# How Our Prompt Cache Is Built

Online test: a single opus request prompt has **49310** tokens, of which **47354** are directly read back from the cache, with a hit rate of **96%**. Among nearly 100 requests, 74 hits occurred.

This document is not about "what prompt caching is," but rather **how we specifically split the request into several blocks, what each block contains, and why splitting it this way leads to such a stable high hit rate**.

---

## Core Idea: Split the Request into "Changing" and "Unchanging" Parts

The cache is a **prefix match**. It compares from the first byte; as soon as one byte differs from last time, everything from that point on is invalidated and recalculated.

So the only thing we do is split the entire request into blocks, ordered from "least changing → most changing," only tagging the front unchanging blocks with cache marks, and pushing all changing parts to the end.

The high hit rate is not because of any black magic, but because **our cached prefix truly does not change byte by byte**.

---

## Our Block Layout (BP1 → BP4)

Anthropic allows up to 4 cache breakpoints per request. We allocate them as follows:

```
═══ system blocks（每块单独挂 cache_control）═══

  ┌─────────────────────────────────────────────┐
  │ BP1  人设 + 语言规则 + 工具说明 + 长期记忆    │  几乎永不动
  ├─────────────────────────────────────────────┤
  │ BP2  每日内容（gateway-bp2-daily.txt）       │  一天换一次
  ├─────────────────────────────────────────────┤
  │ BP3  当前会话压缩摘要（这个 session 专属）    │  约 80K token 触发一次压缩
  └─────────────────────────────────────────────┘

═══ messages 数组 ═══

  ...历史轮次（一字不改）...
  ┌─────────────────────────────────────────────┐
  │ BP4  倒数第二条 user 消息挂标（rolling）      │  把全部历史纳进缓存
  └─────────────────────────────────────────────┘
  <gateway_volatile_context> 动态注入            ← 不挂标，所有会变的塞这里
  当前这条 user 消息
```

### Why Each Block Is Placed This Way

**BP1 — The most stable foundation.** Character settings, language rules, tool manuals, long-term memory—these almost never change and are placed at the very front. If this changes, everything behind it becomes useless, so it must be the most stable part of the entire request.

**BP2 — The layer updated daily.** Read from `gateway-bp2-daily.txt`, updated once per day. Changes here only affect BP2 and beyond, leaving BP1 unchanged.

**BP3 — The compressed summary of this session itself.** Key point: it is **session-only**, not a global long-term skeleton. When the current window reaches about 80K tokens, compression triggers, condensing old context into a summary. Note that only the "gateway-side stable summary" gets tagged into BP3; the front-end’s **per-round changing current window summary does not get tagged**, it goes directly into the dynamic area below to avoid rebuilding the cache each round.

**BP4 — The rolling breakpoint, where the most savings happen.** By default, the cache boundary ends at the system message; historical conversations are not cached. We add a tag on the **second-to-last user message** to extend the cache boundary downward to include all history. In multi-round long sessions, tokens from the first dozens of rounds become all cache reads, which accounts for 96% cache hits.

Tagging the "second-to-last" rather than the "last" is because the last user message is the new input each round and always changes, so tagging it is like not tagging at all. Tagging the second-to-last message means the cache boundary stops exactly at "all content before this round."

### Where Do Changing Things Go

Timestamp, memory recall for this round, temporary notes, front-end current window summary—all packed into a pseudo user message after BP4:

```
<gateway_volatile_context>仅供参考，勿复述：
（当前时间 / 本轮召回的记忆 / 摘要 / 纸条……）
</gateway_volatile_context>
```
It changes every round, but it is placed **after all breakpoints**, so no matter how it changes, it does not touch the cache prefix. This is the most critical cut in the entire design: **isolate volatile content outside the cache boundary**.

---

## Keeping requests stuck to the same backend: user_id

Just setting `cache_control` is not enough. The intermediate load balancer randomly dispatches requests to different backend nodes; if the cache is written on node A, the next request going to node B cannot read it, resulting in "write-only, read never, hit rate always 0."

Our solution: the request top layer is fixed with


```json
"metadata": { "user_id": "sillage-anan-stable" }
```
Fixed string, let the sticky route always stick this conversation to the same backend. Without this, all previous breakpoints are wasted.

---

## Different Channels, Different Attachment Methods

Not every upstream uses the same setup. The gateway automatically determines based on the upstream domain, dividing into three modes:

| Mode | Upstream | Protocol | Where to attach cache_control | TTL |
|---|---|---|---|---|
| `anthropic-bp` | Direct Anthropic / msui / Jinguagua | `/v1/messages` | On system blocks | 1h (Jinguagua only supports 5m) |
| `or-blocks` | OpenRouter | OAI `/chat/completions` | Embedded in messages' content block | 1h |
| `oai-passthrough` | Normal OAI relay / Unknown sites | OAI | Not attached, let the site implicitly cache | Uncontrollable |

The sticky mechanisms for the two main paths differ, **never mix them**:

- **Anthropic native path** sticks backend by `metadata.user_id`.
- **OpenRouter path** does not check user_id; it sticks backend based on `hash(system first part + first non-system message)`. So changing the persona, switching the world book, or tweaking the opening line changes the hash, invalidating the cache for that round. Opening lines and personas on OR must be fixed.

Also, some sites (e.g., ekan) directly return 4xx for `cache_control`. The gateway writes these error hosts into a blacklist file and permanently downgrades them to non-cached passthrough, avoiding repeated 400 errors. This is self-healing, no manual intervention needed.

---

## 5min or 1h

| TTL | Write Cost | Read Cost | Use Case |
|---|---|---|---|
| 5min | 1.25x | 0.1x | Continuous rapid dialogue |
| 1h | 2x | 0.1x | Coming back after half an hour to continue, very reliable |

Read cost is always 0.1x (10 times saving). The difference is only how expensive writes are and how long it can be stored. We use 5m for rapid consecutive messages, and 1h for long sessions returning after a break.

---

## How to Confirm a Hit

Check response usage:

- Anthropic native: `usage.cache_read_input_tokens` (read) / `cache_creation_input_tokens` (write)

- OAI Compatible: `usage.prompt_tokens_details.cached_tokens`

Judgment:

- First round read=0, write a large amount → Normal, building cache
- From the second round read is non-zero → **Cache hit**
- Always read=0 write=0 → cache_control did not take effect at all, failure
- Always write only no read → Routing drifted (user_id not included / OR hash changed)

Check the gateway logs:

```bash
pm2 logs chat-gateway-proxy | grep -E "HIT|MISS"
```
- `HIT 96% (47354/49310)` ← Our current status  
- `MISS (created 0)` ← Fault, neither written nor read  

Monitoring page: `https://catcatty.uk/llm/cache-stats`  

---  

## The iron rules we have discovered  

1. **The system must separate "stable segment + dynamic segment"**, only the stable segment gets tagged. Even a single phrase like "18:00 tonight" in BP1 will immediately invalidate the entire cache.  
2. **All variable parts must be placed after BP4**, dumped into `gateway_volatile_context`. Time, memory recall, temporary summaries—none should remain in the prefix.  
3. **`user_id` is fixed and unchanging**, if absent, only write, no read.  
4. **Add rolling tags to the last user** (attached to the penultimate entry), incorporating history into the cache to save the most on long sessions.  
5. **History is read-only, do not retry rewriting previous turns**. "Regenerate previous entry" changes the prefix and rebuilds the entire segment.  
6. **Tool schema order is fixed**. Dynamically rearranging the tool list by toggling = full segment miss.  
7. **Lock user persona and opening lines via OR**, it relies on hash binding to the backend; any change counts as a new conversation.  

Follow these seven rules, then choose the correct `mode` and `ttl` upstream. Our 96% hit rate comes from this.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-13

---
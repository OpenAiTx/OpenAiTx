<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# claude.sh

Claude Code-টো পুনৰ লিখা হৈছে এটা bash script হিচাপে। ~১,৫০০ শাৰী। একো npm পেকেজ নাই।

## কিয়

মূল Claude Code-টো হৈছে ~৩৮০,০০০ শাৰী TypeScript আৰু ২৬৬টা npm নিৰ্ভৰশীলতা। এইটো সেই একে মূল কামটোৱেই কৰে bash-ত কেৱল `curl` আৰু `jq` ব্যৱহাৰ কৰি।


## বৈশিষ্ট্যসমূহ

- **ৰিয়েল-টাইম ষ্ট্ৰিমিং** FIFO পাইপৰ জৰিয়তে — টেক্স্ট ক্লডে সৃষ্টি কৰাৰ লগে লগে দেখা যায়
- **৬টা টুল**: বাশ, ৰিড, এডিট, ৰাইট, গ্লব, গ্ৰেপ
- **টুল চেইনিং** — প্ৰতি টাৰ্নত ২৫টা টুল কলৰ সৰ্বাধিক সীমা
- **অনুমতি প্ৰম্পটিং** — নিৰাপদ নহোৱা কমাণ্ড চলোৱাৰ আগতে সোধে (`y/n/a`)
- **CLAUDE.md লোডিং** — ডিৰেক্টৰী ট্ৰি ওপৰলৈ CLAUDE.md ফাইলৰ পৰা প্ৰজেক্ট নিৰ্দেশনা পঢ়ে
- **Git-সচেতন কনটেক্সট** — শাখা, অৱস্থা, আৰু সাম্প্ৰতিক কমিটসমূহ ছিষ্টেম প্ৰম্প্টত
- **চেছন সংৰক্ষণ/পুনৰুদ্ধাৰ** — বাহিৰ হোৱাৰ সময়ত স্বয়ংক্ৰিয় সংৰক্ষণ, `--resume <id>` দিয়ে পুনৰুদ্ধাৰ
- **বেকঅফ সহ ৰিট্ৰাই** — 429/529 ৰেট লিমিটত এক্সপ’নেনশিয়েল ৰিট্ৰাই
- **খৰচ অনুগমন** — প্ৰতি টাৰ্ন আৰু চেছন মুঠ খৰচ
- **স্পিনাৰ** — মূল স্পিনাৰ শব্দসমূহৰ সৈতে (Clauding, Flibbertigibbeting, আদি)
- **স্লেছ কমাণ্ড** — `/help`, `/cost`, `/model`, `/clear`, `/save`, `/resume`, `/commit`, `/diff`
- **Pipe ম'ড** — `echo "explain this" | ./claude.sh`

## ইনষ্টল

```bash
git clone https://github.com/jdcodes1/claude.sh.git
cd claude.sh
chmod +x claude.sh
```

## নিৰ্ভৰশীলতা

- `curl`
- `jq`
- বিকল্প: উন্নত সন্ধানৰ বাবে `rg` (ripgrep)
- বিকল্প: সম্পাদনা উপকৰণৰ বাবে `python3`

ৰানটাইম সংস্কৰণসমূহ `.tool-versions`-ত স্থিৰ কৰা হৈছে। এইবোৰ [mise](https://mise.jdx.dev/) ব্যৱহাৰ কৰি ইনষ্টল কৰক:

```bash
mise install
```

## ব্যৱহাৰ

```bash
export ANTHROPIC_API_KEY="sk-ant-..."
./claude.sh
```

### পৰিৱেশ পৰিবৰ্তনশীল

| পৰিবৰ্তনশীল | অবিকল্পিত | বিৱৰণ |
| --- | --- | --- |
| `ANTHROPIC_API_KEY` | (আৱশ্যক) | আপোনাৰ Anthropic API চাবি |
| `CLAUDE_MODEL` | `claude-sonnet-4-6` | ব্যৱহাৰ কৰিবলগীয়া মডেল |
| `CLAUDE_MAX_TOKENS` | `8192` | সৰ্বাধিক আউটপুট টোকেন |
| `ANTHROPIC_API_URL` | `https://api.anthropic.com` | API বেছ URL |
| `CLAUDE_SH_PERMISSIONS` | `ask` | অনুমতি ম'ড: `ask`, `allow`, বা `deny` |

### নিৰ্দেশনা

```txt
/help      — Show help
/cost      — Show session cost
/model     — Show/change model
/clear     — Clear conversation
/save      — Save current session
/resume    — List/resume saved sessions
/commit    — Auto-generate a git commit
/diff      — Show git diff
/quit      — Exit
```

### এটা ছেছন পুনৰ আৰম্ভ কৰক

```bash
# List saved sessions
./claude.sh
> /resume

# Resume by number
> /resume 1

# Resume from CLI
./claude.sh --resume 20240101-120000-12345
```

## স্থাপত্য

```txt
claude.sh          # Main REPL loop, slash commands, process_turn()
lib/
  api.sh           # Anthropic API client, SSE streaming via FIFO, retry
  json.sh          # Message construction, session persistence, CLAUDE.md, git context
  tools.sh         # 6 tool implementations + permission system
  tui.sh           # ANSI colors, spinner, display helpers
```

## এইটো কেনেকৈ কাম কৰে

1. ব্যৱহাৰকাৰীৰ ইনপুট পঢ়ক
2. `jq` ৰ সহায়ত JSON অনুৰোধ নিৰ্মাণ কৰক (বার্তা, সঁজুলি, ছিষ্টেম প্ৰম্পট)
3. উত্তৰক `curl` ৰ জৰিয়তে এটা FIFO পাইপত ষ্ট্ৰীম কৰক
4. SSE ঘটনাসমূহ লাইন-কে-লাইন পাৰ্ছ কৰক, ৰিয়েল-টাইমত টেক্সট ডেল্টা প্ৰকাশ কৰক
5. tool_use ব্লক আহিলে, সঁজুলিসমূহ কার্যকৰ কৰক
6. সঁজুলিৰ ফলাফল পুনৰ বার্তা হিচাপে পঠিয়াওক
7. Claude এ সঁজুলি ব্যৱহাৰ বন্ধ নকৰে পৰ্যন্ত এইটো পুনৰাবৃত্তি কৰক

## তুলনা

| | claude.sh | Claude Code (TypeScript) |
| --- | --- | --- |
| কোডৰ লাইন | ~1,500 | ~380,000 |
| নিৰ্ভৰশীলতা | curl, jq | 266 টা npm পেকেজ |
| বিনাৰী আকাৰ | 0 (স্ক্ৰিপ্ট) | ~200MB node_modules |
| আৰম্ভণিৰ সময় | তৎক্ষণাৎ | ~500ms |

### পৰীক্ষা

পৰীক্ষাসমূহে [bats](https://github.com/bats-core/bats-core) (Bash Automated Testing System) ব্যৱহাৰ কৰে:

```bash
bats test/
```

## License

[MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-14

---
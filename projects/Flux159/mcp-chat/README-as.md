# mcp-chat

<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=hi">হिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

টেস্ট আৰু মূল্যায়নৰ বাবে মুক্ত উৎসৰ সাধাৰণ MCP ক্লায়েন্ট, mcp ছাৰ্ভাৰ আৰু এজেন্টসমূহৰ বাবে

<p align="center">
  <img width="600" src="https://raw.githubusercontent.com/Flux159/mcp-chat/refs/heads/main/mcpchat.svg">
</p>


## কুইকষ্টাৰ্ট

নিশ্চিত কৰক যে আপোনাৰ পৰিৱেশত বা প্ৰকল্পৰ মূল .env ফাইলত `ANTHROPIC_API_KEY` এক্সপোৰ্ট কৰা আছে। আপুনি [Anthropic Console keys page](https://console.anthropic.com/settings/keys) ত সাইন আপ কৰি API key পাব পাৰে।

এটা সাধাৰণ ব্যৱহাৰ য'ত CLIৰ পৰা ফাইলচিষ্টেম MCP ছাৰ্ভাৰৰ সৈতে এটা ইণ্টাৰেক্টিভ চেট প্ৰম্প্ট আৰম্ভ কৰা হয়:

```shell
npx mcp-chat --server "npx -y @modelcontextprotocol/server-filesystem /Users/$USER/Desktop"
```

এইটো এটা চেট প্ৰম্পট খুলিব যি আপোনীয়ে ছাৰ্ভাৰসমূহৰ সৈতে যোগাযোগ কৰিবলৈ আৰু এজন LLM-ৰ সৈতে চেট কৰিবলৈ ব্যৱহাৰ কৰিব পাৰে।

## কনফিগ

আপুনি আপোনাৰ claude_desktop_config.json (Mac) নিৰ্দিষ্ট কৰিবও পাৰে:

```shell
npx mcp-chat --config "~/Library/Application Support/Claude/claude_desktop_config.json"
```

অথবা (Windows):

```shell
npx mcp-chat --config "%APPDATA%\Claude\claude_desktop_config.json"
```

## Web mode

https://github.com/user-attachments/assets/b7e8a648-8084-4955-8cdf-fc6eb141572e

You can also run mcp-chat in web mode by specifying the `--web` flag (make sure to have `ANTHROPIC_API_KEY` exported in your environment):

```shell
npx mcp-chat --web
```

ৱেব মোডত, আপুনি নতুন চেট আৰম্ভ কৰিব পাৰে, মডেললৈ বাৰ্তা প্ৰেৰণ কৰিব পাৰে, আৰু UI-ৰ জৰিয়তে mcp ছাৰ্ভাৰসমূহ ডাইনেমিকভাৱে কনফিগাৰ কৰিব পাৰে - কমাণ্ড লাইনৰ জৰিয়তে উল্লেখ কৰাৰ প্ৰয়োজন নাই। ইয়াৰ উপৰিও, ৱেব UI-ৰ জৰিয়তে সৃষ্টি কৰা চেটসমূহ ~/.mcpchats/chats-ত সংৰক্ষণ কৰা হয়, CLI-ৰ জৰিয়তে সৃষ্টি কৰা চেটসমূহৰ দৰে।

## বৈশিষ্ট্যসমূহ

- [x] CLI-ৰ জৰিয়তে ইণ্টাৰেক্টিভ মোডত চলাওক বা `-p` ব্যৱহাৰ কৰি প্ৰম্প্ট পঠিয়াওক
- [x] ৱেব মোডৰ জৰিয়তে ৱেব ইণ্টাৰফেছত মডেলৰ সৈতে চেট কৰক `--web`
- [x] যিকোনো MCP ছাৰ্ভাৰৰ সৈতে সংযোগ কৰক (JS, Python, Docker) প্ৰডাকশন অথবা ডেভেলপমেণ্টত
- [x] `-m` ব্যৱহাৰ কৰি মডেলৰ মাজত বাছনি কৰক
- [x] `--system` ব্যৱহাৰ কৰি চিষ্টেম প্ৰম্প্ট কাষ্টমাইজ কৰক
- [x] `~/.mcpchat/chats`-ত সংৰক্ষণ কৰক চেট ইতিহাস আৰু ছেটিংছ, ৱেব চেটসহ
- [x] `~/.mcpchat/history`-ত সংৰক্ষণ আৰু পুনৰুদ্ধাৰ কৰক কমাণ্ডসমূহ
- [x] চেটতেই টুল কল আউটপুট আৰু আৰ্গুমেণ্ট চাওক, mcp ছাৰ্ভাৰসমূহ ডিবাগ কৰিবলৈ সহায় কৰে

## CLI ব্যৱহাৰ

CLI-ৰ জৰিয়তে `-p` ফ্লেগ ব্যৱহাৰ কৰি প্ৰম্প্ট চলাওক:

```shell
npx mcp-chat --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

এইটো kubernetes mcp-server সৈতে prompt চলায় আৰু stdout-ত response পোৱাৰ পাছত ওলাই যায়।

CLI-ৰ জৰিয়তে চেট কৰিবলৈ এটা মডেল `-m` পতাকা ব্যৱহাৰ কৰি নিৰ্বাচন কৰক:

```shell
npx mcp-chat --server "npx mcp-server-kubernetes" -m "claude-3.5"
```

মডেল `claude-3.5` ব্যৱহাৰ কৰি চেট কৰে। মনত ৰাখিব যে বৰ্তমান Anthropic মডেলসমূহহে সমৰ্থিত।

কাষ্টম ছিষ্টেম প্ৰম্প্ট:

`--system` ফ্লেগ ব্যৱহাৰ কৰি এটা ছিষ্টেম প্ৰম্প্ট উল্লেখ কৰিব পাৰি:

```shell
npx mcp-chat --system "Explain the output to the user in pirate speak." --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

## ENV ভেৰিয়েবলসমূহ

Mcp-chat এ env ভেৰিয়েবলসমূহক mcp ছাৰ্ভাৰলৈ পঠিয়াবলৈ সমৰ্থন কৰে। এইটো mcp স্পেকত মানকীকৃত নহয় আৰু আন ক্লায়েন্টসমূহে ডাইনেমিক env ভেৰিয়েবল মানসমূহৰ সৈতে এইটো নকৰিব পাৰে - অধিক পঢ়ক [এতিয়া](https://github.com/Flux159/mcp-server-kubernetes/issues/148#issuecomment-2950181666) standard stdio mcp ক্লায়েন্টসমূহৰ বিষয়ে।

```shell
KUBECONFIG="~/.kube/config" npx mcp-chat --server "npx mcp-server-kubernetes"
```

## mcp-servers ৰ ডেভেলপাৰসকলৰ বাবে

আপুনি mcp-chatৰ সৈতে পৰীক্ষা কৰিবলৈ python বা node mcp-server ৰ এটা স্থানীয় বিল্ড pass কৰিব পাৰে:

Node JS:

```shell
# Directly executing built script
npx mcp-chat --server "/path/to/mcp-server-kubernetes/dist/index.js"
# Using node / bun
npx mcp-chat --server "node /path/to/mcp-server-kubernetes/dist/index.js"
```

পাইথন:

```shell
# Python: Using uv
npx mcp-chat --server "uv --directory /path/to/mcp-server-weather/ run weather.py"
# Using python / python3 - make sure to run in venv or install deps globally
npx mcp-chat --server "/path/to/mcp-server-weather/weather.py"
```

## বিকাশ

নিবৰ্ভৰতা সমূহ সংস্থাপন কৰক আৰু CLI চলাও:

```shell
git clone https://github.com/Flux159/mcp-chat
bun install
bun run dev
```

mcp-chat উন্নয়ন কৰিবলৈ যেতিয়া mcp-server লগত সংযোগ কৰা হৈছে, এটা বিল্ড কৰক আৰু CLI টো server পতাকা সহ চলাও:

```shell
npm run build && node dist/index.js --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

পৰীক্ষণ:

```shell
bun run test
```

নির্মাণ:

```shell
bun run build
```
প্ৰকাশনা:


```shell
bun run publish
```

ডকাৰ প্ৰকাশ:

```shell
bun run dockerbuild
```

### প্ৰকল্পৰ গঠন

```
├── src/
│   ├── index.ts            # Main client implementation & CLI params
│   ├── constants.ts        # Default constants
│   ├── interactive.ts      # Interactive chat prompt handling & logic
├── test/                   # Test files
│   ├── cli.test.ts         # Test CLI params
│   ├── config.test.ts      # Test config file parsing
```

## নতুন সংস্কৰণ প্ৰকাশ কৰা

[releases](https://github.com/Flux159/mcp-chat/releases) পৃষ্ঠাত যাওক, "Draft New Release"ত ক্লিক কৰক, "Choose a tag"ত ক্লিক কৰক আৰু "v{major}.{minor}.{patch}" semver ফৰ্মেট ব্যৱহাৰ কৰি এটা নতুন সংস্কৰণ নম্বৰ টাইপ কৰি এটা নতুন tag সৃষ্টি কৰক। তাৰপিছত, "Release v{major}.{minor}.{patch}" শিৰোনাম আৰু প্ৰয়োজন হলে বিৱৰণ / changelog লিখক আৰু "Publish Release"ত ক্লিক কৰক।

এইটো এটা নতুন tag সৃষ্টি কৰিব যি cd.yml workflowৰ জৰিয়তে নতুন release build আৰম্ভ কৰিব। সফল হ'লে, নতুন release npmত প্ৰকাশিত হব। মনত ৰাখিব যে package.json version manually আপডেট কৰাৰ প্ৰয়োজন নাই, কাৰণ workflow-এ স্বয়ংক্ৰিয়ভাৱে package.json ফাইলত version number আপডেট কৰিব আৰু mainত এটা commit push কৰিব।

## অনুমতি পত্ৰ

[MIT License](https://github.com/Flux159/mcp-chat/blob/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-16

---
<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
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

Claude कोड को एक bash स्क्रिप्ट के रूप में पुनः लिखा गया है। ~1,500 पंक्तियाँ। कोई भी npm पैकेज नहीं।

## क्यों

मूल Claude कोड लगभग 380,000 पंक्तियों का TypeScript है जिसमें 266 npm निर्भरताएँ हैं। यह वही मुख्य कार्य bash में केवल `curl` और `jq` के साथ करता है।


## विशेषताएँ

- **रियल-टाइम स्ट्रीमिंग** FIFO पाइप के माध्यम से — टेक्स्ट Claude द्वारा जनरेट होते ही दिखता है
- **6 टूल्स**: Bash, Read, Edit, Write, Glob, Grep
- **टूल चेनिंग** — प्रति टर्न 25 टूल कॉल तक
- **परमिशन प्रॉम्प्टिंग** — गैर-सुरक्षित कमांड चलाने से पहले पूछता है (`y/n/a`)
- **CLAUDE.md लोडिंग** — प्रोजेक्ट निर्देशों को CLAUDE.md फाइलों से डायरेक्टरी ट्री में ऊपर पढ़ता है
- **Git-अवेयर कॉन्टेक्स्ट** — ब्रांच, स्टेटस और हाल की कमिट्स सिस्टम प्रॉम्प्ट में
- **सेशन सेव/रिज़्यूम** — बाहर निकलते समय ऑटो-सेव, `--resume <id>` के साथ रिज़्यूम करें
- **बैकऑफ के साथ रिट्राई** — 429/529 रेट लिमिट पर एक्सपोनेंशियल रिट्राई
- **कॉस्ट ट्रैकिंग** — प्रति टर्न और सेशन कुल लागत
- **स्पिनर** — मूल स्पिनर क्रियाओं के साथ (Clauding, Flibbertigibbeting, आदि)
- **स्लैश कमांड** — `/help`, `/cost`, `/model`, `/clear`, `/save`, `/resume`, `/commit`, `/diff`
- **पाइप मोड** — `echo "explain this" | ./claude.sh`

## इंस्टॉल

```bash
git clone https://github.com/jdcodes1/claude.sh.git
cd claude.sh
chmod +x claude.sh
```

## निर्भरताएँ

- `curl`
- `jq`
- वैकल्पिक: बेहतर खोज के लिए `rg` (ripgrep)
- वैकल्पिक: संपादन टूल के लिए `python3`

रनटाइम संस्करण `.tool-versions` में पिन किए गए हैं। इन्हें [mise](https://mise.jdx.dev/) से इंस्टॉल करें:

```bash
mise install
```

## उपयोग

```bash
export ANTHROPIC_API_KEY="sk-ant-..."
./claude.sh
```

### पर्यावरण वेरिएबल्स

| वेरिएबल | डिफ़ॉल्ट | विवरण |
| --- | --- | --- |
| `ANTHROPIC_API_KEY` | (आवश्यक) | आपका Anthropic API कुंजी |
| `CLAUDE_MODEL` | `claude-sonnet-4-6` | उपयोग हेतु मॉडल |
| `CLAUDE_MAX_TOKENS` | `8192` | अधिकतम आउटपुट टोकन |
| `ANTHROPIC_API_URL` | `https://api.anthropic.com` | एपीआई बेस यूआरएल |
| `CLAUDE_SH_PERMISSIONS` | `ask` | अनुमति मोड: `ask`, `allow`, या `deny` |

### कमांड्स

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

### सत्र को फिर से शुरू करें

```bash
# List saved sessions
./claude.sh
> /resume

# Resume by number
> /resume 1

# Resume from CLI
./claude.sh --resume 20240101-120000-12345
```

## वास्तुकला

```txt
claude.sh          # Main REPL loop, slash commands, process_turn()
lib/
  api.sh           # Anthropic API client, SSE streaming via FIFO, retry
  json.sh          # Message construction, session persistence, CLAUDE.md, git context
  tools.sh         # 6 tool implementations + permission system
  tui.sh           # ANSI colors, spinner, display helpers
```

## यह कैसे काम करता है

1. उपयोगकर्ता इनपुट पढ़ें
2. `jq` के साथ JSON अनुरोध बनाएं (messages, tools, system prompt)
3. प्रतिक्रिया को FIFO पाइप के माध्यम से `curl` से स्ट्रीम करें
4. SSE घटनाओं को लाइन-दर-लाइन पार्स करें, टेक्स्ट डेल्टा को रियल-टाइम में प्रिंट करें
5. जब tool_use ब्लॉक्स आएं, टूल्स को निष्पादित करें
6. टूल के परिणामों को संदेश के रूप में वापस भेजें
7. लूप करें जब तक Claude टूल्स को कॉल करना बंद न कर दे

## तुलना

| | claude.sh | Claude कोड (TypeScript) |
| --- | --- | --- |
| कोड की लाइनें | ~1,500 | ~380,000 |
| निर्भरता | curl, jq | 266 npm पैकेज |
| बाइनरी आकार | 0 (स्क्रिप्ट) | ~200MB node_modules |
| स्टार्टअप समय | त्वरित | ~500ms |

### परीक्षण

परीक्षण [bats](https://github.com/bats-core/bats-core) (Bash स्वचालित परीक्षण प्रणाली) का उपयोग करते हैं:

```bash
bats test/
```

## License

[MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-14

---
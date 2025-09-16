# mcp-chat

<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=hi">हिन्दी</a>
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

मुक्त स्रोत सामान्य एमसीपी क्लाइंट, जो एमसीपी सर्वर और एजेंट का परीक्षण एवं मूल्यांकन करने के लिए है

<p align="center">
  <img width="600" src="https://raw.githubusercontent.com/Flux159/mcp-chat/refs/heads/main/mcpchat.svg">
</p>


## त्वरित प्रारंभ

सुनिश्चित करें कि आपने अपने वातावरण में या प्रोजेक्ट की रूट में .env फ़ाइल में `ANTHROPIC_API_KEY` निर्यात किया है। आप [Anthropic Console keys page](https://console.anthropic.com/settings/keys) पर साइन अप करके एक API कुंजी प्राप्त कर सकते हैं।

सरल उपयोग केस जो CLI से फाइल सिस्टम MCP सर्वर के साथ एक इंटरैक्टिव चैट प्रॉम्प्ट शुरू करता है:

```shell
npx mcp-chat --server "npx -y @modelcontextprotocol/server-filesystem /Users/$USER/Desktop"
```

यह एक चैट प्रॉम्प्ट खोलेगा जिसका उपयोग आप सर्वर से इंटरैक्ट करने और LLM के साथ चैट करने के लिए कर सकते हैं।

## कॉन्फ़िग

आप केवल अपना claude_desktop_config.json भी निर्दिष्ट कर सकते हैं (Mac):

```shell
npx mcp-chat --config "~/Library/Application Support/Claude/claude_desktop_config.json"
```

या (विंडोज़):

```shell
npx mcp-chat --config "%APPDATA%\Claude\claude_desktop_config.json"
```

## Web mode

https://github.com/user-attachments/assets/b7e8a648-8084-4955-8cdf-fc6eb141572e

You can also run mcp-chat in web mode by specifying the `--web` flag (make sure to have `ANTHROPIC_API_KEY` exported in your environment):

```shell
npx mcp-chat --web
```

वेब मोड में, आप नई चैट शुरू कर सकते हैं, मॉडल को संदेश भेज सकते हैं, और UI के माध्यम से mcp सर्वर को डायनामिक रूप से कॉन्फ़िगर कर सकते हैं - कमांड लाइन पर निर्दिष्ट करने की आवश्यकता नहीं है। इसके अलावा, वेब UI के माध्यम से बनाई गई चैट CLI के माध्यम से बनाई गई चैट की तरह ही ~/.mcpchats/chats में सहेजी जाती हैं।

## विशेषताएँ

- [x] CLI के माध्यम से इंटरएक्टिव मोड में चलाएँ या `-p` के साथ सीधे प्रॉम्प्ट पास करें
- [x] वेब मोड के माध्यम से वेब इंटरफेस से मॉडल से चैट करें `--web`
- [x] किसी भी MCP सर्वर (JS, Python, Docker) से प्रोडक्शन या डेवलपमेंट में कनेक्ट करें
- [x] मॉडल के बीच चयन करें `-m`
- [x] सिस्टम प्रॉम्प्ट को कस्टमाइज़ करें `--system`
- [x] सेटिंग्स सहित चैट हिस्ट्री को `~/.mcpchat/chats` में सेव करता है, जिसमें वेब चैट भी शामिल हैं
- [x] कमांड को सेव और पुनर्स्थापित करें `~/.mcpchat/history` में
- [x] mcp सर्वर को डिबग करने में सहायता के लिए टूल कॉल आउटपुट और आर्ग्युमेंट्स को चैट में सीधे देखें

## CLI उपयोग

CLI के माध्यम से प्रॉम्प्ट चलाने के लिए `-p` फ्लैग का उपयोग करें:

```shell
npx mcp-chat --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

यह प्रॉम्प्ट को कुबेरनेट्स mcp-server के साथ चलाता है और stdout पर प्रतिक्रिया प्राप्त होने के बाद बाहर निकल जाता है।

CLI के माध्यम से चैट करने के लिए `-m` फ्लैग के साथ एक मॉडल चुनें:

```shell
npx mcp-chat --server "npx mcp-server-kubernetes" -m "claude-3.5"
```

मॉडल `claude-3.5` का उपयोग बातचीत के लिए करता है। ध्यान दें कि वर्तमान में केवल Anthropic मॉडल समर्थित हैं।

कस्टम सिस्टम प्रॉम्प्ट:

`--system` फ्लैग का उपयोग सिस्टम प्रॉम्प्ट को निर्दिष्ट करने के लिए किया जा सकता है:

```shell
npx mcp-chat --system "Explain the output to the user in pirate speak." --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

## ENV वेरिएबल्स

Mcp-chat env वेरिएबल्स को mcp सर्वर तक पास करने का समर्थन करता है। हालांकि यह mcp स्पेसिफिकेशन में मानकीकृत नहीं है और अन्य क्लाइंट्स डायनामिक env वेरिएबल्स के मानों के साथ ऐसा नहीं कर सकते - मानक stdio mcp क्लाइंट्स के बारे में अधिक पढ़ें [यहाँ](https://github.com/Flux159/mcp-server-kubernetes/issues/148#issuecomment-2950181666)।

```shell
KUBECONFIG="~/.kube/config" npx mcp-chat --server "npx mcp-server-kubernetes"
```

## mcp-servers के डेवलपर्स के लिए

आप mcp-chat के साथ परीक्षण करने के लिए python या node mcp-server का लोकल बिल्ड पास कर सकते हैं:

Node JS:

```shell
# Directly executing built script
npx mcp-chat --server "/path/to/mcp-server-kubernetes/dist/index.js"
# Using node / bun
npx mcp-chat --server "node /path/to/mcp-server-kubernetes/dist/index.js"
```

पाइथन:

```shell
# Python: Using uv
npx mcp-chat --server "uv --directory /path/to/mcp-server-weather/ run weather.py"
# Using python / python3 - make sure to run in venv or install deps globally
npx mcp-chat --server "/path/to/mcp-server-weather/weather.py"
```

## विकास

निर्भरता स्थापित करें और CLI चलाएँ:

```shell
git clone https://github.com/Flux159/mcp-chat
bun install
bun run dev
```
एमसीपी-चैट को विकसित करने के लिए जबकि एक एमसीपी-सर्वर से कनेक्ट किया जा रहा है, एक बिल्ड बनाएं और सर्वर फ्लैग के साथ CLI चलाएँ:


```shell
npm run build && node dist/index.js --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

परीक्षण:

```shell
bun run test
```

निर्माण:

```shell
bun run build
```

प्रकाशन:

```shell
bun run publish
```

डॉकर प्रकाशित करना:

```shell
bun run dockerbuild
```

### परियोजना संरचना

```
├── src/
│   ├── index.ts            # Main client implementation & CLI params
│   ├── constants.ts        # Default constants
│   ├── interactive.ts      # Interactive chat prompt handling & logic
├── test/                   # Test files
│   ├── cli.test.ts         # Test CLI params
│   ├── config.test.ts      # Test config file parsing
```

## नया रिलीज़ प्रकाशित करना

[रिलीज़ेस](https://github.com/Flux159/mcp-chat/releases) पृष्ठ पर जाएँ, "Draft New Release" पर क्लिक करें, "Choose a tag" पर क्लिक करें और "v{major}.{minor}.{patch}" सेमवर फॉर्मेट में नया वर्शन नंबर टाइप करके नया टैग बनाएँ। फिर, रिलीज़ टाइटल "Release v{major}.{minor}.{patch}" और आवश्यक होने पर विवरण / चेंजलॉग लिखें और "Publish Release" पर क्लिक करें।

यह एक नया टैग बनाएगा जो cd.yml वर्कफ़्लो के माध्यम से नया रिलीज़ बिल्ड ट्रिगर करेगा। सफल होने पर, नया रिलीज़ npm पर प्रकाशित हो जाएगा। ध्यान दें कि package.json वर्शन को मैन्युअली अपडेट करने की आवश्यकता नहीं है, क्योंकि वर्कफ़्लो स्वचालित रूप से package.json फ़ाइल में वर्शन नंबर अपडेट करेगा और मुख्य शाखा में एक कमिट पुश करेगा।

## लाइसेंस

[MIT लाइसेंस](https://github.com/Flux159/mcp-chat/blob/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-16

---
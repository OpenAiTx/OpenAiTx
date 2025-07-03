# टोम - जादुई एआई स्पेलबुक

<img src="https://raw.githubusercontent.com/runebookai/tome/main/static/images/repo-header.png" alt="Tome" />

<p align="center">
    <code>एक जादुई डेस्कटॉप ऐप जो LLMs और MCP की शक्ति सभी के हाथों में देता है</code>
</p>

<p align="center">
    <a href="https://discord.gg/9CH6us29YA" target="_blank"><img src="https://img.shields.io/discord/1365100902561742868?logo=discord&logoColor=fff&label=Join%20Us!&color=9D7CD8" alt="Join Us on Discord" /></a>
    <a href="https://opensource.org/licenses/Apache-2.0" target="_blank"><img src="https://img.shields.io/badge/License-Apache_2.0-blue.svg" alt="License: Apache 2.0" /></a>
    <a href="https://github.com/runebookai/tome/releases" target="_blank"><img src="https://img.shields.io/github/v/release/runebookai/tome" alt="GitHub Release" /></a>
</p>

<p align="center">
    🔮 टोम डेस्कटॉप ऐप डाउनलोड करें: <a href="https://github.com/runebookai/tome/releases/download/0.6.0/Tome_0.6.0_x64-setup.exe">Windows</a> | <a href="https://github.com/runebookai/tome/releases/download/0.6.0/Tome_0.6.0_aarch64.dmg">MacOS</a>
</p>

# टोम

टोम एक डेस्कटॉप ऐप है जो **किसी को भी** LLMs और MCP की जादूई शक्ति का उपयोग करने देता है। टोम डाउनलोड करें, किसी भी लोकल या रिमोट LLM को कनेक्ट करें और हजारों MCP सर्वरों से जोड़कर अपना खुद का जादुई एआई-संचालित स्पेलबुक बनाएं।

🫥 इसे 100% लोकल, 100% प्राइवेट बनाना चाहते हैं? केवल लोकल MCP सर्वरों के साथ Ollama और Qwen3 का उपयोग करें और अपनी जेब में यूनिवर्स में स्पेल्स कास्ट करें। ⚡ नवीनतम रिमोट MCP सर्वरों के साथ अत्याधुनिक क्लाउड मॉडल चाहिए? वह भी आपके पास है। सब कुछ आपके ऊपर है!

🏗️ यह एक तकनीकी पूर्वावलोकन (Technical Preview) है, इसलिए ध्यान रखें कि इसमें कुछ खामियां हो सकती हैं। [हमारे डिस्कॉर्ड से जुड़ें](https://discord.gg/9CH6us29YA) और अपने सुझाव, ट्रिक्स और समस्याएं साझा करें। अपडेट्स और फीचर रिलीज़ के लिए इस रिपोजिटरी को स्टार करें!

## 🪄 विशेषताएँ

- 🧙 **सरलीकृत शुरुआती-अनुकूल अनुभव**
  - बस टोम डाउनलोड और इंस्टॉल करें और अपनी पसंद के LLM को कनेक्ट करें
  - JSON, Docker, python या node से झंझट नहीं
- 🤖 **एआई मॉडल सपोर्ट**
  - **रिमोट:** Google Gemini, OpenAI, कोई भी OpenAI API-संगत एंडपॉइंट
  - **लोकल:** Ollama, LM Studio, Cortex, कोई भी OpenAI API-संगत एंडपॉइंट
- 🔮 **विस्तारित MCP समर्थन**
  - MCP सर्वरों को इंस्टॉल, हटाने, चालू/बंद करने के लिए UI
  - npm, uvx, node, python MCP सर्वरों का तुरंत समर्थन
- 🏪 **[Smithery.ai](https://smithery.ai) रजिस्ट्ररी में एकीकरण**
  - एक-क्लिक इंस्टॉल के माध्यम से हजारों MCP सर्वर उपलब्ध
- ✏️ **कॉन्टेक्स्ट विंडो और टेम्परेचर का अनुकूलन**
- 🧰 **टूल कॉल्स और रीजनिंग मॉडल के लिए नेटिव सपोर्ट**
  - UI सुधार जो टूल कॉल्स और सोचने के संदेशों को स्पष्ट रूप से दर्शाते हैं

## डेमो

https://github.com/user-attachments/assets/0775d100-3eba-4219-9e2f-360a01f28cce

# शुरू करना

## आवश्यकताएँ

- MacOS या Windows (Linux जल्द आ रहा है!)
- अपनी पसंद का LLM प्रदाता: [Ollama](https://ollama.com/) या [Gemini API key](https://aistudio.google.com/app/apikey) आसान/मुफ्त विकल्प हैं
- [टोम का नवीनतम संस्करण डाउनलोड करें](https://github.com/runebookai/tome/releases)

## क्विकस्टार्ट

1. [टोम इंस्टॉल करें](https://github.com/runebookai/tome/releases)
2. अपने पसंदीदा LLM प्रदाता को कनेक्ट करें - OpenAI, Ollama और Gemini पहले से सेट हैं, लेकिन आप LM Studio जैसे प्रदाता भी http://localhost:1234/v1 URL डालकर जोड़ सकते हैं
3. टोम में MCP टैब खोलें और अपना पहला [MCP सर्वर](https://github.com/modelcontextprotocol/servers) इंस्टॉल करें (Fetch एक आसान विकल्प है, बस `uvx mcp-server-fetch` को सर्वर फील्ड में पेस्ट करें)।
4. अपने MCP-संचालित मॉडल से चैट करें! इसे Hacker News पर टॉप स्टोरी लाने को कहें।

# विजन

हम चाहते हैं कि लोकल LLMs और MCP सभी के लिए सुलभ हों। हम एक ऐसा टूल बना रहे हैं जो आपको LLMs के साथ रचनात्मक होने की स्वतंत्रता देता है, चाहे आप इंजीनियर हों, टिंकरर, हॉबीस्ट, या कुछ भी बीच का।

## मुख्य सिद्धांत

- **टोम सबसे पहले लोकल है:** आप नियंत्रित करते हैं कि आपका डेटा कहाँ जाता है।
- **टोम सभी के लिए है:** आपको प्रोग्रामिंग भाषाएँ, पैकेज मैनेजर या json कॉन्फ़िग फाइलों को संभालने की जरूरत नहीं होनी चाहिए।

## आगे क्या

टोम रिलीज़ के बाद पिछले कुछ हफ्तों में हमें बहुत शानदार फीडबैक मिला है, लेकिन हमारे पास भविष्य के लिए बड़े प्लान हैं। हम LLMs को उनके चैटबॉक्स से बाहर लाना चाहते हैं, और इसके लिए कई फीचर्स ला रहे हैं।

- अनुसूचित कार्य: LLMs को उपयोगी काम करते रहना चाहिए, भले ही आप कंप्यूटर के सामने न हों।
- नेटिव इंटीग्रेशन: MCP सर्वर टूल्स और जानकारी तक पहुँचने का शानदार तरीका हैं, लेकिन हम और भी पावरफुल इंटीग्रेशन जोड़ना चाहते हैं ताकि LLMs के साथ अनूठा इंटरैक्शन हो सके।
- ऐप बिल्डर: हमारा मानना है कि लंबी अवधि में सबसे अच्छे अनुभव चैट इंटरफेस में नहीं होंगे। हम अतिरिक्त टूल्स जोड़ने की योजना बना रहे हैं, जिससे आप शक्तिशाली एप्लिकेशन और वर्कफ्लो बना सकें।
- ??? आप क्या देखना चाहेंगे, हमें बताएं! नीचे दिए गए लिंक्स के माध्यम से हमारे समुदाय से जुड़ें, हमें आपकी राय का इंतजार रहेगा।

# समुदाय

[Discord](https://discord.gg/9CH6us29YA) [Blog](https://blog.runebook.ai) [Bluesky](https://bsky.app/profile/gettome.app) [Twitter](https://twitter.com/get_tome) 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---
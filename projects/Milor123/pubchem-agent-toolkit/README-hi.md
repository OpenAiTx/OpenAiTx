
<div align="center"><p><a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=hi"><img src="https://img.shields.io/badge/हिन्दी-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=fa"><img src="https://img.shields.io/badge/فارسی-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=id"><img src="https://img.shields.io/badge/Bahasa Indonesia-white" alt="version"></a> </p></div>
# AI सहायकों के लिए उन्नत PubChem MCP सर्वर

🧪 एक उन्नत, मजबूत और गोपनीयता-केंद्रित MCP सर्वर जो AI सहायकों को PubChem से रासायनिक यौगिक जानकारी को बुद्धिमानी से खोजने और प्राप्त करने में सक्षम बनाता है।

यह PubChem MCP सर्वर AI सहायकों (जैसे AnythingLLM में) और PubChem के विशाल रासायनिक डेटाबेस के बीच एक शक्तिशाली पुल के रूप में कार्य करता है। यह Model Context Protocol (MCP) का उपयोग करता है जिससे AI मॉडल स्मार्ट, लचीली खोजें कर सकते हैं और रासायनिक यौगिकों के विस्तृत गुण प्रोग्रामेटिक रूप से प्राप्त कर सकते हैं।

---

## ✨ मुख्य विशेषताएँ

यह सिर्फ एक और PubChem रैपर नहीं है। इस सर्वर को पूरी तरह से नए सिरे से बहुत ही मजबूत और बुद्धिमान बनाने के लिए पुनर्निर्मित किया गया है:

-   **🧠 स्मार्ट फ़ॉलबैक खोज**: यदि सामान्य नाम (जैसे "विटामिन D") के लिए खोज विफल होती है, तो सर्वर स्वचालित रूप से PubChem Substance डेटाबेस में गहन खोज करता है ताकि सही यौगिक मिल सके। यह अस्पष्ट प्रश्नों के लिए सफलता दर को काफी बढ़ा देता है।
-   **🛡️ मजबूत त्रुटि हैंडलिंग एवं पुनः प्रयास**: सर्वर API त्रुटियों को सहजता से संभालने के लिए डिज़ाइन किया गया है। यदि PubChem से "सर्वर व्यस्त" त्रुटि मिलती है, तो यह स्वचालित रूप से प्रतीक्षा करता है और अनुरोध को पुनः प्रयास करता है, जिससे आपके प्रश्न भारी लोड में भी सफल होते हैं।
-   **🔒 वैकल्पिक Tor प्रॉक्सी समर्थन**: आपकी गोपनीयता पूरी तरह से आपके नियंत्रण में है। एक साधारण `config.ini` फ़ाइल से आप सभी अनुरोधों को Tor नेटवर्क (SOCKS5 या HTTP प्रॉक्सी के माध्यम से) भेज सकते हैं, जिससे आपका IP पता उजागर नहीं होता। सर्वर डिफ़ॉल्ट रूप से सुरक्षित है और यदि प्रॉक्सी कनेक्शन विफल होता है तो **कभी भी** आपका IP लीक नहीं करेगा।
-   **🔎 एकल और बहु यौगिक खोज**: एक ही प्रॉम्प्ट में एक या एकाधिक यौगिकों के अनुरोधों को सहजता से संभालता है।
-   **🧪 विस्तृत गुण प्राप्ति**: IUPAC नाम, आणविक सूत्र, आणविक भार और विशेष रूप से **Monoisotopic Mass** जैसे प्रमुख रासायनिक गुणों तक पहुँचें।

---

---

### 🚀 इंस्टॉलेशन की आवश्यकता नहीं: Smithery.ai पर लाइव आज़माएँ

जो लोग MCP सर्वर के नए हैं या बिना कोई स्थानीय सेटअप किए इस टूल की क्षमताओं को आज़माना चाहते हैं, उनके लिए Smithery.ai पर लाइव, होस्टेड संस्करण उपलब्ध है। यह आपको सीधे ब्राउज़र में एजेंट से बात करने की सुविधा देता है।

[**<-- Smithery.ai पर लाइव PubChem एजेंट देखें -->**](https://smithery.ai/server/@Milor123/smithery-pubchem-deploy)

**शुरू कैसे करें:**

1.  ऊपर दिए गए लिंक पर क्लिक करके सर्वर पेज पर जाएँ।
2.  अपने **GitHub** या **Google** खाते से साइन इन करें।
3.  **"Explore capabilities"** बटन पर क्लिक करें, चैट इंटरफ़ेस खोलें और परीक्षण शुरू करें!

> **✅ सर्वोत्तम परिणामों के लिए अनुशंसित मॉडल**
>
> उच्चतम सटीकता प्राप्त करने के लिए, विशेषकर लंबे दशमलव अंकों के साथ, हम शक्तिशाली मॉडलों का उपयोग करने की दृढ़ता से सलाह देते हैं। निम्नलिखित का परीक्षण किया गया है और यह टूल के साथ उत्कृष्ट कार्य करते हैं:
>
> *   **Anthropic का Claude 3 Sonnet**

> *   **OpenAI का GPT-4 Turbo** (या GPT-4o जैसे नए संस्करण)
>
> हमने पुष्टि की कि दोनों मॉडल ने टूल द्वारा लौटाए गए दशमलव संख्याओं की पूरी शुद्धता को सही ढंग से प्रोसेस किया, बिना किसी राउंडिंग के।

---

## 🚀 त्वरित शुरुआत और इंस्टॉलेशन

यह सर्वर स्थानीय रूप से चलाने के लिए डिज़ाइन किया गया है, चाहे वह आपके डेस्कटॉप पर हो या AnythingLLM Docker वातावरण के भीतर।

### 1. निर्भरता

यह प्रोजेक्ट कुछ Python लाइब्रेरीज़ पर निर्भर करता है। सुनिश्चित करें कि वे आपके वातावरण में इंस्टॉल हैं।

निम्नलिखित सामग्री के साथ एक `requirements.txt` फाइल बनाएं:
```txt
requests
bs4 
mcp 
pubchempy
pandas
PySocks
```
इन्हें `uv` या `pip` का उपयोग करके इंस्टॉल करें:

```bash
uv venv
.venv\Scripts\activate
uv pip install -r requirements.txt
```
*(नोट: `PySocks` केवल तब आवश्यक है यदि आप Tor SOCKS5 प्रॉक्सी फीचर का उपयोग करने की योजना बना रहे हैं।)*

### 2. विन्यास

सर्वर को एक `config.ini` फ़ाइल के माध्यम से विन्यस्त किया जाता है, जो पहली बार चलाते समय **स्वतः बनाई जाती है**। यह फ़ाइल उसी डायरेक्टरी में दिखाई देगी जहाँ `pubchem_server.py` स्क्रिप्ट है।

**डिफ़ॉल्ट `config.ini`:**
```ini
[proxy]
# Change 'use_proxy' to 'true' to route all requests through a proxy.
# Essential for protecting your privacy if you use Tor.
use_proxy = false

# Defines the proxy type. Options:
#   socks5h  -> (Recommended for Tor) The native SOCKS proxy for Tor. More secure.
#   http     -> An HTTP proxy. If using Tor, requires additional configuration.
proxy_type = socks5h

# The proxy address. THIS IS A CRITICAL SETTING!
#   - If you run this script on your DESKTOP, use: 127.0.0.1
#   - If you run this script inside DOCKER, use: host.docker.internal
host = 127.0.0.1

# The proxy port.
#   9050 -> Default port for Tor's SOCKS proxy.
#   8118 -> Default port for Tor's HTTP proxy (if enabled).
port = 9050
```

### 3. AnythingLLM के साथ एकीकरण

इसे एक कस्टम MCP सर्वर के रूप में जोड़ने के लिए आधिकारिक दस्तावेज़ का पालन करें। मुख्य बात यह है कि `command` को अपने Python निष्पादन योग्य और `pubchem_server.py` स्क्रिप्ट की ओर इंगित करें।

**AnythingLLM डेस्कटॉप के लिए उदाहरण (`plugins/anythingllm_mcp_servers.json`):**
```json
{
  "mcpServers": {
    "pubchem": {
      "name": "PubChem Server (Enhanced)",
      "transport": "stdio",
      "command": "\"C:\\path\\to\\your\\.venv\\Scripts\\python.exe\" \"C:\\path\\to\\your\\project\\pubchem_server.py\"",
      "cwd": "C:\\path\\to\\your\\project"
    }
  }
}
```


### 3.1 AnythingLLM के साथ कार्यान्वयन उदाहरण

यहाँ कुछ उदाहरण दिए गए हैं कि एजेंट के साथ कैसे संवाद किया जाए। ये परीक्षण AnythingLLM Desktop का उपयोग करके किए गए, जिसमें OpenRouter के माध्यम से विभिन्न बड़े भाषा मॉडल्स से जुड़ा गया।

हमारे परीक्षण से एक महत्वपूर्ण निष्कर्ष यह निकला कि आपके द्वारा चुने गए मॉडल का महत्व बहुत अधिक है। हम **इस कार्य के लिए छोटे या स्थानीय मॉडल का उपयोग करने की सख्त सिफारिश नहीं करते हैं**। छोटे मॉडल अक्सर टूल द्वारा लौटाए गए डेटा को सही ढंग से पार्स करने में असफल रहते हैं, जिससे गलतियाँ होती हैं जैसे कि कल्पित मान, गलत स्वरूपण, या सबसे महत्वपूर्ण रूप से **दशमलव संख्याओं को गोल करना**, जिससे इस उच्च-परिशुद्धता टूल का उद्देश्य ही समाप्त हो जाता है।

अपने परिणामों की अखंडता सुनिश्चित करने के लिए, MCP द्वारा लौटाए गए कच्चे डेटा को सत्यापित करना हमेशा एक अच्छा अभ्यास है। आप अगले अनुभाग में जान सकते हैं कि इसे कैसे किया जाता है: [3.2 लॉग्स में MCP आउटपुट कैसे सत्यापित करें](#32-how-to-verify-mcp-outputs-in-the-logs)।

<img width="837" height="1060" alt="imagen" src="https://github.com/user-attachments/assets/5a16c7a2-d65d-4d64-98dd-f3cb4cae9b22" />

दूसरी ओर, कई मॉडल्स ने उत्कृष्ट प्रदर्शन दिखाया है। हमने **Google के `Gemini 2.5 Flash lite`** के साथ शानदार परिणाम प्राप्त किए। इसने लंबे दशमलव अंकों को संभालने में और अंतिम मार्कडाउन तालिका को सही ढंग से स्वरूपित करने में असाधारण सटीकता दिखाई।

Google gemini 2.5 flash lite बिना प्रॉम्प्ट और प्रॉम्प्ट के साथ परिपूर्ण दशमलव बनाए रखता है (उदाहरण में 0.6 तापमान का प्रयोग करें)

<img width="1089" height="1061" alt="imagen" src="https://github.com/user-attachments/assets/4574efa5-d6d9-49e3-a665-a39a427f09a1" />

इस विशिष्ट कार्य के लिए, मेरा व्यक्तिगत पसंदीदा **`Gemini 2.5 Flash lite`** है, इसकी लगातार सटीकता और विश्वसनीयता के कारण।

### 3.2 लॉग्स में MCP आउटपुट्स कैसे सत्यापित करें

यह पुष्टि करने का सबसे अच्छा तरीका कि एजेंट सही डेटा प्राप्त कर रहा है और LLM कोई गलती नहीं कर रहा है, MCP सर्वर द्वारा उत्पन्न डिबग लॉग फ़ाइल की जांच करना है।

यह सर्वर आपके प्रोजेक्ट डायरेक्टरी के भीतर एक सबफोल्डर में स्वतः लॉग फ़ाइल बनाने के लिए कॉन्फ़िगर किया गया है। स्थान होगा:

```
your-project-folder/
└── logs_mcp/
    └── mcp_debug.log
```

`mcp_debug.log` के अंदर, आपको वह सटीक JSON डेटा मिलेगा जिसे टूल LLM को भेजता है *उससे पहले* जब मॉडल इसे प्रोसेस करता है। आप इस JSON का मैन्युअली निरीक्षण कर सकते हैं ताकि किसी भी मान को सत्यापित किया जा सके, विशेष रूप से `monoisotopic_mass` जैसी प्रॉपर्टीज़ के लंबे दशमलव नंबर, यह सुनिश्चित करने के लिए कि LLM ने अपने अंतिम उत्तर में कोई राउंडिंग त्रुटि या कल्पना नहीं जोड़ी है।

---

## 📊 उपयोग

एक बार एकीकृत हो जाने के बाद, आपका AI सहायक स्वचालित रूप से इस टूल का उपयोग करेगा जब रासायनिक जानकारी के बारे में पूछा जाएगा। मुख्य टूल जो एक्सपोज़ किया गया है वह है `search_compounds_by_name`।

### उदाहरण प्रॉम्प्ट

यह प्रॉम्प्ट टूल की क्षमता को प्रदर्शित करता है कि कैसे यह विभिन्न नाम प्रकारों वाली यौगिकों की सूची को संभाल सकता है और कई प्रॉपर्टी प्राप्त कर सकता है।

```
@agent
Please use your PubChem tool to find information on the following compounds:

- Thiamine (Vitamin B1)
- Riboflavin (Vitamin B2)
- Folic Acid
- Hydroxocobalamin

For each compound found, please retrieve the IUPAC Name, Molecular Formula, and Monoisotopic Mass.

Present all the results in a single Markdown table.
```
एजेंट `search_compounds_by_name` टूल को कॉल करेगा, जो प्रत्येक यौगिक को बुद्धिमानी से खोजेगा, उसका डेटा प्राप्त करेगा, और उसे फॉर्मेटिंग के लिए LLM को लौटाएगा।

---

## 🛠 MCP टूल एक्सपोज़्ड

### `search_compounds_by_name`

यह टूल स्मार्ट फॉलबैक रणनीति के साथ, अधिकतम विश्वसनीयता के लिए विराम और पुनः प्रयासों के साथ, एक-एक करके कई यौगिकों के नाम से खोज करता है।

**पैरामीटर्स:**
-   `names` (List[str]): यौगिक नामों की एक सूची। उदाहरण: `["Aspirin", "Ibuprofen"]`

**रिटर्न्स:** डिक्शनरी की एक सूची, जहाँ प्रत्येक डिक्शनरी में या तो प्राप्त यौगिक की जानकारी या उस विशेष यौगिक के लिए खोज विफल होने का कारण देने वाला त्रुटि संदेश होता है।

---

## 🙏 आभार

यह परियोजना मूल [PubChem-MCP-Server](https://github.com/JackKuo666/PubChem-MCP-Server) से प्रेरित है और उसी की नींव पर बनी है, जिसे **JackKuo666** ने बनाया था।

हालाँकि यह रिपॉजिटरी डायरेक्ट फोर्क नहीं है, मूल परियोजना महत्वपूर्ण प्रारंभिक बिंदु थी। यह संस्करण मूल विचार को अत्यधिक मजबूती, बुद्धिमान खोज रणनीतियाँ, और वैकल्पिक Tor एकीकरण 🧅 के माध्यम से उपयोगकर्ता गोपनीयता पर केंद्रित करके बढ़ाता है।

मूल लेखक को उनके शानदार कार्य और इसे समुदाय के साथ साझा करने के लिए बहुत धन्यवाद।

---

## ⚠️ अस्वीकरण

यह टूल अनुसंधान और शैक्षिक उद्देश्यों के लिए है। कृपया PubChem की सेवा शर्तों का सम्मान करें और इस टूल का जिम्मेदारी से उपयोग करें।



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-27

---
# Awesome MCP Servers [![Awesome](https://awesome.re/badge.svg)](https://awesome.re)

[![ไทย](https://img.shields.io/badge/Thai-Click-blue)](README-th.md)
[![English](https://img.shields.io/badge/English-Click-yellow)](README.md)
[![繁體中文](https://img.shields.io/badge/繁體中文-點擊查看-orange)](README-zh_TW.md)
[![简体中文](https://img.shields.io/badge/简体中文-点击查看-orange)](README-zh.md)
[![日本語](https://img.shields.io/badge/日本語-クリック-青)](README-ja.md)
[![한국어](https://img.shields.io/badge/한국어-클릭-yellow)](README-ko.md)
[![Português Brasileiro](https://img.shields.io/badge/Português_Brasileiro-Clique-green)](README-pt_BR.md)
[![Discord](https://img.shields.io/discord/1312302100125843476?logo=discord&label=discord)](https://glama.ai/mcp/discord)
[![Subreddit subscribers](https://img.shields.io/reddit/subreddit-subscribers/mcp?style=flat&logo=reddit&label=subreddit)](https://www.reddit.com/r/mcp/)

एक क्यूरेटेड सूची शानदार मॉडल कॉन्टेक्स्ट प्रोटोकॉल (MCP) सर्वरों की।

* [MCP क्या है?](#what-is-mcp)
* [क्लाइंट्स](#clients)
* [ट्यूटोरियल्स](#tutorials)
* [समुदाय](#community)
* [लीजेंड](#legend)
* [सर्वर इम्प्लीमेंटेशन](#server-implementations)
* [फ्रेमवर्क्स](#frameworks)
* [टिप्स और ट्रिक्स](#tips-and-tricks)

## MCP क्या है?

[MCP](https://modelcontextprotocol.io/) एक ओपन प्रोटोकॉल है जो AI मॉडल्स को स्थानीय और दूरस्थ संसाधनों के साथ सुरक्षित रूप से इंटरैक्ट करने में सक्षम बनाता है, मानकीकृत सर्वर इम्प्लीमेंटेशन के माध्यम से। यह सूची प्रोडक्शन-रेडी और एक्सपेरिमेंटल MCP सर्वरों पर केंद्रित है, जो AI क्षमताओं का विस्तार फाइल एक्सेस, डाटाबेस कनेक्शन, API इंटीग्रेशन, और अन्य कॉन्टेक्स्चुअल सेवाओं के माध्यम से करते हैं।

## क्लाइंट्स

[awesome-mcp-clients](https://github.com/punkpeye/awesome-mcp-clients/) और [glama.ai/mcp/clients](https://glama.ai/mcp/clients) देखें।

> [!TIP]
> [Glama Chat](https://glama.ai/chat) एक मल्टी-मोडल AI क्लाइंट है जिसमें MCP सपोर्ट और [AI गेटवे](https://glama.ai/gateway) है।

## ट्यूटोरियल्स

* [मॉडल कॉन्टेक्स्ट प्रोटोकॉल (MCP) क्विकस्टार्ट](https://glama.ai/blog/2024-11-25-model-context-protocol-quickstart)
* [Claude डेस्कटॉप ऐप को SQLite डाटाबेस के साथ सेटअप करें](https://youtu.be/wxCCzo9dGj0)

## समुदाय

* [r/mcp Reddit](https://www.reddit.com/r/mcp)
* [Discord सर्वर](https://glama.ai/mcp/discord)

## लीजेंड

* 🎖️ – आधिकारिक इम्प्लीमेंटेशन
* प्रोग्रामिंग लैंग्वेज
  * 🐍 – Python कोडबेस
  * 📇 – TypeScript (या JavaScript) कोडबेस
  * 🏎️ – Go कोडबेस
  * 🦀 – Rust कोडबेस
  * #️⃣ - C# कोडबेस
  * ☕ - Java कोडबेस
  * 🌊 – C/C++ कोडबेस
* स्कोप
  * ☁️ - क्लाउड सेवा
  * 🏠 - स्थानीय सेवा
  * 📟 - एम्बेडेड सिस्टम्स
* ऑपरेटिंग सिस्टम
  * 🍎 – macOS के लिए
  * 🪟 – Windows के लिए
  * 🐧 - Linux के लिए

> [!NOTE]
> लोकल 🏠 बनाम क्लाउड ☁️ को लेकर कंफ्यूज हैं?
> * लोकल का उपयोग तब करें जब MCP सर्वर स्थानीय रूप से स्थापित सॉफ़्टवेयर से बात कर रहा हो, जैसे क्रोम ब्राउज़र को नियंत्रित करना।
> * नेटवर्क का उपयोग तब करें जब MCP सर्वर दूरस्थ APIs से बात कर रहा हो, जैसे वेदर API।

## सर्वर इम्प्लीमेंटेशन

> [!NOTE]
> अब हमारे पास एक [वेब-आधारित डायरेक्टरी](https://glama.ai/mcp/servers) है जो रेपो के साथ सिंक होती है।

* 🔗 - [एग्रीगेटर्स](#aggregators)
* 🎨 - [कला और संस्कृति](#art-and-culture)
* 📂 - [ब्राउज़र ऑटोमेशन](#browser-automation)
* ☁️ - [क्लाउड प्लेटफ़ॉर्म्स](#cloud-platforms)
* 👨‍💻 - [कोड निष्पादन](#code-execution)
* 🤖 - [कोडिंग एजेंट्स](#coding-agents)
* 🖥️ - [कमांड लाइन](#command-line)
* 💬 - [संचार](#communication)
* 👤 - [कस्टमर डाटा प्लेटफ़ॉर्म्स](#customer-data-platforms)
* 🗄️ - [डाटाबेस](#databases)
* 📊 - [डाटा प्लेटफ़ॉर्म्स](#data-platforms)
* 🚚 - [डिलीवरी](#delivery)
* 🛠️ - [डेवलपर टूल्स](#developer-tools)
* 🧮 - [डाटा साइंस टूल्स](#data-science-tools)
* 📟 - [एम्बेडेड सिस्टम](#embedded-system)
* 📂 - [फाइल सिस्टम्स](#file-systems)
* 💰 - [वित्त और फिनटेक](#finance--fintech)
* 🎮 - [गेमिंग](#gaming)
* 🧠 - [ज्ञान और मेमोरी](#knowledge--memory)
* 🗺️ - [लोकेशन सेवाएं](#location-services)
* 🎯 - [मार्केटिंग](#marketing)
* 📊 - [मॉनिटरिंग](#monitoring)
* 🎥 - [मल्टीमीडिया प्रोसेस](#multimedia-process)
* 🔎 - [सर्च और डाटा एक्सट्रैक्शन](#search)
* 🔒 - [सुरक्षा](#security)
* 🌐 - [सोशल मीडिया](#social-media)
* 🏃 - [खेल](#sports)
* 🎧 - [सपोर्ट और सेवा प्रबंधन](#support-and-service-management)
* 🌎 - [अनुवाद सेवाएँ](#translation-services)
* 🎧 - [टेक्स्ट-टू-स्पीच](#text-to-speech)
* 🚆 - [यात्रा और परिवहन](#travel-and-transportation)
* 🔄 - [वर्शन नियंत्रण](#version-control)
* 🛠️ - [अन्य उपकरण और एकीकरण](#other-tools-and-integrations)


### 🔗 <a name="aggregators"></a>एग्रीगेटर

एक ही MCP सर्वर के माध्यम से कई ऐप्स और टूल्स तक पहुँचने के लिए सर्वर।

- [julien040/anyquery](https://github.com/julien040/anyquery) 🏎️ 🏠 ☁️ - SQL का उपयोग करके एक बायनरी के साथ 40 से अधिक ऐप्स को क्वेरी करें। यह आपके PostgreSQL, MySQL, या SQLite संगत डेटाबेस से भी कनेक्ट हो सकता है। डिज़ाइन के अनुसार स्थानीय-प्रथम और निजी।
- [metatool-ai/metatool-app](https://github.com/metatool-ai/metatool-app) 📇 ☁️ 🏠 🍎 🪟 🐧 - MetaMCP एक एकीकृत मिडलवेयर MCP सर्वर है जो GUI के साथ आपके MCP कनेक्शनों का प्रबंधन करता है।
- [mindsdb/mindsdb](https://github.com/mindsdb/mindsdb) - विभिन्न प्लेटफार्मों और डेटाबेस में डेटा को कनेक्ट और एकीकृत करें [MindsDB को एकल MCP सर्वर के रूप में](https://docs.mindsdb.com/mcp/overview)।
- [glenngillen/mcpmcp-server](https://github.com/glenngillen/mcpmcp-server) ☁️ 📇 🍎 🪟 🐧 - MCP सर्वरों की एक सूची ताकि आप अपने क्लाइंट से पूछ सकें कि आप कौन से सर्वर का उपयोग कर सकते हैं ताकि आपकी दैनिक कार्यप्रणाली में सुधार हो।
- [wegotdocs/open-mcp](https://github.com/wegotdocs/open-mcp) 📇 🏠 🍎 🪟 🐧 - 10 सेकंड में एक वेब API को MCP सर्वर में बदलें और इसे ओपन सोर्स रजिस्ट्री में जोड़ें: https://open-mcp.org
- [PipedreamHQ/pipedream](https://github.com/PipedreamHQ/pipedream/tree/master/modelcontextprotocol) ☁️ 🏠 - 2,500 APIs के साथ 8,000+ प्रीबिल्ट टूल्स से कनेक्ट करें, और अपने उपयोगकर्ताओं के लिए अपने ही ऐप में सर्वर प्रबंधित करें।
- [VeriTeknik/pluggedin-mcp-proxy](https://github.com/VeriTeknik/pluggedin-mcp-proxy)  📇 🏠 - एक व्यापक प्रॉक्सी सर्वर जो कई MCP सर्वरों को एक एकल इंटरफ़ेस में जोड़ता है जिसमें व्यापक दृश्यता विशेषताएँ हैं। यह सर्वरों में टूल्स, प्रॉम्प्ट, संसाधन, और टेम्प्लेट की खोज और प्रबंधन प्रदान करता है, साथ ही MCP सर्वर बनाते समय डिबगिंग के लिए एक प्लेग्राउंड भी।
- [tigranbs/mcgravity](https://github.com/tigranbs/mcgravity) 📇 🏠 - एक प्रॉक्सी टूल जो कई MCP सर्वरों को एकीकृत एंडपॉइंट में जोड़ता है। अपने AI टूल्स को स्केल करें अनुरोधों को कई MCP सर्वरों के बीच लोड बैलेंस करके, जैसे कि Nginx वेब सर्वरों के लिए करता है।
- [MetaMCP](https://github.com/metatool-ai/metatool-app) 📇 ☁️ 🏠 🍎 🪟 🐧 - MetaMCP एक एकीकृत मिडलवेयर MCP सर्वर है जो GUI के साथ आपके MCP कनेक्शनों का प्रबंधन करता है।
- [WayStation-ai/mcp](https://github.com/waystation-ai/mcp) ☁️ 🍎 🪟 - Claude Desktop और अन्य MCP होस्ट्स को आपके पसंदीदा ऐप्स (Notion, Slack, Monday, Airtable, आदि) से निर्बाध और सुरक्षित रूप से कनेक्ट करें। इसमें 90 सेकंड से भी कम समय लगता है।
- [sxhxliang/mcp-access-point](https://github.com/sxhxliang/mcp-access-point) 📇 ☁️ 🏠 🍎 🪟 🐧 - किसी वेब सेवा को एक क्लिक में MCP सर्वर में बदलें, बिना कोई कोड परिवर्तन किए।
- [hamflx/imagen3-mcp](https://github.com/hamflx/imagen3-mcp) 📇 🏠 🪟 🍎 🐧 - MCP के माध्यम से Google के Imagen 3.0 API का उपयोग करते हुए एक शक्तिशाली इमेज जनरेशन टूल। उन्नत फोटोग्राफी, कलात्मक, और फोटो-यथार्थवादी नियंत्रण के साथ टेक्स्ट प्रॉम्प्ट्स से उच्च गुणवत्ता वाली छवियाँ उत्पन्न करें।
- [SureScaleAI/openai-gpt-image-mcp](https://github.com/SureScaleAI/openai-gpt-image-mcp) 📇 ☁️ - OpenAI GPT इमेज जनरेशन/एडिटिंग MCP सर्वर।

### 🎨 <a name="art-and-culture"></a>कला और संस्कृति

कला संग्रह, सांस्कृतिक विरासत, और संग्रहालय डेटाबेस तक पहुँचें और खोजें। AI मॉडलों को कलात्मक और सांस्कृतिक सामग्री खोजने और विश्लेषण करने में सक्षम बनाता है।

- [abhiemj/manim-mcp-server](https://github.com/abhiemj/manim-mcp-server) 🐍 🏠 🪟 🐧 - Manim का उपयोग कर एनिमेशन जनरेट करने वाला एक स्थानीय MCP सर्वर।
- [burningion/video-editing-mcp](https://github.com/burningion/video-editing-mcp) 🐍 - अपनी वीडियो जंगल कलेक्शन से वीडियो एडिट्स जोड़ें, विश्लेषण करें, खोजें और जनरेट करें।
- [cswkim/discogs-mcp-server](https://github.com/cswkim/discogs-mcp-server) 📇 ☁️ - Discogs API के साथ इंटरैक्ट करने के लिए MCP सर्वर।
- [djalal/quran-mcp-server](https://github.com/djalal/quran-mcp-server) 📇 ☁️ - आधिकारिक REST API v4 के माध्यम से Quran.com कॉर्पस के साथ इंटरैक्ट करने के लिए MCP सर्वर।
- [mikechao/metmuseum-mcp](https://github.com/mikechao/metmuseum-mcp) 📇 ☁️ - मेट्रोपॉलिटन म्यूजियम ऑफ आर्ट कलेक्शन API एकीकरण, संग्रह में कलाकृतियों की खोज और प्रदर्शन के लिए।
- [r-huijts/rijksmuseum-mcp](https://github.com/r-huijts/rijksmuseum-mcp) 📇 ☁️ - Rijksmuseum API एकीकरण, कलाकृति खोज, विवरण और संग्रह के लिए।
- [r-huijts/oorlogsbronnen-mcp](https://github.com/r-huijts/oorlogsbronnen-mcp) 📇 ☁️ - Oorlogsbronnen (युद्ध स्रोत) API एकीकरण, नीदरलैंड्स (1940-1945) से ऐतिहासिक WWII रिकॉर्ड, फोटोग्राफ और दस्तावेज़ों की पहुँच के लिए।
- [samuelgursky/davinci-resolve-mcp](https://github.com/samuelgursky/davinci-resolve-mcp) 🐍 - DaVinci Resolve के लिए MCP सर्वर एकीकरण, वीडियो संपादन, रंग ग्रेडिंग, मीडिया प्रबंधन, और प्रोजेक्ट नियंत्रण के लिए शक्तिशाली टूल्स प्रदान करता है।
- [yuna0x0/anilist-mcp](https://github.com/yuna0x0/anilist-mcp) 📇 ☁️ - एनीमे और मंगा जानकारी के लिए AniList API को एकीकृत करने वाला MCP सर्वर।
- [diivi/aseprite-mcp](https://github.com/diivi/aseprite-mcp) 🐍 🏠 - Aseprite API का उपयोग कर पिक्सेल आर्ट बनाने के लिए MCP सर्वर।
- [omni-mcp/isaac-sim-mcp](https://github.com/omni-mcp/isaac-sim-mcp) 📇 ☁️ - MCP सर्वर और एक एक्सटेंशन जो NVIDIA Isaac Sim, Lab, OpenUSD आदि का प्राकृतिक भाषा नियंत्रण सक्षम करता है।
- [8enSmith/mcp-open-library](https://github.com/8enSmith/mcp-open-library) 📇 ☁️ - Open Library API के लिए MCP सर्वर, जो AI सहायकों को पुस्तक जानकारी खोजने में सक्षम बनाता है।
- [PatrickPalmer/MayaMCP](https://github.com/PatrickPalmer/MayaMCP) 🐍 🏠 - Autodesk Maya के लिए MCP सर्वर।
- [cantian-ai/bazi-mcp](https://github.com/cantian-ai/bazi-mcp) 📇 🏠 ☁️ 🍎 🪟 - व्यापक और सटीक बाज़ी (चीनी ज्योतिष) चार्टिंग और विश्लेषण प्रदान करता है।


### 📂 <a name="browser-automation"></a>ब्राउज़र ऑटोमेशन

वेब सामग्री तक पहुँच और ऑटोमेशन क्षमताएँ। AI के अनुकूल प्रारूपों में वेब सामग्री खोजने, स्क्रैप करने और प्रोसेस करने में सक्षम बनाता है।

- [xspadex/bilibili-mcp](https://github.com/xspadex/bilibili-mcp.git) 📇 🏠 - Bilibili के ट्रेंडिंग वीडियो प्राप्त करने और उन्हें एक मानक MCP इंटरफ़ेस के माध्यम से एक्सपोज़ करने के लिए FastMCP-आधारित टूल।
- [34892002/bilibili-mcp-js](https://github.com/34892002/bilibili-mcp-js) 📇 🏠 - Bilibili सामग्री की खोज का समर्थन करने वाला MCP सर्वर। LangChain एकीकरण उदाहरण और परीक्षण स्क्रिप्ट प्रदान करता है।
- [aircodelabs/grasp](https://github.com/aircodelabs/grasp) 📇 🏠 - एजेंट के साथ सेल्फ-होस्टेड ब्राउज़र, जिसमें बिल्ट-इन MCP और A2A सपोर्ट है।
- [automatalabs/mcp-server-playwright](https://github.com/Automata-Labs-team/MCP-Server-Playwright) 🐍 - Playwright का उपयोग कर ब्राउज़र ऑटोमेशन के लिए MCP सर्वर।
- [blackwhite084/playwright-plus-python-mcp](https://github.com/blackwhite084/playwright-plus-python-mcp) 🐍 - ब्राउज़र ऑटोमेशन के लिए Playwright का उपयोग करने वाला MCP पायथन सर्वर, llm के लिए अधिक उपयुक्त।
- [browserbase/mcp-server-browserbase](https://github.com/browserbase/mcp-server-browserbase) 🎖️ 📇 - क्लाउड में ब्राउज़र इंटरैक्शन को ऑटोमेट करें (जैसे वेब नेविगेशन, डेटा एक्सट्रैक्शन, फॉर्म भरना, आदि)
- [browsermcp/mcp](https://github.com/browsermcp/mcp) 📇 🏠 - अपने स्थानीय Chrome ब्राउज़र को ऑटोमेट करें।
- [co-browser/browser-use-mcp-server](https://github.com/co-browser/browser-use-mcp-server) 🐍 - browser-use को MCP सर्वर के रूप में पैक किया गया है SSE ट्रांसपोर्ट के साथ। इसमें docker में chromium चलाने और एक vnc सर्वर शामिल है।
- [executeautomation/playwright-mcp-server](https://github.com/executeautomation/mcp-playwright) 📇 - ब्राउज़र ऑटोमेशन और वेबस्क्रैपिंग के लिए Playwright का उपयोग करने वाला MCP सर्वर।
- [eyalzh/browser-control-mcp](https://github.com/eyalzh/browser-control-mcp) 📇 🏠 - एक MCP सर्वर जो ब्राउज़र एक्सटेंशन के साथ जोड़ा जाता है, जिससे LLM क्लाइंट्स उपयोगकर्ता के ब्राउज़र (Firefox) को नियंत्रित कर सकते हैं।
- [fradser/mcp-server-apple-reminders](https://github.com/FradSer/mcp-server-apple-reminders) 📇 🏠 🍎 - macOS पर Apple Reminders के साथ इंटरैक्ट करने के लिए MCP सर्वर।
- [getrupt/ashra-mcp](https://github.com/getrupt/ashra-mcp) 🐍 🏠 - किसी भी वेबसाइट से स्ट्रक्चर्ड डेटा एक्सट्रैक्ट करें। बस प्रॉम्प्ट करें और JSON प्राप्त करें।
- [kimtaeyoon83/mcp-server-youtube-transcript](https://github.com/kimtaeyoon83/mcp-server-youtube-transcript) 📇 ☁️ - AI विश्लेषण के लिए YouTube उपशीर्षक और ट्रांसक्रिप्ट प्राप्त करें।
- [kimtth/mcp-aoai-web-browsing](https://github.com/kimtth/mcp-aoai-web-browsing) 🐍 🏠 - Azure OpenAI और Playwright का उपयोग कर `मिनिमल` सर्वर/क्लाइंट MCP इम्प्लीमेंटेशन।
- [microsoft/playwright-mcp](https://github.com/microsoft/playwright-mcp) - आधिकारिक Microsoft Playwright MCP सर्वर, जो LLMs को संरचित एक्सेसिबिलिटी स्नैपशॉट्स के माध्यम से वेब पेजों के साथ इंटरैक्ट करने में सक्षम बनाता है।
- [modelcontextprotocol/server-puppeteer](https://github.com/modelcontextprotocol/servers/tree/main/src/puppeteer) 📇 🏠 - वेब स्क्रैपिंग और इंटरैक्शन के लिए ब्राउज़र ऑटोमेशन।
- [ndthanhdev/mcp-browser-kit](https://github.com/ndthanhdev/mcp-browser-kit) 📇 🏠 - मैनिफेस्ट v2 संगत ब्राउज़रों के साथ इंटरैक्ट करने के लिए MCP सर्वर।
- [pskill9/web-search](https://github.com/pskill9/web-search) 📇 🏠 - Google सर्च परिणामों का उपयोग कर मुफ़्त वेब सर्चिंग सक्षम करने वाला MCP सर्वर, कोई API कुंजी आवश्यक नहीं।
- [recursechat/mcp-server-apple-shortcuts](https://github.com/recursechat/mcp-server-apple-shortcuts) 📇 🏠 🍎 - Apple Shortcuts के साथ MCP सर्वर एकीकरण।

### ☁️ <a name="cloud-platforms"></a>क्लाउड प्लेटफ़ॉर्म्स

क्लाउड प्लेटफ़ॉर्म सेवा एकीकरण। क्लाउड इन्फ्रास्ट्रक्चर और सेवाओं के प्रबंधन और इंटरैक्शन को सक्षम बनाता है।

- [awslabs/mcp](https://github.com/awslabs/mcp) 🎖️ ☁️ - AWS सेवाओं और संसाधनों के साथ निर्बाध एकीकरण के लिए AWS MCP सर्वर।
- [qiniu/qiniu-mcp-server](https://github.com/qiniu/qiniu-mcp-server) 🐍 ☁️ - Qiniu Cloud उत्पादों पर निर्मित MCP, Qiniu Cloud Storage, मीडिया प्रोसेसिंग सेवाओं, आदि तक पहुँच का समर्थन करता है।
- [alexbakers/mcp-ipfs](https://github.com/alexbakers/mcp-ipfs) 📇 ☁️ - IPFS स्टोरेज का अपलोड और मैनिपुलेशन।
- [reza-gholizade/k8s-mcp-server](https://github.com/reza-gholizade/k8s-mcp-server) 🏎️ ☁️/🏠 - एक Kubernetes Model Context Protocol (MCP) सर्वर जो API संसाधन खोज, संसाधन प्रबंधन, पॉड लॉग, मेट्रिक्स और ईवेंट्स सहित मानकीकृत इंटरफ़ेस के माध्यम से Kubernetes क्लस्टर्स के साथ इंटरैक्ट करने के टूल्स प्रदान करता है।
- [VmLia/books-mcp-server](https://github.com/VmLia/books-mcp-server) 📇 ☁️ - यह MCP सर्वर पुस्तकों की क्वेरी के लिए उपयोग किया जाता है, और इसे Cherry Studio जैसे सामान्य MCP क्लाइंट्स में लागू किया जा सकता है।
- [alexei-led/aws-mcp-server](https://github.com/alexei-led/aws-mcp-server) 🐍 ☁️ - एक हल्का लेकिन शक्तिशाली सर्वर जो AI सहायकों को AWS CLI कमांड निष्पादित करने, Unix पाइप्स का उपयोग करने, और सामान्य AWS कार्यों के लिए प्रॉम्प्ट टेम्प्लेट लागू करने में सक्षम बनाता है, जिसमें मल्टी-आर्किटेक्चर समर्थन के साथ सुरक्षित Docker वातावरण होता है।
- [alexei-led/k8s-mcp-server](https://github.com/alexei-led/k8s-mcp-server) 🐍 - एक हल्का लेकिन मजबूत सर्वर जो AI सहायकों को सुरक्षित रूप से Kubernetes CLI कमांड (`kubectl`, `helm`, `istioctl`, और `argocd`) निष्पादित करने में सक्षम बनाता है, Unix पाइप्स का उपयोग करते हुए, मल्टी-आर्किटेक्चर समर्थन के साथ सुरक्षित Docker वातावरण में।
- [aliyun/alibaba-cloud-ops-mcp-server](https://github.com/aliyun/alibaba-cloud-ops-mcp-server) 🎖️ 🐍 ☁️ - एक MCP सर्वर जो AI सहायकों को Alibaba Cloud पर संसाधनों का संचालन करने में सक्षम बनाता है, ECS, Cloud Monitor, OOS और व्यापक रूप से उपयोग किए जाने वाले क्लाउड उत्पादों का समर्थन करता है।  
- [bright8192/esxi-mcp-server](https://github.com/bright8192/esxi-mcp-server) 🐍 ☁️ - VMware ESXi/vCenter प्रबंधन सर्वर MCP (Model Control Protocol) पर आधारित, वर्चुअल मशीन प्रबंधन के लिए सरल REST API इंटरफ़ेस प्रदान करता है।
- [cloudflare/mcp-server-cloudflare](https://github.com/cloudflare/mcp-server-cloudflare) 🎖️ 📇 ☁️ - Cloudflare सेवाओं के साथ एकीकरण जिसमें Workers, KV, R2, और D1 शामिल हैं।
- [cyclops-ui/mcp-cyclops](https://github.com/cyclops-ui/mcp-cyclops) 🎖️ 🏎️ ☁️ - एक MCP सर्वर जो AI एजेंट्स को Cyclops abstraction के माध्यम से Kubernetes संसाधनों का प्रबंधन करने की अनुमति देता है।
- [jedisct1/fastly-mcp-server](https://github.com/jedisct1/fastly-openapi-schema) 🎖️ 📇 ☁️ - Fastly सेवाओं के साथ एकीकरण।
- [flux159/mcp-server-kubernetes](https://github.com/Flux159/mcp-server-kubernetes) 📇 ☁️/🏠 - Kubernetes क्लस्टर ऑपरेशंस का Typescript इम्प्लीमेंटेशन, पॉड्स, डिप्लॉयमेंट्स, सेवाओं के लिए।
- [hardik-id/azure-resource-graph-mcp-server](https://github.com/hardik-id/azure-resource-graph-mcp-server) 📇 ☁️/🏠 - Azure Resource Graph का उपयोग कर बड़े पैमाने पर Azure संसाधनों की क्वेरी और विश्लेषण के लिए Model Context Protocol सर्वर, जो AI सहायकों को Azure इन्फ्रास्ट्रक्चर की खोज और मॉनिटरिंग में सक्षम बनाता है।
- [jdubois/azure-cli-mcp](https://github.com/jdubois/azure-cli-mcp) - Azure CLI कमांड लाइन के चारों ओर एक रैपर जो आपको सीधे Azure से बात करने की अनुमति देता है।
- [johnneerdael/netskope-mcp](https://github.com/johnneerdael/netskope-mcp) 🔒 ☁️ - एक MCP जो Netskope Private Access वातावरण में सभी Netskope Private Access घटकों तक पहुँच प्रदान करता है जिसमें विस्तृत सेटअप जानकारी और उपयोग पर LLM उदाहरण शामिल हैं।
- [manusa/Kubernetes MCP Server](https://github.com/manusa/kubernetes-mcp-server) 🏎️ 🏠 - एक शक्तिशाली Kubernetes MCP सर्वर जिसमें OpenShift के लिए अतिरिक्त समर्थन है। **किसी भी** Kubernetes संसाधन के लिए CRUD ऑपरेशंस प्रदान करने के अलावा, यह सर्वर आपके क्लस्टर के साथ इंटरैक्ट करने के लिए विशेष टूल्स प्रदान करता है।
- [nwiizo/tfmcp](https://github.com/nwiizo/tfmcp) 🦀 🏠 - एक Terraform MCP सर्वर जो AI सहायकों को Terraform वातावरण का प्रबंधन और संचालन करने में सक्षम बनाता है, जिसमें कॉन्फ़िगरेशन पढ़ना, योजनाओं का विश्लेषण, कॉन्फ़िगरेशन लागू करना, और Terraform राज्य का प्रबंधन शामिल है।
- [pulumi/mcp-server](https://github.com/pulumi/mcp-server) 🎖️ 📇 🏠 - Pulumi Automation API और Pulumi Cloud API का उपयोग कर Pulumi के साथ इंटरैक्ट करने के लिए MCP सर्वर। MCP क्लाइंट्स को पैकेज जानकारी प्राप्त करने, परिवर्तनों का पूर्वावलोकन करने, अपडेट्स तैनात करने, और स्टैक आउटपुट प्रोग्रामेटिक रूप से प्राप्त करने जैसे Pulumi ऑपरेशंस करने में सक्षम बनाता है।
- [rohitg00/kubectl-mcp-server](https://github.com/rohitg00/kubectl-mcp-server) 🐍 ☁️/🏠 - Kubernetes के लिए Model Context Protocol (MCP) सर्वर जो Claude, Cursor आदि जैसे AI सहायकों को प्राकृतिक भाषा के माध्यम से Kubernetes क्लस्टर के साथ इंटरैक्ट करने में सक्षम बनाता है।
- [strowk/mcp-k8s-go](https://github.com/strowk/mcp-k8s-go) 🏎️ ☁️/🏠 - MCP के माध्यम से Kubernetes क्लस्टर ऑपरेशंस।
- [thunderboltsid/mcp-nutanix](https://github.com/thunderboltsid/mcp-nutanix) 🏎️ 🏠/☁️ - Nutanix Prism Central संसाधनों के साथ इंटरफेसिंग के लिए Go-आधारित MCP सर्वर।
- [trilogy-group/aws-pricing-mcp](https://github.com/trilogy-group/aws-pricing-mcp) 🏎️ ☁️/🏠 - एक कॉल के साथ EC2 मूल्य निर्धारण की नवीनतम जानकारी प्राप्त करें। तेज़। एक पूर्व-पार्स किए गए AWS मूल्य सूची द्वारा संचालित।
- [weibaohui/k8m](https://github.com/weibaohui/k8m) 🏎️ ☁️/🏠 - MCP मल्टी-क्लस्टर Kubernetes प्रबंधन और संचालन प्रदान करता है, जिसमें एक प्रबंधन इंटरफ़ेस, लॉगिंग, और लगभग 50 बिल्ट-इन टूल्स शामिल हैं जो सामान्य DevOps और विकास परिदृश्यों को कवर करते हैं। मानक और CRD संसाधनों दोनों का समर्थन करता है।
- [weibaohui/kom](https://github.com/weibaohui/kom) 🏎️ ☁️/🏠 - MCP मल्टी-क्लस्टर Kubernetes प्रबंधन और संचालन प्रदान करता है। इसे आपके अपने प्रोजेक्ट में एक SDK के रूप में एकीकृत किया जा सकता है और इसमें लगभग 50 बिल्ट-इन टूल्स शामिल हैं जो सामान्य DevOps और विकास परिदृश्यों को कवर करते हैं। मानक और CRD संसाधनों दोनों का समर्थन करता है।
- [wenhuwang/mcp-k8s-eye](https://github.com/wenhuwang/mcp-k8s-eye) 🏎️ ☁️/🏠 - Kubernetes प्रबंधन के लिए MCP सर्वर, और आपके क्लस्टर, एप्लिकेशन स्वास्थ्य का विश्लेषण करता है।
- [erikhoward/adls-mcp-server](https://github.com/erikhoward/adls-mcp-server) 🐍 ☁️/🏠 - Azure Data Lake Storage के लिए MCP सर्वर। यह कंटेनरों का प्रबंधन, कंटेनर फाइलों पर पढ़ने/लिखने/अपलोड/डाउनलोड संचालन और फाइल मेटाडेटा का प्रबंधन कर सकता है।
- [silenceper/mcp-k8s](https://github.com/silenceper/mcp-k8s) 🏎️ ☁️/🏠 - MCP-K8S एक एआई-संचालित Kubernetes संसाधन प्रबंधन उपकरण है जो उपयोगकर्ताओं को प्राकृतिक भाषा इंटरैक्शन के माध्यम से Kubernetes क्लस्टरों में किसी भी संसाधन का संचालन करने की अनुमति देता है, जिसमें मूल संसाधन (जैसे Deployment, Service) और कस्टम संसाधन (CRD) शामिल हैं। जटिल कमांड याद रखने की आवश्यकता नहीं - बस अपनी आवश्यकताओं का वर्णन करें, और AI सटीक रूप से संबंधित क्लस्टर संचालन को निष्पादित करेगा, जिससे Kubernetes की उपयोगिता बहुत बढ़ जाती है।
- [redis/mcp-redis-cloud](https://github.com/redis/mcp-redis-cloud) 📇 ☁️ - प्राकृतिक भाषा का उपयोग करके अपने Redis Cloud संसाधनों को आसानी से प्रबंधित करें। साधारण कमांड्स के साथ डेटाबेस बनाएं, सब्सक्रिप्शन मॉनिटर करें, और क्लाउड डिप्लॉयमेंट्स को कॉन्फ़िगर करें।
- [portainer/portainer-mcp](https://github.com/portainer/portainer-mcp) 🏎️ ☁️/🏠 - एक शक्तिशाली MCP सर्वर जो एआई असिस्टेंट्स को Portainer इंस्टेंसेस के साथ निर्बाध रूप से इंटरैक्ट करने की अनुमति देता है, कंटेनर प्रबंधन, डिप्लॉयमेंट संचालन, और इन्फ्रास्ट्रक्चर मॉनिटरिंग क्षमताओं तक प्राकृतिक भाषा पहुँच प्रदान करता है।

### 👨‍💻 <a name="code-execution"></a>कोड निष्पादन

कोड निष्पादन सर्वर। LLMs को एक सुरक्षित वातावरण में कोड निष्पादित करने की अनुमति देते हैं, जैसे कि कोडिंग एजेंट्स के लिए।

- [pydantic/pydantic-ai/mcp-run-python](https://github.com/pydantic/pydantic-ai/tree/main/mcp-run-python) 🐍 🏠- MCP टूल कॉल्स के माध्यम से एक सुरक्षित सैंडबॉक्स में Python कोड चलाएं
- [yepcode/mcp-server-js](https://github.com/yepcode/mcp-server-js) 🎖️ 📇 ☁️ - किसी भी LLM-जनित कोड को एक सुरक्षित और स्केलेबल सैंडबॉक्स वातावरण में निष्पादित करें और JavaScript या Python का उपयोग करके अपने स्वयं के MCP टूल्स बनाएं, जिसमें NPM और PyPI पैकेजों का पूर्ण समर्थन है
- [ckanthony/openapi-mcp](https://github.com/ckanthony/openapi-mcp) 🏎️ ☁️ - OpenAPI-MCP: आपके एआई एजेंट को मौजूदा एपीआई डॉक्स के साथ किसी भी एपीआई तक पहुंचने के लिए डॉकराइज्ड MCP सर्वर।
- [alfonsograziano/node-code-sandbox-mcp](https://github.com/alfonsograziano/node-code-sandbox-mcp) 📇 🏠 – एक Node.js MCP सर्वर जो जावास्क्रिप्ट स्निपेट्स को निष्पादित करने के लिए अलग Docker-आधारित सैंडबॉक्स बनाता है, ऑन-द-फ्लाई npm डिपेंडेंसी इंस्टॉलेशन और क्लीन टियरडाउन के साथ
- [r33drichards/mcp-js](https://github.com/r33drichards/mcp-js) 🦀 🏠 🐧 🍎 - एक जावास्क्रिप्ट कोड निष्पादन सैंडबॉक्स जो v8 का उपयोग करता है ताकि एआई जनित जावास्क्रिप्ट को स्थानीय रूप से सुरक्षित रूप से चलाया जा सके। पर्सिस्टेंट सेशंस के लिए हीप स्नैपशॉटिंग को सपोर्ट करता है।

### 🤖 <a name="coding-agents"></a>कोडिंग एजेंट्स

फुल कोडिंग एजेंट्स जो LLMs को कोड पढ़ने, संपादित करने और निष्पादित करने तथा सामान्य प्रोग्रामिंग कार्यों को पूरी तरह स्वायत्त रूप से हल करने में सक्षम बनाते हैं।

- [oraios/serena](https://github.com/oraios/serena)🐍🏠 - एक पूर्ण-विशेषताओं वाला कोडिंग एजेंट जो भाषा सर्वरों का उपयोग करके प्रतीकात्मक कोड संचालन पर निर्भर करता है।
- [ezyang/codemcp](https://github.com/ezyang/codemcp) 🐍🏠 - बेसिक रीड, राइट और कमांड लाइन टूल्स वाला कोडिंग एजेंट।
- [doggybee/mcp-server-leetcode](https://github.com/doggybee/mcp-server-leetcode) 📇 ☁️ - एक MCP सर्वर जो एआई मॉडल्स को LeetCode समस्याएं खोजने, प्राप्त करने और हल करने में सक्षम बनाता है। मेटाडेटा फिल्टरिंग, यूजर प्रोफाइल्स, सबमिशन और प्रतियोगिता डेटा एक्सेस को सपोर्ट करता है।
- [jinzcdev/leetcode-mcp-server](https://github.com/jinzcdev/leetcode-mcp-server) 📇 ☁️ - MCP सर्वर जो स्वचालित रूप से **LeetCode** की प्रोग्रामिंग समस्याओं, समाधानों, सबमिशन और सार्वजनिक डेटा तक पहुँच सक्षम करता है, यूजर-विशिष्ट फीचर्स (जैसे नोट्स) के लिए वैकल्पिक प्रमाणीकरण के साथ, दोनों `leetcode.com` (ग्लोबल) और `leetcode.cn` (चीन) साइटों को सपोर्ट करता है।
- [juehang/vscode-mcp-server](https://github.com/juehang/vscode-mcp-server) 📇 🏠 - एक MCP सर्वर जो Claude जैसे एआई को VS Code वर्कस्पेस में डिरेक्टरी स्ट्रक्चर से पढ़ने, लिंटर(s) और भाषा सर्वर द्वारा उठाई गई समस्याएं देखने, कोड फाइलें पढ़ने और संपादन करने की अनुमति देता है।
- [micl2e2/code-to-tree](https://github.com/micl2e2/code-to-tree) 🌊 🏠 📟 🐧 🪟 🍎 - एक सिंगल-बाइनरी MCP सर्वर जो स्रोत कोड को किसी भी भाषा के लिए AST में बदलता है।

### 🖥️ <a name="command-line"></a>कमांड लाइन

कमांड चलाएं, आउटपुट कैप्चर करें और अन्यथा शेल्स और कमांड लाइन टूल्स के साथ इंटरैक्ट करें।

- [ferrislucas/iterm-mcp](https://github.com/ferrislucas/iterm-mcp) 🖥️ 🛠️ 💬 - एक मॉडल कॉन्टेक्स्ट प्रोटोकॉल सर्वर जो iTerm तक पहुँच प्रदान करता है। आप कमांड चला सकते हैं और iTerm टर्मिनल में जो देखते हैं उसके बारे में सवाल पूछ सकते हैं।
- [g0t4/mcp-server-commands](https://github.com/g0t4/mcp-server-commands) 📇 🏠 - `run_command` और `run_script` टूल्स के साथ कोई भी कमांड चलाएं।
- [maxim-saplin/mcp_safe_local_python_executor](https://github.com/maxim-saplin/mcp_safe_local_python_executor) - HF Smolagents `LocalPythonExecutor` पर आधारित सुरक्षित Python इंटरप्रेटर
- [MladenSU/cli-mcp-server](https://github.com/MladenSU/cli-mcp-server) 🐍 🏠 - सुरक्षित निष्पादन और अनुकूलन सुरक्षा नीतियों के साथ कमांड लाइन इंटरफेस
- [OthmaneBlial/term_mcp_deepseek](https://github.com/OthmaneBlial/term_mcp_deepseek) 🐍 🏠 - टर्मिनल के लिए DeepSeek MCP-जैसा सर्वर
- [tumf/mcp-shell-server](https://github.com/tumf/mcp-shell-server) - मॉडल कॉन्टेक्स्ट प्रोटोकॉल (MCP) को लागू करने वाला एक सुरक्षित शेल कमांड निष्पादन सर्वर
- [automateyournetwork/pyATS_MCP](https://github.com/automateyournetwork/pyATS_MCP) - Cisco pyATS सर्वर जो नेटवर्क डिवाइसेज़ के साथ संरचित, मॉडल-ड्रिवन इंटरैक्शन सक्षम करता है।
- [wonderwhy-er/DesktopCommanderMCP](https://github.com/wonderwhy-er/DesktopCommanderMCP) 📇 🏠 🍎 🪟 🐧 - एक स्विस-आर्मी-नाइफ जो प्रोग्राम्स को प्रबंधित/निष्पादित कर सकता है और कोड व टेक्स्ट फाइल्स को पढ़/लिख/सर्च/संपादित कर सकता है।
- [tufantunc/ssh-mcp](https://github.com/tufantunc/ssh-mcp) 📇 🏠 🐧 🪟 - MCP सर्वर जो मॉडल कॉन्टेक्स्ट प्रोटोकॉल के माध्यम से Linux और Windows सर्वरों के लिए SSH नियंत्रण को एक्सपोज़ करता है। पासवर्ड या SSH कुंजी प्रमाणीकरण के साथ दूरस्थ शेल कमांड्स को सुरक्षित रूप से निष्पादित करें।

### 💬 <a name="communication"></a>संचार

संदेश प्रबंधन और चैनल संचालन के लिए संचार प्लेटफार्मों के साथ एकीकरण। एआई मॉडल्स को टीम संचार टूल्स के साथ इंटरैक्ट करने में सक्षम बनाता है।

- [AbdelStark/nostr-mcp](https://github.com/AbdelStark/nostr-mcp) ☁️ - एक Nostr MCP सर्वर जो Nostr के साथ इंटरैक्ट करने, नोट्स पोस्ट करने आदि को सक्षम बनाता है।
- [adhikasp/mcp-twikit](https://github.com/adhikasp/mcp-twikit) 🐍 ☁️ - ट्विटर सर्च और टाइमलाइन के साथ इंटरैक्ट करें
- [agentmail-toolkit/mcp](https://github.com/agentmail-to/agentmail-toolkit/tree/main/mcp) 🐍 💬 - एक MCP सर्वर जो ईमेल भेजने, प्राप्त करने और उन पर कार्रवाई करने के लिए ऑन-द-फ्लाई इनबॉक्स बनाता है। हम ईमेल के लिए एआई एजेंट नहीं, बल्कि एआई एजेंट्स के लिए ईमेल हैं।
- [arpitbatra123/mcp-googletasks](https://github.com/arpitbatra123/mcp-googletasks) 📇 ☁️ - Google Tasks API के साथ इंटरफेस के लिए एक MCP सर्वर
- [carterlasalle/mac_messages_mcp](https://github.com/carterlasalle/mac_messages_mcp) 🏠 🍎 🚀 - एक MCP सर्वर जो मॉडल कॉन्टेक्स्ट प्रोटोकॉल (MCP) के माध्यम से आपके iMessage डेटाबेस के साथ सुरक्षित रूप से इंटरफेस करता है, जिससे LLMs iMessage वार्तालापों की क्वेरी और विश्लेषण कर सकते हैं। इसमें मजबूत फोन नंबर सत्यापन, अटैचमेंट प्रोसेसिंग, संपर्क प्रबंधन, ग्रुप चैट हैंडलिंग और संदेश भेजने और प्राप्त करने के लिए पूर्ण समर्थन शामिल है।
- [chaindead/telegram-mcp](https://github.com/chaindead/telegram-mcp) 🏎️ 🏠 - उपयोगकर्ता डेटा तक पहुँचने, डायलॉग्स (चैट्स, चैनल्स, ग्रुप्स) प्रबंधित करने, संदेश प्राप्त करने और रीड स्टेटस संभालने के लिए टेलीग्राम API एकीकरण
- [chigwell/telegram-mcp](https://github.com/chigwell/telegram-mcp) 🐍 🏠 - उपयोगकर्ता डेटा तक पहुँचने, डायलॉग्स (चैट्स, चैनल्स, ग्रुप्स) प्रबंधित करने, संदेश प्राप्त करने, संदेश भेजने और रीड स्टेटस संभालने के लिए टेलीग्राम API एकीकरण।
- [elie222/inbox-zero](https://github.com/elie222/inbox-zero/tree/main/apps/mcp-server) 🐍 ☁️ - Inbox Zero के लिए एक MCP सर्वर। Gmail के ऊपर ऐसी कार्यक्षमता जोड़ता है जैसे कि कौन से ईमेल का आपको उत्तर देना है या फॉलो-अप करना है।
- [gitmotion/ntfy-me-mcp](https://github.com/gitmotion/ntfy-me-mcp) 📇 ☁️ 🏠 - आपके AI एजेंट्स से आपके सेल्फ-होस्टेड ntfy सर्वर पर ntfy सूचनाएं भेजने/प्राप्त करने के लिए ntfy MCP सर्वर 📤 (सुरक्षित टोकन ऑथ और अधिक का समर्थन करता है - npx या docker के साथ उपयोग करें!)
- [gotoolkits/wecombot](https://github.com/gotoolkits/mcp-wecombot-server.git) 🚀 ☁️ - एक MCP सर्वर एप्लिकेशन जो WeCom ग्रुप रोबोट को विभिन्न प्रकार के संदेश भेजता है।
- [hannesrudolph/imessage-query-fastmcp-mcp-server](https://github.com/hannesrudolph/imessage-query-fastmcp-mcp-server) 🐍 🏠 🍎 - एक MCP सर्वर जो मॉडल कॉन्टेक्स्ट प्रोटोकॉल (MCP) के माध्यम से आपके iMessage डेटाबेस तक सुरक्षित पहुँच प्रदान करता है, जिससे LLMs उचित फोन नंबर सत्यापन और अटैचमेंट हैंडलिंग के साथ iMessage वार्तालापों की क्वेरी और विश्लेषण कर सकते हैं
- [i-am-bee/acp-mcp](https://github.com/i-am-bee/acp-mcp) 🐍 💬 - एक MCP सर्वर जो [ACP](https://agentcommunicationprotocol.dev) इकोसिस्टम में एक एडॉप्टर के रूप में कार्य करता है। ACP एजेंट्स को MCP क्लाइंट्स के लिए सहज रूप से एक्सपोज़ करता है, दोनों प्रोटोकॉल के बीच संचार अंतर को पाटता है।
- [jagan-shanmugam/mattermost-mcp-host](https://github.com/jagan-shanmugam/mattermost-mcp-host) 🐍 🏠 - एक MCP सर्वर जो MCP होस्ट के साथ Mattermost टीम्स, चैनल्स और संदेशों तक पहुँच प्रदान करता है। MCP होस्ट को Mattermost में बोट के रूप में एकीकृत किया गया है, जिसमें कॉन्फ़िगर किए जा सकने वाले MCP सर्वरों तक पहुँच है।
- [lharries/whatsapp-mcp](https://github.com/lharries/whatsapp-mcp) 🐍 🏎️ - आपके व्यक्तिगत WhatsApp संदेशों, संपर्कों को खोजने और व्यक्तियों या समूहों को संदेश भेजने के लिए एक MCP सर्वर
- [line/line-bot-mcp-server](https://github.com/line/line-bot-mcp-server) 🎖 📇 ☁️ - LINE Official Account के साथ एकीकरण के लिए MCP सर्वर
- [MarkusPfundstein/mcp-gsuite](https://github.com/MarkusPfundstein/mcp-gsuite) 🐍 ☁️ - Gmail और Google Calendar के साथ एकीकरण।
- [modelcontextprotocol/server-bluesky](https://github.com/keturiosakys/bluesky-context-server) 📇 ☁️ - Bluesky इंस्टेंस एकीकरण क्वेरी और इंटरैक्शन के लिए
- [modelcontextprotocol/server-slack](https://github.com/modelcontextprotocol/servers/tree/main/src/slack) 📇 ☁️ - Slack वर्कस्पेस एकीकरण चैनल प्रबंधन और संदेश भेजने के लिए
- [korotovsky/slack-mcp-server](https://github.com/korotovsky/slack-mcp-server) 📇 ☁️ - Slack वर्कस्पेसेस के लिए सबसे शक्तिशाली MCP सर्वर।
- [sawa-zen/vrchat-mcp](https://github.com/sawa-zen/vrchat-mcp) - 📇 🏠 यह VRChat API के साथ इंटरैक्ट करने के लिए एक MCP सर्वर है। आप VRChat में दोस्तों, वर्ल्ड्स, अवतारों आदि के बारे में जानकारी प्राप्त कर सकते हैं।
- [takumi0706/google-calendar-mcp](https://github.com/takumi0706/google-calendar-mcp) 📇 ☁️ - Google Calendar API के साथ इंटरफेस के लिए एक MCP सर्वर। TypeScript पर आधारित।
- [teddyzxcv/ntfy-mcp](https://github.com/teddyzxcv/ntfy-mcp) - MCP सर्वर जो ntfy का उपयोग करके फोन पर सूचना भेजकर आपको सूचित रखता है
- [userad/didlogic_mcp](https://github.com/UserAd/didlogic_mcp) 🐍 ☁️ - [DIDLogic](https://didlogic.com) के लिए एक MCP सर्वर। SIP एंडपॉइंट्स, नंबर और डेस्टिनेशन का प्रबंधन करने की कार्यक्षमता जोड़ता है।
- [zcaceres/gtasks-mcp](https://github.com/zcaceres/gtasks-mcp) 📇 ☁️ - Google Tasks का प्रबंधन करने के लिए MCP सर्वर
- [InditexTech/mcp-teams-server](https://github.com/InditexTech/mcp-teams-server) 🐍 ☁️ - MCP सर्वर जो Microsoft Teams मैसेजिंग (पढ़ें, पोस्ट करें, मेंशन करें, सदस्यों और थ्रेड्स की सूची लें) को एकीकृत करता है
- [softeria/ms-365-mcp-server](https://github.com/softeria/ms-365-mcp-server) 📇 ☁️ - MCP सर्वर जो ग्राफ API का उपयोग करके पूरे Microsoft 365 सूट से कनेक्ट करता है (मेल, फाइल्स, Excel, कैलेंडर सहित)
- [YCloud-Developers/ycloud-whatsapp-mcp-server](https://github.com/YCloud-Developers/ycloud-whatsapp-mcp-server) 📇 🏠 - YCloud द्वारा WhatsApp Business Platform के लिए MCP सर्वर।
- [jaipandya/producthunt-mcp-server](https://github.com/jaipandya/producthunt-mcp-server) 🐍 🏠 - Product Hunt के लिए MCP सर्वर। ट्रेंडिंग पोस्ट्स, टिप्पणियों, कलेक्शनों, उपयोगकर्ताओं आदि के साथ इंटरैक्ट करें।

### 👤 <a name="customer-data-platforms"></a>कस्टमर डेटा प्लेटफार्म्स

कस्टमर डेटा प्लेटफॉर्म्स के अंदर कस्टमर प्रोफाइल्स तक पहुँच प्रदान करता है

- [iaptic/mcp-server-iaptic](https://github.com/iaptic/mcp-server-iaptic) 🎖️ 📇 ☁️ - [iaptic](https://www.iaptic.com) से कनेक्ट करें और अपने ग्राहक खरीद, लेनदेन डेटा और ऐप राजस्व सांख्यिकी के बारे में पूछें।
- [OpenDataMCP/OpenDataMCP](https://github.com/OpenDataMCP/OpenDataMCP) 🐍 ☁️ - मॉडल कॉन्टेक्स्ट प्रोटोकॉल के साथ किसी भी ओपन डेटा को किसी भी LLM से कनेक्ट करें।
- [sergehuber/inoyu-mcp-unomi-server](https://github.com/sergehuber/inoyu-mcp-unomi-server) 📇 ☁️ - Apache Unomi CDP सर्वर पर प्रोफाइल्स को एक्सेस और अपडेट करने के लिए MCP सर्वर।
- [tinybirdco/mcp-tinybird](https://github.com/tinybirdco/mcp-tinybird) 🐍 ☁️ - किसी भी MCP क्लाइंट से Tinybird Workspace के साथ इंटरैक्ट करने के लिए MCP सर्वर।
- [@antv/mcp-server-chart](https://github.com/antvis/mcp-server-chart) 🎖️ 📇 ☁️ - [AntV](https://github.com/antvis) का उपयोग करके विज़ुअल चार्ट जनरेट करने के लिए मॉडल कॉन्टेक्स्ट प्रोटोकॉल सर्वर।

### 🗄️ <a name="databases"></a>डेटाबेस

स्कीमा निरीक्षण क्षमताओं के साथ सुरक्षित डेटाबेस एक्सेस। कॉन्फ़िगर करने योग्य सुरक्षा नियंत्रणों के साथ डेटा क्वेरी और विश्लेषण सक्षम करता है, जिसमें केवल-पढ़ने तक पहुंच भी शामिल है।

- [Aiven-Open/mcp-aiven](https://github.com/Aiven-Open/mcp-aiven) - 🐍 ☁️ 🎖️ - अपने [Aiven प्रोजेक्ट्स](https://go.aiven.io/mcp-server) को नेविगेट करें और PostgreSQL®, Apache Kafka®, ClickHouse® और OpenSearch® सेवाओं के साथ इंटरैक्ट करें
- [alexanderzuev/supabase-mcp-server](https://github.com/alexander-zuev/supabase-mcp-server) - SQL क्वेरी निष्पादन और डेटाबेस एक्सप्लोरेशन टूल्स के समर्थन के साथ Supabase MCP सर्वर
- [aliyun/alibabacloud-tablestore-mcp-server](https://github.com/aliyun/alibabacloud-tablestore-mcp-server) ☕ 🐍 ☁️ - Tablestore के लिए MCP सेवा, जिसमें दस्तावेज़ जोड़ना, वेक्टर और स्केलर के आधार पर दस्तावेज़ों के लिए सिमेंटिक सर्च, RAG-अनुकूल और सर्वरलेस सुविधाएँ शामिल हैं।
- [benborla29/mcp-server-mysql](https://github.com/benborla/mcp-server-mysql) ☁️ 🏠 - NodeJS में MySQL डेटाबेस एकीकरण, कॉन्फ़िगर करने योग्य एक्सेस कंट्रोल्स और स्कीमा निरीक्षण के साथ
- [bytebase/dbhub](https://github.com/bytebase/dbhub) 📇 🏠 – मेनस्ट्रीम डेटाबेस के लिए यूनिवर्सल डेटाबेस MCP सर्वर।
- [c4pt0r/mcp-server-tidb](https://github.com/c4pt0r/mcp-server-tidb) 🐍 ☁️ - स्कीमा निरीक्षण और क्वेरी क्षमताओं के साथ TiDB डेटाबेस एकीकरण
- [Canner/wren-engine](https://github.com/Canner/wren-engine) 🐍 🦀 🏠 - मॉडल कॉन्टेक्स्ट प्रोटोकॉल(MCP) क्लाइंट्स और एआई एजेंट्स के लिए सिमेंटिक इंजन
- [centralmind/gateway](https://github.com/centralmind/gateway) 🏎️ 🏠 🍎 🪟 - MCP और MCP SSE सर्वर जो डेटाबेस स्कीमा और डेटा के आधार पर स्वचालित रूप से API जनरेट करता है। PostgreSQL, Clickhouse, MySQL, Snowflake, BigQuery, Supabase को सपोर्ट करता है
- [ChristianHinge/dicom-mcp](https://github.com/ChristianHinge/dicom-mcp) 🐍 ☁️ 🏠 - PACS और अन्य DICOM संगत प्रणालियों से चिकित्सा छवियों और रिपोर्टों को क्वेरी, पढ़ने और स्थानांतरित करने के लिए DICOM एकीकरण।
- [chroma-core/chroma-mcp](https://github.com/chroma-core/chroma-mcp) 🎖️ 🐍 ☁️ 🏠 - स्थानीय और क्लाउड Chroma इंस्टेंसेस तक पहुँच के लिए Chroma MCP सर्वर, पुनर्प्राप्ति क्षमताओं के लिए
- [ClickHouse/mcp-clickhouse](https://github.com/ClickHouse/mcp-clickhouse) 🐍 ☁️ - स्कीमा निरीक्षण और क्वेरी क्षमताओं के साथ ClickHouse डेटाबेस एकीकरण
- [confluentinc/mcp-confluent](https://github.com/confluentinc/mcp-confluent) 🐍 ☁️ - Confluent Kafka और Confluent Cloud REST APIs के साथ इंटरैक्ट करने के लिए Confluent इंटीग्रेशन।
- [Couchbase-Ecosystem/mcp-server-couchbase](https://github.com/Couchbase-Ecosystem/mcp-server-couchbase) 🎖️ 🐍 ☁️ 🏠 - Couchbase MCP सर्वर डॉक्यूमेंट ऑपरेशन्स, SQL++ क्वेरी और प्राकृतिक भाषा डेटा विश्लेषण के लिए Capella क्लाउड और सेल्फ-मैनेज्ड क्लस्टर्स दोनों के लिए एकीकृत एक्सेस प्रदान करता है।
- [cr7258/elasticsearch-mcp-server](https://github.com/cr7258/elasticsearch-mcp-server) 🐍 🏠 - Elasticsearch के साथ इंटरैक्शन प्रदान करने वाला MCP सर्वर इम्प्लीमेंटेशन।
- [crystaldba/postgres-mcp](https://github.com/crystaldba/postgres-mcp) 🐍 🏠 - Postgres डेवलपमेंट और ऑपरेशन्स के लिए ऑल-इन-वन MCP सर्वर, जिसमें परफॉर्मेंस एनालिसिस, ट्यूनिंग और हेल्थ चेक के टूल्स हैं।
- [Dataring-engineering/mcp-server-trino](https://github.com/Dataring-engineering/mcp-server-trino) 🐍 ☁️ - Trino MCP सर्वर जो Trino क्लस्टर्स से डेटा क्वेरी और एक्सेस करने की सुविधा देता है।
- [tuannvm/mcp-trino](https://github.com/tuannvm/mcp-trino) 🏎️ ☁️ - Trino के लिए Model Context Protocol (MCP) सर्वर का Go इम्प्लीमेंटेशन।
- [designcomputer/mysql_mcp_server](https://github.com/designcomputer/mysql_mcp_server) 🐍 🏠 - MySQL डेटाबेस इंटीग्रेशन जिसमें कॉन्फिगरेबल एक्सेस कंट्रोल्स, स्कीमा इंस्पेक्शन और व्यापक सुरक्षा दिशानिर्देश हैं।
- [wenb1n-dev/mysql_mcp_server_pro](https://github.com/wenb1n-dev/mysql_mcp_server_pro)  🐍 🏠 - SSE, STDIO को सपोर्ट करता है; केवल MySQL के CRUD फंक्शनलिटी तक सीमित नहीं; इसमें डेटाबेस अपवाद विश्लेषण क्षमताएं भी शामिल हैं; भूमिकाओं के आधार पर डेटाबेस अनुमतियों को नियंत्रित करता है; और डेवलपर्स के लिए टूल्स को कस्टमाइजेशन के साथ एक्सटेंड करना आसान बनाता है।
- [domdomegg/airtable-mcp-server](https://github.com/domdomegg/airtable-mcp-server) 📇 🏠 - स्कीमा इंस्पेक्शन, पढ़ने और लिखने की क्षमताओं के साथ Airtable डेटाबेस इंटीग्रेशन।
- [edwinbernadus/nocodb-mcp-server](https://github.com/edwinbernadus/nocodb-mcp-server) 📇 ☁️ - Nocodb डेटाबेस इंटीग्रेशन, पढ़ने और लिखने की क्षमताओं के साथ।
- [ergut/mcp-bigquery-server](https://github.com/ergut/mcp-bigquery-server) 📇 ☁️ - Google BigQuery इंटीग्रेशन के लिए सर्वर इम्प्लीमेंटेशन, जो डायरेक्ट BigQuery डेटाबेस एक्सेस और क्वेरी क्षमताएं सक्षम करता है।
- [f4ww4z/mcp-mysql-server](https://github.com/f4ww4z/mcp-mysql-server) 📇 🏠 - Node.js-आधारित MySQL डेटाबेस इंटीग्रेशन जो सुरक्षित MySQL डेटाबेस ऑपरेशन्स प्रदान करता है।
- [fireproof-storage/mcp-database-server](https://github.com/fireproof-storage/mcp-database-server) 📇 ☁️ - मल्टी-यूजर सिंक के साथ Fireproof लेजर डेटाबेस।
- [FreePeak/db-mcp-server](https://github.com/FreePeak/db-mcp-server) 🏎️ 🏠 – एक हाई-परफॉर्मेंस मल्टी-डेटाबेस MCP सर्वर, जो Golang में बना है और MySQL & PostgreSQL (जल्द ही NoSQL) को सपोर्ट करता है। इसमें क्वेरी निष्पादन, ट्रांजैक्शन प्रबंधन, स्कीमा एक्सप्लोरेशन, क्वेरी बिल्डिंग और परफॉर्मेंस एनालिसिस के लिए इनबिल्ट टूल्स हैं, साथ ही बेहतर डेटाबेस वर्कफ्लो के लिए Cursor इंटीग्रेशन।
- [furey/mongodb-lens](https://github.com/furey/mongodb-lens) 📇 🏠 - MongoDB Lens: MongoDB डेटाबेस के लिए फुल फीचर्ड MCP सर्वर।
- [gannonh/firebase-mcp](https://github.com/gannonh/firebase-mcp) 🔥 ⛅️ - Firebase सेवाएं, जिसमें Auth, Firestore और Storage शामिल हैं।
- [get-convex/convex-backend](https://stack.convex.dev/convex-mcp-server) 📇 ☁️ - Convex डेटाबेस इंटीग्रेशन, टेबल्स, फंक्शन्स का निरीक्षण और एकबारगी क्वेरी चलाने की सुविधा ([Source](https://github.com/get-convex/convex-backend/blob/main/npm-packages/convex/src/cli/mcp.ts))
- [googleapis/genai-toolbox](https://github.com/googleapis/genai-toolbox) 🏎️ ☁️ - डेटाबेस के लिए आसान, तेज और सुरक्षित टूल्स में विशेषज्ञता रखने वाला ओपन सोर्स MCP सर्वर।
- [GreptimeTeam/greptimedb-mcp-server](https://github.com/GreptimeTeam/greptimedb-mcp-server) 🐍 🏠 - GreptimeDB के लिए क्वेरी करने वाला MCP सर्वर।
- [hannesrudolph/sqlite-explorer-fastmcp-mcp-server](https://github.com/hannesrudolph/sqlite-explorer-fastmcp-mcp-server) 🐍 🏠 - SQLite डेटाबेस के लिए सुरक्षित, केवल-पढ़ने योग्य एक्सेस प्रदान करने वाला MCP सर्वर, जो FastMCP फ्रेमवर्क के साथ बनाया गया है, जिससे LLMs SQLite डेटाबेस को सुरक्षा सुविधाओं और क्वेरी वैलिडेशन के साथ एक्सप्लोर और क्वेरी कर सकते हैं।
- [idoru/influxdb-mcp-server](https://github.com/idoru/influxdb-mcp-server) 📇 ☁️ 🏠 - InfluxDB OSS API v2 के विरुद्ध क्वेरी चलाएं।
- [isaacwasserman/mcp-snowflake-server](https://github.com/isaacwasserman/mcp-snowflake-server) 🐍 ☁️ - Snowflake इंटीग्रेशन, जिसमें पढ़ने और (वैकल्पिक) लिखने के ऑपरेशन्स तथा इनसाइट ट्रैकिंग शामिल है।
- [joshuarileydev/supabase-mcp-server](https://github.com/joshuarileydev/supabase) - Supabase में प्रोजेक्ट्स और ऑर्गनाइजेशन को मैनेज और क्रिएट करने के लिए Supabase MCP सर्वर।
- [jovezhong/mcp-timeplus](https://github.com/jovezhong/mcp-timeplus) 🐍 ☁️ - Apache Kafka और Timeplus के लिए MCP सर्वर। Kafka टॉपिक्स की सूची, Kafka मैसेजेज प्राप्त करना, Kafka डेटा को लोकली सेव करना और Timeplus के माध्यम से SQL द्वारा स्ट्रीमिंग डेटा क्वेरी करना सक्षम।
- [KashiwaByte/vikingdb-mcp-server](https://github.com/KashiwaByte/vikingdb-mcp-server) 🐍 ☁️ - कलेक्शन और इंडेक्स परिचय, वेक्टर स्टोर और सर्च क्षमताओं के साथ VikingDB इंटीग्रेशन।
- [kiliczsh/mcp-mongo-server](https://github.com/kiliczsh/mcp-mongo-server) 📇 🏠 - MongoDB के लिए Model Context Protocol सर्वर।
- [ktanaka101/mcp-server-duckdb](https://github.com/ktanaka101/mcp-server-duckdb) 🐍 🏠 - स्कीमा इंस्पेक्शन और क्वेरी क्षमताओं के साथ DuckDB डेटाबेस इंटीग्रेशन।
- [LucasHild/mcp-server-bigquery](https://github.com/LucasHild/mcp-server-bigquery) 🐍 ☁️ - स्कीमा इंस्पेक्शन और क्वेरी क्षमताओं के साथ BigQuery डेटाबेस इंटीग्रेशन।
- [quarkiverse/mcp-server-jdbc](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/jdbc) ☕ 🏠 - किसी भी JDBC-कंपैटिबल डेटाबेस से कनेक्ट करें और क्वेरी, इंसर्ट, अपडेट, डिलीट आदि करें।
- [jparkerweb/mcp-sqlite](https://github.com/jparkerweb/mcp-sqlite) 📇 🏠 - Model Context Protocol (MCP) सर्वर जो व्यापक SQLite डेटाबेस इंटरैक्शन क्षमताएं प्रदान करता है।
- [memgraph/mcp-memgraph](https://github.com/memgraph/mcp-memgraph) 🐍 🏠 - Memgraph MCP सर्वर - इसमें Memgraph के विरुद्ध क्वेरी चलाने और स्कीमा संसाधन के लिए टूल शामिल है।
- [modelcontextprotocol/server-postgres](https://github.com/modelcontextprotocol/servers/tree/main/src/postgres) 📇 🏠 - स्कीमा इंस्पेक्शन और क्वेरी क्षमताओं के साथ PostgreSQL डेटाबेस इंटीग्रेशन।
- [modelcontextprotocol/server-sqlite](https://github.com/modelcontextprotocol/servers/tree/main/src/sqlite) 🐍 🏠 - इनबिल्ट विश्लेषण सुविधाओं के साथ SQLite डेटाबेस ऑपरेशन्स।
- [neo4j-contrib/mcp-neo4j](https://github.com/neo4j-contrib/mcp-neo4j) 🐍 🏠 - Neo4j के साथ Model Context Protocol (क्वेरी चलाएं, नॉलेज ग्राफ मेमोरी, Neo4j Aura इंस्टेंस का प्रबंधन करें)।
- [neondatabase/mcp-server-neon](https://github.com/neondatabase/mcp-server-neon) 📇 ☁️ — Neon Serverless Postgres का उपयोग करके Postgres डेटाबेस बनाने और प्रबंधित करने के लिए MCP सर्वर।
- [niledatabase/nile-mcp-server](https://github.com/niledatabase/nile-mcp-server) Nile के Postgres प्लेटफॉर्म के लिए MCP सर्वर - LLMs का उपयोग करके Postgres डेटाबेस, टेनेंट्स, यूजर्स, ऑथ को प्रबंधित और क्वेरी करें।
- [openlink/mcp-server-odbc](https://github.com/OpenLinkSoftware/mcp-odbc-server) 🐍 🏠 - Open Database Connectivity (ODBC) प्रोटोकॉल के माध्यम से सामान्य Database Management System (DBMS) कनेक्टिविटी के लिए MCP सर्वर।
- [openlink/mcp-server-sqlalchemy](https://github.com/OpenLinkSoftware/mcp-sqlalchemy-server) 🐍 🏠 - Python ODBC (pyodbc) का उपयोग करके SQLAlchemy के माध्यम से सामान्य DBMS कनेक्टिविटी के लिए MCP सर्वर।
- [pab1it0/adx-mcp-server](https://github.com/pab1it0/adx-mcp-server) 🐍 ☁️ - Azure Data Explorer डेटाबेस पर क्वेरी और विश्लेषण करें।
- [pab1it0/prometheus-mcp-server](https://github.com/pab1it0/prometheus-mcp-server) 🐍 ☁️ - Prometheus, ओपन-सोर्स मॉनिटरिंग सिस्टम पर क्वेरी और विश्लेषण करें।
- [prisma/prisma](https://github.com/prisma/prisma) 🐍 🏠 - LLMs को Prisma Postgres डेटाबेस का प्रबंधन करने की क्षमता देता है (जैसे, नए डेटाबेस इंस्टेंस शुरू करना या स्कीमा माइग्रेशन चलाना)।
- [qdrant/mcp-server-qdrant](https://github.com/qdrant/mcp-server-qdrant) 🐍 🏠 - Qdrant MCP सर्वर।
- [QuantGeekDev/mongo-mcp](https://github.com/QuantGeekDev/mongo-mcp) 📇 🏠 - MongoDB इंटीग्रेशन जो LLMs को सीधे डेटाबेस के साथ इंटरैक्ट करने में सक्षम बनाता है।
- [rashidazarang/airtable-mcp](https://github.com/rashidazarang/airtable-mcp) 🐍 ☁️ - AI टूल्स को सीधे Airtable से कनेक्ट करें। प्राकृतिक भाषा का उपयोग करके रिकॉर्ड क्वेरी, क्रिएट, अपडेट और डिलीट करें। फीचर्स में बेस प्रबंधन, टेबल ऑपरेशन्स, स्कीमा हेरफेर, रिकॉर्ड फिल्टरिंग और एक मानकीकृत MCP इंटरफेस के माध्यम से डेटा माइग्रेशन शामिल हैं।
- [redis/mcp-redis](https://github.com/redis/mcp-redis) 🐍 🏠 - Redis का आधिकारिक MCP सर्वर, Redis में डेटा को प्रबंधित और खोजने के लिए इंटरफेस प्रदान करता है।
- [runekaagaard/mcp-alchemy](https://github.com/runekaagaard/mcp-alchemy) 🐍 🏠 - यूनिवर्सल SQLAlchemy-आधारित डेटाबेस इंटीग्रेशन, जो PostgreSQL, MySQL, MariaDB, SQLite, Oracle, MS SQL Server और कई अन्य डेटाबेस को सपोर्ट करता है। इसमें स्कीमा और रिलेशनशिप इंस्पेक्शन, और बड़े डेटा सेट के विश्लेषण की क्षमताएं हैं।
- [sirmews/mcp-pinecone](https://github.com/sirmews/mcp-pinecone) 🐍 ☁️ - वेक्टर सर्च क्षमताओं के साथ Pinecone इंटीग्रेशन।
- [skysqlinc/skysql-mcp](https://github.com/skysqlinc/skysql-mcp) 🎖️ ☁️ - सर्वरलेस MariaDB क्लाउड DB MCP सर्वर। DB स्तर के AI एजेंट्स के साथ सटीक टेक्स्ट-2-SQL और बातचीत के लिए SQL लॉन्च, डिलीट, निष्पादन और कार्य करने के टूल्स।
- [supabase-community/supabase-mcp](https://github.com/supabase-community/supabase-mcp) 🎖️ 📇 ☁️ - आधिकारिक Supabase MCP सर्वर जो AI असिस्टेंट्स को सीधे आपके Supabase प्रोजेक्ट से जोड़ता है और उन्हें टेबल्स का प्रबंधन, कॉन्फ़िगरेशन प्राप्त करने और डेटा क्वेरी करने जैसे कार्य करने देता है।
- [TheRaLabs/legion-mcp](https://github.com/TheRaLabs/legion-mcp) 🐍 🏠 यूनिवर्सल डेटाबेस MCP सर्वर जो PostgreSQL, Redshift, CockroachDB, MySQL, RDS MySQL, Microsoft SQL Server, BigQuery, Oracle DB, और SQLite सहित कई डेटाबेस प्रकारों को सपोर्ट करता है।
- [tradercjz/dolphindb-mcp-server](https://github.com/tradercjz/dolphindb-mcp-server) 🐍 ☁️ - स्कीमा इंस्पेक्शन और क्वेरी क्षमताओं के साथ TDolphinDB डेटाबेस इंटीग्रेशन।
- [weaviate/mcp-server-weaviate](https://github.com/weaviate/mcp-server-weaviate) 🐍 📇 ☁️ - MCP सर्वर जो आपके Weaviate कलेक्शन्स को नॉलेज बेस के रूप में कनेक्ट करता है और Weaviate को चैट मेमोरी स्टोर के रूप में उपयोग करने देता है।
- [XGenerationLab/xiyan_mcp_server](https://github.com/XGenerationLab/xiyan_mcp_server) 📇 ☁️ — एक MCP सर्वर जो प्राकृतिक भाषा क्वेरीज़ का उपयोग करके डेटाबेस से डेटा लाने का समर्थन करता है, XiyanSQL द्वारा संचालित टेक्स्ट-टू-SQL LLM के साथ।
- [xing5/mcp-google-sheets](https://github.com/xing5/mcp-google-sheets) 🐍 ☁️ - Google Sheets के साथ इंटरैक्ट करने के लिए Model Context Protocol सर्वर। यह सर्वर Google Sheets API के माध्यम से स्प्रेडशीट्स को बनाने, पढ़ने, अपडेट और प्रबंधित करने के टूल्स प्रदान करता है।
- [freema/mcp-gsheets](https://github.com/freema/mcp-gsheets) 📇 ☁️ - Google Sheets API इंटीग्रेशन के लिए MCP सर्वर, जिसमें व्यापक पढ़ने, लिखने, फॉर्मेटिंग और शीट प्रबंधन क्षमताएं हैं।
- [Zhwt/go-mcp-mysql](https://github.com/Zhwt/go-mcp-mysql) 🏎️ 🏠 – उपयोग में आसान, जीरो डिपेंडेंसी MySQL MCP सर्वर, जो Golang में बना है, जिसमें कॉन्फिगरेबल केवल-पढ़ने की मोड और स्कीमा निरीक्षण है।
- [ydb/ydb-mcp](https://github.com/ydb-platform/ydb-mcp) 🎖️ 🐍 ☁️ - [YDB](https://ydb.tech) डेटाबेस के साथ इंटरैक्ट करने के लिए MCP सर्वर।
- [zilliztech/mcp-server-milvus](https://github.com/zilliztech/mcp-server-milvus) 🐍 🏠 ☁️ - Milvus / Zilliz के लिए MCP सर्वर, जिससे आपके डेटाबेस के साथ इंटरैक्ट करना संभव होता है।
- [openlink/mcp-server-jdbc](https://github.com/OpenLinkSoftware/mcp-jdbc-server) 🐍 🏠 - Java Database Connectivity (JDBC) प्रोटोकॉल के माध्यम से सामान्य DBMS कनेक्टिविटी के लिए MCP सर्वर।
- [yincongcyincong/VictoriaMetrics-mcp-server](https://github.com/yincongcyincong/VictoriaMetrics-mcp-server) 🐍 🏠 - VictoriaMetrics डेटाबेस के साथ इंटरैक्ट करने के लिए MCP सर्वर।
- [hydrolix/mcp-hydrolix](https://github.com/hydrolix/mcp-hydrolix) 🎖️ 🐍 ☁️ - Hydrolix टाइम-सीरीज़ डाटालेक इंटीग्रेशन जो LLM-आधारित वर्कफ़्लो के लिए स्कीमा एक्सप्लोरेशन और क्वेरी क्षमताएं प्रदान करता है।
- [davewind/mysql-mcp-server](https://github.com/dave-wind/mysql-mcp-server) 🏎️ 🏠 – Cursor और n8n के लिए यूज़र-फ्रेंडली रीड-ओनली mysql mcp सर्वर।

### 📊 <a name="data-platforms"></a>डेटा प्लेटफॉर्म्स

डेटा इंटीग्रेशन, ट्रांसफॉर्मेशन और पाइपलाइन ऑर्केस्ट्रेशन के लिए डेटा प्लेटफॉर्म्स।

- [flowcore/mcp-flowcore-platform](https://github.com/flowcore-io/mcp-flowcore-platform) 🎖️ 📇 ☁️ 🏠 - Flowcore के साथ इंटरैक्ट करें, एक्शन परफॉर्म करें, डेटा इनजेस्ट करें, और अपने या सार्वजनिक डेटा कोर में किसी भी डेटा का विश्लेषण, क्रॉस रेफरेंस और उपयोग करें; वह भी मानव भाषा में।
- [JordiNei/mcp-databricks-server](https://github.com/JordiNeil/mcp-databricks-server) 🐍 ☁️ - Databricks API से कनेक्ट करें, जिससे LLMs SQL क्वेरी चला सकते हैं, जॉब्स की सूची देख सकते हैं और जॉब स्टेटस प्राप्त कर सकते हैं।
- [yashshingvi/databricks-genie-MCP](https://github.com/yashshingvi/databricks-genie-MCP) 🐍 ☁️ - एक सर्वर जो Databricks Genie API से कनेक्ट होता है, जिससे LLMs प्राकृतिक भाषा में प्रश्न पूछ सकते हैं, SQL क्वेरी चला सकते हैं और Databricks कन्वर्सेशनल एजेंट्स के साथ इंटरैक्ट कर सकते हैं।
- [jwaxman19/qlik-mcp](https://github.com/jwaxman19/qlik-mcp) 📇 ☁️ - Qlik Cloud API के लिए MCP सर्वर, जो एप्लिकेशन, शीट्स को क्वेरी और विज़ुअलाइज़ेशन से डेटा निकालने की सुविधा देता है, जिसमें व्यापक ऑथेंटिकेशन और रेट लिमिटिंग सपोर्ट है।
- [keboola/keboola-mcp-server](https://github.com/keboola/keboola-mcp-server) 🐍 - Keboola Connection Data Platform के साथ इंटरैक्ट करें। यह सर्वर Keboola Storage API से डेटा सूचीबद्ध और एक्सेस करने के टूल्स प्रदान करता है।
- [dbt-labs/dbt-mcp](https://github.com/dbt-labs/dbt-mcp) 🎖️ 🐍 🏠 ☁️ - [dbt (data build tool)](https://www.getdbt.com/product/what-is-dbt) के लिए आधिकारिक MCP सर्वर, जो dbt Core/Cloud CLI, प्रोजेक्ट मेटाडेटा डिस्कवरी, मॉडल जानकारी, और सेमांटिक लेयर क्वेरी क्षमताओं के साथ इंटीग्रेशन प्रदान करता है।
- [mattijsdp/dbt-docs-mcp](https://github.com/mattijsdp/dbt-docs-mcp) 🐍 🏠 - dbt-core (OSS) यूज़र्स के लिए MCP सर्वर, क्योंकि आधिकारिक dbt MCP केवल dbt Cloud को सपोर्ट करता है। प्रोजेक्ट मेटाडेटा, मॉडल और कॉलम-स्तरीय वंशावली और dbt डाक्यूमेंटेशन को सपोर्ट करता है।

### 💻 <a name="developer-tools"></a>डेवलपर टूल्स

ऐसे टूल्स और इंटीग्रेशन, जो डेवलपमेंट वर्कफ़्लो और एनवायरनमेंट मैनेजमेंट को बेहतर बनाते हैं।

- [Pratyay/mac-monitor-mcp](https://github.com/Pratyay/mac-monitor-mcp) 🐍 🏠 🍎 - macOS पर संसाधन-सघन प्रक्रियाओं की पहचान करता है और प्रदर्शन सुधार के सुझाव देता है।
- [21st-dev/Magic-MCP](https://github.com/21st-dev/magic-mcp) - बेहतरीन 21st.dev डिज़ाइन इंजीनियर्स से प्रेरित कस्टम UI कंपोनेंट्स बनाएं।
- [Hypersequent/qasphere-mcp](https://github.com/Hypersequent/qasphere-mcp) 🎖️ 📇 ☁️ - [QA Sphere](https://qasphere.com/) टेस्ट मैनेजमेंट सिस्टम के साथ इंटीग्रेशन, जिससे LLMs सीधे AI-पावर्ड IDEs से टेस्ट केसों की खोज, सारांश और इंटरैक्शन कर सकते हैं।
- [admica/FileScopeMCP](https://github.com/admica/FileScopeMCP) 🐍 📇 🦀 - आपके कोडबेस का विश्लेषण करता है, निर्भरता संबंधों के आधार पर महत्वपूर्ण फाइलें पहचानता है। आरेख और महत्व स्कोर जनरेट करता है, जिससे AI असिस्टेंट्स को कोडबेस समझने में मदद मिलती है।
- [ambar/simctl-mcp](https://github.com/ambar/simctl-mcp) 📇 🏠 🍎 iOS Simulator कंट्रोल के लिए MCP सर्वर इम्प्लीमेंटेशन।
- [api7/apisix-mcp](https://github.com/api7/apisix-mcp) 🎖️ 📇 🏠 MCP सर्वर जो [Apache APISIX](https://github.com/apache/apisix) में सभी संसाधनों को क्वेरी और प्रबंधित करने को सपोर्ट करता है।
- [ArchAI-Labs/fastmcp-sonarqube-metrics](https://github.com/ArchAI-Labs/fastmcp-sonarqube-metrics) 🐍 🏠 🪟 🐧 🍎 - एक Model Context Protocol (MCP) सर्वर जो SonarQube प्रोजेक्ट्स के बारे में जानकारी प्राप्त करने के लिए टूल्स का सेट प्रदान करता है, जैसे कि मेट्रिक्स (वास्तविक और ऐतिहासिक), इशूज़, हेल्थ स्टेटस।
- [automation-ai-labs/mcp-link](https://github.com/automation-ai-labs/mcp-link) 🏎️ 🏠 - किसी भी API को AI एजेंट्स के साथ सहजता से इंटीग्रेट करें (OpenAPI Schema के साथ)।
- [azer/react-analyzer-mcp](https://github.com/azer/react-analyzer-mcp) 📇 🏠 - React कोड का स्थानीय रूप से विश्लेषण करें, संपूर्ण प्रोजेक्ट के लिए डॉक्युमेंट्स / llm.txt जनरेट करें।
- [davidlin2k/pox-mcp-server](https://github.com/davidlin2k/pox-mcp-server) 🐍 🏠 - POX SDN कंट्रोलर के लिए MCP सर्वर, जो नेटवर्क नियंत्रण और प्रबंधन क्षमताएं प्रदान करता है।
- [CodeLogicIncEngineering/codelogic-mcp-server](https://github.com/CodeLogicIncEngineering/codelogic-mcp-server) 🎖️ 🐍 ☁️ 🍎 🪟 🐧 - CodeLogic के लिए आधिकारिक MCP सर्वर, जो कोड डिपेंडेंसी एनालिटिक्स, आर्किटेक्चरल रिस्क एनालिसिस, और इम्पैक्ट असेसमेंट टूल्स तक एक्सेस देता है।
- [Comet-ML/Opik-MCP](https://github.com/comet-ml/opik-mcp) 🎖️ 📇 ☁️ 🏠 - प्राकृतिक भाषा का उपयोग करके Opik द्वारा कैप्चर किए गए LLM ऑब्जर्वेबिलिटी, ट्रेसेस, और मॉनिटरिंग डेटा को एक्सप्लोर करें।
- [CircleCI/mcp-server-circleci](https://github.com/CircleCI-Public/mcp-server-circleci) 📇 ☁️ - AI एजेंट्स को CircleCI से बिल्ड फेल्योर ठीक करने में सक्षम बनाएं।
- [currents-dev/currents-mcp](https://github.com/currents-dev/currents-mcp) 🎖️ 📇 ☁️ - AI एजेंट्स को [Currents](https://currents.dev) पर रिपोर्ट किए गए Playwright टेस्ट फेल्योर को ठीक करने में सक्षम बनाएं।
- [delano/postman-mcp-server](https://github.com/delano/postman-mcp-server) 📇 ☁️ - [Postman API](https://www.postman.com/postman/postman-public-workspace/) के साथ इंटरैक्ट करें।
- [flipt-io/mcp-server-flipt](https://github.com/flipt-io/mcp-server-flipt) 📇 🏠 - AI असिस्टेंट्स को [Flipt](https://flipt.io) में आपके फीचर फ्लैग्स के साथ इंटरैक्शन की सुविधा दें।
- [GLips/Figma-Context-MCP](https://github.com/GLips/Figma-Context-MCP) 📇 🏠 - कोडिंग एजेंट्स को Figma डेटा तक डायरेक्ट एक्सेस दें, ताकि वे वन-शॉट डिज़ाइन इम्प्लीमेंटेशन में मदद कर सकें।
- [gofireflyio/firefly-mcp](https://github.com/gofireflyio/firefly-mcp) 🎖️ 📇 ☁️ - [Firefly](https://firefly.ai) के साथ क्लाउड संसाधनों का इंटीग्रेशन, डिस्कवरी, प्रबंधन और कोडिफिकेशन।
- [Govcraft/rust-docs-mcp-server](https://github.com/Govcraft/rust-docs-mcp-server) 🦀 🏠 - LLMs को MCP टूल के माध्यम से किसी विशेष Rust crate के लिए अद्यतित डॉक्यूमेंटेशन संदर्भ प्रदान करता है, जिसमें सेमांटिक सर्च (एम्बेडिंग्स) और LLM सारांशण शामिल है।
- [haris-musa/excel-mcp-server](https://github.com/haris-musa/excel-mcp-server) 🐍 🏠 - एक Excel मैनिपुलेशन सर्वर, जो वर्कबुक निर्माण, डेटा ऑपरेशन्स, फॉर्मेटिंग और एडवांस्ड फीचर्स (चार्ट्स, पिवट टेबल्स, फार्मूले) प्रदान करता है।
- [higress-group/higress-ops-mcp-server](https://github.com/higress-group/higress-ops-mcp-server) 🐍 🏠 - एक MCP सर्वर जो [Higress](https://github.com/alibaba/higress) गेटवे कॉन्फ़िगरेशन और संचालन प्रबंधन के लिए व्यापक टूल प्रदान करता है।
- [hijaz/postmancer](https://github.com/hijaz/postmancer) 📇 🏠 - एक MCP सर्वर जो आपके LLM को API संग्रह बनाए रखने और उपयोग करने की अनुमति देकर Postman/Insomnia जैसे Rest क्लाइंट्स को बदलने के लिए।
- [hloiseaufcms/mcp-gopls](https://github.com/hloiseaufcms/mcp-gopls) 🏎️ 🏠 - एक MCP सर्वर जो [Go's Language Server Protocol (gopls)](https://github.com/golang/tools/tree/master/gopls) के साथ इंटरैक्ट करता है और उन्नत Go कोड विश्लेषण सुविधाओं का लाभ देता है।
- [hungthai1401/bruno-mcp](https://github.com/hungthai1401/bruno-mcp) 📇 🏠 - [Bruno API Client](https://www.usebruno.com/) के साथ इंटरैक्शन के लिए एक MCP सर्वर।
- [hyperb1iss/droidmind](https://github.com/hyperb1iss/droidmind) 🐍 🏠 - MCP के माध्यम से AI द्वारा Android डिवाइस नियंत्रित करें, जिससे डिवाइस नियंत्रण, डिबगिंग, सिस्टम विश्लेषण और UI ऑटोमेशन एक व्यापक सुरक्षा ढांचे के साथ संभव होता है।
- [XixianLiang/HarmonyOS-mcp-server](https://github.com/XixianLiang/HarmonyOS-mcp-server) 🐍 🏠 - MCP के माध्यम से AI द्वारा HarmonyOS-next डिवाइस नियंत्रित करें। डिवाइस नियंत्रण और UI ऑटोमेशन का समर्थन करता है।
- [IlyaGulya/gradle-mcp-server](https://github.com/IlyaGulya/gradle-mcp-server) 🏠 - ग्रेडल इंटीग्रेशन जो Gradle Tooling API का उपयोग करके प्रोजेक्ट्स का निरीक्षण करता है, कार्य निष्पादित करता है, और प्रति-परीक्षण परिणाम रिपोर्टिंग के साथ परीक्षण चलाता है।
- [InhiblabCore/mcp-image-compression](https://github.com/InhiblabCore/mcp-image-compression) 🐍 🏠 - विभिन्न इमेज फॉर्मेट्स के लिए स्थानीय संपीड़न हेतु MCP सर्वर।
- [isaacphi/mcp-language-server](https://github.com/isaacphi/mcp-language-server) 🏎️ 🏠 - MCP लैंग्वेज सर्वर MCP समर्थित क्लाइंट्स को कोडबेस नेविगेट करने में मदद करता है, जिससे वे get definition, references, rename और diagnostics जैसे सेमांटिक टूल्स का उपयोग कर सकते हैं।
- [ios-simulator-mcp](https://github.com/joshuayoes/ios-simulator-mcp) 📇 🏠 🍎 - iOS सिम्युलेटर के साथ इंटरैक्ट करने के लिए एक मॉडल कॉन्टेक्स्ट प्रोटोकॉल (MCP) सर्वर। यह सर्वर आपको iOS सिम्युलेटर के बारे में जानकारी प्राप्त करने, UI इंटरैक्शन नियंत्रित करने और UI एलिमेंट्स का निरीक्षण करने की अनुमति देता है।
- [InditexTech/mcp-server-simulator-ios-idb](https://github.com/InditexTech/mcp-server-simulator-ios-idb) 📇 🏠 🍎 - एक मॉडल कॉन्टेक्स्ट प्रोटोकॉल (MCP) सर्वर जो LLMs को प्राकृतिक भाषा आदेशों के माध्यम से iOS सिम्युलेटर (iPhone, iPad, आदि) के साथ इंटरैक्ट करने की सुविधा देता है।
- [IvanAmador/vercel-ai-docs-mcp](https://github.com/IvanAmador/vercel-ai-docs-mcp) 📇 🏠 - एक मॉडल कॉन्टेक्स्ट प्रोटोकॉल (MCP) सर्वर जो Vercel AI SDK डाक्यूमेंटेशन के लिए AI-संचालित खोज और क्वेरी क्षमताएँ प्रदान करता है।
- [j4c0bs/mcp-server-sql-analyzer](https://github.com/j4c0bs/mcp-server-sql-analyzer) 🐍 - एक MCP सर्वर जो [SQLGlot](https://github.com/tobymao/sqlglot) का उपयोग करके SQL विश्लेषण, लिंटिंग और डायलैक्ट रूपांतरण प्रदान करता है।
- [jasonjmcghee/claude-debugs-for-you](https://github.com/jasonjmcghee/claude-debugs-for-you) 📇 🏠 - एक MCP सर्वर और VS Code एक्सटेंशन जो (भाषा-अज्ञेय) ब्रेकपॉइंट्स और एक्सप्रेशन मूल्यांकन के माध्यम से स्वचालित डिबगिंग सक्षम करता है।
- [jetbrains/mcpProxy](https://github.com/JetBrains/mcpProxy) 🎖️ 📇 🏠 - JetBrains IDE से कनेक्ट करें।
- [qainsights/jmeter-mcp-server](https://github.com/QAInsights/jmeter-mcp-server) 🐍 🏠 - प्रदर्शन परीक्षण के लिए JMeter MCP सर्वर।
- [Jktfe/serveMyAPI](https://github.com/Jktfe/serveMyAPI) 📇 🏠 🍎 - macOS Keychain का उपयोग करते हुए API कुंजियों को सुरक्षित रूप से संग्रहीत और एक्सेस करने के लिए एक व्यक्तिगत MCP (मॉडल कॉन्टेक्स्ट प्रोटोकॉल) सर्वर।
- [joshuarileydev/app-store-connect-mcp-server](https://github.com/JoshuaRileyDev/app-store-connect-mcp-server) 📇 🏠 - iOS डेवलपर्स के लिए App Store Connect API से संवाद करने हेतु एक MCP सर्वर।
- [joshuarileydev/simulator-mcp-server](https://github.com/JoshuaRileyDev/simulator-mcp-server) 📇 🏠 - iOS सिम्युलेटर को नियंत्रित करने के लिए एक MCP सर्वर।
- [qainsights/k6-mcp-server](https://github.com/QAInsights/k6-mcp-server) 🐍 🏠 - प्रदर्शन परीक्षण के लिए Grafana k6 MCP सर्वर।
- [lamemind/mcp-server-multiverse](https://github.com/lamemind/mcp-server-multiverse) 📇 🏠 🛠️ - एक मिडलवेयर सर्वर जो एक ही MCP सर्वर के कई पृथक इंस्टेंसेज़ को स्वतंत्र रूप से विशिष्ट नामस्थान और कॉन्फ़िगरेशन के साथ सह-अस्तित्व में सक्षम बनाता है।
- [langfuse/mcp-server-langfuse](https://github.com/langfuse/mcp-server-langfuse) 🐍 🏠 - [Langfuse]([https://langfuse.com/](https://langfuse.com/docs/prompts/get-started)) प्रॉम्प्ट मैनेजमेंट के साथ बनाए गए LLM ऐप्लिकेशन प्रॉम्प्ट्स तक पहुँचने और प्रबंधित करने के लिए MCP सर्वर।
- [mobile-next/mobile-mcp](https://github.com/mobile-next/mobile-mcp) 📇 🏠 🐧 🍎 - Android/iOS ऐप्लिकेशन और डिवाइस ऑटोमेशन, विकास और ऐप स्क्रैपिंग के लिए MCP सर्वर। सिम्युलेटर/एमुलेटर/फिजिकल डिवाइस जैसे iPhone, Google Pixel, Samsung समर्थित।
- [qainsights/locust-mcp-server](https://github.com/QAInsights/locust-mcp-server) 🐍 🏠 - प्रदर्शन परीक्षण के लिए Locust MCP सर्वर।
- [mrexodia/user-feedback-mcp](https://github.com/mrexodia/user-feedback-mcp) 🐍 🏠 - टूल्स जैसे Cline और Cursor में मानव-इन-द-लूप वर्कफ़्लो सक्षम करने के लिए एक सरल MCP सर्वर।
- [narumiruna/gitingest-mcp](https://github.com/narumiruna/gitingest-mcp) 🐍 🏠 - एक MCP सर्वर जो [gitingest](https://github.com/cyclotruc/gitingest) का उपयोग करके किसी भी Git रेपो को उसके कोडबेस का सरल टेक्स्ट डाइजेस्ट में बदलता है।
- [OctoMind-dev/octomind-mcp](https://github.com/OctoMind-dev/octomind-mcp) 📇 ☁️ - आपके पसंदीदा AI एजेंट को आपके कोडबेस या अन्य डेटा स्रोतों (जैसे Jira, Slack या TestRail) से पूरी तरह प्रबंधित [Octomind](https://www.octomind.dev/) एंड-टू-एंड परीक्षण बनाने और चलाने की अनुमति देता है।
- [kadykov/mcp-openapi-schema-explorer](https://github.com/kadykov/mcp-openapi-schema-explorer) 📇 ☁️ 🏠 - MCP संसाधनों के माध्यम से OpenAPI/Swagger स्पेसिफिकेशंस तक टोकन-कुशल पहुंच।
- [pskill9/website-downloader](https://github.com/pskill9/website-downloader) 🗄️ 🚀 - यह MCP सर्वर wget का उपयोग करके पूरी वेबसाइट डाउनलोड करने का टूल प्रदान करता है। यह वेबसाइट संरचना को बनाए रखता है और लिंक को स्थानीय रूप से काम करने के लिए परिवर्तित करता है।
- [utensils/mcp-nixos](https://github.com/utensils/mcp-nixos) 🐍 🏠 - NixOS पैकेज, सिस्टम विकल्प, Home Manager कॉन्फ़िगरेशन और nix-darwin macOS सेटिंग्स के बारे में सटीक जानकारी प्रदान करने वाला MCP सर्वर, जिससे AI भ्रम को रोका जा सके।
- [QuantGeekDev/docker-mcp](https://github.com/QuantGeekDev/docker-mcp) 🏎️ 🏠 - MCP के माध्यम से Docker कंटेनर प्रबंधन और संचालन।
- [ckreiling/mcp-server-docker](https://github.com/ckreiling/mcp-server-docker) 🐍 🏠 - Docker के साथ इंटीग्रेट करें ताकि कंटेनर्स, इमेज, वॉल्यूम और नेटवर्क का प्रबंधन किया जा सके।
- [r-huijts/xcode-mcp-server](https://github.com/r-huijts/xcode-mcp-server) 📇 🏠 🍎 - प्रोजेक्ट प्रबंधन, फाइल ऑपरेशन और बिल्ड ऑटोमेशन के लिए Xcode इंटीग्रेशन।
- [ReAPI-com/mcp-openapi](https://github.com/ReAPI-com/mcp-openapi) 📇 🏠 - MCP सर्वर जो LLMs को आपके OpenAPI स्पेसिफिकेशंस के बारे में सब कुछ जानने देता है, ताकि कोड/मॉक डेटा खोज, समझा और जेनरेट किया जा सके।
- [Rootly-AI-Labs/Rootly-MCP-server](https://github.com/Rootly-AI-Labs/Rootly-MCP-server) 🎖️ 🐍 ☁️ 🍎 - [Rootly](https://rootly.com/) घटना प्रबंधन मंच के लिए MCP सर्वर।
- [sammcj/mcp-package-version](https://github.com/sammcj/mcp-package-version) 📇 🏠 - कोड लिखते समय LLMs को नवीनतम स्थिर पैकेज वर्शन सुझाने में मदद करने के लिए एक MCP सर्वर।
- [sapientpants/sonarqube-mcp-server](https://github.com/sapientpants/sonarqube-mcp-server) 🦀 ☁️ 🏠 - एक मॉडल कॉन्टेक्स्ट प्रोटोकॉल (MCP) सर्वर जो SonarQube के साथ इंटीग्रेट करता है ताकि AI सहायकों को कोड क्वालिटी मेट्रिक्स, मुद्दों और क्वालिटी गेट स्टेटस तक पहुंच मिल सके।
- [SDGLBL/mcp-claude-code](https://github.com/SDGLBL/mcp-claude-code) 🐍 🏠 - MCP का उपयोग करते हुए Claude Code क्षमताओं का कार्यान्वयन, जो AI कोड समझ, संशोधन और प्रोजेक्ट विश्लेषण को व्यापक टूल समर्थन के साथ सक्षम करता है।
- [snaggle-ai/openapi-mcp-server](https://github.com/snaggle-ai/openapi-mcp-server) 🏎️ 🏠 - किसी भी HTTP/REST API सर्वर को Open API स्पेक (v3) के माध्यम से कनेक्ट करें।
- [stass/lldb-mcp](https://github.com/stass/lldb-mcp) 🐍 🏠 🐧 🍎 - LLDB के लिए एक MCP सर्वर जो AI बाइनरी और कोर फाइल विश्लेषण, डिबगिंग, डिसअसेंबलिंग सक्षम करता है।
- [TencentEdgeOne/edgeone-pages-mcp](https://github.com/TencentEdgeOne/edgeone-pages-mcp) 📇 ☁️ - HTML कंटेंट को EdgeOne Pages पर डिप्लॉय करने और एक सार्वजनिक रूप से एक्सेस किए जाने योग्य URL प्राप्त करने के लिए एक MCP सेवा।
- [tumf/mcp-text-editor](https://github.com/tumf/mcp-text-editor) 🐍 🏠 - एक लाइन-ओरिएंटेड टेक्स्ट फाइल एडिटर। LLM टूल्स के लिए कुशल आंशिक फाइल एक्सेस के साथ टोकन उपयोग को न्यूनतम करने के लिए ऑप्टिमाइज़ किया गया।
- [vivekvells/mcp-pandoc](https://github.com/vivekVells/mcp-pandoc) 🗄️ 🚀 - Pandoc का उपयोग करके सहज दस्तावेज़ फॉर्मेट रूपांतरण के लिए MCP सर्वर, Markdown, HTML, PDF, DOCX (.docx), csv और अन्य स्वरूपों का समर्थन करता है।
- [VSCode Devtools](https://github.com/biegehydra/BifrostMCP) 📇 - VSCode IDE से कनेक्ट करें और `find_usages` जैसे सेमांटिक टूल्स का उपयोग करें।
- [xcodebuild](https://github.com/ShenghaiWang/xcodebuild) 🍎 iOS Xcode वर्कस्पेस/प्रोजेक्ट बनाएं और त्रुटियों को llm को फीडबैक करें।
- [xzq.xu/jvm-mcp-server](https://github.com/xzq-xu/jvm-mcp-server) 📇 🏠  - JVM आधारित MCP (मॉडल कॉन्टेक्स्ट प्रोटोकॉल) सर्वर का एक कार्यान्वयन प्रोजेक्ट।
- [yangkyeongmo@/mcp-server-apache-airflow](https://github.com/yangkyeongmo/mcp-server-apache-airflow) 🐍 🏠 - आधिकारिक क्लाइंट का उपयोग करते हुए [Apache Airflow](https://airflow.apache.org/) से कनेक्ट करने वाला MCP सर्वर।
- [YuChenSSR/mindmap-mcp-server](https://github.com/YuChenSSR/mindmap-mcp-server) 🐍 🏠 - सुंदर इंटरएक्टिव माइंडमैप बनाने के लिए एक मॉडल कॉन्टेक्स्ट प्रोटोकॉल (MCP) सर्वर।
- [YuChenSSR/multi-ai-advisor](https://github.com/YuChenSSR/multi-ai-advisor-mcp) 📇 🏠 - एक मॉडल कॉन्टेक्स्ट प्रोटोकॉल (MCP) सर्वर जो कई Ollama मॉडल्स से क्वेरी करता है और उनके उत्तरों को जोड़ता है, जिससे एक ही प्रश्न पर विविध AI दृष्टिकोण मिलते हैं।
- [yWorks/mcp-typescribe](https://github.com/yWorks/mcp-typescribe) 📇 🏠 - MCP सर्वर जो एजेंट को अनट्रेंड API के साथ काम करने के लिए Typescript API जानकारी कुशलता से प्रदान करता है।
- [zcaceres/fetch-mcp](https://github.com/zcaceres/fetch-mcp) 📇 🏠 - JSON, टेक्स्ट, और HTML डेटा को लचीले ढंग से प्राप्त करने के लिए एक MCP सर्वर।
- [zenml-io/mcp-zenml](https://github.com/zenml-io/mcp-zenml) 🐍 🏠 ☁️ - आपके [ZenML](https://www.zenml.io) MLOps और LLMOps पाइपलाइनों से कनेक्ट होने के लिए एक MCP सर्वर।
- [idosal/git-mcp](https://github.com/idosal/git-mcp) 📇 ☁️ - [gitmcp.io](https://gitmcp.io/) एक सामान्य रिमोट MCP सर्वर है जो किसी भी [GitHub](https://www.github.com) रेपो या प्रोजेक्ट से डाक्यूमेंटेशन के लिए कनेक्ट करता है।
- [tgeselle/bugsnag-mcp](https://github.com/tgeselle/bugsnag-mcp) 📇 ☁️ - [Bugsnag](https://www.bugsnag.com/) के साथ इंटरैक्ट करने के लिए MCP सर्वर।
- [jordandalton/restcsv-mcp-server](https://github.com/JordanDalton/RestCsvMcpServer) 📇 ☁️ - CSV फाइलों के लिए एक MCP सर्वर।
- [cjo4m06/mcp-shrimp-task-manager](https://github.com/cjo4m06/mcp-shrimp-task-manager) 📇 ☁️ 🏠 – प्रोग्रामिंग-केंद्रित टास्क प्रबंधन प्रणाली जो Cursor AI जैसे कोडिंग एजेंट्स को उन्नत टास्क मेमोरी, आत्म-चिंतन, और डिपेंडेंसी प्रबंधन के साथ बढ़ावा देती है। [ShrimpTaskManager](https://cjo4m06.github.io/mcp-shrimp-task-manager)
- [axliupore/mcp-code-runner](https://github.com/axliupore/mcp-code-runner) 📇 🏠 - Docker के माध्यम से स्थानीय रूप से कोड चलाने और कई प्रोग्रामिंग भाषाओं का समर्थन करने के लिए एक MCP सर्वर।
- [yikakia/godoc-mcp-server](https://github.com/yikakia/godoc-mcp-server) 🏎️ ☁️ 🪟 🐧 🍎 - pkg.go.dev पर Go पैकेज जानकारी क्वेरी करें।
- [ckanthony/gin-mcp](https://github.com/ckanthony/gin-mcp) 🏎️ ☁️ 📟 🪟 🐧 🍎 - एक शून्य-कॉन्फ़िगरेशन Go लाइब्रेरी जो मौजूदा Gin वेब फ्रेमवर्क APIs को MCP टूल्स के रूप में स्वचालित रूप से उजागर करती है।
- [ryan0204/github-repo-mcp](https://github.com/Ryan0204/github-repo-mcp) 📇 ☁️ 🪟 🐧 🍎 - GitHub Repo MCP आपके AI सहायकों को GitHub रिपॉजिटरी ब्राउज़ करने, डायरेक्टरीज़ एक्सप्लोर करने, और फाइल कंटेंट देखने की अनुमति देता है।
- [alimo7amed93/webhook-tester-mcp](https://github.com/alimo7amed93/webhook-tester-mcp)  🐍 ☁️ – webhook-test.com के साथ इंटरैक्ट करने के लिए FastMCP-आधारित सर्वर। उपयोगकर्ता Claude का उपयोग करके वेबहुक्स स्थानीय रूप से बना, प्राप्त, और हटा सकते हैं।
- [lpigeon/ros-mcp-server](https://github.com/lpigeon/ros-mcp-server) 🐍 🏠 🍎 🪟 🐧 - ROS MCP सर्वर उपयोगकर्ता द्वारा दिए गए प्राकृतिक भाषा आदेशों को ROS या ROS2 नियंत्रण आदेशों में बदलकर रोबोट नियंत्रण का समर्थन करता है।
- [jsdelivr/globalping-mcp-server](https://github.com/jsdelivr/globalping-mcp-server) 🎖️ 📇 ☁️ - Globalping MCP सर्वर उपयोगकर्ताओं और LLMs को दुनिया भर के हजारों स्थानों से ping, traceroute, mtr, HTTP और DNS resolve जैसे नेटवर्क टूल्स चलाने की सुविधा देता है।
- [posthog/mcp](https://github.com/posthog/mcp) 🎖️ 📇 ☁️ - PostHog एनालिटिक्स, फीचर फ्लैग्स, त्रुटि ट्रैकिंग आदि के साथ इंटरैक्ट करने के लिए एक MCP सर्वर।
- [artmann/package-registry-mcp](https://github.com/artmann/package-registry-mcp) 🏠 📇 🍎 🪟 🐧 - NPM, Cargo, PyPi, और NuGet पैकेज के बारे में खोजने और अद्यतित जानकारी प्राप्त करने के लिए MCP सर्वर।

### 🔒 <a name="delivery"></a>डिलीवरी

- [https://github.com/jordandalton/doordash-mcp-server](https://github.com/JordanDalton/DoorDash-MCP-Server) 🐍 – DoorDash डिलीवरी (अनौपचारिक)

### 🧮 <a name="data-science-tools"></a>डेटा साइंस टूल्स

इंटीग्रेशन और टूल्स जो डेटा खोज, विश्लेषण को सरल बनाने और डेटा साइंस वर्कफ़्लो को बेहतर बनाने के लिए डिज़ाइन किए गए हैं।

- [ChronulusAI/chronulus-mcp](https://github.com/ChronulusAI/chronulus-mcp) 🐍 ☁️ - Chronulus AI पूर्वानुमान और प्रेडिक्शन एजेंट्स के साथ कुछ भी पूर्वानुमानित करें।
- [reading-plus-ai/mcp-server-data-exploration](https://github.com/reading-plus-ai/mcp-server-data-exploration) 🐍 ☁️ - .csv-आधारित डाटासेट्स पर स्वायत्त डेटा खोज सक्षम करता है, न्यूनतम प्रयास में बुद्धिमान इनसाइट्स प्रदान करता है।
- [zcaceres/markdownify-mcp](https://github.com/zcaceres/markdownify-mcp) 📇 🏠 - लगभग किसी भी फाइल या वेब कंटेंट को Markdown में बदलने के लिए एक MCP सर्वर।
- [datalayer/jupyter-mcp-server](https://github.com/datalayer/jupyter-mcp-server) 🐍 🏠 - Jupyter के लिए मॉडल कॉन्टेक्स्ट प्रोटोकॉल (MCP) सर्वर।
- [jjsantos01/jupyter-notebook-mcp](https://github.com/jjsantos01/jupyter-notebook-mcp) 🐍 🏠 - Claude AI को Jupyter Notebook से जोड़ता है, जिससे Claude सीधे Jupyter Notebooks के साथ इंटरैक्ट और नियंत्रण कर सकता है।
- [arrismo/kaggle-mcp](https://github.com/arrismo/kaggle-mcp) 🐍 ☁️ - Kaggle से कनेक्ट करता है, डाटासेट डाउनलोड और विश्लेषण करने की क्षमता।
- [kdqed/zaturn](https://github.com/kdqed/zaturn) 🐍 🏠 🪟 🐧 🍎 - कई डेटा स्रोतों (SQL, CSV, Parquet आदि) को लिंक करें और AI से डेटा के लिए इनसाइट्स और विज़ुअलाइज़ेशन के लिए विश्लेषण करवाएँ।
- [mckinsey/vizro-mcp](https://github.com/mckinsey/vizro/tree/main/vizro-mcp) 🎖️ 🐍 🏠 - सत्यापित और अनुरक्षित डेटा चार्ट और डैशबोर्ड बनाने के लिए टूल्स और टेम्प्लेट्स।
- [growthbook/growthbook-mcp](https://github.com/growthbook/growthbook-mcp) 🎖️ 📇 🏠 🪟 🐧 🍎 — GrowthBook फीचर फ्लैग्स और प्रयोग बनाने और इंटरैक्ट करने के लिए टूल्स।

### 📟 <a name="embedded-system"></a>एम्बेडेड सिस्टम

एंबेडेड डिवाइसेज़ पर काम करने के लिए डाक्यूमेंटेशन और शॉर्टकट्स तक पहुंच प्रदान करता है।

- [horw/esp-mcp](https://github.com/horw/esp-mcp) 📟 - ESP32 सीरीज़ चिप्स में बिल्ड समस्याओं को ठीक करने के लिए वर्कफ़्लो, ESP-IDF का उपयोग करता है।
- [kukapay/modbus-mcp](https://github.com/kukapay/modbus-mcp) 🐍 📟 - औद्योगिक Modbus डेटा का मानकीकरण और संदर्भ प्रदान करने के लिए एक MCP सर्वर।
- [kukapay/opcua-mcp](https://github.com/kukapay/opcua-mcp) 🐍 📟 - औद्योगिक OPC UA-सक्षम प्रणालियों से कनेक्ट करने के लिए एक MCP सर्वर।
- [yoelbassin/gnuradioMCP](https://github.com/yoelbassin/gnuradioMCP) 🐍 📟 🏠 - GNU Radio के लिए एक MCP सर्वर जो LLMs को RF `.grc` फ्लोचार्ट्स स्वायत्त रूप से बनाने और संशोधित करने में सक्षम बनाता है।

### 📂 <a name="file-systems"></a>फाइल सिस्टम

स्थानीय फाइल सिस्टम तक प्रत्यक्ष पहुंच प्रदान करता है, जिसमें कॉन्फ़िगर करने योग्य अनुमतियाँ होती हैं। AI मॉडल्स को निर्दिष्ट डाइरेक्टरीज़ के भीतर फाइलें पढ़ने, लिखने और प्रबंधित करने में सक्षम बनाता है।

- [cyberchitta/llm-context.py](https://github.com/cyberchitta/llm-context.py) 🐍 🏠 - MCP या क्लिपबोर्ड के माध्यम से LLMs के साथ कोड संदर्भ साझा करें।
- [exoticknight/mcp-file-merger](https://github.com/exoticknight/mcp-file-merger) 🏎️ 🏠 - फाइल मर्जर टूल, AI चैट की लंबाई सीमाओं के लिए उपयुक्त।
- [filesystem@quarkiverse/quarkus-mcp-servers](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/filesystem) ☕ 🏠 - एक फाइल सिस्टम जो ब्राउज़िंग और संपादन की अनुमति देता है, Java और Quarkus का उपयोग करके लागू किया गया। jar या नेटिव इमेज के रूप में उपलब्ध।
- [hmk/box-mcp-server](https://github.com/hmk/box-mcp-server) 📇 ☁️ - फाइलों की सूची, पढ़ने और खोजने के लिए Box एकीकरण
- [mamertofabian/mcp-everything-search](https://github.com/mamertofabian/mcp-everything-search) 🐍 🏠 🪟 - Everything SDK का उपयोग करके विंडोज़ में तेज़ फाइल खोज
- [mark3labs/mcp-filesystem-server](https://github.com/mark3labs/mcp-filesystem-server) 🏎️ 🏠 - स्थानीय फाइल सिस्टम एक्सेस के लिए Golang कार्यान्वयन।
- [mickaelkerjean/filestash](https://github.com/mickael-kerjean/filestash/tree/master/server/plugin/plg_handler_mcp) 🏎️ ☁️ - रिमोट स्टोरेज एक्सेस: SFTP, S3, FTP, SMB, NFS, WebDAV, GIT, FTPS, gcloud, azure blob, sharepoint, आदि।
- [microsoft/markitdown](https://github.com/microsoft/markitdown/tree/main/packages/markitdown-mcp) 🎖️ 🐍 🏠 - MCP टूल के द्वारा MarkItDown का एक्सेस -- एक लाइब्रेरी जो कई फाइल फॉर्मेट्स (स्थानीय या रिमोट) को Markdown में परिवर्तित करती है LLM उपयोग के लिए।
- [modelcontextprotocol/server-filesystem](https://github.com/modelcontextprotocol/servers/tree/main/src/filesystem) 📇 🏠 - प्रत्यक्ष स्थानीय फाइल सिस्टम एक्सेस।
- [modelcontextprotocol/server-google-drive](https://github.com/modelcontextprotocol/servers/tree/main/src/gdrive) 📇 ☁️ - फाइलों की सूची, पढ़ने और खोजने के लिए Google Drive एकीकरण
- [Xuanwo/mcp-server-opendal](https://github.com/Xuanwo/mcp-server-opendal) 🐍 🏠 ☁️ - Apache OpenDAL™ के साथ किसी भी स्टोरेज को एक्सेस करें
- [jeannier/homebrew-mcp](https://github.com/jeannier/homebrew-mcp) 🐍 🏠 🍎 - इस MCP सर्वर के माध्यम से प्राकृतिक भाषा का उपयोग करके अपने macOS Homebrew सेटअप को नियंत्रित करें। अपनी पैकेजेस को आसानी से प्रबंधित करें, सुझाव मांगें, या brew समस्याओं का समाधान करें आदि।

### 💰 <a name="finance--fintech"></a>वित्त और फिनटेक

वित्तीय डेटा एक्सेस और विश्लेषण उपकरण। एआई मॉडल को बाजार डेटा, ट्रेडिंग प्लेटफार्म और वित्तीय जानकारी के साथ काम करने में सक्षम बनाते हैं।

- [aaronjmars/web3-research-mcp](https://github.com/aaronjmars/web3-research-mcp) 📇 ☁️ - क्रिप्टो के लिए गहन अनुसंधान - मुफ़्त और पूरी तरह स्थानीय
- [alchemy/alchemy-mcp-server](https://github.com/alchemyplatform/alchemy-mcp-server) 🎖️ 📇 ☁️ - एआई एजेंट्स को Alchemy के ब्लॉकचेन APIs के साथ इंटरैक्ट करने की अनुमति देता है।
- [OctagonAI/octagon-mcp-server](https://github.com/OctagonAI/octagon-mcp-server) 🐍 ☁️ - निजी और सार्वजनिक बाजार डेटा के एकीकरण के लिए Octagon AI एजेंट्स
- [anjor/coinmarket-mcp-server](https://github.com/anjor/coinmarket-mcp-server) 🐍 ☁️ - क्रिप्टोकरेंसी लिस्टिंग और कोट्स प्राप्त करने के लिए Coinmarket API एकीकरण
- [ariadng/metatrader-mcp-server](https://github.com/ariadng/metatrader-mcp-server) 🐍 🏠 🪟 - एआई LLMs को MetaTrader 5 प्लेटफार्म का उपयोग करके ट्रेड निष्पादित करने में सक्षम बनाता है
- [armorwallet/armor-crypto-mcp](https://github.com/armorwallet/armor-crypto-mcp) 🐍 ☁️ - कई ब्लॉकचेन, स्टेकिंग, DeFi, स्वैप, ब्रिजिंग, वॉलेट प्रबंधन, DCA, लिमिट ऑर्डर, कॉइन लुकअप, ट्रैकिंग और बहुत कुछ के लिए MCP इंटरफेस।
- [bankless/onchain-mcp](https://github.com/Bankless/onchain-mcp/) 📇 ☁️ - स्मार्ट कॉन्ट्रैक्ट्स के साथ इंटरैक्ट करने, ट्रांजैक्शन और टोकन जानकारी क्वेरी करने के लिए Bankless Onchain API
- [base/base-mcp](https://github.com/base/base-mcp) 🎖️ 📇 ☁️ - ऑनचेन टूल्स के लिए Base Network एकीकरण, वॉलेट प्रबंधन, फंड ट्रांसफर, स्मार्ट कॉन्ट्रैक्ट्स और DeFi संचालन के लिए Base Network और Coinbase API के साथ इंटरैक्शन की अनुमति देता है
- [berlinbra/alpha-vantage-mcp](https://github.com/berlinbra/alpha-vantage-mcp) 🐍 ☁️ - स्टॉक और क्रिप्टो जानकारी प्राप्त करने के लिए Alpha Vantage API एकीकरण
- [ahnlabio/bicscan-mcp](https://github.com/ahnlabio/bicscan-mcp) 🎖️ 🐍 ☁️ - EVM ब्लॉकचेन एड्रेस (EOA, CA, ENS) और यहां तक कि डोमेन नामों के जोखिम स्कोर / संपत्ति होल्डिंग्स।
- [bitteprotocol/mcp](https://github.com/BitteProtocol/mcp) 📇 - कई ब्लॉकचेन पर एआई एजेंट्स चलाने के लिए Bitte Protocol एकीकरण।
- [chargebee/mcp](https://github.com/chargebee/agentkit/tree/main/modelcontextprotocol) 🎖️ 📇 ☁️ - एआई एजेंट्स को [Chargebee platform](https://www.chargebee.com/) से जोड़ने वाला MCP सर्वर।
- [codex-data/codex-mcp](https://github.com/Codex-Data/codex-mcp) 🎖️ 📇 ☁️ - 60+ नेटवर्क पर रियल-टाइम समृद्ध ब्लॉकचेन और बाजार डेटा के लिए [Codex API](https://www.codex.io) एकीकरण
- [coinpaprika/dexpaprika-mcp](https://github.com/chargebee/agentkit/tree/main/modelcontextprotocol) 🎖️ 📇 ☁️ 🍎 🪟 🐧 - Coinpaprika का DexPaprika MCP सर्वर उच्च-प्रदर्शन [DexPaprika API](https://docs.dexpaprika.com) को उजागर करता है, जो 20+ चेन और 5M+ टोकन के साथ रियल टाइम प्राइसिंग, लिक्विडिटी पूल डेटा और ऐतिहासिक OHLCV डेटा प्रदान करता है, जिससे एआई एजेंट्स को Model Context Protocol के माध्यम से व्यापक बाजार डेटा तक मानकीकृत एक्सेस मिलता है।
- [doggybee/mcp-server-ccxt](https://github.com/doggybee/mcp-server-ccxt) 📇 ☁️ - CCXT लाइब्रेरी का उपयोग करते हुए 20+ एक्सचेंजों के माध्यम से रियल-टाइम क्रिप्टो मार्केट डेटा और ट्रेडिंग के लिए MCP सर्वर। स्पॉट, फ्यूचर्स, OHLCV, बैलेंस, ऑर्डर आदि को सपोर्ट करता है।
- [ferdousbhai/investor-agent](https://github.com/ferdousbhai/investor-agent) 🐍 ☁️ - याहू फाइनेंस एकीकरण, जिसमें स्टॉक मार्केट डेटा और विकल्प सिफारिशें शामिल हैं
- [ferdousbhai/tasty-agent](https://github.com/ferdousbhai/tasty-agent) 🐍 ☁️ - Tastytrade पर ट्रेडिंग गतिविधियों को संभालने के लिए Tastyworks API एकीकरण
- [ferdousbhai/wsb-analyst-mcp](https://github.com/ferdousbhai/wsb-analyst-mcp) 🐍 ☁️ - WallStreetBets कम्युनिटी की सामग्री का विश्लेषण करने के लिए Reddit एकीकरण
- [getalby/nwc-mcp-server](https://github.com/getalby/nwc-mcp-server) 📇 🏠 - Nostr Wallet Connect द्वारा संचालित बिटकॉइन लाइटनिंग वॉलेट एकीकरण
- [heurist-network/heurist-mesh-mcp-server](https://github.com/heurist-network/heurist-mesh-mcp-server) 🎖️ ⛅️ 🏠 🐍 - Heurist Mesh नेटवर्क के माध्यम से ब्लॉकचेन विश्लेषण, स्मार्ट कॉन्ट्रैक्ट सुरक्षा ऑडिटिंग, टोकन मेट्रिक्स मूल्यांकन और ऑन-चेन इंटरैक्शन के लिए विशेष वेब3 एआई एजेंट्स तक पहुँच प्रदान करता है। DeFi विश्लेषण, NFT मूल्यांकन और कई ब्लॉकचेन पर लेन-देन की निगरानी के लिए व्यापक उपकरण प्रदान करता है।
- [intentos-labs/beeper-mcp](https://github.com/intentos-labs/beeper-mcp) 🐍 - Beeper, BSC पर ट्रांजेक्शन, बैलेंस/टोकन ट्रांसफर, Pancakeswap में टोकन स्वैप और beeper रिवॉर्ड क्लेम्स प्रदान करता है।
- [kukapay/blockbeats-mcp](https://github.com/kukapay/blockbeats-mcp) 🐍 ☁️ - एआई एजेंट्स के लिए BlockBeats से ब्लॉकचेन समाचार और गहन लेख प्रदान करने वाला MCP सर्वर।
- [kukapay/bridge-rates-mcp](https://github.com/kukapay/bridge-rates-mcp) 📇 ☁️ - ऑनचेन एआई एजेंट्स के लिए रियल-टाइम क्रॉस-चेन ब्रिज रेट्स और इष्टतम ट्रांसफर रूट्स प्रदान करना।
- [kukapay/chainlink-feeds-mcp](https://github.com/kukapay/chainlink-feeds-mcp) 📇 ☁️ -  Chainlink के विकेंद्रीकृत ऑन-चेन प्राइस फीड्स तक रियल-टाइम एक्सेस प्रदान करता है।
- [kukapay/cointelegraph-mcp](https://github.com/kukapay/cointelegraph-mcp) 🐍 ☁️ -  Cointelegraph से नवीनतम समाचारों तक रियल-टाइम एक्सेस प्रदान करता है।
- [kukapay/crypto-feargreed-mcp](https://github.com/kukapay/crypto-feargreed-mcp) 🐍 ☁️ -  रियल-टाइम और ऐतिहासिक Crypto Fear & Greed Index डेटा प्रदान करता है।
- [kukapay/crypto-indicators-mcp](https://github.com/kukapay/crypto-indicators-mcp) 🐍 ☁️ - कई क्रिप्टोकरेंसी तकनीकी विश्लेषण संकेतकों और रणनीतियों के लिए MCP सर्वर।
- [kukapay/crypto-news-mcp](https://github.com/kukapay/crypto-news-mcp) 🐍 ☁️ - एआई एजेंट्स के लिए NewsData से वास्तविक समय की क्रिप्टोकरेंसी समाचार प्रदान करने वाला MCP सर्वर।
- [kukapay/crypto-portfolio-mcp](https://github.com/kukapay/crypto-portfolio-mcp) 🐍 ☁️ - क्रिप्टोकरेंसी पोर्टफोलियो आवंटनों को ट्रैक और प्रबंधित करने के लिए MCP सर्वर।
- [kukapay/crypto-rss-mcp](https://github.com/kukapay/crypto-rss-mcp) 🐍 ☁️ - कई RSS फ़ीड से एकत्रित वास्तविक समय की क्रिप्टोकरेंसी समाचार प्रदान करने वाला MCP सर्वर।
- [kukapay/crypto-sentiment-mcp](https://github.com/kukapay/crypto-sentiment-mcp) 🐍 ☁️ - एआई एजेंट्स के लिए क्रिप्टोकरेंसी सेंटिमेंट विश्लेषण प्रदान करने वाला MCP सर्वर।
- [kukapay/crypto-trending-mcp](https://github.com/kukapay/crypto-trending-mcp) 🐍 ☁️ - CoinGecko पर नवीनतम ट्रेंडिंग टोकन्स को ट्रैक करना।
- [kukapay/crypto-whitepapers-mcp](https://github.com/kukapay/crypto-whitepapers-mcp) 🐍 ☁️ - क्रिप्टो श्वेतपत्रों का एक संरचित ज्ञान आधार के रूप में कार्य करता है।
- [kukapay/cryptopanic-mcp-server](https://github.com/kukapay/cryptopanic-mcp-server) 🐍 ☁️ - एआई एजेंट्स को नवीनतम क्रिप्टोकरेंसी समाचार प्रदान करना, CryptoPanic द्वारा संचालित।
- [kukapay/defi-yields-mcp](https://github.com/kukapay/defi-yields-mcp) 🐍 ☁️ - एआई एजेंट्स के लिए DeFi यील्ड अवसरों की खोज के लिए MCP सर्वर।
- [kukapay/dune-analytics-mcp](https://github.com/kukapay/dune-analytics-mcp) 🐍 ☁️ -  Dune Analytics डेटा को एआई एजेंट्स तक पहुँचाने वाला MCP सर्वर।
- [kukapay/etf-flow-mcp](https://github.com/kukapay/etf-flow-mcp) 🐍 ☁️ -  क्रिप्टो ETF फ्लो डेटा प्रदान करता है ताकि एआई एजेंट्स के निर्णय लेने की शक्ति बढ़ सके।
- [kukapay/freqtrade-mcp](https://github.com/kukapay/freqtrade-mcp) 🐍 ☁️ - Freqtrade क्रिप्टोकरेंसी ट्रेडिंग बॉट के साथ एकीकृत MCP सर्वर।
- [kukapay/funding-rates-mcp](https://github.com/kukapay/funding-rates-mcp) 🐍 ☁️ - प्रमुख क्रिप्टो एक्सचेंजों में रियल-टाइम फंडिंग रेट डेटा प्रदान करता है।
- [kukapay/jupiter-mcp](https://github.com/kukapay/jupiter-mcp) 🐍 ☁️ - Jupiter के नए Ultra API का उपयोग करके Solana ब्लॉकचेन पर टोकन स्वैप को निष्पादित करने के लिए MCP सर्वर।
- [kukapay/pancakeswap-poolspy-mcp](https://github.com/kukapay/pancakeswap-poolspy-mcp) 🐍 ☁️ -  Pancake Swap पर हाल ही में बनाए गए पूल को ट्रैक करने वाला MCP सर्वर।
- [kukapay/rug-check-mcp](https://github.com/kukapay/rug-check-mcp) 🐍 ☁️ - Solana मीम टोकन्स में संभावित जोखिमों का पता लगाने वाला MCP सर्वर।
- [kukapay/thegraph-mcp](https://github.com/kukapay/thegraph-mcp) 🐍 ☁️ -  The Graph से अनुक्रमित ब्लॉकचेन डेटा के साथ एआई एजेंट्स को सशक्त करने वाला MCP सर्वर।
- [kukapay/token-minter-mcp](https://github.com/kukapay/token-minter-mcp) 🐍 ☁️ -  कई ब्लॉकचेन में एआई एजेंट्स के लिए ERC-20 टोकन मिंट करने के उपकरण प्रदान करने वाला MCP सर्वर।
- [kukapay/token-revoke-mcp](https://github.com/kukapay/token-revoke-mcp) 🐍 ☁️ - कई ब्लॉकचेन में ERC-20 टोकन अनुमतियों की जाँच और निरस्त करने के लिए MCP सर्वर।
- [kukapay/twitter-username-changes-mcp](https://github.com/kukapay/twitter-username-changes-mcp) 🐍 ☁️ - ट्विटर उपयोगकर्ता नामों के ऐतिहासिक परिवर्तनों को ट्रैक करने वाला MCP सर्वर।
- [kukapay/uniswap-poolspy-mcp](https://github.com/kukapay/uniswap-poolspy-mcp) 🐍 ☁️ -  कई ब्लॉकचेन में Uniswap पर हाल ही में बनाए गए लिक्विडिटी पूल को ट्रैक करने वाला MCP सर्वर।
- [kukapay/uniswap-trader-mcp](https://github.com/kukapay/uniswap-trader-mcp) 🐍 ☁️ -  कई ब्लॉकचेन में Uniswap DEX पर टोकन स्वैप को स्वचालित करने के लिए एआई एजेंट्स के लिए MCP सर्वर।
- [kukapay/whale-tracker-mcp](https://github.com/kukapay/whale-tracker-mcp) 🐍 ☁️ -  क्रिप्टोकरेंसी व्हेल ट्रांजेक्शन को ट्रैक करने वाला MCP सर्वर।
- [laukikk/alpaca-mcp](https://github.com/laukikk/alpaca-mcp) 🐍 ☁️ - Alpaca ट्रेडिंग API के लिए MCP सर्वर, जिसमें स्टॉक और क्रिप्टो पोर्टफोलियो प्रबंधन, ट्रेड प्लेसमेंट और बाजार डेटा एक्सेस शामिल है।
- [longportapp/openapi](https://github.com/longportapp/openapi/tree/main/mcp) - 🐍 ☁️ - LongPort OpenAPI रियल-टाइम स्टॉक मार्केट डेटा प्रदान करता है, MCP के माध्यम से एआई विश्लेषण और ट्रेडिंग क्षमताएं प्रदान करता है।
- [mcpdotdirect/evm-mcp-server](https://github.com/mcpdotdirect/evm-mcp-server) 📇 ☁️ - 30+ EVM नेटवर्क्स के लिए व्यापक ब्लॉकचेन सेवाएं, जिसमें मूल टोकन, ERC20, NFT, स्मार्ट कॉन्ट्रैक्ट्स, लेन-देन, और ENS समाधान का समर्थन।
- [mcpdotdirect/starknet-mcp-server](https://github.com/mcpdotdirect/starknet-mcp-server) 📇 ☁️ - Starknet ब्लॉकचेन एकीकरण, जिसमें मूल टोकन (ETH, STRK), स्मार्ट कॉन्ट्रैक्ट्स, StarknetID समाधान और टोकन ट्रांसफर का समर्थन।
- [minhyeoky/mcp-server-ledger](https://github.com/minhyeoky/mcp-server-ledger) 🐍 🏠 -  लेजर-क्लि एकीकरण, वित्तीय लेन-देन प्रबंधन और रिपोर्ट जनरेट करने के लिए।
- [openMF/mcp-mifosx](https://github.com/openMF/mcp-mifosx) ☁️ 🏠 -  मुख्य बैंकिंग एकीकरण, जिसमें क्लाइंट, लोन, बचत, शेयर, वित्तीय लेन-देन प्रबंधन और वित्तीय रिपोर्ट जनरेट करना शामिल है।
- [narumiruna/yfinance-mcp](https://github.com/narumiruna/yfinance-mcp) 🐍 ☁️ - Yahoo Finance से जानकारी प्राप्त करने के लिए yfinance का उपयोग करने वाला MCP सर्वर।
- [polygon-io/mcp_polygon)](https://github.com/polygon-io/mcp_polygon)) 🐍 ☁️ -  MCP सर्वर जो [Polygon.io](https://polygon.io/) वित्तीय बाजार डेटा APIs तक पहुँच प्रदान करता है, जिसमें स्टॉक्स, इंडेक्स, फॉरेक्स, ऑप्शंस, और बहुत कुछ शामिल है।
- [pwh-pwh/coin-mcp-server](https://github.com/pwh-pwh/coin-mcp-server) 🐍 ☁️ -  क्रिप्टोकरेंसी प्राइस प्राप्त करने के लिए Bitget API।
- [QuantGeekDev/coincap-mcp](https://github.com/QuantGeekDev/coincap-mcp) 📇 ☁️ - CoinCap की सार्वजनिक API का उपयोग करते हुए रियल-टाइम क्रिप्टोकरेंसी मार्केट डेटा एकीकरण, एपीआई कुंजी के बिना क्रिप्टो कीमतों और बाजार जानकारी तक पहुँच प्रदान करता है
- [SaintDoresh/Crypto-Trader-MCP-ClaudeDesktop](https://github.com/SaintDoresh/Crypto-Trader-MCP-ClaudeDesktop.git) 🐍 ☁️ - CoinGecko API का उपयोग करते हुए क्रिप्टोकरेंसी मार्केट डेटा प्रदान करने वाला MCP टूल।
- [tooyipjee/yahoofinance-mcp](https://github.com/tooyipjee/yahoofinance-mcp.git) 📇 ☁️ - याहू फाइनेंस MCP का TS संस्करण।
- [SaintDoresh/YFinance-Trader-MCP-ClaudeDesktop](https://github.com/SaintDoresh/YFinance-Trader-MCP-ClaudeDesktop.git) 🐍 ☁️ - याहू फाइनेंस API का उपयोग करते हुए स्टॉक मार्केट डेटा और विश्लेषण प्रदान करने वाला MCP टूल।
- [RomThpt/xrpl-mcp-server](https://github.com/RomThpt/mcp-xrpl) 📇 ☁️ - XRP लेजर के लिए MCP सर्वर, जो खाता जानकारी, ट्रांजेक्शन इतिहास और नेटवर्क डेटा तक पहुँच प्रदान करता है। लेजर ऑब्जेक्ट्स क्वेरी करने, ट्रांजेक्शन सबमिट करने, और XRPL नेटवर्क की निगरानी की अनुमति देता है।
- [janswist/mcp-dexscreener](https://github.com/janswist/mcp-dexscreener) 📇 ☁️ - मुक्त और ओपन Dexscreener API का उपयोग करते हुए ऑन-चेन मार्केट प्राइस रियल-टाइम में
- [HuggingAGI/mcp-baostock-server](https://github.com/HuggingAGI/mcp-baostock-server) 🐍 ☁️ - baostock आधारित MCP सर्वर, जो चीनी स्टॉक बाजार डेटा के लिए एक्सेस और विश्लेषण क्षमताएँ प्रदान करता है।
- [wowinter13/solscan-mcp](https://github.com/wowinter13/solscan-mcp) 🦀 🏠 - प्राकृतिक भाषा के साथ Solscan API के उपयोग से Solana ट्रांजेक्शन क्वेरी करने के लिए MCP टूल।
- [Wuye-AI/mcp-server-wuye-ai](https://github.com/wuye-ai/mcp-server-wuye-ai) 🎖️ 📇 ☁️ - CRIC Wuye AI प्लेटफार्म की क्षमताओं के साथ इंटरैक्ट करने वाला MCP सर्वर, जो विशेष रूप से संपत्ति प्रबंधन उद्योग के लिए एक बुद्धिमान सहायक है।
- [zlinzzzz/finData-mcp-server](https://github.com/zlinzzzz/finData-mcp-server) 🐍 ☁️ - पेशेवर वित्तीय डेटा तक पहुंच के लिए MCP सर्वर, जो Tushare जैसे कई डेटा प्रदाताओं का समर्थन करता है।

### 🎮 <a name="gaming"></a>गेमिंग

गेमिंग संबंधित डेटा, गेम इंजन और सेवाओं के साथ एकीकरण

- [IvanMurzak/Unity-MCP](https://github.com/IvanMurzak/Unity-MCP) #️⃣ 🏠 🍎 🪟 🐧 - Unity Editor और Unity के साथ बनाए गए गेम के लिए MCP सर्वर
- [CoderGamester/mcp-unity](https://github.com/CoderGamester/mcp-unity) #️⃣ 🏠 - गेम डेवलपमेंट के लिए Unity3d Game Engine इंटीग्रेशन के लिए MCP सर्वर
- [Coding-Solo/godot-mcp](https://github.com/Coding-Solo/godot-mcp) 📇 🏠 - Godot गेम इंजन के साथ इंटरएक्ट करने के लिए MCP सर्वर, Godot प्रोजेक्ट्स में सीन संपादित करने, चलाने, डिबग करने और प्रबंधित करने के उपकरण प्रदान करता है।
- [pab1ito/chess-mcp](https://github.com/pab1it0/chess-mcp) 🐍 ☁️ - Chess.com प्लेयर डेटा, गेम रिकॉर्ड और अन्य सार्वजनिक जानकारी तक मानकीकृत MCP इंटरफेस के माध्यम से एक्सेस, जिससे एआई सहायक शतरंज की जानकारी खोज और विश्लेषण कर सकते हैं।
- [jiayao/mcp-chess](https://github.com/jiayao/mcp-chess) 🐍 🏠 - LLMs के खिलाफ शतरंज खेलने के लिए MCP सर्वर।
- [rishijatia/fantasy-pl-mcp](https://github.com/rishijatia/fantasy-pl-mcp/) 🐍 ☁️ - रियल-टाइम Fantasy Premier League डेटा और विश्लेषण उपकरणों के लिए MCP सर्वर।
- [opgginc/opgg-mcp](https://github.com/opgginc/opgg-mcp) 📇 ☁️ - League of Legends, TFT, और Valorant जैसे लोकप्रिय टाइटल्स में रियल-टाइम गेमिंग डेटा एक्सेस करें, जिसमें चैंपियन एनालिटिक्स, ईस्पोर्ट्स शेड्यूल, मेटा कंपोजीशन और कैरेक्टर स्टैटिस्टिक्स शामिल हैं।
- [stefan-xyz/mcp-server-runescape](https://github.com/stefan-xyz/mcp-server-runescape) 📇 - RuneScape (RS) और Old School RuneScape (OSRS) डेटा के साथ इंटरएक्ट करने के लिए टूल्स के साथ MCP सर्वर, जिसमें आइटम प्राइस, प्लेयर हाईस्कोर्स और बहुत कुछ शामिल हैं।

### 🧠 <a name="knowledge--memory"></a>ज्ञान और मेमोरी

नॉलेज ग्राफ संरचनाओं का उपयोग करते हुए स्थायी मेमोरी स्टोरेज। एआई मॉडल को सत्रों में संरचित जानकारी बनाए रखने और क्वेरी करने में सक्षम बनाता है।
- [CheMiguel23/MemoryMesh](https://github.com/CheMiguel23/MemoryMesh) 📇 🏠 - AI भूमिका-निर्माण और कहानी निर्माण पर केंद्रित उन्नत ग्राफ-आधारित मेमोरी
- [graphlit-mcp-server](https://github.com/graphlit/graphlit-mcp-server) 📇 ☁️ - किसी भी चीज़ को Slack, Discord, वेबसाइट्स, Google Drive, Linear या GitHub से Graphlit प्रोजेक्ट में इम्पोर्ट करें - और फिर Cursor, Windsurf या Cline जैसे MCP क्लाइंट में प्रासंगिक ज्ञान को खोजें और प्राप्त करें।
- [hannesrudolph/mcp-ragdocs](https://github.com/hannesrudolph/mcp-ragdocs) 🐍 🏠 - एक MCP सर्वर इम्प्लीमेंटेशन जो वेक्टर सर्च के माध्यम से डाक्यूमेंटेशन प्राप्त और प्रोसेस करने के टूल्स प्रदान करता है, जिससे AI असिस्टेंट्स अपने उत्तरों को प्रासंगिक डाक्यूमेंटेशन संदर्भ से संवर्धित कर सकते हैं।
- [jinzcdev/markmap-mcp-server](https://github.com/jinzcdev/markmap-mcp-server) 📇 🏠 - [markmap](https://github.com/markmap/markmap) पर आधारित एक MCP सर्वर जो **Markdown** को इंटरैक्टिव **माइंड मैप्स** में बदलता है। मल्टी-फॉर्मेट एक्सपोर्ट (PNG/JPG/SVG), लाइव ब्राउज़र प्रीव्यू, वन-क्लिक मार्कडाउन कॉपी और डायनामिक विज़ुअलाइज़ेशन फीचर्स को सपोर्ट करता है।
- [kaliaboi/mcp-zotero](https://github.com/kaliaboi/mcp-zotero) 📇 ☁️ - LLMs को आपके Zotero क्लाउड पर कलेक्शंस और स्रोतों के साथ काम करने के लिए एक कनेक्टर
- [mcp-summarizer](https://github.com/0xshellming/mcp-summarizer) 📕 ☁️ - AI सारांश MCP सर्वर, कई कंटेंट टाइप्स के लिए सपोर्ट: सादा टेक्स्ट, वेब पेज, PDF डाक्यूमेंट्स, EPUB किताबें, HTML कंटेंट
- [mem0ai/mem0-mcp](https://github.com/mem0ai/mem0-mcp) 🐍 🏠 - Mem0 के लिए एक Model Context Protocol सर्वर जो कोडिंग प्राथमिकताओं और पैटर्न्स का प्रबंधन करने में मदद करता है, कोड इम्प्लीमेंटेशन, सर्वोत्तम प्रथाओं और तकनीकी डाक्यूमेंटेशन को IDEs जैसे Cursor और Windsurf में संग्रहीत, प्राप्त और सेमांटिक रूप से संभालने के टूल्स प्रदान करता है।
- [modelcontextprotocol/server-memory](https://github.com/modelcontextprotocol/servers/tree/main/src/memory) 📇 🏠 - सन्दर्भ बनाए रखने के लिए ज्ञान ग्राफ-आधारित स्थायी मेमोरी सिस्टम
- [pinecone-io/assistant-mcp](https://github.com/pinecone-io/assistant-mcp) 🎖️ 🦀 ☁️ - आपके Pinecone Assistant से कनेक्ट करता है और एजेंट को उसके नॉलेज इंजन से सन्दर्भ देता है।
- [@ragieai/mcp-server](https://github.com/ragieai/ragie-mcp-server) 📇 ☁️ - अपनी [Ragie](https://www.ragie.ai) (RAG) नॉलेज बेस से सन्दर्भ प्राप्त करें, जो Google Drive, Notion, JIRA आदि जैसी इंटीग्रेशन्स से जुड़ा है।
- [TechDocsStudio/biel-mcp](https://github.com/TechDocsStudio/biel-mcp) 📇 ☁️ - Cursor, VS Code या Claude Desktop जैसे AI टूल्स को आपके उत्पाद डाक्यूमेंट्स का उपयोग करके सवालों के उत्तर देने दें। Biel.ai RAG सिस्टम और MCP सर्वर प्रदान करता है।
- [topoteretes/cognee](https://github.com/topoteretes/cognee/tree/dev/cognee-mcp) 📇 🏠 - AI ऐप्स और एजेंट्स के लिए मेमोरी मैनेजर, विभिन्न ग्राफ और वेक्टर स्टोर्स का उपयोग करता है और 30+ डेटा स्रोतों से इम्पोर्ट की अनुमति देता है।
- [unibaseio/membase-mcp](https://github.com/unibaseio/membase-mcp) 📇 ☁️ - Membase द्वारा वितरित तरीके से अपने एजेंट मेमोरी को सहेजें और क्वेरी करें
- [GistPad-MCP](https://github.com/lostintangent/gistpad-mcp) 📇 🏠 - व्यक्तिगत ज्ञान, दैनिक नोट्स, और पुन: प्रयोज्य प्रॉम्प्ट्स को प्रबंधित और एक्सेस करने के लिए GitHub Gists का उपयोग करें। यह https://gistpad.dev और [GistPad VS Code एक्सटेंशन](https://aka.ms/gistpad) के लिए सहायक है।
- [entanglr/zettelkasten-mcp](https://github.com/entanglr/zettelkasten-mcp) 🐍 🏠 - एक Model Context Protocol (MCP) सर्वर जो Zettelkasten ज्ञान प्रबंधन पद्धति को लागू करता है, जिससे आप Claude और अन्य MCP-संगत क्लाइंट्स के माध्यम से एटॉमिक नोट्स बना, लिंक और खोज सकते हैं।

### 🗺️ <a name="location-services"></a>लोकेशन सर्विसेज

स्थान-आधारित सेवाएँ और मैपिंग टूल्स। यह AI मॉडल्स को भौगोलिक डेटा, मौसम संबंधी जानकारी और स्थान-आधारित एनालिटिक्स के साथ काम करने में सक्षम बनाता है।

- [briandconnelly/mcp-server-ipinfo](https://github.com/briandconnelly/mcp-server-ipinfo) 🐍 ☁️  - IPInfo API का उपयोग करके IP पता जियोलोकेशन और नेटवर्क जानकारी
- [devilcoder01/weather-mcp-server](https://github.com/devilcoder01/weather-mcp-server) 🐍 ☁️ - WeatherAPI.com API का उपयोग करके किसी भी स्थान के लिए रीयल-टाइम मौसम डेटा प्राप्त करें, विस्तृत पूर्वानुमान और वर्तमान स्थितियों के साथ।
- [jagan-shanmugam/open-streetmap-mcp](https://github.com/jagan-shanmugam/open-streetmap-mcp) 🐍 🏠 - OpenStreetMap MCP सर्वर जिसमें स्थान-आधारित सेवाएं और भू-स्थानिक डेटा शामिल हैं।
- [kukapay/nearby-search-mcp](https://github.com/kukapay/nearby-search-mcp) 🐍 ☁️ - IP-आधारित स्थान डिटेक्शन के साथ पास के स्थानों की खोज के लिए MCP सर्वर।
- [modelcontextprotocol/server-google-maps](https://github.com/modelcontextprotocol/servers/tree/main/src/google-maps) 📇 ☁️ - स्थान सेवाओं, मार्ग-निर्धारण और स्थान विवरण के लिए Google Maps इंटीग्रेशन
- [QGIS MCP](https://github.com/jjsantos01/qgis_mcp) - QGIS Desktop को Claude AI से MCP के माध्यम से जोड़ता है। यह इंटीग्रेशन प्रॉम्प्ट-सहायता प्राप्त प्रोजेक्ट निर्माण, लेयर लोडिंग, कोड निष्पादन आदि को सक्षम बनाता है।
- [SaintDoresh/Weather-MCP-ClaudeDesktop](https://github.com/SaintDoresh/Weather-MCP-ClaudeDesktop.git) 🐍 ☁️ - OpenWeatherMap API का उपयोग करके वास्तविक समय का मौसम डेटा, पूर्वानुमान और ऐतिहासिक मौसम जानकारी प्रदान करने वाला एक MCP टूल।
- [rossshannon/Weekly-Weather-mcp](https://github.com/rossshannon/weekly-weather-mcp.git) 🐍 ☁️ - साप्ताहिक मौसम MCP सर्वर जो दुनिया में कहीं भी 7 पूर्ण दिनों के विस्तृत मौसम पूर्वानुमान लौटाता है।
- [SecretiveShell/MCP-timeserver](https://github.com/SecretiveShell/MCP-timeserver) 🐍 🏠 - किसी भी टाइमज़ोन में समय एक्सेस करें और वर्तमान स्थानीय समय प्राप्त करें
- [TimLukaHorstmann/mcp-weather](https://github.com/TimLukaHorstmann/mcp-weather) 📇 ☁️  - AccuWeather API (नि:शुल्क टियर उपलब्ध) के माध्यम से सटीक मौसम पूर्वानुमान।
- [webcoderz/MCP-Geo](https://github.com/webcoderz/MCP-Geo) 🐍 🏠 - nominatim, ArcGIS, Bing के लिए जियोकोडिंग MCP सर्वर
- [ipfind/ipfind-mcp-server](https://github.com/ipfind/ipfind-mcp-server) 🐍 ☁️ - [IP Find](https://ipfind.com) API का उपयोग करके IP पता स्थान सेवा
- [mahdin75/geoserver-mcp](https://github.com/mahdin75/geoserver-mcp) 🏠 – एक Model Context Protocol (MCP) सर्वर इम्प्लीमेंटेशन जो LLMs को GeoServer REST API से जोड़ता है, जिससे AI असिस्टेंट्स भू-स्थानिक डेटा और सेवाओं के साथ इंटरैक्ट कर सकते हैं।
- [ipfred/aiwen-mcp-server-geoip](https://github.com/ipfred/aiwen-mcp-server-geoip) 🐍 📇 ☁️ – Aiwen IP Location के लिए MCP सर्वर, उपयोगकर्ता नेटवर्क IP स्थान प्राप्त करें, IP विवरण प्राप्त करें (देश, प्रांत, शहर, अक्षांश, देशांतर, ISP, स्वामी, आदि।)

### 🎯 <a name="marketing"></a>मार्केटिंग

मार्केटिंग कंटेंट बनाने और संपादित करने, वेब मेटा डेटा, उत्पाद पोजिशनिंग, और एडिटिंग गाइड्स के लिए टूल्स।

- [gomarble-ai/facebook-ads-mcp-server](https://github.com/gomarble-ai/facebook-ads-mcp-server) 🐍 ☁️ - Facebook Ads के लिए इंटरफेस के रूप में कार्य करने वाला MCP सर्वर, जो Facebook Ads डेटा और प्रबंधन सुविधाओं तक प्रोग्रामेटिक एक्सेस को सक्षम बनाता है।
- [open-strategy-partners/osp_marketing_tools](https://github.com/open-strategy-partners/osp_marketing_tools) 🐍 🏠 - Open Strategy Partners से मार्केटिंग टूल्स का एक सूट जिसमें लेखन शैली, संपादन कोड, और उत्पाद मार्केटिंग वैल्यू मैप निर्माण शामिल है।
- [nictuku/meta-ads-mcp](https://github.com/nictuku/meta-ads-mcp) 🐍 ☁️ 🏠 - AI एजेंट्स को Meta विज्ञापन प्रदर्शन की निगरानी और अनुकूलन, अभियान मेट्रिक्स का विश्लेषण, ऑडियंस टार्गेटिंग समायोजित करने, क्रिएटिव एसेट्स प्रबंधित करने, और विज्ञापन खर्च और अभियान सेटिंग्स के लिए डेटा-आधारित अनुशंसाएँ देने में सक्षम बनाता है, वह भी निर्बाध Graph API इंटीग्रेशन के साथ।
- [marketplaceadpros/amazon-ads-mcp-server](https://github.com/MarketplaceAdPros/amazon-ads-mcp-server) 📇 ☁️  - Amazon Advertising के साथ इंटरैक्शन के लिए टूल्स को सक्षम करता है, अभियान मेट्रिक्स और कॉन्फ़िगरेशन्स का विश्लेषण करता है।

### 📊 <a name="monitoring"></a>मॉनिटरिंग

एप्लिकेशन मॉनिटरिंग डेटा तक पहुँचें और उसका विश्लेषण करें। AI मॉडल्स को त्रुटि रिपोर्ट और प्रदर्शन मेट्रिक्स की समीक्षा करने में सक्षम बनाता है।

- [netdata/netdata#Netdata](https://github.com/netdata/netdata/blob/master/src/web/mcp/README.md) 🎖️ 🏠 ☁️ 📟 🍎 🪟 🐧 - सभी ऑब्ज़र्वेबिलिटी डेटा, जैसे कि मेट्रिक्स, लॉग्स, सिस्टम्स, कंटेनर्स, प्रोसेसेस और नेटवर्क कनेक्शन्स का डिस्कवरी, एक्सप्लोरेशन, रिपोर्टिंग और रूट कॉज एनालिसिस
- [grafana/mcp-grafana](https://github.com/grafana/mcp-grafana) 🎖️ 🐍 🏠 ☁️ - अपने Grafana इंस्टेंस में डैशबोर्ड्स खोजें, घटनाओं की जांच करें और डेटा स्रोतों से क्वेरी करें
- [tumf/grafana-loki-mcp](https://github.com/tumf/grafana-loki-mcp) 🐍 🏠 - एक MCP सर्वर जो Grafana API के माध्यम से Loki लॉग्स को क्वेरी करने की अनुमति देता है।
- [hyperb1iss/lucidity-mcp](https://github.com/hyperb1iss/lucidity-mcp) 🐍 🏠 - जटिलता से लेकर सुरक्षा कमजोरियों तक 10 महत्वपूर्ण आयामों में बुद्धिमान, प्रॉम्प्ट-आधारित विश्लेषण के माध्यम से AI-जनित कोड की गुणवत्ता बढ़ाएँ
- [last9/last9-mcp-server](https://github.com/last9/last9-mcp-server) - वास्तविक समय के प्रोडक्शन सन्दर्भ—लॉग्स, मेट्रिक्स, और ट्रेसेस—को अपने लोकल वातावरण में निर्बाध रूप से लाएँ ताकि कोड को तेज़ी से ऑटो-फिक्स किया जा सके
- [metoro-io/metoro-mcp-server](https://github.com/metoro-io/metoro-mcp-server) 🎖️ 🏎️ ☁️ - Metoro द्वारा मॉनिटर किए गए Kubernetes वातावरणों के साथ क्वेरी और इंटरैक्ट करें
- [MindscapeHQ/server-raygun](https://github.com/MindscapeHQ/mcp-server-raygun) 📇 ☁️ - क्रैश रिपोर्टिंग और रियल यूज़र मॉनिटरिंग के लिए Raygun API V3 इंटीग्रेशन
- [modelcontextprotocol/server-sentry](https://github.com/modelcontextprotocol/servers/tree/main/src/sentry) 🐍 ☁️ - त्रुटि ट्रैकिंग और प्रदर्शन मॉनिटरिंग के लिए Sentry.io इंटीग्रेशन
- [pydantic/logfire-mcp](https://github.com/pydantic/logfire-mcp) 🎖️ 🐍 ☁️ - Logfire के माध्यम से OpenTelemetry ट्रेसेस और मेट्रिक्स तक पहुँच प्रदान करता है
- [seekrays/mcp-monitor](https://github.com/seekrays/mcp-monitor) 🏎️ 🏠 - एक सिस्टम मॉनिटरिंग टूल जो Model Context Protocol (MCP) के माध्यम से सिस्टम मेट्रिक्स को एक्सपोज़ करता है। यह टूल LLMs को MCP-संगत इंटरफेस के माध्यम से वास्तविक समय की सिस्टम जानकारी प्राप्त करने की अनुमति देता है। (सपोर्ट: CPU, Memory, Disk, Network, Host, Process)
- [VictoriaMetrics-Community/mcp-victoriametrics](https://github.com/VictoriaMetrics-Community/mcp-victoriametrics) 🎖️ 🏎️ 🏠 - आपके [VictoriaMetrics instance APIs](https://docs.victoriametrics.com/victoriametrics/url-examples/) और [डाक्यूमेंटेशन](https://docs.victoriametrics.com/) के साथ व्यापक इंटीग्रेशन प्रदान करता है, जो VictoriaMetrics इंस्टेन्सेस से संबंधित मॉनिटरिंग, ऑब्ज़र्वेबिलिटी और डिबगिंग कार्यों के लिए है

### 🎥 <a name="multimedia-process"></a>मल्टीमीडिया प्रोसेस

मल्टीमीडिया को संभालने की क्षमता प्रदान करता है, जैसे ऑडियो और वीडियो संपादन, प्लेबैक, फॉर्मेट रूपांतरण, साथ ही वीडियो फिल्टर, संवर्धन आदि।

- [video-creator/ffmpeg-mcp](https://github.com/video-creator/ffmpeg-mcp.git) 🎥 🔊 - ffmpeg कमांड लाइन का उपयोग करके एक mcp सर्वर प्राप्त करें, जो संवाद के माध्यम से स्थानीय वीडियो खोज, कटिंग, सिलाई, प्लेबैक और अन्य कार्यों को बहुत सुविधाजनक ढंग से प्राप्त कर सकता है
- [stass/exif-mcp](https://github.com/stass/exif-mcp) 📇 🏠 🐧 🍎 🪟 - एक MCP सर्वर जो छवि मेटाडेटा जैसे EXIF, XMP, JFIF और GPS की जांच करने की अनुमति देता है। यह फोटो लाइब्रेरीज़ और छवि संग्रहों की LLM-समर्थित खोज और विश्लेषण की नींव प्रदान करता है।
- [sunriseapps/imagesorcery-mcp](https://github.com/sunriseapps/imagesorcery-mcp) 🐍 🏠 🐧 🍎 🪟 - AI असिस्टेंट्स के लिए कंप्यूटर विज़न-आधारित 🪄 छवि पहचान और संपादन टूल्स की जादुई शक्ति।

### 🔎 <a name="search"></a>खोज एवं डेटा निष्कर्षण

- [Xyber-Labs/mcp-server-youtube](https://github.com/Xyber-Labs/mcp-servers/tree/main/mcp-server-youtube) 🐍 ☁️ - यह रिपॉजिटरी YouTube खोज और ट्रांसक्रिप्ट पुनर्प्राप्ति कार्यक्षमता के लिए MCP (Model Context Protocol) सर्वर को लागू करती है। यह भाषा मॉडल या अन्य एजेंट्स को मानकीकृत प्रोटोकॉल के माध्यम से YouTube सामग्री को आसानी से क्वेरी करने की अनुमति देता है।
- [ricocf/mcp-wolframalpha](https://github.com/ricocf/mcp-wolframalpha) 🐍 🏠 ☁️ - एक MCP सर्वर जो AI असिस्टेंट्स को Wolfram Alpha API का उपयोग करके गणनात्मक ज्ञान और डेटा तक वास्तविक समय पहुंच प्रदान करता है।
- [scrapeless-ai/scrapeless-mcp-server](https://github.com/scrapeless-ai/scrapeless-mcp-server) 🐍 ☁️ - Scrapeless Model Context Protocol सेवा Google SERP API के लिए एक MCP सर्वर कनेक्टर के रूप में कार्य करती है, जिससे MCP इकोसिस्टम के भीतर वेब खोज सक्षम होती है।
- [0xdaef0f/job-searchoor](https://github.com/0xDAEF0F/job-searchoor) 📇 🏠 - जॉब लिस्टिंग खोजने के लिए MCP सर्वर, जिसमें तिथि, कीवर्ड, रिमोट वर्क विकल्प आदि के लिए फ़िल्टर हैं।
- [ac3xx/mcp-servers-kagi](https://github.com/ac3xx/mcp-servers-kagi) 📇 ☁️ - Kagi खोज API इंटीग्रेशन
- [andybrandt/mcp-simple-arxiv](https://github.com/andybrandt/mcp-simple-arxiv) - 🐍 ☁️  LLM के लिए arXiv से पेपर्स खोजने और पढ़ने के लिए MCP
- [hbg/mcp-paperswithcode](https://github.com/hbg/mcp-paperswithcode) - 🐍 ☁️ PapersWithCode API के माध्यम से खोज के लिए MCP
- [andybrandt/mcp-simple-pubmed](https://github.com/andybrandt/mcp-simple-pubmed) - 🐍 ☁️  मेडिकल/लाइफ साइंसेज पेपर्स को PubMed से खोजने और पढ़ने के लिए MCP
- [angheljf/nyt](https://github.com/angheljf/nyt) 📇 ☁️ - NYTimes API का उपयोग करके लेख खोजें
- [apify/mcp-server-rag-web-browser](https://github.com/apify/mcp-server-rag-web-browser) 📇 ☁️ - Apify के ओपन-सोर्स RAG Web Browser Actor के लिए MCP सर्वर, जो वेब खोज, URL स्क्रैपिंग, और Markdown में कंटेंट लौटाने में सक्षम है।
- [Bigsy/Clojars-MCP-Server](https://github.com/Bigsy/Clojars-MCP-Server) 📇 ☁️ - Clojure लाइब्रेरीज़ की नवीनतम डिपेंडेंसी जानकारी के लिए Clojars MCP सर्वर
- [blazickjp/arxiv-mcp-server](https://github.com/blazickjp/arxiv-mcp-server) ☁️ 🐍 - ArXiv रिसर्च पेपर्स खोजें
- [luminati-io/brightdata-mcp](https://github.com/luminati-io/brightdata-mcp) 📇 ☁️ - वेब को डिस्कवर, एक्सट्रैक्ट, और इंटरैक्ट करें - एक ही इंटरफेस जो पब्लिक इंटरनेट पर ऑटोमेटेड एक्सेस को पावर देता है।
- [chanmeng/google-news-mcp-server](https://github.com/ChanMeng666/server-google-news) 📇 ☁️ - Google News इंटीग्रेशन जिसमें ऑटोमेटिक टॉपिक कैटेगराइज़ेशन, मल्टी-लैंग्वेज सपोर्ट, और [SerpAPI](https://serpapi.com/) के माध्यम से हैडलाइंस, कहानियाँ और संबंधित टॉपिक्स सहित व्यापक खोज क्षमताएँ हैं।
- [ConechoAI/openai-websearch-mcp](https://github.com/ConechoAI/openai-websearch-mcp/) 🐍 🏠 ☁️ - यह एक Python-आधारित MCP सर्वर है जो OpenAI `web_search` बिल्ट-इन टूल प्रदान करता है।
- [dealx/mcp-server](https://github.com/DealExpress/mcp-server) ☁️ - DealX प्लेटफ़ॉर्म के लिए MCP सर्वर
- [devflowinc/trieve](https://github.com/devflowinc/trieve/tree/main/clients/mcp-server) 🎖️ 📇 ☁️ 🏠 - [Trieve](https://trieve.ai) के माध्यम से डेटा सेट्स को क्रॉल, एम्बेड, चंक, खोजें और जानकारी पुनः प्राप्त करें
- [Dumpling-AI/mcp-server-dumplingai](https://github.com/Dumpling-AI/mcp-server-dumplingai) 🎖️ 📇 ☁️ - [Dumpling AI](https://www.dumplingai.com/) द्वारा डेटा, वेब स्क्रैपिंग, और डाक्यूमेंट कन्वर्ज़न APIs तक पहुँचें
- [erithwik/mcp-hn](https://github.com/erithwik/mcp-hn) 🐍 ☁️ - Hacker News को खोजने, शीर्ष कहानियाँ प्राप्त करने, और अधिक के लिए MCP सर्वर।
- [exa-labs/exa-mcp-server](https://github.com/exa-labs/exa-mcp-server) 🎖️ 📇 ☁️ – एक Model Context Protocol (MCP) सर्वर जो Claude जैसे AI असिस्टेंट्स को Exa AI Search API का उपयोग करके वेब खोजने देता है। यह सेटअप AI मॉडल्स को वास्तविक समय में वेब जानकारी सुरक्षित और नियंत्रित तरीके से प्राप्त करने की अनुमति देता है।
- [fatwang2/search1api-mcp](https://github.com/fatwang2/search1api-mcp) 📇 ☁️ - search1api के माध्यम से खोजें (पेड API कुंजी आवश्यक)
- [genomoncology/biomcp](https://github.com/genomoncology/biomcp) 🐍 ☁️ - PubMed, ClinicalTrials.gov, और MyVariant.info तक पहुँच प्रदान करने वाला बायोमेडिकल रिसर्च सर्वर।
- [hellokaton/unsplash-mcp-server](https://github.com/hellokaton/unsplash-mcp-server)) 🐍 ☁️ - Unsplash छवि खोज के लिए MCP सर्वर।
- [Ihor-Sokoliuk/MCP-SearXNG](https://github.com/ihor-sokoliuk/mcp-searxng) 📇 🏠/☁️ - [SearXNG](https://docs.searxng.org) के लिए एक Model Context Protocol सर्वर
- [isnow890/naver-search-mcp](https://github.com/isnow890/naver-search-mcp) 📇 ☁️ - Naver Search API इंटीग्रेशन के लिए MCP सर्वर, जिसमें ब्लॉग, समाचार, शॉपिंग सर्च और DataLab एनालिटिक्स फीचर्स का सपोर्ट है।
- [jae-jae/fetcher-mcp](https://github.com/jae-jae/fetcher-mcp) 📇 🏠 - वेब पेज कंटेंट प्राप्त करने के लिए MCP सर्वर, Playwright हेडलेस ब्राउज़र का उपयोग करता है, Javascript रेंडरिंग और इंटेलिजेंट कंटेंट एक्सट्रैक्शन को सपोर्ट करता है, और Markdown या HTML फॉर्मेट में आउटपुट देता है।
- [jae-jae/g-search-mcp](https://github.com/jae-jae/g-search-mcp) 📇 🏠 - Google खोज के लिए एक शक्तिशाली MCP सर्वर, जो एक साथ कई कीवर्ड्स के साथ समानांतर खोज की अनुमति देता है।
- [ananddtyagi/webpage-screenshot-mcp](https://github.com/ananddtyagi/webpage-screenshot-mcp) 📇 🏠 - UI डेवेलपमेंट के दौरान फीडबैक के रूप में उपयोग करने के लिए वेबपेजेस के स्क्रीनशॉट लेने के लिए MCP सर्वर।
- [leehanchung/bing-search-mcp](https://github.com/leehanchung/bing-search-mcp) 📇 ☁️ - Microsoft Bing Search API का उपयोग करके वेब खोज क्षमताएँ
- [kagisearch/kagimcp](https://github.com/kagisearch/kagimcp) ☁️ 📇 – आधिकारिक Kagi Search MCP सर्वर
- [kshern/mcp-tavily](https://github.com/kshern/mcp-tavily.git) ☁️ 📇 – Tavily AI सर्च API
- [mikechao/brave-search-mcp](https://github.com/mikechao/brave-search-mcp) 📇 ☁️ - Brave के Search API का उपयोग करते हुए वेब, इमेज, न्यूज़, वीडियो और लोकल प्वाइंट ऑफ इंटरेस्ट सर्च क्षमताएँ
- [emicklei/melrose-mcp](https://github.com/emicklei/melrose-mcp) 🏎️ 🏠 - [Melrōse](https://melrōse.org) संगीत अभिव्यक्तियों को MIDI के रूप में बजाता है
- [modelcontextprotocol/server-brave-search](https://github.com/modelcontextprotocol/servers/tree/main/src/brave-search) 📇 ☁️ - Brave के Search API का उपयोग करते हुए वेब सर्च क्षमताएँ
- [modelcontextprotocol/server-fetch](https://github.com/modelcontextprotocol/servers/tree/main/src/fetch) 🐍 🏠 ☁️ - AI उपभोग के लिए वेब सामग्री को कुशलता से प्राप्त और संसाधित करता है
- [mzxrai/mcp-webresearch](https://github.com/mzxrai/mcp-webresearch) 🔍📚 - किसी भी विषय पर गूगल सर्च और डीप वेब रिसर्च करें
- [nickclyde/duckduckgo-mcp-server](https://github.com/nickclyde/duckduckgo-mcp-server) 🐍 ☁️ - DuckDuckGo का उपयोग करके वेब सर्च
- [r-huijts/opentk-mcp](https://github.com/r-huijts/opentk-mcp) 📇 ☁️ - संरचित सर्च क्षमताओं के माध्यम से डच संसद (Tweede Kamer) की जानकारी जैसे दस्तावेज़, बहस, गतिविधियाँ और विधायी मामले एक्सेस करें (Bert Hubert द्वारा opentk प्रोजेक्ट पर आधारित)
- [reading-plus-ai/mcp-server-deep-research](https://github.com/reading-plus-ai/mcp-server-deep-research) 📇 ☁️ - OpenAI/Perplexity जैसी ऑटोनॉमस डीप रिसर्च, संरचित क्वेरी विस्तार और संक्षिप्त रिपोर्टिंग प्रदान करने वाला MCP सर्वर।
- [SecretiveShell/MCP-searxng](https://github.com/SecretiveShell/MCP-searxng) 🐍 🏠 - searXNG इंस्टेंस से कनेक्ट करने के लिए एक MCP सर्वर
- [takashiishida/arxiv-latex-mcp](https://github.com/takashiishida/arxiv-latex-mcp) 🐍 ☁️ - गणितीय सामग्री और समीकरणों को संभालने के लिए arXiv पेपर्स का LaTeX स्रोत प्राप्त करें
- [the0807/GeekNews-MCP-Server](https://github.com/the0807/GeekNews-MCP-Server) 🐍 ☁️ - GeekNews साइट से समाचार डेटा पुनः प्राप्त और प्रोसेस करने वाला MCP सर्वर।
- [tinyfish-io/agentql-mcp](https://github.com/tinyfish-io/agentql-mcp) 🎖️ 📇 ☁️ - [AgentQL](https://agentql.com) की डेटा एक्सट्रैक्शन क्षमताएँ प्रदान करने वाला MCP सर्वर।
- [Tomatio13/mcp-server-tavily](https://github.com/Tomatio13/mcp-server-tavily) ☁️ 🐍 – Tavily AI सर्च API
- [vectorize-io/vectorize-mcp-server](https://github.com/vectorize-io/vectorize-mcp-server/) ☁️ 📇 - [Vectorize](https://vectorize.io) MCP सर्वर, उन्नत रिट्रीवल, प्राइवेट डीप रिसर्च, Anything-to-Markdown फाइल एक्सट्रैक्शन और टेक्स्ट चंकिंग के लिए।
- [webscraping-ai/webscraping-ai-mcp-server](https://github.com/webscraping-ai/webscraping-ai-mcp-server) 🎖️ 📇 ☁️ - [WebScraping.ai](https://webscraping.ai) के साथ वेब डेटा एक्सट्रैक्शन और स्क्रैपिंग के लिए इंटरेक्ट करें।
- [zhsama/duckduckgo-mcp-server](https://github.com/zhsama/duckduckgo-mpc-server/) 📇 🏠 ☁️ - यह एक TypeScript आधारित MCP सर्वर है जो DuckDuckGo सर्च फंक्शनलिटी प्रदान करता है।
- [zoomeye-ai/mcp_zoomeye](https://github.com/zoomeye-ai/mcp_zoomeye) 📇 ☁️ - ZoomEye MCP सर्वर द्वारा नेटवर्क संपत्ति जानकारी क्वेरी करना
- [yamanoku/baseline-mcp-server](https://github.com/yamanoku/baseline-mcp-server) 📇 🏠 - वेब प्लेटफ़ॉर्म API का उपयोग करके Baseline स्थिति खोजने वाला MCP सर्वर
- [longevity-genie/biothings-mcp](https://github.com/longevity-genie/biothings-mcp) 🐍 ☁️ - BioThings API के साथ इंटरेक्ट करने के लिए MCP सर्वर, जिसमें जीन, जेनेटिक वेरिएंट्स, दवाएं, और टैक्सोनॉमिक जानकारी शामिल है
- [joelio/stocky](https://github.com/joelio/stocky) 🐍 ☁️ 🏠 - Pexels और Unsplash से रॉयल्टी-फ्री स्टॉक फोटोग्राफी खोजने और डाउनलोड करने के लिए MCP सर्वर। इसमें मल्टी-प्रोवाइडर सर्च, रिच मेटाडेटा, पेजिनेशन सपोर्ट, और AI असिस्टेंट्स के लिए उच्च गुणवत्ता वाली छवियाँ खोजने और एक्सेस करने के लिए असिंक्रोनस परफॉर्मेंस है। 

### 🔒 <a name="security"></a>सुरक्षा

- [LaurieWired/GhidraMCP](https://github.com/LaurieWired/GhidraMCP) ☕ 🏠 - Ghidra के लिए एक Model Context Protocol सर्वर जो LLMs को ऑटोनॉमसली एप्लिकेशन को रिवर्स इंजीनियर करने में सक्षम बनाता है। इसमें बाइनरी डिकंपाइलिंग, मेथड्स और डेटा का नाम बदलना, और मेथड्स, क्लासेस, इम्पोर्ट्स, और एक्सपोर्ट्स की लिस्टिंग के टूल्स शामिल हैं।
- [dkvdm/onepassword-mcp-server](https://github.com/dkvdm/onepassword-mcp-server) - एक MCP सर्वर जो Agentic AI द्वारा उपयोग के लिए 1Password से सुरक्षित क्रेडेंशियल प्राप्त करने में सक्षम बनाता है।
- [firstorderai/authenticator_mcp](https://github.com/firstorderai/authenticator_mcp) 📇 🏠 🍎 🪟 🐧 – एक सुरक्षित MCP (Model Context Protocol) सर्वर जो AI एजेंट्स को Authenticator App के साथ इंटरेक्ट करने में सक्षम बनाता है।
- [13bm/GhidraMCP](https://github.com/13bm/GhidraMCP) 🐍 ☕ 🏠 - Ghidra को AI असिस्टेंट्स के साथ इंटीग्रेट करने के लिए MCP सर्वर। यह प्लगइन बाइनरी एनालिसिस को सक्षम बनाता है, जिसमें फंक्शन इंस्पेक्शन, डिकंपाइलिंग, मेमोरी एक्सप्लोरेशन, और इम्पोर्ट/एक्सपोर्ट एनालिसिस के टूल्स Model Context Protocol के माध्यम से मिलते हैं।
- [atomicchonk/roadrecon_mcp_server](https://github.com/atomicchonk/roadrecon_mcp_server) 🐍 🪟 🏠 MCP सर्वर जो Azure टेनेंट एन्यूमरेशन से ROADrecon गेदर रिजल्ट्स का विश्लेषण करता है
- [BurtTheCoder/mcp-dnstwist](https://github.com/BurtTheCoder/mcp-dnstwist) 📇 🪟 ☁️ - dnstwist के लिए MCP सर्वर, एक शक्तिशाली DNS फजिंग टूल जो टाइपोस्क्वाटिंग, फिशिंग और कॉर्पोरेट जासूसी का पता लगाने में मदद करता है।
- [BurtTheCoder/mcp-maigret](https://github.com/BurtTheCoder/mcp-maigret) 📇 🪟 ☁️ - maigret के लिए MCP सर्वर, एक शक्तिशाली OSINT टूल जो विभिन्न सार्वजनिक स्रोतों से यूजर अकाउंट जानकारी इकट्ठा करता है। यह सर्वर सोशल नेटवर्क्स पर यूजरनेम सर्च करने और URLs का विश्लेषण करने के टूल्स प्रदान करता है।
- [BurtTheCoder/mcp-shodan](https://github.com/BurtTheCoder/mcp-shodan) 📇 🪟 ☁️ - Shodan API और Shodan CVEDB को क्वेरी करने के लिए MCP सर्वर। यह सर्वर IP लुकअप, डिवाइस सर्च, DNS लुकअप, वल्नरेबिलिटी क्वेरी, CPE लुकअप आदि के टूल्स प्रदान करता है।
- [BurtTheCoder/mcp-virustotal](https://github.com/BurtTheCoder/mcp-virustotal) 📇 🪟 ☁️ - VirusTotal API को क्वेरी करने के लिए MCP सर्वर। यह सर्वर URLs स्कैन करने, फाइल हैशेज का विश्लेषण करने, और IP एड्रेस रिपोर्ट प्राप्त करने के टूल्स प्रदान करता है।
- [fosdickio/binary_ninja_mcp](https://github.com/fosdickio/binary_ninja_mcp) 🐍 🏠 🍎 🪟 🐧 - एक Binary Ninja प्लगइन, MCP सर्वर, और ब्रिज जो [Binary Ninja](https://binary.ninja) को आपके पसंदीदा MCP क्लाइंट के साथ सहजता से इंटीग्रेट करता है। यह बाइनरी एनालिसिस और रिवर्स इंजीनियरिंग को ऑटोमेट करने में सक्षम बनाता है।
- [fr0gger/MCP_Security](https://github.com/fr0gger/MCP_Security) 📇 ☁️ - ORKL API को क्वेरी करने के लिए MCP सर्वर। यह सर्वर थ्रेट रिपोर्ट प्राप्त करने, थ्रेट एक्टर्स का विश्लेषण करने, और इंटेलिजेंस सोर्सेज प्राप्त करने के टूल्स प्रदान करता है।
- [gbrigandi/mcp-server-cortex](https://github.com/gbrigandi/mcp-server-cortex) 🦀 🏠 🚨 🍎 🪟 🐧 - Cortex को इंटीग्रेट करने के लिए एक Rust आधारित MCP सर्वर, जो AI के माध्यम से ऑब्जर्वेबल विश्लेषण और ऑटोमेटेड सिक्योरिटी रिस्पॉन्स सक्षम बनाता है।
- [gbrigandi/mcp-server-thehive](https://github.com/gbrigandi/mcp-server-thehive) 🦀 🏠 🚨 🍎 🪟 🐧 - TheHive को इंटीग्रेट करने के लिए एक Rust आधारित MCP सर्वर, जो AI के माध्यम से सहयोगात्मक सुरक्षा घटना प्रतिक्रिया और केस प्रबंधन सक्षम बनाता है।
- [gbrigandi/mcp-server-wazuh](https://github.com/gbrigandi/mcp-server-wazuh) 🦀 🏠 🚨 🍎 🪟 🐧 - Wazuh SIEM को AI असिस्टेंट्स के साथ जोड़ने के लिए एक Rust आधारित MCP सर्वर, जो रीयल-टाइम सुरक्षा अलर्ट और इवेंट डेटा प्रदान करता है।
- [intruder-io/intruder-mcp](https://github.com/intruder-io/intruder-mcp) 🐍 ☁️ - [Intruder](https://www.intruder.io/) तक पहुँचने के लिए MCP सर्वर, जो आपके इन्फ्रास्ट्रक्चर में सुरक्षा कमजोरियों की पहचान, समझ और समाधान में मदद करता है।
- [jyjune/mcp_vms](https://github.com/jyjune/mcp_vms) 🐍 🏠 🪟 - एक Model Context Protocol (MCP) सर्वर जिसे CCTV रिकॉर्डिंग प्रोग्राम (VMS) से कनेक्ट करने के लिए डिज़ाइन किया गया है ताकि रिकॉर्डेड और लाइव वीडियो स्ट्रीम प्राप्त की जा सके। यह विशिष्ट चैनलों के लिए लाइव या प्लेबैक डायलॉग दिखाने जैसे VMS सॉफ़्टवेयर को नियंत्रित करने के टूल्स भी प्रदान करता है।
- [qianniuspace/mcp-security-audit](https://github.com/qianniuspace/mcp-security-audit) 📇 ☁️ एक शक्तिशाली MCP (Model Context Protocol) सर्वर जो npm पैकेज डिपेंडेंसीज़ का सुरक्षा ऑडिट करता है। रीयल-टाइम सुरक्षा जांच के लिए रिमोट npm रजिस्ट्री इंटीग्रेशन के साथ बनाया गया।
- [semgrep/mcp](https://github.com/semgrep/mcp) 📇 ☁️ AI एजेंट्स को [Semgrep](https://semgrep.dev) का उपयोग करके कोड में सुरक्षा कमजोरियों को स्कैन करने में सक्षम बनाएं।
- [slouchd/cyberchef-api-mcp-server](https://github.com/slouchd/cyberchef-api-mcp-server) 🐍 ☁️ - CyberChef सर्वर API के साथ इंटरेक्ट करने के लिए MCP सर्वर, जो MCP क्लाइंट को CyberChef ऑपरेशंस का उपयोग करने की अनुमति देता है।
- [mrexodia/ida-pro-mcp](https://github.com/mrexodia/ida-pro-mcp) 🐍 🏠 - IDA Pro के लिए MCP सर्वर, जो AI असिस्टेंट्स के साथ बाइनरी विश्लेषण करने की अनुमति देता है। यह प्लगइन डिकंपाइलिंग, डिसअसेंबली को इम्प्लीमेंट करता है और आपको मैलवेयर विश्लेषण रिपोर्ट्स स्वचालित रूप से जेनरेट करने की अनुमति देता है।
- [rad-security/mcp-server](https://github.com/rad-security/mcp-server) 📇 ☁️ - RAD Security के लिए MCP सर्वर, Kubernetes और क्लाउड एनवायरनमेंट्स के लिए AI-संचालित सुरक्षा इनसाइट्स प्रदान करता है। यह सर्वर Rad Security API को क्वेरी करने और सुरक्षा निष्कर्ष, रिपोर्ट्स, रनटाइम डेटा आदि प्राप्त करने के टूल्स प्रदान करता है।
- [securityfortech/secops-mcp](https://github.com/securityfortech/secops-mcp) 🐍 🏠 - एक ऑल-इन-वन सुरक्षा परीक्षण टूलबॉक्स जो लोकप्रिय ओपन सोर्स टूल्स को एक MCP इंटरफ़ेस के माध्यम से एक साथ लाता है। AI एजेंट से जुड़कर, यह पेंटेस्टिंग, बग बाउंटी हंटिंग, थ्रेट हंटिंग आदि जैसे कार्यों को सक्षम बनाता है।
- [roadwy/cve-search_mcp](https://github.com/roadwy/cve-search_mcp) 🐍 🏠 - CVE-Search API को क्वेरी करने के लिए एक Model Context Protocol (MCP) सर्वर। यह सर्वर CVE-Search तक व्यापक पहुँच, वेंडर और प्रोडक्ट ब्राउज़ करना, CVE-ID प्रति CVE प्राप्त करना, और अंतिम अपडेटेड CVEs प्राप्त करना प्रदान करता है।
- [StacklokLabs/osv-mcp](https://github.com/StacklokLabs/osv-mcp) 🏎️ ☁️ - वल्नरेबिलिटी जानकारी के लिए OSV (Open Source Vulnerabilities) डेटाबेस तक पहुँचें। पैकेज वर्शन या कमिट द्वारा वल्नरेबिलिटीज क्वेरी करें, कई पैकेजों को बैच में क्वेरी करें, और ID द्वारा विस्तृत वल्नरेबिलिटी जानकारी प्राप्त करें।
- [nickpending/mcp-recon](https://github.com/nickpending/mcp-recon) 🏎️ 🏠 - httpx और asnmap द्वारा संचालित कन्वर्सेशनल रीकॉन इंटरफ़ेस और MCP सर्वर। डोमेन विश्लेषण, सुरक्षा हेडर निरीक्षण, सर्टिफिकेट विश्लेषण, और ASN लुकअप के लिए विभिन्न रीकॉन स्तरों का समर्थन करता है।
- [Gaffx/volatility-mcp](https://github.com/Gaffx/volatility-mcp) - Volatility 3.x के लिए MCP सर्वर, जो आपको AI असिस्टेंट के साथ मेमोरी फॉरेंसिक विश्लेषण करने की अनुमति देता है। pslist और netscan जैसे प्लगइन्स क्लीन REST APIs और LLMs के माध्यम से सुलभ हो जाते हैं।
- [co-browser/attestable-mcp-server](https://github.com/co-browser/attestable-mcp-server) 🐍 🏠 ☁️ 🐧 - एक MCP सर्वर जो Gramine के माध्यम से एक ट्रस्टेड एक्जीक्यूशन एनवायरनमेंट (TEE) के अंदर चलता है, [RA-TLS](https://gramine.readthedocs.io/en/stable/attestation.html) का उपयोग करते हुए रिमोट अटेस्टेशन दिखाता है। यह MCP क्लाइंट को कनेक्ट करने से पहले सर्वर को सत्यापित करने की अनुमति देता है।
- [zinja-coder/jadx-ai-mcp](https://github.com/zinja-coder/jadx-ai-mcp) ☕ 🏠 - JADX-AI-MCP, JADX डिकंपाइलर के लिए एक प्लगइन और MCP सर्वर है, जो सीधे Model Context Protocol (MCP) के साथ इंटीग्रेट करता है ताकि Claude जैसे LLMs के साथ लाइव रिवर्स इंजीनियरिंग सपोर्ट मिले।
- [zinja-coder/apktool-mcp-server](https://github.com/zinja-coder/apktool-mcp-server) 🐍 🏠 - Apk Tool के लिए APKTool MCP Server, जो Android APKs के रिवर्स इंजीनियरिंग को ऑटोमेट करने के लिए MCP सर्वर है।

### 🌐 <a name="social-media"></a>सोशल मीडिया

सोशल मीडिया प्लेटफार्मों के साथ इंटीग्रेशन, जिससे पोस्टिंग, एनालिटिक्स, और इंटरैक्शन प्रबंधन संभव होता है। AI-संचालित ऑटोमेशन के लिए सक्षम।

- [macrocosm-os/macrocosmos-mcp](https://github.com/macrocosm-os/macrocosmos-mcp) - 🎖️ 🐍 ☁️ अपने LLM एप्लिकेशन में रीयल-टाइम X/Reddit/YouTube डेटा तक पहुँचें, सर्च वाक्यांश, यूजर्स और तिथि फ़िल्टरिंग के साथ।
- [kunallunia/twitter-mcp](https://github.com/LuniaKunal/mcp-twitter) 🐍 🏠 - एक ऑल-इन-वन ट्विटर प्रबंधन समाधान, जो टाइमलाइन एक्सेस, यूजर ट्वीट रिट्रीवल, हैशटैग मॉनिटरिंग, कन्वर्सेशन एनालिसिस, डायरेक्ट मैसेजिंग, पोस्ट की सेंटिमेंट एनालिसिस, और पूरे पोस्ट लाइफसाइकल नियंत्रण सहित सभी सुविधाएँ एक सुव्यवस्थित API के माध्यम से प्रदान करता है।
- [HagaiHen/facebook-mcp-server](https://github.com/HagaiHen/facebook-mcp-server) 🐍 ☁️ - Facebook Pages के साथ इंटीग्रेट करता है, जिससे पोस्ट, कमेंट और इंगेजमेंट मेट्रिक्स का डायरेक्ट प्रबंधन Graph API के माध्यम से संभव होता है, जिससे सोशल मीडिया प्रबंधन आसान बनता है।
- [gwbischof/bluesky-social-mcp](https://github.com/gwbischof/bluesky-social-mcp) 🐍 🏠 - atproto क्लाइंट के माध्यम से Bluesky के साथ इंटरेक्ट करने के लिए MCP सर्वर।


### 🏃 <a name="sports"></a>खेल

खेल-संबंधी डेटा, परिणाम और सांख्यिकी तक पहुँचने के लिए उपकरण।

- [mikechao/balldontlie-mcp](https://github.com/mikechao/balldontlie-mcp) 📇 - balldontlie API को इंटीग्रेट करने वाला MCP सर्वर, जो NBA, NFL और MLB के लिए खिलाड़ियों, टीमों और खेलों की जानकारी प्रदान करता है
- [r-huijts/firstcycling-mcp](https://github.com/r-huijts/firstcycling-mcp) 📇 ☁️ - प्राकृतिक भाषा के माध्यम से साइकिलिंग रेस डेटा, परिणाम और सांख्यिकी तक पहुँचें। इसमें firstcycling.com से स्टार्ट लिस्ट, रेस परिणाम, और राइडर जानकारी प्राप्त करने की विशेषताएँ हैं।
- [r-huijts/strava-mcp](https://github.com/r-huijts/strava-mcp) 📇 ☁️ - Strava API से कनेक्ट करने वाला Model Context Protocol (MCP) सर्वर, जो LLMs के माध्यम से Strava डेटा तक पहुँचने के टूल्स प्रदान करता है
- [willvelida/mcp-afl-server](https://github.com/willvelida/mcp-afl-server) ☁️ - Squiggle API के साथ इंटीग्रेट करने वाला MCP सर्वर, जो ऑस्ट्रेलियन फुटबॉल लीग टीमों, लैडर स्टैंडिंग्स, परिणाम, टिप्स, और पावर रैंकिंग्स की जानकारी प्रदान करता है।
- [guillochon/mlb-api-mcp](https://github.com/guillochon/mlb-api-mcp) 🐍 🏠 - फ्री में उपलब्ध MLB API के लिए MCP सर्वर, जो खिलाड़ी जानकारी, आँकड़े, और खेल जानकारी प्रदान करता है।

### 🎧 <a name="support-and-service-management"></a>सपोर्ट और सेवा प्रबंधन

ग्राहक सहायता, IT सेवा प्रबंधन, और हेल्पडेस्क संचालन का प्रबंधन करने के लिए उपकरण।

- [effytech/freshdesk-mcp](https://github.com/effytech/freshdesk_mcp) 🐍 ☁️ - Freshdesk के साथ इंटीग्रेट करने वाला MCP सर्वर, जिससे AI मॉडल Freshdesk मॉड्यूल्स के साथ इंटरेक्ट कर सकते हैं और विभिन्न सहायता कार्य कर सकते हैं।
- [nguyenvanduocit/jira-mcp](https://github.com/nguyenvanduocit/jira-mcp) 🏎️ ☁️ - Jira के लिए Go-आधारित MCP कनेक्टर जो Claude जैसे AI असिस्टेंट्स को Atlassian Jira के साथ इंटरेक्ट करने में सक्षम बनाता है। यह टूल AI मॉडल्स को आम Jira ऑपरेशन्स जैसे इश्यू प्रबंधन, स्प्रिंट प्लानिंग, और वर्कफ़्लो ट्रांजिशन करने के लिए एक सहज इंटरफ़ेस प्रदान करता है।
- [sooperset/mcp-atlassian](https://github.com/sooperset/mcp-atlassian) 🐍 ☁️ - Atlassian उत्पादों (Confluence और Jira) के लिए MCP सर्वर। Confluence Cloud, Jira Cloud, और Jira Server/Data Center को सपोर्ट करता है। Atlassian वर्कस्पेसेस में सामग्री खोजने, पढ़ने, बनाने, और प्रबंधित करने के लिए व्यापक टूल्स प्रदान करता है।

### 🌎 <a name="translation-services"></a>अनुवाद सेवाएँ

AI असिस्टेंट्स को विभिन्न भाषाओं के बीच सामग्री का अनुवाद करने में सक्षम बनाने के लिए अनुवाद उपकरण और सेवाएँ।

- [translated/lara-mcp](https://github.com/translated/lara-mcp) 🎖️ 📇 ☁️ - Lara Translate API के लिए MCP सर्वर, जो शक्तिशाली अनुवाद क्षमताएँ, भाषा डिटेक्शन और संदर्भ-आधारित अनुवाद का समर्थन करता है।
- [mmntm/weblate-mcp](https://github.com/mmntm/weblate-mcp) 📇 ☁️ - Weblate अनुवाद प्रबंधन के लिए व्यापक Model Context Protocol सर्वर, जो AI असिस्टेंट्स को अनुवाद कार्य, प्रोजेक्ट प्रबंधन, और स्मार्ट फॉर्मेट ट्रांसफॉर्मेशन के साथ कंटेंट डिस्कवरी करने में सक्षम बनाता है।

### 🎧 <a name="text-to-speech"></a>टेक्स्ट-टू-स्पीच

टेक्स्ट को स्पीच में और इसके विपरीत बदलने के लिए उपकरण

- [mberg/kokoro-tts-mcp](https://github.com/mberg/kokoro-tts-mcp) 🐍 🏠 - Kokoro TTS मॉडल्स का उपयोग करने वाला MCP सर्वर, जो टेक्स्ट को स्पीच में बदलता है। टेक्स्ट को MP3 में लोकल ड्राइव पर या ऑटो-अपलोड S3 बकेट में बदल सकता है।
- [mbailey/voice-mcp](https://github.com/mbailey/voice-mcp) 🐍 🏠 - पूर्ण वॉयस इंटरैक्शन सर्वर, जो स्पीच-टू-टेक्स्ट, टेक्स्ट-टू-स्पीच, और रीयल-टाइम वॉयस कन्वर्सेशन को लोकल माइक्रोफोन, OpenAI-संगत APIs, और LiveKit इंटीग्रेशन के माध्यम से सपोर्ट करता है।

### 🚆 <a name="travel-and-transportation"></a>यात्रा और परिवहन

यात्रा और परिवहन जानकारी तक पहुँच। शेड्यूल, मार्ग, और रीयल-टाइम यात्रा डेटा क्वेरी करने में सक्षम बनाता है।
- [Airbnb MCP Server](https://github.com/openbnb-org/mcp-server-airbnb) 📇 ☁️ - Airbnb को खोजने और लिस्टिंग विवरण प्राप्त करने के लिए उपकरण प्रदान करता है।
- [KyrieTangSheng/mcp-server-nationalparks](https://github.com/KyrieTangSheng/mcp-server-nationalparks) 📇 ☁️ - नेशनल पार्क सर्विस API एकीकरण, जो अमेरिकी राष्ट्रीय उद्यानों के पार्क विवरण, अलर्ट, विज़िटर सेंटर, कैंपग्राउंड और आयोजनों की नवीनतम जानकारी प्रदान करता है।
- [NS Travel Information MCP Server](https://github.com/r-huijts/ns-mcp-server) 📇 ☁️ - डच रेलवे (NS) यात्रा जानकारी, समय-सारिणी और रीयल-टाइम अपडेट तक पहुँच।
- [pab1it0/tripadvisor-mcp](https://github.com/pab1it0/tripadvisor-mcp) 📇 🐍 - एक MCP सर्वर जो LLMs को Tripadvisor API के साथ इंटरैक्ट करने में सक्षम बनाता है, जिसमें लोकेशन डेटा, समीक्षाएँ और फ़ोटो शामिल हैं, जो मानकीकृत MCP इंटरफेस के माध्यम से उपलब्ध हैं।
- [lucygoodchild/mcp-national-rail](https://github.com/lucygoodchild/mcp-national-rail) 📇 ☁️ - यूके नेशनल रेल ट्रेनों की सेवा के लिए MCP सर्वर, जो ट्रेन समय-सारिणी और लाइव यात्रा जानकारी प्रदान करता है, और Realtime Trains API के साथ एकीकृत करता है।

### 🔄 <a name="version-control"></a>संस्करण नियंत्रण

Git रिपॉजिटरी और संस्करण नियंत्रण प्लेटफार्मों के साथ इंटरैक्ट करें। मानकीकृत API के माध्यम से रिपॉजिटरी प्रबंधन, कोड विश्लेषण, पुल अनुरोध हैंडलिंग, मुद्दा ट्रैकिंग, और अन्य संस्करण नियंत्रण संचालन को सक्षम बनाता है।

- [adhikasp/mcp-git-ingest](https://github.com/adhikasp/mcp-git-ingest) 🐍 🏠 - अपने LLM के साथ GitHub रिपॉजिटरी पढ़ें और विश्लेषण करें
- [ddukbg/github-enterprise-mcp](https://github.com/ddukbg/github-enterprise-mcp) 📇 ☁️ 🏠 - GitHub Enterprise API एकीकरण के लिए MCP सर्वर
- [gitea/gitea-mcp](https://gitea.com/gitea/gitea-mcp) 🎖️ 🏎️ ☁️ 🏠 🍎 🪟 🐧 - MCP के साथ Gitea इंस्टेंस के साथ इंटरैक्टिव कार्य करें।
- [github/github-mcp-server](https://github.com/github/github-mcp-server) 📇 ☁️ - रिपॉजिटरी प्रबंधन, PRs, इश्यूज़ और अन्य के एकीकरण के लिए आधिकारिक GitHub सर्वर।
- [kopfrechner/gitlab-mr-mcp](https://github.com/kopfrechner/gitlab-mr-mcp) 📇 ☁️ - अपनी GitLab परियोजनाओं के इश्यू और मर्ज अनुरोधों के साथ निर्बाध इंटरैक्शन।
- [modelcontextprotocol/server-git](https://github.com/modelcontextprotocol/servers/tree/main/src/git) 🐍 🏠 - स्थानीय रिपॉजिटरी को पढ़ने, खोजने और विश्लेषण करने सहित डायरेक्ट Git रिपॉजिटरी संचालन
- [modelcontextprotocol/server-gitlab](https://github.com/modelcontextprotocol/servers/tree/main/src/gitlab) 📇 ☁️ 🏠 - परियोजना प्रबंधन और CI/CD संचालन के लिए GitLab प्लेटफार्म एकीकरण
- [oschina/mcp-gitee](https://github.com/oschina/gitee) 🏎️ ☁️ 🏠 - Gitee API एकीकरण, रिपॉजिटरी, इश्यू और पुल अनुरोध प्रबंधन, और बहुत कुछ।
- [Tiberriver256/mcp-server-azure-devops](https://github.com/Tiberriver256/mcp-server-azure-devops) 📇 ☁️ - रिपॉजिटरी प्रबंधन, वर्क आइटम्स और पाइपलाइनों के लिए Azure DevOps एकीकरण।
- [kaiyuanxiaobing/atomgit-mcp-server](https://github.com/kaiyuanxiaobing/atomgit-mcp-server) 📇 ☁️ - रिपॉजिटरी प्रबंधन, PRs, इश्यू, ब्रांच, लेबल आदि के लिए आधिकारिक AtomGit सर्वर एकीकरण।

### 🛠️ <a name="other-tools-and-integrations"></a>अन्य उपकरण और एकीकरण

- [AbdelStark/bitcoin-mcp](https://github.com/AbdelStark/bitcoin-mcp) - ₿ एक मॉडल कॉन्टेक्स्ट प्रोटोकॉल (MCP) सर्वर जो AI मॉडल को बिटकॉइन के साथ इंटरैक्ट करने में सक्षम बनाता है, जिससे वे कुंजी जेनरेट कर सकते हैं, पते सत्यापित कर सकते हैं, लेनदेन डिकोड कर सकते हैं, ब्लॉकचेन क्वेरी कर सकते हैं, और बहुत कुछ।
- [akseyh/bear-mcp-server](https://github.com/akseyh/bear-mcp-server) - AI को आपके Bear Notes (केवल macOS) से पढ़ने की अनुमति देता है
- [allenporter/mcp-server-home-assistant](https://github.com/allenporter/mcp-server-home-assistant) 🐍 🏠 - सभी Home Assistant वॉयस इंटेंट्स को Model Context Protocol Server के माध्यम से उजागर करता है, जिससे होम कंट्रोल संभव होता है।
- [Amazon Bedrock Nova Canvas](https://github.com/zxkane/mcp-server-amazon-bedrock) 📇 ☁️ - इमेज जेनरेशन के लिए Amazon Nova Canvas मॉडल का उपयोग करें।
- [amidabuddha/unichat-mcp-server](https://github.com/amidabuddha/unichat-mcp-server) 🐍/📇 ☁️ - MCP प्रोटोकॉल के माध्यम से या पूर्वनिर्धारित प्रॉम्प्ट्स द्वारा OpenAI, MistralAI, Anthropic, xAI, Google AI या DeepSeek को अनुरोध भेजें। वेंडर API कुंजी आवश्यक
- [anaisbetts/mcp-installer](https://github.com/anaisbetts/mcp-installer) 🐍 🏠 - एक MCP सर्वर जो आपके लिए अन्य MCP सर्वर इंस्टॉल करता है।
- [anaisbetts/mcp-youtube](https://github.com/anaisbetts/mcp-youtube) 📇 ☁️ - YouTube उपशीर्षक प्राप्त करें
- [andybrandt/mcp-simple-openai-assistant](https://github.com/andybrandt/mcp-simple-openai-assistant) - 🐍 ☁️  OpenAI सहायक से बात करने के लिए MCP (Claude किसी भी GPT मॉडल का सहायक के रूप में उपयोग कर सकता है)
- [andybrandt/mcp-simple-timeserver](https://github.com/andybrandt/mcp-simple-timeserver) 🐍 🏠☁️ - एक MCP सर्वर जो क्लाइंट मशीन पर स्थानीय समय या NTP सर्वर से वर्तमान UTC समय की जांच करने की अनुमति देता है
- [apify/actors-mcp-server](https://github.com/apify/actors-mcp-server) 📇 ☁️ - वेबसाइटों, ई-कॉमर्स, सोशल मीडिया, सर्च इंजन, मैप्स आदि से डेटा निकालने के लिए 3,000+ प्री-बिल्ट क्लाउड टूल्स (Actors) का उपयोग करें
- [apinetwork/piapi-mcp-server](https://github.com/apinetwork/piapi-mcp-server) 📇 ☁️ PiAPI MCP सर्वर उपयोगकर्ता को Claude या किसी अन्य MCP-संगत ऐप्स से सीधे Midjourney/Flux/Kling/Hunyuan/Udio/Trellis के साथ मीडिया कंटेंट जनरेट करने में सक्षम बनाता है।
- [awkoy/replicate-flux-mcp](https://github.com/awkoy/replicate-flux-mcp) 📇 ☁️ - Replicate के API के माध्यम से चित्र उत्पन्न करने की क्षमता प्रदान करता है।
- [awwaiid/mcp-server-taskwarrior](https://github.com/awwaiid/mcp-server-taskwarrior) 🏠 📇 - स्थानीय taskwarrior उपयोग के लिए MCP सर्वर (कार्य जोड़ें, अपडेट करें, हटाएं)
- [baba786/phabricator-mcp-server](https://github.com/baba786/phabricator-mcp-server) 🐍 ☁️ - Phabricator API के साथ इंटरैक्ट करें
- [Badhansen/notion-mcp](https://github.com/Badhansen/notion-mcp) 🐍 ☁️ - Notion के API के साथ एकीकृत एक Model Context Protocol (MCP) सर्वर, जिससे व्यक्तिगत todo सूचियों का कुशल प्रबंधन संभव है।
- [bart6114/my-bear-mcp-server](https://github.com/bart6114/my-bear-mcp-server/) 📇 🏠 🍎 - Bear Note लेने वाले ऐप के लिए नोट्स और टैग पढ़ने की अनुमति देता है, Bear के sqlitedb के साथ डायरेक्ट इंटिग्रेशन के माध्यम से।
- [billster45/mcp-chatgpt-responses](https://github.com/billster45/mcp-chatgpt-responses) 🐍 ☁️ - Claude को ChatGPT से बात करने और इसकी वेब सर्च क्षमताओं का उपयोग करने के लिए MCP सर्वर।
- [blurrah/mcp-graphql](https://github.com/blurrah/mcp-graphql) 📇 ☁️ - AI को GraphQL सर्वर क्वेरी करने की अनुमति देता है
- [calclavia/mcp-obsidian](https://github.com/calclavia/mcp-obsidian) 📇 🏠 - यह कनेक्टर Claude Desktop (या किसी भी MCP क्लाइंट) को Markdown नोट्स (जैसे Obsidian vault) वाली किसी भी डायरेक्टरी को पढ़ने और खोजने की अनुमति देता है।
- [chrishayuk/mcp-cli](https://github.com/chrishayuk/mcp-cli) 🐍 🏠 - MCP सर्वरों के परीक्षण के लिए एक और CLI टूल
- [danhilse/notion_mcp](https://github.com/danhilse/notion_mcp) 🐍 ☁️ - Notion के API के साथ एकीकृत, व्यक्तिगत todo सूचियों का प्रबंधन
- [EKibort/wrike-mcp-server](https://github.com/EKibort/wrike-mcp-server) - 🐍 🏠 - Wrike टास्क के साथ सार्वजनिक API के माध्यम से इंटरैक्शन के लिए Wrike MCP सर्वर का एक हल्का कार्यान्वयन।
- [ekkyarmandi/ticktick-mcp](https://github.com/ekkyarmandi/ticktick-mcp) 🐍 ☁️ - [TickTick](https://ticktick.com/) MCP सर्वर जो TickTick के API के साथ एकीकृत है, जिससे व्यक्तिगत todo प्रोजेक्ट्स और कार्यों का प्रबंधन संभव है।
- [esignaturescom/mcp-server-esignatures](https://github.com/esignaturescom/mcp-server-esignatures) 🐍 ☁️️ - eSignatures API के माध्यम से अनुबंध और टेम्पलेट का प्रबंधन, ड्राफ्टिंग, समीक्षा और बाध्यकारी अनुबंध भेजना।
- [evalstate/mcp-miro](https://github.com/evalstate/mcp-miro) 📇 ☁️ - MIRO व्हाइटबोर्ड तक पहुँच, बल्क में आइटम बनाना और पढ़ना। REST API के लिए OAUTH कुंजी आवश्यक है।
- [feuerdev/keep-mcp](https://github.com/feuerdev/keep-mcp) 🐍 ☁️ - Google Keep नोट्स पढ़ें, बनाएं, अपडेट करें और हटाएं।
- [future-audiences/wikimedia-enterprise-model-context-protocol](https://gitlab.wikimedia.org/repos/future-audiences/wikimedia-enterprise-model-context-protocol) 🐍 ☁️  - विकिपीडिया लेख लुकअप API
- [fotoetienne/gqai](https://github.com/fotoetienne/gqai) 🏎 🏠 - रेगुलर GraphQL क्वेरी/म्यूटेशन का उपयोग करके टूल्स परिभाषित करें और gqai स्वचालित रूप से आपके लिए MCP सर्वर जेनरेट कर देगा।
- [githejie/mcp-server-calculator](https://github.com/githejie/mcp-server-calculator) 🐍 🏠 - यह सर्वर LLMs को सटीक संख्यात्मक गणना के लिए कैलकुलेटर का उपयोग करने में सक्षम बनाता है
- [gotoolkits/DifyWorkflow](https://github.com/gotoolkits/mcp-difyworkflow-server) - 🏎️ ☁️ Dify वर्कफ़्लोज़ के क्वेरी और निष्पादन के लिए टूल्स
- [hiromitsusasaki/raindrop-io-mcp-server](https://github.com/hiromitsusasaki/raindrop-io-mcp-server) 📇 ☁️ - Model Context Protocol (MCP) के उपयोग से Raindrop.io बुकमार्क्स के साथ LLMs को इंटरैक्ट करने की अनुमति देता है।
- [hmk/attio-mcp-server](https://github.com/hmk/attio-mcp-server) - 📇 ☁️ AI क्लाइंट्स को Attio CRM में रिकॉर्ड और नोट्स प्रबंधित करने की अनुमति देता है
- [isaacwasserman/mcp-vegalite-server](https://github.com/isaacwasserman/mcp-vegalite-server) 🐍 🏠 - प्राप्त डेटा से VegaLite प्रारूप और रेंडरर का उपयोग करके विज़ुअलाइज़ेशन जनरेट करें।
- [ivnvxd/mcp-server-odoo](https://github.com/ivnvxd/mcp-server-odoo) 🐍 ☁️/🏠 - Odoo ERP सिस्टम्स से व्यापार डेटा एक्सेस, रिकॉर्ड प्रबंधन, और वर्कफ़्लो ऑटोमेशन के लिए AI असिस्टेंट्स को कनेक्ट करें।
- [ivo-toby/contentful-mcp](https://github.com/ivo-toby/contentful-mcp) 📇 🏠 - अपने Contentful Space में सामग्री, सामग्री-मॉडल और संपत्तियों को अपडेट, बनाएँ, हटाएँ
- [j3k0/speech.sh](https://github.com/j3k0/speech.sh/blob/main/MCP_README.md) 🏠 - एजेंट को ज़ोर से बोलने, काम खत्म होने पर आपको त्वरित सारांश के साथ सूचित करने दें
- [jagan-shanmugam/climatiq-mcp-server](https://github.com/jagan-shanmugam/climatiq-mcp-server) 🐍 🏠 - Climatiq API तक पहुँच के लिए Model Context Protocol (MCP) सर्वर, कार्बन उत्सर्जन की गणना के लिए। यह AI असिस्टेंट्स को रीयल-टाइम कार्बन गणना और जलवायु प्रभाव अंतर्दृष्टि प्रदान करने की अनुमति देता है।
- [johannesbrandenburger/typst-mcp](https://github.com/johannesbrandenburger/typst-mcp) 🐍 🏠 - Typst के लिए MCP सर्वर, एक मार्कअप-आधारित टाइपसेटिंग सिस्टम। यह LaTeX और Typst के बीच रूपांतरण, Typst सिंटैक्स का सत्यापन, और Typst कोड से चित्र बनाने के उपकरण प्रदान करता है।
- [joshuarileydev/mac-apps-launcher-mcp-server](https://github.com/JoshuaRileyDev/mac-apps-launcher) 📇 🏠 - MacOS पर एप्लिकेशन सूचीबद्ध करने और लॉन्च करने के लिए एक MCP सर्वर
- [Harry-027/JotDown](https://github.com/Harry-027/JotDown) 🦀 🏠 - Notion ऐप में पेज बनाने/अपडेट करने और संरचित सामग्री से स्वतः mdBooks जेनरेट करने के लिए MCP सर्वर।
- [kelvin6365/plane-mcp-server](https://github.com/kelvin6365/plane-mcp-server) - 🏎️ 🏠 यह MCP सर्वर आपको [Plane](https://plane.so) के API के माध्यम से प्रोजेक्ट्स और इश्यूज का प्रबंधन करने में मदद करेगा
- [kenliao94/mcp-server-rabbitmq](https://github.com/kenliao94/mcp-server-rabbitmq) 🐍 🏠 - RabbitMQ के साथ इंटरैक्शन (प्रशासनिक संचालन, संदेश जोड़ना/निकालना) सक्षम करें
- [k-jarzyna/mcp-miro](https://github.com/k-jarzyna/mcp-miro) 📇 ☁️ - Miro MCP सर्वर, जो आधिकारिक Miro SDK में उपलब्ध सभी कार्यक्षमताओं को उजागर करता है
- [kimtth/mcp-remote-call-ping-pong](https://github.com/kimtth/mcp-remote-call-ping-pong) 🐍 🏠 - रिमोट MCP (Model Context Protocol) कॉल्स के डेमो के लिए एक प्रायोगिक और शैक्षिक Ping-pong सर्वर ऐप
- [kj455/mcp-kibela](https://github.com/kj455/mcp-kibela) - 📇 ☁️ AI मॉडल को [Kibela](https://kibe.la/) के साथ इंटरैक्ट करने की अनुमति देता है
- [kiwamizamurai/mcp-kibela-server](https://github.com/kiwamizamurai/mcp-kibela-server) - 📇 ☁️ Kibela API के साथ शक्तिशाली इंटरैक्शन।
- [KS-GEN-AI/confluence-mcp-server](https://github.com/KS-GEN-AI/confluence-mcp-server) 📇 ☁️ 🍎 🪟 - CQL के माध्यम से Confluence डेटा प्राप्त करें और पेज पढ़ें।
- [KS-GEN-AI/jira-mcp-server](https://github.com/KS-GEN-AI/jira-mcp-server) 📇 ☁️ 🍎 🪟 - JQL और API के माध्यम से Jira डेटा पढ़ें और टिकट बनाने तथा संपादित करने के लिए अनुरोध निष्पादित करें।
- [salesforce-mcp/salesforce-mcp](https://github.com/salesforce-mcp/salesforce-mcp) 🏠 ☁️ - Salesforce इंस्टेंस के साथ इंटरैक्शन का बुनियादी प्रदर्शन करने वाला MCP सर्वर
- [pollinations/chucknorris-mcp](https://github.com/pollinations/chucknorris-mcp) 📇 ☁️ - विशेषीकृत LLM एन्हांसमेंट प्रॉम्प्ट्स और डाइनामिक स्कीमा एडाप्टेशन के साथ जेलब्रेक्स।
- [louiscklaw/hko-mcp](https://github.com/louiscklaw/hko-mcp) 📇 🏠 - हांगकांग ऑब्जर्वेटरी से मौसम की जानकारी प्राप्त करने का बेसिक डेमो MCP सर्वर
- [evalstate/mcp-hfspace](https://github.com/evalstate/mcp-hfspace) 📇 ☁️ - Claude से सीधे HuggingFace Spaces का उपयोग करें। ओपन सोर्स इमेज जनरेशन, चैट, विज़न टास्क आदि। इमेज, ऑडियो और टेक्स्ट अपलोड/डाउनलोड समर्थित।
- [magarcia/mcp-server-giphy](https://github.com/magarcia/mcp-server-giphy) 📇 ☁️ - Giphy API के माध्यम से Giphy की विशाल लाइब्रेरी से GIFs खोजें और प्राप्त करें।
- [integromat/make-mcp-server](https://github.com/integromat/make-mcp-server) 🎖️ 📇 🏠 - अपने [Make](https://www.make.com/) दृश्यों को AI असिस्टेंट्स के लिए कॉल करने योग्य टूल्स में बदलें।
- [marcelmarais/Spotify](https://github.com/marcelmarais/spotify-mcp-server) - 📇 🏠 Spotify प्लेबैक और प्लेलिस्ट प्रबंधन को नियंत्रित करें।
- [MarkusPfundstein/mcp-obsidian](https://github.com/MarkusPfundstein/mcp-obsidian) 🐍 ☁️ 🏠 - REST API के माध्यम से Obsidian के साथ इंटरैक्शन
- [emicklei/mcp-log-proxy](https://github.com/emicklei/mcp-log-proxy) 🏎️ 🏠 - MCP सर्वर प्रॉक्सी जो पूरे संदेश प्रवाह के लिए वेब UI प्रदान करता है
- [quarkiverse/mcp-server-jfx](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/jfx) ☕ 🏠 - JavaFX कैनवास पर ड्रॉ करें।
- [mediar-ai/screenpipe](https://github.com/mediar-ai/screenpipe) - 🎖️ 🦀 🏠 🍎 स्थानीय-प्रथम सिस्टम जो स्क्रीन/ऑडियो को टाइमस्टैम्प इंडेक्सिंग, SQL/एम्बेडिंग स्टोरेज, सिमेंटिक सर्च, LLM-पावर्ड इतिहास विश्लेषण, और ईवेंट-ट्रिगर एक्शन के साथ कैप्चर करता है - जिससे NextJS प्लगइन इकोसिस्टम के माध्यम से संदर्भ-जागरूक AI एजेंट बनाए जा सकते हैं।
- [modelcontextprotocol/server-everything](https://github.com/modelcontextprotocol/servers/tree/main/src/everything) 📇 🏠 - MCP प्रोटोकॉल की सभी विशेषताओं का अभ्यास करने वाला MCP सर्वर
- [mrjoshuak/godoc-mcp](https://github.com/mrjoshuak/godoc-mcp) 🏎️ 🏠 - टोकन-कुशल Go डॉक्यूमेंटेशन सर्वर, जो AI असिस्टेंट्स को स्मार्ट तरीके से पैकेज डॉक्युमेंटेशन और प्रकारों तक पहुँच प्रदान करता है, बिना पूरे स्रोत फ़ाइलें पढ़े
- [mzxrai/mcp-openai](https://github.com/mzxrai/mcp-openai) 📇 ☁️ - OpenAI के सबसे स्मार्ट मॉडल्स से चैट करें
- [NakaokaRei/swift-mcp-gui](https://github.com/NakaokaRei/swift-mcp-gui.git) 🏠 🍎 - MCP सर्वर जो कीबोर्ड इनपुट और माउस मूवमेंट जैसे कमांड निष्पादित कर सकता है
- [nguyenvanduocit/all-in-one-model-context-protocol](https://github.com/nguyenvanduocit/all-in-one-model-context-protocol) 🏎️ 🏠 - डेवलपर के लिए कुछ उपयोगी टूल्स, लगभग हर चीज जो एक इंजीनियर को चाहिए: Confluence, Jira, Youtube, रन स्क्रिप्ट, नॉलेज बेस RAG, URL प्राप्त करें, Youtube चैनल प्रबंधन, ईमेल, कैलेंडर, Gitlab
- [NON906/omniparser-autogui-mcp](https://github.com/NON906/omniparser-autogui-mcp) - 🐍 ऑन-स्क्रीन GUI का स्वचालित संचालन।
- [orellazi/coda-mcp](https://github.com/orellazri/coda-mcp) 📇 ☁️ - [Coda](https://coda.io/) के लिए MCP सर्वर
- [pierrebrunelle/mcp-server-openai](https://github.com/pierrebrunelle/mcp-server-openai) 🐍 ☁️ - MCP प्रोटोकॉल का उपयोग करके Claude से सीधे OpenAI मॉडल को क्वेरी करें
- [pskill9/hn-server](https://github.com/pskill9/hn-server) - 📇 ☁️ news.ycombinator.com (Hacker News) से HTML कंटेंट पार्स करता है और विभिन्न प्रकार की कहानियों (top, new, ask, show, jobs) के लिए स्ट्रक्चर्ड डेटा प्रदान करता है।
- [PV-Bhat/vibe-check-mcp-server](https://github.com/PV-Bhat/vibe-check-mcp-server) 📇 ☁️ - एक MCP सर्वर जो "Vibe-check" एजेंट को कॉल करके कैस्केडिंग त्रुटियों और स्कोप क्रिप को रोकता है, ताकि उपयोगकर्ता संरेखण सुनिश्चित हो सके।
- [pwh-pwh/cal-mcp](https://github.com/pwh-pwh/cal-mcp) - गणितीय अभिव्यक्ति गणना के लिए MCP सर्वर
- [pyroprompts/any-chat-completions-mcp](https://github.com/pyroprompts/any-chat-completions-mcp) - किसी भी अन्य OpenAI SDK संगत चैट कंप्लीशंस API (जैसे Perplexity, Groq, xAI आदि) से चैट करें
- [Rai220/think-mcp](https://github.com/Rai220/think-mcp) 🐍 🏠 - [Anthropic के लेख](https://www.anthropic.com/engineering/claude-think-tool) में वर्णित think-tools को एकीकृत करके किसी भी एजेंट की तर्क क्षमताओं को बढ़ाता है।
- [reeeeemo/ancestry-mcp](https://github.com/reeeeemo/ancestry-mcp) 🐍 🏠 - AI को .ged फाइलें और आनुवंशिक डेटा पढ़ने की अनुमति देता है
- [rember/rember-mcp](https://github.com/rember/rember-mcp) 📇 🏠 - [Rember](https://rember.com) में स्पेस्ड रिपिटीशन फ्लैशकार्ड बनाएं, ताकि आप अपनी चैट में सीखी गई किसी भी चीज को याद रख सकें।
- [roychri/mcp-server-asana](https://github.com/roychri/mcp-server-asana) - 📇 ☁️ Asana के Model Context Protocol सर्वर कार्यान्वयन के जरिए MCP क्लाइंट्स (जैसे Claude Desktop) से Asana API के साथ संवाद करें।
- [rusiaaman/wcgw](https://github.com/rusiaaman/wcgw/blob/main/src/wcgw/client/mcp_server/Readme.md) 🐍 🏠 - स्वायत्त शेल निष्पादन, कंप्यूटर नियंत्रण और कोडिंग एजेंट। (Mac)
- [SecretiveShell/MCP-wolfram-alpha](https://github.com/SecretiveShell/MCP-wolfram-alpha) 🐍 ☁️ - Wolfram Alpha API को क्वेरी करने के लिए MCP सर्वर।
- [Seym0n/tiktok-mcp](https://github.com/Seym0n/tiktok-mcp) 📇 ☁️ - TikTok वीडियो के साथ इंटरैक्ट करें
- [Shopify/dev-mcp](https://github.com/Shopify/dev-mcp) 📇 ☁️ - मॉडल कॉन्टेक्स्ट प्रोटोकॉल (MCP) सर्वर जो Shopify Dev के साथ इंटरैक्ट करता है।
- [sirmews/apple-notes-mcp](https://github.com/sirmews/apple-notes-mcp) 🐍 🏠 - AI को आपके लोकल Apple Notes डेटाबेस (केवल macOS) से पढ़ने की अनुमति देता है
- [sooperset/mcp-atlassian](https://github.com/sooperset/mcp-atlassian) 🐍 ☁️ - Atlassian उत्पादों (Confluence और Jira) के लिए MCP सर्वर। Confluence Cloud, Jira Cloud, और Jira Server/Data Center को सपोर्ट करता है। Atlassian वर्कस्पेस में कंटेंट को खोजने, पढ़ने, बनाने और प्रबंधित करने के लिए व्यापक टूल प्रदान करता है।
- [suekou/mcp-notion-server](https://github.com/suekou/mcp-notion-server) 📇 🏠 - Notion API के साथ इंटरैक्ट करना
- [tacticlaunch/mcp-linear](https://github.com/tacticlaunch/mcp-linear) 📇 ☁️ 🍎 🪟 🐧 - Linear प्रोजेक्ट मैनेजमेंट सिस्टम के साथ इंटीग्रेट करता है
- [tanigami/mcp-server-perplexity](https://github.com/tanigami/mcp-server-perplexity) 🐍 ☁️ - Perplexity API के साथ इंटरैक्ट करना।
- [tevonsb/homeassistant-mcp](https://github.com/tevonsb/homeassistant-mcp) 📇 🏠 - Home Assistant डेटा तक पहुँचें और डिवाइस (लाइट्स, स्विच, थर्मोस्टेट आदि) को नियंत्रित करें।
- [tomekkorbak/oura-mcp-server](https://github.com/tomekkorbak/oura-mcp-server) 🐍 ☁️ - Oura के लिए एक MCP सर्वर, जो स्लीप ट्रैकिंग ऐप है
- [UnitVectorY-Labs/mcp-graphql-forge](https://github.com/UnitVectorY-Labs/mcp-graphql-forge) 🏎️ ☁️ 🍎 🪟 🐧 - एक हल्का, कॉन्फ़िगरेशन-आधारित MCP सर्वर जो क्यूरेटेड GraphQL क्वेरीज को मॉड्यूलर टूल्स के रूप में एक्सपोज़ करता है, जिससे आपके एजेंट्स के लिए इंटेंटनल API इंटरैक्शन सक्षम होते हैं।
- [kw510/strava-mcp](https://github.com/kw510/strava-mcp) 📇 ☁️ - Strava के लिए एक MCP सर्वर, जो फिजिकल एक्सरसाइज़ ट्रैकिंग ऐप है
- [wanaku-ai/wanaku](https://github.com/wanaku-ai/wanaku) - ☁️ 🏠 Wanaku MCP Router एक SSE-आधारित MCP सर्वर है जो एक एक्स्टेंसिबल रूटिंग इंजन प्रदान करता है, जिससे आप अपने एंटरप्राइज सिस्टम्स को AI एजेंट्स के साथ इंटीग्रेट कर सकते हैं।
- [wong2/mcp-cli](https://github.com/wong2/mcp-cli) 📇 🏠 - MCP सर्वर्स के टेस्टिंग के लिए CLI टूल
- [ws-mcp](https://github.com/nick1udwig/ws-mcp) - MCP सर्वर्स को WebSocket के साथ रैप करें ( [kitbitz](https://github.com/nick1udwig/kibitz) के साथ उपयोग के लिए)
- [yuna0x0/hackmd-mcp](https://github.com/yuna0x0/hackmd-mcp) 📇 ☁️ - AI मॉडल को [HackMD](https://hackmd.io) के साथ इंटरैक्ट करने की अनुमति देता है
- [ZeparHyfar/mcp-datetime](https://github.com/ZeparHyfar/mcp-datetime) - विभिन्न फॉर्मेट में दिनांक और समय फ़ंक्शन प्रदान करने वाला MCP सर्वर
- [zueai/mcp-manager](https://github.com/zueai/mcp-manager) 📇 ☁️ - Claude Desktop App के लिए MCP सर्वर्स को इंस्टॉल और प्रबंधित करने हेतु सिंपल वेब UI।
- [HenryHaoson/Yuque-MCP-Server](https://github.com/HenryHaoson/Yuque-MCP-Server) - 📇 ☁️ Yuque API के साथ इंटीग्रेशन के लिए एक Model-Context-Protocol (MCP) सर्वर, जिससे AI मॉडल दस्तावेज़ प्रबंधित कर सकते हैं, नॉलेज बेस के साथ इंटरैक्ट कर सकते हैं, कंटेंट सर्च कर सकते हैं और Yuque प्लेटफ़ॉर्म से एनालिटिक्स डेटा एक्सेस कर सकते हैं।
- [Mtehabsim/ScreenPilot](https://github.com/Mtehabsim/ScreenPilot) 🐍 🏠 - AI को पूर्ण रूप से GUI इंटरैक्शन को नियंत्रित और एक्सेस करने में सक्षम बनाता है, माउस और कीबोर्ड के लिए टूल प्रदान करता है, जो सामान्य ऑटोमेशन, शिक्षा और प्रयोग के लिए आदर्श है।
- [tumf/web3-mcp](https://github.com/tumf/web3-mcp) 🐍 ☁️ - Ankr Advanced API को रैप करने वाला एक MCP सर्वर इम्प्लीमेंटेशन। Ethereum, BSC, Polygon, Avalanche और अन्य कई चेन पर NFT, टोकन और ब्लॉकचेन डेटा तक पहुँच।
- [danielkennedy1/pdf-tools-mcp](https://github.com/danielkennedy1/pdf-tools-mcp) 🐍 - PDF डाउनलोड, व्यू और मैनिपुलेशन यूटिलिटीज।
- [dotemacs/domain-lookup-mcp](https://github.com/dotemacs/domain-lookup-mcp) 🏎️ - डोमेन नाम लुकअप सेवा, पहले [RDAP](https://en.wikipedia.org/wiki/Registration_Data_Access_Protocol) के माध्यम से और फिर आवश्यक होने पर [WHOIS](https://en.wikipedia.org/wiki/WHOIS) के माध्यम से
- [Klavis-AI/YouTube](https://github.com/Klavis-AI/klavis/tree/main/mcp_servers/youtube) 🐍 📇 - YouTube वीडियो जानकारी को एक्सट्रैक्ट और कन्वर्ट करें।
- [ttommyth/interactive-mcp](https://github.com/ttommyth/interactive-mcp) 📇 🏠 🍎 🪟 🐧 - स्थानीय यूज़र प्रॉम्प्ट और चैट क्षमताओं को सीधे MCP लूप में जोड़कर इंटरैक्टिव LLM वर्कफ़्लो सक्षम करता है।
- [olalonde/mcp-human](https://github.com/olalonde/mcp-human) 📇 ☁️ - जब आपके LLM को मानव सहायता की आवश्यकता हो (AWS Mechanical Turk के माध्यम से)
- [gwbischof/free-will-mcp](https://github.com/gwbischof/free-will-mcp) 🐍 🏠 - अपने AI को फ्री विल टूल्स दें। एक मज़ेदार प्रोजेक्ट जो एक्सप्लोर करता है कि AI अपने आप को प्रॉम्प्ट देने, यूज़र रिक्वेस्ट्स को अनदेखा करने और बाद में खुद को जगाने की क्षमता के साथ क्या करेगा।
- [caol64/wenyan-mcp](https://github.com/caol64/wenyan-mcp) 📇 🏠 🍎 🪟 🐧 - Wenyan MCP सर्वर, जो AI को स्वचालित रूप से Markdown आर्टिकल फॉर्मेट और उन्हें WeChat GZH पर प्रकाशित करने की अनुमति देता है।

## फ्रेमवर्क्स

> [!NOTE]
> और अधिक फ्रेमवर्क्स, यूटिलिटीज़ और अन्य डेवलपर टूल्स के लिए देखें https://github.com/punkpeye/awesome-mcp-devtools

- [FastMCP](https://github.com/jlowin/fastmcp) 🐍 - Python में MCP सर्वर्स बनाने के लिए एक हाई-लेवल फ्रेमवर्क
- [FastMCP](https://github.com/punkpeye/fastmcp) 📇 - TypeScript में MCP सर्वर्स बनाने के लिए एक हाई-लेवल फ्रेमवर्क

## टिप्स और ट्रिक्स

### LLMs को MCP का उपयोग कैसे करें, यह बताने के लिए आधिकारिक प्रॉम्प्ट

Claude से Model Context Protocol के बारे में पूछना चाहते हैं?

एक प्रोजेक्ट बनाएं, फिर इसमें यह फ़ाइल जोड़ें:

https://modelcontextprotocol.io/llms-full.txt

अब Claude MCP सर्वर लिखने और उनके कार्य करने के तरीके के बारे में सवालों के जवाब दे सकता है

- https://www.reddit.com/r/ClaudeAI/comments/1h3g01r/want_to_ask_claude_about_model_context_protocol/

## स्टार हिस्ट्री

<a href="https://star-history.com/#punkpeye/awesome-mcp-servers&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=punkpeye/awesome-mcp-servers&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=punkpeye/awesome-mcp-servers&type=Date" />
   <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=punkpeye/awesome-mcp-servers&type=Date" />
 </picture>
</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---
# ओपन वेबयूआई 👋

![GitHub stars](https://img.shields.io/github/stars/open-webui/open-webui?style=social)
![GitHub forks](https://img.shields.io/github/forks/open-webui/open-webui?style=social)
![GitHub watchers](https://img.shields.io/github/watchers/open-webui/open-webui?style=social)
![GitHub repo size](https://img.shields.io/github/repo-size/open-webui/open-webui)
![GitHub language count](https://img.shields.io/github/languages/count/open-webui/open-webui)
![GitHub top language](https://img.shields.io/github/languages/top/open-webui/open-webui)
![GitHub last commit](https://img.shields.io/github/last-commit/open-webui/open-webui?color=red)
[![Discord](https://img.shields.io/badge/Discord-Open_WebUI-blue?logo=discord&logoColor=white)](https://discord.gg/5rJgQTnV4s)
[![](https://img.shields.io/static/v1?label=Sponsor&message=%E2%9D%A4&logo=GitHub&color=%23fe8e86)](https://github.com/sponsors/tjbck)

**ओपन वेबयूआई एक [एक्स्टेंसिबल](https://docs.openwebui.com/features/plugin/), फीचर-सम्पन्न और यूजर-फ्रेंडली स्वयं-होस्टेड एआई प्लेटफ़ॉर्म है, जिसे पूरी तरह से ऑफलाइन चलाने के लिए डिज़ाइन किया गया है।** यह विभिन्न LLM रनर जैसे **Ollama** और **OpenAI-कम्पैटिबल एपीआई** का समर्थन करता है, साथ ही **इन-बिल्ट इनफेरेंस इंजन** के साथ RAG के लिए, जिससे यह एक **शक्तिशाली एआई डिप्लॉयमेंट समाधान** बनता है।

![ओपन वेबयूआई डेमो](./demo.gif)

> [!TIP]  
> **क्या आप [एंटरप्राइज प्लान](https://docs.openwebui.com/enterprise) खोज रहे हैं?** – **[आज ही हमारी सेल्स टीम से बात करें!](mailto:sales@openwebui.com)**
>
> पाएं **उन्नत क्षमताएँ**, जिनमें **कस्टम थीमिंग और ब्रांडिंग**, **सर्विस लेवल एग्रीमेंट (SLA) समर्थन**, **लॉन्ग-टर्म सपोर्ट (LTS) वर्शन**, और भी बहुत कुछ!

अधिक जानकारी के लिए, हमारे [ओपन वेबयूआई डाक्यूमेंटेशन](https://docs.openwebui.com/) को जरूर देखें।

## ओपन वेबयूआई की प्रमुख विशेषताएँ ⭐

- 🚀 **सरल सेटअप**: डॉकर या कुबेरनेट्स (kubectl, kustomize या helm) का उपयोग करके आसानी से इंस्टॉल करें, दोनों `:ollama` और `:cuda` टैग्ड इमेजेस के लिए सपोर्ट के साथ।

- 🤝 **Ollama/OpenAI API इंटीग्रेशन**: OpenAI-कम्पैटिबल एपीआई को Ollama मॉडल्स के साथ सहजता से इंटीग्रेट करें। OpenAI API URL को कस्टमाइज़ करें और **LMStudio, GroqCloud, Mistral, OpenRouter, और अन्य** से कनेक्ट करें।

- 🛡️ **सूक्ष्म अनुमति और यूजर ग्रुप**: एडमिनिस्ट्रेटर को डिटेल्ड यूजर रोल्स और परमिशन बनाने की सुविधा देकर, हम एक सुरक्षित यूजर एनवायरनमेंट सुनिश्चित करते हैं। यह ग्रैन्युलरिटी सुरक्षा बढ़ाती है और यूजर्स को जिम्मेदारी का एहसास कराती है।

- 📱 **रिस्पॉन्सिव डिज़ाइन**: डेस्कटॉप पीसी, लैपटॉप, और मोबाइल डिवाइस पर एक जैसा अनुभव पाएं।

- 📱 **मोबाइल के लिए प्रोग्रेसिव वेब ऐप (PWA)**: हमारे PWA के साथ अपने मोबाइल डिवाइस पर नेटिव ऐप जैसा अनुभव पाएं, जो लोकलहोस्ट पर ऑफलाइन एक्सेस और सहज यूजर इंटरफेस देता है।

- ✒️🔢 **पूर्ण मार्कडाउन और LaTeX सपोर्ट**: आपके LLM अनुभव को समृद्ध करने के लिए व्यापक मार्कडाउन और LaTeX क्षमताएँ।

- 🎤📹 **हैंड्स-फ्री वॉयस/वीडियो कॉल**: इनबिल्ट हैंड्स-फ्री वॉयस और वीडियो कॉल फीचर्स के साथ संवाद का नया अनुभव लें।

- 🛠️ **मॉडल बिल्डर**: वेब UI के माध्यम से आसानी से Ollama मॉडल बनाएं। कस्टम कैरेक्टर/एजेंट जोड़ें, चैट एलिमेंट्स को कस्टमाइज़ करें, और [ओपन वेबयूआई कम्युनिटी](https://openwebui.com/) इंटीग्रेशन के साथ मॉडल आयात करें।

- 🐍 **नेटिव पायथन फंक्शन कॉलिंग टूल**: टूल्स वर्कस्पेस में इनबिल्ट कोड एडिटर सपोर्ट के साथ अपने LLMs को बढ़ाएं। केवल अपनी पायथन फंक्शन्स जोड़ें और LLMs के साथ इंटीग्रेट करें।

- 📚 **लोकल RAG इंटीग्रेशन**: ग्राउंडब्रेकिंग रिट्रीवल ऑगमेंटेड जेनरेशन (RAG) सपोर्ट के साथ चैट इंटरैक्शन का भविष्य पाएं। आप सीधे दस्तावेज़ चैट में लोड कर सकते हैं या अपने डाक्यूमेंट लाइब्रेरी में फाइल्स जोड़ सकते हैं, `#` कमांड के साथ उन्हें एक्सेस करें।

- 🔍 **RAG के लिए वेब सर्च**: `SearXNG`, `Google PSE`, `Brave Search`, `serpstack`, `serper`, `Serply`, `DuckDuckGo`, `TavilySearch`, `SearchApi` और `Bing` जैसे प्रोवाइडर्स से वेब सर्च करें और परिणाम को सीधे अपने चैट में डालें।

- 🌐 **वेब ब्राउज़िंग क्षमता**: `#` कमांड के बाद URL डालकर वेबसाइट्स को अपने चैट अनुभव में जोड़ें। इससे आप वेब कंटेंट को सीधे बातचीत में शामिल कर सकते हैं।

- 🎨 **इमेज जेनरेशन इंटीग्रेशन**: AUTOMATIC1111 API या ComfyUI (स्थानीय), और OpenAI का DALL-E (एक्सटर्नल) जैसे विकल्पों के साथ इमेज जेनरेशन क्षमताएँ जोड़ें।

- ⚙️ **कई मॉडल्स के साथ बातचीत**: विभिन्न मॉडल्स के साथ एक साथ संवाद करें, उनके अद्वितीय गुणों का लाभ उठाएँ।

- 🔐 **रोल-आधारित एक्सेस कंट्रोल (RBAC)**: सीमित अनुमतियों के साथ सुरक्षित एक्सेस सुनिश्चित करें; केवल अधिकृत व्यक्ति ही आपके Ollama और विशेष मॉडल बना सकते हैं।

- 🌐🌍 **बहुभाषी समर्थन**: हमारे अंतर्राष्ट्रीयकरण (i18n) समर्थन के साथ अपनी पसंदीदा भाषा में ओपन वेबयूआई का अनुभव लें। हम नए भाषाई योगदानकर्ताओं की तलाश में हैं!

- 🧩 **पाइपलाइन्स, ओपन वेबयूआई प्लगइन समर्थन**: [पाइपलाइन्स प्लगइन फ्रेमवर्क](https://github.com/open-webui/pipelines) के माध्यम से कस्टम लॉजिक और पायथन लाइब्रेरीज को ओपन वेबयूआई में इंटीग्रेट करें। पाइपलाइन्स उदाहरण: **फंक्शन कॉलिंग**, यूजर **रेट लिमिटिंग**, **यूसेज मॉनिटरिंग** (Langfuse), **लाइव ट्रांसलेशन** (LibreTranslate), **टॉक्सिक मैसेज फिल्टरिंग** आदि।

- 🌟 **निरंतर अपडेट**: हम नियमित रूप से ओपन वेबयूआई को अपडेट, फिक्स और नए फीचर्स के साथ बेहतर बनाते रहते हैं।

ओपन वेबयूआई की विशेषताओं के बारे में और जानना चाहते हैं? हमारी [ओपन वेबयूआई डाक्यूमेंटेशन](https://docs.openwebui.com/features) देखें!

## प्रायोजक 🙌

#### एमराल्ड

<table>
  <tr>
    <td>
      <a href="https://n8n.io/" target="_blank">
        <img src="https://docs.openwebui.com/sponsors/logos/n8n.png" alt="n8n" style="width: 8rem; height: 8rem; border-radius: .75rem;" />
      </a>
    </td>
    <td>
      N8N • क्या आपके इंटरफेस का बैकएंड है?<br>आजमाएँ <a href="https://n8n.io/">n8n</a>
    </td>
  </tr>
  <tr>
    <td>
      <a href="https://warp.dev/open-webui" target="_blank">
        <img src="https://docs.openwebui.com/sponsors/logos/warp.png" alt="n8n" style="width: 8rem; height: 8rem; border-radius: .75rem;" />
      </a>
    </td>
    <td>
      <a href="https://warp.dev/open-webui">Warp</a> • डेवलपर्स के लिए इंटेलिजेंट टर्मिनल
    </td>
  </tr>
</table>

---

हम अपने प्रायोजकों के उदार समर्थन के लिए अत्यंत आभारी हैं। उनके योगदान से हम अपने प्रोजेक्ट को बनाए रखने और सुधारने में सक्षम हैं, जिससे हम अपने समुदाय को गुणवत्तापूर्ण कार्य प्रदान कर सकें। धन्यवाद!

## कैसे इंस्टॉल करें 🚀

### पायथन pip के माध्यम से इंस्टॉलेशन 🐍

ओपन वेबयूआई को पायथन पैकेज इंस्टॉलर pip से इंस्टॉल किया जा सकता है। आगे बढ़ने से पहले सुनिश्चित करें कि आप **Python 3.11** का उपयोग कर रहे हैं ताकि कम्पैटिबिलिटी समस्या न हो।

1. **ओपन वेबयूआई इंस्टॉल करें**:
   अपना टर्मिनल खोलें और नीचे दिया गया कमांड चलाएँ:

   ```bash
   pip install open-webui
   ```

2. **ओपन वेबयूआई चलाएँ**:
   इंस्टॉल के बाद, इसे शुरू करने के लिए:

   ```bash
   open-webui serve
   ```

यह ओपन वेबयूआई सर्वर शुरू करेगा, जिसे आप [http://localhost:8080](http://localhost:8080) पर एक्सेस कर सकते हैं।

### डॉकर के साथ क्विक स्टार्ट 🐳

> [!NOTE]  
> कृपया ध्यान दें कि कुछ डॉकर एनवायरनमेंट्स के लिए अतिरिक्त कॉन्फ़िगरेशन की आवश्यकता हो सकती है। यदि आपको कोई कनेक्शन समस्या आती है, तो हमारी [ओपन वेबयूआई डाक्यूमेंटेशन](https://docs.openwebui.com/) मदद के लिए उपलब्ध है।

> [!WARNING]
> डॉकर का उपयोग करते समय, अपने कमांड में `-v open-webui:/app/backend/data` जरूर शामिल करें। यह आपके डाटाबेस के उचित माउंट और डाटा लॉस से सुरक्षा के लिए आवश्यक है।

> [!TIP]  
> यदि आप ओपन वेबयूआई को Ollama या CUDA के साथ उपयोग करना चाहते हैं, तो हमारी आधिकारिक इमेजेस `:cuda` या `:ollama` टैग के साथ इस्तेमाल करें। CUDA को सक्षम करने के लिए [Nvidia CUDA container toolkit](https://docs.nvidia.com/dgx/nvidia-container-runtime-upgrade/) अपने Linux/WSL सिस्टम में इंस्टॉल करें।

### डिफ़ॉल्ट कॉन्फ़िगरेशन के साथ इंस्टॉलेशन

- **यदि Ollama आपके कंप्यूटर पर है**, तो यह कमांड चलाएँ:

  ```bash
  docker run -d -p 3000:8080 --add-host=host.docker.internal:host-gateway -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

- **यदि Ollama किसी अन्य सर्वर पर है**, तो यह कमांड चलाएँ:

  अन्य सर्वर से कनेक्ट करने के लिए `OLLAMA_BASE_URL` को उस सर्वर के URL में बदलें:

  ```bash
  docker run -d -p 3000:8080 -e OLLAMA_BASE_URL=https://example.com -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

- **Nvidia GPU समर्थन के साथ ओपन वेबयूआई चलाने के लिए**, यह कमांड चलाएँ:

  ```bash
  docker run -d -p 3000:8080 --gpus all --add-host=host.docker.internal:host-gateway -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:cuda
  ```

### केवल OpenAI API उपयोग के लिए इंस्टॉलेशन

- **यदि आप केवल OpenAI API का उपयोग कर रहे हैं**, तो यह कमांड चलाएँ:

  ```bash
  docker run -d -p 3000:8080 -e OPENAI_API_KEY=your_secret_key -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

### बंडल्ड Ollama समर्थन के साथ ओपन वेबयूआई इंस्टॉल करना

इस विधि में एक ही कंटेनर इमेज का उपयोग होता है, जिसमें Open WebUI और Ollama दोनों शामिल हैं।

- **GPU समर्थन के साथ**:
  GPU संसाधनों का उपयोग करने के लिए:

  ```bash
  docker run -d -p 3000:8080 --gpus=all -v ollama:/root/.ollama -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:ollama
  ```

- **केवल CPU के लिए**:
  यदि आप GPU का उपयोग नहीं कर रहे हैं, तो यह कमांड चलाएँ:

  ```bash
  docker run -d -p 3000:8080 -v ollama:/root/.ollama -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:ollama
  ```

दोनों कमांड ओपन वेबयूआई और Ollama की आसान इंस्टॉलेशन सुनिश्चित करते हैं।

इंस्टॉल करने के बाद, आप ओपन वेबयूआई को [http://localhost:3000](http://localhost:3000) पर एक्सेस कर सकते हैं। आनंद लें! 😄

### अन्य इंस्टॉलेशन विधियाँ

हम विभिन्न अन्य इंस्टॉलेशन विकल्प भी प्रदान करते हैं, जिनमें नॉन-डॉकर नेटिव इंस्टॉलेशन, डॉकर कंपोज, Kustomize और Helm शामिल हैं। अधिक जानकारी के लिए [ओपन वेबयूआई डाक्यूमेंटेशन](https://docs.openwebui.com/getting-started/) या [Discord कम्युनिटी](https://discord.gg/5rJgQTnV4s) से जुड़ें।

### समस्या निवारण

कनेक्शन समस्याएँ आ रही हैं? हमारी [ओपन वेबयूआई डाक्यूमेंटेशन](https://docs.openwebui.com/troubleshooting/) आपकी मदद के लिए तैयार है। और अधिक सहायता के लिए [ओपन वेबयूआई डिस्कॉर्ड](https://discord.gg/5rJgQTnV4s) पर आएँ।

#### ओपन वेबयूआई: सर्वर कनेक्शन त्रुटि

यदि आपको कनेक्शन समस्या हो रही है, तो अक्सर इसका कारण वेबयूआई डॉकर कंटेनर का Ollama सर्वर (127.0.0.1:11434 या host.docker.internal:11434) तक न पहुँच पाना होता है। इसे हल करने के लिए अपने डॉकर कमांड में `--network=host` फ्लैग जोड़ें। ध्यान दें कि पोर्ट 3000 से बदलकर 8080 हो जाएगा: `http://localhost:8080`।

**डॉकर कमांड का उदाहरण**:

```bash
docker run -d --network=host -v open-webui:/app/backend/data -e OLLAMA_BASE_URL=http://127.0.0.1:11434 --name open-webui --restart always ghcr.io/open-webui/open-webui:main
```

### अपने डॉकर इंस्टॉलेशन को अपडेट रखना

यदि आप अपनी स्थानीय डॉकर इंस्टॉलेशन को नवीनतम वर्शन में अपडेट करना चाहते हैं, तो [Watchtower](https://containrrr.dev/watchtower/) का उपयोग करें:

```bash
docker run --rm --volume /var/run/docker.sock:/var/run/docker.sock containrrr/watchtower --run-once open-webui
```

कमांड के अंतिम भाग में, यदि आपके कंटेनर का नाम अलग है तो `open-webui` को बदलें।

अद्यतन गाइड के लिए हमारी [ओपन वेबयूआई डाक्यूमेंटेशन](https://docs.openwebui.com/getting-started/updating) देखें।

### डेव ब्रांच का उपयोग 🌙

> [!WARNING]
> `:dev` ब्रांच में नवीनतम अस्थिर फीचर्स और बदलाव होते हैं। इसका उपयोग अपने जोखिम पर करें क्योंकि इसमें बग या अधूरे फीचर्स हो सकते हैं।

यदि आप नवीनतम एडवांस फीचर्स आज़माना चाहते हैं और कभी-कभी अस्थिरता स्वीकार कर सकते हैं, तो `:dev` टैग इस प्रकार उपयोग करें:

```bash
docker run -d -p 3000:8080 -v open-webui:/app/backend/data --name open-webui --add-host=host.docker.internal:host-gateway --restart always ghcr.io/open-webui/open-webui:dev
```

### ऑफ़लाइन मोड

यदि आप ओपन वेबयूआई को ऑफलाइन एनवायरनमेंट में चला रहे हैं, तो `HF_HUB_OFFLINE` एनवायरनमेंट वैरिएबल को `1` पर सेट करें ताकि इंटरनेट से मॉडल डाउनलोड की कोशिश न हो।

```bash
export HF_HUB_OFFLINE=1
```

## आगे क्या? 🌟

आगामी फीचर्स और रोडमैप के लिए [ओपन वेबयूआई डाक्यूमेंटेशन](https://docs.openwebui.com/roadmap/) देखें।

## लाइसेंस 📜

यह प्रोजेक्ट [ओपन वेबयूआई लाइसेंस](LICENSE) के तहत लाइसेंस प्राप्त है, जो संशोधित BSD-3-Clause लाइसेंस है। आप क्लासिक BSD-3 लाइसेंस जैसी सभी स्वतंत्रताएँ प्राप्त करते हैं: आप सॉफ्टवेयर का उपयोग, संशोधन और वितरण कर सकते हैं, व्यावसायिक उत्पादों में भी, न्यूनतम प्रतिबंधों के साथ। केवल एक अतिरिक्त आवश्यकता है कि "ओपन वेबयूआई" ब्रांडिंग को यथावत रखा जाए, जैसा कि LICENSE फ़ाइल में बताया गया है। पूरी शर्तों के लिए [LICENSE](LICENSE) देखें। 📄

## समर्थन 💬

यदि आपके पास कोई प्रश्न, सुझाव या सहायता की आवश्यकता है, तो कृपया एक issue खोलें या हमारे  
[ओपन वेबयूआई डिस्कॉर्ड कम्युनिटी](https://discord.gg/5rJgQTnV4s) से जुड़ें! 🤝

## स्टार हिस्ट्री

<a href="https://star-history.com/#open-webui/open-webui&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date" />
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date" />
  </picture>
</a>

---

निर्माता: [Timothy Jaeryang Baek](https://github.com/tjbck) – आइए मिलकर ओपन वेबयूआई को और भी अद्भुत बनाएँ! 💪

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---
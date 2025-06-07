# प्रॉम्प्ट फ्लो

[![Python package](https://img.shields.io/pypi/v/promptflow)](https://pypi.org/project/promptflow/)
[![Python](https://img.shields.io/pypi/pyversions/promptflow.svg?maxAge=2592000)](https://pypi.python.org/pypi/promptflow/)
[![PyPI - Downloads](https://img.shields.io/pypi/dm/promptflow)](https://pypi.org/project/promptflow/)
[![CLI](https://img.shields.io/badge/CLI-reference-blue)](https://microsoft.github.io/promptflow/reference/pf-command-reference.html)
[![vsc extension](https://img.shields.io/visual-studio-marketplace/i/prompt-flow.prompt-flow?logo=Visual%20Studio&label=Extension%20)](https://marketplace.visualstudio.com/items?itemName=prompt-flow.prompt-flow)

[![Doc](https://img.shields.io/badge/Doc-online-green)](https://microsoft.github.io/promptflow/index.html)
[![Issue](https://img.shields.io/github/issues/microsoft/promptflow)](https://github.com/microsoft/promptflow/issues/new/choose)
[![Discussions](https://img.shields.io/github/discussions/microsoft/promptflow)](https://github.com/microsoft/promptflow/issues/new/choose)
[![CONTRIBUTING](https://img.shields.io/badge/Contributing-8A2BE2)](https://github.com/microsoft/promptflow/blob/main/CONTRIBUTING.md)
[![License: MIT](https://img.shields.io/github/license/microsoft/promptflow)](https://github.com/microsoft/promptflow/blob/main/LICENSE)

> हमारे साथ जुड़ें और [चर्चाओं](https://github.com/microsoft/promptflow/discussions) में भाग लेकर, [इश्यू](https://github.com/microsoft/promptflow/issues/new/choose) खोलकर, [PRs](https://github.com/microsoft/promptflow/pulls) सबमिट कर प्रॉम्प्ट फ्लो को बेहतर बनाएं।

**प्रॉम्प्ट फ्लो** विकास उपकरणों का एक समूह है, जिसे LLM-आधारित AI एप्लिकेशन के संपूर्ण विकास चक्र को सरल और सुव्यवस्थित करने के लिए डिज़ाइन किया गया है — आइडिएशन, प्रोटोटाइपिंग, परीक्षण, मूल्यांकन से लेकर प्रोडक्शन डिप्लॉयमेंट और मॉनिटरिंग तक। यह प्रॉम्प्ट इंजीनियरिंग को बहुत आसान बनाता है और आपको प्रोडक्शन गुणवत्ता वाले LLM ऐप बनाने में सक्षम बनाता है।

प्रॉम्प्ट फ्लो के साथ, आप निम्नलिखित कर सकते हैं:

- **फ्लो बनाएं और इटरटिवली विकसित करें**
    - निष्पादन योग्य [फ्लो](https://microsoft.github.io/promptflow/concepts/concept-flows.html) बनाएं जो LLMs, प्रॉम्प्ट्स, पायथन कोड और अन्य [टूल्स](https://microsoft.github.io/promptflow/concepts/concept-tools.html) को आपस में जोड़ते हैं।
    - अपने फ्लो को डिबग और इटरेट करें, विशेष रूप से [LLMs के साथ इंटरैक्शन को ट्रेस](https://microsoft.github.io/promptflow/how-to-guides/tracing/index.html) करना आसान बनाएं।
- **फ्लो की गुणवत्ता और प्रदर्शन का मूल्यांकन करें**
    - अपने फ्लो की गुणवत्ता और प्रदर्शन का बड़े डेटा सेट के साथ मूल्यांकन करें।
    - अपने फ्लो की गुणवत्ता सुनिश्चित करने के लिए परीक्षण और मूल्यांकन को अपने CI/CD सिस्टम में एकीकृत करें।
- **प्रोडक्शन के लिए सुव्यवस्थित विकास चक्र**
    - अपने फ्लो को उस सर्विंग प्लेटफॉर्म पर डिप्लॉय करें जिसे आप चुनते हैं या अपने ऐप के कोड बेस में आसानी से एकीकृत करें।
    - (वैकल्पिक लेकिन अत्यधिक अनुशंसित) अपनी टीम के साथ सहयोग करें [Azure AI में प्रॉम्प्ट फ्लो](https://learn.microsoft.com/en-us/azure/machine-learning/prompt-flow/overview-what-is-prompt-flow?view=azureml-api-2) के क्लाउड संस्करण का लाभ उठाकर।

------

## इंस्टॉलेशन

जल्दी से शुरुआत करने के लिए, आप प्री-बिल्ट डेवलपमेंट एनवायरनमेंट का उपयोग कर सकते हैं। **नीचे दिए गए बटन पर क्लिक करें** और इस रेपो को GitHub Codespaces में खोलें, फिर README पढ़ना जारी रखें!

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/promptflow?quickstart=1)

यदि आप अपने लोकल एनवायरनमेंट में शुरू करना चाहते हैं, तो पहले निम्नलिखित पैकेज इंस्टॉल करें:

सुनिश्चित करें कि आपके पास पायथन एनवायरनमेंट है, `python>=3.9, <=3.11` अनुशंसित है।

```sh
pip install promptflow promptflow-tools
```

## त्वरित शुरुआत ⚡

**प्रॉम्प्ट फ्लो के साथ एक चैटबॉट बनाएं**

एक चैट टेम्पलेट से प्रॉम्प्ट फ्लो शुरू करने के लिए कमांड चलाएं, यह `my_chatbot` नामक फोल्डर बनाएगा और आवश्यक फाइलें उसमें जेनरेट करेगा:

```sh
pf flow init --flow ./my_chatbot --type chat
```

**अपने API कुंजी के लिए कनेक्शन सेटअप करें**

OpenAI कुंजी के लिए, `my_chatbot` फोल्डर में मौजूद `openai.yaml` फाइल का उपयोग करते हुए कमांड चलाएं, जिसमें आपकी OpenAI कुंजी संग्रहीत होती है (yaml फाइल में बदलाव से बचने के लिए --set के साथ कुंजी और नाम ओवरराइड करें):

```sh
pf connection create --file ./my_chatbot/openai.yaml --set api_key=<your_api_key> --name open_ai_connection
```

Azure OpenAI कुंजी के लिए, `azure_openai.yaml` फाइल का उपयोग करते हुए कमांड चलाएं:

```sh
pf connection create --file ./my_chatbot/azure_openai.yaml --set api_key=<your_api_key> api_base=<your_api_base> --name open_ai_connection
```

**अपने फ्लो के साथ चैट करें**

`my_chatbot` फोल्डर में, एक `flow.dag.yaml` फाइल है, जिसमें फ्लो की रूपरेखा, इनपुट/आउटपुट, नोड्स, कनेक्शन, LLM मॉडल आदि शामिल हैं।

> ध्यान दें कि `chat` नोड में, हम `open_ai_connection` नामक कनेक्शन (जो `connection` फील्ड में निर्दिष्ट है) और `gpt-35-turbo` मॉडल (जो `deployment_name` फील्ड में निर्दिष्ट है) का उपयोग कर रहे हैं। deployment_name फील्ड OpenAI मॉडल या Azure OpenAI डिप्लॉयमेंट रिसोर्स को निर्दिष्ट करने के लिए है।

अपने चैटबॉट के साथ बातचीत करने के लिए निम्न कमांड चलाएं: (सेशन समाप्त करने के लिए `Ctrl + C` दबाएं)

```sh
pf flow test --flow ./my_chatbot --interactive
```

**मुख्य मूल्य: प्रोटोटाइप से प्रोडक्शन तक "उच्च गुणवत्ता" सुनिश्चित करना**

हमारे [**15-मिनट ट्यूटोरियल**](https://raw.githubusercontent.com/microsoft/promptflow/main/examples/tutorials/flow-fine-tuning-evaluation/promptflow-quality-improvement.md) को एक्सप्लोर करें, जो आपको प्रॉम्प्ट ट्यूनिंग ➡ बैच टेस्टिंग ➡ मूल्यांकन के माध्यम से मार्गदर्शन करता है, ताकि प्रोडक्शन के लिए उच्च गुणवत्ता सुनिश्चित की जा सके।

अगला कदम! प्रॉम्प्ट फ्लो में गहराई से जानने के लिए **ट्यूटोरियल** 👇 अनुभाग के साथ जारी रखें।

## ट्यूटोरियल 🏃‍♂️

प्रॉम्प्ट फ्लो एक ऐसा टूल है जिसे **उच्च गुणवत्ता वाले LLM ऐप्स बनाने** के लिए डिज़ाइन किया गया है, इसमें विकास प्रक्रिया निम्नलिखित चरणों में होती है: फ्लो विकसित करें, फ्लो की गुणवत्ता में सुधार करें, फ्लो को प्रोडक्शन में डिप्लॉय करें।

### अपना खुद का LLM ऐप विकसित करें

#### VS कोड एक्सटेंशन

हम एक VS कोड एक्सटेंशन (फ्लो डिजाइनर) भी प्रदान करते हैं, जो UI के साथ इंटरैक्टिव फ्लो विकास अनुभव देता है।

<img src="https://raw.githubusercontent.com/microsoft/promptflow/main/docs/media/readme/vsc.png" alt="vsc" width="1000"/>

आप इसे <a href="https://marketplace.visualstudio.com/items?itemName=prompt-flow.prompt-flow">Visual Studio मार्केटप्लेस</a> से इंस्टॉल कर सकते हैं।

#### फ्लो विकास में गहराई से जाएं

[प्रॉम्प्ट फ्लो के साथ शुरुआत करें](https://raw.githubusercontent.com/microsoft/promptflow/main/docs/how-to-guides/quick-start.md): अपनी पहली फ्लो रन इनवोक करने के लिए स्टेप-बाय-स्टेप मार्गदर्शन।

### उपयोग के मामलों से सीखें

[ट्यूटोरियल: PDF के साथ चैट करें](https://github.com/microsoft/promptflow/blob/main/examples/tutorials/e2e-development/chat-with-pdf.md): एक उच्च गुणवत्ता वाला चैट एप्लिकेशन बनाने पर एक एंड-टू-एंड ट्यूटोरियल, जिसमें फ्लो विकास और मेट्रिक्स के साथ मूल्यांकन शामिल है।
> और अधिक उदाहरण [यहां](https://microsoft.github.io/promptflow/tutorials/index.html#samples) मिल सकते हैं। हम नए उपयोग मामलों के योगदान का स्वागत करते हैं!

### योगदानकर्ताओं के लिए सेटअप

यदि आप योगदान करने में रुचि रखते हैं, तो कृपया हमारे dev सेटअप गाइड से शुरू करें: [dev_setup.md](https://raw.githubusercontent.com/microsoft/promptflow/main/docs/dev/dev_setup.md)।

अगला कदम! प्रॉम्प्ट फ्लो में योगदान करने के लिए **Contributing** 👇 अनुभाग के साथ आगे बढ़ें।

## योगदान

यह प्रोजेक्ट योगदान और सुझावों का स्वागत करता है। अधिकांश योगदानों के लिए आपको एक
Contributor License Agreement (CLA) पर सहमति देनी होगी, जिसमें यह घोषित करना होगा कि आपके पास योगदान देने का अधिकार है और आप हमें अपने योगदान का उपयोग करने का अधिकार प्रदान करते हैं। विवरण के लिए देखें https://cla.opensource.microsoft.com।

जब आप कोई पुल अनुरोध सबमिट करते हैं, तो एक CLA बोट स्वचालित रूप से निर्धारित करेगा कि आपको CLA प्रदान करने की आवश्यकता है या नहीं और PR को उपयुक्त रूप से सजाएगा (जैसे, स्टेटस चेक, टिप्पणी)। बस बोट द्वारा दिए गए निर्देशों का पालन करें। आपको यह केवल एक बार करना होगा, सभी रेपो में जो हमारे CLA का उपयोग करते हैं।

इस प्रोजेक्ट ने [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/) अपनाया है। अधिक जानकारी के लिए देखें [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) या [opencode@microsoft.com](mailto:opencode@microsoft.com) पर संपर्क करें।

## ट्रेडमार्क

इस प्रोजेक्ट में प्रोजेक्ट्स, उत्पादों या सेवाओं के लिए ट्रेडमार्क या लोगो शामिल हो सकते हैं। Microsoft ट्रेडमार्क या लोगो का अधिकृत उपयोग [Microsoft's Trademark & Brand Guidelines](https://www.microsoft.com/en-us/legal/intellectualproperty/trademarks/usage/general) के अधीन है।
प्रोजेक्ट के संशोधित संस्करणों में Microsoft ट्रेडमार्क या लोगो का उपयोग भ्रम पैदा नहीं करना चाहिए या Microsoft के प्रायोजन का संकेत नहीं देना चाहिए।
किसी भी थर्ड-पार्टी ट्रेडमार्क या लोगो का उपयोग उन थर्ड-पार्टी की नीतियों के अधीन है।

## आचार संहिता

इस प्रोजेक्ट ने [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/) अपनाया है।
अधिक जानकारी के लिए देखें
[Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/)
या [opencode@microsoft.com](mailto:opencode@microsoft.com) पर संपर्क करें।

## डेटा संग्रह

सॉफ़्टवेयर आपके बारे में और आपके सॉफ़्टवेयर उपयोग के बारे में जानकारी एकत्र कर सकता है और यदि टेलीमेट्री सक्षम है तो उसे Microsoft को भेज सकता है।
Microsoft इस जानकारी का उपयोग सेवाएं प्रदान करने और अपने उत्पादों और सेवाओं में सुधार के लिए कर सकता है।
आप इस रेपो में वर्णित अनुसार टेलीमेट्री को चालू कर सकते हैं।
सॉफ़्टवेयर में कुछ ऐसी विशेषताएँ भी हो सकती हैं जो आपको और Microsoft को आपके एप्लिकेशन के उपयोगकर्ताओं से डेटा एकत्र करने में सक्षम बनाती हैं। यदि आप इन सुविधाओं का उपयोग करते हैं, तो आपको लागू कानूनों का पालन करना होगा, जिसमें अपने एप्लिकेशन के उपयोगकर्ताओं को उचित सूचना देना और Microsoft की गोपनीयता नीति की एक प्रति प्रदान करना शामिल है। हमारी गोपनीयता नीति यहाँ उपलब्ध है:
https://go.microsoft.com/fwlink/?LinkID=824704। आप सहायता प्रलेखन और हमारी गोपनीयता नीति में डेटा संग्रह और उपयोग के बारे में अधिक जान सकते हैं। सॉफ़्टवेयर का आपका उपयोग इन प्रथाओं के लिए आपकी सहमति के रूप में काम करता है।

### टेलीमेट्री कॉन्फ़िगरेशन

डिफ़ॉल्ट रूप से टेलीमेट्री संग्रह चालू है।

इसे बंद करने के लिए, कृपया `pf config set telemetry.enabled=false` चलाएं।

## लाइसेंस

Copyright (c) Microsoft Corporation. सर्वाधिकार सुरक्षित।

[MIT](LICENSE) लाइसेंस के तहत लाइसेंस प्राप्त।

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---
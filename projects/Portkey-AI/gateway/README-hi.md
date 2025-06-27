<p align="right">
   <strong>English</strong> | <a href="./.github/README.cn.md">中文</a> | <a href="./.github/README.jp.md">日本語</a>
</p>

<div align="center">

<a href="https://portkey.sh/report-github"><img src="https://raw.githubusercontent.com/siddharthsambharia-portkey/Portkey-Product-Images/refs/heads/main/LLM%20Report%20Campaign%20Frame.png"></img></a>
<br>

# एआई गेटवे
#### 1 तेज़ और मित्रवत API के साथ 250+ LLMs तक रूट करें

<img src="https://cfassets.portkey.ai/sdk.gif" width="550px" alt="Portkey AI Gateway Demo showing LLM routing capabilities" style="margin-left:-35px">

[Docs](https://portkey.wiki/gh-1) | [Enterprise](https://portkey.wiki/gh-2) | [Hosted Gateway](https://portkey.wiki/gh-3) | [Changelog](https://portkey.wiki/gh-4) | [API Reference](https://portkey.wiki/gh-5)


[![License](https://img.shields.io/github/license/Ileriayo/markdown-badges)](./LICENSE)
[![Discord](https://img.shields.io/discord/1143393887742861333)](https://portkey.wiki/gh-6)
[![Twitter](https://img.shields.io/twitter/url/https/twitter/follow/portkeyai?style=social&label=Follow%20%40PortkeyAI)](https://portkey.wiki/gh-7)
[![npm version](https://badge.fury.io/js/%40portkey-ai%2Fgateway.svg)](https://portkey.wiki/gh-8)
[![Better Stack Badge](https://uptime.betterstack.com/status-badges/v1/monitor/q94g.svg)](https://portkey.wiki/gh-9)

<a href="https://us-east-1.console.aws.amazon.com/cloudformation/home?region=us-east-1#/stacks/quickcreate?stackName=portkey-gateway&templateURL=https://portkey-gateway-ec2-quicklaunch.s3.us-east-1.amazonaws.com/portkey-gateway-ec2-quicklaunch.template.yaml"><img src="https://img.shields.io/badge/Deploy_to_EC2-232F3E?style=for-the-badge&logo=amazonwebservices&logoColor=white" alt="Deploy to AWS EC2" width="105"/></a> [![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/Portkey-AI/gateway)
</div>

<br/>

[**एआई गेटवे**](https://portkey.wiki/gh-10) को तेज़, विश्वसनीय और सुरक्षित रूटिंग के लिए डिज़ाइन किया गया है, जो 1600+ भाषा, विज़न, ऑडियो और इमेज मॉडल्स तक पहुँच प्रदान करता है। यह एक हल्का, ओपन-सोर्स और एंटरप्राइज़-रेडी समाधान है जो आपको किसी भी भाषा मॉडल के साथ 2 मिनट से कम समय में इंटीग्रेट करने की सुविधा देता है।

- [x] **बहुत तेज़** (<1ms लेटेंसी) और बहुत कम साइज (122kb)
- [x] **बड़े स्तर पर टेस्टेड**, हर दिन 10B से अधिक टोकन प्रोसेस होते हैं
- [x] **एंटरप्राइज़-रेडी** - बेहतर सुरक्षा, स्केल और कस्टम डिप्लॉयमेंट के साथ

<br>

#### एआई गेटवे के साथ आप क्या कर सकते हैं?
- किसी भी LLM के साथ 2 मिनट में इंटीग्रेट करें - [Quickstart](#quickstart-2-mins)
- **[ऑटोमैटिक रिट्राईज़](https://portkey.wiki/gh-11)** और **[फॉलबैक्स](https://portkey.wiki/gh-12)** के माध्यम से डाउनटाइम रोकें
- **[लोड बैलेंसिंग](https://portkey.wiki/gh-13)** और **[कंडीशनल रूटिंग](https://portkey.wiki/gh-14)** के साथ AI एप्स को स्केल करें
- **[गार्डरेल्स](https://portkey.wiki/gh-15)** के साथ अपने AI डिप्लॉयमेंट को सुरक्षित बनाएं
- **[मल्टी-मोडल क्षमताओं](https://portkey.wiki/gh-16)** के साथ सिर्फ टेक्स्ट से आगे बढ़ें
- **[एजेंटिक वर्कफ़्लो](https://portkey.wiki/gh-17)** इंटीग्रेशन एक्सप्लोर करें

<br><br>

> [!TIP]
> इस रिपॉजिटरी को स्टार करने से अधिक डेवलपर्स को AI Gateway के बारे में पता चलता है 🙏🏻
>
> ![star-2](https://github.com/user-attachments/assets/53597dce-6333-4ecc-a154-eb05532954e4)
> 
<br>


<br>

## क्विकस्टार्ट (2 मिनट)

### 1. अपना एआई गेटवे सेटअप करें

```bash
# गेटवे को लोकली चलाएं (Node.js और npm की आवश्यकता है)
npx @portkey-ai/gateway
```
> गेटवे `http://localhost:8787/v1` पर चल रहा है
> 
> गेटवे कंसोल `http://localhost:8787/public/` पर चल रहा है

<sup>
डिप्लॉयमेंट गाइड्स:
&nbsp; <a href="https://portkey.wiki/gh-18"><img height="12" width="12" src="https://cfassets.portkey.ai/logo/dew-color.svg" /> Portkey Cloud (अनुशंसित)</a>
&nbsp; <a href="./docs/installation-deployments.md#docker"><img height="12" width="12" src="https://cdn.simpleicons.org/docker/3776AB" /> Docker</a>
&nbsp; <a href="./docs/installation-deployments.md#nodejs-server"><img height="12" width="12" src="https://cdn.simpleicons.org/node.js/3776AB" /> Node.js</a>
&nbsp; <a href="./docs/installation-deployments.md#cloudflare-workers"><img height="12" width="12" src="https://cdn.simpleicons.org/cloudflare/3776AB" /> Cloudflare</a>
&nbsp; <a href="./docs/installation-deployments.md#replit"><img height="12" width="12" src="https://cdn.simpleicons.org/replit/3776AB" /> Replit</a>
&nbsp; <a href="./docs/installation-deployments.md"> अन्य...</a>

</sup>

### 2. अपनी पहली रिक्वेस्ट करें

<!-- <details open>
<summary>Python Example</summary> -->
```python
# pip install -qU portkey-ai

from portkey_ai import Portkey

# OpenAI संगत क्लाइंट
client = Portkey(
    provider="openai", # या 'anthropic', 'bedrock', 'groq', आदि
    Authorization="sk-***" # प्रोवाइडर API कुंजी
)

# अपने एआई गेटवे के माध्यम से अनुरोध करें
client.chat.completions.create(
    messages=[{"role": "user", "content": "What's the weather like?"}],
    model="gpt-4o-mini"
)
```



<sup>सपोर्टेड लाइब्रेरीज़:
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/javascript/3776AB" /> JS](https://portkey.wiki/gh-19)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/python/3776AB" /> Python](https://portkey.wiki/gh-20)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/gnubash/3776AB" /> REST](https://portkey.sh/gh-84)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/openai/3776AB" /> OpenAI SDKs](https://portkey.wiki/gh-21)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/langchain/3776AB" /> Langchain](https://portkey.wiki/gh-22)
&nbsp; [LlamaIndex](https://portkey.wiki/gh-23)
&nbsp; [Autogen](https://portkey.wiki/gh-24)
&nbsp; [CrewAI](https://portkey.wiki/gh-25)
&nbsp; [More..](https://portkey.wiki/gh-26)
</sup>

गेटवे कंसोल (`http://localhost:8787/public/`) पर आप अपने सभी लोकल लॉग्स एक ही जगह देख सकते हैं।

<img src="https://github.com/user-attachments/assets/362bc916-0fc9-43f1-a39e-4bd71aac4a3a" width="400" />


### 3. रूटिंग और गार्डरेल्स
LLM गेटवे में `Configs` आपको रूटिंग रूल्स बनाने, विश्वसनीयता जोड़ने और गार्डरेल्स सेटअप करने की सुविधा देता है।
```python
config = {
  "retry": {"attempts": 5},

  "output_guardrails": [{
    "default.contains": {"operator": "none", "words": ["Apple"]},
    "deny": True
  }]
}

# कॉन्फ़िग को क्लाइंट से जोड़ें
client = client.with_options(config=config)

client.chat.completions.create(
    model="gpt-4o-mini",
    messages=[{"role": "user", "content": "Reply randomly with Apple or Bat"}]
)

# यह हमेशा "Bat" के साथ उत्तर देगा क्योंकि गार्डरेल सभी "Apple" वाले उत्तरों को अस्वीकार कर देता है। रिट्राई कॉन्फ़िग 5 बार कोशिश करेगा।
```
<div align="center">
<img src="https://portkey.ai/blog/content/images/size/w1600/2024/11/image-15.png" width=600 title="Request flow through Portkey's AI gateway with retries and guardrails" alt="Request flow through Portkey's AI gateway with retries and guardrails"/>
</div>

आप अपने एआई गेटवे में कॉन्फ़िग्स के साथ और भी कई चीज़ें कर सकते हैं। [उदाहरण देखें  →](https://portkey.wiki/gh-27)

<br/>

### एंटरप्राइज़ वर्शन (प्राइवेट डिप्लॉयमेंट्स)

<sup>

[<img height="12" width="12" src="https://cfassets.portkey.ai/amazon-logo.svg" /> AWS](https://portkey.wiki/gh-28)
&nbsp; [<img height="12" width="12" src="https://cfassets.portkey.ai/azure-logo.svg" /> Azure](https://portkey.wiki/gh-29)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/googlecloud/3776AB" /> GCP](https://portkey.wiki/gh-30)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/redhatopenshift/3776AB" /> OpenShift](https://portkey.wiki/gh-31)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/kubernetes/3776AB" /> Kubernetes](https://portkey.wiki/gh-85)

</sup>

LLM गेटवे का [एंटरप्राइज़ वर्शन](https://portkey.wiki/gh-86) **संगठन प्रबंधन**, **गवर्नेंस**, **सुरक्षा** और [अन्य](https://portkey.wiki/gh-87) एडवांस्ड क्षमताएं बॉक्स से बाहर प्रदान करता है। [फीचर तुलना देखें →](https://portkey.wiki/gh-32)

समर्थित प्लेटफार्म्स के लिए एंटरप्राइज़ डिप्लॉयमेंट आर्किटेक्चर यहां उपलब्ध है - [**एंटरप्राइज़ प्राइवेट क्लाउड डिप्लॉयमेंट**](https://portkey.wiki/gh-33)

<a href="https://portkey.sh/demo-13"><img src="https://portkey.ai/blog/content/images/2024/08/Get-API-Key--5-.png" height=50 alt="Book an enterprise AI gateway demo" /></a><br/>


<br>

<hr>

### एआई इंजीनियरिंग ऑवर्स

हर शुक्रवार (8 AM PT) को साप्ताहिक कम्युनिटी कॉल्स में जुड़ें और अपने एआई गेटवे इम्प्लीमेंटेशन की शुरुआत करें! [हर शुक्रवार](https://portkey.wiki/gh-35)

<a href="https://portkey.wiki/gh-35"><img width="500" src="https://github.com/user-attachments/assets/c2885699-f197-4289-b819-21eb839fbae1" /></a>

मीटिंग्स के मिनट्स [यहां प्रकाशित](https://portkey.wiki/gh-36) किए गए हैं।


<hr>

### LLMs in Prod'25

2 ट्रिलियन+ टोकन, 90+ रीजन और 650+ टीम्स के प्रोडक्शन एनालिसिस से इनसाइट्स। इस रिपोर्ट से जानें:
- एआई अपनाने और LLM प्रोवाइडर ग्रोथ को आकार देने वाले ट्रेंड्स।
- स्पीड, लागत और विश्वसनीयता के लिए बेंचमार्क्स।
- प्रोडक्शन-ग्रेड एआई सिस्टम्स को स्केल करने की रणनीतियाँ।

<a href="https://portkey.sh/report-github"><img width="500" src="https://raw.githubusercontent.com/siddharthsambharia-portkey/Portkey-Product-Images/refs/heads/main/LLM%20Report%20Campaign%20Image.png" /></a>

<a href="https://portkey.sh/report-github">**रिपोर्ट प्राप्त करें**</a>
<hr>


## मुख्य विशेषताएँ
### विश्वसनीय रूटिंग
- <a href="https://portkey.wiki/gh-37">**फ़ॉलबैक**</a>: LLM गेटवे का उपयोग करके असफल अनुरोधों पर किसी अन्य प्रदाता या मॉडल पर फ़ॉलबैक करें। आप यह निर्दिष्ट कर सकते हैं कि किन त्रुटियों पर फ़ॉलबैक ट्रिगर करना है। आपकी एप्लिकेशन की विश्वसनीयता में सुधार करता है।
- <a href="https://portkey.wiki/gh-38">**स्वचालित पुनः प्रयास**</a>: असफल अनुरोधों को स्वचालित रूप से 5 बार तक पुनः प्रयास करें। एक एक्सपोनेंशियल बैकऑफ रणनीति पुनः प्रयासों के बीच अंतराल रखती है ताकि नेटवर्क ओवरलोड न हो।
- <a href="https://portkey.wiki/gh-39">**लोड बैलेंसिंग**</a>: LLM अनुरोधों को कई API कुंजियों या AI प्रदाताओं के बीच भार के अनुसार वितरित करें, ताकि उच्च उपलब्धता और अनुकूलित प्रदर्शन सुनिश्चित हो।
- <a href="https://portkey.wiki/gh-40">**अनुरोध टाइमआउट**</a>: ग्रैन्युलर अनुरोध टाइमआउट सेट करके अनियंत्रित LLMs और विलंबता का प्रबंधन करें, जिससे निर्दिष्ट अवधि से अधिक अनुरोधों का स्वचालित रूप से समापन हो सके।
- <a href="https://portkey.wiki/gh-41">**मल्टी-मोडल LLM गेटवे**</a>: विज़न, ऑडियो (टेक्स्ट-टू-स्पीच और स्पीच-टू-टेक्स्ट), और इमेज जनरेशन मॉडल्स को कई प्रदाताओं से कॉल करें — वह भी परिचित OpenAI सिग्नेचर का उपयोग करते हुए।
- <a href="https://portkey.wiki/gh-42">**रीयलटाइम API**</a>: OpenAI द्वारा लॉन्च किए गए रीयलटाइम API को इंटीग्रेटेड वेब सॉकेट्स सर्वर के माध्यम से कॉल करें।

### सुरक्षा और सटीकता
- <a href="https://portkey.wiki/gh-88">**गार्डरेल्स**</a>: अपने LLM इनपुट और आउटपुट को आपके निर्दिष्ट मानकों के अनुसार सत्यापित करें। सुरक्षा और सटीकता मानकों के पालन के लिए 40+ प्री-बिल्ट गार्डरेल्स में से चुनें। आप <a href="https://portkey.wiki/gh-43">अपने स्वयं के गार्डरेल्स ला सकते हैं</a> या हमारे <a href="https://portkey.wiki/gh-44">कई साझेदारों</a> में से चुन सकते हैं।
- [**सुरक्षित कुंजी प्रबंधन**](https://portkey.wiki/gh-45): अपनी स्वयं की कुंजियों का उपयोग करें या चलते-फिरते वर्चुअल कुंजी जनरेट करें।
- [**भूमिका-आधारित एक्सेस कंट्रोल**](https://portkey.wiki/gh-46): अपने उपयोगकर्ताओं, वर्कस्पेस और API कुंजियों के लिए ग्रैन्युलर एक्सेस कंट्रोल।
- <a href="https://portkey.wiki/gh-47">**अनुपालन और डेटा गोपनीयता**</a>: AI गेटवे SOC2, HIPAA, GDPR, और CCPA के अनुरूप है।

### लागत प्रबंधन
- [**स्मार्ट कैशिंग**](https://portkey.wiki/gh-48): लागत कम करने और विलंबता सुधारने के लिए LLMs से प्राप्त प्रतिक्रियाओं को कैश करें। सरल और सेमांटिक* कैशिंग को सपोर्ट करता है।
- [**उपयोग विश्लेषण**](https://portkey.wiki/gh-49): अपने AI और LLM उपयोग की निगरानी और विश्लेषण करें, जिसमें अनुरोध मात्रा, विलंबता, लागत और त्रुटि दरें शामिल हैं।
- [**प्रदाता अनुकूलन***](https://portkey.wiki/gh-89): उपयोग पैटर्न और मूल्य निर्धारण मॉडल के आधार पर सबसे किफायती प्रदाता पर स्वचालित रूप से स्विच करें।

### सहयोग और वर्कफ़्लो
- <a href="https://portkey.ai/docs/integrations/agents">**एजेंट्स सपोर्ट**</a>: जटिल AI एप्लिकेशन बनाने के लिए लोकप्रिय एजेंट फ्रेमवर्क्स के साथ निर्बाध रूप से एकीकृत करें। गेटवे [Autogen](https://portkey.wiki/gh-50), [CrewAI](https://portkey.wiki/gh-51), [LangChain](https://portkey.wiki/gh-52), [LlamaIndex](https://portkey.wiki/gh-53), [Phidata](https://portkey.wiki/gh-54), [Control Flow](https://portkey.wiki/gh-55), और यहाँ तक कि [Custom Agents](https://portkey.wiki/gh-56) के साथ सहजता से एकीकृत होता है।
- [**प्रॉम्प्ट टेम्पलेट प्रबंधन***](https://portkey.wiki/gh-57): एक सार्वभौमिक प्रॉम्प्ट प्लेग्राउंड के माध्यम से अपने प्रॉम्प्ट टेम्पलेट्स को सहयोगात्मक रूप से बनाएं, प्रबंधित करें और संस्करण नियंत्रित करें।
<br/><br/>

<sup>
*&nbsp;होस्टेड और एंटरप्राइज़ वर्शन में उपलब्ध
</sup>

<br>

## कुकबुक्स

### ☄️ ट्रेंडिंग
- [Nvidia NIM](/cookbook/providers/nvidia.ipynb) के मॉडल्स को AI Gateway के साथ उपयोग करें
- [CrewAI एजेंट्स](/cookbook/monitoring-agents/CrewAI_with_Telemetry.ipynb) को Portkey के साथ मॉनिटर करें!
- [शीर्ष 10 LMSYS मॉडल्स](/cookbook/use-cases/LMSYS%20Series/comparing-top10-LMSYS-models-with-Portkey.ipynb) की तुलना AI Gateway के साथ करें।

### 🚨 नवीनतम
* [Nemotron का उपयोग करके सिंथेटिक डेटासेट बनाएं](/cookbook/use-cases/Nemotron_GPT_Finetuning_Portkey.ipynb)
* [Vercel के AI SDK के साथ LLM Gateway का उपयोग करें](/cookbook/integrations/vercel-ai.md)
* [Portkey के LLM Gateway के साथ Llama Agents को मॉनिटर करें](/cookbook/monitoring-agents/Llama_Agents_with_Telemetry.ipynb)

[सभी कुकबुक्स देखें →](https://portkey.wiki/gh-58)
<br/><br/>

## समर्थित प्रदाता

[45+ प्रदाताओं](https://portkey.wiki/gh-59) और [8+ एजेंट फ्रेमवर्क्स](https://portkey.wiki/gh-90) के साथ Gateway इंटीग्रेशन देखें।

|                                                                                                                            | प्रदाता                                                                                      | सपोर्ट | स्ट्रीम |
| -------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | ------- | ------ |
| <img src="docs/images/openai.png" width=35 />                                                                              | [OpenAI](https://portkey.wiki/gh-60)                           | ✅       | ✅      |
| <img src="docs/images/azure.png" width=35>                                                                                 | [Azure OpenAI](https://portkey.wiki/gh-61)               | ✅       | ✅      |
| <img src="docs/images/anyscale.png" width=35>                                                                              | [Anyscale](https://portkey.wiki/gh-62) | ✅       | ✅      |
| <img src="https://upload.wikimedia.org/wikipedia/commons/2/2d/Google-favicon-2015.png" width=35>                           | [Google Gemini](https://portkey.wiki/gh-63)             | ✅       | ✅      |
| <img src="docs/images/anthropic.png" width=35>                                                                             | [Anthropic](https://portkey.wiki/gh-64)                     | ✅       | ✅      |
| <img src="docs/images/cohere.png" width=35>                                                                                | [Cohere](https://portkey.wiki/gh-65)                           | ✅       | ✅      |
| <img src="https://assets-global.website-files.com/64f6f2c0e3f4c5a91c1e823a/654693d569494912cfc0c0d4_favicon.svg" width=35> | [Together AI](https://portkey.wiki/gh-66)                 | ✅       | ✅      |
| <img src="https://www.perplexity.ai/favicon.svg" width=35>                                                                 | [Perplexity](https://portkey.wiki/gh-67)                | ✅       | ✅      |
| <img src="https://docs.mistral.ai/img/favicon.ico" width=35>                                                               | [Mistral](https://portkey.wiki/gh-68)                      | ✅       | ✅      |
| <img src="https://docs.nomic.ai/img/nomic-logo.png" width=35>                                                              | [Nomic](https://portkey.wiki/gh-69)                             | ✅       | ✅      |
| <img src="https://files.readme.io/d38a23e-small-studio-favicon.png" width=35>                                              | [AI21](https://portkey.wiki/gh-91)                                    | ✅       | ✅      |
| <img src="https://platform.stability.ai/small-logo-purple.svg" width=35>                                                   | [Stability AI](https://portkey.wiki/gh-71)               | ✅       | ✅      |
| <img src="https://deepinfra.com/_next/static/media/logo.4a03fd3d.svg" width=35>                                            | [DeepInfra](https://portkey.sh/gh-92)                               | ✅       | ✅      |
| <img src="https://ollama.com/public/ollama.png" width=35>                                                                  | [Ollama](https://portkey.wiki/gh-72)                           | ✅       | ✅      |
| <img src="https://novita.ai/favicon.ico" width=35>                                                                         | [Novita AI](https://portkey.wiki/gh-73)                              | ✅       | ✅      | `/chat/completions`, `/completions` |


> [यहाँ 200+ समर्थित मॉडलों की पूरी सूची देखें](https://portkey.wiki/gh-74)
<br>

<br>

## एजेंट्स
Gateway लोकप्रिय एजेंट फ्रेमवर्क्स के साथ सहजता से एकीकृत होता है। [यहाँ प्रलेखन पढ़ें](https://portkey.wiki/gh-75)।

| फ्रेमवर्क | 200+ LLMs कॉल करें | उन्नत रूटिंग | कैशिंग | लॉगिंग और ट्रेसिंग* | ऑब्ज़र्वेबिलिटी* | प्रॉम्प्ट प्रबंधन* |
|------------------------------|--------|-------------|---------|------|---------------|-------------------|
| [Autogen](https://portkey.wiki/gh-93)    | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [CrewAI](https://portkey.wiki/gh-94)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [LangChain](https://portkey.wiki/gh-95)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Phidata](https://portkey.wiki/gh-96)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Llama Index](https://portkey.wiki/gh-97)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Control Flow](https://portkey.wiki/gh-98) | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Build Your Own Agents](https://portkey.wiki/gh-99) | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |

<br>

* [होस्टेड ऐप](https://portkey.wiki/gh-76) पर उपलब्ध। विस्तृत प्रलेखन के लिए [यहाँ क्लिक करें](https://portkey.wiki/gh-100)।

## गेटवे एंटरप्राइज़ वर्शन
अपने AI ऐप को अधिक <ins>विश्वसनीय</ins> और <ins>फॉरवर्ड कंपैटिबल</ins> बनाएं, साथ ही पूर्ण <ins>डेटा सुरक्षा</ins> और <ins>गोपनीयता</ins> सुनिश्चित करें।

✅&nbsp; सुरक्षित कुंजी प्रबंधन - भूमिका-आधारित एक्सेस कंट्रोल और ट्रैकिंग के लिए <br>
✅&nbsp; सरल एवं सेमांटिक कैशिंग - बार-बार पूछे गए प्रश्नों को तेज़ी से सर्व करने और लागत बचाने के लिए <br>
✅&nbsp; एक्सेस कंट्रोल और इनबाउंड नियम - यह नियंत्रित करने के लिए कि कौन से IPs और Geos आपकी डिप्लॉयमेंट्स से कनेक्ट कर सकते हैं <br>
✅&nbsp; PII रीडैक्शन - आपके अनुरोधों से संवेदनशील डेटा को स्वचालित रूप से हटाने के लिए, ताकि अनजाने में डेटा एक्सपोज़र रोका जा सके <br>
✅&nbsp; SOC2, ISO, HIPAA, GDPR अनुपालन - सर्वोत्तम सुरक्षा प्रथाओं के लिए <br>
✅&nbsp; पेशेवर सहायता - साथ ही फ़ीचर प्राथमिकता <br>

[एंटरप्राइज़ डिप्लॉयमेंट्स पर चर्चा के लिए कॉल शेड्यूल करें](https://portkey.sh/demo-13)

<br>

## योगदान

योगदान करने का सबसे आसान तरीका है `good first issue` टैग वाले किसी मुद्दे को चुनना 💪। योगदान दिशानिर्देश [यहाँ पढ़ें](/.github/CONTRIBUTING.md)।

बग रिपोर्ट? [यहाँ फ़ाइल करें](https://portkey.wiki/gh-78) | फ़ीचर अनुरोध? [यहाँ फ़ाइल करें](https://portkey.wiki/gh-78)


### समुदाय के साथ शुरुआत करें
हमारे साप्ताहिक AI इंजीनियरिंग ऑवर्स में हर शुक्रवार (8 AM PT) जुड़ें:
- अन्य योगदानकर्ताओं और समुदाय के सदस्यों से मिलें
- Gateway की उन्नत विशेषताओं और इम्प्लीमेंटेशन पैटर्न सीखें
- अपने अनुभव साझा करें और सहायता प्राप्त करें
- नवीनतम विकास प्राथमिकताओं से अपडेट रहें

[अगले सत्र से जुड़ें →](https://portkey.wiki/gh-101) | [मीटिंग नोट्स](https://portkey.wiki/gh-102)

<br>

## समुदाय

AI पर सहायता, विचारों और चर्चाओं के लिए हमारी बढ़ती वैश्विक समुदाय से जुड़ें।

- हमारे आधिकारिक [ब्लॉग](https://portkey.wiki/gh-78) को देखें
- [Discord](https://portkey.wiki/community) पर हमसे चैट करें
- [Twitter](https://portkey.wiki/gh-79) पर हमें फॉलो करें
- [LinkedIn](https://portkey.wiki/gh-80) पर हमसे जुड़ें
- [जापानी में प्रलेखन पढ़ें](./.github/README.jp.md)
- [YouTube](https://portkey.wiki/gh-103) पर हमें देखें
- हमारी [डेव कम्युनिटी](https://portkey.wiki/gh-82) से जुड़ें
<!-- - [Stack Overflow](https://stackoverflow.com/questions/tagged/portkey) पर #portkey टैग किए गए प्रश्न -->

![Rubeus Social Share (4)](https://github.com/Portkey-AI/gateway/assets/971978/89d6f0af-a95d-4402-b451-14764c40d03f)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---
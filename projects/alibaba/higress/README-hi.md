<a name="readme-top"></a>
<h1 align="center">
    <img src="https://img.alicdn.com/imgextra/i2/O1CN01NwxLDd20nxfGBjxmZ_!!6000000006895-2-tps-960-290.png" alt="Higress" width="240" height="72.5">
  <br>
  एआई गेटवे
</h1>
<h4 align="center"> एआई नेटिव एपीआई गेटवे </h4>

<div align="center">
    
[![Build Status](https://github.com/alibaba/higress/actions/workflows/build-and-test.yaml/badge.svg?branch=main)](https://github.com/alibaba/higress/actions)
[![license](https://img.shields.io/github/license/alibaba/higress.svg)](https://www.apache.org/licenses/LICENSE-2.0.html)
[![discord](https://img.shields.io/discord/1364956090566971515?color=5865F2&label=discord&labelColor=black&logo=discord&logoColor=white&style=flat-square)](https://discord.gg/tSbww9VDaM)

<a href="https://trendshift.io/repositories/10918" target="_blank"><img src="https://trendshift.io/api/badge/repositories/10918" alt="alibaba%2Fhigress | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a> <a href="https://www.producthunt.com/posts/higress?embed=true&utm_source=badge-featured&utm_medium=badge&utm_souce=badge-higress" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=951287&theme=light&t=1745492822283" alt="Higress - Global&#0032;APIs&#0032;as&#0032;MCP&#0032;powered&#0032;by&#0032;AI&#0032;Gateway | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

</div>

[**आधिकारिक साइट**](https://higress.ai/en/) &nbsp; |
&nbsp; [**MCP सर्वर क्विकस्टार्ट**](https://higress.cn/en/ai/mcp-quick-start/) &nbsp; |
&nbsp; [**Wasm प्लगइन हब**](https://higress.cn/en/plugin/) &nbsp; |

<p>
   English | <a href="README_ZH.md">中文<a/> | <a href="README_JP.md">日本語<a/>
</p>

## Higress क्या है?

Higress एक क्लाउड-नेटिव एपीआई गेटवे है जो Istio और Envoy पर आधारित है, जिसे Go/Rust/JS में लिखे गए Wasm प्लगइनों के साथ एक्सटेंड किया जा सकता है। यह दर्जनों तैयार-प्रयोग सामान्य-उद्देश्य प्लगइन और एक आउट-ऑफ-द-बॉक्स कंसोल प्रदान करता है ([डेमो यहाँ आज़माएं](http://demo.higress.io/))।

### मुख्य उपयोग केस

Higress की एआई गेटवे क्षमताएँ सभी [मुख्यधारा के मॉडल प्रदाताओं](https://raw.githubusercontent.com/alibaba/higress/main/plugins/wasm-go/extensions/ai-proxy/provider) (देशी और अंतरराष्ट्रीय दोनों) का समर्थन करती हैं। यह अपने प्लगइन मैकेनिज्म के माध्यम से MCP (Model Context Protocol) सर्वरों की होस्टिंग भी सक्षम बनाता है, जिससे एआई एजेंट्स विभिन्न टूल्स और सेवाओं को आसानी से कॉल कर सकते हैं। [openapi-to-mcp टूल](https://github.com/higress-group/openapi-to-mcpserver) के साथ, आप OpenAPI स्पेसिफिकेशन को जल्दी से रिमोट MCP सर्वर में बदल सकते हैं। Higress LLM API और MCP API दोनों के लिए एकीकृत प्रबंधन प्रदान करता है।

**🌟 अभी आज़माएँ [https://mcp.higress.ai/](https://mcp.higress.ai/)** और Higress-होस्टेड रिमोट MCP सर्वर का प्रत्यक्ष अनुभव लें:

![Higress MCP Server Platform](https://img.alicdn.com/imgextra/i2/O1CN01nmVa0a1aChgpyyWOX_!!6000000003294-0-tps-3430-1742.jpg)

### एंटरप्राइज अपनाने

Higress का जन्म Alibaba के भीतर Tengine रीलोड की समस्या को हल करने के लिए हुआ था, जिससे लॉन्ग-कनेक्शन सेवाओं पर असर पड़ता था और gRPC/Dubbo के लिए लोड बैलेंसिंग की क्षमताएँ पर्याप्त नहीं थीं। Alibaba Cloud में, Higress की एआई गेटवे क्षमताएँ Tongyi Bailian मॉडल स्टूडियो, मशीन लर्निंग PAI प्लेटफार्म और अन्य महत्वपूर्ण एआई सेवाओं जैसे कोर एआई अनुप्रयोगों का समर्थन करती हैं। Alibaba Cloud ने Higress के आधार पर अपना क्लाउड-नेटिव एपीआई गेटवे उत्पाद बनाया है, जो ढेरों एंटरप्राइज ग्राहकों के लिए 99.99% गेटवे हाई-अवेलेबिलिटी गारंटी सेवा प्रदान करता है।

## सारांश

- [**क्विक स्टार्ट**](#quick-start)    
- [**फीचर शोकेस**](#feature-showcase)
- [**उपयोग केस**](#use-cases)
- [**मुख्य लाभ**](#core-advantages)
- [**समुदाय**](#community)

## क्विक स्टार्ट

Higress को केवल Docker के साथ शुरू किया जा सकता है, जिससे व्यक्तिगत डेवलपर्स के लिए लोकल रूप से सीखने या साधारण साइट्स बनाने के लिए सेटअप करना आसान हो जाता है:

```bash
# एक वर्किंग डायरेक्टरी बनाएं
mkdir higress; cd higress
# Higress शुरू करें, कॉन्फ़िगरेशन फाइलें वर्किंग डायरेक्टरी में लिखी जाएंगी
docker run -d --rm --name higress-ai -v ${PWD}:/data \
        -p 8001:8001 -p 8080:8080 -p 8443:8443  \
        higress-registry.cn-hangzhou.cr.aliyuncs.com/higress/all-in-one:latest
```

पोर्ट विवरण:

- पोर्ट 8001: Higress UI कंसोल एंट्री
- पोर्ट 8080: गेटवे HTTP प्रोटोकॉल एंट्री
- पोर्ट 8443: गेटवे HTTPS प्रोटोकॉल एंट्री

> सभी Higress डॉकर इमेजें Higress की अपनी इमेज रिपॉजिटरी का उपयोग करती हैं और Docker Hub की रेट लिमिट से प्रभावित नहीं होतीं।
> इसके अलावा, इमेज की सबमिशन और अपडेट सुरक्षा स्कैनिंग मैकेनिज्म (Alibaba Cloud ACR द्वारा संचालित) से सुरक्षित हैं, जिससे ये प्रोडक्शन वातावरण में उपयोग के लिए बहुत सुरक्षित हैं।
> 
> यदि आप `higress-registry.cn-hangzhou.cr.aliyuncs.com` से इमेज पुल करते समय टाइमआउट का सामना करते हैं, तो आप निम्न डॉकर रजिस्ट्री मिरर स्रोत का उपयोग कर सकते हैं:
> 
> **दक्षिण पूर्व एशिया**: `higress-registry.ap-southeast-7.cr.aliyuncs.com`

K8s के अंतर्गत Helm डिप्लॉयमेंट जैसी अन्य इंस्टॉलेशन विधियों के लिए, कृपया आधिकारिक [क्विक स्टार्ट डाक्यूमेंटेशन](https://higress.io/en-us/docs/user/quickstart) देखें।

## उपयोग केस

- **MCP सर्वर होस्टिंग**:

  Higress अपने प्लगइन मैकेनिज्म के माध्यम से MCP सर्वरों की होस्टिंग करता है, जिससे एआई एजेंट्स विभिन्न टूल्स और सेवाओं को आसानी से कॉल कर सकते हैं। [openapi-to-mcp टूल](https://github.com/higress-group/openapi-to-mcpserver) के साथ, आप OpenAPI स्पेसिफिकेशन को जल्दी से रिमोट MCP सर्वर में बदल सकते हैं।

  ![](https://img.alicdn.com/imgextra/i1/O1CN01wv8H4g1mS4MUzC1QC_!!6000000004952-2-tps-1764-597.png)

  Higress के साथ MCP सर्वर होस्टिंग के प्रमुख लाभ:
  - एकीकृत प्रमाणीकरण और प्राधिकरण मैकेनिज्म
  - दुरुपयोग से बचाव के लिए फाइन-ग्रेन रेट लिमिटिंग
  - सभी टूल कॉल्स के लिए व्यापक ऑडिट लॉग्स
  - प्रदर्शन की निगरानी के लिए समृद्ध ऑब्जर्वेबिलिटी
  - Higress के प्लगइन मैकेनिज्म के माध्यम से सरलीकृत डिप्लॉयमेंट
  - बिना व्यवधान के डायनामिक अपडेट या कनेक्शन ड्रॉप के

     [और जानें...](https://higress.cn/en/ai/mcp-quick-start/?spm=36971b57.7beea2de.0.0.d85f20a94jsWGm)

- **एआई गेटवे**:

  Higress सभी LLM मॉडल प्रदाताओं से एकीकृत प्रोटोकॉल के साथ जुड़ता है, एआई ऑब्जर्वेबिलिटी, मल्टी-मॉडल लोड बैलेंसिंग, टोकन रेट लिमिटिंग, और कैशिंग क्षमताओं के साथ:

  ![](https://img.alicdn.com/imgextra/i2/O1CN01izmBNX1jbHT7lP3Yr_!!6000000004566-0-tps-1920-1080.jpg)

- **Kubernetes इनग्रेस कंट्रोलर**:

  Higress एक फीचर-समृद्ध इनग्रेस कंट्रोलर के रूप में काम कर सकता है, जो K8s के nginx इनग्रेस कंट्रोलर के कई एनोटेशन के साथ संगत है।
  
  [Gateway API](https://gateway-api.sigs.k8s.io/) का समर्थन जल्द आ रहा है और यह Ingress API से Gateway API में सहज माइग्रेशन को सपोर्ट करेगा।
  
- **माइक्रोसर्विस गेटवे**:

  Higress एक माइक्रोसर्विस गेटवे के रूप में काम कर सकता है, जो विभिन्न सर्विस रजिस्ट्री जैसे Nacos, ZooKeeper, Consul, Eureka आदि से माइक्रोसर्विसेज की खोज कर सकता है।
  
  यह [Dubbo](https://github.com/apache/dubbo), [Nacos](https://github.com/alibaba/nacos), [Sentinel](https://github.com/alibaba/Sentinel) और अन्य माइक्रोसर्विस टेक्नोलॉजी स्टैक्स के साथ गहराई से एकीकृत है।
  
- **सुरक्षा गेटवे**:

  Higress को एक सुरक्षा गेटवे के रूप में उपयोग किया जा सकता है, जो WAF और विभिन्न प्रमाणीकरण रणनीतियों का समर्थन करता है, जैसे कि key-auth, hmac-auth, jwt-auth, basic-auth, oidc आदि।

## मुख्य लाभ

- **प्रोडक्शन ग्रेड**

  Alibaba के आंतरिक उत्पाद से उत्पन्न, 2+ वर्षों के प्रोडक्शन सत्यापन के साथ, सैकड़ों हज़ारों अनुरोध प्रति सेकंड वाले बड़े पैमाने के परिदृश्यों का समर्थन करता है।

  Nginx रीलोड के कारण ट्रैफिक जिटर को पूरी तरह समाप्त करता है, कॉन्फ़िगरेशन परिवर्तन मिलीसेकंड में प्रभावी होते हैं और व्यवसाय के लिए पारदर्शी होते हैं। खासकर एआई व्यवसाय जैसे लॉन्ग-कनेक्शन परिदृश्यों के लिए बहुत अनुकूल।

- **स्ट्रीमिंग प्रोसेसिंग**

  अनुरोध/प्रतिक्रिया बॉडी की सच्ची पूर्ण स्ट्रीमिंग प्रोसेसिंग का समर्थन करता है, Wasm प्लगइन्स आसानी से SSE (Server-Sent Events) जैसे स्ट्रीमिंग प्रोटोकॉल का कस्टम हैंडलिंग कर सकते हैं।

  एआई व्यवसाय जैसे उच्च-बैंडविड्थ परिदृश्यों में, यह मेमोरी ओवरहेड को काफी कम कर सकता है।
    
- **आसान विस्तार**

  एआई, ट्रैफिक प्रबंधन, सुरक्षा संरक्षण और अन्य सामान्य कार्यों को कवर करने वाली समृद्ध आधिकारिक प्लगइन लाइब्रेरी प्रदान करता है, जो 90% से अधिक व्यवसाय परिदृश्य आवश्यकताओं को पूरा करता है।

  Wasm प्लगइन एक्सटेंशन पर केंद्रित, सैंडबॉक्स आइसोलेशन के माध्यम से मेमोरी सुरक्षा सुनिश्चित करता है, बहु-प्रोग्रामिंग भाषाओं का समर्थन करता है, प्लगइन संस्करणों को स्वतंत्र रूप से अपग्रेड करने की अनुमति देता है, और गेटवे लॉजिक के ट्रैफिक-लॉसलेस हॉट अपडेट को प्राप्त करता है।

- **सुरक्षित और उपयोग में आसान**

  Ingress API और Gateway API मानकों पर आधारित, आउट-ऑफ-द-बॉक्स UI कंसोल, WAF सुरक्षा प्लगइन, IP/Cookie CC सुरक्षा प्लगइन तैयार उपयोग के लिए प्रदान करता है।

  Let's Encrypt से कनेक्ट कर फ्री सर्टिफिकेट्स की ऑटो-इश्यू और रिन्यूअल का समर्थन करता है, K8s के बाहर भी डिप्लॉय किया जा सकता है, एकल डॉकर कमांड से शुरू किया जा सकता है, व्यक्तिगत डेवलपर्स के लिए सुविधाजनक।

## समुदाय

हमारे Discord समुदाय से जुड़ें! यहाँ आप Higress के डेवलपर्स और अन्य उत्साही उपयोगकर्ताओं से जुड़ सकते हैं।

[![discord](https://img.shields.io/discord/1364956090566971515?color=5865F2&label=discord&labelColor=black&logo=discord&logoColor=white&style=for-the-badge)](https://discord.gg/tSbww9VDaM)

### धन्यवाद

Higress समुदाय में परियोजनाओं के कीमती ओपन-सोर्स कार्य के बिना संभव नहीं होता। हम Envoy और Istio का विशेष धन्यवाद करना चाहेंगे।

### संबंधित रिपॉजिटरी

- Higress कंसोल: https://github.com/higress-group/higress-console
- Higress स्टैंडअलोन: https://github.com/higress-group/higress-standalone

### योगदानकर्ता

<a href="https://github.com/alibaba/higress/graphs/contributors">
  <img alt="contributors" src="https://contrib.rocks/image?repo=alibaba/higress"/>
</a>

### स्टार इतिहास

[![Star History Chart](https://api.star-history.com/svg?repos=alibaba/higress&type=Date)](https://star-history.com/#alibaba/higress&Date)

<p align="right" style="font-size: 14px; color: #555; margin-top: 20px;">
    <a href="#readme-top" style="text-decoration: none; color: #007bff; font-weight: bold;">
        ↑ शीर्ष पर वापस जाएं ↑
    </a>
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---
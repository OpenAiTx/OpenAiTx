![Envoy लोगो](https://github.com/envoyproxy/artwork/blob/main/PNG/Envoy_Logo_Final_PANTONE.png)

[क्लाउड-नेटिव उच्च-प्रदर्शन एज/मिडल/सर्विस प्रॉक्सी](https://www.envoyproxy.io/)

Envoy की मेज़बानी [Cloud Native Computing Foundation](https://cncf.io) (CNCF) द्वारा की जाती है। यदि आप एक ऐसी कंपनी हैं जो कंटेनर-पैकेज्ड, डायनेमिकली-शेड्यूल्ड और माइक्रोसर्विस-ओरिएंटेड टेक्नोलॉजीज़ के विकास को आकार देने में मदद करना चाहती है, तो कृपया CNCF में शामिल होने पर विचार करें। इसमें कौन-कौन शामिल है और Envoy किस प्रकार भूमिका निभाता है, इसके लिए CNCF की
[घोषणा](https://www.cncf.io/blog/2017/09/13/cncf-hosts-envoy/) पढ़ें।

[![CII बेस्ट प्रैक्टिसेज](https://bestpractices.coreinfrastructure.org/projects/1266/badge)](https://bestpractices.coreinfrastructure.org/projects/1266)
[![OpenSSF स्कोरकार्ड](https://api.securityscorecards.dev/projects/github.com/envoyproxy/envoy/badge)](https://securityscorecards.dev/viewer/?uri=github.com/envoyproxy/envoy)
[![CLOMonitor](https://img.shields.io/endpoint?url=https://clomonitor.io/api/projects/cncf/envoy/badge)](https://clomonitor.io/projects/cncf/envoy)
[![Azure Pipelines](https://dev.azure.com/cncf/envoy/_apis/build/status/11?branchName=main)](https://dev.azure.com/cncf/envoy/_build/latest?definitionId=11&branchName=main)
[![Fuzzing स्थिति](https://oss-fuzz-build-logs.storage.googleapis.com/badges/envoy.svg)](https://bugs.chromium.org/p/oss-fuzz/issues/list?sort=-opened&can=1&q=proj:envoy)
[![Jenkins](https://powerci.osuosl.org/buildStatus/icon?job=build-envoy-static-master&subject=ppc64le%20build)](https://powerci.osuosl.org/job/build-envoy-static-master/)
[![Jenkins](https://ibmz-ci.osuosl.org/buildStatus/icon?job=Envoy_IBMZ_CI&subject=s390x%20build)](https://ibmz-ci.osuosl.org/job/Envoy_IBMZ_CI/)

## दस्तावेज़ीकरण

* [आधिकारिक दस्तावेज़ीकरण](https://www.envoyproxy.io/)
* [FAQ](https://www.envoyproxy.io/docs/envoy/latest/faq/overview)
* [उदाहरण दस्तावेज़ीकरण](https://github.com/envoyproxy/examples/)
* [ब्लॉग](https://medium.com/@mattklein123/envoy-threading-model-a8d44b922310) थ्रेडिंग मॉडल के बारे में
* [ब्लॉग](https://medium.com/@mattklein123/envoy-hot-restart-1d16b14555b5) हॉट रीस्टार्ट के बारे में
* [ब्लॉग](https://medium.com/@mattklein123/envoy-stats-b65c7f363342) स्टैट्स आर्किटेक्चर के बारे में
* [ब्लॉग](https://medium.com/@mattklein123/the-universal-data-plane-api-d15cec7a) यूनिवर्सल डेटा प्लेन API के बारे में
* [ब्लॉग](https://medium.com/@mattklein123/lyfts-envoy-dashboards-5c91738816b1) Lyft के Envoy डैशबोर्ड्स पर

## संबंधित

* [data-plane-api](https://github.com/envoyproxy/data-plane-api): v2 API परिभाषाएँ एक स्वतंत्र
  रिपॉजिटरी के रूप में। यह [api](api/) का केवल-पढ़ने योग्य मिरर है।
* [envoy-perf](https://github.com/envoyproxy/envoy-perf): प्रदर्शन परीक्षण फ्रेमवर्क।
* [envoy-filter-example](https://github.com/envoyproxy/envoy-filter-example): नए फिल्टर जोड़ने और मुख्य रिपॉजिटरी से लिंक करने का उदाहरण।

## संपर्क

* [envoy-announce](https://groups.google.com/forum/#!forum/envoy-announce): कम आवृत्ति वाली मेलिंग
  सूची, जिसमें केवल घोषणाएँ भेजी जाती हैं।
* [envoy-security-announce](https://groups.google.com/forum/#!forum/envoy-security-announce): कम आवृत्ति वाली मेलिंग
  सूची, जिसमें केवल सुरक्षा-संबंधी घोषणाएँ भेजी जाती हैं।
* [envoy-users](https://groups.google.com/forum/#!forum/envoy-users): सामान्य उपयोगकर्ता चर्चा।
* [envoy-dev](https://groups.google.com/forum/#!forum/envoy-dev): Envoy डेवलपर चर्चा (APIs,
  फीचर डिज़ाइन, आदि)।
* [envoy-maintainers](https://groups.google.com/forum/#!forum/envoy-maintainers): सभी मुख्य Envoy मेंटेनर्स से संपर्क के लिए इस सूची का उपयोग करें।
* [Twitter](https://twitter.com/EnvoyProxy/): Twitter पर फॉलो करें!
* [Slack](https://envoyproxy.slack.com/): Slack, निमंत्रण के लिए [यहाँ](https://communityinviter.com/apps/envoyproxy/envoy) जाएँ।
  * नोट: Slack पर उपयोगकर्ता प्रश्नों का उत्तर सर्वोत्तम प्रयास के आधार पर दिया जाता है। "गारंटीड" उत्तर के लिए कृपया नीचे दिए गए लिंक्ड थ्रेड के निर्देशानुसार envoy-users@ पर ईमेल करें।

कृपया ईमेल सूची उपयोग के बारे में जानकारी के लिए [यह](https://groups.google.com/forum/#!topic/envoy-announce/l9zjYsnS3TY) ईमेल थ्रेड देखें।

## योगदान

Envoy में योगदान करना मज़ेदार है और आधुनिक C++ उतना डरावना नहीं है जितना आप सोच सकते हैं, भले ही आपका कोई पूर्व अनुभव न हो। प्रारंभ करने के लिए:

* [योगदान गाइड](CONTRIBUTING.md)
* [शुरुआती मुद्दे](https://github.com/envoyproxy/envoy/issues?q=is%3Aopen+is%3Aissue+label%3Abeginner)
* [डॉकर का उपयोग करके त्वरित बिल्ड/परीक्षण प्रारंभ](ci#building-and-running-tests-as-a-developer)
* [डेवलपर गाइड](DEVELOPER.md)
* Envoy [डेवलपमेंट सपोर्ट टूलचेन](https://github.com/envoyproxy/envoy/blob/main/support/README.md) स्थापित करने पर विचार करें, जो विकास प्रक्रिया के कुछ हिस्सों को स्वचालित करने में मदद करता है, विशेषकर कोड रिव्यू से संबंधित।
* कृपया यह सुनिश्चित करें कि यदि आप किसी मुद्दे पर काम कर रहे हैं, तो हमें बताएं, ताकि हम कार्य को दोहरा न दें!

## सामुदायिक बैठक

Envoy टीम की निर्धारित बैठक माह में दो बार मंगलवार को सुबह 9 बजे PT पर होती है। सार्वजनिक
Google कैलेंडर [यहाँ](https://goo.gl/PkDijT) है। बैठक केवल तभी आयोजित की जाएगी
जब [बैठक के मिनट्स](https://goo.gl/5Cergb) में एजेंडा आइटम सूचीबद्ध हों। किसी भी समुदाय सदस्य को
मिनट्स में जोड़कर एजेंडा आइटम प्रस्तावित करने में सक्षम होना चाहिए। मेंटेनर्स या तो
एजेंडा में जोड़ने की पुष्टि करेंगे, या यदि कोई पुष्टि नहीं हुई तो निर्धारित तिथि से 24 घंटे के भीतर बैठक रद्द कर देंगे।

## सुरक्षा

### सुरक्षा ऑडिट

Envoy सुरक्षा पर केंद्रित कई थर्ड पार्टी एंगेजमेंट्स हुए हैं:
* 2018 में Cure53 ने एक सुरक्षा ऑडिट किया, [पूर्ण रिपोर्ट](https://raw.githubusercontent.com/envoyproxy/envoy/main/docs/security/audit_cure53_2018.pdf)।
* 2021 में Ada Logics ने हमारे फज़िंग इन्फ्रास्ट्रक्चर पर ऑडिट किया और सुधार के लिए सिफारिशें दीं, [पूर्ण रिपोर्ट](https://raw.githubusercontent.com/envoyproxy/envoy/main/docs/security/audit_fuzzer_adalogics_2021.pdf)।

### सुरक्षा कमजोरियों की रिपोर्टिंग

यदि आपने Envoy में कोई कमजोरी या संभावित कमजोरी पाई है, तो कृपया हमें
[envoy-security](mailto:envoy-security@googlegroups.com) पर बताएं। हम आपकी रिपोर्ट स्वीकार करने के लिए पुष्टिकरण ईमेल भेजेंगे, और जब हम समस्या की पहचान कर लेंगे (सकारात्मक या नकारात्मक), तो अतिरिक्त ईमेल भेजेंगे।

अधिक जानकारी के लिए कृपया हमारी पूरी [सुरक्षा रिलीज़ प्रक्रिया](https://raw.githubusercontent.com/envoyproxy/envoy/main/SECURITY.md) देखें।

### ppc64le बिल्ड्स

ppc64le आर्किटेक्चर या aws-lc का उपयोग करके बनाए गए बिल्ड्स Envoy सुरक्षा नीति के अंतर्गत नहीं आते। ppc64le आर्किटेक्चर वर्तमान में सर्वोत्तम प्रयास के आधार पर है और Envoy मेंटेनर्स द्वारा मेंटेन नहीं किया जाता।

## रिलीज़

अधिक जानकारी के लिए कृपया हमारी [रिलीज़ प्रक्रिया](https://github.com/envoyproxy/envoy/blob/main/RELEASES.md) देखें।


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-12

---
[![License](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE) [![Coverage](https://github.com/NVIDIA/KAI-Scheduler/raw/coverage-badge/badges/coverage.svg)](https://github.com/NVIDIA/KAI-Scheduler/blob/main/.github/workflows/update-coverage-badge.yaml)
# KAI शेड्यूलर
KAI शेड्यूलर एक मजबूत, कुशल और स्केलेबल [Kubernetes शेड्यूलर](https://kubernetes.io/docs/concepts/scheduling-eviction/kube-scheduler/) है, जो AI और मशीन लर्निंग वर्कलोड्स के लिए GPU संसाधनों का अनुकूल आवंटन करता है।

यह बड़े पैमाने पर GPU क्लस्टर्स (हजारों नोड्स सहित) और उच्च-थ्रूपुट वर्कलोड्स को प्रबंधित करने के लिए डिज़ाइन किया गया है, जिससे KAI शेड्यूलर बड़े और मांग वाले परिवेशों के लिए आदर्श बनता है।
KAI शेड्यूलर Kubernetes क्लस्टर्स के प्रशासकों को वर्कलोड्स के लिए GPU संसाधनों का डायनामिक रूप से आवंटन करने की अनुमति देता है। 

KAI शेड्यूलर पूरे AI लाइफसायकल का समर्थन करता है, छोटे, इंटरएक्टिव जॉब्स से लेकर बड़े प्रशिक्षण और इन्फरेंस तक, वह भी एक ही क्लस्टर के भीतर।
यह विभिन्न उपभोक्ताओं के बीच संसाधन निष्पक्षता बनाए रखते हुए संसाधनों का इष्टतम आवंटन सुनिश्चित करता है।
यह क्लस्टर पर इंस्टॉल किए गए अन्य शेड्यूलरों के साथ-साथ चल सकता है।

## मुख्य विशेषताएँ
* [बैच शेड्यूलिंग](docs/batch/README.md): सुनिश्चित करें कि एक समूह के सभी पॉड्स एक साथ शेड्यूल हों या बिल्कुल भी न हों।
* बिन पैकिंग एवं स्प्रेड शेड्यूलिंग: नोड उपयोग का अनुकूलन करें, या तो विखंडन को न्यूनतम करके (बिन-पैकिंग) या लचीलापन और लोड बैलेंसिंग बढ़ाकर (स्प्रेड शेड्यूलिंग)।
* [वर्कलोड प्राथमिकता](docs/priority/README.md): कतारों के भीतर वर्कलोड्स को प्रभावी ढंग से प्राथमिकता दें।
* [श्रृंखलाबद्ध कतारें](docs/queues/README.md): लचीले संगठनात्मक नियंत्रण के लिए दो-स्तरीय कतार संरचनाओं के साथ वर्कलोड्स प्रबंधित करें।
* [संसाधन वितरण](docs/fairness/README.md#resource-division-algorithm): प्रत्येक कतार के लिए कोटा, ओवर-कोटा वेट, लिमिट्स और प्राथमिकताएँ अनुकूलित करें।
* [निष्पक्षता नीति](docs/fairness/README.md#reclaim-strategies): डोमिनेंट रिसोर्स फेयरनेस (DRF) और कतारों में संसाधन पुनःप्राप्ति का उपयोग कर समान संसाधन वितरण सुनिश्चित करें।
* वर्कलोड समेकन: क्लस्टर उपयोगिता बढ़ाने और विखंडन कम करने के लिए चल रहे वर्कलोड्स को बुद्धिमानी से फिर से आवंटित करें।
* [इलास्टिक वर्कलोड्स](docs/elastic/README.md): न्यूनतम और अधिकतम पॉड काउंट के भीतर वर्कलोड्स को डायनामिक रूप से स्केल करें।
* डायनामिक रिसोर्स एलोकेशन (DRA): Kubernetes ResourceClaims के माध्यम से वेंडर-विशिष्ट हार्डवेयर संसाधनों का समर्थन करें (जैसे NVIDIA या AMD के GPU)।
* [GPU शेयरिंग](docs/gpu-sharing/README.md): कई वर्कलोड्स को एक या एकाधिक GPU को कुशलतापूर्वक साझा करने की अनुमति दें, संसाधन उपयोगिता को अधिकतम करें।
* क्लाउड एवं ऑन-प्रिमाइज़ समर्थन: डायनामिक क्लाउड इंफ्रास्ट्रक्चर (जैसे Karpenter जैसे ऑटो-स्केलर) के साथ-साथ स्थिर ऑन-प्रिमाइज़ डिप्लॉयमेंट के साथ पूरी तरह संगत।

## पूर्व-आवश्यकताएँ
KAI शेड्यूलर स्थापित करने से पहले सुनिश्चित करें कि आपके पास निम्नलिखित हैं:

- एक चालू Kubernetes क्लस्टर
- [Helm](https://helm.sh/docs/intro/install) CLI स्थापित
- [NVIDIA GPU-Operator](https://github.com/NVIDIA/gpu-operator) स्थापित हो ताकि GPU संसाधनों की मांग करने वाले वर्कलोड्स को शेड्यूल किया जा सके

## स्थापना
KAI शेड्यूलर को `kai-scheduler` नामस्थान में स्थापित किया जाएगा। वर्कलोड सबमिट करते समय समर्पित नामस्थान का उपयोग करना सुनिश्चित करें।

### स्थापना विधियाँ
KAI शेड्यूलर निम्नलिखित तरीकों से स्थापित किया जा सकता है:

- **प्रोडक्शन से (सिफारिश की जाती है)**
- **सोर्स से (स्वयं बिल्ड करें)**

#### प्रोडक्शन से इंस्टॉल करें
[releases](https://github.com/NVIDIA/KAI-Scheduler/releases) पेज में नवीनतम रिलीज़ वर्शन देखें।
निम्न कमांड को `<VERSION>` को वांछित रिलीज़ वर्शन से बदलकर चलाएँ:
```sh
helm upgrade -i kai-scheduler oci://ghcr.io/nvidia/kai-scheduler/kai-scheduler -n kai-scheduler --create-namespace --version <VERSION>
```
#### सोर्स से बिल्ड करें
[यहाँ](docs/developer/building-from-source.md) दिए गए निर्देशों का पालन करें

## त्वरित प्रारंभ
KAI शेड्यूलर के साथ वर्कलोड्स शेड्यूल करना प्रारंभ करने के लिए, कृपया [त्वरित प्रारंभ उदाहरण](docs/quickstart/README.md) देखें

## रोडमैप

### 2025 के लिए मुख्य प्राथमिकताओं का उच्च-स्तरीय अवलोकन
* कोडबेस को पुनर्गठित करना ताकि वेंडर न्यूट्रैलिटी बढ़ाई जा सके
* शेड्यूलिंग गेट्स का समर्थन करें https://github.com/NVIDIA/KAI-Scheduler/issues/63
* Kueue के साथ संभावित एकीकरण पर शोध करें https://github.com/NVIDIA/KAI-Scheduler/issues/68
* पॉड-समूह के टोपोलॉजी-अवेयर शेड्यूलिंग समर्थन को जोड़ें https://github.com/NVIDIA/KAI-Scheduler/issues/66
* प्रति वर्कलोड न्यूनतम रन समय का समर्थन करें
* प्रति वर्कलोड अधिकतम रन समय का समर्थन करें (विलंबित री-क्यू के साथ)
* डिफ़ॉल्ट KAI इंस्टॉल के रूप में अधिक PriorityClasses जोड़ें
* JobSet का समर्थन करें
* LWS (LeaderWorkerSet) का समर्थन करें
* पॉड और पॉड-समूह प्रीएम्प्शन के लिए मेट्रिक्स जोड़ें
* प्राथमिकता और प्रीएम्प्शन को अलग करें

### दीर्घकालिक लक्ष्य
* प्रति कतार समय क्षय का समर्थन करें
* हाइपर स्केल सुधार
* क्लस्टर डिफ्रैगमेंटेशन के लिए इन्फरेंस वर्कलोड्स के समेकन का समर्थन करें
* श्रृंखलाबद्ध कतारों के n-स्तरों का समर्थन करें
* इन्फरेंस वर्कलोड्स का ग्रेसफुल रोलआउट (नई रिवीजन अपडेट के लिए कतार के अस्थायी ओवर-कोटा का उपयोग)

## समुदाय, चर्चा, और समर्थन

हम आपसे सुनना पसंद करेंगे! जुड़ने के सर्वोत्तम तरीके यहां दिए गए हैं:

### स्लैक
पहले [CNCF स्लैक](https://communityinviter.com/apps/cloud-native/cncf) से जुड़ें और [#kai-scheduler](https://cloud-native.slack.com/archives/kai-scheduler) चैनल पर जाएँ।

### द्वि-साप्ताहिक सामुदायिक कॉल  
**कब:** हर दूसरे सोमवार को 17:00 CEST  
[अपने टाइम ज़ोन में बदलें](https://dateful.com/time-zone-converter?t=17&tz2=Germany) | [अपने कैलेंडर में जोड़ें](https://calendar.google.com/calendar/event?action=TEMPLATE&tmeid=N2Q2bjhoNXAzMGc0cWpnZTQ4OGtpdXFhanFfMjAyNTA2MDlUMTUwMDAwWiAxZjQ2OTZiOWVlM2JiMWE1ZWIzMTAwODBkNDZiZmMwMDZjNTUxYWFiZmU1YTM3ZGM2YTc0NTFhYmNhMmE1ODk0QGc&tmsrc=1f4696b9ee3bb1a5eb310080d46bfc006c551aabfe5a37dc6a7451abca2a5894%40group.calendar.google.com&scp=ALL)  | [मीटिंग नोट्स और एजेंडा](https://docs.google.com/document/d/13K7NGdPebOstlrsif1YLjGz1x-aJafMXeIgqbO7WghI/edit?usp=sharing)

### मेलिंग सूची  
द्वि-साप्ताहिक बैठकों के अपडेट प्राप्त करने के लिए [kai-scheduler मेलिंग सूची](https://groups.google.com/g/kai-scheduler) में शामिल हों।

### तकनीकी समस्याएँ और फ़ीचर अनुरोध  
कृपया बग्स, फ़ीचर सुझाव या तकनीकी सहायता के लिए [GitHub issue](https://github.com/NVIDIA/KAI-Scheduler/issues/new/choose) खोलें। यह हमें अनुरोधों को ट्रैक करने और प्रभावी रूप से प्रतिक्रिया करने में मदद करता है।

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---
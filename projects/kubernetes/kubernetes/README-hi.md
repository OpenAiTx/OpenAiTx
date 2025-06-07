# कुबेरनेट्स (K8s)

[![CII Best Practices](https://bestpractices.coreinfrastructure.org/projects/569/badge)](https://bestpractices.coreinfrastructure.org/projects/569) [![Go Report Card](https://goreportcard.com/badge/github.com/kubernetes/kubernetes)](https://goreportcard.com/report/github.com/kubernetes/kubernetes) ![GitHub release (latest SemVer)](https://img.shields.io/github/v/release/kubernetes/kubernetes?sort=semver)

<img src="https://github.com/kubernetes/kubernetes/raw/master/logo/logo.png" width="100">

----

कुबेरनेट्स, जिसे K8s के नाम से भी जाना जाता है, एक ओपन सोर्स सिस्टम है जो [कंटेनराइज्ड एप्लिकेशन्स] का प्रबंधन कई होस्ट्स पर करता है। यह एप्लिकेशनों की तैनाती, रखरखाव और स्केलिंग के लिए मूलभूत तंत्र प्रदान करता है।

कुबेरनेट्स गूगल द्वारा बड़े पैमाने पर प्रोडक्शन वर्कलोड्स को चलाने के डेढ़ दशक के अनुभव (एक सिस्टम जिसे [Borg] कहा जाता है) पर आधारित है, और इसमें समुदाय के सर्वोत्तम विचारों व प्रथाओं को जोड़ा गया है।

कुबेरनेट्स को क्लाउड नेटिव कंप्यूटिंग फाउंडेशन ([CNCF]) द्वारा होस्ट किया जाता है।
यदि आपकी कंपनी कंटेनर-पैकेज्ड, डायनामिकली शेड्यूल्ड और माइक्रोसर्विस-ओरिएंटेड तकनीकों के विकास को आकार देने में मदद करना चाहती है, तो CNCF में शामिल होने पर विचार करें।
कौन-कौन इसमें शामिल है और कुबेरनेट्स की क्या भूमिका है, इसके विवरण के लिए CNCF [घोषणा] पढ़ें।

----

## K8s का उपयोग शुरू करने के लिए

हमारे दस्तावेज़ [kubernetes.io] पर देखें।

[Scalable Microservices with Kubernetes] पर एक मुफ्त कोर्स लें।

अन्य एप्लिकेशनों में कुबेरनेट्स कोड को लाइब्रेरी के रूप में उपयोग करने के लिए, [प्रकाशित घटकों की सूची](https://git.k8s.io/kubernetes/staging/README.md) देखें।
`k8s.io/kubernetes` मॉड्यूल या `k8s.io/kubernetes/...` पैकेजों का लाइब्रेरी के रूप में उपयोग समर्थित नहीं है।

## K8s का विकास शुरू करने के लिए

[समुदाय रिपॉजिटरी] में स्रोत से कुबेरनेट्स बनाने, कोड और दस्तावेज़ में योगदान करने, किससे संपर्क करें आदि की सभी जानकारी होस्ट की गई है।

यदि आप तुरंत कुबेरनेट्स बनाना चाहते हैं, तो दो विकल्प हैं:

##### आपके पास एक कार्यशील [Go वातावरण] है।

```
git clone https://github.com/kubernetes/kubernetes
cd kubernetes
make
```

##### आपके पास एक कार्यशील [Docker वातावरण] है।

```
git clone https://github.com/kubernetes/kubernetes
cd kubernetes
make quick-release
```

पूरी जानकारी के लिए [डेवलपर दस्तावेज़] देखें।

## सहायता

यदि आपको सहायता की आवश्यकता है, तो [समस्या निवारण गाइड] से शुरू करें, और हमने जो प्रक्रिया बताई है उसे अपनाएं।

फिर भी, यदि आपके पास प्रश्न हैं, तो हमसे [किसी भी तरह][संचार] से संपर्क करें।

[घोषणा]: https://cncf.io/news/announcement/2015/07/new-cloud-native-computing-foundation-drive-alignment-among-container
[Borg]: https://research.google.com/pubs/pub43438.html?authuser=1
[CNCF]: https://www.cncf.io/about
[संचार]: https://git.k8s.io/community/communication
[समुदाय रिपॉजिटरी]: https://git.k8s.io/community
[कंटेनराइज्ड एप्लिकेशन्स]: https://kubernetes.io/docs/concepts/overview/what-is-kubernetes/
[डेवलपर दस्तावेज़]: https://git.k8s.io/community/contributors/devel#readme
[Docker वातावरण]: https://docs.docker.com/engine
[Go वातावरण]: https://go.dev/doc/install
[kubernetes.io]: https://kubernetes.io
[Scalable Microservices with Kubernetes]: https://www.udacity.com/course/scalable-microservices-with-kubernetes--ud615
[समस्या निवारण गाइड]: https://kubernetes.io/docs/tasks/debug/

## सामुदायिक बैठकें

[कैलेंडर](https://www.kubernetes.dev/resources/calendar/) में कुबेरनेट्स समुदाय की सभी बैठकों की सूची एक ही स्थान पर उपलब्ध है।

## उपयोक्ता

[उपयोगकर्ता केस स्टडीज](https://kubernetes.io/case-studies/) वेबसाइट में विभिन्न उद्योगों में उन संगठनों के वास्तविक उपयोग के मामले हैं जो कुबेरनेट्स को डिप्लॉय/माइग्रेट कर रहे हैं।

## प्रशासन

कुबेरनेट्स प्रोजेक्ट सिद्धांतों, मूल्यों, नीतियों और प्रक्रियाओं के ढांचे द्वारा शासित होता है ताकि हमारे समुदाय और संबंधितों को हमारे साझा लक्ष्यों की ओर मार्गदर्शन किया जा सके।

[कुबेरनेट्स समुदाय](https://github.com/kubernetes/community/blob/master/governance.md) यह जानने के लिए प्रारंभिक बिंदु है कि हम स्वयं को कैसे संगठित करते हैं।

[कुबेरनेट्स स्टीयरिंग समुदाय रिपो](https://github.com/kubernetes/steering) का उपयोग कुबेरनेट्स स्टीयरिंग समिति द्वारा किया जाता है, जो कुबेरनेट्स प्रोजेक्ट के प्रशासन की निगरानी करती है।

## रोडमैप

[कुबेरनेट्स एन्हांसमेंट्स रिपो](https://github.com/kubernetes/enhancements) कुबेरनेट्स रिलीज़, फीचर ट्रैकिंग और बैकलॉग्स के बारे में जानकारी प्रदान करता है।

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---
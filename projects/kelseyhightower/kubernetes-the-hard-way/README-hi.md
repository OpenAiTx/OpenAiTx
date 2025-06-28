# Kubernetes द हार्ड वे

यह ट्यूटोरियल आपको Kubernetes को कठिन तरीके से सेटअप करना सिखाता है। यह गाइड उन लोगों के लिए नहीं है जो Kubernetes क्लस्टर को लाने के लिए पूरी तरह से स्वचालित टूल की तलाश कर रहे हैं। Kubernetes द हार्ड वे को सीखने के लिए अनुकूलित किया गया है, जिसका अर्थ है प्रत्येक कार्य को खुद करके यह सुनिश्चित करना कि आप Kubernetes क्लस्टर को बूटस्ट्रैप करने के लिए आवश्यक प्रत्येक कार्य को समझते हैं।

> इस ट्यूटोरियल के परिणामों को प्रोडक्शन के लिए तैयार नहीं माना जाना चाहिए, और समुदाय से सीमित समर्थन मिल सकता है, लेकिन इससे आपको सीखने से नहीं रुकना चाहिए!

## कॉपीराइट

<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="Creative Commons License" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/88x31.png" /></a><br />यह कार्य <a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">क्रिएटिव कॉमन्स एट्रिब्यूशन-नॉनकमर्शियल-शेयरअलाइक 4.0 इंटरनेशनल लाइसेंस</a> के तहत लाइसेंस प्राप्त है।

## लक्षित पाठक

इस ट्यूटोरियल का लक्षित पाठक वह व्यक्ति है जो Kubernetes की मूल बातें और इसके मुख्य घटक कैसे मिलकर काम करते हैं, यह समझना चाहता है।

## क्लस्टर विवरण

Kubernetes द हार्ड वे आपको एक बेसिक Kubernetes क्लस्टर को बूटस्ट्रैप करने की प्रक्रिया से गुजारता है जिसमें सभी कंट्रोल प्लेन घटक एक ही नोड पर चलते हैं, और दो वर्कर नोड्स होते हैं, जो मुख्य अवधारणाओं को सीखने के लिए पर्याप्त है।

घटक संस्करण:

* [kubernetes](https://github.com/kubernetes/kubernetes) v1.32.x
* [containerd](https://github.com/containerd/containerd) v2.1.x
* [cni](https://github.com/containernetworking/cni) v1.6.x
* [etcd](https://github.com/etcd-io/etcd) v3.6.x

## लैब्स

इस ट्यूटोरियल के लिए चार (4) ARM64 या AMD64 आधारित वर्चुअल या भौतिक मशीनें आवश्यक हैं, जो एक ही नेटवर्क से जुड़ी हों।

* [पूर्वापेक्षाएँ](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/01-prerequisites.md)
* [जंपबॉक्स सेटअप करना](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/02-jumpbox.md)
* [कंप्यूट संसाधनों का प्रावधान](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/03-compute-resources.md)
* [CA का प्रावधान और TLS प्रमाणपत्र जनरेट करना](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/04-certificate-authority.md)
* [प्रमाणीकरण के लिए Kubernetes कॉन्फ़िगरेशन फाइलें जनरेट करना](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/05-kubernetes-configuration-files.md)
* [डेटा एन्क्रिप्शन कॉन्फ़िग और कुंजी जनरेट करना](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/06-data-encryption-keys.md)
* [etcd क्लस्टर बूटस्ट्रैप करना](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/07-bootstrapping-etcd.md)
* [Kubernetes कंट्रोल प्लेन बूटस्ट्रैप करना](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/08-bootstrapping-kubernetes-controllers.md)
* [Kubernetes वर्कर नोड्स बूटस्ट्रैप करना](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/09-bootstrapping-kubernetes-workers.md)
* [रिमोट एक्सेस के लिए kubectl कॉन्फ़िगर करना](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/10-configuring-kubectl.md)
* [पॉड नेटवर्क रूट्स का प्रावधान](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/11-pod-network-routes.md)
* [स्मोक टेस्ट](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/12-smoke-test.md)
* [साफ-सफाई](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/13-cleanup.md)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---
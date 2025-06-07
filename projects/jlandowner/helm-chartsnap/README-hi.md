# हेल्म-चार्टस्नैप 📸 
[![Go Reference](https://pkg.go.dev/badge/github.com/jlandowner/helm-chartsnap.svg)](https://pkg.go.dev/github.com/jlandowner/helm-chartsnap)
[![Go Report Card](https://goreportcard.com/badge/github.com/jlandowner/helm-chartsnap)](https://goreportcard.com/report/github.com/jlandowner/helm-chartsnap)
[![codecov](https://codecov.io/gh/jlandowner/helm-chartsnap/graph/badge.svg?token=8ARG53CRL7)](https://codecov.io/gh/jlandowner/helm-chartsnap)
[![Workflow Status](https://github.com/jlandowner/helm-chartsnap/actions/workflows/release.yaml/badge.svg)](https://github.com/jlandowner/helm-chartsnap/actions/workflows/release.yaml)
[![CI](https://github.com/jlandowner/helm-chartsnap/actions/workflows/ci.yaml/badge.svg)](https://github.com/jlandowner/helm-chartsnap/actions/workflows/ci.yaml)
[![GitHub Marketplace](https://img.shields.io/badge/Marketplace-Helm%20chartsnap%20action-blue.svg?colorA=24292e&colorB=0366d6&style=flat&longCache=true&logo=github)](https://github.com/marketplace/actions/helm-chartsnap-action)

हेल्म चार्ट्स के लिए स्नैपशॉट परीक्षण उपकरण।

केवल `values.yaml` फ़ाइल के भीतर न्यूनतम कॉन्फ़िगरेशन के साथ हेल्म चार्ट के लिए शक्तिशाली UI परीक्षण क्षमताएं लाएं।

![screenshot](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/docs/screenshot.png)

## अवलोकन
- [विशेषताएँ 🔑](#विशेषताएँ-)
- [स्नैपशॉट परीक्षण क्यों? 📸](#स्नैपशॉट-परीक्षण-क्यों-)
  - [प्रेरणा](#प्रेरणा)
- [इंस्टॉलेशन 🚀](#इंस्टॉलेशन-)
- [उपयोग](#उपयोग)
  - [डायनामिक मानों को संभालना 💪](#डायनामिक-मानों-को-संभालना-)
- [शोकेस और उपयोगकर्ता ✨](#शोकेस--उपयोगकर्ता-)

## विशेषताएँ 🔑

* **हेल्म डेवेलपर्स के लिए आसान और सहज स्नैपशॉट परीक्षण**
  
  - **कोई टूल-विशिष्ट TestSuite फ़ाइल प्रारूप नहीं**: कुछ टूल्स के विपरीत, जिन्हें अलग TestSuites कस्टम फ़ाइल प्रारूपों के साथ तैयार करना आवश्यक होता है, इस टूल में किसी अतिरिक्त फ़ाइल प्रारूप की आवश्यकता नहीं है। इसके बजाय, आप प्रत्येक परीक्षण केस के लिए मानक `values.yaml` फ़ाइल के विभिन्न संस्करण तैयार कर सकते हैं। इससे नया प्रारूप सीखने की आवश्यकता समाप्त होती है और परीक्षण सरल हो जाता है।

* **हेल्म चार्ट के लिए अनुकूलित**

  - **हेल्म फंक्शंस द्वारा उत्पन्न डायनामिक आउटपुट को संभालना**: आप प्रत्येक परीक्षण केस के लिए values.yaml फ़ाइल में अतिरिक्त गुण निर्दिष्ट कर सकते हैं ताकि परीक्षण व्यवहार को समायोजित किया जा सके। उदाहरण के लिए, आप [randAlphaNum](https://helm.sh/docs/chart_template_guide/function_list/) जैसे हेल्म फंक्शंस द्वारा डायनामिक रूप से उत्पन्न आउटपुट को नियंत्रित कर सकते हैं।

* **निरंतर स्नैपशॉट परीक्षण**

  - **[GitHub Action](https://github.com/jlandowner/helm-chartsnap-action) उपलब्ध है**: GitHub एक्शन जो आपके CI में स्थानीय या रिमोट हेल्म चार्ट्स के लिए निरंतर स्नैपशॉट परीक्षण करने में सक्षम बनाता है 🚀 -> [`helm-chart-action`](https://github.com/jlandowner/helm-chartsnap-action)

## स्नैपशॉट परीक्षण क्यों? 📸

मेरा मानना है कि स्नैपशॉट परीक्षण, जो वेब या UI परीक्षण में Jest जैसे टूल्स के साथ लोकप्रिय है, हेल्म चार्ट्स के परीक्षण का सबसे अच्छा तरीका है। स्नैपशॉट परीक्षण कई लाभ प्रदान करता है:

- **दृश्य तुलना:** स्नैपशॉट परीक्षण एक बेसलाइन आउटपुट बनाते हैं और फिर उसे बाद के परीक्षण परिणामों से तुलना करते हैं। इससे हेल्म चार्ट रेंडरिंग में परिवर्तनों और रिग्रेशन की आसान दृश्य जांच संभव होती है।

- **बेहतर अनुरक्षणीयता:** स्नैपशॉट परीक्षण परीक्षण सेटअप प्रक्रिया को सरल बनाता है, जिससे जटिल हेल्म चार्ट्स के साथ काम करते समय यह अधिक सुलभ और अनुरक्षणीय हो जाता है। हेल्म चार्ट के लिए इनपुट मानों का संयोजन होता है। हमें केवल अनुमानी इनपुट संयोजनों (=values.yaml) और उनके स्नैपशॉट्स को बनाए रखना होता है।

- **निरंतर परीक्षण:** अपने CI प्रक्रिया में हेल्म चार्ट का लगातार स्नैपशॉट लेकर, आप अपने पूरे चार्ट में परिवर्तनों को जल्दी देख सकते हैं और रिग्रेशन से बच सकते हैं।

ये लाभ सिर्फ आपके बनाए हेल्म चार्ट तक सीमित नहीं हैं, बल्कि वे थर्ड-पार्टी चार्ट्स पर भी लागू होते हैं जिन्हें आपने अपने Kubernetes में इंस्टॉल किया है। यदि आप क्लस्टर अपग्रेड करते हैं, तो *values* द्वारा निर्मित आउटपुट मैनिफेस्ट्स में किसी भी छोटे बदलाव को भी आप देख सकते हैं।

### प्रेरणा

ऐसे मौजूदा हेल्म परीक्षण उपकरण हैं जो स्नैपशॉट परीक्षण का समर्थन करते हैं।
- [helm-unittest](https://github.com/helm-unittest/helm-unittest), एक लोकप्रिय यूनिट परीक्षण टूल, इसमें [स्नैपशॉट परीक्षण](https://github.com/helm-unittest/helm-unittest#snapshot-testing) का विकल्प है।
- [terratest](https://terratest.gruntwork.io/), आपके इंफ्रास्ट्रक्चर कोड के लिए स्वचालित परीक्षण। इसमें Go कोड के रूप में परीक्षण लिखे जा सकते हैं और इसमें हेल्म के आउटपुट का परीक्षण करने की सुविधा है। [ब्लॉग पोस्ट](https://blog.gruntwork.io/automated-testing-for-kubernetes-and-helm-charts-using-terratest-a4ddc4e67344)

> आधिकारिक हेल्म परीक्षण टूल [`ct`](https://github.com/helm/chart-testing) यूनिट या स्नैपशॉट परीक्षण के लिए नहीं है, बल्कि लिंट और इंटीग्रेशन परीक्षण के लिए है

जबकि ये टूल्स हेल्म चार्ट्स के परीक्षण के लिए मूल्यवान हैं, स्नैपशॉट परीक्षण के लिए इनमें कुछ सीमाएँ हैं।

- आपको केवल स्नैपशॉट परीक्षण के लिए भी टूल्स के Test Suite फ़ाइलों को सीखना और तैयार करना पड़ता है।

- डिफ़ॉल्ट रूप से पूरे चार्ट का स्नैपशॉट नहीं लिया जाता, बल्कि हेल्म चार्ट के भीतर प्रति-फ़ाइल परीक्षण के लिए डिज़ाइन किया गया है।

- हेल्म फंक्शन के डायनामिक आउटपुट पर विचार नहीं किया जाता।

helm-unittest को प्रति-फ़ाइल परीक्षण के लिए डिज़ाइन किया गया है। इसका अर्थ है कि यह प्रत्येक फ़ाइल का स्वतंत्र रूप से मूल्यांकन करता है, और जब हेल्म चार्ट मान या शर्तें किसी पूरी फ़ाइल को शामिल या बाहर करने का कारण बनती हैं, तो परीक्षण महत्वपूर्ण परिदृश्यों को कवर करने में असमर्थ हो सकते हैं।

यहाँ helm-unittest में स्नैपशॉट परीक्षण के लिए एक परीक्षण विनिर्देश फ़ाइल का उदाहरण है।

> https://github.com/helm-unittest/helm-unittest#snapshot-testing
> 
> ```yaml
> templates:
>   - templates/deployment.yaml
> tests:
>   - it: pod spec should match snapshot
>     asserts:
>       - matchSnapshot:
>           path: spec.template.spec
>   # या आप पूरे मैनिफेस्ट का स्नैपशॉट ले सकते हैं
>   - it: manifest should match snapshot
>     asserts:
>       - matchSnapshot: {}
> ```

उदाहरण के लिए, मान लें कि हेल्म चार्ट तब एक `Certificate` संसाधन (`cert-manager` का) बनाएगा जब TLS और cert-manager दोनों सक्षम हों, लेकिन जब cert-manager सक्षम नहीं है, तो हेल्म फंक्शन [`genSelfSignedCert`](https://helm.sh/docs/chart_template_guide/function_list/#genselfsignedcert) का उपयोग करके सेल्फ-साइन TLS `Secret` संसाधन बनाएगा। आगे, TLS सक्षम है या नहीं, यह Ingress के TLS गुणों, Deployment के ऐप-विशिष्ट TLS विकल्पों आदि को प्रभावित करता है।

ऐसे मामलों में, helm-unittest पूरे चार्ट के व्यवहार का पर्याप्त परीक्षण नहीं कर पाएगा, क्योंकि इन कंडीशनल फ़ाइलों का आउटपुट खाली हो सकता है, जिससे परीक्षण अधूरे रह सकते हैं।

हालांकि, `helm-chartsnap` के साथ आपको केवल अपेक्षित पैटर्न के कुछ `values.yaml` फ़ाइलें तैयार करनी हैं 😊

## इंस्टॉलेशन 🚀

आप इसे हेल्म प्लगइन के रूप में इंस्टॉल कर सकते हैं।

```sh
helm plugin install https://github.com/jlandowner/helm-chartsnap
```

अन्य विकल्प:

- Go इंस्टॉल

  ```sh
  go install github.com/jlandowner/helm-chartsnap@latest
  ```

- [रिलीज बाइनरी डाउनलोड करें](https://github.com/jlandowner/helm-chartsnap/releases)

## उपयोग

त्वरित शुरुआत के लिए केवल अपना चार्ट पास करें।

```
helm chartsnap -c YOUR_CHART
```

`__snapshot__` डायरेक्टरी चार्ट डायरेक्टरी में बनाई जाती है और `default.snap` बनाया जाता है।

इसके अलावा, आप अपने चार्ट के Values फ़ाइलों के विभिन्न संस्करणों के रूप में परीक्षण केस बना सकते हैं।

यहाँ कमांड का पूरा उपयोग दिया गया है।

```sh
Usage:
  chartsnap -c CHART [flags]

Examples:

  # डिफ़ॉल्ट मानों के साथ स्नैपशॉट:
  chartsnap -c YOUR_CHART
  
  # स्नैपशॉट फ़ाइलें अपडेट करें:
  chartsnap -c YOUR_CHART -u

  # परीक्षण केस मानों के साथ स्नैपशॉट:
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILE
  
  # सभी परीक्षण मामलों का स्नैपशॉट:
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILES_DIRECTOY
  
  # 'helm template' कमांड के लिए अतिरिक्त आर्ग्स या फ्लैग सेट करें:
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILE -- --skip-tests

  # हेल्म रिपॉजिटरी में रिमोट चार्ट का स्नैपशॉट:
  chartsnap -c CHART_NAME -f YOUR_VALUES_FILE -- --repo HELM_REPO_URL

  # किसी विशेष संस्करण के लिए अपने वैल्यू फ़ाइल के साथ ingress-nginx (https://kubernetes.github.io/ingress-nginx/) हेल्म चार्ट का स्नैपशॉट:
  chartsnap -c ingress-nginx -f YOUR_VALUES_FILE -- --repo https://kubernetes.github.io/ingress-nginx --namespace kube-system --version 4.8.3

  # डिफ़ॉल्ट मानों के साथ cilium (https://cilium.io) हेल्म चार्ट का स्नैपशॉट लें और फ्लैग सेट करें:
  chartsnap -c cilium -- --repo https://helm.cilium.io --namespace kube-system --set hubble.relay.enabled=true --set hubble.ui.enabled=true

  # OCI रजिस्ट्री में चार्ट्स का स्नैपशॉट लें
  chartsnap -c oci://ghcr.io/nginxinc/charts/nginx-gateway-fabric -n nginx-gateway

  # बिना रंग के आउटपुट:
  NO_COLOR=1 chartsnap -c YOUR_CHART

Flags:
  -c, --chart string              चार्ट डायरेक्टरी का पथ। यह फ्लैग 'helm template RELEASE_NAME CHART --values VALUES' को 'CHART' के रूप में पास किया जाता है
      --config-file string        कॉन्फ़िग फ़ाइल का नाम या पथ, जो स्नैपशॉट व्यवहार को परिभाषित करता है जैसे डायनामिक फ़ील्ड्स (डिफ़ॉल्ट ".chartsnap.yaml")
  -N, --ctx-lines int             डिफ़ आउटपुट में दिखाने के लिए लाइनों की संख्या। 0 फुल आउटपुट के लिए (डिफ़ॉल्ट 3)
      --debug                     डिबग मोड
      --fail-helm-error           अगर 'helm template' कमांड फेल हो तो फेल करें
      --failfast                  जैसे ही कोई परीक्षण केस फेल हो, तुरंत फेल करें
  -h, --help                      chartsnap के लिए सहायता
  -n, --namespace string          नेमस्पेस। यह फ्लैग 'helm template RELEASE_NAME CHART --values VALUES --namespace NAMESPACE' को 'NAMESPACE' के रूप में पास किया जाता है (डिफ़ॉल्ट "default")
  -o, --output-dir string         डायरेक्टरी जिसमें __snapshot__ डायरेक्टरी बनाई जाती है। (डिफ़ॉल्ट: अगर --values सेट है तो values फ़ाइल डायरेक्टरी; अगर चार्ट स्थानीय है तो चार्ट डायरेक्टरी; अन्यथा वर्तमान डायरेक्टरी)
      --parallelism int           यदि परीक्षण वैल्यू फ़ाइल डायरेक्टरी के लिए कई स्नैपशॉट लिए जा रहे हैं तो परीक्षण समवर्तीता। डिफ़ॉल्ट असीमित (डिफ़ॉल्ट -1)
      --release-name string       रिलीज नाम। यह फ्लैग 'helm template RELEASE_NAME CHART --values VALUES' को 'RELEASE_NAME' के रूप में पास किया जाता है (डिफ़ॉल्ट "chartsnap")
      --snapshot-version string   एक विशिष्ट स्नैपशॉट फ़ॉर्मेट संस्करण का उपयोग करें। v1, v2, v3 समर्थित हैं। (डिफ़ॉल्ट: नवीनतम)
  -u, --update-snapshot           स्नैपशॉट अपडेट मोड
  -f, --values string             परीक्षण values फ़ाइल या डायरेक्टरी का पथ। यदि डायरेक्टरी सेट है, तो सभी परीक्षण फ़ाइलों का परीक्षण किया जाएगा। यदि खाली है, तो डिफ़ॉल्ट मानों का उपयोग किया जाएगा। यह फ्लैग 'helm template RELEASE_NAME CHART --values VALUES' को 'VALUES' के रूप में पास किया जाता है
  -v, --version                   chartsnap के लिए संस्करण

```

### डायनामिक मानों को संभालना 💪

हेल्म में "हेल्म फंक्शंस" नामक सुविधा है जो यादृच्छिक मान या सेल्फ-साइन सर्टिफिकेट्स उत्पन्न करती है जैसे [`randAlphaNum`](https://helm.sh/docs/chart_template_guide/function_list/#randalphanum-randalpha-randnumeric-and-randascii) और [`genCA`, `genPrivateKey`, `genSelfSignedCert`](https://helm.sh/docs/chart_template_guide/function_list/#cryptographic-and-security-functions)

इन फंक्शंस का उपयोग करते समय, हर बार हेल्म निष्पादित होने पर आउटपुट बदल जाएगा।
ऐसे मामलों के लिए, chartsnap में एक सुविधा है जो उन्हें एक निश्चित मान, `###DYNAMIC_FIELD###` से बदलकर मिसमैच स्नैपशॉट को रोकता है।

आप जेनरेटेड YAML में डायनामिक मानों के पाथ्स को [JSONPath](https://datatracker.ietf.org/doc/html/rfc6901) का उपयोग करके निर्दिष्ट कर सकते हैं।

```yaml:.chartsnap.yaml
dynamicFields:
  - apiVersion: v1
    kind: Secret
    name: cosmo-auth-env
    jsonPath:
      - /data/COOKIE_HASHKEY
      - /data/COOKIE_BLOCKKEY
      - /data/COOKIE_HASHKEY
      - /data/COOKIE_SESSION_NAME
    base64: true
```

> नोट:
> JSONPath में, / कैरेक्टर को एस्केप करने का वर्णन [RFC6901, section 3](https://datatracker.ietf.org/doc/html/rfc6901#section-3) में किया गया है
> ```
>    क्योंकि कैरेक्टर '~' (%x7E) और '/' (%x2F) का JSON Pointer में विशेष अर्थ है,
>    '~' को '~0' और '/' को '~1' के रूप में एन्कोड करना चाहिए जब ये कैरेक्टर्स रेफरेंस टोकन में हों।
> ```
>
> इसलिए यदि आप निम्नलिखित मैनिफेस्ट को संभालते हैं, तो आपको json path को `/metadata/annotaions/checksum~1values` के रूप में निर्दिष्ट करना होगा।
> 
> ```yaml
> metadata:
>   annotations:
>     checksum/values: RANDOM_VALUES
> ```

यदि आपके पास परीक्षण values फ़ाइल डायरेक्टरी है, तो उसमें `.chartsnap.yaml` फ़ाइल रखें। यह डायरेक्टरी के सभी स्नैपशॉट परीक्षणों में सामान्य व्यवहार है।

अधिक उदाहरणों के लिए देखें [example/app1](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/app1)।

वैकल्पिक रूप से, आप सीधे परीक्षण values फ़ाइल में `testSpec` प्रॉपर्टी के रूप में कॉन्फ़िग जोड़ सकते हैं।
इस मामले में, आपको `.chartsnap.yaml` तैयार करने की आवश्यकता नहीं है। यह रिमोट या थर्ड-पार्टी चार्ट्स के स्नैपशॉट लेने के लिए है जिसमें आपकी एकल values फ़ाइल है।

आपकी values फ़ाइल इस तरह हो सकती है:

```yaml
# अपनी values में यह प्रॉपर्टी जोड़ें।
testSpec:
  dynamicFields:
    - apiVersion: v1
      kind: Secret
      name: cilium-ca
      jsonPath:
        - /data/ca.crt
        - /data/ca.key
      base64: true
    - apiVersion: v1
      kind: Secret
      name: hubble-server-certs
      jsonPath:
        - /data/ca.crt
        - /data/tls.crt
        - /data/tls.key
      base64: true
    - apiVersion: v1
      kind: Secret
      name: hubble-relay-client-certs
      jsonPath:
        - /data/ca.crt
        - /data/tls.crt
        - /data/tls.key
      base64: true

# अन्य मान आपके चार्ट के मान हो सकते हैं।
# ...
```

अधिक उदाहरणों के लिए देखें [example/remote](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/remote)।

## शोकेस और उपयोगकर्ता ✨

| उपयोगकर्ता / प्रोजेक्ट | विवरण | URL |
|:---|:---|:---|
| उदाहरण | `helm create` कमांड द्वारा जेनरेट किया गया उदाहरण चार्ट | [`example/app1`](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/app1) |
| उदाहरण | रिमोट हेल्म रिपॉजिटरी में चार्ट्स का स्नैपशॉट लेने का उदाहरण | [`example/remote`](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/remote) |
| [helm-chartsnap-action](https://github.com/jlandowner/helm-chartsnap-action) | CI में हेल्म चार्टस्नैप का उपयोग करने के लिए GitHub एक्शन | https://github.com/jlandowner/helm-chartsnap-action |
| [cosmo-workspace](https://github.com/cosmo-workspace/cosmo) | Kubernetes पर ओपन सोर्स WebIDE और DevEnvironment प्लेटफ़ॉर्म | https://github.com/cosmo-workspace/cosmo/tree/main/charts/cosmo/test |
| [Kong](https://github.com/Kong/kong) | 🦍 क्लाउड-नेटिव API गेटवे और AI गेटवे | https://github.com/Kong/charts |

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---
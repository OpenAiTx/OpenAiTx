# 🎫 BiliTickerStorm

## ⚙️ सेवा विवरण

| सेवा नाम                | विवरण                    | टिप्पणी      |
| ------------------- | --------------------- | --------- |
| `ticket-master`     | मुख्य नियंत्रक सेवा, कार्यों का निर्धारण करता है | एकल उदाहरण परिनियोजन |
| `ticket-worker`     | टिकट बुकिंग वर्कर, क्षैतिज विस्तार योग्य     | मल्टी-इंस्टेंस समर्थित |
| `gt-python`         | ग्राफिकल कैप्चा प्रोसेसिंग सेवा            | एकल उदाहरण परिनियोजन |

---

## 🚀 त्वरित परिनियोजन चरण

> क्लस्टर सेटअप के लिए [क्लस्टर सेटअप गाइड](https://raw.githubusercontent.com/mikumifa/biliTickerStorm/main/docs/集群搭建参考.md) देखें।

<details> <summary><strong>📦 रिमोट रिपॉजिटरी इंस्टॉलेशन (सिफारिश)</strong></summary>

```bash
helm repo add bili-ticker-storm https://mikumifa.github.io/biliTickerStorm/
helm repo update
```
### 2. Chart इंस्टॉल करें

```bash
helm install bili-ticker-storm bili-ticker-storm/bili-ticker-storm \
  --set ticketMaster.hostDataPath=/your/host/data/path \
  --set ticketWorker.pushplusToken="your_token" \
  --set ticketWorker.ticketInterval="300" \
  --set ticketWorker.ticketTimeStart="2025-05-20T13:14"
  
```

> - `hostDataPath` टिकट बुकिंग कॉन्फ़िगरेशन फ़ाइल डायरेक्टरी है, जिसे `ticket-master` कंटेनर को माउंट किया जाता है। टिकट बुकिंग कॉन्फ़िगरेशन फ़ाइल जनरेट करने के लिए https://github.com/mikumifa/biliTickerBuy का उपयोग करें।
> - `ticketWorker.pushplusToken` pushplus पुश कॉन्फ़िगरेशन है, सेट करने के बाद आप टिकट बुकिंग परिणाम की नोटिफिकेशन प्राप्त कर सकते हैं।
> - `ticketWorker.ticketInterval` टिकट बुकिंग का अंतराल (सेकंड में) है, डिफ़ॉल्ट 300 मिलीसेकंड है।
> - `ticketWorker.ticketTimeStart` शेड्यूल शुरू होने का समय है, फॉर्मेट `2025-05-20T13:14` है, यदि खाली छोड़ा तो कंटेनर स्टार्ट होते ही टिकट बुकिंग शुरू हो जाएगी।

### 3. Chart अपग्रेड करें

```bash
helm upgrade bili-ticker-storm bili-ticker-storm/bili-ticker-storm --reuse-values \
  --set ticketWorker.ticketInterval="600"
```
</details> 
<details> <summary><strong>📦 स्थानीय Chart इंस्टॉल करें</strong></summary>


### 1. Chart इंस्टॉल करना

```bash
# रिपोजिटरी क्लोन करें
git clone https://github.com/mikumifa/biliTickerStorm
# स्थानीय Chart पैकेज का उपयोग करें
helm install bili-ticker-storm ./helm \
  --set ticketMaster.hostDataPath=/your/host/data/path \
  --set ticketWorker.pushplusToken="your_token" \
  --set ticketWorker.ticketInterval="300" \
  --set ticketWorker.ticketTimeStart="2025-05-20T13:14"
```
### 2. Chart अपग्रेड करना

```bash
helm upgrade bili-ticker-storm ./helm --reuse-values
```
</details>
<details>
<summary><strong>📌 सामान्य कमांड</strong></summary>

### ⏹ अनइंस्टॉल
```bash
helm uninstall bili-ticker-storm
```
</details>


## 📩 अस्वीकरण

यह परियोजना MIT License लाइसेंस समझौते का पालन करती है, केवल व्यक्तिगत अध्ययन और अनुसंधान के लिए है। कृपया इस परियोजना का उपयोग किसी भी व्यावसायिक लाभ के लिए न करें, और न ही इसे किसी भी प्रकार के ऑटो-ग्रैब, अवैध गतिविधियों या संबंधित प्लेटफ़ॉर्म नियमों का उल्लंघन करने वाले उद्देश्यों के लिए उपयोग करें। इससे उत्पन्न होने वाले सभी परिणामों की जिम्मेदारी उपयोगकर्ता की स्वयं की होगी, इसका लेखक से कोई संबंध नहीं है।

यदि आप इस परियोजना को फोर्क या उपयोग करते हैं, तो कृपया संबंधित कानूनों, विनियमों और लक्षित प्लेटफ़ॉर्म नियमों का पालन अवश्य करें।

## 💡 एक्सेस फ़्रीक्वेंसी और समांतर नियंत्रण के बारे में
इस परियोजना को डिज़ाइन करते समय "गैर-आक्रामक" सिद्धांत का कड़ाई से पालन किया गया है, ताकि लक्षित सर्वर (जैसे Bilibili) पर कोई भी हस्तक्षेप न हो।

सभी नेटवर्क अनुरोधों का समय अंतराल उपयोगकर्ता द्वारा स्वयं कॉन्फ़िगर किया जाता है, डिफ़ॉल्ट मान सामान्य उपयोगकर्ता के मैन्युअल ऑपरेशन की गति का अनुकरण करते हैं। प्रोग्राम डिफ़ॉल्ट रूप से सिंगल थ्रेड में चलता है, कोई समांतर कार्य नहीं होते। अनुरोध विफल होने की स्थिति में, प्रोग्राम सीमित बार पुनः प्रयास करता है और हर प्रयास के बीच उपयुक्त विलंब जोड़ता है, ताकि उच्च आवृत्ति की हिटिंग से बचा जा सके। परियोजना पूरी तरह से प्लेटफ़ॉर्म के सार्वजनिक इंटरफ़ेस और वेबपेज संरचना पर निर्भर करती है, इसमें रिस्क कंट्रोल से बचाव, API हाईजैकिंग जैसी कोई भी विध्वंसक तकनीक शामिल नहीं है।
## 🛡️ प्लेटफ़ॉर्म सम्मान घोषणा

इस प्रोग्राम को डिज़ाइन करते समय अनुरोध आवृत्ति को यथासंभव नियंत्रित किया गया है, ताकि Bilibili सर्वर पर किसी भी प्रकार का स्पष्ट लोड या प्रभाव न पड़े। यह प्रोजेक्ट केवल अध्ययन उद्देश्य के लिए है, इसमें बड़े पैमाने या उच्च समवर्ती क्षमता नहीं है, और न ही किसी प्रकार की दुर्भावनापूर्ण गतिविधि या सेवा में हस्तक्षेप करने का इरादा है।

यदि इस प्रोजेक्ट में Bilibili कंपनी के वैध अधिकारों का उल्लंघन करने वाली कोई सामग्री मौजूद है, तो कृपया ईमेल [1055069518@qq.com](https://raw.githubusercontent.com/mikumifa/biliTickerStorm/main/mailto:1055069518@qq.com) के माध्यम से मुझसे संपर्क करें। मैं संबंधित सामग्री को तुरंत हटा दूँगा और इस रिपॉजिटरी को डिलीट कर दूँगा। इससे हुई असुविधा के लिए मैं गहरा खेद प्रकट करता हूँ, आपकी समझ और सहनशीलता के लिए धन्यवाद।

## 📄 लाइसेंस

[MIT License](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---
# KestrelApp
Kestrel आधारित नेटवर्क प्रोग्रामिंग एप्लिकेशन उदाहरण

### 1 परियोजना उद्देश्य
1. यह समझना कि नेटवर्क प्रोग्रामिंग अब Socket से शुरू करने की आवश्यकता नहीं है
2. यह समझना कि नेटवर्क प्रोग्रामिंग के लिए अब किसी थर्ड पार्टी फ्रेमवर्क (Dotnetty सहित) की आवश्यकता नहीं है
3. `telnet` over `websocket` over `tls` over `xxxप्राइवेट एन्क्रिप्शन` over `tcp` के nested नेटवर्क प्रोग्रामिंग को समझना
4. KestrelFramework के आधार पर नेटवर्क एप्लिकेशन विकसित करने में सक्षम होना

### 2 दस्तावेज़ सामग्री
**आंतरिक दस्तावेज़**：[docs](docs)

**बाहरी दस्तावेज़**
* [Pipelines](https://learn.microsoft.com/zh-cn/dotnet/standard/io/pipelines)
* [Buffers](https://learn.microsoft.com/zh-cn/dotnet/standard/io/buffers)

### 3 KestrelFramework
kestrel नेटवर्क प्रोग्रामिंग के लिए कुछ आवश्यक मूलभूत पुस्तकालय
1. Kestrel मिडलवेयर इंटरफ़ेस और मिडलवेयर पंजीकरण
2. System.Buffers: बफर संचालन क्लास
3. System.IO: स्ट्रीम संचालन क्लास
4. System.IO.Pipelines: डुप्लेक्स पाइपलाइन संचालन क्लास
5. Middleware: kestrel के कुछ मिडलवेयर

### 4 KestrelApp
Kestrel एप्लिकेशन प्रोग्राम, जिसमें शामिल हैं
1. लिसनिंग EndPoint का कॉन्फ़िगरेशन
2. EndPoint द्वारा उपयोग किए जाने वाले प्रोटोकॉल का कॉन्फ़िगरेशन

### 5 KestrelApp.Middleware
KestrelApp का मिडलवेयर क्लास लाइब्रेरी
#### 5.1 Echo
सरल Echo एप्लिकेशन प्रोटोकॉल का उदाहरण

#### 5.2 FlowAnalyze
ट्रांसपोर्ट लेयर ट्रैफिक सांख्यिकी मिडलवेयर का उदाहरण

#### 5.3 FlowXor
ट्रांसपोर्ट लेयर ट्रैफिक XOR प्रोसेसिंग मिडलवेयर का उदाहरण

#### 5.4 HttpProxy
http प्रॉक्सी एप्लिकेशन प्रोटोकॉल का उदाहरण

#### 5.5 Telnet
सरल Telnet एप्लिकेशन प्रोटोकॉल का उदाहरण

#### 5.6 TelnetProxy
ट्रैफिक को telnet सर्वर पर फॉरवर्ड करने का उदाहरण

#### 5.6 Redis
redis प्रोटोकॉल सर्वर, यह दिखाने के लिए कि एप्लिकेशन मिडलवेयर का उपयोग कैसे करें

### ओपन सोर्स आपके साथ और भी शानदार
![打赏](https://raw.githubusercontent.com/xljiulang/KestrelApp/master/reward.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-21

---
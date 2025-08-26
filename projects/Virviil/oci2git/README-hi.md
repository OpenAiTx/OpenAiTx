
<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# OCI2Git

एक Rust एप्लिकेशन जो कंटेनर इमेज (Docker, आदि) को Git रिपॉजिटरी में परिवर्तित करता है। प्रत्येक कंटेनर लेयर को एक Git कमिट के रूप में दर्शाया जाता है, जिससे मूल इमेज का इतिहास और संरचना सुरक्षित रहती है।

![OCI2Git द्वारा nginx इमेज को कन्वर्ट करने का डेमो](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/nginx.gif)

## विशेषताएँ

- Docker इमेज़ का विश्लेषण करें और लेयर जानकारी निकालें
- एक Git रिपॉजिटरी बनाएँ जहाँ प्रत्येक इमेज लेयर को एक कमिट के रूप में दर्शाया गया हो
- खाली लेयर (ENV, WORKDIR, आदि) के लिए खाली कमिट्स का समर्थन
- पूर्ण मेटाडेटा को Markdown प्रारूप में निकालना
- विभिन्न कंटेनर इंजनों के समर्थन के लिए विस्तारशील आर्किटेक्चर

## उपयोग के मामले

### लेयर डिफिंग
जब कंटेनर समस्याओं का समाधान किया जा रहा हो, आप Git की शक्तिशाली डिफिंग क्षमताओं का उपयोग करके किसी भी दो लेयरों के बीच वास्तव में क्या बदला, इसकी पहचान कर सकते हैं। कमिट्स के बीच `git diff` चलाकर, इंजीनियर सटीक रूप से देख सकते हैं कि कौन सी फाइलें जोड़ी गईं, संशोधित हुईं या हटाई गईं, जिससे प्रत्येक Dockerfile निर्देश के प्रभाव को समझना और समस्याग्रस्त बदलावों का पता लगाना कहीं आसान हो जाता है।
![लेयर डिफ के लिए उदाहरण](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/layer-diff.png)

### ओरिजिन ट्रैकिंग
`git blame` का उपयोग करके, डेवलपर्स जल्दी से पता लगा सकते हैं कि कौन सी लेयर ने किसी विशेष फाइल या कोड की लाइन को पेश किया। यह विशेष रूप से तब मूल्यवान होता है जब कॉन्फ़िगरेशन फाइल्स या डिपेंडेंसीज़ में समस्याओं का निदान करना हो। प्रत्येक लेयर को मैन्युअली जांचने की बजाय, आप तुरंत किसी भी फाइल की उत्पत्ति को उसके स्रोत लेयर और संबंधित Dockerfile निर्देश तक ट्रेस कर सकते हैं।

### फाइल लाइफसायकल ट्रैकिंग
OCI2Git आपको किसी विशेष फाइल की यात्रा को पूरे कंटेनर इमेज के इतिहास में फॉलो करने में सक्षम बनाता है। आप देख सकते हैं कि कोई फाइल कब बनाई गई थी, कैसे वह लेयरों में संशोधित हुई, और कब/अगर वह अंततः हटा दी गई। यह व्यापक दृश्य फाइल के विकास को समझने में मदद करता है, बिना दर्जनों लेयरों में बदलावों को मैन्युअली ट्रैक किए।

अपनी कंटेनर इमेज में किसी फाइल का इतिहास ट्रैक करने के लिए — जिसमें कब पहली बार वह दिखाई दी, बदली गई, या हटाई गई — आप रूपांतरण के बाद ये Git कमांड्स इस्तेमाल कर सकते हैं:

```bash
# Full history of a file (including renames)
git log --follow -- /rootfs/my/file/path

# First appearance (i.e. creation) - see which layer introduced the file
git log --diff-filter=A -- /rootfs/my/file/path

# All changes made to the file (with diffs)
git log -p --follow -- /rootfs/my/file/path

# When the file was deleted
git log --diff-filter=D -- /rootfs/my/file/path

# Show short commit info (concise layer history)
git log --follow --oneline -- /rootfs/my/file/path
```
ये कमांड्स किसी भी फाइल के पूरे इतिहास को कंटेनर लेयरों में ट्रेस करना आसान बनाती हैं, बिना मैन्युअली लेयर टारबॉल्स को निकालने और तुलना करने की जटिलता के।

### मल्टी-लेयर विश्लेषण
कभी-कभी सबसे महत्वपूर्ण तुलना तब मिलती है जब आप कई गैर-क्रमागत लेयरों में हुए बदलावों की जांच करते हैं। OCI2Git के साथ, आप Git के तुलना टूल का उपयोग करके देख सकते हैं कि विभिन्न बिल्ड स्टेजों में घटक कैसे विकसित हुए, जिससे ऐसे पैटर्न पहचाने जा सकते हैं जो केवल आस-पास की लेयरों को देखने पर दिखाई नहीं देते।

### लेयर अन्वेषण
`git checkout` का उपयोग करके किसी भी विशिष्ट कमिट पर जाकर आप कंटेनर फाइल सिस्टम को ठीक वैसे ही देख सकते हैं जैसा वह उस लेयर पर था। इससे डेवलपर्स किसी भी बिंदु पर इमेज के निर्माण प्रक्रिया में फाइलों और डाइरेक्टरीज़ की सही स्थिति का निरीक्षण कर सकते हैं, जो डिबगिंग या कंटेनर व्यवहार की जांच करते समय अमूल्य संदर्भ प्रदान करता है।
![पिछले कमिट पर चेकआउट करें](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/checkout.png)

### मल्टी-इमेज विश्लेषण

जब आप कई कंटेनर इमेज के साथ काम करते हैं जिनका साझा पूर्वज होता है, तो OCI2Git केवल तब ब्रांच बनाता है जब इमेज वास्तव में अलग हो जाती हैं। इससे आप एक ही रिपॉजिटरी में कई संबंधित इमेज का विश्लेषण कर सकते हैं, जबकि उनके साझा इतिहास को बनाए रख सकते हैं।


```bash
# Convert first image to create the base repository
oci2git postgres:16.9-alpine3.21 -o alp

# Convert second image to the same output folder
oci2git nginx:1.28.0-alpine-slim -o alp
```
OCI2Git स्वचालित रूप से छवियों के बीच साझा लेयर का पता लगाता है और एक शाखित संरचना बनाता है जो उनके सामान्य आधार को दर्शाती है। Git इतिहास में दिखाई देगा:
- एक सामान्य ट्रंक जिसमें सभी साझा लेयर शामिल हैं
- अलग-अलग शाखाएं जो केवल तब विभाजित होती हैं जब छवियों में वास्तव में अंतर होता है
- स्पष्ट दृश्यावलोकन कि छवियां कहाँ सामान्य वंशावली साझा करती हैं बनाम कहाँ वे अद्वितीय हो जाती हैं
- स्मार्ट डुप्लिकेट हैंडलिंग: यदि एक ही छवि को दो बार प्रोसेस किया जाता है, तो एल्गोरिथ्म अंतिम मेटाडेटा कमिट से पहले इसका पता लगा लेता है और डुप्लिकेट शाखा बनाने को छोड़ देता है

यह दृष्टिकोण विशेष रूप से इन कार्यों के लिए उपयोगी है:
- **इमेज फैमिली विश्लेषण**: यह समझना कि छवि के विभिन्न संस्करण (विभिन्न संस्करण, आर्किटेक्चर, या कॉन्फ़िगरेशन) एक-दूसरे से कैसे संबंधित हैं
- **बेस इमेज प्रभाव**: यह देखना कि बेस इमेज में किए गए बदलाव कई व्युत्पन्न छवियों को कैसे प्रभावित करते हैं
- **अनुकूलन के अवसर**: साझा घटकों की पहचान करना जिन्हें छवि संस्करणों में बेहतर तरीके से उपयोग किया जा सकता है

![साझा बेस और विभाजित शाखाओं के साथ मल्टी-इमेज रिपॉजिटरी संरचना](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/multiimage.png)

### अतिरिक्त उपयोग के मामले

- **सुरक्षा ऑडिटिंग**: बिल्कुल यह पहचानना कि कमजोर पैकेज या कॉन्फ़िगरेशन कब पेश किए गए थे और उन्हें विशिष्ट बिल्ड निर्देशों तक ट्रेस करना।
- **इमेज ऑप्टिमाइजेशन**: लेयर संरचना का विश्लेषण करके अनावश्यक कार्य या बड़े फ़ाइलें ढूंढना, जिन्हें समेकित किया जा सकता है, जिससे इमेज का आकार कम करने में मदद मिले।
- **डिपेंडेंसी प्रबंधन**: छवि इतिहास में डिपेंडेंसियों के जोड़े जाने, अपग्रेड या हटाए जाने को मॉनिटर करना।
- **बिल्ड प्रक्रिया सुधार**: बेहतर कैशिंग और छोटे इमेज आकार के लिए Dockerfile निर्देशों को अनुकूलित करने के लिए लेयर संरचना की जांच करना।
- **क्रॉस-इमेज तुलना**: कई संबंधित छवियों को Git रिपॉजिटरी में बदलना और उनके अंतर व समानताओं का विश्लेषण करने के लिए Git के तुलना उपकरणों का उपयोग करना।

## इंस्टॉलेशन

### स्रोत से


```bash
# Clone the repository
git clone https://github.com/virviil/oci2git.git
cd oci2git

# Install locally
cargo install --path .
```

### क्रेट्स.आईओ से

```bash
cargo install oci2git
```

## उपयोग

```bash
oci2git [OPTIONS] <IMAGE>
```

आर्ग्युमेंट्स:
  `<IMAGE>`  कनवर्ट करने के लिए इमेज नाम (जैसे, 'ubuntu:latest') या टार इंजन का उपयोग करते समय टारबॉल का पथ

विकल्प:
  `-o, --output <o>`  Git रिपोजिटरी के लिए आउटपुट डायरेक्टरी [डिफ़ॉल्ट: ./container_repo]
  `-e, --engine <ENGINE>`  उपयोग करने के लिए कंटेनर इंजन (docker, nerdctl, tar) [डिफ़ॉल्ट: docker]
  `-h, --help`            मदद जानकारी प्रिंट करें
  `-V, --version`         संस्करण जानकारी प्रिंट करें

पर्यावरण वेरिएबल्स:
  `TMPDIR`  मध्यवर्ती डेटा प्रोसेसिंग के लिए डिफ़ॉल्ट स्थान बदलने हेतु इस पर्यावरण वेरिएबल को सेट करें। यह प्लेटफॉर्म-निर्भर है (जैसे, यूनिक्स/macOS पर `TMPDIR`, विंडोज़ पर `TEMP` या `TMP`)।

## उदाहरण

डॉकर इंजन (डिफ़ॉल्ट) का उपयोग करते हुए:
```bash
oci2git -o ./ubuntu-repo ubuntu:latest
```

पहले से डाउनलोड की गई इमेज टारबॉल का उपयोग करना:
```bash
oci2git -e tar -o ./ubuntu-repo /path/to/ubuntu-latest.tar
```
टार इंजन एक वैध OCI फॉर्मेट टारबॉल की अपेक्षा करता है, जिसे आमतौर पर `docker save` से बनाया जाता है:

```bash
# Create a tarball from a local Docker image
docker save -o ubuntu-latest.tar ubuntu:latest

# Convert the tarball to a Git repository
oci2git -e tar -o ./ubuntu-repo ubuntu-latest.tar
```
यह `./ubuntu-repo` में एक Git रिपॉजिटरी बनाएगा जिसमें शामिल हैं:
- `Image.md` - इमेज के बारे में पूरी मेटाडेटा Markdown प्रारूप में
- `rootfs/` - कंटेनर से फाइल सिस्टम की सामग्री

Git इतिहास कंटेनर की लेयर हिस्ट्री को दर्शाता है:
- पहला कमिट केवल `Image.md` फाइल को पूर्ण मेटाडेटा के साथ शामिल करता है
- प्रत्येक अगला कमिट मूल इमेज की एक लेयर को दर्शाता है
- कमिट में Dockerfile कमांड कमिट मैसेज के रूप में शामिल होती है

## रिपॉजिटरी संरचना


```
repository/
├── .git/
├── Image.md     # Complete image metadata
└── rootfs/      # Filesystem content from the container
```
  
## आवश्यकताएँ

- Rust 2021 संस्करण
- Docker CLI (Docker इंजन समर्थन के लिए)
- Git

## लाइसेंस

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-26

---
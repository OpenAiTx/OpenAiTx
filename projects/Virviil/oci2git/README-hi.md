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
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
<img src="https://raw.githubusercontent.com/Virviil/oci2git/main/assets/logo.png" width="140px" />

# OCI2Git

[![प्रलेखन](https://docs.rs/oci2git/badge.svg)][documentation]
[![Crates.io](https://img.shields.io/crates/v/oci2git.svg)](https://crates.io/crates/oci2git)
[![लाइसेंस](https://img.shields.io/crates/l/oci2git.svg)](https://github.com/Virviil/oci2git/blob/master/LICENSE)

[![डाउनलोड](https://img.shields.io/crates/d/oci2git.svg)](https://crates.io/crates/oci2git)

[//]: # (भविष्य के test.yaml के लिए मॉक)
[//]: # ([![Test Status]&#40;https://img.shields.io/github/actions/workflow/status/Virviil/oci2git/rust.yml?branch=master&event=push&label=Test&#41;]&#40;https://github.com/Virviil/oci2git/actions&#41;)

<div align="left"> </div>  
</div>

एक Rust एप्लिकेशन जो कंटेनर इमेजेज़ (Docker, आदि) को Git रिपॉजिटरीज़ में बदलता है, और YAML में फाइल सिस्टम बिल ऑफ मटेरियल्स (fsbom) उत्पन्न करता है। प्रत्येक कंटेनर लेयर को एक Git कमिट के रूप में दर्शाया जाता है, जिससे मूल इमेज का इतिहास और संरचना बनी रहती है।

![OCI2Git द्वारा nginx इमेज को बदलने का डेमो](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/nginx.gif)

## विशेषताएँ

- Docker इमेजेज़ का विश्लेषण करें और लेयर जानकारी निकालें
- एक Git रिपॉजिटरी बनाएं जहाँ प्रत्येक इमेज लेयर को एक कमिट के रूप में दर्शाया गया है
- प्रत्येक लेयर की फाइल लिस्टिंग सहित YAML फाइल सिस्टम बिल ऑफ मटेरियल्स (fsbom) उत्पन्न करें
- खाली लेयर्स (ENV, WORKDIR, आदि) को खाली कमिट्स के रूप में समर्थन दें
- मार्कडाउन प्रारूप में पूर्ण मेटाडेटा निष्कर्षण
- विभिन्न कंटेनर इंजनों के लिए समर्थन हेतु विस्तारशील आर्किटेक्चर

## उपयोग के मामले

### लेयर डिफिंग
जब कंटेनर समस्याओं का समाधान किया जा रहा हो, तो आप Git की शक्तिशाली डिफिंग क्षमताओं का उपयोग करके यह सटीक रूप से पता लगा सकते हैं कि किन दो लेयरों के बीच क्या बदला। `git diff` कमिट्स के बीच चलाकर, इंजीनियर देख सकते हैं कि कौन सी फाइलें जोड़ी गईं, संशोधित हुईं या हटाई गईं, जिससे प्रत्येक Dockerfile निर्देश का प्रभाव समझना और समस्याग्रस्त बदलाव ढूँढ़ना बहुत आसान हो जाता है।
![लेयर डिफ का उदाहरण](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/layer-diff.png)

### उत्पत्ति ट्रैकिंग
`git blame` का उपयोग करके, डेवलपर्स जल्दी से पता लगा सकते हैं कि कौन सी लेयर ने किसी विशिष्ट फाइल या कोड की पंक्ति को जोड़ा। यह विशेष रूप से तब मूल्यवान होता है जब कॉन्फ़िगरेशन फाइलों या डिपेंडेंसीज़ की समस्याओं का निदान किया जाता है। प्रत्येक लेयर को मैन्युअली निरीक्षण करने के बजाय, आप तुरंत किसी भी फाइल की उत्पत्ति उसके स्रोत लेयर और संबंधित Dockerfile निर्देश तक ट्रेस कर सकते हैं।

### फाइल लाइफसाइकल ट्रैकिंग
OCI2Git आपको किसी विशिष्ट फाइल की यात्रा को पूरे कंटेनर इमेज के इतिहास में फॉलो करने में सक्षम बनाता है। आप देख सकते हैं कि कोई फाइल पहली बार कब बनाई गई, विभिन्न लेयरों में उसमें कैसे बदलाव हुए, और यदि/कब वह अंततः हटा दी गई। यह व्यापक दृश्य फाइल के विकास को समझने में मदद करता है, बिना दर्जनों लेयरों के परिवर्तनों को मैन्युअली ट्रैक किए।

अपने कंटेनर इमेज में किसी फाइल का इतिहास ट्रैक करने के लिए — जिसमें यह भी शामिल है कि वह पहली बार कब आई, कब बदली गई या हटाई गई — आप रूपांतरण के बाद ये Git कमांड्स उपयोग कर सकते हैं:

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
OCI2Git स्वचालित रूप से छवियों के बीच साझा परतों का पता लगाता है और एक शाखा संरचना बनाता है जो उनके सामान्य आधार को दर्शाती है। Git इतिहास में दिखाई देगा:
- एक सामान्य ट्रंक जिसमें सभी साझा परतें शामिल हैं
- अलग-अलग शाखाएँ जो केवल तब अलग होती हैं जब छवियाँ वास्तव में भिन्न होती हैं
- यह स्पष्ट दृश्य कि छवियाँ कहाँ सामान्य पूर्वज साझा करती हैं और कहाँ वे अद्वितीय बन जाती हैं
- स्मार्ट डुप्लिकेट प्रबंधन: यदि बिल्कुल वही छवि दो बार प्रोसेस की जाती है, तो एल्गोरिद्म अंतिम मेटाडेटा कमिट से पहले इसे पहचान लेता है और डुप्लिकेट शाखा बनाना छोड़ देता है

यह दृष्टिकोण विशेष रूप से इन के लिए मूल्यवान है:
- **इमेज परिवार विश्लेषण**: यह समझना कि किसी छवि के विभिन्न रूप (विभिन्न संस्करण, आर्किटेक्चर या कॉन्फ़िगरेशन) एक-दूसरे से कैसे संबंधित हैं
- **बेस इमेज प्रभाव**: ठीक-ठीक देखना कि बेस इमेज में बदलाव कई व्युत्पन्न छवियों को कैसे प्रभावित करते हैं
- **अनुकूलन के अवसर**: साझा घटकों की पहचान करना जिन्हें छवि वेरिएंट्स में बेहतर तरीके से उपयोग किया जा सकता है

![मल्टी-इमेज रिपॉजिटरी संरचना जिसमें साझा आधार और अलग-अलग शाखाएँ दिखाई गई हैं](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/multiimage.png)

### अतिरिक्त उपयोग के मामले

- **सुरक्षा ऑडिटिंग**: बिल्कुल पता लगाएँ कि असुरक्षित पैकेज या कॉन्फ़िगरेशन कब जोड़े गए थे और उन्हें विशिष्ट बिल्ड निर्देशों तक ट्रेस करें।
- **इमेज अनुकूलन**: परत संरचनाओं का विश्लेषण करें ताकि अनावश्यक ऑपरेशंस या बड़े फाइल्स की पहचान की जा सके जिन्हें समेकित किया जा सकता है, जिससे इमेज का आकार कम करने में मदद मिलती है।
- **डिपेंडेंसी प्रबंधन**: देखें कि इमेज इतिहास में डिपेंडेंसी कब जोड़ी, अपग्रेड या हटाई गईं।
- **बिल्ड प्रक्रिया सुधार**: बेहतर कैशिंग और छोटे इमेज आकार के लिए Dockerfile निर्देशों को अनुकूलित करने हेतु परतों की संरचना का विश्लेषण करें।
- **क्रॉस-इमेज तुलना**: कई संबंधित छवियों को Git रिपॉजिटरी में बदलें और उनके अंतर व समानता का विश्लेषण करने के लिए Git के तुलना उपकरणों का उपयोग करें।

## स्थापना

### पैकेज प्रबंधक

#### macOS / Linux (Homebrew)


```bash
brew tap virviil/oci2git
brew install oci2git
```

#### डेबियन / उबुन्टू

[नवीनतम रिलीज़](https://github.com/virviil/oci2git/releases/latest) से .deb पैकेज डाउनलोड करें और इंस्टॉल करें:

```bash
# For amd64 (x86_64)
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git_VERSION_amd64.deb
sudo dpkg -i oci2git_VERSION_amd64.deb

# For arm64
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git_VERSION_arm64.deb
sudo dpkg -i oci2git_VERSION_arm64.deb
```

#### आर्च लिनक्स (AUR)

```bash
# Using yay
yay -S oci2git-bin

# Using paru
paru -S oci2git-bin

# Manual installation
git clone https://aur.archlinux.org/oci2git-bin.git
cd oci2git-bin
makepkg -si
```

### पूर्व-निर्मित बाइनरी

अपने प्लेटफ़ॉर्म के लिए उपयुक्त बाइनरी [नवीनतम रिलीज़](https://github.com/virviil/oci2git/releases/latest) से डाउनलोड करें:

```bash
# Linux x86_64
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git-linux-x86_64.tar.gz
tar xzf oci2git-linux-x86_64.tar.gz
sudo mv oci2git-linux-x86_64 /usr/local/bin/oci2git
chmod +x /usr/local/bin/oci2git

# macOS (Apple Silicon)
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git-darwin-aarch64.tar.gz
tar xzf oci2git-darwin-aarch64.tar.gz
sudo mv oci2git-darwin-aarch64 /usr/local/bin/oci2git
chmod +x /usr/local/bin/oci2git
```

### क्रेट्स.आईओ से

```bash
cargo install oci2git
```

### स्रोत से

```bash
# Clone the repository
git clone https://github.com/virviil/oci2git.git
cd oci2git

# Install locally
cargo install --path .
```

## उपयोग

```
oci2git [OPTIONS] <IMAGE>
oci2git convert [OPTIONS] <IMAGE>
oci2git fsbom [OPTIONS] <IMAGE>
```

### `convert` — OCI इमेज → Git रिपॉजिटरी

```bash
oci2git convert [OPTIONS] <IMAGE>
# or simply:
oci2git <IMAGE>
```

विकल्प:
  `-o, --output <OUTPUT>`  Git रिपॉजिटरी के लिए आउटपुट डायरेक्टरी [डिफ़ॉल्ट: ./container_repo]
  `-e, --engine <ENGINE>`  उपयोग करने के लिए कंटेनर इंजन (docker, nerdctl, tar) [डिफ़ॉल्ट: docker]
  `-v, --verbose`          वर्बोज़ मोड (-v सूचना के लिए, -vv डिबग के लिए, -vvv ट्रेस के लिए)

### `fsbom` — फाइल सिस्टम बिल ऑफ मैटेरियल्स

```bash
oci2git fsbom [OPTIONS] <IMAGE>
```
विकल्प:
  `-o, --output <OUTPUT>`  YAML BOM फाइल के लिए आउटपुट पथ [डिफ़ॉल्ट: ./fsbom.yml]
  `-e, --engine <ENGINE>`  उपयोग करने के लिए कंटेनर इंजन (docker, nerdctl, tar) [डिफ़ॉल्ट: docker]
  `-v, --verbose`          वर्बोज़ मोड (-v जानकारी के लिए, -vv डिबग के लिए, -vvv ट्रेस के लिए)

पर्यावरण वेरिएबल्स:
  `TMPDIR`  इस पर्यावरण वेरिएबल को सेट करके इंटरमीडिएट डेटा प्रोसेसिंग के लिए डिफ़ॉल्ट लोकेशन बदलें। यह प्लेटफॉर्म-निर्भर है (जैसे, यूनिक्स/macOS पर `TMPDIR`, Windows पर `TEMP` या `TMP`).

## उदाहरण

### कन्वर्ट करें

डॉकर इंजन का उपयोग करते हुए (डिफ़ॉल्ट):

```bash
oci2git ubuntu:latest
# or explicitly:
oci2git convert ubuntu:latest -o ./ubuntu-repo
```

पहले से डाउनलोड की गई इमेज टारबॉल का उपयोग करना:
```bash
oci2git convert -e tar -o ./ubuntu-repo /path/to/ubuntu-latest.tar
```
टार इंजन एक वैध OCI फॉर्मेट टारबॉल की अपेक्षा करता है, जिसे आमतौर पर `docker save` से बनाया जाता है:

```bash
# Create a tarball from a local Docker image
docker save -o ubuntu-latest.tar ubuntu:latest

# Convert the tarball to a Git repository
oci2git convert -e tar -o ./ubuntu-repo ubuntu-latest.tar
```
यह `./ubuntu-repo` में एक Git रिपॉजिटरी बनाएगा जिसमें निम्नलिखित शामिल होंगे:
- `Image.md` - छवि के बारे में पूरी मेटाडेटा Markdown प्रारूप में
- `rootfs/` - कंटेनर से फ़ाइल सिस्टम की सामग्री

Git इतिहास कंटेनर की लेयर इतिहास को दर्शाता है:
- पहली कमिट में केवल `Image.md` फाइल होती है जिसमें पूरी मेटाडेटा होती है
- प्रत्येक अगली कमिट मूल छवि की एक लेयर का प्रतिनिधित्व करती है
- कमिट संदेश के रूप में Dockerfile कमांड शामिल होता है

### फ़ाइल सिस्टम बिल ऑफ़ मटेरियल्स (fsbom)

प्रत्येक लेयर में जोड़ी गई या संशोधित प्रत्येक फ़ाइल की YAML सूची तैयार करें:

```bash
oci2git fsbom ubuntu:latest -o ubuntu.yml
```

एक टारबॉल का उपयोग करना:
```bash
oci2git fsbom -e tar image.tar -o image-bom.yml
```
आउटपुट YAML प्रत्येक लेयर को उसकी प्रविष्टियों के साथ सूचीबद्ध करता है, जिन्हें प्रकार (`file`, `hardlink`, `symlink`, `directory`) और स्थिति (`n:uid:gid` नया के लिए, `m:uid:gid` संशोधित के लिए) द्वारा टैग किया गया है। हटाए गए फाइलें (OCI व्हाइटआउट्स) को बाहर रखा गया है।


```yaml
layers:
  - index: 0
    command: "ADD rootfs.tar.gz / # buildkit"
    digest: "sha256:45f3ea58..."
    entries:
      - type: file
        path: "bin/busybox"
        size: 919304
        mode: 493
        stat: "n:0:0"
      - type: hardlink
        path: "bin/sh"
        target: "bin/busybox"
        stat: "n:0:0"
      - type: symlink
        path: "lib64"
        target: "lib"
        stat: "n:0:0"
  - index: 1
    command: "RUN apk add --no-cache curl"
    digest: "sha256:..."
    entries:
      - type: file
        path: "usr/bin/curl"
        size: 204800
        mode: 493
        stat: "n:0:0"
      - type: file
        path: "etc/apk/world"
        size: 32
        mode: 420
        stat: "m:0:0"
```

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

[प्रलेखन]: https://docs.rs/oci2git/



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-02

---
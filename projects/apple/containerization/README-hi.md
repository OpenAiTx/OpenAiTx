# कंटेनरीकरण

कंटेनरीकरण पैकेज एप्लिकेशन को लिनक्स कंटेनरों का उपयोग करने की अनुमति देता है।  
कंटेनरीकरण [Swift](https://www.swift.org) में लिखा गया है और Apple सिलिकॉन पर [Virtualization.framework](https://developer.apple.com/documentation/virtualization) का उपयोग करता है।

कंटेनरीकरण निम्नलिखित APIs प्रदान करता है:

- [OCI इमेज़ प्रबंधित करें](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationOCI/)।
- [रिमोट रजिस्ट्री के साथ इंटरैक्ट करें](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationOCI/Client/)।
- [ext4 फ़ाइल सिस्टम बनाएं और भरें](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationEXT4/)।
- [Netlink सॉकेट परिवार के साथ इंटरैक्ट करें](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationNetlink/)।
- [तेजी से बूट समय के लिए एक अनुकूलित लिनक्स कर्नेल बनाएं](https://raw.githubusercontent.com/apple/containerization/main/kernel/)।
- [हल्के वर्चुअल मशीनों को स्पॉन करें और रनटाइम वातावरण प्रबंधित करें](https://raw.githubusercontent.com/apple/containerization/main/Sources/Containerization/LinuxContainer.swift)।
- [कंटेनरीकृत प्रक्रियाओं को स्पॉन करें और उनके साथ इंटरैक्ट करें](https://raw.githubusercontent.com/apple/containerization/main/Sources/Containerization/LinuxProcess.swift)।
- Apple सिलिकॉन पर linux/amd64 कंटेनरों को चलाने के लिए Rosetta 2 का उपयोग करें।

कृपया Swift पैकेजों की जानकारी के लिए [API दस्तावेज़](https://apple.github.io/containerization/documentation/) देखें जो कंटेनरीकरण प्रदान करता है।

## डिज़ाइन

कंटेनरीकरण प्रत्येक लिनक्स कंटेनर को उसके अपने हल्के वर्चुअल मशीन के अंदर निष्पादित करता है। क्लाइंट प्रत्येक कंटेनर के लिए समर्पित IP पते बना सकते हैं ताकि व्यक्तिगत पोर्ट फॉरवर्डिंग की आवश्यकता न हो। कंटेनर अनुकूलित [Linux kernel configuration](https://raw.githubusercontent.com/apple/containerization/main/kernel) और हल्के init सिस्टम के साथ एक न्यूनतम रूट फ़ाइल सिस्टम का उपयोग करके सेकंड से भी कम स्टार्ट टाइम प्राप्त करते हैं।

[vminitd](https://raw.githubusercontent.com/apple/containerization/main/vminitd) एक छोटा init सिस्टम है, जो कंटेनरीकरण के अंतर्गत एक उप-परियोजना है।  
`vminitd` वर्चुअल मशीन के अंदर प्रारंभिक प्रक्रिया के रूप में स्पॉन होता है और vsock पर GRPC API प्रदान करता है।  
यह API रनटाइम वातावरण को कॉन्फ़िगर करने और कंटेनरीकृत प्रक्रियाओं को लॉन्च करने की अनुमति देता है।  
`vminitd` प्रक्रिया चलाने पर कॉलिंग प्रक्रिया को I/O, सिग्नल, और इवेंट प्रदान करता है।

## आवश्यकताएँ

कंटेनरीकरण को बिल्ड और रन करने के लिए आपको Apple सिलिकॉन Mac की आवश्यकता है।

कंटेनरीकरण पैकेज को बिल्ड करने के लिए, आपके सिस्टम में निम्न में से कोई एक होना चाहिए:

- macOS 15 या नया और Xcode 26 बीटा
- macOS 26 बीटा या नया

पैकेज का उपयोग करके बनाए गए एप्लिकेशन macOS 15 या बाद में चलेंगे, लेकिन macOS 15 पर निम्नलिखित सुविधाएँ उपलब्ध नहीं हैं:

- गैर-आइसोलेटेड कंटेनर नेटवर्किंग - macOS 15 के साथ, एक ही vmnet नेटवर्क पर कंटेनर एक-दूसरे के साथ संवाद नहीं कर सकते।

## उदाहरण उपयोग

कुछ लाइब्रेरियों की सतह का उपयोग कैसे करें, इसके उदाहरणों के लिए cctl निष्पादन योग्य एक अच्छा प्रारंभ है। इस टूल का मुख्य कार्य API का परीक्षण करने के लिए एक प्लेग्राउंड के रूप में है। इसमें निम्नलिखित कोर कार्यक्षमताओं को चलाने वाले कमांड शामिल हैं:

1. [OCI इमेज़ को नियंत्रित करना](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/ImageCommand.swift)
2. [कंटेनर रजिस्ट्री में लॉगिन करना](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/LoginCommand.swift)
3. [रूट फ़ाइल सिस्टम ब्लॉक्स बनाना](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/RootfsCommand.swift)
4. [सरल लिनक्स कंटेनर चलाना](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/RunCommand.swift)

## लिनक्स कर्नेल

macOS पर हल्के वर्चुअल मशीनों को स्पॉन करने के लिए लिनक्स कर्नेल आवश्यक है।  
कंटेनरीकरण एक अनुकूलित कर्नेल कॉन्फ़िगरेशन प्रदान करता है जो [kernel](https://raw.githubusercontent.com/apple/containerization/main/kernel) निर्देशिका में स्थित है।

यह निर्देशिका कंटेनरीकरण के साथ उपयोग के लिए कर्नेल को आसानी से संकलित करने के लिए एक कंटेनरीकृत बिल्ड वातावरण शामिल करती है।

कर्नेल कॉन्फ़िगरेशन तेज स्टार्ट टाइम और हल्के वातावरण के लिए न्यूनतम फीचर्स का सेट है।

जबकि यह कॉन्फ़िगरेशन अधिकांश वर्कलोड के लिए काम करेगा, हम समझते हैं कि कुछ को अतिरिक्त फीचर्स की आवश्यकता होगी।  
इसे हल करने के लिए कंटेनरीकरण कंटेनर आधार पर विभिन्न कर्नेल कॉन्फ़िगरेशन और संस्करणों का उपयोग करने के लिए प्रथम श्रेणी की APIs प्रदान करता है।  
यह कंटेनरों को विभिन्न कर्नेल संस्करणों में विकसित और मान्य करने में सक्षम बनाता है।

अनुकूलित कर्नेल को संकलित करने के निर्देशों के लिए कर्नेल निर्देशिका में [README](https://raw.githubusercontent.com/apple/containerization/main/kernel/README.md) देखें।

### प्री-बिल्ट कर्नेल

यदि आप प्री-बिल्ट कर्नेल का उपयोग करना चाहते हैं, तो उसमें `VIRTIO` ड्राइवर कर्नेल में संकलित होने चाहिए, न कि मॉड्यूल के रूप में।

[Kata Containers](https://github.com/kata-containers/kata-containers) परियोजना कंटेनरों के लिए एक अनुकूलित कर्नेल प्रदान करती है जिसमें सभी आवश्यक कॉन्फ़िगरेशन विकल्प सक्षम होते हैं, जो [रिलीज़](https://github.com/kata-containers/kata-containers/releases/) पृष्ठ पर उपलब्ध हैं।

एक कर्नेल इमेज जिसका नाम `vmlinux.container` है, रिलीज आर्टिफैक्ट्स की `/opt/kata/share/kata-containers/` निर्देशिका में पाया जा सकता है।

## पैकेज बनाने के लिए तैयारी

Swiftly, [Swift](https://www.swift.org), और [Static Linux SDK](https://www.swift.org/documentation/articles/static-linux-getting-started.html) स्थापित करें:

```bash
make cross-prep
```

यदि आप कोई कस्टम टर्मिनल एप्लिकेशन उपयोग करते हैं, तो आपको यह कमांड `.zprofile` से `.zshrc` में स्थानांतरित करना पड़ सकता है (यहाँ `<USERNAME>` बदलें):

```bash
# Added by swiftly
. "/Users/<USERNAME>/.swiftly/env.sh"
```

टर्मिनल एप्लिकेशन को पुनः प्रारंभ करें। सुनिश्चित करें कि यह कमांड `/Users/<USERNAME>/.swiftly/bin/swift` लौटाता है (यहाँ `<USERNAME>` बदलें):

```bash
which swift
```

यदि आपने पहले Static Linux SDK स्थापित किया या उपयोग किया है, तो आपको पुराने SDK संस्करणों को सिस्टम से हटाना पड़ सकता है (यहाँ `<SDK-ID>` बदलें):

```bash
swift sdk list
swift sdk remove <SDK-ID>
```

## पैकेज बनाएं

स्रोत से कंटेनरीकरण बनाएं:

```bash
make all
```

## पैकेज का परीक्षण करें

बिल्ड करने के बाद, बुनियादी और एकीकरण परीक्षण चलाएं:

```bash
make test integration
```

एक कर्नेल एकीकरण परीक्षणों को चलाने के लिए आवश्यक है।  
यदि आपके पास स्थानीय रूप से कर्नेल उपलब्ध नहीं है, तो एक डिफ़ॉल्ट कर्नेल `make fetch-default-kernel` लक्ष्य का उपयोग करके प्राप्त किया जा सकता है।

डिफ़ॉल्ट कर्नेल केवल प्रारंभिक बिल्ड के बाद या `make clean` के बाद डाउनलोड करना आवश्यक है।

```bash
make fetch-default-kernel
make all test integration
```

## प्रोटोबफ़

कंटेनरीकरण `grpc-swift` और `swift-protobuf` के विशिष्ट संस्करणों पर निर्भर करता है। आप इन्हें स्थापित कर RPC इंटरफेस पुनः उत्पन्न कर सकते हैं:

```bash
make protos
```

## दस्तावेज़ीकरण

स्थानीय देखने के लिए API दस्तावेज़ उत्पन्न करें:

```bash
make docs
make serve-docs
```

दूसरे टर्मिनल में चलाकर दस्तावेज़ की पूर्वावलोकन करें:

```bash
open http://localhost:8000/documentation/
```

## योगदान

कंटेनरीकरण में योगदान का स्वागत है और प्रोत्साहित किया जाता है। अधिक जानकारी के लिए कृपया [CONTRIBUTING.md](https://raw.githubusercontent.com/apple/containerization/main/CONTRIBUTING.md) देखें।

## परियोजना की स्थिति

संस्करण 0.1.0 कंटेनरीकरण का पहला आधिकारिक रिलीज़ है। पहले के संस्करणों के लिए स्रोत स्थिरता की कोई गारंटी नहीं है।

कंटेनरीकरण लाइब्रेरी सक्रिय विकास में है, इसलिए स्रोत स्थिरता केवल छोटे संस्करणों (जैसे 0.1.1 और 0.1.2 के बीच) के भीतर गारंटीकृत है। यदि आप संभावित स्रोत-ब्रेकिंग पैकेज अपडेट नहीं चाहते हैं, तो आप अपनी पैकेज निर्भरता को `.upToNextMinorVersion(from: "0.1.0")` का उपयोग करके निर्दिष्ट कर सकते हैं।

भविष्य के छोटे संस्करण आवश्यकतानुसार इन नियमों में परिवर्तन ला सकते हैं।

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---
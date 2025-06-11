# Black-Hat-Zig

<p align="center">
  <img alt="GitHub License" src="https://img.shields.io/github/license/CX330Blake/black-hat-zig">
  <img alt="GitHub top language" src="https://img.shields.io/github/languages/top/cx330blake/black-hat-zig">
  <img alt="GitHub repo size" src="https://img.shields.io/github/repo-size/cx330blake/black-hat-zig">
  <img alt="X (formerly Twitter) Follow" src="https://img.shields.io/twitter/follow/CX330Blake">
</p>

<p height="350px" align="center">
  <img src="https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Black-Hat-Zig.png">
  <br/>
  <b>नमस्ते हैकर्स। नमस्ते मालडेव्स। नमस्ते रिवर्सर्स। आपको यहाँ Zig की डार्क पावर एक्सप्लोर करने के लिए देखकर अच्छा लगा!</b><br/><br/>
  <b>संरक्षित एवं प्रबंधित <a href="https://github.com/cx330blake">@CX330Blake</a> द्वारा</b>
</p>

---

## ToC

- [परिचय](#intro)
- [Zig क्यों?](#why-zig)
- [कोड कंपाइल करना](#compiling-the-codes)
- [पेलोड प्लेसमेंट](#payload-placement)
- [पेलोड ऑबफुस्केशन](#payload-obfuscation)
- [पेलोड एन्क्रिप्शन](#payload-encryption)
- [पेलोड निष्पादन](#payload-execution)
- [रिवर्स शेल](#reverse-shell)
- [मालवेयर तकनीकें](#malware-techniques)
- [मालडेव टूल्स](#maldev-tools)
- [योगदानकर्ता](#contributors)
- [श्रेय एवं संदर्भ](#credits--references)
- [स्टार हिस्ट्री](#star-history)
- [अस्वीकरण](#disclaimer)

## परिचय

> [!IMPORTANT]
> यह प्रोजेक्ट लगातार अपडेट हो रहा है!

यह प्रोजेक्ट Zig का उपयोग करते हुए कई मालवेयर तकनीकों के इम्प्लीमेंटेशन प्रदान करता है, क्योंकि मैं इसका बड़ा प्रशंसक हूँ। आप इस रिपॉजिटरी का उपयोग Zig को वेपनाइज़ करने के लिए कर सकते हैं। Black-Hat-Zig लगातार अपडेट हो रहा है ताकि इसमें अधिक से अधिक कंटेंट आ सके। यदि आप इस प्रोजेक्ट के लिए PR बनाना चाहते हैं तो यह उत्तम होगा।

ठीक है, चलिए प्लैनेट हैक करते हैं!

## Zig क्यों?

- 🤝 C/C++ सोर्स के साथ आसानी से इंटरैक्ट कर सकता है
- 🔎 यह नया है, इसलिए इसे डिटेक्ट करना मुश्किल है
- 💪 स्ट्रॉन्गली लो लेवल कंट्रोल, यहाँ तक कि C से भी कम
- 😱 आधुनिक कम्पाइलर के कारण इसे रिवर्स इंजीनियर करना कठिन है
- 🛡️ न्यूनतम रनटाइम डिपेंडेंसी - कोई बड़ी स्टैंडर्ड लाइब्रेरी नहीं
- 🎯 कोई अनडिफाइंड बिहेवियर नहीं - एज केस का स्पष्ट प्रबंधन, जिससे क्रैश नहीं होता

## कोड कंपाइल करना

आप प्रत्येक डायरेक्टरी के अंदर कोड देख सकते हैं। साथ ही, यदि कोड Windows API का उपयोग करता है, तो आपको संबंधित प्रोजेक्ट डायरेक्टरी के `README.md` में संकेत मिलेगा, उदाहरण के लिए, [यहाँ](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/bcrypt_aes/)।

मैंने पहले से ही उन कोड के लिए डिफ़ॉल्ट बिल्डिंग टार्गेट `windows-x86_64` सेट किया है जिन्हें Windows API की आवश्यकता है, तो आप आसानी से निम्नलिखित कमांड को कॉपी-पेस्ट करके कोड को कहीं भी, Linux, Windows, यहाँ तक कि MacOS पर भी कंपाइल कर सकते हैं! (लेकिन आपको एक्सिक्यूटेबल्स चलाने के लिए विंडोज़ एनवायरनमेंट की आवश्यकता होगी)

```bash
zig build
```

## पेलोड प्लेसमेंट

एक्जीक्यूटेबल फाइल के विभिन्न सेक्शन्स में मैलिशियस पेलोड्स को रखने की तकनीकें।

- [.data सेक्शन](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_data_section/)
- [.rdata सेक्शन](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_rdata_section/)
- [.text सेक्शन](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_text_section/)
- [.rsrc सेक्शन](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_rsrc_section/)

## पेलोड ऑबफुस्केशन

पेलोड्स को छिपाने और स्टैटिक एनालिसिस या पैटर्न मैचिंग द्वारा डिटेक्शन से बचने के लिए ऑबफुस्केशन तकनीकें।

- [IP एड्रेस ऑबफुस्केशन](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/)
  - [IPv4 ऑबफुस्केशन](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv4_obfuscation/)
  - [IPv4 डीऑबफुस्केशन](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv4_deobfuscation/)
  - [IPv6 ऑबफुस्केशन](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv6_obfuscation/)
  - [IPv6 डीऑबफुस्केशन](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv6_deobfuscation/)
- [MAC एड्रेस ऑबफुस्केशन](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/)
  - [MAC एड्रेस ऑबफुस्केशन](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/MACFuscation/)
  - [MAC एड्रेस डीऑबफुस्केशन](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/MACDeobfuscation/)
- [UUID ऑबफुस्केशन](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/)
  - [UUID ऑबफुस्केशन](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/UUIDFuscation/)
  - [UUID डीऑबफुस्केशन](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/UUIDDeobfuscation/)

## पेलोड एन्क्रिप्शन

स्टोरेज या ट्रांसमिशन के दौरान पेलोड के असली उद्देश्य को छुपाने के लिए विभिन्न एन्क्रिप्शन स्कीम्स।

- [XOR एन्क्रिप्शन](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/XOR/)
  - [स्टैंडर्ड लाइब्रेरी के साथ XOR](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/XOR/std_lib_xor/)
- [RC4 एन्क्रिप्शन](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/RC4/)
  - [SystemFunction032 के साथ RC4](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/RC4/system_function_032_rc4/)
- [AES एन्क्रिप्शन](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/)
  - [Bcrypt.h के साथ AES](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/bcrypt_aes/)
  - [स्टैंडर्ड लाइब्रेरी के साथ AES](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/std_aes/)
  - [TinyAES के साथ AES](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/tiny_aes/)

## पेलोड निष्पादन

- [DLL](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Execution/dll/)
- [Shellcode](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Execution/shellcode/)

## रिवर्स शेल

C2 एक्सेस या पोस्ट-एक्सप्लॉइटेशन कंट्रोल के लिए रिवर्स शेल स्थापित करने के लिए प्रिमिटिव्स।

- [स्टैंडर्ड लाइब्रेरी के साथ रिवर्स शेल](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Reverse-Shell/std_reverse_shell/)

## मालवेयर तकनीकें

Zig में अनुकूलित आम ऑफेंसिव ट्रेडक्राफ्ट तकनीकों का संग्रह।

- [प्रोसेस इंजेक्शन](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/)
  - [DLL इंजेक्शन](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/dll_injection/)
  - [Shellcode इंजेक्शन](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/shellcode_injection/)
- [पेलोड स्टेजिंग](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/)
  - [वेब सर्वर से](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/web_server/)
  - [Windows रजिस्ट्री से](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/windows_registry/)
- [प्रोसेस एन्यूमरेशन](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/)
  - [CreateToolhelp32Snapshot का उपयोग करते हुए](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/create_tool_help_32_snapshot/)
  - [EnumProcesses का उपयोग करते हुए](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/enum_processes/)
  - [NtQuerySystemInformation का उपयोग करते हुए](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/nt_query_system_information/)

## मालडेव टूल्स

- [ZYRA: आपका रनटाइम आर्मर](https://github.com/cx330blake/zyra)
  - Zig में लिखा गया एक एक्सिक्यूटेबल पैकर
- [ZYPE: आपका पेलोड एन्क्रिप्टर](https://github.com/cx330blake/zype)
  - Zig में एक कोड टेम्पलेट जनरेट करें जिसमें आपका एन्क्रिप्टेड/ऑबफुस्केटेड पेलोड और संबंधित डिक्रिप्ट/डीऑबफुस्केट फंक्शन शामिल हो।

## योगदानकर्ता

यह प्रोजेक्ट मुख्य रूप से [@CX330Blake](https://github.com/CX330Blake) द्वारा संरक्षित एवं प्रबंधित है। PRs का स्वागत है। आशा है कि अधिक लोग मालवेयर डेवेलपिंग के लिए Zig का उपयोग करें ताकि इकोसिस्टम अधिक परिपक्व हो सके।

इन योगदानकर्ताओं का बहुत धन्यवाद!

<a href="https://github.com/CX330Blake/black-hat-zig/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CX330Blake/black-hat-zig" />
</a>

## श्रेय एवं संदर्भ

- [Maldev Academy](https://maldevacademy.com/)
- [OffensiveNim](https://github.com/byt3bl33d3r/OffensiveNim)

## स्टार हिस्ट्री

[![Star History Chart](https://api.star-history.com/svg?repos=CX330blake/black-hat-zig&type=Date)](https://www.star-history.com/#CX330blake/black-hat-zig&Date)

## अस्वीकरण

यह प्रोजेक्ट केवल नैतिक और शैक्षिक उद्देश्य के लिए है। साइबर अपराधी न बनें।

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---
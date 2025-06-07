<img src=".github/splash.png" alt="Tauri" />

[![status](https://img.shields.io/badge/status-stable-blue.svg)](https://github.com/tauri-apps/tauri/tree/dev)
[![License](https://img.shields.io/badge/License-MIT%20or%20Apache%202-green.svg)](https://opencollective.com/tauri)
[![test core](https://img.shields.io/github/actions/workflow/status/tauri-apps/tauri/test-core.yml?label=test%20core&logo=github)](https://github.com/tauri-apps/tauri/actions/workflows/test-core.yml)
[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri.svg?type=shield)](https://app.fossa.com/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri?ref=badge_shield)
[![Chat Server](https://img.shields.io/badge/chat-discord-7289da.svg)](https://discord.gg/SpmNs4S)
[![website](https://img.shields.io/badge/website-tauri.app-purple.svg)](https://tauri.app)
[![https://good-labs.github.io/greater-good-affirmation/assets/images/badge.svg](https://good-labs.github.io/greater-good-affirmation/assets/images/badge.svg)](https://good-labs.github.io/greater-good-affirmation)
[![support](https://img.shields.io/badge/sponsor-Open%20Collective-blue.svg)](https://opencollective.com/tauri)

## परिचय

Tauri एक फ्रेमवर्क है जो सभी प्रमुख डेस्कटॉप प्लेटफार्मों के लिए छोटे, बेहद तेज बाइनरी बनाने के लिए उपयोग होता है। डेवलपर्स किसी भी फ्रंट-एंड फ्रेमवर्क को एकीकृत कर सकते हैं जो HTML, JS और CSS में संकलित होता है, ताकि वे अपना यूज़र इंटरफेस बना सकें। एप्लिकेशन का बैकएंड एक रस्ट-आधारित बाइनरी होता है, जिसमें एक API होता है जिससे फ्रंट-एंड इंटरैक्ट कर सकता है।

Tauri ऐप्स में यूज़र इंटरफेस वर्तमान में [`tao`](https://docs.rs/tao) का उपयोग विंडो हैंडलिंग लाइब्रेरी के रूप में macOS, Windows, Linux, Android और iOS पर करता है। आपके एप्लिकेशन को रेंडर करने के लिए, Tauri [WRY](https://github.com/tauri-apps/wry) का उपयोग करता है, जो एक लाइब्रेरी है जो सिस्टम वेबव्यू के लिए एकीकृत इंटरफ़ेस प्रदान करती है। यह macOS और iOS पर WKWebView, Windows पर WebView2, Linux पर WebKitGTK और Android पर Android System WebView का उपयोग करती है।

इन सभी हिस्सों के एक साथ कैसे काम करते हैं, इसकी विस्तृत जानकारी के लिए कृपया यह [ARCHITECTURE.md](https://github.com/tauri-apps/tauri/blob/dev/ARCHITECTURE.md) दस्तावेज़ देखें।

## प्रारंभ करना

यदि आप एक tauri ऐप बनाना चाहते हैं, तो कृपया [डॉक्यूमेंटेशन वेबसाइट](https://tauri.app) पर जाएं।

सबसे तेज़ तरीका है कि आप अपने सिस्टम के लिए [आवश्यकताएँ](https://v2.tauri.app/start/prerequisites/) इंस्टॉल करें और [`create-tauri-app`](https://github.com/tauri-apps/create-tauri-app/#usage) के साथ एक नया प्रोजेक्ट बनाएं। उदाहरण के लिए `npm` के साथ:

```sh
npm create tauri-app@latest
```

## विशेषताएँ

Tauri की विशेषताओं की सूची में शामिल हैं, लेकिन सीमित नहीं हैं:

- अंतर्निहित ऐप बंडलर, जिससे `.app`, `.dmg`, `.deb`, `.rpm`, `.AppImage` और Windows इंस्टॉलर जैसे `.exe` (NSIS द्वारा) और `.msi` (WiX द्वारा) फॉर्मेट में ऐप बंडल बनाए जा सकते हैं।
- अंतर्निहित स्वयं अपडेटर (केवल डेस्कटॉप के लिए)
- सिस्टम ट्रे आइकॉन्स
- नेटिव नोटिफिकेशन
- नेटिव WebView प्रोटोकॉल (tauri WebView सामग्री को सर्व करने के लिए localhost http(s) सर्वर नहीं बनाता)
- सुविधाजनक CI के लिए GitHub एक्शन
- VS Code एक्सटेंशन

### प्लेटफार्म्स

Tauri वर्तमान में निम्नलिखित प्लेटफार्मों पर विकास और वितरण को सपोर्ट करता है:

| प्लेटफ़ॉर्म   | संस्करण                                                                                                             |
| :------------ | :----------------------------------------------------------------------------------------------------------------- |
| Windows       | 7 और ऊपर                                                                                                            |
| macOS         | 10.15 और ऊपर                                                                                                       |
| Linux         | Tauri v1 के लिए webkit2gtk 4.0 (जैसे Ubuntu 18.04)। Tauri v2 के लिए webkit2gtk 4.1 (जैसे Ubuntu 22.04)।             |
| iOS/iPadOS    | 9 और ऊपर                                                                                                            |
| Android       | 7 और ऊपर (वर्तमान में 8 और ऊपर)                                                                                    |

## योगदान करना

किसी चीज़ पर काम शुरू करने से पहले, यह देखना सबसे अच्छा है कि पहले से कोई मौजूदा issue है या नहीं। साथ ही, Discord सर्वर पर टीम से पुष्टि करना भी अच्छा विचार है कि यह तर्कसंगत है या पहले से कोई और उस पर काम कर रहा है।

कृपया कोई भी pull request करने से पहले [Contributing Guide](./.github/CONTRIBUTING.md) अवश्य पढ़ें।

Tauri में योगदान देने वाले सभी लोगों का धन्यवाद!

### दस्तावेज़ीकरण

बहुभाषी सिस्टम में डॉक्यूमेंटेशन एक जटिल कार्य है। इसी कारण से, हम Rust और JS सोर्स कोड में इनलाइन डॉक्यूमेंटेशन का अधिकतम उपयोग करना पसंद करते हैं। डॉक्यूमेंटेशन साइट की अधिक जानकारी के लिए होस्टिंग रिपोजिटरी देखें: <https://github.com/tauri-apps/tauri-docs>

## साझेदार

<table>
  <tbody>
    <tr>
      <td align="center" valign="middle">
        <a href="https://crabnebula.dev" target="_blank">
          <img src=".github/sponsors/crabnebula.svg" alt="CrabNebula" width="283">
        </a>
      </td>
    </tr>
  </tbody>
</table>

पूरा प्रायोजकों की सूची देखने के लिए कृपया हमारी [वेबसाइट](https://tauri.app#sponsors) और [Open Collective](https://opencollective.com/tauri) देखें।

## संगठन

Tauri का उद्देश्य ऐसे सिद्धांतों पर आधारित एक सतत् सामूहिक बनना है जो [सतत् मुक्त और ओपन सॉफ्टवेयर समुदायों](https://sfosc.org) का मार्गदर्शन करते हैं। इसी उद्देश्य के लिए, यह [Commons Conservancy](https://commonsconservancy.org/) के तहत एक प्रोग्राम बन गया है, और आप [Open Collective](https://opencollective.com/tauri) के माध्यम से आर्थिक रूप से योगदान कर सकते हैं।

## लाइसेंस

कोड: (c) 2015 - वर्तमान - The Commons Conservancy के तहत The Tauri Programme।

MIT या लागू होने पर MIT/Apache 2.0।

लोगो: CC-BY-NC-ND

- मूल Tauri लोगो डिज़ाइन [Alve Larsson](https://alve.io/), [Daniel Thompson-Yvetot](https://github.com/nothingismagick) और [Guillaume Chau](https://github.com/akryum) द्वारा

[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri.svg?type=large)](https://app.fossa.com/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri?ref=badge_large)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---
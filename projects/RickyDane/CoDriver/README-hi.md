
<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<br/>
<p align="center"><img width="500" height="auto" alt="codriver_banner" src="https://github.com/user-attachments/assets/1957b950-db16-4ebd-b514-4f9b4f4abfd9" /></p>

<br/>

<a href="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml"><p align="center"><img src="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml/badge.svg?branch=master"></p></a>

<p align="center">
  <img src="https://img.shields.io/badge/Windows-blue" />
  <img src="https://img.shields.io/badge/ macOS-white" />
  <img src="https://img.shields.io/badge/Linux-red" />
</p>

<p align="center">
  <a href="https://discord.gg/zSE27rjdzp">
      <img src="https://dcbadge.limes.pink/api/server/https://discord.gg/zSE27rjdzp" />
  </a>
</p>

<p align="center">
  <a href='https://ko-fi.com/rickydane'>
      <img height='36px' style='border: 0px; height: 36px;' src='https://storage.ko-fi.com/cdn/kofi2.png?v=3' border='0' alt='ko-fi.com पर मुझे कॉफ़ी खरीदें' />
  </a>
</p>

<br/>

<p align="center">
  एक साधारण फाइल एक्सप्लोरर, जिसे मैंने Rust भाषा सीखने के लिए बनाया था।
  <br>
  यह ऑपरेटिंग सिस्टम से स्वतंत्र है और अनुकूलन के लिए ट्रिम किया गया है।
</p>

<br/><br/>

प्रदर्शन ["jwalk"](https://crates.io/crates/jwalk/versions) और ["Tauri"](https://tauri.app/) के द्वारा प्राप्त किया गया है।
<br/><br/>
CoDriver फाइलों और फोल्डरों को एक्सेस करने के लिए पाथ कैशिंग का उपयोग नहीं करता, इसलिए प्रदर्शन Rust, डिस्क की गति और CPU की शक्ति के द्वारा मिलता है।

⁉️ ध्यान दें कि यह सॉफ्टवेयर अभी निर्माणाधीन है और इसमें बग हो सकते हैं!
<br/><br/>

# लिंक
- <a href="#basic-features">मूलभूत फीचर्स</a>
- <a href="#advanced-features">उन्नत फीचर्स</a>
- <a href="#dependencies-if-not-working-instantly">निर्भरता</a>
- <a href="#%EF%B8%8F-ftp-integration-sshfs">FTP कार्यान्वयन (SSHFS)</a>
- <a href="#%EF%B8%8F-known-issues">ज्ञात समस्याएँ</a>
- <a href="#-todos">Todos</a>
- <a href="#user-interface">यूज़र इंटरफ़ेस</a>

## बेसिक फीचर्स
- डायरेक्टरीज़ में नेविगेट करें जैसे आप जानते हैं
- फाइल्स और फोल्डर्स को कॉपी और पेस्ट करें, डिलीट करें, बनाएं और रीनेम करें
- ग्रिड, लिस्ट और मिलर-कॉलम्स मोड के बीच स्विच करें
- esc दबाकर पॉपअप्स बंद करें
- Ctrl / Cmd + G से डायरेक्टरी में सीधे जंप करें, पाथ डालकर
- लिस्ट मोड में आइटम्स को साइज़, नाम या अंतिम संशोधित के अनुसार सॉर्ट करें

## एडवांस्ड फीचर्स
- फाइल्स और फोल्डर्स को कंप्रेस करें
  - zip
  - zstd
  - brotli
  - density (https://github.com/g1mv/density)
- आर्काइव्स को अनपैक करें
  - rar
  - zip
  - 7zip
  - tar (.gz, .bz2)
  - density
- शॉर्टकट LAlt + 1 / 2 / 3 | (macOS option + 1 / 2 / 3) से डायरेक्टरी में नेविगेट करें
  - सेटिंग्स में पाथ्स खुद से कॉन्फ़िगर करें
- F6 से फाइल बनाएं
- F7 से फोल्डर बनाएं
- डुअल-पेन व्यू
  - F8 से फाइल्स सर्च करें
  - F5 से वर्तमान चयनित आइटम को दूसरे पेन में कॉपी करें
  - LShift + F5 से वर्तमान चयनित आइटम को दूसरे पेन में मूव करें
- फाइल्स को एक्सप्लोरर में ड्रैग और ड्रॉप करके मौजूदा डायरेक्टरी में कॉपी करें
- Ctrl / Cmd + LShift + M से अपने चयनित आइटम्स का मल्टी रीनेम करें
  - Ctrl / Cmd + Return से मल्टी रीनेम चलाएं
- फाइल का त्वरित प्रीव्यू -> डायरेक्टरी एंट्री चुनें और स्पेस बार दबाएं।
  - समर्थित फाइल्स: सभी इमेज फाइल्स (.jpg, .png, ...), .pdf, .mp4, .json, .txt, .html
  - अन्य सभी आइटम्स का एक छोटा टाइल दिखेगा जिसमें इसकी जानकारी होगी। (पाथ, साइज़, अंतिम संशोधित)
- त्वरित नेविगेशन -> टाइप करना शुरू करें और डायरेक्टरी एंट्रीज़ को ऑटोमेटिकली फ़िल्टर करें जिससे कई बार <br/>
  मनचाही लोकेशन तक जाना बहुत तेज़ हो जाता है

## निर्भरता (यदि तुरंत काम नहीं कर रहा है)

<details>
<summary>दिखाने के लिए विस्तार करें</summary>

### लिनक्स

- openssl1.1

#### डेबियन / उबंटू
```
sudo apt update
sudo apt install libwebkit2gtk-4.0-dev \
    build-essential \
    curl \
    wget \
    file \
    libssl-dev \
    libgtk-3-dev \
    libayatana-appindicator3-dev \
    librsvg2-dev
```

#### आर्च
```
sudo apt update
sudo apt install libwebkit2gtk-4.0-dev \
    build-essential \
    curl \
    wget \
    file \
    libssl-dev \
    libgtk-3-dev \
    libayatana-appindicator3-dev \
    librsvg2-dev
```

#### फेडोरा
```
sudo dnf check-update
sudo dnf install openssl1.1 \
    webkit2gtk4.0-devel \
    openssl-devel \
    curl \
    wget \
    file \
    libappindicator-gtk3-devel \
    librsvg2-devel
sudo dnf group install "C Development Tools and Libraries"
```
</details>

## 🖥️ FTP एकीकरण (sshfs)
<details>
  <summary>दिखाने के लिए विस्तार करें</summary>
  <br/>
  निर्भरता (अतिरिक्त रूप से स्थापित करनी होंगी):
  <br/>

  | macOS | Linux | Windows |
  | ----- | ----- | ------- |
  | fuse-t <br/> fuse-t-sshfs | libfuse | अभी समर्थित नहीं है **_yet_** |

  ### स्थापना:
  #### macOS
  ```
  brew tap macos-fuse-t/homebrew-cask
  brew install fuse-t
  brew install fuse-t-sshfs
  ```
  #### लिनक्स
  ```
  sudo apt-get install sshfs
  ```
## 🏴‍☠️ भाषा समर्थन
- अंग्रेज़ी
  - भाषाओं के बीच चयन करने का विकल्प जल्द आ रहा है ...
</details>

## ⚠️ ज्ञात समस्याएँ:
- लिनक्स पर विंडो से बाहर ड्रैग और ड्रॉप वर्तमान में हमेशा कार्य नहीं करता है
- विंडोज़ पर आपको [Microsoft Visual C++ Redistributable](https://learn.microsoft.com/en-us/cpp/windows/latest-supported-vc-redist?view=msvc-170) इंस्टॉल करना पड़ सकता है
- एमएस-विंडोज़ पर अनुमतियाँ थोड़ी अजीब हैं
  - यदि आपको तत्वों की प्रतिलिपि बनाने या इसी तरह की समस्या आती है तो आपको प्रोग्राम को प्रशासक के रूप में चलाना पड़ सकता है
- लिनक्स सिस्टम पर यदि प्रोग्राम शुरू नहीं होता है तो openssl1.1 इंस्टॉल करने की आवश्यकता हो सकती है

## 📝 कार्यसूची:
- अनेक भाषाएँ
- पसंदीदा
- ऑनलाइन स्टोरेज सेवाओं तक पहुँच (गूगल ड्राइव आदि)

## उपयोगकर्ता इंटरफ़ेस
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 19 16" src="https://github.com/user-attachments/assets/fc408504-3000-4325-bc2a-638cdd01ea0a" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 19 40" src="https://github.com/user-attachments/assets/5f772d02-6bc2-470c-b999-6982043496c1" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 02" src="https://github.com/user-attachments/assets/7f2ec5ea-a669-4630-a1f8-413c7ced3f3b" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 07" src="https://github.com/user-attachments/assets/4ac9930d-7b50-4910-afb3-d47c562c3b44" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 28" src="https://github.com/user-attachments/assets/7dcfb0fa-c106-401a-b917-06e766021368" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 23 18" src="https://github.com/user-attachments/assets/4bac06d1-22df-47d4-95c9-1ccb50083506" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 23 39" src="https://github.com/user-attachments/assets/fdca23b0-9ed5-495b-9fec-18ecbfd4d5f2" />



## योगदान कैसे करें
अपने कंप्यूटर पर tauri v1 एप्लिकेशन के विकास के लिए मशीन सेटअप करें: [Tauri आवश्यकताएँ](https://tauri.app/v1/guides/getting-started/prerequisites)
</br></br>
इसके बाद बस अपने कंप्यूटर पर किसी स्थान पर ```git clone https://github.com/RickyDane/CoDriver``` या ```gh repo clone RickyDane/CoDriver``` करें।
</br></br>
आप इस प्रोजेक्ट की रूट डायरेक्टरी में ```cargo tauri dev``` चला सकते हैं ताकि CoDriver का निर्माण और चलाना शुरू कर सकें।
</br>
सुनिश्चित करें कि tauri-cli इंस्टॉल है: ```cargo install tauri-cli```
</br>

## रिलीज़ साइनिंग

macOS रिलीज़ आर्टिफैक्ट्स को साइन और नोटराइज़ करना आवश्यक है ताकि Gatekeeper यह रिपोर्ट न करे कि इंस्टॉल किया गया ऐप डैमेज्ड है। आवश्यक GitHub Actions सीक्रेट्स और सत्यापन कमांड्स के लिए देखें [macOS साइनिंग और नोटराइज़ेशन](https://raw.githubusercontent.com/RickyDane/CoDriver/master/docs/macos-signing-notarization.md)।

## स्टार इतिहास

<a href="https://star-history.com/#rickydane/CoDriver&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
   <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
 </picture>
</a>

#### अन्य तृतीय पक्ष सॉफ़्टवेयर
- DragSelect (https://github.com/ThibaultJanBeyer/DragSelect)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-25

---
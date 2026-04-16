<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# नट्टी [![अनुवाद स्थिति](https://hosted.weblate.org/widgets/nutty/-/svg-badge.svg)](https://hosted.weblate.org/engage/nutty/?utm_source=widget) [![बिल्ड स्थिति](https://travis-ci.org/babluboy/nutty.svg?branch=master)](https://travis-ci.org/babluboy/nutty) [![स्नैप स्थिति](https://build.snapcraft.io/badge/babluboy/nutty.svg)](https://build.snapcraft.io/user/babluboy/nutty) [![दान करें](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=FZP8GK839VGQC)
एक नेटवर्क यूटिलिटी

लेखक: सिद्धार्थ दास

एक सरल एप्लिकेशन जो एलिमेंटरी OS के लिए बनाया गया है, ताकि नेटवर्क से संबंधित महत्वपूर्ण जानकारी प्रदान की जा सके। जानकारी निम्नलिखित टैब्स के रूप में प्रस्तुत की जाती है।<br>
1. मेरी जानकारी: डिवाइस नेटवर्क कार्ड के लिए मूल और विस्तृत जानकारी प्रदान करता है<br>
2. उपयोग: नेटवर्क डेटा उपयोग दो दृश्य में दिखाता है - ऐतिहासिक उपयोग और वर्तमान उपयोग<br>

3. स्पीड: अपलोड और डाउनलोड स्पीड जांचें और किसी होस्ट तक रूट समय प्राप्त करें<br>
4. पोर्ट्स: स्थानीय डिवाइस पर सक्रिय पोर्ट्स और उनका उपयोग करने वाले एप्लिकेशन की जानकारी प्रदान करता है<br>
5. डिवाइस: नेटवर्क से जुड़े अन्य डिवाइस की निगरानी, अलर्ट और जानकारी प्रदान करता है<br>

विशेषताओं, शॉर्टकट्स, उबंटू और अन्य समर्थित डिस्ट्रीब्यूशन के लिए इंस्टॉलेशन गाइड आदि के लिए Nutty वेबसाइट देखें: <br>
https://babluboy.github.io/nutty/

## स्रोत से निर्माण, परीक्षण और स्थापना

बिल्ड करने के लिए आपको निम्नलिखित निर्भरताएँ चाहिए:
* libgranite-dev
* libnotify-dev
* libxml2-dev
* libxml2-utils
* libgee-0.8-dev
* libgtk-3-dev
* libsqlite3-dev
* meson
* valac

और इन्हें निष्पादित करने के लिए ये निर्भरताएँ चाहिए:
* net-tools
* nethogs
* nmap
* traceroute
* vnstat
* curl
* wireless-tools
* iproute2
* pciutils

कभी-कभी vnstat इंस्टॉल करने पर शुरू नहीं होता है, vnstat डेमॉन शुरू करने के लिए उपयुक्त init सिस्टम कमांड का उपयोग करें जैसे कि `sudo systemctl enable vnstat`

बिल्ड एनवायरनमेंट को कॉन्फ़िगर करने के लिए `meson build` चलाएँ और बिल्ड के लिए `ninja test` चलाएँ

```
git clone https://github.com/babluboy/nutty.git
cd nutty
meson build --prefix=/usr
cd build
ninja
```
इंस्टॉल करने के लिए, `sudo ninja install` का उपयोग करें, फिर `com.github.babluboy.nutty` के साथ निष्पादित करें


```
sudo ninja install
com.github.babluboy.nutty
```
अनइंस्टॉल करने के लिए, बिल्ड डायरेक्टरी में जाएं और चलाएं

```
sudo ninja uninstall
```

### डेब पैकेज से स्थापना

`.deb` पैकेज से Nutty स्थापित करने के लिए सुनिश्चित करें कि आपने Nutty की उपरोक्त सभी निष्पादन निर्भरता स्थापित कर ली हैं (बिल्ड निर्भरता की आवश्यकता नहीं है)। फिर नीचे दिया गया कमांड चलाएँ
```bash
sudo dpkg -i <deb-package-name>.deb
```

और यदि आपने Nutty को `.deb` पैकेज के माध्यम से इंस्टॉल किया है, तो अनइंस्टॉल करने के लिए चलाएँ
```bash
sudo apt autoremove com.github.babluboy.nutty
```
यदि आप Nutty का `.deb` पैकेज सीधे स्वयं बनाना चाहते हैं तो ऊपर दिए गए बिल्ड डिपेंडेंसीज़ इंस्टॉल करें और फिर चलाएँ

```bash
git clone https://github.com/babluboy/nutty.git
cd nutty
dpkg-buildpackage -us -uc
cd ..
```


## Screenshot

![screenshot](https://raw.githubusercontent.com/babluboy/nutty/gh-pages/images/Nutty_Device_Alert.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-16

---
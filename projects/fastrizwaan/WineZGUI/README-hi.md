<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# WineZGUI

#### Zenity का उपयोग करते हुए Wine GUI - खेलें और साझा करें!

![](https://raw.githubusercontent.com/fastrizwaan/WineZGUI/main/assets/winezgui.svg) <a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Flathub पर डाउनलोड करें' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>

![](https://github.com/fastrizwaan/WineZGUI/releases/download/0.97.12/winezgui-0.97.14.png)


## WineZGUI क्या है

WineZGUI (उच्चारण वाइन-ज़ी-गू-ई) विंडोज़ गेम्स को वाइन के साथ आसानी से चलाने के लिए एक वाइन फ्रंटएंड है। यह वाइन प्रीफ़िक्स प्रबंधन और लिनक्स डेस्कटॉप एकीकरण के लिए बैश स्क्रिप्ट्स का एक संग्रह है, जिससे ज़ेनिटी का उपयोग करते हुए वाइन गेमिंग का अनुभव आसान होता है। यह फाइल मैनेजर जैसे नॉटिलस से डायरेक्ट-प्ले (इंस्टॉल नहीं किया गया) EXE एप्लिकेशन या गेम को तेज़ी से लॉन्च करने और प्रत्येक विंडोज़ EXE बाइनरी के लिए अलग वाइन प्रीफ़िक्स बनाने की अनुमति देता है।

## WineZGUI क्यों?

1. फाइल मैनेजर से विंडोज़ गेम्स या exe फाइल्स चलाता है।
2. आसान एक्सेस के लिए एप्लिकेशन शॉर्टकट बनाता है।
3. प्रीफ़िक्स सेटअप करने के बजाय गेम खेलने पर फोकस।
4. प्रीफ़िक्स का बैकअप और रिस्टोर बाद में उपयोग के लिए।
5. शेयरिंग के लिए गेम बंडल बनाएँ (प्रीफ़िक्स+गेम)।

## यह कैसे काम करता है

1. जब कोई विंडोज़ बाइनरी या exe WineZGUI से खोला जाता है,
2. यह एक नया प्रीफ़िक्स बनाता है (टेम्पलेट की कॉपी) और EXE फाइलनाम के साथ एक डेस्कटॉप शॉर्टकट बनाता है।
3. जब यूज़र स्क्रिप्ट लॉन्च करता है, तो exe लॉन्च हो जाता है।
4. यदि यह सेटअप है, तो यह इंस्टॉल्ड exe को डिटेक्ट करता है और गेम्स मेनू श्रेणी में शॉर्टकट बनाता है।

## किसी अन्य ड्राइव या डायरेक्टरी में गेम या प्रोग्राम कैसे चलाएँ

अपना टर्मिनल खोलें और यह टाइप करें:

`flatpak override --user --filesystem=/path/to/your/drive io.github.fastrizwaan.WineZGUI`

### WineZGUI इंस्टॉल करें

WineZGUI फ्लैटपैक के रूप में फ्लैथब पर उपलब्ध है:

<a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Download on Flathub' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>


Flathub WineZGUI केवल Desktop, Documents, Downloads, Music, Pictures, Videos डायरेक्टरीज़ तक पहुंच सकता है। अन्य स्थानों या माउंटेड पार्टिशन या ड्राइव्स से फाइलें एक्सेस करने के लिए, या तो उन्हें उपरोक्त डायरेक्टरीज़ (Downloads आदि) में कॉपी करें या पढ़ने की अनुमति चाहिए, जो Flatseal ऐप या कमांड लाइन `flatpak --user override --filesystem=host:ro io.github.fastrizwaan.WineZGUI` से दी जा सकती है।

मैं दृढ़ता से flatpak संस्करण का उपयोग करने की अनुशंसा करता हूँ, क्योंकि डिस्ट्रो आधारित वाइन (wine-staging) लगातार अपडेट होता रहता है और गेम्स हर कुछ दिनों में काम करना बंद कर सकते हैं। Flathub से wine stable का उपयोग करना बेहतर है या डिस्ट्रो पैकेज से wine stable 5.0 या 7.0 का उपयोग करें।

#### [समर्थित लिनक्स डिस्ट्रीब्यूशन्स](https://flatpak.org/setup/) पर WineZGUI फ्लैटपैक इंस्टॉल करें

WineZGUI को फ्लैटपैक-वाइन में मेरे द्वारा पैकेज किया गया है। [WineZGUI Flathub](https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI) मेरा अन्य फ्लैटपैक अब [flatpak-wine](https://github.com/fastrizwaan/flatpak-wine) अप्रचलित हो चुका है।

### लिनक्स सिस्टम पर SETUP के लिए, देखें [Requirements](https://github.com/fastrizwaan/WineZGUI#requirements)

सेटअप तुरंत होता है क्योंकि यह कुछ फाइलों को विशिष्ट डायरेक्टरी में कॉपी करता है।

##### संस्करण 0.99.13

स्रोत डाउनलोड करें [WineZGUI-0.99.13.tar.gz](https://github.com/fastrizwaan/WineZGUI/archive/refs/tags/0.99.13.tar.gz) या `git tag 0.99.13` का उपयोग करें

##### tar.gz का उपयोग करते हुए

```
wget https://github.com/fastrizwaan/WineZGUI/archive/refs/tags/0.99.13.tar.gz
tar -zxvf 0.99.13.tar.gz
cd WineZGUI-0.99.13
sudo ./setup --install ; #systemwide
```

##### git टैग 0.99.13

```
git clone --depth 1 --branch 0.99.13 https://github.com/fastrizwaan/WineZGUI.git
cd WineZGUI
sudo ./setup --install ; #systemwide
```

##### विकास संस्करण

```
git clone https://github.com/fastrizwaan/WineZGUI.git
cd WineZGUI
sudo ./setup --install ; #systemwide
```

### WineZGUI अनइंस्टॉल करें

##### Flatpak अनइंस्टॉल

```
flatpak remove io.github.fastrizwaan.WineZGUI
```

##### सिस्टम अनइंस्टॉल

एक ही इंस्टॉलेशन स्रोत डायरेक्टरी से `uninstall` चलाएँ

```
sudo ./setup --uninstall
```
## आवश्यकताएँ

`wine` - मुख्य प्रोग्राम

`winetricks` - आवश्यक वाइन ऐडऑन स्क्रिप्ट

`perl‑image‑exiftool` - एप्लिकेशन/गेम का नाम निकालने के लिए

`icoutils` - exe फाइल से आइकन निकालने के लिए

`gnome-terminal` - (वैकल्पिक) प्रिफिक्स डायरेक्टरी को शेल में एक्सेस करने के लिए

## लिनक्स ओएस के लिए आवश्यकताओं की स्थापना

### Flatpak समर्थित डिस्ट्रीब्यूशन्स

[flatpak-wine](https://github.com/fastrizwaan/flatpak-wine/releases) प्राप्त करें जिसमें सभी डिपेंडेंसीज़ शामिल हैं। उन डिस्ट्रीब्यूशन्स के लिए उपयोगी जो वाइन को पैकेज नहीं करते हैं।


```
flatpak --user remote-add --if-not-exists flathub https://flathub.org/repo/flathub.flatpakrepo
flatpak --user -y install flathub org.winehq.Wine/x86_64/stable-24.08
```

## रनटाइम निर्भरता:

### फेडोरा 36

`sudo dnf install zenity wine winetricks perl-Image-ExifTool icoutils gnome-terminal wget zstd samba-winbind-clients.x86_64 samba-winbind-clients.i686`

### डेबियन / उबंटू / लिनक्स मिंट

```
sudo dpkg --add-architecture i386 && sudo apt update
sudo apt install zenity wine wine32 wine64 winetricks libimage-exiftool-perl icoutils gnome-terminal wget zstd winbind
```

### सोलस

```
sudo eopkg it zenity wine wine-32bit winetricks perl-image-exiftool icoutils gnome-terminal wget zstd diffutils samba-devel
```

### आर्च लिनक्स / एंडेवरओएस

```
sudo pacman -Sy zenity wine winetricks perl-image-exiftool icoutils gnome-terminal wget \
                lib32-alsa-plugins lib32-libpulse lib32-openal zstd samba
```

#### XBOX संगत कंट्रोलर्स

xbox 360 संगत कंट्रोलर्स के लिए कर्नेल ड्राइवर https://github.com/paroj/xpad से बनाएं और इंस्टॉल करें


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-28

---
<p align="center">
  <img src="res/logo-header.svg" alt="RustDesk - आपका रिमोट डेस्कटॉप"><br>
  <a href="#raw-steps-to-build">बिल्ड</a> •
  <a href="#how-to-build-with-docker">डॉकर</a> •
  <a href="#file-structure">संरचना</a> •
  <a href="#snapshot">स्नैपशॉट</a><br>
  [<a href="docs/README-UA.md">Українська</a>] | [<a href="docs/README-CS.md">česky</a>] | [<a href="docs/README-ZH.md">中文</a>] | [<a href="docs/README-HU.md">Magyar</a>] | [<a href="docs/README-ES.md">Español</a>] | [<a href="docs/README-FA.md">فارسی</a>] | [<a href="docs/README-FR.md">Français</a>] | [<a href="docs/README-DE.md">Deutsch</a>] | [<a href="docs/README-PL.md">Polski</a>] | [<a href="docs/README-ID.md">Indonesian</a>] | [<a href="docs/README-FI.md">Suomi</a>] | [<a href="docs/README-ML.md">മലയാളം</a>] | [<a href="docs/README-JP.md">日本語</a>] | [<a href="docs/README-NL.md">Nederlands</a>] | [<a href="docs/README-IT.md">Italiano</a>] | [<a href="docs/README-RU.md">Русский</a>] | [<a href="docs/README-PTBR.md">Português (Brasil)</a>] | [<a href="docs/README-EO.md">Esperanto</a>] | [<a href="docs/README-KR.md">한국어</a>] | [<a href="docs/README-AR.md">العربي</a>] | [<a href="docs/README-VN.md">Tiếng Việt</a>] | [<a href="docs/README-DA.md">Dansk</a>] | [<a href="docs/README-GR.md">Ελληνικά</a>] | [<a href="docs/README-TR.md">Türkçe</a>] | [<a href="docs/README-NO.md">Norsk</a>]<br>
  <b>हमें आपकी मदद की आवश्यकता है इस README, <a href="https://github.com/rustdesk/rustdesk/tree/master/src/lang">RustDesk UI</a> और <a href="https://github.com/rustdesk/doc.rustdesk.com">RustDesk Doc</a> को आपकी मातृभाषा में अनुवाद करने के लिए</b>
</p>

> [!Caution]
> **दुरुपयोग अस्वीकरण:** <br>
> RustDesk के डेवलपर्स इस सॉफ़्टवेयर के किसी भी अनैतिक या अवैध उपयोग का समर्थन या अनुमोदन नहीं करते हैं। दुरुपयोग, जैसे कि अनधिकृत पहुँच, नियंत्रण या गोपनीयता का उल्लंघन, हमारे दिशानिर्देशों के सख्त खिलाफ है। लेखक एप्लिकेशन के किसी भी दुरुपयोग के लिए जिम्मेदार नहीं हैं।

हमसे चैट करें: [Discord](https://discord.gg/nDceKgxnkV) | [Twitter](https://twitter.com/rustdesk) | [Reddit](https://www.reddit.com/r/rustdesk) | [YouTube](https://www.youtube.com/@rustdesk)

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/I2I04VU09)

एक और रिमोट डेस्कटॉप सॉफ्टवेयर, जो Rust में लिखा गया है। बिना किसी कॉन्फ़िगरेशन के तुरंत काम करता है। आपके डेटा पर आपका पूर्ण नियंत्रण है, सुरक्षा की कोई चिंता नहीं। आप हमारे रेंडेवस/रिले सर्वर का उपयोग कर सकते हैं, [अपना खुद का सेटअप करें](https://rustdesk.com/server), या [अपना खुद का रेंडेवस/रिले सर्वर लिखें](https://github.com/rustdesk/rustdesk-server-demo)।

![image](https://user-images.githubusercontent.com/71636191/171661982-430285f0-2e12-4b1d-9957-4a58e375304d.png)

RustDesk सभी से योगदान का स्वागत करता है। शुरू करने में सहायता के लिए देखें [CONTRIBUTING.md](docs/CONTRIBUTING.md)।

[**सामान्य प्रश्न (FAQ)**](https://github.com/rustdesk/rustdesk/wiki/FAQ)

[**बाइनरी डाउनलोड**](https://github.com/rustdesk/rustdesk/releases)

[**नाइटली बिल्ड**](https://github.com/rustdesk/rustdesk/releases/tag/nightly)

[<img src="https://f-droid.org/badge/get-it-on.png"
    alt="F-Droid पर प्राप्त करें"
    height="80">](https://f-droid.org/en/packages/com.carriez.flutter_hbb)
[<img src="https://flathub.org/api/badge?svg&locale=en"
    alt="Flathub पर प्राप्त करें"
    height="80">](https://flathub.org/apps/com.rustdesk.RustDesk)

## निर्भरताएँ

डेस्कटॉप संस्करण GUI के लिए Flutter या Sciter (अप्रचलित) का उपयोग करते हैं, यह ट्यूटोरियल केवल Sciter के लिए है, क्योंकि यह शुरू करने में आसान और अधिक अनुकूल है। Flutter संस्करण को बिल्ड करने के लिए हमारा [CI](https://github.com/rustdesk/rustdesk/blob/master/.github/workflows/flutter-build.yml) देखें।

कृपया Sciter डायनामिक लाइब्रेरी स्वयं डाउनलोड करें।

[Windows](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.win/x64/sciter.dll) |
[Linux](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.lnx/x64/libsciter-gtk.so) |
[macOS](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.osx/libsciter.dylib)

## बिल्ड करने के कच्चे चरण

- अपने Rust डेवलपमेंट एनवायरनमेंट और C++ बिल्ड एनवायरनमेंट की तैयारी करें

- [vcpkg](https://github.com/microsoft/vcpkg) इंस्टॉल करें, और `VCPKG_ROOT` एनवायरनमेंट वेरिएबल सही से सेट करें

  - Windows: vcpkg install libvpx:x64-windows-static libyuv:x64-windows-static opus:x64-windows-static aom:x64-windows-static
  - Linux/macOS: vcpkg install libvpx libyuv opus aom

- `cargo run` चलाएँ

## [बिल्ड](https://rustdesk.com/docs/en/dev/build/)

## लिनक्स पर कैसे बिल्ड करें

### Ubuntu 18 (Debian 10)

```sh
sudo apt install -y zip g++ gcc git curl wget nasm yasm libgtk-3-dev clang libxcb-randr0-dev libxdo-dev \
        libxfixes-dev libxcb-shape0-dev libxcb-xfixes0-dev libasound2-dev libpulse-dev cmake make \
        libclang-dev ninja-build libgstreamer1.0-dev libgstreamer-plugins-base1.0-dev libpam0g-dev
```

### openSUSE Tumbleweed

```sh
sudo zypper install gcc-c++ git curl wget nasm yasm gcc gtk3-devel clang libxcb-devel libXfixes-devel cmake alsa-lib-devel gstreamer-devel gstreamer-plugins-base-devel xdotool-devel pam-devel
```

### Fedora 28 (CentOS 8)

```sh
sudo yum -y install gcc-c++ git curl wget nasm yasm gcc gtk3-devel clang libxcb-devel libxdo-devel libXfixes-devel pulseaudio-libs-devel cmake alsa-lib-devel gstreamer1-devel gstreamer1-plugins-base-devel pam-devel
```

### Arch (Manjaro)

```sh
sudo pacman -Syu --needed unzip git cmake gcc curl wget yasm nasm zip make pkg-config clang gtk3 xdotool libxcb libxfixes alsa-lib pipewire
```

### vcpkg इंस्टॉल करें

```sh
git clone https://github.com/microsoft/vcpkg
cd vcpkg
git checkout 2023.04.15
cd ..
vcpkg/bootstrap-vcpkg.sh
export VCPKG_ROOT=$HOME/vcpkg
vcpkg/vcpkg install libvpx libyuv opus aom
```

### libvpx ठीक करें (Fedora के लिए)

```sh
cd vcpkg/buildtrees/libvpx/src
cd *
./configure
sed -i 's/CFLAGS+=-I/CFLAGS+=-fPIC -I/g' Makefile
sed -i 's/CXXFLAGS+=-I/CXXFLAGS+=-fPIC -I/g' Makefile
make
cp libvpx.a $HOME/vcpkg/installed/x64-linux/lib/
cd
```

### बिल्ड करें

```sh
curl --proto '=https' --tlsv1.2 -sSf https://sh.rustup.rs | sh
source $HOME/.cargo/env
git clone --recurse-submodules https://github.com/rustdesk/rustdesk
cd rustdesk
mkdir -p target/debug
wget https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.lnx/x64/libsciter-gtk.so
mv libsciter-gtk.so target/debug
VCPKG_ROOT=$HOME/vcpkg cargo run
```

## डॉकर के साथ कैसे बिल्ड करें

रिपॉजिटरी क्लोन करके और डॉकर कंटेनर बनाकर शुरू करें:

```sh
git clone https://github.com/rustdesk/rustdesk
cd rustdesk
git submodule update --init --recursive
docker build -t "rustdesk-builder" .
```

फिर, जब भी आपको एप्लिकेशन बिल्ड करना हो, निम्न कमांड चलाएँ:

```sh
docker run --rm -it -v $PWD:/home/user/rustdesk -v rustdesk-git-cache:/home/user/.cargo/git -v rustdesk-registry-cache:/home/user/.cargo/registry -e PUID="$(id -u)" -e PGID="$(id -g)" rustdesk-builder
```

ध्यान दें कि पहली बिल्ड में डिपेंडेंसी कैश होने से समय लग सकता है, बाद की बिल्ड तेज़ होंगी। यदि आपको बिल्ड कमांड के लिए अलग पैरामीटर देने हैं, तो आप कमांड के अंत में `<OPTIONAL-ARGS>` स्थान पर ऐसा कर सकते हैं। उदाहरण के लिए, यदि आप ऑप्टिमाइज़्ड रिलीज़ संस्करण बनाना चाहते हैं, तो ऊपर दिए गए कमांड के बाद `--release` जोड़ें। परिणामी एक्जीक्यूटेबल आपके सिस्टम के target फोल्डर में उपलब्ध होगा, और इसे चलाया जा सकता है:

```sh
target/debug/rustdesk
```

या, यदि आप रिलीज़ एक्जीक्यूटेबल चला रहे हैं:

```sh
target/release/rustdesk
```

कृपया सुनिश्चित करें कि आप ये कमांड RustDesk रिपॉजिटरी की रूट से चला रहे हैं, अन्यथा एप्लिकेशन आवश्यक संसाधन नहीं खोज पाएगा। ध्यान दें कि अन्य cargo सबकमांड जैसे `install` या `run` इस विधि के माध्यम से वर्तमान में समर्थित नहीं हैं क्योंकि वे प्रोग्राम को कंटेनर के अंदर इंस्टॉल या रन करेंगे, होस्ट पर नहीं।

## फ़ाइल संरचना

- **[libs/hbb_common](https://github.com/rustdesk/rustdesk/tree/master/libs/hbb_common)**: वीडियो कोडेक, कॉन्फ़िग, tcp/udp रैपर, प्रोटोबफ, फ़ाइल ट्रांसफ़र के लिए fs फंक्शंस, और कुछ अन्य उपयोगिता फंक्शंस
- **[libs/scrap](https://github.com/rustdesk/rustdesk/tree/master/libs/scrap)**: स्क्रीन कैप्चर
- **[libs/enigo](https://github.com/rustdesk/rustdesk/tree/master/libs/enigo)**: प्लेटफ़ॉर्म-विशिष्ट कीबोर्ड/माउस नियंत्रण
- **[libs/clipboard](https://github.com/rustdesk/rustdesk/tree/master/libs/clipboard)**: Windows, Linux, macOS के लिए फाइल कॉपी और पेस्ट का इम्प्लीमेंटेशन
- **[src/ui](https://github.com/rustdesk/rustdesk/tree/master/src/ui)**: अप्रचलित Sciter UI (deprecated)
- **[src/server](https://github.com/rustdesk/rustdesk/tree/master/src/server)**: ऑडियो/क्लिपबोर्ड/इनपुट/वीडियो सेवाएँ, और नेटवर्क कनेक्शन
- **[src/client.rs](https://github.com/rustdesk/rustdesk/tree/master/src/client.rs)**: एक पीयर कनेक्शन शुरू करें
- **[src/rendezvous_mediator.rs](https://github.com/rustdesk/rustdesk/tree/master/src/rendezvous_mediator.rs)**: [rustdesk-server](https://github.com/rustdesk/rustdesk-server) से संवाद करें, रिमोट डायरेक्ट (TCP होल पंचिंग) या रिले कनेक्शन का इंतजार करें
- **[src/platform](https://github.com/rustdesk/rustdesk/tree/master/src/platform)**: प्लेटफ़ॉर्म-विशिष्ट कोड
- **[flutter](https://github.com/rustdesk/rustdesk/tree/master/flutter)**: डेस्कटॉप और मोबाइल के लिए Flutter कोड
- **[flutter/web/js](https://github.com/rustdesk/rustdesk/tree/master/flutter/web/v1/js)**: Flutter वेब क्लाइंट के लिए जावास्क्रिप्ट

## स्क्रीनशॉट्स

![कनेक्शन मैनेजर](https://github.com/rustdesk/rustdesk/assets/28412477/db82d4e7-c4bc-4823-8e6f-6af7eadf7651)

![Windows PC से कनेक्टेड](https://github.com/rustdesk/rustdesk/assets/28412477/9baa91e9-3362-4d06-aa1a-7518edcbd7ea)

![फाइल ट्रांसफ़र](https://github.com/rustdesk/rustdesk/assets/28412477/39511ad3-aa9a-4f8c-8947-1cce286a46ad)

![TCP टनलिंग](https://github.com/rustdesk/rustdesk/assets/28412477/78e8708f-e87e-4570-8373-1360033ea6c5)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---
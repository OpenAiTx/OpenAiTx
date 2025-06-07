<p align="center"><img src="https://ohmyzsh.s3.amazonaws.com/omz-ansi-github.png" alt="Oh My Zsh"></p>

Oh My Zsh एक ओपन सोर्स, समुदाय-प्रेरित फ्रेमवर्क है जो आपके [zsh](https://www.zsh.org/) कॉन्फ़िगरेशन को प्रबंधित करता है।

यह थोड़ा नीरस लग सकता है। चलिए फिर से कोशिश करते हैं।

**Oh My Zsh आपको 10x डेवलपर नहीं बनाएगा... लेकिन आप खुद को ऐसा महसूस कर सकते हैं।**

इंस्टॉल होने के बाद, आपका टर्मिनल शेल चर्चा का विषय बन जाएगा _या आपके पैसे वापस!_ कमांड प्रॉम्प्ट में हर कीस्ट्रोक के साथ, आप सैकड़ों शक्तिशाली प्लगइन्स और खूबसूरत थीम्स का लाभ उठा सकते हैं। अजनबी कैफे में आपके पास आकर पूछेंगे, _"यह कमाल है! क्या आप कोई जीनियस हैं?"_

आखिरकार, आपको वह ध्यान मिलने लगेगा जिसकी आपको हमेशा उम्मीद थी। ...या फिर आप इस समय का उपयोग अपने दांतों की फ्लॉसिंग के लिए कर सकते हैं। 😬

अधिक जानने के लिए, [ohmyz.sh](https://ohmyz.sh) पर जाएँ, [@ohmyzsh](https://x.com/ohmyzsh) को X (पहले Twitter) पर फॉलो करें, और [Discord](https://discord.gg/ohmyzsh) पर हमारे साथ जुड़ें।

[![CI](https://github.com/ohmyzsh/ohmyzsh/workflows/CI/badge.svg)](https://github.com/ohmyzsh/ohmyzsh/actions?query=workflow%3ACI)
[![X (formerly Twitter) Follow](https://img.shields.io/twitter/follow/ohmyzsh?label=%40ohmyzsh&logo=x&style=flat)](https://twitter.com/intent/follow?screen_name=ohmyzsh)
[![Mastodon Follow](https://img.shields.io/mastodon/follow/111169632522566717?label=%40ohmyzsh&domain=https%3A%2F%2Fmstdn.social&logo=mastodon&style=flat)](https://mstdn.social/@ohmyzsh)
[![Discord server](https://img.shields.io/discord/642496866407284746)](https://discord.gg/ohmyzsh)
[![Gitpod ready](https://img.shields.io/badge/Gitpod-ready-blue?logo=gitpod)](https://gitpod.io/#https://github.com/ohmyzsh/ohmyzsh)

<details>
<summary>विषय सूची</summary>

- [शुरुआत करें](#getting-started)
  - [ऑपरेटिंग सिस्टम संगतता](#operating-system-compatibility)
  - [पूर्व-आवश्यकताएँ](#prerequisites)
  - [मूल स्थापना](#basic-installation)
    - [मैनुअल निरीक्षण](#manual-inspection)
- [Oh My Zsh का उपयोग करना](#using-oh-my-zsh)
  - [प्लगइन्स](#plugins)
    - [प्लगइन्स सक्षम करना](#enabling-plugins)
    - [प्लगइन्स का उपयोग](#using-plugins)
  - [थीम्स](#themes)
    - [थीम का चयन करना](#selecting-a-theme)
  - [सामान्य प्रश्न](#faq)
- [एडवांस्ड टॉपिक्स](#advanced-topics)
  - [एडवांस्ड स्थापना](#advanced-installation)
    - [कस्टम डायरेक्टरी](#custom-directory)
    - [अनअटेंडेड इंस्टॉल](#unattended-install)
    - [फोर्क्ड रिपोजिटरी से इंस्टॉलेशन](#installing-from-a-forked-repository)
    - [मैनुअल इंस्टॉलेशन](#manual-installation)
  - [इंस्टॉलेशन समस्याएँ](#installation-problems)
  - [कस्टम प्लगइन्स और थीम्स](#custom-plugins-and-themes)
  - [macOS और freeBSD में GNU ls सक्षम करें](#enable-gnu-ls-in-macos-and-freebsd-systems)
  - [उपनाम छोड़ें](#skip-aliases)
  - [Async git प्रॉम्प्ट](#async-git-prompt)
- [अपडेट प्राप्त करना](#getting-updates)
  - [अपडेट्स वर्बोसिटी](#updates-verbosity)
  - [मैनुअल अपडेट्स](#manual-updates)
- [Oh My Zsh को अनइंस्टॉल करना](#uninstalling-oh-my-zsh)
- [मैं Oh My Zsh में योगदान कैसे करूँ?](#how-do-i-contribute-to-oh-my-zsh)
  - [हमें थीम्स न भेजें](#do-not-send-us-themes)
- [योगदानकर्ता](#contributors)
- [हमारा अनुसरण करें](#follow-us)
- [मर्चेंडाइज](#merchandise)
- [लाइसेंस](#license)
- [Planet Argon के बारे में](#about-planet-argon)

</details>

## शुरुआत करें

### ऑपरेटिंग सिस्टम संगतता

| ओएस              | स्थिति |
| :--------------- | :----: |
| Android          |   ✅   |
| freeBSD          |   ✅   |
| LCARS            |   🛸   |
| Linux            |   ✅   |
| macOS            |   ✅   |
| OS/2 Warp        |   ❌   |
| Windows (WSL2)   |   ✅   |

### पूर्व-आवश्यकताएँ

- [Zsh](https://www.zsh.org) इंस्टॉल होना चाहिए (v4.3.9 या उससे नया संस्करण उपयुक्त है, लेकिन हम 5.0.8 या उससे नया पसंद करते हैं)। अगर यह पहले से इंस्टॉल नहीं है (`zsh --version` चलाकर पुष्टि करें), तो यहाँ दिए गए विकी निर्देश देखें: [Installing ZSH](https://github.com/ohmyzsh/ohmyzsh/wiki/Installing-ZSH)
- `curl` या `wget` इंस्टॉल होना चाहिए
- `git` इंस्टॉल होना चाहिए (अनुशंसित v2.4.11 या उच्चतर)

### मूल स्थापना

Oh My Zsh को अपने टर्मिनल में निम्नलिखित कमांड्स में से कोई एक चलाकर इंस्टॉल किया जाता है। आप इसे कमांड-लाइन के जरिए `curl`, `wget` या इसी तरह के किसी अन्य टूल से इंस्टॉल कर सकते हैं।

| विधि      | कमांड                                                                                           |
| :-------- | :------------------------------------------------------------------------------------------------ |
| **curl**  | `sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"` |
| **wget**  | `sh -c "$(wget -O- https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"`   |
| **fetch** | `sh -c "$(fetch -o - https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"` |

वैकल्पिक रूप से, इंस्टॉलर GitHub के बाहर भी उपलब्ध है। यदि आप ऐसे देश (जैसे चीन या भारत में कुछ ISPs) में हैं जहाँ `raw.githubusercontent.com` ब्लॉक है, तो इस यूआरएल का उपयोग करें:

| विधि      | कमांड                                           |
| :-------- | :------------------------------------------------ |
| **curl**  | `sh -c "$(curl -fsSL https://install.ohmyz.sh/)"` |
| **wget**  | `sh -c "$(wget -O- https://install.ohmyz.sh/)"`   |
| **fetch** | `sh -c "$(fetch -o - https://install.ohmyz.sh/)"` |

_ध्यान दें कि कोई भी पूर्व `.zshrc` फाइल का नाम बदलकर `.zshrc.pre-oh-my-zsh` कर दिया जाएगा। इंस्टॉल के बाद, आप अपनी आवश्यक सेटिंग्स को नए `.zshrc` में स्थानांतरित कर सकते हैं।_

#### मैनुअल निरीक्षण

यह अच्छा है कि आप किसी अनजान प्रोजेक्ट की इंस्टॉल स्क्रिप्ट को पहले निरीक्षण करें। आप पहले स्क्रिप्ट को डाउनलोड कर सकते हैं, उसे देख सकते हैं, फिर चला सकते हैं:

```sh
wget https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh
sh install.sh
```

अगर उपरोक्त यूआरएल समय समाप्त हो जाए या काम न करे, तो `https://install.ohmyz.sh` का उपयोग करें।

## Oh My Zsh का उपयोग करना

### प्लगइन्स

Oh My Zsh आपके लिए ढेर सारे प्लगइन्स के साथ आता है। आप [plugins](https://github.com/ohmyzsh/ohmyzsh/tree/master/plugins) डायरेक्टरी और/या [wiki](https://github.com/ohmyzsh/ohmyzsh/wiki/Plugins) में देख सकते हैं कि वर्तमान में क्या उपलब्ध है।

#### प्लगइन्स सक्षम करना

एक बार जब आप कोई प्लगइन (या कई) चुन लेते हैं, तो आपको उन्हें `.zshrc` फाइल में सक्षम करना होगा। यह फाइल आपके `$HOME` डायरेक्टरी में मिलेगी। इसे अपने पसंदीदा टेक्स्ट एडिटर में खोलें और उसमें वह स्थान खोजें जहाँ सभी प्लगइन्स की सूची है।

```sh
vi ~/.zshrc
```

उदाहरण के लिए, यह कुछ ऐसा दिख सकता है:

```sh
plugins=(
  git
  bundler
  dotenv
  macos
  rake
  rbenv
  ruby
)
```

_ध्यान दें कि प्लगइन्स को व्हाइटस्पेस (स्पेस, टैब, नई लाइन...) से अलग किया गया है। **कोमा** का उपयोग न करें, इससे यह खराब हो जाएगा।_

#### प्लगइन्स का उपयोग

प्रत्येक बिल्ट-इन प्लगइन के साथ एक **README** शामिल है, जिसमें उसकी जानकारी होती है। इसमें दर्शाया गया है कि कौन से उपनाम (aliases) जोड़े गए हैं और कौन-कौन सी अतिरिक्त सुविधाएँ उपलब्ध हैं।

### थीम्स

हमें स्वीकार है कि Oh My Zsh की शुरुआत में हम थीम्स को लेकर थोड़े ज्यादा उत्साहित हो गए थे। अब हमारे पास एक सौ पचास से अधिक थीम्स बंडल में हैं। इन में से अधिकतर के [स्क्रीनशॉट्स](https://github.com/ohmyzsh/ohmyzsh/wiki/Themes) विकी पर उपलब्ध हैं (हम इन्हें अपडेट कर रहे हैं!)। जरूर देखें!

#### थीम का चयन करना

_डिफ़ॉल्ट थीम Robby की थीम है। यह सबसे शानदार नहीं है, सबसे सरल भी नहीं है। यह बस सही है (उनके लिए)।_

एक बार जब आप अपनी पसंद की थीम खोज लें, तो आपको `~/.zshrc` फाइल को एडिट करना होगा। वहां एक एनवायरनमेंट वेरिएबल (पूरी तरह कैपिटल में) मिलेगा, जो ऐसा दिखता है:

```sh
ZSH_THEME="robbyrussell"
```

किसी दूसरी थीम का उपयोग करने के लिए, बस वैल्यू को अपनी पसंदीदा थीम के नाम से बदल दें। उदाहरण:

```sh
ZSH_THEME="agnoster" # (यह शानदार थीम्स में से एक है)
# देखें https://github.com/ohmyzsh/ohmyzsh/wiki/Themes#agnoster
```

<!-- prettier-ignore-start -->
> [!NOTE]
> आप कई बार किसी zsh थीम का स्क्रीनशॉट देखेंगे, उसे आजमाएँगे, और पाएंगे कि वह आपके यहाँ वैसी नहीं दिखती।
>
> ऐसा इसलिए है क्योंकि कई थीम्स को ठीक से रेंडर करने के लिए [Powerline Font](https://github.com/powerline/fonts) या [Nerd Font](https://github.com/ryanoasis/nerd-fonts) इंस्टॉल करना आवश्यक है। इनके बिना, ये थीम्स अजीब प्रतीक दिखाएँगी। अधिक जानकारी के लिए [FAQ](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#i-have-a-weird-character-in-my-prompt) देखें।
>
> साथ ही, ध्यान दें कि थीम्स केवल आपके प्रॉम्प्ट की उपस्थिति को नियंत्रित करती हैं। यानी, आपके कर्सर के पहले या बाद में दिखाई देने वाला टेक्स्ट, जहाँ आप कमांड टाइप करते हैं। थीम्स आपके टर्मिनल विंडो के रंग (जिन्हें _color scheme_ कहा जाता है) या फॉन्ट को नियंत्रित नहीं करतीं। इन्हें आप अपने टर्मिनल एमुलेटर की सेटिंग्स में बदल सकते हैं। अधिक जानकारी के लिए देखें [zsh थीम क्या है](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#what-is-a-zsh-theme)।
<!-- prettier-ignore-end -->

नई टर्मिनल विंडो खोलें और आपका प्रॉम्प्ट कुछ ऐसा दिखना चाहिए:

![Agnoster theme](https://cloud.githubusercontent.com/assets/2618447/6316862/70f58fb6-ba03-11e4-82c9-c083bf9a6574.png)

अगर आपको अपनी आवश्यकताओं के अनुसार कोई उपयुक्त थीम न मिले, तो कृपया [और थीम्स](https://github.com/ohmyzsh/ohmyzsh/wiki/External-themes) के लिए विकी देखें।

अगर आप चाहें तो हर बार एक नई टर्मिनल विंडो खोलने पर कंप्यूटर को थीम्स में से एक यादृच्छिक रूप से चुनने दें:

```sh
ZSH_THEME="random" # (...कृपया यह pie हो... कृपया pie हो...)
```

और अगर आप अपनी पसंदीदा थीम्स की सूची में से यादृच्छिक रूप से चुनना चाहते हैं:

```sh
ZSH_THEME_RANDOM_CANDIDATES=(
  "robbyrussell"
  "agnoster"
)
```

अगर आप केवल जानते हैं कि कौन-कौन सी थीम्स आपको पसंद नहीं, तो उन्हें ऐसे ही अनदेखा सूची में जोड़ सकते हैं:

```sh
ZSH_THEME_RANDOM_IGNORED=(pygmalion tjkirch_mod)
```

### सामान्य प्रश्न

अगर आपके पास और सवाल हैं या समस्या है, तो संभवतः आपको इसका हल हमारे [FAQ](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ) में मिल जाए।

## एडवांस्ड टॉपिक्स

अगर आप उन लोगों में हैं जो खुद हाथ गंदे करने का शौक रखते हैं, तो ये सेक्शन आपके लिए हैं।

### एडवांस्ड स्थापना

कुछ यूज़र्स Oh My Zsh को मैन्युअली इंस्टॉल करना चाहते हैं, या डिफ़ॉल्ट पाथ या अन्य सेटिंग्स बदलना चाहते हैं जिन्हें इंस्टॉलर स्वीकार करता है (ये सेटिंग्स इंस्टॉल स्क्रिप्ट के टॉप पर भी बताई गई हैं)।

#### कस्टम डायरेक्टरी

डिफ़ॉल्ट लोकेशन `~/.oh-my-zsh` है (यह आपके होम डायरेक्टरी में छुपा होता है, आप इसे `cd ~/.oh-my-zsh` से एक्सेस कर सकते हैं)।

अगर आप `ZSH` एनवायरनमेंट वेरिएबल के साथ इंस्टॉल डायरेक्टरी बदलना चाहें, तो या तो इंस्टॉल से पहले `export ZSH=/your/path` चलाएँ, या इंस्टॉल पाइपलाइन के अंत में इसे सेट करें:

```sh
ZSH="$HOME/.dotfiles/oh-my-zsh" sh install.sh
```

#### अनअटेंडेड इंस्टॉल

अगर आप Oh My Zsh की इंस्टॉल स्क्रिप्ट को ऑटोमेटेड इंस्टॉल का हिस्सा बना रहे हैं, तो `install.sh` स्क्रिप्ट में `--unattended` फ्लैग पास कर सकते हैं। इससे डिफ़ॉल्ट शेल बदलने की कोशिश नहीं की जाएगी, और इंस्टॉल पूरा होने पर `zsh` नहीं चलेगा।

```sh
sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)" "" --unattended
```

अगर आप चीन, भारत या किसी ऐसे देश में हैं जहाँ `raw.githubusercontent.com` ब्लॉक है, तो आपको `https://install.ohmyz.sh` का उपयोग करना पड़ सकता है।

#### फोर्क्ड रिपोजिटरी से इंस्टॉलेशन

इंस्टॉल स्क्रिप्ट नीचे दिए गए वेरिएबल्स को स्वीकार करती है, जिससे आप किसी अन्य रिपोजिटरी से इंस्टॉल कर सकते हैं:

- `REPO` (डिफ़ॉल्ट: `ohmyzsh/ohmyzsh`): यह `owner/repository` के रूप में होता है। अगर आप यह वेरिएबल सेट करते हैं, तो इंस्टॉलर `https://github.com/{owner}/{repository}` पर रिपोजिटरी ढूंढेगा।

- `REMOTE` (डिफ़ॉल्ट: `https://github.com/${REPO}.git`): यह git रिपोजिटरी क्लोन करने का पूरा URL है। आप इसे तब उपयोग कर सकते हैं जब आप किसी फोर्क से इंस्टॉल करना चाहते हैं जो GitHub पर नहीं है (जैसे GitLab, Bitbucket...) या अगर आप HTTPS की जगह SSH से क्लोन करना चाहते हैं (`git@github.com:user/project.git`)।

  _ध्यान दें: यह `REPO` वेरिएबल सेट करने के साथ संगत नहीं है। यह सेटिंग प्राथमिकता लेगी।_

- `BRANCH` (डिफ़ॉल्ट: `master`): अगर आप डिफ़ॉल्ट ब्रांच बदलना चाहते हैं जिसे क्लोन करते समय चेकआउट किया जाएगा, तो इसका उपयोग करें। यह पुल रिक्वेस्ट के परीक्षण या किसी अन्य ब्रांच के उपयोग के लिए सहायक है।

उदाहरण:

```sh
REPO=apjanke/oh-my-zsh BRANCH=edge sh install.sh
```

#### मैनुअल इंस्टॉलेशन

##### 1. रिपोजिटरी क्लोन करें <!-- omit in toc -->

```sh
git clone https://github.com/ohmyzsh/ohmyzsh.git ~/.oh-my-zsh
```

##### 2. _वैकल्पिक रूप से_, मौजूदा `~/.zshrc` फाइल का बैकअप लें <!-- omit in toc -->

```sh
cp ~/.zshrc ~/.zshrc.orig
```

##### 3. नई Zsh कॉन्फ़िगरेशन फाइल बनाएं <!-- omit in toc -->

आप टेम्पलेट फाइल को कॉपी करके नई zsh कॉन्फ़िग फाइल बना सकते हैं:

```sh
cp ~/.oh-my-zsh/templates/zshrc.zsh-template ~/.zshrc
```

##### 4. अपना डिफ़ॉल्ट शेल बदलें <!-- omit in toc -->

```sh
chsh -s $(which zsh)
```

इस परिवर्तन को देखने के लिए आपको अपने यूज़र सेशन से लॉगआउट कर दोबारा लॉगइन करना होगा।

##### 5. अपनी नई Zsh कॉन्फ़िगरेशन इनिशियलाइज करें <!-- omit in toc -->

नई टर्मिनल विंडो खोलने पर आपकी zsh Oh My Zsh की सेटिंग के साथ लोड होनी चाहिए।

### इंस्टॉलेशन समस्याएँ

अगर इंस्टॉलेशन में कोई समस्या हो, तो यहाँ कुछ सामान्य समाधान दिए गए हैं:

- आपको अपने `PATH` को `~/.zshrc` में बदलने की जरूरत पड़ सकती है, अगर Oh My Zsh पर स्विच करने के बाद कुछ कमांड्स नहीं मिलतीं।
- अगर आपने मैन्युअली इंस्टॉल किया या इंस्टॉल लोकेशन बदली, तो `~/.zshrc` में `ZSH` एनवायरनमेंट वेरिएबल की जाँच करें।

### कस्टम प्लगइन्स और थीम्स

अगर आप डिफ़ॉल्ट व्यवहार को ओवरराइड करना चाहते हैं, तो `custom/` डायरेक्टरी में नई `.zsh` फाइल जोड़ें।

अगर आपके पास कई ऐसी फंक्शन्स हैं जो साथ में अच्छी चलती हैं, तो उन्हें `XYZ.plugin.zsh` फाइल के रूप में `custom/plugins/` डायरेक्टरी में डालें और इस प्लगइन को सक्षम करें।

अगर आप किसी डिफ़ॉल्ट Oh My Zsh प्लगइन की कार्यक्षमता ओवरराइड करना चाहते हैं, तो `custom/plugins/` डायरेक्टरी में उसी नाम का प्लगइन बनाएं, और यह डिफ़ॉल्ट वाले की जगह लोड हो जाएगा।

### macOS और freeBSD में GNU ls सक्षम करें

<a name="enable-gnu-ls"></a>

Oh My Zsh में डिफ़ॉल्ट व्यवहार macOS और FreeBSD में BSD `ls` का उपयोग करना है। अगर GNU `ls` (जैसे `gls` कमांड) इंस्टॉल है, तो आप इसे उपयोग में ला सकते हैं। इसके लिए, `oh-my-zsh.sh` को सोर्स करने से पहले zstyle-बेस्ड सेटिंग का उपयोग करें:

```zsh
zstyle ':omz:lib:theme-and-appearance' gnu-ls yes
```

_ध्यान दें: यह `DISABLE_LS_COLORS=true` के साथ संगत नहीं है_

### उपनाम छोड़ें

<a name="remove-directories-aliases"></a>

अगर आप डिफ़ॉल्ट Oh My Zsh उपनाम (जो `lib/*` फाइल्स में परिभाषित हैं) या प्लगइन उपनाम छोड़ना चाहते हैं, तो नीचे दी गई सेटिंग्स का उपयोग करें `~/.zshrc` फाइल में, **Oh My Zsh लोड होने से पहले**। आवश्यकतानुसार उपनाम छोड़ने के कई तरीके हैं।

```sh
# सभी उपनाम छोड़ें, lib फाइल्स और सक्षम प्लगइन्स में
zstyle ':omz:*' aliases no

# केवल lib फाइल्स में उपनाम छोड़ें
zstyle ':omz:lib:*' aliases no
# केवल directories.zsh lib फाइल में परिभाषित उपनाम छोड़ें
zstyle ':omz:lib:directories' aliases no

# सभी प्लगइन उपनाम छोड़ें
zstyle ':omz:plugins:*' aliases no
# केवल git प्लगइन के उपनाम छोड़ें
zstyle ':omz:plugins:git' aliases no
```

आप इन्हें अन्य तरीकों से भी संयोजित कर सकते हैं, ध्यान रहे कि अधिक विशिष्ट स्कोप को प्राथमिकता मिलती है:

```sh
# सभी प्लगइन उपनाम छोड़ें, लेकिन git प्लगइन के लिए अनुमति दें
zstyle ':omz:plugins:*' aliases no
zstyle ':omz:plugins:git' aliases yes
```

इस फीचर के पिछले संस्करण में नीचे दी गई सेटिंग थी, जिसे अब हटा दिया गया है:

```sh
zstyle ':omz:directories' aliases no
```

अब आप निम्नलिखित का उपयोग कर सकते हैं:

```sh
zstyle ':omz:lib:directories' aliases no
```

#### नोटिस <!-- omit in toc -->

> यह फीचर अभी परीक्षण चरण में है और भविष्य में बदल सकता है। यह अभी zpm या zinit जैसे प्लगइन मैनेजर के साथ संगत नहीं है, जो init स्क्रिप्ट (`oh-my-zsh.sh`) को सोर्स नहीं करते जिसमें यह फीचर लागू है।

> यह फिलहाल "उपनाम" के रूप में परिभाषित फंक्शन्स को नहीं पहचानता। उदाहरण जैसे git प्लगइन के `gccd`, `ggf`, या `ggl` फंक्शन्स।

### Async git प्रॉम्प्ट

Async प्रॉम्प्ट फंक्शन्स एक प्रायोगिक फीचर हैं (3 अप्रैल, 2024 को शामिल), जो Oh My Zsh को प्रॉम्प्ट जानकारी को असिंक्रोनस रूप से रेंडर करने की अनुमति देता है। इससे प्रॉम्प्ट रेंडरिंग की परफॉर्मेंस बेहतर हो सकती है, लेकिन कुछ सेटअप्स के साथ ठीक से काम न करे। अगर आपको इससे समस्या हो रही है, तो आप इसे अपने .zshrc फाइल में Oh My Zsh को सोर्स करने से पहले बंद कर सकते हैं:

```sh
zstyle ':omz:alpha:lib:git' async-prompt no
```

अगर आपकी समस्या यह है कि git प्रॉम्प्ट दिखना बंद हो गया है, तो आप नीचे दी गई सेटिंग आजमा सकते हैं:

```sh
zstyle ':omz:alpha:lib:git' async-prompt force
```

## अपडेट प्राप्त करना

डिफ़ॉल्ट रूप से, आपको हर 2 हफ्ते में अपडेट्स के लिए चेक करने के लिए पूछा जाएगा। आप अपने `~/.zshrc` फाइल में, **Oh My Zsh लोड होने से पहले** निम्नलिखित में से कोई एक लाइन जोड़कर अन्य मोड चुन सकते हैं:

1. बिना पुष्टि के ऑटोमैटिक अपडेट:

   ```sh
   zstyle ':omz:update' mode auto
   ```

2. केवल हर कुछ दिनों में याद दिलाएँ, अगर अपडेट्स उपलब्ध हैं:

   ```sh
   zstyle ':omz:update' mode reminder
   ```

3. ऑटोमैटिक अपडेट पूरी तरह से बंद करने के लिए:

   ```sh
   zstyle ':omz:update' mode disabled
   ```

नोट: आप नीचे दी गई सेटिंग से यह नियंत्रित कर सकते हैं कि Oh My Zsh कितनी बार अपडेट्स के लिए चेक करता है:

```sh
# यह हर 7 दिन में अपडेट्स के लिए चेक करेगा
zstyle ':omz:update' frequency 7
# यह हर बार टर्मिनल खोलने पर चेक करेगा (अनुशंसित नहीं)
zstyle ':omz:update' frequency 0
```

### अपडेट्स वर्बोसिटी

आप निम्नलिखित सेटिंग्स से अपडेट वर्बोसिटी सीमित कर सकते हैं:

```sh
zstyle ':omz:update' verbose default # डिफ़ॉल्ट अपडेट प्रॉम्प्ट

zstyle ':omz:update' verbose minimal # केवल कुछ लाइनें

zstyle ':omz:update' verbose silent # केवल एरर्स
```

### मैनुअल अपडेट्स

अगर आप किसी भी समय अपडेट करना चाहते हैं (शायद किसी ने नया प्लगइन रिलीज़ किया है और आप एक हफ्ता नहीं इंतजार करना चाहते?), तो बस चलाएँ:

```sh
omz update
```

> [!NOTE]
> अगर आप इस प्रक्रिया को किसी स्क्रिप्ट में ऑटोमेट करना चाहते हैं, तो सीधे `upgrade` स्क्रिप्ट को कॉल करें:
>
> ```sh
> $ZSH/tools/upgrade.sh
> ```
>
> अधिक विकल्प के लिए देखें [FAQ: Oh My Zsh को कैसे अपडेट करें?](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#how-do-i-update-oh-my-zsh)।
>
> **`omz update --unattended` का उपयोग हटा दिया गया है, क्योंकि इसके दुष्प्रभाव हैं**।

जादू! 🎉

## Oh My Zsh को अनइंस्टॉल करना

Oh My Zsh सभी के लिए नहीं है। हमें आपकी याद आएगी, लेकिन हम इसे आसान बनाना चाहते हैं।

अगर आप `oh-my-zsh` को अनइंस्टॉल करना चाहते हैं, तो बस कमांड-लाइन से `uninstall_oh_my_zsh` चलाएँ। यह खुद को हटा देगा और आपकी पिछली `bash` या `zsh` कॉन्फ़िगरेशन को बहाल कर देगा।

## मैं Oh My Zsh में योगदान कैसे करूँ?

हमारे अद्भुत समुदाय में भाग लेने से पहले, कृपया [code of conduct](CODE_OF_CONDUCT.md) पढ़ें।

मैं खुद [Zsh](https://www.zsh.org/) का विशेषज्ञ नहीं हूँ और मानता हूँ कि इसमें सुधार की कई संभावनाएँ हैं – अगर आपके पास इसे आसान या तेज़ बनाने के सुझाव हैं, तो फोर्क करें और पुल रिक्वेस्ट भेजें!

हमें पुल रिक्वेस्ट को टेस्ट करने वाले लोगों की भी आवश्यकता है। तो [open issues](https://github.com/ohmyzsh/ohmyzsh/issues) देखें और जहाँ संभव हो मदद करें।

अधिक जानकारी के लिए [Contributing](CONTRIBUTING.md) देखें।

### हमें थीम्स न भेजें

अभी हमारे पास (काफी) थीम्स हैं। कृपया अपनी थीम [external themes](https://github.com/ohmyzsh/ohmyzsh/wiki/External-themes) विकी पेज में जोड़ें।

## योगदानकर्ता

Oh My Zsh का एक जीवंत समुदाय है, जिसमें खुश उपयोगकर्ता और योगदानकर्ता हैं। उनके समय और मदद के बिना यह इतना शानदार नहीं होता।

आप सभी का बहुत धन्यवाद!

<a href="https://github.com/ohmyzsh/ohmyzsh/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=ohmyzsh/ohmyzsh" width="100%"/>
</a>

## हमारा अनुसरण करें

हम सोशल मीडिया पर हैं:

- [@ohmyzsh](https://x.com/ohmyzsh) X (पहले Twitter) पर। आपको फॉलो करना चाहिए।
- [Facebook](https://www.facebook.com/Oh-My-Zsh-296616263819290/) हमें poke करें।
- [Instagram](https://www.instagram.com/_ohmyzsh/) अपनी Oh My Zsh वाली पोस्ट में हमें टैग करें!
- [Discord](https://discord.gg/ohmyzsh) पर हमसे चैट करें!

## मर्चेंडाइज

हमारे पास आपके लिए
[स्टिकर्स, शर्ट्स, और कॉफी मग](https://shop.planetargon.com/collections/oh-my-zsh?utm_source=github)
मौजूद हैं, ताकि आप अपनी Oh My Zsh के प्रति दीवानगी दिखा सकें। फिर से, आप चर्चा का विषय बन जाएंगे!

## लाइसेंस

Oh My Zsh [MIT license](LICENSE.txt) के तहत जारी किया गया है।

## Planet Argon के बारे में

![Planet Argon](https://pa-github-assets.s3.amazonaws.com/PARGON_logo_digital_COL-small.jpg)

Oh My Zsh की शुरुआत [Planet Argon](https://www.planetargon.com/?utm_source=github) टीम ने की थी, जो एक [Ruby on Rails development agency](https://www.planetargon.com/services/ruby-on-rails-development?utm_source=github) है। हमारे [अन्य ओपन सोर्स प्रोजेक्ट्स](https://www.planetargon.com/open-source?utm_source=github) भी देखें।


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---
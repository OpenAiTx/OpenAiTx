# 🍡 scoop-proxy-cn

चीन मुख्य भूमि के उपयोगकर्ताओं के लिए उपयुक्त [Scoop](https://scoop.sh) buckets प्रॉक्सी मिरर रिपॉजिटरी। कई ओपन सोर्स `bucket` रिपॉजिटरी से सिंक्रनाइज़ और अपडेट करता है। जिसमें:

- `sync` शाखा (डिफ़ॉल्ट): कई रिपॉजिटरी के ऐप्स को सिंक्रनाइज़ करता है, लेकिन ghproxy प्रॉक्सी संशोधन नहीं करता। **यह gitee के स्थानीय संशोधित Scoop संस्करण के लिए उपयुक्त है।**
- `main` शाखा: `github release` से डाउनलोड किए गए ऐप के पते को `https://ghfast.top` आधारित प्रॉक्सी डाउनलोड पते में संशोधित करता है। **चूंकि प्रॉक्सी पते अक्सर अस्थिर होते हैं और विफल हो सकते हैं।**

## उपयोग

`spc` ऐप रिपॉजिटरी जोड़ें। [Scoop घरेलू मिरर ऑप्टिमाइज़ेशन रिपॉजिटरी](https://gitee.com/scoop-installer/scoop) के साथ उपयोग के लिए उपयुक्त:

```bash
# bucket जोड़ें, डिफ़ॉल्ट रूप से sync शाखा खींचेगा
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git

# ऐप्स इंस्टॉल करें
scoop install spc/<app_name>
```

यदि केवल Scoop के आधिकारिक संस्करण का उपयोग करना चाहते हैं, तो निम्नलिखित करें, सदस्यता शाखा को `main` में बदलें:

```bash
# spc फ़ोल्डर में जाएं
cd "$env:USERPROFILE\scoop\buckets\spc"
# यदि SCOOP पर्यावरण चर सेट है, तो निम्न कमांड चलाएं
cd "$env:SCOOP\buckets\spc"

# main शाखा पर स्विच करें
git fetch --all
git checkout -b main origin/main
```

## Scoop इंस्टॉलेशन और कॉन्फ़िगरेशन संदर्भ

### तरीका 1: घरेलू कस्टम मिरर आधारित इंस्टॉलेशन (सिफारिश की गई)

Scoop के सोर्स कोड और buckets ऐप्स मुख्य रूप से git के रूप में GitHub पर रखे गए हैं, GitHub तक पहुंच की कठिनाइयों के कारण इंस्टॉलेशन, अपडेट और ऐप डाउनलोडिंग का अनुभव खराब हो जाता है।

नीचे [Scoop घरेलू मिरर ऑप्टिमाइज़ेशन रिपॉजिटरी](https://gitee.com/scoop-installer/scoop) के इंस्टॉलेशन का तरीका बताया गया है।

```bash
# स्क्रिप्ट निष्पादन नीति बदलें, डिफ़ॉल्ट रूप से स्वीकृत
Set-ExecutionPolicy RemoteSigned -scope CurrentUser -Force

# तरीका 1: इंस्टॉल कमांड चलाएं (डिफ़ॉल्ट रूप से उपयोगकर्ता डायरेक्टरी में इंस्टॉल होता है, यदि बदलना हो तो नीचे 'कस्टम इंस्टॉलेशन डायरेक्टरी' कमांड चलाएं)
iwr -useb scoop.201704.xyz | iex


## तरीका 2: कस्टम इंस्टॉलेशन डायरेक्टरी (सुनिश्चित करें कि डायरेक्टरी उपयुक्त हो)
irm scoop.201704.xyz -outfile 'install.ps1'
.\install.ps1 -ScoopDir 'D:\Scoop' -ScoopGlobalDir 'D:\GlobalScoopApps'

# यदि आधिकारिक स्रोत पहले से इंस्टॉल है, तो निम्न कमांड से स्विच करें
scoop config SCOOP_REPO "https://gitee.com/scoop-installer/scoop"

# spc bucket जोड़ें
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git

# नया रिपॉजिटरी पता खींचें
scoop update
```

इस तरीके से इंस्टॉल किया गया scoop कस्टम संशोधन के साथ आता है, जो कस्टम प्रॉक्सी एक्सेलेटर का समर्थन करता है और डिफ़ॉल्ट रूप से `scoop.201704.xyz` प्रॉक्सी का उपयोग करता है।

```bash
# प्रॉक्सी जोड़ें
scoop config URL_PROXY "https://scoop.201704.xyz"

# प्रॉक्सी हटाएं
scoop config rm URL_PROXY
```

### तरीका 2: आधिकारिक रिपॉजिटरी आधारित प्रॉक्सी इंस्टॉलेशन

`PowerShell` खोलें और निम्न कमांड चलाएं:

```bash
# इंस्टॉल करें
Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope CurrentUser
# irm -useb get.scoop.sh | iex
irm https://ghfast.top/raw.githubusercontent.com/lzwme/scoop-proxy-cn/main/install.ps1 | iex

# कॉन्फ़िग करें
scoop config SCOOP_REPO https://ghfast.top/github.com/ScoopInstaller/Scoop

# spc bucket जोड़ें
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git
# spc डायरेक्टरी में जाएं
cd "$env:USERPROFILE\scoop\buckets\spc"
# main शाखा पर स्विच करें
git fetch --all && git checkout -b main origin/main

# मदद दिखाएं
scoop help

# 7zip, aria2, scoop-search इंस्टॉल करें...
scoop install spc/7zip spc/aria2 spc/scoop-search
```

### `scoop-search` के बारे में

`scoop-proxy-cn` रिपॉजिटरी में `1.4w+` ऐप्स सिंक्रनाइज़ किए गए हैं, आधिकारिक PowerShell आधारित `scoop search` कमांड इतना धीमा है कि उपयोग करना मुश्किल है, इसलिए `go` भाषा में विकसित `scoop-search` टूल स्थापित करने और उपयोग करने की सलाह दी जाती है। उदाहरण:

```bash
scoop install scoop-search
# scoop-search का उपयोग करें
scoop-search act
```

## सामान्य समस्याएं

### `aria2` के कारण डाउनलोड विफलता

जब `aria2` इंस्टॉल होता है, तो scoop `aria2` का उपयोग करके फाइल के भागों में डाउनलोड को तेज करता है। लेकिन कुछ प्रॉक्सी पते `aria2` की भागों में डाउनलोड अनुरोधों का समर्थन नहीं करते या उन्हें ब्लॉक करते हैं। इस स्थिति में `aria2` को निम्न कमांड से अक्षम करें:

```bash
scoop config aria2-enabled false
```

### `Hash Check Failed` समस्या

कुछ ऐप्स के डाउनलोड पते नवीनतम रिलीज़ होते हैं, लेकिन साथ ही उनका hash भी सेट होता है। जब नया संस्करण आता है तो `Hash Check Failed` त्रुटि होती है। इस स्थिति में `-s` विकल्प का उपयोग करके hash जाँच को अनदेखा करें। उदाहरण:

```bash
scoop install scoop-search -s
```

### प्रॉक्सी साइट विफल होने पर अपडेट करने का तरीका

Scoop के आधिकारिक संस्करण का उपयोग करते हुए और `main` शाखा सब्सक्राइब होने पर, git रिपॉजिटरी और ऐप डाउनलोड पते प्रॉक्सी साइट से तेज होते हैं। यदि पुराना प्रॉक्सी साइट विफल हो जाता है, तो साइट अपडेट नहीं हो पाएगी। कृपया निम्न कमांड चलाएं:

```bash
# पहले scoop रिपॉजिटरी अपडेट करें
scoop config scoop_repo https://ghfast.top/github.com/ScoopInstaller/Scoop.git

# तरीका 1: spc bucket रिपॉजिटरी अपडेट करें
git -C "$env:USERPROFILE\scoop\buckets\spc" remote set-url origin https://gitee.com/wlzwme/scoop-proxy-cn.git
# यदि buckets के डिफ़ॉल्ट स्थान को बदला गया है, तो निम्न कमांड चलाएं
git -C "$env:SCOOP\buckets\spc" remote set-url origin https://gitee.com/wlzwme/scoop-proxy-cn.git

# तरीका 2: spc bucket हटाएं और फिर से जोड़ें
scoop bucket rm spc
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git
```

## सिंक बकेट्स स्रोत

- [ScoopInstaller/PHP](https://github.com/ScoopInstaller/PHP)
- [ScoopInstaller/Main](https://github.com/ScoopInstaller/Main)
- [ScoopInstaller/Extras](https://github.com/ScoopInstaller/Extras)
- [ScoopInstaller/Java](https://github.com/ScoopInstaller/Java)
- [ScoopInstaller/Versions](https://github.com/ScoopInstaller/Versions)
- [ScoopInstaller/Nirsoft](https://github.com/ScoopInstaller/Nirsoft)
- [ScoopInstaller/Nonportable](https://github.com/ScoopInstaller/Nonportable)
- [renxia/scoop-bucket](https://github.com/renxia/scoop-bucket)
- [scoopcn/scoopcn](https://github.com/scoopcn/scoopcn)
- [rasa/scoops](https://github.com/rasa/scoops)
- [amorphobia/siku](https://github.com/amorphobia/siku)
- [ACooper81/scoop-apps](https://github.com/ACooper81/scoop-apps)
- [kkzzhizhou/scoop-zapps](https://github.com/kkzzhizhou/scoop-zapps)
- [Calinou/scoop-games](https://github.com/Calinou/scoop-games)
- [cderv/r-bucket](https://github.com/cderv/r-bucket)
- [chawyehsu/dorado](https://github.com/chawyehsu/dorado)
- [borger/scoop-galaxy-integrations](https://github.com/borger/scoop-galaxy-integrations)
- [ivaquero/scoopet](https://github.com/ivaquero/scoopet)
- [KNOXDEV/wsl](https://github.com/KNOXDEV/wsl)
- [kodybrown/scoop-nirsoft](https://github.com/kodybrown/scoop-nirsoft)
- [kidonng/sushi](https://github.com/kidonng/sushi)
- [littleli/scoop-clojure](https://github.com/littleli/scoop-clojure)
- [niheaven/scoop-sysinternals](https://github.com/niheaven/scoop-sysinternals)
- [matthewjberger/scoop-nerd-fonts](https://github.com/matthewjberger/scoop-nerd-fonts)
- [TheCjw/scoop-retools](https://github.com/TheCjw/scoop-retools)
- [TheRandomLabs/Scoop-Bucket](https://github.com/TheRandomLabs/Scoop-Bucket)
- [TheRandomLabs/scoop-nonportable](https://github.com/TheRandomLabs/scoop-nonportable)
- [TheRandomLabs/Scoop-Spotify](https://github.com/TheRandomLabs/Scoop-Spotify)
- [Paxxs/Cluttered-bucket](https://github.com/Paxxs/Cluttered-bucket)
- [zhoujin7/tomato](https://github.com/zhoujin7/tomato)
- [HCLonely/my-scoop-bucket](https://github.com/HCLonely/my-scoop-bucket)
- [Weidows-projects/scoop-3rd](https://github.com/Weidows-projects/scoop-3rd)
- [hermanjustnu/scoop-emulators](https://github.com/hermanjustnu/scoop-emulators)
- [everyx/scoop-bucket](https://github.com/everyx/scoop-bucket)
- [borger/scoop-emulators](https://github.com/borger/scoop-emulators)
- [ZvonimirSun/scoop-iszy](https://github.com/ZvonimirSun/scoop-iszy)
- [kiennq/scoop-misc](https://github.com/kiennq/scoop-misc)
- [wzv5/ScoopBucket](https://github.com/wzv5/ScoopBucket)
- [TheRandomLabs/Scoop-Python](https://github.com/TheRandomLabs/Scoop-Python)
- [naderi/scoop-bucket](https://github.com/naderi/scoop-bucket)
- [ViCrack/scoop-bucket](https://github.com/ViCrack/scoop-bucket)
- [42wim/scoop-bucket](https://github.com/42wim/scoop-bucket)
- [akirco/aki-apps](https://github.com/akirco/aki-apps)
- [batkiz/backit](https://github.com/batkiz/backit)
- [iquiw/scoop-bucket](https://github.com/iquiw/scoop-bucket)
- [ygguorun/scoop-bucket](https://github.com/ygguorun/scoop-bucket)
- [seumsc/scoop-seu](https://github.com/seumsc/scoop-seu)
- [cc713/ownscoop](https://github.com/cc713/ownscoop)
- [aoisummer/scoop-bucket](https://github.com/aoisummer/scoop-bucket)
- [yuusakuri/scoop-bucket](https://github.com/yuusakuri/scoop-bucket)
- [hu3rror/scoop-muggle](https://github.com/hu3rror/scoop-muggle)
- [starise/Scoop-Confetti](https://github.com/starise/Scoop-Confetti)
- [dodorz/scoop](https://github.com/dodorz/scoop)
- [SayCV/scoop-cvp](https://github.com/SayCV/scoop-cvp)
- [Qv2ray/mochi](https://github.com/Qv2ray/mochi)
- [Homeland-Community/scoop](https://github.com/Homeland-Community/scoop)
- [jingyu9575/scoop-jingyu9575](https://github.com/jingyu9575/scoop-jingyu9575)
- [couleur-tweak-tips/utils](https://github.com/couleur-tweak-tips/utils)
- [wangzq/scoop-bucket](https://github.com/wangzq/scoop-bucket)
- [jonz94/scoop-sarasa-nerd-fonts](https://github.com/jonz94/scoop-sarasa-nerd-fonts)
- [NyaMisty/scoop_bucket_misty](https://github.com/NyaMisty/scoop_bucket_misty)
- [jfut/scoop-jfut](https://github.com/jfut/scoop-jfut)
- [mogeko/scoop-sysinternals](https://github.com/mogeko/scoop-sysinternals)
- [ChungZH/peach](https://github.com/ChungZH/peach)
- [DoveBoy/Apps](https://github.com/DoveBoy/Apps)
- [Velgus/Scoop-Portapps](https://github.com/Velgus/Scoop-Portapps)
- [starise/Scoop-Gaming](https://github.com/starise/Scoop-Gaming)
- [mo-san/scoop-bucket](https://github.com/mo-san/scoop-bucket)
- [brian6932/dank-scoop](https://github.com/brian6932/dank-scoop)
- [AkariiinMKII/Scoop4kariiin](https://github.com/AkariiinMKII/Scoop4kariiin)
- [littleli/Scoop-littleli](https://github.com/littleli/Scoop-littleli)
- [ChinLong/scoop-customize](https://github.com/ChinLong/scoop-customize)
- [Darkatse/Scoop-KanColle](https://github.com/Darkatse/Scoop-KanColle)
- [aliesbelik/poldi](https://github.com/aliesbelik/poldi)
- [MCOfficer/scoop-bucket](https://github.com/MCOfficer/scoop-bucket)
- [KnotUntied/scoop-fonts](https://github.com/KnotUntied/scoop-fonts)
- [beerpiss/scoop-bucket](https://github.com/beerpiss/scoop-bucket)
- [HUMORCE/nuke](https://github.com/HUMORCE/nuke)
- [AkinoKaede/maple](https://github.com/AkinoKaede/maple)
- [hulucc/bucket](https://github.com/hulucc/bucket)
- [Deide/deide-bucket](https://github.com/Deide/deide-bucket)
- [echoiron/echo-scoop](https://github.com/echoiron/echo-scoop)
- [tetradice/scoop-iyokan-jp](https://github.com/tetradice/scoop-iyokan-jp)

## घोषणा

> [!WARNING]
> इस रिपॉजिटरी में शामिल एप्लिकेशन की जानकारी केवल तृतीय पक्ष रिपॉजिटरी से सिंक्रनाइज़ की गई है, और प्रत्येक की उपयोगिता तथा सुरक्षा की जाँच नहीं की गई है। कृपया इंस्टॉल करने से पहले स्वयं सत्यापन और पहचान करें। यदि कोई उल्लंघन हो तो कृपया issues के माध्यम से सूचित करें।

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---
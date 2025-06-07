![terminal-logos](https://github.com/microsoft/terminal/assets/91625426/333ddc76-8ab2-4eb4-a8c0-4d7b953b1179)

[![Terminal Build Status](https://dev.azure.com/shine-oss/terminal/_apis/build/status%2FTerminal%20CI?branchName=main)](https://dev.azure.com/shine-oss/terminal/_build/latest?definitionId=1&branchName=main)

# Windows Terminal, Console और Command-Line रिपॉजिटरी में आपका स्वागत है

<details>
  <summary><strong>विषय सूची</strong></summary>

- [Windows Terminal स्थापित करना और चलाना](#installing-and-running-windows-terminal)
  - [Microsoft Store \[अनुशंसित\]](#microsoft-store-recommended)
  - [अन्य इंस्टॉल विधियाँ](#other-install-methods)
    - [GitHub के माध्यम से](#via-github)
    - [Windows Package Manager CLI (winget) के माध्यम से](#via-windows-package-manager-cli-aka-winget)
    - [Chocolatey के माध्यम से (अनौपचारिक)](#via-chocolatey-unofficial)
    - [Scoop के माध्यम से (अनौपचारिक)](#via-scoop-unofficial)
- [Windows Terminal Canary स्थापित करना](#installing-windows-terminal-canary)
- [Windows Terminal रोडमैप](#windows-terminal-roadmap)
- [Terminal और Console अवलोकन](#terminal--console-overview)
  - [Windows Terminal](#windows-terminal)
  - [Windows Console Host](#the-windows-console-host)
  - [साझा घटक](#shared-components)
  - [नया Windows Terminal बनाना](#creating-the-new-windows-terminal)
- [संसाधन](#resources)
- [सामान्य प्रश्न (FAQ)](#faq)
  - [मैंने नया टर्मिनल बनाया और चलाया, लेकिन यह पुराने कंसोल जैसा ही दिखता है](#i-built-and-ran-the-new-terminal-but-it-looks-just-like-the-old-console)
- [प्रलेखन](#documentation)
- [योगदान](#contributing)
- [टीम से संवाद करना](#communicating-with-the-team)
- [डेवलपर मार्गदर्शन](#developer-guidance)
- [पूर्व-आवश्यकताएँ](#prerequisites)
- [कोड बनाना](#building-the-code)
  - [PowerShell में बनाना](#building-in-powershell)
  - [Cmd में बनाना](#building-in-cmd)
- [चलाना और डिबग करना](#running--debugging)
  - [कोडिंग मार्गदर्शन](#coding-guidance)
- [आचार संहिता](#code-of-conduct)

</details>

<br />

यह रिपॉजिटरी निम्नलिखित का स्रोत कोड शामिल करती है:

* [Windows Terminal](https://aka.ms/terminal)
* [Windows Terminal Preview](https://aka.ms/terminal-preview)
* Windows कंसोल होस्ट (`conhost.exe`)
* दोनों प्रोजेक्ट्स के बीच साझा किए गए घटक
* [ColorTool](./src/tools/ColorTool)
* [सैंपल प्रोजेक्ट्स](./samples)
  जो दिखाते हैं कि Windows Console API का उपभोग कैसे करें

संबंधित रिपॉजिटरीज में शामिल हैं:

* [Windows Terminal प्रलेखन](https://docs.microsoft.com/windows/terminal)
  ([रिपो: डॉक्स में योगदान करें](https://github.com/MicrosoftDocs/terminal))
* [Console API प्रलेखन](https://github.com/MicrosoftDocs/Console-Docs)
* [Cascadia Code फॉन्ट](https://github.com/Microsoft/Cascadia-Code)

## Windows Terminal स्थापित करना और चलाना

> [!NOTE]
> Windows Terminal के लिए Windows 10 2004 (बिल्ड 19041) या बाद का संस्करण आवश्यक है

### Microsoft Store [अनुशंसित]

[Microsoft Store से Windows Terminal स्थापित करें][store-install-link]।
इससे जब भी हम नया बिल्ड जारी करें, आपको स्वचालित अपग्रेड के साथ हमेशा नवीनतम संस्करण मिलेगा।

यह हमारी पसंदीदा विधि है।

### अन्य इंस्टॉल विधियाँ

#### GitHub के माध्यम से

उन उपयोगकर्ताओं के लिए जो Microsoft Store से Windows Terminal स्थापित नहीं कर सकते,
रिलीज़ किए गए बिल्ड इस रिपॉजिटरी के [Releases
पृष्ठ](https://github.com/microsoft/terminal/releases) से मैन्युअली डाउनलोड किए जा सकते हैं।

`Microsoft.WindowsTerminal_<versionNumber>.msixbundle` फ़ाइल को
**Assets** सेक्शन से डाउनलोड करें। ऐप इंस्टॉल करने के लिए, आप बस
`.msixbundle` फ़ाइल पर डबल-क्लिक कर सकते हैं, और ऐप इंस्टॉलर अपने आप चलना चाहिए। यदि
किसी कारण से यह विफल हो जाता है, तो आप PowerShell प्रॉम्प्ट पर निम्नलिखित कमांड आजमा सकते हैं:

```powershell
# नोट: यदि आप PowerShell 7+ का उपयोग कर रहे हैं, तो कृपया
# Add-AppxPackage का उपयोग करने से पहले
# Import-Module Appx -UseWindowsPowerShell चलाएँ।

Add-AppxPackage Microsoft.WindowsTerminal_<versionNumber>.msixbundle
```

> [!NOTE]
> यदि आप Terminal को मैन्युअली इंस्टॉल करते हैं:
>
> * आपको [VC++ v14 Desktop Framework Package](https://docs.microsoft.com/troubleshoot/cpp/c-runtime-packages-desktop-bridge#how-to-install-and-update-desktop-framework-packages)
>   इंस्टॉल करना पड़ सकता है। यह केवल पुराने Windows 10 बिल्ड पर आवश्यक है और केवल तभी जब आपको framework पैकेज की कमी की त्रुटि मिले।
> * जब नए बिल्ड जारी होंगे, तो Terminal स्वचालित रूप से अपडेट नहीं होगा, इसलिए आपको सभी नवीनतम फिक्स और सुधार प्राप्त करने के लिए नियमित रूप से नवीनतम Terminal रिलीज़ इंस्टॉल करनी होगी!

#### Windows Package Manager CLI (winget) के माध्यम से

[winget](https://github.com/microsoft/winget-cli) उपयोगकर्ता
`Microsoft.WindowsTerminal` पैकेज इंस्टॉल करके नवीनतम Terminal रिलीज़ डाउनलोड और इंस्टॉल कर सकते हैं:

```powershell
winget install --id Microsoft.WindowsTerminal -e
```

> [!NOTE]
> Dependency support WinGet संस्करण [1.6.2631 या बाद के](https://github.com/microsoft/winget-cli/releases) में उपलब्ध है। कृपया सुनिश्चित करें कि आपके पास WinGet क्लाइंट का अपडेटेड वर्शन हो जब आप Terminal का स्टेबल रिलीज़ 1.18 या बाद का इंस्टॉल करें।

#### Chocolatey के माध्यम से (अनौपचारिक)

[Chocolatey](https://chocolatey.org) उपयोगकर्ता
`microsoft-windows-terminal` पैकेज इंस्टॉल करके नवीनतम Terminal रिलीज़ डाउनलोड और इंस्टॉल कर सकते हैं:

```powershell
choco install microsoft-windows-terminal
```

Chocolatey का उपयोग करके Windows Terminal को अपग्रेड करने के लिए, निम्नलिखित चलाएँ:

```powershell
choco upgrade microsoft-windows-terminal
```

यदि पैकेज को इंस्टॉल/अपग्रेड करते समय कोई समस्या आती है, तो कृपया
[Windows Terminal पैकेज
पृष्ठ](https://chocolatey.org/packages/microsoft-windows-terminal) पर जाएँ और
[Chocolatey ट्रायज प्रक्रिया](https://chocolatey.org/docs/package-triage-process) का पालन करें

#### Scoop के माध्यम से (अनौपचारिक)

[Scoop](https://scoop.sh) उपयोगकर्ता
`windows-terminal` पैकेज इंस्टॉल करके नवीनतम Terminal रिलीज़ डाउनलोड और इंस्टॉल कर सकते हैं:

```powershell
scoop bucket add extras
scoop install windows-terminal
```

Scoop का उपयोग करके Windows Terminal को अपडेट करने के लिए, निम्नलिखित चलाएँ:

```powershell
scoop update windows-terminal
```

यदि पैकेज को इंस्टॉल/अपडेट करते समय कोई समस्या आए, तो कृपया
Scoop Extras bucket रिपॉजिटरी के [issues
पृष्ठ](https://github.com/lukesampson/scoop-extras/issues) पर खोजें या रिपोर्ट करें।

---

## Windows Terminal Canary स्थापित करना

Windows Terminal Canary, Windows Terminal का एक नाइटली बिल्ड है। इस बिल्ड में हमारे `main` ब्रांच का नवीनतम कोड होता है, जिससे आपको वे फीचर्स आज़माने का मौका मिलता है, जो बाद में Windows Terminal Preview में आएंगे।

Windows Terminal Canary हमारा सबसे कम स्थिर संस्करण है, इसलिए आप इसमें बग्स पा सकते हैं जिन्हें हमनें अभी तक नहीं खोजा हो।

Windows Terminal Canary एक App Installer वितरण और एक Portable ZIP वितरण के रूप में उपलब्ध है।

App Installer वितरण स्वचालित अपडेट का समर्थन करता है। प्लेटफ़ॉर्म सीमाओं के कारण, यह इंस्टॉलर केवल Windows 11 पर काम करता है।

Portable ZIP वितरण एक पोर्टेबल एप्लिकेशन है। यह स्वचालित रूप से अपडेट नहीं होगा और अपडेट के लिए स्वतः जाँच नहीं करेगा। यह पोर्टेबल ZIP वितरण Windows 10 (19041+) और Windows 11 पर काम करता है।

| वितरण         | आर्किटेक्चर     | लिंक                                                  |
|---------------|:---------------:|-------------------------------------------------------|
| App Installer | x64, arm64, x86 | [डाउनलोड करें](https://aka.ms/terminal-canary-installer) |
| Portable ZIP  | x64             | [डाउनलोड करें](https://aka.ms/terminal-canary-zip-x64)   |
| Portable ZIP  | ARM64           | [डाउनलोड करें](https://aka.ms/terminal-canary-zip-arm64) |
| Portable ZIP  | x86             | [डाउनलोड करें](https://aka.ms/terminal-canary-zip-x86)   |

_[Windows Terminal वितरण के प्रकारों के बारे में और जानें](https://learn.microsoft.com/windows/terminal/distributions)।_

---

## Windows Terminal रोडमैप

Windows Terminal की योजना [यहाँ वर्णित है](/doc/roadmap-2023.md) और जैसे-जैसे प्रोजेक्ट आगे बढ़ेगा, अपडेट की जाएगी।

## Terminal और Console अवलोकन

कृपया कोड में उतरने से पहले नीचे दिए गए अवलोकन को कुछ मिनटों के लिए पढ़ लें:

### Windows Terminal

Windows Terminal कमांड-लाइन उपयोगकर्ताओं के लिए एक नया, आधुनिक, फीचर-सम्पन्न, उत्पादक टर्मिनल एप्लिकेशन है। इसमें Windows कमांड-लाइन समुदाय द्वारा सबसे अधिक अनुरोधित कई फीचर्स शामिल हैं, जैसे टैब्स का समर्थन, रिच टेक्स्ट, ग्लोबलाइजेशन, विन्यास, थीमिंग और स्टाइलिंग आदि।

Terminal को हमारे लक्ष्यों और मानकों को भी पूरा करना होगा ताकि यह तेज़ और कुशल बना रहे, और अधिक मेमोरी या पावर का उपभोग न करे।

### Windows Console Host

Windows Console host, `conhost.exe`, Windows का मूल कमांड-लाइन उपयोगकर्ता अनुभव है। यह Windows की कमांड-लाइन इंफ्रास्ट्रक्चर और Windows Console API सर्वर, इनपुट इंजन, रेंडरिंग इंजन, उपयोगकर्ता प्राथमिकताएँ आदि की मेजबानी भी करता है। इस रिपॉजिटरी में कंसोल होस्ट कोड वही स्रोत है जिससे Windows में `conhost.exe` बनाया जाता है।

2014 में Windows कमांड-लाइन की ज़िम्मेदारी लेने के बाद, टीम ने Console में कई नए फीचर्स जोड़े, जैसे बैकग्राउंड ट्रांसपेरेंसी, लाइन-आधारित चयन, [ANSI / वर्चुअल टर्मिनल सीक्वेंस](https://en.wikipedia.org/wiki/ANSI_escape_code) का समर्थन, [24-बिट रंग](https://devblogs.microsoft.com/commandline/24-bit-color-in-the-windows-console/), एक [Pseudoconsole ("ConPTY")](https://devblogs.microsoft.com/commandline/windows-command-line-introducing-the-windows-pseudo-console-conpty/) आदि।

हालाँकि, क्योंकि Windows Console का मुख्य उद्देश्य पिछड़ा-संगतता बनाए रखना है, हम पिछले कई वर्षों में समुदाय (और टीम) द्वारा चाही गई कई सुविधाएँ जैसे टैब्स, यूनिकोड टेक्स्ट, और इमोजी नहीं जोड़ सके।

इन सीमाओं के कारण हमने नया Windows Terminal बनाया।

> आप कमांड-लाइन के सामान्य विकास, और विशेष रूप से Windows कमांड-लाइन के बारे में [इस ब्लॉग श्रृंखला](https://devblogs.microsoft.com/commandline/windows-command-line-backgrounder/) में पढ़ सकते हैं।

### साझा घटक

Windows Console का ओवरहाल करते हुए, हमने इसके कोडबेस को काफी आधुनिक बनाया, लॉजिकल एंटिटीज़ को मॉड्यूल्स और क्लासेस में साफ-सुथरे ढंग से विभाजित किया, कुछ प्रमुख एक्स्टेंसिबिलिटी पॉइंट्स पेश किए, कई पुराने, स्वयं-निर्मित कलेक्शंस और कंटेनरों को सुरक्षित, अधिक कुशल [STL कंटेनरों](https://docs.microsoft.com/en-us/cpp/standard-library/stl-containers?view=vs-2022) से बदल दिया, और कोड को सरल और सुरक्षित बनाया Microsoft के [Windows Implementation Libraries - WIL](https://github.com/Microsoft/wil) का उपयोग करके।

इस ओवरहाल के परिणामस्वरूप Console के कई मुख्य घटक किसी भी Windows टर्मिनल इम्प्लीमेंटेशन में पुनः उपयोग के लिए उपलब्ध हो गए। इन घटकों में एक नया DirectWrite-आधारित टेक्स्ट लेआउट और रेंडरिंग इंजन, एक टेक्स्ट बफर जो UTF-16 और UTF-8 दोनों को स्टोर करने में सक्षम है, एक VT पार्सर/एमिटर, और भी बहुत कुछ शामिल हैं।

### नया Windows Terminal बनाना

जब हमने नया Windows Terminal एप्लिकेशन बनाने की योजना शुरू की, तो हमने कई दृष्टिकोणों और टेक्नोलॉजी स्टैक्स का अन्वेषण और मूल्यांकन किया। अंततः हमने तय किया कि हमारे लक्ष्य हमारे C++ कोडबेस में निवेश जारी रखने से ही सबसे अच्छे ढंग से पूरे होंगे, जिससे हम ऊपर उल्लिखित कई आधुनिक घटकों को मौजूदा Console और नए Terminal दोनों में पुनः उपयोग कर सकते थे। आगे, हमें यह भी एहसास हुआ कि यह हमें Terminal के मुख्य भाग को स्वयं एक पुनः उपयोग योग्य UI कंट्रोल के रूप में बनाने देगा, जिसे अन्य लोग अपनी खुद की एप्लिकेशन में शामिल कर सकते हैं।

इस कार्य का परिणाम इस रिपॉजिटरी में समाहित है और Windows Terminal एप्लिकेशन के रूप में दिया गया है, जिसे आप Microsoft Store से या [इस रिपॉजिटरी की रिलीज़](https://github.com/microsoft/terminal/releases) से सीधे डाउनलोड कर सकते हैं।

---

## संसाधन

Windows Terminal के बारे में अधिक जानकारी के लिए, आप इनमें से कुछ संसाधनों को उपयोगी और रोचक पा सकते हैं:

* [कमांड-लाइन ब्लॉग](https://devblogs.microsoft.com/commandline)
* [कमांड-लाइन बैकग्राउंडर ब्लॉग श्रृंखला](https://devblogs.microsoft.com/commandline/windows-command-line-backgrounder/)
* Windows Terminal लॉन्च: [Terminal "Sizzle Video"](https://www.youtube.com/watch?v=8gw0rXPMMPE&list=PLEHMQNlPj-Jzh9DkNpqipDGCZZuOwrQwR&index=2&t=0s)
* Windows Terminal लॉन्च: [Build 2019 सत्र](https://www.youtube.com/watch?v=KMudkRcwjCw)
* Run As Radio: [Show 645 - Windows Terminal with Richard Turner](https://www.runasradio.com/Shows/Show/645)
* Azure Devops Podcast: [एपिसोड 54 - Kayla Cinnamon और Rich Turner Windows Terminal टीम पर DevOps के बारे में](http://azuredevopspodcast.clear-measure.com/kayla-cinnamon-and-rich-turner-on-devops-on-the-windows-terminal-team-episode-54)
* Microsoft Ignite 2019 सत्र: [The Modern Windows Command Line: Windows Terminal - BRK3321](https://myignite.techcommunity.microsoft.com/sessions/81329?source=sessions)

---

## सामान्य प्रश्न (FAQ)

### मैंने नया टर्मिनल बनाया और चलाया, लेकिन यह पुराने कंसोल जैसा ही दिखता है

कारण: आप Visual Studio में गलत सॉल्यूशन लॉन्च कर रहे हैं।

समाधान: सुनिश्चित करें कि आप Visual Studio में `CascadiaPackage` प्रोजेक्ट बना और डिप्लॉय कर रहे हैं।

> [!NOTE]
> `OpenConsole.exe` सिर्फ एक लोकली-बिल्ट `conhost.exe` है, क्लासिक Windows Console जो Windows की कमांड-लाइन इंफ्रास्ट्रक्चर की मेजबानी करता है। OpenConsole का उपयोग Windows Terminal द्वारा कमांड-लाइन एप्लिकेशन्स से कनेक्ट होने और संवाद करने के लिए किया जाता है ( [ConPty](https://devblogs.microsoft.com/commandline/windows-command-line-introducing-the-windows-pseudo-console-conpty/) के माध्यम से )।

---

## प्रलेखन

सभी प्रोजेक्ट प्रलेखन [aka.ms/terminal-docs](https://aka.ms/terminal-docs) पर स्थित है। यदि आप प्रलेखन में योगदान देना चाहते हैं, तो कृपया [Windows Terminal Documentation रिपॉजिटरी](https://github.com/MicrosoftDocs/terminal) पर पुल अनुरोध सबमिट करें।

---

## योगदान

हम आपके साथ काम करने के लिए उत्साहित हैं, हमारे अद्भुत समुदाय के साथ, Windows Terminal को बनाने और बेहतर करने के लिए!

***किसी भी फीचर/फिक्स पर काम शुरू करने से पहले***, कृपया हमारे [Contributor's Guide](./CONTRIBUTING.md) को पढ़ें और उसका पालन करें ताकि किसी भी बेकार या डुप्लिकेट प्रयास से बचा जा सके।

## टीम से संवाद करना

टीम से संवाद करने का सबसे आसान तरीका GitHub issues के माध्यम से है।

कृपया नए issues, फीचर रिक्वेस्ट और सुझाव फाइल करें, लेकिन **नया issue बनाने से पहले समान खुले/बंद पूर्व-मौजूद issues को खोजें**।

यदि आप कोई ऐसा सवाल पूछना चाहते हैं जिसे आप एक issue के लायक नहीं मानते (अभी), तो कृपया Twitter के माध्यम से हमसे संपर्क करें:

* Christopher Nguyen, प्रोडक्ट मैनेजर: [@nguyen_dows](https://twitter.com/nguyen_dows)
* Dustin Howett, इंजीनियरिंग लीड: [@dhowett](https://twitter.com/DHowett)
* Mike Griese, वरिष्ठ डेवलपर: [@zadjii@mastodon.social](https://mastodon.social/@zadjii)
* Carlos Zamora, डेवलपर: [@cazamor_msft](https://twitter.com/cazamor_msft)
* पंकज भोजवानी, डेवलपर
* लियोनार्ड हेकर, डेवलपर: [@LeonardHecker](https://twitter.com/LeonardHecker)

## डेवलपर मार्गदर्शन

## पूर्व-आवश्यकताएँ

आप अपना पर्यावरण सेटअप करने के लिए दो तरीकों में से एक का उपयोग कर सकते हैं:

### WinGet कॉन्फ़िगरेशन फ़ाइल का उपयोग करना

रिपॉजिटरी को क्लोन करने के बाद, आप अपने वातावरण को सेटअप करने के लिए [WinGet कॉन्फ़िगरेशन फ़ाइल](https://learn.microsoft.com/en-us/windows/package-manager/configuration/#use-a-winget-configuration-file-to-configure-your-machine) का उपयोग कर सकते हैं। [डिफ़ॉल्ट कॉन्फ़िगरेशन फ़ाइल](.config/configuration.winget) Visual Studio 2022 Community और बाकी आवश्यक टूल्स इंस्टॉल करती है। [.config](.config) डायरेक्टरी में Visual Studio 2022 के Enterprise और Professional संस्करणों के लिए दो अन्य वेरिएंट भी उपलब्ध हैं। डिफ़ॉल्ट कॉन्फ़िगरेशन फ़ाइल चलाने के लिए, आप या तो फ़ाइल को एक्सप्लोरर से डबल-क्लिक कर सकते हैं या निम्नलिखित कमांड चला सकते हैं:

```powershell
winget configure .config\configuration.winget
```

### मैन्युअल कॉन्फ़िगरेशन

* आपको Windows Terminal चलाने के लिए Windows 10 2004 (बिल्ड >= 10.0.19041.0) या बाद का संस्करण चलाना चाहिए
* आपको [Windows सेटिंग्स ऐप में डेवलपर मोड सक्षम करना चाहिए](https://docs.microsoft.com/en-us/windows/uwp/get-started/enable-your-device-for-development) ताकि Windows Terminal को लोकली इंस्टॉल और चला सकें
* आपके पास [PowerShell 7 या बाद का](https://github.com/PowerShell/PowerShell/releases/latest) इंस्टॉल होना चाहिए
* आपके पास [Windows 11 (10.0.22621.0) SDK](https://developer.microsoft.com/en-us/windows/downloads/windows-sdk/) इंस्टॉल होना चाहिए
* आपके पास कम से कम [VS 2022](https://visualstudio.microsoft.com/downloads/) इंस्टॉल होना चाहिए
* आपको VS इंस्टॉलर के माध्यम से निम्नलिखित वर्कलोड्स इंस्टॉल करने होंगे। नोट: VS 2022 में सॉल्यूशन खोलने से [आपको गायब घटकों को अपने आप इंस्टॉल करने के लिए प्रेरित किया जाएगा](https://devblogs.microsoft.com/setup/configure-visual-studio-across-your-organization-with-vsconfig/):
  * C++ के साथ डेस्कटॉप विकास
  * यूनिवर्सल Windows प्लेटफ़ॉर्म विकास
  * **निम्नलिखित व्यक्तिगत घटक**
    * C++ (v143) यूनिवर्सल Windows प्लेटफ़ॉर्म टूल्स
* आपको टेस्ट प्रोजेक्ट्स बनाने के लिए [.NET Framework Targeting Pack](https://docs.microsoft.com/dotnet/framework/install/guide-for-developers#to-install-the-net-framework-developer-pack-or-targeting-pack) इंस्टॉल करनी होगी

## कोड बनाना

OpenConsole.sln को Visual Studio के भीतर या कमांड-लाइन से **/tools** डायरेक्टरी में उपलब्ध स्क्रिप्ट्स और टूल्स का उपयोग करके बनाया जा सकता है:

### PowerShell में बनाना

```powershell
Import-Module .\tools\OpenConsole.psm1
Set-MsBuildDevEnvironment
Invoke-OpenConsoleBuild
```

### Cmd में बनाना

```shell
.\tools\razzle.cmd
bcz
```

## चलाना और डिबग करना

Windows Terminal को VS में डिबग करने के लिए, `CascadiaPackage` (Solution Explorer में) पर राइट क्लिक करें और गुणों में जाएँ। Debug मेनू में, "Application process" और "Background task process" को "Native Only" पर बदलें।

इसके बाद आप <kbd>F5</kbd> दबाकर Terminal प्रोजेक्ट को बना और डिबग कर सकते हैं। सुनिश्चित करें कि आपने या तो "x64" या "x86" प्लेटफ़ॉर्म चुना है - Terminal "Any Cpu" के लिए नहीं बनता (क्योंकि Terminal एक C++ एप्लिकेशन है, C# नहीं)।

> 👉 आप WindowsTerminal.exe को सीधे चलाकर Terminal लॉन्च _नहीं_ कर पाएँगे। क्यों, इसके बारे में अधिक जानकारी के लिए देखें:
> [#926](https://github.com/microsoft/terminal/issues/926),
> [#4043](https://github.com/microsoft/terminal/issues/4043)

### कोडिंग मार्गदर्शन

कृपया हमारे कोडिंग प्रैक्टिस के बारे में नीचे दिए गए संक्षिप्त दस्तावेज़ों की समीक्षा करें।

> 👉 यदि आपको इन डॉक्स में कुछ कमी लगे, तो कृपया रिपॉजिटरी में कहीं भी हमारे किसी भी प्रलेखन फ़ाइल में योगदान करने के लिए स्वतंत्र महसूस करें (या कुछ नए लिखें!)

जैसे-जैसे हम सीखेंगे कि हमें अपने प्रोजेक्ट में प्रभावी योगदानकर्ताओं को क्या देना चाहिए, यह एक प्रगति में काम है।

* [कोडिंग स्टाइल](./doc/STYLE.md)
* [कोड संगठन](./doc/ORGANIZATION.md)
* [हमारे लेगेसी कोडबेस में अपवाद](./doc/EXCEPTIONS.md)
* [WIL में Windows के साथ इंटरफेसिंग के लिए उपयोगी स्मार्ट पॉइंटर्स और मैक्रो](./doc/WIL.md)

---

## आचार संहिता

इस प्रोजेक्ट ने [Microsoft Open Source Code of Conduct][conduct-code] को अपनाया है। अधिक जानकारी के लिए [Code of Conduct FAQ][conduct-FAQ] देखें या [opencode@microsoft.com][conduct-email] पर किसी भी अतिरिक्त प्रश्न या टिप्पणियों के लिए संपर्क करें।

[conduct-code]: https://opensource.microsoft.com/codeofconduct/
[conduct-FAQ]: https://opensource.microsoft.com/codeofconduct/faq/
[conduct-email]: mailto:opencode@microsoft.com
[store-install-link]: https://aka.ms/terminal

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---
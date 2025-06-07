# Microsoft PowerToys

![Microsoft PowerToys के लिए हीरो इमेज](doc/images/overview/PT_hero_image.png)

[PowerToys का उपयोग कैसे करें][usingPowerToys-docs-link] | [डाउनलोड्स और रिलीज़ नोट्स][github-release-link] | [PowerToys में योगदान](#contributing) | [क्या हो रहा है](#whats-happening) | [रोडमैप](#powertoys-roadmap)

## परिचय

Microsoft PowerToys पावर यूज़र्स के लिए विंडोज़ अनुभव को ट्यून और स्ट्रीमलाइन करने के लिए यूटिलिटीज़ का एक सेट है, जिससे उत्पादकता बढ़ती है। [PowerToys ओवरव्यू और यूटिलिटीज़ का उपयोग कैसे करें][usingPowerToys-docs-link] या [Windows विकास परिवेश](https://learn.microsoft.com/windows/dev-environment/overview) के लिए किसी अन्य टूल या संसाधन के लिए, [learn.microsoft.com][usingPowerToys-docs-link] पर जाएं!

|              | वर्तमान यूटिलिटीज़: |              |
|--------------|---------------------|--------------|
| [एडवांस्ड पेस्ट](https://aka.ms/PowerToysOverview_AdvancedPaste) | [ऑलवेज़ ऑन टॉप](https://aka.ms/PowerToysOverview_AoT) | [PowerToys अवेक](https://aka.ms/PowerToysOverview_Awake) |
| [कलर पिकर](https://aka.ms/PowerToysOverview_ColorPicker) | [कमांड नॉट फाउंड](https://aka.ms/PowerToysOverview_CmdNotFound) | [कमांड पैलेट](https://aka.ms/PowerToysOverview_CmdPal) |
| [क्रॉप एंड लॉक](https://aka.ms/PowerToysOverview_CropAndLock) | [एनवायरनमेंट वेरिएबल्स](https://aka.ms/PowerToysOverview_EnvironmentVariables) | [फैंसीज़ोन्स](https://aka.ms/PowerToysOverview_FancyZones) |
| [फाइल एक्सप्लोरर ऐड-ऑन्स](https://aka.ms/PowerToysOverview_FileExplorerAddOns) | [फाइल लॉकस्मिथ](https://aka.ms/PowerToysOverview_FileLocksmith) | [होस्ट्स फाइल एडिटर](https://aka.ms/PowerToysOverview_HostsFileEditor) |
| [इमेज रीसाइज़र](https://aka.ms/PowerToysOverview_ImageResizer) | [कीबोर्ड मैनेजर](https://aka.ms/PowerToysOverview_KeyboardManager) | [माउस यूटिलिटीज़](https://aka.ms/PowerToysOverview_MouseUtilities) |
| [माउस विदाउट बॉर्डर्स](https://aka.ms/PowerToysOverview_MouseWithoutBorders) | [न्यू+](https://aka.ms/PowerToysOverview_NewPlus) | [प्लेन टेक्स्ट के रूप में पेस्ट करें](https://aka.ms/PowerToysOverview_PastePlain) |
| [पीक](https://aka.ms/PowerToysOverview_Peek) | [पावररिनेम](https://aka.ms/PowerToysOverview_PowerRename) | [PowerToys रन](https://aka.ms/PowerToysOverview_PowerToysRun) |
| [क्विक एक्सेंट](https://aka.ms/PowerToysOverview_QuickAccent) | [रजिस्ट्री प्रीव्यू](https://aka.ms/PowerToysOverview_RegistryPreview) | [स्क्रीन रूलर](https://aka.ms/PowerToysOverview_ScreenRuler) |
| [शॉर्टकट गाइड](https://aka.ms/PowerToysOverview_ShortcutGuide) | [टेक्स्ट एक्सट्रैक्टर](https://aka.ms/PowerToysOverview_TextExtractor) | [वर्कस्पेसेज़](https://aka.ms/PowerToysOverview_Workspaces) |
| [ZoomIt](https://aka.ms/PowerToysOverview_ZoomIt) |

## Microsoft PowerToys को इंस्टॉल और चलाना

### आवश्यकताएँ

- Windows 11 या Windows 10 संस्करण 2004 (कोड नाम 20H1 / बिल्ड नंबर 19041) या नया।
- x64 या ARM64 प्रोसेसर
- हमारा इंस्टॉलर निम्नलिखित आइटम इंस्टॉल करेगा:
   - [Microsoft Edge WebView2 Runtime](https://go.microsoft.com/fwlink/p/?LinkId=2124703) बूटस्ट्रैपर। यह नवीनतम संस्करण इंस्टॉल करेगा।

### GitHub के माध्यम से EXE द्वारा [सिफारिश की गई]

[Microsoft PowerToys GitHub रिलीज़ पेज][github-release-link] पर जाएं और नीचे 'Assets' पर क्लिक करें ताकि रिलीज़ में उपलब्ध फाइलें दिख सकें। कृपया अपनी मशीन की आर्किटेक्चर और इंस्टॉल स्कोप के अनुसार उपयुक्त PowerToys इंस्टॉलर का उपयोग करें। अधिकतर के लिए, यह `x64` और प्रति-यूज़र है।

<!-- आइटम जिन्हें हर रिलीज़ में अपडेट करने की आवश्यकता है -->
[github-next-release-work]: https://github.com/microsoft/PowerToys/issues?q=is%3Aissue+milestone%3A%22PowerToys+0.92%22
[github-current-release-work]: https://github.com/microsoft/PowerToys/issues?q=is%3Aissue+milestone%3A%22PowerToys+0.91%22
[ptUserX64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysUserSetup-0.91.1-x64.exe 
[ptUserArm64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysUserSetup-0.91.1-arm64.exe 
[ptMachineX64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysSetup-0.91.1-x64.exe 
[ptMachineArm64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysSetup-0.91.1-arm64.exe
 
|  विवरण   | फाइल नाम | sha256 हैश |
|----------|-----------|-------------|
| प्रति यूज़र - x64       | [PowerToysUserSetup-0.91.1-x64.exe][ptUserX64] | 42EA4A3E8C79A5456476D19E72B3E2AB9393A89C4DC7442EB7EE5A1E3490D38A |
| प्रति यूज़र - ARM64     | [PowerToysUserSetup-0.91.1-arm64.exe][ptUserArm64] | F3F433FE04049F9197411D792AADEBF34E3BE7FE16327BD8B73D2A046ED8BAF6 |
| मशीन वाइड - x64   | [PowerToysSetup-0.91.1-x64.exe][ptMachineX64] | EC4BC3A8625775866B0ED4577CCF83E6EC7B1A0AD267379DDBAF4FE49C7B5BDD |
| मशीन वाइड - ARM64 | [PowerToysSetup-0.91.1-arm64.exe][ptMachineArm64] | 9CB8911008420D0E446AE3D5CE365E447FA4DF9DCF9337F3A80F933C00FC3689 |

यह हमारा पसंदीदा तरीका है।

### Microsoft Store के माध्यम से

[Microsoft Store के PowerToys पेज][microsoft-store-link] से इंस्टॉल करें। आपको [नया Microsoft Store](https://blogs.windows.com/windowsExperience/2021/06/24/building-a-new-open-microsoft-store-on-windows-11/) उपयोग करना होगा, जो Windows 11 और Windows 10 दोनों के लिए उपलब्ध है।

### WinGet के माध्यम से
[WinGet][winget-link] से PowerToys डाउनलोड करें। WinGet के माध्यम से PowerToys को अपडेट करने से वर्तमान इंस्टॉलेशन स्कोप बरकरार रहेगा। PowerToys इंस्टॉल करने के लिए, कमांड लाइन / PowerShell से निम्नलिखित कमांड चलाएँ:

#### यूज़र स्कोप इंस्टॉलर [डिफ़ॉल्ट]
```powershell
winget install Microsoft.PowerToys -s winget
```

#### मशीन-वाइड स्कोप इंस्टॉलर

```powershell
winget install --scope machine Microsoft.PowerToys -s winget
```

### अन्य इंस्टॉल विधियाँ

[कम्युनिटी द्वारा संचालित इंस्टॉल विधियाँ](./doc/unofficialInstallMethods.md) जैसे Chocolatey और Scoop उपलब्ध हैं। यदि ये आपकी पसंदीदा इंस्टॉल सॉल्यूशन हैं, तो आप वहाँ इंस्टॉल निर्देश पा सकते हैं।

## थर्ड-पार्टी रन प्लगइन्स

कम्युनिटी द्वारा बनाए गए [थर्ड-पार्टी प्लगइन्स](./doc/thirdPartyRunPlugins.md) का एक संग्रह है, जो PowerToys के साथ वितरित नहीं होते हैं।

## योगदान

यह प्रोजेक्ट सभी प्रकार के योगदान का स्वागत करता है। कोडिंग फीचर्स / बग फिक्स के अलावा, अन्य मदद के तरीके हैं: स्पेक लेखन, डिजाइन, दस्तावेजीकरण, और बग ढूंढना। हम पावर यूज़र कम्युनिटी के साथ मिलकर ऐसे टूल्स का सेट बनाना चाहते हैं, जो विंडोज़ का अधिकतम लाभ उठाने में आपकी मदद करें।

हम अनुरोध करते हैं कि **किसी फीचर पर काम शुरू करने से पहले जिसे आप योगदान देना चाहते हैं**, कृपया हमारे [Contributor's Guide](CONTRIBUTING.md) को पढ़ें। हम आपके साथ मिलकर सर्वोत्तम दृष्टिकोण तय करने, मार्गदर्शन और मेंटॉरशिप देने, और अनावश्यक या डुप्लिकेट प्रयास से बचने के लिए तैयार हैं।

अधिकांश योगदान के लिए आपको [Contributor License Agreement (CLA)][oss-CLA] से सहमत होना आवश्यक है, जिसमें आप हमें अपने योगदान के उपयोग का अधिकार प्रदान करते हैं और आपके पास ऐसा करने की अनुमति है।

PowerToys के लिए डेवलपमेंट संबंधी मार्गदर्शन के लिए, कृपया [डेवलपर डॉक्युमेंटेशन](/doc/devdocs) पढ़ें, जिसमें सेटअप और कंपाइलिंग का विस्तृत विवरण है।

## क्या हो रहा है

### PowerToys रोडमैप

हमारी [प्राथमिकता वाली रोडमैप][roadmap] जिसमें वे फीचर्स और यूटिलिटीज़ हैं, जिन पर कोर टीम ध्यान केंद्रित कर रही है।

### 0.91 - मई 2025 अपडेट

इस रिलीज़ में हमने नई सुविधाओं, स्थिरता और ऑटोमेशन पर ध्यान केंद्रित किया।

**✨ मुख्य बिंदु**

 - हमने कमांड पैलेट के प्रदर्शन को बहुत बेहतर किया और कई बग्स को ठीक किया। कुछ नई सुविधाएँ जो जोड़ी गईं:
 - कमांड पैलेट में किसी भी फाइल को सर्च करने की क्षमता जोड़ी गई।
 - कमांड पैलेट के ग्लोबल हॉटकी को लो-लेवल कीबोर्ड हुक बनाने की क्षमता जोड़ी गई।
 - वेब सर्च एक्सटेंशन के लिए ओपन URL फॉलबैक कमांड जोड़ा गया, जिससे उपयोगकर्ता सीधे ब्राउज़र में URL खोल सकते हैं।
 - अब आप PT Run और Command Palette के Date and Time प्लगइन्स में कस्टम फॉर्मेट परिभाषित कर सकते हैं। धन्यवाद [@htcfreek](https://github.com/htcfreek)!

### एडवांस्ड पेस्ट

 - एक समस्या को ठीक किया गया जहाँ एडवांस्ड पेस्ट कुछ इंग्लिश लैंग्वेज टैग्स (जैसे en-CA) के लिए OCR इंजन नहीं बना पा रहा था, अब यह यूज़र प्रोफाइल भाषा से OCR इंजन इनिशियलाइज़ करता है। धन्यवाद [@cryolithic](https://github.com/cryolithic)!

### कलर पिकर

 - एक समस्या को ठीक किया गया जहाँ रिसोर्स लीक के कारण हैंग या क्रैश हो रहा था, अब ग्राफिक्स ऑब्जेक्ट को सही तरीके से डिस्पोज़ किया गया। धन्यवाद [@dcog989](https://github.com/dcog989)!
 - एक समस्या को ठीक किया गया जहाँ बैकस्पेस की दबाने पर कलर पिकर बंद हो जाता था, अब केवल फोकस होने पर ही बंद होगा और Escape/Backspace व्यवहार को संरेखित किया गया। धन्यवाद [@PesBandi](https://github.com/PesBandi)!
 - कलर पिकर में Oklab और Oklch कलर फॉर्मेट के लिए सपोर्ट जोड़ा गया। धन्यवाद [@lemonyte](https://github.com/lemonyte)!

### कमांड नॉट फाउंड

 - WinGet Command Not Found स्क्रिप्ट को अपडेट किया गया ताकि केवल उन्हीं एक्सपेरिमेंटल फीचर्स को सक्षम किया जाए जो वास्तव में मौजूद हैं।

### कमांड पैलेट

 - बग टेम्पलेट को अपडेट किया गया ताकि कमांड पैलेट मॉड्यूल शामिल हो।
 - एक समस्या को ठीक किया गया जहाँ टोस्ट विंडो DPI के अनुसार स्केल नहीं होती थी, जिससे डिस्प्ले स्केलिंग के तहत लेआउट समस्याएँ होती थीं।
 - एक समस्या को ठीक किया गया जहाँ Up/Down कीबोर्ड नेविगेशन सेलेक्शन को नहीं बदलता था जब कैरेट पोजीशन 0 पर था, और PT Run v1 जैसी लगातार नेविगेशन जोड़ी गई। धन्यवाद [@davidegiacometti](https://github.com/davidegiacometti)!
 - टाइम और डेट एक्सटेंशन कोड को सरल और स्पष्ट बनाया गया।
 - एक समस्या को ठीक किया गया जहाँ कमांड में कैपिटलाइज़ेशन के कारण माउस पॉइंटर पर जाने में विफलता होती थी, अब कमांड को लोअरकेस में बदलकर हल किया गया।
 - वेब सर्च एक्सटेंशन के लिए ओपन URL फॉलबैक कमांड जोड़ा गया, जिससे उपयोगकर्ता सीधे ब्राउज़र में URL खोल सकते हैं। धन्यवाद [@htcfreek](https://github.com/htcfreek)!
 - CmdPal में सिस्टम ट्रे आइकन को सक्षम/अक्षम करने के लिए सेटिंग जोड़ी गई और Windows 11 के साथ टर्मिनोलॉजी को संरेखित किया गया। धन्यवाद [@davidegiacometti](https://github.com/davidegiacometti)!
 - एक एलियास अपडेट समस्या को ठीक किया गया, अब नया एलियास सेट करने पर पुराना हटा दिया जाता है।
 - GitHub केसिंग संघर्ष को हल किया गया, Exts और exts को नए ext डायरेक्टरी में माइग्रेट किया गया, जिससे सभी प्लेटफ़ॉर्म पर संरचना एक जैसी बनी और पाथ फ्रैगमेंटेशन रोका गया।
 - 'Create New Extension' कमांड में खाली फाइल नाम बनने की समस्या को ठीक किया गया।
 - ग्लोबल हॉटकी को लो-लेवल कीबोर्ड हुक बनाने की क्षमता जोड़ी गई।
 - JUMBO थंबनेल्स के लिए सपोर्ट जोड़ा गया, जिससे हाई-रेजोल्यूशन आइकन तक पहुंच मिल सके।
 - CmdPal के ऑटो-हाइड होने के दौरान MSAL डायलॉग खुले रहने पर क्रैश को रोका गया।
 - पेज लोड होने पर तुरंत सर्च टेक्स्ट को चुनने के लिए सपोर्ट जोड़ा गया।
 - एक्सटेंशन सेटिंग्स पेज के दोबारा खुलने पर फेल होने की समस्या को ठीक किया गया।
 - रनर से कमांड पैलेट लॉन्च न होने की समस्या को ठीक किया गया।
 - PowerToys Run v1 कैलकुलेटर लॉजिक को कमांड पैलेट में पोर्ट व रीफैक्टर किया गया, सेटिंग्स सपोर्ट जोड़ा गया और फॉलबैक व्यवहार को बेहतर किया गया।
 - लिस्ट आइटम कीबोर्ड शॉर्टकट्स के लिए सपोर्ट दोबारा जोड़ा गया।
 - कमांड पैलेट की एक्सेसिबिलिटी बढ़ाई गई, सही लेबल, एनिमेशन, लोकलाइज़ेशन और a11y से संबंधित बग्स ठीक किए।
 - टाइम और डेट प्लगइन में कस्टम फॉर्मेट सपोर्ट पोर्ट किया गया, सेटिंग्स का क्रम बदला गया, एरर मैसेजिंग सुधारी गई, और क्रैश के केस ठीक किए गए। धन्यवाद [@htcfreek](https://github.com/htcfreek)!
 - सिस्टम कमांड के लिए फॉलबैक आइटम जोड़ा गया।
 - विंडोज़ सिस्टम कमांड में 'Open Recycle Bin' एक्शन के लिए 'Empty' की प्रॉम्प्ट दिखने का बग ठीक किया गया। धन्यवाद [@jironemo](https://github.com/jironemo)!
 - 'more commands' लिस्ट में उन कमांड्स के दिखने की समस्या ठीक की गई, जिन्हें नहीं दिखना चाहिए था। धन्यवाद [@davidegiacometti](https://github.com/davidegiacometti)!
 - डिटेल्स व्यू में ओवरसाइज़्ड आइकन और मिसएलाइंड टेक्स्ट की समस्या ठीक की गई, जिससे यह Windows Search जैसा दिखे।
 - लंबे लेबल्स के कारण स्क्रीन कंटेंट और कमांड बार कट जाने की समस्या को ठीक किया गया।
 - WinGet इंटीग्रेशन को सुधारते हुए, इंस्टॉल्ड पैकेजेस का वर्शन डिस्प्ले, अपडेट्स, और प्रीव्यू विंगेट API को स्थिर संस्करण में माइग्रेट किया गया।
 - ContentPage के लिए कमांड्स का अपडेट न होने की समस्या को ठीक किया गया।
 - TimeDate एक्सटेंशन में फॉलबैक सपोर्ट जोड़ा गया, जिससे सीधे तारीख/समय क्वेरी की जा सके।
 - CmdPal प्रोजेक्ट फाइल्स में Common.Dotnet.AotCompatibility.props का इम्पोर्ट जोड़ा गया।
 - CmdPal सेटिंग्स में HotKey न मिलने पर क्रैश की समस्या को ठीक किया गया। धन्यवाद [@davidegiacometti](https://github.com/davidegiacometti)!
 - CmdPal में फिल्टर योग्य, नेस्टेड कॉन्टेक्स्ट मेनू और सर्च बॉक्स के लिए सपोर्ट जोड़ा गया।
 - CmdPal क्लासेस को JSON सीरियलाइजेशन के लिए रिफैक्टर किया गया।
 - Ahead-of-time (AoT) कम्पाइलेशन के लिए सपोर्ट जोड़ा गया।
 - CmdPal लॉन्च के लिए रिट्राई मेकेनिज्म जोड़ा गया।
 - CmdPal.Common से कुछ अप्रयुक्त फाइलें हटाईं।
 - SearchText अपडेट के दौरान रेस कंडीशन के कारण इनपुट बॉक्स में करसर के ऑटो-जंप की समस्या को ठीक किया गया।
 - फॉलबैक कमांड में किसी भी फाइल को सर्च करने के लिए सपोर्ट जोड़ा गया।
 - AoT संबंधित कोड क्लीनअप किया गया।
 - एक्सटेंशन स्टार्टअप को पैरललाइज़ करके CmdPal लोड टाइम कम किया गया।
 - डिटेल्स पेन को लिस्ट खाली होने पर डिसमिस करने के लिए UI व्यवहार सुधारा गया।
 - CmdPal में कोई मिलान कमांड न मिलने पर फॉलबैक कमांड को अनसेट करने के लिए सपोर्ट जोड़ा गया।
 - CmdPal एक्सटेंशन टेम्प्लेट में ComServer के अनुचित उपयोग से लीक की समस्या ठीक की गई।
 - CmdPal विंडो को टाइटल बार डबल-क्लिक पर मैक्सिमाइज़ होने से रोका गया। धन्यवाद [@davidegiacometti](https://github.com/davidegiacometti)!
 - सेटिंग्स UI के छोटे आकार में लॉन्च होने की समस्या ठीक की गई।
 - CmdPal में वाइट फ्लैश और एनिमेशन समस्याएँ ठीक की गईं।
 - सभी एक्सटेंशन सेटिंग्स के स्टार्टअप पर फेच होने की समस्या को ठीक किया गया।
 - CmdPal को Adaptive Card parse failure पर क्रैश से बचाने के लिए सपोर्ट जोड़ा गया।
 - CmdPal में shell:AppsFolder को URI activation से बदल दिया गया।
 - PowerToys Settings से CmdPal सेटिंग्स खोलने की क्षमता जोड़ी गई।
 - CmdPal में चयनित आइटम पर प्रॉपर्टी चेंज ट्रैकिंग के माध्यम से एक्सटेंशन विवरण को डायनामिकली अपडेट करने की क्षमता जोड़ी गई।
 - CmdPal एक्सटेंशन टेम्प्लेट में टूलकिट वर्शन को 0.2.0 पर अपग्रेड किया गया।

### इमेज रीसाइज़र

 - इमेज रीसाइज़र प्रीसेट डिलीट करने पर गलत प्रीसेट हटने की समस्या को ठीक किया गया।

### कीबोर्ड मैनेजर

 - एक समस्या को ठीक किया गया जहाँ केवल मोडिफायर की सेट करने पर वह अटक जाता था, अब प्रेस की ट्रैकिंग और सही की भेजी जाती है। धन्यवाद [@mantaionut](https://github.com/mantaionut)!

### पावररिनेम

 - 12-घंटे के समय फॉर्मेट और AM/PM सपोर्ट के साथ टाइम फॉर्मेटिंग को बेहतर बनाया गया। धन्यवाद [@bitmap4](https://github.com/bitmap4)!

### PowerToys रन

 - "Time and Date" प्लगइन में कस्टम फॉर्मेट का समर्थन और अमान्य इनपुट फॉर्मेट के लिए बेहतर एरर संदेश। धन्यवाद [@htcfreek](https://github.com/htcfreek)!
 - WFT के लिए बहुत पुराने दिनांक और महीने के सप्ताह की गणना के लिए बहुत देर से तारीख (जैसे 31.12.9999) पर दो क्रैश को ठीक किया गया। धन्यवाद [@htcfreek](https://github.com/htcfreek)!
 - कमांड के कैपिटलाइज़ेशन के कारण माउस पॉइंटर पर जाने में विफलता को ठीक किया गया।
 - 'Loading error' और 'Init error' के लिए प्लगइन एरर मैसेज में वर्शन डिटेल्स जोड़ी गईं। धन्यवाद [@htcfreek](https://github.com/htcfreek)!
 - परिणाम मॉडल को बेहतर बनाते हुए उपयोग-आधारित ऑर्डरिंग को रोकने के लिए सपोर्ट जोड़ा गया। धन्यवाद [@CoreyHayward](https://github.com/CoreyHayward) और [@htcfreek](https://github.com/htcfreek)!

### क्विक एक्सेंट

 - GetDefaultLetterKeyEPO में "ǔ" को "ŭ" से बदलते हुए VK_U के लिए एस्पेरांतो फ़ोनेटिक्स को सही किया गया। धन्यवाद [@OlegKharchevkin](https://github.com/OlegKharchevkin)!
 - ऑन-स्क्रीन कीबोर्ड का उपयोग करते समय Quick Accent के काम न करने की समस्या को ठीक किया गया। धन्यवाद [@davidegiacometti](https://github.com/davidegiacometti)!

### रजिस्ट्री प्रीव्यू

 - रजिस्ट्री की और वैल्यू को बिना मैन्युअल फाइल हेडर लिखे पेस्ट करने के लिए सपोर्ट और ऐप रिसेट करने के लिए नया बटन जोड़ा गया। धन्यवाद [@htcfreek](https://github.com/htcfreek)!

### सेटिंग्स

 - सेटिंग्स ऐप में टास्कबार पर ब्लैंक आइकन दिखने की समस्या को ठीक किया गया।
 - "What's New" विंडो को अधिक आरामदायक पढ़ाई के लिए मैक्सिमाइज़ करने की क्षमता जोड़ी गई।

### वर्कस्पेसेज़

 - विंडो फ़िल्टरिंग अपडेट और स्टीम URL प्रोटोकॉल हैंडलिंग एकीकृत करके Steam गेम्स के कैप्चर/लॉन्च से संबंधित बग्स को ठीक किया गया।

### दस्तावेजीकरण

 - PowerToys Run के थर्ड-पार्टी प्लगइन्स डाक्युमेंटेशन में QuickNotes जोड़ा गया। धन्यवाद [@ruslanlap](https://github.com/ruslanlap)!
 - Weather और Pomodoro प्लगइन्स को PowerToys Run के थर्ड-पार्टी प्लगइन्स डाक्युमेंटेशन में जोड़ा गया। धन्यवाद [@ruslanlap](https://github.com/ruslanlap)!
 - Linear प्लगइन को PowerToys Run के थर्ड-पार्टी प्लगइन्स डाक्युमेंटेशन में जोड़ा गया। धन्यवाद [@vednig](https://github.com/vednig)!
 - डाक्युमेंटेशन फाइल्स में फॉर्मेटिंग समस्याएँ ठीक की गईं और योगदानकर्ता तथा टीम सदस्य जानकारी अपडेट की गई। धन्यवाद [@DanielEScherzer](https://github.com/DanielEScherzer) और [@RokyZevon](https://github.com/RokyZevon)!

### विकास

 - GitHub Action को .NET 9 इंस्टॉल करने के लिए अपडेट किया गया।
 - bug_report.yml में वर्शन प्लेसहोल्डर को अपडेट किया गया।
 - GitHub Action को actions/setup-dotnet वर्शन 3 से 4 में अपग्रेड किया गया।
 - WinGet कॉन्फ़िगरेशन फाइल्स में securityContext जोड़ा गया, जिससे यूज़र कॉन्टेक्स्ट से इनवोकेशन और एलीवेटेड रिसोर्सेज के लिए एक ही UAC प्रॉम्प्ट मिले। धन्यवाद [@mdanish-kh](https://github.com/mdanish-kh)!
 - लॉग फाइल एक्सटेंशन को .txt से .log में बदला गया और Workspace के लिए लॉग्स जोड़े गए। धन्यवाद [@benwa](https://github.com/benwa)!
 - टेस्टिंग फ्रेमवर्क डिपेंडेंसीज़ और पैकेज वर्शन को संरेखित किया गया।
 - सुरक्षा के लिए डिपेंडेंसीज़ को अपग्रेड किया गया।
 - रिपॉजिटरी सुरक्षा को बढ़ाया गया, GitHub Actions और Docker टैग्स को इम्यूटेबल कमिट्स पर पिन किया और डिपेंडेंसी वल्नरेबिलिटी स्कैनिंग जोड़ी गई। धन्यवाद [@Nick2bad4u](https://github.com/Nick2bad4u)!
 - Boost डिपेंडेंसीज़ को नए वर्शन में अपग्रेड किया गया।
 - टूलकिट को नवीनतम वर्शन में अपग्रेड किया गया और AoT से संबंधित चेतावनियाँ दबाई गईं।
 - नई फाइलें ऐड करने पर साइनिंग न मिलने के कारण बिल्ड फेल्योर की समस्या को ठीक किया गया।
 - रिलीज़ पाइपलाइन को अपडेट किया गया ताकि 100 साल तक प्राइवेट सिंबल्स प्रकाशित न हों।
 - PowerRename के लिए फज़िंग इंट्रोड्यूस किया गया और अन्य C++ मॉड्यूल्स के लिए गाइडेंस जोड़ा गया।
 - सभी .csproj प्रोजेक्ट्स के लिए जनरेटेड फोल्डर का केंद्रीकृत पूर्व-निर्माण जोड़ा गया।
 - WinAppSDK को नवीनतम 1.7 वर्शन में अपडेट किया गया।
 - PowerRename Fuzzing प्रोजेक्ट के लिए Boost डिपेंडेंसीज़ को लेटेस्ट वर्शन पर अपग्रेड किया गया।
 - tsa.json में ADO एरिया पाथ अपडेट किया गया।
 - CmdPal के लिए AoT सपोर्ट की नींव डाली गई।

### टूल/जनरल

 - बग रिपोर्ट ऑटोमेशन के लिए सिस्टम और डायग्नोस्टिक जानकारी के साथ प्री-फिल्ड GitHub इश्यू URL जनरेट करने के लिए सपोर्ट जोड़ा गया। धन्यवाद [@donlaci](https://github.com/donlaci)!
 - इंस्टॉलर को लोकल रूप से बनाने के लिए स्क्रिप्ट्स जोड़े गए।
 - हार्डकोडेड पासवर्ड के उपयोग को रोकने और PSScriptAnalyzer सुरक्षा चेतावनी को हल करने के लिए एक्सपोर्ट PFX लॉजिक हटाया गया।
 - सभी C# प्रोजेक्ट्स के लिए Common.Dotnet.CsWinRT.props के उपयोग को लागू करने के लिए PowerShell स्क्रिप्ट और CI इंटीग्रेशन जोड़ा गया।

### संस्करण 0.92 के लिए क्या योजना है

[v0.92][github-next-release-work] के लिए, हम निम्नलिखित पर काम करेंगे:

 - कमांड पैलेट का और परिष्करण
 - नए UI ऑटोमेशन टेस्ट्स
 - इंस्टॉलर अपग्रेड्स पर कार्य
 - कीबोर्ड मैनेजर के एडिटर UI को अपग्रेड करना
 - स्थिरता / बग फिक्स

## PowerToys कम्युनिटी

PowerToys टीम को [शानदार सक्रिय कम्युनिटी][community-link] का समर्थन पाकर अत्यंत आभार है। आप जो कार्य करते हैं, वह बेहद महत्वपूर्ण है। PowerToys आज जो भी है, उसमें आपकी बग रिपोर्टिंग, डॉक्युमेंटेशन, डिजाइन गाइडेंस, या फीचर लेखन के योगदान के बिना संभव नहीं था। हम आपका धन्यवाद करना चाहते हैं और आपके कार्य को पहचानना चाहते हैं। हर महीने, आप सीधे PowerToys को बेहतर सॉफ्टवेयर बनाने में मदद करते हैं।

## आचार संहिता

इस प्रोजेक्ट ने [Microsoft Open Source Code of Conduct][oss-conduct-code] को अपनाया है।

## गोपनीयता वक्तव्य

एप्लिकेशन मूलभूत डायग्नोस्टिक डेटा (टेलीमेट्री) लॉग करता है। गोपनीयता और हम क्या एकत्र करते हैं, इसकी अधिक जानकारी के लिए [PowerToys डेटा और गोपनीयता डाक्युमेंटेशन](https://aka.ms/powertoys-data-and-privacy-documentation) देखें।

[oss-CLA]: https://cla.opensource.microsoft.com
[oss-conduct-code]: CODE_OF_CONDUCT.md
[community-link]: COMMUNITY.md
[github-release-link]: https://aka.ms/installPowerToys
[microsoft-store-link]: https://aka.ms/getPowertoys
[winget-link]: https://github.com/microsoft/winget-cli#installing-the-client
[roadmap]: https://github.com/microsoft/PowerToys/wiki/Roadmap
[privacy-link]: http://go.microsoft.com/fwlink/?LinkId=521839
[loc-bug]: https://github.com/microsoft/PowerToys/issues/new?assignees=&labels=&template=translation_issue.md&title=
[usingPowerToys-docs-link]: https://aka.ms/powertoys-docs


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---
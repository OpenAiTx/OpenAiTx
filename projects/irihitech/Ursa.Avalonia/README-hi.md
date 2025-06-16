# Ursa

<p align="center">
    <img src="https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/Ursa.svg" alt="drawing" width="150" />
</p>

[![Irihi.Ursa](https://img.shields.io/nuget/v/Irihi.Ursa.svg?color=red&style=flat-square)](https://www.nuget.org/packages/Irihi.Ursa/)
[![Irihi.Ursa](https://img.shields.io/nuget/dt/Irihi.Ursa.svg?style=flat-square)](https://www.nuget.org/packages/Irihi.Ursa/)
[![GitCode](https://gitcode.com/IRIHI_Technology/Ursa.Avalonia/star/badge.svg)](https://gitcode.com/IRIHI_Technology/Ursa.Avalonia)

Ursa एक एंटरप्राइज़ स्तर की UI लाइब्रेरी है, जिसका उपयोग Avalonia UI के साथ क्रॉस-प्लेटफ़ॉर्म एप्लिकेशन बनाने के लिए किया जाता है।

![Demo](https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/dark-demo.jpg)

## .NET Foundation

यह प्रोजेक्ट [.NET Foundation](https://dotnetfoundation.org) द्वारा समर्थित है।

## शुरुआत करें

1. Ursa

Nuget पैकेज जोड़ें:
```bash
dotnet add package Irihi.Ursa
```

2. Ursa.Themes.Semi

Ursa नियंत्रणों को अपने एप्लिकेशन में दिखाने के लिए, आपको Ursa के लिए डिज़ाइन किए गए थीम पैकेज को संदर्भित करना होगा।
Ursa.Themes.Semi, Semi Design से प्रेरित Ursa के लिए एक थीम पैकेज है। आप इसे निम्नलिखित चरणों द्वारा अपने प्रोजेक्ट में जोड़ सकते हैं।

Nuget पैकेज जोड़ें:
```bash
dotnet add package Semi.Avalonia
dotnet add package Irihi.Ursa.Themes.Semi
```

एप्लिकेशन में स्टाइल्स शामिल करें:
```xaml
<Application...
    xmlns:semi="https://irihi.tech/semi"
    xmlns:u-semi="https://irihi.tech/ursa/themes/semi"
    ....>

    <Application.Styles>
        <semi:SemiTheme Locale="zh-CN" />
        <u-semi:SemiTheme Locale="zh-CN"/>
    </Application.Styles>
```

अब आप अपनी Avalonia एप्लिकेशन में Ursa नियंत्रणों का उपयोग कर सकते हैं।
```xaml
<Window
    ...
    xmlns:u="https://irihi.tech/ursa"
    ...>
    <StackPanel Margin="20">
        <u:TagInput />
    </StackPanel>
</Window>
```

## आचार संहिता

इस प्रोजेक्ट ने Contributor Covenant द्वारा परिभाषित आचार संहिता को अपनाया है, ताकि हमारे समुदाय में अपेक्षित व्यवहार को स्पष्ट किया जा सके।
अधिक जानकारी के लिए देखें [.NET Foundation Code of Conduct](https://dotnetfoundation.org/code-of-conduct)।

## अनुकूलता सूचना
Ursa वर्तमान में Avalonia 11.1.x और 11.2.x दोनों के साथ संगत है, लेकिन विशेष रूप से Avalonia 11.2.0 का समर्थन नहीं करता है।

## एक्सटेंशन

### Prism एक्सटेंशन
यदि आपको Ursa को Prism.Avalonia के साथ एकीकृत करने की आवश्यकता है, तो आप Irihi.Ursa.PrismExtension पैकेज का उपयोग कर सकते हैं। यह पैकेज Prism flavor के साथ Ursa Dialogs का उपयोग करने के लिए Dialog संबंधित सेवाएं प्रदान करता है।

### ReactiveUI एक्सटेंशन
यदि आपको Ursa को Avalonia.ReactiveUI के साथ एकीकृत करने की आवश्यकता है, तो आप Irihi.Ursa.ReactiveUIExtension पैकेज का उपयोग कर सकते हैं। यह पैकेज UrsaWindow और UrsaView के ReactiveUI संस्करण को लागू करता है। विस्तार से जानकारी के लिए देखें [wiki](https://github.com/irihitech/Ursa.Avalonia/wiki/Ursa-ReactiveUI-extension)।

## सहायता

हम Semi Avalonia और Ursa के लिए सीमित निःशुल्क सामुदायिक सहायता प्रदान करते हैं। कृपया हमारे समूह से FeiShu(Lark) के माध्यम से जुड़ें।

<p>
    <img src="https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/community-support.png" alt="drawing" width="600" />
</p>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-16

---
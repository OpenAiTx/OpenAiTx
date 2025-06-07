<p align="center"><img src="https://massgrave.dev/img/logo_small.png" alt="MAS Logo"></p>

<h1 align="center">Microsoft Activation Scripts (MAS)</h1>

<p align="center">ओपन-सोर्स Windows और Office एक्टिवेटर जिसमें HWID, Ohook, TSforge, KMS38, और Online KMS एक्टिवेशन विधियाँ शामिल हैं, साथ ही उन्नत ट्रबलशूटिंग भी उपलब्ध है।</p>

<hr>
  
## Windows / Office को कैसे एक्टिवेट करें?

### विधि 1 - PowerShell (Windows 8 और उसके बाद के संस्करण) ❤️

1.   **PowerShell खोलें**  
	इसके लिए, Windows key + X दबाएँ, फिर PowerShell या Terminal चुनें।

2.   **नीचे दिया गया कोड कॉपी और पेस्ट करें, फिर एंटर दबाएँ।**  
```
irm https://get.activated.win | iex
```
वैकल्पिक रूप से, आप निम्नलिखित का उपयोग कर सकते हैं (यह भविष्य में बंद कर दिया जाएगा):  
```
irm https://massgrave.dev/get | iex
```

3.   आपको एक्टिवेशन विकल्प दिखाई देंगे। हरे रंग में हाइलाइट किए गए एक्टिवेशन विकल्प चुनें।

4.   बस इतना ही

---

### विधि 2 - पारंपरिक (Windows Vista और उसके बाद के संस्करण)

<details>
  <summary>यहाँ क्लिक करें देखने के लिए</summary>
  
1.   नीचे दिए गए किसी एक लिंक से फाइल डाउनलोड करें:  
`https://github.com/massgravel/Microsoft-Activation-Scripts/archive/refs/heads/master.zip`  
या  
`https://git.activated.win/massgrave/Microsoft-Activation-Scripts/archive/master.zip`
2.   डाउनलोड की गई ज़िप फाइल पर राइट-क्लिक करें और एक्सट्रैक्ट करें।
3.   एक्सट्रैक्टेड फोल्डर में, `All-In-One-Version` नामक फोल्डर खोजें।
4.   `MAS_AIO.cmd` नामक फाइल चलाएँ।
5.   आपको एक्टिवेशन विकल्प दिखाई देंगे। स्क्रीन पर दिए गए निर्देशों का पालन करें।
6.   बस इतना ही।

</details>

---

- **Office for macOS, Visual Studio, RDS CALs, और Windows XP** जैसे अतिरिक्त प्रोडक्ट्स को एक्टिवेट करने के लिए [यहाँ देखें](https://massgrave.dev/unsupported_products_activation)。
- स्क्रिप्ट्स को अनअटेंडेड मोड में चलाने के लिए [यहाँ देखें](https://massgrave.dev/command_line_switches)।

---

### काम नहीं कर रहा ❓

- यदि आप **PowerShell विधि का उपयोग करके MAS लॉन्च नहीं कर पा रहे हैं**, तो ऊपर सूचीबद्ध **विधि 2** देखें।
- यदि MAS लॉन्च हो गया है और स्क्रिप्ट में कोई त्रुटि दिखाई दे रही है, तो नीले रंग में उल्लिखित किसी भी ट्रबलशूटिंग चरण की जाँच करें और उनका पालन करने का प्रयास करें।
- यदि आपको कोई समस्या है, तो कृपया हमसे [यहाँ](https://massgrave.dev/troubleshoot) संपर्क करें।

---

> [!NOTE]
>
> - PowerShell में IRM कमांड किसी निर्दिष्ट URL से स्क्रिप्ट डाउनलोड करता है, और IEX कमांड उसे निष्पादित करता है।
> - कमांड निष्पादित करने से पहले हमेशा URL को दोबारा जाँचें और यदि आप मैन्युअली फाइल डाउनलोड कर रहे हैं तो स्रोत को सत्यापित करें।
> - सावधान रहें, क्योंकि कुछ लोग IRM कमांड में भिन्न URL का उपयोग करके MAS के रूप में मालवेयर फैलाते हैं।

---

```
नवीनतम संस्करण: 3.4
रिलीज़ तिथि: 3-जून-2025
```

### [समस्या समाधान / सहायता](https://massgrave.dev/troubleshoot)
### [मूल Windows & Office डाउनलोड करें](https://massgrave.dev/genuine-installation-media)
### होमपेज - [https://massgrave.dev/](https://massgrave.dev/)

<div align="center">
  
[![1.1]][1]
[![1.2]][2]
[![1.3]][3]

</div>

<div align="center">
  
[![1.4]][4]
[![1.5]][5]
[![1.6]][6]
[![1.7]][7]

</div>

[1.1]: https://massgrave.dev/img/logo_github.png (GitHub)
[1.2]: https://massgrave.dev/img/logo_azuredevops.png (AzureDevOps)
[1.3]: https://massgrave.dev/img/logo_gitea.png (Self-hosted Git)

[1.4]: https://massgrave.dev/img/logo_discord.png (Chat with us without signup)
[1.5]: https://massgrave.dev/img/logo_reddit.png (Reddit)
[1.6]: https://massgrave.dev/img/logo_bluesky.png (Bluesky)
[1.7]: https://massgrave.dev/img/logo_x.png (Twitter)

[1]: https://github.com/massgravel/Microsoft-Activation-Scripts
[2]: https://dev.azure.com/massgrave/_git/Microsoft-Activation-Scripts
[3]: https://git.activated.win/massgrave/Microsoft-Activation-Scripts
[4]: https://discord.gg/j2yFsV5ZVC
[5]: https://www.reddit.com/r/MAS_Activator
[6]: https://bsky.app/profile/massgrave.dev
[7]: https://twitter.com/massgravel

---

<p align="center">प्यार के साथ बनाया गया ❤️</p>

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---
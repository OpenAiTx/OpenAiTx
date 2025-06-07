# इंस्टेंट विंडोज़ 10 और 11 एक्टिवेशन: 40-सेकंड समाधान

[![Readme](https://img.shields.io/badge/README_IN-فارسی-blue?logo=readme)](README-FA.md)  
[![Readme](https://img.shields.io/badge/README_IN-ENGLISH-blue?logo=readme)](README.md)

> इस रिपॉजिटरी में वह तरीका है जिससे विंडोज़ 10 और 11 को 40 सेकंड से कम में एक्टिवेट किया जा सकता है। दोनों तरीकों को होम, होम N, होम सिंगल लैंग्वेज, होम कंट्री स्पेसिफिक, प्रोफेशनल, एजुकेशन और एंटरप्राइज वर्शन के साथ इस्तेमाल किया जा सकता है।

## तरीका 1 (अनुशंसित)  
### इंस्टेंट विंडोज़ एक्टिवेशन (PowerShell) का उपयोग करके  
> [!TIP]
> विंडोज़ 10 और 11 में पावरशेल चलाने के कई तरीके हैं। [^1]

विंडोज़ में पावरशेल खोलने का एक सबसे तेज़ तरीका स्टार्ट मेन्यू सर्च है। आप नीचे दिए गए स्टेप्स फॉलो कर सकते हैं:

<br>

### स्टेप 1  
आपको बस स्टार्ट या सर्च आइकॉन पर क्लिक करना है और सर्च बॉक्स में "PowerShell" टाइप करना है।  
> एक और आसान तरीका: [^2]

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/5a10538a-c8c2-4934-868b-fd8e910f1f9e" width="540px">
</p>  

---
<br>

### स्टेप 2  
अब, आपको `Run as Administrator` पर क्लिक करना है ताकि पावरशेल एडमिनिस्ट्रेटिव प्रिविलेज के साथ खुले।

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/1f25dd2a-16db-4053-a45c-aac6f8a9e470" width="540px">
</p>

---
<br>

### स्टेप 3  
अब, थोड़ी देर रुकें और इस लाइन को `कॉपी` करें:

```CSS
irm https://get.activated.win | iex
```

---
<br>

### स्टेप 4  
अब इसे (राइट-क्लिक से) पेस्ट करें और एंटर की दबाएं। नयी विंडो में आपको कुछ विकल्प मिलेंगे, जिसमें से हमें विकल्प `1` चुनना है और कुछ सेकंड्स इंतजार करना है।

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/0c3689a1-1595-40b3-97e2-041dac423237" width="540px">
</p>

<br>

#### बधाई हो,
आपका विंडोज़ एक्टिवेट हो गया है।  
अब आप एंटर की दबाकर CMD से बाहर निकल सकते हैं और पावरशेल बंद कर सकते हैं, और विंडोज़ एक्टिवेशन मेन्यू चेक कर सकते हैं [^3]

<br><br><br><br><br><br><br><br>

## तरीका 2  
### CMD (कमांड प्रॉम्प्ट) का उपयोग करके इंस्टेंट विंडोज़ एक्टिवेशन

<br>

> [!NOTE]
> याद रहे **इंटरनेट से कनेक्टेड** रहें
>
> VPN **जरूरी नहीं** है

<br>

### स्टेप 1  
सबसे पहले, स्टार्ट या सर्च आइकॉन पर क्लिक करें और सर्च बॉक्स में "CMD" टाइप करें। कमांड प्रॉम्प्ट दिखने के बाद, उसे **एडमिनिस्ट्रेटर** के रूप में चलाएं  
> अन्य आसान तरीके: [^2].

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/88ac970a-f24b-4acc-82c0-f8e7c0b05249" width="480px">
</p>  

---
<br>

### नीचे लाइसेंस कीज़ की सूची है  

|            **Key**            |  **Version**   |
| :---------------------------: | :------------: |
| TX9XD-98N7V-6WMQ6-BX7FG-H8Q99 |      Home      |
| 3KHY7-WNT83-DGQKR-F7HPR-844BM |     Home N     |
| 7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH |  Home sl [^4]  |
| PVMJN-6DFY6–9CCP6–7BKTT-D3WVR |  Home cs [^5]  |
| W269N-WFGWX-YVC9B-4J6C9-T83GX |  Professional  |
| MH37W-N47XK-V7XM9-C7227-GCQG9 | Professional N |
| NW6C2-QMPVW-D7KKK-3GKT6-VCFB2 |   Education    |
| 2WH4N-8QGBV-H22JP-CT43Q-MDWWJ |  Education N   |
| NPPR9-FWDCX-D2C8J-H872K-2YT43 |   Enterprise   |
| DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4 |  Enterprise N  |

![rainbow](https://github.com/NiREvil/vless/assets/126243832/1aca7f5d-6495-44b7-aced-072bae52f256)

<br>

### स्टेप 2  
KMS क्लाइंट की इंस्टॉल करें।

यह कमांड उपयोग करें:

```CSS
slmgr /ipk yourlicensekey
```

> [!NOTE]
> कृपया सूची में से अपनी विंडोज़ वर्शन के अनुसार एक **लाइसेंस की** चुनें और उसे कमांड में `yourlicencekey` की जगह डालें।

> [!TIP]
> विंडोज़ का वर्शन कैसे चेक करें [^3]।

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/1b6401e6-7e63-4351-8a92-fa355dfc30cf" width="480px">
</p>  

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/90037069-7ea3-44a8-a9fa-e296f5e8d47b" width="340px">
</p>  

---
<br>

### स्टेप 3  
KMS मशीन एड्रेस सेट करें।

यह कमांड चलाएं:

```CSS
slmgr /skms kms8.msguides.com
```

मेरे KMS सर्वर से कनेक्ट करने के लिए।

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/9d634454-1c59-47da-874e-bfe575288fe6" width="480px">
</p>  

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/2d2e6cfb-4e85-483f-ae0a-c7157d22da36" width="340px">
</p>  

---  
<br>

### स्टेप 4  
अपने विंडोज़ को एक्टिवेट करें।  
अंतिम स्टेप में नीचे दी गई कमांड से विंडोज़ को एक्टिवेट करें:

```CSS
slmgr /ato
```

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/5e495d42-6ce5-4884-9de2-96a56efb4343" width="480px">
</p>  

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/aecd9cfd-8c09-4433-b410-a62205a8d692" width="240px">
</p>  

---
<br>

### स्टेप 5  
अब फिर से एक्टिवेशन स्टेटस चेक करें [^6]।

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/9ca70137-8e2e-4504-a52d-22f41d959bd7" width="480px">
</p>

#### हो गया ✅  
आपका विंडोज़ सफलतापूर्वक एक्टिवेट हो गया है।

<br>

**जिज्ञासु रहें 🤍**

[![Telegram](https://img.shields.io/badge/TELEGRAM-blue.svg?logo=telegram)](https://t.me/F_NiREvil) [![Twitter](https://img.shields.io/badge/TWITTER-blue.svg?logo=x)](https://twitter.com/NiREvil_)

<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://user-images.githubusercontent.com/25423296/163456776-7f95b81a-f1ed-45f7-b7ab-8fa810d529fa.png">
  <source media="(prefers-color-scheme: light)" srcset="https://user-images.githubusercontent.com/25423296/163456779-a8556205-d0a5-45e2-ac17-42d089e3c3f8.png">
  <img alt="Shows an illustrated sun in light mode and a moon with stars in dark mode." src="https://user-images.githubusercontent.com/25423296/163456779-a8556205-d0a5-45e2-ac17-42d089e3c3f8.png">
</picture>

<br>

[^1]: [विंडोज़ में पावरशेल चलाने के 10 तरीके](https://www.google.com/amp/s/www.minitool.com/news/open-windows-11-powershell.html%3famp)  

[^2]: पावरशेल चलाने का एक और सबसे आसान तरीका: **Start मेनू पर राइट-क्लिक** करें जिससे क्विक लिंक मेन्यू खुलेगा, और लिस्ट में से विंडोज़ 11 में **Windows Terminal (admin)** या विंडोज़ 10 में **Windows powershell (admin)** चुनें।
[^3]: विंडोज़ वर्शन चेक करने के लिए: **Start मेनू पर राइट-क्लिक** करें और **system** ऑप्शन चुनें। आपकी विंडोज़ वर्शन **Edition** सेक्शन में दिख जाएगी। आप तरीका 2 के स्टेप्स को **कॉपी-पेस्ट** करके भी फॉलो कर सकते हैं। कमांड्स को कॉपी करें और फिर **cmd या powershell** में **राइट-क्लिक** से पेस्ट करें।
[^4]: Home Single language वर्शन।
[^5]: Home Country Specific वर्शन।
[^6]: विंडोज़ एक्टिवेशन स्टेटस देखने के लिए आपको जाना होगा:  
***Settings → Update & Security → activation menu.***

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---
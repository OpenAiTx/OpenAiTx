# تفعيل ويندوز 10 و11 الفوري: الحل خلال 40 ثانية

[![Readme](https://img.shields.io/badge/README_IN-فارسی-blue?logo=readme)](README-FA.md)  
[![Readme](https://img.shields.io/badge/README_IN-ENGLISH-blue?logo=readme)](README.md)

> يحتوي هذا المستودع على طريقة يمكنها تفعيل ويندوز 10 و11 في أقل من 40 ثانية. كلا الطريقتين متوافقتان مع إصدارات home، home N، Home single lang، Home country specific، professional، education و enterprise من ويندوز.

## الطريقة الأولى (موصى بها)  
### التفعيل الفوري لويندوز باستخدام (PowerShell)  
> [!TIP]
> لدينا العديد من الطرق لتشغيل PowerShell في ويندوز 10 و11. [^1]

إحدى أسرع الطرق لفتح PowerShell في ويندوز هي البحث من قائمة البدء. يمكنك اتباع الخطوات التالية:

<br>

### الخطوة 1  
كل ما عليك فعله هو الضغط على أيقونة البدء أو البحث وكتابة "PowerShell" في مربع البحث.  
> طريقة سهلة أخرى: [^2]

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/5a10538a-c8c2-4934-868b-fd8e910f1f9e" width="540px">
</p>  

---
<br>

### الخطوة 2  
بعد ذلك، يجب عليك الضغط على `تشغيل كمسؤول` لبدء PowerShell، في هذه الحالة نحتاج لتشغيله بصلاحيات **المسؤول**.

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/1f25dd2a-16db-4053-a45c-aac6f8a9e470" width="540px">
</p>

---
<br>

### الخطوة 3  
الآن، بعد توقف قصير للسماح بالتنفيذ، يرجى `نسخ` هذا السطر:

```CSS
irm https://get.activated.win | iex
```

---
<br>

### الخطوة 4  
الآن الصقها (بالزر الأيمن) واضغط على مفتاح الإدخال. في النافذة الجديدة التي ستظهر، هناك عدة خيارات متاحة، يجب علينا اختيار الخيار `1` والانتظار لعدة ثوانٍ حتى الاكتمال.

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/0c3689a1-1595-40b3-97e2-041dac423237" width="540px">
</p>

<br>

#### تهانينا،
تم تفعيل ويندوز الخاص بك.  
الآن يمكنك الضغط على مفتاح الإدخال للخروج من CMD وإغلاق PowerShell والتحقق من قائمة تفعيل ويندوز [^3]

<br><br><br><br><br><br><br><br>

## الطريقة الثانية  
### التفعيل الفوري لويندوز باستخدام CMD (موجه الأوامر)

<br>

> [!NOTE]
> تذكر **الاتصال** بالإنترنت
>
> لا حاجة لاستخدام **VPN**

<br>

### الخطوة 1  
أولاً، اضغط على أيقونة البدء أو البحث واكتب "CMD" في مربع البحث. وبعد ظهور خيار موجه الأوامر، شغّله كـ **مسؤول**  
> طرق سهلة أخرى: [^2].

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/88ac970a-f24b-4acc-82c0-f8e7c0b05249" width="480px">
</p>  

---
<br>

### القائمة التالية لمفاتيح الترخيص LICENSE KEYS  

|            **المفتاح**            |  **الإصدار**   |
| :-------------------------------: | :------------: |
| TX9XD-98N7V-6WMQ6-BX7FG-H8Q99     |      Home      |
| 3KHY7-WNT83-DGQKR-F7HPR-844BM     |     Home N     |
| 7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH     |  Home sl [^4]  |
| PVMJN-6DFY6–9CCP6–7BKTT-D3WVR     |  Home cs [^5]  |
| W269N-WFGWX-YVC9B-4J6C9-T83GX     |  Professional  |
| MH37W-N47XK-V7XM9-C7227-GCQG9     | Professional N |
| NW6C2-QMPVW-D7KKK-3GKT6-VCFB2     |   Education    |
| 2WH4N-8QGBV-H22JP-CT43Q-MDWWJ     |  Education N   |
| NPPR9-FWDCX-D2C8J-H872K-2YT43     |   Enterprise   |
| DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4     |  Enterprise N  |

![rainbow](https://github.com/NiREvil/vless/assets/126243832/1aca7f5d-6495-44b7-aced-072bae52f256)

<br>

### الخطوة 2  
تثبيت مفتاح عميل KMS.

استخدم هذا الأمر:

```CSS
slmgr /ipk yourlicensekey
```

> [!NOTE]
> يرجى اختيار أحد **مفاتيح الترخيص** من القائمة والذي **يتناسب مع إصدار ويندوز الخاص بك** واستبداله بعبارة `yourlicencekey` في الأمر.

> [!TIP]
> كيفية التحقق من إصدار ويندوز [^3].

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/1b6401e6-7e63-4351-8a92-fa355dfc30cf" width="480px">
</p>  

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/90037069-7ea3-44a8-a9fa-e296f5e8d47b" width="340px">
</p>  

---
<br>

### الخطوة 3  
تعيين عنوان جهاز KMS.

استخدم الأمر:

```CSS
slmgr /skms kms8.msguides.com
```

للاتصال بخادم KMS الخاص بي.

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/9d634454-1c59-47da-874e-bfe575288fe6" width="480px">
</p>  

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/2d2e6cfb-4e85-483f-ae0a-c7157d22da36" width="340px">
</p>  

---  
<br>

### الخطوة 4  
فعّل ويندوز الخاص بك.
الخطوة الأخيرة هي تفعيل ويندوز الخاص بك باستخدام الأمر:

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

### الخطوة 5  
الآن تحقق من حالة التفعيل مرة أخرى [^6].

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/9ca70137-8e2e-4504-a52d-22f41d959bd7" width="480px">
</p>

#### تم ✅  
تم تفعيل ويندوز الخاص بك بنجاح.

<br>

**كن فضولياً 🤍**

[![Telegram](https://img.shields.io/badge/TELEGRAM-blue.svg?logo=telegram)](https://t.me/F_NiREvil) [![Twitter](https://img.shields.io/badge/TWITTER-blue.svg?logo=x)](https://twitter.com/NiREvil_)

<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://user-images.githubusercontent.com/25423296/163456776-7f95b81a-f1ed-45f7-b7ab-8fa810d529fa.png">
  <source media="(prefers-color-scheme: light)" srcset="https://user-images.githubusercontent.com/25423296/163456779-a8556205-d0a5-45e2-ac17-42d089e3c3f8.png">
  <img alt="Shows an illustrated sun in light mode and a moon with stars in dark mode." src="https://user-images.githubusercontent.com/25423296/163456779-a8556205-d0a5-45e2-ac17-42d089e3c3f8.png">
</picture>

<br>

[^1]: [10 طرق لتشغيل PowerShell في ويندوز](https://www.google.com/amp/s/www.minitool.com/news/open-windows-11-powershell.html%3famp)  

[^2]: طريقة أخرى سهلة جداً لتشغيل PowerShell: **انقر بزر الفأرة الأيمن** على قائمة البدء لتفعيل قائمة الروابط السريعة ثم اختر **Windows Terminal (admin)** في ويندوز 11 أو **Windows powershell (admin)** في ويندوز 10 من القائمة.
[^3]: للتحقق من إصدار ويندوز الخاص بك: **انقر بزر الفأرة الأيمن** على قائمة البدء واختر خيار **النظام**. يمكنك رؤية إصدار ويندوز في القسم الثاني تحت **الإصدار**. يمكنك أيضاً اتباع خطوات الطريقة الثانية بـ **نسخها ولصقها**، فقط انسخ الأوامر ثم اضغط **زر الفأرة الأيمن** في **cmd أو powershell** للصقها.
[^4]: إصدار Home Single language.
[^5]: إصدار Home Country Specific.
[^6]: لعرض حالة تفعيل ويندوز يجب الذهاب إلى:  
***الإعدادات → التحديث والأمان → قائمة التفعيل.***

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---
# การเปิดใช้งาน Windows 10 & 11 ทันที: วิธีแก้ปัญหาใน 40 วินาที

[![Readme](https://img.shields.io/badge/README_IN-فارسی-blue?logo=readme)](README-FA.md)  
[![Readme](https://img.shields.io/badge/README_IN-ENGLISH-blue?logo=readme)](README.md)

> โครงการนี้ประกอบด้วยวิธีการที่สามารถเปิดใช้งาน Windows 10 และ 11 ได้ภายใน 40 วินาที ทั้งสองวิธีนี้สามารถใช้ได้กับ Windows เวอร์ชัน home, home N, Home single lang, Home country specific, professional, education และ enterprise

## วิธีที่ 1 (แนะนำ)  
### เปิดใช้งาน Windows ทันทีด้วย (PowerShell)  
> [!TIP]
> มีหลายวิธีในการเปิด PowerShell ใน Windows 10 & 11 [^1]

หนึ่งในวิธีที่เร็วที่สุดในการเปิด PowerShell ใน Windows คือการค้นหาผ่านเมนู Start คุณสามารถทำตามขั้นตอนด้านล่างนี้ได้:

<br>

### ขั้นตอนที่ 1  
เพียงแค่คลิกที่ปุ่ม Start หรือไอคอนค้นหา แล้วพิมพ์ "PowerShell" ในช่องค้นหา  
> อีกวิธีง่าย ๆ: [^2]

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/5a10538a-c8c2-4934-868b-fd8e910f1f9e" width="540px">
</p>  

---
<br>

### ขั้นตอนที่ 2  
จากนั้นคุณต้องคลิก `Run as Administrator` เพื่อเปิด PowerShell ในกรณีนี้เราต้องรันด้วย **สิทธิ์ผู้ดูแลระบบ**

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/1f25dd2a-16db-4053-a45c-aac6f8a9e470" width="540px">
</p>

---
<br>

### ขั้นตอนที่ 3  
ตอนนี้ หลังจากรอสักครู่เพื่อให้ระบบพร้อมใช้งาน โปรด `คัดลอก` บรรทัดนี้:

```CSS
irm https://get.activated.win | iex
```

---
<br>

### ขั้นตอนที่ 4  
จากนั้นวาง (ด้วยคลิกขวา) และกดปุ่ม Enter ในหน้าต่างที่เพิ่งเปิดขึ้นมาจะมีตัวเลือกหลายรายการ ให้เราเลือกตัวเลือกที่ `1` และรอสักครู่จนกว่าจะเสร็จสมบูรณ์  

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/0c3689a1-1595-40b3-97e2-041dac423237" width="540px">
</p>

<br>

#### ยินดีด้วย,
Windows ของคุณถูกเปิดใช้งานเรียบร้อยแล้ว  
ตอนนี้คุณสามารถกดปุ่ม Enter เพื่อออกจาก CMD และปิด PowerShell และตรวจสอบเมนูการเปิดใช้งาน Windows [^3]

<br><br><br><br><br><br><br><br>

## วิธีที่ 2  
### เปิดใช้งาน Windows ทันทีด้วย CMD (Command Prompt)

<br>

> [!NOTE]
> จำเป็นต้อง**เชื่อมต่อ**กับ**อินเทอร์เน็ต**
>
> ไม่จำเป็นต้องใช้ VPN

<br>

### ขั้นตอนที่ 1  
ก่อนอื่นให้คลิกที่ปุ่ม Start หรือไอคอนค้นหา แล้วพิมพ์ "CMD" ในช่องค้นหา และหลังจากเห็นตัวเลือก Command Prompt ให้รันในฐานะ **ผู้ดูแลระบบ**  
> อีกวิธีง่าย ๆ: [^2].

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/88ac970a-f24b-4acc-82c0-f8e7c0b05249" width="480px">
</p>  

---
<br>

### ต่อไปนี้คือรายการ LICENSE KEYS  

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

### ขั้นตอนที่ 2  
ติดตั้ง KMS client key

ใช้คำสั่งนี้:

```CSS
slmgr /ipk yourlicensekey
```

> [!NOTE]
> โปรดเลือกหนึ่งใน **license keys** จากรายการที่ **ตรงกับเวอร์ชัน Windows ของคุณ** แล้วแทนที่คำว่า `yourlicencekey` ในคำสั่ง

> [!TIP]
> วิธีตรวจสอบเวอร์ชัน Windows [^3].

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/1b6401e6-7e63-4351-8a92-fa355dfc30cf" width="480px">
</p>  

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/90037069-7ea3-44a8-a9fa-e296f5e8d47b" width="340px">
</p>  

---
<br>

### ขั้นตอนที่ 3  
ตั้งค่า KMS machine address

ใช้คำสั่งนี้:

```CSS
slmgr /skms kms8.msguides.com
```

เพื่อเชื่อมต่อกับ KMS server ของเรา

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/9d634454-1c59-47da-874e-bfe575288fe6" width="480px">
</p>  

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/2d2e6cfb-4e85-483f-ae0a-c7157d22da36" width="340px">
</p>  

---  
<br>

### ขั้นตอนที่ 4  
เปิดใช้งาน Windows ของคุณ  
ขั้นตอนสุดท้ายคือการเปิดใช้งาน Windows ด้วยคำสั่งนี้:

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

### ขั้นตอนที่ 5  
จากนั้นตรวจสอบสถานะการเปิดใช้งานอีกครั้ง [^6].

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/9ca70137-8e2e-4504-a52d-22f41d959bd7" width="480px">
</p>

#### เสร็จสิ้น ✅  
Windows ของคุณถูกเปิดใช้งานเรียบร้อยแล้ว

<br>

**จงอยากรู้อยากเห็น 🤍**

[![Telegram](https://img.shields.io/badge/TELEGRAM-blue.svg?logo=telegram)](https://t.me/F_NiREvil) [![Twitter](https://img.shields.io/badge/TWITTER-blue.svg?logo=x)](https://twitter.com/NiREvil_)

<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://user-images.githubusercontent.com/25423296/163456776-7f95b81a-f1ed-45f7-b7ab-8fa810d529fa.png">
  <source media="(prefers-color-scheme: light)" srcset="https://user-images.githubusercontent.com/25423296/163456779-a8556205-d0a5-45e2-ac17-42d089e3c3f8.png">
  <img alt="Shows an illustrated sun in light mode and a moon with stars in dark mode." src="https://user-images.githubusercontent.com/25423296/163456779-a8556205-d0a5-45e2-ac17-42d089e3c3f8.png">
</picture>

<br>

[^1]: [10 วิธีในการเปิด PowerShell ใน Windows](https://www.google.com/amp/s/www.minitool.com/news/open-windows-11-powershell.html%3famp)  

[^2]: อีกวิธีที่ง่ายที่สุดในการเปิด PowerShell: **คลิกขวา** ที่เมนู Start เพื่อเปิดเมนูลัด แล้วเลือก **Windows Terminal (admin)** ใน Windows 11 หรือ **Windows powershell (admin)** ใน Windows 10 จากรายการเมนู
[^3]: วิธีตรวจสอบเวอร์ชัน Windows: **คลิกขวา** ที่เมนู Start แล้วเลือกตัวเลือก **system** เวอร์ชัน Windows ของคุณจะปรากฏในส่วนที่สองใต้หัวข้อ **Edition.** คุณยังสามารถคัดลอกคำสั่งในวิธีที่ 2 ไปวางและรันใน cmd หรือ powershell ได้โดยการ **คลิกขวา**
[^4]: Home Single language version.
[^5]: Home Country Specific version.
[^6]: เพื่อตรวจสอบสถานะการเปิดใช้งาน Windows ให้ไปที่  
***Settings → Update & Security → activation menu.***

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---
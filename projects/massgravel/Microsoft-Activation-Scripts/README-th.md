<p align="center"><img src="https://massgrave.dev/img/logo_small.png" alt="MAS Logo"></p>

<h1 align="center">Microsoft  Activation  Scripts (MAS)</h1>

<p align="center">ตัวกระตุ้นการใช้งาน Windows และ Office แบบโอเพ่นซอร์ส ที่มีวิธีการเปิดใช้งาน HWID, Ohook, TSforge, KMS38 และ Online KMS พร้อมฟีเจอร์การแก้ไขปัญหาขั้นสูง</p>

<hr>
  
## วิธีเปิดใช้งาน Windows / Office?

### วิธีที่ 1 - PowerShell (Windows 8 ขึ้นไป) ❤️

1.   **เปิด PowerShell**  
	กดปุ่ม Windows + X แล้วเลือก PowerShell หรือ Terminal

2.   **คัดลอกและวางโค้ดด้านล่าง จากนั้นกด Enter**  
```
irm https://get.activated.win | iex
```
หรือจะใช้วิธีนี้ (แต่จะเลิกใช้ในอนาคต):  
```
irm https://massgrave.dev/get | iex
```

3.   จะเห็นตัวเลือกการเปิดใช้งาน ให้เลือกตัวเลือกที่ไฮไลท์ด้วยสีเขียว

4.   เสร็จสิ้น

---

### วิธีที่ 2 - แบบดั้งเดิม (Windows Vista ขึ้นไป)

<details>
  <summary>คลิกที่นี่เพื่อดูรายละเอียด</summary>
  
1.   ดาวน์โหลดไฟล์จากลิงก์ใดลิงก์หนึ่งด้านล่างนี้:  
`https://github.com/massgravel/Microsoft-Activation-Scripts/archive/refs/heads/master.zip`  
หรือ  
`https://git.activated.win/massgrave/Microsoft-Activation-Scripts/archive/master.zip`
2.   คลิกขวาที่ไฟล์ zip ที่ดาวน์โหลดมา แล้วเลือกแตกไฟล์
3.   ในโฟลเดอร์ที่แตกไฟล์แล้ว ให้หาโฟลเดอร์ชื่อ `All-In-One-Version`
4.   รันไฟล์ชื่อ `MAS_AIO.cmd`
5.   จะเห็นตัวเลือกการเปิดใช้งาน ทำตามคำแนะนำบนหน้าจอ
6.   เสร็จสิ้น

</details>

---

- หากต้องการเปิดใช้งานผลิตภัณฑ์เพิ่มเติม เช่น **Office for macOS, Visual Studio, RDS CALs และ Windows XP** ดูข้อมูล [ที่นี่](https://massgrave.dev/unsupported_products_activation)
- หากต้องการรันสคริปต์แบบไม่ต้องโต้ตอบ ดูข้อมูล [ที่นี่](https://massgrave.dev/command_line_switches)

---

### ใช้งานไม่ได้ ❓

- หากคุณ **ไม่สามารถเปิด MAS** ด้วยวิธี PowerShell ได้ กรุณาใช้งาน **วิธีที่ 2** ตามด้านบน
- หาก MAS เปิดใช้งานได้แต่สคริปต์แสดงข้อผิดพลาด ให้ตรวจสอบขั้นตอนการแก้ไขปัญหาที่แสดงเป็นสีน้ำเงิน และลองทำตามนั้น
- หากมีปัญหาใด ๆ สามารถติดต่อเราได้ [ที่นี่](https://massgrave.dev/troubleshoot)

---

> [!NOTE]
>
> - คำสั่ง IRM ใน PowerShell จะดาวน์โหลดสคริปต์จาก URL ที่ระบุ และ IEX จะรันสคริปต์ดังกล่าว
> - ควรตรวจสอบ URL ให้แน่ใจก่อนรันคำสั่ง และตรวจสอบแหล่งที่มาหากดาวน์โหลดไฟล์ด้วยตนเอง
> - โปรดระวัง เนื่องจากบางแห่งอาจปล่อยมัลแวร์ที่ปลอมเป็น MAS โดยใช้ URL อื่นในคำสั่ง IRM

---

```
เวอร์ชันล่าสุด: 3.4
วันที่ออก: 3-มิถุนายน-2025
```

### [การแก้ไขปัญหา / ขอความช่วยเหลือ](https://massgrave.dev/troubleshoot)
### [ดาวน์โหลด Windows & Office ต้นฉบับ](https://massgrave.dev/genuine-installation-media)
### โฮมเพจ - [https://massgrave.dev/](https://massgrave.dev/)

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

[1.4]: https://massgrave.dev/img/logo_discord.png (แชทกับเราโดยไม่ต้องสมัครสมาชิก)
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

<p align="center">สร้างด้วยความรัก ❤️</p>

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---
## 🚀 ทำไมฉันถึงสร้างโมดูลนี้

*ฉันสังเกตเห็นว่ามีหลายคนขาย keybox ที่หลุด หรือจ่ายเงินให้กับโมดูลที่อ้างว่าสามารถผ่าน Play Integrity ที่แข็งแกร่งได้ แต่กลับให้แค่ keybox ที่หลุดเท่านั้น ฉันจึงสร้างโมดูลนี้เพื่อให้คุณได้ใช้ **keybox ของจริง** ที่ใช้งานได้ **ฟรี** ไม่มีค่าใช้จ่ายแอบแฝง ไม่มีการหลอกลวง เพียงแค่ **เข้าถึงได้จริง** พร้อมฟีเจอร์ที่มีประโยชน์มากมาย 🚫🔑*

<div align="center">
  <a href="https://github.com/MeowDump/Integrity-Box/releases" target="_blank">
    <img src="https://raw.githubusercontent.com/MeowDump/Integrity-Box/main/DUMP/download.png" alt="Download Button" width="600" />
  </a>
</div>

<p align="center">
  <img src="https://raw.githubusercontent.com/catppuccin/catppuccin/main/assets/footers/gray0_ctp_on_line.svg?sanitize=true" alt="Catppuccin Footer" />
</p>

`คลิกเพื่อขยาย`

<details>
<summary><strong>ℹ️ ข้อมูลโมดูล</strong></summary>

> **โมดูลนี้มีฟีเจอร์ดังต่อไปนี้:**  

- ✅ อัปเดต `keybox.xml`  
- 🗽 อัปเดต `target.txt` ตามสถานะ TEE ของคุณ  
- 🥷 สลับโหมด Shamiko (ผ่านการสลับในโมดูล)
- 👻 สลับโหมด NoHello (ผ่านการสลับในโมดูล)  
- 🛠️ เพิ่มแพ็กเกจตรวจจับ custom ROM ทั้งหมดใน **เส้นทาง SusFS**  
- ⛔ ปิดใช้งาน EU injector โดยค่าเริ่มต้น  
- ⛔ ปิดใช้งาน Pixel ROM spoofing  
- 🔐 ปลอมแปลงสถานะการเข้ารหัส   
- 🔑 ปลอมแปลง release key ของ ROM  
- 😋 ปลอมแปลงสถานะ SE Linux  
- 🕵️ ตรวจจับกิจกรรมผิดปกติเพื่อช่วยดีบั๊กปัญหา
- 🎨 ยังมีฟีเจอร์อื่นๆ อีก ดูเพิ่มเติมที่ [WebUI](https://raw.githubusercontent.com/MeowDump/Integrity-Box/main/DUMP/9.jpg)

</details>

<details>
<summary><strong>🗽 ข้อกำหนดเบื้องต้น</strong></summary>

> กรุณาตรวจสอบให้แน่ใจว่าคุณได้ติดตั้ง **โมดูลต่อไปนี้** ก่อนใช้งาน:

- [**Play Integrity Fork**](https://github.com/osm0sis/PlayIntegrityFork/releases)
- [**Tricky Store**](https://github.com/5ec1cff/TrickyStore/releases)

</details>

<details>
<summary><strong>❓ คำถามที่พบบ่อย (FAQ)</strong></summary>

<details>
<summary><strong>Meow Assistant เป็นมัลแวร์หรือไม่?</strong></summary>

### 🛡️ การเซ็นแอป & คำชี้แจงด้านความปลอดภัย

ในเวอร์ชันก่อนหน้า แอปนี้ถูกเซ็นด้วย **test key** ซึ่งทำให้บางเครื่องมือรักษาความปลอดภัยตรวจพบว่าเป็นแอปที่อาจเป็นอันตราย

เริ่มต้นตั้งแต่ **Module v3+** แอปนี้ถูกเซ็นด้วย **private release key**  
🔒 แม้ว่า **ฟังก์ชันจะไม่มีการเปลี่ยนแปลง** แต่การเปลี่ยนไปใช้คีย์ที่ถูกต้องได้แก้ปัญหานี้แล้ว และไม่มีการแจ้งเตือนเท็จอีกต่อไป

### 🐾 จุดประสงค์ของ Meow Assistant

**Meow Assistant** ถูกสร้างมาเพื่อเพิ่มความสะดวกและความโปร่งใส

จะแจ้ง **popup** เมื่อ:

- ✅ คุณคลิกตัวเลือกใดๆ ใน **WebView**  
- ⚙️ คุณรันสคริปต์ใดๆ ผ่าน **Action button**

สิ่งนี้ช่วยให้คุณทราบว่ามีการกระทำอะไรเกิดขึ้น และช่วยยกระดับประสบการณ์การใช้งาน

<img src="https://raw.githubusercontent.com/MeowDump/Integrity-Box/main/DUMP/meowassistant.png" alt="Meow Helper" width="100%">

</details>

</details>

<details>
<summary><strong>🔍 พบปัญหา? คลิกที่นี่</strong></summary>

- ไม่สามารถให้สิทธิ์รูทกับแอปต่างๆ ได้? `ปิดใช้งาน` โมดูล IntegrityBox ระบบจะสลับ shamiko/nohello ไปที่ `blacklist mode` และปลดซ่อนรูท  
- [Shamiko](https://t.me/LSPosed/292) ไม่ทำงานกับ magisk delta (kitsune mask)  
- [Shamiko](https://t.me/LSPosed/292) ทำงานได้เฉพาะกับ [Zygisk Next](https://github.com/Dr-TSNG/ZygiskNext/releases)  
- ซ่อนรูทให้ถูกต้อง หาก play integrity ไม่ผ่าน สำหรับ custom rom ให้ปิด gms spoofing ที่ติดมากับ rom แล้วแต่ rom ที่ใช้งาน ให้เข้ากลุ่มช่วยเหลือ rom ของคุณแล้วถาม `วิธีปิด`  
- สลับไปใช้ [Magisk Alpha](https://t.me/magiskalpha/683) หากพบปัญหา integrity กับ magisk ทางการ  

</details>

<details>
<summary><strong>🔗 ช่องทางสนับสนุน</strong></summary>

[![Support Group](https://ziadoua.github.io/m3-Markdown-Badges/badges/Telegram/telegram1.svg "เข้าร่วมกลุ่ม Telegram ของเรา")](https://t.me/+NCWzd1G--UNmNDY1)  
[![PayPal Donate](https://ziadoua.github.io/m3-Markdown-Badges/badges/PayPal/paypal1.svg "บริจาคผ่าน PayPal")](https://paypal.me/TempMeow)

</details>

<details>
<summary><strong>🎨 ตัวอย่างการแสดงผล</strong></summary>

1. ![](https://raw.githubusercontent.com/MeowDump/Integrity-Box/main/DUMP/1.png)  
2. ![](https://raw.githubusercontent.com/MeowDump/Integrity-Box/main/DUMP/2.png)  
3. ![](https://raw.githubusercontent.com/MeowDump/Integrity-Box/main/DUMP/3.png)  
4. ![](https://raw.githubusercontent.com/MeowDump/Integrity-Box/main/DUMP/4.png)  
5. ![](https://raw.githubusercontent.com/MeowDump/Integrity-Box/main/DUMP/5.gif)  
6. ![](https://raw.githubusercontent.com/MeowDump/Integrity-Box/main/DUMP/6.gif)  
7. ![](https://raw.githubusercontent.com/MeowDump/Integrity-Box/main/DUMP/7.gif)  
8. ![](https://raw.githubusercontent.com/MeowDump/Integrity-Box/main/DUMP/8.png)  
9. ![](https://raw.githubusercontent.com/MeowDump/Integrity-Box/main/DUMP/9.jpg)  
10. ![](https://raw.githubusercontent.com/MeowDump/Integrity-Box/main/DUMP/10.png)

</details>

<details>
<summary><strong>📊 สถิติโครงการ</strong></summary>

[![GitHub Stars](https://m3-markdown-badges.vercel.app/stars/7/1/MeowDump/Integrity-Box)](https://github.com/MeowDump/Integrity-Box/stargazers)  
[![GitHub Issues](https://m3-markdown-badges.vercel.app/issues/1/1/MeowDump/Integrity-Box)](https://github.com/MeowDump/Integrity-Box/issues)  
[![GitHub Release](https://ziadoua.github.io/m3-Markdown-Badges/badges/Github/github3.svg)](https://github.com/MeowDump/Integrity-Box/releases)

</details>

_ผมเขียนโค้ดนี้ครั้งแรกใน Notepad และไม่ได้แอคทีฟบน GitHub มากนัก อัปโหลดไว้ที่นี่เพื่อความโปร่งใส ใครอยากตรวจสอบโค้ดเชิญได้เลย_

`ขอให้สนุกกับการดีบั๊ก!`

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---
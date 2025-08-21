
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# โรเซ็ตต้า สตองค์ส์

- [บทนำ](#introduction)
- [การติดตั้ง](#install)
  - [Chrome](#chrome-based-browsers)
    - [คู่มือภาพประกอบ](#chrome-based-browsers)
  - [Firefox](#firefox-based-browsers)
- [วิธีการใช้งาน](#how-to-use)
  - [การเพิ่มเวลา](#adding-time)
    - [พื้นฐาน](#adding-time-in-foundations)
    - [สร้างความคล่องแคล่ว](#adding-time-in-fluency-builder)
  - [การตรวจสอบบทเรียน](#validating-lesson)
    - [พื้นฐาน](#validating-lesson-in-foundations)
    - [สร้างความคล่องแคล่ว](#validating-lesson-in-fluency-builder)

## บทนำ

RosettaStonks เป็นส่วนขยายของเบราว์เซอร์ที่ช่วยให้สามารถเพิ่มเวลาและตรวจสอบ
บทเรียนบนแพลตฟอร์มเรียนรู้ภาษา Rosetta Stone

> RosettaStonks และ Rosetta Stone ของคุณจะกลายเป็น Stonks

## การติดตั้ง

### เบราว์เซอร์ที่ใช้ Chrome

➡️ **ใหม่กับการติดตั้งส่วนขยาย Chrome ด้วยตนเองใช่หรือไม่?** ดู [คู่มือภาพทีละขั้นตอน](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md) — มีภาพประกอบที่เป็นประโยชน์! 🖼️

#### 1. ใช้ GitHub Release

หากต้องการใช้ส่วนขยายในเบราว์เซอร์ที่ใช้ Chrome คุณต้อง:

- ดาวน์โหลดไฟล์ `rosettastonks-chrome.tar.gz` จาก release ล่าสุดบน
  เครื่องของคุณ
- สร้างโฟลเดอร์ชื่อ `rosettastonks` ที่ใดก็ได้บนเครื่องของคุณเพื่อเก็บ
  ส่วนขยาย
- รันคำสั่งต่อไปนี้ในโฟลเดอร์ `rosettastonks`

```bash
$ tar xvzf /path/to/rosettastonks-chrome.tar.gz
```

2. การใช้ตัวจัดการแพ็กเกจ nix

แทนที่จะใช้คำสั่งก่อนหน้านี้ หากคุณอยู่บนระบบ nix ที่ **รองรับ flakes**
คุณสามารถรันคำสั่งต่อไปนี้ ซึ่งจะติดตั้งโฟลเดอร์
ภายใต้เส้นทาง `/tmp/rosettastonks` พร้อมกับไฟล์ทั้งหมด

```bash
$ nix build --out-link "/tmp/rosettastonks" github:m1dugh/RosettaStonks#chrome
```

โฟลเดอร์ถูกติดตั้งไว้ที่ `/tmp/rosettastonks/`

**ส่วนนี้สำหรับผู้ใช้ทุกคนไม่ว่าจะใช้วิธี github
หรือวิธี nix ก็ตาม**

ในเบราว์เซอร์ของคุณ:

- ไปที่ `chrome://extensions`
- ตรวจสอบให้แน่ใจว่าเปิด `Developer mode`
- คลิกที่ `Load unpacked`
- เลือกโฟลเดอร์ `rosettastonks` ของคุณ

### เบราว์เซอร์ที่ใช้ Firefox

- ดาวน์โหลดไฟล์ `rosettastonks.xpi` จาก release ล่าสุด
- หรือถ้าใช้ nix package manager ที่รองรับ flake คุณสามารถรัน
  คำสั่งต่อไปนี้

```bash
$ nix build --out-link "/tmp/rosettatonks.xpi" github:m1dugh/RosettaStonks#mozilla
```
- ไปที่ `about:addons` ในเบราว์เซอร์ของคุณ
- คลิกที่ปุ่มการตั้งค่าและไปที่ `Debug addons`
- คลิก `Load Temporary Add-On`
- เลือกไฟล์ `/tmp/rosettastonks.xpi` ในตัวเลือกไฟล์

_คำเตือน: วิธีนี้จะติดตั้งส่วนขยายแบบชั่วคราวเท่านั้น หมายความว่าหาก
คุณปิดเบราว์เซอร์ ส่วนเสริมจะถูกถอนการติดตั้ง เนื่องจากนโยบายของ Firefox
ไม่อนุญาตให้ใช้ส่วนขยายที่ไม่ได้รับการยืนยัน_

## วิธีใช้งาน

### การเพิ่มเวลา

#### การเพิ่มเวลาใน Foundations

เพื่อเพิ่มเวลาในผลิตภัณฑ์ `foundations` คุณต้องไปที่แบบฝึกหัดของคุณ และ
คลิกข้ามหรือแก้ไขคำถามอย่างน้อยหนึ่งข้อ เมื่อดำเนินการเสร็จแล้ว จะมีช่องเวลา
ปรากฏบนหน้าส่วนขยายซึ่งคุณสามารถเพิ่มเวลาได้

#### การเพิ่มเวลาใน Fluency builder

เพื่อเพิ่มเวลาในผลิตภัณฑ์ `fluency builder` คุณต้องไปที่แบบฝึกหัดของคุณ และ
ตอบแบบฝึกหัดอย่างน้อยหนึ่งข้อ หากช่องเพิ่มเวลาไม่ปรากฏ แสดงว่า
ไม่มีการจับคำขอเวลา คุณต้องรีเฟรชคำถามและตอบอีกครั้ง ในการเพิ่มเวลา
คุณต้องจบบทเรียนที่คุณใช้เพิ่มเวลา

_หมายเหตุ: หากคุณไม่เห็นช่องเพิ่มเวลา แสดงว่าการกระทำของคุณในเว็บไซต์
Rosetta Stone ไม่ได้นำไปสู่การเพิ่มเวลาที่ถูกต้อง ดังนั้นคุณต้องไปตอบคำถามอื่น_

### การยืนยันบทเรียน

#### การยืนยันบทเรียนใน Foundations

เพื่อยืนยันบทเรียน ต้องเริ่มบทเรียนและผ่านทุกคำถามโดยใช้ปุ่ม `ignore`
ที่ด้านล่างขวา เมื่อเห็นทุกคำถามแล้ว ให้คลิกปุ่ม `validate lesson` เพื่อยืนยัน
บทเรียน หากไม่ได้ ให้กลับไปที่หน้าแรก คลิกที่บทเรียนเดิม




ควรถามคุณว่า `คุณต้องการดำเนินการต่อหรือรีเซ็ต ?` คุณสามารถเลือกทั้งสองแบบ และ
ตรวจสอบบทเรียนอีกครั้งจนกว่าจะใช้งานได้ ควรจะใช้งานได้หลังจากลอง 3/4 ครั้งสูงสุด

#### การตรวจสอบบทเรียนใน Fluency builder

ขณะนี้ฟีเจอร์ตรวจสอบบทเรียนยังไม่สามารถใช้งานได้บน rosetta stonks

## การสร้างแอปพลิเคชัน

### การสร้าง worker

สามารถบรรจุ worker ได้โดยใช้คำสั่งต่อไปนี้

```
$ deno task build:worker
```
ซึ่งจะสร้างไฟล์แพ็กเกจ `/dist/worker.esm.js` ซึ่งเป็นไฟล์แพ็กเกจสำหรับ worker

### การสร้างส่วนหน้า (Frontend)

Worker สามารถแพ็กเกจได้โดยใช้คำสั่งต่อไปนี้



```
$ deno task build:frontend
```
ซึ่งจะสร้างไฟล์แพ็คเกจ `/dist/frontend.esm.js` ซึ่งเป็นไฟล์แพ็คเกจสำหรับส่วนหน้าของระบบ

## การแพ็คเกจส่วนขยาย

### Chrome

ในการแพ็คเกจส่วนขยายสำหรับ Chrome สามารถรันคำสั่งต่อไปนี้:



```
$ make chrome
```

### Firefox

ในการจัดแพ็กเกจส่วนขยายสำหรับ Firefox สามารถรันคำสั่งต่อไปนี้ได้:

```
$ make firefox
```
ซึ่งจะสร้างไฟล์ `rosettastonks.xpi` ซึ่งเป็นไฟล์สำหรับส่วนขยายที่สามารถโหลดใน firefox ได้

📸 ชอบภาพประกอบใช่ไหม? ดู [คู่มือการติดตั้ง Chrome พร้อมภาพประกอบ](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-21

---

<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

﻿# Elucidate

- [รายละเอียดโครงการ](#project-description)
- [ข้อกำหนดของระบบ:](#os-requirements)
- [คำถามที่พบบ่อย](#faqs)
- [แผนงาน](#roadmap)
- [ภาพหน้าจอ](#screenshots)

## คำอธิบายโครงการ

Elucidate เป็นโปรแกรม GUI บน Windows ที่ใช้เป็นส่วนหน้าสำหรับแอปพลิเคชัน SnapRAID แบบบรรทัดคำสั่ง

*โครงการนี้เป็นการสานต่อการรวมผลงานที่ยอดเยี่ยมที่ทำโดยตัวผมเองและผู้ร่วมสมทบคนอื่น ๆ

## ข้อกำหนดของระบบ

- ระบบปฏิบัติการ Windows
- .Net Runtime 4.8.0
- SnapRaid เวอร์ชัน 11.5 หรือต่ำกว่า
- พื้นที่ว่าง 10MB บนไดรฟ์เป้าหมาย

## คำถามที่พบบ่อย

**ถาม**: SnapRAID คืออะไร?<br/>
**ตอบ**: SnapRAID เป็นซอฟต์แวร์ที่ใช้เป็นเครื่องมือ snapshot-parity สำหรับระบบปฏิบัติการ Windows และ Linux ในระดับพื้นฐานที่สุด SnapRAID จะให้การปกป้องข้อมูลในระบบไฟล์โดยการคำนวณแฮชของไฟล์ต่าง ๆ และเก็บผลลัพธ์ไว้ในไฟล์ parity หากเกิดความล้มเหลวของฮาร์ดไดรฟ์ ไฟล์ parity นี้สามารถใช้ในการกู้ข้อมูลที่สูญหายได้ สำหรับรายละเอียดเต็ม ดู [การเปรียบเทียบเครื่องมือปกป้องไฟล์อย่างเป็นทางการของ SnapRAID](http://snapraid.sourceforge.net/compare.html)

**ถาม**: ทำไมต้องใช้ GUI ทั้งที่บรรทัดคำสั่งก็ใช้ได้!<br/>
**ตอบ**: เป้าหมายที่ใหญ่กว่าคือการสร้าง GUI ที่มีฟีเจอร์ครบพร้อมฟังก์ชันบริหารจัดการเพิ่มเติมเพื่อช่วยผู้ใช้ในการดูแลระบบ SnapRAID ให้ทำงานได้ดี บางครั้ง ‘คลิกเลือก’ ก็ง่ายสำหรับมือใหม่ SnapRAID มีเอกสารทางเทคนิคและการปรับแต่งที่ลึกซึ้ง อาจทำให้ผู้ที่อยากทดลองใช้รู้สึกไม่สะดวก!

**ถาม**: ฉันยังไม่แน่ใจ มีข้อมูลเพิ่มเติมหรือไม่?<br/>
**ตอบ**: มีครับ ลองดู [เอกสาร](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./docs/Documentation.md) สำหรับภาพประกอบ ฯลฯ

**ถาม**: แล้ว "เป้าหมายใหญ่" คืออะไร?<br/>
**ตอบ**: ดู __Roadmap__ ด้านล่างสำหรับรายละเอียดทั้งหมด

## Roadmap

- [x] ระยะที่ I
  - [x] พยายามรองรับ SnapRAID เวอร์ชันล่าสุดขั้นต่ำ - __ดำเนินการต่อเนื่อง.__
  - [x] ใช้งานง่าย
  - [x] SnapRAID มีสามคำสั่งหลัก ให้สามารถเข้าถึงได้ง่ายสำหรับมือใหม่
  - [x] ตัวบ่งชี้ความคืบหน้า 
  - [x] การบันทึก "แบบโต้ตอบ" และบันทึกตรงไปยัง log 
  - [x] เริ่มต้นอัตโนมัติเมื่อผู้ใช้เข้าสู่ระบบ 
  - [x] คำแนะนำบนเครื่องมือ •	

- [x] ระยะที่ II ขอฟีเจอร์เพิ่มเติมในระยะที่ II
  - [x] หยุดชั่วคราว, เปลี่ยนลำดับความสำคัญ, ยกเลิก
  - [x] ส่วนขยายคำสั่ง - "อนุญาตให้มีพารามิเตอร์เพิ่มเติมนอกเหนือจากค่าปริยายที่ใช้"
  - [x] การตั้งเวลาทำงาน
    - ถูกลบออก ให้ใช้ CommandLine แทน
  - [x] มุมมองแบบกราฟิกของข้อมูลที่ได้รับการป้องกัน

- [ ] เฟส III (เริ่มใหม่สำหรับ 2017-03 เป็นต้นไป)
  - [x] คอมไพเลอร์ใหม่และ .Net 4.7.x	
  - [x] อินเทอร์เฟซแบบ Command Line
  - [ ] รูปแบบใหม่โดยใช้ Krypton Toolkit / Navigator / ฯลฯ
    - กำลังดำเนินการ
  - [ ] การแปลภาษา
  - [x] คำสั่งใหม่
  - [ ] ระบบส่งอีเมลพร้อมรายงานสถานะ
  - [ ] เอกสารขั้นตอนการทดสอบ
    - กำลังดำเนินการ
  - [ ] เพิ่มเนื้อหา/อัปเดตรูปภาพในเอกสารประกอบ
    - กำลังดำเนินการ
  - [ ] เพิ่มการรายงานข้อผิดพลาดใน _Windows EventLog_
  - [x] เพิ่ม _ExceptionLess_ สำหรับรายงานข้อผิดพลาดออนไลน์
  - [x] แสดงข้อมูลที่สามารถกู้คืนได้

- [ ] เฟส IV (คำสั่ง SnapRAID ใหม่?)
  - [ ] คู่มือช่วยเหลือขยายสำหรับการกู้คืนดิสก์ - คำแนะนำแบบโต้ตอบ ฯลฯ
  - [ ] แจ้งเตือนผู้ใช้หากเวอร์ชัน SnapRAID ล้าสมัย
  - [ ] แปลผล log ของ SnapRAID (ใช้โดยฟีเจอร์ด้านล่าง)
  - [ ] แสดงสถานะของ array หลังจากสั่งงาน
  - [ ] ปรับปรุงคำสั่ง sync ให้รวม diff ครั้งแรก
  - [ ] ปรับปรุงคำสั่ง sync ให้เตือนหาก diff รายงานปัญหาเกินค่าที่กำหนด
  - [ ] เพิ่มการตั้งค่าขั้นต่ำที่ผู้ใช้กำหนดได้สำหรับ sync

## สกรีนช็อต

![Starting View](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/starting_view.png)

![Settings Form](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/Settings_Form.PNG)


## คุณช่วยได้ไหม?
- กำลังมองหาผู้ทดสอบ (สำหรับทุกแพลตฟอร์ม .Net)

- สามารถช่วยแปลได้
- คู่มือการใช้งาน / คู่มือส่วนติดต่อผู้ใช้
- ไอเดียอื่น ๆ :-)
- นักพัฒนาสำหรับไอเดียต่าง ๆ


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-30

---
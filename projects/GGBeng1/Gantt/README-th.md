# Gantt
<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>
## การติดตั้ง

```
yarn install
```

### การรัน

```
yarn run serve
```

### คำอธิบาย

```
เป็นการแสดงผลแผนภูมิแกนต์ที่พัฒนาบนพื้นฐานของ vue สามารถใช้สำหรับการทำงานร่วมกันในทีม การแบ่งงาน และสถานการณ์แบบ Agile อื่น ๆ

รองรับการจัดกลุ่ม
รองรับการลากวาง
รองรับการยืดขยาย
รองรับเปอร์เซ็นต์ความคืบหน้า
รองรับช่วงเวลา: วัน สัปดาห์ เดือน
ปัจจุบันรองรับเฉพาะการจัดกลุ่มระดับเดียว เพื่อหลีกเลี่ยงความต้องการการจัดกลุ่มสองระดับหรือหลายระดับในอนาคต ในการคอมมิตครั้งที่แล้วได้รีแฟกเตอร์โค้ดบางส่วนให้รองรับการจัดกลุ่มหลายระดับ แต่เวอร์ชันปัจจุบันยังไม่ได้พัฒนา

ข้อดี: ในขณะลากวาง ยืดขยาย หรือแก้ไขความคืบหน้า ข้อมูลจะไม่อัปเดตแบบเรียลไทม์ แต่จะอัปเดตหลังจากทำรายการเสร็จ ลดการใช้ทรัพยากร
      ในการแก้ไข ลบ หรือเพิ่มข้อมูล จะไม่แก้ไขอินสแตนซ์ทั้งหมดแบบรีเคอร์ซีฟ แต่จะเพิ่ม ลบ หรือแก้ไขเฉพาะส่วนที่เปลี่ยนแปลง

อยู่ระหว่างการจัดระเบียบใหม่เพื่อเตรียมเป็นคอมโพเนนต์ ปัจจุบันหากต้องการใช้งานในโปรเจกต์ เพียงนำเข้า `gant.vue` จากโปรเจกต์นี้ก็ใช้ได้เลย
วิธีการนำเข้าหรือส่งออกข้อมูลเป็นกลุ่มได้เขียนไว้เรียบร้อยแล้ว สามารถคัดลอกไปใช้ได้ทันที!~

```

### หมายเหตุการอัปเดต

- รองรับการแก้ไข
- รองรับการลบ
- แก้ไขบั๊กที่ไม่สามารถเลื่อนขึ้นลงได้ (และเพิ่มการเลื่อนพร้อมกันสองทิศทาง) [#4](https://github.com/GGBeng1/Gantt/issues/4)
- แก้ไขบั๊กที่เกิดจาก elementUI
- เกี่ยวกับปัญหาช่วงเวลา [#5](https://github.com/GGBeng1/Gantt/issues/5)
- ขณะนี้ไม่สามารถเปลี่ยนช่วงเวลาอื่น เช่น ชั่วโมง ผ่านการแก้ไขค่าคอนฟิกได้ เนื่องจากมีการกำหนดค่าบางอย่างแบบตายตัวตั้งแต่เริ่มต้น ในอนาคตจะปรับปรุงให้สามารถตั้งค่าได้ผ่าน API

### ดูตัวอย่าง

ดู [demo](https://ggbeng1.github.io/Gantt/#/)

### ภาพตัวอย่าง

<img src="https://raw.githubusercontent.com/GGBeng1/Gantt/master/public/demo.png" alt="">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-01

---
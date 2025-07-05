<h1 align="center">ยินดีต้อนรับสู่&nbsp;&nbsp;Cursor Auto Helper 👋</h1>
<p>
  <img alt="Version" src="https://img.shields.io/badge/version-2.3.0-blue.svg?cacheSeconds=2592000" />
  <img alt="License: MIT" src="https://img.shields.io/badge/License-MIT-yellow.svg" />
  <img alt="Cursor Version" src="https://img.shields.io/badge/Cursor-0.48.x%20%E8%87%B3%201.0.0-blue.svg" />
</p>

> เครื่องมือช่วยเหลือ Cursor แบบอัตโนมัติ, Cursor ดำเนินการต่ออัตโนมัติ, Cursor ลองใหม่อัตโนมัติ, Cursor ยืนยันอัตโนมัติ, สถิติการใช้งาน Cursor, เครื่องมือเสริม Cursor, เครื่องมือช่วยเหลือ Cursor, เครื่องมืออัตโนมัติ Cursor, การตั้งค่าธีม Cursor, Cursor Auto Continue Tool, Cursor Auto Retry Tool, Cursor Auto Confirm Tool, Cursor Usage Statistics Tool, Cursor Efficiency Tool, Cursor Automation Tool, Cursor Theme Settings, Cursor after 25 tool calls, Cursor Tool Call Limit🔧🤖🚀
> 

## 🏠 [โฮมเพจ](https://github.com/pen9un/cursor-auto-helper)

Cursor Auto Helper คือเครื่องมือเสริมแบบอัตโนมัติที่ออกแบบมาสำหรับ Cursor IDE โดยเฉพาะ สามารถแสดงการใช้งานแบบเรียลไทม์, จัดการข้อจำกัดการสนทนา 25 ครั้ง, ปัญหาการเชื่อมต่อเครือข่ายล้มเหลว, การยืนยันข้อความแจ้งเตือน ฯลฯ ทำให้ประสบการณ์การพัฒนาของคุณราบรื่นยิ่งขึ้น

**วิดีโอสาธิต:** [Cursor Auto Helper สาธิตวิดีโอ](https://www.bilibili.com/video/BV1cajKzCEzv/)

หากคุณมี Prompt ที่มีคุณภาพสูงและวางแผนความต้องการของโปรเจกต์ได้ดี โปรแกรมนี้จะช่วยให้ Cursor สามารถดำเนินการโปรเจกต์ได้โดยอัตโนมัติโดยไม่ต้องมีการแทรกแซงจากมนุษย์

> 🔒 **ความเข้ากันได้ของเวอร์ชัน**: ปัจจุบันทดสอบพัฒนาใน Cursor 0.49.6 และ Cursor 1.0.0 ทฤษฎีรองรับ Cursor 0.48.x - 1.0.0

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper.png" alt="cursor-auto-helper" />

## 📖บันทึกการอัปเดต

- 2025-06-01 ออก v2.3 เพิ่มฟีเจอร์ตั้งค่าธีม Cursor, ปรับปรุงเสถียรภาพของการ Inject โค้ด, แก้ไขการแสดงผลการใช้งานให้ตรงกับรูปแบบทางการ
- 2025-05-21 ออก v2.1 ปรับโครงสร้างใหม่, รองรับหลายแพลตฟอร์ม, เพิ่มฟีเจอร์แสดงการใช้งานแบบเรียลไทม์ ฯลฯ
- 2025-04-25 เสร็จสิ้น v1.0 จัดการข้อจำกัดการสนทนา 25 ครั้ง, ปัญหาเชื่อมต่อเครือข่ายล้มเหลว, การยืนยันข้อความแจ้งเตือน ฯลฯ
- 2025-04-20 เริ่มโครงการ

## 🌟 Cursor Auto Helper แนวทางปฏิบัติที่ดีที่สุด

หมายเหตุ: เอกสารด้านล่างนี้สามารถสร้างด้วย AI เช่น Cursor แต่ต้องมีการตรวจสอบและปรับแต่งโดยมนุษย์

**STEP 1:** ออกแบบความต้องการของระบบโปรเจกต์อย่างละเอียด (ยิ่งวางแผนความต้องการชัดเจน คุณภาพโปรเจกต์จะยิ่งสูง) เขียน Prompt สำหรับพัฒนาโปรเจกต์คุณภาพสูง **SYSTEM.md**

**STEP 2:** สร้างเอกสารออกแบบระบบคุณภาพสูง **DESIGN.md** ตาม **SYSTEM.md**

**STEP 3:** สร้างเอกสารแผนการพัฒนาคุณภาพสูง **TODOLIST.md** ตาม **SYSTEM.md** และ **DESIGN.md**

**STEP 4:** ใช้ **Cursor Auto Helper** กำหนด **SYSTEM.md**, **DESIGN.md**, **TODOLIST.md** และใช้ Prompt ดำเนินการต่ออัตโนมัติ ให้ Cursor ทำงานตามแผนการพัฒนาโดยอัตโนมัติจนเสร็จสมบูรณ์

**Cursor Auto Helper Prompt สำหรับดำเนินการต่ออัตโนมัติ:**

```
@SYSTEM.md @DESIGN.md @TODOLIST.md กรุณาพัฒนาฟีเจอร์ตามแผน TODOLIST อย่างเคร่งครัด และอัปเดตบันทึกแผน TODOLIST แบบเรียลไทม์ ทุกครั้งที่งานเสร็จสิ้น กรุณาถามฉันว่า "ต้องการดำเนินการต่อหรือไม่" จนกว่าโปรเจกต์จะเสร็จสมบูรณ์ให้ตอบกลับว่า "โปรเจกต์พัฒนาเสร็จสมบูรณ์แล้ว"
```

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/guide.png" alt="guide" />

## 🚀 คำแนะนำการใช้งาน

ยินดีรับ Star สนับสนุน หากมีปัญหากรุณาแจ้ง [Issues](https://github.com/pen9un/cursor-auto-helper/issues)

### 📝 คำอธิบายไฟล์การตั้งค่า

ไฟล์ตั้งค่า `config.ini` **สำหรับปรับแต่งพฤติกรรมการทำงานอัตโนมัติ** (สามารถกำหนดและทดสอบได้ตามต้องการ) รองรับการตั้งค่าต่อไปนี้:

#### การตั้งค่าพื้นฐาน
```ini
[common]
log_enable = true     # เปิดใช้งานบันทึก log หากไม่ต้องการบันทึก log ให้เปลี่ยนเป็น false

[cursor]
path = C:\Path\To\Cursor.exe  # ที่อยู่ไฟล์ติดตั้ง Cursor IDE โปรแกรมจะค้นหาที่อยู่ Cursor อัตโนมัติ หากไม่พบจะมีการแจ้งเตือน สามารถแก้ไขตรงนี้ได้
```

#### การตั้งค่ากระทำอัตโนมัติ
แต่ละกระทำอัตโนมัติใช้คำนำหน้า `actionชื่อ.` รองรับฟิลด์ดังนี้:

- `type`: ประเภทการกระทำ
  - `click`: คลิกปุ่ม
  - `input_and_submit`: กรอกข้อมูลและส่ง

- `text` / `text_list`: เนื้อหาข้อความที่ต้องจับคู่
  - `text`: สตริงเดียว
  - `text_list`: หลายสตริงคั่นด้วย | หากหน้าเพจมีข้อความใดข้อความหนึ่งจะทำงาน

- `button_selector`: CSS selector ของปุ่มที่ต้องคลิก (ใช้กับ `click` เท่านั้น)
- `button_text`: ข้อความบนปุ่ม (เลือกใส่ เพื่อระบุปุ่มให้ชัดเจนขึ้น)
- `input_box_selector`: CSS selector ของกล่องกรอกข้อมูล (ใช้กับ `input_and_submit`)
- `input_content`: ข้อความที่ต้องกรอกอัตโนมัติ
- `submit_btn_selector`: CSS selector ของปุ่มส่ง
- `delay`: หน่วงเวลาก่อนดำเนินการ (มิลลิวินาที) ใช้สำหรับรอโหลดหน้าเพจ

##### ตัวอย่างการตั้งค่า
```ini
[auto_actions]
# ลองใหม่อัตโนมัติเมื่อเชื่อมต่อล้มเหลว
action_retry.type = "click"
action_retry.text = "Connection failed. If the problem persists, please check your internet connection or VPN"
action_retry.button_selector = "div.anysphere-secondary-button"
action_retry.button_text = "Try again"
action_retry.delay = 3000

# after 25 tool calls
action_continue.type = "input_and_submit"
action_continue.text_list = "agent after 25 tool calls"
action_continue.input_box_selector = ".full-input-box.undefined"
action_continue.input_content = "请继续"
action_continue.submit_btn_selector = ".codicon-arrow-up-two"
action_continue.delay = 1000

# ยืนยันดำเนินการต่อโดยอัตโนมัติ
action_need_continue.type = "input_and_submit"
action_need_continue.text_list = "是否需要|是否继续|需要我|请告诉我"
action_need_continue.input_box_selector = ".full-input-box.undefined"
action_need_continue.input_content = "请继续后续开发，并实时记录更新开发进度"
action_need_continue.submit_btn_selector = ".codicon-arrow-up-two"
action_need_continue.delay = 1000
```

> **หมายเหตุ:**
> 1. ชื่อของแต่ละ action (เช่น `action_retry`, `action_continue`) สามารถกำหนดเองได้ แต่ prefix ของฟิลด์ทั้งหมดใน action เดียวกันต้องเหมือนกัน
> 2. แนะนำให้ใช้เครื่องมือสำหรับนักพัฒนาของเบราว์เซอร์ในการระบุ CSS Selector เพื่อความถูกต้อง
> 3. หลังจากแก้ไขไฟล์คอนฟิก ต้องรีสตาร์ทโปรแกรมเพื่อให้การตั้งค่ามีผล

## 🎯 สถานการณ์การใช้งาน

### 💼 การพัฒนาบทสนทนายาว
- จัดการข้อจำกัด 25 ครั้งของบทสนทนาโดยอัตโนมัติ รองรับการพัฒนาบทสนทนายาวต่อเนื่อง ดำเนินการบทสนทนาอัตโนมัติ เพิ่มประสิทธิภาพการพัฒนา

### 👥 เครือข่ายไม่เสถียร
- ตรวจจับข้อผิดพลาดเครือข่ายโดยอัตโนมัติ รีลองเชื่อมต่ออย่างชาญฉลาด ฟื้นฟูบทสนทนาอัตโนมัติ รับรองความต่อเนื่องของการพัฒนา

### 🏢 สถานการณ์การยืนยัน
- ตรวจจับสถานการณ์แจ้งยืนยันอย่างชาญฉลาด จัดการแจ้งเตือนยืนยันอัตโนมัติ ลดการแทรกแซงจากมนุษย์

### 📚 การตรวจสอบการใช้งาน
- นับจำนวนบทสนทนาแบบเรียลไทม์ ตรวจสอบการใช้งาน Cursor บันทึกข้อมูลการใช้งาน ปรับแต่งการใช้งานให้มีประสิทธิภาพ

แสดงผลการใช้งานในเทอร์มินัล:

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper-1.png" alt="cursor-auto-helper-1" />

แสดงผลการใช้งานใน Cursor IDE:

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper-logs.png" alt="cursor-auto-helper-logs" />

## 🌟 คำอธิบายฟังก์ชัน

### 🤖 ดำเนินการต่อบทสนทนายาวโดยอัตโนมัติ
- จัดการข้อจำกัดบทสนทนา 25 ครั้งของ Cursor โดยอัตโนมัติ รองรับบทสนทนาแบบหลายรอบต่อเนื่อง

### 🎨 รีลองเชื่อมต่อโดยอัตโนมัติ
- ตรวจจับการเชื่อมต่อล้มเหลวโดยอัตโนมัติ รีลองเชื่อมต่ออัจฉริยะ ติดตามสถานะการเชื่อมต่อแบบเรียลไทม์

### 📱 ยืนยันแจ้งเตือนโดยอัตโนมัติ
- ตรวจจับสถานการณ์แจ้งเตือนยืนยันหลายรูปแบบอย่างชาญฉลาด จัดการป๊อปอัพยืนยันอัตโนมัติ
- รองรับการตั้งค่าข้อความยืนยันและการตอบสนองเอง ลดการแทรกแซงจากมนุษย์
- กำหนดกติกาได้อย่างยืดหยุ่น รองรับกระบวนการพัฒนาหลากหลาย

### 🛍️ สถิติการใช้งาน
- นับจำนวนบทสนทนาและการใช้งานแบบเรียลไทม์ บันทึกข้อมูลอัตโนมัติ
- แสดงข้อมูลการใช้งานในรูปแบบภาพ ช่วยวิเคราะห์และปรับปรุง
- รองรับแสดงผล log สีในเทอร์มินัล, แผงการใช้งานใน IDE เพิ่มความสะดวกในการใช้งาน

### 💡 ระบบบันทึก log
- มี log หลายระดับ (DEBUG/INFO/SUCCESS/WARNING/ERROR/CRITICAL) แสดงผลสีในเทอร์มินัล
- ไฟล์ log ถูกสร้างแยกตามวันที่ รองรับบันทึกไฟล์และแสดงในแผงโดยการลากวาง
- แผงแบบเรียลไทม์ช่วยให้นักพัฒนาตรวจสอบและย้อนกลับได้สะดวก

### 🔒 ความเข้ากันได้ของเวอร์ชันและการปรับแต่งประสิทธิภาพ
- พัฒนาบนพื้นฐาน Cursor 0.49.6 ผ่านการทดสอบฟังก์ชันหลักอย่างครบถ้วน
- ปรับแต่งสำหรับเวอร์ชันเฉพาะ ติดตามการอัปเดต Cursor อย่างต่อเนื่อง
- มีเสถียรภาพสูง เข้ากันได้ดี เหมาะกับการใช้งานในสภาพแวดล้อม production

## 🔮 ตัวอย่างผลลัพธ์

### 🤖 ดำเนินการต่อบทสนทนาโดยอัตโนมัติ

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/auto-continue.png" alt="auto-continue" />

### 🚀 ตัวอย่าง Cursor ดำเนินการโปรแกรมอัตโนมัติ

ตั้งแต่ความต้องการโครงการจนถึงการดำเนินการเสร็จสมบูรณ์ โดยไม่ต้องแทรกแซงจากมนุษย์ตลอดกระบวนการ:

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/auto-complete.png" alt="auto-complete" />

## 🤝 ผู้เขียน

👤 **pen9un**

* เว็บไซต์: https://github.com/pen9un/
* Github: [@pen9un](https://github.com/pen9un)

## ❤️ สนับสนุน

หากคิดว่าโปรเจกต์นี้มีประโยชน์ โปรดกดดาวฟรีเล็ก ๆ ⭐️⭐️

## ✨ ประวัติดาว (Star History)

[![Star History Chart](https://api.star-history.com/svg?repos=pen9un/cursor-auto-helper&type=Date)](https://star-history.com/#pen9un/cursor-auto-helper&Date)

## 💹 สถิติการเข้าชม

![Visitor Count](https://profile-counter.glitch.me/pen9un/count.svg) 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---

<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# ปฏิทินครอบครัวสมาร์ทโฮม DIY (โคลน Skylight)

![Sklylight calendar](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/main_view.jpeg)
![DIY Skylight](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/sky2.png)

## 📖 แนะนำ

เมื่อไม่นานมานี้ ภรรยาของผมโดนโฆษณาปฏิทินสมาร์ทโฮม (Skylight, Cozyla, Hearth) ในโซเชียลมีเดียบ่อยมาก และเธอก็พร้อมที่จะซื้อในราคากว่า 300 ดอลลาร์ ก่อนจะให้ไฟเขียว ผมขอโอกาสในการหาข้อมูลเกี่ยวกับอุปกรณ์เหล่านี้ก่อน
ผมสังเกตว่าฟีเจอร์ส่วนใหญ่คล้ายกันแต่ราคาต่างกันมาก ที่สำคัญคือผมไม่เห็นฟีเจอร์ใดที่โดดเด่นจนผมไม่สามารถทำเองใน **Home Assistant** ได้

**เป้าหมาย:** หน้าจอสัมผัสแสดงปฏิทินที่วางบนเคาน์เตอร์ได้ ได้รับการยอมรับจากภรรยา (WAF) และเชื่อมต่อกับสมาร์ทโฮมอย่างลึกซึ้งโดยไม่มีค่าบริการรายเดือน

## 💡 ทำเองดีกว่าไหม?

การเลือกทำเองผ่าน Home Assistant ให้ข้อดีหลายอย่างเมื่อเทียบกับการซื้อ Skylight/Hearth display:

* **ไม่มีค่ารายเดือน:** ไม่ต้องเสียค่าสมัครสมาชิกฟีเจอร์ "พรีเมียม"
* **เชื่อมต่อสมูท:** สื่อสารกับไฟบ้าน งานบ้าน (Grocy) และเซ็นเซอร์ตรวจจับคนอยู่
* **ใช้ฮาร์ดแวร์เก่า:** นำ Mini PC และจอมอนิเตอร์ธรรมดามาใช้ใหม่
* **ความเป็นส่วนตัว:** ไม่มีล็อกอินหรือเสี่ยงที่บริษัทจะปิดตัว

## 🛠 เลือกฮาร์ดแวร์

ตอนนี้โปรเจกต์นี้สร้างมาเพื่อแสดงแดชบอร์ดบนหน้าจอ HD (1920x1080) ได้ทุกตัว

ในกรณีของผมต้องการให้มัน "ดูเหมือน" skylight, เป็นจอสัมผัส, วางบนเคาน์เตอร์ และสามารถย้ายไปจุดอื่นได้ ผมจึงเลือกฮาร์ดแวร์ด้านล่างนี้
แต่ของคุณอาจต่างกันและต้องปรับเปลี่ยนตามเหมาะ เช่น ถ้าคุณอยากแสดงบนแท็บเล็ตหรืออุปกรณ์อื่น

ฮาร์ดแวร์ที่ผมเลือกตอนแรกเพราะเหตุผลข้างต้นและหวังว่าจะขยายฟีเจอร์ด้วย webcam, ลำโพง และไมค์ได้ ในตอนนี้ถ้าย้อนกลับไป ผมคงเลือกแบบอื่น เพราะยังไม่มีเวลาทำไอเดียฮาร์ดแวร์เพิ่มเติมเหล่านี้

* **จอภาพ:** [HP Engage 15-inch Touchscreen](https://computers.woot.com/offers/hp-engage-16t-fhd-monitor) ผมเลือกแทนจอพกพาทั่วไปเพราะมี **ลำโพง, กล้อง, ไมค์** ในตัว เผื่อเพิ่มควบคุมด้วยเสียงหรือวิดีโอคอลในอนาคต
* **คอมพิวเตอร์:** Mini PC เก่า (NUC/Tiny PC) ที่รัน Windows/Linux แบบ Kiosk หรือ Raspberry Pi 4~~

## ✨ ฟีเจอร์

* **ดูทั้งครอบครัวหรือเฉพาะบุคคล:** เปิด/ปิดปฏิทินของสมาชิกแต่ละคนได้
* **ซิงค์สองทาง:** แก้ไขกิจกรรมบนหน้าจอหรือในมือถือ (Google Calendar)
* **ป๊อปอัป "เพิ่มกิจกรรม":** UI เฉพาะสำหรับเพิ่มกิจกรรมลงปฏิทินแต่ละอันจากหน้าจอ
* **สภาพอากาศ & วันที่:** ส่วนหัวสวย ดูง่าย
* **Responsive:** นับจำนวนวันอัตโนมัติตามความกว้างหน้าจอ (มือถือ/เดสก์ท็อป)

---

## ⚙️ คู่มือการติดตั้ง

*หมายเหตุ: การตั้งค่านี้ใช้ **YAML Package** เพื่อสร้างตัวช่วย, สคริปต์ และตัวแปรที่จำเป็นทั้งหมดให้อัตโนมัติ โดยไม่ต้องสร้างเองทีละตัว*



### 1. ข้อกำหนดเบื้องต้น (HACS)

คุณต้องติดตั้ง [HACS](https://hacs.xyz/) แล้ว กรุณาติดตั้ง **Frontend** integrations ต่อไปนี้:

* `week-planner-card`
* `bubble-card`
* `config-template-card`
* `card-mod`
* `better-moment-card`
* `weather-card`
* `browser_mod` (จำเป็นสำหรับการทำงานของป็อปอัพ)
* `layout-card` (จำเป็นสำหรับมุมมอง Sections)
* `button-card` (จำเป็นสำหรับป็อปอัพเพื่อเพิ่มกิจกรรม)

*หมายเหตุ: ใน Settings → Devices & Services ให้แน่ใจว่า Browser Mod ปรากฏเป็น Integration (tile) และไม่ใช่แค่ใน HACS เท่านั้น 
ถ้าไม่พบให้คลิก Add Integration → Browser Mod และดำเนินการตามขั้นตอนให้เสร็จ จากนั้นรีสตาร์ท HA
การติดตั้งผ่าน HACS จะเป็นเพียงการดาวน์โหลดไฟล์ คุณต้องเพิ่ม Integration เพื่อให้ HA ลงทะเบียนการกระทำ/เอนทิตี

### 2. ส่วน Backend (ส่วนที่เป็นสมอง)

1. เปิดไฟล์ `configuration.yaml` ของคุณใน Home Assistant
2. ตรวจสอบว่าคุณได้เพิ่มบรรทัดนี้ไว้ใต้ `homeassistant:` เพื่อเปิดใช้งานแพ็คเกจ

   ```yaml
   homeassistant:
     packages: !include_dir_named packages
   ```
3. สร้างโฟลเดอร์ชื่อ `packages` ในไดเรกทอรีการตั้งค่าของ HA ของคุณ (หากยังไม่มี)
4. ดาวน์โหลด [packages/family_calendar.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/packages/family_calendar.yaml) จาก repo นี้
5. ค้นหาสตริง [ #<--- UPDATE THIS ENTITY] และอัปเดต Calendar entity ID ให้ตรงกับสภาพแวดล้อมของคุณ ดูรายละเอียดเพิ่มเติมในส่วนที่ 3
6. วางไฟล์ไว้ในโฟลเดอร์ `packages/` ของคุณ
7. **รีสตาร์ท Home Assistant**

### 3. ปฏิทิน

คุณสามารถใช้ **Google Calendar** หรือ **Local Calendar**

#### ตัวเลือก A: ใช้ชื่อปฏิทินเดิม (ง่ายที่สุด)

1. ไปที่ **Settings > Devices & Services**
2. เพิ่มการเชื่อมต่อ **Local Calendar**
3. สร้างปฏิทินโดยใช้ชื่อ: `calendar1`, `calendar2`, `calendar3`, `calendar4`, `Family`
    * *หากใช้ชื่อเหล่านี้ โค้ดจะทำงานได้ทันที!*

#### ตัวเลือก B: ปฏิทินแบบกำหนดเอง

1. ไปที่ **Settings > Devices & Services**
2. เพิ่มการเชื่อมต่อ **Local Calendar** หรือ **Google Calendar**
3. ไปที่ **Configuration > Integrations > Local Calendar** หรือ **Google Calendar** แล้วเลือก "Add Entry"
4. สำหรับแต่ละ entry ที่สร้างขึ้น ให้รับ entity ID เพื่ออัปเดตไฟล์ dashboard.yaml
5. เปิด `dashboard.yaml`
6. ค้นหา `# <--- UPDATE THIS ENTITY`
7. อัปเดต entity ID ให้ตรงกับสภาพแวดล้อมของคุณ

#### การตั้งค่าวันหยุด

เนื่องจาก Home Assistant อัปเดตแล้ว วันหยุดจะถูกเพิ่มผ่าน UI:

1. ไปที่ **Settings > Devices & Services > Add Integration > Holiday**
2. เลือกประเทศของคุณ
3. ตรวจสอบ entity ID (เช่น `calendar.holidays`) หากแตกต่างจากค่าเริ่มต้น ให้อัปเดตใน dashboard YAML

### 4. แดชบอร์ด (หน้าตา)




1. ไปที่ **การตั้งค่า > แดชบอร์ด**
2. คลิกที่ **เพิ่มแดชบอร์ด** (เลือกตัวเลือก "แดชบอร์ดใหม่จากศูนย์" และตรวจสอบให้แน่ใจว่าเลือก "เพิ่มในแถบข้าง")
3. ที่เมนูด้านซ้าย ให้เลือกแดชบอร์ดที่สร้างใหม่และคลิกที่ไอคอนดินสอเพื่อแก้ไข
5. เลือกไอคอน 3 จุด และเลือก "ตัวแก้ไขตัวตั้งค่าดิบ"
6. คัดลอกและวางโค้ดจาก [dashboard.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/dashboard.yaml)

### ขั้นตอนที่ 5: ธีม (ไม่จำเป็น)

เพื่อให้ได้รูปแบบฟอนต์เฉพาะ (Ovo):

1. ตรวจสอบว่าไฟล์ `configuration.yaml` ของคุณมีบรรทัดนี้อยู่ใต้ `frontend:`

   ```yaml
   frontend:
     themes: !include_dir_merge_named themes
   ```
2. สร้างโฟลเดอร์ชื่อ `themes` ในไดเรกทอรี config ของคุณ
3. ดาวน์โหลด [themes/skylight.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/themes/skylight.yaml) และวางไฟล์นี้ไว้ในโฟลเดอร์นั้น
4. ใช้ File Editor และอัปโหลด calbackgrd.png ไปยังโฟลเดอร์ /www/ ซึ่งจะแปลงเป็น /local บนแดชบอร์ดโดยอัตโนมัติ
5. รีสตาร์ท Home Assistant
6. ไปที่โปรไฟล์ของคุณ (ไอคอนผู้ใช้มุมล่างซ้าย) และเปลี่ยน **Theme** เป็น `Skylight`
หมายเหตุ: ธีมนี้ยังไม่ครอบคลุมทั้งหมด โปรดคำนึงถึงข้อนี้ด้วย

---

## 📐 วิธีการทำงาน (เบื้องหลัง)

### หลักการกรอง

`week-planner-card` ไม่รองรับการซ่อนปฏิทินเฉพาะแบบทันที เพื่อแก้ไขปัญหานี้ ผมใช้ **Input Texts** ทำหน้าที่เป็นตัวกรอง Regex

* เมื่อคุณคลิกปุ่มของแต่ละคน จะเป็นการสลับตัวกรองระหว่าง `.*` (แสดงทั้งหมด) และ `^$` (ไม่แสดงอะไรเลย)
* `config-template-card` จะใส่ตัวแปรเหล่านี้เข้าไปในปฏิทินแบบไดนามิก

### สคริปต์สร้างอีเวนต์

ป๊อปอัป "เพิ่มอีเวนต์" ใช้สคริปต์เดียวที่จัดการตรรกะสำหรับหลายบุคคลและหลายประเภทของอีเวนต์ (ทั้งแบบ All Day และแบบกำหนดเวลา)


```yaml
# Simplified Logic Example
target_calendar: "{{ calendar_map.get(states('input_select.calendar_select')) }}"

choose:
  - conditions: "All Day Event is ON"
    action: calendar.create_event (start_date, end_date)
  - conditions: "All Day Event is OFF"
    action: calendar.create_event (start_date_time, end_date_time)
```

## หมายเหตุ

โพสต์ต้นฉบับของผมเป็นเพียงการให้ภาพรวมในระดับสูงเกี่ยวกับวิธีการทำ และเปิดโอกาสให้ผู้ใช้ปรับแต่งโค้ดให้เหมาะสมกับสถานการณ์ของตนเอง

โดยเฉพาะอย่างยิ่งผมทำเช่นนี้เพราะแต่ละจอแสดงผลและความต้องการนั้นแตกต่างกัน ผมไม่สามารถพัฒนาให้รองรับขนาดจอแสดงผล แดชบอร์ด ฯลฯ ทุกรูปแบบได้ ดังนั้นจึงสร้างขึ้นเพื่อให้ทำงานกับจอที่ผมกล่าวถึงหรือจอขนาดใดก็ได้ (1920x1080) แต่สามารถแก้ไขให้เหมาะสมกับแบบอื่นๆ ได้

พูดถึงจอแสดงผล เดิมทีผมแนะนำรุ่นนั้นเพราะมันกำลังลดราคาที่ Woot และเป็นวิธีที่ประหยัดมากในการได้จอทัชสกรีนในขณะนั้น ซึ่งตอนนี้อาจไม่เป็นเช่นนั้นแล้ว ดังนั้นใช้จอที่เหมาะสมกับคุณได้เลย ไม่ว่าจะเป็นแท็บเล็ต ทัชสกรีน โทรศัพท์ หรืออะไรก็ได้ สิ่งสำคัญที่คุณจะต้องแก้ไขคือแดชบอร์ด



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-08

---
<h1 align="center">ModernZ - OSC ทางเลือกที่ดูทันสมัยสำหรับ mpv</h1>

OSC ที่ดูทันสมัยและเรียบหรูสำหรับ [mpv](https://mpv.io/) โครงการนี้เป็นโฟร์กของ ModernX ที่ออกแบบมาเพื่อเพิ่มฟังก์ชันการใช้งานด้วยการเพิ่มคุณสมบัติมากขึ้น ทั้งหมดนี้ยังคงรักษามาตรฐานหลักของ OSC ของ mpv ไว้

![ModernZ-OSC](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/f6854de6-1d57-4b2f-848e-7197933b71aa)

<p align="center">
    <a href="#installation"><strong>การติดตั้ง »</strong></a>
  <br>
  <a href="#configuration">การตั้งค่า</a>
  ·
  <a href="#controls">การควบคุม</a>
  ·
  <a href="#interactive-menus">เมนูโต้ตอบ</a>
  ·
  <a href="#translations">ภาษา OSC</a>
  ·
  <a href="#extras">สคริปต์เสริม</a>
</p>

## คุณสมบัติ

- 🎨 อินเทอร์เฟซทันสมัย ปรับแต่งได้ [[ตัวเลือก](#configuration)]
- 📷 โหมดดูรูปภาพพร้อมการควบคุมซูม [[รายละเอียด](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/IMAGE_VIEWER.md)]
- 🎛️ ปุ่ม: ดาวน์โหลด, เพลย์ลิสต์, ควบคุมความเร็ว, ถ่ายภาพหน้าจอ, ปักหมุด, ลูป, แคช และอื่นๆ [[รายละเอียด](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/CONTROLS.md)]
- 📄 เมนูโต้ตอบสำหรับเพลย์ลิสต์, ซับไตเติล, แยกบท, แทร็กเสียง และอุปกรณ์เสียง [[รายละเอียด](#interactive-menus)]
- 🌐 รองรับหลายภาษาโดยใช้ JSON [locale](#translations) แบบบูรณาการ
- ⌨️ ควบคุมที่ปรับแต่งได้ [[รายละเอียด](#controls)]
- 🖼️ ตัวอย่างภาพขนาดย่อวิดีโอด้วย [thumbfast](https://github.com/po5/thumbfast)

## การปรับแต่ง

คุณสามารถเปลี่ยนธีมไอคอนเป็น `fluent` หรือ `material` ให้ตรงกับความชอบและสไตล์ของคุณโดยใช้ตัวเลือก `icon_theme` ในไฟล์ `modernz.conf`

![modernz_fluent](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/3aafac8c-a13f-4840-8119-739523eb7a8e)

![modernz_material](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/e5ad6d06-f071-42ef-9210-296d95906d94)

ไม่ชอบปุ่มและข้อความสีขาวใช่ไหม? คุณมีอิสระเต็มที่ในการปรับแต่งสีและเลย์เอาต์ปุ่มให้เหมาะกับสไตล์ของคุณอย่างสมบูรณ์แบบ

![modernz_osc_controls_top](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/9e3df3af-d3ea-41bb-8c9a-9bf64c1d895a)

![modernz_osc_controls_bottom](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/d4e56bf5-ce7b-44e9-90a3-e27e922dd6bd)

ดูส่วน [การปรับแต่งสี](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md#colors-and-style) ในคู่มือการตั้งค่าสำหรับรายละเอียดเกี่ยวกับการปรับแต่งสีและปุ่ม

## เมนูโต้ตอบ

ModernZ รองรับคอนโซล/เมนูเลือกในตัวของ mpv ([v0.40+](https://github.com/mpv-player/mpv/releases/tag/v0.40.0)) สำหรับเพลย์ลิสต์, ซับไตเติล, การนำทางบท และอื่นๆ

[![preview_menus](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/4b7a3139-81f1-409b-98f5-f090a81d5ee6)](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/INTERACTIVE_MENUS.md)

## การติดตั้ง

1. **ปิดใช้งาน OSC ต้นฉบับ**

   - เพิ่ม `osc=no` ในไฟล์ `mpv.conf` ของคุณ

2. **คัดลอกไฟล์**

   - วางไฟล์ `modernz.lua` ในโฟลเดอร์สคริปต์ของ mpv
   - วางไฟล์ `fluent-system-icons.ttf` และ `material-design-icons.ttf` ในโฟลเดอร์ฟอนต์ของ mpv
   - (ทางเลือก) วางไฟล์ `thumbfast.lua` ในโฟลเดอร์สคริปต์ของ mpv

3. **ตำแหน่งที่ตั้ง**

   ```
   Linux:   ~/.config/mpv/
   Windows: C:/Users/%username%/AppData/Roaming/mpv/
   macOS:   ~/Library/Application Support/mpv/
   ```

4. **โครงสร้างโฟลเดอร์** [[คู่มือ mpv](https://mpv.io/manual/master/#files)]
   ```
   mpv/
   ├── fonts/
   │   ├── fluent-system-icons.ttf
   │   └── material-design-icons.ttf
   ├── script-opts/
   │   └── modernz.conf
   └── scripts/
   	   ├── modernz.lua
   	   └── thumbfast.lua (ทางเลือก)
   ```

## การตั้งค่า

1. สร้างไฟล์ `modernz.conf` ในโฟลเดอร์ `/script-opts` เพื่อปรับแต่งการตั้งค่า

   - [ดาวน์โหลด modernz.conf เริ่มต้น](https://raw.githubusercontent.com/Samillion/ModernZ/main/modernz.conf)

2. ตัวอย่างการตั้งค่าสั้น ๆ:

   ```EditorConfig
   # สีแถบค้นหา (รูปแบบเลขฐานสิบหก)
   seekbarfg_color=#B7410E

   # ตัวเลือกอินเทอร์เฟซ
   playlist_button=no
   title=${media-title}
   scalewindowed=1.0
   window_top_bar=auto
   ```

สำหรับรายการตัวเลือกทั้งหมด, [ดูรายการเต็มได้ที่นี่](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md).

## การควบคุม

### การโต้ตอบกับปุ่ม

- คลิกซ้าย: การดำเนินการหลัก
- คลิกขวา: การดำเนินการรอง
- คลิกกลาง/Shift+คลิกซ้าย: การดำเนินการทางเลือก

> [!NOTE]
> การคลิกกลางทำหน้าที่เหมือนกับ `Shift+คลิกซ้าย` ช่วยให้ใช้งานด้วยมือเดียวได้

สำหรับรายการการโต้ตอบทั้งหมด, ดูที่ [คู่มือการโต้ตอบกับปุ่ม](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/CONTROLS.md).

### การตั้งค่าคีย์บอร์ด

ModernZ ไม่ตั้งค่าคีย์บอร์ดเริ่มต้นเพื่อหลีกเลี่ยงการรบกวนการตั้งค่าปัจจุบันของคุณ คุณสามารถเพิ่มคีย์บอร์ดใน `input.conf` ได้ถ้าต้องการ:

```
w   script-binding modernz/progress-toggle           # สลับแถบความคืบหน้า
x   script-message-to modernz osc-show               # แสดง OSC
y   script-message-to modernz osc-visibility cycle   # สลับโหมดการมองเห็น
z   script-message-to modernz osc-idlescreen         # สลับหน้าจอว่าง
```

## การแปลภาษา

ModernZ ปัจจุบันมีให้ใช้งานในภาษาอังกฤษ แต่คุณสามารถเปลี่ยนเป็นภาษาที่คุณต้องการได้ง่าย ๆ ดังนี้:

1. **ดาวน์โหลดแพ็ค locale:**

ดาวน์โหลดไฟล์ [modernz-locale.json](https://raw.githubusercontent.com/Samillion/ModernZ/main/extras/locale/modernz-locale.json) จากที่เก็บนี้ ไฟล์นี้เก็บการแปลสำหรับหลายภาษา

2. **เพิ่ม locales ใน mpv:**

คัดลอกไฟล์ `modernz-locale.json` ที่ดาวน์โหลดไปไว้ในโฟลเดอร์ `/script-opts` ของ mpv ของคุณ

3. **เลือกภาษา:**

มีสองวิธีในการตั้งค่าภาษาที่ต้องการ:

- **แนะนำ:** ใช้ไฟล์ `modernz.conf`

  ```ini
  # ตัวอย่างการตั้งค่าใน modernz.conf
  # ตั้งค่าภาษาเป็นจีนตัวย่อ
  language=zh
  ```

- **ทางเลือก:** แก้ไขสคริปต์ `modernz.lua`

  เปิดไฟล์ `modernz.lua` และค้นหาส่วน `user_opts` ใกล้ต้นไฟล์ เปลี่ยนค่าของ `language` เป็นรหัสภาษาที่คุณต้องการ:

  ```lua
  local user_opts = {
      -- ทั่วไป
      language = "en",  -- เปลี่ยนเป็นรหัสภาษาที่คุณต้องการ
      ...
  }
  ```

**ต้องการข้อมูลเพิ่มเติม?**

สำหรับรายการภาษาที่มีทั้งหมด, แนวทางการมีส่วนร่วม และเอกสารการแปลอย่างละเอียด โปรดไปที่ [TRANSLATIONS.md](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/TRANSLATIONS.md).

## สคริปต์เสริม

สคริปต์ต่อไปนี้เป็นของที่ผมเขียนและดูแลเอง ใช้ได้ตามสะดวกหากมีประโยชน์สำหรับคุณ

- [Pause-Indicator-Lite](https://raw.githubusercontent.com/Samillion/ModernZ/main/extras/pause-indicator-lite) - สคริปต์ง่าย ๆ ที่แสดงตัวบ่งชี้เมื่อหยุดชั่วคราว

- [ytdlAutoFormat](https://github.com/Samillion/mpv-ytdlautoformat) - สคริปต์ mpv ง่าย ๆ สำหรับเปลี่ยน `ytdl-format` (yt-dlp) อัตโนมัติสำหรับโดเมนที่ระบุ

- [BoxtoWide](https://github.com/Samillion/mpv-boxtowide) - สคริปต์ mpv ง่าย ๆ สำหรับเปลี่ยนอัตราส่วนภาพ 4:3 ของไฟล์/สตรีมวิดีโอเป็น 16:9 อัตโนมัติ

สำหรับสคริปต์ที่มีประโยชน์มากขึ้น ดูที่ [mpv User Scripts Wiki](https://github.com/mpv-player/mpv/wiki/User-Scripts) ซึ่งรวบรวมสคริปต์ที่ชุมชนสร้างขึ้นเพื่อเพิ่มประสบการณ์การใช้ mpv ของคุณ

## ประวัติ

- [Samillion/ModernZ](https://github.com/Samillion/ModernZ)
  - โฟร์กจาก [dexeonify/ModernX](https://github.com/dexeonify/mpv-config/blob/main/scripts/modernx.lua)
    - โฟร์กจาก [cyl0/ModernX](https://github.com/cyl0/ModernX)
    - โฟร์กจาก [maoiscat/mpv-osc-modern](https://github.com/maoiscat/mpv-osc-modern)

**ทำไมต้องโฟร์กอีกครั้ง?**

- เพื่อเพิ่มฟีเจอร์มากมาย เช่น: [การปรับแต่งสี](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md#colors-and-style), [ตัวเลือก](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md) และ [การรวม Locale](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/TRANSLATIONS.md)
- เพื่อรวมคอนโซลและเมนูเลือกเข้ากับ osc ซึ่งเป็นแรงบันดาลใจให้ mpv นำไปใช้ใน osc ต้นฉบับ [อ้างอิง [#1](https://github.com/mpv-player/mpv/pull/15016), [#2](https://github.com/mpv-player/mpv/pull/15031)]
- เพื่อเพิ่มเลย์เอาต์เฉพาะสำหรับภาพ [[รายละเอียด](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/IMAGE_VIEWER.md)]
- เพื่อทำโครงการใหม่ทั้งหมดให้ตรงกับมาตรฐาน osc ต้นฉบับของ mpv เพื่อความเข้ากันได้
- เพื่อแก้ไขบั๊กเก่าและลดความซ้ำซ้อนในโค้ด
    - ซึ่งช่วยให้โฟร์ก `Modern` อื่น ๆ ใช้ ModernZ เป็นฐาน เช่น [zydezu/ModernX](https://github.com/zydezu/ModernX). [[อ้างอิง](https://github.com/zydezu/ModernX/releases/tag/0.3.9)]

โดยสรุปคือ เพื่อรักษาและฟื้นฟูต้นกำเนิด `modern-osc`
กล่าวอย่างนั้น ModernZ ยังคงใช้ส่วนหนึ่งของโค้ดเก่า และผู้เขียนและผู้ร่วมพัฒนาฟอร์กก่อนหน้าและปัจจุบันทุกคนสมควรได้รับเครดิต (รวมถึง osc ต้นฉบับของ mpv) นั่นคือเหตุผลที่พวกเขาถูกกล่าวถึงอย่างละเอียด

#### เครดิต:

- ฟอนต์: UI Fluent System Icons [[รายละเอียด](https://github.com/microsoft/fluentui-system-icons)] [[ไฟล์ฟอนต์](https://raw.githubusercontent.com/Samillion/ModernZ/main/fluent-system-icons.ttf)]
- ฟอนต์ที่ถูกแก้ไขโดย [Xurdejl](https://github.com/Xurdejl) สำหรับใช้งานใน ModernZ osc
- [mpv](https://github.com/mpv-player/mpv) และ [osc.lua](https://github.com/mpv-player/mpv/blob/master/player/lua/osc.lua) ของพวกเขา เนื่องจาก ModernZ osc ถูกสร้างใหม่บนมาตรฐาน osc ต้นฉบับและนำการอัปเดตจากนั้นมาใช้
- แหล่งที่มาของ osc สมัยใหม่ทั้งหมดและฟอร์กของพวกเขา ตามที่ระบุใน [ประวัติ](#history)
- ผู้ [ร่วมพัฒนา](https://github.com/Samillion/ModernZ/graphs/contributors), ผู้ทดสอบ และผู้ใช้ทุกคนที่ช่วยเหลือโดยตรงหรือโดยอ้อมกับ ModernZ osc ❤️

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---
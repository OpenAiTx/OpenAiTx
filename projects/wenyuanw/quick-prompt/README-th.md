# Quick Prompt

<div align="right">
  <details>
    <summary >🌐 Language</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<p align="center">
  <img src="https://raw.githubusercontent.com/wenyuanw/quick-prompt/main/./assets/icon.png" alt="Quick Prompt Logo" width="128" style="background: transparent;">
</p>

ส่วนขยายเบราว์เซอร์ที่ทรงพลัง มุ่งเน้นการจัดการ Prompt และการป้อนข้อมูลอย่างรวดเร็ว ช่วยให้ผู้ใช้สร้าง จัดการ และจัดระเบียบคลัง Prompt พร้อมทั้งสามารถแทรกเนื้อหา Prompt ที่ตั้งไว้ล่วงหน้าในกล่องป้อนข้อมูลของหน้าเว็บใด ๆ ได้อย่างรวดเร็ว เพิ่มประสิทธิภาพการทำงาน

> เนื่องจากปลั๊กอินเบราว์เซอร์สามารถใช้งานได้เฉพาะบนเว็บ จึงได้เปิดซอร์สปลั๊กอิน [Raycast](https://github.com/wenyuanw/quick-prompt-raycast) ที่มีฟีเจอร์เทียบเท่า และสามารถใช้งานกับรูปแบบข้อมูลเดียวกัน รองรับการถ่ายโอนข้อมูล JSON เดียวกันได้อย่างไร้รอยต่อ

## ✨ คุณลักษณะเด่น

- 📚 **การจัดการ Prompt**: สร้าง แก้ไข และจัดการคลัง Prompt ของคุณได้อย่างสะดวก
- 🚀 **กรอกข้อมูลอย่างรวดเร็ว**: ใช้ `/p` ในช่องกรอกข้อความของเว็บไซต์ใดก็ได้เพื่อเรียกตัวเลือก Prompt อย่างรวดเร็ว
- ⌨️ รองรับการตั้งค่าปุ่มลัดเพื่อเปิดตัวเลือก Prompt & บันทึกข้อความที่เลือกเป็น Prompt
- 📑 รองรับเมนูคลิกขวาเพื่อบันทึกข้อความที่เลือกเป็น Prompt ได้โดยตรง
- 🎯 รองรับการกำหนด Prompt เอง รวมถึงหมวดหมู่ ชื่อ เนื้อหา แท็ก และตัวแปร
- 🧑‍💻 **รองรับตัวแปร**: ใน Prompt สามารถใช้ตัวแปรรูปแบบ `{{ชื่อตัวแปร}}` และกรอกค่าได้ขณะใช้งาน
- 💾 **สำรองข้อมูล**: รองรับการส่งออกและนำเข้าคลัง Prompt เพื่อย้ายหรือสำรองข้อมูลข้ามอุปกรณ์ได้สะดวก
- 🔗 **ซิงค์กับคลาวด์**: รองรับการซิงค์คลัง Prompt กับฐานข้อมูล Notion หรือ Gitee/GitHub Gist
- 🔍 รองรับฟังก์ชันค้นหาและกรอง Prompt
- 🌙 ปรับโหมดมืด/สว่างอัตโนมัติตามธีมของระบบ

## 🚀 วิธีการใช้งาน

1. **เรียกใช้อย่างรวดเร็ว**: พิมพ์ `/p` ในช่องกรอกข้อความของเว็บเพจใดก็ได้เพื่อเปิดตัวเลือก Prompt
2. **ปุ่มลัดเปิดตัวเลือก**: ใช้ `Ctrl+Shift+P` (Windows/Linux) หรือ `Command+Shift+P` (macOS) เพื่อเปิดตัวเลือก Prompt
3. **เลือก Prompt**: คลิก Prompt ที่ต้องการจากตัวเลือกที่แสดงขึ้นมา ข้อความจะถูกแทรกลงในช่องกรอกโดยอัตโนมัติ
4. **บันทึก Prompt อย่างรวดเร็ว**: เลือกข้อความใดก็ได้ แล้วกด `Ctrl+Shift+S` (Windows/Linux) หรือ `Command+Shift+S` (macOS) เพื่อบันทึกเป็น Prompt ทันที
5. **บันทึกผ่านเมนูคลิกขวา**: เลือกข้อความที่ต้องการ คลิกขวาแล้วเลือก "บันทึก Prompt นี้" เพื่อบันทึกข้อความเป็น Prompt
6. **ส่งออกคลัง Prompt**: ในหน้าเมนูการจัดการ กดปุ่ม "ส่งออก" เพื่อบันทึก Prompt ทั้งหมดเป็นไฟล์ JSON ลงเครื่อง
7. **นำเข้าคลัง Prompt**: ในหน้าเมนูการจัดการ กดปุ่ม "นำเข้า" เพื่อโหลด Prompt จากไฟล์ JSON (รองรับรวมกับ Prompt เดิมหรือเขียนทับ)

## 📸 ตัวอย่างหน้าตา

Quick Prompt มีอินเทอร์เฟซที่ใช้งานง่ายและเป็นมิตร ช่วยให้คุณจัดการและใช้ Prompt ได้สะดวก

### ตัวเลือก Prompt

![ตัวเลือก Prompt](https://github.com/user-attachments/assets/41b9897c-d701-4ff0-97f7-2f1754f570a8)

![ตัวเลือก Prompt](https://github.com/user-attachments/assets/22d9d30c-b4c3-4e34-a0a0-8ef51e2cb942)

ใช้คำสั่งลัด `/p` หรือปุ่มลัดเพื่อเรียกตัวเลือก Prompt ในช่องกรอกข้อความใดก็ได้ เลือกและแทรก Prompt ที่ต้องการได้อย่างรวดเร็ว

### หน้าการจัดการ Prompt

![หน้าการจัดการ Prompt](https://github.com/user-attachments/assets/371ae51e-1cee-4a66-a2a5-cca017396872)

ในหน้าเมนูจัดการ คุณสามารถสร้าง Prompt ใหม่ แก้ไข Prompt เดิม เพิ่มแท็ก และจัดการหมวดหมู่ได้อย่างง่ายดาย อินเทอร์เฟซเรียบง่าย ใช้งานสะดวก

### เมนูคลิกขวาเพื่อบันทึก

![เมนูคลิกขวาเพื่อบันทึก](https://github.com/user-attachments/assets/17fc3bfd-3fa4-4b0b-ae1a-5cfd0b62be2e)

เพียงเลือกข้อความใด ๆ บนหน้าเว็บ แล้วคลิกขวาเพื่อบันทึกเป็น Prompt อย่างรวดเร็ว เพิ่มประสิทธิภาพการทำงาน

### การใส่ค่าตัวแปรของ Prompt

![หน้าต่างป้อนค่าตัวแปรของ Prompt](https://github.com/user-attachments/assets/c91c1156-983a-454d-aad0-5698b0291b9b)

Prompt รองรับการตั้งค่าตัวแปร เลือกแล้วจะมีหน้าต่างป๊อปอัพให้กรอกค่าตัวแปรที่ต้องการ

## ⚙️ การตั้งค่าด้วยตนเอง

1. คลิกที่ไอคอนส่วนขยาย แล้วคลิกปุ่ม "จัดการ Prompt"
2. ในหน้าจัดการ คุณสามารถ:
   - เพิ่ม Prompt ใหม่
   - แก้ไข Prompt ที่มีอยู่
   - ลบ Prompt ที่ไม่ต้องการ
   - เพิ่มแท็กให้ Prompt เพื่อจัดหมวดหมู่
   - ส่งออกคลัง Prompt เพื่อสำรองข้อมูล
   - นำเข้าคลัง Prompt ที่สำรองไว้ก่อนหน้า

## 📦 คู่มือการติดตั้ง

### ติดตั้งจากร้านค้าแอป

ขณะนี้พร้อมให้บริการบน Chrome Web Store! [คลิกที่นี่เพื่อติดตั้ง](https://chromewebstore.google.com/detail/quick-prompt/hnjamiaoicaepbkhdoknhhcedjdocpkd)

### ดาวน์โหลดจาก GitHub Releases

1. ไปที่ [หน้าดาวน์โหลด GitHub Releases](https://github.com/wenyuanw/quick-prompt/releases)
2. ดาวน์โหลดไฟล์ส่วนขยายเวอร์ชันล่าสุดที่สร้างไว้แล้ว
3. แตกไฟล์ที่ดาวน์โหลดมา
4. ติดตั้งส่วนขยายที่สร้างไว้ตามคำแนะนำด้านล่าง

### สร้างจากซอร์สโค้ด

1. โคลน repository
   ```bash
   git clone https://github.com/wenyuanw/quick-prompt.git
   cd quick-prompt
   ```
2. ติดตั้งไลบรารีที่จำเป็น
   ```bash
   pnpm install
   ```
3. การพัฒนาและการสร้าง

   ```bash
   # 开发模式 (Chrome)
   pnpm dev
   
   # 开发模式 (Firefox)
   pnpm dev:firefox
   
   # 构建扩展 (Chrome)
   pnpm build
   
   # 构建扩展 (Firefox)
   pnpm build:firefox
   ```

### ติดตั้งส่วนขยายที่ได้สร้างแล้ว

#### Chrome / Edge
1. เปิดหน้าจัดการส่วนขยาย (`chrome://extensions` หรือ `edge://extensions`)
2. เปิดใช้งาน "โหมดนักพัฒนา"
3. คลิก "โหลดส่วนขยายที่ถูกแตกไฟล์แล้ว"
4. เลือกไดเรกทอรี `.output/chrome-mv3/` ของโปรเจกต์

#### Firefox
1. เปิด `about:debugging`
2. คลิก "Firefox นี้"
3. คลิก "โหลดส่วนเสริมแบบชั่วคราว"
4. เลือกไฟล์ `manifest.json` ในไดเรกทอรี `.output/firefox-mv2/` ของโปรเจกต์

## 📄 ใบอนุญาต

MIT

## 🤝 แนวทางการมีส่วนร่วม

ยินดีต้อนรับการส่ง Pull Requests และ Issues!

1. Fork ที่เก็บนี้
2. สร้างฟีเจอร์สาขาของคุณ (`git checkout -b feature/amazing-feature`)
3. ส่งการเปลี่ยนแปลงของคุณ (`git commit -m 'Add some amazing feature'`)
4. push ไปที่สาขา (`git push origin feature/amazing-feature`)
5. เปิด Pull Request

## 👏 รายชื่อผู้ร่วมพัฒนา

ขอขอบคุณนักพัฒนาทุกคนที่มีส่วนร่วมกับโปรเจกต์นี้!

<a href="https://github.com/wenyuanw/quick-prompt/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=wenyuanw/quick-prompt" />
</a>


## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=wenyuanw/quick-prompt&type=Date)](https://www.star-history.com/#wenyuanw/quick-prompt&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-16

---
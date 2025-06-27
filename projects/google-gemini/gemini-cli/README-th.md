# Gemini CLI

[![Gemini CLI CI](https://github.com/google-gemini/gemini-cli/actions/workflows/ci.yml/badge.svg)](https://github.com/google-gemini/gemini-cli/actions/workflows/ci.yml)

![Gemini CLI Screenshot](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/assets/gemini-screenshot.png)

ที่เก็บนี้ประกอบด้วย Gemini CLI ซึ่งเป็นเครื่องมือเวิร์กโฟลว์ AI บนบรรทัดคำสั่งที่เชื่อมต่อกับเครื่องมือต่าง ๆ ของคุณ เข้าใจโค้ดของคุณ และช่วยเร่งกระบวนการทำงานของคุณ

ด้วย Gemini CLI คุณสามารถ:

- สอบถามและแก้ไขฐานโค้ดขนาดใหญ่ได้ทั้งในและเกินหน้าต่างบริบท 1M token ของ Gemini
- สร้างแอปใหม่จากไฟล์ PDF หรือสเก็ตช์ โดยใช้ความสามารถมัลติโหมดของ Gemini
- ทำงานอัตโนมัติงานปฏิบัติการ เช่น สอบถาม pull requests หรือจัดการกับการ rebase ที่ซับซ้อน
- ใช้เครื่องมือและเซิร์ฟเวอร์ MCP เพื่อเชื่อมต่อความสามารถใหม่ ๆ รวมถึง [การสร้างสื่อด้วย Imagen, Veo หรือ Lyria](https://github.com/GoogleCloudPlatform/vertex-ai-creative-studio/tree/main/experiments/mcp-genmedia)
- ทำให้คำถามของคุณแม่นยำขึ้นด้วยเครื่องมือ [Google Search](https://ai.google.dev/gemini-api/docs/grounding) ซึ่งมีใน Gemini

## เริ่มต้นใช้งานอย่างรวดเร็ว

1. **ข้อกำหนดเบื้องต้น:** ตรวจสอบให้แน่ใจว่าคุณได้ติดตั้ง [Node.js เวอร์ชัน 18](https://nodejs.org/en/download) หรือสูงกว่าไว้แล้ว
2. **เรียกใช้ CLI:** รันคำสั่งต่อไปนี้ในเทอร์มินัลของคุณ:

   ```bash
   npx https://github.com/google-gemini/gemini-cli
   ```

   หรือจะติดตั้งด้วยคำสั่ง:

   ```bash
   npm install -g @google/gemini-cli
   gemini
   ```

3. **เลือกธีมสี**
4. **ยืนยันตัวตน:** เมื่อระบบขอ ให้ลงชื่อเข้าใช้ด้วยบัญชี Google ส่วนตัวของคุณ ซึ่งจะทำให้คุณสามารถส่งคำร้องขอต่อโมเดลได้สูงสุด 60 ครั้งต่อนาที และ 1,000 ครั้งต่อวันด้วย Gemini

ตอนนี้คุณพร้อมที่จะใช้งาน Gemini CLI แล้ว!

### สำหรับการใช้งานขั้นสูงหรือขีดจำกัดที่เพิ่มขึ้น:

หากคุณต้องการใช้โมเดลเฉพาะหรือจำเป็นต้องใช้ความจุคำขอที่สูงขึ้น คุณสามารถใช้ API key ได้:

1. สร้างคีย์จาก [Google AI Studio](https://aistudio.google.com/apikey)
2. ตั้งค่าเป็นตัวแปรสภาพแวดล้อมในเทอร์มินัลของคุณ แทนที่ `YOUR_API_KEY` ด้วยคีย์ที่คุณสร้างขึ้น

   ```bash
   export GEMINI_API_KEY="YOUR_API_KEY"
   ```

สำหรับวิธีการยืนยันตัวตนอื่น ๆ รวมถึงบัญชี Google Workspace โปรดดู [คู่มือการยืนยันตัวตน](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/cli/authentication.md)

## ตัวอย่าง

เมื่อ CLI ทำงานแล้ว คุณสามารถเริ่มโต้ตอบกับ Gemini จาก shell ของคุณได้

คุณสามารถเริ่มโปรเจกต์จากไดเรกทอรีใหม่:

```sh
cd new-project/
gemini
> Write me a Gemini Discord bot that answers questions using a FAQ.md file I will provide
```

หรือทำงานกับโปรเจกต์ที่มีอยู่แล้ว:

```sh
git clone https://github.com/google-gemini/gemini-cli
cd gemini-cli
gemini
> Give me a summary of all of the changes that went in yesterday
```

### ขั้นตอนถัดไป

- เรียนรู้วิธี [ร่วมพัฒนาหรือ build จากซอร์สโค้ด](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/CONTRIBUTING.md)
- สำรวจ **[คำสั่ง CLI ที่มีอยู่](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/cli/commands.md)**
- หากพบปัญหาใด ๆ ให้ตรวจสอบ **[คู่มือการแก้ไขปัญหา](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/troubleshooting.md)**
- สำหรับเอกสารที่ครอบคลุมมากขึ้น โปรดดู [เอกสารฉบับเต็ม](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/index.md)
- ดูตัวอย่าง [งานยอดนิยม](#popular-tasks) เพื่อรับแรงบันดาลใจเพิ่มเติม

### การแก้ไขปัญหา

ไปที่ [คู่มือการแก้ไขปัญหา](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/troubleshooting.md) หากคุณมีปัญหา

## งานยอดนิยม

### สำรวจฐานโค้ดใหม่

เริ่มต้นด้วยการ `cd` ไปยังรีโพซิทอรีที่มีอยู่หรือที่โคลนมาใหม่ และรัน `gemini`

```text
> อธิบายส่วนประกอบหลักของสถาปัตยกรรมระบบนี้
```

```text
> มีมาตรการความปลอดภัยอะไรบ้าง?
```

### ทำงานกับโค้ดที่มีอยู่ของคุณ

```text
> เขียนฉบับร่างแรกสำหรับ GitHub issue #123
```

```text
> ช่วยฉันย้ายฐานโค้ดนี้ไปใช้ Java เวอร์ชันล่าสุด เริ่มต้นด้วยแผนงาน
```

### ทำงานอัตโนมัติในเวิร์กโฟลว์ของคุณ

ใช้เซิร์ฟเวอร์ MCP เพื่อผสานรวมเครื่องมือระบบโลคัลของคุณเข้ากับชุดเครื่องมือร่วมมือขององค์กร

```text
> สร้างชุดสไลด์ที่แสดงประวัติ git ในช่วง 7 วันที่ผ่านมา แยกตามฟีเจอร์และสมาชิกทีม
```

```text
> สร้างเว็บแอปแบบเต็มหน้าจอสำหรับแสดง GitHub issue ที่มีการโต้ตอบมากที่สุดของเรา
```

### โต้ตอบกับระบบของคุณ

```text
> แปลงรูปภาพทั้งหมดในไดเรกทอรีนี้เป็น png และเปลี่ยนชื่อโดยใช้วันที่จากข้อมูล exif
```

```text
> จัดระเบียบใบแจ้งหนี้ PDF ของฉันตามเดือนที่ใช้จ่าย
```

## ข้อกำหนดการให้บริการและนโยบายความเป็นส่วนตัว

สำหรับรายละเอียดเกี่ยวกับข้อกำหนดการให้บริการและนโยบายความเป็นส่วนตัวที่ใช้กับการใช้งาน Gemini CLI ของคุณ โปรดดู [ข้อกำหนดการให้บริการและนโยบายความเป็นส่วนตัว](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/tos-privacy.md)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---
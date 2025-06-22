<div align="center">
  <img src="https://raw.githubusercontent.com/ai-shifu/ChatALL/main/src/assets/logo-cover.png" width=256></img>
  <p><strong>พูดคุยกับบอท AI ทุกตัวพร้อมกัน ค้นหาสิ่งที่ดีที่สุด</strong></p>

[Deutsch](README_DE-DE.md) | English | [Español](README_ES-ES.md) | [Français](README_FR-FR.md) | [Italian](README_IT-IT.md) | [日本語](README_JA-JP.md) | [한국어](README_KO-KR.md) | [Русский](README_RU-RU.md) | [Tiếng Việt](README_VI-VN.md) | [简体中文](README_ZH-CN.md)

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/ai-shifu/ChatALL)

</div>

## ภาพหน้าจอ

![Screenshot](https://raw.githubusercontent.com/ai-shifu/ChatALL/main/screenshots/screenshot-1.png?raw=true)

## คุณสมบัติ

บอท AI ที่ใช้ Large Language Models (LLMs) นั้นน่าทึ่งมาก อย่างไรก็ตาม พฤติกรรมของแต่ละตัวอาจสุ่มและแต่ละบอทก็เก่งในงานที่แตกต่างกัน หากคุณต้องการประสบการณ์ที่ดีที่สุด ไม่ควรลองทีละตัว ChatALL (ชื่อภาษาจีน: 齐叨) สามารถส่งคำสั่ง (prompt) ไปยังบอท AI หลายตัวพร้อมกัน ช่วยให้คุณค้นหาผลลัพธ์ที่ดีที่สุด สิ่งที่คุณต้องทำคือ [ดาวน์โหลด ติดตั้ง](https://github.com/ai-shifu/ChatALL/releases) และถาม

### คุณคือคนแบบนี้หรือเปล่า?

ผู้ใช้ทั่วไปของ ChatALL ได้แก่:

- 🤠**กูรู LLMs** ที่ต้องการค้นหาคำตอบหรือผลงานที่ดีที่สุดจาก LLMs
- 🤓**นักวิจัย LLMs** ที่ต้องการเปรียบเทียบจุดเด่นจุดด้อยของ LLMs หลายตัวในแต่ละด้านอย่างเป็นรูปธรรม
- 😎**นักพัฒนาแอปพลิเคชัน LLM** ที่ต้องการดีบัก prompt อย่างรวดเร็วและค้นหาโมเดลพื้นฐานที่มีประสิทธิภาพดีที่สุด

### บอทที่รองรับ

| AI Bots                                                                        | Web Access  | API         | หมายเหตุ                                      |
| ------------------------------------------------------------------------------ | ----------- | ----------- | ------------------------------------------- |
| [360 AI Brain](https://ai.360.cn/)                                             | Yes         | No API      |                                             |
| [Baidu ERNIE](https://yiyan.baidu.com/)                                        | No          | Yes         |                                             |
| [Character.AI](https://character.ai/)                                          | Yes         | No API      |                                             |
| [ChatGLM2 6B & 130B](https://chatglm.cn/)                                      | Yes         | No API      | ไม่ต้องเข้าสู่ระบบ                          |
| [ChatGPT](https://chatgpt.com)                                             | Yes         | Yes         | รองรับ Web Browsing, Azure OpenAI service    |
| [Claude](https://www.anthropic.com/claude)                                     | Yes         | Yes         |                                             |
| [Code Llama](https://ai.meta.com/blog/code-llama-large-language-model-coding/) | Yes         | No API      |                                             |
| [Cohere Aya 23](https://cohere.com/blog/aya23)                                 | No          | Yes         |                                             |
| [Cohere Command R Models](https://cohere.com/command)                          | No          | Yes         |                                             |
| [Copilot](https://copilot.microsoft.com/)                                      | Yes         | No API      |                                             |
| [Dedao Learning Assistant](https://ai.dedao.cn/)                               | Coming soon | No API      |                                             |
| [Falcon 180B](https://huggingface.co/tiiuae/falcon-180B-chat)                  | Yes         | No API      |                                             |
| [Gemini](https://gemini.google.com/)                                           | Yes         | Yes         |                                             |
| [Gemma 2B & 7B](https://blog.google/technology/developers/gemma-open-models/)  | Yes         | No API      |                                             |
| [Gradio](https://gradio.app/)                                                  | Yes         | No API      | สำหรับ Hugging Face space/โมเดลที่ deploy เอง |
| [Groq Cloud](https://console.groq.com/docs/models)                             | No          | Yes         |                                             |
| [HuggingChat](https://huggingface.co/chat/)                                    | Yes         | No API      |                                             |
| [iFLYTEK SPARK](http://xinghuo.xfyun.cn/)                                      | Yes         | Coming soon |                                             |
| [Kimi](https://kimi.moonshot.cn/               )                               | Yes         | No API      |                                             |
| [Llama 2 13B & 70B](https://ai.meta.com/llama/)                                | Yes         | No API      |                                             |
| [MOSS](https://moss.fastnlp.top/)                                              | Yes         | No API      |                                             |
| [Perplexity](https://www.perplexity.ai/)                                       | Yes         | No API      |                                             |
| [Phind](https://www.phind.com/)                                                | Yes         | No API      |                                             |
| [Pi](https://pi.ai)                                                            | Yes         | No API      |                                             |
| [Poe](https://poe.com/)                                                        | Yes         | Coming soon |                                             |
| [SkyWork](https://neice.tiangong.cn/)                                          | Yes         | Coming soon |                                             |
| [Tongyi Qianwen](http://tongyi.aliyun.com/)                                    | Yes         | Coming soon |                                             |
| [Vicuna 13B & 33B](https://lmsys.org/blog/2023-03-30-vicuna/)                  | Yes         | No API      | ไม่ต้องเข้าสู่ระบบ                          |
| [WizardLM 70B](https://github.com/nlpxucan/WizardLM)                           | Yes         | No API      |                                             |
| [xAI Grok](https://x.ai)                                                       | No          | Yes         |                                             |
| [YouChat](https://you.com/)                                                    | Yes         | No API      |                                             |
| [You](https://you.com/)                                                        | Yes         | No API      |                                             |
| [Zephyr](https://huggingface.co/spaces/HuggingFaceH4/zephyr-chat)              | Yes         | No API      |                                             |

มีเพิ่มเติมในอนาคต โหวตบอทที่คุณชื่นชอบได้ที่ [issues เหล่านี้](https://github.com/ai-shifu/ChatALL/labels/more%20LLMs)

### หมายเหตุเกี่ยวกับความเสถียรของบอทที่เชื่อมต่อเว็บ

บอท AI ที่เชื่อมต่อผ่านเว็บ (ที่มี "Web Access") มีความเสถียรน้อยและมักมีปัญหา เพราะผู้ให้บริการจะอัปเดตเว็บอินเทอร์เฟซและมาตรการความปลอดภัยอย่างต่อเนื่อง การเชื่อมต่อแบบเว็บอาศัยการย้อนกลับวิศวกรรม ซึ่งดูแลรักษายากและมักใช้งานไม่ได้โดยไม่คาดคิด เพื่อประสบการณ์ที่เชื่อถือได้ เราขอแนะนำให้ใช้บอทที่มี API เสมอหากเป็นไปได้

### คุณสมบัติอื่น ๆ

- โหมดส่ง prompt ต่อเนื่อง: ส่ง prompt ถัดไปโดยไม่ต้องรอให้ request ก่อนหน้าสำเร็จ
- บันทึกประวัติการแชทไว้ในเครื่อง ปกป้องความเป็นส่วนตัว
- ไฮไลต์ข้อความตอบที่ชอบ ลบข้อความที่ไม่ดีได้
- เปิด/ปิดบอทแต่ละตัวได้ทุกเมื่อ
- สลับมุมมองแบบ 1, 2 หรือ 3 คอลัมน์
- อัปเดตอัตโนมัติเป็นเวอร์ชันล่าสุด
- โหมดมืด (โดย @tanchekwei)
- คีย์ลัด กด <kbd>Ctrl</kbd> + <kbd>/</kbd> เพื่อดูทั้งหมด (โดย @tanchekwei)
- หลายห้องแชท (โดย @tanchekwei)
- ตั้งค่า Proxy (โดย @msaong)
- จัดการ Prompt (โดย @tanchekwei)
- รองรับหลายภาษา (จีน อังกฤษ เยอรมัน ฝรั่งเศส รัสเซีย เวียดนาม เกาหลี ญี่ปุ่น สเปน อิตาลี)
- รองรับ Windows, macOS และ Linux

ฟีเจอร์ที่วางแผนไว้:

คุณสามารถมีส่วนร่วมพัฒนาฟีเจอร์เหล่านี้ได้

- [ ] เปิดหน้า front-end บน GitHub Pages

## ความเป็นส่วนตัว

ประวัติแชท การตั้งค่า และข้อมูลเข้าสู่ระบบทั้งหมดจะถูกบันทึกไว้ในเครื่องของคุณ

ChatALL เก็บข้อมูลการใช้งานแบบไม่ระบุตัวตนเพื่อช่วยพัฒนาผลิตภัณฑ์ รวมถึง:

- บอท AI ตัวใดบ้างที่ถูก prompt และความยาว prompt (ไม่รวมเนื้อหา prompt)
- ความยาวของคำตอบ และคำตอบใดถูกลบ/ไฮไลต์ (ไม่รวมเนื้อหาคำตอบ)

## ข้อกำหนดเบื้องต้น

ChatALL เป็น client ไม่ใช่ proxy ดังนั้นคุณต้อง:

1. มีบัญชีหรือโทเคน API ที่ใช้งานได้สำหรับแต่ละบอท
2. มีการเชื่อมต่อเครือข่ายที่เชื่อถือได้กับบอทแต่ละตัว

## ดาวน์โหลด / ติดตั้ง

ดาวน์โหลดได้ที่ https://github.com/ai-shifu/ChatALL/releases

### บน Windows

เพียงดาวน์โหลดไฟล์ \*-win.exe แล้วติดตั้งตามขั้นตอน

### บน macOS

สำหรับ Mac ที่ใช้ Apple Silicon (M1, M2 CPU) ให้ดาวน์โหลดไฟล์ \*-mac-arm64.dmg

สำหรับ Mac อื่น ๆ ให้ดาวน์โหลดไฟล์ \*-mac-x64.dmg

หากใช้ [Homebrew](https://brew.sh/) สามารถติดตั้งด้วยคำสั่ง:

```bash
brew install --cask chatall
```

### บน Linux

ดิสโทรแบบ Debian: ดาวน์โหลดไฟล์ .deb ดับเบิลคลิกเพื่อติดตั้งซอฟต์แวร์  
ดิสโทรแบบ Arch: โคลน ChatALL จาก AUR [ที่นี่](https://aur.archlinux.org/packages/chatall-bin) ติดตั้งด้วยตนเองหรือผ่าน AUR helper เช่น yay หรือ paru  
ดิสโทรอื่น ๆ: ดาวน์โหลดไฟล์ .AppImage ตั้งค่าให้รันได้ แล้วดับเบิลคลิกเพื่อใช้งาน คุณยังสามารถใช้ [AppimageLauncher](https://github.com/TheAssassin/AppImageLauncher)

## แก้ไขปัญหา

หากพบปัญหาในการใช้งาน ChatALL สามารถลองวิธีเหล่านี้:

1. **รีเฟรช** - กด <kbd>Ctrl</kbd> + <kbd>R</kbd> หรือ <kbd>⌘</kbd> + <kbd>R</kbd>
2. **รีสตาร์ท** - ปิด ChatALL แล้วเปิดใหม่
3. **เข้าสู่ระบบใหม่** - คลิกปุ่มการตั้งค่ามุมขวาบน แล้วคลิก login/logout สำหรับเว็บไซต์นั้น ๆ
4. **สร้างแชทใหม่** - คลิกปุ่ม `New Chat` แล้วส่ง prompt ใหม่อีกครั้ง

หากยังไม่สามารถแก้ไขได้ ให้ลอง **รีเซ็ต ChatALL** (ข้อมูลการตั้งค่าและประวัติแชทจะถูกลบทั้งหมด)

สามารถรีเซ็ตได้โดยลบโฟลเดอร์เหล่านี้:

- Windows: `C:\Users\<user>\AppData\Roaming\chatall\`
- Linux: `/home/<user>/.config/chatall/`
- macOS: `/Users/<user>/Library/Application Support/chatall/`

หากยังมีปัญหา กรุณา [แจ้งปัญหา](https://github.com/ai-shifu/ChatALL/issues)

## สำหรับนักพัฒนา

### เพิ่มบอทใหม่

[คู่มือ](https://github.com/ai-shifu/ChatALL/wiki/%E5%A6%82%E4%BD%95%E6%B7%BB%E5%8A%A0%E4%B8%80%E4%B8%AA%E6%96%B0%E7%9A%84-AI-%E5%AF%B9%E8%AF%9D%E6%9C%BA%E5%99%A8%E4%BA%BA) อาจช่วยคุณได้

### รันโปรแกรม

```bash
npm install
npm run electron:serve
```

### สร้างแพ็กเกจ

สร้างสำหรับแพลตฟอร์มปัจจุบัน:

```bash
npm run electron:build
```

สร้างสำหรับทุกแพลตฟอร์ม:

```bash
npm run electron:build -- -wml --x64 --arm64
```

## เครดิต

### ผู้ร่วมพัฒนา

<a href="https://github.com/ai-shifu/ChatALL/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=ai-shifu/ChatALL" />
</a>

### อื่น ๆ

- GPT-4 มีส่วนช่วยในโค้ดจำนวนมาก
- ChatGPT, Copilot และ Google มีส่วนช่วยให้คำตอบหลายอย่าง (เรียงลำดับตามความถี่)
- ได้รับแรงบันดาลใจจาก [ChatHub](https://github.com/chathub-dev/chathub) ขอแสดงความเคารพ!

## สนับสนุนโครงการ

หากคุณชื่นชอบโปรเจกต์นี้ กรุณาพิจารณา:

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/F1F8KZJGJ)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-22

---
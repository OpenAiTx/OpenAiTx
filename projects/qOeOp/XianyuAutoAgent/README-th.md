<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# 🚀 Xianyu AutoAgent - ระบบแชทบอท AI อัจฉริยะสำหรับแพลตฟอร์ม Xianyu

[![Java Version](https://img.shields.io/badge/java21%2B-blue)](https://www.python.org/) [![LLM Powered](https://img.shields.io/badge/LLM-powered-FF6F61)](https://platform.openai.com/)

โซลูชั่น AI สำหรับแพลตฟอร์ม Xianyu โดยเฉพาะ ให้บริการดูแลอัตโนมัติ 7×24 ชั่วโมง รองรับการตัดสินใจร่วมแบบผู้เชี่ยวชาญหลายคน, ต่อรองราคาอัจฉริยะ และสนทนาแบบเข้าใจบริบท

## 🎮 Playground - ทดลองใช้งานด่วน (เวอร์ชันไม่ต้องตั้งค่า)

ไม่ต้องติดตั้งหรือกำหนดค่า Secrets บนเครื่อง! **เพียงกรอกพารามิเตอร์ผ่านหน้าเว็บ GitHub Actions** ก็สามารถเริ่มต้นใช้งานบอท Xianyu ได้ทันที

### วิธีการใช้งาน
1. **Fork โครงการนี้** → กดปุ่ม `Fork` ที่มุมขวาบน
2. **เรียกใช้งาน Action**:
   - เข้าไปที่แท็บ `Actions` ในรีโปของคุณ
   - เลือก **`🚀 Run Service`** เวิร์กโฟลว์
   - คลิกปุ่ม **`Run workflow`** แล้วกรอกพารามิเตอร์:
      - `API Key`: วาง API Key ของโมเดล AI (เช่น Aliyun DashScope)
      - `Cookies`: วางคุกกี้จากหน้าเว็บ Xianyu เต็มรูปแบบ
3. **ดูบันทึกการทำงาน**:
   - หลังบอทเริ่มต้นจะรับฟังข้อความจาก Xianyu อัตโนมัติ
   - ค้นหา `🤖 Reply:` ในบันทึก Action เพื่อดูประวัติการสนทนา

### หมายเหตุ
⚠️ ข้อจำกัดการใช้งานชั่วคราว:
- เริ่มต้น **30 นาที** (ข้อจำกัดบัญชีฟรีของ GitHub)
- ข้อมูลสำคัญ (เช่น Cookie) **จะไม่ถูกเก็บไว้** ใช้เพียงครั้งเดียว

<div align="center">
  <img src="https://raw.githubusercontent.com/qOeOp/XianyuAutoAgent/main/./screenshots/workflow.png" width="400px" alt="workflow">
</div>

## 🌟 คุณสมบัติหลัก

### เอนจินสนทนาอัจฉริยะ
| โมดูลฟังก์ชัน   | เทคนิคที่ใช้              | คุณสมบัติเด่น                                             |
| --------------- | --------------------- | ------------------------------------------------------ |
| เข้าใจบริบท    | บันทึกประวัติสนทนา        | จัดการความจำสนทนาแบบเบา ใช้ประวัติสนทนาเป็นข้อมูลบริบท LLM |
| เส้นทางผู้เชี่ยวชาญ | LLM prompt+กฎการกำหนดเส้นทาง | แยกแยะเจตนาจาก prompt → ส่งต่อไปยัง Agent ผู้เชี่ยวชาญ, รองรับสลับต่อรอง/เทคนิค/บริการลูกค้า |

### เมทริกซ์ฟังก์ชันธุรกิจ
| โมดูล      | ดำเนินการแล้ว                  | วางแผนในอนาคต             |
| ---------- | ----------------------------- | ----------------------- |
| เอนจินหลัก | ✅ ตอบกลับอัตโนมัติด้วย LLM<br>✅ จัดการบริบท | 🔄 เพิ่มการวิเคราะห์อารมณ์        |
| ระบบต่อรอง | ✅ กลยุทธ์ลดราคาขั้นบันได           | 🔄 ฟีเจอร์เปรียบเทียบราคาตลาด         |
| ซัพพอร์ตเทคนิค | ✅ รวมการค้นหาออนไลน์             | 🔄 เสริมคลังความรู้ RAG           |

## 🚴 เริ่มต้นใช้งานอย่างรวดเร็ว

### ข้อกำหนดสภาพแวดล้อม
- JDK 21+
- Maven 3.9.10+

### ขั้นตอนการติดตั้ง

```bash
1. 克隆仓库
git clone https://github.com/qOeOp/XianyuAutoAgent.git
cd XianyuAutoAgent

2. 配置环境变量
- AI_DASHSCOPE_API_KEY : 阿里云大模型API-KEY
- COOKIES_STR : 闲鱼网页端Cookie

3. 执行命令
mvn spring-boot:run
注意：默认使用的模型是通义千问，如需使用其他API，请自行修改application.yml文件中的模型地址和模型名称；
COOKIES_STR自行在闲鱼网页端获取cookies(网页端F12打开控制台，选择Network，点击Fetch/XHR,点击一个请求，查看cookies)

4. (可选)创建提示词文件src/main/resources/*-prompt.txt
```
## 🤝 การมีส่วนร่วมและการสนับสนุน

ยินดีต้อนรับทุกข้อเสนอแนะผ่าน Issue หรือการส่งโค้ดด้วย PR โปรดปฏิบัติตาม [แนวทางการมีส่วนร่วม](https://contributing.md/)



## 🛡 หมายเหตุสำคัญ

⚠️ หมายเหตุ: **โครงการนี้ใช้เพื่อการเรียนรู้และแลกเปลี่ยนเท่านั้น หากมีการละเมิดโปรดติดต่อผู้เขียนเพื่อลบออก**

เนื่องจากลักษณะเฉพาะของโครงการ ทีมพัฒนาอาจ**หยุดอัปเดต**หรือ**ลบโครงการ**ได้ทุกเมื่อ


## 🧸 ขอขอบคุณเป็นพิเศษ

โครงการนี้ถูกพัฒนาขึ้นใหม่โดยอ้างอิงจากโครงการโอเพนซอร์สดังต่อไปนี้:
- [XianyuAutoAgent](https://github.com/shaxiu/XianyuAutoAgent) - ระบบแชทบอทอัจฉริยะสำหรับผู้ช่วยใน Xianyu พัฒนาโดย [@shaxiu](https://github.com/shaxiu) และ [@cv-cat](https://github.com/cv-cat)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---
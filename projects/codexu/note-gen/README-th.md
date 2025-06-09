![note-gen](https://socialify.git.ci/codexu/note-gen/image?custom_description=Cross-Platform+%7C+LLM+%7C+Markdown+%7C++Recording++%26+Writing&description=1&font=Raleway&forks=1&issues=1&logo=https%3A%2F%2Fcamo.githubusercontent.com%2Fbe4a3a39f8724658ad5bc549d63f0454ad4ca98564c73b7b0778704ca5212509%2F68747470733a2f2f73322e6c6f6c692e6e65742f323032352f30352f32362f594d4e67784b5644724238345a74572e706e67&name=1&owner=1&pattern=Circuit+Board&stargazers=1&theme=Light)

# NoteGen

![](https://github.com/codexu/note-gen/actions/workflows/release.yml/badge.svg?branch=release)
![](https://img.shields.io/github/v/release/codexu/note-gen)
![](https://img.shields.io/badge/version-alpha-orange)
![](https://img.shields.io/github/downloads/codexu/note-gen/total)
![](https://img.shields.io/github/commit-activity/m/codexu/note-gen)

English | [简体中文](.github/README.zh.md) | [日本語](.github/README.ja.md)

<div style="display: flex; gap: 1rem;">
  <a href="https://www.producthunt.com/products/notegen-2?embed=true&utm_source=badge-featured&utm_medium=badge&utm_source=badge-notegen&#0045;2" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=956348&theme=light&t=1749194675492" alt="NoteGen - A&#0032;cross&#0045;platform&#0032;Markdown&#0032;note&#0045;taking&#0032;application | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

  <a href="https://trendshift.io/repositories/12784" target="_blank"><img src="https://trendshift.io/api/badge/repositories/12784" alt="codexu%2Fnote-gen | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a>
</div>

## คู่มือ

NoteGen คือแอปพลิเคชันจดบันทึก `Markdown` ข้ามแพลตฟอร์มที่มุ่งเน้นการใช้ AI เชื่อมโยงการบันทึกและการเขียน จัดระเบียบความรู้ที่กระจัดกระจายให้กลายเป็นโน้ตที่อ่านง่าย

🖥️ เอกสารทางการ: [https://notegen.top](https://notegen.top)

💬 เข้าร่วม [กลุ่ม WeChat/QQ](https://github.com/codexu/note-gen/discussions/110)

## ทำไมต้องเลือก NoteGen?

- น้ำหนักเบา: [ไฟล์ติดตั้ง](https://github.com/codexu/note-gen/releases) มีขนาด **เพียง 20MB** ฟรี ไม่มีโฆษณาหรือซอฟต์แวร์แถม
- ข้ามแพลตฟอร์ม: รองรับ Mac, Windows, Linux และด้วยความสามารถข้ามแพลตฟอร์มของ `Tauri2` จะรองรับ iOS และ Android ในอนาคต
- รองรับวิธีการบันทึกหลายรูปแบบ เช่น `ภาพหน้าจอ`, `ข้อความ`, `ภาพประกอบ`, `ไฟล์`, `ลิงก์` ฯลฯ ตอบโจทย์การบันทึกแบบกระจัดกระจายในหลายสถานการณ์
- ใช้ `Markdown(.md)` เป็นรูปแบบการจัดเก็บโดยตรง ไม่มีการปรับเปลี่ยน ง่ายต่อการย้ายข้อมูล
- ใช้งานแบบออฟไลน์โดยสมบูรณ์ รองรับการซิงก์แบบเรียลไทม์ไปยัง `GitHub, Gitee (private repositories)` พร้อมประวัติย้อนกลับ และซิงก์ผ่าน WebDAV
- เสริมพลังด้วย AI: กำหนดค่า ChatGPT, Gemini, Ollama, LM Studio, Grok และโมเดลอื่น ๆ ได้เอง รวมถึงรองรับการกำหนดค่าบุคคลที่สาม
- RAG: โน้ตของคุณคือคลังความรู้ของคุณ รองรับ embedding models และ reranking models

## ภาพหน้าจอ

https://github.com/user-attachments/assets/4f8a3bc5-17f5-4b36-9b17-d87128685257

การบันทึก:

![1.png](https://s2.loli.net/2025/05/19/Cs5viKfkqb2HJmd.png)

การเขียน:

![2.png](https://s2.loli.net/2025/05/19/5vwQBPoLr6jzgUA.png)

ธีม:

![3.png](https://s2.loli.net/2025/05/19/8yU72prmWdsCHeu.png)

## จากการบันทึกสู่การเขียน

แอปจดบันทึกทั่วไปมักไม่มีฟังก์ชันการบันทึกเสียงหรือข้อมูล ผู้ใช้ต้องคัดลอกและวางเนื้อหาด้วยตนเอง ซึ่งลดประสิทธิภาพลงอย่างมาก และเมื่อมีข้อมูลที่บันทึกแบบกระจัดกระจาย ก็ต้องใช้ความพยายามสูงในการจัดระเบียบ

NoteGen แบ่งเป็นหน้าต่าง `บันทึก (Recording)` และ `เขียน (Writing)` โดยมีความสัมพันธ์ดังนี้

- บันทึกสามารถจัดระเบียบเป็นโน้ตและส่งต่อไปยังหน้าการเขียนเพื่อแต่งเนื้อหาอย่างละเอียด
- ระหว่างการเขียน สามารถแทรกบันทึกเข้ามาได้ทุกเมื่อ

### การบันทึก

ฟังก์ชันบันทึกมีลักษณะคล้าย **AI chatbot** แต่ขณะสนทนา คุณสามารถเชื่อมโยงกับเนื้อหาที่บันทึกไว้ก่อนหน้า สลับจากโหมดสนทนาเป็นโหมดจัดระเบียบ เพื่อจัดเรียงบันทึกให้กลายเป็นโน้ตที่อ่านเข้าใจง่าย

คุณสมบัติเสริมต่อไปนี้จะช่วยให้คุณบันทึกได้อย่างมีประสิทธิภาพยิ่งขึ้น:

- **แท็ก** เพื่อแยกแยะสถานการณ์การบันทึกที่แตกต่างกัน
- **บุคลิก (Personas)** พร้อมรองรับ custom prompt เพื่อควบคุมผู้ช่วย AI ได้อย่างแม่นยำ
- **ผู้ช่วยคลิปบอร์ด** ที่ตรวจจับข้อความหรือรูปในคลิปบอร์ดโดยอัตโนมัติและบันทึกเข้าในรายการ

### การเขียน

ส่วนการเขียนแบ่งออกเป็นสองส่วน คือ **ตัวจัดการไฟล์** และ **เครื่องมือแก้ไข Markdown**

**ตัวจัดการไฟล์**

- รองรับการจัดการไฟล์ Markdown ในเครื่องและไฟล์ที่ซิงก์กับ GitHub
- รองรับโครงสร้างไดเรกทอรีแบบไม่จำกัดชั้น
- รองรับวิธีการจัดเรียงหลายรูปแบบ

**เครื่องมือแก้ไข Markdown**

- รองรับ WYSIWYG, การแสดงผลทันที และโหมดแสดงตัวอย่างแบบแยกหน้าจอ
- รองรับการควบคุมเวอร์ชัน พร้อมย้อนกลับประวัติได้
- รองรับ AI ช่วยเหลือ ทั้งสนทนา, ต่อเนื่อง, ขัดเกลา, และแปลภาษา
- รองรับโฮสต์รูปภาพ อัปโหลดและแปลงเป็นลิงก์ภาพแบบ Markdown
- รองรับแปลง HTML เป็น Markdown โดยแปลงเนื้อหาที่คัดลอกจากเบราว์เซอร์อัตโนมัติ
- รองรับโครงร่าง, สูตรคณิตศาสตร์, แผนผังความคิด, กราฟ, แผนผังลำดับงาน, แผนภูมิแกนต์, แผนภาพลำดับ, โน้ตดนตรี, มัลติมีเดีย, การอ่านเสียง, การสร้าง anchor หัวข้อ, ไฮไลท์และคัดลอกรหัส, การแสดงผล graphviz และไดอะแกรม UML ด้วย plantuml
- รองรับการบันทึกเนื้อหาแบบเรียลไทม์ในเครื่อง, ซิงก์อัตโนมัติเมื่อไม่มีการแก้ไข 10 วินาที และย้อนกลับประวัติได้

## ฟีเจอร์อื่น ๆ

- ค้นหาทั่วทั้งโปรแกรม เพื่อค้นหาและไปยังเนื้อหาที่ต้องการได้อย่างรวดเร็ว
- จัดการโฮสต์รูปภาพ เพื่อจัดการคลังภาพได้สะดวก
- ปรับแต่งธีมและรูปลักษณ์ รองรับโหมดกลางคืน และปรับแต่ง Markdown, โค้ด ฯลฯ
- รองรับหลายภาษา ขณะนี้มีภาษาไทยและอังกฤษ

## วิธีใช้งาน

### ดาวน์โหลด

ขณะนี้รองรับ Mac, Windows และ Linux ด้วยศักยภาพข้ามแพลตฟอร์มของ Tauri2 จะรองรับ iOS และ Android ในอนาคต

[ดาวน์โหลด NoteGen (alpha)](https://github.com/codexu/note-gen/releases)

### การเสริมประสิทธิภาพ

แอปจดบันทึกสามารถใช้ได้ทันทีโดยไม่ต้องตั้งค่า หากต้องการประสบการณ์ที่ดียิ่งขึ้น กรุณาเปิดหน้าตั้งค่าเพื่อกำหนดค่า AI และการซิงก์

## มีส่วนร่วม

- [อ่านคู่มือการมีส่วนร่วม](https://raw.githubusercontent.com/codexu/note-gen/dev/.github/CONTRIBUTING.md)
- [แผนอัปเดต](https://github.com/codexu/note-gen/issues/46)
- [แจ้งบั๊กหรือข้อเสนอแนะ](https://github.com/codexu/note-gen/issues)
- [พูดคุย](https://github.com/codexu/note-gen/discussions)

## ผู้ร่วมพัฒนา

<a href="https://github.com/codexu/note-gen/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=codexu/note-gen" />
</a>

## ประวัติดาว (Star History)

[![Star History Chart](https://api.star-history.com/svg?repos=codexu/note-gen&type=Date)](https://www.star-history.com/#codexu/note-gen&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---
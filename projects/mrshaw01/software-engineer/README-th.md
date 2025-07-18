<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
  <h1>วิศวกรซอฟต์แวร์</h1>
  <p>
    <img src="https://img.shields.io/github/actions/workflow/status/mrshaw01/software-engineer/pre-commit.yml?branch=main&label=pre-commit&logo=pre-commit&logoColor=white" alt="pre-commit status">
  </p>

  <p>
    <img src="https://img.shields.io/github/last-commit/mrshaw01/software-engineer" alt="Last Commit">
    <img src="https://img.shields.io/github/issues/mrshaw01/software-engineer" alt="Issues">
    <img src="https://img.shields.io/github/issues-pr/mrshaw01/software-engineer" alt="Pull Requests">
  </p>
</div>

ชุดรวมแหล่งข้อมูลการเรียนรู้คุณภาพสูงที่คัดสรรมาอย่างดี โดยเน้นที่ **Python** และในอนาคต **C/C++** ออกแบบมาเพื่อสร้างรากฐานที่แข็งแกร่งด้านวิศวกรรมซอฟต์แวร์และความเข้าใจในระดับระบบ

## โครงสร้างของ Repository

```text
.
├── python-basic/           # Essential Python syntax, data types, and operations
├── python-advanced/        # Decorators, threading, logging, JSON, and more
├── python-OOP/             # Deep dive into Python's object-oriented programming
├── cpp-basic/              # Fundamentals of C++: syntax, memory, pointers, etc.
├── cpp-advanced/           # Advanced C++: RAII, noexcept, smart pointers, RVO, etc.
├── cpp-OOP/                # Object-oriented programming in C++
├── CUDA/                   # GPU programming with CUDA (host & device code)
├── MPI/                    # Message Passing Interface programming and demos
├── docs/                   # System-level notes on performance, Python-C++ interop, mixed precision, etc.
└── README.md               # Project overview (this file)
```
## วิธีการใช้งาน

แต่ละโฟลเดอร์ที่มีหมายเลขจะมีไฟล์ `README.md` อธิบายแนวคิด พร้อมไฟล์ `.py` ที่สามารถรันได้ ตัวอย่างเช่น:


```bash
cd python-advanced/08-decorators
python basic_function_decorator.py
```
สคริปต์บางตัวต้องการไลบรารีจากบุคคลที่สาม (เช่น `numpy`, `scipy`, `torch`)

โค้ดทั้งหมดสามารถใช้งานกับ **Python 3.7+** และเขียนให้มีความ **กระทัดรัด, ตรงประเด็น, และทดสอบได้ง่าย**

## ไฮไลท์

### Python

- **เชี่ยวชาญ OOP**: คลาส, การสืบทอด, เมตาคลาส, ดีสคริปเตอร์ (`python-OOP/`)
- **หัวข้อขั้นสูง**: เดคอเรเตอร์, คอนเท็กซ์เมเนเจอร์, แคชฟังก์ชัน, การประมวลผลแบบขนาน
- **โครงสร้างข้อมูล**: ลิสต์, ทูเพิล, ดิกต์, เซ็ต พร้อมตัวอย่างการใช้งานจริง

### C++

- **พื้นฐาน C++**: ไวยากรณ์, ฟังก์ชัน, พอยน์เตอร์, สตรัคต์, ขอบเขต, เอนัม (`cpp-basic/`)
- **C++ สมัยใหม่**: RAII, สมาร์ทพอยน์เตอร์, การย้ายข้อมูล, การจัดแนว, RVO (`cpp-advanced/`)
- **C++ OOP**: คลาส, การกำหนดสิทธิ์เข้าถึง, การสืบทอด, พอลิมอร์ฟิซึม, เท็มเพลต

### Systems & Performance

- **การเขียนโปรแกรม CUDA**: โมเดลโฮสต์/ดีไวซ์, การเรียกเคอร์เนล, การจัดการหน่วยความจำ (`CUDA/`)
- **การเขียนโปรแกรม MPI**: โปรแกรมกระจายแบบใช้งานจริง, การดำเนินการกับเมทริกซ์, และการตรวจสอบผล (`MPI/`)
- **เอกสาร**: การเชื่อมต่อ Python-C++, การจัดการ GIL, การปรับแต่ง CUDA, การเทรนแบบ precision ผสม (`docs/`)

## ปรัชญาการเรียนรู้

- ตัวอย่างขนาดเล็ก แยกโมดูล — ไม่มีโน้ตบุ๊กที่รกตา
- แยกชัดเจนระหว่างแนวคิด, โค้ด, และคำอธิบาย
- เน้นการออกแบบ, ประสิทธิภาพ และการดูแลรักษา
- สร้างพื้นฐานความรู้แบบต่อเนื่อง — เหมาะสำหรับผู้เรียนจริงจังและมืออาชีพ

## ประวัติการกดดาว

<a href="https://www.star-history.com/#mrshaw01/software-engineer&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=mrshaw01/software-engineer&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=mrshaw01/software-engineer&type=Date" />
   <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=mrshaw01/software-engineer&type=Date" />
 </picture>
</a>

## 🤝 การมีส่วนร่วม

พบข้อผิดพลาด, คำผิด, หรืออยากขยายอะไรเพิ่มเติม? เปิด PR ได้เลย — ยินดีรับทุกการมีส่วนร่วม

<p align="center">
  <a href="https://github.com/mrshaw01/software-engineer/graphs/contributors">
    <img src="https://contrib.rocks/image?repo=mrshaw01/software-engineer" />
  </a>
</p>

## 📄 ใบอนุญาต

ใบอนุญาต MIT — สามารถใช้ ดัดแปลง และแบ่งปันได้ฟรีเพื่อการเรียนรู้และการสอน



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---
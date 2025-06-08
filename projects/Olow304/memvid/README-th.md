# Memvid - หน่วยความจำ AI แบบวิดีโอ 🧠📹

**โซลูชันน้ำหนักเบา ปฏิวัติวงการสำหรับหน่วยความจำ AI ขนาดใหญ่**

[![PyPI version](https://badge.fury.io/py/memvid.svg)](https://pypi.org/project/memvid/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Python 3.8+](https://img.shields.io/badge/python-3.8+-blue.svg)](https://www.python.org/downloads/)
[![Code style: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)

Memvid พลิกโฉมการจัดการหน่วยความจำ AI ด้วยการเข้ารหัสข้อมูลข้อความลงในวิดีโอ ช่วยให้สามารถ **ค้นหาเชิงความหมายได้อย่างรวดเร็วสุดขีด** ในข้อมูลข้อความนับล้านชิ้นด้วย **เวลาค้นหาต่ำกว่าหนึ่งวินาที** แตกต่างจากฐานข้อมูลเวกเตอร์แบบดั้งเดิมที่กิน RAM และพื้นที่จัดเก็บมหาศาล Memvid บีบอัดฐานความรู้ของคุณไว้ในไฟล์วิดีโอขนาดเล็ก ขณะที่ยังเข้าถึงข้อมูลแต่ละชิ้นได้ทันที

## 🎥 สาธิต

https://github.com/user-attachments/assets/ec550e93-e9c4-459f-a8a1-46e122b5851e

## ✨ คุณสมบัติเด่น

- 🎥 **วิดีโอแทนฐานข้อมูล**: เก็บข้อความนับล้านชิ้นในไฟล์ MP4 เดียว
- 🔍 **ค้นหาเชิงความหมาย**: ค้นหาข้อมูลที่เกี่ยวข้องด้วยภาษาธรรมชาติ
- 💬 **สนทนาในตัว**: อินเทอร์เฟซแชทตอบกลับตามบริบท
- 📚 **รองรับ PDF**: นำเข้าและสร้างดัชนีเอกสาร PDF ได้โดยตรง
- 🚀 **ค้นหาว่องไว**: ค้นหาข้อมูลขนาดใหญ่ในเวลาต่ำกว่าหนึ่งวินาที
- 💾 **ประหยัดพื้นที่**: บีบอัดข้อมูลได้มากกว่าฐานข้อมูลทั่วไป 10 เท่า
- 🔌 **รองรับ LLM เสียบเปลี่ยนได้**: ใช้งานกับ OpenAI, Anthropic หรือโมเดลโลคอล
- 🌐 **ออฟไลน์เต็มรูปแบบ**: ไม่ต้องใช้อินเทอร์เน็ตหลังสร้างวิดีโอแล้ว
- 🔧 **API เรียบง่าย**: เริ่มต้นได้ด้วยโค้ดเพียง 3 บรรทัด

## 🎯 กรณีใช้งาน

- **📖 ห้องสมุดดิจิทัล**: สร้างดัชนีหนังสือนับพันในไฟล์วิดีโอเดียว
- **🎓 สื่อการศึกษา**: สร้างหน่วยความจำวิดีโอที่ค้นหาได้ของเนื้อหาบทเรียน
- **📰 คลังข่าว**: บีบอัดบทความนับปีเป็นฐานข้อมูลวิดีโอที่จัดการง่าย
- **💼 องค์ความรู้บริษัท**: สร้างฐานความรู้ที่ค้นหาได้ทั่วทั้งองค์กร
- **🔬 วิทยานิพนธ์และงานวิจัย**: ค้นหาเชิงความหมายในวรรณกรรมวิทยาศาสตร์ได้รวดเร็ว
- **📝 บันทึกส่วนตัว**: เปลี่ยนโน้ตของคุณให้เป็นผู้ช่วย AI ค้นหาได้

## 🚀 ทำไมต้อง Memvid?

### นวัตกรรมพลิกวงการ
- **วิดีโอแทนฐานข้อมูล**: เก็บข้อความนับล้านชิ้นในไฟล์ MP4 เดียว
- **เรียกคืนทันที**: ค้นหาเชิงความหมายขนาดใหญ่ในเวลาต่ำกว่าหนึ่งวินาที
- **ประหยัดพื้นที่กว่า 10 เท่า**: บีบอัดวิดีโอลดขนาดหน่วยความจำอย่างมหาศาล
- **ไร้อินฟราสตรัคเจอร์**: ไม่ต้องมีเซิร์ฟเวอร์ฐานข้อมูล ใช้แค่ไฟล์เดียวที่ก็อปปี้ไปไหนก็ได้
- **ออฟไลน์เต็มรูปแบบ**: ใช้งานได้โดยไม่ต้องต่อเน็ตหลังสร้างวิดีโอ

### สถาปัตยกรรมเบา
- **ขึ้นกับไลบรารีน้อย**: ฟังก์ชันหลักอยู่ใน Python ราว 1000 บรรทัด
- **เป็นมิตรกับ CPU**: ทำงานได้ดีไม่ต้องใช้ GPU
- **พกพาสะดวก**: ฐานความรู้ทั้งหมดอยู่ในไฟล์วิดีโอเดียว
- **สตรีมได้**: วิดีโอสามารถสตรีมจากคลาวด์ได้

## 📦 การติดตั้ง

### ติดตั้งด่วน
```bash
pip install memvid
```

### สำหรับรองรับ PDF
```bash
pip install memvid PyPDF2
```

### วิธีแนะนำ (Virtual Environment)
```bash
# สร้างโฟลเดอร์โปรเจกต์ใหม่
mkdir my-memvid-project
cd my-memvid-project

# สร้าง virtual environment
python -m venv venv

# เปิดใช้งาน
# บน macOS/Linux:
source venv/bin/activate
# บน Windows:
venv\Scripts\activate

# ติดตั้ง memvid
pip install memvid

# สำหรับรองรับ PDF:
pip install PyPDF2
```

## 🎯 เริ่มต้นอย่างรวดเร็ว

### การใช้งานพื้นฐาน
```python
from memvid import MemvidEncoder, MemvidChat

# สร้างหน่วยความจำวิดีโอจากข้อความ
chunks = ["ข้อมูลสำคัญ 1", "ข้อมูลสำคัญ 2", "รายละเอียดเหตุการณ์ทางประวัติศาสตร์"]
encoder = MemvidEncoder()
encoder.add_chunks(chunks)
encoder.build_video("memory.mp4", "memory_index.json")

# สนทนากับหน่วยความจำของคุณ
chat = MemvidChat("memory.mp4", "memory_index.json")
chat.start_session()
response = chat.chat("คุณรู้อะไรเกี่ยวกับเหตุการณ์ทางประวัติศาสตร์บ้าง?")
print(response)
```

### สร้างหน่วยความจำจากเอกสาร
```python
from memvid import MemvidEncoder
import os

# โหลดเอกสาร
encoder = MemvidEncoder(chunk_size=512, overlap=50)

# เพิ่มไฟล์ข้อความ
for file in os.listdir("documents"):
    with open(f"documents/{file}", "r") as f:
        encoder.add_text(f.read(), metadata={"source": file})

# สร้างวิดีโอที่ปรับแต่งประสิทธิภาพ
encoder.build_video(
    "knowledge_base.mp4",
    "knowledge_index.json",
    fps=30,  # FPS สูง = ข้อมูลต่อวินาทีมากขึ้น
    frame_size=512  # เฟรมใหญ่ = ข้อมูลต่อเฟรมมากขึ้น
)
```

### ค้นหาและเรียกคืนขั้นสูง
```python
from memvid import MemvidRetriever

# เริ่มต้นตัวค้นคืน
retriever = MemvidRetriever("knowledge_base.mp4", "knowledge_index.json")

# ค้นหาเชิงความหมาย
results = retriever.search("อัลกอริทึม machine learning", top_k=5)
for chunk, score in results:
    print(f"คะแนน: {score:.3f} | {chunk[:100]}...")

# ดึงบริบทโดยรอบ
context = retriever.get_context("อธิบาย neural networks", max_tokens=2000)
print(context)
```

### อินเทอร์เฟซแชทเชิงโต้ตอบ
```python
from memvid import MemvidInteractive

# เปิดใช้งานแชทอินเทอร์เฟซแบบ UI
interactive = MemvidInteractive("knowledge_base.mp4", "knowledge_index.json")
interactive.run()  # เปิดเว็บอินเทอร์เฟซที่ http://localhost:7860
```

### ทดสอบด้วย file_chat.py
สคริปต์ `examples/file_chat.py` ให้คุณทดสอบ Memvid กับเอกสารของคุณได้อย่างครอบคลุม:

```bash
# ประมวลผลโฟลเดอร์เอกสาร
python examples/file_chat.py --input-dir /path/to/documents --provider google

# ประมวลผลไฟล์เฉพาะเจาะจง
python examples/file_chat.py --files doc1.txt doc2.pdf --provider openai

# ใช้การบีบอัด H.265 (ต้องใช้ Docker)
python examples/file_chat.py --input-dir docs/ --codec h265 --provider google

# กำหนดขนาดชิ้นข้อมูลเองสำหรับเอกสารขนาดใหญ่
python examples/file_chat.py --files large.pdf --chunk-size 2048 --overlap 32 --provider google

# โหลดหน่วยความจำที่มีอยู่เดิม
python examples/file_chat.py --load-existing output/my_memory --provider google
```

### ตัวอย่างสมบูรณ์: แชทกับหนังสือ PDF
```bash
# 1. สร้างโฟลเดอร์ใหม่และตั้งค่าสภาพแวดล้อม
mkdir book-chat-demo
cd book-chat-demo
python -m venv venv
source venv/bin/activate  # บน Windows: venv\Scripts\activate

# 2. ติดตั้งไลบรารีที่จำเป็น
pip install memvid PyPDF2

# 3. สร้าง book_chat.py
cat > book_chat.py << 'EOF'
from memvid import MemvidEncoder, chat_with_memory
import os

# ไฟล์ PDF ของคุณ
book_pdf = "book.pdf"  # เปลี่ยนเป็น path ของ PDF ของคุณ

# สร้างหน่วยความจำวิดีโอ
encoder = MemvidEncoder()
encoder.add_pdf(book_pdf)
encoder.build_video("book_memory.mp4", "book_index.json")

# แชทกับหนังสือ
api_key = os.getenv("OPENAI_API_KEY")  # ตัวเลือก: สำหรับตอบกลับด้วย AI
chat_with_memory("book_memory.mp4", "book_index.json", api_key=api_key)
EOF

# 4. รันโปรแกรม
export OPENAI_API_KEY="your-api-key"  # ไม่บังคับ
python book_chat.py
```

## 🛠️ การตั้งค่าขั้นสูง

### การใช้ Embeddings แบบกำหนดเอง
```python
from sentence_transformers import SentenceTransformer

# ใช้โมเดล embedding ที่กำหนดเอง
custom_model = SentenceTransformer('sentence-transformers/all-mpnet-base-v2')
encoder = MemvidEncoder(embedding_model=custom_model)
```

### การปรับแต่งวิดีโอ
```python
# เพื่อการบีบอัดสูงสุด
encoder.build_video(
    "compressed.mp4",
    "index.json",
    fps=60,  # เฟรมต่อวินาทีมากขึ้น
    frame_size=256,  # ขนาดเฟรมเล็กลง
    video_codec='h265',  # การบีบอัดที่ดีกว่า
    crf=28  # คุณภาพการบีบอัด (ยิ่งน้อย = คุณภาพดีขึ้น)
)
```

### การประมวลผลแบบกระจาย
```python
# ประมวลผลข้อมูลขนาดใหญ่แบบขนาน
encoder = MemvidEncoder(n_workers=8)
encoder.add_chunks_parallel(massive_chunk_list)
```

## 🐛 การแก้ไขปัญหา

### ปัญหาทั่วไป

**ModuleNotFoundError: No module named 'memvid'**
```bash
# ตรวจสอบให้แน่ใจว่าคุณใช้ Python ที่ถูกต้อง
which python  # ควรแสดง path ของ virtual environment
# หากไม่เป็นเช่นนั้น ให้เปิดใช้งาน virtual environment:
source venv/bin/activate  # บน Windows: venv\Scripts\activate
```

**ImportError: PyPDF2 is required for PDF support**
```bash
pip install PyPDF2
```

**ปัญหาเกี่ยวกับ LLM API Key**
```bash
# ตั้งค่า API key ของคุณ (รับได้ที่ https://platform.openai.com)
export GOOGLE_API_KEY="AIzaSyB1-..."  # macOS/Linux
# หรือบน Windows:
set GOOGLE_API_KEY=AIzaSyB1-...
```

**การประมวลผล PDF ขนาดใหญ่**
```python
# สำหรับ PDF ขนาดใหญ่มาก ให้ใช้ chunk ขนาดเล็กลง
encoder = MemvidEncoder()
encoder.add_pdf("large_book.pdf", chunk_size=400, overlap=50)
```

## 🤝 การร่วมพัฒนา

ยินดีต้อนรับทุกการร่วมพัฒนา! โปรดดู [คู่มือการร่วมพัฒนา](CONTRIBUTING.md) สำหรับรายละเอียด

```bash
# รันทดสอบ
pytest tests/

# รันพร้อมตรวจสอบ coverage
pytest --cov=memvid tests/

# จัดรูปแบบโค้ด
black memvid/
```

## 🆚 การเปรียบเทียบกับโซลูชันแบบดั้งเดิม

| คุณสมบัติ | Memvid | Vector DBs | ฐานข้อมูลดั้งเดิม |
|-----------|--------|------------|-------------------|
| ประสิทธิภาพการจัดเก็บ | ⭐⭐⭐⭐⭐ | ⭐⭐ | ⭐⭐⭐ |
| ความซับซ้อนในการตั้งค่า | ง่าย | ซับซ้อน | ซับซ้อน |
| ค้นหาความหมาย (Semantic Search) | ✅ | ✅ | ❌ |
| ใช้งานแบบออฟไลน์ | ✅ | ❌ | ✅ |
| การพกพา | ไฟล์ | เซิร์ฟเวอร์ | เซิร์ฟเวอร์ |
| การขยายตัว | หลักล้าน | หลักล้าน | หลักพันล้าน |
| ค่าใช้จ่าย | ฟรี | แพงมาก | แพง |


## 📚 ตัวอย่าง

ดูที่ไดเรกทอรี [examples/](https://raw.githubusercontent.com/Olow304/memvid/main/examples/) สำหรับ:
- การสร้างหน่วยความจำจาก Wikipedia dumps
- การสร้างฐานความรู้ส่วนตัว
- รองรับหลายภาษา
- การอัปเดตหน่วยความจำแบบเรียลไทม์
- การเชื่อมต่อกับ LLMs ยอดนิยม

## 🆘 ขอความช่วยเหลือ

- 📖 [เอกสารประกอบ](https://github.com/olow304/memvid/wiki) - คู่มือครบถ้วน
- 💬 [พูดคุย-สอบถาม](https://github.com/olow304/memvid/discussions)
- 🐛 [ติดตามปัญหา](https://github.com/olow304/memvid/issues) - แจ้งข้อบกพร่อง
- 🌟 [Show & Tell](https://github.com/olow304/memvid/discussions/categories/show-and-tell) - แบ่งปันโปรเจกต์ของคุณ

## 🔗 ลิงก์

- [GitHub Repository](https://github.com/olow304/memvid)
- [PyPI Package](https://pypi.org/project/memvid)
- [Changelog](https://github.com/olow304/memvid/releases)


## 📄 ใบอนุญาต

สัญญาอนุญาต MIT - ดูไฟล์ [LICENSE](https://raw.githubusercontent.com/Olow304/memvid/main/LICENSE) สำหรับรายละเอียด

## 🙏 ขอบคุณ

สร้างโดย [Olow304](https://github.com/olow304) และชุมชน Memvid

สร้างขึ้นด้วย ❤️ โดยใช้:
- [sentence-transformers](https://www.sbert.net/) - การสร้าง embedding ระดับสูงสำหรับ semantic search
- [OpenCV](https://opencv.org/) - การประมวลผลภาพและวิดีโอ
- [qrcode](https://github.com/lincolnloop/python-qrcode) - การสร้าง QR code
- [FAISS](https://github.com/facebookresearch/faiss) - การค้นหา similarity อย่างมีประสิทธิภาพ
- [PyPDF2](https://github.com/py-pdf/pypdf) - การดึงข้อความจาก PDF

ขอขอบคุณผู้ร่วมพัฒนาทุกท่านที่ช่วยให้ Memvid ดียิ่งขึ้น!

---

**พร้อมจะปฏิวัติการจัดการหน่วยความจำ AI ของคุณหรือยัง? ติดตั้ง Memvid แล้วเริ่มสร้างได้เลย!** 🚀

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---
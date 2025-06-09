# Immich + cn-clip + RapidOCR + InsightFace

<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>

> ~~แผนในอนาคตคือย้ายไปใช้ ente-io/ente เพราะผมต้องการ s3 เพื่อเก็บรูปภาพ~~
> 
> ente ยังมีฟีเจอร์น้อยเกินไป
> 
> เปลี่ยนมาใช้ juicedata/juicefs เพื่อต่อ s3

## แนะนำโปรเจกต์

โปรเจกต์นี้คือโซลูชันเพิ่มขีดความสามารถ AI ให้กับระบบจัดการรูปภาพ [Immich](https://github.com/immich-app/immich) โดยหลัก ๆ แล้วจะขยายความสามารถดั้งเดิมของ Immich ผ่านคอมโพเนนต์ดังต่อไปนี้:

- **inference-gateway**: เซอร์วิสเกตเวย์ที่เขียนด้วยภาษา Go รับหน้าที่ส่งคำขอ Machine Learning ของ Immich ไปยังปลายทางที่เหมาะสมอย่างชาญฉลาด
- **mt-photos-ai**: เซอร์วิส AI ที่พัฒนาด้วย Python และ FastAPI รวม RapidOCR และ cn-clip model ไว้ด้วยกัน
- ขยายฟีเจอร์ของ Immich เช่น การค้นหาข้อความในภาพ (OCR) การประมวลผลข้อมูล AI ของสื่อเดี่ยวใหม่, การจัดอันดับผลลัพธ์แบบผสมระหว่างเวกเตอร์ OCR และ CLIP
- เพิ่ม zhparser สำหรับตัดคำภาษาจีนใน PostgreSQL

## ฟีเจอร์หลัก

### 1. การรู้จำและค้นหาข้อความในภาพ (OCR)

- ใช้ RapidOCR เพื่อรู้จำข้อความในรูปภาพ
- รองรับการรู้จำข้อความทั้งภาษาอังกฤษและจีน
- เพิ่มความสามารถค้นหาจากเนื้อหาข้อความในรูปภาพ

### 2. การประมวลผลเวกเตอร์ภาพ CLIP

- ใช้โมเดล cn-clip เพื่อให้จับคู่ภาพกับข้อความภาษาจีนได้แม่นยำขึ้น
- รองรับการค้นหาเชิงความหมาย (semantic search) เพื่อความแม่นยำสูงขึ้น

### 3. การประมวลผลข้อมูล AI สำหรับสื่อเดี่ยวใหม่

- รองรับการสร้างข้อมูล OCR ใหม่สำหรับรูป/วิดีโอแต่ละไฟล์
- รองรับการสร้างเวกเตอร์ CLIP ใหม่สำหรับรูป/วิดีโอแต่ละไฟล์
- กรณีผลลัพธ์ไม่แม่นยำ สามารถรีเฟรชข้อมูล AI ได้ด้วยตนเอง

## สถาปัตยกรรมระบบ

```
┌─────────────┐      ┌──────────────────┐      ┌───────────────┐
│             │      │                  │      │               │
│   Immich    │─────▶│ inference-gateway│─────▶│  Immich ML    │
│   Server    │      │    (Go网关)      │      │   Server      │
│             │      │                  │      │               │
└─────────────┘      └──────────────────┘      └───────────────┘
                              │
                              │ OCR/CLIP请求
                              ▼
                     ┌──────────────────┐
                     │                  │
                     │   mt-photos-ai   │
                     │  (Python服务)    │
                     │                  │
                     └──────────────────┘
```

## รายละเอียดคอมโพเนนต์

### inference-gateway

เกตเวย์เซอร์วิสที่เขียนด้วยภาษา Go มีหน้าที่หลักดังนี้:
- รับคำขอ Machine Learning จาก Immich
- ส่งต่อคำขอ OCR และ CLIP ไปยัง mt-photos-ai ตามประเภทคำขอ
- ส่งคำขอ Machine Learning อื่น ๆ (เช่น การรู้จำใบหน้า) ไปยังเซอร์วิส ML ดั้งเดิมของ Immich
- จัดการการยืนยันตัวตนและแปลงรูปแบบข้อมูล

### mt-photos-ai

เซอร์วิส AI ที่เขียนด้วย Python และ FastAPI ให้บริการดังนี้:
- API สำหรับรู้จำข้อความ (OCR) โดยใช้ RapidOCR
- API สำหรับประมวลผลเวกเตอร์ CLIP (ใช้ cn-clip)
- รองรับ GPU เพื่อการประมวลผลที่รวดเร็ว

## คู่มือการติดตั้ง

### ข้อกำหนดของระบบ

- Docker และ Docker Compose
- NVIDIA GPU (ไม่จำเป็นแต่แนะนำเพื่อความเร็ว)
- พื้นที่เก็บข้อมูลเพียงพอ

### คำอธิบายการตั้งค่า

1. **การตั้งค่า inference-gateway**

ตัวแปรสภาพแวดล้อมหลัก:
```
IMMICH_API=http://localhost:3003  # ที่อยู่ API ของ Immich
MT_PHOTOS_API=http://localhost:8060  # ที่อยู่เซอร์วิส mt-photos-ai
MT_PHOTOS_API_KEY=mt_photos_ai_extra  # API Key
PORT=8080  # พอร์ตที่เกตเวย์ฟัง
```

2. **การตั้งค่า mt-photos-ai**

ตัวแปรสภาพแวดล้อมหลัก:
```
CLIP_MODEL=ViT-B-16  # ชื่อโมเดล CLIP
CLIP_DOWNLOAD_ROOT=./models/clip  # ที่ดาวน์โหลดโมเดล
DEVICE=cuda  # หรือ cpu อุปกรณ์ประมวลผล
HTTP_PORT=8060  # พอร์ตเซอร์วิส
```

### ขั้นตอนการติดตั้ง

1. โคลนโปรเจกต์:
```bash
git clone https://github.com/ชื่อผู้ใช้ของคุณ/immich-all-in-one.git
cd immich-all-in-one
```

2. เริ่มต้นเซอร์วิส:
```bash
docker-compose up -d
```

## วิธีใช้งาน

1. **ตั้งค่า Immich ให้ใช้ ML เซอร์วิสที่กำหนดเอง**

ในไฟล์คอนฟิกของ Immich ให้ระบุที่อยู่เซอร์วิส ML ไปที่ inference-gateway:
```
MACHINE_LEARNING_URL=http://inference-gateway:8080
```

2. **ใช้งานค้นหา OCR**

- ในช่องค้นหาของ Immich ใช้คีย์เวิร์ด `ocr:` เพื่อค้นหาข้อความในภาพ
- ตัวอย่าง: `ocr:ใบเสร็จ` จะค้นหารูปที่มีข้อความ "ใบเสร็จ" อยู่ในภาพ

3. **การประมวลผลข้อมูล AI สำหรับสื่อเดี่ยวใหม่**

- ที่หน้ารายละเอียดรูปภาพ คลิกที่เมนูตัวเลือก
- เลือก "สร้างข้อมูล OCR ใหม่" หรือ "สร้างเวกเตอร์ CLIP ใหม่"
- ระบบจะประมวลผลข้อมูล AI ของภาพนั้นใหม่

## คู่มือสำหรับนักพัฒนา

### inference-gateway (Go)

คอมไพล์และรัน:
```bash
cd inference-gateway
go build
./inference-gateway
```

### mt-photos-ai (Python)

ตั้งค่าสภาพแวดล้อมสำหรับพัฒนา:
```bash
cd mt-photos-ai
pip install -r requirements.txt
python -m app.main
```

## ใบอนุญาต

โปรเจกต์นี้เปิดซอร์สภายใต้ MIT License

## ขอบคุณ

- [Immich](https://github.com/immich-app/immich) - โซลูชันสำรองรูปภาพและวิดีโอแบบ self-hosted แบบโอเพ่นซอร์ส
- [RapidOCR](https://github.com/RapidAI/RapidOCR) - ไลบรารี OCR ข้ามแพลตฟอร์มบนพื้นฐาน PaddleOCR
- [cn-clip](https://github.com/OFA-Sys/Chinese-CLIP) - โมเดล pretrain สำหรับการเรียนรู้เชิงเปรียบเทียบแบบมัลติโหมดภาษาจีน

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---
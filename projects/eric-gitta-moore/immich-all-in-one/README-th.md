# Immich + cn-clip + RapidOCR + InsightFace

<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>

> ~~แผนในอนาคตจะย้ายไป ente-io/ente เพราะฉันต้องการ s3 เพื่อเก็บรูปภาพ~~
> 
> ente ยังมีฟีเจอร์น้อยเกินไป
> 
> เปลี่ยนมาใช้ juicedata/juicefs สำหรับเชื่อมต่อ s3

## บทนำโครงการ

โครงการนี้เป็นโซลูชันเสริมศักยภาพ AI สำหรับระบบจัดการรูปภาพ [Immich](https://github.com/immich-app/immich) โดยขยายความสามารถดั้งเดิมของ Immich ด้วยคอมโพเนนต์หลักดังนี้:

- **inference-gateway**: บริการ Gateway ที่เขียนด้วยภาษา Go รับผิดชอบการกระจายคำขอ Machine Learning ของ Immich อย่างชาญฉลาด
- **mt-photos-ai**: บริการ AI ที่ใช้ Python และ FastAPI รวม RapidOCR และโมเดล cn-clip
- ขยายความสามารถของ Immich เช่น การค้นหาด้วย OCR และการประมวลผลข้อมูล AI ของสื่อเดียวใหม่, การเรียงลำดับแบบผสมระหว่างเวกเตอร์ข้อความ OCR และเวกเตอร์ CLIP
- เพิ่ม zhparser สำหรับตัดคำภาษาจีนใน PostgreSQL

## ฟีเจอร์หลัก

### 1. การรู้จำและค้นหาข้อความ OCR

- ใช้ RapidOCR ตรวจจับข้อความในภาพ
- รองรับการรู้จำข้อความจีน-อังกฤษผสม
- สามารถค้นหาจากเนื้อหาข้อความในภาพได้

### 2. การประมวลผลเวกเตอร์ภาพ CLIP

- ใช้โมเดล cn-clip เพื่อให้จับคู่ภาพ-ข้อความภาษาจีนได้แม่นยำขึ้น
- รองรับการค้นหาด้วยความหมาย เพิ่มความแม่นยำในการค้นหา

### 3. การประมวลผลข้อมูล AI สำหรับสื่อเดี่ยวใหม่

- รองรับการสร้างข้อมูล OCR ใหม่สำหรับรูป/วิดีโอแต่ละไฟล์
- รองรับการสร้างเวกเตอร์ CLIP ใหม่สำหรับรูป/วิดีโอแต่ละไฟล์
- มีฟังก์ชันรีเฟรชข้อมูลด้วยตนเองสำหรับกรณีผลลัพธ์ไม่ถูกต้อง

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
## 组件详解

### inference-gateway

บริการเกตเวย์ที่เขียนด้วยภาษา Go มีหน้าที่หลักดังนี้:
- รับคำขอ Machine Learning จาก Immich
- ส่งต่อคำขอ OCR และ CLIP ไปยังบริการ mt-photos-ai ตามประเภทคำขอ
- ส่งต่อคำขอ Machine Learning อื่น ๆ (เช่น การจดจำใบหน้า) ไปยังบริการ Machine Learning ดั้งเดิมของ Immich
- จัดการการรับรองความถูกต้องและการแปลงรูปแบบข้อมูล

### mt-photos-ai

บริการ AI ที่เขียนด้วย Python และ FastAPI ให้บริการ:
- API สำหรับการรู้จำตัวอักษร OCR (อิงตาม RapidOCR)
- API สำหรับประมวลผลเวกเตอร์ CLIP (อิงตาม cn-clip)
- รองรับการเร่งความเร็วด้วย GPU

## คำแนะนำการปรับใช้

### ข้อกำหนดของสภาพแวดล้อม

- Docker และ Docker Compose
- NVIDIA GPU (ไม่จำเป็นแต่แนะนำสำหรับการประมวลผลที่เร็วขึ้น)
- พื้นที่จัดเก็บข้อมูลเพียงพอ

### คำอธิบายการกำหนดค่า

1. **การกำหนดค่า inference-gateway**

ตัวแปรสภาพแวดล้อมหลัก:

```
IMMICH_API=http://localhost:3003  # Immich API地址
MT_PHOTOS_API=http://localhost:8060  # mt-photos-ai服务地址
MT_PHOTOS_API_KEY=mt_photos_ai_extra  # API密钥
PORT=8080  # 网关监听端口
```
2. **mt-photos-ai การกำหนดค่า**

ตัวแปรสภาพแวดล้อมหลัก:

```
CLIP_MODEL=ViT-B-16  # CLIP模型名称
CLIP_DOWNLOAD_ROOT=./models/clip  # 模型下载路径
DEVICE=cuda  # 或 cpu，推理设备
HTTP_PORT=8060  # 服务监听端口
```
### ขั้นตอนการปรับใช้

1. โคลนคลังเก็บ:

```bash
git clone https://github.com/你的用户名/immich-all-in-one.git
cd immich-all-in-one
```
2. เริ่มต้นบริการ:

```bash
docker-compose up -d
```
## คำแนะนำการใช้งาน

1. **กำหนดค่า Immich ให้ใช้บริการ ML แบบกำหนดเอง**

ในไฟล์การตั้งค่าของ Immich ให้ตั้งค่าที่อยู่บริการ Machine Learning ไปที่ inference-gateway:

```
MACHINE_LEARNING_URL=http://inference-gateway:8080
```
2. **การค้นหา OCR**

- ใช้คำนำหน้า `ocr:` ในแถบค้นหาของ Immich เพื่อค้นหาด้วย OCR
- ตัวอย่าง: `ocr:ใบเสร็จ` จะค้นหารูปภาพที่มีข้อความ "ใบเสร็จ" อยู่ในภาพ

3. **การประมวลผลข้อมูล AI ของสื่อเดี่ยวใหม่**

- ในหน้ารายละเอียดของภาพถ่าย คลิกที่ตัวเลือกเมนู
- เลือก "สร้างข้อมูล OCR ใหม่" หรือ "สร้างเวกเตอร์ CLIP ใหม่"
- ระบบจะประมวลผลข้อมูล AI ของภาพถ่ายนั้นใหม่อีกครั้ง

## คู่มือการพัฒนา

### inference-gateway (Go)

การคอมไพล์และรัน:

```bash
cd inference-gateway
go build
./inference-gateway
```
### mt-photos-ai (Python)

การตั้งค่าสภาพแวดล้อมสำหรับการพัฒนา:

```bash
cd mt-photos-ai
pip install -r requirements.txt
python -m app.main
```
## ใบอนุญาต

โครงการนี้เปิดเผยซอร์สโค้ดภายใต้ใบอนุญาต MIT

## คำขอบคุณ

- [Immich](https://github.com/immich-app/immich) - โซลูชันสำรองข้อมูลภาพถ่ายและวิดีโอแบบโอเพ่นซอร์สที่โฮสต์เอง
- [RapidOCR](https://github.com/RapidAI/RapidOCR) - ไลบรารี OCR ข้ามแพลตฟอร์มที่พัฒนาบน PaddleOCR
- [cn-clip](https://github.com/OFA-Sys/Chinese-CLIP) - โมเดลปรีเทรนการเรียนรู้เชิงเปรียบเทียบแบบมัลติโหมดสำหรับภาษาจีน



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---
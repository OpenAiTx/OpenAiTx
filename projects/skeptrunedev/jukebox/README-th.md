<p align="center">
  <a href="https://www.jukeboxhq.com">
    <img height="500" src="https://raw.githubusercontent.com/skeptrunedev/jukebox/main/frontend/public/opengraph-image.jpg" alt="Trieve Logo">
  </a>
</p>

<p align="center">
  <a href="https://hub.docker.com/r/skeptrune/jukebox-server" style="text-decoration: none;">
    <img src="https://img.shields.io/docker/pulls/skeptrune/jukebox-server?style=flat-square" alt="Docker Pulls" />
  </a>
  <a href="https://github.com/skeptrunedev/jukebox/stargazers" style="text-decoration: none;">
    <img src="https://img.shields.io/github/stars/skeptrunedev/jukebox?style=flat-square" alt="GitHub stars" />
  </a>
  <a href="https://x.com/skeptrune" style="text-decoration: none;">
    <img src="https://img.shields.io/badge/follow%20on-x.com-1da1f2?logo=x&style=flat-square" alt="Follow on X (Twitter)" />
  </a>
</p>

---
# เปลี่ยนอุปกรณ์ใดก็ได้ให้กลายเป็นกล่องเพลงแบบร่วมมือกัน

**Jukebox** ให้คุณสร้างเพลย์ลิสต์เพลงร่วมกับเพื่อน ๆ ได้ทันที—ไม่ต้องติดตั้งแอป ไม่ต้องล็อกอิน ไม่มีโฆษณา แค่สร้างกล่องเพลง แชร์ลิงก์ แล้วเริ่มเพิ่มเพลงด้วยกัน เหมาะสำหรับงานปาร์ตี้ ทริปเดินทาง หรือกิจกรรมกลุ่มทุกประเภท!

- 🌐 **ทางเลือกโอเพ่นซอร์สสำหรับเพลย์ลิสต์ร่วมของ Spotify**
- 🕵️ **ไม่ต้องมีบัญชีผู้ใช้**: ใช้งานแบบไม่ระบุตัวตน—ไม่ต้องสมัครสมาชิกหรือใช้อีเมล
- ✨ **แชร์ลิงก์ เพิ่มเพลงด้วยกัน**: ทุกคนสามารถมีส่วนร่วมได้แบบเรียลไทม์
- 🚀 **ไม่ต้องดาวน์โหลดแอป**: ใช้งานได้บนทุกอุปกรณ์ผ่านเบราว์เซอร์
- 🎵 **เชื่อมต่อกับ YouTube**: ค้นหาและเล่นเพลงแทบทุกเพลงได้ทันที
- 📱 **ใช้งานง่ายบนมือถือ**: ออกแบบมาสำหรับโทรศัพท์ แท็บเล็ต และคอมพิวเตอร์
- ⚖️ **จัดคิวอย่างยุติธรรม**: เพลงจะถูกจัดลำดับอัตโนมัติให้ทุกคนได้คิว
- 🆓 **ฟรี 100% ไม่มีโฆษณา**

---

## ทดลองใช้งานตอนนี้

1. **สร้างกล่องเพลง Jukebox**: เข้าไปที่หน้าแรกแล้วสร้างกล่องใหม่
2. **แชร์ลิงก์**: ส่งลิงก์เชิญให้เพื่อนของคุณ
3. **เพิ่มเพลง**: ค้นหาบน YouTube หรือเพิ่มเพลงด้วยตัวเอง
4. **เล่นเพลง**: ใช้เครื่องเล่นในตัวเพื่อฟังเพลงพร้อมกัน

---
## คุณสมบัติ

- รายการเพลงแบบร่วมมือ: เพิ่ม คิว และเล่นเพลงร่วมกัน
- การใช้งานแบบไม่ระบุตัวตน: ไม่ต้องเข้าสู่ระบบหรือมีบัญชี
- ค้นหาและเล่นเพลงจาก YouTube: เข้าถึงคลังเพลงขนาดใหญ่
- อินเทอร์เฟซที่เน้นมือถือและตอบสนองทุกอุปกรณ์
- โอเพนซอร์ส (สัญญาอนุญาต MIT)
- ติดตั้งง่ายด้วย Docker

### การติดตั้งด้วย Docker Compose

เริ่มต้นบริการทั้งหมด:

```bash
docker-compose up -d
```

ติดตั้งบริการใหม่โดยไม่หยุดชะงักหลังจากอัปเดตรูปภาพ:

```bash
bash ./redeploy.sh
```
---

## เริ่มต้นใช้งาน

### ข้อกำหนดเบื้องต้น

- Node.js 16 ขึ้นไป
- npm หรือ yarn
- คีย์ YouTube Data API v3 (รับฟรีจาก Google)

### การตั้งค่า YouTube API

1. ไปที่ [Google Cloud Console](https://console.cloud.google.com/)
2. สร้างโปรเจ็กต์ใหม่หรือเลือกโปรเจ็กต์ที่มีอยู่แล้ว
3. เปิดใช้งาน **YouTube Data API v3**
4. สร้างข้อมูลรับรอง (API Key)
5. คัดลอก API Key ของคุณ

### การติดตั้ง
```bash
# โคลนรีโพซิทอรี
git clone <your-repo-url>
cd jukebox

# ติดตั้ง dependencies ของเซิร์ฟเวอร์
cd server
yarn install

# ติดตั้ง dependencies ของ frontend
cd ../frontend
yarn install

# กำหนดค่า environment variables
cd ../server
cp .env.example .env
# แก้ไขไฟล์ .env และเพิ่ม YouTube API key ของคุณ

# รัน database migrations
```
yarn migrate

# เริ่มเซิร์ฟเวอร์สำหรับพัฒนา
# Backend:
cd server
yarn dev
# Worker:
cd server
yarn dev:worker
# Frontend (ในเทอร์มินัลใหม่):
cd frontend
yarn dev
```

---

## ใบอนุญาต

MIT

---
## การมีส่วนร่วม & ข้อเสนอแนะ

- เปิด issue หรือ pull request ที่ [GitHub](https://github.com/skeptrunedev/jukebox)
- มีคำขอฟีเจอร์? ส่ง DM หา [@skeptrune บน X (Twitter)](https://twitter.com/skeptrune)

---

## บันทึกการเปลี่ยนแปลง

ดู [บันทึกการเปลี่ยนแปลง](https://jukebox.skeptrune.com#changelog) สำหรับอัปเดตและฟีเจอร์ล่าสุด

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-10

---
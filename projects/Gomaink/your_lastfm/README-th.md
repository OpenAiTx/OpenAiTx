
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

[![Status](https://img.shields.io/badge/status-active-brightgreen)](https://github.com/seuusuario/wakeonweb)
[![License](https://img.shields.io/badge/license-MIT-blue)](LICENSE)

# Your LastFM

แอปพลิเคชัน Node.js ที่บรรจุอยู่ในคอนเทนเนอร์ ซึ่งใช้ในการซิงโครไนซ์สแครบบ์จาก **Last.fm** เก็บข้อมูลไว้ในฐานข้อมูล **SQLite** ในเครื่อง และให้บริการแดชบอร์ดผ่านเว็บ

<img width="1718" height="1066" alt="image" src="https://github.com/user-attachments/assets/97d5a9f1-b39a-42ea-9acf-2b4546426a11" />
---

## โปรเจกต์

**Your LastFM** คือแอปพลิเคชัน Node.js ที่ออกแบบมาเพื่อ **ซิงโครไนซ์สแครบเบิลเพลงจาก Last.fm อัตโนมัติ** โดยจะเก็บประวัติการฟังเพลงของคุณไว้ในฐานข้อมูล SQLite ภายในเครื่อง และให้บริการเว็บอินเทอร์เฟซสำหรับการแสดงผลข้อมูล

โปรเจกต์นี้ถูกบรรจุลงใน **Docker** อย่างสมบูรณ์ โดยใช้ entrypoint อัตโนมัติในการจัดการเริ่มต้นฐานข้อมูลและการรันคำสั่งตามลำดับ (ซิงค์ข้อมูลก่อน จากนั้นจึงเปิด Web API) พร้อมทั้งใช้ **PM2** เป็นตัวจัดการโพรเซสภายในคอนเทนเนอร์เพื่อให้บริการเว็บยังคงทำงานต่อเนื่องและมีความเสถียร

## ฟีเจอร์
### Interactive Web Dashboard

- อินเทอร์เฟซเว็บที่สะอาด ทันสมัย สำหรับแสดงกิจกรรมการฟังเพลงของคุณ

### การซิงโครไนซ์สแครบเบิล Last.fm อัตโนมัติ

- ดึงข้อมูลและบันทึกประวัติการฟังเพลง (scrobbles) จาก Last.fm เป็นระยะ ๆ
- รับรองว่าข้อมูลของคุณเป็นปัจจุบันเสมอโดยไม่ต้องดำเนินการเอง

### ฐานข้อมูลประวัติการฟังเพลงภายในเครื่อง

- เก็บสแครบเบิลทั้งหมดไว้ในฐานข้อมูล SQLite ภายในเครื่อง
- รองรับการค้นหาข้อมูลอย่างรวดเร็วและใช้งานออฟไลน์ได้

### มุมมองสแครบเบิลล่าสุด

- แสดงเพลงล่าสุดที่คุณฟัง
- มีระบบ fallback รูปภาพอัจฉริยะสำหรับเพลง อัลบั้ม และศิลปิน

### การเปรียบเทียบกับเพื่อน (Compatibility View)

- เปรียบเทียบรสนิยมเพลงของคุณกับเพื่อนใน Last.fm
- แสดงระดับความเข้ากันได้ (ต่ำมาก → สูงสุด)
- แสดงศิลปิน อัลบั้ม และเพลงยอดนิยมที่ตรงกัน
- คำนวณและปรับระดับความเข้ากันได้จากข้อมูลการฟังจริง

### การ์ดเพลงสำหรับแชร์

- สร้างรูปภาพไดนามิกจากข้อมูลการฟังเพลงของคุณ
- ปรับแต่งเลย์เอาต์ให้เหมาะกับโพสต์ฟีดและ Instagram Stories (9:16)

- สร้างขึ้นโดยใช้ node-canvas สำหรับการเรนเดอร์ภาพฝั่งเซิร์ฟเวอร์

## ข้อกำหนดเบื้องต้น

* [Docker](https://docs.docker.com/get-docker/)
* [Docker Compose](https://docs.docker.com/compose/install/)

## การติดตั้ง

### สร้างไฟล์ `.env`

```env
LASTFM_API_KEY=your_lastfm_api_key
LASTFM_USERNAME=your_lastfm_username
```

Last.fm: สร้างบัญชี API [ที่นี่](https://www.last.fm/api/account/create) เพื่อรับ API Key ของคุณ

### Docker Compose

```yml
services:
  your-lastfm:
    image: gomaink/your-lastfm
    container_name: your-lastfm
    ports:
      - "1533:1533"
    env_file:
      - .env
    volumes:
      - ./data:/app/data
    restart: unless-stopped
```

บนเทอร์มินัล:
`docker compose up -d`

จากนั้นเข้าถึง:
```
http://localhost:1533
```

(หรือแทนที่ `localhost` ด้วย IP ของเซิร์ฟเวอร์ของคุณ)

## ใบอนุญาต

โครงการนี้ได้รับอนุญาตภายใต้ใบอนุญาต MIT License.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-27

---
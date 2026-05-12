
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<div align="center" width="100%">
    <img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/upstat.png" width="128" alt="" />
</div>

# Upstat

> เครื่องมือมอนิเตอร์สถานะที่โฮสต์เองได้ ใช้งานง่ายและไม่ซับซ้อน

![](https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/dashboard.png)

## 💻 สาธิตการใช้งานสด

ลองใช้งานได้เลย

เซิร์ฟเวอร์สาธิต (ที่ตั้ง: สิงคโปร์): [https://demo.upstat.com](https://upstat.chamanbudhathoki.com.np/)

ชื่อผู้ใช้: `demo`
รหัสผ่าน: `demodemo`

## ⭐ คุณสมบัติ

ยังต้องการฟีเจอร์เพิ่มเติม แต่ตอนนี้มี...

- ตรวจสอบสถานะ uptime สำหรับ HTTP(s)
- แผนภูมิสถานะและเวลาแฝง
- แจ้งเตือนผ่าน Discord
- ตรวจสอบทุก 60 วินาที
- ส่วนติดต่อผู้ใช้สวยงาม รวดเร็ว ตอบสนองไว
- รองรับหลายหน้าสถานะ
- กำหนดโดเมนเฉพาะให้กับแต่ละหน้าสถานะได้
- แผนภูมิ Ping
- ข้อมูลใบรับรอง
- PWA
- รองรับฐานข้อมูล Sqlite & Postgres

และฟีเจอร์ย่อยอื่น ๆ อีกมากมายที่กำลังจะถูกเพิ่ม

## 🔧 วิธีติดตั้ง

### 🐳 Docker

สำหรับ Sqlite

```bash
curl https://raw.githubusercontent.com/chamanbravo/upstat/main/docker-compose-sqlite.yml -o docker-compose.yml
docker compose up
```
สำหรับ Postgres


```bash
curl -O https://raw.githubusercontent.com/chamanbravo/upstat/main/docker-compose.yml
docker compose up
```
Upstat กำลังทำงานอยู่ที่ http://localhost:3000

> [!IMPORTANT]
> ตรวจสอบให้แน่ใจว่าได้เปลี่ยนค่าตัวแปรสภาพแวดล้อมก่อนนำไปใช้งานจริง

### 💪🏻 ไม่ใช้ Docker

ข้อกำหนด:

- Node.js 14 / 16 / 18 / 20.4
- npm 9
- Golang 1.21+
- Postgres (ไม่บังคับ)


```shell
cp .sample.env .env
```

```shell
air
cd web && npm run dev
```

## เทคสแต็ค

- React
- Shadcn
- Golang
- Postgres/Sqlite

## 🙌 การมีส่วนร่วม

ขอต้อนรับทุกการมีส่วนร่วม! การมีส่วนร่วมคือสิ่งที่ทำให้ชุมชนโอเพนซอร์สเป็นสถานที่ที่ยอดเยี่ยมสำหรับการเรียนรู้ สร้างแรงบันดาลใจ และสร้างสรรค์ ผลงานทุกชิ้นที่คุณมีส่วนร่วมจะได้รับการ**ขอบคุณอย่างยิ่ง**

หากคุณมีข้อเสนอแนะที่จะทำให้โปรเจกต์นี้ดีขึ้น โปรด fork รีโป ทำการเปลี่ยนแปลงและสร้าง pull request คุณสามารถเปิด issue พร้อมแท็ก "enhancement" ได้เช่นกัน
อย่าลืมกดดาวให้โปรเจกต์นี้ด้วยนะครับ ขอบคุณอีกครั้ง!

1. Fork โปรเจกต์
2. สร้างฟีเจอร์ branch ของคุณ (`git checkout -b feature/AmazingFeature`)
3. คอมมิตการเปลี่ยนแปลงของคุณ (`git commit -m 'Add some AmazingFeature'`)
4. ส่งขึ้น branch (`git push origin feature/AmazingFeature`)
5. เปิด Pull Request

## ผู้มีส่วนร่วม

<a href="https://github.com/chamanbravo/upstat/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=chamanbravo/upstat" />
</a>

## 📄 ใบอนุญาต

โปรเจกต์นี้ได้รับอนุญาตภายใต้ [MIT License](https://opensource.org/license/mit/)

## 🖼 ภาพหน้าจอเพิ่มเติม

สร้างมอนิเตอร์

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/create.png" width="512" alt="" />

หน้ามอนิเตอร์

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/chart.png" width="512" alt="" />

Settings Page

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/settings.png" width="512" alt="" />

Notifications

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/notifications.png" width="512" alt="" />

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/discord_notification.png" width="512" alt="" />


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-12

---
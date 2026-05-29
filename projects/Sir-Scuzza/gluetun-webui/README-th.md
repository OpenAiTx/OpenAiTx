
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Gluetun WebUI

UI บนเว็บที่มีน้ำหนักเบาสำหรับการตรวจสอบและควบคุม [Gluetun](https://github.com/qdm12/gluetun) — คอนเทนเนอร์ไคลเอนต์ VPN สำหรับ Docker

![สถานะ: เชื่อมต่อแล้ว](https://img.shields.io/badge/status-connected-brightgreen)
![Node 25](https://img.shields.io/badge/node-25--alpine-blue)
![Docker](https://img.shields.io/badge/docker-compose-blue)

---

## คุณสมบัติ

- ✨ **รองรับ Multi-VPN** — ตรวจสอบและควบคุม Gluetun ได้สูงสุด 20 อินสแตนซ์พร้อมกัน
- แบนเนอร์สถานะ VPN สด (เชื่อมต่อ / หยุดชั่วคราว / ตัดการเชื่อมต่อ)
- แสดง IP สาธารณะ ประเทศ ภูมิภาค เมือง และองค์กร
- ผู้ให้บริการ VPN โปรโตคอล (WireGuard / OpenVPN) รายละเอียดเซิร์ฟเวอร์
- แสดงสถานะการส่งต่อพอร์ตและ DNS
- ปุ่มควบคุมเริ่มต้น / หยุด VPN
- รีเฟรชอัตโนมัติพร้อมตั้งช่วงเวลาได้ (5วินาที – 60วินาที)
- แถบประวัติแสดงสถานะ 30 รอบล่าสุดด้วยสีที่ต่างกัน
- ออกแบบให้ตอบสนองทุกอุปกรณ์ (มือถือ แท็บเล็ต เดสก์ท็อป)

---

## ภาพหน้าจอ
![alt text](https://raw.githubusercontent.com/Sir-Scuzza/gluetun-webui/main/image-1.png)

---

## ข้อกำหนด

- Docker + Docker Compose
- Gluetun ต้องเปิดใช้งาน HTTP control server (พอร์ตเริ่มต้น `8000`)
- Gluetun และ gluetun-webui ต้องอยู่ใน Docker network เดียวกัน

> รองรับ `linux/amd64` และ `linux/arm64` (ใช้งานได้บน Mac Intel/Apple Silicon, Linux และ Windows)

---

## เริ่มต้นอย่างรวดเร็ว

### ตัวเลือก A1: อินสแตนซ์เดียว (แนะนำ)

เพิ่ม `gluetun-webui` เข้าไปในไฟล์ compose เดิมของคุณพร้อมกับ Gluetun:

```yaml
gluetun-webui:
  image: scuzza/gluetun-webui:latest
  container_name: gluetun-webui
  ports:
    - "127.0.0.1:3000:3000"
  environment:
    - GLUETUN_CONTROL_URL=http://gluetun:8000
    # Uncomment if Gluetun auth is enabled:
    #- GLUETUN_API_KEY=yourtoken
    #- GLUETUN_USER=username
    #- GLUETUN_PASSWORD=password
  networks:
    - your_network_name
  restart: unless-stopped
  read_only: true
  tmpfs:
    - /tmp
  security_opt:
    - no-new-privileges:true
  cap_drop:
    - ALL
  healthcheck:
    test: ["CMD", "wget", "-qO-", "http://localhost:3000/api/health"]
    interval: 30s
    timeout: 5s
    start_period: 10s
    retries: 3
```

### ตัวเลือก A2: หลายอินสแตนซ์

ตรวจสอบอินสแตนซ์ Gluetun 2 ตัวขึ้นไปด้วยแดชบอร์ดแยกต่างหาก:

```yaml
gluetun-webui:
  image: scuzza/gluetun-webui:latest
  container_name: gluetun-webui
  ports:
    - "127.0.0.1:3000:3000"
  environment:
    - GLUETUN_1_NAME=VPN - London
    - GLUETUN_1_URL=http://gluetun-1:8000
    - GLUETUN_1_API_KEY=token1
    
    - GLUETUN_2_NAME=VPN - Amsterdam  
    - GLUETUN_2_URL=http://gluetun-2:8000
    - GLUETUN_2_API_KEY=token2
    
    - GLUETUN_3_NAME=VPN - Singapore
    - GLUETUN_3_URL=http://gluetun-3:8000
    - GLUETUN_3_API_KEY=token3
  networks:
    - your_network_name
  restart: unless-stopped
  read_only: true
  tmpfs:
    - /tmp
  security_opt:
    - no-new-privileges:true
  cap_drop:
    - ALL
```

### ตัวเลือก B: สร้างภายในเครื่อง

```bash
git clone https://github.com/Sir-Scuzza/gluetun-webui.git
cd gluetun-webui
docker compose up -d --build
```

จากนั้นให้รัน (เลือกวิธีใดวิธีหนึ่ง):

```bash
docker compose up -d
```

UI สามารถเข้าถึงได้ที่ **http://localhost:3000**

---

## การตั้งค่าเครือข่าย

ทั้ง Gluetun และ gluetun-webui ต้องอยู่บนเครือข่าย Docker เดียวกันเพื่อให้ `http://gluetun:8000` สามารถเชื่อมต่อได้อย่างถูกต้อง

**ไฟล์ compose เดียวกัน** — เพียงแค่เพิ่มทั้งสองบริการให้อยู่บนเครือข่ายเดียวกัน (ซึ่งพบบ่อยที่สุด):

```yaml
services:
  gluetun:
    networks:
      - arr-stack
  gluetun-webui:
    networks:
      - arr-stack

networks:
  arr-stack:
    driver: bridge
```

**ไฟล์ compose แยกต่างหาก** — อ้างอิงเครือข่ายที่มีอยู่ของ Gluetun เป็น external ค้นหาชื่อเครือข่ายของคุณด้วย `docker network ls`:

```yaml
networks:
  ext-network:
    external: true
    name: your_gluetun_network_name
```

---

## รองรับ Multi-VPN

### หลายอินสแตนซ์

gluetun-webui รองรับการตรวจสอบและควบคุม **หลายอินสแตนซ์ของ Gluetun พร้อมกัน** แต่ละอินสแตนซ์จะแสดงเป็นแดชบอร์ดแยกต่างหากในกริดที่ตอบสนองต่อหน้าจอ

**การกำหนดค่า**: ใช้ตัวแปรสภาพแวดล้อมที่มีหมายเลข:

```yaml
gluetun-webui:
  image: scuzza/gluetun-webui:latest
  environment:
    # Instance 1
    - GLUETUN_1_NAME=VPN 1
    - GLUETUN_1_URL=http://gluetun-1:8000
    - GLUETUN_1_API_KEY=token1  # optional

    # Instance 2
    - GLUETUN_2_NAME=VPN 2
    - GLUETUN_2_URL=http://gluetun-2:8000
    - GLUETUN_2_API_KEY=token2  # optional

    # Instance 3
    - GLUETUN_3_NAME=VPN 3
    - GLUETUN_3_URL=http://gluetun-3:8000
    - GLUETUN_3_USER=admin
    - GLUETUN_3_PASSWORD=secret  # optional (HTTP Basic auth)
```

**รองรับ**: สูงสุด 20 อินสแตนซ์ (ผ่าน `GLUETUN_1_URL` ถึง `GLUETUN_20_URL`)  
**ตอบสนอง**: 1 แดชบอร์ดเต็มความกว้าง → 2 ครึ่งความกว้าง → 3 หนึ่งในสาม → 4 หนึ่งในสี่ → เลื่อนดูได้เมื่อมากกว่า 5+

### ความเข้ากันได้กับเวอร์ชันก่อนหน้า

หากไม่มีการกำหนดตัวแปรแบบมีหมายเลข ระบบจะย้อนกลับไปใช้ **โหมดซิงเกิลอินสแตนซ์แบบเก่า**:

```yaml
environment:
  - GLUETUN_CONTROL_URL=http://gluetun:8000  # legacy
  - GLUETUN_API_KEY=token
```

### การตรวจสอบสิทธิ์ต่อแต่ละอินสแตนซ์

แต่ละอินสแตนซ์สามารถมีการตรวจสอบสิทธิ์ที่แตกต่างกันได้:

```yaml
# Instance with API key
- GLUETUN_1_API_KEY=my-secret-token

# Instance with HTTP Basic auth
- GLUETUN_2_USER=admin
- GLUETUN_2_PASSWORD=mysecret

# Instance with no auth
- GLUETUN_3_URL=http://gluetun-3:8000  # auth optional
```

---

## การกำหนดค่า

| ตัวแปร | ค่าเริ่มต้น | คำอธิบาย |
|---|---|---|
| `GLUETUN_1_*` ถึง `GLUETUN_20_*` | _(ว่าง)_ | **การกำหนดค่าสำหรับหลายอินสแตนซ์** (สูงสุด 20 อินสแตนซ์) |
| `GLUETUN_{N}_URL` | – | URL เซิร์ฟเวอร์ควบคุม Gluetun HTTP สำหรับอินสแตนซ์ N |
| `GLUETUN_{N}_NAME` | `Instance {N}` | ชื่อที่แสดงสำหรับอินสแตนซ์ N |
| `GLUETUN_{N}_API_KEY` | _(ว่าง)_ | Bearer token สำหรับอินสแตนซ์ N (ถ้าเปิดใช้งานการตรวจสอบสิทธิ์) |
| `GLUETUN_{N}_USER` | _(ว่าง)_ | ชื่อผู้ใช้สำหรับ HTTP Basic auth (อินสแตนซ์ N) |
| `GLUETUN_{N}_PASSWORD` | _(ว่าง)_ | รหัสผ่านสำหรับ HTTP Basic auth (อินสแตนซ์ N) |
| `GLUETUN_CONTROL_URL` | `http://gluetun:8000` | **โหมดเดิม** – ใช้ได้กับอินสแตนซ์เดียวเท่านั้น (fallback ถ้าไม่มีตัวแปร `GLUETUN_1_*`) |
| `GLUETUN_API_KEY` | _(ว่าง)_ | **โหมดเดิม** – Bearer token สำหรับอินสแตนซ์เดียว |
| `GLUETUN_USER` | _(ว่าง)_ | **โหมดเดิม** – ชื่อผู้ใช้สำหรับ HTTP Basic auth |
| `GLUETUN_PASSWORD` | _(ว่าง)_ | **โหมดเดิม** – รหัสผ่านสำหรับ HTTP Basic auth |
| `PORT` | `3000` | พอร์ตที่เว็บ UI รับฟังการเชื่อมต่อ |
| `TRUST_PROXY` | `false` | ตั้งค่าเป็น `true` หากทำงานอยู่หลัง reverse proxy (nginx, Traefik ฯลฯ) |

---

## ความปลอดภัย

- พอร์ตถูกผูกกับ `127.0.0.1` — ไม่ถูกเปิดเผยต่อเครือข่าย
- คอนเทนเนอร์ทำงานในโหมด non-root พร้อมไฟล์ระบบแบบอ่านอย่างเดียวและลดความสามารถ
- มีการจำกัดอัตราการเข้าถึงในทุกเส้นทาง API
- รายละเอียดข้อผิดพลาด upstream จะถูกบันทึกไว้ฝั่งเซิร์ฟเวอร์เท่านั้น — ข้อความทั่วไปจะถูกส่งกลับไปยังเบราว์เซอร์

### การกำหนดค่า reverse-proxy

หากคุณรัน gluetun-webui อยู่หลัง reverse proxy (nginx, Traefik, Caddy ฯลฯ) ให้ตั้งค่า `TRUST_PROXY=true` ในตัวแปรสภาพแวดล้อมของคุณ:

```yaml
gluetun-webui:
  image: scuzza/gluetun-webui:latest
  environment:
    - GLUETUN_CONTROL_URL=http://gluetun:8000
    - TRUST_PROXY=true  # Required for reverse proxies
```

สิ่งนี้ช่วยให้แอปสามารถแยกวิเคราะห์ `X-Forwarded-For` และเฮดเดอร์ที่เกี่ยวข้องได้อย่างถูกต้อง เพื่อจำกัดอัตราและตรวจจับ IP ได้แม่นยำ **หมายเหตุ:** ให้เปิดใช้เฉพาะกรณีที่คุณอยู่หลังรีเวิร์สพร็อกซีจริงๆ เท่านั้น เนื่องจากจะเชื่อถือเฮดเดอร์พร็อกซีจากรีเวิร์สพร็อกซีของคุณ

### การพิสูจน์ตัวตนของรีเวิร์สพร็อกซี

ปุ่มควบคุมเริ่ม/หยุด VPN ไม่มีการพิสูจน์ตัวตนในตัว หากคุณเปิด UI ให้ใช้งานเกินกว่า localhost ให้ตั้งไว้หลังรีเวิร์สพร็อกซีที่มี HTTP Basic auth

**Caddy** (`Caddyfile`):
```
your.domain.com {
  basicauth {
    user $2a$14$<bcrypt-hash>
  }
  reverse_proxy localhost:3000
}
```
สร้างแฮชด้วย: `caddy hash-password`

**Nginx** (`nginx.conf`):
```nginx
location / {
  auth_basic "Restricted";
  auth_basic_user_file /etc/nginx/.htpasswd;
  proxy_pass http://localhost:3000;
}
```
สร้างไฟล์รหัสผ่านด้วย: `htpasswd -c /etc/nginx/.htpasswd user`

**Traefik** (Docker labels):
```yaml
labels:
  - "traefik.enable=true"
  - "traefik.http.routers.gluetun-webui.rule=Host(`your.domain.com`)"
  - "traefik.http.routers.gluetun-webui.middlewares=auth"
  - "traefik.http.middlewares.auth.basicauth.users=user:$$apr1$$<hash>"
```
สร้างแฮชด้วย: `htpasswd -nb user password`

---

## คำขอบคุณ

- **[Gluetun](https://github.com/qdm12/gluetun)** — คอนเทนเนอร์ไคลเอนต์ VPN ที่เว็บ UI นี้ถูกสร้างขึ้นมาเพื่อมัน
- **[gluetun-monitor](https://github.com/csmarshall/gluetun-monitor)** — เครื่องมือมอนิเตอร์ที่ยอดเยี่ยมสำหรับใช้งานร่วมกับเว็บ UI นี้
- **การพัฒนาที่ได้รับความช่วยเหลือจาก AI** — โปรเจกต์นี้สร้างขึ้นด้วยความช่วยเหลือจาก AI

---

## ใบอนุญาต

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-29

---
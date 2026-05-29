<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
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

এটা লাইটৱেইট ৱেব ইউআই যি [Gluetun](https://github.com/qdm12/gluetun) — ডকৰৰ বাবে ভিপিএন ক্লায়েন্ট কন্টেইনাৰৰ মনিটৰিং আৰু নিয়ন্ত্ৰণৰ বাবে ব্যৱহাৰ কৰা হয়।

![Status: Connected](https://img.shields.io/badge/status-connected-brightgreen)
![Node 25](https://img.shields.io/badge/node-25--alpine-blue)
![Docker](https://img.shields.io/badge/docker-compose-blue)


---

## বৈশিষ্ট্যসমূহ

- ✨ **বহু-VPN সমৰ্থন** — একে সময়ত ২০টা Gluetun ইনষ্টেন্স মনিটৰ আৰু নিয়ন্ত্ৰণ কৰক
- লাইভ VPN স্থিতি বেনাৰ (সংযোগিত / ৰোৱা / বিছিন্ন)
- পাব্লিক এক্সিট IP, দেশ, অঞ্চল, চহৰ, আৰু সংগঠন
- VPN প্ৰভাইডাৰ, প্ৰটোকল (WireGuard / OpenVPN), ছাৰ্ভাৰ বিৱৰণ
- পোৰ্ট ফরৱাৰ্ডিং আৰু DNS স্থিতি
- VPN আৰম্ভ / বন্ধ নিয়ন্ত্ৰণসমূহ
- কনফিগাৰযোগ্য আন্তৰাল (৫ছ – ৬০ছ) সহ স্বয়ং-ৰিফ্ৰেছ
- ইতিহাস বাৰত শেষ ৩০টা প'ল টিক ৰঙীন ৰূপত
- প্ৰতিক্ৰিয়াশীল ডিজাইন (ম'বাইল, টেবলেট, ডেস্কটপ)

---

## স্ক্ৰীনশ্বটসমূহ
![alt text](https://raw.githubusercontent.com/Sir-Scuzza/gluetun-webui/main/image-1.png)

---

## আৱশ্যকতাসমূহ

- Docker + Docker Compose
- Gluetun-এ ইয়াৰ HTTP কন্ট্ৰ’ল ছাৰ্ভাৰ সক্ৰিয় হৈ চলি থকা (ডিফ’ল্ট পোৰ্ট `8000`)
- Gluetun আৰু gluetun-webui একেটা Docker নেটৱৰ্কত

> `linux/amd64` আৰু `linux/arm64` সমৰ্থন (Mac Intel/Apple Silicon, Linux, আৰু Windows-ত কাম কৰে)।

---

## দ্রুত আৰম্ভণি

### বিকল্প A1: একক ইনষ্টেন্স (পছন্দনীয়)

Gluetun-ৰ লগত আপোনাৰ বিদ্যমান compose ফাইলত `gluetun-webui` যোগ কৰক:

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

### বিকল্প A2: বহু প্ৰতিলিপি

২ টা বা তাতো অধিক Gluetun প্ৰতিলিপি পৃথক ডেশব'ৰ্ডৰ সৈতে মনিটৰ কৰক:

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

### বিকল্প B: স্থানীয়ভাৱে নিৰ্মাণ কৰক

```bash
git clone https://github.com/Sir-Scuzza/gluetun-webui.git
cd gluetun-webui
docker compose up -d --build
```

তাৰ পিছত (যিকোনো এটা বিকল্প) চলাও:

```bash
docker compose up -d
```

UIটো **http://localhost:3000** ত উপলব্ধ।

---

## নেটৱৰ্ক ছেটআপ

Gluetun আৰু gluetun-webui দুয়োটাই একে Docker নেটৱৰ্কত থাকিব লাগিব যাতে `http://gluetun:8000` ঠিক ভাবে resolve হয়।

**একেই compose ফাইল** — দুয়োটা service একেই নেটৱৰ্কত যোগ কৰক (সৰ্বাধিক সাধাৰণ):

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

**পৃথক কম্প'জ ফাইল** — Gluetun-ৰ বিদ্যমান নেটৱৰ্কক বাহ্যিক হিচাপে উল্লেখ কৰক। আপোনাৰ নেটৱৰ্কৰ নাম `docker network ls`-ৰ সহায়ত বিচাৰি উলিয়াওক:

```yaml
networks:
  ext-network:
    external: true
    name: your_gluetun_network_name
```

---

## মাল্টি-ভিপিএন সমৰ্থন

### বহু সংখ্যক ইনষ্টেন্স

gluetun-webui এ একে সময়তে **বহু Gluetun ইনষ্টেন্স মনিটৰ আৰু নিয়ন্ত্ৰণ** কৰিবলৈ সমৰ্থন কৰে। প্ৰতিটো ইনষ্টেন্স এটা পৃথক ডেশ্ব'ব'ৰ্ড হিচাপে এটা ৰেস্পনচিভ গ্ৰিডত প্ৰদৰ্শিত হয়।

**কনফিগাৰেচন**: নম্বৰত চিহ্নিত পৰিবেশ ভেৰিয়েবল ব্যৱহাৰ কৰক:

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

**সমৰ্থিত**: ২০ টা ইন্সটেন্সলৈকে (`GLUETUN_1_URL` ৰ পৰা `GLUETUN_20_URL` লৈ)  
**প্ৰতিক্ৰিয়াশীল**: ১টা সম্পূৰ্ণ-প্ৰস্থ ডেশব'ৰ্ড → ২টা অৰ্ধ-প্ৰস্থ → ৩টা তৃতীয়াংশ-প্ৰস্থ → ৪টা চতুৰ্থাংশ-প্ৰস্থ → ৫+ ত স্ক্ৰ'ল কৰিব পৰা

### পুৰণি সংস্কৰণৰ সৈতে সামঞ্জস্যতা

যদি ক্ৰমিক নম্বৰযুক্ত ভেৰিয়েবল কনফিগাৰ কৰা নহয়, তেন্তে **পুৰণি একক-ইন্সটেন্স মোড**-লৈ উভতি যায়:

```yaml
environment:
  - GLUETUN_CONTROL_URL=http://gluetun:8000  # legacy
  - GLUETUN_API_KEY=token
```

### প্ৰতি-উদাহৰণ প্ৰমাণীকৰণ

প্ৰত্যেকটা উদাহৰণৰ বাবে বেলেগ প্ৰমাণীকৰণ থাকিব পাৰে:

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

## কনফিগাৰেচন

| পৰিৱৰ্তনশীল | ডিফল্ট | বিৱৰণ |
|---|---|---|
| `GLUETUN_1_*` পৰা `GLUETUN_20_*` | _(খালী)_ | **মাল্টি-ইনষ্টেন্স কনফিগ** (২০টা ইন্সটেন্স পৰ্যন্ত) |
| `GLUETUN_{N}_URL` | – | ইন্সটেন্স N ৰ বাবে Gluetun HTTP কন্ট্ৰোল ছাৰ্ভাৰ URL |
| `GLUETUN_{N}_NAME` | `Instance {N}` | ইন্সটেন্স N ৰ বাবে দেখুওৱা নাম |
| `GLUETUN_{N}_API_KEY` | _(খালী)_ | ইন্সটেন্স N ৰ বাবে বেয়াৰ টোকেন (যদি authentication সক্ৰিয়) |
| `GLUETUN_{N}_USER` | _(খালী)_ | HTTP Basic auth ৰ বাবে ব্যৱহাৰকাৰী নাম (ইন্সটেন্স N) |
| `GLUETUN_{N}_PASSWORD` | _(খালী)_ | HTTP Basic auth ৰ বাবে পাছৱাৰ্ড (ইন্সটেন্স N) |
| `GLUETUN_CONTROL_URL` | `http://gluetun:8000` | **লেগাছি** – কেৱল এটা ইন্সটেন্স (ফলব্যাক, যদি `GLUETUN_1_*` ভেৰিয়েবল নাই) |
| `GLUETUN_API_KEY` | _(খালী)_ | **লেগাছি** – একক ইন্সটেন্সৰ বাবে বেয়াৰ টোকেন |
| `GLUETUN_USER` | _(খালী)_ | **লেগাছি** – HTTP Basic auth ৰ বাবে ব্যৱহাৰকাৰী নাম |
| `GLUETUN_PASSWORD` | _(খালী)_ | **লেগাছি** – HTTP Basic auth ৰ বাবে পাছৱাৰ্ড |
| `PORT` | `3000` | ৱেব UI যি প'ৰ্টত শুনে |
| `TRUST_PROXY` | `false` | `true` কৰিব যদি reverse proxy (nginx, Traefik, আদি) ৰ পিছত চলাইছে |

---

## সুৰক্ষা

- প'ৰ্ট `127.0.0.1` ত বাঁধা — নেটৱৰ্কত উন্মুক্ত নহয়
- কন্টেইনাৰ non-root হিচাপে চলে, read-only ফাইলছিস্টেম আৰু dropped capabilities সহ
- সকলো API ৰুটত rate limiting প্ৰয়োগ কৰা হৈছে
- Upstream ত হোৱা ত্ৰুটিৰ বিৱৰণ কেৱল ছাৰ্ভাৰ-পক্ষত লগ কৰা হয় — ব্রাউজাৰত সাধাৰণ বাৰ্তা প্ৰদান কৰা হয়

### Reverse-proxy কনফিগাৰেচন

যদি gluetun-webui ৰে reverse proxy (nginx, Traefik, Caddy, আদি) ৰ পিছত চলাই, environment variable ত `TRUST_PROXY=true` ছেট কৰক:


```yaml
gluetun-webui:
  image: scuzza/gluetun-webui:latest
  environment:
    - GLUETUN_CONTROL_URL=http://gluetun:8000
    - TRUST_PROXY=true  # Required for reverse proxies
```

এইয়ে এপ্লিকেশনক `X-Forwarded-For` আৰু সম্পৰ্কিত হেডাৰসমূহ সঠিকভাৱে বিশ্লেষণ কৰিবলৈ সক্ষম কৰে যাতে সঠিক হাৰ সীমাবদ্ধতা আৰু IP চিনাক্তকৰণ নিশ্চিত হয়। **টোকা:** কেৱল তেতিয়াহে এইটো সক্ৰিয় কৰক যেতিয়া আপুনি আসলতে এখন ৰিভাৰ্স প্ৰক্সীৰ পিছত আছ, কিয়নো এইয়ে আপোনাৰ ৰিভাৰ্স প্ৰক্সীৰ পৰা প্ৰক্সী হেডাৰসমূহত বিশ্বাস কৰে।

### ৰিভাৰ্স-প্ৰক্সী প্ৰমাণীকৰণ

VPN আৰম্ভ/বন্ধ নিয়ন্ত্ৰণত কোনো অন্তৰ্নিহিত প্ৰমাণীকৰণ নাই। যদি আপুনি UI localhostৰ বাহিৰত উন্মুক্ত কৰে, তেন্তে ইয়াক HTTP Basic auth সহ এখন ৰিভাৰ্স-প্ৰক্সীৰ পিছত ৰাখক।

**Caddy** (`Caddyfile`):
```
your.domain.com {
  basicauth {
    user $2a$14$<bcrypt-hash>
  }
  reverse_proxy localhost:3000
}
```
এটা হেশ সৃষ্টি কৰক: `caddy hash-password`

**Nginx** (`nginx.conf`):
```nginx
location / {
  auth_basic "Restricted";
  auth_basic_user_file /etc/nginx/.htpasswd;
  proxy_pass http://localhost:3000;
}
```
এটা পাছৱৰ্ড ফাইল উৎপন্ন কৰক: `htpasswd -c /etc/nginx/.htpasswd user`

**ট্ৰেফিক** (ডকৰ লেবেলসমূহ):
```yaml
labels:
  - "traefik.enable=true"
  - "traefik.http.routers.gluetun-webui.rule=Host(`your.domain.com`)"
  - "traefik.http.routers.gluetun-webui.middlewares=auth"
  - "traefik.http.middlewares.auth.basicauth.users=user:$$apr1$$<hash>"
```
`htpasswd -nb user password` ব্যৱহাৰ কৰি এটা হেছ সৃষ্টি কৰক

---

## কৃতজ্ঞতা

- **[Gluetun](https://github.com/qdm12/gluetun)** — এই ৱেব UI-টো নিৰ্মাণ কৰা VPN ক্লায়েন্ট কণ্টেইনাৰ
- **[gluetun-monitor](https://github.com/csmarshall/gluetun-monitor)** — এই ৱেব UI-টোৰ সৈতে জোড়া দিবলৈ উৎকৃষ্ট মনিটৰিং টুল
- **AI-Assisted Development** — এই প্ৰকল্প AI সহায়তাৰে নিৰ্মাণ কৰা হৈছে

---

## লাইচেঞ্চ

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-29

---

<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
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

[Gluetun](https://github.com/qdm12/gluetun) — Docker के लिए वीपीएन क्लाइंट कंटेनर की निगरानी और नियंत्रण हेतु एक हल्का वेब यूआई।

![स्थिति: कनेक्टेड](https://img.shields.io/badge/status-connected-brightgreen)
![Node 25](https://img.shields.io/badge/node-25--alpine-blue)
![Docker](https://img.shields.io/badge/docker-compose-blue)

---

## विशेषताएँ

- ✨ **मल्टी-वीपीएन समर्थन** — एक साथ 20 तक Gluetun इंस्टेंस की निगरानी और नियंत्रण करें
- लाइव वीपीएन स्थिति बैनर (कनेक्टेड / पॉज़्ड / डिस्कनेक्टेड)
- सार्वजनिक एग्जिट आईपी, देश, क्षेत्र, शहर, और संगठन
- वीपीएन प्रदाता, प्रोटोकॉल (WireGuard / OpenVPN), सर्वर विवरण
- पोर्ट फॉरवर्डिंग और DNS स्थिति
- वीपीएन स्टार्ट / स्टॉप नियंत्रण
- ऑटो-रिफ्रेश के साथ कॉन्फ़िगर करने योग्य अंतराल (5s – 60s)
- पिछले 30 पोल टिक्स इतिहास पट्टी में रंग-कोडित
- रिस्पॉन्सिव डिज़ाइन (मोबाइल, टैबलेट, डेस्कटॉप)

---

## स्क्रीनशॉट्स
![alt text](https://raw.githubusercontent.com/Sir-Scuzza/gluetun-webui/main/image-1.png)

---

## आवश्यकताएँ

- Docker + Docker Compose
- Gluetun चल रहा हो और उसका HTTP नियंत्रण सर्वर सक्षम हो (डिफ़ॉल्ट पोर्ट `8000`)
- Gluetun और gluetun-webui एक ही Docker नेटवर्क पर हों

> `linux/amd64` और `linux/arm64` को समर्थन करता है (Mac Intel/Apple Silicon, Linux, और Windows पर काम करता है)।

---

## त्वरित प्रारंभ

### विकल्प A1: एकल इंस्टेंस (अनुशंसित)

अपने मौजूदा कंपोज़ फ़ाइल में Gluetun के साथ `gluetun-webui` जोड़ें:

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

### विकल्प A2: एकाधिक उदाहरण

अलग-अलग डैशबोर्ड के साथ 2 या अधिक Gluetun उदाहरणों की निगरानी करें:

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

### विकल्प बी: स्थानीय रूप से निर्माण करें

```bash
git clone https://github.com/Sir-Scuzza/gluetun-webui.git
cd gluetun-webui
docker compose up -d --build
```
फिर चलाएँ (कोई भी विकल्प):


```bash
docker compose up -d
```

UI **http://localhost:3000** पर उपलब्ध है

---

## नेटवर्क सेटअप

Gluetun और gluetun-webui दोनों को एक ही Docker नेटवर्क पर होना चाहिए ताकि `http://gluetun:8000` सही से हल हो सके।

**एक ही compose फ़ाइल** — बस दोनों सेवाओं को एक ही नेटवर्क में जोड़ें (सबसे आम तरीका):

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

**अलग-अलग कंपोज़ फाइलें** — Gluetun के मौजूदा नेटवर्क को बाहरी के रूप में संदर्भित करें। अपने नेटवर्क का नाम `docker network ls` से खोजें:

```yaml
networks:
  ext-network:
    external: true
    name: your_gluetun_network_name
```

---

## मल्टी-VPN समर्थन

### कई इंस्टेंस

gluetun-webui **कई Gluetun इंस्टेंस को एक साथ मॉनिटर और नियंत्रित** करने का समर्थन करता है। प्रत्येक इंस्टेंस एक उत्तरदायी ग्रिड में अलग डैशबोर्ड के रूप में प्रदर्शित होता है।

**कॉन्फ़िगरेशन**: क्रमांकित एनवायरनमेंट वेरिएबल्स का उपयोग करें:

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

**समर्थित**: 20 तक इंस्टेंस ( `GLUETUN_1_URL` से लेकर `GLUETUN_20_URL` तक)  
**उत्तरदायी**: 1 फुल-विथ डैशबोर्ड → 2 हाफ-विथ → 3 थर्ड-विथ → 4 क्वार्टर-विथ → 5+ पर स्क्रॉल योग्य

### पिछड़ी संगतता

यदि कोई क्रमांकित वेरिएबल्स कॉन्फ़िगर नहीं किए गए हैं, तो **पुराने सिंगल-इंस्टेंस मोड** में लौट जाता है:

```yaml
environment:
  - GLUETUN_CONTROL_URL=http://gluetun:8000  # legacy
  - GLUETUN_API_KEY=token
```

### प्रति-इंस्टेंस प्रमाणीकरण

प्रत्येक इंस्टेंस में अलग प्रमाणीकरण हो सकता है:

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

## कॉन्फ़िगरेशन

| वेरिएबल | डिफ़ॉल्ट | विवरण |
|---|---|---|
| `GLUETUN_1_*` से `GLUETUN_20_*` | _(खाली)_ | **मल्टी-इंस्टेंस कॉन्फ़िग** (20 तक इंस्टेंस) |
| `GLUETUN_{N}_URL` | – | इंस्टेंस N के लिए Gluetun HTTP कंट्रोल सर्वर URL |
| `GLUETUN_{N}_NAME` | `इंस्टेंस {N}` | इंस्टेंस N के लिए डिस्प्ले नाम |
| `GLUETUN_{N}_API_KEY` | _(खाली)_ | इंस्टेंस N के लिए बियरर टोकन (यदि ऑथ सक्षम है) |
| `GLUETUN_{N}_USER` | _(खाली)_ | HTTP बेसिक ऑथ के लिए यूज़रनेम (इंस्टेंस N) |
| `GLUETUN_{N}_PASSWORD` | _(खाली)_ | HTTP बेसिक ऑथ के लिए पासवर्ड (इंस्टेंस N) |
| `GLUETUN_CONTROL_URL` | `http://gluetun:8000` | **लीगेसी** – केवल एकल इंस्टेंस (यदि कोई `GLUETUN_1_*` वेरिएबल नहीं है तो फॉलबैक) |
| `GLUETUN_API_KEY` | _(खाली)_ | **लीगेसी** – एकल इंस्टेंस के लिए बियरर टोकन |
| `GLUETUN_USER` | _(खाली)_ | **लीगेसी** – HTTP बेसिक ऑथ के लिए यूज़रनेम |
| `GLUETUN_PASSWORD` | _(खाली)_ | **लीगेसी** – HTTP बेसिक ऑथ के लिए पासवर्ड |
| `PORT` | `3000` | पोर्ट जिस पर वेब UI सुनता है |
| `TRUST_PROXY` | `false` | यदि रिवर्स प्रॉक्सी (nginx, Traefik, आदि) के पीछे चला रहे हैं तो `true` सेट करें |

---

## सुरक्षा

- पोर्ट `127.0.0.1` से जुड़ा है — नेटवर्क पर एक्सपोज़ नहीं है
- कंटेनर नॉन-रूट के रूप में चलता है, रीड-ओनली फाइल सिस्टम और गिराई गई क्षमताओं के साथ
- सभी API रूट्स पर रेट लिमिटिंग लागू है
- अपस्ट्रीम त्रुटि विवरण केवल सर्वर-साइड लॉग होते हैं — ब्राउज़र को सामान्य संदेश लौटाए जाते हैं

### रिवर्स-प्रॉक्सी कॉन्फ़िगरेशन

यदि आप gluetun-webui को रिवर्स प्रॉक्सी (nginx, Traefik, Caddy, आदि) के पीछे चलाते हैं, तो अपने एनवायरनमेंट वेरिएबल्स में `TRUST_PROXY=true` सेट करें:


```yaml
gluetun-webui:
  image: scuzza/gluetun-webui:latest
  environment:
    - GLUETUN_CONTROL_URL=http://gluetun:8000
    - TRUST_PROXY=true  # Required for reverse proxies
```
यह ऐप को `X-Forwarded-For` और संबंधित हेडर को सही ढंग से पार्स करने की अनुमति देता है, जिससे सटीक रेट लिमिटिंग और IP डिटेक्शन संभव होती है। **नोट:** इसे केवल तभी सक्षम करें जब आप वास्तव में एक रिवर्स प्रॉक्सी के पीछे हों, क्योंकि यह आपके रिवर्स प्रॉक्सी से प्रॉक्सी हेडर पर भरोसा करता है।

### रिवर्स-प्रॉक्सी प्रमाणीकरण

VPN स्टार्ट/स्टॉप नियंत्रणों में कोई अंतर्निर्मित प्रमाणीकरण नहीं है। यदि आप UI को लोकलहोस्ट से परे एक्सपोज करते हैं, तो इसे HTTP बेसिक ऑथ के साथ एक रिवर्स प्रॉक्सी के पीछे रखें।

**Caddy** (`Caddyfile`):

```
your.domain.com {
  basicauth {
    user $2a$14$<bcrypt-hash>
  }
  reverse_proxy localhost:3000
}
```
हैश जनरेट करें: `caddy hash-password`

**Nginx** (`nginx.conf`):
```nginx
location / {
  auth_basic "Restricted";
  auth_basic_user_file /etc/nginx/.htpasswd;
  proxy_pass http://localhost:3000;
}
```
एक पासवर्ड फ़ाइल जनरेट करें: `htpasswd -c /etc/nginx/.htpasswd user`

**Traefik** (डॉकर लेबल्स):
```yaml
labels:
  - "traefik.enable=true"
  - "traefik.http.routers.gluetun-webui.rule=Host(`your.domain.com`)"
  - "traefik.http.routers.gluetun-webui.middlewares=auth"
  - "traefik.http.middlewares.auth.basicauth.users=user:$$apr1$$<hash>"
```
हैश जनरेट करें: `htpasswd -nb user password`

---

## आभार

- **[Gluetun](https://github.com/qdm12/gluetun)** — वह वीपीएन क्लाइंट कंटेनर जिसके लिए यह वेबयूआई बनाया गया था
- **[gluetun-monitor](https://github.com/csmarshall/gluetun-monitor)** — इस वेबयूआई के साथ जोड़ने के लिए बेहतरीन मॉनिटरिंग टूल
- **एआई-सहायता प्राप्त विकास** — इस परियोजना को एआई सहायता के साथ बनाया गया है

---

## लाइसेंस

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-29

---
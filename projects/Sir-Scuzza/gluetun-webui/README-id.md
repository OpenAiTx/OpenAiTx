
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
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

Antarmuka web ringan untuk memantau dan mengontrol [Gluetun](https://github.com/qdm12/gluetun) — kontainer klien VPN untuk Docker.

![Status: Terhubung](https://img.shields.io/badge/status-connected-brightgreen)
![Node 25](https://img.shields.io/badge/node-25--alpine-blue)
![Docker](https://img.shields.io/badge/docker-compose-blue)

---

## Fitur

- ✨ **Dukungan Multi-VPN** — Pantau & kendalikan hingga 20 instance Gluetun secara bersamaan
- Banner status VPN langsung (terhubung / dijeda / terputus)
- IP publik keluar, negara, wilayah, kota, dan organisasi
- Penyedia VPN, protokol (WireGuard / OpenVPN), detail server
- Status port forwarding dan DNS
- Kontrol Mulai / Hentikan VPN
- Penyegaran otomatis dengan interval yang dapat diatur (5d – 60d)
- 30 polling terakhir diberi kode warna pada bilah riwayat
- Desain responsif (seluler, tablet, desktop)

---

## Cuplikan Layar
![alt text](https://raw.githubusercontent.com/Sir-Scuzza/gluetun-webui/main/image-1.png)

---

## Persyaratan

- Docker + Docker Compose
- Gluetun berjalan dengan server kontrol HTTP diaktifkan (port default `8000`)
- Gluetun dan gluetun-webui berada di jaringan Docker yang sama

> Mendukung `linux/amd64` dan `linux/arm64` (berfungsi di Mac Intel/Apple Silicon, Linux, dan Windows).

---

## Mulai Cepat

### Opsi A1: Instance Tunggal (Direkomendasikan)

Tambahkan `gluetun-webui` ke file compose Anda yang sudah ada bersama Gluetun:

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

### Opsi A2: Beberapa Instansi

Pantau 2+ instansi Gluetun dengan dasbor terpisah:

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

### Opsi B: Bangun Secara Lokal

```bash
git clone https://github.com/Sir-Scuzza/gluetun-webui.git
cd gluetun-webui
docker compose up -d --build
```

Kemudian jalankan (pilih salah satu opsi):

```bash
docker compose up -d
```

UI tersedia di **http://localhost:3000**

---

## Pengaturan Jaringan

Gluetun dan gluetun-webui harus berada di jaringan Docker yang sama agar `http://gluetun:8000` dapat diakses dengan benar.

**File compose yang sama** — cukup tambahkan kedua layanan ke jaringan yang sama (paling umum):

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

**File compose terpisah** — rujuk jaringan Gluetun yang sudah ada sebagai eksternal. Temukan nama jaringan Anda dengan `docker network ls`:

```yaml
networks:
  ext-network:
    external: true
    name: your_gluetun_network_name
```

---

## Dukungan Multi-VPN

### Banyak Instansi

gluetun-webui mendukung pemantauan dan pengendalian **beberapa instansi Gluetun secara bersamaan**. Setiap instansi ditampilkan sebagai dasbor terpisah dalam grid yang responsif.

**Konfigurasi**: Gunakan variabel lingkungan bernomor:

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

**Didukung**: Hingga 20 instans (melalui `GLUETUN_1_URL` hingga `GLUETUN_20_URL`)  
**Responsif**: 1 dasbor lebar penuh → 2 setengah lebar → 3 sepertiga lebar → 4 seperempat lebar → dapat digulir pada 5+

### Kompatibilitas Mundur

Jika tidak ada variabel bernomor yang dikonfigurasi, akan kembali ke **mode instans tunggal lama**:

```yaml
environment:
  - GLUETUN_CONTROL_URL=http://gluetun:8000  # legacy
  - GLUETUN_API_KEY=token
```

### Otentikasi Per-Instansi

Setiap instansi dapat memiliki otentikasi yang berbeda:

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

## Konfigurasi

| Variabel | Default | Deskripsi |
|---|---|---|
| `GLUETUN_1_*` hingga `GLUETUN_20_*` | _(kosong)_ | **Konfigurasi multi-instance** (maksimal 20 instance) |
| `GLUETUN_{N}_URL` | – | URL server kontrol HTTP Gluetun untuk instance N |
| `GLUETUN_{N}_NAME` | `Instance {N}` | Nama tampilan untuk instance N |
| `GLUETUN_{N}_API_KEY` | _(kosong)_ | Token Bearer untuk instance N (jika autentikasi diaktifkan) |
| `GLUETUN_{N}_USER` | _(kosong)_ | Username untuk autentikasi HTTP Basic (instance N) |
| `GLUETUN_{N}_PASSWORD` | _(kosong)_ | Password untuk autentikasi HTTP Basic (instance N) |
| `GLUETUN_CONTROL_URL` | `http://gluetun:8000` | **Legacy** – hanya untuk single instance (fallback jika tidak ada variabel `GLUETUN_1_*`) |
| `GLUETUN_API_KEY` | _(kosong)_ | **Legacy** – Token Bearer untuk single instance |
| `GLUETUN_USER` | _(kosong)_ | **Legacy** – Username untuk autentikasi HTTP Basic |
| `GLUETUN_PASSWORD` | _(kosong)_ | **Legacy** – Password untuk autentikasi HTTP Basic |
| `PORT` | `3000` | Port yang digunakan web UI |
| `TRUST_PROXY` | `false` | Setel ke `true` jika berjalan di belakang reverse proxy (nginx, Traefik, dll.) |

---

## Keamanan

- Port hanya diikat ke `127.0.0.1` — tidak diekspos ke jaringan
- Kontainer berjalan sebagai non-root dengan filesystem read-only dan kapabilitas dikurangi
- Pembatasan rate diterapkan pada semua rute API
- Detail error upstream hanya dicatat di sisi server — pesan generik dikirim ke browser

### Konfigurasi reverse-proxy

Jika Anda menjalankan gluetun-webui di belakang reverse proxy (nginx, Traefik, Caddy, dll.), setel `TRUST_PROXY=true` di variabel lingkungan Anda:


```yaml
gluetun-webui:
  image: scuzza/gluetun-webui:latest
  environment:
    - GLUETUN_CONTROL_URL=http://gluetun:8000
    - TRUST_PROXY=true  # Required for reverse proxies
```

Ini memungkinkan aplikasi untuk mem-parsing `X-Forwarded-For` dan header terkait dengan benar untuk pembatasan laju dan deteksi IP yang akurat. **Catatan:** Hanya aktifkan ini jika Anda benar-benar berada di belakang reverse proxy, karena ini mempercayai header proxy dari reverse proxy Anda.

### Autentikasi reverse-proxy

Kontrol mulai/berhenti VPN tidak memiliki autentikasi bawaan. Jika Anda mengekspos UI di luar localhost, tempatkan di belakang reverse proxy dengan HTTP Basic auth.

**Caddy** (`Caddyfile`):
```
your.domain.com {
  basicauth {
    user $2a$14$<bcrypt-hash>
  }
  reverse_proxy localhost:3000
}
```
Hasilkan hash dengan: `caddy hash-password`

**Nginx** (`nginx.conf`):
```nginx
location / {
  auth_basic "Restricted";
  auth_basic_user_file /etc/nginx/.htpasswd;
  proxy_pass http://localhost:3000;
}
```
Hasilkan file sandi dengan: `htpasswd -c /etc/nginx/.htpasswd user`

**Traefik** (label Docker):
```yaml
labels:
  - "traefik.enable=true"
  - "traefik.http.routers.gluetun-webui.rule=Host(`your.domain.com`)"
  - "traefik.http.routers.gluetun-webui.middlewares=auth"
  - "traefik.http.middlewares.auth.basicauth.users=user:$$apr1$$<hash>"
```
Hasilkan hash dengan: `htpasswd -nb user password`

---

## Ucapan Terima Kasih

- **[Gluetun](https://github.com/qdm12/gluetun)** — Kontainer klien VPN yang menjadi dasar webui ini
- **[gluetun-monitor](https://github.com/csmarshall/gluetun-monitor)** — Alat monitoring hebat untuk dipasangkan dengan webui ini
- **Pengembangan Berbantuan AI** — Proyek ini dibangun dengan bantuan AI

---

## Lisensi

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-29

---
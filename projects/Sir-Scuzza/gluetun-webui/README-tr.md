
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
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

[Gluetun](https://github.com/qdm12/gluetun) için hafif bir web arayüzü — Docker için VPN istemci konteynerini izlemek ve kontrol etmek için.

![Durum: Bağlandı](https://img.shields.io/badge/status-connected-brightgreen)
![Node 25](https://img.shields.io/badge/node-25--alpine-blue)
![Docker](https://img.shields.io/badge/docker-compose-blue)

---

## Özellikler

- ✨ **Çoklu VPN Desteği** — Aynı anda 20'ye kadar Gluetun örneğini izleyin ve kontrol edin
- Canlı VPN durumu bandı (bağlı / duraklatıldı / bağlantı kesildi)
- Genel çıkış IP'si, ülke, bölge, şehir ve organizasyon
- VPN sağlayıcısı, protokol (WireGuard / OpenVPN), sunucu detayları
- Port yönlendirme ve DNS durumu
- VPN Başlat / Durdur kontrolleri
- Yapılandırılabilir aralıkla otomatik yenileme (5s – 60s)
- Son 30 sorgu aralığı geçmiş çubuğunda renk kodlu
- Duyarlı tasarım (mobil, tablet, masaüstü)

---

## Ekran Görüntüleri
![alt text](https://raw.githubusercontent.com/Sir-Scuzza/gluetun-webui/main/image-1.png)

---

## Gereksinimler

- Docker + Docker Compose
- Gluetun'un HTTP kontrol sunucusu etkin olarak çalışıyor olmalı (varsayılan port `8000`)
- Gluetun ve gluetun-webui aynı Docker ağında olmalı

> `linux/amd64` ve `linux/arm64` desteklenir (Mac Intel/Apple Silicon, Linux ve Windows'ta çalışır).

---

## Hızlı Başlangıç

### Seçenek A1: Tekli Örnek (Tavsiye Edilen)

Gluetun ile birlikte mevcut compose dosyanıza `gluetun-webui` ekleyin:

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

### Seçenek A2: Birden Fazla Örnek

Ayrı panolarla 2 veya daha fazla Gluetun örneğini izleyin:

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

### Seçenek B: Yerel Olarak Derleyin

```bash
git clone https://github.com/Sir-Scuzza/gluetun-webui.git
cd gluetun-webui
docker compose up -d --build
```

Sonra (herhangi bir seçeneği) çalıştırın:

```bash
docker compose up -d
```

UI şu adreste mevcuttur: **http://localhost:3000**

---

## Ağ Kurulumu

Hem Gluetun hem de gluetun-webui aynı Docker ağında olmalıdır, böylece `http://gluetun:8000` doğru şekilde çözülür.

**Aynı compose dosyası** — sadece her iki servisi de aynı ağa ekleyin (en yaygın yöntem):

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

**Ayrı compose dosyaları** — Gluetun'un mevcut ağını harici olarak referans alın. Ağ adınızı `docker network ls` ile bulun:

```yaml
networks:
  ext-network:
    external: true
    name: your_gluetun_network_name
```

---

## Çoklu VPN Desteği

### Birden Fazla Örnek

gluetun-webui, **birden fazla Gluetun örneğini aynı anda izleme ve kontrol etme** desteği sunar. Her bir örnek, duyarlı bir ızgarada ayrı bir gösterge paneli olarak görüntülenir.

**Yapılandırma**: Numaralandırılmış ortam değişkenlerini kullanın:

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

**Desteklenen**: 20 adede kadar örnek (`GLUETUN_1_URL` ile `GLUETUN_20_URL` arasında)  
**Duyarlı**: 1 tam genişlikte pano → 2 yarım genişlik → 3 üçte bir genişlik → 4 dörtte bir genişlik → 5 ve üzeri kaydırılabilir

### Geriye Dönük Uyumluluk

Numaralı değişkenler yapılandırılmazsa, **eski tek örnek modu**na geri döner:

```yaml
environment:
  - GLUETUN_CONTROL_URL=http://gluetun:8000  # legacy
  - GLUETUN_API_KEY=token
```

### Örneğe Özel Kimlik Doğrulama

Her bir örnek farklı kimlik doğrulama yöntemlerine sahip olabilir:

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

## Konfigürasyon

| Değişken | Varsayılan | Açıklama |
|---|---|---|
| `GLUETUN_1_*` ile `GLUETUN_20_*` | _(boş)_ | **Çoklu örnek yapılandırması** (en fazla 20 örnek) |
| `GLUETUN_{N}_URL` | – | Örnek N için Gluetun HTTP kontrol sunucusu URL'si |
| `GLUETUN_{N}_NAME` | `Instance {N}` | Örnek N için görüntülenen ad |
| `GLUETUN_{N}_API_KEY` | _(boş)_ | Örnek N için Bearer token (kimlik doğrulama etkinse) |
| `GLUETUN_{N}_USER` | _(boş)_ | HTTP Basic kimlik doğrulaması için kullanıcı adı (örnek N) |
| `GLUETUN_{N}_PASSWORD` | _(boş)_ | HTTP Basic kimlik doğrulaması için şifre (örnek N) |
| `GLUETUN_CONTROL_URL` | `http://gluetun:8000` | **Eski** – yalnızca tekli örnek (eğer `GLUETUN_1_*` değişkeni yoksa yedek) |
| `GLUETUN_API_KEY` | _(boş)_ | **Eski** – Tekli örnek için Bearer token |
| `GLUETUN_USER` | _(boş)_ | **Eski** – HTTP Basic kimlik doğrulaması için kullanıcı adı |
| `GLUETUN_PASSWORD` | _(boş)_ | **Eski** – HTTP Basic kimlik doğrulaması için şifre |
| `PORT` | `3000` | Web arayüzünün dinlediği port |
| `TRUST_PROXY` | `false` | Ters proxy (nginx, Traefik, vb.) arkasında çalışıyorsa `true` olarak ayarlayın |

---

## Güvenlik

- Port `127.0.0.1` adresine bağlıdır — ağa açılmaz
- Konteyner, salt okunur dosya sistemi ve düşürülmüş yetkiler ile root olmayan olarak çalışır
- Tüm API yollarında hız sınırlaması uygulanır
- Üst sunucudaki hata ayrıntıları yalnızca sunucu tarafında kaydedilir — tarayıcıya genel mesajlar döner

### Ters proxy yapılandırması

Gluetun-webui'yi bir ters proxy (nginx, Traefik, Caddy, vb.) arkasında çalıştırıyorsanız, ortam değişkenlerinizde `TRUST_PROXY=true` olarak ayarlayın:


```yaml
gluetun-webui:
  image: scuzza/gluetun-webui:latest
  environment:
    - GLUETUN_CONTROL_URL=http://gluetun:8000
    - TRUST_PROXY=true  # Required for reverse proxies
```

Bu, uygulamanın doğru şekilde `X-Forwarded-For` ve ilgili başlıkları ayrıştırmasını sağlar; böylece doğru hız sınırlaması ve IP tespiti yapılabilir. **Not:** Bunu yalnızca gerçekten bir ters proxy arkasındaysanız etkinleştirin; çünkü proxy başlıklarına ters proxy'nizden güvenilir.

### Ters Proxy Kimlik Doğrulaması

VPN başlat/durdur kontrollerinde yerleşik bir kimlik doğrulama yoktur. Arayüzü localhost dışında bir yere açarsanız, onu HTTP Basic kimlik doğrulaması olan bir ters proxy arkasına yerleştirin.

**Caddy** (`Caddyfile`):
```
your.domain.com {
  basicauth {
    user $2a$14$<bcrypt-hash>
  }
  reverse_proxy localhost:3000
}
```
Bir hash oluşturmak için: `caddy hash-password` komutunu kullanın.

**Nginx** (`nginx.conf`):
```nginx
location / {
  auth_basic "Restricted";
  auth_basic_user_file /etc/nginx/.htpasswd;
  proxy_pass http://localhost:3000;
}
```
Bir parola dosyası oluşturun: `htpasswd -c /etc/nginx/.htpasswd user`

**Traefik** (Docker etiketleri):
```yaml
labels:
  - "traefik.enable=true"
  - "traefik.http.routers.gluetun-webui.rule=Host(`your.domain.com`)"
  - "traefik.http.routers.gluetun-webui.middlewares=auth"
  - "traefik.http.middlewares.auth.basicauth.users=user:$$apr1$$<hash>"
```
Bir hash oluşturun: `htpasswd -nb user password`

---

## Teşekkürler

- **[Gluetun](https://github.com/qdm12/gluetun)** — Bu web arayüzünün geliştirildiği VPN istemci konteyneri
- **[gluetun-monitor](https://github.com/csmarshall/gluetun-monitor)** — Bu web arayüzü ile birlikte kullanılabilecek harika bir izleme aracı
- **Yapay Zekâ Destekli Geliştirme** — Bu proje yapay zekâ yardımıyla geliştirildi

---

## Lisans

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-29

---
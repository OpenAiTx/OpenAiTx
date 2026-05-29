
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
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

Eine leichtgewichtige Web-Benutzeroberfläche zur Überwachung und Steuerung von [Gluetun](https://github.com/qdm12/gluetun) — dem VPN-Client-Container für Docker.

![Status: Verbunden](https://img.shields.io/badge/status-connected-brightgreen)
![Node 25](https://img.shields.io/badge/node-25--alpine-blue)
![Docker](https://img.shields.io/badge/docker-compose-blue)

---

## Funktionen

- ✨ **Multi-VPN-Unterstützung** — Überwachen und steuern Sie bis zu 20 Gluetun-Instanzen gleichzeitig
- Live-VPN-Status-Banner (verbunden / pausiert / getrennt)
- Öffentliche Exit-IP, Land, Region, Stadt und Organisation
- VPN-Anbieter, Protokoll (WireGuard / OpenVPN), Serverdetails
- Portweiterleitung und DNS-Status
- VPN-Steuerung Start / Stopp
- Automatische Aktualisierung mit konfigurierbarem Intervall (5s – 60s)
- Letzte 30 Abfrage-Ticks farblich codiert in der Verlaufleiste
- Responsives Design (Mobil, Tablet, Desktop)

---

## Screenshots
![alt text](https://raw.githubusercontent.com/Sir-Scuzza/gluetun-webui/main/image-1.png)

---

## Anforderungen

- Docker + Docker Compose
- Gluetun läuft mit aktiviertem HTTP-Control-Server (Standardport `8000`)
- Gluetun und gluetun-webui im selben Docker-Netzwerk

> Unterstützt `linux/amd64` und `linux/arm64` (funktioniert auf Mac Intel/Apple Silicon, Linux und Windows).

---

## Schnellstart

### Option A1: Einzelne Instanz (Empfohlen)

Fügen Sie `gluetun-webui` zu Ihrer bestehenden Compose-Datei zusammen mit Gluetun hinzu:

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

### Option A2: Mehrere Instanzen

Überwachen Sie 2 oder mehr Gluetun-Instanzen mit separaten Dashboards:

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

### Option B: Lokal bauen

```bash
git clone https://github.com/Sir-Scuzza/gluetun-webui.git
cd gluetun-webui
docker compose up -d --build
```
  
Führen Sie dann aus (eine der beiden Optionen):

```bash
docker compose up -d
```

Die Benutzeroberfläche ist verfügbar unter **http://localhost:3000**

---

## Netzwerkkonfiguration

Sowohl Gluetun als auch gluetun-webui müssen sich im selben Docker-Netzwerk befinden, damit `http://gluetun:8000` korrekt aufgelöst wird.

**Gleiche Compose-Datei** — fügen Sie einfach beide Dienste demselben Netzwerk hinzu (am gebräuchlichsten):

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

**Separate Compose-Dateien** — verweisen Sie auf das bestehende Netzwerk von Gluetun als extern. Finden Sie Ihren Netzwerknamen mit `docker network ls`:

```yaml
networks:
  ext-network:
    external: true
    name: your_gluetun_network_name
```

---

## Unterstützung für mehrere VPNs

### Mehrere Instanzen

gluetun-webui unterstützt die Überwachung und Steuerung von **mehreren Gluetun-Instanzen gleichzeitig**. Jede Instanz wird als separates Dashboard in einem responsiven Raster angezeigt.

**Konfiguration**: Verwenden Sie durchnummerierte Umgebungsvariablen:

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

**Unterstützt**: Bis zu 20 Instanzen (über `GLUETUN_1_URL` bis `GLUETUN_20_URL`)  
**Responsiv**: 1 volle Breite Dashboard → 2 halbe Breite → 3 Drittel-Breite → 4 Viertel-Breite → ab 5+ scrollbar

### Rückwärtskompatibilität

Wenn keine nummerierten Variablen konfiguriert sind, wird auf den **Legacy-Einzelinstanzmodus** zurückgegriffen:

```yaml
environment:
  - GLUETUN_CONTROL_URL=http://gluetun:8000  # legacy
  - GLUETUN_API_KEY=token
```

### Authentifizierung pro Instanz

Jede Instanz kann eine unterschiedliche Authentifizierung haben:

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

## Konfiguration

| Variable | Standardwert | Beschreibung |
|---|---|---|
| `GLUETUN_1_*` bis `GLUETUN_20_*` | _(leer)_ | **Multi-Instanz-Konfiguration** (bis zu 20 Instanzen) |
| `GLUETUN_{N}_URL` | – | Gluetun HTTP-Steuerungsserver-URL für Instanz N |
| `GLUETUN_{N}_NAME` | `Instance {N}` | Anzeigename für Instanz N |
| `GLUETUN_{N}_API_KEY` | _(leer)_ | Bearer-Token für Instanz N (falls Authentifizierung aktiviert) |
| `GLUETUN_{N}_USER` | _(leer)_ | Benutzername für HTTP-Basic-Authentifizierung (Instanz N) |
| `GLUETUN_{N}_PASSWORD` | _(leer)_ | Passwort für HTTP-Basic-Authentifizierung (Instanz N) |
| `GLUETUN_CONTROL_URL` | `http://gluetun:8000` | **Veraltet** – nur Einzelinstanz (Fallback, falls keine `GLUETUN_1_*`-Variablen gesetzt sind) |
| `GLUETUN_API_KEY` | _(leer)_ | **Veraltet** – Bearer-Token für Einzelinstanz |
| `GLUETUN_USER` | _(leer)_ | **Veraltet** – Benutzername für HTTP-Basic-Authentifizierung |
| `GLUETUN_PASSWORD` | _(leer)_ | **Veraltet** – Passwort für HTTP-Basic-Authentifizierung |
| `PORT` | `3000` | Port, auf dem die Web-Oberfläche lauscht |
| `TRUST_PROXY` | `false` | Setze auf `true`, wenn hinter einem Reverse Proxy (nginx, Traefik, etc.) betrieben |

---

## Sicherheit

- Port ist an `127.0.0.1` gebunden — nicht im Netzwerk verfügbar
- Container läuft als Nicht-Root mit schreibgeschütztem Dateisystem und eingeschränkten Berechtigungen
- Ratenbegrenzung auf alle API-Routen angewendet
- Fehlerdetails von Upstream werden nur serverseitig protokolliert — generische Meldungen werden an den Browser zurückgegeben

### Reverse-Proxy-Konfiguration

Wenn Sie gluetun-webui hinter einem Reverse Proxy (nginx, Traefik, Caddy, etc.) betreiben, setzen Sie `TRUST_PROXY=true` in Ihren Umgebungsvariablen:

```yaml
gluetun-webui:
  image: scuzza/gluetun-webui:latest
  environment:
    - GLUETUN_CONTROL_URL=http://gluetun:8000
    - TRUST_PROXY=true  # Required for reverse proxies
```
Dies ermöglicht der App, `X-Forwarded-For` und verwandte Header korrekt zu parsen, um eine genaue Ratenbegrenzung und IP-Erkennung durchzuführen. **Hinweis:** Aktiviere dies nur, wenn du tatsächlich hinter einem Reverse Proxy bist, da Proxy-Header von deinem Reverse Proxy vertraut werden.

### Reverse-Proxy-Authentifizierung

Die VPN-Start/Stopp-Steuerungen verfügen über keine integrierte Authentifizierung. Wenn du das UI außerhalb von localhost zugänglich machst, platziere es hinter einem Reverse Proxy mit HTTP Basic Auth.

**Caddy** (`Caddyfile`):

```
your.domain.com {
  basicauth {
    user $2a$14$<bcrypt-hash>
  }
  reverse_proxy localhost:3000
}
```
Erzeuge einen Hash mit: `caddy hash-password`

**Nginx** (`nginx.conf`):
```nginx
location / {
  auth_basic "Restricted";
  auth_basic_user_file /etc/nginx/.htpasswd;
  proxy_pass http://localhost:3000;
}
```
Erstellen Sie eine Passwortdatei mit: `htpasswd -c /etc/nginx/.htpasswd user`

**Traefik** (Docker-Labels):
```yaml
labels:
  - "traefik.enable=true"
  - "traefik.http.routers.gluetun-webui.rule=Host(`your.domain.com`)"
  - "traefik.http.routers.gluetun-webui.middlewares=auth"
  - "traefik.http.middlewares.auth.basicauth.users=user:$$apr1$$<hash>"
```
Generiere einen Hash mit: `htpasswd -nb benutzer passwort`

---

## Danksagungen

- **[Gluetun](https://github.com/qdm12/gluetun)** — Der VPN-Client-Container, für den dieses WebUI entwickelt wurde
- **[gluetun-monitor](https://github.com/csmarshall/gluetun-monitor)** — Großartiges Überwachungstool, das gut zu diesem WebUI passt
- **KI-unterstützte Entwicklung** — Dieses Projekt wurde mit KI-Unterstützung entwickelt

---

## Lizenz

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-29

---
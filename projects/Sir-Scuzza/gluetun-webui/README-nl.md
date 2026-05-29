
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=ja">Japans</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=ko">Koreaans</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=th">Thais</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=fa">Perzisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Gluetun WebUI

Een lichtgewicht web UI voor het monitoren en beheren van [Gluetun](https://github.com/qdm12/gluetun) — de VPN-client container voor Docker.

![Status: Verbonden](https://img.shields.io/badge/status-connected-brightgreen)
![Node 25](https://img.shields.io/badge/node-25--alpine-blue)
![Docker](https://img.shields.io/badge/docker-compose-blue)

---

## Functies

- ✨ **Multi-VPN Ondersteuning** — Monitor en beheer tot 20 Gluetun-instanties tegelijkertijd
- Live VPN-statusbanner (verbonden / gepauzeerd / losgekoppeld)
- Publiek exit-IP, land, regio, stad en organisatie
- VPN-provider, protocol (WireGuard / OpenVPN), servergegevens
- Port forwarding en DNS-status
- Start / Stop VPN-bediening
- Auto-refresh met instelbaar interval (5s – 60s)
- Laatste 30 poll-ticks kleurgecodeerd in de geschiedenisbalk
- Responsief ontwerp (mobiel, tablet, desktop)

---

## Screenshots
![alt tekst](https://raw.githubusercontent.com/Sir-Scuzza/gluetun-webui/main/image-1.png)

---

## Vereisten

- Docker + Docker Compose
- Gluetun met ingeschakelde HTTP-controleserver (standaardpoort `8000`)
- Gluetun en gluetun-webui op hetzelfde Docker-netwerk

> Ondersteunt `linux/amd64` en `linux/arm64` (werkt op Mac Intel/Apple Silicon, Linux en Windows).

---

## Snelstart

### Optie A1: Enkele instantie (Aanbevolen)

Voeg `gluetun-webui` toe aan je bestaande compose-bestand naast Gluetun:

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

### Optie A2: Meerdere Instanties

Monitor 2+ Gluetun-instanties met aparte dashboards:

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

### Optie B: Lokaal Bouwen

```bash
git clone https://github.com/Sir-Scuzza/gluetun-webui.git
cd gluetun-webui
docker compose up -d --build
```
  
Voer dan uit (één van de opties):

```bash
docker compose up -d
```

De gebruikersinterface is beschikbaar op **http://localhost:3000**

---

## Netwerkinstelling

Zowel Gluetun als gluetun-webui moeten op hetzelfde Docker-netwerk zitten zodat `http://gluetun:8000` correct wordt opgelost.

**Zelfde compose-bestand** — voeg gewoon beide services toe aan hetzelfde netwerk (meest gebruikelijk):

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

**Gescheiden compose-bestanden** — verwijs naar het bestaande netwerk van Gluetun als extern. Vind uw netwerknaam met `docker network ls`:

```yaml
networks:
  ext-network:
    external: true
    name: your_gluetun_network_name
```

---

## Ondersteuning voor meerdere VPN's

### Meerdere Instanties

gluetun-webui ondersteunt het monitoren en besturen van **meerdere Gluetun-instanties tegelijkertijd**. Elke instantie wordt weergegeven als een apart dashboard in een responsief raster.

**Configuratie**: Gebruik genummerde omgevingsvariabelen:

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

**Ondersteund**: Tot 20 instanties (via `GLUETUN_1_URL` tot `GLUETUN_20_URL`)  
**Responsief**: 1 dashboard op volledige breedte → 2 op halve breedte → 3 op een derde breedte → 4 op een kwart breedte → scrollbaar bij 5+

### Achterwaartse compatibiliteit

Als er geen genummerde variabelen zijn geconfigureerd, valt terug op **legacy single-instance modus**:

```yaml
environment:
  - GLUETUN_CONTROL_URL=http://gluetun:8000  # legacy
  - GLUETUN_API_KEY=token
```

### Authenticatie per instantie

Elke instantie kan een andere authenticatie hebben:

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

## Configuratie

| Variabele | Standaard | Beschrijving |
|---|---|---|
| `GLUETUN_1_*` tot `GLUETUN_20_*` | _(leeg)_ | **Multi-instance config** (tot 20 instanties) |
| `GLUETUN_{N}_URL` | – | Gluetun HTTP control server URL voor instantie N |
| `GLUETUN_{N}_NAME` | `Instance {N}` | Weergavenaam voor instantie N |
| `GLUETUN_{N}_API_KEY` | _(leeg)_ | Bearer token voor instantie N (indien authenticatie ingeschakeld) |
| `GLUETUN_{N}_USER` | _(leeg)_ | Gebruikersnaam voor HTTP Basic auth (instantie N) |
| `GLUETUN_{N}_PASSWORD` | _(leeg)_ | Wachtwoord voor HTTP Basic auth (instantie N) |
| `GLUETUN_CONTROL_URL` | `http://gluetun:8000` | **Legacy** – slechts één instantie (fallback indien geen `GLUETUN_1_*` variabelen) |
| `GLUETUN_API_KEY` | _(leeg)_ | **Legacy** – Bearer token voor één instantie |
| `GLUETUN_USER` | _(leeg)_ | **Legacy** – Gebruikersnaam voor HTTP Basic auth |
| `GLUETUN_PASSWORD` | _(leeg)_ | **Legacy** – Wachtwoord voor HTTP Basic auth |
| `PORT` | `3000` | Poort waarop de web UI luistert |
| `TRUST_PROXY` | `false` | Zet op `true` als je achter een reverse proxy draait (nginx, Traefik, etc.) |

---

## Beveiliging

- Poort is gebonden aan `127.0.0.1` — niet blootgesteld aan het netwerk
- Container draait als non-root met read-only bestandssysteem en verwijderde capabilities
- Rate limiting toegepast op alle API-routes
- Upstream foutdetails worden alleen server-side gelogd — algemene berichten worden aan de browser teruggegeven

### Reverse-proxy configuratie

Als je gluetun-webui achter een reverse proxy draait (nginx, Traefik, Caddy, etc.), stel `TRUST_PROXY=true` in je omgevingsvariabelen:


```yaml
gluetun-webui:
  image: scuzza/gluetun-webui:latest
  environment:
    - GLUETUN_CONTROL_URL=http://gluetun:8000
    - TRUST_PROXY=true  # Required for reverse proxies
```

Hierdoor kan de app de headers `X-Forwarded-For` en gerelateerde headers correct parseren voor nauwkeurige snelheidsbeperking en IP-detectie. **Let op:** Schakel dit alleen in als je daadwerkelijk achter een reverse proxy zit, omdat het proxyheaders van jouw reverse proxy vertrouwt.

### Reverse-proxy authenticatie

De VPN start/stop controls hebben geen ingebouwde authenticatie. Als je de UI buiten localhost toegankelijk maakt, plaats deze dan achter een reverse proxy met HTTP Basic-authenticatie.

**Caddy** (`Caddyfile`):
```
your.domain.com {
  basicauth {
    user $2a$14$<bcrypt-hash>
  }
  reverse_proxy localhost:3000
}
```
Genereer een hash met: `caddy hash-password`

**Nginx** (`nginx.conf`):
```nginx
location / {
  auth_basic "Restricted";
  auth_basic_user_file /etc/nginx/.htpasswd;
  proxy_pass http://localhost:3000;
}
```
Genereer een wachtwoordbestand met: `htpasswd -c /etc/nginx/.htpasswd gebruiker`

**Traefik** (Docker labels):
```yaml
labels:
  - "traefik.enable=true"
  - "traefik.http.routers.gluetun-webui.rule=Host(`your.domain.com`)"
  - "traefik.http.routers.gluetun-webui.middlewares=auth"
  - "traefik.http.middlewares.auth.basicauth.users=user:$$apr1$$<hash>"
```
Genereer een hash met: `htpasswd -nb gebruiker wachtwoord`

---

## Erkenningen

- **[Gluetun](https://github.com/qdm12/gluetun)** — De VPN-clientcontainer waarvoor deze webui is gebouwd
- **[gluetun-monitor](https://github.com/csmarshall/gluetun-monitor)** — Geweldig monitoring tool om te combineren met deze webui
- **AI-Assisted Development** — Dit project is gebouwd met AI-assistentie

---

## Licentie

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-29

---
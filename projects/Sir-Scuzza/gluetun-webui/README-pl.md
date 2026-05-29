
<div align="right">
  <details>
    <summary >🌐 Język</summary>
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

Lekki interfejs webowy do monitorowania i zarządzania [Gluetun](https://github.com/qdm12/gluetun) — klientem VPN w kontenerze Docker.

![Status: Połączono](https://img.shields.io/badge/status-connected-brightgreen)
![Node 25](https://img.shields.io/badge/node-25--alpine-blue)
![Docker](https://img.shields.io/badge/docker-compose-blue)

---

## Funkcje

- ✨ **Obsługa wielu VPN** — Monitoruj i kontroluj do 20 instancji Gluetun jednocześnie
- Banner statusu VPN na żywo (połączony / wstrzymany / rozłączony)
- Publiczny IP wyjściowy, kraj, region, miasto i organizacja
- Dostawca VPN, protokół (WireGuard / OpenVPN), szczegóły serwera
- Status przekierowania portów i DNS
- Kontrola Start / Stop VPN
- Automatyczne odświeżanie z konfigurowalnym interwałem (5s – 60s)
- Ostatnie 30 cykli odpytywania kolorystycznie oznaczone w pasku historii
- Responsywny design (telefon, tablet, komputer)

---

## Zrzuty ekranu
![alt text](https://raw.githubusercontent.com/Sir-Scuzza/gluetun-webui/main/image-1.png)

---

## Wymagania

- Docker + Docker Compose
- Gluetun uruchomiony z włączonym serwerem HTTP sterowania (domyślny port `8000`)
- Gluetun i gluetun-webui na tej samej sieci Docker

> Obsługuje `linux/amd64` oraz `linux/arm64` (działa na Mac Intel/Apple Silicon, Linux oraz Windows).

---

## Szybki start

### Opcja A1: Pojedyncza instancja (zalecane)

Dodaj `gluetun-webui` do istniejącego pliku compose obok Gluetun:

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

### Opcja A2: Wiele instancji

Monitoruj 2 lub więcej instancji Gluetun na osobnych pulpitach nawigacyjnych:

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

### Opcja B: Budowa lokalna

```bash
git clone https://github.com/Sir-Scuzza/gluetun-webui.git
cd gluetun-webui
docker compose up -d --build
```

Następnie uruchom (dowolną opcję):

```bash
docker compose up -d
```

Interfejs użytkownika jest dostępny pod adresem **http://localhost:3000**

---

## Konfiguracja sieci

Zarówno Gluetun, jak i gluetun-webui muszą być w tej samej sieci Docker, aby `http://gluetun:8000` poprawnie się rozwiązywał.

**Ten sam plik compose** — po prostu dodaj oba serwisy do tej samej sieci (najczęstsze rozwiązanie):

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

**Oddzielne pliki compose** — odwołaj się do istniejącej sieci Gluetun jako zewnętrznej. Znajdź nazwę swojej sieci za pomocą `docker network ls`:

```yaml
networks:
  ext-network:
    external: true
    name: your_gluetun_network_name
```

---

## Obsługa wielu VPN

### Wiele instancji

gluetun-webui umożliwia monitorowanie i kontrolowanie **wielu instancji Gluetun jednocześnie**. Każda instancja wyświetla się jako osobny pulpit nawigacyjny w responsywnej siatce.

**Konfiguracja**: Użyj numerowanych zmiennych środowiskowych:

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

**Obsługiwane**: Do 20 instancji (przez `GLUETUN_1_URL` do `GLUETUN_20_URL`)  
**Responsywne**: 1 pełna szerokość pulpitu → 2 połówkowe szerokości → 3 na jedną trzecią szerokości → 4 na jedną czwartą szerokości → przewijane przy 5+

### Wsteczna kompatybilność

Jeśli nie skonfigurowano zmiennych numerowanych, następuje powrót do **trybu jednej instancji (legacy)**:

```yaml
environment:
  - GLUETUN_CONTROL_URL=http://gluetun:8000  # legacy
  - GLUETUN_API_KEY=token
```

### Uwierzytelnianie per instancja

Każda instancja może mieć inne uwierzytelnianie:

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

## Konfiguracja

| Zmienna | Domyślna | Opis |
|---|---|---|
| `GLUETUN_1_*` do `GLUETUN_20_*` | _(puste)_ | **Konfiguracja wielu instancji** (do 20 instancji) |
| `GLUETUN_{N}_URL` | – | URL serwera kontroli HTTP Gluetun dla instancji N |
| `GLUETUN_{N}_NAME` | `Instancja {N}` | Nazwa wyświetlana dla instancji N |
| `GLUETUN_{N}_API_KEY` | _(puste)_ | Token Bearer dla instancji N (jeśli uwierzytelnianie włączone) |
| `GLUETUN_{N}_USER` | _(puste)_ | Nazwa użytkownika dla HTTP Basic auth (instancja N) |
| `GLUETUN_{N}_PASSWORD` | _(puste)_ | Hasło dla HTTP Basic auth (instancja N) |
| `GLUETUN_CONTROL_URL` | `http://gluetun:8000` | **Legacy** – tylko pojedyncza instancja (zapas, jeśli brak zmiennych `GLUETUN_1_*`) |
| `GLUETUN_API_KEY` | _(puste)_ | **Legacy** – Token Bearer dla pojedynczej instancji |
| `GLUETUN_USER` | _(puste)_ | **Legacy** – Nazwa użytkownika dla HTTP Basic auth |
| `GLUETUN_PASSWORD` | _(puste)_ | **Legacy** – Hasło dla HTTP Basic auth |
| `PORT` | `3000` | Port, na którym nasłuchuje interfejs WWW |
| `TRUST_PROXY` | `false` | Ustaw na `true`, jeśli działa za reverse proxy (nginx, Traefik, itp.) |

---

## Bezpieczeństwo

- Port jest powiązany z `127.0.0.1` — nie jest wystawiony do sieci
- Kontener działa jako non-root z systemem plików tylko do odczytu i ograniczonymi uprawnieniami
- Ograniczanie liczby żądań na wszystkich trasach API
- Szczegóły błędów upstream logowane tylko po stronie serwera — do przeglądarki zwracane ogólne komunikaty

### Konfiguracja reverse-proxy

Jeśli uruchamiasz gluetun-webui za reverse proxy (nginx, Traefik, Caddy, itp.), ustaw `TRUST_PROXY=true` w swoich zmiennych środowiskowych:


```yaml
gluetun-webui:
  image: scuzza/gluetun-webui:latest
  environment:
    - GLUETUN_CONTROL_URL=http://gluetun:8000
    - TRUST_PROXY=true  # Required for reverse proxies
```

To umożliwia aplikacji poprawne analizowanie nagłówków `X-Forwarded-For` i pokrewnych w celu dokładnego ograniczania liczby żądań oraz wykrywania adresów IP. **Uwaga:** Włączaj tę opcję tylko, jeśli faktycznie korzystasz z odwrotnego serwera proxy, ponieważ ufa ona nagłówkom proxy od Twojego serwera pośredniczącego.

### Uwierzytelnianie reverse-proxy

Kontrolki uruchamiania/zatrzymywania VPN nie mają wbudowanego uwierzytelniania. Jeśli udostępniasz interfejs użytkownika poza localhost, umieść go za odwrotnym proxy z HTTP Basic auth.

**Caddy** (`Caddyfile`):
```
your.domain.com {
  basicauth {
    user $2a$14$<bcrypt-hash>
  }
  reverse_proxy localhost:3000
}
```
Wygeneruj hash za pomocą: `caddy hash-password`

**Nginx** (`nginx.conf`):
```nginx
location / {
  auth_basic "Restricted";
  auth_basic_user_file /etc/nginx/.htpasswd;
  proxy_pass http://localhost:3000;
}
```
Wygeneruj plik z hasłami poleceniem: `htpasswd -c /etc/nginx/.htpasswd user`

**Traefik** (etykiety Dockera):
```yaml
labels:
  - "traefik.enable=true"
  - "traefik.http.routers.gluetun-webui.rule=Host(`your.domain.com`)"
  - "traefik.http.routers.gluetun-webui.middlewares=auth"
  - "traefik.http.middlewares.auth.basicauth.users=user:$$apr1$$<hash>"
```
Wygeneruj hash za pomocą: `htpasswd -nb user password`

---

## Podziękowania

- **[Gluetun](https://github.com/qdm12/gluetun)** — Kontener klienta VPN, dla którego zbudowano ten interfejs webowy
- **[gluetun-monitor](https://github.com/csmarshall/gluetun-monitor)** — Świetne narzędzie monitorujące do współpracy z tym interfejsem webowym
- **Rozwój wspomagany AI** — Ten projekt powstał przy wsparciu sztucznej inteligencji

---

## Licencja

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-29

---
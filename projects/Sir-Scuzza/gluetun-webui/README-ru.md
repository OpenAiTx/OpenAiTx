
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
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

Лёгкий веб-интерфейс для мониторинга и управления [Gluetun](https://github.com/qdm12/gluetun) — контейнером VPN-клиента для Docker.

![Статус: Подключено](https://img.shields.io/badge/status-connected-brightgreen)
![Node 25](https://img.shields.io/badge/node-25--alpine-blue)
![Docker](https://img.shields.io/badge/docker-compose-blue)

---

## Возможности

- ✨ **Мульти-VPN поддержка** — Мониторинг и управление до 20 экземплярами Gluetun одновременно
- Живой баннер статуса VPN (подключен / приостановлен / отключен)
- Публичный выходной IP, страна, регион, город и организация
- Провайдер VPN, протокол (WireGuard / OpenVPN), детали сервера
- Статус перенаправления портов и DNS
- Управление запуском / остановкой VPN
- Автообновление с настраиваемым интервалом (5с – 60с)
- Последние 30 опросов с цветовой индикацией в истории
- Адаптивный дизайн (мобильные, планшеты, десктоп)

---

## Скриншоты
![alt text](https://raw.githubusercontent.com/Sir-Scuzza/gluetun-webui/main/image-1.png)

---

## Требования

- Docker + Docker Compose
- Gluetun с включённым HTTP сервером управления (порт по умолчанию `8000`)
- Gluetun и gluetun-webui в одной Docker-сети

> Поддерживает `linux/amd64` и `linux/arm64` (работает на Mac Intel/Apple Silicon, Linux и Windows).

---

## Быстрый старт

### Вариант A1: Один экземпляр (рекомендуется)

Добавьте `gluetun-webui` в ваш существующий compose-файл рядом с Gluetun:

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

### Вариант A2: Несколько экземпляров

Отслеживайте 2 и более экземпляров Gluetun с отдельными дашбордами:

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

### Вариант B: Локальная сборка

```bash
git clone https://github.com/Sir-Scuzza/gluetun-webui.git
cd gluetun-webui
docker compose up -d --build
```

Затем выполните (любой из вариантов):

```bash
docker compose up -d
```

Пользовательский интерфейс доступен по адресу **http://localhost:3000**

---

## Настройка сети

И Gluetun, и gluetun-webui должны находиться в одной Docker-сети, чтобы `http://gluetun:8000` корректно разрешался.

**Один и тот же compose-файл** — просто добавьте оба сервиса в одну сеть (наиболее распространённый вариант):

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

**Отдельные файлы compose** — используйте существующую сеть Gluetun как внешнюю. Найдите имя вашей сети с помощью `docker network ls`:

```yaml
networks:
  ext-network:
    external: true
    name: your_gluetun_network_name
```

---

## Поддержка нескольких VPN

### Несколько экземпляров

gluetun-webui поддерживает мониторинг и управление **несколькими экземплярами Gluetun одновременно**. Каждый экземпляр отображается как отдельная панель управления в адаптивной сетке.

**Конфигурация**: Используйте пронумерованные переменные окружения:

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

**Поддерживается**: До 20 экземпляров (через `GLUETUN_1_URL` до `GLUETUN_20_URL`)  
**Адаптивность**: 1 панель на всю ширину → 2 на половину ширины → 3 на треть ширины → 4 на четверть ширины → прокрутка при 5+

### Обратная совместимость

Если ни одна из пронумерованных переменных не настроена, происходит возврат к **устаревшему одн экземпляру**:

```yaml
environment:
  - GLUETUN_CONTROL_URL=http://gluetun:8000  # legacy
  - GLUETUN_API_KEY=token
```

### Аутентификация для каждого экземпляра

Каждый экземпляр может иметь разную аутентификацию:

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

## Конфигурация

| Переменная | По умолчанию | Описание |
|---|---|---|
| `GLUETUN_1_*` до `GLUETUN_20_*` | _(пусто)_ | **Конфигурация нескольких экземпляров** (до 20 экземпляров) |
| `GLUETUN_{N}_URL` | – | URL HTTP-контрольного сервера Gluetun для экземпляра N |
| `GLUETUN_{N}_NAME` | `Экземпляр {N}` | Отображаемое имя для экземпляра N |
| `GLUETUN_{N}_API_KEY` | _(пусто)_ | Bearer-токен для экземпляра N (если включена авторизация) |
| `GLUETUN_{N}_USER` | _(пусто)_ | Имя пользователя для HTTP Basic авторизации (экземпляр N) |
| `GLUETUN_{N}_PASSWORD` | _(пусто)_ | Пароль для HTTP Basic авторизации (экземпляр N) |
| `GLUETUN_CONTROL_URL` | `http://gluetun:8000` | **Устарело** – только для одного экземпляра (резерв, если нет переменных `GLUETUN_1_*`) |
| `GLUETUN_API_KEY` | _(пусто)_ | **Устарело** – Bearer-токен для одного экземпляра |
| `GLUETUN_USER` | _(пусто)_ | **Устарело** – имя пользователя для HTTP Basic авторизации |
| `GLUETUN_PASSWORD` | _(пусто)_ | **Устарело** – пароль для HTTP Basic авторизации |
| `PORT` | `3000` | Порт, на котором слушает веб-интерфейс |
| `TRUST_PROXY` | `false` | Установите в `true`, если работаете за обратным прокси (nginx, Traefik и т.д.) |

---

## Безопасность

- Порт привязан к `127.0.0.1` — не доступен из сети
- Контейнер работает не от root, с файловой системой только для чтения и урезанными правами
- На все маршруты API применяется ограничение по частоте запросов
- Детали ошибок от upstream логируются только на сервере — браузеру возвращаются общие сообщения

### Конфигурация обратного прокси

Если вы запускаете gluetun-webui за обратным прокси (nginx, Traefik, Caddy и др.), установите `TRUST_PROXY=true` в ваших переменных окружения:

```yaml
gluetun-webui:
  image: scuzza/gluetun-webui:latest
  environment:
    - GLUETUN_CONTROL_URL=http://gluetun:8000
    - TRUST_PROXY=true  # Required for reverse proxies
```

Это позволяет приложению правильно разбирать заголовки `X-Forwarded-For` и связанные с ними для точного ограничения скорости и определения IP. **Примечание:** Включайте это только если вы действительно находитесь за обратным прокси, так как приложение доверяет прокси-заголовкам вашего обратного прокси.

### Аутентификация обратного прокси

Элементы управления запуском/остановкой VPN не имеют встроенной аутентификации. Если вы открываете интерфейс за пределами localhost, разместите его за обратным прокси с HTTP Basic аутентификацией.

**Caddy** (`Caddyfile`):
```
your.domain.com {
  basicauth {
    user $2a$14$<bcrypt-hash>
  }
  reverse_proxy localhost:3000
}
```
Сгенерируйте хеш с помощью: `caddy hash-password`

**Nginx** (`nginx.conf`):
```nginx
location / {
  auth_basic "Restricted";
  auth_basic_user_file /etc/nginx/.htpasswd;
  proxy_pass http://localhost:3000;
}
```
Создайте файл паролей с помощью: `htpasswd -c /etc/nginx/.htpasswd user`

**Traefik** (Docker метки):
```yaml
labels:
  - "traefik.enable=true"
  - "traefik.http.routers.gluetun-webui.rule=Host(`your.domain.com`)"
  - "traefik.http.routers.gluetun-webui.middlewares=auth"
  - "traefik.http.middlewares.auth.basicauth.users=user:$$apr1$$<hash>"
```
Сгенерируйте хеш с помощью: `htpasswd -nb user password`

---

## Благодарности

- **[Gluetun](https://github.com/qdm12/gluetun)** — Контейнер VPN-клиента, для которого был создан этот webui
- **[gluetun-monitor](https://github.com/csmarshall/gluetun-monitor)** — Отличный инструмент мониторинга для использования с этим webui
- **Разработка с помощью ИИ** — Этот проект был создан с помощью искусственного интеллекта

---

## Лицензия

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-29

---
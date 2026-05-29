
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=zh-CN">簡體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=ko">韓國語</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=hi">印地語</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=th">泰語</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=fr">法語</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=de">德語</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=es">西班牙語</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=it">義大利語</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=ru">俄語</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=pt">葡萄牙語</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=nl">荷蘭語</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=pl">波蘭語</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=ar">阿拉伯語</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=fa">波斯語</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=tr">土耳其語</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=vi">越南語</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=id">印尼語</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=as">阿薩姆語</
      </div>
    </div>
  </details>
</div>

# Gluetun WebUI

一個輕量級網頁界面，用於監控和控制 [Gluetun](https://github.com/qdm12/gluetun) — Docker 的 VPN 客戶端容器。

![狀態：已連線](https://img.shields.io/badge/status-connected-brightgreen)
![節點 25](https://img.shields.io/badge/node-25--alpine-blue)
![Docker](https://img.shields.io/badge/docker-compose-blue)

---

## 功能特色

- ✨ **多重VPN支援** — 可同時監控與控制多達20個Gluetun實例
- 即時VPN狀態橫幅（已連線 / 已暫停 / 已斷線）
- 公網出口IP、國家、地區、城市與組織
- VPN供應商、協議（WireGuard / OpenVPN）、伺服器詳細資訊
- 端口轉發與DNS狀態
- 啟動 / 停止VPN控制
- 可設定自動刷新間隔（5秒–60秒）
- 歷史條顯示最近30次輪詢狀態（顏色區分）
- 響應式設計（手機、平板、桌機）

---

## 螢幕截圖
![alt text](https://raw.githubusercontent.com/Sir-Scuzza/gluetun-webui/main/image-1.png)

---

## 系統需求

- Docker + Docker Compose
- 已啟用HTTP控制伺服器的Gluetun（預設端口 `8000`）
- Gluetun與gluetun-webui需在同一Docker網路下

> 支援 `linux/amd64` 與 `linux/arm64`（可於Mac Intel/Apple Silicon、Linux與Windows運行）。

---

## 快速開始

### 選項A1：單一實例（推薦）

在您的現有compose檔案中加入 `gluetun-webui` 與Gluetun併用：

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

### 選項 A2：多重實例

監控 2 個以上的 Gluetun 實例，並分別設置儀表板：

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

### 選項 B：在本地建置

```bash
git clone https://github.com/Sir-Scuzza/gluetun-webui.git
cd gluetun-webui
docker compose up -d --build
```

然後執行（任一選項）：

```bash
docker compose up -d
```

UI 可於 **http://localhost:3000** 存取

---

## 網路設定

Gluetun 和 gluetun-webui 必須在相同的 Docker 網路上，這樣 `http://gluetun:8000` 才能正確解析。

**同一個 compose 檔案** — 只需將兩個服務加到同一個網路（最常見的做法）：

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

**單獨的 compose 檔案** — 將 Gluetun 現有的網路作為 external 引用。使用 `docker network ls` 查找您的網路名稱：

```yaml
networks:
  ext-network:
    external: true
    name: your_gluetun_network_name
```

---

## 多重 VPN 支援

### 多個實例

gluetun-webui 支援同時監控和控制**多個 Gluetun 實例**。每個實例會在響應式網格中以獨立儀表板顯示。

**設定**：使用編號的環境變數：

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

**支援**：最多可達 20 個實例（透過 `GLUETUN_1_URL` 至 `GLUETUN_20_URL`）  
**響應式**：1 個全寬儀表板 → 2 個半寬 → 3 個三分之一寬 → 4 個四分之一寬 → 5 個以上可捲動顯示

### 向下相容性

若未設定任何編號變數，則會回退至**舊版單一實例模式**：

```yaml
environment:
  - GLUETUN_CONTROL_URL=http://gluetun:8000  # legacy
  - GLUETUN_API_KEY=token
```

### 每個實例的驗證

每個實例都可以有不同的驗證：

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

## 設定

| 變數 | 預設值 | 說明 |
|---|---|---|
| `GLUETUN_1_*` 到 `GLUETUN_20_*` | _(空)_ | **多重實例設定**（最多 20 個實例） |
| `GLUETUN_{N}_URL` | – | 實例 N 的 Gluetun HTTP 控制伺服器 URL |
| `GLUETUN_{N}_NAME` | `Instance {N}` | 實例 N 的顯示名稱 |
| `GLUETUN_{N}_API_KEY` | _(空)_ | 實例 N 的 Bearer token（若啟用驗證） |
| `GLUETUN_{N}_USER` | _(空)_ | HTTP Basic 驗證的使用者名稱（實例 N） |
| `GLUETUN_{N}_PASSWORD` | _(空)_ | HTTP Basic 驗證的密碼（實例 N） |
| `GLUETUN_CONTROL_URL` | `http://gluetun:8000` | **舊版** — 僅限單一實例（若無 `GLUETUN_1_*` 變數則作為後備） |
| `GLUETUN_API_KEY` | _(空)_ | **舊版** — 單一實例的 Bearer token |
| `GLUETUN_USER` | _(空)_ | **舊版** — HTTP Basic 驗證的使用者名稱 |
| `GLUETUN_PASSWORD` | _(空)_ | **舊版** — HTTP Basic 驗證的密碼 |
| `PORT` | `3000` | 網頁 UI 監聽的埠號 |
| `TRUST_PROXY` | `false` | 如果在反向代理（nginx、Traefik 等）後運行請設為 `true` |

---

## 安全性

- 埠口綁定於 `127.0.0.1` — 不對外網路開放
- 容器以非 root 身份運行，且檔案系統為唯讀並移除部分權限
- 所有 API 路徑均有速率限制
- 上游錯誤詳細資訊僅記錄於伺服器端 — 瀏覽器僅收到通用訊息

### 反向代理設定

如果你在反向代理（nginx、Traefik、Caddy 等）後運行 gluetun-webui，請在環境變數中設為 `TRUST_PROXY=true`：


```yaml
gluetun-webui:
  image: scuzza/gluetun-webui:latest
  environment:
    - GLUETUN_CONTROL_URL=http://gluetun:8000
    - TRUST_PROXY=true  # Required for reverse proxies
```

這讓應用程式能夠正確解析 `X-Forwarded-For` 及相關標頭，以進行準確的流量限制和 IP 偵測。**注意：**只有在你確實位於反向代理之後才啟用此功能，因為它會信任來自反向代理的標頭。

### 反向代理驗證

VPN 啟動/停止控制沒有內建認證功能。如果你將 UI 曝露在 localhost 之外，請將其置於帶有 HTTP 基本驗證的反向代理後方。

**Caddy** (`Caddyfile`):
```
your.domain.com {
  basicauth {
    user $2a$14$<bcrypt-hash>
  }
  reverse_proxy localhost:3000
}
```
產生雜湊值：`caddy hash-password`

**Nginx**（`nginx.conf`）：
```nginx
location / {
  auth_basic "Restricted";
  auth_basic_user_file /etc/nginx/.htpasswd;
  proxy_pass http://localhost:3000;
}
```
產生密碼檔案：`htpasswd -c /etc/nginx/.htpasswd user`

**Traefik**（Docker 標籤）：
```yaml
labels:
  - "traefik.enable=true"
  - "traefik.http.routers.gluetun-webui.rule=Host(`your.domain.com`)"
  - "traefik.http.routers.gluetun-webui.middlewares=auth"
  - "traefik.http.middlewares.auth.basicauth.users=user:$$apr1$$<hash>"
```
產生雜湊：`htpasswd -nb user password`

---

## 致謝

- **[Gluetun](https://github.com/qdm12/gluetun)** — 本 webui 所建立的 VPN 用戶端容器
- **[gluetun-monitor](https://github.com/csmarshall/gluetun-monitor)** — 與本 webui 搭配使用的優秀監控工具
- **AI 協助開發** — 本專案在 AI 協助下建構

---

## 授權

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-29

---
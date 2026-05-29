
<div align="right">
  <details>
    <summary >🌐 语言</summary>
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

一个轻量级 Web UI，用于监控和控制 [Gluetun](https://github.com/qdm12/gluetun) —— 用于 Docker 的 VPN 客户端容器。

![状态：已连接](https://img.shields.io/badge/status-connected-brightgreen)
![节点 25](https://img.shields.io/badge/node-25--alpine-blue)
![Docker](https://img.shields.io/badge/docker-compose-blue)

---

## 功能

- ✨ **多VPN支持** — 同时监控和控制最多20个Gluetun实例
- 实时VPN状态横幅（已连接 / 暂停 / 已断开）
- 公共出口IP、国家、地区、城市和组织信息
- VPN提供商、协议（WireGuard / OpenVPN）、服务器详情
- 端口转发和DNS状态
- 启动 / 停止VPN控制
- 自动刷新，可配置间隔（5秒 – 60秒）
- 最近30次轮询历史条按颜色编码
- 响应式设计（移动端、平板、桌面端）

---

## 截图
![alt text](https://raw.githubusercontent.com/Sir-Scuzza/gluetun-webui/main/image-1.png)

---

## 要求

- Docker + Docker Compose
- Gluetun运行并启用其HTTP控制服务器（默认端口 `8000`）
- Gluetun和gluetun-webui必须在同一Docker网络下

> 支持 `linux/amd64` 和 `linux/arm64`（兼容Mac Intel/Apple Silicon、Linux和Windows）。

---

## 快速开始

### 选项A1：单实例（推荐）

在你的现有compose文件中添加`gluetun-webui`，与Gluetun一起运行：

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

### 选项 A2：多个实例

通过独立的仪表板监控 2 个以上 Gluetun 实例：

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

### 选项 B：本地构建

```bash
git clone https://github.com/Sir-Scuzza/gluetun-webui.git
cd gluetun-webui
docker compose up -d --build
```

然后运行（任一选项）：

```bash
docker compose up -d
```

UI 可通过 **http://localhost:3000** 访问

---

## 网络设置

Gluetun 和 gluetun-webui 必须在同一 Docker 网络中，以确保 `http://gluetun:8000` 能正确解析。

**相同的 compose 文件** — 只需将两个服务添加到同一网络（最常见）：

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

**分离的 compose 文件** — 将 Gluetun 现有网络作为外部网络引用。使用 `docker network ls` 查找您的网络名称：

```yaml
networks:
  ext-network:
    external: true
    name: your_gluetun_network_name
```

---

## 多重 VPN 支持

### 多实例

gluetun-webui 支持同时监控和控制**多个 Gluetun 实例**。每个实例以响应式网格中的独立仪表盘显示。

**配置**：使用编号环境变量：

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

**支持**：最多20个实例（通过 `GLUETUN_1_URL` 到 `GLUETUN_20_URL`）  
**响应式**：1 个全宽仪表盘 → 2 个半宽 → 3 个三分之一宽 → 4 个四分之一宽 → 5个以上可滚动

### 向后兼容性

如果未配置编号变量，则回退到**传统单实例模式**：

```yaml
environment:
  - GLUETUN_CONTROL_URL=http://gluetun:8000  # legacy
  - GLUETUN_API_KEY=token
```

### 每个实例的认证

每个实例可以有不同的认证：

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

## 配置

| 变量 | 默认值 | 描述 |
|---|---|---|
| `GLUETUN_1_*` 到 `GLUETUN_20_*` | _(空)_ | **多实例配置**（最多20个实例） |
| `GLUETUN_{N}_URL` | – | 实例 N 的 Gluetun HTTP 控制服务器 URL |
| `GLUETUN_{N}_NAME` | `Instance {N}` | 实例 N 的显示名称 |
| `GLUETUN_{N}_API_KEY` | _(空)_ | 实例 N 的 Bearer 令牌（如果启用认证） |
| `GLUETUN_{N}_USER` | _(空)_ | 实例 N 的 HTTP 基本认证用户名 |
| `GLUETUN_{N}_PASSWORD` | _(空)_ | 实例 N 的 HTTP 基本认证密码 |
| `GLUETUN_CONTROL_URL` | `http://gluetun:8000` | **旧版** – 仅单实例（如果没有 `GLUETUN_1_*` 变量则回退） |
| `GLUETUN_API_KEY` | _(空)_ | **旧版** – 单实例的 Bearer 令牌 |
| `GLUETUN_USER` | _(空)_ | **旧版** – HTTP 基本认证用户名 |
| `GLUETUN_PASSWORD` | _(空)_ | **旧版** – HTTP 基本认证密码 |
| `PORT` | `3000` | Web UI 监听的端口 |
| `TRUST_PROXY` | `false` | 如果运行在反向代理（nginx、Traefik 等）后面，设为 `true` |

---

## 安全性

- 端口绑定到 `127.0.0.1` — 不对网络暴露
- 容器以非 root 用户运行，文件系统只读，并移除多余权限
- 对所有 API 路由应用速率限制
- 上游错误详情仅记录在服务器端 — 浏览器返回通用消息

### 反向代理配置

如果你在反向代理（nginx、Traefik、Caddy 等）后运行 gluetun-webui，请在环境变量中设置 `TRUST_PROXY=true`：

```yaml
gluetun-webui:
  image: scuzza/gluetun-webui:latest
  environment:
    - GLUETUN_CONTROL_URL=http://gluetun:8000
    - TRUST_PROXY=true  # Required for reverse proxies
```
这允许应用程序正确解析 `X-Forwarded-For` 及相关头信息，以实现准确的速率限制和 IP 识别。**注意：** 仅当您确实位于反向代理之后时才启用此功能，因为它信任来自您反向代理的代理头。

### 反向代理认证

VPN 启动/停止控制没有内置认证。如果您将 UI 暴露到本地主机以外，请将其置于带有 HTTP 基本认证的反向代理后面。

**Caddy**（`Caddyfile`）：

```
your.domain.com {
  basicauth {
    user $2a$14$<bcrypt-hash>
  }
  reverse_proxy localhost:3000
}
```
使用命令生成哈希：`caddy hash-password`

**Nginx** (`nginx.conf`)：
```nginx
location / {
  auth_basic "Restricted";
  auth_basic_user_file /etc/nginx/.htpasswd;
  proxy_pass http://localhost:3000;
}
```
使用以下命令生成密码文件：`htpasswd -c /etc/nginx/.htpasswd user`

**Traefik**（Docker 标签）：
```yaml
labels:
  - "traefik.enable=true"
  - "traefik.http.routers.gluetun-webui.rule=Host(`your.domain.com`)"
  - "traefik.http.routers.gluetun-webui.middlewares=auth"
  - "traefik.http.middlewares.auth.basicauth.users=user:$$apr1$$<hash>"
```
生成哈希：`htpasswd -nb user password`

---

## 致谢

- **[Gluetun](https://github.com/qdm12/gluetun)** — 此 Web UI 所针对的 VPN 客户端容器  
- **[gluetun-monitor](https://github.com/csmarshall/gluetun-monitor)** — 与此 Web UI 配套的优秀监控工具  
- **AI 辅助开发** — 本项目在 AI 辅助下构建

---

## 许可证

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-29

---
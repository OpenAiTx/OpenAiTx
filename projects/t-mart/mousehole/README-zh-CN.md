# Mousehole，MAM 的 Seedbox IP 更新器

一个后台服务，用于更新 MAM 的 seedbox IP，并提供一个 HTTP 服务器来管理该服务。

![Mousehole 演示](https://raw.githubusercontent.com/t-mart/mousehole/master/docs/images/demo.webp)

如果您使用主机/VPN/seedbox 进行种子上传且其 IP 地址不稳定，这将非常有用。

功能：

- 后台服务，定期使用主机的 IP 地址更新 MAM。

  在更新之前，Mousehole 通过比较主机当前的 IP 地址和 AS 与上次 MAM 响应，检查是否确实需要更新。

- 前端网站管理服务，允许：

  - 设置您的 MAM Cookie
  - 显示状态信息
  - 手动触发检查

- 带有管理端点的 API 服务器。

  详情见 [API.md](https://github.com/t-mart/mousehole/blob/master/docs/API.md)。

## 快速开始

使用 Mousehole，您需要：

1. [运行服务](#running-the-service)
2. [通过网页界面设置您的 MAM Cookie](#setting-your-mam-cookie)
3. [处理 MAM 错误](#handling-errors)（如果有）

### 运行服务

#### Docker Compose（推荐）





```yaml
services:
  gluetun:
    image: qmcgaw/gluetun:latest
    cap_add:
      - NET_ADMIN
    devices:
      - /dev/net/tun:/dev/net/tun
    ports:
      - "5010:5010" # Mousehole port
      - "8080:8080" # qBittorrent Web UI port
      - "6881:6881/tcp" # qBittorrent TCP torrent port
      - "6881:6881/udp" # qBittorrent UDP torrent port
    environment:
      VPN_SERVICE_PROVIDER: "your-vpn-provider"
      FIREWALL_VPN_INPUT_PORTS: "6881" # qBittorrent torrent
      # more is needed here -- see Gluetun documentation
      # https://github.com/qdm12/gluetun-wiki
      # https://github.com/qdm12/gluetun-wiki/tree/main/setup/providers
    restart: unless-stopped

  qbittorrent:
    image: lscr.io/linuxserver/qbittorrent:latest
    network_mode: "service:gluetun"
    environment:
      TZ: Etc/UTC # Set to your timezone for localization
      WEBUI_PORT: 8080
      TORRENTING_PORT: 6881
    restart: unless-stopped

  mousehole:
    image: tmmrtn/mousehole:latest
    network_mode: "service:gluetun"
    environment:
      TZ: Etc/UTC # Set to your timezone for localization
    volumes:
      # persist cookie data across container restarts
      - "mousehole:/srv/mousehole"
    restart: unless-stopped

volumes:
  mousehole:
```


入门级 Docker Compose 示例：

- ⭐ [Gluetun + qBittorrent + Mousehole](https://raw.githubusercontent.com/t-mart/mousehole/master/docs/docker-compose-examples/gluetun-qb.md)
- [Wireguard + qBittorrent + Mousehole](https://raw.githubusercontent.com/t-mart/mousehole/master/docs/docker-compose-examples/wireguard-qb.md)
- [非 VPN 示例](https://raw.githubusercontent.com/t-mart/mousehole/master/docs/docker-compose-examples/non-vpn.md)

任何 VPN 设置都可以调整为包含 Mousehole 作为 sidecar。详情请参见
[在 Docker Compose 中将 Mousehole 用作 Sidecar](https://raw.githubusercontent.com/t-mart/mousehole/master/docs/sidecars.md)。

#### Unraid

请参阅 [Unraid 安装指南](https://raw.githubusercontent.com/t-mart/mousehole/master/./contrib/unraid/README.md) 获取
安装说明。

#### 本地

运行服务器命令：


```bash
bun run start
```

### 设置您的 MAM Cookie

一旦 Mousehole 运行，使用浏览器访问其网页界面，地址为 `http://<host>:5010`。  
如果您本地运行，地址很可能是 <http://localhost:5010>。

首次运行（或 Cookie 不同步时），需要手动设置 Mousehole 的 Cookie。

访问 Mousehole 网页界面时，您会看到一个设置 Cookie 的表单 —— 粘贴您的 Cookie 后点击“Set”按钮。

![Mousehole Cookie Form](https://raw.githubusercontent.com/t-mart/mousehole/master/docs/images/cookie-form.png)

如果您需要获取 Cookie 的帮助，请点击“我该输入什么？”按钮查看教程。


### 处理错误

即使 Mousehole 已启动运行，仍有可能出现 Mousehole 无法自动修复的问题。以下是一些常见错误：

- ["无效会话 - ASN 不匹配"](https://raw.githubusercontent.com/t-mart/mousehole/master/./docs/errors/asn-mismatch.md)
- ["无效会话 - 无效的 Cookie"](https://raw.githubusercontent.com/t-mart/mousehole/master/./docs/errors/invalid-cookie.md)
- ["最近的更改过于频繁"](https://raw.githubusercontent.com/t-mart/mousehole/master/./docs/errors/last-change-too-recent.md)

## Docker 标签

Mousehole 在
[Docker Hub](https://hub.docker.com/r/tmmrtn/mousehole) 发布多个镜像标签：

- 语义版本号（`0`，`0.1`，`0.1.11` 等）
- `latest`，最新发布版本
- `edge`，`master` 分支的最新代码
- 针对 `master` 分支的拉取请求，用于测试，标记为 `pr-<number>`

如果您不知道选哪个，请选择 `latest`。






## 环境变量

- `MOUSEHOLE_PORT`：_(默认 `5010`)_ HTTP 服务器监听的端口。
- `MOUSEHOLE_STATE_DIR_PATH`：_(默认 `/srv/mousehole`)_ 服务存储数据的目录。
- `MOUSEHOLE_USER_AGENT`：_(默认 `mousehole-by-timtimtim/<version>`)_ 向 MAM 发送请求时使用的用户代理。
- `MOUSEHOLE_CHECK_INTERVAL_SECONDS`：_(默认 `300`（5分钟）)_ 检查的时间间隔，单位为秒。
- `MOUSEHOLE_STALE_RESPONSE_SECONDS`：_(默认 `86400`（1天）)_ MAM 响应被视为过时的秒数。这确保 Mousehole 以某个固定间隔与 MAM 通信，并检测对 cookie 的带外更改。
- `TZ`：_(默认 `Etc/UTC`)_ 用于显示本地化时间的时区。

## 贡献

想要贡献代码？请查看 [贡献指南](https://raw.githubusercontent.com/t-mart/mousehole/master/./CONTRIBUTING.md)。

还有一个包含有用辅助功能的 [`contrib`](./contrib/) 目录。

## 链接

- [代码仓库](https://github.com/t-mart/mousehole)
- [Docker Hub 镜像](https://hub.docker.com/r/tmmrtn/mousehole)
- [论坛帖子](https://www.myanonamouse.net/f/t/84712/p/p1013257)

## 开发

- 启动开发服务器：









  ```bash
  bun run dev
  ```

- 新版本可以通过简单地更改 `package.json` 中的版本号并推送到 GitHub 来标记、发布并推送到 Docker Hub。CI 工作流会处理剩下的工作。

## 归属

鼠洞 图标由 Sergey Demushkin 提供，来自
[Noun Project](https://thenounproject.com/term/mouse-hole/) （CC BY 3.0）




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-12

---
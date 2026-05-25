# Sing-box UI

**[English](https://raw.githubusercontent.com/SpadesA99/singbox_ui/main/README_EN.md) | 中文**

<div align="center">

[![Docker Image](https://img.shields.io/badge/ghcr.io-singbox__ui-blue?logo=docker)](https://github.com/SpadesA99/singbox_ui/pkgs/container/singbox_ui)
[![Build Status](https://github.com/SpadesA99/singbox_ui/actions/workflows/docker-build.yml/badge.svg)](https://github.com/SpadesA99/singbox_ui/actions)
[![GitHub Stars](https://img.shields.io/github/stars/SpadesA99/singbox_ui?style=flat&logo=github)](https://github.com/SpadesA99/singbox_ui/stargazers)
[![License](https://img.shields.io/github/license/SpadesA99/singbox_ui)](LICENSE)

**Modern sing-box configuration management tool**

Built on Go 1.24 + Next.js 16, managing sing-box via Docker containerization

</div>

![Sing-box UI interface screenshot](https://raw.githubusercontent.com/SpadesA99/singbox_ui/main/docs/zh.png)

---

## Core Features

### Protocol Support

| Inbound Protocol | Outbound Protocol | Subscription Parsing |
|---------|---------|---------|
| WireGuard | All inbound protocols | VMess |
| Mixed (Socks5+HTTP) | direct | VLESS |
| VLESS | block | Trojan |
| VMess | | Shadowsocks |
| Trojan | | AnyTLS |
| Shadowsocks | | Clash YAML format |
| Hysteria2 | | |
| TUIC | | |
| Naive | | |
| ShadowTLS | | |
| AnyTLS | | |
| HTTP | | |

### TLS Certificate Management

- **ACME Automatic Certificates**: Supports automatic application and renewal with Let's Encrypt  
- **Manual Certificates**: Supports uploading your own certificate files  
- **Multi-Protocol Support**: VLESS, VMess, Trojan, Hysteria2, and other TLS protocols all support ACME  

### Routing Rule Configuration

- **Quick Templates**: One-click enable commonly used rules (ad blocking, direct connection for China IP/domains, direct connection for private IPs)  
- **Quick Rule Addition**: Supports quickly adding IPs or domains to direct/proxy/block lists  
- **Direct Connection Mode**: Automatically configured to direct connection mode when no proxy outbound is used  

### Load Balancing

- **URLTest Mode**: Based on sing-box `urltest` outbound, automatically selects the lowest latency node  
- **Configurable Tolerance**: Customizable latency tolerance value (default 50ms) to avoid frequent switching  
- **Dynamic Node Pool**: Flexibly selects multiple nodes from subscriptions to form load balancing groups  
- **Smart Routing**: Automatically generates routing rules for intelligent traffic distribution  

### Multi-Instance Management

- Supports creating multiple named sing-box instances  
- Each instance has independent configuration, start, and stop controls  
- Independent container logs and status monitoring  

### WireGuard VPN Management

- Curve25519 key generation  
- IP-bound key caching  
- Client configuration management (batch generation, QR codes, configuration downloads)  

### Cloudflare WARP Outbound

- **One-Click Registration**: Automatically generates Curve25519 key pairs and calls Cloudflare registration API, caches device token locally, no manual configuration needed  
- **WARP+ Binding**: Supports inputting License to bind WARP+ account for unlimited traffic  
- **Endpoint Optimization**: Real WireGuard handshake probing—sends WG init packet to candidate `IP:Port`, verifies returned 92-byte `MessageResponse`, sorts by packet loss rate + average RTT, accurately reflects UDP path quality (refer to [CloudflareWarpSpeedTest](https://github.com/peanut996/CloudflareWarpSpeedTest) implementation)  
- **Wide Coverage Scanning**: Concurrent probing and randomized sampling of 8 Cloudflare /24 segments × 54 known WARP UDP ports, quickly finds the fastest edge nodes  

### Node Health Probing

- Asynchronous multi-node concurrent probing
- Success rate sliding window statistics
- API polling to obtain probe results

### Management Features

- Configuration preview (JSON editor)
- Container log viewing
- Container status monitoring

---

## Quick Start

### Docker Compose (Recommended)

Create `docker-compose.yml`:

```yaml
services:
  singbox-ui:
    image: ghcr.io/spadesa99/singbox_ui:latest
    container_name: singbox-ui
    restart: unless-stopped
    network_mode: host
    volumes:
      - /var/run/docker.sock:/var/run/docker.sock
      - ./data:/home/data
    environment:
      - DATA_DIR=/home/data
      - HOST_DATA_DIR=${PWD}/data
      - LISTEN_ADDR=127.0.0.1:7000
      - TZ=Asia/Shanghai
```

```bash
docker compose up -d
```

Access http://127.0.0.1:7000

> **Note**:
> - Use `network_mode: host` so the container directly uses the host network
> - By default, listens on `127.0.0.1:7000`, local access only, customizable via the `LISTEN_ADDR` environment variable
> - Mount the Docker Socket for managing sing-box containers
> - `HOST_DATA_DIR` is automatically mapped to the host data directory via `${PWD}`, used for sing-box container mounting
> - Built-in sing-box v1.13.5 image, automatically loaded on first start, no network pulling required

### Remote Access

The service listens on `127.0.0.1` by default; it is recommended to access securely via an SSH tunnel:

```bash
ssh -L 7000:127.0.0.1:7000 user@your-server
```
Then access http://127.0.0.1:7000 in the local browser

> **Security Tip**: It is not recommended to change `LISTEN_ADDR` to `0.0.0.0:7000` to expose directly to the public network, as the management panel has no authentication protection. For external access, please use an SSH tunnel or configure an authenticated reverse proxy (such as Nginx + Basic Auth).

---

## Environment Variables

| Variable | Description | Default Value |
|------|------|--------|
| `DATA_DIR` | Data directory inside the container | `/home/data` |
| `HOST_DATA_DIR` | Host machine data directory (for mounting in sing-box container) | `${PWD}/data` |
| `LISTEN_ADDR` | Service listening address | `127.0.0.1:7000` |
| `TZ` | Time zone | `Asia/Shanghai` |

---

## Technology Stack

| Frontend | Backend |
|------|------|
| Next.js 16 | Go 1.24 |
| React 19 | Gin 1.11 |
| Tailwind CSS | Docker SDK |
| shadcn/ui | |

---

## License

[MIT License](LICENSE)

## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=SpadesA99/singbox_ui&type=Date)](https://star-history.com/#SpadesA99/singbox_ui&Date)

## Acknowledgements

- [sing-box](https://github.com/SagerNet/sing-box)

- [Next.js](https://nextjs.org/)
- [Gin](https://github.com/gin-gonic/gin)
- [shadcn/ui](https://ui.shadcn.com/)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-25

---
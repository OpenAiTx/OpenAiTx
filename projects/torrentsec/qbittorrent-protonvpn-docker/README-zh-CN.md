# 🏰️ qBittorrent + ProtonVPN（WireGuard）在 Docker（macOS）

**使用 Gluetun 在 Docker 中安全运行 qBittorrent 和 ProtonVPN（WireGuard），确保全 VPN 路由和自动端口转发，以提升种子下载性能。**

&#x20;

---

## 📌 目录

1. [概述](#overview)
2. [功能](#features)
3. [前提条件](#prerequisites)
4. [安装指南](#installation-guide)
   - [安装 Docker](#install-docker)
   - [克隆仓库](#clone-the-repository)
   - [设置](#set-up-the-env-file)[`.env`](#set-up-the-env-file)[ 文件](#set-up-the-env-file)
   - [配置认证](#configure-authentication)
   - [启动容器](#start-the-containers)
5. [访问 qBittorrent Web UI](#accessing-qbittorrent-web-ui)
6. [安全性与最佳实践](#security--best-practices)
7. [故障排除](#troubleshooting)
8. [许可证](#license)
9. [贡献](#contributing)
10. [支持与反馈](#support--feedback)

---

## 🔹 概述

此配置确保 **qBittorrent 仅通过 ProtonVPN（WireGuard）** 使用 **Gluetun** 连接，防止泄漏并增强安全性。\
同时 **自动端口转发** 以提升种子下载速度，且 **所有服务均运行于 Docker 中**，便于管理。

---

## ✅ 功能

- **🔒 VPN 强制种子下载** – 无泄漏，所有流量均在 VPN 内运行。
- **⚡ 自动端口转发** – 确保更快速度和更佳的节点连接。
- **🌐 本地 Web UI 访问** – 通过 [`http://localhost:8080`](http://localhost:8080) 轻松控制种子。
- **📺 完全容器化** – 使用 Docker 实现轻松部署、更新和隔离。  
- **🔄 弹性设置** – 容器在崩溃时会**自动重启**。  
- 使用**独立存储**分别保存未完成和已完成的种子文件。  
- **使用 Watchtower 自动更新容器** 🛠️  

---  

## 🛠️ 先决条件  

- **Docker Desktop**（macOS/Windows/Linux）  
- **Docker Compose**（随 Docker Desktop 一起提供）  
- **ProtonVPN 账户**（支持 WireGuard 需 Plus 或 Visionary 计划）  

---  

## 📂 安装指南  

### **1️⃣ 安装 Docker**  

从[这里](https://www.docker.com/products/docker-desktop/)下载并安装 **Docker Desktop**。  
确保 Docker **正在运行** 后再继续。  

---  

### **2️⃣ 克隆仓库**  

```sh
git clone https://github.com/torrentsec/qbittorrent-protonvpn-docker.git
cd qbittorrent-protonvpn-docker
```

---

### **3️⃣ 设置 **`.env`** 文件**

该项目使用 `.env` 文件来存储**敏感的配置值**（出于安全考虑，Git 会忽略该文件）。

#### **创建你的 **`.env`** 文件**

```sh
cp .env.example .env
nano .env
```

#### **填写以下变量**

```ini
WIREGUARD_PRIVATE_KEY=your_private_key_here
SERVER_COUNTRIES="United Kingdom"
SERVER_CITIES="London"

PUID=1000
PGID=1000
TZ=Europe/London

GLUETUN_USER=your_admin_username
GLUETUN_PASS=your_admin_password

GSP_GTN_API_KEY=your_random_api_key_here
GSP_QBITTORRENT_PORT=your_forwarded_port_here
```

Save and close (`CTRL + X`, then `Y`, then `ENTER`).

---

### **4️⃣ Start the Containers**

```sh
docker-compose up -d
```

🚀 **qBittorrent 现已通过 ProtonVPN 安全运行！**

---

## 📚 访问 qBittorrent Web UI

启动后，打开：\
📌 [**http://localhost:8080**](http://localhost:8080)\
*(默认用户名：admin，密码：请查看控制台获取临时密码)*

首次登录后务必更改您的 Web UI 密码。否则，每次容器重启后密码都会随机生成。

---

## 🛡️ 安全与最佳实践

1. **保持 **`.env`** 文件私密**

   - `.gitignore` 文件**已阻止**`.env`**上传至 GitHub。**

2. **为 Gluetun API 使用强密码**

   - **修改 `.env` 中的 **`GLUETUN_PASS`** 以防止未授权的 API 访问。**

3. **在下载种子前验证 VPN 连接**

   - 在容器内运行 `curl ifconfig.me`：
     ```sh
     docker exec -it qbittorrent curl ifconfig.me
     ```
   - ✅ **如果IP匹配ProtonVPN**，说明正在正常工作。
   - ❌ **如果显示您的真实IP，说明出现了问题。**

---

## 🛠️ 故障排除

### **检查VPN是否正在运行**

```sh
docker ps
```

如果 Gluetun 没有运行，重启所有内容：

```sh
docker-compose down && docker-compose up -d
```

### **验证 qBittorrent 是否正在使用 VPN**

```sh
docker exec -it qbittorrent curl ifconfig.me
```

🟢 如果IP与ProtonVPN匹配，说明正在工作。\
🔴 如果显示您的真实IP，说明出现了问题。

### **检查错误日志**

```sh
docker logs -f gluetun
```

查找 **AUTH_FAILED** 或连接问题。

---

## 💎 许可证

本项目采用 **MIT 许可证** 许可 – 详情请参见 LICENSE 文件。

---

## 💪 贡献

欢迎贡献！如果您有改进建议或反馈，欢迎提交问题或拉取请求。

---

## 💬 支持与反馈

- 如果您觉得有帮助，请在 GitHub 上给它一个⭐星！
- 反馈和建议随时欢迎。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-10

---
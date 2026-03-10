# 🏰️ qBittorrent + ProtonVPN (WireGuard) in Docker (macOS)

**Securely run qBittorrent in Docker with ProtonVPN (WireGuard) using Gluetun, ensuring full VPN routing and automatic port forwarding for improved torrenting performance.**

&#x20;

---

## 📌 Table of Contents

1. [Overview](#overview)
2. [Features](#features)
3. [Prerequisites](#prerequisites)
4. [Installation Guide](#installation-guide)
   - [Install Docker](#install-docker)
   - [Clone the Repository](#clone-the-repository)
   - [Set Up the ](#set-up-the-env-file)[`.env`](#set-up-the-env-file)[ File](#set-up-the-env-file)
   - [Configure Authentication](#configure-authentication)
   - [Start the Containers](#start-the-containers)
5. [Accessing qBittorrent Web UI](#accessing-qbittorrent-web-ui)
6. [Security & Best Practices](#security--best-practices)
7. [Troubleshooting](#troubleshooting)
8. [License](#license)
9. [Contributing](#contributing)
10. [Support & Feedback](#support--feedback)

---

## 🔹 Overview

This setup ensures **qBittorrent only connects through ProtonVPN (WireGuard)** using **Gluetun**, preventing leaks and enhancing security.\
It also **automates port forwarding** for better torrent speeds and **runs everything inside Docker** for easy management.

---

## ✅ Features

- **🔒 VPN-Enforced Torrenting** – No leaks, all traffic runs **inside** the VPN.
- **⚡ Automatic Port Forwarding** – Ensures better speeds and improved peer connections.
- **🌐 Local Web UI Access** – Easily control torrents via [`http://localhost:8080`](http://localhost:8080).
- **📺 Fully Containerized** – Uses Docker for easy deployment, updates, and isolation.
- **🔄 Resilient Setup** – Containers **auto-restart** if anything crashes.
- Uses **separate storage** for incomplete and completed torrents
- **Automatically updates containers using Watchtower** 🛠️

---

## 🛠️ Prerequisites

- **Docker Desktop** (macOS/Windows/Linux)
- **Docker Compose** (bundled with Docker Desktop)
- **ProtonVPN account** (Plus or Visionary required for WireGuard support)

---

## 📂 Installation Guide

### **1️⃣ Install Docker**

Download and install **Docker Desktop** from [here](https://www.docker.com/products/docker-desktop/).\
Ensure Docker is **running** before proceeding.

---

### **2️⃣ Clone the Repository**

```sh
git clone https://github.com/torrentsec/qbittorrent-protonvpn-docker.git
cd qbittorrent-protonvpn-docker
```

---

### **3️⃣ Set Up the **`.env`** File**

This project uses an `.env` file to store **sensitive configuration values** (which are ignored by Git for security).

#### **Create Your **`.env`** File**

```sh
cp .env.example .env
nano .env
```

#### **Fill in the Following Variables**

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

🚀 **qBittorrent is now running securely through ProtonVPN!**

---

## 📚 Accessing qBittorrent Web UI

Once running, open:\
📌 [**http://localhost:8080**](http://localhost:8080)\
*(Default username: admin, password: check console for temporarily password)*

Make sure to change your web UI password after the first login. Otherwise, the password will be randomly generated after every container restart.

---

## 🛡️ Security & Best Practices

1. **Keep **`.env`** Private**

   - The `.gitignore` file **already prevents **`.env`** from being uploaded to GitHub.**

2. **Use a Strong Password for Gluetun API**

   - **Modify **`GLUETUN_PASS`** in **`.env` to prevent unauthorized API access.

3. **Verify VPN Connectivity Before Torrenting**

   - Run `curl ifconfig.me` inside the container:
     ```sh
     docker exec -it qbittorrent curl ifconfig.me
     ```
   - ✅ **If the IP matches ProtonVPN**, it's working.
   - ❌ **If it shows your real IP, something is wrong.**

---

## 🛠️ Troubleshooting

### **Check if VPN is Running**

```sh
docker ps
```

If Gluetun isn’t running, restart everything:

```sh
docker-compose down && docker-compose up -d
```

### **Verify qBittorrent is Using VPN**

```sh
docker exec -it qbittorrent curl ifconfig.me
```

🟢 If the IP matches ProtonVPN, it’s working.\
🔴 If it shows your real IP, something is wrong.

### **Check Logs for Errors**

```sh
docker logs -f gluetun
```

Look for **AUTH\_FAILED** or connection issues.

---

## 💎 License

This project is licensed under the **MIT License** – see the LICENSE file for details.

---

## 💪 Contributing

Contributions are welcome! If you have improvements or feedback, feel free to submit an issue or pull request.

---

## 💬 Support & Feedback

- If you found this helpful, give it a ⭐ star on GitHub!
- Feedback & suggestions are always welcome.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-10

---
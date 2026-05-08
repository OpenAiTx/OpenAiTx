# UnblockPro — Bypass Discord and YouTube Blocks


<p align="center">
  <strong>Automatic DPI bypass for macOS and Windows</strong><br>
  Unblock Discord, YouTube, and other services with one click
</p>

<p align="center">
  <a href="https://github.com/by-sonic/unblock-pro/releases/latest"><img src="https://img.shields.io/github/v/release/by-sonic/unblock-pro?style=for-the-badge&color=blue&label=version" alt="Version"></a>
  <a href="https://github.com/by-sonic/unblock-pro/releases/latest"><img src="https://img.shields.io/github/downloads/by-sonic/unblock-pro/total?style=for-the-badge&color=green&label=downloads" alt="Downloads"></a>
  <a href="https://github.com/by-sonic/unblock-pro/blob/main/LICENSE"><img src="https://img.shields.io/github/license/by-sonic/unblock-pro?style=for-the-badge&color=purple" alt="License"></a>
  <img src="https://img.shields.io/badge/platform-macOS%20%7C%20Windows-blue?style=for-the-badge" alt="Platform">
</p>

---

## Download

| Platform | File | Description |
|-----------|------|----------|
| **macOS** Apple Silicon (M1/M2/M3/M4) | [UnblockPro-mac-arm64.zip](https://github.com/by-sonic/unblock-pro/releases/latest) | For Macs with M processor |
| **macOS** Intel | [UnblockPro-mac-x64.zip](https://github.com/by-sonic/unblock-pro/releases/latest) | For Macs with Intel |
| **Windows** | [UnblockPro-win-setup.exe](https://github.com/by-sonic/unblock-pro/releases/latest) | Installer |
| **Windows** | [UnblockPro-win-portable.exe](https://github.com/by-sonic/unblock-pro/releases/latest) | Portable version (no installation) |

> Go to [Releases](https://github.com/by-sonic/unblock-pro/releases/latest) and download the version for your OS

---

## What is it?

**UnblockPro** is a desktop application for bypassing DPI blocks that lets you use Discord, YouTube, and other services without a VPN. Works on macOS and Windows.

### Key Features

- **One click** — press "Connect" and everything works
- **Automatic strategy selection** — the app finds a working bypass method for your provider automatically
- **Connection verification** — the strategy is checked with a real request, not guesswork
- **macOS + Windows** — full support for both platforms
- **Autostart** — launches with the system  
- **Auto-connect** — connects automatically at startup  
- **System tray** — runs in the background, unobtrusive  
- **Safe cleanup** — proxy settings are automatically reset on exit  

---

## How it works  

UnblockPro uses [zapret](https://github.com/bol-van/zapret) technology to bypass Deep Packet Inspection (DPI):  

| Platform  | Method |  
|-----------|--------|  
| **macOS** | `tpws` — SOCKS5 proxy with packet modification. The app automatically configures the system proxy |  
| **Windows** | `winws` — intercepts packets at the driver level via WinDivert. No proxy configuration needed |  

The app sequentially tests several strategies (split+disorder, split-tls, methodeol, oob, and others) until it finds one that works for your provider.  

---

## Installation  

### macOS  

1. Download `UnblockPro-*-mac.zip` from [Releases](https://github.com/by-sonic/unblock-pro/releases/latest)  
2. Unzip and drag `UnblockPro.app` into the Applications folder  
3. **Open Terminal** and run the command:

```bash
xattr -cr /Applications/UnblockPro.app
```
4. Launch the application and click "Connect"

> **Why is this command needed?** macOS blocks apps without a paid Apple Developer signature ($99/year). The `xattr -cr` command removes the quarantine flag — this is safe, the project code is fully open. Works on Intel and Apple Silicon (M1/M2/M3).

### Windows

1. Download the installer or portable version from [Releases](https://github.com/by-sonic/unblock-pro/releases/latest)
2. Run as administrator
3. Click "Connect"

> **Important:** On Windows, administrator rights are required for WinDivert to work

---

## Screenshots

<p align="center">
  <em>Main screen — connection status, one-click control</em>
</p>

---

## FAQ

<details>
<summary><strong>Is this a VPN?</strong></summary>
No. UnblockPro does not encrypt traffic or route it through a remote server. It modifies network packets locally so that the provider’s DPI systems cannot recognize and block requests to Discord/YouTube.
</details>

<details>
<summary><strong>Is it safe?</strong></summary>
Yes. The app is open-source, does not collect data, and does not send traffic through third-party servers. All code is available for audit.
</details>

<details>
<summary><strong>What if the app crashes?</strong></summary>
Proxy settings are automatically reset on any exit: normal, crash, or kill. On the next launch, settings are also cleared for reliability.
</details>


<details>
<summary><strong>Discord/YouTube still not working</strong></summary>
Try disconnecting and reconnecting — the app will try other strategies. If none help, your provider might be using advanced DPI — create an Issue.
</details>

<details>
<summary><strong>macOS: “file was not opened” / Gatekeeper</strong></summary>

Open Terminal and run:
```bash
xattr -cr /Applications/UnblockPro.app
```
After that, the application will launch normally. This only needs to be done once.

If you downloaded the `.zip` and unpacked it into another folder — specify the path to the `.app` instead of `/Applications/UnblockPro.app`.
</details>

---

## Development

```bash
# Клонировать репозиторий
git clone https://github.com/by-sonic/unblock-pro.git
cd unblock-pro

# Установить зависимости
npm install

# Запустить в режиме разработки
npm start

# Собрать для текущей ОС
npm run build

# Собрать для macOS
npm run build:mac

# Собрать для Windows
npm run build:win
```

---

## Stack

- **Electron** — cross-platform framework
- **zapret** — DPI bypass engine ([bol-van/zapret](https://github.com/bol-van/zapret))
- **electron-builder** — build and distribution
- **GitHub Actions** — automatic builds on release

---

## License

[MIT](LICENSE) — free use, modification, and distribution.

---

<p align="center">
  <strong>by sonic</strong><br>
  <sub>If the project helped — give a ⭐️</sub>
</p>

---

### Keywords / Keywords

> discord unblock, youtube unblock, discord unblock bypass, youtube unblock bypass, dpi bypass, anti-block, unblock discord, discord russia, youtube russia, zapret gui, dpi bypass, discord unblock russia, youtube unblock russia, anti dpi, bypass discord block, unblock discord, unblock youtube


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-08

---
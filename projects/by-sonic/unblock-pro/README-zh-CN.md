# UnblockPro — 绕过 Discord 和 YouTube 阻止


<p align="center">
  <strong>适用于 macOS 和 Windows 的自动 DPI 绕过工具</strong><br>
  一键解锁 Discord、YouTube 及其他服务
</p>

<p align="center">
  <a href="https://github.com/by-sonic/unblock-pro/releases/latest"><img src="https://img.shields.io/github/v/release/by-sonic/unblock-pro?style=for-the-badge&color=blue&label=version" alt="Version"></a>
  <a href="https://github.com/by-sonic/unblock-pro/releases/latest"><img src="https://img.shields.io/github/downloads/by-sonic/unblock-pro/total?style=for-the-badge&color=green&label=downloads" alt="Downloads"></a>
  <a href="https://github.com/by-sonic/unblock-pro/blob/main/LICENSE"><img src="https://img.shields.io/github/license/by-sonic/unblock-pro?style=for-the-badge&color=purple" alt="License"></a>
  <img src="https://img.shields.io/badge/platform-macOS%20%7C%20Windows-blue?style=for-the-badge" alt="Platform">
</p>

---

## 下载

| 平台 | 文件 | 描述 |
|-----------|------|----------|
| **macOS** Apple Silicon (M1/M2/M3/M4) | [UnblockPro-mac-arm64.zip](https://github.com/by-sonic/unblock-pro/releases/latest) | 适用于搭载 M 处理器的 Mac |
| **macOS** Intel | [UnblockPro-mac-x64.zip](https://github.com/by-sonic/unblock-pro/releases/latest) | 适用于搭载 Intel 的 Mac |
| **Windows** | [UnblockPro-win-setup.exe](https://github.com/by-sonic/unblock-pro/releases/latest) | 安装程序 |
| **Windows** | [UnblockPro-win-portable.exe](https://github.com/by-sonic/unblock-pro/releases/latest) | 便携版（无需安装） |

> 访问 [Releases](https://github.com/by-sonic/unblock-pro/releases/latest) 并下载适合您操作系统的版本

---

## 这是什么？

**UnblockPro** 是一款桌面应用程序，用于绕过 DPI 阻止，允许您无需 VPN 即可使用 Discord、YouTube 及其他服务。支持 macOS 和 Windows。

### 主要功能

- **一键连接** — 点击“连接”即可使用
- **自动策略选择** — 应用自动为您的网络提供商找到可用的绕过方法
- **连接检测** — 策略通过真实请求验证，而非猜测
- **macOS + Windows** — 完全支持两个平台
- **自动启动** — 随系统启动
- **自动连接** — 启动时自动连接
- **系统托盘** — 后台运行，不打扰
- **安全清理** — 退出时自动重置代理设置

---

## 工作原理

UnblockPro 使用 [zapret](https://github.com/bol-van/zapret) 技术绕过深度包检测 (DPI)：

| 平台      | 方法  |
|-----------|-------|
| **macOS** | `tpws` — 带包修改的 SOCKS5 代理。应用自动配置系统代理 |
| **Windows** | `winws` — 通过 WinDivert 驱动层拦截数据包。不需要代理配置 |

应用依次测试多种策略（split+disorder，split-tls，methodeol，oob 等），直到找到适合您运营商的可用方案。

---

## 安装

### macOS

1. 从 [Releases](https://github.com/by-sonic/unblock-pro/releases/latest) 下载 `UnblockPro-*-mac.zip`
2. 解压 ZIP 并将 `UnblockPro.app` 拖入「应用程序」文件夹
3. **打开终端** 并执行命令：

```bash
xattr -cr /Applications/UnblockPro.app
```
4. 启动应用程序并点击“连接”

> **为什么需要这条命令？** macOS 会阻止没有付费 Apple Developer 签名（每年 99 美元）的应用程序。命令 `xattr -cr` 会移除隔离标志——这是安全的，项目代码完全开源。适用于 Intel 和 Apple Silicon（M1/M2/M3）。

### Windows

1. 从 [Releases](https://github.com/by-sonic/unblock-pro/releases/latest) 下载安装程序或便携版本  
2. 以管理员身份运行  
3. 点击“连接”

> **重要提示：** Windows 需要管理员权限才能使用 WinDivert

---

## 截图

<p align="center">
  <em>主界面 — 连接状态，一键控制</em>
</p>

---

## 常见问题解答

<details>
<summary><strong>这是 VPN 吗？</strong></summary>
不是。UnblockPro 不加密流量，也不通过远程服务器路由。它在本地修改网络数据包，使运营商的 DPI 系统无法识别和阻止对 Discord/YouTube 的请求。
</details>

<details>
<summary><strong>这安全吗？</strong></summary>
安全。应用是开源的，不收集数据，也不通过第三方服务器发送流量。所有代码均可审计。
</details>

<details>
<summary><strong>如果应用崩溃怎么办？</strong></summary>
代理设置会在任何结束时自动重置：无论是正常退出、异常终止还是被强制关闭。下次启动时，设置同样会被清理以确保安全。
</details>


<details>
<summary><strong>Discord/YouTube 仍然无法使用</strong></summary>
尝试断开连接并重新连接 — 应用程序将尝试其他策略。 如果都无效，可能是您的提供商使用了高级 DPI — 请创建 Issue。
</details>

<details>
<summary><strong>macOS：“文件未被打开” / Gatekeeper</strong></summary>

打开终端并执行：
```bash
xattr -cr /Applications/UnblockPro.app
```
之后应用程序将正常启动。此操作只需执行一次。

如果下载了 `.zip` 并解压到其他文件夹——请指定 `.app` 的路径，而不是 `/Applications/UnblockPro.app`。
</details>

---

## 开发

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

## 技术栈

- **Electron** — 跨平台框架
- **zapret** — DPI 绕过引擎 ([bol-van/zapret](https://github.com/bol-van/zapret))
- **electron-builder** — 构建与发布
- **GitHub Actions** — 发布时自动构建

---

## 许可证

[MIT](LICENSE) — 自由使用、修改和分发。

---

<p align="center">
  <strong>by sonic</strong><br>
  <sub>如果本项目帮到了你 — 请点⭐️</sub>
</p>

---

### 关键词 / Keywords

> discord 解锁，youtube 解锁，绕过 discord 封锁，绕过 youtube 封锁，dpi 绕过，反封锁，解锁 discord，discord 俄罗斯，youtube 俄罗斯，zapret gui，绕过 dpi，discord 解锁俄罗斯，youtube 解锁俄罗斯，反 dpi，绕过 discord 封锁，解锁 discord，解锁 youtube


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-08

---
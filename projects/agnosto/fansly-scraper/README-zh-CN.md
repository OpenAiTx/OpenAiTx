# Fansly 爬取工具

> [!IMPORTANT]
> **项目状态更新**
>
> 由于最近的健康问题，该项目在我生活中的优先级大幅下降。未来可预见的一段时间内，更新和支持将非常有限。感谢您的理解。
>
> 如果您正在寻找一个维护更积极、具有完整 WebUI、实时仪表盘和点播播放器，并支持自动后台监控和归档的替代方案，请查看 **[Accerso](https://accesro.one)**。

> [!WARNING]
> **‼️ Windows Defender 误报**（完全不清楚为什么或从哪里来的）
>
> 本程序的 Windows 可执行文件经常被 Windows Defender 及其他杀毒软件标记为 **`Trojan:Script/Wacatac.B!ml`**。这是一个**误报**。
>
> **为什么会这样？**
> 检测名称中的 `!ml` 表示这是由机器学习模型标记的，而非人工。由于这是一个未签名的开源爬取工具，会进行大量网络请求，自动系统误判其为可疑。这是许多基于 Go 和 Rust 的命令行工具常见的问题。
>
> **推荐方案 - 通过 Go 安装（希望能绕过杀毒问题）：**
> ```bash
> go install github.com/agnosto/fansly-scraper/cmd/fansly-scraper@latest
> ```
>
> **您可以这样做：**
> 1.  **信任程序：** 您可以临时禁用 Windows Defender 来下载和运行程序，然后将其添加为例外。
> 2.  **从源码构建：** 如果您安装了 Go，可以自行编译。程序在本地编译或通过 go 安装时不会被标记。
>
> 代码完全开源，供您检查。使用安全，但我理解杀毒警告可能让人担忧。

一个简单的全能工具，用于下载和监控 Fansly 创作者的内容。

> **⚠️ 当前开发中** - 部分功能可能无法完美运行。请参见下方[已知问题](#known-issues)。

## 需求

- **可选但强烈推荐**：[ffmpeg](https://ffmpeg.org/) 用于直播录制和保存更高质量视频。请参阅 [此指南](https://phoenixnap.com/kb/ffmpeg-windows) 在 Windows 上安装到系统路径。
- **可选**：[mt](https://github.com/mutschler/mt) 用于生成更好的联系表

## 快速开始


### 1. 下载
- **简便方式**：访问[下载页面](https://agnosto.github.io/projects/fansly-scraper/)（自动检测您的系统）
- **手动方式**：从[GitHub发布页面](https://github.com/agnosto/fansly-scraper/releases)获取
- **通过Go安装**：
```bash
go install github.com/agnosto/fansly-scraper/cmd/fansly-scraper@latest
```

### 2. 运行程序
```bash
./fansly-scraper
```
首次运行时，安装向导将帮助您完成所有配置。按 'a' 使用自动登录：它会打开 Fansly 并提供一行代码片段，供您粘贴到 DevTools 控制台中。您的令牌和用户代理会被自动捕获并保存到配置文件中。

## 基本用法

### 交互模式（推荐初学者）

```bash
./fansly-scraper
```
从主菜单您可以：
- 运行设置向导（选择保存位置，自动登录）
- 重置配置（恢复默认，重新运行向导）

### 命令行模式

```bash
# Download all content from a creator
./fansly-scraper -u {creator-name}

# Download specific content types
./fansly-scraper -u {creator-name} -d [all|timeline|messages|stories]

# Monitor for live streams
./fansly-scraper -m {creator-name}

# Start/stop monitoring
./fansly-scraper monitor [start|stop]
```

**注意**：实时监控需要保持终端会话处于活动状态。要在后台运行监控，可以考虑在 Linux/WSL 上使用类似 [tmux](https://github.com/tmux/tmux/wiki) 或 [zellij](https://github.com/zellij-org/zellij) 的终端复用器。从 v0.6.3 开始，您可以通过在不同的终端实例中运行 `-m creator` 来监控额外的创作者，而无需重启现有的监控进程。

### 更新程序
```bash
./fansly-scraper update
```

## 项目路线图与高级设置

我们的开发进度公开记录在**[项目路线图](https://github.com/users/agnosto/projects/1)**。您可以查看我们正在做什么，未来的计划，以及参与讨论。

- **配置指南**：请参阅**[官方维基](https://github.com/agnosto/fansly-scraper/wiki)**
- **从源码构建**：
  ```bash
  git clone https://github.com/agnosto/fansly-scraper && cd fansly-scraper
  go build -v -ldflags "-w -s" -o fansly-scraper ./cmd/fansly-scraper
  ```
## 贡献

欢迎并非常感谢您的贡献！无论是报告错误、提出功能建议还是提交拉取请求，您的帮助都非常宝贵。

![alt text](https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=flat-square)

![alt text](https://img.shields.io/badge/contributions-welcome-brightgreen.svg?style=flat-square)

在开始之前，请阅读我们的[贡献指南](https://raw.githubusercontent.com/agnosto/fansly-scraper/main/./CONTRIBUTING.md)。  
查看[问题标签](https://github.com/agnosto/fansly-scraper/issues)看看是否有您想接手的任务。

## 已知问题

- **重新下载**：自 v0.8.3 版本起，文件命名规则发生更改，导致媒体文件被重新下载。  
- **聊天记录**：重连时可能偶尔会漏掉消息。  
- **MacOS 用户**：可能需要在[系统设置](https://github.com/gen2brain/beeep/issues/67#issuecomment-2646474049)中允许通知。  
- **直播状态**：在 TUI 界面按 `r` 刷新直播状态。  
- **重复文件**：由于 Fansly API 结构，有时相同图片可能出现两次。  
- **直播文件名日期格式**：如果直播流被中断并尝试重新录制，且日期格式不够具体（如无时间戳），可能无法保存后续录像，因为两个 VOD 文件名相同。目前请使用以下格式之一：`2006-01-02_15:04:05` 或 `20060102_150405`。

## 支持项目

如果这个工具对您有帮助，请考虑在 GitHub 上赞助：

[![Sponsor agnosto on GitHub](https://img.shields.io/badge/Sponsor-%23EA4AAA?style=for-the-badge&logo=githubsponsors)](https://github.com/sponsors/agnosto)

或者，您也可以通过加密货币进行一次性捐赠：

<table>
  <tr>
    <td align="center"><strong>比特币 (BTC)</strong></td>
    <td align="center"><strong>索拉纳 (SOL)</strong></td>
  </tr>
  <tr>
    <td align="center">
      <img src="https://raw.githubusercontent.com/agnosto/fansly-scraper/main/./assets/btc_qr.png" alt="Bitcoin QR Code" width="200"/>
      <p><code>bc1q0e78wrtc9ezp6tqv000wfewgqf2ue4tpzdk7ee</code></p>
    </td>
    <td align="center">

      <img src="https://raw.githubusercontent.com/agnosto/fansly-scraper/main/./assets/sol_qr.png" alt="Solana 二维码" width="200"/>
      <p><code>Bv3kYZcwSTHXAQtnPddTF27D3F6Gc29v2MfFLqmGF6Gf</code></p>
    </td>
  </tr>
</table>

---

> [!CAUTION]
> **免责声明**：此工具与 Fansly 或 Select Media LLC 无关。请自行承担风险使用。此脚本的开发者对最终用户的行为或最终用户账户可能产生的任何后果不承担责任。请自行承担风险。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-22

---
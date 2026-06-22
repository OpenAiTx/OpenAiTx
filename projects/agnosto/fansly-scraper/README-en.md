# Fansly Scraper

> [!IMPORTANT]
> **Project Status Update**
>
> Due to a recent health scare, this project is taking a very far backseat priority in my life. Updates and support will be very minimal for the foreseeable future. Thank you for your understanding.
>
> If you're looking for a more actively maintained alternative with a full WebUI, live dashboard and VOD player, and automatic background monitoring and archiving, check out **[Accerso](https://accesro.one)**.

> [!WARNING]
> **‼️ Windows Defender False Positive** (literally no idea why or where this came from)
>
> The Windows executable of this program is frequently being flagged as **`Trojan:Script/Wacatac.B!ml`** by Windows Defender and other AV. This is a **false positive**.
>
> **Why is this happening?**
> The `!ml` in the detection name means it was flagged by a Machine Learning model, not a human. Because this is an unsigned, open-source scraper tool that makes many internet requests, the automated system incorrectly flags it as suspicious. This is a common issue for many Go and Rust-based command-line tools.
>
> **Recommended Solution - Install via Go (should hopefully bypass AV issues):**
> ```bash
> go install github.com/agnosto/fansly-scraper/cmd/fansly-scraper@latest
> ```
>
> **What you can do:**
> 1.  **Trust the program:** You can temporarily disable Windows Defender to download and run the program, and then add it as an exception.
> 2.  **Build from source:** If you have Go installed, you can build it yourself. The program is not flagged when you compile it locally or install via go.
>
> The code is fully open-source for you to inspect. It is safe to use. but I understand if the AV warnings are concerning.

A simple all in one tool to download and monitor content from Fansly creators.

> **⚠️ Currently in development** - Some features may not work perfectly. See [known issues](#known-issues) below.


## Requirements

- **Optional but highly recommended**: [ffmpeg](https://ffmpeg.org/) for livestream recording and saving higher quality videos. Follow [this guide](https://phoenixnap.com/kb/ffmpeg-windows) for installing to system path on windows.
- **Optional**: [mt](https://github.com/mutschler/mt) for better contact sheets

## Quick Start

### 1. Download
- **Easy way**: Visit the [download page](https://agnosto.github.io/projects/fansly-scraper/) (auto-detects your system)
- **Manual way**: Get from [GitHub releases](https://github.com/agnosto/fansly-scraper/releases)
- **Install Via Go**:
```bash
go install github.com/agnosto/fansly-scraper/cmd/fansly-scraper@latest
```

### 2. Run the Program
```bash
./fansly-scraper
```

On first run, the setup wizard helps you configure everything. Press 'a' to use auto login: it opens Fansly and provides a one‑line snippet to paste in DevTools Console. Your token and user‑agent are captured automatically and saved to the config.

## Basic Usage

### Interactive Mode (Recommended for beginners)
```bash
./fansly-scraper
```

From the main menu you can:
- Run setup wizard (choose save location, auto login)
- Reset configuration (restore defaults, re-run wizard)

### Command Line Mode
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

**Note**: Live monitoring requires keeping your terminal session active. To run monitoring in the background, consider using terminal multiplexers like [tmux](https://github.com/tmux/tmux/wiki) or [zellij](https://github.com/zellij-org/zellij) on Linux/WSL. Starting from v0.6.3, you can monitor additional creators by running `-m creator` in separate terminal instances without restarting the existing monitor process.

### Update the Program
```bash
./fansly-scraper update
```

## Project Roadmap & Advanced Setup

Our development is tracked publicly on our **[Project Roadmap](https://github.com/users/agnosto/projects/1)**. You can see what we're working on, what's planned for the future, and contribute to the discussion.

- **Configuration Guide**: See the **[Official Wiki](https://github.com/agnosto/fansly-scraper/wiki)**
- **Build from source**:
  ```bash
  git clone https://github.com/agnosto/fansly-scraper && cd fansly-scraper
  go build -v -ldflags "-w -s" -o fansly-scraper ./cmd/fansly-scraper
  ```
## Contributing

Contributions are welcome and greatly appreciated! Whether it's reporting a bug, proposing a feature, or submitting a pull request, your help is valued.

![alt text](https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=flat-square)

![alt text](https://img.shields.io/badge/contributions-welcome-brightgreen.svg?style=flat-square)

Please read our [Contributing Guidelines](https://raw.githubusercontent.com/agnosto/fansly-scraper/main/./CONTRIBUTING.md) before you start.
Check the [Issues tab](https://github.com/agnosto/fansly-scraper/issues) to see if there's a task you'd like to take on.

## Known Issues

- **Redownloading**: As of v0.8.3, file naming convention was changed causing redownloading of media.
- **Chat recording**: May occasionally miss messages during reconnections
- **MacOS users**: May need to allow notifications in [system settings](https://github.com/gen2brain/beeep/issues/67#issuecomment-2646474049)
- **Live status**: Press `r` in TUI to refresh live status
- **Duplicate files**: Sometimes the same image may appear twice due to Fansly's API structure
- **Date formats for livestream filename**: In the event a stream gets interrupted and reattempts to record, if the date format isn't specific enough (ie, no timestamp), it may fail to save the stream after as both vods will be the same name, for now use one of these: `2006-01-02_15:04:05` or `20060102_150405`

## Support the Project

If this tool helps you, consider sponsoring on github:

[![Sponsor agnosto on GitHub](https://img.shields.io/badge/Sponsor-%23EA4AAA?style=for-the-badge&logo=githubsponsors)](https://github.com/sponsors/agnosto)

Alternatively, you can make a one-time donation via cryptocurrency:

<table>
  <tr>
    <td align="center"><strong>Bitcoin (BTC)</strong></td>
    <td align="center"><strong>Solana (SOL)</strong></td>
  </tr>
  <tr>
    <td align="center">
      <img src="https://raw.githubusercontent.com/agnosto/fansly-scraper/main/./assets/btc_qr.png" alt="Bitcoin QR Code" width="200"/>
      <p><code>bc1q0e78wrtc9ezp6tqv000wfewgqf2ue4tpzdk7ee</code></p>
    </td>
    <td align="center">

      <img src="https://raw.githubusercontent.com/agnosto/fansly-scraper/main/./assets/sol_qr.png" alt="Solana QR Code" width="200"/>
      <p><code>Bv3kYZcwSTHXAQtnPddTF27D3F6Gc29v2MfFLqmGF6Gf</code></p>
    </td>
  </tr>
</table>

---

> [!CAUTION]
> **Disclaimer**: This tool is not affiliated with Fansly or Select Media LLC. Use at your own risk. The developer of this script is not responsible for the end users' actions or any outcomes that may be taken upon the end users' account. Use at your own risk.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-22

---
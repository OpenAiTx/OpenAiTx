# TeamSpeak 6 服务器 - Beta 版发布说明

欢迎使用 TeamSpeak 6 服务器 Beta 版！我们很高兴您能参与体验新一代 TeamSpeak。本文件将指导您入门，并突出当前 Beta 版本的重要细节。

由于这是 Beta 测试版，一些功能仍在开发中，您可能会遇到 bug。您的反馈非常重要，将帮助我们打造更稳定、完善的正式版本。

<h2><img width="24" src="/icons/teamspeak_blue.svg">&nbsp;关于 TeamSpeak</h2>

经过近 25 年的验证，我们拥有能够满足所有人需求的解决方案。TeamSpeak 提供理想的语音通信服务，适用于游戏、教育和培训、企业内部沟通，以及与朋友和家人保持联系。我们的主要目标是提供一个易于使用、高安全标准、卓越语音质量、低系统和带宽占用的解决方案。

## ℹ️ Beta 状态与已知问题
**这是 Beta 测试版。主要目的是收集多样化的反馈并在正式版本发布前发现潜在问题。**

**自托管服务器文件：** TeamSpeak 6 的专用服务器软件仍在积极开发中，尚未完全具备全部功能。我们承诺将为自托管服务器提供完整的 TS6 体验。

**功能不稳定性：** 一些新功能可能不稳定，或在持续优化过程中会有所变动。

**反馈至关重要：** 您的体验对我们非常宝贵，您的意见对我们至关重要。请在我们的 [社区论坛](https://community.teamspeak.com/c/teamspeak-6-server/45) 或直接在 [GitHub](https://github.com/teamspeak/teamspeak6-server/issues) 上报告任何问题或提出建议。

**限制：** 请注意，**TeamSpeak 3 服务器许可证与 TeamSpeak 6 服务器不兼容**，目前**两个版本之间也没有迁移路径**。

**预览许可证：** 根据您的反馈，服务器现在附带一个**临时**的 32 人数预览许可证，以便在评估期间提供更大的灵活性。请注意，该许可证**仅在两个月内有效**。

此外，目前**尚无法获取或升级更大容量的 TeamSpeak 6 许可证**。

我们非常感谢您的耐心和理解，我们将继续努力，为未来更好地支持您的需求。

## 👇 TS6 快速入门
要开始使用 TeamSpeak 6 客户端，请前往我们的 [下载页面](https://teamspeak.com/en/downloads/)。

有关自托管的更多信息，请参阅下方简要指南。想获取最新动态、公告以及与 TeamSpeak 社区互动，请访问我们的 [社区论坛](https://community.teamspeak.com/) 并关注我们的 [Twitter](https://x.com/teamspeak)。

不想自托管，或只需要更简单的 TeamSpeak 6 上手方式？您可以通过 [TeamSpeak Communities](https://www.myteamspeak.com/communities) 直接租用可靠的官方 TeamSpeak 6 服务器。
## ⚙️ 配置
### 您可以通过三种主要方式配置服务器：

1. **命令行参数：** 启动服务器时直接传递选项（例如：./tsserver --default-voice-port 9987）。适用于临时更改或脚本化。

2. **环境变量：** 在启动服务器前设置环境变量。适用于 Docker 或希望避免命令行参数混乱的场景。

3. **YAML 配置文件：** 若需持久化配置，强烈推荐使用 tsserver.yaml 文件。您可以通过 --write-config-file 标志生成默认配置文件。

您可以控制的主要设置包括网络端口（语音、文件传输）、数据库连接（支持 SQLite 和 MariaDB）、IP 绑定和日志选项。

如需完整的可用选项列表，请使用 `--help` 标志运行服务器，或参阅 [CONFIG.md](https://raw.githubusercontent.com/teamspeak/teamspeak6-server/main/CONFIG.md)。

### 使用二进制文件运行服务器
如果您不使用 Docker，可以直接在操作系统上运行服务器。

<h2><img width="22" src="/icons/linux.svg">&nbsp;在 Linux 上运行：</h2>

使服务器二进制文件可执行：
```sh
chmod +x tsserver
```

在终端中运行服务器，并确保接受许可协议：

```sh
./tsserver --accept-license
```

<h2><img width="22" src="/icons/windows.svg">&nbsp;在 Windows 上运行：</h2>

打开命令提示符或 PowerShell 并切换到解压服务器文件的目录。

运行服务器可执行文件，并确保接受许可协议：
```powershell
tsserver.exe
```

<h2><img width="32" src="/icons/docker.svg">&nbsp;使用 Docker 运行服务器（推荐）：</h2>
Docker 是在隔离且易于管理的环境中运行 TeamSpeak 6 服务器的最简单方式。

### 1. 简单 docker run 命令：

快速启动时，可使用 docker run 命令。

```sh
docker run -it --rm \
  -p 9987:9987/udp \
  -p 30033:30033 \
  -e TSSERVER_LICENSE_ACCEPTED=accept \
  teamspeaksystems/teamspeak6-server:latest
```

### 2. 使用 docker-compose.yaml（适用于持久化部署）：
如果希望服务器持续运行，这是最佳实践。创建一个 docker-compose.yaml 文件：

```yaml
services:
  teamspeak:
    image: teamspeaksystems/teamspeak6-server:latest
    container_name: teamspeak-server
    restart: unless-stopped
    ports:
      - "9987:9987/udp"   # 语音端口
      - "30033:30033/tcp" # 文件传输
      # - "10080:10080/tcp" # Web 查询
    environment:
```
```
      - TSSERVER_LICENSE_ACCEPTED=accept
    volumes:
      - teamspeak-data:/var/tsserver/

volumes:
  teamspeak-data:
```

## 🔗 实用链接
[官方网站](https://teamspeak.com/en/)<br>
[社区论坛](https://community.teamspeak.com)<br>
[GitHub 问题反馈](https://github.com/teamspeak/teamspeak6-server/issues)<br>

您的参与和反馈将帮助我们共同塑造 TeamSpeak 的未来！💙<br>
感谢您成为 TeamSpeak 6 Beta 计划的一员，并为其发展做出贡献！🫡

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---
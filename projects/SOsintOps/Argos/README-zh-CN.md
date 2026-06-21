# ARGOS — 测试版
<img align="right" width="86" height="150" src="https://github.com/SOsintOps/Argos/blob/master/multimedia/images/scribblenauts-argos.png">

> **警告：测试版**
> 本脚本已针对 Ubuntu 24.04 LTS 和 Ubuntu Budgie 24.04 LTS 进行更新。
> 目前处于积极测试阶段。使用前请务必在干净的虚拟机中运行。
> 如有任何问题，请通过提交 issue 反馈。

Argos 自动从干净的 Ubuntu 24.04 LTS 虚拟机配置开源 OSINT 工作站。

最佳实践建议为每个 OSINT 调查使用独立虚拟机。
本脚本遵循 Michael Bazzell 在 [Open Source Intelligence Techniques](https://inteltechniques.com/book1.html) 中描述的方法。

## 目录
- [需求](#requirements)
- [工具](#tools)
- [安装](#installation)
- [安装日志](#installation-log)
- [待办事项](#to-do)
- [资源](#resources)
- [鸣谢](#credits)
- [许可](#licences)
- [版本历史](https://raw.githubusercontent.com/SOsintOps/Argos/master/docs/VERSION_HISTORY.md)
- [OSINT 分析指南](https://raw.githubusercontent.com/SOsintOps/Argos/master/docs/guidelines.md)
- [常见问题](https://raw.githubusercontent.com/SOsintOps/Argos/master/docs/faq.md)

---

## 需求

- Ubuntu **24.04 LTS** 或 **Ubuntu Budgie 24.04 LTS**（虚拟机或工作站）
- 任意 Linux 用户名（已取消之前必须使用 `osint` 用户的要求）
- 系统语言：**英语**
- 安装期间需有活动的网络连接
- **已安装 VirtualBox Guest Additions** — 脚本不负责安装，请在运行 `setup.sh` 之前安装 Guest Additions，以启用剪贴板共享、拖放和全屏支持。

> 脚本针对 VirtualBox 进行了优化。VMware Tools 的代码注释中可用。

**测试环境：**
- Ubuntu Budgie 24.04 LTS（虚拟机）
- Ubuntu 24.04 LTS（虚拟机）

**不再支持：**
- Ubuntu 22.04 LTS（某些依赖不兼容）
- Ubuntu 20.04 LTS

---

## 工具

### OSINT

| 工具 | 状态 | 备注 |
|------|--------|-------|
| [Amass](https://github.com/owasp-amass/amass) | 活跃 | 子域名枚举 |
| [Instaloader](https://instaloader.github.io/) | 活跃 | Instagram OSINT |
| [Toutatis](https://github.com/megadose/toutatis) | 有限 | 需要 Instagram 会话 ID |
| [HTTrack](https://www.httrack.com/) | 活跃 | 网站爬取与镜像 |
| [MediaInfo](https://mediaarea.net/en/MediaInfo) | 活跃 | 媒体元数据分析 |
| [ExifTool](https://exiftool.org/) | 活跃 | 文档与图片元数据 |
| [EyeWitness](https://github.com/FortyNorthSecurity/EyeWitness) | 活跃 | 网站截图 |
| [The Harvester](https://github.com/laramies/theHarvester) | 活跃 | 邮箱与域名侦察 |
| [Metagoofil](https://github.com/opsdisk/metagoofil) | 活跃 | 公开文档元数据 |
| [recon-ng](https://github.com/lanmaster53/recon-ng) | 活跃 | 模块化 OSINT 框架 |
| [Sherlock](https://github.com/sherlock-project/sherlock) | 活跃 | 用户名搜索 |
| [SpiderFoot](https://github.com/smicallef/spiderfoot) | 活跃 | OSINT 自动化 |
| [blackbird](https://github.com/p1ngul1n0/blackbird) | 活跃 | 高级用户名搜索 |
| [holehe](https://github.com/megadose/holehe) | 活跃 | 邮箱 OSINT |
| [maigret](https://github.com/soxoj/maigret) | 活跃 | 用户名搜索（Sherlock 高级分支） |
| [Maltego](https://www.maltego.com/) | 活跃 | 关联分析（需账号） |
| [yt-dlp](https://github.com/yt-dlp/yt-dlp) | 活跃 | 视频下载器（替代 youtube-dl） |

**已移除工具（弃用或停止维护）：**
- ~~Instalooter~~：使用 Instaloader
- ~~Sublist3r~~：使用 Amass
- ~~Photon~~：使用 Katana 或 GoSpider
- ~~youtube-dl~~：被 yt-dlp 替代
- ~~Moriarty-Project~~：使用 PhoneInfoga
- ~~Elasticsearch-Crawler~~：使用 Shodan CLI
- ~~Atom Editor~~（2022 年 12 月停止维护）：被 VSCodium 替代
### 通用工具

| 工具 | 状态 |
|------|--------|
| [VLC](https://www.videolan.org/vlc/) | 活跃 |
| [Google Earth Pro](https://www.google.com/earth/versions/#earth-pro) | 活跃 |
| [VSCodium](https://vscodium.com/) | 活跃（替代 Atom） |
| [CherryTree](https://www.giuspen.com/cherrytree/) | 活跃 |
| [KeePassXC](https://keepassxc.org/) | 活跃 |
| [Kazam](https://launchpad.net/kazam) | 活跃 |
| [Audacity](https://www.audacityteam.org/) | 活跃 |
| [Tor Browser](https://www.torproject.org/) | 活跃 |
| [OpenShot](https://www.openshot.org/) | 活跃 |
| [Obsidian](https://obsidian.md/) | 活跃（最新版本动态获取） |
| [Ripgrep](https://github.com/BurntSushi/ripgrep) | 活跃 |
| [Threat Intelligence Resources](https://github.com/pstirparo/threatintel-resources) | 活跃 |

---

## 安装

1. 打开终端。

2. 如果尚未安装 Git，则安装：

    ```bash
    sudo apt install -y git
    ```

3. 将仓库克隆到 `Downloads` 目录：
    ```bash
    git clone https://github.com/SOsintOps/Argos ~/Downloads/Argos
    ```

4. 使脚本可执行：
    ```bash
    chmod +x ~/Downloads/Argos/setup.sh
    ```

5. 运行脚本：
    ```bash
    ~/Downloads/Argos/setup.sh
    ```

    > Firefox 无需手动关闭或打开。脚本会自动初始化 Firefox 配置文件（如果尚未创建）。

---

## 安装日志

脚本会自动在下载目录中生成一个日志文件：

```
~/Downloads/argos_install_YYYYMMDD_HHMMSS.log
```
日志包含带有时间戳的完整安装输出。如果发生错误，日志中会记录确切的行号。

---

## 待办事项

- 添加 PhoneInfoga 以替代 Moriarty-Project
- 添加 Katana 或 GoSpider 以替代 Photon
- 更新 LibreOffice 的 OSINT 调查报告模板
- 完成 Ubuntu Budgie 24.04 LTS 虚拟机的端到端测试
- 为 holehe、maigret 独立版和 blackbird 独立版添加快捷方式

---

## 资源

- [OSIntOps 网站](https://osintops.com/en/)
- [Argos 项目介绍（意大利语）](https://osintops.com/progetto-argos/)
- [OSInt 每日新闻](https://t.me/Osintlatestnews)
- [Michael Bazzell 的《开源情报技术》](https://inteltechniques.com/book1.html)

---

## 致谢

- Skykn0t 贡献了最初的 OSINT_VM_Setup 脚本
- [oh6hay](https://github.com/oh6hay) 贡献了脚本名称
- [pinkevilpimp](https://github.com/pinkevilpimp) 贡献了壁纸脚本

---

## 许可证

请参阅仓库中包含的许可证文件。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-21

---
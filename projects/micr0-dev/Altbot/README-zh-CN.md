<div align="center">
  <img src="https://raw.githubusercontent.com/micr0-dev/Altbot/main/assets/micr0-alty-banner.png" alt="一个装饰性横幅，展示了在浅色背景下重复排列的小紫色机器人图标图案，营造出复古科技壁纸效果">

# Altbot 无障碍机器人

_让联邦宇宙更具包容性，一次描述一张图片_

[![最新版本](https://img.shields.io/github/v/release/micr0-dev/Altbot)](https://github.com/micr0-dev/Altbot/releases)
[![Mastodon 关注](https://img.shields.io/mastodon/follow/113183205946060973?domain=fuzzies.wtf&style=social)](https://fuzzies.wtf/@altbot)
[![许可证: AGPLv3](https://img.shields.io/badge/License-AGPLv3-blue.svg)](https://www.gnu.org/licenses/agpl-3.0)
[![Go 版本](https://img.shields.io/github/go-mod/go-version/micr0-dev/Altbot)](https://go.dev/)
![状态](https://img.shields.io/badge/status-active-success)
![环境](https://img.shields.io/badge/environment-friendly-green)

</div>

## 关于

Altbot 是一个开源无障碍机器人，旨在通过为图片、视频和音频生成替代文本描述来增强联邦宇宙的可访问性。这样有助于视觉障碍用户更容易访问内容。

## 隐私与 GDPR 合规

**Altbot 2.0 现已实现所有处理100%本地完成，零数据保留！** [![Mastodon 关注](https://img.shields.io/mastodon/follow/113183205946060973?domain=fuzzies.wtf&style=social)](https://fuzzies.wtf/@altbot)

为符合 GDPR，Altbot 在处理任何用户请求前需要明确的知情同意。首次与 Altbot 互动时，您将收到同意请求，包含数据收集实践的信息及我们的[隐私政策](https://raw.githubusercontent.com/micr0-dev/Altbot/main/PRIVACY.md)链接。

- **我们收集的信息：** 请求时间戳、处理时间、语言偏好、媒体类型
- **我们不收集的信息：** 图片、个人信息、帖子内容
- **如何撤回同意：** 只需屏蔽该机器人账号

您的帖子内容绝不会被保存或分享。只有没有现有替代文本的图片会被处理，且所有处理均在我们的本地服务器私密完成。

## 免责声明

替代文本由大型语言模型（LLM）生成。虽然我们力求准确，但结果有时可能存在事实错误。请务必在使用前仔细核对替代文本。

## 工作原理

Altbot 监听 Mastodon 上的提及和关注。当检测到提及或关注用户的新帖子时，会检查是否有无替代文本的图片。如果发现，会使用大型语言模型（LLM）生成描述性的替代文本并回复生成的文本。

### 功能

- **基于提及的替代文本生成：** 在任何包含图片、视频或音频的帖子回复中提及 @Altbot，Altbot 将为其生成替代文本描述。  
- **为关注者自动生成替代文本：** 关注 @Altbot，它会监控你的帖子。如果你发布了没有替代文本的图片、视频或音频，Altbot 会自动为你生成替代文本。  
- **本地大语言模型支持：** 通过 Ollama 使用本地大语言模型生成替代文本描述。  
- **符合 GDPR 规定：** 明确的知情同意系统，要求用户在处理请求前提供同意，并清晰告知数据使用情况。  
- **同意请求：** 当非原帖用户提及时，生成替代文本前会向原帖发布者请求同意。  
- **可配置设置：** 通过 TOML 文件轻松配置机器人。  

## 安装

### 标准

1. 克隆仓库：

   ```sh
   git clone https://github.com/micr0-dev/Altbot.git
   cd Altbot
   ```
2. 运行安装向导：


   ```sh
   go run .
   ```

   安装向导将引导您配置机器人所需的基本值，包括：

   - 您的 Mastodon 服务器 URL、客户端密钥、访问令牌和机器人用户名。
   - 用于管理通知的管理员联系账号。
   - 启用可选功能，如指标和替代文本提醒。

   或者，复制示例配置文件并手动编辑：

   ```sh
   cp example.config.toml config.toml
   ```

3. 运行机器人：
   ```sh
   go run .
   ```

### Docker

1. 克隆仓库：

   ```sh
   git clone https://github.com/micr0-dev/Altbot.git
   cd Altbot
   ```
2. 运行安装向导：


   ```sh
   docker run -it -v ./:/data --rm ghcr.io/micr0-dev/altbot:latest
   ```

   设置向导将引导您配置机器人所需的基本值，包括：

   - 您的 Mastodon 服务器 URL、客户端密钥、访问令牌和机器人用户名。
   - 用于管理通知的管理员联系账号。
   - 启用可选功能，如指标和替代文本提醒。

   或者，复制示例配置文件并手动编辑：

   ```sh
   cp example.config.toml config.toml
   ```

3. 运行机器人：
   ```sh
   docker compose up -d
   ```

## 开发环境搭建

### 前提条件

- **Go 1.24+**：从 [go.dev](https://go.dev/dl/) 安装
- **LLM 提供商**（以下之一）：
  - **Gemini API**：从 [Google AI Studio](https://aistudio.google.com/app/apikey) 获取 API 密钥
  - **Ollama**：从 [ollama.ai](https://ollama.ai/) 安装并拉取视觉模型（例如，`ollama pull llava-phi3`）
  - **Transformers**：需要安装带有 transformers 库的 Python 及兼容的 GPU

### 快速开始

1. 克隆代码库：

   ```sh
   git clone https://github.com/micr0-dev/Altbot.git
   cd Altbot
   ```
2. 安装依赖项：


   ```sh
   go mod download
   ```

3. 复制并配置配置文件：

   ```sh
   cp example.config.toml config.toml
   # Edit config.toml with your LLM API and model of choice
   ```

4. 运行机器人：
   ```sh
   go run .
   ```

### 开发模式

使用 `--dev` 标志以开发模式运行机器人。 这提供了一个交互式命令行界面，用于测试而不发布到 Mastodon：

```sh
go run . --dev
```

**注意：** 开发模式跳过 Mastodon 认证，但仍需在 `config.toml` 中配置有效的 LLM API（如 Gemini、Ollama 等）以测试图像/视频/音频处理。

#### 开发模式命令

| 命令           | 描述                                               |
| -------------- | -------------------------------------------------- |
| `/image <url>` | 处理图像 URL 并生成替代文本                        |
| `/video <url>` | 处理视频 URL 并生成替代文本                        |
| `/audio <url>` | 处理音频 URL 并生成替代文本                        |
| `/lang [code]` | 设置/显示响应语言（例如 en、de、ja）              |
| `/follow`      | 模拟关注事件                                       |
| `/status`      | 显示当前开发模式状态                               |
| `/help`        | 显示可用命令                                       |
| `/quit`        | 退出开发模式                                       |

你也可以直接粘贴 URL 来处理为图像。

**示例会话：**

```
[dev] > /lang de
Language set to: de

[dev] > https://example.com/image.jpg
Processing image: https://example.com/image.jpg
Please wait...

=== Generated Alt-Text ===
Ein Foto von...
```

### 建筑

```sh
go build -o altbot .
```

## 贡献

我们欢迎贡献！请打开一个 issue 或提交一个 pull request 来改进项目。

## 支持 / 社区

有问题？想聊天？加入我们：[chat.micr0.dev](https://chat.micr0.dev)

频道：#dev 讨论项目，#help 寻求支持

IRC：irc.micr0.dev（端口 6667/6697）

## 感谢

### 特别感谢

我要向 **Henrik Schönemann**（[@Schoeneh](https://github.com/Schoeneh)）表达最深切的感谢，他在整个过程中激励着我。他在处理批评并将其转化为建设性反馈方面的帮助非常宝贵。没有他的支持和指导，我真的不会有今天的成就。

### Kofi 支持者

衷心感谢所有支持我的 [Ko-fi](https://ko-fi.com/) 朋友！你们的慷慨支持帮助 Altbot 继续运行和不断改进。你们的支持对我意义重大，也帮助让联邦宇宙对每个人更加友好。

## 许可

本项目采用 [GNU AFFERO 通用公共许可证 第3版 (AGPLv3)](https://www.gnu.org/licenses/agpl-3.0.en.html) 许可。详见 [LICENSE](LICENSE) 文件。

---

加入我们，一起让联邦宇宙成为一个更具包容性的空间！


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-28

---
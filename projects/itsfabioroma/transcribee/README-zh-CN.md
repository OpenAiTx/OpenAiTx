# transcribee 🐝

**开源 macOS 转录工具，支持 YouTube、Instagram Reels、TikTok 及本地媒体 —— 发展自我组织的知识库。**

```bash
transcribee "https://youtube.com/watch?v=..."
transcribee "https://instagram.com/reel/..."
transcribee "https://vt.tiktok.com/..."
transcribee ~/Downloads/podcast.mp3
```
随着时间的推移，您的 `~/Documents/transcripts/` 文件夹自然演变成一个个人图书馆：


```
transcripts/
├── AI-Research/
│   ├── ilya-sutskever-agi-2024/
│   └── anthropic-constitutional-ai/
├── Startups/
│   ├── ycombinator-how-to-get-users/
│   └── pmarca-founder-mode/
└── Health/
    └── huberman-sleep-optimization/
```
每个转录文本均标注了说话人，准备好粘贴到 ChatGPT、Claude 或任何大型语言模型中。

## 为什么选择 🍯

我消耗大量视频内容——YouTube、Instagram、TikTok、播客、访谈。我想要：
- 在大型语言模型中提问视频相关问题
- 让所有知识可搜索且有条理
- 不用手动维护这些内容

transcribee 正是为此而生。只需转录一次，知识永存。

## 功能 🪻

- **转录** YouTube、Instagram Reels、TikTok 和本地音视频文件
- **说话人区分**——识别不同说话者
- **自动分类** 转录文本，基于内容使用 Claude 完成
- **构建知识库**，随时间自动组织整理

## 在 OpenClaw 中使用 🤖

transcribee 作为 [OpenClaw](https://github.com/openclaw/openclaw) 的技能提供。只需让你的代理转录任意 YouTube 视频：

> “转录这个视频：https://youtube.com/watch?v=...”

### 安装该技能


```bash
# Install from ClawHub (recommended)
openclaw skills install transcribee

# Or clone manually
git clone https://github.com/itsfabioroma/transcribee.git ~/.openclaw/workspace/skills/transcribee
```
确保已安装依赖项（`brew install yt-dlp ffmpeg`）并配置了 API 密钥。

## 快速开始 🪺


```bash
# Install dependencies (macOS)
brew install yt-dlp ffmpeg
pnpm install

# Configure API keys
cp .env.example .env
# Add your ElevenLabs + Anthropic API keys to .env

# Transcribe anything
transcribee "https://youtube.com/watch?v=..."
transcribee "https://instagram.com/reel/..."
transcribee "https://vt.tiktok.com/..."
transcribee ~/Downloads/podcast.mp3
transcribee ~/Videos/interview.mp4
```

### Shell 别名（推荐）

添加到 `~/.zshrc`：

```bash
alias transcribee="noglob /path/to/transcribee/transcribe.sh"
```

## 输出 🍯

每个转录文件保存到 `~/Documents/transcripts/{category}/{title}/`：

| 文件 | 用途 |
|------|-------|
| `transcript.txt` | 带说话人标注的转录文本 — **将此粘贴到您的大语言模型中** |
| `metadata.json` | 视频信息、语言、自动检测主题 |

### 原始 JSON（可选）

适合需要词级时间戳和置信度分数的高级用户：

```bash
transcribee --raw "https://youtube.com/watch?v=..."
```
这增加了包含完整 ElevenLabs 响应的 `transcript-raw.json`。

## 工作原理 🐝

1. 从 YouTube 下载音频（yt-dlp）或从本地视频提取音频（ffmpeg）
2. 使用 ElevenLabs 转录（`scribe_v1_experimental`，带说话人区分）
3. Claude 分析内容和现有库结构
4. 自动分类到正确的文件夹
5. 保存带元数据的转录文件

## 要求

- macOS（已在 Sonoma 测试）
- Node.js 18+
- [yt-dlp](https://github.com/yt-dlp/yt-dlp) — `brew install yt-dlp`
- [ffmpeg](https://ffmpeg.org/) — `brew install ffmpeg`
- [ElevenLabs API 密钥](https://elevenlabs.io/) — 用于转录
- [Anthropic API 密钥](https://anthropic.com/) — 用于自动分类

## 支持的格式

| 类型 | 格式 |
|------|---------|
| 音频 | mp3, m4a, wav, ogg, flac |
| 视频 | mp4, mkv, webm, mov, avi |
| URL | youtube.com, youtu.be, instagram.com/reel, tiktok.com |

---

*bzz bzz* 🐝



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-31

---
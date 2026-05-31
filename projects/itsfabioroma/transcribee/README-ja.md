# transcribee 🐝

**YouTube、Instagram Reels、TikTok、およびローカルメディア向けのオープンソースmacOSトランスクリプター — 自己組織化ナレッジベースを進化させます。**

```bash
transcribee "https://youtube.com/watch?v=..."
transcribee "https://instagram.com/reel/..."
transcribee "https://vt.tiktok.com/..."
transcribee ~/Downloads/podcast.mp3
```
時間が経つにつれて、あなたの `~/Documents/transcripts/` フォルダーは自然と個人図書館へと進化します：


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
各トランスクリプトには話者ラベルが付けられており、ChatGPT、Claude、または任意のLLMにそのまま貼り付けることができます。

## なぜ 🍯

私は大量の動画コンテンツを消費しています — YouTube、Instagram、TikTok、ポッドキャスト、インタビューなど。私は以下を望んでいました：
- 動画についてLLMに質問できること
- すべての知識を検索可能かつ整理された状態にすること
- それを維持するための手作業を一切しないこと

transcribeeはまさにそれを実現します。一度文字起こしすれば、知識は永遠に残ります。

## 機能 🪻

- **YouTube、Instagramリール、TikTok、ローカルの音声/動画ファイルを文字起こし**
- **話者識別** — 異なる話者を特定
- **内容に基づきClaudeを使って自動カテゴリ分け**
- **時間と共に自己整理される知識ライブラリを構築**

## OpenClawと併用 🤖

transcribeeは[OpenClaw](https://github.com/openclaw/openclaw)のスキルとして利用可能です。エージェントにYouTubeの任意の動画を文字起こしするよう依頼するだけ：

> 「この動画を文字起こしして：https://youtube.com/watch?v=...」

### スキルのインストール方法


```bash
# Install from ClawHub (recommended)
openclaw skills install transcribee

# Or clone manually
git clone https://github.com/itsfabioroma/transcribee.git ~/.openclaw/workspace/skills/transcribee
```

依存関係がインストールされていることを確認してください（`brew install yt-dlp ffmpeg`）およびAPIキーが設定されていること。

## クイックスタート 🪺

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

### シェルエイリアス（推奨）

`~/.zshrc` に追加：

```bash
alias transcribee="noglob /path/to/transcribee/transcribe.sh"
```

## 出力 🍯

各トランスクリプトは `~/Documents/transcripts/{category}/{title}/` に保存されます：

| ファイル | 用途 |
|----------|-------|
| `transcript.txt` | 話者ラベル付きトランスクリプト — **これをLLMに貼り付けてください** |
| `metadata.json` | 動画情報、言語、自動検出テーマ |

### 生のJSON（オプション）

単語単位のタイムスタンプと信頼度スコアが必要なパワーユーザー向け：

```bash
transcribee --raw "https://youtube.com/watch?v=..."
```

これにより、ElevenLabsの完全なレスポンスを含む`transcript-raw.json`が追加されます。

## 仕組み 🐝

1. YouTubeから音声をダウンロード（yt-dlp）またはローカル動画から抽出（ffmpeg）
2. ElevenLabsで文字起こし（話者分離付きの`scribe_v1_experimental`）
3. Claudeがコンテンツと既存のライブラリ構造を分析
4. 適切なフォルダに自動分類
5. メタデータ付きで文字起こしファイルを保存

## 要件

- macOS（Sonomaで動作確認済み）
- Node.js 18以上
- [yt-dlp](https://github.com/yt-dlp/yt-dlp) — `brew install yt-dlp`
- [ffmpeg](https://ffmpeg.org/) — `brew install ffmpeg`
- [ElevenLabs APIキー](https://elevenlabs.io/) — 文字起こし用
- [Anthropic APIキー](https://anthropic.com/) — 自動分類用

## 対応フォーマット

| 種類 | フォーマット |
|------|-------------|
| 音声 | mp3, m4a, wav, ogg, flac |
| 動画 | mp4, mkv, webm, mov, avi |
| URL | youtube.com, youtu.be, instagram.com/reel, tiktok.com |

---

*ぶんぶん* 🐝


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-31

---
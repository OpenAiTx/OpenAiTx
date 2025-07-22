Release : Alpha 1.0.5

<div style="display:flex; width:100%; column-gap:16px; margin-bottom:12px;">
    <span>対応環境 :</span>
    <img style="width:24px; height:24px;" src="https://github.com/ask0ldd/OsspitaUI/blob/main/Front/src/assets/windows.png">
    <img style="width:24px; height:24px;" src="https://github.com/ask0ldd/OsspitaUI/blob/main/Front/src/assets/chrome.png">
    <img style="width:24px; height:24px;" src="https://github.com/ask0ldd/OsspitaUI/blob/main/Front/src/assets/firefox.png">
    <img style="width:24px; height:24px;" src="https://github.com/ask0ldd/OsspitaUI/blob/main/Front/src/assets/brave.png">
    <span style="display:flex; height:100%;">&</span>
    <img style="width:24px; height:24px;" src="https://github.com/ask0ldd/OsspitaUI/blob/main/Front/src/assets/ubuntu.png">
    <img style="width:24px; height:24px;" src="https://github.com/ask0ldd/OsspitaUI/blob/main/Front/src/assets/chrome.png">
    <img style="width:24px; height:24px;" src="https://github.com/ask0ldd/OsspitaUI/blob/main/Front/src/assets/firefox.png">
    <img style="width:24px; height:24px;" src="https://github.com/ask0ldd/OsspitaUI/blob/main/Front/src/assets/brave.png">
</div>

# OSSPITA : あなたのAIアシスタントをローカルで実行し、直感的なインターフェースでエージェントを数クリックでチューニングできます。プライバシーは保証され、費用はかかりません。

OSSPITAは軽量で完全ローカルなオープンソースのデスクトップインターフェースで、ユーザーが様々なオープンソースLLMとリアルタイムで無料に対話できるようにします。[Ollama API](https://github.com/ollama/ollama)を活用し、最先端AI技術との親しみやすい体験を提供します。

![osspita main](https://github.com/ask0ldd/OsspitaUI/blob/main/Front/src/assets/screenshot2.png "osspita main")

アルファ1.0.1リリースのビデオデモ、より最新の動画はまもなく公開予定：

[![OSspita Video Demo](https://img.youtube.com/vi/zKxcANYu-9I/0.jpg)](https://www.youtube.com/watch?v=zKxcANYu-9I "OSspita Video Demo")<br>
_上記の画像をクリックするとYouTubeで動画を視聴できます_

## I - 特徴

- ほとんどのオープンソースAIモデルとの**リアルタイム対話**。
- 軽量で**完全ローカル**動作。
- **初心者に優しい**インストールプロセス。
- マルチコンテキストエージェントチューニング。
- **Llama Vision**対応。
- 様々な歴史的人物とのチャット機能。
- 複雑なタスク解決のための**エージェントチェーン**。
- **プライバシーを保護しながら**独自のドキュメントを調査できるRetrieval Augmented Generation。
- より**最新の情報**を統合するためのWeb検索機能。
- 包括的な推論統計。
- **コンテキスト長チューニング**のためのメモリアロケーション追跡。
- (バージョニング対応予定の) **プロンプトライブラリ**。
- 最も**一般的なLLM設定**への簡単アクセス。

## II - 次に予定していること

- **レスポンシブ**デザイン。
- エージェントチェーンへの**並列処理**追加。
- 強化されたオプションを備えたWeb検索アルゴリズムの改善。
- オンラインドメイン名ランキング。
- 強化されたオプションを備えたRAGアルゴリズムの改善。
- オンラインプロンプトおよびエージェント共有プラットフォーム。
- プロンプトバージョニングシステム。
- 専用コーディングエージェント。
- コード構文ハイライト。
- **ダークモード**テーマ。
- グラフ生成。
- 音声モード。
- コンテキスト自動サイズ調整オプション。
- 詳細なRAG統計とデータ。
- 詳細なWeb検索統計とデータ。

## III - スクリーンショット

![osspita main](https://github.com/ask0ldd/OsspitaUI/blob/main/Front/src/assets/screenshot1.png "osspita main")

## IV - はじめに

### 前提条件

- Node.js (v22.11.0以上) : https://nodejs.org/en/
- npm (10.9.0以上)
- Ollama (ローカルにインストールして起動していること) : https://ollama.com/download
- OSspitaバックエンドが起動していること。
- 少なくとも一つのオープンソースモデル。
- 必要に応じてNvidia CUDA : https://developer.nvidia.com/cuda-downloads

モデル推奨：

| GPU VRAM   | モデル           | 用途           | リンク                                                               |
| ---------- | ---------------- | -------------- | -------------------------------------------------------------------- |
| 4GB        | Llama 3.2:3b     | 会話用         | [OllamaのLlama 3.2](https://ollama.com/library/llama3.2:3b)          |
| 8GB        | Aya Expanse:8b   | 会話用         | [OllamaのAya Expanse](https://ollama.com/library/aya-expanse:8b)     |
| 12GB       | Mistral Nemo:12b | 会話用         | [OllamaのMistral Nemo](https://ollama.com/library/mistral-nemo:12b)  |
| 4GB        | starcoder2:3b    | コーディング用 | [OllamaのStarCoder2](https://ollama.com/library/starcoder2)          |
| 8GB & 12GB | qwen2.5-coder:7b | コーディング用 | [OllamaのQwen 2.5 Coder](https://ollama.com/library/qwen2.5-coder)    |

### インストール

リポジトリをクローン：

> git clone https://github.com/ask0ldd/OsspitaUI.git

プロジェクトディレクトリに移動：

> cd OsspitaUI

#### フロントエンド

> cd front

依存関係をインストール：
> npm install

開発サーバーを起動します：

> npm run dev

ブラウザを開き、http://localhost:5173 にアクセスすると、インストールプロセスの残りの手順が案内されます。

## V - 使用方法

ビデオデモ：

## VI - 使用技術

- React 18.3.1
- Vite
- Ollama API
- ExpressJS
- LokiJS
- Zustand
- Duck-duck-scrape
- Cheerio
- React-pdftotext
- Marked 14.1.1
- Turndown
- Cors
- BodyParser

## VII - 貢献について

バグが発生した場合や機能の追加・改善を希望される場合は、ご要望を記載してIssueを開いてください。ご協力ありがとうございます。

## VIII - 謝辞

- llama.cppのGeorgi Gerganov氏および関係するすべての貢献者の皆様。
- 推論に使用したAPIを提供しているOllamaチーム。
- ReactおよびViteコミュニティの優れたツールに感謝します。
- プロジェクトに貢献し支援してくださったすべての方々。
- GGUFモデルを制作している皆様。
- 最後に、私が使用したライブラリに関わったすべての方々。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-22

---
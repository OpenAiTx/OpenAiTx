<div align="center">
  <img src="https://raw.githubusercontent.com/micr0-dev/Altbot/main/assets/micr0-alty-banner.png" alt="ライトな背景に紫色の小さなロボットアイコンが繰り返し並ぶ装飾的なバナーで、レトロなテック壁紙効果を演出">

# Altbot アクセシビリティロボット

_フェディバースをより包括的に、一度に一つの画像を_

[![Latest Release](https://img.shields.io/github/v/release/micr0-dev/Altbot)](https://github.com/micr0-dev/Altbot/releases)
[![Mastodon Follow](https://img.shields.io/mastodon/follow/113183205946060973?domain=fuzzies.wtf&style=social)](https://fuzzies.wtf/@altbot)
[![License: AGPLv3](https://img.shields.io/badge/License-AGPLv3-blue.svg)](https://www.gnu.org/licenses/agpl-3.0)
[![Go Version](https://img.shields.io/github/go-mod/go-version/micr0-dev/Altbot)](https://go.dev/)
![Status](https://img.shields.io/badge/status-active-success)
![Environment](https://img.shields.io/badge/environment-friendly-green)

</div>

## 概要

Altbotは、画像、動画、音声の代替テキスト説明を生成することでフェディバースを強化するオープンソースのアクセシビリティボットです。これにより視覚障害を持つユーザーがコンテンツにアクセスしやすくなります。

## プライバシーとGDPR準拠

**Altbot 2.0はすべて100％ローカルで処理し、データの保持は一切ありません！** [![Mastodon Follow](https://img.shields.io/mastodon/follow/113183205946060973?domain=fuzzies.wtf&style=social)](https://fuzzies.wtf/@altbot)

GDPRに準拠し、Altbotはユーザーのリクエストを処理する前に明示的な同意を必要とします。初めてAltbotとやり取りする際には、データ収集の情報と[プライバシーポリシー](https://raw.githubusercontent.com/micr0-dev/Altbot/main/PRIVACY.md)へのリンクを含む同意要求が送信されます。

- **収集する情報:** リクエストのタイムスタンプ、処理時間、言語設定、メディアタイプ
- **収集しない情報:** 画像、個人情報、投稿内容
- **同意の取り消し方法:** ボットアカウントをブロックするだけでOK

投稿内容は一切保存または共有されません。既に代替テキストがある画像は処理されず、すべての処理はプライベートなローカルサーバー上で行われます。

## 免責事項

代替テキストは大規模言語モデル（LLM）を使用して生成されます。正確性を心がけていますが、結果が事実と異なる場合があります。使用前に必ず代替テキストを再確認してください。

## 動作方法

AltbotはMastodonのメンションとフォローを監視します。メンションやフォローしているユーザーの新しい投稿を検知すると、代替テキストのない画像をチェックします。見つかった場合、大規模言語モデル（LLM）を使って説明的な代替テキストを生成し、生成したテキストで返信します。

### 機能

- **メンションベースの代替テキスト生成:** 画像、動画、または音声を含む投稿に返信で@Altbotをメンションすると、Altbotが代替テキストの説明を生成します。
- **フォロワー向け自動代替テキスト:** @Altbotをフォローすると、あなたの投稿を監視します。代替テキストなしで画像、動画、または音声を投稿すると、自動的に代替テキストを生成します。
- **ローカルLLMサポート:** Ollamaを介してローカルLLMを使用し、代替テキストの説明を生成します。
- **GDPR準拠:** ユーザーがリクエスト処理前に明示的な同意を提供する必要がある同意システムで、データ使用に関する明確な情報を提供します。
- **同意リクエスト:** OP以外のユーザーによるメンション時に代替テキストを生成する前に、元の投稿者から同意を求めます。
- **設定可能:** TOMLファイルを使って簡単にボットを設定できます。

## セットアップ

### 標準

1. リポジトリをクローンします：

   ```sh
   git clone https://github.com/micr0-dev/Altbot.git
   cd Altbot
   ```

2. セットアップウィザードを実行します:

   ```sh
   go run .
   ```

   セットアップウィザードは、ボットに必要な基本設定値の構成を案内します。内容は以下の通りです：

   - MastodonサーバーのURL、クライアントシークレット、アクセストークン、ボットのユーザー名。
   - 管理者連絡用のハンドル（モデレーション通知用）。
   - メトリクスや代替テキストのリマインダーなどのオプション機能の有効化。

   または、サンプルの設定ファイルをコピーして手動で編集してください：

   ```sh
   cp example.config.toml config.toml
   ```

3. ボットを実行する：
   ```sh
   go run .
   ```

### Docker

1. リポジトリをクローンします：

   ```sh
   git clone https://github.com/micr0-dev/Altbot.git
   cd Altbot
   ```

2. セットアップウィザードを実行します：

   ```sh
   docker run -it -v ./:/data --rm ghcr.io/micr0-dev/altbot:latest
   ```
   セットアップウィザードは、ボットに必要な基本設定の構成を案内します。以下を含みます：

   - MastodonサーバーのURL、クライアントシークレット、アクセストークン、およびボットのユーザー名。
   - モデレーション通知用の管理者連絡ハンドル。
   - メトリクスや代替テキストリマインダーなどのオプション機能の有効化。

   または、サンプル設定ファイルをコピーして手動で編集してください：


   ```sh
   cp example.config.toml config.toml
   ```

3. ボットを実行する:
   ```sh
   docker compose up -d
   ```

## 開発環境設定

### 前提条件

- **Go 1.24+**: [go.dev](https://go.dev/dl/) からインストール
- **LLM プロバイダー**（以下のいずれか）:
  - **Gemini API**: [Google AI Studio](https://aistudio.google.com/app/apikey) からAPIキーを取得
  - **Ollama**: [ollama.ai](https://ollama.ai/) からインストールし、ビジョンモデルをプル（例: `ollama pull llava-phi3`）
  - **Transformers**: Pythonとtransformersライブラリ、対応GPUが必要

### はじめに

1. リポジトリをクローン：

   ```sh
   git clone https://github.com/micr0-dev/Altbot.git
   cd Altbot
   ```

2. 依存関係をインストールします：

   ```sh
   go mod download
   ```

3. 設定ファイルをコピーして設定してください：

   ```sh
   cp example.config.toml config.toml
   # Edit config.toml with your LLM API and model of choice
   ```

4. ボットを実行する:
   ```sh
   go run .
   ```

### 開発モード

`--dev` フラグを使用してボットを開発モードで実行します。これにより、Mastodonに投稿せずにテスト用の対話型コマンドラインインターフェースが提供されます：

```sh
go run . --dev
```
**注意:** 開発モードではMastodon認証をスキップしますが、画像/動画/音声処理をテストするには `config.toml` に有効なLLM API（Gemini、Ollamaなど）を設定する必要があります。

#### 開発モードコマンド

| コマンド        | 説明                                             |
| -------------- | -------------------------------------------------- |
| `/image <url>` | 画像URLを処理し、代替テキストを生成します          |
| `/video <url>` | 動画URLを処理し、代替テキストを生成します          |
| `/audio <url>` | 音声URLを処理し、代替テキストを生成します          |
| `/lang [code]` | 応答の言語を設定/表示します（例: en, de, ja）        |
| `/follow`      | フォローイベントをシミュレートします                |
| `/status`      | 現在の開発モードの状態を表示します                   |
| `/help`        | 利用可能なコマンドを表示します                       |
| `/quit`        | 開発モードを終了します                               |

URLを直接貼り付けると、画像として処理することもできます。

**例セッション:**


```
[dev] > /lang de
Language set to: de

[dev] > https://example.com/image.jpg
Processing image: https://example.com/image.jpg
Please wait...

=== Generated Alt-Text ===
Ein Foto von...
```

### ビルディング

```sh
go build -o altbot .
```
## 貢献について

貢献を歓迎します！改善点があれば、ぜひIssueを開くかプルリクエストを送ってください。

## サポート / コミュニティ

質問がありますか？チャットしたいですか？[chat.micr0.dev](https://chat.micr0.dev) に参加してください。

チャンネル：プロジェクトの議論は #dev、サポートは #help

IRC：irc.micr0.dev（ポート 6667/6697）

## 感謝の言葉

### 特別な感謝

この旅の間ずっと私を励ましてくれた **Henrik Schönemann**（[@Schoeneh](https://github.com/Schoeneh)）に心から感謝します。批判を扱い、それを建設的なフィードバックに変える手助けは非常に貴重でした。彼の支援と指導なしでは、今の私はありませんでした。

### Kofi 支援者の皆様

すべての [Ko-fi](https://ko-fi.com/) 支援者の皆様に心から感謝します！皆様の寛大な支援がAltbotの運営と継続的な改善を支えています。皆様の支援は私にとって大きな意味があり、Fediverseをよりアクセスしやすい場所にする助けとなっています。

## ライセンス

本プロジェクトは [GNU AFFERO GENERAL PUBLIC LICENSE Version 3 (AGPLv3)](https://www.gnu.org/licenses/agpl-3.0.en.html) の下でライセンスされています。詳細は [LICENSE](LICENSE) ファイルをご覧ください。

---

皆でFediverseをより包括的な場所にしていきましょう！



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-28

---
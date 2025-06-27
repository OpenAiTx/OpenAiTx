# Gemini CLI

[![Gemini CLI CI](https://github.com/google-gemini/gemini-cli/actions/workflows/ci.yml/badge.svg)](https://github.com/google-gemini/gemini-cli/actions/workflows/ci.yml)

![Gemini CLI Screenshot](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/assets/gemini-screenshot.png)

このリポジトリには、Gemini CLI が含まれています。Gemini CLI は、あなたのツールと接続し、コードを理解し、ワークフローを加速するコマンドラインのAIワークフローツールです。

Gemini CLI を使うと、以下のことが可能です：

- Gemini の 1M トークンコンテキストウィンドウ内外で、大規模なコードベースのクエリや編集ができます。
- Gemini のマルチモーダル機能を使って、PDF やスケッチから新しいアプリを生成できます。
- プルリクエストのクエリや複雑なリベースの処理など、運用タスクを自動化できます。
- ツールや MCP サーバーを利用して新しい機能を接続できます（例：[Imagen、Veo、Lyria を用いたメディア生成](https://github.com/GoogleCloudPlatform/vertex-ai-creative-studio/tree/main/experiments/mcp-genmedia)）。
- Gemini に組み込まれている [Google 検索](https://ai.google.dev/gemini-api/docs/grounding) ツールで、クエリに根拠を持たせることができます。

## クイックスタート

1. **前提条件:** [Node.js バージョン 18](https://nodejs.org/en/download) 以上がインストールされていることを確認してください。
2. **CLI の実行:** ターミナルで以下のコマンドを実行してください。

   ```bash
   npx https://github.com/google-gemini/gemini-cli
   ```

   または、インストールして実行する場合:

   ```bash
   npm install -g @google/gemini-cli
   gemini
   ```

3. **カラーテーマを選択**
4. **認証:** 指示が表示されたら、個人の Google アカウントでサインインしてください。これにより、1分間に最大60回、1日に最大1,000回の Gemini モデルリクエストが可能になります。

これで Gemini CLI の利用準備が整いました！

### 上級者向けまたは利用上限の拡張について

特定のモデルの利用やリクエスト上限の増加が必要な場合は、API キーを使用できます。

1. [Google AI Studio](https://aistudio.google.com/apikey) からキーを生成します。
2. 生成したキーを環境変数としてターミナルに設定します。`YOUR_API_KEY` は発行されたキーに置き換えてください。

   ```bash
   export GEMINI_API_KEY="YOUR_API_KEY"
   ```

Google Workspace アカウントを含むその他の認証方法については、[認証ガイド](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/cli/authentication.md) を参照してください。

## 使用例

CLI が起動したら、シェルから Gemini との対話を開始できます。

新しいディレクトリからプロジェクトを開始する場合：

```sh
cd new-project/
gemini
> FAQ.md ファイルを利用して質問に答える Gemini Discord ボットを作成してください
```

既存のプロジェクトで作業する場合：

```sh
git clone https://github.com/google-gemini/gemini-cli
cd gemini-cli
gemini
> 昨日加えられたすべての変更点の要約を教えてください
```

### 次のステップ

- [ソースからのビルドやコントリビュート方法](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/CONTRIBUTING.md) を学ぶ。
- 利用可能な **[CLI コマンド](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/cli/commands.md)** を探索する。
- 問題が発生した場合は **[トラブルシューティングガイド](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/troubleshooting.md)** を確認する。
- より詳しいドキュメントは [完全なドキュメント](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/index.md) を参照。
- [人気のあるタスク](#popular-tasks) も参考にしてください。

### トラブルシューティング

問題が発生した場合は [トラブルシューティングガイド](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/troubleshooting.md) をご覧ください。

## 人気のあるタスク

### 新しいコードベースを探索

既存または新たにクローンしたリポジトリに `cd` し、`gemini` を実行します。

```text
> このシステムのアーキテクチャの主な構成要素を説明してください。
```

```text
> どのようなセキュリティ機構が備わっていますか？
```

### 既存コードとの作業

```text
> GitHub issue #123 の初期ドラフトを実装してください。
```

```text
> このコードベースを最新の Java バージョンに移行するための計画から始めて手伝ってください。
```

### ワークフローの自動化

MCP サーバーを使ってローカルのシステムツールをエンタープライズコラボレーションスイートと連携させます。

```text
> 過去7日間の git 履歴を機能ごと・チームメンバーごとにまとめて表示するスライド資料を作成してください。
```

```text
> 最もやり取りの多い GitHub issue を表示するための壁掛け用フルスクリーンWebアプリを作成してください。
```

### システムとの対話

```text
> このディレクトリ内の画像をすべて png に変換し、exif データの日付をファイル名にしてリネームしてください。
```

```text
> PDF 請求書を支出月ごとに整理してください。
```

## 利用規約およびプライバシー通知

Gemini CLI の利用に適用される利用規約およびプライバシー通知の詳細については、[利用規約およびプライバシー通知](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/tos-privacy.md) を参照してください。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---
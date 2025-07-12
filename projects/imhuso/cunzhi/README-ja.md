# 寸止 🛑

> **AI対話の「早漏」終結者、会話を最後まで続ける**

AIアシスタントがいつも早めに会話を終わらせてしまい、イライラしていませんか？まだ話したいことがたくさんあるのに、「他にお手伝いできることはありますか？」と聞かれてしまう。**寸止**はこの問題を専門的に解決します！

AIが「話を切り上げよう」としたとき、寸止が即座にダイアログを表示し、あなたが納得いくまで深くやり取りを続けられるようにします。

## 🌟 コア機能

- 🛑 **スマートインターセプト**：AIが会話を終えようとした時に自動で続行オプションを表示
- 🧠 **メモリ管理**：プロジェクトごとに開発規範や好みを保存
- 🎨 **洗練されたインタラクション**：Markdown対応・多様な入力方式
- ⚡ **インストール即利用**：3秒インストール、クロスプラットフォーム対応

## 📸 効果を見てみよう

### 🛑 スマートインターセプトポップアップ
![寸止ダイアログデモ](https://raw.githubusercontent.com/imhuso/cunzhi/main/./screenshots/popup.png)

*AIが会話を終えようとしたとき、寸止のスマートダイアログがタイミングよく表示され、あらかじめ定義された選択肢ですばやく選択でき、会話を深く続けられます*
### ⚙️ 設定管理画面
![寸止設定画面](https://raw.githubusercontent.com/imhuso/cunzhi/main/./screenshots/settings.png)

*エレガントな設定画面で、メモリ管理、機能スイッチ、テーマ切替、インテリジェントプロンプト生成をサポート*

## 🚀 はじめに

### 方法1：クイックインストール（推奨）

**macOS ユーザー：**
```bash
# 3秒でインストール、コンパイル待ち不要
brew tap imhuso/cunzhi && brew install cunzhi
```

> ⚠️ **トラブルシューティング**：404ダウンロードエラーが発生した場合は、以下の手順を実行してください：
>
> ```bash
> # 古いtapキャッシュをクリア
> brew untap imhuso/cunzhi
> # 再インストール
> brew tap imhuso/cunzhi && brew install cunzhi
> ```
>
> **よくあるエラー例：**
> ```
> curl: (56) The requested URL returned error: 404
> Error: cunzhi: Failed to download resource "cunzhi"
> Download failed: https://github.com/imhuso/cunzhi/releases/download/v0.2.0/cunzhi-cli-v0.2.4-macos-aarch64.tar.gz
> ```
>
> これは主に以前のバージョンのキャッシュ問題によるバージョン不一致が原因です。tapをクリアして再インストールすれば解決します。

**Windows/Linux ユーザー：**
方法2の手動ダウンロードを推奨します。簡単で迅速です！
### 方式二：手動ダウンロード

1. [Releases ページ](https://github.com/imhuso/cunzhi/releases)にアクセス
2. お使いのシステムに適したバージョンをダウンロード：
   - 🐧 **Linux**: `cunzhi-cli-v*-linux-x86_64.tar.gz`
   - 🍎 **macOS (Intel)**: `cunzhi-cli-v*-macos-x86_64.tar.gz`
   - 🍎 **macOS (Apple Silicon)**: `cunzhi-cli-v*-macos-aarch64.tar.gz`
   - 🪟 **Windows**: `cunzhi-cli-v*-windows-x86_64.zip`

3. 解凍後、`寸止` と `等一下` をシステムの PATH に追加

## ⚡ クイックスタート

### 第一步：MCP クライアントの設定

ご利用の MCP クライアント（例：Claude Desktop）の設定ファイルに以下を追加してください：

```json
{
  "mcpServers": {
    "寸止": {
      "command": "寸止"
    }
  }
}
```
### ステップ2：設定画面を開く

```bash
# 設定コマンドを実行
ちょっと待って
```

### ステップ3：プロンプトを設定する

設定画面の「参考プロンプト」タブで：
1. 自動生成されたプロンプトを確認する
2. コピー ボタンをクリックする
3. プロンプトをあなたのAIアシスタントに追加する

### ステップ4：使い始める

これであなたのAIアシスタントは、インテリジェントなブロック、メモリ管理、ポップアップインタラクション機能を備えました！

> 💡 **ワンポイントアドバイス**：生成されたプロンプトを参考にしてカスタマイズし、あなただけのAIインタラクション体験を作り上げましょう。
## 🤝 参加・貢献

寸止はオープンソースプロジェクトであり、あらゆる形での貢献を歓迎します！

### 🐛 問題を発見しましたか？
- [Issueを提出](https://github.com/imhuso/cunzhi/issues) して問題を説明してください
- 再現手順と環境情報を提供してください

### 💡 良いアイデアがありますか？
- [ディスカッションを開始](https://github.com/imhuso/cunzhi/discussions) してあなたのアイデアを共有してください
- Pull Requestを送って新機能を実装してください

### 🛠️ ローカル開発
```bash
git clone https://github.com/imhuso/cunzhi.git
cd cunzhi
pnpm install
pnpm tauri:dev
```
## 📞 お問い合わせ

- 🐛 **問題のフィードバック**：[GitHub Issues](https://github.com/imhuso/cunzhi/issues)
- 💬 **機能の議論**：[GitHub Discussions](https://github.com/imhuso/cunzhi/discussions)
- ⭐ **プロジェクトが気に入ったら**：ぜひ Star で応援してください！

## 📄 オープンソースライセンス

MIT License - 自由にご利用いただけます。貢献も歓迎します！

---

<div align="center">

**AI対話の「早漏」にさようなら | すべてのやり取りを最後まで続けましょう**

[⭐ Star](https://github.com/imhuso/cunzhi) · [🐛 バグ報告](https://github.com/imhuso/cunzhi/issues) · [💡 機能リクエスト](https://github.com/imhuso/cunzhi/discussions)

</div>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---
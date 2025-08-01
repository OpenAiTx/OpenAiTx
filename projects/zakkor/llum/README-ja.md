# llum

### 高速で軽量、オープンなチャットUI

![image](https://github.com/user-attachments/assets/38cc47cf-06a3-4dca-8ee5-d9c9edf57903)

### 主な特徴:

- 🔌 複数のプロバイダーに対応、APIキーを差し込むだけ（完全にローカルに保存）で準備完了

  - ローカルモデル（Ollama経由）
  - OpenRouter（多くのプロバイダーの全モデルを使用可能：OpenAI、Anthropic、OSS、その他50以上）
  - OpenAI
  - Anthropic
  - Mistral
  - Groq

- 🛠️ ツール使用
  - `server/toolfns/toolfns.go` をチェックしてください。関数を書くのみでOK。関数のコメントがモデルに渡される説明となり、使用すべきものがわかります。Web UIの「Sync」ボタンをクリックしてツールを更新。
- 🖼️ マルチモーダル入力：画像のアップロード、貼り付け、リンク共有が可能
- 🎨 DALL-E 3を使った画像生成
- 📝 マルチショットプロンプティング。編集、削除、再生成も自在。世界はあなたのもの
- ⚡ 事前入力済みの応答（プロバイダー対応時）
- 🌐 すべてのプロバイダーの全利用可能モデルに対応
- 🔄 会話中にモデル変更可能
- 🔐 チャットとキーをデバイス間で同期、エンドツーエンド暗号化。セルフホストも、当社のホストインスタンス利用も可能。
- 🔗 会話共有（共有を選択した場合、リンク生成のために会話は外部サーバーに保存されます。セルフホスト共有オプションは近日公開。いいえ、あなたの内容は見ません。）
- 🌿 分岐する会話履歴（左・右のChatGPTの矢印のようにクリックで前の応答に戻れます）

### プライバシー:

- 完全にプライベートで透明。会話履歴とキーはすべてローカルに保存され、ブラウザ内、あなたのデバイスのみに保持されます。

## インストール方法は？

ツールを使わない場合、インストール不要です。ホスト済みインスタンスはこちら：https://llum.chat

ツールを使いたい場合は、以下に進んでください。

## 単一バイナリ:

llumツールサーバーは単一バイナリで事前ビルド済みです。[リリースページから事前ビルドパッケージをダウンロードしてください。](https://github.com/zakkor/llum/releases)

プラットフォーム用バイナリをダウンロードし、実行するとツールサーバーが起動します：

```
./llum-darwin-amd64
Tool server running at http://localhost:8081
```

https://llum.chat に戻り、設定 -> ツール呼び出し に進み、「ツールを更新」ボタンをクリックしてください。これで準備完了です！

### クライアントとサーバーをローカルで構築する方法：

1. リポジトリをクローンします
2. クライアントをインストールして起動します：`npm i && npm run dev`。クライアントは http://localhost:5173 でアクセス可能です
3. サーバーをインストールして起動します：`cd server && go generate ./... && go build && ./server -password foobar`。サーバーは http://localhost:8081 でアクセス可能です。チャットUIのサーバーアドレスにこれを設定し、選択したパスワードを入力してください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---
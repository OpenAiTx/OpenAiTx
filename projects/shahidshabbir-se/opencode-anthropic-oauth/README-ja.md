# opencode-anthropic-oauth

Anthropic Claude Pro/Max OAuthログイン用のOpenCodeプラグイン — Claude Codeは不要です。

## 何ができるか

ブラウザOAuthを通じて、Claude Pro/Maxサブスクリプションで直接OpenCodeに認証できます。Claude Codeのインストールや認証情報ファイルの管理は不要です。

## インストール方法

```bash
npm install -g opencode-anthropic-oauth
```

次に、`opencode.json`に追加してください：

```json
{
  "plugin": ["opencode-anthropic-oauth"]
}
```
## 使用方法

1. OpenCodeで `/connect` を実行する（またはCLIから `oc auth login`）
2. **Anthropic** > **Claude Pro/Max** を選択
3. ブラウザでリンクを開き、認証を行う
4. コードをOpenCodeに貼り付ける
5. 完了 — すべてのAnthropicモデルが利用可能に

## 動作原理

- Anthropicの認証エンドポイントに対してOAuth PKCEフローを直接実装
- 認証のためブラウザを開き、Claudeアカウントでログイン
- 認可コードをアクセストークンとリフレッシュトークンに交換
- **トークンの有効期限切れ時に自動更新** — 手動再認証不要
- Anthropicリクエストに必要なAPIヘッダーを設定
- **プロンプトキャッシュを保持**し効率的なトークン使用を実現

## 更新履歴

### 0.4.1
- **トークン消費の過剰問題を修正** — プロンプトキャッシュを無効にしていた `cache_control` の除去を削除
- トークン追跡用の `x-anthropic-billing-header` を追加
- 公式Claude CLIプラグインとベータフラグを整合

### 0.4.0
- OAuth互換のための `?beta=true` URLパラメータを追加
- claude-codeベータ用にシステムIDプレフィックスを挿入
- `cache_control` を除去（0.4.1で再導入）

### 0.3.0
- ローダーフック経由の自動トークン更新を追加
- バックグラウンドでの積極的な更新タイマー（5分間隔）

## 環境変数による上書き

すべてのOAuthパラメータは環境変数で上書き可能です。Anthropicが更新前に何か変更した場合は、環境変数を設定して作業を継続してください：

| 変数 | 説明 |
|---|---|

| `ANTHROPIC_CLIENT_ID` | OAuth クライアントID |
| `ANTHROPIC_CLI_VERSION` | User-Agent 用の Claude CLI バージョン |
| `ANTHROPIC_USER_AGENT` | フル User-Agent 文字列（バージョンを上書き） |
| `ANTHROPIC_AUTHORIZE_URL` | OAuth 認可エンドポイント |
| `ANTHROPIC_TOKEN_URL` | OAuth トークンエンドポイント |
| `ANTHROPIC_REDIRECT_URI` | OAuth リダイレクトURI |
| `ANTHROPIC_SCOPES` | OAuth スコープ |
| `ANTHROPIC_BETA_FLAGS` | Anthropic ベータ機能フラグ |

例:

```bash
export ANTHROPIC_CLI_VERSION=2.2.0
```

## 免責事項

このプラグインはAnthropicの公開OAuthクライアントIDを使用して認証します。Anthropicの利用規約（2026年2月）では、Claude Pro/Maxサブスクリプショントークンは公式のAnthropicクライアントでのみ使用することが定められています。このプラグインはコミュニティの回避策として存在しており、AnthropicがOAuthインフラを変更した場合に動作しなくなる可能性があります。自己責任でご利用ください。

## ライセンス

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-20

---
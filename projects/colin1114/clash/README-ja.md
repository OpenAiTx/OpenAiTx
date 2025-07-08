このプロジェクトのCDN加速およびセキュリティ保護は、Tencent EdgeOneによって提供されています。

[![image](https://github.com/user-attachments/assets/059fed87-d415-41b0-a575-2423bf2d77e2)](https://edgeone.ai/?from=github)

このプロジェクトの著者はcolin1114です。

# 🚀 Clash サブスクリプション変換ツール

美しく、かつ高機能なオンラインツールで、さまざまなプロキシサブスクリプションリンクをClash構成形式に変換します。Cloudflare Workers & Pagesによる自動デプロイに対応し、高速かつ信頼性の高いサブスクリプション変換サービスを提供します。

## ✨ 機能特長

- 🎨 **美しいモダンなインターフェース** - グラデーション背景とカード型デザインを採用
- 🔄 **多プロトコル対応** - V2Ray、VLESS、Shadowsocks、Trojanなど主要プロトコルをサポート
- ☁️ **クラウドデプロイ** - Cloudflare WorkersによるグローバルCDN加速
- 📱 **レスポンシブデザイン** - デスクトップとモバイル端末に完璧対応
- ⚡ **高速変換** - サブスクリプションリンクをリアルタイムでClash構成に変換
- 📋 **スマートコピー** - 生成されたYAML構成をワンクリックでコピー可能、各種ブラウザに対応
- 📡 **サブスクリプションリンク生成** - Clashに直接インポートできるサブスクリプションリンクを自動生成
- 🌐 **オンラインYAMLアクセス** - 複数のYAMLファイルアクセス方法を提供：
  - 📡 サブスクリプションリンク：Clashクライアントによる自動更新に対応
  - 🔗 オンライン閲覧：ブラウザで直接構成内容を確認
  - 💾 ファイルダウンロード：.yamlファイルをローカルにダウンロード
  - ⚡ クイックアクセス：簡易ダウンロードリンク
- 🔧 **UTF-8対応** - 中国語ノード名や構成にも完全対応
- 🆓 **完全無料** - Cloudflareの無料サービスベース、利用制限なし

## 📁 プロジェクト構成

```
clash/
├── index.html              # フロントエンドページ
├── worker.js               # Cloudflare Worker バックエンドコード
├── wrangler.jsonc          # Wrangler 設定ファイル
├── _headers                # Cloudflare Pages HTTPヘッダー設定
├── .github/
│   └── workflows/
│       └── deploy.yml      # GitHub Actions デプロイ設定
├── README.md              # プロジェクト説明ドキュメント
└── package.json           # プロジェクト設定ファイル
```

## 🚀 クイックスタート

### 方法1：ローカルで実行

1. **プロジェクトをクローン**
   ```bash
   git clone <repository-url>
   cd clash
   ```

2. **ローカルサーバーを起動**
   ```bash
   # Pythonを使用
   python -m http.server 8000
   
   # またはNode.jsを使用
   npx serve .
   ```

3. **アプリへアクセス**
   - ブラウザで `http://localhost:8000` を開く
   - ローカル環境ではサンプル構成が表示されます

### 方法2：Cloudflare Workers でデプロイ

#### ステップ1：Workerを作成

1. [Cloudflare Workers](https://workers.cloudflare.com/) にアクセス
2. Cloudflareアカウントに登録/ログイン
3. 「Create a Worker」をクリック
4. `worker.js` のコードをすべてエディタにコピー
5. 「Save and Deploy」をクリック

#### ステップ2：Wrangler CLIでデプロイ

```bash
# Wrangler CLI をインストール
npm install -g wrangler

# Cloudflare にログイン
wrangler login

# Worker をデプロイ
npm run deploy:worker
```

#### ステップ3：ドメイン設定（任意）

1. Worker設定でカスタムドメインを追加
2. またはCloudflare提供のデフォルトドメインを利用

### 方法3：Cloudflare Pages でデプロイ

#### オプションA：GitHub連携（推奨）

1. **リポジトリを準備**
   - コードをGitHubリポジトリにプッシュ
   - すべての必要ファイルを含めること
2. **Pages プロジェクトの作成**
   - [Cloudflare Pages](https://pages.cloudflare.com/) にアクセス
   - GitHub リポジトリを接続
   - プロジェクトリポジトリを選択

3. **ビルド設定**
   - ビルドコマンド：空欄または `echo "No build required"`
   - ビルド出力ディレクトリ：`/`（ルートディレクトリ）
   - 環境変数：設定不要

#### オプションB：直接アップロード

```bash
# Wrangler Pages を使ってデプロイ
npm run deploy:pages
```

## 🛠️ 技術アーキテクチャ

### フロントエンド技術スタック
- **HTML5** - モダンなマークアップ言語
- **CSS3** - レスポンシブデザインとアニメーション効果
- **Vanilla JavaScript** - 軽量なフロントエンドインタラクション

### バックエンド技術スタック
- **Cloudflare Workers** - エッジコンピューティングプラットフォーム
- **Web APIs** - 標準の Fetch API とレスポンス処理

### サポートされているプロトコル形式
- **VMess** - V2Ray 標準プロトコル
- **VLESS** - V2Ray 軽量プロトコル（Reality対応）
- **Shadowsocks** - クラシックなプロキシプロトコル
- **Trojan** - 新しいプロキシプロトコル

### API エンドポイント
- `GET /` - メインページ
- `POST /convert` - サブスクリプション変換API
- `GET /clash/{config-id}` - YAML設定ファイルの取得（サブスクリプションリンク）
- `GET /yaml/{config-id}` - YAML設定ファイルのダウンロード
- `OPTIONS /*` - CORSプリフライトリクエスト

## 📖 利用ガイド

### 基本的な使い方

1. **サブスクリプションリンクを入力**
   - プロキシサブスクリプションリンクを入力欄に貼り付ける
   - Base64エンコードされたサブスクリプションリンクもサポート

2. **設定名を指定**
   - オプションで設定ファイルにカスタム名をつけられる
   - デフォルトは "My Clash Config"

3. **設定を変換**
   - 「サブスクリプション変換」ボタンをクリック
   - 変換完了まで待機

4. **設定を利用**
   - 生成された YAML 設定をコピー
   - Clash クライアントにインポートして利用

5. **サブスクリプションリンクを利用（推奨）**
   - 生成されたサブスクリプションリンクをコピー
   - Clash クライアントにサブスクリプションとして追加
   - 設定が自動で同期、手動更新不要

### 高度な設定

生成された Clash 設定には以下の機能が含まれます：

- **プロキシグループポリシー**
  - 🚀 ノード選択 - 手動でプロキシを選択
  - ♻️ 自動選択 - レイテンシテストにより自動選択
  - 🎯 グローバル直通 - 直接接続

- **DNS 設定**
  - DNS 解決の有効化
  - fake-ip モード対応
  - 国内外 DNS の分流

- **ルーティングルール**
  - ローカルアドレスは直通
  - 国内IPは直通
  - その他トラフィックはプロキシ経由

## 🔧 デプロイ時のトラブルシューティング

### よくある質問

#### 1. Wrangler がエントリーポイントを見つけられない
**エラーメッセージ**: `Missing entry-point to Worker script`

**解決方法**: 
- プロジェクトのルートディレクトリに `wrangler.jsonc` ファイルがあることを確認
- `wrangler.jsonc` 内の `main` フィールドが `worker.js` を指しているか確認

#### 2. GitHub Actions のデプロイに失敗する
**解決方法**:
- GitHub リポジトリの設定で以下の Secrets を追加：
- `CLOUDFLARE_API_TOKEN`: Cloudflare API トークン
- `CLOUDFLARE_ACCOUNT_ID`: Cloudflare アカウントID

#### 3. Pages ビルド失敗
**解決策**:
- ビルドコマンドを空にするか、`echo "No build required"` に設定する
- ビルド出力ディレクトリが `/` になっていることを確認する

### デプロイ設定ファイルの説明

- **`wrangler.jsonc`**: Worker デプロイ用の Wrangler CLI 設定
- **`_headers`**: Cloudflare Pages 用 HTTP ヘッダー設定
- **`.github/workflows/deploy.yml`**: GitHub Actions 自動デプロイ設定

## 🔧 カスタム設定

### プロキシグループの編集

`worker.js` の `convertToClash` 関数を編集してプロキシグループをカスタマイズできます：

```javascript
'proxy-groups': [
  {
    name: '🚀 ノード選択',
    type: 'select',
    proxies: ['♻️ 自動選択', '🎯 グローバル直通', ...proxyNames]
  },
  // さらにプロキシグループを追加...
]
```

### カスタムルーティングルール

`rules` 配列を編集してカスタムルーティングルールを追加できます：

```javascript
rules: [
  'DOMAIN-SUFFIX,youtube.com,🚀 ノード選択',
  'DOMAIN-SUFFIX,local,DIRECT',
  // さらにルールを追加...
]
```

## 📊 パフォーマンス特性

- **グローバルCDN** - Cloudflareの世界中のエッジノード
- **高速応答** - 平均応答時間 < 100ms
- **高可用性** - 99.9% サービス稼働率
- **無料枠** - 1日あたり 100,000 リクエスト

## 🔒 セキュリティに関する説明

- **データプライバシー** - サブスクリプションデータは変換処理中のみ使用され、保存されません
- **HTTPS暗号化** - すべての通信はHTTPSで暗号化されます
- **オープンソース透明性** - ソースコードはすべて公開され、誰でも監査できます

## 🤝 コントリビュートガイド

Issue や Pull Request の提出を歓迎します！

1. 本リポジトリを Fork する
2. フィーチャーブランチを作成 (`git checkout -b feature/AmazingFeature`)
3. 変更をコミット (`git commit -m 'Add some AmazingFeature'`)
4. ブランチへプッシュ (`git push origin feature/AmazingFeature`)
5. Pull Request を作成

## 📝 更新履歴

### v1.1.0
- ✅ VLESSプロトコルのサポートを追加（Realityセキュアトランスポート対応）
- ✅ プロトコル互換性の向上

### v1.0.0
- ✅ 基本的なサブスクリプション変換機能
- ✅ 美しいユーザーインターフェース
- ✅ Cloudflare Workers 対応
- ✅ 複数プロトコル対応（VMess、Shadowsocks、Trojan）
- ✅ レスポンシブデザイン
- ✅ ワンクリックコピー機能

## 📞 サポート・フィードバック

ご利用中に問題やご要望がある場合は、以下の方法でご連絡ください：

1. 本READMEを参照
2. [Issue](../../issues) を提出
3. [Discussion](../../discussions) を開始

## 📄 ライセンス

本プロジェクトは MIT ライセンスで提供されています - 詳細は [LICENSE](LICENSE) ファイルを参照してください

## 🙏 謝辞

- [Cloudflare Workers](https://workers.cloudflare.com/) - エッジコンピューティングプラットフォームの提供
- [Clash](https://github.com/Dreamacro/clash) - 優秀なプロキシクライアント
- すべてのコントリビューターとユーザーのご支援

---
⭐ もしこのプロジェクトがあなたの役に立った場合は、Star を付けてください！

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---
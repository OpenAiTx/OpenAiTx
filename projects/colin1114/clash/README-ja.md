
<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

このプロジェクトのCDN高速化およびセキュリティ保護はTencent EdgeOneによって提供されています。

[![image](https://github.com/user-attachments/assets/059fed87-d415-41b0-a575-2423bf2d77e2)](https://edgeone.ai/?from=github)

このプロジェクトの作者はcolin1114です。

# 🚀 Clash サブスクリプション変換ツール

さまざまなプロキシサブスクリプションリンクをClash構成フォーマットへ変換できる、美しく高機能なオンラインツールです。Cloudflare Workers & Pagesによる自動デプロイに対応し、高速かつ信頼性の高いサブスクリプション変換サービスを提供します。

## ✨ 機能特性

- 🎨 **美しいモダンなインターフェース** - グラデーション背景とカード型デザインを採用
- 🔄 **多プロトコル対応** - V2Ray、VLESS、Shadowsocks、Trojan など主流プロトコルに対応
- ☁️ **クラウド展開** - Cloudflare Workers によりグローバルCDN加速を実現
- 📱 **レスポンシブデザイン** - デスクトップとモバイル端末に完全対応
- ⚡ **高速変換** - サブスクリプションリンクをリアルタイムでClash設定に変換
- 📋 **スマートコピー** - 生成されたYAML設定をワンクリックでコピー、各種ブラウザに対応
- 📡 **サブスクリプションリンク生成** - Clashに直接インポート可能なリンクを自動生成
- 🌐 **オンラインYAMLアクセス** - 様々なYAMLファイルのアクセス方法を提供：
  - 📡 サブスクリプションリンク：Clashクライアントの自動更新をサポート
  - 🔗 オンライン閲覧：ブラウザで設定内容を直接表示
  - 💾 ファイルダウンロード：.yamlファイルをローカルに保存
  - ⚡ クイックアクセス：簡易化されたダウンロードリンク
- 🔧 **UTF-8サポート** - 中国語ノード名や設定も完全対応
- 🆓 **完全無料** - Cloudflareの無料サービスを基盤とし、利用制限なし

## 📁 プロジェクト構成

```
clash/
├── index.html              # 前端页面
├── worker.js               # Cloudflare Worker 后端代码
├── wrangler.jsonc          # Wrangler 配置文件
├── _headers                # Cloudflare Pages HTTP头配置
├── .github/
│   └── workflows/
│       └── deploy.yml      # GitHub Actions 部署配置
├── README.md              # 项目说明文档
└── package.json           # 项目配置文件
```

## 🚀 クイックスタート

### 方法1：ローカルで実行

1. **プロジェクトをクローンする**
   ```bash
   git clone <repository-url>
   cd clash
   ```

2. **ローカルサーバーを起動する**
   ```bash
   # 使用 Python
   python -m http.server 8000
   
   # 或使用 Node.js
   npx serve .
   ```

3. **アプリケーションへのアクセス**
   - ブラウザで `http://localhost:8000` にアクセスします
   - ローカル環境ではサンプル設定が表示されます

### 方法二：Cloudflare Workers でのデプロイ

#### ステップ1：Worker の作成

1. [Cloudflare Workers](https://workers.cloudflare.com/) にアクセスします
2. Cloudflare アカウントに登録/ログインします
3. 「Create a Worker」をクリックします
4. `worker.js` のコードをエディタに全てコピーします
5. 「Save and Deploy」をクリックします

#### ステップ2：Wrangler CLI でのデプロイ

```bash
# 安装 Wrangler CLI
npm install -g wrangler

# 登录到 Cloudflare
wrangler login

# 部署 Worker
npm run deploy:worker
```

#### ステップ3：ドメインの設定（任意）

1. Workerの設定でカスタムドメインを追加する
2. またはCloudflareが提供するデフォルトドメインを使用する

### 方法3：Cloudflare Pagesによるデプロイ

#### オプションA：GitHub連携（推奨）

1. **リポジトリの準備**
   - コードをGitHubリポジトリへプッシュする
   - 必要なすべてのファイルが含まれていることを確認する

2. **Pagesプロジェクトの作成**
   - [Cloudflare Pages](https://pages.cloudflare.com/)へアクセス
   - GitHubリポジトリを接続する
   - プロジェクトリポジトリを選択する

3. **ビルド設定**
   - ビルドコマンド：空欄または `echo "No build required"`
   - ビルド出力ディレクトリ：`/`（ルートディレクトリ）
   - 環境変数：設定不要

#### オプションB：直接アップロード

```bash
# 使用 Wrangler Pages 部署
npm run deploy:pages
```

## 🛠️ 技術アーキテクチャ

### フロントエンド技術スタック
- **HTML5** - 最新のマークアップ言語
- **CSS3** - レスポンシブデザインとアニメーション効果
- **Vanilla JavaScript** - 軽量なフロントエンドインタラクション

### バックエンド技術スタック
- **Cloudflare Workers** - エッジコンピューティングプラットフォーム
- **Web APIs** - 標準の Fetch API とレスポンス処理

### サポートされるプロトコル形式
- **VMess** - V2Ray 標準プロトコル
- **VLESS** - V2Ray 軽量プロトコル（Reality対応）
- **Shadowsocks** - クラシックなプロキシプロトコル
- **Trojan** - 新興のプロキシプロトコル

### APIエンドポイント
- `GET /` - メインページ
- `POST /convert` - サブスクリプション変換API
- `GET /clash/{config-id}` - YAML設定ファイル取得（サブスクリプションリンク）
- `GET /yaml/{config-id}` - YAML設定ファイルダウンロード
- `OPTIONS /*` - CORSプリフライトリクエスト

## 📖 利用ガイド

### 基本的な使い方

1. **サブスクリプションリンクの入力**
   - プロキシサブスクリプションリンクを入力欄に貼り付け
   - Base64エンコードされたサブスクリプションリンクに対応

2. **設定ファイル名の設定**
   - 任意で設定ファイルにカスタム名を付与可能
   - デフォルトは "My Clash Config"

3. **設定の変換**
   - "サブスクリプション変換" ボタンをクリック
   - 変換完了まで待機
4. **設定の利用**
   - 生成された YAML 設定をコピー
   - Clash クライアントにインポートして使用

5. **サブスクリプションリンクの利用（推奨）**
   - 生成されたサブスクリプションリンクをコピー
   - Clash クライアントでサブスクリプションを追加
   - 設定が自動的に同期され、手動更新不要

### 高度な設定

生成された Clash 設定には以下の特徴があります：

- **プロキシグループポリシー**
  - 🚀 ノード選択 - プロキシを手動で選択
  - ♻️ 自動選択 - レイテンシテストによる自動選択
  - 🎯 グローバル直通 - 直接接続

- **DNS 設定**
  - DNS 解決を有効化
  - fake-ip モード対応
  - 国内外 DNS 分岐

- **ルーティングルール**
  - ローカルアドレスは直通
  - 国内 IP は直通
  - その他の通信はプロキシ経由

## 🔧 デプロイのトラブルシューティング

### よくある問題

#### 1. Wrangler がエントリーポイントを見つけられない
**エラーメッセージ**: `Missing entry-point to Worker script`

**解決策**: 
- プロジェクトのルートディレクトリに `wrangler.jsonc` ファイルがあることを確認
- `wrangler.jsonc` の `main` フィールドが `worker.js` を指しているか確認


#### 2. GitHub Actions のデプロイ失敗
**解決策**:
- GitHub リポジトリの設定で以下の Secrets を追加してください:
  - `CLOUDFLARE_API_TOKEN`: Cloudflare API トークン
  - `CLOUDFLARE_ACCOUNT_ID`: Cloudflare アカウント ID

#### 3. Pages のビルド失敗
**解決策**:
- ビルドコマンドを空、または `echo "No build required"` に設定してください
- ビルド出力ディレクトリを `/` に設定してください

### デプロイ設定ファイルの説明

- **`wrangler.jsonc`**: Wrangler CLI の設定、Worker デプロイ用
- **`_headers`**: Cloudflare Pages の HTTP ヘッダー設定
- **`.github/workflows/deploy.yml`**: GitHub Actions の自動デプロイ設定

## 🔧 カスタム設定

### プロキシグループの編集

`worker.js` の `convertToClash` 関数を編集することでプロキシグループをカスタマイズできます：

```javascript
'proxy-groups': [
  {
    name: '🚀 节点选择',
    type: 'select',
    proxies: ['♻️ 自动选择', '🎯 全球直连', ...proxyNames]
  },
  // 添加更多代理组...
]
```

### カスタムルーティングルール

`rules` 配列を変更してカスタムルーティングルールを追加します：

```javascript
rules: [
  'DOMAIN-SUFFIX,youtube.com,🚀 节点选择',
  'DOMAIN-SUFFIX,local,DIRECT',
  // 添加更多规则...
]
```

## 📊 パフォーマンス特性

- **グローバルCDN** - Cloudflareの世界中に広がるエッジノード
- **高速応答** - 平均応答時間 < 100ms
- **高可用性** - 99.9% サービス稼働率
- **無料枠** - 1日あたり 100,000 リクエスト

## 🔒 セキュリティ情報

- **データプライバシー** - サブスクリプションデータは変換処理時のみ使用され、保存されません
- **HTTPS暗号化** - すべての通信はHTTPSで暗号化
- **オープンソース透明性** - 完全なソースコードを公開、自主監査可能

## 🤝 コントリビューションガイド

IssueやPull Requestの提出を歓迎します！

1. このリポジトリをForkする
2. 機能ブランチを作成 (`git checkout -b feature/AmazingFeature`)
3. 変更をコミットする (`git commit -m 'Add some AmazingFeature'`)
4. ブランチにプッシュする (`git push origin feature/AmazingFeature`)
5. Pull Requestを作成する

## 📝 更新履歴

### v1.1.0
- ✅ VLESSプロトコル対応を追加（Realityセキュア転送含む）
- ✅ プロトコル互換性の改善

### v1.0.0
- ✅ 基本的なサブスクリプション変換機能
- ✅ 美しいユーザーインターフェース
- ✅ Cloudflare Workers対応
- ✅ 複数プロトコル対応（VMess、Shadowsocks、Trojan）
- ✅ レスポンシブデザイン
- ✅ ワンクリックコピー機能

## 📞 サポートとフィードバック

もしご利用中に問題が発生したり、ご提案がある場合は、以下の方法をご利用ください：

1. 本 README ドキュメントを参照してください
2. [Issue](../../issues) を提出してください
3. [Discussion](../../discussions) を開始してください

## 📄 ライセンス

本プロジェクトは MIT ライセンスを採用しています - 詳細は [LICENSE](LICENSE) ファイルをご覧ください

## 🙏 謝辞

- [Cloudflare Workers](https://workers.cloudflare.com/) - エッジコンピューティングプラットフォームの提供
- [Clash](https://github.com/Dreamacro/clash) - 優れたプロキシクライアント
- 全ての貢献者とユーザーのご支援

---

⭐ このプロジェクトが役に立った場合は、ぜひ Star を付けてください！ 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-06

---
# Minecraft サーバー Web 管理パネル

**[中文版本 (Chinese Version)](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/README_CN.md)**

モダンなUIと包括的なサーバー管理機能を備えた**軽量**なMinecraftサーバーのWeb管理パネル。

**現在対応しているサーバー:**
- ✅ Minecraft Bedrock サーバー
- Minecraft Java サーバー

## 🚀 機能

### 🌍 Minecraft サーバーダウンロード
- **サーバーダウンロード** 管理ページから特定のサーバーバージョンを直接ダウンロード可能
- **サーバーバージョン切り替え** ワンクリックでサーバーバージョンを切り替え可能

### 🎮 サーバーコントロール
- **ワンクリックで開始/停止/再起動** Minecraft Bedrock サーバー
- **リアルタイムステータス監視** サーバーの稼働状況を表示

### ⚙️ 設定管理
- **主要な設定オプションすべてに対応**:
  - サーバー名と説明
  - ゲームモード（サバイバル/クリエイティブ/アドベンチャー）
  - 難易度設定（平和/簡単/通常/難しい）
  - 最大プレイヤー数
  - サーバーポート設定
  - チートとホワイトリストの切り替え
- **サーバー設定ファイル管理** `server.properties` ファイルを自動で管理

### 👥 ホワイトリスト管理
- **プレイヤー追加/削除** サーバーに参加可能なプレイヤーリストを管理
- **ホワイトリストファイル管理** `allowlist.json` ファイルを自動で管理

### 🛡️ 権限管理
- **三層の権限システム**:
  - **ビジター** - 基本的なゲーム権限
  - **メンバー** - 標準的なプレイヤー権限
  - **オペレーター** - 完全な管理者権限
- **プレイヤー権限設定** 特定のプレイヤーに権限レベルを割り当て
- **権限ファイル管理** `permissions.json` ファイルを自動的に管理

### 🌍 ワールド管理
- **ワールドファイルアップロード** `.zip` および `.mcworld` 形式をサポートし、自動展開
- **ワールド切り替え** ワンクリックで異なるワールドを有効化
- **ワールド削除** 不要なワールドファイルを安全に削除
- **現在のワールド識別** 現在アクティブなワールドを明確に表示

### 🌍 リソースパック管理
- **リソースファイルアップロード** `.zip` および `.mcpack` 形式をサポート
- **リソース有効化** ワンクリックで異なるリソースパックを有効化
- **リソース削除** 不要なリソースパックを安全に削除

### 📋 サーバーログ
- **リアルタイムログ閲覧** WebインターフェースでMinecraftサーバーのログをリアルタイム監視
- **自動スクロール** 最新のログエントリに自動スクロールするオプション

### 💻 コマンド実行
- **直接コマンド入力** WebインターフェースからMinecraftサーバーコマンドを直接実行
- **コマンド履歴** 過去に実行したコマンドを閲覧および再利用
- **クイックコマンド** カテゴリ別のクイックアクセスボタンで頻繁に使用するコマンドにアクセス

### 🔐 認証とセキュリティ
- **ログインシステム** パスワード認証による管理パネルへの安全なアクセス
- **セッション管理** セキュアなトークンベース認証による自動セッション管理
- **アクセス制御** 不正アクセスからサーバー管理機能を保護

## 📋 システム要件

### サーバー環境
- **オペレーティングシステム**: Windows 10以降 または Ubuntu 18.04以降（Linux）
- **メモリ**: 最低2GB RAM
- **ストレージ**: 最低10GBの空き容量
- **ネットワーク**: ポート8080（管理パネル）および19132（Minecraftサーバー）を開放

## 🛠️ インストールガイド

### クイックスタート（推奨）


1. **事前ビルド済みリリースのダウンロード**:
   - ご使用のオペレーティングシステムに適したバージョンを[Releases](https://github.com/ckfanzhe/bedrock-easy-server/releases)ページからダウンロードしてください
   - Windows用は`minecraft-server-manager-windows.exe`
   - Linux用は`minecraft-server-manager-linux`

2. **アプリケーションの実行**:

   ```bash
   # For Linux
   chmod +x minecraft-server-manager-linux
   ./minecraft-server-manager-linux
   
   # For Windows
   minecraft-server-manager-windows.exe
   ```

### Docker デプロイメント

1. **Dockerを直接使用する（推奨）**:
   ```bash
   # Create data directory for persistent storage
   mkdir -p data
   
   # Run the container using the published image
   docker run -d \
     --name minecraft-easyserver \
     -p 8080:8080 \
     -p 19132:19132/udp \
     -p 19133:19133/udp \
     -v ./data:/data/bedrock-server \
     -v ./config:/data/config \
     ifanzhe/minecraft-easyserver:latest
   ```

2. **Docker Composeの使用**:
   ```bash
   # Create docker-compose.yml file
   cat > docker-compose.yml << EOF
   version: '3.8'
   services:
     minecraft-server-manager:
       image: ifanzhe/minecraft-easyserver:latest
       container_name: minecraft-easyserver
       ports:
         - "8080:8080"
         - "19132:19132/udp"
         - "19133:19133/udp"
       volumes:
         - ./data:/data/bedrock-server
         - ./config:/data/config
       environment:
         - TZ=Asia/Shanghai
       restart: unless-stopped
       healthcheck:
         test: ["CMD", "curl", "-f", "http://localhost:8080"]
         interval: 30s
         timeout: 10s
         retries: 3
   EOF
   
   # Start with Docker Compose
   docker-compose up -d
   ```

3. **アプリケーションにアクセス**:
   - ブラウザを開き、`http://localhost:8080`にアクセス
   - サーバーデータは`./data`ディレクトリに保存されます

### ソースからビルド（開発者向け）

1. **前提条件**: 
   - Go 1.21以上
   - Node.js 16+およびnpm（フロントエンドのコンパイル用）

2. **リポジトリをクローン**:
   ```bash
   git clone https://github.com/ckfanzhe/bedrock-easy-server.git
   cd minecraft-easy-server
   ```

3. **すべてのプラットフォームをビルド（推奨）**:
   ```bash
   chmod +x build.sh
   ./build.sh
   ```
   このスクリプトは以下を実行します：
   - フロントエンドの依存関係をインストールします（`npm install`）
   - Vue.js フロントエンドをビルドします（`npm run build`）
   - ビルドされたアセットを埋め込みディレクトリにコピーします
   - 埋め込みフロントエンドを含むすべてのプラットフォーム向けのGoバイナリをコンパイルします

4. **手動ビルド手順**（ステップバイステップを好む場合）：
   ```bash
   # Build frontend first
   cd minecraft-easyserver-web
   npm install
   npm run build
   cd ..
   
   # Copy frontend build output
   rm -rf web/*
   cp -r minecraft-easyserver-web/dist/* web/
   
   # Build Go binary
   go build -o minecraft-server-manager
   ```

**注意**: ビルドプロセスには現在、webpackを使用したフロントエンドのコンパイルが含まれており、これによりすべてのVue.jsコンポーネント、スタイル、およびアセットが最適化されたファイルにバンドルされ、それらがGoバイナリに埋め込まれて単一ファイルでのデプロイが可能になります。

## 🚀 使用ガイド

### 管理パネルの起動

1. **アプリケーションを実行する**:
   ```bash
   # For Linux
   ./minecraft-server-manager-linux
   
   # For Windows double-click to run
   minecraft-server-manager-windows.exe
   ```

2. **アクセス管理インターフェース**:
   - ブラウザを開き、次のURLにアクセスします: `http://localhost:8080`
   - 管理パネルが自動的に読み込まれます

## 🔥 ファイアウォール設定

### Windowsファイアウォール
一部のシステムでは、サーバーと同じマシン上で実行されているクライアントからサーバーに接続する場合、MinecraftクライアントをUWPループバック制限から除外する必要があります:

```powershell
CheckNetIsolation.exe LoopbackExempt -a -p=S-1-15-2-1958404141-86561845-1752920682-3514627264-368642714-62675701-733520436
```
ファイアウォールで以下のポートが開いていることを確認してください：
- **8080**: 管理パネルアクセス用ポート
- **19132**: Minecraft Bedrockサーバーのデフォルトポート
- **19133**: Minecraft BedrockサーバーのIPv6ポート

## 📝 追加情報

### TODO 計画中の機能
- ✅ ワンクリックmcpackageモッドインポート対応
- ✅ Linuxオペレーティングシステムサポート
- ✅ Bedrockサーバーのリアルタイムログ表示
- ✅ Webインターフェース経由でのBedrockサーバー直接コマンド実行
- 🔄 プレイヤーのオンライン状態監視
- ✅ サーバーパフォーマンス監視
- 🔄 自動ワールドバックアップ機能
- ✅ 多言語インターフェース対応
- 🔄 Javaサーバーサポート - Minecraft Java Editionサーバー対応
- ✅ Dockerサポート - コンテナ化されたデプロイ対応

## 🤝 貢献について

問題報告、機能提案、コード貢献を歓迎します！

### 開発環境のセットアップ
1. プロジェクトリポジトリをフォークする
2. 新機能ブランチを作成する：`git checkout -b feature/new-feature`
3. 変更をコミットする：`git commit -am 'Add new feature'`
4. ブランチをプッシュする：`git push origin feature/new-feature`
5. プルリクエストを作成する

### コード規約
- Goの標準コードフォーマットを使用する
- 適切なコメントとドキュメントを追加する
- テストに合格するコードを書く
- プロジェクトのアーキテクチャパターンに従う

## 📄 ライセンス

このプロジェクトはMITライセンスのもとでライセンスされています。詳細は[LICENSE](LICENSE)ファイルを参照してください。


## 🙏 謝辞

- [Gin Web Framework](https://gin-gonic.com/) - 高性能なGoウェブフレームワーク
- [Tailwind CSS](https://tailwindcss.com/) - ユーティリティファーストのCSSフレームワーク
- [Font Awesome](https://fontawesome.com/) - アイコンライブラリ
- [Minecraft Bedrock](https://www.minecraft.net/) - ゲームサーバー

## 👀 管理パネルプレビュー
> いくつかの機能のスクリーンショットです。その他の機能は実際に体験してみてください。

![Login Panel Preview](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/resources/en-login.png)
![Dashboard Panel Preview](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/resources/en-dashboard.png)
![Performance Panel Preview](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/resources/en-performance.png)
![Server Download Panel Preview](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/resources/en-version.png)
![Resource Panel Preview](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/resources/en-resource.png)
![Worlds Panel Preview](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/resources/en-worlds.png)
![Cmd Panel Preview](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/resources/en-cmd.png)
![Server Config Panel Preview](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/resources/en-server-config.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-05

---
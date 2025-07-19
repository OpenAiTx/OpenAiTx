![icon](https://raw.githubusercontent.com/totovr46/fastdock/main/Icon2Nobg.png)

# Fastdock

シンプルでモダンなデザインのWebベースDockerコンテナ管理インターフェースです。このアプリケーションは、美しいWebインターフェースを通じて、外出先でもDockerコンテナを素早く直感的に起動・停止する方法を提供します。

🎯 [ライブデモ](https://fastdock.salvatoremusumeci.com)

![Fastdock Interface](https://raw.githubusercontent.com/totovr46/fastdock/main/fast-demo.png)
![Fastdock iOS Interface](https://raw.githubusercontent.com/totovr46/fastdock/main/iphone.png)

## ⚠️ セキュリティ注意

**このアプリケーションは内部利用のみを目的としており、VPNの背後または安全なネットワーク環境で展開する必要があります。**

* 認証や認可機構はありません
* Dockerデーモンへの直接アクセス
* 高度な検証なしのファイルアップロード機能
* 開発・ステージング環境向けに適しています

## ✨ 特徴

* **リアルタイムコンテナ管理**：Dockerコンテナの起動と停止
* **マルチサーバ管理**：単一インターフェースで複数サーバのDockerコンテナを管理
* **サーバセレクタ**：ローカルとリモートサーバ間を迅速に切り替え
* **サーバ追加/編集/削除**：カスタム名、アドレス、ポートでリモートサーバを設定
* **サーバ認識表示**：コンテナカードに所属サーバを表示
* **カスタムコンテナアイコン**：視覚的識別のためのカスタムアイコンアップロード
* **コンテナ名変更**：コンテナにカスタム名を割り当て
* **レスポンシブデザイン**：デスクトップ、タブレット、モバイルでシームレスに動作

## 🚀 クイックスタート

### 前提条件

* Node.js >= 16.0.0
* Dockerデーモンが稼働中
* Dockerソケットにアクセス可能（`/var/run/docker.sock`）

### インストール

1. **リポジトリをクローン**

```bash
git clone https://github.com/totovr46/fastdock.git
cd fastdock
```
2. **依存関係のインストール**


```bash
npm install
```
3. **アプリケーションを起動する**


```bash
npm start
```
4. **インターフェースにアクセスする**  
   ブラウザを開き、`http://serverIP:3080` にアクセスします  

## 📋 API エンドポイント  

### コンテナ操作  

* `GET /api/containers` - 選択されたサーバー上の全コンテナを一覧表示  
* `POST /api/containers/:id/start` - コンテナを起動する  
* `POST /api/containers/:id/stop` - コンテナを停止する  
* `GET /api/containers/name/:name` - 名前でコンテナを検索する  

### コンテナ設定  

* `POST /api/containers/settings/:id` - コンテナの設定を更新する（名前、アイコン）  
* `GET /api/containers/settings` - 全コンテナの設定を取得する  

### サーバー管理  

* `GET /api/servers` - 設定済みのリモートサーバーを一覧表示  
* `POST /api/servers` - 新しいサーバーを追加する  
* `PUT /api/servers/:id` - 既存のサーバーを編集する  
* `DELETE /api/servers/:id` - サーバーを削除する  

## 🛠️ 開発  

### プロジェクト構成  


```
fastdock/
├── server.js                  # Main server file
├── package.json              # Dependencies and scripts
├── public/
│   ├── index.html            # Main web interface
│   ├── assets/               # Uploaded container icons
│   ├── containerSettings.json # Container customization data
│   └── servers.json          # Stored remote server configurations
└── README.md
```
## 🔧 設定

### 環境変数

* `PORT` - サーバーポート（デフォルト：3080）、server.jsファイル内でお好みに応じて変更できます

### Dockerソケット

アプリケーションはDockerソケットへのアクセスを必要とします。Dockerが起動していて、ソケットにアクセス可能であることを確認してください：

**Linux/macOS:**


```bash
ls -la /var/run/docker.sock
```
**Windows (WSL):**


```bash
# Ensure Docker Desktop is running
docker ps
```
## 🚦 使用方法

### 基本操作

1. **サーバー選択**: ドロップダウンメニューでローカルまたはリモートサーバーを選択
2. **コンテナ表示**: 選択したサーバーのすべてのコンテナを表示
3. **開始/停止**: ボタンで通常通りコンテナを管理
4. **コンテナ編集**: 鉛筆アイコンをクリックして名前やアイコンを変更

### コンテナのカスタマイズ

1. 任意のコンテナカードの編集アイコン（鉛筆）をクリック
2. カスタムアイコンをアップロード（画像ファイルのみ）
3. 識別しやすいカスタム名を設定
4. 「保存」をクリックして変更を適用

### サーバー管理

1. サーバーセレクタのドロップダウンをクリック
2. 「サーバー追加」を選択して新しいリモートDockerサーバーを設定
3. 編集または削除オプションで既存のサーバーを管理
4. サーバーデータは保存され、起動時に自動読み込みされる

### ステータスインジケーター

* 🟢 **緑**: コンテナが稼働中
* 🔴 **赤**: コンテナが停止中

## 🔐 セキュリティ上の考慮事項

### ネットワークセキュリティ

* **VPNの背後に配置**: アプリケーションは安全なVPN接続経由のみでアクセス可能にする
* **内部ネットワーク**: 信頼できる内部ネットワーク内のみで使用

### ファイルアップロードのセキュリティ

* コンテナアイコンには画像ファイルのみ許可
* ファイルは `public/assets/` ディレクトリに保存される

### Dockerアクセス

* アプリはDockerソケットアクセスを必要とする
* すべてのVPNユーザーは完全なコンテナ管理機能を持つ
* Dockerソケットのセキュリティベストプラクティスを考慮

## 🚨 制限事項

* **ユーザー認証なし**: すべてのユーザーは同じアクセスレベル
* **監査ログなし**: コンテナ操作はログに記録されない
* **ローカルストレージ**: 設定はローカルのJSONファイルに保存
* **単一インスタンス**: マルチインスタンス展開には対応していない

## 🛌 マルチサーバー対応

**v1.1.0**より、FastDockは複数Dockerホストのコンテナ管理をサポート。主なポイント:

* カスタム名、アドレス、ポートでサーバーを追加可能
* ドロップダウンセレクターでサーバー間を切り替え
* サーバーごとにコンテナを表示・管理
* 各コンテナに所属サーバーを表示
* 単一サーバー設定との完全な互換性
* サーバーリストと設定はローカルに保存

## 🤝 コントリビューション

1. リポジトリをフォーク
2. フィーチャーブランチを作成 (`git checkout -b feature/amazing-feature`)
3. 変更をコミット (`git commit -m 'Add amazing feature'`)
4. ブランチをプッシュ (`git push origin feature/amazing-feature`)
5. プルリクエストを作成

---

**⚠️ 重要**: 本アプリケーションはDockerコンテナへの直接アクセスを提供します。信頼できるユーザーの安全かつ管理された環境でのみ使用してください。
![icon](https://raw.githubusercontent.com/totovr46/fastdock/main/Icon.png)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---
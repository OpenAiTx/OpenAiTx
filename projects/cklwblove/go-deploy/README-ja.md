# Go-Deploy 部署ツール

Go言語で開発された自動化デプロイツールであり、SFTPプロトコルを使用してローカルのビルド成果物をリモートサーバーにアップロードすることができます。

## 機能特徴

- ✅ **安全な転送**：SFTPプロトコルを使用し、SSHによる暗号化転送
- ✅ **ディレクトリ同期**：ディレクトリ構造を再帰的にアップロードし、ファイル階層を保持
- ✅ **自動作成**：リモートディレクトリ構造を自動で作成
- ✅ **パス自動適応**：実行ファイルの位置に基づいてローカルパスを自動計算、実行ディレクトリを気にする必要なし
- ✅ **設定ファイル対応**：JSON設定ファイル対応で、異なる環境の設定を簡単に管理
- ✅ **ファイル除外**：ワイルドカードパターンで不要なファイルを除外可能
- ✅ **自動バックアップ**：アップロード前にリモートファイルを自動でバックアップ
- ✅ **リトライ機構**：アップロード失敗時に自動で再試行し、成功率を向上
- ✅ **詳細な統計**：アップロードファイル数、転送サイズ、所要時間、速度を表示
- ✅ **進捗表示**：アップロード進捗とファイル情報をリアルタイムで表示
- ✅ **エラー処理**：充実したエラー処理とログ出力

## システム要件

- Go 1.18 以上
- 対象サーバーがSSH/SFTPプロトコルをサポートしていること

## インストール手順

### 1. プロジェクトをクローン

```bash
git clone <your-repo-url>
cd go-deploy
```

### 2. Goモジュール初期化

```bash
go mod init go-deploy
go mod tidy
```

### 3. 依存パッケージのインストール

プログラムは以下の依存パッケージを自動でダウンロードします：

- `github.com/pkg/sftp` - SFTPクライアント
- `golang.org/x/crypto/ssh` - SSHクライアント

## 設定説明

プログラムは2種類の設定方法に対応しています：

### 1. 設定ファイルの使用（推奨）

`config.example.json` を `config.json` にコピーし、設定を編集します：

```bash
cp config.example.json config.json
```

その後、`config.json` を編集：

```json
{
  "server": {
    "host": "your-server-ip",
    "port": 22,
    "username": "your-username",
    "password": "your-password",
    "timeout": 10
  },
  "paths": {
    "local": "../../unpackage/dist/build/web",
    "remote": "/opt/your-path/dist"
  },
  "options": {
    "backup": true,
    "backup_suffix": ".backup",
    "exclude_patterns": [
      "*.log",
      "*.map",
      ".DS_Store",
      "node_modules"
    ],
    "max_retries": 3,
    "chunk_size": 1048576
  }
}
```

#### 設定項目の説明

**server 設定**：

- `host`: SSHサーバーアドレス
- `port`: SSHポート（通常22）
- `username`: SSHユーザー名
- `password`: SSHパスワード（本番環境では鍵認証を推奨）
- `timeout`: 接続タイムアウト（秒）

**paths 設定**：

- `local`: ローカルディレクトリパス（相対パス・絶対パス対応）
- `remote`: リモートディレクトリパス（絶対パス必須）

**options 設定**：

- `backup`: アップロード前に既存リモートファイルをバックアップするか
- `backup_suffix`: バックアップファイルの接尾辞（カスタム可、バックアップファイルがなければスキップ）
- `exclude_patterns`: 除外ファイルパターン（ワイルドカード可）
- `max_retries`: アップロード失敗時の最大再試行回数
- `chunk_size`: ファイル転送ブロックサイズ（バイト単位、未実装）

### 2. デフォルト設定（互換モード）

`config.json` ファイルがない場合、プログラムは組み込みのデフォルト設定を使用し、後方互換性を保持します。

#### 設定ファイルの優先順位

1. **コマンドラインで指定した設定ファイル**：`--config` パラメータで指定
2. **デフォルト設定ファイル**：カレントディレクトリの `config.json`
3. **組み込みデフォルト設定**：上記が存在しない場合、プログラム内の設定を使用

#### パス処理ルール

- **設定ファイルパス**：

  - 相対パス：実行ファイルのあるディレクトリ基準
  - 絶対パス：指定されたパスをそのまま使用
- **ローカルディレクトリパス**：

  - 相対パス：実行ファイルのあるディレクトリ基準
  - 絶対パス：指定されたパスをそのまま使用

## 実行方法

### コマンドラインパラメータ

プログラムは以下のコマンドラインパラメータをサポートします：

```bash
# ヘルプ情報を表示
./deploy --help

# バージョン情報を表示  
./deploy --version

# デフォルト設定ファイル config.json を使用
./deploy

# 指定した設定ファイルを使用
./deploy --config prod.json

# 絶対パスの設定ファイルを使用
./deploy --config /path/to/config.json
```

### 開発環境での実行

```bash
# デフォルト設定で実行
go run main.go

# 指定した設定ファイルで実行
go run main.go --config test.json

# ヘルプを表示
go run main.go --help
```

### ビルド後の実行

```bash
# ビルド
go build -o deploy main.go

# デフォルト設定で実行
./deploy

# 指定した設定ファイルで実行
./deploy --config prod.json
```

## パッケージング手順

### 1. ローカルプラットフォームでのパッケージング

```bash
# 現在のプラットフォーム用に実行ファイルをビルド
go build -o deploy main.go
```

### 2. クロスプラットフォームパッケージング

#### Linux 64bit

```bash
GOOS=linux GOARCH=amd64 go build -o deploy-linux-amd64 main.go
```

#### Windows 64bit
```bash
GOOS=windows GOARCH=amd64 go build -o deploy-windows-amd64.exe main.go
```

#### macOS 64ビット

```bash
GOOS=darwin GOARCH=amd64 go build -o deploy-darwin-amd64 main.go
```

#### macOS ARM64 (M1/M2)

```bash
GOOS=darwin GOARCH=arm64 go build -o deploy-darwin-arm64 main.go
```

### 3. パッケージ最適化（ファイルサイズの削減）

```bash
# デバッグ情報とシンボルテーブルの除去
go build -ldflags="-s -w" -o deploy main.go

# UPXによる圧縮（事前にUPXのインストールが必要）
upx --best deploy
```

### 4. バッチビルドスクリプト

`build.sh` スクリプトを作成：

```bash
#!/bin/bash

# ビルドディレクトリの作成
mkdir -p builds

# 各プラットフォーム用バイナリのビルド
echo "Linux 64ビット版をビルド中..."
GOOS=linux GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-linux-amd64 main.go

echo "Windows 64ビット版をビルド中..."
GOOS=windows GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-windows-amd64.exe main.go

echo "macOS 64ビット版をビルド中..."
GOOS=darwin GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-darwin-amd64 main.go

echo "macOS ARM64版をビルド中..."
GOOS=darwin GOARCH=arm64 go build -ldflags="-s -w" -o builds/deploy-darwin-arm64 main.go

echo "ビルド完了！"
ls -la builds/
```

スクリプトの実行：

```bash
chmod +x build.sh
./build.sh
```

## 使用例

### ヘルプ情報の表示

```bash
$ ./deploy --help
Go-Deploy デプロイツール

使い方: ./deploy [オプション]

オプション:
  -config string
        設定ファイルパス (default "config.json")
  -help
        ヘルプ情報を表示
  -version
        バージョン情報を表示

例:
  ./deploy                           # デフォルト設定ファイル config.json を使用
  ./deploy --config prod.json        # 指定した設定ファイルを使用
  ./deploy --config /path/to/config.json  # 絶対パスの設定ファイルを使用
```

### 指定した設定ファイルを使う

```bash
$ ./deploy --config prod.json
デプロイプログラムを開始します...
設定ファイルの読み込みを試行中: /path/to/go-deploy/prod.json
設定ファイルを使用中...
ローカルディレクトリ /path/to/project/dist が存在します
SSHサーバーへ接続中...
SSHサーバーへの接続に成功
...
```

### 設定ファイルの使用

```bash
$ ./deploy
デプロイプログラムを開始します...
設定ファイルの読み込みを試行中: /path/to/go-deploy/config.json
設定ファイルを使用中...
ローカルディレクトリ /path/to/project/unpackage/dist/build/web が存在します
SSHサーバーへ接続中...
SSHサーバーへの接続に成功
SFTPクライアントを作成中...
SFTPクライアントの作成に成功
リモートディレクトリへのアップロード準備: /opt/xsoft/nginx/html/app/dist
ディレクトリアップロード開始...
ローカルディレクトリの走査を開始: /path/to/project/unpackage/dist/build/web
ディレクトリ作成: /opt/xsoft/nginx/html/app/dist
ファイル static/js/app.js.map は除外され、アップロードをスキップ
バックアップ作成: /opt/xsoft/nginx/html/app/dist/index.html -> /opt/xsoft/nginx/html/app/dist/index.html.backup
ファイルアップロード: /path/to/project/unpackage/dist/build/web/index.html -> /opt/xsoft/nginx/html/app/dist/index.html
ファイル .DS_Store は除外され、アップロードをスキップ
ファイルアップロード: /path/to/project/unpackage/dist/build/web/static/css/app.css -> /opt/xsoft/nginx/html/app/dist/static/css/app.css
アップロード失敗（試行 1/3）：ネットワークエラー
ファイル再アップロード（2/3）: /path/to/project/unpackage/dist/build/web/static/js/app.js
ファイルアップロード: /path/to/project/unpackage/dist/build/web/static/js/app.js -> /opt/xsoft/nginx/html/app/dist/static/js/app.js
...
ディレクトリアップロード成功！
統計情報:
  - アップロードファイル数: 485
  - ディレクトリ作成数: 18
  - 転送サイズ: 25.8 MB
  - アップロード所要時間: 38.5s
  - 総所要時間: 39.2s
  - 転送速度: 0.67 MB/s
```

## 注意事項

1. **セキュリティ**：

   - 本番環境ではパスワード認証ではなくSSH鍵認証の利用を推奨
   - 現在 `ssh.InsecureIgnoreHostKey()` を使用、本番環境ではホスト鍵を検証すること
2. **ネットワーク**：

   - ローカルからターゲットサーバーの22番ポートへアクセス可能であることを確認
   - 転送速度はネットワーク帯域とサーバー性能に依存
3. **権限**：

   - SSHユーザーがターゲットディレクトリへの書き込み権限を持つことを確認
   - 必要に応じてsudo権限が必要な場合あり
4. **パス**：

   - ローカルパスは実行ファイルの場所から自動計算され、実行ディレクトリを気にする必要なし
   - リモートパスは絶対パスを使用

## トラブルシューティング

### よくある問題

1. **接続タイムアウト**

   ```
   SSHサーバーへの接続失敗: dial tcp: i/o timeout
   ```

   - サーバーのアドレスとポートを確認
   - ネットワーク接続を確認
   - ファイアウォール設定を確認
2. **認証失敗**

   ```
   ログイン失敗: ssh: handshake failed
   ```

   - ユーザー名とパスワードを確認
   - SSHサービスが起動しているか確認
   - SSH設定を確認
3. **権限エラー**

   ```
   ディレクトリ作成失敗: permission denied
   ```

   - ユーザーがターゲットディレクトリへの書き込み権限を持つか確認
   - sudo利用やディレクトリ所有者変更が必要な場合あり
4. **ローカルディレクトリが存在しない**

   ```
   エラー: ローカルディレクトリ /path/to/unpackage/dist/build/web が存在しません
   ```

   - ローカルビルドが完了しているか確認
   - プロジェクトのディレクトリ構成を確認
   - プログラムが自動でパスを計算するため、作業ディレクトリの手動調整は不要

## 開発ガイド

### プロジェクト構成

```
go-deploy/
├── main.go                 # メインプログラムファイル
├── go.mod                  # Goモジュールファイル  
├── go.sum                  # 依存チェックサムファイル
```
├── README.md               # 詳細説明ドキュメント  
├── Makefile                # ビルドツール  
├── build.sh                # 一括パッケージ化スクリプト  
├── install.sh              # ワンクリックインストールスクリプト  
└── config.example.json     # 設定ファイルサンプル  
```

### 主な関数

- `main()` - メイン関数、接続の処理とアップロードの呼び出し
- `uploadDirectory()` - ディレクトリの再帰的アップロード
- `uploadFile()` - 単一ファイルのアップロード
- `mkdirAll()` - リモートディレクトリの再帰的作成

## ライセンス

MIT License

## 貢献

IssueやPull Requestの提出を歓迎します！

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---
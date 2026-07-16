# 剪存 - 剪贴板历史管理工具

Wails + Vue 3 + TypeScript に基づくマルチプラットフォーム対応のクリップボード履歴管理ツール。

## App Storeで公開中
https://apps.apple.com/us/app/剪存/id6754015301

## 機能特徴
- [カスタムスクリプト新規追加 - クリックして確認](https://raw.githubusercontent.com/snsogbl/clip-save/main/scriptingExample/README.md)
- クリップボード履歴を自動保存
- テキスト、画像、ファイルなど多様なタイプをサポート
- リアルタイム検索・フィルター機能（画像内OCRテキストの検索も可能）
- ローカルSQLiteデータベース保存（全データはローカルのみでプライバシー保護）
- カスタマイズ設定：パスワード保護、自動クリア、ショートカットキー設定

## プロジェクトスクリーンショット

<img src="https://raw.githubusercontent.com/snsogbl/clip-save/master/screenshots/clipboard-1.png" alt="Capture" width="960">


## 技術スタック

- **バックエンド**: Go + Wails v2
- **フロントエンド**: Vue 3 + TypeScript + Vite
- **データベース**: SQLite3
- **クリップボード**: golang.design/x/clipboard

## 依存関係のインストール

### 1. Wails CLIをインストール

```bash
go install github.com/wailsapp/wails/v2/cmd/wails@latest
```

### 2. プロジェクト依存関係のインストール

```bash
# Go 依赖
go mod tidy

# 前端依赖
cd frontend
npm install
```

## 开发

### 启动开发服务器

```bash
wails dev
```
これによりホットリロード開発サーバーが起動します：
- バックエンドの Go コードの変更は自動で再コンパイルされます
- フロントエンドの Vue コードの変更は自動でホットリロードされます

### 開発時のデバッグ

開発モードでは、アプリが自動的にデベロッパーツールを開き、以下を確認できます：
- コンソールログ
- ネットワークリクエスト
- フロントエンドコンポーネントの状態

## ビルド

### 本番版のビルド


```bash
wails build
```

ビルドが完了すると、実行可能ファイルは `build/bin/` ディレクトリに配置されます。

### カスタムスクリプトの Cloudflare Pages へのデプロイ

プロジェクトは Cloudflare Pages を使用してオンラインスクリプトリストをホスティングしており、ユーザーは「スクリプトマーケット」から直接スクリプトをインストールおよび更新できます。

#### 1. Wrangler CLI のインストール

```bash
npm install -g wrangler
```

#### 2. Cloudflare にログインする

```bash
wrangler login
```

これによりブラウザが開き、あなたの Cloudflare アカウントにログインします。

#### 3. スクリプトのデプロイ

```bash
wrangler pages deploy scriptingExample --project-name=clip-save-plugins
```

部署完了ら、スクリプトは以下の URL でアクセスされます：
- プラグインリスト：`https://clip-save-plugins.pages.dev/plugins.json`
- スクリプトファイル：`https://clip-save-plugins.pages.dev/{スクリプトファイル名}.js`

#### 4. スクリプトの更新

`scriptingExample` ディレクトリ内のファイルを変更するたびに、再度デプロイコマンドを実行してください：

```bash
wrangler pages deploy scriptingExample --project-name=clip-save-plugins
```

#### 5. 注意事項

- `plugins.json` の `scriptUrl` が Cloudflare Pages の URL を使用していることを確認してください
- デプロイ後、通常数秒以内に反映されます（Cloudflare Pages のキャッシュ時間は非常に短いです）
- Cloudflare ダッシュボードでデプロイ履歴とログを確認できます

### macOS ビルドオプション

```bash
# 构建 Intel 版本
wails build -platform darwin/amd64

# 构建 Apple Silicon 版本
wails build -platform darwin/arm64

# 构建通用二进制（推荐）
wails build -platform darwin/universal
```

### Windows ビルド

```bash
wails build -platform windows/amd64
```

### Linux ビルド

```bash
wails build -platform linux/amd64
```

## プロジェクト構造

```
.
├── main.go                      # 主程序入口
├── app.go                       # Wails 应用结构和 API
├── wails.json                   # Wails 配置文件
├── go.mod                       # Go 依赖管理
├── common/                      # 共享代码
│   ├── clipboard.go             # 剪贴板逻辑
│   ├── clipboard_darwin.go      # macOS 特定代码
│   └── db.go                    # 数据库操作
├── frontend/                    # 前端代码
│   ├── src/
│   │   ├── App.vue              # 主应用组件
│   │   ├── components/
│   │   │   └── ClipboardHistory.vue  # 剪贴板历史组件
│   │   ├── main.ts              # 前端入口
│   │   └── style.css            # 全局样式
│   ├── index.html               # HTML 模板
│   ├── package.json             # 前端依赖
│   ├── vite.config.ts           # Vite 配置
│   └── tsconfig.json            # TypeScript 配置
└── build/                       # 构建资源和输出
    ├── bin/                     # 编译后的可执行文件
    ├── appicon.png              # 应用图标
    └── darwin/                  # macOS 特定配置
```

## API 说明

### バックエンド API（Go）

`app.go` に定義されたメソッドは自動的にフロントエンドに公開されます：

- `SearchClipboardItems(keyword, filterType, limit)` - クリップボードアイテムを検索する
- `GetClipboardItems(limit)` - クリップボードリストを取得する
- `GetClipboardItemByID(id)` - ID に基づいてアイテムを取得する
- `CopyToClipboard(id)` - アイテムをクリップボードにコピーする
- `DeleteClipboardItem(id)` - アイテムを削除する
- `GetStatistics()` - 統計情報を取得する

### フロントエンド呼び出し例

```typescript
import { SearchClipboardItems } from '../wailsjs/go/main/App'

// 搜索剪贴板项目
const items = await SearchClipboardItems('关键词', '所有类型', 100)
```
## 使用説明

1. アプリを起動すると、システムのクリップボードをバックグラウンドで自動保存します  
2. コピーするたびに、履歴に自動保存されます  
3. 上部の検索ボックスで履歴を素早く検索できます（画像内のOCR文字も検索可能）  
4. フィルターを使って種類別にコンテンツを絞り込めます（テキスト/画像/URLなど）  
5. 任意の履歴をクリックして詳細を表示できます  
6. 画像タイプの場合、「文字を抽出」ボタンでOCR認識結果を確認できます  
7. 「コピー」ボタンで内容をクリップボードに再コピーできます  
8. 「削除」ボタンで履歴を削除できます  

### OCR文字認識機能

- **自動認識**：画像をコピーすると、アプリがバックグラウンドで画像内の文字を自動認識します（macOS 10.15+）  
- **スマート検索**：認識された文字は自動的に検索インデックスに追加され、キーワード入力で該当文字を含む画像が見つかります  
- **手動抽出**：画像の詳細ページで「文字を抽出」ボタンを押すと、OCRの完全な認識結果が表示されます  
- **対応言語**：簡体字/繁体字中国語と英語の認識をサポート  
- **性能最適化**：同じ画像は一度だけ認識し、認識結果を再利用して性能を向上させます  

## データ保存

クリップボード履歴は `~/.clipsave/clipboard.db` に保存されます  

データベースは自動生成され、以下のフィールドを含みます：  
- ID - 一意識別子  
- Content - 内容テキスト  
- ContentType - 内容タイプ  
- ImageData - 画像データ（PNG形式）  
- Timestamp - タイムスタンプ  
- Source - ソース  
- CharCount - 文字数  
- WordCount - 単語数  
- OCRText - OCRで認識された文字内容（画像タイプ専用、検索用）  

## システム要件

- **macOS**：10.15 Catalina以降（OCR機能に必要）  
- **Windows**：Windows 10/11（1809以降）＋ WebView2  
- **Linux**：WebKit2GTK対応のディストリビューション

- **Go**: 1.21 またはそれ以降のバージョン
- **Node.js**: 16 またはそれ以降のバージョン

## 開発上の注意事項

### Go API を更新した後

`app.go` 内のメソッドを変更するたびに、フロントエンドのバインディングを再生成する必要があります：

```bash
wails generate module
```

または開発モードを使用すると、自動的に生成されます：

```bash
wails dev
```
### 前端开发

前端は Vite + Vue 3 + TypeScript を使用：
- TypeScript の型チェックをサポート
- Composition API を使用
- Wails バインディングの自動インポート
- ホットモジュールリプレースメント（HMR）

### CGO 依存

プロジェクトは CGO（SQLite とクリップボード操作用）を使用しており、ビルド時に以下が必要：
- macOS: Xcode Command Line Tools が必要
- Windows: MinGW-w64 が必要
- Linux: gcc が必要

## よくある質問

### 1. ビルド失敗

すべての依存関係がインストールされていることを確認してください：

```bash
# macOS
xcode-select --install

# Windows
# 安装 MSYS2 和 MinGW-w64

# Linux
sudo apt-get install build-essential libgtk-3-dev libwebkit2gtk-4.0-dev
```
### 2. 前端がバックエンド API を呼び出せない場合

`wails generate module` を実行してフロントエンドのバインディングを生成したことを確認してください。

## ライセンス

MIT ライセンス

## 支援のお願い

💗 **作者にコーヒーをおごってください**

このソフトウェアがあなたの時間を節約した（あるいは少なくともイライラさせなかった）なら、作者にコーヒー ☕ やビール 🍺 をおごってください！

一杯のコーヒーは魔法のように変わります：新機能、バグの減少（できる限り）、そして作者が徹夜でコードを書く際の精神的支えに。

あなたの Star ⭐ と寄付はバグ修正や新機能追加の原動力（そして私のコーヒー代）です！

### WeChatでスキャン

![支援コード](https://raw.githubusercontent.com/snsogbl/clip-save/main/frontend/src/assets/static/zs.png)

**「私にコーヒーをおごってください ☕」**

### プロジェクトに Star ⭐ をつけてください

このプロジェクトが役に立ったら、ぜひプロジェクトに Star ⭐ をつけてください。これが私への最大の応援になります！

## 謝辞

- [Wails](https://wails.io) - デスクトップアプリケーション構築フレームワーク
- [Vue 3](https://vuejs.org) - プログレッシブ JavaScript フレームワーク
- [golang.design/x/clipboard](https://github.com/golang-design/clipboard) - クロスプラットフォームクリップボードライブラリ
- [json-editor-vue](https://github.com/cloydlau/json-editor-vue)
- [highlight.js](https://github.com/highlightjs/highlight.js)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-16

---
[![MseeP.ai セキュリティ評価バッジ](https://mseep.net/pr/nloui-paperless-mcp-badge.png)](https://mseep.ai/app/nloui-paperless-mcp)

# Paperless-NGX MCP サーバー

[![smithery バッジ](https://smithery.ai/badge/@nloui/paperless-mcp)](https://smithery.ai/server/@nloui/paperless-mcp)

Paperless-NGX API サーバーと連携するための MCP（モデルコンテキストプロトコル）サーバーです。このサーバーは、Paperless-NGX インスタンス内のドキュメント、タグ、宛先、およびドキュメントタイプの管理ツールを提供します。

## クイックスタート

### Smithery 経由でのインストール

[Smithery](https://smithery.ai/server/@nloui/paperless-mcp) を使って Claude Desktop 向けに Paperless NGX MCP サーバーを自動インストールするには:

```bash
npx -y @smithery/cli install @nloui/paperless-mcp --client claude
```

### 手動インストール
1. MCPサーバーをインストールします:
```bash
npm install -g paperless-mcp
```

2. ClaudeのMCP設定に追加します：

VSCode拡張機能の場合、`~/Library/Application Support/Code/User/globalStorage/saoudrizwan.claude-dev/settings/cline_mcp_settings.json` を編集してください：
```json
{
  "mcpServers": {
    "paperless": {
      "command": "npx",
      "args": ["paperless-mcp", "http://your-paperless-instance:8000", "your-api-token"]
    }
  }
}
```

Claudeデスクトップアプリの場合、`~/Library/Application Support/Claude/claude_desktop_config.json` を編集してください：
```json
{
  "mcpServers": {
    "paperless": {
      "command": "npx",
      "args": ["paperless-mcp", "http://your-paperless-instance:8000", "your-api-token"]
    }
  }
}
```
3. APIトークンを取得する:  
   1. Paperless-NGXインスタンスにログインする  
   2. 右上のユーザー名をクリックする  
   3. 「マイプロフィール」を選択する  
   4. 新しいトークンを生成するために円形の矢印ボタンをクリックする  

4. MCP設定内のプレースホルダーを置き換える:  
   - `http://your-paperless-instance:8000` をあなたのPaperless-NGXのURLに  
   - `your-api-token` を先ほど生成したトークンに  

以上です！これでClaudeにPaperless-NGXのドキュメント管理を手伝ってもらえます。  

## 使用例  

Claudeに依頼できることの例をいくつか紹介します:  

- 「'Invoice'タグが付いたすべてのドキュメントを表示して」  
- 「'tax return'を含むドキュメントを検索して」  
- 「色#FF0000で'Receipts'という新しいタグを作成して」  
- 「ドキュメント#123をダウンロードして」  
- 「すべての対応者を一覧表示して」  
- 「'Bank Statement'という新しいドキュメントタイプを作成して」  

## 利用可能なツール  

### ドキュメント操作  

#### list_documents  
すべてのドキュメントのページネーションされたリストを取得します。  

パラメータ:  
- page（任意）: ページ番号  
- page_size（任意）: 1ページあたりのドキュメント数  


```typescript
list_documents({
  page: 1,
  page_size: 25
})
```

#### get_document
IDで特定のドキュメントを取得します。

パラメータ:
- id: ドキュメントID

```typescript
get_document({
  id: 123
})
```

#### search_documents
ドキュメント全体の全文検索。

パラメーター:
- query: 検索クエリ文字列

```typescript
search_documents({
  query: "invoice 2024"
})
```

#### download_document
IDでドキュメントファイルをダウンロードします。

パラメータ:
- id: ドキュメントID
- original (オプション): trueの場合、アーカイブ版ではなく元のファイルをダウンロードします。

```typescript
download_document({
  id: 123,
  original: false
})
```
#### bulk_edit_documents
複数の文書に対して一括操作を実行します。

パラメータ:
- documents: 文書IDの配列
- method: 以下のいずれか:
  - set_correspondent: 文書の担当者を設定
  - set_document_type: 文書の種類を設定
  - set_storage_path: 文書の保存パスを設定
  - add_tag: 文書にタグを追加
  - remove_tag: 文書からタグを削除
  - modify_tags: 複数のタグを追加および/または削除
  - delete: 文書を削除
  - reprocess: 文書を再処理
  - set_permissions: 文書の権限を設定
  - merge: 複数の文書を結合
  - split: 文書を複数に分割
  - rotate: 文書のページを回転
  - delete_pages: 文書の特定ページを削除
- methodに応じた追加パラメータ:
  - correspondent: set_correspondent用のID
  - document_type: set_document_type用のID
  - storage_path: set_storage_path用のID
  - tag: add_tag/remove_tag用のID
  - add_tags: modify_tags用のタグID配列
  - remove_tags: modify_tags用のタグID配列
  - permissions: set_permissions用のオブジェクト（所有者、権限、結合フラグ含む）
  - metadata_document_id: mergeでメタデータ元を指定するID
  - delete_originals: merge/split用のブール値
  - pages: split用 "[1,2-3,4,5-7]" または delete_pages用 "[2,3,4]" の文字列
  - degrees: rotate用の数値（90、180、または270）

例:

```typescript
// Add a tag to multiple documents
bulk_edit_documents({
  documents: [1, 2, 3],
  method: "add_tag",
  tag: 5
})

// Set correspondent and document type
bulk_edit_documents({
  documents: [4, 5],
  method: "set_correspondent",
  correspondent: 2
})

// Merge documents
bulk_edit_documents({
  documents: [6, 7, 8],
  method: "merge",
  metadata_document_id: 6,
  delete_originals: true
})

// Split document into parts
bulk_edit_documents({
  documents: [9],
  method: "split",
  pages: "[1-2,3-4,5]"
})

// Modify multiple tags at once
bulk_edit_documents({
  documents: [10, 11],
  method: "modify_tags",
  add_tags: [1, 2],
  remove_tags: [3, 4]
})
```
#### post_document
Paperless-NGXに新しい文書をアップロードします。

Parameters:
- file: Base64エンコードされたファイル内容
- filename: ファイル名
- title (optional): 文書のタイトル
- created (optional): 文書が作成された日時（例："2024-01-19" または "2024-01-19 06:15:00+02:00"）
- correspondent (optional): 対応者のID
- document_type (optional): 文書タイプのID
- storage_path (optional): 保管場所のID
- tags (optional): タグIDの配列
- archive_serial_number (optional): アーカイブシリアル番号
- custom_fields (optional): カスタムフィールドIDの配列


```typescript
post_document({
  file: "base64_encoded_content",
  filename: "invoice.pdf",
  title: "January Invoice",
  created: "2024-01-19",
  correspondent: 1,
  document_type: 2,
  tags: [1, 3],
  archive_serial_number: "2024-001"
})
```

### タグ操作

#### list_tags
すべてのタグを取得します。

```typescript
list_tags()
```

#### create_tag
新しいタグを作成します。

パラメーター:
- name: タグ名
- color (オプション): 16進カラーコード（例："#ff0000"）
- match (オプション): 一致させるテキストパターン
- matching_algorithm (オプション): "any"、"all"、"exact"、"regular expression"、"fuzzy" のいずれか

```typescript
create_tag({
  name: "Invoice",
  color: "#ff0000",
  match: "invoice",
  matching_algorithm: "fuzzy"
})
```

### 対応者操作

#### list_correspondents
すべての対応者を取得します。

```typescript
list_correspondents()
```

#### create_correspondent
新しい通信者を作成します。

パラメータ:
- name: 通信者の名前
- match (オプション): 一致させるテキストパターン
- matching_algorithm (オプション): "any", "all", "exact", "regular expression", "fuzzy" のいずれか

```typescript
create_correspondent({
  name: "ACME Corp",
  match: "ACME",
  matching_algorithm: "fuzzy"
})
```

### ドキュメントタイプ操作

#### list_document_types
すべてのドキュメントタイプを取得します。

```typescript
list_document_types()
```

#### create_document_type
新しいドキュメントタイプを作成します。

パラメータ:
- name: ドキュメントタイプ名
- match (省略可能): 一致させるテキストパターン
- matching_algorithm (省略可能): "any", "all", "exact", "regular expression", "fuzzy" のいずれか

```typescript
create_document_type({
  name: "Invoice",
  match: "invoice total amount due",
  matching_algorithm: "any"
})
```

## エラーハンドリング

サーバーは以下の場合に明確なエラーメッセージを表示します：
- Paperless-NGX の URL または API トークンが正しくない場合
- Paperless-NGX サーバーに接続できない場合
- 要求された操作が失敗した場合
- 提供されたパラメータが無効な場合

## 開発

サーバーに貢献したい、または変更したいですか？知っておくべきことは以下の通りです：

1. リポジトリをクローンする
2. 依存関係をインストールする：
```bash
npm install
```

3. server.js に変更を加えます
4. ローカルでテストします：
```bash
node server.js http://localhost:8000 your-test-token
```
サーバーは以下で構築されています：
- [litemcp](https://github.com/wong2/litemcp)：MCPサーバー構築用のTypeScriptフレームワーク
- [zod](https://github.com/colinhacks/zod)：TypeScript優先のスキーマバリデーション

## APIドキュメント

このMCPサーバーはPaperless-NGX REST APIのエンドポイントを実装しています。基盤となるAPIの詳細については、[公式ドキュメント](https://docs.paperless-ngx.com/api/)をご覧ください。

## MCPサーバーの実行

MCPサーバーは2つのモードで実行できます：

### 1. stdio（デフォルト）

これはデフォルトのモードです。サーバーはstdioを介して通信し、CLIや直接統合に適しています。


```
npm run start -- <baseUrl> <token>
```

### 2. HTTP（ストリーム可能なHTTPトランスポート）

サーバーをHTTPサービスとして実行するには、`--http`フラグを使用します。`--port`でポートを指定することもできます（デフォルト：3000）。このモードでは[Express](https://expressjs.com/)のインストールが必要です（依存関係として含まれています）。

```
npm run start -- <baseUrl> <token> --http --port 3000
```

- MCP APIは指定されたポートの`POST /mcp`で利用可能です。
- 各リクエストは[StreamableHTTPServerTransport](https://github.com/modelcontextprotocol/typescript-sdk)パターンに従いステートレスに処理されます。
- `/mcp`へのGETおよびDELETEリクエストは405 Method Not Allowedを返します。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-05

---
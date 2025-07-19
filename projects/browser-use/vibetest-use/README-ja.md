# Vibetestの使用

Browser-Useエージェントを使用した自動QAテスト。

https://github.com/user-attachments/assets/9558d051-78bc-45fd-8694-9ac80eaf9494

複数のBrowser-Useエージェントを起動して、vibeコード化されたウェブサイトのUIバグ、リンク切れ、アクセシビリティ問題、その他の技術的問題をテストするMCPサーバー。

ライブサイトとローカルホストの開発サイトの両方のテストに最適。

ウェブサイトが正常に動作するまでVibecodeとvibetestを繰り返そう。

## クイックスタート



```bash
# Install dependencies
uv venv
source .venv/bin/activate
uv pip install -e .
```
### 1) クロードコード


```bash
# Add MCP server via CLI
claude mcp add vibetest /full/path/to/vibetest-use/.venv/bin/vibetest-mcp -e GOOGLE_API_KEY="your_api_key"

# Test in Claude Code
> claude

> /mcp 
  ⎿  MCP Server Status

     • vibetest: connected
```
### 2) カーソル（手動）

1. **MCP設定UIからインストール：**
   - カーソル設定を開く
   - 左のサイドバーで「MCP」をクリック  
   - 「サーバーを追加」または「＋」ボタンをクリック
   - 設定を手動で編集：


```json
{
  "mcpServers": {
    "vibetest": {
      "command": "/full/path/to/vibetest-use/.venv/bin/vibetest-mcp",
      "env": {
        "GOOGLE_API_KEY": "your_api_key"
      }
    }
  }
}

```
### 基本プロンプト

```
> Vibetest my website with 5 agents: browser-use.com
> Run vibetest on localhost:3000
> Run a headless vibetest on localhost:8080 with 10 agents
```
### 指定可能なパラメータ
- **URL**: 任意のウェブサイト (`https://example.com`, `localhost:3000`, `http://dev.mysite.com`)
- **エージェント数**: `3`（デフォルト）、`5 agents`、`2 agents` - エージェント数が多いほど、より徹底的なテスト
- **ヘッドレスモード**: `non-headless`（デフォルト）または `headless`

## 要件

- Python 3.11+
- Google APIキー（[取得はこちら](https://developers.google.com/maps/api-security-best-practices)）（gemini-2.0-flashをサポート）
- MCP対応のCursor/Claude

## フルデモ


https://github.com/user-attachments/assets/6450b5b7-10e5-4019-82a4-6d726dbfbe1f



## ライセンス

MIT

---

Powered by [Browser Use](https://github.com/browser-use/browser-use) 



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---
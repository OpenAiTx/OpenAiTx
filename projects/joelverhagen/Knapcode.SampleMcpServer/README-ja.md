# MCP サーバー

この README は .NET MCP サーバーテンプレートプロジェクトを使用して作成されました。.NET を使って簡単に MCP サーバーを作成し、それを NuGet パッケージとしてパッケージ化する方法を示しています。

完全なガイドについては [aka.ms/nuget/mcp/guide](https://aka.ms/nuget/mcp/guide) をご覧ください。

## NuGet.org への公開前チェックリスト

- .csproj ファイル内のパッケージメタデータを更新する
- `.mcp/server.json` を更新して MCP サーバーの入力を宣言する
- 下記の手順を使ってローカルで MCP サーバーをテストする

## VS Code での MCP サーバーの使用

MCP サーバーパッケージが NuGet.org に公開されると、以下のユーザー設定を使って VS Code で MCP サーバーパッケージをダウンロード・インストールできます。VS Code で MCP サーバーを使用する方法についての詳細は [Use MCP servers in VS Code (Preview)](https://code.visualstudio.com/docs/copilot/chat/mcp-servers) をご覧ください。

```json
{
  "mcp": {
    "servers": {
      "my-custom-mcp": {
        "type": "stdio",
        "command": "dotnet",
        "args": [
          "tool",
          "exec",
          "<your package ID here>",
          "--version",
          "<your package version here>",
          "--yes",
          "--",
          "start-mcp"
        ],
        "env": {
          "MAX_RANDOM_NUMBER": 100
        }
      }
    }
  }
}
```

これで Copilot チャットに例えば `3つの乱数をください` などと尋ねることができます。`my-custom-mcp` MCP サーバー上の `GetRandomNumber` ツールの使用を促され、結果が表示されるはずです。

## ローカルでの開発

ビルド済みの MCP サーバーパッケージを使わずにソースコードから（ローカルで）この MCP サーバーをテストするには、以下の VS Code 設定を使用します。

```json
{
  "mcp": {
    "servers": {
      "my-custom-mcp": {
        "type": "stdio",
        "command": "dotnet",
        "args": [
          "run",
          "--project",
          "<PATH TO PROJECT DIRECTORY>",
          "--",
          "start-mcp"
        ],
        "env": {
          "MAX_RANDOM_NUMBER": 100
        }
      }
    }
  }
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---
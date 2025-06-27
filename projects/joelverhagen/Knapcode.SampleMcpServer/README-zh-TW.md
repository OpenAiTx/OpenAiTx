# MCP 伺服器

本 README 是使用 .NET MCP 伺服器範本專案建立的。它展示了如何使用 .NET 輕鬆建立一個 MCP 伺服器，然後將其封裝成 NuGet 套件。

完整指南請參閱 [aka.ms/nuget/mcp/guide](https://aka.ms/nuget/mcp/guide)。

## 發佈到 NuGet.org 前的檢查清單

- 更新 .csproj 檔案中的套件中繼資料
- 更新 `.mcp/server.json` 以宣告您的 MCP 伺服器輸入
- 使用下方步驟在本機測試 MCP 伺服器

## 在 VS Code 中使用 MCP 伺服器

當 MCP 伺服器套件發佈到 NuGet.org 之後，您可以使用下列的 VS Code 使用者設定來下載並安裝 MCP 伺服器套件。關於在 VS Code 中使用 MCP 伺服器的更多資訊，請參閱 [在 VS Code 中使用 MCP 伺服器 (預覽)](https://code.visualstudio.com/docs/copilot/chat/mcp-servers)。

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

現在您可以在 Copilot chat 中要求隨機數，例如 `給我 3 個隨機數字`。它應該會提示您使用 `my-custom-mcp` MCP 伺服器上的 `GetRandomNumber` 工具並顯示結果。

## 本機開發

若要從原始碼（本機）測試此 MCP 伺服器，而不使用已建置的 MCP 伺服器套件，請使用以下 VS Code 設定：

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
# MCP 服务器

本 README 使用 .NET MCP 服务器模板项目创建。它演示了如何使用 .NET 轻松创建 MCP 服务器，并将其打包为 NuGet 包。

完整指南请参见 [aka.ms/nuget/mcp/guide](https://aka.ms/nuget/mcp/guide)。

## 发布到 NuGet.org 前的检查清单

- 在 .csproj 文件中更新包元数据
- 更新 `.mcp/server.json` 以声明您的 MCP 服务器的输入
- 按照以下步骤在本地测试 MCP 服务器

## 在 VS Code 中使用 MCP 服务器

一旦 MCP 服务器包发布到 NuGet.org，您可以在用户配置中使用以下 VS Code 配置来下载和安装 MCP 服务器包。有关在 VS Code 中使用 MCP 服务器的更多信息，请参见 [在 VS Code 中使用 MCP 服务器（预览）](https://code.visualstudio.com/docs/copilot/chat/mcp-servers)。

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

现在，您可以在 Copilot 聊天中请求生成随机数，例如 `给我 3 个随机数`。这将提示使用 `my-custom-mcp` MCP 服务器上的 `GetRandomNumber` 工具，并显示结果。

## 本地开发

要在不使用已构建的 MCP 服务器包的情况下，从源代码（本地）测试此 MCP 服务器，请使用以下 VS Code 配置：

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
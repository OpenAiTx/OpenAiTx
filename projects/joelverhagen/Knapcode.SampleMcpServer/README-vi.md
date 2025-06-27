# MCP Server

README này được tạo bằng dự án mẫu máy chủ MCP của .NET. Nó minh họa cách bạn có thể dễ dàng tạo một máy chủ MCP bằng .NET và sau đó đóng gói nó thành một gói NuGet.

Xem [aka.ms/nuget/mcp/guide](https://aka.ms/nuget/mcp/guide) để biết hướng dẫn đầy đủ.

## Danh sách kiểm tra trước khi phát hành lên NuGet.org

- Cập nhật metadata của gói trong tệp .csproj
- Cập nhật `.mcp/server.json` để khai báo các đầu vào của máy chủ MCP của bạn
- Kiểm tra máy chủ MCP trên máy cục bộ bằng các bước dưới đây

## Sử dụng máy chủ MCP trong VS Code

Khi gói máy chủ MCP đã được phát hành lên NuGet.org, bạn có thể sử dụng cấu hình người dùng VS Code sau để tải xuống và cài đặt gói máy chủ MCP. Xem [Sử dụng máy chủ MCP trong VS Code (Preview)](https://code.visualstudio.com/docs/copilot/chat/mcp-servers) để biết thêm thông tin về việc sử dụng máy chủ MCP trong VS Code.

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

Bây giờ bạn có thể yêu cầu Copilot chat tạo ra một số ngẫu nhiên, ví dụ `Give me 3 random numbers`. Nó sẽ nhắc sử dụng công cụ `GetRandomNumber` trên máy chủ MCP `my-custom-mcp` và hiển thị cho bạn kết quả.

## Phát triển trên máy cục bộ

Để kiểm tra máy chủ MCP này từ mã nguồn (trên máy cục bộ) mà không cần sử dụng gói máy chủ MCP đã xây dựng, hãy sử dụng cấu hình VS Code sau:

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
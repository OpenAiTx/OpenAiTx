# سرور MCP

این فایل README با استفاده از پروژه قالب سرور MCP در .NET ایجاد شده است. این فایل نشان می‌دهد که چگونه می‌توانید به راحتی یک سرور MCP با استفاده از .NET ساخته و سپس آن را در یک بسته NuGet قرار دهید.

برای راهنمای کامل به [aka.ms/nuget/mcp/guide](https://aka.ms/nuget/mcp/guide) مراجعه کنید.

## چک‌لیست قبل از انتشار در NuGet.org

- به‌روزرسانی اطلاعات متادیتای بسته در فایل .csproj
- به‌روزرسانی فایل `.mcp/server.json` برای اعلام ورودی‌های سرور MCP خود
- تست سرور MCP به صورت محلی با استفاده از مراحل زیر

## استفاده از سرور MCP در VS Code

پس از انتشار بسته سرور MCP در NuGet.org، می‌توانید از پیکربندی کاربری زیر در VS Code استفاده کنید تا بسته سرور MCP را دانلود و نصب نمایید. برای اطلاعات بیشتر درباره استفاده از سرورهای MCP در VS Code به [Use MCP servers in VS Code (Preview)](https://code.visualstudio.com/docs/copilot/chat/mcp-servers) مراجعه کنید.

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

اکنون می‌توانید از Copilot chat بخواهید یک عدد تصادفی به شما بدهد، به عنوان مثال `Give me 3 random numbers`. باید از ابزار `GetRandomNumber` روی سرور MCP با نام `my-custom-mcp` استفاده کند و نتایج را به شما نمایش دهد.

## توسعه به صورت محلی

برای تست این سرور MCP از کد منبع (به صورت محلی) بدون استفاده از بسته ساخته‌شده سرور MCP، از پیکربندی زیر در VS Code استفاده کنید:

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
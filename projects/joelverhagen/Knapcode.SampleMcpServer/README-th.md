# MCP Server

README นี้ถูกสร้างขึ้นโดยใช้โครงการแม่แบบ .NET MCP server ตัวอย่างนี้แสดงวิธีที่คุณสามารถสร้าง MCP server ด้วย .NET ได้อย่างง่ายดายและนำไปบรรจุในแพ็กเกจ NuGet

ดู [aka.ms/nuget/mcp/guide](https://aka.ms/nuget/mcp/guide) เพื่อดูคู่มือฉบับเต็ม

## รายการตรวจสอบก่อนเผยแพร่ไปยัง NuGet.org

- อัปเดตข้อมูลเมตาแพ็กเกจในไฟล์ .csproj
- อัปเดต `.mcp/server.json` เพื่อประกาศอินพุตของ MCP server ของคุณ
- ทดสอบ MCP server ในเครื่องโดยใช้ขั้นตอนด้านล่าง

## การใช้งาน MCP Server ใน VS Code

เมื่อแพ็กเกจ MCP server ถูกเผยแพร่ไปยัง NuGet.org แล้ว คุณสามารถใช้ VS Code ด้วยการตั้งค่าผู้ใช้ดังต่อไปนี้เพื่อดาวน์โหลดและติดตั้งแพ็กเกจ MCP server ดู [Use MCP servers in VS Code (Preview)](https://code.visualstudio.com/docs/copilot/chat/mcp-servers) สำหรับข้อมูลเพิ่มเติมเกี่ยวกับการใช้งาน MCP servers ใน VS Code

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

ตอนนี้คุณสามารถขอให้ Copilot chat สุ่มตัวเลข เช่น `Give me 3 random numbers` ได้แล้ว มันจะเสนอให้ใช้เครื่องมือ `GetRandomNumber` บนเซิร์ฟเวอร์ MCP `my-custom-mcp` และแสดงผลลัพธ์ให้คุณ

## การพัฒนาแบบโลคอล

เพื่อทดสอบ MCP server นี้จากซอร์สโค้ด (บนเครื่อง) โดยไม่ใช้แพ็กเกจ MCP server ที่สร้างแล้ว ให้ใช้การตั้งค่า VS Code ดังต่อไปนี้:

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
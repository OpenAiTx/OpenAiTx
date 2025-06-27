# MCP Server

README ini dibuat menggunakan proyek template server MCP .NET. Ini menunjukkan bagaimana Anda dapat dengan mudah membuat server MCP menggunakan .NET dan kemudian mengemasnya dalam paket NuGet.

Lihat [aka.ms/nuget/mcp/guide](https://aka.ms/nuget/mcp/guide) untuk panduan lengkap.

## Daftar Periksa sebelum menerbitkan ke NuGet.org

- Perbarui metadata paket di file .csproj
- Perbarui `.mcp/server.json` untuk mendeklarasikan input server MCP Anda
- Uji server MCP secara lokal menggunakan langkah-langkah di bawah ini

## Menggunakan MCP Server di VS Code

Setelah paket server MCP diterbitkan ke NuGet.org, Anda dapat menggunakan VS Code dengan konfigurasi pengguna berikut untuk mengunduh dan menginstal paket server MCP. Lihat [Gunakan MCP server di VS Code (Pratinjau)](https://code.visualstudio.com/docs/copilot/chat/mcp-servers) untuk informasi lebih lanjut tentang penggunaan MCP server di VS Code.

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

Sekarang Anda dapat meminta Copilot chat untuk sebuah angka acak, misalnya `Beri saya 3 angka acak`. Ini seharusnya memberi prompt untuk menggunakan tool `GetRandomNumber` pada server MCP `my-custom-mcp` dan menampilkan hasilnya kepada Anda.

## Pengembangan secara lokal

Untuk menguji server MCP ini dari kode sumber (secara lokal) tanpa menggunakan paket server MCP yang sudah dibangun, gunakan konfigurasi VS Code berikut:

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
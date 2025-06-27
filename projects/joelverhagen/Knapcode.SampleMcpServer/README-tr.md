# MCP Sunucusu

Bu README, .NET MCP sunucu şablon projesi kullanılarak oluşturulmuştur. .NET kullanarak nasıl kolayca bir MCP sunucusu oluşturabileceğinizi ve ardından bunu bir NuGet paketi olarak nasıl paketleyebileceğinizi göstermektedir.

Tam kılavuz için [aka.ms/nuget/mcp/guide](https://aka.ms/nuget/mcp/guide) adresine bakınız.

## NuGet.org’a yayımlamadan önce kontrol listesi

- .csproj dosyasındaki paket meta verilerini güncelleyin
- MCP sunucunuzun girdilerini bildirmek için `.mcp/server.json` dosyasını güncelleyin
- MCP sunucusunu aşağıdaki adımları kullanarak yerel olarak test edin

## VS Code’da MCP Sunucusunun Kullanımı

MCP sunucu paketi NuGet.org’da yayımlandıktan sonra, MCP sunucu paketini indirmek ve yüklemek için aşağıdaki kullanıcı yapılandırmasına sahip VS Code’u kullanabilirsiniz. VS Code’da MCP sunucularını kullanma hakkında daha fazla bilgi için [VS Code’da MCP sunucularını kullanma (Önizleme)](https://code.visualstudio.com/docs/copilot/chat/mcp-servers) sayfasına bakınız.

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

Artık Copilot sohbetine örneğin `Bana 3 rastgele sayı ver` gibi bir istekle rastgele sayı sorabilirsiniz. Bu, `my-custom-mcp` MCP sunucusundaki `GetRandomNumber` aracını kullanmanızı istemeli ve sonuçları göstermelidir.

## Yerel Geliştirme

Derlenmiş bir MCP sunucu paketi kullanmadan, kaynak koddan (yerel olarak) bu MCP sunucusunu test etmek için aşağıdaki VS Code yapılandırmasını kullanın:

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
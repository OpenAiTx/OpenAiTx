# MCP-Server

Dieses README wurde mit dem .NET MCP-Server-Vorlagenprojekt erstellt. Es zeigt, wie Sie ganz einfach einen MCP-Server mit .NET erstellen und anschließend in ein NuGet-Paket verpacken können.

Siehe [aka.ms/nuget/mcp/guide](https://aka.ms/nuget/mcp/guide) für die vollständige Anleitung.

## Checkliste vor der Veröffentlichung auf NuGet.org

- Paketmetadaten in der .csproj-Datei aktualisieren
- Die `.mcp/server.json` aktualisieren, um die Eingaben Ihres MCP-Servers zu deklarieren
- Den MCP-Server lokal mit den untenstehenden Schritten testen

## Verwendung des MCP-Servers in VS Code

Sobald das MCP-Server-Paket auf NuGet.org veröffentlicht wurde, können Sie die folgende VS Code-Konfiguration mit Benutzerkonfiguration verwenden, um das MCP-Server-Paket herunterzuladen und zu installieren. Weitere Informationen zur Verwendung von MCP-Servern in VS Code finden Sie unter [Use MCP servers in VS Code (Preview)](https://code.visualstudio.com/docs/copilot/chat/mcp-servers).

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

Nun können Sie Copilot-Chat nach einer Zufallszahl fragen, zum Beispiel `Gib mir 3 Zufallszahlen`. Es sollte dazu auffordern, das `GetRandomNumber`-Tool auf dem `my-custom-mcp` MCP-Server zu verwenden und Ihnen die Ergebnisse anzeigen.

## Lokale Entwicklung

Um diesen MCP-Server aus dem Quellcode (lokal) zu testen, ohne ein gebautes MCP-Server-Paket zu verwenden, verwenden Sie die folgende VS Code-Konfiguration:

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
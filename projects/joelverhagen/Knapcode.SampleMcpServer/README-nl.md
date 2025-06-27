# MCP Server

Dit README-bestand is aangemaakt met het .NET MCP server sjabloonproject. Het demonstreert hoe je eenvoudig een MCP-server kunt maken met .NET en deze vervolgens kunt verpakken in een NuGet-pakket.

Zie [aka.ms/nuget/mcp/guide](https://aka.ms/nuget/mcp/guide) voor de volledige handleiding.

## Checklist voordat je publiceert naar NuGet.org

- Werk de pakketmetadata bij in het .csproj-bestand
- Werk `.mcp/server.json` bij om de invoer van jouw MCP-server te declareren
- Test de MCP-server lokaal met behulp van de onderstaande stappen 

## Gebruik van de MCP Server in VS Code

Zodra het MCP-serverpakket is gepubliceerd op NuGet.org, kun je de volgende VS Code gebruikersconfiguratie gebruiken om het MCP-serverpakket te downloaden en te installeren. Zie [Gebruik MCP-servers in VS Code (Preview)](https://code.visualstudio.com/docs/copilot/chat/mcp-servers) voor meer informatie over het gebruik van MCP-servers in VS Code.

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

Nu kun je Copilot chat vragen om een willekeurig getal, bijvoorbeeld `Geef me 3 willekeurige getallen`. Het zou moeten vragen om de `GetRandomNumber` tool te gebruiken op de `my-custom-mcp` MCP-server en de resultaten tonen.

## Lokaal ontwikkelen

Om deze MCP-server te testen vanuit de broncode (lokaal) zonder gebruik te maken van een gebouwd MCP-serverpakket, gebruik je de volgende VS Code-configuratie:

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
          "<PAD NAAR PROJECTMAP>",
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
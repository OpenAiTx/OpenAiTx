# Serwer MCP

Ten plik README został utworzony przy użyciu szablonu projektu serwera MCP dla .NET. Pokazuje, jak łatwo można utworzyć serwer MCP w .NET i następnie spakować go jako pakiet NuGet.

Zobacz [aka.ms/nuget/mcp/guide](https://aka.ms/nuget/mcp/guide) aby uzyskać pełny przewodnik.

## Lista kontrolna przed publikacją na NuGet.org

- Zaktualizuj metadane pakietu w pliku .csproj
- Zaktualizuj plik `.mcp/server.json`, aby zadeklarować wejścia serwera MCP
- Przetestuj serwer MCP lokalnie, korzystając z poniższych kroków

## Używanie serwera MCP w VS Code

Po opublikowaniu pakietu serwera MCP na NuGet.org możesz użyć poniższej konfiguracji użytkownika w VS Code, aby pobrać i zainstalować pakiet serwera MCP. Zobacz [Używanie serwerów MCP w VS Code (Preview)](https://code.visualstudio.com/docs/copilot/chat/mcp-servers), aby uzyskać więcej informacji o korzystaniu z serwerów MCP w VS Code.

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

Teraz możesz poprosić Copilot chat o wygenerowanie losowej liczby, na przykład `Give me 3 random numbers`. Powinno to spowodować wywołanie narzędzia `GetRandomNumber` na serwerze MCP `my-custom-mcp` i wyświetlenie wyników.

## Rozwój lokalny

Aby przetestować ten serwer MCP z kodu źródłowego (lokalnie), bez użycia zbudowanego pakietu serwera MCP, użyj poniższej konfiguracji VS Code:

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
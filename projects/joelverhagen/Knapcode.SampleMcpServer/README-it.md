# MCP Server

Questo README è stato creato utilizzando il progetto template del server MCP per .NET. Dimostra come sia possibile creare facilmente un server MCP utilizzando .NET e poi impacchettarlo in un pacchetto NuGet.

Consulta [aka.ms/nuget/mcp/guide](https://aka.ms/nuget/mcp/guide) per la guida completa.

## Checklist prima della pubblicazione su NuGet.org

- Aggiorna i metadati del pacchetto nel file .csproj
- Aggiorna il file `.mcp/server.json` per dichiarare gli input del tuo server MCP
- Testa il server MCP localmente utilizzando i passaggi riportati di seguito

## Utilizzo del server MCP in VS Code

Una volta che il pacchetto del server MCP è stato pubblicato su NuGet.org, puoi utilizzare la seguente configurazione utente di VS Code per scaricare e installare il pacchetto del server MCP. Consulta [Usare i server MCP in VS Code (Anteprima)](https://code.visualstudio.com/docs/copilot/chat/mcp-servers) per ulteriori informazioni sull'utilizzo dei server MCP in VS Code.

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

Ora puoi chiedere a Copilot chat un numero casuale, ad esempio `Dammi 3 numeri casuali`. Dovrebbe suggerire di utilizzare lo strumento `GetRandomNumber` sul server MCP `my-custom-mcp` e mostrarti i risultati.

## Sviluppo in locale

Per testare questo server MCP dal codice sorgente (in locale) senza utilizzare un pacchetto server MCP già compilato, usa la seguente configurazione di VS Code:

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
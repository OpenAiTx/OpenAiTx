# MCP Server

Este README foi criado usando o projeto de template do servidor MCP em .NET. Ele demonstra como você pode facilmente criar um servidor MCP usando .NET e então empacotá-lo em um pacote NuGet.

Veja [aka.ms/nuget/mcp/guide](https://aka.ms/nuget/mcp/guide) para o guia completo.

## Checklist antes de publicar no NuGet.org

- Atualize os metadados do pacote no arquivo .csproj
- Atualize o `.mcp/server.json` para declarar as entradas do seu servidor MCP
- Teste o servidor MCP localmente usando os passos abaixo

## Usando o MCP Server no VS Code

Uma vez que o pacote do servidor MCP esteja publicado no NuGet.org, você pode usar a seguinte configuração de usuário no VS Code para baixar e instalar o pacote do servidor MCP. Veja [Use MCP servers in VS Code (Preview)](https://code.visualstudio.com/docs/copilot/chat/mcp-servers) para mais informações sobre o uso de servidores MCP no VS Code.

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

Agora você pode pedir ao chat Copilot um número aleatório, por exemplo `Me dê 3 números aleatórios`. Ele deve sugerir o uso da ferramenta `GetRandomNumber` no servidor MCP `my-custom-mcp` e mostrar os resultados para você.

## Desenvolvendo localmente

Para testar este servidor MCP a partir do código-fonte (localmente) sem usar um pacote já construído do servidor MCP, utilize a seguinte configuração no VS Code:

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
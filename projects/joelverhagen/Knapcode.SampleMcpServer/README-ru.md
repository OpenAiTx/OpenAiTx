# MCP Server

Этот README был создан с использованием шаблонного проекта .NET MCP server. Он демонстрирует, как легко создать MCP сервер с помощью .NET, а затем упаковать его в NuGet-пакет.

Полное руководство смотрите на [aka.ms/nuget/mcp/guide](https://aka.ms/nuget/mcp/guide).

## Контрольный список перед публикацией на NuGet.org

- Обновите метаданные пакета в файле .csproj
- Обновите `.mcp/server.json`, чтобы объявить входные параметры вашего MCP сервера
- Протестируйте MCP сервер локально, используя шаги ниже

## Использование MCP сервера в VS Code

После публикации MCP серверного пакета на NuGet.org вы можете использовать следующий конфиг пользователя VS Code для загрузки и установки MCP серверного пакета. Подробнее об использовании MCP серверов в VS Code см. [Use MCP servers in VS Code (Preview)](https://code.visualstudio.com/docs/copilot/chat/mcp-servers).

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

Теперь вы можете попросить Copilot chat сгенерировать случайное число, например `Give me 3 random numbers`. Должно появиться предложение использовать инструмент `GetRandomNumber` на MCP сервере `my-custom-mcp` и показать вам результаты.

## Разработка локально

Чтобы протестировать этот MCP сервер из исходного кода (локально) без использования собранного пакета MCP сервера, используйте следующую конфигурацию VS Code:

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
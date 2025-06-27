# MCP 서버

이 README는 .NET MCP 서버 템플릿 프로젝트를 사용하여 작성되었습니다. .NET을 사용하여 MCP 서버를 손쉽게 생성하고 NuGet 패키지로 패키징하는 방법을 보여줍니다.

전체 가이드는 [aka.ms/nuget/mcp/guide](https://aka.ms/nuget/mcp/guide)를 참조하세요.

## NuGet.org에 게시하기 전 체크리스트

- .csproj 파일에서 패키지 메타데이터를 업데이트하세요
- `.mcp/server.json` 파일을 업데이트하여 MCP 서버의 입력값을 선언하세요
- 아래 단계에 따라 MCP 서버를 로컬에서 테스트하세요

## VS Code에서 MCP 서버 사용하기

MCP 서버 패키지가 NuGet.org에 게시되면, 다음과 같이 사용자 구성으로 VS Code에서 MCP 서버 패키지를 다운로드 및 설치할 수 있습니다. VS Code에서 MCP 서버를 사용하는 방법에 대한 자세한 내용은 [VS Code에서 MCP 서버 사용(미리보기)](https://code.visualstudio.com/docs/copilot/chat/mcp-servers)를 참고하세요.

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

이제 Copilot 채팅에 예를 들어 `임의의 숫자 3개를 알려줘`와 같이 요청할 수 있습니다. 그러면 `my-custom-mcp` MCP 서버의 `GetRandomNumber` 도구를 사용하라는 알림이 표시되고 결과를 보여줍니다.

## 로컬에서 개발하기

빌드된 MCP 서버 패키지를 사용하지 않고 소스 코드(로컬)에서 이 MCP 서버를 테스트하려면 다음과 같은 VS Code 구성을 사용하세요.

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
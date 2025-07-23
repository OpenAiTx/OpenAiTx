
# effect mcp 서버

[![MCP 서버 설치](https://cursor.com/deeplink/mcp-install-dark.svg)](https://cursor.com/install-mcp?name=effect%20docs&config=eyJjb21tYW5kIjoibnB4IC15IGVmZmVjdC1tY3AifQ%3D%3D)

이 MCP 서버는 Effect 문서에 접근하기 위한 도구와 리소스를 추가합니다.

## 사용법

다음 명령어로 도커에서 실행할 수 있습니다:


```bash
docker run --rm -i timsmart/effect-mcp
```
npx를 사용하십시오:


```bash
npx -y effect-mcp
```
## Claude Code 통합

이 MCP 서버를 Claude Code와 함께 사용하려면, 다음 명령어를 실행하세요:


```bash
claude mcp add-json effect-docs '{
  "command": "npx",
  "args": [
    "-y",
    "effect-mcp"
  ],
  "env": {}
}' -s user
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---
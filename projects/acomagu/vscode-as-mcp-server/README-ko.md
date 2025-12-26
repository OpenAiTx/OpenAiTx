# VSCode as MCP Server

[Marketplace](https://marketplace.visualstudio.com/items?itemName=acomagu.vscode-as-mcp-server)

VSCode를 MCP 서버로 변환하여 Claude Desktop과 같은 MCP 클라이언트로부터 고급 코딩 지원을 받을 수 있게 해주는 VSCode 확장입니다.

## 주요 기능

### 코드 편집 지원
- LLM이 제안한 코드 변경 사항을 diff로 검토하고, 수락, 거부 또는 피드백을 제공할 수 있습니다.
- 타입 오류와 같은 실시간 진단 메시지를 즉시 LLM에 전송하여 바로 수정할 수 있습니다.

![Code editing diff](https://storage.googleapis.com/zenn-user-upload/778b7e9ad8c4-20250407.gif)

### 터미널 작업
- VSCode 통합 터미널 내에서 명령어를 실행할 수 있습니다 (백그라운드/포그라운드 실행 및 타임아웃 설정 지원).

### 미리보기 도구
- VSCode 내장 브라우저에서 URL을 직접 미리보기할 수 있습니다 (예: Vite 서버 시작 후 자동으로 브라우저 미리보기 열기).

![Preview tool](https://storage.googleapis.com/zenn-user-upload/8968c9ad3920-20250407.gif)

### 다중 인스턴스 전환
- 여러 개의 열린 VSCode 창 사이에서 MCP 서버를 쉽게 전환할 수 있습니다. (상태 표시줄 아이템 클릭만으로)

![Instance switching](https://storage.googleapis.com/zenn-user-upload/0a2bc2bee634-20250407.gif)

### 중계 기능 (실험적)
- VSCode 1.99에 도입된 내장 MCP 서버를 외부에 중계 및 노출합니다.
- GitHub Copilot과 같은 다른 MCP 확장 도구에 외부에서 접근할 수 있게 합니다.

## 사용 가능한 내장 도구

- **execute_command**: VSCode 통합 터미널에서 명령어 실행
- **code_checker**: 코드의 현재 진단 정보 조회
- **focus_editor**: 파일 내 특정 위치로 포커스 이동
- **list_debug_sessions** / **start_debug_session** / **restart_debug_session** / **stop_debug_session**: 디버그 세션 관리
- **text_editor**: 파일 작업 (보기, 교체, 생성, 삽입, 실행 취소)
- **list_directory**: 디렉터리 내용을 트리 형식으로 나열
- **get_terminal_output**: 지정한 터미널의 출력 가져오기
- **list_vscode_commands** / **execute_vscode_command**: 임의의 VSCode 명령어 목록 조회 및 실행  
- **preview_url**: VSCode 내장 브라우저에서 URL 열기  

## 설치 및 설정  

1. [VSCode 마켓플레이스](https://marketplace.visualstudio.com/items?itemName=acomagu.vscode-as-mcp-server)에서 확장 프로그램을 설치합니다.  

2. MCP 클라이언트를 구성합니다:  

    - **mcp-installer 사용 시**: "vscode-as-mcp-server MCP 서버 설치"를 지시하면 됩니다.  
    - **Claude Desktop 등 다른 클라이언트**: 구성 파일(`claude_desktop_config.json`)에 다음을 추가하세요:

    ```json
    {
      "mcpServers": {
        "vscode": {
          "command": "npx",
          "args": ["vscode-as-mcp-server"]
        }
      }
    }
    ```
3. VSCode 우측 하단 상태 표시줄에서 MCP 서버 상태 확인:

    - (서버 아이콘): 서버가 실행 중임
    - ∅: 클릭하여 서버 시작

![서버 상태 표시기](https://storage.googleapis.com/zenn-user-upload/321704116d4a-20250408.png)

## 동기

이 확장 기능은 측정 기반 코딩 도구(예: Roo Code 및 Cursor)의 높은 비용 문제를 완화하기 위해 개발되었습니다. VSCode에 직접 내장된 저렴한 자체 호스팅 대안입니다.

버그 보고 및 피드백은 언제나 환영합니다! 🙇

## 향후 계획

- 노출할 내장 MCP 서버 선택 기능
- WebView 기반 승인 UI (Roo Code와 유사)
- VSCode 파일 히스토리(Timeline) 연동
- 자동 승인 및 도구 활성화/비활성화 즉시 전환
- 사용자 지정 서버 포트 구성



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-26

---
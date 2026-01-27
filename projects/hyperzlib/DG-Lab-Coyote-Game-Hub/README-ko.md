<h1 align="center"> 패배 벌칙——코요테 게임 컨트롤러</h1>
<div align="center">
  <a href="https://github.com/hyperzlib/DG-Lab-Coyote-Game-Hub/actions"><img src="https://img.shields.io/github/actions/workflow/status/hyperzlib/DG-Lab-Coyote-Game-Hub/node.js.yml"></a>
  <a href="https://github.com/hyperzlib/DG-Lab-Coyote-Game-Hub/releases"><img src="https://img.shields.io/github/release-date/hyperzlib/DG-Lab-Coyote-Game-Hub"></a>
  <a href="https://github.com/hyperzlib/DG-Lab-Coyote-Game-Hub/commits/main/"><img src="https://img.shields.io/github/last-commit/hyperzlib/DG-Lab-Coyote-Game-Hub"></a>
</div>
<p></p>
<div align="center">
  <a href="https://github.com/hyperzlib/DG-Lab-Coyote-Game-Hub/actions">다운로드</a>
  |
  <a href="https://www.bilibili.com/video/BV17m421G7fm/">미리보기</a>
  |
  <a href="docs/api.md">플러그인 API</a>
</div>
<p></p>
<div align="center">
  <img src="https://raw.githubusercontent.com/hyperzlib/DG-Lab-Coyote-Game-Hub/main/docs/images/screenshot-widget.png" height="200" alt="위젯 스크린샷">
</div>

## 주의사항

라이브 스트리밍 플랫폼의 관련 규정을 준수해 주세요. 본 위젯을 위반하여 사용하는 경우, 생방송 채널 정지 등의 결과에 대해 본 위젯 제작자는 책임지지 않습니다.

## 사용 방법 (Windows 바이너리 배포판)

1. [Releases](https://github.com/hyperzlib/DG-Lab-Coyote-Game-Hub/releases)에서 ```coyote-game-hub-windows-amd64-dist.zip``` 다운로드: [바로가기](https://github.com/hyperzlib/DG-Lab-Coyote-Game-Hub/releases)
2. 압축을 푼 후 ```start.bat```를 실행하여 서버를 시작합니다.

## 사용 방법 (Linux/MacOS 명령어)
1. nodejs 설치 (Linux는 nvm 권장, Mac은 ```brew install node@22``` 사용)
2. [Releases](https://github.com/hyperzlib/DG-Lab-Coyote-Game-Hub/releases)에서 ```coyote-game-hub-nodejs-server.zip``` 다운로드: [바로가기](https://github.com/hyperzlib/DG-Lab-Coyote-Game-Hub/releases)
3. 압축 해제한 경로에서 ```node server/index.js``` 실행

## 사용 방법 (소스 컴파일)

(아래 예제는 ```pnpm```으로 의존성을 설치하지만, ```npm``` 또는 ```yarn```도 사용할 수 있습니다)

1. ```server``` 디렉터리로 이동하여 ```pnpm install```로 의존성 설치

2. ```frontend``` 디렉터리로 이동하여 ```pnpm install```로 의존성 설치
3. 프로젝트 루트 디렉터리에서 ```pnpm install```을 실행하여 의존성을 설치하고, ```npm run build```를 실행하여 프로젝트를 빌드합니다.

4. 프로젝트 루트 디렉터리에서 ```npm start```를 실행하여 서버를 시작합니다.

5. 브라우저에서 ```http://localhost:8920```을 열면 제어판을 볼 수 있습니다.

## 프로젝트 구조

- ```server```: 서버 측 코드  
- ```frontend```: 프론트엔드 코드



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-27

---
# llum

### 빠르고 가볍고 오픈된 채팅 UI

![image](https://github.com/user-attachments/assets/38cc47cf-06a3-4dca-8ee5-d9c9edf57903)

### 주요 기능:

- 🔌 여러 공급자 지원, API 키를 플러그인(완전히 로컬에 저장)하면 바로 사용 가능

  - 로컬 모델 (Ollama 통해)
  - OpenRouter (여러 공급자의 모든 모델 사용 가능: OpenAI, Anthropic, OSS, 50개 이상)
  - OpenAI
  - Anthropic
  - Mistral
  - Groq

- 🛠️ 도구 사용
  - `server/toolfns/toolfns.go`를 확인하세요. 함수만 작성하면 됩니다. 함수 설명은 모델이 사용하는 내용을 알 수 있도록 합니다. 웹 UI에서 `Sync` 버튼을 클릭해 도구를 새로 고침하세요.
- 🖼️ 멀티모달 입력: 이미지 업로드, 붙여넣기, 링크 공유 가능
- 🎨 DALL-E 3를 이용한 이미지 생성
- 📝 멀티샷 프롬프트. 메시지 편집, 삭제, 재생성 등 자유롭게 사용 가능
- ⚡ 사전 작성된 응답 (공급자 지원 시)
- 🌐 모든 공급자의 모든 사용 가능한 모델 지원
- 🔄 대화 중간에 모델 변경 가능
- 🔐 기기 간 대화 및 키 동기화, 종단 간 암호화. 셀프 호스팅 또는 호스팅 인스턴스 사용 가능.
- 🔗 대화 공유 (공유 선택 시, 대화 내용은 외부 서버에 저장되어야 공유 링크 생성 가능. 셀프 호스팅 공유 옵션 곧 제공. 아니요, 사용자의 내용을 보지 않습니다.)
- 🌿 분기 대화 기록 (왼쪽-오른쪽 ChatGPT 화살표처럼 이전 응답으로 돌아가기 가능)

### 개인정보 보호:

- 완전히 개인적이고 투명함. 모든 대화 기록과 키는 완전히 로컬에 저장되고, 브라우저와 기기에만 보관됩니다.

## 설치 방법?

도구를 사용하지 않는다면 설치할 필요 없습니다. 호스팅 인스턴스는 https://llum.chat 에서 이용 가능합니다.

도구를 사용하려면 아래를 진행하세요.

## 단일 바이너리:

llum 도구 서버는 단일 바이너리로 미리 빌드되어 제공됩니다. [릴리즈 페이지에서 미리 빌드된 패키지를 다운로드하세요.](https://github.com/zakkor/llum/releases)

플랫폼에 맞는 바이너리를 다운로드한 후 실행하면 도구 서버가 시작됩니다:

```
./llum-darwin-amd64
Tool server running at http://localhost:8081
```
https://llum.chat로 돌아가서 설정 -> 도구 호출로 이동한 후 "도구 새로고침" 버튼을 클릭하세요. 이제 준비가 완료되었습니다!

### 클라이언트 및 서버 로컬 빌드:

1. 저장소를 클론하세요
2. 클라이언트를 설치하고 시작하세요: `npm i && npm run dev`. 클라이언트는 http://localhost:5173에서 접근할 수 있습니다
3. 서버를 설치하고 시작하세요: `cd server && go generate ./... && go build && ./server -password foobar`. 서버는 http://localhost:8081에서 접근할 수 있습니다. 선택한 비밀번호와 함께 이 주소를 채팅 UI의 서버 주소에 입력할 수 있습니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---
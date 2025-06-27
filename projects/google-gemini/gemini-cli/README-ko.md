# Gemini CLI

[![Gemini CLI CI](https://github.com/google-gemini/gemini-cli/actions/workflows/ci.yml/badge.svg)](https://github.com/google-gemini/gemini-cli/actions/workflows/ci.yml)

![Gemini CLI Screenshot](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/assets/gemini-screenshot.png)

이 저장소는 Gemini CLI를 포함하고 있습니다. Gemini CLI는 명령줄 AI 워크플로우 도구로, 여러분의 도구와 연결하고 코드를 이해하며 워크플로우를 가속화합니다.

Gemini CLI로 할 수 있는 일은 다음과 같습니다:

- Gemini의 1M 토큰 컨텍스트 윈도우 내외에서 대규모 코드베이스를 쿼리하고 편집할 수 있습니다.
- Gemini의 멀티모달 기능을 활용하여 PDF나 스케치에서 새로운 앱을 생성할 수 있습니다.
- 풀 리퀘스트 쿼리나 복잡한 리베이스 처리와 같은 운영 작업을 자동화할 수 있습니다.
- 도구 및 MCP 서버를 사용하여 [Imagen, Veo 또는 Lyria를 활용한 미디어 생성](https://github.com/GoogleCloudPlatform/vertex-ai-creative-studio/tree/main/experiments/mcp-genmedia) 등 새로운 기능을 연결할 수 있습니다.
- Gemini에 내장된 [Google Search](https://ai.google.dev/gemini-api/docs/grounding) 도구로 쿼리를 그라운딩할 수 있습니다.

## 빠른 시작

1. **사전 준비:** [Node.js 18 버전](https://nodejs.org/en/download) 이상이 설치되어 있는지 확인하세요.
2. **CLI 실행:** 터미널에서 다음 명령어를 실행하세요:

   ```bash
   npx https://github.com/google-gemini/gemini-cli
   ```

   또는 다음과 같이 설치할 수 있습니다:

   ```bash
   npm install -g @google/gemini-cli
   gemini
   ```

3. **색상 테마 선택**
4. **인증:** 안내가 나오면 개인 Google 계정으로 로그인하세요. 이렇게 하면 Gemini를 통해 분당 최대 60회, 일일 최대 1,000회 모델 요청이 가능합니다.

이제 Gemini CLI를 사용할 준비가 완료되었습니다!

### 고급 사용 또는 요청 한도 증가가 필요한 경우:

특정 모델을 사용하거나 더 높은 요청 용량이 필요한 경우 API 키를 사용할 수 있습니다:

1. [Google AI Studio](https://aistudio.google.com/apikey)에서 키를 생성하세요.
2. 터미널에서 환경 변수로 설정하세요. `YOUR_API_KEY`를 생성한 키로 교체하세요.

   ```bash
   export GEMINI_API_KEY="YOUR_API_KEY"
   ```

Google Workspace 계정을 포함한 기타 인증 방법은 [인증 가이드](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/cli/authentication.md)를 참고하세요.

## 예시

CLI가 실행되면 쉘에서 Gemini와 상호작용을 시작할 수 있습니다.

새 디렉터리에서 프로젝트를 시작할 수 있습니다:

```sh
cd new-project/
gemini
> 제공할 FAQ.md 파일을 이용해 질문에 답변하는 Gemini Discord 봇을 작성해줘
```

또는 기존 프로젝트와 작업할 수 있습니다:

```sh
git clone https://github.com/google-gemini/gemini-cli
cd gemini-cli
gemini
> 어제 반영된 모든 변경 사항을 요약해줘
```

### 다음 단계

- [소스에 기여하거나 빌드하는 방법](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/CONTRIBUTING.md)을 알아보세요.
- 사용 가능한 **[CLI 명령어](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/cli/commands.md)**를 살펴보세요.
- 문제가 발생하면 **[문제 해결 가이드](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/troubleshooting.md)**를 참고하세요.
- 더 자세한 문서는 [전체 문서](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/index.md)를 참고하세요.
- 영감을 얻고 싶다면 [인기 작업](#popular-tasks)도 확인해보세요.

### 문제 해결

문제가 발생했다면 [문제 해결 가이드](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/troubleshooting.md)를 참고하세요.

## 인기 작업

### 새로운 코드베이스 탐색

기존 또는 새로 클론한 저장소로 `cd` 이동한 뒤 `gemini`를 실행하세요.

```text
> 이 시스템 아키텍처의 주요 구성 요소를 설명해줘.
```

```text
> 어떤 보안 메커니즘이 적용되어 있나요?
```

### 기존 코드로 작업하기

```text
> GitHub 이슈 #123에 대한 초안 구현을 작성해줘.
```

```text
> 이 코드베이스를 최신 Java 버전으로 마이그레이션하는 계획부터 도와줘.
```

### 워크플로우 자동화

MCP 서버를 사용해 로컬 시스템 도구와 엔터프라이즈 협업 도구를 통합하세요.

```text
> 지난 7일간의 git 히스토리를 기능별, 팀원별로 그룹화해서 슬라이드 데크를 만들어줘.
```

```text
> 가장 많이 상호작용된 GitHub 이슈를 보여주는 전체화면 웹앱을 만들어줘.
```

### 시스템과 상호작용

```text
> 이 디렉터리의 모든 이미지를 png로 변환하고, exif 데이터의 날짜를 파일명으로 사용해 이름을 바꿔줘.
```

```text
> PDF 인보이스를 지출 월별로 정리해줘.
```

## 서비스 약관 및 개인정보 보호 안내

Gemini CLI 사용 시 적용되는 서비스 약관 및 개인정보 보호 안내에 대한 자세한 내용은 [서비스 약관 및 개인정보 보호 안내](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/tos-privacy.md)를 참고하세요.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---
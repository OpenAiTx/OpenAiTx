Release : Alpha 1.0.5

<div style="display:flex; width:100%; column-gap:16px; margin-bottom:12px;">
    <span>호환성 :</span>
    <img style="width:24px; height:24px;" src="https://github.com/ask0ldd/OsspitaUI/blob/main/Front/src/assets/windows.png">
    <img style="width:24px; height:24px;" src="https://github.com/ask0ldd/OsspitaUI/blob/main/Front/src/assets/chrome.png">
    <img style="width:24px; height:24px;" src="https://github.com/ask0ldd/OsspitaUI/blob/main/Front/src/assets/firefox.png">
    <img style="width:24px; height:24px;" src="https://github.com/ask0ldd/OsspitaUI/blob/main/Front/src/assets/brave.png">
    <span style="display:flex; height:100%;">&</span>
    <img style="width:24px; height:24px;" src="https://github.com/ask0ldd/OsspitaUI/blob/main/Front/src/assets/ubuntu.png">
    <img style="width:24px; height:24px;" src="https://github.com/ask0ldd/OsspitaUI/blob/main/Front/src/assets/chrome.png">
    <img style="width:24px; height:24px;" src="https://github.com/ask0ldd/OsspitaUI/blob/main/Front/src/assets/firefox.png">
    <img style="width:24px; height:24px;" src="https://github.com/ask0ldd/OsspitaUI/blob/main/Front/src/assets/brave.png">
</div>

# OSSPITA : 로컬에서 AI 어시스턴트를 실행하고 직관적인 인터페이스를 통해 몇 번의 클릭만으로 모든 에이전트를 조정해보세요. 비용 없이 보장된 프라이버시를 누리실 수 있습니다.

OSSPITA는 경량화된 완전 로컬 오픈소스 데스크탑 인터페이스로, 사용자가 다양한 오픈소스 LLM과 무료이자 실시간으로 상호작용할 수 있게 합니다. [Ollama API](https://github.com/ollama/ollama)를 활용하여 OSSPITA는 최첨단 AI 기술과의 친근한 경험을 제공합니다.

![osspita main](https://github.com/ask0ldd/OsspitaUI/blob/main/Front/src/assets/screenshot2.png "osspita main")

알파 1.0.1 버전의 영상 데모, 더 최신 영상이 곧 업데이트 됩니다 :

[![OSspita Video Demo](https://img.youtube.com/vi/zKxcANYu-9I/0.jpg)](https://www.youtube.com/watch?v=zKxcANYu-9I "OSspita Video Demo")<br>
_위 이미지를 클릭하면 유튜브에서 영상을 시청할 수 있습니다_

## I - 기능

- 대부분의 오픈소스 AI 모델과의 **실시간 상호작용**.
- 경량화 및 **완전 로컬** 운영.
- **초보자 친화적인** 설치 과정.
- 다중 컨텍스트 에이전트 조정.
- **라마 비전(Llama Vision)** 지원.
- 다양한 역사적 인물과의 채팅 기능.
- 복잡한 작업 해결을 위한 **에이전트 체이닝**.
- 문서 탐색이 가능한 개인정보 **보호 기능을 갖춘 검색 증강 생성(Retrieval Augmented Generation)**.
- 최신 정보를 위한 웹 검색 기능 통합.
- 포괄적인 추론 통계.
- **컨텍스트 길이 조정**을 위한 메모리 할당 추적.
- (버전 관리 예정인) **프롬프트 라이브러리**.
- 가장 일반적인 **LLM 설정**에 대한 쉬운 접근.

## II - 향후 계획

- **반응형** 디자인.
- 에이전트 체이닝에 **병렬 처리** 추가.
- 향상된 옵션을 갖춘 웹 검색 알고리즘 개선.
- 온라인 도메인 이름 순위 제공.
- 향상된 옵션의 RAG 알고리즘 개선.
- 온라인 프롬프트 및 에이전트 공유 플랫폼.
- 프롬프트 버전 관리 시스템.
- 전용 코딩 에이전트.
- 코드 구문 하이라이팅.
- **다크 모드** 테마.
- 차트 생성 기능.
- 음성 모드.
- 컨텍스트 자동 크기 조정 옵션.
- 심층 RAG 통계 및 데이터.
- 심층 웹 검색 통계 및 데이터.

## III - 스크린샷

![osspita main](https://github.com/ask0ldd/OsspitaUI/blob/main/Front/src/assets/screenshot1.png "osspita main")

## IV - 시작하기

### 필수 조건

- Node.js (v22.11.0 이상) : https://nodejs.org/en/
- npm (10.9.0 이상)
- Ollama (로컬 설치 및 실행) : https://ollama.com/download
- OSspita 백엔드 실행 중.
- 최소 하나 이상의 오픈소스 모델.
- 필요 시 Nvidia CUDA : https://developer.nvidia.com/cuda-downloads

모델 추천 :

| GPU VRAM   | 모델              | 용도           | 링크                                                                 |
| ---------- | ----------------- | -------------- | -------------------------------------------------------------------- |
| 4GB        | Llama 3.2:3b      | 대화형         | [Ollama의 Llama 3.2](https://ollama.com/library/llama3.2:3b)              |
| 8GB        | Aya Expanse:8b    | 대화형         | [Ollama의 Aya Expanse](https://ollama.com/library/aya-expanse:8b)   |
| 12GB       | Mistral Nemo:12b  | 대화형         | [Ollama의 Mistral Nemo](https://ollama.com/library/mistral-nemo:12b)           |
| 4GB        | starcoder2:3b     | 코딩           | [Ollama의 StarCoder2](https://ollama.com/library/starcoder2)        |
| 8GB & 12GB | qwen2.5-coder:7b  | 코딩           | [Ollama의 Qwen 2.5 Coder](https://ollama.com/library/qwen2.5-coder) |

### 설치

레포지토리 클론 :

> git clone https://github.com/ask0ldd/OsspitaUI.git

프로젝트 디렉터리로 이동 :

> cd OsspitaUI

#### 프론트엔드

> cd front

의존성 설치:
> npm install

개발 서버를 시작합니다:

> npm run dev

브라우저를 열고 http://localhost:5173 에 접속하여 나머지 설치 과정을 안내받으세요.

## V - 사용법

비디오 데모 :

## VI - 사용된 기술

- React 18.3.1
- Vite
- Ollama API
- ExpressJS
- LokiJS
- Zustand
- Duck-duck-scrape
- Cheerio
- React-pdftotext
- Marked 14.1.1
- Turndown
- Cors
- BodyParser

## VII - 기여

버그가 발생했거나 기능 추가/개선을 원하시면 요청 사항과 함께 이슈를 열어주세요. 도움에 진심으로 감사드립니다.

## VIII - 감사의 말

- llama.cpp의 Georgi Gerganov 및 모든 관련 기여자분들께.
- 추론에 사용된 API를 제공한 Ollama 팀에 감사드립니다.
- 훌륭한 도구를 제공한 React 및 Vite 커뮤니티에 감사드립니다.
- 프로젝트의 모든 기여자 및 후원자분들께.
- GGUF 모델을 제작하는 모든 분들께.
- 마지막으로, 제가 사용한 라이브러리들에 참여한 모든 분들께.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-22

---
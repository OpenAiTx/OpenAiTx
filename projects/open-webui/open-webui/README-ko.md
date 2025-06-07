# Open WebUI 👋

![GitHub stars](https://img.shields.io/github/stars/open-webui/open-webui?style=social)
![GitHub forks](https://img.shields.io/github/forks/open-webui/open-webui?style=social)
![GitHub watchers](https://img.shields.io/github/watchers/open-webui/open-webui?style=social)
![GitHub repo size](https://img.shields.io/github/repo-size/open-webui/open-webui)
![GitHub language count](https://img.shields.io/github/languages/count/open-webui/open-webui)
![GitHub top language](https://img.shields.io/github/languages/top/open-webui/open-webui)
![GitHub last commit](https://img.shields.io/github/last-commit/open-webui/open-webui?color=red)
[![Discord](https://img.shields.io/badge/Discord-Open_WebUI-blue?logo=discord&logoColor=white)](https://discord.gg/5rJgQTnV4s)
[![](https://img.shields.io/static/v1?label=Sponsor&message=%E2%9D%A4&logo=GitHub&color=%23fe8e86)](https://github.com/sponsors/tjbck)

**Open WebUI는 [확장 가능](https://docs.openwebui.com/features/plugin/)하며, 다양한 기능을 갖추고 사용자 친화적인 셀프 호스팅 AI 플랫폼입니다. 완전히 오프라인으로 동작하도록 설계되었습니다.** Ollama와 **OpenAI 호환 API** 등 다양한 LLM 러너를 지원하며, **내장 추론 엔진**을 통한 RAG 지원으로 **강력한 AI 배포 솔루션**을 제공합니다.

![Open WebUI Demo](./demo.gif)

> [!TIP]  
> **[엔터프라이즈 플랜](https://docs.openwebui.com/enterprise)을 찾고 계신가요?** – **[영업팀에 문의하세요!](mailto:sales@openwebui.com)**
>
> **맞춤 테마 및 브랜딩**, **서비스 수준 계약(SLA) 지원**, **장기 지원(LTS) 버전** 등 **확장된 기능**을 이용해보세요!

자세한 내용은 [Open WebUI 공식 문서](https://docs.openwebui.com/)를 참고하세요.

## Open WebUI의 주요 기능 ⭐

- 🚀 **간편한 설치**: Docker 또는 Kubernetes(kubectl, kustomize, helm)를 사용하여 손쉽게 설치할 수 있습니다. `:ollama` 및 `:cuda` 태그 이미지를 모두 지원합니다.

- 🤝 **Ollama/OpenAI API 통합**: OpenAI 호환 API를 손쉽게 통합하여 Ollama 모델과 다양한 대화를 나눌 수 있습니다. OpenAI API URL을 사용자 지정하여 **LMStudio, GroqCloud, Mistral, OpenRouter 등**과 연동할 수 있습니다.

- 🛡️ **세분화된 권한 및 사용자 그룹**: 관리자는 세부적인 사용자 역할과 권한을 생성할 수 있어 보안이 강화됩니다. 세분화된 권한은 맞춤형 사용자 경험을 제공하고, 사용자에게 소유감과 책임감을 부여합니다.

- 📱 **반응형 디자인**: 데스크탑, 노트북, 모바일 등 다양한 기기에서 매끄러운 사용 경험을 제공합니다.

- 📱 **모바일용 PWA(프로그레시브 웹 앱)**: 모바일 기기에서 네이티브 앱과 유사한 경험을 제공하며, localhost에서 오프라인 접근과 원활한 UI를 지원합니다.

- ✒️🔢 **Markdown 및 LaTeX 완벽 지원**: 풍부한 상호작용을 위해 LLM 경험에 완전한 Markdown 및 LaTeX 기능을 제공합니다.

- 🎤📹 **핸즈프리 음성/영상 통화**: 통합된 핸즈프리 음성 및 영상 통화 기능으로 더욱 동적이고 인터랙티브한 채팅 환경을 경험하세요.

- 🛠️ **모델 빌더**: 웹 UI를 통해 Ollama 모델을 손쉽게 생성할 수 있습니다. 커스텀 캐릭터/에이전트 생성, 채팅 요소 맞춤 설정, [Open WebUI 커뮤니티](https://openwebui.com/) 연동을 통한 모델 가져오기가 간편합니다.

- 🐍 **네이티브 파이썬 함수 호출 도구**: 도구 작업공간의 내장 코드 에디터 지원으로 LLM 기능을 확장할 수 있습니다. 순수 파이썬 함수만 추가하면 LLM과 원활하게 통합됩니다.

- 📚 **로컬 RAG 통합**: 혁신적인 RAG(Retrieval Augmented Generation) 지원으로 채팅 상호작용의 미래를 경험하세요. 문서를 채팅에 직접 불러오거나, 문서 라이브러리에 파일을 추가 후 `#` 명령어로 쉽게 접근할 수 있습니다.

- 🔍 **RAG용 웹 검색**: `SearXNG`, `Google PSE`, `Brave Search`, `serpstack`, `serper`, `Serply`, `DuckDuckGo`, `TavilySearch`, `SearchApi`, `Bing` 등의 공급자를 통해 웹 검색을 수행하고, 결과를 채팅에 바로 삽입할 수 있습니다.

- 🌐 **웹 브라우징 기능**: `#` 명령어 뒤에 URL을 입력하여 웹사이트를 채팅에 통합할 수 있습니다. 이 기능으로 웹 콘텐츠를 직접 대화에 활용할 수 있어 상호작용의 풍부함이 증대됩니다.

- 🎨 **이미지 생성 통합**: AUTOMATIC1111 API, ComfyUI(로컬), OpenAI의 DALL-E(외부) 등 다양한 옵션을 통해 이미지 생성 기능을 통합하여 역동적인 시각 콘텐츠로 채팅 경험을 풍부하게 합니다.

- ⚙️ **다중 모델 동시 대화**: 여러 모델과 동시에 대화하며 각각의 고유한 강점을 활용하여 최적의 답변을 얻을 수 있습니다. 다양한 모델을 병렬로 활용해 경험을 확장하세요.

- 🔐 **역할 기반 접근 제어(RBAC)**: 제한된 권한으로 안전한 접근을 보장하며, Ollama 접근 및 모델 생성/불러오기 권한은 관리자에게만 부여됩니다.

- 🌐🌍 **다국어 지원**: 국제화(i18n) 지원으로 선호하는 언어로 Open WebUI를 사용할 수 있습니다. 지원 언어 확장을 위해 기여자를 모집합니다!

- 🧩 **파이프라인, Open WebUI 플러그인 지원**: [Pipelines Plugin Framework](https://github.com/open-webui/pipelines)를 이용해 Open WebUI에 맞춤 로직과 파이썬 라이브러리를 통합하세요. Pipelines 인스턴스를 실행하고 OpenAI URL을 Pipelines URL로 설정하여 무한한 가능성을 탐험해보세요. [예시](https://github.com/open-webui/pipelines/tree/main/examples)로는 **함수 호출**, 사용자 **요율 제한**, **Langfuse**와 같은 도구를 통한 **사용량 모니터링**, **LibreTranslate를 활용한 실시간 번역**, **유해 메시지 필터링** 등이 있습니다.

- 🌟 **지속적인 업데이트**: 정기적인 업데이트, 버그 수정, 새로운 기능 추가로 Open WebUI를 꾸준히 개선하고 있습니다.

Open WebUI의 기능에 대해 더 알고 싶으신가요? [Open WebUI 공식 문서](https://docs.openwebui.com/features)에서 자세히 확인하세요!

## 스폰서 🙌

#### 에메랄드

<table>
  <tr>
    <td>
      <a href="https://n8n.io/" target="_blank">
        <img src="https://docs.openwebui.com/sponsors/logos/n8n.png" alt="n8n" style="width: 8rem; height: 8rem; border-radius: .75rem;" />
      </a>
    </td>
    <td>
      N8N • 당신의 인터페이스에 백엔드가 있으신가요?<br><a href="https://n8n.io/">n8n</a>을 사용해보세요
    </td>
  </tr>
  <tr>
    <td>
      <a href="https://warp.dev/open-webui" target="_blank">
        <img src="https://docs.openwebui.com/sponsors/logos/warp.png" alt="n8n" style="width: 8rem; height: 8rem; border-radius: .75rem;" />
      </a>
    </td>
    <td>
      <a href="https://warp.dev/open-webui">Warp</a> • 개발자를 위한 지능형 터미널
    </td>
  </tr>
</table>

---

저희 스폰서 여러분의 아낌없는 지원에 진심으로 감사드립니다. 여러분의 도움으로 프로젝트를 유지·개선하며 커뮤니티에 양질의 결과물을 제공할 수 있습니다. 감사합니다!

## 설치 방법 🚀

### Python pip를 통한 설치 🐍

Open WebUI는 파이썬 패키지 관리자 pip를 이용해 설치할 수 있습니다. **Python 3.11** 버전을 사용하여 호환성 문제를 방지하세요.

1. **Open WebUI 설치**:
   터미널을 열고 다음 명령어를 실행합니다.

   ```bash
   pip install open-webui
   ```

2. **Open WebUI 실행**:
   설치 후, 아래 명령어로 Open WebUI를 시작할 수 있습니다.

   ```bash
   open-webui serve
   ```

이렇게 하면 Open WebUI 서버가 시작되며, [http://localhost:8080](http://localhost:8080)에서 접속할 수 있습니다.

### Docker로 빠른 시작 🐳

> [!NOTE]  
> 일부 Docker 환경에서는 추가 설정이 필요할 수 있습니다. 연결에 문제가 발생하면 [Open WebUI 공식 문서](https://docs.openwebui.com/)의 상세 가이드를 참고하세요.

> [!WARNING]
> Docker로 Open WebUI를 설치할 때, 반드시 Docker 명령어에 `-v open-webui:/app/backend/data`를 포함해야 합니다. 이 단계는 데이터베이스가 올바르게 마운트되어 데이터 손실을 방지하기 위해 매우 중요합니다.

> [!TIP]  
> Ollama가 포함된 Open WebUI 또는 CUDA 가속 기능을 사용하려면, `:cuda` 또는 `:ollama` 태그가 붙은 공식 이미지를 사용하는 것을 권장합니다. CUDA를 활성화하려면 Linux/WSL 시스템에 [Nvidia CUDA container toolkit](https://docs.nvidia.com/dgx/nvidia-container-runtime-upgrade/)을 설치해야 합니다.

### 기본 설정으로 설치

- **Ollama가 현재 컴퓨터에 있을 경우** 아래 명령어를 사용하세요.

  ```bash
  docker run -d -p 3000:8080 --add-host=host.docker.internal:host-gateway -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

- **Ollama가 다른 서버에 있을 경우** 아래 명령어를 사용하세요.

  Ollama가 다른 서버에 있을 경우, `OLLAMA_BASE_URL`을 해당 서버의 URL로 변경하세요.

  ```bash
  docker run -d -p 3000:8080 -e OLLAMA_BASE_URL=https://example.com -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

- **Nvidia GPU 지원으로 Open WebUI 실행** 시 아래 명령어를 사용하세요.

  ```bash
  docker run -d -p 3000:8080 --gpus all --add-host=host.docker.internal:host-gateway -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:cuda
  ```

### OpenAI API 전용 설치

- **OpenAI API만 사용할 경우** 아래 명령어를 사용하세요.

  ```bash
  docker run -d -p 3000:8080 -e OPENAI_API_KEY=your_secret_key -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

### Ollama 번들 지원과 함께 Open WebUI 설치

이 설치 방법은 Open WebUI와 Ollama가 하나의 컨테이너 이미지로 묶여 있어, 단일 명령어로 간편하게 설치할 수 있습니다. 하드웨어 환경에 따라 적절한 명령어를 선택하세요.

- **GPU 지원**:
  GPU 리소스를 활용하려면 다음 명령어를 사용하세요.

  ```bash
  docker run -d -p 3000:8080 --gpus=all -v ollama:/root/.ollama -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:ollama
  ```

- **CPU 전용**:
  GPU를 사용하지 않는 경우 아래 명령어를 사용하세요.

  ```bash
  docker run -d -p 3000:8080 -v ollama:/root/.ollama -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:ollama
  ```

두 명령어 모두 Open WebUI와 Ollama를 내장하여 손쉽게 설치 및 실행할 수 있습니다.

설치 후 [http://localhost:3000](http://localhost:3000)에서 Open WebUI에 접속할 수 있습니다. 즐겁게 사용하세요! 😄

### 기타 설치 방법

Docker가 아닌 네이티브 설치, Docker Compose, Kustomize, Helm 등 다양한 설치 옵션이 있습니다. 자세한 내용은 [Open WebUI 공식 문서](https://docs.openwebui.com/getting-started/) 또는 [Discord 커뮤니티](https://discord.gg/5rJgQTnV4s)를 참고하세요.

### 문제 해결

연결 문제를 겪고 계신가요? [Open WebUI 공식 문서](https://docs.openwebui.com/troubleshooting/)에서 해결 방법을 확인할 수 있습니다. 추가 지원과 커뮤니티 참여를 원하시면 [Open WebUI Discord](https://discord.gg/5rJgQTnV4s)에 방문하세요.

#### Open WebUI: 서버 연결 오류

연결 문제가 발생하는 경우, WebUI Docker 컨테이너가 컨테이너 내부에서 127.0.0.1:11434(host.docker.internal:11434)에 위치한 Ollama 서버에 접근할 수 없는 것이 원인일 수 있습니다. docker 명령어에 `--network=host` 플래그를 추가하여 해결할 수 있습니다. 이때 포트가 3000에서 8080으로 변경되어 접속 주소는 `http://localhost:8080`이 됩니다.

**예시 Docker 명령어**:

```bash
docker run -d --network=host -v open-webui:/app/backend/data -e OLLAMA_BASE_URL=http://127.0.0.1:11434 --name open-webui --restart always ghcr.io/open-webui/open-webui:main
```

### Docker 설치 최신 상태 유지

로컬 Docker 설치본을 최신 버전으로 업데이트하려면 [Watchtower](https://containrrr.dev/watchtower/)를 사용할 수 있습니다.

```bash
docker run --rm --volume /var/run/docker.sock:/var/run/docker.sock containrrr/watchtower --run-once open-webui
```

명령어의 마지막 부분인 `open-webui`를 컨테이너 이름에 맞게 변경하세요.

업데이트 가이드에 대한 자세한 내용은 [Open WebUI 공식 문서](https://docs.openwebui.com/getting-started/updating)를 참고하세요.

### 개발(Dev) 브랜치 사용 🌙

> [!WARNING]
> `:dev` 브랜치는 최신의 불안정한 기능과 변경사항을 포함합니다. 버그나 미완성 기능이 있을 수 있으니 주의해서 사용하세요.

최신 실험 기능을 사용해보고 싶고, 약간의 불안정성을 감수할 수 있다면 아래와 같이 `:dev` 태그를 사용할 수 있습니다.

```bash
docker run -d -p 3000:8080 -v open-webui:/app/backend/data --name open-webui --add-host=host.docker.internal:host-gateway --restart always ghcr.io/open-webui/open-webui:dev
```

### 오프라인 모드

오프라인 환경에서 Open WebUI를 실행할 경우, 환경 변수 `HF_HUB_OFFLINE`을 `1`로 설정하면 인터넷에서 모델을 다운로드하지 않습니다.

```bash
export HF_HUB_OFFLINE=1
```

## 다음은 무엇인가요? 🌟

[Open WebUI 공식 문서](https://docs.openwebui.com/roadmap/)의 로드맵에서 예정된 기능을 확인해보세요.

## 라이선스 📜

이 프로젝트는 [Open WebUI License](LICENSE)(수정된 BSD-3-Clause 라이선스)로 배포됩니다. 기존 BSD-3 라이선스와 동일하게 최소한의 제한으로 소프트웨어를 사용, 수정, 배포(상용 및 독점 제품 포함)할 수 있습니다. 단, LICENSE 파일에 상세히 안내된 대로 "Open WebUI" 브랜딩을 보존해야 하는 추가 조건이 있습니다. 자세한 내용은 [LICENSE](LICENSE) 문서를 참고하세요. 📄

## 지원 💬

질문, 건의, 도움이 필요하시면 issue를 남기거나
[Open WebUI Discord 커뮤니티](https://discord.gg/5rJgQTnV4s)에 참여해주세요! 🤝

## 스타 히스토리

<a href="https://star-history.com/#open-webui/open-webui&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date" />
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date" />
  </picture>
</a>

---

[Timothy Jaeryang Baek](https://github.com/tjbck) 제작 – Open WebUI를 함께 더 멋지게 만들어봐요! 💪

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---
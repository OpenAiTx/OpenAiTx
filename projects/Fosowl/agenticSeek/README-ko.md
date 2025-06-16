# AgenticSeek: 프라이빗, 로컬 Manus 대안

<p align="center">
<img align="center" src="https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/agentic_seek_logo.png" width="300" height="300" alt="Agentic Seek Logo">
<p>

  English | [中文](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_CHS.md) | [繁體中文](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_CHT.md) | [Français](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_FR.md) | [日本語](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_JP.md) | [Português (Brasil)](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_PTBR.md) | [Español](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_ES.md)

* **Manus AI의 100% 로컬 대안**인 이 음성 인식 AI 어시스턴트는 웹을 자동으로 탐색하고, 코드를 작성하며, 작업을 계획합니다. 모든 데이터는 사용자의 장치에만 보관됩니다. 로컬 추론 모델에 최적화되어 있으며, 모든 기능이 완전히 사용자의 하드웨어에서 실행되어 완전한 프라이버시와 클라우드 의존도 0%를 보장합니다.*

[![Visit AgenticSeek](https://img.shields.io/static/v1?label=Website&message=AgenticSeek&color=blue&style=flat-square)](https://fosowl.github.io/agenticSeek.html) ![License](https://img.shields.io/badge/license-GPL--3.0-green) [![Discord](https://img.shields.io/badge/Discord-Join%20Us-7289DA?logo=discord&logoColor=white)](https://discord.gg/8hGDaME3TC) [![Twitter](https://img.shields.io/twitter/url/https/twitter.com/fosowl.svg?style=social&label=Update%20%40Fosowl)](https://x.com/Martin993886460) [![GitHub stars](https://img.shields.io/github/stars/Fosowl/agenticSeek?style=social)](https://github.com/Fosowl/agenticSeek/stargazers)

### 왜 AgenticSeek인가?

* 🔒 완전 로컬 & 프라이빗 - 모든 것이 사용자의 컴퓨터에서 실행됩니다. 클라우드, 데이터 공유 없음. 파일, 대화, 검색 모두 프라이빗하게 유지됩니다.

* 🌐 스마트 웹 브라우징 - AgenticSeek은 스스로 인터넷을 검색, 읽기, 정보 추출, 웹 폼 작성 등 완전 자동으로 수행합니다.

* 💻 자율 코딩 어시스턴트 - 코드가 필요하신가요? Python, C, Go, Java 등 다양한 언어로 프로그램을 작성, 디버깅, 실행까지 스스로 합니다.

* 🧠 스마트 에이전트 선택 - 사용자가 요청하면, 작업에 최적화된 에이전트를 자동으로 선정합니다. 전문가 팀이 대기 중인 느낌을 경험하세요.

* 📋 복잡한 작업의 계획 및 실행 - 여행 계획부터 복잡한 프로젝트까지, 대형 작업을 단계별로 분할하고 여러 AI 에이전트를 활용해 완수합니다.

* 🎙️ 음성 지원 - 빠르고 미래지향적인 음성 및 음성-텍스트 변환으로, 마치 SF 영화 속 개인 AI와 대화하듯 사용할 수 있습니다. (개발 중)

### **데모**

> *agenticSeek 프로젝트를 검색하고, 필요한 기술을 파악한 후, CV_candidates.zip을 열고, 프로젝트와 가장 잘 맞는 후보를 알려줘*

https://github.com/user-attachments/assets/b8ca60e9-7b3b-4533-840e-08f9ac426316

면책 조항: 이 데모에 등장하는 모든 파일(예: CV_candidates.zip)은 모두 허구입니다. 우리는 기업이 아니며, 지원자가 아닌 오픈소스 기여자를 찾고 있습니다.

> 🛠⚠️️ **현재 활발히 개발 중**

> 🙏 이 프로젝트는 사이드 프로젝트로 시작되어 로드맵과 자금이 전혀 없습니다. GitHub Trending에 오르며 예상보다 훨씬 성장했습니다. 기여, 피드백, 그리고 인내에 깊이 감사드립니다.

## 사전 준비 사항

시작하기 전에 다음 소프트웨어가 설치되어 있는지 확인하세요:

*   **Git:** 저장소 클론용. [Git 다운로드](https://git-scm.com/downloads)
*   **Python 3.10.x:** Python 3.10.x 버전 사용을 강력 권장합니다. 다른 버전은 의존성 오류가 발생할 수 있습니다. [Python 3.10 다운로드](https://www.python.org/downloads/release/python-3100/) (3.10.x 버전 선택).
*   **Docker Engine & Docker Compose:** SearxNG 등 번들 서비스 실행용.
    *   Docker Desktop(Compose V2 포함) 설치: [Windows](https://docs.docker.com/desktop/install/windows-install/) | [Mac](https://docs.docker.com/desktop/install/mac-install/) | [Linux](https://docs.docker.com/desktop/install/linux-install/)
    *   또는 리눅스에서 Docker Engine과 Docker Compose 개별 설치: [Docker Engine](https://docs.docker.com/engine/install/) | [Docker Compose](https://docs.docker.com/compose/install/) (Compose V2 설치 필요, 예: `sudo apt-get install docker-compose-plugin`).

### 1. **저장소 클론 및 설정**

```sh
git clone https://github.com/Fosowl/agenticSeek.git
cd agenticSeek
mv .env.example .env
```

### 2. .env 파일 내용 변경

```sh
SEARXNG_BASE_URL="http://127.0.0.1:8080"
REDIS_BASE_URL="redis://redis:6379/0"
WORK_DIR="/Users/mlg/Documents/workspace_for_ai"
OLLAMA_PORT="11434"
LM_STUDIO_PORT="1234"
CUSTOM_ADDITIONAL_LLM_PORT="11435"
OPENAI_API_KEY='optional'
DEEPSEEK_API_KEY='optional'
OPENROUTER_API_KEY='optional'
TOGETHER_API_KEY='optional'
GOOGLE_API_KEY='optional'
ANTHROPIC_API_KEY='optional'
```

필요에 따라 `.env` 파일을 본인 환경에 맞게 수정하세요:

- **SEARXNG_BASE_URL**: 변경 없이 유지
- **REDIS_BASE_URL**: 변경 없이 유지
- **WORK_DIR**: 로컬 PC의 작업 디렉터리 경로. AgenticSeek이 이 파일에 접근 및 상호작용할 수 있습니다.
- **OLLAMA_PORT**: Ollama 서비스 포트 번호
- **LM_STUDIO_PORT**: LM Studio 서비스 포트 번호
- **CUSTOM_ADDITIONAL_LLM_PORT**: 추가 커스텀 LLM 서비스 포트

**API Key는 로컬에서 LLM을 실행하는 사용자의 경우 완전히 선택 사항입니다. 이 프로젝트의 주요 목적이기도 합니다. 하드웨어가 충분하다면 비워 두세요.**

### 3. **Docker 시작**

시스템에 Docker가 설치되어 실행 중인지 확인하세요. 다음 명령어로 Docker를 시작할 수 있습니다:

- **Linux/macOS:**  
    터미널에서 아래를 실행:
    ```sh
    sudo systemctl start docker
    ```
    또는 Docker Desktop이 설치되어 있다면 애플리케이션 메뉴에서 실행하세요.

- **Windows:**  
    시작 메뉴에서 Docker Desktop을 실행하세요.

Docker가 정상 실행 중인지 아래로 확인:
```sh
docker info
```
Docker 설치 정보가 보이면 정상적으로 실행 중입니다.

아래 [로컬 제공자 목록](#list-of-local-providers) 표를 참고하세요.

다음 단계: [AgenticSeek 로컬 실행](#start-services-and-run)

*문제가 있을 경우 [문제 해결](#troubleshooting) 섹션을 참고하세요.*
*로컬에서 LLM 실행이 어렵다면 [API로 실행 설정](#setup-to-run-with-an-api)을 참고하세요.*
*자세한 `config.ini` 설명은 [설정 섹션](#config)을 참고하세요.*

---

## 내 PC에서 LLM 로컬 실행 설정

**하드웨어 요구사항:**

LLM을 로컬에서 실행하려면 충분한 하드웨어가 필요합니다. 최소한 Magistral, Qwen 또는 Deepseek 14B를 실행할 수 있는 GPU가 필요합니다. 자세한 모델/성능 권장사항은 FAQ를 참고하세요.

**로컬 제공자 설정**  

예시로 ollama로 로컬 제공자를 시작합니다:

```sh
ollama serve
```

아래에서 지원되는 로컬 제공자 목록을 확인하세요.

**config.ini 업데이트**

config.ini 파일에서 provider_name을 지원되는 제공자로, provider_model을 해당 제공자가 지원하는 LLM으로 설정하세요. *Magistral* 또는 *Deepseek* 등 추론 모델을 권장합니다.

필요 하드웨어는 README 마지막의 **FAQ**를 참고하세요.

```sh
[MAIN]
is_local = True # 로컬 또는 원격 제공자 사용 여부
provider_name = ollama # 또는 lm-studio, openai 등
provider_model = deepseek-r1:14b # 하드웨어에 맞는 모델 선택
provider_server_address = 127.0.0.1:11434
agent_name = Jarvis # AI의 이름
recover_last_session = True # 이전 세션 복구 여부
save_session = True # 현재 세션 저장 여부
speak = False # 텍스트 음성 변환
listen = False # 음성 인식, CLI 전용, 실험적
jarvis_personality = False # "Jarvis" 스타일 성격 사용 여부(실험적)
languages = en zh # 지원 언어 목록, 텍스트 음성 변환은 첫 번째 언어로 기본 설정
[BROWSER]
headless_browser = True # CLI 사용 시에만 변경, 그 외는 유지
stealth_mode = True # 탐지 우회를 위한 undetected selenium 사용
```

**경고**:

- `config.ini` 파일 형식은 주석을 지원하지 않습니다. 
예시 설정을 복사-붙여넣기 하지 마세요. 주석이 포함되면 오류가 발생합니다. 원하는 설정만 직접 입력해 수정하세요.

- LM-studio로 LLM을 실행할 경우 provider_name을 `openai`로 설정하지 마세요. 반드시 `lm-studio`로 설정하세요.

- 일부 제공자(예: lm-studio)는 IP 앞에 `http://`가 필요합니다. 예시: `http://127.0.0.1:1234`

**로컬 제공자 목록**

| 제공자     | 로컬 지원 | 설명                                                    |
|-----------|--------|---------------------------------------------------------|
| ollama    | 예     | ollama를 LLM 제공자로 사용하여 쉽게 로컬에서 실행         |
| lm-studio | 예     | LM studio를 통해 로컬 LLM 실행 (`provider_name`을 `lm-studio`로 설정)|
| openai    | 예     | openai 호환 API 사용 (예: llama.cpp 서버)                |

다음 단계: [서비스 시작 및 AgenticSeek 실행](#Start-services-and-Run)  

*문제가 있을 경우 [문제 해결](#troubleshooting) 섹션을 참고하세요.*
*로컬에서 LLM 실행이 어렵다면 [API로 실행 설정](#setup-to-run-with-an-api)을 참고하세요.*
*자세한 `config.ini` 설명은 [설정 섹션](#config)을 참고하세요.*

## API로 실행 설정

이 설정은 외부 클라우드 기반 LLM 제공자를 사용합니다. 원하는 서비스의 API 키가 필요합니다.

**1. API 제공자 선택 및 API 키 발급:**

아래 [API 제공자 목록](#list-of-api-providers)을 참고하여 웹사이트에서 회원가입 후 API 키를 발급받으세요.

**2. API 키를 환경 변수로 설정:**


*   **Linux/macOS:**
    터미널을 열고 `export` 명령을 사용하세요. 영구 적용을 위해 셸 프로필 파일(예: `~/.bashrc`, `~/.zshrc`)에 추가하는 것이 좋습니다.
    ```sh
    export PROVIDER_API_KEY="your_api_key_here" 
    # PROVIDER_API_KEY를 실제 변수명(예: OPENAI_API_KEY, GOOGLE_API_KEY)으로 변경하세요.
    ```
    TogetherAI 예시:
    ```sh
    export TOGETHER_API_KEY="xxxxxxxxxxxxxxxxxxxxxx"
    ```
*   **Windows:**
*   **명령 프롬프트(현재 세션에서 임시로 설정):**
    ```cmd
    set PROVIDER_API_KEY=your_api_key_here
    ```
*   **PowerShell(현재 세션에서 임시로 설정):**
    ```powershell
    $env:PROVIDER_API_KEY="your_api_key_here"
    ```
*   **영구적으로 설정:** Windows 검색창에서 "환경 변수"를 검색한 뒤, "시스템 환경 변수 편집"을 클릭하고, "환경 변수..." 버튼을 누릅니다. 적절한 이름(예: `OPENAI_API_KEY`)과 값으로 새로운 사용자 변수를 추가하세요.

*(자세한 내용은 FAQ: [API 키는 어떻게 설정하나요?](#how-do-i-set-api-keys) 참고)*


**3. `config.ini` 업데이트:**
```ini
[MAIN]
is_local = False
provider_name = openai # 또는 google, deepseek, togetherAI, huggingface
provider_model = gpt-3.5-turbo # 또는 gemini-1.5-flash, deepseek-chat, mistralai/Mixtral-8x7B-Instruct-v0.1 등
provider_server_address = # 대부분의 API에서 is_local = False일 때 일반적으로 무시되거나 비워둘 수 있음
# ... 기타 설정 ...
```
*경고:* `config.ini` 값에 공백(띄어쓰기)이 뒤따르지 않도록 하세요.

**API 제공자 목록**

| 제공자        | `provider_name` | 로컬? | 설명                                               | API 키 링크(예시)                             |
|---------------|-----------------|-------|----------------------------------------------------|-----------------------------------------------|
| OpenAI        | `openai`        | 아니오| OpenAI의 API를 통해 ChatGPT 모델 사용                | [platform.openai.com/signup](https://platform.openai.com/signup) |
| Google Gemini | `google`        | 아니오| Google AI Studio를 통해 Google Gemini 모델 사용      | [aistudio.google.com/keys](https://aistudio.google.com/keys) |
| Deepseek      | `deepseek`      | 아니오| Deepseek API를 통해 Deepseek 모델 사용               | [platform.deepseek.com](https://platform.deepseek.com) |
| Hugging Face  | `huggingface`   | 아니오| Hugging Face Inference API의 모델 사용               | [huggingface.co/settings/tokens](https://huggingface.co/settings/tokens) |
| TogetherAI    | `togetherAI`    | 아니오| TogetherAI API를 통해 다양한 오픈소스 모델 사용       | [api.together.ai/settings/api-keys](https://api.together.ai/settings/api-keys) |

*참고:*
*   복잡한 웹 브라우징 및 작업 계획에는 `gpt-4o` 또는 기타 OpenAI 모델 사용을 권장하지 않습니다. 현재 프롬프트 최적화는 Deepseek와 같은 모델에 맞춰져 있습니다.
*   코딩/bash 작업은 Gemini에서 프롬프트 포맷팅을 엄격히 따르지 않아 문제가 발생할 수 있습니다.
*   `config.ini`의 `provider_server_address`는 `is_local = False`일 때는 일반적으로 사용되지 않으며, 각 제공자 라이브러리에서 API 엔드포인트가 하드코딩되어 있습니다.

다음 단계: [서비스 시작 및 AgenticSeek 실행](#Start-services-and-Run)

*문제가 발생하면 **Known issues**(알려진 문제) 섹션을 참고하세요.*

*자세한 설정 파일 설명은 **Config** 섹션을 참고하세요.*

---

## 서비스 시작 및 실행

기본적으로 AgenticSeek는 도커(docker)에서 완전히 실행됩니다.

필요한 서비스를 시작하세요. 이는 docker-compose.yml의 모든 서비스를 시작합니다. 포함된 서비스:
    - searxng
    - redis (searxng에서 필요)
    - frontend
    - backend(`full` 사용 시)

```sh
./start_services.sh full # MacOS
start ./start_services.cmd full # Window
```

**경고:** 이 단계는 모든 도커 이미지를 다운로드 및 로드합니다. 최대 30분이 소요될 수 있습니다. 서비스를 시작한 후, 백엔드 서비스가 완전히 실행될 때까지 기다리세요(로그에서 **backend: "GET /health HTTP/1.1" 200 OK** 메시지를 확인할 수 있음). 백엔드 서비스는 첫 실행 시 5분 정도 소요될 수 있습니다.

`http://localhost:3000/`에 접속하면 웹 인터페이스가 나타납니다.

*서비스 시작 문제 해결:* 스크립트가 실패하면 Docker Engine이 실행 중인지, Docker Compose(V2, `docker compose`)가 올바르게 설치되어 있는지 확인하세요. 터미널의 출력 오류 메시지를 확인하세요. [FAQ: AgenticSeek 또는 스크립트 실행 시 오류가 발생합니다.](#faq-troubleshooting) 참고

**선택 사항:** 호스트에서 실행(CLI 모드):

CLI 인터페이스로 실행하려면 패키지를 호스트에 설치해야 합니다.

```sh
./install.sh
./install.bat # windows
```

서비스 시작:

```sh
./start_services.sh # MacOS
start ./start_services.cmd # Window
```

CLI 사용: `python3 cli.py`


---

## 사용법

`./start_services.sh full`로 서비스가 정상적으로 실행 중인지 확인하고, 웹 인터페이스는 `localhost:3000`에서 접속하세요.

CLI 모드에서 `listen = True`로 설정하면 음성 인식(speech to text)도 사용할 수 있습니다.

종료하려면 `goodbye`라고 말하거나 입력하면 됩니다.

사용 예시는 다음과 같습니다:

> *파이썬으로 뱀 게임을 만들어줘!*

> *프랑스 렌(Rennes)의 인기 카페를 웹에서 검색해서, 3곳의 주소와 함께 rennes_cafes.txt에 저장해줘.*

> *숫자의 팩토리얼을 계산하는 Go 프로그램을 작성해서, 작업 공간에 factorial.go로 저장해줘.*

> *내 summer_pictures 폴더의 모든 JPG 파일을 찾아, 오늘 날짜로 파일명을 변경하고, 변경된 파일 목록을 photos_list.txt에 저장해줘.*

> *2024년의 인기 공상과학 영화를 온라인에서 검색해서, 오늘 밤 볼 영화 3편을 고르고 movie_night.txt에 저장해줘.*

> *2025년 최신 AI 뉴스 기사를 웹에서 검색해 3건을 골라, 제목과 요약을 스크랩하는 파이썬 스크립트를 작성해줘. 스크립트는 news_scraper.py, 요약은 ai_news.txt에 /home/projects에 저장해줘.*

> *금요일에 무료 주가 API를 찾아 supersuper7434567@gmail.com으로 가입하고, 해당 API로 테슬라의 일일 주가를 가져오는 파이썬 스크립트를 작성해 stock_prices.csv에 저장해줘.*

*양식 자동 입력(Form filling)은 아직 실험적 기능이며 실패할 수 있습니다.*


질문을 입력하면 AgenticSeek가 해당 작업에 가장 적합한 에이전트를 할당합니다.

초기 프로토타입이기 때문에, 에이전트 라우팅 시스템이 항상 올바른 에이전트를 할당하지 않을 수 있습니다.

따라서 원하는 바와 AI가 어떻게 진행해야 하는지 명확히 지시하는 것이 좋습니다. 예를 들어, 웹 검색을 원한다면 다음과 같이 하지 마세요:

`혼자 여행하기 좋은 나라 알아?`

대신 다음과 같이 요청하세요:

`웹 검색을 해서 혼자 여행하기 좋은 나라를 찾아줘`

---

## **자체 서버에서 LLM 실행 설정**  

강력한 컴퓨터나 서버가 있고, 이를 랩탑 등에서 원격으로 사용하고 싶다면 커스텀 llm 서버를 이용해 원격 서버에서 LLM을 실행할 수 있습니다.

AI 모델을 실행할 "서버"에서 ip 주소를 확인하세요.

```sh
ip a | grep "inet " | grep -v 127.0.0.1 | awk '{print $2}' | cut -d/ -f1 # 로컬 IP
curl https://ipinfo.io/ip # 공인 IP
```

참고: Windows 또는 macOS에서는 각각 ipconfig 또는 ifconfig를 사용하여 IP를 확인하세요.

저장소를 클론하고 `server/` 폴더로 진입합니다.


```sh
git clone --depth 1 https://github.com/Fosowl/agenticSeek.git
cd agenticSeek/llm_server/
```

서버 전용 requirements를 설치하세요:

```sh
pip3 install -r requirements.txt
```

서버 스크립트를 실행하세요.

```sh
python3 app.py --provider ollama --port 3333
```

LLM 서비스로 `ollama`와 `llamacpp` 중에서 선택할 수 있습니다.


이제 개인 컴퓨터에서:

`config.ini` 파일에서 `provider_name`을 `server`로, `provider_model`을 `deepseek-r1:xxb`로 설정하세요.
`provider_server_address`는 모델을 실행할 머신의 IP 주소로 지정하세요.

```sh
[MAIN]
is_local = False
provider_name = server
provider_model = deepseek-r1:70b
provider_server_address = x.x.x.x:3333
```


다음 단계: [서비스 시작 및 AgenticSeek 실행](#Start-services-and-Run)  

---

## 음성 인식(Speech to Text)

경고: 현재 음성 인식은 CLI 모드에서만 동작합니다.

현재 영어로만 음성 인식이 가능합니다.

음성 인식 기능은 기본적으로 비활성화되어 있습니다. 활성화하려면 config.ini 파일에서 listen 옵션을 True로 설정하세요:

```
listen = True
```

활성화되면, 음성 인식 기능은 입력 처리 전에 트리거 키워드(에이전트 이름)를 듣습니다. 에이전트 이름은 *config.ini* 파일의 `agent_name` 값을 변경하여 맞춤 설정할 수 있습니다:

```
agent_name = Friday
```

최적의 인식률을 위해 에이전트 이름으로 "John"이나 "Emma"와 같은 일반적인 영어 이름 사용을 권장합니다.

전사(Transcript)가 나타나기 시작하면 에이전트의 이름(예: "Friday")을 소리 내어 불러 깨우세요.

질문을 명확하게 말하세요.

요청을 마칠 때 시스템이 진행하도록 신호를 주는 확인 문구로 끝내세요. 확인 문구 예시는 다음과 같습니다:
```
"do it", "go ahead", "execute", "run", "start", "thanks", "would ya", "please", "okay?", "proceed", "continue", "go on", "do that", "go it", "do you understand?"
```

## Config

예시 config:
```
[MAIN]
is_local = True
provider_name = ollama
provider_model = deepseek-r1:32b
provider_server_address = http://127.0.0.1:11434 # Ollama 예시; LM-Studio는 http://127.0.0.1:1234 사용
agent_name = Friday
recover_last_session = False
save_session = False
speak = False
listen = False

jarvis_personality = False
languages = en zh # TTS 및 라우팅에 사용할 언어 목록.
[BROWSER]
headless_browser = False
stealth_mode = False
```

**`config.ini` 설정 설명**:

*   **`[MAIN]` 섹션:**
    *   `is_local`: 로컬 LLM 제공자(Ollama, LM-Studio, 로컬 OpenAI 호환 서버)나 자체 호스팅 서버를 사용할 때 `True`. 클라우드 기반 API(OpenAI, Google 등) 사용 시 `False`.
    *   `provider_name`: LLM 제공자 지정.
        *   로컬 옵션: `ollama`, `lm-studio`, `openai`(로컬 OpenAI 호환 서버용), `server`(자체 호스팅 서버).
        *   API 옵션: `openai`, `google`, `deepseek`, `huggingface`, `togetherAI`.
    *   `provider_model`: 선택한 제공자의 특정 모델명 또는 ID(예: Ollama의 `deepseekcoder:6.7b`, OpenAI API의 `gpt-3.5-turbo`, TogetherAI의 `mistralai/Mixtral-8x7B-Instruct-v0.1`).
    *   `provider_server_address`: LLM 제공자의 주소.
        *   로컬 제공자: 예를 들어 Ollama는 `http://127.0.0.1:11434`, LM-Studio는 `http://127.0.0.1:1234` 등.
        *   `server` 제공자 유형: 자체 호스팅 LLM 서버 주소(예: `http://your_server_ip:3333`).
        *   클라우드 API(`is_local = False`): 보통 무시되거나 비워둘 수 있음. API 엔드포인트는 클라이언트 라이브러리에서 처리함.
    *   `agent_name`: AI 비서의 이름(예: Friday). 음성 인식 트리거 단어로 사용됨.
    *   `recover_last_session`: 이전 세션 상태 복원을 시도하려면 `True`, 새로 시작하려면 `False`.
    *   `save_session`: 세션 복구를 위해 현재 세션 상태 저장은 `True`, 아니면 `False`.
    *   `speak`: 음성 출력(TTS) 활성화는 `True`, 비활성화는 `False`.
    *   `listen`: 음성 입력(STT, CLI 모드 전용) 활성화는 `True`, 비활성화는 `False`.
    *   `work_dir`: **중요:** AgenticSeek가 파일을 읽고 쓰는 디렉터리. **해당 경로가 유효하고 접근 가능한지 확인하세요.**
    *   `jarvis_personality`: 보다 "Jarvis 스타일" 시스템 프롬프트 사용은 `True`(실험적), 표준 프롬프트는 `False`.
    *   `languages`: 쉼표로 구분된 언어 목록(예: `en, zh, fr`). TTS 음성 선택(기본은 첫 번째 언어)과 LLM 라우터 보조에 사용됨. 라우터 효율성을 위해 너무 많거나 유사한 언어는 피하세요.
*   **`[BROWSER]` 섹션:**
    *   `headless_browser`: 브라우저 창 없이 자동화 브라우저 실행은 `True`(웹 인터페이스/비대화형 사용 권장), 브라우저 창 표시(CLI 모드/디버깅에 유용)는 `False`.
    *   `stealth_mode`: 브라우저 자동화 탐지 방지를 위한 조치 활성화는 `True`. anticaptcha 등 브라우저 확장 수동 설치 필요할 수 있음.


이 섹션은 지원되는 LLM 제공자 유형을 요약합니다. `config.ini`에서 설정하세요.

**로컬 제공자(자체 하드웨어에서 실행):**

| `config.ini`의 Provider Name | `is_local` | 설명                                                                 | 설치 섹션                                                        |
|-------------------------------|------------|---------------------------------------------------------------------|------------------------------------------------------------------|
| `ollama`                      | `True`     | Ollama를 사용해 로컬 LLM 서비스.                                    | [로컬 LLM 실행 설정](#setup-for-running-llm-locally-on-your-machine) |
| `lm-studio`                   | `True`     | LM-Studio를 사용해 로컬 LLM 서비스.                                 | [로컬 LLM 실행 설정](#setup-for-running-llm-locally-on-your-machine) |
| `openai` (로컬 서버용)        | `True`     | OpenAI 호환 API를 노출하는 로컬 서버 연결(예: llama.cpp).           | [로컬 LLM 실행 설정](#setup-for-running-llm-locally-on-your-machine) |
| `server`                      | `False`    | 다른 머신에서 실행 중인 AgenticSeek 자체 호스팅 LLM 서버 연결.      | [자체 서버에서 LLM 실행 설정](#setup-to-run-the-llm-on-your-own-server) |

**API 제공자(클라우드 기반):**

| `config.ini`의 Provider Name | `is_local` | 설명                                          | 설치 섹션                                     |
|-------------------------------|------------|-----------------------------------------------|-----------------------------------------------|
| `openai`                      | `False`    | OpenAI 공식 API 사용(예: GPT-3.5, GPT-4).     | [API로 실행 설정](#setup-to-run-with-an-api)   |
| `google`                      | `False`    | Google Gemini 모델 API 사용.                  | [API로 실행 설정](#setup-to-run-with-an-api)   |
| `deepseek`                    | `False`    | Deepseek 공식 API 사용.                       | [API로 실행 설정](#setup-to-run-with-an-api)   |
| `huggingface`                 | `False`    | Hugging Face 추론 API 사용.                   | [API로 실행 설정](#setup-to-run-with-an-api)   |
| `togetherAI`                  | `False`    | 다양한 오픈 모델용 TogetherAI API 사용.       | [API로 실행 설정](#setup-to-run-with-an-api)   |

---
## 문제 해결

문제가 발생하면 이 섹션에서 안내를 제공합니다.

# 알려진 문제

## ChromeDriver 문제

**오류 예시:** `SessionNotCreatedException: Message: session not created: This version of ChromeDriver only supports Chrome version XXX`

*   **원인:** 설치된 ChromeDriver 버전이 Google Chrome 브라우저 버전과 호환되지 않습니다.
*   **해결 방법:**
    1.  **Chrome 버전 확인:** Google Chrome을 열고 `설정 > Chrome 정보`에서 버전 확인(예: "Version 120.0.6099.110").
    2.  **일치하는 ChromeDriver 다운로드:**
        *   Chrome 115 이상: [Chrome for Testing (CfT) JSON Endpoints](https://googlechromelabs.github.io/chrome-for-testing/)에서 "stable" 채널을 찾아 OS에 맞는 Chrome의 주요 버전에 일치하는 ChromeDriver를 다운로드합니다.
        *   이전 버전(드물게 사용): [ChromeDriver - WebDriver for Chrome](https://chromedriver.chromium.org/downloads) 페이지에서 찾을 수 있습니다.
        *   아래 이미지는 CfT 페이지 예시입니다:
            ![Download Chromedriver specific version from Chrome for Testing page](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/chromedriver_readme.png)
    3.  **ChromeDriver 설치:**
        *   다운로드한 `chromedriver`(Windows는 `chromedriver.exe`)를 시스템 PATH 환경 변수에 포함된 디렉터리에 배치(예: Linux/macOS는 `/usr/local/bin`, Windows는 PATH에 추가한 커스텀 스크립트 폴더).
        *   또는 `agenticSeek` 프로젝트 루트 디렉터리에 위치시켜도 됩니다.
        *   드라이버가 실행 가능해야 합니다(Linux/macOS는 `chmod +x chromedriver`).
    4.  자세한 내용은 설치 가이드의 [ChromeDriver 설치](#chromedriver-installation) 섹션을 참조하세요.

이 섹션이 미완성이거나 추가 ChromeDriver 문제가 있으면 [GitHub Issues](https://github.com/Fosowl/agenticSeek/issues)에서 검색하거나 새 이슈를 등록하세요.

`Exception: Failed to initialize browser: Message: session not created: This version of ChromeDriver only supports Chrome version 113
Current browser version is 134.0.6998.89 with binary path`

브라우저와 chromedriver 버전이 일치하지 않을 때 발생합니다.

최신 버전 다운로드는 아래 링크에서 가능합니다:

https://developer.chrome.com/docs/chromedriver/downloads

Chrome 115 이상을 사용 중이면 다음으로 이동하세요:

https://googlechromelabs.github.io/chrome-for-testing/

운영체제에 맞는 chromedriver 버전을 다운로드하세요.

![alt text](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/chromedriver_readme.png)

이 섹션이 미완성이라면 이슈를 등록해주세요.

##  connection adapters 문제

```
Exception: Provider lm-studio failed: HTTP request failed: No connection adapters were found for '127.0.0.1:1234/v1/chat/completions'` (포트는 다를 수 있음)
```

*   **원인:** `lm-studio`(또는 유사 로컬 OpenAI 호환 서버)의 `config.ini`의 `provider_server_address`에 `http://` 접두사가 없거나 잘못된 포트로 지정됨.
*   **해결 방법:**
    *   주소에 반드시 `http://`가 포함되어야 합니다. LM-Studio는 보통 `http://127.0.0.1:1234`가 기본입니다.
    *   `config.ini`를 수정: `provider_server_address = http://127.0.0.1:1234`(또는 실제 LM-Studio 서버 포트).

## SearxNG Base URL 미제공

```
raise ValueError("SearxNG base URL must be provided either as an argument or via the SEARXNG_BASE_URL environment variable.")
ValueError: SearxNG base URL must be provided either as an argument or via the SEARXNG_BASE_URL environment variable.`
```

## FAQ

**Q: 어떤 하드웨어가 필요합니까?**  

| 모델 크기  | GPU  | 설명                                               |
|-----------|--------|---------------------------------------------------|
| 7B        | 8GB Vram | ⚠️ 비추천. 성능 저하, 환각 빈번, 플래너 에이전트 실패 가능성 높음. |
| 14B        | 12 GB VRAM (예: RTX 3060) | ✅ 단순 작업에는 사용 가능. 웹 브라우징, 플래닝 작업엔 어려울 수 있음. |
| 32B        | 24+ GB VRAM (예: RTX 4090) | 🚀 대부분 작업 성공, 작업 계획에는 아직 어려움 있을 수 있음 |
| 70B+        | 48+ GB Vram | 💪 우수. 고급 사용 사례에 추천.               |

**Q: 오류가 발생하면 어떻게 합니까?**  

로컬이 실행 중인지(`ollama serve`), `config.ini`가 제공자와 일치하는지, 의존성이 설치되어 있는지 확인하세요. 모두 해결되지 않으면 이슈를 등록하세요.

**Q: 정말 100% 로컬 실행이 가능한가요?**  

Ollama, lm-studio, server 제공자 사용 시 음성 인식, LLM, 음성 합성 모두 로컬에서 실행됩니다. 비로컬 옵션(OpenAI 등 API)은 선택사항입니다.

**Q: 이미 Manus가 있는데 왜 AgenticSeek을 써야 하나요?**

Manus와 달리 AgenticSeek은 외부 시스템에 대한 의존도를 줄여 더 많은 제어권, 프라이버시, API 비용 회피를 제공합니다.

**Q: 프로젝트의 개발자는 누구입니까?**

본 프로젝트는 저와 두 명의 친구(오픈소스 커뮤니티의 기여자, 유지보수자)가 함께 만들었습니다. 우리는 스타트업이나 조직 소속이 아닌, 열정적인 개인들입니다.

X(트위터)에서 AgenticSeek 명의의 계정은 제 개인 계정(https://x.com/Martin993886460) 외엔 모두 사칭입니다.

## 기여

AgenticSeek 개선에 기여할 개발자를 찾고 있습니다! 오픈 이슈나 토론을 확인하세요.

[기여 가이드](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/docs/CONTRIBUTING.md)

[![Star History Chart](https://api.star-history.com/svg?repos=Fosowl/agenticSeek&type=Date)](https://www.star-history.com/#Fosowl/agenticSeek&Date)

## Maintainers:

 > [Fosowl](https://github.com/Fosowl) | 파리 시간 

 > [antoineVIVIES](https://github.com/antoineVIVIES) | 타이베이 시간 

 > [steveh8758](https://github.com/steveh8758) | 타이베이 시간 

## Special Thanks:

 > [tcsenpai](https://github.com/tcsenpai) 및 [plitc](https://github.com/plitc) - 백엔드 도커화 지원

## Sponsors:

월 5달러 이상 후원자는 여기에 표시됩니다:
- **tatra-labs**
Certainly! Please provide the content of Part 4 of 4 that you would like translated.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-16

---
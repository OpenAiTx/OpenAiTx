
<div align="center"><p><a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=hi"><img src="https://img.shields.io/badge/हिन्दी-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=fa"><img src="https://img.shields.io/badge/فارسی-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=id"><img src="https://img.shields.io/badge/Bahasa Indonesia-white" alt="version"></a> </p></div>
# AI 어시스턴트를 위한 고급 PubChem MCP 서버

🧪 AI 어시스턴트가 PubChem에서 화학 화합물 정보를 지능적으로 검색하고 접근할 수 있게 해주는, 고급·강력·개인정보 보호 중심의 MCP 서버입니다.

이 PubChem MCP 서버는 AI 어시스턴트(예: AnythingLLM 등)와 PubChem의 방대한 화학 데이터베이스를 연결하는 강력한 다리 역할을 합니다. 모델 컨텍스트 프로토콜(MCP)을 활용하여 AI 모델이 화학 화합물을 스마트하고 견고하게 검색하고, 상세한 속성을 프로그래밍 방식으로 가져올 수 있습니다.

---

## ✨ 핵심 기능

단순한 PubChem 래퍼가 아닙니다. 이 서버는 완전히 새롭게, 매우 견고하고 지능적으로 재설계되었습니다:

-   **🧠 스마트 폴백 검색**: "비타민 D"와 같은 일반명 검색이 실패할 경우, 서버가 자동으로 PubChem Substance 데이터베이스에서 더 깊은 검색을 수행하여 올바른 화합물을 찾아냅니다. 이는 모호한 쿼리의 성공률을 크게 높여줍니다.
-   **🛡️ 견고한 오류 처리 및 재시도**: 서버는 API 오류를 우아하게 처리하도록 설계되었습니다. PubChem에서 "서버가 바쁨" 오류가 발생하면, 자동으로 대기 후 재시도를 하여, 높은 부하 상황에서도 쿼리가 성공하도록 합니다.
-   **🔒 선택적 Tor 프록시 지원**: 개인정보를 완전히 제어할 수 있습니다. 간단한 `config.ini` 파일을 통해 모든 요청을 Tor 네트워크(SOCKS5 또는 HTTP 프록시)를 통해 라우팅할 수 있어, IP 주소 노출을 방지합니다. 서버는 기본적으로 안전하며, 프록시 연결 실패 시에도 절대 IP가 노출되지 않습니다.
-   **🔎 단일 및 다중 화합물 검색**: 하나 또는 여러 화합물에 대한 요청을 한 번의 프롬프트로 매끄럽게 처리합니다.
-   **🧪 상세 속성 조회**: IUPAC 이름, 분자식, 분자량, 그리고 특히 **모노이소토픽 질량**과 같은 주요 화학 속성에 접근할 수 있습니다.

---

---

### 🚀 설치 필요 없음: Smithery.ai에서 바로 사용해보세요

MCP 서버가 처음이거나, 별도의 로컬 설치 없이 이 도구의 기능을 테스트하고 싶다면 Smithery.ai에서 라이브로 호스팅되는 버전을 사용할 수 있습니다. 브라우저에서 직접 에이전트와 채팅할 수 있습니다.

[**<-- Smithery.ai에서 라이브 PubChem 에이전트 탐색하기 -->**](https://smithery.ai/server/@Milor123/smithery-pubchem-deploy)

**시작 방법:**

1.  위 링크를 클릭해 서버 페이지로 이동하세요.
2.  **GitHub** 또는 **Google** 계정으로 로그인하세요.
3.  **"Explore capabilities"** 버튼을 클릭하여 채팅 인터페이스를 열고 바로 테스트를 시작하세요!

> **✅ 최적의 결과를 위한 추천 모델**
>
> 특히 긴 소수점 숫자 등에서 최고의 정확도를 얻으려면 강력한 모델 사용을 적극 권장합니다. 다음 모델들은 테스트를 거쳐 이 도구와 매우 잘 작동합니다:
>
> *   **Anthropic의 Claude 3 Sonnet**

> *   **OpenAI의 GPT-4 Turbo** (또는 GPT-4o와 같은 최신 버전)
>
> 두 모델 모두 도구에서 반환된 소수점 숫자의 전체 정밀도를 올바르게 처리하며, 반올림이 발생하지 않음을 확인했습니다.

---

## 🚀 빠른 시작 및 설치

이 서버는 로컬에서 실행되도록 설계되었으며, 데스크탑이나 AnythingLLM Docker 환경에서 사용할 수 있습니다.

### 1. 필수 구성 요소

이 프로젝트는 몇 가지 Python 라이브러리에 의존합니다. 환경에 이들이 설치되어 있는지 확인하세요.

다음 내용을 포함하는 `requirements.txt` 파일을 만드세요:
```txt
requests
bs4 
mcp 
pubchempy
pandas
PySocks
```

`uv` 또는 `pip`를 사용하여 설치하세요:
```bash
uv venv
.venv\Scripts\activate
uv pip install -r requirements.txt
```
*(참고: `PySocks`는 Tor SOCKS5 프록시 기능을 사용할 계획인 경우에만 필요합니다.)*

### 2. 구성

서버는 실행 시 처음으로 **자동으로 생성되는** `config.ini` 파일을 통해 구성됩니다. 이 파일은 `pubchem_server.py` 스크립트와 동일한 디렉터리에 생성됩니다.

**기본 `config.ini`:**
```ini
[proxy]
# Change 'use_proxy' to 'true' to route all requests through a proxy.
# Essential for protecting your privacy if you use Tor.
use_proxy = false

# Defines the proxy type. Options:
#   socks5h  -> (Recommended for Tor) The native SOCKS proxy for Tor. More secure.
#   http     -> An HTTP proxy. If using Tor, requires additional configuration.
proxy_type = socks5h

# The proxy address. THIS IS A CRITICAL SETTING!
#   - If you run this script on your DESKTOP, use: 127.0.0.1
#   - If you run this script inside DOCKER, use: host.docker.internal
host = 127.0.0.1

# The proxy port.
#   9050 -> Default port for Tor's SOCKS proxy.
#   8118 -> Default port for Tor's HTTP proxy (if enabled).
port = 9050
```

### 3. AnythingLLM과의 통합

공식 문서를 따라 이를 커스텀 MCP 서버로 추가하십시오. 핵심은 `command`를 Python 실행 파일과 `pubchem_server.py` 스크립트로 지정하는 것입니다.

**AnythingLLM 데스크톱 예시 (`plugins/anythingllm_mcp_servers.json`):**
```json
{
  "mcpServers": {
    "pubchem": {
      "name": "PubChem Server (Enhanced)",
      "transport": "stdio",
      "command": "\"C:\\path\\to\\your\\.venv\\Scripts\\python.exe\" \"C:\\path\\to\\your\\project\\pubchem_server.py\"",
      "cwd": "C:\\path\\to\\your\\project"
    }
  }
}
```
### 3.1 AnythingLLM을 활용한 구현 예시

에이전트와 상호작용하는 몇 가지 예시를 소개합니다. 이 테스트들은 AnythingLLM Desktop을 사용하여 OpenRouter를 통해 다양한 대형 언어 모델에 연결하여 수행되었습니다.

테스트를 통해 얻은 중요한 발견은 선택하는 모델의 중요성입니다. 이 작업에는 **작거나 로컬 모델 사용을 강력히 권장하지 않습니다**. 작은 모델들은 종종 도구가 반환하는 데이터를 올바르게 파싱하지 못해, 환각 값, 잘못된 형식, 그리고 가장 심각한 문제인 **소수점 숫자 반올림**과 같은 오류가 발생할 수 있는데, 이는 이 고정밀 도구의 목적을 무너뜨립니다.

결과의 무결성을 보장하기 위해 MCP가 반환하는 원시 데이터를 항상 확인하는 것이 좋습니다. 이에 대한 방법은 다음 섹션에서 확인할 수 있습니다: [3.2 로그에서 MCP 출력 확인 방법](#32-로그에서-mcp-출력-확인-방법).

<img width="837" height="1060" alt="imagen" src="https://github.com/user-attachments/assets/5a16c7a2-d65d-4d64-98dd-f3cb4cae9b22" />

반면, 여러 모델은 뛰어난 성능을 보여주었습니다. **Google의 `Gemini 2.5 Flash lite`**는 긴 소수점 숫자를 다루는 데 놀라운 정밀도와 최종 마크다운 표를 올바르게 형식화하는 데 탁월한 성능을 보였습니다.

Google gemini 2.5 flash lite는 프롬프트 없이도, 프롬프트를 사용해도 완벽한 소수점 유지(예제에서는 온도 0.6 사용)를 보여줍니다.

<img width="1089" height="1061" alt="imagen" src="https://github.com/user-attachments/assets/4574efa5-d6d9-49e3-a665-a39a427f09a1" />

이 특정 작업에 대해 개인적으로 가장 선호하는 모델은 일관된 정확성과 신뢰성 때문에 **`Gemini 2.5 Flash lite`**입니다.

### 3.2 로그에서 MCP 출력 확인 방법

에이전트가 올바른 데이터를 받고 있고 LLM이 실수를 하지 않는지 확인하는 가장 좋은 방법은 MCP 서버가 생성하는 디버그 로그 파일을 확인하는 것입니다.

이 서버는 자동으로 프로젝트 디렉토리 내 하위 폴더에 로그 파일을 생성하도록 구성되어 있습니다. 위치는 다음과 같습니다:



```
your-project-folder/
└── logs_mcp/
    └── mcp_debug.log
```
`mcp_debug.log` 파일 안에는 도구가 LLM으로 보내기 *전에* 모델이 처리하는 정확한 JSON 데이터가 있습니다. 이 JSON을 수동으로 검사하여 `monoisotopic_mass`와 같은 속성에서 긴 소수점 숫자를 포함한 값들을 확인하고, LLM이 최종 답변에 반올림 오류나 환각을 일으키지 않았는지 검증할 수 있습니다.

---

## 📊 사용법

통합되면, AI 어시스턴트는 화학 정보에 대해 질문받을 때 자동으로 이 도구를 사용합니다. 노출된 주요 도구는 `search_compounds_by_name`입니다.

### 예시 프롬프트

이 프롬프트는 다양한 이름 유형의 화합물 목록을 처리하고 여러 속성을 검색하는 도구의 능력을 보여줍니다.


```
@agent
Please use your PubChem tool to find information on the following compounds:

- Thiamine (Vitamin B1)
- Riboflavin (Vitamin B2)
- Folic Acid
- Hydroxocobalamin

For each compound found, please retrieve the IUPAC Name, Molecular Formula, and Monoisotopic Mass.

Present all the results in a single Markdown table.
```
에이전트는 `search_compounds_by_name` 도구를 호출하여 각 화합물을 지능적으로 찾아 데이터를 검색하고, 이를 LLM에 반환하여 형식을 지정합니다.

---

## 🛠 MCP 도구 공개

### `search_compounds_by_name`

스마트 폴백 전략과 일시 중지 및 재시도를 통해 최대 신뢰성으로 화합물 이름별로 하나씩 여러 화합물을 검색합니다.

**매개변수:**
-   `names` (List[str]): 화합물 이름 리스트. 예: `["Aspirin", "Ibuprofen"]`

**반환:** 각 화합물의 정보 또는 해당 화합물 검색 실패 사유를 담은 오류 메시지를 포함하는 딕셔너리 리스트.

---

## 🙏 감사의 글

이 프로젝트는 **JackKuo666**가 만든 원본 [PubChem-MCP-Server](https://github.com/JackKuo666/PubChem-MCP-Server)를 기반으로 크게 영감을 받아 구축되었습니다.

이 저장소는 직접적인 포크는 아니지만, 원본 프로젝트가 중요한 출발점이었습니다. 이 버전은 극도의 견고성, 지능형 검색 전략, 선택적 Tor 통합을 통한 사용자 프라이버시 강화에 중점을 두어 원본 개념을 향상시켰습니다 🧅.

원작자의 훌륭한 작업과 커뮤니티와 공유해 주신 데 깊이 감사드립니다.

---

## ⚠️ 면책 조항

이 도구는 연구 및 교육 목적으로만 사용됩니다. PubChem의 서비스 약관을 준수하고 책임감 있게 사용해 주시기 바랍니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-27

---
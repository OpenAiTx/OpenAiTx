# 🧠 Cursor DeepSeek V4 프록시

> **Cursor에서 DeepSeek V4 사용 시 발생하는 `reasoning_content` 오류를 원클릭으로 수정하고, `Rate limit exceeded` 문제를 해결하여 AI 에이전트 모드를 안정적으로 실행할 수 있습니다.**

[![GitHub stars](https://img.shields.io/github/stars/你的用户名/cursor-deepseek-v4-proxy?style=social)](https://github.com/你的用户名/cursor-deepseek-v4-proxy)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

---

## 📌 이 프로젝트로 해결할 수 있는 문제는 무엇인가요?

Cursor에서 DeepSeek V4(Pro / Flash)를 호출할 때 다음과 같은 오류가 자주 발생한다면:

* `Provider returned error: The reasoning_content in the thinking mode must be passed back to the API.`
* `User API Key Rate limit exceeded` (쿼터가 충분히 남아있는데도 오류 발생)
* `AI Model Not Found: deepseek-v4-pro` (백엔드 작업에서 모델명이 유효하지 않다고 보고)
* 첫 번째 대화는 정상, 두 번째 대화부터 오류 발생 및 중단

**더 이상 고민하지 마세요, 이 가이드를 따라 5분만에 완벽히 해결할 수 있습니다.**

> ⚠️  **2026-05-14 수정**: 순수 텍스트 모델이 이제 자동으로 이미지를 필터링하여 502 오류를 해결했습니다. 자세한 내용은 [업데이트 로그](#changelog)를 참고하세요.

---

## ✨ 핵심 기능

* ✅ **자동 캐시 & 사고 과정 회신**: `reasoning_content` 누락으로 인한 오류를 방지합니다.
* ✅ **지능형 속도 제한**: 내장된 토큰 버킷으로 급격한 동시 요청으로 무료 한도가 초과되는 것을 방지합니다.
* ✅ **스트리밍 출력 지원**: Cursor의 타자기 효과 렌더링에 영향을 주지 않습니다.
* ✅ **원클릭 실행 스크립트**: Windows / macOS / Linux 공용, 더블 클릭만으로 실행 가능합니다.
* ✅ **투명한 로그**: 터미널에서 요청 상태를 실시간으로 표시하여 문제 해결에 용이합니다.
* ✅ **제로 침투**: Cursor 프로그램 파일을 수정할 필요 없이 Base URL만 변경합니다.

---

## 🖥️ 지원 환경

| 운영체제 | 지원 여부 |
| :--- | :--- |
| **Windows 10 / 11** | ✅ 지원 |
| **macOS** | ✅ 지원 |
| **Linux** | ✅ 지원 |

> **유일한 요구사항**: **Python 3.8** 이상 버전을 설치하세요 (설치 시 반드시 `Add Python to PATH`를 선택하세요).

---

## 🚀 매우 상세한 3단계 시작 가이드 (초보자용)

### 1단계: 프로젝트 다운로드 및 의존성 설치

1.  본 프로젝트 저장소의 ZIP 파일을 다운로드하여 로컬에 압축을 푸세요 (**경로에 한글이 포함되지 않도록 주의하세요**).
2.  압축을 푼 폴더로 이동한 후, 폴더 주소창에 `cmd`를 입력하고 엔터를 눌러 명령 프롬프트를 엽니다.
3.  아래 명령어를 실행하여 의존성을 설치하세요:
    ```bash
    pip install -r requirements.txt
    ```
    *만약 `pip은 내부 명령이 아닙니다`라는 메시지가 뜬다면, Python을 재설치하고 `Add to PATH`를 선택하세요.*

### 두 번째 단계: 로컬 프록시 + 터널 시작

퍼블릭 주소 생성을 위해 터널이 필요합니다 (Cursor는 localhost 접근을 제한합니다).

#### 🪟 Windows 사용자
1.  폴더 안에 `cloudflared-windows-amd64.exe`가 있는지 확인하세요 (없다면 [Cloudflare 공식 사이트](https://github.com/cloudflare/cloudflared/releases)에서 다운로드하세요).
2.  **`start_proxy.bat`**를 더블 클릭하여 실행하세요.
3.  두 개의 창이 열립니다. **터널 창**에서 `https://xxx.trycloudflare.com` 형태의 주소를 찾아 **복사**하세요.

#### 🍎 macOS / Linux 사용자
1.  터미널에서 프로젝트 디렉토리로 이동하여 다음을 실행하세요:
    ```bash
    bash start_proxy.sh
    ```
2.  잠시 기다린 후, 터미널 출력된 `https://xxx.trycloudflare.com` 주소를 복사합니다.

> ⚠️ **주의**: 창을 닫지 마십시오. 터널 주소는 매번 재시작할 때 변경되며, 창을 닫지 않는 한 계속 유효합니다.

### 세 번째 단계: Cursor 설정

1.  Cursor 설정 열기: `Ctrl+Shift+P` → `Cursor Settings` 입력.
2.  **Models** 탭으로 이동합니다.
3.  **"Override OpenAI Base URL"** 에 아까 복사한 주소를 붙여넣고, **끝에 `/v1`을 추가**합니다:
    * 예: `https://xxxxxx.trycloudflare.com/v1`
4.  API Key 항목에 본인의 **DeepSeek API Key**를 입력합니다.
5.  **Cursor를 완전히 종료 후 재시작**합니다.

---

## 🛡️ "Model name not valid" 오류 수정

Apply 또는 백그라운드 작업 실행 시 오류가 발생하면 아래 단계를 따르세요:

1.  `Ctrl+Shift+P`를 누르고, `Preferences: Open User Settings (JSON)` 입력 후 엔터.
2.  JSON 중괄호 `{}` 안에 다음 설정을 추가합니다:
    ```json
    "cursor.models": {
        "deepseek-v4-pro": {
            "provider": "openai",
            "apiBase": "[https://你的隧道地址.trycloudflare.com/v1](https://你的隧道地址.trycloudflare.com/v1)",
            "apiKey": "你的DeepSeek API Key"
        }
    }
    ```
3.  Cursor를 저장하고 재시작합니다.

---

## ❓ 자주 묻는 질문 (FAQ)

<details>
<summary>🔁 터널 주소가 바뀌면 어떻게 하나요?</summary>
스크립트를 재시작할 때마다 새 주소가 생성됩니다. Cursor의 Base URL을 다시 받아서 업데이트하기만 하면 됩니다.
</details>

<details>
<summary>💸 여전히 Rate limit exceeded 라고 나오나요?</summary>
DeepSeek 무료 등급의 호출 빈도가 매우 낮습니다. `proxy.py` 파일에서 `TokenBucket(rate=5/60.0, capacity=5)` 중 `5`를 줄여서(예: `3`) 요청 빈도를 강제로 낮출 수 있습니다.
</details>

<details>
<summary>🚫 반드시 터널을 사용해야 하나요? localhost에 연결할 수는 없나요?</summary>
Cursor는 보안상의 이유로 직접 `localhost` 연결을 금지합니다. Cloudflare Tunnel은 현재 가장 간단하고 무료이며 회원가입이 필요 없는 터널링 솔루션입니다.
</details>

<details>
<summary>🧪 프록시가 모델의 지능에 영향을 주나요?</summary>
99% 이상의 경우에서 체감되지 않습니다. 프록시는 모델이 생각의 흐름을 잊었을 때 자동으로 보완해 대화가 끊기지 않도록 합니다.
</details>

<details>
<summary>🧪 왜 context가 200k 밖에 없고 1M이 아닌가요?</summary>
이는 Cursor의 기본 제한으로, 프록시 문제는 아닙니다.

Cursor는 기본적으로 200k context window를 사용합니다.
모델이 지원하는 1M context를 활성화하려면 Cursor Chat에서 `Max Mode`를 켜야 합니다.
경로:
Chat -> Model Selector -> Max Mode
</details>

---

## ⚙️ 고급 사용자 정의

* **업스트림 교체**：`proxy.py` 내의 `UPSTREAM_URL`을 수정합니다.
* **고정 도메인**：자신의 도메인이 있는 경우, Cloudflare 명명 터널(Persistent Tunnel)을 구성할 수 있습니다.

<a name="changelog"></a>
## 🆕 업데이트 로그

### 2026-05-14：순수 텍스트 모델 이미지 호환성 수정

**수정 내용**
Cursor 등 클라이언트가 `deepseek-v4-pro`(순수 텍스트 모델)로 이미지가 포함된 메시지를 보낼 때, 프록시 레이어는 이제 자동으로 `image_url` 콘텐츠 블록을 필터링하여 텍스트 부분만 남깁니다. 메시지가 전부 이미지(텍스트 없음)인 경우, 모델에 빈 메시지가 전달되는 것을 방지하기 위해 안내 텍스트로 대체합니다.
이 수정은 DeepSeek API가 `"unknown variant image_url, expected text"`를 반환하여 발생하는 502 오류를 해결합니다.

**추가 개선 사항**

- 업스트림 오류 반환 형식을 통일하여, 클라이언트는 구조화된 JSON 오류를 받게 됩니다(원본 오류 메시지나 빈 페이지가 아님).
- 이미지 호환성 로직은 추론 캐시(`reasoning_content`)에 영향을 주지 않으며, 과거 메시지 처리도 정상 유지됩니다.

------

### 감사의 말씀

Issue [#4](https://github.com/wustghj/cursor-deepseek-v4-proxy/issues/4)에서 속도 제한 문제를 피드백해 주신 [@BG-ah](https://github.com/BG-ah)와 참여 토론해 주신 [@CH-nolyn](https://github.com/CH-nolyn)께 감사드립니다. 여러분의 피드백이 이번 호환성 수정에 직접적인 동기를 부여하여 프록시가 순수 텍스트 모델에서 더 안정적으로 작동할 수 있게 했습니다.

------

> 💡 **팁**：모델이 이미지 내용을 실제로 이해하게 하려면 요청의 `model` 필드를 다중 모달을 지원하는 `deepseek-chat`으로 변경하고, DeepSeek 계정에 해당 권한이 활성화되어 있는지 확인하세요.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-24

---
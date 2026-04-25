# InstagramToMealie

간단한 변환기, 인스타그램 URL을 mealie로 가져오기

<p align="center">
    <img src="https://raw.githubusercontent.com/PKief/vscode-material-icon-theme/ec559a9f6bfd399b82bb44393651661b08aaf7ba/icons/folder-markdown-open.svg" align="center" width="30%">
</p>
<p align="center"><h1 align="center">INSTAGRAM TO MEALIE</h1></p>

<p align="center">
	<img src="https://img.shields.io/github/license/JoTec2002/InstagramToMealie?style=default&logo=opensourceinitiative&logoColor=white&color=0080ff" alt="license">
	<img src="https://img.shields.io/github/last-commit/JoTec2002/InstagramToMealie?style=default&logo=git&logoColor=white&color=0080ff" alt="last-commit">
	<img src="https://img.shields.io/github/languages/top/JoTec2002/InstagramToMealie?style=default&color=0080ff" alt="repo-top-language">
	<img src="https://img.shields.io/github/languages/count/JoTec2002/InstagramToMealie?style=default&color=0080ff" alt="repo-language-count">
</p>
<br>

## 목차

- [개요](#overview)
- [시작하기](#getting-started)
    - [필수 조건](#prerequisites)
    - [설치](#installation)
    - [사용법](#usage)
    - [설정](#configuration)
- [기여](#contributing)
- [라이선스](#license)
- [감사의 글](#acknowledgments)

---

## 개요

InstagramToMealie를 사용하면 인스타그램 게시물 URL을 간단히 입력할 수 있습니다. 이 프로젝트는 Mealie API와 원활하게 통합되어
연관된 이미지 또는 비디오 자산과 함께 새 레시피를 생성합니다.

---

## 시작하기

### 사전 준비 사항

1. Mealie 인스턴스에서 `/admin/debug/openai`로 이동하여 OpenAI / Ollama가 Mealie에 구성되어 있는지 확인하세요. 이 프로젝트는 OpenAI / Ollama와 직접 통합되지 않지만, 제대로 작동하려면 Mealie에 설정되어 있어야 합니다. 개인적으로는 Ollama 모델로 `qwen2.5:7b`를 사용했을 때 가장 좋은 결과를 얻었습니다.
2. Mealie API 키를 생성하세요 (`/user/profile/api-tokens`). [Mealie 문서](https://docs.mealie.io/documentation/getting-started/api-usage/)
3. Instagram 세션 파일을 생성하세요 (!가장 까다로운 단계입니다). 이 저장소에는 [도움 스크립트](https://raw.githubusercontent.com/JoTec2002/InstagramToMealie/refs/heads/main/helpers/instaloader_login_helper.py)가 제공됩니다! 이는 [Instaloader 문서](https://instaloader.github.io/troubleshooting.html)에서 복사한 것입니다.
    1. 스크립트 다운로드: [https://raw.githubusercontent.com/JoTec2002/InstagramToMealie/refs/heads/main/helpers/instaloader_login_helper.py](https://raw.githubusercontent.com/JoTec2002/InstagramToMealie/refs/heads/main/helpers/instaloader_login_helper.py)
    2. Firefox에서 Instagram에 로그인하세요
    3. 스니펫 실행: `python ./instaloader_login_helper.py`
    4. 스크립트가 생성한 파일을 알려진 위치에 복사하세요. 이 파일은 나중에 Docker 컨테이너에 마운트됩니다. 다른 시스템에서 생성 후 대상 시스템으로 복사해도 됩니다.

### 설치

다음 방법 중 하나를 사용하여 InstagramToMealie를 설치하세요:

**소스에서 빌드:**
<details closed>

1. InstagramToMealie 저장소를 클론하세요:


```sh
❯ git clone https://github.com/JoTec2002/InstagramToMealie
```
2. 프로젝트 디렉토리로 이동합니다:


```sh
❯ cd InstagramToMealie
```
3. 프로젝트 의존성을 설치합니다:


```sh
❯ pip install -r requirements.txt
```
4. 서버 시작:


```sh
❯ python -u main.py
```

</details>

**[jotec2002/instagramtomealie](https://hub.docker.com/repository/docker/jotec2002/instagramtomealie/general)에서 제공하는 Docker 이미지를 사용하세요**

Mealie 설치와 함께 Docker Compose로 배포하세요

세션 파일을 사용하여 인증하는 예제 `compose.yaml` 파일:

```yaml
services:
  mealie:
    image: ghcr.io/mealie-recipes/mealie:v2.1.0
    container_name: mealie
    #Look up in the Mealie Docs for how to use Mealie
  InstagramToMealie:
    image: jotec2002/instagramtomealie
    ports:
      - 9001:9001
    environment:
      INSTA_USER: "instagram username"
      MEALIE_API_KEY: "MEALIE API KEY"
      MEALIE_URL: "YOU LOCAL MEALIE INSTALLATION" # e.g http://mealie:9000
      MEALIE_OPENAI_REQUEST_TIMEOUT: 60           # Optional, default: 60
    volumes:
      - ./session-file:/app/session-file        # The Instagram session file you created in the Prerequisites
    depends_on:
      mealie:
        condition: service_healthy
```

사용자 이름 및 비밀번호 환경 변수를 사용하여 인증하는 예제 `compose.yaml` 파일:

> [!IMPORTANT]
> **이 방법이 작동하려면 계정에서 이중 인증(TFA/TOTP)을 비활성화해야 합니다.**
> 작동시키기 위해 여러 번 시도해야 할 수 있습니다. 인스타그램 봇 감지를 피하기 위해 다른 시스템/IP에서 병행하여 로그인하세요.
> 이것은 InstagramToMealie를 설정하는 권장 방법이 아닙니다.

```yaml
services:
  mealie:
    image: ghcr.io/mealie-recipes/mealie:v2.1.0
    container_name: mealie
    #Look up in the Mealie Docs for how to use Mealie
  InstagramToMealie:
    image: jotec2002/instagramtomealie
    ports:
      - 9001:9001
    environment:
      INSTA_USER: "instagram username"
      INSTA_PWD: "Cleartext Instagram password"
      MEALIE_API_KEY: "MEALIE API KEY"
      MEALIE_URL: "YOU LOCAL MEALIE INSTALLATION" # e.g http://mealie:9000
      MEALIE_OPENAI_REQUEST_TIMEOUT: 60           # Optional, default: 60
      MEALIE_USE_INSTAGRAM_TAGS: true
```

**도커 이미지 직접 빌드하기**

제공된 도커 이미지를 사용할 때와 동일하게 구성하되 `compose.yaml`에서 다음으로 교체하세요:

```diff
services:
  mealie:
    image: ghcr.io/mealie-recipes/mealie:v2.1.0
    container_name: mealie
    #Look up in the Mealie Docs for how to use Mealie
  InstagramToMealie:
+   build:
+     context: .
+     dockerfile: Dockerfile
+   image: instagramtomealie:latest
    ports:
      - 9001:9001
```
### 사용법

1. 웹브라우저에서 열기 (예: `http://instagramtomealie.my-server.com`) 후 텍스트 필드에 인스타그램 URL을 입력하세요  
2. 자동화(예: IOS 단축어)에서 `http://instagramtomealie.my-server.com?url=<InstagramURL>` URL을 호출하세요  
3. 임포트 결과를 응답하는 API가 필요하면 `POST http://instagramtomealie.my-server.com/api`에 URL을 요청 본문에 JSON 형식으로(`{"url": "<InstagramURL>"}` 권장) 또는 쿼리 파라미터로 보내세요 (이전 항목 참조). API는 다음 형식의 JSON을 응답합니다:

```json
{
  "recipe_slug": <imported recipe slug>,
  "error": <error message if any error>,
  "url": <Instagram URL which was imported>
}
```
### 구성


```env
MEALIE_URL:                          # Full URL of your Mealie instance (e.g http://mealie:9000, http://192.168.1.2:9000, http://my-mealie.com), required.
MEALIE_API_KEY:                      # API key used to authenticate with the Mealie REST API, required.
MEALIE_OPENAI_REQUEST_TIMEOUT: 60    # The timeout in seconds for OpenAI / Ollama requests, optional, default 60.
MEALIE_USE_INSTAGRAM_TAGS: true      # Embeds tags provided on the Instagram post as tags in Mealie, optional, default true.
INSTA_USER:                          # Instagram username (e.g mob_kitchen), required.
INSTA_PWD:                           # Instagram password in plaintext, optional (if using a session file).
INSTA_TOTP_SECRET:                   # Secret key used for 2FA authentication, optional, not recommended.
HTTP_PORT:                           # Port to use for the Flask HTTP server, optional, default 9001
```

---

## 기여하기

- **💬 [토론 참여하기](https://github.com/JoTec2002/InstagramToMealie/discussions)**: 의견을 공유하거나
  피드백을 제공하고 질문을 하세요.
- **🐛 [이슈 신고하기](https://github.com/JoTec2002/InstagramToMealie/issues)**: 발견한 버그를 신고하거나
  `InstagramToMealie` 프로젝트에 기능 요청을 남기세요.
- **💡 [풀 리퀘스트 제출하기](https://github.com/JoTec2002/InstagramToMealie/blob/main/CONTRIBUTING.md)**: 열린
  PR을 검토하고 직접 PR을 제출하세요.

<details closed>
<summary>기여자 그래프</summary>
<br>
<p align="left">
   <a href="https://github.com{/JoTec2002/InstagramToMealie/}graphs/contributors">
      <img src="https://contrib.rocks/image?repo=JoTec2002/InstagramToMealie">
   </a>
</p>
</details>

---

## 라이선스

이 프로젝트는 MIT 라이선스로 보호됩니다. 자세한 내용은
[LICENSE](https://choosealicense.com/licenses/) 파일을 참조하세요.

---

## 감사의 말씀

- [Mealie](https://github.com/mealie-recipes/mealie/)
- [Instadownloader](https://github.com/instaloader/instaloader)

---


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-25

---
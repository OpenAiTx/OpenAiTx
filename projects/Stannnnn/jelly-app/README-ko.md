## 젤리 뮤직 앱 (JMA)

젤리핀을 위한 가볍고 우아한 음악 인터페이스입니다. 직관적이고 미니멀하며 세심한 주의를 기울여 음악 재생에 집중한 깔끔한 웹 앱입니다. 젤리핀 API를 사용하여 개인 음악 라이브러리에 원활하게 접근할 수 있습니다. [데모](https://stannnnn.github.io/jelly-app/login?demo=1)

**비디오 플레이어를 찾고 계신가요?** 젤리핀 라이브러리를 위한 비디오 중심 버전인 [Jelly Video App](https://github.com/Stannnnn/jelly-video-app/)을 확인해보세요!

<br/>

<div>
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/light-variant.webp" alt="라이트 버전" width="49%">
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/dark-variant.webp" alt="다크 버전" width="49%">
</div>
<br/>

<details>
  <summary>추가 스크린샷</summary>
  <br/>
  <b>사이드내비 검색</b>
  <p>트랙, 아티스트, 앨범, 재생목록, 장르 검색</p>
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/search-light-variant.png" alt="사이드내비 검색 라이트 버전" width="49%">
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/search-dark-variant.png" alt="사이드내비 검색 다크 버전" width="49%">
  <br/>
  <br/>
  <b>검색 결과</b>
  <p>전용 창에서 추가 검색 결과 보기</p>
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/search-results-light-variant.webp" alt="검색 결과 라이트 버전" width="49%">
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/search-results-dark-variant.webp" alt="검색 결과 다크 버전" width="49%">
  <br/>
  <br/>
  <b>아티스트</b>
  <p>가장 많이 재생된 곡, 앨범 및 기타 협업 기능</p>
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/artist-light-variant.webp" alt="아티스트 라이트 버전" width="49%">
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/artist-dark-variant.webp" alt="아티스트 다크 버전" width="49%">
  <br/>
  <br/>
  <b>재생목록</b>
  <p>번호가 매겨진 트랙리스트가 포함된 재생목록 보기</p>
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/playlist-light-variant.webp" alt="재생목록 라이트 버전" width="49%">
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/playlist-dark-variant.webp" alt="재생목록 다크 버전" width="49%">
</details>
### 기능

- **우아하고 심플한 디자인:** 음악 재생을 쉽고 즐겁게 만드는 깔끔하고 복잡하지 않은 인터페이스. React 같은 최신 도구로 빠르고 안정적인 경험을 제공합니다.
- **기기 친화적:** 모바일과 데스크톱 모두에서 부드럽고 앱 같은 경험을 제공하며, 즉시 접근할 수 있는 PWA로 설치할 수 있습니다.
- **무결점 라이브러리 접근:** Jellyfin 서버에 연결하여 개인 음악 컬렉션을 쉽게 탐색할 수 있습니다.
- **즐겨찾기 발견하기:**
    - **홈:** 최근 재생한 트랙, 가장 많이 재생한 즐겨찾기, 새로 추가된 미디어로 빠르게 돌아가기.
    - **아티스트:** 라이브러리 내 모든 아티스트의 인기 트랙, 앨범, 협업 작품을 둘러보기.
    - **재생 목록:** 명확하고 번호가 매겨진 트랙리스트와 함께 재생 목록 보기로 빠른 탐색.
    - **빠른 검색:** 사이드 내비게이션 검색 또는 전용 결과 페이지로 트랙, 아티스트, 앨범, 재생 목록, 장르를 손쉽게 찾기.
    - **즉시 믹스:** 독립 페이지에서 음악 라이브러리에서 직접 선별된 재생 목록 즐기기.
- **대기열:** 향상되고 개선된 대기열 기능으로 트랙을 손쉽게 관리하고 재정렬.
- **크로스페이드:** 트랙 간 부드러운 전환으로 몰입감 있는 감상 경험 제공.
- **프리로드:** 다음 트랙을 지능적으로 미리 로드하여 버퍼링 지연 없이 원활하고 끊김 없는 재생 보장.
- **동기화 가사:** 듣는 동안 한 줄씩 완벽하게 타이밍이 맞는 가사를 멋진 UI로 새롭게 즐기기.
- **스마트 페칭:** 음악을 효율적으로 캐시하여 즉시 부드러운 재생 제공.
- **오프라인 동기화:** 개별 곡, 전체 앨범, 재생 목록, 아티스트별로 오프라인 재생을 위해 다운로드 가능.
    - **자동 동기화:** 새로 추가된 트랙을 이전에 저장한 재생 목록, 앨범 또는 아티스트에 자동으로 다운로드.
    - **지속 대기열:** 다운로드는 세션 간에 원활하게 재개되는 로컬 대기열로 관리.
    - **트랜스코딩 또는 직접 스트림:** 선택한 비트레이트에 따라 원본 품질과 트랜스코딩된 다운로드 모두 지원.
- **도커 지원:** 사전 구성된 Jellyfin 서버 URL이 포함된 사전 제작된 Docker 이미지로 앱을 끌어와 배포하여 원활한 셀프 호스팅 가능.

### 설치

Jelly Music App은 전용 데스크톱 앱으로 설치할 수 있으며, [GitHub 릴리스 페이지](https://github.com/Stannnnn/jelly-app/releases)에서 제공됩니다. 최신 프로덕션 빌드를 거기서 받아 웹 서버에 배포하려면 압축된 폴더 내용을 웹 접근 가능한 디렉터리에 배치하면 됩니다.
<br/>
또한 **도커 이미지**로도 제공되어 손쉬운 배포가 가능합니다. 도커 세부사항은 아래를 참고하세요.
<br/>
<br/>

[Yarn](https://classic.yarnpkg.com/lang/en/docs/install) (`npm i -g yarn`)은 프로젝트를 빌드하거나 개발 서버를 직접 실행하려면 필요합니다.

#### 소스에서 빌드하기

1. 저장소를 클론하세요:

    ```bash
    git clone https://github.com/Stannnnn/jelly-app.git
    ```
2. 종속성 설치:
    ```bash
    yarn
    ```
3. 프로덕션 파일 빌드:
    ```bash
    yarn build
    ```
4. `dist` 폴더의 내용을 웹에서 접근 가능한 디렉토리에 배포합니다.

또는 개발 서버를 직접 실행할 수 있습니다: `yarn dev` 또는 `yarn dev:nocache`

루트(`/`) 이외의 기본 경로를 애플리케이션에 사용하려면 `URL_BASE_PATH`를 원하는 기본 경로로 설정하여 수동으로 빌드해야 합니다.

구성은 기본값으로 두거나 필요에 따라 [`config.json`](https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/config.json)을 변경하세요. 구성에 대한 설명은 [앱 구성 섹션](#app-configuration)에서 확인할 수 있습니다.
`config.json` 파일은 빌드된 애플리케이션 내에서 직접 변경할 수 있습니다. 구성 변수만 변경하는 경우 재빌드할 필요가 없습니다.

### 도커

ghcr.io의 미리 빌드된 이미지를 사용하여 Jelly Music App을 쉽게 호스팅할 수 있습니다:

#### 도커 이미지 가져오기

```bash
docker pull ghcr.io/stannnnn/jelly-music-app:latest
```

#### 도커 이미지 실행하기

```bash
docker run --rm -p 80:80 ghcr.io/stannnnn/jelly-music-app:latest
```

Docker 이미지는 -d 플래그를 추가하여 백그라운드에서 실행할 수도 있습니다 `docker run -d ...`

#### 구성 변수와 함께 도커 이미지 실행하기

```bash
docker run --rm \
    -e DEFAULT_JELLYFIN_URL=https://demo.jellyfin.org/stable \
    -e LOCK_JELLYFIN_URL=false \
    -p 80:80 ghcr.io/stannnnn/jelly-music-app:latest
```
<br/>

다음은 도커에서 사용 가능한 태그입니다:

| 태그    | 설명                     |
| ------ | ------------------------ |
| latest | 최신 릴리스를 추적합니다   |
| main   | 메인 브랜치를 추적합니다  |
| vX.X.X | 버전별 태그입니다          |

예: `ghcr.io/stannnnn/jelly-music-app:latest`

#### 도커 컨테이너 빌드

Jelly Music App을 도커를 사용해 빌드할 수도 있습니다.

1.  도커 이미지를 빌드합니다:


    ```bash
    docker build . --tag jelly-music-app
    ```

2.  도커 컨테이너 실행:

    ```bash
    docker run --rm -p 80:80 jelly-music-app:latest
    ```
환경 변수(environment variables)를 사용하여 구성(configuration)을 제공할 수도 있습니다.


    ```bash
    docker run --rm \
        -e DEFAULT_JELLYFIN_URL=https://demo.jellyfin.org/stable \
        -e LOCK_JELLYFIN_URL=false \
        -p 80:80 jelly-music-app:latest
    ```

#### Docker Compose

컨테이너 관리를 더 쉽게 하기 위해 Docker Compose를 사용할 수 있습니다. 리포지토리에는 적절한 기본값이 설정된 `docker-compose.yaml` 파일이 제공됩니다.

1.  예제 환경 파일을 복사하고 설정에 맞게 사용자 지정합니다:

    ```bash
    cp .env.example .env
    ```

2.  `.env` 파일을 Jellyfin 서버 URL 및 설정에 맞게 편집하세요:

    ```env
    JELLYAPP_PORT=80
    JELLYAPP_DEFAULT_URL=https://demo.jellyfin.org/stable
    JELLYAPP_LOCK_URL=true
    ```

3.  Docker Compose를 사용하여 컨테이너를 시작합니다:

    ```bash
    docker-compose up -d
    ```
`docker-compose.yaml` 파일은 다음 기본값을 가진 환경 변수를 사용합니다:

- `JELLYAPP_PORT`: 노출할 외부 포트 (기본값: `80`)
- `JELLYAPP_DEFAULT_URL`: 기본 Jellyfin 서버 URL (기본값: `https://demo.jellyfin.org/stable`)
- `JELLYAPP_LOCK_URL`: Jellyfin URL 입력 잠금 여부 (기본값: `false`)

### 앱 구성

앱 구성은 빌드 과정 중 또는 릴리스 파일에서 `config.json` 파일을 편집하여 수정할 수 있습니다. Docker 사용 시 구성은 환경 변수로 제공할 수 있습니다. 사용 가능한 구성 옵션은 다음과 같습니다:

- `DEFAULT_JELLYFIN_URL`: Local Storage에 URL이 저장되어 있지 않은 경우 앱 첫 접근 시 로드되는 기본 Jellyfin 서버 URL을 설정합니다.
- `LOCK_JELLYFIN_URL`: `true`로 설정하면 URL 입력 필드를 제거하고 모든 연결에 대해 기본 URL(`DEFAULT_JELLYFIN_URL`)을 강제 적용합니다. 단일 서버에 연결된 자체 호스팅 인스턴스에 적합합니다.

### 기여하기

저희는 풀 리퀘스트를 환영하며, `develop` 브랜치로 병합해 주세요. 제안이나 개선 사항이 있으면 이슈를 열거나 풀 리퀘스트를 제출해 주세요. 여러분의 기여에 감사드립니다!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-21

---
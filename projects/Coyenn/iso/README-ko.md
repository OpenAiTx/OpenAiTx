<div align="center">
  <a href="https://iso.tim.cv/" target="_blank">
    <img src="https://raw.githubusercontent.com/Coyenn/iso/main/./.github/assets/preview-dashboard-bg-image.png" alt="Iso 대시보드 스크린샷" width="800" />
  </a>
</div>

<br />
<div align="center">
  <a href="https://iso.tim.cv" target="_blank">데모</a>
  |
  <a href="https://hub.docker.com/r/coyann/iso" target="_blank">도커</a>
  |
  <a href="https://github.com/Coyenn/iso/" target="_blank">깃허브</a>
</div>
<br />

**Iso**는 모든 자체 호스팅 서비스용 플러그 앤 플레이 대시보드입니다.
개인 홈랩을 위해 제작되었으며, 이제 여러분을 위해 오픈 소스로 공개됩니다.

- 단일 `config.json` 파일을 통해 **완전 구성 가능**
- **다국어 지원**: 영어, 스페인어, 프랑스어, 독일어
- **아이콘 지원**: 내장 아이콘 세트에서 선택하거나 직접 아이콘을 제공 가능
- **도커 우선**: 간단한 명령어 하나로 어디서나 실행 가능

## ‍️빠른 시작

### 도커

```bash
docker run -d \
  --name iso \
  -p 3000:3000 \
  -e AUTH_SECRET="changeme" \
  -e AUTH_PASSWORD="changeme" \
  -v ./config:/config \
  coyann/iso
```
### 도커 컴포즈


```yaml
services:
  iso:
    image: coyann/iso:latest
    container_name: iso
    ports:
      - "3000:3000"
    environment:
      - AUTH_SECRET=changeme
      - AUTH_PASSWORD=changeme
    volumes:
      - ./config:/config
    restart: unless-stopped
```
http://localhost:3000을 열면 바로 실행됩니다!

## 구성

Iso는 `/config` 디렉토리에 위치한 단일 `config.json` 파일을 통해 구성됩니다.

### 구성 예시


```json
{
  "title": "My Dashboard",
  "services": [
    {
      "order": 1,
      "icon": "tv",
      "label": "Plex",
      "href": "https://plex.example.com"
    },
    {
      "order": 2,
      "icon": "lock",
      "label": "Bitwarden",
      "href": "https://vault.example.com"
    }
  ],
  "locale": "en",
  "theme": "amethyst",
  "greetings": [],
  "pageLoadAnimation": true,
  "search": {
    "enabled": true,
    "engine": "google",
    "engineUrl": "",
    "placeholder": "Search ..."
  }
}
```
### 구성 옵션

- **title**: 헤더에 표시되는 대시보드 제목
- **services**: 다음을 포함하는 서비스 객체 배열:
  - `order`: 표시 순서 (숫자)
  - `icon`: 내장 아이콘 세트의 아이콘 이름
  - `label`: 서비스 표시 이름
  - `href`: 서비스 URL
- **locale**: 언어 코드 (`en`, `es`, `fr`, `de`)
- **theme**: 색상 테마 (예: `amethyst`)
- **greetings**: 사용자 정의 인사 메시지
- **pageLoadAnimation**: 페이지 애니메이션 활성화/비활성화
- **search**: 검색창 설정을 포함하는 객체
  - `enabled`: 검색창 표시 여부 토글
  - `engine`: 내장 검색 엔진 (`google`, `bing`, `duckduckgo`, `startpage`, `qwant`, `searx`, 또는 `custom`)
  - `engineUrl`: 사용자 정의 검색 엔진 URL. 검색 쿼리 자리 표시자로 `[q]` 사용.
  - `placeholder`: 검색창에 표시되는 입력 자리 표시자 텍스트

## 환경 변수

| 변수 | 설명 | 기본값 | 필수 |
|----------|-------------|---------|----------|
| `AUTH_SECRET` | 인증을 위한 비밀 키 | - | 아니오 |
| `AUTH_PASSWORD` | 대시보드 접근 비밀번호 | - | 아니오 |
| `APP_DATA_PATH` | 구성 디렉토리 경로 | `/config` | 아니오 |

## 추가 스크린샷

<div style="display: flex;">
  <img src="https://raw.githubusercontent.com/Coyenn/iso/main/./.github/assets/preview-settings.png" alt="Iso 설정 스크린샷" width="400" style="width: 49%;" />
  <img src="https://raw.githubusercontent.com/Coyenn/iso/main/./.github/assets/preview-login.png" alt="Iso 로그인 스크린샷" width="400" style="width: 49%;" />
</div>

## 개발

### 전제 조건

- Nix


또는

- [Bun](https://bun.sh/) 자바스크립트 런타임

### 로컬 설정

1. 저장소를 클론하세요:
```bash
git clone https://github.com/Coyenn/iso.git
cd iso
```

2. 의존성 설치:
```bash
bun install
```

3. 개발 서버 시작:
```bash
bun dev
```

4. 브라우저에서 http://localhost:3000 을 엽니다

## 라이선스

MIT 라이선스 하에 배포됩니다. 자세한 내용은 `LICENSE`를 참조하십시오.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---
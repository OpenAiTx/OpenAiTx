# BookHaven

![BookHaven Home](https://raw.githubusercontent.com/HrBingR/BookHaven/master/./bookhaven_home.png)

## 목차
1. [애플리케이션 기능](#what-the-application-does)
2. [특징](#features)
3. [배포](#deployment)
   - [도커](#docker)
   - [개발](#development)
4. [애플리케이션 빌드](#building-the-application)
5. [변경 기록](#change-log)


## 애플리케이션 기능
BookHaven은 로컬 EPUB 전자책 라이브러리를 스캔 및 관리하며, 세련되고 현대적이며 반응형 인터페이스를 통해 어떤 기기에서든 전자책을 읽고 다운로드할 수 있게 합니다.

## 특징
- **브라우저에서 전자책 읽기**
  사용자는 추가 소프트웨어 없이 EPUB 형식 전자책을 직접 접근하고 읽을 수 있습니다.
- **전자책 다운로드**
  컬렉션에 있는 전자책을 쉽게 기기로 다운로드할 수 있습니다.
- **비파괴적 메타데이터 편집**
  전자책 메타데이터(예: 제목, 저자, 시리즈)에 대한 변경 사항은 데이터베이스에 저장되어 원본 EPUB 파일은 변경하지 않습니다.
- **자동 또는 수동 라이브러리 스캔**
  배포 후 앱은 설정 가능한 간격으로 정기적으로 라이브러리 변경사항을 스캔하며, 수동 스캔도 허용합니다.
- **알파벳 순서로 정렬된 홈 페이지**
  도서는 먼저 저자 이름 순으로, 그 다음 시리즈 순으로 정렬되어 깔끔하고 직관적인 탐색을 제공합니다.
- **강력한 검색 기능**
  홈 페이지의 검색 기능을 통해 저자, 도서 제목 또는 시리즈로 라이브러리를 필터링하여 특정 콘텐츠를 빠르게 찾을 수 있습니다.
- **필터**
  즐겨찾기, 완료 표시된 책, 완료되지 않은 책으로 필터링할 수 있는 기본 필터를 제공합니다.
- **직관적인 탐색이 가능한 저자 페이지**
  전용 저자 페이지는 저자를 클릭 가능한 알파벳 그리드로 조직합니다. 사용자는 글자를 클릭해 저자 목록을 확장하고, 저자 페이지로 이동해 시리즈 및 단독 도서가 알파벳 순으로 정렬된 책을 볼 수 있습니다.
- **CloudFlare Access 지원**
  CloudFlare Access 사용 시 로그인 화면을 우회하는 플래그가 있습니다. 자세한 내용은 `.env.example`을 참조하세요.
- **OIDC 지원**
  신규 사용자 등록 및 기존 사용자에 대해 OIDC 구성이 가능합니다.
- **OPDS 지원**
  좋아하는 OPDS 호환 전자책 리더기나 앱을 사용해 라이브러리에서 책을 탐색, 다운로드 및 읽을 수 있습니다.
- **업로드**
  사용자가 이제 사용자 인터페이스를 통해 전자책을 직접 업로드할 수 있으며, 업로드 후 메타데이터를 수정할 수 있는 폼이 제공됩니다.
- **기본 RBAC 지원**
  관리자는 이제 사용자에게 서로 다른 접근 권한을 가진 다양한 역할을 부여할 수 있습니다.
- **도서 요청**
  사용자가 사이트에서 보고 싶은 특정 도서를 요청할 수 있습니다. 관리자는 업로드/추가된 후 이러한 요청을 확인하고 처리할 수 있습니다.

## 배포

### 요구 사항

애플리케이션을 실행하기 위한 최소 요구 사항은 다음과 같습니다:

- 데이터베이스 (MySQL, SQLite, PostgreSQL)
- Redis 인스턴스

간편한 배포를 위해 .compose.yml.example 파일에 이 두 가지가 이미 정의되어 있습니다.

### Docker
Docker Compose로 애플리케이션을 배포하려면 다음 단계를 따르세요:
1. **구성 파일 다운로드**
`compose.yml.example`과 `.env.example` 파일을 얻기 위해 저장소를 다운로드하거나 클론하세요.

2. **예제 파일 이름 변경**
``` bash
   mv compose.yml.example compose.yml
   mv .env.example .env
```
3. **`.env` 파일 맞춤 설정하기**

필수 설정을 구성하려면 `.env` 파일을 편집하세요.

4. **애플리케이션 시작하기**

다음 명령어를 실행하세요:
``` bash
   docker compose up -d
```
이 명령은 `BookHaven`, Redis 및 MySQL 컨테이너를 시작합니다.
5. **애플리케이션 접속하기**

브라우저를 열고 구성한 `BASE_URL`:`APP_PORT`로 이동하세요(기본값은 `http://localhost:5000`).

6. **애플리케이션 중지하기**

``` bash
   docker compose down
```
### 개발
다음 단계를 따라 개발용으로 배포하십시오:
1. **저장소를 클론합니다**:

``` bash
   git clone https://github.com/HrBingR/BookHaven.git
   cd BookHaven
```

2. **예제 파일 이름 변경**:
```bash
   mv compose.exmaple.yml compose.yml
   mv .env.example .env
```
3. **`.env` 파일 맞춤 설정**:

필수 설정을 구성하려면 `.env` 파일을 편집하세요.

4. **`compose.yml` 파일 수정**:

다음과 같이 변경하세요:


```yaml
    epub-reader:
       image: hrbingr/bookhaven:latest
```

To:

```yaml
  epub-reader:
     build:
        context: .
        dockerfile: Dockerfile
```

5. **컨테이너 빌드하기**:
```bash
   docker compose up --build -d
```
6. **앱에 접속하기**:

`.env` 파일에 정의된 `BASE_URL`과 `APP_PORT`에서 앱에 접속하세요.

## 애플리케이션 빌드하기
프로덕션용 애플리케이션을 빌드하려면:
1. **프론트엔드 빌드하기**:

``` bash
   cd frontend
   npm run build:dev
```
2. **도커 이미지 빌드하기**:

루트 프로젝트 디렉토리(BookHaven)에서 다음을 실행하세요:
``` bash
   docker build -t tag:version .
```
`tag:version`을 원하는 이미지 이름과 버전(e.g., `bookhaven:1.0.0`)으로 교체하세요.

## 변경 로그:

자세한 변경 로그는 [CHANGELOG](https://raw.githubusercontent.com/HrBingR/BookHaven/master/CHANGELOG.md)를 참고하세요.

- v1.0.x
  - 초기 출시
- v1.1.0 - v1.1.1
  - OIDC 지원 추가
  - OIDC가 비활성화된 상태에서도 OIDC 프론트엔드 컴포넌트가 렌더링되는 버그 수정.
- v1.2.0 - v1.2.2
  - 메타데이터를 데이터베이스뿐만 아니라 ePub 파일에도 선택적으로 기록하는 기능 추가.
  - Celery가 명시적으로 정의된 PERIODIC_SCAN_INTERVAL을 문자열로 감지하여 예외를 발생시키는 문제 수정.
  - Postgres 사용자가 데이터베이스 초기화를 성공적으로 하지 못하게 하는 마이그레이션 및 DB 모델 로직 수정.
- v1.3.0 - v1.3.5
  - 기본적인 OPDS 지원 추가.
  - OPDS 기능 개선.
  - 저자 페이지의 UI 문제 수정
  - 홈 페이지 스크롤 관련 UX 문제 일부 수정
  - 프론트엔드에서 커버 이미지 로딩 개선
  - 기본 API 속도 제한 상향 및 사용자 정의 가능하도록 변경
  - 한 번에 하나의 스캔만 실행되도록 스캔 프로세스 락킹 구현
  - 스캔 로직의 DB 구성 요소 개선
  - "Authors" 페이지에서 모바일에서 확장된 저자 목록 렌더링 문제 수정
  - 스캔 로직 업데이트 - 시작 시 라이브러리가 자동으로 스캔됨
- v1.4.0 - v1.4.1
  - 업로드 기능 추가 - 활성화 및 사용 방법은 .env.example 참조
  - 스캐너 대체 식별자를 상대 경로에서 파일명으로 변경
  - 기존 대체 식별자를 업데이트하는 마이그레이션 생성
  - 업로드 성능 향상을 위해 gunicorn sync에서 gunicorn gthread로 전환
  - 예약된 스캔을 위한 celery 작업 임포트 수정
  - 업로드 기능 비활성화 시 업로드 버튼 숨김 문제 수정
- v1.5.0 - v1.5.2
  - 역할 기반 접근 제어(RBAC) 추가. 관리자는 이제 다음과 같이 사용자에게 다른 역할을 부여할 수 있음:
    - 사용자: 업로드, 메타데이터 편집, 사용자 관리 제외한 모든 기본 기능 접근 가능.
    - 편집자: 업로드 및 메타데이터 편집 접근 포함.
    - 관리자: 다른 사용자 관리 접근 포함.
  - Cloudflare Access를 통한 로그인 시 로직 개선.
  - 제거되지 않은 레거시 컬럼에 영향을 주는 사소한 버그 수정.
  - 마이그레이션 스크립트를 더 견고하게 개선했습니다.
- v.1.6.0
  - 사용자가 사이트에 새 책 추가를 요청할 수 있는 요청 기능을 추가했습니다.

## TODO:

- 최신 추가 사항으로 테스트 업데이트
- 다른 형식 지원 탐색
- 편집을 위한 추가 메타데이터 필드 추가 탐색

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-22

---
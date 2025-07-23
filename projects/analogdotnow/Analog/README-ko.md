
<p align="center">
  <h1 align="center">아날로그</h1>
  <p align="center">모든 것을 바꾸는 오픈 소스 캘린더</p>
</p>

## 시작하기

로컬 머신에서 Analog를 실행하려면 다음 단계를 따르세요:

### 사전 요구 사항

다음이 설치되어 있는지 확인하세요:

- **Bun**: 빠른 자바스크립트 런타임, 패키지 관리자, 번들러 및 테스트 러너입니다.
  - [설치 가이드](https://bun.sh/docs/installation)
- **Docker Desktop**: PostgreSQL 데이터베이스 실행용.
  - [설치 가이드](https://www.docker.com/products/docker-desktop/)

### 설정

1.  **저장소 클론하기**:


    ```bash
    git clone https://github.com/jeanmeijer/analog.git
    cd analog
    ```
2.  **종속성 설치**:


    ```bash
    bun install
    ```
3.  **환경 변수 구성**:
    예제 환경 파일을 복사합니다:


    ```bash
    cp .env.example .env
    ```
    그런 다음 새로 생성된 `.env` 파일을 엽니다. `DATABASE_URL` 및 `BETTER_AUTH_URL`에 대한 기본값을 찾을 수 있습니다. 다음을 설정해야 합니다:
    - `BETTER_AUTH_SECRET`: 터미널에서 `openssl rand -hex 32`를 실행하여 안전한 비밀 키를 생성하세요.
      <br/><br/>

4.  **Google OAuth 설정**:

- `GOOGLE_CLIENT_ID` 및 `GOOGLE_CLIENT_SECRET`:
  1. [Google Cloud Console](https://console.cloud.google.com/)에서 Google 프로젝트를 생성합니다.
  2. [Better Auth 문서의 1단계](https://www.better-auth.com/docs/authentication/google)를 따라 Google OAuth 자격 증명을 설정하세요.
  3. [Google Cloud Console APIs](https://console.cloud.google.com/apis/library/calendar-json.googleapis.com)에서 Google Calendar API를 활성화합니다.
  4. 테스트 사용자로 자신을 추가하세요:
     - Google OAuth [`Audience`](https://console.cloud.google.com/auth/audience) 탭을 찾습니다.
     - 'Test users' 아래에서 'Add Users'를 클릭합니다.
     - 텍스트 박스에 이메일을 입력하고 'Save'를 클릭합니다.

5. **Microsoft OAuth 설정** (선택 사항):

- `MICROSOFT_CLIENT_ID` 및 `MICROSOFT_CLIENT_SECRET`:
  1. [Microsoft Azure Portal](https://portal.azure.com/)로 이동한 후 Microsoft Entra ID → App registrations로 이동합니다.
  2. 새 애플리케이션을 등록하고 리디렉션 URI를 (`http://localhost:3000/api/auth/callback/microsoft`)로 설정합니다.
  3. 애플리케이션(클라이언트) ID를 복사하고 Certificates & secrets에서 새 클라이언트 비밀을 생성합니다.
  4. API 권한으로 이동하여 + Add a permission을 클릭한 후 Microsoft Graph → Delegated permissions를 선택하고 다음을 추가합니다:
     - `Calendars.Read`, `Calendars.ReadWrite`, `User.Read`, `offline_access`

### 데이터베이스 설정

Analog는 Drizzle ORM과 함께 PostgreSQL을 사용합니다. Docker를 사용하여 데이터베이스를 실행할 수 있습니다:

1.  **PostgreSQL 데이터베이스 컨테이너 시작**:


    ```bash
    bun run docker:up
    ```


    이 명령어는 `docker-compose.yml`을 사용하여 PostgreSQL 컨테이너를 실행합니다.

2.  **데이터베이스 초기화**:
    데이터베이스 컨테이너가 실행 중이고 정상 상태가 되면, 데이터베이스를 초기화합니다:

    ```bash
    bun run db:push
    ```
### 애플리케이션 실행하기

환경과 데이터베이스 설정을 마친 후, 개발 서버를 시작할 수 있습니다:


```bash
bun run dev
```


이제 브라우저에서 [http://localhost:3000](http://localhost:3000) 에서 애플리케이션에 접근할 수 있습니다.

## 기술 스택

- **웹**: Next.js, TypeScript, Tailwind v4, Bun, tRPC, TanStack Query, shadcn/ui
- **데이터베이스**: PostgreSQL과 함께 사용하는 Drizzle
- **인증**: Google OAuth용 Better Auth

## 로드맵

작업 중입니다.

## 기여하기

이 프로젝트에 기여하는 방법에 대한 자세한 내용은 [CONTRIBUTING.md](https://raw.githubusercontent.com/analogdotnow/Analog/main/./CONTRIBUTING.md) 를 참조하세요.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---
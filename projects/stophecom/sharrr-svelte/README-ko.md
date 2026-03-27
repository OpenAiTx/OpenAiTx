# sharrr

**일회성 종단간 암호화 파일 전송.**

사실상 무제한 크기의 파일을 비동기적으로 가장 안전한 방식으로 전송하세요.

[기술 구현](https://sharrr.com/about)에 대해 자세히 알아보세요. 다른 서비스와 [sharrr 비교](https://github.com/stophecom/sharrr-svelte/blob/main/src/routes/about/comparison.md)도 확인해 보세요.

웹사이트: [www.sharrr.com](https://sharrr.com)

이 프로젝트를 계속 운영할 수 있도록 도와주세요: [기부하기](https://donate.stripe.com/28oeV1gKP3bv4b6144)

## 개발 중

시작하기 전에 프로젝트 루트에 `.env` 파일을 추가하세요. 아래를 참고하세요.

```bash
# Initial installation
pnpm i

# Run dev server
pnpm run dev

# or start the server and open the app in a new browser tab
pnpm run dev -- --open
```

### DB

#### Prisma ORM

```bash
# Init primsa
npx prisma init

# Push schema to Postgres
npx prisma db push

# Open prisma studio locally
npx prisma studio

# After changes in DB are made. Should not be necessary.
# https://www.prisma.io/docs/concepts/components/prisma-client#4-evolving-your-application
npx prisma generate
```
#### Postgres 데이터베이스

현재 Vercel Postgres 데이터베이스를 사용 중이지만, Prisma 호환 데이터베이스라면 어떤 것이든 사용할 수 있습니다.

### 테스트


```bash
# Run unit tests with vitest
# Important: Node 19+ is required (Support for crypto modules)
pnpm run test:unit


# E2E tests with playwright
pnpm run test

```

### 빌드

프로덕션 버전의 앱을 생성하려면:

```bash
pnpm run build
```

`pnpm run preview` 명령어로 프로덕션 빌드를 미리 볼 수 있습니다.

### 유지보수

매일 실행되어 오래된 파일을 정리하는 Github 워크플로우 `cron-cleanup-files.yml`이 있습니다.
자세한 내용은 `src/routes/api/v1/cron/+server.ts`를 참조하세요.

로컬에서 크론 작업을 실행하려면 다음을 사용하세요:

```bash
curl --request POST \
     --url 'http://localhost:3000/api/v1/cron' \
     --header 'Authorization: Bearer API_SECRET_KEY'

```

## 자체 호스팅

> **참고**
> 현재 프로젝트는 Vercel에서 실행되며, 저장소로 S3를 사용하고 Vercel Postgres DB를 사용합니다. 자체 호스팅을 위해서는 이러한 3자 솔루션을 대체해야 합니다.

### 현재 설정

#### 환경 변수 (ENV Variables)

```bash
# Postgres
POSTGRES_PRISMA_URL='postgres://'
POSTGRES_URL_NON_POOLING='postgres://' # Direct Connection

# S3 compatible object storage e.g. AWS
S3_ENDPOINT='<string>'
S3_ACCESS_KEY='<string>'
S3_SECRET_KEY='<string>'
PUBLIC_S3_BUCKET='<string>'

# Vercel specific, but can be easily replaced.
VERCEL_URL='http://localhost:3000'
PUBLIC_ENV='development' # preview/production

# Only used for cron jobs that run using Github Actions.
API_SECRET_KEY='<string>'
```

### Docker 사용 (작업 중)

`.env` 파일 내의 환경 변수를 편집해야 합니다.

> **참고**
> Docker에서 앱을 실행하려면 여전히 자체 DB에 연결해야 합니다. 자체 S3 저장소 솔루션을 실행하려는 경우에도 마찬가지입니다. 이 부분은 아직 다루어지지 않았습니다.

이 작업을 완료하면 다음을 수행할 수 있습니다:

```bash
# to start the docker container
sudo docker compose up -d

# to stop the docker container
sudo docker compose down

# to check logs
sudo docker logs sharrr
```
## 소개

저자 정보: [stophe.com](https://stophe.com)

추가적인 프라이버시 및 보안 옵션이 필요하신가요? [scrt.link](https://scrt.link)를 확인해보세요.

### 스택

- SvelteKit
- Tailwind CSS
- PostgreSQL (데이터베이스)
- Prisma (ORM)
- Doppler (환경 변수 관리용)

이 프로젝트는 BrowserStack으로 테스트되었습니다.

### 인프라

- 웹사이트와 Postgres는 [Vercel](https://vercel.com/)에서 운영됩니다.
- S3 객체 저장소는 [flow.swiss](https://flow.swiss)를 사용합니다.

### 라이선스

[MIT](https://opensource.org/license/mit/) (코드)

[CC BY-NC-ND](https://creativecommons.org/licenses/by-nc-nd/4.0/) (창작물)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-27

---
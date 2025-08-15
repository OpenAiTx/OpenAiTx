# AppAgent

<div align="center">
  <img width="200" src="https://github.com/user-attachments/assets/7f86c185-0fc1-46c3-888a-c915602f27ee" alt="AppAgent" />
  <h2>ASO부터 릴리스까지, 모두 간소화되었습니다.</h2>
</div>

[AppAgent](https://app-agent.ai)는 앱의 ASO 및 릴리스 과정을 관리하는 AI 우선 도구입니다. AppAgent는 App Radar, AppTweak, AppFollow, Sensor Tower와 같은 ASO 도구에 대한 오픈 소스 대안입니다. AppAgent는 AI 우선이며 자율적으로 작동합니다.

https://github.com/user-attachments/assets/e34baeef-ceab-4fdb-9a7c-e6a5ab80dbba

---

## 왜 AppAgent인가요?

빠른 AI 발전 덕분에 앱 제작이 그 어느 때보다 쉬워졌습니다. 하지만 인기 있는 ASO 도구들(App Radar, AppTweak, Sensor Tower 등)은 인디 개발자와 소규모 팀에게는 지나치게 비싸고 불필요하게 복잡합니다. 진정으로 필요한 것은 다국어 키워드 선택부터 ASO 콘텐츠 생성까지 모든 것을 자율적으로 처리하여 키워드뿐 아니라 전체 릴리스 과정을 간소화하는 플랫폼입니다.

App Store Connect 또한 릴리스 워크플로에 마찰을 도입했습니다. 그래서 저는 AI 우선 접근 방식을 취해 AppAgent를 처음부터 구축했으며, ASO와 앱 릴리스가 하나의 원활하고 효율적인 플랫폼에서 함께 작동하도록 재구상했습니다.

---

## 기능

### 자율 ASO (베타)

https://github.com/user-attachments/assets/09172b8c-c690-42b2-a394-8b65e80c25ad

- **자율 키워드 연구**
  - 더 이상 수동 키워드 탐색이 필요 없습니다.
  - 지역 및 시장에 관계없이 자율적으로 실행됩니다.
  - 경쟁자를 찾아 자동으로 선별된 경쟁자 목록을 관리할 수 있습니다.
  - 경쟁자를 기반으로 AI가 키워드를 연구하고 목록을 최종 확정합니다.
- **AI 기반 스토어 최적화**
  - 앱 메타데이터를 기반으로 즉각적인 제안 제공.
  - 모든 언어에 대해 ASO 친화적 콘텐츠 생성.
  - 전문가 수준의 마케팅 지식 없이도 클릭만으로 사용 가능.

### 릴리스 관리

https://github.com/user-attachments/assets/9148a814-ae24-4005-adb6-d113933b67d3
- **릴리스 노트를 현지화하세요**  
  - 모든 언어로 릴리스 노트를 생성합니다.  
  - 지원하는 모든 언어에 대해 더 이상 ChatGPT 복사-붙여넣기를 하지 않아도 됩니다.  
- **스토어 동기화**  
  - App Store Connect와 데이터를 동기화합니다. Google Play도 곧 지원 예정입니다.  
  - App Store Connect에서 수동으로 데이터를 입력할 필요가 없습니다.  
  - 한 번의 클릭으로 모든 변경 사항을 App Store Connect에 푸시합니다.  
  - 한 번의 클릭으로 앱 리뷰에 제출합니다.  

---

## 기술 스택  

- [Next.js](https://nextjs.org/) – 프레임워크  
- [TypeScript](https://www.typescriptlang.org/) – 언어  
- [Tailwind](https://tailwindcss.com/) – CSS  
- [shadcn/ui](https://ui.shadcn.com) - UI 컴포넌트  
- [Prisma](https://prisma.io) - ORM [![Made with Prisma](https://made-with.prisma.io/dark.svg)](https://prisma.io)  
- [PostgreSQL](https://www.postgresql.org/) - 데이터베이스  
- [NextAuth.js](https://next-auth.js.org/) – 인증  
- [PostHog](https://posthog.com/) – 분석  
- [Resend](https://resend.com) – 이메일  
- [Stripe](https://stripe.com) – 결제  
- [Vercel](https://vercel.com/) – 호스팅  

---

## 시작하기  

### 1. 저장소 복제하기


```bash
git clone https://github.com/ngo275/app-agent.git
```

### 2. .env.sample을 .env로 복사하고 값을 변경하세요

```bash
cp .env.sample .env
```
다음은 설정해야 할 환경 변수 목록입니다:

- `NEXTAUTH_SECRET`
  - NextAuth.js용 비밀 키입니다. `openssl rand -base64 32` 명령어로 무작위 문자열을 생성할 수 있습니다.
- `NEXTAUTH_URL`
  - 앱의 URL입니다. 예를 들어, `http://localhost:3000`입니다.
- `NEXT_PUBLIC_BASE_URL`
  - 앱의 URL입니다. 예를 들어, `http://localhost:3000`입니다.
- `NEXT_PUBLIC_MARKETING_URL`
  - 마케팅 페이지의 URL입니다. 예를 들어, `http://localhost:3000`입니다.
- `GOOGLE_CLIENT_ID`
  - Google OAuth 애플리케이션의 클라이언트 ID입니다. Google 로그인을 위해 사용합니다. Google 로그인을 사용하지 않으면 필요 없습니다.
- `GOOGLE_CLIENT_SECRET`
  - Google OAuth 애플리케이션의 클라이언트 비밀 키입니다. Google 로그인을 위해 사용합니다. Google 로그인을 사용하지 않으면 필요 없습니다.
- `RESEND_API_KEY`
  - Resend 계정의 API 키입니다. 이메일 전송에 사용됩니다.
- `NEXT_PUBLIC_POSTHOG_KEY`
  - PostHog 계정의 키입니다. 분석용입니다. PostHog를 사용하지 않으면 필요 없습니다.
- `OPENAI_API_KEY`
  - OpenAI 계정의 API 키입니다. LLM 사용에 필요합니다.
- `UPSTASH_REDIS_REST_URL`
  - Upstash 계정의 URL입니다. 캐싱에 사용됩니다.
- `UPSTASH_REDIS_REST_TOKEN`
  - Upstash 계정의 토큰입니다. 캐싱에 사용됩니다.
- `NEXT_PUBLIC_FREE_PLAN_ENABLED`
  - 무료 플랜 활성화 여부입니다. 무료 플랜을 활성화하려면 `true`로 설정하세요.
- `NEXT_PUBLIC_STRIPE_PUBLISHABLE_KEY`
  - Stripe 계정의 공개 키입니다. 결제에 사용됩니다. `NEXT_PUBLIC_FREE_PLAN_ENABLED`를 `true`로 설정했다면 필요하지 않습니다.
- `STRIPE_SECRET_KEY`
  - Stripe 계정의 비밀 키입니다. 결제에 사용됩니다. `NEXT_PUBLIC_FREE_PLAN_ENABLED`를 `true`로 설정했다면 필요하지 않습니다.
- `STRIPE_WEBHOOK_SECRET`
  - Stripe 계정의 웹훅 비밀 키입니다. 웹훅에 사용됩니다. `NEXT_PUBLIC_FREE_PLAN_ENABLED`를 `true`로 설정했다면 필요하지 않습니다.
- `STRIPE_PRO_PRICE_ID`
  - Stripe 프로 플랜의 가격 ID입니다. 결제에 사용됩니다. `NEXT_PUBLIC_FREE_PLAN_ENABLED`를 `true`로 설정했다면 필요하지 않습니다.
- `DATABASE_URL`
  - PostgreSQL 데이터베이스의 URL입니다. 로컬 머신 외에 [Supabase](https://supabase.com/) 또는 [Neon](https://neon.tech/) 같은 무료 서비스를 사용할 수 있습니다.

### 3. 의존성 설치하기


```bash
yarn

# Or with NPM
npm install
```

### 4. DB 설정

```bash
yarn prisma generate
yarn prisma migrate deploy

# Or with NPM
npm run prisma generate
npm run prisma migrate deploy
```

### 5. 개발 서버 실행하기

```bash
yarn dev

# Or with NPM
npm run dev
```

[http://localhost:3000](http://localhost:3000) 에 방문하여 앱을 확인하세요.

---

## 기여하기

기여를 환영합니다! PR 제출을 자유롭게 해주세요.

기여하고 싶으시면, 저장소를 포크한 후 PR을 제출해 주세요.

---

## 라이선스

AppAgent는 GNU Affero 일반 공중 사용 허가서 버전 3 (AGPLv3) 또는 이후 버전 하에 오픈 소스로 제공됩니다. 라이선스는 [여기](https://github.com/ngo275/app-agent/blob/main/LICENSE)에서 확인할 수 있습니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-15

---
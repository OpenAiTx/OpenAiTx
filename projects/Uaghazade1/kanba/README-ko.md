﻿<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# 메이커와 인디 해커를 위한 오픈 소스, 경량 트렐로 대안입니다.

단순성, 속도, 확장성에 중점을 두었습니다.
최신 스택: Tailwind CSS, shadcn/ui, Supabase, Stripe 통합으로 제작되었습니다.
무제한 프로젝트, 팀 협업, 다크/라이트 모드, 매끄러운 사용자 경험을 지원합니다.
불필요한 복잡함 없이 완전한 제어를 원하는 1인 개발자 및 소규모 팀에 적합합니다.

## 🌟 이 프로젝트가 유용하다면 Star를 남겨주세요! 더 많은 사람이 발견할 수 있습니다.

# 배포 가이드

## 개요
이 애플리케이션은 이제 Stripe 통합을 위해 Supabase Edge Functions 대신 로컬 Next.js API 경로를 사용합니다. 이로 인해 배포가 더 간단해지고, 표준 .env 파일로 설정할 수 있습니다.

## 환경 변수 설정

### 1. .env.local 파일 생성
`.env.example`을 `.env.local`로 복사한 후 실제 값을 입력하세요:


```bash
cp .env.example .env.local
```
### 2. 필수 환경 변수

#### Supabase 설정
- `NEXT_PUBLIC_SUPABASE_URL` - Supabase 프로젝트 URL
- `NEXT_PUBLIC_SUPABASE_ANON_KEY` - Supabase 익명 키
- `SUPABASE_SERVICE_ROLE_KEY` - Supabase 서비스 역할 키 (서버 전용)

#### Stripe 설정 (선택 사항)
- `STRIPE_SECRET_KEY` - Stripe 비밀 키 (서버 전용)
- `NEXT_PUBLIC_STRIPE_PUBLISHABLE_KEY` - Stripe 공개 키
- `STRIPE_WEBHOOK_SECRET` - Stripe 웹훅 비밀 키

#### 사이트 설정
- `NEXT_PUBLIC_SITE_URL` - 사이트 URL (운영 환경용)
- `NEXTAUTH_URL` - 사이트 URL (위와 동일)
- `NEXTAUTH_SECRET` - NextAuth용 임의 비밀 키

## 로컬 개발

1. 의존성 설치:

```bash
npm install
```
2. `.env.local` 파일에서 환경 변수를 설정하세요

3. 개발 서버를 실행하세요:


```bash
npm run dev
```
4. Stripe CLI를 사용하여 로컬에서 Stripe 웹훅 테스트하기:

```bash
stripe listen --forward-to localhost:3000/api/stripe/webhook
```
## 프로덕션 배포


### Vercel 배포

1. **Vercel에 배포:**

```bash
npx vercel
```
2. **환경 변수:**
   Vercel 대시보드 또는 CLI를 통해 모든 환경 변수를 추가하세요

3. **Stripe 웹훅 설정:**
   - 웹훅을 다음으로 지정하세요: `https://your-domain.vercel.app/api/stripe/webhook`

## API 엔드포인트

애플리케이션은 이제 다음 로컬 API 경로를 사용합니다:

- `POST /api/stripe/checkout` - Stripe 체크아웃 세션 생성
- `POST /api/stripe/webhook` - Stripe 웹훅 이벤트 처리

## 로컬 API 경로의 장점

1. **배포 간소화** - 별도의 엣지 함수 배포 불필요
2. **환경 변수** - 표준 .env 파일 지원
3. **디버깅 용이** - 로컬에서 더 쉽게 디버깅 가능
4. **프레임워크 통합** - Next.js와 더 나은 통합
5. **공급업체 종속성 없음** - Next.js를 지원하는 모든 플랫폼에 배포 가능

## 문제 해결

1. **웹훅 문제:**
   - `STRIPE_WEBHOOK_SECRET`이 Stripe 웹훅 엔드포인트와 일치하는지 확인
   - Stripe 대시보드에서 웹훅 로그 확인
   - 웹훅 URL이 올바른지 검증

2. **환경 변수:**
   - 필요한 모든 변수가 설정되었는지 확인
   - 변수 이름에 오타가 없는지 점검
   - Supabase 서비스 역할 키에 적절한 권한이 있는지 확인

3. **CORS 문제:**
   - API 경로에 적절한 CORS 헤더 포함
   - 필요한 경우 도메인이 화이트리스트에 등록되었는지 확인

## 보안 주의사항

- `STRIPE_SECRET_KEY` 또는 `SUPABASE_SERVICE_ROLE_KEY`를 클라이언트에 절대 노출하지 마세요
- 클라이언트 측 변수에는 `NEXT_PUBLIC_` 접두사만 사용하세요
- 웹훅 비밀 키를 정기적으로 교체하세요
- Stripe 대시보드에서 웹훅 전달 상태를 모니터링하세요



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---
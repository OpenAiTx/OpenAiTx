<translate-content># 제로 캘린더

[![Vercel로 배포하기](https://vercel.com/button)](https://vercel.com/new/clone?repository-url=https%3A%2F%2Fgithub.com%2FZero-Calendar%2Fzero-calendar)

**미래 일정 관리를 위한 오픈소스 AI 기반 캘린더**

## 제로 캘린더란?
제로 캘린더는 사용자가 구글 캘린더 및 기타 캘린더 제공업체와 같은 외부 서비스와 통합하면서 일정을 지능적으로 관리할 수 있도록 해주는 오픈소스 AI 캘린더 솔루션입니다. 우리의 목표는 AI 에이전트를 통해 일정을 현대화하고 개선하여 시간 관리 방식을 혁신하는 것입니다.

## 왜 제로 캘린더인가?
대부분의 캘린더 서비스는 폐쇄형이거나 데이터 수집에 집중되어 있거나 지능형 기능이 부족합니다. 제로 캘린더는 다릅니다:

✅ **오픈소스** – 숨겨진 의도 없이 완전 투명합니다.  
🦾 **AI 기반** - AI 어시스턴트 및 대규모 언어 모델(LLM)으로 일정 관리를 향상하세요.  
🔒 **데이터 프라이버시 우선** – 당신의 일정, 당신의 데이터입니다. 제로 캘린더는 데이터를 추적, 수집, 판매하지 않습니다.  
⚙️ **셀프 호스팅 자유** – 손쉽게 나만의 캘린더 앱을 운영하세요.  
📅 **통합 캘린더** – 구글 캘린더, 아웃룩 등 여러 캘린더 제공업체를 연결할 수 있습니다.  
🎨 **맞춤형 UI 및 기능** – 원하는 방식으로 캘린더 경험을 조정하세요.  
🚀 **개발자 친화적** – 확장성과 통합을 염두에 두고 설계되었습니다.  

## 기술 스택
제로 캘린더는 현대적이고 신뢰할 수 있는 기술로 구축되었습니다:

- **프론트엔드**: Next.js, React, TypeScript, TailwindCSS, Shadcn UI  
- **백엔드**: Next.js API 라우트, 서버 액션  
- **데이터베이스**: Vercel KV (Redis)  
- **인증**: NextAuth.js, 구글 OAuth  
- **AI**: AI SDK, Groq  

## 시작하기

### 필수 조건
필요한 버전:  
- Node.js (v18 이상)  
- npm (v9 이상) 또는 pnpm (v8 이상)  

애플리케이션 실행 전에 서비스 설정과 환경 변수 구성이 필요합니다. 환경 변수에 대한 자세한 내용은 환경 변수 섹션을 참조하세요.

### 설치 옵션

#### 빠른 시작 가이드

1. **클론 및 설치**</translate-content>
```bash
# Clone the repository
git clone https://github.com/Zero-Calendar/zero-calendar.git
cd zero-calendar

# Install dependencies
npm install
# or
pnpm install
```
2. **환경 설정**
- 프로젝트 루트에 `.env.example`를 `.env.local`로 복사하세요

```bash
cp .env.example .env.local
```
- 환경 변수를 설정하세요 (아래 참조)

3. **앱 시작하기**
```bash
npm run dev
# or
pnpm dev
```
4. **브라우저에서 열기**  
- http://localhost:3000 방문  

### 환경 변수  
프로젝트 루트에 `.env.local` 파일을 생성하고 다음 변수를 설정하세요:  


```
# NextAuth
NEXTAUTH_SECRET=     # Required: Secret key for authentication (generate with `openssl rand -hex 32`)
NEXTAUTH_URL=        # Required: URL of your application (http://localhost:3000 for local dev)

# Google OAuth (Required for Google Calendar integration)
GOOGLE_CLIENT_ID=    # Required for Google Calendar integration
GOOGLE_CLIENT_SECRET=# Required for Google Calendar integration

# Vercel KV (Redis)
KV_URL=              # Required: Vercel KV URL
KV_REST_API_URL=     # Required: Vercel KV REST API URL
KV_REST_API_TOKEN=   # Required: Vercel KV REST API token
KV_REST_API_READ_ONLY_TOKEN= # Required: Vercel KV REST API read-only token

# AI Integration
GROQ_API_KEY=        # Required for AI features
```
### Google OAuth 설정 (Google 캘린더 통합에 필요)

1. [Google Cloud Console](https://console.cloud.google.com/)로 이동
2. 새 프로젝트 생성
3. Google Cloud 프로젝트에 다음 API 추가:
   - Google 캘린더 API
   - Google People API
4. Google OAuth2 API 활성화
5. OAuth 2.0 자격 증명 생성 (웹 애플리케이션 유형)
6. 승인된 리디렉션 URI 추가:
   - 개발: `http://localhost:3000/api/auth/callback/google`
   - 프로덕션: `https://your-production-url/api/auth/callback/google`
7. `.env.local`에 추가:

```
GOOGLE_CLIENT_ID=your_client_id
GOOGLE_CLIENT_SECRET=your_client_secret
```
8. 테스트 사용자로 본인을 추가하세요:
   - OAuth 동의 화면으로 이동
   - '테스트 사용자' 아래에서 '사용자 추가' 클릭
   - 이메일을 추가하고 '저장' 클릭

> **경고**
>
> Google Cloud Console의 승인된 리디렉션 URI는 `.env.local`에 설정한 값과 프로토콜(http/https), 도메인, 경로까지 정확히 일치해야 합니다.

### Vercel KV 설정

1. Vercel 계정이 없으면 생성하세요
2. Vercel CLI 설치: `npm i -g vercel`
3. Vercel 로그인: `vercel login`
4. 프로젝트 연결: `vercel link`
5. Vercel 대시보드에서 KV 데이터베이스 생성
6. 프로젝트에 KV 환경 변수 추가: `vercel env pull .env.local`

## 기능

- 🤖 **AI 어시스턴트**: 자연어로 캘린더와 상호작용
- 🔄 **구글 캘린더 통합**: 기존 구글 캘린더와 동기화
- 🎨 **커스터마이즈 가능한 UI**: 다크 모드 및 개인 설정
- 🔄 **반복 일정**: 예외를 포함한 반복 일정 완벽 지원
- 🌐 **시간대 관리**: 전 세계 일정을 위한 완전한 시간대 지원
- 📤 **가져오기/내보내기**: ICS 및 CSV 형식으로 캘린더 데이터 가져오기 및 내보내기
- ⌨️ **키보드 단축키**: 효율적인 캘린더 관리를 위한 고급 사용자용 단축키
- 🔔 **이벤트 관리**: 쉽고 빠른 이벤트 생성, 편집, 삭제
- 🔒 **안전한 인증**: 이메일/비밀번호 또는 구글 OAuth 로그인

### 키보드 단축키

제로 캘린더는 고급 사용자를 위한 키보드 단축키를 포함합니다:

| 단축키 | 동작 |
|--------|-------|
| `←` | 이전 달 |
| `→` | 다음 달 |
| `T` | 오늘로 이동 |
| `N` | 새 이벤트 생성 |
| `?` | 키보드 단축키 표시 |
| `/` | 검색에 포커스 |
| `M` | 월별 보기 전환 |
| `W` | 주별 보기 전환 |
| `D` | 일별 보기 전환 |
| `A` | AI 어시스턴트 토글 |
| `S` | 설정으로 이동 |
| `Esc` | 대화상자 닫기 |

## 기여하기
[기여 가이드](https://raw.githubusercontent.com/Zero-Calendar/zero-calendar/main/.github/CONTRIBUTING.md)를 참고하세요.

## 라이선스

제로 캘린더는 [GPLv3 라이선스](https://raw.githubusercontent.com/Zero-Calendar/zero-calendar/main/LICENSE.md) 하에 공개 소프트웨어입니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---
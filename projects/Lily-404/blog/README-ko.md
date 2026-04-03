
<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

# Jimmy의 블로그

Next.js 15+ 기반으로 구축된 미니멀한 개인 블로그 시스템으로, 온라인 창작 및 정적 배포를 지원합니다.

## 기술 스택

- **프레임워크**: Next.js 15+ (App Router)
- **언어**: TypeScript
- **스타일**: Tailwind CSS
- **아이콘**: Lucide Icons
- **콘텐츠**: Markdown + Gray Matter + Remark
- **인증**: GitHub OAuth
- **배포**: Vercel

## 기능 특징

### 독자 측

- 📝 Markdown + GFM 문서 렌더링(수식 공식 포함)
- 🏷️ 태그 필터링, 페이지네이션, 아카이브(연도/태그별)
- 📚 문서 목차(TOC) 및 코드 블록 원클릭 복사
- 📱 반응형 레이아웃 및 다크/라이트 테마 전환
- 🔥 떠다니는 창작 캘린더 히트맵(문서 + 에세이)
- 📡 RSS 구독 출력(`/rss.xml`)

### 창작 측(관리 백오피스)

- 🔐 GitHub OAuth 로그인(소유자/협력자 권한 검증)
- ✍️ 문서/에세이 온라인 생성, 편집, 삭제
- 🆔 커스텀 파일 ID + 자동 충돌 방지
- 👀 편집/미리보기/분할 화면 3가지 작성 모드
- 📊 창작 통계 패널(전체, 주/월별 생산량, 인기 태그)

### 엔지니어링 측

- ⚡ 다중 페이지 정적화 출력(`force-static`)으로 성능 및 안정성 향상
- 🧭 내장 sitemap 및 robots
- 🧩 콘텐츠 읽기 캐싱 및 모듈형 API 구조

## 프로젝트 구조

```
.
├── app/               # 页面、API 路由、Server Actions
│   ├── api/           # 接口（OAuth、统计、校验、Markdown 等）
│   ├── actions/       # 内容管理相关服务端动作
│   ├── posts/         # 文章详情页
│   └── page.tsx       # 首页
├── content/
│   ├── notes/         # 随笔
│   └── posts/         # 文章
├── components/        # React 组件
├── public/            # 静态资源
└── styles/            # 全局样式
```
## 설치 및 실행

1. 프로젝트 클론하기


```bash
git clone https://github.com/Lily-404/blog.git
cd jimmy-blog
```

2. 의존성 설치

```bash
npm install
```
3. 개발 서버 실행


```bash
npm run dev
```

4. 프로덕션 빌드 생성

```bash
npm run build
```

## 새 글 추가

### 방법 1: 온라인 관리 백엔드(추천)

1. `/admin` 페이지에 접속
2. GitHub OAuth로 로그인
3. 글 정보를 입력하고 제출
4. 글이 GitHub API를 통해 자동 생성되며, Vercel이 자동으로 다시 배포함

### 방법 2: 파일 수동 추가

1. `content/posts` 디렉터리에서 새로운 Markdown 파일 생성
2. 파일 이름 형식: `xxx.md`
3. 파일 상단에 메타데이터 추가:

```markdown
---
title: 文章标题
date: YYYY-MM-DD
tags: ["标签1","标签2","标签3"]
---
```

## 에세이 추가

1. `content/notes` 디렉토리에 새로운 Markdown 파일 생성
2. 파일 이름 형식: `YYYY-MM-DD-title.md`
3. 파일 상단에 메타데이터 추가:

```markdown
---
date: YYYY-MM-DD
---
```

## 관리 백엔드 구성

관리 백엔드는 GitHub OAuth를 사용하여 인증하며, 저장소 소유자 또는 협업자만 접근할 수 있습니다.

### 1. GitHub OAuth 앱 생성

1. [GitHub 설정 > 개발자 설정 > OAuth Apps](https://github.com/settings/developers)로 이동
2. "New OAuth App" 클릭
3. 정보 입력:
   - **Application name**: `Jimmy Blog Admin`(또는 임의의 이름)
   - **Homepage URL**: `https://당신의도메인.com`(프로덕션) 또는 `http://localhost:3000`(로컬 개발)
   - **Authorization callback URL**: 
     - 프로덕션: `https://당신의도메인.com/api/auth/github/callback`
     - 로컬 개발: `http://localhost:3000/api/auth/github/callback`
4. "Register application" 클릭
5. **Client ID** 기록
6. "Generate a new client secret" 클릭 후 **Client secret** 기록

### 2. 환경 변수 설정

Vercel 프로젝트 설정에서 아래 환경 변수를 추가하세요:

- `GITHUB_CLIENT_ID`: GitHub OAuth App Client ID
- `GITHUB_CLIENT_SECRET`: GitHub OAuth App Client Secret
- `GITHUB_OWNER`: GitHub 사용자명(기본값: `Lily-404`, 사용자 권한 검증용)
- `GITHUB_REPO`: 저장소 이름(기본값: `blog`)
- `GITHUB_REDIRECT_URI`: OAuth 콜백 URL(선택 사항, 기본값 자동 생성)
- `NEXT_PUBLIC_BASE_URL`: 사이트 URL(콜백 URL 생성에 사용, 프로덕션 필수 설정)
  - 프로덕션: `https://www.jimmy-blog.top`
  - 로컬 개발: `http://localhost:3000`

### 3. 로컬 개발 환경 설정

프로젝트 루트 디렉터리에 `.env.local` 파일 생성:

```env
GITHUB_CLIENT_ID=你的Client_ID
GITHUB_CLIENT_SECRET=你的Client_Secret
GITHUB_OWNER=Lily-404
GITHUB_REPO=blog
NEXT_PUBLIC_BASE_URL=http://localhost:3000
```

### 4. 운영 환경 설정 (Vercel)

Vercel 프로젝트 설정에서 다음을 반드시 설정하세요:

```env
NEXT_PUBLIC_BASE_URL=https://www.jimmy-blog.top
```

⚠️ **주의**:
- `.env.local` 파일은 `.gitignore`에 추가되어 있으므로 Git에 커밋되지 않습니다
- 로컬 개발 시 OAuth App의 콜백 URL을 `http://localhost:3000/api/auth/github/callback`으로 설정하세요
- **프로덕션 환경에서는 반드시 `NEXT_PUBLIC_BASE_URL`을 `https://www.jimmy-blog.top`으로 설정해야 합니다**
- 프로덕션 환경의 OAuth App 콜백 URL은 다음과 같이 설정해야 합니다: `https://www.jimmy-blog.top/api/auth/github/callback`

## 배포

프로젝트는 Vercel 배포가 구성되어 있어 자동 배포를 지원합니다. 코드를 GitHub 저장소에 푸시하면 Vercel이 자동으로 빌드 및 배포합니다.

### 관리 백오피스 사용의 장점

- ✅ 로컬 개발 환경이 필요 없음
- ✅ 언제 어디서나 글 추가 가능
- ✅ Vercel 재배포 자동 트리거
- ✅ 완전 무료 (GitHub OAuth 및 Vercel 모두 무료 요금제 범위 내)
- ✅ 안전함 (GitHub OAuth 인증, 저장소 소유자/협업자만 접근 가능)
- ✅ 비밀번호 관리 불필요, GitHub 계정으로 로그인 가능
- ✅ 기존 콘텐츠 온라인 편집 지원 (신규뿐만 아니라)
- ✅ 파일 ID 충돌 자동 처리, 덮어쓰기 및 수동 이름 변경 방지
- ✅ 백오피스 내 창작 통계 제공, 지속적인 콘텐츠 운영에 용이

## 프로젝트 분석 및 향후 계획

- 프로젝트 분석 문서: [`docs/project-analysis.md`](https://raw.githubusercontent.com/Lily-404/blog/main/docs/project-analysis.md)
- Future 계획 문서: [`docs/future-roadmap.md`](https://raw.githubusercontent.com/Lily-404/blog/main/docs/future-roadmap.md)

## 기여

Issue 및 Pull Request 제출을 환영합니다!

## 라이선스

MIT License


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-03

---
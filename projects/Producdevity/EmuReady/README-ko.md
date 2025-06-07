# EmuReady

다양한 기기와 에뮬레이터에서의 에뮬레이션 호환성을 추적하는 커뮤니티 주도 플랫폼입니다.

웹사이트 방문: [https://emuready.com](https://emuready.com)

---

**홈 페이지 스크린샷**

<img src="https://github.com/user-attachments/assets/9a7077fd-a9b1-4a1c-8a81-8f9beed25581" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/df612c7c-4b9d-481b-ae92-175b2b6afb0b" width="48%">

---

**호환성 목록 페이지 스크린샷**

<img src="https://github.com/user-attachments/assets/400c48d4-6340-4a60-8d86-f996a35f1bf4" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/4ca1c1de-3616-4c25-81b9-ad80f8a69458" width="48%">

---

**게임 페이지 스크린샷**

<img src="https://github.com/user-attachments/assets/b036de53-18ed-4bf4-8117-5cd36e87ee31" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/9fbe12c4-3387-4e1d-986a-df80761134e3" width="48%">

---

## 개요

EmuReady는 다양한 하드웨어 및 소프트웨어 환경에서의 에뮬레이션 호환성 정보를 공유하고 발견할 수 있도록 돕습니다. 사용자는 호환성 리포트를 기여하고, 목록에 투표하며, 특정 게임/기기/에뮬레이터 조합에 대해 토론할 수 있습니다.

![License](https://img.shields.io/github/license/Producdevity/emuready?cacheSeconds=1)
![Stars](https://img.shields.io/github/stars/Producdevity/emuready?cacheSeconds=1)
![Forks](https://img.shields.io/github/forks/Producdevity/emuready?cacheSeconds=1)
![Issues](https://img.shields.io/github/issues/Producdevity/emuready?cacheSeconds=1)

## 주요 기능

- **포괄적인 호환성 데이터베이스**: 다양한 에뮬레이터와 기기에서의 게임 동작 추적
- **사용자 기여**: 커뮤니티 기반 리포트 및 투표 시스템
- **토론 시스템**: 업/다운 투표가 가능한 댓글 스레드
- **관리자 대시보드**: 사용자, 목록 및 콘텐츠 관리
- **반응형 디자인**: 모바일, 태블릿, 데스크톱 지원

## 최근 개선 사항

아래와 같은 개선으로 코드베이스가 크게 향상되었습니다.

### UI 컴포넌트

- 더 나은 오류 처리 및 복구를 위한 **ErrorBoundary** 컴포넌트 추가
- 성능 향상을 위한 Next.js 이미지 컴포넌트를 활용한 **OptimizedImage** 컴포넌트 추가
- 접근성, 키보드 내비게이션, UX가 향상된 **Pagination** 개선
- 더 많은 변형, 사이즈, pill 옵션이 추가된 **Badge** 컴포넌트 개선
- 라이트, 다크, 시스템 테마 전환이 가능한 **ThemeToggle** 컴포넌트 추가
- 시각적 표시가 있는 테이블 정렬용 **SortableHeader** 구현

### 캐싱 및 성능

- 캐싱, stale time, 재시도 로직이 개선된 React Query 설정
- 기기 이미지에 대한 이미지 최적화 추가
- 전체 애플리케이션에 적절한 오류 처리 구현

### 접근성

- 인터랙티브 요소에 대한 키보드 내비게이션 강화
- 적절한 ARIA 레이블 및 역할 추가
- 포커스 관리 개선
- UI 컴포넌트의 색상 대비 향상

### 보안

- 여러 레벨(클라이언트, 서버, 데이터베이스)에서의 데이터 검증 및 정제
- Content Security Policy 구현
- XSS 및 CSRF 공격 방지
- NextAuth.js를 이용한 안전한 인증
- 파일 업로드 검증 및 보안 조치
- 입력 길이 제한 및 적절한 정제
- 파라미터 변조 방지를 위한 UUID 검증

### 개발자 경험

- 개발 워크플로우를 위한 추가 npm 스크립트
- 일관된 내보내기 방식의 프로젝트 구조 개선
- 커스텀 ErrorBoundary로 오류 피드백 강화
- 유용한 내비게이션 옵션이 포함된 404 페이지 개선

### 테마

- 시스템 테마 환경설정 감지 기능 추가
- 다양한 UI 옵션이 있는 테마 토글 생성
- 컴포넌트 전반에 걸친 다크 모드 구현 개선

## 시작하기

### 필수 조건

- Node.js 20 이상
- `npm`
- PostgreSQL (개발용으로는 SQLite 가능)

### 설치

1. 저장소 클론

```bash
git clone https://github.com/Producdevity/emuready.git
cd emuready
```

2. 의존성 설치

```bash
npm install
```

3. 환경 변수 설정

```bash
cp .env.example .env
```

그런 다음 `.env` 파일을 열어 데이터베이스 정보 및 기타 설정을 입력하세요.

4. 데이터베이스 설정

```bash
npx prisma generate
npx prisma db push
```

5. 개발 서버 실행

```bash
npm run dev
```

6. 브라우저에서 [http://localhost:3000](http://localhost:3000) 열기

## 사용 가능한 스크립트

- `npm run dev` - 개발 서버 시작
- `npm run dev:strict` - React strict mode로 시작
- `npm run build` - 프로덕션 빌드
- `npm run start` - 프로덕션 서버 시작
- `npm run test` - 테스트 실행
- `npm run lint` - ESLint 실행
- `npm run lint:fix` - 린트 문제 자동 수정
- `npm run format` - Prettier로 코드 포맷팅
- `npm run typecheck` - TypeScript 타입 체크
- `npm run analyze` - 번들 크기 분석
- `npm run clean` - 빌드 캐시 정리
- `npm run prepare-deploy` - 배포 준비 (lint, typecheck, test, build)

### Prisma 명령어

- `npx prisma db seed` - 데이터베이스 시드
- `npx prisma studio` - Prisma Studio 열기
- `npx prisma db pull` - 데이터베이스 스키마 가져오기
- `npx prisma db push` - 데이터베이스 스키마 적용

자세한 내용은 [Prisma Cli Reference](https://www.prisma.io/docs/orm/reference/prisma-cli-reference)를 참고하세요.

## 기술 스택

- **프레임워크**: Next.js 15
- **데이터베이스 ORM**: Prisma
- **API**: tRPC
- **인증**: NextAuth.js
- **스타일링**: Tailwind CSS
- **상태 관리**: React Query
- **타입 체크**: TypeScript
- **애니메이션**: Framer Motion
- **검증**: Zod, Content Security Policy, 입력 검증

## 기여 안내

기여를 환영합니다! 자세한 내용은 [기여 가이드라인](https://raw.githubusercontent.com/Producdevity/EmuReady/master/CONTRIBUTING.md)을 참고하세요.

## 라이선스

이 프로젝트는 MIT 라이선스 하에 제공됩니다. 자세한 내용은 [LICENSE](https://raw.githubusercontent.com/Producdevity/EmuReady/master/LICENSE) 파일을 참고하세요.

## 행동 강령 (TODO)

이 프로젝트는 [행동 강령](https://raw.githubusercontent.com/Producdevity/EmuReady/master/CODE_OF_CONDUCT.md)을 준수합니다. 참여 시 해당 조건을 따라야 합니다.

## 보안 (TODO)

보안 취약점을 발견한 경우, [보안 정책](https://raw.githubusercontent.com/Producdevity/EmuReady/master/SECURITY.md)에 따라 신고해 주세요.

## 감사의 글

- 모든 [기여자](https://github.com/Producdevity/emuready/graphs/contributors)
- 영감을 주고 지원해 준 에뮬레이션 커뮤니티

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---
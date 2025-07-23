
# 언버셀드 Next.js

> OpenNext를 사용하여 Cloudflare Workers에 배포된 툴링이 강력한 Next.js 15 스타터 킷 템플릿입니다.

## 포함된 내용

이 템플릿은 기본적인 "Hello World" 페이지만 포함하고 있지만, 다음과 같은 필요한 모든 툴링이 포함되어 있습니다:

- Changesets
- Github Actions
- Commitlint & Commitizen
- Lefthook pre-commit & commit-msg 훅
- Playwright E2E 테스트
- Vitest 단위 및 브라우저 컴포넌트 테스트
- Prettier, ESLint, Cspell & MarkdownLint
- Tailwind V4 & Shadcn UI
- 완전한 TypeScript TS 초기화
- 엄격한 TypeScript 설정
- Arktype & T3 Env

## 시작하기

1. 이 템플릿을 사용하여 새 저장소를 만듭니다
2. 템플릿을 로컬 머신에 클론합니다
3. `pnpm install` 명령을 실행합니다
4. `wrangler.toml` 파일을 편집하여 자신의 KV 네임스페이스 ID와 D1 데이터베이스 이름 및 ID를 입력합니다
5. Cloudflare에 배포하려면 먼저 `pnpm wrangler login`을 실행한 후, `pnpm run deploy`를 실행하면 됩니다

정말 간단합니다!

이 템플릿의 기본 설정을 확장하려면 OpenNext Cloudflare 문서 [https://opennext.js.org/cloudflare](https://opennext.js.org/cloudflare)를 참조하세요.

## 참고사항

- 메인 브랜치에 새 커밋이 있을 때 자동으로 애플리케이션을 배포하려면 [Cloudflare Workers Builds](https://developers.cloudflare.com/workers/ci-cd/builds/)를 사용할 수 있습니다.
- 이미지 최적화를 위한 커스텀 로더로 Cloudflare Images를 사용할 수 있습니다 [문서](https://opennext.js.org/cloudflare/howtos/image)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---
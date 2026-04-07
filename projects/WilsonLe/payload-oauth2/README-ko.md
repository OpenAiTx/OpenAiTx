# Payload OAuth2 플러그인

<a href="LICENSE">
  <img src="https://img.shields.io/badge/license-MIT-brightgreen.svg" alt="소프트웨어 라이선스" />
</a>
<a href="https://github.com/wilsonle/payload-oauth2/issues">
  <img src="https://img.shields.io/github/issues/wilsonle/payload-oauth2.svg" alt="이슈" />
</a>
<a href="https://npmjs.org/package/payload-oauth2">
  <img src="https://img.shields.io/npm/v/payload-oauth2.svg?style=flat-squar" alt="NPM" />
</a>

# 기능

- ✅ Payload v3와 호환 가능
- 🔐 모든 공급자와 OAuth2 구성 가능
- ✨ 의존성 제로
- ⚙ 고도로 커스터마이징 가능

# 통합

기술적으로 이 플러그인은 모든 일반적인 OAuth2 공급자와 작동해야 합니다. 테스트된 공급자 목록은 다음과 같습니다:

| 공급자  | 상태                                                                                                                                                                                                        | 예시                            |
| -------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------- |
| Google   | [![Google OAuth 테스트](https://github.com/WilsonLe/payload-oauth2/actions/workflows/test-google-oauth.yml/badge.svg)](https://github.com/WilsonLe/payload-oauth2/actions/workflows/test-google-oauth.yml)    | [설정](https://raw.githubusercontent.com/WilsonLe/payload-oauth2/main/./examples/google.ts)  |
| Zitadel  | [![Zitadel OAuth 테스트](https://github.com/WilsonLe/payload-oauth2/actions/workflows/test-zitadel-oauth.yml/badge.svg)](https://github.com/WilsonLe/payload-oauth2/actions/workflows/test-zitadel-oauth.yml) | [설정](https://raw.githubusercontent.com/WilsonLe/payload-oauth2/main/./examples/zitadel.ts) |
| Apple    | 테스트 미구현                                                                                                                                                                                                | [설정](https://raw.githubusercontent.com/WilsonLe/payload-oauth2/main/./examples/apple.ts)   |

# 설치

```
npm install payload-oauth2
yarn install payload-oauth2
pnpm install payload-oauth2
```
만약 모험을 즐기고 직접 플러그인을 관리하고 싶다면, `src` 디렉토리를 당신의 페이로드 프로젝트에 복사할 수 있습니다.

# 기여하기

기여와 피드백은 언제나 환영합니다.

실행하려면:

1. 프로젝트를 클론하세요.
2. `pnpm install`
3. `pnpm dev`

# 라이선스

MIT 라이선스(MIT). 자세한 내용은 [라이선스 파일](LICENSE)을 참조하세요.

# 크레딧

이 패키지는 [Payload Plugin OAuth](https://github.com/thgh/payload-plugin-oauth)에서 영감을 받았습니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-07

---
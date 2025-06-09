[![Nuxt 배너](https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/banner.svg)](https://nuxt.com)

# Nuxt

<p>
  <a href="https://www.npmjs.com/package/nuxt"><img src="https://img.shields.io/npm/v/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="버전"></a>
  <a href="https://www.npmjs.com/package/nuxt"><img src="https://img.shields.io/npm/dm/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="다운로드"></a>
  <a href="https://github.com/nuxt/nuxt/tree/main/LICENSE"><img src="https://img.shields.io/github/license/nuxt/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="라이선스"></a>
  <a href="https://nuxt.com"><img src="https://img.shields.io/badge/Nuxt%20Docs-18181B?logo=nuxt" alt="웹사이트"></a>
  <a href="https://chat.nuxt.dev"><img src="https://img.shields.io/badge/Nuxt%20Discord-18181B?logo=discord" alt="디스코드"></a>
  <a href="https://securityscorecards.dev/"><img src="https://api.securityscorecards.dev/projects/github.com/nuxt/nuxt/badge" alt="Nuxt openssf scorecard score"></a>
</p>

Nuxt는 Vue.js를 사용하여 타입-세이프하고, 고성능의, 그리고 프로덕션급의 풀스택 웹 애플리케이션과 웹사이트를 직관적이고 확장 가능한 방식으로 만들 수 있는 무료 오픈소스 프레임워크입니다.

Nuxt는 다음과 같은 빠르고 SEO 친화적이며 확장 가능한 웹 애플리케이션을 쉽게 구축할 수 있는 다양한 기능을 제공합니다:
- 서버 사이드 렌더링, 정적 사이트 생성, 하이브리드 렌더링, 엣지-사이드 렌더링
- 코드 스플리팅 및 프리-패칭이 적용된 자동 라우팅
- 데이터 패칭 및 상태 관리
- SEO 최적화 및 메타 태그 정의
- 컴포넌트, 컴포저블, 유틸 자동 임포트
- 제로 설정 타입스크립트 지원
- server/ 디렉토리를 통한 풀스택 개발
- [200개 이상의 모듈](https://nuxt.com/modules)로 확장 가능
- 다양한 [호스팅 플랫폼](https://nuxt.com/deploy)에 배포
- ...[그리고 더 많은 기능](https://nuxt.com) 🚀

### 목차

- 🚀 [시작하기](#getting-started)
- 💻 [Vue 개발](#vue-development)
- 📖 [문서](#documentation)
- 🧩 [모듈](#modules)
- ❤️  [기여하기](#contribute)
- 🏠 [로컬 개발](#local-development)
- 🛟 [전문 지원](#professional-support)
- 🔗 [팔로우하기](#follow-us)
- ⚖️ [라이선스](#license)

---

## <a name="getting-started">🚀 시작하기</a>

다음 명령어를 사용하여 새로운 스타터 프로젝트를 생성하세요. 필요한 모든 파일과 종속성이 포함된 스타터 프로젝트가 만들어집니다:

```bash
npm create nuxt <my-project>
```

> [!TIP]
> [nuxt.new](https://nuxt.new)도 확인해보세요: CodeSandbox, StackBlitz 또는 로컬에서 Nuxt 스타터를 빠르게 시작할 수 있습니다.

## <a name="vue-development">💻 Vue 개발</a>

간단하고 직관적이며 강력한 Nuxt는 Vue 컴포넌트를 가장 합리적인 방식으로 작성할 수 있게 해줍니다. 반복 작업은 모두 자동화되므로, 여러분은 자신 있게 풀스택 Vue 애플리케이션 개발에만 집중할 수 있습니다.

`app.vue` 예시:

```vue
<script setup lang="ts">
useSeoMeta({
  title: 'Meet Nuxt',
  description: 'The Intuitive Vue Framework.'
})
</script>

<template>
  <div id="app">
    <AppHeader />
    <NuxtPage />
    <AppFooter />
  </div>
</template>

<style scoped>
#app {
  background-color: #020420;
  color: #00DC82;
}
</style>
```

## <a name="documentation">📖 문서</a>

[Nuxt 공식 문서](https://nuxt.com/docs)를 꼭 참고하시기 바랍니다. 프레임워크에 대한 더 많은 내용을 배울 수 있는 최고의 자료입니다. 시작부터 고급 주제까지 모두 다룹니다.

## <a name="modules">🧩 모듈</a>

Nuxt 팀과 커뮤니티가 만든 [모듈 목록](https://nuxt.com/modules)을 확인하여 Nuxt 프로젝트를 더욱 강력하게 만들어보세요.

## <a name="contribute">❤️ 기여하기</a>

Nuxt의 발전을 위해 기여해주시길 초대합니다 💚

참여할 수 있는 몇 가지 방법:
- **버그 신고:** 버그나 문제를 발견했다면, [버그 신고 가이드](https://nuxt.com/docs/community/reporting-bugs)를 참고하여 버그 리포트를 제출해 주세요.
- **제안:** Nuxt를 개선할 아이디어가 있으신가요? [기여 가이드](https://nuxt.com/docs/community/contribution)를 참고하여 제안을 공유해 주세요.
- **질문:** 질문이 있거나 도움이 필요하다면, [도움 받기 가이드](https://nuxt.com/docs/community/getting-help)에서 다양한 지원 방법을 확인할 수 있습니다.

## <a name="local-development">🏠 로컬 개발</a>

프레임워크 및 문서에 기여하려면 [로컬 개발 환경 설정하기](https://nuxt.com/docs/community/framework-contribution#setup) 문서를 참고하세요.

## <a name="professional-support">🛟 전문 지원</a>

- 기술 감사 및 컨설팅: [Nuxt Experts](https://nuxt.com/enterprise/support)
- 맞춤 개발 및 기타: [Nuxt Agencies Partners](https://nuxt.com/enterprise/agencies)

## <a name="follow-us">🔗 팔로우하기</a>

<p valign="center">
  <a href="https://go.nuxt.com/discord"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/discord.svg" alt="Discord"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/x"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/twitter.svg" alt="Twitter"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/github"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/github.svg" alt="GitHub"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/bluesky"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/bluesky.svg" alt="Bluesky"></a>
</p>

## <a name="license">⚖️ 라이선스</a>

[MIT](https://github.com/nuxt/nuxt/tree/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---
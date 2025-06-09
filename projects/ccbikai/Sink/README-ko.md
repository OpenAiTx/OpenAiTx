# ⚡ Sink

**간단하고 / 빠르고 / 안전한 링크 단축 및 분석 기능, 100% Cloudflare에서 실행됩니다.**

<a href="https://trendshift.io/repositories/10421" target="_blank">
  <img
    src="https://trendshift.io/api/badge/repositories/10421"
    alt="ccbikai/Sink | Trendshift"
    width="250"
    height="55"
  />
</a>
<a href="https://news.ycombinator.com/item?id=40843683" target="_blank">
  <img
    src="https://hackernews-badge.vercel.app/api?id=40843683"
    alt="Featured on Hacker News"
    width="250"
    height="55"
  />
</a>
<a href="https://hellogithub.com/repository/57771fd91d1542c7a470959b677a9944" target="_blank">
  <img
    src="https://abroad.hellogithub.com/v1/widgets/recommend.svg?rid=57771fd91d1542c7a470959b677a9944&claim_uid=qi74Zp23wYKeAVB&theme=neutral"
    alt="Featured｜HelloGitHub"
    width="250"
    height="55"
  />
</a>
<a href="https://www.uneed.best/tool/sink" target="_blank">
  <img
    src="https://www.uneed.best/POTW1.png"
    alt="Uneed Badge"
    width="250"
    height="55"
  />
</a>

[<img src="https://devin.ai/assets/deepwiki-badge.png" alt="DeepWiki" height="20"/>](https://deepwiki.com/ccbikai/Sink)
![Cloudflare](https://img.shields.io/badge/Cloudflare-F69652?style=flat&logo=cloudflare&logoColor=white)
![Nuxt](https://img.shields.io/badge/Nuxt-00DC82?style=flat&logo=nuxtdotjs&logoColor=white)
![Tailwind CSS](https://img.shields.io/badge/Tailwind%20CSS-06B6D4?style=flat&logo=tailwindcss&logoColor=white)
![shadcn/ui](https://img.shields.io/badge/shadcn/ui-000000?style=flat&logo=shadcnui&logoColor=white)

![Hero](https://raw.githubusercontent.com/ccbikai/Sink/master/public/image.png)

----

## ✨ 주요 기능

- **URL 단축:** URL을 최소 길이로 압축합니다.
- **분석:** 링크 분석 및 유용한 통계 정보 제공.
- **서버리스:** 전통적인 서버 없이 배포 가능.
- **커스터마이즈 슬러그:** 사용자 지정 슬러그 및 대소문자 구분 지원.
- **🪄 AI 슬러그:** AI를 활용해 슬러그 자동 생성.
- **링크 만료:** 링크의 만료 날짜 설정 가능.

## 🪧 데모

[Sink.Cool](https://sink.cool/dashboard)에서 데모를 체험해보세요. 아래의 Site Token으로 로그인 가능합니다:

```txt
Site Token: SinkCool
```

<details>
  <summary><b>스크린샷</b></summary>
  <img alt="Analytics" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard.png"/>
  <img alt="Links" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard_links.png"/>
  <img alt="Link Analytics" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard_link_slug.png"/>
</details>

## 🧱 사용 기술

- **프레임워크**: [Nuxt](https://nuxt.com/)
- **데이터베이스**: [Cloudflare Workers KV](https://developers.cloudflare.com/kv/)
- **분석 엔진**: [Cloudflare Workers Analytics Engine](https://developers.cloudflare.com/analytics/)
- **UI 컴포넌트**: [shadcn-vue](https://www.shadcn-vue.com/)
- **스타일링:** [Tailwind CSS](https://tailwindcss.com/)
- **배포**: [Cloudflare](https://www.cloudflare.com/)

## 🚗 로드맵 [진행중]

여러분의 기여 및 PR을 환영합니다.

- [x] 브라우저 확장 프로그램
      - [Sink Tool](https://github.com/zhuzhuyule/sink-extension)
- [x] Raycast 확장 프로그램
      - [Raycast-Sink](https://github.com/foru17/raycast-sink)
- [x] 애플 단축어
      - [Sink Shortcuts](https://s.search1api.com/sink001)
- [x] iOS 앱
      - [Sink](https://apps.apple.com/app/id6745417598)
- [ ] 고급 링크 관리 (Cloudflare D1 연동)
- [ ] 분석 기능 확장 (필터 조건 병합 지원)
- [ ] 대시보드 성능 최적화 (무한 로딩)
- [ ] 단위 테스트

## 🏗️ 배포

> 동영상 튜토리얼: [여기에서 시청](https://www.youtube.com/watch?v=MkU23U2VE9E)

현재 [Cloudflare Workers](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/deployment/workers.md) (권장) 및 [Cloudflare Pages](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/deployment/pages.md) 배포를 지원합니다.

## ⚒️ 설정

[설정 문서](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/configuration.md)

## 🔌 API

[API 문서](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/api.md)

## 🧰 MCP

현재 MCP 서버를 네이티브로 지원하지 않지만, OpenAPI 문서를 제공하며 아래 방법으로 MCP를 지원할 수 있습니다.

> `OPENAPI_SPEC_URL`의 도메인명을 본인 도메인으로 변경하세요.
>
> `API_KEY`는 환경 변수의 `NUXT_SITE_TOKEN`과 동일합니다.

```json
{
  "mcpServers": {
    "sink": {
      "command": "uvx",
      "args": [
        "mcp-openapi-proxy"
      ],
      "env": {
        "OPENAPI_SPEC_URL": "https://sink.cool/_docs/openapi.json",
        "API_KEY": "SinkCool",
        "TOOL_WHITELIST": "/api/link/create"
      }
    }
  }
}
```

## 🙋🏻 자주 묻는 질문

[FAQ](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/faqs.md)

## 💖 크레딧

1. [**Cloudflare**](https://www.cloudflare.com/)
2. [**NuxtHub**](https://hub.nuxt.com/)
3. [**Astroship**](https://astroship.web3templates.com/)

## ☕ 후원

1. [X(Twitter)에서 팔로우하기](https://404.li/kai).
2. [GitHub에서 후원자가 되기](https://github.com/sponsors/ccbikai).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---
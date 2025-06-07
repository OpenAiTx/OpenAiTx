<a href="https://excalidraw.com/" target="_blank" rel="noopener">
  <picture>
    <source media="(prefers-color-scheme: dark)" alt="Excalidraw" srcset="https://excalidraw.nyc3.cdn.digitaloceanspaces.com/github/excalidraw_github_cover_2_dark.png" />
    <img alt="Excalidraw" src="https://excalidraw.nyc3.cdn.digitaloceanspaces.com/github/excalidraw_github_cover_2.png" />
  </picture>
</a>

<h4 align="center">
  <a href="https://excalidraw.com">Excalidraw 에디터</a> |
  <a href="https://plus.excalidraw.com/blog">블로그</a> |
  <a href="https://docs.excalidraw.com">문서</a> |
  <a href="https://plus.excalidraw.com">Excalidraw+</a>
</h4>

<div align="center">
  <h2>
    오픈 소스 가상 손그림 스타일 화이트보드. </br>
    협업 및 종단 간 암호화 지원. </br>
  <br />
  </h2>
</div>

<br />
<p align="center">
  <a href="https://github.com/excalidraw/excalidraw/blob/master/LICENSE">
    <img alt="Excalidraw는 MIT 라이선스로 배포됩니다." src="https://img.shields.io/badge/license-MIT-blue.svg"  />
  </a>
  <a href="https://www.npmjs.com/package/@excalidraw/excalidraw">
    <img alt="npm 다운로드/월" src="https://img.shields.io/npm/dm/@excalidraw/excalidraw"  />
  </a>
  <a href="https://docs.excalidraw.com/docs/introduction/contributing">
    <img alt="PR 환영!" src="https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=flat"  />
  </a>
  <a href="https://discord.gg/UexuTaE">
    <img alt="Discord에서 채팅하기" src="https://img.shields.io/discord/723672430744174682?color=738ad6&label=Chat%20on%20Discord&logo=discord&logoColor=ffffff&widge=false"/>
  </a>
  <a href="https://deepwiki.com/excalidraw/excalidraw">
    <img alt="DeepWiki에 질문하기" src="https://deepwiki.com/badge.svg" />
  </a>
  <a href="https://twitter.com/excalidraw">
    <img alt="트위터에서 Excalidraw 팔로우하기" src="https://img.shields.io/twitter/follow/excalidraw.svg?label=follow+@excalidraw&style=social&logo=twitter"/>
  </a>
</p>

<div align="center">
  <figure>
    <a href="https://excalidraw.com" target="_blank" rel="noopener">
      <img src="https://excalidraw.nyc3.cdn.digitaloceanspaces.com/github%2Fproduct_showcase.png" alt="제품 쇼케이스" />
    </a>
    <figcaption>
      <p align="center">
        아름다운 손그림 스타일의 다이어그램, 와이어프레임 등 원하는 무엇이든 만드세요.
      </p>
    </figcaption>
  </figure>
</div>

## 주요 기능

Excalidraw 에디터(npm 패키지)는 다음을 지원합니다:

- 💯&nbsp;무료 & 오픈 소스
- 🎨&nbsp;무한 캔버스 기반 화이트보드
- ✍️&nbsp;손그림과 유사한 스타일
- 🌓&nbsp;다크 모드
- 🏗️&nbsp;사용자 정의 가능
- 📷&nbsp;이미지 지원
- 😀&nbsp;도형 라이브러리 지원
- 🌐&nbsp;다국어(i18n) 지원
- 🖼️&nbsp;PNG, SVG, 클립보드로 내보내기
- 💾&nbsp;오픈 포맷 - `.excalidraw` json 파일로 내보내기
- ⚒️&nbsp;다양한 도구 - 사각형, 원, 다이아몬드, 화살표, 선, 자유 그리기, 지우개 등
- ➡️&nbsp;화살표 바인딩 및 라벨 화살표
- 🔙&nbsp;실행 취소/다시 실행(Undo/Redo)
- 🔍&nbsp;확대/축소 및 패닝 지원

## Excalidraw.com

[excalidraw.com](https://excalidraw.com)에 호스팅된 앱은 Excalidraw로 무엇을 만들 수 있는지 보여주는 최소한의 예시입니다. 이 앱의 [소스 코드](https://github.com/excalidraw/excalidraw/tree/master/excalidraw-app)도 이 저장소에 포함되어 있으며, 주요 기능은 다음과 같습니다:

- 📡&nbsp;PWA 지원(오프라인 동작)
- 🤼&nbsp;실시간 협업
- 🔒&nbsp;종단 간 암호화
- 💾&nbsp;로컬 우선 지원(브라우저에 자동 저장)
- 🔗&nbsp;공유 가능한 링크(읽기 전용 링크로 내보내어 다른 사람과 공유 가능)

이 기능들은 앞으로 npm 패키지를 위한 플러그인 형태로 추가될 예정입니다.

## 빠른 시작

**참고:** 아래 안내는 Excalidraw를 여러분의 앱에 통합할 때 사용하는 [npm 패키지](https://www.npmjs.com/package/@excalidraw/excalidraw) 설치 방법입니다. 저장소를 로컬에서 개발용으로 실행하려면 [개발 가이드](https://docs.excalidraw.com/docs/introduction/development)를 참고하세요.

`npm` 또는 `yarn`을 사용해 패키지를 설치하세요.

```bash
npm install react react-dom @excalidraw/excalidraw
# 또는
yarn add react react-dom @excalidraw/excalidraw
```

자세한 내용은 [문서](https://docs.excalidraw.com/docs/@excalidraw/excalidraw/installation)를 참고하세요!

## 기여하기

- 누락된 기능이 있거나 버그를 발견하셨나요? [여기에 신고하세요](https://github.com/excalidraw/excalidraw/issues).
- 기여를 원하시나요? [기여 가이드](https://docs.excalidraw.com/docs/introduction/contributing)를 확인하거나 [Discord](https://discord.gg/UexuTaE)에서 알려주세요.
- 번역에 참여하고 싶으신가요? [번역 가이드](https://docs.excalidraw.com/docs/introduction/contributing#translating)를 참고하세요.

## 통합 사례

- [VScode 확장 프로그램](https://marketplace.visualstudio.com/items?itemName=pomdtr.excalidraw-editor)
- [npm 패키지](https://www.npmjs.com/package/@excalidraw/excalidraw)

## Excalidraw를 통합한 곳

[Google Cloud](https://googlecloudcheatsheet.withgoogle.com/architecture) • [Meta](https://meta.com/) • [CodeSandbox](https://codesandbox.io/) • [Obsidian Excalidraw](https://github.com/zsviczian/obsidian-excalidraw-plugin) • [Replit](https://replit.com/) • [Slite](https://slite.com/) • [Notion](https://notion.so/) • [HackerRank](https://www.hackerrank.com/) • 그 외 다수

## 후원 & 지원

프로젝트가 마음에 드신다면 [Open Collective](https://opencollective.com/excalidraw)에서 후원하거나 [Excalidraw+](https://plus.excalidraw.com/)를 이용해보세요.

## Excalidraw를 지원해 주셔서 감사합니다

[<img src="https://opencollective.com/excalidraw/tiers/sponsors/0/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/0/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/1/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/1/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/2/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/2/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/3/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/3/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/4/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/4/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/5/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/5/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/6/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/6/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/7/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/7/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/8/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/8/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/9/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/9/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/10/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/10/website)

<a href="https://opencollective.com/excalidraw#category-CONTRIBUTE" target="_blank"><img src="https://opencollective.com/excalidraw/tiers/backers.svg?avatarHeight=32"/></a>

마지막으로, 아래 기업들이 무료로 서비스를 제공해 주셔서 감사드립니다:

[![Vercel](./.github/assets/vercel.svg)](https://vercel.com) [![Sentry](./.github/assets/sentry.svg)](https://sentry.io) [![Crowdin](./.github/assets/crowdin.svg)](https://crowdin.com)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---
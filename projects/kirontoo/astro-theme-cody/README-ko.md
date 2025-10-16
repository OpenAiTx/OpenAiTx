<a name="readme-top"></a>
<div align="center">
  
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![Netlify Status](https://api.netlify.com/api/v1/badges/3d9506ce-9212-47ae-b686-fb932a24f940/deploy-status)](https://app.netlify.com/sites/astro-theme-cody/deploys)  

<a href='https://ko-fi.com/F1F2J3RV9' target='_blank'><img height='36' style='border:0px;height:36px;' src='https://storage.ko-fi.com/cdn/kofi2.png?v=6' border='0' alt='Buy Me a Coffee at ko-fi.com' /></a>


  <p align="center">
    <h1>Astro 테마 코디</h1>
  <p>
    Astro로 제작된 미니멀리스트 블로그 테마입니다. 자신의 블로그를 시작하려는 누구에게나 빠르고 쉽게 시작할 수 있는 스타터 빌드입니다.
  </p>
    <a href="https://astro-theme-cody.netlify.app">데모 보기</a>
    ·
    <a href="https://github.com/kirontoo/astro-theme-cody/issues">버그 신고</a>
    ·
    <a href="https://github.com/kirontoo/astro-theme-cody/issues">기능 요청</a>
  </p>
  </p>
</div>

![demo-preview](https://github.com/kirontoo/astro-theme-cody/assets/28286622/d585dcb2-6d5f-4a68-871c-b6028cfcc27f)


## 목차
- [동기](#motivation)
- [주요 기능](#key-features)
- [데모](#demo)
- [빠른 시작](#quick-start)
- [명령어](#commands)
- [웹사이트 설정하기](#configuring-your-website)
  - [사이트 설정, 소셜 미디어 링크 및 네비게이션 바 링크](#site-config-social-media-links-and-navbar-links)
  - [게시물 및 프로젝트 추가](#adding-posts-and-projects)
  - [다국어 지원](#multi-language-support)
- [배포](#deploy)
- [추가 기능](#extra-funtionality)
- [크레딧](#credit)

## 동기
이미 많은 블로그 테마들이 있지만, 터미널/개발자 느낌을 주고
다른 테마에는 없는 몇 가지 기능을 가진 테마를 원했습니다.

## 주요 기능:
- Astro v4 빠름 🚀
- TailwindCSS 유틸리티 클래스
- 접근성 좋은 의미론적 HTML 마크업
- 반응형 및 SEO 친화적
- 다국어 지원
- Tailwind와 CSS 변수로 구현한 다크 / 라이트 모드
- 고정된 게시물 및 프로젝트
- 최적화된 이미지를 위한 [Astro Assets 통합](https://docs.astro.build/en/guides/assets/)
- MD 및 [MDX](https://docs.astro.build/en/guides/markdown-content/#mdx-only-features) 게시물
- 페이지네이션
- [PageFind](https://pagefind.app/)으로 게시물 검색
- [자동 RSS 피드](https://docs.astro.build/en/guides/rss)
- 자동 생성된 [사이트맵](https://docs.astro.build/en/guides/integrations-guide/sitemap/)
- [Astro Icon](https://github.com/natemoo-re/astro-icon) svg 아이콘 컴포넌트
- 상단으로 이동 버튼

## 데모
데모는 [여기](https://astro-theme-cody.netlify.app)에서 확인하세요.

## 빠른 시작
이 템플릿에서 [새 리포지토리 생성](https://github.com/new?template_name=astro-theme-cody&template_owner=kirontoo).

```
# npm 7+
npm create astro@latest -- --template kirontoo/astro-theme-cody

# pnpm
pnpm dlx create-astro --template kirontoo/astro-theme-cody
```
<p align="right">(<a href="#readme-top">맨 위로 돌아가기</a>)</p>


## 명령어

모든 명령어는 터미널에서 프로젝트 루트에서 실행됩니다:

| 명령어                     | 동작                                             |
| :------------------------ | :----------------------------------------------- |
| `pnpm install`             | 의존성 설치                                      |
| `pnpm run dev`             | `localhost:4321`에서 로컬 개발 서버 시작          |
| `pnpm run build`           | 프로덕션 사이트를 `./dist/`에 빌드                |
| `pnpm run preview`         | 배포 전에 빌드 미리보기                            |
| `pnpm run astro ...`       | `astro add`, `astro check` 같은 CLI 명령 실행    |
| `pnpm run astro -- --help` | Astro CLI 사용법 도움말 보기                       |

<p align="right">(<a href="#readme-top">맨 위로 돌아가기</a>)</p>

## 웹사이트 구성하기

### 사이트 설정, 소셜 미디어 링크 및 내비게이션 바 링크
사이트 설정, 소셜 미디어 링크, 내비게이션 바 링크는 모두 [`src/consts.ts`](https://github.com/kirontoo/astro-theme-cody/blob/main/src/consts.ts) 안에 있습니다.
여기서 사이트 기본 제목, 설명, 언어, 프로필, 소셜 미디어 링크 및 보이는 내비게이션 바 링크를 설정할 수 있습니다.

### 게시물 및 프로젝트 추가하기
이 테마는 [컨텐츠 컬렉션](https://docs.astro.build/en/guides/content-collections/)을 사용하여
Markdown 및/또는 MDX 파일을 조직하고, 스키마 -> `src/content/config.ts`를 통해 프런트매터 타입 검사를 합니다.

`src/content/blog`에서 블로그 게시물 예시를, `src/content/project`에서 프로젝트 예시를 확인할 수 있습니다.

#### 블로그 게시물 프런트매터
| 속성 (* = 필수)          | 설명                                           |
|:-----------------------| :--------------------------------------------- |
| title *                | 게시물 제목. 최대 150자 이내                      |
| description *          | 게시물에 대한 짧은 설명으로, SEO에도 사용됩니다. 최대 250자 이내입니다. |
| pubDate *              | 게시 날짜                                       |
| updateDate             | 게시물이 업데이트된 날짜(선택). 이 날짜가 있으면 게시물 정렬 시 게시 날짜 대신 사용됩니다.|
| heroImage              | 게시물의 선택적 커버 이미지. `src`와 `alt` 속성 모두 포함해야 합니다. 예시는 `src/content/blog/first-post.md`를 참고하세요.|


| ogImage | SEO에 사용되는 선택적 이미지입니다. |
| tags | 선택적 태그를 사용하여 게시물을 카테고리나 주제로 분류하세요. 모든 태그는 `yourdomain.com/tags`에 표시됩니다. |
| series | 선택적 시리즈를 사용하여 게시물을 시리즈로 구성하세요. 모든 시리즈는 `yourdomain.com/series`에 표시됩니다. |
| draft | 선택적 불리언 값입니다. 게시물의 게시를 제거합니다.|
| order | 1에서 5 사이의 선택적 숫자 값으로 특정 게시물을 상단에 고정합니다. 최대 5개의 고정 게시물만 허용됩니다.|
| hide  | 선택적 불리언 값입니다. `/blog` 페이지에서 게시물을 숨깁니다. `/archive`에는 계속 표시됩니다.|

#### 프로젝트 프런트매터

| 속성 (* = 필수) | 설명 |
|:-----------------------| :----------|
| title * | 프로젝트 제목입니다. 최대 150자까지 허용됩니다.  |
| description * | 프로젝트에 대한 간략한 설명으로 SEO에도 사용됩니다.|
| pubDate * | 게시일 |
| heroImage | 프로젝트의 선택적 커버 이미지입니다. `src`와 `alt` 속성을 모두 포함하세요. 예시는 `src/pages/projects/project-1.md`를 참조하세요.|
| ogImage | SEO에 사용되는 선택적 이미지입니다. |
| stack * | 프로젝트에 사용된 기술 목록으로 아이콘으로 렌더링됩니다. 이 테마는 SVG 로고 라이브러리를 사용하며, 필요한 아이콘은 [icones.js.org](https://icones.js.org/collection/vscode-icons)에서 찾을 수 있습니다.|
| platform | 웹사이트 또는 데모 링크 |
| website | 웹사이트 또는 데모 링크 |
| github | GitHub 저장소 링크 |
| draft | 선택적 불리언 값입니다. 프로젝트의 게시를 제거합니다.|
| order | 1에서 5 사이의 선택적 숫자 값으로 특정 프로젝트를 상단에 고정합니다. 최대 5개의 고정 게시물만 허용됩니다.|

<p align="right">(<a href="#readme-top">위로 가기</a>)</p>

### 다국어 지원
블로그의 다국어 지원 설정 방법은 [위키](https://github.com/kirontoo/astro-theme-cody/wiki/Set-up-multi%E2%80%90language-support)를 참조하세요.

## 배포
Astro는 다양한 플랫폼에서 Astro 웹사이트를 배포하는 훌륭한 문서를 제공합니다.
자세한 내용은 [여기](https://docs.astro.build/en/guides/deploy/)에서 확인할 수 있습니다.

## 추가 기능
RSS 피드와 같은 다른 기능을 추가하려면 [Astro Recipes](https://docs.astro.build/en/recipes/)를 확인하세요.


## 크레딧

이 테마는 [Astro Cactus](https://astro-theme-cactus.netlify.app)와 [Hugo Risotto](https://risotto.joeroe.io) 테마를 기반으로 합니다.

<p align="right">(<a href="#readme-top">위로 가기</a>)</p>

[contributors-shield]: https://img.shields.io/github/contributors/kirontoo/astro-theme-cody.svg?style=for-the-badge
[contributors-url]: https://github.com/kirontoo/astro-theme-cody/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/kirontoo/astro-theme-cody.svg?style=for-the-badge
[forks-url]: https://github.com/kirontoo/astro-theme-cody/network/members
[stars-shield]: https://img.shields.io/github/stars/kirontoo/astro-theme-cody.svg?style=for-the-badge
[stars-url]: https://github.com/kirontoo/astro-theme-cody/stargazers
[issues-shield]: https://img.shields.io/github/issues/kirontoo/astro-theme-cody.svg?style=for-the-badge
[issues-url]: https://github.com/kirontoo/astro-theme-cody/issues
[license-shield]: https://img.shields.io/github/license/kirontoo/astro-theme-cody.svg?style=for-the-badge
[license-url]: https://github.com/kirontoo/astro-theme-cody/blob/master/LICENSE.txt


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---
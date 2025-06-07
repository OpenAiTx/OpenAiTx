<p align="center">
  <img width="320" src="https://wpimg.wallstcn.com/ecc53a42-d79b-42e2-8852-5126b810a4c8.svg">
</p>

<p align="center">
  <a href="https://github.com/vuejs/vue">
    <img src="https://img.shields.io/badge/vue-2.6.10-brightgreen.svg" alt="vue">
  </a>
  <a href="https://github.com/ElemeFE/element">
    <img src="https://img.shields.io/badge/element--ui-2.7.0-brightgreen.svg" alt="element-ui">
  </a>
  <a href="https://travis-ci.org/PanJiaChen/vue-element-admin" rel="nofollow">
    <img src="https://travis-ci.org/PanJiaChen/vue-element-admin.svg?branch=master" alt="Build Status">
  </a>
  <a href="https://github.com/PanJiaChen/vue-element-admin/blob/master/LICENSE">
    <img src="https://img.shields.io/github/license/mashape/apistatus.svg" alt="license">
  </a>
  <a href="https://github.com/PanJiaChen/vue-element-admin/releases">
    <img src="https://img.shields.io/github/release/PanJiaChen/vue-element-admin.svg" alt="GitHub release">
  </a>
  <a href="https://gitter.im/vue-element-admin/discuss">
    <img src="https://badges.gitter.im/Join%20Chat.svg" alt="gitter">
  </a>
  <a href="https://panjiachen.github.io/vue-element-admin-site/donate">
    <img src="https://img.shields.io/badge/%24-donate-ff69b4.svg" alt="donate">
  </a>
</p>

English | [简体中文](./README.zh-CN.md) | [日本語](./README.ja.md) | [Spanish](./README.es.md)

<!-- <p align="center">
  <b>SPONSORED BY</b>
</p>
<table align="center" cellspacing="0" cellpadding="0">
  <tbody>
    <tr>
      <td align="center" valign="middle">
       <a href="" title="" target="_blank" style="padding-right: 20px;">
        <img height="200px" style="padding-right: 20px;" src="" title="variantForm">
        </a>
      </td>
    </tr>
  </tbody> 
</table>-->

## 소개

[vue-element-admin](https://panjiachen.github.io/vue-element-admin)은(는) 관리 인터페이스를 위한 프로덕션 수준의 프론트엔드 솔루션입니다. [vue](https://github.com/vuejs/vue)를 기반으로 하며, UI 툴킷으로 [element-ui](https://github.com/ElemeFE/element)를 사용합니다.

[vue-element-admin](https://panjiachen.github.io/vue-element-admin)은(는) vue의 최신 개발 스택을 기반으로 하며, 내장 i18n 솔루션, 엔터프라이즈 애플리케이션을 위한 전형적인 템플릿, 다양한 뛰어난 기능들을 제공합니다. 대규모 및 복잡한 싱글 페이지 애플리케이션(SPA) 구축을 도와줍니다. 여러분의 요구가 무엇이든, 이 프로젝트가 도움이 될 것이라 믿습니다.

- [미리보기](https://panjiachen.github.io/vue-element-admin)

- [문서](https://panjiachen.github.io/vue-element-admin-site/)

- [Gitter](https://gitter.im/vue-element-admin/discuss)

- [후원하기](https://panjiachen.github.io/vue-element-admin-site/donate/)

- [Wiki](https://github.com/PanJiaChen/vue-element-admin/wiki)

- [Gitee](https://panjiachen.gitee.io/vue-element-admin/) 국내 사용자는 이 주소에서 온라인 미리보기를 할 수 있습니다.

- 기본 템플릿 권장: [vue-admin-template](https://github.com/PanJiaChen/vue-admin-template)
- 데스크탑: [electron-vue-admin](https://github.com/PanJiaChen/electron-vue-admin)
- Typescript: [vue-typescript-admin-template](https://github.com/Armour/vue-typescript-admin-template) (크레딧: [@Armour](https://github.com/Armour))
- [awesome-project](https://github.com/PanJiaChen/vue-element-admin/issues/2312)

**`v4.1.0+` 버전 이후로 기본 master 브랜치는 i18n을 지원하지 않습니다. [i18n 브랜치](https://github.com/PanJiaChen/vue-element-admin/tree/i18n)를 사용해 주세요. master 브랜치와 동기화됩니다.**

**현재 버전은 `vue-cli` 기반의 `v4.0+`입니다. 문제가 있다면 [issue](https://github.com/PanJiaChen/vue-element-admin/issues/new)를 남겨주세요. 구버전 사용을 원하면 [tag/3.11.0](https://github.com/PanJiaChen/vue-element-admin/tree/tag/3.11.0) 브랜치로 전환하세요. 해당 버전은 `vue-cli`에 의존하지 않습니다.**

**이 프로젝트는 구버전 브라우저(예: IE)를 지원하지 않습니다. 필요 시 polyfill을 직접 추가하세요.**

## 준비 사항

[Node.js](https://nodejs.org/)와 [git](https://git-scm.com/)을 로컬에 설치해야 합니다. 본 프로젝트는 [ES2015+](https://es6.ruanyifeng.com/), [vue](https://cn.vuejs.org/index.html), [vuex](https://vuex.vuejs.org/zh-cn/), [vue-router](https://router.vuejs.org/zh-cn/), [vue-cli](https://github.com/vuejs/vue-cli), [axios](https://github.com/axios/axios) 및 [element-ui](https://github.com/ElemeFE/element)를 기반으로 하며, 모든 요청 데이터는 [Mock.js](https://github.com/nuysoft/Mock)로 시뮬레이션합니다.
이런 기술을 미리 이해하고 학습해두면 프로젝트 사용에 큰 도움이 됩니다.

[![Edit on CodeSandbox](https://codesandbox.io/static/img/play-codesandbox.svg)](https://codesandbox.io/s/github/PanJiaChen/vue-element-admin/tree/CodeSandbox)

<p align="center">
  <img width="900" src="https://wpimg.wallstcn.com/a5894c1b-f6af-456e-82df-1151da0839bf.png">
</p>

## 후원사

후원사가 되어 GitHub의 README에 귀사의 로고와 사이트 링크를 노출하세요. [[후원하기]](https://www.patreon.com/panjiachen)

### Akveo
<a href="https://store.akveo.com/products/vue-java-admin-dashboard-spring?utm_campaign=akveo_store-Vue-Vue_demo%2Fgithub&utm_source=vue_admin&utm_medium=referral&utm_content=github_banner"><img width="500px" src="https://raw.githubusercontent.com/PanJiaChen/vue-element-admin-site/master/docs/.vuepress/public/images/vue-java-banner.png" /></a><p>Java 백엔드와 Vue admin을 20% 할인(39$)된 가격에 만나보세요. 쿠폰 코드: SWB0RAZPZR1M
</p>

### Flatlogic

<a href="https://flatlogic.com/admin-dashboards?from=vue-element-admin"><img width="150px" src="https://wpimg.wallstcn.com/9c0b719b-5551-4c1e-b776-63994632d94a.png" /></a><p>Vue, React, Angular로 제작된 어드민 대시보드 템플릿.</p>

## 주요 기능

```
- 로그인 / 로그아웃

- 권한 인증
  - 페이지 권한
  - 디렉티브 권한
  - 권한 설정 페이지
  - 2단계 로그인

- 다중 환경 빌드
  - 개발(dev)
  - sit
  - 스테이지 테스트(stage)
  - 프로덕션(prod)

- 글로벌 기능
  - I18n
  - 다중 동적 테마
  - 동적 사이드바(다단계 라우팅 지원)
  - 동적 브레드크럼
  - 태그-뷰(Tab 페이지, 우클릭 지원)
  - Svg Sprite
  - Mock 데이터
  - 전체화면(Screenfull)
  - 반응형 사이드바

- 에디터
  - 리치 텍스트 에디터
  - 마크다운 에디터
  - JSON 에디터

- 엑셀
  - 엑셀 내보내기
  - 엑셀 업로드
  - 엑셀 시각화
  - zip 내보내기

- 테이블
  - 동적 테이블
  - 드래그 앤 드롭 테이블
  - 인라인 편집 테이블

- 에러 페이지
  - 401
  - 404

- 컴포넌트
  - 아바타 업로드
  - 맨 위로 이동
  - 드래그 다이얼로그
  - 드래그 셀렉트
  - 드래그 칸반
  - 드래그 리스트
  - SplitPane
  - Dropzone
  - Sticky
  - CountTo

- 고급 예제
- 에러 로그
- 대시보드
- 가이드 페이지
- ECharts
- 클립보드
- 마크다운 to html
```

## 시작하기

```bash
# 프로젝트 클론
git clone https://github.com/PanJiaChen/vue-element-admin.git

# 프로젝트 디렉토리로 이동
cd vue-element-admin

# 의존성 설치
npm install

# 개발 모드 실행
npm run dev
```

자동으로 http://localhost:9527 이 열립니다.

## 빌드

```bash
# 테스트 환경용 빌드
npm run build:stage

# 프로덕션 환경용 빌드
npm run build:prod
```

## 고급 기능

```bash
# 배포 환경 미리보기
npm run preview

# 배포 환경 미리보기 + 정적 리소스 분석
npm run preview -- --report

# 코드 포맷 검사
npm run lint

# 코드 포맷 검사 및 자동 수정
npm run lint -- --fix
```

자세한 내용은 [문서](https://panjiachen.github.io/vue-element-admin-site/guide/essentials/deploy.html)를 참고하세요.

## 변경 로그

각 릴리즈의 상세 변경사항은 [릴리즈 노트](https://github.com/PanJiaChen/vue-element-admin/releases)에 문서화되어 있습니다.

## 온라인 데모

[미리보기](https://panjiachen.github.io/vue-element-admin)

## 후원하기

이 프로젝트가 유용하다면, 저자에게 음료수 한 잔을 선물해 보세요 :tropical_drink:

![donate](https://wpimg.wallstcn.com/bd273f0d-83a0-4ef2-92e1-9ac8ed3746b9.png)

[Paypal Me](https://www.paypal.me/panfree23)

[Buy me a coffee](https://www.buymeacoffee.com/Pan)

## 브라우저 지원

최신 브라우저 및 Internet Explorer 10+ 지원.

| [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/edge/edge_48x48.png" alt="IE / Edge" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>IE / Edge | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/firefox/firefox_48x48.png" alt="Firefox" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>Firefox | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/chrome/chrome_48x48.png" alt="Chrome" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>Chrome | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/safari/safari_48x48.png" alt="Safari" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>Safari |
| --------- | --------- | --------- | --------- |
| IE10, IE11, Edge | 최신 2버전 | 최신 2버전 | 최신 2버전 |

## 라이선스

[MIT](https://github.com/PanJiaChen/vue-element-admin/blob/master/LICENSE)

Copyright (c) 2017-present PanJiaChen

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---
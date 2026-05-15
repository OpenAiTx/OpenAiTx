<div align="center">

<a href="https://github.com/oljc/arco-admin">
  <img width="180" src="https://github.com/user-attachments/assets/09c91ec6-1de8-400e-878c-e1066667ff08" alt="Arco admin logo">
</a>

<h1 align="center">Arco Admin</h1>
<p align="center">즉시 사용 가능하고 기능이 풍부한 중후단 관리 시스템 프레임워크로, 최신 기술 스택의 표준화된 프로젝트입니다.</p> 

간체중문 | [English](https://raw.githubusercontent.com/oljc/arco-admin/main/./README.en-US.md)

[![Netlify Status](https://api.netlify.com/api/v1/badges/4177124c-546f-4726-a842-00b72bf864fa/deploy-status)](https://arco-admin.netlify.app)
<a href="https://nodejs.org/en/about/previous-releases" target="_blank"><img alt="node compatibility" src="https://img.shields.io/node/v/vite.svg"></a>
<img alt="License" src="https://img.shields.io/github/license/oljc/arco-admin">
<img alt="Commit" src="https://img.shields.io/github/last-commit/oljc/arco-admin.svg">
<img alt="Version" src="https://img.shields.io/github/package-json/v/oljc/arco-admin/main">

[![Vercel](https://vercel.com/button)](https://vercel.com/new/clone?repository-url=https%3A%2F%2Fgithub.com%2Foljc%2Farco-admin&project-name=arco-admin&build-command=pnpm%20run%20build&install-command=pnpm%20i&output-directory=dist)
[![Netlify](https://www.netlify.com/img/deploy/button.svg)](https://app.netlify.com/start/deploy?repository=https://github.com/oljc/arco-admin)
[![EdgeOne Pages](https://cdnstatic.tencentcs.com/edgeone/pages/deploy.svg)](https://edgeone.ai/pages/new?repository-url=https%3A%2F%2Fgithub.com%2Foljc%2Farco-admin&repository-name=arco-admin&project-name=arco-admin&install-command=pnpm%20i&build-command=pnpm%20run%20build&output-directory=dist)

<img width="600" src="https://github.com/user-attachments/assets/49f985f1-bd8b-4ff6-9d38-25becb7a579e" alt="edgeone" />

본 프로젝트 CDN 가속 및 보안 방어는 [Tencent EdgeOne](https://edgeone.ai/zh?from=github)에서 후원합니다.

</div>

## 특징
+ ⚡️ 최신 Vue 및 Vite 버전을 지속적으로 추적합니다.
+ 👍🏻 [Vue](https://cn.vuejs.org) + 공식 추천 [Vue Router](https://router.vuejs.org/zh) + [Pinia](https://pinia.vuejs.org/zh) 상태 관리기.
+ 🔩 ByteDance가 제작한 엔터프라이즈급 디자인 생태계 [ArcoDesign](https://arco.design/) 컴포넌트 라이브러리.
+ 🎨 [Less](https://less.bootcss.com/) CSS 전처리기.
+ 📚 [i18n](https://github.com/intlify/vue-i18n-next/tree/master/packages/vue-i18n#readme) + [i18n-ally](https://github.com/lokalise/i18n-ally)를 사용하여 더 쉽고 표준화된 자동화 국제화 솔루션 구현.
+ ⌨️ 다양한 비즈니스 시나리오 페이지, 2차 래핑 컴포넌트, 프레임워크 지원 설정으로 손쉬운 맞춤형 설정 가능.
+ 🧚🏻 프로젝트는 전면적으로 `ESM` 표준 모듈 문법을 채택하여 현대 프론트엔드 개발 분야의 통합 추세를 따릅니다.
+ 📦 각종 `의존성`, `Vite`의 업데이트, 폐기, 통합 기능 등을 반영하여 최적의 번들 최적화 효과를 위해 설정을 지속 개선합니다.


---

<img src="https://github.com/user-attachments/assets/da090081-a568-4882-837e-38fd1dbe0a7f">

## 버전
- 국제화 버전：[i18n 브랜치](https://github.com/oljc/arco-admin/tree/i18n)

## 규칙
코드 품질을 향상시키고 오류를 줄이며 전체 프로젝트 코드 스타일의 일관성을 보장하여 코드 품질과 스타일을 더 쉽게 관리할 수 있습니다.

+ **코드 규칙：**  [ESLint](https://eslint.org/) + [Stylelint](https://stylelint.io) + [Prettier](https://prettier.io)<br/>
    *사전에 정의된 규칙을 통해 코드 문법, 스타일 및 형식에 대한 정적 검사와 규정을 하여 코드 품질과 가독성을 보장합니다*

+ **커밋 규칙：**  [Husky](https://typicode.github.io/husky/#/) + [Lint-Staged](https://github.com/okonet/lint-staged) + [Commitlint](https://commitlint.js.org)<br/>
  *코드 커밋 시 사전 설정된 코드 스타일 검사, 포맷팅 및 메시지 검증을 통해 매 커밋의 코드 품질과 스타일을 일관되게 유지합니다*

## 브라우저 지원

| <img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/edge/edge_48x48.png" alt="Edge" width="24px" height="24px" /><br/>Edge | <img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/firefox/firefox_48x48.png" alt="Firefox" width="24px" height="24px" /><br/>Firefox | <img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/chrome/chrome_48x48.png" alt="Chrome" width="24px" height="24px" /><br/>Chrome | <img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/safari/safari_48x48.png" alt="Safari" width="24px" height="24px" /><br/>Safari | <img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/samsung-internet/samsung-internet_48x48.png" alt="Samsung" width="24px" height="24px" /><br/>Samsung | <img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/opera/opera_48x48.png" alt="Opera" width="24px" height="24px" /><br/>Opera | <img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/electron/electron_48x48.png" alt="Electron" width="24px" height="24px" /><br/>Electron |
| --------- | --------- | --------- | --------- | --------- | --------- | --------- |
| Edge >=16| >= 31 | >= 49| >= 31| 최신 2개 버전| >= 36 | 최신 2개 버전

## 사용
1. 이 저장소를 클론하십시오
```bash
git clone https://github.com/oljc/arco-admin
```
2. 의존성 설치
```bash
pnpm i
```
3. 运行
```bash
pnpm run dev
```
#### VsCode 확장 추천


| [<img src="https://vue.gallerycdn.vsassets.io/extensions/vue/volar/2.2.4/1740301455362/Microsoft.VisualStudio.Services.Icons.Default" width="24px" height="24px" /><br>Official](https://marketplace.visualstudio.com/items?itemName=Vue.volar) | [<img src="https://dbaeumer.gallerycdn.vsassets.io/extensions/dbaeumer/vscode-eslint/2.4.2/1687441427519/Microsoft.VisualStudio.Services.Icons.Default" width="24px" height="24px" /><br>ESLint](https://marketplace.visualstudio.com/items?itemName=dbaeumer.vscode-eslint) |[<img src="https://esbenp.gallerycdn.vsassets.io/extensions/esbenp/prettier-vscode/10.1.0/1690819498575/Microsoft.VisualStudio.Services.Icons.Default" width="24px" height="24px" /><br>Prettier](https://marketplace.visualstudio.com/items?itemName=esbenp.prettier-vscode) |[<img src="https://lokalise.gallerycdn.vsassets.io/extensions/lokalise/i18n-ally/2.12.0/1695476646920/Microsoft.VisualStudio.Services.Icons.Default" width="24px" height="24px" /><br>i18n Ally](https://marketplace.visualstudio.com/items?itemName=Lokalise.i18n-ally) |[<img src="https://stylelint.gallerycdn.vsassets.io/extensions/stylelint/vscode-stylelint/1.3.0/1698920117910/Microsoft.VisualStudio.Services.Icons.Default" width="25px" height="25px" /><br>Stylelint](https://marketplace.visualstudio.com/items?itemName=stylelint.vscode-stylelint)|[<img src="https://editorconfig.gallerycdn.vsassets.io/extensions/editorconfig/editorconfig/0.16.4/1607315835386/Microsoft.VisualStudio.Services.Icons.Default" width="25px" height="25px" /><br>EditorConfig](https://marketplace.visualstudio.com/items?itemName=EditorConfig.EditorConfig)|[<img src="https://antfu.gallerycdn.vsassets.io/extensions/antfu/vite/0.2.5/1622972526798/Microsoft.VisualStudio.Services.Icons.Default" width="25px" height="25px" /><br>Vite](https://marketplace.visualstudio.com/items?itemName=antfu.vite)|
| --- | --- | --- | ---| --- | --- | --- |

## 업적
Vite 공식 [awesome-vite](https://github.com/vitejs/awesome-vite#vue-3) 커뮤니티 선정 프로젝트 목록에 등록되었습니다 🎉 

## 기여
모든 형태의 기여를 환영하며, 모든 참여를 성실히 다루겠습니다.<br/><br/>
<a href="https://github.com/oljc/arco-admin/graphs/contributors"><img src="https://contrib.rocks/image?repo=oljc/arco-admin" />
</a><br/>

# 라이선스
본 프로젝트는 [MIT 라이선스](./LICENSE)를 따릅니다.

[![트렌드 차트](https://starchart.cc/oljc/arco-admin.svg)](https://starchart.cc/oljc/arco-admin)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-15

---
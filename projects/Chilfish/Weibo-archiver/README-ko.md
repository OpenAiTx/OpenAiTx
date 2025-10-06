<div align="center">
  <img
    alt="logo"
    width="100"
    src="https://p.chilfish.top/weibo/icon.webp"
  />

  <div>
    <a href="https://deepwiki.com/Chilfish/Weibo-archiver"><img src="https://deepwiki.com/badge.svg" alt="Ask DeepWiki"></a>
    <img src="https://wakatime.com/badge/user/0842a71f-c026-4b09-8aa0-f8398b4c3423/project/3416f224-f0dc-4b08-805c-af30dbd396b2.svg" alt="wakatime">
    <img alt="GitHub Repo stars" src="https://img.shields.io/github/stars/chilfish/weibo-archiver">
    <img alt="GitHub Downloads" src="https://img.shields.io/github/downloads/chilfish/weibo-archiver/total">
    <img alt="beta build" src="https://github.com/Chilfish/Weibo-archiver/actions/workflows/beta-build.yml/badge.svg">
  </div>
</div>

## Weibo-archiver

당신의 신랑 웨이보 추억을 아카이브하세요, 계정이 완전히 사라지기 전에 미리 대비하세요 😭 공식 사이트: [weibo-archiver.chilfish.top](https://weibo-archiver.chilfish.top)

![커버](https://p.chilfish.top/weibo/cover.webp)

### 사용 방법

자세한 내용은 [온라인 문서]를 참고하세요

> 이전 버전은 [v0.5 브랜치](https://github.com/Chilfish/Weibo-archiver/tree/v0.5) 또는 https://weibo.chilfish.top/ 에서 확인할 수 있으며, [문서: 이전 버전에서 마이그레이션](https://weibo-archiver.chilfish.top/docs/intro.html#从旧版本迁移) 부분에서 설명을 확인하세요

### 개발자용

본 프로젝트는 monorepo 구조를 사용하며, pnpm으로 관리되므로 먼저 pnpm을 설치해야 합니다: `npm i -g pnpm`

packages 디렉터리 내에는:

- [/core](packages/core/) 도구 함수와 데이터 처리의 핵심을 포함

apps 디렉터리 내에는 최종 애플리케이션들이 위치

- [/web](apps/web-v2/) 는 웨이보 데이터를 최종적으로 볼 수 있는 웹페이지로, 현재 [vercel]에 호스팅 중
- [/monkey](apps/monkey/) 는 유저스크립트(오일몽키 스크립트)로 패키징하는 용도
- [/cli](apps/cli) Nodejs 명령어 버전

> vercel에 직접 배포하기 전에, vercel 프로젝트 설정에서 Root Directory를 `apps/web-v2`로 설정해야 프로젝트를 올바르게 인식하고 빌드할 수 있습니다.

server 디렉토리에는 go 언어로 작성된 로컬 서버가 있으며, 이미지 다운로드와 웨이보 데이터 탐색에 사용됩니다. 구체적인 사용법은 [로컬 서버 사용 설명](https://raw.githubusercontent.com/Chilfish/Weibo-archiver/main/server/README.md)에서 확인할 수 있습니다.

### 감사의 말씀

- 기본 아이디어를 제공해 주신 [speechless]께 감사드립니다.
- [vite-plugin-monkey]는 유저스크립트로 패키징하는 도구를 제공합니다.
- Shadcn/ui는 아름다운 UI 컴포넌트 라이브러리를 제공합니다.
- [vercel]은 온라인 클라우드 플랫폼 배포를 지원합니다😚
- Github Copilot & v0.dev에 감사드립니다😇

### 후원

이 프로젝트가 도움이 되었다면, 저에게 후원을 고려해 주세요😇 이는 제가 이 프로젝트를 유지하는 데 더 많은 동기를 부여할 것입니다: [후원 주소]

[releases]: https://raw.githubusercontent.com/Chilfish/Weibo-archiver/monkey/weibo-archiver.user.js
[scripts.zip]: https://github.com/Chilfish/Weibo-archiver/raw/monkey/scripts.zip
[speechless]: https://github.com/meterscao/Speechless
[naive-ui]: https://www.naiveui.com/zh-CN/os-theme
[#1]: https://github.com/Chilfish/Weibo-archiver/issues/1
[#5]: https://github.com/Chilfish/Weibo-archiver/issues/5
[Node.js 官网]: https://nodejs.org/en/download
[vite-plugin-monkey]: https://github.com/lisonge/vite-plugin-monkey
[镜像地址]: https://p.chilfish.top/weibo-archiver.user.js
[项目的 Todo]: https://github.com/Chilfish/Weibo-archiver/issues/7
[赞助地址]: https://chilfish.top/sponsors
[vercel]: https://vercel.com
[使用教程]: https://docs.qq.com/doc/DTWttbXlMUGxZZnZq
[actions]: https://github.com/Chilfish/Weibo-archiver/actions/workflows/beta-build.yml?query=branch:main+event:push+is:success
[微博网页版]: https://weibo.com
[在线文档]: https://weibo-archiver.chilfish.top/docs/


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---
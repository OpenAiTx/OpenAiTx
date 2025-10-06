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

Archive your Sina Weibo memories to prepare for the complete disappearance of your account 😭 Official site: [weibo-archiver.chilfish.top](https://weibo-archiver.chilfish.top)

![Cover](https://p.chilfish.top/weibo/cover.webp)

### Usage

See the [online documentation] for detailed instructions

> Old versions can be found on the [v0.5 branch](https://github.com/Chilfish/Weibo-archiver/tree/v0.5) or at https://weibo.chilfish.top/, see the [Documentation: Migrating from old versions](https://weibo-archiver.chilfish.top/docs/intro.html#从旧版本迁移) section for details

### For Developers

The project uses a monorepo structure managed by pnpm, so you need to install pnpm first: `npm i -g pnpm`

Under the packages directory:

- [/core](packages/core/) contains utility functions and core data processing

Under the apps directory are the final applications

- [/web](apps/web-v2/) is the web page for viewing Weibo data, currently hosted on [vercel]
- [/monkey](apps/monkey/) is used to package the userscript
- [/cli](apps/cli) Nodejs command line version

> Before deploying directly to vercel, you need to set the Root Directory to `apps/web-v2` in the vercel project settings to correctly recognize and build the project.

In the server directory, there is a local server written in Go language for downloading images and browsing Weibo data. For detailed usage, see [Local Server Usage Instructions](https://raw.githubusercontent.com/Chilfish/Weibo-archiver/main/server/README.md)

### Acknowledgements

- Thanks to [speechless] for providing the basic idea
- [vite-plugin-monkey] provided the tool for packaging into Tampermonkey scripts
- Shadcn/ui provided the beautiful UI component library
- [vercel] provided the online cloud platform deployment 😚
- Github Copilot & v0.dev 😇

### Sponsorship

If you find this project helpful, consider sponsoring me 😇 it will give me more motivation to maintain this project: [Sponsorship Address]

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
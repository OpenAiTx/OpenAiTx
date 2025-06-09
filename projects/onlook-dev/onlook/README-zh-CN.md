<!-- 改进返回顶部链接的兼容性：见：https://github.com/othneildrew/Best-README-Template/pull/73 -->

<div align="center">
<img width="800" alt="header image" src="https://raw.githubusercontent.com/onlook-dev/onlook/main/assets/web-preview.png">
<h3 align="center">Onlook</h3>
  <p align="center">
    设计师的光标
    <br />
    <a href="https://docs.onlook.com"><strong>探索文档 »</strong></a>
    <br />
    <br />
    <a href="https://youtu.be/RSX_3EaO5eU?feature=shared">观看演示</a>
    ·
    <a href="https://github.com/onlook-dev/onlook/issues/new?labels=bug&template=bug-report---.md">报告Bug</a>
    ·
    <a href="https://github.com/onlook-dev/onlook/issues/new?labels=enhancement&template=feature-request---.md">请求新功能</a>
  </p>
  <!-- PROJECT SHIELDS -->
<!--
*** 我使用 markdown 的“引用样式”链接以提升可读性。
*** 引用链接用方括号 [ ] 包裹，而不是圆括号 ( )。
*** 参见本文档底部对 contributors-url、forks-url 等引用变量的声明
*** 这是一种可选的简洁语法，你可以使用。
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
<!-- [![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![Apache License][license-shield]][license-url] -->

[![Discord][discord-shield]][discord-url]
[![LinkedIn][linkedin-shield]][linkedin-url]
[![Twitter][twitter-shield]][twitter-url]

[中文](https://www.readme-i18n.com/onlook-dev/onlook?lang=zh) | 
[Español](https://www.readme-i18n.com/onlook-dev/onlook?lang=es) | 
[Deutsch](https://www.readme-i18n.com/onlook-dev/onlook?lang=de) | 
[français](https://www.readme-i18n.com/onlook-dev/onlook?lang=fr) | 
[Português](https://www.readme-i18n.com/onlook-dev/onlook?lang=pt) | 
[Русский](https://www.readme-i18n.com/onlook-dev/onlook?lang=ru) | 
[日本語](https://www.readme-i18n.com/onlook-dev/onlook?lang=ja) | 
[한국어](https://www.readme-i18n.com/onlook-dev/onlook?lang=ko)

</div>

# 设计师的光标 – 一个开源、视觉优先的代码编辑器

使用 AI 结合 Next.js + TailwindCSS 打造网站、原型和设计。通过可视化编辑器直接在浏览器 DOM 中编辑。实时用代码进行设计。是 Bolt.new、Lovable、V0、Replit Agent、Figma Make、Webflow 等的开源替代品。

### 🚧 🚧 🚧 Onlook for Web 仍在开发中 🚧 🚧 🚧

我们正在积极寻找贡献者，一起让 Onlook for Web 成为令人惊叹的 prompt-to-build 体验。查看[开放问题](https://github.com/onlook-dev/onlook/issues)，了解全部的功能提案（及已知问题），并加入我们的[Discord](https://discord.gg/hERDfFZCsH) 与数百名其他开发者协作。

## 使用 Onlook 可以做什么：

- [x] 秒级创建 Next.js 应用
  - [x] 从文本或图片开始
  - [ ] 使用预设模板
  - [ ] 从 Figma 导入
  - [ ] 从 GitHub 仓库开始
- [x] 可视化编辑你的应用
  - [x] 使用类 Figma 的 UI
  - [x] 实时预览应用
  - [x] 管理品牌资产和令牌
  - [x] 创建和跳转页面
  - [ ] 图层浏览 – _此前功能在
        [Onlook Desktop](https://github.com/onlook-dev/desktop)_
  - [ ] 组件检测与使用 – _此前功能在
        [Onlook Desktop](https://github.com/onlook-dev/desktop)_
  - [ ] 项目图片管理 – _此前功能在
        [Onlook Desktop](https://github.com/onlook-dev/desktop)_
- [x] 开发工具
  - [x] 实时代码编辑器
  - [x] 保存与恢复检查点
  - [x] 通过 CLI 运行命令
  - [x] 连接应用市场
  - [ ] 本地编辑代码 – _此前功能在
        [Onlook Desktop](https://github.com/onlook-dev/desktop)_
- [ ] 秒级部署应用
  - [ ] 生成可分享链接
  - [ ] 绑定自定义域名
- [ ] 团队协作
  - [ ] 实时协同编辑
  - [ ] 留言评论

![Onlook-GitHub-Example](https://github.com/user-attachments/assets/642de37a-72cc-4056-8eb7-8eb42714cdc4)

### Onlook for Desktop（又名 Onlook Alpha）

我们正在为 Onlook Web 提供早期预览。如果你正在寻找可下载的桌面 electron 应用，它已迁移至
[Onlook Desktop](https://github.com/onlook-dev/desktop)。

为什么我们要迁移到 Web？阅读我们的决策说明：
[从 Electron 迁移到 Web](https://docs.onlook.com/docs/developer/electron-to-web-migration)

## 快速开始

即将通过[托管应用](https://onlook.com)或
[本地运行](https://docs.onlook.com/docs/developer/running-locally)提供。

### 使用方法

Onlook 可在任何 Next.js + TailwindCSS 项目上运行，将你的项目导入 Onlook 或在编辑器内从零开始。

使用 AI 聊天创建或编辑你的项目。在任何时候，你都可以右键元素，打开代码中该元素的确切位置。

<img width="600" alt="image" src="https://github.com/user-attachments/assets/4ad9f411-b172-4430-81ef-650f4f314666" />

<br>

绘制新 div，并通过拖拽在父容器内重新排列。

<img width="600" alt="image" src="https://raw.githubusercontent.com/onlook-dev/onlook/main/assets/insert-div.png">

<br>

并排预览代码和网站设计。

<img width="600" alt="image" src="https://raw.githubusercontent.com/onlook-dev/onlook/main/assets/code-connect.png">

<br>

使用 Onlook 编辑器工具栏调整 Tailwind 样式，直接操作对象，探索不同布局。

<img width="600" alt="image" src="https://raw.githubusercontent.com/onlook-dev/onlook/main/assets/text-styling.png" />

## 文档

完整文档请访问 [docs.onlook.com](https://docs.onlook.com)

关于如何贡献，请查看
[为 Onlook 贡献](https://docs.onlook.com/docs/developer/contributing)。

## 工作原理

<img width="676" alt="architecture" src="https://raw.githubusercontent.com/onlook-dev/onlook/main/assets/architecture.png">

1. 当你创建应用时，我们将代码加载到 Web 容器中
2. 容器运行并提供代码服务
3. 编辑器收到预览链接并在 iFrame 中展示
4. 编辑器读取并索引容器中的代码
5. 我们对代码进行仪表化，以便将元素映射到代码中的位置
6. 当元素被编辑时，我们先在 iFrame 中编辑元素，然后再编辑代码
7. 我们的 AI 聊天同样可以访问代码，并具备理解和编辑代码的工具

这种架构理论上可以扩展到任何以声明式展示 DOM 元素的语言或框架（如 jsx/tsx/html）。目前我们专注于让其在 Next.js 和 TailwindCSS 下表现优异。

完整演示请查看我们的
[架构文档](https://docs.onlook.com/docs/developer/architecture)。

### 技术栈

#### 前端

- [Next.js](https://nextjs.org/) - 全栈
- [TailwindCSS](https://tailwindcss.com/) - 样式
- [tRPC](https://trpc.io/) - 服务接口

#### 数据库

- [Supabase](https://supabase.com/) - 认证、数据库、存储
- [Drizzle](https://orm.drizzle.team/) - ORM

#### AI

- [AI SDK](https://ai-sdk.dev/) - LLM 客户端
- [Anthropic](https://ai-sdk.dev/) - LLM 模型提供商
- [Morph Fast Apply](https://morphllm.com) - 快速应用模型提供商
- [Relace](https://relace.ai) - 快速应用模型提供商

#### 沙箱与托管

- [CodeSandboxSDK](https://codesandbox.io/docs/sdk) - 开发沙箱
- [Freestyle](https://www.freestyle.sh/) - 托管

#### 运行时

- [Bun](https://bun.sh/) - Monorepo、运行时、打包器
- [Docker](https://www.docker.com/) - 容器管理

## 贡献
![image](https://github.com/user-attachments/assets/ecc94303-df23-46ae-87dc-66b040396e0b)

如果您有任何建议可以改进本项目，请 fork 该仓库并创建 pull request。您也可以[提交问题](https://github.com/onlook-dev/onlook/issues)。

请参阅 [CONTRIBUTING.md](https://raw.githubusercontent.com/onlook-dev/onlook/main/CONTRIBUTING.md) 获取相关说明和行为准则。

#### 贡献者

<a href="https://github.com/onlook-dev/onlook/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=onlook-dev/onlook" />
</a>

## 联系方式

![image](https://github.com/user-attachments/assets/60684b68-1925-4550-8efd-51a1509fc953)

- 团队：[Discord](https://discord.gg/hERDfFZCsH) -
  [Twitter](https://twitter.com/onlookdev) -
  [LinkedIn](https://www.linkedin.com/company/onlook-dev/) -
  [邮箱](mailto:contact@onlook.com)
- 项目：
  [https://github.com/onlook-dev/onlook](https://github.com/onlook-dev/onlook)
- 官网：[https://onlook.com](https://onlook.com)

## 许可协议

本项目遵循 Apache 2.0 协议分发。详情请参见 [LICENSE.md](https://raw.githubusercontent.com/onlook-dev/onlook/main/LICENSE.md)。

<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->

[contributors-shield]: https://img.shields.io/github/contributors/onlook-dev/studio.svg?style=for-the-badge
[contributors-url]: https://github.com/onlook-dev/onlook/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/onlook-dev/studio.svg?style=for-the-badge
[forks-url]: https://github.com/onlook-dev/onlook/network/members
[stars-shield]: https://img.shields.io/github/stars/onlook-dev/studio.svg?style=for-the-badge
[stars-url]: https://github.com/onlook-dev/onlook/stargazers
[issues-shield]: https://img.shields.io/github/issues/onlook-dev/studio.svg?style=for-the-badge
[issues-url]: https://github.com/onlook-dev/onlook/issues
[license-shield]: https://img.shields.io/github/license/onlook-dev/studio.svg?style=for-the-badge
[license-url]: https://github.com/onlook-dev/onlook/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/company/onlook-dev
[twitter-shield]: https://img.shields.io/badge/-Twitter-black?logo=x&colorB=555
[twitter-url]: https://x.com/onlookdev
[discord-shield]: https://img.shields.io/badge/-Discord-black?logo=discord&colorB=555
[discord-url]: https://discord.gg/hERDfFZCsH
[React.js]: https://img.shields.io/badge/react-%2320232a.svg?logo=react&logoColor=%2361DAFB
[React-url]: https://reactjs.org/
[TailwindCSS]: https://img.shields.io/badge/tailwindcss-%2338B2AC.svg?logo=tailwind-css&logoColor=white
[Tailwind-url]: https://tailwindcss.com/
[Electron.js]: https://img.shields.io/badge/Electron-191970?logo=Electron&logoColor=white
[Electron-url]: https://www.electronjs.org/
[Vite.js]: https://img.shields.io/badge/vite-%23646CFF.svg?logo=vite&logoColor=white
[Vite-url]: https://vitejs.dev/
[product-screenshot]: https://raw.githubusercontent.com/onlook-dev/onlook/main/assets/brand.png
[weave-shield]: https://img.shields.io/endpoint?url=https%3A%2F%2Fapp.workweave.ai%2Fapi%2Frepository%2Fbadge%2Forg_pWcXBHJo3Li2Te2Y4WkCPA33%2F820087727&cacheSeconds=3600&labelColor=#131313
[weave-url]: https://app.workweave.ai/reports/repository/org_pWcXBHJo3Li2Te2Y4WkCPA33/820087727

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---
# Kelp

一个为热爱 HTML 的人打造的 UI 库，由现代 CSS 和 Web Components 驱动。

**[阅读文档 &rarr;](https://kelpui.com)**

_**注意：** Kelp 目前处于 alpha 阶段开发中。欢迎使用、试验并报告漏洞，但请理解随着时间推移，项目内容可能会发生变化。_



## 快速开始

Kelp 无需任何构建步骤即可使用。

[CDN](https://cdn.jsdelivr.net/npm/kelpui/) 是最快、最简单的入门方式，但如果你愿意，也可以[从 GitHub 下载文件](https://github.com/cferdinandi/kelp)。

```html
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/kelpui@0/css/kelp.css">
```

Kelp 使用语义化版本号。你可以通过 `@1.2.3` 语法从 CDN 获取主版本号、次版本号或补丁版本号。所有可用版本都可以在[发布页面](https://github.com/cferdinandi/kelp/tags)找到。



## 演示

随附的 `index.html` 文件是 Kelp 的厨房水槽演示，包含了每一个功能和组件，集中在一个大型文件中。

在测试阶段，Kelp 没有编译步骤。Web 组件使用 ES imports，并需要本地服务器运行。

你可以使用自己喜欢的服务器，或者运行 `npm run dev` 使用自带的 `http-server`。

```bash
npm install
npm run dev
```

随着 Kelp 接近 v1，将会引入编译步骤，以免去这一步需求。



## 测试

Kelp 使用...

- [Playwright](https://playwright.dev) 进行测试
- [Biome](https://biomejs.dev) 进行代码检查和格式化
- 在部署和 PR 时进行持续集成流程

```bash
# 运行测试
npm run test

# 运行代码检查
npm run lint
```



## 许可证

可在 [Kelp Commons License](https://github.com/cferdinandi/kelp/blob/main/LICENSE.md) 下免费使用。也提供[商业许可证选项](/license/)。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---
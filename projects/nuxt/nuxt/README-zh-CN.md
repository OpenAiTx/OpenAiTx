[![Nuxt 横幅](https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/banner.svg)](https://nuxt.com)

# Nuxt

<p>
  <a href="https://www.npmjs.com/package/nuxt"><img src="https://img.shields.io/npm/v/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="Version"></a>
  <a href="https://www.npmjs.com/package/nuxt"><img src="https://img.shields.io/npm/dm/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="Downloads"></a>
  <a href="https://github.com/nuxt/nuxt/tree/main/LICENSE"><img src="https://img.shields.io/github/license/nuxt/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="License"></a>
  <a href="https://nuxt.com"><img src="https://img.shields.io/badge/Nuxt%20Docs-18181B?logo=nuxt" alt="Website"></a>
  <a href="https://chat.nuxt.dev"><img src="https://img.shields.io/badge/Nuxt%20Discord-18181B?logo=discord" alt="Discord"></a>
  <a href="https://securityscorecards.dev/"><img src="https://api.securityscorecards.dev/projects/github.com/nuxt/nuxt/badge" alt="Nuxt openssf scorecard score"></a>
</p>

Nuxt 是一个免费开源的框架，以直观且可扩展的方式，使用 Vue.js 创建类型安全、高性能且可用于生产的全栈 Web 应用和网站。

它提供了许多功能，使得构建快速、SEO 友好且可扩展的 Web 应用变得简单，包括：
- 服务端渲染、静态站点生成、混合渲染和边缘渲染
- 具有代码分割和预取的自动路由
- 数据获取与状态管理
- SEO 优化和 Meta 标签定义
- 组件、组合式函数和工具的自动导入
- 零配置的 TypeScript 支持
- 通过 server/ 目录实现全栈开发
- 可通过 [200+ 模块](https://nuxt.com/modules) 进行扩展
- 部署到多种 [托管平台](https://nuxt.com/deploy)
- ...[以及更多](https://nuxt.com) 🚀

### 目录

- 🚀 [快速开始](#getting-started)
- 💻 [Vue 开发](#vue-development)
- 📖 [文档](#documentation)
- 🧩 [模块](#modules)
- ❤️  [贡献](#contribute)
- 🏠 [本地开发](#local-development)
- 🛟 [专业支持](#professional-support)
- 🔗 [关注我们](#follow-us)
- ⚖️ [许可证](#license)

---

## <a name="getting-started">🚀 快速开始</a>

使用以下命令创建一个新的入门项目。这将创建一个包含所有必要文件和依赖的入门项目：

```bash
npm create nuxt <my-project>
```

> [!TIP]
> 也可以了解 [nuxt.new](https://nuxt.new)：在 CodeSandbox、StackBlitz 或本地快速打开 Nuxt 入门项目，几秒钟内即可启动。

## <a name="vue-development">💻 Vue 开发</a>

简单、直观且强大，Nuxt 让你以合理的方式编写 Vue 组件。所有重复的任务都已自动化，因此你可以放心地专注于编写全栈 Vue 应用。

一个 `app.vue` 示例：

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

## <a name="documentation">📖 文档</a>

我们强烈推荐你查看 [Nuxt 文档](https://nuxt.com/docs) 来提升技能。这是学习该框架的极佳资源，内容涵盖从入门到高级主题。

## <a name="modules">🧩 模块</a>

探索我们由 Nuxt 团队和社区创建的 [模块列表](https://nuxt.com/modules)，为你的 Nuxt 项目赋能。

## <a name="contribute">❤️ 贡献</a>

我们诚邀你为 Nuxt 做出贡献并帮助我们改进 💚

你可以通过以下方式参与进来：
- **报告 Bug：** 如果你发现任何 Bug 或问题，请参阅 [报告 Bug 指南](https://nuxt.com/docs/community/reporting-bugs) 了解如何提交 Bug 报告。
- **建议：** 有提升 Nuxt 的想法？我们非常欢迎！请查阅 [贡献指南](https://nuxt.com/docs/community/contribution) 分享你的建议。
- **提问：** 有疑问或需要帮助？[获取帮助指南](https://nuxt.com/docs/community/getting-help) 提供了相关资源。

## <a name="local-development">🏠 本地开发</a>

按照文档 [设置你的本地开发环境](https://nuxt.com/docs/community/framework-contribution#setup)，为框架和文档做出贡献。

## <a name="professional-support">🛟 专业支持</a>

- 技术审计与咨询：[Nuxt 专家](https://nuxt.com/enterprise/support)
- 定制开发及更多：[Nuxt 代理合作伙伴](https://nuxt.com/enterprise/agencies)

## <a name="follow-us">🔗 关注我们</a>

<p valign="center">
  <a href="https://go.nuxt.com/discord"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/discord.svg" alt="Discord"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/x"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/twitter.svg" alt="Twitter"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/github"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/github.svg" alt="GitHub"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/bluesky"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/bluesky.svg" alt="Bluesky"></a>
</p>

## <a name="license">⚖️ 许可证</a>

[MIT](https://github.com/nuxt/nuxt/tree/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---
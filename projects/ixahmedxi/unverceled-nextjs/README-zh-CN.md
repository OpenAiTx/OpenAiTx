# Unverceled Next.js

> 一个工具链丰富的 Next.js 15 启动模板，使用 OpenNext 部署到 Cloudflare Workers。

## 包含内容

此模板仅为一个基础的“Hello World”页面，但包含了你可能需要的所有工具，例如：

- Changesets
- Github Actions
- Commitlint & Commitizen
- Lefthook 预提交 & commit-msg 钩子
- Playwright 端到端测试
- Vitest 单元与浏览器组件测试
- Prettier、ESLint、Cspell & MarkdownLint
- Tailwind V4 & Shadcn UI
- 完全重置的 TypeScript TS
- 严格的 TypeScript 配置
- Arktype & T3 Env

## 快速开始

1. 使用此模板创建一个新仓库
2. 将模板克隆到你的机器上
3. 运行 `pnpm install`
4. 编辑 `wrangler.toml` 文件，填入你自己的 KV 命名空间 ID 和 D1 数据库名称及 ID。
5. 部署到 Cloudflare，先运行 `pnpm wrangler login`，然后运行 `pnpm run deploy`

就这么简单！

参考 OpenNext Cloudflare 文档 [https://opennext.js.org/cloudflare](https://opennext.js.org/cloudflare) 来扩展此模板的基础设置。

## 备注

- 你可以使用 [Cloudflare Workers Builds](https://developers.cloudflare.com/workers/ci-cd/builds/) 在主分支有新提交时自动部署应用。
- 你可以使用 Cloudflare Images 作为自定义加载器进行图片优化 [文档](https://opennext.js.org/cloudflare/howtos/image)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---
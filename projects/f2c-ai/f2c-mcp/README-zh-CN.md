# F2C MCP 服务器
![MCP 服务器](https://badge.mcpx.dev?type=server 'MCP Server')
[![smithery badge](https://smithery.ai/badge/@f2c-ai/f2c-mcp)](https://smithery.ai/server/@f2c-ai/f2c-mcp)
[![npm version][npm-version-src]][npm-version-href]
[![npm downloads][npm-downloads-src]][npm-downloads-href]
[![github][github-src]][github-href]
[![node][node-src]][node-href]


[npm-version-src]: https://img.shields.io/npm/v/@f2c/mcp?style=flat&colorA=18181B&colorB=F0DB4F
[npm-version-href]: https://npmjs.com/package/@f2c/mcp
[npm-downloads-src]: https://img.shields.io/npm/dm/@f2c/mcp?style=flat&colorA=18181B&colorB=F0DB4F
[npm-downloads-href]: https://npmjs.com/package/@f2c/mcp
[github-src]: https://img.shields.io/badge/github-@f2c/mcp-blue?style=flat&colorA=18181B&colorB=F0DB4F
[github-href]: https://github.com/f2c-ai/f2c-mcp
[node-src]: https://img.shields.io/node/v/@f2c/mcp?style=flat&colorA=18181B&colorB=F0DB4F
[node-href]: https://nodejs.org/en/about/previous-releases

English | [简体中文](https://raw.githubusercontent.com/f2c-ai/f2c-mcp/main/./README-zh-CN.md)

一个基于 [F2C](https://f2c.yy.com/) 的 Figma 设计转代码的模型上下文协议（MCP）服务器。

<a href="https://glama.ai/mcp/servers/@f2c-ai/f2c-mcp">
  <img width="380" height="200" src="https://glama.ai/mcp/servers/@f2c-ai/f2c-mcp/badge" alt="f2c-mcp-server MCP server" />
</a>

## 功能特性
<img alt="f2c" src="https://raw.githubusercontent.com/f2c-ai/f2c-mcp/main/docs/bannerv3.png" />

- 🎨 像素级 HTML/CSS：F2C 精准地将 Figma 设计稿转化为像素级还原的 HTML/CSS。
- ⚛️ 多框架支持：F2C 可生成 React、CSS Modules 和 Tailwind CSS 代码，加速开发流程。
- 🧠 Figma 设计上下文：F2C 集成设计上下文，确保与 Cursor 等 AI 工具的兼容性。
- 🔗 Figma 文件 URL 解析：F2C 通过 Figma 链接转换设计节点，优化工作流程。
- 🖼️ 远程图片本地化：F2C 自动下载 Figma 图片到本地资源，提高效率。

## 工作原理
1. 在支持 MCP 的 IDE 中[配置服务器](https://raw.githubusercontent.com/f2c-ai/f2c-mcp/main/docs/en/GettingStarted.md)（如 Cursor、Trae）。
2. 在 IDE 中打开你的聊天窗口（如 Cursor 的智能体模式）。
3. 粘贴 Figma 节点的链接（在 Figma 图层面板中右键任意节点即可复制）。
4. 在聊天中输入你的需求，如获取节点数据、下载图片、转换为代码等。

## 配置与开发

详见[配置与开发](https://raw.githubusercontent.com/f2c-ai/f2c-mcp/main/docs/en/GettingStarted.md)

## 常见问题
详见[常见问题](https://raw.githubusercontent.com/f2c-ai/f2c-mcp/main/docs/en/FAQ.md)

## 致谢

感谢以下项目：

+ [Framelink Figma MCP Server](https://github.com/GLips/Figma-Context-MCP) 通过本模型上下文协议服务器，为 Cursor 及其他 AI 编码工具提供 Figma 文件访问能力。  
+ [Cursor Talk to Figma MCP](https://github.com/sonnylazuardi/cursor-talk-to-figma-mcp) 允许 Cursor 与 Figma 通信，实现设计稿的读取与编程式修改。
+ [Figma MCP Server](https://github.com/MatthewDailey/figma-mcp) 该服务器通过 ModelContextProtocol 提供 Figma 设计稿的查看、评论和分析工具。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-07

---
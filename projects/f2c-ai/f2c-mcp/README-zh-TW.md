# F2C MCP 伺服器
![MCP Server](https://badge.mcpx.dev?type=server 'MCP Server')
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

English | [簡體中文](https://raw.githubusercontent.com/f2c-ai/f2c-mcp/main/./README-zh-CN.md)

一個用於 Figma 設計轉代碼的 Model Context Protocol 伺服器，基於 [F2C](https://f2c.yy.com/)。

<a href="https://glama.ai/mcp/servers/@f2c-ai/f2c-mcp">
  <img width="380" height="200" src="https://glama.ai/mcp/servers/@f2c-ai/f2c-mcp/badge" alt="f2c-mcp-server MCP server" />
</a>

## 功能特色
<img alt="f2c" src="https://raw.githubusercontent.com/f2c-ai/f2c-mcp/main/docs/bannerv3.png" />

- 🎨 像素級 HTML/CSS：F2C 精準地將 Figma 設計轉換為像素級 HTML/CSS。
- ⚛️ 多框架支援：F2C 生成 React、CSS Modules 及 Tailwind CSS 代碼，加速開發流程。
- 🧠 Figma 設計上下文：F2C 整合設計上下文，確保與 AI 工具（如 Cursor）的相容性。
- 🔗 Figma 檔案 URL 解析：F2C 可通過 Figma URL 轉換設計節點，簡化工作流程。
- 🖼️ 遠端圖片本地化：F2C 自動下載 Figma 圖片到本地資產資料夾，提高效率。

## 工作原理
1. 在支援 MCP 的 IDE（如 Cursor、Trae）中[配置伺服器](https://raw.githubusercontent.com/f2c-ai/f2c-mcp/main/docs/en/GettingStarted.md)。
2. 在 IDE 中開啟你的聊天（例如 Cursor 的代理模式）。
3. 貼上 Figma 節點的連結（於 Figma 圖層面板右鍵任一節點即可複製）。
4. 在聊天中輸入你的需求，例如獲取節點資料、下載圖片、轉換為代碼等。

## 配置與開發

請參閱[配置與開發](https://raw.githubusercontent.com/f2c-ai/f2c-mcp/main/docs/en/GettingStarted.md)

## 常見問題
請參閱[常見問題](https://raw.githubusercontent.com/f2c-ai/f2c-mcp/main/docs/en/FAQ.md)

## 鳴謝

感謝：

+ [Framelink Figma MCP Server](https://github.com/GLips/Figma-Context-MCP) 這個 Model Context Protocol 伺服器讓 Cursor 及其他 AI 編碼工具能存取你的 Figma 檔案。
+ [Cursor Talk to Figma MCP](https://github.com/sonnylazuardi/cursor-talk-to-figma-mcp) 允許 Cursor 與 Figma 通訊，實現設計讀取與程式化修改。
+ [Figma MCP Server](https://github.com/MatthewDailey/figma-mcp) 此伺服器透過 ModelContextProtocol 提供檢視、評論及分析 Figma 設計的工具。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-07

---
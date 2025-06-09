[![Nuxt 橫幅](https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/banner.svg)](https://nuxt.com)

# Nuxt

<p>
  <a href="https://www.npmjs.com/package/nuxt"><img src="https://img.shields.io/npm/v/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="Version"></a>
  <a href="https://www.npmjs.com/package/nuxt"><img src="https://img.shields.io/npm/dm/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="Downloads"></a>
  <a href="https://github.com/nuxt/nuxt/tree/main/LICENSE"><img src="https://img.shields.io/github/license/nuxt/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="License"></a>
  <a href="https://nuxt.com"><img src="https://img.shields.io/badge/Nuxt%20Docs-18181B?logo=nuxt" alt="Website"></a>
  <a href="https://chat.nuxt.dev"><img src="https://img.shields.io/badge/Nuxt%20Discord-18181B?logo=discord" alt="Discord"></a>
  <a href="https://securityscorecards.dev/"><img src="https://api.securityscorecards.dev/projects/github.com/nuxt/nuxt/badge" alt="Nuxt openssf scorecard score"></a>
</p>

Nuxt 是一個免費且開源的框架，提供直觀且可擴展的方式，利用 Vue.js 建立型別安全、高效能、可用於生產環境的全端網頁應用程式與網站。

它提供多項特性，使構建快速、SEO 友善且可擴展的網頁應用變得容易，包括：
- 伺服器端渲染、靜態網站生成、混合渲染與 Edge-Side Rendering
- 自動路由，支援程式碼分割與預取
- 資料取得與狀態管理
- SEO 最佳化與 Meta 標籤定義
- 組件、composables 及工具自動導入
- TypeScript 零設定支援
- 透過 server/ 目錄實現全端開發
- 可擴充的 [200+ 模組](https://nuxt.com/modules)
- 可部署至多種 [主機平台](https://nuxt.com/deploy)
- ...[還有更多功能](https://nuxt.com) 🚀

### 目錄

- 🚀 [快速開始](#getting-started)
- 💻 [Vue 開發](#vue-development)
- 📖 [文件](#documentation)
- 🧩 [模組](#modules)
- ❤️  [貢獻](#contribute)
- 🏠 [本地開發](#local-development)
- 🛟 [專業支援](#professional-support)
- 🔗 [追蹤我們](#follow-us)
- ⚖️ [授權](#license)

---

## <a name="getting-started">🚀 快速開始</a>

使用以下指令建立新的起始專案。這會建立一個包含所有必要檔案與依賴的起始專案：

```bash
npm create nuxt <my-project>
```

> [!TIP]
> 也可以嘗試 [nuxt.new](https://nuxt.new)：在 CodeSandbox、StackBlitz 或本地快速開啟 Nuxt 起始專案，幾秒鐘即可開始體驗。

## <a name="vue-development">💻 Vue 開發</a>

簡單、直觀且強大，Nuxt 讓你以合乎邏輯的方式編寫 Vue 元件。所有重複性工作都已自動化，讓你能專注自信地開發全端 Vue 應用。

`app.vue` 範例：

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

## <a name="documentation">📖 文件</a>

我們強烈建議你參閱 [Nuxt 文件](https://nuxt.com/docs) 以提升你的能力。這是深入學習框架的絕佳資源，涵蓋從入門到進階主題。

## <a name="modules">🧩 模組</a>

探索我們的 [模組清單](https://nuxt.com/modules)，由 Nuxt 團隊與社群共同打造，助你強化 Nuxt 專案。

## <a name="contribute">❤️ 貢獻</a>

我們誠摯邀請你參與貢獻，共同讓 Nuxt 變得更好 💚

你可以參與的方式有：
- **回報錯誤：** 如果你遇到任何錯誤或問題，請參考 [回報錯誤指南](https://nuxt.com/docs/community/reporting-bugs) 了解如何提交錯誤報告。
- **建議意見：** 有想法能讓 Nuxt 更好嗎？我們很樂意聆聽！請參閱 [貢獻指南](https://nuxt.com/docs/community/contribution) 分享你的建議。
- **提問協助：** 如有疑問或需要幫助，[求助指南](https://nuxt.com/docs/community/getting-help) 提供多種資源協助你。

## <a name="local-development">🏠 本地開發</a>

請依據文件 [設置本地開發環境](https://nuxt.com/docs/community/framework-contribution#setup)，以利參與框架及文件的貢獻。

## <a name="professional-support">🛟 專業支援</a>

- 技術審查與諮詢：[Nuxt 專家](https://nuxt.com/enterprise/support)
- 客製開發與更多：[Nuxt 代理合作夥伴](https://nuxt.com/enterprise/agencies)

## <a name="follow-us">🔗 追蹤我們</a>

<p valign="center">
  <a href="https://go.nuxt.com/discord"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/discord.svg" alt="Discord"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/x"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/twitter.svg" alt="Twitter"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/github"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/github.svg" alt="GitHub"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/bluesky"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/bluesky.svg" alt="Bluesky"></a>
</p>

## <a name="license">⚖️ 授權</a>

[MIT](https://github.com/nuxt/nuxt/tree/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---
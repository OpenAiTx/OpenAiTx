# Kelp

一個專為熱愛 HTML 的人打造的 UI 函式庫，由現代 CSS 和 Web Components 驅動。

**[閱讀文件 &rarr;](https://kelpui.com)**

_**注意：** Kelp 目前處於 alpha 開發階段。歡迎自由使用、實驗和回報錯誤，但請理解未來內容可能會隨時變動。_



## 快速開始

Kelp 無需任何編譯步驟即可運作。

[CDN](https://cdn.jsdelivr.net/npm/kelpui/) 是最快、最簡單的入門方式，但如果你願意，也可以[從 GitHub 下載檔案](https://github.com/cferdinandi/kelp)。

```html
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/kelpui@0/css/kelp.css">
```

Kelp 採用語意化版本控制。你可以使用 CDN 的 `@1.2.3` 語法來抓取主要、次要或修補版本。所有可用版本可在 [releases](https://github.com/cferdinandi/kelp/tags) 查詢。



## 範例展示

內建的 `index.html` 檔案是 Kelp 的總覽範例。它在一個巨大的檔案中包含了每一個功能和元件。

在測試階段，Kelp 沒有編譯步驟。Web 元件使用 ES imports，並需要本地伺服器來執行。

你可以使用偏好的伺服器，或是執行內建的 `http-server`，只需執行 `npm run dev`。

```bash
npm install
npm run dev
```

隨著 Kelp 接近 v1，將會加入編譯步驟，屆時這些步驟就不再需要了。



## 測試

Kelp 使用...

- [Playwright](https://playwright.dev) 進行測試
- [Biome](https://biomejs.dev) 進行程式碼檢查與格式化
- 在部署和 PR 時有持續整合流程

```bash
# 執行測試
npm run test

# 執行程式碼檢查
npm run lint
```



## 授權

可依 [Kelp Commons 授權條款](https://github.com/cferdinandi/kelp/blob/main/LICENSE.md) 免費使用。同時也有[商業授權方案](/license/)可選。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---
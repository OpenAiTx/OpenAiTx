# Gantt
<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>
## 安裝

```
yarn install
```

### 執行

```
yarn run serve
```

### 說明

```
基於 vue 開發的甘特圖展示，可用於團隊協作、任務劃分等敏捷場景

支援分組
支援拖曳
支援拉伸
支援百分比
支援時間跨度：天、週、月
目前僅實作一級分組，為避免未來有二級或多級分組需求，上一次提交時已重構部分代碼，支援多級分組，但當前版本尚未開發

優勢：在拖曳、拉伸、修改進度等操作時，資料不會即時更新，而是在操作後才更新，減少效能損耗
      在編輯、刪除、新增時，並非整體遞迴修改實例，而是僅針對修改部分進行增刪改

正在準備重新組織，為元件化做準備，目前如需於專案中使用僅需引入本專案中的 `gant.vue` 即可
批量資料匯入匯出方法已撰寫完成，可直接複製使用！~
```

### 更新說明

- 支援編輯
- 支援刪除
- 修復無法垂直滾動的 bug（同時增加雙向同步滾動） [#4](https://github.com/GGBeng1/Gantt/issues/4)
- 修復 elementUI 引起的 bug
- 關於時間跨度的問題 [#5](https://github.com/GGBeng1/Gantt/issues/5)
- 目前無法通過更改跨度配置來實現其他跨度，例如增加小時等。因為初始化時有些配置是固定的，後續會更改並作為 API 釋出

### 查看範例

參見 [demo](https://ggbeng1.github.io/Gantt/#/)

### 展示圖

<img src="https://raw.githubusercontent.com/GGBeng1/Gantt/master/public/demo.png" alt="">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-01

---
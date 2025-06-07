<p align="center">
  <img width="320" src="https://wpimg.wallstcn.com/ecc53a42-d79b-42e2-8852-5126b810a4c8.svg">
</p>

<p align="center">
  <a href="https://github.com/vuejs/vue">
    <img src="https://img.shields.io/badge/vue-2.6.10-brightgreen.svg" alt="vue">
  </a>
  <a href="https://github.com/ElemeFE/element">
    <img src="https://img.shields.io/badge/element--ui-2.7.0-brightgreen.svg" alt="element-ui">
  </a>
  <a href="https://travis-ci.org/PanJiaChen/vue-element-admin" rel="nofollow">
    <img src="https://travis-ci.org/PanJiaChen/vue-element-admin.svg?branch=master" alt="Build Status">
  </a>
  <a href="https://github.com/PanJiaChen/vue-element-admin/blob/master/LICENSE">
    <img src="https://img.shields.io/github/license/mashape/apistatus.svg" alt="license">
  </a>
  <a href="https://github.com/PanJiaChen/vue-element-admin/releases">
    <img src="https://img.shields.io/github/release/PanJiaChen/vue-element-admin.svg" alt="GitHub release">
  </a>
  <a href="https://gitter.im/vue-element-admin/discuss">
    <img src="https://badges.gitter.im/Join%20Chat.svg" alt="gitter">
  </a>
  <a href="https://panjiachen.github.io/vue-element-admin-site/donate">
    <img src="https://img.shields.io/badge/%24-donate-ff69b4.svg" alt="donate">
  </a>
</p>

English | [简体中文](./README.zh-CN.md) | [日本語](./README.ja.md) | [Spanish](./README.es.md)

<!-- <p align="center">
  <b>SPONSORED BY</b>
</p>
<table align="center" cellspacing="0" cellpadding="0">
  <tbody>
    <tr>
      <td align="center" valign="middle">
       <a href="" title="" target="_blank" style="padding-right: 20px;">
        <img height="200px" style="padding-right: 20px;" src="" title="variantForm">
        </a>
      </td>
    </tr>
  </tbody> 
</table>-->

## 介紹

[vue-element-admin](https://panjiachen.github.io/vue-element-admin) 是一個生產級的後台前端解決方案，基於 [vue](https://github.com/vuejs/vue) 並使用 UI 工具集 [element-ui](https://github.com/ElemeFE/element)。

[vue-element-admin](https://panjiachen.github.io/vue-element-admin) 基於最新的 vue 開發棧，內建 i18n 解決方案，提供企業級應用典型範本和眾多強大功能，助你快速構建大型複雜的單頁應用（SPA）。不論你的需求為何，本專案都能助你一臂之力。

- [線上預覽](https://panjiachen.github.io/vue-element-admin)

- [文件說明](https://panjiachen.github.io/vue-element-admin-site/)

- [Gitter 討論區](https://gitter.im/vue-element-admin/discuss)

- [捐贈](https://panjiachen.github.io/vue-element-admin-site/donate/)

- [Wiki](https://github.com/PanJiaChen/vue-element-admin/wiki)

- [Gitee](https://panjiachen.gitee.io/vue-element-admin/) 供中國大陸用戶線上預覽

- 模板推薦使用：[vue-admin-template](https://github.com/PanJiaChen/vue-admin-template)
- 桌面端方案：[electron-vue-admin](https://github.com/PanJiaChen/electron-vue-admin)
- Typescript 版：[vue-typescript-admin-template](https://github.com/Armour/vue-typescript-admin-template) (致謝: [@Armour](https://github.com/Armour))
- [優質專案彙總](https://github.com/PanJiaChen/vue-element-admin/issues/2312)

**`v4.1.0+` 版本後，預設 master 分支不再支援 i18n，請使用 [i18n 分支](https://github.com/PanJiaChen/vue-element-admin/tree/i18n)，該分支會與 master 同步更新**

**目前版本為 `v4.0+`，基於 `vue-cli` 構建。如發現問題，請提交 [issue](https://github.com/PanJiaChen/vue-element-admin/issues/new)。如需舊版本，可切換分支至 [tag/3.11.0](https://github.com/PanJiaChen/vue-element-admin/tree/tag/3.11.0)，該版本不依賴 `vue-cli`**

**本專案不支援低版本瀏覽器（如 IE），如有需求請自行加入 polyfill。**

## 前置準備

你需要在本地安裝 [node](https://nodejs.org/) 和 [git](https://git-scm.com/)。本專案基於 [ES2015+](https://es6.ruanyifeng.com/)、[vue](https://cn.vuejs.org/index.html)、[vuex](https://vuex.vuejs.org/zh-cn/)、[vue-router](https://router.vuejs.org/zh-cn/)、[vue-cli](https://github.com/vuejs/vue-cli)、[axios](https://github.com/axios/axios) 與 [element-ui](https://github.com/ElemeFE/element) 開發，所有請求資料皆以 [Mock.js](https://github.com/nuysoft/Mock) 模擬。建議提前學習這些相關知識，將有助於專案使用。

[![Edit on CodeSandbox](https://codesandbox.io/static/img/play-codesandbox.svg)](https://codesandbox.io/s/github/PanJiaChen/vue-element-admin/tree/CodeSandbox)

<p align="center">
  <img width="900" src="https://wpimg.wallstcn.com/a5894c1b-f6af-456e-82df-1151da0839bf.png">
</p>

## 贊助商

成為贊助商，可在我們的 GitHub README 上展示你的標誌並鏈接到你的网站。[[成為贊助商]](https://www.patreon.com/panjiachen)

### Akveo
<a href="https://store.akveo.com/products/vue-java-admin-dashboard-spring?utm_campaign=akveo_store-Vue-Vue_demo%2Fgithub&utm_source=vue_admin&utm_medium=referral&utm_content=github_banner"><img width="500px" src="https://raw.githubusercontent.com/PanJiaChen/vue-element-admin-site/master/docs/.vuepress/public/images/vue-java-banner.png" /></a><p>為 Vue 後台獲取 Java 後端，現用優惠碼 SWB0RAZPZR1M 可享 39 美元再 8 折優惠。
</p>

### Flatlogic

<a href="https://flatlogic.com/admin-dashboards?from=vue-element-admin"><img width="150px" src="https://wpimg.wallstcn.com/9c0b719b-5551-4c1e-b776-63994632d94a.png" /></a><p>使用 Vue、React 和 Angular 製作的後台管理儀表板範本。</p>

## 功能特性

```
- 登入 / 登出

- 權限驗證
  - 頁面權限
  - 指令權限
  - 權限配置頁
  - 雙重驗證登入

- 多環境構建
  - 開發 (dev)
  - sit
  - 預發測試 (stage)
  - 生產 (prod)

- 全局功能
  - 國際化 I18n
  - 多主題動態切換
  - 動態側邊欄（支援多級路由）
  - 動態麵包屑
  - 標籤頁（Tab 支援右鍵操作）
  - SVG Sprite
  - Mock 數據
  - 全屏 Screenfull
  - 響應式側邊欄

- 編輯器
  - 富文本編輯器
  - Markdown 編輯器
  - JSON 編輯器

- Excel
  - 匯出 Excel
  - 上傳 Excel
  - Excel 可視化
  - 匯出 zip

- 表格
  - 動態表格
  - 拖拽表格
  - 行內編輯表格

- 錯誤頁
  - 401
  - 404

- 常用元件
  - 頭像上傳
  - 返回頂部
  - 拖拽 Dialog
  - 拖拽選擇
  - 拖拽看板
  - 拖拽列表
  - SplitPane
  - Dropzone
  - 粘性 Sticky
  - CountTo 數字動畫

- 高級範例
- 錯誤日誌
- 儀表板
- 新手引導
- ECharts
- 剪貼板
- Markdown 轉 HTML
```

## 快速開始

```bash
# 克隆專案
git clone https://github.com/PanJiaChen/vue-element-admin.git

# 進入專案目錄
cd vue-element-admin

# 安裝依賴
npm install

# 啟動開發環境
npm run dev
```

啟動後會自動打開 http://localhost:9527

## 構建

```bash
# 測試環境構建
npm run build:stage

# 生產環境構建
npm run build:prod
```

## 進階操作

```bash
# 預覽發佈環境效果
npm run preview

# 預覽發佈環境效果 + 靜態資源分析
npm run preview -- --report

# 代碼格式檢查
npm run lint

# 代碼格式檢查並自動修復
npm run lint -- --fix
```

更多資訊請參考[文件說明](https://panjiachen.github.io/vue-element-admin-site/guide/essentials/deploy.html)

## 更新日誌

每次發佈的詳細變更記錄在 [發佈說明](https://github.com/PanJiaChen/vue-element-admin/releases)。

## 線上示範

[線上預覽](https://panjiachen.github.io/vue-element-admin)

## 捐贈支持

如果你覺得本專案對你有幫助，可以請作者喝杯果汁 :tropical_drink:

![donate](https://wpimg.wallstcn.com/bd273f0d-83a0-4ef2-92e1-9ac8ed3746b9.png)

[Paypal 捐贈](https://www.paypal.me/panfree23)

[Buy me a coffee](https://www.buymeacoffee.com/Pan)

## 瀏覽器支援

現代瀏覽器和 IE 10+。

| [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/edge/edge_48x48.png" alt="IE / Edge" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>IE / Edge | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/firefox/firefox_48x48.png" alt="Firefox" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>Firefox | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/chrome/chrome_48x48.png" alt="Chrome" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>Chrome | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/safari/safari_48x48.png" alt="Safari" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>Safari |
| --------- | --------- | --------- | --------- |
| IE10, IE11, Edge | 最新兩個版本 | 最新兩個版本 | 最新兩個版本 |

## 授權協議

[MIT](https://github.com/PanJiaChen/vue-element-admin/blob/master/LICENSE)

Copyright (c) 2017-present PanJiaChen

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---
# Gantt

## 安裝

```
yarn install
```

### 運行

```
yarn run serve
```

### 說明

```
基於vue開發的甘特圖展示，可以用於團隊協作、任務劃分等敏捷場景

支持分組
支持拖拽
支持拉伸
支持百分比
支持時間跨度：天，週，月
目前只寫了一級分組，為了避免未來二級或者多級分組需求，在上一次提交中重構了部分代碼，支持多級分組，但是當前版本尚未開發

優勢：在拖拽、拉伸、修改進度等操作時，對數據並沒有即時更新，而是在操作後更新，減少了效能損耗
      在編輯、刪除、添加時，並沒有整體遞迴修改實例，而是只對修改部分增刪改

正在準備重新組織，為元件化做準備，目前想要在專案中使用只需要引入該專案中的`gant.vue`即可
批量數據匯入匯出方法已經寫好，直接copy即可！~
```

### 更新說明

- 支持編輯
- 支持刪除
- 修復無法垂直滾動的 bug（同時增加雙向同時滾動） [#4](https://github.com/GGBeng1/Gantt/issues/4)
- 修復 elementUI 引起的 bug
- 關於時間跨度的問題 [#5](https://github.com/GGBeng1/Gantt/issues/5)
- 目前無法通過更改跨度配置來實現其他跨度，例如增加小時等。因為在初始化時一些配置直接固定，後續會更改作為 api 放出

### 查看範例

See [demo](https://ggbeng1.github.io/Gantt/#/)

### 展示圖

<img src="https://raw.githubusercontent.com/GGBeng1/Gantt/master/public/demo.png" alt="">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---
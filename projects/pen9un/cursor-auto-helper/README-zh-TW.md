<h1 align="center">歡迎使用&nbsp;&nbsp;Cursor Auto Helper 👋</h1>
<p>
  <img alt="Version" src="https://img.shields.io/badge/version-2.3.0-blue.svg?cacheSeconds=2592000" />
  <img alt="License: MIT" src="https://img.shields.io/badge/License-MIT-yellow.svg" />
  <img alt="Cursor Version" src="https://img.shields.io/badge/Cursor-0.48.x%20%E8%87%B3%201.0.0-blue.svg" />
</p>

> Cursor自動繼續工具，Cursor自動重試，Cursor自動確認，Cursor用量統計，Cursor增強工具，Cursor輔助工具，Cursor自動化工具，Cursor主題設定，Cursor Auto Continue Tool，Cursor Auto Retry Tool，Cursor Auto Confirm Tool，Cursor Usage Statistics Tool，Cursor Efficiency Tool，Cursor Automation Tool，Cursor Theme Settings，Cursor after 25 tool calls，Cursor Tool Call Limit🔧🤖🚀
> 

## 🏠 [首頁](https://github.com/pen9un/cursor-auto-helper)

Cursor Auto Helper 是一款專為 Cursor IDE 打造的自動化增強工具，能夠即時顯示用量、自動處理 25 次對話限制、網路連線失敗、確認提示等場景，讓你的開發體驗更加流暢。

**影片演示：** [Cursor Auto Helper 演示視頻](https://www.bilibili.com/video/BV1cajKzCEzv/)

提示詞品質高，專案需求規劃好，這個程式就可以讓 Cursor 在無需人工干預的情況下自動完成一個專案。

> 🔒 **版本相容**：目前在 Cursor 0.49.6 、Cursor 1.0.0 版本上開發測試通過，理論相容 Cursor 0.48.x - 1.0.0 版本。

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper.png" alt="cursor-auto-helper" />

## 📖更新日誌

- 2025-06-01 發佈 v2.3 版本，增加 Cursor 主題設定功能，優化程式碼注入穩定性，修正用量顯示與官方格式一致
- 2025-05-21 發佈 v2.1 版本，重構架構，支援多平台，增加即時顯示用量功能等
- 2025-04-25 完成 v1.0 版本，自動處理 25 次對話限制、網路連線失敗、確認提示等場景
- 2025-04-20 專案啟動

## 🌟 Cursor Auto Helper 最佳實踐

註：以下文件可由 Cursor 等 AI 輔助生成，需人工核驗調整。

**STEP 1：** 詳細專案系統需求設計（需求梳理越清楚，專案品質會越高），撰寫高品質專案開發提示詞 **SYSTEM.md**

**STEP 2：** 根據 **SYSTEM.md** 輸出高品質系統開發設計方案文件 **DESIGN.md**

**STEP 3：** 根據 **SYSTEM.md** 和 **DESIGN.md** 輸出高品質開發計劃文件 **TODOLIST.md**

**STEP 4：** 使用 **Cursor Auto Helper** ，指定 **SYSTEM.md**、**DESIGN.md**、**TODOLIST.md** ，使用自動繼續回饋提示詞，讓 Cursor 持續自動化依照開發計劃完成專案開發，直到完成

**Cursor Auto Helper 自動繼續回饋提示詞：**

```
@SYSTEM.md @DESIGN.md @TODOLIST.md 請嚴格按照TODOLIST開發計劃進行後續功能開發，並即時更新記錄TODOLIST開發計劃，每個工作完成後需要詢問我"是否繼續"，直到專案完成時返回"專案已開發完畢"
```

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/guide.png" alt="guide" />

## 🚀 使用說明

歡迎 Star 支持，如有問題請提 [Issues](https://github.com/pen9un/cursor-auto-helper/issues)。

### 📝 配置檔說明

配置檔 `config.ini` **用於自訂自動化行為**（可依需求進行設定和測試），支援以下配置項：

#### 基礎配置
```ini
[common]
log_enable = true     # 是否啟用日誌，如不想記錄日誌可改為false

[cursor]
path = C:\Path\To\Cursor.exe  # Cursor IDE安裝路徑，程式會自動尋找Cursor路徑，找不到時會有提示，修改此項即可
```

#### 自動動作配置
每個自動動作以 `action名稱.` 為前綴，支援以下字段：

- `type`：動作類型
  - `click`：點擊按鈕
  - `input_and_submit`：輸入並提交

- `text` / `text_list`：匹配的文字內容
  - `text`：單一字串
  - `text_list`：| 分隔的多個字串，頁面內容包含任一項即觸發

- `button_selector`：需點擊的按鈕CSS選擇器（僅`click`類型需要）
- `button_text`：按鈕文字內容（可選，進一步限定按鈕）
- `input_box_selector`：輸入框的CSS選擇器（`input_and_submit`類型需要）
- `input_content`：需自動輸入的內容
- `submit_btn_selector`：提交按鈕的CSS選擇器
- `delay`：動作執行前的延遲（毫秒），可用於等待頁面渲染

##### 配置範例
```ini
[auto_actions]
# 連線失敗自動重試
action_retry.type = "click"
action_retry.text = "Connection failed. If the problem persists, please check your internet connection or VPN"
action_retry.button_selector = "div.anysphere-secondary-button"
action_retry.button_text = "Try again"
action_retry.delay = 3000

# after 25 tool calls
action_continue.type = "input_and_submit"
action_continue.text_list = "agent after 25 tool calls"
action_continue.input_box_selector = ".full-input-box.undefined"
action_continue.input_content = "請繼續"
action_continue.submit_btn_selector = ".codicon-arrow-up-two"
```
action_continue.delay = 1000

# 自動確認繼續
action_need_continue.type = "input_and_submit"
action_need_continue.text_list = "是否需要|是否繼續|需要我|請告訴我"
action_need_continue.input_box_selector = ".full-input-box.undefined"
action_need_continue.input_content = "請繼續後續開發，並即時記錄更新開發進度"
action_need_continue.submit_btn_selector = ".codicon-arrow-up-two"
action_need_continue.delay = 1000
```

> **注意：**
> 1. 每個 action 的名稱（如 `action_retry`、`action_continue`）可自定義，但同一 action 的所有欄位前綴需一致
> 2. CSS 選擇器建議用瀏覽器開發者工具定位，確保準確
> 3. 配置文件修改後需要重啟程式才能生效

## 🎯 應用場景

### 💼 長對話開發
- 自動處理 25 次對話限制，支援連續長對話開發，自動繼續對話流程，提升開發效率。

### 👥 網路不穩定
- 自動偵測網路異常，智慧重試連接，自動恢復對話，保證開發連續性。

### 🏢 確認場景
- 智慧辨識確認提示場景，自動處理確認提示，減少人工干預。

### 📚 用量監控
- 即時統計對話次數，監控 Cursor 用量，記錄使用數據，優化使用效率。

終端用量顯示：

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper-1.png" alt="cursor-auto-helper-1" />

Cursor IDE 用量顯示：

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper-logs.png" alt="cursor-auto-helper-logs" />

## 🌟功能說明

### 🤖自動繼續長對話
- 自動處理 Cursor 25 次對話限制，支援多輪連續對話。

### 🎨 自動重試連接
- 自動偵測網路連接失敗，智慧重試，即時監控連接狀態。

### 📱 自動確認提示
- 智慧辨識多種確認提示場景，自動處理確認彈窗。
- 支援自定義確認內容和回應，減少人工干預。
- 靈活規則配置，適配多樣化開發流程。

### 🛍️ 用量統計
- 即時統計對話次數和用量，自動記錄數據。
- 用量數據可視化展示，便於分析和優化。
- 支援終端彩色日誌顯示、IDE 用量面板，提升可用性。

### 💡 日誌系統
- 多級別日誌（DEBUG/INFO/SUCCESS/WARNING/ERROR/CRITICAL），終端彩色輸出。
- 日誌檔案按日期自動生成，支援檔案記錄和拖曳顯示面板。
- 即時面板便於開發者監控和回溯。

### 🔒 版本相容與效能優化
- 基於 Cursor 0.49.6 開發，核心功能完整測試。
- 針對特定版本優化，持續跟進 Cursor 版本更新。
- 穩定性強，相容性好，適合生產環境使用。

## 🔮效果展示

### 🤖 自動繼續對話

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/auto-continue.png" alt="auto-continue" />

### 🚀 Cursor自動完成程式展示

從項目需求到完整實現，全程無需人工干預：

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/auto-complete.png" alt="auto-complete" />

## 🤝作者

👤 **pen9un**

* 網站: https://github.com/pen9un/
* Github: [@pen9un](https://github.com/pen9un)

## ❤️支持

如果覺得此專案有用，請點一個免費的小 ⭐️⭐️

## ✨Star History

[![Star History Chart](https://api.star-history.com/svg?repos=pen9un/cursor-auto-helper&type=Date)](https://star-history.com/#pen9un/cursor-auto-helper&Date)

## 💹 訪問量統計

![Visitor Count](https://profile-counter.glitch.me/pen9un/count.svg) 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---
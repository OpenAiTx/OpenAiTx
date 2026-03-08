
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# DIY 智慧家庭行事曆（Skylight 仿製版）

![Sklylight calendar](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/main_view.jpeg)
![DIY Skylight](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/sky2.png)

## 📖 介紹

最近我太太在社群媒體上頻繁看到智慧家庭行事曆（Skylight、Cozyla、Hearth）的廣告，甚至準備花超過 300 美元購買一台。在給她同意購買之前，我提出讓我先研究這些產品的機會。
我發現大多數產品雖然功能相似，但價格差異很大。最重要的是，我沒有看到任何我無法在 **Home Assistant** 中實現的突出功能。

**目標：** 一個通過老婆認可（WAF）、適合放在檯面上的觸控式行事曆，可深度整合至我們的智慧家庭，且無需每月付費。

## 💡 為什麼選擇自製？

選擇用 Home Assistant 自己動手做，有幾個優點勝過購買 Skylight/Hearth 顯示器：

* **無需月費：** 避免為「高級」功能訂閱服務。
* **無縫整合：** 可與我們的燈光、家務（Grocy）和在家感測器互通。
* **舊硬體再利用：** 改裝了一台 Mini PC 和一台標準顯示器。
* **隱私性：** 不受廠商綁定，也不用擔心公司倒閉。

## 🛠 硬體選擇

目前設計是讓儀表板可在任何 HD（1920x1080）顯示器上顯示。

我的需求是它「看起來像」skylight、要有觸控、適合放在檯面上，且能隨時搬動。因此我選用了下述硬體。不過你的情況可能不同，或許需要調整，例如你想放在平板上或其他設備。

我當初選擇的硬體，除了上述原因外，也希望將來可利用網路攝影機、喇叭和麥克風擴充功能。現在回想起來，如果重來一次我會有所不同，因為我還沒時間實現這些額外硬體構想。

* **顯示器：** [HP Engage 15吋觸控螢幕](https://computers.woot.com/offers/hp-engage-16t-fhd-monitor)。我選它而不是一般攜帶型螢幕，是因為它內建 **喇叭、網路攝影機和麥克風**，方便未來擴充語音控制或視訊通話。
* **電腦：** 一台舊 Mini PC（NUC/Tiny PC）以 Kiosk 模式運行 Windows/Linux，或 Raspberry Pi 4。~~

## ✨ 功能

* **全家/個人檢視：** 可切換顯示特定家庭成員的行事曆。
* **雙向同步：** 可在螢幕或手機（Google 行事曆）編輯事件。
* **「新增事件」彈窗：** 自訂 UI，直接從螢幕新增事件到指定行事曆。
* **天氣與日期：** 美觀、一目瞭然的抬頭區。
* **響應式設計：** 會根據螢幕寬度自動調整顯示天數（手機與桌面版）。

---

## ⚙️ 安裝指南

*注意：本教學使用 **YAML 套件**，自動為你建立所有必要的輔助工具、腳本和變數。你不需手動建立它們。*




### 1. 先決條件（HACS）

您必須已安裝 [HACS](https://hacs.xyz/)。請安裝以下 **前端** 整合：

* `week-planner-card`
* `bubble-card`
* `config-template-card`
* `card-mod`
* `better-moment-card`
* `weather-card`
* `browser_mod`（彈出視窗功能必需）
* `layout-card`（Sections 檢視必需）
* `button-card`（新增事件彈出視窗必需）

*注意：在設定 → 裝置與服務中，請確保 Browser Mod 作為整合（磁磚）出現，而不僅僅是在 HACS 下方。
如果沒有出現，請點選新增整合 → Browser Mod 並完成流程，然後重新啟動 HA。
透過 HACS 安裝僅會下載檔案；您必須新增整合，才能讓 HA 註冊其動作／實體。

### 2. 後端（大腦）

1. 在 Home Assistant 中開啟您的 `configuration.yaml` 檔案。
2. 請確認您已在 `homeassistant:` 下方新增此行，以啟用套件：

   ```yaml
   homeassistant:
     packages: !include_dir_named packages
   ```
3. 在你的 HA 設定目錄中建立一個名為 `packages` 的資料夾（如果你還沒有的話）。
4. 從這個存儲庫下載 [packages/family_calendar.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/packages/family_calendar.yaml)。
5. 搜尋字串 [ #<--- UPDATE THIS ENTITY] 並將行事曆實體 ID 更新為符合你的環境。詳細資訊請參考第 3 節。
6. 將檔案放入你的 `packages/` 資料夾內。
7. **重新啟動 Home Assistant**。

### 3. 行事曆

你可以使用 **Google 行事曆** 或 **本地行事曆**。

#### 選項 A：重用行事曆名稱（最簡單）


1. 前往 **設定 > 裝置與服務**。
2. 新增 **本地行事曆** 整合。
3. 建立名稱完全為：`calendar1`、`calendar2`、`calendar3`、`calendar4`、`Family` 的行事曆。
    * *如果你使用這些名稱，程式碼即可直接運作！*

#### 選項 B：自訂行事曆

1. 前往 **設定 > 裝置與服務**。
2. 新增 **本地行事曆** 整合，或 **Google 行事曆**。
3. 前往 **設定 > 整合 > 本地行事曆** 或 **Google 行事曆**，並選擇「新增項目」
4. 為每個建立的項目取得實體 ID，以更新 dashboard.yaml 檔案。
5. 開啟 `dashboard.yaml`。
6. 搜尋 `# <--- UPDATE THIS ENTITY`。
7. 更新符合你環境的實體 ID


#### 設定假期

自 Home Assistant 更新後，假期現在可透過 UI 新增：

1. 前往 **設定 > 裝置與服務 > 新增整合 > 假期**。
2. 選擇你的國家。
3. 檢查實體 ID（例如 `calendar.holidays`）。若與預設不同，請在 dashboard YAML 中更新。

### 4. 儀表板（外觀）


1. 前往 **設定 > 儀表板**
2. 點擊 **新增儀表板**（選擇「全新儀表板」並確保選擇「加入側邊欄」）。
3. 在左側選單選擇新建立的儀表板，然後點擊鉛筆圖示進行編輯。
5. 選擇三個點的圖示，然後選擇「原始配置編輯器」。
6. 複製並貼上來自 [dashboard.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/dashboard.yaml) 的程式碼。

### 步驟五：主題（可選）

若要獲得特定的字型外觀（Ovo）：

1. 確保你的 `configuration.yaml` 在 `frontend:` 下有這一行：

   ```yaml
   frontend:
     themes: !include_dir_merge_named themes
   ```
2. 在你的設定目錄下建立一個名為 `themes` 的資料夾。
3. 下載 [themes/skylight.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/themes/skylight.yaml) 並放入該資料夾中。
4. 使用檔案編輯器將 calbackgrd.png 上傳至 /www/ 資料夾，這會在儀表板內部轉換為 /local。
5. 重新啟動 Home Assistant。
6. 前往你的個人檔案（左下角的使用者圖示）並將 **主題** 更改為 `Skylight`。
注意：此主題並非全面性，請留意。

---

## 📐 運作原理（底層說明）

### 篩選邏輯

`week-planner-card` 原生並不支援即時隱藏特定行事曆。為解決此問題，我使用 **Input Texts** 作為正則過濾器。

* 當你點擊某人的按鈕時，會在 `.*`（顯示全部）與 `^$`（全部隱藏）之間切換其過濾條件。
* `config-template-card` 會動態地將這些變數注入至行事曆卡片。

### 建立事件腳本

「新增事件」的彈出視窗使用單一腳本，負責處理多人與事件類型（整天 vs 定時）的邏輯。


```yaml
# Simplified Logic Example
target_calendar: "{{ calendar_map.get(states('input_select.calendar_select')) }}"

choose:
  - conditions: "All Day Event is ON"
    action: calendar.create_event (start_date, end_date)
  - conditions: "All Day Event is OFF"
    action: calendar.create_event (start_date_time, end_date_time)
```

## 注意事項

我最初的貼文只是為了提供一個高層次的概述，讓大家能夠根據自己的特定情境調整程式碼以使其運作。

特別是我這麼做的原因是因為每個顯示器和需求都不同。我無法為所有可能尺寸的顯示器、儀表板等進行開發。因此這套方案是為我所提到的顯示器或任何（1920x1080）設計，但應該可以編輯以適用於其他顯示器。

談到顯示器，我最初推薦那款是因為它當時在 Woot 特價，是取得觸控顯示器非常經濟的方式。現在可能不是如此，所以請使用任何適合你的顯示器。平板、觸控螢幕、手機都可以。你主要需要編輯的是儀表板。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-08

---
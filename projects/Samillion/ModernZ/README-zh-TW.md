<h1 align="center">ModernZ - mpv 的時尚替代 OSC</h1>

一個為 [mpv](https://mpv.io/) 設計的時尚現代 OSC，本專案是 ModernX 的分支，旨在通過新增更多功能來提升功能性，同時保留 mpv OSC 的核心標準。

![ModernZ-OSC](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/f6854de6-1d57-4b2f-848e-7197933b71aa)

<p align="center">
    <a href="#installation"><strong>安裝 »</strong></a>
  <br>
  <a href="#configuration">配置</a>
  ·
  <a href="#controls">控制</a>
  ·
  <a href="#interactive-menus">互動選單</a>
  ·
  <a href="#translations">OSC 語言</a>
  ·
  <a href="#extras">額外腳本</a>
</p>

## 功能

- 🎨 現代且可自訂的介面 [[選項](#configuration)]
- 📷 圖片瀏覽模式，帶有縮放控制 [[詳情](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/IMAGE_VIEWER.md)]
- 🎛️ 按鈕：下載、播放清單、速度控制、截圖、釘選、循環、緩存等 [[詳情](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/CONTROLS.md)]
- 📄 互動選單，支援播放清單、字幕、章節、音訊軌道及音訊裝置 [[詳情](#interactive-menus)]
- 🌐 多語言支援，採用 JSON [locale](#translations) 整合
- ⌨️ 可配置控制 [[詳情](#controls)]
- 🖼️ 影片縮圖預覽，使用 [thumbfast](https://github.com/po5/thumbfast)

## 自訂化

您可以使用 `modernz.conf` 中的 `icon_theme` 選項，將圖示主題更改為 `fluent` 或 `material`，以符合您的喜好與風格。

![modernz_fluent](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/3aafac8c-a13f-4840-8119-739523eb7a8e)

![modernz_material](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/e5ad6d06-f071-42ef-9210-296d95906d94)

不喜歡白色按鈕和文字？您可以完全控制顏色和按鈕佈局，完美反映您的風格。

![modernz_osc_controls_top](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/9e3df3af-d3ea-41bb-8c9a-9bf64c1d895a)

![modernz_osc_controls_bottom](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/d4e56bf5-ce7b-44e9-90a3-e27e922dd6bd)

詳情請參閱配置指南中的[顏色自訂](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md#colors-and-style)章節，了解如何自訂顏色和按鈕。

## 互動選單

ModernZ 支援 mpv 內建的控制台/選擇器功能 ([v0.40+](https://github.com/mpv-player/mpv/releases/tag/v0.40.0))，可用於播放清單、字幕、章節導航等。

[![preview_menus](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/4b7a3139-81f1-409b-98f5-f090a81d5ee6)](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/INTERACTIVE_MENUS.md)

## 安裝

1. **停用預設 OSC**

   - 在您的 `mpv.conf` 中加入 `osc=no`

2. **複製檔案**

   - 將 `modernz.lua` 放入 mpv 的 scripts 目錄
   - 將 `fluent-system-icons.ttf` 與 `material-design-icons.ttf` 放入 mpv 的 fonts 目錄
   - （可選）將 `thumbfast.lua` 放入 mpv 的 scripts 目錄

3. **目錄位置**

   ```
   Linux:   ~/.config/mpv/
   Windows: C:/Users/%username%/AppData/Roaming/mpv/
   macOS:   ~/Library/Application Support/mpv/
   ```

4. **資料夾結構** [[mpv 手冊](https://mpv.io/manual/master/#files)]
   ```
   mpv/
   ├── fonts/
   │   ├── fluent-system-icons.ttf
   │   └── material-design-icons.ttf
   ├── script-opts/
   │   └── modernz.conf
   └── scripts/
   	   ├── modernz.lua
   	   └── thumbfast.lua (可選)
   ```

## 配置

1. 在 `/script-opts` 資料夾中建立 `modernz.conf` 以自訂設定

   - [下載預設 modernz.conf](https://raw.githubusercontent.com/Samillion/ModernZ/main/modernz.conf)

2. 簡短配置範例：

   ```EditorConfig
   # 進度條顏色（十六進位格式）
   seekbarfg_color=#B7410E

   # 介面選項
   playlist_button=no
   title=${media-title}
   scalewindowed=1.0
   window_top_bar=auto
   ```

完整選項列表，請參考[詳細清單](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md)。

## 控制

### 按鈕互動

- 左鍵點擊：主要動作
- 右鍵點擊：次要動作
- 滾輪按鍵點擊／Shift+左鍵點擊：替代動作

> [!注意]
> 滾輪按鍵點擊的功能與 `Shift+左鍵` 相同，方便單手操作

完整互動列表，請參閱[按鈕互動指南](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/CONTROLS.md)。

### 快捷鍵

ModernZ 預設不設定快捷鍵，以免干擾您現有的設定。您可在 `input.conf` 中自行新增：

```
w   script-binding modernz/progress-toggle           # 切換進度條
x   script-message-to modernz osc-show               # 顯示 OSC
y   script-message-to modernz osc-visibility cycle   # 循環顯示模式
z   script-message-to modernz osc-idlescreen         # 切換閒置畫面
```

## 語言翻譯

ModernZ 目前提供英文版，但您可以輕鬆切換到您偏好的語言！方法如下：

1. **下載語系包：**

從本倉庫取得 [modernz-locale.json](https://raw.githubusercontent.com/Samillion/ModernZ/main/extras/locale/modernz-locale.json) 檔案。此檔案包含多種語言翻譯。

2. **將語系檔加入 mpv：**

將下載的 `modernz-locale.json` 複製到 mpv 的 `/script-opts` 資料夾。

3. **選擇您的語言：**

有兩種方式設定偏好語言：

- **推薦使用：** 編輯 `modernz.conf` 檔案

  ```ini
  # modernz.conf 範例配置
  # 設定語言為簡體中文
  language=zh
  ```

- **替代方法：** 編輯 `modernz.lua` 腳本

  打開 `modernz.lua`，在開頭附近找到 `user_opts` 區塊，將 `language` 值改為您偏好的語言代碼：

  ```lua
  local user_opts = {
      -- 一般設定
      language = "en",  -- 將此處改為您偏好的語言代碼
      ...
  }
  ```

**需要更多資訊？**

完整可用語言列表、貢獻指南及詳盡翻譯文件，請參閱 [TRANSLATIONS.md](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/TRANSLATIONS.md)。

## 額外腳本

以下是我編寫並維護的腳本，如果您覺得有用，歡迎使用。

- [Pause-Indicator-Lite](https://raw.githubusercontent.com/Samillion/ModernZ/main/extras/pause-indicator-lite) - 簡單的暫停指示器腳本

- [ytdlAutoFormat](https://github.com/Samillion/mpv-ytdlautoformat) - 自動為指定網域調整 `ytdl-format`（yt-dlp）的 mpv 腳本。

- [BoxtoWide](https://github.com/Samillion/mpv-boxtowide) - 自動將 4:3 影片比例轉換為 16:9 的 mpv 腳本。

更多有用的腳本，請參閱 [mpv 用戶腳本維基](https://github.com/mpv-player/mpv/wiki/User-Scripts)。該維基提供大量社群貢獻的腳本，提升您的 mpv 體驗。

## 歷史

- [Samillion/ModernZ](https://github.com/Samillion/ModernZ)
  - 分支自 [dexeonify/ModernX](https://github.com/dexeonify/mpv-config/blob/main/scripts/modernx.lua)
    - 分支自 [cyl0/ModernX](https://github.com/cyl0/ModernX)
    - 分支自 [maoiscat/mpv-osc-modern](https://github.com/maoiscat/mpv-osc-modern)

**為何再次分支？**

- 新增許多功能：[顏色自訂](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md#colors-and-style)、[選項](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md)及[語系整合](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/TRANSLATIONS.md)
- 將控制台與選擇功能整合入 osc，啟發 mpv 在預設 osc 中應用。[參考 [#1](https://github.com/mpv-player/mpv/pull/15016), [#2](https://github.com/mpv-player/mpv/pull/15031)]
- 新增專為圖片設計的佈局。[[詳情](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/IMAGE_VIEWER.md)]
- 重新設計專案以符合 mpv 預設 osc 標準，確保相容性
- 消除舊有錯誤與冗餘程式碼
    - 使其他 `Modern` 分支可基於 ModernZ 開發，例如 [zydezu/ModernX](https://github.com/zydezu/ModernX)。[[參考](https://github.com/zydezu/ModernX/releases/tag/0.3.9)]

總之，旨在維護並復興 `modern-osc` 的起源。
話雖如此，ModernZ 仍使用部分舊代碼，且所有先前及現有的分支作者與貢獻者都值得肯定（包括 mpv 的原生 osc），這也是為何他們在此詳細提及的原因。

#### 致謝：

- 字體：UI Fluent 系統圖示 [[細節](https://github.com/microsoft/fluentui-system-icons)] [[字體檔案](https://raw.githubusercontent.com/Samillion/ModernZ/main/fluent-system-icons.ttf)]
- 字體由 [Xurdejl](https://github.com/Xurdejl) 修改以供 ModernZ osc 使用
- [mpv](https://github.com/mpv-player/mpv) 及其 [osc.lua](https://raw.githubusercontent.com/mpv-player/mpv/master/player/lua/osc.lua)，因 ModernZ osc 是基於原生 osc 標準重新構建並套用其更新
- 如 [歷史](#history) 所述的所有現代 osc 起源及其分支
- 所有直接或間接協助 ModernZ osc 的 [貢獻者](https://github.com/Samillion/ModernZ/graphs/contributors)、測試者及用戶 ❤️

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---
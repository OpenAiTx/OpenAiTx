<p align="center">
  <a href="https://whispering.bradenwong.com">
    <img width="180" src="https://raw.githubusercontent.com/braden-w/whispering/main/apps/app/src-tauri/recorder-state-icons/studio_microphone.png" alt="Whispering">
  </a>
  <h1 align="center">Whispering</h1>
  <p align="center">由 OpenAI Whisper 模型驅動的無縫語音輸入</p>
</p>

<p align="center">
  <!-- 最新版本徽章 -->
  <img src="https://img.shields.io/github/v/release/braden-w/whispering?style=flat-square&label=Latest%20Version&color=brightgreen" />
  <!-- 授權徽章 -->
  <a href="LICENSE" target="_blank">
    <img alt="MIT License" src="https://img.shields.io/github/license/braden-w/whispering.svg?style=flat-square" />
  </a>
  <!-- 技術徽章 -->
  <img alt="TypeScript" src="https://img.shields.io/badge/-TypeScript-blue?style=flat-square&logo=typescript&logoColor=white" />
  <img alt="Rust" src="https://img.shields.io/badge/-Rust-orange?style=flat-square&logo=rust&logoColor=white" />
  <!-- 平台支援徽章 -->
  <a href="https://chrome.google.com/webstore/detail/whispering/oilbfihknpdbpfkcncojikmooipnlglo" target="_blank">
    <img alt="Chrome" src="https://img.shields.io/chrome-web-store/stars/oilbfihknpdbpfkcncojikmooipnlglo?color=blue&label=Chrome&style=flat-square&logo=google-chrome&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="macOS" src="https://img.shields.io/badge/-macOS-black?style=flat-square&logo=apple&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="Windows" src="https://img.shields.io/badge/-Windows-blue?style=flat-square&logo=windows&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="Linux" src="https://img.shields.io/badge/-Linux-yellow?style=flat-square&logo=linux&logoColor=white" />
  </a>
</p>


## 關於

Whispering 是一款開源的語音轉文字應用程式，提供全域語音轉文字功能，並具備如鍵盤快捷鍵、自動複製貼上等選項，讓語音輸入體驗順暢無比。

在核心技術上，Whispering 採用 OpenAI 的 Whisper 模型，比內建語音輸入準確許多。

> **重要說明**：Whispering 主要設計為語音轉錄工具，而非錄音工具。若需要長時間且高可靠性的錄音，建議使用手機或裝置上的原生錄音 App，以確保最佳音質與錄音穩定性。

## 示範

https://github.com/user-attachments/assets/eca93701-10a0-4d91-b38a-f715bd7e0357

https://github.com/user-attachments/assets/a7934f1f-d08b-4037-9bbc-aadd1b13501e

## 主要功能

1. **全域語音轉錄**：可透過全域鍵盤快捷鍵或兩次按鍵隨時啟用 Whisper 的語音轉文字功能。
2. **跨平台體驗**：
   - 桌面應用程式：可在所有應用中進行全域語音轉錄。
   - 瀏覽器擴充功能：透過與網頁應用的通訊，在瀏覽器中提供全域語音轉錄功能。
3. **聊天整合**：瀏覽器擴充功能會在 ChatGPT 和 Claude 網站新增錄音按鈕，讓你能直接在聊天介面語音輸入並轉錄。
4. **轉錄管理**：可在 Whispering 應用程式內檢視與編輯轉錄內容，以確保準確性與清晰度。
5. **自動剪貼簿整合**：轉錄完成後，文字會自動複製到剪貼簿，也可選擇自動貼上。

## 我的資料如何儲存？

Whispering 儘可能將資料儲存在本機，包括錄音檔案與文字轉錄內容，確保最高的隱私與資料安全。以下是資料處理方式的概述：

1. **本機儲存**：語音錄音與轉錄內容會儲存在 IndexedDB，作為 blob 儲存區及所有資料（如文字與轉錄）的儲存空間。

2. **轉錄服務**：唯一會傳送至外部的是你的錄音，且僅當你選擇外部轉錄服務時。可選擇以下服務：
   - 外部服務，例如 OpenAI 或 Groq
   - 本地轉錄服務，如 `faster-whisper-server`，所有資料都保留在裝置上

3. **可設定選項**：你可於設定中更改轉錄服務，以確保最大程度的本地化功能。

## 安裝方式

### 網頁版

前往 [whispering.bradenwong.com](https://whispering.bradenwong.com/)，此處已託管 `apps/app` 資料夾的最新版本（由 Vercel 提供）。

### Chrome 擴充功能

從 Chrome 線上應用程式商店[這裡](https://chrome.google.com/webstore/detail/whispering/oilbfihknpdbpfkcncojikmooipnlglo)安裝 Chrome 擴充功能。

### 桌面應用程式

如需下載與安裝 Whispering 桌面應用程式，請依照你的作業系統進行：

#### Windows

1. 從[最新發行頁面](https://github.com/braden-w/whispering/releases)下載副檔名為 `.msi` 的安裝包。
2. 開啟下載的 `.msi` 檔案執行安裝程式。
3. 若被提示為不安全，請點選 `更多資訊` -> `仍要執行` 繼續安裝。
4. 按照畫面指示完成安裝。

#### macOS

macOS 安裝 Whispering 步驟如下：

1. **下載安裝包**：
   - 前往[最新發行頁面](https://github.com/braden-w/whispering/releases)。
   - 選擇合適的套件：
     - Apple Silicon：`Whispering_x.x.x_aarch64.dmg`
     - Intel：`Whispering_x.x.x_x64.dmg`

2. **安裝應用程式**：
   - 開啟下載的 `.dmg` 檔案。
   - 將 Whispering app 拖曳至 Applications 資料夾。

3. **啟動 Whispering**：
   - 從 Applications 資料夾開啟 Whispering。
   - 若看到未經驗證開發者的警告：
     - 點選 `取消`
     - 在 Finder 右鍵點選該應用程式並選擇 `開啟`

4. **疑難排解**（僅限 Apple Silicon）：
   若遇到錯誤訊息「"Whispering" 已損毀，無法打開」：
   - 開啟終端機
   - 執行以下指令：
     ```bash
     xattr -cr /Applications/Whispering.app
     ```
   - 再次嘗試開啟應用程式

完成上述步驟後，Whispering 即可於你的 macOS 系統上使用。

#### Linux

Linux 有多種安裝方式，請選擇適合你的環境：

1. **AppImage**：

   - 從[最新發行頁面](https://github.com/braden-w/whispering/releases)下載 `.AppImage` 檔案。
   - 設定檔案執行權限：
     ```bash
     chmod +x whispering_x.x.x_amd64.AppImage
     ```
   - 執行 AppImage：
     ```bash
     ./whispering_x.x.x_amd64.AppImage
     ```

2. **DEB 套件（Debian/Ubuntu）**：
   - 從[最新發行頁面](https://github.com/braden-w/whispering/releases)下載 `.deb` 檔案。
   - 使用 `dpkg` 安裝套件：
     ```bash
     sudo dpkg -i whispering_x.x.x_amd64.deb
     ```
   - 解決相依性問題：
     ```bash
     sudo apt-get install -f
     ```

安裝完成後，即可開始使用此應用程式。

## 使用說明

### Chrome 擴充功能

安裝完成後，你會在 Chrome 擴充功能列看到 Whispering 圖示。點擊此圖示即可開啟擴充功能。點擊麥克風按鈕開始錄音，錄音完畢再點擊方形按鈕。你的轉錄內容會顯示在下方文字框。

如需使用 ChatGPT 或 Claude 功能，請前往 ChatGPT 或 Claude 網頁。你會在聊天介面看到新的錄音按鈕。點擊此按鈕開始與停止錄音，轉錄文字會自動插入聊天輸入框中。

如需使用快捷鍵功能，請按下 <kbd>Control</kbd> + <kbd>Shift</kbd> + <kbd>X</kbd> 或 <kbd>Command</kbd> + <kbd>Shift</kbd> + <kbd>X</kbd>（可於 Chrome 擴充功能快捷鍵中設定）即可從任何網站開始錄音。轉錄內容會自動複製到剪貼簿並貼入目前輸入框。

Chrome 擴充功能會與 [whispering.bradenwong.com](https://whispering.bradenwong.com) 通訊，如找不到網頁會自動在背景開啟新分頁。大多數錯誤都與此通訊失敗有關，例如分頁進入休眠狀態等罕見情況。

### 網頁版

透過 [whispering.bradenwong.com](https://whispering.bradenwong.com) 進入網頁版。點擊麥克風按鈕開始錄音，錄音結束後點擊方形按鈕。轉錄內容會顯示於文字框。

### 桌面應用程式

安裝完成後，按下 <kbd>Control/Command</kbd> + <kbd>Shift</kbd> + <kbd>;</kbd>（可於設定中修改）即可從桌面任何地方開始錄音。轉錄內容會自動複製到剪貼簿並貼上，兩者皆可於設定中切換開關。

## 技術架構

#### 網頁與桌面

Whispering 應用程式使用下列技術與函式庫開發：

- [Svelte 5](https://svelte.dev)：首選的 UI 響應式函式庫。
- [SvelteKit](https://kit.svelte.dev/docs)：用於路由與靜態網站產生，適用於網站與 Tauri 應用的靜態前端。
- [Tauri](https://tauri.studio/en/docs/intro/)：桌面應用程式框架。
- [Effect-TS](https://github.com/Effect-TS/effect)：強化函數式程式設計，撰寫極度型別安全的函數，錯誤會包含在函數回傳型別中。
- [Svelte Sonner](https://svelte-sonner.vercel.app/)：Svelte 專用的簡單可自訂吐司通知函式庫。用於 Effect-TS 冒泡錯誤時，透過 `renderAsToast` 函數顯示。
- [TanStack Table](https://tanstack.com/table)：提供所有資料表格功能。
- [IndexedDB](https://developer.mozilla.org/en-US/docs/Web/API/IndexedDB_API)：瀏覽器內儲存大量結構化資料的低階 API，並與 Tanstack Table 同步。
- [ShadCN-Svelte](https://github.com/huntabyte/shadcn-svelte)：首選 UI 元件函式庫。
- [TailwindCSS](https://tailwindcss.com/docs)：實用為主的 CSS 框架，快速打造自訂 UI。
- [Turborepo](https://turborepo.org/)：Monorepo 管理工具，使 `apps/app` 與 `apps/extension` 可共用同一程式碼，大幅減少重複並統一資料來源。
- [Rust](https://www.rust-lang.org)：擴展桌面應用功能，如用 `enigo` crate 處理自動貼上。
- [Vercel](https://vercel.com/)：適合休閒專案的主機服務，並支援 Turborepo 整合。
- [Zapsplat.com](https://www.zapsplat.com/)：免版稅音效庫。

#### 擴充功能

Whispering Chrome 擴充功能使用：

- [Plasmo](https://docs.plasmo.com/)：Chrome 擴充功能開發框架。採用 [relay flow](https://docs.plasmo.com/framework/messaging#relay-flow) 與 Whispering 網站通訊。
- [Effect-TS](https://github.com/Effect-TS/effect)：強化函數式程式設計，撰寫極度型別安全的函數，錯誤包含在函數回傳型別中。
- [React](https://reactjs.org)：Chrome 擴充功能的 UI 響應式函式庫，因 Plasmo 尚不支援 Svelte 5。
- [ShadCN](https://github.com/shadcn)：Chrome 擴充功能的 UI 元件庫。
- [TailwindCSS](https://tailwindcss.com/docs)：一個以實用為先的 CSS 框架，可快速構建自訂的使用者介面。
- [Chrome API](https://developer.chrome.com/docs/extensions/reference/)：Chrome 擴充功能 API。
- [Zapsplat.com](https://www.zapsplat.com/)：免版稅音效資源庫。

## 在本地開發模式下執行 Whispering

要在本地電腦上設置專案，請按照以下步驟操作：

1. 複製儲存庫：`git clone https://github.com/braden-w/whispering.git`
2. 切換到專案目錄：`cd whispering`
3. 安裝所需依賴：`pnpm i`

要在開發模式下運行 Whispering 桌面應用和網站：

4. 切換到 app 目錄：`cd apps/app`
5. 運行開發伺服器：`pnpm tauri dev`

桌面應用將自動開啟以進行本地開發。若要開發網頁應用，請開啟瀏覽器並前往 `http://localhost:5173`。

要在開發模式下運行 Whispering Chrome 擴充功能：

4. 切換到 extension 目錄：`cd apps/extension`
5. 運行開發伺服器：`pnpm dev --target=chrome-mv3`

開發 Chrome 擴充功能時，請在瀏覽器進入 `chrome://extensions`，啟用開發者模式，然後將 `apps/extension/build/{platform}-{manifest-version}-dev` 資料夾作為未封裝擴充功能載入。

## 自行建置可執行檔

如果你對安裝程式的可信度有所疑慮，或希望擁有更多掌控權，你隨時可以自行建置可執行檔。這需要更多的設置，但能確保你運行的是你預期的程式碼。這就是開源軟體的美好之處！

### Chrome

1. 切換到 extension 目錄：`cd apps/extension`
2. 安裝所需依賴：`pnpm i`
3. 執行 Plasmo build：`pnpm plasmo build --target=chrome-mv3`
4. 輸出會在 `apps/extension/build/chrome-mv3-prod`，可作為未封裝擴充功能載入至 Chrome。
5. 或者，也可以為 Chrome Web Store 建置擴充功能：`pnpm plasmo build --target=chrome-mv3 --release`

### Firefox

1. 切換到 extension 目錄：`cd apps/extension`
2. 安裝所需依賴：`pnpm i`
3. 執行 Plasmo build：`pnpm plasmo build --target=firefox-mv3`
4. 輸出會在 `apps/extension/build/firefox-mv3-prod`，可作為未封裝擴充功能載入至 Chrome。
5. 或者，也可以為 Chrome Web Store 建置擴充功能：`pnpm plasmo build --target=firefox-mv3 --release`

### 桌面

1. 切換到 app 目錄：`cd apps/app`
2. 安裝所需依賴：`pnpm i`
3. 執行 Tauri Build：`pnpm tauri build`
4. 你可以在 `apps/app/target/release` 目錄找到可執行檔。

## 貢獻指南

我們歡迎社群的貢獻！如果你想為 Whispering 做出貢獻，請按照以下步驟：

1. 派生（fork）此儲存庫。
2. 為你的功能或修復建立新分支：`git checkout -b feature/your-feature-name` 或 `git checkout -b fix/your-bugfix-name`
3. 完成修改並以具描述性的訊息提交。
4. 將你的分支推送到你派生的儲存庫：`git push origin your-branch-name`
5. 從你派生的儲存庫建立 pull request 至原始儲存庫。

請確保你的程式碼遵循既定慣例並有良好文件說明。

## 授權

Whispering 以 [MIT 授權條款](https://opensource.org/licenses/MIT) 發佈。

## 贊助者

本專案由以下出色的個人與組織支持：

<!-- sponsors --><a href="https://github.com/DavidGP"><img src="https://github.com/DavidGP.png" width="60px" alt="" /></a><a href="https://github.com/cgbur"><img src="https://github.com/cgbur.png" width="60px" alt="Chris Burgess" /></a><a href="https://github.com/Wstnn"><img src="https://github.com/Wstnn.png" width="60px" alt="" /></a><a href="https://github.com/rkhrkh"><img src="https://github.com/rkhrkh.png" width="60px" alt="" /></a><a href="https://github.com/doxgt"><img src="https://github.com/doxgt.png" width="60px" alt="" /></a><a href="https://github.com/worldoptimizer"><img src="https://github.com/worldoptimizer.png" width="60px" alt="Max Ziebell" /></a><a href="https://github.com/AlpSantoGlobalMomentumLLC"><img src="https://github.com/AlpSantoGlobalMomentumLLC.png" width="60px" alt="" /></a><!-- sponsors -->

## 支援與反饋

如果你遇到任何問題或有改進建議，請至 [GitHub issues 分頁](https://github.com/braden-w/whispering/issues) 提出 issue，或透過 [whispering@bradenwong.com](mailto:whispering@bradenwong.com) 聯絡我。我非常感謝你的反饋！

感謝你使用 Whispering，祝寫作愉快！

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---
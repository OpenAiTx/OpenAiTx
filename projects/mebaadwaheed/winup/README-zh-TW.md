<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=zh-CN">簡體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen)
![Python 3.9+](https://img.shields.io/badge/python-3.9%2B-blue)
![Component Driven](https://img.shields.io/badge/architecture-component--driven-orange)
![Desktop App](https://img.shields.io/badge/platform-desktop-lightgrey)
![CLI Support](https://img.shields.io/badge/CLI-supported-critical)
![Live Reload](https://img.shields.io/badge/live--reload-enabled-blue)

## 圖片範例

![image](https://github.com/user-attachments/assets/81d016e9-e10a-4438-ab94-99b6d76b8efe)

![image](https://github.com/user-attachments/assets/154dc3f4-ea8c-4f6f-84d3-88c7ab74a46f)

![image](https://github.com/user-attachments/assets/2318f701-6ec8-4402-abcc-40c879bf1a10)

# WinUp 🚀

## 請務必下載最新版穩定版 (LSR)，而非最新/LFR！目前 LSR：2.4.9

`pip install winup==2.4.9`

**一個極度 Pythonic 且強大的框架，用於構建美觀的桌面應用程式。**

WinUp 是一款現代化的 Python UI 框架，將 PySide6 (Qt) 的強大功能封裝成簡單、宣告式且對開發者友善的 API。它旨在讓你更快開發應用、寫出更乾淨的程式碼，並享受開發過程。

### ✨ 現在支援 Web！
WinUp 現在也支援使用同樣以 Python 為中心、基於元件的方式，構建完整互動、具狀態的 Web 應用。Web 模組底層採用 FastAPI 與 WebSockets，將 WinUp 的簡單帶進瀏覽器。

[網頁文件](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/web/README.md)

> **聲明：** 網頁支援為可選功能。若需使用，請安裝 web 相關依賴：
> ```bash
> pip install "winup[web]"
> ```

[貢獻指引](https://raw.githubusercontent.com/mebaadwaheed/winup/main/CONTRIBUTING.md)
[更新日誌](https://raw.githubusercontent.com/mebaadwaheed/winup/main/CHANGELOG.md)
[授權](LICENSE)

---

## 為什麼選擇 WinUp？（而不是直接使用 PySide6 或 Tkinter）

Python 桌面開發往往顯得笨重。WinUp 正是為了解決這個問題而誕生。

| 功能                     | WinUp 方式 ✨                                                               | 原生 PySide6 / Tkinter 方式 😟                                                              |
| ----------------------- | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------- |
| **佈局**                 | `ui.Column(children=[...])`, `ui.Row(children=[...])`                          | `QVBoxLayout()`, `QHBoxLayout()`, `layout.addWidget()`, `pack()`, `grid()`                  |
| **樣式**                 | `props={"background-color": "blue", "font-size": "16px"}`                      | 手動撰寫 QSS 字串，`widget.setStyleSheet(...)`，複雜的樣式物件。                            |
| **狀態管理**             | `state.bind(widget, "prop", "key")`                                            | 手動回呼函數、getter/setter、`StringVar()`，樣板程式碼處處可見。                            |
| **雙向綁定**             | `state.bind_two_way(input_widget, "key")`                                      | 不存在。需手動撰寫 `on_change` 處理器來同步狀態與 UI。                                      |
| **開發者工具**           | **內建熱重載**、程式碼分析器與視窗工具直接提供。                               | 不存在。每次 UI 變更都要重啟整個應用程式。                                                  |
| **程式結構**             | 可重用、自我封裝的元件，配合 `@component`。                                   | 往往導致龐大、單一的類別或過程式腳本。                                                      |

**簡而言之，WinUp 為桌面端帶來了現代 Web 框架（如 React 或 Vue） 的「殺手級功能」，讓你節省時間，專注於應用邏輯本身。**

# 🧊 WinUp vs 🧱 PyEdifice（Reddit 用戶請求）

| 功能                              | WinUp      | PyEdifice                        |
|----------------------------------|--------------------------------------|----------------------------------|
| 🧱 架構                          | React 風格 + 狀態              | React 風格 + 狀態                |
| 🌐 內建路由                      | ✅ 有 (`Router(routes={...})`)        | ❌ 無內建路由                    |
| ♻️ 生命週期鉤子                  | ✅ `on_mount`, `on_unmount` 等        | ⚠️ 有限（如 `did_mount` 等）     |
| 🎨 主題 / 樣式系統                | ✅ 全域及區域主題支援                 | ❌ 需手動注入 CSS                |
| 🔲 佈局選項                      | ✅ Row、Column、Grid、Stack、Flexbox  | ⚠️ 主要為 Box 與 HBox/VBox       |
| 🎞️ 動畫效果                      | ✅ 內建（淡入淡出、縮放等）           | ❌ 無內建動畫                    |
| 🔁 熱重載（LHR）                  | ✅ 穩定且快速（`loadup dev`）         | ⚠️ 實驗性，支援有限              |
| 📦 打包                          | ✅ 內建 LoadUp（基於 PyInstaller）    | ❌ 需自行整合 PyInstaller         |
| 🧩 元件可重用性                  | ✅ 高度宣告式                        | ✅ 高                            |

| 🛠 開發者工具                 | ✅ 已規劃 DevTools，Inspector 即將推出  | ❌ 尚未支援                       |
| 📱 行動裝置支援                | ❌ 尚未支援                          | ❌ 不支援                         |
| 🧠 學習曲線                    | ✅ 對 Python+React 使用者容易上手      | ✅ 簡單但工具較少                  |

> ✅ = 內建或功能強大  
> ⚠️ = 部分或有限支援  
> ❌ = 完全缺少
---

## 核心功能

*   **宣告式與 Python 風格的 UI：** 使用簡單的 `Row` 和 `Column` 物件構建複雜版面，無需繁瑣的方塊佈局。
*   **元件化架構：** 使用 `@component` 裝飾器，從簡單函式建立模組化且可重用的 UI 元件。
*   **強大的樣式系統：** 以 Python 字典透過 `props` 為元件設計樣式。用 `style.add_style_dict` 建立全局「類 CSS」樣式。
*   **完整應用殼層：** 以宣告式 API 建立專業應用，包括 `MenuBar`、`ToolBar`、`StatusBar`、`SystemTrayIcon`。
*   **非同步任務執行器：** 使用簡單的 `@tasks.run` 裝飾器，在背景執行長時間操作且不會凍結 UI。
*   **預設高效能：** 提供可選用的 `@memo` 裝飾器，快取元件渲染、避免不必要的重算。
*   **進階擴充性：**
    *   **元件工廠：** 透過 `ui.register_widget()`，可替換任何預設元件為自訂（如 C++ 實作）。
    *   **多視窗管理：** 建立並管理多個獨立視窗，適用於複雜應用（如工具調色盤或音樂播放器）。
*   **反應式狀態管理：**
    *   **單向綁定：** 用 `state.bind()`，當資料變更時自動更新 UI。
    *   **雙向綁定：** 使用 `state.bind_two_way()`，輕鬆同步輸入元件與狀態。
    *   **訂閱機制：** 用 `state.subscribe()`，在狀態變更時觸發任意函式。
*   **友善開發工具：**
    *   **熱重載：** 即時預覽 UI 變更，無需重啟應用程式。
    *   **效能分析器：** 以 `@profiler.measure()` 裝飾器，輕鬆評測任何函式效能。
    *   **視窗工具：** 輕鬆置中、閃爍或管理應用視窗。
*   **內建路由：** 以直觀、狀態驅動的路由器，輕鬆建立多頁面應用。
*   **彈性資料層：** 內建 SQLite、PostgreSQL、MySQL、MongoDB 和 Firebase 等一致連接器。

---

# 文件

深入了解 WinUp 的功能：

## 核心概念
- [**元件模型與樣式**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md)
- [**狀態管理**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/state.md)
- [**生命週期掛勾**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md#component-lifecycle-hooks-on_mount-and-on_unmount)
- [**路由**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md#routing)
- [**絕對定位（進階）**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/absolute-layout.md)

## 開發工具
- [**即時熱重載（LHR）**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/live-hot-reload.md)
- [**效能分析器**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/profiler.md)
- [**記憶化**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/memoization.md)
- [**非同步任務執行器**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/tasks.md)

## UI 元件
- [**完整元件庫**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/components/README.md)

---

## 貢獻

WinUp 是一個開源專案。歡迎各界貢獻！

## 授權

本專案採用 MIT 授權。詳情請參閱 **LICENSE**。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---
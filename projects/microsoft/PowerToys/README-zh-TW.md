# Microsoft PowerToys

![Microsoft PowerToys 主視覺圖](doc/images/overview/PT_hero_image.png)

[如何使用 PowerToys][usingPowerToys-docs-link] | [下載與發行說明][github-release-link] | [參與貢獻 PowerToys](#contributing) | [最新動態](#whats-happening) | [產品藍圖](#powertoys-roadmap)

## 關於

Microsoft PowerToys 是一組專為進階用戶設計的工具，可調整並簡化 Windows 使用體驗，提升生產力。更多有關 [PowerToys 概覽及如何使用各項工具][usingPowerToys-docs-link]，或其他 [Windows 開發環境](https://learn.microsoft.com/windows/dev-environment/overview) 的工具和資源資訊，請前往 [learn.microsoft.com][usingPowerToys-docs-link]！

|              | 目前提供的工具： |              |
|--------------|--------------------|--------------|
| [進階貼上](https://aka.ms/PowerToysOverview_AdvancedPaste) | [頂端顯示](https://aka.ms/PowerToysOverview_AoT) | [PowerToys Awake](https://aka.ms/PowerToysOverview_Awake) |
| [色彩擷取器](https://aka.ms/PowerToysOverview_ColorPicker) | [未找到命令](https://aka.ms/PowerToysOverview_CmdNotFound) | [命令面板](https://aka.ms/PowerToysOverview_CmdPal) |
| [裁剪與鎖定](https://aka.ms/PowerToysOverview_CropAndLock) | [環境變數](https://aka.ms/PowerToysOverview_EnvironmentVariables) | [FancyZones](https://aka.ms/PowerToysOverview_FancyZones) |
| [檔案總管增益集](https://aka.ms/PowerToysOverview_FileExplorerAddOns) | [檔案鎖定查詢](https://aka.ms/PowerToysOverview_FileLocksmith) | [Hosts 檔案編輯器](https://aka.ms/PowerToysOverview_HostsFileEditor) |
| [影像調整大小工具](https://aka.ms/PowerToysOverview_ImageResizer) | [鍵盤管理員](https://aka.ms/PowerToysOverview_KeyboardManager) | [滑鼠工具](https://aka.ms/PowerToysOverview_MouseUtilities) |
| [無邊界滑鼠](https://aka.ms/PowerToysOverview_MouseWithoutBorders) | [New+](https://aka.ms/PowerToysOverview_NewPlus) | [以純文字貼上](https://aka.ms/PowerToysOverview_PastePlain) |
| [Peek 檢視](https://aka.ms/PowerToysOverview_Peek) | [PowerRename](https://aka.ms/PowerToysOverview_PowerRename) | [PowerToys Run](https://aka.ms/PowerToysOverview_PowerToysRun) |
| [快速重音符號](https://aka.ms/PowerToysOverview_QuickAccent) | [登錄檔預覽](https://aka.ms/PowerToysOverview_RegistryPreview) | [螢幕尺規](https://aka.ms/PowerToysOverview_ScreenRuler) |
| [快捷鍵指南](https://aka.ms/PowerToysOverview_ShortcutGuide) | [文字擷取器](https://aka.ms/PowerToysOverview_TextExtractor) | [工作區](https://aka.ms/PowerToysOverview_Workspaces) |
| [ZoomIt 放大鏡](https://aka.ms/PowerToysOverview_ZoomIt) |

## 安裝並執行 Microsoft PowerToys

### 系統需求

- Windows 11 或 Windows 10 版本 2004（代號 20H1 / 組建號 19041）或更新版本。
- x64 或 ARM64 處理器
- 我們的安裝程式將安裝下列項目：
   - [Microsoft Edge WebView2 執行階段](https://go.microsoft.com/fwlink/p/?LinkId=2124703) 啟動程式。這將安裝最新版本。

### 透過 GitHub 使用 EXE 檔安裝【推薦】

前往 [Microsoft PowerToys GitHub 發行頁面][github-release-link]，點選下方的 `Assets` 以顯示本次發行可用的檔案。請依據您的電腦架構與安裝範圍選擇相對應的 PowerToys 安裝程式。大多數用戶應選擇 `x64` 且為單一用戶安裝。

<!-- 需隨發行版本更新的項目 -->
[github-next-release-work]: https://github.com/microsoft/PowerToys/issues?q=is%3Aissue+milestone%3A%22PowerToys+0.92%22
[github-current-release-work]: https://github.com/microsoft/PowerToys/issues?q=is%3Aissue+milestone%3A%22PowerToys+0.91%22
[ptUserX64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysUserSetup-0.91.1-x64.exe 
[ptUserArm64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysUserSetup-0.91.1-arm64.exe 
[ptMachineX64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysSetup-0.91.1-x64.exe 
[ptMachineArm64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysSetup-0.91.1-arm64.exe
 
|  說明   | 檔案名稱 | sha256 雜湊值 |
|----------------|----------|-------------|
| 單一用戶 - x64       | [PowerToysUserSetup-0.91.1-x64.exe][ptUserX64] | 42EA4A3E8C79A5456476D19E72B3E2AB9393A89C4DC7442EB7EE5A1E3490D38A |
| 單一用戶 - ARM64     | [PowerToysUserSetup-0.91.1-arm64.exe][ptUserArm64] | F3F433FE04049F9197411D792AADEBF34E3BE7FE16327BD8B73D2A046ED8BAF6 |
| 全機安裝 - x64   | [PowerToysSetup-0.91.1-x64.exe][ptMachineX64] | EC4BC3A8625775866B0ED4577CCF83E6EC7B1A0AD267379DDBAF4FE49C7B5BDD |
| 全機安裝 - ARM64 | [PowerToysSetup-0.91.1-arm64.exe][ptMachineArm64] | 9CB8911008420D0E446AE3D5CE365E447FA4DF9DCF9337F3A80F933C00FC3689 |

這是我們最推薦的方法。

### 透過 Microsoft Store 安裝

從 [Microsoft Store 的 PowerToys 頁面][microsoft-store-link] 安裝。您必須使用 [新版 Microsoft Store](https://blogs.windows.com/windowsExperience/2021/06/24/building-a-new-open-microsoft-store-on-windows-11/)，此版本適用於 Windows 11 及 Windows 10。

### 透過 WinGet 安裝
可從 [WinGet][winget-link] 下載 PowerToys。透過 winget 更新 PowerToys 時，會遵循目前的安裝範圍。若要安裝 PowerToys，請從命令提示字元 / PowerShell 執行以下指令：

#### 用戶範圍安裝程式【預設】
```powershell
winget install Microsoft.PowerToys -s winget
```

#### 全機範圍安裝程式

```powershell
winget install --scope machine Microsoft.PowerToys -s winget
```

### 其他安裝方式

還有如 Chocolatey 及 Scoop 等 [社群驅動的安裝方式](./doc/unofficialInstallMethods.md)。如您偏好這些安裝方案，請參閱相關安裝說明。

## 第三方 Run 外掛

有一系列由社群製作、未隨 PowerToys 一同發佈的 [第三方外掛](./doc/thirdPartyRunPlugins.md)。

## 參與貢獻

本專案歡迎各類型的貢獻。除了程式碼功能／修復錯誤外，還可以協助撰寫規格、設計、文件編寫及協助找出錯誤。我們很高興能與進階用戶社群協作，打造一套助您更善用 Windows 的工具集。

我們要求**在您開始開發想要貢獻的新功能前**，請詳閱我們的 [貢獻者指南](CONTRIBUTING.md)。我們樂於協助您規劃最佳解決方案，並於開發過程中提供指導及協助，以避免重工與浪費。

大多數貢獻需您同意一份 [貢獻者授權協議（CLA）][oss-CLA]，授權我們使用您的貢獻，並保證您具備此授權權限。

如需 PowerToys 開發指引，請詳閱 [開發者文件](/doc/devdocs) 以獲得詳細說明，包括如何設定您的電腦以進行編譯。

## 最新動態

### PowerToys 產品藍圖

我們的[優先開發藍圖][roadmap]，列出核心團隊目前聚焦的功能與工具。

### 0.91 - 2025 年 5 月更新

本次版本著重於新功能、穩定性與自動化。

**✨焦點整理**

 - 專注於大幅提升命令面板（Command Palette）的效能並修復大量錯誤。新增功能包括：
 - 命令面板可使用後備命令搜尋任意檔案。
 - 命令面板全域熱鍵可設定為低階鍵盤掛鉤。
 - WebSearch 擴充功能加入開啟 URL 的後備命令，允許用戶直接從命令面板於瀏覽器開啟網址。
 - 現在可於 PT Run 與命令面板的日期與時間插件自訂格式。感謝 [@htcfreek](https://github.com/htcfreek)!

### 進階貼上

 - 修正進階貼上因部分英文語言標籤（如 en-CA）無法建立 OCR 引擎的問題，現透過使用者設定語言初始化 OCR 引擎。感謝 [@cryolithic](https://github.com/cryolithic)!

### 色彩擷取器

 - 修正資源釋放問題導致程式卡頓或閃退，現已正確釋放 Graphics 物件。感謝 [@dcog989](https://github.com/dcog989)!
 - 修正按下 Backspace 時色彩擷取器直接關閉的問題，現僅於聚焦時關閉，並統一 Escape/Backspace 行為。感謝 [@PesBandi](https://github.com/PesBandi)!
 - 新增對 Oklab 及 Oklch 色彩格式的支援。感謝 [@lemonyte](https://github.com/lemonyte)!

### 未找到命令

 - 更新 WinGet Command Not Found 腳本，僅於實際存在實驗性功能時啟用。

### 命令面板

 - 更新錯誤回報範本，納入命令面板模組。
 - 修正 toast 視窗未因 DPI 調整導致縮放及版面錯誤。
 - 修正上下鍵盤導覽在游標於首位時無法移動選取項目，並新增類似 PT Run v1 的連續導覽。感謝 [@davidegiacometti](https://github.com/davidegiacometti)!
 - 簡化及優化時間與日期擴充程式碼。
 - 修正命令大小寫導致移動至滑鼠指標時失敗的問題，已調整為小寫處理。
 - 新增 WebSearch 擴充功能開啟 URL 的後備命令，允許直接於瀏覽器開啟網址。感謝 [@htcfreek](https://github.com/htcfreek)!
 - 新增啟用／停用 CmdPal 系統匣圖示選項，並用詞與 Windows 11 對齊。感謝 [@davidegiacometti](https://github.com/davidegiacometti)!
 - 修正別名更新問題，現於設定新別名時移除舊別名。
 - 解決 GitHub 大小寫衝突，將 Exts 與 exts 皆移至新 ext 目錄，確保跨平台目錄結構一致、防止路徑碎片化。
 - 修正「建立新擴充功能」命令產生空檔名問題。
 - 新增全域熱鍵可設為低階鍵盤掛鉤。
 - 新增對 JUMBO 縮圖支援，可存取高解析度圖示。
 - 修正 CmdPal 在 MSAL 對話框開啟時自動隱藏導致閃退，現已阻止自動隱藏。
 - 新增頁面載入時立即選取搜尋文字的支援。
 - 修正擴充功能設定頁面重新打開時未能重新載入的問題，現已於儲存設定時更新表單。
 - 修正命令面板自運行器啟動失敗問題。
 - 重構並移植 PowerToys Run v1 計算機邏輯至命令面板，新增設定支援並改善後備行為。
 - 重新加入清單項目鍵盤快捷鍵支援。
 - 強化命令面板無障礙性，新增標籤、動畫優化、在地化完善並修復 a11y 相關問題。
 - 將自訂格式支援移植至時間與日期插件，重新排序並整理設定，改善錯誤訊息並修正極端情境閃退，讓行為更健全且易用。感謝 [@htcfreek](https://github.com/htcfreek)!
 - 新增系統命令後備項目。
 - 修正 Windows 系統命令中「開啟資源回收筒」動作按鍵提示誤顯「Empty」的問題。感謝 [@jironemo](https://github.com/jironemo)!
 - 修正「更多命令」清單中出現不該顯示的命令。感謝 [@davidegiacometti](https://github.com/davidegiacometti)!
 - 修正命令面板詳細資料檢視圖圖示過大、文字未對齊，現已與 Windows 搜尋行為一致。
 - 修正長標籤導致空白畫面內容與指令列命令被截斷，確保版面完整可見。
 - 改善 CmdPal 的 WinGet 整合，修正已安裝套件的版本顯示、啟用帶圖示的更新、預覽 winget API 遷移至穩定版。
 - 修正 ContentPage 命令於離開後才更新的問題，現已於內容變更時完整初始化右鍵選單。
 - 新增 TimeDate 擴充後備支援，可直接查詢日期／時間而不需預先選擇命令。
 - 將 Common.Dotnet.AotCompatibility.props 引入多個 CmdPal 專案檔，提升 AOT 編譯支援。
 - 修正 CmdPal 設定因 HotKey 為 null 導致閃退問題（如 settings.json 遺失或無熱鍵設定）。感謝 [@davidegiacometti](https://github.com/davidegiacometti)!
 - 新增 CmdPal 可篩選的巢狀右鍵選單支援，含搜尋框維持聚焦行為。
 - 重構 CmdPal 類別，提升 JSON 序列化效能，並引入新序列化環境以增進效能與維護性。
 - 新增提前編譯（AoT）支援。
 - 新增 CmdPal 啟動重試機制。
 - 從 CmdPal.Common 移除部分未使用檔案，以簡化程式碼庫並利於標示為 AoT 相容。
 - 修正更新 SearchText 的競態條件導致輸入框游標自動跳至行尾問題，現僅於內容實際異動時更新。
 - 新增後備命令搜尋任意檔案支援。
 - 清理 AoT 相關程式碼，防止測試時重複執行。
 - 透過平行啟動擴充與加入逾時機制，減少 CmdPal 載入時間，防止異常擴充阻塞其他項目。
 - 當清單為空時自動隱藏詳細窗格，避免 UI 狀態不一致。
 - 無匹配命令時允許 CmdPal 取消後備命令，確保重新載入更乾淨。
 - 修正 CmdPal 擴充範本 ComServer 使用不當導致的資源洩漏。
 - 阻止 CmdPal 視窗於標題列雙擊時最大化，維持預期視窗行為。感謝 [@davidegiacometti](https://github.com/davidegiacometti)!
 - 修正設定 UI 啟動過小問題，現已支援 DPI 感知並強制最小寬高（使用 WinUIEx）。
 - 以遮蔽方式取代隱藏，修正 CmdPal 白屏與單次動畫問題。
 - 修正啟動時過早抓取全部擴充設定問題，現已延後載入減少初始化負擔。
 - 新增 CmdPal 崩潰防護，避免 Adaptive Card 解析失敗導致閃退。
 - 將 shell:AppsFolder 改為 URI 啟動，提升 CmdPal 穩定性。
 - 新增可從 PowerToys 設定開啟 CmdPal 設定。
 - 新增 CmdPal 可即時監聽並動態更新擴充詳細資訊，追蹤所選項目屬性變更。
 - CmdPal 擴充範本套件工具版本升級至 0.2.0。

### 影像調整大小工具

 - 修正刪除影像調整大小預設集時誤刪其他預設集的問題。

### 鍵盤管理員

 - 修正未指定左右側的修飾鍵於按下後卡住問題，現已追蹤按鍵狀態並正確傳送對應按鍵。感謝 [@mantaionut](https://github.com/mantaionut)!

### PowerRename

 - 新增 PowerRename 時間格式支援 12 小時制及 AM/PM 樣式。感謝 [@bitmap4](https://github.com/bitmap4)!

### PowerToys Run

 - 新增「時間與日期」插件自訂格式支援，並改善無效格式錯誤訊息。感謝 [@htcfreek](https://github.com/htcfreek)!
 - 修正兩個閃退問題：一為非常早期日期的 WFT，另一為極晚日期（如 31.12.9999）計算月份週數，並重新排序 UI 設定。感謝 [@htcfreek](https://github.com/htcfreek)!
 - 修正命令大小寫導致移動至滑鼠指標時失敗的問題，已調整為小寫處理。
 - 新增外掛錯誤訊息中的版本細節（'載入錯誤' 及 '初始化錯誤'）。感謝 [@htcfreek](https://github.com/htcfreek)!
 - 強化結果模型，新增防止基於使用次數自動排序的支援，讓外掛開發者能更精確控制排序。感謝 [@CoreyHayward](https://github.com/CoreyHayward) 及 [@htcfreek](https://github.com/htcfreek)!

### 快速重音符號

 - 更新 GetDefaultLetterKeyEPO 中 VK_U 按鍵的字母對應，將 "ǔ" 改為 "ŭ"，準確反映世界語發音。感謝 [@OlegKharchevkin](https://github.com/OlegKharchevkin)!
 - 修正螢幕鍵盤下快速重音符號無法正常運作的問題。感謝 [@davidegiacometti](https://github.com/davidegiacometti)!

### 登錄檔預覽

 - 登錄檔預覽現支援貼上登錄鍵與數值內容，無需手動加入檔案標頭，並新增重設應用程式按鈕。感謝 [@htcfreek](https://github.com/htcfreek)!

### 設定

 - 修正設定應用程式於工作列隨機顯示空白圖示的問題，現延後圖示指定至視窗啟動時。
 - 新增「新功能」視窗最大化功能，提升閱讀體驗。

### 工作區

 - 修正 Steam 遊戲無法正確擷取或啟動的問題，已更新視窗過濾邏輯並整合 Steam URL 協定處理。

### 文件

 - 在 PowerToys Run 第三方外掛文件中新增 QuickNotes。感謝 [@ruslanlap](https://github.com/ruslanlap)!
 - 將 Weather 與 Pomodoro 外掛納入 PowerToys Run 第三方外掛文件。感謝 [@ruslanlap](https://github.com/ruslanlap)!
 - 新增 Linear 外掛至 PowerToys Run 第三方外掛文件。感謝 [@vednig](https://github.com/vednig)!
 - 修正文件格式問題，並更新貢獻者及團隊成員資訊。感謝 [@DanielEScherzer](https://github.com/DanielEScherzer) 及 [@RokyZevon](https://github.com/RokyZevon)!

### 開發

 - 更新 GitHub Action，新增 .NET 9 支援以利 MSStore 發行。
 - 更新 bug_report.yml 的版本佔位符，避免回報單出現錯誤的 v0.70.0 版本字樣。
 - 將 GitHub Action 中 actions/setup-dotnet 由 v3 升級至 v4 以支援 MSStore 發行。
 - 為 WinGet 設定檔新增 securityContext，可從用戶端呼叫並針對提升權限資源於子程序提示單一 UAC。感謝 [@mdanish-kh](https://github.com/mdanish-kh)!
 - 將日誌檔副檔名由 .txt 改為 .log，支援正確的檔案關聯與工具相容，並新增 Workspace 日誌。感謝 [@benwa](https://github.com/benwa)!
 - 升級測試框架相依性並統一元件套件版本。
 - 升級相依套件以修復安全性漏洞。
 - 加強儲存庫安全性，將 GitHub Actions 與 Docker 標籤釘選至不可變更的完整 Commit，並導入自動化的相依性漏洞掃描（Dependency Review Workflow）。感謝 [@Nick2bad4u](https://github.com/Nick2bad4u)!
 - 升級 Boost 相依套件至新版本。
 - 升級工具組至最新版，並抑制 AoT 相關警告。
 - 修正新加入檔案缺少簽章導致建置失敗問題。
 - 更新發行管道，避免私有符號百年內被釋出。
 - 為 PowerRename 加入模糊測試（fuzzing），提升可靠性，並新增擴展其他 C++ 模組的設置指引。
 - 所有 .csproj 專案加入集中預先建立產生目錄邏輯，防止建置失敗。
 - 更新 WinAppSDK 至最新 1.7 版。
 - 將 PowerRename Fuzzing 專案之 Boost 依賴升級至最新版本。
 - 更新 tsa.json 的 ADO 區域路徑，解決因路徑過時導致 TSA 管道錯誤問題。
 - 開始為 CmdPal 推進 AoT 支援，基礎建設中。
  
### 工具／一般

 - 新增自動產生 GitHub 問題網址及系統診斷資訊的腳本，支援自動建立錯誤回報。感謝 [@donlaci](https://github.com/donlaci)!
 - 新增本地建置安裝程式腳本，確保 CmdPal 也能於本地環境啟動。
 - 移除匯出 PFX 的硬編碼密碼邏輯，修正 PSScriptAnalyzer 安全性警告。
 - 新增 PowerShell 腳本及 CI 整合，強制 src 目錄下所有 C# 專案統一採用 Common.Dotnet.CsWinRT.props。
   
### 0.92 版規劃內容

針對 [v0.92][github-next-release-work]，我們將致力於下列項目：

 - 持續優化命令面板
 - 新增 UI 自動化測試
 - 安裝程式升級作業
 - 升級鍵盤管理員編輯器介面
 - 穩定性／錯誤修正

## PowerToys 社群

PowerToys 團隊非常感謝 [熱情活躍社群][community-link] 的支持。您們的貢獻極其重要，沒有您們協助回報錯誤、更新文件、參與設計和撰寫功能，PowerToys 不可能發展成今日的樣貌。我們謹致謝意並希望公開表揚各位。每個月，正是因為您的參與，PowerToys 才能成為更好的軟體。

## 行為準則

本專案採用 [Microsoft 開源行為準則][oss-conduct-code]。

## 隱私權聲明

本應用程式會記錄基本診斷資料（遙測）。如需隱私權及資料收集詳情，請參閱我們的 [PowerToys 資料與隱私權文件](https://aka.ms/powertoys-data-and-privacy-documentation)。

[oss-CLA]: https://cla.opensource.microsoft.com
[oss-conduct-code]: CODE_OF_CONDUCT.md
[community-link]: COMMUNITY.md
[github-release-link]: https://aka.ms/installPowerToys
[microsoft-store-link]: https://aka.ms/getPowertoys
[winget-link]: https://github.com/microsoft/winget-cli#installing-the-client
[roadmap]: https://github.com/microsoft/PowerToys/wiki/Roadmap
[privacy-link]: http://go.microsoft.com/fwlink/?LinkId=521839
[loc-bug]: https://github.com/microsoft/PowerToys/issues/new?assignees=&labels=&template=translation_issue.md&title=
[usingPowerToys-docs-link]: https://aka.ms/powertoys-docs

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---
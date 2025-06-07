![terminal-logos](https://github.com/microsoft/terminal/assets/91625426/333ddc76-8ab2-4eb4-a8c0-4d7b953b1179)

[![Terminal Build Status](https://dev.azure.com/shine-oss/terminal/_apis/build/status%2FTerminal%20CI?branchName=main)](https://dev.azure.com/shine-oss/terminal/_build/latest?definitionId=1&branchName=main)

# 歡迎來到 Windows Terminal、主控台與命令列儲存庫

<details>
  <summary><strong>目錄</strong></summary>

- [安裝與執行 Windows Terminal](#installing-and-running-windows-terminal)
  - [Microsoft Store【推薦】](#microsoft-store-recommended)
  - [其他安裝方式](#other-install-methods)
    - [透過 GitHub](#via-github)
    - [透過 Windows 套件管理員 CLI（又稱 winget）](#via-windows-package-manager-cli-aka-winget)
    - [透過 Chocolatey（非官方）](#via-chocolatey-unofficial)
    - [透過 Scoop（非官方）](#via-scoop-unofficial)
- [安裝 Windows Terminal Canary](#installing-windows-terminal-canary)
- [Windows Terminal 路線圖](#windows-terminal-roadmap)
- [終端機與主控台概述](#terminal--console-overview)
  - [Windows Terminal](#windows-terminal)
  - [Windows Console Host](#the-windows-console-host)
  - [共用元件](#shared-components)
  - [建立全新的 Windows Terminal](#creating-the-new-windows-terminal)
- [資源](#resources)
- [常見問題](#faq)
  - [我編譯並執行了新 Terminal，但它看起來就像舊主控台](#i-built-and-ran-the-new-terminal-but-it-looks-just-like-the-old-console)
- [文件](#documentation)
- [參與貢獻](#contributing)
- [與團隊溝通](#communicating-with-the-team)
- [開發人員指南](#developer-guidance)
- [先決條件](#prerequisites)
- [編譯程式碼](#building-the-code)
  - [在 PowerShell 中編譯](#building-in-powershell)
  - [在 Cmd 中編譯](#building-in-cmd)
- [執行與除錯](#running--debugging)
  - [程式設計指引](#coding-guidance)
- [行為準則](#code-of-conduct)

</details>

<br />

此儲存庫包含以下原始碼：

* [Windows Terminal](https://aka.ms/terminal)
* [Windows Terminal Preview](https://aka.ms/terminal-preview)
* Windows 主控台主機（`conhost.exe`）
* 兩個專案間共用的元件
* [ColorTool](./src/tools/ColorTool)
* [範例專案](./samples)
  展示如何使用 Windows Console API

相關儲存庫包括：

* [Windows Terminal 文件](https://docs.microsoft.com/windows/terminal)
  （[貢獻文件的儲存庫](https://github.com/MicrosoftDocs/terminal)）
* [Console API 文件](https://github.com/MicrosoftDocs/Console-Docs)
* [Cascadia Code 字型](https://github.com/Microsoft/Cascadia-Code)

## 安裝與執行 Windows Terminal

> [!NOTE]
> Windows Terminal 需要 Windows 10 2004（組建 19041）或更新版本

### Microsoft Store【推薦】

從 [Microsoft Store 安裝 Windows Terminal][store-install-link]。
這將讓您在我們釋出新版本時自動升級，始終使用最新版本。

這是我們首選的安裝方式。

### 其他安裝方式

#### 透過 GitHub

如果您無法從 Microsoft Store 安裝 Windows Terminal，可以從本儲存庫的 [發行頁面](https://github.com/microsoft/terminal/releases) 手動下載已發行版本。

從 **Assets** 區段下載 `Microsoft.WindowsTerminal_<versionNumber>.msixbundle` 檔案。安裝應用程式時，只需雙擊 `.msixbundle` 檔案，安裝程式應會自動執行。如果安裝失敗，您可以在 PowerShell 提示字元下執行以下指令：

```powershell
# 注意：如果您使用 PowerShell 7+，請先執行
# Import-Module Appx -UseWindowsPowerShell
# 再使用 Add-AppxPackage。

Add-AppxPackage Microsoft.WindowsTerminal_<versionNumber>.msixbundle
```

> [!NOTE]
> 如果您手動安裝 Terminal：
>
> * 您可能需要安裝 [VC++ v14 Desktop Framework Package](https://docs.microsoft.com/troubleshoot/cpp/c-runtime-packages-desktop-bridge#how-to-install-and-update-desktop-framework-packages)。
>   這僅在較舊的 Windows 10 組建上且出現缺少 framework 套件錯誤時需要安裝。
> * Terminal 不會在新版本釋出時自動更新，因此您需要定期安裝最新版本來獲取所有最新修復與改進！

#### 透過 Windows 套件管理員 CLI（又稱 winget）

[winget](https://github.com/microsoft/winget-cli) 使用者可以透過安裝 `Microsoft.WindowsTerminal` 套件下載並安裝最新版本的 Terminal：

```powershell
winget install --id Microsoft.WindowsTerminal -e
```

> [!NOTE]
> 相依性支援於 WinGet 版本 [1.6.2631 或更新版本](https://github.com/microsoft/winget-cli/releases) 提供。若要安裝 1.18 或更新版本的 Terminal 穩定版，請確保您擁有最新版 WinGet 用戶端。

#### 透過 Chocolatey（非官方）

[Chocolatey](https://chocolatey.org) 使用者可以透過安裝 `microsoft-windows-terminal` 套件下載並安裝最新版本的 Terminal：

```powershell
choco install microsoft-windows-terminal
```

若要使用 Chocolatey 升級 Windows Terminal，請執行下列指令：

```powershell
choco upgrade microsoft-windows-terminal
```

如果您在安裝/升級套件時遇到任何問題，請前往 [Windows Terminal 套件頁面](https://chocolatey.org/packages/microsoft-windows-terminal) 並依照 [Chocolatey 分級流程](https://chocolatey.org/docs/package-triage-process) 操作。

#### 透過 Scoop（非官方）

[Scoop](https://scoop.sh) 使用者可以透過安裝 `windows-terminal` 套件來下載並安裝最新版本的 Terminal：

```powershell
scoop bucket add extras
scoop install windows-terminal
```

若要使用 Scoop 更新 Windows Terminal，請執行下列指令：

```powershell
scoop update windows-terminal
```

如果您在安裝/更新套件時遇到任何問題，請在 Scoop Extras bucket 儲存庫的 [問題頁面](https://github.com/lukesampson/scoop-extras/issues) 搜尋或回報。

---

## 安裝 Windows Terminal Canary
Windows Terminal Canary 是 Windows Terminal 的夜間建置版本。此版本包含我們 `main` 分支的最新程式碼，讓您能在功能進入 Windows Terminal Preview 前搶先體驗。

Windows Terminal Canary 是我們最不穩定的版本，因此您可能會發現一些我們尚未發現的錯誤。

Windows Terminal Canary 提供 App Installer 發行版與可攜式 ZIP 發行版。

App Installer 發行版支援自動更新。由於平台限制，此安裝程式僅適用於 Windows 11。

可攜式 ZIP 發行版則為可攜式應用程式。它不會自動更新，也不會自動檢查更新。此可攜式 ZIP 發行版適用於 Windows 10（19041+）與 Windows 11。

| 發行版       | 架構             | 連結                                                    |
|--------------|:----------------:|---------------------------------------------------------|
| App Installer| x64, arm64, x86  | [下載](https://aka.ms/terminal-canary-installer)        |
| 可攜式 ZIP   | x64              | [下載](https://aka.ms/terminal-canary-zip-x64)          |
| 可攜式 ZIP   | ARM64            | [下載](https://aka.ms/terminal-canary-zip-arm64)        |
| 可攜式 ZIP   | x86              | [下載](https://aka.ms/terminal-canary-zip-x86)          |

_深入了解 [Windows Terminal 發行版本型態](https://learn.microsoft.com/windows/terminal/distributions)。_

---

## Windows Terminal 路線圖

Windows Terminal 的規劃[描述於此](/doc/roadmap-2023.md)，並將隨專案進展不斷更新。

## 終端機與主控台概述

在深入程式碼前，請先花幾分鐘閱讀以下概述：

### Windows Terminal

Windows Terminal 是專為命令列使用者打造的全新、現代化、功能豐富且高生產力的終端機應用程式。它包含 Windows 命令列社群最常要求的多項功能，例如多分頁、豐富文字、全球化、可設定性、主題與樣式等。

此外，Terminal 也必須達到我們的效能目標，確保其快速高效，不會佔用過多記憶體或電力。

### Windows Console Host

Windows Console Host（`conhost.exe`）是 Windows 原生的命令列使用者體驗。它同時負責 Windows 命令列基礎架構、Windows Console API 伺服器、輸入引擎、繪圖引擎、使用者偏好設定等。此儲存庫中的主控台主機程式碼，即是 Windows 系統中 `conhost.exe` 的實際來源。

自 2014 年接手 Windows 命令列後，團隊為主控台新增了多項功能，包括背景透明度、行為選取、[ANSI / 虛擬終端機序列](https://en.wikipedia.org/wiki/ANSI_escape_code)、[24 位元色彩](https://devblogs.microsoft.com/commandline/24-bit-color-in-the-windows-console/)、[偽終端機（ConPTY）](https://devblogs.microsoft.com/commandline/windows-command-line-introducing-the-windows-pseudo-console-conpty/)等。

然而，由於 Windows Console 的主要目標是維持向後相容，我們無法新增社群（與團隊）多年來期望的許多功能，包括分頁、Unicode 文字和表情符號等。

這些限制促使我們打造全新的 Windows Terminal。

> 您可以在[這系列部落格文章](https://devblogs.microsoft.com/commandline/windows-command-line-backgrounder/)中，深入了解命令列的一般演進以及 Windows 命令列的發展歷程。

### 共用元件

在重新設計 Windows Console 的同時，我們大幅現代化其程式碼庫，將邏輯實體明確分離為模組與類別，導入關鍵擴充點，並以更安全高效的 [STL 容器](https://docs.microsoft.com/en-us/cpp/standard-library/stl-containers?view=vs-2022) 取代過去自製的集合與容器，利用 Microsoft 的 [Windows Implementation Libraries - WIL](https://github.com/Microsoft/wil) 讓程式碼更簡單且安全。

這次重構讓主控台的多個關鍵元件可供任何 Windows 終端機實作重複使用，包含全新基於 DirectWrite 的文字排版與繪圖引擎、可儲存 UTF-16 與 UTF-8 的文字緩衝區、VT 分析器/發送器等。

### 建立全新的 Windows Terminal

在規劃新 Windows Terminal 應用程式時，我們探索並評估了多種方法與技術棧。最終我們決定繼續投資於現有的 C++ 程式碼庫，如此便能在現有主控台與新終端機中重複使用上述現代化元件。此外，我們也意識到這樣可以將 Terminal 的核心建構為可重用的 UI 控制項，讓其他人能納入自己的應用程式中。

這項工作的成果即包含於本儲存庫，並以 Windows Terminal 應用程式形式發佈於 Microsoft Store，或可[直接自本儲存庫下載發行版本](https://github.com/microsoft/terminal/releases)。

---

## 資源

如需 Windows Terminal 的更多資訊，您可能會對以下資源感興趣：

* [命令列部落格](https://devblogs.microsoft.com/commandline)
* [命令列背景部落格系列](https://devblogs.microsoft.com/commandline/windows-command-line-backgrounder/)
* Windows Terminal 發表會：[Terminal "Sizzle Video"](https://www.youtube.com/watch?v=8gw0rXPMMPE&list=PLEHMQNlPj-Jzh9DkNpqipDGCZZuOwrQwR&index=2&t=0s)
* Windows Terminal 發表會：[Build 2019 Session](https://www.youtube.com/watch?v=KMudkRcwjCw)
* Run As Radio：[第 645 集 - Windows Terminal 與 Richard Turner](https://www.runasradio.com/Shows/Show/645)
* Azure Devops Podcast：[第 54 集 - Kayla Cinnamon 與 Rich Turner 談 Windows Terminal 團隊 DevOps](http://azuredevopspodcast.clear-measure.com/kayla-cinnamon-and-rich-turner-on-devops-on-the-windows-terminal-team-episode-54)
* Microsoft Ignite 2019 專題：[現代化 Windows 命令列：Windows Terminal - BRK3321](https://myignite.techcommunity.microsoft.com/sessions/81329?source=sessions)

---

## 常見問題

### 我編譯並執行了新 Terminal，但它看起來就像舊主控台

原因：您在 Visual Studio 啟動了錯誤的方案。

解決方法：請確保您在 Visual Studio 中建置並部署的是 `CascadiaPackage` 專案。

> [!NOTE]
> `OpenConsole.exe` 僅是本地建置的 `conhost.exe`，也就是經典的 Windows Console，負責主機 Windows 命令列基礎架構。Windows Terminal 會用 OpenConsole 來與命令列應用程式連線與通訊（透過 [ConPty](https://devblogs.microsoft.com/commandline/windows-command-line-introducing-the-windows-pseudo-console-conpty/)）。

---

## 文件

所有專案文件皆位於 [aka.ms/terminal-docs](https://aka.ms/terminal-docs)。如果您想貢獻文件，請於 [Windows Terminal Documentation 儲存庫](https://github.com/MicrosoftDocs/terminal) 提交拉取請求。

---

## 參與貢獻

我們很高興能與您——這個優秀的社群——一起建構並強化 Windows Terminal！

***在開始進行功能/修正前***，請閱讀並遵循我們的 [貢獻者指南](./CONTRIBUTING.md)，以避免不必要或重複的努力。

## 與團隊溝通

與團隊聯絡最簡單的方式是透過 GitHub 問題單。

請提交新的問題單、功能需求與建議，但**請務必先搜尋類似的已開啟/已關閉問題單**，再建立新問題。

如果您想詢問不值得開新問題（暫時）的問題，歡迎透過 Twitter 聯繫我們：

* Christopher Nguyen，產品經理：[[@nguyen_dows](https://twitter.com/nguyen_dows)]
* Dustin Howett，工程主管：[[@dhowett](https://twitter.com/DHowett)]
* Mike Griese，高級開發人員：[[@zadjii@mastodon.social](https://mastodon.social/@zadjii)]
* Carlos Zamora，開發人員：[[@cazamor_msft](https://twitter.com/cazamor_msft)]
* Pankaj Bhojwani，開發人員
* Leonard Hecker，開發人員：[[@LeonardHecker](https://twitter.com/LeonardHecker)]

## 開發人員指南

## 先決條件

您可以用下列兩種方式之一設定環境來建置 Terminal：

### 使用 WinGet 組態檔

複製儲存庫後，您可以使用 [WinGet 組態檔](https://learn.microsoft.com/en-us/windows/package-manager/configuration/#use-a-winget-configuration-file-to-configure-your-machine) 來設定您的環境。[預設組態檔](.config/configuration.winget) 會安裝 Visual Studio 2022 Community 與所有必要工具。在 [.config](.config) 目錄中還有兩個組態檔變體，分別適用於 Visual Studio 2022 的 Enterprise 與 Professional 版本。要執行預設組態檔，您可以在檔案總管中雙擊，或執行以下指令：

```powershell
winget configure .config\configuration.winget
```

### 手動設定

* 您必須在 Windows 10 2004（組建 >= 10.0.19041.0）或更新版本上執行 Windows Terminal
* 您必須[在 Windows 設定應用程式中啟用開發人員模式](https://docs.microsoft.com/en-us/windows/uwp/get-started/enable-your-device-for-development)，以便本機安裝與執行 Windows Terminal
* 您必須安裝 [PowerShell 7 或更新版本](https://github.com/PowerShell/PowerShell/releases/latest)
* 您必須安裝 [Windows 11 (10.0.22621.0) SDK](https://developer.microsoft.com/en-us/windows/downloads/windows-sdk/)
* 您必須安裝 [VS 2022](https://visualstudio.microsoft.com/downloads/)
* 您必須透過 VS Installer 安裝下列工作負載。注意：在 VS 2022 中開啟方案時，系統會[自動提示安裝缺少元件](https://devblogs.microsoft.com/setup/configure-visual-studio-across-your-organization-with-vsconfig/)：
  * 使用 C++ 進行桌面開發
  * 通用 Windows 平台開發
  * **以下個別元件**
    * C++ (v143) 通用 Windows 平台工具
* 您必須安裝 [.NET Framework Targeting Pack](https://docs.microsoft.com/dotnet/framework/install/guide-for-developers#to-install-the-net-framework-developer-pack-or-targeting-pack) 以建置測試專案

## 編譯程式碼

可在 Visual Studio 內建置 OpenConsole.sln，或於命令列使用 **/tools** 目錄下的便利指令碼與工具：

### 在 PowerShell 中編譯

```powershell
Import-Module .\tools\OpenConsole.psm1
Set-MsBuildDevEnvironment
Invoke-OpenConsoleBuild
```

### 在 Cmd 中編譯

```shell
.\tools\razzle.cmd
bcz
```

## 執行與除錯

若要在 VS 中除錯 Windows Terminal，請於方案總管中右鍵點擊 `CascadiaPackage`，選擇內容。在「除錯」選單中，將「應用程式處理程序」與「背景工作處理程序」都設為「僅限原生」。

此後即可按 <kbd>F5</kbd> 編譯並除錯 Terminal 專案。請務必選擇「x64」或「x86」平台——Terminal 不支援「Any Cpu」（因為 Terminal 是 C++ 應用程式，不是 C#）。

> 👉 您**無法**直接執行 WindowsTerminal.exe 來啟動 Terminal。詳情請參閱
> [#926](https://github.com/microsoft/terminal/issues/926),
> [#4043](https://github.com/microsoft/terminal/issues/4043)

### 程式設計指引

請參閱以下有關我們程式設計實踐的簡要文件。

> 👉 如果您覺得這些文件有遺漏，歡迎在儲存庫內任何位置貢獻或撰寫新的文件！

我們會隨著專案進展，逐步補充這些指南，以協助大家成為有效的貢獻者。

* [程式設計風格](./doc/STYLE.md)
* [程式碼組織](./doc/ORGANIZATION.md)
* [舊程式碼庫中的例外狀況](./doc/EXCEPTIONS.md)
* [WIL 相關的智慧指標與巨集](./doc/WIL.md)

---

## 行為準則

本專案採用 [Microsoft 開源行為準則][conduct-code]。欲瞭解更多資訊，請參閱[行為準則常見問答][conduct-FAQ]，或將其他問題與意見寄送至 [opencode@microsoft.com][conduct-email]。

[conduct-code]: https://opensource.microsoft.com/codeofconduct/
[conduct-FAQ]: https://opensource.microsoft.com/codeofconduct/faq/
[conduct-email]: mailto:opencode@microsoft.com
[store-install-link]: https://aka.ms/terminal

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---
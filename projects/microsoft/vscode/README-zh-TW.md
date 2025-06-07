# Visual Studio Code - 開源版（「Code - OSS」）

[![功能請求](https://img.shields.io/github/issues/microsoft/vscode/feature-request.svg)](https://github.com/microsoft/vscode/issues?q=is%3Aopen+is%3Aissue+label%3Afeature-request+sort%3Areactions-%2B1-desc)
[![錯誤回報](https://img.shields.io/github/issues/microsoft/vscode/bug.svg)](https://github.com/microsoft/vscode/issues?utf8=✓&q=is%3Aissue+is%3Aopen+label%3Abug)
[![Gitter](https://img.shields.io/badge/chat-on%20gitter-yellow.svg)](https://gitter.im/Microsoft/vscode)

## 儲存庫

本儲存庫（「`Code - OSS`」）是我們（Microsoft）與社群共同開發 [Visual Studio Code](https://code.visualstudio.com) 產品的地方。在這裡，我們不僅處理原始碼與議題，也會發佈我們的[開發路線圖](https://github.com/microsoft/vscode/wiki/Roadmap)、[每月迭代計劃](https://github.com/microsoft/vscode/wiki/Iteration-Plans)以及[最終階段計劃](https://github.com/microsoft/vscode/wiki/Running-the-Endgame)。此原始碼以標準的 [MIT 授權](https://github.com/microsoft/vscode/blob/main/LICENSE.txt) 提供給所有人使用。

## Visual Studio Code

<p align="center">
  <img alt="VS Code in action" src="https://user-images.githubusercontent.com/35271042/118224532-3842c400-b438-11eb-923d-a5f66fa6785a.png">
</p>

[Visual Studio Code](https://code.visualstudio.com) 是一個基於 `Code - OSS` 儲存庫、經 Microsoft 客製化後以傳統 [Microsoft 產品授權](https://code.visualstudio.com/License/) 發行的發行版。

[Visual Studio Code](https://code.visualstudio.com) 結合了程式碼編輯器的簡單性與開發人員核心編輯－建置－除錯循環所需的功能。它提供了全面的程式碼編輯、導覽與理解支援，輕量級的除錯功能、豐富的擴充模型，以及與現有工具的輕量級整合。

Visual Studio Code 每月都會推出新功能與錯誤修正。你可以在 [Visual Studio Code 官方網站](https://code.visualstudio.com/Download) 下載 Windows、macOS 和 Linux 版本。若想每日取得最新版本，請安裝 [Insiders 版本](https://code.visualstudio.com/insiders)。

## 貢獻

你可以透過多種方式參與此專案，例如：

* [回報錯誤與提交功能請求](https://github.com/microsoft/vscode/issues)，並協助我們進行驗證
* 審查[原始碼變更](https://github.com/microsoft/vscode/pulls)
* 審查[文件](https://github.com/microsoft/vscode-docs)，並針對錯字或新增內容提交 pull requests

如果你有興趣修復問題並直接貢獻原始碼，請參閱[如何貢獻](https://github.com/microsoft/vscode/wiki/How-to-Contribute)文件，其中涵蓋以下內容：

* [如何從原始碼建置與執行](https://github.com/microsoft/vscode/wiki/How-to-Contribute)
* [開發流程，包括除錯與執行測試](https://github.com/microsoft/vscode/wiki/How-to-Contribute#debugging)
* [程式碼撰寫規範](https://github.com/microsoft/vscode/wiki/Coding-Guidelines)
* [提交 pull requests](https://github.com/microsoft/vscode/wiki/How-to-Contribute#pull-requests)
* [尋找可參與的議題](https://github.com/microsoft/vscode/wiki/How-to-Contribute#where-to-contribute)
* [協助翻譯](https://aka.ms/vscodeloc)

## 反饋

* 在 [Stack Overflow](https://stackoverflow.com/questions/tagged/vscode) 提問
* [請求新功能](CONTRIBUTING.md)
* 為[熱門功能請求](https://github.com/microsoft/vscode/issues?q=is%3Aopen+is%3Aissue+label%3Afeature-request+sort%3Areactions-%2B1-desc)投票
* [提交問題](https://github.com/microsoft/vscode/issues)
* 在 [GitHub Discussions](https://github.com/microsoft/vscode-discussions/discussions) 或 [Slack](https://aka.ms/vscode-dev-community) 與擴充套件作者社群交流
* 追蹤 [@code](https://twitter.com/code) 並告訴我們你的想法！

各反饋管道的說明及其他社群主導管道資訊，請參閱我們的 [wiki](https://github.com/microsoft/vscode/wiki/Feedback-Channels)。

## 相關專案

許多 VS Code 的核心元件與擴充功能都在 GitHub 上擁有獨立的儲存庫。例如，[node 除錯介接器](https://github.com/microsoft/vscode-node-debug) 與 [mono 除錯介接器](https://github.com/microsoft/vscode-mono-debug) 各自分開維護。完整列表請參閱我們 [wiki](https://github.com/microsoft/vscode/wiki) 上的 [相關專案](https://github.com/microsoft/vscode/wiki/Related-Projects) 頁面。

## 內建擴充功能

VS Code 包含一組位於 [extensions](extensions) 資料夾中的內建擴充功能，包括多種語言的文法與程式碼片段。為某語言提供豐富語言支援（如程式碼補全、跳至定義）的擴充功能會以 `language-features` 作為後綴。例如，`json` 擴充功能提供 `JSON` 語法著色，`json-language-features` 擴充功能則提供 `JSON` 的豐富語言支援。

## 開發容器

本儲存庫包含 Visual Studio Code Dev Containers / GitHub Codespaces 的開發容器。

* 對於 [Dev Containers](https://aka.ms/vscode-remote/download/containers)，請使用 **Dev Containers: Clone Repository in Container Volume...** 指令，這會在 macOS 和 Windows 上建立 Docker volume 以提升磁碟 I/O 效能。
  * 如果你已安裝 VS Code 與 Docker，也可以點擊[這裡](https://vscode.dev/redirect?url=vscode://ms-vscode-remote.remote-containers/cloneInVolume?url=https://github.com/microsoft/vscode)開始。這將自動安裝 Dev Containers 擴充功能（如有需要），將原始碼複製至容器 volume，並啟動可用的開發容器。

* 對於 Codespaces，請在 VS Code 中安裝 [GitHub Codespaces](https://marketplace.visualstudio.com/items?itemName=GitHub.codespaces) 擴充功能，並使用 **Codespaces: Create New Codespace** 指令。

Docker / Codespace 至少需有 **4 核心與 6 GB 記憶體（建議 8 GB）** 以執行完整建置。詳細資訊請參閱 [development container README](.devcontainer/README.md)。

## 行為準則

本專案採用 [Microsoft 開源行為準則](https://opensource.microsoft.com/codeofconduct/)。欲了解更多資訊，請參閱 [行為準則常見問答](https://opensource.microsoft.com/codeofconduct/faq/)，或透過 [opencode@microsoft.com](mailto:opencode@microsoft.com) 聯絡我們。

## 授權

Copyright (c) Microsoft Corporation. All rights reserved.

依 [MIT](LICENSE.txt) 授權條款授權。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---
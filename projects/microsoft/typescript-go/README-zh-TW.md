# TypeScript 7

[不確定這是什麼？請閱讀公告貼文！](https://devblogs.microsoft.com/typescript/typescript-native-port/)

## 預覽版

預覽版本可在 npm 以 `@typescript/native-preview` 取得。

```sh
npm install @typescript/native-preview
npx tsgo # 使用方式與 tsc 相同。
```

預覽版 VS Code 擴充功能可於 [VS Code 市集取得](https://marketplace.visualstudio.com/items?itemName=TypeScriptTeam.native-preview)。

若要使用此擴充功能，請在 VS Code 設定中加入：

```json
{
    "typescript.experimental.useTsgo": true
}
```

## 如何建置與執行

本儲存庫使用 [Go 1.24 或更高版本](https://go.dev/dl/)、[Rust 1.85 或更高版本](https://www.rust-lang.org/tools/install)、[Node.js 與 npm](https://nodejs.org/)，以及 [`hereby`](https://www.npmjs.com/package/hereby)。

為了測試與程式碼產生，本儲存庫包含指向主要 TypeScript 儲存庫的 git 子模組，指向被移植的提交。
在複製時，請使用子模組一併複製：

```sh
git clone --recurse-submodules https://github.com/microsoft/typescript-go.git
```

如果你已經複製了儲存庫，可以使用以下指令初始化子模組：

```sh
git submodule update --init --recursive
```

有了子模組並執行 `npm ci` 後，你可以透過 `hereby` 執行各項任務，方式與 TypeScript 儲存庫類似：

```sh
hereby build          # 驗證專案是否能成功建置
hereby test           # 執行所有測試
hereby install-tools  # 安裝額外工具，如 linters
hereby lint           # 執行所有 linters
hereby format         # 格式化所有程式碼
hereby generate       # 產生所有 Go 程式碼（如診斷資訊，已提交至 repo）
```

其他任務仍在持續開發中。

`hereby` 並非必要，可直接使用一般的 `go` 工具（例如 `go build`、`go test ./...`）如預期般運作。
`hereby` 任務僅為習慣 TypeScript 儲存庫流程者提供便利。

### 執行 `tsgo`

執行 `hereby build` 後，你可以執行 `built/local/tsgo`，其行為大致與 `tsc` 相同。

### 執行 LSP 原型

若要在不全域安裝擴充功能的情況下除錯並執行 VS Code 擴充功能：

* 在儲存庫工作區中啟動 VS Code（`code .`）
* 將 `.vscode/launch.template.json` 複製為 `.vscode/launch.json`
* 按 <kbd>F5</kbd>（或從命令面板選擇 `Debug: Start Debugging`）

這會啟動一個新的 VS Code 實例，並以 Corsa LS 為後端。如果設置正確，當你打開 TypeScript 或 JavaScript 檔案時，應會在狀態列看到 "tsgo"：

![LSP 原型截圖](https://raw.githubusercontent.com/microsoft/typescript-go/main/.github/ls-screenshot.png)


## 目前有哪些功能可用？

此專案仍在開發中，尚未與 TypeScript 完全功能等同。可能存在錯誤。請在提出新問題或假設為有意更動前，仔細檢查下列表格。

| 功能 | 狀態 | 備註 |
|---------|--------|-------|
| 程式建立 | 完成 | 與 TS5.8 相同的檔案及模組解析。尚未支援所有解析模式。 |
| 解析/掃描 | 完成 | 與 TS5.8 完全相同的語法錯誤 |
| 命令列與 `tsconfig.json` 解析 | 大致完成 | 進入點目前略有不同 |
| 型別解析 | 完成 | 與 TS5.8 相同的型別 |
| 型別檢查 | 完成 | 與 TS5.8 相同的錯誤、位置及訊息。錯誤訊息中的型別顯示方式可能不同（開發中） |
| JavaScript 特有推斷及 JS Doc | 尚未準備好 | - |
| JSX | 完成 | - |
| 宣告產出 | 開發中 | 大部分常用功能已實現，部分邊緣案例及功能旗標尚未處理 |
| 程式碼產出（JS 輸出） | 開發中 | `target: esnext` 支援良好，其它目標可能有缺口 |
| 監看模式 | 原型 | 監看檔案並重新建置，尚無增量檢查 |
| 建置模式 / 專案參考 | 尚未準備好 | - |
| 增量建置 | 尚未準備好 | - |
| 語言服務（LSP） | 原型 | 僅有基本功能（錯誤、懸停、跳至定義）。即將支援更多功能 |
| API | 尚未準備好 | - |

說明：

 * **完成** 或 "believed done"：目前未發現重大缺失或待辦事項。歡迎回報錯誤
 * **開發中**：目前正在開發中；部分功能可用，部分尚不可用。歡迎回報 panic，但請勿回報其他問題
 * **原型**：僅為概念驗證，請勿回報錯誤
 * **尚未準備好**：尚未開始，或尚遠未完成，建議暫勿嘗試

## 其他說明

長期來看，預期此儲存庫及其內容將合併至 `microsoft/TypeScript`。
因此，typescript-go 的儲存庫與問題追蹤器最終將關閉，請據此斟酌討論／回報問題。

關於與 TypeScript 5.7 之間有意為之的變更，請參閱 CHANGES.md。

## 貢獻

本專案歡迎貢獻及建議。大多數貢獻需你同意
貢獻者授權協議（CLA），聲明你有權利，且確實授權我們
使用你的貢獻。詳情請參閱 [Contributor License Agreements](https://cla.opensource.microsoft.com)。

當你提交 Pull Request 時，CLA bot 會自動判斷你是否需要簽署 CLA，並在 PR 上做出相應標記（如狀態檢查、留言）。請依照 bot 提示操作。只需於所有使用我們 CLA 的 repo 簽署一次即可。

本專案遵循 [Microsoft 開源行為準則](https://opensource.microsoft.com/codeofconduct/)。
更多資訊請參閱 [行為準則 FAQ](https://opensource.microsoft.com/codeofconduct/faq/) 或聯絡 [opencode@microsoft.com](mailto:opencode@microsoft.com) 以取得更多問題或建議。

## 商標

本專案可能包含其他專案、產品或服務的商標或標誌。授權使用 Microsoft
商標或標誌需遵守並符合
[Microsoft 商標與品牌指南](https://www.microsoft.com/legal/intellectualproperty/trademarks/usage/general)。
於本專案修改版中使用 Microsoft 商標或標誌時，不得造成混淆或暗示 Microsoft 贊助。
任何第三方商標或標誌的使用，皆受其各自政策約束。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---
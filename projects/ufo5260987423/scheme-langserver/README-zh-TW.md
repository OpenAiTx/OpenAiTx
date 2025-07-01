![](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/logo-no-background.png)
# Scheme-langserver
[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/ufo5260987423/scheme-langserver)

你可以閱讀我的[論文](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf)，引用方式如下：
> WANG, Z. (2025, May 12). Scheme-langserver: Treat Scheme Code Editing as the First-Class Concern. The 18th European Lisp Symposium (ELS`25), Zurich. https://doi.org/10.5281/zenodo.15384882

由於 GitHub 可能會封鎖中國的 IP 位址，我必須將此倉庫複製到[這裡](https://codeberg.org/ufo5260987423/scheme-langserver)以及[這裡](https://gitee.com/ufo5260987423/scheme-langserver)。我會持續更新所有倉庫，但無法保證。現在我也與 [XmacsLabs](https://github.com/XmacsLabs) 合作，你也可以在[這裡](https://github.com/XmacsLabs/scheme-langserver)找到分支。

<video src="https://github.com/user-attachments/assets/893bba98-6709-4fac-a4d3-dc7b6aab46fb" controls="controls" width="500" height="300"></video>

**現在，VSCode 已經可以使用 scheme-langserver！** 請參考[這裡](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)。

>注意：scheme-langserver 中有許多 bug。我正在修復並呼籲社群協助。請耐心等候。

>注意：你可以在[這裡](https://ufo5260987423.github.io/scheme-langserver/doc/analysis/type-inference-result)找到自動生成的型別資訊。這目前主要用於下一階段的開發（可能包含 AKKU）和除錯。

實現自動補全、跳轉定義或懸停顯示文件等支持功能，對程式設計來說是一項重大工程。然而，與 java、python、javascript 和 c 等其他語言相比，lisp 語言的語言伺服器協定實現幾乎都是在真空中完成的。[Geiser](https://gitlab.com/emacs-geiser)、[racket langserver](https://github.com/jeapostrophe/racket-langserver) 和 [swish-lint](https://github.com/becls/swish-lint) 等，他們的工作都基於 `repl`（Read-Eval-Print Loop）或關鍵字分詞器，而不是實際程式分析。例如，如果程式設計師正在編寫一個尚未完成的專案，代碼尚未完全可執行，[Geiser](https://gitlab.com/emacs-geiser) 或其他工具只能補全由 `environment-symbols` 程序（針對 [Chez](https://cisco.github.io/ChezScheme/)）列出的頂層綁定識別符，或僅補全符號而非識別符。這意味著對於區域綁定和未完成的代碼，雖然對程式分析的努力應該是最重要的，[Geiser](https://gitlab.com/emacs-geiser) 及其同類工具對於識別識別符的有效作用域毫無幫助。類似情況也發生於跳轉定義及其他多種功能。

主要原因在於，對於 scheme 及其他 lisp 方言，它們大量的資料集和靈活的控制結構使得程式分析成為一大挑戰。尤其是巨集，scheme 似乎主要用於天才和元/巨集編程。但我認為並非如此。如果有更好的程式設計環境，Scheme 可以做出許多有趣的事情。你現在可以[**從這裡開始**](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)。

這個套件是一個語言伺服器協定實現，協助 Scheme 程式設計。它提供補全、定義和型別推斷等功能。這些功能是基於靜態程式碼分析，依據 [r6rs 標準](http://www.r6rs.org/) 及一些針對未完成代碼的明確規則建立的。此套件及其相關庫已經或即將以 [Akku](https://akkuscm.org/) 發布，Akku 是 Scheme 的套件管理器。

本套件也已經在 [Chez Scheme](https://cisco.github.io/ChezScheme/) 9.4 與 9.5 版本測試過。針對 10.0.0 版的詳細測試會在我升級筆電作業系統後進行。

我只是在閒暇時間做這個開源專案，也能為社群貢獻很多精彩的想法，例如將資料流分析嵌入 scheme-langserver 或其他事情。我持續尋求更多捐贈或資助。你可以透過[這個 patreon 頁面](https://www.patreon.com/PoorProgrammer/membership)或[愛發電](https://afdian.com/a/ufo5260987423)捐款支持。

## 編譯、安裝與設定請見[這裡](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)

## 近期狀態
我會持續修復 bug、分析程式、並為我的自製型別推斷系統巨著收集資料。這可能需要我約一年的時間。後續開發包括 [VScode](https://code.visualstudio.com/) 外掛與資料流分析。但實際上，我目前將這個開源專案當作兼職工作，無法保證時程。

## 版本發佈
1.2.9 現在，享受型別推斷的樂趣吧！

先前的版本請參考[此檔案](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/release-log.md)。

### 功能特色
1. 支援頂層與區域識別符綁定補全。
![Top-level and local identifiers binding](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion.png "Top-level and local identifiers binding")
2. 跳轉定義。
![Goto definition with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/definition.png "Goto Definition with telescope.nvim")
3. 相容套件管理器：Akku。
4. 檔案變更同步及對應索引更新。
5. 懸停提示。
6. 參考搜尋與文件高亮（文件範圍內的參考）。
![Find references with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/find-references.png "Find references with telescope.nvim")
7. 文件符號。
![Find document symbols with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/document-symbol.png "find document symbols with telescope.nvim")
8. 捕捉 *-syntax（define-syntax、let-syntax 等）型區域識別符綁定。
9. 跨平台平行索引。
10. 自製原始碼註釋器，相容於 .sps 檔案。
11. API 請求的 peephole 最佳化與可掛起任務。
12. 內建自製 DSL 直譯器的型別推斷（我非常自豪！）。且現已整合進自動補全功能。如下圖所示，"length-b" 和 "length-a" 具有 "integer?" 型別，會優先推薦，因為它們能匹配 "<=" 所需的參數型別。
![Autocompletion with type inference](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion-with-type-inference.png "Autocompletion with type inference")
測試可以證明此結果，只需執行 `scheme --script tests/protocol/apis/test-completion.sps`，日誌檔 `scheme-langserver.log` 會包含如下結果：
```bash
send-message
2023 11 21 11 26 41 967266866
{"jsonrpc":"2.0","id":"3","result":[{"label":"length-a"},{"label":"length-b"},{"label":"lambda"},{"label":"latin-1-codec"},{"label":"lcm"},{"label":"least-fixnum"},{"label":"length"},{"label":"let"},{"label":"let*"},{"label":"let*-values"},{"label":"let-syntax"},{"label":"let-values"},{"label":"letrec"},{"label":"letrec*"},{"label":"letrec-syntax"},{"label":"lexical-violation?"},{"label":"list"},{"label":"list->string"},{"label":"list->vector"},{"label":"list-ref"},{"label":"list-sort"},{"label":"list-tail"},{"label":"list?"},{"label":"log"},{"label":"lookahead-char"},{"label":"lookahead-u8"}]}
```
13. 跨檔案副檔名（如 scm、ss、sps、sls、sld）識別符捕捉的抽象直譯器。

### 待辦事項
14. 重新命名功能。
15. 完全相容於 [r6rs 標準](http://www.r6rs.org/)。
16. 步進式巨集展開器：其實我已經實作一個了，並想要讓它成為自定義巨集內識別符綁定的重要步驟。但我發現這遠比我想像的困難，而這個展開器我也不確定能否發揮作用。
17. 程式碼執行。
18. 程式碼診斷。
19. 增加跨語言語意支援。嗯，java、c、python 及其他語言是否可透過 AST 轉換器支援？
20. 將表達式/語句抽取為子程序。

## 待辦：貢獻指引

## 除錯

### 如何除錯
https://www.scheme.com/debug/debug.html#g1

### 輸出日誌
依照[編譯](#building)、[Lunar Vim 安裝](#installation-for-lunarvim)及[VScode 安裝](#todo-installation-for-vscode)的說明，如果有人想開發或記錄日誌，只需增加 `path-to-log-file` 並重寫 `~/.local/share/lunarvim/site/pack/packer/start/nvim-lspconfig/lua/lspconfig/server_configurations/scheme_langserver.lua`，如下所示：
```lua
local util = require 'lspconfig.util'
local bin_name = '{path-to-run}'
local cmd = { bin_name ,"path-to-log-file"}

return {
  default_config = {
    cmd = cmd,
    filetypes = { 'scheme' },
    root_dir = util.find_git_ancestor,
    single_file_support = true,
  },
  docs = {
    description = [[
https://github.com/ufo5260987423/scheme-langserver
`scheme-langserver`, a language server protocol implementation for scheme
]]   ,
  },
}
```
### 使用 Log 進行重現
結合上述的 [輸出日誌](#output-log)，你可以用 `tests/log-debug.sps` 重現 bug：
1. 將 `{path-to-log}`（通常是 `~/scheme-langserver.log`）重新命名為 `~/ready-for-analyse.log`；
2. 執行 `scheme --script tests/log-debug.sps`。如果你想重現多執行緒環境，也可以執行 `scheme --script tests/log-debug.sps`。

## 測試
幾乎所有關鍵程序與 API 都有測試。我的工作雖然很粗糙但很實用，也許你會想在 `tests` 目錄中看看我做了什麼，或直接在 `{scheme-langserver-root-directory}` 執行下列指令：
``` bash
bash test.sh
```
>注意
在多執行緒環境下進行測試很困難。所以目前的測試著重於單執行緒。

## 將 Scheme-langserver 用於其他用途
### GIMP 的 Script-Fu
Script-Fu 基於一種稱為 Scheme 的直譯式語言，並透過使用能與 GIMP 內部功能互動的函式來運作。以[這個頁面](https://dalelane.co.uk/blog/?p=628)的 script 為例，你可以將 scheme-langserver 應用於副檔名為 "SCM" 的 script 檔案。

### 其他

嗯，我對 [OMN (Opusmodus Notation)](https://opusmodus.com/) 和 AutoLisp 也很感興趣。但我還有很多事情要做。

## 程式碼行數統計
```bash
find . -name "*.sls" ! -path "./.akku/*" |xargs wc -l
```
## 詳細文件
1. [Scheme-langserver: Treat Scheme Code Editing as the First-Class Concern](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf)。
2. [Catching identifier bindings](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/identifier.md)
3. [Synchronizing](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/util/synchronize.md)
4. [Type inference](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.md)，~~[類型推斷](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.cn.md)~~（已棄用，目前正在為其撰寫中文書籍）
5. [API 分析](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/protocol/analysis.md)
6. [Deepwiki](https://deepwiki.com/ufo5260987423/scheme-langserver)

## Star 歷史

[![Star History Chart](https://api.star-history.com/svg?repos=ufo5260987423/scheme-langserver&type=Date)](https://star-history.com/#ufo5260987423/scheme-langserver)

## 貢獻者

![Contributors](https://contrib.rocks/image?repo=ufo5260987423/scheme-langserver)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-01

---
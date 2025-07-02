<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

![](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/logo-no-background.png)
# Scheme-langserver
[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/ufo5260987423/scheme-langserver)

你可以閱讀我的[論文](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf)，引用方式如下
> WANG, Z. (2025, May 12). Scheme-langserver: Treat Scheme Code Editing as the First-Class Concern. The 18th European Lisp Symposium (ELS`25), Zurich. https://doi.org/10.5281/zenodo.15384882

由於 GitHub 可能會封鎖中國 IP 地址，我必須將此倉庫複製到[這裡](https://codeberg.org/ufo5260987423/scheme-langserver)和[這裡](https://gitee.com/ufo5260987423/scheme-langserver)。我會持續同步更新所有倉庫，但無法保證。現在我也與[XmacsLabs](https://github.com/XmacsLabs)合作，你也可以在[這裡](https://github.com/XmacsLabs/scheme-langserver)找到分支。

<video src="https://github.com/user-attachments/assets/893bba98-6709-4fac-a4d3-dc7b6aab46fb" controls="controls" width="500" height="300"></video>

**現在，VSCode 可以使用 scheme-langserver！** 請參見[這裡](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)。

>注意：scheme-langserver 還有很多很多 bug。我正在修復並呼籲社群協助。請耐心等待。

>注意：你可以在[這裡](https://ufo5260987423.github.io/scheme-langserver/doc/analysis/type-inference-result)找到自動生成的型別資訊。它目前主要用於下一階段開發（可能包含 AKKU）和除錯。

實現自動補全、跳轉定義或懸停顯示文件等支援功能對於程式設計來說是一項重大工作。然而，與 java、python、javascript 和 c 等其他語言相比，lisp 語言的 language server protocol 實現幾乎是一片空白。[Geiser](https://gitlab.com/emacs-geiser)、[racket langserver](https://github.com/jeapostrophe/racket-langserver) 和 [swish-lint](https://github.com/becls/swish-lint) 等，它們的工作都基於 `repl`（Read-Eval-Print Loop）或關鍵詞分詞器，而不是基於程式分析。例如，如果開發者在一個尚未完成的專案中編碼，代碼無法完全執行，[Geiser](https://gitlab.com/emacs-geiser) 或其他工具僅能補全由 `environment-symbols` 程序（針對 [Chez](https://cisco.github.io/ChezScheme/)）列出的頂層綁定識別符，或只補全符號而非識別符。這意味著對於區域綁定和未完成的代碼，儘管程式分析本該最重要，[Geiser](https://gitlab.com/emacs-geiser) 及其同類工具對識別符作用域的辨識毫無幫助。類似情況也發生在跳轉定義和其他許多功能上。

主要原因在於，對於 scheme 和其他 lisp 方言來說，其豐富的資料集和靈活的控制結構使得程式分析成為一大挑戰。尤其是巨集，似乎 scheme 主要用於天才和元/巨集程式設計。但我並不這麼認為。如果有更好的程式開發環境，Scheme 可以做出很多有趣的事情。現在你可以[**從這裡開始**](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)。

這個套件是一個協助 Scheme 程式設計的 Language Server Protocol 實現。它提供補全、定義及型別推斷功能。這些功能建立在靜態程式碼分析基礎上，依據 [r6rs 標準](http://www.r6rs.org/)及部分對未完成代碼的顯然規則。此套件本身及相關函式庫已經或將通過 [Akku](https://akkuscm.org/) 發佈，Akku 是 Scheme 的套件管理器。

本套件也已經在 [Chez Scheme](https://cisco.github.io/ChezScheme/) 9.4 和 9.5 版本上測試過。對 10.0.0 版本的詳細測試將在我升級筆記型電腦作業系統後進行。

我僅在業餘時間做這個開源項目，也可以為社群貢獻很多精彩的想法，比如將資料流分析嵌入 scheme-langserver 等。我也持續尋求更多的捐贈或資助。你可以通過[這個 patreon 頁面](https://www.patreon.com/PoorProgrammer/membership)或[愛發電](https://afdian.com/a/ufo5260987423)進行捐贈。

## 編譯、安裝與配置請參見[這裡](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)

## 最新進展
我會繼續修 bug、分析效能、並收集自製型別推斷系統巨著的資料。這大約會花我一年的時間。未來開發還包括 [VScode](https://code.visualstudio.com/) 外掛和資料流分析。但實際上，現在這個開源項目被我設定為兼職，無法保證排程。

## 發佈
1.2.9 現在，享受型別推斷吧！

過往版本請參見[這個檔案](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/release-log.md)。

### 功能特點
1. 頂層和區域識別符綁定自動補全。
![Top-level and local identifiers binding](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion.png "Top-level and local identifiers binding")
2. 跳轉定義。
![Goto definition with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/definition.png "Goto Definition with telescope.nvim")
3. 相容套件管理器：Akku。
4. 檔案變動同步及對應索引更新。
5. 懸停顯示。
6. 參考搜尋及文件突顯（文件範圍內的參考）。
![Find references with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/find-references.png "Find references with telescope.nvim")
7. 文件符號。
![Find document symbols with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/document-symbol.png "find document symbols with telescope.nvim")
8. 捕捉 *-syntax（define-syntax、let-syntax 等）為基礎的區域識別符綁定。
9. 跨平台平行索引。
10. 自製原始碼註釋器，支援 .sps 檔案。
11. API 請求的視窗最佳化（可掛起的任務）。
12. 以自製 DSL 直譯器進行型別推斷（我對此非常自豪！）。現在已經嵌入自動補全。如下面圖示，「length-b」和「length-a」具有「integer?」型別，會因為匹配了「<=」所需的參數型別而排在推薦選項前列。
![Autocompletion with type inference](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion-with-type-inference.png "Autocompletion with type inference")
一個測試可以證明這個結果，只需執行 `scheme --script tests/protocol/apis/test-completion.sps`，日誌檔案 `scheme-langserver.log` 會包含如下結果：
```bash
send-message
2023 11 21 11 26 41 967266866
{"jsonrpc":"2.0","id":"3","result":[{"label":"length-a"},{"label":"length-b"},{"label":"lambda"},{"label":"latin-1-codec"},{"label":"lcm"},{"label":"least-fixnum"},{"label":"length"},{"label":"let"},{"label":"let*"},{"label":"let*-values"},{"label":"let-syntax"},{"label":"let-values"},{"label":"letrec"},{"label":"letrec*"},{"label":"letrec-syntax"},{"label":"lexical-violation?"},{"label":"list"},{"label":"list->string"},{"label":"list->vector"},{"label":"list-ref"},{"label":"list-sort"},{"label":"list-tail"},{"label":"list?"},{"label":"log"},{"label":"lookahead-char"},{"label":"lookahead-u8"}]}
```
13. 抽象直譯器支援 scm、ss、sps、sls、sld 等不同副檔名間的識別符捕捉。

### 待辦事項
14. 重新命名。
15. 完全相容 [r6rs 標準](http://www.r6rs.org/)。
16. 步進式巨集展開器：其實我已經實作了一個，想讓它成為捕捉自定義巨集內識別符綁定的關鍵步驟。現在發現這個捕捉比我想像的還難，這個展開器我還不知道該怎麼用。
17. 程式碼執行。
18. 代碼診斷。
19. 增加跨語言語意支持。那麼，Java、C、Python 以及許多其他語言是否能透過 AST 轉換器支援？
20. 將運算式/敘述抽取為程序。

## TODO: 貢獻指南

## 除錯

### 如何除錯
https://www.scheme.com/debug/debug.html#g1

### 輸出日誌
根據 [編譯](#building)、[Lunar Vim 安裝](#installation-for-lunarvim) 及 [VScode 安裝](#todo-installation-for-vscode) 的相關提示，如果有人想要進行開發並記錄日誌，只需新增 `path-to-log-file` 並重寫檔案 `~/.local/share/lunarvim/site/pack/packer/start/nvim-lspconfig/lua/lspconfig/server_configurations/scheme_langserver.lua` 如下：
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
`scheme-langserver`，一個 scheme 的語言伺服器協議實作
]]   ,
  },
}
```
### 日誌重現
有了上述的 [輸出日誌](#output-log)，你可以用 `tests/log-debug.sps` 來重現錯誤：
1. 將 `{path-to-log}`（通常是 `~/scheme-langserver.log`）重新命名為 `~/ready-for-analyse.log`；
2. 執行 `scheme --script tests/log-debug.sps`。如果你想重現多執行緒環境，也可以執行 `scheme --script tests/log-debug.sps`。

## 測試
幾乎所有的關鍵程序與 API 都已經過測試。我的工作雖然粗糙但很實用，也許你可以在 `tests` 目錄下找到我做過的事，或直接在 `{scheme-langserver-root-directory}` 執行以下指令：
``` bash
bash test.sh
```
>注意
在多執行緒環境下很難進行測試。因此，目前的測試主要集中在單執行緒上。

## 將 Scheme-langserver 用於其他用途
### GIMP 的 Script-Fu
Script-Fu 基於一種稱為 Scheme 的直譯語言，通過使用函數與 GIMP 內部函數互動。以[這個頁面](https://dalelane.co.uk/blog/?p=628)的腳本為例，你可以將 scheme-langserver 應用於副檔名為 "SCM" 的腳本檔案。

### 其他

嗯，我也對 [OMN (Opusmodus Notation)](https://opusmodus.com/) 和 AutoLisp 感興趣。但我還有很多事情要做。

## 代碼行數統計
```bash
find . -name "*.sls" ! -path "./.akku/*" |xargs wc -l
```
## 詳細文件
1. [Scheme-langserver: 將 Scheme 代碼編輯視為第一要務](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf)。
2. [捕獲識別符繫結](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/identifier.md)
3. [同步機制](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/util/synchronize.md)
4. [型別推斷](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.md)，~~[類型推斷（中文）](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.cn.md)~~（已棄用，且我正在寫一本相關的中文書籍）
5. [API 分析](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/protocol/analysis.md)
6. [Deepwiki](https://deepwiki.com/ufo5260987423/scheme-langserver)

## Star 歷史

[![Star History Chart](https://api.star-history.com/svg?repos=ufo5260987423/scheme-langserver&type=Date)](https://star-history.com/#ufo5260987423/scheme-langserver)

## 貢獻者

![Contributors](https://contrib.rocks/image?repo=ufo5260987423/scheme-langserver)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---
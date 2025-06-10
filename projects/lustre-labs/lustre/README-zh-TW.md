<h1 align="center">Lustre</h1>

<div align="center">
  ✨ <strong>讓你的前端閃耀光芒</strong> ✨
</div>

<div align="center">
  一個用 Gleam 構建 Web 應用的框架！
</div>

<br />

<div align="center">
  <a href="https://hex.pm/packages/lustre">
    <img src="https://img.shields.io/hexpm/v/lustre"
      alt="Available on Hex" />
  </a>
  <a href="https://hexdocs.pm/lustre">
    <img src="https://img.shields.io/badge/hex-docs-ffaff3"
      alt="Documentation" />
  </a>
</div>

<div align="center">
  <h3>
    <!--
    <a href="https://lustre.build">
      Website
    </a>
    <span> | </span>
    -->
    <a href="https://hexdocs.pm/lustre/guide/01-quickstart.html">
      快速開始
    </a>
    <span> | </span>
    <a href="https://hexdocs.pm/lustre">
      參考文件
    </a>
    <span> | </span>
    <a href="https://discord.gg/Fm8Pwmy">
      Discord
    </a>
  </h3>
</div>

<div align="center">
  <sub>由 ❤︎
  <a href="https://twitter.com/hayleighdotdev">Hayleigh Thompson</a> 及
  <a href="https://github.com/lustre-labs/lustre/graphs/contributors">
    貢獻者
  </a>
  共同打造
</div>

---

## 目錄

- [功能特點](#features)
- [範例](#example)
- [設計理念](#philosophy)
- [安裝](#installation)
- [接下來](#where-next)
- [支援](#support)

## 功能特點 {#features}

- 以 **宣告式**、函數式 API 構建 HTML。無需模板，無需巨集，
  只需 Gleam。

- 受 Erlang 和 Elm 啟發的架構，**管理狀態**。

- **受控的副作用**，讓程式可預測且易於測試。

- 通用元件。**一次撰寫，隨處執行**。Elm 結合 Phoenix LiveView。

- **內建多功能 CLI**，讓腳手架及構建應用變得輕鬆無比。

- 支援**伺服器端渲染**靜態 HTML 模板。

## 範例 {#example}

Lustre 附帶了[超過 20 個範例](https://hexdocs.pm/lustre/reference/examples.html)！
以下是其外觀：

```gleam
import gleam/int
import lustre
import lustre/element.{text}
import lustre/element/html.{div, button, p}
import lustre/event.{on_click}

pub fn main() {
  let app = lustre.simple(init, update, view)
  let assert Ok(_) = lustre.start(app, "#app", Nil)

  Nil
}

fn init(_flags) {
  0
}

type Msg {
  Incr
  Decr
}

fn update(model, msg) {
  case msg {
    Incr -> model + 1
    Decr -> model - 1
  }
}

fn view(model) {
  let count = int.to_string(model)

  div([], [
    button([on_click(Incr)], [text(" + ")]),
    p([], [text(count)]),
    button([on_click(Decr)], [text(" - ")])
  ])
}
```

## 設計理念 {#philosophy}

Lustre 是一個 _有明確主張_ 的框架，適合構建小型到中型 Web 應用。
現代前端開發困難且複雜，其中部分複雜是必需的，但更多是偶發的，或來自於過多的選擇。
Lustre 與 Gleam 有著相同的設計理念：能統一就統一，盡量只有一種做法。

這代表 Lustre 出廠即內建單一狀態管理系統，並以 Elm 和 Erlang/OTP 為模型。
打開任何 Lustre 應用，你都會感到熟悉。

這也代表我們鼓勵用簡單的方式構建視圖，而不是複雜的方法。Lustre _確實_ 有方法創建封裝狀態的元件（這是我們在 Elm 裡很想要的），但這不應該是預設。
請優先使用簡單的函數，而非狀態型元件。

當確實 _需要_ 元件時，善加利用 Lustre 元件可於 _任何地方_ 運行這一特性。
Lustre 提供工具，讓你能將元件在現有 Lustre 應用中運行、導出為獨立 Web Component，或以極小的執行時在伺服器上運行並修補 DOM。
Lustre 稱這些為**通用元件**，它們是以 Gleam 多目標為考量而撰寫的。

## 安裝 {#installation}

Lustre 已發佈於 [Hex](https://hex.pm/packages/lustre)！你可以在命令列將它加入你的 Gleam 專案：

```sh
gleam add lustre
```

Lustre 也有一個輔助套件，包含開發工具，建議你一併安裝：

> **注意**：lustre_dev_tools 開發伺服器會監控你的檔案系統
> 當 gleam 程式碼有變動時可自動重新載入瀏覽器。Linux 用戶需安裝 [inotify-tools]()

```sh
gleam add --dev lustre_dev_tools
```

## 接下來 {#where-next}

想快速上手 Lustre，請參考[快速開始指南](https://hexdocs.pm/lustre/guide/01-quickstart.html)。
如果你想直接看程式碼，[examples](https://github.com/lustre-labs/lustre/tree/main/examples)
目錄中包含數個小型應用，展示本框架的不同面向。

你也可以在 [HexDocs](https://hexdocs.pm/lustre) 閱讀完整文件與 API 參考。

## 支援 {#support}

Lustre 主要由我（[Hayleigh](https://github.com/hayleigh-dot-dev)）一人完成，
在兩份工作的空檔進行。如果你想支持我的工作，可以[在 GitHub 贊助我](https://github.com/sponsors/hayleigh-dot-dev)。

也非常歡迎貢獻！如果你發現了 bug，或想建議新功能，請開 issue 或 pull request。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---
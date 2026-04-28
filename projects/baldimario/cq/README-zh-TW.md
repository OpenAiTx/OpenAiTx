<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# cq - 高效能 SQL 查詢引擎，用於 CSV 檔案

 [![跨平台建置與測試（使用 zig 建構系統）](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml/badge.svg)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml)

一款輕量、快速的 SQL 查詢處理器，以 C 語言編寫，能直接對 CSV 檔案執行 SQL 查詢，無需數據庫。完整文件請參見 /doc 目錄。

 ![cq 運作畫面](https://raw.githubusercontent.com/baldimario/cq/main/assets/cq.png)


## 文件說明

- 入門指南：`doc/GettingStarted.md`
- 安裝說明：`doc/Installation.md`
- 命令列介面：`doc/CLI.md`
- **終端機用戶介面（TUI）**：`doc/TUI.md`
- 架構說明：`doc/Architecture.md`
- 測試：`doc/Testing.md`
- 路線圖：`doc/Roadmap.md`
- 貢獻指南：`doc/Contributing.md`

## 快速開始

建置：`make`

### 命令列

執行範例查詢：
`./build/cq -q "SELECT name, age FROM 'data.csv' WHERE age > 25" -p`

### 終端機介面

啟動互動式TUI：
`./build/cqtui data/`

功能特色：
- 瀏覽與開啟CSV檔案為資料表
- 互動式執行SQL查詢
- 多分頁介面，可同時檢視多個資料表
- 鍵盤導向操作
- 無需外部依賴

## 範例SQL檔案

本儲存庫於 assets/ 目錄下包含範例SQL（如 example_between.sql、example_aggregation.sql 等）。詳情請參閱 assets/。

## 資料與功能概述

- 詳細資料型別、日期格式、CSV格式等可參閱 /doc 資料夾中相關章節。

## 授權

MIT 授權。詳情請參閱 LICENSE 檔案。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-28

---
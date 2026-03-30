
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

﻿# Elucidate

- [專案說明](#project-description)
- [系統需求：](#os-requirements)
- [常見問題](#faqs)
- [開發路線圖](#roadmap)
- [截圖](#screenshots)

## 專案描述

Elucidate 是一款 Windows 圖形介面前端，專為命令列 SnapRAID 應用程式設計。

*本專案延續了我本人及其他貢獻者所做的傑出整合工作。

## 系統需求

- Windows 作業系統
- .Net 執行環境 4.8.0
- SnapRaid 版本 11.5 或以下
- 目標磁碟需有 10MB 空間

## 常見問答

**問**：什麼是 SnapRAID？<br/>
**答**：SnapRAID 是一款基於軟體的快照奇偶校驗引擎，適用於 Windows 與 Linux 作業系統。最基本的功能是透過計算檔案系統中各個檔案的雜湊值，並將結果儲存在奇偶檔案中，為檔案內容提供保護。在硬碟完全損壞時，可利用此奇偶檔案重建遺失資料。詳細內容請參閱 SnapRAID 的[官方檔案保護引擎比較](http://snapraid.sourceforge.net/compare.html)。

**問**：為什麼要有 GUI，命令列不是很好用嗎？<br/>
**答**：更大的目標是打造功能完整的圖形介面，並增加管理功能，協助使用者維持 SnapRAID 環境的正常運作。有時候，對新手來說「點擊操作」更容易上手。SnapRAID 的技術文件及高度可調整性，對初學者來說可能會有些卻步！

**問**：我還是很猶豫，還有更多介紹嗎？<br/>
**答**：有的，您可以參考 [文件說明](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./docs/Documentation.md)，內含圖片等資訊。

**問**：那麼「更大的目標」是什麼？<br/>
**答**：請參閱下方的 __發展規劃__，有完整細節。

## 發展規劃

- [x] 第一階段
  - [x] 盡量跟上最新 SnapRAID 的最低支援。- __持續進行中。__
  - [x] 操作簡易性
  - [x] SnapRAID 有三個指令，讓新手簡單操作 
  - [x] 進度指示器
  - [x] 記錄「互動式」及直接存入日誌
  - [x] 使用者登入時自動啟動
  - [x] 工具提示協助導引 •	

- [x] 第二階段 第二階段功能請求
  - [x] 暫停、變更優先權、終止。
  - [x] 指令擴充 -「允許為預設值提供額外參數。」
  - [x] 排程 
    - 已移除，請使用命令列
  - [x] 受保護資料的圖形化檢視。

- [ ] 第三階段（2017-03 起重新啟動）
  - [x] 新編譯器與 .Net 4.7.x	
  - [x] 命令列介面
  - [ ] 透過 Krypton Toolkit / Navigator / 等等實現新介面佈局 
    - 進行中
  - [ ] 翻譯 
  - [x] 新指令
  - [ ] 具有狀態報告的郵件發送
  - [ ] 文件化測試步驟
    - 進行中
  - [ ] 加入至文件 / 更新圖片
    - 進行中
  - [ ] 加入 _Windows 事件日誌_ 錯誤回報
  - [x] 加入 _ExceptionLess_ 線上異常回報
  - [x] 顯示可恢復的內容。 

- [ ] 第四階段（新 SnapRAID 指令？）
  - [ ] 擴充的磁碟復原說明 - 互動式導引等。
  - [ ] 如 SnapRAID 版本過舊則通知使用者
  - [ ] 解析 SnapRAID 日誌（供下方變更使用）
  - [ ] 在執行指令後提供陣列狀態
  - [ ] 修改 sync 指令以納入初始 diff
  - [ ] 若 diff 報告問題超過門檻則 sync 指令發出警告
  - [ ] 為同步門檻需求新增使用者可設定參數

## 截圖

![啟動畫面](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/starting_view.png)

![設定表單](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/Settings_Form.PNG)

## 你能協助嗎？
- 尋找測試者（所有 .Net 平台）


- 可以協助翻譯
- 幫助／使用者介面指南
- 任何其他想法 :-)
- 為這些想法提供開發者


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-30

---
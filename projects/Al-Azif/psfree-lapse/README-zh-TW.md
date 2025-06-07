# PSFree 版本 1.5.1

PSFree 是一套針對 PS4 主機的漏洞利用集合。本倉庫主要聚焦於 PS4，但我們也嘗試讓其可移植到 PS5。

## 功能

- **自動偵測：** 會自動偵測主機類型與韌體版本（經由 [`src/config.mjs`](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/src/config.mjs)）。
- **WebKit 漏洞利用（PSFree）：** 透過主機網頁瀏覽器作為進入點。
- **核心漏洞利用（Lapse）：** 權限提升至核心等級。
- **有效載入器（Payload Loader）：** 核心漏洞利用成功後，於 9020 埠口等待有效載入（Payload）。

## 漏洞範圍

|               | PSFree    | Lapse      |
| :------------ | :-------- | :--------- |
| PlayStation 4 | 6.00-9.60 | 1.01-12.02 |
| PlayStation 5 | 1.00-5.50 | 1.00-10.01 |

## 本倉庫支援情況

下表顯示本倉庫_當前版本_已實作且通過測試的韌體漏洞利用鏈。

|               | PSFree    | Lapse     |
| :------------ | :-------- | :-------- |
| PlayStation 4 | 7.00-9.60 | 7.00-9.60 |
| PlayStation 5 | N/A       | N/A       |

_注意：關於其他在「漏洞範圍」表中提及的韌體版本，支援情形可能尚在開發中，或曾於本倉庫舊版支援。請查閱 [`CHANGELOG.md`](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/CHANGELOG.md) 以了解歷史支援紀錄。_

## TODO 清單

- [ ] 某些遊戲發生黑屏/存檔問題
- [ ] `lapse.mjs`：僅設置 JIT 權限位元
- [ ] `view.mjs`：目前僅假定為 PS4，需支援 PS5
- [ ] 新增 PS5 支援

## 版權與作者

AGPL-3.0-or-later（詳見 [LICENSE](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/LICENSE)）。本倉庫屬於 `anonymous` 團隊。我們將匿名貢獻者也稱為「anonymous」。

## 鳴謝

- anonymous：提供 PS4 韌體核心轉存
- 其他**額外**貢獻者請參見相關檔案。除非另有說明，所有內容亦可歸功於我們團隊。

## 捐款

(Monero/XMR)：**86Fk3X9AE94EGKidzRbvyiVgGNYD3qZnuKNq1ZbsomFWXHYm6TtAgz9GNGitPWadkS3Wr9uXoT29U1SfdMtJ7QNKQpW1CVS**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---
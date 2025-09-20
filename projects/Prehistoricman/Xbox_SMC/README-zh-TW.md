
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=zh-CN">簡體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Xbox_SMC
原始 Xbox 的 PIC16/Xyclops 轉存檔以及 IDA 資料庫，並進行了一些逆向工程。

![原始 Xbox 上 PIC16LC63A 的圖片](https://raw.githubusercontent.com/Prehistoricman/Xbox_SMC/master/pic16lc63a.jpg)

# Xyclops 燒錄（XycloMod）
請參閱 [Xyclops 目錄和 README](/Xyclops)

# 傾印檔案
每個 PIC 傾印的 .bin 檔案已經進行位元組交換，以便正確載入到 IDA。因此 PIC 記憶體的第一個字是 byte_0 + byte_1 << 8。

.idb IDA 資料庫中包含有關變數的資訊，以及在資料庫備忘錄上的一些觀察。

請參閱此 wiki 頁面以了解 SMC 版本的詳細分解：https://xboxdevwiki.net/Xboxen_Info

## B2A
從 DVT3 Xbox 傾印。設定字與 P01 相同。它在設定區域中燒錄了裝置 ID：0000 0000 000B 002A，這與量產 PIC 不同。

完全缺少開機挑戰。

## D01
從 XDK BETA 2 Xbox 傾印。除了缺少開機挑戰外，與 P01 完全相同。計算預期開機挑戰回應的函數仍存在，但從未被呼叫。

## DXF
從 XDK D2 除錯套件傾印。與 D01 非常相似，但托盤邏輯、過熱邏輯和開機邏輯略有不同。開機挑戰與 D01 一樣缺失。

## D2E
從 Tuscany (v1.6) 開發套件傾印。Xyclops 晶片標示為 X01202-001，並且缺少零售機型上有的 A-A02 或 A-B01 線。

在 FC00 的除錯序列碼與零售版 P2L 傾印一致。從 0x4000 到 0xFBFF 有一個奇怪的資料模式。

## P01
從 v1.0 Xbox 傾印。設定字為 0x86：
- CP1:CP0 = 0（整個記憶體啟用程式碼保護）
- BODEN = 0（停電重置停用）
- ~PWRTE = 0（開機計時器啟用）
- WDTE = 1（看門狗計時器啟用）
- FOSC1:FOSC0 = 2（HS 振盪器）

SMC 複製品適用的設定值為 0x3FB6，這樣就不會啟用程式碼保護。

## P11
從 v1.3 Xbox 傾印。設定字與 P01 相同。

P11 與 P01 相比有一些小變化，包括多了一個 SMBus 指令（寫入 0x22）、不同的 LED 優先順序，以及更寬鬆的開機時序。

我已檢查 v1.3 的加密傾印與 v1.4 相比，它們是相符的。這表示它們極有可能使用相同的程式。

## P2L
從 v1.6 Xbox 傾印。Xyclops 修訂版本 A-A02。它包含 Intel 8051 程式碼，但有許多特殊功能暫存器，其功能未知。

調試串列端口由 FC00 處的程式碼供電。看起來像是一個簡陋的調試器，可以暫停執行、傾印資料，並寫入暫存器/RAM。

# Xyclops 傾印

Xyclops 晶片有三個「調試」腳位：TXD（腳位 64）、RXD（腳位 63）和 DEBUG（腳位 29）。將 DEBUG 腳位設為高電位即可啟用 TX 和 RX 腳位上的串列端口。串列通訊速率為 9600 baud。

協定基於 4 字節指令，格式通常為 `<cmd>` `<address MSByte>` `<address LSByte>` `<don't care>`

指令 0x14 每次傾印 64 字節 BIOS 資料，0x15 每次傾印 64 字節 SMC 程式資料。來自 Xyclops 的傾印檔 P2L.bin 已包含於倉庫中。[xyclops_dumper.py](/Xyclops/xyclops_dumper.py) 也已包含，供你傾印自己的機器。

# PIC 傾印方法
完整說明請參見 https://wiki.recessim.com/view/PIC_Burnout

PIC 啟用了程式碼保護，因此所有資料讀取出來都是 0000。我用了一些技巧取得了亂碼資料輸出，利用犧牲晶片發現了亂碼演算法，然後使用某種漏洞改變 ROM 資料，使部分位元固定為已知值。接著我可以從多次亂碼傾印中提取所需資訊，重建原始資料。

# PICProgrammer
PICProgrammer 是我研究中使用的幾個 RP2040 Arduino 專案之一。它提供一個簡易命令列介面，以執行 PIC 的 ICSP（線路內串列程式燒錄）操作。與使用如 PICkit 等專用燒錄器相比，它因彈性高且可以執行製造商未預期的操作而較受青睞。

在使用前，你應該對電子學和程式設計有良好理解，並仔細了解各指令的作用後再執行。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-20

---
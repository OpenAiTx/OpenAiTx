
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# MiciMike 用於 Google Nest Mini 的可替換式 PCB

[MiciMike Nest Mini](https://github.com/iMike78/nest-mini-drop-in-pcb) 是一款用於 ["Google Nest Mini"（Google 第二代智慧音箱，採用圓柱型連接器充電埠）](https://en.wikipedia.org/wiki/Google_Nest_(smart_speakers)) 的可替換式 PCB，但基於 ESP32 與 XMOS 微控制器，支援開源韌體運行。

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_1.png" width="1000">

提示！如果你正在尋找「Google Home Mini」（Google 第一代智慧音箱硬體，採用 Micro-USB 充電埠）的類似可替換式 PCB，請參考姊妹專案：https://github.com/iMike78/home-mini-v1-drop-in-pcb

這兩個都是完全開源硬體專案，部分概念靈感來自 [Onju Voice](https://github.com/justLV/onju-voice)，但目標是遵循 [Open Home Foundation 的開放語音助理標準，以 Home Assistant Voice Preview Edition 為參考](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)進行 PCB 設計和規範。

# 專案範疇

本專案及儲存庫的目標（類似於 [Onju Voice](https://github.com/justLV/onju-voice)，但採用完全開源硬體授權）是設計一個可直接替換的 PCB（印刷電路板），並提供硬體原理圖，任何人都能自行製作、建造或從一站式 PCB 製造商訂購，作為 Google Nest Mini（第二代）的客製化替換 PCB。

這主要針對希望將舊的 Google Nest Mini 智慧喇叭改裝或再利用為 [Home Assistant 語音控制](https://www.home-assistant.io/voice_control/)開源硬體，以及/或作為 [Music Assistant](https://www.music-assistant.io) 媒體播放器喇叭輸出的人士（不過硬體也可能配合其他應用及韌體使用，因為它基於流行的 Espressif ESP32 平台）。

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

硬體設計將（類似於 [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)）整合 ESP32-S3 SoC，提供 WiFi、BLE 及 [板載喚醒詞偵測](https://www.home-assistant.io/voice_control/about_wake_word/)（採用免程式碼 [ESPHome 韌體](https://esphome.io/)）+ XMOS xCORE XU316 晶片，負責進階音訊處理（使用自訂韌體將麥克風清理運算卸載，提升語音辨識能力，採用本地運算演算法進行噪音抑制、聲學回音消除、干擾消除及自動增益控制）。

在功能上，其硬體與 [Home Assistant Voice Preview Edition（又稱 Home Assistant Voice PE）](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) 參考設計大致相容（該設計已由 Open Home Foundation 與 Nabu Casa 合作發佈為開源硬體設計）。主要差異來自 Google Nest Mini 外殼及元件的限制（即 nest-mini-drop-in-pcb 專案的硬體設計將受限於 Google 原廠硬體相同類型的物理容量及輸入）。

因此，本專案/儲存庫的範疇並不包含 ESPHome 韌體的新功能開發，如有此需求，請參考 Home Assistant Voice Preview Edition 韌體開發，以及上游 ESPHome 主線程式碼：

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## 合作邀請

如果您有 PCB 佈局設計經驗（尤其是 PCB 走線、地層佈局或噪音敏感的數位/類比電路設計），**非常歡迎您的協助**！歡迎建立新議題、提出建議/需求、補充回饋至現有議題，或分叉本儲存庫。

更多概念/想法資訊，請參考並參與相關討論，此 Home Assistant 社群論壇主題：

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### 目前進度

- ✅ 原理圖完成
- ✅ 元件擺放完成
- ✅ 走線完成
- ✅ 地層佈局、防護策略及 EMI 考量完成
- ⚠️ 第一批測試板因兩個錯誤失敗－已修正
- 🕓 正在等待第二批測試板

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">

## 使用工具

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC 用於元件封裝來源

## 已知硬體規格

- 4 層 PCB
- ESP32-S3R8 裸晶片（ESP32-S3 用於 WiFi、BLE 及板載喚醒詞偵測）
- XMOS XU316-1024-QF60B-C32（XMOS XU316 xCORE DSP 音訊處理）
- 雙 SPI 快閃記憶體
- 雙 I²S 匯流排（可同時支援 I2S 介面，即音訊輸出與音訊輸入同步進行）
- MAX98357 用於喇叭輸出（I2S 類 D 單聲道音訊放大器）
- 2 個 MEMS 麥克風（MSM261DHP）
- SK6812 LED
- 客製 USB-C 與 14V 電源輸入

---

> ⚠️ 通過 USB-C 燒錄時需斷開主 14V 電源輸入。詳情請參閱 PCB 絲印標註。

## 參考資料

### Home Assistant Voice Preview Edition 資源及 PCB 設計檔案
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/zh-tw/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Home Assistant Voice PE 專用 ESPHome 韌體（同時使用 ESP32-S3 + XMOS XU316 組合）：

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP（XU316-1024-QF60B-C32）MCU IC 晶片

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai
 
#### 來自 ESPHome 專案的 XMOS 韌體，適用於 Home Assistant Voice 預覽版硬體：

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## 授權條款

本專案採用 [CERN 開放硬體授權版本 2 - 強制回饋（CERN-OHL-S v2）] 授權
任何此硬體的修改版本也必須以相同授權條款分發。

☕ 如果您想支持本專案，歡迎在 [Ko-fi 購買咖啡給我](https://ko-fi.com/imike78)!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---
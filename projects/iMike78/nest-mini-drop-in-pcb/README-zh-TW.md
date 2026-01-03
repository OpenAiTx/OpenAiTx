
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

# MiciMike 適用於 Google Nest Mini 的即插即用 PCB 替換板

[MiciMike Nest Mini](https://github.com/iMike78/nest-mini-drop-in-pcb) 是一款專為 ["Google Nest Mini"（Google 第二代智慧音箱，採用圓柱型電源接頭）](https://en.wikipedia.org/wiki/Google_Nest_(smart_speakers)) 設計的即插即用 PCB 替換板，基於 ESP32 及 XMOS 微控制器，用於運行開源韌體。

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_1.png" width="1000">

提示！如果您正在尋找適用於 "Google Home Mini"（Google 第一代智慧音箱硬體，採用 Micro-USB 充電埠）之類似的即插即用 PCB 替換方案，請參閱姊妹計畫 https://github.com/iMike78/home-mini-v1-drop-in-pcb
這兩個都是完全開源硬體專案，部分概念靈感來自 [Onju Voice](https://github.com/justLV/onju-voice)，但目標是遵循 [Open Home Foundation 的開放語音助理標準，以 Home Assistant Voice Preview Edition 為參考](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)，進行 PCB 設計及規格制定。

# 專案範圍

本專案與此儲存庫（與 [Onju Voice](https://github.com/justLV/onju-voice) 類似，但採用完全開源硬體授權）目標是設計一款可直接替換的 PCB（印刷電路板），並提供硬體電路圖，任何人都可以自行製作／訂製，或透過一站式 PCB 製造商訂購，作為 Google Nest Mini（第二代）的客製化替換 PCB。

主要目標對象是希望將舊 Google Nest Mini 智慧音箱轉換／再利用為開源硬體，實現 [Home Assistant 語音控制](https://www.home-assistant.io/voice_control/) 和／或 [Music Assistant](https://www.music-assistant.io) 媒體播放器音箱輸出的人士，（此硬體也可搭配其他應用及韌體使用，因為其基於流行的 Espressif ESP32 平台）。

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

硬體設計將會（類似 [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)）整合 ESP32-S3 SoC 提供 WiFi、BLE 及 [板載喚醒詞偵測](https://www.home-assistant.io/voice_control/about_wake_word/)（使用免編碼 [ESPHome 韌體](https://esphome.io/)），並搭載 XMOS xCORE XU316 晶片作為進階音訊處理（透過自訂韌體實現麥克風淨音卸載，提升語音辨識能力，運行本地演算法達到噪音抑制、聲學回音消除、干擾消除及自動增益控制）。

在功能上，該硬體設計將與 [Home Assistant Voice Preview Edition（又稱 Home Assistant Voice PE](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) 參考設計大致相容（該設計由 Open Home Foundation 與 Nabu Casa 合作發佈為開源硬體設計）。主要差異來自 Google Nest Mini 機殼及零件的限制（即 nest-mini-drop-in-pcb 專案硬體設計受到與 Google 原廠硬體相同的物理容量輸入限制）。

因此，本專案／儲存庫範圍並不包含為 ESPHome 韌體開發新功能／新特性，如果您有此需求，請前往 Home Assistant Voice Preview Edition 韌體開發及上游 ESPHome 主線代碼：

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## 合作邀請

如果您有 PCB 佈局設計經驗（尤其是 PCB 走線、接地層澆注或噪音敏感的數位／類比佈局），**非常歡迎您的協助**！請隨時建立新議題、提出建議／需求、對現有議題補充意見／回饋，或是 fork 此儲存庫。

如需了解更多概念／想法，並參與相關討論，請參見並貢獻此 Home Assistant 社群論壇主題：

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### 目前狀態

- ✅ 電路圖完成
- ✅ 元件擺放完成
- ✅ 走線完成
- ✅ 地層澆注、屏蔽策略及 EMI 考量已完成
- ⚠️ 第一批測試失敗兩處錯誤－已修正
- 🕓 等待第二批測試

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">


## 使用的工具

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC 用於封裝來源

## 已知硬體規格

- 4 層 PCB
- ESP32-S3R8 裸晶片（ESP32-S3 用於 WiFi、BLE 及板載喚醒詞偵測）
- XMOS XU316-1024-QF60B-C24（XMOS XU316 xCORE DSP 音訊處理）
- 雙 SPI 快閃記憶體（因 ESP32 和 XMOS 各自擁有自己的 SPI 快閃記憶體）
- 雙 I²S 匯流排（允許同時使用 I2S 介面，即音訊輸出和輸入同時進行）
- MAX98357 用於喇叭輸出（I2S 類 D 單聲道音訊放大器）
- 2x MEMS 麥克風（雙 MMICT390200012，麥克風間距 68mm）
- 6x SK6812 RGB LED
- 客製 USB-C 與 14V 電源輸入（注意！USB-C 與圓形插頭不可同時連接）

---

> ⚠️ 透過 USB-C 燒錄時需斷開主 14V 電源輸入。詳情請參閱 PCB 上的絲印備註。

## 參考資料

### Home Assistant Voice Preview Edition 資源，包括 PCB 設計檔案
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/zh-tw/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### 用於 Home Assistant Voice PE 的 ESPHome 韌體（同樣採用 ESP32-S3 + XMOS XU316 組合）：

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP（XU316-1024-QF60B-C32）MCU IC 晶片

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai
 
#### 來自 ESPHome 專案、用於 Home Assistant Voice Preview Edition 硬體的 XMOS 韌體：

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## 授權

本專案採用 [CERN 開放硬體授權條款第 2 版 - 強烈互惠條款 (CERN-OHL-S v2)] 授權
任何修改過的硬體版本也必須以相同授權條款發佈。

☕ 如果您想支持本專案，歡迎到 [Ko-fi 購買咖啡支持我](https://ko-fi.com/imike78)！



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-03

---
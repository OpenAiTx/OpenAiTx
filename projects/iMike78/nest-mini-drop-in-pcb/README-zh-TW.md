
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

**注意！** 目前正在 Crowd Supply 進行「MiciMike Home Mini Drop-In PCB」（第一代 Google Home Mini）群眾募資活動，現正處於預售階段（僅限專案預覽），若本次活動成功，將計劃針對新版 Nest Mini（第二代）推出相應活動，歡迎點擊下方連結參考，若有能力也可透過贊助間接支持此專案：

* https://www.crowdsupply.com/micimike-rev-devices/micimike-home-mini-drop-in-pcb

這兩個專案都是完全開放原始碼硬體，部分概念靈感來自 [Onju Voice](https://github.com/justLV/onju-voice)，但目標是遵循 [Open Home Foundation 的開放語音助理標準，並以 Home Assistant Voice Preview Edition 為參考](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)設計 PCB 與規格。

# 專案範疇

本專案及其程式庫目標（類似 [Onju Voice](https://github.com/justLV/onju-voice)，但採用完全開放原始碼硬體授權）是設計一塊可替換安裝的 PCB（印刷電路板）及硬體電路圖，任何人都能自製/組裝，或委託一站式 PCB 製造商製作，用於 Google Nest Mini（第二代）的專用替換主板。

本專案主要面向希望將舊的 Google Nest Mini 智慧音箱轉換/改造為開放原始碼硬體，進而實現 [Home Assistant 語音控制](https://www.home-assistant.io/voice_control/) 和/或 [Music Assistant](https://www.music-assistant.io) 媒體播放器輸出的人士，（但該硬體基於 Espressif ESP32 平台，亦可搭配其他韌體用於其他應用場景）。

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/front_render.jpg" width="1000" alt="First test PCB">

硬體設計將（如同 [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)）整合 ESP32-S3 SoC，實現 WiFi、BLE、以及[本地喚醒詞偵測](https://www.home-assistant.io/voice_control/about_wake_word/)（採用無程式碼 [ESPHome 韌體](https://esphome.io/)），並加上 XMOS xCORE XU316 晶片作為進階音訊處理（搭配自訂韌體，將麥克風前端降噪、回音消除、干擾抑制、自動增益控制等本地運算，提升語音辨識能力）。

功能上本設計將最大程度對應 [Home Assistant Voice Preview Edition（簡稱 Home Assistant Voice PE）](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) 參考設計（由 Open Home Foundation 與 Nabu Casa 合作釋出開放原始碼硬體設計）。主要差異來自 Google Nest Mini 外殼及零件的物理限制（nest-mini-drop-in-pcb 專案硬體設計需受 Google 原廠硬體同型輸入限制）。

因此，本專案/程式庫的範疇並不包含 ESPHome 韌體的新功能/特性開發，若有此需求，請參與 Home Assistant Voice Preview Edition 韌體開發及上游 ESPHome 主線程式碼：

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## 合作邀請

若您具備 PCB 佈局設計經驗（特別是線路佈線、鋪地層、或數位/類比混合抗干擾佈局），**非常歡迎您的協助**！請隨時提出新議題、建議/需求，或對現有議題提供意見/回饋，亦可 fork 此專案參與開發。

如需更多概念/想法說明或參與討論，亦可參考並加入 Home Assistant 社群論壇主題：

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### 目前狀態

- ✅ 電路圖已完成
- ✅ 元件佈局已完成
- ✅ 佈線已完成
- ✅ 鋪地層、防護策略及 EMI 考量已完成
- ⛔ 第一批測試板因兩處錯誤失敗－已修正
- ⚠️ 第二批測試部分運作正常
- ✅ 下一批已新增 XTAG4 除錯選項

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/back_render.jpg" width="1000">

## 使用工具

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC 用於封裝來源

## 已知硬體規格

- 四層 PCB
- ESP32-S3R8 裸晶片（ESP32-S3 用於 WiFi、BLE 及板載喚醒詞偵測）
- XMOS XU316-1024-QF60B-C24（XMOS XU316 xCORE DSP 音訊處理）
- 16 MB SPI 快閃記憶體（ESP32-S3）
- 4 MB SPI 快閃記憶體（XMOS XU316）
- 雙 I²S 匯流排（可同時音訊輸入與輸出）
- TAS5805M（TAS5805MPWPR）立體聲 Class-D 擴大器，內建 DSP（I2S 音訊，I2C 控制），配置為單聲道 BTL 喇叭輸出
- 3x MEMS 麥克風（MMICT390200012）排列於 34 mm 半徑弧線上－目前韌體使用 2 支麥克風，硬體已支援三麥克風陣列
- 6x SK6812 RGB LED
- 客製 USB-C 與 14V 電源輸入（注意！USB-C 與圓孔連接器不可同時連接）
- MPR121 電容式觸控控制器（用於觸控輸入，取代 ESP32-S3 原生觸控感應）

---

> ⚠️ 使用 USB-C 進行燒錄時，需斷開主 14V 電源輸入。詳情請參閱 PCB 絲印標註。

## 參考資料

### Home Assistant Voice Preview Edition 資源，包括 PCB 設計檔案
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### ESPHome 韌體（適用於 Home Assistant Voice PE，亦採用相同 ESP32-S3 + XMOS XU316 組合）：

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP (XU316-1024-QF60B-C24) MCU IC 晶片

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai
 
#### 來自 ESPHome 專案，針對 Home Assistant Voice Preview Edition 硬體的 XMOS 韌體：

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## 授權條款

本專案依據 [CERN 開放硬體授權條款第 2 版 - 強制互惠（CERN-OHL-S v2）] 授權。
任何修改過的硬體版本也必須以相同授權條款發佈。

☕ 如果您願意支持本專案，歡迎[在 Ko-fi 請我喝杯咖啡](https://ko-fi.com/imike78)！




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-24

---
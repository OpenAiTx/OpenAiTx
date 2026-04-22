
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
**提醒！** 「MiciMike Home Mini Drop-In PCB」（第一代 Google Home Mini）即將啟動群眾募資活動，目前已在 Crowd Supply 的預啟動階段（僅限項目預覽），若此活動成功，將計劃推出 Nest Mini 的對應活動，請於下方查看：

* https://www.crowdsupply.com/micimike-rev-devices/micimike-home-mini-drop-in-pcb

這兩項皆為完全開源硬體專案，概念部分受到 [Onju Voice](https://github.com/justLV/onju-voice) 啟發，但目標是遵循 [Open Home Foundation 的開放語音助手標準，並以 Home Assistant Voice Preview Edition 為設計及規範參考](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) 進行 PCB 設計。

# 專案範疇

本專案及儲存庫的目標（與 [Onju Voice](https://github.com/justLV/onju-voice) 類似，但採用完全開源硬體授權）是設計一款可替換的 PCB（印刷電路板），附硬體電路圖，任何人都能自行製作／組裝或向一站式 PCB 製造商訂購，作為 Google Nest Mini（第二代）的客製化替換 PCB。

此專案主要針對希望將舊 Google Nest Mini 智慧音箱轉為開源硬體以用於 [Home Assistant 語音控制](https://www.home-assistant.io/voice_control/) 及／或媒體播放器音箱輸出（搭配 [Music Assistant](https://www.music-assistant.io)），（硬體亦可能適用於其他應用，搭配其他韌體，因其採用流行的 Espressif ESP32 平台）。

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

硬體設計（類似於 [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)）將整合 ESP32-S3 SoC，用於 WiFi、BLE 及 [內建喚醒詞偵測](https://www.home-assistant.io/voice_control/about_wake_word/)（採用無需編碼的 [ESPHome 韌體](https://esphome.io/)），再加上 XMOS xCORE XU316 晶片負責進階音訊處理（搭配自訂韌體，將麥克風音訊清理離線處理，以提升語音辨識能力，並採用本地運算的降噪、聲學回音消除、干擾消除、與自動增益控制演算法）。

功能上主要與 [Home Assistant Voice Preview Edition（又名 Home Assistant Voice PE](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)）參考設計硬體相容（此設計已由 Open Home Foundation 與 Nabu Casa 合作釋出為開源硬體）。主要差異在於 Google Nest Mini 外殼及零件的限制，（即 nest-mini-drop-in-pcb 專案硬體設計受原 Google 硬體相同物理容量輸入限制）。

因此，本專案／儲存庫範疇並非開發 ESPHome 韌體新功能，如需此類功能，請轉向 Home Assistant Voice Preview Edition 韌體開發及 ESPHome 上游主線程式碼：

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## 協作邀請

若您有 PCB 佈局設計經驗（尤其是 PCB 佈線、地線覆蓋或對噪聲敏感的數位／類比佈局），**非常歡迎您的協助**！請自由開新議題、提交建議／需求、並對現有議題提供意見或反饋，或是分支此儲存庫。

如需更多概念／想法資訊，請參考並參與相關討論，另見 Home Assistant 社群論壇主題：

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### 目前狀態

- ✅ 電路圖繪製完成
- ✅ 元件佈局完成
- ✅ 佈線完成
- ✅ 地線覆蓋、屏蔽策略及 EMI 考量完成
- ⚠️ 第一批測試失敗兩處錯誤－已修正

- 🕓 等待第二批測試

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">

## 使用的工具

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC 用於封裝來源

## 已知硬體規格

- 四層PCB
- ESP32-S3R8裸晶片（ESP32-S3用於WiFi、BLE及板載喚醒詞偵測）
- XMOS XU316-1024-QF60B-C24（XMOS XU316 xCORE DSP音訊處理）
- 雙SPI快閃記憶體（ESP32和XMOS各自有自己的SPI快閃記憶體）
- 雙I²S總線（允許同時有I2S介面，即音訊輸出和音訊輸入同時進行）
- TAS5805M（TAS5805MPWPR）用於喇叭輸出（I2S Class-D單聲道音訊放大器，DSP配置透過I2C）
- 2x MEMS麥克風（雙MMICT390200012，麥克風間距68mm）
- 6x SK6812 RGB LED燈
- 客製USB-C及14V電源輸入（注意！USB-C與圓形插孔不能同時連接）

---

> ⚠️ 通過USB-C燒錄時需要斷開主14V電源輸入。詳情請參閱PCB上的絲印說明。

## 參考資料

### Home Assistant Voice Preview Edition 資源，包括PCB設計檔案
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/zh-tw/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### 用於Home Assistant Voice PE的ESPHome韌體（同樣使用ESP32-S3 + XMOS XU316組合）：

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP（XU316-1024-QF60B-C32）MCU IC晶片

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai
 
#### 來自 ESPHome 專案、適用於 Home Assistant Voice Preview Edition 硬體的 XMOS 韌體：

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## 授權

本專案採用 [CERN 開放硬體授權條款第2版 - 強烈互惠（CERN-OHL-S v2）] 授權
任何修改版本的此硬體也必須以相同授權條款分發。

☕ 如果您想支持本專案，歡迎到 [Ko-fi 購買咖啡給我](https://ko-fi.com/imike78)！




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-22

---
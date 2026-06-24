<div align="right">
  <details>
    <summary >🌐 语言</summary>
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

# MiciMike Google Nest Mini 替换用插拔式PCB

[MiciMike Nest Mini](https://github.com/iMike78/nest-mini-drop-in-pcb) 是一款为["Google Nest Mini"（谷歌第二代智能音箱，带圆柱形电源接口）](https://en.wikipedia.org/wiki/Google_Nest_(smart_speakers))设计的插拔式PCB替换板，基于ESP32和XMOS微控制器，可运行开源固件。

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_1.png" width="1000">

提示！如果你正在寻找用于“Google Home Mini”（谷歌第一代智能音箱，带Micro-USB电源接口）的类似插拔式PCB替换板，请访问姐妹项目：https://github.com/iMike78/home-mini-v1-drop-in-pcb

**注意！** 目前“ MiciMike Home Mini Drop-In PCB”（第一代 Google Home Mini）正在 Crowd Supply 上进行众筹（仅限预售阶段项目预览），如果众筹成功，将计划为新版 Nest Mini（第二代）发起类似活动，请在此查看并通过支持本项目间接支持：

* https://www.crowdsupply.com/micimike-rev-devices/micimike-home-mini-drop-in-pcb

这两个都是完全开源硬件项目，部分理念借鉴了 [Onju Voice](https://github.com/justLV/onju-voice)，但目标是遵循 [Open Home Foundation 的开放语音助手标准并以 Home Assistant Voice Preview Edition 为参考](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)进行 PCB 设计和规范。

# 项目范围

本项目及代码库的目标（类似 [Onju Voice](https://github.com/justLV/onju-voice) 但采用完全开源硬件许可证）是设计一块可直接替换的 PCB（印刷电路板）和硬件原理图，任何人都可自行制作/构建，或从一站式 PCB 制造商订购，作为 Google Nest Mini（第二代）的定制替换 PCB。

本项目主要面向希望将旧 Google Nest Mini 智能音箱转换/重新利用为开源硬件的用户，服务于 [Home Assistant 语音控制](https://www.home-assistant.io/voice_control/) 和/或 [Music Assistant](https://www.music-assistant.io) 媒体播放器音频输出（硬件也可能配合其他固件用于其他应用，因为其基于流行的 Espressif ESP32 平台）。

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/front_render.jpg" width="1000" alt="First test PCB">

硬件设计将（类似 [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)）集成 ESP32-S3 SoC，实现 WiFi、BLE 和 [板载唤醒词检测](https://www.home-assistant.io/voice_control/about_wake_word/)（采用零代码 [ESPHome 固件](https://esphome.io/)）+ XMOS xCORE XU316 芯片用于高级音频处理（通过自定义固件实现麦克风语音清理卸载，提升语音识别效果，采用本地算法实现噪声抑制、声学回声消除、干扰消除和自动增益控制）。

在功能上，它主要与 [Home Assistant Voice Preview Edition（即 Home Assistant Voice PE）](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) 参考设计硬件兼容（已由 Open Home Foundation 与 Nabu Casa 合作以开源硬件形式发布）。主要区别在于受 Google Nest Mini 外壳及元器件限制（即 nest-mini-drop-in-pcb 项目硬件设计将受原 Google 硬件同类物理输入容量约束）。

因此本项目/代码库范围不包括为 ESPHome 固件开发新功能/特性，如果需要此类开发，请转向 Home Assistant Voice Preview Edition 固件开发和 ESPHome 主线代码：

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## 合作邀请

如果你具备 PCB 布局设计经验（特别是 PCB 走线、铺地、或对噪声敏感的数字+模拟混合设计），**非常欢迎你的帮助**！请随时新建 issue，提交建议/需求，或在已有 issue 下提供意见/反馈，也可 fork 本代码库。

关于理念和想法的更多信息及讨论，请见并参与 Home Assistant 社区论坛相关主题：

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### 当前进展

- ✅ 原理图已完成
- ✅ 器件布局已完成
- ✅ 走线已完成
- ✅ 铺地、屏蔽策略、EMI 考虑完成
- ⛔ 第一批测试板有两处错误，已修复

- ⚠️ 第二批测试部分工作正常
- ✅ 下一批已添加XTAG4调试选项

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/back_render.jpg" width="1000">

## 使用的工具

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC用于封装资源获取

## 已知硬件规格

- 4层PCB
- ESP32-S3R8裸芯片（ESP32-S3用于WiFi、BLE和板载唤醒词检测）
- XMOS XU316-1024-QF60B-C24（XMOS XU316 xCORE DSP音频处理）
- 16 MB SPI闪存（ESP32-S3）
- 4 MB SPI闪存（XMOS XU316）
- 双I²S总线（同时音频输入和输出）
- TAS5805M（TAS5805MPWPR）立体声Class-D功放，集成DSP（I2S音频，I2C控制），配置为单声道BTL扬声器输出
- 3个MEMS麦克风（MMICT390200012）以34毫米半径弧形排列——当前固件使用2个麦克风，硬件已支持3麦克风阵列
- 6个SK6812 RGB LED灯
- 定制USB-C和14V电源输入（注意！USB-C和圆孔电源不能同时连接）
- MPR121电容触摸控制器（用于触摸输入，取代ESP32-S3原生触摸感应）

---

> ⚠️ 通过USB-C烧录需要断开主14V电源输入。详情请查看PCB上的丝印说明。

## 参考资料

### Home Assistant Voice Preview Edition资源，包括PCB设计文件
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### 用于Home Assistant Voice PE的ESPHome固件（同样使用ESP32-S3 + XMOS XU316组合）：

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP (XU316-1024-QF60B-C24) MCU 集成电路芯片

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai
 
#### ESPHome 项目为 Home Assistant Voice Preview Edition 硬件提供的 XMOS 固件：

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## 许可证

本项目采用 [CERN 开源硬件许可证第 2 版 - 强制互惠（CERN-OHL-S v2）] 授权。
此硬件的任何修改版本也必须以相同许可证进行分发。

☕ 如果你想支持本项目，欢迎[在 Ko-fi 上请我喝咖啡](https://ko-fi.com/imike78)！




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-24

---
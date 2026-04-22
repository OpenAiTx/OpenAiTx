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

**注意！** “MiciMike Home Mini Drop-In PCB”（第一代 Google Home Mini）的众筹活动即将上线，目前已在 Crowd Supply 预发布阶段（仅项目预览），如果成功，将计划为 Nest Mini 推出匹配活动，详情请见：

* https://www.crowdsupply.com/micimike-rev-devices/micimike-home-mini-drop-in-pcb

这两个项目都是完全开源硬件项目，部分概念灵感来自 [Onju Voice](https://github.com/justLV/onju-voice)，但目标是遵循 [Open Home Foundation 的开放语音助手标准，并以 Home Assistant Voice Preview Edition 为参考](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) 进行 PCB 设计和规范。

# 项目范围

本项目和代码库（类似于 [Onju Voice](https://github.com/justLV/onju-voice)，但采用完全开源硬件许可）旨在设计一款可直接替换的 PCB（印刷电路板）及硬件原理图，任何人都可以自制/制作或从一站式 PCB 制造商订购，作为 Google Nest Mini（第二代）的定制可替换 PCB。

本项目主要面向那些希望将旧 Google Nest Mini 智能音箱转变为开源硬件，实现 [Home Assistant 的语音控制](https://www.home-assistant.io/voice_control/) 和/或 [Music Assistant](https://www.music-assistant.io) 的媒体播放器音箱输出的用户，（但由于基于流行的 Espressif ESP32 平台，该硬件也可用于其他应用场景，通过不同固件实现）。

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

硬件设计将会（类似于 [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)）集成 ESP32-S3 SoC，用于 WiFi、BLE 和 [板载唤醒词检测](https://www.home-assistant.io/voice_control/about_wake_word/)（使用零代码 [ESPHome 固件](https://esphome.io/)）+ XMOS xCORE XU316 芯片进行高级音频处理（通过自定义固件将麦克风清理任务卸载，实现更优语音识别，包括本地运行的噪声抑制、声学回声消除、干扰消除和自动增益控制算法）。

在功能上，该硬件设计大致与 [Home Assistant Voice Preview Edition（即 Home Assistant Voice PE](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) 参考设计（已由 Open Home Foundation 与 Nabu Casa 联合发布为开源硬件设计）兼容。主要区别在于受 Google Nest Mini 外壳和元件的限制（即 nest-mini-drop-in-pcb 项目的硬件设计将受原 Google 硬件相同类型物理容量输入的约束）。

因此本项目/代码库的范围不包括为 ESPHome 固件开发新功能/特性，如有需求请转向 Home Assistant Voice Preview Edition 固件开发及上游 ESPHome 主线代码：

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## 合作请求

如果你有 PCB 布局设计经验（尤其是 PCB 走线、铺地、或对噪声敏感的数字+模拟布局），**非常欢迎你的帮助**！请随时新建 issue，提交建议/需求，为已有问题添加反馈或 fork 本代码库。

有关概念/想法的更多信息及讨论，欢迎参阅并参与 Home Assistant 社区论坛相关讨论帖：

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### 当前进度

- ✅ 原理图设计完成
- ✅ 元件布局完成
- ✅ 走线完成
- ✅ 铺地、屏蔽策略和 EMI 考虑已完成
- ⚠️ 首批测试板因两处错误失败 - 已修正

- 🕓 正在等待第二批测试

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">

## 使用工具

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC 用于封装获取

## 已知硬件规格

- 4层PCB
- ESP32-S3R8裸芯片（ESP32-S3用于WiFi、BLE和板载唤醒词检测）
- XMOS XU316-1024-QF60B-C24（XMOS XU316 xCORE DSP音频处理）
- 双SPI闪存（ESP32和XMOS各自拥有独立的SPI闪存）
- 双I²S总线（支持I2S接口同时工作，即可同时进行音频输入输出）
- TAS5805M（TAS5805MPWPR）用于扬声器输出（I2S D类单声道音频放大器，I2C配置DSP）
- 2个MEMS麦克风（双MMICT390200012，麦克风间距68mm）
- 6个SK6812 RGB LED灯
- 定制USB-C和14V电源输入（注意！USB-C和圆孔电源接口不可同时连接）

---

> ⚠️ 通过USB-C烧录时需要断开主14V电源输入。详细信息见PCB上的丝印说明。

## 参考资料

### Home Assistant Voice Preview Edition 资源，包括PCB设计文件
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### 用于Home Assistant Voice PE的ESPHome固件（同样采用ESP32-S3 + XMOS XU316组合）：

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP（XU316-1024-QF60B-C32）MCU芯片

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai
 
#### 来自ESPHome项目、用于Home Assistant Voice Preview Edition硬件的XMOS固件：

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## 许可证

本项目遵循 [CERN Open Hardware License Version 2 - Strongly Reciprocal (CERN-OHL-S v2)] 许可协议
任何对该硬件的修改版本也必须在相同的许可证下分发。

☕ 如果你想支持这个项目，欢迎在 [Ko-fi 上请我喝咖啡](https://ko-fi.com/imike78)！




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-22

---
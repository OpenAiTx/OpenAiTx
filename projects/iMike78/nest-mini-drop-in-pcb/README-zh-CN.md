
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

# MiciMike 用于 Google Nest Mini 的可替换 PCB

[MiciMike Nest Mini](https://github.com/iMike78/nest-mini-drop-in-pcb) 是一个用于["Google Nest Mini"（谷歌第二代智能音箱，采用圆柱形电源接口）](https://en.wikipedia.org/wiki/Google_Nest_(smart_speakers))的可替换 PCB，采用 ESP32 和 XMOS 微控制器，支持运行开源固件。

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_1.png" width="1000">

提示！如果你正在寻找针对“Google Home Mini”（谷歌第一代智能音箱，采用 Micro-USB 电源接口）类似的可替换 PCB，请访问姐妹项目 https://github.com/iMike78/home-mini-v1-drop-in-pcb

这两个项目都是完全开源硬件项目，部分概念灵感来自 [Onju Voice](https://github.com/justLV/onju-voice)，但旨在遵循 [Open Home Foundation 的开放语音助手标准，以 Home Assistant Voice Preview Edition 作为参考](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)，用于 PCB 设计和规范。

# 项目范围

本项目及其代码库的目标（类似于 [Onju Voice](https://github.com/justLV/onju-voice)，但采用完全开源硬件许可证）是设计一个可直接替换的 PCB（印刷电路板）及硬件原理图，任何人都可以制作、组装或从一站式 PCB 制造商订购，作为 Google Nest Mini（第二代）的定制可插拔替换 PCB。

该项目主要面向希望将旧 Google Nest Mini 智能音箱改造/重新利用为开源硬件，用于 [Home Assistant 的语音控制](https://www.home-assistant.io/voice_control/) 和/或为 [Music Assistant](https://www.music-assistant.io) 提供媒体播放器音箱输出的人群，（但此硬件也很可能可用于其它应用及固件，因为它基于流行的 Espressif ESP32 平台）。

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

硬件设计将（类似于 [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)）集成 ESP32-S3 SoC，实现 WiFi、BLE 和 [板载唤醒词检测](https://www.home-assistant.io/voice_control/about_wake_word/)（使用零代码 [ESPHome 固件](https://esphome.io/)）+ XMOS xCORE XU316 芯片，用于高级音频处理（通过自定义固件实现麦克风清理卸载，提高语音识别能力，利用本地算法进行噪声抑制、声学回声消除、干扰消除和自动增益控制）。

在功能方面，该硬件将与 [Home Assistant Voice Preview Edition（又称 Home Assistant Voice PE）](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) 参考设计大体兼容（该参考设计已由 Open Home Foundation 与 Nabu Casa 合作以开源硬件形式发布）。主要区别在于 Google Nest Mini 外壳和元件所定义的约束，（即 nest-mini-drop-in-pcb 项目的硬件设计将受限于与 Google 原始硬件相同类型的物理输入能力）。

因此，本项目/代码库的范围不包括为 ESPHome 固件开发新功能/特性，如果你需要此类开发，请转向 Home Assistant Voice Preview Edition 的固件开发以及 ESPHome 主线代码：

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## 合作请求

如果你有 PCB 布局设计经验，（特别是 PCB 走线、地层铺设或对噪声敏感的数字+模拟布局），**非常欢迎你的协助**！请随时新建 issue，提交建议/需求，补充意见/反馈，或分叉本代码库。

更多关于该概念/想法的信息及相关讨论，请参见并参与 Home Assistant 社区论坛此主题：

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### 当前状态

- ✅ 原理图已完成
- ✅ 元件摆放已完成
- ✅ 走线已完成
- ✅ 地层铺设、屏蔽策略及 EMI 考虑已完成
- ⚠️ 第一批测试失败，两处错误已修复
- 🕓 正在等待第二批测试

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">

## 使用工具
- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC 用于封装来源

## 已知硬件规格

- 4层PCB
- ESP32-S3R8裸片（ESP32-S3用于WiFi、BLE和板载唤醒词检测）
- XMOS XU316-1024-QF60B-C32（XMOS XU316 xCORE DSP音频处理）
- 双SPI闪存
- 双I²S总线（可同时支持I2S接口，即音频输出与音频输入同时进行）
- MAX98357用于扬声器输出（I2S D类单声道音频放大器）
- 2个MEMS麦克风（MSM261DHP）
- SK6812 LED灯
- 定制USB-C和14V电源输入

---

> ⚠️ 通过USB-C烧录时需断开主14V电源输入。详细信息请参见PCB上的丝印备注。

## 参考资料

### 包含PCB设计文件的Home Assistant Voice Preview Edition资源
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/zh-cn/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### 用于Home Assistant Voice PE的ESPHome固件（同样使用ESP32-S3 + XMOS XU316组合）：

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP（XU316-1024-QF60B-C32）MCU芯片

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/

  - https://www.xmos.com/xcore-ai
 
#### 来自 ESPHome 项目的 XMOS 固件，适用于 Home Assistant Voice 预览版硬件：

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## 许可证

本项目采用 [CERN 开源硬件许可证第 2 版 - 强制互惠 (CERN-OHL-S v2)] 授权。
任何对此硬件进行修改的版本也必须采用相同的许可证进行分发。

☕ 如果您愿意支持本项目，欢迎在 [Ko-fi 上请我喝咖啡](https://ko-fi.com/imike78)！



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---
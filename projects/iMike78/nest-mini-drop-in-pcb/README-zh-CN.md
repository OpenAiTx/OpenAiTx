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

这两个项目都是完全开源的硬件项目，部分概念灵感来自 [Onju Voice](https://github.com/justLV/onju-voice)，但目标是遵循 [Open Home Foundation 的开放语音助手标准，并以 Home Assistant Voice Preview Edition 为参考](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)进行 PCB 设计和规范。

# 项目范围

本项目及仓库的目标（类似于 [Onju Voice](https://github.com/justLV/onju-voice)，但采用完全开源硬件许可）是设计一块可直接替换的 PCB（印刷电路板）及硬件原理图，任何人都可以制作/组装或通过一站式 PCB 制造商定制订购，作为 Google Nest Mini（第二代）的专用替换 PCB。

本项目主要面向希望将旧 Google Nest Mini 智能音箱转换/改造成用于 [Home Assistant 语音控制](https://www.home-assistant.io/voice_control/) 的开源硬件，和/或用于 [Music Assistant](https://www.music-assistant.io) 的媒体播放器音箱输出的用户，（当然，硬件也可能适用于其他应用，只需更换固件，因为它基于流行的 Espressif ESP32 平台）。

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

硬件设计将（类似于 [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)）集成 ESP32-S3 SoC，实现 WiFi、BLE 和 [板载唤醒词检测](https://www.home-assistant.io/voice_control/about_wake_word/)（使用零代码 [ESPHome 固件](https://esphome.io/)）+ XMOS xCORE XU316 芯片用于高级音频处理（通过定制固件实现麦克风清理卸载，以便更好地进行语音识别，利用本地算法实现噪声抑制、声学回声消除、干扰消除和自动增益控制）。

在功能方面，硬件将尽量与 [Home Assistant Voice Preview Edition（即 Home Assistant Voice PE）](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)参考设计兼容（该设计已由 Open Home Foundation 与 Nabu Casa 合作以开源硬件形式发布）。主要区别在于 Google Nest Mini 外壳和元件所定义的约束（即 nest-mini-drop-in-pcb 项目的硬件设计将受限于与 Google 原始硬件相同的物理输入能力）。

因此，本项目/仓库的范围不包括为 ESPHome 固件开发新功能/特性，如果您有此需求，请转向 Home Assistant Voice Preview Edition 的固件开发以及上游 ESPHome 主线代码：

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## 合作请求

如果您有 PCB 布局设计经验（尤其是 PCB 走线、铺铜或对数字+模拟敏感噪声布局），**非常欢迎您的加入**！请随时新建 Issue，提交建议/需求，参与现有问题的讨论，或 Fork 本仓库。

有关该概念/想法的更多信息及相关讨论，请参见并参与 Home Assistant 社区论坛相关话题：

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### 当前状态

- ✅ 原理图已完成
- ✅ 元件布局已完成
- ✅ 走线已完成
- ✅ 铺铜、屏蔽策略和 EMI 考虑已完成
- ⚠️ 第一批测试板因两处错误失败 - 已修复
- 🕓 正在等待第二批测试板

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">


## 使用工具

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC 用于封装资源获取

## 已知硬件规格

- 4 层 PCB
- ESP32-S3R8 裸芯片（ESP32-S3 用于 WiFi、BLE 及板载唤醒词检测）
- XMOS XU316-1024-QF60B-C24（XMOS XU316 xCORE DSP 音频处理）
- 双 SPI 闪存（ESP32 和 XMOS 分别拥有独立 SPI 闪存）
- 双 I²S 总线（可同时支持 I2S 接口，例如音频输入和输出同时进行）
- MAX98357 用于扬声器输出（I2S Class-D 单声道音频放大器）
- 2 个 MEMS 麦克风（双 MMICT390200012，麦克风间距 68mm）
- 6 个 SK6812 RGB LED 灯
- 定制 USB-C 和 14V 电源输入（注意！USB-C 与圆口电源不能同时连接）

---

> ⚠️ 通过 USB-C 烧录时需断开主 14V 电源输入。详见 PCB 丝印注释。

## 参考文献

### Home Assistant Voice Preview Edition 资源及 PCB 设计文件
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Home Assistant Voice PE 的 ESPHome 固件（同样采用 ESP32-S3 + XMOS XU316 组合）：

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP (XU316-1024-QF60B-C32) MCU IC 芯片

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai
 
#### 来自 ESPHome 项目的 XMOS 固件，用于 Home Assistant Voice 预览版硬件：

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## 许可证

本项目采用 [CERN 开源硬件许可证第 2 版 - 强烈互惠（CERN-OHL-S v2）] 授权
本硬件的任何修改版本也必须在相同许可证下分发。

☕ 如果您想支持本项目，欢迎在 [Ko-fi 上请我喝杯咖啡](https://ko-fi.com/imike78)！



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-03

---
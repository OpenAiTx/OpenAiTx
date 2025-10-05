# MiciMike 适用于 Google Nest Mini 的替换插入式 PCB

[MiciMike Nest Mini](https://github.com/iMike78/nest-mini-drop-in-pcb) 是一个替换插入式 PCB，用于替换[“Google Nest Mini”（Google 第二代智能音箱，带桶形连接器充电口）](https://en.wikipedia.org/wiki/Google_Nest_(smart_speakers))，但基于 ESP32 和 XMOS 微控制器运行开源固件。

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_1.png" width="1000">

提示！如果你是在寻找类似的替换插入式 PCB 用于“Google Home Mini”（Google 第一代智能音箱硬件，带 Micro-USB 充电口），请查看姐妹项目：https://github.com/iMike78/home-mini-v1-drop-in-pcb

这两个项目都是完全开源硬件项目，设计理念部分借鉴了 [Onju Voice](https://github.com/justLV/onju-voice)，但目标是遵循[Open Home Foundation 的开放语音助手标准，以 Home Assistant Voice Preview Edition 为参考](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)进行 PCB 设计和规范。

# 项目范围

本项目及代码库的目标（类似于 [Onju Voice](https://github.com/justLV/onju-voice) 但采用完全开源硬件许可）是设计一个替换插入式 PCB（印刷电路板）及硬件原理图，任何人都可以制造/组装或从一站式 PCB 制造商订购，作为 Google Nest Mini（第二代）的定制替换插入式 PCB。

该项目主要面向希望将旧的 Google Nest Mini 智能音箱转换/再利用为开源硬件，用于[Home Assistant 的语音控制](https://www.home-assistant.io/voice_control/)和/或作为[Music Assistant](https://www.music-assistant.io)的媒体播放器扬声器输出的用户，（该硬件也可能基于流行的 Espressif ESP32 平台，用于其他固件和应用场景）。

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

硬件设计将（类似于[Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)）集成一个 ESP32-S3 SoC 用于 WiFi、BLE 和[板载唤醒词检测](https://www.home-assistant.io/voice_control/about_wake_word/)（使用无代码的[ESPHome 固件](https://esphome.io/)）+ 一个 XMOS xCORE XU316 芯片用于高级音频处理（配备自定义固件，实现麦克风信号清理卸载，使用本地运行的噪声抑制、声学回声消除、干扰消除和自动增益控制算法，提高语音识别能力）。

功能方面，它大致与[Home Assistant Voice Preview Edition（简称 Home Assistant Voice PE）](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)参考设计硬件兼容（该设计由 Open Home Foundation 与 Nabu Casa 合作发布为开源硬件）。主要区别在于受限于 Google Nest Mini 的外壳和组件，（即 nest-mini-drop-in-pcb 项目硬件设计将受原 Google 硬件同等物理尺寸和接口限制）。

因此，本项目/代码库的范围不包括为 ESPHome 固件开发新功能/特性，如果你需要这部分内容，请转向 Home Assistant Voice Preview Edition 固件开发以及上游 ESPHome 主线代码：

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## 协作请求

如果你有 PCB 布局设计经验，（尤其是 PCB 走线、地平面铺铜或对数字+模拟噪声敏感的布局），**非常欢迎你的帮助**！请随时打开新 issue，提交建议/请求，或对现有 issue 提供输入/反馈，或 fork 本仓库。

关于概念/想法的更多信息及相关讨论，请参阅 Home Assistant 社区论坛主题：

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### 当前状态

- ✅ 原理图完成
- ✅ 元件布局完成
- ✅ 完成布线
- ✅ 完成地平铺、屏蔽策略和电磁干扰（EMI）考虑
- ⚠️ 第一批测试出现两个错误 - 已修复
- 🕓 等待第二批测试

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">

## 使用工具

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC 用于封装资源

## 已知硬件规格

- 四层PCB
- ESP32-S3R8裸芯片（ESP32-S3用于WiFi、BLE及板载唤醒词检测）
- XMOS XU316-1024-QF60B-C32（XMOS XU316 xCORE DSP音频处理）
- 双SPI闪存
- 双I²S总线（支持同时使用I2S接口，即同时音频输出和输入）
- MAX98357扬声器输出（I2S类D单声道音频放大器）
- 2个MEMS麦克风（MSM261DHP）
- SK6812 LED灯
- 定制USB-C和14V电源输入

---

> ⚠️ 通过USB-C刷写固件时需要断开主14V电源输入。详情请参见PCB丝印标注。

## 参考资料

### Home Assistant Voice 预览版资源及PCB设计文件
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Home Assistant Voice PE的ESPHome固件（同样使用ESP32-S3 + XMOS XU316组合）：

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP (XU316-1024-QF60B-C32) MCU 集成电路芯片

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai
 
#### ESPHome 项目中用于 Home Assistant 语音预览版硬件的 XMOS 固件：

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## 许可证

本项目采用 [CERN 开放硬件许可证版本 2 - 强互惠 (CERN-OHL-S v2)] 授权
任何修改后的硬件版本也必须在相同许可证下分发。

☕ 如果您想支持本项目，欢迎通过 [Ko-fi 买我一杯咖啡](https://ko-fi.com/imike78)!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-05

---
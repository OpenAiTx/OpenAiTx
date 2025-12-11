## OpenFIRE-DONGLE for EPS32


![foto_dongle](https://github.com/user-attachments/assets/a38d7390-f7e7-42d7-844c-ad8388670f6d)



https://github.com/user-attachments/assets/70a193a0-686e-4da3-8d30-f0067de6b63c



本仓库创建用于配合OpenFIRE-Firmware-ESP32项目的代码使用，该项目是TeamOpenFIRE原始“OpenFIRE-firmware”项目的移植版本，适配于ESP32S3微控制器。
该项目使用PlatformIO开发，作为ESP32S3的固件，用作连接到PC的加密狗，通过ESP32的ESP-NOW协议实现无线连接。该加密狗设计用于与安装在光枪上的“OpenFIRE-Firmware-ESP32”固件配合使用。
代码结构设计为自动检测光枪并自主配置。
光枪与加密狗之间的通信是双向的，允许光枪像直接通过USB连接到PC一样工作。
PC无法区分直接USB连接和通过加密狗的无线连接。
我衷心感谢TeamOpenFIRE创建了“OpenFIRE”项目；所有荣誉和我最深的谢意都归于他们。
代码中有一小部分摘自并修改自“SerialTransfer”仓库：https://github.com/PowerBroker2/SerialTransfer.git。
因此，我也要感谢该代码的作者PowerBroker2的贡献。


This repository was created to be used together with the code from the OpenFIRE-Firmware-ESP32 project, a porting of the original 'OpenFIRE-firmware' project by TeamOpenFIRE, adapted to work on the ESP32S3 microcontroller.
The project, developed using PlatformIO, serves as the firmware for an ESP32S3 to be used as a dongle connected to the PC, enabling wireless connectivity through the ESP-NOW protocol of ESP32. This dongle is designed to be used in combination with the firmware 'OpenFIRE-Firmware-ESP32', which is installed on the lightgun.
The code is structured to automatically detect lightguns and configure itself independently.
The communication between the lightgun and the dongle is bidirectional, allowing the lightgun to function as if it were directly connected to the PC via USB.
The PC does not notice any difference between a direct USB connection and a wireless connection through the dongle.
I would like to express my sincere gratitude to TeamOpenFIRE for creating the 'OpenFIRE' project; all credit and my deepest appreciation go to them.
A small portion of the code was taken and modified from the repository "SerialTransfer": https://github.com/PowerBroker2/SerialTransfer.git.
I would therefore like to thank the author of this code, PowerBroker2, for their contribution.


## ... segue la pagina originale del progetto 'OpenFIRE-firmware' del TeamOpenFIRE
## ... follows the original project page 'OpenFIRE-firmware' project by TeamOpenFIRE

### Like our work? [Remember to support the developers!](https://github.com/TeamOpenFIRE/.github/blob/main/profile/README.md)

![BannerDark](https://raw.githubusercontent.com/alessandro-satanassi/OpenFIRE-DONGLE-ESP32/main/docs/of_bannerLoD.png#gh-dark-mode-only)![BannerLight](https://raw.githubusercontent.com/alessandro-satanassi/OpenFIRE-DONGLE-ESP32/main/docs/of_bannerDoL.png#gh-light-mode-only)
# OpenFIRE - The Open *Four Infa-Red Emitter* Light Gun System
###### Successor to [IR-GUN4ALL](http://github.com/SeongGino/ir-light-gun-plus), which is based on the [Prow Enhanced fork](https://github.com/Prow7/ir-light-gun), which in itself is based on the 4IR Beta "Big Code Update" [SAMCO project](https://github.com/samuelballantyne/IR-Light-Gun)

## 特性：
- **功能齐全的外设**，涵盖电磁铁与震动力反馈、TMP36 温度监测，以及未来更多功能。
- **多种红外布局支持**，具有*实时透视调整跟踪*，适用于双光条（推荐！）和类似 Xwiigun 的菱形布局（兼容其他系统）。
- **灵活的输入系统**，输出支持键盘、5按钮绝对定位鼠标和带方向键支持的双摇杆手柄，配备**强大的按键映射系统**，满足您的需求！
- **简易安装**，使用简单的 *.UF2* 二进制文件，可直接拖放到基于 *RP2040* 的微控制器上。
- **便携的板载设置**，用于存储校准配置文件、切换开关、设置、USB 标识等。
- **集成[OpenFIRE 应用](https://github.com/TeamOpenFIRE/OpenFIRE-App)**，实现用户友好且跨平台的即刻配置。
- **针对 RP2040 优化**，利用其第二核心进行输入轮询与排队及串口处理，主核心则处理摄像头和外设。
- **兼容 PC 力反馈处理器**，如 [Mame Hooker](https://dragonking.arcadecontrols.com/static.php?page=aboutmamehooker)、[The Hook Of The Reaper](https://github.com/6Bolt/Hook-Of-The-Reaper) 和 [QMamehook](https://github.com/SeongGino/QMamehook)。
- **支持集成 OLED 显示输出**，适用于 *SSD1306 I2C 显示屏*，用于菜单导航及游戏元素（如生命值和当前弹药数）的视觉反馈。
- **兼容 MiSTer FPGA 生态系统**，提供专用映射，最大程度简化用户体验。
- **永远免费且开源，服务于光枪社区！**

___
## 致谢：
* Samuel Ballantyne，感谢其原创的 SAMCO 项目、精美的 OpenFIRE 品牌设计及基于透视的跟踪系统。
* Prow7，感谢其增强版 SAMCO 分支，为暂停模式和保存子系统提供基础。
* Odwalla-J、mrkylegp、RG2020 及 lemmingDev，感谢其预发布咨询、错误测试和反馈。
* IR-GUN4ALL 测试者，感谢其早期反馈和功能请求——没有你们，这一切都不会发生！
* Chris Young，感谢其 TinyUSB 兼容库（现为 `TinyUSB_Devices` 的一部分）。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---
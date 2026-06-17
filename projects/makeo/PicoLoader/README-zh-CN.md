# PicoLoader  
这是一个基于ODE的任天堂GameCube光驱改装芯片，用于启动自制软件。\
其价格和功能与[PicoBoot](https://github.com/webhdx/PicoBoot)非常相似，但它具有多种优势。  

加入[Discord服务器](https://discord.gg/YtA9aU3BKZ)以获得支持并讨论该改装！  

## 它是如何工作的？  
该改装通过在启动时模拟光驱，执行自制应用程序，然后重新启用光驱来工作。\
这是通过类似FlippyDrive的柔性PCB实现的。  
然而，它不是完整的光驱模拟器，仅允许像PicoBoot一样从闪存执行小型自制应用程序（例如[swiss](https://github.com/emukidid/swiss-gc)）。  
要访问SD卡上的文件，需要SDGecko、SD2SP2或类似适配器，这些可以单独购买。  

## 特性  
- 开源  
- 可保留光驱  
- 使用[在线转换器](https://makeo.github.io/PicoLoader/converter/)简单启动大多数自制应用  
- 不会对GameCube做永久改动  
- [3D打印插头](https://github.com/makeo/PicoLoader/raw/refs/heads/main/mount/Drive_PlugV1.1.stl)，适用于无光驱安装  
- 易于拆卸  
- Pico运行在200MHz，提升与克隆主板的兼容性  

#### 焊接版本  
- 便宜且易得的组件（Raspberry Pi Pico/Pico 2 + 柔性PCB + 二极管）  
- 现货供应充足  
- 无需直接焊接到GameCube  
- 焊接简单  
- 替代安装选项：[Panasonic Q](https://github.com/makeo/PicoLoader/wiki/4.-Advanced-Section#panasonic-q-install-option)、[低矮型](https://github.com/makeo/PicoLoader/wiki/4.-Advanced-Section#low-profile-install-option)  

#### 无焊版本  
- 无需焊接  
- 柔性PCB易于更换  
- 预装PicoLoader固件和[Swiss](https://github.com/emukidid/swiss-gc)  
> [!TIP]  
> 你可以从[store.makstech.io](https://store.makstech.io/)购买无焊和普通版本。  

## 计划功能  
*蟋蟀声*  

## 安装与文档  
> [!IMPORTANT]
> 请遵循维基中的[安装说明](https://makeo.github.io/PicoLoader/)。\
> 不按说明操作，有可能在安装过程中损坏柔性电路板。

开始请查看📖[维基](https://github.com/makeo/PicoLoader/wiki/1.-Home)！

## 图库

<div style="display: flex; gap: 10px; flex-wrap: nowrap; justify-content: center;">
  <a href="#"><img style="width: 23%; height: auto;" alt="1" src="https://github.com/user-attachments/assets/9dbe6a59-c3cd-4a4b-9462-4ebc6618a6cf" /></a>
  <a href="#"><img style="width: 23%; height: auto;" alt="2" src="https://github.com/user-attachments/assets/87efdaf1-e2e6-4f9f-9bec-5a52d9c549fe" /></a>
  <a href="#"><img style="width: 23%; height: auto;" alt="3" src="https://github.com/user-attachments/assets/02900e41-325a-48d2-bb01-8081845d7696" /></a>
  <a href="#"><img style="width: 23%; height: auto;" alt="4" src="https://github.com/user-attachments/assets/9d39575d-f7d6-4cbe-b33c-1c6f40ef0f82" /></a>
</div>
<div style="display: flex; gap: 10px; flex-wrap: nowrap; justify-content: center;">
  <a href="#"><img style="width: 23%; height: auto;" alt="1" src="https://github.com/user-attachments/assets/6027feaa-74c6-407d-be00-104c46bffad4" /></a>
  <a href="#"><img style="width: 23%; height: auto;" alt="2" src="https://github.com/user-attachments/assets/d55b692a-20f6-4cfc-925d-57860416c55e" /></a>
  <a href="#"><img style="width: 23%; height: auto;" alt="3" src="https://github.com/user-attachments/assets/2b155744-3261-40e2-8d08-9167f2aca5f7" /></a>
  <a href="#"><img style="width: 23%; height: auto;" alt="4" src="https://github.com/user-attachments/assets/85811813-3d21-497a-a214-eda23bb56491" /></a>
</div>

## 特别感谢
- 感谢 [silversteel](https://github.com/silverstee1) 的帮助，尤其是制作柔性PCB和支架
- 感谢 [TeamOffBroadway](https://github.com/OffBroadway) 提出的使用柔性PCB截取驱动信号的绝妙创意
- 感谢 [Extrems](https://github.com/Extrems)、[emukidid](https://github.com/emukidid) 及所有参与 Swiss 创建的人
- 感谢 [novenary (9ary)](https://github.com/9ary) 为 gekkoboot 所做贡献

## 致谢
[gbi.hdr](https://github.com/makeo/PicoLoader/blob/main/picoloader/data/gbi.hdr) 和 [gbi_disable_ipl.hdr](https://github.com/makeo/PicoLoader/blob/main/picoloader/data/gbi_disable_ipl.hdr) 的源代码采用 GPL-2.0 许可，代码可在[此处](https://github.com/makeo/cubeboot-tools)获得。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-17

---
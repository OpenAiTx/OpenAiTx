项目采用 [Apache 2.0](https://www.apache.org/licenses/LICENSE-2.0) 许可证授权


机械设计采用：
[知识共享 署名 4.0 国际许可协议][cc-by]。
[![CC BY 4.0][cc-by-image]][cc-by]
[![CC BY 4.0][cc-by-shield]][cc-by]

[cc-by]: http://creativecommons.org/licenses/by/4.0/
[cc-by-image]: https://licensebuttons.net/l/by/4.0/88x31.png
[cc-by-shield]: https://img.shields.io/badge/License-CC%20BY-lightgrey.svg



# Amazing Hand 项目

![Patterns](https://raw.githubusercontent.com/pollen-robotics/AmazingHand/main/assets/Patterns_Overview.jpg)

机器人手通常非常昂贵且表达能力有限。更灵巧的设计通常需要电缆和前臂中的远端执行器。

本项目的目标是在真实机器人上探索类人手的可能性（Reachy2 是完美的候选者！），且成本适中。
=> 手腕接口专为 Reachy2 的手腕（Orbita 3D）设计，但可以轻松适配其他机器人的手腕...

![Reachy](https://raw.githubusercontent.com/pollen-robotics/AmazingHand/main/assets/Reachy.jpg)

Amazing Hand 具有：
- 8 自由度类人手，带 4 根手指
- 每根手指有 2 个指节关节连接
- 几乎所有部位均采用柔性外壳
- 所有执行器均置于手内部，无任何电缆
- 可 3D 打印
- 重量 400 克
- 低成本（<200€）
- 开源

[AmazingHand_Overview](/docs/AmazingHand_Overview.pdf)

![Hand Overview](https://raw.githubusercontent.com/pollen-robotics/AmazingHand/main/assets/Hand_Overview.jpg)
每根手指由并联机构驱动。
这意味着每根手指使用 2 个小型 Feetech SCS0009 舵机来完成屈伸和外展/内收动作。

![Finger Overview](https://raw.githubusercontent.com/pollen-robotics/AmazingHand/main/assets/Finger_Overview.jpg)


提供两种控制方式：
- 使用串口总线驱动器（如 waveshare）+ Python 脚本
- 使用 Arduino + feetech TTL Linker

两种方式均有详细说明，并提供基础演示软件。
随你选择！


## 目录

- [构建资源](#build-resources)
    - [物料清单 (BOM)](#bom-bill-of-materials)
    - [CAD 文件和 Onshape 文档](#CAD-files-and-onshape-document)
    - [装配指南](#assembly-guide)
    - [运行基础演示](#Run-basic-Demo)
- [免责声明](#disclaimer)
- [AmazingHand_追踪演示](#AmazingHand_tracking_Demo)
- [项目更新与社区](#project-updates--community)
    - [更新历史](#updates-history)
    - [项目帖子](#project-posts)
    - [待办事项](#to-do-list)
    - [常见问题](#faq)
    - [联系方式](#contact)
    - [致谢](#thank-you)


# 构建资源
## 物料清单 (BOM)
所有所需组件列表见此处：  
[AmazingHand 物料清单](https://docs.google.com/spreadsheets/d/1QH2ePseqXjAhkWdS9oBYAcHPrxaxkSRCgM_kOK0m52E/edit?gid=1269903342#gid=1269903342)  
![BOM](https://raw.githubusercontent.com/pollen-robotics/AmazingHand/main/assets/BOM.jpg)

请记得加上控制方案的成本（前文详述的两种选项）


定制 3D 打印部件的详细信息见此处：  
[3D 打印部件](https://docs.google.com/spreadsheets/d/1QH2ePseqXjAhkWdS9oBYAcHPrxaxkSRCgM_kOK0m52E/edit?gid=2050623549#gid=2050623549)

![3Dparts](https://raw.githubusercontent.com/pollen-robotics/AmazingHand/main/assets/3Dparts.jpg)

这里是打印所有所需定制部件的指南：
[=> 3D 打印指南](/docs/AmazingHand_3DprintingTips.pdf)
![3DPrint_example](/assets/3DPrint.jpg) 



## CAD 文件和 Onshape 文档
STL 和 Steps 文件可在此处下载：[链接](https://github.com/pollen-robotics/AmazingHand/tree/main/cad)

请注意，如果你想制作左手，手指是相同的，但部分零件是对称的。右手专用零件以 “R” 开头，左手零件以 “L” 开头。

![Heart](/assets/Heart.jpg)

任何人均可访问 Onshape 文档：  
[Onshape 链接](https://cad.onshape.com/documents/430ff184cf3dd9557aaff2be/w/e3658b7152c139971d22c688/e/bd399bf1860732c6c6a2ee45?renderMode=0&uiState=6867fd3ef773466d059edf0c)  

请注意，预定义位置可在“命名位置”工具中使用，并具有对应的舵机角度

![Onshape&Named_Pos](/assets/Named_Pos.jpg)  

## 装配指南

Amazing Hand 与物料清单中标准组件的装配指南在此：  
[=> 装配指南](/docs/AmazingHand_Assembly.pdf)  
![Assembly_example](/assets/Assembly.jpg)  

您需要一个简单的程序/脚本来校准每根手指，脚本可在这里获取：
- 使用 Python 和 Waveshare 串行总线驱动：[这里](https://github.com/pollen-robotics/AmazingHand/tree/main/PythonExample)
- 使用 Arduino 和 TTLinker：[这里](https://github.com/pollen-robotics/AmazingHand/tree/main/ArduinoExample)


请注意，此装配指南适用于独立的右手。

如果您需要构建独立的左手，可以保持舵机位置的相同 ID，并在软件中选择是右手还是左手。

但如果您需要同时构建右手和左手以连接到机器人上，必须为左右手分配不同的 ID。您不能在同一串行总线上为不同的舵机使用相同的 ID...

## 运行基础演示

基础演示同时支持 Python 和 Arduino。

您需要外部电源为手内的 8 个执行器供电。

如果您还没有，可以使用简单的外部电源，例如 DC/DC 220V -> 5V / 2A 适配器带插孔连接器。
请查看物料清单：
[AmazingHand 物料清单](https://docs.google.com/spreadsheets/d/1QH2ePseqXjAhkWdS9oBYAcHPrxaxkSRCgM_kOK0m52E/edit?gid=1269903342#gid=1269903342) 

- Python 脚本："AmazingHand_Demo.py" [这里](https://github.com/pollen-robotics/AmazingHand/tree/main/ArduinoExample)
  
- Arduino 程序："AmazingHand_Demo.ino" [这里](https://github.com/pollen-robotics/AmazingHand/tree/main/PythonExample)


https://github.com/user-attachments/assets/485fc1f4-cc57-4e59-90b5-e84518b9fed0


# 免责声明

我注意到理论上的屈伸角度、外展/内收角度与实际原型中的角度存在一些差异。这可能是由于多种因素造成的（3D 打印零件不完美，万向节杆件逐个手动调整，舵机臂重新加工，塑料零件的柔韧性等）。

该设计尚未经过长时间复杂抓取任务的测试。在能够安全抓取物体（即不会损坏舵机或机械零件）之前，需要开发一种智能软件。
SCS0009 舵机具有智能功能，例如：
- 扭矩启用/禁用
- 扭矩反馈
- 当前位置信息传感器
- 温度反馈
- ...


# AmazingHand 高级演示
[![跟踪演示](https://img.youtube.com/vi/U0TfeG3ZUto/maxresdefault.jpg)](https://www.youtube.com/watch?v=U0TfeG3ZUto)

关于使用逆向/正向运动学的高级用法，Demo 目录中有多个示例以及一些用于测试/配置电机的有用工具。


# 项目更新与社区
## 社区更新

Amazing Hand 的基础座：  
![Base](https://raw.githubusercontent.com/pollen-robotics/AmazingHand/main/assets/Base.jpg)  
STL 或 Step 文件可在此找到：[这里](https://github.com/pollen-robotics/AmazingHand/tree/main/cad) 

特定中国物料清单如下：
[中国物料清单](https://docs.google.com/spreadsheets/d/1fHZiTky79vyZwICj5UGP2c_RiuLLm89K8HrB3vpb2h4/edit?gid=837395814#gid=837395814)

感谢 Shen Jianliang！

## 待办事项
- 设计带有串行集线器和电源功能的小型定制 PCB，以将所有部件集成到手内
- 测试抓握任务  
      => 基于现有电机反馈，增加更智能的闭合手部行为
- 研究实现 4 种不同手指长度，或增加第 5 根手指的可能性
- 研究用 STS3032 脚踏电机替代 SCS0009 的可能性  
      => 在体积相近的情况下更强大，但舵机臂不同
- 研究通过用弹簧替换刚性连杆以增加柔顺性的可能性
- 添加指尖传感器，推动智能控制更进一步


## 常见问题
进行中

## 联系方式

您可以通过公共 Discord 频道联系：  
[Discord AmazingHand](https://discord.com/channels/519098054377340948/1395021147346698300)

或者  
[联系我或 Pollen Robotics](/docs/contact.md)

## 感谢
衷心感谢迄今为止为该项目作出贡献的人士：
- [Steve N'Guyen](https://github.com/SteveNguyen) 负责 beta 测试、Feetech 电机集成至 Rustypot、Mujoco/Mink 和手部跟踪演示
- [Pierre Rouanet](https://github.com/pierre-rouanet) 负责 Feetech 电机集成至 pypot  
- [Augustin Crampette](https://fr.linkedin.com/in/augustin-crampette) 和 [Matthieu Lapeyre](https://www.linkedin.com/in/matthieulapeyre/) 负责开放讨论与机械建议


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---
# 27C322/160/800/400 EPROM 编程适配器系列

![GitHub issues](https://img.shields.io/github/issues-raw/mafe72/27c160-tl866-adapter?logo=Github&style=for-the-badge)

## 介绍

该适配器将以下列出的部件的引脚转换为27C4096引脚配置，后者由现成且廉价的TL866系列USB编程器支持，这些部件的引脚布局类似于当代DIP封装的掩膜ROM。

支持的EPROM部件包括：
- **27C400：** 40引脚，4Mbit（256k x 16位，512k x 8位）
- **27C800：** 42引脚，8Mbit（512k x 16位，1M x 8位）
- **27C160：** 42引脚，16Mbit（1M x 16位，2M x 8位）
- **27C322：** 42引脚，32Mbit（2M x 16位，无8位访问模式）

## 设计

该适配器使用KiCad 5.0设计，项目文件可在名为kicad-project的文件夹中找到。

顶层视图：

![top](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/front_th.png)

底层视图：

![bottom](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/back_th.png)

## 使用方法

将编程适配器插入TL866，确保插座手柄相邻。将EPROM插入适配器中最低可能的位置，且引脚1靠近手柄。

![Adapter when in use](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/adapter_in_use.jpg)

如果您正在编程27C322 EPROM，将开关拨到**Position 27c322**位置；对于27C160、27C400和27C800 EPROM，开关必须位于**Position other**位置。

![Adapter mode](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/addapter_mode.jpg)

## 软件

以下说明描述了如何写入27c160 EPROM。

将源EPROM拆分成512K字节的部分，在此案例中我使用HJSplit，但也可以使用其他程序。

![HJSplit](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/hjsplit_512k.jpg)

定位输出路径，示例中生成了四个512K字节大小的文件，扩展名分别为“.001” - “.004”。

启动MiniPro软件，选择设备`AMD 27C4096 DIP40`，取消选择`Check ID`，并将`Pulse Delay`设置为`50us`。根据EPROM的数据手册和编程成功率，也可以选择将`VPP Voltage`降低到`12.50V`。

![MiniPro Software Configuration](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/minipro.jpg)

EPROM现在可以像访问27C4096设备一样，每次访问512kB，具体由拨码开关配置：

- **27C400：** 一次性编程全部512kB。
- **27C800：** 分2次编程，每次512kB。
- **27C160：** 分4次编程，每次512kB。
- **27C322：** 分8次编程，每次512kB。

请参考下表了解拨码开关配置：

![DIP Switch configuration](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/dip_config.png)

## 故障排除

如果在编程时遇到写入或校验错误，请尝试以下步骤：

1. 确保EPROM在编程前已完全清空（`Device -> Blank Check`）。如今大多数EPROM都是二手“拆机料”；卖家在转售前不一定会仔细擦除。

2. 多次打开并关闭适配器的ZIF夹具，将EPROM正方形地重新放置到插座中。

3. 尝试将`VPP Voltage`调整到`12.50V`到`13.50V`之间。主观经验显示较高电压通常更成功，因为通过适配器逻辑传输VPP时会有电压损失。

4. 编程错误偶尔会发生，且设备越大概率越高。建议投资购买紫外线擦除器。eBay上价格低廉，大约15-20美元。大多数设备在紫外线照射下10至20分钟即可擦除。

5. [Maillouski](https://github.com/Maillouski/)报告Xgpro v12.38默认将AT27C4096的VDD写入电压设置为6.60V。为避免编程问题，请确保将此值更改为3.30V。

![IC Config Information VDD Write](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/vdd_3v30.png)

6. [Tim aka BeepFixer](https://x.com/@beepfixer)分享了他针对AliExpress采购的**27C160**变体的编程参数。

   主要区别是紫外线窗口垫片配置，分为A型、B型和C型。
    - **类型 A**：2x2 引脚，仅使用可用窗口空间的中心部分  
    - **类型 B**：2x2 引脚，使用大部分可用窗口空间  
    - **类型 C**：2x4 引脚  

![IC 配置资料 VDD 写入](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/m27c160_variants.jpg)  

**测试结果**  

  **类型 A**：10 片中有 2 片需要稍微调整——在推荐设置外微调（将 50us 改为 100us）即可编程并验证。为了保险，以下是使用的完整设置：VPP 电压：13.50V / VCC 校验：5.00V / VDD 写入：5.00V / 脉冲延迟：100us。虽然其他电压也成功，只要脉冲延迟是 100us 而非 50us。  

  **类型 B**：10 片中有 7 片第一次尝试即完美工作——采用 Eladio 推荐的设置（50us）  

  **类型 C**：10 片中有 1 片表现异常。读取和擦除正常，且能写入单字。但写入单字后拒绝写入更多内容。很可能是较老、要求更严格的版本；不是损坏，仅是硅片“挑剔”。我多次尝试不同设置，无法写入整批数据。  

**实用技巧**  

   - 编程后务必校验。  
   - 可尝试适配器 GitHub 中提及的电压差异。  
   - 注意文件写入；由于使用适配器写入分为 4 部分的映像，容易将错误文件写入错误的存储区（哎呀，我也曾把文件 3 写入了存储区 3 和 4）。因此，务必校验目标设备上的 EPROM！  

## 硬件变更日志  

R_20231123  

* 修正 EDG-03 DIP 开关的极性。  
* 更新版本号为 R_20231123  
* 更新版本号为 1.1  

V_20180919  

* 初始发布。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-24

---
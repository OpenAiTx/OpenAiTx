# Xbox_SMC
来自原始Xbox的PIC16/Xyclops转储和IDA数据库，进行了部分逆向工程。

![原始Xbox的PIC16LC63A图片](https://raw.githubusercontent.com/Prehistoricman/Xbox_SMC/master/pic16lc63a.jpg)

# Xyclops刷写（XycloMod）
请参阅[Xyclops目录和README](/Xyclops)

# 转储
每个PIC转储的.bin文件中的字节已交换，以便正确加载到IDA中。因此PIC内存的第一个字是byte_0 + byte_1 << 8。

.idb IDA数据库包含有关变量的信息以及数据库记事本中的一些观察。

有关SMC版本的详细说明，请参阅此wiki页面：https://xboxdevwiki.net/Xboxen_Info

## B2A
从DVT3 Xbox转储。配置字与P01相同。它还在配置区域烧录了设备ID，格式为0000 0000 000B 002A，与生产用PIC不同。

完全缺少启动挑战。

## D01
从XDK BETA 2 Xbox转储。与P01相同，但缺少启动挑战。计算预期启动挑战响应的函数仍然存在，但从未被调用。

## DXF
从XDK D2调试套件转储。与D01非常相似，但托盘逻辑、过热逻辑和启动逻辑略有不同。启动挑战以与D01相同的方式缺失。

## D2E
从Tuscany（v1.6）开发套件转储。Xyclops芯片标记为X01202-001，缺少零售单元所具有的A-A02或A-B01线路。

FC00处的调试串行代码与零售P2L转储匹配。0x4000到0xFBFF之间存在奇怪的数据模式。

## P01
从v1.0 Xbox转储。配置字为0x86：
- CP1:CP0 = 0（整个内存启用代码保护）
- BODEN = 0（棕色掉电复位禁用）
- ~PWRTE = 0（启用上电计时器）
- WDTE = 1（启用看门狗定时器）
- FOSC1:FOSC0 = 2（HS振荡器）

配置值0x3FB6适用于SMC克隆，以使其不启用代码保护。
## P11
从v1.3 Xbox中导出。与P01使用相同的配置字。

P11与P01相比有一些小变化，包括额外的SMBus命令（写0x22）、不同的LED优先级和更宽松的启动时序。

我对比了v1.3和v1.4的加密转储，它们匹配。这意味着它们很可能使用相同的程序。

## P2L
从v1.6 Xbox中导出。Xyclops修订版A-A02。它包含Intel 8051代码，但有许多功能未知的特殊功能寄存器。

调试串口由FC00处的代码驱动。看起来像一个粗糙的调试器，可以暂停执行、转储数据以及写入寄存器/内存。

# Xyclops转储

Xyclops芯片有3个“调试”引脚：TXD（引脚64）、RXD（引脚63）和DEBUG（引脚29）。将DEBUG引脚拉高以启用TX和RX引脚上的串口。串口速率为9600波特。

协议基于4字节命令，格式通常为`<命令>` `<地址高字节>` `<地址低字节>` `<无关字节>`

命令0x14一次转储64字节BIOS数据，命令0x15一次转储64字节SMC程序数据。Xyclops的转储文件P2L.bin包含在仓库中。[xyclops_dumper.py](/Xyclops/xyclops_dumper.py)也包含在内，供你转储自己的机器。

# PIC转储方法
完整说明见 https://wiki.recessim.com/view/PIC_Burnout

PIC启用了代码保护，所以所有数据读取均为0000。我使用了一些技巧获得了加密数据输出，通过牺牲芯片发现了加密算法，然后使用一种漏洞修改ROM数据，将某些位固定为已知值。之后，我可以从多次加密转储中提取所需信息，重建原始数据。

# PICProgrammer
PICProgrammer是我研究中使用的几个基于RP2040的Arduino项目之一。它提供了一个简单的命令行界面，用于执行PIC的ICSP（在线串行编程）操作。相比专用编程器如PICkit，它更灵活，且可以做制造商未预期的操作。

使用前应具备良好的电子和编程基础，并仔细了解各命令的功能后再执行。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-17

---
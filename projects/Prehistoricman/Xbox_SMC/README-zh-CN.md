
<div align="right">
  <details>
    <summary >🌐 语言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Xbox_SMC
原版Xbox上的PIC16/Xyclops转储及IDA数据库，并进行了部分逆向工程。

![原版Xbox中PIC16LC63A芯片图片](https://raw.githubusercontent.com/Prehistoricman/Xbox_SMC/master/pic16lc63a.jpg)

# Xyclops刷写（XycloMod）
请参阅[Xyclops目录和README](/Xyclops)

# Dumps
每个 PIC 转储的 .bin 文件都进行了字节交换，以便在 IDA 中正确加载。因此，PIC 内存的第一个字是 byte_0 + byte_1 << 8。

.idb 格式的 IDA 数据库包含变量信息以及数据库记事本上的一些观察内容。

有关 SMC 版本的详细说明，请参见此 wiki 页面：https://xboxdevwiki.net/Xboxen_Info

## B2A
从 DVT3 Xbox 转储。配置字与 P01 相同。它还在配置区烧录了设备 ID：0000 0000 000B 002A，与量产 PIC 不同。

完全缺少启动挑战。

## D01
从 XDK BETA 2 Xbox 转储。与 P01 完全相同，但缺少启动挑战。用于计算预期启动挑战响应的函数仍然存在，但从未被调用。

## DXF
从 XDK D2 调试套件转储。与 D01 非常相似，但托盘逻辑、过热逻辑和启动逻辑略有不同。启动挑战缺失方式与 D01 相同。

## D2E
从 Tuscany（v1.6）开发套件转储。Xyclops 芯片标记为 X01202-001，缺少零售机型的 A-A02 或 A-B01 行。

FC00 处的调试串行代码与零售版 P2L 转储相符。0x4000 到 0xFBFF 之间存在奇怪的数据模式。

## P01
从 v1.0 Xbox 转储。配置字为 0x86：
- CP1:CP0 = 0（整个内存启用代码保护）
- BODEN = 0（棕断复位禁用）
- ~PWRTE = 0（上电定时器启用）
- WDTE = 1（看门狗定时器启用）
- FOSC1:FOSC0 = 2（高速振荡器）

对于 SMC 克隆，0x3FB6 的配置值适用，这样它们不会启用代码保护。

## P11
从 v1.3 Xbox 转储。配置字与 P01 相同。

P11 相比 P01 有一些小变化，包括增加一个 SMBus 命令（写入 0x22）、不同的 LED 优先级，以及更宽松的启动时序。

我检查过 v1.3 的加扰转储与 v1.4 匹配。这意味着他们极有可能使用相同的程序。

## P2L
从v1.6版Xbox转储。Xyclops修订版A-A02。它包含Intel 8051代码，但有许多特殊功能寄存器，其功能尚不清楚。

调试串口由FC00处的代码供电。看起来像是一个简陋的调试器，可以暂停执行、转储数据，以及写入寄存器/RAM。

# Xyclops转储

Xyclops芯片有3个用于“调试”的引脚：TXD（64脚）、RXD（63脚）、DEBUG（29脚）。将DEBUG脚置高以在TX和RX脚上启用串口。串口速率为9600波特。

协议基于4字节命令，通常格式为 `<cmd>` `<地址高字节>` `<地址低字节>` `<无关紧要>`

命令0x14每次转储64字节BIOS数据，命令0x15每次转储64字节SMC程序数据。Xyclops的转储文件P2L.bin已包含在仓库中。[xyclops_dumper.py](/Xyclops/xyclops_dumper.py)也已包含，可用于转储您自己的设备。

# PIC转储方法
完整写作见 https://wiki.recessim.com/view/PIC_Burnout

PIC已启用代码保护，因此所有数据读取为0000。我使用了一些技巧输出了加密数据，通过牺牲芯片发现了加密算法，然后利用某种漏洞更改ROM数据，将一些位固定为已知值。随后可以从多次加密转储中提取所需信息以重建原始数据。

# PICProgrammer
PICProgrammer是我研究中使用的几个RP2040 Arduino项目之一。它提供了一个简单的命令行界面，可在PIC上执行ICSP（在线串行编程）操作。由于灵活性和可进行制造商未预期操作的选项，优于专用编程器如PICkit。

使用前应具备良好的电子和编程知识，并仔细查看命令作用再执行。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-20

---
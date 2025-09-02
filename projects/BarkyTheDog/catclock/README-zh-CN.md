<p align="center">
  <img src="https://raw.githubusercontent.com/BarkyTheDog/catclock/master/catclock.gif">
</p>

catclock
========

这是X Window系统xclock程序的一个版本，增强了“猫模式”。最初由Tony Della Fera（MIT-Athena，DEC）、Dave Mankins（MIT-Athena，BBN）和Ed Moy（加州大学伯克利分校）开发的X10程序，Deanna Hohn和我（数字设备公司）在上世纪80年代末为娱乐而改编制作。图形灵感来源于著名且标志性的Kit-Cat®时钟，我的厨房里还挂着一个。我将其上传到GitHub，以纪念今年是X10引入的30周年纪念日，同时因为它是一个有趣的桌面玩具。

自我们改进以来，代码几乎没有更改，主要是为了适应现在更严格的编译器。目前，它可以在各种Linux发行版、Cygwin和OS X（XQuartz）上编译运行，Makefile的改动仅因Macport默认将X相关文件安装到/opt/local而需调整。Imakefile较为陈旧，我尚未尝试使其工作——现在仅为“历史”原因包含。原始的readme文件现名为readme_original，也出于历史原因保留。

除了猫模式外，此版本xclock还包括闹钟功能和整点报时（详情见手册页）。可以使用各种X默认设置和命令行开关来控制猫的颜色。你可能需要修改Makefile的头文件和库路径以适应你机器的X配置。唯一的“非标准”依赖是Motif，可通过你喜欢的软件包管理器轻松获取。

## 节奏跟踪

此版本能够跟踪音乐节奏，并使猫眼和尾巴与音乐同步移动。  
要启用节奏跟踪构建，你需要一个额外的库来支持节奏跟踪：

```bash
sudo apt install libaubio5 libaubio-dev
```
使用 `WITH_TEMPO_TRACKER=1` 选项启用节奏跟踪器进行编译：


```bash
make WITH_TEMPO_TRACKER=1
```
在“cat”模式下运行时，启动一些PulseAudio混音器（例如 - `pavucontrol`），并在“录音”标签页中选择要分析的音频源。

## 使用方法


```
xclock [toolkitoptions]
       [-mode <analog, digital, cat>]
       [-alarm]  [-bell]  [-chime]
       [-file <alarm file>]  [-period <seconds>]
       [-hl <color>]  [-hd <color>]
       [-catcolor <color>]
       [-detailcolor <color>]
       [-tiecolor <color>]
       [-padding <pixels>]
       [-update <seconds>]
       [-ntails <number>]
       [-help]
```

享受吧！


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-02

---
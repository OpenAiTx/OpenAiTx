# CardStock

## 关于

**CardStock** 是一个跨平台工具，用于快速且轻松地构建图形化程序，称为 **stacks（堆栈）**，它们可以由多个称为 **cards（卡片）** 的页面组成。它提供了类似绘图程序的编辑器，用于构建图形用户界面，以及一个代码编辑器，用于添加事件驱动的 Python 代码。

![Pong example](https://github.com/benjie-git/CardStock/wiki/images/pong.png?raw=true)

过去有许多开源项目试图捕捉在 HyperCard 中构建程序的乐趣和简单性，但在我看来，没有一个能提供 HyperCard 那种神奇感觉的开放式可能性和易用性。因此，秉承开源传统，我自己构建了一个。

我对 CardStock 愿景的指导原则如下，按重要性排序：
1. 保持易接近、易理解、简单且高效，适合 Python 初学者到最资深的软件工程师使用。
2. 使其尽可能强大，而不增加不必要的复杂性。

## 功能

### 基础功能
* CardStock 允许你在 MacOS、Windows 和 GNU/Linux 上设计堆栈。你可以在这些平台上运行 CardStock 堆栈，也可以在任何现代网页浏览器上运行，包括 Chromebook 和智能手机。
* 你可以使用包括文本和图形、图像、按钮、文本输入字段和网页视图等对象来构建程序。
* 你可以使用自己的 Python 代码来操作对象并响应鼠标和键盘事件。
* 你可以从代码中播放音频文件。
* 你可以搜索并使用堆栈中的剪贴画，感谢与 https://openclipart.org 的集成。
* 上下文帮助会在应用中出现，正是你需要的地方。当你不再需要它占用空间时，可以关闭它。
* 拥有你期望的所有应用舒适功能，如完整的撤销/重做，以及贯穿所有代码和对象属性的查找/替换系统。

### 高级功能
* 你可以为对象的大多数属性动画更改，为你的创作注入生命。
* 对象可以具有速度，并且可以设置为自动从其他对象反弹。
* 你可以将其他 Python 模块 **导入** 代码中，使用它们进行网络请求并显示结果，控制机器人，或运行机器学习代码，全部在你的 CardStock 堆栈内完成。
* 基本 IDE 功能，如语法高亮、编辑时下划线标记语法错误，以及对对象、变量、函数、方法、属性的自动完成。
* 在堆栈运行时，可以在交互式控制台窗口中运行 Python 命令，检查或设置变量值，调用函数，或运行任何你想执行的 Python 代码。
* 浏览正在运行的堆栈的变量和对象，并在变量窗口中实时修改它们。
* 在一个地方查看整个堆栈中使用的所有代码，点击某行即可跳转到该对象对应事件的代码编辑器中该行。
* 查看最近的错误信息，点击错误即可跳转到 Designer 应用中的出错代码行。
* 你可以将堆栈导出为独立应用程序，方便分享和分发，或上传到 https://cardstock.run 的网页上。

### 未来计划
* 添加内置的声音库和录制自定义声音的功能。
* 支持声音循环播放。
* 增加更多 CardStock 教程，以及通过 CardStock 学习 Python 的教程。
* 支持用颜色渐变填充形状。
* 添加应用图标。
* 改进反弹物理和碰撞检测性能。

________
## 已知问题
* 文本字段和网页视图始终保持在形状和图像前面，后者直接绘制在卡片视图上。
* 视觉选择指示器（蓝色虚线轮廓）绘制在原生视图后面，因此可能被重叠的文本字段和网页视图遮挡。
* 堆栈只能在从源代码运行时导入额外模块，并导出包含它们的堆栈，预构建应用程序不能。（预构建应用程序包含一些额外库：requests、pyserial，如有需求可添加更多。）
* 讽刺的是，网页视图在 https://cardstock.run 的基于网页的查看器中无法工作。
* 出于性能原因，当前在网页查看器中运行时，鼠标事件不会传播到所有重叠对象，仅传播到鼠标下方最顶层对象、任何包含组和卡片。

## 要求
Mac 和 Windows 的预构建应用程序无外部依赖。

从源代码运行 CardStock 需要 Python 3.9 或更新版本（推荐 3.11+），以及 wxPython 4.1 或更新版本（推荐 wxPython 4.2.x）。
CardStock 需要安装 Python 模块 attrdict3（仅限 Linux）、wxpython、simpleaudio、PyInstaller 和 requests。
为支持 mp3 播放，需要安装 lame 包（mp3 解码器）和 Python 的 streamp3-313compat。

## 安装
你可以选择：

### 1. 下载最新的预构建 CardStock 应用程序（Mac 或 Windows）
#### （强烈推荐 Windows 用户使用此方式，因为从源码构建相当冒险。）
1. 在此下载 Mac 或 Windows 版本的 CardStock：https://github.com/benjie-git/CardStock/releases/latest
2. 注意预构建的 Windows 应用尚未代码签名，首次打开时 Windows 可能会提示警告。如果出现“Windows 保护你的电脑”的窗口，点击警告段末的“更多信息”链接，然后点击窗口底部出现的“仍要运行”按钮。

### 2. 从源码运行：
1. 安装 python3
2. 下载或克隆此仓库
3. 仅限 Linux：apt 安装 libasound2-dev libmp3lame-dev libwebkit2gtk-4.0-dev  # 或非 Debian/Ubuntu 发行版的等效包
4. 仅限 Mac：brew 安装 lame
5. 要支持 mp3：pip3 安装 streamp3-313compat

   注意这可能需要设置 LDFLAGS 和 CPPFLAGS 以找到 lame 的头文件和库文件。

    你可能需要以类似以下方式运行：

   `CPPFLAGS=-I/opt/homebrew/include LDFLAGS=-L/opt/homebrew/lib pip3 install streamp3-313compat` 或 

    `CPPFLAGS=-I/usr/local/include LDFLAGS=-L/usr/local/lib pip3 install streamp3-313compat`

    具体取决于 lame 库安装的位置。

6. pip3 安装 attrdict3  # 必须先安装此模块以支持 wxpython
7. pip3 安装 -r requirements.txt  # 注意 wxpython 编译可能耗时较长
8. 运行 python3 designer.py
9. 可选：运行 build.py 为 CardStock Designer 应用创建你自己的独立应用。

### 3. 使用 pip/pypi 安装：
1. 仅限 Linux：apt 安装 libasound2-dev libmp3lame-dev libwebkit2gtk-4.0-dev  # 或非 Debian/Ubuntu 发行版的等效包
2. 仅限 Mac：brew 安装 lame
3. 要支持 mp3：pip3 安装 streamp3-313compat

   注意这可能需要设置 LDFLAGS 和 CPPFLAGS 以找到 lame 的头文件和库文件。

    你可能需要以类似以下方式运行：

   `CPPFLAGS=-I/opt/homebrew/include LDFLAGS=-L/opt/homebrew/lib pip3 install streamp3-313compat` 或 

    `CPPFLAGS=-I/usr/local/include LDFLAGS=-L/usr/local/lib pip3 install streamp3-313compat`

    取决于 lame 库安装的位置。
4. pip3 install attrdict3  # 先安装这个是 wxpython 的前置条件
5. pip3 install cardstock  # 注意依赖的 wxpython 编译可能需要很长时间
6. 使用新安装的 cardstock 命令运行


## 参考
* [CardStock 维基](https://github.com/benjie-git/CardStock/wiki)
* [CardStock Reddit 讨论区](https://www.reddit.com/r/CardStockPython/)
* [CardStock 手册](https://github.com/benjie-git/CardStock/wiki/Manual)
* [CardStock 教程](https://github.com/benjie-git/CardStock/wiki/Tutorial-Dice)
* [CardStock 参考指南](https://github.com/benjie-git/CardStock/wiki/Reference)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---
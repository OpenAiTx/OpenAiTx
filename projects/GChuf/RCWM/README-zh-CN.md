# 右键 Windows 魔法

右键 Windows 魔法是一套为管理员、高级用户及其他魔法使者设计的右键（上下文）菜单工具。  
如果你认为自己是个巫师，并且想为自己节省一些时间和头疼，这就是为你准备的*正确*的上下文菜单工具集。

这个小魔法包包括：  
- 在 Windows 11 中添加旧版上下文菜单的选项  
- 使用 robocopy 复制和移动目录（比普通复制快得多）  
- robocopy 也支持跨网络共享的复制/移动  
- 从剪贴板粘贴（使用 robocopy）  
- SCP 传输（发送/接收）  
- 在文件夹或驱动器中打开 CMD 或 powershell 窗口  
- 以管理员身份运行 .ps1 脚本  
- 取得文件或目录的所有权（支持递归）（takeown 和 icacls）  
- 启动进入安全模式的选项  
- 重启进入恢复模式的选项  
- 从桌面打开控制面板  
- 以自定义优先级运行程序  
- 始终以管理员身份打开 cmd 的选项  
- 创建符号链接/硬链接  
- 打开“上帝模式”  
- 在 x 秒后重启/关机  
- 移动到/发送到文件夹的选项（来自 Windows 7）  
- 从桌面背景注销  
- 打开 GodMode  
- 卸载你所做更改的选项  
- 禁用 UAC  
- 启用长路径支持（路径超过 260 个字符）

你还可以移除一些右键菜单选项，以免菜单过于杂乱：  
- 固定到快速访问  
- 固定到开始屏幕  
- 包含到库中  
- 发送到  
- 共享  
- 添加到 Windows Media Player  
- 使用 Windows Defender 扫描

其他移除项：  
- 资源管理器内的“版本”标签页
TODO（魔法需要时间）：
- 对文件（.exe及其他）使用takeown
- 多文件/文件夹的目录联接点
- 使用管理员权限打开pwsh
- 在背景右键菜单中添加其他管理员工具
- 你的建议


![魔法示例](https://raw.githubusercontent.com/GChuf/RCWM/magic/img/RCWM.gif)


# 安装


要安装工具：下载最新的zip文件（发布页面[这里](https://github.com/GChuf/RCWM/releases/latest)），解压后以__管理员身份__运行install.cmd脚本——之后，你只需要两个最常用的键：__*Y*__和__*N*__（也许还有其他几个）。
如果运行RCWM命令的用户没有管理员权限，部分魔法可能无法正常工作。


# 它是如何工作的？

基本上是魔法。还有一些意大利面代码。

目前，魔法发生在Windows注册表中，并借助批处理和Powershell脚本。

目标是自动化命令行工具如robocopy，1）让每个人都能使用，2）为已经会使用的人节省时间。在自动化任务时，我意外发现我可以自动化比预想更多的功能——所以现在，你可以选择多个文件夹进行复制/移动，并将它们全部粘贴到一个文件夹中，就像你用普通、缓慢、懒散的Windows图形界面复制一样。


# RoboCopy：复制和移动项目选项

复制/粘贴和移动文件/目录都使用robocopy完成工作。
你有两个选项：可以一次复制多个或单个目录。

__单个__：
要复制的文件/文件夹（目录路径）（当你右键点击“复制”时）写入注册表，并__覆盖__之前存储的任何文件夹路径。如果指定了新的复制文件夹，旧的（如果存在）将被覆盖。

__多个__：
要复制的文件/文件夹路径列表被__追加__到注册表的 *HKCU:\SOFTWARE\RCWM\{rcopy || rcmov}* 键下。然后脚本通过powershell循环复制它们全部。

默认情况下，你最多只能选择15个文件夹进行复制（右键选项的Windows默认限制是15，你可以在安装脚本中将其增加到31或更多——详见 *MultipleInvokeMinimum.reg* 文件）。递归复制/移动从来不是问题（你可以有任意多的子文件夹）。

如果您打算大量使用 RoboCopy，请使用此选项。您可以阅读 rcp.ps1 powershell 文件来了解脚本的工作原理。

复制（多个）与移动（单个）：

![单个与多个](https://raw.githubusercontent.com/GChuf/RCWM/magic/img/sm.gif)

# RoboCopy：其他选项

您也可以粘贴通过 ctrl+c 选择的文件夹。此选项称为“从剪贴板粘贴”。
此外，您还可以使用镜像选项（/MIR）来镜像目录。此功能仅在目标位置已存在同名目录时有效。

# 已知问题

- 当右键点击大量文件夹时，TakeOwn 可能无法正常工作（部分文件夹权限不会被更改——因此您需要执行两次）？
不过，递归更改大量文件夹的所有权工作正常。
- “以优先级运行”不会显示选择以何种优先级运行程序的菜单——如果遇到此情况，请反馈。
- rmdir 和 robocopy 有时需要管理员权限（robocopy 报错 5）——如果遇到此问题，使用 takeown 或始终以管理员身份运行 cmd 会有所帮助。

# 测试
RoboCopy 在复制大量小文件时速度更快。
RmDir（del 和 rd）也比“标准”删除和 robocopy 的 /MIR 选项在使用空目录时更快。

我的机器（SSD 硬盘）上的测试结果：
文件夹信息：1.73GB / 12,089 个文件
- rcopy/普通复制：43 秒/91 秒
- rmdir/普通删除：约 3 秒/4.5 秒

结果可能因您的电脑和硬盘不同而异——但在大量小文件的情况下，您应该能受益。

# 安全性

RCWM v2 因 ps2exe 脚本及其输出被杀毒软件标记存在一些问题。
我现在已经放弃使用 ps2exe。

所有 .exe 文件均通过 VirusTotal 检查并标记为安全（这些文件用于将文件夹路径保存到注册表 HKCU 下）：

[rcwm-single.exe](https://www.virustotal.com/gui/url/3f1d93268323b721b956ac7a015e80a68768fedf34adbbb022b660c06b7f2efb?nocache=1)



[rcwm-multiple.exe](https://www.virustotal.com/gui/url/bcf252d68d68198eb304682dc070f0bed0b14fa159add7e6766c3c41b1feff86?nocache=1)

[RCWMInit.exe](https://www.virustotal.com/gui/url-analysis/u-13bb952212b2d23dce18713803085437b31180b593acb4f4f2d13753269e2db3-21bd70f1?nocache=1)

# 贡献

你随时可以创建一个 PR 或开启一个新问题，关于错误或建议。

# 支持

项目的目标是让他人的生活更轻松。

为项目点赞可以帮助更多人发现它。

如果你愿意，你可以请我喝杯~~咖啡~~啤酒：

- paypal.me: paypal.me/gchuf

- btc: 16BRUTbKu3tSuS9SudCoP7qHreNs6sAp8d

- eth: 0x75240bb1d3fac69954e980ec53d1c93a2d140389

- ltc: LWtm2gXdr29HhaiaXytnaz799RwYbxhz2d

# 致谢

安全模式启动和优先级运行文件深受 Shawn Brink 在 [tenforums.com](https://www.tenforums.com/tutorials/1977-windows-10-tutorial-index.html) 的影响。

TakeOwn.reg 文件（用于取得所有权）深受 Vishal Gupta 在 [AskVG.com](https://www.askvg.com/) 及 Shawn Brink 的影响。

重启至恢复选项是以前在网上某处找到的。不幸的是，我记不得原作者是谁。

以管理员身份运行脚本的想法来自这里：https://ss64.com/ps/syntax-elevate.html

我修改并适配了所有这些文件，但它们的创意和初始实现值得认可。

其他所有内容都是我自己的工作，并借助了互联网。

# 下载

![Downloads](https://img.shields.io/github/downloads/GChuf/RCWM/total?label=TotalDownloads)

![Downloads-Latest](https://img.shields.io/github/downloads/GChuf/RCWM/latest/total?label=LatestReleaseDownloads)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-02

---
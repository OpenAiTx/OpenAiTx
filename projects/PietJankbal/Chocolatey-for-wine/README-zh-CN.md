# Chocolatey-for-wine

Chocolatey 包管理器在 wine 中的自动安装器，方便快速安装 wine 中的程序（并随后发现 wine 中的错误 ;)）  
对于某些错误，添加了如 Visual Studio Community 2022 和 nodejs 的解决方法，详见后文。  

因为在封锁期间无聊，我写了一个自定义的 winetricks(.ps1)，包含我觉得方便的命令。只需运行 'winetricks' 即可查看。  
对于某些命令，需要完全重启 wine（由于最近的 wine 变更）。你会看到一个消息框，当前会话将结束。只需重新启动 powershell 并重试该命令。完成一次后，其他命令就不再需要了。  

示例：  

'winetricks vs22_interactiveinstaller'  （--> 会结束会话）  

运行 'wine powershell'  

再运行 'winetricks vs22_interactiveinstaller'  


（顺便说一句，通过 'winetricks vs22_interactive_installer' 你可以选择通过 Visual Studio 2022 安装程序安装内容；‘winetricks vs22_interactive_installer’ 让我十分钟内进入主程序（选择了使用 C++ 的桌面开发））。

安装：  
- 下载并解压发行版 zip 文件，然后运行 'wine ChoCinstaller_0.5c.751.exe'（大约需要一分钟完成）

可选：  
- 运行安装程序，如 'wine ChoCinstaller_0.5a.751.exe /s'，安装文件（如 Powershell*.msi 和 dotnet48）会保存在  
  我的文档中，创建新前缀时无需再次下载）  
可选：  
- 运行安装程序，如 'wine ChoCinstaller_0.5a.751.exe /q'，防止自动启动 powershell 窗口（仅安装）

可选：  
- 检查是否安装成功："choco install chromium" 和 "start chrome.exe (--no-sandbox 在 wine-8.4 之后不再需要)"  

![Screenshot from 2022-08-26 12-31-18](https://user-images.githubusercontent.com/26839562/186885380-d5a617c4-9cf4-4831-a475-2bd85a3b5784.png)  
关于 PowerShell：

提示：Chocolatey 通常安装程序的最新版本，可能会暴露新的 wine 错误。你使用旧版本的软件可能更顺利。  
示例：  

choco search --exact microsoft-edge --all （--> 列出所有版本）  

choco install microsoft-edge --version --version='135.0.3179.98'
通用信息：

- 使用 'wine powershell.exe' 启动 PowerShell-Core 控制台。

 
关于 ConEmu：

ConEmu 控制台存在一些 wine 的缺陷：
  - Ctrl^C 退出不会返回控制台的程序不起作用。请改用 Shift^Ctrl^C。
  - 在 ConEmu 窗口中选择文本（用于复制/粘贴）不会高亮显示选择内容。包含了一个针对最近 wine 版本的非常糟糕的解决方法，绕过了此问题，因此现在高亮显示应该能正常工作。
   
关于 winetricks(.ps1)：

- 如果不调用它（在 powershell 控制台中运行 'winetricks'），则不会下载任何内容，因此不会产生额外开销。
- 许多命令（如 powershell 5.1）需要一些必备文件来解压 msu 包。安装这些必备文件首先需要大量下载，并且在首次使用时耗时较长。但缓存完成后执行速度很快。例如，如果你想先试试 'winetricks ps51'，大约需要 15 分钟。其他某些命令首次使用可能需要 5 分钟。但调用过一次命令后，这种麻烦就消失了。
- 文件缓存目录在 MyDocuments 中。如果调用所有命令，缓存大约占用 800 MB。
- 希望能支持更多命令的 64 位版本。
- 支持从 msu 文件中提取文件并（尝试）安装。执行 'winetricks install_dll_from_msu' 查看用法。
- 一个简陋的 Powershell 5.1。
- 实验性的 dotnet481 安装，以及 dotnet35（可能某些应用不满足当前的 dotnet48 安装需求）。
- 自动制表符补全。注意：从现在起，命令行中使用多个命令时必须用逗号分隔（这是 powershell 处理多个参数的方式）。
  因此 'winetricks riched20 gdiplus' 不再有效，改用 'winetricks riched20,gdiplus'。
- 由于 wine 缺陷，一些程序通过 Chocolatey 安装/运行失败。我在 winetricks 中添加了一些解决方法，见下文。
- 特殊命令（winetricks vs19、vs22 和 vs22_interactive_installer）用于安装可用的 Visual Studio Community 2019 和 2022（见截图，安装时间超过 10 分钟，约需 10GB 空间！安装后从目录 c:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE\ 运行 devenv.exe）
  ![screenshot](https://github.com/PietJankbal/Chocolatey-for-wine/assets/26839562/d576a619-c752-4eb1-81c2-6f6b66b50ff6)
- 特殊命令用于访问各种 unix 命令如 grep、sed、file、less、curl 等（winetricks git.portable，免责声明：部分命令因 wine 缺陷尚不可用）。
- 还包括一些从网上代码片段改编的 powershell 脚本：
    - 如何通过 Invoke-ReflectivePEInjection 在 powershell 脚本中嵌入 exe（该 exe 不会出现在任务列表中）。
    - 如何制作花哨的消息框。
    - 将 powershell 脚本（ps1）转换为 exe。
    - 以及其他一些脚本。
 
     
关于系统程序：

新增功能，用于替换简单的系统程序，例如用 c:\\Program Files\Powershell\7\profile.ps1 中的函数替代 setx.exe，或者添加缺失的系统程序如 getmac.exe。
如果程序因系统程序不成熟或缺失而失败，可以编写一个 



function 返回程序所期望的内容。  
就像在 profile.ps1 中我添加了（除其他之外）一个支持更多选项的 wmic.exe，  
以及一个基本的 setx.exe。  
或者你也可以直接操作传递给系统程序的参数。参见 profile.ps1 和 choc_install.ps1。  
不能保证这对更复杂的程序也有效……  
 
注意事项：  

  - 不要在已有的 wineprefix 上使用，只能在新创建的前缀上使用！安装程序只是傻乎乎地自己安装 dotnet48 并且搞乱注册表键。  
    如果你已经用常规的 winetricks.sh 安装了任何版本的 dotnet，安装很可能会失败，即使成功，你也可能最终得到一个损坏的前缀。  
    如果你需要用常规 winetricks.sh 安装程序所需的东西，千万不要使用任何 dotnet* 动词。  
    顺便说一句，'Arial' 和 'd3dcompiler_47' 动词默认已安装。  
  - 不支持 WINEARCH=win32！  
  - 目前不支持从先前版本更新，也许以后会支持  

编译：  
  - 如果你想自己编译而不是下载二进制文件：请参阅 mainv1.c 和 installer.c 中的编译说明  
  - 然后将 choc_install.ps1 复制到同一目录  
  - 然后运行 'wine ChoCinstaller_0.5a.735.exe'



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-03

---
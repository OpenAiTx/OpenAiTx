<div align="right">
  <details>
    <summary >🌐 语言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Chocolatey-for-wine

Chocolatey 包管理器在 wine 中的自动安装器，方便在 wine 中快速安装程序（并随之发现 wine 中的 bug ;) ）  
针对某些 bug 加入了修复方法，如 Visual Studio Community 2022 和 nodejs，详见后文。  

在封锁期间无聊时，我编写了一个自定义 winetricks(.ps1)，添加了我觉得实用的动词。只需执行 'winetricks' 即可查看它们。
对于某些动词，由于最近 wine 的变更，需要完全重启 wine。你会看到一个消息框，当前会话将被结束。只需重新启动 powershell 并重试该动词。如果操作过一次，则之后任何动词都无需再次重启。  


示例：

“winetricks vs22_interactiveinstaller”（--> 会结束当前会话）

执行 “wine powershell”

执行 “winetricks vs22_interactiveinstaller”

（顺便说一句，通过 “winetricks vs22_interactive_installer” 可以通过 Visual Studio 2022 安装程序选择要安装的内容；“winetricks vs22_interactive_installer” 现在让我在十分钟内进入主程序（选择了 C++ 桌面开发））。

安装：
- 下载并解压发布版 zip 文件，然后执行 “wine ChoCinstaller_0.5c.751.exe”（完成约需一分钟）

可选：
- 以 “wine ChoCinstaller_0.5a.751.exe /s” 方式运行安装程序，此时安装文件（如 Powershell*.msi 和 dotnet48）会保存在
  我的文档里，如果你创建新前缀，则无需再次下载这些文件
可选：
- 以 “wine ChoCinstaller_0.5a.751.exe /q” 方式运行安装程序，以防止自动启动 powershell 窗口（仅安装）。

可选：
- 检查是否安装成功：“choco install chromium” 和 “start chrome.exe（自 wine-8.4 起不再需要 --no-sandbox）”

![Screenshot from 2022-08-26 12-31-18](https://user-images.githubusercontent.com/26839562/186885380-d5a617c4-9cf4-4831-a475-2bd85a3b5784.png)
关于 PowerShell：

提示：Chocolatey 通常会安装程序的最新版本，这可能会暴露新的 wine bug。你可能会在旧版本软件上更顺利。
示例：

choco search --exact microsoft-edge --all（--> 列出所有版本）

choco install microsoft-edge --version --version='135.0.3179.98'

一般信息：

- “wine powershell.exe” 启动 PowerShell-Core 控制台。

 
关于 ConEmu：


ConEmu 控制台存在一些 wine-bugs：
  - Ctrl^C 退出一个无法返回控制台的程序时无效。请使用 Shift^Ctrl^C 替代。
  - 在 ConEmu 窗口选择文本（用于复制/粘贴）不会高亮显示选中内容。这里包含了一个非常悲伤的 hack，针对近期 wine 版本可以解决这个问题，所以现在高亮应该可以正常工作了。
   
关于 winetricks(.ps1)：

- 如果你没有调用它（在 powershell 控制台输入 'winetricks'），则不会下载任何内容，因此不会有额外负担。
- 很多动词（如 powershell 5.1）需要一些必要文件来从 msu 包中提取内容。安装这些必需文件第一次需要大规模下载，并且耗时很长。但内容缓存后就会很快。例如你可以先尝试 'winetricks ps51'，大约需要 15 分钟。其他动词首次使用可能需要 5 分钟。调用一次动词后这种麻烦就没了。
- 文件缓存于 MyDocuments 目录。如果调用所有动词，总共大约占用 800 MB。
- 希望未来对各种动词能有更好的 64 位支持。
- 可以提取文件并（尝试）从 msu 文件安装。执行 'winetricks install_dll_from_msu' 查看方法。
- 一个基础版的 Powershell 5.1。
- 实验性的 dotnet481 安装和 dotnet35（可能是某些不满足于当前 dotnet48 安装的应用需要）。
- 自动 tab 补全。注意：在命令行使用多个动词时，现在必须用逗号分隔（powershell 处理多个参数就是这样）
  所以 'winetricks riched20 gdiplus' 不再有效，请使用 'winetricks riched20,gdiplus' 替代
- 某些程序通过 Chocolatey 尝试安装/运行时会因 wine-bugs 失败。我在 winetricks 中为它们加入了一些解决办法，见下文。
- 特殊动词（winetricks vs19, vs22 和 vs22_interactive_installer）可安装可用的 Visual Studio Community 2019 和 2022（见截图，安装需 >10 分钟且约 10GB！安装后在目录 c:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE/ 启动 devenv.exe）
  ![截图](https://github.com/PietJankbal/Chocolatey-for-wine/assets/26839562/d576a619-c752-4eb1-81c2-6f6b66b50ff6)
- 特殊动词可访问各种 unix 命令如 grep, sed, file, less, curl 等等（winetricks git.portable，免责声明：部分命令因 wine bug 还无法使用）
- 还包含一些从互联网代码片段改编的 powershell 脚本：
    - 如何通过 Invoke-ReflectivePEInjection 在 powershell 脚本中嵌入 exe（该 exe 不会出现在任务列表中）。
    - 如何制作炫酷消息框
    - 将 powershell 脚本（ps1）转换为 exe。
    - 以及其他几个脚本
 
     
关于系统程序：

添加了替换简单系统程序功能，比如将 setx.exe 替换为
c:\\Program Files\Powershell\7\profile.ps1 中的函数。或者添加缺失的系统程序，如 getmac.exe。
如果程序因系统程序不成熟或缺失而失败，可以编写
函数返回程序期望的内容。
例如在 profile.ps1 中我添加了（还有其他）一个支持更多选项的 wmic.exe，
以及一个基础版 setx.exe。
或者可以直接操作传递给系统程序的参数。参见 profile.ps1 和 choc_install.ps1。
不能保证复杂程序也能正常工作……
 
注意事项：


  - 不要在已有的 wineprefix 上使用，只能在全新创建的 prefix 上使用！安装程序只是简单地自行安装 dotnet48，并且会修改注册表键值。
    如果你已经通过常规的 winetricks.sh 安装过任何 dotnet 版本，很可能会失败，即使成功，也很可能会导致 prefix 损坏。
    如果你需要为程序通过常规 winetricks.sh 安装内容，请不要使用任何 dotnet* 动作。
    顺便说一句，‘Arial’ 和 ‘d3dcompiler_47’ 动作已经默认安装。
  - 不支持 WINEARCH=win32！
  - 目前不支持从之前的版本进行升级，或许以后会支持

编译：
  - 如果你想自行编译而不是下载二进制文件：请参见 mainv1.c 和 installer.c 中的编译说明
  - 然后将 choc_install.ps1 复制到同一目录
  - 然后运行 ‘wine ChoCinstaller_0.5a.735.exe’
  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-23

---
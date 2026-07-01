

<img width="1920" height="1080" alt="renut logo" src="https://github.com/user-attachments/assets/273bee28-755f-4494-920f-9333af72091e" />




Originally created with <a href="https://github.com/rexglue/rexglue-sdk">Rexglue-SDK</a>



DISCORD
--------------------------------------------
We have a discord, please join and direct any questions there. Myself or someone else will happily answer them.

https://discord.gg/D5Bz2ZsHdY



Credits
------------------------------------------------
<a href="https://github.com/rexglue/rexglue-sdk">Rexglue team</a> for creating Rexglue-SDK
<br>
the Rexglue SDK discord for helping with any info they have
<br>
SolarCookies for midasm hooks and future use of CRT functions and the reNut Launcher
<br>
ValcomDrifty for the renut logo
<br>
.
<br>
.
<br>
.
<br>
.
<br>
.
<br>
.
<br>
你，玩家？
<br>
。


需求
-------------------------------------------------------------------
北美版《Banjo-Kazooie: Nuts and Bolts》default.xex


如何构建
------------------------------------------------------
注意：你必须删除所有的 .gitignore 文件，否则你编译的内容将无法识别它们所在区域的文件。
<br>
注意：你必须先安装 <a href="https://git-scm.com/install/windows">GIT</a>，然后才能安装 REXGLUE-SDK 或构建此仓库。
<br>
注意：注意：你必须先构建并安装 <a href="https://github.com/rexglue/rexglue-sdk">Rexglue-SDK</a> 主仓库，然后才能继续。


1. 使用 ```git clone https://github.com/masterspike52/reNut.git``` 克隆仓库
2. 在 assets 文件夹内需要提取你的《Banjo-Kazooie: Nuts & Bolts》ISO 内容和 default.xex。推荐使用 <a href="https://consolemods.org/wiki/images/5/5f/XBOX360_ISO_Extract.zip">iso extract</a>。（我不知道 Linux 用户用什么。我用 Windows，不过 iso extract 通过 WINE 也能在 Linux 上运行。）
3. 在你克隆的 git 仓库中打开终端，运行 ```rexglue migrate --app_root .```。这确保如果 Rexglue 的 codegen 有任何变化，你可以正确生成代码。
   3b. 之后你必须删除 out 文件夹，或者如果你用的是 Windows，可以打开 VS，右键点击 cmakelists.txt，删除缓存并重新配置，以便使用你当前版本的 codegen。
4. 现在你可以打开终端，运行 ```rexglue codegen renut_config.toml```，这会生成用于重新编译的 ppc 文件，位于 generated 文件夹中。
5. 如果你用的是 Windows，可以在 VS 中打开项目，将构建类型改为 `win-amd64-relwithdebinfo`，然后全部构建。
   5b. 如果你用的是 Linux，且没有 VS，你需要使用终端运行 ```cmake --preset linux-amd64-relwithdebinfo```，然后运行 ```cmake --build --preset linux-amd64-relwithdebinfo```。（你也可以在 Windows 上这样做，只需将 `linux` 替换为 `windows`。）
6. 编译完成后，需将生成的 exe 放在与 assets 相同的目录，否则游戏无法启动。

有一个 Linux 分支
-------------------------------------------------
如果你想为 Linux 构建，请使用 etonedemid 制作的 <a href="https://github.com/etonedemid/reNut">reNut</a> 分支，它需要使用他制作的 <a href="https://github.com/etonedemid/rexglue-sdk">rexglue</a> 分支，并且他已经向 rexglue 提交了合并请求，使这些功能成为主分支的一部分。


如果你不想构建
--------------------------------------------
构建主要面向那些更愿意自己构建或者想与我和其他人一起开发游戏的用户。如果你不想构建；
* 访问 https://goopie.xyz/ 并下载 goopie 启动器
* 在启动器中选择《Banjo-Kazooie: Nuts and Bolts》
* 点击选择 ISO，选择你的《Banjo-Kazooie: Nuts and Bolts》ISO（必须是北美版），等待提取完成
* 解压完成后点击更新按钮，启动器将下载最新版本的Windows版renut  
* 点击播放  

已知问题  
-----------------------------------------------  
1. 动画有点卡顿（有抖动，班卓和其他骨骼断裂，一些动画只有一半完成，还有一些小的附属问题），但这些不会影响游戏玩法，只是看起来很滑稽。  

提交问题  
--------------------------  
问题标签页用于记录游戏中未被标注的崩溃等情况，请避免提交“游戏打不开”或“必须使用ISO？”之类的问题。  
涉及崩溃的问题必须使用崩溃模板（我可能会制作其他模板），以免大部分帖子都是用户错误。请加入Discord并在#help频道寻求与崩溃无关的问题帮助。






---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-01

---
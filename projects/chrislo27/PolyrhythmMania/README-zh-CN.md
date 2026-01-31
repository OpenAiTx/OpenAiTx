# 多节奏狂热
一款忠实再现《节奏天国》（リズム天国）中*多节奏*小游戏的游戏，带有内置关卡编辑器和侧面模式。

![多节奏狂热缩略图](https://user-images.githubusercontent.com/6299069/144956042-654ff2b3-aeba-4486-810e-f26aa1b33bff.png)
![多节奏：组装侧面模式缩略图](https://user-images.githubusercontent.com/6299069/140859874-0552bb9a-c6dc-460b-a4a2-e35f99648ea9.png)

[![下载量](https://img.shields.io/github/downloads/chrislo27/PolyrhythmMania/total.svg)](https://github.com/chrislo27/PolyrhythmMania/releases/latest)
[![GitHub 许可证](https://img.shields.io/github/license/chrislo27/PolyrhythmMania.svg)](https://github.com/chrislo27/PolyrhythmMania/blob/dev/LICENSE.txt)
[![捐赠给项目维护者](https://img.shields.io/badge/Donate-PayPal-blue.svg?logo=paypal)](https://www.paypal.com/donate?hosted_button_id=9JLGHKZNWLLQ8)

[GENERIC在YouTube上的原声带](https://www.youtube.com/playlist?list=PLt_3dgnFrUPwcA6SdTfi0RapEBdQV64v_)

## 功能特色
* 完整重现《节奏天国》中多节奏小游戏，*还有更多！*
* 拥有超过40个关卡的完整*故事模式*
* 使用库功能对自定义关卡进行排序和整理
* 使用内置且直观的关卡编辑器创建自定义关卡
* 关卡效果，如更改调色板、添加文本框、放置技能星星等
* 在经典GBA、现代高清和街机纹理之间切换，或添加自己的自定义纹理包
* 练习模式，通过原版GBA游戏的关卡提升多节奏技能
* 无尽模式，使用永无止境的程序生成模式让你保持警觉
* 每日挑战模式，包含常规无尽模式中未见的一系列模式，带有在线排行榜
* 额外侧面模式，如_多节奏：扣篮_、_多节奏：组装_和_按比例构建：纸牌接龙_，增添更多多节奏乐趣

[查看v1.2更新预告片（YouTube）！](https://www.youtube.com/watch?v=I4BXu7sNj-M)  
[查看发布预告片（YouTube）！](https://www.youtube.com/watch?v=A3ZUBIy_MAQ)  
[查看2021年8月功能预告片！](https://www.youtube.com/watch?v=k9PtPI1-tDo)  


## 运行系统要求
**官方支持的操作系统：** Windows 10或更高版本，Linux（x86-64和ARM）。

> macOS官方不支持（即我们不接受来自macOS的错误报告），但你可以根据[问题 #29](https://github.com/chrislo27/PolyrhythmMania/issues/29)尝试运行。

**系统规格：** 使用了与[*Minecraft：Java版*](https://help.minecraft.net/hc/en-us/articles/4409225939853-Minecraft-Java-Edition-Installation-Issues-FAQ#h_01FFJMSQWJH31CH16H63GX4YKE)类似的要求，因其使用了相同的底层图形库（GLFW和OpenGL 4.4）。

### 最低要求
* CPU：Intel Core i3-3210 3.2 GHz / AMD A8-7600 APU 3.1 GHz 或同等配置


* 内存：4GB  
* GPU（集成）：Intel HD Graphics 4000（Ivy Bridge）或 AMD Radeon R5 系列（Kaveri 系列），支持 OpenGL 4.4  
* GPU（独立）：NVIDIA GeForce 400 系列或 AMD Radeon HD 7000 系列，支持 OpenGL 4.4  
* 硬盘：游戏及关卡至少 1GB 空间  
* 操作系统：Windows 10 及以上，2018 年及以后发行的 64 位 Linux 发行版  
* 显示器：1280x720 分辨率  

### 推荐配置  
* CPU：Intel Core i5-4690 3.5GHz / AMD A10-7800 APU 3.5 GHz 或同等配置  
* 内存：8GB  
* GPU：NVIDIA GeForce 700 系列或 AMD Radeon Rx 200 系列（不含集成显卡），支持 OpenGL 4.5  
* 硬盘：2GB（推荐使用 SSD）  
* 操作系统：Windows 10 及更新版本（64 位），2020 年及以后发行的 64 位 Linux 发行版（例如 Ubuntu 20.04）  
* 显示器：1920x1080 分辨率  

## 安装说明  
无论是首次下载游戏还是升级到新版本，以下说明均适用。  
请确保您的系统满足上述要求。  

__Windows（仅限64位，无需安装 Java）：__  
1. 在新标签页或窗口中打开[此处的最新版本](https://github.com/chrislo27/PolyrhythmMania/releases/latest)。  
2. 在“Assets”部分下载名为 `PolyrhythmMania_VERSION_win64.zip` 的正确游戏版本，其中 VERSION 是发布版本名称。**请注意文件名中的“win64”。**不要下载“Source code”。  
3. 在文件资源管理器中找到下载的压缩文件。解压缩该压缩文件：右键点击压缩文件，选择“全部解压…”，并将内容解压到某个文件夹。  
4. 打开新解压的文件夹，进入 `PolyrhythmMania_win64` 文件夹。  
5. 双击 `LaunchPolyrhythmMania.exe` 可执行文件启动游戏！（无需预先安装 Java 运行环境，游戏自带一份。）  
6. 如果 Windows Defender 显示“Windows Defender SmartScreen 阻止了一个未识别的应用启动”，可以点击“详细信息”，然后选择“仍然运行”来安全忽略此提示。  

__其他平台（或已有 Java 的高级用户）：__  
1. **（前提条件）** 确保已安装 Java 运行环境（推荐 JRE 17，最低 JRE 11）并且在路径中可通过 `java` 命令访问。  
2. 在新标签页或窗口中打开[此处的最新版本](https://github.com/chrislo27/PolyrhythmMania/releases/latest)。  
3. 在“Assets”部分下载名为 `PolyrhythmMania_VERSION.zip` 的正确游戏版本，其中 VERSION 是发布版本名称。不要下载“Source code”。  
4. 将压缩文件解压到已知位置。  
5. 打开新解压的目录，进入 `PolyrhythmMania_platform_agnostic` 目录。  
6. 运行相应的启动脚本：Windows 上双击 `play_windows.bat`。Linux 上运行 `play_linux.sh`（可能需要先执行 `chmod +x play_linux.sh`）。  
7. 如果不想使用启动脚本，也可以使用您喜欢的设置运行命令 `java -jar bin/PolyrhythmMania.jar`。  

## 编译说明  
以下说明适用于有兴趣编辑游戏源代码的用户。  

1. 确保安装了 JDK 17 或更高版本。
2. `chmod +x gradlew`
3. `./gradlew :desktop:run`

## 其他信息
节奏天国是任天堂的知识产权。  
本程序**不**得到了任天堂的认可或赞助。  
本软件中使用的所有任天堂财产（例如名称、音频、图形等）均无意恶意侵犯商标权。  
所有其他商标和资产均为其各自所有者的财产。  
这是一个社区项目，其他人可以根据  
[GPL-3.0 许可证](LICENSE)免费使用。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-31

---
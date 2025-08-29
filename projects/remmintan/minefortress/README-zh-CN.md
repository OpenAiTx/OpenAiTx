![将你的Minecraft变成实时战略的模组](https://raw.githubusercontent.com/remmintan/minefortress/master/docs/main-banner.png)
# MineFortress
[![支持项目](https://img.shields.io/badge/PATREON-SUPPORT_THE_PROJECT-f96854?style=for-the-badge&logo=patreon&logoColor=f96854&labelColor=052d49&color=f96854)](https://www.patreon.com/minefortress)
[![加入Discord](https://img.shields.io/discord/906943962659561515?style=for-the-badge&logo=discord&label=discord&color=5865F2)](https://discord.gg/6rt7VJxPcq)
[![网站](https://img.shields.io/badge/website-minefortress-CC9966?style=for-the-badge)](https://minefortress.net/)

这个模组将你的Minecraft变成RTS。扮演村庄领袖的角色，收集资源，建造房屋，雇佣专业人士发展和扩展你的村庄，甚至征服邻居！忘记第一人称视角，像经典RTS游戏一样用鼠标指针控制一切。
## 链接
* **[网站](https://minecraftfortress.org/)**
* **[Patreon](https://www.patreon.com/minefortress)**
* **[Modrinth](https://modrinth.com/mod/minefortress)**
* **[CurseForge](https://www.curseforge.com/minecraft/mc-mods/minefortress-rts)**
## 给玩家
本仓库面向开发者。如果你想玩这个模组，请从[CurseForge](https://www.curseforge.com/minecraft/mc-mods/minefortress-rts)或[Modrinth](https://modrinth.com/mod/minefortress)下载。

模组需要Fabric Loader和Fabric API支持。
请参阅我们的[维基](https://wiki.minecraftfortress.org/wiki/Installation:Curseforge_Launcher)获取详细的安装说明。

## 给开发者
### 前提条件
我假设所有想为项目贡献代码的人对Java/Kotlin开发有基本了解。
我不会详细介绍基本开发环境的安装，但会列出所有需要的工具：
* Java 17 - 我更喜欢使用[Adoptium](https://adoptium.net/)的版本
* IntelliJ IDEA - 为了获得最便捷的开发体验并确保结果与我一致，推荐使用IntelliJ IDEA。你可以从[这里](https://www.jetbrains.com/idea/download/)下载。
* Git - 用于克隆仓库和提交更改。你可以从[这里](https://git-scm.com/downloads)下载。

如果你需要开发环境配置支持，请阅读这里的文章：[使用IntelliJ IDEA进行Java开发](https://www.jetbrains.com/help/idea/getting-started.html)

欢迎在我们的[Discord服务器](https://discord.gg/6rt7VJxPcq)寻求帮助。
### 入门 / 安装
1. 使用Git克隆仓库。
2. 确保项目被克隆到名为`minefortress`的目录中。这是让Gradle在IDEA中正常工作的前提。
3. 在IntelliJ IDEA中打开项目。
4. 等待Gradle完成项目导入。
5. 我们还需要让运行配置生效。Fabric插件会自动完成，但我们需要关闭项目。
6. 关闭项目然后重新打开。
7. 新的运行配置应该会出现。如果没有，尝试重启IDEA。
8. 运行配置旁可能会有一个小叉号，表示Fabric插件在设置配置时使用了错误的模块。
![](https://raw.githubusercontent.com/remmintan/minefortress/master/docs/run-configurations-1.png)
9. 解决方法是编辑配置，选择`minefortress.main`模块的类路径下拉菜单。
![](https://raw.githubusercontent.com/remmintan/minefortress/master/docs/run-configurations-2.png)
10. 现在你可以使用 `Minecraft Client` 配置运行项目。
![](https://raw.githubusercontent.com/remmintan/minefortress/master/docs/run-configurations-3.png)

### 贡献
非常感谢任何帮助！如果你想为项目做贡献，请按照以下步骤操作：
1. Fork 该仓库。
2. 从 `master` 分支创建一个新分支。
3. 进行你的修改。
4. 提交你的修改并推送到你的 Fork。
5. 向本仓库的 `master` 分支创建一个拉取请求。

目前还没有贡献指南，但你可以查看[问题](https://github.com/remmintan/minefortress/issues)寻找可做的工作。
我会尝试在问题中收集 Bug 和功能请求，但如果你有任何问题，欢迎在我们的[Discord 服务器](https://discord.gg/6rt7VJxPcq)中提问。

如果你发现任何 Bug 或有功能请求，也欢迎创建问题。

随着时间推移，我会尝试创建一份贡献指南和适合初学者的问题列表。

## 许可证
本项目采用 MIT 许可证 - 详情请参阅 [LICENSE](LICENSE) 文件。

## 捐赠
通过捐赠支持开源开发。你可以通过以下方式捐赠：
* **[Patreon](https://www.patreon.com/minefortress)**


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-29

---
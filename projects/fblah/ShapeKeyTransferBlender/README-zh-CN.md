## Blender 形状键工具
<!-- BADGES/ -->
<span class="badge-blenderartists"><a href="https://blenderartists.org/t/free-shape-key-transfer-addon" title="Link to Blender Artists forum post"><img src="https://img.shields.io/badge/Blender-Artists-orange.svg?logo=blender&longCache=true&style=popout-square" alt="Blender Artists Forum Post" /></a></span>
<span class="badge-discord"><a href="https://discord.gg/CmgdEvw" title="Join on discord"><img src="https://img.shields.io/badge/Discord-Join-768ADC.svg?logo=discord&longCache=true&style=popout-square" alt="Discord server button" /></a></span>
<span class="badge-youtube"><a href="https://www.youtube.com/watch?v=-zBlaedkkVs" title="Watch Tutorial on Youtube"><img src="https://img.shields.io/badge/Tutorial-Video-F40000.svg?logo=youtube&longCache=true&style=popout-square" alt="Youtube Tutorial" /></a></span>

Blender 2.93 形状键传输

使用此插件可轻松在不同拓扑结构的网格之间传输形状键。

将两个网格都放置在原点，并在目标网格想要复制源网格形状键的位置重叠它们。

此插件最初用于将形状键从 ManuelBastioniLab 角色复制到其他网格，但也可用于任何情况。

该插件基于我在此[StackoverFlow 帖子](https://blender.stackexchange.com/questions/119836/scripting-transferring-shape-keys-between-different-meshes/119867#119867)中编写的代码。

插件位于 工具 -> 形状键工具 下

你也可以排除某些形状键。

使用“增量半径”来增加影响目标网格的源网格顶点数量。

当“使用最近顶点”关闭时，它会平均增量半径内所有附近顶点的位置。

#### 源网格顶点越少，操作运行得越快。

##

### 功能：

- 在不同拓扑结构的网格之间传输形状键

- 通过添加排除项管理传输的形状键

- 将网格的所有形状键名称复制到剪贴板

### 示例用例：

- 将面部的形状键复制到胡须或眉毛发卡。

- 从基础网格复制形状键到LOD。

##

### 注意：
有时复制源网格并删除您认为不需要影响目标网格的顶点会更好。

一个示例是在处理胡须和脸部时：复制脸部并删除除嘴唇周围顶点之外的所有顶点，这些顶点最可能影响胡须，然后使用得到的网格作为源，将形状键复制到目标胡须发卡或网格。

如果需要，将为此插件添加更多功能。您也可以使用此工具轻松删除网格中的所有形状键。

##

### 许可证：

Blender形状键传输插件 - 版权所有 (C) 2018 Ajit Christopher D'Monte

所有Python文件均在GNU通用公共许可证3下发布。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-05

---
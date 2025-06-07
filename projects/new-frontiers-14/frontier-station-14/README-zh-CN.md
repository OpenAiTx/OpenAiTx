<div class="header" align="center">
<img alt="Frontier Station" height="300" src="https://github.com/new-frontiers-14/frontier-station-14/blob/master/Resources/Textures/_NF/Logo/logo.png?raw=true" />
</div>

Frontier Station（边境空间站）是 [Space Station 14](https://github.com/space-wizards/space-station-14) 的一个分支，运行于 [Robust Toolbox](https://github.com/space-wizards/RobustToolbox) 引擎，使用 C# 编写。

这是 Frontier Station 的主仓库。

如果你想为 Frontier Station 托管服务器或创建内容，这就是你需要的仓库。它包含 RobustToolbox 以及用于开发新内容包的内容包。

## 链接

<div class="header" align="center">  
[Discord](https://discord.gg/tpuAT7d3zm/) | [Steam](https://store.steampowered.com/app/1255460/Space_Station_14/) | [Patreon](https://www.patreon.com/frontierstation14) | [Wiki](https://frontierstation.wiki.gg/)
</div>

## 文档/Wiki

我们的 [wiki](https://frontierstation.wiki.gg/) 提供了关于 Frontier Station 内容的文档。

## 贡献

我们欢迎任何人的贡献。如果你想帮助，请加入 Discord。我们有一个[可执行的想法列表](https://discord.com/channels/1123826877245694004/1127017858833068114)，任何人都可以认领。也不要害怕寻求帮助！

我们目前不在主仓库接受游戏的翻译。如果你想将游戏翻译为其他语言，请考虑创建一个分支或为某个分支做贡献。

如果你做了任何贡献，请务必阅读 [MARKERS.md](https://github.com/new-frontiers-14/frontier-station-14/blob/master/MARKERS.md) 中的标记部分。
对上游文件的任何更改都应根据其中的规定进行适当标记。

## 构建

1. 克隆此仓库：
```shell
git clone https://github.com/new-frontiers-14/frontier-station-14.git
```
2. 进入项目文件夹并运行 `RUN_THIS.py` 以初始化子模块并加载引擎：
```shell
cd frontier-station-14
python RUN_THIS.py
```
3. 编译解决方案：

使用 `dotnet build` 构建服务器。

[更详细的项目构建说明。](https://docs.spacestation14.com/en/general-development/setup.html)

## 许可

自提交 2fca06eaba205ae6fe3aceb8ae2a0594f0effee0 之后贡献到本仓库的内容，除非另有说明（见下方归属说明），均遵循 GNU Affero 通用公共许可证第 3.0 版。详见 `LICENSE-AGPLv3.txt`。
在此提交之前贡献的内容，除非另有说明，均遵循 MIT 许可协议。详见 `LICENSE-MIT.txt`。

[2fca06eaba205ae6fe3aceb8ae2a0594f0effee0](https://github.com/new-frontiers-14/frontier-station-14/commit/2fca06eaba205ae6fe3aceb8ae2a0594f0effee0) 于 2024 年 7 月 1 日 16:04 UTC 推送。

大多数素材采用 [CC-BY-SA 3.0](https://creativecommons.org/licenses/by-sa/3.0/) 许可，除非另有说明。素材的许可和版权在元数据文件中注明。例如，见 [撬棍的元数据](https://raw.githubusercontent.com/new-frontiers-14/frontier-station-14/master/Resources/Textures/Objects/Tools/crowbar.rsi/meta.json)。

请注意，部分素材采用非商业 [CC-BY-NC-SA 3.0](https://creativecommons.org/licenses/by-nc-sa/3.0/) 或类似的非商业许可，如果你希望将本项目用于商业用途，则需要移除这些素材。

## 归属说明

当我们从其他分支拉取内容时，会将其内容整理到特定的子文件夹中，以便更好地追溯归属并减少合并冲突。

这些子目录下的内容来源于各自的分支，并可能包含修改。修改部分由注释包围进行标注。

| 子目录 | 分支名称 | 分支仓库 | 许可证 |
|--------------|-----------|-----------------|---------|
| `_NF` | Frontier Station | https://github.com/new-frontiers-14/frontier-station-14 | AGPL 3.0 |
| `_CD` | Cosmatic Drift | https://github.com/cosmatic-drift-14/cosmatic-drift | MIT |
| `_Corvax` | Corvax | https://github.com/space-syndicate/space-station-14 | MIT |
| `_Corvax` | Corvax Frontier | https://github.com/Corvax-Frontier/Frontier | AGPL 3.0 |
| `_DV` | Delta-V | https://github.com/DeltaV-Station/Delta-v | AGPL 3.0 |
| `_EE` | Einstein Engines | https://github.com/Simple-Station/Einstein-Engines | AGPL 3.0 |
| `_Emberfall` | Emberfall | https://github.com/emberfall-14/emberfall | MPL 2.0 |
| `_EstacaoPirata` | Estacao Pirata | https://github.com/Day-OS/estacao-pirata-14 | AGPL 3.0 |
| `_Goobstation` | Goob Station | https://github.com/Goob-Station/Goob-Station | AGPL 3.0 |
| `_Impstation` | Impstation | https://github.com/impstation/imp-station-14 | AGPL 3.0 |
| `_NC14` | Nuclear 14 | https://github.com/Vault-Overseers/nuclear-14 | AGPL 3.0 |
| `Nyanotrasen` | Nyanotrasen | https://github.com/Nyanotrasen/Nyanotrasen | MIT |

我们还从下列仓库移植了部分功能，但未设置子目录，详见下表。

| 分支名称 | 分支仓库 | 许可证 |
|-----------|-----------------|---------|
| Monolith | https://github.com/Monolith-Station/Monolith | AGPL 3.0 |
| Space Station 14 | https://github.com/space-wizards/space-station-14 | MIT |
| White Dream | https://github.com/WWhiteDreamProject/wwdpublic | AGPL 3.0 |


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---
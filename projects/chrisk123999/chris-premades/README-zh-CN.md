# 说明文档

本模块收集了一系列自动化物品，包括法术、职业特性、怪物特性等，以及实现这些功能的机制和提升高自动化 Midi-QOL 基于 D&D5e 环境的质量提升扩展。该模块内置的汇编包不包含物品描述。虽然本模块依赖于多个其他作者的模块，但请不要就与本模块相关的 bug 或问题打扰 tposney、Wasp 或其他模块作者。Bug 报告和大型模块实现请求可在 GitHub 提交。更快速的支持与功能请求请加入 [Discord 服务器](https://discord.gg/BumxBcQDrT)。

![CauldronofPlentifulResourcesMedium](https://github.com/user-attachments/assets/58c729ba-c499-45a3-a62c-c6982ad1f725) 

### 作者:
[Chris](https://github.com/chrisk123999) <br>
[Autumn](https://github.com/Autumn225) <br>
[Michael](https://github.com/roth-michael) <br>
[SagaTympana](https://github.com/SagaTympana)

### 支持:
[<img src="https://raw.githubusercontent.com/chrisk123999/chris-premades/master/images/chris-kofi.svg" width=237px />](https://ko-fi.com/O5O5G582S) <br>
[<img src="https://raw.githubusercontent.com/chrisk123999/chris-premades/master/images/michael-kofi.svg" width=253px />](https://ko-fi.com/T6T8XKCII)

# 必需模块  
| 模块 | 最低版本 |  
| --- | --- | 
| D&D 5e 系统 | ![Dynamic JSON Badge](https://img.shields.io/badge/dynamic/json?url=https%3A%2F%2Fgithub.com%2Fchrisk123999%2Fchris-premades%2Freleases%2Flatest%2Fdownload%2Fmodule.json&query=%24.relationships.systems%5B%3A1%5D.compatibility.minimum&label=%20&color=orange) | 
| Midi-Qol | ![Dynamic JSON Badge](https://img.shields.io/badge/dynamic/json?url=https%3A%2F%2Fgithub.com%2Fchrisk123999%2Fchris-premades%2Freleases%2Flatest%2Fdownload%2Fmodule.json&query=%24.relationships.requires%5B0%5D.compatibility.minimum&label=%20&color=green) |  
| Dynamic Active Effects | ![Dynamic JSON Badge](https://img.shields.io/badge/dynamic/json?url=https%3A%2F%2Fgithub.com%2Fchrisk123999%2Fchris-premades%2Freleases%2Flatest%2Fdownload%2Fmodule.json&query=%24.relationships.requires%5B3%5D.compatibility.minimum&label=%20&color=green) |
| Jules & Ben's Animated Assets | ![Static Badge](https://img.shields.io/badge/0.6.0-blue) |  
| Sequencer | ![Dynamic JSON Badge](https://img.shields.io/badge/dynamic/json?url=https%3A%2F%2Fgithub.com%2Fchrisk123999%2Fchris-premades%2Freleases%2Flatest%2Fdownload%2Fmodule.json&query=%24.relationships.requires%5B1%5D.compatibility.minimum&label=%20&color=green) |  
| Socket Lib | ![Dynamic JSON Badge](https://img.shields.io/badge/dynamic/json?url=https%3A%2F%2Fgithub.com%2Fchrisk123999%2Fchris-premades%2Freleases%2Flatest%2Fdownload%2Fmodule.json&query=%24.relationships.requires%5B2%5D.compatibility.minimum&label=%20&color=green) |  
| Time's Up | ![Dynamic JSON Badge](https://img.shields.io/badge/dynamic/json?url=https%3A%2F%2Fgithub.com%2Fchrisk123999%2Fchris-premades%2Freleases%2Flatest%2Fdownload%2Fmodule.json&query=%24.relationships.requires%5B4%5D.compatibility.minimum&label=%20&color=green) |

# 可选支持模块:  
- Gambit's Premades
- Midi Item Showcase Community
- Universal Animations
- [Animated Spell Effects: Cartoon](https://github.com/chrisk123999/animated-spell-effects-cartoon/releases/download/0.4.6/module.json)
- Visual Active Effects
- D&D Beyond Importer
- Tidy5e Sheet
- Token Magic FX

# 主要功能:
- 自动化法术、物品、职业特性等汇编包。
- 标题栏按钮，提供应用和配置内置自动化的界面。
- 由 ***Eskiemoh*** 制作的精美动画，用于部分自动化，使用 *Patreon JB2A* 和 *Animated Spell Effects: Cartoon*。
- 手动骰点专用自定义投掷解析器，适用于线下游戏。
- 基于 Midi-QOL 工作流的自定义 API，允许精准的事件时序和重叠法术效果的自动化处理。
- 用于运行自定义宏的公共 API。
- 多种可选的用户界面质量提升扩展。
- 效果变更，包括自动描述、状态效果图标变更，以及对状态效果应用相关 Midi-QOL 标记。
- 自定义效果界面，用于存储和应用自定义效果。
- 可选与自定义机制，包括 DMG 破击、爆炸治疗、BG3 武器动作等。
- 角色自动备份。

# 社区链接:
[Plentiful Resources 大锅 Discord](https://discord.gg/BumxBcQDrT)<br>
[Foundry VTT 官方 Discord](https://discord.gg/foundryvtt)<br>
[Posney's Foundry 自动化 Discord](https://discord.gg/Xd4NEvw5d7)<br>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---
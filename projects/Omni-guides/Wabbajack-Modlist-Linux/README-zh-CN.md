[![横幅](https://github.com/Omni-guides/Wabbajack-Modlist-Linux/blob/main/images/WabbajackModlistsBanner2.png)](https://github.com/Omni-guides/Wabbajack-Modlist-Linux)

<p align="center"><b>Wabbajack 应用程序 -</b>
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Wabbajack-via-Proton">通过 Proton 在 Deck/PC 上运行 Wabbajack（推荐） ·
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Wabbajack-on-Linux-via-Wine">通过 Wine 在 Linux 上运行 Wabbajack（仅限 PC）</a>
</p>

<p align="center"><b>Skyrim（Deck/PC） -</b>
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Skyrim:-Tuxborn">Tuxborn</a> ·
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Skyrim:-Licentia-DECK">Licentia DECK</a> ·
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Skyrim:-Legends-of-the-Frost">Legends of the Frost</a>
</p>

<p align="center"><b>Skyrim（仅限 PC） -</b>
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/General-Linux-Guide-(Anvil)">Anvil</a> ·
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Skyrim:-Nordic-Souls">Nordic Souls</a> ·
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Skyrim:-Keizaal">Keizaal</a> ·
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Skyrim:-Living-Skyrim-4">Living Skyrim 4</a>
</p>

<p align="center"><b>Enderal（Deck/PC） -</b>
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Enderal:-Emissaries-of-Tux">Emissaries of Tux</a>
</p>

<p align="center"><b>Fallout（Deck/PC） -</b>
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Fallout-4:-Welcome-to-Paradise">Fallout 4: 欢迎来到天堂</a> ·
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Fallout-NV:-Begin-Again">Fallout New Vegas: 重新开始</a> ·
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Fallout-NV:-Capital-Punishment">Fallout New Vegas: 死刑宣判</a>
</p>

<p align="center"><b>性能 -</b>
<a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Performance-Guide">Ouroboros 的优秀性能指南</a>
</p>


<p align="center"><b>其他 -</b>
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki">主页</a> ·
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Using-the-omni%E2%80%90guides.sh-Automation-Script">自动化脚本</a> ·
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/General-Linux-Guide-(Anvil)">通用 Linux</a> ·
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/ENB,-Reshade-and-Community-Shaders">ENB 与社区着色器</a> ·
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Troubleshooting-and-FAQ">故障排除与常见问题</a> 
</p>

---

免责声明 - 我与 Wabbajack 团队没有任何关联，只是一个想帮助其他玩家的玩家。您可以在主 [官方 Wabbajack Discord](https://discord.gg/wabbajack) 的 #unofficial-linux-help 频道获得本指南的帮助，但最好通过 Discord @ 我（@omni）。由于这是非官方指南，Wabbajack 官方支持或 Modlist 开发者直接提供帮助的可能性极小。

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/D1D8H8WBD)

***

## 介绍

本指南仍在持续完善中，主要基于我自己的测试以及多位用户在 [官方 Wabbajack Discord](https://discord.gg/wabbajack) 的 #unofficial-linux-help 频道的协作。感谢所有参与者。欢迎随时反馈。

请注意，对于小问题的 Pull Requests，可能会直接应用建议更改而不进行合并。请改为创建 Issue 来描述修正内容。

### Wabbajack 应用程序

现在您可以通过 Proton 或 Wine 在 Linux（包括 SteamOS/Deck 和其他发行版）上运行 Wabbajack 本体。推荐使用 Proton 配置方法，因为它适用于所有有 Steam 的平台。如果您确实不想使用 Proton，也可以使用基本 Wine（非 Steam Deck）。

### 自动化配置

虽然指南包含了逐步让 Modlist 运行起来的过程，我也创建了一个自动化 Modlist 安装脚本，旨在大幅减少启动运行所需的工作量。目前，该自动化脚本可以处理约 90% 所需步骤。

如果您想手动执行步骤以学习流程，或只是喜欢折腾，完全可以按照每个指南中的步骤操作。否则，您可以在这里找到自动化脚本及使用说明 - [使用 Omni-Guides 自动化脚本](https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Using-the-omni%E2%80%90guides.sh-Automation-Script)。

### 手动配置

各指南中包含的步骤已被用来让 Wabbajack Modlists 在 Linux 上运行，但不包括 Wabbajack 应用程序本体的运行。目前，**没有任何方法**能在 Linux 上直接运行 Wabbajack 本体——迄今为止的尝试仍然不稳定且功能缺失。通过本指南步骤，我已确认 Skyrim、Fallout 4、Oblivion、Fallout New Vegas 等 Modlists 成功运行，支持平台包括 Steam Deck（SteamOS/Arch）、Garuda Linux（Arch）和 Fedora/Nobara——但流程对大多数 Linux 发行版应基本相同。

Steam Deck 用户可以按照链接的 Modlist 专属指南，获得详细的逐步安装说明，帮助您启动所选 Modlist。

对于通用 Linux 系统（即非 Steam Deck），您可以选择上面列出的 Modlist 专属指南（包括“仅限 PC”部分），或者参考[通用 Linux](https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/General-Linux-Guide-(Anvil)) 指南。该通用 Linux 指南以 Anvil 作为示例，但您可以用自己选择的 Modlist 替换，步骤大致相同。如遇问题，可查看 Modlist 专属指南，看看是否有助于解决您所选 Modlist 的额外步骤。

最后，如果您是 Modlist 开发者，想让我测试您的 Modlist，请告知！祝您游戏愉快！

***

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-25

---
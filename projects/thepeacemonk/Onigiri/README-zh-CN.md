<div align="center">
  <img width="360" height="112" alt="onigiri" src="https://github.com/user-attachments/assets/eaebfec6-f6df-45b4-a3be-22e2ae97c1e8" />
  <br>
  <br>
  <h3>饭团（测试版）</h3>
</div>

<div align="center">
  <img width="400" height="22" alt="Onigiri divider" src="https://github.com/user-attachments/assets/77958660-41fd-4a43-85df-6c17cda02958" />
</div>

饭团是一个**实验性插件**，用现代化、高度可定制且个性化的仪表盘替代了标准的 Anki 界面，彻底改变了 Anki 的外观，帮助你每天保持学习卡片的动力。

饭团（お握り），也称为饭结（おむすび）或饭团（🍙），是一种富含碳水化合物的传统日本食谱，碳水化合物是提供能量的关键，让你能更好地学习 Anki 卡片！饭团的目的就是给予你合适的动力，用一个美观的新界面激励你学习 Anki（暗记），额外的碳水化合物助你一臂之力。

### 📝 哲学

- **Anki 是民主的**：Anki 是一款被全球各地用户使用的工具，每个用户都应有权根据自己的需求调整颜色和界面风格。饭团帮助 Anki 变得更加民主和用户友好。
- **优秀设计能激励人心**：动力能带来更高的效率和学习积极性，激励学生更频繁地使用应用。研究已证明，结构合理且用户友好的设计确实能[培养动力](https://www.mdpi.com/2414-4088/2/1/6)。
- **简洁默认，强大选项**：基础体验保持简洁。高级控制项可被发现，但不会让人感到负担——让用户按自己的节奏逐步掌握复杂功能。
- **灵活且一致**：用户可以改变外观和风格，同时不破坏 Anki 核心范式——卡片、复习、间隔——保持肌肉记忆的有效性。
&nbsp;

### 🧐 为什么选择饭团？

你可能会想“Anki 本来就很好用，为什么还要换？”  
我知道，Anki 确实好用，但饭团让使用体验更加美好。通过清新的默认设置、易读的排版和柔和的提示，饭团降低了使用摩擦，提高了动力——让你更频繁、更有活力地完成卡片复习。

###  🚨 你可能遇到的常见问题
如果你在使用饭团时遇到任何问题，请随时提交一个[问题单](https://github.com/thepeacemonk/Onigiri/issues)，让这个插件变得更顺畅。以下是一些你可能遇到的潜在错误，我正在努力修复：

- 开发过程中，在 Reviewer 中使用图片背景时，卡片格式有时会出现问题，这是由于插件和卡片的 CSS 功能交互引起的，如果你发现任何异常，请告诉我。
- 部分设置需要重启 Anki 才生效，因此如果你点击“保存”后没有任何反应，很可能是遇到了需要重启的设置。另外，有些设置只需刷新即可，按“D”键刷新主菜单即可。
- 该插件与某些其他插件兼容性较差，例如 Shige 的排行榜插件（因与饭团功能冲突而无法显示）以及 The KING of Button Add-ons（部分按钮的颜色、背景或对齐方式可能与预期不同）。
- 和所有处理 .gif 和 .webp 格式动态背景的插件一样，Anki 会使用较高的 CPU 资源，这不是错误，而是 Anki 的结构性问题。因为这两种格式均由 CPU 处理且持续渲染，所以 CPU 占用较高是正常现象。
- 下载后，你的外部插件将显示为已归档，前往设置 -> 菜单 -> 主菜单，整理你的“已归档外部插件”。
- 你可能会觉得饭团使 Anki 变“慢”，这是因为游戏化模式在学习时会记录数据，这属于正常现象，我会在未来更新中优化。
- 饭团不支持旧版本 Anki，仅支持 25.07.5 和 25.09，请保持 Anki 更新以获得更好体验。

### 📜 许可证
本项目采用 `GNU Affero 通用公共许可证 v3.0 (AGPL-3.0)` 授权。简而言之：你可以自由使用、研究和修改此代码——但如果你作为服务运行它或分发修改版本，必须在相同许可下公开你的源代码。

我投入了大量时间设计和维护此作品。请尊重许可及我的努力：
- 不要将本项目的部分内容复制到闭源或商业产品中。
- 如果基于此项目开发，请注明原作者并保持修改内容开源。
- 如果你觉得本项目有价值，考虑贡献或支持本项目。

## 声明

本项目与 [Onigiri Anki](https://www.onigiri-anki.com/) 无关联。未表达或暗示任何背书。

Onigiri（本插件）是一个独立的 Anki 插件，定制应用的用户界面。相比之下，[Onigiri Anki](https://www.onigiri-anki.com/) 提供一个带有其系统的日语学习卡组。这些是独立产品，彼此无任何关联。


### 致谢与鸣谢
以下项目和资源对本插件的设计和开发提供了参考：

- 色彩调色板与主题：[Catppuccin](https://github.com/catppuccin)、[Dracula](https://draculatheme.com/)、[Rosé Pine](https://rosepinetheme.com/palette/)、[Nord](https://www.nordtheme.com/docs/colors-and-palettes)、[Solarized](https://ethanschoonover.com/solarized/)、[Antinote 主题](https://antinote.io/)。
- 视觉与主题灵感来源：[Mochi Cards](https://mochi.cards/)
- Shige 的插件先例：[增强主窗口](https://ankiweb.net/shared/info/911023479)、[重新排列首页插件](https://ankiweb.net/shared/info/1797615099)、[Anki 重新设计](https://ankiweb.net/shared/info/1959668791)（均由 Shige 开发）
- 功能与界面指导：受 [Review Heatmap](https://ankiweb.net/shared/info/1771074083)（Glutanamite）、[Modern Material Theme](https://ankiweb.net/shared/info/1321246682)、以及 [Coloris](https://github.com/mdbassit/Coloris) 启发

### 🫶 感谢

感谢 **Anki** 和 [**Ankimon**](https://github.com/h0tp-ftw/ankimon) 社区教会我编码与插件开发的基础！特别感谢 @Ouranos 在识别 BUG 上提供的特别帮助。

### 💞 支持我的工作

我持续发布更新和新功能。如果我的插件帮助了你的学习或工作流程，欢迎支持我的工作。你的支持让项目得以维护并免费提供给所有人。加入我们的 [Discord](https://discord.gg/ZU9VZHMk3u)

<a href="https://www.buymeacoffee.com/peacemonk">
<img width="30%" height="auto" alt="请我吃个饭团" src="https://github.com/user-attachments/assets/2c993906-ccb5-4a75-9235-9b63a8d62252" />
<br>
<br>
</a>

### ⭐ GitHub Star 历史

[![Star History Chart](https://api.star-history.com/svg?repos=thepeacemonk/Onigiri&type=date&logscale&legend=top-left)](https://www.star-history.com/#thepeacemonk/Onigiri&type=date&logscale&legend=top-left)


### 🍙 This is Onigiri

<img width="60%" height="auto" alt="1" src="https://github.com/user-attachments/assets/523a7890-d599-4030-80c5-45bf9626ad17" />
<img width="60%" height="auto" alt="2" src="https://github.com/user-attachments/assets/75fa35cb-e74b-402d-880a-0b98a7ce3ce4" />
<img width="60%" height="auto" alt="3" src="https://github.com/user-attachments/assets/44e0627d-2a57-40b5-9e5a-6b237a848f7c" />
<img width="60%" height="auto" alt="4" src="https://github.com/user-attachments/assets/6bddc6d2-2105-40fd-9b89-df86f39732a3" />
<img width="60%" height="auto" alt="5" src="https://github.com/user-attachments/assets/983121f6-6c63-4f5d-9cf0-3491100ed28d" />
<img width="60%" height="auto" alt="6" src="https://github.com/user-attachments/assets/6a907210-1d64-4d3f-986c-6816641a7080" />


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-18

---
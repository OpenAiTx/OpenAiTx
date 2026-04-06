# Spicetify DJ 信息

欢迎使用 Spicetify DJ 信息扩展！该扩展通过提供每首曲目的有价值的歌曲分析数据，包括调性、BPM、流行度和年份，提升您的 Spicetify 体验。通过此扩展，您可以更深入地了解您的音乐库，发现完美融入您的 DJ 套装或播放列表的歌曲。

## ⭐功能

- **调性：** 识别每首歌曲的调性，支持标准记号（Dbm）或 Camelot 系统（3B）。Camelot 系统通过将调性分类为和谐兼容的组别，简化了和声混音。这使得在 DJ 套装或创建连贯播放列表时，歌曲之间的过渡更加顺畅。
- **BPM ♫（每分钟节拍数）：** 获取每首歌曲的节奏，表示音乐的速度或节拍。BPM 对于创建速度相似的播放列表或为特定活动选择歌曲非常有用。
- **流行度 ♥：** 了解您的歌曲有多受欢迎，访问其流行度评分。这些数据有助于理解一首曲目的整体接受度和流行程度。
- **年份：** 了解您的歌曲发行时间。这些数据对于创建特定时间段歌曲的播放列表非常有用。

![截图](https://raw.githubusercontent.com/L3-N0X/spicetify-dj-info/main/img/playlist.png)
![截图](https://raw.githubusercontent.com/L3-N0X/spicetify-dj-info/main/img/now-playing.png)

## 💻 安装

将 `dist/djinfo.mjs` 复制到您的 [Spicetify](https://github.com/spicetify/spicetify-cli) 扩展目录：

| **平台**   | **路径**                                                                                |
| ---------- | --------------------------------------------------------------------------------------- |
| **Linux**  | `~/.config/spicetify/Extensions` 或 `$XDG_CONFIG_HOME/.config/spicetify/Extensions/`    |
| **MacOS**  | `~/.config/spicetify/Extensions` 或 `$SPICETIFY_CONFIG/Extensions`                      |
| **Windows**| `%appdata%/spicetify/Extensions/`                                                      |

将扩展文件放入正确的文件夹后，运行以下命令安装扩展：

```bash
spicetify config extensions djinfo.mjs
spicetify apply
```
或者您可以手动编辑您的 `config-xpui.ini` 文件。将您想要的扩展名添加到 extensions 键中，用 | 字符分隔。  
示例：  


```ini
[AdditionalOptions]
...
extensions = autoSkipExplicit.js|shuffle+.js|trashbin.js|djinfo.mjs
```

然后运行：

```bash
spicetify apply
```

**可能导致星级评分问题！**

## ❌ 卸载

运行以下命令卸载扩展（注意末尾的 -）：

```bash
spicetify config extensions djinfo.mjs-
spicetify apply
```

您也可以手动编辑您的 `config-xpui.ini` 文件。只需完全删除扩展名的文件名即可。
示例：

```ini
[AdditionalOptions]
...
extensions = autoSkipExplicit.js|shuffle+.js|trashbin.js
```

然后运行：

```bash
spicetify apply
```

## ⚙️ 设置

您可以选择切换扩展中DJ信息的可见性。默认情况下，每首歌曲都会显示DJ信息，如调性、BPM、流行度和年份，并且当前播放的歌曲旁边也会显示这些信息。但是，如果您喜欢更简洁的界面，可以轻松分别隐藏它们。

切换DJ信息可见性，请按以下步骤操作：

1. 打开 Spotify
2. 找到界面右上角的菜单图标（您的头像），点击该图标
3. 在菜单中找到“DJ信息”选项
4. 在子菜单中点击开关，隐藏或显示您想要的内容
5. 点击“应用更改”使设置生效

## 📜 更新日志

### V 2.4.0

- 更新至不同的 API
- 改进样式
- 为新音频功能添加新选项

### V 2.3.3

- 修复日志垃圾信息

### V 2.3.2

- 修复新混音界面布局

### V 2.3.1

- 修复API导致扩展崩溃的问题
- 移除舞感与能量，因为新API中不再提供
- 为DJ信息添加新UI，并改进旧版本，禁用丰富UI后仍可使用旧版
- 修复缓存并迁移至使用IndexedDB的新系统，替代LocalStorage
- 新的Camelot调性色彩可通过覆盖CSS变量自定义

### V 2.2.1

- 现在推荐功能终于正确工作
- 缓存得到了极大改进  
- 数据以批量方式获取，解决了因速率限制导致的数据缺失问题  
- 重新支持新的播放列表界面  
- 改进了加载性能  
- 改进了错误日志记录  
- 修复了 #16、#23、#24 和 #25 的错误  

### V 2.1.1  

- 修复了推荐歌曲部分的样式  

### V 2.1.0  

- 新增在推荐歌曲部分查看 DJ 信息的选项  
- 修复了 DJ 信息在唱片目录部分不显示的错误 ([#2](https://github.com/L3-N0X/spicetify-dj-info/issues/2))  
- 修复了队列中的一个错误 ([#9](https://github.com/L3-N0X/spicetify-dj-info/issues/9))  

### V 2.0.0  

- 通过本地存储数据提高性能，加快加载速度并减少 API 调用  
- 重新设计设置菜单，更方便地切换 DJ 信息的显示  

### V 1.1.0  

- 新增切换显示年份、流行度、舞曲感和调号的标准记谱选项  
- 错误修复  

## 🌐 致谢与鸣谢  

特别感谢 [obafgkmdh](https://github.com/obafgkmdh) 和 [FixeQD](https://github.com/FixeQD) 在内部 API 崩溃后修复扩展，迁移整个 API 到基于内部 protobuf 的 API，并添加了更好的文件结构与打包！  

也感谢 [Golevka2001](https://github.com/Golevka2001) 提供了更好地对齐播放列表中 DJ 信息的想法！  

特别感谢 [duffey](https://github.com/Tetrax-10) 提供显示播放列表和正在播放小部件的主要代码！  

还要感谢 [je09](https://github.com/je09) 贡献了显示调号的标准记谱法和骆驼调系统代码，以及在正在播放界面左侧显示的选项！  

## 💬 反馈与贡献  

如果你遇到任何问题或有改进此扩展的建议，欢迎在 [GitHub 仓库](https://github.com/L3-N0X/spicetify-dj-info) 提交 issue。也欢迎贡献代码！请 fork 仓库，进行修改，并提交包含改进的 pull request。

## ⚖️ 许可协议

本项目采用[MIT 许可证](https://raw.githubusercontent.com/L3-N0X/spicetify-dj-info/main/LICENSE.md)授权。欢迎根据该许可证的条款使用、修改和分发代码。

---

尽情享受 Spicetify DJ Info 扩展带来的增强音乐分析体验！如果您觉得此扩展有用，欢迎在 GitHub 上为它点个⭐️。感谢您使用 DJ Info！


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-06

---
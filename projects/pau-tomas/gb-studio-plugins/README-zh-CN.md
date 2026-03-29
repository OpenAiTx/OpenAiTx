# GB Studio 4.2 - 插件包

一组针对 GB Studio 4.2 的实验性插件。使用风险自负 :)

> [!注意]
> 一些之前可用的事件插件现已弃用，因为它们的功能已被集成到 GB Studio 中。[请参见下方列表](#deprecated-plugins)。

## 对话与菜单

### 绘制生命条

在覆盖层的指定位置绘制一个（生命/能量/魔力）条。

- `X`, `Y`：覆盖层上的瓦片坐标。
- `Tileset`：包含连续顺序条形瓦片的瓦片集。
- `Tile`：条形瓦片集中的第一个瓦片（通常为空瓦片）。
- `Value`：当前条形所表示的值。
- `Max Value`：条形所能表示的最大值。
- `Steps`：填充条形中一个单位所需的瓦片数量（不包括空瓦片）。

[示例项目](examples/Draw%20Lifebar/)

_注意：_ 瓦片集将加载到 VRAM 的第 128 号瓦片（紧跟在精灵块之后）。这允许在覆盖层上将生命条渲染与 `绘制文本` 结合使用。VRAM 索引可通过编辑插件文件中的 `const VRAM_BASE_START_TILE = 128` 行进行更改。

<img width="300" alt="绘制生命条" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/Draw Lifebar/screenshots/draw_lifebar.png"/>

<img width="300" alt="绘制生命条" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/Draw Lifebar/screenshots/draw_lifebar_screenshot.png"/>

### 显示高级菜单

显示一个多选项菜单，并将指定变量设置为所选选项的值。菜单选项的位置和导航顺序可在 `Items` 标签中为每个项目设置。您可以选择设置 'B' 按钮关闭菜单并将变量设为 '0'，也可以让最后一个菜单项被选中时返回 '0'。对话框大小、打开和关闭方向，以及菜单的位置（顶部或底部）可在 `Layout` 标签中设置。菜单的打开和关闭速度可在 `Behavior` 标签中设置。

每个项目没有最大字符长度限制，但显示的总字符数受到 UI 文本保留瓦片数量的限制（非彩色模式为 52 瓦片）。

_注意：_ 当项目数量较多时，事件可能会变得非常长。

<img width="300" alt="高级菜单项目" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/Advanced Menu/screenshots/advanced_menu_items.png"/> <img width="300" alt="高级菜单截图" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/Advanced Menu/screenshots/advanced_menu_screenshot.png"/>

<img width="300" alt="高级菜单布局" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/Advanced Menu/screenshots/advanced_menu_layout.png"/>

## 实时时钟

一组事件，提供访问某些GB卡带中实时时钟功能的能力。

_注意：_ 项目设置中卡带类型需要设置为 `MBC3`，实时时钟功能才能正常工作。

### 设置时钟时间

将实时时钟字段的值设置为数字或变量的值。

<img width="300" alt="设置时钟时间" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/RTC/screenshots/set_clock_time.png"/>

### 将时钟时间存储到变量中

将当前时间的每个值分别存储到一个变量中。

<img width="300" alt="将时钟时间存储到变量中" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/RTC/screenshots/store_time_in_var.png"/>

### 启动时钟

启动实时时钟。

<img width="300" alt="启动时钟" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/RTC/screenshots/start_clock.png"/>

### 停止时钟

停止实时时钟。

<img width="300" alt="停止时钟" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/RTC/screenshots/stop_clock.png"/>

## 屏幕

### 平滑淡入淡出

**仅限颜色模式**

将当前场景的部分或全部背景或精灵调色板淡入或淡出到白色或黑色屏幕，插值颜色值以实现平滑的淡入淡出效果。

<img width="300" alt="玩家字段更新" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/Smooth Fade/screenshots/smooth_fade.png"/>

## β 插件

此类别中的插件比上述插件更加实验性，未来可能会有所变动。

- **移动变量角色到** 和 **存储变量角色位置到n变量**：
  - 这些事件是现有 GB Studio 角色事件的复制版本，但不是通过下拉菜单选择角色，而是使用变量。变量的值表示场景中角色的索引（玩家始终为 `0`，其余角色根据添加到场景的顺序分配索引）。

- **将角色固定到屏幕** 和 **将角色从屏幕取消固定**：
  - 将角色固定或取消固定到其当前屏幕坐标。\n注意角色的当前状态：如果事件调用时角色已经被固定或取消固定，其位置将基于滚动位置错误偏移。

## 安装方法

将 `plugins` 文件夹放入你的项目中。上述所有事件将通过 `添加事件` 按钮可用。

## 其他作者的更多插件：

- [NalaFala (你的用户名) 的 GB Studio 插件合集](https://github.com/Y0UR-U5ERNAME/gbs-plugin-collection)
- [Platformer+](https://github.com/becomingplural/GBS_PlatformerPlus)
- [高级对话和菜单 vB](https://github.com/dochardware/Advanced-Dialog-and-Menu)
- [Shin 的 GB Studio 插件](https://github.com/shin-gamedev/gbs-plugins)
- [Gud GBS 插件](https://github.com/mikeleisz/gud_gbs_plugins)
- [Fade Street](https://gearfo.itch.io/fade-street)
- [滚动场景过渡](https://github.com/Mico27/GBS-scrollScenePlugin) 及更多 [Mico27 的插件](https://github.com/Mico27/)

## 已废弃插件事件

以下事件插件已不再作为插件包的一部分提供，其功能已被原生集成到 GB Studio 中。

自 4.2 版本起：

- 玩家字段更新
- 将玩家字段存储到变量
- 将摄像机字段存储到变量

自 4.1 版本起：

- 显示高级对话
- 显示背景文本
- 打印屏幕背景
- 静音频道
- 摄像机视野更新  
- 设置对话框框架  
- 角色特效  

自4.0版本起：  

- 锁定事件组  
- 解锁事件组  

如果您未使用GB Studio 4.2或更高版本，仍然可以在[这里](https://github.com/pau-tomas/gb-studio-plugins/tree/4.1)找到上述内容。兼容4.0版本的插件请查看[这里](https://github.com/pau-tomas/gb-studio-plugins/tree/4.0)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-29

---
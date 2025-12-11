## ... 为EPS32移植OpenFIRE-Boards

本仓库是TeamOpenFIRE原创项目“OpenFIRE-Boards”的移植版本，适配于ESP32S3微控制器。
除了一些适配和小幅修改外，代码基本保持与TeamOpenFIRE原版一致。
本仓库中的代码也可在RP2040微控制器上运行。
每当TeamOpenFIRE对“OpenFIRE-Boards”原项目做出修改时，我也会相应更新本仓库中的代码。
衷心感谢TeamOpenFIRE创建了“OpenFIRE-Boards”项目；所有荣誉和感谢都归于他们的付出。
这仅仅是为了在ESP32S3上运行所做的适配。


本仓库是TeamOpenFIRE原创项目“OpenFIRE-Boards”的移植版本，适配于ESP32S3微控制器。
除了一些适配和小幅调整外，代码基本保持与TeamOpenFIRE原版一致。
本仓库中的代码也可在RP2040微控制器上运行。
每当TeamOpenFIRE对“OpenFIRE-Boards”原项目做出修改时，我也会相应更新本仓库中的代码。
衷心感谢TeamOpenFIRE创建了“OpenFIRE-Boards”项目；所有荣誉和感谢都归于他们的付出。
这仅仅是为了在ESP32S3上运行所做的适配。

![Waveshare-esp32-s3-pico](https://github.com/user-attachments/assets/2ce848f3-f308-43cc-b753-3b1dac1647e4)

![YD-esp32-s3-wroom1-DevKitC-1-N16R8](https://github.com/user-attachments/assets/080baf9b-f050-4b3e-ba59-4fb4aa784909)


## ... 以下为项目原始页面
## ... follows the original project page

# OpenFIRE-Boards
OpenFIRE固件与桌面应用共用的开发板通用仓库

# OpenFIRE共享资源
本仓库包含可在微控制器固件实现与面向PC设备的接口和配置应用之间共享的资源。

## `OpenFIREshared.h`
此文件上半部分定义了固件和应用实现中共有的内容：
 - 微控制器在首次对接时报告的开发板名称定义，作为字符串字面量。
 - 引脚功能类型、开关、设置、I2C设备及其设置，以及固件与应用串口通信中使用的命令的枚举。
 - 定义的开发板预设，在启动时加载，并被显示默认开发板布局的应用引用。

在`OF_APP`预处理器检查之后，是支持的开发板和引脚功能的“漂亮”字符串，以及仅被桌面应用用来图形化表示定义开发板GPIO引脚的布局——展示它们相对于以中心为基准的开发板向量应如何渲染，以及应用应向用户提供的该开发板的可选布局（如有）。

### `boardPresetsMap`
支持的开发板应具有与文件顶部定义的 `OPENFIRE_BOARD` 定义对应的名称，后面跟着一个映射，说明每个 GPIO 默认应具有的功能（当板当前偏好设置中的 `OF_Prefs::toggles[OF_Const::customPins]` 设置为 *true* 时加载此映射）。微控制器拥有的每个 GPIO 都应在此处表示，未映射的引脚标记为 `btnUnmapped`，保留或不向用户暴露的引脚标记为 `unavailable`。RP2040 和 RP235X-A 开发板最多应有三十个引脚——注意，即使 `rpipico` 仅暴露大约 26 个引脚，仍会考虑隐藏的 GPIO。

### `boardBoxPositions`
与 `boardPresetsMap` 类似，对于每个支持的 `OPENFIRE_BOARD`，此处提供一个映射，表示桌面应用程序图形化板视图中每个引脚大致的*位置*，用两个值的和表示——左边为从 1 开始的正整数相对位置，右边为枚举值，表示引脚元素应放置在板子的哪一侧。添加 `posLeft`、`posRight` 和 `posMiddle` 将把该 GPIO 放置在板视图的相应侧面，添加 `posNothing`（字面值为 0）将通知应用程序完全不显示该引脚，应对 `boardPresetsMap` 中的 `unavailable` 引脚使用。值的数量应与预设映射中定义的 GPIO 数量匹配。

### `boardsAltPresets`
这是用于可选的备用板预设，将在板布局视图中以下拉列表的形式显示备用布局名称。每个支持的 `OPENFIRE_BOARD` 可以列出多次，每个备用布局对应一次——板名后的字符串表示界面应显示的标签，后跟一个用大括号括起的 GPIO 板功能映射，与 `boardPresetsMap` 完全相同；相同的约定和限制适用。此功能主要用于匹配使用不同建议按钮映射/接线的适配器板的布局，例如 `adafruitItsy` 的 SAMCO 1.1 布局，该布局与默认的 SAMCO 2.0 布局映射不同；另外注意，当前参考桌面应用支持导出和导入自定义布局。

## `boardPics/` - 板矢量图和引脚高亮
这是桌面应用应使用的板矢量图存储库，用于在板布局视图中图形化表示当前连接到应用程序的开发板。板矢量图应导出为*纯 SVG*（或等效格式），并添加到 `vectors.qrc` 资源文件中，每个文件的别名应与 `OpenFIREshared.h` 中 `OPENFIRE_BOARD` 字符串定义的板名匹配。

当前参考桌面应用能够在用户将鼠标悬停在界面中的 GPIO 引脚项上时显示*高亮引脚*。为此，SVG 需要按以下步骤修改（以 Inkscape 为主要示例界面）：
 1. 如果尚未分组，将图像现有的所有板对象分组为一个组（组名无关紧要）。同时确保引脚孔实际上是透明的，而不是填充背景色。
 2. 创建一个新组，放置在板组的*下方*——组名无关紧要，但为了方便使用，建议命名为 `OF`。
 3. 在新建的高亮组内，创建高亮元素，不带描边，填充为单一纯色（现有板使用 RGBA 颜色 `ebe713`，即 *R253/G231/B19*）。
 4. 选择高亮元素，打开*对象属性*选项卡（或显示 *"ID"* 行的等效界面）：每个高亮元素需设置 ID，格式为 `OF_pinX` ——其中 X 为 GPIO 引脚号，无前导零。
 5. 高亮元素选中时，打开*填充与描边*选项卡（或显示 *"不透明度 (%)"* 的等效界面），将不透明度设置为 **0.0**。
 6. 确认所有元素的位置、命名和不透明度设置满意后，保存文件为 ***纯 SVG*** 格式，放入 `boardPics` 目录。确保 `vectors.qrc` 中已将该板列为与您在 `OpenFIREshared.h` 中为该微控制器设置的 `OPENFIRE_BOARD` 字符串匹配的别名！

> [!注意]
> 此操作应**仅**针对每个*可访问*的板上 GPIO 引脚执行（即 `boardPresetsMap` 中标记为 `unavailable` 的引脚不应添加，因为应用程序会隐藏这些引脚）。

完成后，重新构建应用程序并测试板图；最简单的方法是使用 *帮助->查看兼容板* 窗口，并将鼠标悬停在对应 GPIO 的标签上。

> [!注意]
> - 如果板图完全不显示，可能是矢量文件未正确命名或导出——请仔细检查是否正确执行了第 6 步。
> - 如果板图显示但高亮不显示（或显示在错误引脚上），可能需要手动在文本编辑器（如记事本）中编辑导出的 SVG 文件中的某些行。矢量文件工作的技术要求及检查点为：
>   - `id="OF_pinX"` 行必须*在* `style="` 行之上。
>   - `style="` 行内必须包含 `opacity:0`（最好为 `0` 或 `0.0`，具体哪个无所谓，但要保持一致）。
> 参见下方示例（摘自 [`pico.svg`](https://raw.githubusercontent.com/alessandro-satanassi/OpenFIRE-Boards-ESP32/main/boardPics/pico.svg)），了解每个高亮元素的理想格式：
> ```html
>   <g
>      id="OF">
>     <path
>        id="OF_pin1"
>        style="opacity:0;fill:#ebe713;fill-opacity:1"
>        class="st10"
>        d="M19.7,47.4c0,3.4-2.9,6.2-6.3,6.2s-6.2-2.8-6.3-6.2,2.7-6.3,6.1-6.4c3.4,0,6.3,2.6,6.5,6" />
>     <path
>        id="OF_pin2"
>        style="opacity:0;fill:#ebe713;fill-opacity:1"
>        class="st10"
>        d="M19.8,88.1c0,3.4-2.9,6.2-6.3,6.2s-6.2-2.8-6.3-6.2c0-3.4,2.7-6.3,6.1-6.4,3.4,0,6.3,2.6,6.5,6" />
> ...
> ```




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---
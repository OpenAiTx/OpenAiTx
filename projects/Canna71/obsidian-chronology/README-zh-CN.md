# Obsidian 时间轴插件

提供一个侧边栏，显示你的笔记的日历视图。

![](https://raw.githubusercontent.com/Canna71/obsidian-chronology/master/media/demo.gif)

该日历允许导航并选择每日、每周、每月或自定义范围的笔记。每日和每周范围以时间线形式显示，但你可以通过启用设置 `显示简单列表` 强制以简单列表形式显示笔记。
在时间线视图中，你可以通过启用 `将同一时间段的笔记分组` 来将创建或修改于同一时间段的笔记分组显示。

点击月份名称可以查看该月份所有笔记的列表。

要选择要显示的日期范围：先选择一个日期，然后按住 Shift 点击范围的另一个日期。

时间线中的笔记将以彩色标记显示，指示它们是在该时刻**创建**还是**修改**的。

![](https://raw.githubusercontent.com/Canna71/obsidian-chronology/master/media/example.png)

点击笔记名称将打开该笔记。按 Ctrl（或 Command）点击笔记名称将在新窗格中打开。

在日历中，你可以选择单天或左侧的周数。

日期块的背景颜色显示该天创建或编辑的笔记数量。该刻度还依赖于设置中每日笔记数量的平均值。

# Obsidian 同步问题
如果你使用 Obsidian 同步，可能会注意到同步的文件创建时间戳对应的是它们同步到其他设备的时间。
在 1.1.9 版本中，添加了一些设置以解决此问题，方法是（可选地）从文件元数据中读取笔记的实际创建日期。
并非每个笔记的元数据中都必须有创建/修改日期，如果缺失，插件将回退使用文件的创建或修改日期。




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-20

---
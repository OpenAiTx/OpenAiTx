# gnome-gamma-tool

一个命令行工具，允许你通过创建带有 VCGT 表的色彩配置文件，以持久的方式更改 GNOME 和 Cinnamon 中的伽马、对比度和亮度。

## 免责声明
**此工具仅适用于 GNOME 和 Cinnamon**。已在 Fedora 上的 GNOME 42-48 和 Cinnamon 版本测试，可能无法在旧版/新版中正常工作，但已生成的配置文件应继续有效。

这是相当黑客式的做法，色彩配置文件本不打算这样使用。但我认为这种使用场景足够少见，值得这么做。毕竟，如果你的显示器不允许你更改伽马，这难道不是显示器的问题吗？

详见[工作原理](#how-it-works)部分的详细说明。

**注意：**由于 VCGT 的限制，无法更改屏幕的饱和度或色调，但你可以尝试使用 [gnome-saturation-extension](https://github.com/zb3/gnome-saturation-extension)（不过该扩展也有其缺点）。

## 使用方法
无需安装，只需克隆此仓库：
```
git clone https://github.com/zb3/gnome-gamma-tool
cd gnome-gamma-tool
```

**如果**你使用的是 Debian/Ubuntu，可能还需要先安装 `gir1.2-colord-1.0` 软件包：
```
sudo apt install gir1.2-colord-1.0
```
对于 OpenSUSE，您可能需要安装 `typelib-1_0-Colord-1_0` 软件包：
```
sudo zypper install typelib-1_0-Colord-1_0
```
如果你使用的是 NixOS，请查看[此评论](https://github.com/zb3/gnome-gamma-tool/issues/28#issuecomment-3112277504)

然后你可以这样调用该工具：
```
./gnome-gamma-tool.py
```
（如果这不起作用，请在[这里](https://github.com/zb3/gnome-gamma-tool/issues/new)打开一个新问题）

一旦新的配置文件安装完成，该工具可以安全移除。

### 调整屏幕伽马
`-g` 参数允许您指定伽马校正因子。您也可以使用 `R:G:B` 形式为单独通道设置。

例如：

```
./gnome-gamma-tool.py -g 0.8
```
or
```
./gnome-gamma-tool.py -g 0.8:0.8:0.8
```

### 调整对比度（或反转颜色）
您也可以使用 `-c` 参数来更改对比度。`1` 是默认值，而 `-1` 则会有效地反转颜色。请确保不要使用 `0`，因为这会使显示变成全灰色...

例如：
```
./gnome-gamma-tool.py -c -1
```
请注意，它总是从初始状态开始，因此上述命令将撤销任何先前的伽马调整，但您可以组合不同的选项：


```
./gnome-gamma-tool.py -g 0.8 -c 0.5
```

这里同样适用每通道设置，因此例如可以反转蓝色通道，同时保持红色和绿色不变。你能猜出这会是什么样子吗？试试看吧：
```
./gnome-gamma-tool.py -c=1:1:-1
```
那是你预期的吗？ :)

### 更改色温
色温也可以更改，使用 `-t` 选项指定温度。数值的使用方式与 `redshift` 相同，`6500` 是中性值。请注意，这不会阻止夜间模式功能的运行，只是夜间模式的调整是在 gnome-gamma-tool 所做调整的“基础上”进行的。
```
./gnome-gamma-tool.py -t 5000
```

### 调整亮度（有点）
您也可以使用此工具调整亮度，但无法增加物理显示器的亮度，只能通过降低最大亮度值来减少亮度。使用 `-b` 选项来实现，取值范围是 `0` 到 `1`，其中 `1` 为中性值：
```
./gnome-gamma-tool.py -b 0.7
```
这里还有另一个选项允许你*增加* *最小*亮度值。它是`-bm`选项，同样接受从`0`到`1`的值，这次`0`是中性值。执行以下操作后：

```
./gnome-gamma-tool.py -bm 0.3
```
输出值永远不会小于 `0.3`，因此黑色不会是纯黑，而实际上是灰色，而白色仍然是白色，中间的颜色将相应地被乘以。也可以使用 `-b` 和 `-bm` 的组合来反转颜色：
```
./gnome-gamma-tool.py -b 0 -bm 1
```

而且……这还不是全部，因为这些也适用于各个独立通道，这要归功于 `R:G:B` 表示法。这开启了新的可能性，比如……让你的屏幕更绿（这是色温无法实现的）：
```
./gnome-gamma-tool.py -b 1:2:1
```
上面首先被转换成 `0.5:1:0.5`，从技术上讲，它使你的屏幕减少了红色和蓝色，但实际上它使屏幕看起来更绿。多么有用的功能，你不觉得吗？


### 如果你有多个显示器
你可以使用 `-d` 选项指定显示器的 *索引*（第一个的索引是 `0`，但这是默认的，所以在这种情况下你不需要使用这个参数……）。显示器的顺序与 `设置 -> 颜色` 面板中的顺序相同。下面是示例：
```
./gnome-gamma-tool.py -d 1 -g 0.7
```
你也可以使用 `-a` 选项对所有显示器应用更改：

```
./gnome-gamma-tool.py -a -g 0.7
```

### 导出到文件

如果您只想创建一个带有正确 VCGT 表的 ICC 配置文件，但不想与当前配置交互，可以使用 `-o`/`--out-file` 参数。请注意，它不会加载您当前的配置文件，因此输出将是一个 sRGB 配置文件，除非您使用 `-i`/`--in-file` 参数指定基础配置文件。

然后，您可以使用像 `colormgr` 这样的工具导入并应用它。

```
# Create myprofile.icc file
python3 ./gnome-gamma-tool.py --min-brightness 0.05 --brightness 0.95 --out-file myprofile.icc

# This command will print Device ID, save it
colormgr get-devices

# This command will print Profile ID, save it
colormgr import-profile myprofile.icc

# This command will affect colors immediately
colormgr device-add-profile $displayId $profileId

# This command will remove imported profile and revert colors to original state immediately.
colormgr delete-profile $profileId
```
## 工作原理

Mutter（GNOME 的合成器）没有实现任何可用的 Wayland 协议，因此像 `gammastep` 或 `wl-gammactl` 这样的工具无法工作。Mutter 通过 D-Bus 暴露了 `SetCrtcGamma` 方法，这个方法确实有效。但这不是 gnome-gamma-tool 实现其目的的方式，因为：
* 该值不会被保存，因此效果不具备持久性
* 该方法已被另一个守护进程调用，因此效果只是暂时的。

该方法通常由 `gsd-color` 守护进程（间接）调用，目前有两件事会影响其参数：
* 当前启用的色彩配置文件的 VCGT 表（通过 colord 获取）
* 来自“夜间灯光”设置的色温
（这两者会被合并）

现在，似乎显而易见的解决方案是修补 `gsd-color`，以便也考虑其他因素（如 GSettings 属性），这样你就可以通过 `gsettings` 命令调整伽玛。这样也为以后在显示面板添加 GUI 打开了可能性。

然而，这不是 gnome-gamma-tool 的工作方式，因为修补 `gsd-color` 只有在该补丁将被合并到上游时才有意义。否则，我（也可能是你）完全无法接受需要应用自定义补丁并重建 GNOME 的部分组件。这就是为什么 gnome-gamma-tool 安装了带有正确“VCGT”表的色彩配置文件。

`gsd-color` 不管理色彩配置文件，它通过 colord 提供的 API 观察它们。要让 `gsd-color` 识别一个配置文件，必须完成以下操作：
* 为给定设备启用色彩配置文件
* 安装该配置文件（在 colord 数据库中）
* 将该配置文件与设备关联
* 启用该配置文件

所有这些步骤都是通过 colord 通过 D-Bus 暴露的 API 完成的。gnome-gamma-tool 不会从头创建新配置文件（除非你指定了 `-o`/`--out-file`），而是克隆当前配置文件并仅修改 VCGT 表。默认情况下，当前配置文件是由 `gsd-color` 从 EDID 数据生成的。

`gsd-color` 使用 D-Bus 信号监听设备/配置文件更改，因此它会捕获我们的配置文件更改，然后最终调用 `SetCrtcGamma`。就是这样！

那么，这个“VCGT”是什么？VCGT（视频卡伽玛表）基本上映射颜色通道（R、G 和 B）的值。比如如果一个通道的值是 `X`，那么 VCGT 指定它应转换为 `Y`。当然，并非每个输入值都有 VCGT 条目，该表只有 256 个条目，值是插值计算的（但这不是由 gnome-gamma-tool 完成的）。

VCGT 使得可以改变伽玛（通过指数运算）、对比度和亮度，但不能通过这种方式改变色调，因为一个通道无法影响另一个通道。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-16

---
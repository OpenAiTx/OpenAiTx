<head><meta name="google-site-verification" content="YTr2AYTpsxIQk7KIOlVTOfKr11dqkzZP-gOUiyhPU5s" />
<body>

<h1>KOMB：Klipper的终极刷头宏</h1>

欢迎使用KOMB，Klipper优化的刷头宏！这个多功能宏简化了刷头序列，专为床面和龙门安装的刷头量身定制。告别调整现有宏或创建新宏的麻烦——现在你可以在三维空间中充分发挥刷头的全部潜力！

<h3> 安装： </h3>

开始使用KAMP最简洁、最方便的方法是使用Moonraker的更新管理器工具。这将帮助你轻松安装，并在更多功能发布时提供未来更新！

1. 使用`ssh`连接到你的Klipper设备并执行以下命令：
   ```bash
    cd
    
    git clone https://github.com/TmRxJD/KOMB    

    ln -s ~/KOMB printer_data/config/KOMB

    cp ~/KOMB/_KOMB_Variables.cfg ~/printer_data/config/KOMB_Variables.cfg

    ```

2. 打开你的 `moonraker.conf` 文件并添加以下配置：
   ```yaml
   [update_manager KOMB]
   type: git_repo
   channel: dev
   path: ~/KOMB
   origin: https://github.com/TmRxJD/KOMB
   managed_services: klipper
   primary_branch: main
    ```

    > **注意：**
    > 每当更改 Moonraker 配置时，必须重启才能使更改生效。如果您不希望 Moonraker 通知您 KAMP 的未来更新，可以跳过此步骤。

3. 可选地，将 KOMB_Purge.cfg 包含在您的 KOMB_Variables.cfg 中以使用该宏。

<h3>功能与特性</h3>

灵活运动：KOMB 的默认运动是从左下角扫到右侧，但您可以轻松自定义沿各轴和方向的运动。甚至可以根据您的打印机和刷子位置，在打印过程中使用它。

多样图案：目前支持对角线和圆形扫描（需要启用 gcode_arcs），KOMB 的图案库将很快扩展，包含更多模式。

三维刷洗：充分利用刷子的整个区域和深度，确保喷嘴更干净，性能更稳定，您可以放心，每次喷嘴都会保持干净。喷嘴可逐步下降进入刷子，以使更多喷嘴表面接触刷子。

打印中使用：使用 KOMB 触发器，您可以在打印过程中多次调用宏，确保喷嘴在整个打印期间保持清洁。

<h3>可调刷子参数：调整变量以实现精确控制</h3>
* 指定刷子位置的 (X, Y, Z)，以及大小和深度（单位：毫米）<br>
* 步进大小：对角线或圆形笔画之间的距离<br>
* Z 步进：使用重复时每次迭代后下降的距离，设为 0 以禁用<br>
* 偏移量：允许您在刷子边界之外开始和结束运动，或使用负值限制在内部<br>
* 重复次数：指定图案迭代的次数<br>
* 反向：启用后在下一次重复前反向重复图案回到起点，禁用时喷嘴将直接返回起点<br>
* 从相对或邻近边开始：启用相对边时喷嘴从右向左移动；启用邻近边时喷嘴沿相反轴线从底部向上移动；两者均启用时喷嘴从上向下移动<br>
* 可变速度：指定速度（mm/s），并随着每次重复增加或减少速度，还可以控制移动到刷子时的速度<br>
* 图案：选择不同的刷洗图案，目前支持对角线和圆形（如果您仍想使用经典的水平图案，只需将相反轴上的刷子大小设为 0；如果仍需步进，将角度设为 0）<br>
* 角度：使用图案 1 时指定对角线笔画角度，默认推荐角度为 45<br>
* 自动加热：启用并指定允许刷洗的最低温度，刷洗前自动预热至该温度<br>
* 自动回原点：如有需要，自动回原点打印头，仅在未回原点时执行<br>
* 回抽：配置刷洗前、中、后的回抽动作<br>
* Z 跳：指定移动到刷子位置前喷嘴提升的高度，然后下降，设为 0 以禁用<br>
* 详细反馈：启用详细控制台输出，提供刷洗过程的轴值、计算和定位点等全面信息<br>

<h4>KOMB 触发器</h4>

You can use KOMB at a specified frequency throughout the print to ensure your nozzle stays clean for the entire duration. Include `KOMB_trigger` in the 'at layer change' section of your slicer configuration to effortlessly trigger the macro at your preferred frequency. Additionally, integrate this macro name into your start print routine to use the macro before starting printing. This feature is not intended for per-object printing and is tailored for use with gantry and frame-mounted brushes. While functional with bed-mounted brushes, cautious use is advised, as attention to your printer's clearances is essential to prevent potential collisions. If utilizing Z hop, the nozzle will ascend before maneuvering over the brush, descend for brushing, and subsequently reascend to its initial height before resuming printing. Configure Z hop settings to provide added clearance during elevation and descent. It is strongly recommended not to set the Z hop value below 2. Additionally, ensure that your axis limits are accurately defined for the macro's effective operation. For guidance on setting axis limits, refer to the guide provided at the end of this readme.
<h4>KOMB 清洗</h4>

KOMB 的清洗选项使您能够在进入刷涂序列之前启动受控的材料清洗。此功能在精度至关重要的情况下尤为有用，例如在 Z 偏移校准或其他依赖测量的操作中，无需绘制额外的清洗线。通过使用此功能，您可以轻松定义清洗容器的位置、所需的挤出耗材量以及过渡到刷涂序列之前的等待时间。清洗选项也可以独立于宏的其他部分激活；这为您根据具体需求定制打印过程提供了灵活性。要在开始打印时使用该宏，请在配置中添加“KOMB_purge”。

<h3>KOMB 的独特性</h3>

KOMB 设计为无缝适应多样的打印机设置，支持不同的刷子尺寸和位置。不同于传统宏强制喷嘴移动到特定位置，KOMB 根据您的变量生成整个坐标序列，预先调整以保持在打印机限位内。这种主动方法几乎消除了错误风险，确保无论用户错误如何，刷涂都能成功执行。任何超出打印机边界的生成点都会自动调整至范围内，保证顺畅执行。列表一经生成，KOMB 便轻松引导喷嘴通过预定坐标。

<h3>开始使用 KOMB</h3>

确保您的 3D 打印机已安装 Klipper 固件。

将提供的 KOMB 宏代码 `KOMB.cfg` 集成到您的 Klipper 配置文件 “printer.cfg” 中，和其他宏一同使用。为提升用户友好性，建议将 KOMB 变量保存在单独文件中，并通过 `[include _KOMB_Variables.cfg]` 引入。或者，如果您觉得方便，也可以合并到主配置文件。

在 KOMB_Variables 部分指定变量以匹配您的刷涂需求。

通过打印机界面确定精确的 XY 刷子位置。以左下角为起点，若需要可调整至 0.1mm 精度。

测量刷子尺寸，或通过移动到右上角并从右上位置减去左下位置的 X 和 Y 坐标进行计算。
对 Z 位置重复类似步骤，考虑每次迭代递减喷嘴高度的选项（z_step）。

保存配置文件并重新加载 Klipper 以应用更改。

通过控制台、UI 宏按钮执行 KOMB，或将 `KOMB` 添加到开始打印宏。执行前确保变量配置准确。

启用详细输出时，可通过控制台输出监控进度。

享受 KOMB 带来的增强刷涂体验！

<h3>重要说明</h3>

此宏设计支持多种变量和参数。请根据打印机规格和刷涂需求调整它们。务必理解每个变量的作用及使用方法。

必须确保轴限位设置正确，宏才能正常运行。如不确定，请参阅指南：https://github.com/rootiest/zippy_guides/blob/main/guides/axis_limits.md

由于宏涉及喷嘴移动，操作时请谨慎，避免刷涂过程中发生碰撞，并确保所有数值正确。建议先在刷子上方低速测试宏，然后再降低到指定位置。

请务必关注未来更新及更多图案！


KOMB仍在开发中，并非所有变量组合都经过了彻底测试。非常感谢您的反馈和对宏改进的贡献。

如果您遇到任何问题，有改进建议，或希望为KOMB的发展做出贡献，请随时给我留言，提交问题或在GitHub仓库中提交拉取请求。

祝您使用KOMB愉快！


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-14

---
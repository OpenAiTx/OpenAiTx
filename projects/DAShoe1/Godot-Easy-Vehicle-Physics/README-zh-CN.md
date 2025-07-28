# Godot-Easy-Vehicle-Physics
一个基于射线投射的刚体车辆系统，适用于 Godot 4.2 及以上版本

## 描述
一个基于物理的车辆控制器，设计用于键盘操作且易于配置。所有参数都包含在一个脚本（vehicle.gd）中，并为所有参数提供了工具提示。

## 特性
该控制器包含许多辅助系统，帮助构建一个性能良好的车辆，如：
- 转向辅助
- 反向转向辅助
- 牵引力控制
- 防抱死制动系统
- 稳定性辅助
- 空中辅助
- 自动变速箱
- 锁定差速器
- 轮胎抓地力辅助
- 计算悬挂参数；正确的悬挂参数难以调校，因此该控制器会基于比例和重量分布计算弹簧刚度和阻尼率。

## 示例
包含 4 个示例车辆：
- demo_arcade.tscn：操作类似街机风格赛车，抓地力强，易于控制，辅助功能丰富。
- demo_simcade.tscn：操作更接近真实车辆，带有辅助以帮助车辆保持控制。
- demo_monster_truck.tscn：操作像怪兽卡车，辅助功能很少。
- demo_drift.tscn：为轻松漂移而设定。

## 控制
- 转向：左转：← 或 a 右转：→ 或 d
- 油门：↑ 或 w
- 制动：↓ 或 s
- 手刹：空格键
- 离合器：C
- 切换变速箱（自动/手动）：T
- 升挡：F 或 +
- 降挡：R 或 -
- 调试信息：~
- 切换调试界面：< 或 >

## 物理引擎
该控制器在 Godot 和 Jolt 物理引擎中表现良好。建议物理更新频率至少为 120，且可使用更高频率，但请注意切换频率会影响车辆行为。

## 致谢
非常感谢 Dechode 和 Wolfe 与 Godot 社区分享他们的项目。分享此项目是我的回馈方式。部分代码基于 [Dechode 的 Godot 高级车辆](https://github.com/Dechode/Godot-Advanced-Vehicle) 和 [系列：驾驶模拟工作坊](https://lupine-vidya.itch.io/gdsim/devlog/677572/series-driving-simulator-workshop-mirror)，在相关源文件中包含了归属说明。
演示所用的车辆模型来自 [Kenney.nl 车套件](https://www.kenney.nl/assets/car-kit)

## 使用 Godot Easy Vehicle Physics 的项目
如果你正在使用此插件开发项目并希望列出在此处，请打开问题告知我。
- [Jack of all Cars](https://dashoe1.itch.io/jack-of-all-cars)
- [Another Lap](https://store.steampowered.com/app/3550210/Another_Lap/)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-28

---
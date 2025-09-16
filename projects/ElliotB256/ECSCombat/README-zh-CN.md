# ECSCombat

一个科幻战斗模拟，使用Unity的ECS框架。

[![预览图片](https://img.youtube.com/vi/S2RJfbJly_A/0.jpg)](https://www.youtube.com/watch?v=S2RJfbJly_A)

无限战斗的视频可以在[这里](https://www.youtube.com/watch?v=S2RJfbJly_A)观看。

## 建议查看内容：

* 不同的AI行为可以在 `Battle/AI` 中找到。
* 战斗系统位于 `Battle/Combat`。包括不同类型的武器（投射物/即时），基于距离的武器效果，使用护盾拦截攻击。
* 装备和器材位于 `Battle/Equipment`。飞船可以装配不同的设备，这些设备可以影响飞船的速度或转向速度。设备在飞船被攻击时可能受损并失效，例如受损的引擎会导致飞船瘫痪。

## 技术细节：

* Unity 2020.1.0b7
* 通用渲染管线（使用Shader Graph制作飞船着色器）

## 一句提醒！

该项目最初是我练习ECS（实体-组件-系统）编程风格时创建的，那时Unity Entities包还很年轻。
自那以后，Unity Entities API和最佳实践都发生了重大变化。
我尽力在有时间时保持更新，但由于自由时间有限，仍不可避免地存在一些需要改进的地方。
所以，完全可以从中获得灵感，但请注意可能有更好的实现方式！

## 最后的致谢

部分精灵图是我制作的，但那些好看的图像取自[这里](https://opengameart.org/content/spaceships-1)，作者是[Wuhu](https://opengameart.org/users/wuhu)。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-16

---
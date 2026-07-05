![Banner](https://i.imgur.com/qyWHmxW.png)

Gizmo3D 封装了 Godot 引擎的 3D 移动/缩放/旋转控制器为一个可自定义的节点，用于运行时使用。主要区别在于你可以同时编辑所有变换，并且添加了自定义选项。选择框和轴可以切换，颜色可以更改，捕捉间隔可以调整，等等。变换方法可以轻松重写以自定义默认行为。它同时支持 C# 和 GDScript。

### 安装
将 addons 文件夹中的 Gizmo3DScript 或 Gizmo3DSharp 复制到你项目的 addons 文件夹中。关于安装和启用插件的更多信息，请参阅[这里](https://docs.godotengine.org/en/stable/tutorials/plugins/editor/installing_plugins.html)。

安装完成后，你可以在项目中添加 Gizmo3D 节点。建议查看演示项目的使用方法——注意，要使用演示，你需要 **git clone** 仓库，因为该制品是为 Godot 资源库使用而设置的。

### 信号

C#                  | GDScript            |
--------------------|---------------------|
`SelectionChanged`  | `selection_changed` |
`TransformBegin`    | `transform_begin`   |
`TransformChanged`  | `transform_changed` |
`TransformEnd`      | `transform_end`     |

### 可重写的变换

| C#                | GDScript             |
|-------------------|----------------------|
| `EditTranslate()` | `_edit_translate()`  |
| `EditScale()`     | `_edit_scale()`      |
| `EditRotate()`    | `_edit_rotate()`     |

### 许可
Gizmo3D 大部分是 Godot 引擎源码中 C++ 代码的移植。Gizmo3D 采用 MIT 许可，Godot 引擎的许可见[此处](https://godotengine.org/license/)。演示项目使用了 Kenney 的 CC0 许可的 [Mini Dungeon](https://kenney.nl/assets/mini-dungeon) 资源包。横幅 Logo 使用了 [Dimbo](https://www.dafont.com/dimbo.font) 字体。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-05

---
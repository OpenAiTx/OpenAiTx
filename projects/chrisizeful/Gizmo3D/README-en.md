![Banner](https://i.imgur.com/qyWHmxW.png)

Gizmo3D encapsulates the Godot Engine's 3D move/scale/rotation gizmos into a customizable node for use at runtime. The major differences are that you can edit all transformations at the same time, and customization options have been added. The selection box and axes can be toggled, colors changed, snapping intervals changed, and more. Transformation methods can be easily overridden to customize the default behavior. It is available in both C# and GDScript.

### Installation
Copy either Gizmo3DScript or Gizmo3DSharp from the addons folder into the addons folder of your project. Read more about installing and enabling addons [here](https://docs.godotengine.org/en/stable/tutorials/plugins/editor/installing_plugins.html). 

Once installed, you can add a Gizmo3D node to your project. For usage, it's recommended to take a look at the demo project - note that to use the demo you will have to **git clone** the repo, since the artifact is set up for use with the Godot Asset Library.

### Signals

C#                  | GDScript            |
--------------------|---------------------|
`SelectionChanged`  | `selection_changed` |
`TransformBegin`    | `transform_begin`   |
`TransformChanged`  | `transform_changed` |
`TransformEnd`      | `transform_end`     |

### Overridable Transformations

| C#                | GDScript             |
|-------------------|----------------------|
| `EditTranslate()` | `_edit_translate()`  |
| `EditScale()`     | `_edit_scale()`      |
| `EditRotate()`    | `_edit_rotate()`     |

### Licensing
Gizmo3D is largely a port of C++ code from the Godot Engine source. Gizmo3D is licensed under MIT, while the license for the Godot Engine can be found [here](https://godotengine.org/license/). The demo project uses assets from Kenney's CC0 licensed [Mini Dungeon](https://kenney.nl/assets/mini-dungeon) asset pack. The banner logo uses the [Dimbo](https://www.dafont.com/dimbo.font) font.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-05

---
![Banner](https://i.imgur.com/qyWHmxW.png)

Gizmo3D encapsula los gizmos de movimiento/escala/rotación 3D del motor Godot en un nodo personalizable para usar en tiempo de ejecución. Las principales diferencias son que puedes editar todas las transformaciones al mismo tiempo, y se han añadido opciones de personalización. Se puede alternar la caja de selección y los ejes, cambiar colores, modificar los intervalos de ajuste, y más. Los métodos de transformación pueden ser fácilmente sobrescritos para personalizar el comportamiento predeterminado. Está disponible tanto en C# como en GDScript.

### Instalación
Copia Gizmo3DScript o Gizmo3DSharp desde la carpeta addons a la carpeta addons de tu proyecto. Lee más sobre cómo instalar y habilitar addons [aquí](https://docs.godotengine.org/en/stable/tutorials/plugins/editor/installing_plugins.html).

Una vez instalado, puedes agregar un nodo Gizmo3D a tu proyecto. Para su uso, se recomienda echar un vistazo al proyecto de demostración - ten en cuenta que para usar la demo tendrás que **git clone** el repositorio, ya que el artefacto está configurado para usarse con la Biblioteca de Assets de Godot.

### Señales

C#                  | GDScript            |
--------------------|---------------------|
`SelectionChanged`  | `selection_changed` |
`TransformBegin`    | `transform_begin`   |
`TransformChanged`  | `transform_changed` |
`TransformEnd`      | `transform_end`     |

### Transformaciones Sobrescribibles

| C#                | GDScript             |
|-------------------|----------------------|
| `EditTranslate()` | `_edit_translate()`  |
| `EditScale()`     | `_edit_scale()`      |
| `EditRotate()`    | `_edit_rotate()`     |

### Licencia
Gizmo3D es en gran medida un port del código C++ del motor Godot. Gizmo3D está licenciado bajo MIT, mientras que la licencia del motor Godot puede encontrarse [aquí](https://godotengine.org/license/). El proyecto de demostración usa assets del paquete con licencia CC0 [Mini Dungeon](https://kenney.nl/assets/mini-dungeon) de Kenney. El logo del banner usa la fuente [Dimbo](https://www.dafont.com/dimbo.font).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-05

---
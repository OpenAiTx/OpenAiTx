![Bannière](https://i.imgur.com/qyWHmxW.png)

Gizmo3D encapsule les gizmos de déplacement/échelle/rotation 3D du moteur Godot dans un nœud personnalisable pour une utilisation à l'exécution. Les principales différences sont que vous pouvez modifier toutes les transformations en même temps, et des options de personnalisation ont été ajoutées. La boîte de sélection et les axes peuvent être activés ou désactivés, les couleurs changées, les intervalles de capture modifiés, et plus encore. Les méthodes de transformation peuvent être facilement remplacées pour personnaliser le comportement par défaut. Il est disponible en C# et en GDScript.

### Installation
Copiez soit Gizmo3DScript soit Gizmo3DSharp depuis le dossier addons dans le dossier addons de votre projet. Lisez-en plus sur l'installation et l'activation des addons [ici](https://docs.godotengine.org/en/stable/tutorials/plugins/editor/installing_plugins.html). 

Une fois installé, vous pouvez ajouter un nœud Gizmo3D à votre projet. Pour l'utilisation, il est recommandé de jeter un œil au projet de démonstration - notez que pour utiliser la démo, vous devrez **git clone** le dépôt, puisque l’artefact est configuré pour une utilisation avec la Bibliothèque d’Assets Godot.

### Signaux

C#                  | GDScript            |
--------------------|---------------------|
`SelectionChanged`  | `selection_changed` |
`TransformBegin`    | `transform_begin`   |
`TransformChanged`  | `transform_changed` |
`TransformEnd`      | `transform_end`     |

### Transformations remplaçables

| C#                | GDScript             |
|-------------------|----------------------|
| `EditTranslate()` | `_edit_translate()`  |
| `EditScale()`     | `_edit_scale()`      |
| `EditRotate()`    | `_edit_rotate()`     |

### Licence
Gizmo3D est en grande partie un portage de code C++ issu du code source du moteur Godot. Gizmo3D est sous licence MIT, tandis que la licence du moteur Godot est disponible [ici](https://godotengine.org/license/). Le projet de démonstration utilise des ressources du pack d’assets [Mini Dungeon](https://kenney.nl/assets/mini-dungeon) de Kenney sous licence CC0. Le logo de la bannière utilise la police [Dimbo](https://www.dafont.com/dimbo.font).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-05

---
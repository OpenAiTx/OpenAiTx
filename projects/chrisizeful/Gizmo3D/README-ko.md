![배너](https://i.imgur.com/qyWHmxW.png)

Gizmo3D는 Godot 엔진의 3D 이동/스케일/회전 기즈모를 런타임에 사용할 수 있도록 커스터마이징 가능한 노드로 캡슐화합니다. 주요 차이점은 모든 변환을 동시에 편집할 수 있고, 커스터마이징 옵션이 추가되었다는 점입니다. 선택 박스와 축을 토글할 수 있고, 색상을 변경하며, 스냅 간격을 변경하는 등 다양한 기능이 있습니다. 변환 메서드는 기본 동작을 커스터마이징하기 위해 쉽게 오버라이드할 수 있습니다. C#과 GDScript 모두에서 사용할 수 있습니다.

### 설치
addons 폴더에서 Gizmo3DScript 또는 Gizmo3DSharp을 프로젝트의 addons 폴더로 복사하세요. 플러그인 설치 및 활성화에 대한 자세한 내용은 [여기](https://docs.godotengine.org/en/stable/tutorials/plugins/editor/installing_plugins.html)를 참고하세요. 

설치 후, 프로젝트에 Gizmo3D 노드를 추가할 수 있습니다. 사용법은 데모 프로젝트를 확인하는 것이 좋으며, 데모를 사용하려면 아티팩트가 Godot 에셋 라이브러리용으로 설정되어 있기 때문에 **git clone**으로 저장소를 복제해야 합니다.

### 시그널

C#                  | GDScript            |
--------------------|---------------------|
`SelectionChanged`  | `selection_changed` |
`TransformBegin`    | `transform_begin`   |
`TransformChanged`  | `transform_changed` |
`TransformEnd`      | `transform_end`     |

### 오버라이드 가능한 변환 메서드

| C#                | GDScript             |
|-------------------|----------------------|
| `EditTranslate()` | `_edit_translate()`  |
| `EditScale()`     | `_edit_scale()`      |
| `EditRotate()`    | `_edit_rotate()`     |

### 라이선스
Gizmo3D는 주로 Godot 엔진 소스의 C++ 코드를 포팅한 것입니다. Gizmo3D는 MIT 라이선스 하에 배포되며, Godot 엔진의 라이선스는 [여기](https://godotengine.org/license/)에서 확인할 수 있습니다. 데모 프로젝트는 Kenney의 CC0 라이선스가 적용된 [Mini Dungeon](https://kenney.nl/assets/mini-dungeon) 에셋 팩을 사용합니다. 배너 로고는 [Dimbo](https://www.dafont.com/dimbo.font) 폰트를 사용합니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-05

---
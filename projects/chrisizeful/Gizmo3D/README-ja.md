![Banner](https://i.imgur.com/qyWHmxW.png)

Gizmo3DはGodotエンジンの3D移動/スケール/回転ギズモをランタイムで使用可能なカスタマイズ可能なノードにカプセル化したものです。主な違いは、すべての変換を同時に編集できることと、カスタマイズオプションが追加されていることです。選択ボックスや軸の表示切替、色の変更、スナップ間隔の変更などが可能です。変換メソッドは簡単にオーバーライドしてデフォルトの動作をカスタマイズできます。C#とGDScriptの両方で利用可能です。

### インストール
addonsフォルダからGizmo3DScriptまたはGizmo3DSharpをプロジェクトのaddonsフォルダにコピーします。アドオンのインストールと有効化については[こちら](https://docs.godotengine.org/en/stable/tutorials/plugins/editor/installing_plugins.html)を参照してください。

インストール後、プロジェクトにGizmo3Dノードを追加できます。使用方法についてはデモプロジェクトを見ることをお勧めします。デモを使用するにはリポジトリを**git clone**する必要があります。アーティファクトはGodot Asset Library用に設定されています。

### シグナル

C#                  | GDScript            |
--------------------|---------------------|
`SelectionChanged`  | `selection_changed` |
`TransformBegin`    | `transform_begin`   |
`TransformChanged`  | `transform_changed` |
`TransformEnd`      | `transform_end`     |

### オーバーライド可能な変換メソッド

| C#                | GDScript             |
|-------------------|----------------------|
| `EditTranslate()` | `_edit_translate()`  |
| `EditScale()`     | `_edit_scale()`      |
| `EditRotate()`    | `_edit_rotate()`     |

### ライセンス
Gizmo3Dは主にGodotエンジンのソースコードからのC++コードの移植です。Gizmo3DはMITライセンスで提供されており、Godotエンジンのライセンスは[こちら](https://godotengine.org/license/)にあります。デモプロジェクトではKenneyのCC0ライセンスの[Mini Dungeon](https://kenney.nl/assets/mini-dungeon)アセットパックの資産を使用しています。バナーロゴには[Dimbo](https://www.dafont.com/dimbo.font)フォントを使用しています。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-05

---
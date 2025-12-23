# GTML - Godot マークアップ言語

Godot 4.x 用のアドオンで、HTML と CSS を使って UI を構築できます。ゲームメニュー、HUD、パネルを馴染みのあるウェブ技術で作成可能です。

## 特徴

- 20 種類以上の要素を持つ HTML ベースの UI 構造
- 80 以上のプロパティに対応した外部 CSS スタイリング
- エディタ内でのライブリロード
- Flexbox レイアウトシステム
- SVG レンダリングサポート
- シグナル付きフォーム要素
- CSS トランジションと疑似クラス（:hover、:active、:focus）
- グラデーション背景とカスタムフォント

## クイックスタート

### 1. インストール

`addons/gtml/` をプロジェクトにコピーし、**プロジェクト設定 → プラグイン**で有効化してください。

### 2. ファイル作成

**menu.html:**
```html
<div class="menu">
    <h1>My Game</h1>
    <button @click="on_play">Play</button>
    <button @click="on_quit">Quit</button>
</div>
```

**menu.css:**
```css
.menu {
    display: flex;
    flex-direction: column;
    align-items: center;
    gap: 16px;
    padding: 32px;
    background-color: #1a1a2e;
}

h1 {
    font-size: 32px;
    color: #ffffff;
}

button {
    padding: 12px 24px;
    background-color: #00d4ff;
    border-radius: 4px;
    color: #000000;
    transition: background-color 200ms ease;
}

button:hover {
    background-color: #00a8cc;
}
```

### 3. GmlView ノードを追加

`GmlView` ノードを追加し、インスペクターで **Html Path** と **Css Path** を設定します。

### 4. シグナルを接続する

```gdscript
func _ready():
    $GmlView.button_clicked.connect(_on_button_clicked)

func _on_button_clicked(method_name: String):
    match method_name:
        "on_play":
            get_tree().change_scene_to_file("res://game.tscn")
        "on_quit":
            get_tree().quit()
```
## ドキュメンテーション

- [はじめに](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/getting-started.md) - インストールと基本的な使い方
- [HTML要素](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/html-elements.md) - 対応タグと属性
- [CSSプロパティ](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/css-properties.md) - 完全なプロパティリファレンス
- [CSSセレクター](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/css-selectors.md) - セレクターと疑似クラス
- [フォーム＆入力](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/forms-and-inputs.md) - フォーム要素とイベント
- [SVGサポート](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/svg-support.md) - ベクターグラフィックス
- [レイアウト＆フレックスボックス](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/layout-and-flexbox.md) - レイアウトシステム
- [トランジション](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/transitions.md) - CSSトランジション
- [フォント＆タイポグラフィ](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/fonts-and-typography.md) - カスタムフォント
- [GTMLの拡張](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/extending-gtml.md) - 新機能の追加
- [制限事項](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/limitations.md) - 既知の制限事項

## サンプル

動作デモは `addons/gtml/examples/` を参照してください:
- `basic` - シンプルなメニュー
- `all_elements` - すべてのHTML要素
- `css_features` - CSSプロパティの紹介
- `flex_layout` - フレックスボックスレイアウト
- `transitions` - CSSトランジション

## ライセンス

MITライセンス



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-23

---
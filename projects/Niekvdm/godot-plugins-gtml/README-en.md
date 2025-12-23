# GTML - Godot Markup Language

A Godot 4.x addon that lets you build UI using HTML and CSS. Create game menus, HUDs, and panels with familiar web technologies.

## Features

- HTML-based UI structure with 20+ element types
- External CSS styling with 80+ properties
- Live reload in editor
- Flexbox layout system
- SVG rendering support
- Form elements with signals
- CSS transitions and pseudo-classes (:hover, :active, :focus)
- Gradient backgrounds and custom fonts

## Quick Start

### 1. Install

Copy `addons/gtml/` to your project and enable in **Project Settings → Plugins**.

### 2. Create Files

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

### 3. Add GmlView Node

Add a `GmlView` node and set **Html Path** and **Css Path** in the Inspector.

### 4. Connect Signals

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

## Documentation

- [Getting Started](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/getting-started.md) - Installation and basic usage
- [HTML Elements](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/html-elements.md) - Supported tags and attributes
- [CSS Properties](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/css-properties.md) - Complete property reference
- [CSS Selectors](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/css-selectors.md) - Selectors and pseudo-classes
- [Forms & Inputs](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/forms-and-inputs.md) - Form elements and events
- [SVG Support](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/svg-support.md) - Vector graphics
- [Layout & Flexbox](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/layout-and-flexbox.md) - Layout system
- [Transitions](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/transitions.md) - CSS transitions
- [Fonts & Typography](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/fonts-and-typography.md) - Custom fonts
- [Extending GTML](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/extending-gtml.md) - Add new features
- [Limitations](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/limitations.md) - Known limitations

## Examples

Check `addons/gtml/examples/` for working demos:
- `basic` - Simple menu
- `all_elements` - All HTML elements
- `css_features` - CSS properties showcase
- `flex_layout` - Flexbox layouts
- `transitions` - CSS transitions

## License

MIT License


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-23

---
# GTML - Godot Markup Language

Un complemento para Godot 4.x que te permite construir UI usando HTML y CSS. Crea menús de juego, HUDs y paneles con tecnologías web familiares.

## Características

- Estructura de UI basada en HTML con más de 20 tipos de elementos
- Estilos CSS externos con más de 80 propiedades
- Recarga en vivo en el editor
- Sistema de diseño Flexbox
- Soporte para renderizado SVG
- Elementos de formulario con señales
- Transiciones CSS y pseudo-clases (:hover, :active, :focus)
- Fondos degradados y fuentes personalizadas

## Inicio Rápido

### 1. Instalar

Copia `addons/gtml/` a tu proyecto y habilítalo en **Configuración del Proyecto → Plugins**.

### 2. Crear Archivos

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

### 3. Añadir el nodo GmlView

Añade un nodo `GmlView` y configura **Ruta Html** y **Ruta Css** en el Inspector.

### 4. Conectar señales

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

## Documentación

- [Primeros pasos](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/getting-started.md) - Instalación y uso básico
- [Elementos HTML](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/html-elements.md) - Etiquetas y atributos soportados
- [Propiedades CSS](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/css-properties.md) - Referencia completa de propiedades
- [Selectores CSS](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/css-selectors.md) - Selectores y pseudo-clases
- [Formularios y Entradas](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/forms-and-inputs.md) - Elementos y eventos de formularios
- [Soporte SVG](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/svg-support.md) - Gráficos vectoriales
- [Diseño y Flexbox](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/layout-and-flexbox.md) - Sistema de diseño
- [Transiciones](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/transitions.md) - Transiciones CSS
- [Fuentes y Tipografía](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/fonts-and-typography.md) - Fuentes personalizadas
- [Extender GTML](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/extending-gtml.md) - Añadir nuevas funciones
- [Limitaciones](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/limitations.md) - Limitaciones conocidas

## Ejemplos

Consulta `addons/gtml/examples/` para demos funcionales:
- `basic` - Menú simple
- `all_elements` - Todos los elementos HTML
- `css_features` - Muestra de propiedades CSS
- `flex_layout` - Diseños con Flexbox
- `transitions` - Transiciones CSS

## Licencia

Licencia MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-23

---
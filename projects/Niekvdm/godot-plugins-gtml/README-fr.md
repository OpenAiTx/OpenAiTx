# GTML - Godot Markup Language

Un addon Godot 4.x qui vous permet de créer des interfaces utilisateur en utilisant HTML et CSS. Créez des menus de jeu, des HUD et des panneaux avec des technologies web familières.

## Fonctionnalités

- Structure UI basée sur HTML avec plus de 20 types d'éléments
- Style CSS externe avec plus de 80 propriétés
- Rechargement en direct dans l'éditeur
- Système de mise en page Flexbox
- Support du rendu SVG
- Éléments de formulaire avec signaux
- Transitions CSS et pseudo-classes (:hover, :active, :focus)
- Arrière-plans en dégradé et polices personnalisées

## Démarrage rapide

### 1. Installer

Copiez `addons/gtml/` dans votre projet et activez-le dans **Paramètres du projet → Plugins**.

### 2. Créer les fichiers

**menu.html:**
```html
<div class="menu">
    <h1>My Game</h1>
    <button @click="on_play">Play</button>
    <button @click="on_quit">Quit</button>
</div>
```

**menu.css :**
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

### 3. Ajouter un nœud GmlView

Ajoutez un nœud `GmlView` et définissez **Chemin Html** et **Chemin Css** dans l'Inspecteur.

### 4. Connecter les signaux

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

- [Premiers pas](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/getting-started.md) - Installation et utilisation de base
- [Éléments HTML](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/html-elements.md) - Balises et attributs pris en charge
- [Propriétés CSS](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/css-properties.md) - Référence complète des propriétés
- [Sélecteurs CSS](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/css-selectors.md) - Sélecteurs et pseudo-classes
- [Formulaires & Entrées](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/forms-and-inputs.md) - Éléments de formulaire et événements
- [Support SVG](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/svg-support.md) - Graphiques vectoriels
- [Mise en page & Flexbox](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/layout-and-flexbox.md) - Système de mise en page
- [Transitions](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/transitions.md) - Transitions CSS
- [Polices & Typographie](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/fonts-and-typography.md) - Polices personnalisées
- [Extension de GTML](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/extending-gtml.md) - Ajouter de nouvelles fonctionnalités
- [Limitations](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/limitations.md) - Limitations connues

## Exemples

Consultez `addons/gtml/examples/` pour des démos fonctionnelles :
- `basic` - Menu simple
- `all_elements` - Tous les éléments HTML
- `css_features` - Présentation des propriétés CSS
- `flex_layout` - Mise en page Flexbox
- `transitions` - Transitions CSS

## Licence

Licence MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-23

---
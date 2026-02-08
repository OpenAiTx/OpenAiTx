# AppCUI-rs

<img src="https://raw.githubusercontent.com/gdt050579/AppCUI-rs/main/docs/chapter-1/img/logo.png" align="center" />

```                                                              
⯈ 𝗔𝗽𝗽𝗖𝗨𝗜-𝗿𝘀 🖳
```

![Statut de la compilation Windows](https://github.com/gdt050579/AppCUI-rs/actions/workflows/windows.yml/badge.svg)
![Statut de la compilation Linux](https://github.com/gdt050579/AppCUI-rs/actions/workflows/linux.yml/badge.svg)
![Statut de la compilation MacOS](https://github.com/gdt050579/AppCUI-rs/actions/workflows/macos.yml/badge.svg)
![Couverture du code](https://gist.githubusercontent.com/gdt050579/f7d7e7d56b2725a3b33a265e8a9d8e9c/raw/coverage.svg)
![Licence](https://img.shields.io/github/license/gdt050579/AppCUI-rs)
[![Crates.io](https://img.shields.io/crates/v/appcui.svg)](https://crates.io/crates/appcui)
[![Docs.rs](https://docs.rs/appcui/badge.svg)](https://docs.rs/appcui)
[![Galerie](https://img.shields.io/badge/Gallery-See%20Examples-blue)](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


AppCUI-rs est une bibliothèque Rust rapide et multiplateforme pour construire des interfaces utilisateur modernes en mode texte (TUIs) avec des widgets riches, des thèmes, et un support complet de l’Unicode — une alternative à ncurses et autres frameworks d’interface terminale.
* [Livre](https://gdt050579.github.io/AppCUI-rs/)
* [Documentation](https://docs.rs/appcui)
* [Galerie](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html)


## ✨ Fonctionnalités
- [x] multiples contrôles prêts à l’emploi (boutons, étiquettes, zones de texte, cases à cocher, boutons radio, vues en liste, vues en arbre, boîtes combinées, sélecteurs de date/heure, sélecteurs de couleur, onglets, accordéons, etc.). Une liste complète des contrôles est disponible [ici](https://gdt050579.github.io/AppCUI-rs/chapter-3/stock_controls.html) 
- [x] système de disposition puissant permettant de positionner les contrôles avec des coordonnées absolues, coordonnées relatives, ancrage, alignement, ancres ou positionnement par pivot (voir plus [ici](https://gdt050579.github.io/AppCUI-rs/chapter-3/layout.html)) 
- [x] menus et barres d’outils
- [x] support multiplateforme (Windows via API et terminal virtuel, Linux via ncurses, MacOS via termios)
- [x] support du multithreading pour permettre des tâches en arrière-plan
- [x] minuteurs
- [x] support de la souris
- [x] support du presse-papiers
- [x] thèmes de couleur
- [x] support des caractères Unicode
- [x] dialogues prédéfinis (boîte de message, boîte de saisie, sélecteur de couleur, dialogues de sauvegarde & ouverture, navigateur de dossiers, etc)
- [x] support des vraies couleurs (24 bits par pixel) pour les terminaux qui le supportent.

## 📸 Captures d’écran 

<img src="https://github.com/gdt050579/AppCUI-rs/raw/main/docs/chapter-1/img/appcui-rs-demo.gif" align="center" />

👉 **Découvrez la [Galerie](https://gdt050579.github.io/AppCUI-rs/gallery/screenshots.html) pour voir des démos complètes de tous les contrôles !**

## 🖥️ Backends

AppCUI supporte plusieurs backends selon le système d’exploitation utilisé :

* **Console Windows** - basé sur l'API bas niveau Win32, conçu pour la console Windows classique
* **Windows VT** - basé sur les séquences ANSI, conçu pour les terminaux virtuels Windows modernes
* **NCurses** - basé sur l'API NCurses pour les environnements Linux
* **Termios** - basé sur les séquences ANSI et les API bas niveau pour MAC OSX
* **Terminal Web** - conçu pour une implémentation Web (basé sur webgl)
* **CrossTerm** - basé sur la crate `crossterm`, mais activé via un flag de fonctionnalité

Plus d'informations sur les backends supportés sont disponibles [ici](https://gdt050579.github.io/AppCUI-rs/chapter-2/backends.html)


## 🚀 Démarrage rapide

Ajoutez ce qui suit à votre `Cargo.toml` :

```toml
[dependencies]
appcui = "*"
```

Créez ensuite un nouveau projet Rust et ajoutez le code suivant :

```rust
use appcui::prelude::*;

fn main() -> Result<(), appcui::system::Error> {
    let mut app = App::new().build()?;
    let mut win = Window::new(
        "Test",
        LayoutBuilder::new().alignment(Alignment::Center).width(30).height(9).build(),
        window::Flags::Sizeable,
    );
    win.add(Label::new(
        "Hello World !",
        LayoutBuilder::new().alignment(Alignment::Center).width(13).height(1).build(),
    ));
    app.add_window(win);
    app.run();
    Ok(())
}
```

ou une version plus compacte utilisant des proc-macros :

```rs
use appcui::prelude::*;

fn main() -> Result<(), appcui::system::Error> {
    let mut app = App::new().build()?;
    let mut win = window!("Test,a:c,w:30,h:9");
    win.add(label!("'Hello World !',a:c,w:13,h:1"));
    app.add_window(win);
    app.run();
    Ok(())
}
```

Ensuite, lancez le projet avec `cargo run`. Vous devriez voir une fenêtre avec le titre `Test` et le texte `Hello World !` au centre.

## 🧪 Exemples

AppCUI-rs est livré avec un ensemble d'exemples pour vous aider à démarrer. Vous pouvez les trouver dans le dossier [examples](examples), comprenant :
- **Jeux** tels que [Tic Tac Toe](examples/tic-tac-toe/), [Snake](examples/snake/), [Flappy Bird](examples/flappy), [Démineur](examples/minesweeper/), [Ram it](examples/ramit/), [PacMan](examples/games/), [Chees](examples/games/), [Puissance 4](examples/games/), [2048](examples/games/) ou [Tetris](examples/games/)
- **Utilitaires** tels que [Calculatrice](examples/calculator/), [Visionneuse CSV](examples/csv_viewer/), [Convertisseur de température](examples/temperature_convertor/) ou un [Minuteur](examples/timer/)
- **Animations** telles que [Matrix](examples/matrix/), [Fractales](examples/fractals/) ou [Spirale](examples/spiral/)
- **Contrôles**/**Widgets** tels que [Bouton](examples/buttons/), [Case à cocher](examples/checkboxes/), [ComboBox](examples/combobox/), [Sélecteur de date](examples/datepicker/), [ListView](examples/listview/), [TreeView](examples/treeview/) et bien d'autres.
- **Dialogues** tels que [Notification](examples/notification_dialogs/) ou [Saisie](examples/input_dialog/)

## 🛠️ Un exemple plus complexe

Un exemple qui crée une fenêtre avec un bouton qui, lorsqu'il est pressé, augmente un compteur.

```rust
use appcui::prelude::*;

// Create a window that handles button events and has a counter
#[Window(events = ButtonEvents)]
struct CounterWindow {
    counter: i32
}

impl CounterWindow {
    fn new() -> Self {
        let mut w = Self {
            // set up the window title and position
            base: window!("'Counter window',a:c,w:30,h:5"),
            // initial counter is 1
            counter: 1            
        };
        // add a single button with the caption "1" (like the counter)
        w.add(button!("'1',d:b,w:20"));
        w
    }
}
impl ButtonEvents for CounterWindow {
    // When the button is pressed, this function will be called
    // with the handle of the button that was pressed
    // Since we only have one button, we don't need to store its handle 
    // in the struct, as we will receive the handle via the on_pressed method
    fn on_pressed(&mut self, handle: Handle<Button>) -> EventProcessStatus {
        // increase the counter
        self.counter += 1;
        // create a text that containe the new counter
        let text = format!("{}",self.counter);
        // aquire a mutable reference to the button using its handle
        if let Some(button) = self.control_mut(handle) {
            // set the caption of the button to th new text
            button.set_caption(&text);
        }
        // Tell the AppCUI framework that we have processed this event
        // This allows AppCUI to repaint the button
        EventProcessStatus::Processed
    }
}

fn main() -> Result<(), appcui::system::Error> {
    // create a new application
    let mut a = App::new().build()?;
    // add a new window (of type CounterWindow) to the application
    a.add_window(CounterWindow::new());
    // Run AppCUI framework (this wil start the window loop and messaage passing)
    a.run();
    Ok(())
}
```

## 🛣️ Feuille de route

- [x] Ensemble de widgets de base et prise en charge de Windows, Linux et MacOS
- [x] Support WebGL
- [ ] Support OpenGL / SDL / Vulkan
- [ ] Support TextArea pour la mise en surbrillance du code

## 🤝 Contribution

Les contributions, problèmes et demandes de fonctionnalités sont les bienvenus !  
Consultez [CONTRIBUTING.md](https://raw.githubusercontent.com/gdt050579/AppCUI-rs/main/CONTRIBUTING.md) pour commencer.

Rejoignez la discussion dans [GitHub Discussions](https://github.com/gdt050579/AppCUI-rs/discussions).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-08

---
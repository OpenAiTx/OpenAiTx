# gnome-randr-rust

Une réimplémentation de `xrandr` pour Gnome sous Wayland, spécialement pour les systèmes qui ne supportent pas `wlr-output-management-unstable-v1` (par exemple Manjaro). Écrit entièrement en Rust pour la performance et le plaisir. C’est aussi mon premier projet en Rust, donc toutes suggestions sont les bienvenues !

> [!NOTE]  
> Je ne peux actuellement pas maintenir ce projet, car je n’ai plus accès à une machine Linux fonctionnelle. Si quelqu’un est intéressé pour le maintenir, merci de me le faire savoir !
>
> Sur Gnome 48+, essayez le CLI [gdctl](https://gitlab.gnome.org/GNOME/mutter/-/blob/main/doc/man/gdctl.rst) qui l’accompagne, il est très probablement mis à jour régulièrement.

(Pour les compositeurs non-Gnome, voir les liens de configuration d’affichage sur https://arewewaylandyet.com/)

## Installation

L’installation nécessite `pkg-config` et `cargo`, faisant partie de la chaîne d’outils Rust. [Instructions d’installation de Cargo/Rust](https://doc.rust-lang.org/cargo/getting-started/installation.html).

Pour installer cet outil, lancez `cargo install gnome-randr`. Une bibliothèque est également exposée pour une utilisation dans d’autres programmes Rust.

## Méthode

`gnome-randr-rust` utilise l’objet `dbus` `org.gnome.Mutter.DisplayConfig`. Voir https://wiki.gnome.org/Initiatives/Wayland/Gaps/DisplayConfig pour la proposition originale, bien que la spécification listée soit un peu dépassée (vérifiée via `dbus introspect` sur Gnome shell 40.5). Gnome maintient le fichier XML évolutif [ici](https://gitlab.gnome.org/GNOME/mutter/-/blob/main/data/dbus-interfaces/org.gnome.Mutter.DisplayConfig.xml).

La méthode `GetCurrentState` est utilisée pour lister les informations sur les écrans, tandis que `ApplyMonitorsConfig` sert à modifier la configuration actuelle.

## Inspiration

Ce projet a été fortement inspiré par `xrandr` (évidemment) ainsi que par [`gnome-randr`](https://gitlab.com/Oschowa/gnome-randr/). Malheureusement, `gnome-randr.py` semble cassé avec ma version de Gnome (40.5) lorsqu’on essaie de modifier les configurations d’affichage.

`gnome-randr.py` est aussi plus lent que ma réimplémentation en Rust : interroger le script Python prend environ 30 ms sur mon système à 3 écrans, tandis que l’implémentation Rust prend environ 3 ms (`xrandr` prend environ 1,5 ms, mais affiche aussi des informations différentes en raison des limitations du pont `xrandr`).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-30

---
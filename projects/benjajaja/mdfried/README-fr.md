# mdfried

`mdfried` est un visualiseur markdown pour le terminal qui rend les en-têtes en **Texte Plus Gros** que le
reste.

## Captures d'écran

![Capture d'écran](https://raw.githubusercontent.com/benjajaja/mdfried/master/./assets/screenshot_1.png)

[Dernier tableau de captures d'écran de test depuis `master`](https://benjajaja.github.io/mdfried-screenshots/)

## Vidéo

https://github.com/user-attachments/assets/e69154a7-bea8-4e14-a677-be7ccf0d3cac

# Pourquoi ?

Vous pouvez *[cuisiner](https://ratatui.rs/)* un terminal. Mais pouvez-vous **frire profondément** un terminal ?
*OUI !* Vous pouvez **cuisiner *et* frire** votre `tty` ! ~~Courez avant qu'il ne soit trop tard !~~

> Le terminal est généralement en mode "cuit", ou mode canonique.
> Avec `ratatui`🐁, il est en mode brut, mais il "cuit" pour vous.

Le markdown peut évidemment être rendu assez bien dans les terminaux, mais un aspect clé manque : 
Les Gros En-têtes™ rendent le texte plus lisible, et afficher les images en ligne est très pratique.

# Comment ?

En rendant les en-têtes comme [images avec ratatui](https://github.com/benjajaja/ratatui-image),
et en utilisant l’un des plusieurs protocoles graphiques pour terminaux : Sixels, Kitty, ou iTerm2.
Le terminal Kitty implémente aussi un [protocole de redimensionnement de texte](https://sw.kovidgoyal.net/kitty/text-sizing-protocol/)
pour agrandir directement le texte sans avoir besoin de le rendre en images !

Voir [ratatui-image](https://github.com/benjajaja/ratatui-image?tab=readme-ov-file#compatibility-matrix)
pour vérifier si votre terminal supporte les graphiques, et pour plus de détails.

En général, Kitty, WezTerm, iTerm2, Ghostty, Foot, `xterm -ti vt340`, *devraient* fonctionner.

Sur les terminaux sans aucun support graphique, comme Alacritty, les images sont rendues avec Chafa.

# Installation

* Rust cargo : `cargo install mdfried`
  * Depuis la source : `cargo install --path .`
  * Nécessite un paquet chafa avec les en-têtes de développement, généralement appelé quelque chose comme `libchafa-dev`, `libchafa-devel`, ou simplement `libchafa`, voire juste `chafa`.
  * Si chafa n’est pas du tout disponible, ou si cela ne vous importe pas car votre terminal supporte un protocole graphique, utilisez alors `--no-default-features`.
  * Si `cargo install ...` échoue, essayez avec `--locked`, et/ou signalez un problème.
* Nix flake : `github:benjajaja/mdfried`
* Nixpkgs : [`mdfried`](https://search.nixos.org/packages?channel=unstable&query=mdfried)
* Arch Linux : `pacman -S mdfried` ([dépôt extra](https://archlinux.org/packages/extra/x86_64/mdfried/))
* Ubuntu : [Télécharger le .deb de la version](https://github.com/benjajaja/mdfried/releases/latest)
* Mac : `brew install mdfried` ou [binaires de la version](https://github.com/benjajaja/mdfried/releases/latest)
* Windows : [Télécharger le .exe de la version](https://github.com/benjajaja/mdfried/releases/latest)

# Utilisation

### Exécution

```
mdfried ./path/to.md
```

À moins que vous n'utilisiez Kitty version 0.40 ou supérieure, ou un terminal qui ne supporte aucun protocole graphique,
la première fois que vous lancez `mdfried`, vous devrez choisir une police.
Vous devriez choisir la même police que celle utilisée par votre terminal, mais vous pouvez en choisir une autre.
L'écran de configuration de la police vous permet de rechercher les polices du système - vous voudrez choisir la même police que
celle utilisée par votre terminal.
La police est rendue directement en aperçu.
Une fois confirmée, le choix est enregistré dans le fichier de configuration.

Utilisez `--setup` pour forcer à nouveau la configuration de la police si elle n'est pas correcte.

Vous pouvez également lui passer du markdown en pipe :

```
readable https://lobste.rs | markdownify | mdfried
```

### Raccourcis clavier

Touche | Description
-------|-------------
`q` ou `Ctrl-c` | Quitter et laisser le contenu dans le terminal
`r` | Recharger le fichier (sauf si entrée standard redirigée)
`j` | Descendre d’une ligne
`k` | Monter d’une ligne
`d` ou `Ctrl-d` | Descendre d’une demi-page
`u` ou `Ctrl-u` | Monter d’une demi-page
`f` ou `PageDown` ou `Espace` | Descendre d’une page
`b` ou `PageUp` | Monter d’une page
`g` | Aller au début du fichier
`G` | Aller à la fin du fichier
`<nombre>G` ou `<nombre>g` | Aller à la ligne #\<nombre>
`/` | Rechercher du texte
`n` | Aller à la correspondance ou lien suivant
`N` | Aller à la correspondance ou lien précédent
`Entrée` | Ouvrir le lien sélectionné avec `xdg-open`
`Échap` | Quitter les modes recherche ou lien

Entrer un nombre avant un déplacement applique ce déplacement autant de fois.

Le défilement avec la souris ne fonctionne que si activé dans les paramètres avec `enable_mouse_capture = true`, mais alors vous ne pouvez pas
sélectionner de texte.

### Configuration

`~/.config/mdfried/config.toml` est créé automatiquement au premier lancement.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-18

---
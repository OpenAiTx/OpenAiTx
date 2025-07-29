# i3-quickterm

[![Statut du packaging](https://repology.org/badge/vertical-allrepos/python:i3-quickterm.svg)](https://repology.org/project/python:i3-quickterm/versions)

Un petit terminal déroulant pour [i3wm](https://i3wm.org/) et [sway](https://swaywm.org/)

## Fonctionnalités

* utilisez votre émulateur de terminal préféré
* possibilité de sélectionner un shell avec [dmenu](http://tools.suckless.org/dmenu/) / [rofi](https://github.com/DaveDavenport/rofi)
* s’adapte à la largeur de l’écran
* compatible multi-écrans

## Installation

Via pip:

```
pip install i3-quickterm
```

Ou vérifiez le badge repology ci-dessus pour voir s'il est empaqueté par votre distribution.

## Utilisation

Lorsqu'il est lancé, il minimisera le quickterm sur l'écran actuel s'il y en a un. Sinon, il invitera l'utilisateur à choisir le shell à ouvrir ou utilisera celui fourni en argument.

Si le shell demandé est déjà ouvert sur un autre écran, il sera déplacé sur l'écran actuel.

Il est recommandé de le mapper à une liaison i3 :

```
# with prompt
bindsym $mod+p exec i3-quickterm
# always bring up standard shell, without the menu
bindsym $mod+b exec i3-quickterm shell
```

## Configuration

La configuration est lue depuis `~/.config/i3-quickterm/config.json` ou `~/.config/i3/i3-quickterm.json`.

* `menu` : l'application compatible dmenu utilisée pour sélectionner le shell
* `term` : l'émulateur de terminal choisi
* `history` : un fichier pour sauvegarder l'ordre des shells utilisés en dernier, l'ordre des derniers utilisés est désactivé si défini à null
* `width` : le pourcentage de la largeur de l'écran à utiliser
* `height` : le pourcentage de la hauteur de l'écran à utiliser
* `pos` : où faire apparaître le terminal (`top` ou `bottom`)
* `shells` : shells enregistrés (`{ name: command }`)

`term` peut être soit :
- le nom d'un terminal de la [liste supportée](#supported-terminals).
- `auto` pour sélectionner le premier terminal existant de la liste ci-dessus (uniquement pour fournir des valeurs par défaut plus conviviales, non recommandé autrement)
- une chaîne de format, comme celle-ci : `urxvt -t {title} -e {expanded}` avec le format d'arguments correct de votre terminal. Certains terminaux, comme xfce4-terminal, nécessitent que l'argument commande soit passé en tant que chaîne. Dans ce cas, remplacez `{expanded}` par `{string}`

`menu`, `term`, `history` et `shell` peuvent contenir des espaces réservés pour les variables d'environnement : `{$var}`.

Les clés non spécifiées sont héritées des valeurs par défaut :

```
{
    "menu": "rofi -dmenu -p 'quickterm: ' -no-custom -auto-select",
    "term": "auto",
    "history": "{$HOME}/.cache/i3-quickterm/shells.order",
    "width": 1.0,
    "height": 0.25,
    "pos": "top",
    "shells": {
        "js": "node",
        "python": "ipython3 --no-banner",
        "shell": "{$SHELL}"
    }
}
```

## Terminaux pris en charge

* alacritty
* foot
* gnome-terminal
* kitty
* roxterm
* st
* terminator
* termite
* urxvt
* urxvtc
* xfce4-terminal
* xterm

Si vous souhaitez ajouter un autre terminal (ou corriger une erreur), veuillez ouvrir une demande de fusion.

## Exigences

* python >= 3.8
* i3 >= v3.11 ou sway >= 1.2
* [i3ipc-python](https://i3ipc-python.readthedocs.io/en/latest/) >= v2.0.1
* dmenu ou rofi (optionnel)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---
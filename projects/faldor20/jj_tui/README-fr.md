# Jujutsu TUI
[![nix](https://github.com/faldor20/jj_tui/actions/workflows/build-nix.yml/badge.svg)](https://github.com/faldor20/jj_tui/actions/workflows/build-nix.yml)

Une interface TUI pour le système de contrôle de version Jujutsu
Notre objectif ici est :
- **Performance** : jj_tui doit démarrer rapidement et ne jamais vous ralentir, il doit être extrêmement réactif pour parcourir vos commits et fichiers
- **Intuitif** : Les raccourcis clavier doivent être facilement mémorisables et rapides à intégrer dans la mémoire musculaire sans popups inutiles
- **Interactivité** : jj_tui réimplémente complètement le moteur de rendu de jj pour pouvoir afficher des aperçus en temps réel du graphe pendant que vous décidez à quoi doit ressembler votre rebase ( Utilisez `r`ebase `p`review pour l’essayer !)

![jj_tui-ezgif com-optimize](https://github.com/faldor20/jj_tui/assets/26968035/fb053320-484a-4d6f-9b66-e5b9d0d49e5d)


Appuyez sur `?` pour afficher l’aide. (les commandes diffèrent entre la vue graphe et la vue fichiers).
`Flèches` ou `hjkl` pour naviguer dans les fenêtres/éléments
`Espace` pour sélectionner/désélectionner des révisions (sélection multiple dans la vue graphe)
`Entrée` pour élargir le diff et faire défiler son contenu

## Fonctionnalités clés

### Opérations jj normales
- `c`ommiter
- `r`ebaser
- `g`it push et pull
- Ajouter, déplacer et supprimer des `m`arque-pages (`b`ookmarks)
- `s`quasher et `s`éparer les commits
- `espace` peut être utilisé pour sélectionner plusieurs commits pour copier, rebaser, etc., ou commencer un `n`ouveau commit au-dessus, etc.

### Création de commits depuis la vue fichiers :
- `espace` peut être utilisé pour sélectionner des fichiers à `c`ommiter séparément ou à `d`éplacer vers un commit différent
- Les fichiers peuvent être envoyés vers les commits `S`uivant ou `P`récédent

### Filtrage par revsets
- `f`iltrer par n’importe quel revset que vous souhaitez

Liste des commandes pour le graphe :

![jj_tui commands](https://github.com/user-attachments/assets/1e446a3d-1736-4207-b311-29d8e4bdc333)

## Installation
`linux` : Récupérez la dernière version. Elle est liée statiquement et devrait fonctionner sur n’importe quelle machine Linux.
`mac` : Prenez une version précompilée. Faites-moi savoir si vous rencontrez des problèmes car je ne peux pas tester sur un Mac.

Pour ouvrir un shell avec jj_tui sur nix : `nix shell github:faldor20/jj_tui`

## Dépendances
Le CLI jujutsu (version minimale 0.30.0)
Je n'ai pas testé sous Windows ou Mac.
Je pense que cela ne fonctionnera pas en dehors d'Unix, donc les utilisateurs Windows devront actuellement utiliser wsl.

# Fichier de configuration :
Vous pouvez créer un fichier de configuration `config.yaml` dans les répertoires suivants pour personnaliser les entrées clavier
`linux` : $XDG_CONFIG_HOME/jj_tui/
`macos` : ~/Library/preferences/jj_tui/
Voir `./jj_tui/lib/key_map.ml` pour une spécification du keymap et `./jj_tui/lib/config.ml` pour la configuration
La configuration du keymap vous permet de personnaliser entièrement toutes les commandes et leurs sous-menus ainsi que de remapper les touches fléchées.

Exemple :

``` yaml
key_map:
  remap:
   h: "left"
   j: "down"
   k: "up"
   l: "right"
  graph:
    #Simple mapping from key to command_id
    p: prev
    #Command sub menu
    s:
      title: "Squash"
      sub:
        # sub menu command
        s: "squash_into_parent"
# If the terminal is smaller than this width, the UI will change to a single pane view
single_pane_width_threshold: 110
# Sets the limit to how many commits are ever rendered in jj_tui. Usefull for not slowing down too much when viewing 'all()' revest.
max_commits: 100
```
Pour une liste complète des identifiants de commandes, voir [`jj_tui/bin/graph_commands.ml`](https://raw.githubusercontent.com/faldor20/jj_tui/main/jj_tui/bin/graph_commands.ml) et [`jj_tui/bin/file_commands.ml`](https://raw.githubusercontent.com/faldor20/jj_tui/main/jj_tui/bin/file_commands.ml)

# journaux :
`linux` : $XDG_STATE_HOME/jj_tui/
`macos` : ~/Library/logs/jj_tui/

# Dev
Peut être construit avec nix `nix build` ou ouvrir un shell nix avec `nix develop`
REMARQUE : si vous utilisez le shell dev nix et souhaitez construire avec dune, utilisez `dune build --pkg disabled` pour construire en utilisant les dépendances fournies par nix
Peut aussi être construit directement avec la gestion de paquets Dune via `dune build`.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-23

---
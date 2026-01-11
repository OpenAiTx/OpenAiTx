# STAnd aLONE TRAY [![Build][badge-build]][yaml-build] [![Lint][badge-lint]][yaml-lint]

[badge-build]: https://github.com/d3adb5/stalonetray/actions/workflows/build.yml/badge.svg
[yaml-build]: https://github.com/d3adb5/stalonetray/actions/workflows/build.yml
[badge-lint]: https://github.com/d3adb5/stalonetray/actions/workflows/lint.yml/badge.svg
[yaml-lint]: https://github.com/d3adb5/stalonetray/actions/workflows/lint.yml

Stalonetray est un STAnd-aLONE system TRAY (zone de notification) pour les bureaux Unix
utilisant le système de fenêtrage X11. Il a des dépendances minimales par défaut à la compilation et à l'exécution :
Xlib et libXinerama, bien que vous puissiez vous passer de ce dernier
en désactivant une fonctionnalité pour encore plus de minimalisme. Stalonetray fonctionne sous
virtuellement n'importe quel gestionnaire de fenêtres.

Pour commencer à utiliser stalonetray, copiez simplement `stalonetrayrc.sample` dans
`~/.stalonetrayrc` ou dans `$XDG_CONFIG_HOME/stalonetrayrc`. Il est bien commenté
et devrait suffire pour un démarrage rapide.

Notez que certaines fonctionnalités sont désactivées par défaut et peuvent ne pas fonctionner
immédiatement, selon la façon dont stalonetray a été compilé par le mainteneur du paquet. Voir la
section "Compilation depuis la source" ci-dessous si vous souhaitez le compiler vous-même avec
les fonctionnalités dont vous avez besoin.

## État de la maintenance

Ce projet a été initialement développé par [Roman Dubtsov (kolbusa)][gh-kolbusa]
et a récemment changé de main. Roman est toujours impliqué, mais ne maintient plus
activement le projet.

**Tout le mérite lui revient pour avoir créé et maintenu ce projet pendant de nombreuses
années. Merci, Roman !**

[gh-kolbusa]: https://github.com/kolbusa

## Installation

Les gestionnaires de paquets sont le moyen le plus pratique d’installer stalonetray. Il est
packagé pour plusieurs distributions Linux et variantes BSD. Sur Debian et
Ubuntu, exécutez :

```sh
sudo apt install stalonetray
```

Sur Fedora, exécutez :

```sh
sudo dnf install stalonetray
```

## Compilation à partir des sources

Stalonetray utilise [Meson](https://mesonbuild.com/). Consultez le fichier `meson.options`
pour les options de compilation disponibles et leurs valeurs par défaut.

Pour compiler stalonetray avec Meson, assurez-vous que les dépendances nécessaires sont installées
--- par défaut, seuls les paquets de développement Xlib et libXinerama sont requis ---
et lancez les commandes de compilation standard de Meson :

```sh
meson setup builddir
meson compile -C builddir stalonetray
```

Cela devrait construire le binaire `stalonetray` dans le répertoire `builddir`.

Pour construire la documentation de stalonetray, vous aurez besoin d’installer d’abord `xsltproc` et les feuilles de style DocBook. Ensuite, construisez la cible `manpage` :


```sh
meson compile -C builddir manpage
```

Cela crée le fichier `stalonetray.1` dans le répertoire `builddir`.

L'installation à partir des sources peut être effectuée avec :

```sh
meson install -C builddir
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-11

---
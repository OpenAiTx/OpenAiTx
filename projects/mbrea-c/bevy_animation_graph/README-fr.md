_Crate bibliothèque :_
[![Crates.io](https://img.shields.io/crates/v/bevy_animation_graph)](https://crates.io/crates/bevy_animation_graph)
[![Crates.io](https://img.shields.io/crates/d/bevy_animation_graph)](https://crates.io/crates/bevy_animation_graph)

_Crate éditeur :_
[![Crates.io](https://img.shields.io/crates/v/bevy_animation_graph_editor)](https://crates.io/crates/bevy_animation_graph_editor)
[![Crates.io](https://img.shields.io/crates/d/bevy_animation_graph_editor)](https://crates.io/crates/bevy_animation_graph_editor)

[![CI](https://github.com/mbrea-c/bevy_animation_graph/actions/workflows/ci.yaml/badge.svg)](https://github.com/mbrea-c/bevy_animation_graph/actions/workflows/ci.yaml)

# Bevy Animation Graph

> **_AVIS :_** Si vous utilisez actuellement la version `0.8.0` ou inférieure, notez que
> la version `0.9.0` a introduit plusieurs changements incompatibles. Consultez le
> [guide de migration](https://mbrea-c.github.io/bevy_animation_graph/migration_guides/0.8_to_0.9.html)
> pour la mise à jour.

## Motivation

Les graphes d'animation sont un outil essentiel pour gérer la complexité présente dans
les pipelines d'animation des jeux 3D modernes. Lorsque votre jeu comporte des dizaines de
animations avec des fondus et transitions complexes, ou que vous souhaitez générer vos
animations de manière procédurale à partir de très peu d'images clés, la simple lecture
de clips d'animation ne suffit pas.

Ce crate fonctionne comme une alternative à la plupart de `bevy_animation`, et vise à
fournir un système d'animation complet et un flux de travail de développement incluant des graphes
d'animation, des machines d'état d'animation (c'est-à-dire des contrôleurs d'animation) et un éditeur
graphique pour créer vos graphes d'animation et machines d'état.

_NOTE : Ce projet est distinct des graphes d'animation introduits dans
`bevy_animation` à la version 0.14._

![capture d'écran d'exemple d'utilisation](https://raw.githubusercontent.com/mbrea-c/bevy_animation_graph/master/locomotion_graph.png)

## Fonctionnalités actuelles

- Les graphes d'animation sont des assets. Ils peuvent être chargés à partir de fichiers asset, ou créés
  en code avec une API ergonomique.
- Éditeur graphique de graphes.
- Machines à états d’animation :
  - Les machines à états d’animation sont intégrées en tant que nœuds dans les graphes d’animation.
  - Chaque état dans une machine d’états joue son propre graphe d’animation à la demande.
  - Les transitions ont également leur propre graphe d’animation, et elles peuvent interroger les graphes d’animation des états source
    et cible.
- Support du ragdoll :
  - Édition visuelle de ragdoll dans l’éditeur.
  - Support des _ragdolls partiels_, où certains os sont simulés et d’autres
    sont animés cinématiquement par une pose d’animation cible.
- Support pour les nœuds personnalisés écrits en Rust.
  - Les utilisateurs peuvent créer leur propre binaire d’éditeur en ajoutant le plugin de l’éditeur et
    en enregistrant leurs nœuds personnalisés supplémentaires dans le registre de types Bevy. L’éditeur
    détectera automatiquement tous les nœuds enregistrés.
- Les nœuds intégrés disponibles incluent :
  - Chaînage d’animation (c’est-à-dire jouer un nœud après un autre).
  - Cinématique inverse à deux os.
  - Bouclage.
  - Fusion linéaire (dans l’espace osseux).
  - Nœud d’espace de fusion 2D.
  - Miroir d’animation autour du plan YZ.
  - Lecture de clip d’animation.
  - Application d’une rotation donnée à certains os dans une pose en utilisant un masque osseux.
  - Accélérer ou ralentir la lecture de l’animation.
  - Nœud de graphe d’animation.
  - Nœud de machine à états d’animation.
  - Nœuds arithmétiques : une variété d’opérations courantes sur f32, Vec3, Quat, etc.
- Imbrication des graphes d’animation comme nœuds dans d’autres graphes.
- Synchronisation d’animation utilisant des pistes d’événements.
- La sortie des nœuds du graphe est mise en cache pour éviter des calculs inutiles.

## Fonctionnalités prévues

1. Modes de « suivi de pose » ragdoll, où les os du ragdoll simulé tentent de correspondre
   à une pose cible en utilisant des forces physiques :
   - Mode de correspondance _absolue_, où la position/rotation dans l’espace mondial de l’os
     cible est suivie et utilisée comme ancrage pour une force de ressort sur l’os du ragdoll.
   - Mode de correspondance _relative_, où l’os du ragdoll tente de correspondre à la
     position/rotation de la cible relative à son os parent. Nous pourrions avoir besoin du support des moteurs d’articulation sur Avian pour implémenter ce mode correctement.



## Installation

### Bibliothèque

[bevy_animation_graph](https://crates.io/crates/bevy_animation_graph) est la
partie bibliothèque de ce projet. Elle doit être ajoutée comme dépendance à votre
projet afin d’utiliser les graphes d’animation. Pour installer la dernière version publiée
depuis crates.io, exécutez

```bash
cargo add bevy_animation_graph
```
ou ajoutez manuellement la dernière version à votre `Cargo.toml`.

Pour installer la dernière version git master, ajoutez ce qui suit à `Cargo.toml` :


```toml
# ...
[dependencies]
# ...
bevy_animation_graph = { git = "https://github.com/mbrea-c/bevy_animation_graph.git" }
# ...
```

### Éditeur

[bevy_animation_graph_editor](https://crates.io/crates/bevy_animation_graph_editor)
est l'éditeur. Vous pouvez l'installer comme vous installeriez n'importe quel autre binaire Rust :

```bash
# for the latest crates.io version
cargo install bevy_animation_graph_editor
# for the latest master
cargo install --git https://github.com/mbrea-c/bevy_animation_graph bevy_animation_graph_editor
# for the version from a local workspace
cargo install --path <PATH_TO_WORKSPACE> bevy_animation_graph_editor

# use the --force flag to force reinstall
```

Alternativement, je recommande de jeter un coup d'œil à
[l’éditeur en tant qu’exemple de plugin](https://github.com/mbrea-c/bevy_animation_graph/blob/master/examples/editor_as_a_plugin/examples/editor_as_a_plugin.rs)
afin de configurer votre propre binaire d’éditeur dans votre crate/espace de travail, utilisant
la même version de la bibliothèque que votre jeu. Cela vous permettra d’enregistrer des
nœuds personnalisés pour le graphe d’animation, qui sont une fonctionnalité puissante de ce crate.

## Pour commencer

Consultez les tutoriels dans le
[livre en cours de rédaction](https://sarahihme.github.io/initial_book_bevy_animation_graph/)
(merci beaucoup à @SarahIhme pour avoir lancé cela !).

Des exemples supplémentaires et à jour sont inclus dans le
[répertoire examples](https://github.com/mbrea-c/bevy_animation_graph/tree/master/examples).

Les ressources suivantes peuvent également être utiles, mais elles sont quelque peu dépassées :

- La documentation sur [docs.rs](https://docs.rs/bevy_animation_graph) contient
  une introduction à la bibliothèque et à l’éditeur ainsi qu’une explication d’un exemple simple
  de graphe d’animation. Voir aussi la vidéo ci-dessous pour une démonstration de
  l’utilisation de l’éditeur.
- Il existe une
  [vidéo de présentation d’utilisation](https://www.youtube.com/watch?v=q-JBSQJIcX0) un peu datée.

## Contribution ou aide

Si vous rencontrez un bug ou souhaitez discuter de nouvelles fonctionnalités potentielles, n’hésitez pas à
poster un problème, ouvrir une PR ou me contacter sur Discord (@mbreac dans le Discord Bevy,
il y a un post d’aide crate pour `bevy_animation_graph` là-bas :
[lien](https://discord.com/channels/691052431525675048/1202998277482479616)).

## FAQ

### Est-ce prêt pour la production ?

Cela dépend.

Cela peut déjà être utile pour des projets de petite taille, mais je ne peux pas garantir l’API

stabilité entre différentes versions `0.x` (c'est une grosse bibliothèque, elle est
relativement jeune et je n'ai pas d'expérience préalable en programmation
d'animation, donc je suis encore en train de trouver les meilleures façons de faire). Cela
signifie qu'il sera probablement nécessaire de modifier manuellement vos actifs de graphe d'animation
et de les migrer entre les versions, au moins jusqu'à ce que je trouve une meilleure manière
de gérer les migrations.

De plus, il y aura des bugs et d'autres problèmes. J'essaie de les
corriger au fur et à mesure qu'ils apparaissent.

### Allez-vous implémenter la fonctionnalité X ?

Si c'est une petite fonctionnalité (par exemple un nœud supplémentaire pour l'arithmétique
vectorielle ou à virgule flottante), il est probable que je ne l'ai tout simplement pas encore faite. Si vous ouvrez
un ticket, je l'implémenterai probablement rapidement. Les PR sont également les bienvenues.

Pour les fonctionnalités plus importantes, il est préférable de commencer par ouvrir un ticket pour en discuter ou
de me contacter sur le discord de Bevy.

## Tableau des versions

| `bevy` | `bevy_animation_graph` | 
| ------ | ---------------------- | 
| 0.18 | master | 
| 0.18 | 0.10 | 
| 0.17 | 0.9 | 
| 0.17 | 0.8 | 
| 0.16 | 0.7 | 
| 0.15 | 0.6 | 
| 0.14 | 0.5 | 
| 0.13 | 0.4 | 
| 0.13 | 0.3 | 
| 0.12 | 0.2 |

## Remerciements

Un grand merci à [Bobby Anguelov](https://www.youtube.com/@BobbyAnguelov) pour ses
cours sur la programmation d'animation.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-13

---
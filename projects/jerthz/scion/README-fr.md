<img src="https://raw.githubusercontent.com/jerthz/scion/main/banner.png" alt="Scion" />

Scion est une bibliothèque de jeux 2D réalisée en Rust.

> Veuillez noter que ce projet en est à ses premières étapes et est susceptible de changer en fonction des besoins de commodité et des grandes fonctionnalités à venir.
> 
> Vous pouvez utiliser Scion comme bon vous semble, bien que je l’aie rendu open source pour servir la communauté et non pour être un concurrent de l’écosystème actuel des moteurs de jeu Rust.

## Pourquoi ce projet ? 
Eh bien, d’abord parce que c’est un bon moyen d’apprendre les différents aspects du développement de jeux en coulisses. 
Ensuite, parce que je voulais créer quelque chose avec des objectifs modestes, axé sur la facilité d’utilisation et une courte liste de principes servant aussi de guide.

Scion n’est pas « inspiré » par un autre moteur, il est inspiré par les besoins des vrais projets de jeu. Cela signifie que je n’implémente pas une fonctionnalité juste parce que je l’ai vue ailleurs, mais parce que j’en ai besoin pour le prochain projet utilisant Scion.

### Objectifs
- Focalisation forte uniquement sur le **2D**.
- **Facile** et **Amusant** à utiliser. 
- Code source propre et lisible (au moins nous essaierons de réécrire si nécessaire)
- Sans éditeur, c’est une bibliothèque et doit toujours le rester

### Non objectifs
- Code et performances ultra/sur-optimisés. Pour cela, essayez d’autres moteurs ou créez le vôtre !
- 3D

## Documentations, tutoriels ?
Oui, ils sont prévus et en cours de réalisation. Si vous voulez voir Scion en action, consultez pour l’instant les exemples.

## Pourquoi ECS ?
Aujourd’hui, ECS est comme un mot « magique » pour les jeux, bibliothèques de jeux et moteurs de jeu. Mais ECS n’est pas et ne doit pas être considéré comme une réponse universelle à plusieurs questions.
Je crois que l’ECS a ses forces et ses faiblesses. 
Le choix ici est fait parce que les jeux cibles principaux de cette lib au départ étaient de pouvoir réaliser : 
- un jeu de construction de ville complexe.
- un jeu fan de pkmn avec progression du dresseur en temps réel et pkmn sauvages.
- représentation granulaire des paquets réseau && jeux de simulation de points.

## Dépendances notables
Voici les dépendances sur lesquelles ce projet s’appuie. Grâce à ces communautés formidables, nous pouvons construire ce genre de petits projets.

- <a href="https://github.com/rust-windowing/winit" target="blank">winit</a> et <a href="https://github.com/gfx-rs/wgpu/tree/master/wgpu" target="blank">wgpu</a> (fenêtrage et rendu multi-backend)
- <a href="https://github.com/Ralith/hecs" target="blank">hecs</a> (système entité-composant)
- <a href="https://github.com/termhn/ultraviolet" target="blank">ultraviolet</a> (Mathématiques)

## Pré-requis
Pour construire Scion, vous devez installer les paquets requis pour votre système : 
### Debian, Ubuntu, PopOS...
```sh
sudo apt install gcc cmake build-essential libx11-dev libxi-dev libgl1-mesa-dev libasound2-dev
```

### Fedora
```sh
sudo dnf install gcc cmake make automake gcc gcc-c++ kernel-devel libX11-devel libXi-devel mesa-libGL-devel alsa-lib-devel
```
### Arch, Manjaro...

```sh
sudo pacman -S gcc cmake make automake linux-headers libx11 libxi mesa alsa-lib
```

### Exécuter un exemple
Ensuite, vous pouvez exécuter un exemple :
```sh
cargo run --example bomberman --release
```

## Vitrine

| <img src="https://raw.githubusercontent.com/jerthz/scion/main/./examples/taquin/taquin_2.gif" alt="Taquin" style="width:300px; border: 2px solid black;"/>  | <img src="https://raw.githubusercontent.com/jerthz/scion/main/./examples/tetris/tetris.gif" alt="Tetris" style="width:300px" />             | <img src="https://raw.githubusercontent.com/jerthz/scion/main/./examples/pixel-adventures/pixel-adventures.gif" alt="Pixel-aventures" style="width:300px" /> |
|---------------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------|
| <img src="https://raw.githubusercontent.com/jerthz/scion/main/./examples/bomberman/bomberman.gif" alt="Bomberman" style="width:300px" />                    | <img src="https://raw.githubusercontent.com/jerthz/scion/main/./examples/jezzball/jezzball.gif" alt="Jezzball" style="width:300px" />       | <img src="https://raw.githubusercontent.com/jerthz/scion/main/./examples/new-bark-town/new-bark-town.gif" alt="New bark town" style="width:300px" />          |
| <img src="https://raw.githubusercontent.com/jerthz/scion/main/./examples/starlight-1961/starlight.gif" alt="Starlight" style="width:300px" />               | <img src="https://raw.githubusercontent.com/jerthz/scion/main/./examples/klondike.gif" alt="Starlight" style="width:300px" /> | |



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-03

---
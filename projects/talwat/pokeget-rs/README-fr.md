# pokeget-rs

Une meilleure version Rust de pokeget.

## Utilisation

`pokeget <pokemon>`

Pour plus d'infos, lancez `pokeget --help`.

## État du projet

J'ai décidé que, bien que je continuerai à corriger les bugs, etc.,
aucun sprite supplémentaire ne sera ajouté ou modifié sauf en cas de problème
sérieux. Ceci parce que premièrement, Pokémon s'éloigne des sprites
en pixels, et deuxièmement, que pokesprite a cessé ses mises à jour et une
alternative appropriée n'a pas été trouvée.

### .bashrc

Si vous utilisez pokeget au démarrage du shell, comme dans `.bashrc`,
alors au lieu de lancer `pokeget <pokemon>`, vous pouvez écrire la sortie
dans un fichier en faisant : `pokeget <pokemon> > file.txt`
puis faire quelque chose comme `cat file.txt` dans votre bashrc.

Cela rend l'initialisation de votre shell pratiquement instantanée, mais évidemment
cela ne fonctionnera pas avec des Pokémon aléatoires. pokeget est déjà assez rapide,
donc l'utiliser à l'initialisation du shell n'est pas non plus un gros goulot d'étranglement.

### Exemples

#### Utilisation de plusieurs Pokémon

`pokeget bulbizarre pikachu aléatoire`

#### Utilisation des ID du Pokédex

`pokeget 1 2 3`

#### Utilisation des formes alternatives

`pokeget raichu sandslash meowth --alolan`

#### Utilisation des régions

`pokeget kanto`

## Installation

### Cargo *(recommandé)*

La méthode d'installation recommandée est d'utiliser cargo :

```sh
cargo install pokeget
```

and making sure `$HOME/.cargo/bin` is added to `$PATH`.

### AUR

If you're on Arch, you can also use the AUR:

```sh
yay -S pokeget
```

### Git

You can also clone the repository and compile manually by doing:

```sh
git clone --recurse-submodules https://github.com/talwat/pokeget-rs.git
cd pokeget-rs
cargo build --release
mv target/release/pokeget ~/.local/bin
```

et en s'assurant que `$HOME/.local/bin` est ajouté à `$PATH`.

### Ajouter un répertoire à $PATH

#### Bash & Zsh

Ajoutez ceci à votre `.bashrc` ou `.zshrc` :

```sh
export PATH="<path>:$PATH"
```

#### Poisson

Exécutez ceci dans votre CLI :

```sh
fish_add_path <path>
```

## Mise à jour

Il suffit de relancer `cargo install pokeget` ou `git pull` dans le dépôt puis de recompiler.

## Pourquoi ?

Parce que le premier pokeget était lent, gonflé et super compliqué, j'ai donc décidé de faire une meilleure version en rust.

Maintenant, au lieu de pré-calculer tous les sprites et de les uploader dans un repo, pokeget pourra
les calculer à la demande ce qui rend tout beaucoup plus flexible.
Rust permet que ce calcul soit fait beaucoup plus rapidement que quelque chose comme python.

Il dessinera également les sprites deux fois plus petits en utilisant des demi-carrés.

## Qu’en est-il des autres projets ?

pokeget-rs a un avantage sur des projets comme l’ancien pokeget, pokeshell, etc... puisqu’il est en rust.
Il est aussi significativement (5.5x) plus rapide que krabby, un autre projet très similaire.

Pour plus d’infos, consultez [OTHER_PROJECTS.md](https://raw.githubusercontent.com/talwat/pokeget-rs/main/OTHER_PROJECTS.md).

## Qu’en est-il des gros sprites ?

Disparus. Réduits à des atomes.

Plus sérieusement, j’ai juste décidé de ne pas m’en occuper car c’est un travail supplémentaire significatif
que je ne veux pas gérer. Ils étaient rarement utilisés et avaient un aspect moche
dans les petites fenêtres de terminal, donc il y avait peu d’intérêt à les garder.

## Crédits

Cette fois, les sprites viennent de [pokesprite](https://github.com/msikma/pokesprite) et pokeget les utilise via un sous-module git.

Les sprites sont intégrés dans le binaire, donc pokeget ne les télécharge pas. C’est un bon compromis,
car bien que le binaire puisse être volumineux, pokeget peut s’exécuter presque instantanément et hors ligne.

## Licence

pokeget utilise la licence MIT, donc n’hésitez pas à le forker et le personnaliser comme bon vous semble.
Si vous avez des doutes sur le fonctionnement interne de pokeget, [ouvrez une issue](https://github.com/talwat/pokeget-rs/issues),  
et je répondrai à toutes les questions que vous pourriez avoir.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-19

---
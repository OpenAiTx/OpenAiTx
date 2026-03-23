# Marsdev

Chaîne d'outils multiplateforme Sega Mega Drive / Super 32X / Sharp X68000.

Anglais | [日本語](https://raw.githubusercontent.com/andwn/marsdev/master/README-ja.md)


## Compiler & Installer

### 1.1 Dépendances

Installez les paquets suivants, selon votre système d'exploitation :
  * Debian : `apt install build-essential texinfo wget`
  * RedHat : `yum install gcc gcc-c++ texinfo-tex wget`
  * Arch : `pacman -S base-devel texinfo wget`
  * Gentoo : `emerge sys-apps/texinfo net-misc/wget`
  * macOS : `xcode-select --install && brew install wget`


### 2. Chaîne d'outils GCC

Clonez le dépôt :
 - `git clone https://github.com/andwn/marsdev --recurse-submodules`
 - `cd marsdev`

---
**NOTE**

Il y a deux variables qui contrôlent où Marsdev est construit et installé :
 - `MARS_BUILD_DIR` = (REPOSITORY_ROOT)/mars
 - `MARS_INSTALL_DIR` = /opt/toolchains/mars

Si vous souhaitez changer l'emplacement de l'un ou l'autre, utilisez une commande export comme celle-ci :
 - `export MARS_INSTALL_DIR=/path/to/mars`

Si vous oubliez `--recurse-submodules` alors exécutez :
 - `git submodule init && git submodule update`

De plus, il est **fortement recommandé** d'utiliser quelque chose comme `-j8`, en remplaçant le 8 par
le nombre de cœurs CPU que vous avez. J'ai rencontré des problèmes étranges inexpliqués avec `-j`
par lui-même, veuillez donc spécifier un numéro.

---

Vous avez 2 options pour construire GCC :
 - `make m68k-toolchain` - Sans Newlib
 - `make m68k-toolchain-newlib` - Avec Newlib

Pour le 32X, la chaîne d'outils `sh` doit également être construite.
Les options sont les mêmes, en remplaçant `m68k` par `sh` dans les commandes ci-dessus.

Si vous souhaitez une version différente de GCC, ou construire des langages spécifiques :
 - `make m68k-toolchain-newlib GCC_VER=12.4.0 LANGS=c,c++`


### 3. (Optionnel) SGDK

SGDK nécessite Java, donc installez-le.
  * Debian : `apt install openjdk-11-jre`
  * RedHat : `yum install java-11-openjdk`
  * Arch : `pacman -S jdk11-openjdk`
  * Gentoo : `emerge dev-java/openjdk`
  * macOS : `brew install java`

---
**Note pour macOS**

OpenJDK doit être ajouté au PATH.
 - Ouvrez `~/.zshrc` (ou `~/.bashrc` si vous utilisez encore bash) et ajoutez la ligne :
    - `export PATH="/usr/local/opt/openjdk/bin:$PATH"`
 - Redémarrez le terminal ou exécutez `source ~/.zshrc`

---

Construisez SGDK :
 - `make sgdk`

Une version spécifique de SGDK peut être spécifiée avec `SGDK_VER=<git tag>`,
mais je ne peux garantir le fonctionnement des versions autres que celle par défaut.
Les personnes aventureuses souhaitant tester les dernières modifications peuvent aussi spécifier `SGDK_VER=master`.

### 4.1 (Optionnel) Autres Outils

Les cibles suivantes sont également disponibles :
 - `make x68k-tools` - Compatibilité Sharp X68000
 - `make mdtools-sik` - Contient mdtiler et quelques outils Echo (nécessite libpng)
 - `make mdtools-flamewing` - Outils de compression pour les données des jeux Sonic (nécessite boost)

 ### 4.2 (Expérimental) LLVM

Nécessite cmake, ninja et python3 :
 - Debian : `apt install cmake ninja-build python3`
 - (TODO : Compléter les autres)

LLVM avec clang pour M68k peut être construit :
 - `make m68k-llvm`
 
Les tests n’ont pas encore été effectués et des projets exemples/squelettes doivent encore être créés.


### 5. Installation

Il suffit d’exécuter `sudo make install`. Retenez le chemin du script de configuration de l’environnement,
et pensez à l’ajouter à votre ~/.bashrc (ou ~/.zshrc).


## Exemples

Le répertoire `examples` contient divers projets squelettes/exemples pour en baser d’autres.
Pour plus d’informations sur chacun, lisez [examples/README.md](https://raw.githubusercontent.com/andwn/marsdev/master/examples/README.md).

Cela devrait être aussi simple qu’un `make` pour n’importe lequel d’entre eux.


## Questions Fréquemment Posées

### Peu importe, je veux juste utiliser SGDK sous Linux

Installer :

 - `sudo apt install -y git build-essential texinfo wget openjdk-11-jre`
 - `git clone https://github.com/andwn/marsdev && cd marsdev`
 - `make sgdk -j8`
 - `sudo make install`

Build :

 - Récupérez le makefile dans `examples/sgdk-skeleton` et déposez-le dans votre projet.
 - `source /opt/toolchains/mars/mars.sh`
 - `make`

### Puis-je construire un projet Gendev avec Marsdev ou inversement ?

Pas facilement. Vous devrez modifier le Makefile pour que cela fonctionne.
Commencez par comparer votre Makefile actuel avec celui d’un des projets exemples.
Le document [Migration](https://raw.githubusercontent.com/andwn/marsdev/master/doc/migration.md) pourrait être utile ici.

### Comment savoir si un problème que j’ai avec SGDK est causé par Marsdev ?

Il devrait être possible de compiler votre projet tel quel avec une version officielle de SGDK.
Le Makefile inclus est juste un wrapper pour `make -f $GDK/makefile.gen`.

Si le problème persiste, c’est la faute de SGDK. Si le problème est corrigé, c’est la faute de Marsdev.

### Comment utiliser cela avec mon IDE préféré ?

Il y en a tellement, et chacun a des endroits différents où configurer les chemins.
En général, la seule chose que vous devriez AVOIR BESOIN de faire, c’est de pointer vers les headers.

 * Headers GCC : `$(MARSDEV)/m68k-elf/lib/gcc/m68k-elf/$(GCC_VER)/include`
 * Headers SGDK : `$(MARSDEV)/m68k-elf/include`
 * Headers Newlib : `$(MARSDEV)/m68k-elf/m68k-elf/include`
 
Si votre IDE vous permet de configurer ce que font les boutons de build/exécution, faites-le simplement exécuter quelque chose comme ceci.

 * Build : `make MARSDEV=/path/to/mars`
 * Run : `/path/to/an/emulator out.bin`


### Qu’en est-il de Windows ?

Je recommande vivement d’utiliser [WSL](https://learn.microsoft.com/en-us/windows/wsl/install)
et de suivre les instructions pour Debian.
Vous pouvez aussi essayer d’utiliser le Dockerfile, bien que celui-ci soit contribué par d’autres
et que je ne le teste pas moi-même.
J’avais l’habitude d’utiliser [MSYS2](https://raw.githubusercontent.com/andwn/marsdev/master/doc/install_msys_legacy.md), mais sa lenteur et son côté maladroit ne peuvent être sous-estimés.

Un addendum, si vous êtes ici juste pour utiliser SGDK et que vous n’utilisez pas Linux ou macOS alors
je pense que Marsdev vous sera de peu de bénéfice de toute façon.


### Je n’aime pas installer dans /opt. Je veux l’ancienne méthode ~/mars

C’est facile.
1. `export MARS_BUILD_DIR=${HOME}/mars`
2. Faites normalement les étapes 1 à 4
3. Passez l’étape d’installation, ajoutez plutôt à votre `~/.bashrc` :
```
export MARSDEV=${HOME}/mars
export GDK=${MARSDEV}/m68k-elf
```

### Cela prend tellement de temps à compiler !

GCC est un gros morceau, alors nous devons juste être patients.


# Choses à faire

 - [ ] Terminer le portage des parties importantes de libdos et faire fonctionner Newlib avec celui-ci


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-23

---
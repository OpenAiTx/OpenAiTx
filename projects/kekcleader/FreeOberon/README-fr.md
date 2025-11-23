# Environnement de programmation Free Oberon

» [free.oberon.org](https://free.oberon.org/en)

Oberon est un langage de programmation généraliste – le descendant direct de Pascal et Modula-2. Il est à la fois plus simple et bien plus puissant que Pascal et Modula.

Free Oberon est un environnement de développement intégré multiplateforme pour le langage de programmation Oberon, conçu dans le style classique pseudo-graphique – le célèbre écran bleu de Pascal. Disponible pour Windows, macOS et Linux.

Fob est un compilateur Oberon pratique basé sur la console.

![Capture d’écran Free Oberon](http://free.oberon.org/images/screenshot.png)

![Animation Jeu de la Vie en Oberon](http://free.oberon.org/images/life.gif)

*Voir le texte en anglais ci-dessus.*

# Environnement de programmation Free Oberon

Oberon est un langage de programmation généraliste, descendant direct de Pascal et Modula-2. Il est à la fois plus simple et beaucoup plus puissant que Pascal et Modula.

Free Oberon est un environnement de développement intégré multiplateforme pour le langage de programmation Oberon, réalisé dans le style classique pseudo-graphique – le fameux écran bleu de Pascal. Disponible pour Windows, macOS et Linux.

Fob est un compilateur en ligne de commande pour le langage Oberon.

* Version 1.1.0-alpha.7  
* Riga, 11 janvier 2023  
* Site : [free.oberon.org](https://free.oberon.org)

# Installation

## Installation sous Linux

1. Dépendances :

   Allegro (paquets de développement), Git, GCC

   Sur Debian / Ubuntu / Linux Mint, etc. :
   ```
   sudo apt-get update
   sudo apt-get install -y git gcc libc-dev liballegro5-dev
   ```
   или:
   ```
   su
   apt-get update
   apt-get install -y git gcc libc-dev liballegro5-dev
   ```
   Sur Fedora OS :


   ```
   sudo dnf install -y git gcc glibc-devel allegro5-devel allegro5-addon-image allegro5-addon-audio allegro5-addon-acodec allegro5-addon-dialog allegro5-devel allegro5-addon-image-devel allegro5-addon-audio-devel allegro5-addon-acodec-devel allegro5-addon-dialog-devel
   ```
   Sur Arch Linux :

   ```
   sudo pacman -Sy git gcc pkgconf glibc allegro
   ```
   Sur OpenSUSE :

   ```
   sudo zypper install -y git gcc glibc-devel liballegro5_2-devel liballegro_audio5_2-devel liballegro_image5_2-devel liballegro_primitives5_2-devel liballegro_dialog5_2-devel liballegro_acodec5_2-devel liballegro_acodec5_2-devel liballegro_font5_2-devel
   ```
2. Téléchargez Free Oberon sous forme d'archive tar.gz depuis le site
   [free.oberon.org](https://free.oberon.org/download)
   et décompressez-le dans votre répertoire personnel (ou à un autre emplacement).

   Option (dernière version) :

   Sur le site https://github.com/kekcleader/FreeOberon.git
   cliquez sur le bouton vert « Code » puis « Download ZIP »,
   décompressez l'archive dans votre répertoire personnel.
   Renommez le dossier `FreeOberon-main` en `FreeOberon`.

3. Depuis le dossier décompressé, lancez `install.sh`.

  ```
  ./install.sh
  ```
4. (facultatif) Ajoutez à la fin du fichier `~/.bashrc` la ligne suivante :

  ```
  alias fo='cd ~/FreeOberon;./FreeOberon'
  ```
  Cela permettra de lancer Free Oberon avec la commande `fo`.

  Pour lancer Free Oberon dans une langue spécifique, indiquez la langue (en ou ru) :
  ```
  ./FreeOberon --lang ru
  ```
  или
  ```
  fo --lang ru
  ```
## Installation sous Windows

Téléchargez l’archive depuis le site [free.oberon.org](https://free.oberon.org), décompressez-la dans un chemin ne contenant pas de caractères non latins, et lancez `FreeOberon.exe`.

Remarque. Si vous souhaitez compiler vous-même la version Free Oberon pour Windows à partir des sources, consultez l’annexe A de la [documentation Free Oberon sur free.oberon.org](http://free.oberon.org/files/FreeOberon_v1.1.0.pdf).


# Utilisation

Lancez Free Oberon et saisissez le texte d’un module de programme en langage Oberon (ou ouvrez un fichier exemple, par exemple `Life.Mod`). Appuyez sur `F9` pour compiler et exécuter le programme.  
Les fichiers source de vos programmes sont sauvegardés dans le sous-répertoire `Programs`, et les fichiers exécutables compilés sont sauvegardés dans le sous-répertoire `bin`. Le script `Data/bin/compile.sh` (`Data\bin\compile.bat`) est utilisé sous Linux (Windows) lors de la compilation. Vous pouvez modifier ces scripts.

Vous pouvez écrire des programmes composés de plusieurs modules. Ouvrez le module principal et appuyez sur `F9`. Free Oberon compilera et liera automatiquement les modules dans le bon ordre.

Si vous compilez un programme dont le fichier du module principal ne se trouve pas directement dans le sous-répertoire `Programs`, le fichier exécutable compilé sera placé à côté, et non dans le sous-répertoire `_Build`.

Si une erreur est trouvée dans l’un des modules du programme, le fichier correspondant s’ouvrira, et l’emplacement ainsi que la nature de l’erreur seront indiqués. Pour recompiler, retournez à la fenêtre du module principal et appuyez de nouveau sur `F9`.

[Historique des versions](https://raw.githubusercontent.com/kekcleader/FreeOberon/main/HISTORY.md)

______


*ANGLAIS*

* Version 1.1.0-alpha.7  
* Riga, 11 janvier 2023  
* Site web : [free.oberon.org](https://free.oberon.org/en)

# Installation

## Installation sous Linux

1. Dépendances :

   Allegro (paquets de développement), Git, GCC

   Sur OS Debian / Ubuntu / Linux Mint, etc. :


   ```
   sudo apt-get update
   sudo apt-get install -y git gcc libc-dev liballegro5-dev
   ```
   or:
   ```
   su
   apt-get update
   apt-get install -y git gcc libc-dev liballegro5-dev
   ```

   Sur OS Fedora :

   ```
   sudo dnf install -y git gcc glibc-devel allegro5-devel allegro5-addon-image allegro5-addon-audio allegro5-addon-acodec allegro5-addon-dialog allegro5-devel allegro5-addon-image-devel allegro5-addon-audio-devel allegro5-addon-acodec-devel allegro5-addon-dialog-devel argro5-addon-dialog-devel
   ```
   Sur Arch Linux :

   ```
   sudo pacman -Sy git gcc pkgconf glibc allegro
   ```

   Sur openSUSE :
   ```
   sudo zypper install -y git gcc glibc-devel liballegro5_2-devel liballegro_audio5_2-devel liballegro_image5_2-devel liballegro_primitives5_2-devel liballegro_dialog5_2-devel liballegro_acodec5_2-devel liballegro_acodec5_2-devel liballegro_font5_2-devel
   ```
2. Téléchargez Free Oberon au format tar.gz depuis  
   [free.oberon.org](https://free.oberon.org/en/download)  
   et décompressez-le dans le répertoire personnel (ou à tout autre emplacement).  

   Option (version edge) :  

   Rendez-vous sur https://github.com/kekcleader/FreeOberon.git et  
   cliquez sur le bouton vert intitulé "Code" puis sur "Download ZIP",  
   décompressez l’archive dans votre répertoire personnel.  
   Renommez le dossier `FreeOberon-main` en `FreeOberon`.  

3. Dans le répertoire décompressé, lancez `install.sh`.

  ```
  ./install.sh
  ```
4. (optionnel) Ajoutez la ligne suivante à la fin du fichier `~/.bashrc` :

  ```
  alias fo='cd ~/FreeOberon;./FreeOberon'
  ```
  Cela vous permettra de lancer Free Oberon en utilisant la commande `fo`.

  Pour exécuter Free Oberon dans une langue spécifique, spécifiez-la (en ou ru) :
  ```
  ./FreeOberon --lang ru
  ```
  or
  ```
  fo --lang ru
  ```

## Installer sous Windows

Téléchargez Free Oberon dans une archive ZIP (depuis [free.oberon.org](https://free.oberon.org/en)), extrayez-la dans un chemin sur le disque qui ne contient aucun caractère non latin, et lancez `FreeOberon.exe`.

Note. Si vous souhaitez recompiler Free Oberon sous Windows à partir du code source, reportez-vous à l’Annexe A de la [documentation Free Oberon sur free.oberon.org](https://free.oberon.org/files/FreeOberon_v1.1.0_en.pdf).


# Utilisation

Lancez Free Oberon et tapez le texte d’un module Oberon (ou ouvrez un programme exemple tel que `Life.Mod`) puis appuyez sur `F9` pour compiler et exécuter le programme.
Les fichiers source de vos programmes sont sauvegardés dans le sous-répertoire `Programs`, et les exécutables compilés sont sauvegardés dans le sous-répertoire `bin`. Le script `Data/bin/compile.sh` (`Data\bin\compile.bat`) est utilisé sous Linux (Windows) pour la compilation. Vous pouvez modifier ces scripts.

Vous pouvez écrire des programmes composés de plusieurs modules. Ouvrez le module principal et appuyez sur `F9`. Free Oberon compile et lie automatiquement ces modules dans le bon ordre.

Si vous compilez un programme dont le fichier du module principal n’est pas directement dans le sous-répertoire `Programs`, l’exécutable compilé sera situé à côté de celui-ci et non dans le sous-répertoire `_Build`.

Si une erreur survient lors de la compilation d’un des modules, le fichier correspondant sera ouvert et la position ainsi que le message d’erreur seront indiqués. Pour recompiler, retournez à la fenêtre du module principal et appuyez de nouveau sur `F9`.

[Historique des versions](https://raw.githubusercontent.com/kekcleader/FreeOberon/main/HISTORY.md)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-23

---
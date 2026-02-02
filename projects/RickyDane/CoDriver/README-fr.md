<br/>
<p align="center"><img width="700" src="https://github.com/user-attachments/assets/44295a1a-c904-407d-97af-bc1aa74baa86"/></p>
<br>
<!-- <p align="center"><a target="_blank" href="https://discord.gg/XPakYank"><img src="https://dcbadge.limes.pink/api/server/XPakYank" alt="" /></a></p> -->
<p align="center">
  <img src="https://img.shields.io/badge/Windows-blue" />
  <img src="https://img.shields.io/badge/ macOS-white" />
  <img src="https://img.shields.io/badge/Linux-red" />
</p>

<a href='https://ko-fi.com/rickydane'>
  <p align="center">
    <img height='36px' style='border: 0px; height: 36px;' src='https://storage.ko-fi.com/cdn/kofi2.png?v=3' border='0' alt='Offrez-moi un café sur ko-fi.com' />
  </p>
</a>

<p align="center">
  <a href="https://discord.gg/zSE27rjdzp">
      <img src="https://dcbadge.limes.pink/api/server/https://discord.gg/zSE27rjdzp" />
  </a>
</p>

<a href="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml"><p align="center"><img src="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml/badge.svg?branch=master"></p></a>
<p align="center">
  Un explorateur de fichiers simple né parce que je voulais apprendre le langage Rust.
  <br>
  Il est indépendant du système d’exploitation et optimisé pour la performance.
</p>

<br/><br/>

La performance est assurée par ["jwalk"](https://crates.io/crates/jwalk/versions) et ["Tauri"](https://tauri.app/).
<br/><br/>
CoDriver n’utilise pas de cache de chemin pour accéder aux fichiers et dossiers, donc la performance est obtenue grâce à Rust, à la vitesse du disque et à la puissance du CPU.

⁉️ Gardez à l’esprit que ce logiciel est encore en cours de développement et contiendra des bugs !
<br/><br/>

# Liens
- <a href="#basic-features">Fonctionnalités de base</a>
- <a href="#advanced-features">Fonctionnalités avancées</a>
- <a href="#dependencies-if-not-working-instantly">Dépendances</a>
- <a href="#%EF%B8%8F-ftp-integration-sshfs">Implémentation FTP (SSHFS)</a>
- <a href="#%EF%B8%8F-language-support">Support linguistique</a>
- <a href="#%EF%B8%8F-known-issues">Problèmes connus</a>
- <a href="#-todos">Tâches à faire</a>
- <a href="#user-interface">Interface utilisateur</a>
- <a href="#speed-comparison">Comparaison de vitesse</a>
<br/>

## Fonctionnalités de base
- Naviguez dans les répertoires comme vous en avez l'habitude
- Copier & Coller, supprimer, créer et renommer fichiers et dossiers
- Basculer entre les modes "grosses touches", liste et colonnes Miller
- Fermer les popups avec la touche échappement
- Aller à un répertoire avec Ctrl / Cmd + G en saisissant un chemin
- Trier les éléments en mode liste par taille, nom ou date de modification
<br/>

## Fonctionnalités avancées
- Compresser fichiers et dossiers
  - zip
- Décompresser automatiquement les archives dans un nouveau dossier du répertoire de travail
  - rar
  - zip
  - 7zip
  - tar (.gz, .bz2)
- Accéder à un répertoire avec le raccourci LAlt + 1 / 2 / 3 | (macOS option + 1 / 2 / 3)
  - Configurez vous-même les chemins dans les paramètres
- Créer un fichier avec F6
- Créer un dossier avec F7
- Commencer à taper dans un répertoire pour filtrer instantanément les entrées
- Vue à double panneau
  - Rechercher des fichiers avec F8
  - Copier l’élément sélectionné vers l’autre panneau avec F5
  - Déplacer l’élément sélectionné vers l’autre panneau avec LShift + F5
- Glisser-déposer des fichiers dans l’explorateur pour les copier dans le répertoire courant
- Renommer en masse votre sélection avec Ctrl / Cmd + LShift + M
  - Lancer le renommage multiple avec Ctrl / Cmd + Entrée
- Aperçu rapide du fichier -> Sélectionnez une entrée du répertoire et appuyez sur la barre d’espace.
  - Fichiers supportés : tous les fichiers image (.jpg, .png, ...), .pdf, .mp4, .json, .txt, .html  
  - Tous les autres éléments afficheront une petite vignette avec quelques informations à leur sujet. (chemin, taille, dernière modification)  
- Navigation instantanée -> Commencez à taper et filtrez automatiquement les entrées du répertoire, ce qui rend parfois la navigation vers un emplacement désiré <br/>  
  beaucoup plus rapide  
<br/>  

## Dépendances (Si cela ne fonctionne pas instantanément)  

<details>  
<summary>Développer pour afficher</summary>  

### Linux  

- openssl1.1  

#### Debian / Ubuntu
```
sudo apt update
sudo apt install libwebkit2gtk-4.0-dev \
    build-essential \
    curl \
    wget \
    file \
    libssl-dev \
    libgtk-3-dev \
    libayatana-appindicator3-dev \
    librsvg2-dev
```

#### Arche
```
sudo apt update
sudo apt install libwebkit2gtk-4.0-dev \
    build-essential \
    curl \
    wget \
    file \
    libssl-dev \
    libgtk-3-dev \
    libayatana-appindicator3-dev \
    librsvg2-dev
```
#### Fedora

```
sudo dnf check-update
sudo dnf install openssl1.1 \
    webkit2gtk4.0-devel \
    openssl-devel \
    curl \
    wget \
    file \
    libappindicator-gtk3-devel \
    librsvg2-devel
sudo dnf group install "C Development Tools and Libraries"
```
</details>
<br/>

## 🖥️ Intégration FTP (sshfs)
<details>
  <summary>Développer pour afficher</summary>
  <br/>
  Dépendances (Doivent être installées en plus) :
  <br/>

  | macOS | Linux | Windows |
  | ----- | ----- | ------- |
  | fuse-t <br/> fuse-t-sshfs | libfuse | Non pris en charge **_pour le moment_** |

  ### Installation :
  #### macOS
  ```
  brew tap macos-fuse-t/homebrew-cask
  brew install fuse-t
  brew install fuse-t-sshfs
  ```
  #### Linux
  ```
  sudo apt-get install sshfs
  ```
<br/>

## 🏴‍☠️ Support linguistique
- Anglais
  - Option de choix entre les langues bientôt disponible ...
</details>
<br/>

## ⚠️ Problèmes connus :
- Le glisser-déposer hors de la fenêtre ne fonctionne pas actuellement sur Linux
- Sur Windows, il peut être nécessaire d’installer le [Microsoft Visual C++ Redistributable](https://learn.microsoft.com/en-us/cpp/windows/latest-supported-vc-redist?view=msvc-170)
- Les permissions sous ms-windows sont un peu étranges
  - Vous devrez peut-être exécuter le programme en tant qu’administrateur si vous rencontrez des problèmes pour copier des éléments ou quelque chose de similaire
- Il pourrait y avoir un problème nécessitant l’installation d’openssl1.1 sur les systèmes Linux, si le programme ne démarre pas
- ~~Les onglets ne sont pas encore entièrement fonctionnels~~
<br/>

## 📝 Tâches à faire :
- Plusieurs langues
- Favoris
- Accès aux services de stockage en ligne (Google Drive, etc.)
<br/>

## Interface utilisateur

### Style liste
![Screenshot 2024-08-13 at 19 08 02](https://github.com/user-attachments/assets/d643c7f9-44e8-4f94-a23c-69759b600c82)

### Style grille
![Screenshot 2024-08-13 at 19 08 00](https://github.com/user-attachments/assets/b28b346a-58f3-4f7c-a23d-b19f0695bf23)

### Vue colonnes Miller
![Screenshot 2024-08-13 at 19 08 07](https://github.com/user-attachments/assets/95ab9426-837f-492d-8139-9bf7f1f0c51e)

### Vue double panneau
![Screenshot 2024-08-13 at 19 08 25](https://github.com/user-attachments/assets/a3f9a511-5e8f-44ed-95d3-1a59e2cba05b)

## Comparaison de vitesse
Explorateur de fichiers Windows : _39,83 s._<br/>
CoDriver : **_0,81 s._**

https://github.com/user-attachments/assets/17116fa5-8f43-4339-a4ff-2525e7c94ae0

Explorateur de fichiers Windows : _44,91 sec._<br/>
CoDriver : **_< 0,5 sec._**

https://github.com/user-attachments/assets/169da3d0-06ac-4775-a631-5c5708ae4766

</br>

## Comment contribuer
Configurez votre machine pour développer des applications tauri v1 : [Prérequis Tauri](https://tauri.app/v1/guides/getting-started/prerequisites)
</br></br>
Une fois cela fait, faites simplement ```git clone https://github.com/RickyDane/CoDriver``` ou ```gh repo clone RickyDane/CoDriver``` dans un emplacement sur votre machine.
</br></br>
Vous devriez pouvoir exécuter ```cargo tauri dev``` dans le répertoire racine de ce projet pour commencer à construire et lancer CoDriver.
</br>
Assurez-vous d'avoir tauri-cli installé : ```cargo install tauri-cli```
</br></br>

## Historique des étoiles

<a href="https://star-history.com/#rickydane/CoDriver&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
   <img alt="Graphique de l'historique des étoiles" src="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
 </picture>
</a>

#### Autres logiciels tiers
- DragSelect (https://github.com/ThibaultJanBeyer/DragSelect)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-02

---
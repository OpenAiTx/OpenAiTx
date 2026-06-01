
<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=en">Anglais</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ja">Japonais</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ko">Coréen</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=th">Thaï</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=de">Allemand</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=es">Espagnol</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=it">Italien</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ru">Russe</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=pt">Portugais</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=nl">Néerlandais</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=pl">Polonais</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=tr">Turc</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=vi">Vietnamien</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=id">Indonésien</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<br/>
<p align="center"><img width="500" height="auto" alt="codriver_banner" src="https://github.com/user-attachments/assets/1957b950-db16-4ebd-b514-4f9b4f4abfd9" /></p>

<br/>

<a href="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml"><p align="center"><img src="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml/badge.svg?branch=master"></p></a>

<p align="center">
  <img src="https://img.shields.io/badge/Windows-blue" />
  <img src="https://img.shields.io/badge/ macOS-white" />
  <img src="https://img.shields.io/badge/Linux-red" />
</p>

<p align="center">
  <a href="https://discord.gg/zSE27rjdzp">
      <img src="https://dcbadge.limes.pink/api/server/https://discord.gg/zSE27rjdzp" />
  </a>
</p>

<p align="center">
  <a href='https://ko-fi.com/rickydane'>
      <img height='36px' style='border: 0px; height: 36px;' src='https://storage.ko-fi.com/cdn/kofi2.png?v=3' border='0' alt='Achetez-moi un café sur ko-fi.com' />
  </a>
</p>

<br/>

<p align="center">
  Un explorateur de fichiers simple qui a vu le jour parce que je voulais apprendre le langage Rust.
  <br>
  Il est indépendant du système d'exploitation et optimisé pour la performance.
</p>

<br/><br/>

La performance est obtenue grâce à ["jwalk"](https://crates.io/crates/jwalk/versions) et ["Tauri"](https://tauri.app/).
<br/><br/>
CoDriver n'utilise pas de mise en cache des chemins pour accéder aux fichiers et dossiers, donc la performance est due à Rust, à la vitesse du disque et à la puissance du processeur.

⁉️ Gardez à l'esprit que ce logiciel est toujours en cours de développement et peut contenir des bugs !
<br/><br/>

# Liens
- <a href="#basic-features">Fonctionnalités de base</a>
- <a href="#advanced-features">Fonctionnalités avancées</a>
- <a href="#dependencies-if-not-working-instantly">Dépendances</a>
- <a href="#-ftp-sftp-integration">Intégration FTP / SFTP</a>
- <a href="#-known-issues">Problèmes connus</a>
- <a href="#-todos">Tous</a>
- <a href="#user-interface">Interface utilisateur</a>

## Fonctionnalités de base
- Naviguer dans les répertoires comme vous en avez l'habitude
- Copier & coller, supprimer, créer et renommer des fichiers et dossiers
- Passer du mode grille, liste ou colonnes Miller
- Fermer les popups avec Échap
- Aller directement à un répertoire avec Ctrl / Cmd + G en saisissant un chemin
- Trier les éléments en mode liste par taille, nom ou date de modification

## Fonctionnalités avancées
- Compresser des fichiers et dossiers
  - zip
  - zstd
  - brotli
  - density (https://github.com/g1mv/density)
- Décompresser des archives
  - rar
  - zip
  - 7zip
  - tar (.gz, .bz2)
  - density
- Naviguer vers un répertoire avec le raccourci LAlt + 1 / 2 / 3 | (option macOS + 1 / 2 / 3)
  - Configurez les chemins vous-même dans les paramètres
- Créer un fichier avec F6
- Créer un dossier avec F7
- Vue double panneau
  - Rechercher des fichiers avec F8
  - Copier l'élément sélectionné vers l'autre panneau avec F5
  - Déplacer l'élément sélectionné vers l'autre panneau avec LShift + F5
- Glisser-déposer des fichiers dans l'explorateur pour les copier dans le répertoire courant
- Renommer plusieurs éléments sélectionnés avec Ctrl / Cmd + LShift + M
  - Exécuter le renommage multiple avec Ctrl / Cmd + Entrée
- Aperçu rapide d'un fichier -> Sélectionnez une entrée de répertoire et appuyez sur la barre d'espace.
  - Fichiers supportés : tous les fichiers image (.jpg, .png, ...), .pdf, .mp4, .json, .txt, .html
  - Tous les autres éléments afficheront une petite vignette avec quelques informations à leur sujet. (chemin, taille, date de modification)
- Navigation instantanée -> Commencez à taper pour filtrer automatiquement les entrées du répertoire, ce qui permet parfois<br/>
  de naviguer beaucoup plus rapidement vers l'emplacement souhaité

## Dépendances (En cas de dysfonctionnement immédiat)

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

## 🖥️ Intégration FTP / SFTP

CoDriver offre une prise en charge native et immédiate des connexions distantes FTP et SFTP. Aucune dépendance externe, couche FUSE ou montage `sshfs` n'est nécessaire ! Connectez simplement vos serveurs distants directement dans le panneau latéral.

## 🏴‍☠️ Prise en charge des langues
- Anglais
  - Possibilité de choisir entre plusieurs langues à venir prochainement ...

## ⚠️ Problèmes connus :
- Le glisser-déposer en dehors de la fenêtre ne fonctionne pas toujours sous Linux
- Sur Windows, vous devrez peut-être installer le [Microsoft Visual C++ Redistributable](https://learn.microsoft.com/en-us/cpp/windows/latest-supported-vc-redist?view=msvc-170)
- Les permissions sous ms-windows sont un peu étranges
  - Vous devrez peut-être exécuter le programme en tant qu'administrateur si vous rencontrez des problèmes pour copier des éléments ou autre
- Il peut y avoir un problème vous obligeant à installer openssl1.1 sur les systèmes Linux si le programme ne démarre pas

## 📝 À faire :
- Multilingue
- Favoris
- Accéder aux services de stockage en ligne (Google Drive, etc.)

## Interface utilisateur
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 19 16" src="https://github.com/user-attachments/assets/fc408504-3000-4325-bc2a-638cdd01ea0a" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 19 40" src="https://github.com/user-attachments/assets/5f772d02-6bc2-470c-b999-6982043496c1" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 02" src="https://github.com/user-attachments/assets/7f2ec5ea-a669-4630-a1f8-413c7ced3f3b" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 07" src="https://github.com/user-attachments/assets/4ac9930d-7b50-4910-afb3-d47c562c3b44" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 28" src="https://github.com/user-attachments/assets/7dcfb0fa-c106-401a-b917-06e766021368" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 23 18" src="https://github.com/user-attachments/assets/4bac06d1-22df-47d4-95c9-1ccb50083506" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 23 39" src="https://github.com/user-attachments/assets/fdca23b0-9ed5-495b-9fec-18ecbfd4d5f2" />



## Comment contribuer
Préparez votre machine pour le développement d'applications tauri v1 : [Prérequis Tauri](https://tauri.app/v1/guides/getting-started/prerequisites)
</br></br>
Une fois cela fait, effectuez simplement ```git clone https://github.com/RickyDane/CoDriver``` ou ```gh repo clone RickyDane/CoDriver``` à l'emplacement souhaité sur votre machine.
</br></br>
Vous devriez pouvoir exécuter ```cargo tauri dev``` dans le répertoire racine de ce projet pour commencer à construire et lancer CoDriver.
</br>
Assurez-vous d'avoir tauri-cli installé : ```cargo install tauri-cli```
</br>

## Signature de la version

Les artefacts de version macOS doivent être signés et notarized pour éviter que Gatekeeper ne signale que l'application installée est endommagée. Voir [macOS signing and notarization](https://raw.githubusercontent.com/RickyDane/CoDriver/master/docs/macos-signing-notarization.md) pour les secrets GitHub Actions requis et les commandes de vérification.

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-01

---
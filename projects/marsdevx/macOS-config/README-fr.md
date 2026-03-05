<div align="center">
  <img src="https://raw.githubusercontent.com/marsdevx/macOS-config/main/imgs/logo.png" width="320px" alt="macOS Config Logo">
</div>

<br>

<div align="center">

  [![Last Commit](https://custom-icon-badges.demolab.com/github/last-commit/marsdevx/macOS-config?logoColor=white&labelColor=2C2C2C&label=Last%20Commit&color=8A2BE2&logo=mark-github)](https://github.com/marsdevx/macOS-config/commits/main "Last Commit")
  [![Languages](https://custom-icon-badges.demolab.com/static/v1?logoColor=white&labelColor=2C2C2C&label=Languages&message=Bash%20%7C%20Lua&color=D32F2F&logo=file-code)](https://github.com/marsdevx/macOS-config "Languages")
  <br>
  [![Supported Platforms](https://custom-icon-badges.demolab.com/static/v1?logoColor=white&labelColor=2C2C2C&label=Platform&message=MacBook&color=748ADB&logo=apple)](https://github.com/marsdevx/macOS-config "Supported Platforms")
  [![Wallpapers](https://custom-icon-badges.demolab.com/static/v1?logoColor=white&labelColor=2C2C2C&label=Includes&message=Wallpapers&color=F47F42&logo=file-media)](https://github.com/marsdevx/macOS-config/tree/main/wallpapers "Wallpapers")
  [![Customization](https://custom-icon-badges.demolab.com/static/v1?logoColor=white&labelColor=2C2C2C&label=Customization&message=Ricing&color=009688&logo=sparkles-fill)](https://github.com/marsdevx/macOS-config "Customization")
  [![License](https://custom-icon-badges.demolab.com/static/v1?logoColor=white&labelColor=2C2C2C&label=License&message=MIT&color=00C853&logo=law)](https://github.com/marsdevx/macOS-config/blob/main/LICENSE "License")

</div>

---

#  macOS Config

**macOS Config** is an **open-source** project designed to streamline the setup of your **MacBook** with **custom** settings, **program installations**, and **wallpapers**. Built using **shell** scripts, this tool **automates** the process of **configuring** your **macOS environment** for **productivity** and **ricing**.

* Specifically designed for **macOS customization** and **ricing**.
* Includes `.sh` **scripts** to **install** all programs you need for **work**.
* Applies your custom settings for installed programs **automatically**.
* Adds your favorite **wallpapers** for a personalized **macOS experience**.

Transform your MacBook into a fully customized workspace with this powerful and efficient tool!

---

## 🖼️ Preview

<div align="center">
  <img src="https://raw.githubusercontent.com/marsdevx/macOS-config/main/imgs/preview.png" alt="Preview">
</div>

---

## 🛠️ Installation

Pour installer ce projet, lancez l'application Terminal sur votre système, et exécutez les commandes ci-dessous. <br>
  - Si une fenêtre contextuelle apparaît vous invitant à télécharger les outils en ligne de commande Xcode après la première commande, cliquez sur « Télécharger » puis exécutez à nouveau la première commande.

1. **Cloner le dépôt**
```zsh
git clone https://github.com/marsdevx/macOS-config.git ~/Downloads/macOS-config
```
2. **Installer Homebrew**

```zsh
/bin/bash -c "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/HEAD/install.sh)"
echo 'eval "$(/opt/homebrew/bin/brew shellenv)"' >> ~/.zshrc
eval "$(/opt/homebrew/bin/brew shellenv)"
```
3. **Désactiver les icônes du bureau**

```zsh
defaults write com.apple.finder CreateDesktop false; killall Finder
```

4. **Créer le répertoire de configuration**
```zsh
mkdir -p ~/.config
```

5. **Mettre à jour les paramètres système**

  - Accessibilité et Centre de contrôle
    - Paramètres Système -> Accessibilité -> Affichage -> Réduire les animations -> Activé  
    - Paramètres Système -> Centre de contrôle -> Masquer et afficher automatiquement la barre de menus -> Toujours  

  - Bureau et Dock
    - Paramètres Système -> Bureau et Dock -> Masquer et afficher automatiquement le Dock -> Activé  
    - Paramètres Système -> Bureau et Dock -> Réorganiser automatiquement les espaces en fonction de la dernière utilisation -> Désactivé  
    - Paramètres Système -> Bureau et Dock -> Lors du passage à une application, basculer vers un espace ... -> Désactivé  
    - Paramètres Système -> Bureau et Dock -> Grouper les fenêtres par application -> Désactivé  
    - Paramètres Système -> Bureau et Dock -> Les écrans ont des espaces séparés -> Activé  

  - Clavier
    - Paramètres Système -> Clavier -> Raccourcis clavier -> Spotlight -> Afficher la recherche Spotlight -> Désactivé  
    - Paramètres Système -> Clavier -> Raccourcis clavier -> Spotlight -> Afficher la fenêtre de recherche Finder -> Désactivé  
    - Paramètres Système -> Clavier -> Raccourcis clavier -> Mission Control -> Basculer vers Bureau 1 -> Activé  
    - Paramètres Système -> Clavier -> Raccourcis clavier -> Mission Control -> Basculer vers Bureau 2 -> Activé  
    - Paramètres Système -> Clavier -> Raccourcis clavier -> Mission Control -> Basculer vers Bureau 3 -> Activé  
    - Paramètres Système -> Clavier -> Raccourcis clavier -> Mission Control -> Basculer vers Bureau 4 -> Activé  
    - Paramètres Système -> Clavier -> Raccourcis clavier -> Mission Control -> Basculer vers Bureau 5 -> Activé  

---

## 🚀 Utilisation

1. **Boucle**

> Gestionnaire de fenêtres

```zsh
zsh ~/Downloads/macOS-config/loop.sh
```

- Après avoir exécuté le script, configurez l'application Loop avec ces paramètres  
  - Couleur d'accent -> Fond d'écran -> Dégradé -> Activé  
  - Comportement -> Lancer au démarrage -> Activé  
  - Comportement -> Vitesse d'animation -> Fluide  
  - Comportement -> Inclure un remplissage -> Activé -> Configurer le remplissage -> 7px  
  - Comportement -> Utiliser l'écran avec le curseur -> Désactivé  
  - Raccourcis clavier -> Centre -> Supprimer  
  - Raccourcis clavier -> Ajouter -> Général -> Centre macOS -> Fn + Entrée  

<br>

2. **Raycast**

> Lancer des applications

```zsh
zsh ~/Downloads/macOS-config/raycast.sh
```

- Après avoir exécuté le script, configurez l'application Raycast avec ces paramètres
  - Cliquez sur Démarrer la configuration -> Continuer.
  - Définissez un nouveau raccourci clavier : Enregistrer un nouveau raccourci -> Assignez Cmd + Espace.
  - Cliquez sur Continuer pour finaliser.

<br>

3. **Sketchybar**

> Barre supérieure personnalisable

```zsh
zsh ~/Downloads/macOS-config/sketchybar.sh
```

<br>

4. **SKHD**

> Hotkey manager

```zsh
zsh ~/Downloads/macOS-config/skhd.sh
```

<br>

5. **Yabai**

> Window manager for multiple workspaces

```zsh
zsh ~/Downloads/macOS-config/yabai.sh
```

<br>

5. **Iterm**

> Application de terminal

- Installer Oh My Zsh
```zsh
sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"
```
- Installer un thème pour Oh My Zsh

```zsh
git clone https://github.com/romkatv/powerlevel10k.git $ZSH_CUSTOM/themes/powerlevel10k
```
- Installer et configurer Iterm2

```zsh
zsh ~/Downloads/macOS-config/iterm.sh
```
- Mettre à jour zshrc

```zsh
source ~/.zshrc
```
- Configurer Powerlevel10k  
  - Style : Lean  
  - Jeu de caractères : Unicode  
  - Schéma de couleurs : 8 couleurs  
  - Séparateur d’invite : Non  
  - Disposition : Deux lignes  
  - État de la connexion : Déconnecté  
  - Alignement de l’invite : Gauche  
  - Couleur d’accentuation : Bleu  
  - Densité de l’invite : Peu dense  
  - Style d’icônes : Beaucoup d’icônes  
  - Style de l’invite : Concis  
  - Invite instantanée : Oui  
  - Verbosité : Verbeux  

- Configurer iTerm2  
  - Ouvrir iTerm2 et accéder aux Paramètres.  
    - Général -> Fermeture -> Confirmer "Quitter iTerm2 (CmdQ)" -> Désactivé  
    - Apparence -> Général -> Thème : Minimal  
    - Apparence -> Général -> Emplacement de la barre supérieure : Bas  
    - Apparence -> Fenêtres -> Masquer les barres de défilement -> Activé  
    - Apparence -> Fenêtres -> Afficher la ligne sous la barre de titre ... -> Désactivé  
    - Apparence -> Volets -> Marges latérales : 8  
    - Apparence -> Volets -> Marges haut & bas : 12  
    - Profils -> Couleurs -> Préréglages de couleurs -> Importer -> Téléchargements -> rose-pine.itermcolors  
    - Profils -> Couleurs -> Préréglages de couleurs -> rose-pine  
    - Profils -> Fenêtre -> Transparence : 7  
    - Profils -> Texte -> Police -> MesloLGS NF  
    - Profils -> Texte -> Taille de police -> 13  
    - Profils -> Intégration du shell -> Afficher les indicateurs de marque -> Désactivé  

<br>  

6. **Fonds d’écran**  

> Ma configuration des fonds d’écran  

- Ouvrir les Réglages Système  
  - Fond d’écran -> Ajouter un dossier ou un album -> Choisir un dossier -> Téléchargements -> macOS-config -> fonds d’écran

  - Cliquez sur le dossier des fonds d'écran en bas de la page
  - Ajustez les paramètres :
    - Lecture aléatoire : Toutes les minutes
    - Afficher sur tous les espaces : Activé

---

## 📋 Licence

Tout le code contenu dans ce dépôt est sous licence [MIT License](LICENSE)

```
MIT License

Copyright (c) 2025 marsdevx

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```

---

## ⭐ Support

Si vous aimez ce projet, n’oubliez pas de ⭐ **le noter** et de **me suivre** !  
Votre **soutien** m’aide à créer plus de projets. 🚀  

🔗 **Découvrez plus de mes travaux sur [GitHub](https://github.com/marsdevx?tab=repositories) et explorez d’autres projets passionnants !**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-05

---
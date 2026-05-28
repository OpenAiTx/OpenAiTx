# 🌌 Moteur de Fonds d’Écran Animés GNOME

> **[Installez maintenant sur GNOME Extensions](https://extensions.gnome.org/extension/9558/gnome-wallpaper-engine/)**

Pas de configuration complexe. Pas de dépendances lourdes. Juste mpv, ffmpeg + l’extension.

La **façon la plus simple et la plus fiable** d’utiliser des fonds d’écran animés sur GNOME — entièrement compatible avec **Wayland & X11**.

Propulsé par **mpv** pour des performances maximales, une faible consommation de ressources, et une prise en charge complète des formats (MP4, GIF, WebM, MKV…).

Si vous aimez ce projet, pensez à lui donner une étoile ⭐ — cela aide vraiment !

## ☕ Support & Mises à Jour

Si vous souhaitez soutenir le projet, vous pouvez le faire ici :

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/achu94)

Je partagerai également les mises à jour du développement, les progrès, et les coulisses sur Ko-fi.

Vous n’avez pas besoin de faire un don pour voir les publications — tout le monde est invité à suivre et rester informé 🙂

Et si le projet vous plaît, une ⭐ sur GitHub est toujours appréciée !

---

## 🎥 Démo

> Fond d’écran animé fonctionnant sur GNOME (Wayland)

![demo](https://raw.githubusercontent.com/achu94/gnome-wallpaper-engine/main/assets/demo.gif)

---

## ✨ Fonctionnalités

- 🎬 **Galerie Intégrée :** Parcourez et sélectionnez les fonds d’écran directement depuis les Paramètres GNOME
- 🖼️ **Aperçus Miniatures :** Aperçus générés automatiquement pour tous les fonds d’écran
- 📥 **Import Intelligent :** Ajoutez des vidéos en un clic et appliquez-les instantanément
- 🚀 **Accélération GPU (activée par défaut) :** Utilise mpv avec `hwdec=auto`
- ⚡ **Très faible utilisation du CPU :** Typiquement ~1–3%
- 🔄 **Application instantanée :** Changez les fonds d’écran en temps réel
- 🖥️ **Compatible Wayland :** Fonctionne de manière fiable là où la plupart des outils échouent
- 📦 **Installation minimale :** Nécessite seulement mpv et ffmpeg
- 🎞️ **Large prise en charge des formats :** MP4, GIF, WebM, MKV et plus
- 🔁 **Démarrage automatique :** Lance automatiquement le fond d’écran à la connexion
- 🧩 **Basculer l’icône dans la barre :** Affiche ou masque l’indicateur dans le panneau supérieur
- ⏸️ **Pause automatique (plein écran) :** Met en pause lorsqu’une application en plein écran est active
- 🔋 **Pause automatique (batterie) :** Met en pause en mode batterie pour économiser de l’énergie

---

## 🚧 Feuille de route

- 🎮 Intégration Steam Wallpaper Engine (détection automatique et liste des fonds d’écran compatibles)
- 🎛️ Paramètres avancés de lecture (modes de boucle, vitesse, etc.)
- 🎨 Futur moteur de rendu (sans mpv)

---

## 🛠 Prérequis

Vous avez seulement besoin d’**mpv** installé :

### Ubuntu / Debian / Zorin OS

```bash
sudo apt update && sudo apt install mpv ffmpeg
```

### Fedora

```bash
sudo dnf install mpv ffmpeg
```

### Arch Linux

```bash
sudo pacman -S mpv ffmpeg
```

### openSUSE

```bash
sudo zypper in mpv ffmpeg
```

## 📦 Installation

### 🎖️ Extensions GNOME Officielles (Le plus simple)
Installez-le directement depuis le site des Extensions GNOME :

**[Télécharger sur GNOME Extensions](https://extensions.gnome.org/extension/9558/gnome-wallpaper-engine/)**

---

### ⚡ Installation Rapide (ZIP local)

```bash
gnome-extensions install gnome-wallpaper-engine@gjs.com.zip
```
  
Ensuite :

- Wayland : Déconnectez-vous puis reconnectez-vous  
- X11 : Appuyez sur `Alt + F2`, tapez `r`, appuyez sur Entrée

Enfin, activez l’extension via l’application **Extensions**  
(ou via l’indicateur du panneau supérieur si activé).

---

### 🧩 Installation manuelle

1. Téléchargez le fichier ZIP depuis la dernière version  
2. Extrayez-le dans :

```
~/.local/share/gnome-shell/extensions/
```

3. Assurez-vous que le dossier s'appelle :

```
gnome-wallpaper-engine@gjs.com
```

4. Compilez les schémas GSettings en exécutant cette commande dans votre terminal :

```
glib-compile-schemas ~/.local/share/gnome-shell/extensions/gnome-wallpaper-engine@gjs.com/schemas/
```

5. Redémarrer GNOME Shell
    - Wayland : Déconnectez-vous puis reconnectez-vous
    - X11 : Appuyez sur `Alt + F2`, tapez `r`, appuyez sur Entrée

6. Activez l’extension via l’application **Extensions**

---

## 📖 Utilisation

1. Ouvrez les paramètres de l’extension
2. Cliquez sur **"Ajouter Vidéo/GIF"**
3. Sélectionnez un fond d’écran dans la galerie
4. Les fonds d’écran sont appliqués instantanément
5. Utilisez éventuellement l’indicateur du panneau supérieur pour démarrer ou arrêter la lecture
6. Masquez éventuellement l’icône dans la zone de notification depuis les paramètres

---

## 💡 Pourquoi cela existe

J’ai créé ceci pour pallier le manque de solutions simples et fiables de fonds d’écran animés sous GNOME, notamment sur Wayland.

---

## ⚖️ Licence

GPL-3.0 — libre et open source.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-28

---
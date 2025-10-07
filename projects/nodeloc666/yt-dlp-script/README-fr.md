
# 🎬 Outil de téléchargement vidéo en masse yt-dlp (support Windows / Linux)

> Script de téléchargement vidéo en un clic basé sur [yt-dlp](https://github.com/yt-dlp/yt-dlp), inspiré du partage de [NodeSeek](https://www.nodeseek.com/post-334093-2#15).
> Supporte le téléchargement unique et en masse, compatible avec Windows et les principales distributions Linux (Debian / Ubuntu / Alpine / CentOS).

---

## ✨ Fonctionnalités principales

* 📥 **Exécution en un clic** : pas besoin de configuration manuelle, suivez les instructions pour démarrer le téléchargement
* 🍪 **Support de cookie personnalisé** : pour les vidéos nécessitant une connexion (⚠️ fonctionnalité non testée, peut contenir des bugs)
* 📂 **Support de répertoire de sortie personnalisé** : sauvegarde facile dans un dossier spécifié
* 📃 **Support du téléchargement en masse** : lecture automatique des liens dans le fichier `urls.txt`
* ⚙️ **Installation automatique des dépendances** : installation automatique de `yt-dlp` et `ffmpeg` sous Linux

---

## 🖼️ Aperçu des captures d’écran

| Exemple 1                                                               | Exemple 2                                                               |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| ![Exemple 1](https://img.uutv.dpdns.org/file/1746720584399_1000193433.jpg) | ![Exemple 2](https://img.uutv.dpdns.org/file/1746720581006_1000193434.jpg) |
| ![Exemple 3](https://img.uutv.dpdns.org/file/1746720588978_1000193428.jpg) | ![Exemple 4](https://img.uutv.dpdns.org/file/1746720587272_1000193427.jpg) |

---

## 🪟 Utilisation sous Windows

1. Téléchargez les fichiers suivants :

   * [`yt-dlp.exe`](https://github.com/yt-dlp/yt-dlp)
   * [`ffmpeg` version Windows](https://www.gyan.dev/ffmpeg/builds/ffmpeg-git-full.7z)

2. Après extraction, placez les fichiers suivants dans le même dossier (par exemple un dossier `yt-dlp`) :

   * `yt-dlp.exe`
   * `ffmpeg.exe`
   * `ffprobe.exe`
   * `yt-dlp.bat` (fichier script)
3. Double-cliquez sur `yt-dlp.bat`, suivez les instructions pour télécharger la vidéo.  
4. Modifiez config/config.ini pour changer la configuration par défaut  

---  

## 🐧 Méthode d'utilisation sous Linux (le dernier script du grand expert TechLion intègre également ce script aux mêmes fonctionnalités)  

**Systèmes supportés** : Debian / Ubuntu / Alpine / CentOS  

Déploiement ou mise à jour et exécution en un clic :


```bash
bash -c "$(curl -fsSL https://raw.githubusercontent.com/nodeloc666/yt-dlp-script/main/install.sh)"
```
Pour désinstaller :


```bash
bash -c "$(curl -fsSL https://raw.githubusercontent.com/nodeloc666/yt-dlp-script/main/uninstall.sh)"
```

---

## 📱 Recommandations d'utilisation Android

1. Utilisez l'application [Seal](https://github.com/JunkFood02/Seal) pour expérimenter les fonctionnalités de `yt-dlp` sur Android.  
2. L'installation de Debian via termux permet aussi le téléchargement, mais ce n'est pas nécessaire, Seal est très pratique.

---

## ⚠️ Notes importantes

1. **Mode de téléchargement en lot** : Le script lira automatiquement `config\urls.txt` dans le répertoire courant, une URL par ligne. Si le fichier est absent, il sera créé automatiquement.  
2. **Avertissement sur l'utilisation des ressources** : Évitez de télécharger simultanément plusieurs vidéos volumineuses sur des appareils à faible mémoire, ou de définir un nombre trop élevé de threads concurrents.  
3. **Remarque spécifique à CentOS** : En raison d’un environnement particulier, les tests ne sont pas complets, il est conseillé d’utiliser ce système hors production. Les autres systèmes majeurs ont été validés.  
4. Bug mineur sur la version Linux : Le script vérifie les dépendances à chaque retour à la page d’accueil, mais par principe de fonctionnement minimal, nous n’avons pas corrigé cela.  
5. Bug mineur sur la version Windows : Lorsque l’on revient à la page d’accueil depuis une autre page et qu’on effectue une sélection, l’option par défaut peut ne pas fonctionner, provoquant une boucle bloquée. Limitation non corrigée.  
Deux solutions possibles :  
    1. Quitter et relancer le programme  
    2. Ne pas utiliser l’option par défaut, choisir via le numéro

---

## 📄 Licence

Ce projet est sous [Licence MIT](https://opensource.org/licenses/MIT).

---


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-07

---

<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>


# 🎬 Outil de téléchargement vidéo yt-dlp en lot (Windows / Linux supporté)

> Script de téléchargement vidéo en un clic basé sur [yt-dlp](https://github.com/yt-dlp/yt-dlp), inspiré du partage de [NodeSeek](https://www.nodeseek.com/post-334093-2#15).
> Prise en charge du téléchargement vidéo unique et en lot, compatible avec Windows et les principales distributions Linux (Debian / Ubuntu / Alpine / CentOS).

---

## ✨ Fonctionnalités

* 📥 **Exécution en un clic** : Pas besoin de configuration manuelle, il suffit de suivre les instructions pour commencer le téléchargement
* 🍪 **Prise en charge des Cookies personnalisés** : Pour les vidéos nécessitant une connexion pour être téléchargées (⚠️ Fonction non vérifiée, des bugs peuvent exister)
* 📂 **Prise en charge du répertoire de sortie personnalisé** : Enregistrez facilement dans le dossier de votre choix
* 📃 **Prise en charge du téléchargement par lot** : Lit automatiquement les liens du fichier `urls.txt` pour les télécharger
* ⚙️ **Installation automatique des dépendances** : Installation automatique de `yt-dlp` et `ffmpeg` sous Linux

---

## 🖼️ Aperçu des captures d’écran

| Exemple 1                                                                   | Exemple 2                                                                   |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| ![Exemple 1](https://img.uutv.dpdns.org/file/1746720584399_1000193433.jpg) | ![Exemple 2](https://img.uutv.dpdns.org/file/1746720581006_1000193434.jpg) |
| ![Exemple 3](https://img.uutv.dpdns.org/file/1746720588978_1000193428.jpg) | ![Exemple 4](https://img.uutv.dpdns.org/file/1746720587272_1000193427.jpg) |

---

## 🪟 Instructions pour Windows

1. Téléchargez les fichiers suivants :

   * [`yt-dlp.exe`](https://github.com/yt-dlp/yt-dlp)
   * [Version Windows de `ffmpeg`](https://www.gyan.dev/ffmpeg/builds/ffmpeg-git-full.7z)

2. Après extraction, placez les fichiers suivants dans le même répertoire (par exemple, dossier `yt-dlp`) :

   * `yt-dlp.exe`
   * `ffmpeg.exe`
   * `ffprobe.exe`
   * `yt-dlp.bat` (fichier script)

3. Double-cliquez sur `yt-dlp.bat` et suivez les instructions pour télécharger les vidéos.
4. Modifiez config/config.ini pour changer la configuration par défaut

---

## 🐧 Instructions pour Linux (Le dernier script du grand maître lion intègre également les mêmes fonctionnalités)

**Systèmes pris en charge** : Debian / Ubuntu / Alpine / CentOS

Déploiement ou mise à jour en un clic et exécution :

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-08

---
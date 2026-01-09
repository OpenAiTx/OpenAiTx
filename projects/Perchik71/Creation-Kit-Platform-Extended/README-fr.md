
<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<p align="center">
  <img src="https://github.com/Perchik71/Creation-Kit-Platform-Extended/blob/master/Resources/logo.png" alt="Creation Kit Platform Extended" border="0" width="400px">
</p>
<p align="center">
  Une collection de modifications, d'améliorations et de ressources rétro-ingénierées pour le Creation Kit de Bethesda.
</p>

# Description
**CKPE** est une plateforme puissante à source partagée qui apporte de nombreuses corrections et améliorations à l’éditeur Creation Kit de **Bethesda**, inclut le support de l’éditeur pour des jeux tels que **Skyrim Special Edition**, **Fallout 4**, **Starfield**. Il s’agit du successeur des projets [SSE CKFixes](https://github.com/Nukem9/skyrimse-test), [SSE CKFixes Update](https://github.com/Perchik71/SkyrimSETest), [FO4 CKFixes](https://github.com/Perchik71/Fallout4Test), ainsi que du [Unicode patch for SSE CK 1.5.73](https://github.com/Perchik71/usse_test) qui a tout lancé pour l’auteur **perchik71**.  

Page [Wiki](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki)  

# Dépendances
[toml11](https://github.com/ToruNiina/toml11) par `ToruNiina` et autres  
[Zydis](https://github.com/zyantific/zydis.git) par `zyantifi` et autres  
[zipper](https://github.com/kuba--/zip.git) par `kuba--`  
[libdeflate](https://github.com/ebiggers/libdeflate.git) par `ebiggers` et autres  
[xbyak](https://github.com/herumi/xbyak.git) par `herumi` et autres  
[DirectXTex](https://github.com/microsoft/DirectXTex.git) par `microsoft`  
[jDialogs](https://github.com/Perchik71/jDialogs.git) par `perchik71` *(récursif)*

# Installation
### Nouvelle installation
Téléchargez n’importe quel [jeu supporté](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki#brief) et installez le Creation Kit.  
Téléchargez la [dernière version](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases) de **CKPE** pour votre jeu.  
Extrayez tout le contenu dans le dossier du jeu, afin que **ckpe_loader.exe** soit dans le même dossier que **CreationKit.exe**.
### Mise à jour
Téléchargez la [dernière version](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases) de **CKPE** pour votre jeu.  
Extrayez tout le contenu dans le dossier du jeu, afin que **ckpe_loader.exe** soit dans le même dossier que **CreationKit.exe**.  
Acceptez de remplacer tous les fichiers.
### Compilation
Les utilisateurs réguliers n’ont besoin de cette méthode que pour accéder aux nouvelles fonctionnalités qui n’ont pas encore été publiées.  
Ouvrez le projet dans **`Visual Studio 2022`** ou plus récent. Compilez le projet en mode **`Release`** ou **`Release-NoAVX2`**.  
Déplacez ensuite votre build dans le dossier du jeu, afin que **ckpe_loader.exe** soit dans le même dossier que **CreationKit.exe**.  
Si on vous demande de remplacer les anciens fichiers, acceptez de tout remplacer.
### Automatiser les compilations (Beta)
Téléchargez la [dernière compilation](https://github.com/Perchik71/Creation-Kit-Platform-Extended/actions) de **CKPE** pour votre jeu.  
Extrayez tout le contenu dans le dossier du jeu, afin que **ckpe_loader.exe** soit dans le même dossier que **CreationKit.exe**.  
Erreurs possibles.

# Remerciements
[Nukem9](https://github.com/Nukem9) (pour les fonctions expérimentales, le hash, etc., très utile)  
[adzm](https://github.com/adzm) (j’apprécie vraiment votre travail, vous avez [réalisé](https://github.com/adzm/win32-custom-menubar-aero-theme) ce que je voulais faire depuis longtemps)  
[yak3d](https://github.com/yak3d) (pour la contribution et le développement du workflow, et le support du plus récent Starfield)  
[Dio-Kyrie](https://github.com/Dio-Kyrie) (pour la conception du readme)  

# Licence
À partir de la version v0.6 (commit [9d93970](https://github.com/Perchik71/Creation-Kit-Platform-Extended/commit/9d93970cc3918099c895872d46a24aa29a34db11)), le projet est sous licence [LGPLv3](https://www.gnu.org/licenses/lgpl-3.0.html). <br />
Les premières versions sont sous licence [GPLv3](https://www.gnu.org/licenses/gpl-3.0.html) <br />
Copyright © 2023-2025 aka perchik71. Tous droits réservés. <br />
Le fichier `Stuffs\FO4\CreationKitPlatformExtended_FO4_Resources.pak` contient des fichiers propriétaires et non licenciés ; il en va de même pour les fichiers dans `d3dcompiler\*.*`. <br />
Les dépendances sont sous leurs licences respectives. 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-09

---
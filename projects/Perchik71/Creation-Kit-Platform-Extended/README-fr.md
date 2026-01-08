<p align="center">
  <img src="https://github.com/Perchik71/Creation-Kit-Platform-Extended/blob/master/Resources/logo.png" alt="Creation Kit Platform Extended" border="0" width="400px">
</p>
<p align="center">
  Une collection de modifications, améliorations et ressources rétroconçues pour Creation Kit par Bethesda.
</p>

# Description
**CKPE** est une plateforme puissante à code source partagé qui apporte de nombreuses corrections et améliorations à l'éditeur Creation Kit de **Bethesda**, inclut le support éditeur pour des jeux tels que **Skyrim Special Edition**, **Fallout 4**, **Starfield**, est le successeur des projets [SSE CKFixes](https://github.com/Nukem9/skyrimse-test), [SSE CKFixes Update](https://github.com/Perchik71/SkyrimSETest), [FO4 CKFixes](https://github.com/Perchik71/Fallout4Test), ainsi que du [patch Unicode pour SSE CK 1.5.73](https://github.com/Perchik71/usse_test) qui a tout commencé pour l'auteur **perchik71**.  

[Page Wiki](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki)  

# Dépendances
[toml11](https://github.com/ToruNiina/toml11) par `ToruNiina` et d'autres  
[Zydis](https://github.com/zyantific/zydis.git) par `zyantifi` et d'autres  
[zipper](https://github.com/kuba--/zip.git) par `kuba--`  
[libdeflate](https://github.com/ebiggers/libdeflate.git) par `ebiggers` et d'autres  
[xbyak](https://github.com/herumi/xbyak.git) par `herumi` et d'autres    
[DirectXTex](https://github.com/microsoft/DirectXTex.git) par `microsoft`  
[jDialogs](https://github.com/Perchik71/jDialogs.git) par `perchik71` *(récursif)*

# Installation
### Installation propre
Téléchargez un [jeu supporté](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki#brief) et installez Creation Kit.  
Téléchargez la [dernière version](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases) de **CKPE** pour votre jeu.  
Extrayez tout le contenu dans le répertoire du jeu, de sorte que **ckpe_loader.exe** soit dans le même dossier que **CreationKit.exe**.
### Mise à jour
Téléchargez la [dernière version](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases) de **CKPE** pour votre jeu.  
Extrayez tout le contenu dans le répertoire du jeu, de sorte que **ckpe_loader.exe** soit dans le même dossier que **CreationKit.exe**.  
Acceptez de remplacer tous les fichiers.
### Compilation
Les utilisateurs réguliers n'ont besoin que de cette méthode pour accéder aux fonctionnalités les plus récentes non encore publiées.  
Ouvrez un projet dans **`Visual Studio 2022`** ou ultérieur. Compilez le projet en mode **`Release`** ou **`Release-NoAVX2`**.  
Puis déplacez votre sortie de compilation dans le répertoire du jeu, de sorte que **ckpe_loader.exe** soit dans le même dossier que **CreationKit.exe**.  
Si l'on vous demande de remplacer les anciens fichiers, acceptez de tous les remplacer.
### Automatisation des compilations (Beta)
Téléchargez la [dernière build de commit](https://github.com/Perchik71/Creation-Kit-Platform-Extended/actions) de **CKPE** pour votre jeu.  
Extrayez tout le contenu dans le répertoire du jeu, de sorte que **ckpe_loader.exe** soit dans le même dossier que **CreationKit.exe**.  
Erreurs possibles.

# Crédits
[Nukem9](https://github.com/Nukem9) (pour les fonctions expérimentales, le hachage, etc., très utile)  
[adzm](https://github.com/adzm) (j’apprécie vraiment ton travail, tu as [réalisé](https://github.com/adzm/win32-custom-menubar-aero-theme) ce que je voulais faire depuis longtemps)  
[yak3d](https://github.com/yak3d) (pour la contribution et le développement du workflow et le support du plus récent Starfield)  
[Dio-Kyrie](https://github.com/Dio-Kyrie) (pour la conception du readme)  

# Licence
À partir de la v0.6 (commit [9d93970](https://github.com/Perchik71/Creation-Kit-Platform-Extended/commit/9d93970cc3918099c895872d46a24aa29a34db11)) le projet est sous licence [LGPLv3](https://www.gnu.org/licenses/lgpl-3.0.html). <br />
Les premières versions sont sous licence [GPLv3](https://www.gnu.org/licenses/gpl-3.0.html) <br />
Droits d’auteur © 2023-2025 alias perchik71. Tous droits réservés. <br />
Le fichier `Stuffs\FO4\CreationKitPlatformExtended_FO4_Resources.pak` contient des fichiers propriétaires et non licenciés ; il en va de même pour les fichiers dans `d3dcompiler\*.*`. <br />
Les dépendances sont sous leurs licences respectives. 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-08

---
# **<img src="https://raw.githubusercontent.com/FozerG/WinYandexMusicRPC/main/./assets/YMRPC_ico.ico" alt="[DISCORD RPC]" width="30"/> &nbsp;WinSdk + Yandex Music Discord Rich Presence**
[![TotalDownloads](https://img.shields.io/github/downloads/FozerG/WinYandexMusicRPC/total)](https://github.com/FozerG/WinYandexMusicRPC/releases "Download") [![LastRelease](https://img.shields.io/github/v/release/FozerG/WinYandexMusicRPC)](https://github.com/FozerG/WinYandexMusicRPC/releases "Download") [![CodeOpen](https://img.shields.io/github/languages/top/FozerG/WinYandexMusicRPC)](https://github.com/FozerG/WinYandexMusicRPC/blob/main/main.py "Show code") [![OS - Windows](https://img.shields.io/badge/OS-Windows-blue?logo=windows&logoColor=white)](https://github.com/FozerG/WinYandexMusicRPC/releases "Download")

>Malgré la décision déraisonnable de bloquer Discord en Russie, je continuerai à maintenir le script en état de fonctionnement, autant que possible 🕊️

>[Nous utiliserons ce que nous aimons.](https://github.com/Flowseal/zapret-discord-youtube)

**Discord RPC pour afficher la musique que vous écoutez actuellement sur votre ordinateur. Le téléchargement des pistes et leur couverture se fait depuis Yandex Music.**

<img src="https://github.com/user-attachments/assets/99d15c70-632f-41ec-a6cd-49de8a7d2a8f" alt="discord" width="340">

Il existe des RPC similaires qui affichent la piste en cours en utilisant l’API de Yandex Music. Cependant, ils ne peuvent pas afficher d’informations sur ce qui est diffusé à la radio (par exemple, `Моя Волна`).

C’est pourquoi j’ai créé un script qui utilise `Windows.Media.Control` pour obtenir les informations sur la piste en cours, effectue une recherche dans Yandex Music et affiche la piste dans Discord.

Avantages par rapport aux autres scripts :    
Pas besoin de token Yandex Music ✅  
Affiche les pistes des sélections, de la radio ✅  
Non limité à l’utilisation de Yandex Music, la musique peut être écoutée même depuis VKontakte ✅  
Fonctionne aussi bien avec les navigateurs qu’avec les applications ✅   
Affiche le statut pause ✅  
Affiche le temps restant jusqu’à la fin de la piste ✅  
Statut "Écoute" au lieu de "Joue à un jeu" ✅

## Exigences
Testé uniquement sur Windows 11 et Windows 10, ne fonctionnera pas sur d’autres versions et plateformes. **Le fonctionnement n’est pas garanti sur les versions Lite et Custom restreintes de Windows.**

Si vous n’utilisez pas le fichier exe :
1. Python <3.14, >=3.10

## Comment télécharger et utiliser l’exe ?
1. Téléchargez la [dernière version disponible](https://github.com/FozerG/WinYandexMusicRPC/releases)
  
2. Ouvrez WinYandexMusicRPC

3. Le script se minimisera automatiquement dans la barre système après 3 secondes. Ouvrez la console via la barre système pour vérifier le fonctionnement.

## Comment utiliser main.py ?

1. Ouvrez un terminal et allez dans le dossier où se trouve le fichier `requirements.txt`.
2. Tapez `pip install -r requirements.txt` pour installer les dépendances.  
3. Dans le terminal, tapez `python main.py`  

>Pour compiler le script avec [Pyinstaller](https://pypi.org/project/pyinstaller/), exécutez cette commande :  
`pyinstaller --noconfirm main.spec`  

------------  
Si vous écoutez de la musique non seulement depuis Yandex Music, je recommande de remplacer la ligne `strong_find = True` par `strong_find = False`, ou d’utiliser la barre système. Cela affichera de meilleurs résultats de recherche, mais pas toujours précis.  

## Bugs  
Les bugs existent toujours, mais il faut d’abord les trouver 🫡  
Si vous trouvez une erreur, n’hésitez pas à la signaler dans les [Issues](https://github.com/FozerG/WinYandexMusicRPC/issues)  

------------  
Veuillez montrer votre intérêt pour ce projet afin que je puisse le mettre à jour dès que possible.  

>Le code n’est pas parfait, car Python n’est pas mon langage principal, et le script a été écrit pour un usage personnel. Cependant, il peut servir de base pour vos propres scripts.  

>Utilise [Yandex Music API](https://github.com/MarshalX/yandex-music-api)  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-16

---
# ZigStar GW Multi outil
[![Build](https://github.com/xyzroe/ZigStarGW-MT/actions/workflows/build.yml/badge.svg)](https://github.com/xyzroe/ZigStarGW-MT/actions/workflows/build.yml)
[![GitHub version](https://img.shields.io/github/release/xyzroe/ZigStarGW-MT.svg)](https://github.com/xyzroe/ZigStarGW-MT/releases)
[![GitHub download](https://img.shields.io/github/downloads/xyzroe/ZigStarGW-MT/total.svg)](https://github.com/xyzroe/ZigStarGW-MT/latest)
[![License](https://img.shields.io/github/license/xyzroe/ZigStarGW-MT.svg)](LICENSE.txt)


> ⚠️ **ARCHIVÉ / NON MAINTENU**
>
> Ce projet est maintenant archivé et ne recevra plus de mises à jour.
> 
> Je vous invite cordialement à essayer le nouvel outil web [XZG Multi-Tool](https://github.com/xyzroe/XZG-MT), qui offre des fonctionnalités améliorées et un support continu. 🚀

  
est un wrapper GUI conçu initialement pour un travail de service pratique avec Zig Star LAN GW  
mais prend désormais en charge toute clé ou passerelle Zigbee basée sur TI CC1352/CC2538/CC2652, quel que soit le fabricant. 

Multi outil est empaqueté dans un fichier exécutable unique.  
Vous pouvez commencer sans installer Python ni les modules requis, et sans utiliser le terminal, - il suffit de télécharger et lancer.

## Possibilités :
- Lire / Écrire / Effacer la mémoire NVRAM du module Zigbee
- Écrire / Vérifier / Effacer le firmware du module Zigbee
- Le chargeur série backdoor s’active automatiquement
- Redémarrage manuel du module Zigbee ou de l’ESP32 disponible

#### Captures d’écran

<table>
<tr> 
<td width="50%">

##### Windows
<img src="https://github.com/xyzroe/ZigStarGW-MT/raw/main/images/win.png">
</td>
<td>

##### OS X
<img src="https://github.com/xyzroe/ZigStarGW-MT/raw/main/images/osx.png">
</td>
</tr>
</table>

## Instructions :
### 1. Identifier le port
#### Passerelles réseau :
Si vous utilisez ZigStar LAN GW, l'adresse IP sera détectée automatiquement, sinon saisissez l'IP:PORT de votre passerelle.
#### Clés USB :
Cliquez sur le bouton de mise à jour pour identifier la clé USB et sélectionnez votre appareil dans la liste déroulante.
<br>  
<div align="center"><img src="https://zig-star.com/images/radio-docs/multitool/multitool-1.png"></div>


### 2.A Mise à jour du firmware
- Choisissez le fichier firmware *.hex sur votre disque.
- Choisissez les options requises. Habituellement, Effacer, Écrire et Vérifier.
- Si vous devez changer l'adresse IEEE, saisissez-la et cochez la case Écrire IEEE.
- Appuyez sur le bouton « Démarrer » pour lancer les processus sélectionnés.

Si une action est effectuée sur le côté droit du Multi Tool, l'adresse IEEE principale est placée dans le champ correspondant. (Remplaçant celle saisie manuellement ou lue précédemment)

*Pour les passerelles ou clés USB autres que ZigStar, vous devrez peut-être activer manuellement le BSL.  
De plus, si vous utilisez une passerelle non ZigStar, vous devez décocher la case Auto-BSL.*
<br>  
<div align="center"><img src="https://zig-star.com/images/radio-docs/multitool/multitool-2.png"></div>


### 2.B Outils NVRAM
Si vous rencontrez des problèmes avec le réseau Zigbee, l’outil NVRAM peut vous aider.

- Le bouton **Lire** enregistre un fichier *.json sur votre disque avec l’état NVRAM actuel de votre module Zigbee pour une restauration future.
- Le bouton **Écrire** lit un fichier *.json depuis votre disque avec l’état NVRAM sauvegardé et l’écrit sur votre module Zigbee.
- Le bouton **Effacer** nettoie la NVRAM de votre module Zigbee pour une installation propre.
<div align="center"><img src="https://zig-star.com/images/radio-docs/multitool/multitool-3.png"></div>

### Vous aimez ♥️ ?
[!["Buy Me A Coffee"](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)](https://www.buymeacoffee.com/xyzroe)


### Basé sur
[zigpy/zigpy-znp](https://github.com/zigpy/zigpy-znp)  
[JelmerT/cc2538-bsl](https://github.com/JelmerT/cc2538-bsl)  

  

<br>  

xyzroe/ZigStarGW-MT is licensed under the  
##### [GNU General Public License v3.0](https://github.com/xyzroe/ZigStarGW-MT/blob/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-05

---
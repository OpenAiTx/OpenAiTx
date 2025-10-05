# Remplacement de PCB MiciMike drop-in pour Google Nest Mini

[MiciMike Nest Mini](https://github.com/iMike78/nest-mini-drop-in-pcb) est un remplacement de PCB drop-in pour le ["Google Nest Mini" (le haut-parleur intelligent de deuxième génération de Google avec un port de charge à connecteur barrel)](https://en.wikipedia.org/wiki/Google_Nest_(smart_speakers)), mais basé sur des microcontrôleurs ESP32 et XMOS pour faire fonctionner un firmware open-source.

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_1.png" width="1000">

Astuce ! Si vous cherchez plutôt un remplacement de PCB similaire pour le "Google Home Mini" (le matériel du haut-parleur intelligent de première génération de Google avec un port de charge Micro-USB), consultez le projet sœur sur https://github.com/iMike78/home-mini-v1-drop-in-pcb

Ces deux projets sont des matériels entièrement open-source, s'inspirant du concept du [Onju Voice](https://github.com/justLV/onju-voice) mais visant à suivre la [norme des assistants vocaux ouverts de l'Open Home Foundation avec Home Assistant Voice Preview Edition comme référence](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) pour les conceptions et spécifications PCB.

# Portée du projet

L'objectif de ce projet et dépôt (similaire au [Onju Voice](https://github.com/justLV/onju-voice) mais sous une licence matérielle entièrement open-source) est de concevoir un PCB de remplacement drop-in (carte de circuit imprimé) avec schémas matériels que tout un chacun peut fabriquer/construire ou commander auprès d'un fabricant de PCB en un seul endroit comme remplacement personnalisé drop-in pour le Google Nest Mini (2e génération).

Ce projet cible principalement les personnes souhaitant convertir/réutiliser leurs anciens haut-parleurs Google Nest Mini en matériel open-source pour le [Contrôle vocal de Home Assistant](https://www.home-assistant.io/voice_control/) et/ou la sortie haut-parleur du lecteur multimédia pour [Music Assistant](https://www.music-assistant.io), (le matériel pouvant cependant probablement aussi être utilisé avec d'autres applications avec d'autres firmwares car il est basé sur la populaire plateforme Espressif ESP32).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

La conception matérielle intégrera (comme pour la [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) un SoC ESP32-S3 pour WiFi, BLE, et la [détection de mot d’activation embarquée](https://www.home-assistant.io/voice_control/about_wake_word/) (utilisant le firmware sans code [ESPHome](https://esphome.io/)) + une puce XMOS xCORE XU316 pour le traitement audio avancé (avec firmware personnalisé pour le nettoyage du microphone déchargé afin d'améliorer les capacités de reconnaissance vocale en utilisant localement des algorithmes pour la suppression de bruit, l'annulation d'écho acoustique, l'annulation d'interférences et le contrôle automatique du gain).

En termes de fonctionnalités, il est conçu pour être principalement compatible matériellement avec la référence de conception de la [Home Assistant Voice Preview Edition (a.k.a. Home Assistant Voice PE)](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) (qui a été publiée comme matériel open-source par l'Open Home Foundation en collaboration avec Nabu Casa). La principale différence sera due aux contraintes définies par le boîtier et les composants du Google Nest Mini, (c’est-à-dire que la conception matérielle du projet nest-mini-drop-in-pcb sera limitée par le même type d’entrées de capacité physique que le matériel original de Google).

Ainsi, la portée de ce projet/dépôt n’est pas de développer de nouvelles fonctionnalités pour le firmware ESPHome, donc si vous souhaitez cela, vous devez vous tourner vers le développement du firmware de la Home Assistant Voice Preview Edition ainsi que vers le code principal en amont d’ESPHome :

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## Demande de collaboration

Si vous avez une certaine expérience en conception de layout PCB, (et particulièrement en routage PCB, en mise à la masse, ou en layouts numériques+analogiques sensibles au bruit), **votre aide est grandement appréciée** ! N’hésitez pas à ouvrir un nouveau ticket, soumettre des suggestions/demandes, et ajouter vos retours/commentaires aux tickets existants, ou à forker ce dépôt.

Pour plus d’informations sur le concept/idée, voir et contribuer à la discussion liée dans ce fil du forum communautaire Home Assistant :

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### Statut actuel

- ✅ Schéma terminé
- ✅ Placement des composants réalisé
- ✅ Le routage est terminé  
- ✅ Mise à la terre, stratégie de blindage et considérations EMI réalisées  
- ⚠️ Première série de tests échouée sur deux erreurs - corrigé  
- 🕓 en attente de la deuxième série de tests  

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">  

## Outils utilisés  

- 🛠️ KiCad 9  
- 🧰 SnapEDA / LCSC pour la recherche de empreintes  

## Spécifications matérielles connues  

- PCB 4 couches  
- Puce nue ESP32-S3R8 (ESP32-S3 pour WiFi, BLE et détection vocale embarquée)  
- XMOS XU316-1024-QF60B-C32 (DSP audio XMOS XU316 xCORE)  
- Flash SPI double  
- Double bus I²S (pour permettre les interfaces I2S simultanées, c’est-à-dire sortie audio et entrée audio simultanées)  
- MAX98357 pour sortie haut-parleur (Amplificateur audio Mono Classe-D I2S)  
- 2x microphones MEMS (MSM261DHP)  
- LED SK6812  
- Connecteur USB-C personnalisé et entrée d’alimentation 14 V  

---  

> ⚠️ Le flash via USB-C nécessite de déconnecter l’alimentation principale 14 V. Voir la note sérigraphiée sur le PCB pour plus de détails.  

## Références  

### Ressources Home Assistant Voice Preview Edition incluant les fichiers de conception du PCB  
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/  
  - https://voice-pe.home-assistant.io/resources/  
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files  
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf  
     
#### Firmware ESPHome pour Home Assistant Voice PE (qui utilise aussi la même combinaison ESP32-S3 + XMOS XU316) :  

- https://github.com/esphome/home-assistant-voice-pe  
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### Microcontrôleur DSP XMOS xCORE (XU316-1024-QF60B-C32)

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai
 
#### Firmware XMOS du projet ESPHome pour le matériel Home Assistant Voice Preview Edition :

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## Licence

Ce projet est sous licence [CERN Open Hardware License Version 2 - Strongly Reciprocal (CERN-OHL-S v2)]
Toute version modifiée de ce matériel doit également être distribuée sous la même licence.

☕ Si vous souhaitez soutenir ce projet, n’hésitez pas à [m’offrir un café sur Ko-fi](https://ko-fi.com/imike78)!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-05

---
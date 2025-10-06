
<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Remplacement de PCB MiciMike pour Google Nest Mini

[MiciMike Nest Mini](https://github.com/iMike78/nest-mini-drop-in-pcb) est un PCB de remplacement prêt à l'emploi pour le ["Google Nest Mini" (le haut-parleur intelligent de seconde génération de Google avec port de charge à connecteur cylindrique)](https://en.wikipedia.org/wiki/Google_Nest_(smart_speakers)), mais basé sur les microcontrôleurs ESP32 et XMOS pour exécuter un firmware open source.

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_1.png" width="1000">

Astuce ! Si vous cherchez plutôt un PCB de remplacement similaire pour le "Google Home Mini" (le haut-parleur intelligent de première génération de Google avec port de charge Micro-USB), consultez le projet associé à l'adresse https://github.com/iMike78/home-mini-v1-drop-in-pcb

Les deux sont des projets de matériel entièrement open-source, s’inspirant du concept du [Onju Voice](https://github.com/justLV/onju-voice) mais cherchant à suivre [la norme des assistants vocaux ouverts de l’Open Home Foundation avec Home Assistant Voice Preview Edition comme référence](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) pour les conceptions et spécifications des PCB.

# Portée du projet

Le but de ce projet et de ce dépôt (qui est similaire au [Onju Voice](https://github.com/justLV/onju-voice) mais sous une licence matérielle entièrement open-source) est de concevoir un PCB (circuit imprimé) de remplacement prêt à l’emploi avec des schémas matériels que tout le monde peut fabriquer/construire ou commander auprès d’un fabricant de PCB tout-en-un comme PCB de remplacement personnalisé pour le Google Nest Mini (2e génération).

Cela vise principalement les personnes cherchant à convertir/réutiliser leurs anciens haut-parleurs intelligents Google Nest Mini en matériel open-source pour le [contrôle vocal de Home Assistant](https://www.home-assistant.io/voice_control/) et/ou en sortie haut-parleur lecteur multimédia pour [Music Assistant](https://www.music-assistant.io), (le matériel peut probablement aussi être utilisé avec d’autres applications et autres firmwares car il est basé sur la plateforme populaire Espressif ESP32).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

La conception matérielle intégrera (comme [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) un SoC ESP32-S3 pour le WiFi, BLE et [la détection du mot d’activation embarquée](https://www.home-assistant.io/voice_control/about_wake_word/) (utilisant le firmware sans code [ESPHome](https://esphome.io/)) + une puce XMOS xCORE XU316 pour le traitement audio avancé (avec un firmware personnalisé pour le nettoyage du microphone afin d’améliorer les capacités de reconnaissance vocale grâce à des algorithmes locaux de suppression du bruit, annulation d’écho acoustique, annulation d’interférences et contrôle automatique du gain).

En termes de fonctionnalités, il est conçu pour être principalement compatible matériellement avec la [Home Assistant Voice Preview Edition (alias Home Assistant Voice PE](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) conception de référence (qui a été publiée en tant que conception matérielle open-source par l’Open Home Foundation en collaboration avec Nabu Casa). La principale différence sera due aux contraintes définies par l’enveloppe et les composants du Google Nest Mini, (c’est-à-dire que la conception matérielle du projet nest-mini-drop-in-pcb sera limitée par les mêmes types d’entrées physiques de capacité que le matériel d’origine de Google).

Ainsi, la portée de ce projet/dépôt n’est pas de développer de nouvelles fonctionnalités/fonctions pour le firmware ESPHome, donc si vous souhaitez cela, vous devez plutôt vous tourner vers le développement du firmware de Home Assistant Voice Preview Edition ainsi qu’au code principal ESPHome en amont :

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## Appel à collaboration

Si vous avez de l’expérience en conception de circuits imprimés, (et en particulier en routage PCB, plan de masse ou en conception numérique+analogique sensible au bruit), **votre aide est très appréciée** ! N’hésitez pas à ouvrir une nouvelle issue, soumettre des suggestions/demandes, et ajouter vos avis/commentaires sur les issues existantes, ou à forker ce dépôt.

Pour plus d’informations sur le concept/l’idée, consultez et contribuez à la discussion liée sur ce fil du forum de la communauté Home Assistant :

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### Statut actuel

- ✅ Schéma terminé
- ✅ Placement des composants effectué
- ✅ Routage terminé
- ✅ Plan de masse, stratégie de blindage et considérations EMI réalisés
- ⚠️ 1er lot de test échoué sur deux erreurs - corrigé
- 🕓 attente du 2ème lot de test

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">

## Outils utilisés

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC pour la recherche d'empreintes

## Spécifications matérielles connues

- PCB 4 couches
- Puce nue ESP32-S3R8 (ESP32-S3 pour WiFi, BLE et détection embarquée de mot-clé)
- XMOS XU316-1024-QF60B-C32 (XMOS XU316 xCORE DSP pour traitement audio)
- Double mémoire flash SPI
- Double bus I²S (pour permettre des interfaces I2S simultanées, c’est-à-dire sortie et entrée audio en même temps)
- MAX98357 pour sortie haut-parleur (Amplificateur audio mono I2S Classe-D)
- 2x microphones MEMS (MSM261DHP)
- LEDs SK6812
- Entrées personnalisées USB-C et alimentation 14V

---

> ⚠️ Le flashage via USB-C nécessite de déconnecter l’alimentation principale 14V. Voir la note sur la sérigraphie du PCB pour plus de détails.

## Références

### Ressources Home Assistant Voice Preview Edition incluant les fichiers de conception PCB
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/fr/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Firmware ESPHome pour Home Assistant Voice PE (qui utilise aussi la même combinaison ESP32-S3 + XMOS XU316) :

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP (XU316-1024-QF60B-C32) puce MCU IC

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

Ce projet est sous licence [Licence CERN Open Hardware Version 2 - Fortement Réciproque (CERN-OHL-S v2)]
Toute version modifiée de ce matériel doit également être distribuée sous la même licence.

☕ Si vous souhaitez soutenir ce projet, n'hésitez pas à [m'offrir un café sur Ko-fi](https://ko-fi.com/imike78) !



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---
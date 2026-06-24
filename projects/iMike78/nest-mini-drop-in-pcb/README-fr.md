
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

# Remplacement PCB drop-in MiciMike pour Google Nest Mini

[MiciMike Nest Mini](https://github.com/iMike78/nest-mini-drop-in-pcb) est un remplacement de PCB drop-in pour le ["Google Nest Mini" (l’enceinte intelligente de deuxième génération de Google avec port de charge à connecteur cylindrique)](https://en.wikipedia.org/wiki/Google_Nest_(smart_speakers)), mais basé sur les microcontrôleurs ESP32 et XMOS pour exécuter un firmware open-source.

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_1.png" width="1000">

Astuce ! Si vous recherchez plutôt un remplacement de PCB drop-in similaire pour le "Google Home Mini" (la première génération de l’enceinte intelligente de Google avec port de charge Micro-USB), consultez le projet frère sur https://github.com/iMike78/home-mini-v1-drop-in-pcb

**Attention !** Il y a actuellement une campagne de financement participatif en cours pour le "MiciMike Home Mini Drop-In PCB" (Google Home Mini 1ère génération) qui est désormais en ligne sur Crowd Supply en phase de prévente (aperçu du projet uniquement), et si celle-ci réussit, une campagne similaire est prévue pour le Nest Mini (2ème génération), alors consultez-la ici et soutenez ce projet indirectement en le finançant si vous le pouvez :

* https://www.crowdsupply.com/micimike-rev-devices/micimike-home-mini-drop-in-pcb

Ces deux projets sont du matériel entièrement open-source, s’inspirant du concept [Onju Voice](https://github.com/justLV/onju-voice) mais visant à suivre la [norme des assistants vocaux open-source de l’Open Home Foundation avec Home Assistant Voice Preview Edition comme référence](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) pour les conceptions et spécifications des PCB.

# Portée du projet

Le but de ce projet et de ce dépôt (similaire à [Onju Voice](https://github.com/justLV/onju-voice) mais sous une licence matérielle totalement open-source) est de concevoir un PCB de remplacement direct (carte de circuit imprimé) avec schémas électroniques que chacun peut fabriquer/assembler ou commander auprès d’un fabricant de PCB comme PCB de remplacement personnalisé pour le Google Nest Mini (2e génération).

Ceci vise principalement les personnes souhaitant transformer/réutiliser leurs anciens haut-parleurs intelligents Google Nest Mini en matériel open-source pour le [contrôle vocal de Home Assistant](https://www.home-assistant.io/voice_control/) et/ou la sortie haut-parleur média pour [Music Assistant](https://www.music-assistant.io), (le matériel pouvant cependant aussi être utilisé avec d’autres applications et firmwares car il est basé sur la populaire plateforme Espressif ESP32).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/front_render.jpg" width="1000" alt="Premier test PCB">

La conception matérielle intégrera (comme la [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) un SoC ESP32-S3 pour le WiFi, BLE et la [détection du mot de réveil embarquée](https://www.home-assistant.io/voice_control/about_wake_word/) (avec firmware no-code [ESPHome](https://esphome.io/)) + une puce XMOS xCORE XU316 pour le traitement audio avancé (avec firmware personnalisé pour le nettoyage micro hors charge afin d’améliorer la reconnaissance vocale via des algorithmes locaux de suppression de bruit, annulation d’écho acoustique, annulation d’interférences et contrôle automatique du gain).

En termes de fonctionnalités, le matériel est conçu pour être majoritairement compatible avec la référence [Home Assistant Voice Preview Edition (alias Home Assistant Voice PE](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) (qui a été publiée en tant que conception matérielle open-source par l’Open Home Foundation en collaboration avec Nabu Casa). La principale différence résidera dans les contraintes imposées par le boîtier et les composants du Google Nest Mini, (c’est-à-dire que la conception du matériel du projet nest-mini-drop-in-pcb sera limitée par les mêmes types d’entrées physiques de capacité que le matériel d’origine de Google).

Ainsi, la portée de ce projet/dépôt n’est pas de développer de nouvelles fonctions/fonctionnalités pour le firmware ESPHome, donc si vous souhaitez cela, il vous faut plutôt vous tourner vers le développement firmware de la Home Assistant Voice Preview Edition ainsi que vers le code principal d’ESPHome :

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## Appel à collaboration

Si vous avez de l’expérience en conception de PCB, (et notamment en routage, plan de masse ou conception de circuits mixtes numériques+analogiques sensibles au bruit), **votre aide est très appréciée** ! N’hésitez pas à ouvrir une nouvelle issue, soumettre des suggestions/demandes, ou donner votre avis/commentaire sur les issues existantes, ou forker ce dépôt.

Pour plus d’informations sur le concept/l’idée et pour contribuer à la discussion, voir aussi ce fil du forum de la communauté Home Assistant :

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### État actuel

- ✅ Schéma terminé
- ✅ Placement des composants effectué
- ✅ Routage terminé
- ✅ Plan de masse, stratégie de blindage et considérations CEM terminés
- ⛔ 1ère série de tests échouée sur deux erreurs – corrigé
- ⚠️ 2ème lot de tests partiellement fonctionnel
- ✅ Option de débogage XTAG4 ajoutée pour le prochain lot

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/back_render.jpg" width="1000">

## Outils utilisés

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC pour la recherche d’empreintes

## Spécifications matérielles connues

- PCB à 4 couches
- Puce nue ESP32-S3R8 (ESP32-S3 pour WiFi, BLE et détection de mot-clé intégrée)
- XMOS XU316-1024-QF60B-C24 (traitement audio DSP XMOS XU316 xCORE)
- 16 Mo de flash SPI (ESP32-S3)
- 4 Mo de flash SPI (XMOS XU316)
- Deux bus I²S (entrée et sortie audio simultanées)
- Amplificateur stéréo Classe D TAS5805M (TAS5805MPWPR) avec DSP intégré (audio I2S, contrôle I2C), configuré pour sortie haut-parleur mono BTL
- 3x microphones MEMS (MMICT390200012) disposés sur un arc de 34 mm de rayon – le firmware actuel utilise 2 micros, la prise en charge matérielle d’une matrice de 3 micros est déjà présente
- 6x LED RVB SK6812
- Alimentation personnalisée USB-C et 14V (Remarque ! USB-C et connecteur d’alimentation cylindrique ne peuvent pas être connectés en même temps)
- Contrôleur tactile capacitif MPR121 (utilisé pour l’entrée tactile à la place de la détection tactile native ESP32-S3)

---

> ⚠️ La programmation via USB-C nécessite de déconnecter l’alimentation principale 14V. Voir la note sérigraphiée sur le PCB pour plus de détails.

## Références

### Ressources Home Assistant Voice Preview Edition incluant les fichiers de conception PCB
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/fr/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Firmware ESPHome pour Home Assistant Voice PE (qui utilise également la même combinaison ESP32-S3 + XMOS XU316) :

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP (XU316-1024-QF60B-C24) puce IC MCU

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai
 
#### Micrologiciel XMOS du projet ESPHome pour le matériel Home Assistant Voice Preview Edition :

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## Licence

Ce projet est sous licence [CERN Open Hardware License Version 2 - Strongly Reciprocal (CERN-OHL-S v2)]
Toute version modifiée de ce matériel doit également être distribuée sous la même licence.

☕ Si vous souhaitez soutenir ce projet, n'hésitez pas à [m'offrir un café sur Ko-fi](https://ko-fi.com/imike78) !




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-24

---
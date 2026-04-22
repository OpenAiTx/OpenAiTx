
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

**Attention !** Une campagne de financement participatif pour le "MiciMike Home Mini Drop-In PCB" (Google Home Mini de première génération) est désormais en phase de pré-lancement sur Crowd Supply (aperçu du projet uniquement), et si celle-ci réussit, une campagne équivalente pour le Nest Mini sera planifiée. Consultez-la ici :

* https://www.crowdsupply.com/micimike-rev-devices/micimike-home-mini-drop-in-pcb

Ces deux projets sont entièrement open-source hardware, s’inspirant en partie du [Onju Voice](https://github.com/justLV/onju-voice), mais visant à suivre la [norme des assistants vocaux ouverts de l’Open Home Foundation avec Home Assistant Voice Preview Edition comme référence](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) pour les conceptions et spécifications des PCB.

# Portée du projet

Le but de ce projet et de ce dépôt (similaire au [Onju Voice](https://github.com/justLV/onju-voice) mais sous une licence hardware entièrement open-source) est de concevoir un PCB de remplacement (carte de circuit imprimé) avec des schémas matériels que tout le monde peut fabriquer ou commander chez un fabricant de PCB comme PCB de remplacement personnalisé pour le Google Nest Mini (2e génération).

Il cible principalement les personnes souhaitant convertir/repurposer leurs anciens enceintes intelligentes Google Nest Mini en matériel open-source pour le [contrôle vocal de Home Assistant](https://www.home-assistant.io/voice_control/) et/ou pour la sortie audio d’un lecteur média via [Music Assistant](https://www.music-assistant.io), (le matériel peut aussi probablement être utilisé avec d’autres applications et firmwares car il est basé sur la plateforme Espressif ESP32).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

La conception matérielle intégrera (similairement à la [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) un SoC ESP32-S3 pour le WiFi, BLE, et la [détection du mot de réveil embarquée](https://www.home-assistant.io/voice_control/about_wake_word/) (via le firmware [ESPHome sans code](https://esphome.io/)) + une puce XMOS xCORE XU316 pour le traitement audio avancé (avec un firmware personnalisé pour le nettoyage du microphone afin d’améliorer la reconnaissance vocale grâce à des algorithmes locaux de suppression de bruit, annulation d’écho acoustique, annulation d’interférences et contrôle automatique du gain).

En termes de fonctionnalité, il est conçu pour être principalement compatible matériellement avec le [Home Assistant Voice Preview Edition (alias Home Assistant Voice PE](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) design de référence (publié en open-source hardware par l’Open Home Foundation en collaboration avec Nabu Casa). La principale différence sera liée aux contraintes imposées par le boîtier et les composants du Google Nest Mini, (c’est-à-dire que le design hardware du projet nest-mini-drop-in-pcb sera limité par les mêmes entrées de capacité physique que le matériel d’origine de Google).

Ainsi, la portée de ce projet/dépôt n’est pas de développer de nouvelles fonctionnalités pour le firmware ESPHome ; si vous souhaitez cela, vous devez plutôt vous tourner vers le développement du firmware de la Home Assistant Voice Preview Edition ainsi que vers le code principal ESPHome :

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## Appel à collaboration

Si vous avez de l’expérience en conception de PCB, (et en particulier avec le routage PCB, le versement de masse, ou les designs numériques+analogiques sensibles au bruit), **votre aide est très appréciée** ! N’hésitez pas à ouvrir un nouveau ticket, soumettre des suggestions/demandes, et ajouter vos contributions/retours aux tickets existants, ou à forker ce dépôt.

Pour plus d’informations sur le concept/l’idée et pour contribuer à la discussion, consultez également ce fil du forum communautaire Home Assistant :

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### État actuel

- ✅ Schéma terminé
- ✅ Placement des composants effectué
- ✅ Routage terminé
- ✅ Versement de masse, stratégie de blindage et considérations EMI réalisées
- ⚠️ Premier lot de test échoué sur deux erreurs - corrigé
- 🕓 en attente du 2ème lot de tests

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">

## Outils utilisés

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC pour la recherche d'empreintes

## Spécifications matérielles connues

- PCB à 4 couches
- Puce nue ESP32-S3R8 (ESP32-S3 pour WiFi, BLE et détection de mot-clé embarquée)
- XMOS XU316-1024-QF60B-C24 (traitement audio DSP XMOS XU316 xCORE)
- Double SPI flash (car ESP32 et XMOS ont leur propre SPI flash)
- Double bus I²S (pour permettre des interfaces I2S simultanément, c.-à-d. sortie et entrée audio en même temps)
- TAS5805M (TAS5805MPWPR) pour la sortie haut-parleur (amplificateur audio mono I2S Classe D avec configuration DSP via I2C)
- 2x microphones MEMS (double MMICT390200012 avec un espacement inter-micro de 68 mm)
- 6x LED RGB SK6812
- Entrée d'alimentation USB-C et 14V personnalisée (Remarque ! USB-C et connecteur d'alimentation ne peuvent pas être connectés en même temps)

---

> ⚠️ Le flashage via USB-C nécessite de déconnecter l'alimentation principale 14V. Voir la note de sérigraphie sur le PCB pour plus de détails.

## Références

### Ressources Home Assistant Voice Preview Edition incluant les fichiers de conception PCB
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Firmware ESPHome pour Home Assistant Voice PE (qui utilise également la même combinaison ESP32-S3 + XMOS XU316) :

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### Puce IC MCU XMOS xCORE DSP (XU316-1024-QF60B-C32)

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

☕ Si vous souhaitez soutenir ce projet, n'hésitez pas à [m'offrir un café sur Ko-fi](https://ko-fi.com/imike78) !




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-22

---
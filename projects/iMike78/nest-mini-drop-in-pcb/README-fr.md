
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
Les deux sont des projets de matériel entièrement open-source, s’inspirant du concept de [Onju Voice](https://github.com/justLV/onju-voice) mais visant à suivre la [norme des assistants vocaux open-source de l’Open Home Foundation avec Home Assistant Voice Preview Edition comme référence](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) pour la conception et les spécifications des PCB.

# Portée du projet

L’objectif de ce projet et de ce dépôt (similaire à [Onju Voice](https://github.com/justLV/onju-voice) mais sous une licence matérielle entièrement open-source) est de concevoir un PCB de remplacement (carte de circuit imprimé) avec des schémas matériels que chacun peut fabriquer/construire ou commander auprès d’un fabricant de PCB en tant que pièce de remplacement personnalisée pour le Google Nest Mini (2e génération).

Ce projet cible principalement les personnes souhaitant convertir/réutiliser leurs anciens haut-parleurs intelligents Google Nest Mini en matériel open-source pour le [contrôle vocal de Home Assistant](https://www.home-assistant.io/voice_control/) et/ou comme sortie haut-parleur lecteur multimédia pour [Music Assistant](https://www.music-assistant.io), (le matériel peut cependant probablement être utilisé avec d’autres applications avec un firmware différent car il est basé sur la populaire plateforme Espressif ESP32).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

La conception matérielle intégrera (similaire à la [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) un SoC ESP32-S3 pour le WiFi, BLE et la [détection embarquée du mot de réveil](https://www.home-assistant.io/voice_control/about_wake_word/) (avec le firmware sans code [ESPHome](https://esphome.io/)) + une puce XMOS xCORE XU316 pour le traitement audio avancé (avec un firmware personnalisé pour le nettoyage du microphone afin d’améliorer la reconnaissance vocale en utilisant des algorithmes locaux pour la suppression de bruit, l’annulation d’écho acoustique, l’annulation d’interférences et le contrôle automatique du gain).

En termes de fonctionnalité, il est conçu pour être principalement compatible matériellement avec la [Home Assistant Voice Preview Edition (alias Home Assistant Voice PE)](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) (qui a été publiée comme conception matérielle open-source par l’Open Home Foundation en collaboration avec Nabu Casa). La principale différence proviendra des contraintes définies par le boîtier et les composants du Google Nest Mini, (c’est-à-dire que la conception matérielle du projet nest-mini-drop-in-pcb sera limitée par les mêmes types d’entrées physiques de capacité que le matériel original de Google).

Ainsi, la portée de ce projet/dépôt n’est pas de développer de nouvelles fonctionnalités pour le firmware ESPHome ; si vous souhaitez cela, il faut vous tourner vers le développement du firmware de la Home Assistant Voice Preview Edition ainsi que vers le code principal amont d’ESPHome :

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## Demande de collaboration

Si vous avez de l’expérience dans la conception de PCB, (et en particulier en routage de PCB, plan de masse, ou conception de circuits numériques+analogiques sensibles au bruit), **votre aide est grandement appréciée** ! N’hésitez pas à ouvrir une nouvelle issue, soumettre des suggestions/demandes, ajouter vos remarques/retours aux issues existantes, ou à forker ce dépôt.

Pour plus d’informations sur le concept/idée, consultez et contribuez également à la discussion liée sur ce fil du forum Home Assistant :

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### État actuel

- ✅ Schéma terminé
- ✅ Placement des composants effectué
- ✅ Routage terminé
- ✅ Plan de masse, stratégie de blindage et considérations EMI terminées
- ⚠️ 1ère série de tests échouée à cause de deux erreurs - corrigées
- 🕓 en attente de la 2ème série de tests

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">


## Outils utilisés

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC pour la recherche d'empreintes

## Spécifications matérielles connues

- PCB à 4 couches
- Puce nue ESP32-S3R8 (ESP32-S3 pour WiFi, BLE et détection de mot-clé embarquée)
- XMOS XU316-1024-QF60B-C24 (Traitement audio DSP XMOS XU316 xCORE)
- Double mémoire flash SPI (car ESP32 et XMOS ont leur propre flash SPI)
- Doubles bus I²S (pour permettre des interfaces I2S en simultané, c’est-à-dire sortie et entrée audio simultanées)
- MAX98357 pour la sortie haut-parleur (Amplificateur audio mono Classe-D I2S)
- 2x microphones MEMS (double MMICT390200012 avec un espacement inter-microphones de 68mm)
- 6x LED RGB SK6812
- USB-C personnalisé et entrée alimentation 14V (Remarque ! USB-C et connecteur d’alimentation ne peuvent pas être connectés en même temps)

---

> ⚠️ Le flashage via USB-C nécessite de déconnecter l'entrée principale 14V. Voir la note sérigraphiée sur le PCB pour plus de détails.

## Références

### Ressources Home Assistant Voice Preview Edition y compris fichiers de conception PCB
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Micrologiciel ESPHome pour Home Assistant Voice PE (qui utilise aussi la même combinaison ESP32-S3 + XMOS XU316) :

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP (XU316-1024-QF60B-C32) puce IC MCU

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

☕ Si vous souhaitez soutenir ce projet, vous pouvez [m’offrir un café sur Ko-fi](https://ko-fi.com/imike78) !



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-03

---
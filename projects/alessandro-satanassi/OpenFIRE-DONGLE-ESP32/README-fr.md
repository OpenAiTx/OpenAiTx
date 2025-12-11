## OpenFIRE-DONGLE pour EPS32


![foto_dongle](https://github.com/user-attachments/assets/a38d7390-f7e7-42d7-844c-ad8388670f6d)



https://github.com/user-attachments/assets/70a193a0-686e-4da3-8d30-f0067de6b63c



Ce dépôt a été créé pour être utilisé avec le code du projet OpenFIRE-Firmware-ESP32, un portage du projet original 'OpenFIRE-firmware' du TeamOpenFIRE, adapté pour fonctionner sur le microcontrôleur ESP32S3.
Le projet, développé avec PlatformIO, représente le firmware pour un ESP32S3 à utiliser comme dongle connecté au PC, afin de permettre une connexion sans fil via le protocole ESP-NOW de l'ESP32. Ce dongle est conçu pour être utilisé en combinaison avec le firmware 'OpenFIRE-Firmware-ESP32', à installer sur la lightgun.
Le code est structuré pour détecter automatiquement les lightguns et se configurer de manière autonome.
La transmission entre la lightgun et le dongle est bidirectionnelle, permettant d’utiliser la lightgun comme si elle était connectée directement au PC via USB.
Le PC ne perçoit aucune différence entre une connexion directe via USB et une connexion sans fil via le dongle.
Je tiens à exprimer ma sincère gratitude au TeamOpenFIRE pour la création du projet 'OpenFIRE' : tous les mérites et ma pleine reconnaissance leur reviennent.
Une petite partie du code a été extraite et modifiée à partir du dépôt "SerialTransfer" : https://github.com/PowerBroker2/SerialTransfer.git.
Je souhaite donc remercier également l’auteur de ce code, PowerBroker2, pour sa contribution.


Ce dépôt a été créé pour être utilisé conjointement avec le code du projet OpenFIRE-Firmware-ESP32, un portage du projet original 'OpenFIRE-firmware' par TeamOpenFIRE, adapté pour fonctionner sur le microcontrôleur ESP32S3.
Le projet, développé avec PlatformIO, sert de firmware pour un ESP32S3 à utiliser comme dongle connecté au PC, permettant une connectivité sans fil via le protocole ESP-NOW de l’ESP32. Ce dongle est conçu pour être utilisé en combinaison avec le firmware 'OpenFIRE-Firmware-ESP32', installé sur la lightgun.
Le code est structuré pour détecter automatiquement les lightguns et se configurer de façon autonome.
La communication entre la lightgun et le dongle est bidirectionnelle, permettant à la lightgun de fonctionner comme si elle était directement connectée au PC via USB.
Le PC ne remarque aucune différence entre une connexion USB directe et une connexion sans fil via le dongle.
Je tiens à exprimer ma sincère gratitude à TeamOpenFIRE pour la création du projet 'OpenFIRE' ; tout le mérite et ma plus profonde reconnaissance leur reviennent.
Une petite portion du code a été prise et modifiée à partir du dépôt "SerialTransfer" : https://github.com/PowerBroker2/SerialTransfer.git.
Je tiens donc à remercier l’auteur de ce code, PowerBroker2, pour sa contribution.


## ... suit la page originale du projet 'OpenFIRE-firmware' du TeamOpenFIRE
## ... follows the original project page 'OpenFIRE-firmware' project by TeamOpenFIRE

### Vous aimez notre travail ? [N’oubliez pas de soutenir les développeurs !](https://github.com/TeamOpenFIRE/.github/blob/main/profile/README.md)

![BannerDark](https://raw.githubusercontent.com/alessandro-satanassi/OpenFIRE-DONGLE-ESP32/main/docs/of_bannerLoD.png#gh-dark-mode-only)![BannerLight](https://raw.githubusercontent.com/alessandro-satanassi/OpenFIRE-DONGLE-ESP32/main/docs/of_bannerDoL.png#gh-light-mode-only)
# OpenFIRE - Le système de pistolet à lumière ouvert *Four Infa-Red Emitter*
###### Successeur de [IR-GUN4ALL](http://github.com/SeongGino/ir-light-gun-plus), basé sur le fork [Prow Enhanced](https://github.com/Prow7/ir-light-gun), lui-même basé sur la mise à jour majeure "Big Code Update" 4IR Beta du projet [SAMCO](https://github.com/samuelballantyne/IR-Light-Gun)

## Fonctionnalités :
- **Périphériques entièrement fonctionnels**, du solénoïde et retour de force par vibration, à la surveillance de la température TMP36, et d’autres à venir.
- **Support de multiples configurations IR**, avec *suivi en temps réel ajusté à la perspective* pour les doubles barres lumineuses (recommandé !) et les configurations en diamant type Xwiigun (compatible avec d’autres systèmes).
- **Système d’entrée flexible**, avec sorties vers clavier, souris ABS(olue) à 5 boutons, et manette à double stick avec support pad directionnel, avec un **système robuste de mappage des boutons** adapté à vos besoins !
- **Installation facile** avec des binaires simples *.UF2* qui peuvent être glissés-déposés directement sur un microcontrôleur basé sur *RP2040*.
- **Paramètres embarqués portables** pour stocker des profils d’étalonnage, bascules, réglages, identifiant USB, et plus encore.
- **Intégration avec l’[OpenFIRE App](https://github.com/TeamOpenFIRE/OpenFIRE-App)** pour une configuration conviviale, multiplateforme et en temps réel.
- **Optimisé pour le RP2040**, utilisant son second cœur pour le sondage et la mise en file d’attente des entrées ainsi que la gestion série, et le cœur principal pour le traitement de la caméra et des périphériques, dès que possible.
- **Compatible avec les gestionnaires de retour de force PC** tels que [Mame Hooker](https://dragonking.arcadecontrols.com/static.php?page=aboutmamehooker), [The Hook Of The Reaper](https://github.com/6Bolt/Hook-Of-The-Reaper), et [QMamehook](https://github.com/SeongGino/QMamehook).
- **Supporte la sortie affichage OLED intégrée** pour les *écrans SSD1306 I2C* pour la navigation dans les menus et le retour visuel d’éléments de jeu comme la vie et les munitions actuelles.
- **Compatible avec l’écosystème MiSTer FPGA**, avec des mappings dédiés pour fluidifier au maximum l’expérience utilisateur.
- **Gratuit et open source pour la communauté lightgun, pour toujours !**

___
## Remerciements :
* Samuel Ballantyne, pour son projet original SAMCO, le magnifique branding OpenFIRE, et le système de suivi basé sur la perspective.
* Prow7, pour sa branche améliorée de SAMCO qui a servi de base au mode pause et aux sous-systèmes de sauvegarde.
* Odwalla-J, mrkylegp, RG2020 & lemmingDev pour la consultation préliminaire, les tests de bugs et les retours.
* Les testeurs IR-GUN4ALL pour leurs retours précoces et leurs demandes de fonctionnalités – cela n’aurait pas été possible sans vous !
* Chris Young pour sa bibliothèque compatible TinyUSB (désormais intégrée à `TinyUSB_Devices`).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---
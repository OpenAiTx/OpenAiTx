# Contrôle d'alimentation PC ESPHome via Home Assistant

Ce projet contient le contrôle à distance de l'alimentation PC via HomeAssistant et les cartes ESPHome ESP8266/ESP32.

J'utilise ce projet pour allumer et éteindre à distance mon NAS basé sur PC via Home Assistant comme alternative au Wake-On-Lan (WOL) qui présente des limitations connues.

## Fonctionnalités

* Contrôler le bouton d'alimentation physique du PC (panneau avant) connecté à la carte mère :
  * Allumer le PC depuis n'importe quel état d'alimentation tel que `power-off/suspendu/hibernation` (Comportement pression courte du bouton d'alimentation).
  * Arrêt/suspension/hibernation propre du système d'exploitation (Comportement pression courte du bouton d'alimentation).
  * Forcer l'arrêt de l'alimentation (Comportement pression longue du bouton d'alimentation).
* Lire l'état d'alimentation marche/arrêt du PC depuis la carte mère.
* Indépendant du système d'exploitation.
* Les boutons d'alimentation/réinitialisation du panneau avant restent pleinement fonctionnels.
* Autorisation utilisateur via Homeassistant.
* Utilisable avec toute carte mère d'ordinateur (micro/mini)-ATX.

Vidéo Youtube :

[![Vidéo Youtube](https://img.youtube.com/vi/rAcvqaPf830/0.jpg)](https://www.youtube.com/watch?v=rAcvqaPf830)

Capture d'écran Homeassistant :

![Capture d'écran Home Assistant](https://raw.githubusercontent.com/Erriez/ESPHomePCPowerControlHomeAssistant/master/images/ScreenshotHomeAssistant.jpg)

## Différences avec le paquet magique Wake-On-Lan (WOL)

[Wake-On-Lan (WOL)](https://fr.wikipedia.org/wiki/Wake-on-LAN) est destiné à allumer un ordinateur à distance via Ethernet en envoyant un « paquet magique ». Cela présente plusieurs limitations connues qui ne s'appliquent pas à ce projet ESP :

* Wake-On-Lan (WOL) n'a **aucune autorisation** ! Le protocole WOL ne permet pas de fournir un mot de passe ni de restreindre l'accès à un ordinateur spécifique. Tout appareil sur le même LAN peut réveiller un PC en envoyant un paquet magique. L'ESP est protégé par mot de passe via Homeassistant.
* Wake-On-Lan (WOL) ne peut que `réveiller` un PC depuis un état suspendu ou éteint. Il n'y a pas de fonctionnalité d'arrêt/suspension.
* Pour mettre une machine Linux en état de `veille`, une connexion SSH au PC distant peut être établie par exemple en exécutant la commande `pm-suspend` (Installation via `sudo apt install pm-utils`), référence [Documentation Ubuntu pm-action](https://manpages.ubuntu.com/manpages/jammy/man8/pm-action.8.html). Inconvénients :
  * Nécessite une connexion SSH.
  * Nécessite des droits sudo.
* Les paquets magiques Wake-On-Lan sont ignorés lors de la première connexion de l'alimentation principale à l'alimentation, même lorsque le WOL est activé dans le BIOS. La raison est que le WOL est désactivé sur la plupart des ordinateurs au premier allumage et nécessite une activation par un système d'exploitation en fonctionnement avant que le PC ne réponde à un paquet magique pour le réveiller. Référence : [Ubuntu Wake-On-Lan](https://help.ubuntu.com/community/WakeOnLan).
* L'exécution de Wake-On-Lan [Wake-On-Lan](https://www.home-assistant.io/integrations/wake_on_lan) dans un conteneur Docker ne peut pas transmettre les paquets magiques broadcast avec une configuration réseau en pont. Cela nécessite un conteneur Docker externe en pont pour transmettre les paquets magiques et dépasse le cadre de Homeassistant. Ceci n'est actuellement pas inclus dans la documentation Homeassistant.

## Matériel

Le matériel se compose d'un ESP8266 ou ESP32 et de deux broches IO, montés sur une plaque métallique PCI (voir photo ci-dessous). Dans mon cas, j'ai utilisé une carte ESP8266 NodeMCU. Théoriquement, n'importe quelle carte ESP8266 ou ESP32 peut être utilisée pour ce projet.

* Une broche contrôle le bouton d'alimentation en générant une pression longue ou courte
* Une seconde broche lit l'état d'alimentation de la carte mère.

![Hardware](https://raw.githubusercontent.com/Erriez/ESPHomePCPowerControlHomeAssistant/master/images/NodeMCU.jpg)

## Schéma

Mon NAS est basé sur une carte mère Intel Core I7 ASRock Z97 ATX et contient des connecteurs mâles standard 2,5 mm 2x5 :

![Schematic](https://raw.githubusercontent.com/Erriez/ESPHomePCPowerControlHomeAssistant/master/images/Schematic.png)

**Connecteur ATX USB 2.0 :**

La broche 1 du connecteur `J1` fournit du +5V constant sur la broche 1, même lorsque le PC est éteint, et est utilisée pour alimenter le NodeMCU. L'ESP8266 ou ESP32 est alimenté via un régulateur 3V3 embarqué.

**Connecteur ATX panneau système :**

Le connecteur `J2` contient les broches power, reset et GND :

* Broche power bouton 6.
  * Pression courte : Allumer le PC ou générer un arrêt en douceur.
  * Pression longue : Générer une coupure d'alimentation forcée.
* Broche reset bouton 7.
  * Utilisée pour lire l'état d'alimentation via la broche reset :
    * Haut : alimentation activée
    * Bas : alimentation coupée
* Broche GND 5.

* La broche `D1` est utilisée pour lire l'état d'alimentation depuis la broche reset : Haut = allumé, Bas = éteint. La résistance `R1` est utilisée pour minimiser le courant lorsque la broche IO est accidentellement configurée en sortie.
* La broche `D2` est utilisée pour tirer le bouton power vers le bas afin de générer une pression courte ou longue. Le transistor `Q1` est utilisé pour une isolation sécurisée entre l'ESP8266 et la carte mère.

Attention : Toutes les broches ATX et ESP doivent fonctionner à 3V3.

## Téléchargements

* [Schéma KiCad .SCH](https://raw.githubusercontent.com/Erriez/ESPHomePCPowerControlHomeAssistant/master/kicad/ESP8266-ESPHome-PC-Power-HomeAssistant.pro)

## Câblage

![Câblage](https://raw.githubusercontent.com/Erriez/ESPHomePCPowerControlHomeAssistant/master/images/Wiring.jpg)

Un circuit imprimé de dérivation DIY peut être monté sur le connecteur du panneau système pour connecter le bouton d'alimentation `SW1` et le bouton de réinitialisation `SW2`.

## Stabilité du WiFi

Il y a suffisamment d'espace dans un boîtier d'ordinateur ATX pour monter la carte ESP. Cependant, le boîtier de l'ordinateur est blindé en métal, ce qui réduit la portée WiFi vers la station de base. Il est recommandé de placer l'ESP à l'extérieur du boîtier de l'ordinateur lorsque la connexion WiFi est instable ou la distance trop faible. Un ESP32 peut offrir une stabilité de connexion WiFi différente, mais cela dépend globalement de l'environnement.

Carte ESP8266 montée à l'arrière du boîtier PC :

![Montage ESP PC](https://raw.githubusercontent.com/Erriez/ESPHomePCPowerControlHomeAssistant/master/images/ESPMount.jpg)

## Mises à jour logicielles

Le firmware de l'application ESPHome peut être mis à jour via une connexion USB (port série virtuel) ou WiFi OTA (mise à jour Over The Air).

La mise à jour du firmware via WiFi est activée lors de la configuration de `ota` dans le fichier .yaml. Cela nécessite une connexion WiFi entre l'ordinateur hôte et l'ESP. La mise à jour OTA ne fonctionne pas lorsque la connexion de l'ESP à la station de base WiFi échoue en raison d'identifiants WiFi incorrects. Dans ce cas, une mise à jour via le port série est requise ou via un fallback `ap` comme configuré dans le fichier .yaml.

## ESPHome

L'application ESPHome se compose de deux fichiers Yaml. Un fichier de configuration et un second `secrets.yaml` pour stocker les mots de passe.

Documentation :

* [ESPHome GPIO Switch](https://esphome.io/components/switch/gpio.html)
* [ESPHome Binary Sensor](https://esphome.io/components/binary_sensor/gpio.html)

### Configuration du projet

Configurer les fichiers suivants :
- [pc-power.yaml](https://github.com/Erriez/ESPHomePCPowerControlHomeAssistant/blob/master/pc-power.yaml) : Configurer `platform` et `board`.
- [secrets.yaml](https://github.com/Erriez/ESPHomePCPowerControlHomeAssistant/blob/master/secrets.yaml) : Configurer le SSID WiFi et les mots de passe

Veuillez vous référer à la [documentation ESPHome](https://esphome.io/components/esphome.html) pour plus d'informations sur la configuration YAML ESPHome.


### Programmer ESP8266 ou ESP32

Connectez le câble USB à la carte ESP8266 ou ESP32 et saisissez les commandes suivantes. (Exemples testés sur Ubuntu). Pour plus d'informations, consultez [ESPHome.io](https://esphome.io/guides/getting_started_command_line.html).

```bash
# Clone this repository
$ git clone git@github.com:Erriez/ESPHomePCPowerControlHomeAssistant.git

# Install Python3 virtualenv
$ sudo apt install python3-virtualenv

# Create virtualenv
$ virtualenv venv

# Activate virtualenv
$ source venv/bin/activate

# Install ESPHome
$ pip install esphome

# Optional: Install platformio updates
$ platformio platform update
$ platformio upgrade

# Optional: Add user permission serial port
$ sudo usermod -a -G dialout <USERNAME>
$ sudo reboot now

# Check ESPHome installation
$ esphome --help

# Optional: Compile program without upload
$ esphome compile pc-power.yaml

# Upload program to ESP8266 or ESP32
$ esphome run pc-power.yaml

# Select serial port or WiFi to upload application

# Check logs
$ esphome logs pc-power.yaml
```

## Configuration de Home Assistant

Cette section décrit la configuration de Home Assistant.

### Enregistrer un appareil ESP

* `Configuration | Intégrations : Ajouter une intégration : ESPHome`
* Sélectionnez le nom d'hôte ou l'adresse IP de l'appareil ESP.
* Entrez le mot de passe tel que configuré dans `secrets.yml` | `esphome_api_password`.

### Homeassistant | Modifier le tableau de bord | Éditeur de configuration RAW

Ajouter l'intégration de l'alimentation du PC à un tableau de bord via l'édition brute :

```yaml
title: Home
views:
  - title: PC
    path: pc
    badges: []
    cards:
      - type: button
        entity: switch.pc_power_toggle
        show_name: true
      - type: button
        tap_action:
          action: none
        entity: binary_sensor.pc_power_state
        hold_action:
          action: none
      - type: button
        tap_action:
          action: toggle
        entity: switch.pc_hard_power_off
        icon_height: 40px
        show_state: false
        show_name: true
        show_icon: true
```

## Historique des versions

Redémarrez Home Assistant et c’est prêt à l’emploi !

### Mise à jour du 11 octobre 2024

Le format du fichier YAML ESPHome a changé avec [la version ESPHome 2024.6.0](https://esphome.io/changelog/2024.6.0.html#). L’ancien format génère des erreurs telles que :

```
$ esphome compile ESPHomePCPowerControlHomeAssistant/pc-power.yaml
INFO ESPHome 2024.9.2
INFO Reading configuration ESPHomePCPowerControlHomeAssistant/pc-power.yaml...
Failed config

ota.unknown: [source ESPHomePCPowerControlHomeAssistant/pc-power.yaml:27]

  'ota' requires a 'platform' key but it was not specified.

and:

Failed config

switch.gpio: [source ESPHomePCPowerControlHomeAssistant/pc-power.yaml:30]

  Pin 4 is used in multiple places.
```

Dans ce cas, veuillez mettre à jour vers le nouveau format de fichier dans ce projet.

### Mise à jour 13 février 2022

* Le minutage du bouton contrôlé via les scripts Homeassistant n'était pas stable. Le contrôle de la broche d'alimentation a été déplacé vers le firmware ESP qui génère un minutage beaucoup plus précis.
* Renommé les noms suivants :
  * Renommer `switch.pc_power_button` en `switch.pc_power_toggle`.
  * Renommer `switch.pc_power_button_long_press` en `switch.pc_hard_power_off`.
  * Renommer `switch.pc_power_sense` en `switch.pc_power_state`.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-25

---
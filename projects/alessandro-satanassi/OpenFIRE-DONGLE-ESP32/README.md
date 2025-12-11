## OpenFIRE-DONGLE for EPS32


![foto_dongle](https://github.com/user-attachments/assets/a38d7390-f7e7-42d7-844c-ad8388670f6d)



https://github.com/user-attachments/assets/70a193a0-686e-4da3-8d30-f0067de6b63c



Questo repository è stato creato per essere utilizzato insieme al codice del progetto OpenFIRE-Firmware-ESP32, un porting del progetto originale 'OpenFIRE-firmware' del TeamOpenFIRE, adattato per funzionare sul microcontrollore ESP32S3.
Il progetto, sviluppato utilizzando PlatformIO, rappresenta il firmware per un ESP32S3 da usare come dongle collegato al PC, al fine di abilitare una connessione wireless tramite il protocollo ESP-NOW di ESP32. Questo dongle è progettato per essere usato in combinazione con il firmware 'OpenFIRE-Firmware-ESP32', da installare sulla lightgun.
Il codice è strutturato per rilevare automaticamente le lightgun e configurarsi in modo autonomo.
La trasmissione tra lightgun e dongle è bidirezionale, consentendo di utilizzare la lightgun come se fosse connessa direttamente al PC via USB.
Il PC non rileva alcuna differenza tra una connessione diretta tramite USB e una connessione wireless tramite dongle.
Desidero esprimere la mia sincera gratitudine al TeamOpenFIRE per la creazione del progetto 'OpenFIRE': tutti i meriti e la mia piena riconoscenza vanno a loro.
Una piccola parte del codice è stata estratta e modificata dal repository "SerialTransfer": https://github.com/PowerBroker2/SerialTransfer.git.
Desidero pertanto ringraziare anche l'autore di tale codice, PowerBroker2, per il suo contributo.


This repository was created to be used together with the code from the OpenFIRE-Firmware-ESP32 project, a porting of the original 'OpenFIRE-firmware' project by TeamOpenFIRE, adapted to work on the ESP32S3 microcontroller.
The project, developed using PlatformIO, serves as the firmware for an ESP32S3 to be used as a dongle connected to the PC, enabling wireless connectivity through the ESP-NOW protocol of ESP32. This dongle is designed to be used in combination with the firmware 'OpenFIRE-Firmware-ESP32', which is installed on the lightgun.
The code is structured to automatically detect lightguns and configure itself independently.
The communication between the lightgun and the dongle is bidirectional, allowing the lightgun to function as if it were directly connected to the PC via USB.
The PC does not notice any difference between a direct USB connection and a wireless connection through the dongle.
I would like to express my sincere gratitude to TeamOpenFIRE for creating the 'OpenFIRE' project; all credit and my deepest appreciation go to them.
A small portion of the code was taken and modified from the repository "SerialTransfer": https://github.com/PowerBroker2/SerialTransfer.git.
I would therefore like to thank the author of this code, PowerBroker2, for their contribution.


## ... segue la pagina originale del progetto 'OpenFIRE-firmware' del TeamOpenFIRE
## ... follows the original project page 'OpenFIRE-firmware' project by TeamOpenFIRE

### Like our work? [Remember to support the developers!](https://github.com/TeamOpenFIRE/.github/blob/main/profile/README.md)

![BannerDark](https://raw.githubusercontent.com/alessandro-satanassi/OpenFIRE-DONGLE-ESP32/main/docs/of_bannerLoD.png#gh-dark-mode-only)![BannerLight](https://raw.githubusercontent.com/alessandro-satanassi/OpenFIRE-DONGLE-ESP32/main/docs/of_bannerDoL.png#gh-light-mode-only)
# OpenFIRE - The Open *Four Infa-Red Emitter* Light Gun System
###### Successor to [IR-GUN4ALL](http://github.com/SeongGino/ir-light-gun-plus), which is based on the [Prow Enhanced fork](https://github.com/Prow7/ir-light-gun), which in itself is based on the 4IR Beta "Big Code Update" [SAMCO project](https://github.com/samuelballantyne/IR-Light-Gun)

## Features:
- **Fully featured peripherals**, from Solenoid & Rumble Force Feedback, to TMP36 Temperature Monitoring, and others to come.
- **Multiple IR layouts support**, with *realtime perspective-adjusted tracking* for both double lightbar (recommended!) and Xwiigun-like diamond layouts (compatible with other systems).
- **Flexible Input System**, with outputs to Keyboard, 5-button ABS(olute Positioning) Mouse, and dual-stick gamepad w/ d-pad support, with a **robust button mapping system** to suit your needs!
- **Easy installation** with simple *.UF2* binaries that can be drag'n'dropped directly onto an *RP2040*-based Microcontroller.
- **Portable on-board settings** to store calibration profiles, toggles, settings, USB identifier, and more.
- **Integrates with the [OpenFIRE App](https://github.com/TeamOpenFIRE/OpenFIRE-App)** for user-friendly, and cross-platform on-the-fly configuration.
- **Optimized for the RP2040**, using its second core for input polling & queuing and serial handling, and the main core for camera and peripherals processing, whenever possible.
- **Compatible with PC Force Feedback handlers** such as [Mame Hooker](https://dragonking.arcadecontrols.com/static.php?page=aboutmamehooker), [The Hook Of The Reaper](https://github.com/6Bolt/Hook-Of-The-Reaper), and [QMamehook](https://github.com/SeongGino/QMamehook).
- **Supports integrated OLED display output** for *SSD1306 I2C displays* for menu navigation and visual feedback of game elements such as life and current ammo counts.
- **Compatible with the MiSTer FPGA ecosystem**, with dedicated mappings to streamline the user experience as much as possible.
- **Forever free and open source to the lightgun community!**

___
## Thanks:
* Samuel Ballantyne, for his original SAMCO project, the gorgeous OpenFIRE branding, and perspective-based tracking system.
* Prow7, for his enhanced SAMCO fork which provided the basis of pause mode and saving subsystems.
* Odwalla-J, mrkylegp, RG2020 & lemmingDev for prerelease consultation, bug testing and feedback.
* The IR-GUN4ALL testers for their early feedback and feature requests - this wouldn't have happened without you lot!
* Chris Young for his TinyUSB compatible library (now part of `TinyUSB_Devices`).

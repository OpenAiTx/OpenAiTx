usb-gadget
==========

[![page crates.io](https://img.shields.io/crates/v/usb-gadget)](https://crates.io/crates/usb-gadget)
[![page docs.rs](https://docs.rs/usb-gadget/badge.svg)](https://docs.rs/usb-gadget)
[![licence Apache 2.0](https://img.shields.io/crates/l/usb-gadget)](https://github.com/surban/usb-gadget/blob/master/LICENSE)

Cette bibliothèque permet l’implémentation de périphériques USB, appelés **gadgets USB**,
sur des appareils Linux disposant d’un contrôleur de périphérique USB (UDC).
Sont supportées à la fois des fonctions USB pré-définies et des implémentations entièrement personnalisées de l’interface USB.

Les fonctions USB pré-définies suivantes, implémentées par des pilotes du noyau, sont disponibles :

* interface réseau
    * CDC ECM
    * CDC ECM (sous-ensemble)
    * CDC EEM
    * CDC NCM
    * RNDIS
* port série
    * CDC ACM
    * générique
* périphérique d’interface humaine (HID)
* périphérique de stockage de masse (MSD)
* périphérique imprimante
* interface numérique d’instrument de musique (MIDI)
* périphérique audio (UAC1 et UAC2)
* périphérique vidéo (UVC)

De plus, des fonctions USB entièrement personnalisées peuvent être implémentées en Rust en mode utilisateur.

Le support des descripteurs spécifiques au système d’exploitation et de WebUSB est également fourni.

Outil CLI
--------

L’outil CLI `usb-gadget` permet de configurer des gadgets USB à partir de fichiers de configuration TOML
sans écrire de code Rust.


### Installation

    cargo install usb-gadget --features cli

### Utilisation

Créez un fichier de configuration TOML décrivant votre gadget, puis utilisez la CLI pour le gérer :

    usb-gadget up gadget.toml       # enregistrer et lier un gadget
    usb-gadget list                 # lister les gadgets enregistrés
    usb-gadget down my-gadget       # supprimer un gadget par nom
    usb-gadget down --all           # supprimer tous les gadgets
    usb-gadget check gadget.toml    # valider un fichier de configuration

Vous pouvez également passer un répertoire à `up` ou `check` pour traiter tous les fichiers `.toml` qu’il contient.

### Exemple de configuration

```toml
name = "serial-debug"

[device]
vendor = 0x1209
product = 0x0002
manufacturer = "Example Inc."
product_name = "Debug Console"
serial = "0001"

[[config]]
description = "Serial Config"

[[config.function]]
type = "serial"
class = "acm"
```

Plusieurs fonctions peuvent être combinées dans un seul gadget en ajoutant davantage d’entrées `[[config.function]]`. Exécutez `usb-gadget template --list` pour voir tous les modèles disponibles.

Fonctionnalités
---------------

Cette crate propose les fonctionnalités optionnelles suivantes :

* `cli` : construit l’outil CLI `usb-gadget` pour configurer les gadgets à partir de fichiers TOML.
* `tokio` : active la prise en charge asynchrone pour les fonctions USB personnalisées sur la base du runtime Tokio.

Exigences
---------

La version minimale de Rust prise en charge (MSRV) est la 1.77.

Un contrôleur de périphérique USB (UDC) pris en charge par Linux est requis. En général, les PC standard *ne* comprennent *pas* d’UDC.
Un Raspberry Pi 4 contient un UDC, qui est connecté à son port USB-C.

Les options de configuration du noyau Linux suivantes doivent être activées pour une fonctionnalité complète :

  * `CONFIG_USB_GADGET`
  * `CONFIG_USB_CONFIGFS`
  * `CONFIG_USB_CONFIGFS_SERIAL`
  * `CONFIG_USB_CONFIGFS_ACM`
  * `CONFIG_USB_CONFIGFS_NCM`
  * `CONFIG_USB_CONFIGFS_ECM`
  * `CONFIG_USB_CONFIGFS_ECM_SUBSET`
  * `CONFIG_USB_CONFIGFS_RNDIS`
  * `CONFIG_USB_CONFIGFS_EEM`
  * `CONFIG_USB_CONFIGFS_MASS_STORAGE`
  * `CONFIG_USB_CONFIGFS_F_FS`
  * `CONFIG_USB_CONFIGFS_F_HID`
  * `CONFIG_USB_CONFIGFS_F_PRINTER`
  * `CONFIG_USB_CONFIGFS_F_MIDI`
  * `CONFIG_USB_CONFIGFS_F_UAC1`
  * `CONFIG_USB_CONFIGFS_F_UAC2`
  * `CONFIG_USB_CONFIGFS_F_UVC`



Les permissions root sont requises pour configurer les gadgets USB sous Linux et
le système de fichiers `configfs` doit être monté.


Licence
-------

usb-gadget est sous licence [Apache 2.0].

[Apache 2.0 license]: https://github.com/surban/usb-gadget/blob/master/LICENSE

### Contribution

Sauf indication explicite contraire de votre part, toute contribution soumise
intentionnellement pour inclusion dans usb-gadget par vous, sera sous licence Apache 2.0, sans
termes ou conditions supplémentaires.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-27

---
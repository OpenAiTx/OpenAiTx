# Ethereal

Un système d'exploitation tout-en-un personnalisé, conçu pour la rapidité, la conservation de la mémoire et la fiabilité.\
Anciennement connu sous le nom de reduceOS

## Qu'est-ce qu'Ethereal ?

Ethereal est un projet ayant pour objectif de créer un système d'exploitation entièrement fonctionnel à partir de zéro avec tous les composants qu'un OS moderne posséderait.

Actuellement, le projet développe ses étapes en mode utilisateur.

## Captures d'écran

<img width="1925" height="1078" alt="image" src="https://github.com/user-attachments/assets/5f5725af-de16-43bf-9217-6db994f9ff2e" />\
*Environnement de bureau moderne en 1080p*

<img width="1040" height="799" alt="image" src="https://github.com/user-attachments/assets/06835253-90cd-4785-a0f8-9f0042ac3676" />\
*Ancien environnement principal de bureau d'Ethereal avec DOOM*

![](https://preview.redd.it/ethereal-smp-enabled-usb-supporting-multitasking-kernel-v0-ygmgdlm3dowe1.png?width=1620&format=png&auto=webp&s=0473ac09024c17cefb294c8570671e415866b915)\
*Ethereal démarrant en mode débogage*

![Ethereal mais VRAIMENT sur IRC](https://github.com/user-attachments/assets/fedac2c5-db99-463f-88d9-44b1a239dcdd)\
*Ethereal sur le chat Libera (#ethereal)*

![](https://preview.redd.it/ethereal-smp-enabled-usb-supporting-multitasking-kernel-v0-ahe88a85dowe1.png?width=682&format=png&auto=webp&s=b435a1e0d57a91b7d4e0479f9649960b74a22de7)\
*Ethereal exécutant DOOM*

![fixé](https://github.com/user-attachments/assets/bfdce356-5555-436b-990d-3aad65d22dea)\
*Ethereal exécutant un clone de neofetch fait pour lui (whatarewe)*

## Fonctionnalités

- Noyau complet avec prise en charge SMP
- Gestionnaire de fenêtres personnalisé (Celestial)
- Support USB pour les contrôleurs UHCI/EHCI/xHCI
- Support AHCI/IDE
- Pile réseau avec pilotes de carte réseau E1000 et RTL8139
- Ordonnanceur round-robin basé sur les priorités avec une API bien testée
- Support pour la bibliothèque C `mlibc` et sa grande variété de fonctions
- Support complet ACPI avec la bibliothèque ACPICA (avec en secours la bibliothèque MinACPI qui ne fait pas d’analyse AML)

## Structure du projet

- `base` : Contient le système de fichiers de base. Les fichiers dans `base/initrd` vont dans le ramdisk initial (pour les démarrages non LiveCD) et les fichiers dans `base/sysroot` vont dans le sysroot.
- `buildscripts` : Contient les scripts de construction pour le système de build
- `conf` : Contient divers fichiers de configuration, tels que les fichiers d’architecture, les configs GRUB, fichiers de démarrage supplémentaires, etc.
- `drivers` : Pilotes pour Hexahedron, copiés selon leur configuration.
- `external` : Contient des projets externes, comme ACPICA. Voir Composants Externes.
- `hexahedron` : Le projet principal du noyau
- `libkstructures` : Contient diverses structures noyau, comme listes/cartes de hachage/analyseurs/quoi que ce soit
- `libc` : Contient mlibc

## Compilation


### Avis ACPICA

Si vous utilisez ACPICA (activé par défaut), vous devez télécharger l’archive depuis [ici](https://downloadmirror.intel.com/834974/acpica-unix-20240927.tar.gz) et l’extraire dans `external/acpica/acpica-src`

Sinon, vous pouvez modifier `conf/build/<arch>.mk` et régler `USE_ACPICA` à 0.  

### Compilation

Pour compiler Ethereal, vous aurez besoin d’une chaîne d’outils Ethereal pour votre architecture cible.\
La chaîne d’outils Ethereal se trouve sur [le dépôt](https://github.com/sasdallas/Ethereal-Toolchain)

Autres paquets requis : `grub-common`, `xorriso`, `qemu-system`, `meson`, `ninja`

Modifiez `buildscripts/build-arch.sh` pour changer l’architecture cible de compilation. \
L’exécution de `make all` construira une ISO dans `build-output/ethereal.iso`

Actuellement, l’absence de pilotes systèmes de fichiers dans Ethereal signifie que les démarrages LiveCD sont généralement la meilleure option.\
Le ramdisk initial dans un LiveCD est le sysroot, et si l’OS détecte le démarrage, il copiera le ramdisk initial en RAM.

## Arguments du noyau

Souvent, Ethereal ne parvient pas à se charger. C’est prévu. Veuillez ouvrir un ticket GitHub.

Vous pouvez résoudre certains problèmes en utilisant 'e' pour ouvrir une configuration GRUB et en ajoutant quelques arguments du noyau à la fin de l’`entrée multiboot`.\
Voici une petite liste :

- `--debug=` : Les options sont `console` et `none`. Si `console`, redirige la sortie de débogage du noyau vers l'écran. Utile pour le débogage
- `--noload=` : Liste séparée par des virgules des pilotes (.sys) à ne pas charger. Pilotes problématiques : usb_xhci.sys, ahci.sys, ps2.sys (si vous ne supportez pas PS/2),
- `--no-acpica` : Désactive la bibliothèque ACPICA et revient à l’implémentation MinACPI. Utile uniquement dans des cas extrêmes.
- `--no-acpi` : Désactive toutes les implémentations ACPI. Désactive également le SMP.
- `--disable-smp` : Active ACPI, mais désactive le SMP
- `--disable-cow` : Désactive le copy-on-write. Non recommandé, mais peut être utile dans des cas extrêmes.
- `--no-psf-font` : Ne pas charger la police PSF depuis l’initrd

## Composants externes
Certains composants externes sont disponibles dans `external`, `libc` et d’autres parties du noyau. Voici une liste d’entre eux et leurs versions :
- ACPICA UNIX* (Licence Intel) : Version 20240927 [disponible ici](https://www.intel.com/content/www/us/en/developer/topic-technology/open/acpica/download.html)
- bibliothèque math libmusl (Licence MIT) : [disponible ici](https://github.com/kraj/musl)
- freetype (Licence GPL) : [disponible ici](https://sourceforge.net/projects/freetype/)
- mlibc (Licence MIT) : [Fork Ethereal disponible ici](https://github.com/sasdallas/mlibc)
- tinf (Licence zlib) : [disponible ici](https://github.com/jibsen/tinf/)
- json-parser (Licence BSD 2-clause) : [disponible ici](https://github.com/json-parser/json-parser)
- PlutoSVG (Licence MIT) : [disponible ici](https://github.com/sammycage/plutosvg)

## Crédits

Une grande partie de la conception d’Ethereal s’est inspirée de [ToaruOS par klange](https://github.com/klange/ToaruOS) – merci !

La conception du gestionnaire de mémoire virtuelle d’Ethereal et d’autres parties s’est inspirée de [Astral par @mathewnd](https://github.com/mathewnd/Astral)

Du code d’Astral a également été utilisé, crédité lorsque cela est approprié. Un fichier de licence est inclus dans `external/`.

Le logo Ethereal et le thème Mercury ont été conçus par l’artiste [ArtsySquid](https://artsycomms.carrd.co)

## Licence

Hexahedron et tous les autres composants non externes d’Ethereal sont soumis aux termes de la licence BSD 3-clause (disponible dans LICENSE).\
Tous les fichiers, sauf indication contraire dans l’en-tête de copyright, sont soumis à cette licence. Tout fichier sans en-tête de copyright n’est PAS protégé par la BSD 3-clause.

**PROBLÈMES DE LICENCE :** Si un fichier est trouvé sans commentaire approprié, contactez-moi immédiatement (de préférence via un canal public tel que les issues GitHub pour plus de transparence) directement afin de résoudre cela.

L’objectif d’Ethereal n’a **JAMAIS** été de prendre du code, mais cela s’est produit dans le passé. Veuillez me contacter !

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-23

---
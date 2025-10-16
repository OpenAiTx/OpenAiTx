[![Build](https://github.com/alexVinarskis/dell-powermanager/actions/workflows/build.yml/badge.svg?branch=master)](https://github.com/alexVinarskis/dell-powermanager/actions/workflows/build.yml)
[![GitHub release (with filter)](https://img.shields.io/github/v/release/alexVinarskis/dell-powermanager?label=Release)](https://github.com/alexVinarskis/dell-powermanager/releases/latest)
![GitHub all releases](https://img.shields.io/github/downloads/alexVinarskis/dell-powermanager/total?label=Downloads)

# Dell Power Manager
Réimplémentation multiplateforme de Dell Power Manager en Flutter. Plus de captures d’écran dans le [Wiki](https://github.com/alexVinarskis/dell-powermanager/wiki).

![Screenshot Summary](https://raw.githubusercontent.com/alexVinarskis/dell-powermanager/master/images/screenshot_summary.png)

## Pourquoi
Les machines Dell (ordinateurs portables des séries XPS et Precision, potentiellement d’autres) offrent des options avancées configurables dans le BIOS, telles que plusieurs profils thermiques, des seuils de charge de la batterie, etc. Il peut être très souhaitable de les ajuster à la volée, et il n’existe aucun moyen de les configurer depuis le système d’exploitation sans les outils propriétaires de Dell (heureusement fournis). Les réglages peuvent être modifiés via :
* Le BIOS directement, nécessite un redémarrage
* [Dell Command | Configure](https://www.dell.com/support/kbdoc/en-us/000178000/dell-command-configure) CLI, disponible sous Windows et Linux, avec une impressionnante [liste de capacités](https://dl.dell.com/topicspdf/command-configure_reference-guide4_en-us.pdf).
* [Dell Power Manager](https://www.dell.com/support/contents/en-au/article/product-support/self-support-knowledgebase/software-and-downloads/dell-power-manager) interface graphique, disponible uniquement sous Windows. De plus, il est ridiculement lent à démarrer, et (subjectivement) laid.

Cette application est une interface graphique moderne basée sur Flutter, construite sur Dell Command | Configure CLI, avec pour objectif principal de reproduire le comportement de Dell Power Manager pour les utilisateurs Linux, tout en fonctionnant aussi sous Windows.

## Fonctionnalités
* Contrôle via 'Dell Command | Configure CLI' (CCTK)
* Interface utilisateur moderne animée, supporte le mode sombre
* Démarrage rapide, beaucoup plus rapide que l’application Windows de Dell
* Détection et gestion des modes non supportés sur les machines compatibles
* Détection des machines non Dell, affiche un message d’erreur
* Support du BIOS protégé (mots de passe Système/Setup/Propriétaire), et sauvegarde sécurisée des clés

Pour Linux Debian/Ubuntu et Windows, l’application est légèrement plus packagée :
* Téléchargeur et installateur de dépendances intégrés
* Emballée au format `.deb`/`.msi`, avec raccourcis dans le menu démarrer, etc.
* Mise à jour OTA intégrée via l’API Github

Fonctionnalités de contrôle :
* Vue d’ensemble de l’état de la batterie (santé, etc.)
* Contrôle de la charge de la batterie (sans mode avancé/de timing journalier pour l’instant)
* Contrôle des profils thermiques
* Détection du mode d’alimentation du système d’exploitation

TODO prévus :
* Contrôle/programmation avancée de la charge de batterie ([Demande de fonctionnalité](https://github.com/alexVinarskis/dell-powermanager/issues/24))
* Contrôle du "Peak Shift" ([Demande de fonctionnalité](https://github.com/alexVinarskis/dell-powermanager/issues/57))

Fonctionnalités futures potentielles à considérer :
* Ajouter un service de surveillance pour le changement automatique des profils thermiques en fonction de la charge CPU
* Ajouter un service de surveillance pour le changement automatique des profils thermiques en fonction des paramètres d’alimentation, par ex. niveau de batterie, branchement/débranchement, etc.

## État du développement
L’application est actuellement en état **stable, maintenue**.

* Intégration du CCTK de Dell (avec installateur automatisé pour certains OS)
* Vérifications de mise à jour implémentées (avec OTA via l’API Github pour certains OS)
* UI testée, build et packaging validés par CI
* Emballé en `.msi`, `.deb`, `.tar.xz`. Obtenez la dernière version stable sur [Releases](https://github.com/alexVinarskis/dell-powermanager/releases/latest), ou la dernière version de développement sur [CI artifacts](https://github.com/alexVinarskis/dell-powermanager/actions/workflows/build.yml?query=branch%3Amaster)
* Testé sur plusieurs plateformes, voir [Compatibilité](#compatibility). Supporté sur :
    * Windows, x86_64 (Native `.msi`)
    * Windows, arm64 (x64_86 `.msi` fonctionnant en émulation)
    * Linux, x86_64 (Native `.deb`, `.tar`)
    * Linux, arm64* (Native `.deb`, `.tar`) _Seule la partie info batterie fonctionne - pas le contrôle réel car CCTK de Dell n’est pas disponible pour arm64 (pour l’instant ?)_
## Compilation depuis la source
### Linux
* Installer les dépendances :
```
sudo apt-get install -y ninja-build libgtk-3-dev libsqlite3-dev libsecret-1-0 libsecret-1-dev
```
* Exécutez depuis la source via `flutter run`, construisez via `flutter build linux --release`
* Emballez en `.deb`, `.tar.xz` via `./package.sh`

ATTENTION : ne _pas_ installer flutter via `snap`, préférez une [installation native](https://docs.flutter.dev/get-started/install/linux/desktop) – flutter fourni par snap échouera à compiler ce projet à cause de [problèmes spécifiques à snap](https://github.com/juliansteenbakker/flutter_secure_storage/issues/676).

### Windows
* Exécutez depuis la source via `flutter run`, construisez via `flutter build windows --release`
* Emballez en `.msi` via `.\package.bat`

## Contribution

### Débogage

Par défaut, tous les logs sont supprimés. Exportez `POWERMANAGER_DEBUG=true` avant d’exécuter l’application depuis la CLI pour obtenir les logs.
Ex. : `export POWERMANAGER_DEBUG=true && ./dell-powermanager > file.log`. Lors de l’ouverture d’un ticket, veuillez sauvegarder et joindre le log.

### Traductions
L’application supporte plusieurs langues via la bibliothèque de localisation de Flutter. Si vous souhaitez contribuer :
* Consultez les fichiers [lib/l10n/*.arb](https://raw.githubusercontent.com/alexVinarskis/dell-powermanager/master/lib/l10n/app_en.arb).
* Créez un fichier similaire pour votre langue, traduisez les chaînes.
* Ouvrez une PR avec vos modifications.

## Compatibilité
Testé sur les appareils suivants :
* Dell G3 15 3500
    * [Windows 11 24H2 (OS Build 26100.4061)](https://github.com/alexVinarskis/dell-powermanager/issues/65)
* Dell Latitude 5400
    * [Ubuntu 24.04](https://github.com/alexVinarskis/dell-powermanager/issues/56)
* Dell Precision 7560
    * [Fedora 41, 6.12.4](https://github.com/alexVinarskis/dell-powermanager/issues/47)
* Dell XPS 17 9700
    * [Tumbleweed OpenSUSE, 6.7.5](https://github.com/alexVinarskis/dell-powermanager/issues/31)
* Dell XPS 15 9560
    * [Arch Linux, 6.11.6-arch1-1](https://github.com/alexVinarskis/dell-powermanager/issues/46)
* Dell XPS 15 9530 (2023/Fiorano)
    * Ubuntu 23.04, 6.5.0-060500-generic
    * Ubuntu 23.10, 6.5.0-060500-generic
    * Windows 11 Pro 22H2, 22621.2428
* Dell XPS 15 9520
    * [Arch, 6.7.5](https://github.com/alexVinarskis/dell-powermanager/issues/31)
    * Ubuntu 22.04, 6.2.0
    * Windows 11 Home 22H2, 22621.2428
* Dell XPS 13 9345 (Tributo)
    * Ubuntu 24.10, 6.12.0-28-qcom-x1e (informations batterie uniquement)
    * Windows 11 pro
* Dell XPS 13 9310
    * Ubuntu 22.04.3, 6.2.0-26-generic
    * Windows 10 pro 22H2, 19045.3324
* Dell Vostro 5401
    * [Ubuntu 23.10](https://github.com/alexVinarskis/dell-powermanager/issues/23) 

Si vous avez rencontré des problèmes avec l’un des appareils mentionnés ci-dessus, veuillez ouvrir un [**Rapport de bug**](https://github.com/alexVinarskis/dell-powermanager/issues/new?template=bug_report.md&title=[BUG]). Si vous l’avez testé sur d’autres appareils, veuillez signaler un [**Appareil testé**](https://github.com/alexVinarskis/dell-powermanager/issues).

## Problèmes connus
Veuillez consulter les [issues](https://github.com/alexVinarskis/dell-powermanager/issues).
## Crédits
* Dell pour avoir fourni 'Dell Command | Configure CLI'
* Google pour avoir créé Flutter :)

## Avertissement
Conformément à la licence, ce logiciel est fourni tel quel, sans aucune garantie. Il n’est en aucun cas affilié à Dell. Utilisez-le à vos risques et périls. Ni moi ni aucun autre contributeur ne sommes responsables des dommages causés par ce logiciel, y compris mais sans s’y limiter la perte de données, les dommages matériels, les violations de données, etc. Lorsque cela est applicable, une solution intégrée pour la sauvegarde sécurisée des clés est utilisée, mais sa sécurité n’est en aucun cas garantie. Comprenez les risques et implications avant de l’utiliser. Aucune réclamation juridique ne peut être faite contre l’auteur ou les contributeurs.

## Licence
Cette application est sous licence GPLv3. En bref, cela signifie que vous pouvez l’utiliser/copier/modifier/distribuer gratuitement, mais vous devez fournir le code source de vos modifications et conserver la même licence. Vous ne pouvez pas la vendre en tant que logiciel propriétaire. Voir [LICENSE](LICENSE) pour les détails.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---
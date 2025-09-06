[![Pré-Version](https://img.shields.io/github/v/tag/till213/skydolly?include_prereleases&label=Pre-Release)](https://github.com/till213/skydolly/releases)
![Licence : MIT](https://img.shields.io/badge/%E2%9A%96%EF%B8%8F%20License-MIT-brightgreen)
![C++20](https://img.shields.io/badge/C%2B%2B-20-%2300599C?logo=cplusplus)
![Compilateurs supportés](https://img.shields.io/badge/%E2%9A%99%EF%B8%8F%20Compilers-GCC%2C%20clang%2C%20MSVC-informational)

![Tests unitaires](https://github.com/till213/SkyDolly/actions/workflows/unit-tests.yml/badge.svg?event=push)

# Sky Dolly
Sky Dolly - Le mouton noir pour vos enregistrements de vol.

## À propos
Sky Dolly se connecte à une instance en cours de Flight Simulator 2020 et enregistre diverses variables de simulation, pour la lecture.

![Sky Dolly v0.11.0](https://raw.githubusercontent.com/till213/SkyDolly/main/./img/SkyDolly-v0.11.0.png)

La connexion se fait via SimConnect, une API standard introduite avec Flight Simulator X pour se connecter au simulateur de vol.

Voir aussi le [ABOUT.md](https://raw.githubusercontent.com/till213/SkyDolly/main/ABOUT.MD).

## Fonctionnalités
- Enregistrer / Pause / Lecture
- Vols en formation (plusieurs avions, lecture pendant l'enregistrement, "voler en formation", décalage temporel)
- Taux d’échantillonnage d’enregistrement réglable : fixe ou variable ("auto")
- Vitesse de lecture ajustable ("ralenti", "accéléré"), boucle de lecture
- Position, vitesse et variables de simulation de contrôle de vol de base (ailerons, gouvernail, volets, trains d’atterrissage, ...) sont enregistrés
- Architecture de plugin avec divers plugins d’import/export (CSV, GPX, IGC, KML)
- Module de localisation avec plus de 100 emplacements par défaut et fonction d’import/export
- Persistance basée sur une base de données (SQLite) ("carnet de vol")

Regardez la bande-annonce (preview) sur [YouTube](https://www.youtube.com/watch?v=_n4qRtm78_I) :

[![Sky Dolly - Enregistreur et lecture de vol pour Flight Simulator 2020 (Bande-annonce cinématique)](https://img.youtube.com/vi/_n4qRtm78_I/0.jpg)](https://www.youtube.com/watch?v=_n4qRtm78_I "Sky Dolly - Enregistreur et lecture de vol pour Flight Simulator 2020 (Bande-annonce cinématique)")

Pour plus de vidéos créées avec Sky Dolly, voir aussi [SHOWCASE](https://raw.githubusercontent.com/till213/SkyDolly/main/SHOWCASE.md). Les nouveautés et fonctionnalités à venir sont listées dans le [CHANGELOG](https://raw.githubusercontent.com/till213/SkyDolly/main/CHANGELOG.md).

## Utilisation de base

- Démarrer un vol
- Cliquer sur "Enregistrer" (touche R)
- Vous pouvez mettre en pause l’enregistrement (touche P)
- Arrêtez l'enregistrement (touche R) et cliquez sur "Lecture" (barre d'espace)
- Ajustez la vitesse de relecture et recherchez la position de lecture, même pendant la relecture
- Les vols enregistrés sont automatiquement sauvegardés dans le "carnet de vol"
- Sélectionnez un vol dans le carnet de vol et appuyez sur "Charger" (ou double-cliquez sur la ligne) pour charger le vol sauvegardé

### Enregistrement & Relecture de Formation

#### Enregistrement

- Passez au module "Formation" (touche F2)
- Cliquez sur "Enregistrer" (touche R)
- Chaque avion enregistré est ajouté au vol en cours
- Pendant que les avions existants sont rejoués durant l'enregistrement avec un taux d'échantillonnage "auto", vous pouvez toujours changer ce taux d'enregistrement

#### Position

- Le dernier avion enregistré devient "l'avion utilisateur" (suivi par la caméra dans le simulateur de vol)
- Sélectionnez une position relative à l'"avion utilisateur" actuel avant l'enregistrement

#### Relecture

- Cliquez simplement sur "Lecture", "Pause" et naviguez dans la timeline, comme pour un vol d'un seul avion
- Changez l'"avion utilisateur" (même pendant la relecture) pour "sauter de cockpit en cockpit"
- Prenez le contrôle de "l'avion utilisateur" en sélectionnant soit "Prendre le contrôle" soit "Voler avec la Formation"

#### Gestion des Formations

- Vous pouvez supprimer un seul avion d'un vol ("formation")
- Il doit y avoir au moins un avion par vol, donc le dernier avion ne peut pas être supprimé
- Ajoutez un décalage temporel à l'avion sélectionné ("synchronisation de vol en formation multijoueur")
- Pour commencer un nouveau vol avec un seul avion, revenez au module "Carnet de vol" (touche F1) et cliquez sur "Enregistrer" (touche R)

Pourquoi ne pas essayer avec une des ["Tell Tours"](https://github.com/till213/Tell-Tours) guidées ? :)

## Télécharger

Allez sur [Releases](https://github.com/till213/SkyDolly/releases) et téléchargez la dernière version.

Dernière version (pré-)release : **Sky Dolly 0.19.2**

Calculez et comparez votre somme de contrôle avec les [sommes de contrôle SHA-256 publiées](https://raw.githubusercontent.com/till213/SkyDolly/main/SHASUM256.md), pour vérifier l'intégrité de votre copie téléchargée.

## Compilation

Référez-vous à la documentation [BUILD](https://raw.githubusercontent.com/till213/SkyDolly/main/BUILD.md).

## Projets Associés

- https://github.com/nguyenquyhy/Flight-Recorder - Une application d'enregistrement et de relecture de vol basée sur .Net
- https://github.com/saltysimulations/saltyreplay/ - Enregistrement et relecture avec une interface utilisateur web
- https://github.com/SAHorowitz/MSFS2020-PilotPathRecorder - Enregistre le vol et génère des "relectures" Google Earth (format KML)
- https://github.com/Elephant42/FS_Tool - Un outil simple permettant de définir la position de l'avion et le taux de simulation
- https://github.com/pyviator/msfs-geoshot - Prend des captures d'écran et les "géolocalise" automatiquement
- https://github.com/ijl20/msfs_logger_replay - Enregistreur IGC et relecture (pour FSX)
- https://joinfs.net/ - Permet de synchroniser des vols multijoueurs entre différents simulateurs de vol (MSFS, Prepar3D/FSX, XPlane). Fournit également un enregistreur de vol avec enregistrement en formation ("overdub").
- https://github.com/paulalexandrow/a32nx-webremote - WebRemote pour FlyByWire's A32NX : contrôle des fonctionnalités du cockpit du FBW A320, utilisant FSUIPC7
- https://flightloganalyzer.com/ - FlightLog Analyzer analyse le carnet de vol MSFS et propose une exportation CSV lisible par Sky Dolly
- https://github.com/BojoteX/FSAutoSave/ - FSAutoSave enregistre automatiquement (ou sur demande) les plans de vol
- https://github.com/mracko/MSFS-Landing-Inspector - Analyse votre performance d'atterrissage
- [Points d'intérêt (Google Maps)](https://www.google.com/maps/d/viewer?mid=1KUg5jwyT_9k2A9n5IZ99UChlhfVUfO5S&ll=-3.81666561775622e-14%2C-23.028915134521867&z=1) - Points d'intérêt, aéroports et villes 3D dans Microsoft Flight Simulator.

## Autres Ressources Utiles

- https://obsproject.com/ - Application de capture d'écran / diffusion
- https://sqlitebrowser.org/ - Parcourez les fichiers de base de données du carnet de vol Sky Dolly (*.sdlog), exécutez vos propres requêtes SQL


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-06

---
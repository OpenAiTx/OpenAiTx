
<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

[![Pré-version](https://img.shields.io/github/v/tag/till213/skydolly?include_prereleases&label=Pre-Release)](https://github.com/till213/skydolly/releases)
![Licence : MIT](https://img.shields.io/badge/%E2%9A%96%EF%B8%8F%20License-MIT-brightgreen)
![C++20](https://img.shields.io/badge/C%2B%2B-20-%2300599C?logo=cplusplus)
![Compilateurs supportés](https://img.shields.io/badge/%E2%9A%99%EF%B8%8F%20Compilers-GCC%2C%20clang%2C%20MSVC-informational)
[![Demander à DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/till213/SkyDolly)
![Tests unitaires](https://github.com/till213/SkyDolly/actions/workflows/unit-tests.yml/badge.svg?event=push)

# Sky Dolly
Sky Dolly - La brebis galeuse pour vos enregistrements de vol.

## À propos
Sky Dolly se connecte à une instance de Flight Simulator 2020 en cours d’exécution et enregistre diverses variables de simulation, pour la relecture.

![Sky Dolly v0.11.0](https://raw.githubusercontent.com/till213/SkyDolly/main/./img/SkyDolly-v0.11.0.png)

La connexion s'effectue via SimConnect, une API standard introduite avec Flight Simulator X pour se connecter au simulateur de vol.

Consultez également le fichier [ABOUT.md](https://raw.githubusercontent.com/till213/SkyDolly/main/ABOUT.md).

## Fonctionnalités
- Enregistrement / Pause / Lecture
- Vols en formation (plusieurs avions, relecture pendant l'enregistrement, "voler en formation", décalage temporel)
- Taux d'échantillonnage d'enregistrement paramétrable : fixe ou variable ("auto")
- Vitesse de relecture ajustable ("ralenti", "accéléré"), boucle de relecture
- Les variables de simulation de position, vitesse et commandes de vol de base (ailerons, gouverne, volets, trains, ...) sont enregistrées
- Architecture par plugins avec divers plugins d'import/export (CSV, GPX, IGC, KML)
- Module de localisation avec plus de 100 emplacements par défaut et fonctionnalités d'import/export
- Persistance basée sur base de données (SQLite) ("carnet de vol")

Regardez la bande-annonce (aperçu) de la version sur [YouTube](https://www.youtube.com/watch?v=_n4qRtm78_I):

[![Sky Dolly - Enregistreur de vol et relecture pour Flight Simulator 2020 (Cinematic Teaser Trailer)](https://img.youtube.com/vi/_n4qRtm78_I/0.jpg)](https://www.youtube.com/watch?v=_n4qRtm78_I "Sky Dolly - Enregistreur de vol et relecture pour Flight Simulator 2020 (Cinematic Teaser Trailer)")

Pour plus de vidéos créées avec Sky Dolly, consultez également [SHOWCASE](https://raw.githubusercontent.com/till213/SkyDolly/main/SHOWCASE.md). Les nouvelles fonctionnalités et celles à venir sont dans le [CHANGELOG](https://raw.githubusercontent.com/till213/SkyDolly/main/CHANGELOG.md).

## Utilisation de base

- Démarrez un vol
- Cliquez sur "Enregistrer" (touche R)
- Vous pouvez mettre l'enregistrement en pause (touche P)
- Arrêtez l'enregistrement (touche R) et cliquez sur "Lecture" (barre d'espace)
- Ajustez la vitesse de relecture et recherchez la position de lecture, même pendant la relecture
- Les vols enregistrés sont automatiquement sauvegardés dans le "carnet de vol"
- Sélectionnez un vol dans le carnet et appuyez sur "Charger" (ou double-cliquez sur la ligne) pour charger le vol sauvegardé

### Enregistrement et relecture en formation

#### Enregistrement

- Passez au module "Formation" (touche F2)
- Cliquez sur "Enregistrer" (touche R)
- Chaque avion enregistré est ajouté au vol en cours
- Bien que les avions existants soient rejoués pendant l’enregistrement avec le taux d’échantillonnage "auto", vous pouvez toujours modifier le taux d’échantillonnage de l’enregistrement

#### Position

- Le dernier avion enregistré devient "l’avion utilisateur" (suivi par la caméra dans le simulateur de vol)
- Sélectionnez une position relative à l’actuel "avion utilisateur" avant d’enregistrer

#### Relecture

- Il suffit de cliquer sur "Lecture", "Pause" et de naviguer dans la chronologie, comme pour un vol d’avion unique
- Changez "l’avion utilisateur" (également pendant la relecture) pour "sauter de cockpit en cockpit"
- Prenez le contrôle de "l’avion utilisateur" en sélectionnant "Prendre le contrôle" ou l’option "Voler en formation"

#### Gestion des formations

- Vous pouvez supprimer des avions individuels d’un vol ("formation")
- Il doit y avoir au moins un avion par vol, donc le dernier avion ne peut pas être supprimé
- Ajoutez un décalage temporel à l’avion sélectionné ("synchronisation du vol en formation multijoueur")
- Pour démarrer un nouveau vol avec un seul avion, revenez au module "Carnet de vol" (touche F1) et cliquez sur "Enregistrer" (touche R)

Pourquoi ne pas essayer avec l’un des ["Tell Tours"](https://github.com/till213/Tell-Tours) guidés ? :)

## Téléchargement

Allez sur [Releases](https://github.com/till213/SkyDolly/releases) et téléchargez la dernière version.

Dernière (pré-)version : **Sky Dolly 0.19.2**

Calculez et comparez votre somme de contrôle avec les [SHA-256 publiés](https://raw.githubusercontent.com/till213/SkyDolly/main/SHASUM256.md), pour vérifier l’intégrité de votre copie téléchargée.

## Compilation

Reportez-vous à la documentation [BUILD](https://raw.githubusercontent.com/till213/SkyDolly/main/BUILD.md).

## Projets associés

- https://github.com/nguyenquyhy/Flight-Recorder - Une application d'enregistrement et de relecture de vol basée sur .Net
- https://github.com/saltysimulations/saltyreplay/ - Un outil d'enregistrement et de relecture avec une interface web utilisateur
- https://github.com/SAHorowitz/MSFS2020-PilotPathRecorder - Enregistre le vol et génère des "relectures" au format Google Earth (KML)
- https://github.com/Elephant42/FS_Tool - Un outil simple permettant de définir l'emplacement de l'appareil et le taux de simulation
- https://github.com/pyviator/msfs-geoshot - Prend des captures d'écran et leur attribue automatiquement une "géolocalisation"
- https://github.com/ijl20/msfs_logger_replay - Enregistreur et relecteur IGC (pour FSX)
- https://joinfs.net/ - Permet de synchroniser les vols multijoueurs entre différents simulateurs de vol (MSFS, Prepar3D/FSX, XPlane). Fournit également un enregistreur de vol avec enregistrement de vol en formation ("overdub").
- https://github.com/paulalexandrow/a32nx-webremote - WebRemote pour le A32NX de FlyByWire : contrôle des fonctionnalités du cockpit de l'A320 FBW via FSUIPC7
- https://flightloganalyzer.com/ - FlightLog Analyzer analyse le carnet de vol MSFS et propose une exportation CSV lisible par Sky Dolly
- https://github.com/BojoteX/FSAutoSave/ - FSAutoSave sauvegarde automatiquement (ou à la demande) les plans de vol
- https://github.com/mracko/MSFS-Landing-Inspector - Analyse la performance de vos atterrissages
- [Points d'intérêt (Google Maps)](https://www.google.com/maps/d/viewer?mid=1KUg5jwyT_9k2A9n5IZ99UChlhfVUfO5S&ll=-3.81666561775622e-14%2C-23.028915134521867&z=1) - Points d'intérêt, aéroports et villes 3D dans Microsoft Flight Simulator.

## Autres ressources utiles

- https://obsproject.com/ - Application de capture et de diffusion d'écran
- https://sqlitebrowser.org/ - Parcourez les fichiers de base de données du carnet de vol Sky Dolly (*.sdlog), exécutez vos propres requêtes SQL


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-20

---
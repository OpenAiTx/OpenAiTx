# MonkSynth

[![Build](https://github.com/JonET/monksynth/actions/workflows/build.yml/badge.svg)](https://github.com/JonET/monksynth/actions/workflows/build.yml)
[![Release](https://img.shields.io/github/v/release/JonET/monksynth?include_prereleases)](https://github.com/JonET/monksynth/releases)
[![License](https://img.shields.io/github/license/JonET/monksynth)](LICENSE)

Un synthétiseur vocal monophonique qui sonne comme un moine chantant. Construit en utilisant la synthèse par fonction d’onde formante (FOF), inspiré par le classique plugin VST [Delay Lama](http://www.audionerdz.nl/) d’AudioNerdz (2002).

**[Téléchargez la dernière version](https://github.com/JonET/monksynth/releases)** — disponible pour Windows, macOS, et Linux.

<img src="https://raw.githubusercontent.com/JonET/monksynth/main/docs/screenshot1.png" alt="MonkSynth running in Ableton Live 12 with the classic Delay Lama theme" width="600">

*MonkSynth v0.0.1-beta.1 dans Ableton Live 12, avec le thème classique importé depuis la DLL originale de Delay Lama*

## Fonctionnalités

- Moteur de synthèse FOF produisant des formants vocaux réalistes
- Pavé XY pour le contrôle en temps réel de la hauteur et des voyelles
- Effet de délai stéréo intégré
- Support MIDI : note on/off, molette de pitch, CC1 (vibrato), CC5 (glissando), CC7 (volume), CC12 (délai), CC13 (voix)
- Paramètre **Pitch Bend** automatisable (±12 demi-tons). La molette de pitch matérielle est routable soit vers Voyelle (Classique / compatibilité Delay Lama, par défaut) ou Pitch via clic droit → Pitch Bend
- Enveloppe ADSR avec attaque, décroissance, sustain, release configurables
- Mode unisson avec jusqu’à 10 voix désaccordées et dispersion des voix
- Système de thèmes avec menu contextuel clic droit pour thèmes personnalisés
- Import du thème classique depuis la DLL originale de Delay Lama
- 5 presets d’usine
- Format plugin VST3 (Windows, macOS, Linux) et Audio Unit (macOS)

## Compilation

### Prérequis

- CMake 3.20+
- Compilateur C/C++ (MSVC, GCC ou Clang)

### Compilation

```bash
cd cpp
cmake -B build
cmake --build build --config Release --target MonkSynth
```

Le SDK VST3 est récupéré automatiquement par CMake. Le plugin compilé est placé dans votre répertoire système VST3.

### Audio Unit macOS

Pour construire également le plugin AU, installez le [AudioUnit SDK](https://github.com/apple/AudioUnitSDK) et configurez avec :

```bash
cmake -B build -G Xcode -DSMTG_AUDIOUNIT_SDK_PATH=/path/to/AudioUnitSDK
cmake --build build --config Release --target MonkSynth-au
```

### Tests unitaires DSP

La couche DSP en pur C (`dsp/`) dispose d'une petite suite de tests unitaires vérifiant les limites de l'enveloppe ADSR, la pile de notes, les calculs de désaccord en unisson, la propagation du pitch-bend et la stabilité du feedback de la ligne de retard. Les tests sont optionnels afin de ne pas affecter les compilations normales du plugin :

```bash
cd cpp
cmake -B build-tests -DMONKSYNTH_BUILD_TESTS=ON
cmake --build build-tests --config Release
ctest --test-dir build-tests --output-on-failure
```

CI exécute la suite de tests sur le travail Linux avant de packager chaque version, donc toute régression DSP bloque la construction.

## Installation

- **macOS :** Exécutez l'installateur `.pkg` — installe à la fois les plugins VST3 et AU
- **Windows :** Exécutez l'installateur `.exe` — installe le plugin VST3
- **Linux :** Extrayez et copiez `MonkSynth.vst3` dans `~/.vst3/`

### Compatibilité Linux

La version Linux est vérifiée à chaque sortie pour se charger proprement sous des sémantiques de chargeur strictes (style Bitwig `dlopen(RTLD_NOW)`) sur ces familles de distributions :

- Ubuntu 22.04 / 24.04 LTS (et dérivés : Linux Mint, Pop!_OS, Elementary, KDE neon)
- Debian 12 (et dérivés : KX Studio, AV Linux, MX Linux)
- Fedora (dernière version)
- Arch Linux (et dérivés : Manjaro, EndeavourOS, CachyOS)

Si votre distribution n’est pas listée, elle fonctionne très probablement encore — ces tests rapides en CI visent à détecter les bugs de type bibliothèque partagée manquante, pas une garantie de support exhaustive. Le plugin est compilé sur Ubuntu 22.04 (glibc 2.35), donc toute distribution avec glibc ≥ 2.35 devrait être compatible. Les retours d’autres distributions sont bienvenus via [GitHub Issues](https://github.com/JonET/monksynth/issues).

## Thèmes

MonkSynth est livré sans thème intégré. Au premier lancement, il affiche un écran de configuration où vous pouvez importer le look classique du DLL Delay Lama original (disponible en freeware sur [audionerdz.nl](http://www.audionerdz.nl/download.htm)).

Vous pouvez aussi charger des thèmes personnalisés via clic droit sur l’interface du plugin. Un dossier thème contient un manifeste `theme.json` et toute combinaison de ces fichiers PNG (ceux manquants sont remplacés par des images 1x1) :

- `background.png` — arrière-plan principal (360x510)
- `monk-strip.png` — feuille de sprite d’animation (grille 5x6, cadres 311x311)
- `knob-left.png` / `knob-right.png` — films de boutons rotatifs (50x3000, 60 cadres)
- `fader-down-large.png` / `fader-down-sm.png` / `fader-right-sm.png` — poignées de faders
- `info.png` — superposition d’info (253x275)

**Recherche de nouveaux thèmes par défaut à intégrer au plugin.** Si vous créez un thème dont vous êtes fier, ouvrez une PR — j’aimerais inclure des thèmes proposés dans la prochaine version. Le menu clic droit propose un élément "Ouvrir le dossier Thèmes" qui montre où se trouvent les thèmes sur le disque.

## Traductions

L’interface du plugin (écran de configuration, superposition d’info, menu clic droit, messages d’erreur de l’importateur DLL) est disponible en anglais, japonais et coréen. La langue est détectée automatiquement depuis la locale de votre OS ; vous pouvez la changer via clic droit → Langue.

**Les traductions japonaise et coréenne ont été générées par un grand modèle de langue comme point de départ.** Les contributions de locuteurs natifs sont très appréciées — merci d’ouvrir une PR en modifiant `cpp/src/strings_ja.h` ou `cpp/src/strings_ko.h`. Chaque chaîne est indexée par l’énumération `StringId` dans `cpp/src/i18n.h` ; conservez l’ordre des entrées et laissez vides celles dont vous n’êtes pas sûr pour revenir à l’anglais.

Les noms des paramètres (affichés dans les pistes d’automatisation de votre DAW) restent en anglais intentionnellement — les tutoriels, les presets et les discussions communautaires supposent tous les noms en anglais.

## Politique de signature du code

Signature de code gratuite fournie par [SignPath.io](https://about.signpath.io/), certificat par [SignPath Foundation](https://signpath.org/).

Le plugin VST3 Windows et l’installateur sont signés dans le cadre de la compilation de la version via GitHub Actions. Les demandes de signature sont soumises à SignPath uniquement pour les versions taguées construites à partir de ce dépôt, et chaque demande est approuvée manuellement dans l’interface SignPath avant l’application du certificat.

| Rôle privilégié | Signataire |
|-----------------|------------|
| Auteur          | [Jonathan Taylor](https://github.com/JonET) |
| Relecteur       | [Jonathan Taylor](https://github.com/JonET) |
| Approuveur      | [Jonathan Taylor](https://github.com/JonET) |

### Politique de confidentialité

Ce programme ne transférera aucune information à d’autres systèmes en réseau sauf si cela est spécifiquement demandé par l’utilisateur ou la personne l’installant ou l’utilisant.

## Remerciements

- [Delay Lama](http://www.audionerdz.nl/) par AudioNerdz (2002) — le plugin VST freeware adoré qui a inspiré ce projet
- Xavier Rodet (IRCAM) — technique de synthèse par fonction d’onde formante (FOF)
- [stb_image_write](https://github.com/nothings/stb) par Sean Barrett — écriture d’image en un seul fichier d’en-tête (MIT / domaine public)
- [VST3 SDK](https://github.com/steinbergmedia/vst3sdk) par Steinberg — cadre de plugin (MIT)
- [SignPath Foundation](https://signpath.org/) — signature de code Windows gratuite pour projets open source

## Licence

[MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-24

---
# Expériences avec les Extensions Ableton Live

![Extensions Ableton Live](/images/Ableton-Extensions.png)

🖥️ [Regardez ma vidéo d’introduction sur YouTube](https://www.youtube.com/watch?v=_izRiBGngGI)

*Brisez ce qui est attendu. Faites de Live votre propre outil.* 

Les extensions sont une nouvelle manière d’améliorer les capacités de Live avec des outils puissants qui peuvent accélérer votre flux de travail en automatisant les tâches répétitives, stimuler ou brouiller de nouvelles idées et bien plus encore.

Ce dépôt est une collection de certaines des extensions que j’ai développées pour que vous puissiez les essayer, explorer et modifier. La plupart d’entre elles sont simplement des tests conçus pour explorer les capacités du SDK.

Vous pouvez en lire plus sur les extensions Ableton ici :

* [Ableton.com](https://www.ableton.com/en/live/extensions)
* [Extension SDK](https://ableton.github.io/extensions-sdk)
* [Rejoignez le Discord d’Ableton](https://discord.gg/ableton) pour discuter des extensions

## Prérequis

* Ableton Live Suite 12.4.5 beta

## Avertissement

J’ai construit la plupart de ces extensions avec l’aide de *Claude Code* qui a pris en charge la majeure partie du travail lourd côté code. Si cela vous met mal à l’aise ou si vous n’êtes pas d’accord avec cette approche, pas de souci. Quoi qu’il en soit, merci beaucoup d’avoir pris le temps de les découvrir.

Un grand merci à **Rain** et **Jackie** pour m’avoir aidé à construire l’extension **Bird Game** et à la rendre aussi belle. Merci à Glau [@glaurossi](https://github.com/glaurossi) pour avoir rendu **Doom** compatible avec Windows. **Freesound Sampler** est développé en collaboration avec les retours de Frederic Font Corbera [@ffont](https://github.com/ffont), le développeur principal de Freesound.

---

# Extensions

| Nom | Version | Description | Téléchargement | Source |
|---|---|---|---|---|
| Arrangement Helper | 0.0.8 | Crée des arrangements structurés avec des sections nommées et colorées sur une piste MIDI. *⚠️ Veuillez lire les limitations connues actuelles dans le fichier README de l’extension.* | [⬇️ Télécharger](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Arrangement-Helper-0.0.8.ablx) | [🏗️ Source](extensions/arrangement-helper) |
| Basic Pitch ✨ | 1.0.3 | Convertit les clips audio en MIDI en utilisant le réseau neuronal Basic Pitch de Spotify, totalement hors ligne (macOS & Windows) | [⬇️ Télécharger](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Basic-Pitch-1.0.3.ablx) | [🏗️ Source](extensions/spotify-basic-pitch) |
| Bird Game | 1.1.0 | Un jeu juste pour s’amuser inspiré de Flappy Bird qui transforme votre course en clip MIDI (macOS & Windows) | [⬇️ Télécharger](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/bird-game-1.1.0.ablx) | [🏗️ Source](extensions/bird-game) |
| Chord Progression Helper | 0.5.1 | Construit des progressions d’accords à partir de n’importe quelle tonalité et les écrit sous forme de clip MIDI | [⬇️ Télécharger](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Chord-Progression-Helper-0.5.1.ablx) | [🏗️ Source](extensions/chord-progression-helper) |
| Chord Voicing Helper | 1.0.2 | Détecte les accords dans un clip MIDI et vous permet d’appliquer et de prévisualiser des stratégies d’harmonisation | [⬇️ Télécharger](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Chord-Voicing-Helper-1.0.2.ablx) | [🏗️ Source](extensions/chord-voicings-helper) |
| ChromaFlux | 0.0.7 | Randomise les paramètres d’un Instrument Rack avec un mode et une intensité configurables | [⬇️ Télécharger](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/ChromaFlux-0.0.7.ablx) | [🏗️ Source](extensions/chroma-flux) |
| Doom | 1.0.0 | Exécute la version originale DOOM Shareware (1993) entièrement hors ligne dans Ableton Live (macOS & Windows) | [⬇️ Télécharger](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Doom-1.0.0.ablx) | [🏗️ Source](extensions/doom) |
| Duplicate Track | 0.0.7 | Duplique une piste sans copier ses clips | [⬇️ Télécharger](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Duplicate-Track-0.0.7.ablx) | [🏗️ Source](extensions/duplicate-track) |
| Freesound Sampler | 1.1.3 | Recherche sur Freesound.org et télécharge les sons directement dans vos pistes | [⬇️ Télécharger](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Freesound-Sampler-1.1.3.ablx) | [🏗️ Source](extensions/freesound-sampler) |
| Session to Arrangement Bridge | 0.0.8 | Transfère tous les clips de la Session View vers la Arrangement View avec une fidélité complète. *⚠️ Veuillez lire les limitations connues actuelles dans le fichier README de l’extension.* | [⬇️ Télécharger](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Session-to-Arrangement-Bridge-0.0.8.ablx) | [🏗️ Source](extensions/session-arrangement-bridge) |
| Snake | 0.0.7 | Jouez à Snake dans Live et transformez votre partie en clip MIDI | [⬇️ Télécharger](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Snake-0.0.7.ablx) | [🏗️ Source](extensions/snake) |
| Track Creator | 0.0.6 | Crée plusieurs pistes audio ou MIDI simultanément à partir d’un simple dialogue | [⬇️ Télécharger](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Track-Creator-0.0.6.ablx) | [🏗️ Source](extensions/track-creator) |
| Transpose Clips | 0.1.0 | Transpose chaque clip MIDI du Live Set d’un nombre choisi de demi-tons | [⬇️ Télécharger](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Transpose-Clips-0.1.0.ablx) | [🏗️ Source](extensions/transposer) |

✨ *Les plus récemment mis à jour*

---

# Journal des modifications

## 28 juin 2026

### Basic Pitch 1.0.3
- **Barre de progression indéterminée** — Pendant la transcription, la barre de progression s’anime maintenant en mode indéterminé au lieu de se figer. L’inférence CPU de TF.js est synchrone et bloque le thread unique de Node, donc un pourcentage fixe ne pouvait pas se mettre à jour avant la fin de l’inférence.

## 15 juin 2026

### Freesound Sampler 1.1.3
- **Inspire Me** — Cliquez sur **Inspire Me** pour choisir un terme de recherche aléatoire et découvrir instantanément des sons inattendus
- **Connexion OAuth** - Flux de travail amélioré. Suppression du champ clé API.

## 12 juin 2026

### Freesound Sampler 1.0.0
- **Connexion OAuth** — Connectez-vous avec votre compte Freesound directement depuis l’extension ; plus besoin de clé API manuelle
- **Téléchargements en qualité originale** — Une fois connecté, les sons sont téléchargés dans leur format original (WAV, FLAC, AIFF, …) au lieu des aperçus MP3
- **Assistant d’attribution** — La vue Attributions liste les sons importés avec une copie en un clic pour créditer les créateurs
- **Filtres de recherche avancés** — Filtrez par descripteurs de timbre (brillance, chaleur, rugosité, etc.), tonalité, BPM, durée, licence, et plus

## 9 juin 2026

### Bird Game 1.1.0
- **Support Windows** — Fonctionne désormais sur macOS et Windows

### Doom 1.0.0
- **Support Windows** — Fonctionne désormais sur macOS et Windows (merci à Glau [@glaurossi](https://github.com/glaurossi))
- **Entièrement hors ligne** — Tous les assets du jeu inclus ; aucune connexion internet requise

## 7 juin 2026

### Basic Pitch 1.0.0
- **Support Windows** — Support complet multiplateforme (macOS & Windows) grâce à [@jwfeniello](https://github.com/jwfeniello)
- **Modèle intégré** — Le modèle ML fonctionne entièrement localement ; aucune donnée ne quitte votre machine
- **Corrections de stabilité** — Correction des plantages hôtes et gestion des échantillons audio compressés

## 1er juin 2026

### Première version publique
- **Bird Game 1.0.0** — Jeu inspiré de Flappy Bird qui transforme votre course en clip MIDI
- **Doom** — DOOM Shareware original (1993) fonctionnant dans Ableton Live, migré vers le nouveau SDK
- **Arrangement Helper**, **Basic Pitch**, **Chord Progression Helper**, **Chord Voicing Helper**, **ChromaFlux**, **Duplicate Track**, **Freesound Sampler**, **Session to Arrangement Bridge**, **Snake**, **Track Creator**, **Transpose Clips** — premières versions publiques

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-12

---
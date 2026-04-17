# PulseQueue

Application web minimaliste pour créer de la musique électronique avec des synthétiseurs numériques.  
Conçue initialement comme outil de croquis, mais peut être utilisée pour réaliser des morceaux complets :musical_note::notes:

**[:link: LANCER DANS LE NAVIGATEUR :link:](https://valent-in.github.io/pulseq)**

- Simple et facile à utiliser  
- Adaptée aux mobiles  
- Client uniquement (aucune donnée traitée sur les serveurs)

- Synthétiseurs soustractifs avec divers effets  
- Oscillateurs harmoniques & FM basique  
- Séquenceur pas à pas multi-couches  
- Presets de synthé exportables  
- Export audio WAV  
- Export MIDI

## Exemples musicaux (YouTube)  
- [Cosmix - partie 1](https://www.youtube.com/watch?v=KkLsClq37w4)  
- [Cosmix - partie 2](https://www.youtube.com/watch?v=8_aYqIMCa2k)  
- [Clean Steps](https://www.youtube.com/watch?v=2IaCb21nIZU)

## Démarrage rapide  
Pour commencer, vous pouvez expérimenter avec les morceaux inclus. Cliquez sur le bouton "Demo" dans le menu de démarrage et sélectionnez une piste de démonstration. Rechargez la page pour revenir à ce menu.

**Onglets du programme :**  
ARRANGE :cd:  
Combinez les motifs pour créer une piste musicale complète.

PATTERN :musical_keyboard:  
Placez les notes ici. Le moteur de synthé est monophonique (voix unique), des voix supplémentaires peuvent être ajoutées avec des couches de motifs.

SYNTH :control_knobs:  
Panneau de configuration pour l'instrument sélectionné. Les presets sont disponibles depuis le menu à 3 points.

LIST :level_slider::level_slider:  
Contient la liste des synthétiseurs ainsi qu’une table de mixage.

## Cartes de référence
![carte aperçu](https://raw.githubusercontent.com/Valent-in/pulseq/master/refcards/refcard-overview.png)
![carte commandes](https://raw.githubusercontent.com/Valent-in/pulseq/master/refcards/refcard-controls.png)
![carte routage](https://raw.githubusercontent.com/Valent-in/pulseq/master/refcards/refcard-synth.png)

## Notes de performance
- Certains effets sollicitent fortement le CPU (notamment la réverbération et le phaser). Cela doit être pris en compte lors de l'utilisation sur des appareils mobiles.  
- La durée d'exportation WAV peut être limitée à environ 10 minutes sur les navigateurs mobiles.

---
Utilisation de l'API Web Audio et de [Tone.js](https://github.com/Tonejs/Tone.js)  
Sources d'exportation de fichiers :  
[bufferToWave](https://github.com/rwgood18/javascript-audio-file-dynamics-compressor),  
[midi-writer](https://github.com/carter-thaxton/midi-file).

Ce programme est un logiciel libre : vous pouvez le redistribuer et/ou le modifier selon les termes de la licence publique générale GNU version 3.  
Ce programme est distribué dans l'espoir qu'il sera utile, mais SANS AUCUNE GARANTIE.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-17

---
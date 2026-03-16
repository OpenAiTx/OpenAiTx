## Jubler - Éditeur de Sous-titres

![GitHub release (latest by date)](https://img.shields.io/github/v/release/teras/Jubler)
![GitHub all releases](https://img.shields.io/github/downloads/teras/Jubler/total)
![GitHub](https://img.shields.io/github/license/teras/Jubler?v=2)
![Java](https://img.shields.io/badge/Java-8+-orange)
![Platform](https://img.shields.io/badge/platform-Linux%20%7C%20macOS%20%7C%20Windows-blue)
![GitHub Release Date](https://img.shields.io/github/release-date/teras/Jubler)

Jubler est un éditeur de sous-titres gratuit et open source pour créer, éditer et convertir des sous-titres textuels. Écrit en Java pour une compatibilité multiplateforme, il offre des outils pour la création de nouveaux sous-titres et l’amélioration des existants avec aperçu vidéo, validation de qualité et large prise en charge des formats.

(C) 2005-2025 Panayotis Katsaloulis
panayotis@panayotis.com

Sous licence GNU Affero General Public License v3 (AGPL-3.0)

---

## Fonctionnalités

### Formats de Sous-titres
- **Plus de 20 formats supportés** incluant SubRip (SRT), Advanced SubStation Alpha (ASS/SSA), WebVTT, MicroDVD, SubViewer, MPL2, Spruce DVD Maestro, TTML, ITT, DFXP, et sous-titres YouTube
- **Support universel des encodages** (UTF-8, UTF-16, et tous les encodages de la plateforme Java)
- **Style au niveau des caractères et paragraphes** pour les formats compatibles (ASS/SSA, SRT)
- **Conversion de formats** entre tous les types supportés

### Intégration Vidéo
- **Intégration FFmpeg** pour aperçu des images et visualisation de la forme d’onde audio
- **Support MPlayer** pour la lecture vidéo
- **Édition des sous-titres en temps réel** pendant la lecture vidéo
- **Timeline interactive** avec blocs de sous-titres déplaçables
- **Synchronisation à deux points** pour alignement temporel
- **Contrôles d’aperçu améliorés** avec support des touches shift/alt et aimantation

### Outils d’Édition
- **Manipulation temporelle** - décalage, conversion de fréquence d’images, arrondi du timing
- **Opérations sur le contenu** - division/fusion d’entrées, division/fusion de fichiers
- **Traitement du texte** - correcteur orthographique, rechercher & remplacer avec support regex
- **Correcteur de temps intelligent** avec détection et résolution des chevauchements
- **Mode traduction** pour traduction côte à côte des sous-titres
- **Annuler/refaire** avec historique complet
- **Sauvegarde automatique et récupération**

### Contrôle de qualité
- **Validation des sous-titres** avec règles de qualité configurables
- **Métriques CPS (caractères par seconde)** affichées dans le tableau des sous-titres
- **Vérification de la conformité aux directives TED**
- **Validation colorée** pour mettre en évidence les problèmes
- **Outils de statistiques et d'analyse**

### Interface utilisateur
- **Support HiDPI** avec mise à l'échelle ajustable
- **Thème sombre** disponible
- **Raccourcis clavier personnalisables**
- **Interface multilingue** avec support i18n
- **Marquage coloré** pour organiser les groupes de sous-titres

### Automatisation
- **Outils en ligne de commande** pour traitement par lots
- **Système de plugins** pour extensibilité
- **Intégration d'outils externes**
- **Support Azure Translator** pour traduction automatique

---

## Prise en main

### Exigences
- Java 8 ou supérieur (souvent inclus dans la distribution)
- Optionnel : MPlayer pour la prévisualisation vidéo
- Optionnel : ASpell pour la correction orthographique

### Installation

Téléchargez les binaires depuis la [page des versions](https://github.com/teras/Jubler/releases) :
- Installateurs pour Windows, macOS et Linux
- AppImage Linux
- Package multiplateforme générique

Ou compilez depuis la source (voir [BUILD_AND_RUN.md](https://raw.githubusercontent.com/teras/Jubler/master/BUILD_AND_RUN.md))

### Exécution

Lancez depuis le menu de votre application ou le raccourci sur le bureau. Vous pouvez également lancer manuellement :
```bash
java -jar Jubler.jar
```

---

## Contributing

Jubler is an open source project that welcomes contributions. Whether you're fixing bugs, adding features, improving documentation, or translating the interface, your help is appreciated.

---

## Credits

Free code signing on Windows provided by [SignPath.io](https://signpath.io/), certificate by [SignPath Foundation](https://signpath.org/)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-16

---
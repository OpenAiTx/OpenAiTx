<div align="center">
<img src="https://moooonet.github.io/assets/Comfy-Align//images/display.jpg" width="100%">
<br><br>

[![Version](https://img.shields.io/badge/Version-3.0.4-cyan)](README.md)
[![Youtube](https://img.shields.io/badge/Video-Tutorial-red)](https://youtu.be/p1niyxwsOes)

</div>

ComfyUI-Align fournit un ensemble puissant d'outils d'alignement, d'étirement et de configuration des couleurs des nœuds, répondant au manque de fonctionnalité d'alignement des nœuds dans ComfyUI

> _Si ce plugin vous a aidé à préserver votre santé mentale, veuillez envisager de donner une ⭐ pour soutenir l'habitude de la caféine._

## Environnement

- ComfyUI : Testé sur la version 0.3.76 ; supporte théoriquement les versions récentes et futures.
- Python : Testé sur Python 3.12
- Système : Testé sur Windows 11 et Ubuntu 25.10. D'autres distributions Linux devraient fonctionner ; veuillez tester vous-même. Support théorique de macOS, mais non testé faute d'appareil.

## Installation

- **Depuis ComfyUI Manager :** Recherchez "ComfyUI-Align" dans ComfyUI Manager et installez.
- **Git Clone :** Ouvrez le répertoire ComfyUI, naviguez vers le dossier `custom_nodes`, et exécutez :
  ```bash
  git clone https://github.com/Moooonet/ComfyUI-Align.git
  ```
- **Redémarrer ComfyUI :** Après l'installation, redémarrez ComfyUI pour charger le nouveau plugin.

## Paramètres et Utilisation

- **Touche de Raccourci :** Par défaut, c'est la touche backquote <kbd>`</kbd>, pour la compatibilité multi-systèmes, la touche de raccourci personnalisée est implémentée via la fonction native de ComfyUI. Veuillez rechercher "Align Panel" dans les raccourcis clavier pour définir une touche personnalisée.

<div align="center">
  <img src="https://moooonet.github.io/assets/Comfy-Align/images/keybindings.jpg" width="100%">
</div>

- **Deux Modes d'Opération :**
- 1. Utilisez <kbd>`</kbd> pour basculer la visibilité du panneau d'alignement. (Touche backtick, située au-dessus de la touche Tab)
- 2. Activez le Mode Maintien dans les Paramètres (maintenez le raccourci pour afficher le panneau ; survolez un bouton et relâchez la touche pour exécuter sans cliquer ; ou maintenez la touche et cliquez différents boutons pour effectuer plusieurs opérations).

<div align="center">
  <img src="https://moooonet.github.io/assets/Comfy-Align/images/settings.jpg" width="100%">
</div>

## Fonctionnalités Principales

### 1. Alignement, Distribution et Étirement des Nœuds et Groupes

- **Alignement :**

  - **Alignement à Gauche, Alignement à Droite, Alignement en Haut, Alignement en Bas :**
  - Touche `Alt` : Maintenir <kbd>Alt</kbd> pendant l'alignement inverse les nœuds ciblés.

- **Distribution :**

  - **Distribution Horizontale Alignée en Haut :** Distribue les nœuds uniformément horizontalement d'abord, puis les aligne en haut.
  - **Distribution Verticale Alignée au Centre :** Distribue les nœuds uniformément verticalement d'abord, puis les centre.
  - **Réglage de l'Espace :** Définissez l'espacement dans les options `Align`.

- **Étirement :**
  - **Étirement à Gauche, Étirement à Droite, Étirement en Haut, Étirement en Bas :**
  - **Étirement Bilatéral Horizontal :** Le nœud le plus large est la cible, les autres nœuds s'étirent à gauche et à droite du nœud cible, en conservant leur largeur.
  - **Étirement Bilatéral Vertical :** Le nœud le plus haut est la cible, les autres nœuds s'étirent en haut et en bas du nœud cible, en conservant leur hauteur.
  - Touche `Alt` : Maintenir <kbd>Alt</kbd> pendant l'étirement inverse les nœuds ciblés.

### 2. Gestion des Couleurs des Nœuds et Groupes
- **ColorBar :**

  - 7 couleurs par défaut
  - Icône lune (pour ouvrir le sélecteur de couleurs)
  - Effacer la couleur (effacer la couleur des nœuds sélectionnés)
  - Appliquer la couleur (appliquer la couleur des préréglages aux nœuds correspondants)

- **ColorPicker :**

  - Zone de sélection de couleur
  - Outil pipette
  - Curseur de teinte
  - Curseur alpha
  - Valeur HEX (cliquer pour copier, double-cliquer pour éditer)
  - Valeur RGBA (cliquer pour copier, double-cliquer pour éditer. Maintenir Ctrl pour copier toutes les valeurs)
  - Historique des couleurs
  - Préréglages de couleurs

- **ColorPresets :**
  - Initialement, un fichier `color_presets.json` sera généré dans le répertoire racine du plugin pour stocker les préréglages de couleurs personnalisés.
  - Après avoir défini la couleur des nœuds, cliquez sur le bouton `Save` pour enregistrer le préréglage.
  - Cliquez sur le bouton `Clear` pour effacer toutes les couleurs de préréglages enregistrées.
  - Cliquez sur le bouton `Apply` pour appliquer les couleurs des préréglages aux nœuds correspondants. (Le bouton `Apply` se trouve en dernière position de la `ColorBar`)

---

<div align="center">
   <a href="https://www.star-history.com/#Moooonet/ComfyUI-Align&Date">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=Moooonet/ComfyUI-Align&type=Date&theme=dark" />
      <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=Moooonet/ComfyUI-Align&type=Date" />
      <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=Moooonet/ComfyUI-Align&type=Date" />
    </picture>
   </a>
</div>

---

<div align="center">

  <p>Sauf autorisation explicite, l'intégration, la modification ou la redistribution sous quelque forme que ce soit sont strictement interdites.</p>
  <p>© 2025 Moooonet. Tous droits réservés.</p>
</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-23

---
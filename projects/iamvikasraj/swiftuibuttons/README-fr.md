# jordansingerbutton

Un beau composant de compteur interactif pour SwiftUI avec des boutons fléchés en verre morphique et des animations fluides.

## 📱 Démo



## 🌿 Branches

### `main` - Application complète
L'application complète jordansingerbutton avec la fonctionnalité de compteur.

### `tutorial` - Composant Bouton Flèche
Une version propre et autonome se concentrant uniquement sur le magnifique composant de bouton flèche. Parfait pour apprendre et partager !

**Pour voir la version tutoriel :**
```bash
git checkout tutorial
```

## 🚀 Démarrage rapide

### Utilisation du composant Bouton Flèche

Le `ArrowButton` est un composant SwiftUI réutilisable qui crée un magnifique bouton en style glassmorphique avec :
- Apparence métallique en acier avec des contours multi-couches
- Effet de réflexion floutée
- Animations fluides
- Rotation personnalisable

```swift
import SwiftUI

ArrowButton(rotation: .degrees(0))  // Pointing down
ArrowButton(rotation: .degrees(180)) // Pointing up
ArrowButton(rotation: .degrees(90))  // Pointing left
ArrowButton(rotation: .degrees(270)) // Pointing right
```

### Utilisation complète de l’application

L’application complète inclut une navigation par date avec les étiquettes « Aujourd’hui », « Demain », « Hier » et des transitions de date fluides.

## 📁 Structure du projet

```
jordansingerbutton/
├── CounterView.swift          # Counter with arrow buttons (includes ArrowButton)
├── JordanSingerButtonApp.swift  # App entry point
└── Assets.xcassets/            # Arrow image asset
```

## 🎨 Fonctionnalités

- **Design Glassmorphique** : Belle apparence en acier métallique
- **Animations Fluides** : Animations basées sur un ressort pour les interactions
- **Accessibilité** : Support complet de VoiceOver
- **Personnalisable** : Facile à modifier les couleurs, tailles et rotations

## 📝 Licence

Libre d’utilisation et de modification pour vos projets !


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-12

---
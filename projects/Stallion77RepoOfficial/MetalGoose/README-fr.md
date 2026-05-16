<div align="center">
  <img src="https://raw.githubusercontent.com/Stallion77RepoOfficial/MetalGoose/main/Assets/logo.png" alt="Logo MetalGoose" width="128" height="128">
  
  # MetalGoose
  
  **Mise à l’échelle et génération de frames accélérées par GPU pour macOS**
  
  [![macOS](https://img.shields.io/badge/macOS-26.0%2B-blue?logo=apple)](https://www.apple.com/macos/)
  [![Metal](https://img.shields.io/badge/Metal-4.0-orange?logo=apple)](https://developer.apple.com/metal/)
  [![License](https://img.shields.io/badge/License-GPL--3.0-green)](LICENSE)
  [![Swift](https://img.shields.io/badge/Swift-6.2-FA7343?logo=swift)](https://swift.org)
  
  [Fonctionnalités](#features) • [Installation](#installation) • [Utilisation](#usage) • [Exigences](#requirements) • [Compilation](#building) • [Licence](#license)
</div>

---

## Présentation

MetalGoose est une application native macOS qui fournit une mise à l’échelle en temps réel et une génération de frames pour jeux et applications. Entièrement développée avec le framework Metal d’Apple, elle offre une expérience fluide à haute fréquence d’images similaire à NVIDIA DLSS ou AMD FSR, mais spécialement conçue pour macOS.

## Fonctionnalités

### Mise à l’échelle MGUP-1
- **Mode Performance** — Mise à l’échelle la plus rapide avec latence minimale
- **Mode Équilibré** — Ratio qualité/performance optimal
- **Mode Qualité** — Fidélité visuelle maximale
- Plusieurs échelles de rendu : Native, 75 %, 67 %, 50 %, 33 %
- Accentuation adaptative au contraste (CAS)

### Génération de frames MGFG-1
- Multiplicateurs de frames **2x, 3x, 4x**
- Modes de génération de frames **Adaptatif** ou **Fixe**
- Interpolation compensée par mouvement
- Estimation de mouvement basée sur le flux optique
- Modes qualité : Performance, Équilibré, Qualité

### Anti-crénelage
- **FXAA** — Anti-crénelage approximatif rapide
- **SMAA** — Anti-crénelage morphologique sous-pixel amélioré
- **MSAA** — Anti-aliasing multi-échantillonnage  
- **TAA** — Anti-aliasing temporel avec historique  

### Surveillance des performances  
- Superposition HUD en temps réel  
- Suivi FPS capturé/sorti/interpolé  
- Mesures du temps GPU et du temps de trame  
- Surveillance de l’utilisation de la VRAM  
- Statistiques de trame  

## Exigences  

| Composant | Exigence |  
|-----------|----------|  
| **macOS** | 26.0 (Tahoe) ou version ultérieure |  
| **Puce** | Apple Silicon (M1/M2/M3/M4) |  
| **Xcode** | 26.0 ou version ultérieure |  
| **RAM** | Minimum 8 Go, 16 Go recommandés |  

## Installation  

### Télécharger la version  
1. Téléchargez la dernière version depuis [Releases](https://github.com/Stallion77RepoOfficial/MetalGoose/releases)  
2. Déplacez `MetalGoose.app` vers `/Applications`  
3. Accordez les autorisations d’enregistrement d’écran et d’accessibilité lorsqu’elles sont demandées  

### Compiler à partir des sources  
```bash
git clone https://github.com/Stallion77RepoOfficial/MetalGoose
cd MetalGoose
open MetalGoose.xcodeproj
```
## Utilisation

1. **Lancer MetalGoose**  
2. **Sélectionner la cible**  
   - Choisir une fenêtre ou un écran à capturer  
3. **Configurer les paramètres**  
   - Activer la montée en résolution (MGUP-1)  
   - Activer la génération d’images (MGFG-1)  
   - Sélectionner le mode anti-aliasing  
4. **Démarrer la mise à l’échelle**  
   - Cliquer sur "Démarrer" pour lancer le traitement  

### Raccourcis clavier

| Raccourci | Action |  
|-----------|--------|  
| `⌘ + T`  | Basculer l’échelle |  

# Codes d’erreur MetalGoose

## Interface utilisateur (MG-UI)  
- MG-UI-002 : L’application au premier plan est MetalGoose ; l’utilisateur doit passer à la fenêtre cible.  
- MG-UI-003 : Fenêtre cible introuvable pour l’application sélectionnée.  
- MG-UI-004 : Aucun écran trouvé.  
- MG-UI-005 : Fenêtre en plein écran détectée ; l’écran virtuel nécessite un mode fenêtré ou sans bordure.  
- MG-UI-006 : Limites de la fenêtre cible indisponibles.  
- MG-UI-007 : Identifiant d’écran introuvable pour l’écran cible.  
- MG-UI-008 : Fréquence de rafraîchissement de l’écran indisponible.  

## Moteur (MG-ENG)  
- MG-ENG-001 : Échec de la configuration du pipeline Metal.  
- MG-ENG-002 : Périphérique Metal non disponible.  
- MG-ENG-003 : File de commandes Metal non disponible.  
- MG-ENG-004 : Échec de la création du Spatial Scaler MetalFX.  
- MG-ENG-005 : Pipeline de flux optique indisponible.  
- MG-ENG-006 : Échec de l’interpolation d’images.  
- MG-ENG-007 : Pipeline anti-aliasing indisponible.  
- MG-ENG-008 : Pipeline de mise à l’échelle indisponible.  
- MG-ENG-009 : Pipeline CAS indisponible.

- MG-ENG-010 : Échec de la création de la texture IOSurface.
- MG-ENG-011 : Pipeline de flux optique indisponible.
- MG-ENG-012 : Ressources de flux optique indisponibles.
- MG-ENG-013 : Pipeline de génération de trames indisponible.

## Affichage virtuel (MG-VD)
- MG-VD-001 : Échec de la création de CGVirtualDisplayDescriptor.
- MG-VD-002 : Échec de la création de CGVirtualDisplay.
- MG-VD-003 : Échec de la création de CGVirtualDisplayMode.
- MG-VD-004 : Échec de la création de CGVirtualDisplaySettings.
- MG-VD-005 : Échec de l'application des paramètres d'affichage virtuel.
- MG-VD-006 : Aucun affichage virtuel actif.
- MG-VD-007 : Affichage virtuel non trouvé dans ScreenCaptureKit.
- MG-VD-008 : Échec du démarrage de la capture ScreenCaptureKit.
- MG-VD-009 : Échec de l'arrêt de la capture ScreenCaptureKit.
- MG-VD-010 : Flux ScreenCaptureKit arrêté avec une erreur.

## Accessibilité / Migration de fenêtre (MG-AX)
- MG-AX-001 : Permission d'accessibilité non accordée.
- MG-AX-002 : Échec de la lecture de la liste des fenêtres depuis l'API AX.
- MG-AX-003 : Aucune fenêtre trouvée pour le PID cible.
- MG-AX-004 : Échec de la création de la valeur de position AX.
- MG-AX-005 : Échec de la définition de la position de la fenêtre AX.
- MG-AX-006 : La fenêtre en plein écran ne peut pas être déplacée vers un affichage virtuel.
- MG-AX-007 : Échec de la création de la valeur de taille AX.
- MG-AX-008 : Échec de la définition de la taille de la fenêtre AX.
- MG-AX-009 : Écran d'affichage virtuel non trouvé.
- MG-AX-010 : ID de fenêtre non trouvé pour le PID cible.

## Superposition (MG-OV)
- MG-OV-001 : Écran cible manquant pour la création de superposition.
- MG-OV-002 : Cadre de fenêtre manquant pour la création de superposition.
- MG-OV-003 : Format de pixel non pris en charge pour la création de texture de superposition.

## Routage de la souris (MG-MO)
- MG-MO-001 : Affichage virtuel non configuré pour le routage de la souris.

## Licence

Ce projet est sous licence GNU General Public License v3.0 - voir le fichier [LICENSE](LICENSE) pour plus de détails.

## Acknowledgments

- Apple for the Metal framework and documentation
- The macOS gaming community for feedback and testing
- Contributors who helped improve the project

---

RESOURCES THAT USED FOR THIS PROJECT

https://developer.apple.com/documentation/metal
https://developer.apple.com/documentation/metalfx/
https://developer.apple.com/documentation/coreimage
https://developer.apple.com/documentation/screencapturekit/
https://developer.apple.com/documentation/appkit
https://developer.apple.com/documentation/metal/mtltexture
https://developer.apple.com/documentation/corevideo/cvpixelbuffer
https://developer.apple.com/documentation/metalperformanceshaders
https://developer.apple.com/documentation/metal/compute-passes
https://developer.apple.com/documentation/vision
https://developer.apple.com/documentation/vision/vngenerateopticalflowrequest
https://developer.apple.com/documentation/ScreenCaptureKit/capturing-screen-content-in-macos


<div align="center">
  <sub>Built with ❤️ using Metal for macOS</sub>
</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-16

---
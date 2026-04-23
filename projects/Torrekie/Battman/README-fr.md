# Battman
Le gestionnaire de batterie moderne de Strayers pour leurs bons vieux appareils iOS.

### 🌍
[简体中文](https://raw.githubusercontent.com/Torrekie/Battman/master/docs/README-zh_CN.md)

## Captures d'écran
<div style="width:20%; margin: auto;" align="middle">
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Main.png?raw=true" alt="Démonstration principale de Battman" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Gas Gauge.png?raw=true" alt="Démonstration du jauge de carburant Battman" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Gas Gauge-1.png?raw=true" alt="Démonstration 2 du jauge de carburant Battman" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Adapter.png?raw=true" alt="Démonstration de l'adaptateur Battman" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Inductive.png?raw=true" alt="Démonstration inductive Battman" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Inductive-1.png?raw=true" alt="Démonstration inductive 2 Battman" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Serial.png?raw=true" alt="Démonstration série Battman" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Temperature.png?raw=true" alt="Démonstration température Battman" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/ChargingMgmt.png?raw=true" alt="Démonstration gestion de charge Battman" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/ChargingLimit.png?raw=true" alt="Démonstration limite de charge Battman" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Thermal.png?raw=true" alt="Démonstration thermique Battman" width="25%" height="25%" />
</div>

$${\color{grey}La \space vraie \space élégance \space dans \space un \space logiciel \space réside \space dans \space l'art \space de \space son \space code \space plutôt \space que \space dans \space un \space design \space superficiel.}$$

<br />

### Avantages
- [x] Construit uniquement avec Objective-C & C
- [x] Interface utilisateur entièrement écrite avec un brillant code Objective-C
- [x] PAS de StoryBoards, PAS de binaires supplémentaires, PAS de ressources Xcode
- [x] PAS de Swift ni SwiftUI impliqués
- [x] PAS de CocoaPods, PAS de Swift Packages, PAS de code externe requis, PAS de frameworks tiers
- [x] Compilation AVEC/SANS Xcode
- [x] Compilation sous Linux (Oui, « vous avez besoin d’un Mac pour créer des apps iOS » est une propagande Apple)
- [x] Accès et fonctionnement direct avec votre matériel avec les données brutes les plus approfondies
- [x] Supporte iPhone, iPad, iPod, simulateur Xcode et Macs Apple Silicon (Si quelqu’un fait don d’appareils, je peux même coder pour Apple Watch et Apple TV)
- [x] Haute intégration avec votre circuit intégré de jauge de carburant fabriqué par Texas Instruments
- [x] Affiche autant d’informations sur l’énergie que IOPS & PowerManagement fournissent
- [x] Identification de vos adaptateurs d’alimentation, chargeurs sans fil, ou même vos accessoires MagSafe

### Seul Battman peut le faire

Ce que les autres utilitaires de batterie pour iOS n’ont pas fait
(Au 9 mars 2025, dimanche, UTC+0)
- [x] Décodage complet de NotChargingReason (voir [not_charging_reason.h](https://raw.githubusercontent.com/Torrekie/Battman/master/Battman/battery_utils/not_charging_reason.h))
- [x] Récupération des informations Texas Instruments Impedance Track™
- [x] Lecture en temps réel du courant/tension de charge
- [x] Fonctionne parfaitement dans le simulateur Xcode (D’autres utilisent IOPS dans leur app donc ne fonctionnent pas dans les simulateurs)
- [x] Communication Smart Charging (Optimized Battery Charging)
- [x] Contrôle du comportement du mode faible consommation
- [x] Informations détaillées pour les accessoires MagSafe connectés
- [x] Informations détaillées pour les câbles et accessoires Lightning connectés
- [x] Lecture de tous les capteurs de température matériel

### Exigences

- Jailbreak ou installation avec TrollStore
- iOS 12+ / macOS 11+ (backports bienvenus)
- arm64 (A7+ théoriquement / M1+)
- Gettext libintl (Optionnel, pour les localisations)
- GTK+ 3 (Optionnel, pour exécution sous gestionnaire de fenêtres GTK+)

### Téléchargement

Consultez la dernière [Release](https://github.com/Torrekie/Battman/releases/latest) pour un paquet précompilé.

Ou, si vous souhaitez le compiler vous-même :

```bash
# On macOS, install Xcode and directly build in it
# On Linux or BSD, make sure a LLVM cross toolchain and iPhoneOS.sdk is prepared, modify Battman/Makefile if needed
# On iOS, when you using Torrekie/Comdartiwerk as bootstrap
apt install git odcctools bash clang make sed grep ld64 ldid libintl-dev iphoneos.sdk
git clone https://github.com/Torrekie/Battman
cd Battman
# If Targeting iOS 12 or ealier, download SF-Pro-Display-Regular.otf somewhere, and put it under Battman/
wget <https://LINK/OF/SF-Pro-Display-Regular.otf> -O Battman/SF-Pro-Display-Regular.otf
make -C Battman all
# Produced Battman.ipa will under $(CWD)/Battman/build/Battman.ipa
```

### Problèmes connus

- Battman n'est pas réellement intégré au matériel lorsqu'il fonctionne sur des appareils avec A7 à A10, car il n'y a pas d'AppleSMC, à la place ils utilisent AppleHPM que nous ne pouvons pas tester.

### Appareils testés
- Série iPhone 12 (D52)
- iPad Pro 2021 3e génération (J51)
- iPhone XR
- iPad Air 2

Veuillez déposer des [problèmes](../../issues/new) si Battman ne fonctionne pas correctement sur votre appareil

### À FAIRE
- [ ] Interface AppKit/Cocoa pour macOS
- [ ] Interface GTK+/X11 pour iOS/macOS
- [ ] Identification automatique du circuit de jauge de gaz
- [ ] Collecte de données optionnelle (Pour décoder les paramètres actuellement inconnus)
- [x] Fonctionnalités avancées (interface AppleSMC/ApplePMGR)
- [x] Contrôle thermique
- [ ] Exécution en ligne de commande
- [ ] Exécution en tant que démon
- [x] Limite de charge
- [x] Intégration sans fil/MagSafe
- [ ] Limitation du taux d'application
- [ ] Contrôle Jetsam
- [ ] Contrôle du ventilateur
- [ ] Accessoires Bluetooth (AirPods, etc.)

### Licence

Depuis le samedi 27 septembre 2025 UTC+0, Battman utilise une [licence non libre](https://raw.githubusercontent.com/Torrekie/Battman/master/LICENSE/LICENSE.md) au lieu de MIT, vous ne m'en voudrez pas si je veux en vivre, n'est-ce pas ?

## Avertissement

NE PAS UTILISER EN PRODUCTION, AUCUNE GARANTIE, UTILISEZ À VOS RISQUES ET PÉRILS.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-23

---
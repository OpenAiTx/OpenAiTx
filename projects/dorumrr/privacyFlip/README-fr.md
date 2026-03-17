# PrivacyFlip

**Contrôle automatique de la confidentialité par verrouillage/déverrouillage pour appareils Android 🔐📱✨**

**PrivacyFlip** gère automatiquement les fonctions de confidentialité de votre appareil Android selon l’état verrouillé/déverrouillé. Lorsque vous verrouillez votre appareil, il peut désactiver le **Wi-Fi**, le **Bluetooth**, les **données mobiles**, les services de **localisation**, le **NFC**, et même les **capteurs caméra/microphone**. Lors du déverrouillage, il restaure intelligemment les fonctions que vous souhaitez réactiver.

**Fonctionne avec Shizuku ou Root** - Choisissez votre méthode de privilèges préférée !

<div>
  <a href="https://f-droid.org/en/packages/io.github.dorumrr.privacyflip/" target="_blank" rel="noopener"><img height="50" src="https://f-droid.org/badge/get-it-on.png"></a> 
  <a href="https://apt.izzysoft.de/fdroid/index/apk/io.github.dorumrr.privacyflip" target="_blank" rel="noopener"><img height="50" src="https://gitlab.com/IzzyOnDroid/repo/-/raw/master/assets/IzzyOnDroid.png"></a> 
  <a href="https://www.buymeacoffee.com/ossdev"><img height="50" src="https://cdn.buymeacoffee.com/buttons/v2/arial-yellow.png" /></a>
</div>

## 📸 Captures d’écran

<div align="center">
  <img src="https://raw.githubusercontent.com/dorumrr/privacyFlip/main/fastlane/metadata/android/en-US/images/phoneScreenshots/1.png" alt="PrivacyFlip par Doru Moraru" width="300" style="margin: 10px; border: 1px solid #222222"/>
  <img src="https://raw.githubusercontent.com/dorumrr/privacyFlip/main/fastlane/metadata/android/en-US/images/phoneScreenshots/2.png" alt="PrivacyFlip par Doru Moraru" width="300" style="margin: 10px; border: 1px solid #222222"/>
</div>

## 🔒 Fonctionnalités

### **Contrôle automatique de la confidentialité**
- **Détection de verrouillage** : Désactive instantanément les fonctions de confidentialité lors du verrouillage de l’écran
- **Détection de déverrouillage** : Attend une authentification correcte (pas seulement l’allumage de l’écran)
- **Restauration intelligente** : Réactivation configurable des fonctions au déverrouillage

### **Fonctions de confidentialité contrôlées**
- 📶 **Wi-Fi** - Désactiver/activer la connectivité sans fil
- 📱 **Bluetooth** - Contrôler la radio Bluetooth
- 📡 **Données mobiles** - Gérer la connexion de données cellulaires
- 📍 **Services de localisation** - Contrôler le GPS et le suivi de localisation
- 📳 **NFC** - Contrôler le capteur de communication en champ proche
- 📷 **Caméra** - Désactiver/activer la confidentialité du capteur caméra (Android 12+)
- 🎤 **Microphone** - Désactiver/activer la confidentialité du capteur microphone (Android 12+)
- ✈️ **Mode Avion** - Activer le mode avion au verrouillage (optionnel, désactive toutes les radios)
- 🔋 **Économie de batterie** - Activer le mode économie de batterie au verrouillage (optionnel)

### **Fonctions avancées**
- **Options de désactivation intelligente** :
  - **« Seulement si inutilisé/non connecté »** - Ne désactivez pas le WiFi, Bluetooth ou la localisation s’ils sont activement utilisés
  - **« Seulement si non déjà activé »** - Évitez les réinitialisations de connexion en ne réactivant pas les fonctionnalités déjà activées
  - **« Seulement si non configuré manuellement »** - Respectez les modes de protection activés manuellement lors du déverrouillage

- **Exemptions d’applications** - Excluez des applications spécifiques des actions de confidentialité lorsqu’elles sont au premier plan
- **Réessai automatique NFC Samsung** - Fonctionnalité optionnelle pour contrer la substitution NFC du système de paiement Samsung (pour les séries Galaxy S, Note, Z)
- **Service d’accessibilité** - Support expérimental pour verrouillage instantané via bouton latéral/power (optionnel, nécessite la permission d’accessibilité)
- **Détection avancée** - Détection multi-niveaux des connexions Bluetooth pour éviter les déconnexions indésirables des casques

### **Temporisation personnalisable**
- **Délai de verrouillage** : 0-60 secondes (granulaire), 2 minutes, ou 5 minutes avant le déclenchement des actions de confidentialité
- **Délai de déverrouillage** : 0-60 secondes (granulaire), 2 minutes, ou 5 minutes avant la restauration des fonctionnalités
- **Mode instantané** : Réglez les délais à 0 pour une action immédiate
- **Note** : Caméra et microphone ignorent les délais personnalisés et se déclenchent immédiatement, en raison des limitations d’Android

## 📱 Exigences

**Minimum :** Android 7.0+ (niveau API 24)  
**Fonctionnalités Caméra/Microphone :** Android 12+ (niveau API 31)

**Choisissez votre méthode de privilège :**

### **Option 1 : Shizuku** (Pas besoin de root !)  
- Application **Shizuku** installée et active  
- **Privilèges ADB** via débogage USB ou ADB sans fil  
- **Pas de root nécessaire** - fonctionne avec les permissions au niveau ADB

### **Option 2 : Accès Root** (Recommandé pour appareils rootés)  
- **Accès root** via Magisk, SuperSU ou équivalent  
- **Meilleure performance** avec privilèges UID 0

### **Option 3 : Dhizuku** (Méthode Device Owner)  
- Statut **Device Owner** ou **Profile Owner**  
- **Pas de root nécessaire**, ni ADB après la configuration initiale  
- **Privilèges persistants** - survit aux redémarrages  
- **Idéal pour** : appareils d’entreprise, profils professionnels, configurations axées sur la confidentialité

### **Option 4 : Sui** (Le meilleur des deux mondes)  
- Appareil **rooté** avec Magisk installé
- Module **Sui Magisk** installé  
- **Meilleure expérience utilisateur** - pas de demandes d'autorisation, démarrage automatique  

### **Priorité de détection des privilèges**  
1. **Sui** - Module Magisk fournissant l'API Shizuku avec root (meilleure UX)  
2. **Root** - Accès root traditionnel via Magisk/SuperSU  
3. **Dhizuku** - Méthode Device Owner (pas de root ni ADB nécessaire après configuration)  
4. **Shizuku** - Privilèges ADB via l'application Shizuku  

## 🤝 Contribution  

Aidez à améliorer cette application. Aucune contribution n'est trop petite !  

### Comment contribuer  

1. **Forkez le dépôt**  
2. **Créez une branche de fonctionnalité** (`git checkout -b feature/amazing-feature`)  
3. **Faites vos modifications**  
4. **Validez vos modifications** (`git commit -m 'Add some amazing feature'`)  
5. **Poussez la branche** (`git push origin feature/amazing-feature`)  
6. **Ouvrez une Pull Request**  

Toutes les contributions sont **précieuses** et **appréciées** !  

## 📄 Licence  

Ce projet est sous licence MIT - voir le fichier [LICENSE](LICENSE) pour plus de détails.  

## 💖 Soutenir le développement  

PrivacyFlip protège votre vie privée. Vous pouvez protéger son avenir !  

[![DONATE](https://img.shields.io/badge/DONATE-FFD700?style=for-the-badge&logoColor=white)](https://buymeacoffee.com/ossdev)  

---  

*Des nuits tardives pour des jours plus lumineux*  

Créé par Doru Moraru  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-17

---
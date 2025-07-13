# Terminal de Paiement NFC

Un terminal de paiement NFC multi-chaînes qui traite les paiements en cryptomonnaies sur 5 réseaux blockchain avec une surveillance des transactions en temps réel et un suivi complet de l’historique.

## 🌐 Réseaux Pris en Charge

- **Ethereum**
- **Base**
- **Arbitrum**
- **Optimism**
- **Polygon**

### 🎯 **Priorité de Paiement Intelligente**

Au lieu de négocier une combinaison chaîne / jeton avec le commerçant, le terminal de paiement s’en charge automatiquement. Il identifie d’abord une chaîne prise en charge par le commerçant sur laquelle vous disposez également de fonds, puis envoie une transaction en ETH ou en jeton ERC-20 selon cette priorité :

```
Stablecoin L2 > Autre L2 > ETH L2 > Stablecoin L1 > Autre L1 > ETH L1
```
## 🚀 Démarrage rapide

1. **Installer les dépendances :**
   ```bash
   npm install
   ```

2. **Configuration de l'environnement :**
   ```bash
   echo "ALCHEMY_API_KEY=your_alchemy_api_key_here" > .env
   ```

3. **Lancer le terminal :**
   ```bash
   npm start
   ```

4. **Ouvrir l'interface :**
   Rendez-vous sur `http://localhost:3000`
## 🏗️ Architecture

```
src/
├── server.ts                   # Serveur Express & gestionnaire WebSocket
├── app.ts                      # Orchestrateur principal de l'application
├── web/index.html              # Interface utilisateur du terminal de paiement
├── config/index.ts             # Configuration multi-chaînes
└── services/
    ├── nfcService.ts           # Lecteur NFC & scan de portefeuille
    ├── alchemyService.ts       # Solde multi-chaînes & surveillance
    ├── paymentService.ts       # Sélection de paiement & génération EIP-681
    ├── ethereumService.ts      # Utilitaires de validation d'adresse
    └── addressProcessor.ts     # Prévention du traitement des doublons
scripts/
└── rpi-deploy/
    ├── setup-build-environment.sh  # Installer les dépendances pour permettre la création d'une image Raspberry Pi
    └── build-pi-image-osx.sh       # Créer une image Raspberry Pi
```
## 💡 Utilisation

### **Traitement des paiements**
1. Saisissez le montant à l'aide du pavé numérique (en centimes : "150" = 1,50 $)
2. Appuyez sur "Charger" pour lancer le paiement
3. Le client approche son appareil NFC pour effectuer le paiement
4. La surveillance en temps réel confirme la transaction
5. Message "Approuvé" avec lien vers l’explorateur de blocs

### **Historique des transactions**
1. Appuyez sur le bouton 📜 historique du pavé numérique
2. Consultez toutes les transactions ou scannez un portefeuille pour un historique spécifique
3. Appuyez sur "📱 Scanner le portefeuille pour l’historique" et demandez au client d’approcher son appareil
4. Parcourez les transactions filtrées pour ce portefeuille spécifique


## 🔄 Flux de paiement

1. **Détection NFC** → Le client approche son appareil
2. **Récupération multi-chaînes** → Analyse du portefeuille sur les 6 chaînes
3. **Sélection intelligente** → Jeton de paiement optimal selon le système de priorité
4. **Génération EIP-681** → Demande de paiement avec ID de chaîne
5. **Surveillance en temps réel** → WebSocket/interrogation pour confirmation de transaction
6. **Enregistrement de l’historique** → Transaction enregistrée avec toutes les métadonnées
## 🛡️ Surveillance des Transactions

- **Surveillance WebSocket** pour Ethereum, Base, Arbitrum, Optimism, Polygon
- **Surveillance par sondage** en mode de secours
- **Délai d’expiration automatique** après 5 minutes
- **Intégration avec des explorateurs de blocs** pour la vérification des transactions
- **Suivi du statut** : détectée → confirmée → échouée

## 🍓 Déploiement sur Raspberry Pi

Ce terminal de paiement NFC peut être déployé comme un **kiosque plug-and-play** sur du matériel Raspberry Pi pour une utilisation en production.

### **Exigences Matérielles**
- Raspberry Pi 4B (4 Go+ de RAM recommandés)
- Écran tactile officiel Raspberry Pi 7"
- **Lecteur NFC ACR1252U-M1** (spécifiquement pris en charge)
- Carte MicroSD 32 Go ou plus

### **Fonctionnalités de Déploiement**
- **Construction en une commande** pour créer une image SD amorçable
- **WiFi préconfiguré** et identifiants API
- **Démarrage automatique** en mode kiosque plein écran
- **Validation de sécurité** pour empêcher le déploiement avec des adresses de test
- Prise en charge de la construction sur **macOS et Linux**
### **Déploiement Rapide**
```bash
# Accédez aux scripts de déploiement
cd scripts/rpi-deploy

# Configurez votre déploiement
cp build-config.env.template build-config.env
# Modifiez build-config.env avec votre WiFi, clé API et adresse du commerçant

# Construisez l'image bootable (macOS)
./build-pi-image-osx.sh

# Flashez le fichier nfc-terminal-<date>.img.gz généré sur la carte SD à l'aide de Raspberry Pi Imager et démarrez !
```

📖 **[Guide de Déploiement Complet](https://raw.githubusercontent.com/FreePayPOS/merchant-app/main/README-DEPLOYMENT.md)**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---
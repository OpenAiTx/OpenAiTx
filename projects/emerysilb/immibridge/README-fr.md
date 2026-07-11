<p align="center">
  <img src="https://raw.githubusercontent.com/emerysilb/immibridge/main/./assets/icon-transparent.png" alt="ImmiBridge" width="128">
</p>

<h1 align="center">ImmiBridge</h1>

<p align="center">
  <a href="https://opensource.org/licenses/MIT"><img src="https://img.shields.io/badge/License-MIT-yellow.svg" alt="Licence : MIT"></a>
  <a href="https://www.apple.com/macos/"><img src="https://img.shields.io/badge/macOS-12.0+-blue.svg" alt="macOS"></a>
</p>

<p align="center">
  <a href="https://github.com/emerysilb/immibridge/releases/"><img src="https://img.shields.io/badge/Télécharger-Dernière%20version-blue?style=for-the-badge" alt="Télécharger la dernière version"></a>
</p>

Sauvegardez votre bibliothèque Apple Photos dans un dossier organisé par date de capture, ou directement sur un serveur [Immich](https://immich.app). Exporte les originaux (y compris les vidéos associées aux Live Photos) et, en option, les modifications rendues.

<p align="center">
  <img src="https://raw.githubusercontent.com/emerysilb/immibridge/main/./assets/screenshot.png" alt="Capture d'écran ImmiBridge" width="700">
</p>

## Fonctionnalités

- Exporter les photos vers des dossiers locaux organisés par date
- Télécharger directement vers les serveurs photo Immich
- Modes de sauvegarde incrémentale, complète ou miroir
- Filtrer par albums, type de média ou date
- Mettre en pause et reprendre les sauvegardes
- Sauvegardes automatiques planifiées
- Intégration à la barre de menu
- Téléchargement des photos iCloud avec suivi de progression
- Synchronisation uniquement des métadonnées (mettre à jour les métadonnées sans re-télécharger les fichiers)
- Mises à jour automatiques via Sparkle

## Installation

### Téléchargement (Recommandé)

1. Téléchargez `ImmiBridge-x.x.x.dmg` depuis la page [Releases](../../releases)
2. Ouvrez le DMG et glissez ImmiBridge dans votre dossier Applications
3. Lancez ImmiBridge depuis Applications  
4. Accordez l’accès aux Photos lorsqu’on vous le demande  

### Construire à partir des sources  

Voir [CONTRIBUTING.md](https://raw.githubusercontent.com/emerysilb/immibridge/main/CONTRIBUTING.md) pour des instructions détaillées de compilation.  

**Démarrage rapide :**

```bash
# Clone the repository
git clone https://github.com/emerysilb/immibridge.git
cd immibridge

# Open in Xcode
open ImmiBridge/ImmiBridge.xcodeproj
```
### Création de versions signées

Pour créer un DMG notarié pour la distribution, vous avez besoin d’un certificat Apple Developer ID (99 $/an). Voir [CONTRIBUTING.md](https://raw.githubusercontent.com/emerysilb/immibridge/main/CONTRIBUTING.md#creating-a-signed-release) pour plus de détails.

## Utilisation

Lancez ImmiBridge et configurez :

1. **Source** : Choisissez la bibliothèque Photos et/ou des dossiers personnalisés  
2. **Destination** : Dossier local et/ou serveur Immich  
3. **Options** : Mode de sauvegarde, filtres, planification

### Modes de sauvegarde

| Mode | Exporte | Utilise un manifeste | Supprime de la destination |
|------|---------|---------------------|----------------------------|
| **Incrémentiel intelligent** | Seulement les fichiers nouveaux/modifiés | Oui | Non |
| **Complet** | Tout, à chaque fois | Non | Non |
| **Miroir** | Seulement les fichiers nouveaux/modifiés | Oui | Oui (fichiers orphelins) |

### Intégration Immich

Pour vous connecter à votre serveur Immich :

1. Allez dans l’onglet **Destination**  
2. Entrez l’URL de votre serveur Immich (ex., `http://192.168.1.100:2283`)  
3. Entrez votre clé API (générez-en une dans Immich sous Paramètres utilisateur → Clés API)  
4. Cliquez sur **Tester la connexion**

**Fonctionnalités :**  
- Utilise des sommes de contrôle SHA1 pour éviter les doublons d’upload  
- Les Live Photos sont téléchargées en vidéo + image fixe associée  
- Supporte la synchronisation des albums vers Immich

## Permissions

Lors du premier lancement, macOS demandera :

- **Accès aux Photos** : Nécessaire pour lire votre bibliothèque photos

- **Accès au réseau local** : Requis si votre serveur Immich est sur votre réseau local

Si vous refusez une autorisation, réactivez-la dans **Paramètres Système → Confidentialité & Sécurité**.

## Contribution

Les contributions sont les bienvenues ! Consultez [CONTRIBUTING.md](https://raw.githubusercontent.com/emerysilb/immibridge/main/CONTRIBUTING.md) pour les directives.

## Licence

Licence MIT - voir [LICENSE](LICENSE) pour plus de détails.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-11

---
# 🌐 OnionHoster v2.2

> **L'outil ultime d'hébergement de services cachés Tor** - Déployez vos projets web sur le dark web en quelques minutes !

[![Version](https://img.shields.io/badge/version-2.2-brightgreen.svg)](https://github.com/BlackHatDevX/onionhoster)
[![Platform](https://img.shields.io/badge/platform-Linux%20%7C%20macOS-blue.svg)](https://github.com/BlackHatDevX/onionhoster)
[![License](https://img.shields.io/badge/license-MIT-green.svg)](https://github.com/BlackHatDevX/onionhoster)

---

## 🚀 Qu'est-ce qu'OnionHoster ?

OnionHoster est un script bash puissant et multiplateforme qui transforme n'importe quel projet web en service caché Tor en une seule commande. Que vous hébergiez une application Next.js, un backend Flask ou un site statique, OnionHoster gère automatiquement toute la configuration complexe de Tor.

### ✨ Pourquoi choisir OnionHoster ?

- **🔧 Zéro configuration** - Fonctionne directement avec n'importe quel projet web
- **🌍 Multiplateforme** - Supporte Linux, macOS et les principales distributions
- **⚡ Installation en un clic** - De zéro à service caché en moins de 2 minutes
- **🔄 Mises à jour automatiques** - Le vérificateur intégré vous maintient à jour
- **💾 Sauvegarde & Restauration** - Ne perdez jamais vos adresses onion
- **🎯 Interface professionnelle** - Interface colorée et menus intuitifs

---
## Aperçu

https://github.com/user-attachments/assets/b8fe44e8-2b1f-4fdc-bb52-7c4a5ee2c67e


# ⚠️ Avertissement : OnionHoster n'est PAS un outil magique d'anonymat — suivez les bonnes pratiques ou risquez la dé-anonymisation

**Renforcement du système**

* Exécutez le service dans une VM ou un conteneur pour l'isolation.
* Maintenez le système d'exploitation et les paquets à jour.
* Désactivez les services/ports inutiles pour que seul le trafic Tor entre/sorte.

**Pratiques OpSec**

* N'utilisez pas la même machine pour des comptes ou activités personnels.
* Évitez d’exposer des métadonnées identifiantes (noms de fichiers, en-têtes, messages d’erreur).
* Faites attention aux journaux — ce que vous consignez, la durée de conservation, et s’ils divulguent des informations.

**Hygiène Réseau**

* Ne reliez pas votre service caché à votre identité ou domaine clearnet.
* Utilisez un pare-feu pour éviter toute fuite accidentelle hors de Tor.
* Envisagez des reverse proxies pour une isolation supplémentaire.

**Tests & Surveillance**

* Utilisez torsocks ou le navigateur Tor pour vérifier que votre service est accessible uniquement via son adresse `.onion`.
* Testez régulièrement les fuites (par exemple, si votre application tente de récupérer des données depuis le clearnet).

**Conscience du Cas d’Usage**

* Pour un usage loisir/test/éducatif : ce qui précède est généralement suffisant.
* Pour l’anonymat réel à haut risque (journalistes, lanceurs d’alerte, activistes) : cela requiert une sécurité opérationnelle plus poussée et une modélisation des menaces, car une seule erreur peut vous dé-anonymiser.


---
## 🎯 Parfait Pour

- **Développeurs** souhaitant tester leurs applications sur Tor
- **Défenseurs de la vie privée** hébergeant des services anonymes
- **Chercheurs** étudiant les technologies du dark web
- **Entreprises** nécessitant des solutions d’hébergement anonymes
- **Passionnés** explorant le réseau Tor

---

## 🚀 Démarrage Rapide

### Prérequis
- Accès root/sudo
- Connexion Internet
- N’importe quel projet web (HTML, Next.js, Flask, etc.)

### Installation & Utilisation

```bash
# 1. Clone the repository
git clone https://github.com/BlackHatDevX/onionhoster.git

# 2. Navigate to the directory
cd onionhoster

# 3. Make the script executable
chmod +x onionhoster.sh

# 4. Run with sudo
sudo bash onionhoster.sh
```

**C’est tout !** 🎉

Vous recevrez le projet complet OnionHoster incluant :
- Le script principal `onionhoster.sh`
- Un modèle professionnel `index.html` à héberger
- Toute la documentation et les exemples

Le script fera automatiquement :
- Détecter votre système d’exploitation
- Installer toutes les dépendances requises (Tor, Apache, etc.)
- Configurer les services Tor
- Vous présenter un menu intuitif

---

## 🎮 Vue d’ensemble des fonctionnalités

### 🌐 Options d’hébergement
- **HTML statique** - Hébergez n’importe quel fichier `index.html`
- **Redirection de port** - Rediriger vers n’importe quel port d’application locale
- **Applications dynamiques** - Support pour Next.js, Flask, Node.js, et plus

### 🛠️ Outils de gestion
- **Contrôle des services** - Démarrer, arrêter, et gérer votre service caché
- **Sauvegarde & restauration** - Sauvegarder et restaurer en toute sécurité vos domaines onion
- **Rafraîchissement URL** - Générer de nouvelles adresses onion lorsque nécessaire
- **Surveillance du statut** - Vérifier la santé et le statut du service

### 🔄 Mises à jour intelligentes
- **Auto-détection** - Trouve automatiquement la dernière version
- **Mises à jour en un clic** - Mettre à jour via une seule option de menu
- **Mises à jour sécurisées** - Aucun risque de perdre votre configuration

---

## 📱 Systèmes d’exploitation supportés

| OS | Gestionnaire de paquets | Statut |
|----|------------------------|--------|
| **Ubuntu/Debian** | `apt-get` | ✅ Support complet |
| **CentOS/RHEL** | `yum` | ✅ Support complet |
| **Fedora** | `dnf` | ✅ Support complet |
| **Arch Linux** | `pacman` | ✅ Support complet |
| **macOS** | `brew` | ✅ Support complet |

---

## 🎯 Cas d'utilisation

### 🏠 Projets personnels
- Hébergez votre portfolio anonymement
- Testez des applications web en privé
- Partagez du contenu sans révéler votre identité

### 🏢 Applications professionnelles
- Portails de support client anonymes
- Systèmes de communication interne sécurisés
- Sites web d'entreprise axés sur la confidentialité

### 🔬 Recherche & Développement
- Recherche sur les technologies du dark web
- Développement d'outils de confidentialité
- Tests de services anonymes

---

## 📖 Utilisation détaillée

### Options du menu principal

1. **Héberger index.html** - Servir un fichier HTML statique
2. **Rediriger vers un port d'application** - Proxy vers un service local
3. **Sauvegarder le domaine tor** - Enregistrer votre configuration onion
4. **Restaurer le domaine tor** - Restaurer à partir de la sauvegarde
5. **Afficher le domaine tor actuel** - Voir votre adresse onion active
6. **Rafraîchir le domaine tor** - Générer une nouvelle adresse onion
7. **Vérifier les mises à jour** - Mettre à jour vers la dernière version
8. **Statut du serveur web** - Surveiller la santé du service
9. **À propos de OnionHoster** - Informations sur la version et les fonctionnalités

### Exemple de flux de travail

```bash
# Start the service
sudo ./onionhoster.sh

# Choose option 1 to host index.html
# Your onion address will be displayed
# Access it via Tor Browser or similar
```

---

## 🔧 Configuration avancée

### Redirection de port personnalisée
```bash
# Forward your Next.js app running on port 3000
# The script will handle all Tor configuration automatically
```

### Gestion des sauvegardes
```bash
# Automatic backups are stored in ~/onion_backups/
# Each backup includes your onion keys and configuration
```

---

## 🛡️ Fonctionnalités de Sécurité

- **Configuration Automatique de Tor** - Paramètres sécurisés dès l'installation
- **Permissions de Fichiers Appropriées** - Propriété et accès aux fichiers sécurisés
- **Isolation des Services** - Chaque service caché fonctionne indépendamment
- **Aucune Journalisation des Données** - Vos activités restent privées

---

## 🚨 Notes Importantes

- **Accès Root Requis** - Les services Tor nécessitent une configuration au niveau système
- **Réseau Tor** - Votre service sera accessible via le navigateur Tor
- **Adresses Onion** - Chaque service obtient une adresse `.onion` unique
- **Sauvegardez Régulièrement** - Les adresses onion changent lors du rafraîchissement

---

## 🤝 Contribution

Nous accueillons les contributions ! Que ce soit :
- 🐛 Rapports de bugs
- 💡 Requêtes de fonctionnalités
- 📝 Améliorations de la documentation
- 🔧 Contributions de code

**Commencez par :**
1. Forker le dépôt
2. Créer une branche de fonctionnalité
3. Apporter vos modifications
4. Soumettre une pull request

---

## 📄 Licence

Ce projet est sous licence MIT - voir le fichier [LICENSE](LICENSE) pour les détails.

---

## 🙏 Remerciements

- **Tor Project** - Pour l'incroyable réseau d'anonymat  
- **Communauté Open Source** - Pour les améliorations continues  
- **Utilisateurs & Contributeurs** - Pour les retours et suggestions  

---

## 🔗 Liens

- **GitHub** : [https://github.com/BlackHatDevX/onionhoster](https://github.com/BlackHatDevX/onionhoster)  
- **Problèmes** : [https://github.com/BlackHatDevX/onionhoster/issues](https://github.com/BlackHatDevX/onionhoster/issues)  
- **Discussions** : [https://github.com/BlackHatDevX/onionhoster/discussions](https://github.com/BlackHatDevX/onionhoster/discussions)  

---

## ⭐ Étoilez ce projet

Si OnionHoster vous aide, merci de lui donner une étoile ! Cela nous motive à continuer d'améliorer et aide les autres à découvrir cet outil.  

---

**Prêt à devenir anonyme ?** 🕵️‍♂️  

```bash
git clone https://github.com/BlackHatDevX/onionhoster.git
cd onionhoster
sudo bash onionhoster.sh
```
*Votre voyage vers l'hébergement anonyme commence maintenant !* 🚀



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-18

---
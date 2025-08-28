<details align="right">
<summary>🌐 Langue</summary>

[English](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=th) | [Français](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=de) | [Español](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=it) | [Русский](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ru) | [Português](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=as)
</details>

# OnionHoster v2.2

> **L’outil ultime d’hébergement de services cachés Tor** - Déployez vos projets web sur le dark web en quelques minutes !
> 
[![Version](https://img.shields.io/badge/version-2.2-brightgreen.svg)](https://github.com/BlackHatDevX/onionhoster)
[![Plateforme](https://img.shields.io/badge/platform-Linux%20%7C%20macOS-blue.svg)](https://github.com/BlackHatDevX/onionhoster)
[![Licence](https://img.shields.io/badge/license-MIT-green.svg)](https://github.com/BlackHatDevX/onionhoster)

<img width="1023" height="551" alt="ChatGPT Image Aug 27, 2025, 03_32_08 PM (1)-modified" src="https://github.com/user-attachments/assets/92b6e834-2d4f-4cc7-8f77-82b9bafba8a5" />


---

## 🚀 Qu’est-ce que OnionHoster ?

OnionHoster est un script bash puissant et multiplateforme qui transforme n’importe quel projet web en service caché Tor en une seule commande. Que vous hébergiez une application Next.js, un backend Flask ou un site statique, OnionHoster gère automatiquement toute la configuration complexe de Tor.

### ✨ Pourquoi choisir OnionHoster ?

- **🔧 Zéro configuration** - Fonctionne immédiatement avec tout projet web
- **🌍 Multiplateforme** - Compatible Linux, macOS et principales distributions
- **⚡ Installation en un clic** - De zéro à service caché en moins de 2 minutes
- **🔄 Mises à jour automatiques** - Vérificateur intégré pour rester à jour
- **💾 Sauvegarde & restauration** - Ne perdez jamais vos adresses onion
- **🎯 Interface professionnelle** - Belle interface colorée avec menus intuitifs

---
## Aperçu

[![IMAGE ALT TEXT HERE](https://github.com/user-attachments/assets/4b35dfb0-0059-4cc5-99c7-a5b9467a385d)](https://www.youtube.com/watch?v=oPvhA54Tp8w)


# ⚠️ Attention : OnionHoster n’est PAS un outil magique d’anonymat — appliquez les bonnes pratiques ou risquez d’être dé-anonymisé

**Renforcement du système**

* Exécutez le service dans une VM ou un conteneur pour l’isolation.

* Gardez le système d'exploitation et les paquets à jour.
* Désactivez les services/ports inutiles afin que seul le trafic Tor entre et sorte.

**Pratiques OpSec**

* N'utilisez pas la même machine pour des comptes ou activités personnels.
* Évitez d'exposer des métadonnées identifiantes (noms de fichiers, en-têtes, messages d'erreur).
* Soyez attentif aux journaux — ce que vous consignez, combien de temps vous les conservez, et s'ils divulguent des infos.

**Hygiène Réseau**

* Ne reliez pas votre service caché à votre identité ou domaine clearnet.
* Utilisez un pare-feu pour éviter toute fuite accidentelle en dehors de Tor.
* Envisagez des proxies inverses pour une isolation supplémentaire.

**Tests & Surveillance**

* Utilisez torsocks ou le navigateur Tor pour vérifier que votre service n'est accessible que via son adresse `.onion`.
* Testez régulièrement les fuites (par exemple, si votre application tente d'accéder au clearnet).

**Connaissance des Cas d'Utilisation**

* Pour un usage loisir/test/éducatif : ce qui précède est généralement suffisant.
* Pour l'anonymat réel à haut risque (journalistes, lanceurs d’alerte, activistes) : cela demande une sécurité opérationnelle et une modélisation des menaces plus poussées, car une seule erreur peut vous désanonymiser.


---
## 🎯 Parfait pour

- **Développeurs** qui souhaitent tester leurs applications sur Tor
- **Défenseurs de la vie privée** hébergeant des services anonymes (
- **Chercheurs** étudiant les technologies du dark web
- **Entreprises** nécessitant des solutions d’hébergement anonymes
- **Amateurs** explorant le réseau Tor

---

## 🚀 Démarrage rapide

### Prérequis
- Accès root/sudo
- Connexion Internet
- Tout projet web (HTML, Next.js, Flask, etc.)

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-28

---
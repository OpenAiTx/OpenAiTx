<p align="center">
    <img src="https://raw.githubusercontent.com/DrizzleTime/Foxel/dev/Web/public/logo.png" alt="Foxel Logo" width="150"><br>
    <strong>Foxel - Système intelligent de recherche et gestion d'images</strong>
</p>
<p align="center">
    <a href="#-核心功能"><img src="https://img.shields.io/badge/功能-Features-blue?style=for-the-badge" alt="核心功能"></a>
    <a href="#-部署指南"><img src="https://img.shields.io/badge/部署-Deploy-orange?style=for-the-badge" alt="部署"></a>
    <a href="#-贡献指南"><img src="https://img.shields.io/badge/贡献-Contribute-brightgreen?style=for-the-badge" alt="贡献"></a>
    
</p>

<p>
    <strong>Foxel</strong> est un système moderne de recherche et gestion d'images intelligentes développé sur la base de <strong>.NET 9</strong>, intégrant des <strong>modèles visuels AI</strong> avancés et des <strong>technologies d'encastrement vectoriel</strong>, offrant des fonctions efficaces de recherche et gestion d'images.
</p>

---

> 🖥️ **Démo en ligne :**  
> Visitez [https://demo.foxel.cc](https://foxel.cc) pour tester certaines fonctionnalités de Foxel.  
> Compte administrateur : `demo@foxel.cc` Mot de passe : `foxel_demo`  
> ⚠️ **Attention : les données de l'environnement de démo peuvent être nettoyées périodiquement, ne stockez pas d'informations importantes.**

---

## 🌐 Communauté

Rejoignez notre communauté, échangez avec d'autres utilisateurs, obtenez du support technique, participez aux discussions du projet :

|     Plateforme     | Informations du groupe                                  | Contact                                                                     |
|:----------:|:----------------------------------------------------|:-------------------------------------------------------------------------|
| 📱 **WeChat** | **Nom du groupe :** Foxel petit renard <br>*Si le QR code ne fonctionne plus, ajoutez `drizzle2001` pour rejoindre le groupe* | <img src="https://foxel.cc/Uploads/wechat.png" alt="微信群二维码" width="100"> |

> 💡 **Règles de la communauté :**
> - Restez bienveillants et entraidez-vous
> - Fournissez des informations détaillées lors de vos questions
> - Pas de publicité non liée au projet
> - Respectez les règles des différentes plateformes

## ✨ Fonctionnalités principales

### 🔍 Recherche d'images intelligente
- [x] Recherche en langage naturel - Compréhension et recherche d'images basée sur l'IA
- [x] Recherche d'images similaires - Localisation rapide d'images au contenu similaire
- [x] Filtrage conditionnel - Filtrage précis par date, taille, format, etc.
- [x] Recherche avancée - Combinaison multidimensionnelle des critères de recherche

### 🗂️ Gestion d'images
- [x] Téléversement d'images - Supporte le glisser-déposer et le téléversement en masse
- [x] Hébergement anonyme d'images - Téléversez et partagez sans inscription
- [x] Catégorisation et étiquetage - Gestion flexible des catégories et tags d’images
- [x] Opérations en masse - Suppression, déplacement, marquage groupés d’images
- [x] Génération de vignettes - Création automatique de miniatures de différentes tailles
- [x] Conversion WebP - Conversion intelligente des formats pour optimiser l’espace de stockage

### 🤖 Fonctionnalités IA intelligentes
- [x] Reconnaissance faciale - Détection et identification automatique des visages dans les images
- [x] Description d’image par IA - Génération intelligente de descriptions du contenu des images
- [x] Classification automatique IA - Classification intelligente des images basée sur le contenu
- [ ] Détection d’objets - Identification des différents objets présents dans les images
- [ ] Reconnaissance de scènes - Identification automatique des scènes de prise de vue

### 💾 Fonctionnalités de stockage
- [x] Stockage local - Stockage des fichiers sur le serveur local
- [x] Canal Telegram - Stockage cloud basé sur Telegram
- [x] Amazon S3 - Stockage objet compatible avec le protocole S3
- [x] Tencent Cloud COS - Service de stockage objet Tencent Cloud
- [x] Configuration multi-stockage - Support de plusieurs backend de stockage simultanément
- [x] WebDAV - Stockage via le protocole standard WebDAV

### 👥 Fonctionnalités utilisateur
- [x] Inscription et connexion utilisateur - Système complet de gestion des comptes utilisateurs
- [x] Connexion tierce via GitHub - Support de connexion rapide avec compte GitHub
- [x] Connexion tierce via LinuxDo - Support de connexion avec compte communauté LinuxDo
- [x] Gestion des permissions - Contrôle des rôles et permissions multiples
- [ ] Groupes d’utilisateurs - Gestion des groupes d’utilisateurs
- [x] Profil personnel - Gestion complète des informations utilisateur

### 💬 Fonctionnalités sociales
- [x] Likes d’images - Aimer les images favorites
- [x] Favoris d’images - Sauvegarder les images intéressantes
- [ ] Système de commentaires - Commentaires et interactions sur les images
- [ ] Fonction de partage - Partage d’images sur plusieurs plateformes
- [ ] Système de suivi - Suivre d’autres utilisateurs

---

## 🚀 Guide de déploiement

> ⚠️ **Important :**  
> Foxel est actuellement en phase de développement précoce, adapté pour une **expérience de découverte** et des tests fonctionnels. La version actuelle peut contenir des **changements destructifs** lors des mises à jour, aucun processus de migration de données n’est disponible, la réinstallation est nécessaire. Pour une **utilisation stable à long terme**, il est recommandé d’attendre la sortie de la version **Preview**, qui proposera un processus de mise à jour automatisé complet.

Foxel propose plusieurs méthodes de déploiement pour répondre à différents besoins :

- 🐳 **Déploiement en un clic avec Docker Compose** - Recommandé pour les débutants
- 🐋 **Déploiement conteneur unique Docker** - Idéal pour bases de données personnalisées
- 🔧 **Compilation depuis le code source** - Pour les développeurs

📖 **Pour un tutoriel détaillé, consultez : [https://foxel.cc/guide/getting-started.html](https://foxel.cc/guide/getting-started.html)**

---
## 🤝 Guide de contribution

Nous accueillons tous les développeurs intéressés par Foxel à contribuer pour améliorer et faire évoluer ce projet.

|      Étape      | Description                                                                                   |
|:------------:|:--------------------------------------------------------------------------------------------|
| **Soumettre un Issue** | - En cas de bug ou de suggestion, veuillez soumettre un issue.<br>- Merci de décrire en détail le problème et les étapes pour le reproduire afin de faciliter la localisation et la correction rapide. |
|   **Contribuer du code**   | - Forkez ce projet et créez une nouvelle branche.<br>- Respectez les normes de codage du projet.                                         |
|   **Extension des fonctionnalités**   | - Participation bienvenue pour le développement des fonctionnalités clés suivantes :<br>• Algorithmes de recherche d’images plus intelligents<br>• Interaction sociale améliorée<br>• Intégration cloud/disques en ligne<br>• Plus de méthodes de traitement d’images intelligentes (comme annotation automatique, transfert de style, amélioration d’image, etc.) |

Pour toute question ou suggestion, n’hésitez pas à nous contacter via un issue. Merci pour votre contribution !


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-28

---
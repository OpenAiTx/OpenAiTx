# 🚀 AndroBuster

<div align="center">
  <img width="2808" height="699" alt="bannerfinal" src="https://github.com/user-attachments/assets/7f74539f-0af6-40d9-bafb-9207afd80af8" />

</div> 

<div align="center">

**🔒 Pentesting Simplifié**  
*Un puissant outil d'énumération de répertoires et sous-domaines construit avec Flutter*

[![Télécharger APK](https://img.shields.io/badge/Download-APK-blue?style=for-the-badge&logo=android)](https://github.com/BlackHatDevX/androbuster/releases)
[![Étoiles GitHub](https://img.shields.io/github/stars/BlackHatDevX/androbuster?style=for-the-badge&logo=github)](https://github.com/BlackHatDevX/androbuster)
[![Forks GitHub](https://img.shields.io/github/forks/BlackHatDevX/androbuster?style=for-the-badge&logo=github)](https://github.com/BlackHatDevX/androbuster)
[![Issues GitHub](https://img.shields.io/github/issues/BlackHatDevX/androbuster?style=for-the-badge&logo=github)](https://github.com/BlackHatDevX/androbuster/issues)

</div>

---

## 📖 Aperçu

AndroBuster est un **outil de sécurité open-source** inspiré de GoBuster, offrant une interface moderne et multiplateforme pour l'énumération de répertoires et de sous-domaines. Construit avec Flutter, il propose une expérience utilisateur propre et intuitive tout en conservant la puissance et la flexibilité attendues des outils professionnels de sécurité.

### 🎯 Qu'est-ce qui rend AndroBuster spécial ?
- 🚀 **Multiplateforme** : Fonctionne sur Android, iOS et Desktop
- 🔒 **Axé sur la sécurité** : Conçu spécifiquement pour les testeurs d'intrusion
- 💻 **Interface moderne** : Interface élégante basée sur Flutter
- ⚡ **Haute performance** : Gestion efficace des threads et de la mémoire
- 📱 **Mobile-First** : Optimisé pour les tests de sécurité mobiles

---

## 🖼️ Captures d'écran

<div align="center">

<img width="339" height="749" alt="Capture d'écran 2025-08-20 à 1 11 24 AM" src="https://github.com/user-attachments/assets/e12ed93e-876f-408b-9e3d-4a849e8fe2a1" />
<img width="339" height="749" alt="Capture d'écran 2025-08-20 à 1 11 34 AM" src="https://github.com/user-attachments/assets/17850561-cef9-46e2-8203-8ba29c223fe7" />
</div>

---



## ✨ Fonctionnalités

### 🗂️ Mode d'Énumération de Répertoire
- **Entrée URL Cible** : Gestion propre des URL avec suppression automatique du slash final
- **Codes d'État Négatifs** : Filtrage des codes d'état HTTP indésirables (par défaut : 404)
- **Tailles de Page Négatives** : Exclusion des réponses selon la longueur du contenu
- **Support de Liste de Mots** : Entrée de texte volumineuse avec capacité d'import de fichier
- **Contrôle du Multithreading** : Nombre de threads configurable pour performance optimale
- **Paramètres de Timeout** : Délai d'attente personnalisable en millisecondes

### 🌐 Mode d'Énumération de Sous-domaines
- **Entrée de Domaine** : Gestion propre des domaines (http/https non requis)
- **Listes de Mots pour Sous-domaines** : Gestion dédiée des listes de mots pour découverte de sous-domaines
- **Test de Protocole** : Test automatique de basculement HTTPS/HTTP
- **Validation de Sous-domaines** : Validation conforme RFC 1123 des noms de sous-domaines
- **Filtres Dédiés** : Codes d'état négatifs et tailles de page séparés pour les sous-domaines
- **Multithreading & Timeout** : Configuration indépendante du mode répertoire

### 📋 Gestion des Résultats
- **Onglet Résultats Unifié** : Affichage des résultats de scans de répertoires et sous-domaines
- **Formatage des Résultats** : Affichage clair du chemin, code d'état, taille et URL
- **Copier dans le Presse-papiers** : Export des résultats pour analyse externe
- **Effacer les Résultats** : Nettoyage facile entre les scans
- **Comptage des Résultats** : Suivi séparé des résultats répertoires et sous-domaines

### 📁 Gestion des Fichiers
- **Import de Liste de Mots** : Support des fichiers .txt jusqu'à 50 Mo
- **Aperçu Intelligent** : Affichage du contenu selon la taille du fichier
- **Gestion des Gros Fichiers** : Traitement efficace des listes de mots volumineuses
- **Support de Format** : Gestion automatique des commentaires (#) et lignes vides

### 🚀 Performance & Fiabilité
- **Exécution en Arrière-plan** : L'application continue de fonctionner pendant les scans en arrière-plan

- **Optimisation de la mémoire** : Gestion efficace des grandes listes de mots  
- **Gestion des erreurs** : Mécanismes de repli et de récupération gracieux  
- **Multi-plateforme** : Construit avec Flutter pour Android et iOS  

---

## 📱 Installation  

### 📦 Version Release  
Actuellement, seules les versions APK Android sont disponibles. Téléchargez la dernière APK depuis la page des releases.  

<div align="center">  

[![Télécharger la dernière](https://img.shields.io/badge/📥%20Download%20Latest%20Release-blue?style=for-the-badge)](https://github.com/BlackHatDevX/androbuster/releases)  

</div>  

### 🔧 Compilation depuis les sources  
Le code source est désormais public et disponible pour que chacun puisse l’utiliser, le modifier et y contribuer.  

---  

## 📖 Guide d’utilisation  

### 🗂️ Énumération de répertoires  
1. Naviguez à l’onglet « Dir »  
2. Entrez l’URL cible  
3. Configurez les codes d’état négatifs et la taille des pages  
4. Collez ou importez votre liste de mots  
5. Définissez le nombre de threads et le délai d’attente  
6. Lancez le scan et suivez la progression  

### 🌐 Énumération de sous-domaines  
1. Naviguez à l’onglet « Subdomain »  
2. Entrez le domaine cible (sans http/https)  
3. Configurez les filtres spécifiques aux sous-domaines  
4. Importez ou collez la liste de mots des sous-domaines  
5. Ajustez les paramètres de threading et de délai d’attente  


6. Commencer la découverte de sous-domaines

### 📋 Gestion des résultats
- Voir tous les résultats dans l'onglet "Résultats"
- Copier les résultats dans le presse-papiers pour une analyse externe
- Effacer les résultats entre les différentes analyses
- Surveiller la progression et l'achèvement de l'analyse

---

## ⚙️ Configuration

### ⚡ Nombre de threads
- **Recommandé** : 10-20 threads pour la plupart des scénarios
- **Alerte de threads élevés** : Avertissements lorsqu'on dépasse 20 threads
- **Considérations** : Un nombre élevé de threads peut déclencher une limitation de débit

### ⏱️ Paramètres de délai d'attente
- **Par défaut** : 5000 ms (5 secondes)
- **Ajustement** : Augmenter pour les réseaux lents, diminuer pour des réponses plus rapides
- **Plage** : De 1000 ms à 30000 ms supportée

### 🚫 Filtres négatifs
- **Codes d'état** : Liste séparée par des virgules (ex. : 404,403,500)
- **Tailles de page** : Liste séparée par des virgules (ex. : 0,1234,5678)
- **Objectif** : Exclure les réponses indésirables des résultats

---

## 🤝 Contribution

Ce projet est **open source** et accueille les contributions ! Le code source est désormais public et accessible à tous.

<div align="center">

[![Star Repository](https://img.shields.io/badge/⭐%20Star%20Repository-yellow?style=for-the-badge&logo=github)](https://github.com/BlackHatDevX/androbuster)

</div>

### 📋 Comment contribuer
1. **⭐ Étoile**z le dépôt (optionnel mais apprécié !)  
2. **🍴 Fork**ez le dépôt  
3. **🌿 Créez** une branche de fonctionnalité  
4. **📤 Soumettez** une demande de tirage  

---

## 🙏 Crédits & Remerciements  

- **🎯 Inspiré par** : [GoBuster](https://github.com/OJ/gobuster) - L’outil original d’énumération de répertoires  
- **🛠️ Construit avec** : [Flutter](https://flutter.dev/) - La boîte à outils UI de Google pour créer des applications compilées nativement  
- **🔒 Focus sur la sécurité** : Conçu pour les testeurs d’intrusion et chercheurs en sécurité  
- **🌍 Communauté** : Merci à tous les contributeurs et supporters  

---

## 📄 Licence  

Ce projet est **open source** et disponible sous la licence MIT.  

---

## ⚠️ Avertissement  

Cet outil est conçu uniquement pour des **tests de sécurité autorisés** et des **tests d’intrusion**. Les utilisateurs sont responsables de s’assurer qu’ils ont l’autorisation appropriée avant de tester tout système. Les développeurs ne sont pas responsables de toute mauvaise utilisation de cet outil.  

---


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-24

---
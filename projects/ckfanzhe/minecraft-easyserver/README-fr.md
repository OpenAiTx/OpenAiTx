# Panneau de Gestion Web pour Serveur Minecraft

**[版本中文版 (Version Chinoise)](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/README_CN.md)**

Un panneau de gestion web **léger** pour serveur Minecraft avec une interface moderne et des fonctionnalités complètes de gestion de serveur.

**Serveurs actuellement pris en charge :**
- ✅ Serveur Minecraft Bedrock
- Serveur Minecraft Java

## 🚀 Fonctionnalités

### 🌍 Téléchargement du Serveur Minecraft
- **Téléchargement du Serveur** Prise en charge du téléchargement des versions spécifiques du serveur directement depuis la page de gestion
- **Changement de Version du Serveur** Prise en charge du changement de version du serveur en un clic

### 🎮 Contrôle du Serveur
- **Démarrage/Arrêt/Redémarrage en un clic** du serveur Minecraft Bedrock
- **Surveillance en Temps Réel** Affichage de l’état de fonctionnement du serveur

### ⚙️ Gestion de la Configuration
- **Prise en charge de toutes les options majeures de configuration** :
  - Nom et description du serveur
  - Mode de jeu (Survie/Créatif/Aventure)
  - Réglages de la difficulté (Paisible/Faible/Normal/Difficile)
  - Nombre maximum de joueurs
  - Configuration du port du serveur
  - Bascules pour triches et liste blanche
- **Gestion automatique du fichier de configuration serveur** Maintient automatiquement le fichier `server.properties`

### 👥 Gestion de la Liste Blanche
- **Ajout/Suppression de joueurs** Gérer la liste des joueurs autorisés à rejoindre le serveur
- **Gestion du fichier liste blanche** Maintient automatiquement le fichier `allowlist.json`

### 🛡️ Gestion des Permissions
- **Système de permissions à trois niveaux** :
  - **Visiteur** - Permissions de jeu basiques
  - **Membre** - Permissions standards du joueur
  - **Opérateur** - Permissions administratives complètes
- **Paramètres des permissions des joueurs** Attribution de niveaux de permission à des joueurs spécifiques
- **Gestion des fichiers de permissions** Maintient automatiquement le fichier `permissions.json`

### 🌍 Gestion des mondes
- **Téléversement de fichiers monde** Support des formats `.zip` et `.mcworld` avec extraction automatique
- **Changement de monde** Activation en un clic de différents mondes
- **Suppression de monde** Suppression sécurisée des fichiers monde indésirables
- **Identification du monde actuel** Affichage clair du monde actuellement actif

### 🌍 Gestion des packs de ressources
- **Téléversement de fichiers ressources** Support des formats `.zip` et `.mcpack`
- **Activation des ressources** Activation en un clic de différents packs de ressources
- **Suppression des ressources** Suppression sécurisée des packs de ressources indésirables

### 📋 Journaux du serveur
- **Affichage des logs en temps réel** Surveillance des journaux du serveur Minecraft en temps réel via l’interface web
- **Défilement automatique** Option pour défiler automatiquement vers les dernières entrées de log

### 💻 Exécution de commandes
- **Saisie directe de commandes** Exécutez les commandes du serveur Minecraft directement depuis l’interface web
- **Historique des commandes** Visualisez et réutilisez les commandes précédemment exécutées
- **Commandes rapides** Accès aux commandes fréquemment utilisées via des boutons d’accès rapide catégorisés

### 🔐 Authentification & Sécurité
- **Système de connexion** Accès sécurisé au panneau de gestion par authentification par mot de passe
- **Gestion des sessions** Gestion automatique des sessions avec authentification sécurisée par jeton
- **Contrôle d’accès** Protection des fonctions de gestion du serveur contre les accès non autorisés

## 📋 Exigences système

### Environnement serveur
- **Système d’exploitation** : Windows 10+ ou Ubuntu 18.04+ (Linux)
- **Mémoire** : Au moins 2 Go de RAM
- **Stockage** : Au moins 10 Go d’espace disponible
- **Réseau** : Ports 8080 (panneau de gestion) et 19132 (serveur Minecraft) ouverts

## 🛠️ Guide d’installation

### Démarrage rapide (recommandé)


1. **Télécharger la version précompilée** :
   - Téléchargez la version appropriée pour votre système d'exploitation depuis la page [Releases](https://github.com/ckfanzhe/bedrock-easy-server/releases)
   - `minecraft-server-manager-windows.exe` pour Windows
   - `minecraft-server-manager-linux` pour Linux

2. **Lancer l'application** :

   ```bash
   # For Linux
   chmod +x minecraft-server-manager-linux
   ./minecraft-server-manager-linux
   
   # For Windows
   minecraft-server-manager-windows.exe
   ```

### Déploiement Docker

1. **Utilisation directe de Docker (Recommandé)** :
   ```bash
   # Create data directory for persistent storage
   mkdir -p data
   
   # Run the container using the published image
   docker run -d \
     --name minecraft-easyserver \
     -p 8080:8080 \
     -p 19132:19132/udp \
     -p 19133:19133/udp \
     -v ./data:/data/bedrock-server \
     -v ./config:/data/config \
     ifanzhe/minecraft-easyserver:latest
   ```

2. **Utilisation de Docker Compose** :
   ```bash
   # Create docker-compose.yml file
   cat > docker-compose.yml << EOF
   version: '3.8'
   services:
     minecraft-server-manager:
       image: ifanzhe/minecraft-easyserver:latest
       container_name: minecraft-easyserver
       ports:
         - "8080:8080"
         - "19132:19132/udp"
         - "19133:19133/udp"
       volumes:
         - ./data:/data/bedrock-server
         - ./config:/data/config
       environment:
         - TZ=Asia/Shanghai
       restart: unless-stopped
       healthcheck:
         test: ["CMD", "curl", "-f", "http://localhost:8080"]
         interval: 30s
         timeout: 10s
         retries: 3
   EOF
   
   # Start with Docker Compose
   docker-compose up -d
   ```

3. **Accéder à l'application** :
   - Ouvrez le navigateur et visitez : `http://localhost:8080`
   - Les données du serveur seront sauvegardées dans le répertoire `./data`

### Compiler depuis la source (pour les développeurs)

1. **Prérequis** : 
   - Go 1.21 ou supérieur
   - Node.js 16+ et npm (pour la compilation du frontend)

2. **Cloner le dépôt** :
   ```bash
   git clone https://github.com/ckfanzhe/bedrock-easy-server.git
   cd minecraft-easy-server
   ```
3. **Construire toutes les plateformes (Recommandé)** :

   ```bash
   chmod +x build.sh
   ./build.sh
   ```
   Ce script va :
   - Installer les dépendances frontend (`npm install`)
   - Compiler le frontend Vue.js (`npm run build`)
   - Copier les assets compilés dans le répertoire embed
   - Compiler les binaires Go pour toutes les plateformes avec le frontend intégré

4. **Étapes de construction manuelle** (si vous préférez étape par étape) :
   ```bash
   # Build frontend first
   cd minecraft-easyserver-web
   npm install
   npm run build
   cd ..
   
   # Copy frontend build output
   rm -rf web/*
   cp -r minecraft-easyserver-web/dist/* web/
   
   # Build Go binary
   go build -o minecraft-server-manager
   ```

**Note** : Le processus de construction inclut désormais la compilation frontend avec webpack, qui regroupe tous les composants Vue.js, styles et ressources en fichiers optimisés, lesquels sont ensuite intégrés dans le binaire Go pour un déploiement en un seul fichier.

## 🚀 Guide d'utilisation

### Démarrer le panneau de gestion

1. **Lancer l'application** :
   ```bash
   # For Linux
   ./minecraft-server-manager-linux
   
   # For Windows double-click to run
   minecraft-server-manager-windows.exe
   ```

2. **Interface de gestion d'accès** :
   - Ouvrez le navigateur et rendez-vous sur : `http://localhost:8080`
   - Le panneau de gestion se chargera automatiquement

## 🔥 Configuration du pare-feu

### Pare-feu Windows
Sur certains systèmes, lorsque vous souhaitez vous connecter au serveur à l’aide d’un client fonctionnant sur la même machine que le serveur, vous devrez exempté le client Minecraft des restrictions UWP de loopback :

```powershell
CheckNetIsolation.exe LoopbackExempt -a -p=S-1-15-2-1958404141-86561845-1752920682-3514627264-368642714-62675701-733520436
```

Assurez-vous que les ports suivants sont ouverts dans le pare-feu :
- **8080** : Port d'accès au panneau de gestion
- **19132** : Port par défaut du serveur Minecraft Bedrock
- **19133** : Port IPv6 du serveur Minecraft Bedrock

## 📝 Informations supplémentaires

### Fonctionnalités prévues (TODO)
- ✅ Support de l'importation de mods mcpackage en un clic
- ✅ Support du système d'exploitation Linux
- ✅ Visualisation en temps réel des logs du serveur Bedrock
- ✅ Exécution directe de commandes sur le serveur Bedrock via l'interface web
- 🔄 Surveillance du statut en ligne des joueurs
- ✅ Surveillance des performances du serveur
- 🔄 Fonctionnalité de sauvegarde automatique du monde
- ✅ Support multilingue de l'interface
- 🔄 Support du serveur Java - Support des serveurs Minecraft Java Edition
- ✅ Support Docker - Support du déploiement en conteneur

## 🤝 Contribution

N'hésitez pas à soumettre des rapports de bugs, suggestions de fonctionnalités et contributions de code !

### Configuration de l'environnement de développement
1. Forkez le dépôt du projet
2. Créez une branche de fonctionnalité : `git checkout -b feature/new-feature`
3. Commitez les modifications : `git commit -am 'Add new feature'`
4. Poussez la branche : `git push origin feature/new-feature`
5. Créez une Pull Request

### Normes de code
- Utilisez le formatage standard du code Go
- Ajoutez des commentaires et documentations appropriés
- Assurez-vous que le code passe les tests
- Suivez les modèles architecturaux du projet

## 📄 Licence

Ce projet est sous licence MIT - voir le fichier [LICENSE](LICENSE) pour plus de détails.

## 🙏 Remerciements

- [Gin Web Framework](https://gin-gonic.com/) - Framework web Go haute performance  
- [Tailwind CSS](https://tailwindcss.com/) - Framework CSS utilitaire-first  
- [Font Awesome](https://fontawesome.com/) - Bibliothèque d’icônes  
- [Minecraft Bedrock](https://www.minecraft.net/) - Serveur de jeu  

## 👀 Aperçu du panneau de gestion  
> Captures d’écran de certaines fonctionnalités, d’autres fonctionnalités sont à découvrir en personne.  

![Login Panel Preview](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/resources/en-login.png)  
![Dashboard Panel Preview](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/resources/en-dashboard.png)  
![Performance Panel Preview](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/resources/en-performance.png)  
![Server Download Panel Preview](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/resources/en-version.png)  
![Resource Panel Preview](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/resources/en-resource.png)  
![Worlds Panel Preview](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/resources/en-worlds.png)  
![Cmd Panel Preview](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/resources/en-cmd.png)  
![Server Config Panel Preview](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/resources/en-server-config.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-05

---
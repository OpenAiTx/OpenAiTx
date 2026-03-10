# 🏰️ qBittorrent + ProtonVPN (WireGuard) dans Docker (macOS)

**Exécutez qBittorrent en toute sécurité dans Docker avec ProtonVPN (WireGuard) en utilisant Gluetun, garantissant un routage VPN complet et un transfert de port automatique pour améliorer les performances du torrent.**

&#x20;

---

## 📌 Table des Matières

1. [Présentation](#overview)
2. [Fonctionnalités](#features)
3. [Prérequis](#prerequisites)
4. [Guide d’Installation](#installation-guide)
   - [Installer Docker](#install-docker)
   - [Cloner le Dépôt](#clone-the-repository)
   - [Configurer le ](#set-up-the-env-file)[`.env`](#set-up-the-env-file)[ Fichier](#set-up-the-env-file)
   - [Configurer l’Authentification](#configure-authentication)
   - [Démarrer les Conteneurs](#start-the-containers)
5. [Accéder à l’Interface Web de qBittorrent](#accessing-qbittorrent-web-ui)
6. [Sécurité & Bonnes Pratiques](#security--best-practices)
7. [Dépannage](#troubleshooting)
8. [Licence](#license)
9. [Contribuer](#contributing)
10. [Support & Retours](#support--feedback)

---

## 🔹 Présentation

Cette configuration garantit que **qBittorrent ne se connecte que via ProtonVPN (WireGuard)** en utilisant **Gluetun**, évitant les fuites et renforçant la sécurité.\
Elle **automatise également le transfert de port** pour de meilleures vitesses de torrent et **exécute tout dans Docker** pour une gestion simplifiée.

---

## ✅ Fonctionnalités

- **🔒 Torrenting avec VPN obligatoire** – Pas de fuite, tout le trafic circule **à l’intérieur** du VPN.
- **⚡ Transfert de port automatique** – Assure de meilleures vitesses et des connexions pairs améliorées.
- **🌐 Accès local à l’interface Web** – Contrôlez facilement les torrents via [`http://localhost:8080`](http://localhost:8080).
- **📺 Entièrement Conteneurisé** – Utilise Docker pour un déploiement, des mises à jour et une isolation faciles.  
- **🔄 Configuration Résiliente** – Les conteneurs **redémarrent automatiquement** en cas de plantage.  
- Utilise un **stockage séparé** pour les torrents incomplets et complétés  
- **Met à jour automatiquement les conteneurs avec Watchtower** 🛠️  

---  

## 🛠️ Prérequis  

- **Docker Desktop** (macOS/Windows/Linux)  
- **Docker Compose** (inclus avec Docker Desktop)  
- **Compte ProtonVPN** (Plus ou Visionary requis pour le support WireGuard)  

---  

## 📂 Guide d’Installation  

### **1️⃣ Installer Docker**  

Téléchargez et installez **Docker Desktop** depuis [ici](https://www.docker.com/products/docker-desktop/).  
Assurez-vous que Docker est **en cours d’exécution** avant de continuer.  

---  

### **2️⃣ Cloner le Répertoire**  

```sh
git clone https://github.com/torrentsec/qbittorrent-protonvpn-docker.git
cd qbittorrent-protonvpn-docker
```

---

### **3️⃣ Configurer le fichier **`.env`**

Ce projet utilise un fichier `.env` pour stocker des **valeurs de configuration sensibles** (qui sont ignorées par Git pour des raisons de sécurité).

#### **Créer votre fichier **`.env`****

```sh
cp .env.example .env
nano .env
```

#### **Remplissez les variables suivantes**

```ini
WIREGUARD_PRIVATE_KEY=your_private_key_here
SERVER_COUNTRIES="United Kingdom"
SERVER_CITIES="London"

PUID=1000
PGID=1000
TZ=Europe/London

GLUETUN_USER=your_admin_username
GLUETUN_PASS=your_admin_password

GSP_GTN_API_KEY=your_random_api_key_here
GSP_QBITTORRENT_PORT=your_forwarded_port_here
```

Save and close (`CTRL + X`, then `Y`, then `ENTER`).

---

### **4️⃣ Start the Containers**

```sh
docker-compose up -d
```

🚀 **qBittorrent fonctionne désormais en toute sécurité via ProtonVPN !**

---

## 📚 Accéder à l'interface web de qBittorrent

Une fois lancé, ouvrez :\
📌 [**http://localhost:8080**](http://localhost:8080)\
*(Nom d'utilisateur par défaut : admin, mot de passe : consultez la console pour le mot de passe temporaire)*

Veillez à changer votre mot de passe de l'interface web après la première connexion. Sinon, le mot de passe sera généré aléatoirement à chaque redémarrage du conteneur.

---

## 🛡️ Sécurité et bonnes pratiques

1. **Gardez le fichier **`.env`** privé**

   - Le fichier `.gitignore` **empêche déjà que le fichier **`.env`** soit envoyé sur GitHub.**

2. **Utilisez un mot de passe fort pour l'API Gluetun**

   - **Modifiez la variable **`GLUETUN_PASS`** dans le fichier **`.env` pour éviter un accès non autorisé à l'API.**

3. **Vérifiez la connectivité VPN avant de lancer des torrents**

   - Exécutez `curl ifconfig.me` à l'intérieur du conteneur :
     ```sh
     docker exec -it qbittorrent curl ifconfig.me
     ```
   - ✅ **Si l'IP correspond à ProtonVPN**, cela fonctionne.
   - ❌ **Si elle affiche votre IP réelle, quelque chose ne va pas.**

---

## 🛠️ Dépannage

### **Vérifiez si le VPN est en cours d'exécution**

```sh
docker ps
```

Si Gluetun ne fonctionne pas, redémarrez tout :

```sh
docker-compose down && docker-compose up -d
```

### **Vérifier que qBittorrent utilise le VPN**

```sh
docker exec -it qbittorrent curl ifconfig.me
```

🟢 Si l’IP correspond à ProtonVPN, cela fonctionne.\
🔴 Si elle affiche votre IP réelle, il y a un problème.

### **Vérifiez les journaux pour les erreurs**

```sh
docker logs -f gluetun
```

Cherchez **AUTH\_FAILED** ou des problèmes de connexion.

---

## 💎 Licence

Ce projet est sous licence **MIT License** – voir le fichier LICENSE pour plus de détails.

---

## 💪 Contribution

Les contributions sont les bienvenues ! Si vous avez des améliorations ou des retours, n’hésitez pas à soumettre une issue ou une pull request.

---

## 💬 Support & Retours

- Si vous avez trouvé cela utile, donnez-lui une étoile ⭐ sur GitHub !
- Les retours et suggestions sont toujours appréciés.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-10

---
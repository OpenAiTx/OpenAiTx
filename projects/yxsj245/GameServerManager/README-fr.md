# Présentation du projet
<div align="center">

# ![logo3](https://github.com/user-attachments/assets/8d1a37bd-5955-4dc2-b314-aecb04f985dc)

**Rendez le déploiement, la gestion et la maintenance des serveurs de jeux simples et efficaces**

[![GitHub Stars](https://badgen.net/github/stars/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/stargazers)
[![GitHub Release](https://badgen.net/github/release/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/releases)
[![Docker Pulls](https://badgen.net/docker/pulls/xiaozhu674/gameservermanager)](https://hub.docker.com/r/xiaozhu674/gameservermanager)
[![License](https://badgen.net/github/license/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/blob/main/LICENSE)

[📖 Documentation](http://blogpage.xiaozhuhouses.asia/html6/index.html#/) • [🌐 Site officiel](http://blogpage.xiaozhuhouses.asia/html5/index.html) • [💬 Groupe QQ](https://qm.qq.com/q/oNd4HvMj6M)

</div>

---

## 📋 Présentation du projet

GameServerManager (abrégé GSManager) est une plateforme moderne de gestion de serveurs de jeux basée sur la technologie **Docker**, spécialement conçue pour simplifier le déploiement, la gestion et la maintenance des serveurs de jeux.

### ✨ Caractéristiques principales

- 🐳 **Conteneurisation Docker** - Fonctionne entièrement sur Docker, isolation de l’environnement, excellente compatibilité
- 🎯 **Déploiement en un clic** - Prise en charge du déploiement rapide de nombreux jeux populaires
- 🌐 **Interface de gestion Web** - Frontend moderne basé sur React, intuitif et facile à utiliser
- 🔧 **Terminal en temps réel** - Terminal Web intégré, exécution de commandes en temps réel
- 📊 **Surveillance des ressources** - Surveillance en temps réel de l’utilisation des ressources serveur
- 🔐 **Gestion des droits** - Système complet d’authentification et de contrôle des accès utilisateurs
- 🎮 **Support multi-jeux** - Prise en charge de nombreux serveurs de jeux populaires de la plateforme Steam
- 💾 **Persistance des données** - Mappage externe des données de jeu et fichiers de configuration, sûr et fiable

![Panneau d’informations sur les conteneurs](http://images.server.xiaozhuhouses.asia:40061/i/2025/06/09/wbnc63.png)

---

## 🚀 Démarrage rapide

### Script d’installation en un clic

```bash
rm -f install.py && wget http://blogpage.xiaozhuhouses.asia/api/api1/install.py && python3 install.py
```
> Pour debian (installez docker manuellement) et centos, veuillez utiliser l’installation manuelle, voir la documentation

---

## 🎮 Jeux pris en charge

| Nom du jeu | Nom chinois | Steam ID | Téléchargement anonyme | Statut |
|------------|-------------|----------|-----------------------|--------|
| **Jeux populaires** | | | | |
| Palworld | 幻兽帕鲁 | 2394010 | ✅ | 🟢 Support complet |
| Rust | 腐蚀 | 258550 | ✅ | 🟢 Support complet |
| Satisfactory | 幸福工厂 | 1690800 | ✅ | 🟢 Support complet |
| Valheim | 英灵神殿 | 896660 | ✅ | 🟢 Support complet |
| 7 Days to Die | 七日杀 | 294420 | ✅ | 🟢 Support complet |
| Project Zomboid | 僵尸毁灭工程 | 380870 | ✅ | 🟢 Support complet |
| ARK: Survival Evolved | 方舟：生存进化 | 376030 | ✅ | 🟢 Support complet |
| **Jeux de tir** | | | | |
| Left 4 Dead 2 | 求生之路2 | 222860 | ❌ | 🟡 Licence requise |
| Team Fortress 2 | 军团要塞2 | 232250 | ✅ | 🟢 Support complet |
| Squad | 战术小队 | 403240 | ✅ | 🟢 Support complet |
| Insurgency: Sandstorm | 叛乱：沙漠风暴 | 581330 | ✅ | 🟢 Support complet |
| Killing Floor 2 | 杀戮空间2 | 232130 | ✅ | 🟢 Support complet |
| Insurgency (2014) | 叛乱2 | 237410 | ✅ | 🟢 Support complet |
| MORDHAU | 雷霆一击 | 629800 | ✅ | 🟢 Support complet |
| No More Room in Hell | 地狱已满 | 317670 | ✅ | 🟢 Support complet |
| Fistful of Frags | Fistful of Frags | 295230 | ✅ | 🟢 Support complet |
| Half-Life | 半条命 | 90 | ✅ | 🟢 Support complet |
| Half-Life 2: Deathmatch | 半条命2 | 232370 | ✅ | 🟢 Support complet |
| Operation: Harsh Doorstop | 行动代号：残酷之门 | 950900 | ✅ | 🟢 Support complet |
| Vox Machinae | Vox Machinae | 944490 | ✅ | 🟡 Configuration requise |
| **Jeux indépendants** | | | | |
| Unturned | 未转变者 | 1110390 | ✅ | 🟢 Support complet |
| Don't Starve Together | 饥荒联机版 | 343050 | ✅ | 🟡 Configuration requise |
| Last Oasis | 最后的绿洲 | 920720 | ✅ | 🟢 Support complet |
| Hurtworld | 伤害世界 | 405100 | ✅ | 🟢 Support complet |
| Soulmask | 灵魂面甲 | 3017300 | ✅ | 🟢 Support complet |
| **Jeux de simulation** | | | | |
| Euro Truck Simulator 2 | 欧洲卡车模拟2 | 1948160 | ✅ | 🟡 Configuration requise |
| American Truck Simulator | 美国卡车模拟 | 2239530 | ✅ | 🟡 Configuration requise |
| ECO | 生态生存 | 739590 | ✅ | 🟡 Configuration requise |

> Le support de nouveaux jeux est continuellement ajouté...

---

## 🏗️ Architecture technique

### Stack technique front-end
- **React 18** - Framework front-end moderne
- **Ant Design** - Bibliothèque de composants UI de niveau entreprise
- **Monaco Editor** - Éditeur de code
- **Xterm.js** - Émulateur de terminal Web
- **Vite** - Outil de build rapide

### Stack technique back-end
- **Python 3.13** - Langage principal de développement
- **Flask** - Framework Web
- **Gunicorn** - Serveur WSGI
- **Docker** - Technologie de conteneurisation
- **SteamCMD** - Outil en ligne de commande Steam
- **Aria2** - Téléchargeur multi-protocoles

---

## 📁 Structure du projet

```
GameServerManager/
├── app/                    # Application frontend
│   ├── src/               # Code source React
│   ├── public/            # Ressources statiques
│   └── package.json       # Dépendances frontend
├── server/                # Service backend
│   ├── api_server.py      # Serveur API principal
│   ├── game_installer.py  # Installateur de jeux
│   ├── pty_manager.py     # Gestionnaire de terminal
│   ├── auth_middleware.py # Middleware d'authentification
│   └── installgame.json   # Fichier de configuration des jeux
├── docker-compose.yml     # Fichier d’orchestration Docker
├── Dockerfile            # Fichier de construction d’image Docker
└── README.md             # Documentation du projet
```

---

## 🔧 Guide de configuration

### Configuration des ports
- **5000** - Interface de gestion Web
- **27015-27020** - Plage de ports du serveur de jeux Steam

### Mappage des volumes de données
- `./game_data` → `/home/steam/games` - Répertoire des données de jeux
- `./game_file` → `/home/steam/.config` - Répertoire de configuration des jeux
- `./game_file` → `/home/steam/.local` - Répertoire de sauvegarde des jeux

### Variables d’environnement
- `TZ=Asia/Shanghai` - Paramètre du fuseau horaire
- `USE_GUNICORN=true` - Activer Gunicorn
- `GUNICORN_TIMEOUT=120` - Délai d’expiration des requêtes
- `GUNICORN_PORT=5000` - Port du serveur

---

## 🤝 Guide de contribution

Toutes les formes de contribution sont les bienvenues !

1. **Fork** ce projet
2. Crée ta branche de fonctionnalité (`git checkout -b feature/AmazingFeature`)
3. Commit tes modifications (`git commit -m 'Add some AmazingFeature'`)
4. Pousse sur la branche (`git push origin feature/AmazingFeature`)
5. Ouvre une **Pull Request**

---

## 📞 Support et retours

- 🐛 **Signaler un problème** : [GitHub Issues](https://github.com/yxsj245/GameServerManager/issues)
- 💬 **Groupe QQ** : 1040201322
- 📖 **Documentation détaillée** : [Voir la documentation](http://blogpage.xiaozhuhouses.asia/html6/index.html#/)

---

## 📄 Licence Open Source

Ce projet est sous licence [AGPL-3.0 license](LICENSE).

---

## 👨‍💻 À propos de l’auteur

Ce projet est développé et maintenu indépendamment par **又菜又爱玩的小朱**.

Si ce projet t’a été utile, merci de laisser une ⭐ Star pour le soutenir !

---

## 📈 Statistiques du projet

![Star History](https://api.star-history.com/svg?repos=yxsj245/GameServerManager&type=Date)

---

<div align="center">

**🎮 Rendez la gestion des serveurs de jeux simple et amusante !**

</div>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---
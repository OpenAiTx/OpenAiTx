# Telegram Bot + Script de Surveillance des Données HAX

Ceci est un projet combiné pour la gestion de Telegram Bot et la surveillance du centre de données HAX.CO.ID, supportant les modes **déploiement Docker** et **exécution en arrière-plan sur serveur**.  
Le code original du projet a été fourni par un membre du groupe tg (nommé ez ez) (grand maître, si vous avez des questions, veuillez me contacter en privé, par respect pour la vie privée personnelle, je ne publie pas le compte tg du grand maître), l’exécution directe générait une erreur, j’ai utilisé chatgpt pour modifier et améliorer, il fonctionne actuellement normalement.

---

## 📦 Introduction aux fonctionnalités

- 🤖 `bot.py` : un Telegram Bot implémenté avec `python-telegram-bot`, supportant des fonctionnalités interactives (boutons, commandes, callbacks).  
- 📡 `hax.py` : récupère toutes les 60 secondes le statut du centre de données sur [https://hax.co.id/data-center/](https://hax.co.id/data-center/).  
- 🔁 Supporte l’exécution automatique en arrière-plan (adapté aux VPS Linux)  
- 🐳 Fournit un script de construction d’image Docker  
- 📜 Vérifie et installe automatiquement l’environnement Python3 (mode serveur)

---

## 📂 Structure du projet


```
project/                 # 自行创建一个文件夹存放项目文件，名称随意，英文命名
├── bot.py               # Telegram Bot 主程序
├── hax.py               # HAX 数据中心监控脚本
├── requirements.txt     # 所有依赖声明
├── Dockerfile           # Docker 镜像定义
├── run_docker.sh        # 一键 Docker 构建 + 启动脚本
├── run_server.sh        # 一键后台运行（非 Docker）
└── logs/                # 自动生成日志文件目录
```
## 🖥️ Mode d'exécution 1 : Exécution en arrière-plan sur un serveur ordinaire

### ✅ Prérequis

- Convient pour Ubuntu / Debian / CentOS et autres serveurs principaux
- Environnement Python 3 (peut être installé automatiquement)

### ▶️ Exécution en un clic



```bash
chmod +x run_server.sh
./run_server.sh
```

Lors de la première exécution :

- Vérifier si `python3` / `pip3` est installé sur le système
- Installer automatiquement les dépendances de `requirements.txt`
- Lancer le script choisi en arrière-plan (en utilisant `nohup`)
- Sortir les journaux dans le répertoire `logs/`

### 📄 Consulter les journaux

```bash
tail -f logs/bot.log     # 查看 Telegram Bot 日志
tail -f logs/hax.log     # 查看 HAX 监控日志
```

### ❌ Arrêter le processus

```bash
pkill -f bot.py
pkill -f hax.py
```

---

## 🐳 运行方式二：Docker 模式

### 🔧 构建镜像并运行

```bash
chmod +x run_docker.sh
./run_docker.sh
```

Vous pouvez choisir d'exécuter :

- `bot.py` (Bot Telegram)
- `hax.py` (Surveillance HAX)
- 'Démarrer simultanément les scripts bot.py et hax.py...'
- N'importe lequel peut fonctionner indépendamment dans le conteneur

---

---

## 📌 Bibliothèques dépendantes

- `requests`
- `beautifulsoup4`
- `lxml`
- `python-telegram-bot[job-queue]>=20.0`

Méthode d'installation :

```bash
pip install -r requirements.txt
```

---

## 📬 联系方式

欢迎 issue 或 PR，有建议请提！随缘回复


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-18

---
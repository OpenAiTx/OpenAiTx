<h1 align="center">Openlist-Ani</h1>

<p align="center">
  <b>🎬 Abonnement RSS → Téléchargement automatique → Renommage AI, gestion automatisée des séries animées en une seule étape</b>
</p>

<p align="center">
  Récupérez automatiquement les mises à jour des séries animées à partir des flux RSS associés, téléchargez-les hors ligne via Openlist vers le cloud correspondant,<br/>
  et utilisez un LLM pour analyser le nom des ressources, les renommant dans un format compatible avec Emby / Jellyfin.
</p>

---

## ✨ Caractéristiques

- 📡 **Suivi automatique des séries** — Récupération automatique des mises à jour RSS et téléchargement des séries
- 📦 **Support multi-cloud** — Basé sur OpenList, supporte les téléchargements hors ligne sur PikPak, 115, etc.
- 🤖 **Renommage AI** — Analyse AI du nom des ressources + recherche TMDB pour obtenir précisément le nom de la série, la saison, et l’épisode
- 💬 **Assistant intelligent** — Intégration avec Telegram Bot, permet à l’AI de rechercher et télécharger des ressources via langage naturel
- 🔔 **Notifications de mise à jour** — Envoi de notifications via PushPlus, Telegram, et autres canaux

## 📋 Préparatifs

1. Suivez la [documentation officielle d’Openlist](https://doc.oplist.org/guide) pour déployer Openlist et configurer le téléchargement hors ligne
2. Préparez un lien d’abonnement RSS (par exemple [Mikan Project](https://mikanani.me))
3. Préparez une clé API LLM

## 🚀 Démarrage rapide

<details open>
<summary><b>Méthode 1 : Installation via PIP (recommandée)</b></summary>

**1. Installation**

```bash
pip install openlist-ani
```

**2. Création du fichier de configuration**

Dans le répertoire d'exécution, créez un nouveau fichier `config.toml` et insérez le contenu suivant :

```toml
[rss]
urls = ["RSS订阅链接"]

[openlist]
url = "http://localhost:5244"       # Openlist 访问地址
token = ""                          # 令牌，见「设置 → 其他 → 令牌」
download_path = "/PikPak/Anime"     # 下载保存路径
offline_download_tool = "QBITTORRENT"  # 离线下载工具

[llm]
openai_api_key = ""                 # API Key
openai_base_url = "https://api.deepseek.com/v1"
openai_model = "deepseek-chat"
```

> 完整配置项请参考 [`config.toml.example`](https://raw.githubusercontent.com/TwooSix/Openlist-Ani/master/config.toml.example) 及 [配置说明](https://github.com/TwooSix/Openlist-Ani/wiki/配置说明)

**3. 启动**

```bash
openlist-ani
```

**4. (Optionnel) Démarrer l'assistant IA**

Après avoir ajouté la configuration de l'assistant dans le fichier de configuration, exécutez :

```toml
[assistant]
enabled = true

[assistant.telegram]
bot_token = ""        # 从 @BotFather 获取
allowed_users = []    # 允许的用户 ID 列表，留空则不限制
```

```bash
openlist-ani-assistant
```

</details>

<details>
<summary><b>Méthode 2 : Déploiement avec Docker</b></summary>

**1. Préparation des fichiers**

Dans le répertoire d'exécution, créer :
- `config.toml` — fichier de configuration (même contenu que ci-dessus)
- `data/` — répertoire de données

**2. Démarrage du conteneur**

```bash
docker run -d \
  --name openlist-ani \
  --network host \
  -e ENABLE_ASSISTANT=false \
  -v /path/to/config.toml:/config.toml \
  -v /path/to/data:/data \
  twosix26/openlist-ani:latest
```

> Remplacez `/path/to/` par votre chemin réel.  
> Pour activer l'assistant IA, après avoir rempli la configuration, définissez `ENABLE_ASSISTANT` sur `true`.  
> Pour plus de détails, voir le [Guide de déploiement Docker](https://github.com/TwooSix/Openlist-Ani/wiki/Docker部署指南).

</details>

<details>
<summary><b>Méthode 3 : Compiler à partir des sources</b></summary>

#### Prérequis : installer uv

<table><tr><td>

**Linux / macOS**
```bash
curl -LsSf https://astral.sh/uv/install.sh | sh
```

</td><td>

**Windows**
```powershell
powershell -ExecutionPolicy ByPass -c "irm https://astral.sh/uv/install.ps1 | iex"
```

</td></tr></table>

> 更多安装方式参考 [uv 官方文档](https://github.com/astral-sh/uv)

#### 步骤

```bash
# 1. 克隆仓库
git clone https://github.com/TwooSix/Openlist-Ani.git && cd Openlist-Ani

# 2. 切换到最新版本（master 为开发分支，不保证稳定）
git checkout v***    # 替换为最新版本号

# 3. 安装依赖
uv sync --no-dev --frozen

# 4. 创建 config.toml 并填写配置（内容同上）

# 5. 启动
uv run openlist-ani

# 6.（可选）启动 AI 助理
uv run openlist-ani-assistant
```

</details>

## 📖 Documentation

- [Démarrage rapide](https://github.com/TwooSix/Openlist-Ani/wiki/快速开始)
- [Guide d'installation PIP](https://github.com/TwooSix/Openlist-Ani/wiki/PIP安装指南)
- [Guide de déploiement Docker](https://github.com/TwooSix/Openlist-Ani/wiki/Docker部署指南)
- [Guide de compilation du code source](https://github.com/TwooSix/Openlist-Ani/wiki/源码编译指南)
- [Instructions de configuration](https://github.com/TwooSix/Openlist-Ani/wiki/配置说明)

## 🖼️ Démonstration des résultats

| Résultat du renommage | Assistant intelligent |
| :---: | :---: |
| <img src="https://github.com/TwooSix/Openlist-Ani/blob/master/imgs/show_pic1.png" width="400"/> | <img src="https://github.com/TwooSix/Openlist-Ani/blob/master/imgs/show_pic2.jpg" width="150"/> |


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-11

---
# GPT-Load

中文文档 | [English](https://raw.githubusercontent.com/tbphp/gpt-load/main/README_EN.md)

[![Release](https://img.shields.io/github/v/release/tbphp/gpt-load)](https://github.com/tbphp/gpt-load/releases)
![Go Version](https://img.shields.io/badge/Go-1.23+-blue.svg)
![License](https://img.shields.io/badge/license-MIT-green.svg)

Un service proxy transparent d’interface IA haute performance et de niveau entreprise, spécialement conçu pour les entreprises et développeurs nécessitant l’intégration de multiples services IA. Développé en Go, il dispose d’une gestion intelligente des clés, d’un équilibrage de charge et d’une surveillance complète, conçu pour des environnements de production à haute concurrence.

Pour plus de détails, veuillez consulter la [documentation officielle](https://www.gpt-load.com/docs)

<a href="https://hellogithub.com/repository/tbphp/gpt-load" target="_blank"><img src="https://api.hellogithub.com/v1/widgets/recommend.svg?rid=554dc4c46eb14092b9b0c56f1eb9021c&claim_uid=Qlh8vzrWJ0HCneG" alt="Featured｜HelloGitHub" style="width: 250px; height: 54px;" width="250" height="54" /></a>

## Fonctionnalités

- **Proxy transparent** : Conservation complète du format API natif, support des formats OpenAI, Google Gemini, Anthropic Claude, etc.
- **Gestion intelligente des clés** : Piscine de clés haute performance, gestion par groupes, rotation automatique et récupération en cas de panne
- **Équilibrage de charge** : Support de l’équilibrage de charge pondéré sur plusieurs points d’accès en amont, améliore la disponibilité du service
- **Gestion intelligente des pannes** : Gestion automatique de la liste noire des clés et mécanisme de récupération, assure la continuité du service
- **Configuration dynamique** : Paramètres système et configuration des groupes avec rechargement à chaud, sans redémarrage nécessaire
- **Architecture de niveau entreprise** : Déploiement maître-esclave distribué, support de l’extension horizontale et haute disponibilité
- **Gestion moderne** : Interface web de gestion basée sur Vue 3, intuitive et facile à utiliser
- **Surveillance complète** : Statistiques en temps réel, vérification de l’état, journaux détaillés des requêtes
- **Conception haute performance** : Transmission en flux sans copie, réutilisation du pool de connexions, opérations atomiques
- **Prêt pour la production** : Fermeture élégante, récupération d’erreurs, mécanismes de sécurité complets
- **Double système d’authentification** : Authentification séparée pour l’interface d’administration et le proxy, authentification proxy supportant des clés globales et par groupe

## Services IA supportés

GPT-Load, en tant que service proxy transparent, conserve intégralement le format API natif de chaque fournisseur de service IA :

- **Format OpenAI** : API officielle OpenAI, Azure OpenAI, ainsi que d’autres services compatibles OpenAI
- **Format Google Gemini** : API native des modèles Gemini Pro, Gemini Pro Vision, etc.
- **Format Anthropic Claude** : Modèles de la série Claude, supportant des dialogues et génération de texte de haute qualité

## Démarrage rapide

### Exigences environnementales

- Go 1.23+ (construction à partir du code source)  
- Docker (déploiement en conteneur)  
- MySQL, PostgreSQL, ou SQLite (stockage de base de données)  
- Redis (cache et coordination distribuée, optionnel)  

### Méthode 1 : Démarrage rapide avec Docker

```bash
docker run -d --name gpt-load \
    -p 3001:3001 \
    -e AUTH_KEY=sk-123456 \
    -v "$(pwd)/data":/app/data \
    ghcr.io/tbphp/gpt-load:latest
```

> Se connecter à l'interface de gestion avec `sk-123456` : <http://localhost:3001>

### Méthode 2 : Utiliser Docker Compose (recommandé)

**Commande d'installation :**

```bash
# 创建目录
mkdir -p gpt-load && cd gpt-load

# 下载配置文件
wget https://raw.githubusercontent.com/tbphp/gpt-load/refs/heads/main/docker-compose.yml
wget -O .env https://raw.githubusercontent.com/tbphp/gpt-load/refs/heads/main/.env.example

# 启动服务
docker compose up -d
```

La version SQLite est installée par défaut, adaptée aux applications légères sur une seule machine.

Pour installer MySQL, PostgreSQL et Redis, veuillez décommenter les services nécessaires dans le fichier `docker-compose.yml`, configurer les variables d'environnement correspondantes, puis redémarrer.

**Autres commandes :**

```bash
# 查看服务状态
docker compose ps

# 查看日志
docker compose logs -f

# 重启服务
docker compose down && docker compose up -d

# 更新到最新版本
docker compose pull && docker compose down && docker compose up -d
```

Après le déploiement :

- Accédez à l'interface de gestion Web : <http://localhost:3001>
- Adresse du proxy API : <http://localhost:3001/proxy>

> Connectez-vous à l'interface de gestion avec la clé d'authentification par défaut `sk-123456`. La clé d'authentification peut être modifiée dans le fichier .env via AUTH_KEY.

### Méthode 3 : Construction à partir du code source

La construction à partir du code source nécessite une base de données locale installée (SQLite, MySQL ou PostgreSQL) et Redis (optionnel).

```bash
# 克隆并构建
git clone https://github.com/tbphp/gpt-load.git
cd gpt-load
go mod tidy

# 创建配置
cp .env.example .env

# 修改 .env 中 DATABASE_DSN 和 REDIS_DSN 配置
# REDIS_DSN 为可选，如果不配置则启用内存存储

# 运行
make run
```

Après le déploiement :

- Accéder à l’interface de gestion Web : <http://localhost:3001>
- Adresse du proxy API : <http://localhost:3001/proxy>

> Utilisez la clé d’authentification par défaut `sk-123456` pour vous connecter à l’interface de gestion, la clé d’authentification peut être modifiée dans .env via AUTH_KEY.

### Méthode 4 : Déploiement en cluster

Le déploiement en cluster nécessite que tous les nœuds soient connectés au même MySQL (ou PostgreSQL) et Redis, Redis étant obligatoire. Il est conseillé d’utiliser un cluster MySQL et Redis distribués unifiés.

**Exigences de déploiement :**

- Tous les nœuds doivent configurer les mêmes `AUTH_KEY`, `DATABASE_DSN`, `REDIS_DSN`
- Architecture maître-esclave, les nœuds esclaves doivent configurer la variable d’environnement : `IS_SLAVE=true`

Pour plus de détails, veuillez consulter la [documentation de déploiement en cluster](https://www.gpt-load.com/docs/cluster)

## Configuration du système

### Aperçu de l’architecture de configuration

GPT-Load utilise une architecture de configuration à deux niveaux :

#### 1. Configuration statique (variables d’environnement)

- **Caractéristiques** : lue au démarrage de l’application, ne peut pas être modifiée en cours d’exécution, nécessite un redémarrage pour prendre effet
- **Usage** : configuration de l’infrastructure, comme la connexion à la base de données, le port du serveur, la clé d’authentification, etc.
- **Gestion** : via le fichier `.env` ou les variables d’environnement système

#### 2. Configuration dynamique (rechargement à chaud)

- **Paramètres système** : stockés dans la base de données, fournissent une base de comportement unifiée pour toute l’application
- **Configuration de groupe** : paramètres comportementaux personnalisés pour des groupes spécifiques, pouvant surcharger les paramètres système
- **Priorité de configuration** : configuration de groupe > paramètres système > configuration environnementale
- **Caractéristiques** : supporte le rechargement à chaud, les modifications prennent effet immédiatement sans redémarrage de l’application

<details>
<summary>Configuration statique (variables d’environnement)</summary>

**Configuration du serveur :**

| Élément de configuration | Variable d'environnement           | Valeur par défaut | Description                |
| ------------------------ | -------------------------------- | ---------------- | -------------------------- |
| Port du serveur          | `PORT`                           | 3001             | Port d'écoute du serveur HTTP |
| Adresse du serveur       | `HOST`                           | 0.0.0.0          | Adresse de liaison du serveur HTTP |
| Timeout lecture          | `SERVER_READ_TIMEOUT`            | 60               | Timeout de lecture du serveur HTTP (secondes) |
| Timeout écriture         | `SERVER_WRITE_TIMEOUT`           | 600              | Timeout d'écriture du serveur HTTP (secondes) |
| Timeout inactivité       | `SERVER_IDLE_TIMEOUT`            | 120              | Timeout d'inactivité de la connexion HTTP (secondes) |
| Timeout arrêt gracieux   | `SERVER_GRACEFUL_SHUTDOWN_TIMEOUT` | 10               | Durée d'attente pour arrêt gracieux du service (secondes) |
| Mode esclave             | `IS_SLAVE`                      | false            | Indicateur de nœud esclave en déploiement cluster |
| Fuseau horaire           | `TZ`                            | `Asia/Shanghai`  | Fuseau horaire spécifié     |

**Configuration d'authentification et base de données :**

| Élément de configuration | Variable d'environnement | Valeur par défaut    | Description                                 |
| ------------------------ | ------------------------ | ------------------- | ------------------------------------------- |
| Clé d'administration     | `AUTH_KEY`               | `sk-123456`         | Clé d'authentification pour l'**interface d'administration** |
| Connexion base de données | `DATABASE_DSN`           | ./data/gpt-load.db  | Chaîne de connexion (DSN) ou chemin du fichier base de données |
| Connexion Redis          | `REDIS_DSN`              | -                   | Chaîne de connexion Redis, utilisation mémoire si vide |

**Configuration performance et CORS :**

| Élément de configuration | Variable d'environnement    | Valeur par défaut               | Description                    |
| ------------------------ | --------------------------- | ------------------------------ | ----------------------------- |
| Requêtes concurrentes max | `MAX_CONCURRENT_REQUESTS`   | 100                            | Nombre maximal de requêtes concurrentes autorisées |
| Activation CORS          | `ENABLE_CORS`               | true                           | Activation du partage des ressources cross-origin |
| Origines autorisées      | `ALLOWED_ORIGINS`           | `*`                            | Origines autorisées, séparées par des virgules |
| Méthodes autorisées      | `ALLOWED_METHODS`           | `GET,POST,PUT,DELETE,OPTIONS`  | Méthodes HTTP autorisées      |
| En-têtes autorisés       | `ALLOWED_HEADERS`           | `*`                            | En-têtes autorisés, séparés par des virgules |
| Autoriser les identifiants | `ALLOW_CREDENTIALS`         | false                          | Autoriser l'envoi des identifiants |

**Configuration des logs :**

| Élément de configuration | Variable d'environnement | Valeur par défaut    | Description                              |
| ------------------------ | ------------------------ | ------------------- | --------------------------------------- |
| Niveau de log            | `LOG_LEVEL`              | `info`              | Niveau de log : debug, info, warn, error |
| Format de log            | `LOG_FORMAT`             | `text`              | Format de log : text, json              |
| Activation logs fichier  | `LOG_ENABLE_FILE`        | false               | Activation de la sortie des logs dans un fichier |
| Chemin du fichier journal | `LOG_FILE_PATH`   | `./data/logs/app.log` | Chemin de stockage du fichier journal             |

**Configuration du proxy :**

GPT-Load lit automatiquement les paramètres de proxy à partir des variables d'environnement, utilisés pour envoyer des requêtes aux fournisseurs de services IA en amont.

| Option         | Variable d'environnement | Valeur par défaut | Description                                |
| -------------- | ------------------------ | ----------------- | ------------------------------------------ |
| Proxy HTTP     | `HTTP_PROXY`             | -                 | Adresse du serveur proxy pour les requêtes HTTP  |
| Proxy HTTPS    | `HTTPS_PROXY`            | -                 | Adresse du serveur proxy pour les requêtes HTTPS |
| Pas de proxy   | `NO_PROXY`               | -                 | Hôtes ou domaines à exclure du proxy, séparés par des virgules |

Formats de protocole proxy supportés :

- **HTTP** : `http://user:pass@host:port`
- **HTTPS** : `https://user:pass@host:port`
- **SOCKS5** : `socks5://user:pass@host:port`
</details>

<details>
<summary>Configuration dynamique (rechargement à chaud)</summary>

**Paramètres de base :**

| Option                | Nom du champ                        | Valeur par défaut            | Remplacement par groupe | Description                             |
| --------------------- | --------------------------------- | --------------------------- | ---------------------- | ------------------------------------- |
| Adresse du projet     | `app_url`                         | `http://localhost:3001`     | ❌                     | URL de base du projet                  |
| Jours de rétention du journal | `request_log_retention_days`   | 7                           | ❌                     | Durée de conservation des journaux, 0 pour ne pas nettoyer |
| Intervalle d’écriture du journal (minutes) | `request_log_write_interval_minutes` | 1                           | ❌                     | Période d’écriture des logs en base (minutes) |
| Clés globales du proxy | `proxy_keys`                      | Valeur initiale : AUTH_KEY de l’environnement | ❌                     | Clés d’authentification proxy globales, séparées par des virgules |

**Paramètres de requête :**

| Option                 | Nom du champ                   | Valeur par défaut | Remplacement par groupe | Description                          |
| ---------------------- | ------------------------------| ----------------- | ---------------------- | ----------------------------------- |
| Timeout de la requête  | `request_timeout`              | 600               | ✅                     | Timeout complet du cycle de requête (secondes) |
| Timeout de connexion   | `connect_timeout`              | 15                | ✅                     | Timeout de connexion au service amont (secondes) |
| Timeout de connexion inactif | `idle_conn_timeout`        | 120               | ✅                     | Timeout de connexion inactive du client HTTP (secondes) |
| Timeout en-tête réponse | `response_header_timeout`      | 600               | ✅                     | Timeout d’attente de l’en-tête de réponse (secondes) |
| Nombre max de connexions inactives | `max_idle_conns`             | 100               | ✅                     | Nombre maximal de connexions inactives dans le pool |
| Nombre maximal de connexions inactives par hôte | `max_idle_conns_per_host` | 50     | ✅         | Nombre maximal de connexions inactives par hôte en amont |
| Adresse du serveur proxy                        | `proxy_url`               | -      | ✅         | Proxy HTTP/HTTPS utilisé pour la transmission des requêtes, vide pour utiliser la configuration d’environnement |

**Configuration des clés :**

| Option de configuration            | Nom du champ                         | Valeur par défaut | Remplaçable par groupe | Description                                         |
| --------------------------------- | ----------------------------------- | ----------------- | ---------------------- | ------------------------------------------------- |
| Nombre maximal de tentatives      | `max_retries`                       | 3                 | ✅                     | Nombre maximal de tentatives avec différentes clés pour une seule requête |
| Seuil de liste noire              | `blacklist_threshold`               | 3                 | ✅                     | Nombre d’échecs consécutifs avant qu’une clé soit mise en liste noire |
| Intervalle de validation des clés | `key_validation_interval_minutes`  | 60                | ✅                     | Période de validation planifiée des clés en arrière-plan (minutes) |
| Concurrence de validation des clés | `key_validation_concurrency`        | 10                | ✅                     | Nombre de validations simultanées lors de la vérification des clés invalides en arrière-plan |
| Timeout de validation des clés    | `key_validation_timeout_seconds`    | 20                | ✅                     | Délai d’attente des requêtes API pour la validation d’une clé unique (secondes) |

</details>

## Interface Web de gestion

Accéder à la console d’administration : <http://localhost:3001> (adresse par défaut)

### Affichage de l’interface

<img src="https://raw.githubusercontent.com/tbphp/gpt-load/main/screenshot/dashboard.png" alt="Tableau de bord" width="600" />

<br/>

<img src="https://raw.githubusercontent.com/tbphp/gpt-load/main/screenshot/keys.png" alt="Gestion des clés" width="600" />

<br/>

L’interface Web de gestion offre les fonctionnalités suivantes :

- **Tableau de bord** : Statistiques en temps réel et aperçu de l’état du système
- **Gestion des clés** : Création et configuration des groupes de fournisseurs d’IA, ajout, suppression et surveillance des clés API
- **Journal des requêtes** : Historique détaillé des requêtes et informations de débogage
- **Paramètres système** : Gestion de la configuration globale et rechargement à chaud

## Instructions d’utilisation de l’API

<details>
<summary>Méthode d’appel de l’interface proxy</summary>

GPT-Load route les requêtes vers différents services IA selon le nom du groupe. Utilisation comme suit :

#### 1. Format du point de terminaison proxy

```text
http://localhost:3001/proxy/{group_name}/{原始API路径}
```

- `{group_name}` : nom du groupe créé dans l'interface de gestion  
- `{原始API路径}` : chemin identique à celui du service AI original  

#### 2. Méthode d’authentification  

Configurez des **clés proxy** (`Proxy Keys`) dans l’interface de gestion Web, pour définir des clés proxy au niveau système et au niveau groupe.  

- **Méthode d’authentification** : identique à l’API native, mais la clé originale doit être remplacée par la clé proxy configurée.  
- **Portée des clés** : la **clé proxy globale** configurée dans les paramètres système est utilisable dans tous les groupes, la **clé proxy de groupe** configurée dans un groupe est valide uniquement pour ce groupe.  
- **Format** : plusieurs clés séparées par des virgules anglaises.  

#### 3. Exemple d’appel d’interface OpenAI  

Supposons qu’un groupe nommé `openai` ait été créé :  

**Mode d’appel original :**  

```bash
curl -X POST https://api.openai.com/v1/chat/completions \
  -H "Authorization: Bearer sk-your-openai-key" \
  -H "Content-Type: application/json" \
  -d '{"model": "gpt-4.1-mini", "messages": [{"role": "user", "content": "Hello"}]}'
```

**Mode d'appel proxy :**

```bash
curl -X POST http://localhost:3001/proxy/openai/v1/chat/completions \
  -H "Authorization: Bearer your-proxy-key" \
  -H "Content-Type: application/json" \
  -d '{"model": "gpt-4.1-mini", "messages": [{"role": "user", "content": "Hello"}]}'
```

**Notes de modification :**

- Remplacer `https://api.openai.com` par `http://localhost:3001/proxy/openai`
- Remplacer la clé API originale par la **clé de proxy**

#### 4. Exemple d’appel de l’interface Gemini

Supposons qu’un groupe nommé `gemini` ait été créé :

**Mode d’appel original :**

```bash
curl -X POST https://generativelanguage.googleapis.com/v1beta/models/gemini-2.5-pro:generateContent?key=your-gemini-key \
  -H "Content-Type: application/json" \
  -d '{"contents": [{"parts": [{"text": "Hello"}]}]}'
```

**Mode d'appel par proxy :**

```bash
curl -X POST http://localhost:3001/proxy/gemini/v1beta/models/gemini-2.5-pro:generateContent?key=your-proxy-key \
  -H "Content-Type: application/json" \
  -d '{"contents": [{"parts": [{"text": "Hello"}]}]}'
```

**Notes de modification :**

- Remplacer `https://generativelanguage.googleapis.com` par `http://localhost:3001/proxy/gemini`
- Remplacer `key=your-gemini-key` dans les paramètres URL par **la clé proxy**

#### 5. Exemple d'appel de l'interface Anthropic

Supposons qu'un groupe nommé `anthropic` ait été créé :

**Méthode d'appel originale :**

```bash
curl -X POST https://api.anthropic.com/v1/messages \
  -H "x-api-key: sk-ant-api03-your-anthropic-key" \
  -H "anthropic-version: 2023-06-01" \
  -H "Content-Type: application/json" \
  -d '{"model": "claude-sonnet-4-20250514", "messages": [{"role": "user", "content": "Hello"}]}'
```

**Méthode d'appel proxy :**

```bash
curl -X POST http://localhost:3001/proxy/anthropic/v1/messages \
  -H "x-api-key: your-proxy-key" \
  -H "anthropic-version: 2023-06-01" \
  -H "Content-Type: application/json" \
  -d '{"model": "claude-sonnet-4-20250514", "messages": [{"role": "user", "content": "Hello"}]}'
```

**Notes de modification :**

- Remplacer `https://api.anthropic.com` par `http://localhost:3001/proxy/anthropic`
- Remplacer la clé API originale dans l’en-tête `x-api-key` par la **clé proxy**

#### 6. Interfaces prises en charge

**Format OpenAI :**

- `/v1/chat/completions` - Dialogue de chat
- `/v1/completions` - Complétion de texte
- `/v1/embeddings` - Inclusions de texte
- `/v1/models` - Liste des modèles
- Et toutes les autres interfaces compatibles OpenAI

**Format Gemini :**

- `/v1beta/models/*/generateContent` - Génération de contenu
- `/v1beta/models` - Liste des modèles
- Et toutes les autres interfaces natives Gemini

**Format Anthropic :**

- `/v1/messages` - Dialogue de messages
- `/v1/models` - Liste des modèles (si disponible)
- Et toutes les autres interfaces natives Anthropic

#### 7. Configuration du SDK client

**SDK Python OpenAI :**

```python
from openai import OpenAI

client = OpenAI(
    api_key="your-proxy-key",  # 使用密钥
    base_url="http://localhost:3001/proxy/openai"  # 使用代理端点
)

response = client.chat.completions.create(
    model="gpt-4.1-mini",
    messages=[{"role": "user", "content": "Hello"}]
)
```

**Google Gemini SDK (Python)：**

```python
import google.generativeai as genai

# 配置 API 密钥和基础 URL
genai.configure(
    api_key="your-proxy-key",  # 使用代理密钥
    client_options={"api_endpoint": "http://localhost:3001/proxy/gemini"}
)

model = genai.GenerativeModel('gemini-2.5-pro')
response = model.generate_content("Hello")
```

**SDK Anthropic (Python)：**

```python
from anthropic import Anthropic

client = Anthropic(
    api_key="your-proxy-key",  # 使用代理密钥
    base_url="http://localhost:3001/proxy/anthropic"  # 使用代理端点
)

response = client.messages.create(
    model="claude-sonnet-4-20250514",
    messages=[{"role": "user", "content": "Hello"}]
)
```

> **Note importante** : En tant que service de proxy transparent, GPT-Load conserve entièrement le format natif de l'API et la méthode d'authentification de chaque service IA, il suffit de remplacer l'adresse du point de terminaison et d'utiliser la **clé proxy** configurée dans le panneau d'administration pour une migration transparente.

</details>

## Licence

Licence MIT - Pour plus de détails, veuillez consulter le fichier [LICENSE](LICENSE).

## Historique des étoiles

[![Stargazers over time](https://starchart.cc/tbphp/gpt-load.svg?variant=adaptive)](https://starchart.cc/tbphp/gpt-load)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-22

---
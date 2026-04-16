
## 📖 Présentation du projet

ASMRoner est un outil en ligne de commande en langage Go, utilisé pour rechercher, télécharger, synchroniser les œuvres audio d'asmr.one, et fournir une interface Web de lecture simple.

> 🌐 Œuvre dérivée : [asmr.furina.in](https://asmr.furina.in) — une page d'écoute ASMR en ligne simple et propre

## 🚀 Démarrage rapide

```bash
git clone https://github.com/fireinrain/asmroner.git && cd asmroner
go build -o asmroner
./asmroner config   # 交互式初始化配置
```
## 📋 Commandes courantes


```bash
# 搜索
./asmroner search "护士" -c 20
./asmroner search "护士,-中出@duration:1h" -c 50

# 下载
./asmroner download RJ01037721 -d ./downloads
./asmroner download RJ01037721,RJ02000001 -d ./downloads
./asmroner download hot100 -n 10 -d ./downloads

# 搜索 + 下载/导出
./asmroner search download "护士" -d ./downloads -s 20
./asmroner search export "护士" -n 100 -f data.json

# 同步元数据 & 批量下载
./asmroner sync
./asmroner sync download -d ./downloads
./asmroner sync retry -d ./downloads
./asmroner sync report

# Web 播放界面
./asmroner listen -p 8080 ./syncdata
```

## 📸 Captures d'écran

| Configuration | Recherche |
|:---:|:---:|
| ![配置](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/config.png) | ![搜索](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/search.png) |
| **Télécharger** | **Synchroniser** |
| ![下载](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/download.png) | ![同步](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync.png) |
| **Téléchargement synchronisé** | **Statistiques** |
| ![同步下载](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-down.png) | ![统计](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-report.png) |
| **Interface Web** | **Interface Web 2** |
| ![Web界面](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen.png) | ![Web界面2](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen2.png) |

<details>
<summary><b>✨ Fonctionnalités</b></summary>

- **Recherche** : RJID unique/en lot, syntaxe de recherche avancée, export des résultats en CSV/JSON  
- **Téléchargement** : téléchargement unique/en lot/populaire, limitation automatique, retry, backoff exponentiel  
- **Synchronisation** : synchronisation des métadonnées, contrôle du téléchargement en lot, suivi d’état, retry en cas d’échec  
- **Interface Web** : navigation visuelle, lecture dans le navigateur, design responsive  
- **Configuration** : initialisation interactive, support des proxys, limitation de débit, jitter et autres options avancées

</details>

<details>
<summary><b>⚙️ Description du fichier de configuration</b></summary>

Chemin du fichier de configuration : `~/.asmroner/config.toml` (format TOML)

```toml
[user]
account = "guest"
password = "guest"

[downloader]
api_url = ""                # 留空自动获取最快站点
proxy_url = ""              # 支持 http / socks5
max_workers = 5
max_retries = 3
sync_data_folder = "./syncdata"
sync_wanted_size = "200MB"  # 同步容量限制
prefer_media = "all"        # all | mp3>wav>flac

[limit]
sync_qps = 2
sync_jitter_min = 100       # ms
sync_jitter_max = 500
download_qps = 0.2
download_jitter_min = 2000
download_jitter_max = 5000
```

</details>

<details>
<summary><b>📋 Récapitulatif des options de commande</b></summary>

| Commande | Option | Description |
|------|------|------|
| `search` | `-c` | Nombre de résultats de recherche (par défaut 10) |
| `search download` | `-d`, `-s` | Répertoire de téléchargement, nombre de téléchargements |
| `search export` | `-f`, `-n` | Nom du fichier exporté (.csv/.json), nombre d’exportations |
| `download` | `-d`, `-n` | Répertoire de téléchargement, nombre hot100 |
| `sync download` | `-d` | Répertoire de téléchargement |
| `sync retry` | `-d` | Répertoire des fichiers échoués |
| `sync export` | `-s`, `-f` | Statut (failed/success), fichier d’exportation |
| `listen` | `-p` | Port (par défaut 9999) |

</details>

<details>
<summary><b>📁 Structure du projet</b></summary>

```
asmroner/
├── cmd/                # 命令行接口（config/download/search/sync/listen）
├── internal/
│   ├── engine/        # 核心下载引擎（限流、重试、并发控制）
│   ├── logger/        # 结构化日志系统
│   ├── model/         # 数据模型与查询参数解析
│   ├── database/      # SQLite 数据库
│   ├── consts/        # 常量定义
│   └── utils/         # 工具函数
├── webui/             # 内嵌 Web 界面（Tailwind + Plyr）
├── main.go
└── go.mod
```

</details>

<details>
<summary><b>🛠 Pile technologique</b></summary>

| Composant | Usage |
|------|------|
| Cobra + Viper | Framework CLI + gestion de configuration |
| GORM + SQLite | Persistance des données |
| Resty | Client HTTP (supporte proxy HTTP/SOCKS5) |
| Pond | Pool de travail concurrent |
| x/time/rate | Limitation par jetons (token bucket) |
| Gin | Service Web |
| Tailwind + Plyr | Interface frontend + lecture audio |

</details>

<details>
<summary><b>🔧 Questions fréquentes</b></summary>

**Fichier de configuration introuvable** → Exécutez `./asmroner config` pour initialiser

**Échec de téléchargement (erreur de flux)** → Le programme réessaiera automatiquement ; si échec persistant, utilisez `sync retry` ou consultez `.asmroner-data/download_errors.log`

**Interface Web inaccessible** → Vérifiez que le port n’est pas occupé, essayez `-p` pour spécifier un autre port

**Résultat de recherche vide** → Vérifiez la syntaxe de la requête, essayez de simplifier les critères

</details>

## 🤝 Contribution

Les Pull Requests sont les bienvenues ! Forkez → créez une branche → soumettez vos modifications → ouvrez une PR.

## 📄 Licence

Ce projet est sous licence MIT, voir le fichier [LICENSE](/LICENSE) pour plus de détails.

## 🙏 Remerciements

- Un grand merci à [go-asmr-spider](https://github.com/DiheChen/go-asmr-spider)
- Merci à tous les contributeurs et utilisateurs !

---

**ASMRoner** — Chaque soir, une sœur différente pour vous accompagner au sommeil :)

*Dernière mise à jour : février 2026*


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-16

---
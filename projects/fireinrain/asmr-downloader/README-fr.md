
<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=fireinrain&project=asmr-downloader&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>


## 📖 Présentation du projet

ASMRoner est un outil en ligne de commande écrit en Go, permettant de rechercher, télécharger, synchroniser des œuvres audio de asmr.one, et offre une interface Web de lecture simple.

> 🌐 Projet dérivé : [asmr.furina.in](https://asmr.furina.in) — Une page d’écoute ASMR en ligne simple et épurée

## 🚀 Démarrage rapide

```bash
https://github.com/MIKANOoOo/asmr-downloader.git && cd asmroner
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

  # 导出单个作品或指定数量热门榜链接 & 导出到指定目录
./asmroner export RJ01544940 -o ./downloads
./asmroner export hot100 -n 20 -o ./downloads
./asmroner export hot100 -n 10 -o ./downloads
更多内容参考常见问题中的guide

# Web 播放界面
./asmroner listen -p 8080 ./syncdata
```

## 📸 Captures d'écran

| Configuration | Recherche |
|:---:|:---:|
| ![Configuration](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/config.png) | ![Recherche](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/search.png) |
| **Téléchargement** | **Synchronisation** |
| ![Téléchargement](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/download.png) | ![Synchronisation](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync.png) |
| **Téléchargement synchronisé** | **Statistiques** |
| ![Téléchargement synchronisé](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-down.png) | ![Statistiques](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-report.png) |
| **Interface Web** | **Interface Web 2** |
| ![Interface Web](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen.png) | ![Interface Web 2](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen2.png) |
| **interface d'exportation** | **interface d'exportation 2** |
| ![interface d'exportation](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/export1.png) | ![interface d'exportation 2](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/export2.png) |

<details>
<summary><b>✨ Fonctionnalités</b></summary>

- **Recherche** : Recherche RJID unique/lot, syntaxe avancée, exportation des résultats CSV/JSON
- **Téléchargement** : Téléchargement unique/lot/populaire, limitation automatique, reprise, backoff exponentiel
- **Synchronisation** : Synchronisation des métadonnées, gestion du téléchargement en lot, suivi d’état, reprise en cas d’échec
- **Interface Web** : Navigation visuelle, lecture dans le navigateur, design réactif
- **Configuration** : Initialisation interactive, support du proxy, limitation, jitter et autres réglages avancés

</details>

<details>
<summary><b>⚙️ Explications du fichier de configuration</b></summary>

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
|----------|--------|-------------|
| `search` | `-c` | Nombre de résultats de recherche (par défaut 10) |
| `search download` | `-d`, `-s` | Répertoire de téléchargement, nombre de téléchargements |
| `search export` | `-f`, `-n` | Nom du fichier exporté (.csv/.json), nombre d'exports |
| `download` | `-d`, `-n` | Répertoire de téléchargement, nombre hot100 |
| `sync download` | `-d` | Répertoire de téléchargement |
| `sync retry` | `-d` | Répertoire des fichiers échoués |
| `sync export` | `-s`, `-f` | Statut (failed/success), fichier exporté |
| `listen` | `-p` | Port (par défaut 9999) |
| `export` | `-o`, `-n` | Répertoire d'export, nombre hot100 |

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
<summary><b>🛠 Stack technique</b></summary>

| Composant | Usage |
|------|------|
| Cobra + Viper | Framework CLI + gestion de la configuration |
| GORM + SQLite | Persistance des données |
| Resty | Client HTTP (prise en charge des proxies HTTP/SOCKS5) |
| Pond | Pool de travail concurrent |
| x/time/rate | Limitation de débit par le système de jeton |
| Gin | Service web |
| Tailwind + Plyr | Interface frontend + lecture audio |

</details>

<details>
<summary><b>🔧 Questions fréquentes</b></summary>

**Fichier de configuration introuvable** → Exécutez `./asmroner config` pour l'initialisation

**Échec du téléchargement (erreur de flux)** → Le programme réessaie automatiquement ; si l'échec persiste, utilisez `sync retry` pour réessayer ou consultez `.asmroner-data/download_errors.log`

**Interface web inaccessible** → Vérifiez que le port n’est pas utilisé, essayez de spécifier un autre port avec `-p`

**Résultat de recherche vide** → Vérifiez la syntaxe de la requête, essayez de simplifier les conditions

**Méthode de téléchargement pour la commande export** → Voir [guide](/dist/guide.pdf)

</details>

## 🤝 Contribution

Les Pull Requests sont les bienvenus ! Fork → Créez une branche → Soumettez vos modifications → Ouvrez une PR.

## 📄 Licence

Ce projet utilise la licence MIT, veuillez consulter le fichier [LICENSE](/LICENSE) pour plus de détails.


## 🙏 致谢

- 特别感谢 [go-asmr-spider](https://github.com/DiheChen/go-asmr-spider)
- 感谢所有贡献者和用户！

---

**ASMRoner** — 每天晚上都有不同的妹妹陪你入睡 :)

*最后更新：2026 年 2 月*


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-05

---
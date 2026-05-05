
<div align="right">
  <details>
    <summary >🌐 言語</summary>
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


## 📖 プロジェクト概要

ASMRoner は Go 言語で作られたコマンドラインツールで、asmr.one の音声作品の検索、ダウンロード、同期を行い、シンプルな Web 再生画面も提供します。

> 🌐 派生作品：[asmr.furina.in](https://asmr.furina.in) — シンプルでクリーンなオンライン ASMR 視聴ページ

## 🚀 クイックスタート

```bash
https://github.com/MIKANOoOo/asmr-downloader.git && cd asmroner
go build -o asmroner
./asmroner config   # 交互式初始化配置
```

## 📋 Common Commands

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

## 📸 スクリーンショット

| 設定 | 検索 |
|:---:|:---:|
| ![設定](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/config.png) | ![検索](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/search.png) |
| **ダウンロード** | **同期** |
| ![ダウンロード](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/download.png) | ![同期](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync.png) |
| **同期ダウンロード** | **統計** |
| ![同期ダウンロード](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-down.png) | ![統計](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-report.png) |
| **Web インターフェース** | **Web インターフェース 2** |
| ![Webインターフェース](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen.png) | ![Webインターフェース2](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen2.png) |
| **export インターフェース** | **export インターフェース 2** |
| ![exportインターフェース](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/export1.png) | ![exportインターフェース2](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/export2.png) |

<details>
<summary><b>✨ 機能特性</b></summary>

- **検索**：単体/バッチ RJID、高度な検索構文、結果をCSV/JSONでエクスポート
- **ダウンロード**：単体/バッチ/人気作品ダウンロード、自動帯域制限、リトライ、指数バックオフ
- **同期**：メタデータ同期、バッチダウンロード管理、状態追跡、失敗時リトライ
- **Web インターフェース**：ビジュアルブラウズ、ブラウザ内再生、レスポンシブデザイン
- **設定**：対話型初期化、プロキシ・帯域制限・ジッター等の高度な設定対応

</details>

<details>
<summary><b>⚙️ 設定ファイル説明</b></summary>

設定ファイルのパス：`~/.asmroner/config.toml`（TOML形式）

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
<summary><b>📋 コマンドオプション早見表</b></summary>

| コマンド | オプション | 説明 |
|------|------|------|
| `search` | `-c` | 検索結果数（デフォルト 10） |
| `search download` | `-d`, `-s` | ダウンロードディレクトリ、ダウンロード数 |
| `search export` | `-f`, `-n` | エクスポートファイル名（.csv/.json）、エクスポート数 |
| `download` | `-d`, `-n` | ダウンロードディレクトリ、hot100 数 |
| `sync download` | `-d` | ダウンロードディレクトリ |
| `sync retry` | `-d` | 失敗ファイルのディレクトリ |
| `sync export` | `-s`, `-f` | 状態（failed/success）、エクスポートファイル |
| `listen` | `-p` | ポート（デフォルト 9999） |
| `export` | `-o`, `-n` | エクスポートディレクトリ、hot100数 |

</details>

<details>
<summary><b>📁 プロジェクト構成</b></summary>


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
<summary><b>🛠 技術スタック</b></summary>

| コンポーネント | 用途 |
|------|------|
| Cobra + Viper | CLIフレームワーク + 設定管理 |
| GORM + SQLite | データ永続化 |
| Resty | HTTPクライアント（HTTP/SOCKS5プロキシ対応） |
| Pond | 並列ワークプール |
| x/time/rate | トークンバケットによるレート制限 |
| Gin | Webサービス |
| Tailwind + Plyr | フロントエンドUI + オーディオ再生 |

</details>

<details>
<summary><b>🔧 よくある質問</b></summary>

**設定ファイルが見つかりません** → `./asmroner config` を実行して初期化

**ダウンロード失敗（stream error）** → 自動で再試行します；失敗する場合は `sync retry` で再試行、または `.asmroner-data/download_errors.log` を確認

**Web画面がアクセスできません** → ポートが占有されていないか確認し、`-p` で別のポートを指定してみてください

**検索結果が空です** → クエリ構文を確認し、条件を簡素化して試してください

**exportコマンドに対応したダウンロード方法** → [guide](/dist/guide.pdf) を参照してください

</details>

## 🤝 貢献

Pull Requestの提出を歓迎します！Fork → 新しいブランチ作成 → 変更をコミット → PRを開始。

## 📄 ライセンス

本プロジェクトはMITライセンスを採用しています。詳細は [LICENSE](/LICENSE) ファイルをご覧ください。


## 🙏 致谢

- 特别感谢 [go-asmr-spider](https://github.com/DiheChen/go-asmr-spider)
- 感谢所有贡献者和用户！

---

**ASMRoner** — 每天晚上都有不同的妹妹陪你入睡 :)

*最后更新：2026 年 2 月*


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-05

---
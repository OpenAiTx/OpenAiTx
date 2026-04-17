
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
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


## 📖 Introdução ao Projeto

ASMRoner é uma ferramenta de linha de comando em Go para pesquisar, baixar, sincronizar obras de áudio do asmr.one e oferece uma interface web simples para reprodução.

> 🌐 Projeto derivado: [asmr.furina.in](https://asmr.furina.in) — Uma página online simples e limpa para ouvir ASMR

## 🚀 Início Rápido

```bash
git clone https://github.com/fireinrain/asmroner.git && cd asmroner
go build -o asmroner
./asmroner config   # 交互式初始化配置
```

## 📋 Comandos Comuns

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

## 📸 Capturas de Tela

| Configuração | Pesquisa |
|:---:|:---:|
| ![Configuração](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/config.png) | ![Pesquisa](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/search.png) |
| **Download** | **Sincronizar** |
| ![Download](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/download.png) | ![Sincronizar](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync.png) |
| **Sincronizar Download** | **Estatísticas** |
| ![Sincronizar Download](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-down.png) | ![Estatísticas](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-report.png) |
| **Interface Web** | **Interface Web 2** |
| ![Interface Web](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen.png) | ![Interface Web 2](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen2.png) |

<details>
<summary><b>✨ Funcionalidades</b></summary>

- **Pesquisa**: Pesquisa única/em lote por RJID, sintaxe avançada, exportação de resultados CSV/JSON
- **Download**: Download único/em lote/de obras populares, limitação automática, retentativas, backoff exponencial
- **Sincronizar**: Sincronização de metadados, controle de download em lote, rastreamento de status, retentativa de falhas
- **Interface Web**: Navegação visual, reprodução no navegador, design responsivo
- **Configuração**: Inicialização interativa, suporte a proxy, limitação de taxa, jitter e configurações avançadas

</details>

<details>
<summary><b>⚙️ Explicação do Arquivo de Configuração</b></summary>

Caminho do arquivo de configuração: `~/.asmroner/config.toml` (formato TOML)

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
<summary><b>📋 Referência Rápida de Opções de Comando</b></summary>

| Comando | Opção | Descrição |
|---------|-------|-----------|
| `search` | `-c` | Quantidade de resultados da busca (padrão 10) |
| `search download` | `-d`, `-s` | Diretório de download, quantidade de downloads |
| `search export` | `-f`, `-n` | Nome do arquivo exportado (.csv/.json), quantidade de exportação |
| `download` | `-d`, `-n` | Diretório de download, quantidade hot100 |
| `sync download` | `-d` | Diretório de download |
| `sync retry` | `-d` | Diretório dos arquivos com falha |
| `sync export` | `-s`, `-f` | Status (failed/success), arquivo de exportação |
| `listen` | `-p` | Porta (padrão 9999) |

</details>

<details>
<summary><b>📁 Estrutura do Projeto</b></summary>


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
<summary><b>🛠 Stack Tecnológico</b></summary>

| Componente | Finalidade |
|------|------|
| Cobra + Viper | Framework CLI + Gerenciamento de Configuração |
| GORM + SQLite | Persistência de dados |
| Resty | Cliente HTTP (suporta proxy HTTP/SOCKS5) |
| Pond | Pool de trabalho concorrente |
| x/time/rate | Limite de taxa com token bucket |
| Gin | Serviço Web |
| Tailwind + Plyr | Interface frontend + Reprodução de áudio |

</details>

<details>
<summary><b>🔧 Perguntas Frequentes</b></summary>

**Arquivo de configuração não encontrado** → Execute `./asmroner config` para inicializar

**Falha ao baixar (stream error)** → O programa irá tentar novamente automaticamente; se ainda falhar, use `sync retry` para tentar novamente, ou verifique `.asmroner-data/download_errors.log`

**Interface Web inacessível** → Verifique se a porta está livre, tente especificar outra porta com `-p`

**Resultados de busca vazios** → Verifique a sintaxe da consulta, tente simplificar as condições

</details>

## 🤝 Contribuição

Pull Requests são bem-vindos! Fork → Nova branch → Submeter alterações → Abrir PR.

## 📄 Licença

Este projeto utiliza a licença MIT. Para mais detalhes, consulte o arquivo [LICENSE](/LICENSE).

## 🙏 Agradecimentos


- Agradecimentos especiais ao [go-asmr-spider](https://github.com/DiheChen/go-asmr-spider)
- Obrigado a todos os colaboradores e usuários!

---

**ASMRoner** — Toda noite uma irmã diferente para te acompanhar até o sono :)

*Última atualização: fevereiro de 2026*


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-17

---
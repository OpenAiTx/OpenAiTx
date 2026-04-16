
## 📖 Introducción al proyecto

ASMRoner es una herramienta de línea de comandos en Go para buscar, descargar y sincronizar obras de audio de asmr.one, y proporciona una interfaz web sencilla para reproducir.

> 🌐 Proyecto derivado: [asmr.furina.in](https://asmr.furina.in) — una página en línea limpia y sencilla para escuchar ASMR

## 🚀 Comienzo rápido

```bash
git clone https://github.com/fireinrain/asmroner.git && cd asmroner
go build -o asmroner
./asmroner config   # 交互式初始化配置
```

## 📋 Comandos comunes

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

## 📸 Capturas de pantalla

| Configuración | Búsqueda |
|:---:|:---:|
| ![Configuración](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/config.png) | ![Búsqueda](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/search.png) |
| **Descarga** | **Sincronización** |
| ![Descarga](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/download.png) | ![Sincronización](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync.png) |
| **Descarga sincronizada** | **Estadísticas** |
| ![Descarga sincronizada](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-down.png) | ![Estadísticas](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-report.png) |
| **Interfaz Web** | **Interfaz Web 2** |
| ![Interfaz Web](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen.png) | ![Interfaz Web 2](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen2.png) |

<details>
<summary><b>✨ Características</b></summary>

- **Búsqueda**: RJID individual/lote, sintaxis avanzada de búsqueda, exportación de resultados a CSV/JSON  
- **Descarga**: descarga individual/lote/popular, limitación automática, reintentos, retroceso exponencial  
- **Sincronización**: sincronización de metadatos, control de descargas en lote, seguimiento de estado, reintentos en fallos  
- **Interfaz Web**: navegación visual, reproducción en navegador, diseño responsivo  
- **Configuración**: inicialización interactiva, soporte para proxy, limitación, jitter y otras configuraciones avanzadas  

</details>

<details>
<summary><b>⚙️ Explicación del archivo de configuración</b></summary>

Ruta del archivo de configuración: `~/.asmroner/config.toml` (formato TOML)

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
<summary><b>📋 Opciones de comandos rápidas</b></summary>

| Comando | Opción | Descripción |
|------|------|------|
| `search` | `-c` | Número de resultados de búsqueda (por defecto 10) |
| `search download` | `-d`, `-s` | Directorio de descarga, cantidad de descargas |
| `search export` | `-f`, `-n` | Nombre del archivo exportado (.csv/.json), cantidad exportada |
| `download` | `-d`, `-n` | Directorio de descarga, cantidad hot100 |
| `sync download` | `-d` | Directorio de descarga |
| `sync retry` | `-d` | Directorio donde se encuentran archivos fallidos |
| `sync export` | `-s`, `-f` | Estado (failed/success), archivo exportado |
| `listen` | `-p` | Puerto (por defecto 9999) |

</details>

<details>
<summary><b>📁 Estructura del proyecto</b></summary>

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
<summary><b>🛠 Tecnologías</b></summary>

| Componente | Uso |
|------|------|
| Cobra + Viper | Marco CLI + Gestión de configuración |
| GORM + SQLite | Persistencia de datos |
| Resty | Cliente HTTP (soporta proxy HTTP/SOCKS5) |
| Pond | Pool de trabajo concurrente |
| x/time/rate | Limitación de tasa con token bucket |
| Gin | Servicio web |
| Tailwind + Plyr | Interfaz frontend + Reproducción de audio |

</details>

<details>
<summary><b>🔧 Preguntas frecuentes</b></summary>

**Archivo de configuración no encontrado** → Ejecutar `./asmroner config` para inicializar

**Descarga fallida (stream error)** → El programa reintentará automáticamente; si sigue fallando, usar `sync retry` para reintentar, o revisar `.asmroner-data/download_errors.log`

**Interfaz web inaccesible** → Confirmar que el puerto no esté ocupado, intentar con `-p` para especificar otro puerto

**Resultados de búsqueda vacíos** → Verificar sintaxis de consulta, intentar simplificar condiciones

</details>

## 🤝 Contribuciones

¡Bienvenido a enviar Pull Request! Fork → Crear rama → Enviar cambios → Abrir PR.

## 📄 Licencia

Este proyecto utiliza la licencia MIT, para más detalles consulte el archivo [LICENSE](/LICENSE).

## 🙏 Agradecimientos
- Agradecimientos especiales a [go-asmr-spider](https://github.com/DiheChen/go-asmr-spider)
- ¡Gracias a todos los colaboradores y usuarios!

---

**ASMRoner** — Cada noche una hermanita diferente te acompaña a dormir :)

*Última actualización: febrero de 2026*



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-16

---
<h1 align="center">Openlist-Ani</h1>

<p align="center">
  <b>🎬 Suscripción RSS → Descarga automática → Renombrado AI, gestión automatizada de series animadas todo en uno</b>
</p>

<p align="center">
  Obtén automáticamente actualizaciones de series animadas desde fuentes RSS relacionadas, descarga offline con Openlist a la nube correspondiente, <br/>
  y usa LLM para analizar el nombre del recurso y renombrarlo en un formato compatible con Emby / Jellyfin.
</p>

---

## ✨ Características

- 📡 **Seguimiento automático** — Obtiene y descarga automáticamente las actualizaciones de series RSS
- 📦 **Soporte multi nube** — Basado en OpenList, soporta descargas offline en PikPak, 115 y más
- 🤖 **Renombrado AI** — Análisis AI del nombre + búsqueda en TMDB para obtener nombre, temporada y episodio exactos
- 💬 **Asistente inteligente** — Integrado con Telegram Bot, usa lenguaje natural para que AI busque y descargue recursos
- 🔔 **Notificaciones de actualización** — Envía actualizaciones vía PushPlus, Telegram y otros canales

## 📋 Preparativos

1. Despliega Openlist según la [documentación oficial de Openlist](https://doc.oplist.org/guide) y configura la descarga offline
2. Ten listo el enlace RSS (por ejemplo, [Mikan Project](https://mikanani.me))
3. Prepara la clave API de LLM

## 🚀 Inicio rápido

<details open>
<summary><b>Método 1: Instalación PIP (recomendado)</b></summary>

**1. Instalación**

```bash
pip install openlist-ani
```

**2. Crear archivo de configuración**

En el directorio de ejecución, cree un nuevo archivo `config.toml` y rellene con el siguiente contenido:

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

**4. (Opcional) Iniciar el asistente de IA**

Ejecute después de completar la configuración del asistente en el archivo de configuración:

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
<summary><b>Método 2: Despliegue con Docker</b></summary>

**1. Preparar archivos**

Crear en el directorio de ejecución:
- `config.toml` — Archivo de configuración (contenido igual que arriba)
- `data/` — Directorio de datos

**2. Iniciar el contenedor**

```bash
docker run -d \
  --name openlist-ani \
  --network host \
  -e ENABLE_ASSISTANT=false \
  -v /path/to/config.toml:/config.toml \
  -v /path/to/data:/data \
  twosix26/openlist-ani:latest
```

> Reemplaza `/path/to/` con tu ruta real.  
> Para habilitar el asistente de IA, después de completar la configuración, establece `ENABLE_ASSISTANT` en `true`.  
> Para más detalles, consulta la [Guía de despliegue con Docker](https://github.com/TwooSix/Openlist-Ani/wiki/Docker部署指南).

</details>

<details>
<summary><b>Método 3: Compilar desde el código fuente</b></summary>

#### Pre-requisito: Instalar uv

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

## 📖 Documentación

- [Inicio Rápido](https://github.com/TwooSix/Openlist-Ani/wiki/快速开始)
- [Guía de Instalación PIP](https://github.com/TwooSix/Openlist-Ani/wiki/PIP安装指南)
- [Guía de Despliegue Docker](https://github.com/TwooSix/Openlist-Ani/wiki/Docker部署指南)
- [Guía de Compilación del Código Fuente](https://github.com/TwooSix/Openlist-Ani/wiki/源码编译指南)
- [Descripción de Configuración](https://github.com/TwooSix/Openlist-Ani/wiki/配置说明)

## 🖼️ Muestra de Resultados

| Resultado de Renombrado | Asistente Inteligente |
| :---: | :---: |
| <img src="https://github.com/TwooSix/Openlist-Ani/blob/master/imgs/show_pic1.png" width="400"/> | <img src="https://github.com/TwooSix/Openlist-Ani/blob/master/imgs/show_pic2.jpg" width="150"/> |


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-11

---
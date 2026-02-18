# Telegram Bot + HAX Script de Monitoreo de Datos

Este es un proyecto combinado para la gestión del Telegram Bot y la supervisión del centro de datos HAX.CO.ID, que soporta dos modos: **despliegue con Docker** y **ejecución en segundo plano en servidor**.  
El código original del proyecto fue proporcionado por un miembro del grupo de Telegram (nombre ez ez) (gran persona, si hay algún problema por favor contáctenme en privado, por privacidad no se publica su cuenta de Telegram), al ejecutar directamente daba errores, usé chatgpt para modificar y mejorar, ahora funciona correctamente.

---

## 📦 Resumen de Funciones

- 🤖 `bot.py`: Un Telegram Bot implementado con `python-telegram-bot`, soporta funcionalidades interactivas (como botones, comandos, callbacks).  
- 📡 `hax.py`: Captura cada 60 segundos el estado del centro de datos en [https://hax.co.id/data-center/](https://hax.co.id/data-center/).  
- 🔁 Soporta ejecución automática en segundo plano (compatible con VPS Linux)  
- 🐳 Proporciona script para construir imagen Docker  
- 📜 Verifica e instala automáticamente entorno Python3 (modo servidor)

---

## 📂 Estructura del Proyecto


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


## 🖥️ Modo de ejecución 1: Ejecución en segundo plano en servidor normal

### ✅ Requisitos previos

- Adecuado para servidores principales como Ubuntu / Debian / CentOS
- Entorno Python 3 (se puede instalar automáticamente)

### ▶️ Ejecución con un solo clic

```bash
chmod +x run_server.sh
./run_server.sh
```

La primera ejecución realizará:

- Verificará si el sistema tiene instalado `python3` / `pip3`
- Instalará automáticamente las dependencias de `requirements.txt`
- Iniciará el script que elijas en segundo plano (usando `nohup`)
- Guardará los registros en el directorio `logs/`

### 📄 Ver registros

```bash
tail -f logs/bot.log     # 查看 Telegram Bot 日志
tail -f logs/hax.log     # 查看 HAX 监控日志
```

### ❌ Detener proceso

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

Puedes elegir ejecutar:

- `bot.py` (Bot de Telegram)
- `hax.py` (Monitoreo HAX)
- 'Iniciar simultáneamente los scripts bot.py y hax.py...'
- Cualquiera de los dos puede ejecutarse de forma independiente en el contenedor

---

---

## 📌 Bibliotecas dependientes

- `requests`
- `beautifulsoup4`
- `lxml`
- `python-telegram-bot[job-queue]>=20.0`

Forma de instalación:

```bash
pip install -r requirements.txt
```

---

## 📬 联系方式

欢迎 issue 或 PR，有建议请提！随缘回复


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-18

---
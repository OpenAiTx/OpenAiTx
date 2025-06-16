# AgenticSeek: Alternativa privada y local a Manus

<p align="center">
<img align="center" src="https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/agentic_seek_logo.png" width="300" height="300" alt="Agentic Seek Logo">
<p>

  English | [中文](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_CHS.md) | [繁體中文](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_CHT.md) | [Français](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_FR.md) | [日本語](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_JP.md) | [Português (Brasil)](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_PTBR.md) | [Español](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_ES.md)

*Una **alternativa 100% local a Manus AI**, este asistente de IA habilitado por voz navega autónomamente por la web, escribe código y planifica tareas, manteniendo todos los datos en tu dispositivo. Adaptado para modelos de razonamiento locales, se ejecuta completamente en tu hardware, garantizando total privacidad y cero dependencia de la nube.*

[![Visita AgenticSeek](https://img.shields.io/static/v1?label=Website&message=AgenticSeek&color=blue&style=flat-square)](https://fosowl.github.io/agenticSeek.html) ![Licencia](https://img.shields.io/badge/license-GPL--3.0-green) [![Discord](https://img.shields.io/badge/Discord-Join%20Us-7289DA?logo=discord&logoColor=white)](https://discord.gg/8hGDaME3TC) [![Twitter](https://img.shields.io/twitter/url/https/twitter.com/fosowl.svg?style=social&label=Update%20%40Fosowl)](https://x.com/Martin993886460) [![GitHub stars](https://img.shields.io/github/stars/Fosowl/agenticSeek?style=social)](https://github.com/Fosowl/agenticSeek/stargazers)

### ¿Por qué AgenticSeek?

* 🔒 Totalmente local y privado - Todo funciona en tu máquina — sin nube, sin compartir datos. Tus archivos, conversaciones y búsquedas permanecen privadas.

* 🌐 Navegación web inteligente - AgenticSeek puede navegar por Internet de forma autónoma — buscar, leer, extraer información, rellenar formularios web — todo manos libres.

* 💻 Asistente de codificación autónomo - ¿Necesitas código? Puede escribir, depurar y ejecutar programas en Python, C, Go, Java y más — todo sin supervisión.

* 🧠 Selección inteligente de agentes - Tú preguntas, él determina automáticamente el mejor agente para el trabajo. Como tener un equipo de expertos listo para ayudar.

* 📋 Planifica y ejecuta tareas complejas - Desde planificar viajes hasta proyectos complejos — puede dividir grandes tareas en pasos y realizarlas usando múltiples agentes de IA.

* 🎙️ Habilitado por voz - Voz limpia, rápida y futurista, y conversión de voz a texto que te permite hablarle como si fuera tu IA personal de una película de ciencia ficción. (En progreso)

### **Demostración**

> *¿Puedes buscar el proyecto agenticSeek, aprender qué habilidades se requieren, luego abrir el archivo CV_candidates.zip y decirme cuáles coinciden mejor con el proyecto?*

https://github.com/user-attachments/assets/b8ca60e9-7b3b-4533-840e-08f9ac426316

Aviso: Esta demostración, incluidos todos los archivos que aparecen (por ejemplo: CV_candidates.zip), es completamente ficticia. No somos una corporación, buscamos colaboradores de código abierto, no candidatos.

> 🛠⚠️️ **Trabajo activo en progreso**

> 🙏 Este proyecto comenzó como un proyecto paralelo y no tiene hoja de ruta ni financiación. Ha crecido mucho más de lo que esperaba al llegar a GitHub Trending. Se agradecen profundamente las contribuciones, comentarios y paciencia.

## Prerrequisitos

Antes de comenzar, asegúrate de tener instalado el siguiente software:

*   **Git:** Para clonar el repositorio. [Descargar Git](https://git-scm.com/downloads)
*   **Python 3.10.x:** Recomendamos encarecidamente utilizar la versión 3.10.x de Python. Usar otras versiones podría causar errores de dependencias. [Descargar Python 3.10](https://www.python.org/downloads/release/python-3100/) (elige una versión 3.10.x).
*   **Docker Engine & Docker Compose:** Para ejecutar servicios integrados como SearxNG.
    *   Instala Docker Desktop (que incluye Docker Compose V2): [Windows](https://docs.docker.com/desktop/install/windows-install/) | [Mac](https://docs.docker.com/desktop/install/mac-install/) | [Linux](https://docs.docker.com/desktop/install/linux-install/)
    *   Alternativamente, instala Docker Engine y Docker Compose por separado en Linux: [Docker Engine](https://docs.docker.com/engine/install/) | [Docker Compose](https://docs.docker.com/compose/install/) (asegúrate de instalar Compose V2, por ejemplo, `sudo apt-get install docker-compose-plugin`).

### 1. **Clona el repositorio y haz la configuración inicial**

```sh
git clone https://github.com/Fosowl/agenticSeek.git
cd agenticSeek
mv .env.example .env
```

### 2. Cambia el contenido del archivo .env

```sh
SEARXNG_BASE_URL="http://127.0.0.1:8080"
REDIS_BASE_URL="redis://redis:6379/0"
WORK_DIR="/Users/mlg/Documents/workspace_for_ai"
OLLAMA_PORT="11434"
LM_STUDIO_PORT="1234"
CUSTOM_ADDITIONAL_LLM_PORT="11435"
OPENAI_API_KEY='optional'
DEEPSEEK_API_KEY='optional'
OPENROUTER_API_KEY='optional'
TOGETHER_API_KEY='optional'
GOOGLE_API_KEY='optional'
ANTHROPIC_API_KEY='optional'
```

Actualiza el archivo `.env` con tus propios valores según sea necesario:

- **SEARXNG_BASE_URL**: Déjalo sin cambios
- **REDIS_BASE_URL**: Déjalo sin cambios
- **WORK_DIR**: Ruta a tu directorio de trabajo en tu máquina local. AgenticSeek podrá leer e interactuar con estos archivos.
- **OLLAMA_PORT**: Número de puerto para el servicio Ollama.
- **LM_STUDIO_PORT**: Número de puerto para el servicio LM Studio.
- **CUSTOM_ADDITIONAL_LLM_PORT**: Puerto para cualquier servicio LLM adicional personalizado.

**Las claves API son totalmente opcionales para el usuario que elija ejecutar LLM localmente, que es el propósito principal de este proyecto. Déjalas vacías si tienes hardware suficiente**

### 3. **Inicia Docker**

Asegúrate de que Docker esté instalado y en funcionamiento en tu sistema. Puedes iniciar Docker usando los siguientes comandos:

- **En Linux/macOS:**  
    Abre una terminal y ejecuta:
    ```sh
    sudo systemctl start docker
    ```
    O lanza Docker Desktop desde el menú de aplicaciones si está instalado.

- **En Windows:**  
    Inicia Docker Desktop desde el menú Inicio.

Puedes verificar que Docker está funcionando ejecutando:
```sh
docker info
```
Si ves información sobre tu instalación de Docker, está funcionando correctamente.

Consulta la tabla de [Proveedores Locales](#list-of-local-providers) a continuación para un resumen.

Siguiente paso: [Ejecutar AgenticSeek localmente](#start-services-and-run)

*Consulta la sección de [Solución de Problemas](#troubleshooting) si tienes inconvenientes.*
*Si tu hardware no puede ejecutar LLMs localmente, consulta [Configuración para usar con una API](#setup-to-run-with-an-api).*
*Para explicaciones detalladas del `config.ini`, consulta la [Sección de Configuración](#config).*

---

## Configuración para ejecutar LLM localmente en tu máquina

**Requisitos de hardware:**

Para ejecutar LLMs localmente, necesitarás hardware suficiente. Como mínimo, se requiere una GPU capaz de ejecutar Magistral, Qwen o Deepseek 14B. Consulta las recomendaciones de modelos/rendimiento en las preguntas frecuentes.

**Configura tu proveedor local**

Inicia tu proveedor local, por ejemplo con ollama:

```sh
ollama serve
```

Consulta abajo la lista de proveedores locales soportados.

**Actualiza el config.ini**

Cambia el archivo config.ini para establecer provider_name a un proveedor soportado y provider_model a un LLM soportado por tu proveedor. Recomendamos modelos de razonamiento como *Magistral* o *Deepseek*.

Consulta las **FAQ** al final del README para el hardware requerido.

```sh
[MAIN]
is_local = True # Indica si estás ejecutando localmente o con proveedor remoto.
provider_name = ollama # o lm-studio, openai, etc.
provider_model = deepseek-r1:14b # elige un modelo que se ajuste a tu hardware
provider_server_address = 127.0.0.1:11434
agent_name = Jarvis # nombre de tu IA
recover_last_session = True # si se recupera la sesión previa
save_session = True # si se recuerda la sesión actual
speak = False # texto a voz
listen = False # voz a texto, solo para CLI, experimental
jarvis_personality = False # si usar una personalidad más tipo "Jarvis" (experimental)
languages = en zh # Lista de idiomas, texto a voz usará el primero por defecto
[BROWSER]
headless_browser = True # déjalo sin cambios salvo que uses CLI en el host.
stealth_mode = True # Usa selenium indetectable para reducir detección de navegador
```

**Advertencia**:

- El formato del archivo `config.ini` no admite comentarios.
No copies y pegues la configuración de ejemplo directamente, ya que los comentarios causarán errores. En su lugar, modifica manualmente el archivo `config.ini` con tus ajustes deseados, excluyendo cualquier comentario.

- *NO* establezcas provider_name en `openai` si usas LM-studio para ejecutar LLMs. Debe ser `lm-studio`.

- Algunos proveedores (ej: lm-studio) requieren que incluyas `http://` delante de la IP. Por ejemplo `http://127.0.0.1:1234`

**Lista de proveedores locales**

| Proveedor    | ¿Local? | Descripción                                                           |
|--------------|---------|-----------------------------------------------------------------------|
| ollama       | Sí      | Ejecuta LLMs localmente fácilmente usando ollama como proveedor LLM   |
| lm-studio    | Sí      | Ejecuta LLM localmente con LM studio (establece `provider_name` en `lm-studio`)|
| openai       | Sí      | Usa una API compatible con openai (ej: servidor llama.cpp)            |

Siguiente paso: [Iniciar servicios y ejecutar AgenticSeek](#Start-services-and-Run)  

*Consulta la sección de [Solución de Problemas](#troubleshooting) si tienes inconvenientes.*
*Si tu hardware no puede ejecutar LLMs localmente, consulta [Configuración para usar con una API](#setup-to-run-with-an-api).*
*Para explicaciones detalladas del `config.ini`, consulta la [Sección de Configuración](#config).*

## Configuración para usar con una API

Esta configuración utiliza proveedores LLM externos en la nube. Necesitarás una clave API del servicio elegido.

**1. Elige un proveedor de API y obtén una clave API:**

Consulta la [Lista de proveedores de API](#list-of-api-providers) a continuación. Visita sus sitios web para registrarte y obtener una clave API.

**2. Establece tu clave API como variable de entorno:**


*   **Linux/macOS:**
    Abre tu terminal y usa el comando `export`. Es mejor añadir esto al archivo de perfil de tu shell (por ejemplo, `~/.bashrc`, `~/.zshrc`) para que sea persistente.
    ```sh
    export PROVIDER_API_KEY="tu_clave_api_aquí" 
    # Reemplaza PROVIDER_API_KEY por el nombre específico de la variable, por ejemplo, OPENAI_API_KEY, GOOGLE_API_KEY
    ```
    Ejemplo para TogetherAI:
    ```sh
    export TOGETHER_API_KEY="xxxxxxxxxxxxxxxxxxxxxx"
    ```
*   **Windows:**
*   **Command Prompt (Temporal para la sesión actual):**
    ```cmd
    set PROVIDER_API_KEY=tu_clave_api_aquí
    ```
*   **PowerShell (Temporal para la sesión actual):**
    ```powershell
    $env:PROVIDER_API_KEY="tu_clave_api_aquí"
    ```
*   **Permanentemente:** Busca "variables de entorno" en la barra de búsqueda de Windows, haz clic en "Editar las variables de entorno del sistema" y luego haz clic en el botón "Variables de entorno...". Añade una nueva variable de usuario con el nombre apropiado (por ejemplo, `OPENAI_API_KEY`) y tu clave como valor.

*(Consulta la FAQ: [¿Cómo configuro las claves API?](#how-do-i-set-api-keys) para más detalles).*


**3. Actualiza `config.ini`:**
```ini
[MAIN]
is_local = False
provider_name = openai # O google, deepseek, togetherAI, huggingface
provider_model = gpt-3.5-turbo # O gemini-1.5-flash, deepseek-chat, mistralai/Mixtral-8x7B-Instruct-v0.1 etc.
provider_server_address = # Normalmente se ignora o puede dejarse en blanco cuando is_local = False para la mayoría de APIs
# ... otros ajustes ...
```
*Advertencia:* Asegúrate de que no haya espacios al final de los valores en `config.ini`.

**Lista de Proveedores de API**

| Proveedor    | `provider_name` | ¿Local? | Descripción                                        | Enlace de Clave API (Ejemplos)                    |
|--------------|-----------------|---------|----------------------------------------------------|---------------------------------------------------|
| OpenAI       | `openai`        | No      | Usa modelos ChatGPT vía la API de OpenAI.           | [platform.openai.com/signup](https://platform.openai.com/signup) |
| Google Gemini| `google`        | No      | Usa modelos Google Gemini vía Google AI Studio.     | [aistudio.google.com/keys](https://aistudio.google.com/keys) |
| Deepseek     | `deepseek`      | No      | Usa modelos Deepseek vía su API.                    | [platform.deepseek.com](https://platform.deepseek.com) |
| Hugging Face | `huggingface`   | No      | Usa modelos de la Hugging Face Inference API.       | [huggingface.co/settings/tokens](https://huggingface.co/settings/tokens) |
| TogetherAI   | `togetherAI`    | No      | Usa varios modelos open-source vía la API de TogetherAI.| [api.together.ai/settings/api-keys](https://api.together.ai/settings/api-keys) |

*Nota:*
*   Recomendamos no usar `gpt-4o` u otros modelos de OpenAI para tareas complejas de navegación web y planificación, ya que las optimizaciones actuales de prompts están diseñadas para modelos como Deepseek.
*   Las tareas de codificación/bash pueden presentar problemas con Gemini, ya que puede que no siga estrictamente los prompts de formato optimizados para Deepseek.
*   El campo `provider_server_address` en `config.ini` generalmente no se usa cuando `is_local = False`, ya que el endpoint de la API suele estar predefinido en la librería del proveedor correspondiente.

Próximo paso: [Iniciar servicios y ejecutar AgenticSeek](#Start-services-and-Run)

*Consulta la sección **Problemas conocidos** si tienes inconvenientes*

*Consulta la sección **Config** para una explicación detallada del archivo de configuración.*

---

## Iniciar servicios y ejecutar

Por defecto AgenticSeek se ejecuta completamente en docker.

Inicia los servicios necesarios. Esto iniciará todos los servicios definidos en docker-compose.yml, incluyendo:
    - searxng
    - redis (requerido por searxng)
    - frontend
    - backend (si usas `full`)

```sh
./start_services.sh full # MacOS
start ./start_services.cmd full # Windows
```

**Advertencia:** Este paso descargará y cargará todas las imágenes de Docker, lo cual puede tardar hasta 30 minutos. Después de iniciar los servicios, espera hasta que el servicio backend esté completamente funcionando (deberías ver **backend: "GET /health HTTP/1.1" 200 OK** en el log) antes de enviar cualquier mensaje. El backend puede tardar unos 5 minutos en iniciar en la primera ejecución.

Ve a `http://localhost:3000/` y deberías ver la interfaz web.

*Solución de problemas al iniciar servicios:* Si estos scripts fallan, asegúrate de que Docker Engine esté en ejecución y que Docker Compose (V2, `docker compose`) esté correctamente instalado. Revisa la salida en la terminal para mensajes de error. Consulta [FAQ: ¡Ayuda! Obtengo un error al ejecutar AgenticSeek o sus scripts.](#faq-troubleshooting)

**Opcional:** Ejecutar en el host (modo CLI):

Para ejecutar con interfaz CLI deberás instalar el paquete en el host:

```sh
./install.sh
./install.bat # windows
```

Inicia los servicios:

```sh
./start_services.sh # MacOS
start ./start_services.cmd # Windows
```

Usa la CLI: `python3 cli.py`


---

## Uso

Asegúrate de que los servicios estén activos con `./start_services.sh full` y accede a `localhost:3000` para la interfaz web.

También puedes usar reconocimiento de voz configurando `listen = True` en el config. Solo para modo CLI.

Para salir, simplemente di/escribe `goodbye`.

Algunos ejemplos de uso:

> *¡Crea un juego de la serpiente en python!*

> *Busca en la web los mejores cafés en Rennes, Francia, y guarda una lista de tres con sus direcciones en rennes_cafes.txt.*

> *Escribe un programa en Go que calcule el factorial de un número, guárdalo como factorial.go en tu espacio de trabajo*

> *Busca en mi carpeta summer_pictures todos los archivos JPG, renómbralos con la fecha de hoy y guarda una lista de los archivos renombrados en photos_list.txt*

> *Busca en línea películas populares de ciencia ficción del 2024 y elige tres para ver esta noche. Guarda la lista en movie_night.txt.*

> *Busca en la web los últimos artículos de noticias de IA de 2025, selecciona tres y escribe un script en Python para extraer sus títulos y resúmenes. Guarda el script como news_scraper.py y los resúmenes en ai_news.txt en /home/projects*

> *El viernes, busca en la web una API gratuita de precios de acciones, regístrate con supersuper7434567@gmail.com y escribe un script en Python para obtener los precios diarios de Tesla usando la API, guardando los resultados en stock_prices.csv*

*Ten en cuenta que las capacidades de llenado de formularios aún son experimentales y podrían fallar.*



Después de escribir tu consulta, AgenticSeek asignará el mejor agente para la tarea.

Dado que este es un prototipo temprano, el sistema de enrutamiento de agentes puede no asignar siempre el agente adecuado según tu consulta.

Por lo tanto, debes ser muy explícito en lo que deseas y cómo la IA debe proceder; por ejemplo, si quieres que realice una búsqueda web, no digas:

`¿Conoces algunos buenos países para viajar solo?`

En su lugar, pide:

`Haz una búsqueda web y encuentra cuáles son los mejores países para viajar solo`

---

## **Configuración para ejecutar el LLM en tu propio servidor**  

Si tienes un ordenador potente o un servidor que puedas usar, pero quieres utilizarlo desde tu laptop, tienes la opción de ejecutar el LLM en un servidor remoto usando nuestro servidor LLM personalizado.

En tu "servidor" que ejecutará el modelo de IA, obtén la dirección IP

```sh
ip a | grep "inet " | grep -v 127.0.0.1 | awk '{print $2}' | cut -d/ -f1 # ip local
curl https://ipinfo.io/ip # ip pública
```

Nota: Para Windows o macOS, utiliza ipconfig o ifconfig respectivamente para encontrar la dirección IP.

Clona el repositorio y entra en la carpeta `server/`.


```sh
git clone --depth 1 https://github.com/Fosowl/agenticSeek.git
cd agenticSeek/llm_server/
```

Instala los requisitos específicos del servidor:

```sh
pip3 install -r requirements.txt
```

Ejecuta el script del servidor.

```sh
python3 app.py --provider ollama --port 3333
```

Puedes elegir entre usar `ollama` y `llamacpp` como servicio LLM.


Ahora en tu ordenador personal:

Cambia el archivo `config.ini` para establecer `provider_name` a `server` y `provider_model` a `deepseek-r1:xxb`.
Configura `provider_server_address` con la dirección IP de la máquina que ejecutará el modelo.

```sh
[MAIN]
is_local = False
provider_name = server
provider_model = deepseek-r1:70b
provider_server_address = x.x.x.x:3333
```


Próximo paso: [Iniciar servicios y ejecutar AgenticSeek](#Start-services-and-Run)  

---

## Reconocimiento de Voz a Texto

Advertencia: el reconocimiento de voz a texto solo funciona en modo CLI por el momento.

Ten en cuenta que actualmente el reconocimiento de voz a texto solo funciona en inglés.

La funcionalidad de reconocimiento de voz a texto está deshabilitada por defecto. Para habilitarla, establece la opción listen a True en el archivo config.ini:

```
listen = True
```

Cuando está habilitada, la función de voz a texto escucha una palabra clave de activación, que es el nombre del agente, antes de comenzar a procesar tu entrada. Puedes personalizar el nombre del agente actualizando el valor `agent_name` en el archivo *config.ini*:

```
agent_name = Friday
```

Para un reconocimiento óptimo, recomendamos usar un nombre inglés común como "John" o "Emma" como nombre del agente.

Una vez que vea que la transcripción comienza a aparecer, diga el nombre del agente en voz alta para activarlo (por ejemplo, "Friday").

Hable su consulta claramente.

Finalice su solicitud con una frase de confirmación para indicar al sistema que debe proceder. Ejemplos de frases de confirmación incluyen:
```
"hazlo", "adelante", "ejecuta", "corre", "inicia", "gracias", "harías eso", "por favor", "¿vale?", "proceder", "continuar", "sigue", "haz eso", "hazlo", "¿entiendes?"
```

## Configuración

Ejemplo de configuración:
```
[MAIN]
is_local = True
provider_name = ollama
provider_model = deepseek-r1:32b
provider_server_address = http://127.0.0.1:11434 # Ejemplo para Ollama; use http://127.0.0.1:1234 para LM-Studio
agent_name = Friday
recover_last_session = False
save_session = False
speak = False
listen = False

jarvis_personality = False
languages = en zh # Lista de idiomas para TTS y potencialmente enrutamiento.
[BROWSER]
headless_browser = False
stealth_mode = False
```

**Explicación de los ajustes en `config.ini`**:

*   **Sección `[MAIN]`:**
    *   `is_local`: `True` si utiliza un proveedor LLM local (Ollama, LM-Studio, servidor compatible con OpenAI local) o la opción de servidor autohospedado. `False` si usa una API en la nube (OpenAI, Google, etc.).
    *   `provider_name`: Especifica el proveedor LLM.
        *   Opciones locales: `ollama`, `lm-studio`, `openai` (para servidores locales compatibles con OpenAI), `server` (para configuración de servidor autohospedado).
        *   Opciones de API: `openai`, `google`, `deepseek`, `huggingface`, `togetherAI`.
    *   `provider_model`: El nombre o ID del modelo específico para el proveedor elegido (por ejemplo, `deepseekcoder:6.7b` para Ollama, `gpt-3.5-turbo` para OpenAI API, `mistralai/Mixtral-8x7B-Instruct-v0.1` para TogetherAI).
    *   `provider_server_address`: La dirección de su proveedor LLM.
        *   Para proveedores locales: por ejemplo, `http://127.0.0.1:11434` para Ollama, `http://127.0.0.1:1234` para LM-Studio.
        *   Para el tipo de proveedor `server`: La dirección de su servidor LLM autohospedado (por ejemplo, `http://your_server_ip:3333`).
        *   Para APIs en la nube (`is_local = False`): Normalmente se ignora o puede dejarse en blanco, ya que el endpoint API suele ser gestionado por la librería cliente.
    *   `agent_name`: Nombre del asistente de IA (por ejemplo, Friday). Se utiliza como palabra clave para activación por voz si está habilitado.
    *   `recover_last_session`: `True` para intentar restaurar el estado de la sesión anterior, `False` para comenzar de nuevo.
    *   `save_session`: `True` para guardar el estado de la sesión actual para una posible recuperación, `False` en caso contrario.
    *   `speak`: `True` para habilitar la salida de voz por texto a voz, `False` para deshabilitarla.
    *   `listen`: `True` para habilitar la entrada de voz a texto (solo en modo CLI), `False` para deshabilitarla.
    *   `work_dir`: **Crucial:** El directorio donde AgenticSeek leerá/escribirá archivos. **Asegúrese de que esta ruta sea válida y accesible en su sistema.**
    *   `jarvis_personality`: `True` para usar un prompt de sistema más tipo "Jarvis" (experimental), `False` para el prompt estándar.
    *   `languages`: Una lista separada por comas de idiomas (por ejemplo, `en, zh, fr`). Se usa para la selección de voz TTS (por defecto el primero) y puede ayudar al enrutador LLM. Evite demasiados idiomas o muy similares para la eficiencia del enrutador.
*   **Sección `[BROWSER]`:**
    *   `headless_browser`: `True` para ejecutar el navegador automatizado sin ventana visible (recomendado para interfaz web o uso no interactivo). `False` para mostrar la ventana del navegador (útil para modo CLI o depuración).
    *   `stealth_mode`: `True` para habilitar medidas que dificultan la detección de la automatización del navegador. Puede requerir la instalación manual de extensiones como anticaptcha.


Esta sección resume los tipos de proveedores LLM soportados. Configúrelos en `config.ini`.

**Proveedores locales (Ejecutados en su propio hardware):**

| Nombre del proveedor en `config.ini` | `is_local` | Descripción                                                                 | Sección de configuración                                                    |
|--------------------------------------|------------|-----------------------------------------------------------------------------|----------------------------------------------------------------------------|
| `ollama`                            | `True`     | Use Ollama para servir LLMs locales.                                        | [Configuración para ejecutar LLM localmente](#setup-for-running-llm-locally-on-your-machine) |
| `lm-studio`                         | `True`     | Use LM-Studio para servir LLMs locales.                                     | [Configuración para ejecutar LLM localmente](#setup-for-running-llm-locally-on-your-machine) |
| `openai` (para servidor local)       | `True`     | Conéctese a un servidor local que exponga una API compatible con OpenAI (por ejemplo, llama.cpp). | [Configuración para ejecutar LLM localmente](#setup-for-running-llm-locally-on-your-machine) |
| `server`                            | `False`    | Conéctese al servidor LLM autohospedado de AgenticSeek ejecutándose en otra máquina. | [Configuración para ejecutar el LLM en su propio servidor](#setup-to-run-the-llm-on-your-own-server) |

**Proveedores de API (En la nube):**

| Nombre del proveedor en `config.ini` | `is_local` | Descripción                                      | Sección de configuración                              |
|--------------------------------------|------------|--------------------------------------------------|-------------------------------------------------------|
| `openai`                            | `False`    | Use la API oficial de OpenAI (por ejemplo, GPT-3.5, GPT-4). | [Configuración para usar una API](#setup-to-run-with-an-api) |
| `google`                            | `False`    | Use los modelos Gemini de Google vía API.         | [Configuración para usar una API](#setup-to-run-with-an-api) |
| `deepseek`                          | `False`    | Use la API oficial de Deepseek.                   | [Configuración para usar una API](#setup-to-run-with-an-api) |
| `huggingface`                       | `False`    | Use la API de Inferencia de Hugging Face.         | [Configuración para usar una API](#setup-to-run-with-an-api) |
| `togetherAI`                        | `False`    | Use la API de TogetherAI para varios modelos open.| [Configuración para usar una API](#setup-to-run-with-an-api) |

---
## Solución de problemas

Si encuentra problemas, esta sección proporciona orientación.

# Problemas conocidos

## Problemas con ChromeDriver

**Ejemplo de error:** `SessionNotCreatedException: Message: session not created: This version of ChromeDriver only supports Chrome version XXX`

*   **Causa:** La versión de ChromeDriver instalada no es compatible con la versión de su navegador Google Chrome.
*   **Solución:**
    1.  **Verifique la versión de Chrome:** Abra Google Chrome, vaya a `Configuración > Acerca de Chrome` para encontrar la versión (por ejemplo, "Versión 120.0.6099.110").
    2.  **Descargue el ChromeDriver correspondiente:**
        *   Para versiones de Chrome 115 y superiores: Vaya a los [Chrome for Testing (CfT) JSON Endpoints](https://googlechromelabs.github.io/chrome-for-testing/). Busque el canal "stable" y descargue el ChromeDriver para su SO que coincida con la versión principal de su Chrome.
        *   Para versiones antiguas (menos común): Puede encontrarlas en la página de [ChromeDriver - WebDriver for Chrome](https://chromedriver.chromium.org/downloads).
        *   La imagen a continuación muestra un ejemplo de la página CfT:
            ![Descargue una versión específica de Chromedriver desde la página Chrome for Testing](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/chromedriver_readme.png)
    3.  **Instale ChromeDriver:**
        *   Asegúrese de que el `chromedriver` descargado (o `chromedriver.exe` en Windows) esté en un directorio incluido en la variable de entorno PATH de su sistema (por ejemplo, `/usr/local/bin` en Linux/macOS, o una carpeta de scripts personalizada añadida a PATH en Windows).
        *   Alternativamente, colóquelo en el directorio raíz del proyecto `agenticSeek`.
        *   Asegúrese de que el driver sea ejecutable (por ejemplo, `chmod +x chromedriver` en Linux/macOS).
    4.  Consulte la sección [Instalación de ChromeDriver](#chromedriver-installation) en la guía principal de instalación para más detalles.

Si esta sección está incompleta o encuentra otros problemas con ChromeDriver, considere buscar en los [Issues de GitHub](https://github.com/Fosowl/agenticSeek/issues) existentes o crear uno nuevo.

`Exception: Failed to initialize browser: Message: session not created: This version of ChromeDriver only supports Chrome version 113
Current browser version is 134.0.6998.89 with binary path`

Esto ocurre si hay un desajuste entre su versión de navegador y la versión de chromedriver.

Debe ir a descargar la versión más reciente:

https://developer.chrome.com/docs/chromedriver/downloads

Si está usando Chrome versión 115 o superior vaya a:

https://googlechromelabs.github.io/chrome-for-testing/

Y descargue la versión de chromedriver que coincida con su SO.

![texto alternativo](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/chromedriver_readme.png)

Si esta sección está incompleta por favor cree un issue.

## Problemas de adaptadores de conexión

```
Exception: Provider lm-studio failed: HTTP request failed: No connection adapters were found for '127.0.0.1:1234/v1/chat/completions'` (Nota: el puerto puede variar)
```

*   **Causa:** La variable `provider_server_address` en `config.ini` para `lm-studio` (u otros servidores similares compatibles con OpenAI locales) no tiene el prefijo `http://` o apunta al puerto incorrecto.
*   **Solución:**
    *   Asegúrese de que la dirección incluya `http://`. LM-Studio normalmente usa por defecto `http://127.0.0.1:1234`.
    *   Corrija en `config.ini`: `provider_server_address = http://127.0.0.1:1234` (o el puerto real de su servidor LM-Studio).

## URL base de SearxNG no proporcionada

```
raise ValueError("SearxNG base URL must be provided either as an argument or via the SEARXNG_BASE_URL environment variable.")
ValueError: SearxNG base URL must be provided either as an argument or via the SEARXNG_BASE_URL environment variable.`
```

## FAQ

**P: ¿Qué hardware necesito?**  

| Tamaño del modelo | GPU  | Comentario                                               |
|-------------------|------|---------------------------------------------------------|
| 7B                | 8GB Vram | ⚠️ No recomendado. Bajo rendimiento, frecuentes alucinaciones, y los agentes planificadores probablemente fallarán. |
| 14B               | 12 GB VRAM (ej. RTX 3060) | ✅ Usable para tareas simples. Puede tener problemas con navegación web y tareas de planificación. |
| 32B               | 24+ GB VRAM (ej. RTX 4090) | 🚀 Éxito en la mayoría de tareas, aún puede tener dificultades en planificación de tareas |
| 70B+              | 48+ GB Vram | 💪 Excelente. Recomendado para casos de uso avanzados. |

**P: Me aparece un error, ¿qué hago?**  

Asegúrese de que el local esté en ejecución (`ollama serve`), que su `config.ini` coincida con su proveedor, y que las dependencias estén instaladas. Si nada funciona, siéntase libre de crear un issue.

**P: ¿Realmente puede funcionar 100% localmente?**  

Sí, con Ollama, lm-studio o servidores, todos los modelos de voz a texto, LLM y texto a voz se ejecutan localmente. Las opciones no locales (OpenAI u otras APIs) son opcionales.

**P: ¿Por qué debería usar AgenticSeek si ya tengo Manus?**

A diferencia de Manus, AgenticSeek prioriza la independencia de sistemas externos, dándole más control, privacidad y evitando costos de API.

**P: ¿Quién está detrás del proyecto?**

El proyecto fue creado por mí, junto a dos amigos que actúan como mantenedores y colaboradores de la comunidad open-source en GitHub. Solo somos un grupo de personas apasionadas, no una startup ni afiliados a ninguna organización.

Cualquier cuenta de AgenticSeek en X que no sea mi cuenta personal (https://x.com/Martin993886460) es una suplantación.

## Contribuir

¡Buscamos desarrolladores para mejorar AgenticSeek! Consulte los issues abiertos o las discusiones.

[Guía de contribución](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/docs/CONTRIBUTING.md)

[![Gráfico de estrellas históricas](https://api.star-history.com/svg?repos=Fosowl/agenticSeek&type=Date)](https://www.star-history.com/#Fosowl/agenticSeek&Date)

## Mantenedores:

 > [Fosowl](https://github.com/Fosowl) | Hora de París 

 > [antoineVIVIES](https://github.com/antoineVIVIES) | Hora de Taipéi 

 > [steveh8758](https://github.com/steveh8758) | Hora de Taipéi 

## Agradecimientos especiales:

 > [tcsenpai](https://github.com/tcsenpai) y [plitc](https://github.com/plitc) por ayudar con la dockerización del backend

## Patrocinadores:

Patrocinadores mensuales de 5$ o más aparecen aquí:
- **tatra-labs**

Certainly! Please provide the text for Part 4 of 4 so I can translate it as requested.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-16

---
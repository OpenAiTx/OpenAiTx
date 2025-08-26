# Servidor Mejorado PubChem MCP para Asistentes de IA

🧪 Un servidor MCP avanzado, robusto y enfocado en la privacidad que permite a los asistentes de IA buscar y acceder inteligentemente a información de compuestos químicos desde PubChem.

Este Servidor PubChem MCP actúa como un puente poderoso entre los asistentes de IA (como los de AnythingLLM) y la vasta base de datos química de PubChem. Aprovecha el Protocolo de Contexto de Modelo (MCP) para permitir que los modelos de IA realicen búsquedas inteligentes y resistentes de compuestos químicos y recuperen sus propiedades detalladas programáticamente.

---

## ✨ Características Principales

Esto no es solo otro envoltorio para PubChem. Este servidor ha sido reconstruido desde cero para ser altamente robusto e inteligente:

-   **🧠 Búsqueda de Respaldo Inteligente**: Si una búsqueda por nombre común (como "Vitamina D") falla, el servidor automáticamente realiza una búsqueda más profunda en la base de datos de Sustancias de PubChem para encontrar el compuesto correcto. Esto mejora drásticamente las tasas de éxito para consultas ambiguas.
-   **🛡️ Manejo Robusto de Errores y Reintentos**: El servidor está diseñado para manejar errores de API con gracia. Si encuentra un error de "Servidor Ocupado" de PubChem, esperará y reintentará la solicitud automáticamente, asegurando que tus consultas tengan éxito incluso bajo alta carga.
-   **🔒 Soporte Opcional de Proxy Tor**: Tienes control total sobre tu privacidad. Un simple archivo `config.ini` permite enrutar todas las solicitudes a través de la red Tor (vía proxy SOCKS5 o HTTP), evitando que tu dirección IP se exponga. El servidor es seguro por defecto y **nunca** filtrará tu IP si la conexión al proxy falla.
-   **🔎 Búsqueda de Compuestos Individuales y Múltiples**: Maneja sin problemas solicitudes para uno o varios compuestos en un solo prompt.
-   **🧪 Recuperación Detallada de Propiedades**: Accede a propiedades químicas clave como Nombre IUPAC, Fórmula Molecular, Peso Molecular y, crucialmente, **Masa Monoisotópica**.

---

---

### 🚀 Sin Instalación Requerida: Pruébalo en Vivo en Smithery.ai

Para quienes son nuevos en servidores MCP o solo quieren probar las capacidades de esta herramienta sin configuración local, hay una versión alojada en vivo disponible en Smithery.ai. Esto te permite chatear con el agente directamente en tu navegador.

[**<-- Explora el Agente PubChem en Vivo en Smithery.ai -->**](https://smithery.ai/server/@Milor123/smithery-pubchem-deploy)

**Cómo comenzar:**

1.  Haz clic en el enlace arriba para ir a la página del servidor.
2.  Inicia sesión usando tu cuenta de **GitHub** o **Google**.
3.  Haz clic en el botón **"Explore capabilities"** para abrir una interfaz de chat y comenzar a probar.

> **✅ Modelos Recomendados para Mejores Resultados**
>
> Para obtener la máxima precisión, especialmente con números decimales largos, recomendamos encarecidamente usar modelos potentes. Los siguientes han sido probados y funcionan excelentemente con esta herramienta:
>
> *   **Claude 3 Sonnet de Anthropic**
> *   **GPT-4 Turbo de OpenAI** (o versiones más nuevas como GPT-4o)
>
> Confirmamos que ambos modelos procesaron correctamente la precisión completa de los números decimales devueltos por la herramienta sin ningún redondeo.

---

## 🚀 Inicio Rápido e Instalación

Este servidor está diseñado para ejecutarse localmente, ya sea en tu escritorio o dentro del entorno Docker de AnythingLLM.

### 1. Dependencias

Este proyecto depende de algunas bibliotecas de Python. Asegúrate de que estén instaladas en tu entorno.

Crea un archivo `requirements.txt` con el siguiente contenido:
```txt
requests
bs4 
mcp 
pubchempy
pandas
PySocks
```
Instálalos usando `uv` o `pip`:

```bash
uv venv
.venv\Scripts\activate
uv pip install -r requirements.txt
```
*(Nota: `PySocks` solo es necesario si planeas usar la función de proxy SOCKS5 de Tor.)*

### 2. Configuración

El servidor se configura mediante un archivo `config.ini` que se **crea automáticamente** la primera vez que lo ejecutas. Este archivo aparecerá en el mismo directorio que el script `pubchem_server.py`.

**`config.ini` por defecto:**
```ini
[proxy]
# Change 'use_proxy' to 'true' to route all requests through a proxy.
# Essential for protecting your privacy if you use Tor.
use_proxy = false

# Defines the proxy type. Options:
#   socks5h  -> (Recommended for Tor) The native SOCKS proxy for Tor. More secure.
#   http     -> An HTTP proxy. If using Tor, requires additional configuration.
proxy_type = socks5h

# The proxy address. THIS IS A CRITICAL SETTING!
#   - If you run this script on your DESKTOP, use: 127.0.0.1
#   - If you run this script inside DOCKER, use: host.docker.internal
host = 127.0.0.1

# The proxy port.
#   9050 -> Default port for Tor's SOCKS proxy.
#   8118 -> Default port for Tor's HTTP proxy (if enabled).
port = 9050
```

### 3. Integración con AnythingLLM

Sigue la documentación oficial para agregar esto como un servidor MCP personalizado. La clave es apuntar el `command` a tu ejecutable de Python y al script `pubchem_server.py`.

**Ejemplo para AnythingLLM Desktop (`plugins/anythingllm_mcp_servers.json`):**
```json
{
  "mcpServers": {
    "pubchem": {
      "name": "PubChem Server (Enhanced)",
      "transport": "stdio",
      "command": "\"C:\\path\\to\\your\\.venv\\Scripts\\python.exe\" \"C:\\path\\to\\your\\project\\pubchem_server.py\"",
      "cwd": "C:\\path\\to\\your\\project"
    }
  }
}
```


### 3.1 Ejemplos de Implementación con AnythingLLM

Aquí hay algunos ejemplos de cómo interactuar con el agente. Estas pruebas se realizaron utilizando AnythingLLM Desktop, conectándose a varios Modelos de Lenguaje Grandes a través de OpenRouter.

Un hallazgo crucial de nuestras pruebas es la importancia del modelo que elijas. **Recomendamos encarecidamente no usar modelos pequeños o locales** para esta tarea. Los modelos más pequeños a menudo tienen dificultades para analizar correctamente los datos devueltos por la herramienta, lo que conduce a errores como valores alucinados, formato incorrecto o, lo que es más crítico, **redondeo de números decimales**, lo que anula el propósito de esta herramienta de alta precisión.

Para garantizar la integridad de tus resultados, siempre es buena práctica verificar los datos en bruto devueltos por el MCP. Puedes aprender cómo hacerlo en la siguiente sección: [3.2 Cómo verificar las salidas del MCP en los registros](#32-como-verificar-las-salidas-del-mcp-en-los-registros).

<img width="837" height="1060" alt="imagen" src="https://github.com/user-attachments/assets/5a16c7a2-d65d-4d64-98dd-f3cb4cae9b22" />

Por otro lado, varios modelos han demostrado un rendimiento excelente. Obtuvimos resultados sobresalientes con **`Gemini 2.5 Flash lite` de Google**. mostró una precisión notable en el manejo de números decimales largos y en el formato correcto de la tabla Markdown final.

Google gemini 2.5 flash lite sin prompt y con prompt mantiene decimales perfectos (en el ejemplo usa 0.6 de temperatura)

<img width="1089" height="1061" alt="imagen" src="https://github.com/user-attachments/assets/4574efa5-d6d9-49e3-a665-a39a427f09a1" />

Para esta tarea específica, mi favorito personal es **`Gemini 2.5 Flash lite`** debido a su precisión y fiabilidad consistentes.

### 3.2 Cómo Verificar las Salidas del MCP en los Registros

La mejor manera de confirmar que el agente está recibiendo los datos correctos y que el LLM no está cometiendo errores es revisar el archivo de registro de depuración generado por el servidor MCP.

Este servidor está configurado para crear automáticamente un archivo de registro en una subcarpeta dentro del directorio de tu proyecto. La ubicación será:

```
your-project-folder/
└── logs_mcp/
    └── mcp_debug.log
```
Dentro de `mcp_debug.log`, encontrarás los datos JSON exactos que la herramienta envía de vuelta al LLM *antes* de que el modelo los procese. Puedes inspeccionar manualmente este JSON para verificar cualquier valor, especialmente números decimales largos de propiedades como `monoisotopic_mass`, asegurándote de que el LLM no haya introducido errores de redondeo o alucinaciones en su respuesta final.

---

## 📊 Uso

Una vez integrado, tu asistente de IA usará automáticamente esta herramienta cuando se le pregunte sobre información química. La herramienta principal expuesta es `search_compounds_by_name`.

### Ejemplo de Prompt

Este prompt demuestra la capacidad de la herramienta para manejar una lista de compuestos con tipos de nombres variados y recuperar múltiples propiedades.


```
@agent
Please use your PubChem tool to find information on the following compounds:

- Thiamine (Vitamin B1)
- Riboflavin (Vitamin B2)
- Folic Acid
- Hydroxocobalamin

For each compound found, please retrieve the IUPAC Name, Molecular Formula, and Monoisotopic Mass.

Present all the results in a single Markdown table.
```

El agente llamará a la herramienta `search_compounds_by_name`, que encontrará inteligentemente cada compuesto, recuperará sus datos y los devolverá al LLM para su formato.

---

## 🛠 Herramienta MCP Expuesta

### `search_compounds_by_name`

Busca múltiples compuestos por nombre, uno por uno, utilizando una estrategia inteligente de respaldo con pausas y reintentos para máxima fiabilidad.

**Parámetros:**
-   `names` (List[str]): Una lista de nombres de compuestos. Ejemplo: `["Aspirina", "Ibuprofeno"]`

**Devuelve:** Una lista de diccionarios, donde cada diccionario contiene la información del compuesto encontrado o un mensaje de error detallando por qué la búsqueda falló para ese compuesto específico.

---

## 🙏 Agradecimientos

Este proyecto fue fuertemente inspirado y construido sobre la base del original [PubChem-MCP-Server](https://github.com/JackKuo666/PubChem-MCP-Server) creado por **JackKuo666**.

Aunque este repositorio no es un fork directo, el proyecto original fue el punto de partida crucial. Esta versión mejora el concepto original con un enfoque en robustez extrema, estrategias inteligentes de búsqueda y privacidad del usuario mediante integración opcional con Tor 🧅.

Muchas gracias al autor original por su trabajo fantástico y por compartirlo con la comunidad.

---

## ⚠️ Descargo de responsabilidad

Esta herramienta está destinada a fines de investigación y educativos. Por favor, respete los términos de servicio de PubChem y utilice esta herramienta de manera responsable.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-26

---
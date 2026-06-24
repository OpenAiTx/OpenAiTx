# 🧠 Proxy Cursor DeepSeek V4

> **Repara con un clic el error `reasoning_content` al usar DeepSeek V4 en Cursor, olvídate del `Rate limit exceeded` y permite que el modo AI Agent funcione establemente.**

[![GitHub stars](https://img.shields.io/github/stars/tu-usuario/cursor-deepseek-v4-proxy?style=social)](https://github.com/tu-usuario/cursor-deepseek-v4-proxy)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

---

## 📌 ¿Qué problemas puedes resolver con este proyecto?

Si al usar DeepSeek V4 (Pro / Flash) en Cursor te encuentras frecuentemente con cualquiera de estos errores:

* `Provider returned error: The reasoning_content in the thinking mode must be passed back to the API.`
* `User API Key Rate limit exceeded` (aunque el cupo aún tiene mucho disponible)
* `AI Model Not Found: deepseek-v4-pro` (el backend reporta nombre de modelo inválido)
* La primera ronda de chat funciona, pero en la segunda empieza a fallar o interrumpirse

**No te compliques más, sigue esta guía y en 5 minutos estará completamente solucionado.**

> ⚠️  **Reparado el 2026-05-14**: El modelo de texto plano ahora filtra imágenes automáticamente, solucionando el error 502. Consulta el [registro de cambios](#changelog)

---

## ✨ Funciones principales

* ✅ **Caché automático y reenvío de la cadena de razonamiento**: Nunca más errores por falta de `reasoning_content`.
* ✅ **Limitación inteligente**: Cubo de tokens integrado para evitar picos de solicitudes que agoten el cupo gratuito.
* ✅ **Soporte para salida en flujo**: No afecta el efecto de escritura en Cursor.
* ✅ **Script de inicio con un clic**: Compatible con Windows / macOS / Linux, ejecuta con doble clic.
* ✅ **Logs transparentes**: La terminal muestra el estado de las solicitudes en tiempo real para facilitar la depuración.
* ✅ **Cero intrusión**: No modifica archivos del programa Cursor, solo cambia la URL base.

---

## 🖥️ Entornos compatibles

| Sistema operativo | Estado de soporte |
| :--- | :--- |
| **Windows 10 / 11** | ✅ Soportado |
| **macOS** | ✅ Compatible |
| **Linux** | ✅ Compatible |

> **Requisito único**: Instalar **Python 3.8** o superior (asegúrese de marcar `Add Python to PATH` durante la instalación).

---

## 🚀 Guía súper detallada en tres pasos (para principiantes)

### Paso 1: Descargar el proyecto e instalar dependencias

1.  Descargue el archivo ZIP del repositorio del proyecto y descomprímalo localmente (**la ruta no debe contener caracteres chinos**).
2.  Acceda a la carpeta descomprimida, escriba `cmd` en la barra de direcciones de la carpeta y presione Enter para abrir la ventana de comandos.
3.  Ejecute el siguiente comando para instalar las dependencias:
    ```bash
    pip install -r requirements.txt
    ```
    *Si aparece el mensaje `pip no es un comando interno`, reinstale Python y marque la opción `Add to PATH`.*

### Paso 2: Iniciar el proxy local + túnel

Necesitas un túnel para generar una dirección pública (Cursor restringe el acceso a localhost).

#### 🪟 Usuarios de Windows
1.  Asegúrate de que la carpeta contenga `cloudflared-windows-amd64.exe` (si no, descárgalo desde la [página oficial de Cloudflare](https://github.com/cloudflare/cloudflared/releases)).
2.  Haz doble clic para ejecutar **`start_proxy.bat`**.
3.  Aparecerán dos ventanas. En la **ventana del túnel**, encuentra una dirección `https://xxx.trycloudflare.com` y **cópiala**.

#### 🍎 Usuarios de macOS / Linux
1.  En la terminal, entra al directorio del proyecto y ejecuta:
    ```bash
    bash start_proxy.sh
    ```
2.  Espere un momento y copie la dirección `https://xxx.trycloudflare.com` que aparece en la salida del terminal.

> ⚠️ **Atención**: No cierre la ventana. La dirección del túnel cambia cada vez que se reinicia, pero mientras la ventana esté abierta, seguirá siendo válida.

### Paso 3: Configurar Cursor

1.  Abra la configuración de Cursor: presione `Ctrl+Shift+P` → escriba `Cursor Settings`.
2.  Vaya a la pestaña **Models**.
3.  En **"Override OpenAI Base URL"**, pegue la dirección que copió y **agregue `/v1` al final**:
    * Por ejemplo: `https://xxxxxx.trycloudflare.com/v1`
4.  Ingrese su **DeepSeek API Key** en el campo de API Key.
5.  **Cierre completamente y reinicie Cursor**.

---

## 🛡️ Solución al error "Model name not valid"

Si aparece un error al ejecutar Apply o tareas en segundo plano, siga estos pasos:

1.  Presione `Ctrl+Shift+P`, escriba `Preferences: Open User Settings (JSON)` y presione Enter.
2.  Añada la siguiente configuración dentro de las llaves `{}` del JSON:
    ```json
    "cursor.models": {
        "deepseek-v4-pro": {
            "provider": "openai",
            "apiBase": "[https://你的隧道地址.trycloudflare.com/v1](https://你的隧道地址.trycloudflare.com/v1)",
            "apiKey": "你的DeepSeek API Key"
        }
    }
    ```
3.  Guarda y reinicia Cursor.

---

## ❓ Preguntas frecuentes (FAQ)

<details>
<summary>🔁 ¿Qué hacer si cambia la dirección del túnel?</summary>
Cada vez que reinicias el script se genera una nueva dirección. Solo necesitas obtenerla de nuevo y actualizar la Base URL en Cursor.
</details>

<details>
<summary>💸 ¿Sigue apareciendo el mensaje Rate limit exceeded?</summary>
El nivel gratuito de DeepSeek tiene una frecuencia muy baja. Puedes editar `proxy.py` y reducir el valor `5` en `TokenBucket(rate=5/60.0, capacity=5)` (por ejemplo a `3`) para forzar una reducción en la frecuencia de solicitudes.
</details>

<details>
<summary>🚫 ¿Es obligatorio usar túnel? ¿No se puede conectar a localhost?</summary>
Por razones de seguridad, Cursor prohíbe la conexión directa a `localhost`. Cloudflare Tunnel es actualmente la solución de penetración más sencilla, gratuita y sin necesidad de registro.
</details>

<details>
<summary>🧪 ¿El proxy afecta la inteligencia del modelo?</summary>
En el 99% de los casos no se nota. El proxy solo completa automáticamente la cadena de pensamiento cuando el modelo “olvida” devolverla, asegurando que la conversación no se interrumpa.
</details>

<details>
<summary>🧪 ¿Por qué solo hay 200k de contexto, no 1M?</summary>
Este es el límite por defecto de Cursor, no un problema del proxy.

Cursor usa por defecto una ventana de contexto de 200k.
Para activar el contexto de 1M soportado por el modelo, debes habilitar el `Max Mode` en Cursor Chat.
Ruta:
Chat -> Selector de modelo -> Max Mode
</details>

---

## ⚙️ Personalización avanzada

* **Cambiar el upstream**: Modificar `UPSTREAM_URL` en `proxy.py`.  
* **Dominio fijo**: Si tienes tu propio dominio, puedes configurar el túnel nombrado persistente de Cloudflare (Persistent Tunnel).

<a name="changelog"></a>
## 🆕 Registro de cambios

### 2026-05-14: Corrección de compatibilidad con imágenes en modelos de texto plano

**Contenido de la corrección**  
Cuando clientes como Cursor envían mensajes que contienen imágenes a `deepseek-v4-pro` (modelo de texto plano), la capa proxy ahora filtra automáticamente los bloques `image_url`, dejando solo la parte de texto. Si un mensaje contiene solo imágenes (sin texto), se reemplaza por un texto indicativo para evitar que el modelo reciba un mensaje vacío.  
Esta corrección resuelve el error 502 causado por el mensaje `"unknown variant image_url, expected text"` devuelto por la API de DeepSeek.

**Mejoras adicionales**

- Se unificó el formato de error del upstream; el cliente recibirá errores JSON estructurados (en lugar de mensajes de error en crudo o páginas en blanco).  
- La lógica de compatibilidad con imágenes no afecta la caché de inferencia (`reasoning_content`), manteniendo el procesamiento correcto de mensajes históricos.

------

### Agradecimientos

Gracias a [@BG-ah](https://github.com/BG-ah) por reportar el problema de limitación de tasa en el Issue [#4](https://github.com/wustghj/cursor-deepseek-v4-proxy/issues/4) y a [@CH-nolyn](https://github.com/CH-nolyn) por su participación en la discusión. Sus comentarios impulsaron directamente esta corrección de compatibilidad, haciendo que el proxy funcione más estable con modelos de texto plano.

------

> 💡 **Consejo**: Si necesitas que el modelo entienda realmente el contenido de las imágenes, cambia el campo `model` en la solicitud a `deepseek-chat`, que soporta multimodalidad, y asegúrate de que tu cuenta DeepSeek tenga habilitados los permisos correspondientes.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-24

---
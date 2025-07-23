<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
  <a href="https://core.heysol.ai">
    <img src="https://github.com/user-attachments/assets/89066cdd-204b-46c2-8ad4-4935f5ca9edd" width="200px" alt="CORE logo" />
  </a>

### C.O.R.E: Tu cerebro digital para la era de la IA

<p align="center">
    <a href="https://deepwiki.com/RedPlanetHQ/core">
        <img src="https://deepwiki.com/badge.svg" alt="DeepWiki Badge" />
    </a>
</p>
<p align="center">
    <a href="https://docs.heysol.ai/core/overview"><b>Documentación</b></a> •
    <a href="https://discord.gg/YGUZcvDjUa"><b>Discord</b></a>
</p>
</div>

## 🧠 C.O.R.E.

**Motor de Observación y Recuperación Contextual**

C.O.R.E es un grafo de memoria portátil construido a partir de tus interacciones con LLM y datos personales, haciendo que todo tu contexto e historial de trabajo estén accesibles para cualquier herramienta de IA, como un cerebro digital. Esto elimina la necesidad de compartir contexto repetidamente. El objetivo es proporcionar:

- **Memoria Unificada y Portátil**: Agrega y recupera contexto fácilmente, y conecta tu memoria entre apps como Claude, Cursor, Windsurf y más.
- **Relacional, No solo Hechos Planos**: CORE organiza tu conocimiento, almacenando tanto hechos como relaciones para una memoria más profunda y rica como un cerebro real.
- **Propiedad del Usuario**: Tú decides qué conservar, actualizar o eliminar y compartes tu memoria con la herramienta que desees, liberándote del bloqueo de proveedor.

## 🎥 Video Demostrativo

[Mira la Demostración de C.O.R.E](https://youtu.be/iANZ32dnK60)

<img width="954" height="700" alt="Core dashboard" src="https://github.com/user-attachments/assets/d684b708-6907-47be-9499-a30b25434694" />

## 🧩  Funciones Clave

- **Grafo de Memoria**: Visualiza cómo se conectan tus hechos y preferencias
- **Chatea con la Memoria**: Haz preguntas sobre tu memoria para obtener información y comprensión instantánea
- **Plug n Play**: Usa instantáneamente la memoria CORE en apps como Cursor, Claude

## ☁️ Configuración de C.O.R.E Cloud

1. Regístrate en [Core Cloud](https://core.heysol.ai) y comienza a construir tu grafo de memoria.
2. Añade el texto que quieras guardar en memoria. Al hacer clic en el botón `+ Add` se generará tu grafo de memoria.
3. [Conecta Core Memory MCP con Cursor](#connecting-core-mcp-with-cursor)

## 💻 Configuración Local de C.O.R.E

#### Requisitos Previos

1. Docker
2. Clave de API de OpenAI


> **Nota:** Estamos trabajando activamente en mejorar el soporte para modelos Llama. Actualmente, C.O.R.E no proporciona resultados óptimos con modelos basados en Llama, pero estamos avanzando para asegurar una mejor compatibilidad y resultados en un futuro cercano.
> 
#### Ejecutar C.O.R.E localmente

1. **Copia las Variables de Entorno**

   Copia el archivo de ejemplo de entorno a `.env`:


   ```bash
   cp .env.example .env
   ```
2. **Iniciar la Aplicación**

   Utilice Docker Compose para iniciar todos los servicios requeridos:


   ```bash
   docker-compose up
   ```
3. **Acceder a la Aplicación**

   Una vez que los contenedores estén en funcionamiento, abre tu navegador y dirígete a [http://localhost:3000](http://localhost:3000).

4. **Crear Cuenta con Magic Link**

   - Para crear una cuenta, haz clic en el botón `Continuar con correo electrónico`

     <img width="865" height="490" alt="Crear cuenta" src="https://github.com/user-attachments/assets/65de110b-2b1f-42a5-9b8a-954227d68d52" />

   - Ingresa tu correo electrónico y haz clic en el botón `Enviar un Magic Link`

     <img width="824" height="429" alt="Ingresar correo electrónico" src="https://github.com/user-attachments/assets/76128b61-2086-48df-8332-38c2efa14087" />

   - `Copia el magic link de los registros del terminal` y ábrelo en tu navegador

     <img width="1010" height="597" alt="Magic link" src="https://github.com/user-attachments/assets/777cb4b1-bb93-4d54-b6ab-f7147e65aa5c" />


5. **Crea tu Espacio Privado y Agrega Datos**

   - En el panel de control, ve a la sección superior derecha -> Escribe un mensaje, por ejemplo, `Me encanta jugar bádminton`, y haz clic en `+Agregar`.
   - Tu memoria se pone en cola para su procesamiento; puedes monitorear su estado en la sección `Registros`.
     
     <img width="1496" height="691" alt="Registros de memoria principal" src="https://github.com/user-attachments/assets/dc34a7af-fe52-4142-9ecb-49ddc4e0e854" />

   - Una vez completado el procesamiento, los nodos se añadirán a tu grafo de conocimiento privado y serán visibles en el panel.
   - Posteriormente puedes elegir conectar esta memoria a otras herramientas o mantenerla privada.

6. **Busca en tu Memoria**

   - Utiliza la función de búsqueda del panel para consultar tus datos ingeridos dentro de tu espacio privado.


## Conectando CORE MCP con Cursor

1. Abre el panel de control de CORE y navega a la sección de API para generar un nuevo token de API.
2. En Cursor, ve a: Configuración → Herramientas e Integraciones → Nuevo Servidor MCP.
3. Agrega el servidor CORE MCP usando el formato de configuración a continuación. Asegúrate de reemplazar el valor de API_TOKEN con el token que generaste en el paso 1.

   Configuración MCP para agregar en Cursor


   ```json
   {
     "mcpServers": {
       "memory": {
         "command": "npx",
         "args": ["-y", "@redplanethq/core-mcp"],
         "env": {
           "API_TOKEN": "YOUR_API_TOKEN_HERE",
           "API_BASE_URL": "https://core.heysol.ai",
           "SOURCE": "cursor"
         }
       }
     }
   }
   ```
4. Ve a Configuración-> Reglas de usuario -> Nueva regla -> y agrega la siguiente regla para asegurarte de que todas tus interacciones de chat se almacenen en la memoria CORE


```
After every interaction, update the memory with the user's query and the assistant's
response to core-memory mcp. sessionId should be the uuid of the conversation
```
## Documentación

Explora nuestra documentación para sacar el máximo provecho de CORE
- [Conceptos Básicos](https://docs.heysol.ai/core/overview)
- [Referencia de API](https://docs.heysol.ai/core/local-setup)
- [Conectar Core Memory MCP con Cursor](#connecting-core-mcp-with-cursor)


## 🧑‍💻 Soporte
¿Tienes preguntas o comentarios? Estamos aquí para ayudarte:
- Discord: [Únete al canal core-support](https://discord.gg/YGUZcvDjUa)
- Documentación: [docs.heysol.ai/core](https://docs.heysol.ai/core/overview)
- Correo electrónico: manik@poozle.dev

## Directrices de uso

**Almacenar:**

- Historial de conversaciones
- Preferencias de usuario
- Contexto de tareas
- Materiales de referencia

**No almacenar:**

- Datos sensibles (PII)
- Credenciales
- Registros del sistema
- Datos temporales

## 👥 Colaboradores

<a href="https://github.com/RedPlanetHQ/core/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=RedPlanetHQ/core" />
</a>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---
<div align="center">
  <img src="https://raw.githubusercontent.com/micr0-dev/Altbot/main/assets/micr0-alty-banner.png" alt="Un banner decorativo con un patrón repetitivo de pequeños íconos de robots morados sobre un fondo claro, creando un efecto de papel tapiz retro-tecnológico">

# Altbot アクセシビリティロボット

_Haciendo el Fediverso más inclusivo, una imagen a la vez_

[![Última versión](https://img.shields.io/github/v/release/micr0-dev/Altbot)](https://github.com/micr0-dev/Altbot/releases)
[![Seguir en Mastodon](https://img.shields.io/mastodon/follow/113183205946060973?domain=fuzzies.wtf&style=social)](https://fuzzies.wtf/@altbot)
[![Licencia: AGPLv3](https://img.shields.io/badge/License-AGPLv3-blue.svg)](https://www.gnu.org/licenses/agpl-3.0)
[![Versión de Go](https://img.shields.io/github/go-mod/go-version/micr0-dev/Altbot)](https://go.dev/)
![Estado](https://img.shields.io/badge/status-active-success)
![Entorno](https://img.shields.io/badge/environment-friendly-green)

</div>

## Acerca de

Altbot es un bot de accesibilidad de código abierto diseñado para mejorar el Fediverso generando descripciones de texto alternativo para imágenes, video y audio. Esto ayuda a que el contenido sea más accesible para usuarios con discapacidades visuales.

## Privacidad y Cumplimiento GDPR

**¡Altbot 2.0 ahora procesa todo 100% localmente sin retener datos!** [![Seguir en Mastodon](https://img.shields.io/mastodon/follow/113183205946060973?domain=fuzzies.wtf&style=social)](https://fuzzies.wtf/@altbot)

En cumplimiento con el GDPR, Altbot requiere consentimiento informado explícito antes de procesar cualquier solicitud del usuario. Cuando interactúas con Altbot por primera vez, recibirás una solicitud de consentimiento con información sobre prácticas de recopilación de datos y un enlace a nuestra [Política de Privacidad](https://raw.githubusercontent.com/micr0-dev/Altbot/main/PRIVACY.md).

- **Qué recopilamos:** Marcas de tiempo de solicitudes, tiempos de procesamiento, preferencias de idioma, tipo de medio
- **Qué no recopilamos:** Imágenes, información personal, contenido de tus publicaciones
- **Cómo revocar el consentimiento:** Simplemente bloquea la cuenta del bot

El contenido de tus publicaciones nunca se guarda ni se comparte. Solo se procesan imágenes sin texto alternativo existente, y todo el procesamiento ocurre de forma privada en nuestro servidor local.

## Descargo de responsabilidad

Los textos alternativos se generan usando un Modelo de Lenguaje Grande (LLM). Aunque nos esforzamos por la precisión, los resultados pueden ser a veces incorrectos en cuanto a hechos. Siempre verifica el texto alternativo antes de usarlo.

## Cómo funciona

Altbot escucha menciones y seguimientos en Mastodon. Cuando detecta una mención o una nueva publicación de un usuario seguido, verifica si hay imágenes sin texto alternativo. Si encuentra alguna, utiliza un Modelo de Lenguaje Grande (LLM) para generar un texto descriptivo y responde con el texto generado.

### Características

- **Generación de texto alternativo basada en menciones:** Menciona a @Altbot en una respuesta a cualquier publicación que contenga una imagen, video o audio, y Altbot generará una descripción de texto alternativo para ella.
- **Texto alternativo automático para seguidores:** Sigue a @Altbot, y este supervisará tus publicaciones. Si publicas una imagen, video o audio sin texto alternativo, Altbot generará uno automáticamente para ti.
- **Soporte para LLM local:** Usa LLM locales a través de Ollama para generar descripciones de texto alternativo.
- **Cumplimiento con GDPR:** Sistema explícito de consentimiento informado que requiere que los usuarios den su consentimiento antes de procesar sus solicitudes, con información clara sobre el uso de datos.
- **Solicitudes de consentimiento:** Solicita el consentimiento del autor original antes de generar texto alternativo cuando se menciona por usuarios que no son el autor.
- **Configuración configurable:** Configura fácilmente el bot usando un archivo TOML.

## Configuración

### Estándar

1. Clona el repositorio:

   ```sh
   git clone https://github.com/micr0-dev/Altbot.git
   cd Altbot
   ```

2. Ejecute el asistente de configuración:

   ```sh
   go run .
   ```

   El asistente de configuración le guiará para configurar los valores esenciales requeridos para el bot, incluyendo:

   - La URL de su servidor Mastodon, el secreto del cliente, el token de acceso y el nombre de usuario del bot.
   - El identificador de contacto del administrador para notificaciones de moderación.
   - Habilitar funciones opcionales como métricas y recordatorios de texto alternativo.

   Alternativamente, copie el archivo de configuración de ejemplo y edítelo manualmente:

   ```sh
   cp example.config.toml config.toml
   ```
3. Ejecuta el bot:

   ```sh
   go run .
   ```

### Docker

1. Clona el repositorio:

   ```sh
   git clone https://github.com/micr0-dev/Altbot.git
   cd Altbot
   ```

2. Ejecutar el asistente de configuración:

   ```sh
   docker run -it -v ./:/data --rm ghcr.io/micr0-dev/altbot:latest
   ```

   El asistente de configuración le guiará para configurar los valores esenciales requeridos para el bot, incluyendo:

   - La URL de su servidor Mastodon, el secreto del cliente, el token de acceso y el nombre de usuario del bot.
   - El identificador de contacto del administrador para notificaciones de moderación.
   - Habilitar funciones opcionales como métricas y recordatorios de texto alternativo.

   Alternativamente, copie el archivo de configuración de ejemplo y edítelo manualmente:

   ```sh
   cp example.config.toml config.toml
   ```
3. Ejecuta el bot:

   ```sh
   docker compose up -d
   ```

## Configuración de Desarrollo

### Requisitos Previos

- **Go 1.24+**: Instalar desde [go.dev](https://go.dev/dl/)
- **Proveedor LLM** (uno de los siguientes):
  - **API Gemini**: Obtén una clave API en [Google AI Studio](https://aistudio.google.com/app/apikey)
  - **Ollama**: Instala desde [ollama.ai](https://ollama.ai/) y descarga un modelo de visión (p. ej., `ollama pull llava-phi3`)
  - **Transformers**: Requiere Python con la biblioteca transformers y una GPU compatible

### Para Comenzar

1. Clona el repositorio:

   ```sh
   git clone https://github.com/micr0-dev/Altbot.git
   cd Altbot
   ```

2. Instalar dependencias:

   ```sh
   go mod download
   ```

3. Copie y configure el archivo de configuración:

   ```sh
   cp example.config.toml config.toml
   # Edit config.toml with your LLM API and model of choice
   ```

4. Ejecuta el bot:
   ```sh
   go run .
   ```

### Modo de Desarrollo

Utilice la bandera `--dev` para ejecutar el bot en modo de desarrollo. Esto proporciona una interfaz interactiva de línea de comandos para pruebas sin publicar en Mastodon:

```sh
go run . --dev
```

**Nota:** El modo de desarrollo omite la autenticación de Mastodon, pero aún necesitas una API LLM válida (Gemini, Ollama, etc.) configurada en `config.toml` para probar el procesamiento de imágenes/videos/audio.

#### Comandos del modo de desarrollo

| Comando        | Descripción                                       |
| -------------- | ------------------------------------------------ |
| `/image <url>` | Procesa una URL de imagen y genera texto alternativo |
| `/video <url>` | Procesa una URL de video y genera texto alternativo  |
| `/audio <url>` | Procesa una URL de audio y genera texto alternativo  |
| `/lang [code]` | Establece/muestra el idioma para las respuestas (p.ej., en, de, ja) |
| `/follow`      | Simula un evento de seguimiento                   |
| `/status`      | Muestra el estado actual del modo de desarrollo   |
| `/help`        | Muestra los comandos disponibles                   |
| `/quit`        | Salir del modo de desarrollo                        |

También puedes pegar una URL directamente para procesarla como imagen.

**Ejemplo de sesión:**

```
[dev] > /lang de
Language set to: de

[dev] > https://example.com/image.jpg
Processing image: https://example.com/image.jpg
Please wait...

=== Generated Alt-Text ===
Ein Foto von...
```

### Construcción

```sh
go build -o altbot .
```

## Contribuir

¡Damos la bienvenida a las contribuciones! Por favor, abre un issue o envía un pull request con tus mejoras.

## Soporte / Comunidad

¿Preguntas? ¿Quieres charlar? Únete a nosotros en [chat.micr0.dev](https://chat.micr0.dev)

Canales: #dev para discusión del proyecto, #help para soporte

IRC: irc.micr0.dev (puertos 6667/6697)

## Gracias

### Agradecimientos Especiales

Quisiera expresar mi más profunda gratitud a **Henrik Schönemann** ([@Schoeneh](https://github.com/Schoeneh)) quien me motivó a lo largo de este viaje. Su ayuda para manejar la crítica y transformarla en retroalimentación constructiva ha sido invaluable. Realmente no estaría donde estoy hoy sin su apoyo y guía.

### Seguidores de Kofi

¡Un sincero agradecimiento a todos mis seguidores en [Ko-fi](https://ko-fi.com/)! Sus generosas contribuciones ayudan a mantener Altbot en funcionamiento y en mejora continua. Su apoyo significa mucho para mí y ayuda a hacer del Fediverso un lugar más accesible para todos.

## Licencia

Este proyecto está licenciado bajo la [LICENCIA PÚBLICA GENERAL GNU AFFERO Versión 3 (AGPLv3).](https://www.gnu.org/licenses/agpl-3.0.en.html) Consulta el archivo [LICENSE](LICENSE) para más detalles.

---

¡Únete a nosotros para hacer del Fediverso un lugar más inclusivo para todos!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-28

---
<div align="center">
  <img src="https://raw.githubusercontent.com/ai-shifu/ChatALL/main/src/assets/logo-cover.png" width=256></img>
  <p><strong>Chatea con TODOS los Bots de IA Concurrentemente, Descubre el Mejor</strong></p>

[Deutsch](README_DE-DE.md) | English | [Español](README_ES-ES.md) | [Français](README_FR-FR.md) | [Italian](README_IT-IT.md) | [日本語](README_JA-JP.md) | [한국어](README_KO-KR.md) | [Русский](README_RU-RU.md) | [Tiếng Việt](README_VI-VN.md) | [简体中文](README_ZH-CN.md)

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/ai-shifu/ChatALL)

</div>

## Capturas de pantalla

![Screenshot](https://raw.githubusercontent.com/ai-shifu/ChatALL/main/screenshots/screenshot-1.png?raw=true)

## Características

Los bots de IA basados en Modelos de Lenguaje Grandes (LLMs) son increíbles. Sin embargo, su comportamiento puede ser aleatorio y diferentes bots destacan en distintas tareas. Si quieres la mejor experiencia, no los pruebes uno por uno. ChatALL (nombre en chino: 齐叨) puede enviar un prompt a varios bots de IA de manera concurrente, ayudándote a descubrir los mejores resultados. Todo lo que necesitas hacer es [descargar, instalar](https://github.com/ai-shifu/ChatALL/releases) y preguntar.

### ¿Eres tú?

Los usuarios típicos de ChatALL son:

- 🤠**Expertos en LLMs**, que quieren encontrar las mejores respuestas o creaciones de los LLMs.
- 🤓**Investigadores de LLMs**, que desean comparar de forma intuitiva las fortalezas y debilidades de varios LLMs en diferentes campos.
- 😎**Desarrolladores de aplicaciones LLM**, que quieren depurar rápidamente los prompts y encontrar los modelos base de mejor rendimiento.

### Bots soportados

| Bots de IA                                                                       | Acceso Web  | API         | Notas                                       |
| ------------------------------------------------------------------------------- | ----------- | ----------- | ------------------------------------------- |
| [360 AI Brain](https://ai.360.cn/)                                              | Sí          | No API      |                                             |
| [Baidu ERNIE](https://yiyan.baidu.com/)                                         | No          | Sí          |                                             |
| [Character.AI](https://character.ai/)                                           | Sí          | No API      |                                             |
| [ChatGLM2 6B & 130B](https://chatglm.cn/)                                       | Sí          | No API      | No requiere inicio de sesión                |
| [ChatGPT](https://chatgpt.com)                                                  | Sí          | Sí          | Navegación web, incluye servicio Azure OpenAI |
| [Claude](https://www.anthropic.com/claude)                                      | Sí          | Sí          |                                             |
| [Code Llama](https://ai.meta.com/blog/code-llama-large-language-model-coding/)  | Sí          | No API      |                                             |
| [Cohere Aya 23](https://cohere.com/blog/aya23)                                  | No          | Sí          |                                             |
| [Cohere Command R Models](https://cohere.com/command)                           | No          | Sí          |                                             |
| [Copilot](https://copilot.microsoft.com/)                                       | Sí          | No API      |                                             |
| [Dedao Learning Assistant](https://ai.dedao.cn/)                                | Próximamente| No API      |                                             |
| [Falcon 180B](https://huggingface.co/tiiuae/falcon-180B-chat)                   | Sí          | No API      |                                             |
| [Gemini](https://gemini.google.com/)                                            | Sí          | Sí          |                                             |
| [Gemma 2B & 7B](https://blog.google/technology/developers/gemma-open-models/)   | Sí          | No API      |                                             |
| [Gradio](https://gradio.app/)                                                   | Sí          | No API      | Para modelos de Hugging Face space/self-hosted |
| [Groq Cloud](https://console.groq.com/docs/models)                              | No          | Sí          |                                             |
| [HuggingChat](https://huggingface.co/chat/)                                     | Sí          | No API      |                                             |
| [iFLYTEK SPARK](http://xinghuo.xfyun.cn/)                                       | Sí          | Próximamente|                                             |
| [Kimi](https://kimi.moonshot.cn/               )                                | Sí          | No API      |                                             |
| [Llama 2 13B & 70B](https://ai.meta.com/llama/)                                 | Sí          | No API      |                                             |
| [MOSS](https://moss.fastnlp.top/)                                               | Sí          | No API      |                                             |
| [Perplexity](https://www.perplexity.ai/)                                        | Sí          | No API      |                                             |
| [Phind](https://www.phind.com/)                                                 | Sí          | No API      |                                             |
| [Pi](https://pi.ai)                                                             | Sí          | No API      |                                             |
| [Poe](https://poe.com/)                                                         | Sí          | Próximamente|                                             |
| [SkyWork](https://neice.tiangong.cn/)                                           | Sí          | Próximamente|                                             |
| [Tongyi Qianwen](http://tongyi.aliyun.com/)                                     | Sí          | Próximamente|                                             |
| [Vicuna 13B & 33B](https://lmsys.org/blog/2023-03-30-vicuna/)                   | Sí          | No API      | No requiere inicio de sesión                |
| [WizardLM 70B](https://github.com/nlpxucan/WizardLM)                            | Sí          | No API      |                                             |
| [xAI Grok](https://x.ai)                                                        | No          | Sí          |                                             |
| [YouChat](https://you.com/)                                                     | Sí          | No API      |                                             |
| [You](https://you.com/)                                                         | Sí          | No API      |                                             |
| [Zephyr](https://huggingface.co/spaces/HuggingFaceH4/zephyr-chat)               | Sí          | No API      |                                             |

Más están por venir. Vota por tus bots favoritos en [estos temas](https://github.com/ai-shifu/ChatALL/labels/more%20LLMs).

### Nota sobre la Fiabilidad de los Bots Conectados a la Web

Los bots de IA conectados a la web (los que tienen "Acceso Web") son inherentemente menos fiables y a menudo enfrentan problemas de estabilidad, ya que los proveedores de servicios actualizan regularmente sus interfaces web y medidas de seguridad. Estas conexiones web se basan en ingeniería inversa y son difíciles de mantener, rompiéndose a menudo de forma inesperada. Para una experiencia confiable, recomendamos encarecidamente usar bots que ofrezcan acceso por API siempre que sea posible.

### Otras características

- Modo de prompt rápido: envía el siguiente prompt sin esperar a que se complete la solicitud anterior
- Guarda el historial de chat localmente, protege tu privacidad
- Destaca la respuesta que te gusta, elimina las malas
- Habilita/deshabilita cualquier bot en cualquier momento
- Cambia entre vista de una, dos o tres columnas
- Actualización automática a la última versión
- Modo oscuro (aportado por @tanchekwei)
- Atajos de teclado. Pulsa <kbd>Ctrl</kbd> + <kbd>/</kbd> para ver todos (aportado por @tanchekwei)
- Chats múltiples (aportado por @tanchekwei)
- Configuración de proxy (aportado por @msaong)
- Gestión de prompts (aportado por @tanchekwei)
- Soporta varios idiomas (chino, inglés, alemán, francés, ruso, vietnamita, coreano, japonés, español, italiano)
- Compatible con Windows, macOS y Linux

Características planificadas:

Eres bienvenido a contribuir en estas características.

- [ ] Desplegar front-end en GitHub Pages

## Privacidad

Todo el historial de chat, configuraciones y datos de inicio de sesión se guardan localmente en tu ordenador.

ChatALL recopila datos de uso anónimos para ayudarnos a mejorar el producto. Incluyendo:

- Qué bots de IA reciben prompts y cuánto mide el prompt. No incluye el contenido del prompt.
- Cuánto mide la respuesta, y qué respuesta se elimina/destaca. No incluye el contenido de la respuesta.

## Requisitos previos

ChatALL es un cliente, no un proxy. Por lo tanto, debes:

1. Tener cuentas funcionales y/o tokens de API para los bots.
2. Tener conexiones de red fiables con los bots.

## Descargar / Instalar

Descarga desde https://github.com/ai-shifu/ChatALL/releases

### En Windows

Simplemente descarga el archivo \*-win.exe y procede con la instalación.

### En macOS

Para Mac Apple Silicon (CPU M1, M2), descarga el archivo \*-mac-arm64.dmg.

Para otros Macs, descarga el archivo \*-mac-x64.dmg.

Si usas [Homebrew](https://brew.sh/), también puedes instalarlo con:

```bash
brew install --cask chatall
```

### En Linux

Distribuciones basadas en Debian: Descarga el archivo .deb, haz doble clic y instala el software.
Distribuciones basadas en Arch: Puedes clonar ChatALL desde el AUR [aquí](https://aur.archlinux.org/packages/chatall-bin). Puedes instalarlo manualmente o usando un ayudante AUR como yay o paru.
Otras distribuciones: Descarga el archivo .AppImage, hazlo ejecutable y disfruta la experiencia de ejecución con un clic. También puedes usar [AppimageLauncher](https://github.com/TheAssassin/AppImageLauncher).

## Solución de problemas

Si encuentras algún problema al usar ChatALL, puedes probar los siguientes métodos para resolverlo:

1. **Actualizar** - presiona <kbd>Ctrl</kbd> + <kbd>R</kbd> o <kbd>⌘</kbd> + <kbd>R</kbd>.
2. **Reiniciar** - cierra ChatALL y ejecútalo de nuevo.
3. **Volver a iniciar sesión** - haz clic en el botón de configuración en la esquina superior derecha, luego haz clic en el enlace de inicio/cierre de sesión correspondiente para volver a iniciar sesión en el sitio web.
4. **Crear un nuevo chat** - haz clic en el botón `Nuevo Chat` y envía el prompt de nuevo.

Si ninguno de los métodos anteriores funciona, puedes intentar **restablecer ChatALL**. Ten en cuenta que esto eliminará todas tus configuraciones e historial de mensajes.

Puedes restablecer ChatALL eliminando los siguientes directorios:

- Windows: `C:\Users\<usuario>\AppData\Roaming\chatall\`
- Linux: `/home/<usuario>/.config/chatall/`
- macOS: `/Users/<usuario>/Library/Application Support/chatall/`

Si el problema persiste, por favor [abre un issue](https://github.com/ai-shifu/ChatALL/issues).

## Para desarrolladores

### Contribuir un Bot

[La guía](https://github.com/ai-shifu/ChatALL/wiki/%E5%A6%82%E4%BD%95%E6%B7%BB%E5%8A%A0%E4%B8%80%E4%B8%AA%E6%96%B0%E7%9A%84-AI-%E5%AF%B9%E8%AF%9D%E6%9C%BA%E5%99%A8%E4%BA%BA) puede ayudarte.

### Ejecutar

```bash
npm install
npm run electron:serve
```

### Compilar

Compilar para tu plataforma actual:

```bash
npm run electron:build
```

Compilar para todas las plataformas:

```bash
npm run electron:build -- -wml --x64 --arm64
```

## Créditos

### Colaboradores

<a href="https://github.com/ai-shifu/ChatALL/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=ai-shifu/ChatALL" />
</a>

### Otros

- GPT-4 contribuyó con gran parte del código
- ChatGPT, Copilot y Google proporcionan muchas soluciones (por orden de importancia)
- Inspirado por [ChatHub](https://github.com/chathub-dev/chathub). ¡Respeto!

## Patrocina

Si te gusta este proyecto, considera:

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/F1F8KZJGJ)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-22

---
# Open WebUI 👋

![Estrellas de GitHub](https://img.shields.io/github/stars/open-webui/open-webui?style=social)
![Forks de GitHub](https://img.shields.io/github/forks/open-webui/open-webui?style=social)
![Watchers de GitHub](https://img.shields.io/github/watchers/open-webui/open-webui?style=social)
![Tamaño del repositorio en GitHub](https://img.shields.io/github/repo-size/open-webui/open-webui)
![Cantidad de lenguajes en GitHub](https://img.shields.io/github/languages/count/open-webui/open-webui)
![Lenguaje principal en GitHub](https://img.shields.io/github/languages/top/open-webui/open-webui)
![Último commit en GitHub](https://img.shields.io/github/last-commit/open-webui/open-webui?color=red)
[![Discord](https://img.shields.io/badge/Discord-Open_WebUI-blue?logo=discord&logoColor=white)](https://discord.gg/5rJgQTnV4s)
[![](https://img.shields.io/static/v1?label=Sponsor&message=%E2%9D%A4&logo=GitHub&color=%23fe8e86)](https://github.com/sponsors/tjbck)

**Open WebUI es una plataforma de IA autoalojada, [extensible](https://docs.openwebui.com/features/plugin/), rica en funcionalidades y fácil de usar, diseñada para operar completamente sin conexión.** Soporta varios motores LLM como **Ollama** y **APIs compatibles con OpenAI**, con un **motor de inferencia integrado** para RAG, lo que lo convierte en una **potente solución de despliegue de IA**.

![Demostración de Open WebUI](./demo.gif)

> [!TIP]  
> **¿Buscas un [Plan Empresarial](https://docs.openwebui.com/enterprise)?** – **[¡Habla hoy mismo con nuestro equipo de ventas!](mailto:sales@openwebui.com)**
>
> Obtén **capacidades mejoradas**, incluyendo **personalización de temas y branding**, **soporte SLA (Acuerdo de Nivel de Servicio)**, **versiones con soporte a largo plazo (LTS)**, ¡y mucho más!

Para más información, asegúrate de consultar nuestra [Documentación de Open WebUI](https://docs.openwebui.com/).

## Funcionalidades Clave de Open WebUI ⭐

- 🚀 **Instalación sin esfuerzo**: Instala fácilmente usando Docker o Kubernetes (kubectl, kustomize o helm) para una experiencia libre de complicaciones, con soporte para imágenes etiquetadas `:ollama` y `:cuda`.

- 🤝 **Integración API Ollama/OpenAI**: Integra de manera sencilla APIs compatibles con OpenAI para conversaciones versátiles junto con modelos Ollama. Personaliza la URL de la API de OpenAI para enlazar con **LMStudio, GroqCloud, Mistral, OpenRouter y más**.

- 🛡️ **Permisos Granulares y Grupos de Usuarios**: Permite a los administradores crear roles y permisos detallados, asegurando un entorno seguro. Esta granularidad no solo mejora la seguridad, sino que también permite experiencias personalizadas y fomenta el sentido de pertenencia y responsabilidad entre los usuarios.

- 📱 **Diseño Responsivo**: Disfruta de una experiencia fluida en PC de escritorio, portátil y dispositivos móviles.

- 📱 **Aplicación Web Progresiva (PWA) para Móvil**: Disfruta de una experiencia similar a una app nativa en tu dispositivo móvil con nuestra PWA, que permite acceso offline en localhost y una interfaz de usuario fluida.

- ✒️🔢 **Soporte completo de Markdown y LaTeX**: Eleva tu experiencia LLM con capacidades completas de Markdown y LaTeX para una interacción enriquecida.

- 🎤📹 **Llamadas de Voz/Video Manos Libres**: Experimenta comunicación fluida con funciones integradas de llamadas de voz y video manos libres, permitiendo un entorno de chat más dinámico e interactivo.

- 🛠️ **Constructor de Modelos**: Crea fácilmente modelos Ollama a través de la interfaz web. Crea y añade personajes/agentes personalizados, personaliza elementos del chat e importa modelos fácilmente mediante la integración con la [Comunidad Open WebUI](https://openwebui.com/).

- 🐍 **Herramienta Nativa de Llamada de Funciones Python**: Mejora tus LLMs con soporte de editor de código en el área de herramientas. Trae tus propias funciones (BYOF) simplemente agregando funciones Python puras, permitiendo integración fluida con LLMs.

- 📚 **Integración RAG Local**: Sumérgete en el futuro de las interacciones de chat con el revolucionario soporte de Retrieval Augmented Generation (RAG). Esta función integra sin problemas la interacción con documentos en tu chat. Puedes cargar documentos directamente al chat o añadir archivos a tu biblioteca, accediendo fácilmente a ellos usando el comando `#` antes de una consulta.

- 🔍 **Búsqueda Web para RAG**: Realiza búsquedas web usando proveedores como `SearXNG`, `Google PSE`, `Brave Search`, `serpstack`, `serper`, `Serply`, `DuckDuckGo`, `TavilySearch`, `SearchApi` y `Bing` e inyecta los resultados directamente en tu experiencia de chat.

- 🌐 **Capacidad de Navegación Web**: Integra sitios web en tu chat usando el comando `#` seguido de una URL. Esta función permite incorporar contenido web directamente en tus conversaciones, enriqueciendo la interacción.

- 🎨 **Integración de Generación de Imágenes**: Incorpora capacidades de generación de imágenes utilizando opciones como la API AUTOMATIC1111 o ComfyUI (local), y DALL-E de OpenAI (externo), enriqueciendo tu chat con contenido visual dinámico.

- ⚙️ **Conversaciones con Múltiples Modelos**: Interactúa fácilmente con varios modelos simultáneamente, aprovechando sus puntos fuertes para respuestas óptimas. Mejora tu experiencia utilizando una variedad de modelos en paralelo.

- 🔐 **Control de Acceso Basado en Roles (RBAC)**: Garantiza acceso seguro con permisos restringidos; solo personas autorizadas pueden acceder a tu Ollama y los derechos exclusivos de creación/descarga de modelos están reservados para administradores.

- 🌐🌍 **Soporte Multilingüe**: Experimenta Open WebUI en tu idioma preferido con soporte de internacionalización (i18n). ¡Únete a expandir los idiomas soportados! ¡Buscamos activamente colaboradores!

- 🧩 **Pipelines y Soporte para Plugins de Open WebUI**: Integra lógica personalizada y librerías Python en Open WebUI usando el [Framework de Plugins Pipelines](https://github.com/open-webui/pipelines). Lanza tu instancia de Pipelines, configura la URL de OpenAI a la de Pipelines y explora posibilidades infinitas. [Ejemplos](https://github.com/open-webui/pipelines/tree/main/examples) incluyen **Llamada de Funciones**, **Límites de Usuario** para controlar acceso, **Monitoreo de Uso** con herramientas como Langfuse, **Traducción en Vivo con LibreTranslate** para soporte multilingüe, **Filtrado de Mensajes Tóxicos** y mucho más.

- 🌟 **Actualizaciones Continuas**: Estamos comprometidos a mejorar Open WebUI con actualizaciones, correcciones y nuevas funciones de manera regular.

¿Quieres saber más sobre las funciones de Open WebUI? Consulta nuestra [documentación](https://docs.openwebui.com/features) para una visión completa.

## Patrocinadores 🙌

#### Esmeralda

<table>
  <tr>
    <td>
      <a href="https://n8n.io/" target="_blank">
        <img src="https://docs.openwebui.com/sponsors/logos/n8n.png" alt="n8n" style="width: 8rem; height: 8rem; border-radius: .75rem;" />
      </a>
    </td>
    <td>
      N8N • ¿Tu interfaz ya tiene backend?<br>Prueba <a href="https://n8n.io/">n8n</a>
    </td>
  </tr>
  <tr>
    <td>
      <a href="https://warp.dev/open-webui" target="_blank">
        <img src="https://docs.openwebui.com/sponsors/logos/warp.png" alt="n8n" style="width: 8rem; height: 8rem; border-radius: .75rem;" />
      </a>
    </td>
    <td>
      <a href="https://warp.dev/open-webui">Warp</a> • La terminal inteligente para desarrolladores
    </td>
  </tr>
</table>

---

Estamos increíblemente agradecidos por el generoso apoyo de nuestros patrocinadores. Sus contribuciones nos ayudan a mantener y mejorar nuestro proyecto, asegurando que podamos seguir ofreciendo trabajo de calidad a nuestra comunidad. ¡Gracias!

## Cómo Instalar 🚀

### Instalación vía Python pip 🐍

Open WebUI puede instalarse usando pip, el instalador de paquetes de Python. Antes de proceder, asegúrate de estar usando **Python 3.11** para evitar problemas de compatibilidad.

1. **Instala Open WebUI**:
   Abre tu terminal y ejecuta el siguiente comando para instalar Open WebUI:

   ```bash
   pip install open-webui
   ```

2. **Ejecutar Open WebUI**:
   Después de la instalación, puedes iniciar Open WebUI ejecutando:

   ```bash
   open-webui serve
   ```

Esto iniciará el servidor de Open WebUI, al que puedes acceder en [http://localhost:8080](http://localhost:8080)

### Inicio Rápido con Docker 🐳

> [!NOTE]  
> Ten en cuenta que en ciertos entornos Docker pueden requerirse configuraciones adicionales. Si experimentas problemas de conexión, nuestra guía detallada en la [Documentación de Open WebUI](https://docs.openwebui.com/) está lista para ayudarte.

> [!WARNING]
> Al usar Docker para instalar Open WebUI, asegúrate de incluir `-v open-webui:/app/backend/data` en tu comando de Docker. Este paso es crucial para que tu base de datos se monte correctamente y evitar la pérdida de datos.

> [!TIP]  
> Si deseas utilizar Open WebUI con Ollama incluido o aceleración CUDA, recomendamos usar nuestras imágenes oficiales etiquetadas con `:cuda` o `:ollama`. Para habilitar CUDA, debes instalar el [Nvidia CUDA container toolkit](https://docs.nvidia.com/dgx/nvidia-container-runtime-upgrade/) en tu sistema Linux/WSL.

### Instalación con Configuración Predeterminada

- **Si Ollama está en tu computadora**, usa este comando:

  ```bash
  docker run -d -p 3000:8080 --add-host=host.docker.internal:host-gateway -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

- **Si Ollama está en otro servidor**, usa este comando:

  Para conectar a Ollama en otro servidor, cambia el `OLLAMA_BASE_URL` por la URL del servidor:

  ```bash
  docker run -d -p 3000:8080 -e OLLAMA_BASE_URL=https://example.com -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

- **Para ejecutar Open WebUI con soporte Nvidia GPU**, usa este comando:

  ```bash
  docker run -d -p 3000:8080 --gpus all --add-host=host.docker.internal:host-gateway -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:cuda
  ```

### Instalación para Uso Solo con OpenAI API

- **Si solo vas a usar la API de OpenAI**, usa este comando:

  ```bash
  docker run -d -p 3000:8080 -e OPENAI_API_KEY=your_secret_key -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

### Instalación de Open WebUI con Soporte Ollama Integrado

Este método usa una sola imagen de contenedor que integra Open WebUI con Ollama, permitiendo una configuración sencilla en un solo comando. Elige el comando adecuado según tu hardware:

- **Con Soporte GPU**:
  Utiliza recursos de GPU ejecutando el siguiente comando:

  ```bash
  docker run -d -p 3000:8080 --gpus=all -v ollama:/root/.ollama -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:ollama
  ```

- **Solo CPU**:
  Si no usas GPU, usa este comando:

  ```bash
  docker run -d -p 3000:8080 -v ollama:/root/.ollama -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:ollama
  ```

Ambos comandos facilitan una instalación integrada y sin complicaciones tanto de Open WebUI como de Ollama, asegurando que puedas poner todo en marcha rápidamente.

Tras la instalación, puedes acceder a Open WebUI en [http://localhost:3000](http://localhost:3000). ¡Disfrútalo! 😄

### Otros Métodos de Instalación

Ofrecemos varias alternativas de instalación, incluyendo métodos nativos sin Docker, Docker Compose, Kustomize y Helm. Visita nuestra [Documentación de Open WebUI](https://docs.openwebui.com/getting-started/) o únete a nuestra [comunidad en Discord](https://discord.gg/5rJgQTnV4s) para una guía completa.

### Solución de Problemas

¿Tienes problemas de conexión? Nuestra [Documentación de Open WebUI](https://docs.openwebui.com/troubleshooting/) te puede ayudar. Para más asistencia y para unirte a nuestra comunidad, visita el [Discord de Open WebUI](https://discord.gg/5rJgQTnV4s).

#### Open WebUI: Error de Conexión al Servidor

Si experimentas problemas de conexión, a menudo es porque el contenedor Docker de WebUI no puede alcanzar el servidor Ollama en 127.0.0.1:11434 (host.docker.internal:11434) dentro del contenedor. Usa el flag `--network=host` en tu comando Docker para resolverlo. Nota que el puerto cambia de 3000 a 8080, resultando en el enlace: `http://localhost:8080`.

**Ejemplo de Comando Docker**:

```bash
docker run -d --network=host -v open-webui:/app/backend/data -e OLLAMA_BASE_URL=http://127.0.0.1:11434 --name open-webui --restart always ghcr.io/open-webui/open-webui:main
```

### Manteniendo Tu Instalación Docker Actualizada

Si deseas actualizar tu instalación local de Docker a la última versión, puedes hacerlo con [Watchtower](https://containrrr.dev/watchtower/):

```bash
docker run --rm --volume /var/run/docker.sock:/var/run/docker.sock containrrr/watchtower --run-once open-webui
```

En la última parte del comando, reemplaza `open-webui` por el nombre de tu contenedor si es diferente.

Consulta nuestra guía de actualización disponible en la [Documentación de Open WebUI](https://docs.openwebui.com/getting-started/updating).

### Usando la Rama Dev 🌙

> [!WARNING]
> La rama `:dev` contiene las funciones y cambios más recientes e inestables. Úsala bajo tu propio riesgo, ya que puede tener errores o funciones incompletas.

Si quieres probar las funciones más novedosas y no te importa cierta inestabilidad, puedes usar la etiqueta `:dev` así:

```bash
docker run -d -p 3000:8080 -v open-webui:/app/backend/data --name open-webui --add-host=host.docker.internal:host-gateway --restart always ghcr.io/open-webui/open-webui:dev
```

### Modo Offline

Si ejecutas Open WebUI en un entorno sin conexión, puedes establecer la variable de entorno `HF_HUB_OFFLINE` en `1` para evitar intentos de descarga de modelos de internet.

```bash
export HF_HUB_OFFLINE=1
```

## ¿Qué sigue? 🌟

Descubre las próximas funciones en nuestra hoja de ruta en la [Documentación de Open WebUI](https://docs.openwebui.com/roadmap/).

## Licencia 📜

Este proyecto está licenciado bajo la [Licencia Open WebUI](LICENSE), una licencia BSD-3-Clause revisada. Recibes los mismos derechos que la clásica licencia BSD-3: puedes usar, modificar y distribuir el software, incluso en productos propietarios y comerciales, con mínimas restricciones. El único requisito adicional es preservar el branding "Open WebUI", tal como se detalla en el archivo LICENSE. Para los términos completos, consulta el documento [LICENSE](LICENSE). 📄

## Soporte 💬

Si tienes preguntas, sugerencias o necesitas ayuda, abre un issue o únete a nuestra
[comunidad de Open WebUI en Discord](https://discord.gg/5rJgQTnV4s) para conectar con nosotros. 🤝

## Historial de Estrellas

<a href="https://star-history.com/#open-webui/open-webui&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date" />
    <img alt="Gráfico de Historial de Estrellas" src="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date" />
  </picture>
</a>

---

Creado por [Timothy Jaeryang Baek](https://github.com/tjbck) - ¡Hagamos Open WebUI aún más increíble juntos! 💪

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---
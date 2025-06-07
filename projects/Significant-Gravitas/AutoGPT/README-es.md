# AutoGPT: Construye, Despliega y Ejecuta Agentes de IA

[![Discord Follow](https://dcbadge.vercel.app/api/server/autogpt?style=flat)](https://discord.gg/autogpt) &ensp;
[![Twitter Follow](https://img.shields.io/twitter/follow/Auto_GPT?style=social)](https://twitter.com/Auto_GPT) &ensp;
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

**AutoGPT** es una plataforma poderosa que te permite crear, desplegar y gestionar agentes de IA continuos que automatizan flujos de trabajo complejos.

## Opciones de Alojamiento
   - Descarga para alojar en tu propio servidor
   - [Únete a la lista de espera](https://bit.ly/3ZDijAI) para la beta en la nube

## Cómo Configurar para Autoalojamiento
> [!NOTE]
> Configurar y alojar la Plataforma AutoGPT por tu cuenta es un proceso técnico.
> Si prefieres algo que simplemente funcione, te recomendamos [unirte a la lista de espera](https://bit.ly/3ZDijAI) para la beta en la nube.

### Requisitos del Sistema

Antes de proceder con la instalación, asegúrate de que tu sistema cumpla con los siguientes requisitos:

#### Requisitos de Hardware
- CPU: Se recomiendan 4+ núcleos
- RAM: Mínimo 8GB, se recomiendan 16GB
- Almacenamiento: Al menos 10GB de espacio libre

#### Requisitos de Software
- Sistemas Operativos:
  - Linux (se recomienda Ubuntu 20.04 o superior)
  - macOS (10.15 o superior)
  - Windows 10/11 con WSL2
- Software requerido (con versiones mínimas):
  - Docker Engine (20.10.0 o superior)
  - Docker Compose (2.0.0 o superior)
  - Git (2.30 o superior)
  - Node.js (16.x o superior)
  - npm (8.x o superior)
  - VSCode (1.60 o superior) o cualquier editor de código moderno

#### Requisitos de Red
- Conexión a internet estable
- Acceso a los puertos requeridos (se configurarán en Docker)
- Capacidad para realizar conexiones HTTPS salientes

### Instrucciones Actualizadas de Configuración:
Ahora contamos con un sitio de documentación completamente mantenido y actualizado regularmente.

👉 [Sigue la guía oficial de autoalojamiento aquí](https://docs.agpt.co/platform/getting-started/)

Este tutorial asume que tienes Docker, VSCode, git y npm instalados.

### 🧱 AutoGPT Frontend

El frontend de AutoGPT es donde los usuarios interactúan con nuestra poderosa plataforma de automatización de IA. Ofrece múltiples formas de interactuar y aprovechar nuestros agentes de IA. Esta es la interfaz donde darás vida a tus ideas de automatización con IA:

   **Constructor de Agentes:** Para quienes quieren personalizar, nuestra interfaz intuitiva y de bajo código te permite diseñar y configurar tus propios agentes de IA.
   
   **Gestión de Flujos de Trabajo:** Construye, modifica y optimiza tus flujos de automatización fácilmente. Creas tu agente conectando bloques, donde cada bloque realiza una acción individual.
   
   **Controles de Despliegue:** Gestiona el ciclo de vida de tus agentes, desde pruebas hasta producción.
   
   **Agentes Listos para Usar:** ¿No quieres construir? Simplemente selecciona de nuestra biblioteca de agentes preconfigurados y ponlos a trabajar de inmediato.
   
   **Interacción con Agentes:** Ya sea que hayas construido el tuyo o estés usando agentes preconfigurados, ejecútalos e interactúa con ellos fácilmente a través de nuestra interfaz amigable.
   
   **Monitoreo y Analítica:** Haz seguimiento del rendimiento de tus agentes y obtén insights para mejorar continuamente tus procesos de automatización.

[Lee esta guía](https://docs.agpt.co/platform/new_blocks/) para aprender cómo construir tus propios bloques personalizados.

### 💽 AutoGPT Server

El Servidor AutoGPT es la potencia de nuestra plataforma. Aquí es donde se ejecutan tus agentes. Una vez desplegados, los agentes pueden ser activados por fuentes externas y pueden operar de manera continua. Contiene todos los componentes esenciales que hacen que AutoGPT funcione sin problemas.

   **Código Fuente:** La lógica central que impulsa nuestros agentes y procesos de automatización.
   
   **Infraestructura:** Sistemas robustos que garantizan un rendimiento fiable y escalable.
   
   **Marketplace:** Un mercado integral donde puedes encontrar y desplegar una amplia variedad de agentes preconstruidos.

### 🐙 Agentes de Ejemplo

Aquí tienes dos ejemplos de lo que puedes hacer con AutoGPT:

1. **Generar Videos Virales de Temas en Tendencia**
   - Este agente lee temas en Reddit.
   - Identifica temas en tendencia.
   - Luego, crea automáticamente un video corto basado en el contenido.

2. **Identificar las Mejores Frases de Videos para Redes Sociales**
   - Este agente se suscribe a tu canal de YouTube.
   - Cuando subes un nuevo video, lo transcribe.
   - Usa IA para identificar las frases más impactantes y generar un resumen.
   - Luego, escribe una publicación para publicarla automáticamente en tus redes sociales.

¡Estos ejemplos muestran solo una pequeña parte de lo que puedes lograr con AutoGPT! Puedes crear flujos de trabajo personalizados para construir agentes para cualquier caso de uso.

---
### Misión y Licencias
Nuestra misión es proporcionar las herramientas para que puedas centrarte en lo que importa:

- 🏗️ **Construir** - Sienta las bases para algo increíble.
- 🧪 **Probar** - Ajusta tu agente hasta la perfección.
- 🤝 **Delegar** - Deja que la IA trabaje por ti y haz realidad tus ideas.

¡Sé parte de la revolución! **AutoGPT** está aquí para quedarse, a la vanguardia de la innovación en IA.

**📖 [Documentación](https://docs.agpt.co)**
&ensp;|&ensp;
**🚀 [Contribuir](CONTRIBUTING.md)**

**Licencias:**

Licencia MIT: La mayoría del repositorio de AutoGPT está bajo la Licencia MIT.

Licencia Polyform Shield: Esta licencia aplica a la carpeta autogpt_platform.

Para más información, visita https://agpt.co/blog/introducing-the-autogpt-platform

---
## 🤖 AutoGPT Classic
> A continuación encontrarás información sobre la versión clásica de AutoGPT.

**🛠️ [Construye tu propio Agente - Inicio Rápido](classic/FORGE-QUICKSTART.md)**

### 🏗️ Forge

¡Forja tu propio agente! &ndash; Forge es un kit listo para usar para construir tu propia aplicación de agente. Maneja la mayor parte del código base, permitiéndote canalizar toda tu creatividad en aquello que hace *único* a tu agente. Todos los tutoriales están ubicados [aquí](https://medium.com/@aiedge/autogpt-forge-e3de53cc58ec). Los componentes de [`forge`](/classic/forge/) también se pueden utilizar individualmente para acelerar el desarrollo y reducir el código base en tu proyecto de agente.

🚀 [**Comenzando con Forge**](https://github.com/Significant-Gravitas/AutoGPT/blob/master/classic/forge/tutorials/001_getting_started.md) &ndash;
Esta guía te llevará por el proceso de crear tu propio agente y usar el benchmark y la interfaz de usuario.

📘 [Más información](https://github.com/Significant-Gravitas/AutoGPT/tree/master/classic/forge) sobre Forge

### 🎯 Benchmark

¡Mide el rendimiento de tu agente! El `agbenchmark` se puede usar con cualquier agente que soporte el protocolo de agente, y la integración con el [CLI] del proyecto lo hace aún más fácil de usar con AutoGPT y agentes basados en forge. El benchmark ofrece un entorno de pruebas riguroso. Nuestro framework permite evaluaciones autónomas y objetivas del rendimiento, asegurando que tus agentes estén listos para la acción en el mundo real.

<!-- TODO: insertar visual que demuestre el benchmark -->

📦 [`agbenchmark`](https://pypi.org/project/agbenchmark/) en Pypi
&ensp;|&ensp;
📘 [Más información](https://github.com/Significant-Gravitas/AutoGPT/tree/master/classic/benchmark) sobre el Benchmark

### 💻 UI

¡Hace que los agentes sean fáciles de usar! El `frontend` te ofrece una interfaz amigable para controlar y monitorear tus agentes. Se conecta con los agentes a través del [protocolo de agente](#-agent-protocol), asegurando compatibilidad con muchos agentes tanto dentro como fuera de nuestro ecosistema.

<!-- TODO: insertar captura de pantalla del front end -->

El frontend funciona directamente con todos los agentes del repositorio. ¡Simplemente usa el [CLI] para ejecutar el agente de tu elección!

📘 [Más información](https://github.com/Significant-Gravitas/AutoGPT/tree/master/classic/frontend) sobre el Frontend

### ⌨️ CLI

[CLI]: #-cli

Para que sea lo más fácil posible usar todas las herramientas ofrecidas por el repositorio, se incluye un CLI en la raíz del repositorio:

```shell
$ ./run
Usage: cli.py [OPTIONS] COMMAND [ARGS]...

Options:
  --help  Show this message and exit.

Commands:
  agent      Commands to create, start and stop agents
  benchmark  Commands to start the benchmark and list tests and categories
  setup      Installs dependencies needed for your system.
```

¡Solo clona el repositorio, instala las dependencias con `./run setup`, y estarás listo para comenzar!

## 🤔 ¿Preguntas? ¿Problemas? ¿Sugerencias?

### Obtén ayuda - [Discord 💬](https://discord.gg/autogpt)

[![Únete a nosotros en Discord](https://invidget.switchblade.xyz/autogpt)](https://discord.gg/autogpt)

Para reportar un error o solicitar una funcionalidad, crea un [Issue en GitHub](https://github.com/Significant-Gravitas/AutoGPT/issues/new/choose). Por favor, asegúrate de que alguien más no haya creado un issue sobre el mismo tema.

## 🤝 Proyectos Hermanos

### 🔄 Protocolo de Agente

Para mantener un estándar uniforme y garantizar la compatibilidad perfecta con muchas aplicaciones actuales y futuras, AutoGPT emplea el estándar [agent protocol](https://agentprotocol.ai/) de la AI Engineer Foundation. Esto estandariza las vías de comunicación desde tu agente hasta el frontend y el benchmark.

---

## Stars stats

<p align="center">
<a href="https://star-history.com/#Significant-Gravitas/AutoGPT">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=Significant-Gravitas/AutoGPT&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=Significant-Gravitas/AutoGPT&type=Date" />
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=Significant-Gravitas/AutoGPT&type=Date" />
  </picture>
</a>
</p>

## ⚡ Contribuidores

<a href="https://github.com/Significant-Gravitas/AutoGPT/graphs/contributors" alt="View Contributors">
  <img src="https://contrib.rocks/image?repo=Significant-Gravitas/AutoGPT&max=1000&columns=10" alt="Contributors" />
</a>


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---
# Prompt flow

[![Paquete de Python](https://img.shields.io/pypi/v/promptflow)](https://pypi.org/project/promptflow/)
[![Python](https://img.shields.io/pypi/pyversions/promptflow.svg?maxAge=2592000)](https://pypi.python.org/pypi/promptflow/)
[![PyPI - Descargas](https://img.shields.io/pypi/dm/promptflow)](https://pypi.org/project/promptflow/)
[![CLI](https://img.shields.io/badge/CLI-reference-blue)](https://microsoft.github.io/promptflow/reference/pf-command-reference.html)
[![Extensión VSC](https://img.shields.io/visual-studio-marketplace/i/prompt-flow.prompt-flow?logo=Visual%20Studio&label=Extension%20)](https://marketplace.visualstudio.com/items?itemName=prompt-flow.prompt-flow)

[![Doc](https://img.shields.io/badge/Doc-online-green)](https://microsoft.github.io/promptflow/index.html)
[![Issue](https://img.shields.io/github/issues/microsoft/promptflow)](https://github.com/microsoft/promptflow/issues/new/choose)
[![Discusiones](https://img.shields.io/github/discussions/microsoft/promptflow)](https://github.com/microsoft/promptflow/issues/new/choose)
[![CONTRIBUCIÓN](https://img.shields.io/badge/Contributing-8A2BE2)](https://github.com/microsoft/promptflow/blob/main/CONTRIBUTING.md)
[![Licencia: MIT](https://img.shields.io/github/license/microsoft/promptflow)](https://github.com/microsoft/promptflow/blob/main/LICENSE)

> Te invitamos a unirte para mejorar prompt flow
> participando en las [discusiones](https://github.com/microsoft/promptflow/discussions),
> abriendo [issues](https://github.com/microsoft/promptflow/issues/new/choose),
> o enviando [PRs](https://github.com/microsoft/promptflow/pulls).

**Prompt flow** es un conjunto de herramientas de desarrollo diseñado para optimizar el ciclo de desarrollo de aplicaciones de IA basadas en LLM, desde la ideación, el prototipado, pruebas, evaluación hasta el despliegue y monitoreo en producción. Facilita la ingeniería de prompts y permite crear aplicaciones LLM con calidad de producción.

Con prompt flow, podrás:

- **Crear y desarrollar flujos iterativamente**
    - Crear [flujos](https://microsoft.github.io/promptflow/concepts/concept-flows.html) ejecutables que enlazan LLMs, prompts, código Python y otras [herramientas](https://microsoft.github.io/promptflow/concepts/concept-tools.html).
    - Depurar e iterar tus flujos, especialmente [trazando la interacción con LLMs](https://microsoft.github.io/promptflow/how-to-guides/tracing/index.html) fácilmente.
- **Evaluar la calidad y el rendimiento del flujo**
    - Evaluar la calidad y el rendimiento de tu flujo con grandes conjuntos de datos.
    - Integrar pruebas y evaluaciones en tu sistema CI/CD para asegurar la calidad de tu flujo.
- **Ciclo de desarrollo optimizado para producción**
    - Desplegar tu flujo en la plataforma de servicio que elijas o integrarlo fácilmente en el código de tu aplicación.
    - (Opcional pero altamente recomendado) Colaborar con tu equipo usando la versión en la nube de [Prompt flow en Azure AI](https://learn.microsoft.com/en-us/azure/machine-learning/prompt-flow/overview-what-is-prompt-flow?view=azureml-api-2).

------

## Instalación

Para comenzar rápidamente, puedes usar un entorno de desarrollo preconstruido. **Haz clic en el siguiente botón** para abrir el repositorio en GitHub Codespaces y luego continúa con este readme.

[![Abrir en GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/promptflow?quickstart=1)

Si prefieres empezar en tu entorno local, primero instala los paquetes:

Asegúrate de tener un entorno Python, se recomienda `python>=3.9, <=3.11`.

```sh
pip install promptflow promptflow-tools
```

## Inicio Rápido ⚡

**Crea un chatbot con prompt flow**

Ejecuta el siguiente comando para iniciar un prompt flow desde una plantilla de chat, creará una carpeta llamada `my_chatbot` y generará los archivos necesarios dentro de ella:

```sh
pf flow init --flow ./my_chatbot --type chat
```

**Configura una conexión para tu clave de API**

Para la clave de OpenAI, establece una conexión ejecutando el comando, usando el archivo `openai.yaml` en la carpeta `my_chatbot`, que almacena tu clave de OpenAI (puedes sobrescribir las claves y el nombre con --set para evitar cambios en el archivo yaml):

```sh
pf connection create --file ./my_chatbot/openai.yaml --set api_key=<your_api_key> --name open_ai_connection
```

Para la clave de Azure OpenAI, establece la conexión ejecutando el comando, usando el archivo `azure_openai.yaml`:

```sh
pf connection create --file ./my_chatbot/azure_openai.yaml --set api_key=<your_api_key> api_base=<your_api_base> --name open_ai_connection
```

**Chatea con tu flujo**

En la carpeta `my_chatbot`, hay un archivo `flow.dag.yaml` que describe el flujo, incluyendo entradas/salidas, nodos, conexión y el modelo LLM, etc.

> Ten en cuenta que en el nodo `chat`, estamos usando una conexión llamada `open_ai_connection` (especificada en el campo `connection`) y el modelo `gpt-35-turbo` (especificado en el campo `deployment_name`). El campo deployment_name especifica el modelo de OpenAI, o el recurso de despliegue de Azure OpenAI.

Interactúa con tu chatbot ejecutando: (presiona `Ctrl + C` para finalizar la sesión)

```sh
pf flow test --flow ./my_chatbot --interactive
```

**Valor principal: asegurar “Alta Calidad” desde el prototipo hasta la producción**

Explora nuestro [**tutorial de 15 minutos**](https://raw.githubusercontent.com/microsoft/promptflow/main/examples/tutorials/flow-fine-tuning-evaluation/promptflow-quality-improvement.md) que te guía a través del ajuste de prompts ➡ pruebas por lotes ➡ evaluación, todo diseñado para asegurar una alta calidad lista para producción.

¡Siguiente paso! Continúa con la sección de **Tutorial** 👇 para profundizar en prompt flow.

## Tutorial 🏃‍♂️

Prompt flow es una herramienta diseñada para **construir aplicaciones LLM de alta calidad**; el proceso de desarrollo en prompt flow sigue estos pasos: desarrollar un flujo, mejorar la calidad del flujo, desplegar el flujo en producción.

### Desarrolla tus propias aplicaciones LLM

#### Extensión de VS Code

También ofrecemos una extensión para VS Code (un diseñador de flujos) para una experiencia de desarrollo interactiva con interfaz gráfica.

<img src="https://raw.githubusercontent.com/microsoft/promptflow/main/docs/media/readme/vsc.png" alt="vsc" width="1000"/>

Puedes instalarla desde el <a href="https://marketplace.visualstudio.com/items?itemName=prompt-flow.prompt-flow">Marketplace de Visual Studio</a>.

#### Profundiza en el desarrollo de flujos

[Comenzando con prompt flow](https://raw.githubusercontent.com/microsoft/promptflow/main/docs/how-to-guides/quick-start.md): Una guía paso a paso para invocar tu primera ejecución de flujo.

### Aprende con casos de uso

[Tutorial: Chatea con PDF](https://github.com/microsoft/promptflow/blob/main/examples/tutorials/e2e-development/chat-with-pdf.md): Un tutorial de extremo a extremo sobre cómo construir una aplicación de chat de alta calidad con prompt flow, incluyendo desarrollo y evaluación del flujo con métricas.
> Más ejemplos pueden encontrarse [aquí](https://microsoft.github.io/promptflow/tutorials/index.html#samples). ¡Agradecemos contribuciones de nuevos casos de uso!

### Configuración para colaboradores

Si estás interesado en contribuir, comienza con nuestra guía de configuración para desarrolladores: [dev_setup.md](https://raw.githubusercontent.com/microsoft/promptflow/main/docs/dev/dev_setup.md).

¡Siguiente paso! Continúa con la sección de **Contribución** 👇 para aportar a prompt flow.

## Contribución

Este proyecto da la bienvenida a contribuciones y sugerencias. La mayoría de las contribuciones requieren que aceptes un
Acuerdo de Licencia de Colaborador (CLA) declarando que tienes el derecho de, y efectivamente, otorgarnos
los derechos para usar tu contribución. Para más detalles, visita https://cla.opensource.microsoft.com.

Cuando envíes un pull request, un bot de CLA determinará automáticamente si necesitas proporcionar
un CLA y decorará el PR apropiadamente (por ejemplo, verificación de estado, comentario). Simplemente sigue las instrucciones
provistas por el bot. Solo tendrás que hacerlo una vez en todos los repositorios que usen nuestro CLA.

Este proyecto ha adoptado el [Código de Conducta de Código Abierto de Microsoft](https://opensource.microsoft.com/codeofconduct/).
Para más información, consulta las [Preguntas Frecuentes sobre el Código de Conducta](https://opensource.microsoft.com/codeofconduct/faq/) o
contacta a [opencode@microsoft.com](mailto:opencode@microsoft.com) si tienes preguntas o comentarios adicionales.

## Marcas Registradas

Este proyecto puede contener marcas registradas o logotipos de proyectos, productos o servicios. El uso autorizado de marcas registradas o logotipos de Microsoft está sujeto y debe seguir las
[Directrices de Marca y Marca Registrada de Microsoft](https://www.microsoft.com/en-us/legal/intellectualproperty/trademarks/usage/general).
El uso de marcas registradas o logotipos de Microsoft en versiones modificadas de este proyecto no debe causar confusión ni implicar patrocinio de Microsoft.
Cualquier uso de marcas registradas o logotipos de terceros está sujeto a las políticas de esos terceros.

## Código de Conducta

Este proyecto ha adoptado el
[Código de Conducta de Código Abierto de Microsoft](https://opensource.microsoft.com/codeofconduct/).
Para más información consulta las
[Preguntas Frecuentes sobre el Código de Conducta](https://opensource.microsoft.com/codeofconduct/faq/)
o contacta a [opencode@microsoft.com](mailto:opencode@microsoft.com)
para cualquier pregunta o comentario adicional.

## Recolección de Datos

El software puede recopilar información sobre ti y el uso que haces del software y
enviarlo a Microsoft si está configurado para habilitar la telemetría.
Microsoft puede usar esta información para proporcionar servicios y mejorar nuestros productos y servicios.
Puedes activar la telemetría como se describe en el repositorio.
También hay funciones en el software que pueden permitirte a ti y a Microsoft
recopilar datos de los usuarios de tus aplicaciones. Si utilizas estas funciones, debes cumplir con la ley aplicable, incluyendo proporcionar los avisos apropiados a
los usuarios de tus aplicaciones junto con una copia de la declaración de privacidad de Microsoft.
Nuestra declaración de privacidad se encuentra en
https://go.microsoft.com/fwlink/?LinkID=824704. Puedes obtener más información sobre la recopilación
y uso de datos en la documentación de ayuda y en nuestra declaración de privacidad. El uso del software implica tu consentimiento a estas prácticas.

### Configuración de Telemetría

La recopilación de telemetría está habilitada por defecto.

Para desactivarla, ejecuta `pf config set telemetry.enabled=false` para apagarla.

## Licencia

Copyright (c) Microsoft Corporation. Todos los derechos reservados.

Licenciado bajo la licencia [MIT](https://raw.githubusercontent.com/microsoft/promptflow/main/LICENSE).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---
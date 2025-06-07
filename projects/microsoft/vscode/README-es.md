# Visual Studio Code - Código Abierto ("Code - OSS")

[![Solicitudes de Funciones](https://img.shields.io/github/issues/microsoft/vscode/feature-request.svg)](https://github.com/microsoft/vscode/issues?q=is%3Aopen+is%3Aissue+label%3Afeature-request+sort%3Areactions-%2B1-desc)
[![Errores](https://img.shields.io/github/issues/microsoft/vscode/bug.svg)](https://github.com/microsoft/vscode/issues?utf8=✓&q=is%3Aissue+is%3Aopen+label%3Abug)
[![Gitter](https://img.shields.io/badge/chat-on%20gitter-yellow.svg)](https://gitter.im/Microsoft/vscode)

## El Repositorio

Este repositorio ("`Code - OSS`") es donde nosotros (Microsoft) desarrollamos el producto [Visual Studio Code](https://code.visualstudio.com) junto con la comunidad. No solo trabajamos en el código y los problemas aquí, también publicamos nuestra [hoja de ruta](https://github.com/microsoft/vscode/wiki/Roadmap), [planes de iteración mensuales](https://github.com/microsoft/vscode/wiki/Iteration-Plans), y nuestros [planes de cierre](https://github.com/microsoft/vscode/wiki/Running-the-Endgame). Este código fuente está disponible para todos bajo la [licencia MIT](https://github.com/microsoft/vscode/blob/main/LICENSE.txt) estándar.

## Visual Studio Code

<p align="center">
  <img alt="VS Code en acción" src="https://user-images.githubusercontent.com/35271042/118224532-3842c400-b438-11eb-923d-a5f66fa6785a.png">
</p>

[Visual Studio Code](https://code.visualstudio.com) es una distribución del repositorio `Code - OSS` con personalizaciones específicas de Microsoft publicadas bajo una [licencia de producto de Microsoft](https://code.visualstudio.com/License) tradicional.

[Visual Studio Code](https://code.visualstudio.com) combina la simplicidad de un editor de código con lo que los desarrolladores necesitan para su ciclo principal de edición-compilación-depuración. Ofrece edición de código integral, navegación y soporte de comprensión junto con depuración ligera, un rico modelo de extensibilidad e integración liviana con herramientas existentes.

Visual Studio Code se actualiza mensualmente con nuevas características y corrección de errores. Puedes descargarlo para Windows, macOS y Linux en el [sitio web de Visual Studio Code](https://code.visualstudio.com/Download). Para obtener las últimas versiones todos los días, instala la [versión Insiders](https://code.visualstudio.com/insiders).

## Contribuir

Hay muchas maneras en las que puedes participar en este proyecto, por ejemplo:

* [Enviar errores y solicitudes de funciones](https://github.com/microsoft/vscode/issues), y ayudarnos a verificarlos a medida que se revisan
* Revisar [cambios en el código fuente](https://github.com/microsoft/vscode/pulls)
* Revisar la [documentación](https://github.com/microsoft/vscode-docs) y hacer pull requests para cualquier cosa, desde errores tipográficos hasta contenido nuevo o adicional

Si estás interesado en solucionar problemas y contribuir directamente a la base de código,
consulta el documento [Cómo Contribuir](https://github.com/microsoft/vscode/wiki/How-to-Contribute), que cubre lo siguiente:

* [Cómo compilar y ejecutar desde el código fuente](https://github.com/microsoft/vscode/wiki/How-to-Contribute)
* [El flujo de trabajo de desarrollo, incluyendo depuración y ejecución de pruebas](https://github.com/microsoft/vscode/wiki/How-to-Contribute#debugging)
* [Pautas de codificación](https://github.com/microsoft/vscode/wiki/Coding-Guidelines)
* [Enviar pull requests](https://github.com/microsoft/vscode/wiki/How-to-Contribute#pull-requests)
* [Cómo encontrar un problema en el que trabajar](https://github.com/microsoft/vscode/wiki/How-to-Contribute#where-to-contribute)
* [Contribuir a las traducciones](https://aka.ms/vscodeloc)

## Comentarios

* Haz una pregunta en [Stack Overflow](https://stackoverflow.com/questions/tagged/vscode)
* [Solicita una nueva función](CONTRIBUTING.md)
* Vota a favor de las [solicitudes de funciones populares](https://github.com/microsoft/vscode/issues?q=is%3Aopen+is%3Aissue+label%3Afeature-request+sort%3Areactions-%2B1-desc)
* [Reporta un problema](https://github.com/microsoft/vscode/issues)
* Conéctate con la comunidad de autores de extensiones en [GitHub Discussions](https://github.com/microsoft/vscode-discussions/discussions) o [Slack](https://aka.ms/vscode-dev-community)
* Sigue a [@code](https://twitter.com/code) y cuéntanos tu opinión

Consulta nuestra [wiki](https://github.com/microsoft/vscode/wiki/Feedback-Channels) para ver una descripción de cada uno de estos canales e información sobre otros canales disponibles impulsados por la comunidad.

## Proyectos Relacionados

Muchos de los componentes principales y extensiones de VS Code se encuentran en sus propios repositorios en GitHub. Por ejemplo, los repositorios del [adaptador de depuración de node](https://github.com/microsoft/vscode-node-debug) y el [adaptador de depuración de mono](https://github.com/microsoft/vscode-mono-debug) son independientes entre sí. Para ver una lista completa, visita la página de [Proyectos Relacionados](https://github.com/microsoft/vscode/wiki/Related-Projects) en nuestra [wiki](https://github.com/microsoft/vscode/wiki).

## Extensiones Incluidas

VS Code incluye un conjunto de extensiones integradas ubicadas en la carpeta [extensions](extensions), incluyendo gramáticas y fragmentos para muchos lenguajes. Las extensiones que proporcionan soporte de lenguaje avanzado (autocompletado, Ir a la Definición) para un idioma tienen el sufijo `language-features`. Por ejemplo, la extensión `json` proporciona coloreado para `JSON` y la extensión `json-language-features` proporciona soporte avanzado para `JSON`.

## Contenedor de Desarrollo

Este repositorio incluye un contenedor de desarrollo Visual Studio Code Dev Containers / GitHub Codespaces.

* Para [Dev Containers](https://aka.ms/vscode-remote/download/containers), utiliza el comando **Dev Containers: Clone Repository in Container Volume...** que crea un volumen Docker para un mejor I/O de disco en macOS y Windows.
  * Si ya tienes VS Code y Docker instalados, también puedes hacer clic [aquí](https://vscode.dev/redirect?url=vscode://ms-vscode-remote.remote-containers/cloneInVolume?url=https://github.com/microsoft/vscode) para comenzar. Esto hará que VS Code instale automáticamente la extensión Dev Containers si es necesario, clone el código fuente en un volumen del contenedor y levante un contenedor de desarrollo listo para usar.

* Para Codespaces, instala la extensión [GitHub Codespaces](https://marketplace.visualstudio.com/items?itemName=GitHub.codespaces) en VS Code y utiliza el comando **Codespaces: Create New Codespace**.

Docker / el Codespace deben tener al menos **4 núcleos y 6 GB de RAM (8 GB recomendados)** para ejecutar una compilación completa. Consulta el [README del contenedor de desarrollo](.devcontainer/README.md) para más información.

## Código de Conducta

Este proyecto ha adoptado el [Código de Conducta de Código Abierto de Microsoft](https://opensource.microsoft.com/codeofconduct/). Para más información, consulta las [preguntas frecuentes sobre el Código de Conducta](https://opensource.microsoft.com/codeofconduct/faq/) o contacta a [opencode@microsoft.com](mailto:opencode@microsoft.com) con cualquier pregunta o comentario adicional.

## Licencia

Copyright (c) Microsoft Corporation. Todos los derechos reservados.

Licenciado bajo la licencia [MIT](LICENSE.txt).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---
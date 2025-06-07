![terminal-logos](https://github.com/microsoft/terminal/assets/91625426/333ddc76-8ab2-4eb4-a8c0-4d7b953b1179)

[![Terminal Build Status](https://dev.azure.com/shine-oss/terminal/_apis/build/status%2FTerminal%20CI?branchName=main)](https://dev.azure.com/shine-oss/terminal/_build/latest?definitionId=1&branchName=main)

# Bienvenido al repositorio de Windows Terminal, Consola y Línea de Comandos

<details>
  <summary><strong>Tabla de Contenidos</strong></summary>

- [Instalación y ejecución de Windows Terminal](#instalación-y-ejecución-de-windows-terminal)
  - [Microsoft Store \[Recomendado\]](#microsoft-store-recomendado)
  - [Otros métodos de instalación](#otros-métodos-de-instalación)
    - [Vía GitHub](#vía-github)
    - [Vía Windows Package Manager CLI (winget)](#vía-windows-package-manager-cli-winget)
    - [Vía Chocolatey (no oficial)](#vía-chocolatey-no-oficial)
    - [Vía Scoop (no oficial)](#vía-scoop-no-oficial)
- [Instalación de Windows Terminal Canary](#instalación-de-windows-terminal-canary)
- [Hoja de ruta de Windows Terminal](#hoja-de-ruta-de-windows-terminal)
- [Resumen de Terminal y Consola](#resumen-de-terminal-y-consola)
  - [Windows Terminal](#windows-terminal)
  - [El host de la consola de Windows](#el-host-de-la-consola-de-windows)
  - [Componentes compartidos](#componentes-compartidos)
  - [Creación del nuevo Windows Terminal](#creación-del-nuevo-windows-terminal)
- [Recursos](#recursos)
- [Preguntas Frecuentes (FAQ)](#preguntas-frecuentes-faq)
  - [Compilé y ejecuté el nuevo Terminal, pero se ve igual que la consola antigua](#compilé-y-ejecuté-el-nuevo-terminal-pero-se-ve-igual-que-la-consola-antigua)
- [Documentación](#documentación)
- [Contribuir](#contribuir)
- [Comunicación con el equipo](#comunicación-con-el-equipo)
- [Guía para desarrolladores](#guía-para-desarrolladores)
- [Prerrequisitos](#prerrequisitos)
- [Compilando el código](#compilando-el-código)
  - [Compilar en PowerShell](#compilar-en-powershell)
  - [Compilar en Cmd](#compilar-en-cmd)
- [Ejecución y depuración](#ejecución-y-depuración)
  - [Guía de codificación](#guía-de-codificación)
- [Código de conducta](#código-de-conducta)

</details>

<br />

Este repositorio contiene el código fuente de:

* [Windows Terminal](https://aka.ms/terminal)
* [Windows Terminal Preview](https://aka.ms/terminal-preview)
* El host de la consola de Windows (`conhost.exe`)
* Componentes compartidos entre ambos proyectos
* [ColorTool](./src/tools/ColorTool)
* [Proyectos de ejemplo](./samples)
  que muestran cómo consumir las APIs de la Consola de Windows

Repositorios relacionados incluyen:

* [Documentación de Windows Terminal](https://docs.microsoft.com/windows/terminal)
  ([Repo: Contribuir a la documentación](https://github.com/MicrosoftDocs/terminal))
* [Documentación de la API de Consola](https://github.com/MicrosoftDocs/Console-Docs)
* [Fuente tipográfica Cascadia Code](https://github.com/Microsoft/Cascadia-Code)

## Instalación y ejecución de Windows Terminal

> [!NOTE]
> Windows Terminal requiere Windows 10 2004 (compilación 19041) o posterior

### Microsoft Store [Recomendado]

Instale el [Windows Terminal desde Microsoft Store][store-install-link].
Esto le permite estar siempre en la última versión cuando lanzamos nuevas compilaciones
con actualizaciones automáticas.

Este es nuestro método preferido.

### Otros métodos de instalación

#### Vía GitHub

Para usuarios que no pueden instalar Windows Terminal desde Microsoft Store,
las compilaciones liberadas pueden descargarse manualmente desde la [página de lanzamientos](https://github.com/microsoft/terminal/releases) de este repositorio.

Descargue el archivo `Microsoft.WindowsTerminal_<versionNumber>.msixbundle` de la sección **Assets**. Para instalar la aplicación, simplemente haga doble clic en el archivo `.msixbundle` y el instalador debería ejecutarse automáticamente. Si esto falla por alguna razón, puede intentar el siguiente comando en un prompt de PowerShell:

```powershell
# NOTA: Si está usando PowerShell 7+, por favor ejecute
# Import-Module Appx -UseWindowsPowerShell
# antes de usar Add-AppxPackage.

Add-AppxPackage Microsoft.WindowsTerminal_<versionNumber>.msixbundle
```

> [!NOTE]
> Si instala Terminal manualmente:
>
> * Puede que necesite instalar el [Paquete de Framework de Escritorio VC++ v14](https://docs.microsoft.com/troubleshoot/cpp/c-runtime-packages-desktop-bridge#how-to-install-and-update-desktop-framework-packages).
>   Esto solo debería ser necesario en compilaciones antiguas de Windows 10 y solo si recibe un error sobre paquetes de framework faltantes.
> * Terminal no se actualizará automáticamente cuando se publiquen nuevas compilaciones, así que deberá
>   instalar regularmente la última versión de Terminal para recibir todas las correcciones
>   y mejoras.

#### Vía Windows Package Manager CLI (winget)

Los usuarios de [winget](https://github.com/microsoft/winget-cli) pueden descargar e instalar
la última versión de Terminal instalando el paquete `Microsoft.WindowsTerminal`:

```powershell
winget install --id Microsoft.WindowsTerminal -e
```

> [!NOTE]
> El soporte de dependencias está disponible en la versión [1.6.2631 o posterior](https://github.com/microsoft/winget-cli/releases) de WinGet. Para instalar la versión estable 1.18 o posterior de Terminal, asegúrese de tener la versión actualizada del cliente WinGet.

#### Vía Chocolatey (no oficial)

Los usuarios de [Chocolatey](https://chocolatey.org) pueden descargar e instalar la última
versión de Terminal instalando el paquete `microsoft-windows-terminal`:

```powershell
choco install microsoft-windows-terminal
```

Para actualizar Windows Terminal usando Chocolatey, ejecute lo siguiente:

```powershell
choco upgrade microsoft-windows-terminal
```

Si tiene algún problema al instalar/actualizar el paquete, diríjase a la
[página del paquete Windows Terminal](https://chocolatey.org/packages/microsoft-windows-terminal) y siga el
[proceso de triaje de Chocolatey](https://chocolatey.org/docs/package-triage-process).

#### Vía Scoop (no oficial)

Los usuarios de [Scoop](https://scoop.sh) pueden descargar e instalar la última versión de Terminal
instalando el paquete `windows-terminal`:

```powershell
scoop bucket add extras
scoop install windows-terminal
```

Para actualizar Windows Terminal usando Scoop, ejecute lo siguiente:

```powershell
scoop update windows-terminal
```

Si tiene algún problema al instalar/actualizar el paquete, por favor busque o
repórtelo en la [página de issues](https://github.com/lukesampson/scoop-extras/issues) del repositorio Scoop Extras bucket.

---

## Instalación de Windows Terminal Canary
Windows Terminal Canary es una compilación nocturna de Windows Terminal. Esta compilación incluye el código más reciente de nuestra rama `main`, dándole la oportunidad de probar características antes de que lleguen a Windows Terminal Preview.

Windows Terminal Canary es nuestra oferta menos estable, por lo que puede encontrar errores antes de que los detectemos.

Windows Terminal Canary está disponible como distribución App Installer y como distribución Portable ZIP.

La distribución App Installer soporta actualizaciones automáticas. Debido a limitaciones de la plataforma, este instalador solo funciona en Windows 11.

La distribución Portable ZIP es una aplicación portátil. No se actualizará automáticamente ni buscará actualizaciones. Esta distribución ZIP portátil funciona en Windows 10 (19041+) y Windows 11.

| Distribución  | Arquitectura    | Enlace                                             |
|---------------|:---------------:|---------------------------------------------------|
| App Installer | x64, arm64, x86 | [descargar](https://aka.ms/terminal-canary-installer) |
| Portable ZIP  | x64             | [descargar](https://aka.ms/terminal-canary-zip-x64)   |
| Portable ZIP  | ARM64           | [descargar](https://aka.ms/terminal-canary-zip-arm64) |
| Portable ZIP  | x86             | [descargar](https://aka.ms/terminal-canary-zip-x86)   |

_Conozca más sobre los [tipos de distribuciones de Windows Terminal](https://learn.microsoft.com/windows/terminal/distributions)._

---

## Hoja de ruta de Windows Terminal

El plan para Windows Terminal [se describe aquí](/doc/roadmap-2023.md) y
se actualizará a medida que avance el proyecto.

## Resumen de Terminal y Consola

Por favor, tómese unos minutos para revisar el siguiente resumen antes de sumergirse en el
código:

### Windows Terminal

Windows Terminal es una aplicación de terminal moderna, rica en características y productiva
para usuarios de la línea de comandos. Incluye muchas de las funciones más solicitadas
por la comunidad de la línea de comandos de Windows, como soporte para pestañas, texto enriquecido,
globalización, configurabilidad, temas y estilos, y más.

El Terminal también deberá cumplir nuestros objetivos y métricas para asegurar que siga
siendo rápido y eficiente, y que no consuma grandes cantidades de memoria o energía.

### El host de la consola de Windows

El host de la consola de Windows, `conhost.exe`, es la experiencia original de usuario de la línea de comandos de Windows. También aloja la infraestructura de línea de comandos de Windows y el servidor de la API de Consola de Windows, el motor de entrada, el motor de renderizado, las preferencias de usuario, etc. El código del host de la consola en este repositorio es el código fuente real del que se compila el `conhost.exe` en Windows.

Desde que asumimos la responsabilidad de la línea de comandos de Windows en 2014, el equipo añadió
varias funciones nuevas a la Consola, incluyendo transparencia de fondo,
selección basada en líneas, soporte para [secuencias ANSI / Terminal Virtual](https://en.wikipedia.org/wiki/ANSI_escape_code), [color de 24 bits](https://devblogs.microsoft.com/commandline/24-bit-color-in-the-windows-console/),
un [Pseudoconsola ("ConPTY")](https://devblogs.microsoft.com/commandline/windows-command-line-introducing-the-windows-pseudo-console-conpty/),
y más.

Sin embargo, debido a que el objetivo principal de la Consola de Windows es mantener la compatibilidad hacia atrás,
no hemos podido añadir muchas de las funciones que la comunidad
(y el equipo) han estado solicitando durante los últimos años, incluyendo pestañas,
texto unicode y emojis.

Estas limitaciones nos llevaron a crear el nuevo Windows Terminal.

> Puede leer más sobre la evolución de la línea de comandos en general, y sobre la
> línea de comandos de Windows en particular en [esta serie de publicaciones del blog](https://devblogs.microsoft.com/commandline/windows-command-line-backgrounder/)
> del equipo de Command-Line.

### Componentes compartidos

Al revisar la Consola de Windows, modernizamos considerablemente su base de código,
separando lógicamente entidades en módulos y clases, introdujimos algunos
puntos clave de extensibilidad, reemplazamos varias colecciones y
contenedores antiguos con [contenedores STL](https://docs.microsoft.com/en-us/cpp/standard-library/stl-containers?view=vs-2022) más seguros y eficientes,
y simplificamos y aseguramos el código usando las [Windows Implementation Libraries - WIL](https://github.com/Microsoft/wil) de Microsoft.

Esta revisión resultó en que varios de los componentes clave de la Consola estén disponibles
para su reutilización en cualquier implementación de terminal en Windows. Estos componentes incluyen un
nuevo motor de diseño y renderizado de texto basado en DirectWrite, un búfer de texto capaz de
almacenar tanto UTF-16 como UTF-8, un parser/emisor VT, y más.

### Creación del nuevo Windows Terminal

Cuando comenzamos a planificar la nueva aplicación Windows Terminal, exploramos y
evaluamos varios enfoques y tecnologías. Finalmente decidimos que
nuestros objetivos se cumplirían mejor continuando nuestra inversión en nuestra base de código C++,
lo que nos permitiría reutilizar varios de los componentes modernizados mencionados tanto en la Consola existente como en el nuevo Terminal. Además, nos
dimos cuenta de que esto nos permitiría construir gran parte del núcleo del Terminal como
un control de interfaz de usuario reutilizable que otros pueden incorporar en sus propias aplicaciones.

El resultado de este trabajo está contenido en este repositorio y se entrega como la
aplicación Windows Terminal que puede descargar desde Microsoft Store o
[directamente desde los lanzamientos de este repositorio](https://github.com/microsoft/terminal/releases).

---

## Recursos

Para más información sobre Windows Terminal, pueden ser útiles e interesantes los siguientes recursos:

* [Blog de Command-Line](https://devblogs.microsoft.com/commandline)
* [Serie de publicaciones sobre Command-Line Backgrounder](https://devblogs.microsoft.com/commandline/windows-command-line-backgrounder/)
* Lanzamiento de Windows Terminal: [Video "Sizzle" de Terminal](https://www.youtube.com/watch?v=8gw0rXPMMPE&list=PLEHMQNlPj-Jzh9DkNpqipDGCZZuOwrQwR&index=2&t=0s)
* Lanzamiento de Windows Terminal: [Sesión Build 2019](https://www.youtube.com/watch?v=KMudkRcwjCw)
* Run As Radio: [Show 645 - Windows Terminal con Richard Turner](https://www.runasradio.com/Shows/Show/645)
* Azure Devops Podcast: [Episodio 54 - Kayla Cinnamon y Rich Turner en DevOps en el equipo de Windows Terminal](http://azuredevopspodcast.clear-measure.com/kayla-cinnamon-and-rich-turner-on-devops-on-the-windows-terminal-team-episode-54)
* Microsoft Ignite 2019 Sesión: [La línea de comandos moderna de Windows: Windows Terminal - BRK3321](https://myignite.techcommunity.microsoft.com/sessions/81329?source=sessions)

---

## Preguntas Frecuentes (FAQ)

### Compilé y ejecuté el nuevo Terminal, pero se ve igual que la consola antigua

Causa: Está iniciando la solución incorrecta en Visual Studio.

Solución: Asegúrese de estar compilando y desplegando el proyecto `CascadiaPackage` en
Visual Studio.

> [!NOTE]
> `OpenConsole.exe` es solo un `conhost.exe` compilado localmente, la clásica
> Consola de Windows que aloja la infraestructura de línea de comandos de Windows. OpenConsole
> es utilizado por Windows Terminal para conectarse y comunicarse con aplicaciones de línea de comandos (a través de
> [ConPty](https://devblogs.microsoft.com/commandline/windows-command-line-introducing-the-windows-pseudo-console-conpty/)).

---

## Documentación

Toda la documentación del proyecto se encuentra en [aka.ms/terminal-docs](https://aka.ms/terminal-docs). Si desea
contribuir a la documentación, por favor envíe un pull request en el [repositorio de Documentación de Windows Terminal](https://github.com/MicrosoftDocs/terminal).

---

## Contribuir

¡Estamos emocionados de trabajar junto a usted, nuestra increíble comunidad, para construir y
mejorar Windows Terminal!

***ANTES de comenzar a trabajar en una funcionalidad/solución***, por favor lea y siga nuestra
[Guía del Colaborador](./CONTRIBUTING.md)
para evitar esfuerzos duplicados o innecesarios.

## Comunicación con el equipo

La forma más fácil de comunicarse con el equipo es a través de issues en GitHub.

Por favor, cree nuevos issues, solicitudes de características y sugerencias, pero **busque issues abiertos/cerrados similares antes de crear uno nuevo.**

Si desea hacer una pregunta que considere que no amerita un issue
(aún), puede contactarnos por Twitter:

* Christopher Nguyen, Product Manager:
  [@nguyen_dows](https://twitter.com/nguyen_dows)
* Dustin Howett, Engineering Lead: [@dhowett](https://twitter.com/DHowett)
* Mike Griese, Senior Developer: [@zadjii@mastodon.social](https://mastodon.social/@zadjii)
* Carlos Zamora, Developer: [@cazamor_msft](https://twitter.com/cazamor_msft)
* Pankaj Bhojwani, Developer
* Leonard Hecker, Developer: [@LeonardHecker](https://twitter.com/LeonardHecker)

## Guía para desarrolladores

## Prerrequisitos

Puede configurar su entorno para compilar Terminal de dos maneras:

### Usando archivo de configuración WinGet

Después de clonar el repositorio, puede usar un [archivo de configuración WinGet](https://learn.microsoft.com/en-us/windows/package-manager/configuration/#use-a-winget-configuration-file-to-configure-your-machine)
para configurar su entorno. El [archivo de configuración predeterminado](.config/configuration.winget) instala Visual Studio 2022 Community y el resto de herramientas requeridas. Hay otras dos variantes del archivo de configuración disponibles en el directorio [.config](.config) para las ediciones Enterprise y Professional de Visual Studio 2022. Para ejecutar el archivo de configuración predeterminado, puede hacer doble clic en el archivo desde el explorador o ejecutar el siguiente comando:

```powershell
winget configure .config\configuration.winget
```

### Configuración manual

* Debe estar ejecutando Windows 10 2004 (compilación >= 10.0.19041.0) o posterior para ejecutar
  Windows Terminal
* Debe [habilitar el Modo Desarrollador en la aplicación de Configuración de Windows](https://docs.microsoft.com/en-us/windows/uwp/get-started/enable-your-device-for-development)
  para instalar y ejecutar Windows Terminal localmente
* Debe tener [PowerShell 7 o posterior](https://github.com/PowerShell/PowerShell/releases/latest) instalado
* Debe tener instalado el [SDK de Windows 11 (10.0.22621.0)](https://developer.microsoft.com/en-us/windows/downloads/windows-sdk/)
* Debe tener instalado al menos [VS 2022](https://visualstudio.microsoft.com/downloads/)
* Debe instalar las siguientes cargas de trabajo mediante el instalador de VS. Nota: Al abrir
  la solución en VS 2022, [se le pedirá instalar los componentes faltantes automáticamente](https://devblogs.microsoft.com/setup/configure-visual-studio-across-your-organization-with-vsconfig/):
  * Desarrollo de escritorio con C++
  * Desarrollo de Plataforma Universal de Windows
  * **Los siguientes componentes individuales**
    * C++ (v143) Universal Windows Platform Tools
* Debe instalar el [paquete de destino de .NET Framework](https://docs.microsoft.com/dotnet/framework/install/guide-for-developers#to-install-the-net-framework-developer-pack-or-targeting-pack) para compilar proyectos de prueba

## Compilando el código

OpenConsole.sln puede compilarse desde Visual Studio o desde la línea de comandos
usando un conjunto de scripts y herramientas de conveniencia en el directorio **/tools**:

### Compilar en PowerShell

```powershell
Import-Module .\tools\OpenConsole.psm1
Set-MsBuildDevEnvironment
Invoke-OpenConsoleBuild
```

### Compilar en Cmd

```shell
.\tools\razzle.cmd
bcz
```

## Ejecución y depuración

Para depurar Windows Terminal en VS, haga clic derecho sobre `CascadiaPackage` (en el
Explorador de soluciones) y vaya a propiedades. En el menú Depuración, cambie "Application
process" y "Background task process" a "Native Only".

Debería poder compilar y depurar el proyecto Terminal presionando
<kbd>F5</kbd>. Asegúrese de seleccionar la plataforma "x64" o "x86": el
Terminal no se compila para "Any Cpu" (porque el Terminal es una aplicación C++,
no una en C#).

> 👉 _No_ podrá iniciar Terminal directamente ejecutando
> WindowsTerminal.exe. Para más detalles del porqué, vea
> [#926](https://github.com/microsoft/terminal/issues/926),
> [#4043](https://github.com/microsoft/terminal/issues/4043)

### Guía de codificación

Por favor revise estos breves documentos sobre nuestras prácticas de codificación.

> 👉 Si encuentra algo faltante en estos documentos, no dude en contribuir
> en cualquiera de nuestros archivos de documentación en el repositorio (¡o escriba unos nuevos!)

Esto es un trabajo en progreso mientras aprendemos qué necesitamos proporcionar a las personas para que sean contribuyentes efectivos a nuestro proyecto.

* [Estilo de código](./doc/STYLE.md)
* [Organización del código](./doc/ORGANIZATION.md)
* [Excepciones en nuestra base de código heredada](./doc/EXCEPTIONS.md)
* [Punteros inteligentes y macros útiles para interactuar con Windows en WIL](./doc/WIL.md)

---

## Código de Conducta

Este proyecto ha adoptado el [Código de Conducta de Microsoft Open Source][conduct-code]. Para más información, vea las [Preguntas Frecuentes del Código de Conducta][conduct-FAQ] o contacte a [opencode@microsoft.com][conduct-email] con cualquier pregunta o comentario adicional.

[conduct-code]: https://opensource.microsoft.com/codeofconduct/
[conduct-FAQ]: https://opensource.microsoft.com/codeofconduct/faq/
[conduct-email]: mailto:opencode@microsoft.com
[store-install-link]: https://aka.ms/terminal

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---
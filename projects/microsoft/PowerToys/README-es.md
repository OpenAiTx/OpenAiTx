# Microsoft PowerToys

![Imagen principal de Microsoft PowerToys](doc/images/overview/PT_hero_image.png)

[Cómo usar PowerToys][usingPowerToys-docs-link] | [Descargas y notas de lanzamiento][github-release-link] | [Contribuir a PowerToys](#contributing) | [Novedades](#whats-happening) | [Hoja de ruta](#powertoys-roadmap)

## Acerca de

Microsoft PowerToys es un conjunto de utilidades para usuarios avanzados que permite ajustar y optimizar su experiencia en Windows para lograr una mayor productividad. Para más información sobre [descripción general de PowerToys y cómo usar las utilidades][usingPowerToys-docs-link], o cualquier otra herramienta y recurso para [entornos de desarrollo en Windows](https://learn.microsoft.com/windows/dev-environment/overview), visite [learn.microsoft.com][usingPowerToys-docs-link].

|              | Utilidades actuales: |              |
|--------------|----------------------|--------------|
| [Advanced Paste](https://aka.ms/PowerToysOverview_AdvancedPaste) | [Always on Top](https://aka.ms/PowerToysOverview_AoT) | [PowerToys Awake](https://aka.ms/PowerToysOverview_Awake) |
| [Color Picker](https://aka.ms/PowerToysOverview_ColorPicker) | [Command Not Found](https://aka.ms/PowerToysOverview_CmdNotFound) | [Command Palette](https://aka.ms/PowerToysOverview_CmdPal) |
| [Crop And Lock](https://aka.ms/PowerToysOverview_CropAndLock) | [Environment Variables](https://aka.ms/PowerToysOverview_EnvironmentVariables) | [FancyZones](https://aka.ms/PowerToysOverview_FancyZones) |
| [Complementos de Explorador de Archivos](https://aka.ms/PowerToysOverview_FileExplorerAddOns) | [File Locksmith](https://aka.ms/PowerToysOverview_FileLocksmith) | [Editor de archivo Hosts](https://aka.ms/PowerToysOverview_HostsFileEditor) |
| [Redimensionador de Imágenes](https://aka.ms/PowerToysOverview_ImageResizer) | [Administrador de Teclado](https://aka.ms/PowerToysOverview_KeyboardManager) | [Utilidades de ratón](https://aka.ms/PowerToysOverview_MouseUtilities) |
| [Mouse Without Borders](https://aka.ms/PowerToysOverview_MouseWithoutBorders) | [New+](https://aka.ms/PowerToysOverview_NewPlus) | [Pegar como Texto Plano](https://aka.ms/PowerToysOverview_PastePlain) |
| [Peek](https://aka.ms/PowerToysOverview_Peek) | [PowerRename](https://aka.ms/PowerToysOverview_PowerRename) | [PowerToys Run](https://aka.ms/PowerToysOverview_PowerToysRun) |
| [Quick Accent](https://aka.ms/PowerToysOverview_QuickAccent) | [Vista previa del registro](https://aka.ms/PowerToysOverview_RegistryPreview) | [Regla de Pantalla](https://aka.ms/PowerToysOverview_ScreenRuler) |
| [Guía de atajos](https://aka.ms/PowerToysOverview_ShortcutGuide) | [Extractor de texto](https://aka.ms/PowerToysOverview_TextExtractor) | [Espacios de trabajo](https://aka.ms/PowerToysOverview_Workspaces) |
| [ZoomIt](https://aka.ms/PowerToysOverview_ZoomIt) |

## Instalación y ejecución de Microsoft PowerToys

### Requisitos

- Windows 11 o Windows 10 versión 2004 (nombre en clave 20H1 / número de compilación 19041) o superior.
- Procesador x64 o ARM64
- Nuestro instalador instalará los siguientes elementos:
   - Instalador de [Microsoft Edge WebView2 Runtime](https://go.microsoft.com/fwlink/p/?LinkId=2124703). Esto instalará la última versión.

### Vía GitHub con EXE [Recomendado]

Vaya a la [página de lanzamientos de Microsoft PowerToys en GitHub][github-release-link] y haga clic en `Assets` al final para mostrar los archivos disponibles en la versión. Use el instalador de PowerToys adecuado que coincida con la arquitectura de su máquina y el alcance de instalación. Para la mayoría, es `x64` y por usuario.

<!-- items that need to be updated release to release -->
[github-next-release-work]: https://github.com/microsoft/PowerToys/issues?q=is%3Aissue+milestone%3A%22PowerToys+0.92%22
[github-current-release-work]: https://github.com/microsoft/PowerToys/issues?q=is%3Aissue+milestone%3A%22PowerToys+0.91%22
[ptUserX64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysUserSetup-0.91.1-x64.exe 
[ptUserArm64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysUserSetup-0.91.1-arm64.exe 
[ptMachineX64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysSetup-0.91.1-x64.exe 
[ptMachineArm64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysSetup-0.91.1-arm64.exe
 
|  Descripción  | Nombre de archivo | hash sha256 |
|---------------|-------------------|-------------|
| Por usuario - x64       | [PowerToysUserSetup-0.91.1-x64.exe][ptUserX64] | 42EA4A3E8C79A5456476D19E72B3E2AB9393A89C4DC7442EB7EE5A1E3490D38A |
| Por usuario - ARM64     | [PowerToysUserSetup-0.91.1-arm64.exe][ptUserArm64] | F3F433FE04049F9197411D792AADEBF34E3BE7FE16327BD8B73D2A046ED8BAF6 |
| Para toda la máquina - x64   | [PowerToysSetup-0.91.1-x64.exe][ptMachineX64] | EC4BC3A8625775866B0ED4577CCF83E6EC7B1A0AD267379DDBAF4FE49C7B5BDD |
| Para toda la máquina - ARM64 | [PowerToysSetup-0.91.1-arm64.exe][ptMachineArm64] | 9CB8911008420D0E446AE3D5CE365E447FA4DF9DCF9337F3A80F933C00FC3689 |

Este es nuestro método preferido.

### Vía Microsoft Store

Instale desde la [página de PowerToys en Microsoft Store][microsoft-store-link]. Debe estar utilizando la [nueva Microsoft Store](https://blogs.windows.com/windowsExperience/2021/06/24/building-a-new-open-microsoft-store-on-windows-11/), que está disponible tanto para Windows 11 como para Windows 10.

### Vía WinGet
Descargue PowerToys desde [WinGet][winget-link]. La actualización de PowerToys mediante winget respetará el alcance de instalación actual de PowerToys. Para instalar PowerToys, ejecute el siguiente comando desde la línea de comandos / PowerShell:

#### Instalador para usuario [predeterminado]
```powershell
winget install Microsoft.PowerToys -s winget
```

#### Instalador para toda la máquina

```powershell
winget install --scope machine Microsoft.PowerToys -s winget
```

### Otros métodos de instalación

Existen [métodos de instalación impulsados por la comunidad](./doc/unofficialInstallMethods.md) como Chocolatey y Scoop. Si estas son sus soluciones de instalación preferidas, encontrará las instrucciones allí.

## Complementos de terceros para Run

Existe una colección de [complementos de terceros](./doc/thirdPartyRunPlugins.md) creados por la comunidad que no se distribuyen con PowerToys.

## Contribuir

Este proyecto da la bienvenida a todo tipo de contribuciones. Además de características de codificación / corrección de errores, otras formas de ayudar incluyen redacción de especificaciones, diseño, documentación y detección de errores. Nos entusiasma trabajar con la comunidad de usuarios avanzados para construir un conjunto de herramientas que le ayuden a sacar el máximo provecho de Windows.

Pedimos que **antes de comenzar a trabajar en una característica que desee contribuir**, por favor lea nuestra [Guía del colaborador](CONTRIBUTING.md). Nos encantaría trabajar con usted para encontrar el mejor enfoque, proporcionar orientación y mentoría durante el desarrollo de la función, y ayudar a evitar esfuerzos desperdiciados o duplicados.

La mayoría de las contribuciones requieren que acepte un [Acuerdo de Licencia para Colaboradores (CLA)][oss-CLA] declarando que nos otorga los derechos para usar su contribución y que tiene permiso para hacerlo.

Para obtener orientación sobre el desarrollo para PowerToys, consulte la [documentación para desarrolladores](/doc/devdocs) para una descripción detallada. Esto incluye cómo configurar su equipo para compilar.

## Novedades

### Hoja de ruta de PowerToys

Nuestra [hoja de ruta priorizada][roadmap] de características y utilidades en las que el equipo principal está trabajando.

### 0.91 - Actualización de mayo de 2025

En esta versión, nos centramos en nuevas características, estabilidad y automatización.

**✨Destacados**

 - Nos centramos en mejorar considerablemente el rendimiento de Command Palette y corregir una gran cantidad de errores. Algunas de las nuevas funciones que hemos agregado son:
 - Se añadió la capacidad para que Command Palette busque cualquier archivo usando un comando de respaldo.
 - Se añadió la posibilidad de hacer que la tecla de acceso rápido global de Command Palette sea un "low-level keyboard hook".
 - Se añadió un comando de respaldo para abrir URL en la extensión WebSearch, permitiendo a los usuarios abrir directamente URLs en el navegador desde Command Palette.
 - Ahora puede definir formatos personalizados en los complementos de Fecha y Hora de PT Run y Command Palette. Gracias [@htcfreek](https://github.com/htcfreek)!

### Advanced Paste

 - Se solucionó un problema donde Advanced Paste no creaba el motor OCR para ciertas etiquetas de idioma inglés (por ejemplo, en-CA) inicializando el motor OCR con el idioma del perfil de usuario. Gracias [@cryolithic](https://github.com/cryolithic)!

### Color Picker

 - Se solucionó una pérdida de recursos que causaba bloqueos o cierres inesperados eliminando correctamente el objeto Graphics. Gracias [@dcog989](https://github.com/dcog989)!
 - Se solucionó un problema donde Color Picker se cerraba al presionar la tecla Backspace, asegurando que solo se cierre cuando está enfocado y alineando el comportamiento de Escape/Backspace. Gracias [@PesBandi](https://github.com/PesBandi)!
 - Se añadió soporte para los formatos de color Oklab y Oklch en Color Picker. Gracias [@lemonyte](https://github.com/lemonyte)!

### Command Not Found

 - Se actualizó el script de WinGet Command Not Found para habilitar características experimentales solo si realmente existen.

### Command Palette

 - Se actualizó la plantilla de informe de errores para incluir el módulo Command Palette.
 - Se solucionó un problema donde la ventana de notificación no se escalaba para DPI, lo que causaba problemas de diseño bajo escalado de pantalla.
 - Se corrigió un problema donde la navegación con teclado arriba/abajo no movía la selección cuando el cursor estaba en la posición 0, y se añadió navegación continua como en PT Run v1. Gracias [@davidegiacometti](https://github.com/davidegiacometti)!
 - Se actualizó el código de la extensión de Tiempo y Fecha para simplificarlo y mejorar su claridad.
 - Se solucionó un problema donde el uso de mayúsculas en el comando causaba fallo al intentar ir al puntero del ratón, resuelto ajustando el comando a minúsculas.
 - Se añadió un comando de respaldo para abrir URL en la extensión WebSearch, permitiendo a los usuarios abrir directamente URLs en el navegador desde Command Palette. Gracias [@htcfreek](https://github.com/htcfreek)!
 - Se añadió la opción para habilitar/deshabilitar el icono de la bandeja del sistema en CmdPal y se alineó la terminología con Windows 11. Gracias [@davidegiacometti](https://github.com/davidegiacometti)!
 - Se corrigió un problema de actualización de alias eliminando el alias anterior cuando se establece uno nuevo.
 - Se resolvió un conflicto de mayúsculas en GitHub migrando Exts y exts a un nuevo directorio ext, asegurando una estructura coherente en todas las plataformas y previniendo la fragmentación de rutas.
 - Se solucionó un problema donde el comando 'Crear nueva extensión' generaba nombres de archivo vacíos.
 - Se añadió la opción de hacer que la tecla de acceso rápido global sea un "low-level keyboard hook".
 - Se añadió soporte para miniaturas JUMBO, permitiendo el acceso a iconos de alta resolución.
 - Se solucionaron bloqueos cuando CmdPal se ocultaba automáticamente mientras se abría un diálogo MSAL, evitando que CmdPal se oculte si está deshabilitado.
 - Se añadió soporte para seleccionar inmediatamente el texto de búsqueda cuando se carga una página.
 - Se corrigió un error donde las páginas de configuración de extensiones no se recargaban al reabrir, actualizando el formulario de configuración cuando se guardan los ajustes de la extensión.
 - Se solucionó un problema donde Command Palette no se iniciaba desde el lanzador.
 - Se refactorizó y migró la lógica de la calculadora de PowerToys Run v1 a Command Palette, se añadió soporte de configuración y se mejoró el comportamiento de respaldo.
 - Se volvió a añadir soporte para atajos de teclado en elementos de lista.
 - Se mejoró la accesibilidad en Command Palette añadiendo etiquetas adecuadas, afinando animaciones, mejorando la localización y corrigiendo problemas relacionados con a11y.
 - Se adaptó el soporte para formatos personalizados al complemento de Fecha y Hora, se reorganizaron y limpiaron los ajustes, se mejoraron los mensajes de error y se corrigieron bloqueos en casos límite para un comportamiento más robusto y fácil de usar. Gracias [@htcfreek](https://github.com/htcfreek)!
 - Se añadió un elemento de respaldo para comandos del sistema.
 - Se corrigió un error en Windows System Command donde el mensaje de tecla mostraba incorrectamente "Empty" para la acción "Abrir papelera de reciclaje". Gracias [@jironemo](https://github.com/jironemo)!
 - Se solucionó un problema donde la lista 'más comandos' mostraba comandos que no debían ser visibles. Gracias [@davidegiacometti](https://github.com/davidegiacometti)!
 - Se solucionó un problema donde la vista de detalles en Command Palette mostraba un icono sobredimensionado y texto desalineado, alineándolo con el comportamiento de búsqueda de Windows.
 - Se corrigió un error donde el contenido de pantalla vacío y los comandos de la barra de comandos se cortaban al usar etiquetas largas, garantizando el diseño y la visibilidad adecuados.
 - Se mejoró la integración de CmdPal con WinGet corrigiendo la visualización de la versión para los paquetes instalados, permitiendo actualizaciones con iconos y migrando la API de vista previa de winget a una versión estable.
 - Se solucionó un error donde los comandos para ContentPage no se actualizaban hasta después de salir, asegurando que los menús contextuales se inicialicen completamente cuando cambian.
 - Se añadió soporte de respaldo a la extensión TimeDate, permitiendo consultas directas de fecha/hora sin preseleccionar el comando.
 - Se añadió la importación de Common.Dotnet.AotCompatibility.props en varios archivos de proyecto CmdPal para mejorar el soporte de compilación AOT.
 - Se solucionó un bloqueo en la configuración de CmdPal causado por una HotKey nula cuando settings.json falta o no tiene una tecla definida. Gracias [@davidegiacometti](https://github.com/davidegiacometti)!
 - Se añadió soporte para menús contextuales anidados y filtrables en CmdPal, incluyendo un cuadro de búsqueda para mantener el comportamiento de foco.
 - Se refactorizaron las clases de CmdPal para mejorar la serialización JSON y se introdujeron nuevos contextos de serialización para un mejor rendimiento y mantenibilidad.
 - Se añadió soporte para compilación anticipada (AoT).
 - Se añadió un mecanismo de reintento para el lanzamiento de CmdPal.
 - Se eliminaron algunos archivos no utilizados de CmdPal.Common para simplificar el código y facilitar su marcado como compatible con AoT.
 - Se solucionó un error donde una condición de carrera en la actualización de SearchText causaba que el cursor en el cuadro de entrada saltara automáticamente al final de la línea, asegurando que SearchText solo se actualice después de que haya cambiado realmente.
 - Se añadió soporte para buscar cualquier archivo en el comando de respaldo.
 - Se limpió el código relacionado con AoT para evitar operaciones duplicadas durante las pruebas.
 - Se redujo el tiempo de carga de CmdPal paralelizando el inicio de extensiones y añadiendo límites de tiempo para evitar que extensiones problemáticas bloqueen a otras.
 - Se mejoró el comportamiento de la interfaz de usuario ocultando el panel de detalles cuando la lista se vacía, evitando estados visuales inconsistentes.
 - Se añadió soporte para desactivar el comando de respaldo en CmdPal cuando no se encuentra un comando coincidente, asegurando un comportamiento de recarga más limpio.
 - Se solucionó una fuga en la plantilla de extensión CmdPal corrigiendo el uso incorrecto de ComServer.
 - Se evitó que la ventana de CmdPal se maximizara al hacer doble clic en la barra de título para mantener el comportamiento de ventana previsto. Gracias [@davidegiacometti](https://github.com/davidegiacometti)!
 - Se corrigió un problema donde la interfaz de configuración se abría demasiado pequeña haciendo que las dimensiones de la ventana sean conscientes de DPI y aplicando un ancho y alto mínimos mediante WinUIEx.
 - Se corrigió el destello blanco y problemas de animación en CmdPal ocultando la ventana en lugar de cerrarla.
 - Se solucionó un error donde todos los ajustes de extensiones se obtenían al inicio cargando los ajustes bajo demanda, reduciendo la sobrecarga de inicialización.
 - Se añadió soporte para proteger CmdPal de bloqueos en fallos de análisis de tarjetas adaptativas (Adaptive Card).
 - Se reemplazó shell:AppsFolder con activación por URI en CmdPal para mejorar la fiabilidad.
 - Se añadió la posibilidad de abrir la configuración de CmdPal desde la Configuración de PowerToys.
 - Se añadió la posibilidad de que CmdPal observe y actualice dinámicamente los detalles de las extensiones siguiendo los cambios de propiedad en el elemento seleccionado.
 - Se actualizó la versión del toolkit utilizada en la plantilla de extensión de CmdPal a la 0.2.0.

### Redimensionador de Imágenes

 - Se solucionó un problema donde al eliminar una configuración predefinida de Image Resizer se eliminaba la incorrecta.

### Administrador de Teclado

 - Se solucionó un problema donde una tecla modificadora, cuando se configuraba sin especificar izquierda o derecha, se quedaba atascada debido a un manejo incorrecto, haciendo seguimiento de las teclas presionadas y enviando la tecla correcta. Gracias [@mantaionut](https://github.com/mantaionut)!

### PowerRename

 - Se mejoraron las capacidades de formato de hora de PowerRename añadiendo patrones de formato de hora de 12 horas con soporte AM/PM. Gracias [@bitmap4](https://github.com/bitmap4)!

### PowerToys Run

 - Se añadió soporte para formatos personalizados en el complemento "Hora y Fecha" y se mejoraron los mensajes de error para formatos de entrada no válidos. Gracias [@htcfreek](https://github.com/htcfreek)!
 - Se corrigieron dos bloqueos: uno para WFT en fechas muy tempranas y otro al calcular la semana del mes en fechas muy avanzadas (por ejemplo, 31.12.9999), y se reorganizaron los ajustes de la interfaz. Gracias [@htcfreek](https://github.com/htcfreek)!
 - Se solucionó un problema donde el uso de mayúsculas en el comando causaba fallo al intentar ir al puntero del ratón, resuelto ajustando el comando a minúsculas.
 - Se añadieron detalles de versión a los mensajes de error del complemento para 'Error de carga' y 'Error de inicialización'. Gracias [@htcfreek](https://github.com/htcfreek)!
 - Se mejoró el modelo de resultados añadiendo soporte para evitar el ordenamiento basado en uso, dando mayor control a los desarrolladores de complementos sobre el comportamiento de ordenación. Gracias [@CoreyHayward](https://github.com/CoreyHayward) y [@htcfreek](https://github.com/htcfreek)!

### Quick Accent

 - Se actualizó el mapeo de letras en GetDefaultLetterKeyEPO, reemplazando "ǔ" por "ŭ" para la tecla VK_U para reflejar con precisión la fonética del esperanto. Gracias [@OlegKharchevkin](https://github.com/OlegKharchevkin)!
 - Se solucionó un problema donde Quick Accent no funcionaba correctamente al usar el teclado en pantalla. Gracias [@davidegiacometti](https://github.com/davidegiacometti)!

### Vista previa del registro

 - Se mejoró Registry Preview para soportar pegar claves y valores de registro sin escribir manualmente el encabezado del archivo, y se añadió un nuevo botón para restablecer la aplicación. Gracias [@htcfreek](https://github.com/htcfreek)!

### Configuración

 - Se solucionó un problema donde la aplicación de Configuración mostraba aleatoriamente un icono en blanco en la barra de tareas posponiendo la asignación del icono hasta que la ventana esté activada.
 - Se añadió la capacidad de maximizar la ventana "Novedades" para una experiencia de lectura más cómoda.

### Espacios de trabajo

 - Se corrigieron errores donde los juegos de Steam no se capturaban o lanzaban correctamente actualizando el filtrado de ventanas e integrando el manejo del protocolo URL de Steam.

### Documentación

 - Se añadieron QuickNotes a la documentación de complementos de terceros para PowerToys Run. Gracias [@ruslanlap](https://github.com/ruslanlap)!
 - Se añadieron los complementos Weather y Pomodoro a la documentación de complementos de terceros de PowerToys Run. Gracias [@ruslanlap](https://github.com/ruslanlap)!
 - Se añadió el complemento Linear a la documentación de complementos de terceros de PowerToys Run. Gracias [@vednig](https://github.com/vednig)!
 - Se corrigieron problemas de formato en archivos de documentación y se actualizó la información de colaboradores y miembros del equipo. Gracias [@DanielEScherzer](https://github.com/DanielEScherzer) y [@RokyZevon](https://github.com/RokyZevon)!

### Desarrollo

 - Se actualizó GitHub Action para instalar .NET 9 para soporte de lanzamiento en MSStore.
 - Se actualizó el marcador de posición de versión en bug_report.yml para evitar la versión incorrecta v0.70.0 en informes de problemas.
 - Se actualizó GitHub Action para actualizar actions/setup-dotnet de la versión 3 a la 4 para lanzamiento en MSStore.
 - Se añadió securityContext a los archivos de configuración de WinGet, permitiendo la invocación desde el contexto de usuario y solicitando un único UAC para recursos elevados en un proceso separado. Gracias [@mdanish-kh](https://github.com/mdanish-kh)!
 - Se cambiaron las extensiones de archivos de registro de .txt a .log para soportar asociaciones de archivos adecuadas y compatibilidad con herramientas, y se añadieron registros para Workspace. Gracias [@benwa](https://github.com/benwa)!
 - Se actualizaron las dependencias del marco de pruebas y se alinearon las versiones de los paquetes entre componentes.
 - Se actualizaron las dependencias para corregir vulnerabilidades.
 - Se mejoró la seguridad del repositorio fijando las etiquetas de GitHub Actions y Docker a commits inmutables de longitud completa e integrando el escaneo automatizado de vulnerabilidades de dependencias mediante Dependency Review Workflow. Gracias [@Nick2bad4u](https://github.com/Nick2bad4u)!
 - Se actualizaron las dependencias Boost a una versión más reciente.
 - Se actualizó el toolkit a la última versión, suprimiendo advertencias relacionadas con AoT.
 - Se solucionó un problema donde la falta de firma en archivos recién añadidos causaba fallos de compilación.
 - Se actualizó la canalización de lanzamiento para evitar la publicación de símbolos privados durante 100 años.
 - Se introdujo fuzzing para PowerRename para mejorar la fiabilidad y se añadieron instrucciones para ampliar el fuzzing a otros módulos C++.
 - Se añadió la pre-creación centralizada de carpetas generadas para todos los proyectos .csproj para evitar fallos de compilación.
 - Se actualizó WinAppSDK a la última versión 1.7.
 - Se actualizaron las dependencias Boost a la última versión para el proyecto de Fuzzing de PowerRename.
 - Se actualizó la ruta de área de ADO en tsa.json para resolver errores de canalización TSA causados por una ruta obsoleta.
 - Se inició el soporte AoT para CmdPal con trabajo fundamental en progreso.
  
### Herramientas/General

 - Se añadió soporte para automatizar la creación de informes de errores generando una URL de issue de GitHub pre-rellenada con información del sistema y diagnósticos. Gracias [@donlaci](https://github.com/donlaci)!
 - Se añadieron scripts para compilar localmente el instalador, asegurando que CmdPal también pueda iniciarse en un entorno local.
 - Se eliminó la lógica de exportación de PFX para eliminar el uso de contraseñas codificadas y resolver la advertencia de seguridad de PSScriptAnalyzer.
 - Se añadió un script de PowerShell e integración CI para hacer cumplir el uso coherente de Common.Dotnet.CsWinRT.props en todos los proyectos C# bajo la carpeta src.
   
### Qué se está planificando para la versión 0.92

Para [v0.92][github-next-release-work], trabajaremos en los siguientes puntos:

 - Continuar puliendo Command Palette
 - Nuevas pruebas de automatización de interfaz de usuario
 - Mejoras en las actualizaciones del instalador
 - Actualización de la interfaz del editor de Keyboard Manager
 - Estabilidad / corrección de errores

## Comunidad de PowerToys

El equipo de PowerToys está sumamente agradecido de contar con el [apoyo de una comunidad activa increíble][community-link]. El trabajo que realizan es increíblemente importante. PowerToys no sería ni de lejos lo que es hoy sin su ayuda al reportar errores, actualizar la documentación, guiar el diseño o escribir funciones. Queremos agradecerles y tomarnos el tiempo para reconocer su trabajo. Mes a mes, ayudan directamente a hacer de PowerToys un mejor software.

## Código de conducta

Este proyecto ha adoptado el [Código de Conducta de Código Abierto de Microsoft][oss-conduct-code].

## Declaración de privacidad

La aplicación registra datos diagnósticos básicos (telemetría). Para obtener más información sobre la privacidad y lo que recopilamos, consulte nuestra [documentación de Datos y Privacidad de PowerToys](https://aka.ms/powertoys-data-and-privacy-documentation).

[oss-CLA]: https://cla.opensource.microsoft.com
[oss-conduct-code]: CODE_OF_CONDUCT.md
[community-link]: COMMUNITY.md
[github-release-link]: https://aka.ms/installPowerToys
[microsoft-store-link]: https://aka.ms/getPowertoys
[winget-link]: https://github.com/microsoft/winget-cli#installing-the-client
[roadmap]: https://github.com/microsoft/PowerToys/wiki/Roadmap
[privacy-link]: http://go.microsoft.com/fwlink/?LinkId=521839
[loc-bug]: https://github.com/microsoft/PowerToys/issues/new?assignees=&labels=&template=translation_issue.md&title=
[usingPowerToys-docs-link]: https://aka.ms/powertoys-docs

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---
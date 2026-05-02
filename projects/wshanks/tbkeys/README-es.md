[![Pacto de Colaboradores](https://img.shields.io/badge/Contributor%20Covenant-v2.0%20adopted-ff69b4.svg)](code_of_conduct.md)

# <a name="intro"></a>tbkeys

`tbkeys` es un complemento para Thunderbird que utiliza [Mousetrap](https://craig.is/killing/mice) para asignar secuencias de teclas a comandos personalizados.

## Instalación

- Descargue el archivo tbkeys.xpi desde una de las versiones listadas en la [página de lanzamientos de GitHub](https://github.com/willsALMANJ/tbkeys/releases).
- Abra el Administrador de Complementos en Thunderbird (Herramientas->Complementos).
- Haga clic en el icono de engranaje en la parte superior derecha y elija "Instalar complemento desde archivo..." y luego seleccione el archivo tbkeys.xpi descargado.
- El complemento se actualizará automáticamente desde la página de lanzamientos de GitHub cuando se publiquen futuras actualizaciones.

La versión [tbkeys-lite](#tbkeys-lite) del complemento también puede instalarse desde addons.thunderbird.net buscando "tbkeys-lite" en el administrador de complementos de Thunderbird o descargando el archivo xpi desde [esta página](https://addons.thunderbird.net/en-US/thunderbird/addon/tbkeys-lite/) y siguiendo los pasos anteriores.

## Asignaciones de teclas por defecto

Las asignaciones de teclas por defecto para la ventana principal están modeladas según las asignaciones de teclas de GMail.

| Tecla | Función                                          |
| --- | ------------------------------------------------- |
| c   | Redactar nuevo mensaje                            |
| r   | Responder                                        |
| a   | Responder a todos                               |
| f   | Reenviar                                         |
| #   | Eliminar                                         |
| u   | Actualizar correo. Si hay una pestaña de mensaje abierta, ciérrala. |
| j   | Mensaje siguiente                                |
| k   | Mensaje anterior                                 |
| o   | Abrir mensaje                                    |
| x   | Archivar mensaje                                 |

## Personalización de asignaciones de teclas

Para personalizar las asignaciones de teclas, modifique las entradas de "key bindings" en el panel de preferencias del complemento que puede accederse desde la entrada del complemento en el Administrador de Complementos ("Complementos" en el menú de Thunderbird).
Aquí hay algunas consideraciones al configurar las asignaciones de teclas:

- La entrada "key bindings" debe ser un objeto JSON que mapee las asignaciones de teclas (con la sintaxis de Mousetrap como se describe [aquí](https://craig.is/killing/mice)) a un comando válido (ver la sección [Sintaxis de comandos](#command-syntax)).
- Hay campos separados en la página de preferencias para configurar asignaciones de teclas para la ventana principal de Thunderbird y la ventana de redacción.
  Las asignaciones de teclas no se activan en otras ventanas.
- Las combinaciones de teclas no se activan en los campos de entrada de texto a menos que la primera combinación de teclas incluya un modificador distinto de `shift`.
- La página de preferencias no permitirá enviar JSON no válido, pero no verifica la coherencia de las combinaciones de teclas de otro modo.
- Esta [antigua página wiki sobre Keyconfig](http://kb.mozillazine.org/Keyconfig_extension:_Thunderbird) también tiene algunos comandos que aún son válidos.
- La Caja de Herramientas para Desarrolladores (Herramientas->Herramientas para Desarrolladores->Caja de Herramientas para Desarrolladores en el menú) puede ser útil para explorar la interfaz y encontrar el nombre de un elemento para llamar a una función.
- No se admite definir una secuencia de teclas (es decir, varias teclas sucesivas) donde la primera combinación de la secuencia sea igual a un atajo integrado (como `ctrl+j ctrl+k`).
  Las teclas simples con modificadores pueden mapearse para sobrescribir los atajos integrados pero no secuencias.

### Sintaxis de comandos

Se pueden especificar varios estilos diferentes de comandos para las combinaciones de teclas.
Estos son:

- **Comandos simples**: Estos comandos siguen el formato `cmd:<nombre_comando>` donde `<nombre_comando>` es un comando que Thunderbird puede ejecutar con `goDoCommand()`.
  La mayoría de los nombres de comandos se encuentran en [el archivo principal de conjunto de comandos](https://hg.mozilla.org/comm-central/file/tip/mail/base/content/mainCommandSet.inc.xhtml) del código fuente de Thunderbird.
- **Llamadas simples a funciones**: Estos comandos siguen el formato `func:<nombre_función>` donde `<nombre_función>` es una función definida en el objeto ventana de Thunderbird.
  Esa función se llama sin argumentos.
- **Llamadas a funciones personalizadas**: Estos comandos siguen el formato `tbkeys:<nombre_función>` donde `<nombre_función>` es el nombre de una función personalizada escrita en tbkeys.
  Actualmente, la única función personalizada disponible es `closeMessageAndRefresh` que cierra la pestaña abierta si no es la primera pestaña y luego actualiza todas las cuentas.
  Este comportamiento imita el comportamiento del atajo `u` de GMail.
- **Desasignar combinación**: Estas entradas simplemente contienen el texto `unset`.
  Cuando se activa una combinación `unset`, no ocurre nada.
  Esto puede ser útil para desasignar atajos integrados de Thunderbird que no desea activar por accidente.
- **Mensajes de MailExtension**: Estos comandos siguen el formato `memsg:<IDextensión>:<mensaje>` donde `<IDextensión>` es el ID de la extensión de Thunderbird a la que enviar un mensaje y `<mensaje>` es un mensaje en forma de cadena para enviar a la extensión usando la API `browser.runtime.sendMessage()` de MailExtension.
  Actualmente, solo se admiten mensajes en forma de cadena porque `tbkeys` almacena sus comandos como cadenas, aunque esa restricción podría relajarse en el futuro.
- <a name="eval"></a>**Comandos eval**: Estas entradas pueden contener código javascript arbitrario sobre el cual tbkeys llamará `eval()` cuando se active la combinación.
  Cualquier entrada que no coincida con los prefijos de los otros tipos de comandos se trata como un comando eval.
  **NOTA:** los comandos eval no están disponibles en tbkeys-lite y funcionarán igual que los comandos unset.

## Combinaciones comunes

Aquí algunos ejemplos de comandos eval para combinaciones de teclas comunes:

- **Siguiente pestaña**: `window.document.getElementById('tabmail-tabs').advanceSelectedTab(1, true)`
- **Pestaña anterior**: `window.document.getElementById('tabmail-tabs').advanceSelectedTab(-1, true)`
- **Cerrar pestaña**: `func:CloseTabOrWindow`
- **Desplazar lista de mensajes hacia abajo**: `window.document.getElementById('threadTree').scrollByLines(1)`
- **Desplazar lista de mensajes hacia arriba**: `window.document.getElementById('threadTree').scrollByLines(-1)`
- **Desplazar cuerpo del mensaje hacia abajo**:
  - v115+: `window.gTabmail.currentAboutMessage.getMessagePaneBrowser().contentWindow.scrollBy(0, 100)`
  - v102: `window.document.getElementById('messagepane').contentDocument.documentElement.getElementsByTagName('body')[0].scrollBy(0, 100)`
- **Desplazar el cuerpo del mensaje hacia arriba**:
  - v115+: `window.gTabmail.currentAboutMessage.getMessagePaneBrowser().contentWindow.scrollBy(0, -100)`
  - v102: `window.document.getElementById('messagepane').contentDocument.documentElement.getElementsByTagName('body')[0].scrollBy(0, -100)`
- **Crear nueva carpeta**: `window.goDoCommand('cmd_newFolder')`
- **Suscribirse a un feed**: `window.openSubscriptionsDialog(window.GetSelectedMsgFolders()[0])`

## Desactivar atajos de teclado predeterminados

El botón "Desactivar individuales" en el panel de preferencias puede usarse para desactivar los atajos de tecla simples predeterminados de Thunderbird en la ventana principal.
Esta función establece todos los atajos de tecla simples predeterminados de Thunderbird en `desactivado` a menos que ya estén configurados en las preferencias de tbkeys (es decir, no sobrescribirá las configuraciones existentes de tbkeys para atajos simples).

## <a name="tbkeys-lite"></a>tbkeys y tbkeys-lite

tbkeys-lite es una versión de tbkeys con la capacidad de ejecutar javascript arbitrario eliminada.

## Seguridad, privacidad e implementación

Antes de la instalación, Thunderbird mostrará un aviso sobre que la extensión requiere permiso para "Tener acceso completo y sin restricciones a Thunderbird y a su computadora."
La razón de esta solicitud de permiso es que tbkeys debe inyectar un listener de teclas en la interfaz de usuario de Thunderbird para escuchar los atajos de teclado.
Para ello, tbkeys utiliza la interfaz de extensión antigua de Thunderbird que precede a MailExtensions.
Esta interfaz es la que usaban todas las extensiones antes de Thunderbird 68.
Las nuevas APIs de MailExtensions, que proporcionan un control más estricto sobre lo que las extensiones pueden hacer, no cuentan con una API para atajos de teclado.
Si está interesado en que se agregue una API de atajos de teclado a Thunderbird, por favor considere contribuir con código al proyecto.
Quizás [este ticket](https://bugzilla.mozilla.org/show_bug.cgi?id=1591730) en el rastreador de incidencias de Thunderbird podría ser un punto de partida.

Para discutir más a fondo las consideraciones de seguridad relacionadas con tbkeys, es necesario revisar su implementación.
Como se menciona en la [introducción](#intro), tbkeys depende de la biblioteca Mousetrap para gestionar los atajos de teclado.
La mayor parte de la lógica de tbkeys está en [implementation.js](https://raw.githubusercontent.com/wshanks/tbkeys/main/addon/implementation.js), que es un [experimento de MailExtension](https://developer.thunderbird.net/add-ons/mailextensions/experiments).
`implementation.js` configura la API del experimento que puede ser llamada por la MailExtension estándar (de alcance restringido) de tbkeys para enlazar atajos de teclado a funciones (incluyendo una función nula para desactivar atajos) y para enviar mensajes a otras extensiones.
`implementation.js` también carga Mousetrap en cada ventana de Thunderbird, ajusta las condiciones bajo las cuales Mousetrap captura un evento de tecla para tener en cuenta elementos específicos de la interfaz de Thunderbird, y define la función que ejecuta lo que el usuario especifica para cada atajo de teclado.
Eso es todo lo que hace `implementation.js`.
No accede al sistema de archivos local ni a datos de mensajes y no accede a la red.

Uno de los modos de comando que tbkeys soporta es [eval](#eval).
Este modo usa `eval()` para ejecutar código arbitrario proporcionado por el usuario en `implementation.js` con acceso completo a los internos de Thunderbird.
Si no se necesita enlazar a código arbitrario, tal vez se gane algo de seguridad usando [tbkeys-lite](#tbkeys-lite) que no soporta comandos eval.
tbkeys-lite es la versión publicada en la [página de complementos de Thunderbird](https://addons.thunderbird.net/en-US/thunderbird/addon/tbkeys-lite/).
Los complementos publicados allí pasan por una revisión manual independiente.
Tener esa barrera de revisión entre usted y el desarrollador proporciona una capa adicional de seguridad.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-02

---
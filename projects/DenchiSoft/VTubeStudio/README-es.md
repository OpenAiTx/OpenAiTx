# <a href="https://denchisoft.com"><img src="https://raw.githubusercontent.com/DenchiSoft/VTubeStudio/master/Images/vtube_studio_logo_nyan_2.png" width="542" /></a><br> [![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](https://github.com/DenchiSoft/VTubeStudio/blob/master/LICENSE) [![VTube Studio Discord](https://discordapp.com/api/guilds/652602255748497449/widget.png?style=shield)](https://discord.gg/VTubeStudio) [![Stars](https://img.shields.io/github/stars/DenchiSoft/VTubeStudio?style=social)](https://github.com/DenchiSoft/VTubeStudio) [![Twitter Follow](https://img.shields.io/twitter/follow/VTubeStudio.svg?style=social)](https://twitter.com/VTubeStudio)


[![VTube Studio Discord](https://discordapp.com/api/guilds/652602255748497449/widget.png?style=banner2)](https://discord.gg/VTubeStudio)

## ¿Buscas el [Manual de VTube Studio](https://github.com/DenchiSoft/VTubeStudio/wiki)?

Se puede encontrar aquí: https://github.com/DenchiSoft/VTubeStudio/wiki

## ¿Buscas una [lista de Plugins de VTube Studio](https://github.com/DenchiSoft/VTubeStudio/wiki/Plugins)?

Consulta esta página: https://github.com/DenchiSoft/VTubeStudio/wiki/Plugins

## ¿Eres un desarrollador que busca una manera de recibir datos de seguimiento desde la app de iPhone de VTube Studio?

El proceso para solicitar datos de seguimiento desde la app iOS de VTube Studio se describe aquí: https://github.com/DenchiSoft/VTubeStudioBlendshapeUDPReceiverTest

## ¿Eres un desarrollador que quiere aprender a crear Plugins para VTube Studio?

Todo lo que buscas está en esta página. Si tienes alguna pregunta, por favor pregúntala en el [Discord](https://discord.gg/VTubeStudio).

## Contenido

- [Información General](#general-info)
- [Información Legal](#legal-info)
- [Plugins y Ejemplos Disponibles](#available-examples)
- [API de Eventos](#event-api)
- [Detalles de la API](#api-details)
  - [Permisos de la API](#api-permissions)
  - [Descubrimiento del Servidor API (UDP)](#api-server-discovery-udp)
  - [Autenticación](#authentication)
  - [Suscribirse y darse de baja de eventos](#subscribing-to-and-unsubscribing-from-events)
  - [Obtener estadísticas actuales de VTS](#getting-current-vts-statistics)
  - [Obtener lista de carpetas de VTS](#getting-list-of-vts-folders)
  - [Obtener el modelo actualmente cargado](#getting-the-currently-loaded-model)
  - [Obtener una lista de modelos VTS disponibles](#getting-a-list-of-available-vts-models)
  - [Cargar un modelo VTS por su ID](#loading-a-vts-model-by-its-id)
  - [Mover el modelo VTS actualmente cargado](#moving-the-currently-loaded-vts-model)
  - [Solicitar lista de teclas rápidas disponibles en el modelo VTS actual u otro](#requesting-list-of-hotkeys-available-in-current-or-other-vts-model)
  - [Solicitar ejecución de teclas rápidas](#requesting-execution-of-hotkeys)
  - [Solicitar lista de expresiones y sus estados](#requesting-current-expression-state-list)
  - [Solicitar activación/desactivación de expresiones](#requesting-activation-or-deactivation-of-expressions)
  - [Solicitar lista de ArtMeshes en el modelo actual](#requesting-list-of-artmeshes-in-current-model)
  - [Teñir ArtMeshes con color](#tint-artmeshes-with-color)
  - [Obtener color de superposición de iluminación de la escena](#getting-scene-lighting-overlay-color)
  - [Verificar si la cara está actualmente detectada por el rastreador](#checking-if-face-is-currently-found-by-tracker)
  - [Solicitar lista de parámetros de rastreo disponibles](#requesting-list-of-available-tracking-parameters)
  - [Obtener el valor de un parámetro específico, predeterminado o personalizado](#get-the-value-for-one-specific-parameter-default-or-custom)
  - [Obtener el valor de todos los parámetros Live2D en el modelo actual](#get-the-value-for-all-live2d-parameters-in-the-current-model)
  - [Agregar nuevos parámetros de rastreo ("parámetros personalizados")](#adding-new-tracking-parameters-custom-parameters)
  - [Eliminar parámetros personalizados](#delete-custom-parameters)
  - [Ingresar datos para parámetros predeterminados o personalizados](#feeding-in-data-for-default-or-custom-parameters)
  - [Obtener configuraciones físicas del modelo VTS actualmente cargado](#getting-physics-settings-of-currently-loaded-vts-model)
  - [Sobrescribir configuraciones físicas del modelo VTS actualmente cargado](#overriding-physics-settings-of-currently-loaded-vts-model)
  - [Obtener y/o configurar ajustes de NDI](#get-and-set-ndi-settings)
  - [Solicitar lista de ítems disponibles o ítems en la escena](#requesting-list-of-available-items-or-items-in-scene)
  - [Cargar ítem en la escena](#loading-item-into-the-scene)
  - [Remover ítem de la escena](#removing-item-from-the-scene)
  - [Controlar ítems y animaciones de ítems](#controling-items-and-item-animations)
  - [Mover ítems en la escena](#moving-items-in-the-scene)
  - [Establecer orden de clasificación dentro del modelo para ítems](#set-item-within-model-sorting-order)
  - [Pedir al usuario que seleccione ArtMeshes](#asking-user-to-select-artmeshes)
  - [Fijar ítems al modelo](#pin-items-to-the-model)
  - [Obtener lista de efectos de postprocesamiento y su estado](#get-list-of-post-processing-effects-and-state)
  - [Configurar efectos de postprocesamiento](#set-post-processing-effects)
  
## Información General

VTube Studio tiene una **API pública**. Esto significa que puedes escribir plugins/scripts que pueden activar teclas rápidas, alimentar datos de rastreo facial, cargar ítems, cargar modelos, recibir notificaciones de eventos diversos, teñir ArtMeshes del modelo y mucho más.

Si desarrollas un plugin o cualquier aplicación que pueda usarse con VTube Studio, por favor abre un PR y lo añadiré a la lista en esta página.

## Información Legal

Eres libre de escribir, publicar y vender cualquier plugin que desees para VTube Studio. No se requiere permiso y no hay tarifas de licencia ni regalías.

## Ejemplos Disponibles

Si eres usuario de VTube Studio y buscas plugins que puedas usar, revisa la [página wiki de la lista de plugins](https://github.com/DenchiSoft/VTubeStudio/wiki/Plugins).

Si eres un desarrollador que busca ejemplos/bibliotecas para facilitar la integración de la API de VTube Studio en tu aplicación, por favor echa un vistazo a la siguiente tabla.

:warning: **Si hiciste algo que quieres que se incluya aquí, ¡abre un pull request con la tabla modificada!** :warning:

| Plugin | Desarrollador | Tipo | Explicación |
| --- | --- | --- | --- |
| [Cheers Bot](https://cheers.hawk.bar/) | [Hawkbar](https://twitter.com/HawkbarGaming) | App | Una plataforma de integración web para Twitch que puede activar acciones en VTube Studio cuando los espectadores canjean puntos de canal, entre muchas otras funciones. |
| [VTubeStudioJS](https://github.com/Hawkbat/VTubeStudioJS) | [Hawkbar](https://twitter.com/HawkbarGaming) | Biblioteca | Una biblioteca JavaScript para ser usada por otros autores de plugins que implementa la API WebSocket de VTube Studio. Compatible con NodeJS y el navegador. |
| [VTS Linker - SMB1](https://github.com/Renpona/VTStudio-Linker-SMB1) | [Renpona](https://twitter.com/renpona) | Ejemplo | Un prototipo para leer datos de una copia emulada de Super Mario Bros, y usar esos datos para mover y recolorear automáticamente un modelo Live2D en VTS según lo que ocurre en el juego. |
| [VTchaos](https://github.com/Raelice/VTchaos) | [Raelice](https://twitter.com/theraelice) | App | Un programa que lee chats de YouTube y Twitch para realizar funciones como cambio de modelo, rotación, atajos y movimiento en VTube Studio mediante comandos simples en el chat. |
| [Mix It Up](https://mixitupapp.com/) | [Mix It Up](https://twitter.com/mixitupapp) | App | Bot de software para streaming para chat, eventos y otras funciones increíbles. |
| [VsPyYt](https://github.com/mlo40/VsPyYt) | [emlo40](https://emlo40.com) | App/Framework | VsPyYt es una aplicación de línea de comandos que puede leer el chat de YouTube y ejecutar comandos guardados en token.json. También puede usarse como base para programas en Python que interactúan con VTube Studio. |
| [VTS-Sharp](https://github.com/FomTarro/VTS-Sharp) | [Skeletom](https://www.twitter.com/FomTarro) | Biblioteca | Una biblioteca Unity/C# para ser usada por otros autores de plugins que implementa la API WebSocket de VTube Studio. |
| [node-red-contrib-vts](https://github.com/eslym/node-red-contrib-vts) | [0nepeop1e](https://github.com/eslym) | Biblioteca | Un paquete de biblioteca que provee un nodo para Node-RED para integrarse con VTube Studio. |
| [VTS Mod](https://github.com/MechaWolfVtuberShin/VTS-Mod/releases/tag/vts-mod) | [MechaWolfVtuber_Shin](https://github.com/MechaWolfVtuberShin) | App | Un programa que permite a los usuarios cambiar el color de la superficie del modelo incluyendo RGB. También puede cambiar la rotación del modelo. |
| [Tie Tools: VTS Color Editor](https://tie-tools.tiberiusx.me) | [Prof. Tiberius](https://www.twitter.com/prof_tiberius) | App | Aplicación web que ofrece control detallado de los colores y opacidad de partes específicas de tu modelo. |
| [vtubestudio-rs](https://github.com/walfie/vtubestudio-rs) | [Walfie](https://www.twitter.com/walfieee) | Biblioteca | Una biblioteca Rust para ser usada por otros autores de plugins que implementa la API WebSocket de VTube Studio. |
| [vts-heartrate](https://skeletom-ch.itch.io/vts-heartrate) | [Skeletom](https://www.twitter.com/FomTarro) | App | Un plugin que conecta datos de ritmo cardíaco en tiempo real a VTube Studio, permitiendo tintado dinámico del modelo y proporcionando parámetros personalizados basados en el pulso. |
| [vts-chameleon](https://satetsu888.github.io/vts-chameleon/) | [satetsu888](https://www.twitter.com/satetsu888) | App | Un plugin para aplicar tintes de color. Puedes experimentar cambiando tonos de color en cabello, piel, uniforme, etc. de tus modelos. |
| [ViewLink](https://kawaentertainment.itch.io/viewlink) | [KawaEntertainment](https://twitter.com/kawa_entertain) | App | ¿Eres un VTuber que quiere hacer streaming de juegos VR pero solo tiene un modelo Live2D? Con ViewLink, tu avatar Live2D puede reaccionar al juego VR sin configuraciones complejas ni hardware adicional. |
| [VTS Desktop Audio](https://lualucky.itch.io/vts-desktop-audio-plugin) | [Lua Lucky](https://twitter.com/LuaVLucky) | App | Un plugin para usar audio de escritorio como parámetros de entrada en VTS. |
| [pyvts](https://github.com/Genteki/pyvts) | [Genteki](https://github.com/Genteki) | Biblioteca | Una biblioteca python para interactuar con la API de VTube Studio. |
| [DSYS: Dummy System](https://github.com/chuigda/Project-WG/tree/master/extra/dsys) | [Chuigda](https://github.com/chuigda) | App | Un plugin simple para grabar/reproducir/semi-pilotar parámetros del modelo en VTS. |
| [SAMMIVtubeStudioExtension](https://github.com/HueVirtualCreature/SAMMIVtubeStudioExtension) | [hue](https://twitter.com/Hue_SwordDevil) | Plugin | Un plugin para la herramienta de automatización de streams llamada [SAMMI](https://sammi.solutions/) |
| [Streamer.bot](https://streamer.bot) | [Streamer.bot](https://streamer.bot) | App | Software avanzado de streaming multiplataforma con una [integración oficial con VTubeStudio](https://docs.streamer.bot/guide/integrations/vtube-studio) |
| [coovts](https://github.com/lgc2333/coovts) | [LgCookie](https://github.com/lgc2333) | Biblioteca | Otra biblioteca para crear plugins de VTube Studio con Python (en desarrollo temprano). Soporta hints de tipos completos \| Diseño asíncrono \| Validación de datos basada en Pydantic |
| [VTS Terminal](https://www.nekomaido.com/plugin/vts-terminal) | [Neko Maido](https://www.nekomaido.com) | App | Un plugin que provee muchas utilidades, puede activar atajos, ajustar la posición y efectos visuales del modelo, y generar un manual PDF para tu modelo Live2D. |

# API de Eventos

Hay otra página wiki que describe la **API de Eventos**, la cual puedes usar para suscribirte a eventos que ocurren en VTube Studio, como la carga de modelos o la ejecución de atajos. Por favor, consulta la página sobre eventos [aquí mismo](Events/).


# Detalles de la API

El servidor websocket de VTube Studio corre en `ws://localhost:8001`. Este es el valor por defecto, pero los usuarios también pueden cambiar el puerto en la aplicación. Los websockets en general soportan mensajes `binarios` y `texto`. VTube Studio siempre responderá con mensajes `texto` y se recomienda también enviar mensajes `texto` a la API. También puedes enviar mensajes `binarios`, pero si lo haces, asegúrate que estén codificados en UTF-8.

Si tu plugin no puede conectarse al servidor websocket, dile a los usuarios que verifiquen si el puerto es correcto o si hay configuraciones de firewall/antivirus que puedan impedir la conexión. Lo más importante es que les pidas que `"Permitan el acceso a la API de Plugins"` en VTube Studio. Es una opción en la página de configuración principal de VTS.
También debes asegurarte de que tu plugin soporte configurar el puerto usado para la conexión.

Si puede conectarse, lo primero que puede intentar es verificar el estado de su sesión.

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "MyIDWithLessThan64Characters",
	"messageType": "APIStateRequest"
}
```

**`RESPUESTA`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"messageType": "APIStateResponse",
	"requestID": "MyIDWithLessThan64Characters",
	"data": {
		"active": true,
		"vTubeStudioVersion": "1.9.0",
		"currentSessionAuthenticated": false
	}
}
```
Cada solicitud debe contener `"apiName" : "VTubeStudioPublicAPI"` y la versión de API utilizada, que será `"1.0"` en el momento del primer lanzamiento.  
Esta versión de la API permanecerá igual hasta que se realicen cambios incompatibles en el comportamiento o en las cargas útiles. Esto significa que se puede añadir nueva funcionalidad a la API (incluidos nuevos campos en cargas útiles existentes) sin incrementar la versión. Asegúrate de que tu aplicación pueda manejar esto y no falle si encuentra campos desconocidos durante la deserialización.  

Un ejemplo de un cambio incompatible sería renombrar un campo existente o eliminarlo por completo de la carga útil. Si se realizan cambios incompatibles, la versión de la API se incrementará para ellos, de modo que las APIs antiguas puedan seguir usándose tal como están.  

Puedes añadir el campo `"requestID"` a cada solicitud. Esto es opcional pero recomendado, ya que te permite identificar las respuestas a tus solicitudes.  
Este ID también se usará para registrar la solicitud en los registros de VTube Studio junto con cualquier error. Si algo sale mal, puedes usar esto como referencia para revisar cualquier error relacionado con esta solicitud en los registros.  

Puedes usar el mismo ID o IDs diferentes para cada solicitud. Si se proporciona, los IDs solo deben contener caracteres ASCII y tener una longitud de al menos 1 y como máximo 64 caracteres.  
Si no añades el campo `"requestID"`, VTube Studio añadirá un UUID generado aleatoriamente para la solicitud y lo devolverá con la respuesta.  

El campo `"currentSessionAuthenticated"` te indicará si la sesión actual ya ha sido autenticada.  

Todos los posibles IDs de error están listados en la página [ErrorsID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs).  

Una vez conectado, el cliente puede consultar información sobre el estado actual de la aplicación en cualquier momento.  

## Permisos de la API  

Cierta funcionalidad ofrecida por la API de VTube Studio está bloqueada detrás de **permisos** adicionales que deben ser solicitados por el plugin después de autenticarse. Al igual que los permisos en iOS y Android, esto es para asegurar que los usuarios entiendan cuando los plugins usan funcionalidades que podrían considerarse riesgosas o potencialmente peligrosas, como cargar imágenes arbitrarias como elementos.  

Al solicitar un permiso, se muestra una ventana emergente al usuario explicando para qué sirve el permiso. El usuario puede entonces elegir concederlo o denegarlo. Para más información sobre cómo solicitar permisos y para qué los necesitas, consulta la [página de permisos](Permissions/).  

[![Pantalla de solicitud de permiso de VTube Studio](/Images/vts_api_permissions_1_transparent.png)](Permissions/)  

## Descubrimiento del Servidor API (UDP)  

VTube Studio también transmite el estado de la API en la red local vía UDP en el puerto 47779. Esto se hace una vez cada dos segundos, incluso si el usuario ha desactivado la API.  
El `instanceID` es un ID aleatorio que se genera para una instancia de VTube Studio cuando se inicia. No cambia mientras esta instancia esté en ejecución, por lo que dos instancias de VTube Studio tendrán IDs diferentes.  

El `windowTitle` es el texto del título de la ventana. En Windows, esto será diferente para distintas instancias de VTS. Cuando se inician más de una instancia, la primera tendrá el título `VTube Studio`, la segunda instancia tendrá el título `VTube Studio Window 2` y así sucesivamente. En macOS, todas las instancias tendrán el título `VTube Studio`



```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1630159656406,
	"messageType": "VTubeStudioAPIStateBroadcast",
	"requestID": "VTubeStudioAPIStateBroadcast",
	"data": {
		"active": false,
		"port": 8001,
		"instanceID": "93aa0d0494304fddb057ae8a295c4e59",
		"windowTitle": "VTube Studio"
	}
}
```

## Autenticación

Antes de usar la API, debes autenticarte una vez. Para ello, tendrás que proporcionar el nombre de tu plugin y el nombre del desarrollador. Ambos deben tener entre 3 y 32 caracteres.

Esto se realiza solicitando un token para tu plugin. Envía la siguiente solicitud:

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "AuthenticationTokenRequest",
	"data": {
		"pluginName": "My Cool Plugin",
		"pluginDeveloper": "My Name",
		"pluginIcon": "iVBORw0.........KGgoA="
	}
}
```

Si el usuario ha activado el acceso API, esto desencadenará una ventana emergente dentro de VTS preguntando al usuario si desea permitir que el plugin `"My Cool Plugin"` de `"My Name"` controle VTube Studio. `"pluginIcon"` se puede agregar opcionalmente. Esto debe ser una imagen PNG o JPG codificada en base64 con las dimensiones exactas de 128x128 píxeles. Si la añades, el ícono se usará en la ventana emergente de solicitud de acceso al plugin mostrada al usuario. Si hacen clic en "Permitir", recibirás la siguiente respuesta:

**`RESPONSE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "AuthenticationTokenResponse",
	"data": {
		"authenticationToken": "adcd-123-ef09-some-token-string-abcd"
	}
}
```

El campo `"authenticationToken"` contiene una cadena ASCII que servirá como el token para autenticarse con la API. Tiene una longitud máxima de 64 caracteres.
Si deniegan el acceso, recibirá el siguiente error:

**`RESPUESTA`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "APIError",
	"data": {
		"errorID": 50,
		"message": "User has denied API access for your plugin."
	}
}
```
Los usuarios pueden revocar el acceso API de tu plugin en cualquier momento desde VTube Studio. Si lo hacen, también recibirás este error al intentar enviar cualquier solicitud. En este caso, puedes intentar reautenticarte.

Solo necesitas obtener el token una vez. Con este token, ahora puedes autenticarte para esta sesión. En la siguiente sesión (por ejemplo, cuando se reinicie VTS o tu plugin tenga que reconectarse a VTS por alguna razón), puedes usar el mismo token para autenticarte de nuevo y así no tendrás que enviar las solicitudes para obtener un token otra vez, por lo que al usuario solo se le pedirá permiso para tu plugin una vez.

Para autenticarte en una sesión, envía la siguiente solicitud con tu token:

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "AuthenticationRequest",
	"data": {
		"pluginName": "My Cool Plugin",
		"pluginDeveloper": "My Name",
		"authenticationToken": "adcd-123-ef09-some-token-string-abcd"
	}
}
```
`"pluginName"` y `"pluginDeveloper"` deben coincidir con los valores que usaste al solicitar el token, de lo contrario la solicitud de autenticación fallará.

Si el token es válido y el acceso a la API no ha sido revocado por el usuario, obtendrás la siguiente respuesta:

**`RESPUESTA`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "AuthenticationResponse",
	"data": {
		"authenticated": true,
		"reason": "Token valid. The plugin is authenticated for the duration of this session."
	}
}
```

Felicidades, estás autenticado y puedes usar la API de VTube Studio.

Si faltan campos obligatorios, recibirás una respuesta de error. Si todos los campos están presentes y correctamente formateados pero el token es inválido o ha sido revocado por el usuario, se devolverá `"authenticated"` como `false`.

**Nota sobre el campo `data`:** Algunas solicitudes incluyen un campo objeto JSON `data` y otras no. Para facilitarte las cosas, también puedes incluir este campo en solicitudes que no lo requieran. Simplemente será ignorado por VTube Studio, incluso si lo dejas vacío o lo configuras como `null`/`undefined`. VTube Studio devolverá este campo con cada solicitud para facilitar la deserialización para tu plugin. Si la respuesta no tiene datos, el campo contendrá un objeto JSON vacío.

**Nota sobre el campo `timestamp`:** Todas las respuestas también tienen un campo `"timestamp"` que contiene la marca de tiempo UNIX en milisegundos en que se procesó tu solicitud. Puedes incluir un campo `"timestamp"` en tus solicitudes, pero será ignorado.

## Suscribirse y darse de baja de [eventos](Events/)

En versiones anteriores de la API, la información como el modelo cargado o los elementos tenía que ser consultada repetidamente por los plugins. Ahora, VTube Studio soporta suscribirse a **"eventos"**, lo que hará que VTube Studio te envíe mensajes cada vez que suceda algo relevante para tu plugin. Los eventos incluyen recibir notificaciones cuando se cargan elementos, cuando se pierde/recupera el seguimiento, cuando se hace clic en el modelo y muchos más.

Por favor, consulta la página sobre eventos [justo aquí](Events/).

## Obtener estadísticas actuales de VTS

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "StatisticsRequest"
}
```
**`RESPUESTA`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "StatisticsResponse",
	"data": {
		"uptime": 1439384,
		"framerate": 73,
		"vTubeStudioVersion": "1.9.0",
		"allowedPlugins": 7,
		"connectedPlugins": 2,
		"startedWithSteam": true,
		"windowWidth": 1031,
		"windowHeight": 812,
		"windowIsFullscreen": false
	}
}
```
`"uptime"` contiene el número de milisegundos desde que VTube Studio se inició. `"framerate"` es el valor actual de FPS de renderizado. `"allowedPlugins"` es el número de plugins que el usuario ha permitido usar en VTube Studio, `"connectedPlugins"` es el número de plugins que están actualmente conectados a la API de VTube Studio. `"startedWithSteam"` es verdadero si la aplicación se inició usando Steam, falso de lo contrario (si se ha utilizado el archivo `.bat` para iniciar VTS sin Steam).

El ancho y alto de la ventana están en píxeles.

## Obtención de la lista de carpetas de VTS

Devuelve el nombre de varias carpetas de VTube Studio. Están en la carpeta `StreamingAssets` dentro de los archivos del juego.

**`REQUEST`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "VTSFolderInfoRequest"
}
```
**`RESPUESTA`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "VTSFolderInfoResponse",
	"data": {
		"models": "Live2DModels",
		"backgrounds": "Backgrounds",
		"items": "Items",
		"config": "Config",
		"logs": "Logs",
		"backup": "Backup"
	}
}
```

## Obtener el modelo cargado actualmente

**`SOLICITUD`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "CurrentModelRequest"
}
```
**`RESPUESTA`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "CurrentModelResponse",
	"data": {
		"modelLoaded": true,
		"modelName": "My Currently Loaded Model",
		"modelID": "UniqueIDToIdentifyThisModelBy",
		"vtsModelName": "Model.vtube.json",
		"vtsModelIconName": "ModelIconPNGorJPG.png",
		"live2DModelName": "Model.model3.json",
		"modelLoadTime": 3021,
		"timeSinceModelLoaded": 419903,
		"numberOfLive2DParameters": 29,
		"numberOfLive2DArtmeshes": 136,
		"hasPhysicsFile": true,
		"numberOfTextures": 2,
		"textureResolution": 4096,
		"modelPosition": {
			"positionX": -0.1,
			"positionY": 0.4,
			"rotation": 9.33,
			"size": -61.9
		}
	}
}
```
`"modelLoaded"` será `true` si un modelo está actualmente cargado. Si no hay ningún modelo cargado o un modelo está en proceso de carga, esto será falso. En este caso, todos los demás valores estarán vacíos (o cero en caso de enteros).

`"modelLoadTime"` es el tiempo en milisegundos que tomó cargar el modelo actual. `"timeSinceModelLoaded"` contiene el tiempo en milisegundos desde que el modelo fue cargado.

`"vtsModelIconName"` contiene el nombre del ícono usado para este modelo en la barra de selección de modelos en VTube Studio. Si el modelo no tiene ícono asignado, esto será una cadena vacía. Todos los nombres de archivos devueltos en esta solicitud son relativos a la carpeta respectiva del modelo.

El arreglo `"modelPosition"` contiene la posición actual del modelo, rotación y tamaño. Para más información sobre cómo interpretar estos valores, consulte `MoveModelRequest`.

## Obtener una lista de modelos VTS disponibles

**`REQUEST`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "AvailableModelsRequest"
}
```

**`RESPUESTA`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "AvailableModelsResponse",
	"data": {
		"numberOfModels": 2,
		"availableModels": [
			{
				"modelLoaded": false,
				"modelName": "My First Model",
				"modelID": "UniqueIDToIdentifyThisModelBy1",
				"vtsModelName": "Model_1.vtube.json",
				"vtsModelIconName": "ModelIconPNGorJPG_1.png"
			},
			{
				"modelLoaded": true,
				"modelName": "My Second Model",
				"modelID": "UniqueIDToIdentifyThisModelBy2",
				"vtsModelName": "Model_2.vtube.json",
				"vtsModelIconName": "ModelIconPNGorJPG_1.png"
			}
		]
	}
}
```
`"modelLoaded"` es `true` si el modelo respectivo está actualmente cargado en VTube Studio, `false` en caso contrario. 

## Cargando un modelo de VTS por su ID

**`REQUEST`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ModelLoadRequest",
	"data": {
		"modelID": "UniqueIDOfModelToLoad"
	}
}
```
**`RESPUESTA`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ModelLoadResponse",
	"data": {
		"modelID": "UniqueIDOfModelThatWasJustLoaded"
	}
}
```

Esto puede fallar y devolver un error si la aplicación está actualmente en un estado donde no se puede cargar/descargar ningún modelo. Esto incluye tener ventanas de configuración abiertas o una operación de carga de modelo ya en curso. También hay un tiempo de espera global de 2 segundos para esta solicitud.

Si se pasa un ID de modelo vacío, se descargará el modelo actualmente cargado (no hará nada si no hay ningún modelo cargado).

## Mover el modelo VTS cargado actualmente

Si un modelo está cargado, esto permite cambiar su posición, rotación y tamaño. Si no hay ningún modelo cargado, esto devolverá un error, consulte [ErrorsID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)

Los campos requeridos en esta solicitud son `"timeInSeconds"` y `"valuesAreRelativeToModel"`. `"timeInSeconds"` es el tiempo en segundos que debe durar el movimiento y tiene que ser un valor flotante entre 0 y 2. Si se establece en 0, el modelo aparecerá instantáneamente en la posición dada. Un valor mayor hará que el modelo se mueva, rote y crezca/encoga suavemente a la posición dada (desvaneciéndose dentro/fuera). Mientras el movimiento está en curso, el usuario no puede mover el modelo manualmente arrastrándolo. Esto será posible de nuevo aproximadamente medio segundo después de que el modelo haya terminado de moverse al destino.

Se pueden enviar solicitudes `MoveModelRequest` subsecuentes sin esperar a que la en curso termine. Si hay una en curso, será interrumpida y reemplazada por la nueva. Incluso puedes tomar control completo del movimiento enviando una solicitud en cada frame con 0 como `"timeInSeconds"`.

El `"size"` se da como un flotante entre -100 (más pequeño) y +100 (más grande). Para `"positionX"`, `"positionY"` y `"rotation"`, consulte la siguiente imagen:

#### El Sistema de Coordenadas de VTS
![El Sistema de Coordenadas de VTS](/Images/coordinate_explanation.png)

Los números en los gatos representan las coordenadas **[X/Y]** que puedes pasar usando `"positionX"` y `"positionY"`. Por ejemplo, enviar [0/0] posicionará el centro del modelo en el centro de la pantalla. Lo que es el "centro del modelo" puede configurarse libremente en Live2D Cubism y puede variar entre modelos. Por supuesto, también puedes enviar valores mucho mayores/menores para mover el modelo fuera de la pantalla. `"positionX"` y `"positionY"` deben estar entre -1000 y 1000.

Los números alrededor del círculo representan los ángulos que puedes configurar usando `"rotation"`. Los valores para este parámetro deben estar entre -360 y 360. Nota cómo hay dos representaciones para cada ángulo: positivo al rotar en el sentido de las agujas del reloj, negativo al rotar en sentido contrario. Cuál uses depende de ti, no hay diferencia. Cuando envíes una `CurrentModelRequest`, la respuesta también contendrá la posición/rotación/tamaño del modelo. En esta respuesta, el ángulo siempre se representará en la notación positiva.

No tienes que proporcionar todos los valores en la solicitud. Por ejemplo, podrías proporcionar solo posiciones o solo una rotación o cualquier otra combinación. Todos los valores que no se incluyan en la solicitud serán ignorados al establecer la posición/rotación/tamaño. De esta forma, podrías por ejemplo cambiar solo la coordenada X del modelo dejando todo lo demás como está.

Si `"valuesAreRelativeToModel"` está establecido en `false`, los valores de tu solicitud serán tomados como valores absolutos y el modelo se moverá a esa posición. Si `"valuesAreRelativeToModel"` está establecido en `true`, los valores se consideran relativos a la posición actual del modelo. Supongamos que lo configuras en `true` y solo incluyes una rotación de `10` en tu solicitud. Eso rotaría el modelo 10 grados en sentido horario, desde la rotación en la que está ahora mismo sin tocar la posición ni el tamaño en absoluto. Esto puede ser muy útil para implementar efectos que deben mover el modelo en su lugar, como sacudirlo independientemente de dónde esté en la pantalla.

Si quieres mover el modelo a una posición fija en píxeles o por una cierta cantidad de píxeles, tendrás que calcular las coordenadas respectivas tú mismo. Puedes hacerlo obteniendo el ancho y alto de la ventana en píxeles usando la `StatisticsRequest`.

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "MoveModelRequest",
	"data": {
		"timeInSeconds": 0.2,
		"valuesAreRelativeToModel": false,
		"positionX": 0.1,
		"positionY": -0.7,
		"rotation": 16.3,
		"size": -22.5
	}
}
```
**`RESPUESTA`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "MoveModelResponse",
	"data": { }
}
```
## Solicitud de lista de teclas rápidas disponibles en el modelo VTS actual u otro

**`SOLICITUD`**



```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "HotkeysInCurrentModelRequest",
	"data": {
		"modelID": "Optional_UniqueIDOfModel",
		"live2DItemFileName": "Optional_Live2DItemFileName"
	}
}
```

El `"modelID"` (y el objeto `"data"` en general aquí) es opcional. Si no se proporciona, se devuelven las teclas rápidas para el modelo actual. Si se proporciona el ID del modelo, se devuelven las teclas rápidas del modelo con el ID proporcionado. Si no se encuentra ningún modelo con ese ID, se devuelve un error (ver [ErrorID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs), `ModelIDNotFound`).

Esto también puede devolver las teclas rápidas de cualquier elemento Live2D disponible. Para ello, solo pasa el nombre del archivo del elemento en el campo `"live2DItemFileName"`. Puedes obtener los nombres de archivo (únicos) de todos los elementos Live2D disponibles usando el `ItemListRequest`.

Si se proporcionan tanto `"modelID"` como `"live2DItemFileName"`, solo se usa `"modelID"` y el otro campo será ignorado.

**`RESPONSE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "HotkeysInCurrentModelResponse",
	"data": {
		"modelLoaded": true,
		"modelName": "My Currently Loaded Model",
		"modelID": "UniqueIDOfModel",
		"availableHotkeys": [
			{
				"name": "My first hotkey",
				"type": "ToggleExpression",
				"description": "Toggles an expression",
				"file": "myExpression_1.exp3.json",
				"hotkeyID": "SomeUniqueIdToIdentifyHotkeyWith1",
				"keyCombination": [],
                		"onScreenButtonID": 8
			},
			{
				"name": "My second hotkey",
				"type": "TriggerAnimation",
				"description": "Triggers an animation",
				"file": "myAnimation.motion3.json",
				"hotkeyID": "SomeUniqueIdToIdentifyHotkeyWith2",
				"keyCombination": [],
                		"onScreenButtonID": -1
			},
			{
				"name": "My third hotkey",
				"type": "ChangeVTSModel",
				"description": "Changes the VTS model",
				"file": "someOtherModel.vtube.json",
				"hotkeyID": "SomeUniqueIdToIdentifyHotkeyWith3",
				"keyCombination": [],
                		"onScreenButtonID": -1
			},
			{
				"name": "My fourth hotkey",
				"type": "MoveModel",
				"description": "Moves the Live2D model",
				"file": "",
				"hotkeyID": "SomeUniqueIdToIdentifyHotkeyWith4",
				"keyCombination": [],
                		"onScreenButtonID": -1
			},
			{
				"name": "My fifth hotkey",
				"type": "Unset",
				"description": "No action set for hotkey",
				"file": "",
				"hotkeyID": "SomeUniqueIdToIdentifyHotkeyWith5",
				"keyCombination": [],
                		"onScreenButtonID": 5
			}
		]
	}
}
```
Si no se especificó un ID de modelo en la solicitud y no hay ningún modelo cargado, `"modelLoaded"` será falso y el arreglo `"availableHotkeys"` estará vacío. Si se especificó un ID, el campo `"modelLoaded"` será `true` o `false` dependiendo de si el modelo con el ID dado está actualmente cargado.

El campo `"file"` contiene el nombre del archivo de expresión/animación/modelo para las teclas rápidas de tipo `TriggerAnimation`, `ChangeIdleAnimation`, `ToggleExpression` y `ChangeVTSModel`. Para las teclas rápidas de `ChangeBackground`, contiene el nombre del fondo sin la extensión del archivo. Para todos los demás tipos, contiene una cadena vacía.

El campo `"description"` contiene una descripción de lo que hace la tecla rápida. Puedes mostrar esta cadena en la interfaz de tu plugin cuando encuentres un tipo de tecla rápida que tu plugin no reconozca, por ejemplo, porque el tipo de tecla rápida fue agregado recientemente a VTube Studio.

El arreglo `"keyCombination"` contiene la combinación de teclas del teclado (o botón del ratón) que activará la tecla rápida. Consulta [RestrictedRawKey.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/RestrictedRawKey.cs) para todos los valores posibles. Si el arreglo está vacío, no se ha establecido ninguna combinación de teclas. **IMPORTANTE:** Por razones de seguridad, el arreglo `"keyCombination"` actualmente **siempre estará vacío**, por lo que estos datos no estarán disponibles para los plugins por ahora. Podría reanudarse en una actualización futura.

El campo `"onScreenButtonID"` contiene todos los IDs de botones en pantalla que activarán la tecla rápida (1 (arriba) a 8 (abajo) o -1). Si el valor es `-1`, no se ha establecido ningún botón en pantalla para esta tecla rápida.

Todas las cadenas de tipos de teclas rápidas pueden encontrarse en la página [HotkeyActions.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/HotkeyAction.cs).

## Solicitud de ejecución de teclas rápidas

**`REQUEST`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "HotkeyTriggerRequest",
	"data": {
		"hotkeyID": "HotkeyNameOrUniqueIdOfHotkeyToExecute",
		"itemInstanceID": "Optional_ItemInstanceIdOfLive2DItemToTriggerThisHotkeyFor"
	}
}
```
**`RESPUESTA`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "HotkeyTriggerResponse",
	"data": {
		"hotkeyID": "UniqueIdOfHotkeyThatWasExecuted"
	}
}
```

Esto activa una tecla rápida para el modelo actualmente cargado en VTube Studio, si dejas `"itemInstanceID"` vacío o no lo proporcionas en absoluto. Si proporcionas un ID en ese campo, en su lugar activará la tecla rápida en el modelo de elemento Live2D dado (ver más abajo para más información).

Puedes activar teclas rápidas ya sea por su ID único o por el nombre de la tecla rápida (sin distinguir mayúsculas de minúsculas). Si varias teclas rápidas tienen el mismo nombre, solo se ejecutará la primera (el orden es el orden en que aparecen en la interfaz). Las teclas rápidas con nombre vacío solo pueden activarse por ID.

Esto puede devolver un error si no se encontró el ID o nombre de la tecla rápida o si la tecla rápida no pudo ejecutarse por alguna razón. Las razones incluyen que no haya un modelo cargado actualmente o que el tiempo de espera de la tecla rápida no haya terminado (una tecla rápida específica solo puede activarse una vez cada 5 cuadros). Puedes enviar diferentes teclas rápidas en rápida sucesión, lo que hará que se pongan en cola. Una vez cada 5 cuadros, se toma una tecla rápida de la cola y se ejecuta. La cola tiene capacidad para 32 teclas rápidas. Cuando la cola está llena pero intentas enviar más teclas rápidas, se devolverá un error.

### Activar teclas rápidas en elementos Live2D

También puedes usar esta solicitud para activar teclas rápidas en elementos Live2D. Consulta [esta página](https://github.com/DenchiSoft/VTubeStudio/wiki/Live2D-Items) para más información sobre los elementos Live2D en general.

Para hacer esto, solo establece `"itemInstanceID"` en el ID de instancia del elemento Live2D. Si no hay ningún elemento Live2D con ese ID de instancia cargado actualmente, se devuelve un error. Para obtener los IDs de instancia de todos los elementos cargados actualmente, puedes usar la `ItemListRequest`.

## Solicitar la lista del estado actual de expresiones

Puedes obtener el estado actual (activo o inactivo) de una expresión específica o de todas las expresiones. Si incluyes `"expressionFile"`, solo se devolverá el estado de esa expresión. Si no lo incluyes o lo dejas como una cadena vacía, se devolverá el estado de todas las expresiones en el modelo actual.

Si incluyes un nombre de archivo pero es inválido (no termina en `.exp3.json`) o no se encuentra en el modelo actual, se devolverá un error (ver "[ErrorID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)").

Establecer `"details"` en true devolverá algunos detalles más en la respuesta (específicamente, los arreglos `"usedInHotkeys"` y `"parameters"` estarán vacíos si `"details"` está en false).

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ExpressionStateRequest",
	"data": {
		"details": true,
		"expressionFile": "myExpression_optional_1.exp3.json",
	}
}
```

El arreglo `expressions` estará vacío si no se ha cargado ningún modelo. De lo contrario, contendrá información sobre las expresiones disponibles para el modelo actualmente cargado.

El campo `"file"` es el nombre del archivo de la expresión tal como se almacena en la carpeta del modelo. `"name"` es lo mismo pero sin la extensión `.exp3.json`. `"active"` indica si la expresión está activa o no.

Si la expresión fue activada usando una tecla rápida, `"deactivateWhenKeyIsLetGo"` y `"autoDeactivateAfterSeconds"` indicarán si esas opciones fueron activadas para la tecla rápida de la expresión. Si `"autoDeactivateAfterSeconds"` es `true`, el tiempo restante hasta que la expresión se desactive automáticamente se devolverá en `"secondsRemaining"` (de lo contrario será 0).

Si `"details"` se estableció en `true` en la solicitud, el arreglo `"usedInHotkeys"` contendrá una lista de todas las teclas rápidas en las que se usa esta expresión. Además, el arreglo `"parameters"` contendrá el contenido de la expresión, es decir, los IDs de parámetros Live2D y los valores objetivo de todos los parámetros usados en la expresión.

**`RESPONSE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ExpressionStateResponse",
	"data": {
		"modelLoaded": true,
		"modelName": "My Currently Loaded Model",
		"modelID": "UniqueIDOfModel",
		"expressions": [
			{
				"name": "myExpression_optional_1",
				"file": "myExpression_optional_1 .exp3.json",
				"active": false,
				"deactivateWhenKeyIsLetGo": false,
				"autoDeactivateAfterSeconds": false,
				"secondsRemaining": 0,
				"usedInHotkeys": [
					{
						"name": "Some Hotkey",
						"id": "SomeUniqueIdToIdentifyHotkeyWith1"
					},
					{
						"name": "Some other Hotkey",
						"id": "SomeUniqueIdToIdentifyHotkeyWith2"
					}
				],
				"parameters": [
					{
						"name": "SomeLive2DParamID",
						"value": 0
					}
				]
			}
		]
	}
}
```

## Solicitar activación o desactivación de expresiones

Se recomienda activar las expresiones mediante teclas rápidas, ya que de lo contrario los usuarios podrían terminar con expresiones activadas que no pueden desactivar porque no tienen configuradas teclas rápidas para ellas. Sin embargo, también puedes activar y desactivar las teclas rápidas directamente si eso es necesario para tu complemento. Esto se hace pasando un nombre de archivo de expresión y si la expresión debe activarse o desactivarse.

**`SOLICITUD`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ExpressionActivationRequest",
	"data": {
		"expressionFile": "myExpression_1.exp3.json",
		"fadeTime": 0.5,
		"active": true
	}
}
```

Obtendrás esta respuesta vacía si la solicitud fue exitosa. Si el nombre del archivo es inválido (no termina en `.exp3.json`) o no se encuentra en el modelo actual o no hay ningún modelo cargado, se devuelve un error (ver "[ErrorID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)").
El parámetro `fadeTime` está limitado entre 0 y 2 segundos. Su valor predeterminado es 0.25. Ten en cuenta que el tiempo de desvanecimiento solo se puede configurar durante el desvanecimiento de entrada debido a restricciones del sistema de animación de VTS. Al desvanecer una expresión, siempre se usará el mismo tiempo del desvanecimiento de entrada.

**`RESPONSE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ExpressionActivationResponse",
	"data": { }
}
```

## Solicitud de la lista de ArtMeshes en el modelo actual

La API utiliza el término `Nombre de ArtMesh`, pero esto en realidad se refiere al ID de ArtMesh que será único por modelo según lo establecido por el Live2D Cubism Editor. Se pueden añadir `Etiquetas de ArtMesh` seleccionando un ArtMesh y escribiendo en el campo UserData. Si desea usar etiquetas, asegúrese de marcar `Exportar archivo UserData (userdata3.json)`. Luego debe incluir el archivo `.userdata3.json` al copiar el modelo a la carpeta Live2DModels de VTube Studio.

Las etiquetas de ArtMesh devueltas en el arreglo `"artMeshTags"` no contendrán etiquetas duplicadas.

Si no hay un modelo cargado, `"modelLoaded"` será `false` y los arreglos estarán vacíos.

**Nota sobre "etiquetas":** Las etiquetas pueden añadirse a los ArtMeshes en el campo "UserData" en el Live2D Cubism Editor. Puede agregar cualquier texto en ese campo en el editor. VTube Studio dividirá ese texto en espacios y caracteres de nueva línea. Esto significa que si su texto de etiqueta es "mi etiqueta", se convertirá en dos etiquetas en VTS: "mi" y "etiqueta". Puede agregar tantas etiquetas como quiera a cada ArtMesh.

**`SOLICITUD`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ArtMeshListRequest"
}
```
**`RESPUESTA`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ArtMeshListResponse",
	"data": {
		"modelLoaded": true,
		"numberOfArtMeshNames": 5,
		"numberOfArtMeshTags": 2,
		"artMeshNames": ["ArtMesh1", "ArtMesh2", "HairFront1", "HairFront2", "SomeArtMesh"],
		"artMeshTags": ["my_tag", "SomeOtherTag"]
	}
}
```

## Teñir ArtMeshes con color

Puedes teñir ArtMeshes proporcionando un color y criterios de coincidencia. Cualquier ArtMesh que coincida con alguno de los criterios dados será teñido con el color proporcionado. Para restablecer el color del ArtMesh, tiñe de blanco (R=G=B=A=255). No puedes convertir un ArtMesh en blanco con esta solicitud, solo en tonos más oscuros.

No proporcionar uno de los valores de color o que alguno esté fuera del rango 0-255 devolverá un error. Intentar enviar esta solicitud cuando no hay un modelo cargado también devolverá un error.

Opcionalmente, puedes proporcionar `mixWithSceneLightingColor` entre 0 y 1. Si se proporciona, esto determinará cómo se mezcla el color de tinte con el color del sistema de iluminación de la escena (consulta [aquí](https://github.com/DenchiSoft/VTubeStudio/wiki/Display-Light-Overlay) para más información al respecto). Si se establece en 1, el valor de color que proporciones sobrescribirá completamente el valor establecido por la iluminación de la escena. Establecerlo en 0 hará que el color de la iluminación de la escena sobrescriba tu color proporcionado. Cualquier valor intermedio mezclará ambos colores. Si la iluminación de la escena está apagada, esto no tiene efecto. Si no proporcionas `mixWithSceneLightingColor`, se establece en 1 por defecto, lo que significa que tu color proporcionado sobrescribirá completamente la iluminación de la escena.

Todos los arreglos incluidos en el objeto `"artMeshMatcher"` son opcionales. Si los incluyes, seleccionará ArtMeshes basándose en si los nombres o etiquetas de los ArtMeshes coinciden exactamente con alguna de las cadenas dadas o las contienen (al usar los arreglos `"nameContains"`/`"tagContains"`). El arreglo `"artMeshNumber"` permite seleccionar ArtMeshes según su orden dentro del modelo. Si solo quieres teñir todo el modelo, no incluyas ninguno de los arreglos de coincidencia y en su lugar establece `"tintAll"` en true.

Cuando la sesión se desconecta, todos los ArtMeshes que han sido teñidos en esta sesión se restablecerán a su valor predeterminado (blanco completamente opaco). Cuando múltiples plugins/sesiones sobrescriben el color de un ArtMesh, tendrá el color establecido por la solicitud más reciente.

La coincidencia siempre se realiza **sin distinguir mayúsculas y minúsculas**.

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ColorTintRequest",
	"data": {
		"colorTint": {
			"colorR": 255,
			"colorG": 150,
			"colorB": 0,
			"colorA": 255,
			"mixWithSceneLightingColor": 1
		},
		"artMeshMatcher": {
			"tintAll": false,
			"artMeshNumber": [1, 3, 5],
			"nameExact": ["eye_white_left", "eye_white_right"],
			"nameContains": ["mouth"],
			"tagExact": [],
			"tagContains": ["MyTag"]
		}
	}
}
```
**`RESPUESTA`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ColorTintResponse",
	"data": {
		"matchedArtMeshes": 3
	}
}
```

## Obtener el color de superposición de iluminación de la escena

VTube Studio tiene una funcionalidad para superponer el modelo con el color promedio capturado de una pantalla (macOS/Windows) o ventana específica (solo Windows). Para más información, vea [esta página en la documentación](https://github.com/DenchiSoft/VTubeStudio/wiki/Display-Light-Overlay).

Puede obtener la configuración actual del usuario y el color para el sistema de superposición de iluminación de la escena a través de la API.

En el nivel superior de la respuesta, tiene el campo `active`, que indica si la superposición de iluminación está activada o no. Si `itemsIncluded` es verdadero, todos los elementos también están afectados por la superposición de iluminación. Si `isWindowCapture` es `true`, VTube Studio está configurado para capturar el color promedio de una ventana. Si es `false`, la captura está configurada para una pantalla.

`baseBrightness` (entre 0 y 100), `colorBoost` (entre 0 y 100) y `smoothing` (entre 0 y 60) son los tres valores que los usuarios pueden seleccionar mediante deslizadores en la interfaz. Para una explicación, consulte [la página de documentación sobre esta función](https://github.com/DenchiSoft/VTubeStudio/wiki/Display-Light-Overlay).

`leftCapturePart`, `middleCapturePart` y `rightCapturePart` describen los colores promedio de las partes respectivas de la ventana o pantalla capturada. Su campo `active` indica si la parte de la pantalla ha sido activada por el usuario.

El color promedio calculado a partir de todas las partes de pantalla activadas se encuentra en los campos `colorAvg` (R, G y B entre 0 y 255).

El color final que se utilizará para superponer los ArtMeshes está en los campos `colorOverlay` (R, G y B entre 0 y 459). Tenga en cuenta que esto permite valores superiores a 255. El color final se calcula de la siguiente manera:

`colorAvg` *  (`colorBoost` / 50) + `WHITE_COLOR` * (`baseBrightness` / 100)

Esto puede producir valores tan altos como 2 * 255 para R, G y B. Los valores se limitan a 1.8 * 255 = 459.

Cuando el sistema de superposición de iluminación está desactivado, `active` en el nivel superior de la carga útil será `false` y todos los colores se devolverán como blanco.

**`SOLICITUD`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "SceneColorOverlayInfoRequest"
}
```

**`RESPUESTA`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "SceneColorOverlayInfoResponse",
	"data": {
		"active": true,
		"itemsIncluded": true,
		"isWindowCapture": false,
		"baseBrightness": 16,
		"colorBoost": 35,
		"smoothing": 6,
		"colorOverlayR": 206,
		"colorOverlayG": 150,
		"colorOverlayB": 153,
		"colorAvgR": 237,
		"colorAvgG": 157,
		"colorAvgB": 162,
		"leftCapturePart": {
			"active": true,
			"colorR": 243,
			"colorG": 231,
			"colorB": 234
		},
		"middleCapturePart": {
			"active": true,
			"colorR": 230,
			"colorG": 83,
			"colorB": 89
		},
		"rightCapturePart": {
			"active": false,
			"colorR": 235,
			"colorG": 95,
			"colorB": 101
		}
	}
}
```


## Comprobando si la cara está actualmente detectada por el rastreador

Devuelve si la cara está o no actualmente detectada por el rastreador activo (smartphone vía red/USB o rastreador de webcam).

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "FaceFoundRequest"
}
```
**`RESPUESTA`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "FaceFoundResponse",
	"data": {
		"found": true
	}
}
```

## Solicitud de lista de parámetros de seguimiento disponibles

Puede solicitar una lista de parámetros disponibles actualmente en VTube Studio.
Esto incluye todos los parámetros regulares y todos los parámetros personalizados creados por plugins. Los parámetros creados por plugins estarán marcados como tales cuando los seleccione en la lista de parámetros en VTube Studio. También mostrará el nombre del plugin que los creó.

**Importante:** Esto puede devolver una gran cantidad de datos. No se recomienda enviar esta solicitud a frecuencias altas (más de 60 FPS), ya que puede causar problemas de rendimiento en PCs más lentos.

**`SOLICITUD`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "InputParameterListRequest"
}
```

**`RESPUESTA`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "InputParameterListResponse",
	"data": {
		"modelLoaded": true,
		"modelName": "My Currently Loaded Model",
		"modelID": "UniqueIDOfModel",
		"customParameters": [
			{
				"name": "MyCustomParamName1",
				"addedBy": "My Plugin Name",
				"value": 12.4,
				"min": -30,
				"max": 30,
				"defaultValue": 0
			},
			{
				"name": "MyCustomParamName2",
				"addedBy": "My Plugin Name",
				"value": 0.833,
				"min": -10,
				"max": 10,
				"defaultValue": 0
			},
			{
				"name": "MyCustomParamName3",
				"addedBy": "My Other Plugin Name",
				"value": 0,
				"min": 0,
				"max": 1,
				"defaultValue": 0
			}
		],
		"defaultParameters": [
			{
				"name": "FaceAngleX",
				"addedBy": "VTube Studio",
				"value": 45.78,
				"min": -30,
				"max": 30,
				"defaultValue": 0
			},
			{
				"name": "FacePositionX",
				"addedBy": "VTube Studio",
				"value": 8.33,
				"min": -10,
				"max": 10,
				"defaultValue": 0
			}
		]
	}
}
```
**Nota:** El arreglo `"defaultParameters"` está incompleto en este ejemplo de carga útil. Este contendrá todos los parámetros predeterminados de seguimiento de rostro/ratón/etc. ofrecidos por VTube Studio 

## Obtener el valor de un parámetro específico, predeterminado o personalizado

Si el parámetro de entrada solicitado no existe, se devolverá un error.

**`SOLICITUD`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ParameterValueRequest",
	"data": {
		"name": "MyCustomParamName1"
	}
}
```
**`RESPUESTA`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ParameterValueResponse",
	"data": {
		"name": "MyCustomParamName1",
		"addedBy": "My Plugin Name",
		"value": 12.4,
		"min": -30,
		"max": 30,
		"defaultValue": 0
	}
}
```

## Obtener el valor de todos los parámetros Live2D en el modelo actual

Esto devolverá un error si no hay ningún modelo cargado.

**`SOLICITUD`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "Live2DParameterListRequest"
}
```
**`RESPUESTA`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "Live2DParameterListResponse",
	"data": {
		"modelLoaded": true,
		"modelName": "My Currently Loaded Model",
		"modelID": "UniqueIDOfModel",
		"parameters": [
			{
				"name": "MyLive2DParameterID1",
				"value": 12.4,
				"min": -30,
				"max": 30,
				"defaultValue": 0
			},
			{
				"name": "MyLive2DParameterID2",
				"value": 0,
				"min": 0,
				"max": 1,
				"defaultValue": 0
			}
		]
	}
}
```
Si no se carga ningún modelo, `"modelLoaded"` será falso y el arreglo de parámetros estará vacío. Todos los demás campos serán cadenas vacías.

## Añadiendo nuevos parámetros de seguimiento ("parámetros personalizados")

También puedes añadir tus propios nuevos parámetros de seguimiento y usarlos en tus modelos de VTube Studio. Se llaman parámetros "personalizados". Después de ser añadidos por tu plugin, el usuario puede seleccionar tus parámetros como entradas para los mapeos de parámetros Live2D.

Los nombres de los parámetros deben ser únicos, alfanuméricos (no se permiten espacios) y deben tener entre 4 y 32 caracteres de longitud. Los nuevos parámetros de seguimiento se crean así:

**`REQUEST`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ParameterCreationRequest",
	"data": {
		"parameterName": "MyNewParamName",
		"explanation": "This is my new parameter.",
		"min": -50,
		"max": 50,
		"defaultValue": 10
	}
}
```
**`RESPUESTA`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ParameterCreationResponse",
	"data": {
		"parameterName": "MyNewParamName"
	}
}
```
La solicitud puede fallar y devolver un error si el nombre del parámetro es inválido.

También fallará si ya existe un parámetro con el mismo nombre creado por un plugin diferente. Si crea un parámetro varias veces con el mismo nombre de plugin, la solicitud tendrá éxito. También puede sobrescribir los valores `min`, `max` y `defaultValue` de esa manera.

Los valores Min/Max/Default deben ser números de punto flotante entre `-1000000` y `1000000`. Los valores min/max no son realmente los valores mínimos y máximos permitidos para el parámetro. Son los valores que se usarán como valor predeterminado inferior y superior cuando se cree un nuevo mapeo de parámetro usando este parámetro.

La explicación es una breve explicación opcional (menos de 256 caracteres) que indica qué hace el parámetro y cómo los usuarios deben usarlo en sus modelos. Si proporciona esto en la solicitud, se mostrará cuando el usuario vea los detalles de este parámetro personalizado.

Existe un límite global en VTS de 300 parámetros personalizados y un límite de 100 parámetros personalizados por plugin. Si intenta crear más, se devolverá un error.

Estos parámetros personalizados que crea se almacenan como parte de la configuración de VTube Studio en un archivo llamado `custom_parameters.json` en la carpeta `Config`, que se encuentra en la carpeta `StreamingAssets` de VTube Studio. Si revoca el token de autenticación de un plugin, todos los parámetros personalizados que este plugin creó también se eliminarán. Todavía estarán establecidos en los modelos de VTube Studio que los hayan usado, pero se mostrarán en texto rojo para indicar que el parámetro de entrada ya no existe. Los plugins pueden obtener otro token y recrear estos parámetros en cualquier momento y seguirán funcionando.

## Eliminar parámetros personalizados

Puede eliminar parámetros personalizados. Los parámetros predeterminados no se pueden eliminar. Tampoco puede eliminar parámetros creados por plugins distintos al que ha usado para autenticar esta sesión.

**`SOLICITUD`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ParameterDeletionRequest",
	"data": {
		"parameterName": "MyNewParamName"
	}
}
```

**`RESPUESTA`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ParameterDeletionResponse",
	"data": {
		"parameterName": "MyNewParamName"
	}
}
```

## Alimentación de datos para parámetros predeterminados o personalizados

Puede alimentar datos para cualquier parámetro predeterminado o personalizado. Estos parámetros de seguimiento se usarán como entradas para el modelo de VTube Studio cargado y cualquier [Live2D Items](https://github.com/DenchiSoft/VTubeStudio/wiki/Live2D-Items) cargado.

La carga útil se ve así:

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "InjectParameterDataRequest",
	"data": {
		"faceFound": false,
		"mode": "set",
		"parameterValues": [
			{
				"id": "FaceAngleX",
				"value": 12.31
			},
			{
				"id": "MyNewParamName",
				"weight": 0.8,
				"value": 0.7
			}
		]
	}
}
```

**`RESPUESTA`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "InjectParameterDataResponse",
	"data": { }
}
```

Si uno o más de los parámetros no existen, se devolverá una carga útil de error.

Los valores deben ser números de punto flotante entre `-1000000` y `1000000`. Los valores fuera de ese rango también devolverán un error.

Si existen valores para esos parámetros provenientes del seguimiento de webcam/iOS/Android, los valores de la API sobrescribirán esos mientras continúes enviando datos a través de la API.
Debes volver a enviar datos para un parámetro que quieras controlar con tu plugin **al menos una vez por segundo**. No hacerlo resultará en que el parámetro sea considerado "perdido" y volverá al valor de lo que lo controlaba antes. Si nada más lo controla, volverá a su valor por defecto.

También puedes añadir un parámetro opcional `"weight"` entre 0 y 1. Esto puede usarse para mezclar el `"value"` que envías para el parámetro con el valor que ha sido establecido para el parámetro desde el seguimiento facial. Por ejemplo, podrías controlar un parámetro 50% con seguimiento facial y 50% usando la API. Sin embargo, solo un plugin de API puede escribir en un parámetro a la vez. Un caso de uso para esto sería hacer un fade in/out del control de un parámetro de seguimiento facial para que no "salte" en el momento que tomas control vía API. Si no incluyes el parámetro `"weight"` en tu solicitud para un parámetro, se considerará que tiene el valor 1, lo que significa que el parámetro objetivo se establecerá instantáneamente al valor proporcionado por tu plugin.

También debe notarse que estos parámetros se tratan de manera similar a los parámetros normales de seguimiento. Por lo tanto, puedes seleccionarlos como entradas normales para los mapeos de parámetros en VTube Studio y aplicar suavizado mediante los deslizadores en la interfaz de usuario. Eliminar parámetros personalizados mientras están siendo usados por un modelo tampoco causa problemas y pueden recrearse en cualquier momento.

Opcionalmente, puedes pasar `"faceFound": true`, lo que indicará a VTube Studio que considere que se ha encontrado la cara del usuario. De esta forma, puedes controlar cuándo se reproduce la animación de "seguimiento perdido".

### Controlar un parámetro con múltiples plugins

Generalmente, si otro plugin ya está controlando un parámetro (por defecto o personalizado), se devolverá un error. Esto sucede porque solo un plugin puede "establecer" (sobrescribir) un parámetro dado a la vez, que es el modo por defecto para esta solicitud. Este es el modo que se usa cuando no proporcionas un valor en el campo `"mode"` o estableces el valor a `"set"`.

Alternativamente, puedes establecer el campo `"mode"` a `"add"`. Esto añadirá los valores que envíes a los valores actuales del parámetro. Los valores de `"weight"` no se usan en ese caso. Cualquier número de plugins puede usar el modo `"add"` para un parámetro dado al mismo tiempo. Esto puede ser útil para plugins de tipo **bonk/throwing** y otros casos de uso.

## Obtener configuraciones de física del modelo VTS cargado actualmente

Los usuarios pueden personalizar configuraciones de física en VTube Studio. Pueden cambiar las siguientes configuraciones:

- **Fuerza base de la física (por modelo):** Entero entre 0 (apagado) y 100 (máximo). El valor por defecto es 50, lo que significa que la física se comportará como en el Live2D Cubism Editor.
- **Fuerza base del viento (por modelo):** Entero entre 0 (apagado) y 100 (máximo). El valor por defecto es 0.
- **Multiplicador de física (por grupo de física):** Para cada grupo de física (configurable en Live2D Cubism), los usuarios pueden establecer un multiplicador. El valor base de física se multiplicará por este valor al procesar el grupo de física respectivo. Número flotante entre 0 y 2, el valor por defecto es 1, lo que significa que el valor base permanece sin cambios.
- **Multiplicador de viento (por grupo de física):** Para cada grupo de física (configurable en Live2D Cubism), los usuarios pueden establecer un multiplicador. El valor base de viento se multiplicará por este valor al procesar el grupo de física respectivo. Número flotante entre 0 y 2, el valor por defecto es 1, lo que significa que el valor base permanece sin cambios.

Estos valores establecidos por el usuario pueden leerse vía API y también ser sobrescritos temporalmente (ver `SetCurrentModelPhysicsRequest`).

Para leer los valores del modelo cargado actualmente, usa esta solicitud:


**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "GetCurrentModelPhysicsRequest"
}
```
**`RESPUESTA`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "GetCurrentModelPhysicsResponse",
	"data": {
		"modelLoaded": true,
		"modelName": "My Currently Loaded Model",
		"modelID": "UniqueIDOfModel",
		"modelHasPhysics": true,
		"physicsSwitchedOn": true,
		"usingLegacyPhysics": false,
		"physicsFPSSetting": -1,
		"baseStrength": 50,
		"baseWind": 17,
		"apiPhysicsOverrideActive": false,
		"apiPhysicsOverridePluginName": "",
		"physicsGroups": [
			{
				"groupID": "PhysicsSetting1",
				"groupName": "Hair Front Physics",
				"strengthMultiplier": 1.5,
				"windMultiplier": 0.3
			},
			{
				"groupID": "PhysicsSetting2",
				"groupName": "Clothes Physics",
				"strengthMultiplier": 1,
				"windMultiplier": 2
			}
		]
	}
}
```

Si no se carga ningún modelo, `modelLoaded` será `false`. Todos los demás valores no tienen ningún significado en ese caso y el arreglo `physicsGroups` estará vacío.

Si se carga un modelo, el campo `modelHasPhysics` te indicará si el modelo tiene o no una configuración de física válida. Algunos modelos no tienen física configurada o tienen un archivo de física dañado, lo que hará que el sistema de física no se inicie correctamente. `physicsSwitchedOn` será verdadero si el interruptor `Use Physics` ha sido activado para este modelo por el usuario en VTube Studio. `usingLegacyPhysics` es el estado del interruptor `Legacy Physics`.

`physicsFPSSetting` contiene la configuración de FPS de física para este modelo y puede ser 30, 60, 120 o -1, lo que indica que el usuario ha seleccionado `Use same FPS as app`.

Los campos `apiPhysicsOverrideActive` y `apiPhysicsOverridePluginName` indican si un plugin está actualmente sobrescribiendo algunas de las configuraciones de física. Si el campo active es verdadero, el campo de nombre contendrá el nombre del plugin. Solo un plugin puede tomar control del sistema de física a la vez. Esto también se explicará como parte de la solicitud `SetCurrentModelPhysicsRequest`.

Si usas la solicitud `SetCurrentModelPhysicsRequest` para sobrescribir valores base o multiplicadores de física o viento, estos cambios **NO** se reflejarán en esta solicitud Get. Debes recordar tus propias sobrescrituras de física.

Nota sobre el arreglo `physicsGroup`: Cada grupo tiene un ID pero no todos los grupos tienen que tener un nombre. En ese caso, el campo `groupName` respectivo será una cadena vacía.

## Sobrescribir configuraciones de física del modelo VTS actualmente cargado

Puedes sobrescribir las configuraciones de física del modelo actualmente cargado usando esta solicitud. Una vez que un plugin ha tomado control del sistema de física a través de esta API, ningún otro plugin puede usar esta API hasta que el primer plugin haya cedido el control. Intentar hacerlo devolverá el error respectivo, consulta "[ErrorID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)" (`SetCurrentModelPhysicsRequestPhysicsControlledByOtherPlugin`). Esto también devolverá un error si no hay ningún modelo cargado, si alguno de los IDs de grupos de física proporcionados no existe en el modelo actual o si olvidaste añadir un valor a tus sobrescrituras.

Si el usuario ha desactivado la física para el modelo cargado actualmente, no puedes activar la física usando esta API. Solo puedes usar esta API para sobrescribir valores base y multiplicadores de física/viento.

Como se explicó en la sección `GetCurrentModelPhysicsRequest` arriba, los valores para multiplicadores de física/viento deben estar entre 0 y 2, mientras que los valores para valores base de física/viento deben ser enteros entre 0 y 100 (porque así es como se muestran al usuario en la aplicación). Los valores fuera de ese rango serán ajustados automáticamente.

Si quieres establecer multiplicadores para fuerza o viento para un grupo específico de física, usa los arreglos `strengthOverrides` y `windOverrides` con el ID de grupo respectivo y `setBaseValue` en falso. Si estableces `setBaseValue` en verdadero, el valor proporcionado se establecerá como valor base para la fuerza física o el viento en lugar de para un grupo específico. Puedes dejar el ID del grupo (`id`) vacío en ese caso.

En general, los valores establecidos usando esta API se usan para sobrescribir los valores establecidos por el usuario en la aplicación. En realidad no se muestran al usuario en la interfaz y no se guardan. Los valores sobrescritos establecidos usando esta API se desactivan automáticamente cuando su temporizador expira (el valor que estableces usando `overrideSeconds`). Si deseas mantener los valores sobrescritos, debes enviar esta solicitud repetidamente.

Cuando todos los temporizadores expiran, la API ya no considerará que tu plugin controla el sistema de física, por lo que otro plugin podría comenzar a controlar el sistema de física.

Los valores del temporizador de sobrescritura deben estar entre 0.5 y 5 segundos. Los valores fuera de ese rango serán ajustados automáticamente.

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "SetCurrentModelPhysicsRequest",
	"data": {
		"strengthOverrides": [
			{
				"id": "PhysicsSetting1",
				"value": 1.5,
				"setBaseValue": false,
				"overrideSeconds": 2
			}
		],
		"windOverrides": [
			{
				"id": "",
				"value": 85,
				"setBaseValue": true,
				"overrideSeconds": 5
			}
		]
	}
}
```
**`RESPUESTA`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "SetCurrentModelPhysicsResponse",
	"data": { }
}
```

## Obtener y configurar ajustes de NDI

Puede solicitar los ajustes actuales de NDI y cambiarlos a través de la API. Esto le permite activar/desactivar NDI, establecer una resolución fija personalizada y más.

La información sobre NDI y cómo usarlo en VTube Studio se encuentra en esta página: https://github.com/DenchiSoft/VTubeStudio/wiki/Streaming-to-Mac-PC

Si establece `"setNewConfig"` en `false`, esto solo devuelve la configuración actual. Todos los demás campos se ignoran en ese caso. Si se establece en `true`, se aplicará la configuración dada si es válida.

`"ndiActive"` activa o desactiva NDI. Si NDI está activado, `"useNDI5"` usa NDI 5 en lugar de NDI 4 (recomiendo usar NDI 5).

Configurar `"useCustomResolution"` en `true` significa que la transmisión NDI ya no tendrá la misma resolución que la ventana de VTube Studio, sino que usará la resolución personalizada establecida a través de la interfaz. Esta resolución también se puede cambiar mediante la API usando los campos `"customWidthNDI"` y `"customHeightNDI"`. Ambos deben estar entre 256 y 8192. El ancho debe ser múltiplo de 16 y la altura múltiplo de 8. Establecer ambos en `-1` en la solicitud omitirá configurarlos y solo establecerá los campos booleanos. De esa manera, por ejemplo, puede activar/desactivar NDI sin cambiar la resolución.

Si la resolución de NDI no coincide con la resolución de la ventana, VTube Studio cortará y escalará automáticamente la transmisión de video. VTube Studio siempre asegurará que la relación de aspecto sea correcta, incluso si eso significa cortar partes en la parte superior/inferior o izquierda/derecha.

**Importante:** Esta solicitud tiene un periodo de enfriamiento de 3 segundos. Ejecutarla demasiado rápido devolverá un error del tipo `NDIConfigCooldownNotOver` (ver "[ErrorID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)").

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "NDIConfigRequest",
	"data": {
		"setNewConfig": true,
		"ndiActive": true,
		"useNDI5": true,
		"useCustomResolution": true,
		"customWidthNDI": 1024,
		"customHeightNDI": 512
	}
}
```
La respuesta solo contendrá la configuración actual (las nuevas si solicitó establecer una nueva configuración). El campo `"setNewConfig"` no tiene ningún significado en la respuesta.

**`RESPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "NDIConfigResponse",
	"data": {
		"setNewConfig": true,
		"ndiActive": true,
		"useNDI5": true,
		"useCustomResolution": true,
		"customWidthNDI": 1024,
		"customHeightNDI": 512
	}
}
```

## Solicitar lista de objetos disponibles o objetos en la escena

Esta solicitud te permite pedir una lista de objetos que están actualmente en la escena. También te permite pedir una lista de archivos de objetos que están disponibles para cargarse en el PC del usuario, incluyendo objetos Live2D, carpetas de animación, ...

Si quieres saber qué lugares de orden están disponibles para cargar objetos en este momento, configura `"includeAvailableSpots"` a `true`. De lo contrario, el arreglo `"availableSpots"` en la respuesta estará vacío.

Si quieres saber qué objetos están cargados en la escena en este momento, configura `"includeItemInstancesInScene"` a `true`. De lo contrario, el arreglo `"itemInstancesInScene"` en la respuesta estará vacío.

Si quieres saber qué archivos de objetos están disponibles para cargarse, configura `"includeAvailableItemFiles"` a `true`. De lo contrario, el arreglo `"availableItemFiles"` en la respuesta estará vacío. **IMPORTANTE:** Esto lee la lista completa de archivos de objetos desde el PC del usuario. Esto puede causar una pequeña demora en la aplicación, así que no uses esta solicitud con `"includeAvailableItemFiles"` configurado a `true` con frecuencia. Úsalo solo si realmente necesitas actualizar la lista de archivos de objetos disponibles. Configúralo a `false` en cualquier otro caso.

#### Filtrado para objetos específicos

Si solo quieres que las listas de objetos contengan objetos con un cierto ID de instancia o un cierto nombre de archivo, puedes proporcionarlos en los campos `"onlyItemsWithInstanceID"` y `"onlyItemsWithFileName"` respectivamente.

Solo habrá como máximo un objeto con un cierto ID de instancia en la escena, pero podría haber muchos objetos con el mismo nombre de archivo porque puedes cargar muchas instancias de objetos basadas en el mismo archivo de objeto.

Ten en cuenta también que **los nombres de archivo de objetos son únicos**, lo que significa que no puede haber dos archivos de objetos con el mismo nombre de archivo. También son **sensibles a mayúsculas y minúsculas**, así que si quieres referirte a un archivo específico, asegúrate de no cambiar la capitalización.

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ItemListRequest",
	"data": {
		"includeAvailableSpots": true,
		"includeItemInstancesInScene": true,
		"includeAvailableItemFiles": false,
		"onlyItemsWithFileName": "OPTIONAL_my_item_filename.png",
		"onlyItemsWithInstanceID": "OPTIONAL_InstanceIdOfItemInScene"
	}
}
```

Los campos en la respuesta deberían ser en su mayoría autoexplicativos.

El nombre del archivo es el nombre del archivo del ítem. Este es el nombre que puedes usar para cargar una instancia del ítem en la escena. Para ítems JPG/PNG/GIF, este es el nombre completo del archivo (sin la ruta) incluyendo la extensión del archivo (por ejemplo "mi_item.jpg"). Para carpetas de animación, es el nombre de la carpeta. Para ítems Live2D, también es el nombre de la carpeta.

El tipo de ítem se puede encontrar en el campo `"type"`. Los valores posibles son `PNG`, `JPG`, `GIF`, `AnimationFolder` o `Live2D`. Otro valor posible es `Unknown`. Esto solo ocurriría si se añade otro tipo de ítem a VTube Studio antes de que la API se actualice, por lo que no debería suceder.

`"canLoadItemsRightNow"` puede ser `false` si el usuario tiene ciertos menús o diálogos abiertos en VTube Studio. Esto generalmente impide acciones como cargar ítems, usar teclas rápidas y más.

`"framerate"` y `"frameCount"` solo están disponibles para ítems animados (GIFs y carpetas de fotogramas de animación).

Si `"pinnedToModel"` es true, `"pinnedModelID"` contendrá el ID del modelo al que está anclado el ítem (que será el modelo cargado actualmente) y `"pinnedArtMeshID"` contendrá el ID del ArtMesh al que está anclado el ítem.

Si configuras `"includeAvailableItemFiles"` a `true`, `"availableItemFiles"` contendrá una lista de todos los archivos de ítems en la carpeta `Items` del usuario. Puedes usar los nombres de archivo devueltos aquí para cargar ítems en la escena usando la `ItemLoadRequest`.

**`RESPUESTA`**
```json
{
    "apiName": "VTubeStudioPublicAPI",
    "apiVersion": "1.0",
    "timestamp": 1625405710728,
    "messageType": "ItemListResponse",
    "requestID": "SomeID",
    "data": {
        "itemsInSceneCount": 2,
        "totalItemsAllowedCount": 60,
        "canLoadItemsRightNow": true,
        "availableSpots":
	[
            -30,-29,-28,-27,-26,-25,-24,-23,-22,-21,-20,-19,-18,-17,-16,-15,-14,
            -13,-12,-11,-10,-9,-8,-7,-6,-5,-4,-3,-2,-1,3,4,5,6,7,8,9,10,11,12,13,
            14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30
        ],
        "itemInstancesInScene": [
            {
                "fileName": "Ribbon (@denchisoft)",
                "instanceID": "18de53dc47154b00afdd382a6ebd2194",
                "order": 1,
                "type": "Live2D",
                "censored": false,
                "flipped": false,
                "locked": false,
                "smoothing": 0.0,
                "framerate": 0.0,
                "frameCount": -1,
                "currentFrame": -1,
                "pinnedToModel": true,
                "pinnedModelID": "47c71722c5304a039b0570b60a189875",
                "pinnedArtMeshID": "D_FACE_00",
                "groupName": "",
                "sceneName": "",
                "fromWorkshop": false
            },
            {
                "fileName": "akari_fly (@walfieee)",
                "instanceID": "716cddf2e12a438ab5da05bbbf8b341c",
                "order": 2,
                "type": "AnimationFolder",
                "censored": false,
                "flipped": false,
                "locked": false,
                "smoothing": 0.0,
                "framerate": 15.0,
                "frameCount": 7,
                "currentFrame": 0,
                "pinnedToModel": false,
                "pinnedModelID": "",
                "pinnedArtMeshID": "",
                "groupName": "",
                "sceneName": "",
                "fromWorkshop": false
            }
        ],
        "availableItemFiles": [
            {
                "fileName": "Ribbon (@denchisoft)",
                "type": "Live2D",
                "loadedCount": 1
            },
            {
                "fileName": "ANIM_headpat",
                "type": "AnimationFolder",
                "loadedCount": 0
            },
            {
                "fileName": "workshop_2801215328_ANIM_loading gif",
                "type": "AnimationFolder",
                "loadedCount": 0
            },
            {
                "fileName": "akari_fly (@walfieee)",
                "type": "AnimationFolder",
                "loadedCount": 1
            },
            {
                "fileName": "b_woozy (@denchisoft).png",
                "type": "PNG",
                "loadedCount": 0
            }
        ]
    }
}
```
## Carga de un objeto en la escena

Con esta solicitud, puedes cargar objetos en la escena. Los objetos se cargan desde la carpeta "Items" en la PC del usuario.

Para obtener la lista de archivos de objetos disponibles, usa la `ItemListRequest`. Puedes usar esos nombres en el campo `"fileName"`.

Los objetos pueden posicionarse/escalar/rotarse usando los campos `"positionX/Y"`, `"size"` y `"rotation"`. Por favor, consulta la imagen que muestra el [sistema de coordenadas de VTube Studio](#the-vts-coordinate-system) para más información sobre cómo usar estos valores. En cuanto al tamaño, debe estar entre `0` y `1`, siendo `0.32` aproximadamente el tamaño "predeterminado" que tendrán los objetos cuando el usuario los cargue manualmente.

Debes asegurarte de que tu plugin limpie sus objetos. Absolutamente nunca debes dejar objetos fuera de la escena visible donde el usuario ya no pueda acceder a ellos sin usar el botón **"Eliminar todos los objetos en la escena"**. Para facilitar esto, puedes establecer `"unloadWhenPluginDisconnects"` en true.

Puedes usar el campo `"fadeTime"` para especificar un tiempo de desvanecimiento de entrada/salida entre 0 y 2 segundos para el objeto. Si lo configuras en 0, el objeto aparecerá instantáneamente.

Puedes especificar el orden de clasificación en el que el objeto debe cargarse en la escena usando el campo `"order"`. Si ese orden está ocupado, el objeto se cargará automáticamente en el siguiente orden disponible superior y si todos los órdenes superiores están llenos, revisará los órdenes inferiores. Si quieres que la carga del objeto falle si el orden solicitado está ocupado, usa `failIfOrderTaken` en `true`. En ese caso, se devolverá un error del tipo `ItemOrderAlreadyTaken` (ver [ErrorsID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)).

También hay límites para algunos valores. Específicamente, el tamaño debe estar entre `0` y `1`, las posiciones deben estar entre `-1000` y `1000` (aunque `-1`/`1` son los bordes de la pantalla), el tiempo de desvanecimiento debe estar entre `0` y `2` segundos y el suavizado debe estar entre `0` y `1`. Si excedes esos límites, se devuelve un error del tipo `ItemLoadValuesInvalid`.

### Objetos con Datos Personalizados

Los plugins también pueden usar esta solicitud para cargar datos arbitrarios PNG/JPG/GIF como objetos pasándolos a través del campo `customDataBase64` (debe ser un archivo JPG, PNG o GIF codificado en base64). Déjalo vacío/NULL si no lo estás usando.

Si quieres hacer esto, necesitas el permiso `LoadCustomImagesAsItems`. Para más información sobre cómo solicitar permisos, consulta la [página de permisos](Permissions/). Si no tienes ese permiso, se devolverá un error si intentas cargar una imagen de datos personalizada (`RequestRequiresPermission`, ver [ErrorsID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)).

Para solicitar que se carguen datos arbitrarios como un objeto, `customDataBase64` debe contener datos válidos de un archivo PNG, JPG o GIF. Actualmente no se admiten objetos Live2D con datos personalizados. Las dimensiones deben estar entre (inclusive) 64 y 2048 píxeles y los datos deben ser menores a 5 MB (los datos binarios antes de codificarlos en base64). Para datos GIF, el GIF debe contener 1024 cuadros o menos pero al menos 1 cuadro y todos los cuadros deben tener el mismo tamaño.

Al proporcionar datos personalizados, aún debes proporcionar un nombre de archivo en el campo `fileName`. El `fileName` debe ser alfanumérico (pero puede contener guiones) y debe terminar con `.jpg`, `.png` o `.gif`. Debe tener entre (inclusive) 8 y 32 caracteres de longitud.

Al cargar datos personalizados, tienes dos opciones:
* Simplemente cargar el objeto de datos personalizado instantáneamente.
* Mostrar una pequeña ventana emergente al usuario (incluyendo la miniatura del objeto) y preguntarle si desea cargar el objeto.

Elige la opción apropiada según tu caso de uso. Es tu responsabilidad asegurarte de que tu plugin no cargue imágenes que puedan causar problemas al usuario.

Si quieres cargar el objeto de inmediato, establece `customDataAskUserFirst` en `false`.

Si quieres mostrar primero una ventana emergente al usuario, establece `customDataAskUserFirst` en `true`. Si haces esto, se mostrará la siguiente ventana emergente al usuario:

![Ventana emergente de carga de imagen personalizada](/Images/vts_load_custom_image_1.png)

Se pueden mostrar hasta 6 ventanas emergentes como esta al mismo tiempo (las ventanas emergentes se apilan verticalmente). Cuando ya se muestran 6 ventanas emergentes al usuario, las solicitudes posteriores devolverán un error.

Al mostrar el popup, la respuesta a esta solicitud solo se devolverá una vez que el usuario tome una decisión. Si el usuario decide denegar la carga del elemento de datos personalizado, se devolverá un error (`ItemCustomDataLoadRequestRejectedByUser`). Cuando el usuario decide cargar el elemento, este se cargará y se devolverá una respuesta normal. Eso también lo añadirá a la lista blanca para tu plugin, por lo que cargas posteriores del mismo elemento (según lo determinado por su hash SHA256) no activarán el popup. Si quieres forzar que el popup se active cada vez, puedes configurar `customDataSkipAskingUserIfWhitelisted` a false.

Puedes establecer un tiempo límite para el popup usando el campo `customDataAskTimer`. Si lo configuras en 0 (o menor), el popup se mostrará indefinidamente (hasta que el usuario haga clic en OK o cancelar). Si lo configuras en cualquier otro número positivo, el popup se mostrará durante ese número de segundos, con una cuenta regresiva visible para el usuario. Si el usuario no toma una decisión antes de que termine la cuenta regresiva, la solicitud de carga del elemento se considera rechazada por el usuario.

**`REQUEST`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ItemLoadRequest",
	"data": {
		"fileName": "some_item_name.jpg",
		"positionX": 0,
		"positionY": 0.5,
		"size": 0.33,
		"rotation": 90,
		"fadeTime": 0.5,
		"order": 4,
		"failIfOrderTaken": false,
		"smoothing": 0,
		"censored": false,
		"flipped": false,
		"locked": false,
		"unloadWhenPluginDisconnects": true,
		"customDataBase64": "",
		"customDataAskUserFirst": true,
		"customDataSkipAskingUserIfWhitelisted": true,
		"customDataAskTimer": -1,
	}
}
```

La respuesta contiene el ID de instancia del elemento recién cargado en el campo `instanceID`. También contiene el nombre del archivo.

Si cargaste un elemento de datos personalizado, el nombre del archivo será generado por VTube Studio, por lo que será diferente del nombre del archivo que enviaste. Puedes usar ese nombre de archivo para solicitar que se cargue ese elemento nuevamente sin enviar datos personalizados. Sin embargo, cuando se reinicia VTube Studio, todos los archivos temporales se borran, lo que incluye los elementos de datos personalizados.

**`RESPONSE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ItemLoadResponse",
	"data": {
		"instanceID": "SomeUniqueItemInstanceId",
		"fileName": "some_item_name.jpg"
	}
}
```

## Eliminando un ítem de la escena

Puede usar esta solicitud para descargar cualquier ítem que esté actualmente cargado en la escena.

Configurar `"unloadAllInScene"` a `true` descarga todos los ítems. Todos los demás campos se ignoran en ese caso.

Configurar `"unloadAllLoadedByThisPlugin"` a `true` descarga todos los ítems que han sido cargados por este plugin.

Si desea evitar que esta solicitud descargue ítems que han sido cargados por el usuario u otros plugins, configure `"allowUnloadingItemsLoadedByUserOrOtherPlugins"` en `false`.

También puede solicitar instancias específicas de ítems o instancias de ítems que hayan sido cargados desde ciertos nombres de archivo usando los arreglos opcionales `"instanceIDs"` y `"fileNames"`. Incluso si esos ítems no se encuentran en la escena, la solicitud no devolverá un error. Simplemente devolverá una respuesta con un arreglo vacío.

Esto puede devolver un error de tipo `CannotCurrentlyUnloadItem` si el usuario tiene menús abiertos que impiden que VTS cargue/descargue ítems.

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ItemUnloadRequest",
    	"data": {
		"unloadAllInScene": false,
		"unloadAllLoadedByThisPlugin": false,
		"allowUnloadingItemsLoadedByUserOrOtherPlugins": true,
		"instanceIDs":
		[
			"SomeInstanceIdOfItemToUnload", "SomeOtherInstanceIdOfItemToUnload"
		],
		"fileNames":
		[
			"UnloadAllItemInstancesWithThisFileName", "SomeOtherFileName"
		]
    	}
}
```

La respuesta contiene los ID de instancia y los nombres de archivo de los elementos descargados.

**`RESPUESTA`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ItemUnloadResponse",
    	"data": {
		"unloadedItems":
		[
		    {
			"instanceID": "SomeInstanceId",
			"fileName": "SomeFileName"
		    },
		    {
			"instanceID": "SomeOtherInstanceId",
			"fileName": "SomeFileName"
		    }
		]
    	}
}
```

## Control de elementos y animaciones de elementos

Puedes controlar ciertos aspectos de los elementos en la escena. Esta solicitud te permite hacer que los elementos sean más oscuros (superposición negra), cambiar la opacidad y controlar la animación de elementos animados. Esta solicitud no funciona con elementos Live2D y devolverá un error del tipo `ItemAnimationControlUnsupportedItemType` si lo intentas (consulta [ErrorsID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)). Esto puede ser útil para complementos tipo "PNG reactivo" y más.

Para elementos animados, puedes establecer la velocidad de fotogramas (en fotogramas por segundo, se limitará automáticamente entre `0.1` y `120`). También puedes hacer que la animación salte manualmente a un fotograma determinado usando el campo `"frame"`. Se devolverá un error si ese índice de fotograma es inválido. Para un elemento animado con (por ejemplo) 20 fotogramas, los índices válidos van de 0 (primer fotograma) a 19 (último fotograma). El recuento de fotogramas para elementos animados se puede solicitar usando `ItemListRequest`. Intentar hacer esto con elementos JPG/PNG normales devolverá un error del tipo `ItemAnimationControlSimpleImageDoesNotSupportAnim`.

Si no quieres cambiar la velocidad de fotogramas, el fotograma actual, el brillo o la opacidad, puedes pasar `-1` para esos campos (que también es su valor predeterminado si omites los campos en la carga útil).

Puedes iniciar/detener la animación usando el campo `"animationPlayState"` (`true` = reproducir animación, `false` = detener animación). Este campo solo se usa si configuras `"setAnimationPlayState"` en `true`, de lo contrario, el estado de reproducción de la animación no se cambiará.

#### Uso de fotogramas de detención automática

Puedes establecer una lista de índices de fotogramas en los que la animación se detendrá automáticamente usando el arreglo `"autoStopFrames"`. Este arreglo solo se usa si configuras `"setAutoStopFrames"` en true, de lo contrario, los fotogramas de detención automática no se cambiarán. Si deseas eliminar los fotogramas de detención automática, configura `"setAutoStopFrames"` en true y establece un arreglo vacío en `"autoStopFrames"`. Puedes tener un máximo de 1024 fotogramas de detención automática.

Una vez que la animación alcanza uno de esos fotogramas, se detendrá y solo podrá iniciarse nuevamente vía API usando esta solicitud para establecer el estado de reproducción de la animación en `true` (ver arriba).

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ItemAnimationControlRequest",
	"data": {
		"itemInstanceID": "ItemInstanceId",
		"framerate": 12,
		"frame": 3,
		"brightness": 1,
		"opacity": 1,
		"setAutoStopFrames": true,
		"autoStopFrames": [0, 7, 26],
		"setAnimationPlayState": true,
		"animationPlayState": true
	}
}
```
La respuesta contiene el índice del cuadro actual y si la animación se está reproduciendo actualmente (solo para elementos animados, para otros tipos de elementos estos campos deben ser ignorados).

**`RESPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ItemAnimationControlResponse",
	"data": {
		"frame": 3,
		"animationPlaying": true
	}
}
```

## Movimiento de elementos en la escena

Puedes mover elementos dentro de la escena. Para hacerlo, llena el arreglo `"itemsToMove"` con todos los elementos que deseas mover. El arreglo de respuesta (`"movedItems"`) contendrá una entrada por cada elemento solicitado, mostrando si la solicitud de movimiento fue exitosa o no para ese elemento (consulta el campo respectivo `"success"`). Si no fue exitosa, el campo `"errorID"` contendrá el código de error, que te indicará qué salió mal (consulta [ErrorsID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)). Si fue exitosa, `"success"` será `true` y `"errorID"` será `-1`.

El arreglo `"itemsToMove"` puede tener hasta 64 entradas. Todas las entradas más allá de ese número serán ignoradas. Si el arreglo contiene entradas con IDs de instancia de elemento duplicados, se usará la última entrada en el arreglo para ese ID.

Si deseas establecer la posición instantáneamente (por ejemplo, cuando quieres establecer una nueva posición en cada frame), establece `"timeInSeconds"` en `0`. De lo contrario, puedes usar este campo para definir el tiempo usado para el desvanecimiento del movimiento (limitado entre 0 y 30 segundos).

Si deseas establecer el estado de volteo del elemento, configura `"setFlip"` en true. El estado de volteo puede establecerse entonces usando el campo `"flip"`.

Si quieres cambiar el orden de un elemento, puedes usar el campo `"order"`. Solo puedes cambiar el orden a posiciones que no estén ocupadas (consulta `ItemListResponse`). Si no deseas cambiar el orden, establece este campo en -1000 o menor, o alternativamente puedes establecerlo en el valor actual de orden del elemento. Además, no puedes cambiar el orden cuando el usuario tiene alguna ventana de configuración abierta. El orden no se desvanecerá como los otros parámetros (si se solicita), sino que cambiará instantáneamente al valor solicitado una vez recibida la solicitud.

Para los campos que establecen el objetivo del movimiento (`"positionX"`, `"positionY"`, `"size"` y `"rotation"`), consulta la documentación de `ItemLoadRequest`. La única diferencia es que este `ItemMoveRequest` no devolverá un error si los valores dados son demasiado altos o bajos. En su lugar, puedes establecer valores de `-1000` o menores si deseas que un campo respectivo sea ignorado. Si haces eso, ese campo no se incluirá en el movimiento y en su lugar se usará el valor actual respectivo.


#### Tipos de desvanecimiento de transición de movimiento de elementos

Puedes establecer el tipo de movimiento para el desvanecimiento de posición/rotación/tamaño usando el campo `"fadeMode"`. Los valores aceptados son `"linear"`, `"easeIn"`, `"easeOut"`, `"easeBoth"`, `"overshoot"` y `"zip"`. Solo se usarán si el campo `"timeInSeconds"` fue establecido en un valor mayor a `0`.

Si deseas que el usuario pueda detener el movimiento haciendo clic/arrastrando el elemento mientras se mueve, establece `"userCanStop"` en `true`. Si lo configuras en `false`, los usuarios no podrán interactuar con el elemento mientras el movimiento esté en curso.

Aquí tienes una representación visual de los modos de movimiento:

![Modos de movimiento de VTube Studio](/Images/vts_movement_modes_smooth.png)

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ItemMoveRequest",
	"data": {
		"itemsToMove":
		[
			{
				"itemInstanceID": "ItemInstanceId",
				"timeInSeconds": 1,
				"fadeMode": "easeOut",
				"positionX": 0.2,
				"positionY": -0.8,
				"size": 0.6,
				"rotation": 180,
				"order": -1000,
				"setFlip": true,
				"flip": false,
				"userCanStop": true
			},
			{
				"itemInstanceID": "SomeOther_ItemInstanceId",
				"timeInSeconds": 0.5,
				"fadeMode": "zip",
				"positionX": 1,
				"positionY": 1,
				"size": 0.3,
				"rotation": 0,
				"order": 25,
				"setFlip": false,
				"flip": false,
				"userCanStop": false
			}
		]
	}
}
```

Si la solicitud fue exitosa, recibirá una respuesta que contiene el estado de todos los elementos solicitados.

**`RESPUESTA`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ItemMoveResponse",
	"data": {
		"movedItems":
		[
			{
				"itemInstanceID": "ItemInstanceId",
				"success": true,
				"errorID": -1
			},
			{
				"itemInstanceID": "SomeOther_ItemInstanceId",
				"success": false,
				"errorID": 900
			}
		]
	}
}
```

## Establecer el orden de clasificación dentro del modelo para un elemento

#### ⚠️ Esta solicitud solo está disponible actualmente en la [rama beta pública](https://github.com/DenchiSoft/VTubeStudio/wiki/Joining-the-Beta) ⚠️

VTube Studio te permite ordenar y fijar elementos **entre las capas** de tu modelo principal. Para información general sobre cómo funciona esto, consulta la página sobre "[Fijación de elementos entre capas](https://github.com/DenchiSoft/VTubeStudio/wiki/Between-Layer-Item-Pinning)".

Para los [elementos Live2D](https://github.com/DenchiSoft/VTubeStudio/wiki/Live2D-Items) específicamente, también puedes dividir el **modelo del elemento Live2D** en una parte frontal y una trasera e insertarlos por separado en el modelo principal.

Para identificar el elemento cuyo orden dentro del modelo quieres cambiar, pasa su ID de instancia de elemento usando el campo `"itemInstanceID"`. Se devuelve un error `ItemSortRequestInstanceIDNotFound` si no se encuentra un elemento con ese ID. Para obtener los IDs de instancia de todos los elementos cargados, puedes usar la `ItemListRequest`. El ID también se devuelve directamente cuando usas la `ItemLoadRequest` para cargar un elemento a través de la API.

Para todos los errores que esta solicitud puede devolver, consulta "[ErrorsID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)".

*Nota:* Los elementos normales (no Live2D) no tienen "parte trasera" ni "punto de división", por lo que los campos de trasera/división se ignoran completamente al usar esta solicitud para elementos normales. Puedes dejarlos vacíos/`null`. El texto a continuación asume que estás usando esta solicitud para elementos Live2D. Además, VTube Studio se asegurará de que, incluso si colocas la parte trasera delante de la parte frontal, no se moverá más allá de esta.

Para insertar el elemento en el modelo, establece `"frontOn"` en `true`. Si tienes un elemento Live2D y quieres insertar su parte trasera más atrás en el modelo, también puedes establecer `"backOn"` en `true` (ignorado para elementos no Live2D).

El punto de división y los puntos de inserción frontal/trasero se establecen usando `"splitAt"`, `"withinModelOrderFront"` y `"withinModelOrderBack"`. La interpretación de estos campos depende de lo que pases a través de `"setSplitPoint"`, `"setFrontOrder"` y `"setBackOrder"`.

Los siguientes campos se usan para establecer el punto de división del elemento y el/los punto(s) de inserción:

* `"splitAt"`: Establece el punto de división usado para dividir el modelo del elemento Live2D en parte frontal y trasera.
  * Ignorado para elementos no Live2D.
  * Si `"setSplitPoint"` está establecido en `"Unchanged"`: El valor en `"splitAt"` será ignorado y el punto de división permanecerá sin cambios.
  * Si `"setSplitPoint"` está establecido en `"UseArtMeshID"`: `"splitAt"` espera un ID de ArtMesh que exista en el modelo Live2D del elemento y devolverá el error `ItemSortRequestInvalidSplitPoint` si ese ID de ArtMesh no existe.
* `"withinModelOrderFront"`: Establece dónde insertar el elemento en el modelo principal (o la parte frontal del elemento en caso de elementos Live2D).
  * Si `"setFrontOrder"` está establecido en `"Unchanged"`: El valor en `"withinModelOrderFront"` será ignorado y la posición de inserción de la parte frontal quedará sin cambios.
  * Si `"setFrontOrder"` está establecido en `"UseArtMeshID"`: `"withinModelOrderFront"` espera un ID de ArtMesh que exista en el modelo Live2D principal, pero si no existe, la solicitud aún devolverá éxito porque podría ser un ID para un modelo Live2D que no está cargado actualmente.
  * Si `"setFrontOrder"` está establecido en `"UseSpecialID"`: `"withinModelOrderFront"` espera `"FullyInFront"` o `"FullyInBack"` para siempre colocar el elemento (parte frontal) completamente delante o completamente detrás del modelo principal cargado. Cualquier otro valor devolverá un error `ItemSortRequestInvalidFrontOrder` en este caso.
* `"withinModelOrderBack"`: Establece dónde insertar la parte trasera de los elementos Live2D en el modelo principal.
  * Ignorado para elementos no Live2D.
  * Si `"setBackOrder"` está establecido en `"Unchanged"`: El valor en `"withinModelOrderBack"` será ignorado y la posición de inserción de la parte trasera quedará sin cambios.
  * Si `"setBackOrder"` está establecido en `"UseArtMeshID"`: `"withinModelOrderBack"` espera un ID de ArtMesh que exista en el modelo Live2D principal, pero si no existe, la solicitud aún devolverá éxito porque podría ser un ID para un modelo Live2D que no está cargado actualmente.
  * Si `"setBackOrder"` está establecido en `"UseSpecialID"`: `"withinModelOrderBack"` espera `"FullyInBack"` para siempre colocar el elemento (parte trasera) completamente detrás del modelo principal cargado. Cualquier otro valor devolverá un error `ItemSortRequestInvalidBackOrder` en este caso.

Los valores inválidos en `"setSplitPoint"`, `"setFrontOrder"` y `"setBackOrder"` devolverán un error `ItemSortRequestInvalidValueSetType`.

También devolverá el error `ItemSortRequestItemConfigWindowOpen` si la ventana de orden de clasificación dentro del modelo está abierta actualmente (es decir, si el usuario está configurando manualmente las posiciones de inserción).

**`SOLICITUD`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ItemSortRequest",
	"data": {
		"itemInstanceID": "b616cf51fe3444729ccbf6ee54a14d1a",
		"frontOn": true,
		"backOn": true,
		"setSplitPoint": "UseArtMeshID",
		"setFrontOrder": "UseArtMeshID",
		"setBackOrder": "UseSpecialID",
		"splitAt": "MyArtMeshIDInItemModel91",		
		"withinModelOrderFront": "MyArtMeshIDInMainModel73",
		"withinModelOrderBack": "FullyInBack"
	}
}
```

Si la solicitud fue exitosa, recibirá esta respuesta.

`"itemInstanceID"` devolverá el ID de instancia del artículo para el cual se realizó la solicitud.

Si un modelo principal está cargado actualmente, `"modelLoaded"` será `true` y `"modelID"` y `"modelName"` contendrán el ID y el nombre del modelo. Si no hay ningún modelo cargado, estos campos estarán vacíos.

Si un modelo principal está cargado, `"loadedModelHadRequestedFrontLayer"` y `"loadedModelHadRequestedBackLayer"` le indicarán si los puntos de inserción frontal/trasero que proporcionó se encontraron en el modelo actualmente cargado. Si los puntos de inserción no fueron modificados, estos campos se establecen en `false`.

**`RESPONSE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ItemSortResponse",
	"data": {
		"itemInstanceID": "b616cf51fe3444729ccbf6ee54a14d1a",
		"modelLoaded": true,
		"modelID": "d87b771d2902473bbaa0226d03ef4754",
		"modelName": "Akari",
		"loadedModelHadRequestedFrontLayer": true,
		"loadedModelHadRequestedBackLayer": true
	}
}
```


## Solicitar al usuario que seleccione ArtMeshes

Puedes usar esta solicitud para mostrar una lista en VTube Studio que contenga todos los ArtMeshes del modelo Live2D principal actualmente cargado y permitir que el usuario seleccione uno o más de ellos. Una vez que el usuario termine de seleccionar los ArtMeshes, se devolverán los IDs de los ArtMeshes. Puedes usar esos IDs de ArtMesh en varias otras solicitudes de la API, por ejemplo, para aplicar un tinte de color o hacerlos invisibles.

Si no hay ningún modelo cargado actualmente o hay otras ventanas abiertas, la solicitud devolverá un error.

El usuario puede pasar el cursor sobre los ArtMeshes para mostrar su ID y hacer clic en ellos para filtrar la lista mostrada con todos los ArtMeshes bajo la posición del clic. La interfaz que muestra esta solicitud se ve así:

![Pantalla de solicitud de selección de ArtMesh de la API](/Images/vts_request_select_artmeshes.png)

Usa el campo `requestedArtMeshCount` para especificar cuántos ArtMeshes debe activar el usuario. El botón "OK" estará deshabilitado hasta que se activen exactamente esa cantidad de ArtMeshes. Si estableces `requestedArtMeshCount` en 0 o un valor menor, se le pedirá al usuario que elija cualquier número arbitrario de ArtMeshes (pero al menos uno).

Si quieres preactivar ArtMeshes en la lista, puedes usar la lista `activeArtMeshes` y pasar algunos IDs de ArtMesh. Si alguno de esos IDs no está contenido en el modelo actual, se devolverá un error. Si quieres obtener una lista de todos los ArtMeshes en el modelo actualmente cargado, usa la `ArtMeshListRequest`.

Como puedes ver en la captura de pantalla anterior, la lista tiene un texto predeterminado que se muestra, pidiendo al usuario que seleccione ArtMeshes para el plugin. El mismo texto se muestra en una ventana emergente cuando presionas el botón `?` (ayuda) en la esquina superior derecha. Puedes sobrescribir ambas cadenas usando los campos `textOverride` y `helpOverride` respectivamente. Si los dejas vacíos (cadena vacía), nulos o los omites en la carga útil, se usará el mensaje predeterminado mostrado arriba. Si deseas sobrescribir esos mensajes, la cadena que proporciones debe tener entre 4 y 1024 caracteres, de lo contrario se usará el predeterminado. Puedes usar `\n` para saltos de línea en las cadenas que proporciones.

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ArtMeshSelectionRequest",
	"data": {
		"textOverride": "This text is shown over the ArtMesh selection list.",
		"helpOverride": "This text is shown when the user presses the ? button."
		"requestedArtMeshCount": 5
		"activeArtMeshes": [
			"D_BODY_00",
			"D_ARM_R_05"
		]
	}
}
```

Si la solicitud tiene éxito, la lista de selección se mostrará al usuario. No habrá una respuesta inmediata. La respuesta llegará una vez que el usuario haga clic en el botón "OK" o "Cancelar". El botón "Cancelar" siempre estará disponible, pero el botón "OK" solo será clickeable una vez que se haya seleccionado la cantidad solicitada de ArtMeshes.

Los ArtMeshes activados/desactivados se devolverán en los arrays `activeArtMeshes` y `inactiveArtMeshes` respectivamente. No habrá **superposición** entre esos arrays, por lo que si combinas los ArtMeshes en esos arrays, tendrás una lista de todos los ArtMeshes en el modelo.

Si el usuario hizo clic en "OK", el campo `success` será `true`. Si el usuario hizo clic en "Cancelar", el campo `success` será `false` (en ese caso probablemente deberías ignorar los arrays `activeArtMeshes` y `inactiveArtMeshes`, aunque aún así serán devueltos).

**`RESPONSE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ArtMeshSelectionResponse",
	"data": {
		"success": true
		"activeArtMeshes": [
			"D_BROW_00",
			"D_EYE_BALL_03",
			"D_EYE_BALL_02",
			"D_EYE_BALL_01",
			"D_EYE_BALL_00",
			"D_EYE_11"
		],
		"inactiveArtMeshes": [
			"D_EAR_06",
			"D_BODY_00",
			"D_ARM_R_05"
		]
	}
}
```


## Fijar elementos al modelo

Puede usar esta solicitud para fijar elementos en la escena al modelo cargado actualmente.

El ID de instancia del elemento para identificar el elemento debe especificarse en el campo `itemInstanceID`. Si desea despegar el elemento, simplemente establezca `pin` en `false`. No se debe proporcionar ninguna otra información en ese caso. Si no hay ningún elemento con ese ID cargado actualmente, se devuelve un error (consulte [ErrorsID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)).

Si desea fijar un elemento, la posición de fijación debe proporcionarse en el objeto `pinInfo`. Hay varias formas de fijar un elemento. Por ejemplo, puede proporcionar una posición exacta para fijar o simplemente proporcionar un ArtMesh y dejar que VTS fije el elemento al centro de este o a una posición aleatoria en el ArtMesh. Cómo funciona exactamente esto se describirá a continuación.

Cuando envía una `ItemPinRequest` para un elemento con una `ItemMoveRequest` activa, la `ItemMoveRequest` se cancelará automáticamente.

Además, si su plugin (o varios plugins diferentes) envían múltiples solicitudes de fijación para el mismo elemento y se reciben dentro del mismo cuadro en VTS, solo se ejecuta la última solicitud de fijación recibida mientras que las demás se descartan.

### Opciones para fijar

Hay tres campos que determinan cómo se interpreta la información dada en `pinInfo`:

* `angleRelativeTo`: ¿Cómo debe interpretarse el ángulo proporcionado?
  * `RelativeToWorld`: Ángulo absoluto. Eso significa que si pasa 0 como ángulo, el elemento se fijará verticalmente con un ángulo de 0 en comparación con la ventana de VTS. Usaría esto si desea que el elemento mire en una dirección determinada relativa a la ventana de VTS.
  * `RelativeToCurrentItemRotation`: Relativo al ángulo en el que el elemento está actualmente. Si pasa 0 como ángulo, eso significa que el elemento se fijará en el ángulo en el que ya está, lo que significa que su rotación actual no cambiará. Usaría esto si no desea cambiar la rotación del elemento y simplemente fijarlo tal cual.
  * `RelativeToModel`: Ángulo relativo a la rotación del modelo. Eso significa que si pasa 0 como ángulo y el usuario ha rotado el modelo, el elemento se fijará verticalmente en relación con el modelo. Esta "rotación del modelo" no incluye la rotación causada por la deformación del Live2D ArtMesh, solo la rotación real aplicada a todo el modelo por VTube Studio. Usaría esto si desea que el elemento mire en una dirección determinada relativa a la rotación actual del modelo.
  * `RelativeToPinPosition`: Ángulo relativo a la posición de fijación. Esto es lo que debe usar si desea fijar un elemento en una posición determinada dentro de un ArtMesh determinado en un ángulo determinado y desea que ese ángulo sea exactamente el mismo sin importar cómo esté rotado el modelo en este momento o cómo esté deformado el ArtMesh. Sin embargo, el ángulo que debe pasar para obtener el efecto deseado será completamente diferente para cada posición de fijación.
* `sizeRelativeTo`:
  * `RelativeToWorld`: Tamaño absoluto. Entre 0 (más pequeño) y 1 (más grande). Vea también `ItemLoadRequest`.
  * `RelativeToCurrentItemSize`: Relativo al tamaño actual del elemento. Puede pasar números entre `-1` y `1`, que se agregarán al tamaño actual del elemento, lo que significa que puede pasar 0 si desea fijar el elemento en su tamaño actual sin cambiarlo.
* `vertexPinType`: 
  * `Provided`: El elemento se fijará al ArtMesh dado usando la posición de fijación proporcionada en los campos `vertexID1`, `vertexID2`, `vertexID3`, `vertexWeight1`, `vertexWeight2` y `vertexWeight3`. Los detalles se explicarán a continuación.
  * `Center`: El elemento se fijará al "centro" del ArtMesh dado. No es realmente el centro (espacialmente) sino en realidad el triángulo en el medio de la lista de triángulos del mesh. Esto le dará la misma posición cada vez para un ArtMesh dado.
  * `Random`: El elemento se fijará a un triángulo aleatorio dentro del ArtMesh dado.

Si el ID de modelo proporcionado no coincide con el modelo cargado, se devuelve un error. También puede dejar el ID del modelo vacío, lo que intentará fijar al modelo cargado actualmente (si hay uno cargado).

Si el modelo no tiene el ArtMesh con el ID de ArtMesh que proporcionó, se devuelve un error. Si deja el ID de ArtMesh vacío, se elegirá un ArtMesh aleatorio en el modelo.

Por ejemplo, podría dejar tanto el ID del modelo como el ID del ArtMesh vacíos y establecer `vertexPinType` en `Random`. Eso simplemente fijará el elemento a una posición aleatoria en un ArtMesh aleatorio en el modelo cargado actualmente.

### Fijación a una posición específica

Si establece `vertexPinType` en `Provided`, debe usar los campos `vertexID1`, `vertexID2`, `vertexID3`, `vertexWeight1`, `vertexWeight2` y `vertexWeight3` para proporcionar una posición válida en el ArtMesh que seleccionó usando los campos `modelID` y `artMeshID`.

Los tres campos de ID de vértice deben ser los IDs de vértices de un triángulo en el ArtMesh dado. Para definir una posición dentro de ese triángulo específico, use los campos de peso de vértice. Esos campos se multiplicarán con las posiciones de los vértices para definir una posición en el triángulo. Tenga en cuenta que los pesos deben sumar exactamente 1, de lo contrario la posición resultante estaría fuera del triángulo (y se devolverá un error). Esas son [coordenadas baricéntricas](https://es.wikipedia.org/wiki/Sistema_de_coordenadas_baric%C3%A9ntricas).

Para obtener una de esas posiciones, puede usar el [ModelClickedEvent](https://github.com/DenchiSoft/VTubeStudio/tree/master/Events#model-clicked-event). Este evento devolverá posiciones de pines que puede usar con el `ItemPinRequest` cuando se haga clic en el modelo.

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ItemPinRequest",
	"data": {
		"pin": true,
		"itemInstanceID": "4a241269394f463ca16b8b21aa636568",
		"angleRelativeTo": "RelativeToModel",
		"sizeRelativeTo": "RelativeToWorld",
		"vertexPinType": "Provided",
		"pinInfo": {
			"modelID": "d87b771d2902473bbaa0226d03ef4754",
			"artMeshID": "hair_right_4",
			"angle": 23.938,
			"size": 0.33,
			"vertexID1": 17,
			"vertexID2": 9,
			"vertexID3": 55,
			"vertexWeight1": 0.25928378105163576,
			"vertexWeight2": 0.6850675940513611,
			"vertexWeight3": 0.055648624897003177
		}
	}
}
```
Si tiene éxito, la respuesta contiene el ID del ítem, el nombre del archivo del ítem y si el ítem está ahora fijado o no.

**`RESPUESTA`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ItemPinResponse",
	"data": {
		"isPinned": true,
		"itemInstanceID": "4a241269394f463ca16b8b21aa636568",
		"itemFileName": "my_test_item_2.png",
	}
}
```

## Obtener lista de efectos de postprocesamiento y estado

**Nota:** Los términos efectos visuales, VFX y efectos de postprocesamiento se usan indistintamente en este documento.

VTube Studio tiene postprocesamiento incorporado, que permite agregar efectos visuales directamente a la escena. Esto está disponible en Windows y macOS. Para más información, consulte la página ["Visual Effects"](https://github.com/DenchiSoft/VTubeStudio/wiki/Visual-Effects).

Esta solicitud devuelve el estado general del sistema de postprocesamiento, una lista de todos los presets de postprocesamiento existentes (creados por el usuario) y una lista de todos los efectos de postprocesamiento disponibles con su valor actual (estado actual de postprocesamiento).

Si establece `fillPostProcessingPresetsArray` en `false`, el arreglo `postProcessingPresets` en la carga de respuesta estará vacío. Solicitar la lista de presets de postprocesamiento requiere leer los archivos de presets del disco (aunque están en caché por un tiempo en VTS), lo que puede ser lento. Si envía esta solicitud con alta frecuencia, asegúrese de que `fillPostProcessingPresetsArray` no sea `true`, de lo contrario podría generar retrasos debido a la E/S de disco.

Si establece `fillPostProcessingEffectsArray` en `false`, el arreglo `postProcessingEffects` en la carga de respuesta estará vacío. Si no necesita la lista completa de efectos de postprocesamiento y sus valores, se recomienda establecer `fillPostProcessingEffectsArray` en `false` porque la carga de respuesta puede ser bastante grande.

Si solo le interesan efectos de postprocesamiento específicos, puede listarlos en el arreglo `effectIDFilter`. De lo contrario, deje el arreglo vacío para no aplicar ningún filtro. Una lista de todos los efectos actuales se puede encontrar aquí: https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/Effects.cs

**Nota:** Estos IDs son aceptados en muchos formatos diferentes, por lo que puede crear un enum para ellos en cualquier estilo de enum que desee. No distinguen mayúsculas y minúsculas y se ignoran `_` o `-`. Por ejemplo, eso significa que en lugar de `ChromaticAberration` podría escribir `Chromatic_Aberration`, `chromatic_aberration`, `CHROMATIC_ABERRATION` o cualquier otro estilo que funcione mejor para usted.

**`SOLICITUD`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "PostProcessingListRequest",
	"data":
	{
		"fillPostProcessingPresetsArray": true,
		"fillPostProcessingEffectsArray": true,
		"effectIDFilter":
		[
			"ASCII",
			"ColorGrading",
			"WeatherEffects",
			"ChromaticAberration"
		]
	}
}
```
La respuesta contiene información general sobre el estado del sistema de postprocesamiento y los arreglos `postProcessingEffects` y `postProcessingPresets` si se solicitan.

`postProcessingSupported` verifica si la plataforma soporta postprocesamiento, lo cual siempre debería ser `true` en Windows y macOS. El campo `postProcessingActive` indica si el usuario ha activado o no el postprocesamiento. Ten en cuenta que también puedes activarlo o desactivarlo mediante la API usando la solicitud `PostProcessingUpdateRequest` descrita a continuación. El uso de `PostProcessingUpdateRequest` puede no ser posible en algunas situaciones, específicamente cuando algunas ventanas o cuadros emergentes relacionados con configuraciones de postprocesamiento están abiertos en VTube Studio. En ese caso, `canSendPostProcessingUpdateRequestRightNow` será `false`.

Existen algunos efectos restringidos/experimentales (ver ["Efectos Restringidos/Experimentales"](https://github.com/DenchiSoft/VTubeStudio/wiki/Visual-Effects#restrictedexperimental-effects)). El usuario debe permitir explícitamente que estos efectos se usen. Si el usuario ha permitido el uso de estos efectos se devuelve en el campo `restrictedEffectsAllowed`.

Si un preset de postprocesamiento está activo o no se devuelve en el campo `presetIsActive`. Si hay uno activo, su nombre aparecerá en el campo `activePreset`, de lo contrario ese campo estará vacío.

`presetCount` contiene el número de presets de postprocesamiento en el arreglo `postProcessingPresets`. Si no solicitaste que se llenara el arreglo, `presetCount` será 0.

`activeEffectCount` es el número de efectos de postprocesamiento activos. Lo que significa que un efecto esté "activo" se explica más adelante en esta sección.

Los campos "effectCount" y "configCount" contienen el número de efectos y el total de configuraciones para todos los efectos antes y después de aplicar el filtro (si solicitaste filtrado).

### El arreglo `postProcessingEffects`

El arreglo `postProcessingEffects` contiene una lista de todos los efectos. Son los mismos efectos que se muestran en la lista de VFX en VTube Studio. Cada efecto puede tener múltiples "configs" que configuran ciertos aspectos del efecto, por ejemplo su intensidad o un color.

El ID que usas para identificar un efecto se devuelve en el campo `enumID`. También existe el campo `internalID` que contiene el ID que VTube Studio usa internamente para ese efecto. Ese es el ID que se usa en los archivos JSON de presets de postprocesamiento, por lo que no debería ser relevante en la mayoría de los casos. Sin embargo, estos IDs también pueden usarse en la API para referirse a los efectos si quieres usarlos por alguna razón.

Las configs tienen uno de los siguientes tipos (devueltos en el campo `type` de la config):
* Float
* Int
* Bool
* String
* Color
* SceneItem

Las configs para un efecto se devuelven en el arreglo `configEntries`. Cada config también tiene un `internalID` y un `enumID`. Todos los IDs de config para todos los efectos con explicaciones se pueden encontrar aquí: https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/EffectConfigs.cs

Para una config, solo se llenan los campos que coinciden con el tipo de esa config. Los otros campos estarán vacíos o tendrán un valor por defecto y deben ser ignorados. Por ejemplo, para una config de tipo float, campos como `intMin` y `colorValue` están vacíos (en este caso 0 y una cadena vacía). Además de un valor por defecto (que todos los tipos tienen), las configs de tipo `Float` y `Int` también tienen un `min` y un `max`.

Para campos que contienen colores, se devuelve una cadena en formato hexadecimal RGBA (como "77CCAAFF") y `colorHasAlpha` indicará si esa config tiene alfa o no. Si es `false`, el alfa siempre será `FF`.

Las configs de tipo `SceneItem` son esencialmente configs tipo cadena, pero el valor debe ser el nombre de archivo de un ítem (terminando en .jpg o .png) que exista en la carpeta "Items" de VTube Studio. Por ejemplo, se usan en el efecto de partículas personalizadas.

### ¿Cuándo se considera un efecto "activo"?



Cada efecto tiene al menos una configuración de tipo float (pero puede tener múltiples) con `activationConfig` establecida en `true`. Si una de esas configuraciones para un efecto tiene un valor mayor que 0, ese efecto se considera `activo`.

Para el efecto `ColorGrading`, por ejemplo, esa sería la configuración `ColorGrading_Strength`.

**Nota:** El `postProcessingEffects` en este ejemplo de carga útil de respuesta está muy abreviado. Cuando no se aplican filtros, puede tener miles de líneas ya que hay más de 250 configuraciones de efectos.

**`RESPUESTA`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "PostProcessingListResponse",
	"data": {
		"postProcessingSupported": true,
		"postProcessingActive": true,
		"canSendPostProcessingUpdateRequestRightNow": true,
		"restrictedEffectsAllowed": false,
		"presetIsActive": true,
		"activePreset": "some_effects_preset_3",
		"presetCount": 70,
		"activeEffectCount": 5,
		"effectCountBeforeFilter": 29,
		"configCountBeforeFilter": 258,
		"effectCountAfterFilter": 4,
		"configCountAfterFilter": 31,
		"postProcessingEffects": [
			{
				"internalID": "color_grading",
				"enumID": "ColorGrading",
				"explanation": "Color grading",
				"effectIsActive": false,
				"effectIsRestricted": false,
				"configEntries": [
					{
						"internalID": "color_grading-strength",
						"enumID": "ColorGrading_Strength",
						"explanation": "Effect on/off",
						"type": "Float",
						"activationConfig": true,
						"floatValue": 0.0,
						"floatMin": 0.0,
						"floatMax": 1.0,
						"floatDefault": 0.0,
						"intValue": 0,
						"intMin": 0,
						"intMax": 0,
						"intDefault": 0,
						"colorValue": "",
						"colorDefault": "",
						"colorHasAlpha": false,
						"boolValue": false,
						"boolDefault": false,
						"stringValue": "",
						"stringDefault": "",
						"sceneItemValue": "",
						"sceneItemDefault": ""
					},
					{
						"internalID": "color_grading-color_filter",
						"enumID": "ColorGrading_ColorFilter",
						"explanation": "Color filter",
						"type": "color",
						"activationConfig": false,
						"floatValue": 0.0,
						"floatMin": 0.0,
						"floatMax": 0.0,
						"floatDefault": 0.0,
						"intValue": 0,
						"intMin": 0,
						"intMax": 0,
						"intDefault": 0,
						"colorValue": "FFFFFFFF",
						"colorDefault": "FFFFFFFF",
						"colorHasAlpha": false,
						"boolValue": false,
						"boolDefault": false,
						"stringValue": "",
						"stringDefault": "",
						"sceneItemValue": "",
						"sceneItemDefault": ""
					}
				]
			}
		],
		"postProcessingPresets": [
			"My Cool Preset",
			"some_effects_preset_1",
			"some_effects_preset_2",
			"some_effects_preset_3",
			"test asdf 123456",
			"blur and color grading",
		]
	}
}
```
## Configurar efectos de postprocesamiento

**Nota:** Los términos efectos visuales, VFX y efectos de postprocesamiento se usan indistintamente en este documento.

VTube Studio tiene postprocesamiento integrado, que permite agregar efectos visuales directamente a la escena. Esto está disponible en Windows y macOS. Para más información, consulta la página ["Visual Effects"](https://github.com/DenchiSoft/VTubeStudio/wiki/Visual-Effects).

Usando el `PostProcessingUpdateRequest`, puedes controlar el sistema de postprocesamiento. Puedes activarlo/desactivarlo, cargar/descargar presets o incluso controlar elementos individuales de configuración directamente y en detalle (colores, intensidades, etc.).

Esta actualización solo puede enviarse si no hay ventanas relacionadas con la configuración de postprocesamiento abiertas. De lo contrario, se devolverá el error `PostProcessingUpdateReqestCannotUpdateRightNow`. Para todos los errores que esta solicitud puede devolver, consulta ["ErrorsID.cs"](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs).

Usa `postProcessingOn` para activar o desactivar el postprocesamiento globalmente. Esto hace lo mismo que alternar el botón de postprocesamiento en la interfaz de VTS. Puedes establecer presets o valores individuales de configuración incluso cuando apagas el postprocesamiento con la misma solicitud. Los valores se establecerán pero no habrá efecto en pantalla. Al abrir la ventana de configuración de postprocesamiento en VTube Studio, verás que tus valores solicitados están establecidos y serán visibles cuando el postprocesamiento se active. Ten en cuenta que si estableces un preset pero apagas el postprocesamiento con la misma solicitud, todos los valores del preset se establecerán pero el preset no aparecerá como activo en la UI porque técnicamente ya no está "activo". Todos los valores del preset serán visibles cuando se active el postprocesamiento nuevamente.

Puedes establecer valores para los elementos de configuración de postprocesamiento usando dos métodos:
* Establecer un preset de postprocesamiento: Pon `setPostProcessingPreset` en `true` y proporciona el nombre del preset en el campo `presetToSet` (solo el nombre del preset sin la extensión del archivo). Si el preset no existe, se devuelve el error `PostProcessingUpdateRequestPresetFileLoadFailed`.
* Establecer valores individuales de configuración: Pon `setPostProcessingValues` en `true` y proporciona una lista de pares clave/valor en el arreglo `postProcessingValues`.

No puedes hacer ambas cosas a la vez: si `setPostProcessingPreset` y `setPostProcessingValues` son ambos `true`, se devolverá el error `PostProcessingUpdateRequestLoadingPresetAndValues`. Sin embargo, ambos pueden ser `false`. En ese caso, no se establecerán valores. Esto puede ser útil si solo quieres activar o desactivar el postprocesamiento globalmente sin cambiar nada de la configuración actual.

Al cambiar los valores de configuración directamente o mediante presets, los valores de configuración se desvanecerán suavemente de los valores antiguos a los nuevos que proporcionaste. La duración del desvanecimiento debe proporcionarse en el campo `postProcessingFadeTime` y debe estar entre 0 y 2 (segundos). Cualquier valor fuera de ese rango devolverá el error `PostProcessingUpdateRequestFadeTimeInvalid`.

Al establecer valores individuales, el campo `setAllOtherValuesToDefault` determina si todos los demás valores (los que no incluiste en tu carga) se mantendrán sin cambios o se desvanecerán a sus valores predeterminados, lo que significa que todos los efectos no mencionados se apagarán.

Si deseas usar cualquier [efecto restringido/experimental](https://github.com/DenchiSoft/VTubeStudio/wiki/Visual-Effects#restrictedexperimental-effects) al establecer valores de configuración directamente, asegúrate de que `usingRestrictedEffects` esté establecido en `true` en tu carga. Esto es solo una comprobación para evitar que esos efectos se usen accidentalmente. De lo contrario, se devolverá el error `PostProcessingUpdateRequestTriedToLoadRestrictedEffect`. Este error también se devolverá si el usuario no ha habilitado el uso de esos efectos en la configuración de VFX de VTube Studio. Esto debe hacerse manualmente por el usuario. Si se carga un preset y contiene efectos restringidos, se cargará completamente sin error, pero los efectos restringidos no se activarán.

También puedes solicitar que todos los efectos se configuren aleatoriamente. Esto es solo por diversión. Para hacerlo, pon `randomizeAll` en `true`. Cualquier valor de configuración o preset que envíes en la carga será ignorado si `randomizeAll` es `true`. Cuando muchos efectos están activos al mismo tiempo, terminas con solo ruido aleatorio, así que esto asegura que el número de efectos esté limitado y los valores no sean demasiado extremos. Esto puede controlarse usando el campo `randomizeAllChaosLevel`, que acepta valores entre 0 y 1 (los valores más altos o bajos se ajustan a ese rango). `0` tendrá solo uno o dos efectos activos con valores suaves, mientras que `1` creará un caos completo en pantalla. `0.4` a `0.5` es el rango recomendado para un buen efecto. Los efectos restringidos solo se incluirán en la aleatorización si estableces `usingRestrictedEffects` en `true` y el usuario ha permitido/habilitado el uso de esos efectos.

### Cómo establecer valores individuales de configuración

Cuando quieras controlar la configuración de postprocesamiento en detalle estableciendo valores individuales, debes poner `setPostProcessingValues` en `true` y establecer los valores mediante el arreglo `postProcessingValues`. `configID` es el ID del efecto de configuración que quieres modificar, `configValue` es el valor que quieres establecer como cadena.

* `configID`: ID de la configuración que quieres modificar, consulta [esta lista de todos los IDs de configuración](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/EffectConfigs.cs). Estos IDs se aceptan en muchos formatos diferentes, así que puedes crear un enum para ellos en cualquier estilo que desees. No distinguen mayúsculas ni minúsculas y `_` o `-` se ignoran. Por ejemplo, en lugar de `Backlight_OutlineSize` podrías escribir `Backlight_Outline_Size`, `backlight_outlinesize`, `BACKLIGHT_OUTLINESIZE`, `backlight-outline_size` o cualquier otro estilo que prefieras (consulta también el campo `enumID` en el arreglo `configEntries` de la respuesta `PostProcessingListResponse`).
* `configValue`: El valor a establecer, como cadena. Para flotantes o enteros, los valores fuera del rango mínimo/máximo de la configuración se ajustarán al límite. Los valores booleanos no distinguen mayúsculas ni minúsculas, por lo que `"True"` y `"true"` (o `"TRUE"`, etc.) son valores aceptados.

Si tienes claves duplicadas en el arreglo, se devolverá el error `PostProcessingUpdateRequestValueListContainsDuplicates` y si alguna clave es inválida (no encontrada) o algún valor inválido (falló al deserializar float, bool, etc. correctamente), se devolverá el error `PostProcessingUpdateRequestValueListInvalid`.

**Cómo activar realmente un efecto:** Los efectos pueden tener muchas entradas de configuración. Cada efecto tiene al menos una entrada de configuración (pero puede tener muchas) que activa el efecto si ese valor es mayor que 0. En la carga `PostProcessingListResponse`, esas configuraciones (siempre de tipo float) están marcadas con `"activationConfig": true`. También puedes ver la lista de todas las configuraciones de efectos, donde esas configuraciones especiales están marcadas con `sets_active: True`, consulta: https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/EffectConfigs.cs

### Consejos generales de uso


No debes enviar esta solicitud a altas frecuencias, por ejemplo, en cada cuadro. Si deseas desvanecer un valor, utiliza el campo `postProcessingFadeTime` para establecer el tiempo de desvanecimiento adecuado. Dependiendo de la combinación de configuración, las actualizaciones frecuentes *pueden* estar bien, pero debes probar cuidadosamente. El sistema de postprocesamiento está optimizado para actualizaciones de configuración poco frecuentes, así que asegúrate de verificar si tu complemento causa algún retraso antes de publicarlo.


```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "PostProcessingUpdateRequest",
	"data":
	{
		"postProcessingOn": true,
		"setPostProcessingPreset": false,
		"setPostProcessingValues": true,
		"presetToSet": "",
		"postProcessingFadeTime": 1.3,
		"setAllOtherValuesToDefault": true,
		"usingRestrictedEffects": false,
		"randomizeAll": false,
		"randomizeAllChaosLevel" : 0.0,
		"postProcessingValues": [
			{
				"configID": "Backlight_Strength",
				"configValue": "0.8"
			},
			{
				"configID": "Bloom_Strength",
				"configValue": "1.0"
			},
			{
				"configID": "Bloom_StreakVertical",
				"configValue": "false"
			},
			{
				"configID": "Bloom_StreakColorTint",
				"configValue": "220308FF"
			}
		]
	}
}
```

Si no hay error, recibirá la siguiente respuesta con información general sobre el nuevo estado de post-procesamiento después de su actualización solicitada.

**`RESPUESTA`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "PostProcessingUpdateResponse",
	"data":
	{
		"postProcessingActive": true,
		"presetIsActive": false,
		"activePreset": "",
		"activeEffectCount": 2
	}
}
```



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-29

---
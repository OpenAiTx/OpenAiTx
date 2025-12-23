# Pushbullet Go

[![Versión en Chrome Web Store](https://img.shields.io/chrome-web-store/v/dghndapbehjdbhiffbckojkhoennbofg)](https://chromewebstore.google.com/detail/push-go-for-pushbullet/dghndapbehjdbhiffbckojkhoennbofg) [![Usuarios en Chrome Web Store](https://img.shields.io/chrome-web-store/users/dghndapbehjdbhiffbckojkhoennbofg)](https://chromewebstore.google.com/detail/push-go-for-pushbullet/dghndapbehjdbhiffbckojkhoennbofg) [![Calificación en Chrome Web Store](https://img.shields.io/chrome-web-store/rating/dghndapbehjdbhiffbckojkhoennbofg)](https://chromewebstore.google.com/detail/push-go-for-pushbullet/dghndapbehjdbhiffbckojkhoennbofg)

> **Nota 1**: El nombre de la extensión ha cambiado a "Push Go" debido a la política de Chrome Web Store.
>
> **Nota 2**: Este es un cliente de terceros, de código abierto, para la API de Pushbullet. No está afiliado ni respaldado por el servicio.

![Pushbullet Go](https://raw.githubusercontent.com/nemofq/pushbullet-go/main/screenshots/1_popup.png)

Una extensión ligera para Chrome de Pushbullet que permite recibir y enviar pushes directamente desde tu navegador.

Esta extensión es compatible con Manifest V3, siendo una alternativa a la extensión oficial que ya no funciona.

[![](https://developer.chrome.com/static/docs/webstore/branding/image/UV4C4ybeBTsZt43U4xis.png)](https://chromewebstore.google.com/detail/push-go-for-pushbullet/dghndapbehjdbhiffbckojkhoennbofg)

## Características

Requiere una cuenta de [Pushbullet](https://www.pushbullet.com/). Las características incluyen:

- Recibir y enviar pushes
- Enviar archivos/imágenes pegando, arrastrando o subiendo (en ventana independiente debido a la restricción de Chrome)
- Enviar URL de la página actual, texto seleccionado o imágenes desde el menú contextual con selección de dispositivo/personas
- Controlar a qué dispositivos enviar los pushes seleccionando dispositivos
- Notificaciones para pushes recibidos con botones para abrir enlaces y descartar
- Apertura automática de enlaces recibidos en una nueva pestaña (desactivado por defecto, activar en la página de opciones)
- Almacena localmente los 100 últimos pushes (historial completo disponible en la web de Pushbullet)
- (Nuevo) Filtro para mostrar y notificar pushes por dispositivo destino
- (Nuevo) Control de notificaciones de pushes originados en el navegador (útil para uso multi-navegador)
- (Nuevo) Espejo de notificaciones (requiere la app Pushbullet para Android instalada y activada tanto en la app Android como en ajustes de Push Go)
- (Nuevo) Modo oscuro (sigue el sistema por defecto, o se puede elegir manualmente)
- (Nuevo) Soporte i18n con 33 idiomas
- (Nuevo) Conteo de no leídos
- (Nuevo) Compartir rápido del enlace de la pestaña actual en el popup (desactivado por defecto, activar en la página de opciones)
- (Nuevo) Reproducir sonido en notificación (se puede desactivar en la página de opciones)
- (Nuevo) Cifrado de extremo a extremo para espejado de notificaciones
- (Nuevo) Extraer código de verificación de notificación espejada (clic para copiar en el popup)

## Instalación
> **Nota 3**: Requiere Chrome 116+ para usar la API `chrome.idle` y mantener la conexión al servidor WebSocket de Pushbullet.

### Recomendado

Instale directamente desde la [Chrome Web Store](https://chromewebstore.google.com/detail/push-go/dghndapbehjdbhiffbckojkhoennbofg) o:

### Manual

1. Descargue y descomprima la extensión desde la carpeta `release/`
2. Abra Chrome y navegue a `chrome://extensions/`
3. Active el "Modo desarrollador" en la parte superior derecha
4. Haga clic en "Cargar descomprimida" y seleccione la carpeta `/src` descomprimida

## Configuración

1. Haga clic en el ícono de la extensión y seleccione "Abrir configuración"
2. Ingrese el token de acceso mediante autenticación OAuth o manualmente (desde [configuración de Pushbullet](https://www.pushbullet.com/#settings/account))
3. Haga clic en el botón recuperar y comience a enviar y recibir notificaciones push
4. Personalice la configuración en la página de opciones según sea necesario

## Permisos

Esta extensión requiere los siguientes permisos:
- **Almacenamiento**: Para guardar sus opciones e historial de push localmente
- **Inactividad**: Para mantener la conexión y recibir push en tiempo real
- **Notificaciones**: Para mostrar notificaciones push
- **Menús contextuales**: Para agregar opciones en el menú de clic derecho para enviar contenido
- **Pestaña activa**: Para acceder a la URL y título de la página actual para acciones de menú contextual y atajos de teclado
- **Acceso a host**: Para comunicarse con los servidores de la API de Pushbullet
- **Fuera de pantalla**: Para reproducir sonido de notificación
- **Identidad**: Para completar el proceso OAuth

## Privacidad

Esta extensión almacena todo localmente y no transmite ninguna información más allá de la API de Pushbullet.

## Licencia

Este proyecto utiliza la [licencia AGPL-3.0](https://github.com/nemofq/pushbullet-go?tab=AGPL-3.0-1-ov-file). Si tiene solicitudes de funciones o comentarios, no dude en crear un issue o pull request.

## Una cosa más

Si también eres usuario de iOS+Pushbullet, es posible que encuentres útiles estos Atajos:

- [Push a Pushbullet](https://www.icloud.com/shortcuts/5549bbb5b06e4f0a8ccb1b6fd33e853f)
- [Receptor de Pushbullet](https://www.icloud.com/shortcuts/1f94913de21b41debe60ef43631afde2)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-23

---
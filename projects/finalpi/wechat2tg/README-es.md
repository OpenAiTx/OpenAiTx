# wechat2tg-mac

Basado en el protocolo de WeChat para Mac, permite enviar y recibir mensajes de WeChat en Telegram. El servicio wx2tg-server no es de código abierto por motivos de seguridad.

## Grupo de Telegram: [@Wx2TgUserGroup](https://t.me/+AD02MEZa-og3ZGY1)

## Funciones principales

1. Recepción de mensajes de chats individuales de WeChat, mensajes de grupos, mensajes de cuentas oficiales y mensajes de WeChat empresarial.
2. Envío de mensajes desde Telegram a usuarios, grupos o cuentas oficiales de WeChat especificados.
3. Bloqueo de mensajes de grupos designados.

## Tipos de mensajes soportados

### Lista de tipos de mensajes de WeChat soportados

+ [x] Mensajes de texto
+ [x] Mensajes de WeChat empresarial
+ [x] Stickers de WeChat
+ [x] Mensajes de imagen
+ [x] Mensajes de video
+ [x] Llamadas de audio/video (solo notificaciones de mensajes)
+ [x] Mensajes de archivos
+ [x] Mensajes de enlaces
+ [x] Mensajes de grupo
+ [x] Mensajes de grupo con @ (tanto @todos como @tú se convertirán en Telegram @tú)
+ [x] Mensajes de cuentas oficiales
+ [x] Emoji
+ [x] Mensajes de ubicación
+ [x] Mensajes retirados
+ [x] Mensajes de voz
+ [ ] Mensajes de sobres rojos (solo alerta, no se puede obtener el contenido)
+ [ ] Mensajes de mini programas

### Lista de tipos de mensajes de Telegram soportados

+ [x] Mensajes de texto
+ [x] Stickers
+ [x] Mensajes de imagen
+ [x] Mensajes de video
+ [x] Mensajes de archivos
+ [x] Mensajes de voz

## Notas importantes

1. Este proyecto es solo para investigación técnica y aprendizaje, no se debe utilizar para fines ilegales.
2. Si tienes cualquier problema, no dudes en enviar un issue.

## Instalación y despliegue

Primero, copia `.env.example` a un archivo `.env` y configura las variables de entorno en el archivo `.env`.

Copia `app.conf.example` del proyecto a un archivo `app.conf` en el directorio `conf` y ajusta la dirección de Redis a la de tu propia instancia de Redis.

### docker-compose

Crea un archivo `docker-compose.yml`:

```yaml
version: '3'

services:
  wx2tg-mac:
    image: finalpi/wechat2tg-mac:latest
    container_name: wx2tg-mac
    volumes:
      - ./config:/app/storage
      - ./save-files:/app/save-files # Al montar esta carpeta, los archivos de stickers no necesitan ser convertidos de nuevo
    env_file: ".env"
    restart: unless-stopped

  wx2tg-server:
    image: finalpi/wx2tg-server:latest # Descargar imagen
    container_name: wx2tg-server
    ports:
      - "8058:8058"
    volumes:
      - ./conf:/usr/wic-go/conf
    restart: unless-stopped

  wx2tg-redis:
    image: redis:7.2
    container_name: wx2tg-redis
    ports:
      - "16379:6379"
    volumes:
      - ./redis-data:/data
    command: ["redis-server", "--appendonly", "yes"]
    restart: unless-stopped
```

#### Ejecutar

```shell
docker-compose up -d
```

#### Desactivar el modo de privacidad del bot

Desactiva el modo de privacidad del bot. Abre BotFather, escribe `/mybots`, elige tu bot. Haz clic en `Bot Settings` - `Group Privacy` - `Turn off`. Si ves `Privacy mode is disabled for xxx`, el modo de privacidad se ha desactivado con éxito.

## Instrucciones de uso

### Comandos del BOT

- `/login`: Obtiene el código QR para iniciar sesión; la primera persona que envíe el comando `/login` después del despliegue será el propietario del `BOT`.

- `/flogin`: Obtiene el código QR del asistente de transferencia de archivos; permite recibir videos y archivos.

- `/update`: Actualiza la información de avatares y nombres de grupos.

- `/message`: Activa/desactiva la recepción de mensajes de grupo.

- `/forward`: Activa/desactiva el reenvío de mensajes de otros miembros o del bot en el grupo.

- `/user`: Obtiene la lista de usuarios de WeChat; al hacer clic en el botón puedes crear un nuevo grupo o vincular un usuario (puedes buscar por nombre o alias, por ejemplo: `/user 张` para buscar usuarios de WeChat que contengan "张").

- `/room`: Obtiene la lista de grupos de WeChat; al hacer clic en el botón puedes crear un nuevo grupo o vincular un grupo de WeChat (puedes buscar por nombre o alias, por ejemplo: `/room 外卖` para buscar grupos de WeChat que contengan "外卖").

- `/settings`: Configuración del programa.

- `/unbind`: Desvincula un grupo de WeChat o un usuario de WeChat (solo se puede usar en grupos).

### Descripción de las variables de entorno

|Nombre| Obligatorio | Descripción                                                             |
|--|------|----------------------------------------------------------------|
|`BOT_TOKEN`| Sí    | Token del Bot de Telegram, crea uno usando [BotFather](https://t.me/BotFather) |
|`API_ID`| Sí    | API ID de la API de Telegram                                          |
|`API_HASH`| Sí    | API HASH de la API de Telegram                                        |
|`BASE_API`| Sí    | Dirección completa de la API del contenedor wx2tg-server                            | |
|`PROXY_PROTOCOL`| No    | Tipo de proxy opcional (socks5,http,https)                                     |
|`PROXY_HOST`| No    | URL del proxy                                                        |
|`PROXY_PORT`| No    | Puerto del proxy                                                         |
|`PROXY_USERNAME`| No    | Nombre de usuario del proxy                                                         |
|`PROXY_PASSWORD`| No    | Contraseña del proxy                                                          |
|`ROOM_MESSAGE`| No    | Formato de visualización de mensajes de grupo de WeChat en el BOT                      |
|`OFFICIAL_MESSAGE`| No    | Formato de visualización de mensajes de cuentas oficiales en el BOT                 |
|`CONTACT_MESSAGE`| No    | Formato de visualización de mensajes de usuarios de WeChat en el BOT                 |
|`ROOM_MESSAGE_GROUP`| No    | Formato de visualización de mensajes de grupo de WeChat en grupos                  |
|`CONTACT_MESSAGE_GROUP`| No    | Formato de visualización de mensajes de usuarios de WeChat en grupos               |
|`OFFICIAL_MESSAGE_GROUP`| No    | Formato de visualización de mensajes de cuentas oficiales en grupos                |
|`CREATE_ROOM_NAME`| No    | Formato del nombre del grupo al crear automáticamente un grupo de WeChat              |
|`CREATE_CONTACT_NAME`| No    | Formato del nombre del grupo al crear automáticamente un contacto de WeChat         |
|`MESSAGE_DISPLAY`| No    | Formato de visualización de mensajes de texto                                     |

 ---

### Descripción del comando `/settings`

1. ¿Mostrar emoji de WeChat como enlaces de imagen?: Si se activa, los emojis tipo carita amarilla de tus amigos se mostrarán como enlaces de imagen.

2. Sincronizar información de grupo al iniciar: Si se activa, al iniciar el programa se sincronizará la información de todos los usuarios, actualizando los avatares y nombres de los grupos.

---

### Transcripción de voz a texto

1. Configura `TENCENT_SECRET_ID` y `TENCENT_SECRET_KEY`, puedes obtenerlos en la [consola de reconocimiento de voz de Tencent](https://console.cloud.tencent.com/asr). Hay cuota gratuita disponible.
2. Activa la función de transcripción automática de voz a texto en `/settings`.

---

### Cómo obtener `API_ID` y `API_HASH`

1. Inicia sesión en [telegram account](https://my.telegram.org/)

2. Haz clic en "API development tools" y rellena los detalles de la aplicación (solo se requiere título y nombre corto).

3. Haz clic en "Create application".

---

### Plantillas de mensajes personalizadas

Si deseas modificar el formato del remitente del mensaje, puedes cambiar las variables de entorno en el docker o en el archivo `.env`.

Marcadores para plantillas de mensajes personalizadas:

`#[alias]`: Alias del contacto

`#[name]`: Nombre del contacto

`#[topic]`: Nombre del grupo

`#[alias_first]`: Prioriza el alias, si no hay alias muestra el nombre del contacto

`#[identity]`: Información de identidad

`#[body]`: Texto del mensaje

`#[br]`: Salto de línea

### Cómo @todos

Enviar un mensaje que empiece con `@all` mencionará a todos. Solo funciona para mensajes de texto.

---

## Preguntas frecuentes


## Participa en el desarrollo

1. Haz fork del proyecto, cambia a la rama `wx2tg-mac-dev` o crea una nueva rama. No envíes código directamente a la rama principal.
2. Envía un Pull Request a la rama `wx2tg-mac-dev`.


## Licencia

[MIT](LICENSE)


## Agradecimientos

Agradecimientos a Jetbrains por el apoyo a este proyecto

[<img src="https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png" width="200">](https://www.jetbrains.com)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---
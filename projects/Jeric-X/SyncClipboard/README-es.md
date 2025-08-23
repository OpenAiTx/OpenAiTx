# SyncClipboard
[![build](https://github.com/Jeric-X/SyncClipboard/actions/workflows/build-entry.yml/badge.svg?branch=master)](https://github.com/Jeric-X/SyncClipboard/actions?query=branch%3Amaster)

中文 | [English](https://raw.githubusercontent.com/Jeric-X/SyncClipboard/master/docs/README_EN.md)  

<details>
<summary>Contenido</summary>

- [SyncClipboard](#syncclipboard)
  - [Funciones](#funciones)
  - [Servidor](#servidor)
    - [Servidor independiente](#servidor-independiente)
      - [Configuración del servidor](#configuración-del-servidor)
      - [Docker](#docker)
      - [Arch Linux](#arch-linux)
    - [Servidor integrado en el cliente](#servidor-integrado-en-el-cliente)
    - [Servidor WebDAV](#servidor-webdav)
  - [Cliente](#cliente)
    - [Windows](#windows)
      - [Versión portátil](#versión-portátil)
      - [Exclusiones comunes](#exclusiones-comunes)
    - [macOS](#macos)
      - [Instalación manual](#instalación-manual)
      - [Exclusiones comunes](#exclusiones-comunes-1)
    - [Linux](#linux)
      - [Instalación manual](#instalación-manual-1)
      - [Arch Linux](#arch-linux-1)
      - [Exclusiones comunes](#exclusiones-comunes-2)
    - [Parámetros de línea de comandos del cliente de escritorio](#parámetros-de-línea-de-comandos-del-cliente-de-escritorio)
      - [--shutdown-previous](#--shutdown-previous)
      - [--command-{command-name}](#--command-command-name)
    - [IOS](#ios)
      - [Uso de atajos](#uso-de-atajos)
    - [Android](#android)
      - [Uso de HTTP Request Shortcuts](#uso-de-http-request-shortcuts)
      - [Uso de Autox.js](#uso-de-autoxjs)
      - [Uso de SmsForwarder](#uso-de-smsforwarder)
      - [Uso de Tasker](#uso-de-tasker)
    - [Descripción de la configuración del cliente](#descripción-de-la-configuración-del-cliente)
  - [API](#api)
    - [Obtener/Subir portapapeles (texto)](#获取上传剪贴板文字)
    - [Obtener/Subir portapapeles (imagen/archivo)](#获取上传剪贴板图片文件)
    - [SyncClipboard.json](#syncclipboardjson)
  - [Dependencias del proyecto](#项目依赖)

</details>

## Funcionalidad

- Sincronización del portapapeles, compatible con texto, imágenes y archivos. Arquitectura servidor/cliente, puede usar servidor integrado en el cliente, servidor desplegado independientemente o almacenamiento en la nube con soporte WebDAV como servidor  
- Optimización del portapapeles para tipos de imagen, con funciones como:
  - Al copiar una imagen desde cualquier ubicación, se puede pegar directamente como archivo en el sistema de archivos y viceversa
  - Al copiar imágenes desde el navegador, descarga en segundo plano la imagen original localmente, solucionando problemas para copiar imágenes animadas desde el navegador (la mayoría de sitios requieren autenticación, uso limitado, compatible con imágenes animadas de bilibili)
  - Al copiar archivos de imagen en formatos recientes (webp/heic, etc.) desde el sistema de archivos, almacena en el portapapeles en formato gif o jpg para pegar directamente en cuadros de texto que soportan imágenes

## Servidor
### Servidor independiente
[SyncClipboard.Server](https://github.com/Jeric-X/SyncClipboard/releases/) soporta ejecución multiplataforma, depende de [ASP.NET Core 8.0](https://dotnet.microsoft.com/zh-cn/download/dotnet/8.0), tras instalar el `runtime de ASP.NET Core`, ejecutar el siguiente comando
```
dotnet /path/to/SyncClipboard.Server.dll --contentRoot ./
```
El directorio de trabajo debe ser el mismo que el directorio donde se encuentra el dll y debe tener permisos de escritura. Si necesita cambiar el directorio de trabajo, copie una copia de `appsettings.json` al nuevo directorio de trabajo y modifique la ruta después de `--contentRoot`  

#### Configuración del servidor
El servidor se configura mediante el archivo `appsettings.json`, con el siguiente formato:
```jsonc
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "Kestrel": {
    "Endpoints": {
      "http": {
        "Url": "http://*:5033"
      },
      //"https": {
      //  "Url": "https://*:5033"
      //}
    },
    //"Certificates": {
    //  "Default": {
    //    "Path": "/path/to/pem",
    //    "KeyPath": "/path/to/pem_key"
    //  }
    //}
  },
  "AppSettings": {
    "UserName": "your_username",
    "Password": "your_password"
  }
}
```
Para habilitar HTTPS, descomente las secciones `https` y `Certificates`, y configure la ruta del certificado HTTPS. Finalmente, comente o elimine la sección `http` para desactivar la conexión insegura. Para habilitar HTTP y HTTPS simultáneamente, configure las `Url` de ambos en diferentes números de puerto.  
Los métodos de configuración para diferentes tipos de certificados pueden consultarse en la [documentación oficial de Microsoft](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/servers/kestrel/endpoints?view=aspnetcore-8.0#configure-https-in-appsettingsjson)

El nombre de usuario y la contraseña pueden configurarse mediante variables de entorno; cuando las variables `SYNCCLIPBOARD_USERNAME` y `SYNCCLIPBOARD_PASSWORD` no están vacías, se priorizan estas como usuario y contraseña.  

La variable de entorno `ASPNETCORE_hostBuilder__reloadConfigOnChange` configura si se debe detectar automáticamente cambios en appsettings.json y recargar la configuración. El valor predeterminado es `false`; al cambiarlo a cualquier valor distinto de `false` se habilita esta función.

> [!WARNING]  
> HTTP utiliza transmisión en texto claro; si el servidor se despliega en una red pública, habilite HTTPS o configure HTTPS mediante una herramienta de proxy inverso. Si no se puede obtener un certificado de una autoridad certificadora, se recomienda usar la herramienta de código abierto [mkcert](https://github.com/FiloSottile/mkcert) u otro método para generar certificados autofirmados.

#### Docker

```shell
# docker
docker run -d \
  --name=syncclipboard-server \
  -p 5033:5033 \
  -e SYNCCLIPBOARD_USERNAME=your_username \
  -e SYNCCLIPBOARD_PASSWORD=your_password \
  --restart unless-stopped \
  jericx/syncclipboard-server:latest

# docker compose
curl -sL https://github.com/Jeric-X/SyncClipboard/raw/master/src/SyncClipboard.Server/docker-compose.yml
docker compose up -d
```
Para configurar HTTPS, mapee usted mismo `appsettings.json` y el archivo del certificado, la ruta dentro del contenedor para `appsettings.json` es `/app/appsettings.json`

#### Arch Linux

Se puede instalar directamente desde [AUR](https://aur.archlinux.org/packages/syncclipboard-server) (mantenido por [@devome](https://github.com/devome)):

```shell
paru -Sy syncclipboard-server
```
La ruta del archivo de configuración es `/etc/syncclipboard/appsettings.json`, después de modificar la configuración, utilice el comando `systemctl` para iniciar:


```shell
sudo systemctl enable --now syncclipboard.service
```

### Servidor integrado en el cliente

El cliente de escritorio (Windows/Linux/macOS) tiene una función de servidor integrada, que se puede configurar mediante una interfaz visual

### Servidor WebDAV
Se puede usar un disco en la nube que soporte el protocolo WebDAV como servidor  
Servidores probados:   

- [x] [Nextcloud](https://nextcloud.com/) 
- [x] [AList](https://alist.nn.ci/)
- [x] [InfiniCLOUD](https://infini-cloud.net/en/)
- [x] [aliyundrive-webdav](https://github.com/messense/aliyundrive-webdav)

## Cliente

El cliente de escritorio (Windows/Linux/macOS) sincroniza automáticamente el portapapeles cuando se ejecuta en segundo plano
<details>
<summary>Mostrar/Ocultar captura de pantalla</summary>

![](https://raw.githubusercontent.com/Jeric-X/SyncClipboard/master/docs/image/WinUI.png)

</details>

### Windows
#### Versión portable

Descargue el archivo zip cuyo nombre comienza con `SyncClipboard_win_` desde la página de [Release](https://github.com/Jeric-X/SyncClipboard/releases/latest), descomprímalo y ejecute `SyncClipboard.exe`

#### Problemas comunes
- La versión mínima compatible del sistema es Windows 10 2004
- Al ejecutar SyncClipboard en Windows 10, los íconos de la interfaz aparecen incorrectos en gran medida; por favor instale la fuente de íconos [Segoe Fluent Icons](https://aka.ms/SegoeFluentIcons) de Microsoft

### macOS
#### Instalación manual
Descargue el paquete de instalación cuyo nombre comienza con `SyncClipboard_macos_` desde la página de [Release](https://github.com/Jeric-X/SyncClipboard/releases/latest), haga doble clic y arrastre el ícono de SyncClipboard a la carpeta Aplicaciones

#### Problemas comunes
- El sistema muestra el mensaje "SyncClipboard no se puede abrir porque el desarrollador no se puede verificar": 
En la configuración de macOS, en la sección `Privacidad y seguridad`, haga clic en `Abrir de todos modos`
- El sistema muestra el mensaje `“SyncClipboard” está dañado y no se puede abrir`: ejecute en la terminal `sudo xattr -d com.apple.quarantine /Applications/SyncClipboard.app`
- Los atajos de teclado dependen de los permisos de accesibilidad, el software mostrará una ventana emergente solicitando autorización cuando sea necesario

### Linux
#### Instalación manual
Descargue el paquete de instalación cuyo nombre comienza con `SyncClipboard_linux_` en la página [Release](https://github.com/Jeric-X/SyncClipboard/releases/latest)

#### Arch Linux

Los usuarios de Arch Linux pueden instalar directamente desde [AUR](https://aur.archlinux.org/packages/syncclipboard-desktop) (mantenido por [@devome](https://github.com/devome)):

```shell
paru -Sy syncclipboard-desktop
```

Después de la instalación, inícielo desde el menú. Si al iniciar con el comando `syncclipboard-desktop` en la línea de comandos aparece un error, establezca la variable de entorno `LANG` a `en_US.UTF-8` y ejecute con `LANG=en_US.UTF-8 syncclipboard-desktop`.

#### Solución de problemas comunes
- Sincronización del portapapeles no oportuna, incapacidad para sincronizar, carga con caracteres extraños: se recomienda instalar `xclip` (X11) o `wl-clipboard` (Wayland) en el sistema; SyncClipboard utilizará estas herramientas para ayudar a obtener el portapapeles y mejorar la estabilidad. Use `xclip -version` o `wl-paste -version` para confirmar si están instaladas.
- Al usar paquetes `deb` o `rpm`, si la actualización falla, elimine primero la versión antigua antes de instalar la nueva.
- Al usar el paquete `AppImage`, asegúrese de que el archivo AppImage tenga permisos de ejecución.
- Las teclas rápidas pueden no funcionar en Wayland.
- Si no se reconoce automáticamente el idioma, el predeterminado es inglés; después de iniciar, puede cambiarlo en la configuración de SyncClipboard.

> [!NOTE]  
> Para eliminar completamente SyncClipboard, elimine manualmente los archivos de configuración y directorios temporales:  
> `%AppData%\SyncClipboard\` (Windows), `~/Library/Application Support/SyncClipboard/` (macOS), `~/.config/SyncClipboard/` (Linux)

### Parámetros de línea de comandos del cliente de escritorio

#### --shutdown-previous
Cierra SyncClipboard ya en ejecución y ejecuta una nueva instancia.

#### --command-{command-name}
Ejecuta el comando especificado, donde `{command-name}` es el nombre del comando; después de configurar una tecla rápida, puede consultar el nombre correspondiente en el archivo de configuración. Incluso si se elimina la configuración de la tecla rápida, el parámetro de línea de comandos sigue siendo válido.  
Si ya hay una instancia de SyncClipboard en ejecución, no se iniciará una nueva, sino que se llamará a la instancia existente para ejecutar el comando. Si no hay ninguna instancia en ejecución, el comando se ejecutará inmediatamente después de iniciar.  
Se admiten múltiples parámetros `--command-{command-name}`, que permiten ejecutar varios comandos simultáneamente.

> [!NOTE]  
> En macOS, al usar parámetros de línea de comandos, use la ruta completa del ejecutable: `/Applications/SyncClipboard.app/Contents/MacOS/SyncClipboard.Desktop.MacOS`

### IOS  
#### Uso de [Atajos](https://apps.apple.com/cn/app/%E5%BF%AB%E6%8D%B7%E6%8C%87%E4%BB%A4/id1462947752)  

- Sincronización manual: importe este [atajo](https://www.icloud.com/shortcuts/d1b9e49556e04c2ca290590294afbd99) y ejecútelo para subir o descargar manualmente.
- Sincronización automática: importe este [atajo](https://www.icloud.com/shortcuts/1ced32f011bc4d3498dca9960dc2c0d5); al ejecutarlo, el dispositivo sincronizará automáticamente el portapapeles en segundo plano. Este atajo se ejecuta indefinidamente y debe cerrarse manualmente. También puede modificar manualmente si enviar notificaciones del sistema tras la sincronización y el intervalo en segundos para consultas.
- Carga automática de códigos SMS, consulte el tutorial en video en esta publicación https://github.com/Jeric-X/SyncClipboard/discussions/60

### Android
#### Uso de [HTTP Request Shortcuts](https://github.com/Waboodoo/HTTP-Shortcuts)
Importe este [archivo de configuración](/script/shortcuts.zip), modifique las `variables` `UserName`, `UserToken` y `url`. La `url` no debe terminar con el separador de barra `/`. `HTTP Request Shortcuts` admite uso desde el menú desplegable, widget de escritorio, icono en escritorio y menú de compartir.

<details>
<summary>Ilustración para modificar la configuración tras importar el archivo</summary>

![](https://raw.githubusercontent.com/Jeric-X/SyncClipboard/master/docs/image/android1.jpg)
![](https://raw.githubusercontent.com/Jeric-X/SyncClipboard/master/docs/image/android2.jpg)
![](https://raw.githubusercontent.com/Jeric-X/SyncClipboard/master/docs/image/android3.jpg)

</details>

#### Uso de [Autox.js](https://github.com/kkevsekk1/AutoX)

- Sincronización automática, usando este [archivo js](/script/SyncAutoxJs.js). Debido a las restricciones del sistema Android, en Android 10 y versiones superiores las aplicaciones no pueden leer el portapapeles en segundo plano, pero se pueden usar herramientas basadas en permisos Root (Magisk/Xposed) para habilitar el acceso en segundo plano, como [Riru-ClipboardWhitelist](https://github.com/Kr328/Riru-ClipboardWhitelist), [Clipboard Whitelist](https://modules.lsposed.org/module/io.github.tehcneko.clipboardwhitelist). En Android 13 y versiones superiores, las aplicaciones deben obtener permiso manual del usuario para acceder a los registros del sistema (portapapeles), también se puede usar Xposed para conceder automáticamente el permiso para acceder a los registros del sistema, como [DisableLogRequest/Desactivar solicitud de acceso a logs](https://github.com/QueallyTech/DisableLogRequest)
- Subida automática de códigos de verificación, usando este [archivo js](/script/UploadVerificationCode.js), este script corre en segundo plano y lee todas las notificaciones, cuando identifica mensajes con códigos de verificación, sube el código al servidor

Importa los archivos js, modifica la configuración de usuario en la cabecera de cada archivo, luego ejecuta manualmente, o configura un disparador para cada archivo js, por ejemplo: ejecución al encender el dispositivo

#### Uso de [SmsForwarder](https://github.com/pppscn/SmsForwarder)

- Subida automática de códigos de verificación, https://github.com/Jeric-X/SyncClipboard/discussions/109

#### Uso de [Tasker](https://tasker.joaoapps.com/)

- https://github.com/forrestgao/taskerforSyncClipboard , autor: [forrestgao](https://github.com/forrestgao)

Tasker es una poderosa herramienta de automatización para Android, puedes crear perfiles personalizados usando la API de SyncClipboard, si consideras que tu perfil es muy útil y deseas compartirlo, contáctame para incluirlo aquí


### Explicación de la configuración del cliente

Todas las plataformas requieren tres configuraciones necesarias (la ortografía puede variar, pero el significado es el mismo).
- user
- password
- url, con formato http(s)://ip(o dominio):puerto. Al usar un servidor WebDav, la url debe apuntar a una carpeta existente como directorio de trabajo, por ejemplo `https://domain.com/dav/folder1/working%20folder`, los caracteres especiales deben usarse en formato de escape url, no uses esta carpeta para almacenar otros archivos. Si no usas cliente de escritorio (Windows/Linux/macOS), debes crear dentro del directorio de trabajo una carpeta llamada `file` para sincronizar archivos; el cliente de escritorio crea automáticamente la carpeta `file` al configurar el servidor. Se recomienda no terminar la url con barra `/` para evitar problemas en algunos clientes.

## API

La API está basada en WebDAV, en un entorno de servidor independiente, configura la variable de entorno ASPNETCORE_ENVIRONMENT como Development y ejecuta el servidor, o abre el servidor desde el cliente de escritorio y activa el modo diagnóstico en configuración, luego
accede a `http://ip:puerto/swagger/index.html` para abrir la página de la API, a continuación algunas APIs clave

### Obtener/Subir portapapeles (texto)
```
GET /SyncClipboard.json
PUT /SyncClipboard.json
```

### Obtener/Subir portapapeles (imagen/archivo)
```
GET  /SyncClipboard.json
HEAD /file/filename         // optional
GET  /file/filename

PUT /file/filename
PUT /SyncClipboard.json
```

### SyncClipboard.json
```
{
    "Type" : "Text"
    "Clipboard" : "Content",
    "File":""
}

{
    "Type": "Image", // or "File", "Group"
    "Clipboard": "hash, optional",
    "File": "filename"
}
```

## 项目依赖
[NativeNotification](https://github.com/Jeric-X/NativeNotification)  
[Magick.NET](https://github.com/dlemstra/Magick.NET)  
[.NET Community Toolkit](https://github.com/CommunityToolkit/dotnet)  
[H.NotifyIcon](https://github.com/HavenDV/H.NotifyIcon)  
[WinUIEx](https://github.com/dotMorten/WinUIEx)  
[moq](https://github.com/moq/moq)  
[Avalonia](https://avaloniaui.net/)  
[FluentAvalonia.BreadcrumbBar](https://github.com/indigo-san/FluentAvalonia.BreadcrumbBar)  
[FluentAvalonia](https://github.com/amwx/FluentAvalonia)  
[Vanara](https://github.com/dahall/Vanara)  
[Tmds.DBus](https://github.com/tmds/Tmds.DBus)  
[SharpHook](https://github.com/TolikPylypchuk/SharpHook)  
[DotNetZip.Semverd](https://github.com/haf/DotNetZip.Semverd)  
[Quartz.NET](https://github.com/quartznet/quartznet)  
[MiSans](https://hyperos.mi.com/font)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-23

---
# twitch-downloader-gui

Este es un envoltorio GUI para la versión CLI del gran proyecto [TwitchDownloader](https://github.com/lay295/TwitchDownloader), solo para Linux.  
Utilicé la biblioteca [libui-ng](https://github.com/libui-ng/libui-ng) con algunos [parches](https://github.com/mohad12211/libui-ng).  
La biblioteca aún está en una fase alfa media, pero es un proyecto prometedor, simple, multiplataforma (macOS se puede hacer, simplemente no me importa mucho) y muy intuitivo.

# Vista previa

![preview](https://user-images.githubusercontent.com/51754973/167058990-a574493a-fd44-4f12-be59-185798fb93bf.gif)

# Instalación

> [!IMPORTANT]
> **Esto es solo un envoltorio para la CLI, aún necesitas el binario `TwitchDownloaderCLI`. Por defecto la aplicación intentará encontrar el binario en tu `PATH`,  
si no quieres poner `TwitchDownloaderCLI` en tu `PATH` puedes especificar la ruta del binario desde la configuración. Asegúrate de que `TwitchDownloaderCLI` sea ejecutable.**

Paquetes disponibles para debian, fedora y [AUR](https://aur.archlinux.org/packages/twitch-downloader-gui).

### Dependencias

- ffmpeg (requerido para renderizar chat y vods)  
- libcurl  
- TwitchDownloaderCLI (ver más abajo)

# Compilación

### Dependencias para Compilar

- make  
- libcurl (versión de desarrollo)  
- gtk3 (versión de desarrollo, llamada libgtk-3-dev en ubuntu)

La biblioteca estática para libui está en el repositorio, pero puedes usar tu propia versión compilada y simplemente reemplazarla, instrucciones [aquí](https://github.com/mohad12211/libui-ng/blob/customs/README.md#quick-building-instructions)


```
$ git clone https://github.com/mohad12211/twitch-downloader-gui.git
$ cd twitch-downloader-gui
$ make
$ make install # (if you want to install the app to your system)
$ make uninstall # (to uninstall)
```

el binario está dentro de `build/bin`

# ¿Incluye todas las funciones? ¿algún error?

incluye las funcionalidades básicas, no hay cola de tareas.

## Errores...

- Solo puedes descargar la calidad más alta para el vod (lo resolveré pronto).

Por favor, reporta cualquier error.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-20

---
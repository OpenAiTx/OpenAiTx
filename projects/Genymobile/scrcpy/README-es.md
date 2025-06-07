**Este repositorio de GitHub (<https://github.com/Genymobile/scrcpy>) es la única fuente oficial
del proyecto. No descargues versiones desde sitios web aleatorios, incluso si
su nombre contiene `scrcpy`.**

# scrcpy (v3.2)

<img src="app/data/icon.svg" width="128" height="128" alt="scrcpy" align="right" />

_pronunciado "**scr**een **c**o**py**"_

Esta aplicación refleja dispositivos Android (video y audio) conectados vía USB o
por [TCP/IP](doc/connection.md#tcpip-wireless) y permite el control usando el
teclado y ratón del ordenador. No requiere acceso _root_ ni una app instalada
en el dispositivo. Funciona en _Linux_, _Windows_ y _macOS_.

![screenshot](assets/screenshot-debian-600.jpg)

Se enfoca en:

 - **ligereza**: nativo, muestra solo la pantalla del dispositivo
 - **rendimiento**: 30~120fps, dependiendo del dispositivo
 - **calidad**: 1920×1080 o superior
 - **baja latencia**: [35~70ms][lowlatency]
 - **bajo tiempo de inicio**: ~1 segundo para mostrar la primera imagen
 - **no intrusivo**: no deja nada instalado en el dispositivo Android
 - **beneficios para el usuario**: sin cuenta, sin anuncios, sin internet requerido
 - **libertad**: software libre y de código abierto

[lowlatency]: https://github.com/Genymobile/scrcpy/pull/646

Sus funciones incluyen:
 - [reenvío de audio](doc/audio.md) (Android 11+)
 - [grabación](doc/recording.md)
 - [pantalla virtual](doc/virtual_display.md)
 - duplicación con [pantalla del dispositivo Android apagada](doc/device.md#turn-screen-off)
 - [copiar y pegar](doc/control.md#copy-paste) en ambas direcciones
 - [calidad configurable](doc/video.md)
 - [duplicado de cámara](doc/camera.md) (Android 12+)
 - [duplicación como webcam (V4L2)](doc/v4l2.md) (solo en Linux)
 - simulación física de [teclado][hid-keyboard] y [ratón][hid-mouse] (HID)
 - soporte de [gamepad](doc/gamepad.md)
 - [modo OTG](doc/otg.md)
 - y más…

[hid-keyboard]: doc/keyboard.md#physical-keyboard-simulation
[hid-mouse]: doc/mouse.md#physical-mouse-simulation

## Requisitos previos

El dispositivo Android requiere al menos API 21 (Android 5.0).

El [reenvío de audio](doc/audio.md) es compatible para API >= 30 (Android 11+).

Asegúrate de haber [activado la depuración USB][enable-adb] en tu(s) dispositivo(s).

[enable-adb]: https://developer.android.com/studio/debug/dev-options#enable

En algunos dispositivos (especialmente Xiaomi), podrías obtener el siguiente error:

```
java.lang.SecurityException: Injecting input events requires the caller (or the source of the instrumentation, if any) to have the INJECT_EVENTS permission.
```

En ese caso, necesitas habilitar [una opción adicional][control] `Depuración USB
(Ajustes de seguridad)` (esto es diferente de `Depuración USB`) para poder
controlarlo usando teclado y ratón. Es necesario reiniciar el dispositivo una vez
que esta opción esté activada.

[control]: https://github.com/Genymobile/scrcpy/issues/70#issuecomment-373286323

Ten en cuenta que no se requiere la depuración USB para ejecutar scrcpy en [modo OTG](doc/otg.md).


## Obtén la aplicación

 - [Linux](doc/linux.md)
 - [Windows](doc/windows.md) (lee [cómo ejecutar](doc/windows.md#run))
 - [macOS](doc/macos.md)


## Consejos imprescindibles

 - [Reducir la resolución](doc/video.md#size) puede mejorar mucho el rendimiento
   (`scrcpy -m1024`)
 - [_Clic derecho_](doc/mouse.md#mouse-bindings) acciona `ATRÁS`
 - [_Clic central_](doc/mouse.md#mouse-bindings) acciona `INICIO`
 - <kbd>Alt</kbd>+<kbd>f</kbd> alterna [pantalla completa](doc/window.md#fullscreen)
 - Hay muchos otros [atajos](doc/shortcuts.md)


## Ejemplos de uso

Hay muchas opciones [documentadas](#user-documentation) en páginas separadas.
Aquí tienes algunos ejemplos comunes.

 - Captura la pantalla en H.265 (mejor calidad), limita el tamaño a 1920, limita
   la tasa de fotogramas a 60fps, desactiva el audio y controla el dispositivo
   simulando un teclado físico:

    ```bash
    scrcpy --video-codec=h265 --max-size=1920 --max-fps=60 --no-audio --keyboard=uhid
    scrcpy --video-codec=h265 -m1920 --max-fps=60 --no-audio -K  # versión corta
    ```

 - Inicia VLC en una nueva pantalla virtual (separada de la pantalla del dispositivo):

    ```bash
    scrcpy --new-display=1920x1080 --start-app=org.videolan.vlc
    ```

 - Graba la cámara del dispositivo en H.265 a 1920x1080 (y micrófono) en un archivo MP4:

    ```bash
    scrcpy --video-source=camera --video-codec=h265 --camera-size=1920x1080 --record=file.mp4
    ```

 - Captura la cámara frontal del dispositivo y expónla como webcam en el ordenador (en
   Linux):

    ```bash
    scrcpy --video-source=camera --camera-size=1920x1080 --camera-facing=front --v4l2-sink=/dev/video2 --no-playback
    ```

 - Controla el dispositivo sin duplicar la pantalla, simulando un teclado y ratón físicos
   (no requiere depuración USB):

    ```bash
    scrcpy --otg
    ```

 - Controla el dispositivo usando mandos de juego conectados al ordenador:

    ```bash
    scrcpy --gamepad=uhid
    scrcpy -G  # versión corta
    ```

## Documentación de usuario

La aplicación proporciona muchas funciones y opciones de configuración. Estas están
documentadas en las siguientes páginas:

 - [Conexión](doc/connection.md)
 - [Vídeo](doc/video.md)
 - [Audio](doc/audio.md)
 - [Control](doc/control.md)
 - [Teclado](doc/keyboard.md)
 - [Ratón](doc/mouse.md)
 - [Gamepad](doc/gamepad.md)
 - [Dispositivo](doc/device.md)
 - [Ventana](doc/window.md)
 - [Grabación](doc/recording.md)
 - [Pantalla virtual](doc/virtual_display.md)
 - [Túneles](doc/tunnels.md)
 - [OTG](doc/otg.md)
 - [Cámara](doc/camera.md)
 - [Video4Linux](doc/v4l2.md)
 - [Atajos](doc/shortcuts.md)


## Recursos

 - [FAQ](FAQ.md)
 - [Traducciones][wiki] (no necesariamente actualizadas)
 - [Instrucciones de compilación](doc/build.md)
 - [Desarrolladores](doc/develop.md)

[wiki]: https://github.com/Genymobile/scrcpy/wiki


## Artículos

- [Presentando scrcpy][article-intro]
- [Scrcpy ahora funciona de forma inalámbrica][article-tcpip]
- [Scrcpy 2.0, con audio][article-scrcpy2]

[article-intro]: https://blog.rom1v.com/2018/03/introducing-scrcpy/
[article-tcpip]: https://www.genymotion.com/blog/open-source-project-scrcpy-now-works-wirelessly/
[article-scrcpy2]: https://blog.rom1v.com/2023/03/scrcpy-2-0-with-audio/

## Contacto

Puedes abrir un [issue] para reportar errores, solicitar funciones o para preguntas generales.

Para reportes de errores, por favor lee primero las [FAQ](FAQ.md), podrías encontrar
una solución a tu problema de inmediato.

[issue]: https://github.com/Genymobile/scrcpy/issues

También puedes usar:

 - Reddit: [`r/scrcpy`](https://www.reddit.com/r/scrcpy)
 - BlueSky: [`@scrcpy.bsky.social`](https://bsky.app/profile/scrcpy.bsky.social)
 - Twitter: [`@scrcpy_app`](https://twitter.com/scrcpy_app)


## Donar

Soy [@rom1v](https://github.com/rom1v), el autor y mantenedor de _scrcpy_.

Si aprecias esta aplicación, puedes [apoyar mi trabajo de código abierto][donate]:
 - [GitHub Sponsors](https://github.com/sponsors/rom1v)
 - [Liberapay](https://liberapay.com/rom1v/)
 - [PayPal](https://paypal.me/rom2v)

[donate]: https://blog.rom1v.com/about/#support-my-open-source-work

## Licencia

    Copyright (C) 2018 Genymobile
    Copyright (C) 2018-2025 Romain Vimont

    Licenciado bajo la Licencia Apache, Versión 2.0 (la "Licencia");
    no puedes usar este archivo excepto en cumplimiento con la Licencia.
    Puedes obtener una copia de la Licencia en

        http://www.apache.org/licenses/LICENSE-2.0

    A menos que la ley aplicable lo requiera o se acuerde por escrito, el software
    distribuido bajo la Licencia se distribuye "TAL CUAL", SIN GARANTÍAS NI CONDICIONES
    DE NINGÚN TIPO, sean expresas o implícitas.
    Consulta la Licencia para conocer el lenguaje específico que rige los permisos y
    limitaciones bajo la Licencia.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---
# UniControlHub

[![](https://img.shields.io/static/v1?label=Sponsor&message=%E2%9D%A4&logo=GitHub&color=%23fe8e86)](https://github.com/sponsors/rohitsangwan01)
![Downloads](https://img.shields.io/github/downloads/rohitsangwan01/uni_control_hub/total.svg)

<p align="center">
  <img src="https://github.com/user-attachments/assets/41c886c0-f08c-4186-bc98-153aa2769d13" height=150 />
</p>

UniControlHub: Conecta tus dispositivos sin interrupciones

UniControlHub revoluciona la forma en que interactúas con tu entorno digital al ofrecer una experiencia de control fluida e intuitiva a través de múltiples dispositivos. Inspirado en la conveniencia y fluidez del Universal Control de Apple, UniControlHub extiende esta funcionalidad innovadora más allá del ecosistema Apple. Con solo un mouse y teclado, puedes navegar y gestionar dispositivos sin esfuerzo; UniControlHub garantiza un espacio de trabajo cohesivo y productivo. Construida con Flutter para una experiencia de usuario suave y receptiva, esta aplicación es la herramienta definitiva para mejorar la productividad y optimizar tu vida digital.

![macOS](https://img.shields.io/badge/mac%20os-000000?style=for-the-badge&logo=macos&logoColor=F0F0F0)
![Windows](https://img.shields.io/badge/Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white)
![Linux](https://img.shields.io/badge/Linux-FCC624?style=for-the-badge&logo=linux&logoColor=black)

<a href="https://buymeacoffee.com/rohitsangwan" target="_blank"><img src="https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png" alt="Buy Me A Coffee" style="height: 41px !important;width: 174px !important;box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;-webkit-box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;" ></a>


## Comenzando

Descarga la aplicación para tu plataforma desde la sección [Release](https://github.com/rohitsangwan01/uni_control_hub/releases)

### MacOS

- Instala libusb: `brew install libusb`

### Windows

- Instala `Microsoft Visual C++ 2015-2022` para tu SO [x86](https://aka.ms/vs/17/release/vc_redist.x86.exe) o [x64](https://aka.ms/vs/17/release/vc_redist.x64.exe).

- Si el dispositivo Android no se detecta, asegúrate de tener instalados los [drivers](https://github.com/libusb/libusb/wiki/Windows#driver-installation) de libusb.

### Linux

Asegúrate de que `libqt5dbus5` esté instalado

En sistemas basados en Ubuntu/Debian, ejecuta:

```bash
sudo apt update
sudo apt install libqt5dbus5
```

En Fedora/RHEL/CentOS, ejecute:

```bash
sudo dnf install qt5-qtbase
```
En Arch Linux, ejecute:


```bash
sudo pacman -S qt5-base
```

## Plataformas Soportadas

| Plataforma | Bluetooth | USB | ADB |
| --------- | --------- | --- | --- |
| IOS       | ✅        | ❌  | ❌  |
| Android   | ⏳        | ✅  | ✅  |

## Captura de Pantalla

<p align="start">
  <img src="https://github.com/rohitsangwan01/uni_control_hub/assets/59526499/7b2b87c3-4501-490b-a205-0e3815c4b583" height=400 />
</p>

## Demo

[![](http://markdown-videos-api.jorgenkh.no/youtube/KYsqdJkG2N0)](https://youtu.be/KYsqdJkG2N0)

## Solución de Problemas

- En MacOS, la aplicación pedirá permiso de `Accesibilidad` y `Bluetooth` en MacOS, (Después de actualizar, la app puede volver a pedir permiso de Accesibilidad, aunque ya esté dado, intenta eliminar la app de Accesibilidad y ejecuta nuevamente)
- Para usar el modo UHID en Android, asegúrate de que `ADB` esté instalado (no es necesario para el modo AOA)
- Para conexión con Desktop e IOS, asegúrate de que el Bluetooth esté activado
- Después de conectar el dispositivo Android, haz clic en el botón de refrescar

## Guía para Desarrolladores

Esta sección te guía para configurar y ejecutar UniControlHub con fines de desarrollo.

#### Requisitos Previos:

- Instala la última versión de [Flutter](https://flutter-ko.dev/get-started/install) para tu sistema operativo. Puedes encontrar instrucciones en el sitio oficial de Flutter.
- Sigue la guía de configuración de [Flutter](https://flutter-ko.dev/get-started/install) para tu plataforma. Puedes omitir los pasos específicos para Android o iOS si no estás desarrollando para esas plataformas.

#### Ejecutar/Depurar la Aplicación:

- Una vez configurado Flutter, ejecuta `flutter pub get` para descargar dependencias, y luego `flutter run` para iniciar la aplicación

## Patrocinador

Si encuentras este proyecto útil, ¡considera patrocinarlo! Tu apoyo ayuda a mantener el desarrollo activo, agregar nuevas funciones y mejorar la estabilidad. También puedes compartir tus ideas o comentarios en las [Discusiones](https://github.com/rohitsangwan01/uni_control_hub/discussions). ¡Gracias por tu apoyo! 🚀

[![](https://img.shields.io/static/v1?label=Sponsor&message=%E2%9D%A4&logo=GitHub&color=%23fe8e86)](https://github.com/sponsors/rohitsangwan01)

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/rohitsangwan)

## Notas adicionales:

UniControlHub utiliza el [servidor Synergy](https://github.com/symless/synergy-core) para compartir teclado y ratón entre plataformas. Puedes encontrar más información sobre [Synergy](https://symless.com/synergy) en su sitio web.

¡Damos la bienvenida a contribuciones para UniControlHub! Si encuentras un error o tienes una solicitud de función, por favor abre un issue en nuestro repositorio de GitHub.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-17

---
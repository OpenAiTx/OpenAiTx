# <img src="https://github.com/user-attachments/assets/b81b9503-948e-4cba-b0a1-f5f809588aad" width="48"> SwitchWave
Un reproductor multimedia acelerado por hardware para Nintendo Switch, construido sobre mpv y FFmpeg.

## Características
- Backend de aceleración por hardware personalizado para FFmpeg, con escalado dinámico de frecuencia. Se pueden decodificar los siguientes códecs:
    - MPEG1/2/4
    - VC1
    - H.264/AVC (bits 10+ no soportados por hardware)
    - H.265/HEVC (bits 12+ no soportados por hardware)
    - VP8
    - VP9 (bits 10+ no soportados por hardware)
- Backend gráfico personalizado para mpv usando [deko3d](https://github.com/devkitPro/deko3d), soportando:
    - Reproducción a 4k60fps
    - Renderizado directo (decodificación por software más rápida)
    - Shaders personalizados de post-procesamiento
- Backend de audio personalizado para mpv usando APIs nativas de Nintendo, soportando configuraciones hasta 5.1 surround
- Reproducción en red mediante HTTP/S, Samba, NFS o SFTP
- Soporte para unidades externas usando [libusbhsfs](https://github.com/DarkMatterCore/libusbhsfs)
- Interfaz de usuario rica y sensible, incluso bajo carga

## Capturas de pantalla

<p float="center">
    <img src="https://github.com/user-attachments/assets/09aed446-148a-4276-8b07-336890c224a3" width="413" />
    <img src="https://github.com/user-attachments/assets/6e354511-47bc-4898-881c-348d5a9e6fbc" width="413" />
    <img src="https://github.com/user-attachments/assets/b86eb7c6-4229-46c6-8709-86d1a6ee8eed" width="413" />
    <img src="https://github.com/user-attachments/assets/70f4be3e-fa1e-434a-b76c-4fb6b671f80e" width="413" />
</p>

## Instalación
- Descargue la [última versión](https://github.com/averne/SwitchWave/releases/latest) y extraígala en la raíz de su tarjeta SD (tenga cuidado de fusionar y no sobrescribir carpetas)
- Las unidades de red pueden configurarse desde la app, al igual que los ajustes de mpv mediante el editor incorporado (consulte el [manual](https://mpv.io/manual/master/))
- Los parámetros de ejecución más relevantes pueden ajustarse dinámicamente durante la reproducción a través del menú, o en su defecto, la consola ([manual](https://mpv.io/manual/master/#console))

## Compilación

### Docker (recomendado)
```sh
./build-docker.sh
```
Esto construye la imagen de la cadena de herramientas y compila todo automáticamente. La salida se encontrará en `build/`.

Para compilar con GIMP 3 en lugar del GIMP 2 predeterminado:
```sh
GIMP_VERSION=3 ./build-docker.sh
```

### Manual
- Configure un entorno [devkitpro](https://devkitpro.org/wiki/devkitPro_pacman) para el desarrollo de homebrew en Switch.
- Instale los siguientes paquetes: `switch-bzip2`, `switch-dav1d`, `switch-freetype`, `switch-glm`, `switch-harfbuzz`, `switch-libarchive`, `switch-libass`, `switch-libfribidi`, `switch-libjpeg-turbo`, `switch-libpng`, `switch-libwebp`, `switch-curl`, `switch-libssh2`, `switch-mbedtls`, `switch-ntfs-3g` y `switch-lwext4`. Además, se requieren las siguientes dependencias de compilación: `switch-pkg-config`, `dkp-meson-scripts`, `dkp-toolchain-vars` y [GIMP](https://www.gimp.org/) (2 o 3).
- Compile e instale una versión GPL de [libusbhsfs](https://github.com/DarkMatterCore/libusbhsfs).
- Compile e instale [libsmb2](misc/libsmb2/) y [libnfs](misc/libnfs/).
- Configure, compile e instale FFmpeg: `make configure-ffmpeg && make build-ffmpeg -j$(nproc)`.
- Configure, compile e instale libuam: `make configure-uam && make build-uam`.
- Configure, compile e instale mpv: `make configure-mpv && make build-mpv`.
- Finalmente, compile la aplicación principal y genere la distribución de lanzamiento: `make dist -j$(nproc)`.
- La salida se encontrará en `build/`.

## Créditos
- [Behemoth](https://github.com/HookedBehemoth) por el método de sobrescritura del botón de captura de pantalla.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-11

---
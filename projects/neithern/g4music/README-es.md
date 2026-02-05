<img align="left" alt="Logotipo del proyecto" src="https://raw.githubusercontent.com/neithern/g4music/master/data/icons/hicolor/scalable/apps/app.svg" />

# Gapless
Reproduce tu música elegantemente.

<img src="https://gitlab.gnome.org/neithern/screenshots/-/raw/main/g4music/window.png" width="1134"/>
<img src="https://gitlab.gnome.org/neithern/screenshots/-/raw/main/g4music/albums.png" width="1134"/>
<img src="https://gitlab.gnome.org/neithern/screenshots/-/raw/main/g4music/playing.png" width="462"/>
<img src="https://gitlab.gnome.org/neithern/screenshots/-/raw/main/g4music/playlist.png" width="466"/>

Gapless (también conocido como G4Music) es un reproductor de música ligero escrito en GTK4, enfocado en grandes colecciones de música.

## Características
- Soporta la mayoría de tipos de archivos de música, Samba y cualquier otro protocolo remoto (depende de GIO y GStreamer).
- Carga rápida y análisis de miles de archivos de música en muy pocos segundos, monitorea cambios locales.
- Bajo consumo de memoria para grandes colecciones de música con portadas de álbum (incrustadas y externas), sin cachés de miniaturas para almacenar.
- Agrupa y ordena por álbum/artista/título, lista aleatoria, búsqueda de texto completo.
- Interfaz de usuario adaptable y fluida para diferentes pantallas (Escritorio, Tableta, Móvil).
- Portada desenfocada con efecto gaussiano como fondo, sigue el modo claro/oscuro de GNOME.
- Soporta creación y edición de listas de reproducción, arrastrar portada para cambiar el orden o añadir a otra lista.
- Soporta arrastrar y soltar con otras aplicaciones.
- Soporta visualizador de picos de audio.
- Soporta reproducción sin pausas (gapless).
- Soporta normalización de volumen con ReplayGain.
- Soporta salida de audio específica.
- Soporta control MPRIS.

## Instalación desde Flathub
<a href="https://flathub.org/apps/com.github.neithern.g4music">
<img src="https://flathub.org/assets/badges/flathub-badge-en.png" width="240"/></a>

## Instalación desde Snapcraft (no oficial)
<a href="https://snapcraft.io/g4music">
<img alt="Consíguelo en Snap Store" src="https://camo.githubusercontent.com/ab077b20ad9938c23fbdac223ab101df5ed27329bbadbe7f98bfd62d5808f0a7/68747470733a2f2f736e617063726166742e696f2f7374617469632f696d616765732f6261646765732f656e2f736e61702d73746f72652d626c61636b2e737667" data-canonical-src="https://snapcraft.io/static/images/badges/en/snap-store-black.svg" width="240" style="max-width: 100%;"> 

## Dependencias para FreeBSD

```bash
pkg install vala meson libadwaita gstreamer1-plugins-all gettext gtk4
```

## Cómo compilar 
Está escrito en Vala, código simple y limpio, con pocas dependencias de terceros:

1. Clona el código desde gitlab.
2. Instala vala, paquetes de desarrollo de gtk4, libadwaita, gstreamer.
3. Ejecuta en el directorio del proyecto:

    `meson setup build --buildtype=release`

    `meson install -C build`

## Registro de cambios
Consulta las [etiquetas de lanzamiento](https://gitlab.gnome.org/neithern/g4music/-/tags) para el registro de cambios.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-05

---
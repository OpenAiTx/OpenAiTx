<img height="80" width="80" src="https://raw.githubusercontent.com/Thomas-Sohier/jellyflut/main/./img/icon/rounded_logo.png"/>

# Jellyflut

Un cliente de jellyfin hecho en Flutter

Es una beta, funciona bien.

## :warning: Noticias
 
El proyecto está inactivo por ahora. No tengo mucho tiempo ni interés en este proyecto actualmente. El reproductor de video es muy problemático en Flutter. Todavía estoy buscando soluciones pero por ahora, voy a ralentizar el desarrollo de esta app.

Sigo buscando PR y las aceptaré con gusto.
 
## :gear: Funcionalidades

Puedes:
- [x] Reproducir un video
- [x] Leer un libro (epub/CBZ)
  - Epub es bastante limitado por ahora ya que es solo un parser combinado con un visor HTML
  - necesita algo de trabajo
- [x] Escuchar música
  - Inestable en Linux (necesita investigación, o usar otro paquete para linux)
- [x] Ver fotos
- [x] SQLite para tener registros y guardar la URL del servidor
- [x] Navegar por todos los archivos
- [x] ~~LO MÁS IMPORTANTE HACER que la transcodificación funcione, por ahora no sé cómo verificar si un archivo puede reproducirse directamente y si no cómo decirle a jellyfin que me envíe la URL correcta~~ Funciona (ya no mucho, roto desde 10.8.0 beta 3)
  - No funciona correctamente en Windows (parece roto por la dll libvlc, problema de certificado)
  - En computadora añadí codecs soportados manualmente. Algunos codecs pueden faltar, si es así, crea un issue y revisaré si es reproducible
- [x] Controlar la música desde cualquier pantalla
- [x] Extraer y/o parsear subtítulos desde archivo de video
 - Solo srt remoto, no puede parsear desde archivo mkv (excepto en VLC)

## Hecho
  - [X] Añadir botón de desconexión y manejarlo bien
  - [X] Rehacer página de inicio de sesión
  - [x] Animación Hero OK
  - [x] Carga asíncrona de detalles
  - [x] Navegación detalles sin saltos
  - [x] Responsivo (WIP)
  - [x] Navegación con D-pad (parece bien pero en la web aún se pueden seleccionar cosas fuera de la pantalla en la página principal)
    - Aún se necesita más trabajo pero se puede navegar el 80% de la app, lo cual es suficiente por ahora
  - [x] Manejo de múltiples usuarios y servidores
  - [x] Mejor manejo de datos al cambiar tamaño para evitar recarga desde la API
    - Parece bastante bueno ahora, puede que se necesite más trabajo en el futuro
  - [X] Tema (oscuro/claro)
  - [X] Localización (ENG,FR,DE)

## Por hacer
  - [ ] Siempre refactorizar todo
  - [ ] Añadir pruebas unitarias
  - [ ] Corregir "transcodeReasons=0" de jellyfin
  - [ ] Corregir todos los aspectos de flutter, hacer las cosas más rápidas
  - [ ] Igualar IPTV con la versión web
    - La guía funciona
    - Se pueden reproducir canales IPTV
    - aún falta añadir grabación

## Pantallas

 <img src="https://raw.githubusercontent.com/Thomas-Sohier/jellyflut/main/./img/readme/home.png"/>

### Teléfono

<div style="display: flex">
 <img src="https://raw.githubusercontent.com/Thomas-Sohier/jellyflut/main/./img/readme/series_details_phone_1.png"/>
 <img src="https://raw.githubusercontent.com/Thomas-Sohier/jellyflut/main/./img/readme/series_details_phone_2.png"/>
</div>

### Escritorio

<div style="display: flex">
 <img src="https://raw.githubusercontent.com/Thomas-Sohier/jellyflut/main/./img/readme/details_desktop.png" height="360" />
 <img src="https://raw.githubusercontent.com/Thomas-Sohier/jellyflut/main/./img/readme/series_details_desktop.png" height="360" />
 <img src="https://raw.githubusercontent.com/Thomas-Sohier/jellyflut/main/./img/readme/music_details_desktop.png" height="360" />
</div>

## Comenzando

Esta app debería funcionar en cualquier plataforma pero IOS y MacOs no han sido probados.

### ¿Cómo probar? 

```bash
  git clone https://github.com/Thomas-Sohier/jellyflut.git
  cd jellyflut
  flutter packages get
  flutter packages upgrade
  flutter run
```

### ¿Cómo construir? (Android)

```bash
  flutter build apk --release
```

### ¿Cómo construir? (Computadora, dependiendo de la plataforma)

Específico para Linux, necesitas instalar dep

```bash
  # depend of your distro of course
  sudo apt-get update -y
  sudo apt-get install -y vlc libvlc-dev ninja-build clang libgtk-3-dev
```

```bash
  # enable desktop support at first (shouldn't be necessary but anyway)
  flutter config --enable-windows-desktop
  flutter config --enable-macos-desktop
  flutter config --enable-linux-desktop

  # build the app depending of your platform
  flutter build windows
  flutter build macos
  flutter build linux
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-20

---
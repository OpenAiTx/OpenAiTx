
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<br/>
<p align="center"><img width="500" height="auto" alt="codriver_banner" src="https://github.com/user-attachments/assets/1957b950-db16-4ebd-b514-4f9b4f4abfd9" /></p>

<br/>

<a href="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml"><p align="center"><img src="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml/badge.svg?branch=master"></p></a>

<p align="center">
  <img src="https://img.shields.io/badge/Windows-blue" />
  <img src="https://img.shields.io/badge/ macOS-white" />
  <img src="https://img.shields.io/badge/Linux-red" />
</p>

<p align="center">
  <a href="https://discord.gg/zSE27rjdzp">
      <img src="https://dcbadge.limes.pink/api/server/https://discord.gg/zSE27rjdzp" />
  </a>
</p>

<p align="center">
  <a href='https://ko-fi.com/rickydane'>
      <img height='36px' style='border: 0px; height: 36px;' src='https://storage.ko-fi.com/cdn/kofi2.png?v=3' border='0' alt='Cómprame un café en ko-fi.com' />
  </a>
</p>

<br/>

<p align="center">
  Un explorador de archivos simple que nació porque quería aprender el lenguaje Rust.
  <br>
  Es independiente del sistema operativo y optimizado para el rendimiento.
</p>

<br/><br/>

El rendimiento se logra gracias a ["jwalk"](https://crates.io/crates/jwalk/versions) y ["Tauri"](https://tauri.app/).
<br/><br/>
CoDriver no utiliza caché de rutas para acceder a archivos y carpetas, por lo que el rendimiento se debe a Rust, la velocidad del disco y la potencia del CPU.

⁉️ Ten en cuenta que este software aún está en desarrollo y puede contener errores.
<br/><br/>

# Enlaces
- <a href="#basic-features">Funciones básicas</a>
- <a href="#advanced-features">Funciones avanzadas</a>
- <a href="#dependencies-if-not-working-instantly">Dependencias</a>
- <a href="#%EF%B8%8F-ftp-integration-sshfs">Implementación FTP (SSHFS)</a>
- <a href="#%EF%B8%8F-known-issues">Problemas conocidos</a>
- <a href="#-todos">Todos</a>
- <a href="#user-interface">Interfaz de usuario</a>

## Funcionalidades básicas
- Navega por directorios como lo haces habitualmente
- Copia y pega, elimina, crea y renombra archivos y carpetas
- Cambia entre los modos de cuadrícula, lista y columnas Miller
- Cierra ventanas emergentes con esc
- Salta directamente a un directorio con Ctrl / Cmd + G introduciendo una ruta
- Ordena elementos en modo lista por tamaño, nombre o última modificación

## Funcionalidades avanzadas
- Comprime archivos y carpetas
  - zip
  - zstd
  - brotli
  - density (https://github.com/g1mv/density)
- Extrae archivos comprimidos
  - rar
  - zip
  - 7zip
  - tar (.gz, .bz2)
  - density
- Navega a un directorio usando el atajo LAlt + 1 / 2 / 3 | (macOS opción + 1 / 2 / 3)
  - Configura las rutas tú mismo en la configuración
- Crea archivo con F6
- Crea carpeta con F7
- Vista de panel doble
  - Busca archivos con F8
  - Copia el elemento seleccionado actual al otro panel con F5
  - Mueve el elemento seleccionado actual al otro panel con LShift + F5
- Arrastra y suelta archivos en el explorador para copiarlos en el directorio actual
- Renombra varios elementos de tu selección con Ctrl / Cmd + LShift + M
  - Ejecuta el renombrado múltiple con Ctrl / Cmd + Return
- Vista rápida de archivos -> Selecciona una entrada de directorio y pulsa la barra espaciadora.
  - Archivos soportados: todos los archivos de imagen (.jpg, .png, ...), .pdf, .mp4, .json, .txt, .html
  - Todos los demás elementos mostrarán una pequeña ficha con información sobre ellos. (ruta, tamaño, última modificación)
- Navegación instantánea -> Empieza a escribir y filtra automáticamente las entradas del directorio, lo que a veces <br/>
  hace que navegar a una ubicación deseada sea mucho más rápido

## Dependencias (Si no funciona instantáneamente)

<details>
<summary>Expandir para mostrar</summary>

### Linux

- openssl1.1

#### Debian / Ubuntu
```
sudo apt update
sudo apt install libwebkit2gtk-4.0-dev \
    build-essential \
    curl \
    wget \
    file \
    libssl-dev \
    libgtk-3-dev \
    libayatana-appindicator3-dev \
    librsvg2-dev
```

#### Arco
```
sudo apt update
sudo apt install libwebkit2gtk-4.0-dev \
    build-essential \
    curl \
    wget \
    file \
    libssl-dev \
    libgtk-3-dev \
    libayatana-appindicator3-dev \
    librsvg2-dev
```
#### Fedora

```
sudo dnf check-update
sudo dnf install openssl1.1 \
    webkit2gtk4.0-devel \
    openssl-devel \
    curl \
    wget \
    file \
    libappindicator-gtk3-devel \
    librsvg2-devel
sudo dnf group install "C Development Tools and Libraries"
```
</details>

## 🖥️ Integración FTP (sshfs)
<details>
  <summary>Expandir para mostrar</summary>
  <br/>
  Dependencias (deben instalarse adicionalmente):
  <br/>

  | macOS | Linux | Windows |
  | ----- | ----- | ------- |
  | fuse-t <br/> fuse-t-sshfs | libfuse | No soportado **_aún_** |

  ### Instalación:
  #### macOS
  ```
  brew tap macos-fuse-t/homebrew-cask
  brew install fuse-t
  brew install fuse-t-sshfs
  ```
  #### Linux
  ```
  sudo apt-get install sshfs
  ```

## 🏴‍☠️ Soporte de idiomas
- Inglés
  - Opción para elegir entre idiomas próximamente ...
</details>

## ⚠️ Problemas conocidos:
- Arrastrar y soltar fuera de la ventana actualmente no siempre funciona en Linux
- En Windows puede que tengas que instalar [Microsoft Visual C++ Redistributable](https://learn.microsoft.com/en-us/cpp/windows/latest-supported-vc-redist?view=msvc-170)
- Los permisos en ms-windows son un poco extraños
  - Puede que tengas que ejecutar el programa como administrador si encuentras problemas para copiar elementos o algo similar
- Puede haber un problema y necesitas instalar openssl1.1 en sistemas Linux, cuando el programa no inicia

## 📝 Tareas pendientes:
- Múltiples idiomas
- Favoritos
- Acceso a servicios de almacenamiento en línea (Google Drive, etc.)

## Interfaz de usuario

### Estilo de lista
<img width="1119" height="673" alt="Screenshot 2025-11-16 at 13 53 53" src="https://github.com/user-attachments/assets/cfe15e6f-9936-4e29-9ca5-0f83f366c9dc" />

### Estilo de cuadrícula
<img width="1121" height="674" alt="Screenshot 2025-11-16 at 13 53 46" src="https://github.com/user-attachments/assets/69dbeee0-b53c-4566-b90e-e85ab97e0033" />

### Vista de columnas Miller
<img width="1112" height="664" alt="Screenshot 2025-11-16 at 13 54 29" src="https://github.com/user-attachments/assets/1f540880-2097-423b-8522-1ef466aee1bd" />

### Vista de panel dual
<img width="1119" height="667" alt="Screenshot 2025-11-16 at 13 55 16" src="https://github.com/user-attachments/assets/80706079-a048-4e9e-93f0-54fa270f30ac" />

## Cómo contribuir
Prepara tu máquina para desarrollar aplicaciones tauri v1: [Tauri prerequisites](https://tauri.app/v1/guides/getting-started/prerequisites)
</br></br>
Cuando esto esté listo, simplemente ejecuta ```git clone https://github.com/RickyDane/CoDriver``` o ```gh repo clone RickyDane/CoDriver``` en una ubicación de tu máquina.
</br></br>
Deberías poder ejecutar ```cargo tauri dev``` en el directorio raíz de este proyecto para comenzar a construir y ejecutar CoDriver.
</br>
Asegúrate de tener instalado tauri-cli: ```cargo install tauri-cli```
</br>

## Firma de lanzamientos

Los artefactos de lanzamiento de macOS deben ser firmados y notarizados para evitar que Gatekeeper informe que la aplicación instalada está dañada. Consulta [Firma y notarización en macOS](https://raw.githubusercontent.com/RickyDane/CoDriver/master/docs/macos-signing-notarization.md) para conocer los secretos requeridos de GitHub Actions y los comandos de verificación.

## Historial de estrellas

<a href="https://star-history.com/#rickydane/CoDriver&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
   <img alt="Gráfico de historial de estrellas" src="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
 </picture>
</a>

#### Otro software de terceros
- DragSelect (https://github.com/ThibaultJanBeyer/DragSelect)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-24

---
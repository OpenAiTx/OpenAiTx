<br/>
<p align="center"><img width="700" src="https://github.com/user-attachments/assets/44295a1a-c904-407d-97af-bc1aa74baa86"/></p>
<br>
<!-- <p align="center"><a target="_blank" href="https://discord.gg/XPakYank"><img src="https://dcbadge.limes.pink/api/server/XPakYank" alt="" /></a></p> -->
<p align="center">
  <img src="https://img.shields.io/badge/Windows-blue" />
  <img src="https://img.shields.io/badge/ macOS-white" />
  <img src="https://img.shields.io/badge/Linux-red" />
</p>

<a href='https://ko-fi.com/rickydane'>
  <p align="center">
    <img height='36px' style='border: 0px; height: 36px;' src='https://storage.ko-fi.com/cdn/kofi2.png?v=3' border='0' alt='Cómprame un café en ko-fi.com' />
  </p>
</a>

<p align="center">
  <a href="https://discord.gg/zSE27rjdzp">
      <img src="https://dcbadge.limes.pink/api/server/https://discord.gg/zSE27rjdzp" />
  </a>
</p>

<a href="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml"><p align="center"><img src="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml/badge.svg?branch=master"></p></a>
<p align="center">
  Un explorador de archivos simple que nació porque quería aprender el lenguaje Rust.
  <br>
  Es independiente del sistema operativo y optimizado para el rendimiento.
</p>

<br/><br/>

El rendimiento es proporcionado por ["jwalk"](https://crates.io/crates/jwalk/versions) y ["Tauri"](https://tauri.app/).
<br/><br/>
CoDriver no utiliza caché de rutas para acceder a archivos y carpetas, por lo que el rendimiento se logra gracias a Rust, la velocidad del disco y la potencia del CPU.

⁉️ ¡Ten en cuenta que este software todavía está en desarrollo y contendrá errores!
<br/><br/>

# Enlaces
- <a href="#basic-features">Características básicas</a>
- <a href="#advanced-features">Funciones avanzadas</a>
- <a href="#dependencies-if-not-working-instantly">Dependencias</a>
- <a href="#%EF%B8%8F-ftp-integration-sshfs">Implementación FTP (SSHFS)</a>
- <a href="#%EF%B8%8F-language-support">Soporte de idiomas</a>
- <a href="#%EF%B8%8F-known-issues">Problemas conocidos</a>
- <a href="#-todos">Pendientes</a>
- <a href="#user-interface">Interfaz de usuario</a>
- <a href="#speed-comparison">Comparación de velocidad</a>
<br/>

## Funciones básicas
- Navega por los directorios como ya conoces
- Copiar y pegar, eliminar, crear y renombrar archivos y carpetas
- Cambia entre modo de "botones grandes", lista y columnas Miller
- Cierra los popups con esc
- Salta a un directorio con Ctrl / Cmd + G introduciendo una ruta
- Ordena elementos en modo lista por tamaño, nombre o última modificación
<br/>

## Funciones avanzadas
- Comprimir archivos y carpetas
  - zip
- Desempaquetar archivos automáticamente en una nueva carpeta en el directorio de trabajo
  - rar
  - zip
  - 7zip
  - tar (.gz, .bz2)
- Navega a un directorio usando el atajo LAlt + 1 / 2 / 3 | (macOS opción + 1 / 2 / 3)
  - Configura las rutas tú mismo en los ajustes
- Crear archivo con F6
- Crear carpeta con F7
- Empieza a escribir en un directorio para filtrar instantáneamente las entradas
- Vista de panel doble
  - Buscar archivos con F8
  - Copiar el elemento seleccionado al otro panel con F5
  - Mover el elemento seleccionado al otro panel con LShift + F5
- Arrastrar y soltar archivos en el explorador para copiarlos en el directorio actual
- Renombrar múltiples elementos seleccionados con Ctrl / Cmd + LShift + M
  - Ejecutar renombrado múltiple con Ctrl / Cmd + Enter
- Vista rápida de archivos -> Selecciona una entrada del directorio y presiona la barra espaciadora.
  - Archivos soportados: todos los archivos de imagen (.jpg, .png, ...), .pdf, .mp4, .json, .txt, .html
  - Todos los demás elementos mostrarán una pequeña miniatura con alguna información sobre ellos. (ruta, tamaño, última modificación)
- Navegación instantánea -> Comience a escribir y filtre automáticamente las entradas del directorio, haciendo que a veces <br/>
  sea mucho más rápido navegar a una ubicación deseada
<br/>

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
<br/>

## 🖥️ Integración FTP (sshfs)
<details>
  <summary>Expandir para mostrar</summary>
  <br/>
  Dependencias (Necesitan ser instaladas adicionalmente):
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
<br/>

## 🏴‍☠️ Soporte de idiomas
- Inglés
  - Próximamente opción para elegir entre idiomas ...
</details>
<br/>

## ⚠️ Problemas conocidos:
- Arrastrar y soltar fuera de la ventana actualmente no funciona en Linux
- En Windows puede que tenga que instalar [Microsoft Visual C++ Redistributable](https://learn.microsoft.com/en-us/cpp/windows/latest-supported-vc-redist?view=msvc-170)
- Los permisos en ms-windows son un poco extraños
  - Puede que tenga que ejecutar el programa como administrador si encuentra problemas para copiar elementos o algo similar
- Podría haber un problema y necesitar instalar openssl1.1 en sistemas Linux, cuando el programa no se inicia
- ~~Las pestañas aún no están completamente desarrolladas~~
<br/>

## 📝 Por hacer:
- Múltiples idiomas
- Favoritos
- Acceder a servicios de almacenamiento en línea (Google Drive, etc.)
<br/>

## Interfaz de usuario

### Estilo lista
![Screenshot 2024-08-13 at 19 08 02](https://github.com/user-attachments/assets/d643c7f9-44e8-4f94-a23c-69759b600c82)

### Estilo cuadrícula
![Screenshot 2024-08-13 at 19 08 00](https://github.com/user-attachments/assets/b28b346a-58f3-4f7c-a23d-b19f0695bf23)

### Vista columna Miller
![Screenshot 2024-08-13 at 19 08 07](https://github.com/user-attachments/assets/95ab9426-837f-492d-8139-9bf7f1f0c51e)

### Vista de panel dual
![Screenshot 2024-08-13 at 19 08 25](https://github.com/user-attachments/assets/a3f9a511-5e8f-44ed-95d3-1a59e2cba05b)

## Comparación de velocidad
Explorador de archivos de Windows: _39.83 seg._<br/>
CoDriver: **_0.81 seg._**

https://github.com/user-attachments/assets/17116fa5-8f43-4339-a4ff-2525e7c94ae0

Explorador de archivos de Windows: _44.91 seg._<br/>
CoDriver: **_< 0.5 seg._**

https://github.com/user-attachments/assets/169da3d0-06ac-4775-a631-5c5708ae4766

</br>

## Cómo contribuir
Configura tu máquina para desarrollar aplicaciones tauri v1: [Requisitos previos de Tauri](https://tauri.app/v1/guides/getting-started/prerequisites)
</br></br>
Cuando esto esté listo, simplemente haz ```git clone https://github.com/RickyDane/CoDriver``` o ```gh repo clone RickyDane/CoDriver``` en una ubicación de tu máquina.
</br></br>
Deberías poder ejecutar ```cargo tauri dev``` en el directorio raíz de este proyecto para comenzar a construir y ejecutar CoDriver.
</br>
Asegúrate de tener instalado tauri-cli: ```cargo install tauri-cli```
</br></br>

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-02

---
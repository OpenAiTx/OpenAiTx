# WineZGUI

#### Interfaz gráfica de Wine usando Zenity - ¡Juega y Comparte!

![](https://raw.githubusercontent.com/fastrizwaan/WineZGUI/main/assets/winezgui.svg) <a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Descargar en Flathub' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>

![](https://github.com/fastrizwaan/WineZGUI/releases/download/0.97.12/winezgui-0.97.14.png)

## Qué es WineZGUI

WineZGUI (pronunciado Wine-Zee-Goo-Eee) es una interfaz para Wine para jugar juegos de Windows fácilmente con Wine. Es una colección de scripts Bash para la gestión de prefijos de Wine e integración con el escritorio Linux para una experiencia de juego con Wine más sencilla usando Zenity. Permite el lanzamiento rápido de aplicaciones o juegos EXE Direct play (no instalados) desde el gestor de archivos como Nautilus y permite crear un prefijo Wine separado para cada binario EXE de Windows.

## ¿Por qué WineZGUI?

1. Ejecuta juegos de Windows o archivos exe desde el gestor de archivos
2. Crea accesos directos a aplicaciones para un acceso más fácil.
3. Enfócate en jugar y no en configurar prefijos.
4. Respalda y restaura prefijos para uso posterior.
5. Crea paquetes de juegos para compartir (prefijo + juego)

## Cómo funciona

1. Cuando un binario de Windows o exe se abre con WineZGUI, 
2. Crea un nuevo prefijo (copia plantilla) y un acceso directo en el escritorio con el nombre del archivo EXE.
3. Cuando el usuario lanza el script, se ejecuta el exe.
4. Si es un instalador, detectará el exe instalado y creará accesos directos en la categoría del menú Juegos.

## Cómo ejecutar un juego o programa en otra unidad o directorio

Abre tu Terminal y escribe esto:

`flatpak override --user --filesystem=/ruta/a/tu/unidad io.github.fastrizwaan.WineZGUI`

### Instalar WineZGUI

WineZGUI está disponible como Flatpak en Flathub:

<a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Descargar en Flathub' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>


Flathub WineZGUI solo puede acceder a los directorios Escritorio, Documentos, Descargas, Música, Imágenes y Videos. Para acceder a archivos de otras ubicaciones o de otras particiones o unidades montadas, copie los archivos en los directorios mencionados anteriormente (Descargas, etc.) o se necesita permiso de lectura, que se puede otorgar usando la aplicación Flatseal o mediante la línea de comandos `flatpak --user override --filesystem=host:ro io.github.fastrizwaan.WineZGUI`

Recomiendo encarecidamente usar la versión flatpak, porque el wine basado en la distribución (wine-staging) se actualiza constantemente y los juegos pueden dejar de funcionar cada pocos días. Usar wine estable desde flathub es mejor o usar wine estable 5.0 o 7.0 de los paquetes de la distribución.

#### Instalar WineZGUI flatpak en [distribuciones Linux soportadas](https://flatpak.org/setup/)

WineZGUI está empaquetado en flatpak-wine por el que suscribe. [WineZGUI Flathub](https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI) mi otro flatpak ahora obsoleto [flatpak-wine](https://github.com/fastrizwaan/flatpak-wine)

### CONFIGURACIÓN en un sistema Linux, ver [Requisitos](https://github.com/fastrizwaan/WineZGUI#requirements)

La configuración es instantánea ya que copia algunos archivos a directorios específicos.

##### Versión 0.99.13

Descargar fuente [WineZGUI-0.99.13.tar.gz](https://github.com/fastrizwaan/WineZGUI/archive/refs/tags/0.99.13.tar.gz) o usar `git tag 0.99.13`

##### Usando tar.gz

```
wget https://github.com/fastrizwaan/WineZGUI/archive/refs/tags/0.99.13.tar.gz
tar -zxvf 0.99.13.tar.gz
cd WineZGUI-0.99.13
sudo ./setup --install ; #systemwide
```
##### git tag 0.99.13


```
git clone --depth 1 --branch 0.99.13 https://github.com/fastrizwaan/WineZGUI.git
cd WineZGUI
sudo ./setup --install ; #systemwide
```

##### Versión de desarrollo

```
git clone https://github.com/fastrizwaan/WineZGUI.git
cd WineZGUI
sudo ./setup --install ; #systemwide
```

### Desinstalar WineZGUI

##### Desinstalación con Flatpak

```
flatpak remove io.github.fastrizwaan.WineZGUI
```

##### Desinstalación del sistema

Ejecute `uninstall` desde el mismo directorio de origen de la instalación

```
sudo ./setup --uninstall
```

## Requisitos

`wine` - programa principal

`winetricks` - debe tener el script adicional de wine

`perl‑image‑exiftool` - para extraer el nombre de la aplicación/juego

`icoutils` - para extraer el icono del archivo exe

`gnome-terminal` - (opcional) para acceder al directorio del prefijo en la consola

## Instalar requisitos para Linux OS

### Distribuciones compatibles con Flatpak

Obtenga [flatpak-wine](https://github.com/fastrizwaan/flatpak-wine/releases) que incluye todas las dependencias. Útil para distribuciones que no empaquetan wine.

```
flatpak --user remote-add --if-not-exists flathub https://flathub.org/repo/flathub.flatpakrepo
flatpak --user -y install flathub org.winehq.Wine/x86_64/stable-24.08
```

## Dependencias en tiempo de ejecución:

### Fedora 36

`sudo dnf install zenity wine winetricks perl-Image-ExifTool icoutils gnome-terminal wget zstd samba-winbind-clients.x86_64 samba-winbind-clients.i686`

### Debian / Ubuntu / Linux Mint

```
sudo dpkg --add-architecture i386 && sudo apt update
sudo apt install zenity wine wine32 wine64 winetricks libimage-exiftool-perl icoutils gnome-terminal wget zstd winbind
```

### Solus

```
sudo eopkg it zenity wine wine-32bit winetricks perl-image-exiftool icoutils gnome-terminal wget zstd diffutils samba-devel
```

### Arch Linux / EndeavourOS

```
sudo pacman -Sy zenity wine winetricks perl-image-exiftool icoutils gnome-terminal wget \
                lib32-alsa-plugins lib32-libpulse lib32-openal zstd samba
```

#### Controladores compatibles con XBOX

compilar e instalar controladores del kernel para controladores compatibles con xbox 360 desde https://github.com/paroj/xpad


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-27

---
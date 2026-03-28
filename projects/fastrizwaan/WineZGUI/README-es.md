
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# WineZGUI

#### Interfaz gráfica de Wine usando Zenity - ¡Juega y comparte!

![](https://raw.githubusercontent.com/fastrizwaan/WineZGUI/main/assets/winezgui.svg) <a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Descargar en Flathub' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>

![](https://github.com/fastrizwaan/WineZGUI/releases/download/0.97.12/winezgui-0.97.14.png)

## ¿Qué es WineZGUI?

WineZGUI (pronunciado Wine-Zee-Goo-Eee) es una interfaz para Wine que permite jugar juegos de Windows fácilmente con Wine. Es una colección de scripts Bash para la gestión de prefijos de Wine y la integración con el escritorio Linux, facilitando la experiencia de juego con Zenity. Permite lanzar rápidamente una aplicación o juego EXE de Direct play (no instalado) desde el gestor de archivos como Nautilus y permite crear un prefijo de Wine separado para cada binario EXE de Windows.

## ¿Por qué WineZGUI?

1. Ejecuta juegos de Windows o archivos exe desde el gestor de archivos
2. Crea un acceso directo de la aplicación para un acceso más fácil.
3. Se enfoca en jugar y no en configurar prefijos.
4. Realiza copias de seguridad y restauración de prefijos para su uso posterior.
5. Crea paquetes de juegos para compartir (prefijo+juego)

## ¿Cómo funciona?

1. Cuando se abre un binario de Windows o exe con WineZGUI,
2. Crea un nuevo prefijo (copia plantilla) y un acceso directo en el escritorio con el nombre del archivo EXE.
3. Cuando el usuario ejecuta el script, se lanza el exe.
4. Si es una instalación, detectará el exe instalado y creará accesos directos en la categoría de menú Juegos.

## Cómo ejecutar un juego o programa en otra unidad o directorio

Abre tu Terminal y escribe esto:

`flatpak override --user --filesystem=/ruta/a/tu/unidad io.github.fastrizwaan.WineZGUI`

### Instalar WineZGUI

WineZGUI está disponible como Flatpak en Flathub:

<a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Descargar en Flathub' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>


Flathub WineZGUI solo puede acceder a los directorios Escritorio, Documentos, Descargas, Música, Imágenes y Videos. Para acceder a archivos de otras ubicaciones o de otras particiones o unidades montadas, cópialos a los directorios mencionados anteriormente (Descargas, etc.) o necesita permiso de lectura, que se puede otorgar usando la aplicación Flatseal o usando la línea de comandos `flatpak --user override --filesystem=host:ro io.github.fastrizwaan.WineZGUI`

Recomiendo encarecidamente usar la versión flatpak, porque el wine basado en la distro (wine-staging) se actualiza constantemente y los juegos pueden dejar de funcionar cada pocos días. Usar wine estable de flathub es mejor o usar wine estable 5.0 o 7.0 de los paquetes de la distro.

#### Instalar WineZGUI flatpak en [distros Linux compatibles](https://flatpak.org/setup/)

WineZGUI está empaquetado en flatpak-wine por un servidor. [WineZGUI Flathub](https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI) mi otro flatpak ahora desaprobado [flatpak-wine](https://github.com/fastrizwaan/flatpak-wine)

### CONFIGURACIÓN en un sistema Linux, consulta [Requisitos](https://github.com/fastrizwaan/WineZGUI#requirements)

La configuración es instantánea ya que copia algunos archivos a directorios específicos.

##### Versión 0.99.13

Descarga el código fuente [WineZGUI-0.99.13.tar.gz](https://github.com/fastrizwaan/WineZGUI/archive/refs/tags/0.99.13.tar.gz) o usa `git tag 0.99.13`

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-28

---
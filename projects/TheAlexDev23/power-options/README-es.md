<div align="center">
    <img src="https://raw.githubusercontent.com/TheAlexDev23/power-options/main/icon.png" width=120>
    <h1>
        Opciones de Energía
    </h1>
    <a href="https://discord.gg/KyZt97MvdU">
        <img src="https://img.shields.io/badge/Discord-%235865F2.svg?style=for-the-badge&logo=discord&logoColor=white">
    </a>
    <a href="https://www.paypal.com/paypalme/AlexanderKarpukhin2">
        <img src="https://img.shields.io/badge/PayPal-00457C?style=for-the-badge&logo=paypal&logoColor=white">
    </a>
</div>

<br/>

Aplicación GUI para Linux todo-en-uno y extremadamente rápida para la gestión simple y avanzada
de energía en cualquier dispositivo.

Power Options puede ser un reemplazo directo para cualquier aplicación de ahorro de energía,
incluyendo TLP, auto-cpufreq, cpupower-gui, etc. Power Options cubre todos los
ajustes de ahorro de energía más comunes y añade otros adicionales que no están presentes en ninguna otra aplicación.

Al instalar, Power Options analizará el sistema y generará de forma inteligente una amplia gama
de perfiles basados en los hallazgos. Estos perfiles están muy optimizados y no deberían
requerir intervención, a menos que el usuario quiera más control.

La mayoría de las aplicaciones sólo permiten dos perfiles: Perfil de Batería y Perfil de Corriente Alterna (CA). Esto
es subóptimo para ocasiones en las que se desea un control mayor. Esto fue lo que
llevó a la creación del sistema de perfiles que utiliza este programa:
- El usuario puede tener tantos perfiles como desee
- El usuario elige qué perfiles se seleccionarán para Batería y CA.
- El usuario puede anular temporalmente la selección de perfil por otro hasta que
  elimine esa anulación.
- El usuario puede establecer una anulación persistente que se mantendrá tras reinicios.

## Interfaces/Frontends Disponibles

Se puede simplemente instalar el demonio y editar los archivos de configuración manualmente
ya que están escritos en TOML. Pero la mayor fortaleza de este programa
son las interfaces GUI que proporciona, ya que casi ninguna otra herramienta de ahorro de energía lo hace
tiene uno y recurre a archivos de configuración.

### Interfaz nativa GTK

Simple, ligera y nativa con una interfaz sencilla. Recomendado para la mayoría
de los usuarios.

![gtk-slideshow](https://raw.githubusercontent.com/TheAlexDev23/power-options/main/static/gtk-slideshow.gif)

### Interfaz WebKit

Opciones más avanzadas y mayor control. No tan ligera. Recomendado para
usuarios avanzados y usuarios que buscan usar power-options junto con
otra solución de gestión de energía.

![webview-slideshow](https://raw.githubusercontent.com/TheAlexDev23/power-options/main/static/webview-slideshow.gif)

## Características

Power options fue creado basado en una recopilación de todos los consejos y
recomendaciones de los wikis y guías de Linux más importantes, así como de otras
aplicaciones de ahorro de energía. Algunos ejemplos incluyen:
- https://wiki.archlinux.org/title/Power_management
- https://wiki.gentoo.org/wiki/Power_management/Guide
- https://en.wikipedia.org/wiki/Power_management
- https://github.com/supplantr/ftw
- https://github.com/linrunner/TLP
- https://github.com/AdnanHodzic/auto-cpufreq
- https://github.com/vagnum08/cpupower-gui

Power Option incluye las siguientes características:
- Más tipos de perfiles que alternativas
- Puede generar perfiles inteligentemente analizando el sistema del usuario.
- Opciones de suspensión del sistema (suspender, apagar pantalla)
- Opciones de CPU
- Opciones individuales por núcleo de CPU. La mayoría de las herramientas de ahorro
  de energía carecen de esta opción y fue una de las principales motivaciones para este proyecto.
- Opciones de pantalla
- Opciones para deshabilitar componentes de radio (por ejemplo Bluetooth, WiFi, NFC)
- Opciones de red. Permite un control MUCHO mayor que aplicaciones alternativas, pero
  requiere la recarga del controlador de red. Limitado a tarjetas de red Intel que usan
  iwlwifi.
- Opciones ASPM
- Opciones PCI
- Opciones USB
- Opciones SATA
- Opciones del Kernel
- Configuraciones de firmware
- Opciones de audio
- Opciones de GPU
- Configuraciones del Límite de Potencia Promedio en Tiempo Real (RAPL) de Intel

## Instalación

### Recomendado: DistroPack (Interfaz GTK, Bandeja y Demonio)

Para la mayoría de los usuarios, recomendamos instalar mediante [DistroPack](https://distropack.dev), que provee paquetes para Debian/Ubuntu, Fedora/RHEL/Rocky y Arch Linux con manejo automático de particularidades específicas de cada distribución.

**Interfaz GTK:**
Visite [https://distropack.dev/Install/Package/TheAlexDev23/power-options/power-options-gtk](https://distropack.dev/Install/Package/TheAlexDev23/power-options/power-options-gtk) para instrucciones de instalación específicas para su distribución.

**Bandeja del sistema:**
Visite [https://distropack.dev/Install/Package/TheAlexDev23/power-options/power-options-tray](https://distropack.dev/Install/Package/TheAlexDev23/power-options/power-options-tray) para instrucciones de instalación específicas para su distribución.

**Solo el demonio:**
Visite [https://distropack.dev/Install/Package/TheAlexDev23/power-options/power-options-daemon](https://distropack.dev/Install/Package/TheAlexDev23/power-options/power-options-daemon) para instrucciones de instalación específicas para su distribución.

### Arch Linux (AUR)

Para usuarios de Arch Linux, también hay paquetes disponibles en AUR:

- GTK: `power-options-gtk` (estable) y `power-options-gtk-git` (últimas novedades)
- Webview: `power-options-webview` (estable) y `power-options-webview-git` (últimas novedades)
- Bandeja del sistema: `power-options-tray` (estable) y `power-options-tray-git` (últimas novedades)
- Solo el demonio: `power-options-daemon` (estable) y `power-options-daemon-git` (últimas novedades)

### Interfaz Webview (Solo desde código fuente o AUR)

La interfaz webview actualmente no está disponible en DistroPack y debe ser instalada desde el código fuente o mediante AUR (para usuarios de Arch Linux).

**Desde AUR (solo Arch Linux):**
```bash
yay -S power-options-webview  # or power-options-webview-git for bleeding edge
```
Para compilar, se requieren las bibliotecas de desarrollo `libsoup-3.0-dev`, `libwebkit2gtk-4.1-dev` y  
`libxdo-dev` (o el equivalente en su distribución)



```bash
# dioxus-cli is required
cargo install dioxus-cli
git clone https://github.com/TheAlexDev23/power-options/ --depth=1
cd power-options/scripts
chmod +x *.sh
# Run as local user, will require sudo password
./install-webview.sh
# If installing for the first time
./setup.sh
# If updating
./update.sh
```

### Instalación desde el código fuente (método alternativo)

Si prefieres compilar desde el código fuente o DistroPack no soporta tu distribución:

- GTK:

Para compilar, requiere las librerías de desarrollo `libgtk4-dev` `libadwaita-1-dev` (o el equivalente en
tu distribución)
```bash
git clone https://github.com/TheAlexDev23/power-options/ --depth=1
cd power-options/scripts
chmod +x *.sh
# Run as local user, will require sudo password
./install-gtk.sh
# If installing for the first time
./setup.sh
# If updating
./update.sh
```

- El icono de la bandeja del sistema:

```bash
git clone https://github.com/TheAlexDev23/power-options/ --depth=1
cd power-options/scripts
chmod +x *.sh
# Run as local user, will require sudo password
./install-tray.sh
# If installing for the first time
./setup.sh
# If updating
./update.sh
```

- Solo el demonio:

```bash
git clone https://github.com/TheAlexDev23/power-options/ --depth=1
cd power-options/scripts
chmod +x *.sh
# Run as local user, will require sudo password
./install-daemon.sh
# If installing for the first time
./setup.sh
# If updating
./update.sh
```

## Dependencias

Para dependencias de *build*, consulte la guía de instalación arriba.

Obligatorias:
- lspci
- lsusb
- acpi

Opcionales:
- tarjeta de red compatible con iwlwifi para configuración de red
- tarjeta de sonido Intel para configuración de audio
- GPU Intel/AMD para configuración de GPU
- xrandr: control de resolución/frecuencia de actualización
- brightnessctl: control de brillo
- ifconfig: bloqueo de ethernet
- xset: tiempo para apagar la pantalla
- xautolock: tiempo para suspensión del sistema

Frontend webview:
- webkit2gtk
- dioxus-cli

Frontend GTK:
- yad
- libadwaita

## Actualización

Si instaló usando DistroPack, su gestor de paquetes debería manejar las
actualizaciones automáticamente (p. ej., `sudo apt update && sudo apt upgrade` para Debian/Ubuntu,
`sudo dnf update` para Fedora, o `sudo pacman -Syu` para Arch).

Si instaló usando el AUR, su gestor de paquetes debería manejar las
actualizaciones.

Si instaló usando scripts de instalación, simplemente descargue los últimos cambios y
ejecute de nuevo los scripts de instalación y `./update.sh`. **Importante, no ejecute
`./uninstall.sh`, `./setup.sh` ni `power-daemon-mgr setup` si usted
quieres mantener tus perfiles**

## Limitaciones
- La configuración de red solo funciona en tarjetas Intel y tarjetas que usan iwlwifi
- El control de resolución y tasa de refresco solo funciona en X11 (aunque otras opciones deberían funcionar).
- La configuración de audio solo funciona en tarjetas Intel y tarjetas que usan `snd_hda_intel`
  o `snd_ac97_codec`
- La configuración de GPU solo funciona en tarjetas Intel y AMD o tarjetas que usan los controladores/módulos `i915`,
  `amdgpu` o `radeon`.
- Las opciones para controlar la resolución y la tasa de refresco solo están disponibles en
  el frontend webview.

## Contribuyendo

Una de las formas más fáciles de ayudar es abriendo issues cuando encuentres errores.
Esto permite a los desarrolladores saber qué corregir, y ayuda a futuros usuarios con el mismo
problema a encontrar una solución.

Linux es un ecosistema grande, existen alternativas para casi todo. Y
aunque power-options fue construido para usarse con el software Linux más popular,
todavía puedes ayudar portando power-options a otras alternativas que uses
abriendo PRs. Algunos ejemplos podrían incluir portar power-options fuera de systemd,
añadir algunas características exclusivas de X a wayland, etc.

La rama `dev` casi siempre tendrá algunas características experimentales que aún
no se han fusionado en la rama `main`. Si tu hardware soporta esas
funciones, los desarrolladores agradecerán mucho si las pruebas en tu
sistema e informas de posibles problemas. Se recomienda usar el servidor de Discord de power-options
para esos casos.

## Agradecimientos
- Arch Linux Wiki (https://wiki.archlinux.org)
- TLP (https://github.com/linrunner/TLP)
- Conjunto de iconos Open Source de Figma (https://www.figma.com/community/file/1250041133606945841/8-000-free-icons-open-source-icon-set)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-26

---
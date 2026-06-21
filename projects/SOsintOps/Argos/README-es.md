# ARGOS — Beta
<img align="right" width="86" height="150" src="https://github.com/SOsintOps/Argos/blob/master/multimedia/images/scribblenauts-argos.png">

> **ADVERTENCIA: VERSIÓN BETA**
> Este script ha sido actualizado para Ubuntu 24.04 LTS y Ubuntu Budgie 24.04 LTS.
> Está en pruebas activas. Siempre ejecútelo en una máquina virtual limpia antes de usarlo en producción.
> Informe cualquier problema abriendo un issue.

Argos configura automáticamente una estación de trabajo OSINT de código abierto desde una máquina virtual limpia de Ubuntu 24.04 LTS.

La mejor práctica recomienda usar una VM dedicada para cada investigación OSINT.
Este script sigue los métodos descritos por Michael Bazzell en [Open Source Intelligence Techniques](https://inteltechniques.com/book1.html).

## Contenidos
- [Requisitos](#requirements)
- [Herramientas](#tools)
- [Instalación](#installation)
- [Registro de Instalación](#installation-log)
- [Por Hacer](#to-do)
- [Recursos](#resources)
- [Créditos](#credits)
- [Licencias](#licences)
- [Historial de Versiones](https://raw.githubusercontent.com/SOsintOps/Argos/master/docs/VERSION_HISTORY.md)
- [Guías de Análisis OSINT](https://raw.githubusercontent.com/SOsintOps/Argos/master/docs/guidelines.md)
- [Preguntas Frecuentes](https://raw.githubusercontent.com/SOsintOps/Argos/master/docs/faq.md)

---

## Requisitos

- Ubuntu **24.04 LTS** o **Ubuntu Budgie 24.04 LTS** (VM o estación de trabajo)
- Cualquier nombre de usuario Linux (se ha eliminado el requisito anterior de usar `osint`)
- Idioma del sistema: **Inglés**
- Conexión activa a internet durante la instalación
- **VirtualBox Guest Additions ya instalado** — el script no los instala. Instale Guest Additions antes de ejecutar `setup.sh` para habilitar el portapapeles compartido, arrastrar y soltar, y soporte de pantalla completa.

> El script está optimizado para VirtualBox. El código para VMware Tools está disponible en los comentarios.

**Probado en:**
- Ubuntu Budgie 24.04 LTS (VM)
- Ubuntu 24.04 LTS (VM)

**Ya no es compatible:**
- Ubuntu 22.04 LTS (algunas dependencias son incompatibles)
- Ubuntu 20.04 LTS

---

## Herramientas

### OSINT

| Herramienta | Estado | Notas |
|-------------|--------|-------|
| [Amass](https://github.com/owasp-amass/amass) | Activo | Enumeración de subdominios |
| [Instaloader](https://instaloader.github.io/) | Activo | OSINT de Instagram |
| [Toutatis](https://github.com/megadose/toutatis) | Limitado | Requiere ID de sesión de Instagram |
| [HTTrack](https://www.httrack.com/) | Activo | Rastreo y espejo web |
| [MediaInfo](https://mediaarea.net/en/MediaInfo) | Activo | Análisis de metadatos multimedia |
| [ExifTool](https://exiftool.org/) | Activo | Metadatos de documentos e imágenes |
| [EyeWitness](https://github.com/FortyNorthSecurity/EyeWitness) | Activo | Capturas de pantalla de sitios web |
| [The Harvester](https://github.com/laramies/theHarvester) | Activo | Reconocimiento de correos y dominios |
| [Metagoofil](https://github.com/opsdisk/metagoofil) | Activo | Metadatos de documentos públicos |
| [recon-ng](https://github.com/lanmaster53/recon-ng) | Activo | Framework modular de OSINT |
| [Sherlock](https://github.com/sherlock-project/sherlock) | Activo | Búsqueda de nombres de usuario |
| [SpiderFoot](https://github.com/smicallef/spiderfoot) | Activo | Automatización OSINT |
| [blackbird](https://github.com/p1ngul1n0/blackbird) | Activo | Búsqueda avanzada de nombres de usuario |
| [holehe](https://github.com/megadose/holehe) | Activo | OSINT de correos electrónicos |
| [maigret](https://github.com/soxoj/maigret) | Activo | Búsqueda de nombres de usuario (fork avanzado de Sherlock) |
| [Maltego](https://www.maltego.com/) | Activo | Análisis de enlaces (requiere cuenta) |
| [yt-dlp](https://github.com/yt-dlp/yt-dlp) | Activo | Descargador de videos (reemplaza a youtube-dl) |

**Herramientas eliminadas (abandonadas o descontinuadas):**
- ~~Instalooter~~: usar Instaloader
- ~~Sublist3r~~: usar Amass
- ~~Photon~~: usar Katana o GoSpider
- ~~youtube-dl~~: reemplazado por yt-dlp
- ~~Moriarty-Project~~: usar PhoneInfoga
- ~~Elasticsearch-Crawler~~: usar Shodan CLI
- ~~Atom Editor~~ (descontinuado diciembre 2022): reemplazado por VSCodium
### Herramientas Generales

| Herramienta | Estado |
|-------------|--------|
| [VLC](https://www.videolan.org/vlc/) | Activo |
| [Google Earth Pro](https://www.google.com/earth/versions/#earth-pro) | Activo |
| [VSCodium](https://vscodium.com/) | Activo (reemplaza a Atom) |
| [CherryTree](https://www.giuspen.com/cherrytree/) | Activo |
| [KeePassXC](https://keepassxc.org/) | Activo |
| [Kazam](https://launchpad.net/kazam) | Activo |
| [Audacity](https://www.audacityteam.org/) | Activo |
| [Tor Browser](https://www.torproject.org/) | Activo |
| [OpenShot](https://www.openshot.org/) | Activo |
| [Obsidian](https://obsidian.md/) | Activo (última versión obtenida dinámicamente) |
| [Ripgrep](https://github.com/BurntSushi/ripgrep) | Activo |
| [Recursos de Inteligencia de Amenazas](https://github.com/pstirparo/threatintel-resources) | Activo |

---

## Instalación

1. Abra una terminal.

2. Instale Git si aún no está presente:

    ```bash
    sudo apt install -y git
    ```

3. Clona el repositorio en el directorio `Descargas`:
    ```bash
    git clone https://github.com/SOsintOps/Argos ~/Downloads/Argos
    ```

4. Hacer el script ejecutable:
    ```bash
    chmod +x ~/Downloads/Argos/setup.sh
    ```

5. Ejecuta el script:
    ```bash
    ~/Downloads/Argos/setup.sh
    ```

    > Firefox no necesita ser cerrado o abierto manualmente. El script inicializa el perfil de Firefox automáticamente si aún no ha sido creado.

---

## Registro de Instalación

El script genera automáticamente un archivo de registro en el directorio de Descargas:

```
~/Downloads/argos_install_YYYYMMDD_HHMMSS.log
```

El registro contiene la salida completa de la instalación con marcas de tiempo. Si ocurre un error, el número exacto de línea se registra en el registro.

---

## Por hacer

- Añadir PhoneInfoga como reemplazo de Moriarty-Project
- Añadir Katana o GoSpider como reemplazo de Photon
- Actualizar plantillas de informes de LibreOffice para investigaciones OSINT
- Completar pruebas de extremo a extremo en la VM Ubuntu Budgie 24.04 LTS
- Añadir atajos para holehe, maigret standalone y blackbird standalone

---

## Recursos

- [Sitio web OSIntOps](https://osintops.com/en/)
- [Presentación del proyecto Argos (italiano)](https://osintops.com/progetto-argos/)
- [Noticias diarias OSInt](https://t.me/Osintlatestnews)
- [Técnicas de inteligencia de código abierto por Michael Bazzell](https://inteltechniques.com/book1.html)

---

## Créditos

- Skykn0t por el script original OSINT_VM_Setup
- [oh6hay](https://github.com/oh6hay) por el nombre del script
- [pinkevilpimp](https://github.com/pinkevilpimp) por el script del fondo de pantalla

---

## Licencias

Ver los archivos de licencia incluidos en el repositorio.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-21

---
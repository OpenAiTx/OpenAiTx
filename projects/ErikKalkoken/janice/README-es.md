# Janice

Una aplicación de escritorio para visualizar archivos JSON grandes.

[![GitHub Release](https://img.shields.io/github/v/release/ErikKalkoken/janice)](https://github.com/ErikKalkoken/janice)
[![Fyne](https://img.shields.io/badge/dynamic/regex?url=https%3A%2F%2Fgithub.com%2FErikKalkoken%2Fjanice%2Fblob%2Fmain%2Fgo.mod&search=fyne%5C.io%5C%2Ffyne%5C%2Fv2%20(v%5Cd*%5C.%5Cd*%5C.%5Cd*)&replace=%241&label=Fyne&cacheSeconds=https%3A%2F%2Fgithub.com%2Ffyne-io%2Ffyne)](https://github.com/fyne-io/fyne)
[![build status](https://github.com/ErikKalkoken/janice/actions/workflows/ci-cd.yml/badge.svg)](https://github.com/ErikKalkoken/janice/actions/workflows/ci-cd.yml)
[![codecov](https://codecov.io/gh/ErikKalkoken/janice/graph/badge.svg?token=nei6PLRXrD)](https://codecov.io/gh/ErikKalkoken/janice)
[![GitHub License](https://img.shields.io/github/license/ErikKalkoken/janice)](https://github.com/ErikKalkoken/janice)
[![GitHub Downloads (all assets, all releases)](https://img.shields.io/github/downloads/ErikKalkoken/janice/total)](https://github.com/ErikKalkoken/janice/releases)

[![download](https://github.com/user-attachments/assets/c8de336f-8c42-4501-86bb-dbc9c66db1f0)](https://github.com/ErikKalkoken/janice/releases/latest)

## Contenidos

- [Descripción](#description)
- [Capturas de pantalla](#screenshots)
- [Cómo ejecutar](#how-to-run)
- [Preguntas frecuentes](#faq)
- [Atribuciones](#attributions)

## Descripción

Janice es una aplicación de escritorio para visualizar archivos JSON grandes. Sus características clave son:

- Navegar a través de un documento JSON en estructura clásica de árbol
- Los archivos JSON pueden abrirse mediante un diálogo de archivos, desde el portapapeles, arrastrándolos a la ventana o como argumento de línea de comandos
- Soporta visualizar archivos JSON muy grandes (>100MB, >10M elementos)
- Buscar claves y valores en el documento. Soporta comodines.
- Exportar partes de un archivo JSON a un nuevo archivo o al portapapeles
- Copiar valores al portapapeles
- Archivo ejecutable único, no requiere instalación
- Aplicación de escritorio que funciona en Windows, Linux y macOS
- Tema automático oscuro y claro

## Capturas de pantalla

### Tema claro

![light](https://cdn.imgpile.com/f/0IrYBjJ_xl.png)

### Tema oscuro

![dark](https://cdn.imgpile.com/f/bdQBc3q_xl.png)

## Cómo ejecutar

Para ejecutar Janice, simplemente descargue y descomprima la última versión en su computadora. Janice se distribuye como un único archivo ejecutable que se puede ejecutar directamente. Puede encontrar los paquetes más recientes para descargar en la [página de lanzamientos](https://github.com/ErikKalkoken/janice/releases).

### Linux

Proporcionamos dos variantes para instalar en el escritorio Linux:

- AppImage: La variante AppImage le permite ejecutar la aplicación directamente desde el ejecutable sin necesidad de instalación o acceso root.
- Tarball: El archivo tar requiere instalación, pero también permite integrar la aplicación en su entorno de escritorio. El tarball también tiene una compatibilidad más amplia entre diferentes versiones de Linux.

#### AppImage

> [!NOTE]
> La aplicación se distribuye en formato [AppImage](https://appimage.org/), por lo que puede usarse sin requerir instalación y ejecutarse en muchas distribuciones diferentes de Linux.

1. Descargue el archivo AppImage más reciente desde la página de lanzamientos y hágalo ejecutable.
1. Ejecútelo para iniciar la aplicación.

> [!TIP]
> Si recibe el siguiente error: `AppImages require FUSE to run.`, primero debe instalar FUSE en su sistema. Esta es una biblioteca requerida por todas las AppImages para funcionar. Consulte [esta página](https://docs.appimage.org/user-guide/troubleshooting/fuse.html#the-appimage-tells-me-it-needs-fuse-to-run) para más detalles.

#### Tarball

1. Descargue el último archivo tar desde la página de lanzamientos.
1. Descomprima el archivo tar, por ejemplo con: `tar xf janice-0.12.3-linux-amd64.tar.xz`
1. Ejecute `make user-install` para instalar la aplicación para el usuario actual o ejecute `sudo make install` para instalar la aplicación en el sistema.

Ahora debería tener un acceso directo en el lanzador de su entorno de escritorio para iniciar la aplicación.

Para desinstalar la aplicación, ejecute: `make user-uninstall` o `sudo make uninstall` según cómo la haya instalado.

### Windows

1. Descargue el archivo zip para Windows desde la última versión en Github.
1. Descomprima el archivo en un directorio de su elección y ejecute el archivo .exe para iniciar la aplicación.

### Mac OS

1. Descargue el archivo zip de darwin desde la última versión en Github para su plataforma respectiva (arm o intel).
1. Descomprima el archivo en un directorio de su elección
1. Ejecute el archivo .app para iniciar la aplicación.

> [!TIP]
> MacOS puede reportar incorrectamente esta aplicación como "dañada", porque no está firmada con un certificado de Apple. Puede eliminar este error abriendo una terminal y ejecutando el siguiente comando. Para más información, por favor vea [Fyne Troubleshooting](https://docs.fyne.io/faq/troubleshoot#distribution):
>
> ```sudo xattr -r -d com.apple.quarantine Janice.app```

### Construir y ejecutar desde el repositorio

Si su sistema está configurado para construir aplicaciones [Fyne](https://fyne.io/), puede construir y ejecutar esta aplicación directamente desde el repositorio con el siguiente comando:

```sh
go run github.com/ErikKalkoken/janice@latest
```
Para más información sobre cómo configurar su sistema para Fyne, por favor consulte: [Primeros pasos](https://docs.fyne.io/started/).

## Preguntas frecuentes

### ¿Cuál es el archivo JSON más grande que puedo cargar?

El archivo JSON más grande que puede cargar en su computadora depende principalmente de la cantidad de RAM que tenga y del archivo JSON en particular. El principal factor del consumo de memoria es la cantidad de elementos en un documento JSON.

Para comparación, realizamos una prueba de carga en uno de nuestros notebooks de desarrollo. Tiene 8 GB de RAM y corre Ubuntu 22.04 LTS. Pudimos cargar archivos JSON exitosamente con hasta 45 millones de elementos. El tamaño de nuestro archivo de prueba fue de aproximadamente 2.5 GB.

### ¿Los archivos JSON están formateados?

Sí. El documento JSON se muestra como un árbol y las claves se presentan en orden alfabético.

## Atribuciones

- [Iconos JSON creados por LAB Design Studio - Flaticon](https://www.flaticon.com/free-icons/json)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-29

---
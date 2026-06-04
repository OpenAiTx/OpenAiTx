# ByeTunes 🎵

**¡Di adiós a la sincronización con iTunes!**

ByeTunes es una aplicación nativa para iOS que te permite inyectar música (MP3, M4A, FLAC, WAV) y tonos directamente en la biblioteca de medios de tu dispositivo—sin necesidad de una conexión a la computadora para cada sincronización. Se comunica directamente con la base de datos de medios de iOS, dándote el poder de administrar tu música a tu manera.

## Características

-   **Inyección Directa de Música**: Añade canciones a tu biblioteca de Apple Music sin PC.
-   (DESACTIVADO POR AHORA) **Administrador de Tonos**: Inyecta tonos personalizados (con conversión automática de `.m4r` y `.mp3`).
-   **Soporte para Listas de Reproducción**: Crea y administra listas sobre la marcha.
-   **No se Necesita Computadora** (después de la configuración): ¡Una vez emparejado, eres libre!
-   **Edición de Metadatos**: Se obtienen automáticamente desde iTunes o Deezer.

## Instrucciones de Compilación

Para construir ByeTunes tú mismo, necesitarás una Mac con Xcode.

### Requisitos Previos

1.  **Xcode**: Se recomienda la versión 15 o superior.
2.  **Dispositivo iOS**: Con iOS 16.0 o posterior.

### Bibliotecas Externas

ByeTunes depende de `idevice` (una alternativa a `libimobiledevice`) para comunicarse con el sistema de archivos interno de iOS. **Estos archivos NO están incluidos en este repositorio** por razones de licencia/tamaño.

Para compilar la aplicación, necesitas obtener estos dos archivos y colocarlos en el directorio `MusicManager/`:

1.  `libidevice_ffi.a` (Librería Estática)
2.  `idevice.h` (Archivo Header)

Puedes encontrar idevice y compilarlo desde aquí: [https://github.com/jkcoxson/idevice](https://github.com/jkcoxson/idevice)

*Si no tienes estos archivos, el proyecto no compilará.*

### Pasos para Compilar

1.  Instala Rust:
    ```bash
    curl --proto '=https' --tlsv1.2 -sSf https://sh.rustup.rs | sh
    ```
2.  Añadir la arquitectura ios:
    ```bash
    rustup target add aarch64-apple-ios
    ```
    
3.  Instale las herramientas de línea de comandos de Xcode si aún no las tiene instaladas:
    ```bash
    xcode-select --install
    ```

4.  Clona el repositorio:
    ```bash
    git clone https://github.com/jkcoxson/idevice
    ```
5.  Establecer un objetivo de despliegue:

    ```bash
    export IPHONEOS_DEPLOYMENT_TARGET=xx.x
    ```

6.  Ejecuta el cargo build:
    ```bash
    cargo build --release --package idevice-ffi --target aarch64-apple-ios
    ```
Dentro de la carpeta idevice encuentra: idevice.h y libidevice_ffi.a. Muévelos dentro del proyecto en Xcode, asegúrate de crear **Bridging-Header.h**  
Dentro de tu proyecto Xcode y asegúrate de agregar:

 ```bash
    #import "idevice.h"
```

**En Configuración del Proyecto > Fases de Construcción > Vincular Binarios con Bibliotecas, asegúrate de que libidevice_ffi.a esté listado.**

## Cómo Usar

1. **LocalDevVPN**:
    - Descarga LocalDevVPN desde la App Store/Altstore PAL https://apps.apple.com/us/app/localdevvpn/id6755608044.
    - Ábrelo y toca Conectar, necesitarás una conexión activa para importar el archivo de emparejamiento dentro de la app.

2.  **Emparejamiento**:
    -   En el primer lanzamiento, verás una pantalla "Importar Archivo de Emparejamiento".
    -   Necesitas obtener un `archivo de emparejamiento`.
    -   Descarga idevice_pair refiérete a https://github.com/jkcoxson/idevice_pair .
    -   Genera tu `archivo de emparejamiento`.
    -   Expórtalo desde tu computadora y envíalo por Airdrop/Guárdalo en tu iPhone.
    -   Impórtalo en ByeTunes.
      
3.  **Agregar Música**:
    -   Toca "Agregar Canciones" y selecciona archivos desde la app Archivos.
    -   Presiona "Inyectar al Dispositivo" y observa la magia suceder.
      
4.  **Tonos**:
    -   Ve a la pestaña Tonos, añade tu archivo ¡y inyecta!

## Notas

-   **Apps Firmadas**: Si instalas esto mediante un servicio de firma (Signulous, AltStore, etc.), la app incluye una corrección (`asCopy: true`) para asegurar que la importación de archivos funcione correctamente sin causar fallos.
-   **Respaldo**: ¡Siempre es bueno tener un respaldo de tu biblioteca musical antes de manipular la inyección en la base de datos!

## Soporte y Reporte de Errores

¿Encontraste un error? ¡Nos encantaría solucionarlo!

1.  **Reportar Problemas**: Abre un ticket en [GitHub Issues](https://github.com/EduAlexxis/ByeTunes/issues).
2.  **Únete a la Comunidad**: Chatea con nosotros en [Discord](https://discord.gg/dDQ4P4SyKJ).
3.  **Adjunta Registros de Depuración**:
    *   Si experimentas fallos en la inyección, usa las **Opciones de Depuración** bajo eliminar biblioteca dentro de configuración.
    *   Esto incluye una pantalla de "Registros de Depuración" donde puedes copiar los registros de la app.
    *   ¡Por favor adjunta estos registros en tu reporte de problema—nos ayudan a resolver los problemas mucho más rápido!

---
*Creado con ❤️ por EduAlexxis*


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-04

---
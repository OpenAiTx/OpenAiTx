
# Sammie-Roto
**S**egmenta **A**lgo **M**odelo con **M**ascarilla **I**ntegrada **E**legantemente

![Captura de pantalla de Sammie-Roto](https://raw.githubusercontent.com/Zarxrax/Sammie-Roto/main/sammie/sammie_screenshot.webp)

Sammie-Roto está diseñado para ser una herramienta fácil de usar para el enmascaramiento asistido por IA de clips de video. Sirve como una alternativa gratuita a soluciones comerciales como Roto Brush de Adobe o Magic Mask de DaVinci Resolve. Generalmente es menos preciso que el rotoscopiado manual, pero usualmente puede dar un resultado bastante bueno con poco esfuerzo.

## ¡Consulta el nuevo [Sammie-Roto 2](https://github.com/Zarxrax/Sammie-Roto-2)!

### Actualizaciones
- [31/10/2025] ¡[Sammie-Roto 2](https://github.com/Zarxrax/Sammie-Roto-2) ya está disponible! Todas las actualizaciones futuras serán en esa versión.
- [22/09/2025] Añadida exportación PNG, importación de secuencias de imágenes, corregidos errores en la exportación de enmascarado y carga de videos vía CLI.
- [23/08/2025] Añadidas opciones en la pestaña de exportación para incluir diversa información en el nombre del archivo.
- [16/08/2025] Añadido control deslizante para corregir bordes y ayudar a arreglar máscaras en los bordes del cuadro. Reducido uso de VRAM durante el enmascarado.
- [03/08/2025] Añadida deduplicación para reducir fluctuaciones en los bordes en contenido de anime.
- [10/05/2025] Añadido soporte para importar/exportar imágenes individuales. Ahora se recuerdan los ajustes de exportación.
- [23/04/2025] Añadido instalador para Linux/Mac, reducido consumo de VRAM, varias mejoras y correcciones de errores.
- [04/04/2025] Añadidos algunos controles deslizantes de ajuste en la página de enmascarado.
- [26/02/2025] Añadido soporte para enmascarado de video humano mediante [MatAnyone](https://github.com/pq-yang/MatAnyone), junto con muchas otras mejoras.
- [26/01/2025] Lanzamiento inicial

### Características
- Soporta Windows, Linux y Mac
- Instalador sencillo que descarga automáticamente todas las dependencias y modelos
- Puede funcionar con tan solo 4GB de VRAM o incluso en CPU (pero se recomienda GPU Nvidia de 6GB)
- Incluye 3 modelos de segmentación: Sam 2.1 Large, Sam 2.1 Base+, y EfficientTAM_s_512x512.
- Soporta modelo MatAnyone para enmascarado de video humano.
- Interfaz fácil de usar.
- Soporte para múltiples objetos.
- Varias opciones de posprocesamiento de máscaras, incluyendo suavizado de bordes.
- Soporta deduplicación para reducir fluctuaciones en bordes en contenido de anime.
- Múltiples opciones de exportación: máscara en blanco y negro, canal alfa y pantalla verde.

### Instalación (Windows):
- Descarga la última versión para Windows desde [releases](https://github.com/Zarxrax/Sammie-Roto/releases)
- Extrae el archivo zip.
- Ejecuta 'install_dependencies.bat' y sigue las indicaciones.
- Ejecuta 'run_sammie.bat' para iniciar el software.

Todo está contenido en la carpeta Sammie-Roto. Si desea eliminar la aplicación, simplemente borre esta carpeta. También puede mover la carpeta.

### Instalación (Linux, Mac)
- Asegúrese de que [Python](https://www.python.org/) esté instalado (versión 3.10 o superior)
- Descargue la última versión para Linux/Mac desde [releases](https://github.com/Zarxrax/Sammie-Roto/releases)
- Extraiga el archivo zip.
- Abra una terminal y navegue a la carpeta Sammie-Roto que acaba de extraer del zip.
- Ejecute el siguiente comando: `bash install_dependencies.sh` y luego siga las indicaciones.
- Usuarios de MacOS: haga doble clic en "run_sammie.command" para iniciar el programa. Usuarios de Linux: `bash run_sammie.command` o ejecute el archivo como prefiera.

### Tutorial
[![Tutorial de Sammie-Roto](https://img.youtube.com/vi/042uKTqlJ_c/0.jpg)](https://www.youtube.com/watch?v=042uKTqlJ_c)

### Agradecimientos
* [SAM 2](https://github.com/facebookresearch/sam2)
* [EfficientTAM](https://github.com/yformer/EfficientTAM)
* [MatAnyone](https://github.com/pq-yang/MatAnyone)
* [Wan2GP](https://github.com/deepbeepmeep/Wan2GP) (para MatAnyone optimizado)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-28

---
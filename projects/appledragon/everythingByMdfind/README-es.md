[English](https://raw.githubusercontent.com/appledragon/everythingByMdfind/master/README.md) | [中文](https://raw.githubusercontent.com/appledragon/everythingByMdfind/master/README_CN.md) | [한국어](https://raw.githubusercontent.com/appledragon/everythingByMdfind/master/README_KO.md) | [日本語](https://raw.githubusercontent.com/appledragon/everythingByMdfind/master/README_JP.md) | [Français](https://raw.githubusercontent.com/appledragon/everythingByMdfind/master/README_FR.md) | [Deutsch](https://raw.githubusercontent.com/appledragon/everythingByMdfind/master/README_DE.md) | [Español](https://raw.githubusercontent.com/appledragon/everythingByMdfind/master/README_ES.md)

<img width="3836" height="2026" alt="image" src="https://github.com/user-attachments/assets/d86c3d6b-6fd4-4cfe-b64f-67c465bb3d3c" /><img width="3832" height="2024" alt="image" src="https://github.com/user-attachments/assets/a91d2b13-07ac-4cae-ab33-506f1fa3bca6" />


# Everything por mdfind

Una herramienta de búsqueda de archivos potente y eficiente para macOS, que aprovecha el motor nativo Spotlight para resultados ultrarrápidos.

## Características principales

*   **Búsqueda ultrarrápida:** Utiliza el índice Spotlight de macOS para una búsqueda de archivos casi instantánea.
*   **Opciones de búsqueda flexibles:** Busca por nombre de archivo o contenido para localizar rápidamente los archivos que necesitas.
*   **Filtrado avanzado:** Refina tus búsquedas con una variedad de filtros:
    *   Rango de tamaño de archivo (tamaño mínimo y máximo en bytes)
    *   Extensiones de archivo específicas (por ejemplo, `pdf`, `docx`)
    *   Coincidencia sensible a mayúsculas y minúsculas
    *   Opciones de coincidencia completa o parcial
*   **Búsqueda específica por directorio:** Limita tu búsqueda a un directorio específico para obtener resultados enfocados.
*   **Vista previa enriquecida:** Previsualiza varios tipos de archivos directamente en la aplicación:
    *   Archivos de texto con detección de codificación
    *   Imágenes (JPEG, PNG, GIF con soporte de animación, BMP, WEBP, HEIC)
    *   Archivos SVG con escalado y centrado adecuados
    *   Archivos de video con controles de reproducción
    *   Archivos de audio
*   **Reproductor multimedia integrado:**
    *   Reproducción de video y audio con controles estándar
    *   Ventana de reproductor independiente para archivos multimedia
    *   Modo de reproducción continua
    *   Control de volumen y opción de silencio
*   **Marcadores:** Acceso rápido a búsquedas comunes:
    *   Archivos grandes (>50MB)
    *   Archivos de video
    *   Archivos de audio
    *   Imágenes
    *   Archivos comprimidos
    *   Aplicaciones
*   **Análisis de espacio en disco:** Analiza el uso del espacio en disco para cualquier directorio:
    *   Análisis del espacio en el directorio personal con un solo clic
    *   Visualización interactiva con gráfico de barras que muestra las carpetas que más espacio consumen
    *   Haz clic derecho en cualquier carpeta en los resultados de búsqueda para analizar su uso de espacio
    *   Haz doble clic en las barras del gráfico para profundizar en los subdirectorios para un análisis detallado
    *   Desglose visual de tamaños de subdirectorios con gráficos codificados por colores
    *   Ordenación automática por tamaño para identificar las carpetas más grandes
*   **Resultados ordenables:** Organiza los resultados de búsqueda por nombre, tamaño, fecha de modificación o ruta.
*   **Operaciones múltiples de archivos:** Realiza acciones en varios archivos simultáneamente:
    *   Selección múltiple de archivos usando las teclas Shift o Command (⌘)
    *   Operaciones en lote: Abrir, Eliminar, Copiar, Mover, Renombrar
    *   Menú contextual para operaciones adicionales
*   **Interfaz de búsqueda con múltiples pestañas:** Trabaja con varias sesiones de búsqueda simultáneamente:
    *   Crea nuevas pestañas para diferentes consultas de búsqueda
    *   Cierra, reordena y administra pestañas con el menú contextual de clic derecho
    *   Resultados y configuraciones independientes por pestaña
    *   Experiencia de pestañas similar a Chrome con botones de desplazamiento para muchas pestañas
*   **Interfaz personalizable:**
    *   6 hermosos temas para elegir:
        *   Claro y Oscuro (predeterminado del sistema)
        *   Tokyo Night y Tokyo Night Storm
        *   Chinolor Dark y Chinolor Light (colores tradicionales chinos)
    *   Tematización de la barra de título del sistema que coincide con el tema seleccionado
    *   Mostrar/ocultar panel de vista previa
    *   Historial de búsqueda configurable
*   **Exportación multi-formato:** Exporta los resultados de búsqueda a múltiples formatos:
    *   JSON - Formato de datos estructurados
    *   Excel (.xlsx) - Hoja de cálculo con formato
    *   HTML - Formato de tabla listo para web
    *   Markdown - Formato amigable para documentación
    *   CSV - Valores separados por comas clásico
*   **Carga diferida:** Maneja grandes conjuntos de resultados eficientemente cargando elementos en lotes mientras desplazas.
*   **Arrastrar y soltar:** Arrastra archivos directamente a aplicaciones externas.
*   **Operaciones de ruta:** Copia la ruta del archivo, la ruta del directorio o el nombre del archivo al portapapeles.

## Instalación

1.  **Prerrequisitos:**
    *   Python 3.6+
    *   PyQt6

2.  **Clona el repositorio:**

    ```bash
    git clone https://github.com/appledragon/everythingByMdfind
    cd everythingByMdfind
    ```
3.  **Instalar dependencias:**


    ```bash
    pip install -r requirements.txt
    ```

4.  **Ejecute la aplicación:**

    ```bash
    python everything.py
    ```
## Descargar Aplicación Precompilada

Puedes descargar la aplicación para macOS lista para usar (.dmg) directamente desde la página de [GitHub Releases](https://github.com/appledragon/everythingByMdfind/releases).

## Contribuir

¡Las contribuciones son bienvenidas! No dudes en enviar pull requests o abrir issues para corrección de errores, solicitudes de funciones o mejoras generales.

## Licencia

Este proyecto está licenciado bajo la Licencia Apache 2.0 - consulta el archivo [LICENSE.md](https://raw.githubusercontent.com/appledragon/everythingByMdfind/master/LICENSE.md) para más detalles.

## Autor

Apple Dragon

## Versión

1.4.2

## Agradecimientos

*   Gracias al equipo de PyQt6 por proporcionar un framework de GUI potente y versátil.
*   Inspiración de otras excelentes herramientas de búsqueda de archivos.





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-03

---
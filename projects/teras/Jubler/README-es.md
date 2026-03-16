## Jubler - Editor de Subtítulos

![GitHub release (latest by date)](https://img.shields.io/github/v/release/teras/Jubler)
![GitHub all releases](https://img.shields.io/github/downloads/teras/Jubler/total)
![GitHub](https://img.shields.io/github/license/teras/Jubler?v=2)
![Java](https://img.shields.io/badge/Java-8+-orange)
![Platform](https://img.shields.io/badge/platform-Linux%20%7C%20macOS%20%7C%20Windows-blue)
![GitHub Release Date](https://img.shields.io/github/release-date/teras/Jubler)

Jubler es un editor de subtítulos gratuito y de código abierto para crear, editar y convertir subtítulos basados en texto. Escrito en Java para compatibilidad multiplataforma, proporciona herramientas para crear nuevos subtítulos y perfeccionar los existentes con vista previa de video, validación de calidad y amplio soporte de formatos.

(C) 2005-2025 Panayotis Katsaloulis
panayotis@panayotis.com

Licenciado bajo la Licencia Pública General Affero GNU v3 (AGPL-3.0)

---

## Características

### Formatos de Subtítulos
- **Más de 20 formatos soportados** incluyendo SubRip (SRT), Advanced SubStation Alpha (ASS/SSA), WebVTT, MicroDVD, SubViewer, MPL2, Spruce DVD Maestro, TTML, ITT, DFXP y subtítulos de YouTube
- **Soporte universal de codificación** (UTF-8, UTF-16 y todas las codificaciones de la plataforma Java)
- **Estilos a nivel de caracteres y párrafos** para formatos que lo soportan (ASS/SSA, SRT)
- **Conversión de formatos** entre todos los tipos soportados

### Integración de Video
- **Integración con FFmpeg** para vista previa de cuadros y visualización de forma de onda de audio
- **Soporte para MPlayer** para reproducción de video
- **Edición de subtítulos en tiempo real** mientras se ve el video
- **Línea de tiempo interactiva** con bloques de subtítulos arrastrables
- **Sincronización de dos puntos** para alineación temporal
- **Controles mejorados de vista previa** con soporte de teclas shift/alt y ajuste automático

### Herramientas de Edición
- **Manipulación de tiempo** - desplazamiento, conversión de tasa de cuadros, redondeo de tiempo
- **Operaciones de contenido** - dividir/unir entradas, dividir/unir archivos
- **Procesamiento de texto** - corrector ortográfico, buscar y reemplazar con soporte regex
- **Corrector inteligente de tiempo** con detección y resolución de solapamientos
- **Modo de traducción** para traducción de subtítulos lado a lado
- **Deshacer/rehacer** con historial completo
- **Guardado automático y recuperación**

### Control de Calidad
- **Validación de subtítulos** con reglas de calidad configurables
- **Métricas CPS (caracteres por segundo)** mostradas en la tabla de subtítulos
- **Verificación de cumplimiento de directrices TED**
- **Validación codificada por colores** para resaltar problemas
- **Herramientas de estadísticas y análisis**

### Interfaz de Usuario
- **Soporte HiDPI** con escalado ajustable
- **Tema oscuro** disponible
- **Atajos de teclado personalizables**
- **Interfaz multilingüe** con soporte i18n
- **Marcado de colores** para organizar grupos de subtítulos

### Automatización
- **Herramientas de línea de comandos** para procesamiento por lotes
- **Sistema de plugins** para extensibilidad
- **Integración con herramientas externas**
- **Soporte para Azure Translator** para traducción automática

---

## Primeros Pasos

### Requisitos
- Java 8 o superior (a menudo incluido con la distribución)
- Opcional: MPlayer para vista previa de video
- Opcional: ASpell para corrección ortográfica

### Instalación

Descargue los binarios desde la [página de lanzamientos](https://github.com/teras/Jubler/releases):
- Instaladores para Windows, macOS y Linux
- AppImage para Linux
- Paquete genérico multiplataforma

O compile desde el código fuente (ver [BUILD_AND_RUN.md](https://raw.githubusercontent.com/teras/Jubler/master/BUILD_AND_RUN.md))

### Ejecución

Inicie desde el menú de su aplicación o acceso directo en el escritorio. También puede ejecutar manualmente:
```bash
java -jar Jubler.jar
```

---

## Contributing

Jubler is an open source project that welcomes contributions. Whether you're fixing bugs, adding features, improving documentation, or translating the interface, your help is appreciated.

---

## Credits

Free code signing on Windows provided by [SignPath.io](https://signpath.io/), certificate by [SignPath Foundation](https://signpath.org/)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-16

---
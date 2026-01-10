# Generador de Mapas de Altura PNG/EXR en Escala de Grises de 16/32 Bits

Una herramienta basada en navegador para generar mapas de altura PNG en escala de grises de 16 bits o mapas de altura EXR de 16/32 bits a partir de datos reales de terreno.

Perfecto para crear paisajes realistas en Unreal Engine 5 y otros motores de juego o software 3D, como Terrain3d, Godot4 y Blender.

🌐 **Sitio Web en Vivo:** [https://manticorp.github.io/unrealheightmap/](https://manticorp.github.io/unrealheightmap/)

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/L4L212G6M7)

## ⚠️ Aviso Importante

Hemos comenzado a alcanzar los límites del nivel gratuito de algunos servicios de mapas, por lo que el sitio *puede no funcionar* hasta que obtengamos financiamiento para aumentar estos límites. ¡Si encuentras útil esta herramienta, considera apoyar el proyecto!

## ✨ Características

- **Salida de Alta Calidad de 16/32 bits** - Genera mapas de altura con 65,536/4,294,967,296 niveles de detalle (vs solo 256 en 8 bits)
- **Datos Reales de Terreno** - Usa datos de elevación de alta calidad del [servicio global de elevación de Mapzen](https://www.mapzen.com/blog/elevation/)
- **Interfaz de Mapa Interactiva** - Selección visual de áreas de terreno usando una interfaz de mapa intuitiva
- **Múltiples Modos de Normalización** - Elige entre Ninguno, Regular o Normalización Inteligente para optimizar tus datos de mapas de altura
- **Tamaños de Salida Flexibles** - Tamaños predefinidos para Unreal Engine o dimensiones personalizadas hasta 8129×8129 píxeles
- **Basado en Navegador** - No requiere instalación, funciona completamente en tu navegador web
- **Vista Previa en Tiempo Real** - Ve el área que estás exportando con una superposición en el mapa
- **Copiar y Pegar Coordenadas** - Soporte para múltiples formatos de coordenadas incluyendo DMS y grados decimales

## 🎯 Casos de Uso

- Crear terrenos realistas para paisajes en Unreal Engine 5/Blender/Terrain3D
- Desarrollo de juegos con topografía real precisa
- Proyectos de modelado 3D y visualización
- Aplicaciones de sistemas de información geográfica (SIG)
- Visualización educativa y científica

## 🚀 Inicio Rápido

1. Visita [https://manticorp.github.io/unrealheightmap/](https://manticorp.github.io/unrealheightmap/)
2. Usa el mapa para navegar a la ubicación deseada o ingresa las coordenadas manualmente
3. Ajusta el zoom y tamaño de salida para definir tu área de exportación (mostrada como un rectángulo naranja)
4. Selecciona un modo de normalización apropiado para tu caso de uso
5. Haz clic en "Generar" para crear y descargar tu mapa de altura
Para instrucciones detalladas, visite la página de [Documentación](https://manticorp.github.io/unrealheightmap/instructions.html).

## 📖 Documentación

- **[Instrucciones](https://manticorp.github.io/unrealheightmap/instructions.html)** - Guía completa sobre cómo usar la herramienta
- **[Ejemplos](https://manticorp.github.io/unrealheightmap/examples.html)** - Galería de mapas de altura creados con la herramienta
- **[Información de Licencia](https://manticorp.github.io/unrealheightmap/rights.html)** - Información sobre fuentes de datos y licencias

## 🛠️ Tecnología Utilizada

- **TypeScript** - Código de aplicación con tipado seguro
- **Leaflet** - Interfaz de mapa interactivo
- **jQuery** - Manipulación del DOM e interacciones de UI
- **UPNG.js** - Codificación/decodificación PNG
- **Pako** - Compresión de datos
- **Webpack** - Empaquetado de módulos
- **Bulma** - Framework CSS
- **SASS** - Preprocesamiento CSS

## 💻 Configuración para Desarrollo

### Requisitos Previos

- Node.js (v14 o superior recomendado)
- npm (incluido con Node.js)

### Instalación


```bash
# Clone the repository
git clone https://github.com/manticorp/unrealheightmap.git
cd unrealheightmap

# Install dependencies
npm install
```
### Comandos de compilación


```bash
# Development build
npm run build

# Production build
npm run author

# Watch mode (auto-rebuild on changes)
npm run watch

# Run unit tests
npm test
```

### Estructura del Proyecto

```
├── src/                   # Source TypeScript and SASS files
│   ├── app.ts             # Main application logic
│   ├── main.ts            # Entry point
│   ├── png.ts             # PNG processing
│   ├── processor.ts       # Web worker for image processing
│   ├── sass/              # Stylesheets
│   └── templates/         # HTML templates
├── public/                # Static assets and build output
│   ├── dist/              # Built JavaScript and CSS
│   ├── im/                # Images
│   └── examples/          # Example heightmaps
├── index.html             # Main application page
├── instructions.html      # Documentation page
├── examples.html          # Examples page
└── webpack.config.js      # Webpack configuration
```

## 🎨 Ejemplos

### Gran Cañón (64km)
[Ver en la herramienta](https://manticorp.github.io/unrealheightmap/#latitude/36.18111652966563/longitude/-112.021/zoom/10/outputzoom/14/width/8129/height/8129)

![Ejemplo Gran Cañón](https://raw.githubusercontent.com/manticorp/unrealheightmap/main/public/im/grand_canyon_desserty.png)

Para más ejemplos, visite la [página de ejemplos](https://manticorp.github.io/unrealheightmap/examples.html).

## 🔧 Modos de Normalización

### Ninguno
No se realiza normalización. Los valores de píxel representan directamente la altura en metros (los valores negativos se establecen en 0).

### Regular
Escala los valores de altura para usar todo el rango de 16 bits (0-65535), maximizando el detalle en todo el mapa de alturas.

### Inteligente
Un modo avanzado que maneja errores de datos y valores atípicos. Usa una ventana del 99.9% para filtrar valores extremos mientras preserva valores min/máx auténticos dentro de 1 desviación estándar.

## 📊 Formato de Salida

- **Formato:** PNG en escala de grises de 16 bits, EXR de 16 bits o EXR de 32 bits
- **Profundidad de bits:** 65,536 niveles de detalle (2^16) o 4,294,967,296 (2^32)
- **Precisión:** Capaz de representar el Monte Everest (8,849m) en intervalos de ~13cm (16 bits)
- **Datos fuente:** Datos de elevación de Mapzen (precisión de 24 bits, fidelidad ~4mm)

## 🤝 Contribuciones

¡Las contribuciones son bienvenidas! Por favor, siéntase libre de enviar problemas, bifurcar el repositorio y crear solicitudes de extracción.

## 📄 Licencia

Este proyecto está licenciado bajo la Licencia MIT - vea el archivo [LICENSE](LICENSE) para más detalles.

Los datos de elevación son proporcionados por [Mapzen](https://www.mapzen.com/blog/elevation/) y pueden tener sus propios términos de licencia.

## 💖 Apoyo

Si encuentras esta herramienta útil, por favor considera apoyar el proyecto:

- ☕ [Invítame un café en Ko-fi](https://ko-fi.com/harrymustoeplayfair)
- ⭐ Dale una estrella a este repositorio
- 🐦 Compártelo con otros que puedan encontrarlo útil

## 🙏 Agradecimientos

- [Mapzen](https://www.mapzen.com/) por proporcionar datos globales de elevación de alta calidad
- [Unreal Engine](https://www.unrealengine.com/) comunidad por la inspiración y casos de uso
- Todos los colaboradores y usuarios de esta herramienta

## 📞 Contacto

- **Autor:** Harry Mustoe-Playfair
- **Correo:** harry.mustoeplayfair@gmail.com
- **GitHub:** [manticorp](https://github.com/manticorp)

---

Hecho con ❤️ para la comunidad de Unreal Engine, desarrollo 3D y de juegos


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-10

---
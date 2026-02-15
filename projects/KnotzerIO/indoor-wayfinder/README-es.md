> [!TIP]  
> ¿Buscas una solución de navegación interior más avanzada?  
> Prueba [OpenIndoorMaps](https://github.com/openindoormap/openindoormaps) - con edición de mapas, vistas 3D e integración de mapas exteriores.

# Pathpal: Navegador Interior Basado en Web

Pathpal es una innovadora aplicación web diseñada para revolucionar la navegación interior. Utilizando mapas interactivos y algoritmos eficientes de búsqueda de rutas, ofrece una solución intuitiva para navegar en espacios interiores complejos.  
<br>  
**Demo:** [Visitar Pathpal](https://indoor-wayfinder.vercel.app)

## Tabla de Contenido:

- [Pathpal: Navegador Interior Basado en Web](#pathpal-web-based-indoor-wayfinder)  
  - [Tabla de Contenido:](#table-of-content)  
  - [Sobre la Aplicación](#about-the-app)  
  - [Capturas de Pantalla](#screenshots)  
  - [Características](#features)  
  - [Tecnologías](#technologies)  
  - [Configuración](#setup)  
  - [Aspectos Técnicos](#technical-insights)  
    - [Tecnología del Mapa](#map-technology)  
    - [Búsqueda de Rutas](#pathfinding)  
    - [Tecnología Central del Mapa](#core-map-technology)  
    - [Dibujo de Rutas y Navegación](#path-drawing-and-wayfinding)  
    - [Personalización del Mapa](#customizing-the-map)  
  - [Créditos](#credits)  
  - [Licencia](#license)

## Sobre la Aplicación

Este proyecto es una variación de mi proyecto de diploma, centrado en un mapa interactivo para la navegación interior. Cuenta con un mapa SVG interactivo y utiliza el algoritmo de Dijkstra para calcular la ruta más corta hacia puntos de interés (POIs). Originalmente, la aplicación experimentó con posicionamiento interior usando tecnología BLE, pero debido a la naturaleza experimental de la API Web Bluetooth, ha sido omitida en esta variación.

> [!WARNING]  
> El backend de este proyecto ha sido eliminado. Todos los datos se almacenan en un archivo JSON. Este proyecto es un prototipo y no debe usarse para fines de producción. Por favor, consulta mi nuevo proyecto [OpenIndoorMaps](https://github.com/yourusername/OpenIndoorMaps) para una solución más completa.

## Capturas de Pantalla

<table style="border-radius: 10px;  border: 1px solid gray;">  
  <tr >  
    <td align="center"><img src="https://raw.githubusercontent.com/KnotzerIO/indoor-wayfinder/main/media/indoor-map-details.png"/></td>
   <td align="center"><h3 >Mostrar Información del Objeto al Hacer Clic</h3></td>
  </tr>
    <tr>
    <td align="center"><img src="https://raw.githubusercontent.com/KnotzerIO/indoor-wayfinder/main/media/indoor-wayfinding.png"/></td>
    <td align="center"><h3>Demostración del Cálculo de la Ruta Más Corta</h3></td>
  </tr>
</table>

## Características

- **Mapas SVG Interactivos**: Navega con facilidad por espacios interiores complejos.
- **Búsqueda de Ruta con Dijkstra**: Calcula la ruta más corta a tu destino.
- **Diseño Responsivo**: Optimizado para cualquier dispositivo y tamaño de pantalla.
- **POIs Personalizables**: Edita nombres y categorías de puntos de interés.
- **Zoom con Pellizco**: Acércate y aléjate fácilmente en los mapas con gestos táctiles.

## Tecnologías

Pathpal está construido con las últimas tecnologías web para velocidad, eficiencia y adaptabilidad:

- React
- Vite
- TypeScript
- TailwindCSS
- SVG
- Algoritmo de Dijkstra

## Configuración

Sigue estos pasos para poner el proyecto en marcha:

1. **Clona el Repositorio**: Usa tu cliente Git preferido para clonar este repositorio en tu máquina local.

2. **Instala Node.js**: Este proyecto requiere Node.js. Si no tienes instalada la versión 21 de Node.js, puedes descargarla e instalarla desde [nodejs.org](https://nodejs.org/).

3. **Instala las Dependencias**: Navega al directorio del proyecto en tu terminal y ejecuta el siguiente comando para instalar las dependencias necesarias:

   ```bash
   npm install
   ```

4. **Iniciar la Aplicación**: Una vez que las dependencias estén instaladas, puedes iniciar la aplicación ejecutando el siguiente comando en tu terminal:

   ```bash
   npm run dev
   ```
Después de ejecutar estos comandos, su navegador web predeterminado debería abrirse automáticamente y navegar a `localhost:5173`, donde podrá ver la aplicación en ejecución.

## Perspectivas Técnicas

### Tecnología del Mapa

- **Formato SVG**: El mapa es principalmente SVG por su flexibilidad y capacidades interactivas, ideal para una navegación detallada.
- **Soporte de Formatos de Imagen**: Soporta varios formatos como PNG y JPEG para fondos de mapa, con funciones interactivas mejor adaptadas para SVG.

### Búsqueda de Rutas

- **Definición de Rutas**: Los caminos dentro del mapa representan rutas navegables, esenciales para que el algoritmo de Dijkstra calcule rutas eficientes.
- **Algoritmo de Dijkstra**: Garantiza una navegación precisa y rápida entre los Puntos de Interés.

### Tecnología Principal del Mapa

- **SVG como Formato Predeterminado**: La aplicación utiliza principalmente un archivo SVG (Gráficos Vectoriales Escalables) para el mapa debido a su escalabilidad y facilidad de manipulación. Los SVG permiten una representación interactiva y dinámica de espacios interiores, haciéndolos ideales para rutas de navegación detalladas.
- **Soporte para Varios Formatos de Imagen**: Aunque SVG es el predeterminado, el sistema está diseñado para acomodar cualquier formato de imagen (p. ej., PNG, JPEG) como fondo del mapa. Esta flexibilidad asegura que los desarrolladores puedan usar planos o mapas existentes sin necesidad de convertirlos a SVG. Sin embargo, las funciones interactivas y de navegación principales están optimizadas para SVG.

### Dibujo de Rutas y Orientación

- **Dibujo de Rutas**: Para que la navegación funcione, las rutas deben estar definidas dentro del mapa. Estas rutas representan caminos transitables y son cruciales para el algoritmo de orientación. En archivos SVG, las rutas pueden dibujarse y editarse directamente, permitiendo un control preciso sobre las rutas de navegación.
- **Algoritmo de Orientación**: La aplicación utiliza el algoritmo de Dijkstra para calcular la ruta más corta entre puntos de interés (POIs) en el mapa. Este algoritmo opera sobre la red de rutas dibujadas en el mapa, asegurando una navegación eficiente y precisa.

### Personalización del Mapa

- **Herramientas de Edición**: Los desarrolladores tienen la opción de utilizar herramientas de edición de gráficos vectoriales como Adobe Illustrator o Boxy SVG para modificar el mapa SVG. Esta modificación puede involucrar la actualización de diseños, añadir o eliminar Puntos de Interés (POIs) y ajustar rutas. Consulte la captura de pantalla a continuación para ver un ejemplo de edición de mapa usando Boxy SVG. Para convertir SVG a JSX, [Transform Tools](https://transform.tools/) puede ser un recurso útil.

![Ejemplo de Edición de IndoorMap](https://raw.githubusercontent.com/KnotzerIO/indoor-wayfinder/main/media/map-editing-preview.png)

## Créditos

Este proyecto fue inspirado por mi trabajo de diploma y significativamente influenciado por el apoyo de mentores, compañeros y recursos como la [app de pathfinding de maciejb2k](https://github.com/maciejb2k/pathfinding_app).

## Licencia

Pathpal es un proyecto de código abierto bajo la Licencia MIT. ¡Se agradecen contribuciones y comentarios!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-15

---
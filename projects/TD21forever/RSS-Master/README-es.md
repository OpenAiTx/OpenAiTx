# RSS-Master

Personalización de filtrado y selección para fuentes RSS, utilizando AI para resumir, sintetizar y puntuar. Versión optimizada en rendimiento, que soporta procesamiento asíncrono y resúmenes AI en paralelo.

### Prefacio

A principios de septiembre, comencé a usar Inoreader + RSSHub para agregar y suscribirme a fuentes RSS que me interesan, junto con Reeder para leer, intentando controlar completamente la fuente de información diaria. Después de un mes, el aumento gradual de fuentes RSS y la creciente cantidad de información no leída me generaron ansiedad al leer, por lo que pensé si habría una manera de personalizar algunas reglas de filtrado, preferiblemente con AI para ayudarme a leer y reducir mi carga de lectura.

Inoreader trae filtros incorporados, pero pagar solo por esta función parecía poco rentable; NewsBlur tiene un "Intelligence Trainer" para clasificación inteligente, pero lo probé brevemente y no sentí un feedback notable, no se notaba inteligencia en corto plazo; Feedly tiene tanto filtrado como funciones AI, lo que parecía satisfacer mis necesidades. Justo cuando dudaba si cambiar de usuario de pago de Inoreader a Feedly, vi estos dos proyectos:

- [Dejar que ChatGPT nos ayude a resumir Hacker News](https://blog.betacat.io/post/2023/06/summarize-hacker-news-by-chatgpt/)
- [Guía de uso de RSS-GPT](http://yinan.me/rss-gpt-manual-zh.html)

La idea general de ambos proyectos es ejecutar un script mediante GitAction, obtener información, usar la API de OpenAI para traducir y resumir, luego renderizar en una plantilla y desplegar en GitHub Pages. El método de RSS-GPT satisface mejor mis necesidades, ejecutando periódicamente el script para obtener el archivo XML RSS, procesarlo y desplegar el XML en GitHub Pages, para luego obtener el enlace de acceso a este archivo XML y hacer que el lector simplemente se suscriba a este enlace.

Tengo una fuerte necesidad de sincronización multi-dispositivo con Inoreader, y para las fuentes RSS añadidas en el archivo de configuración, necesito notificar a Inoreader para sincronización inmediata. Por eso, en base a la idea de [RSS-GPT](https://github.com/yinan-c/) hice una extensión llamada RSS-Master.

### Características

- **Soporte para procesamiento en paralelo**: uso de asincronía y threadpool para procesamiento paralelo de fuentes RSS y resúmenes AI, mejorando notablemente la velocidad
- **Mecanismo de caché mejorado**: sistema de caché más estable para evitar pérdida de datos y mejorar el rendimiento en accesos repetidos
- **Manejo de errores mejorado**: todas las operaciones incluyen manejo completo de errores y registro de logs para mayor estabilidad
- **Extracción optimizada de contenido HTML**: extracción inteligente del contenido del artículo, ignorando información irrelevante para mejorar la calidad del resumen AI
- **Soporte para la última API de OpenAI**: total compatibilidad con la versión más reciente de la API OpenAI
- **Estadísticas detalladas**: al finalizar, se proveen estadísticas de tiempo de ejecución, tasa de éxito y costos
- **Generación de archivos opml**: así como conversión mutua con config.yml mediante `script/convert_opml_to_yaml.sh` y `script/convert_yaml_to_opml.sh`
- **Soporte para reglas de filtrado personalizadas**: incluye tipos include y exclude, con ámbitos de título y artículo
- **Modelo AI configurable**: permite configurar el modelo OpenAI mediante variables de entorno
- **URL base configurable**: permite definir la URL base para acceder a archivos RSS, facilitando el despliegue en distintos entornos
- **Notebook interactivo para pruebas**: se provee un notebook Jupyter para probar funcionalidades

### Configuración de variables de entorno

El proyecto soporta configurar los siguientes parámetros mediante un archivo `.env`:

```
# Parámetros obligatorios
OPENAI_API_KEY=tu_clave_openai_aquí

# Parámetros opcionales
RSS_BASE_URL=https://raw.githubusercontent.com/TD21forever/RSS-Master/main/rss-feeds/  # URL base RSS
OPENAI_MODEL=gpt-4o-mini-2024-07-18          # Modelo OpenAI
LOG_LEVEL=INFO                               # Nivel de logging
PARALLEL_WORKERS=5                           # Cantidad de procesos paralelos
```

Puedes copiar el archivo `.env.example`, renombrarlo a `.env` y modificar los valores según corresponda.

### Mejoras de rendimiento

Esta versión presenta las siguientes mejoras respecto a la versión original:

1. **Procesamiento paralelo de fuentes RSS**: uso de `asyncio` para manejar múltiples fuentes simultáneamente
2. **Resumen AI paralelo**: uso de threadpool para procesar resúmenes AI de múltiples artículos concurrentemente
3. **Optimización en procesamiento de texto**: mejor algoritmo para extraer contenido HTML, enfocándose más inteligentemente en el contenido clave
4. **Manejo seguro de archivos**: mecanismo seguro para escritura de archivos, evitando pérdida de datos por caídas del programa
5. **Optimización en uso de memoria**: mejoras en estructuras de datos y flujo para reducir consumo de memoria

### Instrucciones de uso

1. Clona el proyecto localmente
2. Instala dependencias: `pip install -r requirements.txt`
3. Crea el archivo `.env` y configura la clave API de OpenAI: `OPENAI_API_KEY=tu_clave`
4. Modifica `resource/config.yml` para configurar tus fuentes RSS
5. Ejecuta `python main.py` para iniciar el procesamiento

### Pruebas y depuración

El proyecto incluye un notebook interactivo `test.ipynb` para probar funcionalidades:

1. Obtención y análisis de fuentes RSS
2. Funcionalidad de filtros
3. Función de resumen AI
4. Mecanismo de caché
5. Configuración de URL base personalizada
6. Pruebas de rendimiento

Uso:

```bash
# Instalar Jupyter
pip install jupyter

# Abrir notebook
jupyter notebook test.ipynb
```

### Ejemplo de reglas de filtrado personalizadas

```yaml
- htmlUrl: http://www.smzdm.com
  name: c5738f
  text: 什么值得买 | 优惠精选
  url: http://feed.smzdm.com
  filters:
    - type: include
      field: title
      keywords:
        [
          '可乐',
          '雪碧',
          '芬达',
          '柠檬',
          '茶叶',
          '纸巾',
          '酒精',
          '湿纸巾',
          '餐巾纸',
        ]
```

### Capturas de pantalla de uso

- Función de resumen y síntesis AI

<div style="display: flex;">
    <img src="https://raw.githubusercontent.com/TD21forever/RSS-Master/main/typora/202310031757486.png" alt="image-20231003174334231" style="width: 45%;">
    <img src="https://raw.githubusercontent.com/TD21forever/RSS-Master/main/typora/202310031757686.png" alt="image-20231003175143405" style="width: 45%;">
</div>

- Filtrado personalizado: filtrar el canal de buenas ofertas de "什么值得买", recomendando solo productos recientes que quiero almacenar, como refrescos

<img src="https://raw.githubusercontent.com/TD21forever/RSS-Master/main/typora/%E4%BB%80%E4%B9%88%E5%80%BC%E5%BE%97%E4%B9%B0-%E6%B1%BD%E6%B0%B4.png" alt="image-20231003164248923" style="width: 400px; height: 400px;" />

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---
# 👋 Resumen
![Simple Columns](https://drive.google.com/uc?export=view&id=1Q4Vrx3FpE14U_6RtGkmfQg9UnsNJKx-j)

- [👋 Resumen](#-resumen)
  - [📝 Descripción](#-descripción)
  - [⚙️ Cómo Usar](#️-cómo-usar)
    - [Ejemplo: Creando Columnas con Bloques de Código](#ejemplo-creando-columnas-con-bloques-de-código)
    - [Ejemplo: Especificando Anchos de Columna vía YAML](#ejemplo-especificando-anchos-de-columna-vía-yaml)
  - [✨ Características](#-características)
  - [🔧 Configuraciones Globales](#-configuraciones-globales)
    - [Bordes del Contenedor](#bordes-del-contenedor)
    - [Configuración del Redimensionador](#configuración-del-redimensionador)
    - [Configuraciones Avanzadas](#configuraciones-avanzadas)
  - [⚡️ Configuraciones Locales](#️-configuraciones-locales)
    - [Configuraciones Locales Disponibles:](#configuraciones-locales-disponibles)
  - [🚀 Trabajos Futuros](#-trabajos-futuros)


## 📝 Descripción
El plugin **Simple Columns** para Obsidian te permite crear columnas fácilmente redimensionables y personalizables en tus notas. Ya sea que estés organizando tareas, desglosando contenido o visualizando ideas, este plugin proporciona una sintaxis markdown simple para ajustar y estructurar rápidamente tus diseños.

## ⚙️ Cómo Usar 
Para crear un diseño simple de columnas, puedes:
- Hacer clic derecho en tu nota y seleccionar la opción del submenú.

![Submenú](https://drive.google.com/uc?export=view&id=1Nu2tmvENJFtsnbDIqnk4XqT05WSJexN_)

- Usar la paleta de comandos para insertar columnas directamente. Por ejemplo, escribe "Agregar 2 columnas" para insertar un diseño de dos columnas en tu nota.

Cuando creas columnas, el plugin genera el siguiente markdown con un ID único para cada columna:

```columns
id: b52707b0-ce15-6458-825d-32615b4b7h85
===
Column 1

===
Column 2
```

### Ejemplo: Crear columnas con bloques de código
Para crear un diseño con bloques de código dentro de columnas, use la siguiente sintaxis (comience y termine con 4 acentos graves: ````):

````columns

id: b52707b0-ce15-6458-825d-32615b4b7h85
===
Columna 1
```javascript
console.log("Hello world")
```
===
Columna 2
````
`````

### Ejemplo: Especificar anchos de columna mediante YAML

Puedes establecer anchos personalizados para columnas específicas usando YAML. Las columnas con una proporción especificada tendrán prioridad, y las columnas sin una proporción definida compartirán el espacio restante por igual.

```
id: b52707b0-ce15-6458-825d-32615b4b7h85
column-1-ratio: 60%
===
Column 1
hello
===
Column 2
```

Explicación:  
- column-1-ratio: 60% → La columna 1 ocupa el 60% del ancho del contenedor.  
- La columna 2 (no especificada) llena automáticamente el 40% restante.  
- Puedes definir proporciones para múltiples columnas (column-2-ratio, column-3-ratio, etc.), hasta 4 columnas.  

## ✨ Características  
- **IDs Únicos para Columnas**: Cada columna se genera con un ID único, asegurando que puedas estilizar o referenciar columnas de forma independiente.  
- **Columnas Fácilmente Redimensionables**: Las columnas son completamente redimensionables, dándote control total sobre la disposición de tu contenido.  
- **Diseños Responsivos**: Las columnas se ajustan automáticamente según el tamaño de tu pantalla, proporcionando un diseño limpio y adaptable.  
- **Altamente Personalizables**: Las columnas son completamente ajustables, permitiéndote controlar fácilmente su tamaño, espaciado y alineación según tus necesidades.  

## 🔧 Configuraciones Globales  

Las **Configuraciones Globales** te permiten definir estilos y comportamientos predeterminados para todas las columnas en tu bóveda de Obsidian. Estas configuraciones pueden ser accedidas y configuradas en los ajustes del plugin.  

![Configuraciones Globales](https://drive.google.com/uc?export=view&id=1WPBg0Y3pffL5pw1dVRUC81TMMlaod-eK)  

### Bordes del Contenedor  
Puedes personalizar la apariencia de los contenedores de columna con bordes para mejor visibilidad.  

- **Mostrar Bordes del Contenedor**: Activa esta opción para mostrar bordes alrededor de cada contenedor de columna.  
- **Ancho del Borde**: Establece el ancho de los bordes del contenedor de columna.  
- **Color del Borde**: Elige el color de los bordes.  
- **Transparencia del Borde**: Ajusta la transparencia de los bordes usando códigos de color RGBA. El valor alfa (último número) controla la transparencia.  

### Configuraciones del Redimensionador  
También puedes personalizar la apariencia y el comportamiento del redimensionador de columnas.  

- **Mostrar Redimensionador**: Activa esta opción para mostrar u ocultar el redimensionador entre columnas. El redimensionador solo aparecerá al pasar el cursor sobre el divisor de columnas.  
- **Ancho del Redimensionador**: Establece el ancho del elemento redimensionador.  
- **Color del Redimensionador**: Elige el color del redimensionador.  
- **Transparencia del Redimensionador**: Ajusta la transparencia del redimensionador usando códigos de color RGBA.  

### Configuraciones Avanzadas  
- **Restablecer Estilos**: Esto revertirá todos los estilos de columnas, incluyendo configuraciones de bordes y estilos del redimensionador, a sus valores predeterminados.  
- **Borrar Almacenamiento Local**: Esto eliminará todas las configuraciones personalizadas y restaurará el plugin a su estado inicial. Usa esta opción si tienes problemas o quieres empezar desde cero.  


## ⚡️ Configuraciones Locales
Las **Configuraciones Locales** te permiten aplicar **personalizaciones más detalladas** a columnas individuales dentro de tus notas.

![Configuraciones Locales](https://drive.google.com/uc?export=view&id=1q11NA49CeizEAozavC1YAiiSI7J7oe5U)

### Configuraciones Locales Disponibles:
- **Restablecer Todos los Estilos**: Revertir todos los estilos personalizados de la columna a sus ajustes predeterminados.
- **Mostrar Borde**
- **Establecer Color y Transparencia del Borde**
- **Mostrar Redimensionador**: Alternar la visualización del redimensionador de la columna. El redimensionador aparecerá solo al pasar el cursor.
- **Establecer Color y Transparencia del Redimensionador**
- **Establecer Color del Texto**
- **Establecer Color y Transparencia de Fondo**
- **Establecer Alineación del Texto**: Alinear el texto dentro de la columna (por ejemplo, `izquierda`, `centro`, `derecha`).

## 📦 Instalación
¡Este complemento ya está disponible en los Complementos de la Comunidad de Obsidian! 🎉

1. En Obsidian, ve a Configuración > Complementos de la Comunidad.
2. Haz clic en Explorar y busca Simple Columns.
3. Haz clic en Instalar, luego Activa el complemento.

## 🚀 Trabajos Futuros
1. Agregar imagen de fondo a columnas individuales
2. Habilitar columnas anidadas


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-24

---
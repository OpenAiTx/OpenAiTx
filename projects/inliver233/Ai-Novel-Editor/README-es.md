# Editor de Novelas con IA

Editor de novelas asistido por IA basado en PyQt6, que ofrece herramientas profesionales de escritura como autocompletado inteligente, gestión de proyectos y organización de conceptos.

## Instalación

1. Clonar el proyecto
```bash
git clone https://github.com/inliver233/Ai-Novel-Editor.git
cd ai-novel-editor
```

2. Crear un entorno virtual
```bash
python -m venv venv
venv\Scripts\activate     # Windows
```

3. Instalar dependencias
```bash
pip install -r requirements.txt
```
4. Ejecutar el programa
```bash
python src/main.py
```

## Funcionalidades principales

### Gestión de proyectos
- Estructura jerárquica de documentos (Obra > Capítulo > Escena)
- Importación y exportación de proyectos (compatible con formatos TEXT, MARKDOWN, DOCX, PDF, HTML)
- Copias de seguridad automáticas y control de versiones
- Gestión de múltiples proyectos

### Función de autocompletado por IA
- Tres modos de autocompletado: autocompletado automático, autocompletado manual (recomendado: presiona una vez Tab para activar y otra vez Tab para aplicar el autocompletado), desactivar autocompletado
- Tres modos de contexto:
  - Modo rápido: contexto ligero, respuesta rápida
  - Modo equilibrado: contexto medio, equilibrio entre calidad y velocidad
  - Modo global: contexto completo del proyecto, mejor resultado
- Compatible con varios servicios de IA: OpenAI, Claude, Tongyi Qianwen, Zhipu AI, DeepSeek, Groq, entre otros
### Gestión de esquema
- Estructura de árbol de esquema visualizable
- Ordenamiento por arrastrar y ajustar niveles
- Navegación rápida del documento
- Análisis del esquema y sugerencias de optimización

### Configuración de API
- Centro unificado de configuración de IA
- Configuraciones preestablecidas de múltiples proveedores
- Función de prueba de conexión
- Guardar, importar y exportar esquemas de configuración

### Configuración de autocompletado inteligente
- Retraso de activación ajustable
- Límite de longitud de autocompletado
- Configuración de longitud de contexto
- Soporte de respuesta en streaming

### Edición de prompts
- Múltiples plantillas de redacción integradas
- Plantillas de prompts personalizadas
- Gestión de categorías de plantillas
- Configuración de plantillas específicas por modo
### Funciones de la interfaz
- Tema claro y oscuro
- Diseño de tres columnas (árbol de proyectos, editor, panel de conceptos)
- Barra lateral plegable
- Modo de escritura a pantalla completa
- Modo de concentración (oración, párrafo, máquina de escribir, modo zen, modo inmersivo)

### Búsqueda y reemplazo
- Búsqueda de texto en todo el proyecto
- Soporte para expresiones regulares
- Función de reemplazo por lotes
- Opciones de búsqueda avanzada

### Gestión de conceptos
- Detección automática de personajes, lugares y objetos
- Gestión de relaciones entre conceptos
- Sistema de etiquetas y clasificación
- Inserción rápida de conceptos

## Atajos de teclado
- `Ctrl+N`: Nuevo proyecto
- `Ctrl+O`: Abrir proyecto
- `Ctrl+S`: Guardar documento
- `F11`: Modo de pantalla completa
- `Tab`: Activar autocompletado AI manualmente (en modo manual)
- `Ctrl+F`: Buscar
- `Ctrl+H`: Buscar y reemplazar
- `Ctrl+Shift+H`: Búsqueda y reemplazo avanzado


## Requisitos del sistema

- Python 3.8+
- PyQt6
- Sistema operativo: Windows, macOS, Linux

## Autor

**inliver**
- Correo electrónico: inliverapi@outlook.com  
- GitHub: https://github.com/inliver233

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---
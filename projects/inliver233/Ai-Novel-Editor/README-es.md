<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

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
Usar uv
```bash
uv venv -p 3.11
```
3. Instalar dependencias
```bash
pip install -r requirements.txt
```
Usando uv
```bash
uv sync
```

4. Ejecutar el programa
```bash
python -m src
```

## Funciones principales

### Gestión de proyectos
- Estructura jerárquica de documentos (Obra > Capítulo > Escena)
- Importación y exportación de proyectos (soporta formatos TEXT, MARKDOWN, DOCX, PDF, HTML)
- Copias de seguridad automáticas y control de versiones
- Gestión de múltiples proyectos
### Función de Autocompletado AI
- Tres modos de autocompletado: autocompletado automático, autocompletado manual (recomendado: presione Tab una vez para activar, presione Tab otra vez para aplicar el autocompletado), desactivar autocompletado
- Tres modos de contexto:
  - Modo rápido: contexto ligero, respuesta rápida
  - Modo equilibrado: contexto medio, equilibrio entre calidad y velocidad
  - Modo global: contexto completo del proyecto, mejor efecto
- Soporta múltiples servicios de IA: OpenAI, Claude, Tongyi Qianwen, Zhipu AI, DeepSeek, Groq, etc.

### Gestión de Esquema
- Estructura de árbol de esquema visualizable
- Arrastrar y soltar para ordenar y ajustar niveles
- Navegación rápida de documentos
- Análisis del esquema y sugerencias de optimización

### Configuración de API
- Centro unificado de configuración de IA
- Configuraciones preestablecidas para múltiples proveedores de servicios
- Función de prueba de conexión
- Guardar, importar y exportar esquemas de configuración
### Configuración de autocompletado inteligente
- Retardo de activación ajustable
- Límite de longitud de autocompletado
- Configuración de longitud de contexto
- Soporte para respuesta en streaming

### Edición de prompts
- Múltiples plantillas de escritura integradas
- Plantillas de prompts personalizadas
- Gestión de categorías de plantillas
- Configuración de plantillas específicas por modo

### Funciones de la interfaz
- Doble tema claro/oscuro
- Diseño de tres columnas (árbol de proyectos, editor, panel de conceptos)
- Barra lateral colapsable
- Modo de escritura a pantalla completa
- Modo de concentración (oración, párrafo, máquina de escribir, modo zen, modo inmersivo)

### Buscar y reemplazar
- Búsqueda de texto en todo el proyecto
- Soporte para expresiones regulares
- Función de reemplazo por lotes
- Opciones de búsqueda avanzadas

### Gestión de conceptos
- Detección automática de roles, lugares, objetos
- Gestión de relaciones de conceptos
- Sistema de etiquetas y clasificación
- Inserción rápida de conceptos

## Atajos de teclado

- `Ctrl+N`: Nuevo proyecto
- `Ctrl+O`: Abrir proyecto
- `Ctrl+S`: Guardar documento
- `F11`: Modo de pantalla completa
- `Tab`: Activar manualmente la autocompletación por IA (en modo manual)
- `Ctrl+F`: Buscar
- `Ctrl+H`: Buscar y reemplazar
- `Ctrl+Shift+H`: Búsqueda y reemplazo avanzados
## Requisitos del sistema

- Python 3.8+
- PyQt6
- Sistema operativo: Windows, macOS, Linux

## Autor

**inliver**
- Correo electrónico: inliverapi@outlook.com  
- GitHub: https://github.com/inliver233

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---
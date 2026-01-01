
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
- Importación y exportación de proyectos (compatible con TEXT, MARKDOWN, DOCX, PDF, HTML)
- Copias de seguridad automáticas y control de versiones
- Gestión de múltiples proyectos

### Función de autocompletado AI
- Tres modos de autocompletado: autocompletado automático, autocompletado manual (recomendado: presionar Tab una vez para activar, presionar Tab de nuevo para aplicar el autocompletado), desactivar autocompletado
- Tres modos de contexto:
  - Modo rápido: contexto ligero, respuesta rápida
  - Modo equilibrado: contexto medio, balance entre calidad y velocidad
  - Modo global: contexto completo del proyecto, mejor resultado
- Soporte para múltiples servicios de IA: OpenAI, Claude, Tongyi Qianwen, Zhipu AI, DeepSeek, Groq, entre otros

### Gestión de esquema
- Árbol de esquema visualizable
- Ordenamiento y ajuste de niveles mediante arrastrar y soltar
- Navegación rápida de documentos
- Análisis de esquema y sugerencias de optimización

### Configuración de API
- Centro de configuración unificado para IA
- Configuraciones preestablecidas para varios proveedores
- Función de prueba de conexión
- Guardado e importación/exportación de esquemas de configuración

### Ajustes de autocompletado inteligente
- Retardo de activación ajustable
- Límite de longitud de autocompletado
- Configuración de longitud de contexto
- Soporte de respuesta por streaming

### Edición de prompts
- Múltiples plantillas de escritura integradas
- Plantillas de prompts personalizables
- Gestión de clasificación de plantillas
- Configuración de plantillas específicas por modo

### Funcionalidad de la interfaz
- Doble tema claro/oscuro
- Diseño de tres columnas (árbol de proyectos, editor, panel de conceptos)
- Barra lateral plegable
- Modo de escritura a pantalla completa
- Modo de concentración (frase, párrafo, máquina de escribir, modo zen, modo inmersivo)

### Búsqueda y reemplazo
- Búsqueda de texto en todo el proyecto
- Soporte para expresiones regulares
- Función de reemplazo por lotes
- Opciones de búsqueda avanzadas

### Gestión de conceptos
- Detección automática de personajes, lugares, objetos
- Gestión de relaciones de conceptos
- Sistema de etiquetas y categorías
- Inserción rápida de conceptos

## Atajos de teclado

- `Ctrl+N`: Nuevo proyecto
- `Ctrl+O`: Abrir proyecto
- `Ctrl+S`: Guardar documento
- `F11`: Modo pantalla completa
- `Tab`: Activar autocompletado AI manualmente (en modo manual)
- `Ctrl+F`: Buscar
- `Ctrl+H`: Buscar y reemplazar
- `Ctrl+Shift+H`: Búsqueda y reemplazo avanzada


## Requisitos del sistema

- Python 3.8+
- PyQt6
- Sistemas operativos: Windows, macOS, Linux

## Autor

**inliver**
- Correo electrónico: inliverapi@outlook.com  
- GitHub: https://github.com/inliver233

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-01

---
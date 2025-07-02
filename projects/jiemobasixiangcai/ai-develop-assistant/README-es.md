# 🚀 MCP AI Asistente de Desarrollo

> Herramienta MCP para ayudar a los desarrolladores de IA en el análisis inteligente de requerimientos y diseño de arquitectura

## ✨ Características principales

- **Aclaración inteligente de requerimientos**: Identificación automática del tipo de proyecto y generación de preguntas específicas
- **Gestión con conciencia de ramas**: Seguimiento de objetivos del proyecto, diseño de funciones, preferencias técnicas, diseño de UI, etc.
- **Generación automática de arquitectura**: Generación de esquemas de arquitectura técnica a partir de requerimientos completos
- **Almacenamiento persistente**: Guardado automático de resultados de análisis, compatible con exportación de documentos

## 📁 Configuración rápida

### Configuración de versión antigua
1. **Clonar el código**
   ```bash
   git clone https://github.com/jiemobasixiangcai/ai-develop-assistant.git
   ```
2. **Recomendado: entorno virtual**
   ```bash
   python -m venv venv
   source venv/bin/activate  # Unix/Linux/MacOS
   venv\Scripts\activate  # Windows
   ```
3. **Instalar dependencias**
   ```bash
   pip install -r requirements.txt
   ```

4. **Ubicación del archivo de configuración**
   ```
   Windows: %APPDATA%\Claude\claude_desktop_config.json
   macOS: ~/Library/Application Support/Claude/claude_desktop_config.json
   ```

5. **Agregar configuración**
   ```json
   {
     "mcpServers": {
       "ai-develop-assistant": {
         "command": "python",
         "args": ["path/to/AIDevlopStudy.py"],
         "env": {
           "MCP_STORAGE_DIR": "./mcp_data"
         }
       }
     }
   }
   ```

3. **Reiniciar Claude Desktop**

### Configuración de nueva versión
#### 🔧 Herramientas principales
1. **start_new_project** - Iniciar un nuevo proyecto
2. **create_requirement_blueprint** - Crear un plano de requerimientos
3. **requirement_clarifier** - Obtener sugerencias para aclarar requerimientos
4. **save_clarification_tasks** - Guardar tareas de aclaración
5. **update_branch_status** - Actualizar estado de la rama
6. **requirement_manager** - Gestor de documentos de requerimientos
7. **check_architecture_prerequisites** - Comprobar los prerrequisitos de arquitectura
8. **get_architecture_design_prompt** - Obtener sugerencias de diseño de arquitectura
9. **save_generated_architecture** - Guardar el diseño de arquitectura generado
10. **export_final_document** - Exportar el documento completo
11. **view_requirements_status** - Ver el estado de los requerimientos

#### Configuración (copia directa remota a tu herramienta, reemplaza MCP_STORAGE_DIR por tu directorio local)
   ```json
   {
     "mcpServers": {
       "ai-develop-assistant": {
         "command": "uvx",
         "args": ["ai-develop-assistant@latest"],
         "env": {
           "MCP_STORAGE_DIR": "/path/to/your/storage"
         }
       }
     }
   }
   ```

## 🎯 Flujo de uso

### Pasos básicos

1. **Aclaración de requerimientos**
   ```
   requirement_clarifier("Quiero hacer una plataforma de educación en línea")
   ```

2. **Gestión de requerimientos**
   ```
   requirement_manager("Usuarios objetivo: estudiantes y profesores", "Resumen del proyecto")
   ```

3. **Ver estado**
   ```
   view_requirements_status()
   ```

4. **Diseño de Arquitectura**
   ```
   architecture_designer("Arquitectura de la plataforma de educación en línea")
   ```

5. **Exportar Documento**
   ```
   export_final_document()
   ```

## 🚀 Comenzar a Usar

### Guía Rápida
1. **Configura Claude Desktop** (consulta el método de configuración anterior)
2. **Reinicia Claude Desktop**
3. **Inicia el análisis inteligente de requerimientos**:
   ```
   requirement_clarifier("Describe tu idea de proyecto")
   ```
4. **Sigue la guía inteligente de la IA** para completar cada rama de requerimientos
5. **Exporta el documento completo**:
   ```
   export_final_document()
   ```

### Mejores Prácticas
- 💬 **Confía en la gestión de ramas de la IA**: deja que la IA te guíe para completar todas las ramas de requerimientos
- 🎯 **Expresa tus preferencias claramente**: expresa claramente tus preferencias sobre selección tecnológica, estilo de UI, etc.
- 📊 **Revisa el estado periódicamente**: usa `view_requirements_status` para conocer el progreso
- 🤖 **Autoriza adecuadamente a la IA**: para las partes inciertas puedes decir "usa el enfoque convencional"

---

**🎯 ¡Ahora tienes un verdadero asistente de desarrollo inteligente con IA, que recordará cada detalle y te guiará en el análisis completo de requerimientos!**

## 💬 Grupo de Intercambio

<div align="center">
<img src="https://raw.githubusercontent.com/jiemobasixiangcai/ai-develop-assistant/main/./assets/qr-code.jpg" width="200" alt="Grupo de Intercambio">
<br>
Grupo de Intercambio
</div>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---
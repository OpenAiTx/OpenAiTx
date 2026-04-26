## Motor Orca

Discord: https://discord.gg/bvdpdT26Tq

Basado en Godot Engine, con mejoras por Simplifine.


### ¿Cuál es la trampa?
Estamos integrando un chatbot, con acceso completo a Godot.  
El chatbot puede:  
  - Leer/editar/crear/eliminar archivos  
  - entender todo el proyecto como contexto  
  - crear imágenes y mantener la consistencia entre imágenes creadas  
  - editar objetos nativos de Godot, p.ej. nodos, escenas, ...

### Capacidades del Asistente de IA

El chatbot integrado tiene acceso a herramientas completas para el desarrollo en Godot:

#### Gestión de Escenas y Nodos
- **Operaciones con Escenas**: Abrir, crear, guardar e instanciar escenas  
- **Manipulación de Nodos**: Crear, eliminar, mover y renombrar nodos en el árbol de la escena  
- **Inspección de Nodos**: Obtener propiedades, scripts e información jerárquica de nodos  
- **Selección de Nodos**: Trabajar con nodos seleccionados actualmente en el editor  
- **Descubrimiento de Clases**: Acceder a todas las clases de nodos disponibles en Godot y sus capacidades  

#### Gestión de Scripts y Código
- **Operaciones con Archivos**: Leer, escribir y editar cualquier archivo del proyecto con enfoque en líneas específicas  
- **Generación de Scripts**: Crear nuevos archivos GDScript con generación de código potenciada por IA  
- **Edición de Código**: Aplicar ediciones inteligentes a scripts existentes mediante indicaciones en lenguaje natural  
- **Detección de Errores**: Verificar errores de compilación en archivos individuales o en todo el proyecto  
- **Adjuntar Scripts**: Adjuntar y gestionar scripts en nodos  

#### Navegación y Búsqueda en el Proyecto
- **Sistema de Archivos**: Explorar directorios y archivos del proyecto con opciones de filtrado  
- **Búsqueda Semántica Avanzada**: Encontrar archivos y código relevantes usando consultas en lenguaje natural con **inteligencia a nivel de función**  
- **Rastreo de Dependencias Multi-Salto**: Entender cadenas completas de llamadas a funciones y flujos de señales en el proyecto  
- **Análisis de Grafos**: Descubrir archivos conectados, componentes centrales del proyecto y relaciones arquitectónicas  
- **Modos de Búsqueda Inteligentes**: Semántico (entendimiento IA), por palabra clave (texto exacto) o híbrido (combinado)  

> 🔍 **[Ver documentación avanzada de indexación](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/backend/indexing.md)** para detalles técnicos sobre segmentación a nivel de función, seguimiento del flujo de señales y análisis de dependencias

#### Creación de Contenido Visual
- **Generación de Imágenes**: Crear nuevas imágenes a partir de descripciones de texto con varios estilos artísticos
- **Edición de Imágenes**: Modificar imágenes existentes usando edición potenciada por IA
- **Generación de Modelos 3D**: Generar modelos 3D a partir de indicaciones de texto o imágenes (cuando esté configurado)
- **Gestión de Activos**: Guardar imágenes generadas en rutas específicas del proyecto
- **Consistencia de Estilo**: Mantener coherencia visual en los activos generados

#### Física y Objetos del Juego
- **Formas de Colisión**: Añadir detección de colisiones a cuerpos físicos (rectángulo, círculo, cápsula)
- **Propiedades del Nodo**: Modificar transformaciones, física y propiedades de juego
- **Llamadas a Métodos**: Ejecutar métodos de nodos con parámetros personalizados

#### Sistema de Señales y Conexiones
- **Inspección de Señales**: Listar señales disponibles y sus conexiones
- **Gestión de Conexiones**: Crear y administrar conexiones de señales entre nodos
- **Rastreo de Señales**: Depurar el flujo de señales con seguimiento ligero de eventos
- **Validación de Conexiones**: Verificar la integridad de conexiones de señales

#### Flujo de Trabajo en Desarrollo
- **Soporte Multi-Modelo**: Elegir entre GPT-5, Claude-4, Gemini-2.5 y GPT-4o
- **Asistencia en Tiempo Real**: Transmitir respuestas con retroalimentación de ejecución de herramientas
- **Recuperación de Errores**: Recurso inteligente entre proveedores de IA para mayor fiabilidad
- **Autenticación**: Acceso seguro con OAuth (Google, GitHub, Microsoft) o modo invitado

### Sistema Avanzado de Indexación

Orca Engine cuenta con un **sistema de indexación Godot de primera clase** que comprende tu código a nivel de **función**:

- **🎯 Inteligencia a Nivel de Función**: Cada función GDScript, señal y exportación se convierte en una unidad buscable con metadatos ricos
- **🔗 Seguimiento del Flujo de Señales**: Comprensión completa de la emisión de señales → conexión → cadenas de manejadores en todo tu proyecto  
- **🕸️ Rastreo de Dependencias Multi-Salto**: Rastrear cadenas de llamadas a funciones (p. ej., Entrada → Controlador → Física → Animación)
- **📊 Análisis de Centralidad de Grafos**: Identificar archivos arquitectónicamente importantes y sus roles estructurales
- **🔍 Modos de Búsqueda Inteligente**: Semántica (entendimiento IA), palabra clave (texto exacto) o híbrido (combinado)

**Rendimiento**: ~2.7 veces más fragmentos inteligentes que la indexación tradicional basada en líneas, permitiendo una comprensión precisa de mecánicas de juego complejas.

> 📚 **[Análisis Técnico Profundo: Indexación Avanzada](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/backend/indexing.md)** | **[Guía de Configuración Backend](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/backend/README.md)**

### Inicio Rápido (Solo Editor)

Compila y ejecuta el editor. Las funciones de IA se conectan a nuestro backend en la nube por defecto. No se requiere configuración de backend local.

macOS:
```bash
git clone https://github.com/Simplifine-gamedev/orca-engine.git
cd orca-engine
brew install scons pkg-config python3 git
scons platform=macos target=editor dev_build=yes vulkan=no -j"$(sysctl -n hw.ncpu)"
./bin/godot.macos.editor.dev.arm64
```

Windows (PowerShell):
```powershell
git clone https://github.com/Simplifine-gamedev/orca-engine.git
cd orca-engine
# If needed: scoop install python scons git   (or: choco install python scons git)
scons platform=windows target=editor dev_build=yes vulkan=no -j $env:NUMBER_OF_PROCESSORS
.\bin\godot.windows.editor.dev.x86_64.exe
```

Linux (Ubuntu/Debian):
```bash
git clone https://github.com/Simplifine-gamedev/orca-engine.git
cd orca-engine
sudo apt update
sudo apt install -y build-essential scons pkg-config libx11-dev libxcursor-dev libxinerama-dev \
  libgl1-mesa-dev libglu1-mesa-dev libasound2-dev libpulse-dev libudev-dev libxi-dev libxrandr-dev \
  python3 python3-pip git
scons platform=linuxbsd target=editor dev_build=yes vulkan=no -j"$(nproc)"
./bin/godot.linuxbsd.editor.dev.x86_64
```
Notas:
- No se requiere Vulkan SDK. El editor utiliza el renderizador predeterminado de la plataforma (Metal en macOS, D3D12 en Windows, GLES3 en Linux). Vulkan es opcional y no es necesario para construir o ejecutar el editor.
- Para apuntar el editor a un backend autoalojado en lugar de la nube, consulte la sección de backend a continuación.

### Backend (Despliegue Local / en la Nube Opcional)

- Para desarrollo local o autoalojamiento, siga la **[Guía de Configuración del Backend](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/backend/README.md)**. Cubre variables de entorno, ejecución local y despliegue en Google Cloud Run vía `backend/deploy.sh`.
- Para detalles avanzados de indexación (fragmentos a nivel de función, gráficos de dependencia), consulte **[backend/indexing.md](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/backend/indexing.md)**.

#### Configuración del Entorno

Cree un archivo `.env` en el directorio `backend/` con sus claves API:


```env
# Required: AI provider for embeddings and chat
OPENAI_API_KEY=YOUR_OPENAI_API_KEY
# ANTHROPIC_API_KEY=YOUR_ANTHROPIC_API_KEY
# GOOGLE_API_KEY=YOUR_GOOGLE_API_KEY

# Required: For advanced vector search and function-level indexing
WEAVIATE_URL=https://YOUR-WEAVIATE-ENDPOINT
WEAVIATE_API_KEY=YOUR_WEAVIATE_API_KEY

# Optional: Additional configuration
FLASK_SECRET_KEY=YOUR_RANDOM_SECRET_KEY

# Development mode (set to 'false' in production)
DEV_MODE=true
```

> ⚙️ **[Ver Guía de Configuración del Backend](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/backend/README.md)** para documentación completa de variables de entorno e instrucciones de despliegue

#### Rendimiento de indexación (proyectos grandes)

El editor activa la indexación del lado del servidor automáticamente. Para bases de código grandes, configure estos para acelerar el proceso (en `backend/.env` localmente o antes de ejecutar `backend/deploy.sh` para que Cloud Run los tome como secretos):

```env
# Parallelism and batching
INDEX_MAX_WORKERS=32         # number of parallel file workers on the backend
EMBED_MAX_PARALLEL=12        # concurrent embedding batches (respect provider limits)
EMBED_BATCH_SIZE=256         # embeddings per batch
CHUNK_MAX_LINES=100          # larger chunks = fewer embedding calls

# Small response caches
SEARCH_CACHE_TTL=45
GRAPH_CACHE_TTL=45
```
Notas:  
- También puedes pasar `INDEX_MAX_WORKERS` desde el editor vía env; se reenvía al backend para `index_project`/`index_files`.  
- Al desplegar en Cloud Run, asegúrate de contar con recursos suficientes (por ejemplo, `--cpu 4`, `--memory 8Gi`, `--concurrency` más alto).  

### Búsqueda en Documentación de Godot (RAG)  

Consulta **[Búsqueda en Documentación de Godot: Indexación y Consulta](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/./godot_doc_search.md)**.  

#### Solución de Problemas  

**Problemas con el Editor y la Compilación:**  
- **Errores de compilación**: Consulta la [documentación oficial de compilación de Godot](https://docs.godotengine.org/en/stable/development/compiling/index.html) para problemas específicos de plataforma  
- **Problemas con dependencias de Python**: Asegúrate de usar Python 3.8+ y considera usar un entorno virtual  
- **Herramientas faltantes**: Las herramientas del chatbot solo aparecerán una vez que la conexión con el backend esté establecida  

**Problemas con el Backend de IA:**  
- **Problemas de conexión**: Verifica que el backend esté corriendo en http://localhost:8000 y que las claves API estén configuradas correctamente  
- **La búsqueda no funciona**: Revisa la conexión con Weaviate (WEAVIATE_URL y WEAVIATE_API_KEY en .env)  
- **Problemas de indexación**: Consulta los registros de extracción de funciones y seguimiento de dependencias  

> 🔧 **[Solución detallada de problemas del backend](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/backend/README.md#troubleshooting)** para búsqueda vectorial, indexación y configuración de API  

### Licencia  
- Código original de Godot Engine: Expat (MIT). Ver `LICENSE.txt`.  
- Componentes de terceros: ver `COPYRIGHT.txt` y licencias bajo `thirdparty/`.  
- Contribuciones originales de Simplifine: Código fuente disponible no comercial. Ver `NOTICE` y `LICENSES/COMPANY-NONCOMMERCIAL.md`.  

Licencias comerciales disponibles. Contacto: [support@simplifine.com]  

### Atribución  
Este proyecto se basa en Godot Engine por los contribuyentes de Godot Engine, Juan Linietsky y Ariel Manzur. No estamos afiliados con el proyecto Godot.  

### Marca  
Este proyecto es una distribución independiente de Simplifine. “Godot” y marcas relacionadas son propiedad de sus respectivos dueños.  





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-26

---
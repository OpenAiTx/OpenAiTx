![Gitcontainer](https://raw.githubusercontent.com/cyclotruc/gitcontainer/main/docs/image.png)

# Gitcontainer 🐳

**Convierte cualquier repositorio de GitHub en un contenedor Docker listo para producción con generación de Dockerfile potenciada por IA.**

[![Licencia MIT](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)
[![Python 3.9+](https://img.shields.io/badge/python-3.9+-blue.svg)](https://www.python.org/downloads/)
[![FastAPI](https://img.shields.io/badge/FastAPI-0.68+-00a393.svg)](https://fastapi.tiangolo.com/)

Gitcontainer es una aplicación web potenciada por IA que genera automáticamente Dockerfiles listos para producción analizando repositorios de GitHub. Simplemente pega una URL de GitHub y obtén un Dockerfile personalizado con selección inteligente de imagen base, gestión de dependencias y buenas prácticas de Docker.

## 🌟 Acceso Rápido

Simplemente reemplaza `github.com` por `gitcontainer.com` en cualquier URL de repositorio de GitHub para acceder instantáneamente a la página de generación de Dockerfile para ese repositorio.

Por ejemplo:
```
https://github.com/username/repo  →  https://gitcontainer.com/username/repo
```

## ✨ Características

- **🔄 Acceso Instantáneo vía URL**: Solo reemplaza 'github.com' por 'gitcontainer.com' en cualquier URL de GitHub
- **🤖 Análisis con IA**: Utiliza OpenAI GPT-4 para analizar la estructura del repositorio y generar Dockerfiles inteligentes
- **⚡ Transmisión en Tiempo Real**: Observa cómo la IA genera tu Dockerfile en tiempo real mediante streaming WebSocket
- **🎯 Detección Inteligente**: Detecta automáticamente stacks tecnológicos (Python, Node.js, Java, Go, etc.)
- **🔧 Listo para Producción**: Genera Dockerfiles siguiendo buenas prácticas con seguridad adecuada, builds multi-stage y optimización
- **📋 Instrucciones Adicionales**: Agrega requisitos personalizados para entornos especializados
- **📄 Docker Compose**: Sugiere automáticamente docker-compose.yml para aplicaciones complejas
- **🎨 Interfaz Moderna**: Interfaz limpia y responsiva con editor Monaco para resaltado de sintaxis
- **📱 Amigable para Móviles**: Funciona perfectamente en escritorio y dispositivos móviles

## 🚀 Inicio Rápido

### Prerrequisitos

- Python 3.9 o superior
- Git
- Clave de API de OpenAI

### Instalación

1. **Clona el repositorio:**
   ```bash
   git clone https://github.com/cyclotruc/gitcontainer.git
   cd gitcontainer
   ```

2. **Instala las dependencias:**
   ```bash
   pip install -r requirements.txt
   ```

3. **Configura las variables de entorno:**
   ```bash
   # Crea el archivo .env
   echo "OPENAI_API_KEY=tu_clave_de_api_openai_aquí" > .env
   ```

4. **Ejecuta la aplicación:**
   ```bash
   python app.py
   ```

5. **Abre tu navegador:**
   Navega a `http://localhost:8000`

## 🛠️ ¿Cómo Funciona?

1. **Procesamiento de URL**: Accede a cualquier repositorio reemplazando 'github.com' por 'gitcontainer.com' en la URL
2. **Clonado del Repositorio**: Gitcontainer clona el repositorio de GitHub localmente usando Git
3. **Análisis de Código**: Usa [gitingest](https://github.com/cyclotruc/gitingest) para analizar la estructura del repositorio y extraer información relevante
4. **Generación con IA**: Envía el análisis a OpenAI GPT-4 con prompts especializados para la generación del Dockerfile
5. **Optimización Inteligente**: La IA tiene en cuenta:
   - Detección de stack tecnológico
   - Gestión de dependencias
   - Buenas prácticas de seguridad
   - Builds multi-stage cuando sea beneficioso
   - Configuración de puertos
   - Variables de entorno
   - Health checks

## 📁 Estructura del Proyecto

```
cyclotruc-gitcontainer/
├── app.py                 # Aplicación principal FastAPI
├── requirements.txt       # Dependencias de Python
├── .env                  # Variables de entorno (créalo)
├── static/               # Recursos estáticos (iconos, CSS)
├── templates/
│   └── index.jinja       # Plantilla HTML principal
└── tools/                # Módulos de funcionalidad principal
    ├── __init__.py
    ├── create_container.py  # Generación de Dockerfile con IA
    ├── git_operations.py    # Clonado de repositorios de GitHub
    └── gitingest.py        # Análisis de repositorio
```
## 🔧 Configuración

### Variables de Entorno

| Variable | Descripción | Requerido |
|----------|-------------|-----------|
| `OPENAI_API_KEY` | Tu clave API de OpenAI | Sí |
| `PORT` | Puerto del servidor (por defecto: 8000) | No |
| `HOST` | Host del servidor (por defecto: 0.0.0.0) | No |

### Uso Avanzado

Puedes usar las herramientas de forma programática:

```python
from tools import clone_repo_tool, gitingest_tool, create_container_tool
import asyncio

async def generate_dockerfile(github_url):
    # Clonar repositorio
    clone_result = await clone_repo_tool(github_url)
    
    # Analizar con gitingest
    analysis = await gitingest_tool(clone_result['local_path'])
    
    # Generar Dockerfile
    dockerfile = await create_container_tool(
        gitingest_summary=analysis['summary'],
        gitingest_tree=analysis['tree'],
        gitingest_content=analysis['content']
    )
    
    return dockerfile

# Uso
result = asyncio.run(generate_dockerfile("https://github.com/user/repo"))
print(result['dockerfile'])
```

## 🎨 Personalización

### Añadir Instrucciones Personalizadas

Utiliza la función "Instrucciones adicionales" para personalizar la generación:

- `"Usar Alpine Linux para un tamaño de imagen más pequeño"`
- `"Incluir Redis y PostgreSQL"`
- `"Optimizar para despliegue en producción"`
- `"Agregar herramientas de desarrollo para depuración"`

## 📝 Licencia

Este proyecto está licenciado bajo la Licencia MIT - consulta el archivo [LICENSE](LICENSE) para más detalles.

## 🙏 Agradecimientos

- **[OpenAI](https://openai.com/)** por proveer la API de GPT-4
- **[gitingest](https://github.com/cyclotruc/gitingest)** por las capacidades de análisis de repositorios
- **[FastAPI](https://fastapi.tiangolo.com/)** por el excelente framework web
- **[Monaco Editor](https://microsoft.github.io/monaco-editor/)** por el resaltado de sintaxis de código

## 🔗 Enlaces

- **Repositorio GitHub**: [https://github.com/cyclotruc/gitcontainer](https://github.com/cyclotruc/gitcontainer)
- **Demostración**: Pruébalo en vivo con repositorios de ejemplo
- **Incidencias**: [Reporta errores o solicita funciones](https://github.com/cyclotruc/gitcontainer/issues)

---

**Hecho con ❤️ por [Romain Courtois](https://github.com/cyclotruc)**

*¡Convierte cualquier repositorio en un contenedor en segundos!*

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---
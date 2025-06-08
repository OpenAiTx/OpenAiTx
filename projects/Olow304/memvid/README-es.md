# Memvid - Memoria de IA Basada en Video 🧠📹

**La solución ligera y revolucionaria para memoria de IA a gran escala**

[![PyPI version](https://badge.fury.io/py/memvid.svg)](https://pypi.org/project/memvid/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Python 3.8+](https://img.shields.io/badge/python-3.8+-blue.svg)](https://www.python.org/downloads/)
[![Code style: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)

Memvid revoluciona la gestión de memoria de IA codificando datos de texto en videos, permitiendo una **búsqueda semántica ultrarrápida** en millones de fragmentos de texto con **tiempos de recuperación de menos de un segundo**. A diferencia de las bases de datos vectoriales tradicionales que consumen enormes cantidades de RAM y almacenamiento, Memvid comprime tu base de conocimiento en archivos de video compactos mientras mantiene el acceso instantáneo a cualquier pieza de información.

## 🎥 Demo

https://github.com/user-attachments/assets/ec550e93-e9c4-459f-a8a1-46e122b5851e



## ✨ Características principales

- 🎥 **Video como Base de Datos**: Almacena millones de fragmentos de texto en un solo archivo MP4
- 🔍 **Búsqueda Semántica**: Encuentra contenido relevante usando consultas en lenguaje natural
- 💬 **Chat Integrado**: Interfaz conversacional con respuestas contextuales
- 📚 **Soporte de PDF**: Importación e indexación directa de documentos PDF
- 🚀 **Recuperación Rápida**: Búsqueda en menos de un segundo en grandes conjuntos de datos
- 💾 **Almacenamiento Eficiente**: Compresión 10x comparado con bases de datos tradicionales
- 🔌 **LLMs Enchufables**: Funciona con OpenAI, Anthropic o modelos locales
- 🌐 **Offline-First**: No requiere internet después de la generación del video
- 🔧 **API Simple**: Comienza con solo 3 líneas de código

## 🎯 Casos de Uso

- **📖 Bibliotecas Digitales**: Indexa miles de libros en un solo archivo de video
- **🎓 Contenido Educativo**: Crea memorias de video buscables de materiales de cursos
- **📰 Archivos de Noticias**: Comprime años de artículos en bases de datos de video manejables
- **💼 Conocimiento Corporativo**: Construye bases de conocimiento buscables a nivel empresa
- **🔬 Artículos Científicos**: Búsqueda semántica rápida en literatura científica
- **📝 Notas Personales**: Transforma tus notas en un asistente de IA buscable

## 🚀 ¿Por qué Memvid?

### Innovación Revolucionaria
- **Video como Base de Datos**: Almacena millones de fragmentos de texto en un solo archivo MP4
- **Recuperación Instantánea**: Búsqueda semántica en menos de un segundo en grandes conjuntos de datos
- **Eficiencia de Almacenamiento 10x**: La compresión en video reduce drásticamente el uso de memoria
- **Cero Infraestructura**: Sin servidores de base de datos, solo archivos que puedes copiar a cualquier lugar
- **Offline-First**: Funciona completamente offline una vez generados los videos

### Arquitectura Ligera
- **Dependencias Mínimas**: Funcionalidad principal en ~1000 líneas de Python
- **Amigable con CPU**: Se ejecuta eficientemente sin requerir GPU
- **Portátil**: Un solo archivo de video contiene toda tu base de conocimiento
- **Streameable**: Los videos pueden transmitirse desde almacenamiento en la nube

## 📦 Instalación

### Instalación Rápida
```bash
pip install memvid
```

### Para Soporte de PDF
```bash
pip install memvid PyPDF2
```

### Configuración Recomendada (Entorno Virtual)
```bash
# Crea un nuevo directorio de proyecto
mkdir mi-proyecto-memvid
cd mi-proyecto-memvid

# Crea un entorno virtual
python -m venv venv

# Actívalo
# En macOS/Linux:
source venv/bin/activate
# En Windows:
venv\Scripts\activate

# Instala memvid
pip install memvid

# Para soporte de PDF:
pip install PyPDF2
```

## 🎯 Inicio Rápido

### Uso Básico
```python
from memvid import MemvidEncoder, MemvidChat

# Crea memoria de video a partir de fragmentos de texto
chunks = ["Hecho importante 1", "Hecho importante 2", "Detalles de un evento histórico"]
encoder = MemvidEncoder()
encoder.add_chunks(chunks)
encoder.build_video("memory.mp4", "memory_index.json")

# Chatea con tu memoria
chat = MemvidChat("memory.mp4", "memory_index.json")
chat.start_session()
response = chat.chat("¿Qué sabes sobre eventos históricos?")
print(response)
```

### Construyendo Memoria desde Documentos
```python
from memvid import MemvidEncoder
import os

# Cargar documentos
encoder = MemvidEncoder(chunk_size=512, overlap=50)

# Agregar archivos de texto
for file in os.listdir("documents"):
    with open(f"documents/{file}", "r") as f:
        encoder.add_text(f.read(), metadata={"source": file})

# Construir video optimizado
encoder.build_video(
    "knowledge_base.mp4",
    "knowledge_index.json",
    fps=30,  # Mayor FPS = más fragmentos por segundo
    frame_size=512  # Cuadros más grandes = más datos por cuadro
)
```

### Búsqueda y Recuperación Avanzada
```python
from memvid import MemvidRetriever

# Inicializar recuperador
retriever = MemvidRetriever("knowledge_base.mp4", "knowledge_index.json")

# Búsqueda semántica
results = retriever.search("algoritmos de aprendizaje automático", top_k=5)
for chunk, score in results:
    print(f"Puntaje: {score:.3f} | {chunk[:100]}...")

# Obtener ventana de contexto
context = retriever.get_context("explica redes neuronales", max_tokens=2000)
print(context)
```

### Interfaz de Chat Interactiva
```python
from memvid import MemvidInteractive

# Lanzar interfaz de chat interactiva
interactive = MemvidInteractive("knowledge_base.mp4", "knowledge_index.json")
interactive.run()  # Abre la interfaz web en http://localhost:7860
```

### Pruebas con file_chat.py
El script `examples/file_chat.py` proporciona una manera integral de probar Memvid con tus propios documentos:

```bash
# Procesar un directorio de documentos
python examples/file_chat.py --input-dir /ruta/a/documentos --provider google

# Procesar archivos específicos
python examples/file_chat.py --files doc1.txt doc2.pdf --provider openai

# Usar compresión H.265 (requiere Docker)
python examples/file_chat.py --input-dir docs/ --codec h265 --provider google

# Fragmentación personalizada para documentos grandes
python examples/file_chat.py --files large.pdf --chunk-size 2048 --overlap 32 --provider google

# Cargar memoria existente
python examples/file_chat.py --load-existing output/my_memory --provider google
```

### Ejemplo Completo: Chatea con un Libro PDF
```bash
# 1. Crea un nuevo directorio y configura el entorno
mkdir book-chat-demo
cd book-chat-demo
python -m venv venv
source venv/bin/activate  # En Windows: venv\Scripts\activate

# 2. Instala las dependencias
pip install memvid PyPDF2

# 3. Crea book_chat.py
cat > book_chat.py << 'EOF'
from memvid import MemvidEncoder, chat_with_memory
import os

# Tu archivo PDF
book_pdf = "book.pdf"  # Reemplázalo con la ruta a tu PDF

# Construye la memoria de video
encoder = MemvidEncoder()
encoder.add_pdf(book_pdf)
encoder.build_video("book_memory.mp4", "book_index.json")

# Chatea con el libro
api_key = os.getenv("OPENAI_API_KEY")  # Opcional: para respuestas de IA
```python
chat_with_memory("book_memory.mp4", "book_index.json", api_key=api_key)
EOF

# 4. Ejecútalo
export OPENAI_API_KEY="tu-api-key"  # Opcional
python book_chat.py
```

## 🛠️ Configuración Avanzada

### Embeddings Personalizados
```python
from sentence_transformers import SentenceTransformer

# Usar modelo de embedding personalizado
custom_model = SentenceTransformer('sentence-transformers/all-mpnet-base-v2')
encoder = MemvidEncoder(embedding_model=custom_model)
```

### Optimización de Video
```python
# Para máxima compresión
encoder.build_video(
    "compressed.mp4",
    "index.json",
    fps=60,  # Más cuadros por segundo
    frame_size=256,  # Cuadros más pequeños
    video_codec='h265',  # Mejor compresión
    crf=28  # Calidad de compresión (menor = mejor calidad)
)
```

### Procesamiento Distribuido
```python
# Procesa grandes conjuntos de datos en paralelo
encoder = MemvidEncoder(n_workers=8)
encoder.add_chunks_parallel(massive_chunk_list)
```

## 🐛 Solución de Problemas

### Problemas Comunes

**ModuleNotFoundError: No module named 'memvid'**
```bash
# Asegúrate de estar usando el Python correcto
which python  # Debe mostrar la ruta de tu entorno virtual
# Si no, activa tu entorno virtual:
source venv/bin/activate  # En Windows: venv\Scripts\activate
```

**ImportError: PyPDF2 is required for PDF support**
```bash
pip install PyPDF2
```

**Problemas con la clave API de LLM**
```bash
# Establece tu clave API (obtenla en https://platform.openai.com)
export GOOGLE_API_KEY="AIzaSyB1-..."  # macOS/Linux
# O en Windows:
set GOOGLE_API_KEY=AIzaSyB1-...
```

**Procesamiento de PDF grande**
```python
# Para PDFs muy grandes, usa tamaños de fragmento más pequeños
encoder = MemvidEncoder()
encoder.add_pdf("large_book.pdf", chunk_size=400, overlap=50)
```

## 🤝 Contribuir

¡Agradecemos las contribuciones! Consulta nuestra [Guía de Contribución](https://raw.githubusercontent.com/Olow304/memvid/main/CONTRIBUTING.md) para más detalles.

```bash
# Ejecutar pruebas
pytest tests/

# Ejecutar con cobertura
pytest --cov=memvid tests/

# Formatear código
black memvid/
```

## 🆚 Comparación con Soluciones Tradicionales

| Funcionalidad        | Memvid | BDs Vectoriales | BDs Tradicionales |
|----------------------|--------|-----------------|-------------------|
| Eficiencia de Almacenamiento | ⭐⭐⭐⭐⭐ | ⭐⭐ | ⭐⭐⭐ |
| Complejidad de Configuración | Simple | Complejo | Complejo |
| Búsqueda Semántica         | ✅ | ✅ | ❌ |
| Uso sin Conexión           | ✅ | ❌ | ✅ |
| Portabilidad               | Basado en archivos | Basado en servidor | Basado en servidor |
| Escalabilidad              | Millones | Millones | Billones |
| Costo                      | Gratis | $$$$ | $$$ |


## 📚 Ejemplos

Consulta el directorio [examples/](https://raw.githubusercontent.com/Olow304/memvid/main/examples/) para:
- Construir memoria desde volcados de Wikipedia
- Crear una base de conocimientos personal
- Soporte multilingüe
- Actualizaciones de memoria en tiempo real
- Integración con LLMs populares

## 🆘 Obtener Ayuda

- 📖 [Documentación](https://github.com/olow304/memvid/wiki) - Guías completas
- 💬 [Discusiones](https://github.com/olow304/memvid/discussions) - Haz preguntas
- 🐛 [Rastreador de Errores](https://github.com/olow304/memvid/issues) - Reporta errores
- 🌟 [Show & Tell](https://github.com/olow304/memvid/discussions/categories/show-and-tell) - Comparte tus proyectos

## 🔗 Enlaces

- [Repositorio en GitHub](https://github.com/olow304/memvid)
- [Paquete PyPI](https://pypi.org/project/memvid)
- [Changelog](https://github.com/olow304/memvid/releases)


## 📄 Licencia

Licencia MIT - ver el archivo [LICENSE](https://raw.githubusercontent.com/Olow304/memvid/main/LICENSE) para más detalles.

## 🙏 Agradecimientos

Creado por [Olow304](https://github.com/olow304) y la comunidad de Memvid.

Construido con ❤️ usando:
- [sentence-transformers](https://www.sbert.net/) - Embeddings de última generación para búsqueda semántica
- [OpenCV](https://opencv.org/) - Visión computacional y procesamiento de video
- [qrcode](https://github.com/lincolnloop/python-qrcode) - Generación de códigos QR
- [FAISS](https://github.com/facebookresearch/faiss) - Búsqueda eficiente de similitud
- [PyPDF2](https://github.com/py-pdf/pypdf) - Extracción de texto de PDF

¡Un agradecimiento especial a todos los colaboradores que ayudan a mejorar Memvid!

---

**¿Listo para revolucionar la gestión de memoria de tu IA? ¡Instala Memvid y comienza a construir!** 🚀
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---
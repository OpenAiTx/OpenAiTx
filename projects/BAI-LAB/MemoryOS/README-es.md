# MemoryOS
<div align="center">
  <img src="https://raw.githubusercontent.com/BAI-LAB/MemoryOS/main/logo_1.png" alt="logo" width="400"/>
</div>
<p align="center">
  <a href="https://arxiv.org/abs/2506.06326">
    <img src="https://img.shields.io/badge/Arxiv-paper-red" alt="Mem0 Discord">
  </a>
  <a href="https://github.com/user-attachments/assets/d195e740-1249-4eb1-962a-2c0d99a38c39">
    <img src="https://img.shields.io/badge/Wechat-群二维码-green" alt="Mem0 PyPI - Downloads">
  </a>
  <a href="https://youtu.be/y9Igs0FnX_M" target="blank">
    <img src="https://img.shields.io/badge/Demo-Video-red" alt="Npm package">
  </a>
    <a href="https://www.apache.org/licenses/LICENSE-2.0" target="_blank">
    <img src="https://img.shields.io/badge/License-Apache_2.0-blue" alt="License: Apache 2.0">
  </a>
</p>

<h5 align="center"> 🎉 Si te gusta nuestro proyecto, por favor danos una estrella ⭐ en GitHub para estar al tanto de las últimas actualizaciones.</h5>
**MemoryOS** está diseñado para proporcionar un sistema operativo de memoria para agentes de IA personalizados, permitiendo interacciones más coherentes, personalizadas y conscientes del contexto. Inspirado en los principios de gestión de memoria en los sistemas operativos, adopta una arquitectura de almacenamiento jerárquica con cuatro módulos principales: Almacenamiento, Actualización, Recuperación y Generación, para lograr una gestión de memoria integral y eficiente. En el benchmark LoCoMo, el modelo alcanzó mejoras promedio de **49,11%** y **46,18%** en las puntuaciones F1 y BLEU-1.







## 📣 Últimas Noticias
*   *<mark>[nuevo]</mark>* 🔥  **[2025-06-15]**:🛠️ ¡Lanzamiento de **MemoryOS-MCP** de código abierto! Ahora configurable en clientes de agente para integración y personalización sin problemas. [👉 Ver](#memoryos_mcp-getting-started)
*   **[2025-05-30]**: ¡Versión inicial de **MemoryOS** lanzada! Incluye memoria de persona a corto, medio y largo plazo con actualización automática de perfil y conocimientos del usuario.

## Demostración
[![Ver el video](https://img.youtube.com/vi/y9Igs0FnX_M/maxresdefault.jpg)](https://youtu.be/y9Igs0FnX_M)

## 	Arquitectura del Sistema
![image](https://github.com/user-attachments/assets/09200494-03a9-4b7d-9ffa-ef646d9d51f0)

## Estructura del Proyecto

```
memoryos/
├── __init__.py            # Inicializa el paquete MemoryOS
├── __pycache__/           # Directorio de caché de Python (autogenerado)
├── long_term.py           # Gestiona la memoria de persona a largo plazo (perfil del usuario, conocimientos)
├── memoryos.py            # Clase principal de MemoryOS, orquesta todos los componentes
├── mid_term.py            # Gestiona la memoria a medio plazo, consolidando interacciones de corto plazo
├── prompts.py             # Contiene prompts usados para interacciones con LLM (p.ej., resumen, análisis)
├── retriever.py           # Recupera información relevante de todas las capas de memoria
├── short_term.py          # Gestiona la memoria a corto plazo para interacciones recientes
├── updater.py             # Procesa las actualizaciones de memoria, incluyendo la promoción entre capas
└── utils.py               # Funciones utilitarias usadas en toda la biblioteca
```

## Cómo Funciona

1.  **Inicialización:** `Memoryos` se inicializa con IDs de usuario y asistente, claves API, rutas de almacenamiento de datos y varias configuraciones de capacidad/umbral. Configura un almacenamiento dedicado para cada usuario y asistente.
2.  **Añadiendo Memorias:** Las entradas del usuario y las respuestas del agente se agregan como pares de preguntas y respuestas. Estas se almacenan inicialmente en la memoria a corto plazo.
3.  **Procesamiento de Corto a Medio Plazo:** Cuando la memoria a corto plazo está llena, el módulo `Updater` procesa estas interacciones, consolidándolas en segmentos significativos y almacenándolos en la memoria a medio plazo.
4.  **Análisis de Medio Plazo y Actualizaciones LPM:** Los segmentos de memoria a medio plazo acumulan "calor" basado en factores como la frecuencia de visita y la duración de la interacción. Cuando el calor de un segmento supera un umbral, su contenido es analizado:
    *   Se extraen conocimientos del perfil del usuario y se usan para actualizar el perfil a largo plazo.
    *   Se añaden hechos específicos del usuario al conocimiento a largo plazo del usuario.
    *   La información relevante para el asistente se añade a la base de conocimientos de largo plazo del asistente.
5.  **Generación de Respuestas:** Cuando se recibe una consulta del usuario:
    *   El módulo `Retriever` obtiene el contexto relevante del historial a corto plazo, segmentos de memoria a medio plazo, el perfil y conocimientos del usuario, y la base de conocimientos del asistente.
    *   Este contexto integral se utiliza, junto con la consulta del usuario, para generar una respuesta coherente e informada mediante un LLM.

## MemoryOS_PYPI Primeros Pasos

### Prerrequisitos

*   Python >= 3.10
*   pip install -i https://pypi.org/simple/ MemoryOS-BaiJia

### Instalación

```bash
conda create -n MemoryOS python=3.10
conda activate MemoryOS
pip install -i https://pypi.org/simple/ MemoryOS-BaiJia
```

### Uso Básico

```python

import os
from memoryos import Memoryos

# --- Configuración Básica ---
USER_ID = "demo_user"
ASSISTANT_ID = "demo_assistant"
API_KEY = "TU_OPENAI_API_KEY"  # Reemplaza con tu clave
BASE_URL = ""  # Opcional: si usas un endpoint personalizado de OpenAI
DATA_STORAGE_PATH = "./simple_demo_data"
LLM_MODEL = "gpt-4o-mini"

def simple_demo():
    print("Demostración Simple de MemoryOS")
    
    # 1. Inicializar MemoryOS
    print("Inicializando MemoryOS...")
    try:
        memo = Memoryos(
            user_id=USER_ID,
            openai_api_key=API_KEY,
            openai_base_url=BASE_URL,
            data_storage_path=DATA_STORAGE_PATH,
            llm_model=LLM_MODEL,
            assistant_id=ASSISTANT_ID,
            short_term_capacity=7,  
            mid_term_heat_threshold=5,  
            retrieval_queue_capacity=7,
            long_term_knowledge_capacity=100
        )
        print("¡MemoryOS inicializado con éxito!\n")
    except Exception as e:
        print(f"Error: {e}")
        return

    # 2. Añadir algunas memorias básicas
    print("Añadiendo algunas memorias...")
    
    memo.add_memory(
        user_input="¡Hola! Soy Tom, trabajo como científico de datos en San Francisco.",
        agent_response="¡Hola Tom! Encantado de conocerte. La ciencia de datos es un campo muy emocionante. ¿Con qué tipo de datos trabajas?"
    )
     
    test_query = "¿Qué recuerdas sobre mi trabajo?"
    print(f"Usuario: {test_query}")
    
    response = memo.get_response(
        query=test_query,
    )
    
    print(f"Asistente: {response}")

if __name__ == "__main__":
    simple_demo()
```
## Primeros Pasos con MemoryOS-MCP
### 🔧 Herramientas Principales

#### 1. `add_memory`
Guarda el contenido de la conversación entre el usuario y el asistente de IA en el sistema de memoria, con el fin de construir un historial de diálogo persistente y registro contextual.

#### 2. `retrieve_memory`
Recupera diálogos históricos relacionados, preferencias del usuario e información de conocimientos del sistema de memoria a partir de una consulta, ayudando al asistente de IA a comprender las necesidades y el contexto del usuario.

#### 3. `get_user_profile`
Obtiene un perfil de usuario generado a partir del análisis de los diálogos históricos, incluyendo rasgos de personalidad, preferencias de interés y conocimientos relevantes del usuario.


### 1. Instalar dependencias
```bash
cd memoryos-mcp
pip install -r requirements.txt
```
### 2. configuración

Edita `config.json`：
```json
{
  "user_id": "tu_ID_de_usuario",
  "openai_api_key": "tu_clave_API_de_OpenAI",
  "openai_base_url": "https://api.openai.com/v1",
  "data_storage_path": "./memoryos_data",
  "assistant_id": "assistant_id",
  "llm_model": "gpt-4o-mini"
}
```
### 3. Inicia el servidor
```bash
python server_new.py --config config.json
```
### 4. Prueba
```bash
python test_comprehensive.py
```
### 5. Configúralo en Cline y otros clientes
Copia el archivo mcp.json y asegúrate de que la ruta del archivo sea correcta.
```bash
command": "/root/miniconda3/envs/memos/bin/python"
#Esto debe cambiarse al intérprete de Python de tu entorno virtual
```
## Contribuir

¡Las contribuciones son bienvenidas! No dudes en enviar issues o pull requests.

## Cita
Si deseas leer más detalles, haz clic aquí: [Leer el artículo completo](https://arxiv.org/abs/2506.06326)

Si encuentras útil este proyecto, por favor cita nuestro artículo:

```bibtex
@misc{kang2025memoryosaiagent,
      title={Memory OS of AI Agent}, 
      author={Jiazheng Kang and Mingming Ji and Zhe Zhao and Ting Bai},
      year={2025},
      eprint={2506.06326},
## Contáctanos
百家AI es un grupo de investigación dirigido por la profesora asociada Bai Ting de la Universidad de Correos y Telecomunicaciones de Beijing, dedicado a crear cerebros llenos de emociones y con memoria extraordinaria para los humanos basados en silicio.<br>
Colaboraciones y sugerencias: baiting@bupt.edu.cn<br>
¡Bienvenidos a seguir el canal de 百家Agent en WeChat y unirse a nuestro grupo para intercambiar ideas juntos!  
<div style="display: flex; justify-content: center; gap: 20px;">
  <img src="https://github.com/user-attachments/assets/42651f49-f1f7-444d-9455-718e13ed75e9" alt="百家Agent公众号" width="250"/>
  <img src="https://github.com/user-attachments/assets/6b15a873-9e9a-44ee-b0b3-64f488fbd5d8" alt="微信群二维码" width="300"/>
</div>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---
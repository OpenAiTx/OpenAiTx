## MCP-Zero: Descubrimiento Activo de Herramientas para Agentes LLM Autónomos

<div style="display: flex; align-items: center; gap: 10px; margin-bottom: 10px;">
  <!-- <img src="https://raw.githubusercontent.com/xfey/MCP-Zero/master/assets/robot.png" alt="MCP-Zero Robot" width="24" height="24"> -->
  <a href="https://arxiv.org/abs/2506.01056">
    <img src="https://img.shields.io/badge/Paper-arXiv-red">
  </a>
  <a href="https://arxiv.org/abs/2506.01056">
    https://arxiv.org/abs/2506.01056
  </a>
</div>

¡Gracias por tu interés en MCP-Zero! 🤗

Ahora hemos liberado el código involucrado en el artículo. Continuaremos actualizando nuestro trabajo, explorando su aplicación en la industria y ampliando este proyecto.


<div align="center">
  <img src="https://raw.githubusercontent.com/xfey/MCP-Zero/master/assets/fig1.png" alt="MCP-Zero workflow">
  <p> Usando MCP-Zero para construir proactivamente cadenas de herramientas para "Hacer una gran comida"</p>
</div>


### Método: MCP-Zero

```
MCP-zero/
├── experiment_apibank.py       # experimentos: APIBank
├── experiment_mcptools.py      # experimentos: mcp_tools (needle test)
├── matcher.py                  # código para emparejamiento por similitud
├── prompt_guide/               # prompts para nuestro método
├── reformatter.py              # formateador json para la descripción de herramientas
├── sampler.py                  # muestreador para seleccionar herramienta objetivo
├── test_cases.jsonl            # casos de prueba para el matcher
├── test_matcher.py             # prueba unitaria para el matcher
└── utils.py                    # utilidades: grid_search
```

Ya hemos publicado nuestro código para el artículo. El código implementa capacidades de recuperación y logra resultados concretos en los experimentos.

En nuestro trabajo futuro, estamos comprometidos a aplicar MCP-zero en la industria, por lo que aún es necesario involucrar otros módulos, como el despliegue dinámico de servidores MCP, el despliegue de entorno para pruebas GAIA, etc. Continuaremos mejorando nuestro trabajo y gracias a todos por su atención a este proyecto. Deja una estrella🌟 para que sepa que sigues al tanto :D



### Dataset: MCP-tools

- **Google Drive**: [Enlace de descarga](https://drive.google.com/file/d/1RjBGU-AGdHdhUABoeYSztbfQlD0hjUBn/view?usp=sharing)
- **Enlace Huggingface**: Próximamente
- **Coloca el archivo en**: `./MCP-tools/mcp_tools_with_embedding.json`


**Introducción**: Un conjunto de datos que contiene todas las herramientas filtradas (308 servidores y 2,797 herramientas en total) del repositorio oficial de MCP.

**Estructura de los datos**:
```
{
  "server_name": string, // El nombre del servidor MCP, extraído o inferido del README
  "server_summary": string, // Un resumen del propósito y capacidades del servidor, basado en todas las partes relevantes del README.
  "server_description": string, // Descripción desde los metadatos.
  "description_embedding": float[3072], // El embedding de la descripción del servidor desde text-embedding-3-large
  "summary_embedding": float[3072], // El embedding del resumen del servidor desde text-embedding-3-large
  "tools": [
    {
      "name": string, // El nombre de la función/herramienta
      "description": string, // Una descripción concisa de lo que hace la herramienta
      "description_embedding": float[3072], // El embedding de la descripción de la herramienta desde text-embedding-3-large
      "parameter": { // Un diccionario de parámetros de entrada, incluidos si están definidos explícitamente
        "param1": "(type) description1",
        "param2": "(Optional, type) description2"
      }
    }
  ]
}
```

**Construir el dataset por tu cuenta**: Si deseas construir un conjunto de datos personalizado para servidores MCP, puedes seguir el código en la carpeta `MCP-tools/build_data`.

```
MCP-tools/
├── build_data
│   ├── get_server_summary.py       # código para extraer datos estructurales del archivo ReadMe del servidor MCP
│   ├── run_vllm.sh                 # desplegar el modelo Qwen2.5-72B-Instruct con VLLM
│   └── server_summary.prompt       # el prompt para extraer el conjunto de datos
└── download_data.md
```


### Cita

> Citar me hace feliz.
> 
>   --Shakespeare
>   ~~(solo por diversión :D)~~

```bibtex
@article{fei2025mcp,
  title={MCP-Zero: Active Tool Discovery for Autonomous LLM Agents},
  author={Fei, Xiang y Zheng, Xiawu y Feng, Hao},
  journal={arXiv preprint arXiv:2506.01056},
  year={2025}
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-06

---
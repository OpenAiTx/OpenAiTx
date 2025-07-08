<div align="center">
  <picture>
    <source srcset="assets/minimax-logo.png" media="(prefers-color-scheme: dark)">
      <img src="https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/assets/minimax-logo.png" width="60%" alt="MiniMax">
    </source>
  </picture>
</div>
<hr>

<div align="center" style="line-height: 1;">
<a href="https://arxiv.org/abs/2505.19641" target="_blank" style="margin: 2px;">
  <img alt="Paper" src="https://img.shields.io/badge/📖_Paper-Arxiv-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
<a href="https://huggingface.co/datasets/MiniMaxAI/SynLogic" target="_blank" style="margin: 2px;">
  <img alt="Hugging Face" src="https://img.shields.io/badge/🤗_HF-Data-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
<a href="https://huggingface.co/collections/MiniMaxAI/synlogic-6836c3246fca0277657ff032" target="_blank" style="margin: 2px;">
  <img alt="Hugging Face" src="https://img.shields.io/badge/🤗_HF-Model-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
</div>

<hr>

# SynLogic

Este repositorio contiene el código y los datos de SynLogic, un marco integral de síntesis de datos de razonamiento lógico que genera datos diversos y verificables a gran escala. Nuestro trabajo aborda la brecha crítica en datos de entrenamiento de razonamiento lógico de alta calidad para desarrollar capacidades generales de razonamiento en Grandes Modelos de Lenguaje (LLMs).

<p align="center">
  <img src="https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/assets/main.jpg" alt="Laser main figure">
</p> 

## Noticias
- **[2025/07/07]** :fire: Proporcionamos una guía para usar los datos de SynLogic en entrenamiento RL con el marco Verl. Consulta [docs/training_guidance.md](https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/docs/training_guidance.md) para más detalles. 

- **[2025/06/03]** :fire: Modelos entrenados publicados en Hugging Face:  
→ [MiniMaxAI/SynLogic Collection](https://huggingface.co/collections/MiniMaxAI/synlogic-6836c3246fca0277657ff032)  

- **[2025/05]** :fire: Nos complace lanzar los recursos para el artículo "SynLogic: Synthesizing Verifiable Reasoning Data at Scale for Learning Logical Reasoning and Beyond"

## 📋 Descripción general

**SynLogic** es un marco de síntesis de datos y un conjunto de datos integral que:
- 📊 **Cubre 35 tareas diversas de razonamiento lógico** incluyendo Sudoku, Juego del 24, Cifrado, Laberinto de Flechas y más
- 🎯 **Permite la síntesis de dificultad controlable** con parámetros ajustables para cada tarea
- ✅ **Proporciona recompensas verificables** mediante verificación basada en reglas para entrenamiento RL
- 🚀 **Alcanza un rendimiento SOTA** entre conjuntos de datos de código abierto, superando a DeepSeek-R1-Distill-Qwen-32B por 6 puntos en BBEH

### Características clave
- **Generación de datos escalable**: Síntesis ilimitada con niveles de dificultad controlables
- **Cobertura integral de tareas**: 35 tareas distintas de razonamiento lógico con generadores y verificadores personalizados
- **Listo para RL**: Todos los ejemplos pueden ser verificados por reglas simples, ideales para aprendizaje por refuerzo
- **Transferencia multidominio**: Fuerte generalización a dominios matemáticos y de codificación

## 🚀 Inicio rápido

### Instalación
```bash
git clone https://github.com/MiniMax-AI/SynLogic.git
cd SynLogic
pip install -r requirements.txt
```

### Generar datos de ejemplo (Ejemplo: Laberinto de Flechas)
```bash
# Ejemplo rápido con Laberinto de Flechas
bash games/tasks/arrow_maze/run.sh

# O con parámetros personalizados
python scripts/arrow_maze.py \
  --num_of_data 1000 \
  --width 5 \
  --height 5 \
  --arrow_fill_rate_min 0.3 \
  --arrow_fill_rate_max 0.9
```

### Para entrenamiento RL

Proporcionamos una guía completa para utilizar los datos de SynLogic en entrenamiento de aprendizaje por refuerzo. Consulta [docs/training_guidance.md](https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/docs/training_guidance.md) para instrucciones detalladas sobre la integración de SynLogic con el marco Verl.

## :rocket: Recursos

### Conjuntos de datos
| Nombre del dataset | Descripción | Enlace |
|:------------------:|:------------|:------:|
| **SynLogic** | Conjunto de datos | [🤗 HuggingFace](https://huggingface.co/datasets/MiniMaxAI/SynLogic) |



### Modelos


| Nombre del modelo | Descripción | Enlace |
|:------------------|:------------|:------:|
| **SynLogic-7B** | Modelo 7B entrenado en SynLogic | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-7B) |
| **SynLogic-32B** | Modelo 32B entrenado en SynLogic | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-32B) |
| **SynLogic-Mix-3-32B** | Modelo 32B entrenado en datos mixtos de SynLogic, Matemáticas y Código | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-Mix-3-32B) |

## 🔄 Actualizaciones futuras
Estamos trabajando activamente en la expansión de SynLogic con más tareas de razonamiento lógico.

¡Sigue nuestro repositorio para las últimas actualizaciones y lanzamientos!

## Citación
Por favor, cita nuestro artículo si consideras útil nuestro trabajo:

```bibtex
@misc{liu2025synlogic,
      title={SynLogic: Synthesizing Verifiable Reasoning Data at Scale for Learning Logical Reasoning and Beyond}, 
      author={Junteng Liu and Yuanxiang Fan and Zhuo Jiang and Han Ding and Yongyi Hu and Chi Zhang and Yiqi Shi and Shitong Weng and Aili Chen and Shiqi Chen and Yunan Huang and Mozhi Zhang and Pengyu Zhao and Junjie Yan and Junxian He},
      year={2025},
      eprint={2505.19641},
      archivePrefix={arXiv},
      primaryClass={cs.AI},
      url={https://arxiv.org/abs/2505.19641}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---
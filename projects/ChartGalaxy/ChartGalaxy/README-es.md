![ChartGalaxy Logo](https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/main/title.png)

## Conjunto de Datos
> 📦 **[👉 ¡Accede al conjunto de datos completo de ChartGalaxy en Hugging Face! 👈](https://huggingface.co/datasets/ChartGalaxy/ChartGalaxy)**

Debido a limitaciones de almacenamiento, solo incluimos una colección de ejemplos representativos.  
Este repositorio contiene el código asociado al artículo "ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation".

## 🔥 Novedades
**2025.5**:  🎉🎉 Hemos lanzado la primera versión de nuestro conjunto de datos, que incluye 1,151,087 gráficos infográficos sintéticos y 104,519 reales, cubriendo 75 tipos de gráficos y 330 variaciones.

-------------------

<img src="https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/main/teaser.png" style="border:none;box-shadow:none;">

![Examples image](https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/main/examples.png)

<!-- ## 🔔 News -->

## Introducción

### Acerca de

ChartGalaxy es un conjunto de datos a escala millonaria de gráficos infográficos sintéticos y reales con tablas de datos, que soporta aplicaciones en comprensión de gráficos infográficos, generación de código y generación de gráficos. El conjunto de datos aborda el desafío de que los conjuntos existentes están en su mayoría limitados a gráficos simples, sin captar la diversidad de estilos de diseño y disposiciones que son características clave de los gráficos infográficos.

### Estadísticas

- **Tamaño**: 1,255,606 gráficos infográficos (1,151,087 sintéticos + 104,519 reales)
- **Contenido**: Cada gráfico infográfico está emparejado con la tabla de datos utilizada para crearlo
- **Tipos de Gráficos**: 75 tipos de gráficos con 330 variaciones
- **Plantillas de Disposición**: 68 plantillas de disposición

### Recolección y Creación de Datos

ChartGalaxy fue construido a través de:

1. **Recolección de Gráficos Infográficos Reales**: Los gráficos se recopilaron de 19 sitios web reconocidos ricos en gráficos, como Pinterest, Visual Capitalist, Statista e Information is Beautiful.

2. **Creación de Gráficos Infográficos Sintéticos**: Siguiendo un proceso de estructuración inductiva que:
   - Identifica 75 tipos de gráficos (por ejemplo, gráficos de barras) y 330 variaciones que reflejan diferentes estilos de elementos visuales
   - Extrae 68 plantillas de disposición que definen las relaciones espaciales entre los elementos
   - Genera programáticamente gráficos sintéticos basados en estos patrones

## 🎯 Aplicaciones

La utilidad de ChartGalaxy se demuestra a través de tres aplicaciones representativas:

### 1. 🧠 Comprensión de Gráficos Infográficos

El ajuste fino en ChartGalaxy mejora el rendimiento de modelos fundacionales en la comprensión de gráficos infográficos.

### 2. 💻 Generación de Código para Gráficos Infográficos

Un benchmark para evaluar la generación de código de LVLMs para gráficos infográficos. El benchmark evalúa la similitud entre los gráficos renderizados por el código D3.js generado y los originales a dos niveles de granularidad: alto nivel (similitud visual general) y bajo nivel (similitud promedio entre elementos SVG detallados).

#### Descripción General

El benchmark evalúa la generación de código de gráficos en dos niveles:
- **Bajo nivel**: Similitud elemento a elemento entre SVGs generados y de referencia
- **Alto nivel**: Evaluación general de la fidelidad visual y funcionalidad

#### Instalación

```bash
git clone https://github.com/ChartGalaxy/ChartGalaxy.git
cd ChartGalaxy/code_generation_benchmark
```

#### Uso

1. Configura los parámetros en `code_generation_benchmark/configs/default_config.yaml`:
   ```yaml
   prompts:
     high_level_eval_prompt_file: eval_high_level.txt
     chat_prompt_file: chat_direct_prompt.txt

   VLM:
     max_tokens: null
     thinking_budget: 1024
     temperature: 0.0
     top_p: 1.0

   models:
     # Descomenta los modelos que deseas evaluar
     # - gpt-4o-2024-11-20
     # - claude-3-7-sonnet-20250219
     # - gemini-2.5-pro-preview-05-06
     # - Qwen/Qwen2.5-VL-72B-Instruct

   dirs:
     output_dir: ./output
     log_dir: ./logs
     data_root_dir: ./data
     clip_cache_dir: ./model-ckpts

   eval_model: gpt-4o-2024-11-20
   n_workers: 10
   ```

2. Ejecuta el benchmark:
   ```bash
   python main.py
   ```

#### Estructura de Datos

Cada carpeta de gráfico en `data_root_dir` debe contener:
- `chart.svg`: Gráfico original en formato SVG

El sistema generará:
- `convert_chart.html`: Renderizado HTML del gráfico de referencia
- `convert_chart.png`: Captura PNG del gráfico de referencia
- `convert_chart.json`: Estructura de elementos del gráfico de referencia
- Salidas específicas del modelo en subcarpetas

#### Resultados

Los resultados se guardan en subcarpetas específicas de cada modelo con:
- Renderizados HTML/PNG generados
- Métricas de evaluación en formato JSON
- Registros detallados en `log_dir`
  

### 3. 🖼️ Generación de Gráficos Infográficos Basada en Ejemplos

Un método basado en ejemplos que transforma datos tabulares proporcionados por el usuario en un gráfico infográfico, alineándose con la disposición y el estilo visual de un gráfico de ejemplo dado. Estudios con usuarios muestran que este método supera a GPT-Image-1 en fidelidad, estética y creatividad.


## Contacto
- chartgalaxy@163.com

## Enlaces del Artículo

### 📌 Artículo Principal (Este Repositorio)

- **[ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation](https://arxiv.org/abs/2505.18668)**  
  _Zhen Li, Duan Li, Yukai Guo, Xinyuan Guo, Bowen Li, Lanxi Xiao, Shenyu Qiao, Jiashu Chen, Zijian Wu, Hui Zhang, Xinhuan Shu, Shixia Liu_  

### Artículos Relevantes

- **[OrionBench: A Benchmark for Chart and Human-Recognizable Object Detection in Infographics](https://arxiv.org/abs/2505.17473)**  
  _Jiangning Zhu, Yuxing Zhou, Zheng Wang, Juntao Yao, Yima Gu, Yuhui Yuan, Shixia Liu_  

- **[InfoChartQA: A Benchmark for Multimodal Question Answering on Infographic Charts](https://arxiv.org/abs/2505.19028)**  
  _Minzhi Lin, Tianchi Xie, Mengchen Liu, Yilin Ye, Changjian Chen, Shixia Liu_  

## 📚 Citación
Si utilizas ChartGalaxy en tu investigación, por favor cita:
```
@misc{li2025chartgalaxydatasetinfographicchart,
      title={ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation}, 
      author={Zhen Li and Yukai Guo and Duan Li and Xinyuan Guo and Bowen Li and Lanxi Xiao and Shenyu Qiao and Jiashu Chen and Zijian Wu and Hui Zhang and Xinhuan Shu and Shixia Liu},
      year={2025},
      eprint={2505.18668},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2505.18668}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---
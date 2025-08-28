<div align="center">

<!-- TITLE -->
# **Los Modelos de Lenguaje por Difusión son Superaprendices de Datos**

[![Static Badge](https://img.shields.io/badge/Blog-2025--08--09-darkcyan)](https://jinjieni.notion.site/Diffusion-Language-Models-are-Super-Data-Learners-239d8f03a866800ab196e49928c019ac)
[![Twitter](https://img.shields.io/twitter/url/https/twitter.com/cloudposse.svg?style=social&label=tweet)](https://x.com/NiJinjie/status/1954177095435014533)
</div>

# Destacados
- Preentrenamos modelos DLM y AR desde cero con hasta **8 mil millones de parámetros** y **480 mil millones de tokens**. Los DLM demuestran un potencial de datos > **3x** mayor comparado con modelos autorregresivos (AR). Notablemente, un modelo de difusión enmascarada de 1B parámetros alcanza > **56%** de precisión en HellaSwag y > **33%** en MMLU usando solo **1B** tokens, sin trucos especiales, solo repitiendo datos estándar de preentrenamiento. Nótese que más repeticiones podrían mejorar aún más su rendimiento, ya que **no se observaron señales de rendimientos decrecientes**.
- Los DLM son modelos superdensos que consumen más FLOPs que los modelos AR densos. Entrenar DLM para aprovechar completamente los datos típicamente demanda al menos **dos órdenes de magnitud** más FLOPs. Durante la inferencia, generar secuencias de entre 16 y 4096 tokens implica un aumento de FLOPs de **16× a 4700×** comparado con las bases AR. Además, la atención bidireccional más expresiva habilitada por el objetivo de difusión permite **modelado bidireccional de los datos del lenguaje**, que no es totalmente causal, para exprimir completamente su valor.
- Nuestro trabajo concurrente, “Diffusion Beats Autoregressive in Data-Constrained Settings”, contiene problemas metodológicos críticos que podrían conducir a conclusiones problemáticas, incluyendo **formulación problemática de la pérdida de difusión, métricas inválidas para comparación, configuraciones injustas para modelos AR y formulación problemática de la ley de escalado.** Todo lo cual podría llevar a resultados y conclusiones cuestionables.

<br>

# El Cruce
<p align="center" width="100%">
<img src="https://raw.githubusercontent.com/JinjieNi/dlms-are-super-data-learners/main/resources/imgs/1.jpg"  width="80%" height="100%">
</p>

*Figura A del blog: Comparación de rendimiento entre modelos autorregresivos (AR) y modelos de difusión enmascarada (Difusión) al repetir en una porción limitada de datos. Todos los modelos se entrenaron con 96B tokens totales (incluyendo repetición), variando los tokens únicos de 0.5B a 96B. Los modelos de difusión explotan mejor los datos mediante más repeticiones sobre datos únicos limitados. Más tokens únicos requieren más repetición para ver el cruce, donde las corridas con alta cantidad de tokens únicos posponen el cruce más allá de nuestro alcance de observación de 96B tokens.*

<br>

# Citación
```
@misc{ni2025difflm,
title={Diffusion Language Models are Super Data Learners},
author={Jinjie Ni and the team},
year={2025},
howpublished={\url{https://jinjieni.notion.site/Diffusion-Language-Models-are-Super-Data-Learners-239d8f03a866800ab196e49928c019ac}},
note={Notion Blog},
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-28

---
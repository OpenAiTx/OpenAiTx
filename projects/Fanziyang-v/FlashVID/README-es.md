# FlashVID: Modelos de Lenguaje Grandes para Video Eficientes mediante Fusión de Tokens Espaciotemporales Basada en Árbol sin Entrenamiento

<div align="center">
<a href="https://scholar.google.com/citations?user=myU7V58AAAAJ&hl=en">Ziyang Fan</a><sup>1</sup>,&nbsp; <a href="https://github.com/Mirei124">Keyu Chen</a><sup>1</sup>,&nbsp; <a href="https://github.com/xrlexpert">Ruilong Xing</a><sup>1</sup>,&nbsp; <a href="https://scholar.google.com/citations?user=dQssXVsAAAAJ&hl=en">Yulin Li</a><sup>1</sup>,&nbsp; <a href="https://scholar.google.com/citations?user=5cIodxsAAAAJ&hl=en">Li Jiang</a><sup>2,3</sup>,&nbsp; <a href="https://scholar.google.com/citations?user=mEjhz-IAAAAJ&hl=en">Zhuotao Tian</a><sup>1,3*</sup>&nbsp;
<br>
<sup>1</sup> Instituto de Tecnología de Harbin (Shenzhen) &nbsp;&nbsp;&nbsp; <sup>2</sup> Universidad China de Hong Kong (Shenzhen)<br> <sup>3</sup> Instituto del Área Loop de Shenzhen
<br>
<sup>*</sup>Autor Correspondiente
<br>
<a href='https://iclr.cc/'><img src='https://img.shields.io/badge/ICLR-2026-78CA2E.svg'></a> &nbsp;
<a href='https://openreview.net/forum?id=H6rDX4w6Al'><img src='https://img.shields.io/badge/Paper-Openreview-8D1B12.svg'></a> &nbsp;
<a href="LICENSE"><img src="https://img.shields.io/badge/License-MIT-yellow.svg" alt="License"></a> &nbsp;
<a href='https://fanziyang-v.github.io/FlashVID/'><img src='https://img.shields.io/badge/Project-Page-Green'></a> &nbsp;
<a href="https://arxiv.org/abs/2602.08024"><img src="https://img.shields.io/badge/arXiv-2602.08024-b31b1b.svg"></a> &nbsp;
<a href="https://huggingface.co/"><img src="https://img.shields.io/badge/transformers-4.57-FFD21E.svg" alt="transformers"></a> &nbsp;
<!-- <a href="https://python.org/"><img src="https://img.shields.io/badge/Python-3.10%2B-3776ab.svg" alt="Python"></a> &nbsp; -->
<!-- <a href="https://pytorch.org/"><img src="https://img.shields.io/badge/PyTorch-2.5%2B-DF3411.svg" alt="PyTorch"></a> &nbsp; -->
<!-- <a href="#"><img src="https://img.shields.io/badge/#.svg"></a> &nbsp; -->
</div>

## 🔖Tabla de Contenidos

1. [Noticias](#news)
2. [Lista de Tareas](#todo-list)
3. [Aspectos Destacados](#highlights)
4. [Motivación](#motivation)
5. [Método](#method)
6. [Instalación](#installation)
7. [Inicio Rápido](#quickstart)
8. [Evaluación](#evaluation)
9. [Agradecimientos](#acknowledgement)
10. [Citación](#citation)

## 🔥Noticias

- [2026.05.01] 🔍Corrección de un posible error OOM en la extracción manual de atención [CLS] en Qwen2.5-VL y Qwen3-VL.
- [2026.02.10] 🚀Publicación de nuestro artículo en arXiv.
- [2026.02.06] 🍾Nuestro artículo ha sido seleccionado como **Presentación Oral** en **ICLR 2026**.
- [2026.02.01] ✨Lanzamiento del código FlashVID y demos de inferencia en *Qwen2.5-VL* y *Qwen3-VL*.
- [2026.01.31] 🚀Liberación pública de este repositorio.
- [2026.01.30] ✨Lanzamiento del código FlashVID y demos de inferencia en *LLaVA-OneVision* y *LLaVA-Video*.  
- [2026.01.30] 👏Inicialización de este repositorio de GitHub.  
- [2026.01.26] 🎉Nuestro método de aceleración de inferencia sin entrenamiento [FlashVID](https://openreview.net/forum?id=H6rDX4w6Al) ha sido aceptado en **ICLR 2026**.  
- [2025.12.06] 🌟Publicación del repositorio GitHub de [DyTok](https://github.com/yu-lin-li/DyToK).  
- [2025.09.18] 🎉 Nuestro marco de aceleración de inferencia sin entrenamiento [DyTok](https://www.arxiv.org/abs/2512.06866) ha sido aceptado en **NeurIPS 2025**.  

## 📋Lista de tareas  

- [ ] Optimizar la eficiencia del código  
- [x] Publicar código FlashVID en LLaVA-OneVision y LLaVA-Video.  
- [x] Publicar demos de inferencia en diferentes Video LLMs con FlashVID.  
- [x] Soportar evaluación usando [LMMs-Eval](https://github.com/EvolvingLMMs-Lab/lmms-eval).  
- [x] Publicar código FlashVID en Qwen2.5-VL y Qwen3-VL.  
- [x] Publicar nuestro artículo en arXiv.  

## ✨Aspectos destacados  

![FlashVID Teaser](https://raw.githubusercontent.com/Fanziyang-v/FlashVID/main/assets/teaser.png)  

1. Nuestro FlashVID supera significativamente a los anteriores marcos de aceleración de última generación (por ejemplo, VisionZip, FastVID) en **tres** VLLMs representativos (es decir, LLaVA-OneVision, LLaVA-Video, Qwen2.5-VL) en **cinco** benchmarks ampliamente usados para comprensión de video (es decir, VideoMME, EgoSchema, LongVideoBench, MVBench, MLVU).  
2. FlashVID puede servir como un módulo plug-and-play y sin necesidad de entrenamiento para extender cuadros de video largos, permitiendo un aumento de **10x** en la entrada de cuadros de video a Qwen2.5-VL, resultando en un **8.6%** dentro del mismo presupuesto computacional.  
3. Los métodos existentes eficientes para Video LLM a menudo comprimen de forma independiente la redundancia espacial y temporal, ignorando las relaciones intrínsecas espaciotemporales en videos. Para abordar esto, presentamos una solución **simple pero efectiva**: Fusión de Tokens Espaciotemporales basada en Árbol (TSTM) para compresión detallada de redundancia espaciotemporal.  

## 💡Motivación  

![Motivation](https://raw.githubusercontent.com/Fanziyang-v/FlashVID/main/assets/motivation.png)  

En este trabajo, identificamos dos observaciones clave sobre la redundancia espaciotemporal en videos:  

1. **La redundancia temporal no está ligada a ubicaciones espaciales fijas.** Elementos semánticamente consistentes en videos a menudo se desplazan en posición espacial, escala o apariencia debido al movimiento y la dinámica de la escena, haciendo que la correspondencia espacial rígida entre cuadros no sea confiable.  
2. **La redundancia espacial y temporal están intrínsecamente acopladas.** Las regiones redundantes dentro de un solo cuadro frecuentemente persisten a través de múltiples cuadros. La compresión desacoplada de la redundancia espaciotemporal ignora las relaciones espaciotemporales intrínsecas, llevando a una compresión subóptima.  

Para lograr una mejor compresión de la redundancia espaciotemporal, presentamos una solución **simple pero efectiva**: **Fusión de Tokens Espaciotemporales basada en Árbol (TSTM)** para compresión detallada de redundancia espaciotemporal, complementada con el módulo **Selección de Tokens basada en Atención y Diversidad (ADTS)** para la selección de tokens informativos.  

## 🌈Método  

![Method](https://raw.githubusercontent.com/Fanziyang-v/FlashVID/main/assets/method.png)  

**Ilustración de FlashVID**. Comprimimos tokens visuales mediante dos módulos sinérgicos.

1. **Selección de Tokens basada en Atención y Diversidad (ADTS)** prioriza tokens informativos espaciotemporales mientras asegura diversidad de características resolviendo un Problema Calibrado de Diversidad Máximo-Mínimo (MMDP);
2. **Fusión de Tokens Espaciotemporales basada en Árboles (TSTM)** modela la redundancia mediante árboles de redundancia espaciotemporal, que capturan efectivamente la dinámica fina del video. Cada árbol de redundancia se agregará en una sola representación de token.


## 📦Instalación

En este proyecto, usamos [uv](https://github.com/astral-sh/uv) para la gestión de paquetes.

1. **Clona este repositorio y navega a la carpeta FlashVID:**

```bash
git clone https://github.com/Fanziyang-v/FlashVID.git
cd FlashVID
```

2. **Instale el paquete de inferencia:**

```bash
uv sync
```

## 🚀Inicio rápido

El código de FlashVID es fácil de usar y funciona desde el primer momento. Simplemente envuelve el modelo con la función `flashvid()`. Actualmente, FlashVID soporta LLaVA-OneVision, LLaVA-Video, Qwen2.5-VL y Qwen3-VL.

```python
from flashvid import flashvid

model = flashvid(
    model,
    retention_ratio=0.1,
    alpha=0.7,
    temporal_threshold=0.8,
)
```

📝**Nota**: Puedes sobrescribir los parámetros predeterminados (por ejemplo, la tasa de retención) en la función envoltorio `flashvid()`.

Las demostraciones de inferencia se proporcionan en `playground/`. Aquí hay un ejemplo en ejecución:

```bash
python playground/llava_ov_infer.py \
    --video-path assets/Qgr4dcsY-60.mp4 \
    --question "Describe the video in detail." \
    --num-frames 32 \
    --enable-flashvid
```

## 📊Evaluación

En este proyecto, todos los experimentos se realizan utilizando [LMMs-Eval](https://github.com/EvolvingLMMs-Lab/lmms-eval). Proporcionamos scripts de evaluación FlashVID en `scripts/`, incluyendo LLaVA-OneVision, LLaVA-Video, Qwen2.5-VL y Qwen3-VL. Puedes ejecutar los scripts para reproducir nuestros resultados experimentales:

```bash
bash scripts/llava_ov.sh
```

📝**Nota**: Es extremadamente fácil integrar FlashVID en LMMs-Eval añadiendo parámetros específicos en `__init__()` y envolviendo el modelo cargado con la función `flashvid()`. (Ver `lmms_eval/models/simple/llava_onevision.py`)

## 👏Agradecimientos

Este proyecto se basa en trabajos recientes de código abierto: [FastV](https://github.com/pkunlp-icler/FastV), [VisionZip](https://github.com/dvlab-research/VisionZip), [PruneVID](https://github.com/visual-ai/prunevid), [FastVID](https://github.com/LunarShen/FastVID), [LLaVA-NeXT](https://github.com/LLaVA-VL/LLaVA-NeXT), [Qwen2.5-VL/Qwen3-VL](https://github.com/QwenLM/Qwen3-VL), [LMMs-Eval](https://github.com/EvolvingLMMs-Lab/lmms-eval). ¡Gracias por su excelente trabajo!

## 📜Citación

Si encuentra este proyecto útil en su investigación, por favor considere citar:

```bib
@inproceedings{
    fan2026flashvid,
    title={Flash{VID}: Efficient Video Large Language Models via Training-free Tree-based Spatiotemporal Token Merging},
    author={Ziyang Fan and Keyu Chen and Ruilong Xing and Yulin Li and Li Jiang and Zhuotao Tian},
    booktitle={The Fourteenth International Conference on Learning Representations},
    year={2026},
    url={https://openreview.net/forum?id=H6rDX4w6Al}
}
```

## ⭐️Star History

[![Star History Chart](https://api.star-history.com/svg?repos=Fanziyang-v/FlashVID&type=Date)](https://star-history.com/#Fanziyang-v/FlashVID&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-03

---
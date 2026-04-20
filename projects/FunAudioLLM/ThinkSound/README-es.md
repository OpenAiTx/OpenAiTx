<h1 align="center">ThinkSound</h1>

<p align="center">
  🌐
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=en">English</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=zh-CN">简体中文</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=zh-TW">繁體中文</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=es">Español</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=fr">Français</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=ja">日本語</a>
  
</p>
<p align="center">
  <img src="https://img.shields.io/badge/NeurIPS%202025-Main%20Conference-blue.svg" alt="NeurIPS 2025"/>
  &nbsp;
  <a href="https://arxiv.org/pdf/2506.21448">
    <img src="https://img.shields.io/badge/arXiv-2506.21448-b31b1b.svg" alt="arXiv"/>
  </a>
  &nbsp;
  <a href="https://thinksound-project.github.io/">
    <img src="https://img.shields.io/badge/Online%20Demo-🌐-blue" alt="Online Demo"/>
  </a>
  &nbsp;
  <a href="https://huggingface.co/spaces/FunAudioLLM/ThinkSound">
    <img src="https://img.shields.io/badge/HuggingFace-Spaces-orange?logo=huggingface" alt="Hugging Face"/>
  </a>
  &nbsp;
  <a href="https://modelscope.cn/studios/iic/ThinkSound">
    <img src="https://img.shields.io/badge/ModelScope-在线体验-green" alt="ModelScope"/>
  </a>
</p>

<p align="center">
  Si encuentras útil este proyecto,<br>
  ¡una estrella ⭐ en GitHub sería muy apreciada!
</p>

---

## Estructura del repositorio

Este repositorio de GitHub **ThinkSound** aloja dos proyectos relacionados en ramas separadas:

| Rama | Proyecto | Documentación |
|--------|---------|----------------|
| **`master`** | **ThinkSound** (NeurIPS 2025) — generación unificada Any2Audio con flujo guiado por CoT | Este archivo: **`README.md`** |
| **`prismaudio`** | **PrismAudio** — trabajo posterior (ICLR 2026) sobre video-audio con CoT-RL multidimensional | **`README.md`** en la rama [`prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) |

Para **ThinkSound**, usa la rama **`master`** (este README). Para **PrismAudio**, cambia a **`prismaudio`** y sigue el **`README.md`** allí.

---

**ThinkSound** es un marco unificado de generación Any2Audio con flujo guiado por razonamiento Chain-of-Thought (CoT).

Implementación en PyTorch para generación y edición de audio multimodal: genera o edita audio a partir de video, texto y audio, potenciados por razonamiento paso a paso de Modelos Multimodales de Lenguaje Grande (MLLMs).

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 Noticias
- **2026.03.24** &nbsp; 🔥 **PrismAudio** ha sido lanzado en el mismo repositorio en la rama [`prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) — consulta **`README.md`** allí para la configuración y modelos.
- **2026.01.26** &nbsp; 🎉 PrismAudio aceptado en la **Conferencia Principal ICLR 2026** (código/docs en `prismaudio`).
- **2025.11.25** &nbsp; 🔥 [Demo en línea de PrismAudio](http://prismaudio-project.github.io/) está disponible.
- **2025.11.25** &nbsp; 🔥 [Artículo de PrismAudio](https://arxiv.org/pdf/2511.18833) en arXiv — CoT-RL multidimensional para video-audio.
- **2025.09.19** &nbsp; 🎉 **ThinkSound** aceptado en la **Conferencia Principal NeurIPS 2025**!
- **2025.09.01** &nbsp; Nuestro conjunto de datos AudioCoT ahora es de código abierto y está disponible en [Hugging Face](https://huggingface.co/datasets/liuhuadai/AudioCoT)!
- **2025.07.17** &nbsp; 🧠 Fine-tuning habilitado: el código de entrenamiento y fine-tuning ahora es público, junto con instrucciones claras para ayudarte a personalizar y ampliar ThinkSound con tus propios datos.
- **2025.07.15** &nbsp; 📦 Instalación y usabilidad simplificadas: dependencias en PyPI para una fácil configuración multiplataforma; scripts `.bat` en Windows automatizan la creación de entorno y ejecución de scripts.
- **2025.07.08** &nbsp;  🔧 Actualización importante: modelo aligerado y optimizado en uso de memoria y GPU, ¡ahora soporta generación de audio de alto rendimiento a escala!
- **2025.07.01** &nbsp; Demo en línea en [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) y [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) para experiencia interactiva!
- **2025.07.01** &nbsp; Scripts de inferencia e interfaz web lanzados;
- **2025.06** &nbsp; ¡[Artículo de ThinkSound](https://arxiv.org/pdf/2506.21448) publicado en arXiv!
- **2025.06** &nbsp; [Demo en línea](http://thinksound-project.github.io/) disponible - ¡pruébalo ahora!

---


<div align="center">

### Trabajo posterior: PrismAudio (mismo repositorio, rama `prismaudio`)

**PrismAudio** es el sucesor de ThinkSound (ICLR 2026), desarrollado bajo un nuevo nombre pero mantenido en este repositorio en la rama **`prismaudio`**. Instalación, puntos de control y citación están en **[`README.md` en esa rama](https://github.com/liuhuadai/ThinkSound/blob/prismaudio/README.md)**.

👉 [`git checkout prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) o abre la rama en GitHub.

</div>

---


## 🚀 Características

- **Any2Audio**: Genera audio desde modalidades arbitrarias — video, texto, audio o sus combinaciones.
- **Video-to-Audio SOTA**: Logra resultados de última generación en múltiples benchmarks V2A.
- **Razonamiento impulsado por CoT**: Razonamiento Chain-of-Thought para generación de audio composicional y controlable mediante MLLMs.
- **Edición interactiva centrada en objetos**: Refina o edita eventos sonoros específicos haciendo clic en objetos visuales o usando instrucciones de texto.
- **Marco unificado**: Un modelo base soporta generación, edición y flujo de trabajo interactivo.

---

## ✨ Descripción general del método

ThinkSound descompone la generación y edición de audio en tres etapas interactivas, todas guiadas por razonamiento Chain-of-Thought (CoT) basado en MLLM:

1. **Generación Foley:** Genera paisajes sonoros fundamentales, alineados semántica y temporalmente a partir de video.
2. **Refinamiento centrado en objetos:** Refina o agrega sonidos para objetos especificados por el usuario mediante clics o regiones en el video.
3. **Edición de audio dirigida:** Modifica el audio generado usando instrucciones de lenguaje natural de alto nivel.

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- Un conjunto de datos a gran escala anotado con CoT (**AudioCoT**) se utiliza para entrenar tanto el módulo de razonamiento como el modelo base unificado de audio.
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ Inicio rápido

**Preparación del entorno:**
```bash
# ThinkSound code: branch master. PrismAudio: clone with -b prismaudio (see README.md on that branch).
git clone -b master https://github.com/liuhuadai/ThinkSound.git
cd ThinkSound
conda create -n thinksound python=3.10
conda activate thinksound
pip install thinksound
conda install -y -c conda-forge 'ffmpeg<7'
# Download pretrained weights https://huggingface.co/liuhuadai/ThinkSound to Directory ckpts/
# model weights can be also downloaded from https://www.modelscope.cn/models/iic/ThinkSound
git lfs install
git clone https://huggingface.co/liuhuadai/ThinkSound ckpts
# To improve inference and training speed, you may optionally install a FlashAttention backend compatible with your system and PyTorch version.
```
> ✅ **Consejo para Windows:**  
> Los usuarios de Windows pueden simplemente ejecutar `setup_windows.bat` (o hacer doble clic en él) para crear automáticamente el entorno conda, instalar todas las dependencias (incluido FFmpeg) y descargar el modelo preentrenado — no se requiere configuración manual.  
> Asegúrate de que `conda` y `git` estén instalados y disponibles en el PATH de tu sistema antes de ejecutar el script.


### ▶️ Ejecutar la Demostración

#### **Linux/macOS**


```bash
chmod +x scripts/demo.sh
./scripts/demo.sh <path-to-your-demo-video> <title> <CoT description> [use-half]
```
#### **Windows**

En su lugar, puede usar el script `.bat` proporcionado:


```bash
.\scripts\demo.bat <path-to-your-demo-video> <title> <CoT description> [use-half]
```
**Nota:**

* `<ruta-a-tu-video-demo>`: La ruta a un solo video
* `[use-half]` (opcional): Añade use-half al final para habilitar la extracción de características en media precisión.

---

### 📦 Inferencia por Lotes

#### **Linux/macOS**


```bash
chmod +x scripts/eval_batch.sh
./scripts/eval_batch.sh <video_path> <csv_path> <save_path (optional)> [use-half]
```
#### **Windows**

Utilice el script `.bat` equivalente:


```bash
.\scripts\eval_batch.bat <video_path> <csv_path> <save_path (optional)> [use-half]
```
**Nota:**

* `<video_path>`: Ruta al directorio raíz que contiene todos los videos .mp4 a procesar (todos los videos deben tener la misma duración).
* `<csv_path>`: Un archivo CSV con indicaciones de texto para cada video (ver `demo_test.csv` para el formato).
* `<save_path>` (opcional): Dónde guardar el audio generado. Por defecto es `results/features`.
* `[use-half]` (opcional): Agregue use-half al final para habilitar la extracción de características en precisión media.

---


### Uso de la Interfaz Web

Para una experiencia interactiva, inicie la interfaz web de Gradio:


```bash
python app.py
```
## 🏋️ Entrena el Modelo

Consulta [`Training.md`](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/docs/Training.md)


---


## 📄 Licencia

Este proyecto se publica bajo la Licencia Apache 2.0.

> **Nota:**
> El código, los modelos y el conjunto de datos son **solo para fines de investigación y educativos**.
> **No se permite el uso comercial.**
> Para licencias comerciales, por favor contacte a los autores.

**📦 Componentes de terceros**

* **Stable Audio Open VAE** (por Stability AI):
  Este repositorio incluye un VAE ajustado de [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/), licenciado bajo la [Licencia de la Comunidad Stability AI](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md).
  **El uso comercial y la redistribución requieren permiso previo de Stability AI.**

* 📘 **Todo el resto del código y modelos** se publica bajo la Licencia Apache 2.0.

---

## Agradecimientos

Muchas gracias a:

* **stable-audio-tools** (por Stability AI):
Por proporcionar un marco fácil de usar para la generación de audio, así como el módulo VAE y los pesos.
* **MMAudio**:
  Por la implementación del backbone MM-DiT en el dominio del audio.

---



## 📖 Citación

Si nuestro proyecto te resulta útil en tu investigación o trabajo, por favor cita nuestro artículo:

```bibtex
@misc{liu2025thinksoundchainofthoughtreasoningmultimodal,
      title={ThinkSound: Chain-of-Thought Reasoning in Multimodal Large Language Models for Audio Generation and Editing}, 
      author={Huadai Liu and Jialei Wang and Kaicheng Luo and Wen Wang and Qian Chen and Zhou Zhao and Wei Xue},
      year={2025},
      eprint={2506.21448},
      archivePrefix={arXiv},
      primaryClass={eess.AS},
      url={https://arxiv.org/abs/2506.21448}, 
}
@misc{liu2025prismaudiodecomposedchainofthoughtsmultidimensional,
          title={PrismAudio: Decomposed Chain-of-Thoughts and Multi-dimensional Rewards for Video-to-Audio Generation}, 
          author={Huadai Liu and Kaicheng Luo and Wen Wang and Qian Chen and Peiwen Sun and Rongjie Huang and Xiangang Li and Jieping Ye and Wei Xue},
          year={2025},
          eprint={2511.18833},
          archivePrefix={arXiv},
          primaryClass={cs.SD},
          url={https://arxiv.org/abs/2511.18833}, 
    }
```

---

## 📬 Contact


✨ Feel free to [open an issue](https://github.com/liuhuadai/ThinkSound/issues) or contact us via email ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) if you have any questions or suggestions!





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---
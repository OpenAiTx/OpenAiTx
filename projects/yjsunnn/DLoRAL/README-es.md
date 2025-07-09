<div align="center">
<h2>Difusión de un Paso para Super-Resolución de Video con Detalles Ricos y Consistencia Temporal</h2>

[Yujing Sun](https://yjsunnn.github.io/)<sup>1,2, *</sup> | 
[Lingchen Sun](https://scholar.google.com/citations?hl=zh-CN&tzom=-480&user=ZCDjTn8AAAAJ)<sup>1,2, *</sup> | 
[Shuaizheng Liu](https://scholar.google.com/citations?user=wzdCc-QAAAAJ&hl=en)<sup>1,2</sup> | 
[Rongyuan Wu](https://scholar.google.com/citations?user=A-U8zE8AAAAJ&hl=zh-CN)<sup>1,2</sup> | 
[Zhengqiang Zhang](https://scholar.google.com.tw/citations?user=UX26wSMAAAAJ&hl=en)<sup>1,2</sup> | 
[Lei Zhang](https://www4.comp.polyu.edu.hk/~cslzhang)<sup>1,2</sup>

<sup>1</sup>The Hong Kong Polytechnic University, <sup>2</sup>OPPO Research Institute
</div>

<div>
    <h4 align="center">
        <a href="https://yjsunnn.github.io/DLoRAL-project/" target='_blank'>
        <img src="https://img.shields.io/badge/💡-Página%20del%20Proyecto-gold">
        </a>
        <a href="https://arxiv.org/pdf/2506.15591" target='_blank'>
        <img src="https://img.shields.io/badge/arXiv-2312.06640-b31b1b.svg">
        </a>
        <a href="https://www.youtube.com/embed/Jsk8zSE3U-w?si=jz1Isdzxt_NqqDFL&vq=hd1080" target='_blank'>
        <img src="https://img.shields.io/badge/Video%20Demostración-%23FF0000.svg?logo=YouTube&logoColor=white">
        </a>
        <a href="https://www.youtube.com/embed/xzZL8X10_KU?si=vOB3chIa7Zo0l54v" target="_blank">
        <img src="https://img.shields.io/badge/Explicador%20de%202%20Minutos-brightgreen?logo=YouTube&logoColor=white">
        </a>
        </a>
        <a href="https://github.com/yjsunnn/Awesome-video-super-resolution-diffusion" target="_blank">
        <img src="https://img.shields.io/badge/GitHub-Awesome--VSR--Diffusion-181717.svg?logo=github&logoColor=white">
        </a>
<!--         <a href="https://www.youtube.com/embed/Jsk8zSE3U-w?si=jz1Isdzxt_NqqDFL&vq=hd1080" target='_blank'>
        <img src="https://img.shields.io/badge/1--Min%20Algorithm%20Explainer-%23FF0000.svg?logo=YouTube&logoColor=white">
        </a> -->
        <a href="https://github.com/yjsunnn/DLoRAL" target='_blank' style="text-decoration: none;"><img src="https://visitor-badge.laobi.icu/badge?page_id=yjsunnn/DLoRAL"></a>
    </h4>
</div>

<p align="center">

<img src="https://raw.githubusercontent.com/yjsunnn/DLoRAL/main/assets/visual_results.svg" alt="Visual Results">

</p>
## ⏰ Actualización

- **2025.07.08**: El código de inferencia y los pesos preentrenados están disponibles.
- **2025.06.24**: La página del proyecto está disponible, incluyendo un breve video explicativo de 2 minutos, más resultados visuales e investigaciones relevantes.
- **2025.06.17**: El repositorio ha sido publicado.

:star: Si DLoRAL es útil para tus videos o proyectos, por favor, ayuda dando una estrella a este repositorio. ¡Gracias! :hugs:

😊 También puedes revisar nuestros trabajos relacionados:

1. **OSEDiff (NIPS2024)** [Artículo](https://arxiv.org/abs/2406.08177) | [Código](https://github.com/cswry/OSEDiff/)  

   Algoritmo de SR de imágenes en tiempo real que ha sido aplicado a la serie OPPO Find X8.

2. **PiSA-SR (CVPR2025)** [Artículo](https://arxiv.org/pdf/2412.03017) | [Código](https://github.com/csslc/PiSA-SR) 

   Exploración pionera del paradigma Dual-LoRA en SR de imágenes.

3. **Awesome Diffusion Models for Video Super-Resolution** [Repositorio](https://github.com/yjsunnn/Awesome-video-super-resolution-diffusion)

   Una lista curada de recursos para Super-Resolución de Video (VSR) usando Modelos de Difusión.
## 👀 TODO
- [x] Liberar el código de inferencia.
- [ ] Interfaz Colab y Huggingface para pruebas convenientes (¡Próximamente!).
- [ ] Liberar el código de entrenamiento.
- [ ] Liberar los datos de entrenamiento.


## 🌟 Descripción General del Framework

<p align="center">

<img src="https://raw.githubusercontent.com/yjsunnn/DLoRAL/main/assets/pipeline.svg" alt="DLoRAL Framework">

</p>

**Entrenamiento**: Un esquema dinámico de entrenamiento en dos etapas alterna entre la optimización de la coherencia temporal (etapa de consistencia) y el refinamiento de los detalles espaciales de alta frecuencia (etapa de mejora) con una interpolación suave de la pérdida para garantizar la estabilidad.

**Inferencia**: Durante la inferencia, tanto C-LoRA como D-LoRA se integran en el UNet de difusión congelado, permitiendo la mejora en un solo paso de entradas de baja calidad a salidas de alta calidad.
## 🔧 Dependencias e Instalación

1. Clonar el repositorio
    ```bash
    git clone https://github.com/yjsunnn/DLoRAL.git
    cd DLoRAL
    ```

2. Instalar los paquetes dependientes
    ```bash
    conda create -n DLoRAL python=3.10 -y
    conda activate DLoRAL
    pip install -r requirements.txt
    ```

3. Descargar Modelos 
#### Modelos Dependientes
* [SD21 Base](https://huggingface.co/stabilityai/stable-diffusion-2-1-base) --> colocar en **/path/to/DLoRAL/preset_models/stable-diffusion-2-1-base**
* [Bert-Base](https://huggingface.co/google-bert/bert-base-uncased) --> colocar en **/path/to/DLoRAL/preset_models/bert-base-uncased**
* [RAM](https://huggingface.co/spaces/xinyu1205/recognize-anything/blob/main/ram_swin_large_14m.pth) --> colocar en **/path/to/DLoRAL/preset/models/ram_swin_large_14m.pth**
* [DAPE](https://drive.google.com/file/d/1KIV6VewwO2eDC9g4Gcvgm-a0LDI7Lmwm/view?usp=drive_link) --> colocar en **/path/to/DLoRAL/preset/models/DAPE.pth**
* [Pesos Preentrenados](https://drive.google.com/file/d/1vpcaySpRx_K-tXq2D2EBqFZ-03Foky8G/view?usp=sharing) --> colocar en **/path/to/DLoRAL/preset/models/checkpoints/model.pkl**

Cada ruta puede ser modificada de acuerdo a los propios requerimientos, y los cambios correspondientes también deben aplicarse en la línea de comandos y en el código.
## 🖼️ Inferencia Rápida
Para Super-Resolución de Video en el Mundo Real:

```
python src/test_DLoRAL.py     \
--pretrained_model_path /ruta/al/stable-diffusion-2-1-base     \
--ram_ft_path /ruta/al/DAPE.pth     \
--ram_path '/ruta/al/ram_swin_large_14m.pth'     \
--merge_and_unload_lora False     \
--process_size 512     \
--pretrained_model_name_or_path '/ruta/al/stable-diffusion-2-1-base'     \
--vae_encoder_tiled_size 4096     \
--load_cfr     \
--pretrained_path /ruta/al/model_checkpoint.pkl     \
--stages 1     \
-i /ruta/al/input_videos/     \
-o /ruta/al/results
```
### Citaciones
Si nuestro código ayuda en su investigación o trabajo, por favor considere citar nuestro artículo.
Las siguientes son referencias BibTeX:

```
@misc{sun2025onestepdiffusiondetailrichtemporally,
      title={One-Step Diffusion for Detail-Rich and Temporally Consistent Video Super-Resolution}, 
      author={Yujing Sun and Lingchen Sun y Shuaizheng Liu y Rongyuan Wu y Zhengqiang Zhang y Lei Zhang},
      year={2025},
      eprint={2506.15591},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2506.15591}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---
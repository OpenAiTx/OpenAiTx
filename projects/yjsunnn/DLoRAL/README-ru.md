<div align="center">
<h2>Одношаговая диффузия для детализированного и временно согласованного увеличения разрешения видео</h2>

[Yujing Sun](https://yjsunnn.github.io/)<sup>1,2, *</sup> | 
[Lingchen Sun](https://scholar.google.com/citations?hl=zh-CN&tzom=-480&user=ZCDjTn8AAAAJ)<sup>1,2, *</sup> | 
[Shuaizheng Liu](https://scholar.google.com/citations?user=wzdCc-QAAAAJ&hl=en)<sup>1,2</sup> | 
[Rongyuan Wu](https://scholar.google.com/citations?user=A-U8zE8AAAAJ&hl=zh-CN)<sup>1,2</sup> | 
[Zhengqiang Zhang](https://scholar.google.com.tw/citations?user=UX26wSMAAAAJ&hl=en)<sup>1,2</sup> | 
[Lei Zhang](https://www4.comp.polyu.edu.hk/~cslzhang)<sup>1,2</sup>

<sup>1</sup>Гонконгский политехнический университет, <sup>2</sup>Исследовательский институт OPPO
</div>

<div>
    <h4 align="center">
        <a href="https://yjsunnn.github.io/DLoRAL-project/" target='_blank'>
        <img src="https://img.shields.io/badge/💡-Project%20Page-gold">
        </a>
        <a href="https://arxiv.org/pdf/2506.15591" target='_blank'>
        <img src="https://img.shields.io/badge/arXiv-2312.06640-b31b1b.svg">
        </a>
        <a href="https://www.youtube.com/embed/Jsk8zSE3U-w?si=jz1Isdzxt_NqqDFL&vq=hd1080" target='_blank'>
        <img src="https://img.shields.io/badge/Demo%20Video-%23FF0000.svg?logo=YouTube&logoColor=white">
        </a>
        <a href="https://www.youtube.com/embed/xzZL8X10_KU?si=vOB3chIa7Zo0l54v" target="_blank">
        <img src="https://img.shields.io/badge/2--Min%20Explainer-brightgreen?logo=YouTube&logoColor=white">
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

<img src="https://raw.githubusercontent.com/yjsunnn/DLoRAL/main/assets/visual_results.svg" alt="Визуальные результаты">

</p>

## ⏰ Обновления

- **2025.07.08**: Доступен код для инференса и предобученные веса.
- **2025.06.24**: Доступна страница проекта, включая краткое 2-минутное объясняющее видео, больше визуальных результатов и соответствующих исследований.
- **2025.06.17**: Репозиторий опубликован.

:star: Если DLoRAL оказался полезен для ваших видео или проектов, пожалуйста, поставьте звезду этому репозиторию. Спасибо! :hugs:

😊 Возможно, вам также будут интересны наши смежные работы:

1. **OSEDiff (NIPS2024)** [Статья](https://arxiv.org/abs/2406.08177) | [Код](https://github.com/cswry/OSEDiff/)  

   Алгоритм суперразрешения изображений в реальном времени, который был применён в серии OPPO Find X8.

2. **PiSA-SR (CVPR2025)** [Статья](https://arxiv.org/pdf/2412.03017) | [Код](https://github.com/csslc/PiSA-SR) 

   Первое исследование парадигмы Dual-LoRA в суперразрешении изображений.

3. **Awesome Diffusion Models for Video Super-Resolution** [Репозиторий](https://github.com/yjsunnn/Awesome-video-super-resolution-diffusion)

   Кураторский список ресурсов по суперразрешению видео (VSR) с использованием диффузионных моделей.
## 👀 TODO
- [x] Выпустить код для инференса.
- [ ] Colab и интерфейс Huggingface для удобного тестирования (Скоро!).
- [ ] Выпустить код для обучения.
- [ ] Выпустить обучающие данные.


## 🌟 Обзор фреймворка

<p align="center">

<img src="https://raw.githubusercontent.com/yjsunnn/DLoRAL/main/assets/pipeline.svg" alt="DLoRAL Framework">

</p>

**Обучение**: Динамическая двухэтапная схема обучения поочередно оптимизирует временную согласованность (этап согласованности) и улучшает высокочастотные пространственные детали (этап повышения качества) с плавной интерполяцией потерь для обеспечения стабильности.

**Инференс**: Во время инференса C-LoRA и D-LoRA объединяются во встроенной (замороженной) диффузионной UNet, что позволяет за один шаг преобразовывать низкокачественные входные данные в высококачественные выходные.
## 🔧 Зависимости и установка

1. Клонируйте репозиторий
    ```bash
    git clone https://github.com/yjsunnn/DLoRAL.git
    cd DLoRAL
    ```

2. Установите необходимые пакеты
    ```bash
    conda create -n DLoRAL python=3.10 -y
    conda activate DLoRAL
    pip install -r requirements.txt
    ```

3. Загрузите модели 
#### Необходимые модели
* [SD21 Base](https://huggingface.co/stabilityai/stable-diffusion-2-1-base) --> поместить в **/path/to/DLoRAL/preset_models/stable-diffusion-2-1-base**
* [Bert-Base](https://huggingface.co/google-bert/bert-base-uncased) --> поместить в **/path/to/DLoRAL/preset_models/bert-base-uncased**
* [RAM](https://huggingface.co/spaces/xinyu1205/recognize-anything/blob/main/ram_swin_large_14m.pth) --> поместить в **/path/to/DLoRAL/preset/models/ram_swin_large_14m.pth**
* [DAPE](https://drive.google.com/file/d/1KIV6VewwO2eDC9g4Gcvgm-a0LDI7Lmwm/view?usp=drive_link) --> поместить в **/path/to/DLoRAL/preset/models/DAPE.pth**
* [Pretrained Weights](https://drive.google.com/file/d/1vpcaySpRx_K-tXq2D2EBqFZ-03Foky8G/view?usp=sharing) --> поместить в **/path/to/DLoRAL/preset/models/checkpoints/model.pkl**

Каждый путь можно изменить в соответствии со своими требованиями, и соответствующие изменения также должны быть внесены в командную строку и код.
## 🖼️ Быстрое Выводное Инферирование
Для сверхразрешения реальных видеороликов:

```
python src/test_DLoRAL.py     \
--pretrained_model_path /path/to/stable-diffusion-2-1-base     \
--ram_ft_path /path/to/DAPE.pth     \
--ram_path '/path/to/ram_swin_large_14m.pth'     \
--merge_and_unload_lora False     \
--process_size 512     \
--pretrained_model_name_or_path '/path/to/stable-diffusion-2-1-base'     \
--vae_encoder_tiled_size 4096     \
--load_cfr     \
--pretrained_path /path/to/model_checkpoint.pkl     \
--stages 1     \
-i /path/to/input_videos/     \
-o /path/to/results
```

### Цитирования
Если наш код помог вашей исследовательской работе или проекту, пожалуйста, рассмотрите возможность цитирования нашей статьи.
Ниже приведены ссылки в формате BibTeX:

```
@misc{sun2025onestepdiffusiondetailrichtemporally,
      title={One-Step Diffusion for Detail-Rich and Temporally Consistent Video Super-Resolution}, 
      author={Yujing Sun and Lingchen Sun and Shuaizheng Liu and Rongyuan Wu and Zhengqiang Zhang and Lei Zhang},
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
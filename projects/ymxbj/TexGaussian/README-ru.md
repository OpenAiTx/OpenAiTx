<h1 align="center">TexGaussian: Генерация высококачественных PBR-материалов с помощью октридного 3D Gaussian Splatting</h1>
<p align="center"><a href="https://arxiv.org/abs/2411.19654"><img src='https://img.shields.io/badge/arXiv-Paper-red?logo=arxiv&logoColor=white' alt='arXiv'></a>
<a href='https://3d-aigc.github.io/TexGaussian/'><img src='https://img.shields.io/badge/Project_Page-Website-green?logo=googlechrome&logoColor=white' alt='Project Page'></a>
<p align="center"><img src="https://raw.githubusercontent.com/ymxbj/TexGaussian/main/assets/teaser.png" width="100%"></p>

Материалы для физически корректного рендеринга (PBR) играют ключевую роль в современной графике, обеспечивая фотореалистичный рендеринг в различных окружениях. Разработка эффективного и быстрого алгоритма, способного автоматически генерировать высококачественные PBR-материалы (а не только RGB-текстуры) для 3D-моделей, может существенно упростить процесс создания 3D-контента. Большинство существующих методов используют предварительно обученные 2D-диффузионные модели для синтеза изображений с различных ракурсов, что часто приводит к значительным несоответствиям между сгенерированными текстурами и исходными 3D-моделями. В данной работе представлен TexGaussian — новый метод, использующий октантно-ориентированный 3D Gaussian Splatting для быстрой генерации PBR-материалов. В частности, каждый 3D-гауссиан размещается в самом мелком листовом узле октри, построенного из входной 3D-модели, для отрисовки изображений с разных ракурсов не только для карты альбедо, но и для карт шероховатости и металличности. Кроме того, наша модель обучается в регрессионной постановке, а не через диффузионное шумоподавление, что позволяет генерировать PBR-материалы для 3D-модели за один прогон без обратного распространения. Обширные эксперименты на открытых бенчмарках показывают, что наш метод синтезирует более визуально привлекательные PBR-материалы и работает быстрее по сравнению с предыдущими решениями как в безусловных, так и в текст-условных сценариях, обеспечивая лучшее соответствие заданной геометрии.

## 📦 Установка

```bash
conda create -n texgaussian python==3.10
pip3 install torch==2.1.0 torchvision==0.16.0 torchaudio==2.1.0 --index-url https://download.pytorch.org/whl/cu118

# модифицированный gaussian splatting (+ глубина, альфа-рендеринг)
git clone --recursive https://github.com/ashawkey/diff-gaussian-rasterization

pip3 install ./diff-gaussian-rasterization

pip3 install git+https://github.com/NVlabs/nvdiffrast

# остальные зависимости
pip3 install -r requirements.txt
```

## 🤖 Предобученные модели

Мы предоставляем следующие предобученные модели:

| Модель | Описание | Параметры | Скачать |
| --- | --- | --- | --- |
| TexGaussian-bench | Безусловная RGB-текстурная модель, обученная на ShapeNet bench | 70M | [Скачать](https://huggingface.co/ymxbj/TexGaussian/resolve/main/bench.safetensors?download=true) |
| TexGaussian-car | Безусловная RGB-текстурная модель, обученная на ShapeNet car | 70M | [Скачать](https://huggingface.co/ymxbj/TexGaussian/resolve/main/car.safetensors?download=true) |
| TexGaussian-chair | Безусловная RGB-текстурная модель, обученная на ShapeNet chair | 70M | [Скачать](https://huggingface.co/ymxbj/TexGaussian/resolve/main/chair.safetensors?download=true) |
| TexGaussian-table | Безусловная RGB-текстурная модель, обученная на ShapeNet table | 70M | [Скачать](https://huggingface.co/ymxbj/TexGaussian/resolve/main/table.safetensors?download=true) |
| TexGaussian-PBR | Текст-условная модель PBR-материалов, обученная на Objaverse | 295M | [Скачать](https://huggingface.co/ymxbj/TexGaussian/resolve/main/PBR_model.safetensors?download=true) |

## 💡 Инференс

### PBR-материал
Для генерации PBR-материалов по текстовому описанию выполните:
```bash
bash inference_for_PBR_material.sh
```
После запекания текстуры и материала вы получите две карты: одну карту альбедо и одну карту PBR-материалов. В частности, карта PBR-материалов содержит три канала: зеленый канал отвечает за значение шероховатости, синий канал — за значение металличности. Для PBR-рендеринга сгенерированных карт текстуры и материала мы рекомендуем использовать [этот скрипт рендеринга](https://github.com/ymxbj/BlenderToolboxPBR) на bpy.

Кроме того, мы рекомендуем ориентироваться на стиль текстовых описаний из датасета Cap3D и создавать свои собственные промпты для получения лучших результатов генерации. Датасет Cap3D доступен для загрузки [здесь](https://huggingface.co/ymxbj/TexGaussian/resolve/main/Cap3D_automated_Objaverse_full.csv?download=true).

### RGB-текстура
Для безусловной генерации RGB-текстур (работает только для 4 категорий: bench, car, chair, table) выполните:
```bash
bash inference_for_RGB_texture.sh
```
После запекания текстуры вы получите одну карту альбедо.

## 🏋️‍♂️ Обучение
Для Objaverse:
```bash
bash train_for_objaverse.sh
```

Для ShapeNet:
```bash
bash train_for_shapenet.sh
```

## 🚧 В планах
- [x] Открыть код для обучения и инференса
- [x] Открыть предобученную безусловную модель только с альбедо на датасете ShapeNet
- [x] Открыть предобученную текст-условную PBR-модель на датасете Objaverse
- [ ] Открыть датасет и инструменты для работы с ним

## 📚Благодарности

Данная работа основана на множестве потрясающих исследований и open-source проектов. Огромное спасибо всем авторам за их вклад и открытость!

- [gaussian-splatting](https://github.com/graphdeco-inria/gaussian-splatting) и [diff-gaussian-rasterization](https://github.com/graphdeco-inria/diff-gaussian-rasterization)
- [nvdiffrast](https://github.com/NVlabs/nvdiffrast)
- [LGM](https://github.com/3DTopia/LGM)
- [ocnn-pytorch](https://github.com/octree-nn/ocnn-pytorch)

<!-- Citation -->
## 📜 Цитирование

Если вы нашли данную работу полезной, пожалуйста, цитируйте нашу статью:

1. Версия на arXiv
```bibtex
@article{xiong2024texgaussian,
  title={TexGaussian: Generating High-quality PBR Material via Octree-based 3D Gaussian Splatting},
  author={Xiong, Bojun and Liu, Jialun and Hu, Jiakui and Wu, Chenming and Wu, Jinbo and Liu, Xing and Zhao, Chen and Ding, Errui and Lian, Zhouhui},
  journal={arXiv preprint arXiv:2411.19654},
  year={2024}
}
```

2. Версия для CVPR
```bibtex
@InProceedings{Xiong_2025_CVPR,
    author    = {Xiong, Bojun and Liu, Jialun and Hu, Jiakui and Wu, Chenming and Wu, Jinbo and Liu, Xing and Zhao, Chen and Ding, Errui and Lian, Zhouhui},
    title     = {TexGaussian: Generating High-quality PBR Material via Octree-based 3D Gaussian Splatting},
    booktitle = {Proceedings of the Computer Vision and Pattern Recognition Conference (CVPR)},
    month     = {June},
    year      = {2025},
    pages     = {551-561}
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---
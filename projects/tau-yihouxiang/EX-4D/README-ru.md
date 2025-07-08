# EX-4D: EXtreme Viewpoint 4D Video Synthesis via Depth Watertight Mesh

<div align="center">

<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/Logo.png" alt="EX-4D Logo" width="250">

[📄 Статья](https://arxiv.org/abs/2506.05554)  |  [🎥 Домашняя страница](https://tau-yihouxiang.github.io/projects/EX-4D/EX-4D.html)  |  [💻 Код](https://github.com/tau-yihouxiang/EX-4D)

</div>



## 🌟 Основные особенности

- **🎯 Синтез с экстремальными ракурсами**: Генерация высококачественного 4D-видео с перемещением камеры от -90° до 90°
- **🔧 Глубинная водонепроницаемая сетка (Depth Watertight Mesh)**: Новое геометрическое представление, моделирующее как видимые, так и скрытые области
- **⚡ Легковесная архитектура**: Всего 1% обучаемых параметров (140M) от 14B-видеодиффузионного бэкона
- **🎭 Без мультракурстного обучения**: Инновационная стратегия маскирования исключает необходимость в дорогих мультракурстных датасетах
- **🏆 Передовые показатели**: Превосходит существующие методы, особенно на экстремальных углах камеры

## 🎬 Демонстрационные результаты

<div align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/teaser.png" alt="EX-4D Demo Results" width="800">
</div>

*EX-4D преобразует монокулярные видео в управляемые камерой 4D-опыты с физически согласованными результатами при экстремальных ракурсах.*

## 🏗️ Обзор фреймворка

<div align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/overview.png" alt="EX-4D Architecture">
</div>

Наш фреймворк состоит из трёх ключевых компонентов:

1. **🔺 Построение глубинной водонепроницаемой сетки**: Создаёт надёжный геометрический приор, явно моделируя как видимые, так и скрытые области
2. **🎭 Симулированная стратегия маскирования**: Генерирует эффективные обучающие данные из монокулярных видео без мультракурстных датасетов
3. **⚙️ Лёгкий адаптер LoRA**: Эффективно интегрирует геометрическую информацию с предобученными видеодиффузионными моделями

## 🚀 Быстрый старт

### Установка

```bash
# Клонируйте репозиторий
git clone https://github.com/tau-yihouxiang/EX-4D.git
cd EX-4D

# Создайте окружение conda
conda create -n ex4d python=3.10
conda activate ex4d
# Установите PyTorch (рекомендуется 2.x)
pip install torch==2.4.1 torchvision==0.19.1 torchaudio==2.4.1 --index-url https://download.pytorch.org/whl/cu124
# Установите Nvdiffrast
pip install git+https://github.com/NVlabs/nvdiffrast.git
# Установите зависимости и diffsynth
pip install -e .
# Установите depthcrafter для оценки глубины. (Следуйте инструкции DepthCrafter по подготовке контрольных точек.)
git clone https://github.com/Tencent/DepthCrafter.git
```

### Загрузка предобученной модели
```bash
huggingface-cli download Wan-AI/Wan2.1-I2V-14B-480P --local-dir ./models/Wan-AI
huggingface-cli download yihouxiang/EX-4D --local-dir ./models/EX-4D
```

### Пример использования
#### 1. Реконструкция DW-Mesh
```bash
# --cam 180 (30 / 60 / 90 / zoom_in / zoom_out )
python recon.py --input_video examples/flower/input.mp4 --cam 180 --output_dir outputs/flower --save_mesh
```
#### 2. Генерация EX-4D (требуется 48GB VRAM)
```bash
python generate.py --color_video outputs/flower/color_180.mp4 --mask_video outputs/flower/mask_180.mp4 --output_video outputs/flower/output.mp4
```

<table>
<tr>
<td width="45%" align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/examples/flower/input.gif" width="100%">
<br><b>Входное видео</b>
</td>
<td align="center">
<div style="font-size: 2em; color: #4A90E2; padding: 0 0px;">
  ➜
</div>
</td>
<td width="45%" align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/examples/flower/output.gif" width="100%">
<br><b>Выходное видео</b>
</td>
</tr> 
</table>

<!-- ## 📊 Performance

### Quantitative Results
| Метод | FID (Экстремальный) ↓ | FVD (Экстремальный) ↓ | Оценка VBench ↑ |
|--------|----------------------|-----------------------|-----------------|
| ReCamMaster | 64.68 | 943.45 | 0.434 |
| TrajectoryCrafter | 65.33 | 893.80 | 0.447 |
| TrajectoryAttention | 62.49 | 912.14 | 0.389 |
| **EX-4D (Наш)** | **55.42** | **823.61** | **0.450** | -->

### Результаты пользовательского исследования

- **70.7%** участников предпочли EX-4D по сравнению с базовыми методами
- Превосходная физическая согласованность и качество при экстремальных ракурсах
- Значительное улучшение по мере увеличения экстремальности углов камеры

## 🎯 Применения

- **🎮 Игры**: Создание захватывающих 3D-кинематографических сцен на основе 2D-видео
- **🎬 Кинопроизводство**: Генерация новых ракурсов для пост-продакшна
- **🥽 VR/AR**: Создание видео с возможностью свободного выбора точки обзора
- **📱 Социальные сети**: Генерация динамичных движений камеры для создания контента
- **🏢 Архитектура**: Визуализация пространств с различных точек зрения

<!-- ## 📈 Benchmarks -->

<!-- ### Оценка диапазона точек зрения

| Диапазон | Малый (0°→30°) | Большой (0°→60°) | Экстремальный (0°→90°) | Полный (-90°→90°) |
|----------|----------------|------------------|-----------------------|-------------------|
| FID | 44.19 | 50.30 | 55.42 | - |
| Прирост производительности | +9.1% лучше | +8.9% лучше | +11.3% лучше | +15.5% лучше | -->

<!-- *Прирост производительности по сравнению со вторым лучшим методом в каждой категории.* -->

## ⚠️ Ограничения

- **Зависимость от глубины**: Производительность зависит от качества монокулярной оценки глубины
- **Вычислительные затраты**: Требуется значительные вычислительные ресурсы для видео высокого разрешения
- **Отражающие поверхности**: Сложности с отражающими или прозрачными материалами

## 🔮 Будущая работа
- [ ] Оптимизация инференса в реальном времени (3DGS / 4DGS)
- [ ] Поддержка более высоких разрешений (1K, 2K)
- [ ] Техники нейронной доработки сетки

## 🙏 Благодарности

Мы хотели бы поблагодарить проект [DiffSynth-Studio v1.1.1](https://github.com/modelscope/DiffSynth-Studio/tree/v1.1.1) за предоставление базовой диффузионной платформы.

## 📚 Цитирование

Если вы считаете нашу работу полезной, пожалуйста, укажите ссылку:

```bibtex
@misc{hu2025ex4dextremeviewpoint4d,
      title={EX-4D: EXtreme Viewpoint 4D Video Synthesis via Depth Watertight Mesh}, 
      author={Tao Hu and Haoyang Peng and Xiao Liu and Yuewen Ma},
      year={2025},
      eprint={2506.05554},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2506.05554}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---
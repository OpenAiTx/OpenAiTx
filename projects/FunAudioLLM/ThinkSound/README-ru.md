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
  <img src="https://img.shields.io/badge/NeurIPS 2025-Main Conference-blue.svg" alt="NeurIPS 2025"/>
<p align="center">
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
  Если вы считаете этот проект полезным,<br>
  звезда ⭐ на GitHub будет очень признательна!
</p>

---

**ThinkSound** — это унифицированная платформа генерации Any2Audio с сопоставлением потоков, управляемая рассуждениями в стиле Chain-of-Thought (CoT).

Реализация на PyTorch для мультимодальной генерации и редактирования аудио: генерируйте или редактируйте аудио на основе видео, текста и аудио, с поэтапным рассуждением от Мультимодальных Больших Языковых Моделей (MLLMs).

![Тизер](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 Новости
- **2025.09.19** &nbsp; 🎉 ThinkSound принят на **Главную конференцию NeurIPS 2025**!
- **2025.09.01** &nbsp; 🔥 Наш датасет AudioCoT открыт и доступен на [Hugging Face](https://huggingface.co/datasets/liuhuadai/AudioCoT)!
- **2025.07.17** &nbsp; 🧠 Доступно дообучение: код для обучения и дообучения опубликован вместе с подробной инструкцией, чтобы вы могли адаптировать и расширять ThinkSound под свои данные.
- **2025.07.15** &nbsp; 📦 Упрощённая установка и использование: зависимости через PyPI для лёгкой кроссплатформенной установки; Windows `.bat`-скрипты автоматизируют создание окружения и запуск скриптов.
- **2025.07.08** &nbsp;  🔧 Важное обновление: модель облегчена, оптимизировано использование памяти и GPU, теперь поддерживает массовую высокопроизводительную генерацию аудио!
- **2025.07.01** &nbsp; 🔥Онлайн-демо на [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) и [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) для интерактивного опыта!
- **2025.07.01** &nbsp; 🔥Выпущены скрипты для инференса и веб-интерфейс;
- **2025.06** &nbsp; 🔥[Статья ThinkSound](https://arxiv.org/pdf/2506.21448) опубликована на arXiv!
- **2025.06** &nbsp; 🔥[Онлайн-демо](http://thinksound-project.github.io/) доступно — попробуйте прямо сейчас!

---


## 🚀 Возможности

- **Any2Audio**: Генерируйте аудио из любых модальностей — видео, текста, аудио или их комбинаций.
- **Video-to-Audio SOTA**: Достигает передовых результатов на нескольких V2A-бенчмарках.
- **CoT-Driven Reasoning**: Поэтапное рассуждение для композиционной и управляемой генерации аудио через MLLMs.
- **Интерактивное объектно-центричное редактирование**: Улучшайте или редактируйте отдельные звуковые события, кликая по визуальным объектам или используя текстовые инструкции.
- **Унифицированный фреймворк**: Одна базовая модель поддерживает генерацию, редактирование и интерактивный рабочий процесс.

---

## ✨ Обзор метода

ThinkSound разделяет генерацию и редактирование аудио на три интерактивные стадии, все управляются поэтапным рассуждением на базе MLLM:

1. **Генерация фоли:** Генерация базовых, семантически и временно согласованных звуковых ландшафтов из видео.
2. **Объектно-центричное уточнение:** Улучшение или добавление звуков для выбранных пользователем объектов через клики или области на видео.
3. **Целевое редактирование аудио:** Модификация сгенерированного аудио с помощью высокоуровневых инструкций на естественном языке.

![Обзор ThinkSound](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- Для обучения модуля рассуждений и унифицированной аудио-базовой модели используется крупномасштабный датасет с аннотацией Chain-of-Thought (**AudioCoT**).
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ Быстрый старт

**Подготовка среды:**
```bash
git clone https://github.com/liuhuadai/ThinkSound.git
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
> ✅ **Совет для Windows:**  
> Пользователи Windows могут просто запустить `setup_windows.bat` (или дважды щелкнуть по нему), чтобы автоматически создать среду conda, установить все зависимости (включая FFmpeg) и загрузить предобученную модель — никакой ручной настройки не требуется.  
> Перед запуском скрипта убедитесь, что `conda` и `git` установлены и доступны в переменной PATH вашей системы.


### ▶️ Запуск демо

#### **Linux/macOS**


```bash
chmod +x scripts/demo.sh
./scripts/demo.sh <path-to-your-demo-video> <title> <CoT description> [use-half]
```
#### **Windows**

Вместо этого вы можете использовать предоставленный скрипт `.bat`:


```bash
.\scripts\demo.bat <path-to-your-demo-video> <title> <CoT description> [use-half]
```
**Примечание:**

* `<path-to-your-demo-video>`: Путь к одному видео
* `[use-half]` (необязательно): Добавьте use-half в конце для включения извлечения признаков в половинной точности.

---

### 📦 Пакетный вывод

#### **Linux/macOS**


```bash
chmod +x scripts/eval_batch.sh
./scripts/eval_batch.sh <video_path> <csv_path> <save_path (optional)> [use-half]
```
#### **Windows**

Используйте эквивалентный скрипт `.bat`:


```bash
.\scripts\eval_batch.bat <video_path> <csv_path> <save_path (optional)> [use-half]
```
**Примечание:**

* `<video_path>`: Путь к корневому каталогу, содержащему все .mp4 видео для обработки (все видео должны быть одинаковой длительности).
* `<csv_path>`: CSV-файл с текстовыми подсказками для каждого видео (см. формат в `demo_test.csv`).
* `<save_path>` (необязательно): Путь для сохранения сгенерированного аудио. По умолчанию `results/features`.
* `[use-half]` (необязательно): Добавьте use-half в конце для включения извлечения признаков в половинной точности.

---

### Использование веб-интерфейса

Для интерактивной работы запустите веб-интерфейс Gradio:



```bash
python app.py
```


## 🏋️ Обучение модели

См. [`Training.md`](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/docs/Training.md)


---

## 📝 Планы TODO и на будущее
* - [ ] Выпустить более мощную базовую модель, охватывающую несколько доменов, для более увлекательного и иммерсивного создания фоли
* - [ ] Добавить поддержку дополнительных модальностей и последующих задач
* - [ ] Выпустить модели разных масштабов
* - [x] Открыть исходный датасет AudioCoT и автоматизированный конвейер
* - [x] Выпустить обучающие скрипты для моделей ThinkSound
* - [x] README для быстрого старта на Windows для новичков
---


## 📄 Лицензия

Этот проект распространяется по лицензии Apache 2.0.

> **Примечание:**
> Код, модели и датасет предназначены **только для научных и образовательных целей**.
> **Коммерческое использование НЕ разрешено.**
> Для коммерческого лицензирования, пожалуйста, свяжитесь с авторами.

**📦 Сторонние компоненты**

* **Stable Audio Open VAE** (от Stability AI):
  Этот репозиторий включает доработанный VAE из [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/), лицензированный по [лицензии Stability AI Community License](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md).
  **Коммерческое использование и распространение требуют предварительного разрешения Stability AI.**

* 📘 **Весь остальной код и модели** распространяются по лицензии Apache 2.0.

---

## Благодарности

Благодарности:

* **stable-audio-tools** (от Stability AI):
За предоставление удобной платформы для генерации аудио, а также модуля VAE и весов.
* **MMAudio**:
  За реализацию архитектуры MM-DiT в аудио-домене.

---

## 📖 Цитирование

Если ThinkSound оказался полезным для ваших исследований или работы, пожалуйста, процитируйте нашу статью:

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
```

---

## 📬 Contact


✨ Feel free to [open an issue](https://github.com/liuhuadai/ThinkSound/issues) or contact us via email ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) if you have any questions or suggestions!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-04

---
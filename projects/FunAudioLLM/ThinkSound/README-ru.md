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
  Если вы считаете этот проект полезным,<br>
  звезда ⭐ на GitHub будет очень признательна!
</p>

---

## Структура репозитория

В этом репозитории **ThinkSound** на GitHub размещены два связанных проекта на отдельных ветках:

| Ветка | Проект | Документация |
|--------|---------|----------------|
| **`master`** | **ThinkSound** (NeurIPS 2025) — унифицированная генерация Any2Audio с сопоставлением потоков, управляемым рассуждением CoT | Этот файл: **`README.md`** |
| **`prismaudio`** | **PrismAudio** — последующая работа (ICLR 2026) по преобразованию видео в аудио с многомерным CoT-RL | **`README.md`** на ветке [`prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) |

Для **ThinkSound** используйте ветку **`master`** (этот README). Для **PrismAudio** переключитесь на **`prismaudio`** и следуйте **`README.md`** там.

---

**ThinkSound** — это унифицированный фреймворк генерации Any2Audio с сопоставлением потоков, управляемым рассуждением Chain-of-Thought (CoT).

Реализация на PyTorch для мультимодальной генерации и редактирования аудио: генерируйте или редактируйте звук по видео, тексту и аудио, используя пошаговое рассуждение на базе мультимодальных больших языковых моделей (MLLMs).

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 Новости
- **2026.03.24** &nbsp; 🔥 **PrismAudio** выпущен в этом же репозитории на ветке [`prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) — смотрите **`README.md`** там для установки и моделей.
- **2026.01.26** &nbsp; 🎉 PrismAudio принят на **ICLR 2026 Main Conference** (код/документация на `prismaudio`).
- **2025.11.25** &nbsp; 🔥 [Онлайн-демо PrismAudio](http://prismaudio-project.github.io/) запущено.
- **2025.11.25** &nbsp; 🔥 [Статья по PrismAudio](https://arxiv.org/pdf/2511.18833) на arXiv — многомерный CoT-RL для преобразования видео в аудио.
- **2025.09.19** &nbsp; 🎉 **ThinkSound** принят на **NeurIPS 2025 Main Conference**!
- **2025.09.01** &nbsp; Наш датасет AudioCoT теперь с открытым исходным кодом и доступен на [Hugging Face](https://huggingface.co/datasets/liuhuadai/AudioCoT)!
- **2025.07.17** &nbsp; 🧠 Доступно дообучение: код для обучения и дообучения теперь в открытом доступе, с подробной инструкцией для быстрой настройки и расширения ThinkSound под ваши данные.
- **2025.07.15** &nbsp; 📦 Упрощённая установка и использование: зависимости на PyPI для быстрой настройки на разных платформах; Windows `.bat`-скрипты автоматизируют создание окружения и запуск сценариев.
- **2025.07.08** &nbsp;  🔧 Крупное обновление: модель облегчена и оптимизирована по памяти и использованию GPU, теперь поддерживает масштабную генерацию аудио!
- **2025.07.01** &nbsp; Онлайн-демо на [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) и [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) для интерактивного опыта!
- **2025.07.01** &nbsp; Выпущены скрипты для инференса и веб-интерфейс;
- **2025.06** &nbsp; [Статья по ThinkSound](https://arxiv.org/pdf/2506.21448) опубликована на arXiv!
- **2025.06** &nbsp; [Онлайн-демо](http://thinksound-project.github.io/) запущено — попробуйте прямо сейчас!

---


<div align="center">

### Продолжение: PrismAudio (тот же репозиторий, ветка `prismaudio`)

**PrismAudio** является преемником ThinkSound (ICLR 2026), разработан под новым названием, но хранится в этом репозитории в ветке **`prismaudio`**. Инструкции по установке, контрольные точки и цитирование находятся в файле **[`README.md` на этой ветке](https://github.com/liuhuadai/ThinkSound/blob/prismaudio/README.md)**.

👉 [`git checkout prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) или откройте ветку на GitHub.

</div>

---


## 🚀 Возможности

- **Any2Audio**: Генерация аудио из любых модальностей — видео, текста, аудио или их комбинаций.
- **Video-to-Audio SOTA**: Достигает передовых результатов на нескольких V2A-бенчмарках.
- **CoT-Driven Reasoning**: Многошаговое рассуждение для композиционной и управляемой генерации аудио с помощью MLLM.
- **Интерактивное объектно-ориентированное редактирование**: Улучшение или редактирование конкретных звуковых событий по клику на визуальные объекты или с использованием текстовых инструкций.
- **Единая структура**: Одна базовая модель поддерживает генерацию, редактирование и интерактивный рабочий процесс.

---

## ✨ Обзор метода

ThinkSound разбивает генерацию и редактирование аудио на три интерактивные стадии, все они управляются многошаговым рассуждением (CoT) на базе MLLM:

1. **Генерация звукового фона:** Создание базовых, семантически и временно согласованных звуковых пейзажей из видео.
2. **Объектно-ориентированное уточнение:** Улучшение или добавление звуков для выбранных пользователем объектов через клики или выделение областей на видео.
3. **Целенаправленное аудио-редактирование:** Изменение сгенерированного аудио с помощью высокоуровневых инструкций на естественном языке.

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- Для обучения модуля рассуждений и единой базовой аудиомодели используется масштабный CoT-аннотированный датасет (**AudioCoT**).
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ Быстрый старт

**Подготовка среды:**
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


## 📄 Лицензия

Этот проект распространяется по лицензии Apache 2.0.

> **Примечание:**
> Код, модели и датасет предназначены **только для исследовательских и образовательных целей**.
> **Коммерческое использование НЕ разрешено.**
> Для получения коммерческой лицензии свяжитесь с авторами.

**📦 Сторонние компоненты**

* **Stable Audio Open VAE** (от Stability AI):
  Этот репозиторий включает дообученный VAE из [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/), лицензированный по [Stability AI Community License](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md).
  **Коммерческое использование и распространение требуют предварительного разрешения от Stability AI.**

* 📘 **Весь остальной код и модели** распространяются по лицензии Apache 2.0.

---

## Благодарности

Большое спасибо:

* **stable-audio-tools** (от Stability AI):
За предоставление удобного фреймворка для генерации аудио, а также за модуль VAE и веса.
* **MMAudio**:
  За реализацию MM-DiT-бэкенда в аудио-домене.

---



## 📖 Цитирование

Если наш проект оказался полезен для ваших исследований или работы, пожалуйста, цитируйте нашу статью:

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
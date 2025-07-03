# 🎶 ThinkSound

<p align="center">
  Если этот проект оказался для вас полезным, буду признателен за звезду ⭐ на GitHub!
</p>

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

---

**ThinkSound** — это унифицированная система генерации Any2Audio с согласованием потоков, управляемая цепочкой рассуждений (Chain-of-Thought, CoT).

Реализация на PyTorch для мультимодальной генерации и редактирования аудио: создание или редактирование аудио по видео, тексту и аудио с поддержкой пошагового рассуждения на основе мультимодальных больших языковых моделей (MLLMs).

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 Новости
- **2025.07** &nbsp; 🔥Онлайн-демо на [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) и [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) для интерактивного опыта!
- **2025.07** &nbsp; 🔥Выпущены скрипты для инференса и веб-интерфейс;
- **2025.06** &nbsp; 🔥[Статья о ThinkSound](https://arxiv.org/pdf/2506.21448) опубликована на arXiv!
- **2025.06** &nbsp; 🔥[Онлайн-демо](http://thinksound-project.github.io/) доступно — попробуйте прямо сейчас!

---

## 🚀 Возможности

- **Any2Audio**: Генерация аудио из любых модальностей — видео, текста, аудио или их комбинаций.
- **Video-to-Audio SOTA**: Достигает передовых результатов на нескольких бенчмарках V2A.
- **CoT-управляемое рассуждение**: Генерация аудио с цепочкой рассуждений для композиционного и управляемого процесса на базе MLLM.
- **Интерактивное редактирование объектов**: Улучшайте или редактируйте отдельные звуковые события, кликая по визуальным объектам или используя текстовые инструкции.
- **Унифицированный фреймворк**: Одна базовая модель поддерживает генерацию, редактирование и интерактивную работу.

---

## ✨ Обзор метода

ThinkSound разделяет генерацию и редактирование аудио на три интерактивные стадии, все они управляются цепочкой рассуждений на основе MLLM (CoT):

1. **Генерация фоли**: Создание базовых, семантически и временно согласованных звуковых ландшафтов по видео.
2. **Объектно-ориентированная доработка**: Уточнение или добавление звуков для выбранных пользователем объектов через клики или выделение областей на видео.
3. **Таргетированное аудиоредактирование**: Модификация сгенерированного аудио с помощью высокоуровневых инструкций на естественном языке.

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- Для обучения модуля рассуждения и унифицированной базовой аудиомодели используется крупномасштабный CoT-аннотированный датасет (**AudioCoT**).
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ Быстрый старт

**Подготовка среды:**
```bash
git clone https://github.com/liuhuadai/ThinkSound.git
cd ThinkSound
pip install -r requirements.txt
conda install -y -c conda-forge 'ffmpeg<7'
# Скачайте предобученные веса https://huggingface.co/liuhuadai/ThinkSound в папку ckpts/
# веса модели также можно скачать с https://www.modelscope.cn/models/iic/ThinkSound
git lfs install
git clone https://huggingface.co/liuhuadai/ThinkSound ckpts
```

**Сделайте файл исполняемым**
```bash
chmod +x scripts/demo.sh
```

**Запустите скрипт**
```bash
./scripts/demo.sh <video_path> <caption> <CoT description>
```


### Использование веб-интерфейса

Для интерактивной работы запустите веб-интерфейс Gradio:

```bash
python app.py
```

---
## 📝 TODO

- ☐ Выпустить обучающие скрипты для моделей ThinkSound
- ☐ Открыть исходный код датасета AudioCoT и автоматизированного пайплайна
- ☐ Предоставить подробную документацию и справочник по API
- ☐ Добавить поддержку дополнительных модальностей и последующих задач

---

## 📄 Лицензия

Этот проект распространяется под [лицензией Apache 2.0](LICENSE).

> **Примечание:**  
> Код, модели и датасет предназначены **только для исследовательских и образовательных целей**.  
> **Коммерческое использование НЕ разрешено.**
>
> Для получения коммерческой лицензии, пожалуйста, свяжитесь с авторами.

---

## 📖 Цитирование

Если ThinkSound оказался полезен в ваших исследованиях или работе, пожалуйста, процитируйте нашу статью:

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

## 📬 Контакты

✨ Не стесняйтесь [создать issue](https://github.com/liuhuadai/ThinkSound/issues) или связаться с нами по электронной почте ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)), если у вас есть вопросы или предложения!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---
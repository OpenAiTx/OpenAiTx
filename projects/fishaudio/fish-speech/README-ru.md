<div align="center">
<h1>Fish Speech</h1>

**Английский** | [简体中文](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/README.zh.md) | [Португальский](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/README.pt-BR.md) | [Японский](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/README.ja.md) | [Корейский](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/README.ko.md) <br>

<a href="https://www.producthunt.com/posts/fish-speech-1-4?embed=true&utm_source=badge-featured&utm_medium=badge&utm_souce=badge-fish&#0045;speech&#0045;1&#0045;4" target="_blank">
    <img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=488440&theme=light" alt="Fish&#0032;Speech&#0032;1&#0046;4 - Open&#0045;Source&#0032;Multilingual&#0032;Text&#0045;to&#0045;Speech&#0032;with&#0032;Voice&#0032;Cloning | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" />
</a>
<a href="https://trendshift.io/repositories/7014" target="_blank">
    <img src="https://trendshift.io/api/badge/repositories/7014" alt="fishaudio%2Ffish-speech | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/>
</a>
<br>
</div>
<br>

<div align="center">
    <img src="https://count.getloli.com/get/@fish-speech?theme=asoul" /><br>
</div>

<br>

<div align="center">
    <a target="_blank" href="https://discord.gg/Es5qTB9BcN">
        <img alt="Discord" src="https://img.shields.io/discord/1214047546020728892?color=%23738ADB&label=Discord&logo=discord&logoColor=white&style=flat-square"/>
    </a>
    <a target="_blank" href="https://hub.docker.com/r/fishaudio/fish-speech">
        <img alt="Docker" src="https://img.shields.io/docker/pulls/fishaudio/fish-speech?style=flat-square&logo=docker"/>
    </a>
    <a target="_blank" href="https://pd.qq.com/s/bwxia254o">
      <img alt="QQ Channel" src="https://img.shields.io/badge/QQ-blue?logo=tencentqq">
    </a>
</div>

<div align="center">
    <a target="_blank" href="https://huggingface.co/spaces/TTS-AGI/TTS-Arena-V2">
      <img alt="TTS-Arena2 Score" src="https://img.shields.io/badge/TTS_Arena2-Rank_%231-gold?style=flat-square&logo=trophy&logoColor=white">
    </a>
    <a target="_blank" href="https://huggingface.co/spaces/fishaudio/fish-speech-1">
        <img alt="Huggingface" src="https://img.shields.io/badge/🤗%20-space%20demo-yellow"/>
    </a>
    <a target="_blank" href="https://huggingface.co/fishaudio/openaudio-s1-mini">
        <img alt="HuggingFace Model" src="https://img.shields.io/badge/🤗%20-models-orange"/>
    </a>
</div>

> [!IMPORTANT]
> **Лицензионное уведомление**  
> Этот репозиторий распространяется под **лицензией Apache**, а все веса моделей под **лицензией CC-BY-NC-SA-4.0**. См. подробнее в [LICENSE](https://raw.githubusercontent.com/fishaudio/fish-speech/main/LICENSE).

> [!WARNING]
> **Юридический отказ от ответственности**  
> Мы не несем ответственности за любое незаконное использование данного репозитория. Пожалуйста, ознакомьтесь с местными законами о DMCA и другими соответствующими нормами.

---

## 🎉 Анонс

Мы рады сообщить, что мы переименовались в **OpenAudio** — представляя революционную новую серию продвинутых моделей преобразования текста в речь, основанных на Fish-Speech.

Мы с гордостью представляем **OpenAudio-S1** — первую модель в этой серии, предоставляющую значительные улучшения в качестве, производительности и возможностях.

OpenAudio-S1 доступен в двух версиях: **OpenAudio-S1** и **OpenAudio-S1-mini**. Обе модели теперь доступны на [Fish Audio Playground](https://fish.audio) (для **OpenAudio-S1**) и на [Hugging Face](https://huggingface.co/fishaudio/openaudio-s1-mini) (для **OpenAudio-S1-mini**).

Посетите [сайт OpenAudio](https://openaudio.com/blogs/s1) для блога и технического отчёта.

## Основные возможности ✨

### **Отличное качество TTS**

Мы используем Seed TTS Eval Metrics для оценки производительности модели, и результаты показывают, что OpenAudio S1 достигает **0.008 WER** и **0.004 CER** на английском языке, что значительно лучше предыдущих моделей. (Английский, автооценка, основано на OpenAI gpt-4o-transcribe, расстояние между голосами с помощью Revai/pyannote-wespeaker-voxceleb-resnet34-LM)

| Модель | Word Error Rate (WER) | Character Error Rate (CER) | Speaker Distance |
|--------|----------------------|---------------------------|------------------|
| **S1** | **0.008**  | **0.004**  | **0.332** |
| **S1-mini** | **0.011** | **0.005** | **0.380** |

### **Лучшая модель на TTS-Arena2** 🏆

OpenAudio S1 заняла **1-е место** на [TTS-Arena2](https://arena.speechcolab.org/), эталонном бенчмарке для оценки синтеза речи:

<div align="center">
    <img src="https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/assets/Elo.jpg" alt="TTS-Arena2 Ranking" style="width: 75%;" />
</div>

### **Управление речью**

OpenAudio S1 **поддерживает различные эмоции, интонационные и специальные маркеры** для улучшения синтеза речи:

- **Базовые эмоции**:
```
(angry) (sad) (excited) (surprised) (satisfied) (delighted) 
(scared) (worried) (upset) (nervous) (frustrated) (depressed)
(empathetic) (embarrassed) (disgusted) (moved) (proud) (relaxed)
(grateful) (confident) (interested) (curious) (confused) (joyful)
```

- **Продвинутые эмоции**:
```
(disdainful) (unhappy) (anxious) (hysterical) (indifferent) 
(impatient) (guilty) (scornful) (panicked) (furious) (reluctant)
(keen) (disapproving) (negative) (denying) (astonished) (serious)
(sarcastic) (conciliative) (comforting) (sincere) (sneering)
(hesitating) (yielding) (painful) (awkward) (amused)
```

- **Интонационные маркеры**:
```
(in a hurry tone) (shouting) (screaming) (whispering) (soft tone)
```

- **Спецэффекты аудио**:
```
(laughing) (chuckling) (sobbing) (crying loudly) (sighing) (panting)
(groaning) (crowd laughing) (background laughter) (audience laughing)
```

Вы также можете использовать Ha,ha,ha для управления, есть много других случаев для самостоятельного изучения.

(Поддержка английского, китайского и японского языков сейчас, больше языков появится скоро!)

### **Два типа моделей**

| Модель | Размер | Доступность | Особенности |
|--------|--------|-------------|-------------|
| **S1** | 4B параметров | Доступна на [fish.audio](https://fish.audio) | Полнофункциональная флагманская модель |
| **S1-mini** | 0.5B параметров | Доступна на huggingface [hf space](https://huggingface.co/spaces/fishaudio/openaudio-s1-mini) | Дистиллированная версия с основными возможностями |

Обе модели S1 и S1-mini используют онлайн-обучение с подкреплением от обратной связи человека (RLHF).

## **Возможности**

1. **Zero-shot & Few-shot TTS:** Дайте голосовой образец длиной 10–30 секунд, чтобы сгенерировать высококачественный синтез речи. **Подробные рекомендации см. в [Voice Cloning Best Practices](https://docs.fish.audio/text-to-speech/voice-clone-best-practices).**

2. **Мультиязычная и кросс-языковая поддержка:** Просто скопируйте и вставьте многоязычный текст в поле ввода — не нужно беспокоиться о языке. В настоящий момент поддерживаются английский, японский, корейский, китайский, французский, немецкий, арабский и испанский.

3. **Без зависимости от фонем:** Модель обладает высокой способностью к обобщению и не зависит от фонем для синтеза речи. Она может обрабатывать текст на любом языке.

4. **Высокая точность:** CER (Character Error Rate) около 0,4% и WER (Word Error Rate) около 0,8% для Seed-TTS Eval.

5. **Быстрота:** Благодаря fish-tech ускорению, коэффициент реального времени примерно 1:5 на Nvidia RTX 4060 Laptop и 1:15 на Nvidia RTX 4090.

6. **WebUI-инференс:** Удобный веб-интерфейс на основе Gradio, совместимый с Chrome, Firefox, Edge и другими браузерами.

7. **GUI-инференс:** Графический интерфейс на PyQt6, полностью совместим с API-сервером. Поддержка Linux, Windows и macOS. [Смотреть GUI](https://github.com/AnyaCoder/fish-speech-gui).

8. **Простота развертывания:** Легко разверните сервер инференса с нативной поддержкой Linux, Windows (MacOS скоро будет), минимизируя потери в скорости.

## **Медиа и демо**

<div align="center">

### **Социальные сети**
<a href="https://x.com/FishAudio/status/1929915992299450398" target="_blank">
    <img src="https://img.shields.io/badge/𝕏-Latest_Demo-black?style=for-the-badge&logo=x&logoColor=white" alt="Latest Demo on X" />
</a>

### **Интерактивные демо**
<a href="https://fish.audio" target="_blank">
    <img src="https://img.shields.io/badge/Fish_Audio-Try_OpenAudio_S1-blue?style=for-the-badge" alt="Try OpenAudio S1" />
</a>
<a href="https://huggingface.co/spaces/fishaudio/openaudio-s1-mini" target="_blank">
    <img src="https://img.shields.io/badge/Hugging_Face-Try_S1_Mini-yellow?style=for-the-badge" alt="Try S1 Mini" />
</a>

### **Видеопримеры**

<a href="https://www.youtube.com/watch?v=SYuPvd7m06A" target="_blank">
    <img src="https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/assets/Thumbnail.jpg" alt="OpenAudio S1 Video" style="width: 50%;" />
</a>

### **Аудиопримеры**
<div style="margin: 20px 0;">
    <em> Скоро появятся аудиопримеры высокого качества, демонстрирующие наши мультиязычные возможности TTS для различных языков и эмоций.</em>
</div>

</div>

---

## Документация

- [Build Envrionment](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/en/install.md)
- [Inference](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/en/inference.md)

## Благодарности

- [VITS2 (daniilrobnikov)](https://github.com/daniilrobnikov/vits2)
- [Bert-VITS2](https://github.com/fishaudio/Bert-VITS2)
- [GPT VITS](https://github.com/innnky/gpt-vits)
- [MQTTS](https://github.com/b04901014/MQTTS)
- [GPT Fast](https://github.com/pytorch-labs/gpt-fast)
- [GPT-SoVITS](https://github.com/RVC-Boss/GPT-SoVITS)
- [Qwen3](https://github.com/QwenLM/Qwen3)

## Технический отчет (V1.4)
```bibtex
@misc{fish-speech-v1.4,
      title={Fish-Speech: Leveraging Large Language Models for Advanced Multilingual Text-to-Speech Synthesis},
      author={Shijia Liao and Yuxuan Wang and Tianyu Li and Yifan Cheng and Ruoyi Zhang and Rongzhi Zhou and Yijin Xing},
      year={2024},
```
      eprint={2411.01156},
      archivePrefix={arXiv},
      primaryClass={cs.SD},
      url={https://arxiv.org/abs/2411.01156},
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---
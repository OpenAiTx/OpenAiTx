
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# index-tts-lora

[中文版本](https://github.com/asr-pub/index-tts-lora/blob/main/README_zh.md) | [Английская версия](https://github.com/asr-pub/index-tts-lora/blob/main/README.md)

Этот проект основан на Bilibili [index-tts](https://github.com/index-tts/index-tts) и предоставляет решения для **тонкой настройки LoRA** для **одного и нескольких дикторов**. Он направлен на улучшение **просодии и естественности** при синтезе высококачественного аудио голоса.

### Обучение и инференс

#### 1. Извлечение аудиотокенов и условий диктора

```shell
# Extract tokens and speaker conditions
python tools/extract_codec.py --audio_list ${audio_list} --extract_condition

# audio_list format: audio_path + transcript, separated by \t
/path/to/audio.wav 小朋友们，大家好，我是凯叔，今天我们讲一个龟兔赛跑的故事。
```

После извлечения обработанные файлы и `speaker_info.json` будут сгенерированы в директории `finetune_data/processed_data/`. Например:

```json
[
    {
        "speaker": "kaishu_30min",
        "avg_duration": 6.6729,
        "sample_num": 270,
        "total_duration_in_seconds": 1801.696,
        "total_duration_in_minutes": 30.028,
        "total_duration_in_hours": 0.500,
        "train_jsonl": "/path/to/kaishu_30min/metadata_train.jsonl",
        "valid_jsonl": "/path/to/kaishu_30min/metadata_valid.jsonl",
        "medoid_condition": "/path/to/kaishu_30min/medoid_condition.npy"
    }
]
```

#### 2. Обучение

```shell
python train.py
```

#### 3. Инференция

```shell
python indextts/infer.py
```

### Результаты дообучения

В этом эксперименте используется **китайская аудиодата** из *Кай Шу рассказывает истории*, с общей продолжительностью **\~30 минут** и **270 аудиофрагментов**.
Датасет разделён на **244 обучающих образца** и **26 валидационных образцов**.
Примечание: расшифровки были сгенерированы автоматически с помощью ASR и моделей пунктуации, без ручной корректировки, поэтому возможны ошибки.

Пример обучающего образца, `他上了马车，来到了皇宫之中。`：[kaishu_train_01.wav](https://github.com/user-attachments/files/22354621/kaishu_train_01.wav)


#### 1. Примеры синтеза речи


| Текст                                                        | Аудио                                                        |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| Часы в старом доме остановились на три часа ночи, в пыли проявилась цепочка незнакомых следов. Детектив присел и обнаружил в щели пола окровавленное кольцо. | [kaishu_cn_1.wav](https://github.com/user-attachments/files/22354649/kaishu_cn_1.wav) |
| Под лунным светом на тыкве вдруг появилась улыбка, плети изогнулись и распахнули садовую калитку. Девочка встала на цыпочки и услышала, как грибы напевают древнюю колыбельную. | [kaishu_cn_2.wav](https://github.com/user-attachments/files/22354652/kaishu_cn_2.wav) |
| Так в Java на среднем уровне ещё нужно учить, M и разработку внешних фронтенд-приложений, нужно изучить базу данных Java Script и научиться делать динамические сайты. | [kaishu_cn_en_mix_1.wav](https://github.com/user-attachments/files/22354654/kaishu_cn_en_mix_1.wav) |
| Этот financial report подробно анализирует revenue performance и expenditure trends компании за прошлый квартал. | [kaishu_cn_en_mix_2.wav](https://github.com/user-attachments/files/22354656/kaishu_cn_en_mix_2.wav) |
| Вверх по горе, вниз по горе, одна гора, другая гора, пробежал три ли три ми три, взобрался на большую гору, высота горы триста три. Взобрался на гору и громко крикнул: я выше горы на три чи три. | [kaishu_raokouling.wav](https://github.com/user-attachments/files/22354658/kaishu_raokouling.wav) |
| A thin man lies against the side of the street with his shirt and a shoe off and bags nearby. | [kaishu_en_1.wav](https://github.com/user-attachments/files/22354659/kaishu_en_1.wav) |
| As research continued, the protective effect of fluoride against dental decay was demonstrated. | [kaishu_en_2.wav](https://github.com/user-attachments/files/22354661/kaishu_en_2.wav) |

#### 2. Оценка модели
Подробнее о наборе для оценки см.: [2025 Benchmark of Mainstream TTS Models: Who Is the Best Voice Synthesis Solution?](https://mp.weixin.qq.com/s/5z_aRKQG3OIv7fnSdxegqQ)
<img width="1182" height="261" alt="image" src="https://github.com/user-attachments/assets/fb86938d-95d9-4b10-9588-2de1e43b51d1" />

### Благодарности

[index-tts](https://github.com/index-tts/index-tts)

[finetune-index-tts](https://github.com/yrom/finetune-index-tts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-16

---
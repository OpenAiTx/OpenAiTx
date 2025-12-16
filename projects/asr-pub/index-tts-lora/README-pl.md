
<div align="right">
  <details>
    <summary >🌐 Język</summary>
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

[Wersja chińska](https://github.com/asr-pub/index-tts-lora/blob/main/README_zh.md) | [Wersja angielska](https://github.com/asr-pub/index-tts-lora/blob/main/README.md)

Projekt ten bazuje na [index-tts](https://github.com/index-tts/index-tts) z Bilibili i oferuje rozwiązania do **strojenia LoRA** zarówno dla **pojedynczego mówcy, jak i wielu mówców**. Celem jest poprawa **prozodii i naturalności** w syntezie wysokiej jakości dźwięku mówców.

### Trening i wnioskowanie

#### 1. Ekstrakcja tokenu audio i warunków mówcy

```shell
# Extract tokens and speaker conditions
python tools/extract_codec.py --audio_list ${audio_list} --extract_condition

# audio_list format: audio_path + transcript, separated by \t
/path/to/audio.wav 小朋友们，大家好，我是凯叔，今天我们讲一个龟兔赛跑的故事。
```

Po ekstrakcji, przetworzone pliki oraz `speaker_info.json` zostaną wygenerowane w katalogu `finetune_data/processed_data/`. Na przykład:

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

#### 2. Szkolenie

```shell
python train.py
```

#### 3. Wnioskowanie

```shell
python indextts/infer.py
```

### Wyniki dostrajania

W tym eksperymencie wykorzystano **chińskie dane audio** z *Kai Shu Tells Stories*, o łącznym czasie trwania **~30 minut** i **270 klipach audio**.
Zbiór danych został podzielony na **244 próbki treningowe** oraz **26 próbek walidacyjnych**.
Uwaga: Transkrypcje zostały wygenerowane automatycznie za pomocą modeli ASR i interpunkcyjnych, bez ręcznej korekty, więc mogą wystąpić pewne błędy.

Przykładowa próbka treningowa, `他上了马车，来到了皇宫之中。`：[kaishu_train_01.wav](https://github.com/user-attachments/files/22354621/kaishu_train_01.wav)


#### 1. Przykłady syntezy mowy


| Tekst                                                         | Audio                                                        |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| Zegar w starej rezydencji zatrzymał się o trzeciej w nocy, a w kurzu pojawiły się obce ślady stóp. Detektyw przykucnął i odkrył zakrwawiony pierścionek ukryty w szczelinie podłogi. | [kaishu_cn_1.wav](https://github.com/user-attachments/files/22354649/kaishu_cn_1.wav) |
| W blasku księżyca dynia nagle wyrosła z uśmiechniętą twarzą, a jej pnącza otworzyły furtkę do ogrodu. Dziewczynka stanęła na palcach, słysząc jak grzyby nucą starą kołysankę. | [kaishu_cn_2.wav](https://github.com/user-attachments/files/22354652/kaishu_cn_2.wav) |
| W Javie na poziomie średniozaawansowanym trzeba się nauczyć, a także zewnętrznego rozwoju systemów front-endowych, trzeba poznać bazę danych Java Script i nauczyć się tworzyć dynamiczne strony internetowe. | [kaishu_cn_en_mix_1.wav](https://github.com/user-attachments/files/22354654/kaishu_cn_en_mix_1.wav) |
| Ten financial report szczegółowo analizuje wyniki revenue performance oraz trendy wydatków firmy w ostatnim kwartale. | [kaishu_cn_en_mix_2.wav](https://github.com/user-attachments/files/22354656/kaishu_cn_en_mix_2.wav) |
| Wchodzi na górę, schodzi z góry na kolejną górę, przebiegł trzy li trzy mi trzy, zdobył wysoką górę o wysokości trzysta trzy. Wszedł na górę i krzyknął: jestem o trzy stopy wyższy niż góra. | [kaishu_raokouling.wav](https://github.com/user-attachments/files/22354658/kaishu_raokouling.wav) |
| A thin man lies against the side of the street with his shirt and a shoe off and bags nearby. | [kaishu_en_1.wav](https://github.com/user-attachments/files/22354659/kaishu_en_1.wav) |
| As research continued, the protective effect of fluoride against dental decay was demonstrated. | [kaishu_en_2.wav](https://github.com/user-attachments/files/22354661/kaishu_en_2.wav) |

#### 2. Ocena modelu
Szczegóły zbioru ewaluacyjnego: [2025 Benchmark of Mainstream TTS Models: Who Is the Best Voice Synthesis Solution?](https://mp.weixin.qq.com/s/5z_aRKQG3OIv7fnSdxegqQ)
<img width="1182" height="261" alt="image" src="https://github.com/user-attachments/assets/fb86938d-95d9-4b10-9588-2de1e43b51d1" />

### Podziękowania

[index-tts](https://github.com/index-tts/index-tts)

[finetune-index-tts](https://github.com/yrom/finetune-index-tts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-16

---
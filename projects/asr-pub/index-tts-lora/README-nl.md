
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=zh-CN">Vereenvoudigd Chinees</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=zh-TW">Traditioneel Chinees</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=ja">Japans</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=ko">Koreaans</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=th">Thais</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=fa">Perzisch</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=id">Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=as">Assamees</
      </div>
    </div>
  </details>

</div>

# index-tts-lora

[Chinese versie](https://github.com/asr-pub/index-tts-lora/blob/main/README_zh.md) | [Engelse versie](https://github.com/asr-pub/index-tts-lora/blob/main/README.md)

Dit project is gebaseerd op Bilibili's [index-tts](https://github.com/index-tts/index-tts), en biedt **LoRA fine-tuning** oplossingen voor zowel **enkelvoudige als meervoudige spreker**-instellingen. Het is gericht op het verbeteren van **prosodie en natuurlijkheid** in hoogwaardige spraaksynthese.

### Training & Inferentie

#### 1. Extractie van audiotokens en sprekerconditie

```shell
# Extract tokens and speaker conditions
python tools/extract_codec.py --audio_list ${audio_list} --extract_condition

# audio_list format: audio_path + transcript, separated by \t
/path/to/audio.wav 小朋友们，大家好，我是凯叔，今天我们讲一个龟兔赛跑的故事。
```

Na extractie worden de verwerkte bestanden en `speaker_info.json` gegenereerd in de map `finetune_data/processed_data/`. Bijvoorbeeld:

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

#### 2. Training

```shell
python train.py
```

#### 3. Inferentie

```shell
python indextts/infer.py
```

### Resultaten van Fijn-afstemming

Dit experiment maakt gebruik van **Chinese audiogegevens** uit *Kai Shu Vertelt Verhalen*, met een totale duur van **\~30 minuten** en **270 audioclips**.
De dataset is opgesplitst in **244 trainingsmonsters** en **26 validatiemonsters**.
Opmerking: Transcripties zijn automatisch gegenereerd via ASR- en interpunctiemodellen, zonder handmatige correctie, dus enige fouten worden verwacht.

Voorbeeld trainingsmonster, `他上了马车，来到了皇宫之中。`：[kaishu_train_01.wav](https://github.com/user-attachments/files/22354621/kaishu_train_01.wav)


#### 1. Voorbeelden van Spraaksynthese


| Tekst                                                        | Audio                                                        |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| De klok in het oude huis stond stil om middernacht, in het stof verscheen een reeks onbekende voetafdrukken. De detective hurkte neer en vond een bebloede ring in de kier van de vloer. | [kaishu_cn_1.wav](https://github.com/user-attachments/files/22354649/kaishu_cn_1.wav) |
| In het maanlicht verscheen er plots een lachend gezicht op de pompoen, de ranken kronkelden en openden het tuinhek. Het meisje ging op haar tenen staan en hoorde de paddenstoelen een oud wiegelied neuriën. | [kaishu_cn_2.wav](https://github.com/user-attachments/files/22354652/kaishu_cn_2.wav) |
| Dus in Java moet je op gemiddeld niveau ook leren over M en over het ontwikkelen van externe frontend-applicatiesystemen, je moet leren over Java Script-databases en dynamische websites bouwen. | [kaishu_cn_en_mix_1.wav](https://github.com/user-attachments/files/22354654/kaishu_cn_en_mix_1.wav) |
| Dit financial report analyseert in detail de revenue performance en expenditure trends van het bedrijf in het afgelopen kwartaal. | [kaishu_cn_en_mix_2.wav](https://github.com/user-attachments/files/22354656/kaishu_cn_en_mix_2.wav) |
| De berg op, de berg af, de ene berg op, de volgende berg af, drie li en drie meter gerend, een hoge berg beklommen, de berg is driehonderd drie hoog. Boven op de berg riep hij hard: Ik ben drie chi en drie hoger dan de berg! | [kaishu_raokouling.wav](https://github.com/user-attachments/files/22354658/kaishu_raokouling.wav) |
| A thin man lies against the side of the street with his shirt and a shoe off and bags nearby. | [kaishu_en_1.wav](https://github.com/user-attachments/files/22354659/kaishu_en_1.wav) |
| As research continued, the protective effect of fluoride against dental decay was demonstrated. | [kaishu_en_2.wav](https://github.com/user-attachments/files/22354661/kaishu_en_2.wav) |

#### 2. Model Evaluatie
<img width="1182" height="261" alt="image" src="https://github.com/user-attachments/assets/fb86938d-95d9-4b10-9588-2de1e43b51d1" />

### Dankbetuigingen

[index-tts](https://github.com/index-tts/index-tts)

[finetune-index-tts](https://github.com/yrom/finetune-index-tts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-28

---
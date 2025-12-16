
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
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

[Chinese versie](https://github.com/asr-pub/index-tts-lora/blob/main/README_zh.md) | [Engelse versie](https://github.com/asr-pub/index-tts-lora/blob/main/README.md)

Dit project is gebaseerd op Bilibili's [index-tts](https://github.com/index-tts/index-tts), en biedt **LoRA fine-tuning** oplossingen voor zowel **enkelvoudige als meervoudige spreker** configuraties. Het is gericht op het verbeteren van **prosodie en natuurlijkheid** in hoogwaardige spraaksynthese van sprekers.

### Training & Inferentie

#### 1. Extractie van audiotoken en sprekerconditie

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

### Resultaten van het Fijn-afstemmen

Dit experiment maakt gebruik van **Chinese audiogegevens** van *Kai Shu Tells Stories*, met een totale duur van **\~30 minuten** en **270 audioclips**.
De dataset is opgesplitst in **244 trainingssamples** en **26 validatiesamples**.
Opmerking: Transcripties zijn automatisch gegenereerd via ASR- en interpunctiemodellen, zonder handmatige correctie, dus enige fouten worden verwacht.

Voorbeeld trainingssample, `他上了马车，来到了皇宫之中。`：[kaishu_train_01.wav](https://github.com/user-attachments/files/22354621/kaishu_train_01.wav)


#### 1. Voorbeelden van Spraaksynthese


| Tekst                                                         | Audio                                                        |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| De klok in het oude huis bleef stilstaan om drie uur 's nachts, en in het stof verscheen een reeks onbekende voetafdrukken. De detective hurkte neer en vond een met bloed besmeurde ring in de kier van de vloer. | [kaishu_cn_1.wav](https://github.com/user-attachments/files/22354649/kaishu_cn_1.wav) |
| In het maanlicht verscheen er opeens een lachend gezicht op de pompoen, en de ranken duwden het tuinhek open. Het meisje ging op haar tenen staan en hoorde de paddenstoelen een oud wiegelied neuriën. | [kaishu_cn_2.wav](https://github.com/user-attachments/files/22354652/kaishu_cn_2.wav) |
| Dus in Java moet je op gemiddeld niveau nog leren, en tot externe frontend-applicatiesystemen ontwikkelen, databases leren met Java Script, en leren om dynamische websites te maken. | [kaishu_cn_en_mix_1.wav](https://github.com/user-attachments/files/22354654/kaishu_cn_en_mix_1.wav) |
| Dit financial report analyseert in detail de revenue performance en expenditure trends van het bedrijf in het afgelopen kwartaal. | [kaishu_cn_en_mix_2.wav](https://github.com/user-attachments/files/22354656/kaishu_cn_en_mix_2.wav) |
| Heuvel op, heuvel af, ene berg op, de andere berg af, drie li en drie meter rennend, beklom een hoge berg met een hoogte van driehonderd drie. Op de berg, riep luid: ik ben drie chi drie hoger dan de berg. | [kaishu_raokouling.wav](https://github.com/user-attachments/files/22354658/kaishu_raokouling.wav) |
| Een magere man ligt tegen de kant van de straat, zijn overhemd en een schoen uit, en tassen ernaast. | [kaishu_en_1.wav](https://github.com/user-attachments/files/22354659/kaishu_en_1.wav) |
| Terwijl het onderzoek doorging, werd het beschermende effect van fluoride tegen tandbederf aangetoond. | [kaishu_en_2.wav](https://github.com/user-attachments/files/22354661/kaishu_en_2.wav) |

#### 2. Model Evaluatie
Voor details van de evaluatieset, zie: [2025 Benchmark van Mainstream TTS-modellen: Wie is de beste spraaksynthese-oplossing?](https://mp.weixin.qq.com/s/5z_aRKQG3OIv7fnSdxegqQ)
<img width="1182" height="261" alt="image" src="https://github.com/user-attachments/assets/fb86938d-95d9-4b10-9588-2de1e43b51d1" />

### Dankbetuigingen

[index-tts](https://github.com/index-tts/index-tts)

[finetune-index-tts](https://github.com/yrom/finetune-index-tts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-16

---
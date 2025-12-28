
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=en">Englisch</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=ja">Japanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=ko">Koreanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=th">Thailändisch</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=fr">Französisch</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=es">Spanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=it">Italienisch</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=pt">Portugiesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=nl">Niederländisch</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=pl">Polnisch</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=fa">Persisch</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=tr">Türkisch</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=vi">Vietnamesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=as">Assamesisch</
      </div>
    </div>
  </details>

</div>

# index-tts-lora

[Chinesische Version](https://github.com/asr-pub/index-tts-lora/blob/main/README_zh.md) | [Englische Version](https://github.com/asr-pub/index-tts-lora/blob/main/README.md)

Dieses Projekt basiert auf Bilibilis [index-tts](https://github.com/index-tts/index-tts) und bietet **LoRA-Feinabstimmungslösungen** sowohl für **Einzelsprecher- als auch Mehrsprechersysteme**. Ziel ist es, die **Prosodie und Natürlichkeit** bei der hochwertigen Sprachsynthese zu verbessern.

### Training & Inferenz

#### 1. Extraktion von Audio-Token und Sprecherbedingungen

```shell
# Extract tokens and speaker conditions
python tools/extract_codec.py --audio_list ${audio_list} --extract_condition

# audio_list format: audio_path + transcript, separated by \t
/path/to/audio.wav 小朋友们，大家好，我是凯叔，今天我们讲一个龟兔赛跑的故事。
```

Nach der Extraktion werden die verarbeiteten Dateien und `speaker_info.json` im Verzeichnis `finetune_data/processed_data/` erzeugt. Zum Beispiel:

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

#### 2. Training (Schulung)

```shell
python train.py
```

#### 3. Inferenz

```shell
python indextts/infer.py
```

### Feinabstimmungs-Ergebnisse

Dieses Experiment verwendet **chinesische Audiodaten** aus *Kai Shu erzählt Geschichten*, mit einer Gesamtdauer von **\~30 Minuten** und **270 Audioclips**.
Der Datensatz ist in **244 Trainingsbeispiele** und **26 Validierungsbeispiele** aufgeteilt.
Hinweis: Die Transkripte wurden automatisch mittels ASR- und Interpunktionsmodellen erstellt, ohne manuelle Korrektur. Daher sind einige Fehler zu erwarten.

Beispiel für ein Trainingsbeispiel, `他上了马车，来到了皇宫之中。`：[kaishu_train_01.wav](https://github.com/user-attachments/files/22354621/kaishu_train_01.wav)


#### 1. Sprachsynthese-Beispiele


| Text                                                         | Audio                                                        |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| Die Standuhr im alten Haus blieb um Mitternacht um drei Uhr stehen, im Staub erschien eine Reihe fremder Fußspuren. Der Detektiv kniete sich nieder und fand einen blutigen Ring in den Ritzen des Bodens. | [kaishu_cn_1.wav](https://github.com/user-attachments/files/22354649/kaishu_cn_1.wav) |
| Im Mondlicht wuchs plötzlich ein lachendes Gesicht auf dem Kürbis, Ranken drängten das Gartentor auf. Das kleine Mädchen stellte sich auf die Zehenspitzen und hörte, wie Pilze ein altes Wiegenlied summten. | [kaishu_cn_2.wav](https://github.com/user-attachments/files/22354652/kaishu_cn_2.wav) |
| Also muss man im mittleren Java-Bereich noch lernen, M sowie die Entwicklung von externen Frontend-Anwendungssystemen, die Datenbank von Java Script und die Erstellung dynamischer Webseiten. | [kaishu_cn_en_mix_1.wav](https://github.com/user-attachments/files/22354654/kaishu_cn_en_mix_1.wav) |
| Dieser financial report analysiert detailliert die revenue performance und expenditure trends des Unternehmens im letzten Quartal. | [kaishu_cn_en_mix_2.wav](https://github.com/user-attachments/files/22354656/kaishu_cn_en_mix_2.wav) |
| Bergauf, bergab, einen Berg hinauf, den nächsten hinab, drei Li und drei Meter gelaufen, einen hohen Berg bestiegen, der Berg ist dreihundertdrei Meter hoch. Oben auf dem Berg rief ich laut: Ich bin drei Chi und drei größer als der Berg. | [kaishu_raokouling.wav](https://github.com/user-attachments/files/22354658/kaishu_raokouling.wav) |
| A thin man lies against the side of the street with his shirt and a shoe off and bags nearby. | [kaishu_en_1.wav](https://github.com/user-attachments/files/22354659/kaishu_en_1.wav) |
| As research continued, the protective effect of fluoride against dental decay was demonstrated. | [kaishu_en_2.wav](https://github.com/user-attachments/files/22354661/kaishu_en_2.wav) |

#### 2. Modellevaluierung
<img width="1182" height="261" alt="image" src="https://github.com/user-attachments/assets/fb86938d-95d9-4b10-9588-2de1e43b51d1" />

### Danksagungen

[index-tts](https://github.com/index-tts/index-tts)

[finetune-index-tts](https://github.com/yrom/finetune-index-tts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-28

---
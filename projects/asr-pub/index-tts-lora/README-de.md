
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
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

[Chinesische Version](https://github.com/asr-pub/index-tts-lora/blob/main/README_zh.md) | [Englische Version](https://github.com/asr-pub/index-tts-lora/blob/main/README.md)

Dieses Projekt basiert auf Bilibilis [index-tts](https://github.com/index-tts/index-tts) und bietet **LoRA Fine-Tuning**-Lösungen sowohl für **Einzelsprecher- als auch Mehrsprecher-Setups**. Ziel ist es, die **Prosodie und Natürlichkeit** bei der hochwertigen Audio-Synthese von Sprechern zu verbessern.

### Training & Inferenz

#### 1. Extraktion von Audiotoken und Sprecherbedingungen

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

### Feinabstimmungsergebnisse

Dieses Experiment verwendet **chinesische Audiodaten** aus *Kai Shu erzählt Geschichten*, mit einer Gesamtdauer von **\~30 Minuten** und **270 Audio-Clips**.
Das Datenset ist unterteilt in **244 Trainingsbeispiele** und **26 Validierungsbeispiele**.
Hinweis: Die Transkripte wurden automatisch mittels ASR und Interpunktionsmodellen erzeugt, ohne manuelle Korrektur, daher sind einige Fehler zu erwarten.

Beispiel eines Trainingsdatensatzes, `他上了马车，来到了皇宫之中。`：[kaishu_train_01.wav](https://github.com/user-attachments/files/22354621/kaishu_train_01.wav)


#### 1. Beispiele für Sprachsynthese


| Text                                                         | Audio                                                        |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| Die Uhr im alten Haus blieb um Mitternacht um drei Uhr stehen, im Staub tauchte eine Spur fremder Fußabdrücke auf. Der Detektiv hockte sich hin und fand im Spalt des Bodens einen blutigen Ring. | [kaishu_cn_1.wav](https://github.com/user-attachments/files/22354649/kaishu_cn_1.wav) |
| Im Mondlicht bekam der Kürbis plötzlich ein lachendes Gesicht, die Ranken wanden sich und öffneten das Gartentor. Das kleine Mädchen stellte sich auf die Zehenspitzen und hörte, wie die Pilze ein uraltes Wiegenlied summten. | [kaishu_cn_2.wav](https://github.com/user-attachments/files/22354652/kaishu_cn_2.wav) |
| Also muss man im mittleren Java-Bereich noch M lernen und bis zur Entwicklung von externen Frontend-Anwendungssystemen kommen, man muss Datenbanken für Java Script lernen und dynamische Webseiten erstellen können. | [kaishu_cn_en_mix_1.wav](https://github.com/user-attachments/files/22354654/kaishu_cn_en_mix_1.wav) |
| Dieser financial report analysiert ausführlich die revenue performance und expenditure trends des Unternehmens im letzten Quartal. | [kaishu_cn_en_mix_2.wav](https://github.com/user-attachments/files/22354656/kaishu_cn_en_mix_2.wav) |
| Den Berg hinauf, den Berg hinunter, einen Berg, den nächsten Berg, drei Li und drei Meter gelaufen, einen hohen Berg bestiegen, der Berg ist 330 Meter über dem Meeresspiegel. Auf dem Berg ruft man laut: Ich bin drei Chi drei höher als der Berg. | [kaishu_raokouling.wav](https://github.com/user-attachments/files/22354658/kaishu_raokouling.wav) |
| Ein dünner Mann liegt an der Straßenseite, sein Hemd und ein Schuh sind ausgezogen, Taschen liegen in der Nähe. | [kaishu_en_1.wav](https://github.com/user-attachments/files/22354659/kaishu_en_1.wav) |
| Während die Forschung fortschritt, wurde die schützende Wirkung von Fluorid gegen Zahnkaries nachgewiesen. | [kaishu_en_2.wav](https://github.com/user-attachments/files/22354661/kaishu_en_2.wav) |

#### 2. Modellauswertung
Details zum Evaluationsset finden Sie unter: [2025 Benchmark der Mainstream-TTS-Modelle: Wer ist die beste Lösung für Sprachsynthese?](https://mp.weixin.qq.com/s/5z_aRKQG3OIv7fnSdxegqQ)
<img width="1182" height="261" alt="image" src="https://github.com/user-attachments/assets/fb86938d-95d9-4b10-9588-2de1e43b51d1" />

### Danksagungen

[index-tts](https://github.com/index-tts/index-tts)

[finetune-index-tts](https://github.com/yrom/finetune-index-tts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-16

---
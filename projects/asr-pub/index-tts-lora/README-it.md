
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
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

[Versione in Cinese](https://github.com/asr-pub/index-tts-lora/blob/main/README_zh.md) | [Versione in Inglese](https://github.com/asr-pub/index-tts-lora/blob/main/README.md)

Questo progetto si basa su [index-tts](https://github.com/index-tts/index-tts) di Bilibili, offrendo soluzioni di **LoRA fine-tuning** sia per configurazioni **single-speaker che multi-speaker**. Mira a migliorare **prosodia e naturalezza** nella sintesi vocale di alta qualità.

### Addestramento & Inferenza

#### 1. Estrazione del token audio e della condizione dell'oratore

```shell
# Extract tokens and speaker conditions
python tools/extract_codec.py --audio_list ${audio_list} --extract_condition

# audio_list format: audio_path + transcript, separated by \t
/path/to/audio.wav 小朋友们，大家好，我是凯叔，今天我们讲一个龟兔赛跑的故事。
```

Dopo l'estrazione, i file elaborati e `speaker_info.json` saranno generati nella directory `finetune_data/processed_data/`. Ad esempio:

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

#### 2. Addestramento

```shell
python train.py
```

#### 3. Inferenza

```shell
python indextts/infer.py
```

### Risultati del Fine-tuning

Questo esperimento utilizza **dati audio cinesi** da *Kai Shu Tells Stories*, con una durata totale di **\~30 minuti** e **270 clip audio**.
Il dataset è suddiviso in **244 campioni di training** e **26 campioni di validazione**.
Nota: Le trascrizioni sono state generate automaticamente tramite modelli ASR e di punteggiatura, senza correzione manuale, quindi sono previsti alcuni errori.

Esempio di campione di training, `他上了马车，来到了皇宫之中。`：[kaishu_train_01.wav](https://github.com/user-attachments/files/22354621/kaishu_train_01.wav)


#### 1. Esempi di Sintesi Vocale


| Testo                                                        | Audio                                                        |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| L’orologio della vecchia casa si è fermato alle tre di notte e tra la polvere appare una fila di impronte sconosciute. Il detective si accovaccia e trova un anello insanguinato nascosto tra le fessure del pavimento. | [kaishu_cn_1.wav](https://github.com/user-attachments/files/22354649/kaishu_cn_1.wav) |
| Al chiaro di luna, la zucca improvvisamente spunta un sorriso, il viticcio si muove e apre la recinzione del giardino. La bambina si mette sulle punte dei piedi e sente i funghi cantare un’antica ninna nanna. | [kaishu_cn_2.wav](https://github.com/user-attachments/files/22354652/kaishu_cn_2.wav) |
| Quindi in Java bisogna ancora studiare a livello intermedio, M e fino allo sviluppo di sistemi applicativi frontend esterni, bisogna imparare il database di Java Script e a creare siti web dinamici. | [kaishu_cn_en_mix_1.wav](https://github.com/user-attachments/files/22354654/kaishu_cn_en_mix_1.wav) |
| Questo financial report analizza in dettaglio la revenue performance e le expenditure trends dell’azienda nell’ultimo trimestre. | [kaishu_cn_en_mix_2.wav](https://github.com/user-attachments/files/22354656/kaishu_cn_en_mix_2.wav) |
| Salire e scendere dalla montagna, su una montagna, giù da un’altra, correre per tre li e tre metri e tre, scalare una grande montagna alta, la montagna è a trecentotrentatre metri sul livello del mare. Una volta in cima, gridare forte: Sono più alto della montagna di tre piedi e tre. | [kaishu_raokouling.wav](https://github.com/user-attachments/files/22354658/kaishu_raokouling.wav) |
| Un uomo magro giace sul lato della strada con la camicia e una scarpa tolte e le borse accanto. | [kaishu_en_1.wav](https://github.com/user-attachments/files/22354659/kaishu_en_1.wav) |
| Con il proseguire della ricerca, l’effetto protettivo del fluoro contro la carie dentale è stato dimostrato. | [kaishu_en_2.wav](https://github.com/user-attachments/files/22354661/kaishu_en_2.wav) |

#### 2. Valutazione del Modello
Per i dettagli del set di valutazione, vedi: [2025 Benchmark dei Modelli TTS Mainstream: Qual è la Migliore Soluzione di Sintesi Vocale?](https://mp.weixin.qq.com/s/5z_aRKQG3OIv7fnSdxegqQ)
<img width="1182" height="261" alt="image" src="https://github.com/user-attachments/assets/fb86938d-95d9-4b10-9588-2de1e43b51d1" />

### Ringraziamenti

[index-tts](https://github.com/index-tts/index-tts)

[finetune-index-tts](https://github.com/yrom/finetune-index-tts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-16

---
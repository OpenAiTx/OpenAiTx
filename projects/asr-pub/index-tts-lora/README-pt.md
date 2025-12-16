
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
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

[Versão em Chinês](https://github.com/asr-pub/index-tts-lora/blob/main/README_zh.md) | [Versão em Inglês](https://github.com/asr-pub/index-tts-lora/blob/main/README.md)

Este projeto é baseado no [index-tts](https://github.com/index-tts/index-tts) da Bilibili, fornecendo soluções de **ajuste fino LoRA** tanto para configurações de **um único locutor quanto multi-locutor**. O objetivo é aprimorar a **prosódia e naturalidade** na síntese de áudio de alta qualidade de locutores.

### Treinamento & Inferência

#### 1. Extração de token de áudio e condição do locutor

```shell
# Extract tokens and speaker conditions
python tools/extract_codec.py --audio_list ${audio_list} --extract_condition

# audio_list format: audio_path + transcript, separated by \t
/path/to/audio.wav 小朋友们，大家好，我是凯叔，今天我们讲一个龟兔赛跑的故事。
```

Após a extração, os arquivos processados e o `speaker_info.json` serão gerados no diretório `finetune_data/processed_data/`. Por exemplo:

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

#### 2. Treinamento

```shell
python train.py
```

#### 3. Inferência

```shell
python indextts/infer.py
```

### Resultados do Ajuste Fino

Este experimento utiliza **dados de áudio em chinês** de *Kai Shu Conta Histórias*, com duração total de **\~30 minutos** e **270 clipes de áudio**.
O conjunto de dados está dividido em **244 amostras de treinamento** e **26 amostras de validação**.
Nota: As transcrições foram geradas automaticamente via modelos de ASR e pontuação, sem correção manual, portanto, alguns erros são esperados.

Exemplo de amostra de treinamento, `他上了马车，来到了皇宫之中。`：[kaishu_train_01.wav](https://github.com/user-attachments/files/22354621/kaishu_train_01.wav)


#### 1. Exemplos de Síntese de Fala


| Texto                                                        | Áudio                                                        |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| 老宅的钟表停在午夜三点，灰尘中浮现一串陌生脚印。侦探蹲下身，发现地板缝隙里藏着一枚带血的戒指。 | [kaishu_cn_1.wav](https://github.com/user-attachments/files/22354649/kaishu_cn_1.wav) |
| 月光下，南瓜突然长出笑脸，藤蔓扭动着推开花园栅栏。小女孩踮起脚，听见蘑菇在哼唱古老的摇篮曲。 | [kaishu_cn_2.wav](https://github.com/user-attachments/files/22354652/kaishu_cn_2.wav) |
| 那么Java里面中级还要学，M以及到外部前端的应用系统开发，要学到Java Script的数据库，要学做动态的网站。 | [kaishu_cn_en_mix_1.wav](https://github.com/user-attachments/files/22354654/kaishu_cn_en_mix_1.wav) |
| 这份 financial report 详细分析了公司在过去一个季度的 revenue performance 和 expenditure trends。 | [kaishu_cn_en_mix_2.wav](https://github.com/user-attachments/files/22354656/kaishu_cn_en_mix_2.wav) |
| 上山下山上一山，下一山，跑了三里三米三，登了一座大高山，山高海拔三百三。上了山，大声喊：我比山高三尺三。 | [kaishu_raokouling.wav](https://github.com/user-attachments/files/22354658/kaishu_raokouling.wav) |
| A thin man lies against the side of the street with his shirt and a shoe off and bags nearby. | [kaishu_en_1.wav](https://github.com/user-attachments/files/22354659/kaishu_en_1.wav) |
| As research continued, the protective effect of fluoride against dental decay was demonstrated. | [kaishu_en_2.wav](https://github.com/user-attachments/files/22354661/kaishu_en_2.wav) |

#### 2. Avaliação do Modelo
Para detalhes do conjunto de avaliação, veja: [2025 Benchmark of Mainstream TTS Models: Who Is the Best Voice Synthesis Solution?](https://mp.weixin.qq.com/s/5z_aRKQG3OIv7fnSdxegqQ)
<img width="1182" height="261" alt="image" src="https://github.com/user-attachments/assets/fb86938d-95d9-4b10-9588-2de1e43b51d1" />

### Agradecimentos

[index-tts](https://github.com/index-tts/index-tts)

[finetune-index-tts](https://github.com/yrom/finetune-index-tts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-16

---
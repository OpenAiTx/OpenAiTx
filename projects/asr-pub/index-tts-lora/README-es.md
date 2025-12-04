# index-tts-lora

[中文版本](https://github.com/asr-pub/index-tts-lora/blob/main/README_zh.md) | [Versión en Inglés](https://github.com/asr-pub/index-tts-lora/blob/main/README.md)

Este proyecto se basa en [index-tts](https://github.com/index-tts/index-tts) de Bilibili, proporcionando soluciones de **afinación fina LoRA** para configuraciones de **un solo hablante y múltiples hablantes**. Su objetivo es mejorar la **prosodia y naturalidad** en la síntesis de audio de alta calidad de hablantes.

### Entrenamiento e Inferencia

#### 1. Extracción de tokens de audio y condición del hablante

```shell
# Extract tokens and speaker conditions
python tools/extract_codec.py --audio_list ${audio_list} --extract_condition

# audio_list format: audio_path + transcript, separated by \t
/path/to/audio.wav 小朋友们，大家好，我是凯叔，今天我们讲一个龟兔赛跑的故事。
```
Después de la extracción, los archivos procesados y `speaker_info.json` se generarán en el directorio `finetune_data/processed_data/`. Por ejemplo:


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
#### 2. Entrenamiento


```shell
python train.py
```

#### 3. Inferencia

```shell
python indextts/infer.py
```

### Resultados de Fine-tuning

Este experimento utiliza **datos de audio en chino** de *Kai Shu Tells Stories*, con una duración total de **\~30 minutos** y **270 clips de audio**.
El conjunto de datos está dividido en **244 muestras de entrenamiento** y **26 muestras de validación**.
Nota: Las transcripciones se generaron automáticamente mediante modelos ASR y de puntuación, sin corrección manual, por lo que se esperan algunos errores.

Ejemplo de muestra de entrenamiento, `他上了马车，来到了皇宫之中。`：[kaishu_train_01.wav](https://github.com/user-attachments/files/22354621/kaishu_train_01.wav)


#### 1. Ejemplos de Síntesis de Voz


| Texto                                                        | Audio                                                        |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| 老宅的钟表停在午夜三点，灰尘中浮现一串陌生脚印。侦探蹲下身，发现地板缝隙里藏着一枚带血的戒指。 | [kaishu_cn_1.wav](https://github.com/user-attachments/files/22354649/kaishu_cn_1.wav) |
| 月光下，南瓜突然长出笑脸，藤蔓扭动着推开花园栅栏。小女孩踮起脚，听见蘑菇在哼唱古老的摇篮曲。 | [kaishu_cn_2.wav](https://github.com/user-attachments/files/22354652/kaishu_cn_2.wav) |
| 那么Java里面中级还要学，M以及到外部前端的应用系统开发，要学到Java Script的数据库，要学做动态的网站。 | [kaishu_cn_en_mix_1.wav](https://github.com/user-attachments/files/22354654/kaishu_cn_en_mix_1.wav) |
| 这份 financial report 详细分析了公司在过去一个季度的 revenue performance 和 expenditure trends。 | [kaishu_cn_en_mix_2.wav](https://github.com/user-attachments/files/22354656/kaishu_cn_en_mix_2.wav) |
| 上山下山上一山，下一山，跑了三里三米三，登了一座大高山，山高海拔三百三。上了山，大声喊：我比山高三尺三。 | [kaishu_raokouling.wav](https://github.com/user-attachments/files/22354658/kaishu_raokouling.wav) |
| A thin man lies against the side of the street with his shirt and a shoe off and bags nearby. | [kaishu_en_1.wav](https://github.com/user-attachments/files/22354659/kaishu_en_1.wav) |
| As research continued, the protective effect of fluoride against dental decay was demonstrated. | [kaishu_en_2.wav](https://github.com/user-attachments/files/22354661/kaishu_en_2.wav) |

#### 2. Evaluación del Modelo
Para detalles del conjunto de evaluación, ver: [Benchmark 2025 de Modelos TTS Principales: ¿Cuál es la Mejor Solución de Síntesis de Voz?](https://mp.weixin.qq.com/s/5z_aRKQG3OIv7fnSdxegqQ)
<img width="1182" height="261" alt="imagen" src="https://github.com/user-attachments/assets/fb86938d-95d9-4b10-9588-2de1e43b51d1" />

### Agradecimientos

[index-tts](https://github.com/index-tts/index-tts)

[finetune-index-tts](https://github.com/yrom/finetune-index-tts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-04

---
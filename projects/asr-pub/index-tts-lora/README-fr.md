# index-tts-lora

[中文版本](https://github.com/asr-pub/index-tts-lora/blob/main/README_zh.md) | [Version française](https://github.com/asr-pub/index-tts-lora/blob/main/README.md)

Ce projet est basé sur [index-tts](https://github.com/index-tts/index-tts) de Bilibili, fournissant des solutions de **fine-tuning LoRA** pour des configurations **mono-locuteur et multi-locuteurs**. Il vise à améliorer la **prosodie et la naturalité** dans la synthèse audio de haute qualité des locuteurs.

### Entraînement & Inférence

#### 1. Extraction des tokens audio et de la condition locuteur

```shell
# Extract tokens and speaker conditions
python tools/extract_codec.py --audio_list ${audio_list} --extract_condition

# audio_list format: audio_path + transcript, separated by \t
/path/to/audio.wav 小朋友们，大家好，我是凯叔，今天我们讲一个龟兔赛跑的故事。
```
Après extraction, les fichiers traités et `speaker_info.json` seront générés dans le répertoire `finetune_data/processed_data/`. Par exemple :


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

#### 2. Entraînement

```shell
python train.py
```

#### 3. Inférence

```shell
python indextts/infer.py
```

### Résultats du fine-tuning

Cette expérience utilise des **données audio chinoises** de *Kai Shu Tells Stories*, avec une durée totale de **\~30 minutes** et **270 extraits audio**.  
Le jeu de données est divisé en **244 échantillons d'entraînement** et **26 échantillons de validation**.  
Remarque : Les transcriptions ont été générées automatiquement via des modèles ASR et de ponctuation, sans correction manuelle, donc certaines erreurs sont attendues.

Exemple d’échantillon d’entraînement, `他上了马车，来到了皇宫之中。` : [kaishu_train_01.wav](https://github.com/user-attachments/files/22354621/kaishu_train_01.wav)


#### 1. Exemples de synthèse vocale


| Texte                                                        | Audio                                                        |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| 老宅的钟表停在午夜三点，灰尘中浮现一串陌生脚印。侦探蹲下身，发现地板缝隙里藏着一枚带血的戒指。 | [kaishu_cn_1.wav](https://github.com/user-attachments/files/22354649/kaishu_cn_1.wav) |
| 月光下，南瓜突然长出笑脸，藤蔓扭动着推开花园栅栏。小女孩踮起脚，听见蘑菇在哼唱古老的摇篮曲。 | [kaishu_cn_2.wav](https://github.com/user-attachments/files/22354652/kaishu_cn_2.wav) |
| 那么Java里面中级还要学，M以及到外部前端的应用系统开发，要学到Java Script的数据库，要学做动态的网站。 | [kaishu_cn_en_mix_1.wav](https://github.com/user-attachments/files/22354654/kaishu_cn_en_mix_1.wav) |
| 这份 financial report 详细分析了公司在过去一个季度的 revenue performance 和 expenditure trends。 | [kaishu_cn_en_mix_2.wav](https://github.com/user-attachments/files/22354656/kaishu_cn_en_mix_2.wav) |
| 上山下山上一山，下一山，跑了三里三米三，登了一座大高山，山高海拔三百三。上了山，大声喊：我比山高三尺三。 | [kaishu_raokouling.wav](https://github.com/user-attachments/files/22354658/kaishu_raokouling.wav) |
| Un homme mince est allongé sur le bord de la rue avec sa chemise et une chaussure enlevées et des sacs à proximité. | [kaishu_en_1.wav](https://github.com/user-attachments/files/22354659/kaishu_en_1.wav) |
| Au fur et à mesure des recherches, l’effet protecteur du fluorure contre la carie dentaire a été démontré. | [kaishu_en_2.wav](https://github.com/user-attachments/files/22354661/kaishu_en_2.wav) |

#### 2. Évaluation du modèle
Pour les détails de l’ensemble d’évaluation, voir : [Benchmark 2025 des modèles TTS grand public : Quelle est la meilleure solution de synthèse vocale ?](https://mp.weixin.qq.com/s/5z_aRKQG3OIv7fnSdxegqQ)  
<img width="1182" height="261" alt="image" src="https://github.com/user-attachments/assets/fb86938d-95d9-4b10-9588-2de1e43b51d1" />

### Remerciements

[index-tts](https://github.com/index-tts/index-tts)

[finetune-index-tts](https://github.com/yrom/finetune-index-tts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-04

---
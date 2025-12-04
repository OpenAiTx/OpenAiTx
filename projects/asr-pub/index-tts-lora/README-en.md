# index-tts-lora

[Chinese Version](https://github.com/asr-pub/index-tts-lora/blob/main/README_zh.md) | [English Version](https://github.com/asr-pub/index-tts-lora/blob/main/README.md)

This project is based on Bilibili's [index-tts](https://github.com/index-tts/index-tts), providing **LoRA fine-tuning** solutions for both **single-speaker and multi-speaker** setups. It aims to enhance **prosody and naturalness** in high-quality speaker audio synthesis.

### Training & Inference

#### 1. Audio token and speaker condition extraction

```shell
# Extract tokens and speaker conditions
python tools/extract_codec.py --audio_list ${audio_list} --extract_condition

# audio_list format: audio_path + transcript, separated by \t
/path/to/audio.wav 小朋友们，大家好，我是凯叔，今天我们讲一个龟兔赛跑的故事。
```
After extraction, the processed files and `speaker_info.json` will be generated under the `finetune_data/processed_data/` directory. For example:


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

#### 3. Inference

```shell
python indextts/infer.py
```

### Fine-tuning Results

This experiment uses **Chinese audio data** from *Kai Shu Tells Stories*, with a total duration of **\~30 minutes** and **270 audio clips**.
The dataset is split into **244 training samples** and **26 validation samples**.
Note: Transcripts were generated automatically via ASR and punctuation models, without manual correction, so some errors are expected.

Example training sample, `他上了马车，来到了皇宫之中。`：[kaishu_train_01.wav](https://github.com/user-attachments/files/22354621/kaishu_train_01.wav)


#### 1. Speech Synthesis Examples


| Text                                                         | Audio                                                        |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| The old house clock stopped at midnight three o’clock, and a string of unfamiliar footprints appeared in the dust. The detective crouched down and found a blood-stained ring hidden in the floorboard gap. | [kaishu_cn_1.wav](https://github.com/user-attachments/files/22354649/kaishu_cn_1.wav) |
| Under the moonlight, the pumpkin suddenly grew a smiling face, and the vines twisted to push open the garden fence. The little girl stood on tiptoe, hearing the mushrooms humming an ancient lullaby. | [kaishu_cn_2.wav](https://github.com/user-attachments/files/22354652/kaishu_cn_2.wav) |
| Then in Java, intermediate levels still need to learn M as well as external front-end application system development, need to learn JavaScript databases, and need to learn to make dynamic websites. | [kaishu_cn_en_mix_1.wav](https://github.com/user-attachments/files/22354654/kaishu_cn_en_mix_1.wav) |
| This financial report analyzes in detail the company’s revenue performance and expenditure trends in the past quarter. | [kaishu_cn_en_mix_2.wav](https://github.com/user-attachments/files/22354656/kaishu_cn_en_mix_2.wav) |
| Going up and down the mountain, one mountain after another, running three li three meters three, climbed a high mountain, altitude three hundred and three. On the mountain, shouted loudly: I am three chi three taller than the mountain. | [kaishu_raokouling.wav](https://github.com/user-attachments/files/22354658/kaishu_raokouling.wav) |
| A thin man lies against the side of the street with his shirt and a shoe off and bags nearby. | [kaishu_en_1.wav](https://github.com/user-attachments/files/22354659/kaishu_en_1.wav) |
| As research continued, the protective effect of fluoride against dental decay was demonstrated. | [kaishu_en_2.wav](https://github.com/user-attachments/files/22354661/kaishu_en_2.wav) |

#### 2. Model Evaluation
For details of the evaluation set, see: [2025 Benchmark of Mainstream TTS Models: Who Is the Best Voice Synthesis Solution?](https://mp.weixin.qq.com/s/5z_aRKQG3OIv7fnSdxegqQ)
<img width="1182" height="261" alt="image" src="https://github.com/user-attachments/assets/fb86938d-95d9-4b10-9588-2de1e43b51d1" />

### Acknowledgements

[index-tts](https://github.com/index-tts/index-tts)

[finetune-index-tts](https://github.com/yrom/finetune-index-tts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-04

---
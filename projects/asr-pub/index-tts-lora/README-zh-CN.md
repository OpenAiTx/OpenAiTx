
<div align="right">
  <details>
    <summary >🌐 语言</summary>
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

[中文版本](https://github.com/asr-pub/index-tts-lora/blob/main/README_zh.md) | [English Version](https://github.com/asr-pub/index-tts-lora/blob/main/README.md)

本项目基于哔哩哔哩的[index-tts](https://github.com/index-tts/index-tts)，为**单说话人和多说话人**场景提供**LoRA微调**解决方案，旨在提升高质量说话人音频合成的**韵律感与自然度**。

### 训练与推理

#### 1. 音频令牌和说话人条件提取

```shell
# Extract tokens and speaker conditions
python tools/extract_codec.py --audio_list ${audio_list} --extract_condition

# audio_list format: audio_path + transcript, separated by \t
/path/to/audio.wav 小朋友们，大家好，我是凯叔，今天我们讲一个龟兔赛跑的故事。
```
提取完成后，处理过的文件和 `speaker_info.json` 将生成在 `finetune_data/processed_data/` 目录下。例如：


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

#### 2. 训练

```shell
python train.py
```

#### 3. 推理

```shell
python indextts/infer.py
```

### 微调结果

本次实验使用了来自*开书讲故事*的**中文音频数据**，总时长约**30分钟**，包含**270个音频片段**。  
数据集分为**244个训练样本**和**26个验证样本**。  
注意：转录文本通过ASR和标点模型自动生成，未经过人工校正，因此可能存在一些错误。

训练样本示例，`他上了马车，来到了皇宫之中。`：[kaishu_train_01.wav](https://github.com/user-attachments/files/22354621/kaishu_train_01.wav)


#### 1. 语音合成示例


| 文本                                                         | 音频                                                        |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| 老宅的钟表停在午夜三点，灰尘中浮现一串陌生脚印。侦探蹲下身，发现地板缝隙里藏着一枚带血的戒指。 | [kaishu_cn_1.wav](https://github.com/user-attachments/files/22354649/kaishu_cn_1.wav) |
| 月光下，南瓜突然长出笑脸，藤蔓扭动着推开花园栅栏。小女孩踮起脚，听见蘑菇在哼唱古老的摇篮曲。 | [kaishu_cn_2.wav](https://github.com/user-attachments/files/22354652/kaishu_cn_2.wav) |
| 那么Java里面中级还要学，M以及到外部前端的应用系统开发，要学到Java Script的数据库，要学做动态的网站。 | [kaishu_cn_en_mix_1.wav](https://github.com/user-attachments/files/22354654/kaishu_cn_en_mix_1.wav) |
| 这份 financial report 详细分析了公司在过去一个季度的 revenue performance 和 expenditure trends。 | [kaishu_cn_en_mix_2.wav](https://github.com/user-attachments/files/22354656/kaishu_cn_en_mix_2.wav) |
| 上山下山上一山，下一山，跑了三里三米三，登了一座大高山，山高海拔三百三。上了山，大声喊：我比山高三尺三。 | [kaishu_raokouling.wav](https://github.com/user-attachments/files/22354658/kaishu_raokouling.wav) |
| 一个瘦弱的男子靠在街边，衬衫和一只鞋脱落，身边放着几个包。 | [kaishu_en_1.wav](https://github.com/user-attachments/files/22354659/kaishu_en_1.wav) |
| 随着研究的继续，氟化物对防止牙齿蛀牙的保护作用得到了证明。 | [kaishu_en_2.wav](https://github.com/user-attachments/files/22354661/kaishu_en_2.wav) |

#### 2. 模型评估
有关评估集的详细信息，请参见：[2025主流TTS模型基准：谁是最佳语音合成方案？](https://mp.weixin.qq.com/s/5z_aRKQG3OIv7fnSdxegqQ)
<img width="1182" height="261" alt="image" src="https://github.com/user-attachments/assets/fb86938d-95d9-4b10-9588-2de1e43b51d1" />

### 致谢

[index-tts](https://github.com/index-tts/index-tts)

[finetune-index-tts](https://github.com/yrom/finetune-index-tts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-16

---
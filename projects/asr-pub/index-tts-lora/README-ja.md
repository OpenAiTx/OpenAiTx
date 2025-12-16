
<div align="right">
  <details>
    <summary >🌐 言語</summary>
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

[中文版本](https://github.com/asr-pub/index-tts-lora/blob/main/README_zh.md) | [英語版](https://github.com/asr-pub/index-tts-lora/blob/main/README.md)

本プロジェクトはBilibiliの [index-tts](https://github.com/index-tts/index-tts) をベースにしており、**単一話者および複数話者**の両方に対応した**LoRAファインチューニング**ソリューションを提供します。高品質な話者音声合成において、**韻律や自然さ**を向上させることを目的としています。

### 学習と推論

#### 1. オーディオトークンおよび話者条件の抽出

```shell
# Extract tokens and speaker conditions
python tools/extract_codec.py --audio_list ${audio_list} --extract_condition

# audio_list format: audio_path + transcript, separated by \t
/path/to/audio.wav 小朋友们，大家好，我是凯叔，今天我们讲一个龟兔赛跑的故事。
```
抽出後、処理されたファイルと `speaker_info.json` は `finetune_data/processed_data/` ディレクトリの下に生成されます。例えば：


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

#### 2. トレーニング

```shell
python train.py
```

#### 3. 推論

```shell
python indextts/infer.py
```
### ファインチューニング結果

本実験では、*開書物語*の**中国語音声データ**を使用し、合計**約30分**、**270音声クリップ**を用いました。  
データセットは**244の訓練サンプル**と**26の検証サンプル**に分割されています。  
注：文字起こしはASRと句読点モデルにより自動生成され、手動修正は行っていないため、一部誤りが含まれる可能性があります。

訓練サンプル例、`他上了马车，来到了皇宫之中。`：[kaishu_train_01.wav](https://github.com/user-attachments/files/22354621/kaishu_train_01.wav)


#### 1. 音声合成例


| テキスト                                                        | 音声                                                          |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| 老宅の時計は深夜3時で止まり、ほこりの中に見知らぬ足跡が浮かぶ。探偵はしゃがみ込み、床の隙間に血のついた指輪を見つけた。 | [kaishu_cn_1.wav](https://github.com/user-attachments/files/22354649/kaishu_cn_1.wav) |
| 月光の下、カボチャが突然笑顔を見せ、つるが動いて庭の柵を押し開けた。少女はつま先立ちで、キノコが古い子守唄を口ずさんでいるのを聞いた。 | [kaishu_cn_2.wav](https://github.com/user-attachments/files/22354652/kaishu_cn_2.wav) |
| それではJavaの中級も学び、Mや外部フロントエンドのアプリケーション開発、JavaScriptのデータベースや動的なウェブサイト作成も学ぶ必要がある。 | [kaishu_cn_en_mix_1.wav](https://github.com/user-attachments/files/22354654/kaishu_cn_en_mix_1.wav) |
| このfinancial reportは、過去四半期の会社のrevenue performanceとexpenditure trendsを詳細に分析している。 | [kaishu_cn_en_mix_2.wav](https://github.com/user-attachments/files/22354656/kaishu_cn_en_mix_2.wav) |
| 山を上り下りし、次の山へ、三里三米三走り、大きな高い山に登った。山の高さは海抜三百三。山に登り、大声で叫んだ：私は山より三尺三高い。 | [kaishu_raokouling.wav](https://github.com/user-attachments/files/22354658/kaishu_raokouling.wav) |
| シャツと靴の片方を脱いだ細身の男性が街角に寄りかかり、近くにバッグがある。 | [kaishu_en_1.wav](https://github.com/user-attachments/files/22354659/kaishu_en_1.wav) |
| 研究が続く中で、フッ素が虫歯に対する防護効果を持つことが示された。 | [kaishu_en_2.wav](https://github.com/user-attachments/files/22354661/kaishu_en_2.wav) |

#### 2. モデル評価
評価セットの詳細については、こちらを参照してください：[2025年主流TTSモデルのベンチマーク：最良の音声合成ソリューションは？](https://mp.weixin.qq.com/s/5z_aRKQG3OIv7fnSdxegqQ)  
<img width="1182" height="261" alt="image" src="https://github.com/user-attachments/assets/fb86938d-95d9-4b10-9588-2de1e43b51d1" />

### 謝辞

[index-tts](https://github.com/index-tts/index-tts)

[finetune-index-tts](https://github.com/yrom/finetune-index-tts)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-16

---
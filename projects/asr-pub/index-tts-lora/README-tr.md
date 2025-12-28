
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
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

[中文版本](https://github.com/asr-pub/index-tts-lora/blob/main/README_zh.md) | [İngilizce Sürüm](https://github.com/asr-pub/index-tts-lora/blob/main/README.md)

Bu proje, Bilibili'nin [index-tts](https://github.com/index-tts/index-tts) tabanlıdır ve hem **tek konuşmacılı hem de çok konuşmacılı** kurulumlar için **LoRA ince ayar** çözümleri sunar. Yüksek kaliteli konuşmacı ses sentezinde **prozodi ve doğallığı** artırmayı amaçlar.

### Eğitim & Çıkarım

#### 1. Ses belirteci ve konuşmacı durumu çıkarımı

```shell
# Extract tokens and speaker conditions
python tools/extract_codec.py --audio_list ${audio_list} --extract_condition

# audio_list format: audio_path + transcript, separated by \t
/path/to/audio.wav 小朋友们，大家好，我是凯叔，今天我们讲一个龟兔赛跑的故事。
```

Çıkarımdan sonra, işlenmiş dosyalar ve `speaker_info.json` dosyası `finetune_data/processed_data/` dizini altında oluşturulacaktır. Örneğin:

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

#### 2. Eğitim

```shell
python train.py
```

#### 3. Çıkarım

```shell
python indextts/infer.py
```

### İnce Ayar Sonuçları

Bu deneyde *Kai Shu Tells Stories*’den alınan **Çince ses verisi** kullanılmıştır, toplamda **\~30 dakika** süresinde ve **270 ses klibi** bulunmaktadır.
Veri seti **244 eğitim örneği** ve **26 doğrulama örneği** olarak ayrılmıştır.
Not: Transkriptler ASR ve noktalama modelleriyle otomatik olarak oluşturulmuştur, elle düzeltilmemiştir, bu yüzden bazı hatalar beklenmektedir.

Örnek eğitim verisi, `他上了马车，来到了皇宫之中。`：[kaishu_train_01.wav](https://github.com/user-attachments/files/22354621/kaishu_train_01.wav)


#### 1. Konuşma Sentetik Örnekleri


| Metin                                                         | Ses                                                         |
| ------------------------------------------------------------ | ----------------------------------------------------------- |
| Eski konağın saati gece yarısı üçte durmuştu, tozun içinde yabancı ayak izleri belirdi. Dedektif eğildi, zemin aralığında kanlı bir yüzük buldu. | [kaishu_cn_1.wav](https://github.com/user-attachments/files/22354649/kaishu_cn_1.wav) |
| Ay ışığında, balkabağı aniden gülümseyen bir yüz çıkardı, sarmaşıklar bahçe çitini itti. Küçük kız parmak uçlarında yükseldi, mantarın eski bir ninni mırıldandığını duydu. | [kaishu_cn_2.wav](https://github.com/user-attachments/files/22354652/kaishu_cn_2.wav) |
| Java'da orta seviyede hala öğrenilecekler var, M ve harici ön yüz uygulama sistemi geliştirmeyi, Java Script veritabanını, dinamik web sitesi yapmayı öğrenmek gerekiyor. | [kaishu_cn_en_mix_1.wav](https://github.com/user-attachments/files/22354654/kaishu_cn_en_mix_1.wav) |
| Bu financial report şirketin son çeyrekteki revenue performance ve expenditure trends analizini detaylı şekilde sunuyor. | [kaishu_cn_en_mix_2.wav](https://github.com/user-attachments/files/22354656/kaishu_cn_en_mix_2.wav) |
| Dağa çık, dağdan in, bir dağ, bir sonraki dağ, üç mil üç metre koş, büyük bir dağa tırman, dağın yüksekliği üç yüz üç metre. Dağa çıkınca yüksek sesle bağır: Ben dağdan üç arşın yükseğim. | [kaishu_raokouling.wav](https://github.com/user-attachments/files/22354658/kaishu_raokouling.wav) |
| Zayıf bir adam, gömleği ve bir ayakkabısı çıkmış halde, çantalar yanında, caddenin kenarında yatıyor. | [kaishu_en_1.wav](https://github.com/user-attachments/files/22354659/kaishu_en_1.wav) |
| Araştırmalar sürdükçe, florürün diş çürüğüne karşı koruyucu etkisi gösterildi. | [kaishu_en_2.wav](https://github.com/user-attachments/files/22354661/kaishu_en_2.wav) |

#### 2. Model Değerlendirmesi
<img width="1182" height="261" alt="image" src="https://github.com/user-attachments/assets/fb86938d-95d9-4b10-9588-2de1e43b51d1" />

### Teşekkürler

[index-tts](https://github.com/index-tts/index-tts)

[finetune-index-tts](https://github.com/yrom/finetune-index-tts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-28

---
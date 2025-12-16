
<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
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

[النسخة الصينية](https://github.com/asr-pub/index-tts-lora/blob/main/README_zh.md) | [النسخة الإنجليزية](https://github.com/asr-pub/index-tts-lora/blob/main/README.md)

هذا المشروع يعتمد على [index-tts](https://github.com/index-tts/index-tts) الخاص بـ Bilibili، ويقدم حلول **ضبط دقيق LoRA** لكل من **الإعدادات أحادية المتحدث ومتعددة المتحدثين**. يهدف إلى تحسين **الإيقاع والطبيعية** في توليف الصوت عالي الجودة للمتحدث.

### التدريب والاستدلال

#### 1. استخراج رمز الصوت وشرط المتحدث

```shell
# Extract tokens and speaker conditions
python tools/extract_codec.py --audio_list ${audio_list} --extract_condition

# audio_list format: audio_path + transcript, separated by \t
/path/to/audio.wav 小朋友们，大家好，我是凯叔，今天我们讲一个龟兔赛跑的故事。
```

بعد الاستخراج، سيتم إنشاء الملفات المعالجة وملف `speaker_info.json` ضمن دليل `finetune_data/processed_data/`. على سبيل المثال:

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

#### 2. التدريب

```shell
python train.py
```

#### 3. الاستنتاج

```shell
python indextts/infer.py
```

### نتائج الضبط الدقيق

تستخدم هذه التجربة **بيانات صوتية صينية** من *كاي شو يروي القصص*، بإجمالي مدة **حوالي 30 دقيقة** و **270 مقطع صوتي**.
تم تقسيم مجموعة البيانات إلى **244 عينة تدريب** و **26 عينة تحقق**.
ملاحظة: تم توليد النصوص تلقائيًا عبر نماذج تحويل الكلام إلى نص ونماذج علامات الترقيم، بدون تصحيح يدوي، لذا من المتوقع وجود بعض الأخطاء.

مثال لعينة تدريب، `他上了马车，来到了皇宫之中。`：[kaishu_train_01.wav](https://github.com/user-attachments/files/22354621/kaishu_train_01.wav)


#### 1. أمثلة على توليد الكلام


| النص                                                          | الصوت                                                        |
| ------------------------------------------------------------- | ------------------------------------------------------------ |
| توقفت ساعة القصر القديم عند الثالثة منتصف الليل، وظهرت آثار أقدام غريبة وسط الغبار. انحنى المحقق واكتشف خاتمًا ملطخًا بالدماء بين شقوق الأرضية. | [kaishu_cn_1.wav](https://github.com/user-attachments/files/22354649/kaishu_cn_1.wav) |
| تحت ضوء القمر، ظهرت على اليقطينة فجأة وجه مبتسم، وتحركت الكرمة لتفتح سياج الحديقة. وقفت الفتاة الصغيرة على أطراف أصابعها، تسمع الفطر يغني تهويدة قديمة. | [kaishu_cn_2.wav](https://github.com/user-attachments/files/22354652/kaishu_cn_2.wav) |
| إذًا في لغة جافا يجب دراسة المستوى المتوسط، وأيضًا تطوير أنظمة التطبيقات الخارجية للواجهة الأمامية، ويجب دراسة قاعدة بيانات Java Script، وإنشاء مواقع ديناميكية. | [kaishu_cn_en_mix_1.wav](https://github.com/user-attachments/files/22354654/kaishu_cn_en_mix_1.wav) |
| هذا الـ financial report يحلل بالتفصيل أداء الإيرادات واتجاهات الإنفاق للشركة في الربع الماضي. | [kaishu_cn_en_mix_2.wav](https://github.com/user-attachments/files/22354656/kaishu_cn_en_mix_2.wav) |
| صعد ونزل الجبل وصعد جبلًا آخر، وركض ثلاثة أميال وثلاثة أمتار وثلاثة، وتسلق جبلًا شاهقًا بارتفاع ثلاثمائة وثلاثة. وبعد أن وصل الجبل، صاح بصوت عالٍ: أنا أعلى من الجبل بثلاثة أقدام وثلاثة. | [kaishu_raokouling.wav](https://github.com/user-attachments/files/22354658/kaishu_raokouling.wav) |
| رجل نحيف يستلقي بجانب الطريق وقميصه وحذاؤه مخلوعان وحقائبه بجانبه. | [kaishu_en_1.wav](https://github.com/user-attachments/files/22354659/kaishu_en_1.wav) |
| مع استمرار البحث، تم إثبات التأثير الوقائي للفلورايد ضد تسوس الأسنان. | [kaishu_en_2.wav](https://github.com/user-attachments/files/22354661/kaishu_en_2.wav) |

#### 2. تقييم النموذج
للاطلاع على تفاصيل مجموعة التقييم، راجع: [معيار 2025 لنماذج تحويل النص إلى كلام: من هو أفضل حل لتوليد الصوت؟](https://mp.weixin.qq.com/s/5z_aRKQG3OIv7fnSdxegqQ)
<img width="1182" height="261" alt="image" src="https://github.com/user-attachments/assets/fb86938d-95d9-4b10-9588-2de1e43b51d1" />

### الشكر والتقدير

[index-tts](https://github.com/index-tts/index-tts)

[finetune-index-tts](https://github.com/yrom/finetune-index-tts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-16

---

<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
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

[เวอร์ชันภาษาจีน](https://github.com/asr-pub/index-tts-lora/blob/main/README_zh.md) | [เวอร์ชันภาษาอังกฤษ](https://github.com/asr-pub/index-tts-lora/blob/main/README.md)

โปรเจกต์นี้มีพื้นฐานมาจาก [index-tts](https://github.com/index-tts/index-tts) ของ Bilibili โดยให้โซลูชัน **LoRA fine-tuning** สำหรับทั้ง **แบบพูดคนเดียวและหลายคน** มีเป้าหมายเพื่อยกระดับ **จังหวะและความเป็นธรรมชาติ** ในการสังเคราะห์เสียงพูดคุณภาพสูง

### การฝึกสอน & การอนุมาน

#### 1. การสกัดโทเคนเสียงและเงื่อนไขของผู้พูด

```shell
# Extract tokens and speaker conditions
python tools/extract_codec.py --audio_list ${audio_list} --extract_condition

# audio_list format: audio_path + transcript, separated by \t
/path/to/audio.wav 小朋友们，大家好，我是凯叔，今天我们讲一个龟兔赛跑的故事。
```
หลังจากการแยกไฟล์แล้ว ไฟล์ที่ผ่านการประมวลผลและ `speaker_info.json` จะถูกสร้างขึ้นภายใต้ไดเรกทอรี `finetune_data/processed_data/` เช่น:


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

#### 2. การฝึกอบรม

```shell
python train.py
```

#### 3. การอนุมาน

```shell
python indextts/infer.py
```

### ผลการปรับแต่งโมเดล

การทดลองนี้ใช้ **ข้อมูลเสียงภาษาจีน** จาก *Kai Shu Tells Stories* โดยมีระยะเวลารวม **ประมาณ 30 นาที** และ **270 คลิปเสียง**  
ชุดข้อมูลถูกแบ่งเป็น **244 ตัวอย่างสำหรับฝึก** และ **26 ตัวอย่างสำหรับตรวจสอบความถูกต้อง**  
หมายเหตุ: ข้อความถอดเสียงถูกสร้างโดยอัตโนมัติผ่านโมเดล ASR และระบบวรรคตอน โดยไม่มีการแก้ไขด้วยมนุษย์ จึงอาจมีข้อผิดพลาดบ้าง

ตัวอย่างข้อมูลฝึก, `他上了马车，来到了皇宫之中。`：[kaishu_train_01.wav](https://github.com/user-attachments/files/22354621/kaishu_train_01.wav)


#### 1. ตัวอย่างการสังเคราะห์เสียงพูด


| ข้อความ                                                        | เสียง                                                        |
| -------------------------------------------------------------- | ------------------------------------------------------------ |
| นาฬิกาในบ้านเก่าหยุดที่เที่ยงคืนสามนาฬิกา มีรอยเท้าแปลกปลอมปรากฏบนฝุ่น นักสืบย่อตัวลง พบแหวนเปื้อนเลือดซ่อนอยู่ในร่องพื้นไม้ | [kaishu_cn_1.wav](https://github.com/user-attachments/files/22354649/kaishu_cn_1.wav) |
| ใต้แสงจันทร์ ฟักทองจู่ๆ ก็มีใบหน้าที่ยิ้มแย้ม เถาวัลย์บิดตัวผลักรั้วสวน เด็กหญิงเขย่งเท้า ได้ยินเห็ดร้องเพลงกล่อมโบราณ | [kaishu_cn_2.wav](https://github.com/user-attachments/files/22354652/kaishu_cn_2.wav) |
| ดังนั้นใน Java ระดับกลางยังต้องเรียน และไปถึงการพัฒนาระบบแอปพลิเคชันฝั่งหน้าบ้านภายนอก ต้องเรียนฐานข้อมูล Java Script ต้องเรียนการทำเว็บไซต์ไดนามิก | [kaishu_cn_en_mix_1.wav](https://github.com/user-attachments/files/22354654/kaishu_cn_en_mix_1.wav) |
| รายงานการเงินนี้ได้วิเคราะห์รายละเอียดประสิทธิภาพรายรับและแนวโน้มการใช้จ่ายของบริษัทในไตรมาสที่ผ่านมา | [kaishu_cn_en_mix_2.wav](https://github.com/user-attachments/files/22354656/kaishu_cn_en_mix_2.wav) |
| ขึ้นเขาลงเขาขึ้นเขา หนึ่งเขา สองเขา วิ่งสามลี้สามเมตรสาม ขึ้นเขาสูงลูกหนึ่ง สูงเหนือระดับน้ำทะเลสามร้อยสาม ขึ้นเขาแล้วตะโกนดังว่า: ฉันสูงกว่าเขาสามฟุตสาม | [kaishu_raokouling.wav](https://github.com/user-attachments/files/22354658/kaishu_raokouling.wav) |
| ชายผอมคนหนึ่งนอนอยู่ข้างถนน เสื้อและรองเท้าหลุดออก ถุงวางอยู่ใกล้ ๆ | [kaishu_en_1.wav](https://github.com/user-attachments/files/22354659/kaishu_en_1.wav) |
| เมื่อการวิจัยดำเนินต่อไป พบว่า ฟลูออไรด์มีฤทธิ์ป้องกันฟันผุอย่างมีประสิทธิภาพ | [kaishu_en_2.wav](https://github.com/user-attachments/files/22354661/kaishu_en_2.wav) |

#### 2. การประเมินโมเดล
<img width="1182" height="261" alt="image" src="https://github.com/user-attachments/assets/fb86938d-95d9-4b10-9588-2de1e43b51d1" />

### ขอบคุณ

[index-tts](https://github.com/index-tts/index-tts)

[finetune-index-tts](https://github.com/yrom/finetune-index-tts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-28

---
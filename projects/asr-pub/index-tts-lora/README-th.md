
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

[เวอร์ชั่นภาษาจีน](https://github.com/asr-pub/index-tts-lora/blob/main/README_zh.md) | [เวอร์ชั่นภาษาอังกฤษ](https://github.com/asr-pub/index-tts-lora/blob/main/README.md)

โปรเจกต์นี้อ้างอิงจาก [index-tts](https://github.com/index-tts/index-tts) ของ Bilibili โดยให้บริการโซลูชันการ **ปรับแต่ง LoRA** สำหรับทั้ง **การใช้งานแบบผู้พูดเดี่ยวและหลายผู้พูด** มุ่งเน้นเพื่อพัฒนาคุณภาพ **จังหวะเสียงและความเป็นธรรมชาติ** ในการสังเคราะห์เสียงพูดคุณภาพสูง

### การเทรนและการอนุมาน

#### 1. การแยกโทเค็นเสียงและเงื่อนไขของผู้พูด

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

### ผลลัพธ์การปรับแต่งโมเดล

การทดลองนี้ใช้ **ข้อมูลเสียงภาษาจีน** จาก *Kai Shu Tells Stories* รวมระยะเวลาทั้งหมด **ประมาณ 30 นาที** และ **270 คลิปเสียง** 
ชุดข้อมูลแบ่งออกเป็น **244 ตัวอย่างสำหรับฝึก** และ **26 ตัวอย่างสำหรับตรวจสอบความถูกต้อง**
หมายเหตุ: ข้อความถอดเสียงถูกสร้างโดยอัตโนมัติผ่านระบบ ASR และโมเดลใส่เครื่องหมายวรรคตอน โดยไม่มีการแก้ไขด้วยมือ ดังนั้นอาจมีข้อผิดพลาดบางส่วน

ตัวอย่างข้อมูลฝึก, `他上了马车，来到了皇宫之中。`：[kaishu_train_01.wav](https://github.com/user-attachments/files/22354621/kaishu_train_01.wav)


#### 1. ตัวอย่างการสังเคราะห์เสียงพูด


| ข้อความ                                                         | ไฟล์เสียง                                                        |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| นาฬิกาในคฤหาสน์เก่าหยุดที่สามทุ่มตรง เศษฝุ่นลอยขึ้นเผยรอยเท้าคนแปลกหน้า นักสืบย่อตัวลง พบแหวนเปื้อนเลือดซ่อนอยู่ในร่องไม้พื้น | [kaishu_cn_1.wav](https://github.com/user-attachments/files/22354649/kaishu_cn_1.wav) |
| ใต้แสงจันทร์ ฟักทองจู่ๆ ก็มีใบหน้าที่ยิ้มแย้ม เถาวัลย์บิดตัวเปิดรั้วสวนออก เด็กหญิงเขย่งเท้า ฟังเห็ดร้องเพลงกล่อมโบราณ | [kaishu_cn_2.wav](https://github.com/user-attachments/files/22354652/kaishu_cn_2.wav) |
| ดังนั้นใน Java ระดับกลางยังต้องเรียน ตั้งแต่ M ไปจนถึงการพัฒนาระบบแอปพลิเคชันฝั่ง frontend ภายนอก ต้องเรียน Java Script ฐานข้อมูล และการทำเว็บไซต์แบบไดนามิก | [kaishu_cn_en_mix_1.wav](https://github.com/user-attachments/files/22354654/kaishu_cn_en_mix_1.wav) |
| รายงานการเงินนี้วิเคราะห์รายละเอียดเกี่ยวกับการดำเนินงานด้านรายได้และแนวโน้มการใช้จ่ายของบริษัทในไตรมาสที่ผ่านมา | [kaishu_cn_en_mix_2.wav](https://github.com/user-attachments/files/22354656/kaishu_cn_en_mix_2.wav) |
| ขึ้นเขาลงเขาขึ้นอีกเขา ลงอีกเขา วิ่งไปสามลี้สามเมตรสาม ขึ้นเขาสูงหนึ่งลูก เขาสูงระดับน้ำทะเลสามร้อยสาม ขึ้นถึงยอดตะโกนดัง: ฉันสูงกว่าเขาสามศอกสาม | [kaishu_raokouling.wav](https://github.com/user-attachments/files/22354658/kaishu_raokouling.wav) |
| ชายผอมคนหนึ่งนอนพิงริมถนน เสื้อกับรองเท้าถูกถอดออกและมีถุงวางอยู่ใกล้ ๆ | [kaishu_en_1.wav](https://github.com/user-attachments/files/22354659/kaishu_en_1.wav) |
| จากการวิจัยต่อเนื่อง พบว่าฟลูออไรด์มีผลป้องกันฟันผุได้อย่างชัดเจน | [kaishu_en_2.wav](https://github.com/user-attachments/files/22354661/kaishu_en_2.wav) |

#### 2. การประเมินผลโมเดล
ดูรายละเอียดชุดประเมินผลได้ที่: [2025 Benchmark of Mainstream TTS Models: ใครคือโซลูชันสังเคราะห์เสียงที่ดีที่สุด?](https://mp.weixin.qq.com/s/5z_aRKQG3OIv7fnSdxegqQ)
<img width="1182" height="261" alt="image" src="https://github.com/user-attachments/assets/fb86938d-95d9-4b10-9588-2de1e43b51d1" />

### คำขอบคุณ

[index-tts](https://github.com/index-tts/index-tts)

[finetune-index-tts](https://github.com/yrom/finetune-index-tts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-16

---
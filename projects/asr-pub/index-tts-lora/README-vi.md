
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
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

[Phiên bản tiếng Trung](https://github.com/asr-pub/index-tts-lora/blob/main/README_zh.md) | [Phiên bản tiếng Anh](https://github.com/asr-pub/index-tts-lora/blob/main/README.md)

Dự án này dựa trên [index-tts](https://github.com/index-tts/index-tts) của Bilibili, cung cấp giải pháp **tinh chỉnh LoRA** cho cả **thiết lập một người nói và nhiều người nói**. Mục tiêu nhằm nâng cao **ngữ điệu và sự tự nhiên** trong tổng hợp âm thanh người nói chất lượng cao.

### Huấn luyện & Suy luận

#### 1. Trích xuất token âm thanh và điều kiện người nói

```shell
# Extract tokens and speaker conditions
python tools/extract_codec.py --audio_list ${audio_list} --extract_condition

# audio_list format: audio_path + transcript, separated by \t
/path/to/audio.wav 小朋友们，大家好，我是凯叔，今天我们讲一个龟兔赛跑的故事。
```

Sau khi trích xuất, các tệp đã xử lý và `speaker_info.json` sẽ được tạo ra trong thư mục `finetune_data/processed_data/`. Ví dụ:

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

#### 2. Đào tạo

```shell
python train.py
```

#### 3. Suy luận

```shell
python indextts/infer.py
```

### Kết quả Fine-tuning

Thí nghiệm này sử dụng **dữ liệu âm thanh tiếng Trung** từ *Kai Shu Tells Stories*, với tổng thời lượng **\~30 phút** và **270 đoạn âm thanh**.
Bộ dữ liệu được chia thành **244 mẫu huấn luyện** và **26 mẫu xác thực**.
Lưu ý: Bản phiên âm được tạo tự động qua hệ thống nhận diện giọng nói và mô hình dấu câu, không có chỉnh sửa thủ công, nên có thể có một số lỗi.

Ví dụ mẫu huấn luyện, `他上了马车，来到了皇宫之中。`：[kaishu_train_01.wav](https://github.com/user-attachments/files/22354621/kaishu_train_01.wav)


#### 1. Ví dụ tổng hợp giọng nói


| Văn bản                                                         | Âm thanh                                                        |
| -------------------------------------------------------------- | -------------------------------------------------------------- |
| Đồng hồ ở ngôi nhà cũ dừng lại lúc ba giờ sáng, một chuỗi dấu chân lạ xuất hiện giữa bụi bặm. Thám tử cúi xuống, phát hiện một chiếc nhẫn dính máu giấu trong kẽ sàn. | [kaishu_cn_1.wav](https://github.com/user-attachments/files/22354649/kaishu_cn_1.wav) |
| Dưới ánh trăng, quả bí ngô bỗng mọc khuôn mặt cười, dây leo uốn mình đẩy mở hàng rào khu vườn. Cô bé nhón chân lên, nghe thấy nấm đang ngân nga bài hát ru cổ xưa. | [kaishu_cn_2.wav](https://github.com/user-attachments/files/22354652/kaishu_cn_2.wav) |
| Vậy thì trong Java ở mức trung cấp còn phải học, M cũng như đến phát triển hệ thống ứng dụng phía trước bên ngoài, phải học cơ sở dữ liệu Java Script, phải học làm website động. | [kaishu_cn_en_mix_1.wav](https://github.com/user-attachments/files/22354654/kaishu_cn_en_mix_1.wav) |
| Báo cáo tài chính này phân tích chi tiết hiệu suất doanh thu và xu hướng chi tiêu của công ty trong quý vừa qua. | [kaishu_cn_en_mix_2.wav](https://github.com/user-attachments/files/22354656/kaishu_cn_en_mix_2.wav) |
| Lên núi xuống núi lên một núi, xuống một núi, chạy ba dặm ba mét ba, leo một ngọn núi cao lớn, núi cao độ cao ba trăm ba. Lên núi, hét lớn: Tôi cao hơn núi ba thước ba. | [kaishu_raokouling.wav](https://github.com/user-attachments/files/22354658/kaishu_raokouling.wav) |
| Một người đàn ông gầy nằm dựa bên đường, áo sơ mi và một chiếc giày đã tháo ra, túi xách đặt gần đó. | [kaishu_en_1.wav](https://github.com/user-attachments/files/22354659/kaishu_en_1.wav) |
| Khi nghiên cứu tiếp tục, hiệu quả bảo vệ của fluoride chống lại sâu răng đã được chứng minh. | [kaishu_en_2.wav](https://github.com/user-attachments/files/22354661/kaishu_en_2.wav) |

#### 2. Đánh giá mô hình
<img width="1182" height="261" alt="image" src="https://github.com/user-attachments/assets/fb86938d-95d9-4b10-9588-2de1e43b51d1" />

### Lời cảm ơn

[index-tts](https://github.com/index-tts/index-tts)

[finetune-index-tts](https://github.com/yrom/finetune-index-tts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-28

---
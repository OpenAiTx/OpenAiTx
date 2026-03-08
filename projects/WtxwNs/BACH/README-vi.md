
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

<p align="center">
  <img src="https://raw.githubusercontent.com/WtxwNs/BACH/main/tokenpair.png" width="85%"/>
  <br><br>
  <i>Xem cách BACH biến các token thô thành nhạc có cấu trúc—từng bước một.</i>
</p>

# BACH: Trợ lý Sáng tác AI Cấp Đoạn Nhạc  
<p align="center">
  <a href="https://arxiv.org/abs/2508.01394">
    <img src="https://img.shields.io/badge/arXiv-2508.01394-b31b1b.svg" alt="arXiv"/>
  </a>
  <a href="https://github.com/WtxwNs/BACH/blob/main/LICENSE">
    <img src="https://img.shields.io/github/license/WtxwNs/BACH" alt="License"/>
  </a>
  <img src="https://img.shields.io/github/repo-size/WtxwNs/BACH" alt="Repo Size"/>
  <img src="https://img.shields.io/github/stars/WtxwNs/BACH?style=social" alt="Stars"/>
</p>

&gt; *"Thông qua Score to Performance: Sinh nhạc dài, tiết kiệm, có thể kiểm soát bởi con người với ký hiệu thanh nhạc theo ô nhịp"*  
&gt; Nộp ICASSP 2026 – **Đã được chấp nhận**

---

## 🎼 Tóm tắt trong một câu  
BACH là trình tạo bài hát ký hiệu theo ô nhịp đầu tiên **cho phép con người chỉnh sửa**:  
LLM viết lời → Transformer xuất ra score ABC → phần mềm dựng nhạc cho ra nhạc **dài vài phút, chất lượng như Suno**.  
**1 tỷ tham số**, suy luận **ở cấp độ phút**, **mã nguồn mở SOTA**.

---

## 📦 Có gì trong repo này (bản phát hành xem trước)
| Đường dẫn | Mô tả |
|------|-------------|
| `README.md` | Tệp này |
| `code/` | mã suy luận |
| `example.mp3` | một bài hát ví dụ |
| `fig/` | Hình kiến trúc |

---

## 🏗️ Kiến trúc mô hình (tổng quan)

Nhắc nhở của người dùng
Qwen3 — thẻ lời & phong cách
BACH-1B Transformer chỉ giải mã
Score ABC (Dual-NTP + Chain-of-Score)

ABC → MIDI → FluidSynth + VOCALOID
Phối âm stereo


| Thành phần | Ý tưởng chính |
|------------|--------------|
| **Dual-NTP** | Dự đoán `{vocal_patch, accomp_patch}` cùng lúc ở mỗi bước |
| **Chain-of-Score** | Thẻ phân đoạn `[START:Chorus] ... [END:Chorus]` để duy trì tính nhất quán dài hạn |
| **Bar-stream patch** | Miếng vá 16 ký tự không chồng lấn mỗi ô nhịp |

---

## 🧪 Bắt đầu nhanh (thân thiện với CPU)
```bash
# 1. Clone
git clone https://github.com/your-github/BACH.git
cd BACH

# 2. Install
pip install -r requirements.txt        # transformers>=4.41 mido abcpy fluidsynth

# 3. Generate ABC
python bach/generate.py \
    --prompt "A rainy-day lo-fi hip-hop song about missing the last train" \
    --out_abc demo/rainy_lofi.abc

# 4. Render audio
```

##  🎧 Nghe ngay
example.mp3 đã sẵn sàng cho bạn, đây là một bài hát hoàn chỉnh. Bạn có thể so sánh nó với Suno🙂

## Phát hành đầy đủ khi bài báo liên quan được chấp nhận
- Bộ dữ liệu huấn luyện hoàn chỉnh (ABC + lời bài hát + nhãn cấu trúc)
- Trọng số BACH-1B (định dạng Transformers)
- Script huấn luyện (đa giai đoạn + đa nhiệm vụ + ICL)
- Mã hoàn chỉnh

## 📎 Trích dẫn
Bài báo đã được phát hành trên Arxiv,
@misc{wang2025scoreperformanceefficienthumancontrollable,
      title={Từ Bản Nhạc Đến Hiệu Suất: Tạo Nhạc Dài Có Thể Kiểm Soát Bởi Con Người Một Cách Hiệu Quả Với Ký Hiệu Biểu Tượng Cấp Thanh}, 
      author={Tongxi Wang và Yang Yu và Qing Wang và Junlang Qian},
      year={2025},
      eprint={2508.01394},
      archivePrefix={arXiv},
      primaryClass={cs.SD},
      url={https://arxiv.org/abs/2508.01394}, 
}



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-08

---
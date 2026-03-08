
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
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
  <i>ชมวิธีที่ BACH เปลี่ยนโทเคนดิบให้กลายเป็นดนตรีที่มีโครงสร้าง—ทีละขั้นตอน</i>
</p>

# BACH: ผู้ช่วยประพันธ์เพลงด้วย AI ระดับห้องเพลง  
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

&gt; *"Via Score to Performance: การสร้างเพลงยาวที่ควบคุมได้โดยมนุษย์อย่างมีประสิทธิภาพด้วยสัญลักษณ์แบบบาร์"*  
&gt; ส่งผลงานเข้า ICASSP 2026 – **ได้รับการตอบรับแล้ว**

---

## 🎼 สรุปในประโยคเดียว  
BACH คือเครื่องมือสร้างเพลงด้วยสัญลักษณ์แบบบาร์ที่แก้ไขโดยมนุษย์ได้ตัวแรกของโลก:  
LLM แต่งเนื้อเพลง → Transformer สร้างโน้ต ABC → renderer ทั่วไปให้เสียงเพลงคุณภาพสูง **ยาวหลายนาที ระดับ Suno**  
**1 พันล้านพารามิเตอร์**, ประมวลผลระดับนาที, **โอเพ่นซอร์ส SOTA**

---

## 📦 มีอะไรอยู่ใน repo นี้ (พรีวิวรีลีส)
| Path | รายละเอียด |
|------|-------------|
| `README.md` | ไฟล์นี้ |
| `code/` | โค้ดสำหรับ inference |
| `example.mp3` | ตัวอย่างเพลง |
| `fig/` | รูปโครงสร้างโมเดล |

---

## 🏗️ สถาปัตยกรรมโมเดล (มองแว้บเดียว)

ข้อความที่ผู้ใช้ป้อน
Qwen3 — เนื้อเพลง & แท็กสไตล์
BACH-1B Decoder-Only Transformer
โน้ต ABC (Dual-NTP + Chain-of-Score)

ABC → MIDI → FluidSynth + VOCALOID
สเตอริโอมิกซ์


| ส่วนประกอบ | แนวคิดสำคัญ |
|-------------|-------------|
| **Dual-NTP** | ทำนาย `{vocal_patch, accomp_patch}` ร่วมกันทุกขั้นตอน |
| **Chain-of-Score** | แท็กส่วน `[START:Chorus] ... [END:Chorus]` เพื่อความต่อเนื่องยาว |
| **Bar-stream patch** | แพทช์ 16 ตัวอักษรไม่ซ้อนกันต่อบาร์ |

---

## 🧪 เริ่มต้นใช้งานอย่างรวดเร็ว (เหมาะกับ CPU)
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

##  🎧 ฟังเลยตอนนี้
example.mp3 พร้อมให้คุณใช้งานแล้ว เป็นเพลงเต็ม คุณสามารถเปรียบเทียบกับ Suno🙂

## ปล่อยทั้งหมดเมื่อบทความที่เกี่ยวข้องได้รับการยอมรับ
- ชุดข้อมูลฝึกอบรมครบถ้วน (ABC + เนื้อเพลง + ป้ายโครงสร้าง)
- น้ำหนัก BACH-1B (รูปแบบ Transformers)
- สคริปต์ฝึกอบรม (หลายเฟส + หลายงาน + ICL)
- โค้ดครบถ้วน

## 📎 การอ้างอิง
บทความเผยแพร่บน Arxiv,
```bibtex
@misc{wang2025scoreperformanceefficienthumancontrollable,
      title={จากโน้ตสู่การแสดง: การสร้างเพลงยาวด้วยโน้ตเชิงสัญลักษณ์ระดับห้องที่ควบคุมได้โดยมนุษย์อย่างมีประสิทธิภาพ}, 
      author={ถงซี หวัง และ หยาง หยู และ ชิง หวัง และ จวิ้นหลาง เชียน},
      year={2025},
      eprint={2508.01394},
      archivePrefix={arXiv},
      primaryClass={cs.SD},
      url={https://arxiv.org/abs/2508.01394}, 
}


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-08

---
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">

# ZipVoice⚡

## ระบบแปลงข้อความเป็นเสียงความเร็วสูงคุณภาพสูงแบบ Zero-Shot ด้วย Flow Matching
</div>

## ภาพรวม

ZipVoice เป็นชุดโมเดล TTS แบบ zero-shot ที่รวดเร็วและคุณภาพสูงโดยอิงกับ flow matching

### 1. คุณสมบัติเด่น

- ขนาดเล็กและรวดเร็ว: มีเพียง 123M พารามิเตอร์

- โคลนเสียงคุณภาพสูง: ให้ประสิทธิภาพระดับแนวหน้าในด้านความคล้ายคลึงของผู้พูด ความเข้าใจง่าย และความเป็นธรรมชาติ

- รองรับหลายภาษา: รองรับภาษาจีนและภาษาอังกฤษ

- หลายโหมด: รองรับทั้งการสร้างเสียงผู้พูดเดียวและบทสนทนา

### 2. รุ่นของโมเดล

<table>
  <thead>
    <tr>
      <th>ชื่อโมเดล</th>
      <th>คำอธิบาย</th>
      <th>เอกสาร</th>
      <th>เดโม</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>ZipVoice</td>
      <td>โมเดลพื้นฐานรองรับ TTS แบบ zero-shot สำหรับผู้พูดเดียวทั้งภาษาจีนและอังกฤษ</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2506.13053"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Distill</td>
      <td>เวอร์ชั่นกลั่นของ ZipVoice ที่เร็วขึ้นโดยประสิทธิภาพลดลงเพียงเล็กน้อย</td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog</td>
      <td>โมเดลสร้างบทสนทนาที่พัฒนาบน ZipVoice สามารถสร้างบทสนทนาเสียงสองฝ่ายในช่องสัญญาณเดียว</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2507.09318"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice-dialog.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog-Stereo</td>
      <td>เวอร์ชั่นสเตอริโอของ ZipVoice-Dialog รองรับการสร้างบทสนทนาแบบสองช่องโดยแต่ละผู้พูดอยู่คนละช่อง</td>
    </tr>
  </tbody>
</table>

## ข่าวสาร

**2025/07/14**: **ZipVoice-Dialog** และ **ZipVoice-Dialog-Stereo** โมเดลสร้างบทสนทนาเสียงสองรุ่น ได้รับการเปิดตัว [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice-dialog.github.io)

**2025/07/14**: ชุดข้อมูล **OpenDialog** ซึ่งเป็นชุดข้อมูลบทสนทนาเสียง 6.8k ชั่วโมง ได้รับการปล่อยให้ดาวน์โหลดที่ [![hf](https://img.shields.io/badge/%F0%9F%A4%97%20HuggingFace-Dataset-yellow)](https://huggingface.co/datasets/k2-fsa/OpenDialog), [![ms](https://img.shields.io/badge/ModelScope-Dataset-blue?logo=data)](https://www.modelscope.cn/datasets/k2-fsa/OpenDialog) ดูรายละเอียดที่ [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318)

**2025/06/16**: **ZipVoice** และ **ZipVoice-Distill** ได้รับการเปิดตัว [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2506.13053) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice.github.io)

## การติดตั้ง

### 1. โคลนที่เก็บ ZipVoice


```bash
git clone https://github.com/k2-fsa/ZipVoice.git
```
### 2. (ไม่บังคับ) สร้างสภาพแวดล้อมเสมือนของ Python


```bash
python3 -m venv zipvoice
source zipvoice/bin/activate
```
### 3. ติดตั้งแพ็กเกจที่จำเป็น


```bash
pip install -r requirements.txt
```
### 4. (ตัวเลือก) ติดตั้ง k2 สำหรับการฝึกหรือการอนุมานที่มีประสิทธิภาพ

k2 จำเป็นสำหรับการฝึกและสามารถเพิ่มความเร็วในการอนุมาน อย่างไรก็ตาม คุณยังคงสามารถใช้โหมดอนุมานของ ZipVoice ได้โดยไม่ต้องติดตั้ง k2

> **หมายเหตุ:** โปรดตรวจสอบให้แน่ใจว่าคุณติดตั้ง k2 เวอร์ชันที่ตรงกับ PyTorch และ CUDA ของคุณ ตัวอย่างเช่น หากคุณใช้ pytorch 2.5.1 และ CUDA 12.1 คุณสามารถติดตั้ง k2 ได้ดังนี้:


```bash
pip install k2==1.24.4.dev20250208+cuda12.1.torch2.5.1 -f https://k2-fsa.github.io/k2/cuda.html
```
โปรดดูรายละเอียดได้ที่ https://k2-fsa.org/get-started/k2/
ผู้ใช้ในจีนแผ่นดินใหญ่สามารถดูข้อมูลได้ที่ https://k2-fsa.org/zh-CN/get-started/k2/

## การใช้งาน

### 1. การสร้างเสียงพูดผู้พูดเดียว

หากต้องการสร้างเสียงพูดผู้พูดเดียวด้วยโมเดล ZipVoice หรือ ZipVoice-Distill ที่เราได้ฝึกไว้ล่วงหน้า ให้ใช้คำสั่งต่อไปนี้ (โมเดลที่จำเป็นจะถูกดาวน์โหลดจาก HuggingFace):

#### 1.1 การอินเฟอเรนซ์ประโยคเดียว


```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --prompt-wav prompt.wav \
    --prompt-text "I am the transcription of the prompt wav." \
    --text "I am the text to be synthesized." \
    --res-wav-path result.wav
```
- `--model-name` สามารถเป็น `zipvoice` หรือ `zipvoice_distill` ซึ่งเป็นโมเดลก่อนและหลังการกลั่น ตามลำดับ
- หากปรากฏ `<>` หรือ `[]` ในข้อความ สตริงที่อยู่ภายในจะถูกจัดการเป็นโทเคนพิเศษ โดย `<>` หมายถึงพินอินภาษาจีน และ `[]` หมายถึงแท็กพิเศษอื่น ๆ
- สามารถรันโมเดล ONNX บน CPU ได้เร็วขึ้นด้วย `zipvoice.bin.infer_zipvoice_onnx`

> **หมายเหตุ:** หากคุณมีปัญหาในการเชื่อมต่อกับ HuggingFace ให้ลองทำดังนี้:
> ```bash
> export HF_ENDPOINT=https://hf-mirror.com
> ```

#### 1.2 การอินเฟอเรนซ์รายการประโยค


```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --test-list test.tsv \
    --res-dir results
```
- แต่ละบรรทัดของ `test.tsv` อยู่ในรูปแบบ `{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}`

### 2. การสร้างบทสนทนาแบบพูดคุย

#### 2.1 คำสั่งสำหรับการอนุมาน

เพื่อสร้างบทสนทนาแบบพูดคุยสองฝ่ายด้วยโมเดล ZipVoice-Dialogue หรือ ZipVoice-Dialogue-Stereo ที่ผ่านการฝึกฝนล่วงหน้าของเรา ให้ใช้คำสั่งดังต่อไปนี้ (โมเดลที่จำเป็นจะถูกดาวน์โหลดจาก HuggingFace):


```bash
python3 -m zipvoice.bin.infer_zipvoice_dialog \
    --model-name "zipvoice_dialog" \
    --test-list test.tsv \
    --res-dir results
```
- `--model-name` สามารถเป็น `zipvoice_dialog` หรือ `zipvoice_dialog_stereo` ซึ่งจะสร้างบทสนทนาแบบโมโนและสเตอริโอตามลำดับ

#### 2.2 รูปแบบอินพุต

แต่ละบรรทัดของ `test.tsv` จะอยู่ในหนึ่งในรูปแบบต่อไปนี้:

(1) **รูปแบบพรอมต์รวม** ซึ่งไฟล์เสียงและข้อความถอดเสียงของผู้พูดสองคนจะถูกรวมเป็นไฟล์พรอมต์ wav เดียว:


```
{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}
```
- `wav_name` คือชื่อของไฟล์ wav ที่จะส่งออก
- `prompt_transcription` คือข้อความถอดเสียงของไฟล์ wav ที่เป็นบทสนทนา เช่น "[S1] สวัสดีค่ะ [S2] สบายดีไหม?"
- `prompt_wav` คือพาธไปยังไฟล์ wav ที่เป็นพรอมต์
- `text` คือข้อความที่ต้องการสังเคราะห์เสียง เช่น "[S1] ฉันสบายดี [S2] คุณชื่ออะไร?"

(2) **รูปแบบพรอมต์แยกไฟล์** ซึ่งไฟล์เสียงและไฟล์ถอดเสียงของผู้พูดทั้งสองจะถูกแยกเก็บไว้ในไฟล์ต่างหาก:


```
{wav_name}\t{spk1_prompt_transcription}\t{spk2_prompt_transcription}\t{spk1_prompt_wav}\t{spk2_prompt_wav}\t{text}'
```
- `wav_name` คือชื่อของไฟล์ wav ที่จะสร้างขึ้น
- `spk1_prompt_transcription` คือข้อความถอดเสียงของไฟล์ wav ตัวอย่างเสียงผู้พูดคนแรก เช่น "สวัสดี"
- `spk2_prompt_transcription` คือข้อความถอดเสียงของไฟล์ wav ตัวอย่างเสียงผู้พูดคนที่สอง เช่น "สบายดีไหม?"
- `spk1_prompt_wav` คือพาธของไฟล์ wav ตัวอย่างเสียงผู้พูดคนแรก
- `spk2_prompt_wav` คือพาธของไฟล์ wav ตัวอย่างเสียงผู้พูดคนที่สอง
- `text` คือข้อความที่ต้องการสังเคราะห์ เช่น "[S1] ฉันสบายดี [S2] คุณชื่ออะไร?"

### 3. ฟีเจอร์อื่น ๆ

#### 3.1 การแก้ไขการออกเสียงผิดของอักขระจีนที่มีหลายเสียง

เราใช้ [pypinyin](https://github.com/mozillazg/python-pinyin) เพื่อแปลงอักขระจีนเป็นพินอิน อย่างไรก็ตาม บางครั้งอาจออกเสียง **อักขระหลายเสียง** (多音字) ผิดได้

หากต้องการแก้ไขการออกเสียงผิดด้วยตนเอง ให้ใส่ **พินอินที่ถูกต้อง** ไว้ในเครื่องหมายมุมเหลี่ยม `< >` และใส่ **เครื่องหมายโทนเสียง**

**ตัวอย่าง:**

- ข้อความเดิม: `这把剑长三十公分`
- แก้ไขพินอินของ `长`:  `这把剑<chang2>三十公分`

> **หมายเหตุ:** หากต้องการกำหนดหลายพินอินด้วยตนเอง ให้ใส่แต่ละพินอินด้วย `<>` เช่น `这把<jian4><chang2><san1>十公分`

## ฝึกโมเดลของคุณเอง

ดูตัวอย่างการฝึกและปรับจูนได้ที่ไดเรกทอรี [egs](egs)

## การพูดคุย & สื่อสาร

คุณสามารถพูดคุยได้โดยตรงที่ [Github Issues](https://github.com/k2-fsa/ZipVoice/issues)

คุณยังสามารถสแกน QR code เพื่อเข้าร่วมกลุ่ม wechat ของเราหรือกดติดตามบัญชีทางการ wechat ของเราได้เช่นกัน

| กลุ่ม Wechat | บัญชีทางการ Wechat |
| ------------ | ----------------------- |
|![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_group.jpg) |![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_account.jpg) |

## การอ้างอิง


```bibtex
@article{zhu2025zipvoice,
      title={ZipVoice: Fast and High-Quality Zero-Shot Text-to-Speech with Flow Matching},
      author={Zhu, Han and Kang, Wei and Yao, Zengwei and Guo, Liyong and Kuang, Fangjun and Li, Zhaoqing and Zhuang, Weiji and Lin, Long and Povey, Daniel},
      journal={arXiv preprint arXiv:2506.13053},
      year={2025}
}

@article{zhu2025zipvoicedialog,
      title={ZipVoice-Dialog: Non-Autoregressive Spoken Dialogue Generation with Flow Matching},
      author={Zhu, Han and Kang, Wei and Guo, Liyong and Yao, Zengwei and Kuang, Fangjun and Zhuang, Weiji and Li, Zhaoqing and Han, Zhifeng and Zhang, Dong and Zhang, Xin and Song, Xingchen and Lin, Long and Povey, Daniel},
      journal={arXiv preprint arXiv:2507.09318},
      year={2025}
}
```
<translate-content></translate-content>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---
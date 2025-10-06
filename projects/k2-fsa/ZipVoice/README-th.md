
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

## ระบบแปลงข้อความเป็นเสียงคุณภาพสูงและรวดเร็วแบบ Zero-Shot ด้วย Flow Matching
</div>

## ภาพรวม

ZipVoice เป็นชุดโมเดล TTS แบบ zero-shot ที่รวดเร็วและคุณภาพสูงโดยใช้ flow matching

### 1. คุณสมบัติเด่น

- ขนาดเล็กและรวดเร็ว: มีเพียง 123M พารามิเตอร์

- โคลนนิ่งเสียงคุณภาพสูง: ประสิทธิภาพล้ำสมัยในด้านความคล้ายคลึงของผู้พูด ความชัดเจน และความเป็นธรรมชาติ

- รองรับหลายภาษา: รองรับภาษาจีนและภาษาอังกฤษ

- รองรับหลายโหมด: รองรับการสร้างเสียงพูดแบบผู้พูดเดี่ยวและบทสนทนา

### 2. รุ่นของโมเดล

<table>
  <thead>
    <tr>
      <th>ชื่อโมเดล</th>
      <th>คำอธิบาย</th>
      <th>เอกสารวิจัย</th>
      <th>เดโม</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>ZipVoice</td>
      <td>โมเดลพื้นฐานที่รองรับ TTS zero-shot สำหรับผู้พูดเดี่ยวในภาษาจีนและอังกฤษ</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2506.13053"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Distill</td>
      <td>เวอร์ชันกลั่นของ ZipVoice ที่เพิ่มความเร็วโดยลดความเสื่อมของประสิทธิภาพให้น้อยที่สุด</td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog</td>
      <td>โมเดลสร้างบทสนทนาที่พัฒนาบน ZipVoice สามารถสร้างบทสนทนาแบบสองฝ่ายในช่องเสียงเดียว</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2507.09318"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice-dialog.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog-Stereo</td>
      <td>รูปแบบสเตอริโอของ ZipVoice-Dialog ที่รองรับการสร้างบทสนทนาแบบสองช่อง โดยแต่ละผู้พูดจะอยู่ในช่องเสียงที่แตกต่างกัน</td>
    </tr>
  </tbody>
</table>

## ข่าวสาร

**2025/07/14**: **ZipVoice-Dialog** และ **ZipVoice-Dialog-Stereo** สองโมเดลสร้างบทสนทนาแบบเสียง ได้เปิดตัวแล้ว [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice-dialog.github.io)

**2025/07/14**: ชุดข้อมูล **OpenDialog** ชุดข้อมูลบทสนทนาเสียงขนาด 6.8k ชั่วโมง ได้เปิดให้ดาวน์โหลดแล้วที่ [![hf](https://img.shields.io/badge/%F0%9F%A4%97%20HuggingFace-Dataset-yellow)](https://huggingface.co/datasets/k2-fsa/OpenDialog), [![ms](https://img.shields.io/badge/ModelScope-Dataset-blue?logo=data)](https://www.modelscope.cn/datasets/k2-fsa/OpenDialog) ดูรายละเอียดได้ที่ [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318)

**2025/06/16**: **ZipVoice** และ **ZipVoice-Distill** เปิดตัวแล้ว [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2506.13053) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice.github.io)

## การติดตั้ง

### 1. โคลนคลังข้อมูล ZipVoice

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
### 4. ติดตั้ง k2 สำหรับการฝึกหรือการอนุมานที่มีประสิทธิภาพ

**k2 จำเป็นสำหรับการฝึก** และสามารถเพิ่มความเร็วในการอนุมานได้ อย่างไรก็ตาม คุณยังสามารถใช้โหมดอนุมานของ ZipVoice ได้โดยไม่ต้องติดตั้ง k2

> **หมายเหตุ:** โปรดตรวจสอบให้แน่ใจว่าคุณติดตั้ง k2 เวอร์ชันที่ตรงกับเวอร์ชันของ PyTorch และ CUDA ของคุณ ตัวอย่างเช่น หากคุณใช้ pytorch 2.5.1 และ CUDA 12.1 คุณสามารถติดตั้ง k2 ได้ดังนี้:


```bash
pip install k2==1.24.4.dev20250208+cuda12.1.torch2.5.1 -f https://k2-fsa.github.io/k2/cuda.html
```
โปรดดูรายละเอียดได้ที่ https://k2-fsa.org/get-started/k2/
ผู้ใช้ในจีนแผ่นดินใหญ่สามารถดูได้ที่ https://k2-fsa.org/zh-CN/get-started/k2/

- เพื่อตรวจสอบการติดตั้ง k2:


```bash
python3 -c "import k2; print(k2.__file__)"
```
## วิธีการใช้งาน

### 1. การสร้างเสียงพูดจากผู้พูดเดียว

เพื่อสร้างเสียงพูดจากผู้พูดเดียวด้วยโมเดล ZipVoice หรือ ZipVoice-Distill ที่ผ่านการฝึกมาแล้ว กรุณาใช้คำสั่งต่อไปนี้ (โมเดลที่จำเป็นจะถูกดาวน์โหลดจาก HuggingFace):

#### 1.1 การทำนายผลของประโยคเดียว


```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --prompt-wav prompt.wav \
    --prompt-text "I am the transcription of the prompt wav." \
    --text "I am the text to be synthesized." \
    --res-wav-path result.wav
```
- `--model-name` สามารถเป็น `zipvoice` หรือ `zipvoice_distill` ซึ่งเป็นโมเดลก่อนและหลังการกลั่นกรองตามลำดับ
- หากมี `<>` หรือ `[]` ปรากฏในข้อความ สตริงที่อยู่ภายในจะถูกจัดการเป็นโทเคนพิเศษ โดย `<>` หมายถึงพินอินภาษาจีน และ `[]` หมายถึงแท็กพิเศษอื่น ๆ

#### 1.2 การอนุมานรายการประโยค

```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --test-list test.tsv \
    --res-dir results
```
- แต่ละบรรทัดของ `test.tsv` อยู่ในรูปแบบ `{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}`

### 2. การสร้างเสียงสนทนา

#### 2.1 คำสั่งสำหรับการอนุมาน

เพื่อสร้างเสียงสนทนาแบบสองฝ่ายด้วยโมเดล ZipVoice-Dialogue หรือ ZipVoice-Dialogue-Stereo ที่ฝึกมาแล้วของเรา ให้ใช้คำสั่งดังต่อไปนี้ (โมเดลที่จำเป็นจะถูกดาวน์โหลดจาก HuggingFace):


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

- `wav_name` คือชื่อของไฟล์ wav ผลลัพธ์
- `prompt_transcription` คือข้อความถอดเสียงของไฟล์ wav บทสนทนา เช่น "[S1] สวัสดี [S2] สบายดีไหม?"
- `prompt_wav` คือเส้นทางไปยังไฟล์ wav ของบทสนทนา
- `text` คือข้อความที่ต้องการสังเคราะห์ เช่น "[S1] ฉันสบายดี [S2] คุณชื่ออะไร? [S1] ฉันชื่อเอริค [S2] สวัสดีเอริค"

(2) **รูปแบบแยกไฟล์บทสนทนา** ที่ไฟล์เสียงและข้อความถอดเสียงของผู้พูดสองคนอยู่ในไฟล์แยกกัน:

```
{wav_name}\t{spk1_prompt_transcription}\t{spk2_prompt_transcription}\t{spk1_prompt_wav}\t{spk2_prompt_wav}\t{text}
```
- `wav_name` คือชื่อของไฟล์ wav ที่จะถูกสร้างขึ้น
- `spk1_prompt_transcription` คือการถอดเสียงของไฟล์ wav ตัวอย่างของผู้พูดคนแรก เช่น "Hello"
- `spk2_prompt_transcription` คือการถอดเสียงของไฟล์ wav ตัวอย่างของผู้พูดคนที่สอง เช่น "How are you?"
- `spk1_prompt_wav` คือเส้นทางไปยังไฟล์ wav ตัวอย่างของผู้พูดคนแรก
- `spk2_prompt_wav` คือเส้นทางไปยังไฟล์ wav ตัวอย่างของผู้พูดคนที่สอง
- `text` คือข้อความที่จะใช้สังเคราะห์เสียง เช่น "[S1] I'm fine. [S2] What's your name? [S1] I'm Eric. [S2] Hi Eric."

### 3 แนวทางการใช้งานที่ดียิ่งขึ้น:

#### 3.1 ความยาวของตัวอย่างเสียง

เราแนะนำให้ใช้ไฟล์ wav ตัวอย่างที่สั้น (เช่น น้อยกว่า 3 วินาทีสำหรับการสร้างเสียงผู้พูดเดียว น้อยกว่า 10 วินาทีสำหรับการสร้างเสียงสนทนา) เพื่อความเร็วในการประมวลผลที่ดีกว่า ไฟล์ตัวอย่างที่ยาวมากจะทำให้การประมวลผลช้าลงและคุณภาพเสียงลดลง

#### 3.2 การปรับแต่งความเร็ว

หากความเร็วในการประมวลผลไม่เป็นที่น่าพอใจ คุณสามารถเพิ่มความเร็วได้ดังนี้:

- **ลดขนาดโมเดลและจำนวนขั้นตอน**: สำหรับโมเดลสร้างเสียงผู้พูดเดียว เราใช้โมเดล `zipvoice` เป็นค่าเริ่มต้นเพื่อคุณภาพเสียงที่ดีกว่า หากต้องการเน้นความเร็ว สามารถเปลี่ยนไปใช้ `zipvoice_distill` และลดค่า `--num-steps` ได้ต่ำสุดถึง `4` (ค่าเริ่มต้นคือ 8)

- **เพิ่มความเร็ว CPU ด้วยมัลติเทรด**: เมื่อรันบน CPU สามารถใช้พารามิเตอร์ `--num-thread` (เช่น `--num-thread 4`) เพื่อเพิ่มจำนวนเทรดสำหรับความเร็วที่มากขึ้น ค่าเริ่มต้นคือ 1 เทรด

- **เพิ่มความเร็ว CPU ด้วย ONNX**: เมื่อรันบน CPU สามารถใช้โมเดล ONNX กับ `zipvoice.bin.infer_zipvoice_onnx` เพื่อความเร็วที่มากขึ้น (ยังไม่รองรับ ONNX สำหรับโมเดลสร้างเสียงสนทนา) เพื่อความเร็วที่มากยิ่งขึ้น สามารถตั้งค่า `--onnx-int8 True` เพื่อใช้โมเดล ONNX ที่ถูกควอนไทซ์เป็น INT8 โปรดทราบว่าโมเดลควอนไทซ์จะมีคุณภาพเสียงลดลง **อย่าใช้ ONNX บน GPU** เพราะจะช้ากว่า PyTorch บน GPU

#### 3.3 การควบคุมหน่วยความจำ

ข้อความที่ให้มาจะถูกแบ่งเป็นส่วนๆ ตามเครื่องหมายวรรคตอน (สำหรับสร้างเสียงผู้พูดเดียว) หรือสัญลักษณ์เปลี่ยนผู้พูด (สำหรับสร้างเสียงสนทนา) จากนั้นข้อความที่แบ่งส่วนจะถูกประมวลผลแบบแบทช์ ดังนั้นโมเดลสามารถประมวลผลข้อความที่ยาวมากได้โดยใช้หน่วยความจำเกือบคงที่ สามารถควบคุมการใช้หน่วยความจำได้โดยปรับพารามิเตอร์ `--max-duration`

#### 3.4 การประเมิน "Raw"

โดยค่าเริ่มต้น เราจะประมวลผลอินพุต (ไฟล์ตัวอย่าง, การถอดเสียงตัวอย่าง, และข้อความ) เพื่อการประมวลผลที่มีประสิทธิภาพและผลลัพธ์ที่ดีกว่า หากต้องการประเมินประสิทธิภาพ "raw" ของโมเดลโดยใช้อินพุตตามที่ให้มา (เช่น เพื่อจำลองผลการทดลองในเอกสารของเรา) สามารถใช้ `--raw-evaluation True`

#### 3.5 ข้อความสั้น

เมื่อสร้างเสียงสำหรับข้อความที่สั้นมาก (เช่น หนึ่งหรือสองคำ) เสียงที่สร้างขึ้นอาจละบางเสียงบางส่วน เพื่อแก้ไขปัญหานี้ สามารถใช้ `--speed 0.3` (โดยที่ 0.3 เป็นค่าที่ปรับได้) เพื่อยืดระยะเวลาของเสียงที่สร้างขึ้น

#### 3.6 การแก้ไขการออกเสียงผิดของอักขระจีนที่ออกเสียงได้หลายแบบ

เราใช้ [pypinyin](https://github.com/mozillazg/python-pinyin) เพื่อแปลงอักขระจีนเป็น pinyin อย่างไรก็ตาม อาจเกิดการออกเสียงผิดสำหรับ **อักขระหลายเสียง** (多音字) ได้เป็นครั้งคราว


ในการแก้ไขการออกเสียงผิดด้วยตนเอง ให้วงเล็บ **พินอินที่ถูกต้อง** ไว้ในเครื่องหมายมุม `< >` และใส่ **เครื่องหมายวรรณยุกต์** ด้วย

**ตัวอย่าง:**

- ข้อความต้นฉบับ: `这把剑长三十公分`
- แก้พินอินของ `长`:  `这把剑<chang2>三十公分`

> **หมายเหตุ:** หากต้องการกำหนดหลายพินอินด้วยตนเอง ให้วงเล็บแต่ละพินอินด้วย `<>` เช่น `这把<jian4><chang2><san1>十公分`

#### 3.7 การลบช่วงเงียบที่ยาวจากเสียงที่สร้างขึ้น

โมเดลจะกำหนดตำแหน่งและระยะเวลาของช่วงเงียบในเสียงที่สร้างขึ้นโดยอัตโนมัติ บางครั้งจะมีช่วงเงียบที่ยาวในกลางเสียง หากไม่ต้องการ สามารถใช้ `--remove-long-sil` เพื่อลบช่วงเงียบที่ยาวในกลางเสียงที่สร้างขึ้น (ช่วงเงียบที่ขอบจะถูกลบโดยค่าเริ่มต้น)

#### 3.8 การดาวน์โหลดโมเดล

หากคุณมีปัญหาในการเชื่อมต่อกับ HuggingFace ขณะดาวน์โหลดโมเดลที่ผ่านการฝึกมาแล้ว ลองเปลี่ยน endpoint ไปยังเว็บไซต์มิเรอร์: `export HF_ENDPOINT=https://hf-mirror.com`

## ฝึกโมเดลของคุณเอง

ดูไดเรกทอรี [egs](egs) สำหรับตัวอย่างการฝึก การปรับแต่ง และการประเมินผล

## การใช้งาน C++

ตรวจสอบ [sherpa-onnx](https://github.com/k2-fsa/sherpa-onnx/pull/2487#issuecomment-3227884498) สำหรับโซลูชันการใช้งาน C++ บน CPU

## การพูดคุยและสื่อสาร

คุณสามารถพูดคุยโดยตรงผ่าน [Github Issues](https://github.com/k2-fsa/ZipVoice/issues)

คุณยังสามารถสแกน QR code เพื่อเข้าร่วมกลุ่ม wechat ของเรา หรือกดติดตามบัญชีทางการ wechat ของเรา

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




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---
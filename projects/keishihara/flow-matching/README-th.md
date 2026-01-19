
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# การจับคู่โฟลว์ใน PyTorch

คลังนี้ประกอบด้วยการใช้งาน PyTorch อย่างง่ายของบทความ [Flow Matching for Generative Modeling](https://arxiv.org/abs/2210.02747)

## ตัวอย่างการจับคู่โฟลว์แบบ 2D

ภาพ gif ด้านล่างแสดงการแมปการกระจายแบบเกาส์เซียนเดี่ยวไปยังการกระจายแบบกระดานหมากรุก พร้อมกับการแสดงภาพฟิลด์เวกเตอร์

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/checkerboard/vector_field_and_samples_checkerboard.gif" height="400" />
</p>

และนี่คือตัวอย่างชุดข้อมูล moons อีกตัวอย่างหนึ่ง

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/moons/vector_field_and_samples_moons.gif" height="400" />
</p>

## เริ่มต้นใช้งาน

โคลน repository และตั้งค่าสภาพแวดล้อม python

```bash
git clone https://github.com/keishihara/flow-matching.git
cd flow-matching
```

ตรวจสอบให้แน่ใจว่าคุณได้ติดตั้ง Python 3.12+ แล้ว
ติดตั้ง `uv`:

```bash
curl -LsSf https://astral.sh/uv/install.sh | sh
```
จากนั้น ตั้งค่าสภาพแวดล้อม:


```bash
uv sync
```

## Conditional Flow Matching [Lipman+ 2023]

นี่คือการนำเสนอการใช้งานต้นฉบับของ CFM [1] ส่วนประกอบบางส่วนของโค้ดถูกนำมาจาก [2] และ [3]

### ชุดข้อมูลของเล่น 2D

คุณสามารถฝึกโมเดล CFM บนชุดข้อมูลสังเคราะห์ 2D เช่น `checkerboard` และ `moons` กำหนดชื่อชุดข้อมูลโดยใช้ตัวเลือก `--dataset` พารามิเตอร์การฝึกอบรมถูกกำหนดไว้ล่วงหน้าในสคริปต์ และผลการฝึกจะถูกจัดเก็บไว้ในไดเรกทอรี `outputs/` จุดตรวจสอบของโมเดลจะไม่ถูกรวมไว้ เนื่องจากสามารถสร้างซ้ำได้ง่ายด้วยการตั้งค่าเริ่มต้น

```bash
uv run scripts/train_flow_matching_2d.py --dataset checkerboard
```

ฟิลด์เวกเตอร์และตัวอย่างที่สร้างขึ้น เช่นเดียวกับตัวอย่างที่แสดงเป็น GIF ที่ด้านบนของ README นี้ สามารถพบได้ในไดเรกทอรี `outputs/cfm/`

### ชุดข้อมูลภาพ

คุณยังสามารถฝึกโมเดล CFM แบบกำหนดคลาสบนชุดข้อมูลการจำแนกภาพยอดนิยมได้ ตัวอย่างที่สร้างขึ้นและจุดตรวจโมเดลจะถูกจัดเก็บไว้ในไดเรกทอรี `outputs/cfm` สำหรับรายการพารามิเตอร์การฝึกที่ละเอียด ให้รันคำสั่ง `uv run scripts/train_flow_matching_on_image.py --help`

หากต้องการฝึกโมเดล CFM แบบกำหนดคลาสบนชุดข้อมูล MNIST ให้รันคำสั่ง:

```bash
uv run scripts/train_flow_matching_on_image.py --do_train --dataset mnist
```
หลังจากการฝึกอบรม คุณสามารถสร้างตัวอย่างได้โดยใช้:


```bash
uv run scripts/train_flow_matching_on_image.py --do_sample --dataset mnist
```
ตอนนี้ คุณควรจะสามารถเห็นตัวอย่างที่ถูกสร้างขึ้นในไดเรกทอรี `outputs/cfm/mnist/` ได้แล้ว

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/mnist/trajectory.gif" height="400" />
</p>

## Rectified Flow [Liu+ 2023]

นี่คือการนำเสนอโมเดล Reflow (โดยเฉพาะ 2-Rectified Flow) จากงานวิจัย Rectified Flow [2]

### ข้อมูลสังเคราะห์ 2 มิติ

เราได้ทำการติดตั้ง Reflow บนชุดข้อมูลสังเคราะห์ 2 มิติ เช่นเดียวกับ CFM ในการฝึกสอน reflow คุณต้องระบุเช็คพอยต์ CFM ที่ผ่านการฝึกมาแล้ว เนื่องจาก reflow เป็นโมเดลการกลั่น

ตัวอย่างเช่น หากต้องการฝึกบนชุดข้อมูล `checkerboard` โดยใช้เช็คพอยต์ CFM ที่ผ่านการฝึกมาแล้ว:


```bash
uv run scripts/train_reflow_2d.py --dataset checkerboard
```
ผลการฝึกอบรม รวมถึงการแสดงภาพสนามเวกเตอร์และตัวอย่างที่สร้างขึ้น จะถูกบันทึกไว้ในโฟลเดอร์ `outputs/reflow/`

### การเปรียบเทียบกระบวนการสุ่มตัวอย่างระหว่าง CFM และ Reflow

ในการเปรียบเทียบ CFM และ Reflow บนชุดข้อมูล 2d ให้รัน:


```bash
uv run scripts/plot_comparison_2d.py --dataset checkerboard
```
ไฟล์ GIF ที่ได้สามารถพบได้ในโฟลเดอร์ `outputs/comparisons/` ด้านล่างนี้เป็นตัวอย่างการเปรียบเทียบของสองวิธีในชุดข้อมูล `checkerboard`:

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/comparisons/cfm_reflow_checkerboard.gif" height="400" />
</p>

## อ้างอิง

- [1] Lipman, Yaron, et al. "Flow Matching for Generative Modeling." [arXiv:2210.02747](https://arxiv.org/abs/2210.02747)
- [2] Liu, Xingchao, et al. "Flow Straight and Fast: Learning to Generate and Transfer Data with Rectified Flow." [arXiv:2209.03003](https://arxiv.org/abs/2209.03003)
- [3] [facebookresearch/flow_matching](https://github.com/facebookresearch/flow_matching)
- [4] [atong01/conditional-flow-matching](https://github.com/atong01/conditional-flow-matching)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-19

---
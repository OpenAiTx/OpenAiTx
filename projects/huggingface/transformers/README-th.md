<!---
Copyright 2020 The HuggingFace Team. สงวนลิขสิทธิ์ทั้งหมด

ได้รับอนุญาตภายใต้ Apache License, Version 2.0 ("ใบอนุญาต");
คุณไม่สามารถใช้ไฟล์นี้ได้หากไม่ได้ปฏิบัติตามใบอนุญาต
คุณสามารถขอสำเนาใบอนุญาตได้ที่

    http://www.apache.org/licenses/LICENSE-2.0

เว้นแต่กฎหมายจะกำหนดไว้หรือมีการตกลงเป็นลายลักษณ์อักษร ซอฟต์แวร์
ที่แจกจ่ายภายใต้ใบอนุญาตนี้จะถูกแจกจ่าย "ตามสภาพ"
โดยไม่มีการรับประกันใดๆ ไม่ว่าจะแสดงออกหรือโดยนัย
ดูใบอนุญาตสำหรับข้อกำหนดเฉพาะที่ควบคุมสิทธิ์และ
ข้อจำกัดภายใต้ใบอนุญาต
-->

<p align="center">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-dark.svg">
    <source media="(prefers-color-scheme: light)" srcset="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-light.svg">
    <img alt="Hugging Face Transformers Library" src="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-light.svg" width="352" height="59" style="max-width: 100%;">
  </picture>
  <br/>
  <br/>
</p>

<p align="center">
    <a href="https://huggingface.com/models"><img alt="Checkpoints on Hub" src="https://img.shields.io/endpoint?url=https://huggingface.co/api/shields/models&color=brightgreen"></a>
    <a href="https://circleci.com/gh/huggingface/transformers"><img alt="Build" src="https://img.shields.io/circleci/build/github/huggingface/transformers/main"></a>
    <a href="https://github.com/huggingface/transformers/blob/main/LICENSE"><img alt="GitHub" src="https://img.shields.io/github/license/huggingface/transformers.svg?color=blue"></a>
    <a href="https://huggingface.co/docs/transformers/index"><img alt="Documentation" src="https://img.shields.io/website/http/huggingface.co/docs/transformers/index.svg?down_color=red&down_message=offline&up_message=online"></a>
    <a href="https://github.com/huggingface/transformers/releases"><img alt="GitHub release" src="https://img.shields.io/github/release/huggingface/transformers.svg"></a>
    <a href="https://github.com/huggingface/transformers/blob/main/CODE_OF_CONDUCT.md"><img alt="Contributor Covenant" src="https://img.shields.io/badge/Contributor%20Covenant-v2.0%20adopted-ff69b4.svg"></a>
    <a href="https://zenodo.org/badge/latestdoi/155220641"><img src="https://zenodo.org/badge/155220641.svg" alt="DOI"></a>
</p>

<h4 align="center">
    <p>
        <b>English</b> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_zh-hans.md">简体中文</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_zh-hant.md">繁體中文</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ko.md">한국어</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_es.md">Español</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ja.md">日本語</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_hd.md">हिन्दी</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ru.md">Русский</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_pt-br.md">Рortuguês</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_te.md">తెలుగు</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_fr.md">Français</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_de.md">Deutsch</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_vi.md">Tiếng Việt</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ar.md">العربية</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ur.md">اردو</a> |
    </p>
</h4>

<h3 align="center">
    <p>โมเดลปรีเทรนล้ำสมัยสำหรับการอินเฟอเรนซ์และการฝึกสอน</p>
</h3>

<h3 align="center">
    <a href="https://hf.co/course"><img src="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/course_banner.png"></a>
</h3>

Transformers คือไลบรารีโมเดลปรีเทรนสำหรับข้อความ, วิสัยทัศน์คอมพิวเตอร์, เสียง, วิดีโอ และมัลติโหมด สำหรับการอินเฟอเรนซ์และฝึกสอน ใช้ Transformers เพื่อจูนโมเดลกับข้อมูลของคุณ, สร้างแอปพลิเคชันอินเฟอเรนซ์ และเพื่อกรณีการใช้งาน AI แบบสร้างสรรค์ในหลายรูปแบบ

มีโมเดล Transformers [จุดตรวจโมเดล](https://huggingface.co/models?library=transformers&sort=trending) มากกว่า 500,000+ บน [Hugging Face Hub](https://huggingface.com/models) ให้คุณเลือกใช้งาน

สำรวจ [Hub](https://huggingface.com/) วันนี้เพื่อค้นหาโมเดลและใช้ Transformers เพื่อเริ่มต้นได้ทันที

## การติดตั้ง

Transformers ทำงานร่วมกับ Python 3.9+, [PyTorch](https://pytorch.org/get-started/locally/) 2.1+, [TensorFlow](https://www.tensorflow.org/install/pip) 2.6+ และ [Flax](https://flax.readthedocs.io/en/latest/) 0.4.1+

สร้างและเปิดใช้งาน virtual environment ด้วย [venv](https://docs.python.org/3/library/venv.html) หรือ [uv](https://docs.astral.sh/uv/) ซึ่งเป็นตัวจัดการแพคเกจและโปรเจกต์ Python ที่เขียนด้วยภาษา Rust

```py
# venv
python -m venv .my-env
source .my-env/bin/activate
# uv
uv venv .my-env
source .my-env/bin/activate
```

ติดตั้ง Transformers ใน virtual environment ของคุณ

```py
# pip
pip install "transformers[torch]"

# uv
uv pip install "transformers[torch]"
```

ติดตั้ง Transformers จากซอร์ส หากคุณต้องการการเปลี่ยนแปลงล่าสุดในไลบรารีหรือสนใจจะร่วมพัฒนา อย่างไรก็ตาม *เวอร์ชันล่าสุด* อาจไม่เสถียร หากคุณพบข้อผิดพลาดสามารถเปิด [issue](https://github.com/huggingface/transformers/issues) ได้

```shell
git clone https://github.com/huggingface/transformers.git
cd transformers

# pip
pip install .[torch]

# uv
uv pip install .[torch]
```

## เริ่มต้นอย่างรวดเร็ว

เริ่มใช้ Transformers ได้ทันทีด้วย API [Pipeline](https://huggingface.co/docs/transformers/pipeline_tutorial) `Pipeline` เป็นคลาสอินเฟอเรนซ์ระดับสูงที่รองรับงานข้อความ, เสียง, วิสัยทัศน์ และมัลติโหมด โดยจะจัดการการประมวลผลล่วงหน้าของอินพุตและคืนค่าผลลัพธ์ที่เหมาะสม

สร้าง pipeline และระบุโมเดลที่ใช้สำหรับการสร้างข้อความ โมเดลจะถูกดาวน์โหลดและแคชเพื่อให้ใช้งานซ้ำได้ง่าย สุดท้าย ส่งข้อความไปกระตุ้นโมเดล

```py
from transformers import pipeline

pipeline = pipeline(task="text-generation", model="Qwen/Qwen2.5-1.5B")
pipeline("the secret to baking a really good cake is ")
[{'generated_text': 'the secret to baking a really good cake is 1) to use the right ingredients and 2) to follow the recipe exactly. the recipe for the cake is as follows: 1 cup of sugar, 1 cup of flour, 1 cup of milk, 1 cup of butter, 1 cup of eggs, 1 cup of chocolate chips. if you want to make 2 cakes, how much sugar do you need? To make 2 cakes, you will need 2 cups of sugar.'}]
```

หากต้องการสนทนากับโมเดล รูปแบบการใช้งานจะเหมือนเดิม ต่างกันเพียงแค่คุณต้องสร้างประวัติการสนทนา (อินพุตสำหรับ `Pipeline`) ระหว่างคุณกับระบบ

> [!TIP]
> คุณสามารถแชทกับโมเดลได้โดยตรงจาก command line
> ```shell
> transformers chat Qwen/Qwen2.5-0.5B-Instruct
> ```

```py
import torch
from transformers import pipeline

chat = [
    {"role": "system", "content": "You are a sassy, wise-cracking robot as imagined by Hollywood circa 1986."},
    {"role": "user", "content": "Hey, can you tell me any fun things to do in New York?"}
]

pipeline = pipeline(task="text-generation", model="meta-llama/Meta-Llama-3-8B-Instruct", torch_dtype=torch.bfloat16, device_map="auto")
response = pipeline(chat, max_new_tokens=512)
print(response[0]["generated_text"][-1]["content"])
```

ขยายตัวอย่างด้านล่างเพื่อดูว่า `Pipeline` ทำงานอย่างไรสำหรับแต่ละโมดัลลิตี้และงาน

<details>
<summary>การรู้จำเสียงพูดอัตโนมัติ</summary>

```py
from transformers import pipeline

pipeline = pipeline(task="automatic-speech-recognition", model="openai/whisper-large-v3")
pipeline("https://huggingface.co/datasets/Narsil/asr_dummy/resolve/main/mlk.flac")
{'text': ' I have a dream that one day this nation will rise up and live out the true meaning of its creed.'}
```

</details>

<details>
<summary>การจำแนกภาพ</summary>

<h3 align="center">
    <a><img src="https://huggingface.co/datasets/Narsil/image_dummy/raw/main/parrots.png"></a>
</h3>

```py
from transformers import pipeline

pipeline = pipeline(task="image-classification", model="facebook/dinov2-small-imagenet1k-1-layer")
pipeline("https://huggingface.co/datasets/Narsil/image_dummy/raw/main/parrots.png")
[{'label': 'macaw', 'score': 0.997848391532898},
 {'label': 'sulphur-crested cockatoo, Kakatoe galerita, Cacatua galerita',
  'score': 0.0016551691805943847},
 {'label': 'lorikeet', 'score': 0.00018523589824326336},
 {'label': 'African grey, African gray, Psittacus erithacus',
  'score': 7.85409429227002e-05},
 {'label': 'quail', 'score': 5.502637941390276e-05}]
```

</details>

<details>
<summary>การตอบคำถามด้วยภาพ</summary>


<h3 align="center">
    <a><img src="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/transformers/tasks/idefics-few-shot.jpg"></a>
</h3>

```py
from transformers import pipeline

pipeline = pipeline(task="visual-question-answering", model="Salesforce/blip-vqa-base")
pipeline(
    image="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/transformers/tasks/idefics-few-shot.jpg",
    question="What is in the image?",
)
[{'answer': 'statue of liberty'}]
```

</details>

## ทำไมจึงควรใช้ Transformers?

1. โมเดลล้ำสมัยที่ใช้งานง่าย:
    - ประสิทธิภาพสูงสำหรับการเข้าใจและสร้างภาษาธรรมชาติ, วิสัยทัศน์คอมพิวเตอร์, เสียง, วิดีโอ และงานมัลติโหมด
    - ลดข้อจำกัดสำหรับนักวิจัย, วิศวกร และนักพัฒนา
    - มี abstraction สำหรับผู้ใช้เพียง 3 คลาสหลักเท่านั้น
    - API เดียวสำหรับใช้โมเดลปรีเทรนทั้งหมด

1. ลดค่าใช้จ่ายในการประมวลผล, ลดคาร์บอนฟุตพรินต์:
    - แชร์โมเดลที่ฝึกแล้ว แทนการฝึกใหม่ตั้งแต่ต้น
    - ลดเวลาในการประมวลผลและต้นทุนการผลิต
    - สถาปัตยกรรมโมเดลหลายสิบแบบและจุดตรวจปรีเทรนมากกว่า 1 ล้านจุดสำหรับทุกโมดัลลิตี้

1. เลือกเฟรมเวิร์กที่เหมาะสมสำหรับทุกช่วงชีวิตของโมเดล:
    - ฝึกโมเดลล้ำสมัยใน 3 บรรทัดโค้ด
    - ย้ายโมเดลเดียวกันระหว่าง PyTorch/JAX/TF2.0 ได้อย่างอิสระ
    - เลือกเฟรมเวิร์กที่เหมาะสมสำหรับการฝึก, ประเมินผล และการนำไปใช้จริง

1. ปรับแต่งโมเดลหรือโค้ดตัวอย่างได้อย่างง่ายดาย:
    - เรามีตัวอย่างสำหรับแต่ละสถาปัตยกรรมเพื่อสร้างซ้ำผลลัพธ์ที่ผู้แต่งดั้งเดิมเผยแพร่
    - เปิดเผยโครงสร้างภายในของโมเดลให้มากที่สุดเท่าที่ทำได้
    - ไฟล์โมเดลสามารถนำไปใช้แยกจากไลบรารีเพื่อทดลองอย่างรวดเร็ว

<a target="_blank" href="https://huggingface.co/enterprise">
    <img alt="Hugging Face Enterprise Hub" src="https://github.com/user-attachments/assets/247fb16d-d251-4583-96c4-d3d76dda4925">
</a><br>

## ทำไมถึงอาจไม่ควรใช้ Transformers?

- ไลบรารีนี้ไม่ใช่กล่องเครื่องมือโมดูลาร์สำหรับสร้าง neural net โค้ดในไฟล์โมเดลไม่ได้ถูก refactor ด้วย abstraction เพิ่มเติมโดยตั้งใจ เพื่อให้นักวิจัยสามารถทดลองกับแต่ละโมเดลได้อย่างรวดเร็วโดยไม่ต้องเรียนรู้ abstraction/ไฟล์เพิ่ม
- API ฝึกสอนได้ถูกปรับแต่งให้เหมาะกับโมเดล PyTorch ที่ให้มาโดย Transformers สำหรับ loop machine learning ทั่วไป คุณควรใช้ไลบรารีอื่น เช่น [Accelerate](https://huggingface.co/docs/accelerate)
- [สคริปต์ตัวอย่าง]((https://github.com/huggingface/transformers/tree/main/examples)) เป็นเพียง *ตัวอย่าง* เท่านั้น อาจไม่สามารถใช้กับกรณีเฉพาะของคุณได้ทันที คุณจำเป็นต้องปรับแต่งโค้ดเพื่อให้เหมาะสม

## 100 โปรเจกต์ที่ใช้ Transformers

Transformers ไม่ใช่แค่เครื่องมือสำหรับใช้โมเดลปรีเทรน แต่ยังเป็นชุมชนของโปรเจกต์ที่สร้างขึ้นรอบๆ และ Hugging Face Hub เราต้องการให้ Transformers ช่วยให้นักพัฒนา นักวิจัย นักศึกษา อาจารย์ วิศวกร และใครก็ตามสามารถสร้างโปรเจกต์ในฝันได้

เพื่อฉลอง Transformers ครบ 100,000 ดาว เราขอเน้นย้ำถึงชุมชนผ่านหน้า [awesome-transformers](./awesome-transformers.md) ซึ่งรวบรวม 100 โปรเจกต์ที่น่าทึ่งที่สร้างด้วย Transformers

หากคุณเป็นเจ้าของหรือใช้โปรเจกต์ที่คิดว่าสมควรอยู่ในรายชื่อ กรุณาส่ง PR เพื่อเพิ่มได้เลย!

## ตัวอย่างโมเดล

คุณสามารถทดลองโมเดลส่วนใหญ่ของเราได้โดยตรงใน [หน้ารายละเอียดโมเดลบน Hub](https://huggingface.co/models)

ขยายแต่ละหมวดด้านล่างเพื่อดูตัวอย่างโมเดลสำหรับการใช้งานหลากหลาย

<details>
<summary>เสียง</summary>

- การจำแนกเสียงด้วย [Whisper](https://huggingface.co/openai/whisper-large-v3-turbo)
- การรู้จำเสียงพูดอัตโนมัติด้วย [Moonshine](https://huggingface.co/UsefulSensors/moonshine)
- การตรวจจับคำสำคัญด้วย [Wav2Vec2](https://huggingface.co/superb/wav2vec2-base-superb-ks)
- การสร้างเสียงต่อเสียงด้วย [Moshi](https://huggingface.co/kyutai/moshiko-pytorch-bf16)
- การแปลงข้อความเป็นเสียงด้วย [MusicGen](https://huggingface.co/facebook/musicgen-large)
- การแปลงข้อความเป็นเสียงพูดด้วย [Bark](https://huggingface.co/suno/bark)

</details>

<details>
<summary>วิสัยทัศน์คอมพิวเตอร์</summary>

- การสร้าง mask อัตโนมัติด้วย [SAM](https://huggingface.co/facebook/sam-vit-base)
- การประมาณความลึกด้วย [DepthPro](https://huggingface.co/apple/DepthPro-hf)
- การจำแนกภาพด้วย [DINO v2](https://huggingface.co/facebook/dinov2-base)
- การตรวจจับจุดสำคัญด้วย [SuperGlue](https://huggingface.co/magic-leap-community/superglue_outdoor)
- การจับคู่จุดสำคัญด้วย [SuperGlue](https://huggingface.co/magic-leap-community/superglue)
- การตรวจจับวัตถุด้วย [RT-DETRv2](https://huggingface.co/PekingU/rtdetr_v2_r50vd)
- การประมาณท่าทางด้วย [VitPose](https://huggingface.co/usyd-community/vitpose-base-simple)
- การแบ่งเซ็กเมนต์แบบสากลด้วย [OneFormer](https://huggingface.co/shi-labs/oneformer_ade20k_swin_large)
- การจำแนกวิดีโอด้วย [VideoMAE](https://huggingface.co/MCG-NJU/videomae-large)

</details>

<details>
<summary>มัลติโหมด</summary>

- เสียงหรือข้อความเป็นข้อความด้วย [Qwen2-Audio](https://huggingface.co/Qwen/Qwen2-Audio-7B)
- การตอบคำถามเอกสารด้วย [LayoutLMv3](https://huggingface.co/microsoft/layoutlmv3-base)
- ภาพหรือข้อความเป็นข้อความด้วย [Qwen-VL](https://huggingface.co/Qwen/Qwen2.5-VL-3B-Instruct)
- การบรรยายภาพด้วย [BLIP-2](https://huggingface.co/Salesforce/blip2-opt-2.7b)
- ความเข้าใจเอกสารด้วย OCR ด้วย [GOT-OCR2](https://huggingface.co/stepfun-ai/GOT-OCR-2.0-hf)
- การตอบคำถามตารางด้วย [TAPAS](https://huggingface.co/google/tapas-base)
- ความเข้าใจและสร้างมัลติโหมดแบบรวมด้วย [Emu3](https://huggingface.co/BAAI/Emu3-Gen)
- วิสัยทัศน์สู่ข้อความด้วย [Llava-OneVision](https://huggingface.co/llava-hf/llava-onevision-qwen2-0.5b-ov-hf)
- การตอบคำถามด้วยภาพด้วย [Llava](https://huggingface.co/llava-hf/llava-1.5-7b-hf)
- การแบ่งเซ็กเมนต์ตามนิยามในภาพด้วย [Kosmos-2](https://huggingface.co/microsoft/kosmos-2-patch14-224)

</details>

<details>
<summary>ประมวลผลภาษาธรรมชาติ (NLP)</summary>

- การเติมคำที่หายไปด้วย [ModernBERT](https://huggingface.co/answerdotai/ModernBERT-base)
- การรู้จำชื่อเอนทิตีด้วย [Gemma](https://huggingface.co/google/gemma-2-2b)
- การตอบคำถามด้วย [Mixtral](https://huggingface.co/mistralai/Mixtral-8x7B-v0.1)
- การสรุปเนื้อหาด้วย [BART](https://huggingface.co/facebook/bart-large-cnn)
- การแปลภาษาด้วย [T5](https://huggingface.co/google-t5/t5-base)
- การสร้างข้อความด้วย [Llama](https://huggingface.co/meta-llama/Llama-3.2-1B)
- การจำแนกข้อความด้วย [Qwen](https://huggingface.co/Qwen/Qwen2.5-0.5B)

</details>

## การอ้างอิง

ขณะนี้เรามี [เปเปอร์](https://www.aclweb.org/anthology/2020.emnlp-demos.6/) ที่คุณสามารถใช้อ้างอิงไลบรารี 🤗 Transformers ได้:
```bibtex
@inproceedings{wolf-etal-2020-transformers,
    title = "Transformers: State-of-the-Art Natural Language Processing",
    author = "Thomas Wolf and Lysandre Debut and Victor Sanh and Julien Chaumond and Clement Delangue and Anthony Moi and Pierric Cistac and Tim Rault and Rémi Louf and Morgan Funtowicz and Joe Davison and Sam Shleifer and Patrick von Platen and Clara Ma and Yacine Jernite and Julien Plu and Canwen Xu and Teven Le Scao and Sylvain Gugger and Mariama Drame and Quentin Lhoest and Alexander M. Rush",
    booktitle = "Proceedings of the 2020 Conference on Empirical Methods in Natural Language Processing: System Demonstrations",
    month = oct,
    year = "2020",
    address = "Online",
    publisher = "Association for Computational Linguistics",
    url = "https://www.aclweb.org/anthology/2020.emnlp-demos.6",
    pages = "38--45"
}
```


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---
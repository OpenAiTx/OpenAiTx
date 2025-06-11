<div align="center">

Megatron-LM & Megatron-Core
===========================
<h4>เทคนิคที่ปรับแต่งสำหรับ GPU เพื่อการเทรนโมเดลทรานส์ฟอร์มเมอร์ขนาดใหญ่</h4>

[![Documentation](https://img.shields.io/badge/docs-latest-brightgreen.svg?style=flat)](https://docs.nvidia.com/megatron-core/developer-guide/latest/index.html)
[![version](https://img.shields.io/badge/release-0.5.0-green)](./setup.py)
[![license](https://img.shields.io/badge/license-OpenBSD-blue)](./LICENSE)

<div align="left">

# ข่าวล่าสุด

- **[2024/7]** Megatron-Core v0.7 ปรับปรุงความสามารถในการสเกลและความทนทานในการเทรน พร้อมเพิ่มการรองรับการเทรนแบบมัลติโหมด ([blog](https://developer.nvidia.com/blog/train-generative-ai-models-more-efficiently-with-new-nvidia-megatron-core-functionalities/)). 
- **[2024/6]** Megatron-Core เพิ่มการรองรับโมเดลที่ใช้ Mamba ดูรายละเอียดในบทความ [An Empirical Study of Mamba-based Language Models](https://arxiv.org/pdf/2406.07887) และ [ตัวอย่างโค้ด](https://github.com/NVIDIA/Megatron-LM/tree/ssm/examples/mamba)
- **[2024/1 ประกาศ]** NVIDIA ได้ปล่อยฟีเจอร์หลักของ **Megatron-LM** สู่ [**Megatron-Core**](https://github.com/NVIDIA/Megatron-LM/tree/main/megatron/core) ใน repository นี้ Megatron-Core ได้ขยายเทคนิคที่ปรับแต่งสำหรับ GPU จาก Megatron-LM ด้วยนวัตกรรมใหม่ๆ ในการปรับแต่งระดับระบบ พร้อม API ที่ประกอบได้และโมดูลาร์ ศึกษา [Megatron-Core intro](#megatron-core) สำหรับรายละเอียดเพิ่มเติม

# สารบัญ

- [Megatron-LM \& Megatron-Core](#megatron-lm--megatron-core)
- [ข่าวล่าสุด](#latest-news)
- [สารบัญ](#table-of-contents)
- [ภาพรวมของ Megatron](#megatron-overview)
  - [Megatron-LM](#megatron-lm)
  - [Megatron-Core](#megatron-core)
- [ความเร็วในการเทรนและการสเกล](#training-speed-and-scalability)
- [การติดตั้ง](#setup)
  - [Docker (แนะนำ)](#docker-recommended)
  - [ตัวเลือกการติดตั้ง](#installation-options)
    - [ติดตั้งจาก PyPI](#install-from-pypi)
    - [ติดตั้งจากซอร์สโค้ด](#install-from-source)
  - [สิ่งที่ต้องเตรียม](#prerequisites)
  - [ดาวน์โหลดเช็คพอยต์](#downloading-checkpoints)
- [การใช้งาน](#usage)
- [การเทรน](#training)
  - [การเตรียมข้อมูล](#data-preprocessing)
  - [BERT Pretraining](#bert-pretraining)
  - [GPT Pretraining](#gpt-pretraining)
  - [T5 Pretraining](#t5-pretraining)
  - [Distributed Pretraining](#distributed-pretraining)
  - [Activation Checkpointing and Recomputation](#activation-checkpointing-and-recomputation)
  - [Distributed Optimizer](#distributed-optimizer)
  - [FlashAttention](#flashattention)
  - [GPT-3 Example](#gpt-3-example)
  - [Retro and InstructRetro](#retro-and-instructretro)
  - [Mamba-based Language Models](#mamba-based-language-models)
  - [Mixture of Experts](#mixture-of-experts)
- [การประเมินผลและงานต่างๆ](#evaluation-and-tasks)
  - [การสร้างข้อความ GPT](#gpt-text-generation)
    - [Detoxify GPT via Self-generation](#detoxify-gpt-via-self-generation)
  - [การประเมิน GPT](#gpt-evaluation)
    - [WikiText Perplexity Evaluation](#wikitext-perplexity-evaluation)
    - [LAMBADA Cloze Accuracy](#lambada-cloze-accuracy)
  - [BERT Task Evaluation](#bert-task-evaluation)
    - [RACE Evaluation](#race-evaluation)
    - [MNLI Evaluation](#mnli-evaluation)
  - [Llama-2 Inference and Finetuning](#llama-2-inference-and-finetuning)
- [การปรับแต่งและการนำโมเดลไปใช้งาน](#model-optimization-and-deployment)
  - [Quantization และ TensorRT-LLM Deployment](#quantization-and-tensorrt-llm-deployment)
- [ชุดข้อมูล](#datasets)
  - [การเก็บข้อมูลฝึก Wikipedia](#collecting-wikipedia-training-data)
  - [การเก็บข้อมูล GPT Webtext](#collecting-gpt-webtext-data)
- [การทำซ้ำผลลัพธ์](#reproducibility)
- [การแปลงเช็คพอยต์](#checkpoint-conversion)
  - [การแปลงคลาสโมเดล](#model-class-conversion)
  - [การแปลงฟอร์แมตเช็คพอยต์](#checkpoint-format-conversion)
- [โปรเจกต์ที่ใช้ Megatron](#projects-using-megatron)

# ภาพรวมของ Megatron
รีโพซิทอรีนี้ประกอบด้วยสององค์ประกอบหลัก: **Megatron-LM** และ **Megatron-Core** Megatron-LM เป็นเฟรมเวิร์กที่เน้นงานวิจัยซึ่งใช้ Megatron-Core สำหรับการเทรนโมเดลภาษาใหญ่ (LLM) ส่วน Megatron-Core เป็นไลบรารีเทคนิคการเทรนที่ปรับแต่งสำหรับ GPU พร้อมการสนับสนุนระดับโปรดักชั่นอย่างเป็นทางการ รวมถึง API ที่มีเวอร์ชัน และการออกรีลีสเป็นประจำ คุณสามารถใช้ Megatron-Core ร่วมกับ Megatron-LM หรือ [Nvidia NeMo Framework](https://docs.nvidia.com/deeplearning/nemo/user-guide/docs/en/main/nlp/nemo_megatron/mcore_customization.html) เพื่อโซลูชันแบบ end-to-end และบนคลาวด์ หรือจะรวมบล็อกพื้นฐานของ Megatron-Core เข้าในเฟรมเวิร์กการเทรนที่คุณต้องการก็ได้

## Megatron-LM
Megatron ([1](https://arxiv.org/pdf/1909.08053.pdf), [2](https://arxiv.org/pdf/2104.04473.pdf), และ [3](https://arxiv.org/pdf/2205.05198)) ได้รับการแนะนำครั้งแรกในปี 2019 และจุดประกายคลื่นนวัตกรรมในวงการ AI โดยเปิดโอกาสให้นักวิจัยและนักพัฒนาสามารถใช้ไลบรารีนี้เพื่อผลักดันความก้าวหน้าของ LLM ทุกวันนี้ เฟรมเวิร์กสำหรับนักพัฒนา LLM ที่ได้รับความนิยมจำนวนมากได้รับแรงบันดาลใจและสร้างขึ้นโดยใช้ไลบรารี Megatron-LM แบบโอเพ่นซอร์สโดยตรง ส่งผลให้เกิดโมเดลพื้นฐานและสตาร์ทอัพ AI ใหม่ๆ มากมาย เฟรมเวิร์กยอดนิยมที่สร้างบน Megatron-LM เช่น [Colossal-AI](https://github.com/hpcaitech/ColossalAI), [HuggingFace Accelerate](https://github.com/huggingface/accelerate), และ [NVIDIA NeMo Framework](https://www.nvidia.com/en-us/ai-data-science/generative-ai/nemo-framework/) รายชื่อโปรเจกต์ที่ใช้ Megatron โดยตรง ดูได้ที่ [ที่นี่](#projects-using-megatron)

## Megatron-Core
Megatron-Core เป็นไลบรารีโอเพ่นซอร์สบนพื้นฐาน PyTorch ที่รวมเทคนิคการเทรนที่ปรับแต่งสำหรับ GPU และการปรับแต่งระดับระบบขั้นสูง โดยนำเทคนิคเหล่านี้มาสร้างเป็น API ที่ประกอบและโมดูลาร์ได้ ให้ความยืดหยุ่นเต็มที่สำหรับนักพัฒนาและนักวิจัยโมเดลในการเทรนทรานส์ฟอร์เมอร์ขนาดใหญ่บนโครงสร้างพื้นฐานที่เร่งด้วย NVIDIA ไลบรารีนี้รองรับ GPU NVIDIA Tensor Core ทุกรุ่น รวมถึงการเร่งด้วย FP8 บน [สถาปัตยกรรม NVIDIA Hopper](https://www.nvidia.com/en-us/data-center/technologies/hopper-architecture/)

Megatron-Core มีบล็อกพื้นฐานเช่น กลไก attention, บล็อกและเลเยอร์ทรานส์ฟอร์เมอร์, เลเยอร์ normalization และเทคนิค embedding ฟังก์ชันเพิ่มเติม เช่น การคำนวณใหม่ของ activation และ distributed checkpointing ก็ถูกรวมมาในไลบรารีนี้เช่นกัน บล็อกพื้นฐานและฟังก์ชันทั้งหมดถูกปรับแต่งสำหรับ GPU และสามารถนำไปใช้กับกลยุทธ์ parallelization ขั้นสูงเพื่อประสิทธิภาพและเสถียรภาพสูงสุดบนโครงสร้างพื้นฐาน NVIDIA ส่วนสำคัญอีกอย่างของ Megatron-Core คือเทคนิค model parallelism ขั้นสูง (tensor, sequence, pipeline, context, และ MoE expert parallelism)

Megatron-Core สามารถใช้งานร่วมกับ [NVIDIA NeMo](https://www.nvidia.com/en-us/ai-data-science/products/nemo/) ซึ่งเป็นแพลตฟอร์ม AI สำหรับองค์กร หรือทดลองใช้งาน Megatron-Core กับ native PyTorch training loop [ที่นี่](https://github.com/NVIDIA/Megatron-LM/tree/main/examples) ศึกษาเพิ่มเติมได้ที่ [เอกสาร Megatron-Core](https://docs.nvidia.com/megatron-core/developer-guide/latest/index.html)


# ความเร็วในการเทรนและการสเกล
โค้ดเบสของเราสามารถเทรนโมเดลภาษาใหญ่ (เช่น โมเดลที่มีพารามิเตอร์นับแสนล้าน) ได้อย่างมีประสิทธิภาพด้วยทั้ง model และ data parallelism เพื่อแสดงให้เห็นว่าโค้ดของเราสเกลกับจำนวน GPU และขนาดโมเดลอย่างไร เราพิจารณาโมเดล GPT ขนาดตั้งแต่ 2 พันล้าน ถึง 462 พันล้านพารามิเตอร์ โดยทุกโมเดลใช้ขนาดคำศัพท์ 131,072 และ sequence length 4096 เราปรับเปลี่ยนขนาด hidden, จำนวน attention heads และจำนวนเลเยอร์ เพื่อให้ได้ขนาดโมเดลที่ต้องการ เมื่อขนาดโมเดลเพิ่มขึ้น เราก็เพิ่ม batch size ตามไปด้วย การทดลองใช้ GPU [H100](https://www.nvidia.com/en-us/data-center/h100/) สูงสุด 6144 ตัว เราใช้การซ้อนทับการสื่อสารของ data-parallel (`--overlap-grad-reduce --overlap-param-gather`), tensor-parallel (`--tp-comm-overlap`) และ pipeline-parallel (เปิดใช้งานโดยดีฟอลต์) กับการคำนวณ เพื่อเพิ่มการสเกล ผลลัพธ์ throughput ที่รายงานเป็น end-to-end training รวมทุกกระบวนการ เช่น การโหลดข้อมูล, ขั้นตอน optimizer, การสื่อสาร และแม้แต่ logging ทั้งหมด หมายเหตุว่าเราไม่ได้เทรนโมเดลเหล่านี้จนกว่าจะ convergence

![Model table](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/images/model_table.png)

ผลการ weak scaling ของเราแสดงให้เห็นถึงการสเกลที่มากกว่าเชิงเส้น (MFU เพิ่มจาก 41% สำหรับโมเดลที่เล็กที่สุดเป็น 47-48% สำหรับโมเดลที่ใหญ่ที่สุด) เพราะ GEMM ขนาดใหญ่จะมี arithmetic intensity สูงกว่าและประมวลผลได้มีประสิทธิภาพมากกว่า

![Weak scaling](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/images/weak_scaling.png)

เรายังทดสอบ strong scaling กับโมเดล GPT-3 มาตรฐาน (เวอร์ชันของเรามีมากกว่า 175 พันล้านพารามิเตอร์เล็กน้อยเนื่องจากขนาดคำศัพท์ใหญ่ขึ้น) จาก 96 H100 GPU จนถึง 4608 GPU โดยใช้ batch size 1152 sequence ตลอด การสื่อสารจะมีบทบาทมากขึ้นเมื่อขยายขนาด ทำให้ MFU ลดลงจาก 47% เป็น 42%

![Strong scaling](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/images/strong_scaling.png)


# การติดตั้ง

## Docker (แนะนำ)

ขอแนะนำให้ใช้ [PyTorch NGC Container](https://catalog.ngc.nvidia.com/orgs/nvidia/containers/pytorch) เวอร์ชันเดือนก่อนหน้า ไม่ใช่เวอร์ชันล่าสุด รีลีสของเราทุกครั้งจะอ้างอิงกับ NGC container เดือนก่อนหน้า เพื่อความเข้ากันได้และเสถียรภาพ คอนเทนเนอร์นี้มาพร้อมกับ dependencies ที่จำเป็นและคอนฟิกที่ปรับแต่งสำหรับ NVIDIA GPU แล้ว

```bash
# ดึง NGC container เดือนก่อนหน้า (แทนที่ 25.04 ด้วยเวอร์ชันเดือนก่อนหน้า)
docker pull nvcr.io/nvidia/pytorch:25.04-py3
```

```bash
# รันคอนเทนเนอร์พร้อม mount ไดเรกทอรี
docker run --gpus all -it --rm \
  -v /path/to/megatron:/workspace/megatron \
  -v /path/to/dataset:/workspace/dataset \
  -v /path/to/checkpoints:/workspace/checkpoints \
  nvcr.io/nvidia/pytorch:25.04-py3
```

## ตัวเลือกการติดตั้ง

### สิ่งที่ต้องเตรียม

- PyTorch (เวอร์ชันเสถียรล่าสุด)
- CUDA, cuDNN, NCCL (เวอร์ชันเสถียรล่าสุด)
- รองรับ FP8 บน NVIDIA Hopper, Ada และ Blackwell GPUs
- เพื่อประสิทธิภาพสูงสุด ควรใช้สถาปัตยกรรม NVIDIA Turing ขึ้นไป

### ติดตั้งจาก PyPI

ติดตั้งเวอร์ชันเสถียรล่าสุดด้วย pip:

```bash
# ติดตั้งรีลีสล่าสุด
pip install megatron-core
```

### ติดตั้งจากซอร์สโค้ด

```bash
# โคลนรีโพซิทอรี
git clone https://github.com/NVIDIA/Megatron-LM.git
cd Megatron-LM

# เลือกเช็คเอาท์รีลีสที่ต้องการ (ถ้ามี)
git checkout v0.11.0

# ติดตั้งแบบ development mode
pip install -e .
```

## ดาวน์โหลดเช็คพอยต์
เราได้เตรียม [BERT-345M](https://ngc.nvidia.com/catalog/models/nvidia:megatron_bert_345m) และ [GPT-345M](https://ngc.nvidia.com/catalog/models/nvidia:megatron_lm_345m) เช็คพอยต์ที่ผ่านการเทรนแล้ว สำหรับประเมินผลหรือเทรนต่อในงาน downstream ขั้นตอนแรกให้ [สมัครสมาชิก](https://ngc.nvidia.com/signup) และ [ตั้งค่า](https://ngc.nvidia.com/setup/installers/cli) NVIDIA GPU Cloud (NGC) Registry CLI ดูเอกสารการดาวน์โหลดโมเดลเพิ่มเติมได้ที่ [NGC documentation](https://docs.nvidia.com/dgx/ngc-registry-cli-user-guide/index.html#topic_6_4_1)

หรือจะดาวน์โหลดเช็คพอยต์โดยตรงด้วยคำสั่ง:

<pre>
BERT-345M-uncased: wget --content-disposition https://api.ngc.nvidia.com/v2/models/nvidia/megatron_bert_345m/versions/v0.1_uncased/zip -O megatron_bert_345m_v0.1_uncased.zip
BERT-345M-cased: wget --content-disposition https://api.ngc.nvidia.com/v2/models/nvidia/megatron_bert_345m/versions/v0.1_cased/zip -O megatron_bert_345m_v0.1_cased.zip
GPT-345M: wget --content-disposition https://api.ngc.nvidia.com/v2/models/nvidia/megatron_lm_345m/versions/v0.0/zip -O megatron_lm_345m_v0.0.zip
</pre>

โมเดลเหล่านี้ต้องใช้ไฟล์ vocabulary ในการรัน โดยไฟล์ WordPiece vocab ของ BERT สามารถแตกไฟล์จาก BERT ที่เทรนโดย Google ได้ที่: [uncased](https://s3.amazonaws.com/models.huggingface.co/bert/bert-large-uncased-vocab.txt), [cased](https://s3.amazonaws.com/models.huggingface.co/bert/bert-large-cased-vocab.txt) สำหรับ GPT [vocab file](https://s3.amazonaws.com/models.huggingface.co/bert/gpt2-vocab.json) และ [merge table](https://s3.amazonaws.com/models.huggingface.co/bert/gpt2-merges.txt) สามารถดาวน์โหลดได้โดยตรง

# การใช้งาน

หลังติดตั้งแล้ว มี workflow ให้เลือกหลายแบบ วิธีที่สมบูรณ์ที่สุดคือ:
1. เตรียมข้อมูล
2. เทรนล่วงหน้า (pretraining)
3. เทรนจูน (finetuning) (อาจข้ามได้ในงาน zero-shot)
4. ประเมินผล downstream หรือสร้างข้อความ

อย่างไรก็ตาม ขั้นตอนที่ 1 และ 2 สามารถแทนที่ด้วยการใช้ pretrained model ที่กล่าวถึงข้างต้น

เราได้เตรียมสคริปต์สำหรับ pretraining ทั้ง BERT และ GPT ไว้ในไดเรกทอรี [`examples`](./examples) รวมถึงสคริปต์สำหรับงาน downstream แบบ zero-shot และ fine-tuned เช่น MNLI, RACE, WikiText103, และ LAMBADA และยังมีสคริปต์สำหรับ GPT interactive text generation ด้วย

# การเทรน
## การเตรียมข้อมูล
ข้อมูลฝึกต้องผ่านการเตรียมล่วงหน้า โดยให้นำข้อมูลฝึกของคุณมาอยู่ในรูปแบบ json แบบหลวม (loose json) ซึ่งแต่ละบรรทัดคือ json หนึ่ง record เช่น:
<pre>
{"src": "www.nvidia.com", "text": "The quick brown fox", "type": "Eng", "id": "0", "title": "First Part"}
{"src": "The Internet", "text": "jumps over the lazy dog", "type": "Eng", "id": "42", "title": "Second Part"}
</pre>

ชื่อ field `text` ใน json สามารถเปลี่ยนได้ด้วย flag `--json-key` ใน [`preprocess_data.py`](./tools/preprocess_data.py) ข้อมูล metadata อื่นๆ เป็นทางเลือก ไม่ถูกใช้ในการเทรน

json แบบหลวมนี้จะถูกแปลงเป็นฟอร์แมตไบนารีสำหรับฝึก ใช้ `preprocess_data.py` แปลง json เป็น mmap ตัวอย่างสคริปต์สำหรับเตรียมข้อมูลเทรน BERT คือ:
<pre>
python tools/preprocess_data.py \
       --input my-corpus.json \
       --output-prefix my-bert \
       --vocab-file bert-vocab.txt \
       --tokenizer-type BertWordPieceLowerCase \
       --split-sentences
</pre>

ผลลัพธ์จะได้สองไฟล์ชื่อ `my-bert_text_sentence.bin` และ `my-bert_text_sentence.idx` ในที่นี้ โดย option `--data-path` ที่ใช้ในเทรน BERT ต้องระบุ path และชื่อไฟล์ (โดยไม่ต้องใส่นามสกุลไฟล์)

สำหรับ T5 ใช้การเตรียมข้อมูลแบบเดียวกับ BERT อาจเปลี่ยนชื่อเป็น:
<pre>
       --output-prefix my-t5 \
</pre>
มีการปรับแต่งเล็กน้อยสำหรับการเตรียมข้อมูลล่วงหน้า GPT ได้แก่ การเพิ่มตาราง merge, โทเค็นสิ้นสุดเอกสาร, การลบการแบ่งประโยค และการเปลี่ยนประเภท tokenizer:
<pre>
python tools/preprocess_data.py \
       --input my-corpus.json \
       --output-prefix my-gpt2 \
       --vocab-file gpt2-vocab.json \
       --tokenizer-type GPT2BPETokenizer \
       --merge-file gpt2-merges.txt \
       --append-eod
</pre>

ที่นี่ไฟล์ผลลัพธ์จะถูกตั้งชื่อว่า `my-gpt2_text_document.bin` และ `my-gpt2_text_document.idx` เช่นเดียวกับก่อนหน้านี้ ในการฝึก GPT ให้ใช้ชื่อไฟล์ที่ยาวกว่าโดยไม่รวมส่วนขยายเป็นค่า `--data-path`

อาร์กิวเมนต์เพิ่มเติมของบรรทัดคำสั่งถูกอธิบายไว้ในไฟล์ต้นฉบับ [`preprocess_data.py`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/tools/preprocess_data.py)

## การ Pretraining ของ BERT

สคริปต์ [`examples/bert/train_bert_340m_distributed.sh`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/bert/train_bert_340m_distributed.sh) ใช้สำหรับฝึก BERT ขนาด 345M พารามิเตอร์บน GPU เดียว จุดประสงค์หลักของการฝึกแบบ GPU เดียวคือการดีบัก เนื่องจากฐานโค้ดและอาร์กิวเมนต์ถูกปรับแต่งมาสำหรับการฝึกแบบกระจาย อาร์กิวเมนต์ส่วนใหญ่เข้าใจง่าย โดยค่าเริ่มต้น learning rate จะลดลงเชิงเส้นตลอดช่วง iteration การฝึก จากค่า `--lr` ไปยังค่าต่ำสุดที่กำหนดโดย `--min-lr` ตลอด `--lr-decay-iters` iterations สัดส่วนของ iteration ที่ใช้สำหรับ warmup กำหนดโดย `--lr-warmup-fraction` แม้จะเป็นการฝึกด้วย GPU เดียว ขนาด batch ที่กำหนดโดย `--micro-batch-size` คือ batch ขนาดเดียวของแต่ละรอบ forward-backward และโค้ดจะทำ step สะสม gradient จนกว่าจะถึง `global-batch-size` ซึ่งเป็น batch size ต่อรอบ ข้อมูลจะถูกแบ่งเป็นอัตราส่วน 949:50:1 สำหรับชุดฝึก/ตรวจสอบ/ทดสอบ (ค่าเริ่มต้นคือ 969:30:1) การแบ่งนี้เกิดขึ้นขณะรัน แต่จะเหมือนกันทุกครั้งที่ใช้ random seed เดียวกัน (1234 เป็นค่าเริ่มต้น หรือกำหนดเองด้วย `--seed`) เราใช้ `train-iters` เป็นจำนวน iteration การฝึกที่ต้องการ หรืออีกทางหนึ่ง สามารถใช้ `--train-samples` ซึ่งเป็นจำนวนตัวอย่างรวมที่ต้องการฝึก หากเลือกใช้ตัวเลือกนี้ จะต้องใช้ `--lr-decay-samples` แทน `--lr-decay-iters`

มีตัวเลือกสำหรับ logging, การบันทึก checkpoint และช่วงเวลาประเมินผล โปรดสังเกตว่า `--data-path` จะมี suffix `_text_sentence` ที่เพิ่มมาตั้งแต่ขั้นตอนเตรียมข้อมูล แต่ไม่รวมส่วนขยายไฟล์

อาร์กิวเมนต์เพิ่มเติมของบรรทัดคำสั่งถูกอธิบายไว้ในไฟล์ต้นฉบับ [`arguments.py`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/megatron/training/arguments.py)

ในการรัน `train_bert_340m_distributed.sh` ให้ปรับแต่งตามที่ต้องการ รวมถึงตั้งค่าตัวแปรแวดล้อมสำหรับ `CHECKPOINT_PATH`, `VOCAB_FILE`, และ `DATA_PATH` ให้แน่ใจว่าตั้งค่าเหล่านี้เป็น path ใน container จากนั้นเปิด container ที่ติดตั้ง Megatron และ mount path ที่จำเป็น (ตามที่อธิบายใน [Setup](#setup)) แล้วรันสคริปต์ตัวอย่าง

## การ Pretraining ของ GPT

สคริปต์ `examples/gpt3/train_gpt3_175b_distributed.sh` ใช้สำหรับฝึก GPT ขนาด 345M พารามิเตอร์บน GPU เดียว เช่นเดียวกับที่กล่าวข้างต้น การฝึกแบบ GPU เดียวส่วนใหญ่สำหรับการดีบัก เนื่องจากโค้ดนี้ถูกออกแบบมาสำหรับการฝึกแบบกระจาย

รูปแบบโดยรวมเหมือนกับสคริปต์ BERT ก่อนหน้า แต่มีความแตกต่างที่สำคัญ: โทเค็นไนเซอร์ที่ใช้คือ BPE (ต้องมีตาราง merge และไฟล์ vocabulary แบบ `json`) แทนที่จะเป็น WordPiece, สถาปัตยกรรมโมเดลรองรับ sequence ที่ยาวขึ้น (max position embedding ต้องมากกว่าหรือเท่ากับ sequence length สูงสุด) และ `--lr-decay-style` ถูกตั้งเป็น cosine decay  โปรดสังเกตว่า `--data-path` จะมี suffix `_text_document` ที่เพิ่มมาตั้งแต่ขั้นตอนเตรียมข้อมูล แต่ไม่รวมส่วนขยายไฟล์

อาร์กิวเมนต์เพิ่มเติมของบรรทัดคำสั่งถูกอธิบายไว้ในไฟล์ต้นฉบับ [`arguments.py`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/megatron/training/arguments.py)

สามารถรัน `train_gpt3_175b_distributed.sh` ด้วยวิธีเดียวกันกับ BERT ตั้งค่าตัวแปรแวดล้อมและปรับแต่งอื่น ๆ, เปิด container พร้อม mount ที่เหมาะสม แล้วรันสคริปต์
ดูรายละเอียดเพิ่มเติมใน [`examples/gpt3/README.md`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/gpt3/README.md)

## การ Pretraining ของ T5

คล้ายกับ BERT และ GPT สคริปต์ `examples/t5/train_t5_220m_distributed.sh` ใช้สำหรับฝึก T5 "base" (~220M พารามิเตอร์) บน GPU เดียว ความแตกต่างหลักจาก BERT และ GPT คือการเพิ่มอาร์กิวเมนต์ดังนี้เพื่อรองรับสถาปัตยกรรม T5:

* `--kv-channels` กำหนดขนาดมิติภายในของเมทริกซ์ "key" และ "value" ในกลไก attention ทั้งหมดในโมเดล สำหรับ BERT และ GPT ค่าเริ่มต้นคือขนาด hidden หารด้วยจำนวน attention heads แต่สามารถกำหนดเองได้สำหรับ T5

* `--ffn-hidden-size` กำหนดขนาด hidden ใน feed-forward networks ภายในเลเยอร์ transformer สำหรับ BERT และ GPT ค่าเริ่มต้นคือ 4 เท่าของ transformer hidden size แต่สามารถกำหนดเองได้สำหรับ T5

* `--encoder-seq-length` และ `--decoder-seq-length` กำหนด sequence length สำหรับ encoder และ decoder แยกจากกัน

อาร์กิวเมนต์อื่น ๆ คงเดิมเหมือนกับ BERT และ GPT pretraining รันตัวอย่างนี้ด้วยขั้นตอนเดียวกับสคริปต์อื่น ๆ ข้างต้น

ดูรายละเอียดเพิ่มเติมใน [`examples/t5/README.md`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/t5/README.md)

## การ Pretraining แบบ Distributed

สคริปต์ `pretrain_{bert,gpt,t5}_distributed.sh` ใช้ PyTorch distributed launcher สำหรับการฝึกแบบ distributed ดังนั้นการฝึกแบบ multi-node สามารถทำได้โดยการตั้งค่าตัวแปรแวดล้อมอย่างเหมาะสม ดู [เอกสารอย่างเป็นทางการของ PyTorch](https://pytorch.org/docs/stable/elastic/run.html#launcher-api) สำหรับรายละเอียดเพิ่มเติมของ [ตัวแปรแวดล้อม](https://pytorch.org/docs/stable/distributed.html#environment-variable-initialization) โดยค่าเริ่มต้น การฝึกแบบ multi-node จะใช้ [nccl](https://developer.nvidia.com/nccl) เป็น distributed backend มีอาร์กิวเมนต์เพิ่มเติมง่าย ๆ และการใช้ PyTorch distributed module กับ `torchrun` elastic launcher (เทียบเท่ากับ `python -m torch.distributed.run`) เป็นข้อกำหนดเพิ่มเติมเพียงอย่างเดียวสำหรับการฝึกแบบ distributed ดูตัวอย่างใน `pretrain_{bert,gpt,t5}_distributed.sh` สำหรับรายละเอียดเพิ่มเติม

เราใช้ parallelism สองรูปแบบ: data และ model parallelism การทำ data parallelism ของเราอยู่ใน `megatron/core/distributed` และรองรับการ overlap การลด gradient กับ backward pass เมื่อใช้ตัวเลือก `--overlap-grad-reduce`

นอกจากนี้ เราพัฒนา model-parallel แบบสองมิติที่เรียบง่ายและมีประสิทธิภาพ เพื่อใช้มิติแรก tensor model parallelism (แบ่ง execution ของ transformer module เดียวกันบน GPU หลายตัว ดู Section 3 ของ [บทความของเรา](https://arxiv.org/pdf/1909.08053.pdf)) ให้เพิ่ม flag `--tensor-model-parallel-size` เพื่อกำหนดจำนวน GPU ที่จะแบ่งโมเดล พร้อมกับอาร์กิวเมนต์ที่ส่งไปยัง distributed launcher ตามที่กล่าวไว้ข้างต้น สำหรับมิติที่สอง sequence parallelism ให้ระบุ `--sequence-parallel` ซึ่งต้องใช้ tensor model parallelism ด้วย เนื่องจากจะแบ่งข้าม GPU ชุดเดียวกัน (ดูรายละเอียดใน Section 4.2.2 ของ [บทความของเรา](https://arxiv.org/pdf/2205.05198.pdf))

หากต้องการใช้ pipeline model parallelism (sharding transformer modules เป็น stages และแต่ละ stage มีจำนวน transformer module เท่ากัน จากนั้น pipeline execution โดยแบ่ง batch ออกเป็น microbatch ขนาดเล็ก ดู Section 2.2 ของ [บทความของเรา](https://arxiv.org/pdf/2104.04473.pdf)) ให้ใช้ flag `--pipeline-model-parallel-size` เพื่อระบุจำนวน stages ที่จะแบ่งโมเดล (เช่น โมเดลที่มี 24 transformer layer แบ่งเป็น 4 stage แต่ละ stage จะได้ 6 layer)

มีตัวอย่างวิธีใช้ model parallelism ทั้งสองแบบนี้ในสคริปต์ตัวอย่างที่ลงท้ายด้วย `distributed_with_mp.sh`

นอกจากการเปลี่ยนแปลงเล็กน้อยนี้ การฝึกแบบ distributed จะเหมือนกับการฝึกบน GPU เดียวทุกประการ

สามารถเปิดใช้งาน interleaved pipelining schedule (ดูรายละเอียดเพิ่มเติมใน Section 2.2.2 ของ [บทความของเรา](https://arxiv.org/pdf/2104.04473.pdf)) ด้วยอาร์กิวเมนต์ `--num-layers-per-virtual-pipeline-stage` ซึ่งควบคุมจำนวน transformer layer ในแต่ละ virtual stage (โดยปกติกับ non-interleaved schedule, แต่ละ GPU จะรัน virtual stage เดียวกับ `NUM_LAYERS / PIPELINE_MP_SIZE` transformer layer) จำนวนเลเยอร์ในโมเดลควรหารด้วยค่านี้ลงตัว นอกจากนี้จำนวน microbatch ใน pipeline (คำนวณเป็น `GLOBAL_BATCH_SIZE / (DATA_PARALLEL_SIZE * MICRO_BATCH_SIZE)`) ต้องหารด้วย `PIPELINE_MP_SIZE` ลงตัวเมื่อใช้ schedule นี้ (มี assertion ตรวจสอบไว้ในโค้ด) interleaved schedule ไม่รองรับ pipeline ที่มี 2 stage (`PIPELINE_MP_SIZE=2`)

## Activation Checkpointing และ Recomputation

เพื่อลดการใช้หน่วยความจำ GPU เมื่อฝึกโมเดลขนาดใหญ่ เรารองรับ activation checkpointing และ recomputation หลายรูปแบบ โดยปกติ activation ทั้งหมดจะถูกเก็บไว้ในหน่วยความจำเพื่อใช้ตอน backprop แต่ด้วยเทคนิคนี้จะเก็บเฉพาะ activation ที่จุด "checkpoint" บางจุดในโมเดล ส่วนอื่น ๆ จะ recompute แบบ on-the-fly เมื่อจำเป็นสำหรับ backprop โปรดทราบว่า checkpointing แบบนี้คือ *activation* checkpointing ซึ่งแตกต่างจาก checkpointing ของ model parameters และ optimizer state ที่กล่าวถึงในส่วนอื่น

รองรับระดับความละเอียดในการ recompute 2 ระดับ: `selective` และ `full` โดย `selective` เป็นค่าเริ่มต้นและแนะนำให้ใช้เกือบทุกกรณี โหมดนี้จะเก็บ activation ที่ใช้พื้นที่น้อยและ recompute แพงไว้ใน memory และ recompute activation ที่ใช้พื้นที่มากแต่ recompute ถูกกว่า ดู [บทความของเรา](https://arxiv.org/pdf/2205.05198) สำหรับรายละเอียด คุณจะพบว่าโหมดนี้ให้ประสิทธิภาพสูงสุดและใช้ memory ต่ำสุดสำหรับ activation ในการเปิดใช้งาน selective activation recompute ให้ใช้ `--recompute-activations`

สำหรับกรณีที่ memory มีจำกัดมาก ๆ `full` recompute จะเก็บเพียง input ของ transformer layer หรือกลุ่ม layer (block) และ recompute อื่น ๆ ทั้งหมด เปิดใช้งาน full activation recompute ด้วย `--recompute-granularity full` โดยใน `full` activation recompute มีสองวิธี: `uniform` และ `block` เลือกโดยอาร์กิวเมนต์ `--recompute-method`

* วิธี `uniform` แบ่ง transformer layer ออกเป็นกลุ่มเท่า ๆ กัน (แต่ละกลุ่มขนาด `--recompute-num-layers`) และเก็บ input activation ของแต่ละกลุ่มไว้ baseline group size คือ 1 (กรณีนี้เก็บ input activation ของทุก layer) หาก GPU memory ไม่พอ การเพิ่มจำนวน layer ต่อกลุ่มจะลดการใช้ memory ทำให้ฝึกโมเดลใหญ่ขึ้นได้ เช่น ถ้า `--recompute-num-layers` เป็น 4 จะเก็บเฉพาะ input activation ของแต่ละกลุ่ม 4 layer เท่านั้น

* วิธี `block` จะ recompute input activation ของจำนวน layer ที่กำหนด (`--recompute-num-layers`) ในแต่ละ pipeline stage และเก็บ input activation ของ layer ที่เหลือไว้ การลด `--recompute-num-layers` จะเพิ่มการเก็บ input activation ของ layer มากขึ้น ทำให้ต้อง recompute activation น้อยลงขณะ backprop และประสิทธิภาพฝึกจะดีขึ้นแต่ใช้ memory เพิ่มขึ้น เช่น หากระบุให้ recompute 5 layer จาก 8 layer ต่อ pipeline stage จะมีการ recompute input activation เฉพาะ 5 layer แรกในขั้นตอน backprop ส่วน 3 layer สุดท้ายจะถูกเก็บไว้ สามารถเพิ่มค่า `--recompute-num-layers` ทีละน้อยจนการใช้ memory ต่ำพอที่จะพอดีกับหน่วยความจำที่มีอยู่ เพื่อใช้ memory ได้เต็มที่และประสิทธิภาพสูงสุด

## Distributed Optimizer

การใช้งาน: `--use-distributed-optimizer` รองรับกับโมเดลและข้อมูลทุกรูปแบบ

Distributed optimizer เป็นเทคนิคการประหยัดหน่วยความจำ โดยจะแจกจ่าย optimizer state อย่างเท่าเทียมกันข้าม data parallel rank (ต่างจากวิธีดั้งเดิมที่ replicate optimizer state ข้าม data parallel rank) ตามที่อธิบายไว้ใน [ZeRO: Memory Optimizations Toward Training Trillion Parameter Models](https://arxiv.org/abs/1910.02054) implementation ของเราจะแจกจ่าย optimizer state ทั้งหมดที่ไม่ซ้อนทับกับ model state เช่น เมื่อใช้ fp16 model params distributed optimizer จะเก็บ fp32 main params & grads แยกต่างหากและแจกจ่ายข้าม DP rank แต่ถ้าใช้ bf16 model params distributed optimizer จะใช้ fp32 main grads เดียวกันกับ model's fp32 grads ดังนั้นกรณีนี้ grads จะไม่ถูกแจกจ่าย (แต่ fp32 main params ยังคงแจกจ่ายเพราะแยกจาก bf16 model params)

ทฤษฎีการประหยัดหน่วยความจำจะแตกต่างกันไปขึ้นกับ dtype ของ param และ grad ใน implementation ของเรา จำนวน byte ต่อพารามิเตอร์เป็นดังนี้ ('d' คือ data parallel size):

| | Non-distributed optim | Distributed optim |
|-|-|-|
| fp16 param, fp16 grads | 20 | 4 + 16/d |
| bf16 param, fp32 grads | 18 | 6 + 12/d |
| fp32 param, fp32 grads | 16 | 8 + 8/d |

เช่นเดียวกับ data parallelism ปกติ สามารถ overlap การลด gradient (ในที่นี้คือ reduce-scatter) กับ backward pass ได้โดยใช้ flag `--overlap-grad-reduce` นอกจากนี้ สามารถ overlap การ all-gather ของ parameter กับ forward pass ได้โดยใช้ `--overlap-param-gather`

## FlashAttention

การใช้งาน: `--use-flash-attn` รองรับขนาด attention head สูงสุด 128

[FlashAttention](https://github.com/HazyResearch/flash-attention) เป็นอัลกอริทึมที่รวดเร็วและประหยัดหน่วยความจำสำหรับคำนวณ attention อย่างแม่นยำ ช่วยเร่งการฝึกโมเดลและลดการใช้หน่วยความจำ

การติดตั้ง FlashAttention:
```sh
pip install flash-attn
```

## ตัวอย่าง GPT-3

ใน `examples/gpt3/train_gpt3_175b_distributed.sh` เราได้ให้ตัวอย่างการตั้งค่า Megatron เพื่อฝึก [GPT-3](https://arxiv.org/abs/2005.14165) ขนาด 175 พันล้านพารามิเตอร์บน 1024 GPU สคริปต์นี้ออกแบบมาสำหรับ [slurm](https://slurm.schedmd.com/documentation.html) ร่วมกับปลั๊กอิน [pyxis](https://github.com/NVIDIA/pyxis) แต่สามารถนำไปใช้กับ scheduler อื่นได้ง่าย ใช้ tensor parallelism 8 ทาง และ pipeline parallelism 16 ทาง ด้วยตัวเลือก `global-batch-size 1536` และ `rampup-batch-size 16 16 5859375` การฝึกจะเริ่มด้วย global batch size 16 และเพิ่มขึ้นเป็น 1536 อย่างเชิงเส้นตลอด 5,859,375 ตัวอย่าง ด้วย step 16 ชุดข้อมูลฝึกอาจเป็นชุดเดียวหรือหลายชุดรวมกันพร้อม weight

เมื่อใช้ global batch size เต็มที่ 1536 บน 1024 A100 GPU แต่ละ iteration ใช้เวลาประมาณ 32 วินาที ทำได้ 138 teraFLOPs ต่อ GPU ซึ่งคิดเป็น 44% ของ theoretical peak FLOPs

## Retro และ InstructRetro

Retro [(Borgeaud et al., 2022)](https://arxiv.org/abs/2112.04426) เป็น language model แบบ autoregressive decoder-only ที่ pretrain ด้วย retrieval-augmentation
Retro รองรับการ scale อย่างมีประสิทธิภาพสำหรับ pretraining ขนาดใหญ่ โดยสามารถดึงข้อมูลจาก trillion token
การฝึกด้วย retrieval เป็นกลไกจัดเก็บความรู้เชิงข้อเท็จจริงที่มีประสิทธิภาพกว่าการจัดเก็บเชิงข้อเท็จจริงไว้ใน parameter ของเครือข่ายแบบปกติ ซึ่งช่วยลดขนาด parameter ของโมเดลลงขณะที่ได้ perplexity ต่ำกว่า GPT ปกติ
Retro ยังมีความยืดหยุ่นในการอัปเดต
knowledge ที่เก็บใน LMs [(Wang et al., 2023a)](https://arxiv.org/abs/2304.06762)
โดยอัปเดต retrieval database ได้โดยไม่ต้องฝึก LMs ใหม่

InstructRetro [(Wang et al., 2023b)](https://arxiv.org/abs/2310.07713) เพิ่มขนาด Retro ไปที่ 48B ซึ่งเป็น LLM ที่ pretrain ด้วย retrieval ที่ใหญ่ที่สุด (ณ ธันวาคม 2023)
โมเดลพื้นฐานที่ได้ Retro 48B มีประสิทธิภาพเหนือกว่า GPT counterpart ในแง่ perplexity อย่างมาก
เมื่อนำ instruction tuning มาปรับกับ Retro, InstructRetro มีผลลัพธ์ที่ดีกว่า GPT ที่ instruction tuned อย่างมีนัยสำคัญใน downstream task แบบ zero-shot โดยเฉลี่ย InstructRetro ดีกว่า GPT counterpart 7% บน 8 งาน short-form QA และ 10% บน 4 งาน long-form QA ที่ท้าทาย เรายังพบว่าสามารถ ablate encoder จากสถาปัตยกรรม InstructRetro และใช้ decoder backbone ของ InstructRetro เป็น GPT ได้โดยได้ผลลัพธ์ใกล้เคียงกัน

ใน repo นี้ เรามีคู่มือ reproduction แบบ end-to-end สำหรับ Retro และ InstructRetro ครอบคลุม
- **การสร้าง retrieval database** ที่รองรับหลายพันล้านถึงล้านล้าน token สำหรับฐานข้อมูล retrieval ขนาดใหญ่
- **การ pretrain ด้วย retrieval** ที่รองรับ pretrain ตั้งแต่เริ่มต้นและ pretrain จากโมเดล GPT เดิม (Retro-fitting)
- **Instruction tuning** ที่เรามีชุดข้อมูล instruction tuning แบบ open-source และ training recipe สำหรับ instruction tuning บน Retro
- **การประเมิน downstream task** ที่เรามีสคริปต์สำหรับ text generation และการประเมินผลสำหรับ zero-shot question answering

ดูรายละเอียดใน [tools/retro/README.md](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/tools/retro/README.md)

## Language Model ที่ใช้ Mamba

ดู [examples/mamba](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/mamba) สำหรับรายละเอียด

<!--
## REALM Pipeline
เรากำลังพัฒนา [REALM](https://arxiv.org/pdf/2002.08909.pdf) system ส่วนถัดไปนี้ (จะ) สะท้อนถึง 3 ขั้นตอนของการฝึก สำหรับตอนนี้เป็นเพียงโค้ด ICT เท่านั้น
โดยคร่าว ๆ คือ pretrain retriever module, จากนั้นฝึก language model และ retriever ร่วมกัน, และ finetune หัว question answering บน language model ที่ retriever ถูกตรึงค่าไว้

### Inverse Cloze Task (ICT) Pretraining
1. เตรียม corpus ในรูปแบบ JSON หลวม ๆ เพื่อสร้าง collection ของบล็อกข้อความขนาดคงที่เป็นหน่วยข้อมูลหลัก สำหรับ corpus เช่น Wikipedia จะมีหลายประโยคต่อ block และหลาย block ต่อเอกสาร
รัน `tools/preprocess_data.py` เพื่อสร้างชุดข้อมูลแบบ indexed dataset โดยใช้ argument `--split-sentences` เพื่อให้ประโยคเป็นหน่วยหลัก สำหรับ REALM ดั้งเดิมจะสร้าง 2 dataset คือ dataset ที่มี title ของแต่ละเอกสาร กับอีกชุดเป็น body
ดูตัวอย่างสคริปต์
<pre>
python preprocess_data.py \
    --input /path/to/corpus.json \
    --json-keys text title \
    --split-sentences \
    --tokenizer-type BertWordPieceLowerCase \
    --vocab-file /path/to/vocab.txt \
    --output-prefix corpus_indexed \
    --workers 5  # เหมาะสำหรับ 10 CPU core ปรับเพิ่มได้ตามจำนวน core
</pre>

2. ใช้ฟังก์ชัน map sample แบบ custom แทนที่ `megatron/legacy/data/realm_dataset_utils.get_block_samples_mapping` หากจำเป็น โดยต้อง implement ฟังก์ชันใหม่ใน C++ ที่ `megatron/core/datasets/helpers.cpp` โครงสร้างข้อมูล samples mapping ใช้สำหรับเลือกข้อมูลที่เป็น training sample ล่วงหน้าก่อน training loop
 samples mapping จะเก็บ metadata ที่จำเป็นทั้งหมดสำหรับสร้าง sample จาก dataset แบบ indexed หนึ่งชุดหรือมากกว่า ใน REALM, samples mapping จะเก็บ start และ end sentence index, document index (เพื่อหา title ที่ถูกต้องให้ body) และ unique ID สำหรับแต่ละ block
3. Pretrain BERT language model ด้วย `pretrain_bert.py` โดย sequence length เท่ากับ block size ใน token id โมเดลนี้ควรฝึกบน indexed dataset เดียวกับที่ใช้สำหรับ block ใน retrieval task
ใน REALM คือ bert base uncased ที่ฝึกด้วย hyperparameter มาตรฐาน
4. ใช้ `pretrain_ict.py` เพื่อฝึก `ICTBertModel` ซึ่งใช้ encoder แบบ BERT 2 ตัวสำหรับ encode query และ block เพื่อใช้ในการ retrieval
สคริปต์ด้านล่างนี้ฝึก ICT model ของ REALM โดยอ้างถึง BERT ที่ฝึกไว้แล้ว (step 3) ในอาร์กิวเมนต์ `--bert-load` batch size ที่ใช้ใน paper คือ 4096 ดังนั้นควรใช้ data parallel world size 32
<pre>
python pretrain_ict.py \
    --num-layers 12 \
    --num-attention-heads 12 \
    --hidden-size 768 \
    --batch-size 128 \
    --seq-length 256 \
    --max-position-embeddings 256 \
    --ict-head-size 128 \
    --train-iters 100000 \
    --bert-load /path/to/pretrained_bert \
    --load checkpoints \
    --save checkpoints \
    --data-path /path/to/indexed_dataset \
    --titles-data-path /path/to/titles_indexed_dataset \
    --vocab-file /path/to/vocab.txt \
    --lr 0.0001 \
    --num-workers 2 \
    --lr-decay-style linear \
    --weight-decay 1e-2 \
    --clip-grad 1.0 \
    --lr-warmup-fraction .01 \
    --save-interval 3000 \
    --query-in-block-prob 0.1 \
    --fp16

</pre>

### สร้างดัชนี Block Embeddings
หลังจากฝึก ICT model แล้ว สามารถฝัง dataset ของ block ทั้งหมดโดยสร้างโครงสร้าง `BlockData` หลังจากบันทึกแล้ว สามารถโหลดและใช้ร่วมกับ `FaissMIPSIndex` เพื่อค้นหา similarity อย่างรวดเร็ว ซึ่งเป็นหัวใจของ retrieval pipeline ที่เรียนรู้ ดัชนีเริ่มต้นสามารถสร้างด้วยสคริปต์ด้านล่างนี้ เหมาะกับการรันแบบ interactive และใช้ GPU หลายตัวบนหลาย node เพื่อ index ชุดข้อมูลขนาดใหญ่ได้รวดเร็ว

<pre>
python tools/create_doc_index.py \
    --num-layers 12 \
    --hidden-size 768 \
    --ict-head-size 128 \
    --num-attention-heads 12 \
    --batch-size 128 \
    --seq-length 256 \
    --max-position-embeddings 256 \
    --ict-load /path/to/pretrained_ict \
    --data-path /path/to/indexed_dataset \
    --titles-data-path /path/to/titles_indexed_dataset \
    --block-data-path embedded_blocks.pkl \
    --indexer-log-interval 1000 \
    --indexer-batch-size 128 \
    --vocab-file /path/to/vocab.txt \
    --num-workers 2 \
    --fp16
</pre>

-->

## Mixture of Experts
MoE (Mixture of Experts) เป็นสถาปัตยกรรม LLM ที่ทรงพลังซึ่งถูกนำมาใช้ในเฟรมเวิร์ก Megatron-Core โดยออกแบบมาเพื่อเพิ่มประสิทธิภาพและความสามารถในการขยายขนาดของโมเดลภาษาใหญ่ MoE ใช้ประโยชน์จาก **Expert Parallelism** โดยให้ผู้เชี่ยวชาญแต่ละคนถูกกระจายไปยัง worker ที่ต่างกัน ซึ่งแต่ละ worker จะประมวลผลชุดข้อมูลการฝึกที่แตกต่างกัน วิธีนี้ช่วยเพิ่มปริมาณงานการประมวลผลอย่างมีนัยสำคัญ ทำให้โมเดลสามารถทำงานได้ในระดับสูง เช่น 47% MFU ระหว่างการฝึก BF16 สำหรับ 8x7B บน H100

คุณสมบัติเด่นของ MoE:
- **เทคนิค Parallelism**: MoE ผสมผสานกลยุทธ์ parallelism หลายแบบ รวมถึง Expert Parallelism, Data Parallelism, Tensor Parallelism, Sequence Parallelism, Pipeline Parallelism และ Context Parallelism การผสมผสานนี้ช่วยให้รองรับโมเดลขนาดใหญ่ได้อย่างมีประสิทธิภาพ
- **Router และ Load Balancing**: ระบบใช้กลไกการส่งต่อขั้นสูง เช่น Top-K router และใช้อัลกอริธึม load balancing เพื่อเพิ่มประสิทธิภาพการกระจาย token ไปยังผู้เชี่ยวชาญแต่ละคน
- **การเพิ่มประสิทธิภาพการทำงาน**: เทคนิคเช่น GroupedGEMM และ FP8 training ช่วยเพิ่มประสิทธิภาพของโมเดล MoE โดยเฉพาะเมื่อมีผู้เชี่ยวชาญหลายคน
- **กลไก Token Dispatch**: MoE รองรับทั้งกลยุทธ์ dropless และ token drop เพื่อบริหารจัดการการกระจาย token ไปยังผู้เชี่ยวชาญได้อย่างมีประสิทธิผล

สำหรับภาพรวมโดยละเอียดเกี่ยวกับการตั้งค่าการฝึก MoE และการเพิ่มประสิทธิภาพ โปรดดูที่ README ฉบับเต็มที่ [megatron/core/transformer/moe/README.md](./megatron/core/transformer/moe/README.md)

# การประเมินผลและงานต่าง ๆ

เราได้จัดเตรียม command line arguments หลายรายการ ซึ่งระบุรายละเอียดไว้ในสคริปต์ด้านล่างนี้ เพื่อรองรับงาน downstream แบบ zero-shot และ fine-tuned หลากหลายรูปแบบ อย่างไรก็ตาม คุณสามารถ fine-tune โมเดลจาก checkpoint ที่ฝึกไว้ล่วงหน้าได้กับคอร์ปัสอื่น ๆ ตามต้องการ เพียงแค่เพิ่ม flag `--finetune` และปรับไฟล์อินพุตกับพารามิเตอร์การฝึกในสคริปต์ฝึกดั้งเดิม จำนวน iteration จะถูกรีเซ็ตเป็นศูนย์ และ optimizer กับสถานะภายในจะถูกตั้งค่าใหม่ หากการ fine-tune ถูกขัดจังหวะด้วยเหตุผลใด ๆ อย่าลืมลบ flag `--finetune` ออกก่อนดำเนินการต่อ ไม่เช่นนั้นการฝึกจะเริ่มใหม่ตั้งแต่ต้น

เนื่องจากการประเมินผลใช้หน่วยความจำน้อยกว่าการฝึกมาก จึงอาจเป็นประโยชน์ที่จะรวมโมเดลที่ฝึกแบบขนานไว้เพื่อใช้งานกับ GPU จำนวนน้อยลงในงาน downstream สคริปต์ต่อไปนี้ใช้สำหรับวัตถุประสงค์นี้ ตัวอย่างนี้อ่านโมเดล GPT ที่มี tensor model parallelism 4 ทาง และ pipeline model parallelism 4 ทาง แล้วเขียนออกเป็นโมเดลที่มี tensor และ pipeline parallelism อย่างละ 2 ทาง

<pre>
python tools/checkpoint/convert.py \
        --model-type GPT \
        --load-dir checkpoints/gpt3_tp4_pp4 \
        --save-dir checkpoints/gpt3_tp2_pp2 \
        --target-tensor-parallel-size 2 \
        --target-pipeline-parallel-size 2

</pre>

ตัวอย่างงาน downstream หลายรายการสำหรับทั้งโมเดล GPT และ BERT อธิบายไว้ด้านล่าง สามารถรันแบบ distributed และ model parallel ได้เช่นเดียวกับในสคริปต์ฝึก

## การสร้างข้อความด้วย GPT

เราได้รวม REST server อย่างง่ายสำหรับสร้างข้อความไว้ใน `tools/run_text_generation_server.py` สามารถรันโดยคล้ายกับการเริ่มงาน pretraining โดยระบุ checkpoint ที่ฝึกไว้ล่วงหน้าที่เหมาะสม นอกจากนี้ยังมีพารามิเตอร์เสริมบางอย่าง เช่น `temperature`, `top-k` และ `top-p` ดู `--help` หรือไฟล์ซอร์สสำหรับข้อมูลเพิ่มเติม ดูตัวอย่างวิธีรัน server ได้ที่ [examples/inference/run_text_generation_server_345M.sh](examples/inference/run_text_generation_server_345M.sh)

เมื่อ server ทำงานแล้ว คุณสามารถใช้ `tools/text_generation_cli.py` เพื่อ query ไปยัง server ได้ โดยรับ argument เดียวคือ host ที่ server ทำงานอยู่

<pre>
tools/text_generation_cli.py localhost:5000
</pre>

คุณยังสามารถใช้ CURL หรือเครื่องมืออื่น ๆ เพื่อ query ไปยัง server ได้โดยตรง:

<pre>
curl 'http://localhost:5000/api' -X 'PUT' -H 'Content-Type: application/json; charset=UTF-8'  -d '{"prompts":["Hello world"], "tokens_to_generate":1}'
</pre>

ดูตัวเลือก API เพิ่มเติมที่ [megatron/inference/text_generation_server.py](megatron/inference/text_generation_server.py)

### การลดพิษ GPT ด้วย Self-generation
เรามีตัวอย่างใน `examples/academic_paper_scripts/detxoify_lm/` สำหรับลดพิษของ language model โดยใช้ความสามารถการสร้างข้อความของ language model

ดูคำแนะนำแบบทีละขั้นตอนสำหรับการฝึก domain-adaptive และการลดพิษ LM ด้วย self-generated corpus ที่ [examples/academic_paper_scripts/detxoify_lm/README.md](examples/academic_paper_scripts/detxoify_lm/README.md)


## การประเมิน GPT
เราได้รวมสคริปต์ตัวอย่างสำหรับการประเมิน GPT บน WikiText perplexity และ LAMBADA Cloze accuracy

### การประเมิน WikiText Perplexity
เพื่อเปรียบเทียบกับงานวิจัยก่อนหน้าอย่างเที่ยงตรง เราประเมิน perplexity ที่ระดับคำบน [WikiText-103 test dataset](https://s3.amazonaws.com/research.metamind.io/wikitext/wikitext-103-v1.zip) และคำนวณ perplexity ให้เหมาะสมกับการเปลี่ยนแปลงของ token เมื่อใช้ subword tokenizer ของเรา

ใช้คำสั่งต่อไปนี้เพื่อประเมิน WikiText-103 บนโมเดลขนาด 345M พารามิเตอร์
<pre>
TASK="WIKITEXT103"

VALID_DATA=&#60;wikitext path&#62;.txt
VOCAB_FILE=gpt2-vocab.json
MERGE_FILE=gpt2-merges.txt
CHECKPOINT_PATH=checkpoints/gpt2_345m

COMMON_TASK_ARGS="--num-layers 24 \
                  --hidden-size 1024 \
                  --num-attention-heads 16 \
                  --seq-length 1024 \
                  --max-position-embeddings 1024 \
                  --fp16 \
                  --vocab-file $VOCAB_FILE"

python tasks/main.py \
       --task $TASK \
       $COMMON_TASK_ARGS \
       --valid-data $VALID_DATA \
       --tokenizer-type GPT2BPETokenizer \
       --merge-file $MERGE_FILE \
       --load $CHECKPOINT_PATH \
       --micro-batch-size 8 \
       --log-interval 10 \
       --no-load-optim \
       --no-load-rng
</pre>


### การประเมิน LAMBADA Cloze Accuracy
เพื่อคำนวณ LAMBADA cloze accuracy (ความแม่นยำในการทำนาย token สุดท้ายโดยดูจาก token ก่อนหน้า) เราใช้เวอร์ชันที่ detokenize และประมวลผลแล้วของ [LAMBADA dataset](https://github.com/cybertronai/bflm/blob/master/lambada_test.jsonl)

ใช้คำสั่งต่อไปนี้เพื่อประเมิน LAMBADA บนโมเดลขนาด 345M พารามิเตอร์ โปรดสังเกตว่า flag `--strict-lambada` ควรถูกใช้เพื่อบังคับให้ตรงกับทั้งคำ ตรวจสอบให้แน่ใจว่า `lambada` เป็นส่วนหนึ่งของ path ไฟล์

<pre>
TASK="LAMBADA"

VALID_DATA=&#60;lambada path&#62;.json
VOCAB_FILE=gpt2-vocab.json
MERGE_FILE=gpt2-merges.txt
CHECKPOINT_PATH=checkpoints/gpt2_345m
COMMON_TASK_ARGS=&#60;เช่นเดียวกับใน <a href="#wikitext-perplexity-evaluation">WikiText Perplexity Evaluation</a> ข้างต้น&#62;

python tasks/main.py \
       --task $TASK \
       $COMMON_TASK_ARGS \
       --valid-data $VALID_DATA \
       --tokenizer-type GPT2BPETokenizer \
       --strict-lambada \
       --merge-file $MERGE_FILE \
       --load $CHECKPOINT_PATH \
       --micro-batch-size 8 \
       --log-interval 10 \
       --no-load-optim \
       --no-load-rng
</pre>

argument บรรทัดคำสั่งเพิ่มเติมอธิบายไว้ในซอร์สไฟล์ [`main.py`](./tasks/main.py)

## การประเมินงาน BERT
### การประเมิน RACE
สคริปต์ต่อไปนี้จะ fine-tune โมเดล BERT สำหรับประเมินผลบน [RACE dataset](http://www.cs.cmu.edu/~glai1/data/race/) โฟลเดอร์ `TRAIN_DATA` และ `VALID_DATA` มีชุดข้อมูล RACE เป็นไฟล์ `.txt` แยกแต่ละไฟล์ โปรดสังเกตว่าสำหรับ RACE ขนาด batch คือจำนวน query RACE ที่ต้องประเมิน โดยแต่ละ query มีตัวอย่าง 4 ชุด ขนาด batch ที่ผ่านโมเดลจริงจะเป็น 4 เท่าของค่าที่ระบุในบรรทัดคำสั่ง

<pre>
TRAIN_DATA="data/RACE/train/middle"
VALID_DATA="data/RACE/dev/middle \
            data/RACE/dev/high"
VOCAB_FILE=bert-vocab.txt
PRETRAINED_CHECKPOINT=checkpoints/bert_345m
CHECKPOINT_PATH=checkpoints/bert_345m_race
COMMON_TASK_ARGS="--num-layers 24 \
                  --hidden-size 1024 \
                  --num-attention-heads 16 \
                  --seq-length 512 \
                  --max-position-embeddings 512 \
                  --fp16 \
                  --vocab-file $VOCAB_FILE"

COMMON_TASK_ARGS_EXT="--train-data $TRAIN_DATA \
                      --valid-data $VALID_DATA \
                      --pretrained-checkpoint $PRETRAINED_CHECKPOINT \
                      --save-interval 10000 \
                      --save $CHECKPOINT_PATH \
                      --log-interval 100 \
                      --eval-interval 1000 \
                      --eval-iters 10 \
                      --weight-decay 1.0e-1"

python tasks/main.py \
       --task RACE \
       $COMMON_TASK_ARGS \
       $COMMON_TASK_ARGS_EXT \
       --tokenizer-type BertWordPieceLowerCase \
       --epochs 3 \
       --micro-batch-size 4 \
       --lr 1.0e-5 \
       --lr-warmup-fraction 0.06
</pre>

### การประเมิน MNLI
สคริปต์ต่อไปนี้จะ fine-tune โมเดล BERT สำหรับประเมินผลกับ [MultiNLI sentence pair corpus](https://www.nyu.edu/projects/bowman/multinli/) เนื่องจากงาน matching เหล่านี้คล้ายกัน สคริปต์สามารถปรับแต่งอย่างรวดเร็วเพื่อใช้กับ [Quora Question Pairs](https://www.kaggle.com/quora/question-pairs-dataset) (QQP) ได้เช่นกัน

<pre>

TRAIN_DATA="data/glue_data/MNLI/train.tsv"
VALID_DATA="data/glue_data/MNLI/dev_matched.tsv \
            data/glue_data/MNLI/dev_mismatched.tsv"
PRETRAINED_CHECKPOINT=checkpoints/bert_345m
VOCAB_FILE=bert-vocab.txt
CHECKPOINT_PATH=checkpoints/bert_345m_mnli
COMMON_TASK_ARGS=&#60;เช่นเดียวกับใน <a href="#race-evaluation">RACE Evaluation</a> ข้างต้น&#62;
COMMON_TASK_ARGS_EXT=&#60;เช่นเดียวกับใน <a href="#race-evaluation">RACE Evaluation</a> ข้างต้น&#62;

python tasks/main.py \
       --task MNLI \
       $COMMON_TASK_ARGS \
       $COMMON_TASK_ARGS_EXT \
```
   --tokenizer-type BertWordPieceLowerCase \
   --epochs 5 \
   --micro-batch-size 8 \
   --lr 5.0e-5 \
   --lr-warmup-fraction 0.065
</pre>

## การทำ Inference และ Finetuning กับ Llama-2

Llama-2 [ชุดโมเดล](https://ai.meta.com/llama/) เป็นชุดโมเดลโอเพนซอร์สที่ผ่านการ pretrain และ finetune (สำหรับแชท) ซึ่งสามารถทำผลงานได้อย่างยอดเยี่ยมในหลากหลาย benchmark ณ เวลาที่เปิดตัว โมเดล Llama-2 สามารถทำผลงานได้ดีที่สุดในกลุ่มโมเดลโอเพนซอร์ส และยังสามารถแข่งขันกับโมเดลปิดอย่าง GPT-3.5 ได้ (ดู https://arxiv.org/pdf/2307.09288.pdf)

สามารถโหลด checkpoint ของ Llama-2 เข้าใช้งานกับ Megatron สำหรับการ inference และ finetune ได้ ดูเอกสาร [ที่นี่](docs/llama_mistral.md)

# การเพิ่มประสิทธิภาพโมเดลและการนำไปใช้งานจริง
Megatron-Core (MCore) ตระกูล `GPTModel` รองรับอัลกอริธึม quantization ขั้นสูงและการ inference ที่มีประสิทธิภาพสูงผ่าน TensorRT-LLM

## การ Quantization และการนำ TensorRT-LLM ไปใช้งานจริง
ดู [การเพิ่มประสิทธิภาพและการนำ Megatron Model ไปใช้งานจริง](examples/inference/quantization/README.md) สำหรับตัวอย่าง `llama2` และ `nemotron3`

# ชุดข้อมูล (Datasets)
เราไม่ได้โฮสต์ชุดข้อมูลใด ๆ สำหรับการฝึก GPT หรือ BERT แต่เราให้รายละเอียดกระบวนการเก็บรวบรวมข้อมูลเหล่านี้เพื่อให้สามารถทำซ้ำผลลัพธ์ได้

## การรวบรวมข้อมูลฝึกจาก Wikipedia
เราขอแนะนำให้ทำตามขั้นตอนการดึงข้อมูล Wikipedia ตามที่ Google research ระบุไว้: "การ pre-processing ที่แนะนำคือ ดาวน์โหลด [dump ล่าสุด](https://dumps.wikimedia.org/enwiki/latest/enwiki-latest-pages-articles.xml.bz2), ดึงข้อความด้วย [WikiExtractor.py](https://github.com/attardi/wikiextractor) และทำความสะอาดเพิ่มเติมเพื่อแปลงเป็น plain text"

แนะนำให้ใช้ argument `--json` ขณะใช้ WikiExtractor ซึ่งจะ dump ข้อมูล Wikipedia ให้อยู่ในรูปแบบ json (หนึ่งอ็อบเจกต์ json ต่อบรรทัด) ทำให้ง่ายต่อการจัดการและสามารถนำไปใช้กับ codebase ของเราได้ทันที แนะนำให้ preprocess ชุดข้อมูล json นี้เพิ่มเติมด้วยการมาตรฐานเครื่องหมายวรรคตอนด้วย nltk สำหรับการฝึก BERT ให้ใช้ flag `--split-sentences` กับ `preprocess_data.py` ตามที่อธิบาย [ข้างต้น](#data-preprocessing) เพื่อให้มีการแบ่งประโยคใน index ที่สร้างขึ้น หากต้องการใช้ข้อมูล Wikipedia กับการฝึก GPT ควรทำความสะอาดด้วย nltk/spacy/ftfy เช่นกัน แต่ไม่ควรใช้ flag `--split-sentences`

## การรวบรวมข้อมูล GPT Webtext
เราใช้ [OpenWebText](https://github.com/eukaryote31/openwebtext) library ที่มีให้ใช้งานสาธารณะจาก [jcpeterson](https://github.com/jcpeterson/openwebtext) และผลงานของ [eukaryote31](https://github.com/eukaryote31/openwebtext) เพื่อดาวน์โหลด url จากนั้นเราจะกรอง ทำความสะอาด และลบข้อมูลซ้ำทั้งหมดที่ดาวน์โหลดมา ตามขั้นตอนที่อธิบายไว้ใน [openwebtext](./tools/openwebtext) directory สำหรับ reddit URL ที่เป็นคอนเทนต์ถึงตุลาคม 2018 เราได้ข้อมูลประมาณ 37GB

# การทำซ้ำผลลัพธ์ (Reproducibility)
การฝึก Megatron สามารถทำให้ได้ผลลัพธ์ bitwise reproducible; เพื่อเปิดโหมดนี้ให้ใช้ `--deterministic-mode` หมายความว่าการรัน config การฝึกเดียวกันสองครั้งใน HW และ SW environment เดียวกันควรจะได้ checkpoint, loss, และค่า metric อื่น ๆ ที่เหมือนกันทุกประการ (แต่เวลา iteration อาจต่างกัน)

ปัจจุบันมี 3 optimization ใน Megatron ที่ทำให้การ reproducibility ไม่สมบูรณ์ แต่ยังได้ผลลัพธ์ที่เกือบเหมือนเดิม:
1. อัลกอริธึม NCCL ที่ใช้ระหว่าง all-reduce (ระบุด้วย environment variable `NCCL_ALGO`) มีความสำคัญ เราทดสอบดังนี้: `^NVLS`, `Tree`, `Ring`, `CollnetDirect`, `CollnetChain` โค้ดยอมรับ `^NVLS` ซึ่งให้ NCCL เลือกอัลกอริธึมที่ไม่ใช่ NVLS; การเลือกนี้ดูเหมือนจะเสถียร
2. Flash attention ไม่เป็น determinisitic; อย่าใช้ `--use-flash-attn`
3. หากใช้ Transformer Engine ต้องตั้งค่า environment variable `NVTE_ALLOW_NONDETERMINISTIC_ALGO=0` ด้วย

นอกจากนี้ determinism ได้รับการยืนยันแล้วเฉพาะใน NGC PyTorch containers รุ่น 23.12 ขึ้นไป หากพบ nondeterminism ในการฝึก Megatron ในสถานการณ์อื่น โปรดเปิด issue

# การแปลง Checkpoint

เรารองรับการแปลงโมเดล 2 รูปแบบ:

1. การแปลงคลาสของโมเดล (เช่น `GPTModel` ใน `model.legacy` กับ `model.core`)
2. การแปลงรูปแบบ checkpoint (distributed กับ non-distributed checkpoint)

## การแปลงคลาสของโมเดล

Megatron รองรับการแปลงระหว่างคลาสโมเดลต่าง ๆ รวมถึงคลาสโมเดลภายใน (ปัจจุบันมี `legacy` รุ่นเก่า และ `core` รุ่นใหม่) และคลาสโมเดลภายนอก (เช่น Meta, Huggingface, Mistral, และ Mixtral) นอกจากนี้ระหว่างการแปลง สามารถอัปเดตสถานะ parallel ของโมเดลได้ (เช่น เปลี่ยน tensor และ pipeline model parallelism)

เรามีเครื่องมือ `tools/checkpoint/convert.py` สำหรับแปลงระหว่างคลาสโมเดล โดย argument สำคัญได้แก่:

- `--model-type`: `GPT` หรือ `BERT`
- `--loader`: รูปแบบ checkpoint ที่มีอยู่ รองรับ:
  - `legacy`: คลาสโมเดลรุ่นเก่า (ใน `megatron.legacy.model`)
  - `core`: คลาสโมเดลรุ่นใหม่ (ใน `megatron.core.models`)
  - `llama_mistral`: สำหรับโหลด Llama และ Mistral (รองรับทั้ง Meta และ Huggingface)
  - `mixtral_hf`: สำหรับโหลด Mixtral (เฉพาะ Huggingface)
- `--load-dir`: โฟลเดอร์สำหรับโหลด checkpoint ที่มีอยู่
- `--saver`: `legacy` หรือ `core` (ดูคำอธิบายที่ `--loader`)
- `--save-dir`: โฟลเดอร์สำหรับบันทึก checkpoint ใหม่
- `--target-tensor-parallel-size`: ขนาด tensor model parallel ใหม่
- `--target-pipeline-parallel-size`: ขนาด pipeline model parallel ใหม่

สำหรับรายละเอียด argument เพิ่มเติม ดูที่ script หลัก (`convert.py`), script loader (`loader_core.py`, `loader_legacy.py`, `loader_llama_mistral.py`, `loader_mixtral_hf.py`), หรือ script saver (`saver_core.py`, `saver_legacy.py`)

ตัวอย่างคำสั่งสำหรับแปลง GPT model จากรูปแบบเก่า (`legacy`) เป็นรูปแบบใหม่ (`core`) จะมีลักษณะดังนี้:

```
python tools/checkpoint/convert.py \
>   --model-type GPT \
>   --loader legacy \
>   --load-dir ${LEGACY_FORMAT_DIR} \
>   --saver core \
>   --save-dir ${CORE_FORMAT_DIR} \
>   --target-tensor-parallel-size ${TP} \
>   --target-pipeline-parallel-size ${PP} \
```

สำหรับตัวอย่างการแปลง Llama/Mistral models ไปยัง Megatron ดูได้ที่ [ที่นี่](docs/llama_mistral.md)

## การแปลงรูปแบบ Checkpoint

Megatron รองรับ checkpoint ได้หลายรูปแบบ ได้แก่:

- `torch`: รูปแบบ checkpoint พื้นฐาน อ่าน/เขียนแบบ sequential และผูกกับ tensor/pipeline model parallel state (TP/PP) เฉพาะ (แม้ checkpoint จะผูกกับ TP/PP เฉพาะ แต่สามารถแปลงได้ด้วยตัวแปลงคลาสโมเดลดังที่อธิบายข้างต้น)
- `torch_dist`: รูปแบบ checkpoint แบบ distributed สำหรับอ่าน/เขียนแบบขนานที่รวดเร็ว และไม่ขึ้นกับสถานะ parallel (สามารถโหลด checkpoint เดียวกันกับ TP/PP ต่างกันได้)

โดยทั่วไป `torch_dist` เป็นรูปแบบ checkpoint ที่ทันสมัยกว่าและแนะนำเนื่องจากความเร็ว อย่างไรก็ตาม ขึ้นอยู่กับกรณีใช้งาน อาจต้องการแปลงระหว่างสองรูปแบบนี้ วิธีการคือ รัน *training* script ตามปกติ (เช่น `pretrain_gpt.py`) โดยเพิ่ม argument สองตัวนี้:

- `--ckpt-convert-format ${FORMAT}`: `${FORMAT}` คือ `torch` หรือ `torch_dist` ดังที่อธิบายข้างต้น
- `--ckpt-convert-save ${PATH_TO_SAVE_NEW_FORMAT}`: path นี้ควรแตกต่างจาก path ที่ใช้กับ `--load`/`--save` เพื่อไม่ให้ทับ checkpoint เดิม หลังจากแปลงแล้ว ให้ใช้ path ใหม่นี้กับ `--load`/`--save`

แนวคิดโดยรวมของตัวแปลง checkpoint นี้คือ จะ launch โมเดลเหมือนการฝึกปกติ แต่ก่อนเริ่ม iteration จะบันทึกเป็นรูปแบบใหม่แล้วออกจากโปรแกรม สำคัญว่าควรคง argument อื่น ๆ เหมือนเดิมทั้งหมด เพื่อให้ระบบเข้าใจรูปแบบ checkpoint เดิม

# โครงการที่ใช้ Megatron
ด้านล่างนี้เป็นโครงการที่ใช้ Megatron โดยตรง:
* [BERT and GPT Studies Using Megatron](https://arxiv.org/pdf/1909.08053.pdf)
* [BioMegatron: Larger Biomedical Domain Language Model](https://www.aclweb.org/anthology/2020.emnlp-main.379.pdf)
* [End-to-End Training of Neural Retrievers for Open-Domain Question Answering](https://arxiv.org/abs/2101.00408)
* [Large Scale Multi-Actor Generative Dialog Modeling](https://www.aclweb.org/anthology/2020.acl-main.8.pdf)
* [Local Knowledge Powered Conversational Agents](https://arxiv.org/abs/2010.10150)
* [MEGATRON-CNTRL: Controllable Story Generation with External Knowledge Using Large-Scale Language Models](https://www.aclweb.org/anthology/2020.emnlp-main.226.pdf)
* [RACE Reading Comprehension Dataset Leaderboard](http://www.qizhexie.com/data/RACE_leaderboard.html)
* [Training Question Answering Models From Synthetic Data](https://www.aclweb.org/anthology/2020.emnlp-main.468.pdf)
* [Few-shot Instruction Prompts for Pretrained Language Models to Detect Social Biases](https://arxiv.org/abs/2112.07868)
* [Exploring the Limits of Domain-Adaptive Training for Detoxifying Large-Scale Language Models](https://arxiv.org/abs/2202.04173)
* [Using DeepSpeed and Megatron to Train Megatron-Turing NLG 530B, A Large-Scale Generative Language Model](https://arxiv.org/abs/2201.11990)
* [Multi-Stage Prompting for Knowledgeable Dialogue Generation](https://arxiv.org/abs/2203.08745)
* [Evaluating Parameter Efficient Learning for Generation](https://aclanthology.org/2022.emnlp-main.319.pdf)
* [Exploring the Limits of Domain-Adaptive Training for Detoxifying Large-Scale Language Models](https://arxiv.org/abs/2202.04173)
* [Shall We Pretrain Autoregressive Language Models with Retrieval? A Comprehensive Study](https://arxiv.org/abs/2304.06762)
* [InstructRetro: Instruction Tuning post Retrieval-Augmented Pretraining](https://arxiv.org/abs/2310.07713)
* [An Empirical Study of Mamba-based Language Models](https://arxiv.org/abs/2406.07887)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---
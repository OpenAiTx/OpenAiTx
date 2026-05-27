
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=en">อังกฤษ</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=ja">ญี่ปุ่น</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=ko">เกาหลี</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=hi">ฮินดี</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=fr">ฝรั่งเศส</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=de">เยอรมัน</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=es">สเปน</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=it">อิตาลี</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=ru">รัสเซีย</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=pt">โปรตุเกส</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=nl">ดัตช์</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=pl">โปแลนด์</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=ar">อาหรับ</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=fa">เปอร์เซีย</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=tr">ตุรกี</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=vi">เวียดนาม</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=id">อินโดนีเซีย</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# น้อยก็เพียงพอ: สังเคราะห์ข้อมูลที่หลากหลายในพื้นที่คุณลักษณะของ LLMs

นี่คือการนำเสนอการใช้งานจริงของบทความ: `น้อยก็เพียงพอ: สังเคราะห์ข้อมูลที่หลากหลายในพื้นที่คุณลักษณะของ LLMs`

---

## ข้อมูลเชิงลึกหลัก

✨ **ทำงานอย่างชาญฉลาด ไม่ใช่แค่หนักขึ้น**

ในขั้นตอนหลังการฝึกของ LLMs แทนที่จะเพิ่มข้อความที่หลากหลายเพียงผิวเผินจำนวนมากโดยไร้ทิศทาง การระบุและสังเคราะห์คุณลักษณะสำคัญที่ขาดจริง ๆ อย่างแม่นยำจะมีประสิทธิภาพมากกว่า ด้วยตัวอย่างสังเคราะห์ที่ตรงเป้าหมายเพียงเล็กน้อย เราสามารถเติมช่องว่างใน **Feature Activation Coverage (FAC)** ได้อย่างมีนัยสำคัญ นำไปสู่การพัฒนาประสิทธิภาพที่ชัดเจนในงานต่อยอด

### เหตุใดข้อค้นพบนี้จึงเรียบง่ายแต่ทรงพลัง?

การสังเคราะห์ข้อมูลแบบดั้งเดิมเน้นปริมาณและความหลากหลายทางผิวเผิน (คำศัพท์ รูปแบบประโยค การกระจายหัวข้อ) แต่สิ่งเหล่านี้มักเป็นแค่ **ตัวแทนอ่อนแอ** สิ่งที่กำหนดผลการทำงานของโมเดลในงานต่อยอดจริง ๆ คือ **การครอบคลุมคุณลักษณะสำคัญที่งานเป้าหมายต้องการ**

งานของเราแสดงให้เห็นว่า:

- ข้อความจำนวนมากที่ "ดูแตกต่างกันมาก" แท้จริงแล้วกระตุ้นคุณลักษณะที่ซ้อนทับกันสูง;
- **FAC** ทำนายผลการทำงานในงานต่อยอดได้ดีกว่าตัวชี้วัดความหลากหลายมาตรฐาน รวมถึง **Distinct-1/2** และ **n-gram Entropy** ในระดับคำ **POS-tag Distinct-2** ในระดับไวยากรณ์ และ **Pair CosDist** กับ **Semantic Entropy** ในระดับ embedding  
- สำหรับการตามคำสั่ง **FAC Synthesis** ให้ผลลัพธ์เทียบเท่า SOTA เดิมอย่าง **MAGPIE** โดยใช้ข้อมูลน้อยกว่า MAGPIE ถึง **150×**

<p align="center">
  <img src="https://raw.githubusercontent.com/Zhongzhi660/FAC-Synthesis/main/figures/Figure_0.png" width="400" />
</p>

<p align="center">
  <b>รูปที่ 1:</b> เส้นประสิทธิภาพของชุดข้อมูลการตามคำสั่ง วิธีที่เสนอของเราได้ Win Rate ใน AlpacaEval 2.0 เทียบเท่า MAGPIE โดยใช้ตัวอย่างสังเคราะห์เพียง 2K (เทียบกับ 300K ของ MAGPIE)
</p>

---

## เริ่มต้นใช้งาน

### การติดตั้ง

```bash
git clone https://github.com/Zhongzhi660/FAC-Synthesis.git
cd FAC-Synthesis
pip install -r requirements.txt
```

---

### Repository Structure

```text
FAC-Synthesis/
├── LICENSE
├── README.md
├── requirements.txt
│
├── sae_pretrain/                 # SAE pretraining
│   ├── datasets/                 # pretraining corpora (constructed from public sources)
│   └── outputs/                  # SAE pre-trained weights
│
├── sae_feature_analysis/         # SAE feature analysis pipeline
│   ├── interpret_features/       # feature interpretation (span collection + annotation)
│   ├── identify_task_relevant_features/   # task-relevant feature identification
│   └── identify_missing_features/         # missing-feature discovery (coverage gap)
│
├── fac_synthesis/                # FAC synthesis pipeline
│   ├── step1_contrastive_pair_construction/      # Step-1: contrastive pair construction
│   └── step2_feature_covered_sample_synthesis/   # Step-2: feature-covered synthesis
│
└── training_scripts/             # Downstream training / evaluation scripts
    ├── toxicity_detection/
    ├── reward_modeling/
    ├── instruction_following/
    └── behavior_steering/
```

### การฝึกล่วงหน้า Sparse Autoencoders
สคริปต์ส่วนใหญ่สำหรับการฝึกล่วงหน้า SAE จะอยู่ใน `sae_pretrain/` เราได้จัดเตรียมจุดตรวจ SAE ที่ฝึกล่วงหน้าไว้แล้วบน Hugging Face:
- **Llama-3.1-8B-Instruct SAE**: [Zhongzhi1228/sae_llama_l16_h65536](https://huggingface.co/Zhongzhi1228/sae_llama_l16_h65536)
- **Qwen2-7B-Instruct SAE**: [Zhongzhi1228/sae_qwen_l14_h65536](https://huggingface.co/Zhongzhi1228/sae_qwen_l14_h65536)
- **Mistral-7B-Instruct SAE**: [Zhongzhi1228/sae_mistral_l16_h65536](https://huggingface.co/Zhongzhi1228/sae_mistral_l16_h65536)

ในการฝึกล่วงหน้า SAE ให้รันคำสั่งต่อไปนี้:

```bash
# Step-1: Collect hidden activations from the backbone LLM (e.g., layer 16)
python create_actvs_uni.py 0 0 1 meta-llama/Llama-3.1-8B-Instruct 16

# Step-2: Train SAEs on the target layer (e.g., layer 16)
python train_SAEs.py 0 16 meta-llama/Llama-3.1-8B-Instruct /sae_input/prompt_actvs_l16
```

### การวิเคราะห์คุณลักษณะของ SAE
สคริปต์การวิเคราะห์คุณลักษณะจะอยู่ใน `sae_feature_analysis/` หากต้องการจัดกลุ่มช่วงการกระตุ้นและสร้างการตีความคุณลักษณะที่อ่านง่ายสำหรับมนุษย์ ให้รัน:

```bash
# Step-1: Group extracted activation spans
python groupby_textspans.py /xxx/threshold_0.0

# Step-2: Annotate feature explanations based on grouped spans
python annotate_explanations.py /xxx/threshold_0.0.tsv

# Step-3: Identify task-relevant features from the explanations
python annotate_toxicity.py /xxx/threshold_0.0_explained.tsv

# Step-4: Identify missing features via FAC analysis
python identify_fac.py anchor_features.tsv (complete) task_features.tsv (currently available)
```

### การสังเคราะห์ข้อมูลโดยการนำทางด้วยการครอบคลุม
สคริปต์การสังเคราะห์ที่นำทางด้วยการครอบคลุมจะอยู่ใน fac_synthesis/. ในการสร้างคำถามสังเคราะห์ ให้รัน

```bash
# Step-1 (1): Contrastive Pair Construction
python generate_data_llama_r1.py \
  --features xxx.tsv \
  --out xxx \
  --temperature 0.8
# Step-1 (2): Feature-Covered Sample Synthesis
python analyze_step1_synthetic_data.py
python merge_step1_failed_cases.py

# Step-2: Feature-Covered Sample Synthesis
python generate_data_llama_r2.py \
  --features xxx.tsv \
  --out xxx \
  --temperature 0.8
```

---

## คำขอบคุณ

ในขั้นตอนการประเมินผล สคริปต์การฝึกและทดสอบแบบ downstream ของเราได้รับการปรับแต่งจากคลังโอเพ่นซอร์สดังต่อไปนี้:

- [RLHF-Reward-Modeling](https://github.com/RLHFlow/RLHF-Reward-Modeling)
- [CAA](https://github.com/nrimsky/CAA)
- [LLaMAFactory](https://github.com/hiyouga/LLaMAFactory)

## การอ้างอิง

หากคุณพบว่างานนี้เป็นประโยชน์ต่อการวิจัยของคุณ กรุณาอ้างอิงงานวิจัยของเรา 🤩:

```bibtex
@article{li2026less,
  title={Less is Enough: Synthesizing Diverse Data in Feature Space of LLMs},
  author={Li, Zhongzhi and Wu, Xuansheng and Li, Yijiang and Hu, Lijie and Liu, Ninghao},
  journal={arXiv preprint arXiv:2602.10388},
  year={2026}
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-27

---
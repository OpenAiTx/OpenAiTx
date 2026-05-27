
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Ít là đủ: Tổng hợp dữ liệu đa dạng trong không gian đặc trưng của LLMs

Đây là mã nguồn chính thức của bài báo: `Ít là đủ: Tổng hợp dữ liệu đa dạng trong không gian đặc trưng của LLMs`.

---

## Ý tưởng cốt lõi

✨ **Làm việc thông minh hơn, không chăm chỉ hơn.**

Trong giai đoạn huấn luyện hậu của các mô hình LLM, thay vì mù quáng thêm vào lượng lớn văn bản đa dạng bề mặt, việc xác định chính xác và tổng hợp những **đặc điểm then chốt thực sự còn thiếu** sẽ hiệu quả hơn. Chỉ với một số mẫu tổng hợp có mục tiêu, chúng ta có thể lấp đầy đáng kể các khoảng trống trong **Phạm vi Kích hoạt Đặc trưng (FAC)**, dẫn đến cải thiện rõ rệt hiệu suất ở các tác vụ hạ nguồn.

### Tại sao nhận định này vừa đơn giản vừa mạnh mẽ?

Tổng hợp dữ liệu truyền thống tập trung vào số lượng và đa dạng bề mặt (từ vựng, mẫu câu, phân phối chủ đề), nhưng chúng thường chỉ là **chỉ báo yếu**. Điều thực sự quyết định hiệu suất hạ nguồn của mô hình là **phạm vi bao phủ các đặc trưng then chốt mà nhiệm vụ mục tiêu yêu cầu**.

Công trình của chúng tôi chỉ ra rằng:

- Nhiều văn bản "trông rất khác nhau" thực chất lại kích hoạt các đặc trưng cực kỳ trùng lặp;
- **FAC** dự đoán hiệu suất hạ nguồn tốt hơn nhiều so với các chỉ số đa dạng tiêu chuẩn, bao gồm **Distinct-1/2** và **Độ Entropy n-gram** ở cấp độ từ, **Distinct-2 thẻ POS** ở cấp độ cú pháp, và **Pair CosDist** cùng **Semantic Entropy** ở cấp độ embedding.  
- Với tác vụ làm theo hướng dẫn, **FAC Synthesis** đạt hiệu suất tương đương SOTA trước đó là **MAGPIE**, trong khi chỉ cần **ít dữ liệu hơn 150 lần** so với MAGPIE.

<p align="center">
  <img src="https://raw.githubusercontent.com/Zhongzhi660/FAC-Synthesis/main/figures/Figure_0.png" width="400" />
</p>

<p align="center">
  <b>Hình 1:</b> Biên hiệu quả của các tập dữ liệu làm theo hướng dẫn. Phương pháp của chúng tôi đạt Win Rate trên AlpacaEval 2.0 tương đương MAGPIE chỉ với 2K mẫu tổng hợp (so với 300K của MAGPIE).
</p>

---

## Bắt đầu

### Cài đặt

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

### Huấn luyện trước Sparse Autoencoders
Hầu hết các script để huấn luyện trước SAE nằm trong thư mục `sae_pretrain/`. Chúng tôi cung cấp các checkpoint SAE đã được huấn luyện trước trên Hugging Face:
- **Llama-3.1-8B-Instruct SAE**: [Zhongzhi1228/sae_llama_l16_h65536](https://huggingface.co/Zhongzhi1228/sae_llama_l16_h65536)
- **Qwen2-7B-Instruct SAE**: [Zhongzhi1228/sae_qwen_l14_h65536](https://huggingface.co/Zhongzhi1228/sae_qwen_l14_h65536)
- **Mistral-7B-Instruct SAE**: [Zhongzhi1228/sae_mistral_l16_h65536](https://huggingface.co/Zhongzhi1228/sae_mistral_l16_h65536)

Để huấn luyện trước SAE, hãy chạy các lệnh sau:

```bash
# Step-1: Collect hidden activations from the backbone LLM (e.g., layer 16)
python create_actvs_uni.py 0 0 1 meta-llama/Llama-3.1-8B-Instruct 16

# Step-2: Train SAEs on the target layer (e.g., layer 16)
python train_SAEs.py 0 16 meta-llama/Llama-3.1-8B-Instruct /sae_input/prompt_actvs_l16
```

### Phân tích các tính năng của SAE
Các script phân tích tính năng nằm trong `sae_feature_analysis/`. Để nhóm các khoảng kích hoạt và tạo ra các diễn giải tính năng dễ hiểu cho con người, hãy chạy:

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

### Tổng hợp dữ liệu dựa trên phạm vi kiểm thử
Các script tổng hợp dựa trên phạm vi kiểm thử nằm trong fac_synthesis/. Để tạo truy vấn tổng hợp, hãy chạy

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

## Lời cảm ơn

Trong giai đoạn đánh giá, các tập lệnh huấn luyện và kiểm tra downstream của chúng tôi được điều chỉnh từ các kho mã nguồn mở sau:

- [RLHF-Reward-Modeling](https://github.com/RLHFlow/RLHF-Reward-Modeling)
- [CAA](https://github.com/nrimsky/CAA)
- [LLaMAFactory](https://github.com/hiyouga/LLaMAFactory)

## Trích dẫn

Nếu bạn thấy công trình này hữu ích cho nghiên cứu của mình, vui lòng trích dẫn bài báo của chúng tôi 🤩:

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
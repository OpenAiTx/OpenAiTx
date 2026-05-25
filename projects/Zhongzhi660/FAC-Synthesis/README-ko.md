# 적게 하는 것이 충분하다: LLM의 특징 공간에서 다양한 데이터 합성하기

이것은 논문 `Less is Enough: Synthesizing Diverse Data in Feature Space of LLMs`의 공식 구현입니다.

---

## 핵심 통찰

✨ **더 열심히 하기보다 더 똑똑하게 일하라.**

LLM의 사후 훈련 단계에서, 무작정 대량의 표면 수준의 다양한 텍스트를 추가하기보다는 **진정으로 부족한 핵심 특징**을 정확히 식별하고 합성하는 것이 더 효과적입니다. 소수의 목표 지향적 합성 샘플만으로도 **특징 활성화 커버리지 (FAC)**의 공백을 크게 메울 수 있어 하위 작업에서 명확한 성능 향상을 이끌어냅니다.

### 왜 이 통찰이 단순하면서도 강력한가?

전통적인 데이터 합성은 양과 표면적 다양성(어휘, 문장 패턴, 주제 분포)에 초점을 맞추지만, 이는 종종 **약한 대리 지표**에 불과합니다. 모델의 하위 작업 성능을 진정으로 결정하는 것은 **목표 작업에 필요한 핵심 특징의 커버리지**입니다.

우리 연구는 다음을 밝혀냅니다:

- "매우 달라 보이는" 많은 텍스트가 실제로는 매우 겹치는 특징을 활성화한다;
- **FAC**는 표준 다양성 지표들보다 하위 작업 성능을 훨씬 잘 예측한다. 여기에는 단어 수준의 **Distinct-1/2**와 **n-gram 엔트로피**, 구문 수준의 **POS-tag Distinct-2**, 임베딩 수준의 **Pair CosDist**와 **Semantic Entropy**가 포함된다.  
- 지시 수행에서는, **FAC 합성**이 이전 SOTA인 **MAGPIE**와 비슷한 성능을 달성하면서 MAGPIE보다 **150배 적은 데이터**를 요구한다.

<p align="center">
  <img src="https://raw.githubusercontent.com/Zhongzhi660/FAC-Synthesis/main/figures/Figure_0.png" width="400" />
</p>

<p align="center">
  <b>그림 1:</b> 지시 수행 데이터셋의 효율성 경계선. 제안된 방법은 2K개의 합성 샘플만 사용(대비 MAGPIE는 30만)하면서 AlpacaEval 2.0에서 MAGPIE와 비슷한 승률을 달성한다.
</p>

---

## 시작하기

### 설치

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
### 희소 오토인코더 사전 학습  
SAE 사전 학습을 위한 대부분의 스크립트는 `sae_pretrain/`에 위치해 있습니다. Hugging Face에서 사전 학습된 SAE 체크포인트를 제공합니다:  
- **Llama-3.1-8B-Instruct SAE**: [Zhongzhi1228/sae_llama_l16_h65536](https://huggingface.co/Zhongzhi1228/sae_llama_l16_h65536)  
- **Qwen2-7B-Instruct SAE**: [Zhongzhi1228/sae_qwen_l14_h65536](https://huggingface.co/Zhongzhi1228/sae_qwen_l14_h65536)  
- **Mistral-7B-Instruct SAE**: [Zhongzhi1228/sae_mistral_l16_h65536](https://huggingface.co/Zhongzhi1228/sae_mistral_l16_h65536)  

SAE를 사전 학습하려면, 다음 명령어를 실행하세요:


```bash
# Step-1: Collect hidden activations from the backbone LLM (e.g., layer 16)
python create_actvs_uni.py 0 0 1 meta-llama/Llama-3.1-8B-Instruct 16

# Step-2: Train SAEs on the target layer (e.g., layer 16)
python train_SAEs.py 0 16 meta-llama/Llama-3.1-8B-Instruct /sae_input/prompt_actvs_l16
```

### SAE 기능 분석
기능 분석 스크립트는 `sae_feature_analysis/`에 위치해 있습니다. 활성화 구간을 그룹화하고 사람이 읽을 수 있는 기능 해석을 생성하려면 다음을 실행하세요:

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

### 커버리지 기반 데이터 합성
커버리지 기반 합성 스크립트는 fac_synthesis/에 위치해 있습니다. 합성 쿼리를 생성하려면, 실행하세요

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

## 감사의 글

평가 단계에서, 우리의 다운스트림 학습 및 테스트 스크립트는 다음 오픈 소스 저장소에서 수정되었습니다:

- [RLHF-Reward-Modeling](https://github.com/RLHFlow/RLHF-Reward-Modeling)
- [CAA](https://github.com/nrimsky/CAA)
- [LLaMAFactory](https://github.com/hiyouga/LLaMAFactory)

## 인용

이 작업이 연구에 도움이 되었다면, 저희 논문을 인용해 주세요 🤩:

```bibtex
@article{li2026less,
  title={Less is Enough: Synthesizing Diverse Data in Feature Space of LLMs},
  author={Li, Zhongzhi and Wu, Xuansheng and Li, Yijiang and Hu, Lijie and Liu, Ninghao},
  journal={arXiv preprint arXiv:2602.10388},
  year={2026}
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-25

---
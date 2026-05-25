# 少ないほど十分：LLMの特徴空間における多様なデータの合成

これは論文「Less is Enough: Synthesizing Diverse Data in Feature Space of LLMs」の公式実装です。

---

## コアインサイト

✨ **賢く働き、無駄を省く。**

LLMの後処理段階では、大量の表面的に多様なテキストを無差別に追加するのではなく、**真に欠けている重要な特徴**を正確に特定して合成することがより効果的です。ごく少数のターゲットを絞った合成サンプルだけで、**特徴活性化カバレッジ（FAC）**のギャップを大幅に埋めることができ、下流タスクでの明確な性能向上につながります。

### なぜこのインサイトはシンプルでありながら強力なのか？

従来のデータ合成は量と表面的多様性（語彙、文パターン、トピック分布）に焦点を当てていますが、これらはしばしば**弱い代理指標**に過ぎません。モデルの下流性能を真に決定づけるのは、**ターゲットタスクが必要とする重要な特徴のカバレッジ**です。

我々の研究は以下を明らかにしました：

- 「非常に異なるように見える」多くのテキストは実際には非常に重複する特徴を活性化していること；
- **FAC**は、単語レベルの**Distinct-1/2**や**n-gramエントロピー**、構文レベルの**POSタグDistinct-2**、埋め込みレベルの**Pair CosDist**や**セマンティックエントロピー**を含む標準的な多様性指標よりも下流性能をはるかに良く予測すること。  
- 命令従属タスクにおいて、**FAC合成**は先行最先端の**MAGPIE**と同等の性能を達成しつつ、**MAGPIEの150倍少ないデータ量**で済むこと。

<p align="center">
  <img src="https://raw.githubusercontent.com/Zhongzhi660/FAC-Synthesis/main/figures/Figure_0.png" width="400" />
</p>

<p align="center">
  <b>図1：</b> 命令従属データセットの効率的フロンティア。我々の提案手法は、2Kの合成サンプル（MAGPIEは300K）でMAGPIEと同等のAlpacaEval 2.0における勝率を達成。
</p>

---

## はじめに

### インストール

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

### スパースオートエンコーダの事前学習
SAEの事前学習用スクリプトの大部分は`sae_pretrain/`にあります。Hugging Faceで事前学習済みのSAEチェックポイントを提供しています：
- **Llama-3.1-8B-Instruct SAE**: [Zhongzhi1228/sae_llama_l16_h65536](https://huggingface.co/Zhongzhi1228/sae_llama_l16_h65536)
- **Qwen2-7B-Instruct SAE**: [Zhongzhi1228/sae_qwen_l14_h65536](https://huggingface.co/Zhongzhi1228/sae_qwen_l14_h65536)
- **Mistral-7B-Instruct SAE**: [Zhongzhi1228/sae_mistral_l16_h65536](https://huggingface.co/Zhongzhi1228/sae_mistral_l16_h65536)

SAEを事前学習するには、以下のコマンドを実行してください：

```bash
# Step-1: Collect hidden activations from the backbone LLM (e.g., layer 16)
python create_actvs_uni.py 0 0 1 meta-llama/Llama-3.1-8B-Instruct 16

# Step-2: Train SAEs on the target layer (e.g., layer 16)
python train_SAEs.py 0 16 meta-llama/Llama-3.1-8B-Instruct /sae_input/prompt_actvs_l16
```

### SAEの特徴分析
特徴分析スクリプトは `sae_feature_analysis/` にあります。活性化スパンをグループ化し、人間が理解しやすい特徴の解釈を生成するには、次を実行してください：

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

### カバレッジ指向データ合成
カバレッジ指向合成スクリプトは fac_synthesis/ にあります。合成クエリを生成するには、次を実行してください。

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

## 謝辞

評価段階において、我々の下流のトレーニングおよびテストスクリプトは以下のオープンソースリポジトリから適応しています：

- [RLHF-Reward-Modeling](https://github.com/RLHFlow/RLHF-Reward-Modeling)
- [CAA](https://github.com/nrimsky/CAA)
- [LLaMAFactory](https://github.com/hiyouga/LLaMAFactory)

## 引用

この研究があなたの研究に役立った場合は、ぜひ私たちの論文を引用してください 🤩:

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
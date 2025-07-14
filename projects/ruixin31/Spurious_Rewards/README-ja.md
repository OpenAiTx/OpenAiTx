<div align="center">

![thinking-spongebob](https://raw.githubusercontent.com/ruixin31/Spurious_Rewards/main/figs/thinking-spongebob.png)

# 💭 偽報酬: RLVRにおける学習信号の再考

[Rulin Shao*](https://rulinshao.github.io/), [Shuyue Stella Li*](https://stellalisy.com/), [Rui Xin*](https://ruixin31.github.io/), [Scott Geng*](https://www.scottgeng.com/), [Yiping Wang](https://ypwang61.github.io/), [Sewoong Oh](https://homes.cs.washington.edu/~sewoong/), [Simon Shaolei Du](https://simonshaoleidu.com/), [Nathan Lambert](https://www.natolambert.com/), [Sewon Min](https://www.sewonmin.com/), [Ranjay Krishna](https://www.ranjaykrishna.com/index.html), [Yulia Tsvetkov](https://homes.cs.washington.edu/~yuliats/), [Hannaneh Hajishirzi](https://homes.cs.washington.edu/~hannaneh/), [Pang Wei Koh](https://koh.pw/), [Luke Zettlemoyer](https://www.cs.washington.edu/people/faculty/luke-zettlemoyer/)
</div>

<div align="center">

[![Github](https://img.shields.io/badge/Github-000000?style=for-the-badge&logo=github&logoColor=000&logoColor=white)](https://github.com/ruixin31/Rethink_RLVR)
[![Website](https://img.shields.io/badge/Site-000000.svg?style=for-the-badge&logo=notion&logoColor=white)](https://rethink-rlvr.notion.site/Spurious-Rewards-Rethinking-Training-Signals-in-RLVR-1f4df34dac1880948858f95aeb88872f) 
[![Paper](https://img.shields.io/badge/Paper-000000.svg?style=for-the-badge&logo=arxiv&logoColor=white)](http://arxiv.org/abs/2506.10947) 
[![Twitter](https://img.shields.io/badge/Twitter-000000?style=for-the-badge&logo=x&logoColor=white)](https://x.com/StellaLisy/status/1927392717593526780)
[![Wandb](https://img.shields.io/badge/📁_reproduction_W&B-000000?style=for-the-badge&logo=wandb&logoColor=white)](https://wandb.ai/rx31/SpuriousRewardRLVR)
[![Models](https://img.shields.io/badge/Models-000000?style=for-the-badge&logo=huggingface&logoColor=white)](https://huggingface.co/collections/stellalisy/spurious-rewards-684a38b8eeb32273c287a4db)

</div>


## セットアップ

```sh
# Our codebase is based on TTRL (https://github.com/PRIME-RL/TTRL).
git clone git@github.com:ruixin31/Spurious_Rewards
cd code

conda create -n spurious-rewards python=3.10 
conda activate spurious-rewards

pip install -r requirements.txt
pip install flash_attn==2.7.0.post2
pip install -e .
```
## トレーニング

```sh
bash scripts/rlvr_deepscaler_grpo_qwen_ground_truth.sh
```
## 設定

### データ
本論文では、フィルタリング済みおよび多数決ラベル付きデータを含めています。完全なリストは `code/data` ディレクトリにあります。例えば、正解データは `DeepScaleR` と呼ばれ、Llama 3.2 3B instruct でラベル付けされたデータのうち、誤ったラベルのみをフィルタしたものは `DeepScaleR_mv_labeled_llama3.2_3b_instruct_incorrect` フォルダにあります。データソースを変更するには、`code/scripts/rlvr_deepscaler_grpo_qwen_ground_truth.sh` 内の `TASK` 変数を変更してください。

### 報酬
本論文で使用した報酬リストを以下に示します。さらに、チャットテンプレートのないモデルについては、必ずサフィックスとして `_r1_only` を追加してください。報酬関数を変更するには、`code/scripts/rlvr_deepscaler_grpo_qwen_ground_truth.sh` 内の `REWARD` 変数を変更してください。

- `math`: 数学的等価性報酬（デフォルト）
- `box_only_format`: ボックスのみのフォーマット報酬
- `contain_python_wo_backticks`: Python 言及報酬
- `random0.5`: 50% の確率で 1 を返すランダム報酬


## 評価
評価結果を再現するには、以下のコマンドを使用してください:


```sh
cd code

# For MATH-500 evaluation (requires NVIDIA A100 80GB PCIe for exact reproduction)
python scripts/eval_checkpoint.py --model_path Qwen/Qwen2.5-Math-7B --datasets MATH-500,AIME-2024,AIME-2025,AMC

# For MATH-500 evaluation matching our reported scores in wandb using checkpoints (requires NVIDIA H200 for exact reproduction)
python scripts/eval_checkpoint.py --model_path {} --datasets MATH-500,AIME-2024,AIME-2025,AMC --shards 2
```
注意: `temperature = 0` の結果を正確に再現するには、GPUの種類と `--shards` パラメータの両方が元の評価設定と一致している必要があります。これは、VLLM に渡されるバッチサイズが生成の揺らぎを引き起こす可能性があるためです。

## 論文

こちらが私たちの論文の[リンク](http://arxiv.org/abs/2506.10947)です。

## 引用


```bibtex
@misc{shao2025spuriousrewardsrethinkingtraining,
      title={Spurious Rewards: Rethinking Training Signals in RLVR}, 
      author={Rulin Shao and Shuyue Stella Li and Rui Xin and Scott Geng and Yiping Wang and Sewoong Oh and Simon Shaolei Du and Nathan Lambert and Sewon Min and Ranjay Krishna and Yulia Tsvetkov and Hannaneh Hajishirzi and Pang Wei Koh and Luke Zettlemoyer},
      year={2025},
      eprint={2506.10947},
      archivePrefix={arXiv},
      primaryClass={cs.AI},
      url={https://arxiv.org/abs/2506.10947}, 
}
```
## 謝辞
このリポジトリは [TTRL](https://github.com/PRIME-RL/TTRL) を基に構築されており、TTRL は [OpenRLHF](https://github.com/OpenRLHF/OpenRLHF) の上に構築されています。
我々は、非同期評価などの独自機能をコードベースに追加しました。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-14

---
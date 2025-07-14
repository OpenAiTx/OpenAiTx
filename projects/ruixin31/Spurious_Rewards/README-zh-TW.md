<div align="center">

![thinking-spongebob](https://raw.githubusercontent.com/ruixin31/Spurious_Rewards/main/figs/thinking-spongebob.png)

# 💭 虛假獎勵：重新思考 RLVR 中的訓練訊號
  
[Rulin Shao*](https://rulinshao.github.io/)、[Shuyue Stella Li*](https://stellalisy.com/)、[Rui Xin*](https://ruixin31.github.io/)、[Scott Geng*](https://www.scottgeng.com/)、[Yiping Wang](https://ypwang61.github.io/)、[Sewoong Oh](https://homes.cs.washington.edu/~sewoong/)、[Simon Shaolei Du](https://simonshaoleidu.com/)、[Nathan Lambert](https://www.natolambert.com/)、[Sewon Min](https://www.sewonmin.com/)、[Ranjay Krishna](https://www.ranjaykrishna.com/index.html)、[Yulia Tsvetkov](https://homes.cs.washington.edu/~yuliats/)、[Hannaneh Hajishirzi](https://homes.cs.washington.edu/~hannaneh/)、[Pang Wei Koh](https://koh.pw/)、[Luke Zettlemoyer](https://www.cs.washington.edu/people/faculty/luke-zettlemoyer/)
</div>

<div align="center">

[![Github](https://img.shields.io/badge/Github-000000?style=for-the-badge&logo=github&logoColor=000&logoColor=white)](https://github.com/ruixin31/Rethink_RLVR)
[![Website](https://img.shields.io/badge/Site-000000.svg?style=for-the-badge&logo=notion&logoColor=white)](https://rethink-rlvr.notion.site/Spurious-Rewards-Rethinking-Training-Signals-in-RLVR-1f4df34dac1880948858f95aeb88872f) 
[![Paper](https://img.shields.io/badge/Paper-000000.svg?style=for-the-badge&logo=arxiv&logoColor=white)](http://arxiv.org/abs/2506.10947) 
[![Twitter](https://img.shields.io/badge/Twitter-000000?style=for-the-badge&logo=x&logoColor=white)](https://x.com/StellaLisy/status/1927392717593526780)
[![Wandb](https://img.shields.io/badge/📁_reproduction_W&B-000000?style=for-the-badge&logo=wandb&logoColor=white)](https://wandb.ai/rx31/SpuriousRewardRLVR)
[![Models](https://img.shields.io/badge/Models-000000?style=for-the-badge&logo=huggingface&logoColor=white)](https://huggingface.co/collections/stellalisy/spurious-rewards-684a38b8eeb32273c287a4db)

</div>


## 環境設置

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
## 訓練

```sh
bash scripts/rlvr_deepscaler_grpo_qwen_ground_truth.sh
```
## 設定

### 資料
我們在論文中包含了過濾過和多數標註的資料。您可以在 `code/data` 目錄中找到完整列表。例如，真實標註資料命名為 `DeepScaleR`，而 Llama 3.2 3B instruct 標註資料，僅保留錯誤標註者，則存於 `DeepScaleR_mv_labeled_llama3.2_3b_instruct_incorrect` 資料夾中。您可以通過更改 `code/scripts/rlvr_deepscaler_grpo_qwen_ground_truth.sh` 中的變數 `TASK` 來更換資料來源。

### 獎勵
我們在下方列出了論文中使用的獎勵清單。此外，請注意，對於沒有對話模板的模型，務必在後綴加上 `_r1_only`。您可以通過更改 `code/scripts/rlvr_deepscaler_grpo_qwen_ground_truth.sh` 中的變數 `REWARD` 來變更獎勵函數。

- `math`：數學等價性獎勵，為預設值
- `box_only_format`：僅限框架格式的獎勵
- `contain_python_wo_backticks`：提及 Python 的獎勵
- `random0.5`：隨機獎勵，有 50% 機率回傳 1


## 評估
要重現我們的評估結果，請使用下列指令：


```sh
cd code

# For MATH-500 evaluation (requires NVIDIA A100 80GB PCIe for exact reproduction)
python scripts/eval_checkpoint.py --model_path Qwen/Qwen2.5-Math-7B --datasets MATH-500,AIME-2024,AIME-2025,AMC

# For MATH-500 evaluation matching our reported scores in wandb using checkpoints (requires NVIDIA H200 for exact reproduction)
python scripts/eval_checkpoint.py --model_path {} --datasets MATH-500,AIME-2024,AIME-2025,AMC --shards 2
```
注意：要精確重現 `temperature = 0` 的結果，GPU 類型與 `--shards` 參數必須與原始評估設置相同。這是因為傳遞給 VLLM 的批次大小可能導致生成結果的波動。

## 論文

這裡是我們論文的[連結](http://arxiv.org/abs/2506.10947)。

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
## 致謝
本倉庫是基於 [TTRL](https://github.com/PRIME-RL/TTRL) 建立，而 TTRL 又是基於 [OpenRLHF](https://github.com/OpenRLHF/OpenRLHF) 開發的。我們在原有程式碼基礎上加入了非同步評估以及其他自訂功能。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-14

---
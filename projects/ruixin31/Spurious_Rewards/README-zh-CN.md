<div align="center">

![thinking-spongebob](https://raw.githubusercontent.com/ruixin31/Spurious_Rewards/main/figs/thinking-spongebob.png)

# 💭 虚假奖励：重新思考RLVR中的训练信号
  
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


## 环境配置

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
## 训练

```sh
bash scripts/rlvr_deepscaler_grpo_qwen_ground_truth.sh
```
## 配置

### 数据
我们在论文中包含了经过筛选和多数标签的数据。您可以在 `code/data` 目录中找到完整列表。例如，真实标签数据命名为 `DeepScaleR`，而经过筛选仅保留错误标签的 Llama 3.2 3B instruct 标注数据在 `DeepScaleR_mv_labeled_llama3.2_3b_instruct_incorrect` 文件夹中。您可以通过更改 `code/scripts/rlvr_deepscaler_grpo_qwen_ground_truth.sh` 中的 `TASK` 变量来更改数据源。

### 奖励
我们在下方列出了论文中使用的奖励列表。此外，请注意，对于没有聊天模板的模型，请确保在后缀中添加 `_r1_only`。您可以通过更改 `code/scripts/rlvr_deepscaler_grpo_qwen_ground_truth.sh` 中的 `REWARD` 变量来更改奖励函数。

- `math`：数学等价奖励，默认为此选项
- `box_only_format`：仅框格式奖励
- `contain_python_wo_backticks`：提及 Python 的奖励
- `random0.5`：50% 概率返回 1 的随机奖励


## 评估
要复现我们的评估结果，请使用以下命令：


```sh
cd code

# For MATH-500 evaluation (requires NVIDIA A100 80GB PCIe for exact reproduction)
python scripts/eval_checkpoint.py --model_path Qwen/Qwen2.5-Math-7B --datasets MATH-500,AIME-2024,AIME-2025,AMC

# For MATH-500 evaluation matching our reported scores in wandb using checkpoints (requires NVIDIA H200 for exact reproduction)
python scripts/eval_checkpoint.py --model_path {} --datasets MATH-500,AIME-2024,AIME-2025,AMC --shards 2
```
注意：要精确复现 `temperature = 0` 的结果，GPU 类型和 `--shards` 参数都必须与原始评测设置一致。这是因为传递给 VLLM 的批处理大小可能导致生成波动。

## 论文

这是我们的论文[链接](http://arxiv.org/abs/2506.10947)。

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
## 致谢
本仓库基于 [TTRL](https://github.com/PRIME-RL/TTRL) 构建，而 TTRL 又是基于 [OpenRLHF](https://github.com/OpenRLHF/OpenRLHF) 开发的。我们在代码库中添加了异步评估等自定义功能。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-14

---
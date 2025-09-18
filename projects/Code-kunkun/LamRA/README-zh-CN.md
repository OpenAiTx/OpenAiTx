# LamRA：作为您的高级检索助手的大型多模态模型

本仓库是 LamRA 的官方实现。

[🏡 项目主页](https://code-kunkun.github.io/LamRA/) |  [📄 论文](https://arxiv.org/pdf/2412.01720) | [🤗 LamRA-Ret-预训练模型](https://huggingface.co/code-kunkun/LamRA-Ret-Pretrained) | [🤗 LamRA-Ret](https://huggingface.co/code-kunkun/LamRA-Ret) | [🤗 LamRA-Rank](https://huggingface.co/code-kunkun/LamRA-Rank) | [🤗 数据集](https://huggingface.co/datasets/code-kunkun/LamRA_Eval)

## 安装

```bash 
conda create -n lamra python=3.10 -y
conda activate lamra 

pip install --upgrade pip  # enable PEP 660 support 
pip install -r requirements.txt

pip install ninja
pip install flash-attn --no-build-isolation
```
## 新版本
我们已在 `qwen2.5vl` 分支更新了 Qwen2.5-VL 的版本。

## 快速开始
请参考 `demo.py`

## 数据准备

下载 Qwen2-VL-7B 并放置在 `./checkpoints/hf_models/Qwen2-VL-7B-Instruct`

有关预训练数据集，请参考 [链接](https://huggingface.co/datasets/princeton-nlp/datasets-for-simcse)

有关多模态指令调优数据集，请参考 [M-BEIR](https://huggingface.co/datasets/TIGER-Lab/M-BEIR)

有关 LamRA 相关的评估数据，请参考 [LamRA_Eval](https://huggingface.co/datasets/code-kunkun/LamRA_Eval)

下载完成后，将数据按如下方式组织到 `./data` 中

```
├── M-BEIR
├── nli_for_simcse.csv
├── rerank_data_for_training
├── flickr
├── coco
├── sharegpt4v
├── Urban1K
├── circo
├── genecis
├── vist
├── visdial
├── ccneg
├── sugar-crepe
├── MSVD
└── msrvtt
```

## LamRA-Ret 的训练与评估

### 预训练

```bash 
sh scripts/lamra_ret/pretrain.sh
```

```bash 
# Evaluation 
sh scripts/eval/eval_pretrained.sh
```

```bash 
# Merge LoRA for multimodal instruction tuning stage
sh scripts/merge_lora.sh 
```

### 多模态指令调优

```bash
sh scripts/lamra_ret/finetune.sh
```

```bash 
# Evaluation 
sh scripts/eval/eval_mbeir.sh   # eval under local pool setting

sh scripts/eval/eval_mbeir_global.sh   # eval under global pool setting
```

## LamRA-Rank 的训练与评估

您可以使用我们提供的[数据](https://huggingface.co/datasets/code-kunkun/LamRA_Eval/tree/main/rerank_data_for_training)，或者运行以下命令获取用于重排序训练的数据。

```bash
# Collecting data for reranking training
sh scripts/lamra_rank/get_train_data.sh

sh scripts/lamra_rank/merge_train_data.sh
```

```bash
# training for reranking
sh scripts/lamra_rank/train_rerank.sh
```

```bash 
# pointwise reranking
sh scripts/eval/eval_rerank_mbeir_pointwise.sh

# listwise reranking
sh scripts/eval/eval_rerank_mbeir_listwise.sh
```

```bash
# Get the reranking results on M-BEIR
sh scirpts/eval/get_rerank_results_mbeir.sh
```

## 其他基准评估

```bash
# evaluation results on zeroshot datasets
sh scirpts/eval/eval_zeroshot.sh

# reranking the results on zeroshot datasets
sh scripts/eval/eval_rerank_zeroshot.sh

# get the final results
sh scripts/eval/get_rerank_results_zeroshot.sh
```

## 🫡 致谢

非常感谢来自 [lmms-finetune](https://github.com/zjysteven/lmms-finetune) 和 [E5-V](https://github.com/kongds/E5-V) 的代码库。


## 引用
如果您在研究或项目中使用此代码，请引用：

```latex
@inproceedings{liu2025lamra,
  title={Lamra: Large multimodal model as your advanced retrieval assistant},
  author={Liu, Yikun and Zhang, Yajie and Cai, Jiayin and Jiang, Xiaolong and Hu, Yao and Yao, Jiangchao and Wang, Yanfeng and Xie, Weidi},
  booktitle={Proceedings of the Computer Vision and Pattern Recognition Conference},
  pages={4015--4025},
  year={2025}
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-18

---
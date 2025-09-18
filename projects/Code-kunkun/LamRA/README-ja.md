# LamRA: 高度な検索アシスタントとしての大規模マルチモーダルモデル

このリポジトリはLamRAの公式実装です。

[🏡 プロジェクトページ](https://code-kunkun.github.io/LamRA/) |  [📄 論文](https://arxiv.org/pdf/2412.01720) | [🤗 LamRA-Ret-Pretrained](https://huggingface.co/code-kunkun/LamRA-Ret-Pretrained) | [🤗 LamRA-Ret](https://huggingface.co/code-kunkun/LamRA-Ret) | [🤗 LamRA-Rank](https://huggingface.co/code-kunkun/LamRA-Rank) | [🤗 データセット](https://huggingface.co/datasets/code-kunkun/LamRA_Eval)

## インストール

```bash 
conda create -n lamra python=3.10 -y
conda activate lamra 

pip install --upgrade pip  # enable PEP 660 support 
pip install -r requirements.txt

pip install ninja
pip install flash-attn --no-build-isolation
```

## 新バージョン
`qwen2.5vl` ブランチで Qwen2.5-VL のバージョンを更新しました。

## クイックスタート
`demo.py` を参照してください。

## データ準備 

Qwen2-VL-7B をダウンロードし、`./checkpoints/hf_models/Qwen2-VL-7B-Instruct` に配置してください。

事前学習用データセットについては、[こちら](https://huggingface.co/datasets/princeton-nlp/datasets-for-simcse) を参照してください。

マルチモーダル指示調整用データセットについては、[M-BEIR](https://huggingface.co/datasets/TIGER-Lab/M-BEIR) を参照してください。

LamRA 関連の評価データについては、[LamRA_Eval](https://huggingface.co/datasets/code-kunkun/LamRA_Eval) を参照してください。

すべてダウンロード後、`./data` に以下のようにデータを整理してください。
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

## LamRA-Retのトレーニングと評価

### 事前学習

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

### マルチモーダル指示調整

```bash
sh scripts/lamra_ret/finetune.sh
```

```bash 
# Evaluation 
sh scripts/eval/eval_mbeir.sh   # eval under local pool setting

sh scripts/eval/eval_mbeir_global.sh   # eval under global pool setting
```

## LamRA-Rank のトレーニングと評価

提供している[data](https://huggingface.co/datasets/code-kunkun/LamRA_Eval/tree/main/rerank_data_for_training)を使用するか、以下のコマンドを実行してリランキングトレーニング用のデータを取得できます。

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

## 他のベンチマークでの評価

```bash
# evaluation results on zeroshot datasets
sh scirpts/eval/eval_zeroshot.sh

# reranking the results on zeroshot datasets
sh scripts/eval/eval_rerank_zeroshot.sh

# get the final results
sh scripts/eval/get_rerank_results_zeroshot.sh
```


## 🫡 謝辞

[ lmms-finetune](https://github.com/zjysteven/lmms-finetune) と [E5-V](https://github.com/kongds/E5-V) のコードベースに深く感謝します。


## 引用
このコードを研究やプロジェクトで使用する場合は、次のように引用してください：
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
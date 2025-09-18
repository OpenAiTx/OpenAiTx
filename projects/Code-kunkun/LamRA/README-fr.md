# LamRA : Grand modèle multimodal comme votre assistant avancé de recherche

Ce dépôt est l'implémentation officielle de LamRA.

[🏡 Page du projet](https://code-kunkun.github.io/LamRA/) |  [📄 Article](https://arxiv.org/pdf/2412.01720) | [🤗 LamRA-Ret-Préentraîné](https://huggingface.co/code-kunkun/LamRA-Ret-Pretrained) | [🤗 LamRA-Ret](https://huggingface.co/code-kunkun/LamRA-Ret) | [🤗 LamRA-Rank](https://huggingface.co/code-kunkun/LamRA-Rank) | [🤗 Jeu de données](https://huggingface.co/datasets/code-kunkun/LamRA_Eval)

## Installation

```bash 
conda create -n lamra python=3.10 -y
conda activate lamra 

pip install --upgrade pip  # enable PEP 660 support 
pip install -r requirements.txt

pip install ninja
pip install flash-attn --no-build-isolation
```

## Nouvelle Version
Nous avons mis à jour la version de Qwen2.5-VL dans la branche `qwen2.5vl`.

## Démarrage Rapide
Veuillez vous référer à `demo.py`

## Préparation des Données 

Téléchargez Qwen2-VL-7B et placez-le dans `./checkpoints/hf_models/Qwen2-VL-7B-Instruct`

Pour le jeu de données de pré-entraînement, veuillez consulter [lien](https://huggingface.co/datasets/princeton-nlp/datasets-for-simcse)

Pour le jeu de données d’ajustement d’instruction multimodale, veuillez consulter [M-BEIR](https://huggingface.co/datasets/TIGER-Lab/M-BEIR)

Pour les données d’évaluation liées à LamRA, veuillez consulter [LamRA_Eval](https://huggingface.co/datasets/code-kunkun/LamRA_Eval)

Après avoir téléchargé tous ces éléments, organisez les données comme suit dans `./data`
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

## Entraînement et Évaluation pour LamRA-Ret

### Pré-entraînement

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

###  Ajustement des instructions multimodales

```bash
sh scripts/lamra_ret/finetune.sh
```

```bash 
# Evaluation 
sh scripts/eval/eval_mbeir.sh   # eval under local pool setting

sh scripts/eval/eval_mbeir_global.sh   # eval under global pool setting
```

## Entraînement et évaluation pour LamRA-Rank

Vous pouvez utiliser les [données](https://huggingface.co/datasets/code-kunkun/LamRA_Eval/tree/main/rerank_data_for_training) que nous fournissons ou exécuter la commande suivante pour obtenir les données pour l'entraînement au reranking.

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

## Évaluation sur d'autres bancs d'essai

```bash
# evaluation results on zeroshot datasets
sh scirpts/eval/eval_zeroshot.sh

# reranking the results on zeroshot datasets
sh scripts/eval/eval_rerank_zeroshot.sh

# get the final results
sh scripts/eval/get_rerank_results_zeroshot.sh
```


## 🫡 Remerciements

Un grand merci aux bases de code de [lmms-finetune](https://github.com/zjysteven/lmms-finetune) et [E5-V](https://github.com/kongds/E5-V).


## Citation
Si vous utilisez ce code pour votre recherche ou projet, veuillez citer :
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
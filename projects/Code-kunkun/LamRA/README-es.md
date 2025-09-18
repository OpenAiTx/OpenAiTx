# LamRA: Modelo Multimodal Grande como tu Asistente Avanzado de Recuperación

Este repositorio es la implementación oficial de LamRA.

[🏡 Página del Proyecto](https://code-kunkun.github.io/LamRA/) |  [📄 Artículo](https://arxiv.org/pdf/2412.01720) | [🤗 LamRA-Ret-Pretrained](https://huggingface.co/code-kunkun/LamRA-Ret-Pretrained) | [🤗 LamRA-Ret](https://huggingface.co/code-kunkun/LamRA-Ret) | [🤗 LamRA-Rank](https://huggingface.co/code-kunkun/LamRA-Rank) | [🤗 Conjunto de Datos](https://huggingface.co/datasets/code-kunkun/LamRA_Eval)

## Instalación

```bash 
conda create -n lamra python=3.10 -y
conda activate lamra 

pip install --upgrade pip  # enable PEP 660 support 
pip install -r requirements.txt

pip install ninja
pip install flash-attn --no-build-isolation
```

## Nueva Versión
Hemos actualizado la versión de Qwen2.5-VL en la rama `qwen2.5vl`.

## Inicio Rápido
Por favor, consulte el archivo `demo.py`

## Preparación de Datos 

Descargue Qwen2-VL-7B y colóquelo en `./checkpoints/hf_models/Qwen2-VL-7B-Instruct`

Para el conjunto de datos de preentrenamiento, consulte [enlace](https://huggingface.co/datasets/princeton-nlp/datasets-for-simcse)

Para el conjunto de datos de ajuste por instrucciones multimodales, consulte [M-BEIR](https://huggingface.co/datasets/TIGER-Lab/M-BEIR)

Para los datos de evaluación relacionados con LamRA, consulte [LamRA_Eval](https://huggingface.co/datasets/code-kunkun/LamRA_Eval)

Después de descargar todos ellos, organice los datos como se indica a continuación en `./data`
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

## Entrenamiento y Evaluación para LamRA-Ret

### Preentrenamiento

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

###  Afinación de instrucciones multimodales

```bash
sh scripts/lamra_ret/finetune.sh
```

```bash 
# Evaluation 
sh scripts/eval/eval_mbeir.sh   # eval under local pool setting

sh scripts/eval/eval_mbeir_global.sh   # eval under global pool setting
```

## Entrenamiento y Evaluación para LamRA-Rank

Puede usar los [datos](https://huggingface.co/datasets/code-kunkun/LamRA_Eval/tree/main/rerank_data_for_training) que proporcionamos o ejecutar el siguiente comando para obtener los datos para el entrenamiento de reranking.

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

## Evaluación en otros puntos de referencia

```bash
# evaluation results on zeroshot datasets
sh scirpts/eval/eval_zeroshot.sh

# reranking the results on zeroshot datasets
sh scripts/eval/eval_rerank_zeroshot.sh

# get the final results
sh scripts/eval/get_rerank_results_zeroshot.sh
```


## 🫡 Agradecimientos

Muchas gracias a las bases de código de [lmms-finetune](https://github.com/zjysteven/lmms-finetune) y [E5-V](https://github.com/kongds/E5-V).


## Citación
Si utiliza este código para su investigación o proyecto, por favor cite:
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
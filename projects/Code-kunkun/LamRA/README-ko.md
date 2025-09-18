# LamRA: 고급 검색 도우미로서의 대형 멀티모달 모델

이 저장소는 LamRA의 공식 구현체입니다.

[🏡 프로젝트 페이지](https://code-kunkun.github.io/LamRA/) |  [📄 논문](https://arxiv.org/pdf/2412.01720) | [🤗 LamRA-Ret-Pretrained](https://huggingface.co/code-kunkun/LamRA-Ret-Pretrained) | [🤗 LamRA-Ret](https://huggingface.co/code-kunkun/LamRA-Ret) | [🤗 LamRA-Rank](https://huggingface.co/code-kunkun/LamRA-Rank) | [🤗 데이터셋](https://huggingface.co/datasets/code-kunkun/LamRA_Eval)

## 설치

```bash 
conda create -n lamra python=3.10 -y
conda activate lamra 

pip install --upgrade pip  # enable PEP 660 support 
pip install -r requirements.txt

pip install ninja
pip install flash-attn --no-build-isolation
```
## New Version
`qwen2.5vl` 브랜치에서 Qwen2.5-VL 버전을 업데이트했습니다.

## Quickstart
`demo.py`를 참조하세요.

## Data Preparation 

Qwen2-VL-7B를 다운로드하여 `./checkpoints/hf_models/Qwen2-VL-7B-Instruct`에 배치하세요.

사전 학습 데이터셋은 [링크](https://huggingface.co/datasets/princeton-nlp/datasets-for-simcse)를 참조하세요.

멀티모달 지침 튜닝 데이터셋은 [M-BEIR](https://huggingface.co/datasets/TIGER-Lab/M-BEIR)를 참조하세요.

LamRA 관련 평가 데이터는 [LamRA_Eval](https://huggingface.co/datasets/code-kunkun/LamRA_Eval)를 참조하세요.

모두 다운로드한 후, 데이터를 `./data`에 다음과 같이 정리하세요.

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

## LamRA-Ret의 학습 및 평가

### 사전 학습

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

###  다중 모달 지침 조정

```bash
sh scripts/lamra_ret/finetune.sh
```

```bash 
# Evaluation 
sh scripts/eval/eval_mbeir.sh   # eval under local pool setting

sh scripts/eval/eval_mbeir_global.sh   # eval under global pool setting
```

## LamRA-Rank의 학습 및 평가

제공하는 [데이터](https://huggingface.co/datasets/code-kunkun/LamRA_Eval/tree/main/rerank_data_for_training)를 사용하거나 다음 명령어를 실행하여 재순위 학습용 데이터를 얻을 수 있습니다.

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

## 다른 벤치마크 평가

```bash
# evaluation results on zeroshot datasets
sh scirpts/eval/eval_zeroshot.sh

# reranking the results on zeroshot datasets
sh scripts/eval/eval_rerank_zeroshot.sh

# get the final results
sh scripts/eval/get_rerank_results_zeroshot.sh
```
## 🫡 감사의 글

[ lmms-finetune](https://github.com/zjysteven/lmms-finetune) 및 [E5-V](https://github.com/kongds/E5-V) 코드베이스에 깊은 감사를 드립니다.


## 인용
이 코드를 연구나 프로젝트에 사용하시는 경우, 다음을 인용해 주십시오:


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
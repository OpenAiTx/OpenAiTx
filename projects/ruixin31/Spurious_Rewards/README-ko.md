<div align="center">

![thinking-spongebob](https://raw.githubusercontent.com/ruixin31/Spurious_Rewards/main/figs/thinking-spongebob.png)

# 💭 허위 보상: RLVR에서 학습 신호 재고하기
  
[샤오 루린*](https://rulinshao.github.io/), [리 슈위에 스텔라*](https://stellalisy.com/), [신 루이*](https://ruixin31.github.io/), [겡 스콧*](https://www.scottgeng.com/), [왕 이핑](https://ypwang61.github.io/), [오 세웅](https://homes.cs.washington.edu/~sewoong/), [두 시몬 샤오레이](https://simonshaoleidu.com/), [램버트 네이선](https://www.natolambert.com/), [민 세원](https://www.sewonmin.com/), [크리슈나 란제이](https://www.ranjaykrishna.com/index.html), [츠베트코프 율리아](https://homes.cs.washington.edu/~yuliats/), [하지시르지 하난네](https://homes.cs.washington.edu/~hannaneh/), [코 팡웨이](https://koh.pw/), [제틀레모이어 루크](https://www.cs.washington.edu/people/faculty/luke-zettlemoyer/)
</div>

<div align="center">

[![Github](https://img.shields.io/badge/Github-000000?style=for-the-badge&logo=github&logoColor=000&logoColor=white)](https://github.com/ruixin31/Rethink_RLVR)
[![Website](https://img.shields.io/badge/Site-000000.svg?style=for-the-badge&logo=notion&logoColor=white)](https://rethink-rlvr.notion.site/Spurious-Rewards-Rethinking-Training-Signals-in-RLVR-1f4df34dac1880948858f95aeb88872f) 
[![Paper](https://img.shields.io/badge/Paper-000000.svg?style=for-the-badge&logo=arxiv&logoColor=white)](http://arxiv.org/abs/2506.10947) 
[![Twitter](https://img.shields.io/badge/Twitter-000000?style=for-the-badge&logo=x&logoColor=white)](https://x.com/StellaLisy/status/1927392717593526780)
[![Wandb](https://img.shields.io/badge/📁_reproduction_W&B-000000?style=for-the-badge&logo=wandb&logoColor=white)](https://wandb.ai/rx31/SpuriousRewardRLVR)
[![Models](https://img.shields.io/badge/Models-000000?style=for-the-badge&logo=huggingface&logoColor=white)](https://huggingface.co/collections/stellalisy/spurious-rewards-684a38b8eeb32273c287a4db)

</div>


## 환경 설정

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
## 교육

```sh
bash scripts/rlvr_deepscaler_grpo_qwen_ground_truth.sh
```
## 설정

### 데이터
논문에는 필터링된 데이터와 다수결 라벨 데이터가 포함되어 있습니다. 전체 목록은 `code/data` 디렉토리에서 확인할 수 있습니다. 예를 들어, 정답 데이터는 `DeepScaleR`로 명명되어 있고, Llama 3.2 3B instruct 라벨 데이터 중 오답 라벨만 필터링한 데이터는 `DeepScaleR_mv_labeled_llama3.2_3b_instruct_incorrect` 폴더에 있습니다. 데이터 소스는 `code/scripts/rlvr_deepscaler_grpo_qwen_ground_truth.sh` 파일의 `TASK` 변수를 변경하여 바꿀 수 있습니다.

### 보상
논문에서 사용된 보상 목록을 아래에 포함하였습니다. 또한, 챗 템플릿이 없는 모델의 경우, 반드시 접미사로 `_r1_only`를 추가해야 합니다. 보상 함수는 `code/scripts/rlvr_deepscaler_grpo_qwen_ground_truth.sh` 파일의 `REWARD` 변수를 변경하여 바꿀 수 있습니다.

- `math`: 수학적 동등성 보상(기본값)
- `box_only_format`: 박스 전용 형식 보상
- `contain_python_wo_backticks`: Python 언급 보상
- `random0.5`: 50% 확률로 1을 반환하는 랜덤 보상

## 평가
평가 결과를 재현하려면 다음 명령어를 사용하세요:



```sh
cd code

# For MATH-500 evaluation (requires NVIDIA A100 80GB PCIe for exact reproduction)
python scripts/eval_checkpoint.py --model_path Qwen/Qwen2.5-Math-7B --datasets MATH-500,AIME-2024,AIME-2025,AMC

# For MATH-500 evaluation matching our reported scores in wandb using checkpoints (requires NVIDIA H200 for exact reproduction)
python scripts/eval_checkpoint.py --model_path {} --datasets MATH-500,AIME-2024,AIME-2025,AMC --shards 2
```
참고: `temperature = 0` 결과를 정확하게 재현하려면, GPU 유형과 `--shards` 파라미터가 원래 평가 설정과 일치해야 합니다. 이는 VLLM에 전달되는 배치 크기가 생성 결과에 변동을 일으킬 수 있기 때문입니다.

## 논문

[여기 링크](http://arxiv.org/abs/2506.10947)에서 논문을 확인하실 수 있습니다.

## 인용


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
## 감사의 말씀
이 저장소는 [TTRL](https://github.com/PRIME-RL/TTRL)을 기반으로 구축되었으며, TTRL은 [OpenRLHF](https://github.com/OpenRLHF/OpenRLHF)를 기반으로 합니다.
우리는 코드베이스에 비동기 평가와 기타 맞춤형 기능을 추가하였습니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-14

---
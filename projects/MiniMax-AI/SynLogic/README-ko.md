<div align="center">
  <picture>
    <source srcset="assets/minimax-logo.png" media="(prefers-color-scheme: dark)">
      <img src="https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/assets/minimax-logo.png" width="60%" alt="MiniMax">
    </source>
  </picture>
</div>
<hr>

<div align="center" style="line-height: 1;">
<a href="https://arxiv.org/abs/2505.19641" target="_blank" style="margin: 2px;">
  <img alt="Paper" src="https://img.shields.io/badge/📖_Paper-Arxiv-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
<a href="https://huggingface.co/datasets/MiniMaxAI/SynLogic" target="_blank" style="margin: 2px;">
  <img alt="Hugging Face" src="https://img.shields.io/badge/🤗_HF-Data-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
<a href="https://huggingface.co/collections/MiniMaxAI/synlogic-6836c3246fca0277657ff032" target="_blank" style="margin: 2px;">
  <img alt="Hugging Face" src="https://img.shields.io/badge/🤗_HF-Model-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
</div>

<hr>

# SynLogic

이 저장소는 SynLogic의 코드와 데이터를 포함하고 있습니다. SynLogic은 다양한 논리적 추론 데이터를 대규모로 생성할 수 있는 종합적인 논리 추론 데이터 합성 프레임워크입니다. 본 연구는 범용 추론 역량을 개발하기 위한 대규모 언어 모델(LLM) 학습용 고품질 논리 추론 데이터의 핵심적인 부족 문제를 해결합니다.

<p align="center">
  <img src="https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/assets/main.jpg" alt="Laser main figure">
</p> 

## 뉴스
- **[2025/07/07]** :fire: SynLogic 데이터를 활용하여 Verl 프레임워크로 RL 학습을 진행하는 가이드를 제공합니다. 자세한 내용은 [docs/training_guidance.md](https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/docs/training_guidance.md) 문서를 참고하세요. 

- **[2025/06/03]** :fire: Hugging Face에서 학습된 모델 공개:  
→ [MiniMaxAI/SynLogic Collection](https://huggingface.co/collections/MiniMaxAI/synlogic-6836c3246fca0277657ff032)  

- **[2025/05]** :fire: 논문 "SynLogic: Synthesizing Verifiable Reasoning Data at Scale for Learning Logical Reasoning and Beyond"의 리소스를 공개하게 되어 기쁩니다.

## 📋 개요

**SynLogic**은 다음과 같은 데이터 합성 프레임워크 및 종합 데이터셋입니다:
- 📊 **35종의 다양한 논리 추론 태스크 제공**: 스도쿠, 24게임, 암호 해독, 화살 미로 등 포함
- 🎯 **난이도 조절 가능한 데이터 합성**: 각 태스크별로 조정 가능한 파라미터 제공
- ✅ **검증 가능한 보상 제공**: 규칙 기반 검증을 통해 RL 학습에 적합
- 🚀 **최첨단 성능 달성**: 오픈소스 데이터셋 중 최고 성능, BBEH에서 DeepSeek-R1-Distill-Qwen-32B 대비 6점 우수

### 주요 특징
- **확장 가능한 데이터 생성**: 난이도 조절 가능한 무제한 합성 지원
- **포괄적인 태스크 커버리지**: 35가지 논리 추론 태스크, 맞춤형 생성기 및 검증기 제공
- **RL 학습에 최적화**: 모든 예제가 간단한 규칙으로 검증 가능하여 강화학습에 이상적
- **도메인 간 전이**: 수학 및 코딩 분야로의 뛰어난 일반화 성능

## 🚀 빠른 시작

### 설치
```bash
git clone https://github.com/MiniMax-AI/SynLogic.git
cd SynLogic
pip install -r requirements.txt
```

### 샘플 데이터 생성 (Arrow Maze 예시)
```bash
# Arrow Maze 빠른 예시
bash games/tasks/arrow_maze/run.sh

# 혹은 사용자 정의 파라미터 사용
python scripts/arrow_maze.py \
  --num_of_data 1000 \
  --width 5 \
  --height 5 \
  --arrow_fill_rate_min 0.3 \
  --arrow_fill_rate_max 0.9
```

### RL 학습용

강화학습(RL) 학습에 SynLogic 데이터를 사용하는 포괄적인 가이드를 제공합니다. SynLogic을 Verl 프레임워크와 통합하는 자세한 방법은 [docs/training_guidance.md](https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/docs/training_guidance.md) 문서를 참고하세요.

## :rocket: 리소스

### 데이터셋
| 데이터셋 이름 | 설명 | 링크 |
|:------------:|:------------|:----:|
| **SynLogic** | 데이터셋 | [🤗 HuggingFace](https://huggingface.co/datasets/MiniMaxAI/SynLogic) |



### 모델


| 모델 이름 | 설명 | 링크 |
|:-----------|:------------|:----:|
| **SynLogic-7B** | SynLogic 데이터로 학습된 7B 모델 | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-7B) |
| **SynLogic-32B** | SynLogic 데이터로 학습된 32B 모델 | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-32B) |
| **SynLogic-Mix-3-32B** | SynLogic, 수학, 코딩 데이터를 혼합하여 학습한 32B 모델 | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-Mix-3-32B) |

## 🔄 향후 업데이트

우리는 SynLogic을 더 많은 논리적 추론 작업으로 확장하기 위해 적극적으로 노력하고 있습니다.

최신 업데이트와 릴리스를 보려면 우리의 저장소를 팔로우하세요!

## 인용
저희 연구가 도움이 되었다면 논문을 인용해 주세요:

```bibtex
@misc{liu2025synlogic,
      title={SynLogic: Synthesizing Verifiable Reasoning Data at Scale for Learning Logical Reasoning and Beyond}, 
      author={Junteng Liu and Yuanxiang Fan and Zhuo Jiang and Han Ding and Yongyi Hu and Chi Zhang and Yiqi Shi and Shitong Weng and Aili Chen and Shiqi Chen and Yunan Huang and Mozhi Zhang and Pengyu Zhao and Junjie Yan and Junxian He},
      year={2025},
      eprint={2505.19641},
      archivePrefix={arXiv},
      primaryClass={cs.AI},
      url={https://arxiv.org/abs/2505.19641}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---
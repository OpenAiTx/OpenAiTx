![ChartGalaxy Logo](https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/main/title.png)

## 데이터셋
> 📦 **[👉 Hugging Face에서 ChartGalaxy 전체 데이터셋에 접속하세요! 👈](https://huggingface.co/datasets/ChartGalaxy/ChartGalaxy)**

저장 공간의 한계로, 대표적인 예시만을 포함하였습니다.  
이 저장소는 논문 "ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation"의 관련 코드를 포함하고 있습니다.

## 🔥 소식
**2025.5**:  🎉🎉 데이터셋의 첫 번째 버전을 출시했습니다. 1,151,087개의 합성 및 104,519개의 실제 인포그래픽 차트를 포함하며, 75개의 차트 유형과 330개의 변형을 다룹니다.

-------------------

<img src="https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/main/teaser.png" style="border:none;box-shadow:none;">

![Examples image](https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/main/examples.png)

<!-- ## 🔔 News -->

## 소개

### 개요

ChartGalaxy는 데이터 테이블과 함께 제공되는 합성 및 실제 인포그래픽 차트로 이루어진 백만 규모의 데이터셋으로, 인포그래픽 차트 이해, 코드 생성, 차트 생성 등의 응용을 지원합니다. 기존 데이터셋이 대부분 단순한 차트에 한정되어 있어 인포그래픽 차트의 핵심 특징인 다양한 디자인 스타일과 레이아웃을 포착하지 못하는 문제를 해결합니다.

### 통계

- **규모**: 1,255,606개의 인포그래픽 차트 (1,151,087 합성 + 104,519 실제)
- **내용**: 각 인포그래픽 차트는 생성에 사용된 표 형식 데이터와 쌍을 이룹니다
- **차트 유형**: 75개 차트 유형, 330개 차트 변형
- **레이아웃 템플릿**: 68개 레이아웃 템플릿

### 데이터 수집 및 생성

ChartGalaxy는 다음과 같은 과정을 통해 구축되었습니다:

1. **실제 인포그래픽 차트 수집**: Pinterest, Visual Capitalist, Statista, Information is Beautiful 등 19개의 신뢰할 수 있는 차트 중심 웹사이트에서 차트를 수집하였습니다.

2. **합성 인포그래픽 차트 생성**: 귀납적 구조화 과정을 통해  
   - 75개 차트 유형(예: 막대 차트) 및 330개 시각적 요소 스타일의 차트 변형 식별
   - 요소 간 공간적 관계를 정의하는 68개 레이아웃 템플릿 추출
   - 이러한 패턴을 바탕으로 프로그램적으로 합성 차트 생성

## 🎯 응용

ChartGalaxy의 유용성은 세 가지 대표적인 응용을 통해 입증됩니다:

### 1. 🧠 인포그래픽 차트 이해

ChartGalaxy로 파인튜닝하면 인포그래픽 차트 이해에서 기반 모델의 성능이 향상됩니다.

### 2. 💻 인포그래픽 차트 코드 생성

LVLMs의 인포그래픽 차트 코드 생성 평가를 위한 벤치마크입니다. 벤치마크는 생성된 D3.js 코드로 렌더링된 차트와 정답 차트 간의 유사성을 두 가지 수준(고수준: 전체적 시각적 유사성, 저수준: 세밀한 SVG 요소별 평균 유사성)에서 평가합니다.

#### 개요

이 벤치마크는 차트 코드 생성을 두 가지 수준에서 평가합니다:
- **저수준**: 생성된 SVG와 참조 SVG 간의 요소별 유사성
- **고수준**: 전체적인 시각적 충실도 및 기능 평가

#### 설치

```bash
git clone https://github.com/ChartGalaxy/ChartGalaxy.git
cd ChartGalaxy/code_generation_benchmark
```

#### 사용법

1. `code_generation_benchmark/configs/default_config.yaml`에서 설정을 구성합니다:
   ```yaml
   prompts:
     high_level_eval_prompt_file: eval_high_level.txt
     chat_prompt_file: chat_direct_prompt.txt

   VLM:
     max_tokens: null
     thinking_budget: 1024
     temperature: 0.0
     top_p: 1.0

   models:
     # 평가할 모델의 주석을 해제하세요
     # - gpt-4o-2024-11-20
     # - claude-3-7-sonnet-20250219
     # - gemini-2.5-pro-preview-05-06
     # - Qwen/Qwen2.5-VL-72B-Instruct

   dirs:
     output_dir: ./output
     log_dir: ./logs
     data_root_dir: ./data
     clip_cache_dir: ./model-ckpts

   eval_model: gpt-4o-2024-11-20
   n_workers: 10
   ```

2. 벤치마크 실행:
   ```bash
   python main.py
   ```

#### 데이터 구조

`data_root_dir` 내의 각 차트 폴더는 다음을 포함해야 합니다:
- `chart.svg`: 원본 차트(SVG 형식)

시스템이 생성하는 결과:
- `convert_chart.html`: 참조 차트의 HTML 렌더링
- `convert_chart.png`: 참조 차트의 PNG 스크린샷
- `convert_chart.json`: 참조 차트의 요소 구조
- 모델별 산출물(하위 폴더)

#### 결과

결과는 모델별 하위 폴더에 저장되며:
- 생성된 HTML/PNG 렌더링
- JSON 형식의 평가 지표
- `log_dir` 내 상세 로그
  

### 3. 🖼️ 예시 기반 인포그래픽 차트 생성

사용자가 제공한 표 형식 데이터를 예시 차트의 레이아웃 및 시각적 스타일에 맞추어 인포그래픽 차트로 변환하는 예시 기반 방법입니다. 사용자 연구 결과, 이 방법은 GPT-Image-1 대비 충실도, 심미성, 창의성에서 더 우수함을 보였습니다.


## 문의
- chartgalaxy@163.com

## 논문 링크

### 📌 주요 논문 (이 저장소)

- **[ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation](https://arxiv.org/abs/2505.18668)**  
  _Zhen Li, Duan Li, Yukai Guo, Xinyuan Guo, Bowen Li, Lanxi Xiao, Shenyu Qiao, Jiashu Chen, Zijian Wu, Hui Zhang, Xinhuan Shu, Shixia Liu_  

### 관련 논문

- **[OrionBench: A Benchmark for Chart and Human-Recognizable Object Detection in Infographics](https://arxiv.org/abs/2505.17473)**  
  _Jiangning Zhu, Yuxing Zhou, Zheng Wang, Juntao Yao, Yima Gu, Yuhui Yuan, Shixia Liu_  

- **[InfoChartQA: A Benchmark for Multimodal Question Answering on Infographic Charts](https://arxiv.org/abs/2505.19028)**  
  _Minzhi Lin, Tianchi Xie, Mengchen Liu, Yilin Ye, Changjian Chen, Shixia Liu_  

## 📚 인용
ChartGalaxy를 연구에 사용하실 경우 아래와 같이 인용해 주세요:
```
@misc{li2025chartgalaxydatasetinfographicchart,
      title={ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation}, 
      author={Zhen Li and Yukai Guo and Duan Li and Xinyuan Guo and Bowen Li and Lanxi Xiao and Shenyu Qiao and Jiashu Chen and Zijian Wu and Hui Zhang and Xinhuan Shu and Shixia Liu},
      year={2025},
      eprint={2505.18668},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2505.18668}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---
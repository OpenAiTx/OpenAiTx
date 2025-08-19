<div align="center">
    
<h1><a href="https://ieeexplore.ieee.org/document/10591792">Change-Agent: 대화형 종합 원격 탐사 변화 해석 및 분석을 향하여</a></h1>

**[Chenyang Liu](https://chen-yang-liu.github.io/), [Keyan Chen](https://kyanchen.github.io), [Haotian Zhang](https://scholar.google.com/citations?user=c7uR6NUAAAAJ), [Zipeng Qi](https://scholar.google.com/citations?user=KhMtmBsAAAAJ), [Zhengxia Zou](https://scholar.google.com.hk/citations?hl=en&user=DzwoyZsAAAAJ), 그리고 [Zhenwei Shi*✉](https://scholar.google.com.hk/citations?hl=en&user=kNhFWQIAAAAJ)**

<div align="center">
  <img src="https://raw.githubusercontent.com/Chen-Yang-Liu/Change-Agent/main/resource/Change_Agent.png" width="400"/>
</div>
</div>

## 이 저장소에 관심이 있으시면 :star:를 눌러주세요

논문 "**Change-Agent: 대화형 종합 원격 탐사 변화 해석 및 분석을 향하여**"의 공식 PyTorch 구현체입니다: [[IEEE](https://ieeexplore.ieee.org/document/10591792)]  ***(IEEE TGRS 2024 채택)***

## 🥳뉴스

- 2024-06: 코드가 **이용 가능합니다**.
- 2024-03: 논문이 **이용 가능합니다**.
- 🔥 저희 설문조사 "**원격 탐사 시계열 비전-언어 모델: 종합 설문조사": [Arxiv](https://arxiv.org/abs/2412.02573) || [Github](https://github.com/Chen-Yang-Liu/Awesome-RS-Temporal-VLM)** 🔥 

## 목차
- [LEVIR-MCI 데이터셋](#LEVIR-MCI-dataset)
- [MCI 모델의 학습](#Training-of-the-multi-level-change-interpretation-model)
- [Change-Agent 구성](#Construction-of-Change-Agent)
- [인용](#Citation)

## LEVIR-MCI 데이터셋 
- LEVIR_MCI 데이터셋 다운로드: [LEVIR-MCI](https://huggingface.co/datasets/lcybuaa/LEVIR-MCI/tree/main) (**지금 이용 가능!**).
- 이 데이터셋은 저희가 이전에 구축한 [LEVIR-CC 데이터셋](https://github.com/Chen-Yang-Liu/RSICC)의 확장판입니다. 양시점 이미지와 다양한 변화 탐지 마스크 및 설명 문장을 포함하고 있습니다. 변화 탐지 및 변화 캡셔닝의 다중 작업 학습 탐구를 위한 중요한 데이터 기반을 제공합니다.
    <br>
    <div align="center">
      <img src="https://raw.githubusercontent.com/Chen-Yang-Liu/Change-Agent/main/resource/dataset.png" width="800"/>
    </div>
    <br>
## 다중 수준 변화 해석 모델의 학습
MCI 모델 개요:
<br>
    <div align="center">
      <img src="https://raw.githubusercontent.com/Chen-Yang-Liu/Change-Agent/main/resource/MCI_model.png" width="800"/>
    </div>
<br>

### 준비
    
- **환경 설치**:
    <details open>
    
    **1단계**: `Multi_change_env`라는 가상 환경을 생성하고 활성화합니다.
    ```python
    conda create -n Multi_change_env python=3.9
    conda activate Multi_change_env
    ```
    
    **2단계**: 저장소를 다운로드하거나 클론합니다.
    ```python
    git clone https://github.com/Chen-Yang-Liu/Change-Agent.git
    cd ./Change-Agent/Multi_change
    ```
    
    **3단계**: 종속 항목을 설치합니다.
    ```python
    pip install -r requirements.txt
    ```
    </details>

- **데이터셋 다운로드**:
  <details open>
      
  링크: [LEVIR-MCI](https://huggingface.co/datasets/lcybuaa/LEVIR-MCI/tree/main). LEVIR-MCI의 데이터 구조는 다음과 같이 구성되어 있습니다:

    ```
    ├─/DATA_PATH_ROOT/Levir-MCI-dataset/
            ├─LevirCCcaptions.json
            ├─images
                 ├─train
                 │  ├─A
                 │  ├─B
                 │  ├─label
                 ├─val
                 │  ├─A
                 │  ├─B
                 │  ├─label
                 ├─test
                 │  ├─A
                 │  ├─B
                 │  ├─label
    ```
    폴더 ``A``는 사전 단계 이미지를 포함하고, 폴더 ``B``는 사후 단계 이미지를 포함하며, 폴더 ``label``은 변화 탐지 마스크를 포함합니다.
    </details>

- **LEVIR-MCI에서 각 이미지 쌍에 대한 설명 텍스트 파일 추출**:

    ```
    python preprocess_data.py
    ```
    그 후, `./data/LEVIR_MCI/`에서 일부 생성된 파일을 찾을 수 있습니다. 

### 학습
위의 데이터 준비를 완료했는지 확인하세요. 그런 다음, 다음과 같이 학습을 시작합니다:
```python
python train.py --train_goal 2 --data_folder /DATA_PATH_ROOT/Levir-MCI-dataset/images --savepath ./models_ckpt/
```

### 평가
```python
python test.py --data_folder /DATA_PATH_ROOT/Levir-MCI-dataset/images --checkpoint {checkpoint_PATH}
```
모델을 평균 점수를 얻기 위해 5번 훈련할 것을 권장합니다.

### 추론
다음과 같이 추론을 실행하여 시작합니다:
```python
python predict.py --imgA_path {imgA_path} --imgB_path {imgA_path} --mask_save_path ./CDmask.png
```
``--checkpoint``를 ``predict.py``의 ``Change_Perception.define_args()``에서 수정할 수 있습니다.  
그 후 자신만의 모델을 사용할 수 있으며, 물론 사전학습된 모델 ``MCI_model.pth``를 여기서 다운로드할 수도 있습니다: [[Hugging face](https://huggingface.co/lcybuaa/Change-Agent/tree/main)].  
그 다음, 이를 `./models_ckpt/` 폴더에 넣으세요.  

## Change-Agent 구성  
<br>  
<div align="center">  
      <img src="https://raw.githubusercontent.com/Chen-Yang-Liu/Change-Agent/main/resource/overview_agent.png" width="800"/>  
</div>  

- **에이전트 설치**:
    ```python
    cd ./Change-Agent/lagent-main
    pip install -e .[all]
    ```
- **에이전트 실행**:

    ``Multi_change`` 폴더로 이동:
    ```python
    cd ./Change-Agent/Multi_change
    ```
    (1) 에이전트 CLI 데모 실행:
    ```bash
    # You need to install streamlit first
    # pip install streamlit
    python try_chat.py
    ```
        
    (2) 에이전트 웹 데모 실행:
    ```bash
    # You need to install streamlit first
    # pip install streamlit
    streamlit run react_web_demo.py
    ```
    <br>
    <div align="center">
          <img src="https://raw.githubusercontent.com/Chen-Yang-Liu/Change-Agent/main/resource/web.png"/>
    </div>

## 인용
이 논문이 연구에 도움이 되었다면, 다음을 인용해 주시기 바랍니다:
```
@ARTICLE{Liu_Change_Agent,
  author={Liu, Chenyang and Chen, Keyan and Zhang, Haotian and Qi, Zipeng and Zou, Zhengxia and Shi, Zhenwei},
  journal={IEEE Transactions on Geoscience and Remote Sensing}, 
  title={Change-Agent: Toward Interactive Comprehensive Remote Sensing Change Interpretation and Analysis}, 
  year={2024},
  volume={},
  number={},
  pages={1-1},
  keywords={Remote sensing;Feature extraction;Semantics;Transformers;Roads;Earth;Task analysis;Interactive Change-Agent;change captioning;change detection;multi-task learning;large language model},
  doi={10.1109/TGRS.2024.3425815}}

```
## 감사의 말
다음 저장소에 감사드립니다:

[RSICCformer](https://github.com/Chen-Yang-Liu/RSICC); [Chg2Cap](https://github.com/ShizhenChang/Chg2Cap); [lagent](https://github.com/InternLM/lagent)

## 라이선스
이 저장소는 [MIT 라이선스](https://github.com/Chen-Yang-Liu/Change-Agent/blob/main/LICENSE.txt) 하에 배포됩니다. 코드는 학술 목적으로만 사용 가능합니다.

## 문의하기
다른 질문이 있으시면❓, 제때 저희에게 연락해 주세요 👬



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---
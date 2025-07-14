<div align="center">
<div style="text-align: center;">
    <img src="https://raw.githubusercontent.com/zjx0101/ObjectClear/main/./assets/ObjectClear_logo.png" alt="ObjectClear Logo" style="height: 52px;">
    <h2>객체-효과 어텐션을 통한 완전한 객체 제거</h2>
</div>

<div>
    <a href="https://zjx0101.github.io/" target='_blank'>자신 자오</a>&emsp;
    <a href='https://shangchenzhou.com/' target='_blank'>샹첸 저우<sup>†</sup></a>&emsp;
    <a href='https://wzhouxiff.github.io' target='_blank'>저우샤 왕</a>&emsp;
    <a href='https://pq-yang.github.io/' target='_blank'>페이칭 양</a>&emsp;
    <a href='https://www.mmlab-ntu.com/person/ccloy/' target='_blank'>첸 챙 로이</a>
</div>
<div>
    S-Lab, 난양공과대학교<br>
   <p><sup>†</sup>교신 저자</p>
</div>


<div>
    <h4 align="center">
        <a href="https://zjx0101.github.io/projects/ObjectClear/" target='_blank'>
        <img src="https://img.shields.io/badge/🐳-Project%20Page-blue">
        </a>
        <a href="https://arxiv.org/abs/2505.22636" target='_blank'>
        <img src="https://img.shields.io/badge/arXiv-2505.22636-b31b1b.svg">
        </a>
        <a href="https://huggingface.co/spaces/jixin0101/ObjectClear" target='_blank'>
        <img src="https://img.shields.io/badge/Demo-%F0%9F%A4%97%20Hugging%20Face-blue">
        </a>
        <img src="https://api.infinitescript.com/badgen/count?name=sczhou/ObjectClear&ltext=Visitors&color=3977dd">
    </h4>
</div>

<strong>ObjectClear는 객체-효과 어텐션을 활용하여 대상 객체와 관련된 효과를 함께 제거하면서 배경 일관성을 유지하는 객체 제거 모델입니다.</strong>

<div style="width: 100%; text-align: center; margin:auto;">
    <img style="width:100%" src="https://raw.githubusercontent.com/zjx0101/ObjectClear/main/assets/teaser.jpg">
</div>

더 많은 시각적 결과는 <a href="https://zjx0101.github.io/projects/ObjectClear/" target="_blank">프로젝트 페이지</a>에서 확인하세요.

---
</div>


## ⭐ 업데이트
- [2025.07] 추론 코드 및 Gradio 데모 공개.
- [2025.05] 이 저장소 생성.


## 🎃 개요
![overall_structure](https://raw.githubusercontent.com/zjx0101/ObjectClear/main/assets/ObjectClear_pipeline.png)


## 📷 OBER 데이터셋
![OBER_dataset_pipeline](https://raw.githubusercontent.com/zjx0101/ObjectClear/main/assets/OBER_pipeline.png)

OBER(객체-효과 제거)는 카메라 촬영 데이터와 시뮬레이션 데이터를 결합하여 효과가 있는 객체 제거 연구를 지원하기 위해 설계된 하이브리드 데이터셋입니다.

![OBER_dataset_samples](https://raw.githubusercontent.com/zjx0101/ObjectClear/main/assets/dataset_samples.png)


## ⚙️ 설치
1. 저장소 클론하기
    ```bash
    git clone https://github.com/zjx0101/ObjectClear.git
    cd ObjectClear
    ```
2. Conda 환경 생성 및 종속성 설치

    ```bash
    # create new conda env
    conda create -n objectclear python=3.10 -y
    conda activate objectclear

    # install python dependencies
    pip3 install -r requirements.txt
    # [optional] install python dependencies for gradio demo
    pip3 install -r hugging_face/requirements.txt
    ```
## ⚡ 추론

### 빠른 테스트
[`inputs`](./inputs) 폴더에 몇 가지 예제를 제공합니다. **각 실행마다 이미지와 그에 대응하는 세그멘테이션 마스크를 입력으로 받습니다.** <u>세그멘테이션 마스크는 [SAM2 데모](https://huggingface.co/spaces/fffiloni/SAM2-Image-Predictor)와 같은 인터랙티브 세그멘테이션 모델에서 얻을 수 있습니다.</u> 예를 들어, 디렉토리 구조는 다음과 같이 정리할 수 있습니다:


```
inputs
   ├─ imgs
   │   ├─ test-sample1.jpg      # .jpg, .png, .jpeg supported
   │   ├─ test-sample2.jpg
   └─ masks
       ├─ test-sample1.png
       ├─ test-sample2.png
```
다음 명령어를 실행하여 시도해 보십시오:

```shell
## Single image inference
python inference_objectclear.py -i inputs/imgs/test-sample1.jpg -m inputs/masks/test-sample1.png --use_fp16

## Batch inference on image folder
python inference_objectclear.py -i inputs/imgs -m inputs/masks --use_fp16
```
## 🪄 인터랙티브 데모
분할 마스크 준비 과정을 없애기 위해, [허깅 페이스](https://huggingface.co/spaces/jixin0101/ObjectClear)에 gradio 데모를 준비했으며, [로컬에서 실행할 수도 있습니다](./hugging_face). 이미지 파일을 드롭하고 몇 번의 클릭으로 대상 마스크를 지정한 후, 객체 제거 결과를 확인하세요!


```shell
cd hugging_face

# install python dependencies
pip3 install -r requirements.txt

# launch the demo
python app.py
```
## 📑 인용
우리 저장소가 연구에 유용하다면, 논문을 인용해 주시기 바랍니다:



```bibtex
@InProceedings{zhao2025ObjectClear,
    title     = {{ObjectClear}: Complete Object Removal via Object-Effect Attention},
    author    = {Zhao, Jixin and Zhou, Shangchen and Wang, Zhouxia and Yang, Peiqing and Loy, Chen Change},
    booktitle = {arXiv preprint arXiv:2505.22636},
    year      = {2025}
    }
```
## 📧 연락처
질문이 있으시면 언제든지 `jixinzhao0101@gmail.com`으로 연락해 주세요.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-14

---
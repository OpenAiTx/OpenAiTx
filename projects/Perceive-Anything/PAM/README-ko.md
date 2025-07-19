<div align="center">
<h1>
무엇이든 인지하기: 이미지 및 비디오 내 무엇이든 인식, 설명, 캡션 작성, 분할하기 (PAM)
</h1>

</div>

<div align="center">

[Weifeng Lin](), [Xinyu Wei](), [Ruichuan An](), [Tianhe Ren](), [Tingwei Chen](), [Renrui Zhang](), [Ziyu Guo]() <br>
[Wentao Zhang](), [Lei Zhang](), [Hongsheng Li]() <br>
CUHK, HKU, PolyU, PekingU

</div>

<p align="center">
  <a href="https://Perceive-Anything.github.io"><b>🌐 프로젝트 웹사이트</b></a> |
  <a href="https://arxiv.org/abs/2506.05302"><b>📕 논문</b></a> |
  <a href="https://huggingface.co/Perceive-Anything/PAM-3B"><b>📥 모델 다운로드</b></a> |
  <a href="https://huggingface.co/datasets/Perceive-Anything/PAM-data"><b>🤗 데이터셋</b></a> |
  <a href="#quick-start"><b>⚡빠른 시작</b></a> <br>
  <a href="#license"><b>📜 라이선스</b></a> |
  <a href="#citation"><b>📖 인용 (BibTeX)</b></a> <br>
</p>

<p align="center">
    <img src="https://raw.githubusercontent.com/Perceive-Anything/PAM/main/assets/teaser_img.jpg" width="95%"> <br>
    <img src="https://raw.githubusercontent.com/Perceive-Anything/PAM/main/assets/teaser_video.jpg" width="95%"> <br>
</p>

## 뉴스

<!-- **2025.06.20**: Release Gradio demo ([online demo]() and [local](#gradio-demo)) -->

<!-- **2025.06.05**: Evaluation code Please refer to [this link](). -->

**2025.06.08**: 모델 가중치(1.5B / 3B) 및 학습 데이터셋이 공개되었습니다. 자세한 내용은 [PAM-1.5B](https://huggingface.co/Perceive-Anything/PAM-1.5B), [PAM-3B](https://huggingface.co/Perceive-Anything/PAM-3B) 및 [데이터셋](https://huggingface.co/datasets/Perceive-Anything/PAM-data)를 참조하세요.

**2025.06.08**: 객체 분할 및 이해를 위한 간단한 종단간(region-level) VLM인 PAM이 공개되었습니다. 논문은 [여기](https://arxiv.org/abs/2506.05302)를 참조하세요.


## 소개

**무엇이든 인지하기 모델(PAM)**은 이미지 및 비디오에서 포괄적인 영역 수준 시각 이해를 위한 개념적으로 간단하고 효율적인 프레임워크입니다. 본 접근법은 대형 언어 모델(LLM)을 통합하여 SAM 2를 확장하며, 객체 분할과 동시에 범주, 라벨 정의, 기능적 설명 및 상세 캡션 등 다양한 영역별 의미론적 출력을 생성할 수 있습니다. 우리는 일반적인 시각 정보, 위치 및 의미론적 사전 지식을 내포한 SAM 2의 풍부한 시각적 특징을 LLM 이해를 위한 다중 모달 토큰으로 효율적으로 변환하는 방식을 제안합니다. 견고한 다중 세분화 이해를 지원하기 위해, 우리는 고품질의 이미지 및 비디오 영역-의미 주석 데이터셋 [**dataset**](https://huggingface.co/datasets/Perceive-Anything/PAM-data)과 새로운 영역 수준 스트리밍 비디오 캡션 데이터를 생성하는 전용 데이터 정제 및 증강 파이프라인을 개발했습니다.


<p align="center">
    <img src="https://raw.githubusercontent.com/Perceive-Anything/PAM/main/assets/PAM_comp.jpg" width="95%"> <br>
    <img src="https://raw.githubusercontent.com/Perceive-Anything/PAM/main/assets/PAM_arch.jpg" width="95%"> <br>
</p>

## 설치

1. 이 저장소를 클론하고 기본 폴더로 이동합니다</translate-content>

```bash
git clone https://github.com/Afeng-x/PAM.git
cd PAM
```
<translate-content>
2. 패키지 설치</translate-content>
```bash
### packages for base
conda create -n PAM python=3.10 -y
conda activate PAM
pip install --upgrade pip
pip install -e ".[train]"
### packages for sam2
cd sam2
pip install -e ".[notebooks]"
```
3. 플래시 어텐션 설치하기

```bash
pip install flash-attn --no-build-isolation
### (If the method mentioned above don’t work for you, try the following one)
git clone https://github.com/Dao-AILab/flash-attention.git
cd flash-attention
python setup.py install
```
4. SAM2.1-h-large 체크포인트를 다운로드하세요:

```bash
cd llava/model/multimodal_encoder
bash download_ckpts.sh
```
## 빠른 시작

- 이미지: [image_infer_example.ipynb](https://raw.githubusercontent.com/Perceive-Anything/PAM/main/./notebooks/image_infer_example.ipynb)의 예제를 참조하세요  
- 비디오: [video_infer_example.ipynb](https://raw.githubusercontent.com/Perceive-Anything/PAM/main/./notebooks/video_infer_example.ipynb) 의 예제를 참조하세요  
- 비디오 스트림: [video_stream_infer_example.ipynb](https://raw.githubusercontent.com/Perceive-Anything/PAM/main/./notebooks/video_stream_infer_example.ipynb) 의 예제를 참조하세요  

## 데이터셋

정제되고 증강된 데이터 주석을 다운로드하려면 [이 링크](https://huggingface.co/datasets/Perceive-Anything/PAM-data)를 참조하세요.  

**참고:** 원본 이미지는 직접 제공하지 않습니다. 그러나 각 데이터셋에 대해 관련 다운로드 링크 또는 공식 웹사이트 주소를 제공하여 사용자가 다운로드 방법을 안내받을 수 있도록 합니다. [DATA_README](https://raw.githubusercontent.com/Perceive-Anything/PAM/main/data/README.md)  

<!-- ## Training PAM

You can train or fine-tune PAM on custom datasets of images, videos, or both. Please check the training [README](https://raw.githubusercontent.com/Perceive-Anything/PAM/main/training/README.md) on how to get started. -->

## PAM을 위한 로컬 그라디오 데모
진행 중 ......  
<!-- ### Simple Gradio Demo for Image

[`pam_image.py`](https://raw.githubusercontent.com/Perceive-Anything/PAM/main/pam_image.py) - 이미지에서 마스크를 그리고 의미를 얻기 위한 대화형 Gradio 웹 인터페이스입니다. **이 데모는 `gradio` 5.5.0에서 테스트되었습니다.**

### Simple Gradio Demo for Video

[`pam_video.py`](https://raw.githubusercontent.com/Perceive-Anything/PAM/main/pam_video.py) - 비디오에서 마스크를 그리고 의미를 얻기 위한 대화형 Gradio 웹 인터페이스입니다. **이 데모는 `gradio` 5.5.0에서 테스트되었습니다.** -->

## 라이선스

이 코드 저장소는 [Apache 2.0](./LICENSE) 라이선스 하에 있습니다.  

## 감사의 글
본 작업에 기여한 다음 프로젝트들에 감사드립니다:

- [LLaVA-Next](https://github.com/LLaVA-VL/LLaVA-NeXT)  
- [SAM](https://github.com/facebookresearch/segment-anything)  
- [SAM 2](https://github.com/facebookresearch/sam2)  

## 인용

PAM이 연구나 응용에 유용하거나, 데이터셋을 연구에 사용하셨다면, 다음 BibTeX 항목을 사용해 주시기 바랍니다.


```bibtex
@misc{lin2025perceiveanythingrecognizeexplain,
      title={Perceive Anything: Recognize, Explain, Caption, and Segment Anything in Images and Videos}, 
      author={Weifeng Lin and Xinyu Wei and Ruichuan An and Tianhe Ren and Tingwei Chen and Renrui Zhang and Ziyu Guo and Wentao Zhang and Lei Zhang and Hongsheng Li},
      year={2025},
      eprint={2506.05302},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2506.05302}, 
}
```



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---
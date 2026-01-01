# Quantized Visual Geometry Grounded Transformer

[arXiv](https://arxiv.org/abs/2509.21302) | [BibTeX](#bibtex)

------

This project is the official implementation of our QuantVGGT: "Quantized Visual Geometry Grounded Transformer".

![teaser](https://raw.githubusercontent.com/wlfeng0509/QuantVGGT/main/imgs/teaser.png)

![overview](https://raw.githubusercontent.com/wlfeng0509/QuantVGGT/main/imgs/overview.png)

------

## Results

![result](https://raw.githubusercontent.com/wlfeng0509/QuantVGGT/main/imgs/result.png)

## Updates

- [October 10, 2025] Evaluation code for reproducing our camera pose estimation results on Co3D is now available.

## Quick Start

First, clone this repository to your local machine, and install the dependencies (torch, torchvision, numpy, Pillow, and huggingface_hub).

```
git clone git@github.com:wlfeng0509/QuantVGGT.git
cd QuantVGGT
pip install -r requirements.txt
```
그런 다음 [VGGT](https://github.com/facebookresearch/vggt)에서 제공하는 사전 학습된 가중치를 다운로드하고 [이것](https://github.com/facebookresearch/vggt/tree/evaluation/evaluation)을 따라 Co3D 데이터셋을 준비합니다.

그런 다음 [huggingface](https://huggingface.co/wlfeng/QuantVGGT/tree/main)에서 사전 학습된 W4A4 양자화 매개변수를 다운로드하고 다운로드한 폴더를 *evaluation\outputs\w4a4* 브랜치 아래에 배치합니다.

이제 제공된 스크립트를 사용하여 추론할 수 있습니다 **(스크립트 내 데이터 경로를 변경하는 것을 잊지 마십시오)**.


```
cd evaluation
bash test.sh
```
또한, 양자화된 모델을 사용하여 다른 3D 속성을 예측할 수 있으며, 자세한 내용은 [여기](https://github.com/facebookresearch/vggt/tree/evaluation#detailed-usage)를 참고하세요.

## 코멘트

* 저희 코드베이스는 [VGGT](https://github.com/facebookresearch/vggt)와 [QuaRot](https://github.com/spcl/QuaRot)에 크게 기반하고 있습니다. 오픈소스 공개에 감사드립니다!

## BibTeX

*QuantVGGT*가 귀하의 연구에 유용하다면, 본 논문을 인용해 주시기 바랍니다:


```
@article{feng2025quantized,
  title={Quantized Visual Geometry Grounded Transformer},
  author={Feng, Weilun and Qin, Haotong and Wu, Mingqiang and Yang, Chuanguang and Li, Yuqi and Li, Xiangqi and An, Zhulin and Huang, Libo and Zhang, Yulun and Magno, Michele and others},
  journal={arXiv preprint arXiv:2509.21302},
  year={2025}
}
```



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-01

---
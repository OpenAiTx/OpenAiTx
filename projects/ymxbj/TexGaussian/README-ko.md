<h1 align="center">TexGaussian: Octree 기반 3D Gaussian Splatting을 통한 고품질 PBR 소재 생성</h1>
<p align="center"><a href="https://arxiv.org/abs/2411.19654"><img src='https://img.shields.io/badge/arXiv-Paper-red?logo=arxiv&logoColor=white' alt='arXiv'></a>
<a href='https://3d-aigc.github.io/TexGaussian/'><img src='https://img.shields.io/badge/Project_Page-Website-green?logo=googlechrome&logoColor=white' alt='Project Page'></a>
<p align="center"><img src="https://raw.githubusercontent.com/ymxbj/TexGaussian/main/assets/teaser.png" width="100%"></p>

물리 기반 렌더링(Physically Based Rendering, PBR) 소재는 현대 그래픽스에서 중요한 역할을 하며, 다양한 환경 맵에서 사실적인 렌더링을 가능하게 합니다. 3D 메시를 위한 RGB 텍스처 대신 고품질 PBR 소재를 자동으로 생성할 수 있는 효과적이고 효율적인 알고리즘을 개발하면 3D 콘텐츠 제작 프로세스를 크게 간소화할 수 있습니다. 대부분의 기존 방법은 사전 학습된 2D 확산 모델을 활용하여 다중 뷰 이미지를 합성하지만, 이로 인해 생성된 텍스처와 입력 3D 메시 간의 일관성이 크게 저하되는 문제가 있습니다. 본 논문에서는 TexGaussian을 제안합니다. 이는 옥탄트 정렬 3D Gaussian Splatting을 사용하여 빠르게 PBR 소재를 생성하는 새로운 방법입니다. 구체적으로, 입력 3D 메시로부터 구축한 Octree의 가장 미세한 리프 노드에 각 3D Gaussian을 배치하여, 알베도 맵뿐만 아니라 러프니스, 메탈릭에 대한 다중 뷰 이미지를 렌더링합니다. 또한, 본 모델은 확산 디노이징 대신 회귀 방식으로 학습되어, 단일 피드포워드 과정에서 3D 메시의 PBR 소재를 생성할 수 있습니다. 공개 벤치마크에서의 광범위한 실험 결과, 본 방법은 기존 방법보다 조건 없는(unconditional) 및 텍스트 조건(text-conditional) 시나리오 모두에서 더 일관성 있고 시각적으로 우수한 PBR 소재를 더 빠르게 합성함을 보여줍니다.

## 📦 설치

```bash
conda create -n texgaussian python==3.10
pip3 install torch==2.1.0 torchvision==0.16.0 torchaudio==2.1.0 --index-url https://download.pytorch.org/whl/cu118

# 수정된 Gaussian Splatting (+ depth, alpha rendering)
git clone --recursive https://github.com/ashawkey/diff-gaussian-rasterization

pip3 install ./diff-gaussian-rasterization

pip3 install git+https://github.com/NVlabs/nvdiffrast

# 기타 의존성
pip3 install -r requirements.txt
```

## 🤖 사전학습 모델

다음과 같은 사전학습 모델을 제공합니다:

| 모델 | 설명 | 파라미터 | 다운로드 |
| --- | --- | --- | --- |
| TexGaussian-bench | ShapeNet 벤치에서 훈련된 조건 없는 RGB 텍스처 모델 | 70M | [다운로드](https://huggingface.co/ymxbj/TexGaussian/resolve/main/bench.safetensors?download=true) |
| TexGaussian-car | ShapeNet 자동차에서 훈련된 조건 없는 RGB 텍스처 모델 | 70M | [다운로드](https://huggingface.co/ymxbj/TexGaussian/resolve/main/car.safetensors?download=true) |
| TexGaussian-chair | ShapeNet 의자에서 훈련된 조건 없는 RGB 텍스처 모델 | 70M | [다운로드](https://huggingface.co/ymxbj/TexGaussian/resolve/main/chair.safetensors?download=true) |
| TexGaussian-table | ShapeNet 테이블에서 훈련된 조건 없는 RGB 텍스처 모델 | 70M | [다운로드](https://huggingface.co/ymxbj/TexGaussian/resolve/main/table.safetensors?download=true) |
| TexGaussian-PBR | Objaverse에서 훈련된 텍스트 조건 PBR 소재 모델 | 295M | [다운로드](https://huggingface.co/ymxbj/TexGaussian/resolve/main/PBR_model.safetensors?download=true) |

## 💡 추론

### PBR 소재
텍스트 조건 PBR 소재 생성을 위해, 다음을 실행하세요.
```bash
bash inference_for_PBR_material.sh
```
텍스처 및 소재 베이킹 후, 두 개의 맵을 얻을 수 있습니다. 하나는 알베도 맵이고, 다른 하나는 PBR 소재 맵입니다. 특히, PBR 소재 맵은 3채널로, 그린 채널은 러프니스 값을, 블루 채널은 메탈릭 값을 나타냅니다. 생성된 텍스처 및 소재 맵의 PBR 렌더링을 위해 [이 렌더링 스크립트](https://github.com/ymxbj/BlenderToolboxPBR)(bpy 기반 사용)을 권장합니다.

추가로, Cap3D 데이터셋의 텍스트 스타일을 참고하여 자신만의 프롬프트를 생성하면 더 나은 결과를 얻을 수 있습니다. Cap3D 데이터셋은 [여기](https://huggingface.co/ymxbj/TexGaussian/resolve/main/Cap3D_automated_Objaverse_full.csv?download=true)에서 다운로드할 수 있습니다.

### RGB 텍스처
조건 없는 RGB 텍스처 생성을 위해, 이는 벤치, 자동차, 의자, 테이블의 4가지 특정 카테고리에서만 동작합니다.
```bash
bash inference_for_RGB_texture.sh
```
텍스처 베이킹 후 하나의 알베도 맵을 얻을 수 있습니다.

## 🏋️‍♂️ 학습
Objaverse용:
```bash
bash train_for_objaverse.sh
```

ShapeNet용:
```bash
bash train_for_shapenet.sh
```

## 🚧 TODO
- [x] 학습 및 추론 코드 공개
- [x] ShapeNet 데이터셋 기반 조건 없는 알베도 전용 사전학습 모델 공개
- [x] Objaverse 데이터셋 기반 텍스트 조건 PBR 사전학습 모델 공개
- [ ] 데이터셋 및 데이터셋 툴킷 공개

## 📚 감사의 말

본 연구는 여러 훌륭한 연구 및 오픈소스 프로젝트에 기반하고 있습니다. 모든 저자분들께 감사드립니다!

- [gaussian-splatting](https://github.com/graphdeco-inria/gaussian-splatting) 및 [diff-gaussian-rasterization](https://github.com/graphdeco-inria/diff-gaussian-rasterization)
- [nvdiffrast](https://github.com/NVlabs/nvdiffrast)
- [LGM](https://github.com/3DTopia/LGM)
- [ocnn-pytorch](https://github.com/octree-nn/ocnn-pytorch)

<!-- Citation -->
## 📜 인용

본 연구가 도움이 되셨다면 아래 논문을 인용해 주세요.

1. arXiv 버전
```bibtex
@article{xiong2024texgaussian,
  title={TexGaussian: Generating High-quality PBR Material via Octree-based 3D Gaussian Splatting},
  author={Xiong, Bojun and Liu, Jialun and Hu, Jiakui and Wu, Chenming and Wu, Jinbo and Liu, Xing and Zhao, Chen and Ding, Errui and Lian, Zhouhui},
  journal={arXiv preprint arXiv:2411.19654},
  year={2024}
}
```

2. CVPR 버전
```bibtex
@InProceedings{Xiong_2025_CVPR,
    author    = {Xiong, Bojun and Liu, Jialun and Hu, Jiakui and Wu, Chenming and Wu, Jinbo and Liu, Xing and Zhao, Chen and Ding, Errui and Lian, Zhouhui},
    title     = {TexGaussian: Generating High-quality PBR Material via Octree-based 3D Gaussian Splatting},
    booktitle = {Proceedings of the Computer Vision and Pattern Recognition Conference (CVPR)},
    month     = {June},
    year      = {2025},
    pages     = {551-561}
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---
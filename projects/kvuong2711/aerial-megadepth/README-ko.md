<div align="center">

# AerialMegaDepth: 항공-지상 재구성 및 뷰 합성 학습

[Khiem Vuong](https://www.khiemvuong.com/), [Anurag Ghosh](https://anuragxel.github.io/), [Deva Ramanan*](https://www.cs.cmu.edu/~deva), [Srinivasa Narasimhan*](https://www.cs.cmu.edu/~srinivas), [Shubham Tulsiani*](https://shubhtuls.github.io/)

**CVPR 2025**

[[`arXiv`](https://arxiv.org/abs/2504.13157)]
[[`프로젝트 페이지`](https://aerial-megadepth.github.io/)]
[[`3D 웹 뷰어`](https://aerial-megadepth.github.io/web-viewer/)]
[[`Bibtex`](#citation)]

</div>

## 📢 소식
- (2025년 9월 5일): 전체 데이터셋을 HuggingFace로 이전하여 다운로드를 더 쉽게 했습니다. 전체 지침은 [data_generation](data_generation)을 참고하세요.

## 목차

- [설치](#installation)
- [빠른 시작](#quick-start)
- [평가](#evaluation)
- [데이터 생성](#data-generation)
- [감사의 글](#acknowledgement)
- [인용](#citation)
- [이슈](#issues)


## 📋 시작하기 전에...
관심사에 따라:

- 🚀 **사전 학습된 체크포인트를 다운로드하고 데모를 실행하고 싶다면**: 아래 내용을 계속 읽으세요.

- 🛠️ **데이터셋에 접근하거나 직접 생성하고 싶다면**: 전체 지침은 [data_generation](data_generation)을 참고하세요.

## 설치

아래는 설치 안내입니다 ([MASt3R repo](https://github.com/naver/mast3r)를 주로 따릅니다). MASt3R 설치를 따르는 이유는 DUSt3R를 포함하고 있기 때문이며, 두 방법 모두 유사하게 작동합니다.

1. 저장소를 복제합니다:

```bash
git clone --recursive https://github.com/kvuong2711/aerial-megadepth.git
cd aerial-megadepth/mast3r

# If you already cloned the repository, you can update the submodules:
# git submodule update --init --recursive
```
2. 환경을 만들고 종속성을 설치합니다:
```bash
conda create -n aerialmd python=3.11 cmake=3.14.0
conda activate aerialmd 
conda install pytorch torchvision pytorch-cuda=12.1 -c pytorch -c nvidia  # use the correct version of cuda for your system
pip install -r requirements.txt
pip install -r dust3r/requirements.txt
pip install -r dust3r/requirements_optional.txt
```
3. 선택 사항, RoPE용 cuda 커널을 컴파일합니다 (CroCo v2와 같이):
```bash
# DUST3R relies on RoPE positional embeddings for which you can compile some cuda kernels for faster runtime.
cd dust3r/croco/models/curope/
python setup.py build_ext --inplace
cd ../../../../
```
## 빠른 시작
저희의 미세 조정된 체크포인트는 원래 DUSt3R/MASt3R/MASt3R-SfM 코드베이스와 완벽하게 호환됩니다 - 이미 설정되어 있다면, 항공-지상 시나리오에 맞게 체크포인트만 교체하면 됩니다!

### 체크포인트

저희 AerialMegaDepth 데이터셋으로 미세 조정된 DUSt3R 및 MASt3R 체크포인트를 다운로드하는 두 가지 옵션이 있습니다:

1. huggingface_hub 통합을 사용할 수 있습니다: 모델들 ([aerial-dust3r](https://huggingface.co/kvuong2711/checkpoint-aerial-dust3r) 또는 [aerial-mast3r](https://huggingface.co/kvuong2711/checkpoint-aerial-mast3r))이 자동으로 다운로드됩니다.

2. 또는, 체크포인트를 수동으로 다운로드할 수 있습니다 ([gdown](https://github.com/wkentaro/gdown) 사용, `pip install gdown`로 설치):


```bash
# you are inside aerial-megadepth/mast3r
mkdir -p checkpoints/
gdown --fuzzy "https://drive.google.com/open?id=1wSGpYwWeGn99J8dVWNkfefwmWMAH7LFT" -O checkpoints/  # checkpoint-aerial-dust3r.pth
gdown --fuzzy "https://drive.google.com/open?id=1LrRNUQRQZcVzcioyYHYYx9ImypSZpUq2" -O checkpoints/  # checkpoint-aerial-mast3r.pth
```
### 추론/데모
빠른 테스트를 위해 [assets](assets) 폴더에 몇 가지 예제 이미지가 제공되며, 여기에는 [ULTRRA challenge](https://sites.google.com/view/ultrra-wacv-2025) 및 [Accenture-NVS1](https://arxiv.org/pdf/2503.18711)에서 가져온 이미지가 포함됩니다.

각 스크립트(예: [demo_dust3r_nongradio.py](https://raw.githubusercontent.com/kvuong2711/aerial-megadepth/main/mast3r/demo_dust3r_nongradio.py))에는 일반적인 사용 사례를 보여주기 위한 미리 정의된 이미지 경로가 포함되어 있습니다. 스크립트 내의 `image_list` 변수를 수정하여 다양한 쌍을 시도할 수 있습니다. 다음 명령어로 추론을 실행할 수 있습니다:

- DUSt3R 데모 코드:

```bash
python demo_dust3r_nongradio.py --weights kvuong2711/checkpoint-aerial-dust3r

# or, if you downloaded the checkpoints manually:
# python demo_dust3r_nongradio.py --weights checkpoints/checkpoint-aerial-dust3r.pth
```

- MASt3R 데모 코드:
```bash
python demo_mast3r_nongradio.py --weights kvuong2711/checkpoint-aerial-mast3r

# or, if you downloaded the checkpoints manually:
# python demo_mast3r_nongradio.py --weights checkpoints/checkpoint-aerial-mast3r.pth
```
![matching example](https://raw.githubusercontent.com/kvuong2711/aerial-megadepth/main/assets/figures/matches_figure.png)

## 평가

- [ ] **할 일:** 평가 데이터가 곧 공개될 예정입니다.

데이터를 다운로드한 후 평가 스크립트를 실행하세요:
```bash
python eval.py \
    --weights checkpoints/checkpoint-aerial-dust3r.pth \
    --eval_data_dir data/eval_data_release
```
이 스크립트는 ([PoseDiffusion](https://github.com/facebookresearch/PoseDiffusion)에서 수정됨) 다양한 각도 임계값에서 RRA 및 RTA를 보고합니다.

## 데이터 생성
데이터 다운로드 및/또는 생성 방법에 대한 지침은 [data_generation](data_generation)을 참조하십시오.

## 감사의 글
이 코드베이스는 [MegaDepth](https://www.cs.cornell.edu/projects/megadepth), [DUSt3R](https://github.com/naver/dust3r), [hloc](https://github.com/cvg/Hierarchical-Localization), [COLMAP](https://github.com/colmap/colmap) 등 많은 훌륭한 오픈 소스 프로젝트를 기반으로 합니다. 해당 작업을 공개해 주신 저자분들께 감사드립니다.

## 인용
본 연구가 귀하의 연구에 유용하다면, 저희 논문을 인용해 주시기 바랍니다:

```bibtex
@inproceedings{vuong2025aerialmegadepth,
  title={AerialMegaDepth: Learning Aerial-Ground Reconstruction and View Synthesis},
  author={Vuong, Khiem and Ghosh, Anurag and Ramanan, Deva and Narasimhan, Srinivasa and Tulsiani, Shubham},
  booktitle={Proceedings of the IEEE/CVF Conference on Computer Vision and Pattern Recognition},
  year={2025},
}
```

## 문제점
문제/질문/제안이 있으면, 자유롭게 이슈를 생성하거나 [이메일](https://raw.githubusercontent.com/kvuong2711/aerial-megadepth/main/mailto:kvuong@andrew.cmu.edu)을 통해 직접 저에게 연락하세요.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-23

---
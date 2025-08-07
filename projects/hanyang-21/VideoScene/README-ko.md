<p align="center">
  <h1 align="center">VideoScene: 비디오 확산 모델을 증류하여 한 번에 3D 장면 생성하기</h1>
  <p align="center">
    <a href="https://hanyang-21.github.io/">한양 왕</a><sup>*</sup>,
    <a href="https://liuff19.github.io/">팡푸 류</a><sup>*</sup>,
    <a href="https://github.com/hanyang-21/VideoScene">자웨이 치</a>,
    <a href="https://duanyueqi.github.io/">위에치 둔</a>
    <br>
    <sup>*</sup>동등 기여.
    <br>
    칭화대학교
  </p>
  <h3 align="center">CVPR 2025 하이라이트 🔥</h3>
  <h5 align="center">

[![arXiv](https://img.shields.io/badge/Arxiv-2403.20309-b31b1b.svg?logo=arXiv)](https://arxiv.org/abs/2504.01956) 
[![Home Page](https://img.shields.io/badge/Project-Website-green.svg)](https://hanyang-21.github.io/VideoScene)
<a><img src='https://img.shields.io/badge/License-MIT-blue'></a>
<a href='https://mp.weixin.qq.com/s/u6OUo5mHKPG6I3yYJPMC8Q'><img src='https://img.shields.io/badge/%E5%BE%AE%E4%BF%A1-%E4%B8%AD%E6%96%87%E4%BB%8B%E7%BB%8D-green'></a>

</h5>
  <!-- <h3 align="center"><a href="https://arxiv.org/abs/">논문</a> | <a href="">프로젝트 페이지</a> | <a href="">사전학습 모델</a> </h3> -->
<!--   <div align="center">
    <a href="https://news.ycombinator.com/item?id=41222655">
      <img
        alt="Featured on Hacker News"
        src="https://hackerbadge.vercel.app/api?id=41222655&type=dark"
      />
    </a>
  </div> -->

</p>

<div align="center">
VideoScene는 비디오에서 3D로의 격차를 연결하는 한 단계 비디오 확산 모델입니다.
</div>
</br>


https://github.com/user-attachments/assets/dca733b1-b78f-49ac-ae47-5d1b1e8a689b

[ReconX](https://github.com/liuff19/ReconX)를 기반으로, VideoScene은 터보 버전의 발전을 이루어냈습니다.



## 설치

시작하려면 이 프로젝트를 클론하고, Python 3.10+를 사용하는 conda 가상 환경을 생성한 후 요구사항을 설치하세요:

1. VideoScene을 클론합니다.
```bash
git clone https://github.com/hanyang-21/VideoScene
cd VideoScene
```
2. 환경을 생성합니다. 여기서는 conda를 사용하는 예를 보여줍니다.

```bash
conda create -y -n videoscene python=3.10
conda activate videoscene
pip install torch==2.1.2 torchvision==0.16.2 torchaudio==2.1.2 --index-url https://download.pytorch.org/whl/cu118
pip install -r requirements.txt
```

3. 선택 사항으로, RoPE용 cuda 커널을 컴파일합니다 (CroCo v2와 동일).
```bash
# NoPoSplat relies on RoPE positional embeddings for which you can compile some cuda kernels for faster runtime.
cd src/model/encoder/backbone/croco/curope/
python setup.py build_ext --inplace
cd ../../../../../..
```

## 데이터셋 획득

### RealEstate10K 및 ACID

우리 VideoScene은 pixelSplat과 동일한 학습 데이터셋을 사용합니다. 아래는 pixelSplat의 [상세 지침](https://github.com/dcharatan/pixelsplat?tab=readme-ov-file#acquiring-datasets)을 인용한 내용입니다.

> pixelSplat은 RealEstate10k 및 ACID 데이터셋 버전을 서버 클러스터 파일 시스템에서 사용하기 위해 약 100MB 크기로 분할된 형태로 학습되었습니다. 이 형식의 RealEstate10k 및 ACID 데이터셋의 소규모 하위 집합은 [여기](https://drive.google.com/drive/folders/1joiezNCyQK2BvWMnfwHJpm2V77c7iYGe?usp=sharing)에서 찾을 수 있습니다. 사용하려면 프로젝트 루트 디렉토리에 새로 생성한 `datasets` 폴더에 압축을 풀기만 하면 됩니다.

> 다운로드한 RealEstate10k 및 ACID 데이터셋을 우리 형식으로 변환하려면 [여기](https://github.com/dcharatan/real_estate_10k_tools)의 스크립트를 사용할 수 있습니다. 처리된 데이터셋의 전체 버전(RealEstate10k 약 500GB, ACID 약 160GB)이 필요하면 pixelSplat에 문의하세요.

## 체크포인트 다운로드

* 우리의 [사전 학습 가중치](https://wisemodel.cn/models/hanyang/VideoScene/file) (`VideoScene/checkpoints/model.safetensors` 및 `VideoScene/checkpoints/prompt_embeds.pt`)를 다운로드하여 `checkpoints`에 저장하세요.

* 맞춤형 이미지 입력용으로, NoPoSplat [사전 학습 모델](https://huggingface.co/botaoye/NoPoSplat/resolve/main/mixRe10kDl3dv_512x512.ckpt)을 다운로드하여 `checkpoints/noposplat`에 저장하세요.

* RealEstate10K 데이터셋용으로, MVSplat [사전 학습 모델](https://drive.google.com/drive/folders/14_E_5R6ojOWnLSrSVLVEMHnTiKsfddjU)을 다운로드하여 `checkpoints/mvsplat`에 저장하세요.

## 코드 실행

### Gradio 데모
이 데모에서는 VideoScene을 로컬에서 실행하여 포즈가 없는 입력 뷰로 비디오를 생성할 수 있습니다.

* 동일한 장면을 묘사하는 이미지 쌍을 선택하고 "RUN"을 클릭하여 해당 장면의 비디오를 생성하세요.


```bash
python -m noposplat.src.app \
    checkpointing.load=checkpoints/noposplat/mixRe10kDl3dv_512x512.ckpt \
    test.video=checkpoints/model.safetensors

# also "bash demo.sh"
```
* 생성된 비디오는 `outputs/gradio`에 저장됩니다

### 추론

RealEstate10K 데이터셋에서 비디오를 생성하기 위해, [MVSplat](https://github.com/donydchen/mvsplat) 사전학습 모델을 사용합니다,

* 다음을 실행하세요:

```bash
# re10k
python -m mvsplat.src.main +experiment=re10k \
checkpointing.load=checkpoints/mvsplat/re10k.ckpt \
mode=test \
dataset/view_sampler=evaluation \
dataset.view_sampler.index_path=mvsplat/assets/evaluation_index_re10k_video.json \
test.save_video=true \
test.save_image=false \
test.compute_scores=false \
test.video=checkpoints/model.safetensors

# also "bash inference.sh"
```

* 생성된 비디오는 `outputs/test` 아래에 저장됩니다


## BibTeX

```bibtex
@misc{wang2025videoscenedistillingvideodiffusion,
      title={VideoScene: Distilling Video Diffusion Model to Generate 3D Scenes in One Step}, 
      author={Hanyang Wang and Fangfu Liu and Jiawei Chi and Yueqi Duan},
      year={2025},
      eprint={2504.01956},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2504.01956}, 
}
```

## 감사의 글

이 프로젝트는 여러 훌륭한 저장소들과 함께 개발되었습니다: [ReconX](https://github.com/liuff19/ReconX), [MVSplat](https://github.com/donydchen/mvsplat), [NoPoSplat](https://github.com/cvg/NoPoSplat), [CogVideo](https://github.com/THUDM/CogVideo), 그리고 [CogvideX-Interpolation](https://github.com/feizc/CogvideX-Interpolation). 이들 프로젝트의 뛰어난 기여에 깊은 감사를 드립니다!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-07

---
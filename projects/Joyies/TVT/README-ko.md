<div align="center">
<h2>전이 VAE 학습을 통한 미세구조 보존 실제 이미지 초해상화</h2>

🚩 ICCV2025 채택

[Qiaosi Yi](https://dblp.org/pid/249/8335.html)<sup>1,2</sup>
| [Shuai Li](https://scholar.google.com/citations?hl=zh-CN&user=Bd73ldQAAAAJ)<sup>1</sup>
| [Rongyuan Wu](https://scholar.google.com/citations?user=A-U8zE8AAAAJ&hl=zh-CN)<sup>1,2</sup>
| [Lingchen Sun](https://scholar.google.com/citations?hl=zh-CN&tzom=-480&user=ZCDjTn8AAAAJ)<sup>1,2</sup>
| [Yuhui Wu](https://dblp.org/pid/41/915-1.html)<sup>1,2</sup>
| [Lei Zhang](https://www4.comp.polyu.edu.hk/~cslzhang)<sup>1,2</sup>

<sup>1</sup>홍콩 폴리텍대학교, <sup>2</sup>OPPO 연구소
</div>

[![](https://img.shields.io/badge/ArXiv%20-Paper-b31b1b?logo=arxiv&logoColor=red)](https://arxiv.org/pdf/2507.20291)&nbsp; [![weights](https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-model%20weights-blue)](https://huggingface.co/Joypop/TVTSR/tree/main)


## ⏰ 업데이트
- **2025.7.29**: 논문이 [ArXiv](https://arxiv.org/pdf/2507.20291)에 공개되었습니다.
- **2025.7.28**: 학습 코드와 테스트 코드가 공개되었습니다.
- **2025.7.24**: 저장소가 공개되었습니다.

:star: TVT가 여러분의 이미지나 프로젝트에 도움이 된다면, 이 저장소에 별을 눌러주세요. 감사합니다! :hugs:

### 할 일
- [x] 추론용 코드 공개.
- [x] 학습 코드 업데이트.
- [ ] fp16 VAED4.


## ⚙ 의존성 및 설치
```shell
## git clone this repository
git clone https://github.com/Joyies/TVT.git
cd TVT


# create an environment
conda create -n TVT python=3.10
conda activate TVT
pip install --upgrade pip
pip install -r requirements.txt
```
## 🏂 빠른 추론

### 실제 이미지 초해상도

#### 1단계: 사전 학습된 모델 다운로드
- 사전 학습된 SD-2.1-base 모델을 [![weights](https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-SD%202.1%20Base-blue)](https://huggingface.co/Joypop/stable-diffusion-2-1-base)&nbsp;에서 다운로드합니다.
- 모델 가중치([VAED4](https://huggingface.co/Joypop/TVTSR/tree/main/ckp), [TVT 모델](https://huggingface.co/Joypop/TVTSR/tree/main/ckp), [TVTUNet](https://huggingface.co/Joypop/TVTSR/tree/main/ckp), [DAPE](https://huggingface.co/Joypop/TVTSR/tree/main/ckp), 그리고 [RAM](https://huggingface.co/Joypop/TVTSR/tree/main/ckp))를 [![weights](https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-model%20weights-blue)](https://huggingface.co/Joypop/TVTSR/tree/main)&nbsp;에서 다운로드하여 `ckp/`에 넣습니다.

#### 2단계: 테스트 데이터 준비 및 테스트 명령 실행
입력 경로(input_path)와 출력 경로(output_path)를 수정하여 테스트 명령을 실행할 수 있습니다. 입력 경로는 테스트 이미지 경로이고 출력 경로는 출력 이미지가 저장될 경로입니다.

```
python TVT/inferences/inference.py \
--input_image input_path \
--output_dir output_path \
--pretrained_path ckp/model_TVT.pkl \
--pretrained_model_name_or_path stabilityai/stable-diffusion-2-1-base \
--pretrained_unet_path ckp/TVTUNet \
--vae4d_path ckp/vae.ckpt \
--ram_ft_path ckp/DAPE.pth \
--negprompt 'dotted, noise, blur, lowres, smooth' \
--prompt 'clean, high-resolution, 8k' \
--upscale 4 \
--time_step 1
```
or 
```
bash scripts/test/test_realsr.sh
```
또한 추론 시 GPU 메모리를 절약하기 위한 타일 코드를 제공합니다. 실행 명령어를 실행하고 장치의 VRAM에 따라 타일 크기와 스트라이드를 변경할 수 있습니다.
```
python TVT/inferences/inference_tile.py \
--input_image input_path \
--output_dir output_path \
--pretrained_path ckp/model_TVT.pkl \
--pretrained_model_name_or_path stabilityai/stable-diffusion-2-1-base \
--pretrained_unet_path ckp/TVTUNet \
--vae4d_path ckp/vae.ckpt \
--ram_ft_path ckp/DAPE.pth \
--negprompt 'dotted, noise, blur, lowres, smooth' \
--prompt 'clean, high-resolution, 8k' \
--upscale 4 \
--time_step 1 \
--tiled_size 96 \
--tiled_overlap 32
```
## 🚄 학습 단계

### OpenImage 데이터셋과 LSDIR 데이터셋으로 VAED4 학습
#### Step1: 학습 데이터 준비
[OpenImage 데이터셋](https://storage.googleapis.com/openimages/web/index.html)과 [LSIDR 데이터셋](https://github.com/ofsoundof/LSDIR)을 다운로드합니다. LSDIR 데이터셋의 각 이미지에 대해, 스트라이드 64 픽셀의 슬라이딩 윈도우를 사용해 여러 개의 512×512 이미지 패치를 자릅니다;

#### Step2: VAED4 학습
VAED4 학습에는 [LDM 코드](https://github.com/CompVis/latent-diffusion)를 사용합니다. 


### Real-ISR 데이터셋으로 TVTSR 학습
#### Step1: 학습 데이터 준비

[LSIDR 데이터셋](https://github.com/ofsoundof/LSDIR)과 처음 1만 장의 [FFHQ 데이터셋](https://github.com/NVlabs/ffhq-dataset)을 다운로드합니다. 이후 학습 데이터셋에 대해 데이터 증강을 수행합니다. 구체적으로, LSDIR 데이터셋의 각 이미지에 대해 스트라이드 64 픽셀의 슬라이딩 윈도우로 여러 개의 512×512 이미지 패치를 자르고; FFHQ 데이터셋의 경우 모든 이미지를 512×512로 직접 리사이즈합니다.

#### Step2: Real-ISR 모델 학습

1. [VAED4](https://huggingface.co/Joypop/TVTSR/tree/main/ckp), [TVTUNet](https://huggingface.co/Joypop/TVTSR/tree/main/ckp), [RAM](https://huggingface.co/Joypop/TVTSR/tree/main/ckp) 모델을 다운로드하고, 이 모델들을 `ckp/` 폴더에 넣습니다. 

2. 학습을 시작합니다.

    ```shell
   accelerate launch --gpu_ids=0,1,2,3, --num_processes=4 TVT/train_TVTSR/train.py \
    --pretrained_model_name_or_path="stabilityai/stable-diffusion-2-1-base" \
    --pretrained_model_name_or_path_vsd="stabilityai/stable-diffusion-2-1-base" \
    --pretrained_unet_path='ckp/TVTUNet' \
    --vae4d_path='ckp/vae.ckpt' \
    --dataset_folder="data_path" \
    --testdataset_folder="test_path" \
    --resolution=512 \
    --learning_rate=5e-5 \
    --train_batch_size=2 \
    --gradient_accumulation_steps=2 \
    --enable_xformers_memory_efficient_attention \
    --eval_freq 500 \
    --checkpointing_steps 500 \
    --mixed_precision='fp16' \
    --report_to "tensorboard" \
    --output_dir="output_path" \
    --lora_rank_unet_vsd=4 \
    --lora_rank_unet=4 \
    --lambda_lpips=2 \
    --lambda_l2=1 \
    --lambda_vsd=1 \
    --lambda_vsd_lora=1 \
    --min_dm_step_ratio=0.25 \
    --max_dm_step_ratio=0.75 \
    --use_vae_encode_lora \
    --align_method="adain" \
    --use_online_deg \
    --deg_file_path="params_TVT.yml" \
    --negative_prompt='painting, oil painting, illustration, drawing, art, sketch, oil painting, cartoon, CG Style, 3D render, unreal engine, blurring, dirty, messy, worst quality, low quality, frames, watermark, signature, jpeg artifacts, deformed, lowres, over-smooth' \
    --test_image_prep='no_resize' \
    --time_step=1 \
    --tracker_project_name "experiment_track_name"
    ```
    or
    ```shell
   bash scripts/train/train.sh
    ```

## 🔗 인용
저희 코드가 연구나 작업에 도움이 되셨다면, 논문 인용을 고려해 주세요.
다음은 BibTeX 참고문헌입니다:

```
@article{yi2025fine,
  title={Fine-structure Preserved Real-world Image Super-resolution via Transfer VAE Training},
  author={Yi, Qiaosi and Li, Shuai and Wu, Rongyuan and Sun, Lingchen and Wu, Yuhui and Zhang, Lei},
  booktitle={Proceedings of the IEEE/CVF international conference on computer vision},
  year={2025}
}
```
## ©️ 라이선스
이 프로젝트는 [Apache 2.0 라이선스](LICENSE) 하에 공개되어 있습니다.

## 📧 연락처
문의사항이 있으면 다음 주소로 연락해 주세요: qiaosiyijoyies@gmail.com

## 감사의 글
이 프로젝트는 [diffusers](https://github.com/huggingface/diffusers), [LDM](https://github.com/CompVis/latent-diffusion), [OSEDiff](https://github.com/cswry/OSEDiff) 및 [PiSA-SR](https://github.com/csslc/PiSA-SR)을 기반으로 합니다. 훌륭한 작업에 감사드립니다.

<details>
<summary>통계</summary>

![방문자](https://visitor-badge.laobi.icu/badge?page_id=Joyies/TVT)

</details>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-22

---
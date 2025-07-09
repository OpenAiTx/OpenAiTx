<div align="center">
<h2>디테일이 풍부하고 시간적으로 일관된 비디오 초해상도를 위한 원스텝 디퓨전</h2>

[Yujing Sun](https://yjsunnn.github.io/)<sup>1,2, *</sup> | 
[Lingchen Sun](https://scholar.google.com/citations?hl=zh-CN&tzom=-480&user=ZCDjTn8AAAAJ)<sup>1,2, *</sup> | 
[Shuaizheng Liu](https://scholar.google.com/citations?user=wzdCc-QAAAAJ&hl=en)<sup>1,2</sup> | 
[Rongyuan Wu](https://scholar.google.com/citations?user=A-U8zE8AAAAJ&hl=zh-CN)<sup>1,2</sup> | 
[Zhengqiang Zhang](https://scholar.google.com.tw/citations?user=UX26wSMAAAAJ&hl=en)<sup>1,2</sup> | 
[Lei Zhang](https://www4.comp.polyu.edu.hk/~cslzhang)<sup>1,2</sup>

<sup>1</sup>홍콩 폴리테크닉 대학교, <sup>2</sup>OPPO 연구소
</div>

<div>
    <h4 align="center">
        <a href="https://yjsunnn.github.io/DLoRAL-project/" target='_blank'>
        <img src="https://img.shields.io/badge/💡-Project%20Page-gold">
        </a>
        <a href="https://arxiv.org/pdf/2506.15591" target='_blank'>
        <img src="https://img.shields.io/badge/arXiv-2312.06640-b31b1b.svg">
        </a>
        <a href="https://www.youtube.com/embed/Jsk8zSE3U-w?si=jz1Isdzxt_NqqDFL&vq=hd1080" target='_blank'>
        <img src="https://img.shields.io/badge/Demo%20Video-%23FF0000.svg?logo=YouTube&logoColor=white">
        </a>
        <a href="https://www.youtube.com/embed/xzZL8X10_KU?si=vOB3chIa7Zo0l54v" target="_blank">
        <img src="https://img.shields.io/badge/2--Min%20Explainer-brightgreen?logo=YouTube&logoColor=white">
        </a>
        </a>
        <a href="https://github.com/yjsunnn/Awesome-video-super-resolution-diffusion" target="_blank">
        <img src="https://img.shields.io/badge/GitHub-Awesome--VSR--Diffusion-181717.svg?logo=github&logoColor=white">
        </a>
<!--         <a href="https://www.youtube.com/embed/Jsk8zSE3U-w?si=jz1Isdzxt_NqqDFL&vq=hd1080" target='_blank'>
        <img src="https://img.shields.io/badge/1--Min%20Algorithm%20Explainer-%23FF0000.svg?logo=YouTube&logoColor=white">
        </a> -->
        <a href="https://github.com/yjsunnn/DLoRAL" target='_blank' style="text-decoration: none;"><img src="https://visitor-badge.laobi.icu/badge?page_id=yjsunnn/DLoRAL"></a>
    </h4>
</div>

<p align="center">

<img src="https://raw.githubusercontent.com/yjsunnn/DLoRAL/main/assets/visual_results.svg" alt="Visual Results">

</p>
## ⏰ 업데이트

- **2025.07.08**: 추론 코드와 사전학습된 가중치가 제공됩니다.
- **2025.06.24**: 2분 분량의 간단한 설명 영상, 더 많은 시각적 결과 및 관련 연구를 포함한 프로젝트 페이지가 공개되었습니다.
- **2025.06.17**: 저장소가 공개되었습니다.

:star: DLoRAL이 여러분의 비디오나 프로젝트에 도움이 되었다면, 이 저장소에 별을 남겨주세요. 감사합니다! :hugs:

😊 관련 연구도 함께 참고해보세요:

1. **OSEDiff (NIPS2024)** [논문](https://arxiv.org/abs/2406.08177) | [코드](https://github.com/cswry/OSEDiff/)  

   OPPO Find X8 시리즈에 적용된 실시간 이미지 초해상도(SR) 알고리즘입니다.

2. **PiSA-SR (CVPR2025)** [논문](https://arxiv.org/pdf/2412.03017) | [코드](https://github.com/csslc/PiSA-SR) 

   이미지 SR에서 Dual-LoRA 패러다임을 선도적으로 탐구한 연구입니다.

3. **Awesome Diffusion Models for Video Super-Resolution** [저장소](https://github.com/yjsunnn/Awesome-video-super-resolution-diffusion)

   Diffusion Models을 활용한 비디오 초해상도(VSR) 관련 자료를 엄선하여 정리한 목록입니다.
## 👀 TODO
- [x] 추론 코드 공개.
- [ ] 편리한 테스트를 위한 Colab 및 Huggingface UI (곧 공개!).
- [ ] 학습 코드 공개.
- [ ] 학습 데이터 공개.


## 🌟 개요 프레임워크

<p align="center">

<img src="https://raw.githubusercontent.com/yjsunnn/DLoRAL/main/assets/pipeline.svg" alt="DLoRAL Framework">

</p>

**학습(Training)**: 동적 이중 단계 학습 방식은 시간적 일관성 최적화(일관성 단계)와 고주파 공간 세부 정보 정제(향상 단계) 사이를 번갈아 진행하며, 부드러운 손실 보간을 통해 안정성을 보장합니다.

**추론(Inference)**: 추론 시, C-LoRA와 D-LoRA가 고정된 diffusion UNet에 병합되어 저화질 입력을 고화질 출력으로 한 번에 향상시킵니다.
## 🔧 의존성 및 설치

1. 저장소 클론
    ```bash
    git clone https://github.com/yjsunnn/DLoRAL.git
    cd DLoRAL
    ```

2. 의존 패키지 설치
    ```bash
    conda create -n DLoRAL python=3.10 -y
    conda activate DLoRAL
    pip install -r requirements.txt
    ```

3. 모델 다운로드 
#### 의존 모델
* [SD21 Base](https://huggingface.co/stabilityai/stable-diffusion-2-1-base) --> **/path/to/DLoRAL/preset_models/stable-diffusion-2-1-base** 경로에 저장
* [Bert-Base](https://huggingface.co/google-bert/bert-base-uncased) --> **/path/to/DLoRAL/preset_models/bert-base-uncased** 경로에 저장
* [RAM](https://huggingface.co/spaces/xinyu1205/recognize-anything/blob/main/ram_swin_large_14m.pth) --> **/path/to/DLoRAL/preset/models/ram_swin_large_14m.pth** 경로에 저장
* [DAPE](https://drive.google.com/file/d/1KIV6VewwO2eDC9g4Gcvgm-a0LDI7Lmwm/view?usp=drive_link) --> **/path/to/DLoRAL/preset/models/DAPE.pth** 경로에 저장
* [Pretrained Weights](https://drive.google.com/file/d/1vpcaySpRx_K-tXq2D2EBqFZ-03Foky8G/view?usp=sharing) --> **/path/to/DLoRAL/preset/models/checkpoints/model.pkl** 경로에 저장

각 경로는 필요에 따라 수정할 수 있으며, 이에 맞게 명령어와 코드도 변경해야 합니다.
## 🖼️ 빠른 추론
실제 영상 초해상도(Real-World Video Super-Resolution)를 위해:

```
python src/test_DLoRAL.py     \
--pretrained_model_path /path/to/stable-diffusion-2-1-base     \
--ram_ft_path /path/to/DAPE.pth     \
--ram_path '/path/to/ram_swin_large_14m.pth'     \
--merge_and_unload_lora False     \
--process_size 512     \
--pretrained_model_name_or_path '/path/to/stable-diffusion-2-1-base'     \
--vae_encoder_tiled_size 4096     \
--load_cfr     \
--pretrained_path /path/to/model_checkpoint.pkl     \
--stages 1     \
-i /path/to/input_videos/     \
-o /path/to/results
```

### 인용
우리의 코드가 귀하의 연구나 작업에 도움이 되었다면, 논문을 인용해 주시기 바랍니다.
아래는 BibTeX 참고문헌입니다:

```
@misc{sun2025onestepdiffusiondetailrichtemporally,
      title={One-Step Diffusion for Detail-Rich and Temporally Consistent Video Super-Resolution}, 
      author={Yujing Sun and Lingchen Sun and Shuaizheng Liu and Rongyuan Wu and Zhengqiang Zhang and Lei Zhang},
      year={2025},
      eprint={2506.15591},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2506.15591}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---
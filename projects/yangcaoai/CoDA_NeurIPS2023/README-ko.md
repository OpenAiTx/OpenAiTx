
## :book: CoDA: 협업 소설 상자 발견 및 교차 모달 정렬을 통한 개방 어휘 3D 객체 감지 (NeurIPS2023)
<p align="center">
  <small> 🔥CoDA에 별⭐을 눌러주시고 공유해 주세요. 감사합니다🔥 </small>
</p>

> [[논문](https://arxiv.org/abs/2310.02960)] &emsp; [[프로젝트 페이지](https://yangcaoai.github.io/publications/CoDA.html)] <br>
<!-- > [Yang Cao](https://yangcaoai.github.io/), Yihan Zeng, [Hang Xu](https://xuhangcn.github.io/), [Dan Xu](https://www.danxurgb.net) <br> -->
<!-- > The Hong Kong University of Science and Technology, Huawei Noah's Ark Lab -->
> [Yang Cao](https://yangcaoai.github.io/), Yihan Zeng, [Hang Xu](https://xuhangcn.github.io/), [Dan Xu](https://www.danxurgb.net) <br>
> 홍콩과학기술대학교<br>
> 화웨이 노아의 방주 연구소

:triangular_flag_on_post: **업데이트**  

&#9745; 저희의 새로운 연구 **CoDAv2**가 TPAMI에 채택되었습니다, [여기](https://arxiv.org/pdf/2406.00830v2)에서 확인하세요!

&#9745; 3D 가우시안 스플래팅을 3D 객체 감지에 처음 도입한 연구인 3DGS-DET가 [여기](https://arxiv.org/pdf/2410.01647)에서 공개되었습니다!

&#9745; 개방 어휘 인식에 관한 최신 논문 및 코드를 [여기](https://github.com/yangcaoai/Awesome-Open-Vocabulary-Perception)에서 모았습니다.

&#9745; 모든 코드, 데이터 및 사전 학습된 모델이 공개되었습니다!

&#9745; 학습 및 테스트 코드가 공개되었습니다.

&#9745; 사전 학습된 모델이 공개되었습니다.

&#9745; OV 설정의 SUN-RGBD 데이터셋이 공개되었습니다.  

&#9745; OV 설정의 ScanNet 데이터셋이 공개되었습니다.

&#9745; 논문 LaTeX 코드는 https://scienhub.com/Yang/CoDA 에서 확인할 수 있습니다.

## 프레임워크  
<img src="https://raw.githubusercontent.com/yangcaoai/CoDA_NeurIPS2023/main/assets/ov3d_det.png">

## 샘플  
<img src="https://raw.githubusercontent.com/yangcaoai/CoDA_NeurIPS2023/main/assets/CoDA_sup_fig0_v3_cropped_compressed_v2.jpg">

## 설치
우리 코드는 PyTorch 1.8.1, torchvision==0.9.1, CUDA 10.1 및 Python 3.7을 기반으로 합니다. 다른 버전에서도 작동할 수 있습니다.

아래의 Python 종속성도 설치해 주십시오:

```
matplotlib
opencv-python
plyfile
'trimesh>=2.35.39,<2.35.40'
'networkx>=2.2,<2.3'
scipy
```

`pointnet2` 레이어를 설치하려면 다음을 실행하세요

```
cd third_party/pointnet2 && python setup.py install
```
더 빠른 학습을 위해 gIOU의 Cython화된 구현을 설치하십시오.

```
conda install cython
cd utils && python cython_compile.py build_ext --inplace
```

## 데이터셋 준비

OV 설정을 달성하기 위해, 원본 [ScanNet](https://github.com/facebookresearch/votenet/tree/main/scannet) 및 [SUN RGB-D](https://github.com/facebookresearch/votenet/tree/main/sunrgbd)를 재구성하고 더 많은 카테고리의 주석을 채택합니다. 여기에서 제공하는 OV 설정 데이터셋을 직접 다운로드하세요: [OV SUN RGB-D](https://huggingface.co/datasets/YangCaoCS/Open-Vocabulary-SUN-RGBD) 및 [OV ScanNet](https://hkustconnect-my.sharepoint.com/:f:/g/personal/ycaobd_connect_ust_hk/EsqoPe7-VFxOlY0a-v1-vPwBSiEHoGRTgK5cLIhnjyXiEQ?e=jY7nKT).

그런 다음 다운로드한 *.tar 파일에 대해 다음을 실행합니다:
```
bash data_preparation.sh
```

## 평가
사전 학습된 모델은 [여기](https://drive.google.com/file/d/1fTKX1ML5u8jJ249GwAYqdCZGs941907H/view?usp=drive_link)에서 다운로드하세요.
그런 다음 실행하세요:
```
bash test_release_models.sh
```

## 훈련
```
bash scripts/coda_sunrgbd_stage1.sh
bash scripts/coda_sunrgbd_stage2.sh
```
## 샘플 실행하기
```
bash run_samples.sh
```

## :scroll: BibTeX
CoDA가 도움이 되었다면, 다음을 인용해 주세요:
```
@inproceedings{cao2023coda,
  title={CoDA: Collaborative Novel Box Discovery and Cross-modal Alignment for Open-vocabulary 3D Object Detection},
  author={Cao, Yang and Zeng, Yihan and Xu, Hang and Xu, Dan},
  booktitle={NeurIPS},
  year={2023}
}

@article{cao2024collaborative,
  title={Collaborative Novel Object Discovery and Box-Guided Cross-Modal Alignment for Open-Vocabulary 3D Object Detection},
  author={Cao, Yang and Zeng, Yihan and Xu, Hang and Xu, Dan},
  journal={IEEE Transactions on Pattern Analysis and Machine Intelligence (TPAMI)},
  year={2025}
}
```

## :e-mail: 연락처

질문이나 협업 요청(연구 목적 또는 상업적 목적)이 있으시면 `yangcao.cs@gmail.com`으로 이메일을 보내주세요.

## :scroll: 감사의 글
CoDA는 [CLIP](https://github.com/openai/CLIP)과 [3DETR](https://github.com/facebookresearch/3detr)에서 영감을 받았습니다. 훌륭한 코드에 감사드립니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-21

---
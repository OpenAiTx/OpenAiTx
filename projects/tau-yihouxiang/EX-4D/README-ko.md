# EX-4D: 깊이 워터타이트 메시를 통한 익스트림 시점 4D 비디오 합성

<div align="center">

<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/Logo.png" alt="EX-4D Logo" width="250">

[📄 논문](https://arxiv.org/abs/2506.05554)  |  [🎥 홈페이지](https://tau-yihouxiang.github.io/projects/EX-4D/EX-4D.html)  |  [💻 코드](https://github.com/tau-yihouxiang/EX-4D)

</div>



## 🌟 하이라이트

- **🎯 익스트림 시점 합성**: -90°에서 90°까지의 카메라 이동으로 고품질 4D 비디오 생성
- **🔧 깊이 워터타이트 메시**: 가시 영역과 가려진 영역 모두를 모델링하는 새로운 기하학적 표현
- **⚡ 경량화된 아키텍처**: 14B 비디오 디퓨전 백본의 1%인 1억 4천만 개의 학습 가능 파라미터만 사용
- **🎭 멀티뷰 학습 불필요**: 혁신적인 마스킹 전략으로 고가의 멀티뷰 데이터셋 없이 학습 가능
- **🏆 최첨단 성능**: 기존 방법 대비 특히 극단적 카메라 각도에서 더 우수한 성능 제공

## 🎬 데모 결과

<div align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/teaser.png" alt="EX-4D Demo Results" width="800">
</div>

*EX-4D는 단안 비디오를 물리적으로 일관된 결과와 함께 카메라 제어가 가능한 4D 경험으로 변환합니다.*

## 🏗️ 프레임워크 개요

<div align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/overview.png" alt="EX-4D Architecture">
</div>

본 프레임워크는 세 가지 주요 구성 요소로 이루어져 있습니다:

1. **🔺 깊이 워터타이트 메시 구축**: 가시 영역과 가려진 영역을 모두 명시적으로 모델링하는 강력한 기하학적 프라이어 생성
2. **🎭 시뮬레이션 마스킹 전략**: 멀티뷰 데이터셋 없이 단안 비디오에서 효과적인 학습 데이터를 생성
3. **⚙️ 경량화된 LoRA 어댑터**: 사전 학습된 비디오 디퓨전 모델과 기하학 정보를 효율적으로 통합

## 🚀 빠른 시작

### 설치

```bash
# 저장소 클론
git clone https://github.com/tau-yihouxiang/EX-4D.git
cd EX-4D

# conda 환경 생성
conda create -n ex4d python=3.10
conda activate ex4d
# PyTorch 설치 (2.x 권장)
pip install torch==2.4.1 torchvision==0.19.1 torchaudio==2.4.1 --index-url https://download.pytorch.org/whl/cu124
# Nvdiffrast 설치
pip install git+https://github.com/NVlabs/nvdiffrast.git
# 의존성 및 diffsynth 설치
pip install -e .
# 깊이 추정을 위한 depthcrafter 설치 (체크포인트 준비는 DepthCrafter 설치 안내 참고)
git clone https://github.com/Tencent/DepthCrafter.git
```

### 사전학습 모델 다운로드
```bash
huggingface-cli download Wan-AI/Wan2.1-I2V-14B-480P --local-dir ./models/Wan-AI
huggingface-cli download yihouxiang/EX-4D --local-dir ./models/EX-4D
```

### 사용 예시
#### 1. DW-메시 재구성
```bash
# --cam 180 (30 / 60 / 90 / zoom_in / zoom_out )
python recon.py --input_video examples/flower/input.mp4 --cam 180 --output_dir outputs/flower --save_mesh
```
#### 2. EX-4D 생성 (48GB VRAM 필요)
```bash
python generate.py --color_video outputs/flower/color_180.mp4 --mask_video outputs/flower/mask_180.mp4 --output_video outputs/flower/output.mp4
```

<table>
<tr>
<td width="45%" align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/examples/flower/input.gif" width="100%">
<br><b>입력 비디오</b>
</td>
<td align="center">
<div style="font-size: 2em; color: #4A90E2; padding: 0 0px;">
  ➜
</div>
</td>
<td width="45%" align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/examples/flower/output.gif" width="100%">
<br><b>출력 비디오</b>
</td>
</tr> 
</table>

<!-- ## 📊 Performance

### Quantitative Results
| Method | FID (Extreme) ↓ | FVD (Extreme) ↓ | VBench Score ↑ |
|--------|-----------------|-----------------|----------------|
| ReCamMaster | 64.68 | 943.45 | 0.434 |
| TrajectoryCrafter | 65.33 | 893.80 | 0.447 |
| TrajectoryAttention | 62.49 | 912.14 | 0.389 |
| **EX-4D (Ours)** | **55.42** | **823.61** | **0.450** | -->

### 사용자 연구 결과

- 참가자의 **70.7%**가 EX-4D를 기존 방법보다 선호함
- 물리적 일관성과 극단적 시점 품질에서 우수한 성능
- 카메라 앵글이 더 극단적으로 변할수록 유의미한 성능 향상


## 🎯 응용 분야

- **🎮 게임**: 2D 영상에서 몰입형 3D 게임 시네마틱 생성
- **🎬 영화 제작**: 후반 제작을 위한 새로운 카메라 시점 생성
- **🥽 VR/AR**: 자유 시점 비디오 경험 제공
- **📱 소셜 미디어**: 콘텐츠 제작을 위한 동적인 카메라 무빙 생성
- **🏢 건축**: 다양한 시점에서 공간 시각화

<!-- ## 📈 Benchmarks -->

<!-- ### Viewpoint Range Evaluation

| Range | Small (0°→30°) | Large (0°→60°) | Extreme (0°→90°) | Full (-90°→90°) |
|-------|----------------|----------------|------------------|-----------------|
| FID Score | 44.19 | 50.30 | 55.42 | - |
| Performance Gap | +9.1% better | +8.9% better | +11.3% better | +15.5% better | -->

<!-- *Performance gap compared to the second-best method in each category.* -->

## ⚠️ 한계점

- **깊이 의존성**: 단안 깊이 추정 품질에 따라 성능이 좌우됨
- **연산 비용**: 고해상도 비디오 처리 시 상당한 연산 자원 필요
- **반사면**: 반사 또는 투명한 소재에서는 어려움 발생

## 🔮 향후 연구 방향
- [ ] 실시간 추론 최적화 (3DGS / 4DGS)
- [ ] 고해상도(1K, 2K) 지원
- [ ] 신경망 메시 정제 기법

## 🙏 감사의 말씀

기초적인 디퓨전 프레임워크를 제공해주신 [DiffSynth-Studio v1.1.1](https://github.com/modelscope/DiffSynth-Studio/tree/v1.1.1) 프로젝트에 감사드립니다.

## 📚 인용

본 연구가 유용하다면, 아래와 같이 인용해 주시기 바랍니다:

```bibtex
@misc{hu2025ex4dextremeviewpoint4d,
      title={EX-4D: EXtreme Viewpoint 4D Video Synthesis via Depth Watertight Mesh}, 
      author={Tao Hu and Haoyang Peng and Xiao Liu and Yuewen Ma},
      year={2025},
      eprint={2506.05554},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2506.05554}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---
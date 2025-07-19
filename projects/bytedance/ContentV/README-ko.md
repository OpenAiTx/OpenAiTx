<translate-content># ContentV: 제한된 컴퓨팅 자원으로 비디오 생성 모델의 효율적인 학습

<div align="center">
<p align="center">
  <a href="https://contentv.github.io">
    <img
      src="https://img.shields.io/badge/Gallery-Project Page-0A66C2?logo=googlechrome&logoColor=blue"
      alt="프로젝트 페이지"
    />
  </a>
  <a href='https://arxiv.org/abs/2506.05343'>
    <img
      src="https://img.shields.io/badge/Tech Report-ArXiv-red?logo=arxiv&logoColor=red"
      alt="기술 보고서"
    />
  </a>
  <a href="https://huggingface.co/ByteDance/ContentV-8B">
    <img 
        src="https://img.shields.io/badge/HuggingFace-Model-yellow?logo=huggingface&logoColor=yellow" 
        alt="모델"
    />
  </a>
  <a href="https://github.com/bytedance/ContentV">
    <img 
        src="https://img.shields.io/badge/Code-GitHub-orange?logo=github&logoColor=white" 
        alt="코드"
    />
  </a>
  <a href="https://www.apache.org/licenses/LICENSE-2.0">
    <img
      src="https://img.shields.io/badge/License-Apache 2.0-5865F2?logo=apache&logoColor=purple"
      alt="라이선스"
    />
  </a>
</p>
</div>

본 프로젝트는 *ContentV*를 소개하며, 이는 DiT 기반 비디오 생성 모델의 학습을 가속화하는 세 가지 주요 혁신을 통해 효율적인 프레임워크를 제공합니다:

- 비디오 합성을 위해 사전 학습된 이미지 생성 모델의 재사용을 극대화한 미니멀리스트 아키텍처
- 효율성을 높이기 위해 흐름 매칭을 활용한 체계적인 다단계 학습 전략
- 추가적인 인간 주석 없이 생성 품질을 향상시키는 비용 효율적인 인간 피드백 강화 학습 프레임워크

우리의 오픈소스 8B 모델(Stable Diffusion 3.5 Large 및 Wan-VAE 기반)은 256×64GB NPU 환경에서 단 4주 만에 최첨단 성능(VBench 85.14)을 달성합니다.

<div align="center">
    <img src="https://raw.githubusercontent.com/bytedance/ContentV/main/./assets/demo.jpg" width="100%">
    <img src="https://raw.githubusercontent.com/bytedance/ContentV/main/./assets/arch.jpg" width="100%">
</div>

## ⚡ 빠른 시작

#### 권장 PyTorch 버전

- GPU: torch >= 2.3.1 (CUDA >= 12.2)

#### 설치
</translate-content>
```bash
git clone https://github.com/bytedance/ContentV.git
cd ContentV
pip3 install -r requirements.txt
```
#### T2V 생성


```bash
## For GPU
python3 demo.py
```
## 📊 VBench

| 모델 | 총점 | 품질 점수 | 의미 점수 | 인간 행동 | 장면 | 동적 정도 | 다중 객체 | 출현 스타일 |
|----------------------|--------|-------|-------|-------|-------|-------|-------|-------|
| Wan2.1-14B           | 86.22  | 86.67 | 84.44 | 99.20 | 61.24 | 94.26 | 86.59 | 21.59 |
| **ContentV (Long)**  | 85.14  | 86.64 | 79.12 | 96.80 | 57.38 | 83.05 | 71.41 | 23.02 |
| Goku†                | 84.85  | 85.60 | 81.87 | 97.60 | 57.08 | 76.11 | 79.48 | 23.08 |
| Open-Sora 2.0        | 84.34  | 85.40 | 80.12 | 95.40 | 52.71 | 71.39 | 77.72 | 22.98 |
| Sora†                | 84.28  | 85.51 | 79.35 | 98.20 | 56.95 | 79.91 | 70.85 | 24.76 |
| **ContentV (Short)** | 84.11  | 86.23 | 75.61 | 89.60 | 44.02 | 79.26 | 74.58 | 21.21 |
| EasyAnimate 5.1      | 83.42  | 85.03 | 77.01 | 95.60 | 54.31 | 57.15 | 66.85 | 23.06 |
| Kling 1.6†           | 83.40  | 85.00 | 76.99 | 96.20 | 55.57 | 62.22 | 63.99 | 20.75 |
| HunyuanVideo         | 83.24  | 85.09 | 75.82 | 94.40 | 53.88 | 70.83 | 68.55 | 19.80 |
| CogVideoX-5B         | 81.61  | 82.75 | 77.04 | 99.40 | 53.20 | 70.97 | 62.11 | 24.91 |
| Pika-1.0†            | 80.69  | 82.92 | 71.77 | 86.20 | 49.83 | 47.50 | 43.08 | 22.26 |
| VideoCrafter-2.0     | 80.44  | 82.20 | 73.42 | 95.00 | 55.29 | 42.50 | 40.66 | 25.13 |
| AnimateDiff-V2       | 80.27  | 82.90 | 69.75 | 92.60 | 50.19 | 40.83 | 36.88 | 22.42 |
| OpenSora 1.2         | 79.23  | 80.71 | 73.30 | 85.80 | 42.47 | 47.22 | 58.41 | 23.89 |

## ✅ 할 일 목록
- [x] 추론 코드 및 체크포인트
- [ ] RLHF 학습 코드

## 🧾 라이선스
이 코드 저장소와 일부 모델 가중치는 [Apache 2.0 라이선스](https://www.apache.org/licenses/LICENSE-2.0) 하에 라이선스가 부여됩니다. 참고로:
- MM DiT는 [Stable Diffusion 3.5 Large](https://huggingface.co/stabilityai/stable-diffusion-3.5-large)에서 파생되었으며 비디오 샘플로 학습되었습니다. 이 Stability AI 모델은 [Stability AI 커뮤니티 라이선스](https://stability.ai/community-license-agreement) 하에 라이선스가 부여되며, 저작권 © Stability AI Ltd. 모든 권리 보유
- [Wan2.1](https://huggingface.co/Wan-AI/Wan2.1-T2V-14B)의 비디오 VAE는 [Apache 2.0 라이선스](https://huggingface.co/Wan-AI/Wan2.1-T2V-14B/blob/main/LICENSE.txt) 하에 라이선스가 부여됩니다.

## ❤️ 감사의 말
* [Stable Diffusion 3.5 Large](https://huggingface.co/stabilityai/stable-diffusion-3.5-large)
* [Wan2.1](https://github.com/Wan-Video/Wan2.1)
* [Diffusers](https://github.com/huggingface/diffusers)
* [HuggingFace](https://huggingface.co)

## 🔗 인용


```bibtex
@article{contentv2025,
  title     = {ContentV: Efficient Training of Video Generation Models with Limited Compute},
  author    = {Bytedance Douyin Content Team},
  journal   = {arXiv preprint arXiv:2506.05343},
  year      = {2025}
  }
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---
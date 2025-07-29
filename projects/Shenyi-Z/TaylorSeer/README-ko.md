<div align=center>
  
# [ICCV 2025] *TaylorSeer*: 재사용에서 예측으로: *TaylorSeers*로 확산 모델 가속화

<p>
<a href='https://arxiv.org/abs/2503.06923'><img src='https://img.shields.io/badge/Paper-arXiv-red'></a>
<a href='https://taylorseer.github.io/TaylorSeer/'><img src='https://img.shields.io/badge/Project-Page-blue'></a>
</p>

</div>

## 🔥 뉴스

* `2025/06/26` 💥💥 TaylorSeer가 ICCV 2025에 채택되어 영광입니다!

* `2025/05/03` 🚀🚀 HiDream용 TaylorSeer가 출시되었습니다.

* `2025/03/30` 🚀🚀 Wan2.1용 TaylorSeer가 출시되었습니다.

* `2025/03/30` 🚀🚀 TaylorSeers용 Diffusers 추론 스크립트와 멀티 GPU 병렬 추론에 적용 가능한 xDiT 스크립트가 공식 출시되었습니다.

* `2025/03/10` 🚀🚀 최신 연구 "재사용에서 예측으로: TaylorSeers로 확산 모델 가속화"가 발표되었습니다! 코드는 [TaylorSeer](https://github.com/Shenyi-Z/TaylorSeer)에서 확인 가능합니다! TaylorSeer는 FLUX.1-dev에서 4.99배 무손실 압축(지연 시간 3.53배 가속)과 HunyuanVideo에서 5.00배 압축률의 고품질 가속(지연 시간 4.65배 가속)을 지원합니다! *TaylorSeer*가 기능 캐싱 방법의 패러다임을 재사용에서 예측으로 전환할 수 있길 기대합니다. 자세한 내용은 최신 연구 논문을 참고해주세요.
* `2025/02/19` 🚀🚀 **FLUX**용 ToCa 솔루션이 조정 후 공식 출시되어 최대 **3.14× 무손실 가속**(FLOPs 기준)을 달성했습니다!
* `2025/01/22` 💥💥 ToCa가 ICLR 2025에 채택되어 영광입니다!
* `2024/12/29` 🚀🚀 확산 변환기 가속을 위한 연구 [DuCa](https://arxiv.org/abs/2412.18911)를 무료로 공개했습니다. OpenSora에서 거의 무손실 가속 **2.50×**를 달성했습니다! 🎉 **DuCa는 FlashAttention을 완전히 지원하여 ToCa의 한계를 극복하고 호환성과 효율성을 넓혔습니다.**
* `2024/12/24` 🤗🤗 최신 우수 토큰 축소 논문들을 모은 오픈소스 "[Awesome-Token-Reduction-for-Model-Compression](https://github.com/xuyang-liu16/Awesome-Token-Reduction-for-Model-Compression)" 저장소를 공개했습니다! 여러분의 제안도 환영합니다!
* `2024/12/10` 💥💥 우리 팀의 최신 연구 **SiTo** (https://github.com/EvelynZhang-epiclab/SiTo)가 **AAAI 2025**에 채택되었습니다. 적응형 **토큰 프루닝**을 통해 확산 모델을 가속합니다.
* `2024/07/15` 🤗🤗 최신 우수 생성 가속 논문들을 모은 오픈소스 "[Awesome-Generation-Acceleration](https://github.com/xuyang-liu16/Awesome-Generation-Acceleration)" 저장소를 공개했습니다! 여러분의 제안도 환영합니다!

<details>
  <summary><strong>초록</strong></summary>

  확산 변환기(DiT)는 고화질 이미지 및 비디오 합성을 혁신했지만, 실시간 적용에는 계산 비용이 매우 높습니다. 이를 해결하기 위해, 이전 타임스텝의 특징을 캐싱하고 이후 타임스텝에서 재사용하는 특징 캐싱 방법이 제안되었습니다. 그러나 간격이 큰 타임스텝에서는 확산 모델 내 특징 유사도가 크게 감소하여, 특징 캐싱으로 인한 오차가 크게 증가하고 생성 품질이 심각하게 저하됩니다. 이를 해결하기 위해, 우리는 미래 타임스텝의 확산 모델 특징을 이전 타임스텝 값 기반으로 예측할 수 있음을 보여주는 TaylorSeer를 제안합니다. 특징이 타임스텝 간 천천히 연속적으로 변화한다는 사실에 기반해, TaylorSeer는 미분 방법을 사용해 특징의 고차 도함수를 근사하고 Taylor 급수 전개로 미래 타임스텝의 특징을 예측합니다. 광범위한 실험에서 이미지 및 비디오 합성에서 특히 높은 가속 비율에서 뛰어난 효과를 입증했습니다. 예를 들어, 추가 훈련 없이 FLUX에서 4.99배 거의 무손실 가속, HunyuanVideo에서 5.00배 가속을 달성했습니다. DiT에서는 이전 SOTA 대비 4.53배 가속 시 $3.41$ 낮은 FID를 기록했습니다.

</details>

## 🧩 커뮤니티 기여

강력한 지원을 해주신 모든 오픈소스 기여자분들께 감사드립니다! 여러분의 의견을 기다립니다!

* ComfyUI-TaylorSeer-philipy1219 (FLUX에서 FP8 추론, 더 많은 비디오 모델 예정): [ComfyUI-TaylorSeer-philipy1219](https://github.com/philipy1219/ComfyUI-TaylorSeer) by [philipy1219](https://github.com/philipy1219).

## 🛠 설치

``` cmd
git clone https://github.com/Shenyi-Z/TaylorSeer.git
```
## TaylorSeer-FLUX

TaylorSeer는 FLUX.1-dev에서 4.99배의 무손실 연산 압축과 3.53배의 지연 시간 속도 향상을 달성했으며, 이는 종합 품질 평가를 위한 [ImageReward](https://github.com/THUDM/ImageReward)에 의해 측정되었습니다. TaylorSeer-FLUX 실행 방법은 [TaylorSeer-FLUX](https://raw.githubusercontent.com/Shenyi-Z/TaylorSeer/main/TaylorSeer-FLUX.md)를 참조하세요.

또한, **diffusers 버전**에 대한 추론 스크립트 예제와 다중 GPU 병렬 **xDiT 추론 스크립트**도 제공하고 있습니다. 각각 [TaylorSeers-Diffusers](./TaylorSeers-Diffusers)와 [TaylorSeers-xDiT](./TaylorSeers-xDiT)에서 기반으로 테스트를 진행할 수 있습니다.

## TaylorSeer-HunyuanVideo

TaylorSeer는 HunyuanVideo에서 5.00배의 연산 압축과 4.65배의 놀라운 지연 시간 속도 향상을 달성했으며, 이는 [VBench](https://github.com/Vchitect/VBench) 지표로 종합 평가되었습니다. 기존 방법들과 비교하여 가속 효율과 품질 모두에서 크게 향상된 결과를 보여주었습니다. TaylorSeer-HunyuanVideo 실행 방법은 [TaylorSeer-HunyuanVideo](https://raw.githubusercontent.com/Shenyi-Z/TaylorSeer/main/TaylorSeer-HunyuanVideo.md)를 참조하세요.

추가로, 당사의 스크립트는 HunyuanVideo가 xDiT를 이용해 구현한 다중 GPU 병렬 가속도 지원합니다. 이 경우, 캐시로 인한 가속 효과와 다중 GPU 병렬 가속 효과는 서로 독립적이며 곱해져 매우 높은 가속 효과를 달성합니다.

## TayorSeer-DiT

TaylorSeer는 기본 모델 DiT에서 2.77배의 무손실 연산 압축을 달성했으며, FID 등 다양한 지표로 종합 평가되었습니다. 여러 가속 비율에서의 성능이 기존 방법들을 크게 능가했습니다. 예를 들어, 4.53배 압축이라는 극한 상황에서 TaylorSeer의 FID는 비가속 기준 2.32에서 0.33만 증가한 2.65를 기록한 반면, ToCa와 DuCa는 동일 조건에서 FID가 6.0 이상을 기록했습니다. TaylorSeer-DiT 실행 방법은 [TaylorSeer-DiT](https://raw.githubusercontent.com/Shenyi-Z/TaylorSeer/main/TaylorSeer-DiT.md)를 참조하세요.

## TaylorSeer-Wan2.1

TaylorSeer 가속 방법을 Wan2.1에 구현했으며, 다중 GPU 병렬 추론을 지원합니다. TaylorSeer-Wan2.1의 설치 및 추론 명령어는 Wan2.1과 완전히 호환됩니다. TaylorSeer-Wan2.1 실행 방법은 [TaylorSeer-Wan2.1](https://raw.githubusercontent.com/Shenyi-Z/TaylorSeer/main/TaylorSeer-Wan2.1.md)를 참조하세요.

## TaylorSeer-HiDream

최근 오픈소스된 이미지 생성 모델 **HiDream**은 뛰어난 출력 품질에도 불구하고 긴 추론 시간으로 인해 가속 요구가 증가하고 있습니다. 우리는 **TaylorSeer**를 적용해 HiDream 추론을 가속화하여 **72%의 실행 시간 감소**를 달성했습니다. 자세한 내용은 [TaylorSeer-HiDream](https://raw.githubusercontent.com/Shenyi-Z/TaylorSeer/main/TaylorSeer-HiDream.md)를 참조하세요.

## 👍 감사의 글

- TaylorSeer-DiT를 구축하는 데 기반이 된 훌륭한 작업과 코드베이스를 제공한 [DiT](https://github.com/facebookresearch/DiT) 팀에 감사드립니다.
- TaylorSeer-FLUX를 구축하는 데 기반이 된 훌륭한 작업과 코드베이스를 제공한 [FLUX](https://github.com/black-forest-labs/flux) 팀에 감사드립니다.
- TaylorSeer-HiDream를 구축하는 데 기반이 된 훌륭한 작업과 코드베이스를 제공한 [HiDream](https://github.com/HiDream-ai/HiDream-I1) 팀에 감사드립니다.
- TaylorSeer-HunyuanVideo를 구축하는 데 기반이 된 훌륭한 작업과 코드베이스를 제공한 [HunyuanVideo](https://github.com/Tencent/HunyuanVideo) 팀에 감사드립니다.
- TaylorSeer-Wan2.1을 구축하는 데 기반이 된 훌륭한 작업과 코드베이스를 제공한 [Wan2.1](https://github.com/Wan-Video/Wan2.1) 팀에 감사드립니다.
- 텍스트-투-이미지 품질 평가를 위한 [ImageReward](https://github.com/THUDM/ImageReward)에 감사드립니다.
- 텍스트-투-비디오 품질 평가를 위한 [VBench](https://github.com/Vchitect/VBench)에 감사드립니다.


## 📌 인용문헌



```bibtex
@article{TaylorSeer2025,
  title={From Reusing to Forecasting: Accelerating Diffusion Models with TaylorSeers},
  author={Liu, Jiacheng and Zou, Chang and Lyu, Yuanhuiyi and Chen, Junjie and Zhang, Linfeng},
  journal={arXiv preprint arXiv:2503.06923},
  year={2025}
}
```

## :e-mail: 연락처

질문이 있으시면, [`shenyizou@outlook.com`](https://raw.githubusercontent.com/Shenyi-Z/TaylorSeer/main/mailto:shenyizou@outlook.com)으로 이메일을 보내주세요.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---
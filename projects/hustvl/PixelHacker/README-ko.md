<div align="center">
    <img src="https://raw.githubusercontent.com/hustvl/PixelHacker/main/./assets/LOGO.png" width="280px"></img>
</div>
<div align="center">
    <img src="https://raw.githubusercontent.com/hustvl/PixelHacker/main/./assets/Typing_re.gif" width="320px"></img>
</div>

<div align="center">
<h2>PixelHacker: 구조적 및 의미론적 일관성을 갖춘 이미지 복원</h2>

**_Places2, CelebA-HQ, FFHQ에서 최첨단 성능 및 우수한 구조적·의미론적 일관성_**

[Ziyang Xu](https://ziyangxu.top)<sup>1</sup>, [Kangsheng Duan](https://github.com/AnduinD)<sup>1</sup>, Xiaolei Shen<sup>2</sup>, Zhifeng Ding<sup>2</sup>, [Wenyu Liu](http://eic.hust.edu.cn/professor/liuwenyu)<sup>1</sup>, Xiaohu Ruan<sup>2</sup>,  
[Xiaoxin Chen](https://scholar.google.com/citations?hl=zh-CN&user=SI_oBwsAAAAJ)<sup>2</sup>, [Xinggang Wang](https://xwcv.github.io)<sup>1 :email:</sup>

(<sup>:email:</sup>) 교신저자.

<sup>1</sup> 화중과학기술대학교. <sup>2</sup> VIVO AI 연구소.  

[![arxiv](https://img.shields.io/badge/Paper-arXiv-orange)](https://arxiv.org/abs/2504.20438) [![license](https://img.shields.io/badge/License-Apache_2.0-blue)](LICENSE) [![Project](https://img.shields.io/badge/Project-https://hustvl.github.io/PixelHacker-purple)](https://hustvl.github.io/PixelHacker) [![Demo](https://img.shields.io/badge/Demo-Comming_Soon-b687f8)]()
</div>

<img src="https://raw.githubusercontent.com/hustvl/PixelHacker/main/./assets/Pipeline.png"></img>

## 🌟하이라이트
* **잠재 카테고리 가이드(Latent Categories Guidance, LCG)**: 간단하면서도 효과적인 복원 패러다임으로 뛰어난 구조적 및 의미론적 일관성을 제공합니다. 더 복잡한 시나리오에 도전하는 복원 연구를 발전시켜 봅시다!
* **PixelHacker**: LCG로 훈련된 확산 기반 복원 모델로, 다양한 자연 장면(Places2)과 인물 얼굴(CelebA-HQ, FFHQ) 벤치마크에서 최첨단 성능을 뛰어넘습니다!
* **종합적인 최첨단 성능**：
    * **Places2** (자연 장면)
        * 512 해상도에서 40-50% 마스크 영역이 있는 10k 테스트 이미지로 평가 시, PixelHacker는 **FID 8.59** 및 **LPIPS 0.2026**으로 최고의 성능을 기록했습니다.
        * 512 해상도에서 크고 작은 마스크 설정이 있는 36.5k 검증 이미지로 평가 시, PixelHacker는 **FID (대형: 2.05, 소형: 0.82)** 및 **U-IDS (대형:36.07, 소형:42.21)**에서 최고 성능을, **LPIPS (대형:0.169, 소형:0.088)**에서 두 번째로 좋은 성능을 달성했습니다.
        * 매우 무작위화된 마스킹 전략을 적용한 검증 이미지에서 256 및 512 해상도로 평가 시, PixelHacker는 512 해상도에서 **FID 5.75 및 LPIPS 0.305**로 최고 성능을, 256 해상도에서 **FID 9.25 및 LPIPS 0.367**로 두 번째로 좋은 성능을 기록했습니다.
    * **CelebA-HQ** (인물 얼굴 장면)
        * 512 해상도에서 평가 시, PixelHacker는 **FID 4.75 및 LPIPS 0.115**로 최고 성능을 달성했습니다.
    * **FFHQ** (인물 얼굴 장면)
        * 256 해상도에서 평가 시, PixelHacker는 **FID 6.35 및 LPIPS 0.229**로 최고 성능을 기록했습니다.

## 🔥업데이트

* **`2025년 5월 20일`**: 🔥 [코드](https://github.com/hustvl/PixelHacker)와 [가중치](https://huggingface.co/hustvl/PixelHacker/tree/main)를 공개했습니다. 가중치에는 사전 훈련된 모델과 모든 미세 조정 버전이 포함되어 있으며, 각각 0.8B 파라미터만 차지합니다. 자유롭게 사용하세요!
* **`2025년 5월 1일`**: 🔥 자연 및 인물 얼굴 장면에 대한 63개 이상의 데모를 포함한 [프로젝트 페이지](https://hustvl.github.io/PixelHacker)를 공개했습니다. 즐기세요! 🤗
* **`2025년 4월 30일`:** 🔥 PixelHacker의 [arXiv 논문](https://arxiv.org/abs/2504.20438)을 공개했습니다. 코드와 프로젝트 페이지는 곧 공개될 예정입니다.

## 🏕️자연 장면에서의 성능

<div align="center">
<img src="https://raw.githubusercontent.com/hustvl/PixelHacker/main/./assets/Demo1.gif" width="360px"></img>
</div>

<img src="https://raw.githubusercontent.com/hustvl/PixelHacker/main/./assets/Cover.png"></img>

<img src="https://raw.githubusercontent.com/hustvl/PixelHacker/main/./assets/Natural-Scene.png"></img>

## 🤗인물 얼굴 장면에서의 성능
<div align="center">
<img src="https://raw.githubusercontent.com/hustvl/PixelHacker/main/./assets/Demo2.gif" width="360px"></img>
</div>

<img src="https://raw.githubusercontent.com/hustvl/PixelHacker/main/./assets/Human-Face.png"></img>

## 📦환경 설정
* torch 2.3.0
* transformers 4.40.0
* diffusers 0.30.2
* 필요한 파이썬 라이브러리는 'requirements.txt' 참조

```shell
conda create -n pixelhacker python=3.10
conda activate pixelhacker
# cd /xx/xx/PixelHacker
pip install -r requirements.txt
```
## 🗃️모델 체크포인트  
* [VAE](https://huggingface.co/hustvl/PixelHacker/tree/main/vae) 체크포인트를 다운로드하여 ../PixelHacker/vae에 넣으세요.  

* [사전학습 버전](https://huggingface.co/hustvl/PixelHacker/tree/main/pretrained), [미세조정 버전 (places2)](https://huggingface.co/hustvl/PixelHacker/tree/main/ft_places2), [미세조정 버전 (celeba-hq)](https://huggingface.co/hustvl/PixelHacker/tree/main/ft_celebahq), [미세조정 버전 (ffhq)](https://huggingface.co/hustvl/PixelHacker/tree/main/ft_ffhq) 체크포인트를 다운로드하여 ../PixelHacker/weight에 넣으세요.  

* 최종적으로, 상세한 조직 형태는 다음과 같습니다:

```shell
├── PixelHacker
│    ├── weight
│        ├── pretrained
│            ├── diffusion_pytorch_model.bin
│        ├── ft_places2
│            ├── diffusion_pytorch_model.bin
│        ├── ft_celebahq
│            ├── diffusion_pytorch_model.bin
│        ├── ft_ffhq
│            ├── diffusion_pytorch_model.bin
│    ├── vae
│        ├── config.json
│        ├── diffusion_pytorch_model.bin
│    ├── ...
```
## 🔮추론  
다음 코드를 직접 실행하여 예제 이미지-마스크 쌍의 인페인팅 결과를 얻을 수 있으며, 결과는 ../PixelHacker/outputs에 생성됩니다.  
사용자 지정 데이터에 대해 추론하려면 이미지와 마스크를 동일한 이름으로 각각 ../PixelHacker/imgs 및 ../PixelHacker/masks에 배치한 다음, 아래 코드를 실행하면 됩니다.
```shell
python infer_pixelhacker.py \
--config config/PixelHacker_sdvae_f8d4.yaml \
--weight weight/ft_places/diffusion_pytorch_model.bin
```


## 🎓Citation

```shell
@misc{xu2025pixelhacker,
      title={PixelHacker: Image Inpainting with Structural and Semantic Consistency}, 
      author={Ziyang Xu and Kangsheng Duan and Xiaolei Shen and Zhifeng Ding and Wenyu Liu and Xiaohu Ruan and Xiaoxin Chen and Xinggang Wang},
      year={2025},
      eprint={2504.20438},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2504.20438}, 
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---
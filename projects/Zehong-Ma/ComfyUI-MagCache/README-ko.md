<translate-content># ComfyUI-MagCache

## 🫖 소개  
Magnitude-aware Cache (MagCache)는 학습이 필요 없는 캐싱 방식입니다. 강력한 **크기 관찰(magnitude observations)**을 기반으로 시간 단계별로 모델 출력 사이의 변동 차이를 추정하여, 오류 모델링 메커니즘과 적응형 캐시 전략을 사용해 추론 속도를 가속화합니다. MagCache는 비디오 확산 모델(Video Diffusion Models)과 이미지 확산 모델(Image Diffusion models)에 적합합니다. 자세한 내용과 결과는 저희 [프로젝트 페이지](https://zehong-ma.github.io/MagCache)와 [코드](https://github.com/Zehong-Ma/MagCache)를 참고하세요.

MagCache는 현재 ComfyUI에 통합되어 있으며 ComfyUI 기본 노드와 호환됩니다. ComfyUI-MagCache는 사용이 간편하며, MagCache 노드를 ComfyUI 기본 노드와 연결하여 원활하게 사용할 수 있습니다.

## 🔥 최신 소식  
- **프로젝트가 마음에 드신다면 최신 업데이트를 위해 GitHub에서 별 ⭐을 눌러주세요.**
- [2025/6/30] 🔥 [Flux-Kontext](https://huggingface.co/black-forest-labs/FLUX.1-Kontext-dev)를 2배 속도로 지원합니다. 데모는 [여기](https://github.com/user-attachments/assets/79d5f654-5828-442d-b1a1-9b754c17e457)를 참조하세요.
- [2025/6/19] 🔥 [FramePack](https://github.com/lllyasviel/FramePack)을 [MagCache-FramePack](https://github.com/Zehong-Ma/MagCache)에서 Gradio 데모와 함께 지원합니다.
- [2025/6/18] 👉 커뮤니티로부터 최적의 파라미터 설정을 수집 중입니다. <br>     👉**설정을 공유하려면 이 [토론 이슈](https://github.com/Zehong-Ma/ComfyUI-MagCache/issues/15)를 열어주세요!**
- [2025/6/17] 🔥 [Wan2.1-VACE-1.3B](https://github.com/ali-vilab/VACE)를 지원하며 1.7× 가속을 달성했습니다. 
- [2025/6/17] 🔥 MagCache는 [ComfyUI-WanVideoWrapper](https://github.com/kijai/ComfyUI-WanVideoWrapper)에서 지원됩니다. 감사드립니다 @[kijai](https://github.com/kijai). 
- [2025/6/16] 🔥 [Chroma](https://huggingface.co/lodestones/Chroma)를 지원합니다. 코드베이스 제공에 감사드립니다 @[kabachuha](https://github.com/kabachuha).
- [2025/6/10] 🔥 [Wan2.1](https://github.com/Wan-Video/Wan2.1) T2V&I2V, [HunyuanVideo](https://github.com/Tencent/HunyuanVideo) T2V, [FLUX-dev]((https://github.com/black-forest-labs/flux)) T2I 지원

## 설치  
<!-- ComfyUI-Manager를 통한 설치가 권장됩니다. 노드 목록에서 ComfyUI-MagCache를 검색한 후 설치를 클릭하세요.
### 수동 설치 -->
1. comfyUI custom_nodes 폴더로 이동, `ComfyUI/custom_nodes/`
2. git clone https://github.com/zehong-ma/ComfyUI-MagCache.git
3. ComfyUI-MagCache 폴더로 이동, `cd ComfyUI-MagCache/`
4. pip install -r requirements.txt
5. 프로젝트 폴더 `ComfyUI/`로 이동 후 `python main.py` 실행
## 사용법

### 모델 가중치 다운로드  
먼저 다음 링크를 참고하여 ComfyUI 형식의 모델 가중치를 준비하세요:  
- [Wan2.1](https://comfyanonymous.github.io/ComfyUI_examples/wan/)
- [HunyuanVideo](https://comfyanonymous.github.io/ComfyUI_examples/hunyuan_video/)
- [FLUX](https://comfyanonymous.github.io/ComfyUI_examples/flux/)
- [Chroma](https://huggingface.co/lodestones/Chroma)

### MagCache

**커뮤니티로부터 최적의 파라미터 설정을 수집 중입니다. 설정을 공유하려면 이 [토론 이슈](https://github.com/Zehong-Ma/ComfyUI-MagCache/issues/15)를 열어주세요!**

MagCache 노드를 사용하려면 `Load Diffusion Model` 노드 또는 `Load LoRA` 노드(LoRA가 필요한 경우) 이후에 `MagCache` 노드를 워크플로우에 추가하면 됩니다. 일반적으로 MagCache는 시각적 품질 손실을 허용 가능한 범위 내에서 2배에서 3배의 속도 향상을 달성할 수 있습니다. 아래 표는 다양한 모델에 권장되는 magcache_thresh, retention_ratio, magcache_K 값을 보여줍니다:

<div align="center">

| 모델                         |   magcache_thresh |   retention_ratio |    magcache_K     |  
|:----------------------------:|:-----------------:|:-----------------:|:-----------------:|
| FLUX                         |        0.24       |         0.1       |         5         |
| FLUX-Kontext                 |        0.05       |         0.2       |         4         |
| Chroma                       |        0.10       |         0.25      |         2         |
| HunyuanVideo-T2V             |        0.24       |         0.2       |         6         |
| Wan2.1-T2V-1.3B              |        0.12       |         0.2       |         4         |
| Wan2.1-T2V-14B               |        0.24       |         0.2       |         6         |
| Wan2.1-I2V-480P-14B          |        0.24       |         0.2       |         6         |
| Wan2.1-I2V-720P-14B          |        0.24       |         0.2       |         6         |
| Wan2.1-VACE-1.3B             |        0.02       |         0.2       |         3         |

</div>

**MagCache 적용 후 이미지/비디오 품질이 낮다면 `magcache_thresh`와 `magcache_K`를 낮춰보세요.** 기본 파라미터는 매우 빠른 추론(2배-3배)을 위해 설정되어 일부 경우에는 실패할 수 있습니다.

데모 워크플로우([flux](https://raw.githubusercontent.com/Zehong-Ma/ComfyUI-MagCache/main/./examples/flux.json), [flux-kontext](https://raw.githubusercontent.com/Zehong-Ma/ComfyUI-MagCache/main/./examples/flux_1_kontext_dev.json), [chroma](https://raw.githubusercontent.com/Zehong-Ma/ComfyUI-MagCache/main/./examples/chroma.json), [hunyuanvideo](https://raw.githubusercontent.com/Zehong-Ma/ComfyUI-MagCache/main/./examples/hunyuanvideo.json), [wan2.1_t2v](https://raw.githubusercontent.com/Zehong-Ma/ComfyUI-MagCache/main/./examples/wan2.1_t2v.json), [wan2.1_i2v](https://raw.githubusercontent.com/Zehong-Ma/ComfyUI-MagCache/main/./examples/wan2.1_i2v.json), [wan2.1_vace](https://raw.githubusercontent.com/Zehong-Ma/ComfyUI-MagCache/main/./examples/wan2.1_vace.json))는 examples 폴더에 위치합니다. 워크플로우 [chroma_calibration](https://raw.githubusercontent.com/Zehong-Ma/ComfyUI-MagCache/main/./examples/chroma_calibration.json)은 사전 정의된 추론 스텝 수와 다를 때 `Chroma`의 `mag_ratios`를 보정하는 데 사용됩니다.  
**실험 결과, Wan2.1이 생성한 비디오는 [원본 비양자화 버전](https://github.com/Wan-Video/Wan2.1)이 생성한 것만큼 고품질이 아닙니다.**

### 컴파일 모델  
`Compile Model` 노드를 사용하려면 `Load Diffusion Model` 노드 또는 `MagCache` 노드 이후에 `Compile Model` 노드를 워크플로우에 추가하세요. Compile Model은 `torch.compile`을 사용하여 모델을 더 효율적인 중간 표현(IR)으로 컴파일함으로써 성능을 향상시킵니다. 이 컴파일 과정은 백엔드 컴파일러를 활용해 최적화된 코드를 생성하며, 추론 속도를 크게 높일 수 있습니다. 워크플로우를 처음 실행할 때 컴파일에 시간이 걸리지만, 일단 완료되면 추론은 매우 빠릅니다.  
<!-- 사용법은 아래와 같습니다: -->
<!-- ![](https://raw.githubusercontent.com/Zehong-Ma/ComfyUI-MagCache/main/./assets/compile.png) -->

## 감사의 말  
[ComfyUI-TeaCache](https://github.com/welltop-cn/ComfyUI-TeaCache), [ComfyUI](https://github.com/comfyanonymous/ComfyUI), [ComfyUI-MagCache](https://github.com/wildminder/ComfyUI-MagCache), [MagCache](https://github.com/Zehong-Ma/MagCache/), [TeaCache](https://github.com/ali-vilab/TeaCache), [HunyuanVideo](https://github.com/Tencent/HunyuanVideo), [FLUX](https://github.com/black-forest-labs/flux), [Chroma](https://huggingface.co/lodestones/Chroma), 그리고 [Wan2.1](https://github.com/Wan-Video/Wan2.1)에게 감사드립니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---
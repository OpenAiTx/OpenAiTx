# DreamO Comfyui
[DreamO](https://github.com/bytedance/DreamO) ComfyUI 네이티브 구현체입니다.

[![arXiv](https://img.shields.io/badge/arXiv-Paper-<COLOR>.svg)](https://arxiv.org/abs/2504.16915) [![demo](https://img.shields.io/badge/🤗-HuggingFace_Demo-orange)](https://huggingface.co/spaces/ByteDance/DreamO) <br>

<img width="1485" alt="Image" src="https://github.com/user-attachments/assets/0954b0bf-63db-463f-ae25-9cd983b462db" />


> [!Important]  
> **2025.06.24** - 이미지 품질 향상, 신체 구성 오류 가능성 감소, 미적 요소 강화와 함께 **DreamO v1.1**을 기쁜 마음으로 출시합니다. [이 모델에 대해 더 알아보기](https://github.com/bytedance/DreamO/blob/main/dreamo_v1.1.md)


## 설치
이 구현체는 2025.5.19 버전의 ComfyUI(e930a38 커밋 ID)를 기반으로 합니다. 이전 버전을 사용 중이라면 호환성 문제가 발생할 수 있습니다.
```shell
# manual install
cd custom_nodes
git clone https://github.com/ToTheBeginning/ComfyUI-DreamO.git
# Please make sure that you have installed the forked version of facexlib, not the original facexlib. Otherwise, you may encounter face parsing errors.
pip install -r requirements.txt
# restart comfyui
```
## 모델
### FLUX 모델
기계에 이미 FLUX 모델이 다운로드되어 있다면 이 단계를 건너뛸 수 있습니다.
- 원본 bf16 모델: [dit](https://huggingface.co/black-forest-labs/FLUX.1-dev/blob/main/flux1-dev.safetensors), [t5](https://huggingface.co/comfyanonymous/flux_text_encoders/blob/main/t5xxl_fp16.safetensors)
- 8 비트 FP8: [dit](https://huggingface.co/Comfy-Org/flux1-dev/blob/main/flux1-dev-fp8.safetensors), [t5](https://huggingface.co/comfyanonymous/flux_text_encoders/blob/main/t5xxl_fp8_e4m3fn.safetensors)
- Clip 및 VAE (모든 모델용): [clip](https://huggingface.co/comfyanonymous/flux_text_encoders/blob/main/clip_l.safetensors), [vae](https://huggingface.co/black-forest-labs/FLUX.1-schnell/blob/main/ae.safetensors)

### DreamO 모델
- https://huggingface.co/ByteDance/DreamO/tree/main/comfyui 에서 `.safetensors`로 끝나는 모든 파일을 다운로드하여 `ComfyUI/models/loras`에 저장하세요.
- 🔥🔥**v1.1**: https://huggingface.co/ByteDance/DreamO/tree/main/v1.1 에서 `.safetensors`로 끝나는 모든 파일을 다운로드하여 `ComfyUI/models/loras`에 저장하세요.
- (자동 다운로드 지원) [dreamo-embedding](https://huggingface.co/ByteDance/DreamO/blob/main/embedding.safetensors)를 다운로드하여 `ComfyUI/models/dreamo`에 저장하세요.
- (자동 다운로드 지원) [ben2](https://huggingface.co/PramaLLC/BEN2/blob/main/model.safetensors)를 다운로드하여 `ComfyUI/models/dreamo`에 저장하세요.
- [flux-turbo](https://huggingface.co/alimama-creative/FLUX.1-Turbo-Alpha/blob/main/diffusion_pytorch_model.safetensors)를 다운로드하여 `ComfyUI/models/loras`에 저장하고 이름을 `flux-turbo.safetensors`로 변경하세요.

## 워크플로우
[workflows](workflows) 폴더에서 워크플로우를 확인하세요. [이 v1.1 워크플로우](https://raw.githubusercontent.com/ToTheBeginning/ComfyUI-DreamO/main/workflows/dreamo_comfyui_v1.1.json)가 최신 버전입니다.

v1.1 모델은 [Super-Realism LoRA](https://huggingface.co/strangerzonehf/Flux-Super-Realism-LoRA)와 결합하면 리얼리즘을 더욱 향상시킬 수 있습니다. 하지만 리얼리즘 중심의 LoRA이므로 스타일 전송에 영향을 줄 수 있습니다. 필요에 따라 사용하세요.

## 노드
- DreamOProcessorLoader
  - 이 노드는 두 개의 이미지 전처리 모델을 로드합니다: 배경 제거용 BEN2 모델과 정렬된 얼굴 검출용 facexlib 모델입니다.
- DreamORefEncode
  - 이 노드는 선택한 작업 유형에 따라 참조 이미지를 잠재 표현으로 인코딩합니다. 세 가지 작업 유형이 있습니다: ip, id, style.
    - ip: 참조 이미지의 배경을 제거합니다.
    - id: 참조 이미지에서 얼굴을 정렬하고 자릅니다. PuLID와 유사합니다.
    - style: 참조 이미지의 배경을 유지합니다. 스타일 전송 작업을 활성화하려면 트리거 메타 프롬프트가 필요합니다.
- ApplyDreamO
  - 이 노드는 Flux 모델에 훅을 추가하여 참조 잠재값과 노이즈 잠재값을 연결할 수 있도록 지원합니다.

## 주의사항
- 현재 코드는 진정한 CFG 로직을 구현하지 않았으므로 샘플러 노드에서 cfg=1로 설정해야 합니다.
- 앞서 언급했듯이, 저희는 ComfyUI에 익숙하지 않습니다. 더 나은 워크플로우나 제안이 있다면 알려주세요.

기여를 환영합니다!

    
## 감사의 말
ComfyUI 플러그인의 구현은 [ComfyUI_PuLID_Flux_ll](https://github.com/lldacing/ComfyUI_PuLID_Flux_ll)를 참고했습니다.

## 향후 계획
✅ 기본 저장소 [DreamO](https://github.com/bytedance/DreamO)를 팔로우해 주세요 — 향후 몇 주 내에 모델 업데이트를 릴리스할 예정입니다.

## :e-mail: 연락처
의견이나 질문이 있으면 [새 이슈 열기](https://github.com/xxx/xxx/issues/new/choose) 또는 [Yanze Wu](https://tothebeginning.github.io/)와 [Chong Mou](https://raw.githubusercontent.com/ToTheBeginning/ComfyUI-DreamO/main/mailto:eechongm@gmail.com)에게 연락하세요.





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---
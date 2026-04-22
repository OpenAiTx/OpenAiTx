수정: 이 저장소는 모델로 좋은(충분한) 결과를 생성하지 못해 아카이브되었습니다. 당분간 LTX2.3을 사용할 예정입니다.  
계속 작업하셔도 좋습니다.  

수정: 주의! 아직 진행 중인 작업이며 작동을 기대하지 마세요.  
부활절 휴가로 자리를 비워 돌아오기 전까지는 볼 시간이 없습니다.  
포크하여 작업을 이어가거나 Kijai가 자신의 버전을 출시할 때까지 기다리셔도 됩니다.  

코드는 (현재는, 나중에 변경 예정) 필요한 텍스트 인코더와 wan vae를 huggingface에서 자동으로 다운로드합니다.  
첫 실행 시 시간이 좀 걸릴 수 있습니다.  

# ComfyUI-DaVinci-MagiHuman  

[daVinci-MagiHuman](https://huggingface.co/GAIR/daVinci-MagiHuman)를 위한 ComfyUI 커스텀 노드입니다. 15B 파라미터 단일 스트림 트랜스포머로 빠른 오디오-비디오 생성에 최적화되어 있습니다. 소비자용 GPU(RTX 5090 32GB)에 최적화되어 있습니다.  

## 기능  

- **블록 단위 CPU/GPU 스와핑** — 40개 트랜스포머 레이어 중 8개만 GPU에서 실행(~6GB vs ~30GB)  
- **비동기 CUDA 프리페칭** — 현재 블록 계산 중 다음 블록 전송  
- **디스틸 모드** — CFG 없이 8단계 생성(가장 빠름)  
- **1080p 슈퍼 해상도** — 256p 베이스의 잠재 공간 업스케일링  
- **TurboVAE 디코더** — 출력 오프로드와 함께 슬라이딩 윈도우 디코딩(1080p)  
- **오디오 + 비디오** — 단일 스트림 공동 생성  

## 노드  

| 노드 | 설명 |  
|------|-------------|  
| **DaVinci 모델 로더** | 구성 가능한 `blocks_on_gpu`로 디스틸/베이스/SR 모델 로드 |  
| **DaVinci TurboVAE 로더** | 빠른 디코드 전용 VAE 로드 |  
| **DaVinci 텍스트 인코더** | 텍스트 프롬프트를 임베딩으로 변환 (외부 T5 인코더 사용 가능) |  
| **DaVinci 샘플러** | 디노이징 루프 (8단계 디스틸 / 32단계 베이스) |  
| **DaVinci 슈퍼 해상도** | 256p 잠재공간을 SR 모델로 1080p 업스케일 |  
| **DaVinci 디코드** | TurboVAE 잠재공간을 비디오로 변환하며 출력 오프로드 수행 |  
| **DaVinci 비디오 출력** | FFmpeg를 통한 mp4/webm 저장 |  

## 작업 흐름  

```
Model Loader (distill, 8 blocks on GPU)
  → Text Encode
    → Sampler (256p, 8 steps)
      → [optional] SR Model Loader (1080p_sr) → Super Resolution
        → TurboVAE Loader → Decode → Video Output
```
## 요구 사항

- **GPU**: RTX 5090 (32GB) 이상. 32GB VRAM에서 GPU 8블록 작동 가능.
- **RAM**: 64GB 이상 권장 (CPU 오프로딩 시 모델 가중치 약 24GB가 시스템 RAM에 저장됨)
- **CUDA**: bf16 지원 CUDA 가능 GPU
- **FFmpeg**: 비디오 출력에 필요
- **Python 패키지**: `safetensors`, `torch`, `numpy`

## 모델 설정

[HuggingFace](https://huggingface.co/GAIR/daVinci-MagiHuman)에서 모델 가중치를 다운로드하세요:


```bash
cd ComfyUI/models

# Clone without large files
GIT_LFS_SKIP_SMUDGE=1 git clone https://huggingface.co/GAIR/daVinci-MagiHuman

cd daVinci-MagiHuman

# Pull only what you need (skip 540p_sr if you only want 1080p)
git lfs pull --include="distill/*,turbo_vae/*"        # ~61GB - base generation
git lfs pull --include="1080p_sr/*"                    # ~61GB - 1080p upscaling
```
예상 디렉터리 구조:

```
ComfyUI/models/daVinci-MagiHuman/
├── distill/          # 8-step distilled model (~61GB)
├── 1080p_sr/         # Super-resolution model (~61GB)
├── turbo_vae/        # Fast decoder (small)
├── base/             # Full 32-step model (optional, ~30GB)
└── 540p_sr/          # 540p SR (optional, ~61GB)
```
## VRAM 가이드

| `blocks_on_gpu` | VRAM 사용량 | 속도 | 권장 대상 |
|-----------------|-----------|-------|-----------------|
| 4 | 약 3GB + 오버헤드 | 가장 느림 | 16GB GPU |
| 8 | 약 6GB + 오버헤드 | 양호 | 24-32GB GPU |
| 16 | 약 12GB + 오버헤드 | 빠름 | 48GB GPU |
| 40 | 약 30GB | 가장 빠름 | 80GB 이상 GPU |

## 텍스트 인코더

daVinci-MagiHuman은 T5Gemma-9B를 텍스트 인코더로 사용합니다. **DaVinci Text Encode** 노드는 현재 다음을 제공합니다:

- 파이프라인 테스트용 **플레이스홀더 임베딩** (무작위 노이즈 — 의미 있는 출력 생성 불가)
- **외부 T5 입력** — 다른 인코더 노드에서 미리 계산된 T5 임베딩(3584 차원) 연결 가능

실제 사용 시에는 T5-XXL 또는 T5Gemma 인코더 노드를 `t5_embeds` 입력에 연결하세요.

## 아키텍처

모델은 비디오와 오디오를 함께 생성하는 단일 스트림 트랜스포머입니다:

- **150억 파라미터**, 40개 트랜스포머 레이어
- **히든 크기**: 5120, **GQA**: 40 쿼리 / 8 KV 헤드, **헤드 차원**: 128
- **샌드위치 레이어**: 0-3 및 36-39 레이어는 모달리티별 노름(비디오/오디오/텍스트) 적용
- **공유 레이어**: 4-35 레이어는 통합 처리 사용
- **타임스텝 프리**: 명시적 타임스텝 임베딩 없음 — 입력에서 노이즈 제거 상태 추론
- **헤드별 게이팅**: 각 어텐션 헤드에 학습된 시그모이드 게이트 적용

## 크레딧

- [daVinci-MagiHuman](https://huggingface.co/GAIR/daVinci-MagiHuman) by SII-GAIR & Sand.ai
- 연산자 융합을 위한 [MagiCompiler](https://github.com/SandAI-org/MagiCompiler)
- Wan2.2 및 TurboVAED 기반 구축

## 라이선스

Apache 2.0



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-22

---
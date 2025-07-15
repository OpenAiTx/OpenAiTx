# Qwen3 MoE 퓨즈드

HF Transformers의 Qwen3 MoE 모델(및 모든 다른 MoE 모델)은 전문가에 접근하기 위해 [for 루프](https://github.com/huggingface/transformers/blob/bdf5fb70aa11782cce22027d76879f71f4e41c1e/src/transformers/models/qwen3_moe/modular_qwen3_moe.py#L103)를 사용하기 때문에 매우 느립니다. 이 저장소의 목적은 24GB VRAM을 가진 단일 GPU에서 Qwen3-30B-A3B를 미세 조정하고 높은 처리량을 달성하는 것입니다. 구현은 LoRA, bitsandbytes 4비트 양자화, Unsloth 등 HF Transformers 생태계와 호환됩니다. 사용법은 [`example_train_30b_a3b_unsloth.py`](https://github.com/woct0rdho/transformers-qwen3-moe-fused/blob/master/example_train_30b_a3b_unsloth.py)를 참조하세요.

## 퓨즈드 선형 계층

핵심 부분은 [`moe_fused_linear`](https://github.com/woct0rdho/transformers-qwen3-moe-fused/blob/master/qwen3_moe_fused/functional.py) 함수를 구현하는 것입니다:
```
output[b, o] = sum_i weight[selected_experts[b], o, i] * input[b, i]
```
이미 [triton-kernels](https://github.com/triton-lang/triton/blob/dd1c3d429d1c24904722ac699ea5750bc694c4d6/python/triton_kernels/triton_kernels/matmul_ogs.py), [llama.cpp](https://github.com/ggml-org/llama.cpp/blob/a0535ffa0d35fccfec3e1a0a3bfc9dbb6054d7c0/ggml/src/ggml-cuda/ggml-cuda.cu#L2065), [vLLM](https://github.com/vllm-project/vllm/blob/015fab8c2fa4db8776f7e91abd50371911673d88/vllm/model_executor/layers/fused_moe/fused_moe.py)와 같은 여러 좋은 구현체가 있습니다. `torch._grouped_mm`도 구현 중입니다. `weight`의 메모리 연속성을 개선하기 위해 `input`을 전문가별로 정렬해야 합니다.

이 저장소의 구현은 Triton의 [grouped GEMM](https://triton-lang.org/main/getting-started/tutorials/08-grouped-gemm.html)을 기반으로 한 [Unsloth](https://github.com/unslothai/unsloth/blob/2bfc39b6387577457834059c59f83fcdb954c9bd/unsloth/kernels/moe)의 MoE 커널에 크게 의존합니다. LoRA에 필요한 작은 또는 '얇은' 행렬을 위한 스트라이드, 마스크, 자동 튜닝 설정을 추가했습니다.

코드는 읽기 쉽고 따라가기 쉽게 유지하는 것을 목표로 합니다. TMA나 스위즐 같은 기능 대신 Triton의 가장 성숙한 기능인 로드와 저장만 사용했습니다.

### LoRA

융합 선형층의 LoRA는 각 전문가의 선형층에 대해 먼저 LoRA를 생성한 다음 전문가 차원으로 쌓아 정의합니다. `(num_experts, out_features, in_features)` 형태의 weight 텐서에 대해 두 LoRA 가중치는 `lora_A: (num_experts, lora_rank, in_features), lora_B: (num_experts, out_features, lora_rank)` 형태를 가집니다. 따라서 이전에 학습된 LoRA를 손실 없이 융합 형식으로 변환할 수 있습니다.

[`qwen3_moe_fused/convert.py`](https://github.com/woct0rdho/transformers-qwen3-moe-fused/blob/master/qwen3_moe_fused/convert.py)의 함수들은 모델이나 LoRA를 융합 형식과 비융합 형식 간에 변환할 수 있습니다. 융합 형식으로 LoRA를 학습한 후 비융합 형식으로 변환하고, 다시 GGUF 같은 다른 형식으로 변환할 수 있습니다.

### TODO

* 4비트 디퀀타이즈와 MoE 선형을 융합하기, [`qwen3_moe_fused/quantize/layer.py`](https://github.com/woct0rdho/transformers-qwen3-moe-fused/blob/master/qwen3_moe_fused/quantize/layer.py) 참조. 현재 [`qwen3_moe_fused/grouped_gemm/forward_4bit.py`](https://github.com/woct0rdho/transformers-qwen3-moe-fused/blob/master/qwen3_moe_fused/grouped_gemm/forward_4bit.py)에 커널을 작성했으나 배치 크기가 클 때 비융합 버전보다 느립니다.
* 멀티 GPU 지원. 집에 여러 GPU가 없어 이 부분에 집중하지 않고 있습니다. [OpenSloth](https://github.com/anhvth/opensloth)를 참고할 만합니다.
* Transformers나 Unsloth에 상류 병합. 방법에 대한 아이디어가 있으면 이슈를 열어 주세요. Transformers 자체는 패키지에 Triton이나 CUDA 커널을 포함하지 않지만, 이를 위한 [HuggingFace Kernels](https://github.com/huggingface/kernels) 프로젝트가 있고, [vLLM MoE 커널](https://huggingface.co/kernels-community/moe)은 이미 존재합니다.

### 라이선스

`qwen3_moe_fused/grouped_gemm/` 내 파일들은 Unsloth MoE 커널에서 수정한 것이므로 AGPLv3 라이선스를 따릅니다. 자세한 내용은 [설명](https://github.com/unslothai/unsloth/discussions/2890#discussioncomment-13675890)을 참조하세요. 더 견고하고 성능 좋은 통합을 위해 MIT 라이선스의 [triton-kernels](https://github.com/triton-lang/triton/tree/main/python/triton_kernels/triton_kernels)를 대안으로 사용할 수 있습니다.

이 저장소의 나머지 부분, Transformers, PEFT, bitsandbytes에서 수정한 파일들은 Apache-2.0 라이선스를 따릅니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-15

---
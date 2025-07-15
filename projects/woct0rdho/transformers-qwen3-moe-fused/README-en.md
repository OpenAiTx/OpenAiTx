# Qwen3 MoE Fused

The Qwen3 MoE model (and all other MoE models) in HF Transformers is notoriously slow, because it uses a [for loop](https://github.com/huggingface/transformers/blob/bdf5fb70aa11782cce22027d76879f71f4e41c1e/src/transformers/models/qwen3_moe/modular_qwen3_moe.py#L103) to access the experts. The purpose of this repo is to fine-tune Qwen3-30B-A3B on a single GPU with 24GB VRAM and achieve high throughput. The implementation is compatible with the HF Transformers ecosystem, such as LoRA, bitsandbytes 4-bit quantization, and Unsloth. See [`example_train_30b_a3b_unsloth.py`](https://github.com/woct0rdho/transformers-qwen3-moe-fused/blob/master/example_train_30b_a3b_unsloth.py) for the usage.

## Fused linear layer

The critical part is to implement the [`moe_fused_linear`](https://github.com/woct0rdho/transformers-qwen3-moe-fused/blob/master/qwen3_moe_fused/functional.py) function:
```
output[b, o] = sum_i weight[selected_experts[b], o, i] * input[b, i]
```
There are already several good implementations, such as [triton-kernels](https://github.com/triton-lang/triton/blob/dd1c3d429d1c24904722ac699ea5750bc694c4d6/python/triton_kernels/triton_kernels/matmul_ogs.py), [llama.cpp](https://github.com/ggml-org/llama.cpp/blob/a0535ffa0d35fccfec3e1a0a3bfc9dbb6054d7c0/ggml/src/ggml-cuda/ggml-cuda.cu#L2065), [vLLM](https://github.com/vllm-project/vllm/blob/015fab8c2fa4db8776f7e91abd50371911673d88/vllm/model_executor/layers/fused_moe/fused_moe.py). `torch._grouped_mm` is also being implemented. We need to sort `input` by the experts to improve the memory coalescence of `weight`.

The implementation in this repo is largely based on the MoE kernel in [Unsloth](https://github.com/unslothai/unsloth/blob/2bfc39b6387577457834059c59f83fcdb954c9bd/unsloth/kernels/moe), which is based on the Triton [grouped GEMM](https://triton-lang.org/main/getting-started/tutorials/08-grouped-gemm.html). I've added strides, masks, and autotune configs for small or 'thin' matrices, which are needed for LoRA.

I aim to keep the code readable and easy to follow. I only used the most mature features of Triton, such as load and store, rather than things like TMA and swizzle.

### LoRA

The LoRA for the fused linear layer is defined by first creating a LoRA for the linear layer in each expert, then stacking them along the experts dimension. For the weight tensor with shape `(num_experts, out_features, in_features)`, the two LoRA weights have shape `lora_A: (num_experts, lora_rank, in_features), lora_B: (num_experts, out_features, lora_rank)`. Therefore, a previously trained LoRA can be losslessly converted to the fused format.

The functions in [`qwen3_moe_fused/convert.py`](https://github.com/woct0rdho/transformers-qwen3-moe-fused/blob/master/qwen3_moe_fused/convert.py) can convert a model or a LoRA between the fused and the unfused formats. After you train a LoRA in the fused format, you can convert it to the unfused format, then convert it to other formats such as GGUF.

### TODO

* Fuse 4-bit dequant and MoE linear, see [`qwen3_moe_fused/quantize/layer.py`](https://github.com/woct0rdho/transformers-qwen3-moe-fused/blob/master/qwen3_moe_fused/quantize/layer.py). Currently I've written a kernel in [`qwen3_moe_fused/grouped_gemm/forward_4bit.py`](https://github.com/woct0rdho/transformers-qwen3-moe-fused/blob/master/qwen3_moe_fused/grouped_gemm/forward_4bit.py) but it's slower than the unfused version when the batch size is large.
* Multi-GPU support. I don't have multiple GPUs at home so I'm not focusing on this. Maybe worth checking [OpenSloth](https://github.com/anhvth/opensloth).
* Upstream to Transformers or Unsloth. If you have any idea how to do this, please open an issue. Transformers itself never includes Triton or CUDA kernels in the package, but they have a [HuggingFace Kernels](https://github.com/huggingface/kernels) project for them, and the [vLLM MoE kernels](https://huggingface.co/kernels-community/moe) are already there.

### License

The files in `qwen3_moe_fused/grouped_gemm/` are modified from the Unsloth MoE kernels so they are AGPLv3 licensed, see the [explanation](https://github.com/unslothai/unsloth/discussions/2890#discussioncomment-13675890). For more robust and performant integration, it's possible to use the MIT licensed [triton-kernels](https://github.com/triton-lang/triton/tree/main/python/triton_kernels/triton_kernels) as an alternative.

The rest of this repo, including files modified from Transformers, PEFT, and bitsandbytes, are Apache-2.0 licensed.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-15

---
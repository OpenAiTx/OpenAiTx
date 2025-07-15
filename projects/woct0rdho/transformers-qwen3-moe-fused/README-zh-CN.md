# Qwen3 MoE 融合

HF Transformers 中的 Qwen3 MoE 模型（以及所有其他 MoE 模型）速度非常慢，因为它使用了一个 [for 循环](https://github.com/huggingface/transformers/blob/bdf5fb70aa11782cce22027d76879f71f4e41c1e/src/transformers/models/qwen3_moe/modular_qwen3_moe.py#L103) 来访问专家。这个仓库的目的是在单个拥有 24GB 显存的 GPU 上微调 Qwen3-30B-A3B 并实现高吞吐量。该实现兼容 HF Transformers 生态系统，例如 LoRA、bitsandbytes 4-bit 量化和 Unsloth。使用方法见 [`example_train_30b_a3b_unsloth.py`](https://github.com/woct0rdho/transformers-qwen3-moe-fused/blob/master/example_train_30b_a3b_unsloth.py)。

## 融合线性层

关键部分是实现 [`moe_fused_linear`](https://github.com/woct0rdho/transformers-qwen3-moe-fused/blob/master/qwen3_moe_fused/functional.py) 函数：
```
output[b, o] = sum_i weight[selected_experts[b], o, i] * input[b, i]
```
已经有几个很好的实现，例如 [triton-kernels](https://github.com/triton-lang/triton/blob/dd1c3d429d1c24904722ac699ea5750bc694c4d6/python/triton_kernels/triton_kernels/matmul_ogs.py)、[llama.cpp](https://github.com/ggml-org/llama.cpp/blob/a0535ffa0d35fccfec3e1a0a3bfc9dbb6054d7c0/ggml/src/ggml-cuda/ggml-cuda.cu#L2065)、[vLLM](https://github.com/vllm-project/vllm/blob/015fab8c2fa4db8776f7e91abd50371911673d88/vllm/model_executor/layers/fused_moe/fused_moe.py) 。`torch._grouped_mm` 也正在实现中。我们需要按专家对 `input` 进行排序，以提升 `weight` 的内存合并效率。

本仓库中的实现很大程度上基于 [Unsloth](https://github.com/unslothai/unsloth/blob/2bfc39b6387577457834059c59f83fcdb954c9bd/unsloth/kernels/moe) 中的 MoE 内核，该内核基于 Triton 的 [grouped GEMM](https://triton-lang.org/main/getting-started/tutorials/08-grouped-gemm.html)。我添加了 stride、掩码和针对小型或“瘦”矩阵的自动调优配置，这些都是 LoRA 所需的。

我力求保持代码可读且易于理解。我只使用了 Triton 中最成熟的特性，如 load 和 store，而没有使用 TMA 和 swizzle 之类的功能。

### LoRA

融合线性层的 LoRA 是先为每个专家的线性层创建 LoRA，然后沿专家维度堆叠。对于形状为 `(num_experts, out_features, in_features)` 的权重张量，两个 LoRA 权重的形状分别是 `lora_A: (num_experts, lora_rank, in_features)` 和 `lora_B: (num_experts, out_features, lora_rank)`。因此，先前训练好的 LoRA 可以无损转换为融合格式。

[`qwen3_moe_fused/convert.py`](https://github.com/woct0rdho/transformers-qwen3-moe-fused/blob/master/qwen3_moe_fused/convert.py) 中的函数可以在融合和非融合格式之间转换模型或 LoRA。在融合格式下训练完 LoRA 后，可以将其转换为非融合格式，然后再转换为 GGUF 等其他格式。

### 待办事项

* 融合 4-bit 反量化和 MoE 线性，见 [`qwen3_moe_fused/quantize/layer.py`](https://github.com/woct0rdho/transformers-qwen3-moe-fused/blob/master/qwen3_moe_fused/quantize/layer.py)。目前我已在 [`qwen3_moe_fused/grouped_gemm/forward_4bit.py`](https://github.com/woct0rdho/transformers-qwen3-moe-fused/blob/master/qwen3_moe_fused/grouped_gemm/forward_4bit.py) 编写了一个内核，但在批量较大时，其速度比非融合版本慢。
* 多 GPU 支持。我家中没有多块 GPU，因此暂时未重点开发。也许可以关注 [OpenSloth](https://github.com/anhvth/opensloth)。
* 上游集成到 Transformers 或 Unsloth。如果你有任何想法，欢迎开 issue。Transformers 本身从不在包中包含 Triton 或 CUDA 内核，但它们有一个 [HuggingFace Kernels](https://github.com/huggingface/kernels) 项目，且 [vLLM MoE 内核](https://huggingface.co/kernels-community/moe) 已经在那里。

### 许可协议

`qwen3_moe_fused/grouped_gemm/` 目录下的文件是从 Unsloth MoE 内核修改而来，因此遵循 AGPLv3 许可，详见 [说明](https://github.com/unslothai/unsloth/discussions/2890#discussioncomment-13675890)。为了更稳健和高性能的集成，可以选择使用 MIT 许可的 [triton-kernels](https://github.com/triton-lang/triton/tree/main/python/triton_kernels/triton_kernels) 作为替代。

本仓库其余部分，包括从 Transformers、PEFT 和 bitsandbytes 修改的文件，均采用 Apache-2.0 许可。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-15

---
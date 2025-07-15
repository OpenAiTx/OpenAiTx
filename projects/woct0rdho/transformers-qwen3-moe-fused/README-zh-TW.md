# Qwen3 MoE 融合版

HF Transformers 中的 Qwen3 MoE 模型（以及所有其他 MoE 模型）以速度緩慢著稱，因為它使用了[for 迴圈](https://github.com/huggingface/transformers/blob/bdf5fb70aa11782cce22027d76879f71f4e41c1e/src/transformers/models/qwen3_moe/modular_qwen3_moe.py#L103)來存取專家模型。此倉庫的目標是使用單一擁有 24GB VRAM 的 GPU 微調 Qwen3-30B-A3B 並達成高吞吐量。此實作與 HF Transformers 生態系統相容，例如 LoRA、bitsandbytes 4-bit 量化及 Unsloth。使用說明請參考[`example_train_30b_a3b_unsloth.py`](https://github.com/woct0rdho/transformers-qwen3-moe-fused/blob/master/example_train_30b_a3b_unsloth.py)。

## 融合線性層

關鍵部分是實作 [`moe_fused_linear`](https://github.com/woct0rdho/transformers-qwen3-moe-fused/blob/master/qwen3_moe_fused/functional.py) 函數：
```
output[b, o] = sum_i weight[selected_experts[b], o, i] * input[b, i]
```
已有幾個不錯的實作，例如 [triton-kernels](https://github.com/triton-lang/triton/blob/dd1c3d429d1c24904722ac699ea5750bc694c4d6/python/triton_kernels/triton_kernels/matmul_ogs.py)、[llama.cpp](https://github.com/ggml-org/llama.cpp/blob/a0535ffa0d35fccfec3e1a0a3bfc9dbb6054d7c0/ggml/src/ggml-cuda/ggml-cuda.cu#L2065)、[vLLM](https://github.com/vllm-project/vllm/blob/015fab8c2fa4db8776f7e91abd50371911673d88/vllm/model_executor/layers/fused_moe/fused_moe.py)。`torch._grouped_mm` 也正在實作中。我們需要依據專家將 `input` 進行排序，以提升 `weight` 的記憶體連續性。

本倉庫的實作主要基於 [Unsloth](https://github.com/unslothai/unsloth/blob/2bfc39b6387577457834059c59f83fcdb954c9bd/unsloth/kernels/moe) 中的 MoE 核心，其又基於 Triton 的 [grouped GEMM](https://triton-lang.org/main/getting-started/tutorials/08-grouped-gemm.html)。我加入了 strides、遮罩以及針對小型或「細長」矩陣的自動調參配置，這些對 LoRA 是必要的。

我希望保持程式碼的可讀性與易於理解。我只使用了 Triton 最成熟的功能，如 load 與 store，而非 TMA 或 swizzle 等較複雜的功能。

### LoRA

融合線性層的 LoRA 是先在每個專家中的線性層建立 LoRA，然後沿著專家維度堆疊。對於形狀為 `(num_experts, out_features, in_features)` 的權重張量，兩個 LoRA 權重分別為 `lora_A: (num_experts, lora_rank, in_features), lora_B: (num_experts, out_features, lora_rank)`。因此，先前訓練好的 LoRA 可以無損地轉換成融合格式。

[`qwen3_moe_fused/convert.py`](https://github.com/woct0rdho/transformers-qwen3-moe-fused/blob/master/qwen3_moe_fused/convert.py) 中的函式可以在融合與非融合格式間轉換模型或 LoRA。當你在融合格式下訓練好 LoRA 後，可以轉換回非融合格式，再轉換成其他格式，如 GGUF。

### TODO

* 融合 4-bit 反量化與 MoE 線性層，詳見 [`qwen3_moe_fused/quantize/layer.py`](https://github.com/woct0rdho/transformers-qwen3-moe-fused/blob/master/qwen3_moe_fused/quantize/layer.py)。目前我在 [`qwen3_moe_fused/grouped_gemm/forward_4bit.py`](https://github.com/woct0rdho/transformers-qwen3-moe-fused/blob/master/qwen3_moe_fused/grouped_gemm/forward_4bit.py) 寫了一個核心，但批次大小大時速度比非融合版慢。
* 多 GPU 支援。我家沒有多 GPU，所以目前沒專注在這塊。或許值得參考 [OpenSloth](https://github.com/anhvth/opensloth)。
* 提交至 Transformers 或 Unsloth。如果你有任何想法，請開 issue。Transformers 本身不會在套件中包含 Triton 或 CUDA 核心，但他們有一個 [HuggingFace Kernels](https://github.com/huggingface/kernels) 專案，且 [vLLM MoE 核心](https://huggingface.co/kernels-community/moe) 已經存在那裡。

### 授權

`qwen3_moe_fused/grouped_gemm/` 中的檔案是修改自 Unsloth MoE 核心，因此採用 AGPLv3 授權，詳見 [說明](https://github.com/unslothai/unsloth/discussions/2890#discussioncomment-13675890)。若要更穩健且高效的整合，可以使用 MIT 授權的 [triton-kernels](https://github.com/triton-lang/triton/tree/main/python/triton_kernels/triton_kernels) 作為替代。

本倉庫其餘部分，包括修改自 Transformers、PEFT 與 bitsandbytes 的檔案，均採用 Apache-2.0 授權。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-15

---
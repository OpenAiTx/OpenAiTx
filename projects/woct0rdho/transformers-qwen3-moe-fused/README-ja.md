# Qwen3 MoE Fused

HF TransformersのQwen3 MoEモデル（および他のすべてのMoEモデル）は、[forループ](https://github.com/huggingface/transformers/blob/bdf5fb70aa11782cce22027d76879f71f4e41c1e/src/transformers/models/qwen3_moe/modular_qwen3_moe.py#L103)を使ってエキスパートにアクセスするため、非常に遅いです。このリポジトリの目的は、24GB VRAMの単一GPUでQwen3-30B-A3Bをファインチューニングし、高スループットを実現することです。実装はLoRA、bitsandbytes 4ビット量子化、Unslothなど、HF Transformersエコシステムと互換性があります。使用例は[`example_train_30b_a3b_unsloth.py`](https://github.com/woct0rdho/transformers-qwen3-moe-fused/blob/master/example_train_30b_a3b_unsloth.py)を参照してください。

## Fused linear layer

重要な部分は[`moe_fused_linear`](https://github.com/woct0rdho/transformers-qwen3-moe-fused/blob/master/qwen3_moe_fused/functional.py)関数の実装です：
```
output[b, o] = sum_i weight[selected_experts[b], o, i] * input[b, i]
```
すでにいくつかの優れた実装があります。例えば、[triton-kernels](https://github.com/triton-lang/triton/blob/dd1c3d429d1c24904722ac699ea5750bc694c4d6/python/triton_kernels/triton_kernels/matmul_ogs.py)、[llama.cpp](https://github.com/ggml-org/llama.cpp/blob/a0535ffa0d35fccfec3e1a0a3bfc9dbb6054d7c0/ggml/src/ggml-cuda/ggml-cuda.cu#L2065)、[vLLM](https://github.com/vllm-project/vllm/blob/015fab8c2fa4db8776f7e91abd50371911673d88/vllm/model_executor/layers/fused_moe/fused_moe.py)があります。`torch._grouped_mm`も実装中です。`weight`のメモリコアレセンスを改善するために`input`をエキスパートごとにソートする必要があります。

このリポジトリの実装は主に[Unsloth](https://github.com/unslothai/unsloth/blob/2bfc39b6387577457834059c59f83fcdb954c9bd/unsloth/kernels/moe)のMoEカーネルに基づいており、これはTritonの[grouped GEMM](https://triton-lang.org/main/getting-started/tutorials/08-grouped-gemm.html)に基づいています。LoRAに必要な小さいまたは「薄い」行列用のストライド、マスク、自動チューニング設定を追加しました。

コードは読みやすく、追いやすいままに保つことを目標としています。TMAやスウィズルのようなものではなく、ロードやストアのようなTritonの最も成熟した機能のみを使用しました。

### LoRA

融合線形層のLoRAは、まず各エキスパート内の線形層に対してLoRAを作成し、それをエキスパート次元に沿って積み重ねることで定義されます。形状が`(num_experts, out_features, in_features)`の重みテンソルに対し、2つのLoRA重みは`lora_A: (num_experts, lora_rank, in_features)、lora_B: (num_experts, out_features, lora_rank)`の形状を持ちます。したがって、以前に訓練されたLoRAは損失なく融合形式に変換可能です。

[`qwen3_moe_fused/convert.py`](https://github.com/woct0rdho/transformers-qwen3-moe-fused/blob/master/qwen3_moe_fused/convert.py)の関数は、モデルまたはLoRAを融合形式と非融合形式の間で変換できます。融合形式でLoRAを訓練した後、非融合形式に変換し、さらにGGUFなどの他の形式に変換可能です。

### TODO

* 4ビットの非量子化とMoE線形層の融合。詳しくは[`qwen3_moe_fused/quantize/layer.py`](https://github.com/woct0rdho/transformers-qwen3-moe-fused/blob/master/qwen3_moe_fused/quantize/layer.py)を参照。現在、[`qwen3_moe_fused/grouped_gemm/forward_4bit.py`](https://github.com/woct0rdho/transformers-qwen3-moe-fused/blob/master/qwen3_moe_fused/grouped_gemm/forward_4bit.py)にカーネルを書いていますが、バッチサイズが大きい場合は非融合版より遅いです。
* マルチGPU対応。自宅に複数GPUがないため、現在は重点を置いていません。[OpenSloth](https://github.com/anhvth/opensloth)を確認する価値があるかもしれません。
* TransformersまたはUnslothへの上流統合。方法についてアイデアがあれば、ぜひIssueを開いてください。Transformers自体はTritonやCUDAカーネルをパッケージに含めませんが、[HuggingFace Kernels](https://github.com/huggingface/kernels)というプロジェクトがあり、[vLLM MoEカーネル](https://huggingface.co/kernels-community/moe)も既に存在します。

### ライセンス

`qwen3_moe_fused/grouped_gemm/`内のファイルはUnsloth MoEカーネルから改変されたもので、AGPLv3ライセンスです。詳細は[説明](https://github.com/unslothai/unsloth/discussions/2890#discussioncomment-13675890)を参照してください。より堅牢で高性能な統合には、MITライセンスの[triton-kernels](https://github.com/triton-lang/triton/tree/main/python/triton_kernels/triton_kernels)を代替として使用可能です。

Transformers、PEFT、bitsandbytesから改変されたファイルを含むこのリポジトリの残りはApache-2.0ライセンスです。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-15

---
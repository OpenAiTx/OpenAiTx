编辑：由于我未能用该模型生成足够好的结果，此仓库已归档，暂时我会坚持使用 LTX2.3。  
欢迎大家继续开发。  

编辑：注意！此项目仍在开发中，请不要指望它能正常运行。  
我将去复活节假期，回来前没时间处理它。  
欢迎 fork 继续开发，或等待 Kijai 发布他的版本。  

代码目前（后续会更改）会自动从 huggingface 下载所需的文本编码器和 wan vae，  
首次运行时请预期会花费一些时间。  

# ComfyUI-DaVinci-MagiHuman  

ComfyUI 自定义节点，针对 [daVinci-MagiHuman](https://huggingface.co/GAIR/daVinci-MagiHuman) —— 一个15亿参数的单流变换器，用于快速音视频生成。针对消费级 GPU（RTX 5090 32GB）进行了优化。  

## 特性  

- **块级 CPU/GPU 交换** — GPU 上同时仅运行40层变换器中的8层（约6GB 对比约30GB）  
- **异步 CUDA 预取** — 当前块计算时预传输下一个块  
- **蒸馏模式** — 8步生成无 CFG（最快）  
- **1080p 超分辨率** — 从256p基础潜变量空间上采样  
- **TurboVAE 解码器** — 滑动窗口解码并输出卸载支持1080p  
- **音频 + 视频** — 单流联合生成  

## 节点  

| 节点 | 描述 |  
|------|-------------|  
| **DaVinci 模型加载器** | 加载蒸馏/基础/SR模型，支持配置 `blocks_on_gpu` |  
| **DaVinci TurboVAE 加载器** | 加载快速仅解码 VAE |  
| **DaVinci 文本编码** | 文本提示转嵌入（支持外部 T5 编码器） |  
| **DaVinci 采样器** | 去噪循环（8步蒸馏 / 32步基础） |  
| **DaVinci 超分辨率** | 使用 SR 模型将256p潜变量放大至1080p |  
| **DaVinci 解码** | TurboVAE 潜变量转视频，支持输出卸载 |  
| **DaVinci 视频输出** | 通过 FFmpeg 保存为 mp4/webm |  

## 工作流程  

```
Model Loader (distill, 8 blocks on GPU)
  → Text Encode
    → Sampler (256p, 8 steps)
      → [optional] SR Model Loader (1080p_sr) → Super Resolution
        → TurboVAE Loader → Decode → Video Output
```

## 要求

- **GPU**：RTX 5090（32GB）或更好。32GB显存的GPU上支持8个块。
- **内存**：建议64GB以上（CPU卸载会在系统内存中存储约24GB的模型权重）
- **CUDA**：支持bf16的CUDA兼容GPU
- **FFmpeg**：视频输出所需
- **Python包**：`safetensors`，`torch`，`numpy`

## 模型设置

从 [HuggingFace](https://huggingface.co/GAIR/daVinci-MagiHuman) 下载模型权重：

```bash
cd ComfyUI/models

# Clone without large files
GIT_LFS_SKIP_SMUDGE=1 git clone https://huggingface.co/GAIR/daVinci-MagiHuman

cd daVinci-MagiHuman

# Pull only what you need (skip 540p_sr if you only want 1080p)
git lfs pull --include="distill/*,turbo_vae/*"        # ~61GB - base generation
git lfs pull --include="1080p_sr/*"                    # ~61GB - 1080p upscaling
```

预期的目录结构：
```
ComfyUI/models/daVinci-MagiHuman/
├── distill/          # 8-step distilled model (~61GB)
├── 1080p_sr/         # Super-resolution model (~61GB)
├── turbo_vae/        # Fast decoder (small)
├── base/             # Full 32-step model (optional, ~30GB)
└── 540p_sr/          # 540p SR (optional, ~61GB)
```

## VRAM 指南

| `blocks_on_gpu` | 显存使用 | 速度 | 适用推荐 |
|-----------------|-----------|-------|-----------------|
| 4 | 约3GB + 额外开销 | 最慢 | 16GB 显卡 |
| 8 | 约6GB + 额外开销 | 良好 | 24-32GB 显卡 |
| 16 | 约12GB + 额外开销 | 快速 | 48GB 显卡 |
| 40 | 约30GB | 最快 | 80GB 及以上显卡 |

## 文本编码器

daVinci-MagiHuman 使用 T5Gemma-9B 作为其文本编码器。**DaVinci 文本编码**节点当前提供：

- **占位符嵌入**用于流水线测试（随机噪声——不会产生有意义的输出）
- **外部 T5 输入**——连接来自其他编码器节点的预计算 T5 嵌入（3584 维）

生产环境中，连接 T5-XXL 或 T5Gemma 编码器节点至 `t5_embeds` 输入。

## 架构

该模型是一个单流变换器，联合生成视频和音频：

- **15B 参数量**，40 层变换器
- **隐藏层大小**：5120，**GQA**：40 查询 / 8 KV 头，**头维度**：128
- **夹层**：第 0-3 层和 36-39 层有针对每种模态的归一化（视频/音频/文本）
- **共享层**：第 4-35 层采用统一处理
- **无时间步**：无显式时间步嵌入——从输入推断去噪状态
- **每头门控**：每个注意力头上学习的 sigmoid 门控

## 致谢

- [daVinci-MagiHuman](https://huggingface.co/GAIR/daVinci-MagiHuman) 由 SII-GAIR & Sand.ai 贡献
- [MagiCompiler](https://github.com/SandAI-org/MagiCompiler) 用于算子融合
- 基于 Wan2.2 和 TurboVAED 构建

## 许可证

Apache 2.0


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-22

---
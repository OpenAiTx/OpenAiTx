
# ComfyUI-MagCache

## 🫖 介绍
Magnitude-aware Cache（MagCache）是一种无需训练的缓存方法。它基于稳健的**幅度观测**，估计模型输出在各时间步之间的波动差异，从而利用误差建模机制和自适应缓存策略加速推理。MagCache 在视频扩散模型和图像扩散模型中表现良好。更多详情和结果，请访问我们的[项目主页](https://zehong-ma.github.io/MagCache)和[代码库](https://github.com/Zehong-Ma/MagCache)。

MagCache 已集成到 ComfyUI 中，兼容 ComfyUI 原生节点。ComfyUI-MagCache 使用简便，只需将 MagCache 节点与 ComfyUI 原生节点连接，即可无缝使用。

## 🔥 最新动态
- **如果您喜欢我们的项目，请在 GitHub 上给我们点⭐，以获取最新更新。**
- [2025/6/30] 🔥 支持 [Flux-Kontext](https://huggingface.co/black-forest-labs/FLUX.1-Kontext-dev)，实现2倍加速。请查看演示[这里](https://github.com/user-attachments/assets/79d5f654-5828-442d-b1a1-9b754c17e457)。
- [2025/6/19] 🔥 支持 [FramePack](https://github.com/lllyasviel/FramePack)，并在 [MagCache-FramePack](https://github.com/Zehong-Ma/MagCache) 提供 Gradio 演示。
- [2025/6/18] 👉 我们正在收集社区最佳参数设置。<br> 👉**打开此[讨论议题](https://github.com/Zehong-Ma/ComfyUI-MagCache/issues/15)贡献您的配置！**
- [2025/6/17] 🔥 支持 [Wan2.1-VACE-1.3B](https://github.com/ali-vilab/VACE)，实现1.7倍加速。
- [2025/6/17] 🔥 MagCache 得到 [ComfyUI-WanVideoWrapper](https://github.com/kijai/ComfyUI-WanVideoWrapper) 支持。感谢 @[kijai](https://github.com/kijai)。
- [2025/6/16] 🔥 支持 [Chroma](https://huggingface.co/lodestones/Chroma)。感谢 @[kabachuha](https://github.com/kabachuha) 提供代码库。
- [2025/6/10] 🔥 支持 [Wan2.1](https://github.com/Wan-Video/Wan2.1) T2V&I2V，[HunyuanVideo](https://github.com/Tencent/HunyuanVideo) T2V，[FLUX-dev](https://github.com/black-forest-labs/flux) T2I。

## 安装
<!-- 推荐通过 ComfyUI-Manager 安装。只需在节点列表中搜索 ComfyUI-MagCache 并点击安装。
### 手动安装 -->
1. 进入 comfyUI 自定义节点文件夹，`ComfyUI/custom_nodes/`
2. 执行 git clone https://github.com/zehong-ma/ComfyUI-MagCache.git
3. 进入 ComfyUI-MagCache 文件夹，`cd ComfyUI-MagCache/`
4. 执行 pip install -r requirements.txt
5. 进入项目文件夹 `ComfyUI/` 并运行 `python main.py`
## 使用方法

### 下载模型权重
请先参照以下链接准备 ComfyUI 格式的模型权重：
- [Wan2.1](https://comfyanonymous.github.io/ComfyUI_examples/wan/)
- [HunyuanVideo](https://comfyanonymous.github.io/ComfyUI_examples/hunyuan_video/)
- [FLUX](https://comfyanonymous.github.io/ComfyUI_examples/flux/)
- [Chroma](https://huggingface.co/lodestones/Chroma)

### MagCache

**我们正在收集社区中最佳的参数设置。打开此[讨论议题](https://github.com/Zehong-Ma/ComfyUI-MagCache/issues/15)贡献您的配置！**

使用 MagCache 节点，只需在 `Load Diffusion Model` 节点或 `Load LoRA` 节点（如需 LoRA）之后添加 `MagCache` 节点。通常，MagCache 可实现2到3倍的加速，同时视觉质量损失可接受。下表为不同模型推荐的 magcache_thresh、retention_ratio 和 magcache_K：

<div align="center">

| 模型                         |   magcache_thresh |   retention_ratio |    magcache_K     |  
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

**如果应用 MagCache 后的图像/视频质量较低，请降低 `magcache_thresh` 和 `magcache_K`。** 默认参数配置为极快推理（2x-3x），可能在某些情况下导致失败。

演示工作流（[flux](https://raw.githubusercontent.com/Zehong-Ma/ComfyUI-MagCache/main/./examples/flux.json)、[flux-kontext](https://raw.githubusercontent.com/Zehong-Ma/ComfyUI-MagCache/main/./examples/flux_1_kontext_dev.json)、[chroma](https://raw.githubusercontent.com/Zehong-Ma/ComfyUI-MagCache/main/./examples/chroma.json)、[hunyuanvideo](https://raw.githubusercontent.com/Zehong-Ma/ComfyUI-MagCache/main/./examples/hunyuanvideo.json)、[wan2.1_t2v](https://raw.githubusercontent.com/Zehong-Ma/ComfyUI-MagCache/main/./examples/wan2.1_t2v.json)、[wan2.1_i2v](https://raw.githubusercontent.com/Zehong-Ma/ComfyUI-MagCache/main/./examples/wan2.1_i2v.json)、及 [wan2.1_vace](https://raw.githubusercontent.com/Zehong-Ma/ComfyUI-MagCache/main/./examples/wan2.1_vace.json)）放置于 examples 文件夹。工作流 [chroma_calibration](https://raw.githubusercontent.com/Zehong-Ma/ComfyUI-MagCache/main/./examples/chroma_calibration.json) 用于校准 `Chroma` 的 `mag_ratios`，当推理步数与预设值不同时使用。
**在我们的实验中，Wan2.1 生成的视频质量不及[原始未量化版本](https://github.com/Wan-Video/Wan2.1)。**

### 编译模型
使用 Compile Model 节点，只需在 `Load Diffusion Model` 节点或 `MagCache` 节点之后添加 `Compile Model` 节点。Compile Model 使用 `torch.compile` 通过将模型编译为更高效的中间表示（IR）来提升模型性能。此编译过程利用后端编译器生成优化代码，可显著加速推理。首次运行工作流时，编译可能耗时较长，但编译完成后推理速度极快。
<!-- 使用示例如下： -->
<!-- ![](https://raw.githubusercontent.com/Zehong-Ma/ComfyUI-MagCache/main/./assets/compile.png) -->

## 致谢
感谢 [ComfyUI-TeaCache](https://github.com/welltop-cn/ComfyUI-TeaCache)、[ComfyUI](https://github.com/comfyanonymous/ComfyUI)、[ComfyUI-MagCache](https://github.com/wildminder/ComfyUI-MagCache)、[MagCache](https://github.com/Zehong-Ma/MagCache/)、[TeaCache](https://github.com/ali-vilab/TeaCache)、[HunyuanVideo](https://github.com/Tencent/HunyuanVideo)、[FLUX](https://github.com/black-forest-labs/flux)、[Chroma](https://huggingface.co/lodestones/Chroma) 以及 [Wan2.1](https://github.com/Wan-Video/Wan2.1)。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---
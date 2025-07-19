<translate-content># DreamO Comfyui
[DreamO](https://github.com/bytedance/DreamO) ComfyUI 原生实现。

[![arXiv](https://img.shields.io/badge/arXiv-Paper-<COLOR>.svg)](https://arxiv.org/abs/2504.16915) [![demo](https://img.shields.io/badge/🤗-HuggingFace_Demo-orange)](https://huggingface.co/spaces/ByteDance/DreamO) <br>

<img width="1485" alt="Image" src="https://github.com/user-attachments/assets/0954b0bf-63db-463f-ae25-9cd983b462db" />


> [!Important]  
> **2025.06.24** - 我们很高兴发布 **DreamO v1.1**，大幅提升了图像质量，减少了人体构图错误的可能性，并增强了美学效果。 [了解更多关于此模型的信息](https://github.com/bytedance/DreamO/blob/main/dreamo_v1.1.md)


## 安装
此实现基于 2025.5.19 版本的 ComfyUI（提交ID：e930a38）。如果您使用较旧版本，可能会出现兼容性问题。
```shell
# manual install
cd custom_nodes
git clone https://github.com/ToTheBeginning/ComfyUI-DreamO.git
# Please make sure that you have installed the forked version of facexlib, not the original facexlib. Otherwise, you may encounter face parsing errors.
pip install -r requirements.txt
# restart comfyui
```
## 模型
### FLUX 模型
如果你的机器上已经下载了 FLUX 模型，可以跳过此步骤。
- 原始 bf16 模型: [dit](https://huggingface.co/black-forest-labs/FLUX.1-dev/blob/main/flux1-dev.safetensors), [t5](https://huggingface.co/comfyanonymous/flux_text_encoders/blob/main/t5xxl_fp16.safetensors)
- 8 位 FP8: [dit](https://huggingface.co/Comfy-Org/flux1-dev/blob/main/flux1-dev-fp8.safetensors), [t5](https://huggingface.co/comfyanonymous/flux_text_encoders/blob/main/t5xxl_fp8_e4m3fn.safetensors)
- Clip 和 VAE（适用于所有模型）: [clip](https://huggingface.co/comfyanonymous/flux_text_encoders/blob/main/clip_l.safetensors), [vae](https://huggingface.co/black-forest-labs/FLUX.1-schnell/blob/main/ae.safetensors)

### DreamO 模型
- 下载 https://huggingface.co/ByteDance/DreamO/tree/main/comfyui 中所有以 `.safetensors` 结尾的文件 => `ComfyUI/models/loras`。
- 🔥🔥**v1.1**：下载 https://huggingface.co/ByteDance/DreamO/tree/main/v1.1 中所有以 `.safetensors` 结尾的文件 => `ComfyUI/models/loras`。
- （支持自动下载）下载 [dreamo-embedding](https://huggingface.co/ByteDance/DreamO/blob/main/embedding.safetensors) => `ComfyUI/models/dreamo`
- （支持自动下载）下载 [ben2](https://huggingface.co/PramaLLC/BEN2/blob/main/model.safetensors) => `ComfyUI/models/dreamo`
- 下载 [flux-turbo](https://huggingface.co/alimama-creative/FLUX.1-Turbo-Alpha/blob/main/diffusion_pytorch_model.safetensors) => `ComfyUI/models/loras`，并重命名为 `flux-turbo.safetensors`

## 工作流程
请在 [workflows](workflows) 文件夹中查找工作流程，[此 v1.1 工作流程](https://raw.githubusercontent.com/ToTheBeginning/ComfyUI-DreamO/main/workflows/dreamo_comfyui_v1.1.json) 是最新版本。

v1.1 模型结合 [Super-Realism LoRA](https://huggingface.co/strangerzonehf/Flux-Super-Realism-LoRA) 可以进一步增强真实感。但由于它是面向真实感的 LoRA，可能会影响风格迁移。根据需要使用。

## 节点
- DreamOProcessorLoader
  - 该节点加载两个图像预处理模型：用于背景移除的 BEN2 模型和用于对齐人脸检测的 facexlib 模型。
- DreamORefEncode
  - 该节点根据选择的任务类型将参考图像编码为潜在表示。提供三种任务类型：ip、id 和 style。
    - ip：将移除参考图像的背景
    - id：将从参考图像中对齐并裁剪人脸，类似 PuLID
    - style：将保留参考图像的背景。你仍需触发元提示以激活风格迁移任务
- ApplyDreamO
  - 该节点为 Flux 模型添加钩子，以支持将参考潜在与噪声潜在连接。

## 注意
- 当前代码未实现真正的 CFG 逻辑，意味着你需要在采样器节点中将 cfg 设置为 1
- 如前所述，我们是 ComfyUI 新手。如果你有更好的工作流程或建议，请告诉我们。

欢迎贡献！

    
## 致谢
ComfyUI 插件的实现参考了 [ComfyUI_PuLID_Flux_ll](https://github.com/lldacing/ComfyUI_PuLID_Flux_ll)。

## 未来计划
✅ 请关注我们的基础仓库 [DreamO](https://github.com/bytedance/DreamO) —— 我们将在未来几周发布模型更新。

## :e-mail: 联系方式
如有任何评论或问题，请 [创建新问题](https://github.com/xxx/xxx/issues/new/choose) 或联系 [Yanze Wu](https://tothebeginning.github.io/) 和 [Chong Mou](https://raw.githubusercontent.com/ToTheBeginning/ComfyUI-DreamO/main/mailto:eechongm@gmail.com)。





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---
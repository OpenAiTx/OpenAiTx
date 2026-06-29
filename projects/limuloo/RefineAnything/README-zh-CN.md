# RefineAnything

**多模态区域特定细化，实现完美局部细节**

<a href="https://limuloo.github.io/RefineAnything/"><img src="https://img.shields.io/badge/Project-Page-blue" /></a>
<a href="https://arxiv.org/abs/2604.06870"><img src="https://img.shields.io/badge/arXiv-2604.06870-b31b1b" /></a>
<a href="https://github.com/limuloo/RefineAnything"><img src="https://img.shields.io/badge/GitHub-Code-black?logo=github" /></a>
<a href="https://huggingface.co/limuloo1999/RefineAnything"><img src="https://img.shields.io/badge/HuggingFace-Checkpoint-yellow?logo=huggingface" /></a>
<a href="https://huggingface.co/spaces/limuloo1999/RefineAnything"><img src="https://img.shields.io/badge/HuggingFace-Space-orange?logo=huggingface" /></a>
<a href="https://github.com/smthemex/ComfyUI_RefineAnything"><img src="https://img.shields.io/badge/ComfyUI-Plugin-green?logo=github" /></a>

RefineAnything 目标是**区域特定图像细化**：给定输入图像和用户指定区域（如涂鸦遮罩或边界框），它恢复细粒度细节——文字、标志、细线结构——同时保持**所有未编辑像素不变**。支持**基于参考图像**和**无参考**的细化。

![Teaser](https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/teaser.png)
---

## 新闻
- **2026-04-21** — **环境版本锁定更新。** 为获得最佳效果（并避免色彩偏移），请使用 `requirement.txt` 中**精确**锁定的版本：`diffusers==0.36.0`、`transformers==4.55.0`、`safetensors==0.5.3`、`peft==0.17.0`。详见下方[环境说明](#environment-notice)的对比图。
- **2026-04-21** — **Hugging Face Space 环境修复。** 在线演示现运行于正确的依赖版本，细化效果明显提升：<https://huggingface.co/spaces/limuloo1999/RefineAnything>。
- **2026-04-14** — 社区 ComfyUI 集成，由 [@smthemex](https://github.com/smthemex) 贡献：[ComfyUI_RefineAnything](https://github.com/smthemex/ComfyUI_RefineAnything)。感谢出色的工作！
- **2026-04-14** — 本地 Gradio 演示（`app.py`）上线，支持交互测试。
- **2026-04-12** — Hugging Face Space 演示上线：<https://huggingface.co/spaces/limuloo1999/RefineAnything>。
- **2026-04-09** — Hugging Face 发布模型检查点：<https://huggingface.co/limuloo1999/RefineAnything>。
- **2026-04-09** — 发布推理脚本。
- **2026-04-08** — 添加文档框架；**本月内发布代码**（推理脚本、环境及检查点链接将附于此处）。
- **待定** — 检查点及训练/评估资源将于最终确定后公布。

---

## 亮点

- **区域精确细化** — 明确的区域提示（涂鸦或边框）引导编辑至目标区域。
- **基于参考与无参考** — 可选参考图像辅助局部细节恢复。
- **严格背景保护** — 编辑仅限目标区域，训练强调边界无缝连接。

---

## 对比

![无参考定性对比](https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/qualitative_free.png)

![Reference-based qualitative comparisons](https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/qualitative_reference.png)

---

## Installation

```bash
pip install -r requirement.txt
```

> **重要 — 请精确固定这些版本。** RefineAnything 对底层库中的微小数值差异非常敏感。请**严格安装**以下版本；使用更新或更旧的版本可能导致细化区域出现明显的色彩偏差等问题。
>
> ```
> diffusers==0.36.0
> transformers==4.55.0
> safetensors==0.5.3
> peft==0.17.0
> ```

---

## 环境说明

我们观察到 `diffusers` / `transformers` / `safetensors` / `peft` 版本不匹配时，即使其他条件相同，也可能在细化区域引入**色彩偏差**。以下示例使用提示语 *“remove the hand”*：

<table>
<tr>
<td align="center"><b>输入（遮罩区域 = 手）</b></td>
<td align="center"><b>正确环境</b></td>
<td align="center"><b>错误环境（色彩偏差）</b></td>
</tr>
<tr>
<td><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/env_check_input.png" width="100%"></td>
<td><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/correct_env_result.png" width="100%"></td>
<td><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/wrong_env_result.png" width="100%"></td>
</tr>
</table>

如果输出显示遮罩内存在轻微色彩或色调不匹配，而图像其他部分正常，首先应检查您的软件包版本。

---

## 快速开始

运行 RefineAnything 仅需**三个**参数：

| 参数 | 说明 |
|----------|-------------|
| `--input` | 源图像 |
| `--mask` | 二值掩码（白色 = 需要细化的区域） |
| `--prompt` | 需要细化的内容 |
| `--ref` | *(可选)* 用于引导细化的参考图像 |

---

### 演示 1 — 基于参考的标志细化

使用参考图像细化枕头上模糊的标志。

```bash
python scripts/fast_inference.py \
    --input  src/input1.png \
    --mask   src/mask1.png \
    --prompt "Refine the LOGO." \
    --ref    src/ref1.png \
    --output output/demo1.png
```
<table>
<tr>
<td align="center"><b>输入</b></td>
<td align="center"><b>参考</b></td>
<td align="center"><b>提示</b></td>
</tr>
<tr>
<td><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/demo1_input_zoom.jpg" width="100%"></td>
<td><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/src/ref1.png" width="100%"></td>
<td><i>“优化LOGO。”</i></td>
</tr>
<tr>
<td align="center" colspan="3"><b>输出</b></td>
</tr>
<tr>
<td colspan="3"><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/demo1_output_zoom.jpg" width="100%"></td>
</tr>
</table>

---

### 演示2 — 无参考文本优化

优化建筑招牌上的模糊中文文本 — 无需参考图片。


```bash
python scripts/fast_inference.py \
    --input  src/input2.png \
    --mask   src/mask2.png \
    --prompt "refine the text '鼎好商城'" \
    --output output/demo2.png
```

<table>
<tr>
<td align="center"><b>输入</b></td>
<td align="center"><b>提示词</b></td>
</tr>
<tr>
<td><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/demo2_input_zoom.jpg" width="100%"></td>
<td><i>“润色文字‘鼎好商城’”</i></td>
</tr>
<tr>
<td align="center" colspan="2"><b>输出</b></td>
</tr>
<tr>
<td colspan="2"><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/demo2_output_zoom.jpg" width="100%"></td>
</tr>
</table>

---

## 本地 Gradio 演示

我们还提供了基于 Gradio 的网页界面，支持交互式测试。您可以在浏览器中刷选区域、上传参考图像，并调整所有推理参数。

```bash
python app.py
```

然后在浏览器中打开 `http://localhost:7860`。应用程序将在首次启动时自动从 Hugging Face 下载基础模型（`Qwen/Qwen-Image-Edit-2511`）和 RefineAnything LoRA。

您可以通过 `MODEL_DIR` 环境变量指定自定义的基础模型路径：

```bash
MODEL_DIR=/path/to/local/Qwen-Image-Edit-2511 python app.py
```

**Gradio 演示的特点：**
- **刷子选择**：直接在源图像上绘制以定义细化区域。
- **可选参考图像**：上传第二张图像，并可选择性地刷选特定参考区域。
- **焦点裁剪**：自动裁剪并放大编辑区域以获得更高细节保真度，然后无缝合成回去。
- **Lightning LoRA**：一键切换，实现更少步骤的更快推理。
- **前后滑块**：即时比较输入和输出。

---

## 引用

如果您使用此仓库，请引用：

```bibtex
@article{zhou2026refineanything,
  title={RefineAnything: Multimodal Region-Specific Refinement for Perfect Local Details},
  author={Zhou, Dewei and Li, You and Yang, Zongxin and Yang, Yi},
  journal={arXiv preprint arXiv:2604.06870},
  year={2026}
}
```

---

## 致谢与许可

RefineAnything 建立在更广泛的扩散和多模态生态系统的思想和组件之上（包括 **Qwen2.5-VL**、**Qwen-Image** 以及带有 **VAE** + **MMDiT** 的潜在扩散）。基础模型权重和 API 条款受各自许可协议约束—**在重新分发检查点或派生权重前请核实合规性**。

仓库 **代码许可**：*待定*（例如 Apache-2.0 或 MIT）—在开源实现时请设置 `LICENSE`。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-29

---
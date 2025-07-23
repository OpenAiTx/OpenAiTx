
# FastVLM：面向视觉语言模型的高效视觉编码

这是
**[FastVLM：面向视觉语言模型的高效视觉编码](https://www.arxiv.org/abs/2412.13303)（CVPR 2025）** 的官方仓库

[//]: # (![FastViTHD Performance]&#40;docs/acc_vs_latency_qwen-2.png&#41;)
<p align="center">
<img src="https://raw.githubusercontent.com/apple/ml-fastvlm/main/docs/acc_vs_latency_qwen-2.png" alt="准确率与延迟图示" width="400"/>
</p>

### 亮点
* 我们介绍了 FastViTHD，一种新颖的混合视觉编码器，旨在输出更少的令牌并显著减少高分辨率图像的编码时间。  
* 我们最小的版本以 85 倍更快的首次令牌时间（TTFT）和 3.4 倍更小的视觉编码器性能优于 LLaVA-OneVision-0.5B。
* 我们使用 Qwen2-7B 大型语言模型的更大版本优于 Cambrian-1-8B 等最新工作，同时使用单一图像编码器，TTFT 快 7.9 倍。
* 提供演示 iOS 应用，展示我们模型在移动设备上的性能。

<table>
<tr>
    <td><img src="https://raw.githubusercontent.com/apple/ml-fastvlm/main/docs/fastvlm-counting.gif" alt="FastVLM - 计数"></td>
    <td><img src="https://raw.githubusercontent.com/apple/ml-fastvlm/main/docs/fastvlm-handwriting.gif" alt="FastVLM - 手写"></td>
    <td><img src="https://raw.githubusercontent.com/apple/ml-fastvlm/main/docs/fastvlm-emoji.gif" alt="FastVLM - 表情符号"></td>
</tr>
</table>

## 快速开始
我们使用 LLaVA 代码库训练 FastVLM 变体。若要训练或微调您自己的变体，
请按照 [LLaVA](https://github.com/haotian-liu/LLaVA) 代码库中提供的说明操作。
我们提供了使用我们的模型进行推理的说明。

### 安装配置

```bash
conda create -n fastvlm python=3.10
conda activate fastvlm
pip install -e .
```
### 模型库
有关各种评估的详细信息，请参阅我们的[论文](https://www.arxiv.org/abs/2412.13303)。

| 模型          | 阶段  |                                            Pytorch 检查点（链接）                                               |
|:-------------|:-----:|:---------------------------------------------------------------------------------------------------------------:|
| FastVLM-0.5B |   2   | [fastvlm_0.5b_stage2](https://ml-site.cdn-apple.com/datasets/fastvlm/llava-fastvithd_0.5b_stage2.zip) |
|              |   3   | [fastvlm_0.5b_stage3](https://ml-site.cdn-apple.com/datasets/fastvlm/llava-fastvithd_0.5b_stage3.zip) |
| FastVLM-1.5B |   2   | [fastvlm_1.5b_stage2](https://ml-site.cdn-apple.com/datasets/fastvlm/llava-fastvithd_1.5b_stage2.zip) |
|              |   3   | [fastvlm_1.5b_stage3](https://ml-site.cdn-apple.com/datasets/fastvlm/llava-fastvithd_1.5b_stage3.zip)  |
| FastVLM-7B   |   2   | [fastvlm_7b_stage2](https://ml-site.cdn-apple.com/datasets/fastvlm/llava-fastvithd_7b_stage2.zip)  |
|              |   3   | [fastvlm_7b_stage3](https://ml-site.cdn-apple.com/datasets/fastvlm/llava-fastvithd_7b_stage3.zip)  |

要下载所有预训练检查点，请运行以下命令（注意根据您的网络连接速度，这可能需要一些时间，因此等待时不妨喝杯☕️）。


```bash
bash get_models.sh   # Files will be downloaded to `checkpoints` directory.
```
### 使用示例  
要运行PyTorch检查点的推理，请按照以下说明操作

```bash
python predict.py --model-path /path/to/checkpoint-dir \
                  --image-file /path/to/image.png \
                  --prompt "Describe the image."
```
### 在 Apple Silicon 上进行推理
要在 Apple Silicon 上运行推理，pytorch 检查点必须导出为适合在 Apple Silicon 上运行的格式，详细的说明和代码可在 [`model_export`](model_export/) 子文件夹中找到。
请参阅那里的 README 以获取更多详情。

为了方便起见，我们提供了 3 个兼容 Apple Silicon 格式的模型：[fastvlm_0.5b_stage3](https://ml-site.cdn-apple.com/datasets/fastvlm/llava-fastvithd_0.5b_stage3_llm.fp16.zip)，
[fastvlm_1.5b_stage3](https://ml-site.cdn-apple.com/datasets/fastvlm/llava-fastvithd_1.5b_stage3_llm.int8.zip)，
[fastvlm_7b_stage3](https://ml-site.cdn-apple.com/datasets/fastvlm/llava-fastvithd_7b_stage3_llm.int4.zip)。
我们鼓励开发者按照 [`model_export`](model_export/) 中的说明，选择合适的量化级别导出所需的模型。

### 在 Apple 设备上进行推理
要在 iPhone、iPad 或 Mac 等 Apple 设备上运行推理，请参阅 [`app`](app/) 子文件夹了解更多详情。

## 引用
如果您觉得此代码有用，请引用以下论文：



```
@InProceedings{fastvlm2025,
  author = {Pavan Kumar Anasosalu Vasu, Fartash Faghri, Chun-Liang Li, Cem Koc, Nate True, Albert Antony, Gokul Santhanam, James Gabriel, Peter Grasch, Oncel Tuzel, Hadi Pouransari},
  title = {FastVLM: Efficient Vision Encoding for Vision Language Models},
  booktitle = {Proceedings of the IEEE/CVF Conference on Computer Vision and Pattern Recognition (CVPR)},
  month = {June},
  year = {2025},
}
```
## 致谢
我们的代码库是基于多个开源贡献构建的，详细信息请参见 [ACKNOWLEDGEMENTS](ACKNOWLEDGEMENTS)。

## 许可
使用提供的代码前，请查看仓库中的 [LICENSE](LICENSE) 以及发布模型的 [LICENSE_MODEL](LICENSE_MODEL)。




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---
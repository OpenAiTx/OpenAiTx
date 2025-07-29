<div align=center>
  
# [ICCV 2025] *TaylorSeer*: 从重用到预测：用*TaylorSeers*加速扩散模型

<p>
<a href='https://arxiv.org/abs/2503.06923'><img src='https://img.shields.io/badge/Paper-arXiv-red'></a>
<a href='https://taylorseer.github.io/TaylorSeer/'><img src='https://img.shields.io/badge/Project-Page-blue'></a>
</p>

</div>

## 🔥 新闻

* `2025/06/26` 💥💥 TaylorSeer 荣幸被 ICCV 2025 接收！

* `2025/05/03` 🚀🚀 TaylorSeer for HiDream 发布。

* `2025/03/30` 🚀🚀 TaylorSeer for Wan2.1 发布。

* `2025/03/30` 🚀🚀 TaylorSeers 的 Diffusers 推理脚本和适用于多 GPU 并行推理的 xDiT 脚本已正式发布。

* `2025/03/10` 🚀🚀 我们最新工作“从重用到预测：用 TaylorSeers 加速扩散模型”发布！代码已在 [TaylorSeer](https://github.com/Shenyi-Z/TaylorSeer) 开源！TaylorSeer 在 FLUX.1-dev 上支持 4.99 倍无损压缩（延迟加速 3.53 倍），在 HunyuanVideo 上以 5.00 倍压缩率实现高质量加速（延迟加速 4.65 倍）！我们希望 *TaylorSeer* 能推动特征缓存方法范式从重用向预测转变。更多详情请参见我们的最新研究论文。
* `2025/02/19` 🚀🚀 调整后的 **FLUX** ToCa 方案已正式发布，现实现高达 **3.14× 无损加速**（FLOPs）！
* `2025/01/22` 💥💥 ToCa 荣幸被 ICLR 2025 接收！
* `2024/12/29` 🚀🚀 我们发布了关于加速扩散变换器的工作 [DuCa](https://arxiv.org/abs/2412.18911)，免费开源，在 [OpenSora](https://github.com/hpcaitech/Open-Sora) 上实现了近乎无损的 **2.50×** 加速！🎉 **DuCa 还克服了 ToCa 的限制，全面支持 FlashAttention，实现更广泛的兼容性和效率提升。**
* `2024/12/24` 🤗🤗 我们发布了开源仓库“[Awesome-Token-Reduction-for-Model-Compression](https://github.com/xuyang-liu16/Awesome-Token-Reduction-for-Model-Compression)”，收集了近期优秀的令牌缩减论文！欢迎贡献建议！
* `2024/12/10` 💥💥 我们团队最新工作 **SiTo** (https://github.com/EvelynZhang-epiclab/SiTo) 被 **AAAI 2025** 接收。通过自适应 **Token Pruning** 加速扩散模型。
* `2024/07/15` 🤗🤗 我们发布了开源仓库“[Awesome-Generation-Acceleration](https://github.com/xuyang-liu16/Awesome-Generation-Acceleration)”，收集了近期优秀的生成加速论文！欢迎贡献建议！

<details>
  <summary><strong>摘要</strong></summary>

  扩散变换器（DiT）在高保真图像和视频合成领域带来了革命性进展，但其计算需求对于实时应用仍然过于庞大。为解决该问题，提出了特征缓存，通过缓存前一时间步的特征并在后续时间步复用来加速扩散模型。然而，在时间步间隔较大的情况下，扩散模型中特征的相似性显著降低，导致特征缓存引入的误差明显增加，严重影响生成质量。为此，我们提出了 TaylorSeer，首次展示了扩散模型未来时间步的特征可以基于先前时间步的特征值进行预测。基于特征随时间步缓慢且连续变化的事实，TaylorSeer 采用微分方法近似特征的高阶导数，并通过泰勒级数展开预测未来时间步的特征。大量实验证明其在图像和视频合成中的显著效果，尤其在高加速比下表现突出。例如，在 FLUX 上实现了接近无损的 4.99 倍加速，在 HunyuanVideo 上实现了 5.00 倍加速且无额外训练。在 DiT 上，与之前的 SOTA 相比，在 4.53 倍加速下实现了 3.41 更低的 FID。

</details>

## 🧩 社区贡献

感谢所有开源贡献者的大力支持！我们期待您的反馈！

* ComfyUI-TaylorSeer-philipy1219（FLUX 上的 FP8 推理，更多视频模型即将推出）：[ComfyUI-TaylorSeer-philipy1219](https://github.com/philipy1219/ComfyUI-TaylorSeer) 由 [philipy1219](https://github.com/philipy1219) 维护。

## 🛠 安装

``` cmd
git clone https://github.com/Shenyi-Z/TaylorSeer.git
```
## TaylorSeer-FLUX

TaylorSeer 在 FLUX.1-dev 上实现了无损计算压缩 4.99 倍和延迟加速 3.53 倍，综合质量由 [ImageReward](https://github.com/THUDM/ImageReward) 测量。有关运行 TaylorSeer-FLUX 的详情，请参见 [TaylorSeer-FLUX](https://raw.githubusercontent.com/Shenyi-Z/TaylorSeer/main/TaylorSeer-FLUX.md)。

此外，我们提供了 **diffusers 版本** 的推理脚本示例，以及多 GPU 并行的 **xDiT 推理脚本**。您也可以基于它们进行测试，分别位于 [TaylorSeers-Diffusers](./TaylorSeers-Diffusers) 和 [TaylorSeers-xDiT](./TaylorSeers-xDiT)。

## TaylorSeer-HunyuanVideo

TaylorSeer 在 HunyuanVideo 上实现了 5.00 倍的计算压缩和显著的 4.65 倍延迟加速，综合由 [VBench](https://github.com/Vchitect/VBench) 指标测量。与以往方法相比，在加速效率和质量上均有显著提升。有关运行 TaylorSeer-HunyuanVideo 的详情，请参见 [TaylorSeer-HunyuanVideo](https://raw.githubusercontent.com/Shenyi-Z/TaylorSeer/main/TaylorSeer-HunyuanVideo.md)。

此外，我们的脚本还支持 HunyuanVideo 使用 xDiT 实现的多 GPU 并行加速。在此情况下，缓存带来的加速效果与多 GPU 并行加速效果相互独立且相乘，实现极高的加速效果。

## TayorSeer-DiT

TaylorSeer 在基础模型 DiT 上实现了无损计算压缩 2.77 倍，综合通过 FID 等指标评估。其在不同加速比下的性能显著超越以往方法。例如，在极端的 4.53 倍压缩场景下，TaylorSeer 的 FID 从未加速基线的 2.32 仅增加 0.33，达到 2.65，而 ToCa 和 DuCa 在相同条件下的 FID 均高于 6.0。有关运行 TaylorSeer-DiT 的详情，请参见 [TaylorSeer-DiT](https://raw.githubusercontent.com/Shenyi-Z/TaylorSeer/main/TaylorSeer-DiT.md)。

## TaylorSeer-Wan2.1

我们在 Wan2.1 上实现了 TaylorSeer 加速方法，支持多 GPU 并行推理。TaylorSeer-Wan2.1 的安装和推理命令与 Wan2.1 完全兼容。有关运行 TaylorSeer-Wan2.1 的详情，请参见 [TaylorSeer-Wan2.1](https://raw.githubusercontent.com/Shenyi-Z/TaylorSeer/main/TaylorSeer-Wan2.1.md)。

## TaylorSeer-HiDream

最近开源的图像生成模型 **HiDream**，尽管输出质量出色，但因推理时间较长而面临越来越大的加速需求。我们应用 **TaylorSeer** 加速 HiDream 推理，实现了 **72% 的运行时间缩减**。更多详情请参见 [TaylorSeer-HiDream](https://raw.githubusercontent.com/Shenyi-Z/TaylorSeer/main/TaylorSeer-HiDream.md)。

## 👍 致谢

- 感谢 [DiT](https://github.com/facebookresearch/DiT) 的卓越工作及代码库，基于此我们构建了 TaylorSeer-DiT。
- 感谢 [FLUX](https://github.com/black-forest-labs/flux) 的卓越工作及代码库，基于此我们构建了 TaylorSeer-FLUX。
- 感谢 [HiDream](https://github.com/HiDream-ai/HiDream-I1) 的卓越工作及代码库，基于此我们构建了 TaylorSeer-HiDream。
- 感谢 [HunyuanVideo](https://github.com/Tencent/HunyuanVideo) 的卓越工作及代码库，基于此我们构建了 TaylorSeer-HunyuanVideo。
- 感谢 [Wan2.1](https://github.com/Wan-Video/Wan2.1) 的卓越工作及代码库，基于此我们构建了 TaylorSeer-Wan2.1。
- 感谢 [ImageReward](https://github.com/THUDM/ImageReward) 提供文本到图像质量评估。
- 感谢 [VBench](https://github.com/Vchitect/VBench) 提供文本到视频质量评估。

## 📌 引用




```bibtex
@article{TaylorSeer2025,
  title={From Reusing to Forecasting: Accelerating Diffusion Models with TaylorSeers},
  author={Liu, Jiacheng and Zou, Chang and Lyu, Yuanhuiyi and Chen, Junjie and Zhang, Linfeng},
  journal={arXiv preprint arXiv:2503.06923},
  year={2025}
}
```

## :e-mail: 联系方式

如果您有任何问题，请发送邮件至 [`shenyizou@outlook.com`](https://raw.githubusercontent.com/Shenyi-Z/TaylorSeer/main/mailto:shenyizou@outlook.com)。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---
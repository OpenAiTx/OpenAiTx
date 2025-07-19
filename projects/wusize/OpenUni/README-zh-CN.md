<translate-content># OpenUni：统一多模态理解与生成的简单基线

![](https://raw.githubusercontent.com/wusize/OpenUni/main/figures/teaser.png)

> **[OpenUni：统一多模态理解与生成的简单基线](https://arxiv.org/abs/2505.23661)**
>
> 吴思泽，吴中华，龚泽锐，陶清怡，金晟，李琴悦，李伟，卢陈昌
>
> [![报告](https://img.shields.io/badge/arXiv-2505.23661-b31b1b.svg)](docs/report.pdf)
> [![引用](https://img.shields.io/badge/Cite-BibTeX-blue)](https://github.com/wusize/OpenUni?tab=readme-ov-file#-citation)

## 简介

这是一个正在建设中的仓库，名为 OpenUni，是 [MetaQuery](https://xichenpan.com/metaquery) 的开源版本，用于统一多模态理解与生成。通过极简的架构选择，我们展示了 OpenUni 可以：1）生成高质量且符合指令的图像，2）在 GenEval、DPG-Bench 和 WISE 等标准基准测试中取得卓越表现，且仅激活 1.1B 和 3.1B 参数。目前，我们提供了三种模型变体：OpenUni-B-512、OpenUni-L-512 和 OpenUni-L-1024。提供了预训练和微调的检查点。

## 🔥 模型库

| 模型名称 | 图像尺寸 | MLMM 模型 | 扩散模型 | 预训练 | 微调 |
|------------|------------|------------|-----------------|-------------|------------|
| OpenUni-B-512 | 512×512 | [InternVL3-1B](https://huggingface.co/OpenGVLab/InternVL3-1B) | [SANA-0.6B-512px](https://huggingface.co/Efficient-Large-Model/Sana_600M_512px_diffusers) | [链接](https://huggingface.co/wusize/openuni/blob/main/openuni_b_internvl3_1b_sana_0_6b_512_hf_text2image23m.pth) | [链接](https://huggingface.co/wusize/openuni/blob/main/openuni_b_internvl3_1b_sana_0_6b_512_hf_blip3o60k.pth) |
| OpenUni-L-512 | 512×512 | [InternVL3-2B](https://huggingface.co/OpenGVLab/InternVL3-2B) | [SANA-1.6B-512px](https://huggingface.co/Efficient-Large-Model/Sana_1600M_512px_diffusers) | [链接](https://huggingface.co/wusize/openuni/blob/main/openuni_l_internvl3_2b_sana_1_6b_512_hf_text2image23m.pth) | [链接](https://huggingface.co/wusize/openuni/blob/main/openuni_l_internvl3_2b_sana_1_6b_512_hf_blip3o60k.pth) |
| OpenUni-L-1024 | 1024×1024 | [InternVL3-2B](https://huggingface.co/OpenGVLab/InternVL3-2B) | [SANA1.5-1.6B-1024px](https://huggingface.co/Efficient-Large-Model/SANA1.5_1.6B_1024px_diffusers) | [链接](https://huggingface.co/wusize/openuni/blob/main/openuni_l_internvl3_2b_sana_1_6b_512_hf_text2image23m.pth) | [链接](https://huggingface.co/wusize/openuni/blob/main/openuni_l_internvl3_2b_sana_1_6b_1024_hf_blip3o60k.pth) |

## 环境</translate-content>





```
mmengine
xtuner
transformers
torch
flash_attn
```
## 文本到图像

请从 🤗[wusize/openuni](https://huggingface.co/wusize/openuni) 下载我们发布的模型权重。建议使用以下命令下载检查点文件



```bash
# pip install -U "huggingface_hub[cli]"
huggingface-cli download wusize/openuni  --local-dir checkpoints --repo-type model
```

```text
OpenUni/
├── checkpoints
    ├── openuni_b_internvl3_1b_sana_0_6b_512_hf_blip3o60k.pth
    ├── openuni_b_internvl3_1b_sana_0_6b_512_hf_text2image23m.pth
    ├── openuni_l_internvl3_2b_sana_1_6b_1024_hf_blip3o60k.pth
    ├── openuni_l_internvl3_2b_sana_1_6b_1024_hf_text2image23m.pth
    ├── openuni_l_internvl3_2b_sana_1_6b_512_hf_blip3o60k.pth
    ├── openuni_l_internvl3_2b_sana_1_6b_512_hf_text2image23m.pth
```
### 推理
请参考 [docs/INFERENCE.md](https://raw.githubusercontent.com/wusize/OpenUni/main/docs/INFERENCE.md)。

### 评估
请参考 [docs/EVALUATION.md](https://raw.githubusercontent.com/wusize/OpenUni/main/docs/EVALUATION.md)。

### 训练

请参考 [docs/DATASETS.md](https://raw.githubusercontent.com/wusize/OpenUni/main/docs/DATASETS.md) 和 [docs/datasets](docs/datasets) 来准备数据集。获取数据集后，
请按照 [docs/TRAIN.md](https://raw.githubusercontent.com/wusize/OpenUni/main/docs/TRAIN.md) 中的说明启动训练脚本。

## 📚 引用

如果您发现 OpenUni 对您的研究或应用有帮助，请使用以下 BibTeX 引用我们的论文：


```bibtex
@article{wu2025openuni,
      title={OpenUni: A Simple Baseline for Unified Multimodal Understanding and Generation}, 
      author={Size Wu and Zhonghua Wu and Zerui Gong and Qingyi Tao and Sheng Jin and Qinyue Li and Wei Li and Chen Change Loy},
      year={2025},
      eprint={2505.23661},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2505.23661}, 
}
```
## 📜 许可协议  
本项目基于 [NTU S-Lab License 1.0](LICENSE) 许可协议。  

## 🙏 致谢  
本项目基于以下开创性工作构建：  
- [SANA](https://github.com/NVlabs/Sana)：我们采用 SANA 作为扩散模块，考虑到其高效性和强大性能。  
- [InternVL3](https://github.com/OpenGVLab/InternVL)：我们使用最新的 InternVL3 作为基础多模态大语言模型。  
- [MetaQuery](https://xichenpan.com/metaquery)：OpenUni 灵感来源于 MetaQuery，是该工作的开源实现。  
- [BLIP3-o](https://github.com/JiuhaiChen/BLIP3o)：感谢 BLIP3-o 团队发布了宝贵的高质量调优数据集。




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---
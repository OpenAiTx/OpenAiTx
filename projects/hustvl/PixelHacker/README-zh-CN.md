<div align="center">
    <img src="https://raw.githubusercontent.com/hustvl/PixelHacker/main/./assets/LOGO.png" width="280px"></img>
</div>
<div align="center">
    <img src="https://raw.githubusercontent.com/hustvl/PixelHacker/main/./assets/Typing_re.gif" width="320px"></img>
</div>

<div align="center">
<h2>PixelHacker：具有结构和语义一致性的图像修复</h2>

**_在Places2、CelebA-HQ和FFHQ上的SOTA性能 & 卓越的结构和语义一致性_**

[徐子阳](https://ziyangxu.top)<sup>1</sup>，[段康生](https://github.com/AnduinD)<sup>1</sup>，申晓磊<sup>2</sup>，丁志锋<sup>2</sup>，[刘文宇](http://eic.hust.edu.cn/professor/liuwenyu)<sup>1</sup>，阮晓虎<sup>2</sup>，  
[陈晓新](https://scholar.google.com/citations?hl=zh-CN&user=SI_oBwsAAAAJ)<sup>2</sup>，[王行刚](https://xwcv.github.io)<sup>1 :email:</sup>

(<sup>:email:</sup>) 通讯作者。

<sup>1</sup> 华中科技大学。 <sup>2</sup> VIVO AI 实验室。  

[![arxiv](https://img.shields.io/badge/Paper-arXiv-orange)](https://arxiv.org/abs/2504.20438) [![license](https://img.shields.io/badge/License-Apache_2.0-blue)](LICENSE) [![Project](https://img.shields.io/badge/Project-https://hustvl.github.io/PixelHacker-purple)](https://hustvl.github.io/PixelHacker) [![Demo](https://img.shields.io/badge/Demo-Comming_Soon-b687f8)]()
</div>

<img src="https://raw.githubusercontent.com/hustvl/PixelHacker/main/./assets/Pipeline.png"></img>

## 🌟亮点
* **潜类别引导（LCG）**：简单而有效的修复范式，具备卓越的结构和语义一致性。让我们推动修复研究，挑战更复杂的场景！
* **PixelHacker**：基于扩散的修复模型，采用LCG训练，在多个自然场景（Places2）和人脸场景（CelebA-HQ和FFHQ）基准上超越SOTA性能！
* **全面的SOTA性能**：
    * **Places2**（自然场景）
        * 在512分辨率下，使用含40-50%掩码区域的1万张测试集图像评估，PixelHacker取得最佳表现，FID为**8.59**，LPIPS为**0.2026**。
        * 在512分辨率下，使用含大、小掩码设置的3.65万张验证集图像评估，PixelHacker在**FID（大：2.05，小：0.82）**和**U-IDS（大：36.07，小：42.21）**上取得最佳表现，在**LPIPS（大：0.169，小：0.088）**上取得第二好表现。
        * 在256和512分辨率下，使用高度随机掩码策略的验证集图像评估，PixelHacker在512分辨率下取得最佳表现，FID为**5.75**，LPIPS为**0.305**，在256分辨率下取得第二好表现，FID为**9.25**，LPIPS为**0.367**。
    * **CelebA-HQ**（人脸场景）
        * 在512分辨率下评估，PixelHacker取得最佳表现，FID为**4.75**，LPIPS为**0.115**。
    * **FFHQ**（人脸场景）
        * 在256分辨率下评估，PixelHacker取得最佳表现，FID为**6.35**，LPIPS为**0.229**。

## 🔥更新

* **`2025年5月20日`**：🔥 我们已发布[代码](https://github.com/hustvl/PixelHacker)和[权重](https://huggingface.co/hustvl/PixelHacker/tree/main)。权重包括预训练及所有微调版本，每个仅0.8B参数。欢迎体验！
* **`2025年5月1日`**：🔥 我们已发布[项目页面](https://hustvl.github.io/PixelHacker)，包含63+自然及人脸场景演示。玩得开心！🤗
* **`2025年4月30日`：** 🔥 我们已发布PixelHacker的[arXiv论文](https://arxiv.org/abs/2504.20438)。代码和项目页面即将发布。

## 🏕️自然场景性能

<div align="center">
<img src="https://raw.githubusercontent.com/hustvl/PixelHacker/main/./assets/Demo1.gif" width="360px"></img>
</div>

<img src="https://raw.githubusercontent.com/hustvl/PixelHacker/main/./assets/Cover.png"></img>

<img src="https://raw.githubusercontent.com/hustvl/PixelHacker/main/./assets/Natural-Scene.png"></img>

## 🤗人脸场景性能
<div align="center">
<img src="https://raw.githubusercontent.com/hustvl/PixelHacker/main/./assets/Demo2.gif" width="360px"></img>
</div>

<img src="https://raw.githubusercontent.com/hustvl/PixelHacker/main/./assets/Human-Face.png"></img>

## 📦环境配置
* torch 2.3.0
* transformers 4.40.0
* diffusers 0.30.2
* 详细Python库依赖见'requirements.txt'文件

```shell
conda create -n pixelhacker python=3.10
conda activate pixelhacker
# cd /xx/xx/PixelHacker
pip install -r requirements.txt
```
## 🗃️模型检查点
* 下载[VAE](https://huggingface.co/hustvl/PixelHacker/tree/main/vae)的检查点并放入 ../PixelHacker/vae。

* 下载[预训练版本](https://huggingface.co/hustvl/PixelHacker/tree/main/pretrained)、[微调版本 (places2)](https://huggingface.co/hustvl/PixelHacker/tree/main/ft_places2)、[微调版本 (celeba-hq)](https://huggingface.co/hustvl/PixelHacker/tree/main/ft_celebahq)、[微调版本 (ffhq)](https://huggingface.co/hustvl/PixelHacker/tree/main/ft_ffhq)的检查点并放入 ../PixelHacker/weight。

* 最后，详细的组织形式如下：

```shell
├── PixelHacker
│    ├── weight
│        ├── pretrained
│            ├── diffusion_pytorch_model.bin
│        ├── ft_places2
│            ├── diffusion_pytorch_model.bin
│        ├── ft_celebahq
│            ├── diffusion_pytorch_model.bin
│        ├── ft_ffhq
│            ├── diffusion_pytorch_model.bin
│    ├── vae
│        ├── config.json
│        ├── diffusion_pytorch_model.bin
│    ├── ...
```
## 🔮推理
你可以直接运行以下代码来获得示例图像-掩码对的修补结果，结果将生成在 ../PixelHacker/outputs 中。  
如果你想对自定义数据进行推理，只需将图像和掩码以相同的名字分别放置在 ../PixelHacker/imgs 和 ../PixelHacker/masks 中，  
然后同样运行以下代码。
```shell
python infer_pixelhacker.py \
--config config/PixelHacker_sdvae_f8d4.yaml \
--weight weight/ft_places/diffusion_pytorch_model.bin
```


## 🎓Citation

```shell
@misc{xu2025pixelhacker,
      title={PixelHacker: Image Inpainting with Structural and Semantic Consistency}, 
      author={Ziyang Xu and Kangsheng Duan and Xiaolei Shen and Zhifeng Ding and Wenyu Liu and Xiaohu Ruan and Xiaoxin Chen and Xinggang Wang},
      year={2025},
      eprint={2504.20438},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2504.20438}, 
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---
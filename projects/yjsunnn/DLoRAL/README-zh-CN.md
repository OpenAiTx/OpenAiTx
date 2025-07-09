<div align="center">
<h2>一步扩散：细节丰富且时序一致的视频超分辨率</h2>

[Yujing Sun](https://yjsunnn.github.io/)<sup>1,2, *</sup> | 
[Lingchen Sun](https://scholar.google.com/citations?hl=zh-CN&tzom=-480&user=ZCDjTn8AAAAJ)<sup>1,2, *</sup> | 
[Shuaizheng Liu](https://scholar.google.com/citations?user=wzdCc-QAAAAJ&hl=en)<sup>1,2</sup> | 
[Rongyuan Wu](https://scholar.google.com/citations?user=A-U8zE8AAAAJ&hl=zh-CN)<sup>1,2</sup> | 
[Zhengqiang Zhang](https://scholar.google.com.tw/citations?user=UX26wSMAAAAJ&hl=en)<sup>1,2</sup> | 
[Lei Zhang](https://www4.comp.polyu.edu.hk/~cslzhang)<sup>1,2</sup>

<sup>1</sup>香港理工大学，<sup>2</sup>OPPO研究院
</div>

<div>
    <h4 align="center">
        <a href="https://yjsunnn.github.io/DLoRAL-project/" target='_blank'>
        <img src="https://img.shields.io/badge/💡-项目主页-gold">
        </a>
        <a href="https://arxiv.org/pdf/2506.15591" target='_blank'>
        <img src="https://img.shields.io/badge/arXiv-2312.06640-b31b1b.svg">
        </a>
        <a href="https://www.youtube.com/embed/Jsk8zSE3U-w?si=jz1Isdzxt_NqqDFL&vq=hd1080" target='_blank'>
        <img src="https://img.shields.io/badge/演示视频-%23FF0000.svg?logo=YouTube&logoColor=white">
        </a>
        <a href="https://www.youtube.com/embed/xzZL8X10_KU?si=vOB3chIa7Zo0l54v" target="_blank">
        <img src="https://img.shields.io/badge/2分钟讲解-brightgreen?logo=YouTube&logoColor=white">
        </a>
        </a>
        <a href="https://github.com/yjsunnn/Awesome-video-super-resolution-diffusion" target="_blank">
        <img src="https://img.shields.io/badge/GitHub-Awesome--VSR--Diffusion-181717.svg?logo=github&logoColor=white">
        </a>
<!--         <a href="https://www.youtube.com/embed/Jsk8zSE3U-w?si=jz1Isdzxt_NqqDFL&vq=hd1080" target='_blank'>
        <img src="https://img.shields.io/badge/1--Min%20Algorithm%20Explainer-%23FF0000.svg?logo=YouTube&logoColor=white">
        </a> -->
        <a href="https://github.com/yjsunnn/DLoRAL" target='_blank' style="text-decoration: none;"><img src="https://visitor-badge.laobi.icu/badge?page_id=yjsunnn/DLoRAL"></a>
    </h4>
</div>

<p align="center">

<img src="https://raw.githubusercontent.com/yjsunnn/DLoRAL/main/assets/visual_results.svg" alt="视觉效果">

</p>

## ⏰ 更新

- **2025.07.08**：推理代码和预训练权重已开放。
- **2025.06.24**：项目页面已上线，包含简短的2分钟讲解视频、更多可视化结果及相关研究。
- **2025.06.17**：代码仓库已发布。

:star: 如果 DLoRAL 对您的视频或项目有帮助，请为本仓库点个星。谢谢！:hugs:

😊 您可能还想了解我们的相关工作：

1. **OSEDiff (NIPS2024)** [论文](https://arxiv.org/abs/2406.08177) | [代码](https://github.com/cswry/OSEDiff/)  

   已应用于 OPPO Find X8 系列的实时图像超分算法。

2. **PiSA-SR (CVPR2025)** [论文](https://arxiv.org/pdf/2412.03017) | [代码](https://github.com/csslc/PiSA-SR) 

   图像超分中 Dual-LoRA 范式的开创性探索。

3. **Awesome Diffusion Models for Video Super-Resolution** [仓库](https://github.com/yjsunnn/Awesome-video-super-resolution-diffusion)

   基于扩散模型的视频超分辨率（VSR）资源精选列表。
## 👀 待办事项
- [x] 发布推理代码。
- [ ] 提供便捷测试的 Colab 和 Huggingface 界面（即将上线！）。
- [ ] 发布训练代码。
- [ ] 发布训练数据。


## 🌟 框架概览

<p align="center">

<img src="https://raw.githubusercontent.com/yjsunnn/DLoRAL/main/assets/pipeline.svg" alt="DLoRAL Framework">

</p>

**训练**：采用动态双阶段训练方案，交替优化时序连贯性（一致性阶段）和高频空间细节（增强阶段），通过平滑损失插值确保训练过程的稳定性。

**推理**：在推理阶段，将 C-LoRA 和 D-LoRA 合并到冻结的扩散 UNet 中，实现对低质量输入的一步高质量增强。
## 🔧 依赖项与安装

1. 克隆仓库
    ```bash
    git clone https://github.com/yjsunnn/DLoRAL.git
    cd DLoRAL
    ```

2. 安装依赖包
    ```bash
    conda create -n DLoRAL python=3.10 -y
    conda activate DLoRAL
    pip install -r requirements.txt
    ```

3. 下载模型  
#### 依赖模型
* [SD21 Base](https://huggingface.co/stabilityai/stable-diffusion-2-1-base) --> 放入 **/path/to/DLoRAL/preset_models/stable-diffusion-2-1-base**
* [Bert-Base](https://huggingface.co/google-bert/bert-base-uncased) --> 放入 **/path/to/DLoRAL/preset_models/bert-base-uncased**
* [RAM](https://huggingface.co/spaces/xinyu1205/recognize-anything/blob/main/ram_swin_large_14m.pth) --> 放入 **/path/to/DLoRAL/preset/models/ram_swin_large_14m.pth**
* [DAPE](https://drive.google.com/file/d/1KIV6VewwO2eDC9g4Gcvgm-a0LDI7Lmwm/view?usp=drive_link) --> 放入 **/path/to/DLoRAL/preset/models/DAPE.pth**
* [预训练权重](https://drive.google.com/file/d/1vpcaySpRx_K-tXq2D2EBqFZ-03Foky8G/view?usp=sharing) --> 放入 **/path/to/DLoRAL/preset/models/checkpoints/model.pkl**

每个路径可根据自身需求进行修改，相应的更改也应应用到命令行和代码中。
## 🖼️ 快速推理
用于真实世界视频超分辨率：

```
python src/test_DLoRAL.py     \
--pretrained_model_path /path/to/stable-diffusion-2-1-base     \
--ram_ft_path /path/to/DAPE.pth     \
--ram_path '/path/to/ram_swin_large_14m.pth'     \
--merge_and_unload_lora False     \
--process_size 512     \
--pretrained_model_name_or_path '/path/to/stable-diffusion-2-1-base'     \
--vae_encoder_tiled_size 4096     \
--load_cfr     \
--pretrained_path /path/to/model_checkpoint.pkl     \
--stages 1     \
-i /path/to/input_videos/     \
-o /path/to/results
```

### 引用
如果我们的代码对您的研究或工作有所帮助，请考虑引用我们的论文。
以下是 BibTeX 参考文献：

```
@misc{sun2025onestepdiffusiondetailrichtemporally,
      title={One-Step Diffusion for Detail-Rich and Temporally Consistent Video Super-Resolution}, 
      author={Yujing Sun and Lingchen Sun and Shuaizheng Liu and Rongyuan Wu and Zhengqiang Zhang and Lei Zhang},
      year={2025},
      eprint={2506.15591},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2506.15591}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---
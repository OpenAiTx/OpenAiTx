<div align="center">
<h2>通过迁移VAE训练实现细节保留的真实世界图像超分辨率</h2>

🚩 已被ICCV2025接受

[易巧思](https://dblp.org/pid/249/8335.html)<sup>1,2</sup>
| [李帅](https://scholar.google.com/citations?hl=zh-CN&user=Bd73ldQAAAAJ)<sup>1</sup>
| [吴荣元](https://scholar.google.com/citations?user=A-U8zE8AAAAJ&hl=zh-CN)<sup>1,2</sup>
| [孙凌辰](https://scholar.google.com/citations?hl=zh-CN&tzom=-480&user=ZCDjTn8AAAAJ)<sup>1,2</sup>
| [吴宇辉](https://dblp.org/pid/41/915-1.html)<sup>1,2</sup>
| [张磊](https://www4.comp.polyu.edu.hk/~cslzhang)<sup>1,2</sup>

<sup>1</sup>香港理工大学, <sup>2</sup>OPPO研究院
</div>

[![](https://img.shields.io/badge/ArXiv%20-Paper-b31b1b?logo=arxiv&logoColor=red)](https://arxiv.org/pdf/2507.20291)&nbsp; [![weights](https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-model%20weights-blue)](https://huggingface.co/Joypop/TVTSR/tree/main)


## ⏰ 更新
- **2025.7.29**：论文已发布于[ArXiv](https://arxiv.org/pdf/2507.20291)。
- **2025.7.28**：训练代码和测试代码已发布。
- **2025.7.24**：仓库已发布。

:star: 如果TVT对您的图像或项目有帮助，请帮忙给这个仓库点个星。谢谢！:hugs:

### 待办事项 
- [x] 发布推理代码。
- [x] 更新训练代码。
- [ ] fp16 VAED4。


## ⚙ 依赖和安装
```shell
## git clone this repository
git clone https://github.com/Joyies/TVT.git
cd TVT


# create an environment
conda create -n TVT python=3.10
conda activate TVT
pip install --upgrade pip
pip install -r requirements.txt
```

## 🏂 快速推理

### 真实世界图像超分辨率

#### 第1步：下载预训练模型
- 从[![weights](https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-SD%202.1%20Base-blue)](https://huggingface.co/Joypop/stable-diffusion-2-1-base)&nbsp;下载预训练的SD-2.1-base模型
- 从[![weights](https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-model%20weights-blue)](https://huggingface.co/Joypop/TVTSR/tree/main)&nbsp;下载模型权重([VAED4](https://huggingface.co/Joypop/TVTSR/tree/main/ckp), [TVT模型](https://huggingface.co/Joypop/TVTSR/tree/main/ckp), [TVTUNet](https://huggingface.co/Joypop/TVTSR/tree/main/ckp), [DAPE](https://huggingface.co/Joypop/TVTSR/tree/main/ckp)，和 [RAM](https://huggingface.co/Joypop/TVTSR/tree/main/ckp))，并将模型权重放入 `ckp/` 文件夹：

#### 第2步：准备测试数据并运行测试命令
您可以修改 input_path 和 output_path 来运行测试命令。input_path 是测试图像的路径，output_path 是输出图像保存的路径。
```
python TVT/inferences/inference.py \
--input_image input_path \
--output_dir output_path \
--pretrained_path ckp/model_TVT.pkl \
--pretrained_model_name_or_path stabilityai/stable-diffusion-2-1-base \
--pretrained_unet_path ckp/TVTUNet \
--vae4d_path ckp/vae.ckpt \
--ram_ft_path ckp/DAPE.pth \
--negprompt 'dotted, noise, blur, lowres, smooth' \
--prompt 'clean, high-resolution, 8k' \
--upscale 4 \
--time_step 1
```
or 
```
bash scripts/test/test_realsr.sh
```
我们还提供了切片代码以节省推理时的GPU内存。您可以运行该命令，并根据设备的显存调整切片大小和步幅。
```
python TVT/inferences/inference_tile.py \
--input_image input_path \
--output_dir output_path \
--pretrained_path ckp/model_TVT.pkl \
--pretrained_model_name_or_path stabilityai/stable-diffusion-2-1-base \
--pretrained_unet_path ckp/TVTUNet \
--vae4d_path ckp/vae.ckpt \
--ram_ft_path ckp/DAPE.pth \
--negprompt 'dotted, noise, blur, lowres, smooth' \
--prompt 'clean, high-resolution, 8k' \
--upscale 4 \
--time_step 1 \
--tiled_size 96 \
--tiled_overlap 32
```

## 🚄 训练阶段

### 在 OpenImage 数据集和 LSDIR 数据集上训练 VAED4。
#### 第一步：准备训练数据
下载 [OpenImage 数据集](https://storage.googleapis.com/openimages/web/index.html) 和 [LSIDR 数据集](https://github.com/ofsoundof/LSDIR)。对于 LSDIR 数据集中的每张图像，使用步长为64像素的滑动窗口裁剪多个512×512的图像块；

#### 第二步：训练 VAED4
使用 [LDM 代码](https://github.com/CompVis/latent-diffusion) 来训练 VAED4。 


### 在 Real-ISR 数据集上训练 TVTSR
#### 第一步：准备训练数据

下载 [LSIDR 数据集](https://github.com/ofsoundof/LSDIR) 和前 1 万张 [FFHQ 数据集](https://github.com/NVlabs/ffhq-dataset)。随后对训练数据集进行数据增强。具体来说，对于 LSDIR 数据集中的每张图像，使用步长为64像素的滑动窗口裁剪多个512×512的图像块；对于 FFHQ 数据集，直接将所有图像调整为512×512。

#### 第二步：训练 Real-ISR 模型

1. 下载 [VAED4](https://huggingface.co/Joypop/TVTSR/tree/main/ckp)、[TVTUNet](https://huggingface.co/Joypop/TVTSR/tree/main/ckp) 和 [RAM](https://huggingface.co/Joypop/TVTSR/tree/main/ckp) 模型，并将这些模型放入 `ckp/` 文件夹中。

2. 开始训练。
    ```shell
   accelerate launch --gpu_ids=0,1,2,3, --num_processes=4 TVT/train_TVTSR/train.py \
    --pretrained_model_name_or_path="stabilityai/stable-diffusion-2-1-base" \
    --pretrained_model_name_or_path_vsd="stabilityai/stable-diffusion-2-1-base" \
    --pretrained_unet_path='ckp/TVTUNet' \
    --vae4d_path='ckp/vae.ckpt' \
    --dataset_folder="data_path" \
    --testdataset_folder="test_path" \
    --resolution=512 \
    --learning_rate=5e-5 \
    --train_batch_size=2 \
    --gradient_accumulation_steps=2 \
    --enable_xformers_memory_efficient_attention \
    --eval_freq 500 \
    --checkpointing_steps 500 \
    --mixed_precision='fp16' \
    --report_to "tensorboard" \
    --output_dir="output_path" \
    --lora_rank_unet_vsd=4 \
    --lora_rank_unet=4 \
    --lambda_lpips=2 \
    --lambda_l2=1 \
    --lambda_vsd=1 \
    --lambda_vsd_lora=1 \
    --min_dm_step_ratio=0.25 \
    --max_dm_step_ratio=0.75 \
    --use_vae_encode_lora \
    --align_method="adain" \
    --use_online_deg \
    --deg_file_path="params_TVT.yml" \
    --negative_prompt='painting, oil painting, illustration, drawing, art, sketch, oil painting, cartoon, CG Style, 3D render, unreal engine, blurring, dirty, messy, worst quality, low quality, frames, watermark, signature, jpeg artifacts, deformed, lowres, over-smooth' \
    --test_image_prep='no_resize' \
    --time_step=1 \
    --tracker_project_name "experiment_track_name"
    ```
    or
    ```shell
   bash scripts/train/train.sh
    ```

## 🔗 引用
如果我们的代码对您的研究或工作有所帮助，请考虑引用我们的论文。
以下是BibTeX引用格式：

```
@article{yi2025fine,
  title={Fine-structure Preserved Real-world Image Super-resolution via Transfer VAE Training},
  author={Yi, Qiaosi and Li, Shuai and Wu, Rongyuan and Sun, Lingchen and Wu, Yuhui and Zhang, Lei},
  booktitle={Proceedings of the IEEE/CVF international conference on computer vision},
  year={2025}
}
```

## ©️ 许可证
本项目采用[Apache 2.0 许可证](LICENSE)发布。

## 📧 联系方式
如有任何疑问，请联系：qiaosiyijoyies@gmail.com

## 致谢
本项目基于[diffusers](https://github.com/huggingface/diffusers)、[LDM](https://github.com/CompVis/latent-diffusion)、[OSEDiff](https://github.com/cswry/OSEDiff)和[PiSA-SR](https://github.com/csslc/PiSA-SR)。感谢这些出色的工作。

<details>
<summary>统计信息</summary>

![访客](https://visitor-badge.laobi.icu/badge?page_id=Joyies/TVT)

</details>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-22

---
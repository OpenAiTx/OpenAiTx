<div align="center">
<h2>Fine-structure Preserved Real-world Image Super-resolution via Transfer VAE Training</h2>

🚩 Accepted by ICCV2025

[Qiaosi Yi](https://dblp.org/pid/249/8335.html)<sup>1,2</sup>
| [Shuai Li](https://scholar.google.com/citations?hl=zh-CN&user=Bd73ldQAAAAJ)<sup>1</sup>
| [Rongyuan Wu](https://scholar.google.com/citations?user=A-U8zE8AAAAJ&hl=zh-CN)<sup>1,2</sup>
| [Lingchen Sun](https://scholar.google.com/citations?hl=zh-CN&tzom=-480&user=ZCDjTn8AAAAJ)<sup>1,2</sup>
| [Yuhui Wu](https://dblp.org/pid/41/915-1.html)<sup>1,2</sup>
| [Lei Zhang](https://www4.comp.polyu.edu.hk/~cslzhang)<sup>1,2</sup>

<sup>1</sup>The Hong Kong Polytechnic University, <sup>2</sup>OPPO Research Institute
</div>

[![](https://img.shields.io/badge/ArXiv%20-Paper-b31b1b?logo=arxiv&logoColor=red)](https://arxiv.org/pdf/2507.20291)&nbsp; [![weights](https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-model%20weights-blue)](https://huggingface.co/Joypop/TVTSR/tree/main)


## ⏰ Update
- **2025.7.29**: Paper is released on [ArXiv](https://arxiv.org/pdf/2507.20291).
- **2025.7.28**: The training code and testing code are released.
- **2025.7.24**: The repo is released.

:star: If TVT is helpful to your images or projects, please help star this repo. Thanks! :hugs:

### TODO 
- [x] Release the code for inference.
- [x] Update the code for training.
- [ ] fp16 VAED4.


## ⚙ Dependencies and Installation
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

## 🏂 Quick Inference

### Real-world Image Super-resolution

#### Step 1: Download the pretrained models
- Download the pretrained SD-2.1-base models from [![weights](https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-SD%202.1%20Base-blue)](https://huggingface.co/Joypop/stable-diffusion-2-1-base)&nbsp;
- Download the model weights ([VAED4](https://huggingface.co/Joypop/TVTSR/tree/main/ckp), [TVT model](https://huggingface.co/Joypop/TVTSR/tree/main/ckp), [TVTUNet](https://huggingface.co/Joypop/TVTSR/tree/main/ckp), [DAPE](https://huggingface.co/Joypop/TVTSR/tree/main/ckp), and [RAM](https://huggingface.co/Joypop/TVTSR/tree/main/ckp)) from [![weights](https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-model%20weights-blue)](https://huggingface.co/Joypop/TVTSR/tree/main)&nbsp; and put the model weights in the `ckp/`:

#### Step 2: Prepare testing data and run testing command 
You can modify input_path and output_path to run testing command. The input_path is the path of the test image and the output_path is the path where the output images are saved.
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
We also provide the tile code to save GPU memory during inference. You can run the command and adjust the tile size and stride according to your device's VRAM.
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

## 🚄 Training Phase

### Train VAED4 on the OpenImage dataset and LSDIR dataset.
#### Step1: Prepare training data
Download the [OpenImage dataset](https://storage.googleapis.com/openimages/web/index.html) and [LSIDR dataset](https://github.com/ofsoundof/LSDIR). For each image in the LSDIR dataset, crop multiple 512×512 image patches using a sliding window with a stride of 64 pixels;

#### Step2: Train VAED4
The [LDM code](https://github.com/CompVis/latent-diffusion) is used to train VAED4. 


### Train TVTSR on the Real-ISR datasets
#### Step1: Prepare training data

Download the [LSIDR dataset](https://github.com/ofsoundof/LSDIR) and the first 10k [FFHQ dataset](https://github.com/NVlabs/ffhq-dataset). Subsequently, perform data augmentation on the training dataset. Specifically, for each image in the LSDIR dataset, crop multiple 512×512 image patches using a sliding window with a stride of 64 pixels; for the FFHQ dataset, directly resize all images to 512×512.

#### Step2: Train Real-ISR Model

1. Download [VAED4](https://huggingface.co/Joypop/TVTSR/tree/main/ckp), [TVTUNet](https://huggingface.co/Joypop/TVTSR/tree/main/ckp), and [RAM](https://huggingface.co/Joypop/TVTSR/tree/main/ckp) models, and put these models into `ckp/`. 

2. Start training.
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

## 🔗 Citations
If our code helps your research or work, please consider citing our paper.
The following are BibTeX references:

```
@article{yi2025fine,
  title={Fine-structure Preserved Real-world Image Super-resolution via Transfer VAE Training},
  author={Yi, Qiaosi and Li, Shuai and Wu, Rongyuan and Sun, Lingchen and Wu, Yuhui and Zhang, Lei},
  booktitle={Proceedings of the IEEE/CVF international conference on computer vision},
  year={2025}
}
```

## ©️ License
This project is released under the [Apache 2.0 license](LICENSE).

## 📧 Contact
If you have any questions, please contact: qiaosiyijoyies@gmail.com

## Acknowledgement
This project is based on [diffusers](https://github.com/huggingface/diffusers), [LDM](https://github.com/CompVis/latent-diffusion), [OSEDiff](https://github.com/cswry/OSEDiff) and [PiSA-SR](https://github.com/csslc/PiSA-SR). Thanks for the awesome work. 

<details>
<summary>statistics</summary>

![visitors](https://visitor-badge.laobi.icu/badge?page_id=Joyies/TVT)

</details>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-22

---
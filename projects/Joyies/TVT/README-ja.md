<div align="center">
<h2>転送VAEトレーニングによる微細構造を保持した実世界画像超解像</h2>

🚩 ICCV2025に採択

[Qiaosi Yi](https://dblp.org/pid/249/8335.html)<sup>1,2</sup>
| [Shuai Li](https://scholar.google.com/citations?hl=zh-CN&user=Bd73ldQAAAAJ)<sup>1</sup>
| [Rongyuan Wu](https://scholar.google.com/citations?user=A-U8zE8AAAAJ&hl=zh-CN)<sup>1,2</sup>
| [Lingchen Sun](https://scholar.google.com/citations?hl=zh-CN&tzom=-480&user=ZCDjTn8AAAAJ)<sup>1,2</sup>
| [Yuhui Wu](https://dblp.org/pid/41/915-1.html)<sup>1,2</sup>
| [Lei Zhang](https://www4.comp.polyu.edu.hk/~cslzhang)<sup>1,2</sup>

<sup>1</sup>香港理工大学, <sup>2</sup>OPPOリサーチインスティテュート
</div>

[![](https://img.shields.io/badge/ArXiv%20-Paper-b31b1b?logo=arxiv&logoColor=red)](https://arxiv.org/pdf/2507.20291)&nbsp; [![weights](https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-model%20weights-blue)](https://huggingface.co/Joypop/TVTSR/tree/main)


## ⏰ 更新情報
- **2025.7.29**: 論文を[ArXiv](https://arxiv.org/pdf/2507.20291)に公開しました。
- **2025.7.28**: トレーニングコードとテストコードを公開しました。
- **2025.7.24**: リポジトリを公開しました。

:star: TVTがあなたの画像やプロジェクトに役立つ場合は、このリポジトリにスターをお願いします。ありがとうございます！ :hugs:

### TODO 
- [x] 推論用コードの公開。
- [x] トレーニング用コードの更新。
- [ ] fp16 VAED4。


## ⚙ 依存関係とインストール
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

## 🏂 クイック推論

### 実世界画像超解像

#### ステップ1: 事前学習済みモデルのダウンロード
- [![weights](https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-SD%202.1%20Base-blue)](https://huggingface.co/Joypop/stable-diffusion-2-1-base) から事前学習済みのSD-2.1-baseモデルをダウンロードします&nbsp;
- [![weights](https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-model%20weights-blue)](https://huggingface.co/Joypop/TVTSR/tree/main) からモデル重み（[VAED4](https://huggingface.co/Joypop/TVTSR/tree/main/ckp)、[TVT model](https://huggingface.co/Joypop/TVTSR/tree/main/ckp)、[TVTUNet](https://huggingface.co/Joypop/TVTSR/tree/main/ckp)、[DAPE](https://huggingface.co/Joypop/TVTSR/tree/main/ckp)、および [RAM](https://huggingface.co/Joypop/TVTSR/tree/main/ckp)）をダウンロードし、モデル重みを `ckp/` に配置します:

#### ステップ2: テストデータの準備とテストコマンドの実行
input_path と output_path を変更してテストコマンドを実行できます。input_path はテスト画像のパスで、output_path は出力画像が保存されるパスです。
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
また、推論時のGPUメモリ節約のためのタイルコードも提供しています。実行コマンドを実行し、デバイスのVRAMに応じてタイルサイズとストライドを変更できます。
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

## 🚄 トレーニングフェーズ

### OpenImageデータセットおよびLSDIRデータセットでVAED4をトレーニングする。
#### ステップ1: トレーニングデータの準備
[OpenImageデータセット](https://storage.googleapis.com/openimages/web/index.html)および[LSIDRデータセット](https://github.com/ofsoundof/LSDIR)をダウンロードする。LSDIRデータセット内の各画像に対して、ストライド64ピクセルのスライディングウィンドウを使用し、複数の512×512画像パッチをクロップする；

#### ステップ2: VAED4のトレーニング
[ LDMコード](https://github.com/CompVis/latent-diffusion)を使用してVAED4をトレーニングする。 


### Real-ISRデータセットでTVTSRをトレーニングする
#### ステップ1: トレーニングデータの準備

[LSIDRデータセット](https://github.com/ofsoundof/LSDIR)および最初の1万枚の[FFHQデータセット](https://github.com/NVlabs/ffhq-dataset)をダウンロードする。その後、トレーニングデータセットに対してデータ拡張を行う。具体的には、LSDIRデータセットの各画像に対してストライド64ピクセルのスライディングウィンドウを使用し複数の512×512画像パッチをクロップし、FFHQデータセットに対してはすべての画像を直接512×512にリサイズする。

#### ステップ2: Real-ISRモデルのトレーニング

1. [VAED4](https://huggingface.co/Joypop/TVTSR/tree/main/ckp)、[TVTUNet](https://huggingface.co/Joypop/TVTSR/tree/main/ckp)、および[RAM](https://huggingface.co/Joypop/TVTSR/tree/main/ckp)モデルをダウンロードし、これらのモデルを`ckp/`に配置する。 

2. トレーニングを開始する。
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
もし私たちのコードがあなたの研究や仕事に役立った場合は、ぜひ私たちの論文を引用してください。
以下はBibTeXの参考文献です：

```
@article{yi2025fine,
  title={Fine-structure Preserved Real-world Image Super-resolution via Transfer VAE Training},
  author={Yi, Qiaosi and Li, Shuai and Wu, Rongyuan and Sun, Lingchen and Wu, Yuhui and Zhang, Lei},
  booktitle={Proceedings of the IEEE/CVF international conference on computer vision},
  year={2025}
}
```

## ©️ ライセンス
このプロジェクトは[Apache 2.0 ライセンス](LICENSE)の下で公開されています。

## 📧 お問い合わせ
ご質問がある場合は、次のアドレスまでご連絡ください：qiaosiyijoyies@gmail.com

## 謝辞
このプロジェクトは[diffusers](https://github.com/huggingface/diffusers)、[LDM](https://github.com/CompVis/latent-diffusion)、[OSEDiff](https://github.com/cswry/OSEDiff)、および[PiSA-SR](https://github.com/csslc/PiSA-SR)に基づいています。素晴らしい作品に感謝します。

<details>
<summary>統計情報</summary>

![訪問者](https://visitor-badge.laobi.icu/badge?page_id=Joyies/TVT)

</details>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-22

---
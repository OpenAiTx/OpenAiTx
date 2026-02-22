<div align="center">
<h2>Super-résolution d’images réelles avec préservation de la structure fine via un entraînement VAE par transfert</h2>

🚩 Accepté par ICCV2025

[Qiaosi Yi](https://dblp.org/pid/249/8335.html)<sup>1,2</sup>
| [Shuai Li](https://scholar.google.com/citations?hl=zh-CN&user=Bd73ldQAAAAJ)<sup>1</sup>
| [Rongyuan Wu](https://scholar.google.com/citations?user=A-U8zE8AAAAJ&hl=zh-CN)<sup>1,2</sup>
| [Lingchen Sun](https://scholar.google.com/citations?hl=zh-CN&tzom=-480&user=ZCDjTn8AAAAJ)<sup>1,2</sup>
| [Yuhui Wu](https://dblp.org/pid/41/915-1.html)<sup>1,2</sup>
| [Lei Zhang](https://www4.comp.polyu.edu.hk/~cslzhang)<sup>1,2</sup>

<sup>1</sup>L’Université Polytechnique de Hong Kong, <sup>2</sup>Institut de Recherche OPPO
</div>

[![](https://img.shields.io/badge/ArXiv%20-Paper-b31b1b?logo=arxiv&logoColor=red)](https://arxiv.org/pdf/2507.20291)&nbsp; [![weights](https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-model%20weights-blue)](https://huggingface.co/Joypop/TVTSR/tree/main)


## ⏰ Mise à jour
- **2025.7.29** : Article publié sur [ArXiv](https://arxiv.org/pdf/2507.20291).
- **2025.7.28** : Le code d’entraînement et de test est publié.
- **2025.7.24** : Le dépôt est publié.

:star: Si TVT vous aide pour vos images ou projets, merci d’étoiler ce dépôt. Merci ! :hugs:

### À FAIRE 
- [x] Publier le code pour l’inférence.
- [x] Mettre à jour le code pour l’entraînement.
- [ ] VAED4 en fp16.


## ⚙ Dépendances et installation
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

## 🏂 Inférence rapide

### Super-résolution d'image réelle

#### Étape 1 : Télécharger les modèles pré-entraînés
- Téléchargez les modèles SD-2.1-base pré-entraînés depuis [![weights](https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-SD%202.1%20Base-blue)](https://huggingface.co/Joypop/stable-diffusion-2-1-base)&nbsp;
- Téléchargez les poids des modèles ([VAED4](https://huggingface.co/Joypop/TVTSR/tree/main/ckp), [modèle TVT](https://huggingface.co/Joypop/TVTSR/tree/main/ckp), [TVTUNet](https://huggingface.co/Joypop/TVTSR/tree/main/ckp), [DAPE](https://huggingface.co/Joypop/TVTSR/tree/main/ckp), et [RAM](https://huggingface.co/Joypop/TVTSR/tree/main/ckp)) depuis [![weights](https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-model%20weights-blue)](https://huggingface.co/Joypop/TVTSR/tree/main)&nbsp; et placez les poids dans le dossier `ckp/` :

#### Étape 2 : Préparez les données de test et lancez la commande de test 
Vous pouvez modifier input_path et output_path pour lancer la commande de test. input_path est le chemin de l'image de test et output_path est le chemin où les images de sortie sont sauvegardées.
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
Nous fournissons également le code de tuiles pour économiser la mémoire GPU lors de l'inférence. Vous pouvez exécuter la commande et modifier la taille des tuiles et le pas en fonction de la VRAM de votre appareil.
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

## 🚄 Phase d'entraînement

### Entraîner VAED4 sur les jeux de données OpenImage et LSDIR.
#### Étape 1 : Préparer les données d'entraînement
Téléchargez le [jeu de données OpenImage](https://storage.googleapis.com/openimages/web/index.html) et le [jeu de données LSIDR](https://github.com/ofsoundof/LSDIR). Pour chaque image du jeu de données LSDIR, découpez plusieurs patches d’image de 512×512 en utilisant une fenêtre glissante avec un pas de 64 pixels ;

#### Étape 2 : Entraîner VAED4
Le [code LDM](https://github.com/CompVis/latent-diffusion) est utilisé pour entraîner VAED4. 


### Entraîner TVTSR sur les jeux de données Real-ISR
#### Étape 1 : Préparer les données d'entraînement

Téléchargez le [jeu de données LSIDR](https://github.com/ofsoundof/LSDIR) et les 10 000 premières images du [jeu de données FFHQ](https://github.com/NVlabs/ffhq-dataset). Ensuite, effectuez une augmentation des données sur le jeu de données d'entraînement. Plus précisément, pour chaque image du jeu LSDIR, découpez plusieurs patches d’image de 512×512 en utilisant une fenêtre glissante avec un pas de 64 pixels ; pour le jeu FFHQ, redimensionnez directement toutes les images à 512×512.

#### Étape 2 : Entraîner le modèle Real-ISR

1. Téléchargez les modèles [VAED4](https://huggingface.co/Joypop/TVTSR/tree/main/ckp), [TVTUNet](https://huggingface.co/Joypop/TVTSR/tree/main/ckp) et [RAM](https://huggingface.co/Joypop/TVTSR/tree/main/ckp), et placez-les dans le dossier `ckp/`. 

2. Lancez l’entraînement.
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
Si notre code aide votre recherche ou votre travail, veuillez envisager de citer notre article.
Voici les références BibTeX :

```
@article{yi2025fine,
  title={Fine-structure Preserved Real-world Image Super-resolution via Transfer VAE Training},
  author={Yi, Qiaosi and Li, Shuai and Wu, Rongyuan and Sun, Lingchen and Wu, Yuhui and Zhang, Lei},
  booktitle={Proceedings of the IEEE/CVF international conference on computer vision},
  year={2025}
}
```

## ©️ Licence
Ce projet est publié sous la [licence Apache 2.0](LICENSE).

## 📧 Contact
Si vous avez des questions, veuillez contacter : qiaosiyijoyies@gmail.com

## Remerciements
Ce projet est basé sur [diffusers](https://github.com/huggingface/diffusers), [LDM](https://github.com/CompVis/latent-diffusion), [OSEDiff](https://github.com/cswry/OSEDiff) et [PiSA-SR](https://github.com/csslc/PiSA-SR). Merci pour ce travail remarquable. 

<details>
<summary>statistiques</summary>

![visiteurs](https://visitor-badge.laobi.icu/badge?page_id=Joyies/TVT)

</details>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-22

---
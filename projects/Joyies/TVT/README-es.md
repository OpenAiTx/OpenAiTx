<div align="center">
<h2>Superresolución de Imágenes del Mundo Real con Preservación de Estructura Fina mediante Entrenamiento VAE por Transferencia</h2>

🚩 Aceptado en ICCV2025

[Qiaosi Yi](https://dblp.org/pid/249/8335.html)<sup>1,2</sup>
| [Shuai Li](https://scholar.google.com/citations?hl=zh-CN&user=Bd73ldQAAAAJ)<sup>1</sup>
| [Rongyuan Wu](https://scholar.google.com/citations?user=A-U8zE8AAAAJ&hl=zh-CN)<sup>1,2</sup>
| [Lingchen Sun](https://scholar.google.com/citations?hl=zh-CN&tzom=-480&user=ZCDjTn8AAAAJ)<sup>1,2</sup>
| [Yuhui Wu](https://dblp.org/pid/41/915-1.html)<sup>1,2</sup>
| [Lei Zhang](https://www4.comp.polyu.edu.hk/~cslzhang)<sup>1,2</sup>

<sup>1</sup>La Universidad Politécnica de Hong Kong, <sup>2</sup>Instituto de Investigación OPPO
</div>

[![](https://img.shields.io/badge/ArXiv%20-Paper-b31b1b?logo=arxiv&logoColor=red)](https://arxiv.org/pdf/2507.20291)&nbsp; [![weights](https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-model%20weights-blue)](https://huggingface.co/Joypop/TVTSR/tree/main)


## ⏰ Actualización
- **2025.7.29**: El artículo fue publicado en [ArXiv](https://arxiv.org/pdf/2507.20291).
- **2025.7.28**: Se liberaron el código de entrenamiento y el código de prueba.
- **2025.7.24**: Se liberó el repositorio.

:star: Si TVT es útil para tus imágenes o proyectos, por favor ayuda a darle estrella a este repositorio. ¡Gracias! :hugs:

### POR HACER
- [x] Publicar el código para inferencia.
- [x] Actualizar el código para entrenamiento.
- [ ] VAED4 en fp16.


## ⚙ Dependencias e Instalación
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

## 🏂 Inferencia Rápida

### Superresolución de Imágenes del Mundo Real

#### Paso 1: Descargar los modelos preentrenados
- Descargue los modelos preentrenados SD-2.1-base desde [![weights](https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-SD%202.1%20Base-blue)](https://huggingface.co/Joypop/stable-diffusion-2-1-base)&nbsp;
- Descargue los pesos del modelo ([VAED4](https://huggingface.co/Joypop/TVTSR/tree/main/ckp), [modelo TVT](https://huggingface.co/Joypop/TVTSR/tree/main/ckp), [TVTUNet](https://huggingface.co/Joypop/TVTSR/tree/main/ckp), [DAPE](https://huggingface.co/Joypop/TVTSR/tree/main/ckp), y [RAM](https://huggingface.co/Joypop/TVTSR/tree/main/ckp)) desde [![weights](https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-model%20weights-blue)](https://huggingface.co/Joypop/TVTSR/tree/main)&nbsp; y coloque los pesos del modelo en `ckp/`:

#### Paso 2: Prepare los datos de prueba y ejecute el comando de prueba 
Puede modificar input_path y output_path para ejecutar el comando de prueba. input_path es la ruta de la imagen de prueba y output_path es la ruta donde se guardan las imágenes de salida.
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
También proporcionamos el código de mosaico para ahorrar memoria GPU durante la inferencia. Puede ejecutar el comando y cambiar el tamaño del mosaico y el paso según la VRAM de su dispositivo.
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

## 🚄 Fase de Entrenamiento

### Entrenar VAED4 en el conjunto de datos OpenImage y LSDIR.
#### Paso 1: Preparar datos de entrenamiento
Descargue el [conjunto de datos OpenImage](https://storage.googleapis.com/openimages/web/index.html) y el [conjunto de datos LSIDR](https://github.com/ofsoundof/LSDIR). Para cada imagen en el conjunto de datos LSDIR, recorte múltiples parches de imagen de 512×512 usando una ventana deslizante con un paso de 64 píxeles;

#### Paso 2: Entrenar VAED4
El [código LDM](https://github.com/CompVis/latent-diffusion) se utiliza para entrenar VAED4. 


### Entrenar TVTSR en los conjuntos de datos Real-ISR
#### Paso 1: Preparar datos de entrenamiento

Descargue el [conjunto de datos LSIDR](https://github.com/ofsoundof/LSDIR) y los primeros 10k del [conjunto de datos FFHQ](https://github.com/NVlabs/ffhq-dataset). Posteriormente, realice aumento de datos en el conjunto de entrenamiento. Específicamente, para cada imagen en el conjunto LSDIR, recorte múltiples parches de imagen de 512×512 usando una ventana deslizante con un paso de 64 píxeles; para el conjunto FFHQ, redimensione directamente todas las imágenes a 512×512.

#### Paso 2: Entrenar el modelo Real-ISR

1. Descargue los modelos [VAED4](https://huggingface.co/Joypop/TVTSR/tree/main/ckp), [TVTUNet](https://huggingface.co/Joypop/TVTSR/tree/main/ckp) y [RAM](https://huggingface.co/Joypop/TVTSR/tree/main/ckp), y coloque estos modelos en `ckp/`. 

2. Comience el entrenamiento.
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

## 🔗 Citas
Si nuestro código ayuda a su investigación o trabajo, por favor considere citar nuestro artículo.
Las siguientes son referencias en BibTeX:

```
@article{yi2025fine,
  title={Fine-structure Preserved Real-world Image Super-resolution via Transfer VAE Training},
  author={Yi, Qiaosi and Li, Shuai and Wu, Rongyuan and Sun, Lingchen and Wu, Yuhui and Zhang, Lei},
  booktitle={Proceedings of the IEEE/CVF international conference on computer vision},
  year={2025}
}
```

## ©️ Licencia
Este proyecto se publica bajo la [licencia Apache 2.0](LICENSE).

## 📧 Contacto
Si tiene alguna pregunta, por favor contacte a: qiaosiyijoyies@gmail.com

## Agradecimientos
Este proyecto se basa en [diffusers](https://github.com/huggingface/diffusers), [LDM](https://github.com/CompVis/latent-diffusion), [OSEDiff](https://github.com/cswry/OSEDiff) y [PiSA-SR](https://github.com/csslc/PiSA-SR). Gracias por el excelente trabajo. 

<details>
<summary>estadísticas</summary>

![visitors](https://visitor-badge.laobi.icu/badge?page_id=Joyies/TVT)

</details>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-22

---
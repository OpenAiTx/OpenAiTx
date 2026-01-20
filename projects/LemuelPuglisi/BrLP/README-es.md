![brlp](https://raw.githubusercontent.com/LemuelPuglisi/BrLP/main/assets/readme-brlp-v2.png)

<p align="center">
  <a href='https://www.sciencedirect.com/science/article/pii/S1361841525002816'>
    <img src='https://img.shields.io/badge/Journal-PDF-green?style=for-the-badge&logo=adobeacrobatreader&logoWidth=20&logoColor=white&color=94DD15' alt='Paper PDF'>
  </a>
  <a href='https://papers.miccai.org/miccai-2024/paper/0511_paper.pdf'>
    <img src='https://img.shields.io/badge/MICCAI-PDF-green?style=for-the-badge&logo=adobeacrobatreader&logoWidth=20&logoColor=white&color=94DD15' alt='Paper PDF'>
  </a>
  <a href='https://youtu.be/6YKz2MNM4jg?si=nkG21K4lIgLrH-pK'>
    <img src='https://img.shields.io/badge/Video-YouTube-red?style=for-the-badge&logo=youtube&logoColor=white&color=FF3737' alt='Video'>
  </a>
</p>

<h4 align="center">Mejorando modelos de progresión de enfermedades espaciotemporales mediante difusión latente y conocimiento previo</h4>

<h4 align="center"><a href="https://lemuelpuglisi.github.io/">Lemuel Puglisi</a>, <a href="https://profiles.ucl.ac.uk/3589">Daniel C. Alexander</a>, <a href="https://daniravi.wixsite.com/researchblog">Daniele Ravì</a></h4>

https://github.com/user-attachments/assets/28ad3693-5e3e-4f6e-9bbc-485424fbbee2

<p align="center">
  <a href="#installation">Instalación</a> •
  <a href="#training">Entrenamiento</a> •
  <a href="#inference">Aplicación CLI</a> •
  <a href="#citing">Citar</a>
</p>


**NOTICIAS**
* 🎉 ¡BrLP ha obtenido el segundo lugar en el premio Media Best Paper Award en MICCAI 2025!
* 🎉 Nuestro [artículo de extensión](https://arxiv.org/pdf/2502.08560) ha sido aceptado para publicación en Medical Image Analysis (*IF=11.8*)
* 🎉 Un [nuevo artículo](https://www.spiedigitallibrary.org/conference-proceedings-of-spie/13406/1340621/A-technical-assessment-of-latent-diffusion-for-Alzheimers-disease-progression/10.1117/12.3047135.short) de la Universidad de Vanderbilt ha replicado nuestros resultados en el conjunto de datos [BLSA](https://www.blsa.nih.gov/)!
* 🆕 ¡La [guía corta para usar la CLI de BrLP](https://lemuelpuglisi.github.io/blog/2024/brlp/) ya está disponible!
* 🎉 ¡BrLP ha sido nominado y preseleccionado para el MICCAI Best Paper Award! (top <1%)
* 🎉 BrLP ha sido aceptado anticipadamente y seleccionado para **presentación oral** en [MICCAI 2024](https://conferences.miccai.org/2024/en/) (top 4%)!



## Tabla de Contenidos
- [Instalación](#installation)
- [Preparación de datos](https://raw.githubusercontent.com/LemuelPuglisi/BrLP/main/./REPR-DATA.md)
- [Entrenamiento](#training)
- [Modelos preentrenados](#pretrained-models)
- [Agradecimientos](#acknowledgements)
- [Citación de nuestro trabajo](#citing)

## Instalación

Descargue el repositorio, haga `cd` en la carpeta del proyecto e instale el paquete `brlp`:

```console
pip install -e .
```
Recomendamos usar un entorno separado (ver [Anaconda](https://www.anaconda.com/)). El código ha sido probado con python 3.9, sin embargo, esperamos que también funcione con versiones más recientes.

## Preparación de datos

Consulta nuestro documento sobre [*Preparación de datos y reproducibilidad del estudio*](https://raw.githubusercontent.com/LemuelPuglisi/BrLP/main/./REPR-DATA.md). Este archivo te guiará en la organización de tus datos y la creación de los archivos CSV necesarios para ejecutar los pipelines de entrenamiento.


## Entrenamiento
![](https://raw.githubusercontent.com/LemuelPuglisi/BrLP/main/assets/pipeline.png)


El entrenamiento de BrLP tiene 3 fases principales que se describirán en las secciones siguientes. Cada entrenamiento (excepto para el modelo auxiliar) puede ser monitoreado usando `tensorboard` de la siguiente manera:

```console
tensorboard --logdir runs
```



### Train the autoencoder

Follow the commands below to train the autoencoder.

```console
# Create an output and a cache directory
mkdir ae_output ae_cache

# Run the training script
python scripts/training/train_autoencoder.py \
  --dataset_csv /path/to/A.csv \
  --cache_dir   ./ae_cache \
  --output_dir  ./ae_output
```

Luego extrae los latentes de tus datos de MRI:

```console
python scripts/prepare/extract_latents.py \
  --dataset_csv /path/to/A.csv \
  --aekl_ckpt   ae_output/autoencoder-ep-XXX.pth
```

Reemplace `XXX` para seleccionar los puntos de control del autoencoder de su elección.

### Entrenar el UNet

Siga los comandos a continuación para entrenar el UNet de difusión. Reemplace `XXX` para seleccionar los puntos de control del autoencoder de su elección.


```console
# Create an output and a cache directory:
mkdir unet_output unet_cache

# Run the training script
python scripts/training/train_diffusion_unet.py \
  --dataset_csv /path/to/A.csv \
  --cache_dir   unet_cache \
  --output_dir  unet_output \
  --aekl_ckpt   ae_output/autoencoder-ep-XXX.pth
```

### Entrena el ControlNet

Sigue los comandos a continuación para entrenar el ControlNet. Reemplaza `XXX` para seleccionar los puntos de control del autoencoder y UNet de tu elección.

```console
# Create an output and a cache directory:
mkdir cnet_output cnet_cache

# Run the training script
python scripts/training/train_controlnet.py \
  --dataset_csv /path/to/B.csv \
  --cache_dir   unet_cache \
  --output_dir  unet_output \
  --aekl_ckpt   ae_output/autoencoder-ep-XXX.pth \
  --diff_ckpt   unet_output/unet-ep-XXX.pth
```

### Modelos auxiliares

Sigue los comandos a continuación para entrenar el modelo auxiliar DCM.

```console
# Create an output directory
mkdir aux_output

# Run the training script
python scripts/training/train_aux.py \
  --dataset_csv /path/to/A.csv \
  --output_path aux_output
```

Enfatizamos que cualquier modelo de progresión de la enfermedad capaz de predecir cambios volumétricos a lo largo del tiempo también es viable como modelo auxiliar para BrLP.

## Inferencia

Nuestro paquete incluye un comando `brlp` para usar BrLP en inferencia. Verifique:
```console
brlp --help
```
El parámetro `--input` requiere un archivo CSV donde liste todos los datos disponibles para sus sujetos. Como ejemplo, consulte `examples/input.example.csv`. Si no ha segmentado sus escaneos de entrada, `brlp` puede realizar esta tarea por usted usando [SynthSeg](https://surfer.nmr.mgh.harvard.edu/fswiki/SynthSeg), pero requiere que FreeSurfer >= 7.4 esté instalado. El parámetro `--confs` especifica las rutas a los modelos y otros parámetros de inferencia, como LAS $m$. Como ejemplo, consulte `examples/confs.example.yaml`. 

Ejecutar el programa se ve así:

![inference-preview](https://raw.githubusercontent.com/LemuelPuglisi/BrLP/main/assets/inference.gif)


## Modelos preentrenados

Descargue los modelos preentrenados para BrLP:

| Modelo                 | URL de Pesos                                               |
| ---------------------- | ---------------------------------------------------------- |
| Autoencoder            | [enlace](https://studentiunict-my.sharepoint.com/:u:/g/personal/pgllml99h18c351e_studium_unict_it/EUxUFIQtkQ1EvBqojYA5BAYByIyHbttca5Mx1cU4bC6q3A?e=sCXSUA) |
| Modelo de Difusión UNet| [enlace](https://studentiunict-my.sharepoint.com/:u:/g/personal/pgllml99h18c351e_studium_unict_it/EQT7KJTtfmRAguf8_utWeJIBUJPsRRgPZlt94s2vNbwVFw?e=IjHnx7) |
| ControlNet             | [enlace](https://studentiunict-my.sharepoint.com/:u:/g/personal/pgllml99h18c351e_studium_unict_it/EYtVvH47dFJJnH8gtwSMA-MB8c3pm4_Z9g5F_IG1OKxW9Q?e=CzvGT4) |
| Modelos Auxiliares (DCM)| [enlace](https://studentiunict-my.sharepoint.com/:u:/g/personal/pgllml99h18c351e_studium_unict_it/EXJDQqLNCwBFkt2J6zg1kpwBS_1hAZoBfGy5AfcGOBZvHQ?e=Z05kOG) |

## Agradecimientos

Agradecemos a los mantenedores de bibliotecas de código abierto por sus contribuciones para acelerar el proceso de investigación, con una mención especial a [MONAI](https://monai.io/) y su extensión [GenerativeModels](https://github.com/Project-MONAI/GenerativeModels/tree/main).

## Citación

Medical Image Analysis:


```bib
@article{puglisi2025brain,
  title={Brain latent progression: Individual-based spatiotemporal disease progression on 3D brain MRIs via latent diffusion},
  author={Puglisi, Lemuel and Alexander, Daniel C and Rav{\`\i}, Daniele},
  journal={Medical Image Analysis},
  year={2025}
}
```

Actas de MICCAI 2024:

```bib
@inproceedings{puglisi2024enhancing,
  title={Enhancing spatiotemporal disease progression models via latent diffusion and prior knowledge},
  author={Puglisi, Lemuel and Alexander, Daniel C and Rav{\`\i}, Daniele},
  booktitle={International Conference on Medical Image Computing and Computer-Assisted Intervention},
  pages={173--183},
  year={2024},
  organization={Springer}
}
```


Actas de SPIE Medical Imaging 2025: 
```bib
@inproceedings{mcmaster2025technical,
  title={A technical assessment of latent diffusion for Alzheimer's disease progression},
  author={McMaster, Elyssa and Puglisi, Lemuel and Gao, Chenyu and Krishnan, Aravind R and Saunders, Adam M and Ravi, Daniele and Beason-Held, Lori L and Resnick, Susan M and Zuo, Lianrui and Moyer, Daniel and others},
  booktitle={Medical Imaging 2025: Image Processing},
  volume={13406},
  pages={505--513},
  year={2025},
  organization={SPIE}
}
```



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-20

---
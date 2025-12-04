# MoE-Adapters4CL
Código para el artículo "[**Impulsando el Aprendizaje Continuo de Modelos Visión-Lenguaje mediante Adaptadores de Mezcla de Expertos**](https://arxiv.org/abs/2403.11549)" CVPR2024.

## Tabla de Contenidos
  - [Resumen](#Abstract)
  - [Enfoque](#Approach)
  - [Instalación](#Install)
  - [Preparación de datos](#Data-preparation)
  - [Primeros pasos](#getting-started)
    - [Modelo ckpt](#Model-ckpt)
    - [MTCL](#MTCL)
      - [Prueba](#Test)
      - [Entrenamiento](#Train)
    - [CIL](#CIL)
      - [Entrenamiento](#Train)
  - [Citación](#Citation)
  - [Agradecimientos](#Acknowledgement)

## Resumen
Continual learning can empower vision-language models to continuously acquire new knowledge, without the need for access to the entire historical dataset. However, mitigating the performance degradation in large-scale models is non-trivial due to (i) parameter shifts throughout lifelong learning and (ii) significant computational burdens associated with full-model tuning. In this work, we present a parameter-efficient continual learning framework to alleviate long-term forgetting in incremental learning with vision-language models. Our approach involves the dynamic expansion of a pre-trained CLIP model, through the integration of Mixture-of-Experts (MoE) adapters in response to new tasks. To preserve the zero-shot recognition capability of vision-language models, we further introduce a Distribution Discriminative Auto-Selector (DDAS) that automatically routes in-distribution and out-of-distribution inputs to the MoE Adapter and the original CLIP, respectively. Through extensive experiments across various settings, our proposed method consistently outperforms previous state-of-the-art approaches while concurrently reducing parameter training burdens by 60%. 
## Enfoque
___
![imagen de ejemplo](https://raw.githubusercontent.com/JiazuoYu/MoE-Adapters4CL/MoE-Adapters/fig/framework.png)


## Instalación
```bash
conda create -n MoE_Adapters4CL python=3.9
conda activate MoE_Adapters4CL
conda install pytorch==2.1.0 torchvision==0.16.0 torchaudio==2.1.0 pytorch-cuda=11.8 -c pytorch -c nvidia
cd cil
pip install -r requirements.txt
```
## Preparación de datos
Conjuntos de datos objetivo: Aircraft, Caltech101, CIFAR10, CIFAR100, DTD, EuroSAT, Flowers, Food, MNIST, OxfordPet, StanfordCars, SUN397, TinyImagenet.

Si tienes problemas con Caltech101, puedes referirte a [issue#6](https://github.com/JiazuoYu/MoE-Adapters4CL/issues/6).

Más detalles pueden consultarse en [datasets.md](https://raw.githubusercontent.com/JiazuoYu/MoE-Adapters4CL/MoE-Adapters/mtil%2Fdatasets.md) de [ZSCL](https://github.com/Thunderbeee/ZSCL). ¡Muchas gracias a ellos por su excelente trabajo!
## Checkpoint del modelo
|                  | Modelo                                                                | Enlace |
|------------------|----------------------------------------------------------------------|---------------------------------------------------------------------- |
| full_shot_order1 | full_shot_order1_1000iters.pth                  | [Baidu Disk](https://pan.baidu.com/s/1brWYIMrv34fhdc4kC9B0_g?pwd=p3zp) / [Google Drive](https://drive.google.com/drive/folders/1f2GB2kmBYoxzWI9E33XqPnkIKrAB2fh9?usp=sharing)      |
| few_shot_order1  | few_shot_order1_1000iters.pth | [Baidu Disk](https://pan.baidu.com/s/1Z7q3tTLdRFN3zmtkj3_i4g?pwd=4edw) / [Google Drive](https://drive.google.com/drive/folders/1f2GB2kmBYoxzWI9E33XqPnkIKrAB2fh9?usp=sharing)       |
## MTCL
### Etapa de prueba
Ejemplo:
1. Mover los checkpoints a MoE-Adapters4CL/ckpt
2. ```cd MoE-Adapters4CL/mtil```
3. Ejecutar el script ```bash srcipts/test/Full_Shot_order1.sh ```


### Etapa de entrenamiento
Ejemplo:
1. Mover los checkpoints a MoE-Adapters4CL/ckpt
2. ```cd MoE-Adapters4CL/mtil```
3. Ejecutar el script ```bash srcipts/train/train_full_shot_router11_experts22_1000iters.sh```

## Aprendizaje incremental por clases

### Etapa de entrenamiento
Ejemplo:
1. ```cd cil```
2. ```bash run_cifar100-2-2.sh ```

## Citación

```
@inproceedings{yu2024boosting,
  title={Boosting continual learning of vision-language models via mixture-of-experts adapters},
  author={Yu, Jiazuo and Zhuge, Yunzhi and Zhang, Lu and Hu, Ping and Wang, Dong and Lu, Huchuan and He, You},
  booktitle={Proceedings of the IEEE/CVF Conference on Computer Vision and Pattern Recognition},
  pages={23219--23230},
  year={2024}
}
```
## Agradecimientos
Nuestro repositorio está basado en [wise-ft](https://github.com/mlfoundations/wise-ft), [Continual-CLIP](https://github.com/vgthengane/Continual-CLIP/tree/master) y [ZSCL](https://github.com/Thunderbeee/ZSCL). Agradecemos a los autores por compartir sus códigos.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-04

---
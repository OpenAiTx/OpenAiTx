
## :book: CoDA: Descubrimiento Colaborativo de Nuevas Cajas y Alineación Cruzada Modal para la Detección de Objetos 3D de Vocabulario Abierto (NeurIPS2023)
<p align="center">
  <small> 🔥Por favor, dale estrella a CoDA ⭐ y compártelo. Gracias🔥 </small>
</p>

> [[Artículo](https://arxiv.org/abs/2310.02960)] &emsp; [[Página del Proyecto](https://yangcaoai.github.io/publications/CoDA.html)] <br>
<!-- > [Yang Cao](https://yangcaoai.github.io/), Yihan Zeng, [Hang Xu](https://xuhangcn.github.io/), [Dan Xu](https://www.danxurgb.net) <br> -->
<!-- > La Universidad de Ciencia y Tecnología de Hong Kong, Huawei Noah's Ark Lab -->
> [Yang Cao](https://yangcaoai.github.io/), Yihan Zeng, [Hang Xu](https://xuhangcn.github.io/), [Dan Xu](https://www.danxurgb.net) <br>
> La Universidad de Ciencia y Tecnología de Hong Kong<br>
> Huawei Noah's Ark Lab

:triangular_flag_on_post: **Actualizaciones**  

&#9745; Nuestro nuevo trabajo **CoDAv2** ha sido aceptado por TPAMI, ¡échale un vistazo [aquí](https://arxiv.org/pdf/2406.00830v2)!

&#9745; Como el primer trabajo que introduce 3D Gaussian Splatting en la Detección de Objetos 3D, 3DGS-DET ha sido publicado [aquí](https://arxiv.org/pdf/2410.01647)!

&#9745; Los últimos artículos y códigos sobre percepción de vocabulario abierto están recopilados [aquí](https://github.com/yangcaoai/Awesome-Open-Vocabulary-Perception).

&#9745; ¡Todos los códigos, datos y modelos preentrenados han sido liberados!

&#9745; Los códigos de entrenamiento y prueba han sido liberados.

&#9745; Los modelos preentrenados han sido liberados.

&#9745; Los conjuntos de datos SUN-RGBD en configuración OV han sido liberados.  

&#9745; Los conjuntos de datos ScanNet en configuración OV han sido liberados.

&#9745; El código LaTeX del artículo está disponible en https://scienhub.com/Yang/CoDA.

## Marco de trabajo  
<img src="https://raw.githubusercontent.com/yangcaoai/CoDA_NeurIPS2023/main/assets/ov3d_det.png">

## Ejemplos  
<img src="https://raw.githubusercontent.com/yangcaoai/CoDA_NeurIPS2023/main/assets/CoDA_sup_fig0_v3_cropped_compressed_v2.jpg">

## Instalación
Nuestro código está basado en PyTorch 1.8.1, torchvision==0.9.1, CUDA 10.1 y Python 3.7. Puede funcionar con otras versiones.

Por favor, instale también las siguientes dependencias de Python:

```
matplotlib
opencv-python
plyfile
'trimesh>=2.35.39,<2.35.40'
'networkx>=2.2,<2.3'
scipy
```

Por favor, instale las capas `pointnet2` ejecutando

```
cd third_party/pointnet2 && python setup.py install
```

Por favor, instale una implementación cionizada de gIOU para un entrenamiento más rápido.
```
conda install cython
cd utils && python cython_compile.py build_ext --inplace
```

## Preparación del conjunto de datos

Para lograr la configuración OV, reorganizamos los conjuntos de datos originales [ScanNet](https://github.com/facebookresearch/votenet/tree/main/scannet) y [SUN RGB-D](https://github.com/facebookresearch/votenet/tree/main/sunrgbd) y adoptamos anotaciones de más categorías. Por favor, descargue directamente los conjuntos de datos con configuración OV que proporcionamos aquí: [OV SUN RGB-D](https://huggingface.co/datasets/YangCaoCS/Open-Vocabulary-SUN-RGBD) y [OV ScanNet](https://hkustconnect-my.sharepoint.com/:f:/g/personal/ycaobd_connect_ust_hk/EsqoPe7-VFxOlY0a-v1-vPwBSiEHoGRTgK5cLIhnjyXiEQ?e=jY7nKT). 

Luego ejecute para el archivo *.tar descargado:
```
bash data_preparation.sh
```

## Evaluación
Descargue los modelos preentrenados [aquí](https://drive.google.com/file/d/1fTKX1ML5u8jJ249GwAYqdCZGs941907H/view?usp=drive_link).
Luego ejecute:
```
bash test_release_models.sh
```

## Entrenamiento
```
bash scripts/coda_sunrgbd_stage1.sh
bash scripts/coda_sunrgbd_stage2.sh
```
## Ejecutando Muestras
```
bash run_samples.sh
```

## :scroll: BibTeX
Si CoDA es útil, por favor cite:
```
@inproceedings{cao2023coda,
  title={CoDA: Collaborative Novel Box Discovery and Cross-modal Alignment for Open-vocabulary 3D Object Detection},
  author={Cao, Yang and Zeng, Yihan and Xu, Hang and Xu, Dan},
  booktitle={NeurIPS},
  year={2023}
}

@article{cao2024collaborative,
  title={Collaborative Novel Object Discovery and Box-Guided Cross-Modal Alignment for Open-Vocabulary 3D Object Detection},
  author={Cao, Yang and Zeng, Yihan and Xu, Hang and Xu, Dan},
  journal={IEEE Transactions on Pattern Analysis and Machine Intelligence (TPAMI)},
  year={2025}
}
```

## :e-mail: Contacto

Si tiene alguna pregunta o necesidad de colaboración (con fines de investigación o comerciales), por favor envíe un correo a `yangcao.cs@gmail.com`.

## :scroll: Agradecimientos
CoDA está inspirado en [CLIP](https://github.com/openai/CLIP) y [3DETR](https://github.com/facebookresearch/3detr). Agradecemos sus excelentes códigos.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-08

---
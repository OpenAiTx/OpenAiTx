# HiFuse
![](https://img.shields.io/github/license/huoxiangzuo/HiFuse)  
Este repositorio es la implementación oficial de [HiFuse: Hierarchical Multi-Scale Feature Fusion Network for Medical Image Classification](https://www.sciencedirect.com/science/article/pii/S1746809423009679)    
Autores: Xiangzuo Huo, Gang Sun, Shengwei Tian, Yan Wang, Long Yu, Jun Long, Wendong Zhang y Aolun Li.  
¡Disfruta del código y encuentra su conveniencia para producir trabajos más impresionantes!

## Visión General
<img width="1395" alt="figure1" src="https://user-images.githubusercontent.com/57312968/191570017-34f30c13-9d8e-4776-a118-de968aebdb19.png" width="80%">

## Bloque HFF
<img width="1424" alt="figure2s" src="https://user-images.githubusercontent.com/57312968/191570496-c62e04dc-8baf-4b01-a6ba-03c24c5a744d.png" width="70%">

## Inspección Visual de HiFuse
<img src="https://user-images.githubusercontent.com/57312968/191570242-4425944d-4017-45c6-a3f7-f977376766a2.png" width="75%">

## Ejecución
0. Requisitos:
* python3
* pytorch 1.10
* torchvision 0.11.1
1. Entrenamiento:
* Prepara las imágenes requeridas y guárdalas en categorías, configura carpetas de imágenes para entrenamiento y validación respectivamente
* Ejecuta `python train.py`
2. Reanudar entrenamiento:
* Modifica `parser.add_argument('--RESUME', type=bool, default=True)` en `python train.py`
* Ejecuta `python train.py`
3. Pruebas:
* Ejecuta `python test.py`

## TensorBoard
Ejecuta `tensorboard --logdir runs --port 6006` para ver el progreso del entrenamiento

## Referencias
Algunos códigos de este repositorio están tomados de:  
* [Swin Transformer](https://github.com/microsoft/Swin-Transformer)  
* [ConvNeXt](https://github.com/facebookresearch/ConvNeXt)  
* [WZMIAOMIAO](https://github.com/WZMIAOMIAO/deep-learning-for-image-processing)

## Citación

Si encuentra que nuestro artículo/código es útil, por favor considere citar:

```bibtex
@article{huo2024hifuse,
  title={HiFuse: Hierarchical multi-scale feature fusion network for medical image classification},
  author={Huo, Xiangzuo and Sun, Gang and Tian, Shengwei and Wang, Yan and Yu, Long and Long, Jun and Zhang, Wendong and Li, Aolun},
  journal={Biomedical Signal Processing and Control},
  volume={87},
  pages={105534},
  year={2024},
  publisher={Elsevier}
}
@article{huo2025mm,
  title={MM-HiFuse: multi-modal multi-task hierarchical feature fusion for esophagus cancer staging and differentiation classification},
  author={Huo, Xiangzuo and Tian, Shengwei and Yu, Long and Zhang, Wendong and Li, Aolun and Yang, Qimeng and Song, Jinmiao},
  journal={Complex \& Intelligent Systems},
  volume={11},
  number={1},
  pages={1--12},
  year={2025},
  publisher={Springer}
}
```

## Star History

[![Star History Chart](https://api.star-history.com/image?repos=huoxiangzuo/HiFuse&type=date&legend=top-left)](https://www.star-history.com/?repos=huoxiangzuo%2FHiFuse&type=date&legend=top-left)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-19

---
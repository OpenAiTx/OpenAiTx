# Semantic-Guided-Low-Light-Image-Enhancement
Esta es la implementación oficial en Pytorch de nuestro artículo "**Aprendizaje Zero-Shot Guiado por Semántica para la Mejora de Imágenes/Vídeos en Condiciones de Baja Luz**" 

# Actualizaciones
- 2021.11.27: Se ha subido la figura de la arquitectura del modelo.
- 2021.11.10: Este trabajo ha sido aceptado y será presentado en [WACV 2022](https://wacv2022.thecvf.com/home).
- 2021.10.8: Una forma fácil de calcular las métricas mPA y mIOU está disponible en este [repositorio](https://github.com/ShenZheng2000/DarkCityScape_mIOU_mPA)
- 2021.10.6: Se ha publicado un vídeo de baja luz mejorado en formato GIF.
- 2021.10.5: Un vídeo de baja luz de muestra y su resultado mejorado están disponibles en: [[Low-Light](https://www.youtube.com/watch?v=4Avy_xsczdU)]  [[Enhanced](https://www.youtube.com/watch?v=rN6Tf1E-kE8)]
- 2021.10.5: Mi nuevo [repositorio](https://github.com/ShenZheng2000/Awesome-Low-Light-Enhancement-with-Deep-Learning) contiene una colección de métodos para la mejora de imágenes en baja luz. Espero que lo encuentres útil.
- 2021.10.4: El enlace de arxiv está disponible en http://arxiv.org/abs/2110.00970


# Resumen
Low-light images challenge both human perceptions and computer vision algorithms. It is crucial to make algorithms robust to enlighten low-light images for computational photography and computer vision applications such as real-time detection and segmentation tasks. This paper proposes a semantic-guided zero-shot low-light enhancement network which is trained in the absence of paired images, unpaired datasets, and segmentation annotation. Firstly, we design an efficient **enhancement factor extraction** network using depthwise separable convolution. Secondly, we propose a **recurrent image enhancement** network for progressively enhancing the low-light image. Finally, we introduce an **unsupervised semantic segmentation** network for preserving the semantic information. Extensive experiments on various benchmark datasets and a low-light video demonstrate that our model outperforms the previous state-of-the-art qualitatively and quantitatively. We further discuss the benefits of the proposed method for low-light detection and segmentation.
# Arquitectura del Modelo  
Haga clic en el siguiente enlace para ver la arquitectura del modelo en formato pdf.  

![Arquitectura del Modelo](https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/main_architecture.pdf)  

# Resultados de Muestra  
## 1. Cuadros de Video con Baja Iluminación  
De izquierda a derecha, y de arriba hacia abajo: Oscuro, Retinex [1], KinD [2], EnlightenGAN [3], Zero-DCE [4], Nuestro método.  

<p float="left">  
<p align="middle">  
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/F1.png" width="250" />  
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/retinex_net.png" width="250" />   
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/kind.png" width="250" />  
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/enlighten_gan.png" width="250" />  
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/zero_dce.png" width="250" />   
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/F1Crop.png" width="250" />  
</p>  

## 2. Imágenes con Baja Iluminación (Mundo Real)  
De izquierda a derecha, y de arriba hacia abajo: Oscuro, PIE [5], LIME [6], Retinex [1], MBLLEN [7], KinD [2] , Zero-DCE [4], Nuestro método  

<p float="left">  
<p align="middle">  
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/Dark7.jpg" width="200" />  
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/PIE7.jpg" width="200" />   
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/LIME7.jpg" width="200" />  
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/Retinex7.jpg" width="200" />  
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/mbllen7.jpg" width="200" />   
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/KinD7.jpg" width="200" />  
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/ZeroDCE7.jpg" width="200" />   
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/Ours7.jpg" width="200" />  
</p>  

# Comenzar  

## 1. Requisitos  
* CUDA 10.0  
* Python 3.6+

* Pytorch 1.0+
* torchvision 0.4+
* opencv-python
* numpy
* pillow
* scikit-image

## 2. Preparar Conjuntos de Datos
### Conjunto de Datos de Prueba
- Descargue las imágenes oficiales de prueba desde [BaiduYun](https://pan.baidu.com/s/1pbz0YlOmLqxnazeKrRRUQg) con la contraseña `8itq`. 
- Mueva el archivo descomprimido a `data/test_data/`. 
- También puede colocar conjuntos de datos personalizados o sus propias imágenes con poca luz en esta carpeta para pruebas. Ejemplo: `data/test_data/yourDataset/`

### Conjunto de Datos de Entrenamiento
- Descargue las imágenes oficiales de entrenamiento desde [GoogleDrive](https://drive.google.com/file/d/1GAB3uGsmAyLgtDBDONbil08vVu5wJcG3/view). 
- Mueva el archivo descomprimido a `data/train_data/`. 

NOTA: Si no tiene cuenta en BaiduYun, puede descargar tanto el conjunto de datos de entrenamiento como el de prueba a través de [Google Drive](https://drive.google.com/drive/folders/1RIQsP5ap5QU7LstHPknOffQZeqht_FCh)

Después de la preparación, las carpetas de datos deberían verse así:
```
data/
├── test_data/
│   ├── lowCUT/
│   ├── BDD/
│   ├── Cityscapes/
│   ├── DICM/
│   ├── LIME/
│   ├── LOL/
│   ├── MEF/
│   ├── NPE/
│   └── VV/
└── train_data/
    └── ...
```

## 3. Entrenamiento desde cero
Para entrenar el modelo:
```
python train.py \
  --lowlight_images_path path/to/train_images \
  --snapshots_folder path/to/save_weights
```
Ejemplo (entrenar desde cero):

```
python train.py \
  --lowlight_images_path data/train_data \
  --snapshots_folder weight/
```

## 4. Reanudar el Entrenamiento

Para reanudar el entrenamiento desde un punto de control:
```
python train.py \
  --lowlight_images_path path/to/train_images \
  --snapshots_folder path/to/save_weights \
  --load_pretrain True \
  --pretrain_dir path/to/checkpoint.pth
```

Ejemplo (reanudar desde Epoch99.pth):
```
python train.py \
  --lowlight_images_path data/train_data \
  --snapshots_folder weight/ \
  --load_pretrain True \
  --pretrain_dir weight/Epoch99.pth
```
 
## 5. Pruebas
**NOTA: Por favor, elimine todos los archivos readme.txt en la carpeta `data` para evitar errores de inferencia del modelo.**

Para probar el modelo:

```
python test.py \
  --input_dir path/to/your_input_images \
  --weight_dir path/to/pretrained_model.pth \
  --test_dir path/to/output_folder 
```
Ejemplo:

```
python test.py \
  --input_dir data/test_data/lowCUT \
  --weight_dir weight/Epoch99.pth \
  --test_dir test_output
```

## 6. Pruebas en Videos
Para probar el modelo en videos (formato MP4), ejecute en la terminal:
```
bash test_video.sh
```

Hay cinco hiperparámetros en `demo/make_video.py` para la prueba de video. Vea la siguiente explicación.  
- `video_path`: ruta del video en baja luminosidad  
- `image_lowlight_folder`: ruta de las imágenes en baja luminosidad  
- `image_folder`: ruta de las imágenes mejoradas  
- `save_path`: ruta del video mejorado  
- `choice`: si convertir video a imagen, o imagen a video  


# Hiperparámetros  
| Nombre               | Tipo  | Predeterminado     |  
|----------------------|-------|--------------------|  
| lowlight_images_path | str   | data/train_data/   |  
| lr                   | float | 1e-3               |  
| weight_decay         | float | 1e-3               |  
| grad_clip_norm       | float | 0.1                |  
| num_epochs           | int   | 100                |  
| train_batch_size     | int   | 6                  |  
| val_batch_size       | int   | 8                  |  
| num_workers          | int   | 4                  |  
| display_iter         | int   | 10                 |  
| snapshot_iter        | int   | 10                 |  
| scale_factor         | int   | 1                  |  
| snapshots_folder     | str   | weight/            |  
| load_pretrain        | bool  | False              |  
| pretrain_dir         | str   | weight/Epoch99.pth |  
| num_of_SegClass      | int   | 21                 |  
| conv_type            | str   | dsc                |  
| patch_size           | int   | 4                  |  
| exp_level            | float | 0.6                |  


# Lista de tareas  
- [x] Listar hiperparámetros (importantes)  
- [x] Resolver problema con tamaño de entrada del modelo  
- [x] Subir peso preentrenado  
- [x] Reescribir argparse de entrenamiento y prueba en un option.py  
- [x] Reescribir entrenamiento como una clase  
- [x] Reescribir prueba como una clase  
- [x] Subir dataset de prueba  
- [x] Subir enlace de Arxiv
- [x] Pruebas en video
- [x] Subir BibTeX
- [x] Modificar archivo Readme
- [x] Subir arquitectura del modelo
- [ ] Proveer demo en línea
# Otros
Por favor contacte a zhengsh@kean.edu si tiene alguna pregunta. Este repositorio está fuertemente basado en [Zero-DCE](https://github.com/Li-Chongyi/Zero-DCE). ¡Gracias por compartir el código!

# Citas
Por favor cite el siguiente artículo si encuentra útil este repositorio.
```
@inproceedings{zheng2022semantic,
  title={Semantic-guided zero-shot learning for low-light image/video enhancement},
  author={Zheng, Shen and Gupta, Gaurav},
  booktitle={Proceedings of the IEEE/CVF Winter Conference on Applications of Computer Vision},
  pages={581--590},
  year={2022}
}
```


# Referencias
[1] Wei, Chen, et al. "Descomposición profunda de Retinex para mejora en baja iluminación." arXiv preprint arXiv:1808.04560 (2018).

[2] Zhang, Yonghua, Jiawan Zhang, y Xiaojie Guo. "Encendiendo la oscuridad: Un mejorador práctico de imágenes en baja iluminación." Proceedings of the 27th ACM international conference on multimedia. 2019.

[3] Jiang, Yifan, et al. "Enlightengan: Mejora profunda de luz sin supervisión pareada." IEEE Transactions on Image Processing 30 (2021): 2340-2349.

[4] Guo, Chunle, et al. "Estimación de curva profunda sin referencia para mejora de imágenes en baja iluminación." Proceedings of the IEEE/CVF Conference on Computer Vision and Pattern Recognition. 2020.

[5] Fu, Xueyang, et al. "Un método probabilístico para mejora de imágenes con estimación simultánea de iluminación y reflectancia." IEEE Transactions on Image Processing 24.12 (2015): 4965-4977.

[6] Guo, Xiaojie, Yu Li, y Haibin Ling. "LIME: Mejora de imágenes en baja iluminación mediante estimación del mapa de iluminación." IEEE Transactions on image processing 26.2 (2016): 982-993.

[7] Lv, Feifan, et al. "MBLLEN: Mejora de imágenes/videos en baja iluminación usando CNNs." BMVC. 2018.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-29

---
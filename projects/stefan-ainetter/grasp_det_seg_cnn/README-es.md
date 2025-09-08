# Red Neuronal Profunda Entrenable de Extremo a Extremo para la Detección de Agarre Robótico y Segmentación Semántica a partir de RGB

<p align="center">
<img src="https://raw.githubusercontent.com/stefan-ainetter/grasp_det_seg_cnn/main/Network.png" width="100%"/>
<br>
<a href="https://arxiv.org/abs/2107.05287">arXiv</a>
</p>

Este repositorio contiene el código para el artículo ICRA21 "Red Neuronal Profunda Entrenable de Extremo a Extremo para la Detección de Agarre Robótico
y Segmentación Semántica a partir de RGB". 
Contiene el código para entrenar y probar nuestro método propuesto en combinación con el conjunto de datos OCID_grasp. 

Si utiliza nuestro método o la extensión del conjunto de datos para su investigación, por favor cite:
```bibtex
@InProceedings{ainetter2021end,
  title={End-to-end Trainable Deep Neural Network for Robotic Grasp Detection and Semantic Segmentation from RGB},
  author={Ainetter, Stefan and Fraundorfer, Friedrich},
  booktitle={IEEE International Conference on Robotics and Automation (ICRA)},
  pages={13452--13458}
  year={2021}
}
```

## Requisitos y configuración

Requisitos principales del sistema:
* CUDA 10.1
* Linux con GCC 7 u 8
* PyTorch v1.1.0

**NOTA IMPORTANTE**: Estos requisitos no son necesariamente estrictos, por ejemplo, podría ser posible compilar con versiones anteriores
de CUDA, o bajo Windows. Sin embargo, solo hemos probado el código bajo las configuraciones mencionadas y no podemos ofrecer soporte para otros entornos.

Para instalar PyTorch, por favor consulte https://github.com/pytorch/pytorch#installation.

Para instalar todas las demás dependencias usando pip:
```bash
pip install -r requirements.txt
```

### Configuración

Nuestro código está dividido en dos componentes principales: una biblioteca que contiene implementaciones para los diversos módulos de red,
algoritmos y utilidades, y un conjunto de scripts para entrenar / probar las redes.

La biblioteca, llamada `grasp_det_seg`, se puede instalar con:
```bash
git clone https://github.com/stefan-ainetter/grasp_det_seg_cnn.git
cd grasp_det_seg_cnn
python setup.py install
```

## Modelos entrenados

Los archivos de modelo proporcionados están disponibles bajo la licencia [CC BY-NC-SA 4.0](https://creativecommons.org/licenses/by-nc-sa/4.0/).

Un modelo entrenado para el conjunto de datos OCID_grasp puede descargarse [aquí](https://cloud.tugraz.at/index.php/s/NA7icqiJ5SeNSA6?dir=/Grasp_det_seg_cnn/OCID_pretrained). 
Descargue y copie los pesos descargados en la carpeta `ckpt_files_OCID/pretrained`.

Para reentrenar la red en OCID_grasp, debe descargar pesos preentrenados en ImageNet 
[aquí](https://cloud.tugraz.at/index.php/s/NA7icqiJ5SeNSA6?dir=/Grasp_det_seg_cnn/ImageNet_weights) y copiarlos 
en la carpeta `weights_pretrained`.

### Entrenamiento

El entrenamiento implica tres pasos principales: Preparar el conjunto de datos, crear un archivo de configuración y ejecutar el script de entrenamiento.

Para preparar el conjunto de datos:
1) Descargue el conjunto de datos OCID_grasp [aquí](https://cloud.tugraz.at/index.php/s/NA7icqiJ5SeNSA6?dir=/Grasp_det_seg_cnn/OCID_grasp).
Descomprima el archivo `OCID_grasp.zip` descargado en la carpeta `DATA`.
2) El archivo de configuración es un archivo de texto simple en formato `ini`.
El valor predeterminado de cada parámetro de configuración, así como una breve descripción de su función, están disponibles en
[grasp_det_seg/config/defaults](grasp_det_seg/config/defaults).
**Nota** que estos son solo una indicación de cuál podría ser un valor "razonable" para cada parámetro, y no
están destinados a reproducir ninguno de los resultados de nuestro artículo.

3) Para iniciar el entrenamiento:

```bash
cd scripts
python3 -m torch.distributed.launch --nproc_per_node=1 train_det_seg_OCID.py 
--log_dir=LOGDIR CONFIG DATA_DIR
```
Los registros de entrenamiento, tanto en formatos de texto como Tensorboard, así como los parámetros de la red entrenada, se escribirán  
en `LOG_DIR` (por ejemplo, `ckpt_files_OCID`).  
El archivo `CONFIG` contiene la configuración de la red, por ejemplo `grasp_det_seg/config/defaults/det_seg_OCID.ini`,  
y `DATA_DIR` apunta a las divisiones OCID_grasp descargadas previamente, por ejemplo `DATA/OCID_grasp/data_split`.  

Tenga en cuenta que, por ahora, nuestro código **debe** ejecutarse en modo "distribuido" utilizando la utilidad `torch.distributed.launch` de PyTorch.  

### Ejecución de inferencia  

Dada una red entrenada, la inferencia se puede ejecutar en cualquier conjunto de imágenes usando  
[scripts/test_det_seg_OCID.py](https://raw.githubusercontent.com/stefan-ainetter/grasp_det_seg_cnn/main/scripts/test_det_seg_OCID.py):

```bash
cd scripts
python3 -m torch.distributed.launch --nproc_per_node=1 test_det_seg_OCID.py 
--log_dir=LOG_DIR CONFIG MODEL_PARAMS DATA_DIR OUTPUT_DIR

```
Las predicciones se escribirán en `OUTPUT_DIR`, por ejemplo, la carpeta `output`. `MODEL_PARAMS` son pesos preentrenados, por ejemplo, `ckpt_files_OCID/pretrained/model_last.pth.tar`,  
`DATA_DIR` apunta a las divisiones del conjunto de datos utilizadas, por ejemplo, `DATA/OCID_grasp/data_split`.  

## Conjunto de datos OCID_grasp  
El conjunto de datos OCID_grasp se puede descargar [aquí](https://cloud.tugraz.at/index.php/s/NA7icqiJ5SeNSA6?dir=/Grasp_det_seg_cnn/OCID_grasp).  
OCID_grasp consta de 1763 imágenes RGB-D seleccionadas del conjunto de datos OCID, con más de 11.4k máscaras segmentadas de objetos y más de 75k candidatos a agarre anotados a mano.  
Además, cada objeto está clasificado en una de 31 clases de objetos.  
## Trabajos Relacionados  
OCID_grasp es una extensión del conjunto de datos [OCID](https://www.acin.tuwien.ac.at/en/vision-for-robotics/software-tools/object-clutter-indoor-dataset/).  
Si decide usar OCID_grasp para su investigación, por favor cite también el artículo de OCID:
```bibtex
@inproceedings{suchi2019easylabel,
  title={EasyLabel: a semi-automatic pixel-wise object annotation tool for creating robotic RGB-D datasets},
  author={Suchi, Markus and Patten, Timothy and Fischinger, David and Vincze, Markus},
  booktitle={2019 International Conference on Robotics and Automation (ICRA)},
  pages={6678--6684},
  year={2019},
  organization={IEEE}
}
```
Nuestro marco está basado en la arquitectura de [Segmentación Continua de Escenas](https://github.com/mapillary/seamseg):
```bibtex
@InProceedings{Porzi_2019_CVPR,
  author = {Porzi, Lorenzo and Rota Bul\`o, Samuel and Colovic, Aleksander and Kontschieder, Peter},
  title = {Seamless Scene Segmentation},
  booktitle = {The IEEE Conference on Computer Vision and Pattern Recognition (CVPR)},
  month = {June},
  year = {2019}
}
```
---
## Sobre nuestra última investigación
### Nuestro artículo 'Segmentación de objetos consciente de la profundidad y detección de agarres para tareas robóticas de recogida' fue aceptado en BMVC21
En nuestro último trabajo, implementamos un método para la detección conjunta de agarres y la segmentación de instancias de objetos independiente de la clase,
que fue publicado en BMVC21. 
Más información se puede encontrar [aquí](https://arxiv.org/pdf/2111.11114).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-08

---
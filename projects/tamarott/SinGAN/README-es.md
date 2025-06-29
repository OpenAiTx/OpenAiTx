# SinGAN

[Proyecto](https://tamarott.github.io/SinGAN.htm) | [Arxiv](https://arxiv.org/pdf/1905.01164.pdf) | [CVF](http://openaccess.thecvf.com/content_ICCV_2019/papers/Shaham_SinGAN_Learning_a_Generative_Model_From_a_Single_Natural_Image_ICCV_2019_paper.pdf) | [Materiales suplementarios](https://openaccess.thecvf.com/content_ICCV_2019/supplemental/Shaham_SinGAN_Learning_a_ICCV_2019_supplemental.pdf) | [Charla (ICCV`19)](https://youtu.be/mdAcPe74tZI?t=3191) 
### Implementación oficial en pytorch del artículo: "SinGAN: Learning a Generative Model from a Single Natural Image"
#### Premio al mejor artículo ICCV 2019 (Premio Marr)


## Muestras aleatorias de una *sola* imagen
Con SinGAN, puedes entrenar un modelo generativo a partir de una sola imagen natural, y luego generar muestras aleatorias a partir de la imagen dada, por ejemplo:

![](https://raw.githubusercontent.com/tamarott/SinGAN/master/imgs/teaser.PNG)


## Aplicaciones de SinGAN
SinGAN también puede usarse para una variedad de tareas de manipulación de imágenes, por ejemplo:
 ![](https://raw.githubusercontent.com/tamarott/SinGAN/master/imgs/manipulation.PNG)
Esto se logra inyectando una imagen en el modelo ya entrenado. Consulta la sección 4 de nuestro [artículo](https://arxiv.org/pdf/1905.01164.pdf) para más detalles.


### Citación
Si usas este código para tu investigación, por favor cita nuestro artículo:

```
@inproceedings{rottshaham2019singan,
  title={SinGAN: Learning a Generative Model from a Single Natural Image},
  author={Rott Shaham, Tamar and Dekel, Tali and Michaeli, Tomer},
  booktitle={Computer Vision (ICCV), IEEE International Conference on},
  year={2019}
}
```

## Código

### Instalar dependencias

```
python -m pip install -r requirements.txt
```

Este código fue probado con python 3.6, torch 1.4

Nota: actualmente el código solo soporta torch 1.4 o versiones anteriores debido al esquema de optimización.

Para versiones más recientes de torch, puedes intentar este repositorio: https://github.com/kligvasser/SinGAN (los resultados no necesariamente serán idénticos a la implementación oficial).


###  Entrenar
Para entrenar el modelo SinGAN con tu propia imagen, coloca la imagen deseada para entrenamiento en Input/Images y ejecuta

```
python main_train.py --input_name <input_file_name>
```

Esto también usará el modelo entrenado resultante para generar muestras aleatorias comenzando desde la escala más gruesa (n=0).

Para ejecutar este código en una máquina cpu, especifica `--not_cuda` al llamar a `main_train.py`

###  Muestras aleatorias
Para generar muestras aleatorias desde cualquier escala de generación inicial, primero entrena el modelo SinGAN en la imagen deseada (como se describe arriba), luego ejecuta 

```
python random_samples.py --input_name <training_image_file_name> --mode random_samples --gen_start_scale <generation start scale number>
```

atención: para usar el modelo completo, especifica la escala de inicio de generación como 0, para comenzar la generación desde la segunda escala, especifícalo como 1, y así sucesivamente.

###  Muestras aleatorias de tamaños arbitrarios
Para generar muestras aleatorias de tamaños arbitrarios, primero entrena el modelo SinGAN en la imagen deseada (como se describe arriba), luego ejecuta 

```
python random_samples.py --input_name <training_image_file_name> --mode random_samples_arbitrary_sizes --scale_h <horizontal scaling factor> --scale_v <vertical scaling factor>
```

###  Animación a partir de una sola imagen

Para generar una animación corta a partir de una sola imagen, ejecuta

```
python animation.py --input_name <input_file_name> 
```

Esto comenzará automáticamente una nueva fase de entrenamiento con modo de padding de ruido.

###  Armonización

Para armonizar un objeto pegado en una imagen (ver ejemplo en la Fig. 13 en [nuestro artículo](https://arxiv.org/pdf/1905.01164.pdf)), primero entrena el modelo SinGAN en la imagen de fondo deseada (como se describe arriba), luego guarda la imagen de referencia pegada de forma ingenua y su máscara binaria en "Input/Harmonization" (ver imágenes guardadas para un ejemplo). Ejecuta el comando

```
python harmonization.py --input_name <training_image_file_name> --ref_name <naively_pasted_reference_image_file_name> --harmonization_start_scale <scale to inject>

```

Ten en cuenta que diferentes escalas de inyección producirán diferentes efectos de armonización. La escala de inyección más gruesa es igual a 1.

###  Edición

Para editar una imagen, (ver ejemplo en la Fig. 12 en [nuestro artículo](https://arxiv.org/pdf/1905.01164.pdf)), primero entrena el modelo SinGAN en la imagen sin editar (como se describe arriba), luego guarda la edición ingenua como imagen de referencia en "Input/Editing" con un mapa binario correspondiente (ver imágenes guardadas para un ejemplo). Ejecuta el comando

```
python editing.py --input_name <training_image_file_name> --ref_name <edited_image_file_name> --editing_start_scale <scale to inject>
```
tanto la salida enmascarada como la no enmascarada serán guardadas.
Aquí también, diferentes escalas de inyección producirán diferentes efectos de edición. La escala de inyección más gruesa es igual a 1.

###  Pintar a Imagen

Para transferir una pintura a una imagen realista (ver ejemplo en la Fig. 11 de [nuestro artículo](https://arxiv.org/pdf/1905.01164.pdf)), primero entrene el modelo SinGAN en la imagen deseada (como se describe arriba), luego guarde su pintura en "Input/Paint" y ejecute el comando

```
python paint2image.py --input_name <nombre_archivo_imagen_entrenamiento> --ref_name <nombre_archivo_imagen_pintura> --paint_start_scale <escala para inyectar>
```
Aquí también, diferentes escalas de inyección producirán diferentes efectos de edición. La escala de inyección más gruesa es igual a 1.

Opción avanzada: Especifique quantization_flag como True, para reentrenar *solo* el nivel de inyección del modelo, para obtener una versión cuantizada por color de las imágenes generadas reescaladas de la escala anterior. Para algunas imágenes, esto puede llevar a resultados más realistas.

### Super Resolución
Para superresolver una imagen, ejecute:
```
python SR.py --input_name <nombre_archivo_imagen_baja_resolucion>
```
Esto entrenará automáticamente un modelo SinGAN correspondiente a un factor de aumento de 4x (si no existe ya).
Para diferentes factores de SR, especifíquelo utilizando el parámetro `--sr_factor` al llamar a la función.
Los resultados de SinGAN en el conjunto de datos BSD100 pueden descargarse desde la carpeta 'Downloads'.

## Datos y Funciones Adicionales

### Single Image Fréchet Inception Distance (Puntaje SIFID)
Para calcular el SIFID entre imágenes reales y sus muestras falsas correspondientes, ejecute:
```
python SIFID/sifid_score.py --path2real <ruta_imagenes_reales> --path2fake <ruta_imagenes_falsas> 
```  
Asegúrese de que cada nombre de archivo de imagen falsa sea idéntico al nombre de archivo de la imagen real correspondiente. Las imágenes deben guardarse en formato `.jpg`.

### Resultados de Super Resolución
Los resultados de SR de SinGAN en el conjunto de datos BSD100 pueden descargarse desde la carpeta 'Downloads'.

### Estudio de Usuario
Los datos utilizados para el estudio de usuario se encuentran en la carpeta Downloads.

carpeta real: 50 imágenes reales, seleccionadas aleatoriamente de la [base de datos places](http://places.csail.mit.edu/)

carpeta fake_high_variance: muestras aleatorias comenzando desde n=N para cada una de las imágenes reales

carpeta fake_mid_variance: muestras aleatorias comenzando desde n=N-1 para cada una de las imágenes reales

Para más detalles, por favor vea la sección 3.1 de nuestro [artículo](https://arxiv.org/pdf/1905.01164.pdf)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---
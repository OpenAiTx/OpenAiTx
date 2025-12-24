# Emparejamiento de Flujo en PyTorch

Este repositorio contiene una implementación sencilla en PyTorch del artículo [Flow Matching for Generative Modeling](https://arxiv.org/abs/2210.02747).

## Ejemplo de Emparejamiento de Flujo 2D

El gif a continuación demuestra el mapeo de una distribución Gaussiana única a una distribución de tablero de ajedrez, con el campo vectorial visualizado.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/checkerboard/vector_field_checkerboard.gif" height="400" />
</p>

Y, aquí hay otro ejemplo con el conjunto de datos de lunas.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/moons/vector_field_moons.gif" height="400" />
</p>

## Comenzando

Clona el repositorio y configura el entorno de python.

```bash
git clone https://github.com/keishihara/flow-matching.git
cd flow-matching
```

Asegúrese de tener Python 3.10+ instalado.
Para configurar el entorno de Python usando `uv`:

```bash
uv sync
source .venv/bin/activate
```

Alternativamente, usando `pip`:

```bash
python -m venv .venv
source .venv/bin/activate
pip install -e .
```

## Emparejamiento de Flujo Condicional [Lipman+ 2023]

Esta es la implementación original del artículo CFM [1]. Algunos componentes del código están adaptados de [2] y [3].

### Conjuntos de Datos Sintéticos 2D

Puede entrenar los modelos CFM en conjuntos de datos sintéticos 2D como `checkerboard` y `moons`. Especifique el nombre del conjunto de datos usando la opción `--dataset`. Los parámetros de entrenamiento están predefinidos en el script, y las visualizaciones de los resultados de entrenamiento se almacenan en el directorio `outputs/`. No se incluyen puntos de control del modelo ya que son fácilmente reproducibles con la configuración predeterminada.

```bash
python train_flow_matching_2d.py --dataset checkerboard
```

Los campos vectoriales y las muestras generadas, como las que se muestran en GIFs en la parte superior de este README, ahora se pueden encontrar en el directorio `outputs/cfm/`.

### Conjuntos de Datos de Imágenes

También puede entrenar modelos CFM condicionales por clase en conjuntos de datos populares de clasificación de imágenes. Tanto las muestras generadas como los puntos de control del modelo se almacenarán en el directorio `outputs/cfm`. Para una lista detallada de los parámetros de entrenamiento, ejecute `python train_flow_matching_on_images.py --help`.

Para entrenar un CFM condicional por clase en el conjunto de datos MNIST, ejecute:

```bash
python train_flow_matching_on_image.py --do_train --dataset mnist
```

Después del entrenamiento, ahora puedes generar muestras con:

```bash
python train_flow_matching_on_image.py --do_sample --dataset mnist
```
Ahora, deberías poder ver las muestras generadas en el directorio `outputs/cfm/mnist/`.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/mnist/trajectory.gif" height="400" />
</p>

## Flujo Rectificado [Liu+ 2023]

Esta es una implementación del modelo Reflow (Flujo Rectificado 2 para ser específicos) del artículo sobre Flujo Rectificado [2].

### Datos Sintéticos 2D

Hemos implementado Reflow en conjuntos de datos sintéticos 2D, igual que CFM. Para entrenar el reflow, debes especificar puntos de control CFM preentrenados ya que reflow es un modelo de destilación.

Por ejemplo, para entrenar en el conjunto de datos `checkerboard` con un punto de control CFM preentrenado:


```bash
python train_reflow_2d.py --dataset checkerboard --pretrained-model outputs/cfm/checkerboard/ckpt.pth
```

Los resultados del entrenamiento, incluyendo visualizaciones del campo vectorial y muestras generadas, se guardan en la carpeta `outputs/reflow/`.

### Comparación del proceso de muestreo entre CFM y Reflow

Para comparar CFM y Reflow en conjuntos de datos 2d, ejecute:

```bash
python plot_comparison_2d.py --dataset checkerboard
```

Los GIF resultantes se pueden encontrar en la carpeta `outputs/comparisons/`. A continuación, un ejemplo de comparación de los dos métodos en el conjunto de datos `checkerboard`:

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/comparisons/cfm_reflow_checkerboard.gif" height="400" />
</p>

## Referencias

- [1] Lipman, Yaron, et al. "Flow Matching for Generative Modeling." [arXiv:2210.02747](https://arxiv.org/abs/2210.02747)
- [2] Liu, Xingchao, et al. "Flow Straight and Fast: Learning to Generate and Transfer Data with Rectified Flow." [arXiv:2209.03003](https://arxiv.org/abs/2209.03003)
- [3] [facebookresearch/flow_matching](https://github.com/facebookresearch/flow_matching)
- [4] [atong01/conditional-flow-matching](https://github.com/atong01/conditional-flow-matching)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-24

---

<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Flow Matching en PyTorch

Este repositorio contiene una implementación sencilla en PyTorch del artículo [Flow Matching for Generative Modeling](https://arxiv.org/abs/2210.02747).

## Ejemplo de Flow Matching en 2D

El gif a continuación muestra el mapeo de una sola distribución Gaussiana a una distribución de tablero de ajedrez, con el campo vectorial visualizado.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/checkerboard/vector_field_and_samples_checkerboard.gif" height="400" />
</p>

Y aquí tienes otro ejemplo con el conjunto de datos moons.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/moons/vector_field_and_samples_moons.gif" height="400" />
</p>

## Primeros Pasos

Clona el repositorio y configura el entorno de Python.

```bash
git clone https://github.com/keishihara/flow-matching.git
cd flow-matching
```

Asegúrate de tener instalado Python 3.12+.
Instala `uv`:

```bash
curl -LsSf https://astral.sh/uv/install.sh | sh
```

Luego, configura el entorno:

```bash
uv sync
```

## Emparejamiento de Flujo Condicional [Lipman+ 2023]

Esta es la implementación original del artículo CFM [1]. Algunos componentes del código están adaptados de [2] y [3].

### Conjuntos de Datos Sintéticos 2D

Puede entrenar los modelos CFM en conjuntos de datos sintéticos 2D como `checkerboard` y `moons`. Especifique el nombre del conjunto de datos usando la opción `--dataset`. Los parámetros de entrenamiento están predefinidos en el script, y las visualizaciones de los resultados de entrenamiento se almacenan en el directorio `outputs/`. No se incluyen puntos de control del modelo ya que son fácilmente reproducibles con la configuración predeterminada.

```bash
uv run scripts/train_flow_matching_2d.py --dataset checkerboard
```

Los campos vectoriales y las muestras generadas, como las que se muestran como GIFs en la parte superior de este README, ahora se pueden encontrar en el directorio `outputs/cfm/`.

### Conjuntos de datos de imágenes

También puedes entrenar modelos CFM condicionales por clase en conjuntos de datos de clasificación de imágenes populares. Tanto las muestras generadas como los puntos de control del modelo se almacenarán en el directorio `outputs/cfm`. Para obtener una lista detallada de los parámetros de entrenamiento, ejecuta `uv run scripts/train_flow_matching_on_image.py --help`.

Para entrenar un CFM condicional por clase en el conjunto de datos MNIST, ejecuta:

```bash
uv run scripts/train_flow_matching_on_image.py --do_train --dataset mnist
```

Después del entrenamiento, ahora puedes generar muestras con:

```bash
uv run scripts/train_flow_matching_on_image.py --do_sample --dataset mnist
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
uv run scripts/train_reflow_2d.py --dataset checkerboard
```

Los resultados del entrenamiento, incluyendo visualizaciones del campo vectorial y muestras generadas, se guardan en la carpeta `outputs/reflow/`.

### Comparación del proceso de muestreo entre CFM y Reflow

Para comparar CFM y Reflow en conjuntos de datos 2d, ejecute:

```bash
uv run scripts/plot_comparison_2d.py --dataset checkerboard
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-19

---
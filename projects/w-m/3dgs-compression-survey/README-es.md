# 3DGS.zip: Una encuesta sobre métodos de compresión de 3D Gaussian Splatting
Este repositorio contiene una encuesta completa de métodos de compresión de 3D Gaussian Splatting (3DGS). Puede ver la tabla completa de la encuesta y gráficos comparativos en [w-m.github.io/3dgs-compression-survey/](https://w-m.github.io/3dgs-compression-survey/).

## Instalación
Para ejecutar los scripts en este repositorio, asegúrese de tener instaladas todas las dependencias necesarias. Puede instalarlas usando el siguiente comando:

`pip install -r requirements.txt`

## Construcción del sitio
Para construir el sitio, utilice el siguiente comando:

`python data_extraction/build_html.py`

Este script también se ejecuta automáticamente para reconstruir el sitio cada vez que se envían cambios a la rama principal.

## Obtención de resultados
Puede obtener los resultados automáticamente ejecutando:

`python data_extraction/data_extraction.py`

Este script intenta obtener datos de los artículos relevantes y actualizar las tablas en la carpeta `results`. Para añadir un nuevo artículo, cree una entrada en `data_extraction/data_source.yaml`.

## Inclusión de sus propios resultados

Se solicita amablemente a los autores que suban sus resultados por escena en una carpeta designada dentro de su repositorio de GitHub. Esto asegura una recuperación precisa de datos y permite comparaciones consistentes y justas. La estructura de carpeta esperada es:

```
results
├── DeepBlending
│   ├── drjohnson.csv
│   └── playroom.csv
├── MipNeRF360
│   ├── bicycle.csv
│   ├── bonsai.csv
│   ├── counter.csv
│   ├── flowers.csv
│   ├── garden.csv
│   ├── kitchen.csv
│   ├── room.csv
│   ├── stump.csv
│   └── treehill.csv
├── SyntheticNeRF
│   ├── chair.csv
│   ├── drums.csv
│   ├── ficus.csv
│   ├── hotdog.csv
│   ├── lego.csv 
│   ├── materials.csv
│   ├── mic.csv
│   └── ship.csv
└── TanksAndTemples
    ├── train.csv
    └── truck.csv
```
La carpeta debe incluir todos los conjuntos de datos en los que se evaluó su método y cubrir todas las escenas especificadas en la estructura de la carpeta.

Cada archivo CSV debe estar estructurado de la siguiente manera:


```
Submethod,PSNR,SSIM,LPIPS,Size [Bytes],#Gaussians
Baseline,xx.xx,0.xxx,0.xxx,xxxxxxxx,xxxxxxxx
-SubmethodName,xx.xx,0.xxx,0.xxx,xxxxxxxx,xxxxxxxx
,xx.xx,0.xxx,0.xxx,xxxxxxxx,xxxxxxxx
,xx.xx,0.xxx,0.xxx,xxxxxxxx,xxxxxxxx
,xx.xx,0.xxx,0.xxx,xxxxxxxx,xxxxxxxx

```
Por favor, asegúrese de que los resultados de PSNR se informen con una precisión de al menos dos decimales, y que los resultados de SSIM y LPIPS se informen con una precisión de al menos tres decimales. Se recomienda a los autores proporcionar resultados con precisión completa, ya que estos serán redondeados antes de su inclusión en nuestra encuesta.

Incluya hasta dos nombres de submétodos coherentes para sus resultados en todos los archivos para asegurar que aparezcan en la tabla de la encuesta. Estos nombres serán concatenados con el nombre de su enfoque en la tabla. Si el especificador del submétodo debe separarse del nombre del método con un espacio, asegúrese de incluir ese espacio delante del nombre del submétodo. Si prefiere que solo se muestre el nombre de su enfoque en la tabla, puede usar "Baseline" como nombre de submétodo para esos resultados. Los resultados sin nombre de submétodo solo se mostrarán en los gráficos.

Puede ver un ejemplo [aquí](https://github.com/fraunhoferhhi/Self-Organizing-Gaussians/tree/main/results).

### Importante: Convenciones de prueba 3DGS

Se requiere que los autores sigan las convenciones de prueba establecidas en el proyecto original [3DGS](https://github.com/graphdeco-inria/gaussian-splatting). Específicamente, esto incluye:

- Usar las 9 escenas del conjunto de datos MipNeRF360, incluyendo las [escenas adicionales](https://storage.googleapis.com/gresearch/refraw360/360_extra_scenes.zip) "flowers" y "treehill".
- Evaluar imágenes a resolución completa hasta un máximo de 1600 px de lado. Las imágenes de prueba más grandes deben reducirse para que la dimensión más larga sea 1600 px (aplicable solo a MipNeRF360). Asegúrese de que el redimensionamiento coincida con 3DGS, que aplica el método estándar PIL ```.resize()``` con remuestreo bicúbico.  
- Para los 3 conjuntos de datos COLMAP (Tanks and Temples, Deep Blending, MipNeRF360), use cada octava imagen para la prueba. Concretamente, las imágenes de prueba son aquellas donde ```idx % 8 == 0```.
- Para el conjunto Blender (SyntheticNeRF), siga la división predefinida de entrenamiento/evaluación.


## Tabla LaTeX

Versiones actualizadas en LaTeX de las tablas de la encuesta están disponibles para [compresión](https://github.com/w-m/3dgs-compression-survey/blob/main/data_extraction/latex/3dgs_table_compression.tex) y [compactación](https://github.com/w-m/3dgs-compression-survey/blob/main/data_extraction/latex/3dgs_table_densification.tex). Siéntase libre de copiar una línea de la tabla en su investigación si desea comparar con el enfoque. Si desea copiar la tabla completa, podría necesitar los siguientes paquetes y definiciones en el preámbulo de su LaTeX:

```
\usepackage{booktabs}
\usepackage[table]{xcolor}
% colors for table
\definecolor{lightred}{HTML}{FF9999}
\definecolor{lightyellow}{HTML}{FFFF99}
\definecolor{lightorange}{HTML}{FFCC99}
\usepackage{makecell}
\usepackage{adjustbox}
% make text the same size even when its bold in a table
\newsavebox\CBox
\def\textBF#1{\sbox\CBox{#1}\resizebox{\wd\CBox}{\ht\CBox}{\textbf{#1}}}
```

## Cita

Si utiliza nuestra encuesta en su investigación, por favor cite nuestro trabajo. Puede usar la siguiente entrada BibTeX:

```bibtex
@article{3DGSzip2025,
author = {Bagdasarian, M. T. and Knoll, P. and Li, Y. and Barthel, F. and Hilsmann, A. and Eisert, P. and Morgenstern, W.},
title = {{3DGS.zip}: A {Survey} on {3D} {Gaussian} {Splatting} {Compression} {Methods}},
journal = {Computer Graphics Forum},
pages = {e70078},
year = {2025},
keywords = {CCS Concepts, • Information systems → Data compression, • Computing methodologies → Rasterization, • General and reference → Surveys and overviews},
doi = {https://doi.org/10.1111/cgf.70078},
url = {https://onlinelibrary.wiley.com/doi/abs/10.1111/cgf.70078},
eprint = {https://onlinelibrary.wiley.com/doi/pdf/10.1111/cgf.70078},
note = {\url{https://w-m.github.io/3dgs-compression-survey/}},
} 
```
## Actualizaciones
- 2025-04-29: Artículo publicado, actualizado bibtex en Readme y en el sitio web
- 2025-03-04: Añadido resumen de GaussianSpa (proporcionado por los autores).
- 2025-02-26: Añadido HEMGS
- 2025-02-25: Añadido GaussianSpa
- 2025-02-25: Añadido HAC++
- 2025-02-25: Añadido FCGS
- 2025-02-10: Eliminado IGS ya que la publicación fue retirada
- 2025-02-05: Añadido CodecGS
- 2024-11-21: Añadido ContextGS
- 2024-11-07: Añadido CompGS
- 2024-11-05: Actualizada versión [arXiv](https://arxiv.org/abs/2407.09510) con métodos de compresión y compactación y fundamentos de la compresión 3DGS
- 2024-10-21: Renombramiento oficial de métodos de "densificación" a métodos de "compactación" en el sitio web para alinear con el artículo de revisión
- 2024-10-17: Añadidos GaussiansPro, AtomGS y Taming3DGS a métodos de densificación/compactación
- 2024-10-14: Añadido MesonGS a métodos de compresión
- 2024-09-30: Añadidos métodos de densificación a la revisión
- 2024-09-17: Actualizados resultados de Morgenstern et al. y revertidos resultados de HAC debido a [confusión sobre convenciones de prueba](https://github.com/YihangChen-ee/HAC/issues/14)
- 2024-09-05: Actualizados resultados de Scaffold-GS MipNeRF-360 para incluir las 9 escenas
- 2024-08-27: Añadido método IGS a la revisión
- 2024-08-26: Añadido método gsplat a la revisión
- 2024-08-14: Rangos adaptativos basados en selección de atributo y conjunto de datos
- 2024-08-12: Nuevos gráficos para mostrar métricas sobre número de Gaussianas en lugar del tamaño del modelo
- 2024-08-08: Añadidas casillas para seleccionar métricas y conjuntos de datos a mostrar en la tabla
- 2024-08-07: Incluido número de Gaussianas en la revisión, incluido bits por Gaussiana en la tabla
- 2024-08-02: Mostrar conferencias de los artículos publicados
- 2024-06-19: Nuevo cálculo de rangos con todos los conjuntos de datos disponibles
- 2024-06-17: Incluidos rangos de métodos
- 2024-06-17: Publicación inicial de la revisión en [arXiv](https://arxiv.org/abs/2407.09510)
- 2024-06-13: Añadidos gráficos de métricas sobre tamaño del modelo
- 2024-06-10: Primer borrador de página de revisión con tabla interactiva














---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-30

---
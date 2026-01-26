## PSICHIC: red neuronal gráfica fisicoquímica para aprender huellas de interacción proteína-ligando a partir de datos de secuencia [[Nature Machine Intelligence](https://www.nature.com/articles/s42256-024-00847-1)]

<img src="https://raw.githubusercontent.com/huankoh/PSICHIC/main/image/PSICHIC.jpg" width="500"/>

## Servidor web PSICHIC <a href="http://www.psichicserver.com" target="_blank"><img src="https://raw.githubusercontent.com/huankoh/PSICHIC/main/image/crystal_ball.png" alt="PSICHIC Webserver" width="30"/></a>

¡Noticias emocionantes❗ El servidor web PSICHIC (versión beta) ya está disponible! 🚀 Experimenta el futuro del análisis de interacción proteína-ligando en [www.psichicserver.com](https://www.psichicserver.com/)

_Comienza a explorar. Tu próximo descubrimiento_ 🌐🔬 _¡podría estar a solo unos clics!_

<sub>Nota: Este servidor no está oficialmente asociado con el artículo. Para la versión oficial, puedes consultar el Colab y la configuración de despliegue local a continuación.</sub>

## Plataforma de cribado virtual PSICHIC <a href="https://colab.research.google.com/github/huankoh/PSICHIC/blob/main/PSICHIC.ipynb" target="_parent"><img src="https://colab.research.google.com/assets/colab-badge.svg" alt="Open In Colab"/></a>

- **Solo datos de secuencia**: Solo necesitas pares de secuencia de proteína + SMILES de ligando.
- **Cribado rápido**: Hasta 100K compuestos en una hora.
- **Análisis profundo**: Descubre insights moleculares con análisis farmacóforo y mutagénesis dirigida potenciados por PSICHIC.

**ACTUALIZACIÓN:** Incluimos un cuaderno jupyter en la subcarpeta de selectividad para demostrar cómo PSICHIC puede usarse para el perfilado de selectividad.

## Configuración del entorno PSICHIC para despliegue local
<details>
<summary>Haz clic para mostrar el contenido del desarrollo local de PSICHIC </summary>


Actualmente, PSICHIC está validado para uso en MacOS (OSX), Linux y Windows. Recomendamos la instalación vía conda, o mejor aún, usando el gestor de paquetes y entornos más rápido mamba. Mamba puede instalarse con el comando ``conda install mamba -n base -c conda-forge``. Para la configuración usando conda o mamba, por favor consulta la línea de código relevante proporcionada a continuación.

```
## OSX 
conda env create -f environment_osx.yml  # if mamba: mamba env create -f environment_osx.yml
## LINUX or Windows GPU
conda env create -f environment_gpu.yml # if mamba: mamba env create -f environment_gpu.yml
conda activate psichic_fp
pip install torch_scatter torch_sparse torch_cluster torch_spline_conv -f https://data.pyg.org/whl/torch-2.1.0+cu118.html
## LINUX or Windows CPU
conda env create -f environment_cpu.yml  # if mamba: mamba env create -f environment_cpu.yml
conda activate psichic_fp
pip install torch_scatter torch_sparse torch_cluster torch_spline_conv -f https://data.pyg.org/whl/torch-2.1.0+cpu.html
```

Alternativamente, líneas de comandos que pueden ser útiles para configurar el entorno (probado en Linux con Python 3.8). 
```
conda create --name psichic_fp python=3.8
conda install pytorch==2.0.0 torchvision==0.15.0 torchaudio==2.0.0 pytorch-cuda=11.7 -c pytorch -c nvidia
conda install pyg -c pyg
conda install -c conda-forge rdkit==2022.09.5
pip install scipy biopython pandas biopandas timeout_decorator py3Dmol umap-learn plotly mplcursors lifelines reprint
pip install "fair-esm"
```

## BYO-PSICHIC con Datos de Secuencia Anotados

Cree un archivo csv de train, valid y test en una carpeta de datos (para ejemplos, vea la carpeta del conjunto de datos). La carpeta de datos debe contener al menos un archivo train.csv y test.csv. Dependiendo de sus etiquetas anotadas, debe usar ``--regression_task True`` si es una etiqueta de valor continuo (por ejemplo, afinidad de unión), ``--classification_task True`` si es una etiqueta de clase binaria (por ejemplo, presencia de interacción) y ``--mclassification_task C`` donde C representa el número de clases en sus etiquetas multiclase (por ejemplo, 3 si está utilizando nuestro conjunto de datos de respuesta funcional proteína-ligando). Tenga en cuenta que puede tener un conjunto de datos con múltiples tipos de etiquetas y entrenaremos PSICHIC para predecir múltiples propiedades de interacción proteína-ligando (vea PSICHIC-MultiTask a continuación)

```
python main.py --datafolder annotated_folder --result_path result/annotated_result --regression_task True 
```
BYO-PSICHIC utilizando un conjunto de datos de referencia, por ejemplo, el conjunto de referencia PDBBind v2020:

```
python main.py --datafolder dataset/pdb2020 --result_path result/PDB2020_BENCHMARK --regression_task True 
```
Las configuraciones del modelo y del optimizador son consistentes en todos los conjuntos de datos de referencia, excepto en PDBBind v2016 donde se desea cambiar el número de iteraciones de entrenamiento del optimizador, los betas y eps a 30000, "(0.9,0.99)" y 1e-5 respectivamente, es decir, añadir a la línea de comandos: ``--total_iters 30000 --betas "(0.9,0.99)" --eps 1e-5``. Para la tarea de clasificación binaria, reemplace ``--regression_task True`` por ``--classification_task True``. Para el conjunto de datos de efecto funcional de proteínas, reemplace ``--regression_task True`` por ``--mclassification_task 3``. Siéntase libre de ajustar los hiperparámetros del modelo en el archivo config.json, ¡háganos saber si encuentra algún resultado interesante!


## Estructura del Conjunto de Datos y Directrices de Formateo BYO
Todos los conjuntos de datos referenciados en nuestro manuscrito están disponibles en Google Drive ([Dataset](https://drive.google.com/drive/folders/1ZRpnwXtllCP89hjhfDuPivBlarBIXnmu?usp=sharing)). Para los conjuntos de datos utilizados en la evaluación de referencia de PSICHIC, tenemos archivos CSV de train, valid y test que se han creado basados en configuraciones de división establecidas. Un README.md separado en la sección del conjunto de datos está dedicado a explicar el propósito de cada conjunto de datos en el enlace de Google Drive (esto es similar a la Tabla de Datos Extendidos 1 en nuestro manuscrito).

Conjunto de Datos BYO-PSICHIC: Cada archivo debería verse algo así si está interesado en entrenar BYO-PSICHIC. No se requiere un archivo CSV de validación si no tiene uno, por ejemplo, si planea aplicar los resultados en experimentos externos.

__Regresión de Afinidad de Unión__

| Proteína | Ligando | etiqueta_regresión | 
|:----------:|:----------:|:----------:|
| ISAFQAAYIGIE....  | C1CCCCC1  | 6.7 | 
| GGALVSVISAFQASV....  | O=C(C)Oc1ccccc1C(=O)O | 4.0 |
|...|...| ...|
| MIPSAYIGIEVLI... | CCO | 8.1 | 

```
python main.py --datafolder BYO_DATASET --result_path BYO_RESULT --regression_task True 
```

__Clasificación de Interacción Binaria__

| Proteína | Ligando | etiqueta_de_clasificación | 
|:----------:|:----------:|:----------:|
| ISAFQAAYIGIE....  | C1CCCCC1  | 1 | 
| GGALVSVISAFQASV.... | O=C(C)Oc1ccccc1C(=O)O | 0 |
|...|...| ...|
| MIPSAYIGIEVLI.... | CCO | 1 | 

```
python main.py --datafolder BYO_DATASET --result_path BYO_RESULT --classification_task True
```

__Clasificación del Efecto Funcional (Clasificación de Tres Vías)__

| Proteína | Ligando | etiqueta_multiclase | 
|:----------:|:----------:|:----------:|
| ISAFQAAYIGIE....  | C1CCCCC1  | -1 |  # antagonista
| GGALVSVISAFQASV.... | O=C(C)Oc1ccccc1C(=O)O | 0 | # no unión
|...|...| ...|
| MIPSAYIGIEVLI.... | CCO | 1 | # agonista

```
python main.py --datafolder BYO_DATASET --result_path BYO_RESULT --mclassification_task 3
```

__Multi Task PSICHIC__

| Proteína | Ligando | etiqueta_regresión | etiqueta_multiclase | 
|:----------:|:----------:|:----------:|:----------:|
| ISAFQAAYIGIE....  | C1CCCCC1  | 6.7 | -1 |  # antagonista
| GGALVSVISAFQASV....  | O=C(C)Oc1ccccc1C(=O)O | 4.0 | 0 | # no unión
|...|...| ...|
| MIPSAYIGIEVLI.... | CCO | 8.1 | 1 | # agonista

```
python main.py --datafolder BYO_DATASET --result_path BYO_RESULT --regression_task True --mclassification_task 3
```
**¿Dividir estratégicamente su conjunto de datos?** Hay un cuaderno Jupyter en la carpeta del conjunto de datos disponible para ilustrar cómo realizamos divisiones aleatorias, divisiones con proteínas no vistas y divisiones con andamios de ligandos no vistos para evaluar la generalizabilidad de PSICHIC u otros métodos. Esto puede ser útil para evaluar si el BYO-PSICHIC funciona con sus datos de secuencia anotados.
 
## PSICHIC<sub>XL</sub>: Entrenamiento de Predicción Multitarea en Conjunto de Datos de Interacciones a Gran Escala
El PSICHIC<sub>XL</sub> fue referido anteriormente como el PSICHIC multitarea preentrenado. El PSICHIC<sub>A1R</sub> fue referido anteriormente como el PSICHIC multitarea ajustado finamente. Cambiamos el nombre para aclarar que PSICHIC<sub>XL</sub> puede usarse tal cual sin entrenamiento adicional. Sin embargo, PSICHIC<sub>XL</sub> puede potencialmente mejorar sus capacidades de clasificación en cribado virtual cuando se afina con datos específicos para un objetivo proteico, por ejemplo, el PSICHIC<sub>A<sub>1</sub>R</sub> que mostramos a continuación usando datos relacionados con A<sub>1</sub>R.

### Entrenamiento de PSICHIC<sub>XL</sub> (TAMBIÉN llamado PSICHIC preentrenado en el preprint)

```
python main.py --datafolder dataset/large_scale_interaction_dataset --result_path PSICHIC_MultiTask_Pretrain --lrate 1e-5 --sampling_col pretrain_sampling_weight --regression_task True --mclassification_task 3 --total_iters 300000 --evaluate_step 25000
```
### Ajustar fino PSICHIC<sub>XL</sub> a PSICHIC<sub>A<sub>1</sub>R</sub> (también conocido como PSICHIC ajustado fino en Preprint)  
Ajustamos fino solo las capas de aplicación de PSICHIC<sub>XL</sub> durante 1000 iteraciones en la proteína relacionada con A<sub>1</sub>R usando el siguiente comando:
```
python main.py --regression_task True --mclassification_task 3 --datafolder dataset/A1R_FineTune --result_path PSICHIC_A1R_FineTune --lrate 1e-5 --total_iters 1000 --finetune_modules "['reg_out','mcls_out']" --trained_model_path trained_weights/multitask_PSICHIC
```
Hemos renombrado la versión de PSICHIC entrenada con el extenso conjunto de datos de interacción como PSICHIC<sub>XL</sub>, y el subconjunto centrado en datos de A<sub>1</sub>R como PSICHIC<sub>A<sub>1</sub>R</sub>. Anteriormente, PSICHIC<sub>XL</sub> y PSICHIC<sub>A<sub>1</sub>R</sub> se conocían como PSICHIC preentrenado y PSICHIC afinado, respectivamente. Este cambio refleja con mayor precisión la amplia aplicabilidad de PSICHIC<sub>XL</sub> y el énfasis específico de PSICHIC<sub>A<sub>1</sub>R</sub> en A1R.

Para cualquier otra proteína, puede filtrar las proteínas irrelevantes y los no unidores en el conjunto de datos de interacción a gran escala para aplicar PSICHIC en otros experimentos.
</details>



## Referencias

Para más información, por favor consulte nuestro trabajo: 

```
PSICHIC: physicochemical graph neural network for learning protein-ligand interaction fingerprints from sequence data
Huan Yee Koh, Anh T.N. Nguyen, Shirui Pan, Lauren T. May, Geoffrey I. Webb
bioRxiv 2023.09.17.558145; doi: https://doi.org/10.1101/2023.09.17.558145
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-26

---
<h1 align="center">
  Aprendiendo el lenguaje de las interacciones proteína-proteína 
</h1>

## 🌿 Resumen de MINT

MINT (Multimeric INteraction Transformer) es un Modelo de Lenguaje de Proteínas (PLM) diseñado para el modelado **contextual y escalable** de secuencias de proteínas que interactúan. Entrenado con un conjunto grande y curado de **96 millones de interacciones proteína-proteína (PPIs)** de la base de datos STRING, MINT supera a los PLMs existentes en diversas tareas y tipos de proteínas, incluyendo:

- Predicción de afinidad de unión
- Estimación del efecto mutacional
- Modelado de ensamblajes complejos de proteínas
- Modelado de interacciones anticuerpo-antígeno
- Predicción de unión receptor de células T–epítopo

🔬 **¿Por qué MINT?**

✅ Primer PLM entrenado con datos a gran escala de PPI

✅ Rendimiento de vanguardia en múltiples tareas de PPI

✅ Escalable y adaptable para diversas interacciones proteicas

## 🖥️ Instalación 

1. Crea un nuevo entorno [conda](https://docs.anaconda.com/miniconda/install/) a partir del archivo `enviroment.yml` proporcionado. 

```
conda env create --name mint --file=environment.yml
```
2. Active el entorno e instale el paquete desde la fuente.


```
conda activate mint
pip install -e .
```
3. Verifique si puede importar el paquete.


```
python -c "import mint; print('Success')" 
```
4. Descargue el punto de control del modelo y anote la ruta del archivo donde se guarda.


```
wget https://huggingface.co/varunullanat2012/mint/resolve/main/mint.ckpt
```

## 🚀 Cómo usar 

### Generación de embeddings

Sugerimos generar embeddings a partir de un archivo CSV que contenga las secuencias que interactúan como este [aquí](https://raw.githubusercontent.com/VarunUllanat/mint/main/./data/protein_sequences.csv). Luego, simplemente ejecute el siguiente código para obtener embeddings promedio sobre todas las secuencias de entrada. 

```
import torch
from mint.helpers.extract import load_config, CSVDataset, CollateFn, MINTWrapper

cfg = load_config("data/esm2_t33_650M_UR50D.json") # model config
device = 'cuda:0' # GPU device
checkpoint_path = '' # Where you stored the model checkpoint

dataset = CSVDataset('data/protein_sequences.csv', 'Protein_Sequence_1', 'Protein_Sequence_2')
loader = torch.utils.data.DataLoader(dataset, batch_size=2, collate_fn=CollateFn(512), shuffle=False) 

wrapper = MINTWrapper(cfg, checkpoint_path, device=device)

chains, chain_ids = next(iter(loader)) # Get the first batch
chains = chains.to(device)
chain_ids = chain_ids.to(device)
embeddings = wrapper(chains, chain_ids)  # Generate embeddings
print(embeddings.shape) # Should be of shape (2, 1280)
```

Sin embargo, **recomendamos** usar el argumento `sep_chains=True` en la clase wrapper para obtener el máximo rendimiento en tareas posteriores. Esto obtiene la incrustación a nivel de secuencia para **todas las secuencias**, y la devuelve concatenada en el mismo orden que la entrada. 

```
wrapper = MINTWrapper(cfg, checkpoint_path, sep_chains=True, device=device)

chains, chain_ids = next(iter(loader)) # Get the first batch
chains = chains.to(device)
chain_ids = chain_ids.to(device)
embeddings = wrapper(chains, chain_ids)  # Generate embeddings
print(embeddings.shape) # Should be of shape (2, 2560)
```

### Clasificación binaria de PPI

Proporcionamos código y un [punto de control del modelo](https://huggingface.co/varunullanat2012/mint/blob/main/bernett_mlp.pth) para predecir si dos secuencias de entrada interactúan o no. El modelo downstream, que es un MLP, se entrena utilizando los datos estándar de oro de [Bernett et al.](./downstream/GeneralPPI/ppi). 

```
import torch
from mint.helpers.extract import load_config, CSVDataset, CollateFn, MINTWrapper
from mint.helpers.predict import SimpleMLP

cfg = load_config("data/esm2_t33_650M_UR50D.json") # model config
device = 'cuda:0' # GPU device
checkpoint_path = 'mint.ckpt' # Where you stored the model checkpoint
mlp_checkpoint_path = 'bernett_mlp.pth' # Where you stored the Bernett MLP checkpoint

dataset = CSVDataset('data/protein_sequences.csv', 'Protein_Sequence_1', 'Protein_Sequence_2')
loader = torch.utils.data.DataLoader(dataset, batch_size=2, collate_fn=CollateFn(512), shuffle=False) 

wrapper = MINTWrapper(cfg, checkpoint_path, sep_chains=True, device=device)

# Generate embeddings 
chains, chain_ids = next(iter(loader)) 
chains = chains.to(device)
chain_ids = chain_ids.to(device)
embeddings = wrapper(chains, chain_ids) # Should be of shape (2, 2560)

# Predict using trained MLP
model = SimpleMLP() 
mlp_checkpoint = torch.load(mlp_checkpoint_path)
model.load_state_dict(mlp_checkpoint)
model.eval()
model.to(device)

predictions = torch.sigmoid(model(embeddings)) # Should be of shape (2, 1)
print(predictions) # Probability of interaction (0 is no, 1 is yes)
```

### Ajuste fino

Para ajustar finamente nuestro modelo en un nuevo conjunto de datos supervisado, simplemente configure el parámetro `freeze_percent` a cualquier valor distinto de 1. Configurarlo en 0.5 significa que el 50% final de las capas del modelo pueden ser entrenadas. Por ejemplo, 

```
import torch
from mint.helpers.extract import MINTWrapper

cfg = load_config("data/esm2_t33_650M_UR50D.json") # model config
device = 'cuda:0' # GPU device
checkpoint_path = '' # path where you stored the model checkpoint

wrapper = MINTWrapper(cfg, checkpoint_path, freeze_percent=0.5, device=device)
for name, param in wrapper.model.named_parameters():
    print(f"Parameter: {name}, Trainable: {param.requires_grad}")
```

### Pre-entrenamiento en STRING-DB 

Esta sección describe los pasos necesarios para preentrenar MINT en PPIs de STRING-DB. Primero, para crear las divisiones de entrenamiento y validación que usamos, primero descargue `protein.physical.links.v12.0.txt.gz` y `protein.sequences.v12.0.fa.gz` de [STRING-DB](https://stringdb-downloads.org/download/). 

Luego, ejecute los siguientes comandos para agrupar las secuencias utilizando un umbral de similitud de secuencia del 50 % usando [mmseqs](https://github.com/soedinglab/MMseqs2).

```
mmseqs createdb protein.sequences.v12.0.fa DB100
mmseqs cluster DB100 clu50 /tmp/mmseqs --min-seq-id 0.50 --remove-tmp-files
mmseqs createtsv DB100 DB100 clu50 clu50.tsv
```

Luego, ejecute `stringdb.py`, asegurándose de que las rutas de archivos en ese script coincidan con las rutas donde guardó los archivos `protein.sequences.v12.0.fa`, `clu50.tsv` (salida del paso anterior) y `protein.physical.links.full.v12.0.txt.gz`. 

Finalmente, ejecute el entrenamiento así:

```
python train.py --batch_size 2 --crop_len 512 --model 650M --val_check_interval 320000 --accumulate_grad 32 --run_name 650M_nofreeze_filtered --copy_weights --wandb --dataset_split filtered
```

### Ejemplos

Proporcionamos varios ejemplos que destacan los casos de uso de MINT en diversas tareas supervisadas y diferentes tipos de proteínas en la carpeta `downstream`.

1. [Predecir si dos proteínas interactúan o no](./downstream/GeneralPPI/ppi)
2. [Predecir la afinidad de unión de complejos proteicos](./downstream/GeneralPPI/pdb-bind)
3. [Predecir si dos proteínas interactúan o no después de una mutación](./downstream/GeneralPPI/mutational-ppi)
4. [Predecir la diferencia en la afinidad de unión en complejos proteicos tras una mutación](./downstream/GeneralPPI/SKEMPI_v2)


## 📝 Citando 

```
@article{ullanat2026learning,
  title={Learning the language of protein-protein interactions},
  author={Ullanat, Varun and Jing, Bowen and Sledzieski, Samuel and Berger, Bonnie},
  journal={Nature Communications},
  year={2026},
  publisher={Nature Publishing Group UK London}
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-10

---
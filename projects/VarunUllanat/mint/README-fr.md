<h1 align="center">
  Apprendre le langage des interactions protéine-protéine 
</h1>

## 🌿 Présentation de MINT

MINT (Multimeric INteraction Transformer) est un modèle de langage des protéines (PLM) conçu pour la modélisation **contextuelle et évolutive** des séquences protéiques en interaction. Entraîné sur un ensemble important et sélectionné de **96 millions d’interactions protéine-protéine (IPP)** issues de la base de données STRING, MINT surpasse les PLM existants dans diverses tâches et types de protéines, notamment :

- Prédiction de l’affinité de liaison
- Estimation des effets mutagènes
- Modélisation d’assemblages protéiques complexes
- Modélisation des interactions anticorps-antigène
- Prédiction de la liaison récepteur T – épitope

🔬 **Pourquoi MINT ?**

✅ Premier PLM entraîné sur des données IPP à grande échelle

✅ Performances de pointe sur plusieurs tâches IPP

✅ Évolutif et adaptable à diverses interactions protéiques

## 🖥️ Installation 

1. Créez un nouvel environnement [conda](https://docs.anaconda.com/miniconda/install/) à partir du fichier `enviroment.yml` fourni. 

```
conda env create --name mint --file=environment.yml
```
2. Activez l'environnement et installez le paquet depuis la source.


```
conda activate mint
pip install -e .
```
3. Vérifiez si vous êtes capable d'importer le paquet.


```
python -c "import mint; print('Success')" 
```

4. Téléchargez le point de contrôle du modèle et notez le chemin du fichier où il est stocké.

```
wget https://huggingface.co/varunullanat2012/mint/resolve/main/mint.ckpt
```

## 🚀 Comment utiliser 

### Génération d'embeddings

Nous suggérons de générer des embeddings à partir d'un fichier CSV contenant les séquences d'interaction comme celui-ci [ici](https://raw.githubusercontent.com/VarunUllanat/mint/main/./data/protein_sequences.csv). Ensuite, exécutez simplement le code suivant pour obtenir des embeddings moyens sur toutes les séquences d'entrée. 

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
Cependant, nous **recommandons** d'utiliser l'argument `sep_chains=True` dans la classe wrapper pour des performances maximales sur les tâches en aval. Cela obtient l'encodage au niveau de la séquence pour **toutes les séquences**, et le renvoie concaténé dans le même ordre que l'entrée.


```
wrapper = MINTWrapper(cfg, checkpoint_path, sep_chains=True, device=device)

chains, chain_ids = next(iter(loader)) # Get the first batch
chains = chains.to(device)
chain_ids = chain_ids.to(device)
embeddings = wrapper(chains, chain_ids)  # Generate embeddings
print(embeddings.shape) # Should be of shape (2, 2560)
```

### Classification binaire des PPI

Nous fournissons un code et un [point de contrôle du modèle](https://huggingface.co/varunullanat2012/mint/blob/main/bernett_mlp.pth) pour prédire si deux séquences d'entrée interagissent ou non. Le modèle en aval, qui est un MLP, est entraîné en utilisant les données de référence de [Bernett et al.](./downstream/GeneralPPI/ppi). 

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

### Ajustement fin

Pour ajuster finement notre modèle sur un nouveau jeu de données supervisé, il suffit de définir le paramètre `freeze_percent` à une valeur différente de 1. Le régler à 0,5 signifie que les 50 % derniers des couches du modèle peuvent être entraînés. Par exemple, 

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

### Pré-entraînement sur STRING-DB

Cette section décrit les étapes nécessaires pour préentraîner MINT sur les interactions protéines-protéines (PPI) de STRING-DB. Tout d'abord, pour créer les divisions train-validation que nous avons utilisées, téléchargez d'abord `protein.physical.links.v12.0.txt.gz` et `protein.sequences.v12.0.fa.gz` depuis [STRING-DB](https://stringdb-downloads.org/download/).

Ensuite, exécutez les commandes suivantes pour regrouper les séquences en utilisant un seuil de similarité de séquence de 50% avec [mmseqs](https://github.com/soedinglab/MMseqs2).

```
mmseqs createdb protein.sequences.v12.0.fa DB100
mmseqs cluster DB100 clu50 /tmp/mmseqs --min-seq-id 0.50 --remove-tmp-files
mmseqs createtsv DB100 DB100 clu50 clu50.tsv
```

Ensuite, exécutez `stringdb.py`, en vous assurant que les chemins de fichiers dans ce script correspondent aux emplacements où vous avez stocké les fichiers `protein.sequences.v12.0.fa`, `clu50.tsv` (sortie de l'étape précédente), et `protein.physical.links.full.v12.0.txt.gz`. 

Enfin, lancez l'entraînement de cette manière :

```
python train.py --batch_size 2 --crop_len 512 --model 650M --val_check_interval 320000 --accumulate_grad 32 --run_name 650M_nofreeze_filtered --copy_weights --wandb --dataset_split filtered
```

### Exemples 

Nous fournissons plusieurs exemples mettant en évidence les cas d'utilisation de MINT sur diverses tâches supervisées et différents types de protéines dans le dossier `downstream`. 

1. [Prédire si deux protéines interagissent ou non](./downstream/GeneralPPI/ppi)
2. [Prédire l'affinité de liaison des complexes protéiques](./downstream/GeneralPPI/pdb-bind)
3. [Prédire si deux protéines interagissent ou non après mutation](./downstream/GeneralPPI/mutational-ppi)
4. [Prédire la différence d'affinité de liaison dans les complexes protéiques après mutation](./downstream/GeneralPPI/SKEMPI_v2)


## 📝 Citation 

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
<h1 align="center">
  Learning the language of protein-protein interactions 
</h1>

## 🌿 Overview of MINT

MINT (Multimeric INteraction Transformer) is a Protein Language Model (PLM) designed for **contextual and scalable** modeling of interacting protein sequences. Trained on a large, curated set of **96 million protein-protein interactions (PPIs)** from the STRING database, MINT outperforms existing PLMs across diverse tasks and protein types, including:

- Binding affinity prediction
- Mutational effect estimation
- Complex protein assembly modeling
- Antibody-antigen interaction modeling
- T cell receptor–epitope binding prediction

🔬 **Why MINT?**

✅ First PLM to be trained on large-scale PPI data

✅ State-of-the-art performance across multiple PPI tasks

✅ Scalable and adaptable for diverse protein interactions

## 🖥️ Installation 

1. Create a new [conda](https://docs.anaconda.com/miniconda/install/) environment from the provided `enviroment.yml` file. 

```
conda env create --name mint --file=environment.yml
```

2. Activate the enviroment and install the package from source.

```
conda activate mint
pip install -e .
```

3. Check if you are able to import the package.

```
python -c "import mint; print('Success')" 
```

4. Download the model checkpoint and note the file path where it is stored.

```
wget https://huggingface.co/varunullanat2012/mint/resolve/main/mint.ckpt
```

## 🚀 How to use 

### Generating embeddings

We suggest generating embeddings from a CSV file containing the interacting sequences like this one [here](https://raw.githubusercontent.com/VarunUllanat/mint/main/./data/protein_sequences.csv). Next, simply execute the following code to get average embeddings over all input sequences. 

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

However, we **recommend** using the `sep_chains=True` argument in the wrapper class for maximum performance on downstream tasks. This gets the sequence-level embedding for **all sequences**, and returns it concatenated in the same order as the input. 

```
wrapper = MINTWrapper(cfg, checkpoint_path, sep_chains=True, device=device)

chains, chain_ids = next(iter(loader)) # Get the first batch
chains = chains.to(device)
chain_ids = chain_ids.to(device)
embeddings = wrapper(chains, chain_ids)  # Generate embeddings
print(embeddings.shape) # Should be of shape (2, 2560)
```

### Binary PPI classification

We provide code and a [model checkpoint](https://huggingface.co/varunullanat2012/mint/blob/main/bernett_mlp.pth) to predict whether two input sequences interact or not. The downstream model, which is an MLP, is trained using the gold-standard data from [Bernett et al.](./downstream/GeneralPPI/ppi). 

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

### Finetuning 

To finetune our model on a new supervised dataset, simply set the `freeze_percent` parameter to anything other than 1. Setting it to 0.5 means the last 50% of the model layers can be trained. For example, 

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

### Pre-training on STRING-DB 

This section outlines the steps required to pretrain MINT on PPIs from STRING-DB. First, to create the train-validation splits we used, first download `protein.physical.links.v12.0.txt.gz` and `protein.sequences.v12.0.fa.gz` from [STRING-DB](https://stringdb-downloads.org/download/). 

Then, run the following commands to cluster the sequences using a 50% sequence similarity threshold using [mmseqs](https://github.com/soedinglab/MMseqs2).

```
mmseqs createdb protein.sequences.v12.0.fa DB100
mmseqs cluster DB100 clu50 /tmp/mmseqs --min-seq-id 0.50 --remove-tmp-files
mmseqs createtsv DB100 DB100 clu50 clu50.tsv
```

Then, run `stringdb.py`, ensuring that the filepaths in that script match the paths where you stored the `protein.sequences.v12.0.fa`, `clu50.tsv` (output of the previous step), and `protein.physical.links.full.v12.0.txt.gz` files. 

Finally, run the training like this:

```
python train.py --batch_size 2 --crop_len 512 --model 650M --val_check_interval 320000 --accumulate_grad 32 --run_name 650M_nofreeze_filtered --copy_weights --wandb --dataset_split filtered
```

### Examples 

We provide several examples highlighting the use cases of MINT on various supervised tasks and different protein types in the `downstream` folder. 

1. [Predict whether two proteins interact or not](./downstream/GeneralPPI/ppi)
2. [Predict the binding affinity of protein complexes](./downstream/GeneralPPI/pdb-bind)
3. [Predict whether two proteins interact or not after mutation](./downstream/GeneralPPI/mutational-ppi)
4. [Predict the difference in binding affinity in protein complexes upon mutation](./downstream/GeneralPPI/SKEMPI_v2)


## 📝 Citing 

```
@article{ullanat2026learning,
  title={Learning the language of protein-protein interactions},
  author={Ullanat, Varun and Jing, Bowen and Sledzieski, Samuel and Berger, Bonnie},
  journal={Nature Communications},
  year={2026},
  publisher={Nature Publishing Group UK London}
}
```

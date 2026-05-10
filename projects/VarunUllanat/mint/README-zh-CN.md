<h1 align="center">
  学习蛋白质-蛋白质相互作用的语言 
</h1>

## 🌿 MINT 概述

MINT（多聚体相互作用转换器）是一种蛋白质语言模型（PLM），专为**上下文相关且可扩展**的蛋白质序列相互作用建模设计。MINT 在 STRING 数据库中经过精心筛选的**9600万蛋白质-蛋白质相互作用（PPI）**大规模数据集上训练，性能优于现有的 PLM，适用于多种任务和蛋白质类型，包括：

- 结合亲和力预测
- 突变效应估计
- 复杂蛋白质组装建模
- 抗体-抗原相互作用建模
- T 细胞受体-表位结合预测

🔬 **为何选择 MINT？**

✅ 首个在大规模 PPI 数据上训练的 PLM

✅ 多个 PPI 任务上的最先进性能

✅ 可扩展且适用于多样化的蛋白质相互作用

## 🖥️ 安装

1. 使用提供的 `enviroment.yml` 文件创建一个新的 [conda](https://docs.anaconda.com/miniconda/install/) 环境。

```
conda env create --name mint --file=environment.yml
```
2. 激活环境并从源代码安装软件包。


```
conda activate mint
pip install -e .
```

3. 检查您是否能够导入该包。

```
python -c "import mint; print('Success')" 
```

4. 下载模型检查点并记下存储的文件路径。

```
wget https://huggingface.co/varunullanat2012/mint/resolve/main/mint.ckpt
```

## 🚀 如何使用

### 生成嵌入向量

我们建议从包含交互序列的CSV文件生成嵌入向量，类似这个[链接](https://raw.githubusercontent.com/VarunUllanat/mint/main/./data/protein_sequences.csv)。接下来，只需执行以下代码即可获得所有输入序列的平均嵌入向量。 

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
然而，我们**建议**在包装类中使用`sep_chains=True`参数，以在下游任务中获得最佳性能。这样可以获得**所有序列**的序列级嵌入，并按输入的相同顺序连接返回。


```
wrapper = MINTWrapper(cfg, checkpoint_path, sep_chains=True, device=device)

chains, chain_ids = next(iter(loader)) # Get the first batch
chains = chains.to(device)
chain_ids = chain_ids.to(device)
embeddings = wrapper(chains, chain_ids)  # Generate embeddings
print(embeddings.shape) # Should be of shape (2, 2560)
```

### 二元PPI分类

我们提供代码和一个[模型检查点](https://huggingface.co/varunullanat2012/mint/blob/main/bernett_mlp.pth)，用于预测两个输入序列是否相互作用。下游模型是一个多层感知器（MLP），使用来自[Bernett等人](./downstream/GeneralPPI/ppi)的黄金标准数据进行训练。

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

### 微调

要在新的有监督数据集上微调我们的模型，只需将 `freeze_percent` 参数设置为不等于 1 的值。将其设置为 0.5 意味着模型的后 50% 层可以被训练。例如， 

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

### 在 STRING-DB 上进行预训练

本节概述了在 STRING-DB 的蛋白质-蛋白质相互作用（PPI）数据上对 MINT 进行预训练所需的步骤。首先，为了创建我们使用的训练-验证集划分，先从 [STRING-DB](https://stringdb-downloads.org/download/) 下载 `protein.physical.links.v12.0.txt.gz` 和 `protein.sequences.v12.0.fa.gz` 文件。

然后，运行以下命令，使用 [mmseqs](https://github.com/soedinglab/MMseqs2) 以 50% 序列相似度阈值对序列进行聚类。

```
mmseqs createdb protein.sequences.v12.0.fa DB100
mmseqs cluster DB100 clu50 /tmp/mmseqs --min-seq-id 0.50 --remove-tmp-files
mmseqs createtsv DB100 DB100 clu50 clu50.tsv
```

然后，运行 `stringdb.py`，确保该脚本中的文件路径与您存储 `protein.sequences.v12.0.fa`、`clu50.tsv`（上一步的输出）和 `protein.physical.links.full.v12.0.txt.gz` 文件的位置相匹配。

最后，像这样运行训练：

```
python train.py --batch_size 2 --crop_len 512 --model 650M --val_check_interval 320000 --accumulate_grad 32 --run_name 650M_nofreeze_filtered --copy_weights --wandb --dataset_split filtered
```

### 示例 

我们在 `downstream` 文件夹中提供了几个示例，突出展示了 MINT 在各种监督任务和不同蛋白类型上的应用场景。 

1. [预测两个蛋白是否相互作用](./downstream/GeneralPPI/ppi)
2. [预测蛋白复合物的结合亲和力](./downstream/GeneralPPI/pdb-bind)
3. [预测突变后两个蛋白是否相互作用](./downstream/GeneralPPI/mutational-ppi)
4. [预测蛋白复合物在突变后结合亲和力的差异](./downstream/GeneralPPI/SKEMPI_v2)


## 📝 引用 

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
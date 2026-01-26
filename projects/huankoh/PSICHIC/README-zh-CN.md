## PSICHIC：用于从序列数据中学习蛋白质-配体相互作用指纹的理化图神经网络 [[Nature Machine Intelligence](https://www.nature.com/articles/s42256-024-00847-1)]

<img src="https://raw.githubusercontent.com/huankoh/PSICHIC/main/image/PSICHIC.jpg" width="500"/>

## PSICHIC 网络服务器 <a href="http://www.psichicserver.com" target="_blank"><img src="https://raw.githubusercontent.com/huankoh/PSICHIC/main/image/crystal_ball.png" alt="PSICHIC Webserver" width="30"/></a>

激动人心的消息❗ PSICHIC 网络服务器（测试版）现已上线！🚀 体验蛋白质-配体相互作用分析的未来，访问 [www.psichicserver.com](https://www.psichicserver.com/)

_开始探索。你的下一次发现_ 🌐🔬 _可能只需几次点击！_

<sub>注：该服务器与论文官方无关联。官方版本请参阅下面的 Colab 和本地部署设置。</sub>

## PSICHIC 虚拟筛选平台 <a href="https://colab.research.google.com/github/huankoh/PSICHIC/blob/main/PSICHIC.ipynb" target="_parent"><img src="https://colab.research.google.com/assets/colab-badge.svg" alt="Open In Colab"/></a>

- **仅需序列数据**：蛋白质序列 + 配体 SMILES 对即可。
- **快速筛选**：一小时内筛选最多 10 万化合物。
- **深度分析**：利用 PSICHIC 支持的药效团和定向诱变分析，揭示分子见解。

**更新：** 我们在 selectivity 子文件夹中新增了 Jupyter 笔记本，演示如何使用 PSICHIC 进行选择性分析。

## PSICHIC 本地部署环境设置
<details>
<summary>点击切换 PSICHIC 本地开发内容</summary>


目前，PSICHIC 已验证可用于 MacOS（OSX）、Linux 和 Windows。我们推荐通过 conda 安装，或者更佳的选择是使用更快的 mamba 包和环境管理器。mamba 可通过命令 ``conda install mamba -n base -c conda-forge`` 安装。有关使用 conda 或 mamba 进行设置，请参阅下面提供的相应代码行。

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
或者，以下命令行可用于设置环境（在使用 Python 3.8 的 Linux 上测试通过）。 

```
conda create --name psichic_fp python=3.8
conda install pytorch==2.0.0 torchvision==0.15.0 torchaudio==2.0.0 pytorch-cuda=11.7 -c pytorch -c nvidia
conda install pyg -c pyg
conda install -c conda-forge rdkit==2022.09.5
pip install scipy biopython pandas biopandas timeout_decorator py3Dmol umap-learn plotly mplcursors lifelines reprint
pip install "fair-esm"
```
## 带注释序列数据的 BYO-PSICHIC

在 datafolder 中创建 train、valid 和 test 的 csv 文件（示例见 dataset 文件夹）。datafolder 中至少应包含 train.csv 和 test.csv 文件。根据您的注释标签，如果是连续值标签（例如，结合亲和力），请使用 ``--regression_task True``；如果是二分类标签（例如，是否存在相互作用），请使用 ``--classification_task True``；如果是多分类标签，请使用 ``--mclassification_task C``，其中 C 表示多分类标签的类别数（例如，如果使用我们的蛋白质-配体功能响应数据集，则为 3）。注意，您可以拥有包含多种标签类型的数据集，我们将训练 PSICHIC 以预测多种蛋白质-配体相互作用属性（见下文的 PSICHIC-MultiTask）。


```
python main.py --datafolder annotated_folder --result_path result/annotated_result --regression_task True 
```

使用基准数据集进行BYO-PSICHIC，例如PDBBind v2020基准：
```
python main.py --datafolder dataset/pdb2020 --result_path result/PDB2020_BENCHMARK --regression_task True 
```
模型和优化器配置在所有基准数据集之间保持一致，除了PDBBind v2016，在该数据集中您需要将优化器的训练迭代次数、betas和eps分别更改为30000、"(0.9,0.99)"和1e-5，即在命令行中添加：``--total_iters 30000 --betas "(0.9,0.99)" --eps 1e-5``。对于二分类任务，将``--regression_task True``替换为``--classification_task True``。对于蛋白质功能效应数据集，将``--regression_task True``替换为``--mclassification_task 3``。欢迎随意调整config.json文件中的模型超参数，如果发现任何有趣的结果，请告诉我们！

## 数据集结构和BYO格式指南
我们手稿中引用的所有数据集均可在Google Drive上获取（[数据集](https://drive.google.com/drive/folders/1ZRpnwXtllCP89hjhfDuPivBlarBIXnmu?usp=sharing)）。对于PSICHIC基准评估中使用的数据集，我们基于既定的划分设置创建了训练、验证和测试CSV文件。数据集部分中有一个单独的README.md文件，用于解释Google Drive链接中每个数据集的用途（这类似于我们手稿中的扩展数据表1）。

BYO-PSICHIC数据集：如果您有兴趣训练BYO-PSICHIC，每个文件应类似如下所示。如果您没有验证CSV文件，例如计划将结果应用于外部实验，则无需验证文件。

__结合亲和力回归__

| 蛋白质 | 配体 | 回归标签 | 
|:----------:|:----------:|:----------:|
| ISAFQAAYIGIE....  | C1CCCCC1  | 6.7 | 
| GGALVSVISAFQASV....  | O=C(C)Oc1ccccc1C(=O)O | 4.0 |
|...|...| ...|
| MIPSAYIGIEVLI... | CCO | 8.1 | 


```
python main.py --datafolder BYO_DATASET --result_path BYO_RESULT --regression_task True 
```

__二元相互作用分类__

| 蛋白质 | 配体 | 分类标签 | 
|:----------:|:----------:|:----------:|
| ISAFQAAYIGIE....  | C1CCCCC1  | 1 | 
| GGALVSVISAFQASV.... | O=C(C)Oc1ccccc1C(=O)O | 0 |
|...|...| ...|
| MIPSAYIGIEVLI.... | CCO | 1 | 

```
python main.py --datafolder BYO_DATASET --result_path BYO_RESULT --classification_task True
```

__功能效应分类（三分类）__

| 蛋白质 | 配体 | 多分类标签 | 
|:----------:|:----------:|:----------:|
| ISAFQAAYIGIE....  | C1CCCCC1  | -1 |  # 拮抗剂
| GGALVSVISAFQASV.... | O=C(C)Oc1ccccc1C(=O)O | 0 | # 非结合物
|...|...| ...|
| MIPSAYIGIEVLI.... | CCO | 1 | # 激动剂

```
python main.py --datafolder BYO_DATASET --result_path BYO_RESULT --mclassification_task 3
```

__多任务 PSICHIC__

| 蛋白质 | 配体 | 回归标签 | 多分类标签 | 
|:----------:|:----------:|:----------:|:----------:|
| ISAFQAAYIGIE....  | C1CCCCC1  | 6.7 | -1 |  # 拮抗剂
| GGALVSVISAFQASV....  | O=C(C)Oc1ccccc1C(=O)O | 4.0 | 0 | # 非结合物
|...|...| ...|
| MIPSAYIGIEVLI.... | CCO | 8.1 | 1 | # 激动剂

```
python main.py --datafolder BYO_DATASET --result_path BYO_RESULT --regression_task True --mclassification_task 3
```

**策略性拆分您的数据集？** 数据集文件夹中的 Jupyter 笔记本展示了我们如何执行随机拆分、未见过的蛋白质拆分和未见过的配体骨架拆分，以评估 PSICHIC 或其他方法的泛化能力。这对于评估 BYO-PSICHIC 是否适用于您的注释序列数据非常有用。
 
## PSICHIC<sub>XL</sub>：大规模相互作用数据集上的多任务预测训练
PSICHIC<sub>XL</sub> 之前称为预训练多任务 PSICHIC。PSICHIC<sub>A1R</sub> 之前称为微调多任务 PSICHIC。我们更改了名称，以澄清 PSICHIC<sub>XL</sub> 可以直接使用，无需任何额外训练。然而，当针对特定蛋白质靶点的数据进行微调时，例如下面展示的使用 A<sub>1</sub>R 相关数据的 PSICHIC<sub>A<sub>1</sub>R</sub>，PSICHIC<sub>XL</sub> 在虚拟筛选中的排名能力有望得到提升。

### 训练 PSICHIC<sub>XL</sub>（即预印本中的预训练 PSICHIC）
```
python main.py --datafolder dataset/large_scale_interaction_dataset --result_path PSICHIC_MultiTask_Pretrain --lrate 1e-5 --sampling_col pretrain_sampling_weight --regression_task True --mclassification_task 3 --total_iters 300000 --evaluate_step 25000
```
### 微调 PSICHIC<sub>XL</sub> 为 PSICHIC<sub>A<sub>1</sub>R</sub>（即预印本中的微调 PSICHIC）  
我们仅对 PSICHIC<sub>XL</sub> 的应用层进行微调，针对 A<sub>1</sub>R 相关蛋白进行 1000 次迭代，使用以下命令：
```
python main.py --regression_task True --mclassification_task 3 --datafolder dataset/A1R_FineTune --result_path PSICHIC_A1R_FineTune --lrate 1e-5 --total_iters 1000 --finetune_modules "['reg_out','mcls_out']" --trained_model_path trained_weights/multitask_PSICHIC
```
我们将基于大规模相互作用数据集训练的 PSICHIC 版本重命名为 PSICHIC<sub>XL</sub>，将聚焦于 A<sub>1</sub>R 数据的子集命名为 PSICHIC<sub>A<sub>1</sub>R</sub>。此前，PSICHIC<sub>XL</sub> 和 PSICHIC<sub>A<sub>1</sub>R</sub> 分别被称为预训练 PSICHIC 和微调 PSICHIC。此更名更准确地反映了 PSICHIC<sub>XL</sub> 的广泛适用性以及 PSICHIC<sub>A<sub>1</sub>R</sub> 对 A1R 的特定侧重。

对于其他蛋白质，您可以筛选掉无关蛋白质和大规模相互作用数据集中的非结合蛋白，以便将 PSICHIC 应用于其他实验。
</details>



## 参考文献

欲了解更多信息，请参阅我们的工作： 

```
PSICHIC: physicochemical graph neural network for learning protein-ligand interaction fingerprints from sequence data
Huan Yee Koh, Anh T.N. Nguyen, Shirui Pan, Lauren T. May, Geoffrey I. Webb
bioRxiv 2023.09.17.558145; doi: https://doi.org/10.1101/2023.09.17.558145
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-26

---
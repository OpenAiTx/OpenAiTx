
# 伴随采样

本仓库包含伴随采样：通过伴随匹配实现高度可扩展扩散采样器的官方实现和实验。

伴随采样是一种高度可扩展的基于扩散的采样框架，能够在没有任何参考数据的情况下学习从未归一化的密度中采样。伴随采样在生成模型和能量函数的复杂度方面具有良好的可扩展性，允许使用最先进的神经能量函数。

**[Arxiv](https://arxiv.org/abs/2504.11713)（ICML 2025 接收）**  
*作者：_Aaron Havens, Benjamin Kurt Miller, Bing Yan, Carles Domingo-Enrich, Anuroop Sriram, Brandon Wood, Daniel Levine, Bin Hu, Brandon Amos, Brian Karrer, Xiang Fu, Guan-Horng Liu, Ricky T. Q. Chen_*

![](https://raw.githubusercontent.com/facebookresearch/adjoint_sampling/main/./assets/molecule_progression.png)

我们在一个新的摊销构象生成任务上评估伴随采样，使用 eSEN 能量函数和 SPICE：一个大规模的有机类药物分子数据集，提供分子图信息——包括原子种类和键结构。

## 安装

安装依赖项。

```bash
micromamba env create -f environment.yml
micromamba activate adjoint_sampling
```


要针对能量模型进行训练，您需要我们[Hugging Face仓库](https://huggingface.co/facebook/adjoint_sampling)中的[eSEN](https://arxiv.org/abs/2502.12147)检查点。只要您为`huggingface-cli`提供了[令牌](https://huggingface.co/settings/tokens)，运行代码时它将自动下载。您必须先[申请访问该仓库](https://huggingface.co/facebook/adjoint_sampling)，令牌才能生效。


```bash
huggingface-cli login
```
## 数据

分子以行的形式组织在 `data/{drugs_test,spice_test,spice_train}.txt` 文件中，包含三列：可旋转键数量、SMILES 字符串和哈希值。查找分子的 [CREST](https://github.com/crest-lab/crest) 构象需要哈希值。对于哈希值为 `${hash}` 的 `{drugs,spice}` 分子，其构象作为拼接的 `.xyz` 块写入单个文本文件，位于目录 `data/{drugs,spice}_test_conformers/${hash}` 下。

`drugs` 中的构象来自 [GEOM](https://github.com/learningmatter-mit/geom)。`spice` 中的构象由 FAIR Chemistry 计算得出。

## 模型

我们所有的模型均托管于 [Hugging Face](https://huggingface.co/facebook/adjoint_sampling)。我们提供了一个脚本，将文件下载到本地目录 `models`。下载模型需要您拥有一个 [令牌](https://huggingface.co/settings/tokens)。您必须先[申请访问该仓库](https://huggingface.co/facebook/adjoint_sampling)后才能下载。


```bash
python download_models.py
```


模型下载完成后，您可以复制路径以用于评估或您自己的项目。检查点可以通过以下方式识别：

```
Cartesian AdjSampling             -   models/am/checkpoints/checkpoint_4999.pt
Cartesian AdjSampling (+pretrain) -   models/bmam/checkpoints/checkpoint_4999.pt
Torsional AdjSampling             -   models/torsion/checkpoints/checkpoint_3000.pt

Pretrained Cartesian              -   pretrain_for_bmam/checkpoints/checkpoint_2000.pt
```
我们提供了用于训练 `Cartesian AdjSampling (+pretrain)` 的 `预训练笛卡尔`。

## 在 SPICE 数据集上的训练

我们使用 8 个 GPU 训练每个模型，训练时间为 72 小时。以下命令将训练相应的模型。

在开始训练之前，请在拥有多个 CPU 的单个节点上运行以下命令！第二个命令仅在您想训练 Torsional AdjSampling 模型时才需要。

```bash
python cache_dataset.py
python cache_dataset.py --learn_torsions
```
我们的代码库支持分布式训练，其中共享文件放置在配置中称为 `shared_dir` 的共享目录中。它默认设置为 `/home/${oc.env:USER}`。由于 [hydra](https://hydra.cc/docs/intro/) 的变量展开语法，训练时该路径会解析为 `/home/${USER}`。

##### 笛卡尔邻域采样

```bash
python train.py experiment=spice_cartesian
```
##### 笛卡尔邻接采样 (+预训练)

该模型需要顺序训练。首先，必须使用第一个命令训练“预训练”模型。然后，需要通过 `init_model=...` 指向初始检查点，使第二个模型从第一个模型初始化。如果未指定 `init_model`，不会报错，但模型不会进行预训练。


```bash
python train.py experiment=spice_cartesian_pretrain_for_bmam
python train.py experiment=spice_cartesian_bmam init_model=???
```
##### 扭转调整采样

```bash
python train.py experiment=spice_torsion
```



## 评估
要评估训练好的模型，请使用 `eval.py`。报告的结果将 `max_n_refs` 设置为 512。


```bash
python eval.py \
--test_mols data/spice_test.txt \
--true_confs data/spice_test_conformers \
--save_path results \
--checkpoint_path path/to/checkpoint.pt \
--max_n_refs 512
```


也可以以分布式方式进行评估，查看 `eval_distributed.sh`。


## 📚 引用

如果您在研究或项目中发现此代码有用，请考虑引用我们的研究论文：


```bibtex
@article{adjoint_sampling,
  title={{A}djoint {S}ampling: Highly Scalable Diffusion Samplers via {A}djoint {M}atching},
  author={Havens, Aaron and Miller, Benjamin Kurt and Yan, Bing and Domingo-Enrich, Carles and Sriram, Anuroop and Wood, Brandon and Levine, Daniel and Hu, Bin and Amos, Brandon and Karrer, Brian and Fu, Xiang and Liu, Guan-Horng and Chen, Ricky T. Q.},
  journal={International Conference on Machine Learning},
  year={2025}
}
```
## 许可协议  
本仓库采用  
[CC BY-NC 4.0 许可协议](https://creativecommons.org/licenses/by-nc/4.0/)。  

### 注意事项  
Adjoint Sampling的大部分内容采用CC-BY-NC许可协议，但项目的部分内容采用单独的许可条款：[DEM](https://github.com/jarridrb/DEM)、[EGNN](https://github.com/vgsatorras/egnn)、[torsional-diffusion](https://github.com/gcorso/torsional-diffusion)、[fairchem](https://github.com/FAIR-Chem/fairchem)采用MIT许可协议。[SPICE](https://github.com/openmm/spice-dataset)和[GEOM](https://github.com/learningmatter-mit/geom)采用CC0许可协议。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---
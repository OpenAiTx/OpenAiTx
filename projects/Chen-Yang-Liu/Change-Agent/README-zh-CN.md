<div align="center">
    
<h1><a href="https://ieeexplore.ieee.org/document/10591792">Change-Agent：迈向交互式综合遥感变化解释与分析</a></h1>

**[刘晨阳](https://chen-yang-liu.github.io/), [陈克言](https://kyanchen.github.io), [张浩天](https://scholar.google.com/citations?user=c7uR6NUAAAAJ), [齐子鹏](https://scholar.google.com/citations?user=KhMtmBsAAAAJ), [邹正霞](https://scholar.google.com.hk/citations?hl=en&user=DzwoyZsAAAAJ), 以及 [石振伟*✉](https://scholar.google.com.hk/citations?hl=en&user=kNhFWQIAAAAJ)**

<div align="center">
  <img src="https://raw.githubusercontent.com/Chen-Yang-Liu/Change-Agent/main/resource/Change_Agent.png" width="400"/>
</div>
</div>

## 如果你对本仓库感兴趣，请给我们一个 :star: 

本文的官方 PyTorch 实现：“**Change-Agent：迈向交互式综合遥感变化解释与分析**”发表于 [[IEEE](https://ieeexplore.ieee.org/document/10591792)] ***(被 IEEE TGRS 2024 接收)***

## 🥳新闻

- 2024-06：代码 **已发布**。
- 2024-03：论文 **已发布**。
- 🔥 我们的综述“**遥感时序视觉-语言模型：一项综合调研**”：[Arxiv](https://arxiv.org/abs/2412.02573) || [Github](https://github.com/Chen-Yang-Liu/Awesome-RS-Temporal-VLM)** 🔥 

## 目录
- [LEVIR-MCI 数据集](#LEVIR-MCI-dataset)
- [多层次变化解释模型训练](#Training-of-the-multi-level-change-interpretation-model)
- [Change-Agent 构建](#Construction-of-Change-Agent)
- [引用](#Citation)

## LEVIR-MCI 数据集 
- 下载 LEVIR_MCI 数据集：[LEVIR-MCI](https://huggingface.co/datasets/lcybuaa/LEVIR-MCI/tree/main)（**现已开放！**）。
- 本数据集是我们先前建立的 [LEVIR-CC 数据集](https://github.com/Chen-Yang-Liu/RSICC) 的扩展，包含双时相影像以及多样的变化检测掩码和描述性句子。它为探索变化检测与变化描述的多任务学习提供了关键数据基础。
    <br>
    <div align="center">
      <img src="https://raw.githubusercontent.com/Chen-Yang-Liu/Change-Agent/main/resource/dataset.png" width="800"/>
    </div>
    <br>
## 多层次变化解释模型训练
MCI 模型概览：
<br>
    <div align="center">
      <img src="https://raw.githubusercontent.com/Chen-Yang-Liu/Change-Agent/main/resource/MCI_model.png" width="800"/>
    </div>
<br>

### 准备工作
    
- **环境安装**：
    <details open>
    
    **步骤 1**：创建一个名为 `Multi_change_env` 的虚拟环境并激活它。
    ```python
    conda create -n Multi_change_env python=3.9
    conda activate Multi_change_env
    ```
    
    **步骤 2**：下载或克隆该仓库。
    ```python
    git clone https://github.com/Chen-Yang-Liu/Change-Agent.git
    cd ./Change-Agent/Multi_change
    ```
    
    **步骤3**：安装依赖项。
    ```python
    pip install -r requirements.txt
    ```
    </details>

- **下载数据集**：
  <details open>
      
  链接：[LEVIR-MCI](https://huggingface.co/datasets/lcybuaa/LEVIR-MCI/tree/main)。LEVIR-MCI 的数据结构组织如下：

    ```
    ├─/DATA_PATH_ROOT/Levir-MCI-dataset/
            ├─LevirCCcaptions.json
            ├─images
                 ├─train
                 │  ├─A
                 │  ├─B
                 │  ├─label
                 ├─val
                 │  ├─A
                 │  ├─B
                 │  ├─label
                 ├─test
                 │  ├─A
                 │  ├─B
                 │  ├─label
    ```
    其中文件夹``A``包含前期图像，文件夹``B``包含后期图像，文件夹``label``包含变化检测掩码。
    </details>

- **提取LEVIR-MCI中每对图像描述的文本文件**：

    ```
    python preprocess_data.py
    ```
    之后，您可以在 `./data/LEVIR_MCI/` 中找到一些生成的文件。

### 训练
确保您已完成上述数据准备。然后，按如下方式开始训练：
```python
python train.py --train_goal 2 --data_folder /DATA_PATH_ROOT/Levir-MCI-dataset/images --savepath ./models_ckpt/
```

### 评估
```python
python test.py --data_folder /DATA_PATH_ROOT/Levir-MCI-dataset/images --checkpoint {checkpoint_PATH}
```
我们建议训练模型5次以获得平均分数。

### 推理
运行推理以开始，方法如下：
```python
python predict.py --imgA_path {imgA_path} --imgB_path {imgA_path} --mask_save_path ./CDmask.png
```
你可以修改 ``predict.py`` 中 ``Change_Perception.define_args()`` 的 ``--checkpoint`` 参数。然后你可以使用你自己的模型，当然，你也可以下载我们的预训练模型 ``MCI_model.pth``，下载地址：[[Hugging face](https://huggingface.co/lcybuaa/Change-Agent/tree/main)]。下载后，将其放入 `./models_ckpt/` 文件夹中。



## Change-Agent 的构建
<br>
<div align="center">
      <img src="https://raw.githubusercontent.com/Chen-Yang-Liu/Change-Agent/main/resource/overview_agent.png" width="800"/>
</div>

- **Agent 安装**：
    ```python
    cd ./Change-Agent/lagent-main
    pip install -e .[all]
    ```
- **运行代理**：

    进入 ``Multi_change`` 文件夹：
    ```python
    cd ./Change-Agent/Multi_change
    ```
    （1）运行代理客户端演示：
    ```bash
    # You need to install streamlit first
    # pip install streamlit
    python try_chat.py
    ```
        
    （2）运行代理网页演示：
    ```bash
    # You need to install streamlit first
    # pip install streamlit
    streamlit run react_web_demo.py
    ```
    <br>
    <div align="center">
          <img src="https://raw.githubusercontent.com/Chen-Yang-Liu/Change-Agent/main/resource/web.png"/>
    </div>

## 引用
如果您在研究中发现本文有用，请考虑引用：
```
@ARTICLE{Liu_Change_Agent,
  author={Liu, Chenyang and Chen, Keyan and Zhang, Haotian and Qi, Zipeng and Zou, Zhengxia and Shi, Zhenwei},
  journal={IEEE Transactions on Geoscience and Remote Sensing}, 
  title={Change-Agent: Toward Interactive Comprehensive Remote Sensing Change Interpretation and Analysis}, 
  year={2024},
  volume={},
  number={},
  pages={1-1},
  keywords={Remote sensing;Feature extraction;Semantics;Transformers;Roads;Earth;Task analysis;Interactive Change-Agent;change captioning;change detection;multi-task learning;large language model},
  doi={10.1109/TGRS.2024.3425815}}

```

## 致谢
感谢以下仓库：

[RSICCformer](https://github.com/Chen-Yang-Liu/RSICC); [Chg2Cap](https://github.com/ShizhenChang/Chg2Cap); [lagent](https://github.com/InternLM/lagent)

## 许可协议
本仓库遵循[MIT 许可证](https://github.com/Chen-Yang-Liu/Change-Agent/blob/main/LICENSE.txt)分发。代码仅限于学术用途。

## 联系我们
如果您有任何其他问题❓，请及时联系我们 👬


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---
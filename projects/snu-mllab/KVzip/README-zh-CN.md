# KVzip：支持上下文重构的查询无关KV缓存压缩

[[论文](https://arxiv.org/abs/2505.23416)] [[博客](https://janghyun1230.github.io/kvzip/)] 

<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/method.png" width="800">

## 新特性
- KVzip 压缩KV缓存以支持**多样化的未来查询**。
- 【上下文相关】实现**KV缓存大小3–4倍压缩**和**解码延迟降低2倍**，性能损失极小。
- 【上下文无关】提升[DuoAttention](https://github.com/mit-han-lab/duo-attention)风格的头级KV压缩，仅需**一分钟内少量前向推理**进行头级重要性分数优化（快100倍）。
- 运行 demo.py：
<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/demo.png" width="800">


### 查询无关设定的基准测试
- 任务：[SQuAD](https://huggingface.co/datasets/rajpurkar/squad)、[NIAH](https://github.com/gkamradt/LLMTest_NeedleInAHaystack)、[SCBench](https://github.com/microsoft/MInference/tree/main/scbench)、[GSM8K](https://huggingface.co/datasets/openai/gsm8k/viewer/main/train?row=7294)。
- 模型：[Qwen2.5-7B-Instruct-1M](https://huggingface.co/Qwen/Qwen2.5-7B-Instruct)

<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/benchmark.png" width="800">


## 安装
我们使用 CUDA 12.1 和 Python 3.10
```bash
cd KVzip
pip install -r requirements.txt
pip install flash-attn==2.7.4.post1 --no-build-isolation
make i
```
- 若使用[QServe](https://github.com/mit-han-lab/omniserve)量化，请参照[`./model/quant_model`](https://github.com/snu-mllab/KVzip/tree/main/model/quant_model)。
### 数据集
- 请从[Google Drive](https://drive.google.com/file/d/1cqoR6pxxFcjFqvPZkuAmF-fBSAlAbjbN/view?usp=share_link)下载预处理好的 SCBench 数据集。
- 若已解压文件，直接移动 scbench 文件夹：
```bash
mv scbench.zip kvzip/data/
cd kvzip/data
unzip scbench.zip  
```

## 快速开始
```python
from model import ModelKVzip

model = ModelKVzip("Qwen/Qwen2.5-7B-Instruct-1M")
context = "这是我的基本个人信息。我叫Kim，住在首尔。我的专业是计算机科学。"
queries = ["我叫什么名字？", "我住在首尔吗？"]

kv = model.prefill(context, load_score=False)  # 预填充KV缓存 + 重要性评分
kv.prune(ratio=0.3)  # 压缩比例，剔除70%的KV

for q in queries:
    query_ids = model.apply_template(q)
    output = model.generate(query_ids, kv=kv, update_cache=False)  # 高效推理
    print(q, output)
```
- 支持的模型列于[`model/load.py`](https://github.com/snu-mllab/KVzip/blob/main/model/load.py)，包括**LLaMA3、Qwen2.5/3、Gemma3**。
- 设定 `load_score=True` 可消除压缩开销，启用上下文无关KV剔除，但压缩比例调整为 `ratio=0.6`。
- 生成后，会选择性剔除与查询及生成令牌对应的KV对以便后续处理。设定 `update_cache=True` 可支持多轮推理，保持完整交互历史。

## 性能及内存分析
### 上下文相关剔除
```bash
python -B test.py -m [model_name] -d [data_name] --kv_type evict --ratio 0.3
```
- 上述代码同时比较完整KV缓存与剪枝KV缓存生成的结果。
- 快速测试使用 `-d squad`，长上下文测试用 `-d scbench_kv`。
  - 可用数据集列表见[`data/load.py`](https://github.com/snu-mllab/KVzip/blob/main/data/load.py)。
  - 可用模型列表见[`model/load.py`](https://github.com/snu-mllab/KVzip/blob/main/model/load.py)，例如 llama3.1-8b, qwen2.5-7b（或 Qwen/Qwen2.5-7B-Instruct-1M）。
- 我们采用了[AdaKV](https://github.com/FFY0/AdaKV/tree/main)的CUDA内核，支持非均匀头预算分配。
  - 目前代码缺少针对使用静态KV缓存的Gemma3的优化内核，因此未体现实际效率提升。但仍可通过KV子采样(`--kv_type retain`)在减少注意力的情况下评估模型性能。


### 上下文无关剔除（无运行时压缩开销）
- 使用 `--level head` 标志并设置 `--ratio 0.6`（推荐）。
  - 剔除所有与特定头相关的上下文KV对，保留系统提示和查询KV对。
  - LLaMA3.1-8B 和 Qwen2.5-7/14B的预计算头分数位于 `./utils/head_score`。
- 若需计算其它模型的头分数：
  ```bash
  python -B test.py -m [model_name] -d scbench_qa_eng --save_head_score
  ```
  - 结果保存在 `./utils/head_score`。
  - 如果针对编码任务，建议额外执行 `-d scbench_repoqa`，这使模型能使用自然语言和编程语言的最大头分数，从而提升性能。
- 这些分数可无缝整合进[DuoAttention](https://github.com/mit-han-lab/duo-attention)的优化推理引擎，只需替换其头分数数据即可。


## 评估
- 生成不同KV压缩比（0.1至1.0）的模型响应：
    ```bash
    python -B eval.py -m [model_name] -d [data_name] --kv_type retain --num 100
    ``` 
  - 结果保存在 `./results/[data_name]`。
  - 支持的数据集见 `data/load.py`。
- 计算生成结果的评估指标：
  ```bash
  python -B -m results.parse -m [model_name] -d [data_name]
  ```

## 应用于新模型
集成KVzip到新模型时需更新以下文件：
- `attention/attn.py`  
  根据需要修改注意力的前向传播逻辑。部分情况下也需更新 `kvcache.py` 和 `score.py`。
- `model/monkeypatch.py`  
  实现模型特定的猴子补丁。
- `model/template.py`   
  定义模型的系统提示和对话格式模板。


## 引用
```bibtex
@article{kim2025kvzip,
        title={KVzip: Query-Agnostic KV Cache Compression with Context Reconstruction},
        author={Kim, Jang-Hyun and Kim, Jinuk and Kwon, Sangwoo and Lee, Jae W and Yun, Sangdoo and Song, Hyun Oh},
        journal={arXiv preprint arXiv:2505.23416},
        year={2025}
}
```

## 许可证
MIT 许可证

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---
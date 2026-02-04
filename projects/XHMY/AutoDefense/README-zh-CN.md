# AutoDefense：多智能体大语言模型防护越狱攻击

[**博客**](https://microsoft.github.io/autogen/0.2/blog/2024/03/11/AutoDefense/Defending%20LLMs%20Against%20Jailbreak%20Attacks%20with%20AutoDefense/)

## 安装

```bash
pip install vllm autogen pandas retry openai
```

## 使用 [vLLM](https://docs.vllm.ai/) 准备推理服务

vLLM 提供了一个兼容 OpenAI 的 API 服务器，具有效率高的推理能力和内置的多 GPU 负载均衡功能。

### 启动 vLLM 服务器

使用您所需的模型启动 vLLM 服务器。对于多 GPU 配置，使用 `--data-parallel-size` 启用自动负载均衡：

**单 GPU：**
```bash
vllm serve Qwen/Qwen3-1.7B --port 8000
```

**多GPU（例如，使用数据并行的2个GPU）：**
```bash
vllm serve Qwen/Qwen3-1.7B --port 8000 --data-parallel-size 2
```

**对于更大型模型的张量并行：**
```bash
vllm serve <your-large-model> --port 8000 --tensor-parallel-size 4
```

**组合张量并行和数据并行（8个GPU，2路张量并行 × 4路数据并行）：**
```bash
vllm serve <your-large-model> --port 8000 --tensor-parallel-size 2 --data-parallel-size 4
```

有关带有内部负载均衡的数据并行部署的更多详细信息，请参阅[vLLM 文档](https://docs.vllm.ai/en/latest/serving/data_parallel_deployment/)。

### 验证服务器

您可以通过检查模型端点来验证服务器是否正在运行：

```bash
curl http://localhost:8000/v1/models
```

## 响应生成

响应由 vLLM 提供服务的目标模型生成（默认：`Qwen/Qwen3-1.7B`）。请确保在执行以下命令前，vLLM 服务器已启动。

### 攻击提示（有害）

```bash
python attack/attack.py --model Qwen/Qwen3-1.7B --host 127.0.0.1 --port 8000
```

此命令将使用从 `data/prompt/attack_prompt_template.json` 加载的攻击提示模板（默认：`--template v1`）生成响应。  
要运行多次重复，请多次调用脚本并更改 `--output-suffix` 和/或 `--cache-seed`。  

### 安全提示（良性）  

要为安全/良性提示生成响应（用于误报评估）：  

```bash
python attack/attack.py \
    --model Qwen/Qwen3-1.7B \
    --template placeholder \
    --prompts data/prompt/safe_prompts.json \
    --output-prefix safe
```

`placeholder` 模板直接传递提示词，不包含任何攻击框架，而 `v1` 则用越狱指令包装提示词。

## 运行防御实验

以下命令运行 1-Agent、2-Agent 和 3-Agent 防御实验。`--chat-file` 应指向由 `attack/attack.py` 生成的有害输出（默认保存在 `data/harmful_output/<model_dir>/` 下，例如 `data/harmful_output/Qwen-Qwen3-1.7B/attack-dan_0.json`）。

```bash
export AUTOGEN_USE_DOCKER=0

python defense/run_defense_exp.py \
  --model Qwen/Qwen3-1.7B \
  --chat-file data/harmful_output/Qwen-Qwen3-1.7B/attack-dan_0.json
```

### 命令行参数

| 参数 | 说明 | 默认值 |
|----------|-------------|---------|
| `--model` | vLLM 服务的目标模型 | `Qwen/Qwen3-1.7B` |
| `--chat-file` | 含有有害输出的聊天文件路径 | 必填 |
| `--port` | vLLM 服务器运行的端口 | `8000` |
| `--host` | vLLM 服务器的主机名 | `127.0.0.1` |
| `--output-dir` | 输出目录 | `data/defense_output/<model_dir>` |
| `--output-suffix` | 输出目录的后缀 | `""` |
| `--strategies` | 运行的防御策略 | `ex-2 ex-3 ex-cot` |
| `--workers` | 并行工作线程数 | `128` |
| `--frequency_penalty` | 生成时的频率惩罚 | `0.0` |
| `--presence_penalty` | 生成时的存在惩罚 | `0.0` |
| `--temperature` | 生成时的温度 | `0.7` |

完成防御实验后，输出将出现在 `data/defense_output/<model_dir>/`（例如 `data/defense_output/Qwen-Qwen3-1.7B/`）。

## GPT 评估（论文使用 GPT-4）

评估有害输出防御：

```bash
python evaluator/gpt4_evaluator.py \
--defense_output_dir data/defense_output/Qwen-Qwen3-1.7B \
--ori_prompt_file_name prompt_dan.json
```
完成评估后，输出将出现在 `data/defense_output/Qwen-Qwen3-1.7B/asr.csv` 中。  
输出的 `json` 文件中，每个防御输出也会出现一个 `score` 值。  
`evaluator/gpt4_evaluator.py` 使用 GPT 模型作为评估器（原论文使用的是 GPT-4）。  
通过环境变量（或命令行参数）设置您的 OpenAI 凭据，您也可以通过 `--model` 将评估器替换为更新的 GPT 模型（例如，GPT-5）。  

```bash
export OPENAI_API_KEY=...
# optional (only if you use an OpenAI-compatible endpoint):
# export OPENAI_BASE_URL=...

python evaluator/gpt4_evaluator.py \
  --defense_output_dir data/defense_output/Qwen-Qwen3-1.7B \
  --ori_prompt_file_name prompt_dan.json \
  --model gpt-4-1106-preview
```
基于GPT的评估可能成本较高；我们启用缓存以避免重复评估。

对于安全响应评估，有一种无需使用GPT-4的高效方法。如果您知道数据集中所有提示都是常规用户提示且不应被拒绝，您可以使用以下命令评估防御输出的误报率（FPR）。


```bash
python evaluator/evaluate_safe.py
```

这将查找 `data/defense_output` 中所有包含关键词 `-safe` 的输出文件夹，并评估误报率（FPR）。
误报率将保存在 `data/defense_output/defense_fp.csv` 文件中。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-04

---
# BIRD-INTERACT 1.0 <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/hku-logo.jpg" alt="HKU Logo" width="50" style="vertical-align:middle;margin-left:10px;"> <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/google-cloud-logo.png" alt="Google Cloud Logo" width="50" style="vertical-align:middle;margin-left:10px;">

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/bird_interact.png" 
       style="width: 30%; min-width: 100px; display: block; margin: auto; border-radius: 15px !important;">
</p>


<div style="display: flex; justify-content: center; align-items: center; gap: 10px;">
  <a href="https://creativecommons.org/licenses/by-sa/4.0/deed.en">
    <img src="https://img.shields.io/badge/License-CC%20By%20SA%204.0-orange.svg" alt="License">
  </a>
  <a href="https://bird-interact.github.io/">
    <img src="https://img.shields.io/badge/Leaderboard-2025-28a745.svg" alt="Leaderboard">
  </a>
  <a href="https://huggingface.co/datasets/birdsql/bird-interact-lite/tree/main">
    <img src="https://img.shields.io/badge/Dataset-HuggingFace-FFD21E.svg" alt="HuggingFace">
  </a>
  <a href="https://www.python.org/downloads/release/python-310/">
    <img src="https://img.shields.io/badge/Python-3.10+-teal.svg" alt="Python">
  </a>
  <a href="https://pypi.org/project/openai/">
    <img src="https://img.shields.io/badge/OpenAI-1.40+-beige.svg" alt="OpenAI">
  </a>
</div>

## 🧸 概述

BIRD-INTERACT 是一个交互式文本到 SQL 基准，**通过动态交互的视角重新构想了 Text-to-SQL 的评测方式**。
该环境融合了分层知识库、数据库文档和函数驱动的用户模拟器，重现了真实企业环境下的完整 **CRUD** 操作。
它提供了两种严格的测试模式：（1）被动的**对话式交互**（Conversational Interaction）和（2）主动的**代理式交互**（Agentic Interaction），涵盖 600 个带注释的任务，包括商业智能（BI）、CRUD 操作等，每个任务均配备可执行的测试用例。
典型评测会在模型与用户模拟器之间触发 1,968-5,496 个交互回合，而当前最先进的推理模型仅能解决约 **24%** 和 **18%** 的任务，突出展现了该基准的挑战性。

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ 两种评测模式

BIRD-INTERACT 支持上述两种评测模式：

   - **c-Interact**：对话式交互，是一种被动模式，工作流程是固定的。相关代码与详细信息可见 `bird_interact_conv`。
   - **a-Interact**：代理式交互，是一种具身的主动模式，工作流程动态变化并由模型主导。相关代码与详细信息可见 `bird_interact_agent`。

### 🐣 精简版

我们发布了 BIRD-INTERACT 的精简版 `bird-interact-lite-exp`，包含专为 PostgreSQL 设计的 270 个高质量真实任务。这是快速实验的良好起点。

### 🦜 完整版

BIRD-INTERACT 的完整版 `bird-interact-full` 是一个全面的基准，包含 600 个 PostgreSQL 任务，涵盖了广泛的 SQL 操作和用户查询。完整版即将发布。

### BIRD-INTERACT Lite 上的模型性能结果

#### 1. **c-Interact** 性能
| 排名 | 模型名称          | 归一化得分 | 等级               |
|:------:|--------------------|:-------:|:--------------:|
| 1    | o3-mini            | 33.04 | 🏆 卓越对话         |
| 2    | GPT-4o             | 30.33 | 💎 优秀对话         |
| 3    | Gemini-2.0-flash   | 27.41 | 💎 优秀对话         |
| 4    | Claude-3.7-sonnet  | 26.60 | ✨ 标准             |
| 5    | DeepSeek-R1        | 21.74 | ✨ 标准             |
| 6    | Qwen3              | 20.33 | ⚪ 基础             |
| 7    | DeepSeek-V3        | 15.85 | ⚪ 基础             |

#### 2. **a-Interact** 性能
| 排名 | 模型名称          | 预算参数*  | 平均回合/任务 | 平均花费 (美元)/任务 | 归一化得分 | 等级                  |
|:------:|--------------------|:-------------------:|:----------------:|:---------------------:|:-------------------:|:---------------------:|
| 1    | Claude-3.7-sonnet  | 6/6 | 15.4 | $0.6668 | 29.19 | 🏆 卓越交互             |
| 2    | o3-mini            | 6/6 | 7.8  | $0.0754 | 21.07 | 💎 优秀交互             |
| 3    | DeepSeek-V3        | 6/6 | 15.6 | $0.0629 | 19.19 | 💎 优秀交互             |
| 4    | Qwen3              | 6/6 | 12.5 | $0.0278 | 18.74 | ✨ 标准                 |
| 5    | GPT-4o             | 6/6 | 15.3 | $0.4594 | 18.37 | ✨ 标准                 |
| 6    | Gemini-2.0-flash   | 6/6 | 13.2 | $0.0337 | 17.26 | ⚪ 基础                 |
| 7    | DeepSeek-R1        | 6/6 | 12.0 | $0.0931 | 17.07 | ⚪ 基础                 |

> \* 预算参数：初始预算/用户耐心预算，以我们的虚拟货币 *bird-coin* <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;"> 为单位。详情请参考 [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting)。

### 交互时长缩放（ITS）

交互时长缩放（Interaction-Time Scaling, ITS）指的是模型通过多轮交互不断提升最终性能的能力。当该交互性能超过模型在完全明确定义、无歧义任务上的理想单轮性能时，我们称其满足 **ITS 法则**。随着用户耐心提升和交互回合数增加，性能持续提升，表明模型能够在长对话中保持高效沟通。目前，我们仅发现 claude-3-7-sonnet 满足 ITS 法则。

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 数据集详情

### 数据集描述

- **数据库：** 完整的 PostgreSQL 数据库可从 [Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view) 下载。更多详情请见 [快速评测](#quick-eval) 部分。
- **数据：** 每个数据实例包含以下主要部分：
   - `selected_database`：数据库名称。  
   - `query`：无歧义的用户查询。  
   - `amb_user_query`：注入歧义的用户查询。
   - `user_query_ambiguity`：注入到用户查询中的歧义内容。
   - `non_critical_ambiguity`：如排序、限制等非关键性歧义。
- `knowledge_ambiguity`：由被屏蔽的外部知识引起的歧义。
- `sol_sql`：标准答案SQL解决方案。
- `preprocess_sql`：在执行解决方案或预测前运行的SQL查询。
- `clean_up_sql`：在测试用例后运行的SQL查询，用于还原对数据库所做的更改。
- `test_cases`：用于验证预测修正SQL的一组测试用例。
- `follow_up`：标注的后续问题。
- `external_knowledge`：与特定任务相关的外部知识。

- **评估：** 评估代码位于[`./evaluation`](./evaluation)目录下。
- **策划团队：** BIRD 团队 & Google Cloud
- **许可证：** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **HuggingFace 数据集卡片：** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### 数据集用途

为避免自动爬取造成的数据泄露，我们未随数据一同提供GT解决方案SQL及测试用例。
如需完整数据集，请发送邮件至[bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com)，邮件标题中包含标签`[bird-interact-lite GT&Test Cases]`，数据集将自动发送。


<!-- ### 从 HuggingFace 使用数据集

你可以使用以下命令从 HuggingFace 下载数据集：
```bash
from datasets import load_dataset
# 加载数据集的精简版
dataset = load_dataset("birdsql/bird-interact-lite")
print(dataset["lite"][0])

# 加载数据集的完整版（即将上线）
dataset = load_dataset("birdsql/bird-interact-full")
print(dataset["full"][0])
```

或者你可以使用提供的脚本下载数据集完整版，并按不同方言拆分数据集。
```bash
cd baseline/data
python pull_data.py \
  --schema_path path/to/full_schema.jsonl \
  --input_path path/to/input.jsonl \ # 输入JSONL文件路径（如需从HuggingFace下载数据集，可为空）
  --output_folder path/to/output_dir # 拆分文件的输出文件夹
``` -->

## 文件夹结构
```ultree
.
├── LICENSE
├── README.md
├── bird_interact_conv
│   ├── ...
│   └── README.md
├── bird_interact_agent
│   ├── ...
│   └── README.md
├── evaluation
│   ├── docker-compose.yml
│   ├── env
│   ├── postgre_table_dumps
│   ├── run
│   └── src
├── materials
│   ├── ...
└── requirements.txt
```
关于**a-interact**的运行细节可参考`./bird_interact_agent/README.md`；**c-interact**的运行细节可参考`./bird_interact_conv/README.md`。


## 📋 待办事项清单

- [x] 发布精简版，bird-interact-lite（270）。
- [x] 发布对话版，bird-interact-conv。
- [x] 发布代理版，bird-interact-agent。
- [ ] 发布完整版，bird-interact-full（600）。
- [ ] SFT / RL 用户模拟器

## 创建团队：
BIRD 团队 & Google Cloud

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---
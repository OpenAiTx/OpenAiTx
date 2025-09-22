
<div align="right">
  <details>
    <summary >🌐 语言</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>

</div>

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

## ⚠️ 公告  
请注意，在您的评估流程开始前，当 Docker 加载数据库时，由于环境不一致偶尔会出现错误（这些错误不会终止流程，但会显示在 Docker 日志中）。因此，部分数据库可能无法正常加载，导致数据库为空。这将使评测结果异常偏低。  
👉 因此，我们强烈建议您在**评测前检查 Docker 日志**是否有报错，并确认所有数据库均已成功加载。

## 📰 新闻

- [2025-08-26] 🚀 我们很高兴宣布**[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)**数据集正式发布！  
难度很高——目前最好的 LLM 仅获得了**16.33%**的成功率，`c-interact` 和 `a-interact`部分仅为**10.0%**。  
👉 更多详情请访问我们的[项目主页](https://bird-interact.github.io/)。

- [2025-08-26] 📬 我们将在本周向邮件列表发送**真实答案与测试用例**。  
如需提前获取，请按网站说明发邮件，开启**自动下载**通道。  

- [2025-08-26] 💾 另外，我们已发布了**[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)**的 SQLite 版本，更方便本地研究。  
完整版 **LiveSQLBench-Base** 和 **-Large** 即将上线！

- [2025-08-22] **Bug 修复**：Bird-Interact-Agent 代码中修复了一个 bug，在评测 phase-2 SQL 时，储存的 phase-1 SQL 无法成功执行，导致 Phase-2 成功率降低。该 bug 仅影响 phase1 sql 对数据库有操作的任务，如创建表等。

## 🧸 概览

BIRD-INTERACT 是一个交互式文本到 SQL 基准测试，通过**动态交互视角重新定义文本到 SQL 评测**。
该环境融合分层知识库、数据库文档和功能驱动用户模拟器，重现企业真实环境，覆盖完整的**CRUD**操作。
它提供了两种严格的测试模式：（1）被动的**对话交互**，以及（2）主动的**智能体交互**，涵盖了600个带有注释的任务，包括商业智能（BI）、CRUD操作等，每个任务都配有可执行的测试用例。
典型评估会触发模型与用户模拟器之间1,968-5,496次交互回合，而当前最先进的推理模型仅能解决**约24%**和**约18%**的任务，突显了该基准的挑战性。

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ 两种评估模式

如上所述，BIRD-INTERACT支持两种评估模式：

   - **c-Interact**：对话交互，是一种被动模式，工作流程是固定的。代码和详细信息可在 `bird_interact_conv` 中找到。
   - **a-Interact**：智能体交互，是一种具身的主动模式，工作流程是动态并由模型主导。代码和详细信息可在 `bird_interact_agent` 中找到。


### 🐣 精简版

我们发布了BIRD-INTERACT的精简版 `bird-interact-lite-exp`，其中包含了专为PostgreSQL设计的270个高质量真实任务。非常适合快速实验的入门使用。

### 🦜 完整版

BIRD-INTERACT的完整版 `bird-interact-full` 是一个全面的基准测试，涵盖了PostgreSQL的600个任务。包含广泛的SQL操作和用户查询。完整版即将推出。

### BIRD-INTERACT 精简版模型性能结果

#### 1. **c-Interact** 性能
| 排名 | 模型名称           | 标准化奖励 | 等级          |
|:------:|--------------------|:-------:|:--------------:|
| 1    | o3-mini            | 33.04 | 🏆 卓越对话      |
| 2    | GPT-4o             | 30.33 | 💎 良好对话      |
| 3    | Gemini-2.0-flash   | 27.41 | 💎 良好对话      |
| 4    | Claude-3.7-sonnet  | 26.60 | ✨ 标准          |
| 5    | DeepSeek-R1        | 21.74 | ✨ 标准          |
| 6    | Qwen3              | 20.33 | ⚪ 基础          |
| 7    | DeepSeek-V3        | 15.85 | ⚪ 基础          |

#### 2. **a-Interact** 性能
| 排名 | 模型名称           |预算参数*      | 平均步数/任务 | 平均花费（美元）/任务 | 标准化奖励   | 等级             |
|:------:|--------------------|:-------------------:|:----------------:|:---------------------:|:-------------------:|:---------------------:|
| 1    | Claude-3.7-sonnet  | 6/6 | 15.4 | $0.6668 | 29.19 | 🏆 卓越交互体验 |
| 2    | o3-mini            | 6/6 | 7.8 | $0.0754 | 21.07 | 💎 良好交互体验 |
| 3    | DeepSeek-V3        | 6/6 | 15.6 | $0.0629 | 19.19 | 💎 良好交互体验 |
| 4    | Qwen3              | 6/6 | 12.5 | $0.0278 | 18.74 | ✨ 标准           |
| 5    | GPT-4o             | 6/6 | 15.3 | $0.4594 | 18.37 | ✨ 标准           |
| 6    | Gemini-2.0-flash   | 6/6 | 13.2 | $0.0337 | 17.26 | ⚪ 基础           |
| 7    | DeepSeek-R1        | 6/6 | 12.0 | $0.0931 | 17.07 | ⚪ 基础           |

> \* 预算参数：初始预算/用户耐心预算，均以我们的虚拟货币 *bird-coin* <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;"> 计量。详细信息请参考 [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting)。

### 交互时间扩展（ITS）

交互时间扩展（ITS）指的是模型通过多轮交互不断提升最终表现的能力。当这种交互式表现超过模型在完全指定且无歧义任务上的理想单轮表现时，我们认为模型满足 **ITS 定律**。随着用户耐心提升与交互轮次增加，模型表现持续提升，展现出在长对话中保持高效沟通的能力。目前，仅有 claude-3-7-sonnet 满足 ITS 定律。

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 数据集详情

### 数据集说明

- **数据库：** 完整的 PostgreSQL 数据库可从 [Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view) 下载。更多信息见 [快速评测](#quick-eval) 部分。
- **数据：** 每条数据实例包含以下主要部分：
   - `selected_database`: 数据库名称。  
   - `query`: 明确无歧义的用户查询。  
   - `amb_user_query`: 注入歧义后的用户查询。
   - `user_query_ambiguity`: 注入到用户查询中的歧义。
   - `non_critical_ambiguity`: 非关键歧义，如排序、限制等。
   - `knowledge_ambiguity`: 由屏蔽外部知识造成的歧义。 
   - `sol_sql`: 标准 SQL 解决方案。  
   - `preprocess_sql`: 在执行解决方案或预测前需运行的 SQL 查询。  
   - `clean_up_sql`: 在测试用例后恢复数据库更改的 SQL 查询。  
   - `test_cases`: 用于验证预测修正 SQL 的测试用例集合。
   - `follow_up`: 标注的后续问题。
   - `external_knowledge`: 与具体任务相关的外部知识。

- **评测：** 评测代码可在 [`./evaluation`](./evaluation) 目录下获取。
- **整理团队：** BIRD 团队 & Google Cloud
- **许可证:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **HuggingFace 数据集卡片:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### 数据集用途

为避免通过自动爬取造成数据泄漏，我们未在数据中包含GT解决方案SQL和测试用例。
如需完整数据集，请发送邮件至[bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com)，邮件标题请注明 `[bird-interact-lite GT&Test Cases]`，我们将自动发送完整数据集。


<!-- ### 从 HuggingFace 获取数据集

你可以使用以下命令从 HuggingFace 下载数据集：
```bash
from datasets import load_dataset
# Load the flash version of the dataset
dataset = load_dataset("birdsql/bird-interact-lite")
print(dataset["lite"][0])

# Load the full version of the dataset (coming soon)
dataset = load_dataset("birdsql/bird-interact-full")
print(dataset["full"][0])
```
或者，您可以使用提供的脚本下载完整版本的数据集，并将其拆分为不同的方言。

```bash
cd baseline/data
python pull_data.py \
  --schema_path path/to/full_schema.jsonl \
  --input_path path/to/input.jsonl \ # 输入 JSONL 文件的路径（如果你希望从 HuggingFace 下载数据集，则可以为空）
  --output_folder path/to/output_dir # 拆分文件的输出文件夹
```

## 文件结构
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
有关运行 **a-interact** 的详细信息可在 `./bird_interact_agent/README.md` 中找到；而有关 **c-interact** 的信息可在 `./bird_interact_conv/README.md` 中找到。

## 📋 待办事项清单

- [x] 发布简化版，bird-interact-lite（270）。
- [x] 发布对话版，bird-interact-conv。
- [x] 发布代理版，bird-interact-agent。
- [x] 发布完整版，bird-interact-full（600）。
- [ ] SFT / RL 用户模拟器

## 创建者：
BIRD 团队 & Google Cloud







---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-22

---
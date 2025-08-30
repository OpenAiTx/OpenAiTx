
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

## 📰 新闻

- [2025-08-26] 🚀 我们很高兴宣布 **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)** 集已发布！  
这个集合非常有挑战性 —— 最好的大模型仅取得了 **16.33%** 的成功率，`c-interact` 和 `a-interact` 部分仅为 **10.0%**。  
👉 更多详情请访问我们的 [项目网站](https://bird-interact.github.io/)。

- [2025-08-26] 📬 本周我们将向邮件列表发送 **真实标签 & 测试用例**。  
如需抢先获取，请按网站说明发送邮件以实现 **自动下载**。  

- [2025-08-26] 💾 另外，我们还发布了适用于本地研究的 SQLite 版本 **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)**。  
完整版 **LiveSQLBench-Base** 和 **-Large** 即将上线！

- [2025-08-22] **Bug 修复**：Bird-Interact-Agent 代码中修复了一个 bug，即在评估 phase-2 SQL 时，存储的 phase-1 SQL 无法成功执行，导致 Phase-2 成功率下降。该 bug 仅影响 phase1 sql 对数据库进行某些操作的任务，例如 CREATE table 等。

## 🧸 概览

BIRD-INTERACT 是一个交互式 text-to-SQL 基准集，**通过动态交互视角重新定义 Text-to-SQL 评测**。
该环境融合了分层知识库、数据库文档和以函数驱动的用户模拟器，重现了企业环境下全流程 **CRUD** 操作。
它提供两种严苛测试模式：(1) 被动的 **对话式交互** 和 (2) 主动的 **智能体交互**，涵盖 600 个标注任务，包括商业智能（BI）、CRUD 操作等，每个任务都有可执行测试用例。
典型评测将触发模型与用户模拟器间 1,968-5,496 次交互轮次，而当前最先进的推理模型仅能解决 **≈24%** 和 **≈18%** 的任务，凸显了该基准集的挑战性。

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ 两种评测模式

如上所述，BIRD-INTERACT 支持两种评测模式：

   - **c-Interact**：对话式交互，为被动模式，流程固定。相关代码和详细信息请参见 `bird_interact_conv`。
   - **a-Interact**：智能体交互，为主动模式，流程由模型动态引导。相关代码和详细信息请参见 `bird_interact_agent`。


### 🐣 精简版

我们发布了 BIRD-INTERACT 的精简版 `bird-interact-lite-exp`，包含 270 个专为 PostgreSQL 设计的高质量真实任务。适合快速实验的起步阶段。

### 🦜 完整版

BIRD-INTERACT 的完整版 `bird-interact-full` 是一个包含 600 个 PostgreSQL 任务的全面基准，涵盖了广泛的 SQL 操作和用户查询。完整版即将上线。

### BIRD-INTERACT 精简版模型性能结果

#### 1. **c-Interact** 性能
| 排名 | 模型名称         | 标准化奖励 | 等级        |
|:------:|--------------------|:-------:|:--------------:|
| 1    | o3-mini            | 33.04 | 🏆 优秀对话 |
| 2    | GPT-4o             | 30.33 | 💎 良好对话      |
| 3    | Gemini-2.0-flash   | 27.41 | 💎 良好对话      |
| 4    | Claude-3.7-sonnet  | 26.60 | ✨ 标准       |
| 5    | DeepSeek-R1        | 21.74 | ✨ 标准       |
| 6    | Qwen3              | 20.33 | ⚪ 基础          |
| 7    | DeepSeek-V3        | 15.85 | ⚪ 基础          |

#### 2. **a-Interact** 性能
| 排名 | 模型名称         | 预算参数* | 平均步数/任务 | 平均花费（美元）/任务 | 标准化奖励 | 等级            |
|:------:|--------------------|:-------------------:|:----------------:|:---------------------:|:-------------------:|:---------------------:|
| 1    | Claude-3.7-sonnet  | 6/6 | 15.4 | $0.6668 | 29.19 | 🏆 优秀交互 |
| 2    | o3-mini            | 6/6 | 7.8 | $0.0754 | 21.07 | 💎 良好交互      |
| 3    | DeepSeek-V3        | 6/6 | 15.6 | $0.0629 | 19.19 | 💎 良好交互      |
| 4    | Qwen3              | 6/6 | 12.5 | $0.0278 | 18.74 | ✨ 标准              |
| 5    | GPT-4o             | 6/6 | 15.3 | $0.4594 | 18.37 | ✨ 标准                  |
| 6    | Gemini-2.0-flash   | 6/6 | 13.2 | $0.0337 | 17.26 | ⚪ 基础                  |
| 7    | DeepSeek-R1        | 6/6 | 12.0 | $0.0931 | 17.07 | ⚪ 基础                  |

> \* 预算参数：起始预算/用户耐心预算，采用我们的虚拟货币 *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">。详情参见 [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting)。

### 交互时间扩展（ITS）

交互时间扩展（ITS）指的是模型通过多轮交互持续提升最终表现的能力。当这种交互表现超过模型在完全明确、无歧义任务上的理想化单轮表现时，我们称其满足 **ITS 法则**。随着用户耐心增长和交互轮次的积累，性能不断提升，表明模型能够在长时间对话中保持有效沟通。目前我们仅发现 claude-3-7-sonnet 满足 ITS 法则。

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 数据集详情

### 数据集描述

- **数据库：** 完整的 PostgreSQL 数据库可从 [Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view) 下载。更多细节请查看 [快速评估](#quick-eval) 部分。
- **数据：** 每个数据实例包含以下主要部分：
   - `selected_database`: 数据库名称。  
   - `query`: 明确无歧义的用户查询。  
   - `amb_user_query`: 注入歧义后的用户查询。
   - `user_query_ambiguity`: 注入到用户查询中的歧义。
   - `non_critical_ambiguity`: 非关键性歧义，如顺序、限制等。
   - `knowledge_ambiguity`: 由屏蔽外部知识产生的歧义。 
   - `sol_sql`: 标准答案 SQL。  
   - `preprocess_sql`: 在执行答案或预测前需运行的 SQL 查询。  
   - `clean_up_sql`: 测试用例后需运行的 SQL 查询，以恢复数据库更改。  
   - `test_cases`: 验证预测 SQL 是否正确的一组测试用例。
   - `follow_up`: 标注的后续问题。
   - `external_knowledge`: 与具体任务相关的外部知识。

- **评估：** 评估代码位于 [`./evaluation`](./evaluation) 目录。
- **策划团队：** BIRD 团队 & Google Cloud
- **许可证：** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **HuggingFace 数据集卡片：** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### 数据集用途

为了避免因自动爬取导致的数据泄露，我们没有将GT解决方案SQL和测试用例与数据一起提供。
请发送邮件至 [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com)，邮件标题请包含标签 `[bird-interact-lite GT&Test Cases]`，完整数据集将自动发送给您。


<!-- ### 使用HuggingFace的数据集

您可以使用以下命令从HuggingFace下载数据集：
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
有关运行 **a-interact** 的详细信息请参见 `./bird_interact_agent/README.md`；而 **c-interact** 的信息请参见 `./bird_interact_conv/README.md`。

## 📋 待办事项列表

- [x] 发布精简版，bird-interact-lite（270）。
- [x] 发布会话版，bird-interact-conv。
- [x] 发布代理版，bird-interact-agent。
- [x] 发布完整版，bird-interact-full（600）。
- [ ] SFT / RL 用户模拟器

## 创建者：
BIRD团队 & Google Cloud





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-30

---
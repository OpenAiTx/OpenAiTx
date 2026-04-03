
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
请注意，在您的评测流程开始前，Docker 加载数据库时可能偶尔会因环境不一致而报错（这些错误不会导致进程终止，但会出现在 Docker 日志中）。因此，部分数据库可能加载失败，导致数据库为空。这将导致评测结果异常偏低。  
👉 因此，我们强烈建议在**运行评测前先检查 Docker 日志**中是否有错误，并确保所有数据库均已成功加载。

👉 我们已更新了**提交指南**，现支持自定义 Agent 脚手架。欢迎查看我们详细的提交指南 [这里](https://docs.google.com/document/d/1F1DSqHDBzGvXFlWU8iCl9otkqxIefgcH/edit?usp=sharing&ouid=108161566779099489782&rtpof=true&sd=true)。

## 📰 新闻

- [2026-03-29] 🔥🔥🔥 **BIRD-Interact-ADK**：我们发布了基于 Google ADK 的**[BIRD-Interact-ADK](./BIRD-Interact-ADK/)**，采用模块化三微服务（Agent、用户模拟器和数据库环境）架构。可轻松替换您的自定义 Agent、用户模拟器或数据库环境，支持并行执行及任意 [LiteLlm 兼容](https://docs.litellm.ai/docs/providers) 的大模型服务商。强烈建议在科研中使用本实现。

- [2026-02-08] 🔥🔥🔥 我们的**[Bird-Interact 论文](https://huggingface.co/papers/2510.05318)**已被**ICLR 2026（Oral）**接收！里约见 🇧🇷！  

- [2025-11-06] 🐛 **Bug修复** & 🐳 **Docker更新**：将 sqlglot 版本更新至 26.16.4，修复 SQL 解析器无法正确解析用户模拟器 SQL 的 bug。您可在 `bird_interact_eval` 环境下通过 `pip install sqlglot==26.16.4` 重新安装修复。`bird_interact_eval` 镜像也已更新，亦可直接拉取并重建 `bird_interact_eval` 容器。

- [2025-10-21] 🐳 **Docker更新**：我们新增了完整数据库环境的 Docker，并已将 3 个镜像（基础/完整数据库环境及 a-Interact、c-Interact 的评测环境）推送至 Docker Hub，方便环境搭建。无需手动下载数据库转储或自行构建镜像！

- [2025-10-08] 📝 我们的**[Bird-Interact 论文](https://huggingface.co/papers/2510.05318)**现已公开！  
  论文详细介绍了我们的交互式文本到 SQL 基准测试的全部细节、方法和评估。  
  👉 欢迎查阅，了解 [BIRD-Interact](https://bird-interact.github.io/) 背后的思路。

- [2025-08-26] 🚀 我们很高兴宣布**[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)** 集合正式发布！  
这是一个极具挑战性的集合——目前最佳大模型仅达到**16.33%** 成功率，`c-interact` 和 `a-interact` 部分仅有**10.0%**。
👉 更多详情请访问我们的 [项目网站](https://bird-interact.github.io/)。

- [2025-08-26] 📬 本周我们将向邮件订阅者发送**Ground Truth & Test cases（基准答案与测试用例）**。  
如果您想提前获取，请按照网站上的说明发送邮件以**自动下载**。

- [2025-08-26] 💾 另外，我们已经发布了**[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)**的 SQLite 版本，便于本地研究。  
完整版的 **LiveSQLBench-Base** 和 **-Large** 即将推出！

- [2025-08-22] **Bug 修复**：在 Bird-Interact-Agent 代码中，我们修复了一个 bug：在评估 phase-2 SQL 时，存储的 phase-1 SQL 无法成功执行，导致 Phase-2 成功率降低。该问题仅影响 phase1 sql 对数据库执行操作的任务，比如 CREATE table 等。

## 🧸 概述

BIRD-INTERACT 是一个交互式文本到 SQL 基准测试，**以动态交互为视角重新定义 Text-to-SQL 评测方式**。
该环境融合了分层知识库、数据库文档和基于函数的用户模拟器，重现了真实企业环境下的全方位 **CRUD** 操作。
它提供了两种严格的测试模式：（1）被动的**对话交互**和（2）主动的**智能体交互**，覆盖了 600 个带注释的任务，包括商业智能（BI）、CRUD 操作等，每个任务都由可执行的测试用例守护。
典型的评测会触发模型与用户模拟器之间 1,968-5,496 轮交互，而最先进的推理模型当前仅能解决约 **24%** 和 **18%** 的任务，凸显了该基准的挑战性。

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ 两种评测模式

BIRD-INTERACT 支持上述两种评测模式：

   - **c-Interact**：对话交互，是被动模式，流程固定。相关代码与详细信息见 `bird_interact_conv`。
   - **a-Interact**：智能体交互，是具身主动模式，流程动态且由模型主导。相关代码与详细信息见 `bird_interact_agent`。

### 🐣 精简版

我们发布了 BIRD-INTERACT 的精简版 `bird-interact-lite-exp`，包含 270 个高质量、真实世界任务，专为 PostgreSQL 设计。非常适合快速实验。

### 🦜 完整版

BIRD-INTERACT 的完整版 `bird-interact-full` 是一个包含 600 个 PostgreSQL 任务的综合基准，涵盖多种 SQL 操作和用户查询。完整版即将发布。

### BIRD-INTERACT-FULL 的模型性能结果


#### 1. **c-Interact 文本转 SQL** 性能
| 排名 | 模型名称           | 标准化奖励        | 平均成本（美元）/任务 | 水平               |
|:----:|:-------------------|:-----------------:|:-------------------:|:------------------:|
| 1    | Gemini-2.5-Pro     | 20.92             | $0.04               | 🏆 卓越对话        |
| 2    | O3-Mini            | 20.27             | $0.07               | 🏆 卓越对话        |
| 3    | Claude-Sonnet-4    | 18.35             | $0.29               | 💎 良好对话        |
| 4    | Qwen-3-Coder-480B  | 17.75             | $0.11               | 💎 良好对话        |
| 5    | Deepseek-Chat-V3.1 | 15.15             | $0.12               | ✨ 标准            |
| 6    | Claude-Sonnet-3.7  | 13.87             | $0.29               | ✨ 标准            |
| 7    | GPT-5              | 12.58             | $0.08               | ⚪ 基础            |

#### 2. **a-Interact 文本转 SQL** 性能
| 排名 | 模型名称           | 标准化奖励        | 平均成本（美元）/任务 | 水平                    |
|:----:|:-------------------|:-----------------:|:-------------------:|:------------------------:|
| 1    | GPT-5              | 25.52             | $0.24               | 🏆 卓越交互              |
| 2    | Claude-Sonnet-4    | 23.28             | $0.51               | 🏆 卓越交互              |
| 3    | Claude-Sonnet-3.7  | 17.45             | $0.60               | 💎 良好交互              |
| 4    | Gemini-2.5-Pro     | 17.33             | $0.22               | 💎 良好交互              |
| 5    | O3-Mini            | 16.43             | $0.06               | ✨ 标准                  |
| 6    | Deepseek-Chat-V3.1 | 13.47             | $0.06               | ✨ 标准                  |
| 7    | Qwen-3-Coder-480B  | 10.58             | $0.07               | ⚪ 基础                  |

> \* 预算参数：起始预算/用户耐心预算，由我们的虚拟货币 *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;"> 测量。更多细节请参阅 [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting)。

### 互动时间缩放（ITS）

互动时间缩放（ITS）指的是模型通过多轮交互持续提升最终性能的能力。当这种交互性能超过模型在完全指定、无歧义任务上的理想化单轮表现时，我们认为它满足 **ITS 法则**。随着用户耐心提升和交互轮数累计，性能持续提升，展示出模型能在长时间对话中保持有效沟通。目前，我们仅发现 claude-3-7-sonnet 满足 ITS 法则。

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 环境搭建

1. 为 bird-interact-lite 数据库、bird-interact-full 数据库以及评测环境运行 Docker 容器：
  
  > 如果你只想在 `bird-interact-lite` 上评测，可以注释掉 `docker-compose.yml` 中 [`postgresql_full` 服务](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/./env/docker-compose.yml#L21-L31) 来加快环境搭建速度。
  
  通过运行以下命令启动环境：
   ```bash
   cd env
   docker compose pull 
   docker compose up -d
   ```
   等待几分钟以完成数据库初始化。
   
  您可以通过以下方式跟踪构建进度：
  ```bash
  docker compose logs -f --tail=100 bird_interact_postgresql_full # or bird_interact_postgresql for bird-interact-lite
  ```
  如果完成，您应该会看到没有错误的日志，如下所示：

  ```bash
  bird_interact_postgresql_full  | 2025-10-28 17:58:30.413 HKT [1] LOG:  database system is ready to accept connection
  ```
  
 
  ```bash
  docker compose down -v # this cmd removes the containers and the volumes
  docker compose pull   # pull the latest images from Docker Hub
  docker compose up -d --force-recreate # build and start the containers again. --force-recreate means force the recreation of the containers. 
  # Or `docker compose up -d --force-recreate bird_interact_eval` to only recreate the bird_interact_eval container about evalution code environment.
  ```
   
   这将使用来自 Docker Hub 的预构建镜像运行 3 个容器：
   - `bird_interact_postgresql`：bird-interact-lite 的 PostgreSQL 数据库
   - `bird_interact_postgresql_full`：bird-interact-full 的 PostgreSQL 数据库
   - `bird_interact_eval`：`a-Interact` 和 `c-Interact` 的评估环境。

   现在，您可以通过执行以下命令启动评估环境：
   ```bash
   docker compose exec bird_interact_eval bash
   ```
2. （可选）手动构建环境（如果你希望从零开始构建镜像）：
   - 下载数据库转储文件
      - [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view)。解压后重命名为 `env/postgre_table_dumps`。
      - [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view)。解压后重命名为 `env/postgre_table_dumps_full`。
   - 通过运行 `docker-compose.build.yml` 手动构建环境。

      ```bash
      cd env/
      docker compose -f docker-compose.build.yml build
      docker compose -f docker-compose.build.yml up -d
      ```

3. （推荐）检查数据库容器是否已成功构建并正在运行。

- 打印容器构建日志，以确保数据库已成功构建且没有错误：
   ```bash 
   docker logs bird_interact_postgresql > build_bird_interact_postgresql.log 2>&1
   docker logs bird_interact_postgresql_full > build_bird_interact_postgresql_full.log 2>&1
   ```
   如果发生错误，日志文件中将打印 `"导入过程中发生错误："`。


-  检查数据库容器是否正常。

   使用我们提供的 Python 脚本来验证数据库元数据：
   ```bash
   docker compose exec bird_interact_eval bash
   cd /app/env
   python check_db_metadata.py --host bird_interact_postgresql
   python check_db_metadata.py --host bird_interact_postgresql_full
   ```
   
   预期结果：
   - **bird-interact-lite**： 
     - 📈 总数据库数：18
     - 📋 总数据表数：175
     - 🔢 总字段数：2286
     - 📈 每张表平均行数：1,038.48
     - 💾 总大小：207.15 MB（约）
   - **bird-interact-full**： 
     - 📈 总数据库数：22
     - 📋 总数据表数：244
     - 🔢 总字段数：2011
     - 📈 每张表平均行数：1,121.19
     - 💾 总大小：272.00 MB（约）


## 📦 数据集详情

### 数据集描述

- **Database：** 完整的 PostgreSQL 数据库可从 [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view) 和 [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view) 下载。
- **data：** 每条数据实例包含以下主要部分：
   - `selected_database`：数据库名称。  
   - `query`：无歧义的用户查询。  
   - `amb_user_query`：带有注入歧义的用户查询。
   - `user_query_ambiguity`：注入到用户查询中的歧义。
   - `non_critical_ambiguity`：如排序、限制等非关键歧义。
   - `knowledge_ambiguity`：由屏蔽外部知识产生的歧义。 
   - `sol_sql`：标准答案 SQL 解决方案。  
   - `preprocess_sql`：在执行解决方案或预测前运行的 SQL 查询。  
   - `clean_up_sql`：测试用例后运行以还原数据库变更的 SQL 查询。  
   - `test_cases`：用于验证预测修正 SQL 的一组测试用例。
   - `follow_up`：标注的后续问题。
   - `external_knowledge`：与具体任务相关的外部知识。

- **evaluation：** 评测代码位于 [`./evaluation`](./evaluation) 目录。
- **策划团队：** BIRD Team & Google Cloud
- **许可证：** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **HuggingFace 数据集卡片：** PostgreSQL 版本见 [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)
  和 [bird-interact-full](https://huggingface.co/datasets/birdsql/bird-interact-full)；SQLite 版本见 [mini-interact](https://huggingface.co/datasets/birdsql/mini-interact)。
### 数据集用途

为避免通过自动爬取导致的数据泄漏，我们没有将GT解决方案SQL和测试用例与数据一同包含。
请发送电子邮件至 [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com)，邮件标题需包含标签 `[bird-interact-lite GT&Test Cases]` 或 `[bird-interact-full GT&Test Cases]`，以获取 bird-interact-lite 或 bird-interact-full 数据集的真实标签和测试用例，系统会自动发送相关内容。


### 将公开数据与真实标签和测试用例合并

然后使用以下脚本将公开数据与真实标签和测试用例合并：

以完整版为例：
(1) 运行：
```bash
python combine_public_with_gt.py /path/to/bird-interact-full/bird_interact_data.jsonl /path/to/bird_interact_full_gt_kg_testcases_08022.jsonl /path/to/bird_interact_data.jsonl  # bird_interact_full_gt_kg_testcases_08022.jsonl is the data of ground-truth fields, which is obtained by emailing us.
```
这将在 `/path/to/bird_interact_data.jsonl` 创建一个包含合并数据的新文件。

（2）然后用合并后的数据替换原始公共数据：

```bash
cp /path/to/bird_interact_data.jsonl /path/to/bird-interact-full/bird_interact_data.jsonl
```
其他版本也是如此：bird-interact-lite、mini 版本等。只需为公共数据、真实值和测试用例设置正确的路径，然后将公共数据替换为合并数据。




<!-- ### 使用 HuggingFace 的数据集

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
├── BIRD-Interact-ADK
│   ├── ...
│   └── README.md
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
关于运行 **a-interact** 的详细信息可以在 `./bird_interact_agent/README.md` 中找到；**c-interact** 的信息可以在 `./bird_interact_conv/README.md` 中找到；**基于 ADK 的实现** 可以在 `./BIRD-Interact-ADK/README.md` 中找到。

## 📋 待办事项列表

- [x] 发布轻量版，bird-interact-lite（270）。
- [x] 发布对话版，bird-interact-conv。
- [x] 发布代理版，bird-interact-agent。
- [x] 发布完整版，bird-interact-full（600）。
- [x] 发布基于 ADK 的实现，BIRD-Interact-ADK。
- [ ] SFT / RL 用户模拟器

## 致谢
我们衷心感谢 **Irina Saparina**、**Mohammadreza Pourreza**、**Mehdi Bouzouina**、**Hailong Li**、**Jiatong Shi** 和 **Shinji Watanabe** 教授的富有成效的讨论和宝贵见解，这些都极大地促进了本项目的改进。

## 制作团队：
BIRD 团队 & Google Cloud







## 引用

```bibtex
@inproceedings{
huo2026birdinteract,
title={{BIRD}-{INTERACT}: Re-imagining Text-to-{SQL} Evaluation via Lens of Dynamic Interactions},
author={Nan Huo and Xiaohan Xu and Jinyang Li and Per Jacobsson and Shipei Lin and Bowen Qin and Binyuan Hui and Xiaolong Li and Ge Qu and Shuzheng Si and Linheng Han and Edward Alexander and Xintong Zhu and Rui Qin and Ruihan Yu and Yiyao Jin and Feige Zhou and Weihao Zhong and Yun Chen and Hongyu Liu and Chenhao Ma and Fatma Ozcan and Yannis Papakonstantinou and Reynold Cheng},
booktitle={The Fourteenth International Conference on Learning Representations},
year={2026},
url={https://openreview.net/forum?id=nHrYBGujps}
}
```


## 更新日志

- [2025-11-06] 🐛 **漏洞修复** & 🐳 **Docker 更新**：将 sqlglot 版本升级至 26.16.4，以修复 SQL 解析器无法为用户模拟器正确解析 SQL 的漏洞。你可以通过在 `bird_interact_eval` 环境中重新安装 `pip install sqlglot==26.16.4` 来解决该问题。`bird_interact_eval` 镜像也已更新，因此你也可以拉取并重新创建 `bird_interact_eval` 容器。
- [2025-10-21] 🐳 **Docker 更新**：新增 Full DB Env 的 Docker。我们已将 3 个 Docker 镜像（Base/Full DB Env 及 `a-Interact` 和 `c-Interact` 的评估环境）推送到 Docker Hub，方便环境部署。无需下载数据库转储并手动构建镜像！请从 Docker Hub 拉取最新镜像并重建容器，例如使用 `docker compose down -v && docker compose pull && docker compose up -d --force-recreate`。
- [2025-08-22]  🐛 **漏洞修复**：修复在评估 phase-2 SQL 时，存储的 phase-1 SQL 无法成功执行导致 Phase-2 成功率降低的漏洞。该漏洞仅影响 phase1 sql 对数据库有操作的任务，如 CREATE table 等。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-03

---
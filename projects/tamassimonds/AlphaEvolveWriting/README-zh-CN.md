<div align="right">
  <details>
    <summary >🌐 语言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# AlphaEvolve 写作

![AlphaEvolve 写作流程](https://raw.githubusercontent.com/tamassimonds/AlphaEvolveWriting/main/assets/AlphaWriteProcess.png)

你可以在[这里](https://tobysimonds.com/research/2025/06/06/LLM-Self-Rewarding-copy.html)找到完整解释

你可以在[这里](https://blog.reedsy.com/short-story/wo9iuy/#comments)找到提交到写作比赛的示例故事

一套现代的进化写作系统，通过 AI 模型生成、评估并进化创意故事或一般写作作品，采用迭代竞赛的方式。采用干净、模块化的 Python 架构，遵循现代设计原则。




## ✨ 功能特色

- 🧬 **进化算法**：故事通过 AI 驱动的锦标赛不断进化
- 🎯 **双写作模式**：兼具创意故事与一般写作优化
- 🏆 **ELO 锦标赛系统**：通过两两比较实现复杂排名
- 🌐 **网页界面**：支持人工验证与故事对比工具
- 🔧 **可配置**：通过 JSON 配置实现高度自定义

## 🚀 快速开始

### 安装


```bash
# Clone the repository
git clone https://github.com/your-org/alphaevolve-writing
cd alphaevolve-writing

# Install with uv (recommended)
uv sync

# Or install with pip
pip install -e .

# Configure your API keys (see Configuration section below)
```
### 运行进化


```bash
# Run 5 evolution iterations
python evolve.py 5

# Fresh start with 3 iterations
python evolve.py 3 --fresh

# Use general writing mode
python evolve.py 5 --general

# Show help
python evolve.py --help
```
## 🏗️ 架构

该系统遵循现代Python设计原则，明确职责分离：


```
├── src/
│   ├── core/           # Pipeline orchestration
│   │   └── pipeline.py # Main EvolutionPipeline class
│   ├── generators/     # Story generation logic
│   │   ├── story_generator.py      # Initial & next batch generators
│   │   ├── generate_response.py    # Creative writing generation
│   │   ├── generate_response_general.py # General writing generation
│   │   └── judge_response.py       # AI judging system
│   ├── rankers/        # ELO ranking system
│   │   ├── elo_rank.py            # Core ELO algorithm
│   │   └── tournament_runner.py    # Tournament management
│   └── utils/          # Utility functions
│       └── inference.py           # Multi-provider LLM interface
├── evolve.py           # Clean CLI entry point
├── pyproject.toml      # Modern Python packaging
├── config.json         # Configuration
└── web_interface/      # Web UI for validation
```
### 关键组件

- **`EvolutionPipeline`**：管理完整进化周期的主协调器  
- **`InitialStoryGenerator`**：根据提示生成第一代故事  
- **`NextBatchGenerator`**：将表现最佳的故事进化成改进版本  
- **`TournamentRunner`**：管理故事排名的 ELO 锦标赛  
- **`EloRankingSystem`**：实现复杂的排名算法  

## 📖 工作原理

系统遵循三阶段进化周期：

### 1. **生成初始批次**  
- 根据您的提示生成多个故事  
- 使用可配置的 AI 模型（GPT、Claude、Llama 等）  
- 分配初始 ELO 评分  

### 2. **运行 ELO 锦标赛**  
- 故事进行成对比较  
- AI 裁判根据您的评分标准评估  
- 根据胜负更新 ELO 评分  

### 3. **生成下一批次**  
- 选出表现最佳的故事  
- 生成改进版本的变体  
- 该过程重复多代  

这一迭代过程随着时间推移不断进化出更优质的作品。

## ⚙️ 配置

### 基本设置

编辑以下关键文件：

- **`prompt.txt`** - 您的写作提示/主题  
- **`rubric.txt`** - 评判标准  
- **`config.json`** - 系统配置  

### API 密钥设置

系统支持通过 `config.json` 配置的多家 AI 提供商。配置映射模型到提供商，并指定包含 API 密钥的环境变量：


```json
{
  "llm_providers": {
    "openai": {
      "type": "openai",
      "base_url": "https://api.openai.com/v1",
      "api_key_env": "OPENAI_API_KEY"
    },
    "anthropic": {
      "type": "anthropic", 
      "api_key_env": "ANTHROPIC_API_KEY"
    },
    "deepinfra": {
      "type": "openai_compatible",
      "base_url": "https://api.deepinfra.com/v1/openai",
      "api_key_env": "DEEPINFRA_API_KEY"
    },
    "deepseek": {
      "type": "openai_compatible",
      "base_url": "https://api.deepseek.com/v1",
      "api_key_env": "DEEPSEEK_API_KEY"
    },
    "gemini": {
      "type": "openai_compatible",
      "api_key_env": "GEMINI_API_KEY",
      "base_url": "https://generativelanguage.googleapis.com/v1beta/openai/"
    }
  },
  "model_provider_mapping": {
    "gpt-4": "openai",
    "gpt-3.5-turbo": "openai", 
    "claude-3-sonnet-20240229": "anthropic",
    "meta-llama/Meta-Llama-3-70B-Instruct": "deepinfra",
    "deepseek-chat": "deepseek",
    "gemini-2.5-flash": "gemini"
  }
}
```
然后将您的 API 密钥设置为环境变量：


```bash
export OPENAI_API_KEY="your-openai-key"        # For GPT models
export ANTHROPIC_API_KEY="your-anthropic-key"  # For Claude models  
export DEEPINFRA_API_KEY="your-deepinfra-key"  # For Llama models
export DEEPSEEK_API_KEY="your-deepseek-key"    # For DeepSeek models
export GEMINI_API_KEY="your-gemini-key"          # For Gemini models
```
你只需为计划使用的提供商设置密钥。系统会根据配置自动将模型请求路由到正确的提供商。

### 配置选项

`config.json` 文件控制所有系统行为：


```json
{
  "batch_generation": {
    "num_stories": 10,
    "model": "gpt-4",
    "initial_elo": 1500
  },
  "elo_ranking": {
    "tournament_rounds": 50,
    "judge_model": "claude-3-sonnet-20240229",
    "k_factor": 32
  },
  "next_batch_generation": {
    "top_stories_to_select": 3,
    "variants_per_story": 2,
    "include_original_stories": true
  },
  "evolution_pipeline": {
    "max_iterations": 5,
    "auto_continue_from_existing": true
  }
}
```
## 🎭 写作模式

### 创意写作模式（默认）
- 侧重于故事讲述、人物发展和叙事技巧
- 使用基于任务的生成策略
- 优化创造力和吸引力

### 通用写作模式（`--general`）
- 侧重于学术论文、散文、报告和专业写作
- 使用分析和结构化方法
- 优化清晰度和说服力

## 🔧 高级配置

### 自定义生成策略

对于高级用户，可以通过编辑 `src/generators/` 目录中的文件来自定义生成提示、作者风格和任务集：

#### 创意写作自定义（`src/generators/generate_response.py`）

**任务集** - 定义创意方法和目标：

```python
mission_sets = {
    "emotional_depth": [
        "Focus on the psychological depth of characters",
        "Explore complex emotional landscapes", 
        "Create moments of genuine human connection"
    ],
    "narrative_craft": [
        "Experiment with unique narrative structures",
        "Use vivid, sensory descriptions",
        "Create compelling story arcs"
    ],
    "dialogue_mastery": [
        "Write authentic, character-specific dialogue",
        "Use subtext and implied meaning",
        "Balance dialogue with action and description"
    ]
}
```
**作者风格** - 模仿不同的写作方法：

```python
author_styles = [
    "Write with the psychological insight of Virginia Woolf",
    "Adopt the sparse, powerful prose of Ernest Hemingway", 
    "Use the magical realism style of Gabriel García Márquez",
    "Employ the detailed world-building of Tolkien"
]
```
#### 通用写作定制（`src/generators/generate_response_general.py`）

**学术重点领域** - 针对特定写作领域：

```python
academic_focuses = [
    "Rigorous analytical argument development",
    "Clear thesis statement and supporting evidence",
    "Proper academic citation and source integration",
    "Logical flow and coherent structure"
]
```
**编写方法** - 定义分析策略：

```python
writing_approaches = [
    "Comparative analysis with multiple perspectives",
    "Problem-solution framework with evidence",
    "Cause-and-effect reasoning with examples",
    "Critical evaluation with balanced arguments"
]
```
### 自定义评判标准（`src/generators/judge_response.py`）

您可以修改评判标准和评价提示，以关注写作质量的特定方面：


```python
# Edit the judge_responses function to customize evaluation criteria
evaluation_criteria = [
    "Technical writing proficiency",
    "Creative originality and innovation", 
    "Emotional impact and reader engagement",
    "Structural coherence and flow",
    "Character development and authenticity"
]
```
### 高级配置技巧

1. **备份原始文件**：在修改生成器文件之前，务必保留原始文件的副本  
2. **逐步测试**：进行小幅度修改，并先用少量迭代测试，再运行完整进化周期  
3. **监控结果**：使用网页界面验证自定义设置是否提升了故事质量  
4. **混合搭配**：结合不同的任务集和作者风格，创造独特的生成策略  
5. **版本控制**：使用 git 跟踪自定义设置，必要时可恢复  

这种模块化方法允许你针对特定写作目标和领域微调进化过程。

## 🌐 网页界面

使用内置网页界面验证你的进化结果：


```bash
cd web_interface
pip install -r requirements.txt
python app.py
```
打开 http://localhost:5000 访问：

- **故事比较**：并排阅读与偏好选择
- **ELO 排名**：查看当前排名和统计数据
- **进化跟踪**：验证后代是否有所提升
- **数据导出**：下载结果进行分析


```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---
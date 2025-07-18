<div align="right">
  <details>
    <summary >🌐 語言</summary>
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

# AlphaEvolve Writing

![AlphaEvolve 寫作流程](https://raw.githubusercontent.com/tamassimonds/AlphaEvolveWriting/main/assets/AlphaWriteProcess.png)

你可以在[這裡](https://tobysimonds.com/research/2025/06/06/LLM-Self-Rewarding-copy.html)找到完整說明

你可以在[這裡](https://blog.reedsy.com/short-story/wo9iuy/#comments)查看一個參加寫作比賽的樣本故事

一個現代化、進化式的寫作系統，利用 AI 模型通過多輪競賽來生成、評估並進化創意故事或一般寫作作品。採用乾淨、模組化的 Python 架構，遵循現代設計原則。




## ✨ 功能特色

- 🧬 **進化演算法**：故事通過 AI 驅動的錦標賽進化
- 🎯 **雙重寫作模式**：創意故事敘述與一般寫作優化
- 🏆 **ELO 錦標賽系統**：通過成對比較進行精密排名
- 🌐 **網頁介面**：提供人工驗證與故事比較工具
- 🔧 **可配置性**：透過 JSON 配置進行廣泛自訂

## 🚀 快速開始

### 安裝


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
### 執行進化


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
## 🏗️ 架構

該系統遵循現代 Python 設計原則，並明確區分各個關注點：


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
### 主要組件

- **`EvolutionPipeline`**：主要的協調者，管理完整的演化循環
- **`InitialStoryGenerator`**：從提示生成第一代故事
- **`NextBatchGenerator`**：將最佳作品演化為改進變體
- **`TournamentRunner`**：管理故事排名的ELO錦標賽
- **`EloRankingSystem`**：實現先進的排名演算法

## 📖 運作方式

系統遵循三階段的演化循環：

### 1. **生成初始批次**
- 從您的提示產生多個故事
- 使用可配置的AI模型（GPT、Claude、Llama等）
- 分配初始ELO分數

### 2. **運行ELO錦標賽**
- 故事進行成對比較競賽
- AI評審根據您的評分標準進行評價
- 根據勝負更新ELO分數

### 3. **生成下一批次**
- 選出表現最佳的故事
- 生成改進過的變體
- 流程重複多代

這個反覆過程會隨著時間進化出越來越優秀的寫作成果。

## ⚙️ 設定

### 基本設定

編輯以下主要檔案：

- **`prompt.txt`** - 您的寫作提示/主題
- **`rubric.txt`** - 評分標準
- **`config.json`** - 系統設定

### API金鑰設定

系統支援多家AI服務提供者，可透過`config.json`設定。設定檔會對應模型與提供者，並指定環境變數中存放API金鑰的名稱：


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
然後將您的 API 金鑰設為環境變數：


```bash
export OPENAI_API_KEY="your-openai-key"        # For GPT models
export ANTHROPIC_API_KEY="your-anthropic-key"  # For Claude models  
export DEEPINFRA_API_KEY="your-deepinfra-key"  # For Llama models
export DEEPSEEK_API_KEY="your-deepseek-key"    # For DeepSeek models
export GEMINI_API_KEY="your-gemini-key"          # For Gemini models
```
您只需要為您計劃使用的服務提供者設置金鑰。系統會根據配置自動將模型請求路由到正確的服務提供者。

### 配置選項

`config.json` 檔案控制所有系統行為：


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
## 🎭 撰寫模式

### 創意寫作模式（預設）
- 著重於故事敘述、角色發展與敘事技巧
- 採用任務導向的生成策略
- 針對創造力與吸引力進行最佳化

### 一般寫作模式（`--general`）
- 著重於學術論文、散文、報告及專業寫作
- 採用分析性與結構化的方法
- 針對清晰度與說服力進行最佳化

## 🔧 進階設定

### 自訂生成策略

對進階使用者而言，可透過編輯 `src/generators/` 目錄下的檔案，自訂生成提示、作者風格及任務集：

#### 創意寫作自訂（`src/generators/generate_response.py`）

**任務集** - 定義創意取向與目標：

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
**作者風格** - 模仿不同的寫作方式：

```python
author_styles = [
    "Write with the psychological insight of Virginia Woolf",
    "Adopt the sparse, powerful prose of Ernest Hemingway", 
    "Use the magical realism style of Gabriel García Márquez",
    "Employ the detailed world-building of Tolkien"
]
```
#### 一般寫作自訂（`src/generators/generate_response_general.py`）

**學術重點領域** - 鎖定特定寫作領域：

```python
academic_focuses = [
    "Rigorous analytical argument development",
    "Clear thesis statement and supporting evidence",
    "Proper academic citation and source integration",
    "Logical flow and coherent structure"
]
```
**寫作方法** - 定義分析策略：

```python
writing_approaches = [
    "Comparative analysis with multiple perspectives",
    "Problem-solution framework with evidence",
    "Cause-and-effect reasoning with examples",
    "Critical evaluation with balanced arguments"
]
```
### 自訂評分標準（`src/generators/judge_response.py`）

您可以修改評分標準和評估提示，以聚焦於寫作品質的特定面向：


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
### 進階設定提示

1. **備份原始檔案**：在進行更改前，務必保留原始產生器檔案的副本
2. **逐步測試**：每次只做小幅修改，並在進行完整進化循環前，先用少量迭代測試
3. **監控結果**：利用網頁介面驗證你的自訂是否提升了故事品質
4. **混搭策略**：結合不同的任務集與作者風格，創造獨特的生成策略
5. **版本控制**：使用 git 追蹤你的自訂變更，方便必要時還原

這種模組化的方法讓你能針對特定寫作目標與領域，細緻調整進化流程。

## 🌐 網頁介面

利用內建網頁介面驗證你的進化結果：


```bash
cd web_interface
pip install -r requirements.txt
python app.py
```
打開 http://localhost:5000 以存取：

- **故事比較**：並排閱讀並選擇偏好
- **ELO 排名**：檢視當前排名與統計數據
- **演化追蹤**：驗證後代是否有所提升
- **數據匯出**：下載結果以供分析


```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---
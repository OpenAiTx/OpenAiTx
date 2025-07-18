<div align="right">
  <details>
    <summary >🌐 言語</summary>
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

![AlphaEvolve Writing Process](https://raw.githubusercontent.com/tamassimonds/AlphaEvolveWriting/main/assets/AlphaWriteProcess.png)

詳細な解説は[こちら](https://tobysimonds.com/research/2025/06/06/LLM-Self-Rewarding-copy.html)をご覧ください。

執筆コンペに提出されたサンプルストーリーは[こちら](https://blog.reedsy.com/short-story/wo9iuy/#comments)でご覧いただけます。

AIモデルを用いて創造的なストーリーや一般的な文章を生成・評価・進化させる、現代的な進化的執筆システム。クリーンでモジュラーなPythonアーキテクチャに基づき、最新の設計原則を採用しています。




## ✨ 特徴

- 🧬 **進化的アルゴリズム**: AI主導のトーナメントで物語が進化
- 🎯 **2つの執筆モード**: クリエイティブなストーリーテリングと一般文書の最適化
- 🏆 **ELOトーナメントシステム**: ペアごとの比較による高度なランキング
- 🌐 **ウェブインターフェース**: 人間による検証とストーリー比較ツール
- 🔧 **設定可能**: JSON設定による広範なカスタマイズ

## 🚀 クイックスタート

### インストール


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
### 進化を実行


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
## 🏗️ アーキテクチャ

システムは、関心事の明確な分離を伴う最新のPython設計原則に従っています:


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
### 主要コンポーネント

- **`EvolutionPipeline`**：進化サイクル全体を管理するメインオーケストレーター  
- **`InitialStoryGenerator`**：プロンプトから最初の世代の物語を生成  
- **`NextBatchGenerator`**：上位の物語を改良したバリアントに進化させる  
- **`TournamentRunner`**：物語のランキングのためにELOトーナメントを管理  
- **`EloRankingSystem`**：高度なランキングアルゴリズムを実装  

## 📖 仕組み

システムは3段階の進化サイクルに従います：

### 1. **初期バッチの生成**  
- プロンプトから複数の物語を生成  
- 設定可能なAIモデルを使用（GPT、Claude、Llamaなど）  
- 初期ELO評価を割り当て  

### 2. **ELOトーナメントの実行**  
- 物語同士がペアで競い合う  
- AIジャッジがルーブリックに基づいて評価  
- 勝敗に基づいてELO評価を更新  

### 3. **次バッチの生成**  
- 成績上位の物語を選出  
- 改良を加えたバリアントを生成  
- このプロセスを複数世代にわたり繰り返す  

この反復プロセスにより、時間と共により良い文章が進化します。  

## ⚙️ 設定

### 基本セットアップ

以下の主要ファイルを編集してください：  

- **`prompt.txt`** - 文章のプロンプト／テーマ  
- **`rubric.txt`** - 評価のための審査基準  
- **`config.json`** - システム設定  

### APIキーの設定

システムは複数のAIプロバイダーを`config.json`で設定可能です。設定ではモデルをプロバイダーにマッピングし、APIキーを含む環境変数を指定します：


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
APIキーを環境変数として設定します：


```bash
export OPENAI_API_KEY="your-openai-key"        # For GPT models
export ANTHROPIC_API_KEY="your-anthropic-key"  # For Claude models  
export DEEPINFRA_API_KEY="your-deepinfra-key"  # For Llama models
export DEEPSEEK_API_KEY="your-deepseek-key"    # For DeepSeek models
export GEMINI_API_KEY="your-gemini-key"          # For Gemini models
```
<translate-content>
使用する予定のプロバイダーのキーのみを設定すれば十分です。システムは設定に基づいてモデルリクエストを正しいプロバイダーに自動的にルーティングします。

### 設定オプション

`config.json` ファイルはすべてのシステム動作を制御します：
</translate-content>
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
## 🎭 ライティングモード

### クリエイティブライティングモード（デフォルト）
- ストーリーテリング、キャラクター開発、ナラティブ技法に焦点を当てる
- ミッションベースの生成戦略を使用する
- 創造性とエンゲージメントを最適化する

### 一般ライティングモード（`--general`）
- 学術論文、エッセイ、レポート、専門的な文章に焦点を当てる
- 分析的かつ構造化されたアプローチを使用する
- 明確さと説得力を最適化する

## 🔧 高度な設定

### 生成戦略のカスタマイズ

上級ユーザー向けに、`src/generators/` ディレクトリ内のファイルを編集して、生成プロンプト、作者スタイル、ミッションセットをカスタマイズできます：

#### クリエイティブライティングのカスタマイズ（`src/generators/generate_response.py`）

**ミッションセット** - 創造的なアプローチと目標を定義：

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
**著者スタイル** - さまざまな執筆アプローチを模倣する：

```python
author_styles = [
    "Write with the psychological insight of Virginia Woolf",
    "Adopt the sparse, powerful prose of Ernest Hemingway", 
    "Use the magical realism style of Gabriel García Márquez",
    "Employ the detailed world-building of Tolkien"
]
```
#### 一般的な執筆カスタマイズ (`src/generators/generate_response_general.py`)

**学術的焦点分野** - 特定の執筆領域を対象とする:

```python
academic_focuses = [
    "Rigorous analytical argument development",
    "Clear thesis statement and supporting evidence",
    "Proper academic citation and source integration",
    "Logical flow and coherent structure"
]
```
**執筆アプローチ** - 分析戦略を定義する:

```python
writing_approaches = [
    "Comparative analysis with multiple perspectives",
    "Problem-solution framework with evidence",
    "Cause-and-effect reasoning with examples",
    "Critical evaluation with balanced arguments"
]
```
### 判定基準のカスタマイズ (`src/generators/judge_response.py`)

判定基準や評価プロンプトを変更して、文章の特定の品質要素に焦点を当てることができます：


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
### 高度な設定のヒント

1. **元のファイルをバックアップ**：変更を加える前に必ず元のジェネレーターファイルのコピーを保存してください  
2. **段階的にテスト**：少しずつ変更を加え、全進化サイクルを実行する前に数回のイテレーションでテストしましょう  
3. **結果を監視**：カスタマイズがストーリーの質を向上させているか、ウェブインターフェースで確認してください  
4. **組み合わせる**：異なるミッションセットや作者スタイルを組み合わせて独自の生成戦略を作成しましょう  
5. **バージョン管理**：gitでカスタマイズを管理し、必要に応じて元に戻せるようにしましょう  

このモジュラー方式により、特定の執筆目標や分野に合わせて進化プロセスを細かく調整できます。  

## 🌐 ウェブインターフェース  

内蔵のウェブインターフェースで進化の結果を検証しましょう：


```bash
cd web_interface
pip install -r requirements.txt
python app.py
```
<translate-content>
http://localhost:5000 を開いてアクセスしてください：

- **ストーリー比較**：並べて読み、好みを選択
- **ELOランキング**：現在の順位と統計を表示
- **進化追跡**：後の世代が改善されていることを検証
- **データエクスポート**：解析用に結果をダウンロード
</translate-content>
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---
<div align="right">
  <details>
    <summary >🌐 언어</summary>
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

전체 설명은 [여기](https://tobysimonds.com/research/2025/06/06/LLM-Self-Rewarding-copy.html)에서 확인할 수 있습니다.

글쓰기 대회에 제출된 샘플 스토리는 [여기](https://blog.reedsy.com/short-story/wo9iuy/#comments)에서 볼 수 있습니다.

AI 모델을 사용하여 창의적인 스토리나 일반 글을 생성, 평가, 진화시키는 현대적 진화적 글쓰기 시스템입니다. 최신 설계 원칙을 따르는 깔끔하고 모듈화된 파이썬 아키텍처로 제작되었습니다.




## ✨ 주요 기능

- 🧬 **진화 알고리즘**: AI 기반 토너먼트로 스토리가 진화합니다
- 🎯 **이중 작성 모드**: 창의적 스토리텔링 및 일반 글쓰기 최적화
- 🏆 **ELO 토너먼트 시스템**: 쌍대 비교를 통한 정교한 순위 산정
- 🌐 **웹 인터페이스**: 인간 검증 및 스토리 비교 도구 제공
- 🔧 **설정 가능**: JSON 구성으로 폭넓은 맞춤화 가능

## 🚀 빠른 시작

### 설치


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
### 실행 진화


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
## 🏗️ 아키텍처

시스템은 관심사의 명확한 분리를 통해 현대적인 파이썬 설계 원칙을 따릅니다:


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
### 주요 구성 요소

- **`EvolutionPipeline`**: 전체 진화 사이클을 관리하는 메인 오케스트레이터  
- **`InitialStoryGenerator`**: 프롬프트로부터 첫 세대 이야기를 생성  
- **`NextBatchGenerator`**: 상위 성과자를 개선된 변종으로 진화  
- **`TournamentRunner`**: 이야기 순위를 위한 ELO 토너먼트 관리  
- **`EloRankingSystem`**: 정교한 순위 알고리즘 구현  

## 📖 작동 방식

시스템은 세 단계 진화 사이클을 따릅니다:

### 1. **초기 배치 생성**  
- 프롬프트로부터 여러 이야기 생성  
- 구성 가능한 AI 모델 사용 (GPT, Claude, Llama 등)  
- 초기 ELO 등급 할당  

### 2. **ELO 토너먼트 실행**  
- 이야기들이 쌍별 비교로 경쟁  
- AI 심판이 평가 기준에 따라 평가  
- 승/패에 따라 ELO 등급 갱신  

### 3. **다음 배치 생성**  
- 상위 성과자 이야기 선택  
- 개선된 변종 생성  
- 여러 세대에 걸쳐 과정 반복  

이 반복 과정을 통해 시간이 지남에 따라 점점 더 나은 글쓰기가 진화합니다.

## ⚙️ 구성

### 기본 설정

다음 주요 파일을 편집하세요:

- **`prompt.txt`** - 작성할 프롬프트/테마  
- **`rubric.txt`** - 평가 기준  
- **`config.json`** - 시스템 구성  

### API 키 설정

시스템은 `config.json`을 통해 구성된 여러 AI 제공자를 지원합니다. 구성은 모델과 제공자를 매핑하고 API 키가 포함된 환경 변수명을 지정합니다:


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
그런 다음 API 키를 환경 변수로 설정하세요:


```bash
export OPENAI_API_KEY="your-openai-key"        # For GPT models
export ANTHROPIC_API_KEY="your-anthropic-key"  # For Claude models  
export DEEPINFRA_API_KEY="your-deepinfra-key"  # For Llama models
export DEEPSEEK_API_KEY="your-deepseek-key"    # For DeepSeek models
export GEMINI_API_KEY="your-gemini-key"          # For Gemini models
```


사용할 계획인 제공자에 대해서만 키를 설정하면 됩니다. 시스템은 구성을 기반으로 모델 요청을 올바른 제공자로 자동 라우팅합니다.

### 구성 옵션

`config.json` 파일은 모든 시스템 동작을 제어합니다:


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
## 🎭 글쓰기 모드

### 창의적 글쓰기 모드 (기본)
- 스토리텔링, 캐릭터 개발, 내러티브 기법에 중점
- 미션 기반 생성 전략 사용
- 창의성과 몰입도 최적화

### 일반 글쓰기 모드 (`--general`)
- 학술 논문, 에세이, 보고서, 전문 글쓰기에 중점
- 분석적이고 구조화된 접근법 사용
- 명확성과 설득력 최적화

## 🔧 고급 설정

### 생성 전략 맞춤화

고급 사용자는 `src/generators/` 디렉토리 내 파일을 편집하여 생성 프롬프트, 저자 스타일, 미션 세트를 맞춤 설정할 수 있습니다:

#### 창의적 글쓰기 맞춤화 (`src/generators/generate_response.py`)

**미션 세트** - 창의적 접근법과 목표 정의:

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
**저자 스타일** - 다양한 작성 방식을 모방합니다:

```python
author_styles = [
    "Write with the psychological insight of Virginia Woolf",
    "Adopt the sparse, powerful prose of Ernest Hemingway", 
    "Use the magical realism style of Gabriel García Márquez",
    "Employ the detailed world-building of Tolkien"
]
```
#### 일반 글쓰기 맞춤화 (`src/generators/generate_response_general.py`)

**학문 분야 집중** - 특정 글쓰기 영역을 목표로 함:

```python
academic_focuses = [
    "Rigorous analytical argument development",
    "Clear thesis statement and supporting evidence",
    "Proper academic citation and source integration",
    "Logical flow and coherent structure"
]
```
**작성 접근법** - 분석 전략 정의:

```python
writing_approaches = [
    "Comparative analysis with multiple perspectives",
    "Problem-solution framework with evidence",
    "Cause-and-effect reasoning with examples",
    "Critical evaluation with balanced arguments"
]
```
### 평가 기준 맞춤 설정 (`src/generators/judge_response.py`)

평가기준 및 평가 프롬프트를 수정하여 글 품질의 특정 측면에 집중할 수 있습니다:


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
### 고급 설정 팁

1. **원본 파일 백업**: 변경하기 전에 항상 원본 생성기 파일을 복사해 두세요  
2. **점진적 테스트**: 소규모 변경 후 몇 번의 반복 테스트를 거쳐 전체 진화 주기를 실행하세요  
3. **결과 모니터링**: 웹 인터페이스를 사용해 맞춤화가 스토리 품질을 향상시키는지 확인하세요  
4. **혼합 및 매치**: 다양한 미션 세트와 작가 스타일을 결합해 독특한 생성 전략을 만드세요  
5. **버전 관리**: git으로 맞춤 설정을 추적하여 필요 시 되돌릴 수 있도록 하세요  

이 모듈식 접근 방식은 특정 글쓰기 목표와 분야에 맞게 진화 과정을 세밀하게 조정할 수 있습니다.  

## 🌐 웹 인터페이스  

내장된 웹 인터페이스로 진화 결과를 검증하세요:


```bash
cd web_interface
pip install -r requirements.txt
python app.py
```


http://localhost:5000 을 열어 접속하세요:

- **스토리 비교**: 나란히 읽기 및 선호도 선택
- **ELO 순위**: 현재 순위 및 통계 보기
- **진화 추적**: 이후 세대가 개선되었는지 검증
- **데이터 내보내기**: 분석을 위한 결과 다운로드


```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---
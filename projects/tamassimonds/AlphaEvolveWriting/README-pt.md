<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
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

![Processo de Escrita AlphaEvolve](https://raw.githubusercontent.com/tamassimonds/AlphaEvolveWriting/main/assets/AlphaWriteProcess.png)

Você pode encontrar a explicação completa [aqui](https://tobysimonds.com/research/2025/06/06/LLM-Self-Rewarding-copy.html)

Você pode encontrar uma história de exemplo submetida a uma competição de escrita [aqui](https://blog.reedsy.com/short-story/wo9iuy/#comments)

Um sistema moderno e evolutivo de escrita que utiliza modelos de IA para gerar, avaliar e evoluir histórias criativas ou textos gerais por meio de competições iterativas. Construído com arquitetura Python limpa e modular, seguindo princípios de design modernos.




## ✨ Recursos

- 🧬 **Algoritmo Evolutivo**: Histórias evoluem através de torneios alimentados por IA
- 🎯 **Modos Duplos de Escrita**: Otimização para narrativa criativa e textos gerais
- 🏆 **Sistema de Torneio ELO**: Classificação sofisticada por comparações em pares
- 🌐 **Interface Web**: Ferramentas para validação humana e comparação de histórias
- 🔧 **Configurável**: Ampla personalização via configuração JSON

## 🚀 Início Rápido

### Instalação


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
### Executar Evolução


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
## 🏗️ Arquitetura

O sistema segue princípios modernos de design Python com separação clara de responsabilidades:


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
### Componentes Principais

- **`EvolutionPipeline`**: Orquestrador principal que gerencia todo o ciclo de evolução
- **`InitialStoryGenerator`**: Cria a primeira geração de histórias a partir dos prompts
- **`NextBatchGenerator`**: Evolui os melhores desempenhos em variantes aprimoradas
- **`TournamentRunner`**: Gerencia torneios ELO para ranqueamento das histórias
- **`EloRankingSystem`**: Implementa algoritmo sofisticado de ranqueamento

## 📖 Como Funciona

O sistema segue um ciclo de evolução em três estágios:

### 1. **Gerar Lote Inicial**
- Cria múltiplas histórias a partir do seu prompt
- Usa modelos de IA configuráveis (GPT, Claude, Llama, etc.)
- Atribui classificações ELO iniciais

### 2. **Executar Torneio ELO**
- Histórias competem em comparações em pares
- IAs juízas avaliam com base no seu critério
- Classificações ELO atualizadas conforme vitórias/derrotas

### 3. **Gerar Próximo Lote**
- Histórias com melhor desempenho são selecionadas
- Variantes geradas com melhorias
- Processo se repete por várias gerações

Esse processo iterativo evolui a escrita para níveis cada vez melhores ao longo do tempo.

## ⚙️ Configuração

### Configuração Básica

Edite estes arquivos principais:

- **`prompt.txt`** - Seu prompt/tema de escrita
- **`rubric.txt`** - Critérios de avaliação para julgamento
- **`config.json`** - Configuração do sistema

### Configuração de Chaves de API

O sistema suporta múltiplos provedores de IA configurados pelo `config.json`. A configuração mapeia modelos para provedores e especifica quais variáveis de ambiente contêm as chaves de API:


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
Em seguida, defina suas chaves de API como variáveis de ambiente:


```bash
export OPENAI_API_KEY="your-openai-key"        # For GPT models
export ANTHROPIC_API_KEY="your-anthropic-key"  # For Claude models  
export DEEPINFRA_API_KEY="your-deepinfra-key"  # For Llama models
export DEEPSEEK_API_KEY="your-deepseek-key"    # For DeepSeek models
export GEMINI_API_KEY="your-gemini-key"          # For Gemini models
```
Você só precisa definir as chaves para os provedores que planeja usar. O sistema roteia automaticamente as solicitações de modelo para o provedor correto com base na configuração.

### Opções de Configuração

O arquivo `config.json` controla todo o comportamento do sistema:


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
## 🎭 Modos de Escrita

### Modo de Escrita Criativa (Padrão)
- Foca em narrativa, desenvolvimento de personagens e técnicas narrativas
- Utiliza estratégias de geração baseadas em missões
- Otimiza para criatividade e engajamento

### Modo de Escrita Geral (`--general`)
- Foca em artigos acadêmicos, ensaios, relatórios e escrita profissional
- Utiliza abordagens analíticas e estruturadas
- Otimiza para clareza e persuasão

## 🔧 Configuração Avançada

### Personalizando Estratégias de Geração

Para usuários avançados, é possível personalizar os prompts de geração, estilos de autor e conjuntos de missões editando os arquivos no diretório `src/generators/`:

#### Personalização de Escrita Criativa (`src/generators/generate_response.py`)

**Conjuntos de Missão** - Defina abordagens e objetivos criativos:

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
**Estilos de Autor** - Emule diferentes abordagens de escrita:

```python
author_styles = [
    "Write with the psychological insight of Virginia Woolf",
    "Adopt the sparse, powerful prose of Ernest Hemingway", 
    "Use the magical realism style of Gabriel García Márquez",
    "Employ the detailed world-building of Tolkien"
]
```
#### Personalização de Escrita Geral (`src/generators/generate_response_general.py`)

**Áreas de Foco Acadêmico** - Direcione domínios específicos de escrita:

```python
academic_focuses = [
    "Rigorous analytical argument development",
    "Clear thesis statement and supporting evidence",
    "Proper academic citation and source integration",
    "Logical flow and coherent structure"
]
```
**Abordagens de Escrita** - Defina estratégias analíticas:

```python
writing_approaches = [
    "Comparative analysis with multiple perspectives",
    "Problem-solution framework with evidence",
    "Cause-and-effect reasoning with examples",
    "Critical evaluation with balanced arguments"
]
```
### Personalizando os Critérios de Avaliação (`src/generators/judge_response.py`)

Você pode modificar os critérios de avaliação e os prompts de julgamento para focar em aspectos específicos da qualidade da escrita:


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
### Dicas para Configuração Avançada

1. **Faça backup dos arquivos originais**: Sempre mantenha cópias dos arquivos originais do gerador antes de fazer alterações
2. **Teste incrementalmente**: Faça pequenas alterações e teste com algumas iterações antes de executar ciclos completos de evolução
3. **Monitore os resultados**: Use a interface web para validar se suas customizações melhoram a qualidade das histórias
4. **Misture e combine**: Combine diferentes conjuntos de missões e estilos de autores para estratégias de geração exclusivas
5. **Controle de versão**: Acompanhe suas customizações com git para reverter, se necessário

Essa abordagem modular permite ajustar finamente o processo de evolução para seus objetivos e domínios de escrita específicos.

## 🌐 Interface Web

Valide seus resultados de evolução com a interface web integrada:


```bash
cd web_interface
pip install -r requirements.txt
python app.py
```
Abra http://localhost:5000 para acessar:

- **Comparação de Histórias**: Leitura lado a lado e seleção de preferência
- **Classificações ELO**: Visualize as posições atuais e estatísticas
- **Acompanhamento da Evolução**: Valide se as gerações posteriores melhoram
- **Exportação de Dados**: Baixe os resultados para análise


```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---
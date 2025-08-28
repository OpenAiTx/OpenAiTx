
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
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
    <img src="https://img.shields.io/badge/License-CC%20By%20SA%204.0-orange.svg" alt="Licença">
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

## Novidades
- [2025-08-22] **Correção de Bug**: No código Bird-Interact-Agent, corrigimos um bug onde, ao avaliar SQL da fase-2, o SQL armazenado da fase-1 não podia ser executado com sucesso, levando a uma taxa de sucesso menor na Fase-2. Este bug afeta apenas tarefas nas quais o sql da fase1 realiza operações no banco de dados, por exemplo, CREATE table, etc.

## 🧸 Visão Geral

BIRD-INTERACT, um benchmark interativo de texto-para-SQL, **reimagina a avaliação de Text-to-SQL pelo olhar das interações dinâmicas**.
O ambiente combina uma base de conhecimento hierárquica, documentação de banco de dados e um simulador de usuário orientado por funções para recriar ambientes empresariais autênticos em todas as operações **CRUD**.
Oferece dois modos rigorosos de teste: (1) **Interação Conversacional** passiva e (2) **Interação Agente** ativa, abrangendo 600 tarefas anotadas incluindo Business Intelligence (BI), operações CRUD e etc., cada uma protegida por casos de teste executáveis.
Avaliações típicas geram de 1.968 a 5.496 turnos de interação entre modelo e simulador de usuário, enquanto modelos de raciocínio de última geração resolvem apenas **≈24%** e **≈18%** das tarefas, destacando o desafio do benchmark.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ Dois Modos de Avaliação

O BIRD-INTERACT suporta dois modos de avaliação como mencionado acima:

   - **c-Interact**: Interação Conversacional, que é um modo passivo e o fluxo de trabalho é fixo. O código e informações detalhadas podem ser encontrados em `bird_interact_conv`.
   - **a-Interact**: Interação Agente, que é um modo ativo incorporado onde o fluxo de trabalho é dinâmico e liderado pelos modelos. O código e informações detalhadas podem ser encontrados em `bird_interact_agent`.


### 🐣 Versão Lite

Estamos lançando uma versão lite do BIRD-INTERACT, `bird-interact-lite-exp`, que inclui 270 tarefas reais de alta qualidade, especificamente para PostgreSQL. Esta é uma boa opção para experimentação rápida.

### 🦜 Versão Completa

A versão completa do BIRD-INTERACT, `bird-interact-full`, é um benchmark abrangente que inclui 600 tarefas para PostgreSQL. Ela cobre uma ampla variedade de operações SQL e consultas de usuários. A versão completa estará disponível em breve.

### Resultados de Desempenho dos Modelos no BIRD-INTERACT Lite

#### 1. **Desempenho c-Interact**
| Classificação | Nome do Modelo      | Recompensa Normalizada | Nível           |
|:------:|---------------------|:---------:|:-------------------:|
| 1    | o3-mini              | 33,04     | 🏆 Chat Excelente    |
| 2    | GPT-4o               | 30,33     | 💎 Chat Bom          |
| 3    | Gemini-2.0-flash     | 27,41     | 💎 Chat Bom          |
| 4    | Claude-3.7-sonnet    | 26,60     | ✨ Padrão            |
| 5    | DeepSeek-R1          | 21,74     | ✨ Padrão            |
| 6    | Qwen3                | 20,33     | ⚪ Básico            |
| 7    | DeepSeek-V3          | 15,85     | ⚪ Básico            |

#### 2. **Desempenho a-Interact**
| Classificação | Nome do Modelo      | Parâmetros de Orçamento* | Média de Passos/Tarefa | Média de Custo (USD)/Tarefa | Recompensa Normalizada | Nível                   |
|:------:|---------------------|:---------------------:|:---------------------:|:-------------------------:|:---------------------:|:--------------------------:|
| 1    | Claude-3.7-sonnet    | 6/6 | 15,4 | $0,6668 | 29,19 | 🏆 Interação Excelente     |
| 2    | o3-mini              | 6/6 | 7,8  | $0,0754 | 21,07 | 💎 Interação Boa           |
| 3    | DeepSeek-V3          | 6/6 | 15,6 | $0,0629 | 19,19 | 💎 Interação Boa           |
| 4    | Qwen3                | 6/6 | 12,5 | $0,0278 | 18,74 | ✨ Padrão                  |
| 5    | GPT-4o               | 6/6 | 15,3 | $0,4594 | 18,37 | ✨ Padrão                  |
| 6    | Gemini-2.0-flash     | 6/6 | 13,2 | $0,0337 | 17,26 | ⚪ Básico                  |
| 7    | DeepSeek-R1          | 6/6 | 12,0 | $0,0931 | 17,07 | ⚪ Básico                  |

> \* Parâmetros de Orçamento: Orçamento Inicial/Orçamento de Paciência do Usuário, medido por nossa moeda virtual *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. Consulte [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) para mais detalhes.

### Escalabilidade do Tempo de Interação (ITS)

Escalabilidade do Tempo de Interação (ITS) refere-se à capacidade de um modelo de aumentar continuamente seu desempenho final por meio de interações multi-turno. Quando esse desempenho interativo supera o desempenho idealizado do modelo em uma tarefa totalmente especificada e não ambígua, dizemos que ele satisfaz a **lei ITS**. À medida que a paciência do usuário cresce e os turnos de interação se acumulam, o desempenho continua melhorando, demonstrando que o modelo pode sustentar comunicação eficaz durante diálogos prolongados. Atualmente, apenas o claude-3-7-sonnet satisfaz a lei ITS.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 Detalhes do Conjunto de Dados

### Descrição do Conjunto de Dados

- **Banco de Dados:** O banco de dados completo PostgreSQL pode ser baixado do [Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view). Consulte a seção [Quick Eval](#quick-eval) para mais detalhes.
- **dados:** Cada instância de dados contém as seguintes partes principais:
   - `selected_database`: O nome do banco de dados.
   - `query`: A consulta do usuário sem ambiguidades.
   - `amb_user_query`: A consulta do usuário com ambiguidades injetadas.
   - `user_query_ambiguity`: As ambiguidades injetadas na consulta do usuário.
   - `non_critical_ambiguity`: As ambiguidades não críticas, como ordem, limite, etc.
   - `knowledge_ambiguity`: As ambiguidades criadas por conhecimentos externos mascarados.
   - `sol_sql`: A solução SQL considerada como verdade.
   - `preprocess_sql`: Consultas SQL para executar antes da solução ou predição.
   - `clean_up_sql`: Consultas SQL para executar após os casos de teste e reverter quaisquer mudanças feitas no banco de dados.
   - `test_cases`: Um conjunto de casos de teste para validar o SQL corrigido previsto.
   - `follow_up`: As perguntas de acompanhamento rotuladas.
   - `external_knowledge`: O conhecimento externo relacionado à tarefa específica.

- **avaliação:** O código de avaliação está disponível no diretório [`./evaluation`](./evaluation).
- **Curadoria:** Equipe BIRD & Google Cloud
- **Licença:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **Ficha do Conjunto de Dados na HuggingFace:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### Usos do Conjunto de Dados

Para evitar vazamento de dados por auto-raspagem, não incluímos SQLs de solução GT e casos de teste junto com os dados.
por favor envie um e-mail para [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) com a tag `[bird-interact-lite GT&Test Cases]` no título para o conjunto completo, que será enviado automaticamente.


<!-- ### Use o Conjunto de Dados da HuggingFace

Você pode baixar o conjunto de dados da HuggingFace usando o seguinte comando:
```bash
from datasets import load_dataset
# Load the flash version of the dataset
dataset = load_dataset("birdsql/bird-interact-lite")
print(dataset["lite"][0])

# Load the full version of the dataset (coming soon)
dataset = load_dataset("birdsql/bird-interact-full")
print(dataset["full"][0])
```
Ou você pode usar o script fornecido para baixar a versão completa do conjunto de dados e dividi-lo em diferentes dialetos.

```bash
cd baseline/data
python pull_data.py \
  --schema_path caminho/para/full_schema.jsonl \
  --input_path caminho/para/input.jsonl \ # Caminho para o arquivo JSONL de entrada (pode estar vazio se quiser baixar o conjunto de dados do HuggingFace)
  --output_folder caminho/para/output_dir # pasta de saída dos arquivos divididos
```

## Estrutura de Pastas
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
Os detalhes sobre como executar **a-interact** podem ser encontrados em `./bird_interact_agent/README.md`; e **c-interact** podem ser encontrados em `./bird_interact_conv/README.md`.

## 📰 Novidades

🚀 Estamos animados em anunciar o lançamento do conjunto **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)**!  
Este é desafiador — os melhores LLMs estão alcançando apenas **16,33%** de taxa de sucesso, com apenas **10,0%** nas partes `c-interact` e `a-interact`.  
👉 Para mais detalhes, visite nosso [site do projeto](https://bird-interact.github.io/).

📬 Vamos enviar os **Casos de Teste & Ground Truth** para nossa lista de e-mails esta semana.  
Se você deseja acesso antecipado, envie um e-mail conforme instruído no site para um **download automático**.  

💾 Em outra nota, também lançamos uma versão SQLite do **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)** para facilitar pesquisas locais.  
As versões completas **LiveSQLBench-Base** e **-Large** estão chegando em breve!

## 📋 Listas de Tarefas

- [x] Lançar versão lite, bird-interact-lite (270).
- [x] Lançar versão conversacional, bird-interact-conv.
- [x] Lançar versão agente, bird-interact-agent.
- [x] Lançar versão Full bird-interact-full (600).
- [ ] SFT / RL de um Simulador de Usuário

## Criado por:
Equipe BIRD & Google Cloud



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-27

---
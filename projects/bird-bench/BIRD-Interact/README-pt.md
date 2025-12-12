
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
    <img src="https://img.shields.io/badge/Leaderboard-2025-28a745.svg" alt="Ranking">
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

## ⚠️ Aviso  
Por favor, note que antes do processo de avaliação, quando o Docker carrega os bancos de dados, erros podem ocasionalmente ocorrer devido à inconsistência do ambiente (estes não encerram o processo, mas aparecerão nos logs do Docker). Como resultado, alguns bancos podem não carregar corretamente, levando a bancos vazios. Isso causará resultados anormalmente baixos na avaliação.  
👉 Portanto, recomendamos fortemente que verifique os logs do Docker para eventuais erros **antes de rodar a avaliação** e confirme que todos os bancos de dados foram carregados com sucesso.

👉 Atualizamos as **Diretrizes de Submissão**, onde agora são suportados scaffolds de agentes personalizados. Sinta-se à vontade para conferir nossas diretrizes detalhadas de submissão [aqui](https://docs.google.com/document/d/1F1DSqHDBzGvXFlWU8iCl9otkqxIefgcH/edit?usp=sharing&ouid=108161566779099489782&rtpof=true&sd=true).

## 📰 Novidades

- [2025-11-06] 🐛 **Correção de Bug** & 🐳 **Atualização Docker**: Atualize a versão do sqlglot para 26.16.4 para corrigir o bug em que o analisador SQL não conseguia interpretar corretamente o SQL para o simulador de usuário. Você pode corrigir isso reinstalando com `pip install sqlglot==26.16.4` no ambiente `bird_interact_eval`. A imagem `bird_interact_eval` também foi atualizada, então você pode puxá-la e recriar o container `bird_interact_eval`.

- [2025-10-21] 🐳 **Atualização Docker**: Adicionamos o docker para o Ambiente Full DB. E publicamos 3 imagens docker (Base/Full DB Env e o ambiente de avaliação para ambos `a-Interact` e `c-Interact`) no Docker Hub para facilitar a configuração do ambiente. Não é necessário baixar os dumps do BD e construir as imagens manualmente!

- [2025-10-08] 📝 Nosso **[artigo Bird-Interact](https://huggingface.co/papers/2510.05318)** já está disponível publicamente!  
  Ele apresenta todos os detalhes, metodologia e avaliação do nosso benchmark interativo texto-para-SQL.  
  👉 Confira e saiba mais sobre as ideias por trás do [BIRD-Interact](https://bird-interact.github.io/).

- [2025-08-26] 🚀 Estamos empolgados em anunciar o lançamento do **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)**!  
É um desafio — os melhores LLMs estão alcançando apenas **16,33%** de sucesso, com apenas **10,0%** nas porções `c-interact` e `a-interact`.  
👉 Para mais detalhes, visite nosso [site do projeto](https://bird-interact.github.io/).

- [2025-08-26] 📬 Enviaremos os **Casos de Teste & Gabaritos** para nossa lista de e-mails nesta semana.  
Se quiser acesso antecipado, envie um e-mail conforme instruções no site para um **download automático**.  
- [2025-08-26] 💾 Em outra nota, também lançamos uma versão SQLite do **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)** para facilitar pesquisas locais.  
As versões completas **LiveSQLBench-Base** e **-Large** estarão disponíveis em breve!

- [2025-08-22] **Correção de Bug**: No código do Bird-Interact-Agent, corrigimos um bug que, ao avaliar SQL da fase 2, o SQL armazenado na fase 1 não podia ser executado com sucesso, levando a uma taxa de sucesso menor na Fase 2. Este bug afeta apenas tarefas onde o SQL da fase 1 realiza operações no banco de dados, por exemplo, CREATE table, etc.

## 🧸 Visão Geral

BIRD-INTERACT, um benchmark interativo de text-to-SQL, **reimagina a avaliação Text-to-SQL através da lente de interações dinâmicas**.
O ambiente combina uma base de conhecimento hierárquica, documentação do banco de dados e um simulador de usuário baseado em funções para recriar ambientes empresariais autênticos em todas as operações **CRUD**.
Oferece dois modos rigorosos de teste: (1) **Interação Conversacional** passiva e (2) **Interação Agente** ativa, abrangendo 600 tarefas anotadas, incluindo Business Intelligence (BI), operações CRUD, etc., cada uma protegida por casos de teste executáveis.
Avaliações típicas disparam entre 1.968 e 5.496 rodadas de interação entre o modelo e o simulador de usuário, enquanto os modelos de raciocínio mais avançados atualmente resolvem apenas **≈24%** e **≈18%** das tarefas, destacando o desafio do benchmark.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ Dois Modos de Avaliação

O BIRD-INTERACT suporta dois modos de avaliação conforme mencionado acima:

   - **c-Interact**: Interação Conversacional, que é um modo passivo e o fluxo de trabalho é fixo. O código e informações detalhadas podem ser encontrados em `bird_interact_conv`.
   - **a-Interact**: Interação Agente, que é um modo ativo incorporado onde o fluxo de trabalho é dinâmico e liderado pelos modelos. O código e informações detalhadas podem ser encontrados em `bird_interact_agent`.


### 🐣 Versão Lite

Estamos lançando uma versão lite do BIRD-INTERACT, `bird-interact-lite-exp`, que inclui 270 tarefas do mundo real de alta qualidade, especificamente para PostgreSQL. É um bom ponto de partida para experimentação rápida. 

### 🦜 Versão Completa

A versão completa do BIRD-INTERACT, `bird-interact-full`, é um benchmark abrangente que inclui 600 tarefas para PostgreSQL. Ela cobre uma ampla variedade de operações SQL e consultas de usuários. A versão completa estará disponível em breve.

### Resultados de Performance de Modelos no BIRD-INTERACT-FULL

#### 1. **c-Interact Text-to-SQL** Performance
| Rank | Nome do Modelo     | Recompensa Normalizada | Custo Médio (USD)/Tarefa | Nível              |
|:----:|:-------------------|:---------------------:|:------------------------:|:------------------:|
| 1    | Gemini-2.5-Pro     | 20.92                 | $0.04                    | 🏆 Excelente Chat  |

| 2    | O3-Mini            | 20,27             | $0,07               | 🏆 Chat Excelente   |
| 3    | Claude-Sonnet-4    | 18,35             | $0,29               | 💎 Chat Bom         |
| 4    | Qwen-3-Coder-480B  | 17,75             | $0,11               | 💎 Chat Bom         |
| 5    | Deepseek-Chat-V3.1 | 15,15             | $0,12               | ✨ Padrão           |
| 6    | Claude-Sonnet-3.7  | 13,87             | $0,29               | ✨ Padrão           |
| 7    | GPT-5              | 12,58             | $0,08               | ⚪ Básico           |

#### 2. **a-Interact Text-to-SQL** Desempenho
| Rank | Nome do Modelo     | Recompensa Normalizada | Custo Médio (USD)/Tarefa | Nível                      |
|:----:|:-------------------|:---------------------:|:------------------------:|:--------------------------:|
| 1    | GPT-5              | 25,52                 | $0,24                    | 🏆 Interação Excelente     |
| 2    | Claude-Sonnet-4    | 23,28                 | $0,51                    | 🏆 Interação Excelente     |
| 3    | Claude-Sonnet-3.7  | 17,45                 | $0,60                    | 💎 Interação Boa           |
| 4    | Gemini-2.5-Pro     | 17,33                 | $0,22                    | 💎 Interação Boa           |
| 5    | O3-Mini            | 16,43                 | $0,06                    | ✨ Padrão                  |
| 6    | Deepseek-Chat-V3.1 | 13,47                 | $0,06                    | ✨ Padrão                  |
| 7    | Qwen-3-Coder-480B  | 10,58                 | $0,07                    | ⚪ Básico                  |

> \* Parâmetros de Orçamento: Orçamento Inicial/Orçamento de Paciência do Usuário, medido por nossa moeda virtual *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. Consulte [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) para mais detalhes.

### Escalonamento do Tempo de Interação (ITS)

Escalonamento do Tempo de Interação (ITS) refere-se à capacidade de um modelo de aumentar continuamente seu desempenho final por meio de interações de múltiplas rodadas. Quando esse desempenho interativo supera o desempenho idealizado de rodada única do modelo em uma tarefa totalmente especificada e não ambígua, dizemos que ele satisfaz a **lei ITS**. À medida que a paciência do usuário cresce e as rodadas de interação se acumulam, o desempenho continua melhorando, demonstrando que o modelo pode sustentar comunicação eficaz durante um diálogo prolongado. Atualmente, apenas encontramos que o claude-3-7-sonnet satisfaz a lei ITS.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## Configuração do Ambiente

1. Execute os containers Docker para o banco de dados bird-interact-lite, banco de dados bird-interact-full e ambiente de avaliação:
  
  > Se você quiser apenas avaliar no `bird-interact-lite`, pode comentar o serviço [`postgresql_full`](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/./env/docker-compose.yml#L21-L31) em `docker-compose.yml` para acelerar a configuração do ambiente.
  
  Inicie o ambiente executando:
   ```bash
   cd env
   docker compose pull 
   docker compose up -d
   ```
   Aguarde alguns minutos para a inicialização do banco de dados.
   
  Você pode acompanhar o progresso da construção por:
  ```bash
  docker compose logs -f --tail=100 bird_interact_postgresql_full # or bird_interact_postgresql for bird-interact-lite
  ```
  Se concluído, você deverá ver os logs sem erros, como:

  ```bash
  bird_interact_postgresql_full  | 2025-10-28 17:58:30.413 HKT [1] LOG:  database system is ready to accept connection
  ```
  
  Se você já criou contêineres antes e deseja recriá-los, pode executar o seguinte comando:
  ```bash
  docker compose down -v # this cmd removes the containers and the volumes
  docker compose pull   # pull the latest images from Docker Hub
  docker compose up -d --force-recreate # build and start the containers again. --force-recreate means force the recreation of the containers. 
  # Or `docker compose up -d --force-recreate bird_interact_eval` to only recreate the bird_interact_eval container about evalution code environment.
  ```
   
   Isso executa 3 containers usando imagens pré-construídas do Docker Hub:
   - `bird_interact_postgresql`: Banco de dados PostgreSQL para bird-interact-lite
   - `bird_interact_postgresql_full`: Banco de dados PostgreSQL para bird-interact-full
   - `bird_interact_eval`: Ambiente de avaliação para ambos `a-Interact` e `c-Interact`.

   Agora, você pode iniciar o ambiente de avaliação executando o seguinte comando:
   ```bash
   docker compose exec bird_interact_eval bash
   ```

2. (Opcional) Construa o ambiente manualmente (se quiser criar as imagens do zero): 
   - Baixe os dumps do banco de dados 
      - [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view). Extraia e renomeie como `env/postgre_table_dumps`.
      - [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view). Extraia e renomeie como `env/postgre_table_dumps_full`.
   - Construa o ambiente manualmente executando `docker-compose.build.yml`.
      ```bash
      cd env/
      docker compose -f docker-compose.build.yml build
      docker compose -f docker-compose.build.yml up -d
      ```

3. (Recomendado) Verifique se os containers de banco de dados foram construídos e estão em execução com sucesso.

-  Imprima os logs de construção dos containers para garantir que os bancos de dados foram construídos com sucesso, sem erros:
   ```bash 
   docker logs bird_interact_postgresql > build_bird_interact_postgresql.log 2>&1
   docker logs bird_interact_postgresql_full > build_bird_interact_postgresql_full.log 2>&1
   ```
   Se ocorrerem erros, `"Ocorreram erros durante a importação:"` será impresso nos arquivos de log.


-  Verifique se os containers de banco de dados estão em bom estado.
   
   Use nosso script Python fornecido para verificar os metadados do banco de dados:
   ```bash
   docker compose exec bird_interact_eval bash
   cd /app/env
   python check_db_metadata.py --host bird_interact_postgresql
   python check_db_metadata.py --host bird_interact_postgresql_full
   ```
   
   Resultados esperados:
   - **bird-interact-lite**: 
     - 📈 Total de Bancos de Dados: 18
     - 📋 Total de Tabelas: 175
     - 🔢 Total de Colunas: 2286
     - 📈 Média de Linhas por Tabela: 1.038,48
     - 💾 Tamanho Total: 207,15 MB (aproximadamente)
   - **bird-interact-full**: 
     - 📈 Total de Bancos de Dados: 22
     - 📋 Total de Tabelas: 244
     - 🔢 Total de Colunas: 2011
     - 📈 Média de Linhas por Tabela: 1.121,19
     - 💾 Tamanho Total: 272,00 MB (aproximadamente)


## 📦 Detalhes do Conjunto de Dados

### Descrição do Conjunto de Dados

- **Banco de Dados:** O banco de dados PostgreSQL completo pode ser baixado em [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view) e [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view).
- **dados:** Cada instância de dados contém as seguintes partes principais:
   - `selected_database`: O nome do banco de dados.  
   - `query`: A consulta do usuário sem ambiguidades.  
   - `amb_user_query`: A consulta do usuário com ambiguidades injetadas.
   - `user_query_ambiguity`: As ambiguidades injetadas na consulta do usuário.
   - `non_critical_ambiguity`: Ambiguidades não críticas como ordem, limite, etc.
   - `knowledge_ambiguity`: Ambiguidades criadas pelo mascaramento de conhecimentos externos. 
   - `sol_sql`: A solução SQL verídica.  
   - `preprocess_sql`: Consultas SQL para executar antes da solução ou predição.  
   - `clean_up_sql`: Consultas SQL para executar após os testes e reverter alterações no banco.  
   - `test_cases`: Um conjunto de casos de teste para validar o SQL corrigido previsto.
   - `follow_up`: As perguntas de acompanhamento rotuladas.
   - `external_knowledge`: O conhecimento externo relacionado à tarefa específica.

- **avaliação:** O código de avaliação está disponível no diretório [`./evaluation`](./evaluation).
- **Curadoria:** Equipe BIRD & Google Cloud
- **Licença:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **Cartão do Conjunto de Dados na HuggingFace:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)
  e [bird-interact-full](https://huggingface.co/datasets/birdsql/bird-interact-full)
### Usos do Conjunto de Dados

Para evitar vazamento de dados por auto-crawling, não incluímos SQLs de solução GT e casos de teste juntamente com os dados.
por favor envie um e-mail para [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) com a tag `[bird-interact-lite GT&Test Cases]` ou `[bird-interact-full GT&Test Cases]` no título para obter a verdade de base e casos de teste para o conjunto de dados bird-interact-lite ou bird-interact-full, que serão enviados automaticamente.


### Combine os dados públicos com a verdade de base e casos de teste

Em seguida, use o seguinte script para combinar os dados públicos com a verdade de base e casos de teste:

Pegue a versão completa como exemplo:
(1) Execute:
```bash
python combine_public_with_gt.py /path/to/bird-interact-full/bird_interact_data.jsonl /path/to/bird_interact_full_gt_kg_testcases_08022.jsonl /path/to/bird_interact_data.jsonl  # bird_interact_full_gt_kg_testcases_08022.jsonl is the data of ground-truth fields, which is obtained by emailing us.
```
Isso criará um novo arquivo em `/path/to/bird_interact_data.jsonl` com os dados combinados.

(2) Em seguida, substitua os dados públicos originais pelos dados combinados:

```bash
cp /path/to/bird_interact_data.jsonl /path/to/bird-interact-full/bird_interact_data.jsonl
```

O mesmo vale para as outras versões: bird-interact-lite, versão mini, etc. Basta definir os caminhos corretos para os dados públicos, os dados de verdade e os casos de teste, e então substituir os dados públicos pelos dados combinados.




<!-- ### Usar o Dataset do HuggingFace

Você pode baixar o dataset do HuggingFace usando o seguinte comando:
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

## 📋 Listas de Tarefas

- [x] Lançar versão lite, bird-interact-lite (270).
- [x] Lançar versão conversacional, bird-interact-conv.
- [x] Lançar versão agent, bird-interact-agent.
- [x] Lançar versão completa bird-interact-full (600).
- [ ] SFT / RL de Simulador de Usuário

## Agradecimentos
Gostaríamos de expressar nossa sincera gratidão a **Irina Saparina**, **Mohammadreza Pourreza**, **Mehdi Bouzouina**, **Hailong Li**, **Jiatong Shi** e ao Professor **Shinji Watanabe** pelas discussões frutíferas e valiosas ideias que ajudaram a melhorar este projeto.

## Criado Por:
Equipe BIRD & Google Cloud








## Registro de Alterações

- [2025-11-06] 🐛 **Correção de Bug** & 🐳 **Atualização do Docker**: Atualize a versão do sqlglot para 26.16.4 para corrigir o bug em que o analisador SQL não consegue analisar o SQL corretamente para o simulador de usuário. Você pode corrigir isso reinstalando com `pip install sqlglot==26.16.4` no ambiente `bird_interact_eval`. A imagem `bird_interact_eval` também foi atualizada, então você pode baixá-la e recriar o container `bird_interact_eval`.
- [2025-10-21] 🐳 **Atualização do Docker**: Adicionado o docker para o ambiente Full DB. E publicamos 3 imagens docker (Base/Ambiente Full DB e o ambiente de avaliação para ambos `a-Interact` e `c-Interact`) no Docker Hub para facilitar a configuração do ambiente. Não é necessário baixar os dumps do DB e construir as imagens manualmente! Por favor, baixe as imagens mais recentes do Docker Hub e recrie os containers, por exemplo usando `docker compose down -v && docker compose pull && docker compose up -d --force-recreate`.
- [2025-08-22]  🐛 **Correção de Bug**: Corrigido o bug em que, ao avaliar SQL da fase-2, o SQL armazenado da fase-1 não pode ser executado com sucesso, levando a uma taxa de sucesso menor na Fase-2. Esse bug afeta apenas as tarefas em que o SQL da fase1 realiza algumas operações no banco de dados, por exemplo, CREATE table, etc.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-12

---
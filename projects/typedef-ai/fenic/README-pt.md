<!-- markdownlint-disable MD041 MD033 -->
<div align="center">
    <picture>
        <source media="(prefers-color-scheme: dark)" srcset="docs/images/typedef-fenic-logo-dark.png">
        <img src="https://raw.githubusercontent.com/typedef-ai/fenic/main/docs/images/typedef-fenic-logo.png" alt="fenic, by typedef" width="90%">
    </picture>
</div>

# fenic: o dataframe (re)construído para inferência LLM

[![Versão no PyPI](https://img.shields.io/pypi/v/fenic.svg)](https://pypi.org/project/fenic/)
[![Versões do Python](https://img.shields.io/pypi/pyversions/fenic.svg)](https://pypi.org/project/fenic/)
[![Licença](https://img.shields.io/github/license/typedef-ai/fenic.svg)](https://github.com/typedef-ai/fenic/blob/main/LICENSE)
[![Discord](https://img.shields.io/discord/1381706122322513952?label=Discord&logo=discord)](https://discord.gg/GdqF3J7huR)

---

## **Documentação**: [docs.fenic.ai](https://docs.fenic.ai/)

fenic é um framework de DataFrame opinativo, inspirado no PySpark, da typedef.ai para construir aplicações de IA e agentes. Transforme dados não estruturados e estruturados em insights usando operações familiares de DataFrame aprimoradas com inteligência semântica. Com suporte de primeira classe para markdown, transcrições e operadores semânticos, além de inferência em lote eficiente através de qualquer provedor de modelo.
## Instalação

fenic suporta Python `[3.10, 3.11, 3.12]`

```bash
pip install fenic
```

### Configuração do Provedor de LLM

fenic requer uma chave de API de pelo menos um provedor de LLM. Defina a variável de ambiente apropriada para o provedor escolhido:

```bash
# Para OpenAI
export OPENAI_API_KEY="sua-chave-api-openai"

# Para Anthropic
export ANTHROPIC_API_KEY="sua-chave-api-anthropic"

# Para Google
export GEMINI_API_KEY="sua-chave-api-do-google"
```

## Início Rápido

A maneira mais rápida de aprender sobre o fenic é conferindo os exemplos.

Abaixo está uma lista rápida dos exemplos neste repositório:

| Exemplo                                                                   | Descrição                                                                                                                          |
| ------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------- |
| [Hello World!](examples/hello_world)                                      | Introdução à extração e classificação semântica usando os operadores principais do fenic através da análise de logs de erro.       |
| [Enriquecimento](examples/enrichment)                                     | DataFrames em múltiplas etapas com extração de texto baseada em templates, joins e transformações com LLM demonstradas via log.    |
| [Processamento de Transcrição de Reunião](examples/meeting_transcript_processing) | Análise nativa de transcrições, integração de schemas Pydantic e agregações complexas apresentadas através da análise de reuniões. |
| [Análise de Notícias](examples/news_analysis)                             | Analise e extraia insights de artigos de notícias utilizando operadores semânticos e processamento de dados estruturados.          |
| [Sumarização de Podcast](examples/podcast_summarization)                  | Processe e resuma transcrições de podcasts com análise sensível ao locutor e extração de pontos-chave.                             |
| [Join Semântico](examples/semantic_joins)                                 | Em vez de simples correspondência fuzzy, use o poderoso join semântico do fenic para casar dados entre tabelas.                    |
| [Reconhecimento de Entidades Nomeadas](examples/named_entity_recognition) | Extraia e classifique entidades nomeadas de textos usando extração e classificação semântica.                                      |
| [Processamento de Markdown](examples/markdown_processing)                 | Processe e transforme documentos markdown com extração de dados estruturados e formatação.                                         |
| [Processamento de JSON](examples/json_processing)                         | Lide com estruturas de dados JSON complexas utilizando operações semânticas e validação de schema.                                 |
| [Agrupamento de Feedback](examples/feedback_clustering)                   | Agrupe e analise feedbacks usando similaridade semântica e operações de clusterização.                                             |
| [Extração de Documentos](examples/document_extraction)                    | Extraia informações estruturadas de vários formatos de documentos usando operadores semânticos.                                    |

(Sinta-se à vontade para clicar em qualquer exemplo acima para ir diretamente à sua pasta.)
## Por que usar o fenic?

fenic é um framework de DataFrame opinativo, inspirado no PySpark, para construção de aplicações de IA e agentes em produção.

Diferente das ferramentas de dados tradicionais adaptadas para LLMs, o mecanismo de consulta do fenic foi criado do zero, já considerando inferência.

Transforme dados estruturados e não estruturados em insights usando operações de DataFrame familiares, aprimoradas com inteligência semântica. Com suporte de primeira classe para markdown, transcrições e operadores semânticos, além de inferência em lote eficiente em qualquer provedor de modelo.

fenic traz a confiabilidade dos pipelines de dados tradicionais para cargas de trabalho de IA.

### Principais Recursos

#### Desenvolvido para Inferência de LLM

- Mecanismo de consulta projetado do zero para cargas de trabalho de IA, não adaptado
- Otimização automática de lotes para chamadas de API
- Lógica de retentativa embutida e limitação de taxa
- Contagem de tokens e rastreamento de custos

#### Operadores Semânticos como Cidadãos de Primeira Classe
- `semantic.analyze_sentiment` - Análise de sentimento incorporada
- `semantic.classify` - Categorize texto com exemplos few-shot
- `semantic.extract` - Transforme texto não estruturado em dados estruturados com esquemas
- `semantic.group_by` - Agrupe dados por similaridade semântica
- `semantic.join` - Una DataFrames pelo significado, não apenas pelos valores
- `semantic.map` - Aplique transformações de linguagem natural
- `semantic.predicate` - Crie predicados usando linguagem natural para filtrar linhas
- `semantic.reduce` - Agregue dados agrupados com operações de LLM

#### Suporte Nativo a Dados Não Estruturados

Vai além dos tipos de dados multimodais típicos (áudio, imagens) criando tipos especializados para cargas de trabalho com grande volume de texto:

- Análise e extração de Markdown como tipo de dado de primeira classe
- Processamento de transcrições (SRT, formatos genéricos) com reconhecimento de falante e marcação temporal
- Manipulação de JSON com expressões JQ para dados aninhados
- Fragmentação automática de texto com sobreposição configurável para documentos longos

#### Infraestrutura Pronta para Produção
- Suporte a múltiplos provedores (OpenAI, Anthropic, Gemini)
- Backends de execução locais e na nuvem
- Tratamento abrangente de erros e logging
- Integração com Pydantic para segurança de tipos

#### API Familiar de DataFrame

- Operações compatíveis com PySpark
- Avaliação preguiçosa e otimização de consultas
- Suporte a SQL para consultas complexas
- Integração perfeita com pipelines de dados existentes

### Por que DataFrames para Aplicações LLM e Agentes?

Aplicações de IA e agentes são fundamentalmente pipelines e fluxos de trabalho – exatamente o que as APIs de DataFrame foram projetadas para lidar. Ao invés de reinventar padrões para transformação, filtragem e agregação de dados, o fenic aproveita décadas de práticas de engenharia comprovadas.

#### Arquitetura Desacoplada para Melhores Agentes

O fenic cria uma separação clara entre tarefas pesadas de inferência e interações em tempo real dos agentes. Ao mover o processamento em lote para fora do tempo de execução do agente, você obtém:

- Agentes mais previsíveis e responsivos
- Melhor utilização de recursos com chamadas LLM em lote
- Separação mais limpa entre planejamento/orquestração e execução
#### Feito para Todos os Engenheiros

DataFrames não são apenas para profissionais de dados. O design da API fluente e componível a torna acessível para qualquer engenheiro:

- Encadeie operações de forma natural: `df.filter(...).semantic.group_by(...)`
- Misture estilos imperativos e declarativos perfeitamente
- Comece rapidamente com padrões familiares do pandas/PySpark ou SQL

## Suporte

Junte-se à nossa comunidade no [Discord](https://discord.gg/GdqF3J7huR), onde você pode se conectar com outros usuários, fazer perguntas e obter ajuda com seus projetos fenic. Nossa comunidade está sempre feliz em receber novos membros!

Se você achar o fenic útil, considere nos dar uma ⭐ no topo deste repositório. Seu apoio nos ajuda a crescer e melhorar o framework para todos!

## Contribuindo

Acolhemos contribuições de todos os tipos! Seja escrevendo código, melhorando a documentação, testando funcionalidades ou propondo novas ideias, sua ajuda é valiosa para nós.

Para desenvolvedores que planejam enviar alterações de código, incentivamos que abram primeiro uma issue para discutir suas ideias antes de criar um Pull Request. Isso ajuda a garantir o alinhamento com a direção do projeto e evita esforços duplicados.

Consulte nossas [diretrizes de contribuição](https://raw.githubusercontent.com/typedef-ai/fenic/main/CONTRIBUTING.md) para informações detalhadas sobre o processo de desenvolvimento e configuração do projeto.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---
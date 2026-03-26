
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# llama-github

[Documento Detalhado] https://deepwiki.com/JetXu-LLM/llama-github

[![Versão PyPI](https://badge.fury.io/py/llama-github.svg)](https://badge.fury.io/py/llama-github)
[![Downloads](https://static.pepy.tech/badge/Llama-github)](https://pepy.tech/project/Llama-github)
[![Licença](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)

Llama-github é uma poderosa ferramenta que ajuda você a recuperar (baseado em Agentic RAG) os trechos de código, issues e informações de repositório mais relevantes do GitHub com base nas suas consultas, transformando-os em contexto de conhecimento valioso. Ela potencializa Chatbots LLM, Agentes de IA e Agentes Auto-dev para resolver tarefas complexas de codificação. Seja você um desenvolvedor em busca de soluções rápidas ou um engenheiro implementando Agentes Avançados Auto Dev IA, o llama-github torna tudo fácil e eficiente.

Se você gosta deste projeto ou acredita que ele tem potencial, por favor, dê uma ⭐️. Seu apoio é nossa maior motivação!

## Arquitetura
![Arquitetura de Alto Nível](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/high_level_architecture.drawio.svg)

## Instalação
```
pip install llama-github
```

Alvo de tempo de execução atualmente mantido: Python `3.10+`.

## Uso

Aqui está um exemplo simples de como usar o llama-github:

```python
from llama_github import GithubRAG

# Initialize GithubRAG with your credentials
github_rag = GithubRAG(
    github_access_token="your_github_access_token", 
    openai_api_key="your_openai_api_key", # Optional in Simple Mode
    jina_api_key="your_jina_api_key" # Optional - unless you want high concurrency production deployment (s.jina.ai API will be used in llama-github)
)

# Retrieve context for a coding question (simple_mode is default set to False)
query = "How to create a NumPy array in Python?"
contexts = github_rag.retrieve_context(
    query,
    # simple_mode = True
)

print(contexts[0]["url"])
print(contexts[0]["context"])
```

`retrieve_context()` retorna uma lista de dicionários de contexto. Cada item contém pelo menos `context` e `url`.

Para usos mais avançados e exemplos, consulte a [documentação](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/docs/usage.md). Exemplos práticos e de baixo custo também estão disponíveis em [`examples/`](examples).

## Funcionalidades Principais

- **🔍 Recuperação Inteligente no GitHub**: Aproveite o poder do llama-github para recuperar trechos de código, issues e informações de repositório altamente relevantes do GitHub com base em consultas do usuário. Nossas técnicas avançadas de busca garantem que você encontre rapidamente as informações mais pertinentes.

- **⚡ Cache de Pool de Repositórios**: O llama-github possui um mecanismo inovador de cache de pool de repositórios. Ao armazenar em cache repositórios (incluindo READMEs, estruturas, código e issues) entre threads, o llama-github acelera significativamente a eficiência de busca e minimiza o consumo de tokens da API do GitHub.

- **🧠 Análise de Perguntas com LLM**: Utilize modelos de linguagem de última geração para analisar perguntas do usuário e gerar estratégias e critérios de busca altamente eficazes. O llama-github decompõe consultas complexas, garantindo a recuperação das informações mais relevantes na vasta rede de repositórios do GitHub.

- **📚 Geração Abrangente de Contexto**: Gera respostas ricas e contextualmente relevantes, combinando informações recuperadas do GitHub com o raciocínio de modelos de linguagem avançados. O llama-github lida até com perguntas extensas e complexas, fornecendo respostas completas e contextos detalhados para apoiar seu desenvolvimento.

- **🚀 Excelência em Processamento Assíncrono**: O llama-github foi construído do zero para aproveitar todo o potencial da programação assíncrona. Com mecanismos assíncronos meticulosamente implementados em todo o código, o llama-github pode lidar com múltiplas requisições simultaneamente, aumentando significativamente o desempenho geral.

- **🔧 Integração Flexível com LLMs**: Integre facilmente o llama-github com vários provedores de LLM, modelos de embedding, modelos de reranking ou um modelo de chat compatível com LangChain para adaptar as capacidades da biblioteca às suas necessidades específicas.

- **🔒 Opções Robusta de Autenticação**: O llama-github suporta tanto tokens de acesso pessoal quanto autenticação via GitHub App, oferecendo flexibilidade para integração em diferentes ambientes de desenvolvimento. Seja para uso individual ou organizacional, o llama-github garante mecanismos de autenticação seguros e confiáveis.

- **🛠️ Logging e Tratamento de Erros**: Entendemos a importância de operações estáveis e fácil resolução de problemas. Por isso, o llama-github possui sistemas abrangentes de logging e tratamento de erros. Obtenha insights profundos sobre o comportamento da biblioteca, diagnostique problemas rapidamente e mantenha um fluxo de trabalho estável.

## 🤖 Experimente Nosso Assistente de Revisão de PR com IA: LlamaPReview

Se você achar o llama-github útil, talvez também se interesse pelo nosso assistente de revisão de PRs do GitHub com IA, o LlamaPReview. Ele foi criado para complementar seu fluxo de trabalho e elevar a qualidade do código.

### Principais Funcionalidades do LlamaPReview:
- 🚀 Instalação com um clique, zero configuração, execução totalmente automática
- 💯 Atualmente gratuito para uso - sem necessidade de cartão de crédito ou pagamento
- 🧠 Revisões automáticas de PR com IA e compreensão profunda de código
- 🌐 Suporte a múltiplas linguagens de programação

**O LlamaPReview utiliza a recuperação de contexto avançada e análise com LLM do llama-github** para fornecer revisões inteligentes e conscientes do contexto. É como ter um desenvolvedor sênior, com todo o contexto do repositório, revisando cada PR automaticamente!

👉 [Instale o LlamaPReview Agora](https://github.com/marketplace/llamapreview/) (Grátis)

Usando o llama-github para recuperação de contexto e o LlamaPReview para revisão de código, você cria um ambiente de desenvolvimento poderoso e aprimorado por IA.

## Visão e Roadmap

### Visão

Nossa visão é nos tornar um módulo fundamental no futuro das soluções de desenvolvimento orientadas por IA, integrando-se perfeitamente ao GitHub para capacitar LLMs a resolver automaticamente tarefas complexas de codificação.

![Arquitetura da Visão](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/vision.drawio.svg)

### Roteiro

Para uma visão histórica do roteiro anterior, por favor visite [Visão e Roteiro](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/VISION_AND_ROADMAP.md).

## Agradecimentos

Gostaríamos de expressar nossa gratidão aos seguintes projetos open-source pelo apoio e contribuições:

- **[LangChain](https://github.com/langchain-ai/langchain)**: Por fornecer a estrutura fundamental que potencializa as capacidades de prompting e processamento de LLM no llama-github.
- **[Jina.ai](https://github.com/jina-ai/reader)**: Por oferecer a API s.jina.ai e modelos open source de reranker e embedding que aumentam a precisão e relevância dos contextos gerados no llama-github.

Suas contribuições foram fundamentais para o desenvolvimento do llama-github e recomendamos fortemente que você conheça seus projetos para mais soluções inovadoras.

## Contribuindo

Agradecemos contribuições para o llama-github! Por favor, consulte nossas [diretrizes de contribuição](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/CONTRIBUTING.md) para mais informações.

## Licença

Este projeto está licenciado sob os termos da licença Apache 2.0. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

## Contato

Se você tiver dúvidas, sugestões ou feedback, sinta-se à vontade para entrar em contato conosco pelo [email do Jet Xu](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/mailto:Voldemort.xu@foxmail.com).

---

Obrigado por escolher o llama-github! Esperamos que esta biblioteca melhore sua experiência de desenvolvimento em IA e ajude você a construir aplicações poderosas com facilidade.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-26

---
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
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# llama-github

[Documento Detalhado] https://deepwiki.com/JetXu-LLM/llama-github

[![Versão PyPI](https://badge.fury.io/py/llama-github.svg)](https://badge.fury.io/py/llama-github)
[![Downloads](https://static.pepy.tech/badge/Llama-github)](https://pepy.tech/project/Llama-github)
[![Licença](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)

Llama-github é uma ferramenta poderosa que ajuda você a recuperar (baseado em Agentic RAG) os trechos de código, issues e informações de repositório mais relevantes do GitHub com base em suas consultas, transformando-os em um contexto de conhecimento valioso. Ele potencializa Chatbots LLM, Agentes de IA e Agentes Auto-dev para resolver tarefas complexas de codificação. Seja você um desenvolvedor em busca de soluções rápidas ou um engenheiro implementando Agentes Avançados de Auto Dev IA, o llama-github torna tudo mais fácil e eficiente.

Se você gosta deste projeto ou acredita que ele tem potencial, por favor, deixe uma ⭐️. Seu apoio é nossa maior motivação!

## Arquitetura
![Arquitetura de Alto Nível](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/high_level_architecture.drawio.svg)

## Instalação

```
pip install llama-github
```

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
context = github_rag.retrieve_context(
    query, # In professional mode, one query will take nearly 1 min to generate final contexts. You could set log level to INFO to monitor the retrieval progress
    # simple_mode = True
)

print(context)
```
Para usos mais avançados e exemplos, consulte a [documentação](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/docs/usage.md).

## Principais Funcionalidades

- **🔍 Recuperação Inteligente do GitHub**: Aproveite o poder do llama-github para recuperar trechos de código altamente relevantes, issues e informações de repositórios do GitHub com base nas consultas do usuário. Nossas técnicas avançadas de recuperação garantem que você encontre as informações mais pertinentes de forma rápida e eficiente.

- **⚡ Cache de Pool de Repositórios**: O llama-github possui um mecanismo inovador de cache de pool de repositórios. Ao armazenar em cache repositórios (incluindo READMEs, estruturas, código e issues) entre threads, o llama-github acelera significativamente a eficiência de busca no GitHub e minimiza o consumo de tokens da API do GitHub. Implante o llama-github em ambientes de produção multithread com confiança, sabendo que ele terá desempenho ideal e economizará recursos valiosos.

- **🧠 Análise de Perguntas com LLM**: Aproveite modelos de linguagem de última geração para analisar perguntas dos usuários e gerar estratégias e critérios de busca altamente eficazes. O llama-github decompõe inteligentemente consultas complexas, garantindo que você recupere as informações mais relevantes da vasta rede de repositórios do GitHub.

- **📚 Geração de Contexto Abrangente**: Gere respostas ricas e contextualmente relevantes, combinando perfeitamente informações recuperadas do GitHub com a capacidade de raciocínio de modelos de linguagem avançados. O llama-github se destaca ao lidar com questões complexas e extensas, fornecendo respostas completas e perspicazes que incluem amplo contexto para apoiar suas necessidades de desenvolvimento.

- **🚀 Excelência em Processamento Assíncrono**: O llama-github foi construído do zero para aproveitar todo o potencial da programação assíncrona. Com mecanismos assíncronos meticulosamente implementados em todo o código, o llama-github pode lidar com várias requisições simultaneamente, aumentando significativamente o desempenho geral. Experimente a diferença enquanto o llama-github gerencia eficientemente cargas de trabalho de alto volume sem comprometer a velocidade ou qualidade.

- **🔧 Integração Flexível com LLMs**: Integre facilmente o llama-github com diversos provedores de LLMs, modelos de embedding e modelos de reranking para adaptar as capacidades da biblioteca às suas necessidades específicas. Nossa arquitetura extensível permite personalizar e aprimorar a funcionalidade do llama-github, garantindo que ele se adapte perfeitamente ao seu ambiente de desenvolvimento.

- **🔒 Opções Robusta de Autenticação**: O llama-github suporta tanto tokens de acesso pessoal quanto autenticação via GitHub App, oferecendo flexibilidade para integrá-lo em diferentes ambientes de desenvolvimento. Seja você um desenvolvedor individual ou atuando em um contexto organizacional, o llama-github oferece mecanismos de autenticação seguros e confiáveis.

- **🛠️ Log e Tratamento de Erros**: Entendemos a importância de operações suaves e fácil solução de problemas. Por isso, o llama-github vem equipado com mecanismos abrangentes de log e tratamento de erros. Obtenha insights detalhados sobre o comportamento da biblioteca, diagnostique problemas rapidamente e mantenha um fluxo de trabalho de desenvolvimento estável e confiável.

## 🤖 Experimente Nosso Assistente de Revisão de PR com IA: LlamaPReview

Se você acha o llama-github útil, talvez também se interesse por nosso assistente de revisão de PR do GitHub com IA, o LlamaPReview. Ele foi projetado para complementar seu fluxo de desenvolvimento e aprimorar ainda mais a qualidade do código.

### Principais Funcionalidades do LlamaPReview:
- 🚀 Instalação com um clique, zero configuração, totalmente automático
- 💯 Atualmente gratuito para uso - não requer cartão de crédito ou informações de pagamento
- 🧠 Revisões automáticas de PR com IA e compreensão profunda de código
- 🌐 Suporta múltiplas linguagens de programação

**O LlamaPReview utiliza a recuperação de contexto avançada do llama-github e análise com LLM** para fornecer revisões de código inteligentes e com contexto. É como ter um desenvolvedor sênior, munido de todo o contexto do seu repositório, revisando cada PR automaticamente!

👉 [Instale o LlamaPReview Agora](https://github.com/marketplace/llamapreview/) (Grátis)

Ao usar o llama-github para recuperação de contexto e o LlamaPReview para revisões de código, você pode criar um ambiente de desenvolvimento poderoso e aprimorado por IA.

## Visão e Roteiro

### Visão

Nossa visão é nos tornarmos um módulo fundamental no futuro das soluções de desenvolvimento orientadas por IA, integrando-se perfeitamente ao GitHub para capacitar LLMs a resolver automaticamente tarefas complexas de codificação.

![Arquitetura da Visão](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/vision.drawio.svg)

### Roteiro

Para uma visão detalhada do nosso roteiro do projeto, visite nosso [Roteiro do Projeto](https://github.com/users/JetXu-LLM/projects/2).

## Agradecimentos

Gostaríamos de expressar nossa gratidão aos seguintes projetos open-source por seu apoio e contribuições:

- **[LangChain](https://github.com/langchain-ai/langchain)**: Por fornecer a estrutura fundamental que potencializa as capacidades de prompting e processamento de LLM no llama-github.
- **[Jina.ai](https://github.com/jina-ai/reader)**: Por oferecer a API s.jina.ai e modelos open source de reranker e embedding que aprimoram a precisão e relevância dos contextos gerados no llama-github.

Suas contribuições foram fundamentais para o desenvolvimento do llama-github, e recomendamos fortemente que você confira seus projetos para mais soluções inovadoras.

## Contribuindo

Contribuições para o llama-github são bem-vindas! Consulte nossas [diretrizes de contribuição](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/CONTRIBUTING.md) para mais informações.

## Licença

Este projeto está licenciado sob os termos da licença Apache 2.0. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

## Contato

Se você tiver dúvidas, sugestões ou comentários, fique à vontade para entrar em contato conosco pelo [email do Jet Xu](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/mailto:Voldemort.xu@foxmail.com).

---

Obrigado por escolher o llama-github! Esperamos que esta biblioteca aprimore sua experiência de desenvolvimento com IA e ajude você a construir aplicações poderosas com facilidade.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-28

---
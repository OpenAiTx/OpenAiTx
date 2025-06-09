![note-gen](https://socialify.git.ci/codexu/note-gen/image?custom_description=Cross-Platform+%7C+LLM+%7C+Markdown+%7C++Recording++%26+Writing&description=1&font=Raleway&forks=1&issues=1&logo=https%3A%2F%2Fcamo.githubusercontent.com%2Fbe4a3a39f8724658ad5bc549d63f0454ad4ca98564c73b7b0778704ca5212509%2F68747470733a2f2f73322e6c6f6c692e6e65742f323032352f30352f32362f594d4e67784b5644724238345a74572e706e67&name=1&owner=1&pattern=Circuit+Board&stargazers=1&theme=Light)

# NoteGen

![](https://github.com/codexu/note-gen/actions/workflows/release.yml/badge.svg?branch=release)
![](https://img.shields.io/github/v/release/codexu/note-gen)
![](https://img.shields.io/badge/version-alpha-orange)
![](https://img.shields.io/github/downloads/codexu/note-gen/total)
![](https://img.shields.io/github/commit-activity/m/codexu/note-gen)

English | [简体中文](.github/README.zh.md) | [日本語](.github/README.ja.md)

<div style="display: flex; gap: 1rem;">
  <a href="https://www.producthunt.com/products/notegen-2?embed=true&utm_source=badge-featured&utm_medium=badge&utm_source=badge-notegen&#0045;2" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=956348&theme=light&t=1749194675492" alt="NoteGen - A&#0032;cross&#0045;platform&#0032;Markdown&#0032;note&#0045;taking&#0032;application | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

  <a href="https://trendshift.io/repositories/12784" target="_blank"><img src="https://trendshift.io/api/badge/repositories/12784" alt="codexu%2Fnote-gen | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a>
</div>

## Guia

NoteGen é um aplicativo de anotações em `Markdown` multiplataforma dedicado a usar IA para conectar gravação e escrita, organizando conhecimento fragmentado em uma nota legível.

🖥️ Documento oficial: [https://notegen.top](https://notegen.top)

💬 Participe do [Grupo WeChat/QQ](https://github.com/codexu/note-gen/discussions/110)

## Por que escolher o NoteGen?

- Leve: O [pacote de instalação](https://github.com/codexu/note-gen/releases) tem **apenas 20MB**, gratuito, sem anúncios ou softwares agregados.
- Multiplataforma: Suporta Mac, Windows, Linux e, graças às capacidades multiplataforma do `Tauri2`, suportará iOS e Android no futuro.
- Suporta múltiplos métodos de gravação, incluindo `capturas de tela`, `texto`, `ilustrações`, `arquivos`, `links`, etc., atendendo às necessidades de registro fragmentado em vários cenários.
- Armazenamento nativo em `Markdown(.md)`, sem modificações, fácil de migrar.
- Uso nativo offline, com suporte à sincronização em tempo real para `GitHub, repositórios privados do Gitee` com reversão de histórico, e sincronização via WebDAV.
- Aprimorado por IA: Configurável com ChatGPT, Gemini, Ollama, LM Studio, Grok e outros modelos, com suporte para configuração de modelos terceiros personalizados.
- RAG: Suas notas são sua base de conhecimento. Suporta modelos de embedding e modelos de reranking.

## Capturas de Tela

https://github.com/user-attachments/assets/4f8a3bc5-17f5-4b36-9b17-d87128685257

Gravação:

![1.png](https://s2.loli.net/2025/05/19/Cs5viKfkqb2HJmd.png)

Escrita:

![2.png](https://s2.loli.net/2025/05/19/5vwQBPoLr6jzgUA.png)

Tema:

![3.png](https://s2.loli.net/2025/05/19/8yU72prmWdsCHeu.png)

## Da Gravação à Escrita

Aplicativos convencionais de anotações normalmente não fornecem funcionalidade de gravação. Usuários precisam copiar e colar manualmente o conteúdo para registrar, o que reduz muito a eficiência. Ao lidar com conteúdo gravado disperso, é necessário muito esforço para organizar.

O NoteGen é dividido em páginas de `Gravação` e `Escrita`, com a seguinte relação:

- As gravações podem ser organizadas em notas e transferidas para a página de escrita para uma redação aprofundada.
- Durante a escrita, você pode inserir gravações a qualquer momento.

### Gravação

A função de gravação é semelhante a um **chatbot de IA**, mas ao conversar com ele, você pode associá-lo ao conteúdo previamente gravado, alternando do modo de conversa para o modo de organização para arranjar as gravações em uma nota legível.

Os seguintes recursos auxiliares podem ajudar você a gravar de forma mais eficaz:

- **Tags** para distinguir diferentes cenários de gravação.
- **Personas** com suporte para prompts personalizados para controlar precisamente seu assistente de IA.
- **Assistente de Área de Transferência** que reconhece automaticamente texto ou imagens na sua área de transferência e os grava na sua lista.

### Escrita

A seção de escrita é dividida em duas partes: **Gerenciador de Arquivos** e **Editor Markdown**.

**Gerenciador de Arquivos**

- Suporta gerenciamento de arquivos Markdown locais e arquivos sincronizados do GitHub.
- Suporta hierarquia ilimitada de diretórios.
- Suporta múltiplos métodos de ordenação.

**Editor Markdown**

- Suporta WYSIWYG, renderização instantânea e modos de visualização dividida.
- Suporta controle de versão com reversão de histórico.
- Suporta assistência de IA para conversa, continuação, refinamento e funções de tradução.
- Suporta hospedagem de imagens, upload de imagens e conversão para links de imagens em Markdown.
- Suporta conversão de HTML para Markdown, convertendo automaticamente conteúdo copiado do navegador para o formato Markdown.
- Suporta tópicos, fórmulas matemáticas, mapas mentais, gráficos, fluxogramas, gráficos de Gantt, diagramas de sequência, pautas, multimídia, leitura por voz, âncoras de título, realce e cópia de código, renderização graphviz e diagramas UML plantuml.
- Suporta salvamento local em tempo real, sincronização automática retardada (10s sem edição) e reversão de histórico.

## Outros Recursos

- Pesquisa global para encontrar e pular rapidamente para conteúdo específico.
- Gerenciamento de hospedagem de imagens para facilitar o gerenciamento do conteúdo do repositório de imagens.
- Temas e aparência com suporte para temas escuros e configurações de aparência para Markdown, código, etc.
- Suporte à internacionalização, atualmente disponível em chinês e inglês.

## Como usar?

### Download

Atualmente suporta Mac, Windows e Linux. Graças às capacidades multiplataforma do Tauri2, suportará iOS e Android no futuro.

[Baixar NoteGen (alpha)](https://github.com/codexu/note-gen/releases)

### Aprimoramento

O aplicativo de anotações pode ser usado diretamente sem configuração. Se você deseja uma experiência melhor, abra a página de configurações para configurar IA e sincronização.

## Contribua

- [Leia o guia de contribuição](https://raw.githubusercontent.com/codexu/note-gen/dev/.github/CONTRIBUTING.md)
- [Planos de atualização](https://github.com/codexu/note-gen/issues/46)
- [Reporte bugs ou sugestões de melhoria](https://github.com/codexu/note-gen/issues)
- [Discussões](https://github.com/codexu/note-gen/discussions)

## Contribuidores

<a href="https://github.com/codexu/note-gen/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=codexu/note-gen" />
</a>

## Histórico de Estrelas

[![Star History Chart](https://api.star-history.com/svg?repos=codexu/note-gen&type=Date)](https://www.star-history.com/#codexu/note-gen&Date)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---
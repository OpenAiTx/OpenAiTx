# c4 GenAI Suite

Um aplicativo de chatbot de IA com integração ao Model Context Provider (MCP), alimentado por Langchain e compatível com todos os principais Modelos de Linguagem de Grande Escala (LLMs) e Modelos de Embedding.

Administradores podem criar assistentes com diferentes capacidades adicionando extensões, como serviços RAG (Geração Aumentada por Recuperação) ou servidores MCP. O aplicativo é construído com uma stack tecnológica moderna, incluindo React, NestJS e Python FastAPI para o serviço REI-S.

Usuários podem interagir com assistentes por meio de uma interface amigável. Dependendo da configuração do assistente, os usuários podem fazer perguntas, enviar seus próprios arquivos ou usar outros recursos. Os assistentes interagem com diversos provedores de LLM para fornecer respostas baseadas nas extensões configuradas. Informações contextuais fornecidas pelas extensões configuradas permitem que os assistentes respondam a perguntas específicas de domínio e forneçam informações relevantes.

O aplicativo foi projetado para ser modular e extensível, permitindo que os usuários criem assistentes com diferentes capacidades ao adicionar extensões.

![vídeo curto de demonstração de uso básico](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/demo/preview.webp)

## Funcionalidades

### Modelos de Linguagem de Grande Escala (LLM) e Modelos Multimodais

O c4 GenAI Suite já suporta muitos modelos diretamente. E se o seu modelo preferido ainda não for suportado, deve ser fácil escrever uma extensão para suportá-lo.

* Modelos compatíveis com OpenAI
* Modelos Azure OpenAI
* Modelos Bedrock
* Modelos Google GenAI
* Modelos compatíveis com Ollama
### Geração Aumentada por Recuperação (RAG)

O c4 GenAI Suite inclui o REI-S, um servidor para preparar arquivos para consumo pelo LLM.

* REI-S, um servidor RAG integrado personalizado
  * Armazenamento vetorial
    * pgvector
    * Azure AI Search
  * Modelos de embedding
    * Embeddings compatíveis com OpenAI
    * Embeddings Azure OpenAI
    * Embeddings compatíveis com Ollama
  * Formatos de arquivo:
    * pdf, docx, pptx, xlsx, ...
    * transcrição de voz de arquivos de áudio (via Whisper)

### Extensões

O c4 GenAI Suite é projetado para ser extensível. Escrever extensões é fácil, assim como utilizar um servidor MCP já existente.

* Servidores Model Context Protocol (MCP)
* systemprompt personalizado
* Pesquisa Bing
* Calculadora
## Primeiros Passos

### Usando Docker-Compose

- Execute `docker compose up` na raiz do projeto.
- Abra o [aplicativo](http://localhost:3333) em um navegador. As credenciais padrão de login são usuário `admin@example.com` e senha `secret`.

![vídeo mostrando a configuração do assistente](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/demo/assistants.webp)

### Usando Helm & Kubernetes

Para implantação em ambientes Kubernetes, consulte o [README do nosso Helm Chart](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/./helm-chart/README.md).

### Configurando Assistentes e Extensões

O c4 GenAI Suite gira em torno de *assistentes*.
Cada assistente consiste em um conjunto de extensões, que determinam o modelo LLM e quais ferramentas ele pode usar.

- Na área de administração (clique no nome de usuário no canto inferior esquerdo), vá para a [seção de assistentes](http://localhost:3333/admin/assistants).
- Adicione um assistente com o botão verde `+` ao lado do título da seção. Escolha um nome e uma descrição.
- Selecione o assistente criado e clique no verde `+ Adicionar Extensão`.
- Selecione o modelo e preencha as credenciais.
- Use o botão `Testar` para verificar se está funcionando e clique em `salvar`.

Agora você pode retornar à [página de chat](http://localhost:3333/chat) (clique em `c4 GenAI Suite` no canto superior esquerdo) e iniciar uma nova conversa com seu novo assistente.

> [!DICA]
> Nosso `docker-compose` inclui um Ollama local, que roda na CPU. Você pode usar isso para testes rápidos. Mas será lento e provavelmente você vai querer usar outro modelo. Se quiser utilizá-lo, basta criar a seguinte extensão de modelo em seu Assistente.
> * Extensão: `Dev: Ollama`
> * Endpoint: `http://ollama:11434`
> * Modelo: `llama3.2`

### Protocolo de Contexto de Modelo (MCP) [opcional]

Utilize qualquer servidor MCP que ofereça uma interface `sse` com a extensão `MCP Tools` (ou use nosso `mcp-tool-as-server` como um proxy na frente de um servidor MCP `stdio`).
Cada servidor MCP pode ser configurado em detalhes como uma extensão.

### Geração Aumentada por Recuperação (RAG) / Busca em Arquivos [opcional]

Utilize nosso servidor RAG `REI-S` para pesquisar arquivos fornecidos pelo usuário. Basta configurar uma extensão `Search Files` para o assistente.
Esse processo é descrito em detalhes no [subdiretório `services/reis`](services/reis/#example-configuration-in-c4).

## Contribuindo & Desenvolvimento

* Veja [CONTRIBUTING.md](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/CONTRIBUTING.md) para orientações sobre como contribuir.
* Para integração de desenvolvedores, confira [DEVELOPERS.md](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/DEVELOPERS.md).

## Principais Blocos de Construção

A aplicação consiste em um **Frontend**, um **Backend** e um serviço **REI-S**.

```
┌──────────┐
│  Usuário │
└─────┬────┘
      │ acesso
      ▼
┌──────────┐
│ Frontend │
└─────┬────┘
      │ acesso
      ▼
┌──────────┐     ┌─────────────────┐
│ Backend  │────►│      LLM        │
└─────┬────┘     └─────────────────┘
      │ acesso
      ▼
┌──────────┐     ┌─────────────────┐
│  REI-S   │────►│ Modelo de Embedding │
│          │     └─────────────────┘
│          │
│          │     ┌─────────────────┐
│          │────►│  Armazenamento Vetorial │
└──────────┘     └─────────────────┘
```
### Frontend

O frontend é construído com React e TypeScript, proporcionando uma interface amigável para interagir com o backend e o serviço REI-S. Inclui funcionalidades para gerenciamento de assistentes, extensões e chats.

> Fontes: `/frontend`

### Backend

O backend é desenvolvido usando NestJS e TypeScript, servindo como a principal camada de API para a aplicação. Ele lida com as requisições do frontend e interage com provedores LLM para viabilizar funcionalidades de chat. O backend também gerencia assistentes e suas extensões, permitindo que os usuários configurem e utilizem diversos modelos de IA em seus chats.

Além disso, o backend gerencia a autenticação de usuários e se comunica com o serviço REI-S para indexação e recuperação de arquivos.

Para persistência de dados, o backend utiliza um banco de dados **PostgreSQL**.

> Fontes: `/backend`

### REI-S

O REI-S (**R**etrieval **E**xtraction **I**ngestion **S**erver) é um servidor baseado em Python que fornece capacidades básicas de RAG (Geração Aumentada por Recuperação). Ele permite a extração de conteúdo de arquivos, indexação e consulta, possibilitando que a aplicação manipule grandes conjuntos de dados de forma eficiente. O serviço REI-S foi projetado para funcionar perfeitamente com o backend, fornecendo os dados necessários para funcionalidades de chat e buscas de arquivos.

O REI-S suporta Azure AI Search e pgvector para armazenamento vetorial, permitindo opções flexíveis e escaláveis de recuperação de dados. O serviço pode ser configurado usando variáveis de ambiente para especificar o tipo de armazenamento vetorial e detalhes de conexão.

> Fontes: `/services/reis`


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---
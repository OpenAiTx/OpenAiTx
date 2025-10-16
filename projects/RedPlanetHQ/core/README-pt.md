<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
  <a href="https://core.heysol.ai">
    <img src="https://github.com/user-attachments/assets/89066cdd-204b-46c2-8ad4-4935f5ca9edd" width="200px" alt="CORE logo" />
  </a>

### CORE: Sua Camada de Memória Pessoal para Aplicativos de IA

<p align="center">
    <a href="https://deepwiki.com/RedPlanetHQ/core">
        <img src="https://deepwiki.com/badge.svg" alt="Selo DeepWiki" />
    </a>
</p>
<p align="center">
    <a href="https://docs.heysol.ai/introduction"><b>Documentação</b></a> •
    <a href="https://discord.gg/YGUZcvDjUa"><b>Discord</b></a>
</p>
</div>

## 🔥 Destaques da Pesquisa

A memória CORE alcança **88,24%** de acurácia média no conjunto de dados Locomo em todas as tarefas de raciocínio, superando significativamente outros provedores de memória. Confira este [blog](https://blog.heysol.ai/core-build-memory-knowledge-graph-for-individuals-and-achieved-sota-on-locomo-benchmark/) para mais informações.

<img width="6048" height="3428" alt="benchmark" src="https://github.com/user-attachments/assets/2e5fdac5-02ed-4d00-9312-c21d09974e1f" />
(1) Perguntas single-hop exigem respostas baseadas em uma única sessão; (2) Perguntas multi-hop exigem a síntese de informações de várias sessões diferentes; (3) Perguntas de conhecimento de domínio aberto podem ser respondidas integrando informações fornecidas pelo falante com conhecimento externo, como senso comum ou fatos mundiais; (4) Perguntas de raciocínio temporal podem ser respondidas através de raciocínio temporal e capturando sinais de dados relacionados ao tempo dentro da conversa;

## Visão Geral

**Problema**

Desenvolvedores perdem tempo reexplicando contexto para ferramentas de IA. Atingiu o limite de tokens no Claude? Comece do zero e perca tudo. Mudou do ChatGPT/Claude para o Cursor? Explique seu contexto novamente. Suas conversas, decisões e insights desaparecem entre as sessões. A cada nova ferramenta de IA, o custo da troca de contexto aumenta.

**Solução** - **CORE** (**Engine de Observação e Recuperação Contextual**)

CORE é uma camada de memória unificada, persistente e de código aberto para todas as suas ferramentas de IA. Seu contexto te acompanha do Cursor ao Claude, do ChatGPT ao Claude Code. Um grafo de conhecimento lembra quem disse o quê, quando e por quê. Conecte uma vez, lembre-se em todo lugar. Pare de gerenciar contexto e comece a construir.

## 🚀 Auto-hospedagem do CORE
Quer rodar o CORE na sua própria infraestrutura? A auto-hospedagem te dá controle total sobre seus dados e implantação.

**Pré-requisitos**:

- Docker (20.10.0+) e Docker Compose (2.20.0+) instalados
- Chave de API da OpenAI

> **Nota sobre modelos open-source:** Testamos opções OSS como Ollama e modelos GPT, mas sua extração de fatos e qualidade de grafo ficaram aquém. Estamos procurando ativamente por opções.

### Configuração

1. Clone o repositório:
```
git clone https://github.com/RedPlanetHQ/core.git
cd core
```
2. Configure as variáveis de ambiente em `core/.env`:
```
OPENAI_API_KEY=your_openai_api_key
```
3. Inicie o serviço
```
docker-compose up -d
```

Depois de implantado, você pode configurar seus provedores de IA (OpenAI, Anthropic) e começar a construir seu grafo de memória.

👉 [Veja o guia completo de auto-hospedagem](https://docs.heysol.ai/self-hosting/docker)

Nota: Testamos modelos open-source como Ollama ou GPT OSS, mas a geração de fatos não foi boa. Ainda estamos buscando melhorias e, então, também ofereceremos suporte a modelos OSS.

## 🚀 CORE Cloud
**Construa seu grafo de memória unificado em 5 minutos:**

Não quer gerenciar infraestrutura? O CORE Cloud permite criar seu sistema pessoal de memória instantaneamente - sem configuração, sem servidores, apenas memória que funciona.

1. **Cadastre-se** em [core.heysol.ai](https://core.heysol.ai) e crie sua conta
2. **Visualize seu grafo de memória** e veja como o CORE conecta fatos automaticamente
3. **Teste** - pergunte "O que você sabe sobre mim?" na seção de conversas
4. Conecte às suas ferramentas:
   - [Claude](https://docs.heysol.ai/providers/claude) & [Cursor](https://docs.heysol.ai/providers/cursor) - programação com contexto
   - [CLaude Code CLI](https://docs.heysol.ai/providers/claude-code) & [Codex CLI](https://docs.heysol.ai/providers/codex) - programação no terminal com memória
   - [Adicionar extensão de navegador](https://docs.heysol.ai/providers/browser-extension) - leve sua memória para qualquer site
   - [Linear](https://docs.heysol.ai/integrations/linear), [Github](https://docs.heysol.ai/integrations/github) - adicione contexto de projeto automaticamente

## 🧩 Principais Funcionalidades

### 🧠 **Memória Unificada e Portátil**: 
Adicione e recupere sua memória em **Cursor, Windsurf, Claude Desktop, Claude Code, Gemini CLI, Kiro da AWS, VS Code e Roo Code** via MCP

![core-claude](https://github.com/user-attachments/assets/56c98288-ee87-4cd0-8b02-860aca1c7f9a)


### 🕸️ **Grafo de Conhecimento Temporal + Reificado**: 

Lembre-se da história por trás de cada fato—acompanhe quem disse o quê, quando e por quê, com relacionamentos ricos e proveniência completa, não apenas armazenamento plano

![core-memory-graph](https://github.com/user-attachments/assets/5d1ee659-d519-4624-85d1-e0497cbdd60a)


### 🌐 **Extensão de Navegador**: 

Salve conversas e conteúdos do ChatGPT, Grok, Gemini, Twitter, YouTube, posts de blogs e qualquer página diretamente na sua memória CORE.

**Como Usar a Extensão**
1. [Baixe a Extensão](https://chromewebstore.google.com/detail/core-extension/cglndoindnhdbfcbijikibfjoholdjcc) na Chrome Web Store.
2. Faça login no [dashboard do CORE](https://core.heysol.ai)
   - Navegue até Configurações (canto inferior esquerdo)
   - Vá para Chave de API → Gerar nova chave → Nomeie como “extensão.”
3. Abra a extensão, cole sua chave de API e salve.

https://github.com/user-attachments/assets/6e629834-1b9d-4fe6-ae58-a9068986036a


### 💬 **Conversar com Memória**: 
Faça perguntas como "Quais são minhas preferências de escrita?" com insights instantâneos do seu conhecimento conectado

![chat-with-memory](https://github.com/user-attachments/assets/d798802f-bd51-4daf-b2b5-46de7d206f66)


### ⚡ **Sincronização Automática de Apps**:

Capture automaticamente contexto relevante do Linear, Slack, Notion, GitHub e outros apps conectados na sua memória CORE

📖 **[Ver Todas as Integrações](https://raw.githubusercontent.com/RedPlanetHQ/core/main/./integrations/README.md)** - Lista completa de serviços suportados e seus recursos

![core-slack](https://github.com/user-attachments/assets/d5fefe38-221e-4076-8a44-8ed673960f03)


### 🔗 **Hub de Integração MCP**: 

Conecte Linear, Slack, GitHub, Notion uma vez ao CORE—depois use todas as ferramentas deles no Claude, Cursor, ou qualquer cliente MCP com uma única URL


![core-linear-claude](https://github.com/user-attachments/assets/7d59d92b-8c56-4745-a7ab-9a3c0341aa32)



## Como o CORE cria memória

<img width="12885" height="3048" alt="memory-ingest-diagram" src="https://github.com/user-attachments/assets/c51679de-8260-4bee-bebf-aff32c6b8e13" />

O pipeline de ingestão do CORE possui quatro fases projetadas para capturar o contexto em evolução:

1. **Normalização**: Vincula novas informações ao contexto recente, divide documentos longos em blocos coerentes mantendo referências cruzadas e padroniza termos para que, quando o CORE extrair conhecimento, esteja trabalhando com uma entrada limpa e contextualizada em vez de texto confuso.
2. **Extração**: Extrai significado do texto normalizado identificando entidades (pessoas, ferramentas, projetos, conceitos), transformando-as em declarações com contexto, fonte e tempo, e mapeando relacionamentos. Por exemplo, “Nós escrevemos o CORE em Next.js” vira: Entidades (Core, Next.js), Declaração (CORE foi desenvolvido usando Next.js) e Relacionamento (foi desenvolvido usando).
3. **Resolução**: Detecta contradições, rastreia como preferências evoluem e preserva múltiplas perspectivas com proveniência em vez de sobrescrevê-las, para que a memória reflita toda a sua jornada, não apenas o último instantâneo.
4. **Integração ao Grafo**: Conecta entidades, declarações e episódios em um grafo temporal de conhecimento que vincula fatos ao seu contexto e histórico, transformando dados isolados em uma teia viva de conhecimento realmente utilizável por agentes.

O Resultado: Em vez de um banco de dados plano, o CORE oferece uma memória que cresce e muda com você – preservando contexto, evolução e autoria para que agentes possam realmente usá-la.


![memory-ingest-eg](https://github.com/user-attachments/assets/1d0a8007-153a-4842-9586-f6f4de43e647)

## Como o CORE recupera da memória

<img width="10610" height="3454" alt="memory-search-diagram" src="https://github.com/user-attachments/assets/3541893e-f7c9-42b9-8fad-6dabf138dbeb" />

Quando você faz uma pergunta ao CORE, ele não apenas busca texto – ele explora todo o seu grafo de conhecimento para encontrar as respostas mais úteis.

1. **Busca**: O CORE examina a memória de vários ângulos ao mesmo tempo – busca por palavra-chave para correspondências exatas, busca semântica para ideias relacionadas mesmo que formuladas diferente, e travessia de grafo para seguir links entre conceitos conectados.
2. **Reclassificação**: Os resultados obtidos são reordenados para destacar os mais relevantes e diversos, garantindo que você veja não só as correspondências óbvias, mas também conexões mais profundas.
3. **Filtragem**: O CORE aplica filtros inteligentes baseados em tempo, confiabilidade e força de relacionamento, para que só o conhecimento mais significativo seja exibido.
4. **Saída**: Você recebe tanto fatos (declarações claras) quanto episódios (o contexto original de onde vieram), então o resgate está sempre fundamentado em contexto, tempo e narrativa.

O resultado: O CORE não apenas recupera fatos – ele os recupera no contexto, tempo e narrativa corretos, para que agentes possam responder como você se lembraria.

## Documentação

Explore nossa documentação para aproveitar ao máximo o CORE

- [Conceitos Básicos](https://docs.heysol.ai/concepts/memory_graph)
- [Auto-hospedagem](https://docs.heysol.ai/self-hosting/overview)
- [Conecte Core MCP ao Claude](https://docs.heysol.ai/providers/claude)
- [Conecte Core MCP ao Cursor](https://docs.heysol.ai/providers/cursor)
- [Conecte Core MCP ao Claude Code](https://docs.heysol.ai/providers/claude-code)
- [Conecte Core MCP ao Codex](https://docs.heysol.ai/providers/codex) 

- [Conceitos Básicos](https://docs.heysol.ai/overview)
- [Referência da API](https://docs.heysol.ai/api-reference/get-user-profile)

## 🔒 Segurança

O CORE leva a segurança a sério. Implementamos práticas de segurança padrão da indústria para proteger seus dados:

- **Criptografia de Dados**: Todos os dados em trânsito (TLS 1.3) e em repouso (AES-256)
- **Autenticação**: OAuth 2.0 e autenticação por link mágico
- **Controle de Acesso**: Isolamento baseado em workspace e permissões baseadas em função
- **Relato de Vulnerabilidades**: Por favor, reporte problemas de segurança para harshith@poozle.dev

Para informações detalhadas de segurança, veja nossa [Política de Segurança](https://raw.githubusercontent.com/RedPlanetHQ/core/main/SECURITY.md).

## 🧑‍💻 Suporte

Tem perguntas ou sugestões? Estamos aqui para ajudar:

- Discord: [Entre no canal core-support](https://discord.gg/YGUZcvDjUa)
- Documentação: [docs.heysol.ai](https://docs.heysol.ai)
- E-mail: manik@poozle.dev

## Diretrizes de Uso

**Armazene:**

- Histórico de conversas
- Preferências do usuário
- Contexto de tarefas
- Materiais de referência

**Não Armazene:**

- Dados sensíveis (PII)
- Credenciais
- Logs do sistema
- Dados temporários

## 👥 Contribuidores

<a href="https://github.com/RedPlanetHQ/core/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=RedPlanetHQ/core" />
</a>















---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---
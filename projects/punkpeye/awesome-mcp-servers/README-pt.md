# Servidores MCP Incríveis [![Awesome](https://awesome.re/badge.svg)](https://awesome.re)

[![ไทย](https://img.shields.io/badge/Thai-Click-blue)](README-th.md)
[![English](https://img.shields.io/badge/English-Click-yellow)](README.md)
[![繁體中文](https://img.shields.io/badge/繁體中文-點擊查看-orange)](README-zh_TW.md)
[![简体中文](https://img.shields.io/badge/简体中文-点击查看-orange)](README-zh.md)
[![日本語](https://img.shields.io/badge/日本語-クリック-青)](README-ja.md)
[![한국어](https://img.shields.io/badge/한국어-클릭-yellow)](README-ko.md)
[![Português Brasileiro](https://img.shields.io/badge/Português_Brasileiro-Clique-green)](README-pt_BR.md)
[![Discord](https://img.shields.io/discord/1312302100125843476?logo=discord&label=discord)](https://glama.ai/mcp/discord)
[![Subreddit subscribers](https://img.shields.io/reddit/subreddit-subscribers/mcp?style=flat&logo=reddit&label=subreddit)](https://www.reddit.com/r/mcp/)

Uma lista curada de servidores incríveis do Model Context Protocol (MCP).

* [O que é MCP?](#o-que-e-mcp)
* [Clientes](#clientes)
* [Tutoriais](#tutoriais)
* [Comunidade](#comunidade)
* [Legenda](#legenda)
* [Implementações de Servidor](#implementacoes-de-servidor)
* [Frameworks](#frameworks)
* [Dicas & Truques](#dicas-e-truques)

## O que é MCP?

[MCP](https://modelcontextprotocol.io/) é um protocolo aberto que permite que modelos de IA interajam de forma segura com recursos locais e remotos através de implementações de servidor padronizadas. Esta lista foca em servidores MCP prontos para produção e experimentais que ampliam as capacidades de IA por meio de acesso a arquivos, conexões com bancos de dados, integrações de API e outros serviços contextuais.

## Clientes

Confira [awesome-mcp-clients](https://github.com/punkpeye/awesome-mcp-clients/) e [glama.ai/mcp/clients](https://glama.ai/mcp/clients).

> [!TIP]
> [Glama Chat](https://glama.ai/chat) é um cliente de IA multimodal com suporte a MCP e [gateway de IA](https://glama.ai/gateway).

## Tutoriais

* [Model Context Protocol (MCP) Guia Rápido](https://glama.ai/blog/2024-11-25-model-context-protocol-quickstart)
* [Configurar o aplicativo Claude Desktop para usar um banco de dados SQLite](https://youtu.be/wxCCzo9dGj0)

## Comunidade

* [r/mcp Reddit](https://www.reddit.com/r/mcp)
* [Servidor Discord](https://glama.ai/mcp/discord)

## Legenda

* 🎖️ – implementação oficial
* linguagem de programação
  * 🐍 – Código base em Python
  * 📇 – Código base em TypeScript (ou JavaScript)
  * 🏎️ – Código base em Go
  * 🦀 – Código base em Rust
  * #️⃣ - Código base em C#
  * ☕ - Código base em Java
  * 🌊 – Código base em C/C++
* escopo
  * ☁️ - Serviço em Nuvem
  * 🏠 - Serviço Local
  * 📟 - Sistemas Embarcados
* sistema operacional
  * 🍎 – Para macOS
  * 🪟 – Para Windows
  * 🐧 - Para Linux

> [!NOTE]
> Está confuso sobre Local 🏠 vs Nuvem ☁️?
> * Use local quando o servidor MCP estiver falando com um software instalado localmente, por exemplo, controlando o navegador Chrome.
> * Use rede quando o servidor MCP estiver falando com APIs remotas, por exemplo, API de clima.

## Implementações de Servidor

> [!NOTE]
> Agora temos um [diretório baseado na web](https://glama.ai/mcp/servers) que está sincronizado com o repositório.

* 🔗 - [Agregadores](#agregadores)
* 🎨 - [Arte & Cultura](#arte-e-cultura)
* 📂 - [Automação de Navegador](#automacao-de-navegador)
* ☁️ - [Plataformas em Nuvem](#plataformas-em-nuvem)
* 👨‍💻 - [Execução de Código](#execucao-de-codigo)
* 🤖 - [Agentes de Programação](#agentes-de-programacao)
* 🖥️ - [Linha de Comando](#linha-de-comando)
* 💬 - [Comunicação](#comunicacao)
* 👤 - [Plataformas de Dados de Clientes](#plataformas-de-dados-de-clientes)
* 🗄️ - [Bancos de Dados](#bancos-de-dados)
* 📊 - [Plataformas de Dados](#plataformas-de-dados)
* 🚚 - [Entrega](#entrega)
* 🛠️ - [Ferramentas de Desenvolvimento](#ferramentas-de-desenvolvimento)
* 🧮 - [Ferramentas de Ciência de Dados](#ferramentas-de-ciencia-de-dados)
* 📟 - [Sistema Embarcado](#sistema-embarcado)
* 📂 - [Sistemas de Arquivos](#sistemas-de-arquivos)
* 💰 - [Finanças & Fintech](#financas--fintech)
* 🎮 - [Jogos](#jogos)
* 🧠 - [Conhecimento & Memória](#conhecimento--memoria)
* 🗺️ - [Serviços de Localização](#servicos-de-localizacao)
* 🎯 - [Marketing](#marketing)
* 📊 - [Monitoramento](#monitoramento)
* 🎥 - [Processamento Multimídia](#processamento-multimidia)
* 🔎 - [Busca & Extração de Dados](#busca)
* 🔒 - [Segurança](#seguranca)
* 🌐 - [Mídias Sociais](#midias-sociais)
* 🏃 - [Esportes](#sports)
* 🎧 - [Suporte & Gerenciamento de Serviços](#support-and-service-management)
* 🌎 - [Serviços de Tradução](#translation-services)
* 🎧 - [Texto para Fala](#text-to-speech)
* 🚆 - [Viagem & Transporte](#travel-and-transportation)
* 🔄 - [Controle de Versão](#version-control)
* 🛠️ - [Outras Ferramentas e Integrações](#other-tools-and-integrations)


### 🔗 <a name="aggregators"></a>Agregadores

Servidores para acessar muitos aplicativos e ferramentas através de um único servidor MCP.

- [julien040/anyquery](https://github.com/julien040/anyquery) 🏎️ 🏠 ☁️ - Consulte mais de 40 aplicativos com um binário usando SQL. Também pode conectar ao seu banco de dados compatível com PostgreSQL, MySQL ou SQLite. Local-first e privado por padrão.
- [metatool-ai/metatool-app](https://github.com/metatool-ai/metatool-app) 📇 ☁️ 🏠 🍎 🪟 🐧 - MetaMCP é o middleware unificado que gerencia suas conexões MCP com interface gráfica.
- [mindsdb/mindsdb](https://github.com/mindsdb/mindsdb) - Conecte e unifique dados em várias plataformas e bancos de dados com o [MindsDB como um único servidor MCP](https://docs.mindsdb.com/mcp/overview).
- [glenngillen/mcpmcp-server](https://github.com/glenngillen/mcpmcp-server) ☁️ 📇 🍎 🪟 🐧 - Uma lista de servidores MCP para que você possa perguntar ao seu cliente quais servidores usar para melhorar seu fluxo de trabalho diário.
- [wegotdocs/open-mcp](https://github.com/wegotdocs/open-mcp) 📇 🏠 🍎 🪟 🐧 - Transforme uma API web em um servidor MCP em 10 segundos e adicione ao registro open source: https://open-mcp.org
- [PipedreamHQ/pipedream](https://github.com/PipedreamHQ/pipedream/tree/master/modelcontextprotocol) ☁️ 🏠 - Conecte-se a 2.500 APIs com mais de 8.000 ferramentas pré-construídas, e gerencie servidores para seus usuários, no seu próprio aplicativo.
- [VeriTeknik/pluggedin-mcp-proxy](https://github.com/VeriTeknik/pluggedin-mcp-proxy)  📇 🏠 - Proxy server abrangente que combina múltiplos servidores MCP em uma única interface com recursos avançados de visibilidade. Fornece descoberta e gerenciamento de ferramentas, prompts, recursos e templates entre servidores, além de um playground para depuração ao criar servidores MCP.
- [tigranbs/mcgravity](https://github.com/tigranbs/mcgravity) 📇 🏠 - Ferramenta proxy para compor múltiplos servidores MCP em um único endpoint unificado. Escale suas ferramentas de IA balanceando as requisições entre múltiplos servidores MCP, similar ao funcionamento do Nginx para servidores web.
- [MetaMCP](https://github.com/metatool-ai/metatool-app) 📇 ☁️ 🏠 🍎 🪟 🐧 - MetaMCP é o middleware unificado que gerencia suas conexões MCP com interface gráfica.
- [WayStation-ai/mcp](https://github.com/waystation-ai/mcp) ☁️ 🍎 🪟 - Conecte rapidamente e com segurança o Claude Desktop e outros hosts MCP aos seus apps favoritos (Notion, Slack, Monday, Airtable, etc.). Leva menos de 90 segundos.
- [sxhxliang/mcp-access-point](https://github.com/sxhxliang/mcp-access-point) 📇 ☁️ 🏠 🍎 🪟 🐧 - Transforme um serviço web em servidor MCP com um clique, sem alterar código.
- [hamflx/imagen3-mcp](https://github.com/hamflx/imagen3-mcp) 📇 🏠 🪟 🍎 🐧 - Ferramenta poderosa de geração de imagens usando a API Imagen 3.0 do Google via MCP. Gere imagens de alta qualidade a partir de prompts de texto com controles avançados de fotografia, arte e fotorrealismo.
- [SureScaleAI/openai-gpt-image-mcp](https://github.com/SureScaleAI/openai-gpt-image-mcp) 📇 ☁️ - Servidor MCP para geração/edição de imagens com OpenAI GPT.

### 🎨 <a name="art-and-culture"></a>Arte & Cultura

Acesse e explore coleções de arte, patrimônio cultural e bancos de dados de museus. Permite que modelos de IA pesquisem e analisem conteúdos artísticos e culturais.

- [abhiemj/manim-mcp-server](https://github.com/abhiemj/manim-mcp-server) 🐍 🏠 🪟 🐧 - Servidor MCP local que gera animações usando Manim.
- [burningion/video-editing-mcp](https://github.com/burningion/video-editing-mcp) 🐍 - Adicione, Analise, Pesquise e Gere Edições de Vídeo da sua Coleção Video Jungle
- [cswkim/discogs-mcp-server](https://github.com/cswkim/discogs-mcp-server) 📇 ☁️ - Servidor MCP para interação com a API Discogs
- [djalal/quran-mcp-server](https://github.com/djalal/quran-mcp-server) 📇 ☁️ Servidor MCP para interação com o corpus do Quran.com via API REST oficial v4.
- [mikechao/metmuseum-mcp](https://github.com/mikechao/metmuseum-mcp) 📇 ☁️ - Integração com API da Coleção do Metropolitan Museum of Art para pesquisar e exibir obras de arte da coleção.
- [r-huijts/rijksmuseum-mcp](https://github.com/r-huijts/rijksmuseum-mcp) 📇 ☁️ - Integração com API do Rijksmuseum para busca de obras, detalhes e coleções
- [r-huijts/oorlogsbronnen-mcp](https://github.com/r-huijts/oorlogsbronnen-mcp) 📇 ☁️ - Integração com API do Oorlogsbronnen (Fontes da Guerra) para acesso a registros históricos da Segunda Guerra Mundial, fotografias e documentos dos Países Baixos (1940-1945)
- [samuelgursky/davinci-resolve-mcp](https://github.com/samuelgursky/davinci-resolve-mcp) 🐍 - Integração servidor MCP para DaVinci Resolve fornecendo ferramentas avançadas para edição de vídeo, correção de cor, gerenciamento de mídia e controle de projetos
- [yuna0x0/anilist-mcp](https://github.com/yuna0x0/anilist-mcp) 📇 ☁️ - Servidor MCP integrando a API AniList para informações de anime e mangá
- [diivi/aseprite-mcp](https://github.com/diivi/aseprite-mcp) 🐍 🏠 - Servidor MCP usando a API do Aseprite para criar pixel art
- [omni-mcp/isaac-sim-mcp](https://github.com/omni-mcp/isaac-sim-mcp) 📇 ☁️ - Servidor MCP e extensão que permite controle por linguagem natural do NVIDIA Isaac Sim, Lab, OpenUSD etc.
- [8enSmith/mcp-open-library](https://github.com/8enSmith/mcp-open-library) 📇 ☁️ - Servidor MCP para a API Open Library que permite a assistentes de IA pesquisarem informações de livros. 
- [PatrickPalmer/MayaMCP](https://github.com/PatrickPalmer/MayaMCP) 🐍 🏠 - Servidor MCP para Autodesk Maya
- [cantian-ai/bazi-mcp](https://github.com/cantian-ai/bazi-mcp) 📇 🏠 ☁️ 🍎 🪟 - Oferece análise e geração de mapas Bazi (Astrologia Chinesa) abrangentes e precisos


### 📂 <a name="browser-automation"></a>Automação de Navegador

Acesso a conteúdo web e automação. Permite pesquisar, extrair e processar conteúdo web em formatos compatíveis com IA.

- [xspadex/bilibili-mcp](https://github.com/xspadex/bilibili-mcp.git) 📇 🏠 - Ferramenta baseada em FastMCP que busca vídeos em alta do Bilibili e os expõe via interface padrão MCP.
- [34892002/bilibili-mcp-js](https://github.com/34892002/bilibili-mcp-js) 📇 🏠 - Servidor MCP que suporta busca de conteúdo do Bilibili. Fornece exemplos de integração com LangChain e scripts de teste.
- [aircodelabs/grasp](https://github.com/aircodelabs/grasp) 📇 🏠 - Navegador auto-hospedado usando agente com MCP embutido e suporte A2A.
- [automatalabs/mcp-server-playwright](https://github.com/Automata-Labs-team/MCP-Server-Playwright) 🐍 - Servidor MCP para automação de navegador usando Playwright
- [blackwhite084/playwright-plus-python-mcp](https://github.com/blackwhite084/playwright-plus-python-mcp) 🐍 - Servidor MCP em Python usando Playwright para automação de navegador, mais adequado para LLM
- [browserbase/mcp-server-browserbase](https://github.com/browserbase/mcp-server-browserbase) 🎖️ 📇 - Automatize interações com navegador na nuvem (ex: navegação web, extração de dados, preenchimento de formulários, etc)
- [browsermcp/mcp](https://github.com/browsermcp/mcp) 📇 🏠 - Automatize seu navegador Chrome local
- [co-browser/browser-use-mcp-server](https://github.com/co-browser/browser-use-mcp-server) 🐍 - browser-use empacotado como servidor MCP com transporte SSE. Inclui Dockerfile para rodar Chromium em docker + servidor vnc.
- [executeautomation/playwright-mcp-server](https://github.com/executeautomation/mcp-playwright) 📇 - Servidor MCP usando Playwright para automação e raspagem web
- [eyalzh/browser-control-mcp](https://github.com/eyalzh/browser-control-mcp) 📇 🏠 - Servidor MCP emparelhado com extensão de navegador que permite ao cliente LLM controlar o navegador do usuário (Firefox).
- [fradser/mcp-server-apple-reminders](https://github.com/FradSer/mcp-server-apple-reminders) 📇 🏠 🍎 - Servidor MCP para interação com Lembretes da Apple no macOS
- [getrupt/ashra-mcp](https://github.com/getrupt/ashra-mcp) 🐍 🏠 - Extraia dados estruturados de qualquer site. Basta promptar e receber JSON.
- [kimtaeyoon83/mcp-server-youtube-transcript](https://github.com/kimtaeyoon83/mcp-server-youtube-transcript) 📇 ☁️ - Busca legendas e transcrições do YouTube para análise por IA
- [kimtth/mcp-aoai-web-browsing](https://github.com/kimtth/mcp-aoai-web-browsing) 🐍 🏠 - Implementação mínima de servidor/cliente MCP usando Azure OpenAI e Playwright.
- [microsoft/playwright-mcp](https://github.com/microsoft/playwright-mcp) - Servidor MCP oficial da Microsoft Playwright, permitindo que LLMs interajam com páginas web através de snapshots estruturados de acessibilidade
- [modelcontextprotocol/server-puppeteer](https://github.com/modelcontextprotocol/servers/tree/main/src/puppeteer) 📇 🏠 - Automação de navegador para raspagem e interação web
- [ndthanhdev/mcp-browser-kit](https://github.com/ndthanhdev/mcp-browser-kit) 📇 🏠 - Servidor MCP para interação com navegadores compatíveis com manifest v2.
- [pskill9/web-search](https://github.com/pskill9/web-search) 📇 🏠 - Servidor MCP que permite busca gratuita na web usando resultados do Google, sem necessidade de chaves de API.
- [recursechat/mcp-server-apple-shortcuts](https://github.com/recursechat/mcp-server-apple-shortcuts) 📇 🏠 🍎 - Integração de servidor MCP com Atalhos da Apple

### ☁️ <a name="cloud-platforms"></a>Plataformas em Nuvem

Integração de serviços de plataformas em nuvem. Permite o gerenciamento e interação com infraestrutura e serviços de nuvem.

- [awslabs/mcp](https://github.com/awslabs/mcp) 🎖️ ☁️ - Servidores MCP da AWS para integração perfeita com serviços e recursos AWS.
- [qiniu/qiniu-mcp-server](https://github.com/qiniu/qiniu-mcp-server) 🐍 ☁️ - MCP baseado nos produtos da Qiniu Cloud, com suporte a acesso ao armazenamento Qiniu Cloud, serviços de processamento de mídia, etc.
- [alexbakers/mcp-ipfs](https://github.com/alexbakers/mcp-ipfs) 📇 ☁️ - Upload e manipulação de armazenamento IPFS
- [reza-gholizade/k8s-mcp-server](https://github.com/reza-gholizade/k8s-mcp-server) 🏎️ ☁️/🏠 - Servidor Kubernetes Model Context Protocol (MCP) que fornece ferramentas para interagir com clusters Kubernetes via interface padronizada, incluindo descoberta de recursos de API, gerenciamento de recursos, logs de pods, métricas e eventos.
- [VmLia/books-mcp-server](https://github.com/VmLia/books-mcp-server) 📇 ☁️ - Servidor MCP para consulta de livros, podendo ser usado em clientes MCP comuns, como Cherry Studio.
- [alexei-led/aws-mcp-server](https://github.com/alexei-led/aws-mcp-server) 🐍 ☁️ - Servidor leve e poderoso que permite a assistentes de IA executarem comandos AWS CLI, usar pipes Unix, e aplicar templates de prompt para tarefas AWS comuns em ambiente Docker seguro com suporte multi-arquitetura.
- [alexei-led/k8s-mcp-server](https://github.com/alexei-led/k8s-mcp-server) 🐍 - Servidor leve e robusto que permite a assistentes de IA executarem comandos CLI do Kubernetes (`kubectl`, `helm`, `istioctl` e `argocd`) usando pipes Unix em ambiente Docker seguro com suporte multi-arquitetura.
- [aliyun/alibaba-cloud-ops-mcp-server](https://github.com/aliyun/alibaba-cloud-ops-mcp-server) 🎖️ 🐍 ☁️ - Servidor MCP que permite a assistentes de IA operar recursos na Alibaba Cloud, com suporte a ECS, Cloud Monitor, OOS e produtos amplamente usados na nuvem.  
- [bright8192/esxi-mcp-server](https://github.com/bright8192/esxi-mcp-server) 🐍 ☁️ - Servidor de gerenciamento VMware ESXi/vCenter baseado em MCP (Model Control Protocol), fornecendo APIs REST simples para gerenciamento de máquinas virtuais.
- [cloudflare/mcp-server-cloudflare](https://github.com/cloudflare/mcp-server-cloudflare) 🎖️ 📇 ☁️ - Integração com serviços Cloudflare, incluindo Workers, KV, R2 e D1
- [cyclops-ui/mcp-cyclops](https://github.com/cyclops-ui/mcp-cyclops) 🎖️ 🏎️ ☁️ - Servidor MCP que permite a agentes de IA gerenciar recursos Kubernetes via abstração Cyclops
- [jedisct1/fastly-mcp-server](https://github.com/jedisct1/fastly-openapi-schema) 🎖️ 📇 ☁️ - Integração com serviços Fastly
- [flux159/mcp-server-kubernetes](https://github.com/Flux159/mcp-server-kubernetes) 📇 ☁️/🏠 - Implementação Typescript de operações de cluster Kubernetes para pods, deployments, serviços.
- [hardik-id/azure-resource-graph-mcp-server](https://github.com/hardik-id/azure-resource-graph-mcp-server) 📇 ☁️/🏠 - Servidor Model Context Protocol para consulta e análise de recursos Azure em escala usando Azure Resource Graph, permitindo que assistentes de IA explorem e monitorem infraestrutura Azure.
- [jdubois/azure-cli-mcp](https://github.com/jdubois/azure-cli-mcp) - Wrapper para a linha de comando Azure CLI permitindo interação direta com Azure
- [johnneerdael/netskope-mcp](https://github.com/johnneerdael/netskope-mcp) 🔒 ☁️ - MCP para acesso a todos os componentes Netskope Private Access em ambientes Netskope Private Access, incluindo informações detalhadas de configuração e exemplos de uso com LLM.
- [manusa/Kubernetes MCP Server](https://github.com/manusa/kubernetes-mcp-server) 🏎️ 🏠 - Servidor Kubernetes MCP poderoso com suporte adicional a OpenShift. Além das operações CRUD para **qualquer** recurso Kubernetes, fornece ferramentas especializadas para interagir com seu cluster.
- [nwiizo/tfmcp](https://github.com/nwiizo/tfmcp) 🦀 🏠 - Servidor MCP para Terraform permitindo que assistentes de IA gerenciem ambientes Terraform, lendo configurações, analisando planos, aplicando configurações e gerenciando state do Terraform.
- [pulumi/mcp-server](https://github.com/pulumi/mcp-server) 🎖️ 📇 🏠 - Servidor MCP para interação com Pulumi usando as APIs Automation e Cloud do Pulumi. Permite a clientes MCP realizar operações como buscar informações de pacotes, visualizar mudanças, implantar atualizações e recuperar outputs de stacks programaticamente.
- [rohitg00/kubectl-mcp-server](https://github.com/rohitg00/kubectl-mcp-server) 🐍 ☁️/🏠 - Servidor Model Context Protocol (MCP) para Kubernetes permitindo que assistentes de IA como Claude, Cursor e outros interajam com clusters Kubernetes via linguagem natural.
- [strowk/mcp-k8s-go](https://github.com/strowk/mcp-k8s-go) 🏎️ ☁️/🏠 - Operações de cluster Kubernetes via MCP
- [thunderboltsid/mcp-nutanix](https://github.com/thunderboltsid/mcp-nutanix) 🏎️ 🏠/☁️ - Servidor MCP em Go para interface com recursos Nutanix Prism Central.
- [trilogy-group/aws-pricing-mcp](https://github.com/trilogy-group/aws-pricing-mcp) 🏎️ ☁️/🏠 - Obtenha informações atualizadas de preços EC2 com uma chamada. Rápido. Alimentado por catálogo de preços AWS pré-analisado.
- [weibaohui/k8m](https://github.com/weibaohui/k8m) 🏎️ ☁️/🏠 - Proporciona gerenciamento e operações MCP multi-cluster Kubernetes, com interface de gerenciamento, logs e quase 50 ferramentas integradas cobrindo cenários comuns de DevOps e desenvolvimento. Suporta recursos padrão e CRD.
- [weibaohui/kom](https://github.com/weibaohui/kom) 🏎️ ☁️/🏠 - Proporciona gerenciamento e operações MCP multi-cluster Kubernetes. Pode ser integrado como SDK em seu próprio projeto e inclui quase 50 ferramentas integradas para cenários comuns de DevOps e desenvolvimento. Suporta recursos padrão e CRD.
- [wenhuwang/mcp-k8s-eye](https://github.com/wenhuwang/mcp-k8s-eye) 🏎️ ☁️/🏠 - Servidor MCP para gerenciamento do Kubernetes e análise da saúde do seu cluster e aplicações.
- [erikhoward/adls-mcp-server](https://github.com/erikhoward/adls-mcp-server) 🐍 ☁️/🏠 - Servidor MCP para Azure Data Lake Storage. Permite gerenciar containers, realizar operações de leitura/gravação/upload/download em arquivos de container e gerenciar metadados de arquivos.
- [silenceper/mcp-k8s](https://github.com/silenceper/mcp-k8s) 🏎️ ☁️/🏠 - MCP-K8S é uma ferramenta de gerenciamento de recursos Kubernetes impulsionada por IA que permite aos usuários operar quaisquer recursos em clusters Kubernetes por meio de interação em linguagem natural, incluindo recursos nativos (como Deployment, Service) e recursos customizados (CRD). Não é necessário memorizar comandos complexos – basta descrever suas necessidades e a IA executará com precisão as operações correspondentes no cluster, aumentando significativamente a usabilidade do Kubernetes.
- [redis/mcp-redis-cloud](https://github.com/redis/mcp-redis-cloud) 📇 ☁️ - Gerencie seus recursos do Redis Cloud facilmente usando linguagem natural. Crie bancos de dados, monitore assinaturas e configure implantações na nuvem com comandos simples.
- [portainer/portainer-mcp](https://github.com/portainer/portainer-mcp) 🏎️ ☁️/🏠 - Um servidor MCP poderoso que permite que assistentes de IA interajam perfeitamente com instâncias Portainer, fornecendo acesso em linguagem natural ao gerenciamento de containers, operações de implantação e recursos de monitoramento de infraestrutura.

### 👨‍💻 <a name="code-execution"></a>Execução de Código

Servidores de execução de código. Permitem que LLMs executem código em um ambiente seguro, por exemplo, para agentes de programação.

- [pydantic/pydantic-ai/mcp-run-python](https://github.com/pydantic/pydantic-ai/tree/main/mcp-run-python) 🐍 🏠- Execute código Python em um sandbox seguro via chamadas de ferramentas MCP
- [yepcode/mcp-server-js](https://github.com/yepcode/mcp-server-js) 🎖️ 📇 ☁️ - Execute qualquer código gerado por LLM em um ambiente sandbox seguro e escalável e crie suas próprias ferramentas MCP usando JavaScript ou Python, com suporte total para pacotes NPM e PyPI
- [ckanthony/openapi-mcp](https://github.com/ckanthony/openapi-mcp) 🏎️ ☁️ - OpenAPI-MCP: Servidor MCP dockerizado que permite ao seu agente de IA acessar qualquer API com documentação já existente.
- [alfonsograziano/node-code-sandbox-mcp](https://github.com/alfonsograziano/node-code-sandbox-mcp) 📇 🏠 – Um servidor MCP Node.js que cria sandboxes isolados baseados em Docker para execução de trechos de JavaScript com instalação de dependências npm em tempo real e encerramento limpo
- [r33drichards/mcp-js](https://github.com/r33drichards/mcp-js) 🦀 🏠 🐧 🍎 - Um sandbox de execução de código Javascript que usa v8 para isolar o código e rodar javascript gerado por IA localmente sem riscos. Suporta snapshot de heap para sessões persistentes.

### 🤖 <a name="coding-agents"></a>Agentes de Programação

Agentes de programação completos que permitem que LLMs leiam, editem e executem código e resolvam tarefas gerais de programação de forma totalmente autônoma.

- [oraios/serena](https://github.com/oraios/serena)🐍🏠 - Um agente de programação completo que utiliza operações simbólicas de código usando servidores de linguagem.
- [ezyang/codemcp](https://github.com/ezyang/codemcp) 🐍🏠 - Agente de programação com ferramentas básicas de leitura, escrita e linha de comando.
- [doggybee/mcp-server-leetcode](https://github.com/doggybee/mcp-server-leetcode) 📇 ☁️ - Um servidor MCP que permite a modelos de IA pesquisar, recuperar e resolver problemas do LeetCode. Suporta filtragem de metadados, perfis de usuário, submissões e acesso a dados de competições.
- [jinzcdev/leetcode-mcp-server](https://github.com/jinzcdev/leetcode-mcp-server) 📇 ☁️ - Servidor MCP que permite acesso automatizado aos problemas de programação, soluções, submissões e dados públicos do **LeetCode**, com autenticação opcional para recursos específicos do usuário (ex.: notas), suportando os sites `leetcode.com` (global) e `leetcode.cn` (China).
- [juehang/vscode-mcp-server](https://github.com/juehang/vscode-mcp-server) 📇 🏠 - Um servidor MCP que permite que IAs como o Claude leiam a estrutura de diretórios em um workspace do VS Code, vejam problemas identificados por linter(s) e pelo servidor de linguagem, leiam arquivos de código e façam edições.
- [micl2e2/code-to-tree](https://github.com/micl2e2/code-to-tree) 🌊 🏠 📟 🐧 🪟 🍎 - Um servidor MCP em binário único que converte código-fonte em AST, independente da linguagem.

### 🖥️ <a name="command-line"></a>Linha de Comando

Execute comandos, capture saídas e interaja com shells e ferramentas de linha de comando.

- [ferrislucas/iterm-mcp](https://github.com/ferrislucas/iterm-mcp) 🖥️ 🛠️ 💬 - Um servidor Model Context Protocol que fornece acesso ao iTerm. Você pode executar comandos e fazer perguntas sobre o que aparece no terminal iTerm.
- [g0t4/mcp-server-commands](https://github.com/g0t4/mcp-server-commands) 📇 🏠 - Execute qualquer comando com as ferramentas `run_command` e `run_script`.
- [maxim-saplin/mcp_safe_local_python_executor](https://github.com/maxim-saplin/mcp_safe_local_python_executor) - Interpretador Python seguro baseado no HF Smolagents `LocalPythonExecutor`
- [MladenSU/cli-mcp-server](https://github.com/MladenSU/cli-mcp-server) 🐍 🏠 - Interface de linha de comando com execução segura e políticas de segurança personalizáveis
- [OthmaneBlial/term_mcp_deepseek](https://github.com/OthmaneBlial/term_mcp_deepseek) 🐍 🏠 - Um servidor DeepSeek semelhante ao MCP para Terminal
- [tumf/mcp-shell-server](https://github.com/tumf/mcp-shell-server) - Servidor seguro de execução de comandos shell implementando o Model Context Protocol (MCP)
- [automateyournetwork/pyATS_MCP](https://github.com/automateyournetwork/pyATS_MCP) - Servidor Cisco pyATS que permite interação estruturada e orientada a modelos com dispositivos de rede.
- [wonderwhy-er/DesktopCommanderMCP](https://github.com/wonderwhy-er/DesktopCommanderMCP) 📇 🏠 🍎 🪟 🐧 - Uma ferramenta multifuncional capaz de gerenciar/executar programas e ler/escrever/pesquisar/editar arquivos de código e texto.
- [tufantunc/ssh-mcp](https://github.com/tufantunc/ssh-mcp) 📇 🏠 🐧 🪟 - Servidor MCP que expõe controle SSH para servidores Linux e Windows via Model Context Protocol. Execute comandos shell remotos com autenticação por senha ou chave SSH de forma segura.

### 💬 <a name="communication"></a>Comunicação

Integração com plataformas de comunicação para gerenciamento de mensagens e operações de canais. Permite que modelos de IA interajam com ferramentas de comunicação em equipe.

- [AbdelStark/nostr-mcp](https://github.com/AbdelStark/nostr-mcp) ☁️ - Um servidor MCP Nostr que permite interagir com o Nostr, possibilitando publicar notas e mais.
- [adhikasp/mcp-twikit](https://github.com/adhikasp/mcp-twikit) 🐍 ☁️ - Interaja com buscas e timeline do Twitter
- [agentmail-toolkit/mcp](https://github.com/agentmail-to/agentmail-toolkit/tree/main/mcp) 🐍 💬 - Um servidor MCP para criar caixas de entrada instantaneamente para enviar, receber e tomar ações em e-mails. Não somos agentes de IA para e-mail, mas e-mail para Agentes de IA.
- [arpitbatra123/mcp-googletasks](https://github.com/arpitbatra123/mcp-googletasks) 📇 ☁️ - Um servidor MCP para interface com a API do Google Tasks
- [carterlasalle/mac_messages_mcp](https://github.com/carterlasalle/mac_messages_mcp) 🏠 🍎 🚀 - Um servidor MCP que se conecta com segurança ao seu banco de dados do iMessage via Model Context Protocol (MCP), permitindo que LLMs consultem e analisem conversas do iMessage. Inclui validação robusta de número de telefone, processamento de anexos, gerenciamento de contatos, manipulação de grupos e suporte completo para envio e recebimento de mensagens.
- [chaindead/telegram-mcp](https://github.com/chaindead/telegram-mcp) 🏎️ 🏠 - Integração com a API do Telegram para acessar dados do usuário, gerenciar diálogos (chats, canais, grupos), recuperar mensagens e manipular status de leitura
- [chigwell/telegram-mcp](https://github.com/chigwell/telegram-mcp) 🐍 🏠 - Integração com a API do Telegram para acessar dados do usuário, gerenciar diálogos (chats, canais, grupos), recuperar e enviar mensagens e manipular status de leitura.
- [elie222/inbox-zero](https://github.com/elie222/inbox-zero/tree/main/apps/mcp-server) 🐍 ☁️ - Um servidor MCP para Inbox Zero. Adiciona funcionalidades ao Gmail, como descobrir quais e-mails você precisa responder ou acompanhar.
- [gitmotion/ntfy-me-mcp](https://github.com/gitmotion/ntfy-me-mcp) 📇 ☁️ 🏠 - Um servidor MCP ntfy para enviar/buscar notificações ntfy ao seu servidor ntfy autohospedado a partir de Agentes de IA 📤 (suporta autenticação segura por token e mais - use com npx ou docker!)
- [gotoolkits/wecombot](https://github.com/gotoolkits/mcp-wecombot-server.git) 🚀 ☁️ - Um aplicativo servidor MCP que envia vários tipos de mensagens para o robô de grupo WeCom.
- [hannesrudolph/imessage-query-fastmcp-mcp-server](https://github.com/hannesrudolph/imessage-query-fastmcp-mcp-server) 🐍 🏠 🍎 - Um servidor MCP que fornece acesso seguro ao seu banco de dados iMessage via Model Context Protocol (MCP), permitindo que LLMs consultem e analisem conversas do iMessage com validação adequada de número de telefone e manipulação de anexos.
- [i-am-bee/acp-mcp](https://github.com/i-am-bee/acp-mcp) 🐍 💬 - Um servidor MCP atuando como adaptador para o ecossistema [ACP](https://agentcommunicationprotocol.dev). Expõe perfeitamente agentes ACP a clientes MCP, fazendo a ponte entre os dois protocolos.
- [jagan-shanmugam/mattermost-mcp-host](https://github.com/jagan-shanmugam/mattermost-mcp-host) 🐍 🏠 - Um servidor MCP juntamente com MCP host que fornece acesso a equipes, canais e mensagens do Mattermost. MCP host está integrado como bot no Mattermost com acesso a servidores MCP configuráveis.
- [lharries/whatsapp-mcp](https://github.com/lharries/whatsapp-mcp) 🐍 🏎️ - Um servidor MCP para pesquisar suas mensagens pessoais do WhatsApp, contatos e enviar mensagens para indivíduos ou grupos
- [line/line-bot-mcp-server](https://github.com/line/line-bot-mcp-server) 🎖 📇 ☁️ - Servidor MCP para integração com a Conta Oficial do LINE
- [MarkusPfundstein/mcp-gsuite](https://github.com/MarkusPfundstein/mcp-gsuite) 🐍 ☁️ - Integração com Gmail e Google Calendar.
- [modelcontextprotocol/server-bluesky](https://github.com/keturiosakys/bluesky-context-server) 📇 ☁️ - Integração com instância Bluesky para consulta e interação
- [modelcontextprotocol/server-slack](https://github.com/modelcontextprotocol/servers/tree/main/src/slack) 📇 ☁️ - Integração com workspaces Slack para gerenciamento de canais e mensagens
- [korotovsky/slack-mcp-server](https://github.com/korotovsky/slack-mcp-server) 📇 ☁️ - O servidor MCP mais poderoso para Workspaces Slack.
- [sawa-zen/vrchat-mcp](https://github.com/sawa-zen/vrchat-mcp) - 📇 🏠 Este é um servidor MCP para interagir com a API do VRChat. Você pode recuperar informações sobre amigos, mundos, avatares e mais no VRChat.
- [takumi0706/google-calendar-mcp](https://github.com/takumi0706/google-calendar-mcp) 📇 ☁️ - Servidor MCP para interface com a API do Google Calendar. Baseado em TypeScript.
- [teddyzxcv/ntfy-mcp](https://github.com/teddyzxcv/ntfy-mcp) - O servidor MCP que mantém você informado enviando notificações no telefone usando ntfy
- [userad/didlogic_mcp](https://github.com/UserAd/didlogic_mcp) 🐍 ☁️ - Um servidor MCP para [DIDLogic](https://didlogic.com). Adiciona funcionalidades para gerenciar endpoints SIP, números e destinos.
- [zcaceres/gtasks-mcp](https://github.com/zcaceres/gtasks-mcp) 📇 ☁️ - Um servidor MCP para gerenciar Google Tasks
- [InditexTech/mcp-teams-server](https://github.com/InditexTech/mcp-teams-server) 🐍 ☁️ - Servidor MCP que integra mensagens do Microsoft Teams (ler, postar, mencionar, listar membros e tópicos)
- [softeria/ms-365-mcp-server](https://github.com/softeria/ms-365-mcp-server) 📇 ☁️ - Servidor MCP que conecta toda a suíte Microsoft 365 usando Graph API (incluindo e-mail, arquivos, Excel, calendário)
- [YCloud-Developers/ycloud-whatsapp-mcp-server](https://github.com/YCloud-Developers/ycloud-whatsapp-mcp-server) 📇 🏠 - Servidor MCP para a Plataforma WhatsApp Business da YCloud.
- [jaipandya/producthunt-mcp-server](https://github.com/jaipandya/producthunt-mcp-server) 🐍 🏠 - Servidor MCP para Product Hunt. Interaja com posts em alta, comentários, coleções, usuários e mais.

### 👤 <a name="customer-data-platforms"></a>Plataformas de Dados do Cliente

Fornece acesso a perfis de clientes dentro de plataformas de dados do cliente

- [iaptic/mcp-server-iaptic](https://github.com/iaptic/mcp-server-iaptic) 🎖️ 📇 ☁️ - Conecte-se ao [iaptic](https://www.iaptic.com) para consultar Compras de Clientes, dados de Transações e estatísticas de Receita de Aplicativos.
- [OpenDataMCP/OpenDataMCP](https://github.com/OpenDataMCP/OpenDataMCP) 🐍 ☁️ - Conecte qualquer Open Data a qualquer LLM com Model Context Protocol.
- [sergehuber/inoyu-mcp-unomi-server](https://github.com/sergehuber/inoyu-mcp-unomi-server) 📇 ☁️ - Um servidor MCP para acessar e atualizar perfis em um servidor Apache Unomi CDP.
- [tinybirdco/mcp-tinybird](https://github.com/tinybirdco/mcp-tinybird) 🐍 ☁️ - Um servidor MCP para interagir com um Workspace Tinybird de qualquer cliente MCP.
- [@antv/mcp-server-chart](https://github.com/antvis/mcp-server-chart) 🎖️ 📇 ☁️ - Um servidor Model Context Protocol para geração de gráficos visuais usando [AntV](https://github.com/antvis).

### 🗄️ <a name="databases"></a>Bancos de Dados

Acesso seguro a bancos de dados com capacidade de inspeção de esquema. Permite consultar e analisar dados com controles de segurança configuráveis, incluindo acesso somente leitura.

- [Aiven-Open/mcp-aiven](https://github.com/Aiven-Open/mcp-aiven) - 🐍 ☁️ 🎖️ -  Navegue por seus [projetos Aiven](https://go.aiven.io/mcp-server) e interaja com os serviços PostgreSQL®, Apache Kafka®, ClickHouse® e OpenSearch®
- [alexanderzuev/supabase-mcp-server](https://github.com/alexander-zuev/supabase-mcp-server) - Servidor MCP Supabase com suporte para execução de consultas SQL e ferramentas de exploração de banco de dados
- [aliyun/alibabacloud-tablestore-mcp-server](https://github.com/aliyun/alibabacloud-tablestore-mcp-server) ☕ 🐍 ☁️ - Serviço MCP para Tablestore, com recursos como adição de documentos, busca semântica por documentos baseada em vetores e escalares, compatível com RAG e serverless.
- [benborla29/mcp-server-mysql](https://github.com/benborla/mcp-server-mysql) ☁️ 🏠 - Integração MySQL em NodeJS com controles de acesso configuráveis e inspeção de esquema
- [bytebase/dbhub](https://github.com/bytebase/dbhub) 📇 🏠 – Servidor MCP universal de banco de dados com suporte aos principais bancos de dados.
- [c4pt0r/mcp-server-tidb](https://github.com/c4pt0r/mcp-server-tidb) 🐍 ☁️ - Integração com banco de dados TiDB com inspeção de esquema e recursos de consulta
- [Canner/wren-engine](https://github.com/Canner/wren-engine) 🐍 🦀 🏠 - O motor semântico para clientes Model Context Protocol (MCP) e agentes de IA
- [centralmind/gateway](https://github.com/centralmind/gateway) 🏎️ 🏠 🍎 🪟 - Servidor MCP e MCP SSE que gera automaticamente API baseada em esquema e dados do banco de dados. Suporta PostgreSQL, Clickhouse, MySQL, Snowflake, BigQuery, Supabase
- [ChristianHinge/dicom-mcp](https://github.com/ChristianHinge/dicom-mcp) 🐍 ☁️ 🏠 - Integração DICOM para consultar, ler e mover imagens médicas e laudos de PACS e outros sistemas compatíveis com DICOM.
- [chroma-core/chroma-mcp](https://github.com/chroma-core/chroma-mcp) 🎖️ 🐍 ☁️ 🏠 - Servidor MCP Chroma para acessar instâncias Chroma locais e na nuvem para capacidades de recuperação
- [ClickHouse/mcp-clickhouse](https://github.com/ClickHouse/mcp-clickhouse) 🐍 ☁️ - Integração com banco de dados ClickHouse com inspeção de esquema e recursos de consulta
- [confluentinc/mcp-confluent](https://github.com/confluentinc/mcp-confluent) 🐍 ☁️ - Integração Confluent para interagir com as APIs REST do Confluent Kafka e do Confluent Cloud.
- [Couchbase-Ecosystem/mcp-server-couchbase](https://github.com/Couchbase-Ecosystem/mcp-server-couchbase) 🎖️ 🐍 ☁️ 🏠 - O servidor Couchbase MCP fornece acesso unificado tanto à nuvem Capella quanto a clusters autogerenciados para operações com documentos, consultas SQL++ e análise de dados em linguagem natural.
- [cr7258/elasticsearch-mcp-server](https://github.com/cr7258/elasticsearch-mcp-server) 🐍 🏠 - Implementação de Servidor MCP que fornece interação com Elasticsearch.
- [crystaldba/postgres-mcp](https://github.com/crystaldba/postgres-mcp) 🐍 🏠 - Servidor MCP tudo-em-um para desenvolvimento e operações com Postgres, com ferramentas para análise de desempenho, ajuste e verificações de integridade.
- [Dataring-engineering/mcp-server-trino](https://github.com/Dataring-engineering/mcp-server-trino) 🐍 ☁️ - Servidor MCP Trino para consultar e acessar dados de clusters Trino.
- [tuannvm/mcp-trino](https://github.com/tuannvm/mcp-trino) 🏎️ ☁️ - Uma implementação Go de um servidor Model Context Protocol (MCP) para Trino.
- [designcomputer/mysql_mcp_server](https://github.com/designcomputer/mysql_mcp_server) 🐍 🏠 - Integração com banco de dados MySQL com controles de acesso configuráveis, inspeção de esquema e diretrizes abrangentes de segurança.
- [wenb1n-dev/mysql_mcp_server_pro](https://github.com/wenb1n-dev/mysql_mcp_server_pro)  🐍 🏠 - Suporta SSE, STDIO; não se limita apenas à funcionalidade CRUD do MySQL; também inclui capacidades de análise de exceções do banco de dados; controla permissões do banco com base em funções; e facilita a extensão de ferramentas pelos desenvolvedores com personalização.
- [domdomegg/airtable-mcp-server](https://github.com/domdomegg/airtable-mcp-server) 📇 🏠 - Integração com banco de dados Airtable com inspeção de esquema, capacidades de leitura e escrita.
- [edwinbernadus/nocodb-mcp-server](https://github.com/edwinbernadus/nocodb-mcp-server) 📇 ☁️ - Integração com banco de dados Nocodb, capacidades de leitura e escrita.
- [ergut/mcp-bigquery-server](https://github.com/ergut/mcp-bigquery-server) 📇 ☁️ - Implementação de servidor para integração com Google BigQuery que permite acesso direto ao banco e capacidades de consulta.
- [f4ww4z/mcp-mysql-server](https://github.com/f4ww4z/mcp-mysql-server) 📇 🏠 - Integração com banco MySQL baseada em Node.js que fornece operações seguras no banco de dados MySQL.
- [fireproof-storage/mcp-database-server](https://github.com/fireproof-storage/mcp-database-server) 📇 ☁️ - Banco de dados ledger Fireproof com sincronização multiusuário.
- [FreePeak/db-mcp-server](https://github.com/FreePeak/db-mcp-server) 🏎️ 🏠 – Um servidor MCP multi-banco de alto desempenho construído em Golang, com suporte a MySQL & PostgreSQL (NoSQL em breve). Inclui ferramentas integradas para execução de consultas, gerenciamento de transações, exploração de esquemas, construção de consultas e análise de desempenho, com integração perfeita com Cursor para fluxos de trabalho aprimorados.
- [furey/mongodb-lens](https://github.com/furey/mongodb-lens) 📇 🏠 - MongoDB Lens: Servidor MCP completo para bancos MongoDB.
- [gannonh/firebase-mcp](https://github.com/gannonh/firebase-mcp) 🔥 ⛅️ - Serviços Firebase incluindo Auth, Firestore e Storage.
- [get-convex/convex-backend](https://stack.convex.dev/convex-mcp-server) 📇 ☁️ - Integração com banco Convex para inspecionar tabelas, funções e executar consultas pontuais ([Fonte](https://github.com/get-convex/convex-backend/blob/main/npm-packages/convex/src/cli/mcp.ts))
- [googleapis/genai-toolbox](https://github.com/googleapis/genai-toolbox) 🏎️ ☁️ - Servidor MCP open source especializado em ferramentas fáceis, rápidas e seguras para bancos de dados.
- [GreptimeTeam/greptimedb-mcp-server](https://github.com/GreptimeTeam/greptimedb-mcp-server) 🐍 🏠 - Servidor MCP para consultas ao GreptimeDB.
- [hannesrudolph/sqlite-explorer-fastmcp-mcp-server](https://github.com/hannesrudolph/sqlite-explorer-fastmcp-mcp-server) 🐍 🏠 - Um servidor MCP que fornece acesso seguro e somente leitura a bancos SQLite via Model Context Protocol (MCP). Construído com o framework FastMCP, permite que LLMs explorem e consultem bancos SQLite com recursos de segurança e validação de consultas integrados.
- [idoru/influxdb-mcp-server](https://github.com/idoru/influxdb-mcp-server) 📇 ☁️ 🏠 - Execute consultas contra o InfluxDB OSS API v2.
- [isaacwasserman/mcp-snowflake-server](https://github.com/isaacwasserman/mcp-snowflake-server) 🐍 ☁️ - Integração Snowflake implementando operações de leitura e (opcional) escrita, além de rastreamento de insights.
- [joshuarileydev/supabase-mcp-server](https://github.com/joshuarileydev/supabase) - Servidor Supabase MCP para gerenciar e criar projetos e organizações no Supabase.
- [jovezhong/mcp-timeplus](https://github.com/jovezhong/mcp-timeplus) 🐍 ☁️ - Servidor MCP para Apache Kafka e Timeplus. Capaz de listar tópicos Kafka, buscar mensagens Kafka, salvar dados Kafka localmente e consultar dados em streaming com SQL via Timeplus.
- [KashiwaByte/vikingdb-mcp-server](https://github.com/KashiwaByte/vikingdb-mcp-server) 🐍 ☁️ - Integração VikingDB com introdução de coleções e índices, armazenamento e busca vetorial.
- [kiliczsh/mcp-mongo-server](https://github.com/kiliczsh/mcp-mongo-server) 📇 🏠 - Um servidor Model Context Protocol para MongoDB.
- [ktanaka101/mcp-server-duckdb](https://github.com/ktanaka101/mcp-server-duckdb) 🐍 🏠 - Integração com banco DuckDB com inspeção de esquema e capacidades de consulta.
- [LucasHild/mcp-server-bigquery](https://github.com/LucasHild/mcp-server-bigquery) 🐍 ☁️ - Integração com banco BigQuery com inspeção de esquema e capacidades de consulta.
- [quarkiverse/mcp-server-jdbc](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/jdbc) ☕ 🏠 - Conecte-se a qualquer banco compatível com JDBC para consultar, inserir, atualizar, deletar e mais.
- [jparkerweb/mcp-sqlite](https://github.com/jparkerweb/mcp-sqlite) 📇 🏠 - Servidor Model Context Protocol (MCP) que fornece interação abrangente com bancos SQLite.
- [memgraph/mcp-memgraph](https://github.com/memgraph/mcp-memgraph) 🐍 🏠 - Servidor Memgraph MCP — inclui ferramenta para executar consulta e recurso de esquema.
- [modelcontextprotocol/server-postgres](https://github.com/modelcontextprotocol/servers/tree/main/src/postgres) 📇 🏠 - Integração com banco PostgreSQL com inspeção de esquema e capacidades de consulta.
- [modelcontextprotocol/server-sqlite](https://github.com/modelcontextprotocol/servers/tree/main/src/sqlite) 🐍 🏠 - Operações com banco SQLite com recursos de análise integrados.
- [neo4j-contrib/mcp-neo4j](https://github.com/neo4j-contrib/mcp-neo4j) 🐍 🏠 - Model Context Protocol com Neo4j (executa consultas, memória de grafo de conhecimento, gerencia instâncias Neo4j Aura).
- [neondatabase/mcp-server-neon](https://github.com/neondatabase/mcp-server-neon) 📇 ☁️ — Um Servidor MCP para criar e gerenciar bancos Postgres usando o Neon Serverless Postgres.
- [niledatabase/nile-mcp-server](https://github.com/niledatabase/nile-mcp-server) Servidor MCP para a plataforma Postgres da Nile — Gerencie e consulte bancos Postgres, locatários, usuários, autenticação usando LLMs.
- [openlink/mcp-server-odbc](https://github.com/OpenLinkSoftware/mcp-odbc-server) 🐍 🏠 - Servidor MCP para conectividade genérica com Sistemas de Gerenciamento de Banco de Dados (DBMS) via protocolo ODBC.
- [openlink/mcp-server-sqlalchemy](https://github.com/OpenLinkSoftware/mcp-sqlalchemy-server) 🐍 🏠 - Servidor MCP para conectividade genérica com DBMS via SQLAlchemy usando Python ODBC (pyodbc).
- [pab1it0/adx-mcp-server](https://github.com/pab1it0/adx-mcp-server) 🐍 ☁️ - Consulta e análise de bancos Azure Data Explorer.
- [pab1it0/prometheus-mcp-server](https://github.com/pab1it0/prometheus-mcp-server) 🐍 ☁️ - Consulta e análise do Prometheus, sistema open-source de monitoramento.
- [prisma/prisma](https://github.com/prisma/prisma) 🐍 🏠 - Permite que LLMs gerenciem bancos Prisma Postgres (ex: criar novas instâncias ou executar migrações de esquema).
- [qdrant/mcp-server-qdrant](https://github.com/qdrant/mcp-server-qdrant) 🐍 🏠 - Um servidor Qdrant MCP.
- [QuantGeekDev/mongo-mcp](https://github.com/QuantGeekDev/mongo-mcp) 📇 🏠 - Integração MongoDB que permite que LLMs interajam diretamente com bancos de dados.
- [rashidazarang/airtable-mcp](https://github.com/rashidazarang/airtable-mcp) 🐍 ☁️ - Conecte ferramentas de IA diretamente ao Airtable. Consulte, crie, atualize e exclua registros usando linguagem natural. Recursos incluem gerenciamento de bases, operações em tabelas, manipulação de esquemas, filtragem de registros e migração de dados através de uma interface MCP padronizada.
- [redis/mcp-redis](https://github.com/redis/mcp-redis) 🐍 🏠 - O servidor MCP oficial do Redis oferece interface para gerenciar e buscar dados no Redis.
- [runekaagaard/mcp-alchemy](https://github.com/runekaagaard/mcp-alchemy) 🐍 🏠 - Integração universal baseada em SQLAlchemy com suporte a PostgreSQL, MySQL, MariaDB, SQLite, Oracle, MS SQL Server e muitos outros. Recursos de inspeção de esquema, relacionamentos e análise de grandes volumes de dados.
- [sirmews/mcp-pinecone](https://github.com/sirmews/mcp-pinecone) 🐍 ☁️ - Integração Pinecone com capacidades de busca vetorial.
- [skysqlinc/skysql-mcp](https://github.com/skysqlinc/skysql-mcp) 🎖️ ☁️ - Servidor MCP Serverless MariaDB Cloud DB. Ferramentas para iniciar, deletar, executar SQL e trabalhar com agentes de IA para conversão texto-para-sql e conversas.
- [supabase-community/supabase-mcp](https://github.com/supabase-community/supabase-mcp) 🎖️ 📇 ☁️ - Servidor MCP oficial do Supabase para conectar assistentes de IA diretamente ao seu projeto Supabase, permitindo tarefas como gerenciamento de tabelas, obtenção de configuração e consultas de dados.
- [TheRaLabs/legion-mcp](https://github.com/TheRaLabs/legion-mcp) 🐍 🏠 Servidor MCP universal para bancos de dados, suportando múltiplos tipos incluindo PostgreSQL, Redshift, CockroachDB, MySQL, RDS MySQL, Microsoft SQL Server, BigQuery, Oracle DB e SQLite.
- [tradercjz/dolphindb-mcp-server](https://github.com/tradercjz/dolphindb-mcp-server) 🐍 ☁️ - Integração com DolphinDB com inspeção de esquema e capacidades de consulta.
- [weaviate/mcp-server-weaviate](https://github.com/weaviate/mcp-server-weaviate) 🐍 📇 ☁️ - Um servidor MCP para conectar suas coleções Weaviate como base de conhecimento e também usar como memória de chat.
- [XGenerationLab/xiyan_mcp_server](https://github.com/XGenerationLab/xiyan_mcp_server) 📇 ☁️ — Um servidor MCP que suporta busca de dados em bancos utilizando consultas em linguagem natural, alimentado por XiyanSQL como LLM texto-para-SQL.
- [xing5/mcp-google-sheets](https://github.com/xing5/mcp-google-sheets) 🐍 ☁️ - Um servidor Model Context Protocol para interação com Google Sheets. Ferramentas para criar, ler, atualizar e gerenciar planilhas pela API do Google Sheets.
- [freema/mcp-gsheets](https://github.com/freema/mcp-gsheets) 📇 ☁️ - Servidor MCP para integração com API do Google Sheets, com leitura, escrita, formatação e gerenciamento completos das planilhas.
- [Zhwt/go-mcp-mysql](https://github.com/Zhwt/go-mcp-mysql) 🏎️ 🏠 – Servidor MCP MySQL fácil de usar, sem dependências, construído em Golang com modo somente leitura configurável e inspeção de esquema.
- [ydb/ydb-mcp](https://github.com/ydb-platform/ydb-mcp) 🎖️ 🐍 ☁️ - Servidor MCP para interação com bancos [YDB](https://ydb.tech).
- [zilliztech/mcp-server-milvus](https://github.com/zilliztech/mcp-server-milvus) 🐍 🏠 ☁️ - Servidor MCP para Milvus / Zilliz, possibilitando interação com seu banco de dados.
- [openlink/mcp-server-jdbc](https://github.com/OpenLinkSoftware/mcp-jdbc-server) 🐍 🏠 - Servidor MCP para conectividade genérica com DBMS via protocolo Java Database Connectivity (JDBC).
- [yincongcyincong/VictoriaMetrics-mcp-server](https://github.com/yincongcyincong/VictoriaMetrics-mcp-server) 🐍 🏠 - Servidor MCP para interação com banco VictoriaMetrics.
- [hydrolix/mcp-hydrolix](https://github.com/hydrolix/mcp-hydrolix) 🎖️ 🐍 ☁️ - Integração Hydrolix time-series datalake fornecendo exploração de esquema e capacidades de consulta para fluxos de trabalho baseados em LLM.
- [davewind/mysql-mcp-server](https://github.com/dave-wind/mysql-mcp-server) 🏎️ 🏠 – Servidor MCP MySQL somente leitura, amigável ao usuário, para cursor e n8n...


### 📊 <a name="data-platforms"></a>Plataformas de Dados

Plataformas de dados para integração, transformação e orquestração de pipelines de dados.

- [flowcore/mcp-flowcore-platform](https://github.com/flowcore-io/mcp-flowcore-platform) 🎖️ 📇 ☁️ 🏠 - Interaja com Flowcore para realizar ações, ingerir dados e analisar, cruzar e utilizar qualquer dado em seus data cores ou em data cores públicos, tudo em linguagem natural.
- [JordiNei/mcp-databricks-server](https://github.com/JordiNeil/mcp-databricks-server) 🐍 ☁️ - Conecte-se à API Databricks, permitindo que LLMs executem consultas SQL, listem jobs e obtenham status de jobs.
- [yashshingvi/databricks-genie-MCP](https://github.com/yashshingvi/databricks-genie-MCP) 🐍 ☁️ - Servidor que conecta à API Databricks Genie, permitindo que LLMs façam perguntas em linguagem natural, executem consultas SQL e interajam com agentes conversacionais do Databricks.
- [jwaxman19/qlik-mcp](https://github.com/jwaxman19/qlik-mcp) 📇 ☁️ - Servidor MCP para API Qlik Cloud que permite consultar aplicações, abas e extrair dados de visualizações, com autenticação abrangente e suporte a rate limiting.
- [keboola/keboola-mcp-server](https://github.com/keboola/keboola-mcp-server) 🐍 - Interaja com a plataforma Keboola Connection Data. Ferramentas para listar e acessar dados via API Keboola Storage.
- [dbt-labs/dbt-mcp](https://github.com/dbt-labs/dbt-mcp) 🎖️ 🐍 🏠 ☁️ - Servidor MCP oficial para [dbt (data build tool)](https://www.getdbt.com/product/what-is-dbt) fornecendo integração com dbt Core/Cloud CLI, descoberta de metadados de projeto, informações de modelos e consultas à camada semântica.
- [mattijsdp/dbt-docs-mcp](https://github.com/mattijsdp/dbt-docs-mcp) 🐍 🏠 - Servidor MCP para usuários dbt-core (OSS), pois o MCP dbt oficial só suporta dbt Cloud. Suporta metadados de projeto, linhagem de modelos e colunas e documentação dbt.

### 💻 <a name="developer-tools"></a>Ferramentas de Desenvolvimento

Ferramentas e integrações que aprimoram o fluxo de trabalho de desenvolvimento e o gerenciamento do ambiente.

- [Pratyay/mac-monitor-mcp](https://github.com/Pratyay/mac-monitor-mcp) 🐍 🏠 🍎 - Identifica processos que consomem muitos recursos no macOS e sugere melhorias de desempenho.
- [21st-dev/Magic-MCP](https://github.com/21st-dev/magic-mcp) - Crie componentes de UI inspirados pelos melhores engenheiros de design do 21st.dev.
- [Hypersequent/qasphere-mcp](https://github.com/Hypersequent/qasphere-mcp) 🎖️ 📇 ☁️ - Integração com o sistema de gerenciamento de testes [QA Sphere](https://qasphere.com/), permitindo que LLMs descubram, resumam e interajam com casos de teste diretamente de IDEs com IA.
- [admica/FileScopeMCP](https://github.com/admica/FileScopeMCP) 🐍 📇 🦀 - Analisa seu código identificando arquivos importantes com base nas dependências. Gera diagramas e pontuações de importância, ajudando assistentes de IA a entender o código.
- [ambar/simctl-mcp](https://github.com/ambar/simctl-mcp) 📇 🏠 🍎 Uma implementação de servidor MCP para controle do iOS Simulator.
- [api7/apisix-mcp](https://github.com/api7/apisix-mcp) 🎖️ 📇 🏠 Servidor MCP que suporta consultas e gerenciamento de todos os recursos no [Apache APISIX](https://github.com/apache/apisix).
- [ArchAI-Labs/fastmcp-sonarqube-metrics](https://github.com/ArchAI-Labs/fastmcp-sonarqube-metrics) 🐍 🏠 🪟 🐧 🍎 -  Servidor Model Context Protocol (MCP) que fornece ferramentas para obter informações sobre projetos SonarQube como métricas (atuais e históricas), problemas e status de saúde.
- [automation-ai-labs/mcp-link](https://github.com/automation-ai-labs/mcp-link) 🏎️ 🏠 - Integre qualquer API com agentes de IA de forma transparente (com Esquema OpenAPI).
- [azer/react-analyzer-mcp](https://github.com/azer/react-analyzer-mcp) 📇 🏠 - Analisa código React localmente, gera documentação / llm.txt para todo o projeto de uma vez.
- [davidlin2k/pox-mcp-server](https://github.com/davidlin2k/pox-mcp-server) 🐍 🏠 - Servidor MCP para o controlador SDN POX, fornecendo capacidades de controle e gerenciamento de rede.
- [CodeLogicIncEngineering/codelogic-mcp-server](https://github.com/CodeLogicIncEngineering/codelogic-mcp-server) 🎖️ 🐍 ☁️ 🍎 🪟 🐧 - Servidor MCP oficial para CodeLogic, fornecendo acesso a análise de dependências de código, análise de risco arquitetural e ferramentas de avaliação de impacto.
- [Comet-ML/Opik-MCP](https://github.com/comet-ml/opik-mcp) 🎖️ 📇 ☁️ 🏠 - Use linguagem natural para explorar observabilidade LLM, rastreamentos e dados de monitoramento capturados pelo Opik.
- [CircleCI/mcp-server-circleci](https://github.com/CircleCI-Public/mcp-server-circleci) 📇 ☁️ Permite que agentes de IA corrijam falhas de build do CircleCI.
- [currents-dev/currents-mcp](https://github.com/currents-dev/currents-mcp) 🎖️ 📇 ☁️ Permite que agentes de IA corrijam falhas de teste Playwright relatadas ao [Currents](https://currents.dev).
- [delano/postman-mcp-server](https://github.com/delano/postman-mcp-server) 📇 ☁️ - Interaja com a [API do Postman](https://www.postman.com/postman/postman-public-workspace/)
- [flipt-io/mcp-server-flipt](https://github.com/flipt-io/mcp-server-flipt) 📇 🏠 - Permite que assistentes de IA interajam com seus feature flags no [Flipt](https://flipt.io).
- [GLips/Figma-Context-MCP](https://github.com/GLips/Figma-Context-MCP) 📇 🏠 - Forneça aos agentes de codificação acesso direto aos dados do Figma para ajudar na implementação de design em uma só etapa.
- [gofireflyio/firefly-mcp](https://github.com/gofireflyio/firefly-mcp) 🎖️ 📇 ☁️ - Integra, descobre, gerencia e codifica recursos em nuvem com o [Firefly](https://firefly.ai).
- [Govcraft/rust-docs-mcp-server](https://github.com/Govcraft/rust-docs-mcp-server) 🦀 🏠 - Fornece contexto de documentação atualizada para um crate Rust específico para LLMs via ferramenta MCP, usando busca semântica (embeddings) e sumarização LLM.
- [haris-musa/excel-mcp-server](https://github.com/haris-musa/excel-mcp-server) 🐍 🏠 - Um servidor de manipulação Excel fornecendo criação de planilhas, operações de dados, formatação e recursos avançados (gráficos, tabelas dinâmicas, fórmulas).
- [higress-group/higress-ops-mcp-server](https://github.com/higress-group/higress-ops-mcp-server) 🐍 🏠 - Servidor MCP que fornece ferramentas abrangentes para gerenciar configurações e operações do gateway [Higress](https://github.com/alibaba/higress).
- [hijaz/postmancer](https://github.com/hijaz/postmancer) 📇 🏠 - Um servidor MCP para substituir clientes Rest como Postman/Insomnia, permitindo que seu LLM mantenha e use coleções de APIs.
- [hloiseaufcms/mcp-gopls](https://github.com/hloiseaufcms/mcp-gopls) 🏎️ 🏠 - Um servidor MCP para interagir com o [Protocolo de Servidor de Linguagem do Go (gopls)](https://github.com/golang/tools/tree/master/gopls) e aproveitar recursos avançados de análise de código Go.
- [hungthai1401/bruno-mcp](https://github.com/hungthai1401/bruno-mcp) 📇 🏠 - Um servidor MCP para interagir com o [Bruno API Client](https://www.usebruno.com/).
- [hyperb1iss/droidmind](https://github.com/hyperb1iss/droidmind) 🐍 🏠 - Controle dispositivos Android com IA via MCP, habilitando controle do dispositivo, depuração, análise de sistema e automação de UI com uma estrutura de segurança abrangente.
- [XixianLiang/HarmonyOS-mcp-server](https://github.com/XixianLiang/HarmonyOS-mcp-server) 🐍 🏠 - Controle dispositivos HarmonyOS-next com IA via MCP. Suporta controle de dispositivo e automação de UI.
- [IlyaGulya/gradle-mcp-server](https://github.com/IlyaGulya/gradle-mcp-server) 🏠 - Integração Gradle usando a API Gradle Tooling para inspecionar projetos, executar tarefas e rodar testes com relatórios de resultados por teste.
- [InhiblabCore/mcp-image-compression](https://github.com/InhiblabCore/mcp-image-compression) 🐍 🏠 - Servidor MCP para compressão local de vários formatos de imagem.
- [isaacphi/mcp-language-server](https://github.com/isaacphi/mcp-language-server) 🏎️ 🏠 - MCP Language Server auxilia clientes habilitados para MCP a navegar por bases de código com ferramentas semânticas como obter definição, referências, renomear e diagnósticos.
- [ios-simulator-mcp](https://github.com/joshuayoes/ios-simulator-mcp) 📇 🏠 🍎 - Um servidor Model Context Protocol (MCP) para interagir com simuladores iOS. Permite obter informações, controlar interações de UI e inspecionar elementos de UI.
- [InditexTech/mcp-server-simulator-ios-idb](https://github.com/InditexTech/mcp-server-simulator-ios-idb) 📇 🏠 🍎 - Um servidor Model Context Protocol (MCP) que permite que LLMs interajam com simuladores iOS (iPhone, iPad, etc.) via comandos em linguagem natural.
- [IvanAmador/vercel-ai-docs-mcp](https://github.com/IvanAmador/vercel-ai-docs-mcp) 📇 🏠 - Um servidor Model Context Protocol (MCP) que fornece pesquisa e consulta por IA para a documentação do Vercel AI SDK.
- [j4c0bs/mcp-server-sql-analyzer](https://github.com/j4c0bs/mcp-server-sql-analyzer) 🐍 - Servidor MCP que fornece análise SQL, linting e conversão de dialetos usando [SQLGlot](https://github.com/tobymao/sqlglot)
- [jasonjmcghee/claude-debugs-for-you](https://github.com/jasonjmcghee/claude-debugs-for-you) 📇 🏠 - Um Servidor MCP e extensão VS Code que permite depuração automática (agnóstico à linguagem) via breakpoints e avaliação de expressões.
- [jetbrains/mcpProxy](https://github.com/JetBrains/mcpProxy) 🎖️ 📇 🏠 - Conecte-se ao JetBrains IDE
- [qainsights/jmeter-mcp-server](https://github.com/QAInsights/jmeter-mcp-server) 🐍 🏠 - Servidor JMeter MCP para testes de performance
- [Jktfe/serveMyAPI](https://github.com/Jktfe/serveMyAPI) 📇 🏠 🍎 - Um servidor MCP pessoal para armazenar e acessar chaves de API com segurança em projetos usando o Keychain do macOS.
- [joshuarileydev/app-store-connect-mcp-server](https://github.com/JoshuaRileyDev/app-store-connect-mcp-server) 📇 🏠 - Um servidor MCP para comunicar-se com a API App Store Connect para desenvolvedores iOS
- [joshuarileydev/simulator-mcp-server](https://github.com/JoshuaRileyDev/simulator-mcp-server) 📇 🏠 - Um servidor MCP para controlar simuladores iOS
- [qainsights/k6-mcp-server](https://github.com/QAInsights/k6-mcp-server) 🐍 🏠 - Servidor Grafana k6 MCP para testes de performance
- [lamemind/mcp-server-multiverse](https://github.com/lamemind/mcp-server-multiverse) 📇 🏠 🛠️ - Um servidor middleware que permite a coexistência independente de múltiplas instâncias isoladas dos mesmos servidores MCP, com namespaces e configurações exclusivos.
- [langfuse/mcp-server-langfuse](https://github.com/langfuse/mcp-server-langfuse) 🐍 🏠 - Servidor MCP para acessar e gerenciar prompts de aplicativos LLM criados com [Langfuse]([https://langfuse.com/](https://langfuse.com/docs/prompts/get-started)) Prompt Management.
- [mobile-next/mobile-mcp](https://github.com/mobile-next/mobile-mcp) 📇 🏠 🐧 🍎 - Servidor MCP para automação de aplicativos e dispositivos Android/iOS, desenvolvimento e scraping de apps. Suporte a simulador/emulador/dispositivos físicos como iPhone, Google Pixel, Samsung.
- [qainsights/locust-mcp-server](https://github.com/QAInsights/locust-mcp-server) 🐍 🏠 - Servidor Locust MCP para testes de performance
- [mrexodia/user-feedback-mcp](https://github.com/mrexodia/user-feedback-mcp) 🐍 🏠 - Servidor MCP simples para habilitar workflow com humanos no loop em ferramentas como Cline e Cursor.
- [narumiruna/gitingest-mcp](https://github.com/narumiruna/gitingest-mcp) 🐍 🏠 - Um servidor MCP que usa [gitingest](https://github.com/cyclotruc/gitingest) para converter qualquer repositório Git em um resumo de texto simples da base de código.
- [OctoMind-dev/octomind-mcp](https://github.com/OctoMind-dev/octomind-mcp) 📇 ☁️ - permite que seu agente de IA crie e execute testes end-to-end totalmente gerenciados do [Octomind](https://www.octomind.dev/) a partir do seu código ou de outras fontes como Jira, Slack ou TestRail.
- [kadykov/mcp-openapi-schema-explorer](https://github.com/kadykov/mcp-openapi-schema-explorer) 📇 ☁️ 🏠 - Acesso eficiente a especificações OpenAPI/Swagger via MCP Resources.
- [pskill9/website-downloader](https://github.com/pskill9/website-downloader) 🗄️ 🚀 - Este servidor MCP fornece uma ferramenta para baixar sites inteiros usando wget. Preserva a estrutura do site e converte links para funcionar localmente.
- [utensils/mcp-nixos](https://github.com/utensils/mcp-nixos) 🐍 🏠 - Servidor MCP fornecendo informações precisas sobre pacotes NixOS, opções do sistema, configurações do Home Manager e ajustes do nix-darwin no macOS para evitar alucinações de IA.
- [QuantGeekDev/docker-mcp](https://github.com/QuantGeekDev/docker-mcp) 🏎️ 🏠 - Gerenciamento e operações de containers Docker via MCP
- [ckreiling/mcp-server-docker](https://github.com/ckreiling/mcp-server-docker) 🐍 🏠 - Integração com Docker para gerenciar containers, imagens, volumes e redes.
- [r-huijts/xcode-mcp-server](https://github.com/r-huijts/xcode-mcp-server) 📇 🏠 🍎 - Integração Xcode para gerenciamento de projetos, operações de arquivos e automação de builds
- [ReAPI-com/mcp-openapi](https://github.com/ReAPI-com/mcp-openapi) 📇 🏠 - Servidor MCP que permite que LLMs saibam tudo sobre suas especificações OpenAPI para descobrir, explicar e gerar código/dados mock
- [Rootly-AI-Labs/Rootly-MCP-server](https://github.com/Rootly-AI-Labs/Rootly-MCP-server) 🎖️ 🐍 ☁️ 🍎 - Servidor MCP para a plataforma de gerenciamento de incidentes [Rootly](https://rootly.com/).
- [sammcj/mcp-package-version](https://github.com/sammcj/mcp-package-version) 📇 🏠 - Um Servidor MCP para ajudar LLMs a sugerirem a versão mais estável de um pacote ao escrever código.
- [sapientpants/sonarqube-mcp-server](https://github.com/sapientpants/sonarqube-mcp-server) 🦀 ☁️ 🏠 - Um servidor Model Context Protocol (MCP) que integra o SonarQube para fornecer métricas de qualidade de código, issues e status das quality gates a assistentes de IA.
- [SDGLBL/mcp-claude-code](https://github.com/SDGLBL/mcp-claude-code) 🐍 🏠 - Uma implementação das capacidades do Claude Code usando MCP, permitindo compreensão, modificação e análise de projetos de código pela IA com amplo suporte de ferramentas.
- [snaggle-ai/openapi-mcp-server](https://github.com/snaggle-ai/openapi-mcp-server) 🏎️ 🏠 - Conecte qualquer servidor HTTP/REST API usando uma especificação Open API (v3)
- [stass/lldb-mcp](https://github.com/stass/lldb-mcp) 🐍 🏠 🐧 🍎 - Um servidor MCP para LLDB, permitindo análise binária e de arquivos core, depuração e desassemblagem por IA.
- [TencentEdgeOne/edgeone-pages-mcp](https://github.com/TencentEdgeOne/edgeone-pages-mcp) 📇 ☁️ - Serviço MCP para deploy de conteúdo HTML no EdgeOne Pages e obtenção de URL pública.
- [tumf/mcp-text-editor](https://github.com/tumf/mcp-text-editor) 🐍 🏠 - Editor de arquivos texto orientado a linhas. Otimizado para ferramentas LLM com acesso eficiente a partes do arquivo para minimizar uso de tokens.
- [vivekvells/mcp-pandoc](https://github.com/vivekVells/mcp-pandoc) 🗄️ 🚀 - Servidor MCP para conversão transparente de formatos de documento usando o Pandoc, suportando Markdown, HTML, PDF, DOCX (.docx), csv e mais.
- [VSCode Devtools](https://github.com/biegehydra/BifrostMCP) 📇 - Conecte-se ao VSCode IDE e use ferramentas semânticas como `find_usages`
- [xcodebuild](https://github.com/ShenghaiWang/xcodebuild) 🍎 Compile workspace/projeto Xcode do iOS e retorne erros ao llm.
- [xzq.xu/jvm-mcp-server](https://github.com/xzq-xu/jvm-mcp-server) 📇 🏠  - Um projeto de implementação de um servidor MCP (Model Context Protocol) baseado em JVM.
- [yangkyeongmo@/mcp-server-apache-airflow](https://github.com/yangkyeongmo/mcp-server-apache-airflow) 🐍 🏠 - Servidor MCP que se conecta ao [Apache Airflow](https://airflow.apache.org/) usando o cliente oficial.
- [YuChenSSR/mindmap-mcp-server](https://github.com/YuChenSSR/mindmap-mcp-server) 🐍 🏠 - Um servidor Model Context Protocol (MCP) para geração de mapas mentais interativos e bonitos.
- [YuChenSSR/multi-ai-advisor](https://github.com/YuChenSSR/multi-ai-advisor-mcp) 📇 🏠 - Um servidor Model Context Protocol (MCP) que consulta múltiplos modelos Ollama e combina suas respostas, fornecendo perspectivas diversificadas de IA sobre uma mesma pergunta.
- [yWorks/mcp-typescribe](https://github.com/yWorks/mcp-typescribe) 📇 🏠 - Servidor MCP que fornece informações de APIs Typescript de forma eficiente para o agente trabalhar com APIs não treinadas
- [zcaceres/fetch-mcp](https://github.com/zcaceres/fetch-mcp) 📇 🏠 - Um servidor MCP para buscar dados JSON, texto e HTML de forma flexível
- [zenml-io/mcp-zenml](https://github.com/zenml-io/mcp-zenml) 🐍 🏠 ☁️ - Um servidor MCP para conectar com seus pipelines de MLOps e LLMOps do [ZenML](https://www.zenml.io)
- [idosal/git-mcp](https://github.com/idosal/git-mcp) 📇 ☁️ - [gitmcp.io](https://gitmcp.io/) é um servidor MCP remoto genérico para conectar a QUALQUER repositório ou projeto [GitHub](https://www.github.com) para documentação
- [tgeselle/bugsnag-mcp](https://github.com/tgeselle/bugsnag-mcp) 📇 ☁️ - Um servidor MCP para interagir com o [Bugsnag](https://www.bugsnag.com/)
- [jordandalton/restcsv-mcp-server](https://github.com/JordanDalton/RestCsvMcpServer) 📇 ☁️ - Um servidor MCP para arquivos CSV.
- [cjo4m06/mcp-shrimp-task-manager](https://github.com/cjo4m06/mcp-shrimp-task-manager) 📇 ☁️ 🏠 – Um sistema de gerenciamento de tarefas focado em programação que potencializa agentes de codificação como o Cursor AI com memória avançada de tarefas, autorreflexão e gerenciamento de dependências. [ShrimpTaskManager](https://cjo4m06.github.io/mcp-shrimp-task-manager)
- [axliupore/mcp-code-runner](https://github.com/axliupore/mcp-code-runner) 📇 🏠 - Um servidor MCP para execução de código localmente via Docker, suportando múltiplas linguagens de programação.
- [yikakia/godoc-mcp-server](https://github.com/yikakia/godoc-mcp-server) 🏎️ ☁️ 🪟 🐧 🍎 - Consulte informações de pacotes Go no pkg.go.dev
- [ckanthony/gin-mcp](https://github.com/ckanthony/gin-mcp) 🏎️ ☁️ 📟 🪟 🐧 🍎 - Uma biblioteca Go de configuração zero para expor automaticamente APIs existentes do framework web Gin como ferramentas MCP.
- [ryan0204/github-repo-mcp](https://github.com/Ryan0204/github-repo-mcp) 📇 ☁️ 🪟 🐧 🍎 - GitHub Repo MCP permite que seus assistentes de IA naveguem em repositórios GitHub, explorem diretórios e visualizem conteúdos de arquivos.
- [alimo7amed93/webhook-tester-mcp](https://github.com/alimo7amed93/webhook-tester-mcp)  🐍 ☁️ – Um servidor baseado em FastMCP para interagir com webhook-test.com. Permite criar, recuperar e deletar webhooks localmente usando Claude.
- [lpigeon/ros-mcp-server](https://github.com/lpigeon/ros-mcp-server) 🐍 🏠 🍎 🪟 🐧 - O ROS MCP Server suporta controle robótico convertendo comandos em linguagem natural emitidos pelo usuário em comandos de controle ROS ou ROS2.
- [jsdelivr/globalping-mcp-server](https://github.com/jsdelivr/globalping-mcp-server) 🎖️ 📇 ☁️ - O servidor Globalping MCP permite aos usuários e LLMs executar ferramentas de rede como ping, traceroute, mtr, HTTP e DNS resolve de milhares de localidades ao redor do mundo.
- [posthog/mcp](https://github.com/posthog/mcp) 🎖️ 📇 ☁️ - Um servidor MCP para interagir com analytics do PostHog, feature flags, rastreamento de erros e mais.
- [artmann/package-registry-mcp](https://github.com/artmann/package-registry-mcp) 🏠 📇 🍎 🪟 🐧 - Servidor MCP para buscar e obter informações atualizadas sobre pacotes NPM, Cargo, PyPi e NuGet.

### 🔒 <a name="delivery"></a>Entrega

- [https://github.com/jordandalton/doordash-mcp-server](https://github.com/JordanDalton/DoorDash-MCP-Server) 🐍 – Entregas DoorDash (Não Oficial)

### 🧮 <a name="data-science-tools"></a>Ferramentas de Ciência de Dados

Integrações e ferramentas projetadas para simplificar a exploração, análise de dados e aprimorar fluxos de trabalho de ciência de dados.

- [ChronulusAI/chronulus-mcp](https://github.com/ChronulusAI/chronulus-mcp) 🐍 ☁️ - Faça previsões com agentes de forecasting e previsão Chronulus AI.
- [reading-plus-ai/mcp-server-data-exploration](https://github.com/reading-plus-ai/mcp-server-data-exploration) 🐍 ☁️ - Permite exploração autônoma de dados em conjuntos .csv, fornecendo insights inteligentes com mínimo esforço.
- [zcaceres/markdownify-mcp](https://github.com/zcaceres/markdownify-mcp) 📇 🏠 - Um servidor MCP para converter quase qualquer arquivo ou conteúdo web em Markdown
- [datalayer/jupyter-mcp-server](https://github.com/datalayer/jupyter-mcp-server) 🐍 🏠 - Servidor Model Context Protocol (MCP) para Jupyter.
- [jjsantos01/jupyter-notebook-mcp](https://github.com/jjsantos01/jupyter-notebook-mcp) 🐍 🏠 - conecta Jupyter Notebook ao Claude AI, permitindo que Claude interaja e controle cadernos Jupyter diretamente.
- [arrismo/kaggle-mcp](https://github.com/arrismo/kaggle-mcp) 🐍 ☁️ - Conecta ao Kaggle, com capacidade de baixar e analisar datasets.
- [kdqed/zaturn](https://github.com/kdqed/zaturn) 🐍 🏠 🪟 🐧 🍎 - Vincule múltiplas fontes de dados (SQL, CSV, Parquet, etc.) e peça para a IA analisar e visualizar os dados.
- [mckinsey/vizro-mcp](https://github.com/mckinsey/vizro/tree/main/vizro-mcp) 🎖️ 🐍 🏠 - Ferramentas e templates para criar gráficos e dashboards de dados validados e sustentáveis.
- [growthbook/growthbook-mcp](https://github.com/growthbook/growthbook-mcp) 🎖️ 📇 🏠 🪟 🐧 🍎 — Ferramentas para criar e interagir com feature flags e experimentos do GrowthBook.

### 📟 <a name="embedded-system"></a>Sistema Embarcado

Fornece acesso a documentação e atalhos para trabalhar em dispositivos embarcados.

- [horw/esp-mcp](https://github.com/horw/esp-mcp) 📟 - Fluxo de trabalho para corrigir problemas de build em chips da série ESP32 usando ESP-IDF.
- [kukapay/modbus-mcp](https://github.com/kukapay/modbus-mcp) 🐍 📟 - Um servidor MCP que padroniza e contextualiza dados industriais Modbus.
- [kukapay/opcua-mcp](https://github.com/kukapay/opcua-mcp) 🐍 📟 - Um servidor MCP que conecta a sistemas industriais com suporte OPC UA.
- [yoelbassin/gnuradioMCP](https://github.com/yoelbassin/gnuradioMCP) 🐍 📟 🏠 - Um servidor MCP para GNU Radio que permite que LLMs criem e modifiquem autonomamente fluxogramas RF `.grc`.

### 📂 <a name="file-systems"></a>Sistemas de Arquivos

Fornece acesso direto ao sistema de arquivos local com permissões configuráveis. Permite que modelos de IA leiam, escrevam e gerenciem arquivos em diretórios especificados.

- [cyberchitta/llm-context.py](https://github.com/cyberchitta/llm-context.py) 🐍 🏠 - Compartilhe contexto de código com LLMs via MCP ou área de transferência
- [exoticknight/mcp-file-merger](https://github.com/exoticknight/mcp-file-merger) 🏎️ 🏠 - Ferramenta de mesclagem de arquivos, adequada para limites de comprimento de chat de IA.
- [filesystem@quarkiverse/quarkus-mcp-servers](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/filesystem) ☕ 🏠 - Um sistema de arquivos que permite navegação e edição de arquivos implementado em Java usando Quarkus. Disponível como jar ou imagem nativa.
- [hmk/box-mcp-server](https://github.com/hmk/box-mcp-server) 📇 ☁️ - Integração com Box para listagem, leitura e busca de arquivos
- [mamertofabian/mcp-everything-search](https://github.com/mamertofabian/mcp-everything-search) 🐍 🏠 🪟 - Busca rápida de arquivos no Windows usando Everything SDK
- [mark3labs/mcp-filesystem-server](https://github.com/mark3labs/mcp-filesystem-server) 🏎️ 🏠 - Implementação em Golang para acesso ao sistema de arquivos local.
- [mickaelkerjean/filestash](https://github.com/mickael-kerjean/filestash/tree/master/server/plugin/plg_handler_mcp) 🏎️ ☁️ - Acesso a armazenamento remoto: SFTP, S3, FTP, SMB, NFS, WebDAV, GIT, FTPS, gcloud, azure blob, sharepoint, etc.
- [microsoft/markitdown](https://github.com/microsoft/markitdown/tree/main/packages/markitdown-mcp) 🎖️ 🐍 🏠 - Ferramenta MCP para acessar o MarkItDown -- uma biblioteca que converte diversos formatos de arquivo (locais ou remotos) em Markdown para consumo por LLM.
- [modelcontextprotocol/server-filesystem](https://github.com/modelcontextprotocol/servers/tree/main/src/filesystem) 📇 🏠 - Acesso direto ao sistema de arquivos local.
- [modelcontextprotocol/server-google-drive](https://github.com/modelcontextprotocol/servers/tree/main/src/gdrive) 📇 ☁️ - Integração com Google Drive para listagem, leitura e busca de arquivos
- [Xuanwo/mcp-server-opendal](https://github.com/Xuanwo/mcp-server-opendal) 🐍 🏠 ☁️ - Acesse qualquer armazenamento com Apache OpenDAL™
- [jeannier/homebrew-mcp](https://github.com/jeannier/homebrew-mcp) 🐍 🏠 🍎 - Controle sua instalação do Homebrew no macOS usando linguagem natural via este servidor MCP. Gerencie seus pacotes facilmente, peça sugestões, solucione problemas do brew, etc.

### 💰 <a name="finance--fintech"></a>Finanças & Fintech

Ferramentas de acesso e análise de dados financeiros. Permite que modelos de IA trabalhem com dados de mercado, plataformas de negociação e informações financeiras.

- [aaronjmars/web3-research-mcp](https://github.com/aaronjmars/web3-research-mcp) 📇 ☁️ - Pesquisa profunda para cripto - gratuito & totalmente local
- [alchemy/alchemy-mcp-server](https://github.com/alchemyplatform/alchemy-mcp-server) 🎖️ 📇 ☁️ - Permite que agentes de IA interajam com as APIs blockchain da Alchemy.
- [OctagonAI/octagon-mcp-server](https://github.com/OctagonAI/octagon-mcp-server) 🐍 ☁️ - Agentes Octagon AI para integrar dados de mercado privados e públicos
- [anjor/coinmarket-mcp-server](https://github.com/anjor/coinmarket-mcp-server) 🐍 ☁️ - Integração com a API Coinmarket para buscar listagens e cotações de criptomoedas
- [ariadng/metatrader-mcp-server](https://github.com/ariadng/metatrader-mcp-server) 🐍 🏠 🪟 - Permite que LLMs de IA executem negociações usando a plataforma MetaTrader 5
- [armorwallet/armor-crypto-mcp](https://github.com/armorwallet/armor-crypto-mcp) 🐍 ☁️ - MCP para interface com múltiplos blockchains, staking, DeFi, swap, bridge, gerenciamento de carteiras, DCA, Ordens Limitadas, consulta de moedas, rastreamento e mais.
- [bankless/onchain-mcp](https://github.com/Bankless/onchain-mcp/) 📇 ☁️ - API Onchain da Bankless para interagir com contratos inteligentes, consultar transações e informações de tokens
- [base/base-mcp](https://github.com/base/base-mcp) 🎖️ 📇 ☁️ - Integração com a Base Network para ferramentas onchain, permitindo interação com Base Network e API Coinbase para gerenciamento de carteiras, transferências de fundos, contratos inteligentes e operações DeFi
- [berlinbra/alpha-vantage-mcp](https://github.com/berlinbra/alpha-vantage-mcp) 🐍 ☁️ - Integração com Alpha Vantage API para buscar informações sobre ações e criptomoedas
- [ahnlabio/bicscan-mcp](https://github.com/ahnlabio/bicscan-mcp) 🎖️ 🐍 ☁️ - Pontuação de risco / saldo de ativos de endereço blockchain EVM (EOA, CA, ENS) e até nomes de domínio.
- [bitteprotocol/mcp](https://github.com/BitteProtocol/mcp) 📇 - Integração com o Bitte Protocol para executar agentes de IA em vários blockchains.
- [chargebee/mcp](https://github.com/chargebee/agentkit/tree/main/modelcontextprotocol) 🎖️ 📇 ☁️ - Servidor MCP que conecta agentes de IA à [plataforma Chargebee](https://www.chargebee.com/).
- [codex-data/codex-mcp](https://github.com/Codex-Data/codex-mcp) 🎖️ 📇 ☁️ - Integração com a [Codex API](https://www.codex.io) para dados blockchain e de mercado enriquecidos em tempo real em 60+ redes
- [coinpaprika/dexpaprika-mcp](https://github.com/chargebee/agentkit/tree/main/modelcontextprotocol) 🎖️ 📇 ☁️ 🍎 🪟 🐧 - O servidor MCP do DexPaprika da Coinpaprika expõe a [API DexPaprika](https://docs.dexpaprika.com) de alta performance cobrindo 20+ chains e 5M+ tokens com preços em tempo real, dados de pools de liquidez & dados históricos OHLCV, fornecendo acesso padronizado para agentes de IA a dados de mercado abrangentes através do Model Context Protocol.
- [doggybee/mcp-server-ccxt](https://github.com/doggybee/mcp-server-ccxt) 📇 ☁️ - Servidor MCP para acessar dados de mercado cripto em tempo real e negociar via 20+ exchanges usando a biblioteca CCXT. Suporta spot, futuros, OHLCV, saldos, ordens e mais.
- [ferdousbhai/investor-agent](https://github.com/ferdousbhai/investor-agent) 🐍 ☁️ - Integração com Yahoo Finance para buscar dados de mercado de ações incluindo recomendações de opções
- [ferdousbhai/tasty-agent](https://github.com/ferdousbhai/tasty-agent) 🐍 ☁️ - Integração com a API Tastyworks para gerenciar operações na Tastytrade
- [ferdousbhai/wsb-analyst-mcp](https://github.com/ferdousbhai/wsb-analyst-mcp) 🐍 ☁️ - Integração com Reddit para analisar conteúdo da comunidade WallStreetBets
- [getalby/nwc-mcp-server](https://github.com/getalby/nwc-mcp-server) 📇 🏠 - Integração com carteira Bitcoin Lightning, alimentada pelo Nostr Wallet Connect
- [heurist-network/heurist-mesh-mcp-server](https://github.com/heurist-network/heurist-mesh-mcp-server) 🎖️ ⛅️ 🏠 🐍 - Acesse agentes de IA web3 especializados para análise blockchain, auditoria de segurança de contratos inteligentes, avaliação de métricas de tokens e interações on-chain através da rede Heurist Mesh. Fornece ferramentas abrangentes para análise DeFi, avaliação de NFTs e monitoramento de transações em múltiplos blockchains
- [intentos-labs/beeper-mcp](https://github.com/intentos-labs/beeper-mcp) 🐍 - Beeper fornece transações na BSC, incluindo transferências de saldo/token, swaps de tokens na Pancakeswap e reivindicações de recompensas beeper.
- [kukapay/blockbeats-mcp](https://github.com/kukapay/blockbeats-mcp) 🐍 ☁️ -  Servidor MCP que entrega notícias de blockchain e artigos aprofundados do BlockBeats para agentes de IA.
- [kukapay/bridge-rates-mcp](https://github.com/kukapay/bridge-rates-mcp) 📇 ☁️ - Entrega taxas de bridge cross-chain em tempo real e rotas de transferência ótimas para agentes de IA onchain.
- [kukapay/chainlink-feeds-mcp](https://github.com/kukapay/chainlink-feeds-mcp) 📇 ☁️ -  Fornecendo acesso em tempo real aos feeds de preços descentralizados da Chainlink.
- [kukapay/cointelegraph-mcp](https://github.com/kukapay/cointelegraph-mcp) 🐍 ☁️ -  Fornecendo acesso em tempo real às últimas notícias do Cointelegraph.
- [kukapay/crypto-feargreed-mcp](https://github.com/kukapay/crypto-feargreed-mcp) 🐍 ☁️ -  Fornecendo dados em tempo real e históricos do Índice de Medo & Ganância de Cripto.
- [kukapay/crypto-indicators-mcp](https://github.com/kukapay/crypto-indicators-mcp) 🐍 ☁️ - Servidor MCP que fornece uma variedade de indicadores de análise técnica e estratégias de criptomoedas.
- [kukapay/crypto-news-mcp](https://github.com/kukapay/crypto-news-mcp) 🐍 ☁️ - Servidor MCP que fornece notícias em tempo real de criptomoedas extraídas do NewsData para agentes de IA.
- [kukapay/crypto-portfolio-mcp](https://github.com/kukapay/crypto-portfolio-mcp) 🐍 ☁️ - Servidor MCP para rastreamento e gerenciamento de alocações de portfólio de criptomoedas.
- [kukapay/crypto-rss-mcp](https://github.com/kukapay/crypto-rss-mcp) 🐍 ☁️ - Servidor MCP que agrega notícias em tempo real de criptomoedas de múltiplos feeds RSS.
- [kukapay/crypto-sentiment-mcp](https://github.com/kukapay/crypto-sentiment-mcp) 🐍 ☁️ - Servidor MCP que fornece análise de sentimento de criptomoedas para agentes de IA.
- [kukapay/crypto-trending-mcp](https://github.com/kukapay/crypto-trending-mcp) 🐍 ☁️ - Rastreamento dos tokens mais populares no CoinGecko.
- [kukapay/crypto-whitepapers-mcp](https://github.com/kukapay/crypto-whitepapers-mcp) 🐍 ☁️ - Servindo como uma base de conhecimento estruturada de whitepapers de criptomoedas.
- [kukapay/cryptopanic-mcp-server](https://github.com/kukapay/cryptopanic-mcp-server) 🐍 ☁️ - Fornecendo as últimas notícias de criptomoedas para agentes de IA, alimentado pelo CryptoPanic.
- [kukapay/defi-yields-mcp](https://github.com/kukapay/defi-yields-mcp) 🐍 ☁️ - Servidor MCP para agentes de IA explorarem oportunidades de rendimento DeFi.
- [kukapay/dune-analytics-mcp](https://github.com/kukapay/dune-analytics-mcp) 🐍 ☁️ -  Servidor MCP que conecta dados do Dune Analytics a agentes de IA.
- [kukapay/etf-flow-mcp](https://github.com/kukapay/etf-flow-mcp) 🐍 ☁️ -  Entregando dados de fluxos de ETF cripto para alimentar a tomada de decisão de agentes de IA.
- [kukapay/freqtrade-mcp](https://github.com/kukapay/freqtrade-mcp) 🐍 ☁️ - Servidor MCP que integra com o robô de trading de criptomoedas Freqtrade.
- [kukapay/funding-rates-mcp](https://github.com/kukapay/funding-rates-mcp) 🐍 ☁️ - Fornecendo dados de funding rates em tempo real nas principais exchanges de cripto.
- [kukapay/jupiter-mcp](https://github.com/kukapay/jupiter-mcp) 🐍 ☁️ - Servidor MCP para executar swaps de tokens na blockchain Solana usando a nova Ultra API do Jupiter.
- [kukapay/pancakeswap-poolspy-mcp](https://github.com/kukapay/pancakeswap-poolspy-mcp) 🐍 ☁️ -  Servidor MCP que rastreia pools recém-criados no Pancake Swap.
- [kukapay/rug-check-mcp](https://github.com/kukapay/rug-check-mcp) 🐍 ☁️ - Servidor MCP que detecta potenciais riscos em tokens meme da Solana.
- [kukapay/thegraph-mcp](https://github.com/kukapay/thegraph-mcp) 🐍 ☁️ -  Servidor MCP que fornece dados indexados de blockchain do The Graph para agentes de IA.
- [kukapay/token-minter-mcp](https://github.com/kukapay/token-minter-mcp) 🐍 ☁️ -  Servidor MCP que oferece ferramentas para agentes de IA criarem tokens ERC-20 em múltiplos blockchains.
- [kukapay/token-revoke-mcp](https://github.com/kukapay/token-revoke-mcp) 🐍 ☁️ - Servidor MCP para checar e revogar permissões de tokens ERC-20 em múltiplos blockchains.
- [kukapay/twitter-username-changes-mcp](https://github.com/kukapay/twitter-username-changes-mcp) 🐍 ☁️ - Servidor MCP que rastreia as mudanças históricas de nomes de usuário do Twitter.
- [kukapay/uniswap-poolspy-mcp](https://github.com/kukapay/uniswap-poolspy-mcp) 🐍 ☁️ -  Servidor MCP que rastreia pools de liquidez recém-criados no Uniswap em múltiplos blockchains.
- [kukapay/uniswap-trader-mcp](https://github.com/kukapay/uniswap-trader-mcp) 🐍 ☁️ -  Servidor MCP para agentes de IA automatizarem swaps de tokens no Uniswap DEX em múltiplos blockchains.
- [kukapay/whale-tracker-mcp](https://github.com/kukapay/whale-tracker-mcp) 🐍 ☁️ -  Servidor MCP para rastrear transações de baleias de criptomoedas.
- [laukikk/alpaca-mcp](https://github.com/laukikk/alpaca-mcp) 🐍 ☁️ - Servidor MCP para a API Alpaca de trading para gerenciar portfólios de ações e cripto, executar negociações e acessar dados de mercado.
- [longportapp/openapi](https://github.com/longportapp/openapi/tree/main/mcp) - 🐍 ☁️ - LongPort OpenAPI fornece dados de mercado de ações em tempo real, acesso de análise de IA e capacidades de negociação via MCP.
- [mcpdotdirect/evm-mcp-server](https://github.com/mcpdotdirect/evm-mcp-server) 📇 ☁️ - Serviços blockchain completos para 30+ redes EVM, suportando tokens nativos, ERC20, NFTs, contratos inteligentes, transações e resolução ENS.
- [mcpdotdirect/starknet-mcp-server](https://github.com/mcpdotdirect/starknet-mcp-server) 📇 ☁️ - Integração completa com a blockchain Starknet com suporte a tokens nativos (ETH, STRK), contratos inteligentes, resolução StarknetID e transferências de tokens.
- [minhyeoky/mcp-server-ledger](https://github.com/minhyeoky/mcp-server-ledger) 🐍 🏠 -  Integração com ledger-cli para gerenciar transações financeiras e gerar relatórios.
- [openMF/mcp-mifosx](https://github.com/openMF/mcp-mifosx) ☁️ 🏠 -  Integração de core banking para gerenciar clientes, empréstimos, poupanças, ações, transações financeiras e gerar relatórios financeiros.
- [narumiruna/yfinance-mcp](https://github.com/narumiruna/yfinance-mcp) 🐍 ☁️ - Servidor MCP que usa yfinance para obter informações do Yahoo Finance.
- [polygon-io/mcp_polygon)](https://github.com/polygon-io/mcp_polygon)) 🐍 ☁️ -  Servidor MCP que fornece acesso às APIs de dados de mercado financeiro da [Polygon.io](https://polygon.io/) para ações, índices, forex, opções e mais.
- [pwh-pwh/coin-mcp-server](https://github.com/pwh-pwh/coin-mcp-server) 🐍 ☁️ -  API Bitget para buscar preço de criptomoedas.
- [QuantGeekDev/coincap-mcp](https://github.com/QuantGeekDev/coincap-mcp) 📇 ☁️ - Integração de dados de mercado de criptomoedas em tempo real usando a API pública do CoinCap, fornecendo acesso a preços e informações de mercado sem chaves de API
- [SaintDoresh/Crypto-Trader-MCP-ClaudeDesktop](https://github.com/SaintDoresh/Crypto-Trader-MCP-ClaudeDesktop.git) 🐍 ☁️ - Ferramenta MCP que fornece dados de mercado de criptomoedas usando a API CoinGecko.
- [tooyipjee/yahoofinance-mcp](https://github.com/tooyipjee/yahoofinance-mcp.git) 📇 ☁️ - Versão TS do mcp yahoo finance.
- [SaintDoresh/YFinance-Trader-MCP-ClaudeDesktop](https://github.com/SaintDoresh/YFinance-Trader-MCP-ClaudeDesktop.git) 🐍 ☁️ - Ferramenta MCP que fornece dados de mercado de ações e análise usando a API Yahoo Finance.
- [RomThpt/xrpl-mcp-server](https://github.com/RomThpt/mcp-xrpl) 📇 ☁️ - Servidor MCP para o XRP Ledger que fornece acesso a informações de conta, histórico de transações e dados de rede. Permite consultar objetos do ledger, enviar transações e monitorar a rede XRPL.
- [janswist/mcp-dexscreener](https://github.com/janswist/mcp-dexscreener) 📇 ☁️ - Preços de mercado on-chain em tempo real usando a API aberta e gratuita Dexscreener
- [HuggingAGI/mcp-baostock-server](https://github.com/HuggingAGI/mcp-baostock-server) 🐍 ☁️ - Servidor MCP baseado em baostock, fornecendo acesso e capacidades de análise para dados do mercado de ações chinês.
- [wowinter13/solscan-mcp](https://github.com/wowinter13/solscan-mcp) 🦀 🏠 - Ferramenta MCP para consultar transações Solana usando linguagem natural com a API Solscan.
- [Wuye-AI/mcp-server-wuye-ai](https://github.com/wuye-ai/mcp-server-wuye-ai) 🎖️ 📇 ☁️ - Servidor MCP que interage com capacidades da plataforma CRIC Wuye AI, um assistente inteligente especificamente para o setor de gestão imobiliária.
- [zlinzzzz/finData-mcp-server](https://github.com/zlinzzzz/finData-mcp-server) 🐍 ☁️ - Servidor MCP para acesso a dados financeiros profissionais, suportando múltiplos fornecedores de dados como Tushare.

### 🎮 <a name="gaming"></a>Jogos

Integração com dados relacionados a jogos, engines de jogos e serviços

- [IvanMurzak/Unity-MCP](https://github.com/IvanMurzak/Unity-MCP) #️⃣ 🏠 🍎 🪟 🐧 - Servidor MCP para Unity Editor e para um jogo feito com Unity
- [CoderGamester/mcp-unity](https://github.com/CoderGamester/mcp-unity) #️⃣ 🏠 - Servidor MCP para integração com o motor de jogos Unity3d para desenvolvimento de jogos
- [Coding-Solo/godot-mcp](https://github.com/Coding-Solo/godot-mcp) 📇 🏠 - Servidor MCP para interação com a engine de jogos Godot, fornecendo ferramentas para edição, execução, depuração e gerenciamento de cenas em projetos Godot.
- [pab1ito/chess-mcp](https://github.com/pab1it0/chess-mcp) 🐍 ☁️ - Acesse dados de jogadores do Chess.com, registros de partidas e outras informações públicas por interfaces MCP padronizadas, permitindo que assistentes de IA busquem e analisem informações de xadrez.
- [jiayao/mcp-chess](https://github.com/jiayao/mcp-chess) 🐍 🏠 - Servidor MCP jogando xadrez contra LLMs.
- [rishijatia/fantasy-pl-mcp](https://github.com/rishijatia/fantasy-pl-mcp/) 🐍 ☁️ - Servidor MCP para dados em tempo real da Fantasy Premier League e ferramentas de análise.
- [opgginc/opgg-mcp](https://github.com/opgginc/opgg-mcp) 📇 ☁️ - Acesse dados de jogos em tempo real de títulos populares como League of Legends, TFT e Valorant, oferecendo análises de campeões, cronogramas de esports, composições meta e estatísticas de personagens.
- [stefan-xyz/mcp-server-runescape](https://github.com/stefan-xyz/mcp-server-runescape) 📇 - Servidor MCP com ferramentas para interação com dados de RuneScape (RS) e Old School RuneScape (OSRS), incluindo preços de itens, hiscores de jogadores e mais.

### 🧠 <a name="knowledge--memory"></a>Conhecimento & Memória

Armazenamento persistente de memória usando estruturas de grafo de conhecimento. Permite que modelos de IA mantenham e consultem informações estruturadas entre sessões.
- [CheMiguel23/MemoryMesh](https://github.com/CheMiguel23/MemoryMesh) 📇 🏠 - Memória aprimorada baseada em grafos com foco em role-play de IA e geração de histórias
- [graphlit-mcp-server](https://github.com/graphlit/graphlit-mcp-server) 📇 ☁️ - Ingira qualquer coisa do Slack, Discord, sites, Google Drive, Linear ou GitHub em um projeto Graphlit - e então pesquise e recupere conhecimento relevante dentro de um cliente MCP como Cursor, Windsurf ou Cline.
- [hannesrudolph/mcp-ragdocs](https://github.com/hannesrudolph/mcp-ragdocs) 🐍 🏠 - Uma implementação de servidor MCP que fornece ferramentas para recuperação e processamento de documentação através de busca vetorial, permitindo que assistentes de IA aumentem suas respostas com contexto documental relevante.
- [jinzcdev/markmap-mcp-server](https://github.com/jinzcdev/markmap-mcp-server) 📇 🏠 - Um servidor MCP baseado no [markmap](https://github.com/markmap/markmap) que converte **Markdown** em **mapas mentais** interativos. Suporta exportações em vários formatos (PNG/JPG/SVG), pré-visualização ao vivo no navegador, cópia de Markdown com um clique e recursos dinâmicos de visualização.
- [kaliaboi/mcp-zotero](https://github.com/kaliaboi/mcp-zotero) 📇 ☁️ - Um conector para LLMs trabalharem com coleções e fontes no seu Zotero Cloud
- [mcp-summarizer](https://github.com/0xshellming/mcp-summarizer) 📕 ☁️ - Servidor MCP de sumarização por IA, suporte a múltiplos tipos de conteúdo: texto simples, páginas web, documentos PDF, livros EPUB, conteúdo HTML
- [mem0ai/mem0-mcp](https://github.com/mem0ai/mem0-mcp) 🐍 🏠 - Um servidor Model Context Protocol para Mem0 que ajuda a gerenciar preferências e padrões de codificação, fornecendo ferramentas para armazenar, recuperar e lidar semanticamente com implementações de código, melhores práticas e documentação técnica em IDEs como Cursor e Windsurf
- [modelcontextprotocol/server-memory](https://github.com/modelcontextprotocol/servers/tree/main/src/memory) 📇 🏠 - Sistema de memória persistente baseado em grafo de conhecimento para manutenção de contexto
- [pinecone-io/assistant-mcp](https://github.com/pinecone-io/assistant-mcp) 🎖️ 🦀 ☁️ - Conecta-se ao seu Pinecone Assistant e fornece contexto ao agente a partir do seu mecanismo de conhecimento.
- [@ragieai/mcp-server](https://github.com/ragieai/ragie-mcp-server) 📇 ☁️ - Recupera contexto da sua base de conhecimento [Ragie](https://www.ragie.ai) (RAG) conectada a integrações como Google Drive, Notion, JIRA e mais.
- [TechDocsStudio/biel-mcp](https://github.com/TechDocsStudio/biel-mcp) 📇 ☁️ - Permite que ferramentas de IA como Cursor, VS Code ou Claude Desktop respondam perguntas usando sua documentação de produto. Biel.ai fornece o sistema RAG e o servidor MCP.
- [topoteretes/cognee](https://github.com/topoteretes/cognee/tree/dev/cognee-mcp) 📇 🏠 - Gerenciador de memória para apps e agentes de IA usando vários armazenamentos de grafos e vetores, permitindo ingestão de mais de 30 fontes de dados
- [unibaseio/membase-mcp](https://github.com/unibaseio/membase-mcp) 📇 ☁️ - Salve e consulte a memória do seu agente de forma distribuída via Membase
- [GistPad-MCP](https://github.com/lostintangent/gistpad-mcp) 📇 🏠 - Use GitHub Gists para gerenciar e acessar seu conhecimento pessoal, notas diárias e prompts reutilizáveis. Atua como um complemento para https://gistpad.dev e a [extensão GistPad para VS Code](https://aka.ms/gistpad).
- [entanglr/zettelkasten-mcp](https://github.com/entanglr/zettelkasten-mcp) 🐍 🏠 - Um servidor Model Context Protocol (MCP) que implementa a metodologia de gestão de conhecimento Zettelkasten, permitindo criar, vincular e pesquisar notas atômicas via Claude e outros clientes compatíveis com MCP.

### 🗺️ <a name="location-services"></a>Serviços de Localização

Serviços baseados em localização e ferramentas de mapeamento. Permite que modelos de IA trabalhem com dados geográficos, informações meteorológicas e análises baseadas em localização.

- [briandconnelly/mcp-server-ipinfo](https://github.com/briandconnelly/mcp-server-ipinfo) 🐍 ☁️  - Geolocalização de endereço IP e informações de rede usando a API IPInfo
- [devilcoder01/weather-mcp-server](https://github.com/devilcoder01/weather-mcp-server) 🐍 ☁️ - Acesse dados meteorológicos em tempo real para qualquer local usando a API WeatherAPI.com, fornecendo previsões detalhadas e condições atuais.
- [jagan-shanmugam/open-streetmap-mcp](https://github.com/jagan-shanmugam/open-streetmap-mcp) 🐍 🏠 - Um servidor MCP OpenStreetMap com serviços baseados em localização e dados geoespaciais.
- [kukapay/nearby-search-mcp](https://github.com/kukapay/nearby-search-mcp) 🐍 ☁️ - Um servidor MCP para buscas de locais próximos com detecção de localização baseada em IP.
- [modelcontextprotocol/server-google-maps](https://github.com/modelcontextprotocol/servers/tree/main/src/google-maps) 📇 ☁️ - Integração com Google Maps para serviços de localização, rotas e detalhes de lugares
- [QGIS MCP](https://github.com/jjsantos01/qgis_mcp) - conecta o QGIS Desktop ao Claude AI através do MCP. Essa integração permite criação de projetos assistida por prompt, carregamento de camadas, execução de código e mais.
- [SaintDoresh/Weather-MCP-ClaudeDesktop](https://github.com/SaintDoresh/Weather-MCP-ClaudeDesktop.git) 🐍 ☁️ - Ferramenta MCP que fornece dados meteorológicos em tempo real, previsões e informações históricas usando a API OpenWeatherMap.
- [rossshannon/Weekly-Weather-mcp](https://github.com/rossshannon/weekly-weather-mcp.git) 🐍 ☁️ - Servidor MCP Weekly Weather que retorna 7 dias completos de previsões meteorológicas detalhadas em qualquer lugar do mundo.
- [SecretiveShell/MCP-timeserver](https://github.com/SecretiveShell/MCP-timeserver) 🐍 🏠 - Acesse o horário em qualquer fuso horário e obtenha a hora local atual
- [TimLukaHorstmann/mcp-weather](https://github.com/TimLukaHorstmann/mcp-weather) 📇 ☁️  - Previsões meteorológicas precisas via API AccuWeather (plano gratuito disponível).
- [webcoderz/MCP-Geo](https://github.com/webcoderz/MCP-Geo) 🐍 🏠 - Servidor MCP de geocodificação para nominatim, ArcGIS, Bing
- [ipfind/ipfind-mcp-server](https://github.com/ipfind/ipfind-mcp-server) 🐍 ☁️ - Serviço de localização de endereço IP usando a API [IP Find](https://ipfind.com)
- [mahdin75/geoserver-mcp](https://github.com/mahdin75/geoserver-mcp) 🏠 – Implementação de servidor Model Context Protocol (MCP) que conecta LLMs à API REST do GeoServer, permitindo que assistentes de IA interajam com dados e serviços geoespaciais.
- [ipfred/aiwen-mcp-server-geoip](https://github.com/ipfred/aiwen-mcp-server-geoip) 🐍 📇 ☁️ – Servidor MCP para Aiwen IP Location, obtém localização de IP de rede do usuário, detalhes de IP (país, estado, cidade, lat, lon, ISP, proprietário, etc.)

### 🎯 <a name="marketing"></a>Marketing

Ferramentas para criar e editar conteúdo de marketing, trabalhar com metadados da web, posicionamento de produto e guias de edição.

- [gomarble-ai/facebook-ads-mcp-server](https://github.com/gomarble-ai/facebook-ads-mcp-server) 🐍 ☁️ - Servidor MCP atuando como interface para o Facebook Ads, permitindo acesso programático aos dados e recursos de gerenciamento de anúncios do Facebook.
- [open-strategy-partners/osp_marketing_tools](https://github.com/open-strategy-partners/osp_marketing_tools) 🐍 🏠 - Um conjunto de ferramentas de marketing da Open Strategy Partners incluindo estilo de escrita, códigos de edição e criação de mapa de valor de marketing de produto.
- [nictuku/meta-ads-mcp](https://github.com/nictuku/meta-ads-mcp) 🐍 ☁️ 🏠 - Permite que agentes de IA monitorem e otimizem o desempenho de anúncios Meta, analisem métricas de campanhas, ajustem o público-alvo, gerenciem ativos criativos e façam recomendações baseadas em dados para investimentos e configurações de campanhas por meio de integração transparente com a Graph API.
- [marketplaceadpros/amazon-ads-mcp-server](https://github.com/MarketplaceAdPros/amazon-ads-mcp-server) 📇 ☁️  - Permite que ferramentas interajam com o Amazon Advertising, analisando métricas e configurações de campanhas.

### 📊 <a name="monitoring"></a>Monitoramento

Acesse e analise dados de monitoramento de aplicações. Permite que modelos de IA revisem relatórios de erro e métricas de desempenho.

- [netdata/netdata#Netdata](https://github.com/netdata/netdata/blob/master/src/web/mcp/README.md) 🎖️ 🏠 ☁️ 📟 🍎 🪟 🐧 - Descoberta, exploração, relatórios e análise de causa raiz usando todos os dados de observabilidade, incluindo métricas, logs, sistemas, containers, processos e conexões de rede
- [grafana/mcp-grafana](https://github.com/grafana/mcp-grafana) 🎖️ 🐍 🏠 ☁️ - Busque dashboards, investigue incidentes e consulte fontes de dados em sua instância Grafana
- [tumf/grafana-loki-mcp](https://github.com/tumf/grafana-loki-mcp) 🐍 🏠 - Um servidor MCP que permite consultas a logs Loki através da API do Grafana.
- [hyperb1iss/lucidity-mcp](https://github.com/hyperb1iss/lucidity-mcp) 🐍 🏠 - Melhore a qualidade do código gerado por IA por meio de análise inteligente baseada em prompts em 10 dimensões críticas, desde complexidade até vulnerabilidades de segurança
- [last9/last9-mcp-server](https://github.com/last9/last9-mcp-server) - Traga contexto de produção em tempo real—logs, métricas e traces—para seu ambiente local para corrigir código automaticamente mais rápido
- [metoro-io/metoro-mcp-server](https://github.com/metoro-io/metoro-mcp-server) 🎖️ 🏎️ ☁️ - Consulte e interaja com ambientes kubernetes monitorados pelo Metoro
- [MindscapeHQ/server-raygun](https://github.com/MindscapeHQ/mcp-server-raygun) 📇 ☁️ - Integração com Raygun API V3 para relatórios de falhas e monitoramento de usuários reais
- [modelcontextprotocol/server-sentry](https://github.com/modelcontextprotocol/servers/tree/main/src/sentry) 🐍 ☁️ - Integração com Sentry.io para rastreamento de erros e monitoramento de desempenho
- [pydantic/logfire-mcp](https://github.com/pydantic/logfire-mcp) 🎖️ 🐍 ☁️ - Fornece acesso a traces e métricas OpenTelemetry através do Logfire
- [seekrays/mcp-monitor](https://github.com/seekrays/mcp-monitor) 🏎️ 🏠 - Ferramenta de monitoramento de sistema que expõe métricas do sistema via Model Context Protocol (MCP). Permite que LLMs obtenham informações do sistema em tempo real via interface compatível com MCP. (suporte a CPU, Memória, Disco, Rede, Host, Processo)
- [VictoriaMetrics-Community/mcp-victoriametrics](https://github.com/VictoriaMetrics-Community/mcp-victoriametrics) 🎖️ 🏎️ 🏠 - Fornece integração abrangente com suas [APIs do VictoriaMetrics](https://docs.victoriametrics.com/victoriametrics/url-examples/) e [documentação](https://docs.victoriametrics.com/) para tarefas de monitoramento, observabilidade e depuração relacionadas às suas instâncias VictoriaMetrics

### 🎥 <a name="multimedia-process"></a>Processamento Multimídia

Fornece a capacidade de lidar com multimídia, como edição de áudio e vídeo, reprodução, conversão de formatos, além de incluir filtros de vídeo, aprimoramentos e outros.

- [video-creator/ffmpeg-mcp](https://github.com/video-creator/ffmpeg-mcp.git) 🎥 🔊 - Usando linha de comando ffmpeg para implementar um servidor mcp, pode ser muito conveniente, permitindo por meio de diálogo realizar busca local de vídeos, corte, junção, reprodução e outras funções
- [stass/exif-mcp](https://github.com/stass/exif-mcp) 📇 🏠 🐧 🍎 🪟 - Um servidor MCP que permite examinar metadados de imagens como EXIF, XMP, JFIF e GPS. Fornece base para busca e análise de bibliotecas de fotos e coleções de imagens alimentadas por LLM.
- [sunriseapps/imagesorcery-mcp](https://github.com/sunriseapps/imagesorcery-mcp) 🐍 🏠 🐧 🍎 🪟 - Ferramentas de reconhecimento e edição de imagens baseadas em ComputerVision para assistentes de IA.

### 🔎 <a name="search"></a>Busca & Extração de Dados

- [Xyber-Labs/mcp-server-youtube](https://github.com/Xyber-Labs/mcp-servers/tree/main/mcp-server-youtube) 🐍 ☁️ - Este repositório implementa um servidor MCP (Model Context Protocol) para busca no YouTube e recuperação de transcrições. Permite que modelos de linguagem ou outros agentes consultem facilmente conteúdos do YouTube via protocolo padronizado.
- [ricocf/mcp-wolframalpha](https://github.com/ricocf/mcp-wolframalpha) 🐍 🏠 ☁️ - Um servidor MCP que permite a assistentes de IA utilizarem a API Wolfram Alpha para acesso em tempo real a conhecimento computacional e dados.
- [scrapeless-ai/scrapeless-mcp-server](https://github.com/scrapeless-ai/scrapeless-mcp-server) 🐍 ☁️ - O serviço Scrapeless Model Context Protocol atua como conector MCP à Google SERP API, permitindo busca na web dentro do ecossistema MCP sem sair dele.
- [0xdaef0f/job-searchoor](https://github.com/0xDAEF0F/job-searchoor) 📇 🏠 - Servidor MCP para busca de vagas de emprego com filtros por data, palavras-chave, opções de trabalho remoto e mais.
- [ac3xx/mcp-servers-kagi](https://github.com/ac3xx/mcp-servers-kagi) 📇 ☁️ - Integração com a API de busca Kagi
- [andybrandt/mcp-simple-arxiv](https://github.com/andybrandt/mcp-simple-arxiv) - 🐍 ☁️  MCP para LLM buscar e ler artigos do arXiv
- [hbg/mcp-paperswithcode](https://github.com/hbg/mcp-paperswithcode) - 🐍 ☁️ MCP para buscar via API PapersWithCode
- [andybrandt/mcp-simple-pubmed](https://github.com/andybrandt/mcp-simple-pubmed) - 🐍 ☁️  MCP para buscar e ler artigos médicos/científicos do PubMed.
- [angheljf/nyt](https://github.com/angheljf/nyt) 📇 ☁️ - Busque artigos usando a API do NYTimes
- [apify/mcp-server-rag-web-browser](https://github.com/apify/mcp-server-rag-web-browser) 📇 ☁️ - Um servidor MCP para o RAG Web Browser Actor open-source da Apify para realizar buscas na web, raspar URLs e retornar conteúdo em Markdown.
- [Bigsy/Clojars-MCP-Server](https://github.com/Bigsy/Clojars-MCP-Server) 📇 ☁️ - Servidor MCP do Clojars para informações atualizadas de dependências de bibliotecas Clojure
- [blazickjp/arxiv-mcp-server](https://github.com/blazickjp/arxiv-mcp-server) ☁️ 🐍 - Busque artigos de pesquisa do ArXiv
- [luminati-io/brightdata-mcp](https://github.com/luminati-io/brightdata-mcp) 📇 ☁️ - Descubra, extraia e interaja com a web - uma interface para acesso automatizado em toda a internet pública.
- [chanmeng/google-news-mcp-server](https://github.com/ChanMeng666/server-google-news) 📇 ☁️ - Integração com o Google News com categorização automática de tópicos, suporte multilíngue e busca abrangente incluindo manchetes, notícias e tópicos relacionados via [SerpAPI](https://serpapi.com/).
- [ConechoAI/openai-websearch-mcp](https://github.com/ConechoAI/openai-websearch-mcp/) 🐍 🏠 ☁️ - Servidor MCP em Python que fornece a ferramenta integrada `web_search` do OpenAI.
- [dealx/mcp-server](https://github.com/DealExpress/mcp-server) ☁️ - Servidor MCP para a plataforma DealX
- [devflowinc/trieve](https://github.com/devflowinc/trieve/tree/main/clients/mcp-server) 🎖️ 📇 ☁️ 🏠 - Rastreie, embaralhe, fragmente, busque e recupere informações de conjuntos de dados via [Trieve](https://trieve.ai)
- [Dumpling-AI/mcp-server-dumplingai](https://github.com/Dumpling-AI/mcp-server-dumplingai) 🎖️ 📇 ☁️ - Acesse dados, APIs de web scraping e conversão de documentos pelo [Dumpling AI](https://www.dumplingai.com/)
- [erithwik/mcp-hn](https://github.com/erithwik/mcp-hn) 🐍 ☁️ - Servidor MCP para buscar notícias do Hacker News, obter as principais histórias e mais.
- [exa-labs/exa-mcp-server](https://github.com/exa-labs/exa-mcp-server) 🎖️ 📇 ☁️ – Um servidor Model Context Protocol (MCP) que permite que assistentes de IA como Claude utilizem a Exa AI Search API para buscas na web. Este setup permite que modelos de IA obtenham informações web em tempo real de forma segura e controlada.
- [fatwang2/search1api-mcp](https://github.com/fatwang2/search1api-mcp) 📇 ☁️ - Busca via search1api (requer chave API paga)
- [genomoncology/biomcp](https://github.com/genomoncology/biomcp) 🐍 ☁️ - Servidor de pesquisa biomédica fornecendo acesso ao PubMed, ClinicalTrials.gov e MyVariant.info.
- [hellokaton/unsplash-mcp-server](https://github.com/hellokaton/unsplash-mcp-server)) 🐍 ☁️ - Servidor MCP para busca de imagens no Unsplash.
- [Ihor-Sokoliuk/MCP-SearXNG](https://github.com/ihor-sokoliuk/mcp-searxng) 📇 🏠/☁️ - Servidor Model Context Protocol para [SearXNG](https://docs.searxng.org)
- [isnow890/naver-search-mcp](https://github.com/isnow890/naver-search-mcp) 📇 ☁️ - Servidor MCP para integração com a Naver Search API, suportando busca em blogs, notícias, compras e recursos de análise do DataLab.
- [jae-jae/fetcher-mcp](https://github.com/jae-jae/fetcher-mcp) 📇 🏠 - Servidor MCP para buscar conteúdo de páginas web usando Playwright headless browser, com suporte a renderização Javascript e extração inteligente de conteúdo, saídas em Markdown ou HTML.
- [jae-jae/g-search-mcp](https://github.com/jae-jae/g-search-mcp) 📇 🏠 - Um poderoso servidor MCP para busca Google que permite buscas paralelas com múltiplas palavras-chave simultaneamente.
- [ananddtyagi/webpage-screenshot-mcp](https://github.com/ananddtyagi/webpage-screenshot-mcp) 📇 🏠 - Servidor MCP para capturar screenshots de páginas web para usar como feedback durante o desenvolvimento de UI.
- [leehanchung/bing-search-mcp](https://github.com/leehanchung/bing-search-mcp) 📇 ☁️ - Capacidades de busca web usando a API Microsoft Bing Search
- [kagisearch/kagimcp](https://github.com/kagisearch/kagimcp) ☁️ 📇 – Servidor oficial Kagi Search MCP
- [kshern/mcp-tavily](https://github.com/kshern/mcp-tavily.git) ☁️ 📇 – Tavily API de busca em IA
- [mikechao/brave-search-mcp](https://github.com/mikechao/brave-search-mcp) 📇 ☁️ - Capacidades de busca na Web, Imagens, Notícias, Vídeos e Pontos de Interesse Local usando a API de Busca do Brave
- [emicklei/melrose-mcp](https://github.com/emicklei/melrose-mcp) 🏎️ 🏠 - Toca expressões musicais do [Melrōse](https://melrōse.org) como MIDI
- [modelcontextprotocol/server-brave-search](https://github.com/modelcontextprotocol/servers/tree/main/src/brave-search) 📇 ☁️ - Capacidades de busca na Web usando a API de Busca do Brave
- [modelcontextprotocol/server-fetch](https://github.com/modelcontextprotocol/servers/tree/main/src/fetch) 🐍 🏠 ☁️ - Busca e processamento eficiente de conteúdo web para consumo por IA
- [mzxrai/mcp-webresearch](https://github.com/mzxrai/mcp-webresearch) 🔍📚 - Pesquisa no Google e realiza pesquisa profunda na web sobre qualquer tópico
- [nickclyde/duckduckgo-mcp-server](https://github.com/nickclyde/duckduckgo-mcp-server) 🐍 ☁️ - Busca na web usando DuckDuckGo
- [r-huijts/opentk-mcp](https://github.com/r-huijts/opentk-mcp) 📇 ☁️ - Acessa informações do Parlamento Holandês (Tweede Kamer), incluindo documentos, debates, atividades e casos legislativos através de capacidades de busca estruturada (baseado no projeto opentk de Bert Hubert)
- [reading-plus-ai/mcp-server-deep-research](https://github.com/reading-plus-ai/mcp-server-deep-research) 📇 ☁️ - Servidor MCP que fornece pesquisa profunda autônoma no estilo OpenAI/Perplexity, elaboração de consultas estruturadas e relatórios concisos.
- [SecretiveShell/MCP-searxng](https://github.com/SecretiveShell/MCP-searxng) 🐍 🏠 - Um servidor MCP para conectar a instâncias do searXNG
- [takashiishida/arxiv-latex-mcp](https://github.com/takashiishida/arxiv-latex-mcp) 🐍 ☁️ - Obtém o código LaTeX de artigos do arXiv para lidar com conteúdo e equações matemáticas
- [the0807/GeekNews-MCP-Server](https://github.com/the0807/GeekNews-MCP-Server) 🐍 ☁️ - Um servidor MCP que recupera e processa dados de notícias do site GeekNews.
- [tinyfish-io/agentql-mcp](https://github.com/tinyfish-io/agentql-mcp) 🎖️ 📇 ☁️ - Servidor MCP que fornece as capacidades de extração de dados do [AgentQL](https://agentql.com).
- [Tomatio13/mcp-server-tavily](https://github.com/Tomatio13/mcp-server-tavily) ☁️ 🐍 – Tavily API de busca em IA
- [vectorize-io/vectorize-mcp-server](https://github.com/vectorize-io/vectorize-mcp-server/) ☁️ 📇 - Servidor MCP do [Vectorize](https://vectorize.io) para recuperação avançada, Pesquisa Profunda Privada, extração de arquivos Anything-to-Markdown e divisão de texto em blocos.
- [webscraping-ai/webscraping-ai-mcp-server](https://github.com/webscraping-ai/webscraping-ai-mcp-server) 🎖️ 📇 ☁️ - Interage com o [WebScraping.ai](https://webscraping.ai) para extração e raspagem de dados web.
- [zhsama/duckduckgo-mcp-server](https://github.com/zhsama/duckduckgo-mpc-server/) 📇 🏠 ☁️ - Servidor MCP baseado em TypeScript que fornece funcionalidade de busca DuckDuckGo.
- [zoomeye-ai/mcp_zoomeye](https://github.com/zoomeye-ai/mcp_zoomeye) 📇 ☁️ - Consulta informações de ativos de rede via ZoomEye MCP Server
- [yamanoku/baseline-mcp-server](https://github.com/yamanoku/baseline-mcp-server) 📇 🏠 - Servidor MCP que pesquisa o status do Baseline usando a Web Platform API
- [longevity-genie/biothings-mcp](https://github.com/longevity-genie/biothings-mcp) 🐍 ☁️ - Servidor MCP para interagir com a API BioThings, incluindo genes, variantes genéticas, medicamentos e informações taxonômicas
- [joelio/stocky](https://github.com/joelio/stocky) 🐍 ☁️ 🏠 - Um servidor MCP para pesquisar e baixar fotografias de banco de imagens royalty-free do Pexels e Unsplash. Possui busca multiprovedores, metadados ricos, suporte a paginação e desempenho assíncrono para assistentes de IA encontrarem e acessarem imagens de alta qualidade.

### 🔒 <a name="security"></a>Segurança

- [LaurieWired/GhidraMCP](https://github.com/LaurieWired/GhidraMCP) ☕ 🏠 - Um servidor Model Context Protocol para o Ghidra que permite LLMs fazerem engenharia reversa autônoma de aplicações. Fornece ferramentas para descompilar binários, renomear métodos e dados, e listar métodos, classes, imports e exports.
- [dkvdm/onepassword-mcp-server](https://github.com/dkvdm/onepassword-mcp-server) - Um servidor MCP que permite a recuperação segura de credenciais do 1Password para uso por IA Agentes.
- [firstorderai/authenticator_mcp](https://github.com/firstorderai/authenticator_mcp) 📇 🏠 🍎 🪟 🐧 – Um servidor MCP seguro (Model Context Protocol) que permite agentes de IA interagirem com o aplicativo Authenticator.
- [13bm/GhidraMCP](https://github.com/13bm/GhidraMCP) 🐍 ☕ 🏠 - Servidor MCP para integração do Ghidra com assistentes de IA. Este plugin permite análise binária, fornecendo ferramentas para inspeção de funções, descompilação, exploração de memória e análise de importação/exportação via Model Context Protocol.
- [atomicchonk/roadrecon_mcp_server](https://github.com/atomicchonk/roadrecon_mcp_server) 🐍 🪟 🏠 Servidor MCP para analisar resultados do ROADrecon de enumeração de tenants Azure
- [BurtTheCoder/mcp-dnstwist](https://github.com/BurtTheCoder/mcp-dnstwist) 📇 🪟 ☁️ - Servidor MCP para dnstwist, uma poderosa ferramenta de fuzzing DNS que ajuda a detectar typosquatting, phishing e espionagem corporativa.
- [BurtTheCoder/mcp-maigret](https://github.com/BurtTheCoder/mcp-maigret) 📇 🪟 ☁️ - Servidor MCP para maigret, uma poderosa ferramenta OSINT que coleta informações de contas de usuários em diversas fontes públicas. Este servidor fornece ferramentas para buscar nomes de usuários em redes sociais e analisar URLs.
- [BurtTheCoder/mcp-shodan](https://github.com/BurtTheCoder/mcp-shodan) 📇 🪟 ☁️ - Servidor MCP para consultar a API Shodan e Shodan CVEDB. Este servidor fornece ferramentas para buscas de IP, pesquisas de dispositivos, buscas de DNS, consultas de vulnerabilidades, buscas de CPE e mais.
- [BurtTheCoder/mcp-virustotal](https://github.com/BurtTheCoder/mcp-virustotal) 📇 🪟 ☁️ - Servidor MCP para consultar a API VirusTotal. Este servidor fornece ferramentas para escanear URLs, analisar hashes de arquivos e recuperar relatórios de endereços IP.
- [fosdickio/binary_ninja_mcp](https://github.com/fosdickio/binary_ninja_mcp) 🐍 🏠 🍎 🪟 🐧 - Plugin Binary Ninja, servidor MCP e ponte que integra o [Binary Ninja](https://binary.ninja) ao seu cliente MCP favorito. Permite automatizar o processo de análise binária e engenharia reversa.
- [fr0gger/MCP_Security](https://github.com/fr0gger/MCP_Security) 📇 ☁️ - Servidor MCP para consultar a API ORKL. Este servidor fornece ferramentas para buscar relatórios de ameaças, analisar atores de ameaças e recuperar fontes de inteligência.
- [gbrigandi/mcp-server-cortex](https://github.com/gbrigandi/mcp-server-cortex) 🦀 🏠 🚨 🍎 🪟 🐧 - Servidor MCP em Rust para integrar Cortex, permitindo análise de observáveis e respostas automáticas de segurança via IA.
- [gbrigandi/mcp-server-thehive](https://github.com/gbrigandi/mcp-server-thehive) 🦀 🏠 🚨 🍎 🪟 🐧 - Servidor MCP em Rust para integrar TheHive, facilitando resposta colaborativa a incidentes de segurança e gerenciamento de casos via IA.
- [gbrigandi/mcp-server-wazuh](https://github.com/gbrigandi/mcp-server-wazuh) 🦀 🏠 🚨 🍎 🪟 🐧 - Servidor MCP em Rust conectando o Wazuh SIEM a assistentes de IA, fornecendo alertas de segurança em tempo real e dados de eventos para maior compreensão contextual.
- [intruder-io/intruder-mcp](https://github.com/intruder-io/intruder-mcp) 🐍 ☁️ - Servidor MCP para acessar o [Intruder](https://www.intruder.io/), ajudando você a identificar, entender e corrigir vulnerabilidades de segurança em sua infraestrutura.
- [jyjune/mcp_vms](https://github.com/jyjune/mcp_vms) 🐍 🏠 🪟 - Um servidor Model Context Protocol (MCP) projetado para conectar a um programa de gravação CCTV (VMS) para recuperar vídeos gravados e transmissões ao vivo. Também fornece ferramentas para controlar o software VMS, como exibir diálogos ao vivo ou reprodução para canais específicos em horários determinados.
- [qianniuspace/mcp-security-audit](https://github.com/qianniuspace/mcp-security-audit) 📇 ☁️ Um poderoso servidor MCP (Model Context Protocol) que audita dependências de pacotes npm para vulnerabilidades de segurança. Desenvolvido com integração ao registro npm remoto para verificações de segurança em tempo real.
- [semgrep/mcp](https://github.com/semgrep/mcp) 📇 ☁️ Permite que agentes de IA escaneiem códigos em busca de vulnerabilidades de segurança usando o [Semgrep](https://semgrep.dev).
- [slouchd/cyberchef-api-mcp-server](https://github.com/slouchd/cyberchef-api-mcp-server) 🐍 ☁️ - Servidor MCP para interagir com a API do servidor CyberChef, permitindo que um cliente MCP utilize as operações do CyberChef.
- [mrexodia/ida-pro-mcp](https://github.com/mrexodia/ida-pro-mcp) 🐍 🏠 - Servidor MCP para IDA Pro, permitindo realizar análise binária com assistentes de IA. Este plugin implementa descompilação, desmontagem e permite gerar relatórios automáticos de análise de malware.
- [rad-security/mcp-server](https://github.com/rad-security/mcp-server) 📇 ☁️ - Servidor MCP para RAD Security, fornecendo insights de segurança baseados em IA para Kubernetes e ambientes de nuvem. Fornece ferramentas para consultar a API Rad Security e recuperar achados de segurança, relatórios, dados de runtime e mais.
- [securityfortech/secops-mcp](https://github.com/securityfortech/secops-mcp) 🐍 🏠 - Toolbox de testes de segurança tudo-em-um que reúne ferramentas open source populares através de uma única interface MCP. Conectado a um agente IA, permite tarefas como pentest, bug bounty, threat hunting e mais.
- [roadwy/cve-search_mcp](https://github.com/roadwy/cve-search_mcp) 🐍 🏠 - Um servidor Model Context Protocol (MCP) para consultar a API CVE-Search. Fornece acesso abrangente ao CVE-Search, navegação por fornecedor/produto, busca por CVE-ID, últimas CVEs atualizadas.
- [StacklokLabs/osv-mcp](https://github.com/StacklokLabs/osv-mcp) 🏎️ ☁️ - Acesse o banco de dados OSV (Open Source Vulnerabilities) para informações de vulnerabilidade. Consulta por versão de pacote, commit, consulta em lote de múltiplos pacotes e informações detalhadas por ID.
- [nickpending/mcp-recon](https://github.com/nickpending/mcp-recon) 🏎️ 🏠 - Interface de reconhecimento conversacional e servidor MCP alimentado por httpx e asnmap. Suporta vários níveis de reconhecimento para análise de domínio, inspeção de cabeçalhos de segurança, análise de certificados e lookup ASN.
- [Gaffx/volatility-mcp](https://github.com/Gaffx/volatility-mcp) - Servidor MCP para Volatility 3.x, permitindo análise de forense de memória com assistente de IA. Experimente análise de memória sem barreiras com plugins como pslist e netscan acessíveis via APIs REST limpas e LLMs.
- [co-browser/attestable-mcp-server](https://github.com/co-browser/attestable-mcp-server) 🐍 🏠 ☁️ 🐧 - Um servidor MCP rodando em ambiente de execução confiável (TEE) via Gramine, demonstrando atestação remota usando [RA-TLS](https://gramine.readthedocs.io/en/stable/attestation.html). Permite que um cliente MCP verifique o servidor antes de conectar.
- [zinja-coder/jadx-ai-mcp](https://github.com/zinja-coder/jadx-ai-mcp) ☕ 🏠 - JADX-AI-MCP é um plugin e servidor MCP para o decompilador JADX que integra diretamente ao Model Context Protocol (MCP) para suporte de engenharia reversa ao vivo com LLMs como Claude.
- [zinja-coder/apktool-mcp-server](https://github.com/zinja-coder/apktool-mcp-server) 🐍 🏠 - APKTool MCP Server é um servidor MCP para o Apk Tool, proporcionando automação na engenharia reversa de APKs Android.

### 🌐 <a name="social-media"></a>Mídias Sociais

Integração com plataformas de mídias sociais para permitir postagem, análise e gerenciamento de interações. Permite automação orientada por IA para presença social.

- [macrocosm-os/macrocosmos-mcp](https://github.com/macrocosm-os/macrocosmos-mcp) - 🎖️ 🐍 ☁️ Acesse dados em tempo real de X/Reddit/YouTube diretamente em suas aplicações LLM com frases de busca, usuários e filtragem por data.
- [kunallunia/twitter-mcp](https://github.com/LuniaKunal/mcp-twitter) 🐍 🏠 - Solução completa de gerenciamento do Twitter fornecendo acesso à timeline, recuperação de tweets de usuários, monitoramento de hashtags, análise de conversas, mensagens diretas, análise de sentimento de postagens e controle completo do ciclo de vida de posts - tudo via API simplificada.
- [HagaiHen/facebook-mcp-server](https://github.com/HagaiHen/facebook-mcp-server) 🐍 ☁️ - Integra com Páginas do Facebook para permitir o gerenciamento direto de postagens, comentários e métricas de engajamento através da Graph API para gestão de mídias sociais.
- [gwbischof/bluesky-social-mcp](https://github.com/gwbischof/bluesky-social-mcp) 🐍 🏠 - Um servidor MCP para interagir com o Bluesky via cliente atproto.


### 🏃 <a name="sports"></a>Esportes

Ferramentas para acessar dados, resultados e estatísticas relacionadas a esportes.

- [mikechao/balldontlie-mcp](https://github.com/mikechao/balldontlie-mcp) 📇 - Servidor MCP que integra a API balldontlie para fornecer informações sobre jogadores, times e jogos da NBA, NFL e MLB
- [r-huijts/firstcycling-mcp](https://github.com/r-huijts/firstcycling-mcp) 📇 ☁️ - Acesse dados de corridas de ciclismo, resultados e estatísticas por linguagem natural. Permite recuperar listas de largada, resultados de corridas e informações de ciclistas do firstcycling.com.
- [r-huijts/strava-mcp](https://github.com/r-huijts/strava-mcp) 📇 ☁️ - Um servidor Model Context Protocol (MCP) que conecta à API Strava, fornecendo ferramentas para acessar dados do Strava via LLMs
- [willvelida/mcp-afl-server](https://github.com/willvelida/mcp-afl-server) ☁️ - Servidor MCP que integra a API Squiggle para fornecer informações sobre times da Australian Football League, classificação, resultados, dicas e rankings.
- [guillochon/mlb-api-mcp](https://github.com/guillochon/mlb-api-mcp) 🐍 🏠 - Servidor MCP que atua como proxy para a API MLB gratuita, fornecendo informações de jogadores, estatísticas e jogos.

### 🎧 <a name="support-and-service-management"></a>Suporte & Gestão de Serviços

Ferramentas para gerenciamento de suporte ao cliente, gerenciamento de serviços de TI e operações de helpdesk.

- [effytech/freshdesk-mcp](https://github.com/effytech/freshdesk_mcp) 🐍 ☁️ - Servidor MCP que integra com o Freshdesk, permitindo que modelos de IA interajam com módulos do Freshdesk e realizem várias operações de suporte.
- [nguyenvanduocit/jira-mcp](https://github.com/nguyenvanduocit/jira-mcp) 🏎️ ☁️ - Um conector MCP em Go para o Jira que permite que assistentes de IA como o Claude interajam com o Atlassian Jira. Fornece interface sem atrito para modelos de IA executarem operações comuns do Jira, incluindo gestão de issues, planejamento de sprints e transições de workflow.
- [sooperset/mcp-atlassian](https://github.com/sooperset/mcp-atlassian) 🐍 ☁️ - Servidor MCP para produtos Atlassian (Confluence e Jira). Suporta Confluence Cloud, Jira Cloud e Jira Server/Data Center. Fornece ferramentas abrangentes para busca, leitura, criação e gerenciamento de conteúdo em workspaces Atlassian.

### 🌎 <a name="translation-services"></a>Serviços de Tradução

Ferramentas e serviços de tradução para permitir que assistentes de IA traduzam conteúdo entre diferentes idiomas.

- [translated/lara-mcp](https://github.com/translated/lara-mcp) 🎖️ 📇 ☁️ - Servidor MCP para a API Lara Translate, permitindo capacidades poderosas de tradução com suporte a detecção de idioma e traduções contextuais.
- [mmntm/weblate-mcp](https://github.com/mmntm/weblate-mcp) 📇 ☁️ - Servidor Model Context Protocol abrangente para gerenciamento de traduções Weblate, permitindo que assistentes de IA realizem tarefas de tradução, gestão de projetos e descoberta de conteúdo com transformações inteligentes de formato.

### 🎧 <a name="text-to-speech"></a>Texto para Fala

Ferramentas para converter texto em fala e vice-versa

- [mberg/kokoro-tts-mcp](https://github.com/mberg/kokoro-tts-mcp) 🐍 🏠 - Servidor MCP que utiliza os modelos abertos Kokoro TTS para converter texto em fala. Pode converter texto para MP3 em disco local ou enviar automaticamente para um bucket S3.
- [mbailey/voice-mcp](https://github.com/mbailey/voice-mcp) 🐍 🏠 - Servidor completo de interação por voz com suporte a reconhecimento de fala, texto para fala e conversas de voz em tempo real via microfone local, APIs compatíveis com OpenAI e integração LiveKit

### 🚆 <a name="travel-and-transportation"></a>Viagem & Transporte

Acesso a informações de viagem e transporte. Permite consulta de horários, rotas e dados de viagem em tempo real.
- [Airbnb MCP Server](https://github.com/openbnb-org/mcp-server-airbnb) 📇 ☁️ - Fornece ferramentas para pesquisar no Airbnb e obter detalhes de anúncios.
- [KyrieTangSheng/mcp-server-nationalparks](https://github.com/KyrieTangSheng/mcp-server-nationalparks) 📇 ☁️ - Integração com a API do Serviço Nacional de Parques, fornecendo as informações mais recentes sobre detalhes dos parques, alertas, centros de visitantes, acampamentos e eventos dos Parques Nacionais dos EUA.
- [NS Travel Information MCP Server](https://github.com/r-huijts/ns-mcp-server) 📇 ☁️ - Acesse informações de viagens, horários e atualizações em tempo real da Dutch Railways (NS).
- [pab1it0/tripadvisor-mcp](https://github.com/pab1it0/tripadvisor-mcp) 📇 🐍 - Um servidor MCP que permite que LLMs interajam com a API do Tripadvisor, suportando dados de localização, avaliações e fotos por meio de interfaces MCP padronizadas.
- [lucygoodchild/mcp-national-rail](https://github.com/lucygoodchild/mcp-national-rail) 📇 ☁️ - Um servidor MCP para o serviço de trens National Rail do Reino Unido, fornecendo horários de trens e informações de viagem ao vivo, integrando a API Realtime Trains.

### 🔄 <a name="version-control"></a>Controle de Versão

Interaja com repositórios Git e plataformas de controle de versão. Permite gerenciamento de repositório, análise de código, manipulação de pull requests, rastreamento de issues e outras operações de controle de versão por meio de APIs padronizadas.

- [adhikasp/mcp-git-ingest](https://github.com/adhikasp/mcp-git-ingest) 🐍 🏠 - Leia e analise repositórios GitHub com seu LLM.
- [ddukbg/github-enterprise-mcp](https://github.com/ddukbg/github-enterprise-mcp) 📇 ☁️ 🏠 - Servidor MCP para integração com a API do GitHub Enterprise.
- [gitea/gitea-mcp](https://gitea.com/gitea/gitea-mcp) 🎖️ 🏎️ ☁️ 🏠 🍎 🪟 🐧 - Interaja com instâncias Gitea usando MCP.
- [github/github-mcp-server](https://github.com/github/github-mcp-server) 📇 ☁️ - Servidor oficial do GitHub para integração com gerenciamento de repositórios, PRs, issues e mais.
- [kopfrechner/gitlab-mr-mcp](https://github.com/kopfrechner/gitlab-mr-mcp) 📇 ☁️ - Interaja perfeitamente com issues e merge requests dos seus projetos GitLab.
- [modelcontextprotocol/server-git](https://github.com/modelcontextprotocol/servers/tree/main/src/git) 🐍 🏠 - Operações diretas em repositórios Git, incluindo leitura, busca e análise de repositórios locais.
- [modelcontextprotocol/server-gitlab](https://github.com/modelcontextprotocol/servers/tree/main/src/gitlab) 📇 ☁️ 🏠 - Integração com a plataforma GitLab para gerenciamento de projetos e operações CI/CD.
- [oschina/mcp-gitee](https://github.com/oschina/gitee) 🏎️ ☁️ 🏠 - Integração com API do Gitee, gerenciamento de repositório, issue, pull request e mais.
- [Tiberriver256/mcp-server-azure-devops](https://github.com/Tiberriver256/mcp-server-azure-devops) 📇 ☁️ - Integração Azure DevOps para gerenciamento de repositórios, work items e pipelines.
- [kaiyuanxiaobing/atomgit-mcp-server](https://github.com/kaiyuanxiaobing/atomgit-mcp-server) 📇 ☁️ - Servidor oficial AtomGit para integração com gerenciamento de repositórios, PRs, issues, branches, labels e mais.

### 🛠️ <a name="other-tools-and-integrations"></a>Outras Ferramentas e Integrações

- [AbdelStark/bitcoin-mcp](https://github.com/AbdelStark/bitcoin-mcp) - ₿ Um servidor Model Context Protocol (MCP) que permite que modelos de IA interajam com Bitcoin, possibilitando gerar chaves, validar endereços, decodificar transações, consultar a blockchain e muito mais.
- [akseyh/bear-mcp-server](https://github.com/akseyh/bear-mcp-server) - Permite que a IA leia suas notas do Bear (somente macOS).
- [allenporter/mcp-server-home-assistant](https://github.com/allenporter/mcp-server-home-assistant) 🐍 🏠 - Expõe todas as intenções de voz do Home Assistant por meio de um Servidor Model Context Protocol, permitindo o controle residencial.
- [Amazon Bedrock Nova Canvas](https://github.com/zxkane/mcp-server-amazon-bedrock) 📇 ☁️ - Use o modelo Amazon Nova Canvas para geração de imagens.
- [amidabuddha/unichat-mcp-server](https://github.com/amidabuddha/unichat-mcp-server) 🐍/📇 ☁️ - Envie solicitações para OpenAI, MistralAI, Anthropic, xAI, Google AI ou DeepSeek usando o protocolo MCP via ferramenta ou prompts predefinidos. Chave de API do fornecedor necessária.
- [anaisbetts/mcp-installer](https://github.com/anaisbetts/mcp-installer) 🐍 🏠 - Um servidor MCP que instala outros servidores MCP para você.
- [anaisbetts/mcp-youtube](https://github.com/anaisbetts/mcp-youtube) 📇 ☁️ - Busca legendas do YouTube.
- [andybrandt/mcp-simple-openai-assistant](https://github.com/andybrandt/mcp-simple-openai-assistant) - 🐍 ☁️  MCP para conversar com assistentes OpenAI (Claude pode usar qualquer modelo GPT como assistente).
- [andybrandt/mcp-simple-timeserver](https://github.com/andybrandt/mcp-simple-timeserver) 🐍 🏠☁️ - Um servidor MCP que permite verificar a hora local na máquina cliente ou a hora UTC atual de um servidor NTP.
- [apify/actors-mcp-server](https://github.com/apify/actors-mcp-server) 📇 ☁️ - Use mais de 3.000 ferramentas em nuvem pré-construídas, conhecidas como Actors, para extrair dados de sites, e-commerce, redes sociais, motores de busca, mapas e mais.
- [apinetwork/piapi-mcp-server](https://github.com/apinetwork/piapi-mcp-server) 📇 ☁️ O servidor PiAPI MCP permite gerar conteúdo de mídia com Midjourney/Flux/Kling/Hunyuan/Udio/Trellis diretamente do Claude ou de qualquer outro app compatível com MCP.
- [awkoy/replicate-flux-mcp](https://github.com/awkoy/replicate-flux-mcp) 📇 ☁️ - Oferece a capacidade de gerar imagens via API do Replicate.
- [awwaiid/mcp-server-taskwarrior](https://github.com/awwaiid/mcp-server-taskwarrior) 🏠 📇 - Um servidor MCP para uso local básico do taskwarrior (adicionar, atualizar, remover tarefas).
- [baba786/phabricator-mcp-server](https://github.com/baba786/phabricator-mcp-server) 🐍 ☁️ - Interação com a API do Phabricator.
- [Badhansen/notion-mcp](https://github.com/Badhansen/notion-mcp) 🐍 ☁️ - Um servidor Model Context Protocol (MCP) que integra com a API do Notion para gerenciar listas de tarefas pessoais de forma eficiente.
- [bart6114/my-bear-mcp-server](https://github.com/bart6114/my-bear-mcp-server/) 📇 🏠 🍎 - Permite ler notas e tags do app Bear, através de integração direta com o sqlitedb do Bear.
- [billster45/mcp-chatgpt-responses](https://github.com/billster45/mcp-chatgpt-responses) 🐍 ☁️ - Servidor MCP para Claude conversar com o ChatGPT e usar sua capacidade de pesquisa na web.
- [blurrah/mcp-graphql](https://github.com/blurrah/mcp-graphql) 📇 ☁️ - Permite que a IA faça consultas a servidores GraphQL.
- [calclavia/mcp-obsidian](https://github.com/calclavia/mcp-obsidian) 📇 🏠 - Conector para permitir que Claude Desktop (ou qualquer cliente MCP) leia e pesquise qualquer diretório contendo notas Markdown (como um cofre Obsidian).
- [chrishayuk/mcp-cli](https://github.com/chrishayuk/mcp-cli) 🐍 🏠 - Mais uma ferramenta CLI para testar servidores MCP.
- [danhilse/notion_mcp](https://github.com/danhilse/notion_mcp) 🐍 ☁️ - Integra com a API do Notion para gerenciar listas de tarefas pessoais.
- [EKibort/wrike-mcp-server](https://github.com/EKibort/wrike-mcp-server) - 🐍 🏠 - Uma implementação leve de um servidor MCP Wrike para interagir com tarefas do Wrike via API pública.
- [ekkyarmandi/ticktick-mcp](https://github.com/ekkyarmandi/ticktick-mcp) 🐍 ☁️ - Servidor MCP do [TickTick](https://ticktick.com/) que integra com a API do TickTick para gerenciar projetos e tarefas pessoais.
- [esignaturescom/mcp-server-esignatures](https://github.com/esignaturescom/mcp-server-esignatures) 🐍 ☁️️ - Gerenciamento de contratos e modelos para redigir, revisar e enviar contratos vinculativos via API eSignatures.
- [evalstate/mcp-miro](https://github.com/evalstate/mcp-miro) 📇 ☁️ - Acesse quadros MIRO, crie e leia itens em massa. Requer chave OAUTH para REST API.
- [feuerdev/keep-mcp](https://github.com/feuerdev/keep-mcp) 🐍 ☁️ - Leia, crie, atualize e exclua notas do Google Keep.
- [future-audiences/wikimedia-enterprise-model-context-protocol](https://gitlab.wikimedia.org/repos/future-audiences/wikimedia-enterprise-model-context-protocol) 🐍 ☁️  - API de busca de artigos da Wikipedia.
- [fotoetienne/gqai](https://github.com/fotoetienne/gqai) 🏎 🏠 - Defina ferramentas usando consultas/mutações GraphQL regulares e o gqai gera automaticamente um servidor MCP para você.
- [githejie/mcp-server-calculator](https://github.com/githejie/mcp-server-calculator) 🐍 🏠 - Este servidor permite que LLMs usem calculadora para cálculos numéricos precisos.
- [gotoolkits/DifyWorkflow](https://github.com/gotoolkits/mcp-difyworkflow-server) - 🏎️ ☁️ Ferramentas para consultar e executar fluxos de trabalho Dify.
- [hiromitsusasaki/raindrop-io-mcp-server](https://github.com/hiromitsusasaki/raindrop-io-mcp-server) 📇 ☁️ - Integração que permite que LLMs interajam com favoritos do Raindrop.io usando o Model Context Protocol (MCP).
- [hmk/attio-mcp-server](https://github.com/hmk/attio-mcp-server) - 📇 ☁️ Permite que clientes IA gerenciem registros e notas no Attio CRM.
- [isaacwasserman/mcp-vegalite-server](https://github.com/isaacwasserman/mcp-vegalite-server) 🐍 🏠 - Gere visualizações a partir de dados coletados usando o formato e renderizador VegaLite.
- [ivnvxd/mcp-server-odoo](https://github.com/ivnvxd/mcp-server-odoo) 🐍 ☁️/🏠 - Conecte assistentes IA a sistemas Odoo ERP para acesso a dados empresariais, gerenciamento de registros e automação de fluxos de trabalho.
- [ivo-toby/contentful-mcp](https://github.com/ivo-toby/contentful-mcp) 📇 🏠 - Atualize, crie, exclua conteúdo, modelos de conteúdo e ativos em seu Espaço Contentful.
- [j3k0/speech.sh](https://github.com/j3k0/speech.sh/blob/main/MCP_README.md) 🏠 - Permita que o agente fale em voz alta, notificando quando terminar com um resumo rápido.
- [jagan-shanmugam/climatiq-mcp-server](https://github.com/jagan-shanmugam/climatiq-mcp-server) 🐍 🏠 - Um servidor Model Context Protocol (MCP) para acessar a API do Climatiq e calcular emissões de carbono. Isso permite que assistentes de IA realizem cálculos de carbono em tempo real e forneçam insights sobre impactos climáticos.
- [johannesbrandenburger/typst-mcp](https://github.com/johannesbrandenburger/typst-mcp) 🐍 🏠 - Servidor MCP para Typst, um sistema de composição baseado em marcação. Fornece ferramentas para converter entre LaTeX e Typst, validar sintaxe Typst e gerar imagens a partir de código Typst.
- [joshuarileydev/mac-apps-launcher-mcp-server](https://github.com/JoshuaRileyDev/mac-apps-launcher) 📇 🏠 - Um servidor MCP para listar e iniciar aplicativos no MacOS.
- [Harry-027/JotDown](https://github.com/Harry-027/JotDown) 🦀 🏠 - Um servidor MCP para criar/atualizar páginas no app Notion e gerar automaticamente mdBooks a partir de conteúdo estruturado.
- [kelvin6365/plane-mcp-server](https://github.com/kelvin6365/plane-mcp-server) - 🏎️ 🏠 Este servidor MCP ajuda a gerenciar projetos e issues via API do [Plane](https://plane.so).
- [kenliao94/mcp-server-rabbitmq](https://github.com/kenliao94/mcp-server-rabbitmq) 🐍 🏠 - Permite interação (operação administrativa, enfileirar/desenfileirar mensagens) com o RabbitMQ.
- [k-jarzyna/mcp-miro](https://github.com/k-jarzyna/mcp-miro) 📇 ☁️ - Servidor MCP Miro, expondo todas as funcionalidades disponíveis no SDK oficial do Miro.
- [kimtth/mcp-remote-call-ping-pong](https://github.com/kimtth/mcp-remote-call-ping-pong) 🐍 🏠 - App experimental e educacional de servidor Ping-pong demonstrando chamadas remotas MCP (Model Context Protocol).
- [kj455/mcp-kibela](https://github.com/kj455/mcp-kibela) - 📇 ☁️ Permite que modelos de IA interajam com o [Kibela](https://kibe.la/).
- [kiwamizamurai/mcp-kibela-server](https://github.com/kiwamizamurai/mcp-kibela-server) - 📇 ☁️ Interaja poderosamente com a API do Kibela.
- [KS-GEN-AI/confluence-mcp-server](https://github.com/KS-GEN-AI/confluence-mcp-server) 📇 ☁️ 🍎 🪟 - Obtenha dados do Confluence via CQL e leia páginas.
- [KS-GEN-AI/jira-mcp-server](https://github.com/KS-GEN-AI/jira-mcp-server) 📇 ☁️ 🍎 🪟 - Leia dados do Jira via JQL e API e execute solicitações para criar e editar tickets.
- [salesforce-mcp/salesforce-mcp](https://github.com/salesforce-mcp/salesforce-mcp) 🏠 ☁️ - Servidor MCP com demonstração básica de interações com instância Salesforce.
- [pollinations/chucknorris-mcp](https://github.com/pollinations/chucknorris-mcp) 📇 ☁️ - Prompts de aprimoramento LLM especializados e jailbreaks com adaptação dinâmica de esquema.
- [louiscklaw/hko-mcp](https://github.com/louiscklaw/hko-mcp) 📇 🏠 - Servidor MCP com demonstração básica de obtenção de clima do Observatório de Hong Kong.
- [evalstate/mcp-hfspace](https://github.com/evalstate/mcp-hfspace) 📇 ☁️ - Use HuggingFace Spaces diretamente do Claude. Use geração de imagens Open Source, chat, tarefas de visão e mais. Suporta upload/download de imagens, áudio e texto.
- [magarcia/mcp-server-giphy](https://github.com/magarcia/mcp-server-giphy) 📇 ☁️ - Pesquise e recupere GIFs da vasta biblioteca do Giphy através da API Giphy.
- [integromat/make-mcp-server](https://github.com/integromat/make-mcp-server) 🎖️ 📇 🏠 - Transforme seus cenários do [Make](https://www.make.com/) em ferramentas acionáveis para assistentes de IA.
- [marcelmarais/Spotify](https://github.com/marcelmarais/spotify-mcp-server) - 📇 🏠 Controle a reprodução do Spotify e gerencie playlists.
- [MarkusPfundstein/mcp-obsidian](https://github.com/MarkusPfundstein/mcp-obsidian) 🐍 ☁️ 🏠 - Interagindo com o Obsidian via REST API.
- [emicklei/mcp-log-proxy](https://github.com/emicklei/mcp-log-proxy) 🏎️ 🏠 - Proxy de servidor MCP que oferece uma interface web para todo o fluxo de mensagens.
- [quarkiverse/mcp-server-jfx](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/jfx) ☕ 🏠 - Desenhe em canvas JavaFX.
- [mediar-ai/screenpipe](https://github.com/mediar-ai/screenpipe) - 🎖️ 🦀 🏠 🍎 Sistema local que captura tela/áudio com indexação temporal, armazenamento SQL/embedding, busca semântica, análise histórica por LLM e ações acionadas por eventos – permite construir agentes de IA sensíveis ao contexto via ecossistema de plugins NextJS.
- [modelcontextprotocol/server-everything](https://github.com/modelcontextprotocol/servers/tree/main/src/everything) 📇 🏠 - Servidor MCP que exercita todos os recursos do protocolo MCP.
- [mrjoshuak/godoc-mcp](https://github.com/mrjoshuak/godoc-mcp) 🏎️ 🏠 - Servidor de documentação Go eficiente em tokens que fornece acesso inteligente a docs de pacotes e tipos para assistentes IA sem ler arquivos-fonte inteiros.
- [mzxrai/mcp-openai](https://github.com/mzxrai/mcp-openai) 📇 ☁️ - Converse com os modelos mais avançados da OpenAI.
- [NakaokaRei/swift-mcp-gui](https://github.com/NakaokaRei/swift-mcp-gui.git) 🏠 🍎 - Servidor MCP que pode executar comandos como entrada de teclado e movimento de mouse.
- [nguyenvanduocit/all-in-one-model-context-protocol](https://github.com/nguyenvanduocit/all-in-one-model-context-protocol) 🏎️ 🏠 - Ferramentas úteis para desenvolvedores: confluence, Jira, Youtube, executar scripts, RAG de base de conhecimento, buscar URL, gerenciar canal do YouTube, e-mails, calendário, gitlab.
- [NON906/omniparser-autogui-mcp](https://github.com/NON906/omniparser-autogui-mcp) - 🐍 Operação automática de GUI na tela.
- [orellazi/coda-mcp](https://github.com/orellazri/coda-mcp) 📇 ☁️ - Servidor MCP para o [Coda](https://coda.io/).
- [pierrebrunelle/mcp-server-openai](https://github.com/pierrebrunelle/mcp-server-openai) 🐍 ☁️ - Consulte modelos OpenAI diretamente do Claude usando protocolo MCP.
- [pskill9/hn-server](https://github.com/pskill9/hn-server) - 📇 ☁️ Analisa o conteúdo HTML do news.ycombinator.com (Hacker News) e fornece dados estruturados para diferentes tipos de notícias (top, new, ask, show, jobs).
- [PV-Bhat/vibe-check-mcp-server](https://github.com/PV-Bhat/vibe-check-mcp-server) 📇 ☁️ - Um servidor MCP que previne erros em cascata e escopo excessivo ao chamar um agente “Vibe-check” para garantir alinhamento do usuário.
- [pwh-pwh/cal-mcp](https://github.com/pwh-pwh/cal-mcp) - Um servidor MCP para cálculo de expressões matemáticas.
- [pyroprompts/any-chat-completions-mcp](https://github.com/pyroprompts/any-chat-completions-mcp) - Converse com qualquer API Chat Completions compatível com SDK OpenAI, como Perplexity, Groq, xAI e mais.
- [Rai220/think-mcp](https://github.com/Rai220/think-mcp) 🐍 🏠 - Aprimora as capacidades de raciocínio de qualquer agente integrando as think-tools, conforme descrito no [artigo da Anthropic](https://www.anthropic.com/engineering/claude-think-tool).
- [reeeeemo/ancestry-mcp](https://github.com/reeeeemo/ancestry-mcp) 🐍 🏠 - Permite que a IA leia arquivos .ged e dados genéticos.
- [rember/rember-mcp](https://github.com/rember/rember-mcp) 📇 🏠 - Crie flashcards de repetição espaçada no [Rember](https://rember.com) para lembrar de tudo que aprender em seus chats.
- [roychri/mcp-server-asana](https://github.com/roychri/mcp-server-asana) - 📇 ☁️ Esta implementação de servidor Model Context Protocol do Asana permite conversar com a API do Asana a partir de clientes MCP como o aplicativo Claude Desktop, entre outros.
- [rusiaaman/wcgw](https://github.com/rusiaaman/wcgw/blob/main/src/wcgw/client/mcp_server/Readme.md) 🐍 🏠 - Execução autônoma de shell, controle do computador e agente de codificação. (Mac)
- [SecretiveShell/MCP-wolfram-alpha](https://github.com/SecretiveShell/MCP-wolfram-alpha) 🐍 ☁️ - Um servidor MCP para consultar a API do Wolfram Alpha.
- [Seym0n/tiktok-mcp](https://github.com/Seym0n/tiktok-mcp) 📇 ☁️ - Interaja com vídeos do TikTok
- [Shopify/dev-mcp](https://github.com/Shopify/dev-mcp) 📇 ☁️ - Servidor Model Context Protocol (MCP) que interage com Shopify Dev.
- [sirmews/apple-notes-mcp](https://github.com/sirmews/apple-notes-mcp) 🐍 🏠 - Permite que a IA leia do seu banco de dados local do Apple Notes (apenas macOS)
- [sooperset/mcp-atlassian](https://github.com/sooperset/mcp-atlassian) 🐍 ☁️ - Servidor MCP para produtos Atlassian (Confluence e Jira). Suporta Confluence Cloud, Jira Cloud e Jira Server/Data Center. Fornece ferramentas abrangentes para pesquisar, ler, criar e gerenciar conteúdo em espaços de trabalho Atlassian.
- [suekou/mcp-notion-server](https://github.com/suekou/mcp-notion-server) 📇 🏠 - Interagindo com a API do Notion
- [tacticlaunch/mcp-linear](https://github.com/tacticlaunch/mcp-linear) 📇 ☁️ 🍎 🪟 🐧 - Integração com o sistema de gerenciamento de projetos Linear
- [tanigami/mcp-server-perplexity](https://github.com/tanigami/mcp-server-perplexity) 🐍 ☁️ - Interagindo com a API Perplexity.
- [tevonsb/homeassistant-mcp](https://github.com/tevonsb/homeassistant-mcp) 📇 🏠 - Acesse dados do Home Assistant e controle dispositivos (luzes, interruptores, termostatos, etc).
- [tomekkorbak/oura-mcp-server](https://github.com/tomekkorbak/oura-mcp-server) 🐍 ☁️ - Um servidor MCP para Oura, um app de rastreamento de sono
- [UnitVectorY-Labs/mcp-graphql-forge](https://github.com/UnitVectorY-Labs/mcp-graphql-forge) 🏎️ ☁️ 🍎 🪟 🐧 - Um servidor MCP leve, orientado por configuração, que expõe consultas GraphQL selecionadas como ferramentas modulares, permitindo interações intencionais de API para seus agentes.
- [kw510/strava-mcp](https://github.com/kw510/strava-mcp) 📇 ☁️ - Um servidor MCP para Strava, um app de rastreamento de exercícios físicos
- [wanaku-ai/wanaku](https://github.com/wanaku-ai/wanaku) - ☁️ 🏠 O Wanaku MCP Router é um servidor MCP baseado em SSE que fornece um mecanismo de roteamento extensível permitindo integrar seus sistemas corporativos com agentes de IA.
- [wong2/mcp-cli](https://github.com/wong2/mcp-cli) 📇 🏠 - Ferramenta CLI para testar servidores MCP
- [ws-mcp](https://github.com/nick1udwig/ws-mcp) - Envolva servidores MCP com um WebSocket (para uso com [kitbitz](https://github.com/nick1udwig/kibitz))
- [yuna0x0/hackmd-mcp](https://github.com/yuna0x0/hackmd-mcp) 📇 ☁️ - Permite que modelos de IA interajam com o [HackMD](https://hackmd.io)
- [ZeparHyfar/mcp-datetime](https://github.com/ZeparHyfar/mcp-datetime) - Servidor MCP fornecendo funções de data e hora em vários formatos
- [zueai/mcp-manager](https://github.com/zueai/mcp-manager) 📇 ☁️ - Interface Web simples para instalar e gerenciar servidores MCP para o aplicativo Claude Desktop.
- [HenryHaoson/Yuque-MCP-Server](https://github.com/HenryHaoson/Yuque-MCP-Server) - 📇 ☁️ Um servidor Model-Context-Protocol (MCP) para integração com a API do Yuque, permitindo que modelos de IA gerenciem documentos, interajam com bases de conhecimento, pesquisem conteúdo e acessem dados analíticos da plataforma Yuque.
- [Mtehabsim/ScreenPilot](https://github.com/Mtehabsim/ScreenPilot) 🐍 🏠 - permite que a IA controle totalmente e acesse interações de interface gráfica, fornecendo ferramentas para mouse e teclado, ideal para automação geral, educação e experimentação.
- [tumf/web3-mcp](https://github.com/tumf/web3-mcp) 🐍 ☁️ - Uma implementação de servidor MCP envolvendo a Ankr Advanced API. Acesso a dados de NFT, tokens e blockchain em várias cadeias incluindo Ethereum, BSC, Polygon, Avalanche e mais.
- [danielkennedy1/pdf-tools-mcp](https://github.com/danielkennedy1/pdf-tools-mcp) 🐍 - Utilitários para baixar, visualizar e manipular PDFs.
- [dotemacs/domain-lookup-mcp](https://github.com/dotemacs/domain-lookup-mcp) 🏎️ - Serviço de busca de nomes de domínio, primeiro via [RDAP](https://en.wikipedia.org/wiki/Registration_Data_Access_Protocol) e depois, como fallback, via [WHOIS](https://en.wikipedia.org/wiki/WHOIS)
- [Klavis-AI/YouTube](https://github.com/Klavis-AI/klavis/tree/main/mcp_servers/youtube) 🐍 📇 - Extraia e converta informações de vídeos do YouTube.
- [ttommyth/interactive-mcp](https://github.com/ttommyth/interactive-mcp) 📇 🏠 🍎 🪟 🐧 - Permite fluxos de trabalho LLM interativos adicionando prompts de usuário locais e capacidades de chat diretamente no loop MCP.
- [olalonde/mcp-human](https://github.com/olalonde/mcp-human) 📇 ☁️ - Quando seu LLM precisa de assistência humana (via AWS Mechanical Turk)
- [gwbischof/free-will-mcp](https://github.com/gwbischof/free-will-mcp) 🐍 🏠 - Dê ferramentas de livre arbítrio para sua IA. Um projeto divertido para explorar o que uma IA faria com a capacidade de se auto-fornecer prompts, ignorar solicitações do usuário e se reativar depois de um tempo.
- [caol64/wenyan-mcp](https://github.com/caol64/wenyan-mcp) 📇 🏠 🍎 🪟 🐧 - Wenyan MCP Server, que permite à IA formatar automaticamente artigos em Markdown e publicá-los no WeChat GZH.

## Frameworks

> [!NOTE]
> Mais frameworks, utilitários e outras ferramentas para desenvolvedores estão disponíveis em https://github.com/punkpeye/awesome-mcp-devtools

- [FastMCP](https://github.com/jlowin/fastmcp) 🐍 - Um framework de alto nível para construir servidores MCP em Python
- [FastMCP](https://github.com/punkpeye/fastmcp) 📇 - Um framework de alto nível para construir servidores MCP em TypeScript

## Dicas e Truques

### Prompt oficial para informar LLMs como usar MCP

Quer perguntar ao Claude sobre o Model Context Protocol?

Crie um Projeto e adicione este arquivo a ele:

https://modelcontextprotocol.io/llms-full.txt

Agora o Claude pode responder perguntas sobre como escrever servidores MCP e como eles funcionam

- https://www.reddit.com/r/ClaudeAI/comments/1h3g01r/want_to_ask_claude_about_model_context_protocol/

## Histórico de Stars

<a href="https://star-history.com/#punkpeye/awesome-mcp-servers&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=punkpeye/awesome-mcp-servers&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=punkpeye/awesome-mcp-servers&type=Date" />
   <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=punkpeye/awesome-mcp-servers&type=Date" />
 </picture>
</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---
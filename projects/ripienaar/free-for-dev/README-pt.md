# free-for.dev

Desenvolvedores e autores de projetos Open Source agora contam com muitos serviços que oferecem camadas gratuitas, mas encontrá-los todos leva tempo para tomar decisões informadas.

Esta é uma lista de softwares (SaaS, PaaS, IaaS, etc.) e outras ofertas com camadas gratuitas para desenvolvedores.

O escopo desta lista em particular é limitado a coisas que desenvolvedores de infraestrutura (Administrador de Sistemas, Profissionais de DevOps, etc.) provavelmente acharão úteis. Amamos todos os serviços gratuitos disponíveis, mas seria bom manter o foco no tema. Às vezes é uma linha tênue, então esta lista é opinativa; por favor, não se ofenda se eu não aceitar sua contribuição.

Esta lista é resultado de Pull Requests, revisões, ideias e trabalho realizado por mais de 1600 pessoas. Você também pode ajudar enviando [Pull Requests](https://github.com/ripienaar/free-for-dev) para adicionar mais serviços ou remover aqueles cujas ofertas mudaram ou foram descontinuadas.

[![Track Awesome List](https://www.trackawesomelist.com/badge.svg)](https://www.trackawesomelist.com/ripienaar/free-for-dev)

**NOTA**: Esta lista é apenas para ofertas "as-a-Service", não para softwares auto-hospedados. Para ser elegível, um serviço deve oferecer uma camada gratuita, não apenas um teste gratuito. A camada gratuita deve durar pelo menos um ano se for limitada por tempo. Também consideramos a camada gratuita sob a perspectiva de segurança, então SSO é aceitável, mas não aceitarei serviços que restrinjam TLS apenas para planos pagos.

# Índice

  * [Limites Sempre-Grátis dos Principais Provedores de Nuvem](#major-cloud-providers)
  * [Soluções de Gerenciamento de Nuvem](#cloud-management-solutions)
  * [Analytics, Eventos e Estatísticas](#analytics-events-and-statistics)
  * [APIs, Dados e ML](#apis-data-and-ml)
  * [Repositórios de Artefatos](#artifact-repos)
  * [BaaS](#baas)
  * [Plataforma Low-code](#low-code-platform)
  * [CDN e Proteção](#cdn-and-protection)
  * [CI e CD](#ci-and-cd)
  * [CMS](#cms)
  * [Geração de Código](#code-generation)
  * [Qualidade de Código](#code-quality)
  * [Busca e Navegação de Código](#code-search-and-browsing)
  * [Tratamento de Crash e Exceções](#crash-and-exception-handling)
  * [Visualização de Dados em Mapas](#data-visualization-on-maps)
  * [Serviços de Dados Gerenciados](#managed-data-services)
  * [Design e UI](#design-and-ui)
  * [Inspiração para Design](#design-inspiration)
  * [Sites de Blog para Devs](#dev-blogging-sites)
  * [DNS](#dns)
  * [Relacionados ao Docker](#docker-related)
  * [Domínio](#domain)
  * [Educação e Desenvolvimento de Carreira](#education-and-career-development)
  * [Email](#email)
  * [Plataformas de Gerenciamento de Feature Toggles](#feature-toggles-management-platforms)
  * [Fonte](#font)
  * [Formulários](#forms)
  * [IA Generativa](#generative-ai)
  * [IaaS](#iaas)
  * [IDE e Edição de Código](#ide-and-code-editing)
  * [API e SDK de Verificação de Número Móvel Internacional](#international-mobile-number-verification-api-and-sdk)
  * [Rastreamento de Issues e Gerenciamento de Projetos](#issue-tracking-and-project-management)
  * [Gerenciamento de Logs](#log-management)
  * [Distribuição e Feedback de Apps Mobile](#mobile-app-distribution-and-feedback)
  * [Sistemas de Gerenciamento](#management-system)
  * [Mensageria e Streaming](#messaging-and-streaming)
  * [Diversos](#miscellaneous)
  * [Monitoramento](#monitoring)
  * [PaaS](#paas)
  * [Sistema de Build de Pacotes](#package-build-system)
  * [Integração de Pagamento e Faturamento](#payment-and-billing-integration)
  * [Gerenciamento de Privacidade](#privacy-management)
  * [APIs de Screenshot](#screenshot-apis)
  * [Relacionados a Flutter e Construção de Apps IOS sem Mac](#flutter-related-and-building-ios-apps-without-mac)
  * [Busca](#search)
  * [Segurança e PKI](#security-and-pki)
  * [Autenticação, Autorização e Gerenciamento de Usuários](#authentication-authorization-and-user-management)
  * [Repositórios de Código Fonte](#source-code-repos)
  * [Armazenamento e Processamento de Mídia](#storage-and-media-processing)
  * [Túnel, WebRTC, Servidores Web Socket e Outros Roteadores](#tunneling-webrtc-web-socket-servers-and-other-routers)
  * [Testes](#testing)
  * [Ferramentas para Times e Colaboração](#tools-for-teams-and-collaboration)
  * [Gerenciamento de Tradução](#translation-management)
  * [Relacionados ao Vagrant](#vagrant-related)
  * [Gravação de Sessão de Visitantes](#visitor-session-recording)
  * [Hospedagem Web](#web-hosting)
  * [Plataformas de Comentário](#commenting-platforms)
  * [Emulação de Hardware no Navegador](#browser-based-hardware-emulation-written-in-javascript)
  * [Ferramentas de Desktop Remoto](#remote-desktop-tools)
  * [Desenvolvimento de Jogos](#game-development)
  * [Outros Recursos Gratuitos](#other-free-resources)

## Principais Provedores de Nuvem

  * [Google Cloud Platform](https://cloud.google.com)
    * App Engine - 28 horas de instância frontend por dia, nove horas de instância backend por dia
    * Cloud Firestore - 1GB de armazenamento, 50.000 leituras, 20.000 gravações, 20.000 exclusões por dia
    * Compute Engine - 1 e2-micro não-preemptível, 30GB HDD, 5GB de armazenamento de snapshot (restrito a certas regiões), 1 GB de saída de rede da América do Norte para todos os destinos regionais (exceto China e Austrália) por mês
    * Cloud Storage - 5GB, 1GB de saída de rede
    * Cloud Shell - Shell Linux baseado na web/IDE primário com 5GB de armazenamento persistente. Limite de 60 horas por semana
    * Cloud Pub/Sub - 10GB de mensagens por mês
    * Cloud Functions - 2 milhões de invocações por mês (inclui invocações em background e HTTP)
    * Cloud Run - 2 milhões de requisições por mês, 360.000 GB-segundos de memória, 180.000 vCPU-segundos de tempo de computação, 1 GB de saída de rede da América do Norte por mês
    * Google Kubernetes Engine - Sem taxa de gerenciamento de cluster para um cluster zonal. Cada nó de usuário é cobrado conforme o preço padrão do Compute Engine
    * BigQuery - 1 TB de consultas por mês, 10 GB de armazenamento por mês
    * Cloud Build - 120 minutos de build por dia
    * Cloud Source Repositories - Até 5 Usuários, 50 GB de Armazenamento, 50 GB de Egress
    * [Google Colab](https://colab.research.google.com/) - Ambiente gratuito de desenvolvimento de Jupyter Notebooks.
    * [Firebase Studio](https://firebase.studio) Google Firebase Studio (anteriormente Project IDX). VSCode online rodando no Google Cloud.
    * Lista completa e detalhada - https://cloud.google.com/free

  * [Amazon Web Services](https://aws.amazon.com)
    * [CloudFront](https://aws.amazon.com/cloudfront/) - 1TB de saída por mês e 2M de invocações de função por mês
    * [CloudWatch](https://aws.amazon.com/cloudwatch/) - 10 métricas customizadas e dez alarmes
* [CodeBuild](https://aws.amazon.com/codebuild/) - 100 minutos de tempo de build por mês  
* [CodeCommit](https://aws.amazon.com/codecommit/) - 5 usuários ativos, 50GB de armazenamento e 10.000 requisições por mês  
* [CodePipeline](https://aws.amazon.com/codepipeline/) - 1 pipeline ativa por mês  
* [DynamoDB](https://aws.amazon.com/dynamodb/) - 25GB de banco de dados NoSQL  
* [EC2](https://aws.amazon.com/ec2/) - 750 horas por mês de t2.micro ou t3.micro (12 meses). 100GB de saída por mês  
* [EBS](https://aws.amazon.com/ebs/) - 30GB por mês de armazenamento General Purpose (SSD) ou Magnético (12 meses)  
* [Elastic Load Balancing](https://aws.amazon.com/elasticloadbalancing/) - 750 horas por mês (12 meses)  
* [RDS](https://aws.amazon.com/rds/) - 750 horas por mês de db.t2.micro, db.t3.micro ou db.t4g.micro, 20GB de armazenamento General Purpose (SSD), 20GB de backups de armazenamento (12 meses)  
* [S3](https://aws.amazon.com/s3/) - 5GB de armazenamento de objetos Standard, 20.000 requisições Get e 2.000 requisições Put (12 meses)  
* [Glacier](https://aws.amazon.com/glacier/) - 10GB de armazenamento de objetos de longo prazo  
* [Lambda](https://aws.amazon.com/lambda/) - 1 milhão de requisições por mês  
* [SNS](https://aws.amazon.com/sns/) - 1 milhão de publicações por mês  
* [SES](https://aws.amazon.com/ses/) - 3.000 mensagens por mês (12 meses)  
* [SQS](https://aws.amazon.com/sqs/) - 1 milhão de requisições de fila de mensagens  
* Lista completa e detalhada - https://aws.amazon.com/free/

* [Microsoft Azure](https://azure.microsoft.com)  
  * [Virtual Machines](https://azure.microsoft.com/services/virtual-machines/) - 1 VM Linux B1S, 1 VM Windows B1S (12 meses)  
  * [App Service](https://azure.microsoft.com/services/app-service/) - 10 apps web, mobile ou API (60 minutos de CPU/dia)  
  * [Functions](https://azure.microsoft.com/services/functions/) - 1 milhão de requisições por mês  
  * [DevTest Labs](https://azure.microsoft.com/services/devtest-lab/) - Permite ambientes de dev-test rápidos, fáceis e leves  
  * [Active Directory](https://azure.microsoft.com/services/active-directory/) - 500.000 objetos  
  * [Active Directory B2C](https://azure.microsoft.com/services/active-directory/external-identities/b2c/) - 50.000 usuários armazenados por mês  
  * [Azure DevOps](https://azure.microsoft.com/services/devops/) - 5 usuários ativos, repositórios Git privados ilimitados  
  * [Azure Pipelines](https://azure.microsoft.com/services/devops/pipelines/) — 10 trabalhos paralelos gratuitos com minutos ilimitados para código aberto para Linux, macOS e Windows  
  * [Microsoft IoT Hub](https://azure.microsoft.com/services/iot-hub/) - 8.000 mensagens por dia  
  * [Load Balancer](https://azure.microsoft.com/services/load-balancer/) - 1 IP público balanceado gratuito (VIP)  
  * [Notification Hubs](https://azure.microsoft.com/services/notification-hubs/) - 1 milhão de notificações push  
  * [Bandwidth](https://azure.microsoft.com/pricing/details/bandwidth/) - 15GB de entrada (12 meses) e 5GB de saída por mês  
  * [Cosmos DB](https://azure.microsoft.com/services/cosmos-db/) - 25GB de armazenamento e 1.000 RUs de throughput provisionado  
  * [Static Web Apps](https://azure.microsoft.com/pricing/details/app-service/static/) — Construa, publique e hospede aplicações estáticas e funções serverless com SSL gratuito, Autenticação/Autorização e domínios personalizados  
  * [Storage](https://azure.microsoft.com/services/storage/) - 5GB de armazenamento LRS File ou Blob (12 meses)  
  * [Cognitive Services](https://azure.microsoft.com/services/cognitive-services/) - APIs de IA/ML (Visão Computacional, Tradutor, Detecção facial, Bots, etc) com camada gratuita incluindo transações limitadas  
  * [Cognitive Search](https://azure.microsoft.com/services/search/#features) - Serviço de busca e indexação baseada em IA, gratuito para 10.000 documentos  
  * [Azure Kubernetes Service](https://azure.microsoft.com/services/kubernetes-service/) - Serviço Kubernetes gerenciado, gerenciamento de cluster gratuito  
  * [Event Grid](https://azure.microsoft.com/services/event-grid/) - 100.000 operações/mês  
  * Lista completa e detalhada - https://azure.microsoft.com/free/

* [Oracle Cloud](https://www.oracle.com/cloud/)  
  * Compute  
     - 2 VMs de Computação baseadas em AMD com 1/8 OCPU e 1 GB de memória cada  
     - 4 núcleos Arm Ampere A1 e 24 GB de memória utilizáveis como uma VM ou até 4 VMs  
     - Instâncias serão recuperadas quando [consideradas ociosas](https://docs.oracle.com/en-us/iaas/Content/FreeTier/freetier_topic-Always_Free_Resources.htm#compute__idleinstances)  
  * Block Volume - 2 volumes, 200 GB no total (usados para computação)  
  * Object Storage - 10 GB  
  * Load balancer - 1 instância com 10 Mbps  
  * Databases - 2 bancos de dados, 20 GB cada  
  * Monitoring - 500 milhões de pontos de dados ingeridos, 1 bilhão de pontos de dados recuperados  
  * Banda - 10 TB de saída por mês, velocidade limitada a 50 Mbps em VM baseada em x64, 500 Mbps * contagem de núcleos em VM baseada em ARM  
  * IP Público - 2 IPv4 para VMs, 1 IPv4 para load balancer  
  * Notificações - 1 milhão de opções de entrega por mês, 1.000 e-mails enviados por mês  
  * Lista completa e detalhada - https://www.oracle.com/cloud/free/

* [IBM Cloud](https://www.ibm.com/cloud/free/)  
  * Banco de dados Cloudant - 1 GB de armazenamento de dados  
  * Banco de dados Db2 - 100MB de armazenamento de dados  
  * API Connect - 50.000 chamadas de API por mês  
  * Monitoramento de disponibilidade - 3 milhões de pontos de dados por mês  
  * Log Analysis - 500MB de log diário  
  * Lista completa e detalhada - https://www.ibm.com/cloud/free/

* [Cloudflare](https://www.cloudflare.com/)  
  * [Application Services](https://www.cloudflare.com/plans/) - DNS gratuito para um número ilimitado de domínios, proteção DDoS, CDN com SSL gratuito, regras de firewall e de página, WAF, mitigação de bots, rate limiting gratuito e ilimitado - 1 regra por domínio, analytics, encaminhamento de e-mail  
  * [Zero Trust & SASE](https://www.cloudflare.com/plans/zero-trust-services/) - Até 50 usuários, 24 horas de registro de atividades, três locais de rede  
  * [Cloudflare Tunnel](https://www.cloudflare.com/products/tunnel/) - Você pode expor uma porta HTTP localmente executando por meio de um túnel para um subdomínio aleatório em trycloudflare.com usando [Quick Tunnels](https://developers.cloudflare.com/cloudflare-one/connections/connect-networks/do-more-with-tunnels/trycloudflare/), sem necessidade de conta. Mais recursos (túnel TCP, balanceamento de carga, VPN) no [Zero Trust](https://www.cloudflare.com/products/zero-trust/) plano gratuito.  
  * [Workers](https://developers.cloudflare.com/workers/) - Publique código serverless gratuitamente na rede global da Cloudflare — 100 mil requisições diárias.  
  * [Workers KV](https://developers.cloudflare.com/kv) - 100 mil requisições de leitura por dia, 1.000 de escrita por dia, 1.000 de exclusão por dia, 1.000 de listagem por dia, 1 GB de dados armazenados  
  * [R2](https://developers.cloudflare.com/r2/) - 10 GB por mês, 1 milhão de operações Classe A por mês, 10 milhões de operações Classe B por mês  
  * [D1](https://developers.cloudflare.com/d1/) - 5 milhões de linhas lidas por dia, 100 mil linhas gravadas por dia, 1 GB de armazenamento  
  * [Pages](https://developers.cloudflare.com/pages/) - Desenvolva e publique suas aplicações web na rede global rápida e segura da Cloudflare. Quinhentas builds mensais, 100 domínios personalizados, SSL integrado, assentos ilimitados, deploys de preview ilimitados e capacidade full-stack via integração com Cloudflare Workers.  
  * [Queues](https://developers.cloudflare.com/queues/) - 1 milhão de operações por mês  
  * [TURN](https://developers.cloudflare.com/calls/turn/) – 1TB de tráfego (saída) gratuito por mês.

**[⬆️ Voltar ao Topo](#table-of-contents)**

## Soluções de gerenciamento de nuvem

* [Brainboard](https://www.brainboard.co) - Solução colaborativa para construir e gerenciar infraestruturas em nuvem visualmente de ponta a ponta.
* [Cloud 66](https://www.cloud66.com/) - Gratuito para projetos pessoais (inclui um servidor de deploy, um site estático), o Cloud 66 oferece tudo que você precisa para construir, publicar e crescer suas aplicações em qualquer nuvem sem complicações de “coisas de servidor”.
* [Pulumi](https://www.pulumi.com/) — Plataforma moderna de infraestrutura como código que permite usar linguagens de programação e ferramentas familiares para construir, publicar e gerenciar infraestrutura de nuvem.
* [terraform.io](https://www.terraform.io/) — Terraform Cloud. Gerenciamento remoto de estado gratuito e colaboração de equipe para até 500 recursos.
* [scalr.com](https://scalr.com/) - Scalr é um produto de Automação e Colaboração Terraform (TACO) usado para melhorar a colaboração e automação em infraestrutura e configurações gerenciadas por Terraform. Suporte completo ao CLI Terraform, integração OPA e modelo de configuração hierárquica. Sem taxas de SSO. Todos os recursos estão incluídos. Use até 50 execuções/mês gratuitamente.
* [deployment.io](https://deployment.io) - O Deployment.io ajuda desenvolvedores a automatizar deploys na AWS. No nosso plano gratuito, um desenvolvedor (usuário único) pode publicar sites estáticos, serviços web e ambientes ilimitados. Oferecemos 20 execuções de jobs gratuitas por mês com previews e auto-deploys incluídos no plano gratuito.

**[⬆️ Voltar ao Topo](#table-of-contents)**

## Repositórios de Código-Fonte

* [Bitbucket](https://bitbucket.org/) — Repositórios Git públicos e privados ilimitados para até 5 usuários com Pipelines para CI/CD
* [chiselapp.com](https://chiselapp.com/) — Repositórios Fossil públicos e privados ilimitados
* [codebasehq.com](https://www.codebasehq.com/) — Um projeto gratuito com 100 MB de espaço e dois usuários
* [Codeberg](https://codeberg.org/) — Repositórios Git públicos e privados ilimitados para projetos gratuitos e de código aberto (com colaboradores ilimitados). Baseado no [Forgejo](https://forgejo.org/). Hospedagem de site estático com [Codeberg Pages](https://codeberg.page/). Hospedagem de CI/CD com [Codeberg's CI](https://docs.codeberg.org/ci/). Hospedagem de tradução com [Codeberg Translate](https://translate.codeberg.org/). Inclui hospedagem de pacotes e containers, gerenciamento de projetos e rastreamento de issues
* [GitGud](https://gitgud.io) — Repositórios privados e públicos ilimitados. Gratuito para sempre. Baseado em GitLab & Sapphire. CI/CD não incluído.
* [GitHub](https://github.com/) — Repositórios públicos ilimitados e repositórios privados ilimitados (com colaboradores ilimitados). Inclui CI/CD, ambiente de desenvolvimento, hospedagem estática, hospedagem de pacotes e containers, gerenciamento de projetos e AI Copilot
* [gitlab.com](https://about.gitlab.com/) — Repositórios Git públicos e privados ilimitados com até 5 colaboradores. Inclui CI/CD, hospedagem estática, registro de container, gerenciamento de projetos e rastreamento de issues
* [framagit.org](https://framagit.org/) — Framagit é a forja de software da Framasoft baseada no Gitlab, inclui CI, páginas estáticas, páginas de projetos e rastreamento de issues.
* [heptapod.net](https://foss.heptapod.net/) — Heptapod é um fork amigável do GitLab Community Edition com suporte a Mercurial
* [ionicframework.com](https://ionicframework.com/appflow) - Repositório e ferramentas para desenvolver aplicações com Ionic; também possui um repositório ionic
* [NotABug](https://notabug.org) — NotABug.org é uma plataforma de colaboração de código para projetos de software livre, baseada em Git
* [OSDN](https://osdn.net/) - O OSDN.net é um serviço gratuito para desenvolvedores de software open source, oferecendo repositórios SVN/Git/Mercurial/Bazaar/CVS.
* [Pagure.io](https://pagure.io) — Pagure.io é uma plataforma gratuita e de código aberto para colaboração em projetos licenciados FOSS, baseada em Git.
* [perforce.com](https://www.perforce.com/products/helix-teamhub) — 1GB gratuito na nuvem e repositórios Git, Mercurial ou SVN.
* [pijul.com](https://pijul.com/) - Sistema de controle de versão distribuído gratuito e de código aberto, ilimitado. Sua característica distintiva baseia-se em uma teoria sólida de patches, o que o torna fácil de aprender, usar e distribuir. Resolve muitos problemas do git/hg/svn/darcs.
* [plasticscm.com](https://plasticscm.com/) — Gratuito para indivíduos, projetos OSS e organizações sem fins lucrativos.
* [projectlocker.com](https://projectlocker.com) — Um projeto privado gratuito (Git e Subversion) com 50 MB de espaço.
* [RocketGit](https://rocketgit.com) — Hospedagem de repositórios baseada em Git. Repositórios públicos e privados ilimitados.
* [savannah.gnu.org](https://savannah.gnu.org/) - Serve como um sistema colaborativo de gerenciamento de desenvolvimento de software para projetos de software livre (para projetos GNU).
* [savannah.nongnu.org](https://savannah.nongnu.org/) - Serve como um sistema colaborativo de gerenciamento de desenvolvimento de software para projetos de software livre (para projetos não-GNU).

**[⬆️ Voltar ao Topo](#table-of-contents)**

## APIs, Dados e ML

* [JSONGrid](https://jsongrid.com) - Ferramenta gratuita para visualizar, editar e filtrar dados JSON complexos em uma bela grade tabular. Salve e compartilhe dados JSON por link.
* [Zerosheets](https://zerosheets.com) - Transforme suas planilhas do Google Sheets em APIs poderosas para desenvolver rapidamente protótipos, sites, aplicativos e mais. 500 requisições por mês disponíveis gratuitamente.
* [IP.City](https://ip.city) — 100 requisições gratuitas de geolocalização de IP por dia.
* [Abstract API](https://www.abstractapi.com) — Suíte de APIs para vários casos de uso, incluindo geolocalização de IP, detecção de gênero ou validação de e-mail.
* [Apify](https://www.apify.com/) — Plataforma de automação e web scraping para criar uma API para qualquer site e extrair dados. Scrapers prontos, proxies integrados e soluções personalizadas. Plano gratuito com $5 em créditos de plataforma por mês.
* [APITemplate.io](https://apitemplate.io) - Gere automaticamente imagens e documentos PDF com uma API simples ou ferramentas de automação como Zapier & Airtable. Não requer CSS/HTML. O plano gratuito inclui 50 imagens/mês e três modelos.
* [APIToolkit.io](https://apitoolkit.io) - Todas as ferramentas para entender totalmente o que acontece nas suas APIs e backends. Validação automática de contrato e monitoramento de API. O plano gratuito cobre servidores com até 10.000 requisições por dia.
* [APIVerve](https://apiverve.com) - Acesse instantaneamente mais de 120+ APIs gratuitamente, com qualidade, consistência e confiabilidade. O plano gratuito cobre até 50 tokens de API por mês. (Possivelmente fora do ar, 2025-06-25)
* [Arize AI](https://arize.com/) - Observabilidade de machine learning para monitoramento de modelos e identificação de causas raiz como qualidade de dados e deriva de performance. Gratuito até dois modelos.
* [Maxim AI](https://getmaxim.ai/) - Simule, avalie e observe seus agentes de IA. Plataforma de avaliação e observabilidade de ponta a ponta, ajudando equipes a lançar agentes de IA de forma confiável e >5x mais rápido. Gratuito para sempre para desenvolvedores independentes e pequenas equipes (3 usuários).
* [Beeceptor](https://beeceptor.com) - Simule uma API REST em segundos, crie respostas falsas e muito mais. Gratuito para 50 requisições por dia, dashboard público, endpoints abertos (qualquer um com o link do dashboard pode ver envios e respostas).
* [BigDataCloud](https://www.bigdatacloud.com/) - Oferece APIs rápidas, precisas e gratuitas (Ilimitadas ou até 10K-50K/mês) para web moderna como geolocalização de IP, geocodificação reversa, insights de rede, validação de e-mail e telefone, informações de cliente e mais.
* [Browse AI](https://www.browse.ai) — Extração e monitoramento de dados na web. 1k créditos por mês gratuitos, equivalendo a 1k requisições simultâneas.
* [BrowserCat](https://www.browsercat.com) - API de navegador headless para automação, scraping, acesso web por agentes de IA, geração de imagem/pdf e mais. Plano gratuito com 1k requisições por mês.
* [Calendarific](https://calendarific.com) - API de feriados públicos de nível empresarial para mais de 200 países. O plano gratuito inclui 500 chamadas por mês.
* [Canopy](https://www.canopyapi.co/) - API GraphQL para dados de produtos, busca e categorias da Amazon.com. O plano gratuito inclui 100 chamadas por mês.
* [Clarifai](https://www.clarifai.com) — API de imagens para reconhecimento e detecção facial personalizada. Possibilidade de treinar modelos de IA. O plano gratuito possui 1.000 chamadas por mês.
* [Cloudmersive](https://cloudmersive.com/) — Plataforma de API utilitária com acesso completo à biblioteca expansiva de APIs incluindo conversão de documentos, verificação de vírus e mais com 600 chamadas/mês, apenas na América do Norte AZ, tamanho máximo de arquivo de 2,5MB.
* [Colaboratory](https://colab.research.google.com) — Ambiente gratuito de notebooks Python baseado na web com GPU Nvidia Tesla K80.
* [CometML](https://www.comet.com/site/) - Plataforma MLOps para rastreamento de experimentos, gerenciamento de produção de modelos, registro de modelos e linhagem completa de dados, cobrindo o fluxo de trabalho do treinamento à produção. Gratuito para indivíduos e acadêmicos.
* [Commerce Layer](https://commercelayer.io) - API de comércio componível que pode construir, fazer e gerenciar pedidos de qualquer front end. O plano de desenvolvedor permite 100 pedidos por mês e até 1.000 SKUs gratuitamente.
* [Composio](https://composio.dev/) - Plataforma de integração para Agentes de IA e LLMs. Integre mais de 200+ ferramentas pela internet agentic.
* [Conversion Tools](https://conversiontools.io/) - Conversor de arquivos online para documentos, imagens, vídeo, áudio e eBooks. API REST disponível. Bibliotecas para Node.js, PHP, Python. Suporta arquivos de até 50 GB (para planos pagos). O plano gratuito é limitado por tamanho de arquivo (20MB) e número de conversões (30/dia, 300/mês).
* [Country-State-City Microservice API](https://country-state-city.rebuscando.info/) - API e microserviço que fornece uma ampla gama de informações incluindo países, regiões, províncias, cidades, CEPs e muito mais. O plano gratuito inclui até 100 requisições por dia.
* [Coupler](https://www.coupler.io/) - Ferramenta de integração de dados que sincroniza entre aplicativos. Pode criar dashboards e relatórios ao vivo, transformar e manipular valores, coletar e fazer backup de insights. O plano gratuito é limitado a um usuário, conexão de dados, fonte de dados e destino de dados. Também requer atualização manual dos dados.
* [CraftMyPDF](https://craftmypdf.com) - Gere PDFs automaticamente a partir de modelos reutilizáveis com editor drag-and-drop e API simples. O plano gratuito inclui 100 PDFs/mês e três modelos.
* [Crawlbase](https://crawlbase.com/) — Raspagem e crawling de sites sem proxies, infraestrutura ou navegadores. Solucionamos captchas para você e impedimos que seja bloqueado. As primeiras 1000 chamadas são gratuitas.
* [CurlHub](https://curlhub.io) — Serviço proxy para inspecionar e depurar chamadas de API. O plano gratuito inclui 10.000 requisições por mês.
* [CurrencyScoop](https://currencyscoop.com) - API de dados de câmbio em tempo real para apps fintech. O plano gratuito inclui 5.000 chamadas por mês.
* [Cube](https://cube.dev/) - O Cube ajuda engenheiros de dados e desenvolvedores de aplicações a acessar dados de armazenamentos modernos, organizar em definições consistentes e entregar para qualquer aplicação. O jeito mais rápido de usar Cube é com Cube Cloud, com plano gratuito limitado a 1.000 consultas por dia.
* [Data Dead Drop](https://datadeaddrop.com) - Compartilhamento simples e gratuito de arquivos. Os dados se autodestroem após o acesso. Faça upload e download via navegador ou cliente de linha de comando.
* [Data Fetcher](https://datafetcher.com) - Conecte Airtable a qualquer aplicativo ou API sem código. Interface tipo Postman para executar requisições API no Airtable. Integrações pré-construídas com dezenas de apps. O plano gratuito inclui 100 execuções por mês.
* [Dataimporter.io](https://www.dataimporter.io) - Ferramenta para conectar, limpar e importar dados para o Salesforce. Plano gratuito inclui até 20.000 registros por mês.
* [Datalore](https://datalore.jetbrains.com) - Notebooks Python da Jetbrains. Inclui 10 GB de armazenamento e 120 horas de execução por mês.
* [Data Miner](https://dataminer.io/) - Extensão de navegador (Google Chrome, MS Edge) para extração de dados de páginas web em CSV ou Excel. O plano gratuito oferece 500 páginas/mês.
* [Datapane](https://datapane.com) - API para construir relatórios interativos em Python e implantar scripts Python e Jupyter Notebooks como ferramentas de autoatendimento.
* [DB-IP](https://db-ip.com/api/free) - API gratuita de geolocalização de IP com 1k requisições por IP por dia. Banco de dados lite sob licença CC-BY 4.0 também é gratuito.
* [DB Designer](https://www.dbdesigner.net/) — Ferramenta em nuvem para design e modelagem de esquemas de banco de dados com plano inicial gratuito de 2 modelos e dez tabelas por modelo.
* [DeepAR](https://developer.deepar.ai) — Filtros de rosto de realidade aumentada para qualquer plataforma com um SDK. O plano gratuito fornece até 10 usuários ativos mensais (MAU) e rastreia até 4 rostos.
* [Deepnote](https://deepnote.com) - Novo notebook de ciência de dados. Compatível com Jupyter, colaboração em tempo real e execução na nuvem. O plano gratuito inclui projetos pessoais ilimitados, máquinas básicas ilimitadas com 5GB RAM e 2vCPU, e equipes de até 3 editores.
* [Disease.sh](https://disease.sh/) — API gratuita que fornece dados precisos para construir aplicativos úteis relacionados à Covid-19.
* [Doczilla](https://www.doczilla.app/) — SaaS API para geração de screenshots ou PDFs diretamente de código HTML/CSS/JS. O plano gratuito permite 250 documentos por mês.
* [Doppio](https://doppio.sh/) — API gerenciada para gerar e armazenar PDFs e screenshots usando tecnologia de renderização de ponta. O plano gratuito permite 400 PDFs e screenshots por mês.
* [drawDB](https://drawdb.app/) — Editor online gratuito e open-source de diagramas de banco de dados, sem necessidade de cadastro.
* [dreamfactory.com](https://dreamfactory.com/) — Backend REST API open source para aplicações mobile, web e IoT. Conecte qualquer banco de dados SQL/NoSQL, sistema de arquivos ou serviço externo, e crie instantaneamente uma plataforma REST API completa com documentação ao vivo e gerenciamento de usuários.
* [Duply.co](https://duply.co) — Crie imagens dinâmicas por API & URL, desenhe o template uma vez e reutilize. O plano gratuito oferece 20 créditos.
* [DynamicDocs](https://advicement.io) - Gere documentos PDF com API JSON para PDF baseada em templates LaTeX. O plano gratuito permite 50 chamadas de API por mês e acesso a uma biblioteca de templates.
* [Efemarai](https://efemarai.com) - Plataforma de teste e depuração para modelos e dados de ML. Visualize qualquer grafo computacional. Uso local gratuito.
* [ERD Lab](https://www.erdlab.io) — Ferramenta gratuita em nuvem para diagramação de relacionamento de entidades (ERD) feita para desenvolvedores. Teste gratuito inclui 2 projetos com 10 tabelas cada.
* [ExtendsClass](https://extendsclass.com/rest-client-online.html) - Cliente HTTP online gratuito para enviar requisições HTTP.
* [Export SDK](https://exportsdk.com) - API geradora de PDFs com editor de templates drag-and-drop que fornece SDK e integrações sem código. O plano gratuito possui 250 páginas mensais, usuários ilimitados e três modelos.
* [file.coffee](https://file.coffee/) - Plataforma onde você pode armazenar até 15MB/arquivo (30MB/arquivo com conta).
* [Financial Data](https://financialdata.net/) - API de dados financeiros e de mercado de ações. Plano gratuito permite 300 requisições por dia.
* [FormatJSONOnline.com](https://formatjsononline.com) - Ferramenta gratuita baseada no navegador para formatar, validar, comparar e minificar dados JSON instantaneamente.
* [FraudLabs Pro](https://www.fraudlabspro.com) — Verifique transações para fraude em pagamentos com cartão de crédito. Esta API REST detecta possíveis traços de fraude com base nos parâmetros de um pedido. O plano Free Micro permite 500 transações por mês.
* [GeoDataSource](https://www.geodatasource.com) — Serviço de busca de localização que consulta nomes de cidades usando coordenadas de latitude e longitude. API gratuita com até 500 consultas por mês.
* [Geolocated.io](https://geolocated.io) — API de Geolocalização de IP com servidores em múltiplos continentes, oferecendo plano gratuito com 2.000 requisições por dia.
* [Glitterly](https://glitterly.app/) - Gere imagens dinâmicas programaticamente a partir de templates base. API Restful e integrações sem código. O plano gratuito inclui 50 imagens/mês e cinco modelos.
* [Hex](https://hex.tech/) - Plataforma colaborativa de dados para notebooks, aplicativos de dados e bibliotecas de conhecimento. Plano comunitário gratuito com até cinco projetos.
* [Hook0](https://www.hook0.com/) - Hook0 é um serviço open-source de Webhooks-as-a-service (WaaS) que facilita para produtos online fornecerem webhooks. Despache até 100 eventos/dia com retenção de histórico de sete dias gratuitamente.
* [Hoppscotch](https://hoppscotch.io) - Ferramenta gratuita, rápida e bonita para requisições de API.
* [huggingface.co](https://huggingface.co) - Construa, treine e implante modelos NLP para Pytorch, TensorFlow e JAX. Gratuito até 30k caracteres de entrada/mês.
* [Hybiscus](https://hybiscus.dev/) - Gere relatórios em PDF usando uma API declarativa simples. O plano gratuito de 14 dias inclui 50 relatórios de página única com personalização de cores e fontes.
* [Invantive Cloud](https://cloud.invantive.com/) — Acesse mais de 70 plataformas (cloud) como Exact Online, Twinfield, ActiveCampaign ou Visma usando Invantive SQL ou OData4 (tipicamente Power BI ou Power Query). Inclui replicação e troca de dados. Plano gratuito para desenvolvedores e consultores de implementação. Gratuito para plataformas específicas com limitações de volume de dados.
* [ipaddress.sh](https://ipaddress.sh) — Serviço simples para obter o endereço IP público em diferentes [formatos](https://about.ipaddress.sh/).
* [ip-api](https://ip-api.com) — API de geolocalização de IP, gratuita para uso não comercial, sem necessidade de chave de API, limitada a 45 req/minuto do mesmo IP no plano gratuito.
* [ipbase.com](https://ipbase.com) - API de geolocalização de IP - Plano gratuito para sempre com 150 requisições mensais.
* [IP Geolocation](https://ipgeolocation.io/) — API de Geolocalização de IP - Plano gratuito para sempre para desenvolvedores com limite de 1.000 requisições por dia.
* [IP Geolocation API](https://www.abstractapi.com/ip-geolocation-api) — API de Geolocalização de IP da Abstract - Permite 1.000 requisições gratuitas.
* [IPLocate](https://www.iplocate.io) — API de Geolocalização de IP, gratuita até 1.000 requisições/dia. Inclui detecção de proxy/VPN/hospedagem, dados ASN, IP para empresa e mais. IPLocate também oferece bancos de dados gratuitos para download de IP para país e IP para ASN em formatos CSV ou MMDB compatíveis com GeoIP.
* [IP2Location](https://www.ip2location.com) — Serviço freemium de geolocalização de IP. Banco de dados LITE disponível para download gratuito. Importe o banco de dados no servidor e faça consulta local para determinar cidade, coordenadas e informações do ISP.
* [IP2Location.io](https://www.ip2location.io/) — API de geolocalização de IP freemium, rápida e confiável. Obtenha dados como cidade, coordenadas, ISP e mais. Plano gratuito inclui 50k créditos por mês. IP2Location.io também oferece 500 consultas WHOIS e domínios hospedados por mês. Veja detalhes de registro de domínio e encontre domínios hospedados em IP específico. Faça upgrade para plano pago para mais recursos.
* [ipapi](https://ipapi.co/) - API de localização de endereços IP da Kloudend, Inc - API de geolocalização confiável baseada na AWS, usada por empresas Fortune 500. O plano gratuito oferece 30k consultas/mês (1k/dia) sem cadastro.
* [ipapi.is](https://ipapi.is/) - API confiável de endereço IP feita por desenvolvedores para desenvolvedores, com as melhores capacidades de detecção de hospedagem que existem. O plano gratuito oferece 1.000 consultas sem cadastro.
* [IPinfo](https://ipinfo.io/) — API rápida, precisa e gratuita (até 50k/mês) de dados de endereço IP. Oferece APIs com detalhes de geolocalização, empresas, operadoras, faixas de IP, domínios, contatos de abuso e mais. Todas as APIs pagas podem ser testadas gratuitamente.
* [IPQuery](https://ipquery.io) — API ilimitada de IP para desenvolvedores, sem limites de taxa ou cobrança.
* [IPTrace](https://iptrace.io) — API extremamente simples que fornece dados confiáveis e úteis de geolocalização de IP para sua empresa com 50.000 consultas gratuitas por mês.
* [JSON2Video](https://json2video.com) - API de edição de vídeo para automação de vídeos de marketing e redes sociais, programaticamente ou sem código.
* [JSON IP](https://getjsonip.com) — Retorna o endereço IP público do cliente que faz a requisição. Não requer cadastro no plano gratuito. Com CORS, os dados podem ser requisitados por JS direto do navegador. Útil para monitoramento de mudanças de IP cliente e servidor. Requisições ilimitadas.
* [JSON Serve](https://jsonserve.com/) — Serviço gratuito que ajuda desenvolvedores a armazenar objetos JSON e usar esse JSON como uma API REST em seus aplicativos.
* [JSONing](https://jsoning.com/api/) — Crie uma API REST falsa a partir de um objeto JSON, personalizando códigos de status HTTP, headers e corpos de resposta.
* [konghq.com](https://konghq.com/) — Marketplace de APIs e ferramentas poderosas para APIs privadas e públicas. No plano gratuito, alguns recursos como monitoramento, alertas e suporte são limitados.
* [Kreya](https://kreya.app) — Cliente GUI gratuito para gRPC para chamar e testar APIs gRPC. Pode importar APIs gRPC via reflexão do servidor.
* [Lightly](https://www.lightly.ai/) — Melhore seus modelos de machine learning usando os dados corretos. Use conjuntos de dados de até 1.000 amostras gratuitamente.
* [LoginLlama](https://loginllama.app) - API de segurança de login para detectar acessos fraudulentos e suspeitos e notificar seus clientes. Gratuito para 1.000 logins por mês.
* [MailboxValidator](https://www.mailboxvalidator.com) — Serviço de verificação de e-mail usando conexão real com servidores para confirmar validade do e-mail. O plano gratuito de API permite 100 verificações por mês.
* [Market Data API](https://www.marketdata.app) - Fornece dados financeiros em tempo real e históricos para ações, opções, fundos mútuos e mais. O plano Free Forever permite 100 requisições diárias de API sem custo.
* [Meteosource Weather API](https://www.meteosource.com/) — API global de clima para dados meteorológicos atuais e previstos. As previsões são baseadas em uma combinação de aprendizado de máquina de vários modelos climáticos para alcançar melhor precisão. O plano gratuito oferece 400 chamadas por dia.
* [microlink.io](https://microlink.io/) – Transforma qualquer site em dados, como normalização de metatags, visualizações de links bonitas, capacidades de scraping ou screenshots como serviço. 50 requisições por dia, todos os dias grátis.
* [Mindee](https://developers.mindee.com) – O Mindee é um poderoso software de OCR e uma plataforma API-first que ajuda desenvolvedores a automatizarem fluxos de trabalho de aplicações, padronizando a camada de processamento de documentos através do reconhecimento de dados para informações chave usando visão computacional e aprendizado de máquina. O plano gratuito oferece 500 páginas por mês.
* [Mintlify](https://mintlify.com) — Padrão moderno para documentação de API. Componentes de UI bonitos e fáceis de manter, busca in-app e playground interativo. Grátis para 1 editor.
* [MockAPI](https://www.mockapi.io/) — O MockAPI é uma ferramenta simples que permite criar rapidamente APIs simuladas, gerar dados customizados e realizar operações usando uma interface RESTful. O MockAPI é destinado a prototipagem/teste/aprendizado. Um projeto/2 recursos por projeto gratuitamente.
* [Mockfly](https://www.mockfly.dev/) — O Mockfly é uma ferramenta confiável para desenvolvimento, simulação de APIs e gerenciamento de feature flags. Gere e controle rapidamente APIs simuladas com uma interface intuitiva. O plano gratuito oferece 500 requisições por dia.
* [Mocki](https://mocki.io) - Ferramenta que permite criar APIs simuladas GraphQL e REST sincronizadas com um repositório do GitHub. APIs REST simples são gratuitas para desenvolver e usar sem cadastro.
* [Mocko.dev](https://mocko.dev/) — Proxie sua API, escolha quais endpoints simular na nuvem e inspecione o tráfego, gratuitamente. Acelere seu desenvolvimento e testes de integração.
* [Mocky](https://designer.mocky.io/) - Aplicativo web simples para gerar respostas HTTP customizadas para simulação de requisições HTTP. Também disponível como [open source](https://github.com/julien-lafont/Mocky).
* [Mock N Roll](https://mpcknroll.me/) - Serviço gratuito de Mocks API—uma poderosa ferramenta para simular respostas reais de API sem atrasos de backend. Perfeito para desenvolvedores frontend, testadores de QA e equipes DevOps. [repositório](https://github.com/haerulmuttaqin/mocknroll-web).
* [microenv.com](https://microenv.com) — Crie APIs REST falsas para desenvolvedores com possibilidade de gerar código e aplicativo em um container Docker.
* [Multi-Exit IP Address Checker](https://ip.alstra.ca/) — Ferramenta gratuita e simples para checar seu endereço IP de saída em múltiplos nós e entender como seu IP aparece em diferentes regiões e serviços globais. Útil para testar ferramentas de DNS baseadas em regras como Control D.
* [Namekit](https://namekit.app/) - Descoberta de domínios impulsionada por IA – encontre nomes disponíveis a preço padrão instantaneamente. Consultas diárias gratuitas.
* [News API](https://newsapi.org) — Pesquise notícias na web via código e obtenha resultados em JSON. Desenvolvedores recebem 100 consultas gratuitas por dia. Artigos têm atraso de 24 horas.
* [numlookupapi.com](https://numlookupapi.com) - API gratuita de validação de número de telefone - 100 requisições gratuitas/mês.
* [OCR.Space](https://ocr.space/) — API de OCR que processa imagens e arquivos PDF e retorna os resultados do texto em formato JSON. 25.000 requisições por mês são gratuitas e limite de 1MB por arquivo.
* [OpenAPI3 Designer](https://openapidesigner.com/) — Crie visualmente definições Open API 3 gratuitamente.
* [parsehub.com](https://parsehub.com/) — Extraia dados de sites dinâmicos, transforme sites dinâmicos em APIs, cinco projetos gratuitos.
* [Parseur](https://parseur.com) — 20 páginas gratuitas/mês: Extraia dados de PDFs, e-mails. Impulsionado por IA. Acesso completo à API.
* [PDFBolt](https://pdfbolt.com) - API de geração de PDF focada em desenvolvedores, projetada com privacidade em mente. Oferece documentação inspirada no Stripe e inclui 500 conversões PDF gratuitas por mês.
* [pdfEndpoint.com](https://pdfendpoint.com) - Converta facilmente HTML ou URLs em PDF com uma API simples. Cem conversões por mês gratuitamente.
* [PDF-API.io](https://pdf-api.io) - API de automação PDF, editor visual de templates ou HTML para PDF, integração de dados dinâmicos e renderização de PDF via API. O plano gratuito inclui um template, 100 PDFs/mês.
* [Pixela](https://pixe.la/) - Serviço gratuito de banco de dados daystream. Todas as operações são realizadas por API. Visualização com mapas de calor e gráficos de linha também é possível.
* [Postman](https://postman.com) — Simplifique fluxos de trabalho e crie APIs melhores – mais rápido – com o Postman, uma plataforma colaborativa para desenvolvimento de APIs. Use o aplicativo Postman gratuitamente para sempre. Recursos na nuvem do Postman também são gratuitos para sempre com certos limites.
* [Insomnia](https://insomnia.rest) - Cliente de API open-source para design e teste de APIs, suporta REST e GraphQL.
* [PrefectCloud](https://www.prefect.io/cloud/) — Plataforma completa para automação de fluxos de dados. O plano gratuito inclui 5 fluxos de trabalho implantados e 500 minutos de créditos de computação serverless por mês.
* [Preset Cloud](https://preset.io/) - Serviço hospedado do Apache Superset. Gratuito para equipes de até 5 usuários, com dashboards e gráficos ilimitados, construtor de gráficos sem código e editor SQL colaborativo.
* [PromptLoop](https://www.promptloop.com/) - PromptLoop oferece web scraping com IA 10X mais fácil, quase sem tempo de adoção, mais de 85% de tempo economizado em fluxos existentes e opera 4X mais rápido que pesquisas manuais, sem comprometer e inclui endpoint REST API para todas as tarefas de pesquisa. Os primeiros 1.000 créditos são gratuitos por mês.
* [Public-Apis Github Repo](https://github.com/public-apis/public-apis) — Lista de APIs públicas gratuitas.
* [Rapidapi](https://rapidapi.com/) - O maior hub de APIs do mundo. Milhões de desenvolvedores encontram e conectam-se a milhares de APIs, desenvolvimento de APIs usando desafios divertidos (com soluções!) e exemplos interativos.
* [RequestBin.com](https://requestbin.com) — Crie um endpoint gratuito para o qual você pode enviar requisições HTTP. Todas as requisições enviadas para esse endpoint serão registradas com o payload e headers associados para que você possa observar recomendações de webhooks e outros serviços.
* [reqres.in](https://reqres.in) - Uma API REST hospedada gratuitamente pronta para responder às suas requisições AJAX.
* [Roboflow](https://roboflow.com) - Crie e implemente um modelo de visão computacional customizado sem experiência prévia em machine learning. O plano gratuito inclui 30 créditos por mês.
* [ROBOHASH](https://robohash.org/) - Serviço web para gerar imagens únicas e legais a partir de qualquer texto.
* [Scraper's Proxy](https://scrapersproxy.com) — API de proxy HTTP simples para scraping. Raspe anonimamente sem se preocupar com restrições, bloqueios ou captchas. Primeiros 100 scrapes bem-sucedidos por mês gratuitos, incluindo renderização de javascript (mais disponível se você contatar o suporte).
* [ScrapingAnt](https://scrapingant.com/) — API de scraping com Chrome headless e proxies verificados gratuitos. Renderização de javascript, proxies rotativos premium, evitando CAPTCHAs. 10.000 créditos de API gratuitos.
* [Simplescraper](https://simplescraper.io) — Dispare seu webhook após cada operação. O plano gratuito inclui 100 créditos de scraping na nuvem.
* [Select Star](https://www.selectstar.com/) - Plataforma inteligente de descoberta de dados que analisa e documenta automaticamente seus dados. Plano gratuito light com 2 fontes de dados, até 1.000 tabelas e 25 usuários.
* [Sheetson](https://sheetson.com) - Transforme instantaneamente qualquer Google Sheets em uma API RESTful. Plano gratuito disponível, incluindo 1.000 linhas gratuitas por planilha.
* [Shipyard](https://www.shipyardapp.com) — Plataforma de orquestração de dados low-code na nuvem. Construa com uma mistura de templates low-code e seu código (Python, Node.js, Bash, SQL). Nosso plano gratuito para desenvolvedores oferece 10 horas de execução por mês para um usuário – mais do que suficiente para automatizar vários fluxos de trabalho.
* [Siterelic](https://siterelic.com/) - A API Siterelic permite tirar screenshots, auditar sites, escanear TLS, consultar DNS, testar TTFB e mais. O plano gratuito oferece 100 requisições API por mês.
* [SerpApi](https://serpapi.com/) - API de scraping de motores de busca em tempo real. Retorna resultados JSON estruturados para Google, YouTube, Bing, Baidu, Walmart e muitos outros. O plano gratuito inclui 100 chamadas API bem-sucedidas por mês.
* [SmartParse](https://smartparse.io) - Plataforma de migração de dados e CSV para API que oferece ferramentas de desenvolvedor que economizam tempo e custo. O plano Free inclui 300 Unidades de Processamento por mês, uploads via navegador, quarentena de dados, circuit breakers e alertas de jobs.
* [Sofodata](https://www.sofodata.com/) - Crie APIs RESTful seguras a partir de arquivos CSV. Faça upload de um arquivo CSV e acesse instantaneamente os dados via API, permitindo um desenvolvimento de aplicações mais rápido. O plano gratuito inclui 2 APIs e 2.500 chamadas API por mês. Não é necessário cartão de crédito.
* [Sqlable](https://sqlable.com/) - Coleção de ferramentas SQL online gratuitas, incluindo formatador e validador SQL, testador de regex SQL, gerador de dados falsos e playgrounds de banco de dados interativos.
* [Stoplight](https://stoplight.io/) - SaaS para design colaborativo e documentação de APIs. O plano gratuito oferece ferramentas gratuitas de design, simulação e documentação.
* [Supportivekoala](https://supportivekoala.com/) — Permite autogerar imagens a partir de suas entradas via templates. O plano gratuito permite criar até 50 imagens por mês.
* [Svix](https://www.svix.com/) - Webhooks como Serviço. Envie até 50.000 mensagens/mês gratuitamente.
* [Tavily AI](https://tavily.com/) - API para busca online, insights rápidos e pesquisa abrangente, com capacidade de organização dos resultados. 1000 requisições/mês no plano Free, sem necessidade de cartão de crédito.
* [The IP API](https://theipapi.com/) - API de geolocalização de IP com 1000 requisições gratuitas/dia. Fornece informações sobre a localização de um endereço IP, incluindo país, cidade, região e mais.
* [TinyMCE](https://www.tiny.cloud) - API de edição de texto rico. Recursos principais gratuitos para uso ilimitado.
* [Tomorrow.io Weather API](https://www.tomorrow.io/weather-api/) - Oferece plano gratuito de API de clima. Fornece previsão do tempo precisa e atualizada com cobertura global, dados históricos e soluções de monitoramento climático.
* [Treblle](https://www.treblle.com) - O Treblle ajuda equipes a construir, entregar e gerenciar APIs. Com agregação avançada de logs de API, observabilidade, docs e depuração. Você tem todos os recursos gratuitamente, mas há um limite de até 250k requisições por mês no plano gratuito.
* [UniRateAPI](https://unirateapi.com) – Taxas de câmbio em tempo real para mais de 590 moedas e criptos. Chamadas API ilimitadas no plano gratuito, perfeito para desenvolvedores e aplicativos financeiros.
* [vatcheckapi.com](https://vatcheckapi.com) - API simples e gratuita para validação de número de VAT. 150 validações gratuitas por mês.
* [WeatherXu](https://weatherxu.com/) — Dados meteorológicos globais, incluindo condições atuais, previsões horárias e diárias, e alertas via API. Integra modelos de IA e sistemas de ML para analisar e combinar múltiplos modelos meteorológicos, entregando previsões mais precisas. O plano gratuito inclui 10.000 chamadas API/mês.
* [Webhook Store](https://www.openwebhook.io) - Ferramenta para armazenar webhooks de terceiros e depurá-los em localhost (estilo ngrok). Open source e auto-hospedável. Domínio pessoal gratuito *username*.github.webhook.store, domínios públicos gratuitos *anything*.webhook.store.
* [WebScraping.AI](https://webscraping.ai) - API simples para scraping web com parsing integrado, renderização Chrome e proxies. Dois mil chamadas API gratuitas por mês.
* [Weights & Biases](https://wandb.ai) — Plataforma MLOps developer-first. Construa modelos melhores mais rápido com rastreamento de experimentos, versionamento de datasets e gerenciamento de modelos. Plano gratuito para projetos pessoais apenas, com 100 GB de armazenamento incluídos.
* [What The Diff](https://whatthediff.ai) - Assistente de revisão de código com IA. O plano gratuito tem limite de 25.000 tokens mensais (~10 PRs).
* [wolfram.com](https://wolfram.com/language/) — Algoritmos embutidos baseados em conhecimento na nuvem.
* [wrapapi.com](https://wrapapi.com/) — Transforme qualquer site em uma API parametrizada. 30k chamadas API por mês.
* [Zenscrape](https://zenscrape.com/web-scraping-api) — API de scraping web com browsers headless, IPs residenciais e preços simples. Mil chamadas API gratuitas/mês e créditos extras para estudantes e ONGs.
* [Zipcodebase](https://zipcodebase.com) - API gratuita de CEP, acesso a dados de CEPs mundiais. 5.000 requisições gratuitas/mês.
* [Zipcodestack](https://zipcodestack.com) - API gratuita de CEP e validação de código postal. Dez mil requisições gratuitas/mês.
* [Zuplo](https://zuplo.com/) - Plataforma gratuita de gerenciamento de APIs para projetar, construir e implantar APIs na Edge. Adicione autenticação por chave de API, limitação de taxa, documentação para desenvolvedores e monetização a qualquer API em minutos. OpenAPI-nativo e totalmente programável com APIs web padrão & Typescript. O plano gratuito oferece até 10 projetos, ambientes de produção edge ilimitados, 1M requisições mensais e 10GB de egress.

**[⬆️ Voltar ao Topo](#table-of-contents)**

## Repositórios de Artefatos

* [Artifactory](https://jfrog.com/start-free/) - Um repositório de artefatos que suporta inúmeros formatos de pacotes como Maven, Docker, Cargo, Helm, PyPI, CocoaPods e GitLFS. Inclui a ferramenta de varredura de pacotes XRay e ferramenta CI/CD Pipelines (anteriormente Shippable) com plano gratuito de 2.000 minutos CI/CD por mês.
* [central.sonatype.org](https://central.sonatype.org) — O repositório padrão de artefatos para Apache Maven, SBT e outros sistemas de build.
* [cloudrepo.io](https://cloudrepo.io) - Repositórios Maven e PyPi privados e públicos baseados em nuvem. Gratuito para projetos open-source.
* [cloudsmith.io](https://cloudsmith.io) — Serviço de repositório simples, seguro e centralizado para Java/Maven, RedHat, Debian, Python, Ruby, Vagrant e mais. Plano gratuito + grátis para open source.
* [jitpack.io](https://jitpack.io/) — Repositório Maven para projetos JVM e Android no GitHub, gratuito para projetos públicos.
* [packagecloud.io](https://packagecloud.io/users/new?plan=free_usage_plan) — Hospedagem fácil de repositórios para pacotes Maven, RPM, DEB, PyPi, NPM e RubyGem (possui plano gratuito).
* [repsy.io](https://repsy.io) — 1 GB gratuito de repositório Maven privado/público.
* [Gemfury](https://gemfury.com) — Repositórios de artefatos privados e públicos para Maven, PyPi, NPM, Go Module, Nuget, APT e RPM. Gratuito para projetos públicos.
* [paperspace](https://www.paperspace.com/) — Construa e escale modelos de IA, desenvolva, treine e implemente aplicações de IA, plano gratuito: projetos públicos, 5Gb de armazenamento, instâncias básicas.
* [RepoForge](https://repoforge.io) - Repositório privado hospedado na nuvem para pacotes Python, Debian, NPM e registros Docker. Plano gratuito para projetos open source/públicos.
* [RepoFlow](https://repoflow.io) - RepoFlow simplifica o gerenciamento de pacotes com suporte para npm, PyPI, Docker, Go, Helm e mais. Experimente gratuitamente com 10GB de armazenamento, 10GB de banda, 100 pacotes e usuários ilimitados na nuvem, ou auto-hospedado para uso pessoal apenas.

**[⬆️ Voltar ao Topo](#table-of-contents)**

## Ferramentas para Equipes e Colaboração
* [3Cols](https://3cols.com/) - Gerenciador de snippets de código baseado em nuvem, gratuito para uso pessoal e colaborativo.
* [Bitwarden](https://bitwarden.com) — A maneira mais fácil e segura para indivíduos, equipes e organizações empresariais armazenarem, compartilharem e sincronizarem dados sensíveis.
* [Braid](https://www.braidchat.com/) — Aplicativo de chat projetado para equipes. Grátis para grupo de acesso público, usuários ilimitados, histórico e integrações. Também oferece versão open-source auto-hospedável.
* [cally.com](https://cally.com/) — Encontre o melhor horário e data para uma reunião. Simples de usar, ótimo para grupos pequenos e grandes.
* [Calendly](https://calendly.com) — Calendly é a ferramenta para conectar e agendar reuniões. O plano gratuito oferece 1 conexão de calendário por usuário e sessões ilimitadas. Apps desktop e mobile também disponíveis.
* [Discord](https://discord.com/) — Chat com salas públicas/privadas. Texto Markdown, voz, vídeo e compartilhamento de tela. Gratuito para usuários ilimitados.
* [Fibo](https://fibo.dev) - Ferramenta gratuita de scrum poker online em tempo real para equipes ágeis que permite que membros ilimitados estimem story points para planejamento mais rápido.
* [Telegram](https://telegram.org/) — Telegram é para todos que querem mensagens e chamadas rápidas e confiáveis. Usuários empresariais e pequenas equipes podem gostar de grupos grandes, nomes de usuário, aplicativos desktop e opções poderosas de compartilhamento de arquivos.
* [DevToolLab](https://devtoollab.com) — Ferramentas online para desenvolvedores oferecendo acesso gratuito a todas as ferramentas básicas, com capacidade de auto salvar uma entrada por ferramenta, velocidade de processamento padrão e suporte à comunidade.
* [Dubble](https://dubble.so/) — Criador gratuito de guias passo a passo. Tire screenshots, documente processos e colabore com sua equipe. Também suporta gravação de tela assíncrona.
* [Duckly](https://duckly.com/) — Converse e colabore em tempo real com sua equipe. Pair programming com compartilhamento de IDE, terminal, voz, vídeo e tela. Grátis para pequenas equipes.
* [Dyte](https://dyte.io) - SDK de áudio e vídeo ao vivo mais amigável para desenvolvedores, com plugins colaborativos para aumentar produtividade e engajamento. O plano gratuito inclui 10.000 minutos mensais de uso de vídeo/áudio ao vivo.
* [evernote.com](https://evernote.com/) — Ferramenta para organizar informações. Compartilhe suas notas e trabalhe junto com outros.
* [Fibery](https://fibery.io/) — Plataforma de workspace conectado. Grátis para usuários individuais, até 2 GB de espaço em disco.
* [flock.com](https://flock.com) — Uma maneira mais rápida para sua equipe se comunicar. Mensagens, canais, usuários, aplicativos e integrações ilimitados gratuitos.
* [Gather](https://www.gather.town/) - Uma maneira melhor de se reunir online. Centrado em espaços totalmente personalizáveis, o Gather torna passar tempo com suas comunidades tão fácil quanto na vida real. Gratuito para até 10 usuários simultâneos.
* [gokanban.io](https://gokanban.io) - Quadro Kanban baseado em sintaxe, sem registro, para uso rápido. Gratuito sem limitações.
* [flat.social](https://flat.social) - Espaços interativos e personalizáveis para reuniões de equipe e happy hours sociais. Reuniões ilimitadas, gratuito para até 8 usuários simultâneos.
* [GitDailies](https://gitdailies.com) - Relatórios diários da atividade de Commits e Pull Requests da sua equipe no GitHub. Inclui visualizador de Push, sistema de reconhecimento entre pares e construtor de alertas personalizados. O plano gratuito permite usuários ilimitados, três repositórios e 3 configurações de alerta.
* [gitter.im](https://gitter.im/) — Chat para GitHub. Salas públicas e privadas ilimitadas, gratuito para equipes de até 25 pessoas.
* [Hackmd.io](https://hackmd.io/) - Ferramenta de colaboração em tempo real e escrita para documentos/arquivos em formato markdown. Semelhante ao Google Docs, mas para arquivos markdown. Número ilimitado de "notas" grátis, mas o número de colaboradores (convidados) para notas privadas e modelos [será limitado](https://hackmd.io/pricing).
* [hangouts.google.com](https://hangouts.google.com/) — Um só lugar para todas as suas conversas, gratuito, requer conta Google.
* [HeySpace](https://hey.space) - Ferramenta de gestão de tarefas com chat, calendário, linha do tempo e chamadas de vídeo. Gratuito para até 5 usuários.
* [helplightning.com](https://www.helplightning.com/) — Ajuda por vídeo com realidade aumentada. Gratuito sem analytics, criptografia, suporte.
* [ideascale.com](https://ideascale.com/) — Permite que clientes enviem ideias e votem, gratuito para 25 membros em 1 comunidade.
* [Igloo](https://www.igloosoftware.com/) — Portal interno para compartilhamento de documentos, blogs, calendários, etc. Gratuito para até 10 usuários.
* [Keybase](https://keybase.io/) — O Keybase é uma alternativa FOSS ao Slack; mantém chats e arquivos seguros, de famílias a comunidades e empresas.
* [Google Meet](https://meet.google.com/) — Use o Google Meet para reuniões de vídeo online do seu negócio. O Meet oferece reuniões online seguras e fáceis de participar.
* [/meet for Slack](https://meetslack.com) - Inicie reuniões do Google diretamente do Slack usando /meet em qualquer canal, grupo ou DM. Gratuito sem limitações.
* [Livecycle](https://www.livecycle.io/) — Plataforma de colaboração inclusiva que torna fluxos de trabalho sem fricção para equipes de produto multifuncionais e projetos open-source.
* [Lockitbot](https://www.lockitbot.com/) — Reserve e bloqueie recursos compartilhados dentro do Slack, como salas, ambientes de desenvolvimento, servidores, etc. Gratuito para até 2 recursos.
* [MarkUp](https://www.markup.io/) — O MarkUp permite coletar feedback diretamente em seus sites, PDFs e imagens.
* [Proton Pass](https://proton.me/pass) — Gerenciador de senhas com aliases de e-mail integrados, autenticador 2FA, compartilhamento e passkeys. Disponível na web, extensão de navegador, app móvel e desktop.
* [Visual Debug](https://visualdebug.com) - Ferramenta visual de feedback para melhorar a comunicação cliente-dev.
* [meet.jit.si](https://meet.jit.si/) — Conversas em vídeo com um clique e compartilhamento de tela, gratuito.
* [Microsoft Teams](https://products.office.com/microsoft-teams/free) — O Microsoft Teams é um hub digital baseado em chat que reúne conversas, conteúdo e aplicativos em um único lugar. Gratuito para até 500 mil usuários.
* [Miro](https://miro.com/) - Quadro colaborativo escalável, seguro, multi-dispositivo e pronto para empresas, para equipes distribuídas. Plano freemium disponível.
* [nootiz](https://www.nootiz.com/) - Ferramenta para coletar e gerenciar feedback visual em qualquer site.
* [Notion](https://www.notion.so/) - O Notion é um aplicativo de anotações e colaboração com suporte a markdown que integra tarefas, wikis e bancos de dados. É descrito como um workspace tudo-em-um para anotações, gerenciamento de projetos e tarefas. Além de apps multiplataforma, pode ser acessado via navegadores web.
* [Nuclino](https://www.nuclino.com) - Wiki leve e colaborativa para todo o conhecimento, documentos e anotações da equipe. Plano gratuito com recursos essenciais, até 50 itens e 5GB de armazenamento.
* [OnlineInterview.io](https://onlineinterview.io/) - Plataforma gratuita para entrevistas de código com chat de vídeo integrado, quadro de desenho e editor de código online onde você pode compilar e rodar seu código no navegador. Crie uma sala de entrevista remota com um clique.
* [Quidlo Timesheets](https://www.quidlo.com/timesheets) - App simples de controle de ponto e timesheet para equipes. O plano gratuito permite até 10 usuários, controle de tempo e geração de relatórios.
* [PageShare.dev](https://www.pageshare.dev) - Adiciona recursos de revisão visual aos Pull Requests do GitHub sem necessidade de deploy dos sites. Gratuito para até 10 páginas por mês e 100MB de armazenamento no total.
* [Pendulums](https://pendulums.io/) - Ferramenta gratuita de controle de tempo que ajuda a gerenciar seu tempo de forma melhor, com interface fácil e estatísticas valiosas.
* [Pumble](https://pumble.com) - App gratuito de chat para equipes. Usuários e histórico de mensagens ilimitados, grátis para sempre.
* [Raindrop.io](https://raindrop.io) - Aplicativo privado e seguro de favoritos para macOS, Windows, Android, iOS e Web. Favoritos e colaboração ilimitados gratuitos.
* [element.io](https://element.io/) — Ferramenta descentralizada e open-source de comunicação baseada em Matrix. Chats em grupo, mensagens diretas, transferência de arquivos criptografados, chats de voz e vídeo e fácil integração com outros serviços.
* [Rocket.Chat](https://rocket.chat/) - Plataforma de comunicação open-source com recursos Omnichannel, Federação Matrix, Bridge com outros apps, mensagens ilimitadas e histórico completo.
* [seafile.com](https://www.seafile.com/) — Armazenamento privado ou em nuvem, compartilhamento de arquivos, sincronização, discussões. A versão cloud tem apenas 1 GB.
* [Sema](https://www.semasoftware.com/) - Ferramenta gratuita de portfólio para desenvolvedores, capaz de consolidar e capturar contribuições de múltiplos repositórios em um único relatório.
* [Screen Sharing via Browser](https://screensharing.net) - Ferramenta gratuita de compartilhamento de tela, compartilhe sua tela com colaboradores direto do navegador, sem download ou registro. Gratuito.
* [Slab](https://slab.com/) — Serviço moderno de gestão de conhecimento para equipes. Gratuito para até 10 usuários.
* [slack.com](https://slack.com/) — Gratuito para usuários ilimitados com algumas limitações de recursos.
* [Spectrum](https://spectrum.chat/) - Crie comunidades públicas ou privadas gratuitamente.
* [StatusPile](https://www.statuspile.com/) - Página de status das páginas de status. Permite acompanhar o status de provedores upstream.
* [Stickies](https://stickies.app/) - App de colaboração visual usado para brainstorming, curadoria de conteúdo e anotações. Gratuito para até 3 paredes, usuários ilimitados e 1 GB de armazenamento.
* [Stacks](https://betterstacks.com/) - Espaço de trabalho de conteúdo com anotações, links e armazenamento de arquivos integrados para navegar sobrecarga de informação. Plano pessoal gratuito para sempre.
* [talky.io](https://talky.io/) — Chat de vídeo em grupo gratuito. Anônimo. Peer-to-peer. Sem plugins, cadastro ou pagamento necessário.
* [Teamhood](https://teamhood.com/) - Software gratuito de gerenciamento de projetos, tarefas e issues. Suporta Kanban com Swimlanes e implementação completa de Scrum. Tem controle de tempo integrado. Gratuito para cinco usuários e três portfólios de projetos.
* [Teamplify](https://teamplify.com) - Melhore processos de desenvolvimento de equipe com Analytics e Smart Daily Standup. Inclui gestão completa de folgas para equipes remotas. Gratuito para grupos de até 5 usuários.
* [Tefter](https://tefter.io) - Aplicativo de favoritos com integração poderosa ao Slack. Gratuito para equipes open-source.
* [TeleType](https://teletype.oorja.io/) — Compartilhe terminais, voz, código, quadro branco e mais. Não é necessário login para colaboração criptografada de ponta-a-ponta para desenvolvedores.
* [TimeCamp](https://www.timecamp.com/) - Software gratuito de controle de tempo para usuários ilimitados. Integra-se facilmente a ferramentas de PM como Jira, Trello, Asana, etc.
* [Huly](https://huly.io/) - Plataforma de gerenciamento de projetos tudo-em-um (alternativa ao Linear, Jira, Slack, Notion, Motion) - usuários ilimitados, 10GB de armazenamento por workspace, 10GB de tráfego de vídeo(áudio).
* [Teamcamp](https://www.teamcamp.app) - Aplicação tudo-em-um de gerenciamento de projetos para empresas de desenvolvimento de software.
* [twist.com](https://twist.com) — Aplicativo de comunicação para equipes voltado para assíncrono, onde conversas permanecem organizadas e no tópico. Planos Gratuito e Ilimitado disponíveis. Descontos para equipes elegíveis.
* [tldraw.com](https://tldraw.com) — Ferramenta open-source gratuita para quadro branco e diagramas com setas inteligentes, snapping, post-its e exportação em SVG. Modo multiplayer para edição colaborativa. Extensão oficial gratuita para VS Code disponível.
* [BookmarkOS.com](https://bookmarkos.com) - Gerenciador de favoritos, abas e tarefas tudo-em-um, gratuito, em um desktop online personalizável com colaboração por pastas.
* [typetalk.com](https://www.typetalk.com/) — Compartilhe e discuta ideias com sua equipe via mensagens instantâneas na web ou móvel.
* [Tugboat](https://tugboat.qa) - Preview de cada pull request, automatizado e sob demanda. Gratuito para todos, Nano tier complementar para organizações sem fins lucrativos.
* [whereby.com](https://whereby.com/) — Conversas em vídeo com um clique, gratuitamente (anteriormente conhecido como appear.in).
* [windmill.dev](https://windmill.dev/) - Plataforma open-source para desenvolvedores criarem automações e apps internos de produção rapidamente a partir de scripts mínimos em Python e Typescript. Usuários gratuitos podem criar e participar de no máximo três workspaces não-premium.
* [vadoo.tv](https://vadoo.tv/) — Hospedagem e marketing de vídeos simplificados. Faça upload com um clique. Grave, gerencie, compartilhe e mais. O plano gratuito permite até 10 vídeos, 1 GB de armazenamento e 10 GB de banda/mês.
* [userforge.com](https://userforge.com/) - Personas online interconectadas, histórias de usuário e mapeamento de contexto. Ajuda a manter design e dev sincronizados, gratuito para até 3 personas e dois colaboradores.
* [wistia.com](https://wistia.com/) — Hospedagem de vídeo com analytics de visualização, entrega HD e ferramentas de marketing para entender seus visitantes. 25 vídeos e player com marca Wistia.
* [wormhol.org](https://www.wormhol.org/) — Serviço simples de compartilhamento de arquivos. Compartilhe arquivos ilimitados até 5GB com quantos pares quiser.
* [Wormhole](https://wormhole.app/) - Compartilhe arquivos até 5GB com criptografia ponta-a-ponta por até 24h. Para arquivos maiores que 5GB, usa transferência peer-to-peer direta.
* [zoom.us](https://zoom.us/) — Videoconferência segura e complementos web. O plano gratuito é limitado a 40 minutos.
* [Zulip](https://zulip.com/) — Chat em tempo real com modelo exclusivo de threading semelhante a e-mail. O plano gratuito inclui 10.000 mensagens de histórico de busca e até 5 GB de armazenamento de arquivos. Versão open-source self-hosted disponível.
* [robocorp.com](https://robocorp.com) - Stack open-source para automação Ops. Experimente recursos Cloud e implemente automações simples gratuitamente. Trabalho de robô 240 min/mês, 10 execuções de Assistente, 100 MB de armazenamento.
* [Fleep.io](https://fleep.io/) — Fleep, alternativa ao Slack. Plano gratuito para pequenas equipes com histórico completo, conversas 1:1 ilimitadas, 1 conversa em grupo e 1 GB de armazenamento.
* [Chanty.com](https://chanty.com/) — Chanty é outra alternativa ao Slack. Plano gratuito para sempre para equipes pequenas (até 10) com conversas públicas e privadas ilimitadas, histórico pesquisável, chamadas de áudio 1:1 ilimitadas, mensagens de voz ilimitadas, dez integrações e 20 GB de armazenamento por equipe.
* [ruttl.com](https://ruttl.com/) — Ferramenta tudo-em-um para coleta de feedback digital e revisão de sites, PDFs e imagens.
* [Mattermost](https://mattermost.com/) — Colaboração segura para equipes técnicas. Plano gratuito com canais, playbooks, quadros, usuários ilimitados, 10GB de armazenamento e mais.
* [Webvizio](https://webvizio.com) — Ferramenta de feedback de site, revisão de sites e relatório de bugs para colaboração direta em sites, web apps, imagens, PDFs e arquivos de design.
* [Pullflow](https://pullflow.com) — Plataforma aprimorada por IA para colaboração em revisão de código no GitHub, Slack e VS Code.
* [Webex](https://www.webex.com/) — Reuniões por vídeo com plano gratuito de 40 minutos por reunião e até 100 participantes.
* [RingCentral](https://www.ringcentral.com/) — Reuniões por vídeo com plano gratuito de 50 minutos por reunião e até 100 participantes.
* [GitBook](https://www.gitbook.com/) — Plataforma para captura e documentação de conhecimento técnico — de docs de produto a bases de conhecimento internas e APIs. Plano gratuito para desenvolvedores individuais.
* [transfernow](https://www.transfernow.net/) — Interface mais simples, rápida e segura para transferir e compartilhar arquivos. Envie fotos, vídeos e outros arquivos grandes sem assinatura obrigatória.
* [paste.sh](https://paste.sh/) — Site de paste simples baseado em JavaScript e Crypto.
* [Revolt.chat](https://revolt.chat/) — Alternativa OpenSource ao [Discord](https://discord.com/), que respeita sua privacidade. Possui a maioria dos recursos proprietários do Discord gratuitamente. Revolt é uma aplicação tudo-em-um, segura e rápida, 100% gratuita. Todos os recursos são gratuitos. Suporta plugins (oficiais e não oficiais), ao contrário da maioria dos apps de chat tradicionais.
* [Tencent RTC](https://trtc.io/) — Tencent Real-Time Communication (TRTC) oferece soluções para chamadas de áudio/vídeo em grupo. 10.000 minutos gratuitos/mês no primeiro ano.
* [Pastefy](https://pastefy.app/) - Pastebin bonito e simples, com criptografia opcional no cliente, multitab, API, editor destacado e mais.
* [SiteDots](https://sitedots.com/) - Compartilhe feedback para projetos de sites diretamente no seu site, sem emulação, canvas ou alternativas. Camada gratuita totalmente funcional.

**[⬆️ Voltar ao topo](#table-of-contents)**

## CMS

* [acquia.com](https://www.acquia.com/) — Hospedagem para sites Drupal. Camada gratuita para desenvolvedores. Ferramentas de desenvolvimento gratuitas (como Acquia Dev Desktop) também disponíveis.
* [Contentful](https://www.contentful.com/) — Headless CMS. Gerenciamento de conteúdo e APIs de entrega na nuvem. Inclui um espaço gratuito Community com cinco usuários, 25 mil registros, 48 tipos de conteúdo, 2 idiomas.
* [Cosmic](https://www.cosmicjs.com/) — Headless CMS e toolkit de API. Planos pessoais gratuitos para desenvolvedores.
* [Crystallize](https://crystallize.com) — PIM headless com suporte a ecommerce. API GraphQL embutida. Versão gratuita inclui usuários ilimitados, 1000 itens de catálogo, 5 GB/mês de banda e 25k/mês de chamadas API.
* [DatoCMS](https://www.datocms.com/) - Oferece camada gratuita para pequenos projetos. DatoCMS é um CMS baseado em GraphQL. No plano básico, são permitidas 100k chamadas/mês.
* [Directus](https://directus.io) — Headless CMS. Plataforma completamente gratuita e open-source para gerenciar ativos e conteúdo de banco de dados on-premises ou na nuvem. Sem limitações ou paywalls.
* [FrontAid](https://frontaid.io/) — Headless CMS que armazena conteúdo JSON diretamente no seu repositório Git. Sem restrições.
* [kontent.ai](https://www.kontent.ai) - Plataforma Content-as-a-Service que oferece todos os benefícios de um CMS headless e empodera os profissionais de marketing ao mesmo tempo. O plano para desenvolvedores fornece dois usuários com projetos ilimitados, dois ambientes por projeto, 500 itens de conteúdo, dois idiomas, Delivery e Management API, e suporte a elementos personalizados. Planos mais detalhados disponíveis conforme a necessidade.
* [Prismic](https://www.prismic.io/) — Headless CMS. Interface de gerenciamento de conteúdo com API totalmente hospedada e escalável. O Community Plan oferece chamadas ilimitadas de API, documentos, tipos personalizados, ativos e idiomas para um usuário. Tudo o que você precisa para seu próximo projeto. Planos gratuitos maiores para projetos Open Content/Open Source.
* [Sanity.io](https://www.sanity.io/) - Plataforma para conteúdo estruturado com ambiente de edição open-source e armazenamento de dados em tempo real. Projetos ilimitados. Usuários admin ilimitados, três usuários não-admin, dois datasets, 500K requisições CDN na API, 10GB de banda e 5GB de ativos grátis por projeto.
* [sensenet](https://sensenet.com) - CMS headless API-first com soluções de nível empresarial para negócios de todos os tamanhos. O plano Developer oferece três usuários, 500 itens de conteúdo, três papéis embutidos, 25+5 tipos de conteúdo, REST API acessível, geração de preview de documentos e edição Office Online.
* [TinaCMS](https://tina.io/) — Substituindo o Forestry.io. CMS headless open source baseado em Git, com suporte a Markdown, MDX e JSON. Oferta básica gratuita com dois usuários disponíveis.
* [GatsbyjsCMS](https://www.gatsbyjs.com/) - Gatsby é um framework rápido e flexível que torna a criação de sites com qualquer CMS, API ou banco de dados divertida novamente. Construa e faça deploy de sites headless que atraem mais tráfego, convertem melhor e geram mais receita!
* [Hygraph](https://hygraph.com/) - Oferece camada gratuita para pequenos projetos. API GraphQL first. Migre de soluções legadas para o Headless CMS nativo em GraphQL e entregue conteúdo omnichannel, API first.
  * [Squidex](https://squidex.io/) - Oferece um plano gratuito para pequenos projetos. API / GraphQL first. Código aberto e baseado em event sourcing (versionando automaticamente cada alteração).
  * [InstaWP](https://instawp.com/) - Lance um site WordPress em poucos segundos. Um plano gratuito com 5 sites ativos, 500 MB de espaço, expiração do site em 48 horas.
  * [Storyblok](https://www.storyblok.com) - Um CMS Headless para desenvolvedores e profissionais de marketing que funciona com todos os frameworks modernos. O plano Community (gratuito) oferece Management API, Editor Visual, dez fontes, Tipos de Campos Personalizados, Internacionalização (idiomas/locais ilimitados), Gerenciador de Ativos (até 2500 ativos), Serviço de Otimização de Imagens, Consulta de Pesquisa, Webhook + 250GB de tráfego/mês incluídos.
  * [WPJack](https://wpjack.com) - Configure o WordPress em qualquer nuvem em menos de 5 minutos! O plano gratuito inclui 1 servidor, 2 sites, certificados SSL gratuitos e cron jobs ilimitados. Sem limites de tempo ou expirações — seu site, do seu jeito.

**[⬆️ Voltar ao topo](#table-of-contents)**

## Geração de Código

  * [Appinvento](https://appinvento.io/) — AppInvento é um construtor de aplicativos no-code gratuito. No backend gerado automaticamente, os usuários têm acesso completo ao código-fonte e APIs e rotas ilimitadas, permitindo ampla integração. O plano gratuito inclui três projetos, cinco tabelas e um add-on do Google.
  * [Cody AI](https://sourcegraph.com/cody) - Cody é um assistente de codificação com IA que utiliza inteligência artificial e compreensão profunda da sua base de código para ajudar você a escrever e entender código mais rápido. Cody oferece escolha de LLMs aos desenvolvedores (incluindo inferência local), suporte para diversos IDEs, suporta todas as linguagens populares de programação e possui plano gratuito. O plano gratuito oferece aos desenvolvedores 20 mensagens de chat (usando Claude 3 Sonnet como LLM) e 500 autocompletes (usando o Starcoder 16b) por mês.
  * [DhiWise](https://www.dhiwise.com/) — Transforme designs do Figma em aplicativos dinâmicos Flutter & React de forma fluida com a tecnologia inovadora de geração de código do DhiWise, otimizando seu fluxo de trabalho e ajudando a criar experiências web e mobile excepcionais mais rápido do que nunca.
  * [Codeium](https://www.codeium.com/) — Codeium é uma ferramenta gratuita de autocompletar código baseada em IA. Suporta mais de 20 linguagens de programação (Python, JavaScript, Java, TypeScript, PHP, C/C++, Go, etc.) e integra-se com todos os principais IDEs locais e web.
  * [Fern](https://buildwithfern.com) - Escreva definições de API e use-as para gerar SDKs/bibliotecas cliente em linguagens populares como TypeScript, Python, Java, Go e mais. Suporte total ao OpenAPI. O plano gratuito gera código para até 20 endpoints.
  * [Metalama](https://www.postsharp.net/metalama) - Apenas para C#. Metalama gera o boilerplate do código dinamicamente durante a compilação para que seu código-fonte permaneça limpo. Gratuito para projetos open-source, e o plano gratuito comercialmente amigável inclui três aspects.
  * [Supermaven](https://www.supermaven.com/) — Supermaven é um plugin rápido de autocompletar código com IA para VSCode, JetBrains e Neovim. O plano gratuito oferece autocompletes inline ilimitados.
  * [tabnine.com](https://www.tabnine.com/) — Tabnine ajuda desenvolvedores a criar softwares melhores e mais rápido, fornecendo insights aprendidos de todo o código do mundo. Plugin disponível.
  * [v0.dev](https://v0.dev/) — v0 usa modelos de IA para gerar código baseado em prompts de texto simples. Gera código React pronto para copiar e colar baseado em shadcn/ui e Tailwind CSS que pode ser usado em projetos. Cada geração consome no mínimo 30 créditos. Você começa com 1200 créditos e recebe 200 créditos gratuitos todo mês.

**[⬆️ Voltar ao topo](#table-of-contents)**

## Qualidade de Código

  * [beanstalkapp.com](https://beanstalkapp.com/) — Um fluxo de trabalho completo para escrever, revisar e fazer deploy de código, conta gratuita para um usuário e um repositório com 100 MB de armazenamento
  * [browserling.com](https://www.browserling.com/) — Testes interativos de cross-browser ao vivo, sessões gratuitas de 3 minutos apenas com MS IE 9 sob Vista em resolução 1024 x 768
  * [codacy.com](https://www.codacy.com/) — Revisões automáticas de código para PHP, Python, Ruby, Java, JavaScript, Scala, CSS e CoffeeScript, gratuito para repositórios públicos e privados ilimitados
  * [Codeac.io](https://www.codeac.io/infrastructure-as-code.html?ref=free-for-dev) - Ferramenta automatizada de revisão de Infrastructure as Code para DevOps, integra-se ao GitHub, Bitbucket e GitLab (mesmo self-hosted). Além das linguagens padrão, também analisa Ansible, Terraform, CloudFormation, Kubernetes e mais. (open-source gratuito)
  * [CodeBeat](https://codebeat.co) — Plataforma automatizada de revisão de código disponível para várias linguagens. Grátis para sempre para repositórios públicos com integração Slack e e-mail.
  * [codeclimate.com](https://codeclimate.com/) — Revisão automatizada de código, gratuito para Open Source e repositórios privados de organizações ilimitados (até 4 colaboradores). Também gratuito para estudantes e instituições.
  * [codecov.io](https://codecov.io/) — Ferramenta de cobertura de código (SaaS), gratuita para Open Source e um repositório privado gratuito
  * [CodeFactor](https://www.codefactor.io) — Revisão automatizada de código para Git. A versão gratuita inclui usuários ilimitados, repositórios públicos e um repositório privado.
  * [coderabbit.ai](https://coderabbit.ai) — Ferramenta de revisão de código com IA que integra com GitHub/GitLab. O plano gratuito inclui 200 arquivos/hora, 3 revisões por hora e 50 conversas/hora. Gratuito para sempre para projetos open source.
  * [codescene.io](https://codescene.io/) - O CodeScene prioriza dívidas técnicas com base em como os desenvolvedores trabalham com o código e visualiza fatores organizacionais como acoplamento de equipe e domínio do sistema. Gratuito para Open Source.
  * [CodSpeed](https://codspeed.io) - Automatize o acompanhamento de performance em seus pipelines de CI. Identifique regressões de desempenho antes do deploy, graças a métricas precisas e consistentes. Gratuito para sempre para projetos Open Source.
  * [coveralls.io](https://coveralls.io/) — Exibe relatórios de cobertura de testes, gratuito para Open Source
  * [dareboost](https://dareboost.com) - 5 relatórios gratuitos de análise por mês para performance web, acessibilidade e segurança
  * [deepcode.ai](https://www.deepcode.ai) — DeepCode encontra bugs, vulnerabilidades de segurança, problemas de performance e API com base em IA. A velocidade de análise do DeepCode permite analisar seu código em tempo real e entregar resultados ao salvar no IDE. Suporta Java, C/C++, JavaScript, Python e TypeScript. Integrações com GitHub, BitBucket e GitLab. Gratuito para open source e repositórios privados e até 30 desenvolvedores.
  * [deepscan.io](https://deepscan.io) — Análise estática avançada para encontrar automaticamente erros de runtime em código JavaScript, gratuito para Open Source
  * [DeepSource](https://deepsource.io/) - DeepSource analisa continuamente mudanças no código-fonte, encontrando e corrigindo problemas categorizados como segurança, performance, anti-patterns, riscos de bug, documentação e estilo. Integração nativa com GitHub, GitLab e Bitbucket.
  * [DiffText](https://difftext.com) - Encontre instantaneamente as diferenças entre dois blocos de código. Totalmente gratuito para uso.
  * [eversql.com](https://www.eversql.com/) — EverSQL - A plataforma #1 para otimização de banco de dados. Obtenha insights críticos sobre seu banco de dados e queries SQL automaticamente.
  * [gerrithub.io](https://review.gerrithub.io/) — Gerrit code review para repositórios GitHub gratuitamente
  * [gocover.io](https://gocover.io/) — Cobertura de código para qualquer pacote [Go](https://golang.org/)
  * [goreportcard.com](https://goreportcard.com/) — Qualidade de código para projetos Go, gratuito para Open Source
  * [gtmetrix.com](https://gtmetrix.com/) — Relatórios e recomendações detalhadas para otimizar websites
  * [holistic.dev](https://holistic.dev/) - O analisador de código estático nº 1 para otimização de Postgresql. Serviço de detecção automática de questões de performance, segurança e arquitetura de banco de dados
  * [houndci.com](https://houndci.com/) — Comenta sobre commits do GitHub a respeito de qualidade de código, gratuito para Open Source
  * [Moderne.io](https://app.moderne.io) — Refatoração automática de código-fonte. O Moderne oferece migrações de frameworks, análise de código com remediação e transformação de código em escala, para que os desenvolvedores possam focar em construir coisas novas em vez de manter as antigas. Gratuito para Open Source.
  * [reviewable.io](https://reviewable.io/) — Revisão de código para repositórios GitHub, gratuito para repositórios públicos ou pessoais.
  * [parsers.dev](https://parsers.dev/) - Parsers de árvore de sintaxe abstrata e compiladores de representação intermediária como serviço
  * [scan.coverity.com](https://scan.coverity.com/) — Análise estática de código para Java, C/C++, C# e JavaScript, gratuito para Open Source
  * [scrutinizer-ci.com](https://scrutinizer-ci.com/) — Plataforma de inspeção contínua, gratuito para Open Source
  * [semanticdiff.com](https://app.semanticdiff.com/) — Diff ciente de linguagem de programação para pull requests e commits do GitHub, gratuito para repositórios públicos
  * [shields.io](https://shields.io) — Badges de metadados de qualidade para projetos open source
  * [sonarcloud.io](https://sonarcloud.io) — Análise automática de código-fonte para Java, JavaScript, C/C++, C#, VB.NET, PHP, Objective-C, Swift, Python, Groovy e mais linguagens, gratuito para Open Source
  * [SourceLevel](https://sourcelevel.io/) — Revisão automatizada de código e análise de times. Gratuito para Open Source e organizações com até 5 colaboradores.
  * [webceo.com](https://www.webceo.com/) — Ferramentas de SEO mas também com verificações de código e diversos tipos de dispositivos
  * [zoompf.com](https://zoompf.com/) — Corrija a performance dos seus sites, análise detalhada

**[⬆️ Voltar ao topo](#table-of-contents)**

## Busca e Navegação de Código

  * [libraries.io](https://libraries.io/) — Pesquisa e notificações de atualização de dependências para 32 gerenciadores de pacotes diferentes, gratuito para open source
  * [Namae](https://namae.dev/) - Pesquise em vários sites como GitHub, Gitlab, Heroku, Netlify e muitos outros para disponibilidade do nome do seu projeto.
  * [searchcode.com](https://searchcode.com/) — Busca de código baseada em texto abrangente, gratuita para Open Source
  * [tickgit.com](https://www.tickgit.com/) — Mostra comentários `TODO` (e outros marcadores) para identificar áreas de código que merecem melhorias.
  * [CodeKeep](https://codekeep.io) - Google Keep para trechos de código. Organize, descubra e compartilhe snippets de código, com ferramenta poderosa de captura de tela de código com modelos predefinidos e recurso de vinculação.

**[⬆️ Voltar ao topo](#table-of-contents)**

## CI e CD

  * [AccessLint](https://github.com/marketplace/accesslint) — AccessLint traz testes automatizados de acessibilidade web para seu fluxo de trabalho de desenvolvimento. Gratuito para open source e fins educacionais.
  * [appcircle.io](https://appcircle.io) — Plataforma DevOps mobile de nível empresarial que automatiza build, teste e publicação de apps móveis para ciclos de lançamento mais rápidos e eficientes. Gratuito para 30 minutos de build por build, 20 builds mensais e 1 build simultâneo.
  * [appveyor.com](https://www.appveyor.com/) — Serviço de CD para Windows, gratuito para Open Source
  * [LocalOps](https://localops.co/) - Faça deploy de seu app na AWS/GCP/Azure em menos de 30 minutos. Configure ambientes padronizados de app em qualquer nuvem, com automação de deploy contínuo e observabilidade avançada. O plano gratuito permite 1 usuário e 1 ambiente de app.
  * [Argonaut](https://argonaut.dev/) - Faça deploy de apps e infraestrutura na sua nuvem em minutos. Suporte para deploys de apps personalizados e de terceiros em ambientes Kubernetes e Lambda. O plano gratuito permite apps e deploys ilimitados para 5 domínios e 2 usuários.
  * [bitrise.io](https://www.bitrise.io/) — CI/CD para apps mobile, nativos ou híbridos. Com 200 builds gratuitos/mês, 10 min por build e dois membros na equipe. Projetos OSS têm 45 min por build, +1 concorrência e equipe ilimitada.
  * [buddy.works](https://buddy.works/) — CI/CD com cinco projetos gratuitos e uma execução concorrente (120 execuções/mês)
  * [Buildkite](https://buildkite.com) Pipelines de CI gratuitos para 3 usuários e 5k minutos de job/mês. Test Analytics com tier gratuito para desenvolvedor inclui 100k execuções de testes/mês, com mais benefícios para projetos open source.
  * [bytebase.com](https://www.bytebase.com/) — CI/CD e DevOps para bancos de dados. Gratuito para menos de 20 usuários e dez instâncias de banco de dados
  * [CircleCI](https://circleci.com/) — Plano gratuito abrangente com todos os recursos incluídos em serviço de CI/CD hospedado para repositórios GitHub, GitLab e BitBucket. Múltiplas classes de recurso, Docker, Windows, Mac OS, executores ARM, runners locais, divisão de testes, Docker Layer Caching e outros recursos avançados de CI/CD. Gratuito para até 6000 minutos/mês de execução, colaboradores ilimitados, 30 jobs paralelos em projetos privados e até 80.000 minutos de build gratuitos para projetos Open Source.
  * [cirrus-ci.org](https://cirrus-ci.org) - Gratuito para repositórios públicos do GitHub
  * [cirun.io](https://cirun.io) - Gratuito para repositórios públicos do GitHub
  * [codefresh.io](https://codefresh.io) — Plano Free-for-Life: 1 build, um ambiente, servidores compartilhados, repositórios públicos ilimitados
  * [codemagic.io](https://codemagic.io/) - 500 minutos de build gratuitos/mês
  * [codeship.com](https://codeship.com/) — 100 builds privados/mês, cinco projetos privados, ilimitado para Open Source
  * [deploybot.com](https://www.deploybot.com/) — 1 repositório com dez deploys, gratuito para Open Source
  * [deployhq.com](https://www.deployhq.com/) — 1 projeto com dez deploys diários (30 minutos de build/mês)
  * [drone](https://cloud.drone.io/) - Drone Cloud permite rodar pipelines de Continuous Delivery em múltiplas arquiteturas - incluindo x86 e Arm (32 e 64 bits) - tudo em um só lugar
  * [LayerCI](https://layerci.com) — CI para projetos full stack. Um ambiente de preview full stack com 5GB de memória e 3 CPUs.
  * [semaphoreci.com](https://semaphoreci.com/) — Gratuito para Open Source, 100 builds privados por mês
  * [Squash Labs](https://www.squash.io/) — Cria uma VM para cada branch e deixa seu app disponível em uma URL única, repositórios públicos e privados ilimitados, VMs de até 2 GB.
  * [styleci.io](https://styleci.io/) — Apenas repositórios públicos do GitHub
  * [Mergify](https://mergify.io) — automação de fluxo de trabalho e fila de merge para GitHub — Gratuito para repositórios públicos do GitHub
  * [Make](https://www.make.com/en) — Ferramenta de automação de fluxo de trabalho que permite conectar apps e automatizar fluxos usando interface visual. Suporta muitos apps e as APIs mais populares. Gratuito para repositórios públicos do GitHub e plano gratuito com 100 Mb, 1000 operações e 15 minutos de intervalo mínimo.
  * [Spacelift](https://spacelift.io/) - Plataforma de gerenciamento para Infrastructure as Code. Recursos do plano gratuito: colaboração IaC, registro de módulos Terraform, integração ChatOps, compliance contínuo de recursos com Open Policy Agent, SSO com SAML 2.0 e acesso a public worker pools: até 200 minutos/mês
  * [microtica.com](https://microtica.com/) - Ambientes para startups com componentes de infraestrutura prontos, faça deploy de apps na AWS gratuitamente e suporte suas cargas de produção. O plano gratuito inclui 1 ambiente (na sua conta AWS), 2 serviços Kubernetes, 100 minutos de build por mês e 20 deploys mensais.
* [Nx Cloud](https://nx.dev/ci) - Nx Cloud acelera seus monorepos em CI com recursos como cache remoto, distribuição de tarefas entre máquinas e até divisão automatizada das execuções dos seus testes e2e. Possui um plano gratuito para até 30 colaboradores, incluindo generosos 150 mil créditos.
* [blacksmith](https://www.blacksmith.sh/) - Runners de performance gerenciados para GitHub Actions que oferecem 3.000 minutos gratuitos por mês, sem necessidade de cartão de crédito.
* [Terramate](https://terramate.io/) - Terramate é uma plataforma de orquestração e gerenciamento para ferramentas de Infrastructure as Code (IaC) como Terraform, OpenTofu e Terragrunt. Gratuito para até 2 usuários, incluindo todos os recursos.
* [Terrateam](https://terrateam.io) - Automação Terraform orientada por GitOps, com fluxos de trabalho baseados em pull request, isolamento de projetos via runners auto-hospedados e execuções em camadas para operações ordenadas. Grátis para até 3 usuários.

**[⬆️ Voltar ao Topo](#table-of-contents)**

## Testes

* [Applitools.com](https://applitools.com/) — Validação visual inteligente para aplicativos web, mobile nativos e desktop. Integra com quase todas as soluções de automação (como Selenium e Karma) e runners remotos (Sauce Labs, Browser Stack). Gratuito para projetos open source. Um plano gratuito para usuário único com checkpoints limitados por semana.
* [Appetize](https://appetize.io) — Teste seus apps Android & iOS neste emulador Cloud Based para Android Phones/Tablets e simuladores de iPhone/iPad diretamente no navegador. O plano gratuito inclui duas sessões simultâneas com 30 minutos de uso por mês. Sem limite de tamanho do app.
* [Apptim](https://apptim.com) — Ferramenta de teste mobile que permite a pessoas sem habilidades em engenharia de performance avaliar a performance e experiência do usuário (UX) de um app. A versão desktop, usando seu próprio dispositivo, é 100% GRATUITA, com testes ilimitados em iOS e Android.
* [Argos](https://argos-ci.com) - Testes visuais Open Source para desenvolvedores. Projetos ilimitados, com 5.000 screenshots por mês. Grátis para projetos open-source.
* [Bencher](https://bencher.dev/) - Suite de ferramentas de benchmarking contínuo para detectar regressões de performance em CI. Gratuito para todos os projetos públicos.
* [browserstack.com](https://www.browserstack.com/) — Teste manual e automatizado em navegadores, [gratuito para Open Source](https://www.browserstack.com/open-source?ref=pricing)
* [BugBug](https://bugbug.io/) - Ferramenta leve de automação de testes para aplicações web. Fácil de aprender e não requer programação. Execute testes ilimitados em seu próprio computador gratuitamente. Monitoramento em nuvem e integração CI/CD disponíveis por uma taxa mensal adicional.
* [Checkly](https://checklyhq.com) - Monitoramento sintético code-first para DevOps modernos. Monitore suas APIs e apps a uma fração do preço de provedores legados. Baseado em workflow Monitoring as Code e Playwright. Generoso plano gratuito para desenvolvedores.
* [checkbot.io](https://www.checkbot.io/) — Extensão de navegador que testa se seu site segue mais de 50 boas práticas de SEO, velocidade e segurança. Plano gratuito para sites menores.
* [CORS-Tester](https://cors-error.dev/cors-tester/) - Ferramenta gratuita para desenvolvedores e testadores de APIs verificarem se uma API está habilitada para CORS para um domínio e identificar lacunas. Oferece insights acionáveis.
* [cypress.io](https://www.cypress.io/) - Testes rápidos, fáceis e confiáveis para qualquer coisa que rode em um navegador. O Cypress Test Runner é sempre gratuito e open-source sem restrições. O Cypress Dashboard é gratuito para projetos open-source para até 5 usuários.
* [Cypress Recorder by Preflight](https://cypress.preflight.com/) - Crie testes Cypress/POM models com IA no navegador. Open-source, exceto pela parte de IA. Grátis para cinco criações de teste mensais com scripts autossustentáveis, Email e testes visuais.
* [everystep-automation.com](https://www.everystep-automation.com/) — Grava e reproduz todos os passos feitos em um navegador e gera scripts, gratuito com menos opções.
* [Gremlin](https://www.gremlin.com/gremlin-free-software) — Ferramentas de Chaos Engineering da Gremlin permitem injetar falhas em seus sistemas de forma segura para encontrar fragilidades antes que causem problemas ao cliente. Gremlin Free permite acesso a ataques de Shutdown e CPU em até 5 hosts ou containers.
* [gridlastic.com](https://www.gridlastic.com/) — Testes Selenium Grid com plano gratuito de até 4 nós simultâneos/10 grids iniciados/4.000 minutos de teste por mês.
* [katalon.com](https://katalon.com) - Plataforma de testes para times de todos os tamanhos e níveis de maturidade, incluindo Katalon Studio, TestOps (+ Visual Testing gratuito), TestCloud e Katalon Recorder.
* [Keploy](https://keploy.io/) - Kit de ferramentas de teste funcional para desenvolvedores. Grava chamadas de API e gera testes E2E para APIs (KTests) e mocks ou stubs (KMocks). Gratuito para projetos Open Source.
* [knapsackpro.com](https://knapsackpro.com) - Acelere seus testes com paralelização ótima do conjunto de testes em qualquer provedor de CI. Divide testes Ruby, JavaScript em nós paralelos do CI para economizar tempo. Plano gratuito para até 10 minutos de arquivos de teste e plano ilimitado grátis para projetos Open Source.
* [lambdatest.com](https://www.lambdatest.com/) — Testes manuais, visuais, de screenshot e automatizados em navegadores via selenium e cypress, [gratuito para Open Source](https://www.lambdatest.com/open-source-cross-browser-testing-tool)
* [loadmill.com](https://www.loadmill.com/) - Crie testes de API e carga automaticamente analisando o tráfego de rede. Simule até 50 usuários simultâneos por até 60 minutos grátis por mês.
* [lost-pixel.com](https://lost-pixel.com) - Testes holísticos de regressão visual para suas histórias Storybook, Ladle, Histoire e Web Apps. Membros ilimitados na equipe, totalmente gratuito para open-source, 7.000 snapshots/mês.
* [octomind.dev](https://www.octomind.dev/) - Testes Playwright UI gerados, executados e mantidos automaticamente com geração de casos de teste assistida por IA.
* [percy.io](https://percy.io) - Adicione testes visuais a qualquer web app, site estático, style guide ou biblioteca de componentes. Membros ilimitados, app demo e projetos ilimitados, 5.000 snapshots/mês.
* [preflight.com](https://preflight.com) - Testes web automatizados sem código. Grave testes no navegador resilientes a mudanças de UI e execute-os em máquinas Windows. Pode integrar com CI/CD? O plano gratuito inclui 50 execuções de teste mensais com vídeo, sessões HTML e mais.
* [qase.io](https://qase.io) - Sistema de gerenciamento de testes para times de Dev e QA. Gerencie casos de teste, componha execuções, realize testes, acompanhe defeitos e meça impacto. O plano gratuito inclui todos os recursos principais, com 500MB para anexos e até 3 usuários.
* [Repeato](https://repeato.app/) Ferramenta de automação de testes mobile sem código, baseada em visão computacional e IA. Funciona para apps nativos, flutter, react-native, web, ionic e outros frameworks. O plano gratuito é limitado a 10 testes para iOS e 10 para Android, mas inclui a maioria dos recursos dos planos pagos, incluindo execuções ilimitadas.
* [Requestly](https://requestly.com/) Extensão Chrome open-source para Interceptar, Redirecionar e Simular Requisições HTTP. Inclui [Debugger](https://requestly.com/products/web-debugger/), [Mock Server](https://requestly.com/products/mock-server/), [API Client](https://requestly.com/products/api-client/) e [Session Recording](https://requestly.com/products/session-book/). Redirecione URLs, modifique cabeçalhos HTTP, simule APIs, injete JS personalizado, modifique requisições GraphQL, gere endpoints de API fictícios, grave sessões com logs de rede e console. Crie até 10 regras no plano gratuito. Grátis para open-source.
* [seotest.me](https://seotest.me/) — Ferramenta gratuita de teste SEO on-page. 10 crawls de sites grátis por dia. Recursos úteis de aprendizado em SEO e recomendações para melhorar os resultados de SEO on-page para qualquer site, independente da tecnologia.
* [snippets.uilicious.com](https://snippets.uilicious.com) - Semelhante ao CodePen, mas para testes cross-browser. O UI-licious permite escrever testes como histórias de usuário e oferece a plataforma gratuita - UI-licious Snippets - que permite rodar testes ilimitados no Chrome sem cadastro, até 3 minutos por execução. Achou um bug? Você pode copiar a URL única do seu teste para mostrar aos devs exatamente como reproduzir.
* [TestCollab](https://testcollab.com) - Software de gerenciamento de testes fácil de usar, o plano gratuito inclui integração com Jira, projetos ilimitados, importação de casos de teste via CSV/XLSx, controle de tempo e 1 GB de armazenamento de arquivos.
* [testingbot.com](https://testingbot.com/) — Testes Selenium em Navegadores e Dispositivos, [gratuito para Open Source](https://testingbot.com/open-source)
* [Testspace.com](https://testspace.com/) - Dashboard para publicação de resultados de testes automatizados e framework para implementação de testes manuais como código via GitHub. O serviço é [gratuito para Open Source](https://github.com/marketplace/testspace-com) e suporta 450 resultados mensais.
* [tesults.com](https://www.tesults.com) — Relatórios de resultados de teste e gerenciamento de casos de teste. Integra com frameworks populares de teste. Desenvolvedores de software open source, indivíduos, educadores e pequenos times iniciantes podem solicitar ofertas gratuitas ou com desconto além dos projetos gratuitos básicos.
* [UseWebhook.com](https://usewebhook.com) - Capture e inspecione webhooks no navegador. Encaminhe para localhost ou repita execuções do histórico. Uso gratuito.
* [Vaadin](https://vaadin.com) — Construa UIs escaláveis em Java ou TypeScript, usando ferramentas integradas, componentes e design system para iterar mais rápido, projetar melhor e simplificar o desenvolvimento. Projetos ilimitados com cinco anos de manutenção gratuita.
* [websitepulse.com](https://www.websitepulse.com/tools/) — Diversas ferramentas gratuitas de rede e servidor.
* [webhook-test.com](https://webhook-test.com) - Depure e inspecione webhooks e requisições HTTP com uma URL única durante a integração. Totalmente gratuito, você pode criar URLs ilimitadas e receber recomendações.
* [webhook.site](https://webhook.site) - Verifique webhooks, requisições HTTP de saída ou e-mails com uma URL personalizada. Sempre gratuito com URL e e-mail temporários.
* [webhookbeam.com](https://webhookbeam.com) - Configure webhooks e monitore-os via notificações push e e-mails.

**[⬆️ Voltar ao Topo](#table-of-contents)**

## Segurança e PKI

* [aikido.dev](https://www.aikido.dev) — Plataforma appsec tudo-em-um cobrindo SCA, SAST, CSPM, DAST, Secrets, IaC, Malware, Container scanning, EOL,... O plano gratuito inclui dois usuários, análise de 10 repositórios, 1 cloud, 2 containers e 1 domínio.
* [alienvault.com](https://www.alienvault.com/open-threat-exchange/reputation-monitor) — Descobre sistemas comprometidos em sua rede
* [Altcha.org](https://altcha.org/anti-spam) - Filtro de spam para sites e APIs baseado em processamento de linguagem natural e machine learning. O plano gratuito inclui 200 requisições por dia por domínio.
* [atomist.com](https://atomist.com/) — Forma mais rápida e conveniente de automatizar várias tarefas de desenvolvimento. Atualmente em beta.
* [cloudsploit.com](https://cloudsploit.com/) — Auditoria e monitoramento de segurança e conformidade para Amazon Web Services (AWS)
* [Public Cloud Threat Intelligence](https://cloudintel.himanshuanand.com/) — Indicadores de comprometimento (IOC) de alta confiança focados em infraestrutura de nuvem pública, parte disponível no github (https://github.com/unknownhad/AWSAttacks). Lista completa disponível via API
* [CodeNotary.io](https://www.codenotary.io/) — Plataforma Open Source com prova indelével para notarizar código, arquivos, diretórios ou containers
* [crypteron.com](https://www.crypteron.com/) — Plataforma de segurança Cloud-first e amigável ao desenvolvedor que previne vazamento de dados em aplicações .NET e Java
* [CyberChef](https://gchq.github.io/CyberChef/) — Web app simples e intuitivo para analisar e codificar/decodificar dados sem ferramentas complexas ou linguagens de programação. Um canivete suíço da criptografia & encriptação. Todos os recursos são gratuitos e sem limites. Open source para auto-hospedagem.
* [DAS](https://signup.styra.com/) — Styra DAS Free, gestão de ciclo de vida completo de políticas para criar, implantar e gerenciar autorização Open Policy Agent (OPA)
* [Datree](https://www.datree.io/) — CLI Open Source para evitar más configurações no Kubernetes, garantindo que manifests e charts Helm sigam as melhores práticas e políticas da organização
* [Dependabot](https://dependabot.com/) Atualização automatizada de dependências para Ruby, JavaScript, Python, PHP, Elixir, Rust, Java (Maven e Gradle), .NET, Go, Elm, Docker, Terraform, Git Submodules e GitHub Actions.
* [DJ Checkup](https://djcheckup.com) — Escaneia seu site Django para falhas de segurança com esta ferramenta gratuita e automatizada. Forkado do site Pony Checkup.
* [Doppler](https://doppler.com/) — Gerenciador universal de segredos de aplicativos e configs, com suporte para sincronização com vários provedores de nuvem. Gratuito para cinco usuários com controles de acesso básicos.
* [Dotenv](https://dotenv.org/) — Sincronize seus arquivos .env de forma rápida & segura. Pare de compartilhar arquivos .env por canais inseguros como Slack e e-mail, e nunca mais perca um arquivo importante. Gratuito para até 3 integrantes.
* [GitGuardian](https://www.gitguardian.com) — Mantenha segredos fora do código fonte com detecção e remediação automatizada. Escaneie seus repositórios git para mais de 350 tipos de segredos e arquivos sensíveis – Gratuito para indivíduos e times de até 25 desenvolvedores.
* [Have I been pwned?](https://haveibeenpwned.com) — API REST para consultar informações sobre vazamentos.
* [hostedscan.com](https://hostedscan.com) — Scanner online de vulnerabilidades para aplicações web, servidores e redes. Dez scans gratuitos por mês.
* [Infisical](https://infisical.com/) — Plataforma open source que permite gerenciar segredos de desenvolvedores em todo o time e infraestrutura: do desenvolvimento local à produção/serviços de terceiros. Grátis para até 5 desenvolvedores.
* [Internet.nl](https://internet.nl) — Teste para padrões modernos de Internet como IPv6, DNSSEC, HTTPS, DMARC, STARTTLS e DANE
* [keychest.net](https://keychest.net) - Gerenciamento de expiração de SSL e compra de certificados com banco de dados CT integrado
* [letsencrypt.org](https://letsencrypt.org/) — Autoridade Certificadora SSL gratuita com certificados confiáveis por todos os principais navegadores
* [meterian.io](https://www.meterian.io/) - Monitore projetos Java, Javascript, .NET, Scala, Ruby e NodeJS para vulnerabilidades de segurança em dependências. Gratuito para um projeto privado, projetos ilimitados para open source.
* [Mozilla Observatory](https://observatory.mozilla.org/) — Encontre e corrija vulnerabilidades de segurança no seu site.
* [opswat.com](https://www.opswat.com/) — Monitoramento de segurança de computadores, dispositivos, aplicações, configurações. Grátis para 25 usuários e histórico de 30 dias.
* [openapi.security](https://openapi.security/) - Ferramenta gratuita para verificar rapidamente a segurança de qualquer API baseada em OpenAPI / Swagger. Não é necessário cadastro.
* [pixee.ai](https://pixee.ai) - Engenheiro de Segurança de Produto automatizado como bot gratuito do GitHub que envia PRs para seu código Java resolvendo vulnerabilidades automaticamente. Outras linguagens em breve!
* [pyup.io](https://pyup.io) — Monitore dependências Python para vulnerabilidades de segurança e as atualize automaticamente. Grátis para um projeto privado, projetos ilimitados para open source.
* [qualys.com](https://www.qualys.com/community-edition) — Encontre vulnerabilidades em web apps, auditando riscos OWASP
* [report-uri.io](https://report-uri.io/) — Relatórios de violações CSP e HPKP
* [ringcaptcha.com](https://ringcaptcha.com/) — Ferramentas para usar o número de telefone como ID, disponível gratuitamente
* [seclookup.com](https://www.seclookup.com/) - APIs Seclookup podem enriquecer indicadores de ameaça de domínio em SIEM, fornecer informações abrangentes sobre domínios e melhorar a detecção & resposta a ameaças. 50 mil consultas grátis [aqui](https://account.seclookup.com/).
* [snyk.io](https://snyk.io) — Encontre e corrija vulnerabilidades conhecidas em dependências open-source. Testes e correções ilimitadas para projetos open-source. Limitado a 200 testes/mês em projetos privados.
* [ssllabs.com](https://www.ssllabs.com/ssltest/) — Análise intensa da configuração de qualquer servidor web SSL
* [SOOS](https://soos.io) - Scans SCA gratuitos e ilimitados para projetos open-source. Detecte e corrija ameaças de segurança antes do release. Proteja seus projetos com uma solução simples e eficaz.
* [StackHawk](https://www.stackhawk.com/) Automatize o escaneamento de aplicações durante o pipeline para encontrar e corrigir bugs de segurança antes de irem para produção. Scans e ambientes ilimitados para um único app.
* [Sucuri SiteCheck](https://sitecheck.sucuri.net) - Verificação gratuita de segurança de sites e scanner de malware
* [Protectumus](https://protectumus.com) - Verificação gratuita de segurança de sites, antivírus para sites e firewall de servidor (WAF) para PHP. Notificações por email para usuários registrados no plano gratuito.
* [TestTLS.com](https://testtls.com) - Teste um serviço SSL/TLS para configuração segura de servidor, certificados, cadeias, etc. Não limitado a HTTPS.
* [threatconnect.com](https://threatconnect.com) — Inteligência de ameaças: projetado para pesquisadores individuais, analistas e organizações que estão começando em threat intelligence cibernética. Grátis para até 3 usuários
* [tinfoilsecurity.com](https://www.tinfoilsecurity.com/) — Scan automatizado de vulnerabilidades. O plano gratuito permite scans semanais de XSS
* [Ubiq Security](https://ubiqsecurity.com/) — Encripte e decripte dados com três linhas de código e gerenciamento automático de chaves. Grátis para um app e até 1.000.000 de encriptações por mês.
* [Virgil Security](https://virgilsecurity.com/) — Ferramentas e serviços para implementar criptografia ponta-a-ponta, proteção de banco de dados, segurança para IoT e mais em sua solução digital. Grátis para apps com até 250 usuários.
* [Vulert](https://vulert.com) - O Vulert monitora continuamente suas dependências open-source para novas vulnerabilidades, recomenda correções, sem necessidade de instalação ou acesso ao seu código. Gratuito para projetos open-source.
* [Escape GraphQL Quickscan](https://escape.tech/) - Scan de segurança de endpoints GraphQL em um clique. Grátis, sem necessidade de login.
* [HasMySecretLeaked](https://gitguardian.com/hasmysecretleaked) - Procure entre 20 milhões de segredos expostos em repositórios públicos do GitHub, gists, issues e comentários gratuitamente
* [Project Gatekeeper](https://gatekeeper.binarybiology.top/) - Kit de ferramentas SSL tudo-em-um com recursos como Gerador de Chave Privada & CSR, Decodificador de Certificados SSL, Correspondência de Certificados e Pedido de Certificados SSL. Oferecemos geração gratuita de certificados SSL do Let's Encrypt, Google Trust e BuyPass usando registros CNAME em vez de TXT.
**[⬆️ Voltar ao Topo](#table-of-contents)**

## Autenticação, Autorização e Gerenciamento de Usuários

  * [Aserto](https://www.aserto.com) - Autorização granular como serviço para aplicações e APIs. Gratuito até 1000 MAUs e 100 instâncias de autorizador.
  * [asgardeo.io](https://wso2.com/asgardeo) - Integração perfeita de SSO, MFA, autenticação sem senha e mais. Inclui SDKs para aplicações frontend e backend. Gratuito até 1000 MAUs e cinco provedores de identidade.
  * [Auth0](https://auth0.com/) — SSO hospedado. O plano gratuito inclui 25.000 MAUs, conexões sociais ilimitadas, domínio personalizado e mais.
  * [Authgear](https://www.authgear.com) - Traga autenticação sem senha, OTPs, 2FA, SSO para seus apps em minutos. Todo Front-end incluído. Gratuito até 5000 MAUs.
  * [Authress](https://authress.io/) — Login de autenticação e controle de acesso, provedores de identidade ilimitados para qualquer projeto. Facebook, Google, Twitter e mais. As primeiras 1000 chamadas de API são gratuitas.
  * [Authy](https://authy.com) - Autenticação de dois fatores (2FA) em múltiplos dispositivos, com backups. Substituição direta do Google Authenticator. Gratuito para até 100 autenticações bem-sucedidas.
  * [Cerbos Hub](https://www.cerbos.dev/product-cerbos-hub) - Um sistema completo de gerenciamento de autorização para criação, teste e implantação de políticas de acesso. Autorização granular e controle de acesso, gratuito até 100 principais ativos mensais.
  * [Clerk](https://clerk.com) — Gerenciamento de usuários, autenticação, 2FA/MFA, componentes de UI pré-construídos para login, cadastro, perfis de usuário e mais. Gratuito até 10.000 usuários ativos mensais.
  * [Cloud-IAM](https://www.cloud-iam.com/) — Keycloak Identity and Access Management como Serviço. Gratuito até 100 usuários e um realm.
  * [Corbado](https://www.corbado.com/) — Adicione autenticação passkey-first a apps novos ou existentes. Gratuito para MAUs ilimitados.
  * [Descope](https://www.descope.com/) — Fluxos de AuthN altamente customizáveis, possui abordagem no-code e API/SDK, Gratuito para 7.500 usuários ativos/mês, 50 locatários (até 5 locatários SAML/SSO).
  * [duo.com](https://duo.com/) — Autenticação de dois fatores (2FA) para site ou app. Gratuito para dez usuários, todos os métodos de autenticação, integrações ilimitadas, tokens de hardware.
  * [Kinde](https://kinde.com/) - Autenticação simples e robusta que pode ser integrada ao seu produto em minutos. Tudo que você precisa para começar com 7.500 MAU gratuitos.
  * [logintc.com](https://www.logintc.com/) — Autenticação de dois fatores (2FA) por push notifications, gratuito para dez usuários, VPN, sites e SSH.
  * [MojoAuth](https://mojoauth.com/) - MojoAuth facilita a implementação de autenticação sem senha em sua aplicação web, mobile ou qualquer outra em minutos.
  * [Okta](https://developer.okta.com/signup/) — Gerenciamento de usuários, autenticação e autorização. Gratuito até 100 usuários ativos mensais.
  * [onelogin.com](https://www.onelogin.com/) — Identidade como Serviço (IDaaS), Provedor de Identidade SSO, Cloud SSO IdP, três apps empresariais e cinco apps pessoais, usuários ilimitados
  * [Ory](https://ory.sh/) - AuthN/AuthZ/OAuth2.0/Plataforma de segurança Zero Trust gerenciada. Contas de desenvolvedor gratuitas para sempre com todos os recursos de segurança, membros de equipe ilimitados, 200 usuários ativos diários e 25k verificações de permissão/mês.
  * [Permit.io](https://permit.io) - Plataforma de autorização como serviço permitindo RBAC, ABAC e ReBAC para microsserviços escaláveis com atualizações em tempo real e interface de política no-code. Camada gratuita para 1000 usuários ativos mensais.
  * [Phase Two](https://phasetwo.io) - Keycloak Open Source Identity and Access Management. Realm gratuito até 1000 usuários, até 10 conexões SSO, usando o container Keycloak aprimorado do Phase Two que inclui a extensão [Organization](https://phasetwo.io/product/organizations/).
  * [SSOJet](https://ssojet.com/) - Adicione SSO Empresarial sem refazer seu Auth. O plano gratuito inclui usuários ativos mensais ilimitados, organizações ilimitadas, 2 conexões SSO e 2 SCIM.
  * [Stytch](https://www.stytch.com/) - Plataforma completa que fornece APIs e SDKs para autenticação e prevenção de fraudes. O plano gratuito inclui 10.000 usuários ativos mensais, organizações ilimitadas, 5 conexões SSO ou SCIM, e 1.000 tokens M2M.
  * [Stack Auth](https://stack-auth.com) — Autenticação open-source que realmente funciona. A solução mais amigável ao desenvolvedor, pronta em apenas cinco minutos. Hospedável gratuitamente ou versão SaaS gerenciada com 10k MAUs gratuitos.
  * [SuperTokens](https://supertokens.com/) - Autenticação de usuário open source que se integra nativamente ao seu app - permitindo que você comece rapidamente controlando a experiência do usuário e do desenvolvedor. Gratuito até 5000 MAUs.
  * [Warrant](https://warrant.dev/) — Serviço de autorização e controle de acesso empresarial hospedado para seus apps. O plano gratuito inclui 1 milhão de requisições de API mensais e 1.000 regras authz.
  * [ZITADEL Cloud](https://zitadel.com) — Gerenciamento turnkey de usuários e acessos que funciona para você e suporta cenários multi-tenant (B2B). Gratuito até 25.000 requisições autenticadas, com todos os recursos de segurança (sem paywall para OTP, Passwordless, Políticas etc).
  * [PropelAuth](https://propelauth.com) — Venda para empresas de qualquer tamanho imediatamente com poucas linhas de código, gratuito até 200 usuários e 10k e-mails transacionais (com marca d'água: "Powered by PropelAuth").
  * [Logto](https://logto.io/) - Desenvolva, proteja e gerencie identidades de usuário do seu produto - tanto para autenticação quanto autorização. Gratuito até 5.000 MAUs com opção open source auto-hospedada disponível.
  * [WorkOS](https://workos.com/) - Gerenciamento de usuários e autenticação gratuitos para até 1 milhão de MAUs. Suporte a email + senha, autenticação social, Magic Auth, MFA e mais.

**[⬆️ Voltar ao Topo](#table-of-contents)**

## Distribuição e Feedback de Aplicativos Mobile

  * [TestApp.io](https://testapp.io) - Sua plataforma para garantir que seus aplicativos mobile funcionem como deveriam. Plano gratuito: um app, analytics, versões e instalações ilimitadas, e coleta de feedback.
  * [Loadly](https://loadly.io) - Serviço de distribuição de apps beta iOS & Android completamente gratuito, com downloads ilimitados, downloads em alta velocidade e uploads ilimitados.
  * [Diawi](https://www.diawi.com) - Implante apps iOS & Android diretamente nos dispositivos. Plano gratuito: upload de apps, links protegidos por senha, expiração de 1 dia, dez instalações.
  * [InstallOnAir](https://www.installonair.com) - Distribua apps iOS & Android over the air. Plano gratuito: uploads ilimitados, links privados, expiração de 2 dias para convidados, 60 dias para usuários registrados.
  * [GetUpdraft](https://www.getupdraft.com) - Distribua apps mobile para testes. O plano gratuito inclui um projeto de app, três versões de app, 500 MB de armazenamento e 100 instalações de apps por mês.
  * [Appho.st](https://appho.st) - Plataforma de hospedagem de aplicativos mobile. O plano gratuito inclui cinco apps, 50 downloads mensais e tamanho máximo de arquivo de 100 MB.

**[⬆️ Voltar ao Topo](#table-of-contents)**

## Sistema de Gerenciamento

  * [bitnami.com](https://bitnami.com/) — Implante apps preparados em IaaS. Gerenciamento de 1 instância micro AWS gratuito
  * [Esper](https://esper.io) — MDM e MAM para dispositivos Android com DevOps. Cem dispositivos gratuitos com uma licença de usuário e 25 MB de armazenamento de aplicativos.
  * [jamf.com](https://www.jamf.com/) — Gerenciamento de dispositivos para iPads, iPhones e Macs, três dispositivos gratuitos
  * [Miradore](https://miradore.com) — Serviço de gerenciamento de dispositivos. Mantenha-se atualizado com seu parque de dispositivos e proteja dispositivos ilimitados gratuitamente. O plano gratuito oferece recursos básicos.
  * [moss.sh](https://moss.sh) - Ajuda desenvolvedores a implantar e gerenciar seus aplicativos web e servidores. Gratuito até 25 deploys git por mês
  * [runcloud.io](https://runcloud.io/) - Gerenciamento de servidores com foco principalmente em projetos PHP. Gratuito até 1 servidor.
  * [ploi.io](https://ploi.io/) - Ferramenta de gerenciamento de servidores para gerenciar e implantar servidores & sites facilmente. Gratuito para um servidor.
  * [xcloud.host](https://xcloud.host) — Plataforma de gerenciamento e implantação de servidores com interface amigável. Camada gratuita disponível para um servidor.
  * [serveravatar.com](https://serveravatar.com) — Gerencie e monitore servidores web baseados em PHP com configurações automatizadas. Gratuito para um servidor.

**[⬆️ Voltar ao Topo](#table-of-contents)**

## Mensageria e Streaming

  * [Ably](https://www.ably.com/) - Serviço de mensageria em tempo real com presença, persistência e entrega garantida. O plano gratuito inclui 3 milhões de mensagens por mês, 100 conexões simultâneas e 100 canais simultâneos.
  * [cloudamqp.com](https://www.cloudamqp.com/) — RabbitMQ como Serviço. Plano Little Lemur: máximo de 1 milhão de mensagens/mês, máximo de 20 conexões simultâneas, máximo de 100 filas, máximo de 10.000 mensagens em fila, múltiplos nós em diferentes AZs
  * [courier.com](https://www.courier.com/) — API única para push, in-app, email, chat, SMS e outros canais de mensagem com gerenciamento de templates e outros recursos. O plano gratuito inclui 10.000 mensagens/mês.
  * [engagespot.co](https://engagespot.co/) — Infraestrutura multicanal de notificações para desenvolvedores com inbox in-app pré-construído e editor de templates sem código. Plano gratuito inclui 10.000 mensagens/mês.
  * [HiveMQ](https://www.hivemq.com/mqtt-cloud-broker/) - Conecte seus dispositivos MQTT ao Cloud Native IoT Messaging Broker. Gratuito para conectar até 100 dispositivos (sem necessidade de cartão de crédito) para sempre.
  * [knock.app](https://knock.app) – Infraestrutura de notificações para desenvolvedores. Envie para múltiplos canais como in-app, email, SMS, Slack e push com uma única chamada de API. O plano gratuito inclui 10.000 mensagens/mês.
  * [NotificationAPI.com](https://www.notificationapi.com/) — Adicione notificações de usuário a qualquer software em 5 minutos. O plano gratuito inclui 10.000 notificações/mês + 100 SMS e chamadas automáticas.
  * [Novu.co](https://novu.co) — Infraestrutura open-source de notificações para desenvolvedores. Componentes simples e APIs para gerenciar todos os canais de comunicação em um só lugar: Email, SMS, Direto, In-App e Push. O plano gratuito inclui 30.000 notificações/mês com 90 dias de retenção.
  * [pusher.com](https://pusher.com/) — Serviço de mensagens em tempo real. Gratuito até 100 conexões simultâneas e 200.000 mensagens/dia
  * [scaledrone.com](https://www.scaledrone.com/) — Serviço de mensagens em tempo real. Gratuito até 20 conexões simultâneas e 100.000 eventos/dia
  * [synadia.com](https://synadia.com/ngs) — [NATS.io](https://nats.io) como serviço. Global, AWS, GCP e Azure. Gratuito para sempre com 4k tamanho de mensagem, 50 conexões ativas e 5GB de dados por mês.
  * [pubnub.com](https://www.pubnub.com/) - Mensageria em Swift, Kotlin e React com 1 milhão de transações por mês. Cada transação pode conter múltiplas mensagens.
  * [eyeson API](https://developers.eyeson.team/) - API de comunicação em vídeo baseada em WebRTC (SFU, MCU) para construir plataformas de vídeo. Permite injeção de dados em tempo real, layouts de vídeo, gravações, uma UI web hospedada completa (quickstart) ou pacotes para UIs customizadas. Possui [camada gratuita para desenvolvedores](https://apiservice.eyeson.com/api-pricing) com 1000 minutos de reunião por mês.
  * [webpushr](https://www.webpushr.com/) - Notificações Web Push - Gratuito até 10k assinantes, notificações push ilimitadas, mensagens no navegador
  * [httpSMS](https://httpsms.com) - Envie e receba mensagens de texto usando seu Android como Gateway SMS. Gratuito para enviar e receber até 200 mensagens por mês.
  * [EMQX Serverless](https://www.emqx.com/en/cloud/serverless-mqtt) - Broker MQTT serverless escalável e seguro pronto em segundos. 1M minutos de sessão/mês gratuitos para sempre (sem necessidade de cartão de crédito).
  * [Pocket Alert](https://pocketalert.app) - Envie notificações push para seus dispositivos iOS e Android. Integração fácil via API ou Webhooks e controle total dos seus alertas. Plano gratuito: 50 mensagens por dia para 1 dispositivo e 1 aplicação.
  * [SuprSend](https://www.suprsend.com/) - SuprSend é uma infraestrutura de notificações que simplifica as notificações do seu produto com abordagem API-first. Crie e entregue notificações transacionais, crons e de engajamento em múltiplos canais com uma única API. No plano gratuito você recebe 10.000 notificações por mês, incluindo diferentes nós de fluxo de trabalho como digests, batches, multicanais, preferências, locatários, broadcasts e mais.

**[⬆️ Voltar ao Topo](#table-of-contents)**

## Gerenciamento de Logs

  * [bugfender.com](https://bugfender.com/) — Gratuito até 100k linhas de log/dia com retenção de 24 horas
  * [logentries.com](https://logentries.com/) — Gratuito até 5 GB/mês com sete dias de retenção
  * [loggly.com](https://www.loggly.com/) — Gratuito para um único usuário, 200MB/dia com sete dias de retenção
  * [logz.io](https://logz.io/) — Gratuito até 1 GB/dia, um dia de retenção
  * [ManageEngine Log360 Cloud](https://www.manageengine.com/cloud-siem/) — Serviço de gerenciamento de logs alimentado pela Manage Engine. Plano gratuito oferece 50 GB de armazenamento com 15 dias de retenção e 7 dias de busca.
  * [papertrailapp.com](https://papertrailapp.com/) — 48 horas de busca, sete dias de arquivo, 50 MB/mês
  * [sematext.com](https://sematext.com/logsene) — Gratuito até 500 MB/dia, sete dias de retenção
  * [sumologic.com](https://www.sumologic.com/) — Gratuito até 500 MB/dia, sete dias de retenção
  * [logflare.app](https://logflare.app/) — Gratuito até 12.960.000 entradas por app por mês, 3 dias de retenção
  * [logtail.com](https://logtail.com/) — Gerenciamento de logs compatível com SQL baseado em ClickHouse. Gratuito até 1 GB por mês, três dias de retenção.
  * [logzab.com](https://logzab.com/) — Sistema de gerenciamento de trilhas de auditoria. Gratuito para 1.000 logs de atividades de usuário por mês, 1 mês de retenção, para até 5 projetos.
  * [openobserve.ai](https://openobserve.ai/) - 200 GB de ingestão/mês grátis, 15 dias de retenção
**[⬆️ Voltar ao Topo](#table-of-contents)**

## Gerenciamento de Tradução

  * [crowdin.com](https://crowdin.com/) — Projetos ilimitados, strings ilimitadas e colaboradores para Open Source
  * [gitlocalize.com](https://gitlocalize.com) - Gratuito e ilimitado para repositórios privados e públicos
  * [Lecto](https://lecto.ai/) - API de Tradução Automática com plano gratuito (30 requisições grátis, 1000 caracteres traduzidos por requisição). Integrado ao plugin Loco Translate para Wordpress.
  * [lingohub.com](https://lingohub.com/) — Gratuito para até 3 usuários, sempre gratuito para Open Source
  * [localazy.com](https://localazy.com) - Gratuito para 1000 strings no idioma fonte, idiomas ilimitados, contribuidores ilimitados, ofertas para startups e open source
  * [Localeum](https://localeum.com) - Gratuito para até 1000 strings, um usuário, idiomas ilimitados, projetos ilimitados
  * [localizely.com](https://localizely.com/) — Gratuito para Open Source
  * [Loco](https://localise.biz/) — Gratuito para até 2000 traduções, tradutores ilimitados, dez idiomas/projeto, 1000 ativos traduzíveis/projeto
  * [oneskyapp.com](https://www.oneskyapp.com/) — Edição gratuita limitada para até 5 usuários, gratuito para Open Source
  * [POEditor](https://poeditor.com/) — Gratuito para até 1000 strings
  * [SimpleLocalize](https://simplelocalize.io/) - Gratuito para até 100 chaves de tradução, strings ilimitadas, idiomas ilimitados, ofertas para startups
  * [Texterify](https://texterify.com/) - Gratuito para um único usuário
  * [Tolgee](https://tolgee.io) - Oferta SaaS gratuita com traduções limitadas, versão self-hosted sempre gratuita
  * [transifex.com](https://www.transifex.com/) — Gratuito para Open Source
  * [Translation.io](https://translation.io) - Gratuito para Open Source
  * [Translized](https://translized.com) - Gratuito para até 1000 strings, um usuário, idiomas ilimitados, projetos ilimitados
  * [webtranslateit.com](https://webtranslateit.com/) — Gratuito para até 500 strings
  * [weblate.org](https://weblate.org/) — Gratuito para projetos livres com até 10.000 fontes de strings na camada gratuita e ilimitado para Self-hosted on-premises.
  * [Free PO editor](https://pofile.net/free-po-editor) — Gratuito para todos
  * [Lingo.dev](https://lingo.dev) – CLI open-source com IA para localização web & mobile. Use seu próprio LLM ou utilize 10.000 palavras gratuitas por mês pelo motor de localização gerenciado pelo Lingo.dev.

**[⬆️ Voltar ao Topo](#table-of-contents)**

## Monitoramento

  * [UptimeObserver.com](https://uptimeobserver.com) - Tenha 20 monitores de uptime com intervalos de 5 minutos e uma página de status personalizável — mesmo para uso comercial. Receba notificações ilimitadas e em tempo real por e-mail e Telegram. Não precisa de cartão de crédito para começar.
  * [Pingmeter.com](https://pingmeter.com/) - 5 monitores de uptime com intervalo de 10 minutos. Monitore SSH, HTTP, HTTPS e qualquer porta TCP personalizada.
  * [alerty.ai](https://www.alerty.ai) - APM e monitoramento gratuito para seu FE, BE, DB e mais + execuções de agentes gratuitas.
  * [appdynamics.com](https://www.appdynamics.com/) — Gratuito para métricas de 24 horas, agentes de gerenciamento de desempenho de aplicações limitado a um Java, um .NET, um PHP e um Node.js
  * [appneta.com](https://www.appneta.com/) — Gratuito com retenção de dados por 1 hora
  * [appspector.com](https://appspector.com/) - Controle de missão para depuração remota de iOS/Android/Flutter. Gratuito para uso de baixo tráfego (64MB de logs).
  * [assertible.com](https://assertible.com) — Testes e monitoramento automatizados de API. Planos gratuitos para equipes e indivíduos.
  * [bleemeo.com](https://bleemeo.com) - Gratuito para 3 servidores, 5 monitores de uptime, usuários ilimitados, dashboards ilimitados, regras de alerta ilimitadas.
  * [Core Web Vitals History](https://punits.dev/core-web-vitals-historical/) - Encontre o histórico dos Core Web Vitals para uma URL ou site.
  * [checklyhq.com](https://checklyhq.com) - Monitoramento E2E/Sintético open source e monitoramento profundo de API para desenvolvedores. Plano gratuito com um usuário e 10k execuções de checagem de API & rede / 1,5k execuções de checagem de navegador.
  * [cloudsploit.com](https://cloudsploit.com) — Monitoramento de segurança e configuração AWS. Gratuito: scans ilimitados sob demanda, usuários ilimitados, contas armazenadas ilimitadas. Assinatura: escaneamento automatizado, acesso via API, etc.
  * [cronitor.io](https://cronitor.io/) - Insights de desempenho e monitoramento de uptime para cron jobs, sites, APIs e mais. Um plano gratuito com cinco monitores.
  * [datadoghq.com](https://www.datadoghq.com/) — Gratuito para até 5 nós
  * [deadmanssnitch.com](https://deadmanssnitch.com/) — Monitoramento para cron jobs. Um monitor (snitch) grátis, mais se você indicar outros para se cadastrar
  * [downtimemonkey.com](https://downtimemonkey.com/) — 60 monitores de uptime, intervalo de 5 minutos. Alertas por e-mail e Slack.
  * [economize.cloud](https://economize.cloud) — O Economize ajuda a desmistificar os custos da infraestrutura cloud organizando recursos em nuvem para otimizar e reportar os mesmos. Gratuito para até US$ 5.000 gastos mensalmente no Google Cloud Platform.
  * [elastic.co](https://www.elastic.co/solutions/apm) — Insights de desempenho instantâneos para desenvolvedores JS. Gratuito com retenção de dados de 24 horas
  * [fivenines.io](https://fivenines.io/) — Monitoramento de servidor Linux com dashboards em tempo real e alertas — gratuito para sempre para até 5 servidores monitorados em intervalo de 60 segundos. Não precisa de cartão de crédito.
  * [Grafana Cloud](https://grafana.com/products/cloud/) - Grafana Cloud é uma plataforma de observabilidade composta que integra métricas e logs com o Grafana. Gratuito: 3 usuários, dez dashboards, 100 alertas, armazenamento de métricas em Prometheus e Graphite (10.000 séries, 14 dias de retenção), armazenamento de logs no Loki (50 GB de logs, 14 dias de retenção)
  * [healthchecks.io](https://healthchecks.io) — Monitore seus cron jobs e tarefas em background. Gratuito para até 20 verificações.
  * [Hydrozen.io](https://hydrozen.io) — Monitoramento de uptime & Status pages, Plano gratuito: 10 monitores de uptime, 5 monitores de heartbeat, 1 monitor de domínio e 1 statuspage grátis.
  * [incidenthub.cloud](https://incidenthub.cloud/) — Agregador de páginas de status Cloud e SaaS - 20 monitores e 2 canais de notificação (Slack e Discord) gratuitos para sempre.
  * [inspector.dev](https://www.inspector.dev) - Dashboard completo de monitoramento em tempo real em menos de um minuto com um plano gratuito para sempre.
  * [instrumentalapp.com](https://instrumentalapp.com) - Monitoramento bonito e fácil de usar para aplicações e servidores com até 500 métricas e 3 horas de visibilidade de dados gratuitamente
  * [keychest.net/speedtest](https://keychest.net/speedtest) - Teste de velocidade independente e teste de latência de handshake TLS contra Digital Ocean
  * [letsmonitor.org](https://letsmonitor.org) - Monitoramento SSL, gratuito para até 5 monitores
  * [linkok.com](https://linkok.com) - Verificador de links quebrados online, gratuito para sites pequenos até 100 páginas, completamente gratuito para projetos open-source.
  * [loader.io](https://loader.io/) — Ferramenta gratuita de teste de carga com limitações
  * [MonitorMonk](https://monitormonk.com) - Monitoramento de uptime minimalista com belas páginas de status. O plano Forever Free oferece monitoramento HTTPS, por palavra-chave, SSL e tempo de resposta para 10 sites ou endpoints de API, e fornece 2 dashboards/páginas de status.
  * [netdata.cloud](https://www.netdata.cloud/) — Netdata é uma ferramenta open-source para coletar métricas em tempo real. Produto em crescimento e também disponível no GitHub!
  * [newrelic.com](https://www.newrelic.com) — Plataforma de observabilidade New Relic desenvolvida para ajudar engenheiros a criar softwares mais perfeitos. De monólitos a serverless, você pode instrumentar tudo e depois analisar, solucionar problemas e otimizar todo seu stack de software. O plano gratuito oferece 100GB/mês de ingestão gratuita de dados, um usuário full-access gratuito e usuários primários gratuitos ilimitados.
  * [Middleware.io](https://middleware.io/) - Plataforma de observabilidade Middleware fornece visibilidade completa de seus apps & stack, para monitorar & diagnosticar problemas em escala. Plano gratuito para sempre para uso da comunidade Dev permite monitoramento de logs até 1M de eventos, monitoramento de infraestrutura & APM para até 2 hosts.
  * [nixstats.com](https://nixstats.com) - Gratuito para um servidor. Notificações por e-mail, página de status pública, intervalo de 60 segundos e mais.
  * [OnlineOrNot.com](https://onlineornot.com/) - OnlineOrNot oferece monitoramento de uptime para sites e APIs, monitoramento para cron jobs e tarefas agendadas. Também fornece páginas de status. As cinco primeiras verificações com intervalo de 3 minutos são gratuitas. O plano gratuito envia alertas via Slack, Discord e E-mail.
  * [OntarioNet.ca CN Test](https://cntest.ontarionet.ca) — Verifique se um site está bloqueado na China pelo Grande Firewall. Identifica poluição de DNS comparando resultados de DNS e informações ASN detectadas por servidores na China versus servidores nos Estados Unidos.
  * [opsgenie.com](https://www.opsgenie.com/) — Alertas avançados e gerenciamento de plantões para operação de serviços always-on. Gratuito para até 5 usuários.
  * [paessler.com](https://www.paessler.com/) — Solução poderosa de monitoramento de infraestrutura e rede, incluindo alertas, visualização avançada e relatórios básicos. Gratuito para até 100 sensores.
  * [pagecrawl.io](https://pagecrawl.io/) -  Monitore alterações em sites, gratuito para até 6 monitores com verificações diárias.
  * [syagent.com](https://syagent.com/) — Serviço gratuito de monitoramento de servidores para uso não comercial, alertas e métricas.
  * [pagerly.io](https://pagerly.io/) -  Gerencie plantões no Slack (integra com Pagerduty, OpsGenie). Gratuito para até 1 equipe (uma equipe corresponde a um plantão)
  * [pagertree.com](https://pagertree.com/) - Interface simples para alertas e gerenciamento de plantões. Gratuito para até 5 usuários.
  * [phare.io](https://phare.io/) - Monitoramento de Uptime gratuito para até 100.000 eventos para projetos ilimitados e páginas de status ilimitadas.
  * [pingbreak.com](https://pingbreak.com/) — Serviço moderno de monitoramento de uptime. Verifique URLs ilimitadas e receba notificações de downtime via Discord, Slack ou e-mail.
  * [pingpong.one](https://pingpong.one/) — Plataforma avançada de status page com monitoramento. O plano gratuito inclui uma página de status pública personalizável com subdomínio SSL. Plano Pro é oferecido gratuitamente para projetos open-source e organizações sem fins lucrativos.
  * [robusta.dev](https://home.robusta.dev/) — Monitoramento poderoso de Kubernetes baseado em Prometheus. Use seu próprio Prometheus ou instale o pacote all-in-one. O plano gratuito inclui até 20 nós Kubernetes. Alertas via Slack, Microsoft Teams, Discord e outros. Integrações com PagerDuty, OpsGenie, VictorOps, DataDog e muitas outras ferramentas.
  * [sematext.com](https://sematext.com/) — Gratuito para métricas de 24 horas, servidores ilimitados, dez métricas personalizadas, 500.000 pontos de dados de métricas personalizadas, dashboards e usuários ilimitados, etc.
  * [sitemonki.com](https://sitemonki.com/) — Monitoramento de site, domínio, Cron & SSL, 5 monitores em cada categoria gratuitamente
  * [sitesure.net](https://sitesure.net) - Monitoramento de sites e cron - 2 monitores gratuitos
  * [skylight.io](https://www.skylight.io/) — Gratuito para os primeiros 100.000 requisições (apenas Rails)
  * [speedchecker.xyz](https://probeapi.speedchecker.xyz/) — API de Monitoramento de Desempenho, verifica Ping, DNS, etc.
  * [stathat.com](https://www.stathat.com/) — Comece com dez estatísticas gratuitamente, sem expiração
  * [statuscake.com](https://www.statuscake.com/) — Monitoramento de sites, testes ilimitados gratuitos com limitações
  * [statusgator.com](https://statusgator.com/) — Monitoramento de páginas de status, 3 monitores gratuitos
  * [SweetUptime](https://dicloud.net/sweetuptime-server-uptime-monitoring/) — Monitoramento de servidor, uptime, DNS & domínio. Monitore 10 servidores, 10 uptimes e 10 domínios gratuitamente.
  * [thousandeyes.com](https://www.thousandeyes.com/) — Monitoramento de rede e experiência do usuário. 3 localizações e 20 feeds de dados dos principais serviços web gratuitos
  * [uptimetoolbox.com](https://uptimetoolbox.com/) — Monitoramento gratuito para cinco sites, intervalos de 60 segundos, statuspage pública.
  * [zenduty.com](https://www.zenduty.com/) — Plataforma de gerenciamento de incidentes de ponta a ponta, alertas, gerenciamento de plantões e orquestração de resposta para operações de rede, engenharia de confiabilidade de sites e equipes DevOps. Gratuito para até 5 usuários.
  * [instatus.com](https://instatus.com) - Tenha uma bela página de status em 10 segundos. Grátis para sempre com assinantes ilimitados e equipes ilimitadas.
  * [Squadcast.com](https://squadcast.com) - Squadcast é um software de gerenciamento de incidentes de ponta a ponta projetado para promover as melhores práticas de SRE. Plano gratuito para sempre para até 10 usuários.
  * [RoboMiri.com](https://robomiri.com/) - RoboMiri é um monitor de uptime estável que oferece uma ampla variedade de monitores: cronjob, palavra-chave, site, porta, ping. Vinte e cinco verificações de uptime com intervalo de 3 minutos gratuitamente. Alertas por chamada telefônica, SMS, E-mail e Webhooks.
  * [Better Stack](https://betterstack.com/better-uptime) - Monitoramento de uptime, gerenciamento de incidentes, agendamento/alerta de plantões e status pages em um único produto. O plano gratuito inclui dez monitores com frequência de checagem de 3 minutos e status pages.
  * [Pulsetic](https://pulsetic.com) - 10 monitores, 6 meses de histórico de Uptime/Logs, status pages ilimitadas e domínios personalizados inclusos! Por tempo indefinido e alertas por e-mail ilimitados gratuitamente. Não é necessário cartão de crédito.
  * [Wachete](https://www.wachete.com) - monitore cinco páginas, verificações a cada 24 horas.
  * [Xitoring.com](https://xitoring.com/) — Monitoramento de uptime: 20 gratuitos, Monitoramento de servidores Linux e Windows: 5 gratuitos, Página de status: 1 gratuita - Aplicativo móvel, múltiplos canais de notificação e muito mais!
  * [Servervana](https://servervana.com) - Monitoramento avançado de uptime com suporte para grandes projetos e equipes. Oferece monitoramento HTTP, monitoramento baseado em navegador, monitoramento DNS, monitoramento de domínio, páginas de status e mais. O plano gratuito inclui 10 monitores HTTP, 1 monitor DNS e uma página de status.

**[⬆️ Voltar ao Topo](#table-of-contents)**

## Tratamento de Crash e Exceções
* [CatchJS.com](https://catchjs.com/) - Rastreamento de erros JavaScript com capturas de tela e trilhas de cliques. Gratuito para projetos open-source.
* [bugsnag.com](https://www.bugsnag.com/) — Gratuito para até 2.000 erros/mês após o teste inicial
* [elmah.io](https://elmah.io/) — Registro de erros e monitoramento de uptime para desenvolvedores web. Assinatura Small Business gratuita para projetos open-source.
* [Embrace](https://embrace.io/) — Monitoramento de aplicativos móveis. Gratuito para pequenas equipes com até 1 milhão de sessões de usuários por ano.
* [exceptionless](https://exceptionless.com) — Relatórios em tempo real de erros, funcionalidades, logs e mais. Gratuito para 3k eventos por mês/1 usuário. Open source e fácil de hospedar para uso ilimitado.
* [GlitchTip](https://glitchtip.com/) — Rastreamento de erros simples e open-source. Compatível com SDKs open-source do Sentry. 1000 eventos por mês gratuitos, ou pode ser auto-hospedado sem limites
* [honeybadger.io](https://www.honeybadger.io) - Monitoramento de exceções, uptime e cron. Gratuito para pequenas equipes e projetos open-source (12.000 erros/mês).
* [memfault.com](https://memfault.com) — Plataforma de observabilidade e depuração de dispositivos em nuvem. 100 dispositivos gratuitos para dispositivos [Nordic](https://app.memfault.com/register-nordic), [NXP](https://app.memfault.com/register-nxp) e [Laird](https://app.memfault.com/register-laird).
* [rollbar.com](https://rollbar.com/) — Monitoramento de exceções e erros, plano gratuito com 5.000 erros/mês, usuários ilimitados, retenção de 30 dias
* [sentry.io](https://sentry.io/) — O Sentry rastreia exceções de aplicativos em tempo real e possui um pequeno plano gratuito. Gratuito para 5k erros por mês/1 usuário, uso irrestrito se auto-hospedado
* [Axiom](https://axiom.co/) — Armazene até 0,5 TB de logs com retenção de 30 dias. Inclui integrações com plataformas como Vercel e consultas avançadas de dados com notificadores por email/Discord.
* [Semaphr](https://semaphr.com) — Kill switch tudo-em-um gratuito para seus apps móveis.
* [Jam](https://jam.dev) - Relatórios de bugs amigáveis ao desenvolvedor em um clique. Plano gratuito com jams ilimitados.
* [Whitespace](https://whitespace.dev) – Relatórios de bugs em um clique direto no seu navegador. Plano gratuito com gravações ilimitadas para uso pessoal.

**[⬆️ Voltar ao Topo](#table-of-contents)**

## Busca

* [algolia.com](https://www.algolia.com/) — Solução de busca hospedada com tolerância a erros de digitação, relevância e bibliotecas de UI para criar facilmente experiências de busca. O plano gratuito "Build" inclui 1M de documentos e 10K buscas/mês. Também oferece [busca de documentação para desenvolvedores](https://docsearch.algolia.com/) gratuitamente.
* [bonsai.io](https://bonsai.io/) — 1 GB de memória e 1 GB de armazenamento gratuitos
* [CommandBar](https://www.commandbar.com/) - Barra de busca unificada como serviço, widget/plugin de UI web que permite aos usuários buscar conteúdos, navegação, funcionalidades etc. dentro do seu produto, auxiliando na descoberta. Gratuito para até 1.000 usuários ativos mensais, comandos ilimitados.
* [Orama Cloud](https://orama.com/pricing) — 3 índices gratuitos, 100K docs/índice, buscas full-text/vetoriais/híbridas ilimitadas, 60 dias de analytics
* [searchly.com](http://www.searchly.com/) — 2 índices gratuitos e 20 MB de armazenamento
* [easysitesearch.com](https://easysitesearch.com/) — Widget de busca e API, com indexação automatizada baseada em web-crawler. Buscas ilimitadas gratuitamente, para até 50 subpáginas.

**[⬆️ Voltar ao Topo](#table-of-contents)**

## Educação e Desenvolvimento de Carreira

* [FreeCodeCamp](https://www.freecodecamp.org/) - Plataforma open-source que oferece cursos e certificações gratuitos em Análise de Dados, Segurança da Informação, Desenvolvimento Web e mais.
* [The Odin Project](https://www.theodinproject.com/) - Plataforma gratuita e open-source com currículo focado em JavaScript e Ruby para desenvolvimento web.
* [Free Professional Resume Templates & Editor](https://www.overleaf.com/latex/templates/tagged/cv) - Plataforma gratuita com vários modelos de currículo de profissionais experientes, prontos para clonar, editar totalmente e baixar, otimizados para ATS.
* [DeepLearning.AI Short Courses](https://www.deeplearning.ai/short-courses/) - Cursos rápidos e gratuitos de especialistas líderes da indústria para obter experiência prática com as mais recentes ferramentas e técnicas de IA generativa em uma hora ou menos.
* [LabEx](https://labex.io) - Desenvolva habilidades em Linux, DevOps, Cibersegurança, Programação, Ciência de Dados e mais através de laboratórios interativos e projetos do mundo real.
* [Roadmap.sh](https://roadmap.sh) - Roadmaps gratuitos de aprendizado cobrindo todos os aspectos do desenvolvimento, de Blockchain a UX Design.
* [Cisco Networking Academy, Skills for All](https://skillsforall.com/) - Oferece cursos gratuitos alinhados a certificações em tópicos como cibersegurança, redes e Python.
* [MIT OpenCourseWare](https://ocw.mit.edu/) - MIT OpenCourseWare é uma publicação online de materiais de mais de 2.500 cursos do MIT, compartilhando conhecimento gratuitamente com alunos e educadores do mundo todo. Canal no Youtube: [@mitocw](https://www.youtube.com/@mitocw/featured)
* [W3Schools](https://www.w3schools.com/) - Oferece tutoriais gratuitos sobre tecnologias de desenvolvimento web como HTML, CSS, JavaScript e mais.
* [Khan Academy](https://www.khanacademy.org/computing/computer-programming) - Guias online gratuitos para aprender HTML/CSS, JavaScript e SQL do básico ao avançado.
* [Full Stack Open](https://fullstackopen.com/en/) – Curso universitário gratuito sobre desenvolvimento web moderno com React, Node.js, GraphQL, TypeScript e mais. Totalmente online e autoguiado.
* [edX](https://www.edx.org/) - Oferece acesso a mais de 4.000 cursos online gratuitos de 250 instituições líderes, incluindo Harvard e MIT, especializados em ciência da computação, engenharia e ciência de dados.
* [Django-tutorial.dev](https://django-tutorial.dev) - Guias online gratuitos para aprender Django como seu primeiro framework & oferece backlink dofollow gratuito para artigos escritos pelos usuários.

**[⬆️ Voltar ao Topo](#table-of-contents)**

## Email

* [10minutemail](https://10minutemail.com) - Email temporário gratuito para testes.
* [AhaSend](https://ahasend.com) - Serviço de email transacional, gratuito para 1000 emails por mês, com domínios ilimitados, membros de equipe, webhooks e rotas de mensagens no plano gratuito.
* [AnonAddy](https://anonaddy.com) - Encaminhamento de email anônimo open-source, crie aliases de email ilimitados gratuitamente
* [Antideo](https://www.antideo.com/) — 10 requisições de API por hora para verificação de email, validação de IP e número de telefone no plano gratuito. Não requer cartão de crédito.
* [Brevo](https://www.brevo.com/) — 9.000 emails/mês, 300 emails/dia gratuitos
* [OneSignal](https://onesignal.com/) — 10.000 emails/mês, não requer cartão de crédito.
* [Bump](https://bump.email/) - 10 endereços de email Bump gratuitos, um domínio personalizado
* [Burnermail](https://burnermail.io/) – 5 endereços de email temporários gratuitos, 1 caixa de entrada, histórico de 7 dias
* [Buttondown](https://buttondown.email/) — Serviço de newsletter. Até 100 assinantes gratuitamente
* [CloudMailin](https://www.cloudmailin.com/) - Email recebido via HTTP POST e envio transacional - 10.000 emails gratuitos/mês
* [Contact.do](https://contact.do/) — Formulário de contato em um link (bitly para formulários de contato)
* [debugmail.io](https://debugmail.io/) — Servidor de email para testes fácil de usar para desenvolvedores
* [DNSExit](https://dnsexit.com/) - Até 2 endereços de email sob seu domínio gratuitamente com 100MB de espaço de armazenamento. Suporte IMAP, POP3, SMTP, SPF/DKIM.
* [EmailLabs.io](https://emaillabs.io/en) — Envie até 9.000 emails gratuitamente por mês, até 300 emails diários.
* [EmailOctopus](https://emailoctopus.com) - Até 2.500 assinantes e 10.000 emails por mês gratuitamente
* [EmailJS](https://www.emailjs.com/) – Não é um servidor de email completo; é apenas um cliente de email que pode ser usado para enviar emails direto do cliente sem expor suas credenciais, o plano gratuito possui 200 requisições mensais, 2 modelos de email, requisições até 50Kb, histórico de contatos limitado.
* [EtherealMail](https://ethereal.email) - Ethereal é um serviço SMTP falso, voltado principalmente para usuários do Nodemailer e EmailEngine (mas não limitado a eles). É um serviço totalmente gratuito de email anti-transacional onde as mensagens nunca são entregues.
* [Temp-Mail.org](https://temp-mail.org/en/) - Geração de email temporário/descartável utilizando uma variedade de domínios. O endereço de email é atualizado toda vez que a página é recarregada. É totalmente gratuito e não possui cobrança por serviços.
* [TempMailDetector.com](https://tempmaildetector.com/) - Verifique até 200 emails por mês gratuitamente e veja se um email é temporário ou não.
* [Emailvalidation.io](https://emailvalidation.io) - 100 verificações de email gratuitas por mês
* [FakeMailGenerator.com](https://www.fakemailgenerator.com/) - Gerador alemão de email temporário/descartável. Suporta 10 domínios, permitindo a criação de endereços ilimitados. (contém anúncios), mas fora isso, não há cobrança, é totalmente gratuito.
* [forwardemail.net](https://forwardemail.net) — Encaminhamento de email gratuito para domínios personalizados. Crie e encaminhe uma quantidade ilimitada de endereços de email com seu domínio (**nota**: É necessário pagar se usar os TLDs .casa, .cf, .click, .email, .fit, .ga, .gdn, .gq, .lat, .loan, .london, .men, .ml, .pl, .rest, .ru, .tk, .top, .work devido a spam)
* [Imitate Email](https://imitate.email) - Servidor de email sandbox para testar funcionalidades de email em build/qa e ci/cd. Contas gratuitas recebem 15 emails por dia para sempre.
* [ImprovMX](https://improvmx.com) – Encaminhamento de email gratuito.
* [EForw](https://www.eforw.com) – Encaminhamento de email gratuito para um domínio. Receba e envie emails do seu domínio.
* [Inboxes App](https://inboxesapp.com) — Crie até 3 emails temporários por dia e exclua-os quando terminar dentro de uma extensão prática do Chrome. Perfeito para testar fluxos de cadastro.
* [inboxkitten.com](https://inboxkitten.com/) - Caixa de entrada gratuita de email temporário/descartável, com exclusão automática dos emails após até 3 dias. Open source e pode ser auto-hospedado.
* [mail-tester.com](https://www.mail-tester.com/) — Teste se as configurações DNS/SPF/DKIM/DMARC do email estão corretas, 20 gratuitos/mês.
* [dkimvalidator.com](https://dkimvalidator.com/) - Teste se as configurações DNS/SPF/DKIM/DMARC do email estão corretas, serviço gratuito por roundsphere.com
* [mailcatcher.me](https://mailcatcher.me/) — Captura emails e os exibe através de uma interface web.
* [mailchannels.com](https://www.mailchannels.com) - API de email com integrações REST API e SMTP, gratuito para até 3.000 emails/mês.
* [Mailcheck.ai](https://www.mailcheck.ai/) - Impede que usuários se cadastrem com endereços de email temporários, 120 requisições/hora (~86.400 por mês)
* [Mailchimp](https://mailchimp.com/) — 500 assinantes e 1.000 emails/mês gratuitos.
* [Maildroppa](https://maildroppa.com) - Até 100 assinantes e emails ilimitados, além de automações gratuitamente.
* [MailerLite.com](https://www.mailerlite.com) — 1.000 assinantes/mês, 12.000 emails/mês gratuitos
* [MailerSend.com](https://www.mailersend.com) — API de email, SMTP, 3.000 emails/mês gratuitos para emails transacionais
* [mailinator.com](https://www.mailinator.com/) — Sistema público gratuito de email onde você pode usar qualquer caixa de entrada desejada
* [Mailjet](https://www.mailjet.com/) — 6.000 emails/mês gratuitos (limite diário de envio de 200 emails)
* [Mailnesia](https://mailnesia.com) - Email temporário/descartável gratuito, que visita automaticamente links de registro.
* [mailsac.com](https://mailsac.com) - API gratuita para teste de email temporário, hospedagem pública gratuita de email, captura de saída, email-para-slack/websocket/webhook (limite de 1.500 APIs mensais)
* [Mailtrap.io](https://mailtrap.io/) — Servidor SMTP falso para desenvolvimento, plano gratuito com uma caixa de entrada, 100 mensagens, sem membros de equipe, dois emails/segundo, sem regras de encaminhamento.
* [Mail7.io](https://www.mail7.io/) — Endereços de email temporários gratuitos para desenvolvedores QA. Crie endereços instantaneamente usando a interface web ou API.
* [Momentary Email](https://www.momentaryemail.com/) — Endereços de email temporários gratuitos. Leia os emails recebidos no site ou via feed RSS.
* [Mutant Mail](https://www.mutantmail.com/) – 10 IDs de email gratuitos, 1 domínio, 1 caixa de entrada. Caixa de entrada única para todos os IDs de email.
* [Outlook.com](https://outlook.live.com/owa/) - Email pessoal e calendário gratuitos.
* [Parsio.io](https://parsio.io) — Extrator de emails gratuito (Encaminhe emails, extraia os dados, envie para seu servidor)
* [pepipost.com](https://pepipost.com) — 30k emails gratuitos no primeiro mês, depois os primeiros 100 emails/dia gratuitos.
* [Plunk](https://useplunk.com) - 3K emails/mês gratuitos
* [Postmark](https://postmarkapp.com/) - 100 emails/mês gratuitos, digests DMARC semanais ilimitados.
* [Proton Mail](https://proton.me/mail) - Serviço gratuito de email seguro com criptografia de ponta a ponta. 1GB de armazenamento gratuito.
* [Queuemail.dev](https://queuemail.dev) — API de entrega de email confiável. Plano gratuito (10.000 emails/mês). Envie de forma assíncrona. Use vários servidores SMTP. Listas de bloqueio, logs, rastreamento, webhooks e mais.
* [QuickEmailVerification](https://quickemailverification.com) — Verifique 100 emails diariamente gratuitamente no plano gratuito junto com outras APIs gratuitas como DEA Detector, DNS Lookup, SPF Detector e mais.
* [Resend](https://resend.com) - API de e-mails transacionais para desenvolvedores. 3.000 e-mails/mês, 100 e-mails/dia grátis, um domínio personalizado.
* [Sender](https://www.sender.net) Até 15.000 e-mails/mês, até 2.500 assinantes
* [Sendpulse](https://sendpulse.com) — 500 assinantes/mês, 15.000 e-mails/mês grátis
* [SimpleLogin](https://simplelogin.io/) – Solução de alias/redirecionamento de e-mail de código aberto e auto-hospedável. Gratuito para 5 aliases, banda ilimitada, resposta/envio ilimitados. Gratuito para funcionários de instituições educacionais (estudantes, pesquisadores, etc.).
* [Substack](https://substack.com) — Serviço de newsletter ilimitado e gratuito. Você só paga quando começar a cobrar.
* [Sweego](https://www.sweego.io/) - API europeia de e-mails transacionais para desenvolvedores. 500 e-mails/dia grátis.
* [Takeout](https://takeout.bysourfruit.com) - Serviço de e-mails constantemente atualizado que facilita o envio de e-mails. Quinhentos e-mails transacionais/mês grátis.
* [temp-mail.io](https://temp-mail.io) — Serviço gratuito de e-mail temporário descartável com múltiplos e-mails simultâneos e redirecionamento
* [tinyletter.com](https://tinyletter.com/) — 5.000 assinantes/mês grátis
* [Touchlead](https://touchlead.app) - Ferramenta multifuncional de automação de marketing, com gerenciamento de leads, construtor de formulários e automações. Grátis para número limitado de leads e automações
* [trashmail.com](https://www.trashmail.com) - Endereços de e-mail descartáveis gratuitos com redirecionamento e expiração automática do endereço
* [Tuta](https://tuta.com/) - Serviço gratuito de e-mail seguro com criptografia de ponta a ponta, sem anúncios, sem rastreamento. Grátis 1GB de armazenamento, um calendário (Tuta também possui um [plano pago](https://tuta.com/pricing).). Tuta também é parcialmente [código aberto](https://github.com/tutao/tutanota), permitindo auto-hospedagem.
* [Verifalia](https://verifalia.com/email-verification-api) — API de verificação de e-mails em tempo real com confirmação de caixa de correio e detecção de e-mails descartáveis; 25 verificações de e-mail grátis/dia.
* [verimail.io](https://verimail.io/) — Serviço de verificação de e-mails em massa e por API. 100 verificações grátis/mês
* [Zoho](https://www.zoho.com) — Iniciou como provedor de e-mail e agora oferece uma suíte de serviços, alguns com planos gratuitos. Lista de serviços com planos gratuitos:
   - [Email](https://zoho.com/mail) Grátis para 5 usuários. 5GB/usuário & 25 MB de limite de anexo, um domínio.
   - [Zoho Assist](https://www.zoho.com/assist) — O plano gratuito para sempre do Zoho Assist inclui uma licença de suporte remoto simultâneo e acesso a 5 licenças de computador não monitorado por tempo ilimitado, disponível para uso profissional e pessoal.
   - [Sprints](https://zoho.com/sprints) Grátis para 5 usuários, 5 projetos & 500MB de armazenamento.
   - [Docs](https://zoho.com/docs) — Grátis para 5 usuários com limite de upload de 1 GB & 5GB de armazenamento. Zoho Office Suite (Writer, Sheets & Show) incluídos.
   - [Projects](https://zoho.com/projects) — Grátis para 3 usuários, 2 projetos & 10 MB de limite de anexo. O mesmo plano se aplica ao [Bugtracker](https://zoho.com/bugtracker).
   - [Connect](https://zoho.com/connect) — Colaboração em equipe grátis para 25 usuários com três grupos, três apps personalizados, 3 quadros, 3 manuais e 10 integrações, além de canais, eventos & fóruns.
   - [Meeting](https://zoho.com/meeting) — Reuniões com até 3 participantes & 10 participantes em webinar.
   - [Vault](https://zoho.com/vault) — Gerenciamento de senhas acessível para indivíduos.
   - [Showtime](https://zoho.com/showtime) — Outro software de reuniões para treinamento remoto de até 5 participantes.
   - [Notebook](https://zoho.com/notebook) — Alternativa gratuita ao Evernote.
   - [Wiki](https://zoho.com/wiki) — Grátis para três usuários com 50 MB de armazenamento, páginas ilimitadas, backups zip, RSS & Atom feed, controles de acesso & CSS personalizável.
   - [Subscriptions](https://zoho.com/subscriptions) — Gerenciamento de cobrança recorrente grátis para 20 clientes/assinaturas & 1 usuário, com todo o processamento de pagamento feito pelo Zoho. As últimas 40 métricas de assinatura são armazenadas.
   - [Checkout](https://zoho.com/checkout) — Gerenciamento de cobrança de produtos com 3 páginas & até 50 pagamentos.
   - [Desk](https://zoho.com/desk) — Gerenciamento de suporte ao cliente com três agentes, base de conhecimento privada e tickets por e-mail. Integra-se ao [Assist](https://zoho.com/assist) para um técnico remoto & 5 computadores não monitorados.
   - [Cliq](https://zoho.com/cliq) — Chat em equipe com 100 GB de armazenamento, usuários ilimitados, 100 usuários por canal & SSO.
   - [Campaigns](https://zoho.com/campaigns) - E-mail Marketing
   - [Forms](https://zoho.com/forms) - Criador de Formulários
   - [Sign](https://zoho.com/sign) - Assinaturas Digitais
   - [Surveys](https://zoho.com/surveys) - Pesquisas Online
   - [Bookings](https://zoho.com/bookings) - Agendamento de Compromissos
* [Maileroo](https://maileroo.com) - SMTP relay e API de e-mails para desenvolvedores. 5.000 e-mails por mês, domínios ilimitados, verificação de e-mail gratuita, monitoramento de blacklist, mail tester e mais.

**[⬆️ Voltar ao Topo](#table-of-contents)**

## Plataformas de Gerenciamento de Feature Toggles

* [ConfigCat](https://configcat.com) - Serviço de feature flags centrado no desenvolvedor, com tamanho de equipe ilimitado, excelente suporte e preço acessível. Plano gratuito com até 10 flags, dois ambientes, 1 produto e 5 milhões de requisições por mês.
* [Flagsmith](https://flagsmith.com) - Lance recursos com confiança; gerencie feature flags em aplicações web, mobile e server-side. Use a API hospedada, implante na nuvem privada ou rode on-premises.
* [GrowthBook](https://growthbook.io) - Provedor open source de feature flags e testes A/B com motor de análise estatística bayesiana integrado. Grátis para até 3 usuários, feature flags e experimentos ilimitados.
* [Hypertune](https://www.hypertune.com) - Feature flags type-safe, testes A/B, analytics e configuração de apps, com controle de versão estilo Git e avaliação local síncrona e em memória. Grátis para até 5 membros com flags e testes A/B ilimitados.
* [Molasses](https://www.molasses.app) - Feature flags e testes A/B poderosos. Gratuito até 3 ambientes com cinco feature flags cada.
* [Toggled.dev](https://www.toggled.dev) - Plataforma de gerenciamento de toggles pronta para empresas, escalável e multi-regional. Plano gratuito com até 10 flags, dois ambientes, requisições ilimitadas. SDK, painel de analytics, calendário de releases, notificações Slack e todos os outros recursos incluídos no plano grátis sem limites.
* [Statsig](https://www.statsig.com) - Plataforma robusta para gerenciamento de features, testes A/B, analytics e mais. Plano gratuito generoso com assentos, flags, experimentos e configurações dinâmicas ilimitados, suportando até 1 milhão de eventos por mês.
* [Abby](https://www.tryabby.com) - Feature flags & A/B testing open-source. Configuração como código & SDKs Typescript totalmente tipados. Forte integração com frameworks como Next.js & React. Camada gratuita generosa e opções de escalonamento baratas.

**[⬆️ Voltar ao Topo](#table-of-contents)**

## Fontes

* [dafont](https://www.dafont.com/) - As fontes apresentadas neste site são propriedade de seus autores e podem ser freeware, shareware, versões demo ou domínio público.
* [Everything Fonts](https://everythingfonts.com/) - Oferece várias ferramentas; @font-face, conversor de unidades, Font Hinter e Font Submitter.
* [Font Squirrel](https://www.fontsquirrel.com/) - Fontes freeware licenciadas para uso comercial. Fontes selecionadas a dedo e apresentadas em formato fácil de usar.
* [Google Fonts](https://fonts.google.com/) - Muitas fontes gratuitas fáceis e rápidas de instalar em sites via download ou link para o CDN do Google.
* [FontGet](https://www.fontget.com/) - Possui uma variedade de fontes disponíveis para download organizadas por tags.
* [Fontshare](https://www.fontshare.com/) - serviço gratuito de fontes. Coleção crescente de fontes profissionais, 100% grátis para uso pessoal e comercial.
* [Befonts](https://befonts.com/) - Oferece diversas fontes exclusivas para uso pessoal ou comercial.
* [Font of web](https://fontofweb.com/) - Identifique todas as fontes usadas em um site e como elas são usadas.
* [Bunny](https://fonts.bunny.net) Orientado à privacidade, alternativa ao Google Fonts
* [FontsKey](https://www.fontskey.com/) - Disponibiliza fontes gratuitas e pagas para uso pessoal e permite filtrar rapidamente digitando texto.
* [fonts.xz.style](https://fonts.xz.style/) serviço gratuito e open source para entrega de famílias tipográficas para sites via CSS.
* [Fontsensei](https://fontsensei.com/) Google fonts open source marcadas por usuários. Com tags para fontes CJK (Chinês, Japonês, Coreano).

**[⬆️ Voltar ao Topo](#table-of-contents)**

## Formulários

* [Feathery](https://feathery.io) - Construtor de formulários poderoso e amigável para desenvolvedores. Crie cadastros & logins, onboarding de usuários, fluxos de pagamento, aplicações financeiras complexas e mais. O plano gratuito permite até 250 envios/mês e cinco formulários ativos.
* [Form-Data](https://form-data.com) - Backend para formulários sem código. Filtro de spam, notificação e resposta automática por e-mail, webhooks, zapier, redirecionamentos, AJAX ou POST, e mais. O plano grátis oferece formulários ilimitados, 20 envios/mês, e mais 2000 envios com badge Form-Data.
* [FabForm](https://fabform.io/) - Plataforma backend de formulários para desenvolvedores inteligentes. O plano grátis permite 250 envios de formulário por mês. Interface moderna e amigável. Integra com Google Sheets, Airtable, Slack, E-mail, entre outros.
* [Form.taxi](https://form.taxi/) — Endpoint para submissão de formulários HTML. Com notificações, bloqueadores de spam e processamento de dados compatível com GDPR. Plano gratuito para uso básico.
* [Formcarry.com](https://formcarry.com) - Endpoint HTTP POST para formulários. Plano gratuito permite 100 envios mensais.
* [formingo.co](https://www.formingo.co/)- Formulários HTML fáceis para sites estáticos. É possível começar gratuitamente sem criar conta. O plano gratuito permite 500 envios mensais e e-mail de resposta personalizável.
* [FormKeep.com](https://www.formkeep.com/) - Formulários ilimitados com 50 envios mensais, proteção contra spam, notificação por e-mail e construtor drag-and-drop que exporta HTML. Recursos adicionais incluem regras de campo personalizadas, equipes e integrações com Google Sheets, Slack, ActiveCampaign e Zapier.
* [formlets.com](https://formlets.com/) — Formulários online, páginas únicas ilimitadas/mês, 100 envios/mês, notificações por e-mail.
* [formspark.io](https://formspark.io/) - Serviço Form to Email, plano gratuito permite formulários ilimitados, 250 envios por mês, suporte pela equipe de atendimento ao cliente.
* [Formspree.io](https://formspree.io/) — Envie e-mail usando requisição HTTP POST. O plano gratuito limita a 50 envios por formulário por mês.
* [Formsubmit.co](https://formsubmit.co/) — Endpoints fáceis para seus formulários HTML. Grátis para sempre. Não requer cadastro.
* [Formlick.com](https://formlick.com) - Alternativa ao Typeform com oferta vitalícia. Usuários podem criar 1 formulário grátis e receber envios ilimitados. No premium, formulários e envios ilimitados.
* [getform.io](https://getform.io/) - Plataforma backend de formulários para designers e desenvolvedores, 1 formulário, 50 envios, upload de arquivo único, 100MB de armazenamento.
* [HeroTofu.com](https://herotofu.com/) - Backend para formulários com detecção de bots e arquivo criptografado. Encaminhe envios via UI para e-mail, Slack ou Zapier. Use seu próprio front-end. Sem necessidade de código no servidor. Plano grátis oferece formulários ilimitados e 100 envios por mês.
* [HeyForm.net](https://heyform.net/) - Construtor de formulários online drag and drop. O plano gratuito permite criar formulários ilimitados e coletar envios ilimitados. Vem com templates prontos, anti-spam e 100MB de armazenamento.
* [Tally.so](https://tally.so/) - 99% dos recursos são gratuitos. O plano grátis permite: formulários ilimitados, envios ilimitados, notificações por e-mail, lógica de formulário, coleta de pagamentos, upload de arquivos, página de agradecimento personalizada, entre outros.
* [Hyperforms.app](https://hyperforms.app/) — Crie formulários para e-mail e mais em segundos e sem backend. Conta pessoal permite até 50 envios mensais gratuitos.
* [Kwes.io](https://kwes.io/) - Endpoint de formulário rico em recursos. Funciona bem com sites estáticos. Plano gratuito inclui até 1 site com até 50 envios mensais.
* [Pageclip](https://pageclip.co/) - O plano gratuito permite um site, um formulário e 1.000 envios mensais.
* [Qualtrics Survey](https://qualtrics.com/free-account) — Crie formulários e pesquisas profissionais com esta ferramenta de primeira linha. Mais de 50 templates de pesquisa. Conta grátis limitada a 1 pesquisa ativa, 100 respostas/pesquisa & 8 tipos de resposta.
* [Screeb](https://screeb.app/) - Pesquisas in-app e analytics de produto para decifrar o comportamento do usuário. Plano gratuito para sempre permite 500 usuários ativos mensais, respostas e eventos ilimitados, várias integrações, exportação e relatórios periódicos.
* [smartforms.dev](https://smartforms.dev/) - Backend poderoso e fácil para formulários, plano grátis para sempre permite 50 envios/mês, 250MB de armazenamento, integração com Zapier, exportação CSV/JSON, redirecionamento customizado, página de resposta personalizada, bot Telegram & Slack, notificações por e-mail.
* [Survicate](https://survicate.com/) — Colete feedback de todas as fontes e envie pesquisas de acompanhamento com uma só ferramenta. Analisa feedback automaticamente e extrai insights com IA. E-mail, web, in-product ou pesquisas mobile grátis, criador de pesquisas com IA, e 25 respostas mensais.
* [staticforms.xyz](https://www.staticforms.xyz/) - Integre facilmente formulários HTML sem código server-side, gratuitamente. Após o envio, um e-mail com o conteúdo do formulário é enviado para seu endereço cadastrado.
* [stepFORM.io](https://stepform.io) - Criador de questionários e formulários. Plano gratuito possui cinco formulários, até 3 etapas por formulário e 50 respostas mensais.
* [Typeform.com](https://www.typeform.com/) — Inclua formulários lindamente desenhados em sites. O plano grátis permite apenas dez campos por formulário e 100 respostas mensais.
* [WaiverStevie.com](https://waiverstevie.com) - Plataforma de assinatura eletrônica com API REST. Notificações via webhooks. O plano gratuito adiciona marca d'água nos documentos assinados, mas permite envelopes + assinaturas ilimitadas.
* [Web3Forms](https://web3forms.com) - Formulários de contato para sites estáticos & JAMStack sem necessidade de backend. Plano gratuito permite Formulários Ilimitados, Domínios Ilimitados & 250 Envios por mês.
* [WebAsk](https://webask.io) - Construtor de pesquisas e formulários. O plano gratuito permite três pesquisas por conta, 100 respostas mensais e dez elementos por pesquisa.
* [Wufoo](https://www.wufoo.com/) - Formulários rápidos para uso em sites. O plano gratuito tem um limite de 100 envios por mês.
* [formpost.app](https://formpost.app) - Serviço gratuito e ilimitado de Formulário para E-mail. Configure redirecionamentos personalizados, respostas automáticas, webhooks, etc., de graça.
* [Formester.com](https://formester.com) - Compartilhe e incorpore formulários exclusivos em seu site—sem limites de criação de formulários ou restrição de recursos pelo plano. Receba até 100 envios por mês gratuitamente.
* [SimplePDF.eu](https://simplepdf.eu/embed) - Incorpore um editor de PDF em seu site e transforme qualquer PDF em um formulário preenchível. O plano gratuito permite PDFs ilimitados com três envios por PDF.
* [forms.app](https://forms.app/) — Crie formulários online com recursos avançados, como lógica condicional, calculadora de pontuação automática e IA. Colete até 100 respostas com o plano gratuito, incorpore seus formulários em um site ou use-os via link.
* [Qualli](https://usequalli.com) - Pesquisas no aplicativo, projetadas para dispositivos móveis. Use a IA do Qualli para criar as perguntas perfeitas. Você pode experimentar no plano gratuito, até 500 MAU, criar formulários e gatilhos ilimitados.
* [Sprig](https://sprig.com/) - 1 pesquisa no produto ou pesquisa com replay por mês, com análise por IA alimentada por GPT.
* [feedback.fish](https://feedback.fish/) - O plano gratuito permite coletar 25 envios de feedback no total. Fácil de integrar com componentes React e Vue fornecidos.
* [Vidhook](https://vidhook.io/) - Colete feedback usando pesquisas agradáveis com altas taxas de resposta. O plano gratuito inclui 1 pesquisa ativa, 25 respostas por pesquisa e modelos personalizáveis.

**[⬆️ Voltar ao Topo](#table-of-contents)**

## IA Generativa

* [Zenable](https://zenable.io) - Corrija instantaneamente as saídas de ferramentas como Cursor, Windsurf e Copilot para atender aos padrões de qualidade e conformidade da sua empresa usando guardrails construídos com Policy as Code. O nível gratuito inclui 100 chamadas de ferramentas por dia ao servidor MCP e 25 análises automáticas de pull request por dia via o aplicativo GitHub.
* [Keywords AI](https://keywordsai.co) - A melhor plataforma de monitoramento de LLM. Um formato para chamar mais de 200 LLMs com 2 linhas de código. 10.000 solicitações gratuitas todo mês e $0 para recursos da plataforma!
* [Portkey](https://portkey.ai/) - Painel de controle para apps de IA generativa com suíte de observabilidade e gateway de IA. Envie e registre até 10.000 solicitações gratuitamente por mês.
* [Braintrust](https://www.braintrustdata.com/) - Avaliações, playground de prompts e gerenciamento de dados para IA generativa. O plano gratuito oferece até 1.000 linhas privadas de avaliação por semana.
* [Findr](https://www.usefindr.com/) - Busca universal que permite pesquisar em todos os seus aplicativos de uma vez. Assistente de busca que responde perguntas usando suas informações. O plano gratuito oferece busca unificada ilimitada e 5 consultas de co-piloto diárias.
* [ReportGPT](https://ReportGPT.app) - Assistente de escrita alimentado por IA. Toda a plataforma é gratuita, desde que você utilize sua própria chave de API.
* [Clair](https://askclair.ai/) - Referência clínica de IA. Estudantes têm acesso gratuito ao conjunto de ferramentas profissionais, que inclui Busca Aberta, Resumo Clínico, Revisão Médica, Interações Medicamentosas, Códigos CID-10 e Stewardship. Além disso, está disponível um teste gratuito para o pacote profissional.
* [Langtrace](https://langtrace.ai) - Permite que desenvolvedores rastreiem, avaliem, gerenciem prompts e conjuntos de dados, e depurem problemas relacionados ao desempenho de aplicações LLM. Cria rastreamentos padrão open telemetry para qualquer LLM, ajudando na observabilidade e funcionando com qualquer cliente de observabilidade. O plano gratuito oferece 50 mil rastreamentos/mês.
* [LangWatch](https://langwatch.ai) - Plataforma LLMOps que auxilia equipes de IA a medir, monitorar e otimizar aplicações LLM para confiabilidade, custo-benefício e desempenho. Com um poderoso componente DSPy, permite colaboração entre engenheiros e equipes não técnicas para ajustar e colocar produtos GenAI em produção. Plano gratuito inclui todos os recursos da plataforma, 1k rastreamentos/mês e 1 workflow de otimizador DSPy. [#opensource](https://github.com/langwatch/langwatch)
* [Comet Opik](https://www.comet.com/site/products/opik/) - Avalie, teste e implemente aplicações LLM em todos os ciclos de vida de desenvolvimento e produção. [#opensource](https://github.com/comet-ml/opik/)
* [Langfuse](https://langfuse.com/) - Plataforma open-source para engenharia de LLMs que ajuda equipes a depurar, analisar e iterar colaborativamente em suas aplicações LLM. Plano gratuito para sempre inclui 50 mil observações mensais e todos os recursos da plataforma. [#opensource](https://github.com/langfuse/langfuse)
* [Pollinations.AI](https://pollinations.ai/) - IA de geração de imagens fácil de usar, gratuita, com API disponível gratuitamente. Não requer cadastro ou chave de API, e várias opções para integração em site ou workflow. [#opensource](https://github.com/pollinations/pollinations)
* [Othor AI](https://othor.ai/) - Alternativa de BI rápida, simples e segura baseada em IA para soluções populares como Tableau, Power BI e Looker. Othor utiliza LLMs para entregar soluções personalizadas de BI em minutos. Plano Free Forever fornece um workspace com cinco conexões de fonte de dados para um usuário, sem limites de análises. [#opensource](https://github.com/othorai/othor.ai)
* [OpenRouter](https://openrouter.ai/models?q=free) - Fornece diversos modelos de IA gratuitos, incluindo DeepSeek R1, V3, Llama e Moonshot AI. Esses modelos são excelentes em processamento de linguagem natural e adequados para diversas necessidades de desenvolvimento. Observe que, embora gratuitos, estão sujeitos a limites de uso. Modelos pagos também disponíveis para requisitos avançados, como Claude, OpenAI, Grok, Gemini e Nova.

**[⬆️ Voltar ao Topo](#table-of-contents)**

## CDN e Proteção

* [bootstrapcdn.com](https://www.bootstrapcdn.com/) — CDN para bootstrap, bootswatch e fontawesome.io
* [cdnjs.com](https://cdnjs.com/) — Simples. Rápido. Confiável. Distribuição de conteúdo de alta qualidade. cdnjs é um serviço CDN gratuito e open-source confiado por mais de 11% de todos os sites, alimentado pela Cloudflare.
* [developers.google.com](https://developers.google.com/speed/libraries/) — Google Hosted Libraries é uma rede de distribuição de conteúdo para as bibliotecas JavaScript Open Source mais populares.
* [Stellate](https://stellate.co/) - Stellate é um CDN ultra-rápido e confiável para sua API GraphQL, gratuito para dois serviços.
* [jsdelivr.com](https://www.jsdelivr.com/) — CDN open-source gratuito, rápido e confiável. Suporta npm, GitHub, WordPress, Deno e mais.
* [Microsoft Ajax](https://docs.microsoft.com/en-us/aspnet/ajax/cdn/overview) — O Microsoft Ajax CDN hospeda populares bibliotecas JavaScript de terceiros, como jQuery, e permite adicioná-las facilmente à sua aplicação web.
* [ovh.ie](https://www.ovh.ie/ssl-gateway/) — Proteção gratuita contra DDoS e certificado SSL.
* [Skypack](https://www.skypack.dev/) — CDN 100% nativo para módulos ES JavaScript. Gratuito para 1 milhão de requisições por domínio por mês.
* [raw.githack.com](https://raw.githack.com/) — Um substituto moderno do **rawgit.com** que simplesmente hospeda arquivos usando Cloudflare.
* [section.io](https://www.section.io/) — Uma maneira simples de iniciar e gerenciar uma solução completa de Varnish Cache. Supostamente gratuito para sempre para um site.
* [statically.io](https://statically.io/) — CDN para repositórios Git (GitHub, GitLab, Bitbucket), ativos relacionados ao WordPress e imagens.
* [toranproxy.com](https://toranproxy.com/) — Proxy para Packagist e GitHub. Nunca falhe no CD. Grátis para uso pessoal, um desenvolvedor, sem suporte.
* [UNPKG](https://unpkg.com/) — CDN para tudo que está no npm.
* [weserv](https://images.weserv.nl/) — Serviço de cache e redimensionamento de imagens. Manipule imagens em tempo real com cache mundial.
* [Namecheap Supersonic](https://www.namecheap.com/supersonic-cdn/#free-plan) — Proteção gratuita contra DDoS.
* [Gcore](https://gcorelabs.com/) Rede global de CDN, 1 TB e 1 milhão de requisições por mês grátis e hospedagem DNS gratuita.
* [CacheFly](https://portal.cachefly.com/signup/free2023) - Até 5 TB por mês de tráfego CDN gratuito, 19 Core PoPs, 1 domínio e SSL universal.

**[⬆️ Voltar ao Topo](#table-of-contents)**

## PaaS

* [anvil.works](https://anvil.works) - Desenvolvimento de web apps usando apenas Python. Nível gratuito com apps ilimitados e timeouts de 30 segundos.
* [appwrite](https://appwrite.io) - Projetos ilimitados sem pausa (suporta websockets) e serviço de autenticação. 1 banco de dados, 3 buckets, 5 funções por projeto no nível gratuito.
* [configure.it](https://www.configure.it/) — Plataforma de desenvolvimento de apps móveis, grátis para dois projetos, recursos limitados mas sem restrição de recursos.
* [codenameone.com](https://www.codenameone.com/) — Ferramenta open source, multiplataforma, para desenvolvimento móvel Java/Kotlin. Gratuito para uso comercial com número ilimitado de projetos.
* [deco.cx](https://www.deco.cx/en/dev) - Plataforma frontend edge-native com CMS visual gerado automaticamente a partir de código TypeScript. Testes A/B, segmentação de conteúdo e analytics em tempo real inclusos. Ideal para e-commerce de conteúdo pesado e enterprise. Grátis até 5k pageviews/mês ou projetos open-source/pessoais.
* [Deno Deploy](https://deno.com/deploy) - Sistema distribuído que executa JavaScript, TypeScript e WebAssembly na borda globalmente. O plano gratuito inclui 100.000 requisições por dia e 100 GiB de transferência de dados por mês.
* [domcloud.co](https://domcloud.co) – Serviço de hospedagem Linux que oferece CI/CD com GitHub, SSH e banco de dados MariaDB/Postgres. A versão gratuita possui 1 GB de armazenamento, 1 GB de rede/mês e está limitada a um domínio gratuito.
* [encore.dev](https://encore.dev/) — Framework backend que usa análise estática para fornecer infraestrutura automática, código sem boilerplate e mais. Inclui hospedagem gratuita para projetos hobby.
* [flightcontrol.dev](https://flightcontrol.dev/) - Implemente serviços web, bancos de dados e mais em sua própria conta AWS com workflow estilo Git push. Nível gratuito para 1 desenvolvedor em repositórios pessoais do GitHub. Custos AWS cobrados pela própria AWS, mas é possível usar créditos e a camada gratuita da AWS.
* [gigalixir.com](https://gigalixir.com/) - Oferece uma instância gratuita que nunca dorme e banco de dados PostgreSQL gratuito limitado a 2 conexões, 10.000 linhas e sem backups para apps Elixir/Phoenix.
* [Glitch](https://glitch.com/) — Hospedagem pública gratuita com compartilhamento de código e colaboração em tempo real. O plano gratuito tem limite de 1000 horas/mês.
* [leapcell](https://leapcell.io/) - Plataforma distribuída confiável para aplicações, fornecendo tudo para sustentar seu crescimento rapidamente. O plano gratuito inclui 100k invocações de serviço, 10k tarefas assíncronas e 100k comandos Redis.
* [pipedream.com](https://pipedream.com) - Plataforma de integração para desenvolvedores. Desenvolva qualquer workflow com qualquer gatilho. Workflows são código que você pode rodar [de graça](https://docs.pipedream.com/pricing/). Sem servidores ou recursos em nuvem para gerenciar.
* [pythonanywhere.com](https://www.pythonanywhere.com/) — Hospedagem em nuvem para apps Python. Conta iniciante é gratuita, 1 app web Python no domínio your-username.pythonanywhere.com, 512 MB de armazenamento privado, um banco de dados MySQL.
* [ampt.dev](https://getampt.com/) - Permite que equipes construam, implementem e escalem apps JavaScript na AWS sem configs complicadas ou gerenciamento de infraestrutura. Plano Preview gratuito inclui 500 invocações por hora, 2.500 diárias e 50.000 mensais. Domínios personalizados apenas nos planos pagos.
* [Koyeb](https://www.koyeb.com) - Plataforma serverless developer-friendly para deploy global de apps. Rode containers Docker, web apps e APIs com deploy via git, autoscaling nativo, edge network global e service mesh embutido. Instância gratuita permite deploy de web service em Frankfurt (Alemanha) ou Washington, D.C. (EUA). Banco de dados Postgres gerenciado gratuito disponível em Frankfurt, Washington e Singapura. 512MB RAM, 2GB armazenamento e 0.1 CPU.
* [Napkin](https://www.napkin.io/) - FaaS com 500Mb de memória, timeout padrão de 15 segundos e 5.000 chamadas de API grátis/mês limitadas a 5 chamadas/segundo.
* [Meteor Cloud](https://www.meteor.com/cloud) — Galaxy hosting. Plataforma como serviço Meteor para apps Meteor inclui hospedagem MongoDB compartilhada gratuita e SSL automático.
* [Northflank](https://northflank.com) — Construa e implemente microsserviços, jobs e bancos gerenciados com UI, API e CLI poderosas. Escalabilidade de containers via controle de versão e registries externos Docker. Nível gratuito inclui dois serviços, dois cron jobs e 1 banco de dados.
* [YepCode](https://yepcode.io) - Plataforma all-in-one para conectar APIs e serviços em ambiente serverless. Traz toda a agilidade e benefícios do NoCode, mas com o poder das linguagens de programação. Nível gratuito inclui [1.000 yeps](https://yepcode.io/pricing/).
* [WunderGraph](https://cloud.wundergraph.com) - Plataforma open-source para construir, entregar e gerenciar APIs modernas rapidamente. CI/CD embutido, integração com GitHub e HTTPS automático. Até 3 projetos, 1GB de saída, 300 minutos de build/mês no [plano gratuito](https://wundergraph.com/pricing)
* [Zeabur](https://zeabur.com) - Implemente seus serviços com um clique. Grátis para três serviços, com US$ 5 em créditos gratuitos por mês.
* [mogenius](https://mogenius.com) - Construa, implemente e rode serviços facilmente no Kubernetes. O nível gratuito permite conectar um Kubernetes local com mogenius, possibilitando que desenvolvedores criem ambiente de testes semelhante à produção em suas máquinas.
* [genezio](https://genezio.com/) - Provedor de funções serverless oferece 1 milhão de chamadas de função, 100GB de banda e 10 cron jobs mensais grátis, exclusivo para uso não comercial ou acadêmico.

**[⬆️ Voltar ao Topo](#table-of-contents)**

## BaaS

* [Activepieces](https://www.activepieces.com) - Construa fluxos de automação para conectar diversos apps no backend do seu aplicativo. Por exemplo, envie mensagem no Slack ou adicione linha no Google Sheets quando um evento ocorre em seu app. Grátis até 5.000 tarefas por mês.
* [back4app.com](https://www.back4app.com) - Backend fácil de usar, flexível e escalável baseado na plataforma Parse.
* [backendless.com](https://backendless.com/) — BaaS para mobile e web, com 1 GB de armazenamento de arquivos grátis, 50.000 notificações push/mês e 1.000 objetos de dados na tabela.
* [bismuth.cloud](https://www.bismuth.cloud/) — Nossa IA irá bootstrapar sua API Python em nosso runtime de funções e armazenamento hospedado, construa e hospede gratuitamente em nosso editor online ou localmente com suas ferramentas favoritas.
* [BMC Developer Program](https://developers.bmc.com/site/global/bmc_helix_platform/program/overview/index.gsp) — O Programa de Desenvolvedores BMC oferece documentação e recursos para construir e implantar inovações digitais para sua empresa. Acesso a um sandbox pessoal, abrangente, que inclui a plataforma, SDK e uma biblioteca de componentes para construir e personalizar apps.
* [connectycube.com](https://connectycube.com) - Mensagens de chat ilimitadas, chamadas p2p de voz e vídeo, anexos de arquivos e push notifications. Grátis para apps com até 1.000 usuários.
* [convex.dev](https://convex.dev/) - Backend reativo como serviço, hospedando seus dados (documentos com relacionamentos e transações ACID serializáveis), funções serverless e WebSockets para atualização em clientes. Grátis para projetos pequenos - até 1M de registros, 5M de chamadas de função mensais.
* [darklang.com](https://darklang.com/) - Linguagem hospedada combinando editor e infraestrutura. Acessível durante o beta, com generoso nível gratuito planejado após o beta.
* [Firebase](https://firebase.com) — Ajuda a criar e executar apps de sucesso. O Plano Spark gratuito oferece Autenticação, Hospedagem, Firebase ML, Realtime Database, Cloud Storage, Testlab. A/B Testing, Analytics, App Distribution, App Indexing, Cloud Messaging (FCM), Crashlytics, Dynamic Links, In-App Messaging, Performance Monitoring, Predictions e Remote Config são sempre gratuitos.
* [Flutter Flow](https://flutterflow.io) — Construa a UI do seu app Flutter sem escrever código. Também integra com Firebase. O plano gratuito inclui acesso total ao UI Builder e templates grátis.
* [getstream.io](https://getstream.io/) — Construa chat in-app escalável, mensagens, vídeo e áudio, e feeds em poucas horas ao invés de semanas
* [hasura.io](https://hasura.io/) — Hasura amplia seus bancos de dados existentes, independente da hospedagem, e fornece uma API GraphQL instantânea para acesso seguro via web, mobile e integrações. Grátis para até 1GB/mês de tráfego de dados.
* [nhost.io](https://nhost.io) - Backend serverless para apps web e mobile. O plano gratuito inclui PostgreSQL, GraphQL (Hasura), Autenticação, Armazenamento e Funções Serverless.
* [onesignal.com](https://onesignal.com/) — Notificações push ilimitadas gratuitas. 10.000 envios de e-mail por mês, contatos ilimitados e acesso ao Auto Warm Up.
* [paraio.com](https://paraio.com) — Serviço de backend com autenticação flexível, busca full-text e cache. Grátis para um app, 1GB de dados de app.
* [pubnub.com](https://www.pubnub.com/) — Notificações push gratuitas para até 1 milhão de mensagens/mês e 100 dispositivos ativos diários
* [pushbots.com](https://pushbots.com/) — Serviço de notificações push. Gratuito para até 1,5 milhão de notificações/mês
* [pushcrew.com](https://pushcrew.com/) — Serviço de notificações push. Notificações ilimitadas para até 2.000 assinantes
* [pusher.com](https://pusher.com/beams) — Notificações push gratuitas e ilimitadas para 2.000 usuários ativos mensais. Uma única API para dispositivos iOS e Android.
* [quickblox.com](https://quickblox.com/) — Backend de comunicação para mensagens instantâneas, chamadas de vídeo e voz, e notificações push
* [restspace.io](https://restspace.io/) - Configure um servidor com serviços para autenticação, dados, arquivos, API de e-mail, templates e mais, compondo pipelines e transformando dados.
* [Salesforce Developer Program](https://developer.salesforce.com/signup) — Construa apps rapidamente com ferramentas de arrastar e soltar. Personalize seu modelo de dados com cliques. Vá além com código Apex. Integre com qualquer coisa usando APIs poderosas. Fique protegido com segurança de nível empresarial. Personalize a UI com cliques ou qualquer framework web moderno. O programa gratuito para desenvolvedores oferece acesso total à Lightning Platform.
* [simperium.com](https://simperium.com/) — Movimente dados em qualquer lugar instantaneamente e automaticamente, multiplataforma, envio e armazenamento ilimitado de dados estruturados, máx. 2.500 usuários/mês
* [Supabase](https://supabase.com) — A alternativa open source ao Firebase para construir backends. O plano gratuito oferece autenticação, banco de dados em tempo real e armazenamento de objetos.
* [tyk.io](https://tyk.io/) — Gerenciamento de API com autenticação, cotas, monitoramento e análises. Oferta gratuita na nuvem
* [zapier.com](https://zapier.com/) — Conecte os aplicativos que você usa para automatizar tarefas. Cinco zaps a cada 15 minutos e 100 tarefas/mês
* [IFTTT](https://ifttt.com) — Automatize seus aplicativos e dispositivos favoritos. 2 Applets gratuitos
* [Integrately](https://integrately.com) — Automatize tarefas tediosas com um clique. 100 tarefas gratuitas, atualização a cada 15 minutos, cinco automações ativas, webhooks.
* [LeanCloud](https://leancloud.app/) — Backend móvel. 1GB de armazenamento de dados, 256MB de instância, 3K requisições API/dia e 10K notificações push/dia gratuitos. (API muito similar ao Parse Platform)
* [Claw.cloud](https://run.claw.cloud) - Plataforma PaaS oferecendo US$ 5/mês em créditos gratuitos para usuários com conta GitHub com mais de 180 dias. Perfeito para hospedar apps, bancos de dados e mais. ([Link de cadastro com crédito grátis](https://ap-southeast-1.run.claw.cloud/signin)).


**[⬆️ Voltar ao Topo](#table-of-contents)**

## Plataforma Low-code

* [appsmith](https://www.appsmith.com/) — Projeto low code para construir painéis de administração, ferramentas internas e dashboards. Integra-se com mais de 15 bancos de dados e qualquer API.
* [Basedash](https://www.basedash.com) — Plataforma low-code para criar painéis administrativos internos e dashboards. Suporta bancos de dados SQL e APIs REST.
* [BudiBase](https://budibase.com/) — Budibase é uma plataforma open source low-code para criar aplicativos internos em minutos. Suporta PostgreSQL, MySQL, MSSQL, MongoDB, Rest API, Docker, K8s
* [Clappia](https://www.clappia.com) — Plataforma low-code projetada para criar aplicações de processos de negócios com apps web e mobile personalizáveis. Oferece interface de arrastar e soltar, recursos como suporte offline, rastreamento de localização em tempo real e integração com vários serviços de terceiros
* [DronaHQ](https://www.dronahq.com/) — DronaHQ - uma plataforma low code que ajuda equipes de engenharia e gerentes de produto a criar ferramentas internas, jornadas personalizadas, experiências digitais, automações, painéis administrativos e apps operacionais 10X mais rápido.
* [lil'bots](https://www.lilbots.io/) - escreva e execute scripts online utilizando APIs gratuitas integradas como OpenAI, Anthropic, Firecrawl e outras. Excelente para construir agentes de IA / ferramentas internas e compartilhar com a equipe. O plano gratuito inclui acesso completo às APIs, assistente de código IA e 10.000 créditos de execução/mês.
* [Mendix](https://www.mendix.com/) — Desenvolvimento rápido de aplicações para empresas, ambientes sandbox ilimitados suportando usuários totais, 0,5 GB de armazenamento e 1 GB de RAM por app. IDEs Studio e Studio Pro também permitidas no plano gratuito.
* [outsystems.com](https://www.outsystems.com/) — PaaS de desenvolvimento web empresarial para on-premise ou nuvem, oferta gratuita de "ambiente pessoal" permite código ilimitado e até 1 GB de banco de dados
* [ReTool](https://retool.com/) — Plataforma low-code para construir aplicações internas. Retool é altamente customizável. Se você pode escrever em JavaScript e usar uma API, pode criar na Retool. O plano gratuito permite até cinco usuários por mês, apps e conexões API ilimitados.
* [Superblocks](https://superblocks.com/) — Plataforma aberta para aplicações empresariais, projetada para desenvolvedores e equipes semi-técnicas. Use IA para gerar, editar visualmente e estender com código. Gerencie centralmente com integrações, autenticação, permissões e logs de auditoria.
* [ToolJet](https://www.tooljet.com/) — Framework low-code extensível para criar aplicativos empresariais. Conecte-se a bancos de dados, storages em nuvem, GraphQL, endpoints de API, Airtable, etc., e crie apps usando construtor de aplicativos drag-and-drop.
* [UI Bakery](https://uibakery.io) — Plataforma low-code que permite construir aplicações web personalizadas rapidamente. Suporta construção de UI com drag and drop e alto nível de customização via JavaScript, Python e SQL. Disponível como solução em nuvem e self-hosted. Grátis para até 5 usuários.
* [manubes](https://www.manubes.com) - Plataforma cloud poderosa no-code com foco em gestão de produção industrial. Gratuito para um usuário com 1 milhão de atividades de workflow por mês ([também disponível em alemão](https://www.manubes.de)).

**[⬆️ Voltar ao Topo](#table-of-contents)**

## Hospedagem Web

* [Alwaysdata](https://www.alwaysdata.com/) — 100 MB de hospedagem web gratuita com suporte para MySQL, PostgreSQL, CouchDB, MongoDB, PHP, Python, Ruby, Node.js, Elixir, Java, Deno, servidores web customizados, acesso via FTP, WebDAV e SSH; caixa postal, lista de e-mails e instalador de apps inclusos.
* [Awardspace.com](https://www.awardspace.com) — Hospedagem web gratuita + domínio curto gratuito, PHP, MySQL, Instalador de Apps, Envio de Email & Sem Anúncios.
* [Bohr](https://bohr.io) — Gratuito para projetos não comerciais + Plataforma de Deployment e Desenvolvimento Developer-First que minimiza o trabalho com infraestrutura e acelera a configuração.
* [Bubble](https://bubble.io/) — Programação visual para criar apps web e mobile sem código, gratuito com branding Bubble.
* [dAppling Network](https://www.dappling.network/) - Plataforma de hospedagem web descentralizada para frontends Web3, focada em aumentar o uptime e a segurança, e fornecer ponto de acesso adicional para usuários.
* [DigitalOcean](https://www.digitalocean.com/pricing) - Construa e faça deploy de três sites estáticos gratuitamente na App Platform Starter.
* [Drive To Web](https://drv.tw) — Hospede diretamente na web a partir do Google Drive & OneDrive. Apenas sites estáticos. Gratuito para sempre. Um site por conta Google/Microsoft.
* [Fenix Web Server](https://preview.fenixwebserver.com) - Aplicativo desktop para desenvolvedores hospedarem sites localmente e compartilharem publicamente (em tempo real). Trabalhe como preferir, com interface gráfica, API e/ou CLI.
* [Fern](https://buildwithfern.com) - Construa e hospede um site de documentação baseado em Markdown no plano gratuito da Fern. É possível até mesmo gerar automaticamente uma referência de API a partir de arquivos de definição de API. O site é hospedado em _yoursite_.docs.buildwithfern.com.
* [Free Hosting](https://freehostingnoads.net/) — Hospedagem gratuita com PHP 5, Perl, CGI, MySQL, FTP, Gerenciador de Arquivos, Email POP, subdomínios gratuitos, hospedagem de domínio gratuita, Editor de Zona DNS, Estatísticas do Site, SUPORTE Online GRÁTIS e muitos outros recursos não oferecidos por outros hosts gratuitos.
* [Freehostia](https://www.freehostia.com) — FreeHostia oferece serviços de hospedagem gratuitos incluindo um Painel de Controle líder do setor e instalação 1-click de 50+ apps gratuitos. Configuração instantânea. Sem anúncios forçados.
* [HelioHost](https://heliohost.org) — Hospedagem web gratuita sem fins lucrativos com painel Plesk, PHP, Node.js, Python, Django, Flask, .NET, Perl, CGI, MySQL, PostgreSQL, SQLite, e-mail IMAP/POP3/SMTP, banda ilimitada, subdomínios gratuitos, 1000 MB de armazenamento gratuito com opção de upgrade.
* [Kinsta Static Site Hosting](https://kinsta.com/static-site-hosting/) — Hospede até 100 sites estáticos gratuitamente, domínios customizados com SSL, 100 GB de banda mensal, mais de 260 locais CDN Cloudflare.
* [Lecturify](https://www.lecturify.net/index.en.html) - Hospedagem web com acesso SFPT para upload e download de arquivos, php disponível.
* [Neocities](https://neocities.org) — Site estático, 1 GB de armazenamento gratuito com 200 GB de banda.
* [Netlify](https://www.netlify.com/) — Constrói, faz deploy e hospeda site/app estático gratuitamente para 100 GB de dados e 100 GB/mês de banda.
* [pantheon.io](https://pantheon.io/) — Hospedagem Drupal e WordPress, DevOps automatizado e infraestrutura escalável. Gratuito para desenvolvedores e agências. Sem domínio personalizado.
* [readthedocs.org](https://readthedocs.org/) — Hospedagem gratuita de documentação com versionamento, geração de PDF e mais
* [render.com](https://render.com) — Nuvem unificada para construir e rodar apps e sites com SSL gratuito, CDN global, redes privadas, deploy automático via Git e planos totalmente gratuitos para serviços web, bancos de dados e páginas web estáticas.
* [SourceForge](https://sourceforge.net/) — Encontre, crie e publique software Open Source gratuitamente
* [surge.sh](https://surge.sh/) — Publicação web estática para desenvolvedores Front-End. Sites ilimitados com suporte a domínio personalizado
* [telegra.ph](https://telegra.ph/) Crie facilmente páginas web usando Quill
* [tilda.cc](https://tilda.cc/) — Um site, 50 páginas, 50 MB de armazenamento, apenas os blocos principais pré-definidos entre 170+ disponíveis, sem fontes, sem favicon, e sem domínio personalizado
* [Vercel](https://vercel.com/) — Construa, faça deploy e hospede apps web com SSL gratuito, CDN global e URLs de preview exclusivos a cada `git push`. Perfeito para Next.js e outros geradores de site estático.
* [Versoly](https://versoly.com/) — Construtor de sites focado em SaaS - sites ilimitados, 70+ blocos, cinco templates, CSS customizado, favicon, SEO e formulários. Sem domínio personalizado.
* [Qoddi](https://qoddi.com) - Serviço PaaS semelhante ao Heroku com abordagem centrada no desenvolvedor e recursos all-inclusive. Plano gratuito para ativos estáticos, staging e apps de desenvolvedor.
* [FreeFlarum](https://freeflarum.com/) - Hospedagem gratuita e comunitária de Flarum para até 250 usuários (doe para remover a marca d'água do rodapé).
* [MDB GO](https://mdbgo.com/) - Hospedagem gratuita para um projeto com TTL de Container de duas semanas, 500 MB de RAM por projeto, SFTP - 1G de espaço em disco.
* [Patr Cloud](https://patr.cloud/) — Plataforma cloud fácil de usar, entre seus serviços pagos oferece hospedagem gratuita para três sites estáticos.
* [Serv00.com](https://serv00.com/) — 3 GB de hospedagem web gratuita com backups diários (7 dias). Suporte: tarefas Crontab, acesso SSH, repositórios (GIT, SVN e Mercurial), suporte: MySQL, PostgreSQL, MongoDB, PHP, Node.js, Python, Ruby, Java, Perl, TCL/TK, Lua, Erlang, Rust, Pascal, C, C++, D, R, e muito mais.
- [Sevalla](https://sevalla.com/) - Plataforma de hospedagem projetada para simplificar o deploy e gerenciamento de aplicativos, bancos de dados e sites estáticos - limite de 1GB por site, 100GB de banda gratuita, 600 minutos gratuitos de build, 100 sites por conta.

**[⬆️ Voltar ao Topo](#table-of-contents)**

## DNS

* [1.1.1.1](https://developers.cloudflare.com/1.1.1.1/) - Resolver DNS público gratuito, rápido e seguro (criptografa sua consulta DNS), fornecido pela Cloudflare. Útil para contornar bloqueios de DNS do seu provedor, evitar espionagem de consultas DNS e [bloquear conteúdo adulto e malware](https://developers.cloudflare.com/1.1.1.1/1.1.1.1-for-families). Também pode ser usado [via API](https://developers.cloudflare.com/1.1.1.1/encrypted-dns/dns-over-https/make-api-requests). Nota: Apenas resolver DNS, não hospeda DNS.
* [1984.is](https://www.1984.is/product/freedns/) — Serviço de DNS gratuito com API e vários outros recursos gratuitos incluídos.
* [cloudns.net](https://www.cloudns.net/) — Hospedagem DNS gratuita para até 1 domínio com 50 registros
* [deSEC](https://desec.io) - Hospedagem DNS gratuita com suporte a API, projetada com foco em segurança. Funciona com software open source e é suportado pela [SSE](https://www.securesystems.de/).
* [dns.he.net](https://dns.he.net/) — Serviço de hospedagem DNS gratuita com suporte a DNS Dinâmico
* [Zonomi](https://zonomi.com/) — Serviço de hospedagem DNS gratuito com propagação instantânea. Plano gratuito: 1 zona DNS (nome de domínio) com até 10 registros DNS.
* [dnspod.com](https://www.dnspod.com/) — Hospedagem DNS gratuita.
* [duckdns.org](https://www.duckdns.org/) — DDNS gratuito com até 5 domínios na camada gratuita. Com guias de configuração para vários cenários.
* [Dynv6.com](https://dynv6.com/) — Serviço DDNS gratuito com [suporte a API](https://dynv6.com/docs/apis) e gerenciamento de vários tipos de registros DNS (como CNAME, MX, SPF, SRV, TXT e outros).
* [freedns.afraid.org](https://freedns.afraid.org/) — Hospedagem DNS gratuita. Também oferece subdomínios gratuitos baseados em vários domínios públicos [contribuídos por usuários](https://freedns.afraid.org/domain/registry/). Obtenha subdomínios gratuitos no menu "Subdomains" após o cadastro.
* [luadns.com](https://www.luadns.com/) — Hospedagem DNS gratuita, três domínios, todos os recursos com limites razoáveis
* [namecheap.com](https://www.namecheap.com/domains/freedns/) — DNS gratuito. Sem limite no número de domínios
* [nextdns.io](https://nextdns.io) - Firewall baseado em DNS, 300 mil consultas gratuitas por mês
* [noip.at](https://noip.at/) — Serviço DDNS gratuito sem registro, rastreamento, logging ou publicidade. Sem limite de domínios.
* [noip](https://www.noip.com/) — Serviço de DNS dinâmico que permite até 3 hostnames gratuitos, com confirmação a cada 30 dias
* [sslip.io](https://sslip.io/) — Serviço DNS gratuito que, ao consultar um nome de host com o IP embutido, retorna esse IP.
* [zilore.com](https://zilore.com/en/dns) — Hospedagem DNS gratuita para 5 domínios.
* [zoneedit.com](https://www.zoneedit.com/free-dns/) — Hospedagem DNS gratuita com suporte a DNS Dinâmico.
* [zonewatcher.com](https://zonewatcher.com) — Backups automáticos e monitoramento de mudanças DNS. Um domínio gratuito
* [huaweicloud.com](https://www.huaweicloud.com/intl/en-us/product/dns.html) – Hospedagem DNS gratuita pela Huawei
* [Hetzner](https://www.hetzner.com/dns-console) – Hospedagem DNS gratuita pela Hetzner com suporte a API.
* [Glauca](https://docs.glauca.digital/hexdns/) – Hospedagem DNS gratuita para até 3 domínios e suporte a DNSSEC
* [VolaryDDNS](https://volaryddns.net) - DDNS gratuito de alta performance sem assinaturas ou anúncios
**[⬆️ Voltar ao Topo](#table-of-contents)**

## Domínio

  * [pp.ua](https://nic.ua/) — Subdomínios pp.ua gratuitos.
  * [us.kg](https://nic.us.kg/) - Subdomínios us.kg gratuitos.

**[⬆️ Voltar ao Topo](#table-of-contents)**

## IaaS

  * [4EVERLAND](https://www.4everland.org/) — Compatível com AWS S3 - APIs, operações de interface, CLI e outros métodos de upload, faça upload e armazene arquivos das redes IPFS e Arweave de forma segura, conveniente e eficiente. Usuários registrados podem obter 6 GB de armazenamento IPFS e 300 MB de armazenamento Arweave gratuitamente. Qualquer upload de arquivo Arweave menor que 150 KB é gratuito.
  * [backblaze.com](https://www.backblaze.com/b2/) — Armazenamento em nuvem Backblaze B2. 10 GB gratuitos de armazenamento de objetos (semelhante ao Amazon S3) por tempo ilimitado.
  * [filebase.com](https://filebase.com/) - Armazenamento de objetos compatível com S3 movido a Blockchain. 5 GB de armazenamento gratuito por tempo ilimitado.
  * [Tebi](https://tebi.io/) - Armazenamento de objetos compatível com S3. 25 GB de armazenamento gratuito e 250 GB de transferência de saída.
  * [Idrive e2](https://www.idrive.com/e2/) - Armazenamento de objetos compatível com S3. 10 GB de armazenamento gratuito e 10 GB de largura de banda de download por mês.
  * [C2 Object Storage](https://c2.synology.com/en-us/pricing/object-storage) - Armazenamento de objetos compatível com S3. 15 GB de armazenamento gratuito e 15 GB de downloads por mês.

**[⬆️ Voltar ao Topo](#table-of-contents)**

## Serviços Gerenciados de Dados

  * [Aiven](https://aiven.io/) - Aiven oferece planos gratuitos de PostgreSQL, MySQL e Redis em sua plataforma de dados open-source. Nó único, 1 CPU, 1GB RAM, e para PostgreSQL e MySQL, 5GB de armazenamento. Fácil migração para planos mais robustos ou entre nuvens.
  * [airtable.com](https://airtable.com/) — Parece uma planilha, mas é um banco de dados relacional com bases ilimitadas, 1.200 linhas/base e 1.000 requisições API/mês.
  * [Astra](https://www.datastax.com/products/datastax-astra/) — Cassandra Nativo em Nuvem como Serviço com [80GB gratuitos](https://www.datastax.com/products/datastax-astra/pricing)
  * [codehooks.io](https://codehooks.io/) — API/backend serverless em JavaScript fácil de usar e serviço de banco de dados NoSQL com funções, consultas tipo MongoDB, buscas chave/valor, sistema de tarefas, mensagens em tempo real, filas de trabalho, CLI poderosa e gerenciador de dados web. Plano gratuito tem 5GB de armazenamento e 60 chamadas/API por minuto. 2 desenvolvedores inclusos. Sem necessidade de cartão de crédito.
  * [CrateDB](https://crate.io/) - Banco de dados SQL Open Source distribuído para análise em tempo real. [Nível gratuito CRFREE](https://crate.io/lp-crfree): Um nó com 2 CPUs, 2 GiB de memória, 8 GiB de armazenamento. Um cluster por organização, sem necessidade de método de pagamento.
  * [Upstash](https://upstash.com/) — Redis serverless com nível gratuito até 10.000 requisições por dia, 256MB tamanho máximo do banco de dados e 20 conexões simultâneas.
  * [Couchbase Capella](https://www.couchbase.com/products/capella/) - implante um cluster de banco de dados totalmente gerenciado e gratuito para sempre, construído para desenvolvedores criarem a próxima geração de aplicações de IoT a IA.
  * [MongoDB Atlas](https://www.mongodb.com/cloud/atlas) — nível gratuito oferece 512 MB.
  * [redsmin.com](https://www.redsmin.com/) — Serviço online de monitoramento e administração em tempo real para Redis, monitoramento de 1 instância Redis gratuito.
  * [redislabs](https://redislabs.com/try-free/) - Instância Redis gratuita de 30MB.
  * [MemCachier](https://www.memcachier.com/) — Serviço gerenciado de Memcache. Gratuito até 25MB, 1 servidor proxy e análises básicas.
  * [scalingo.com](https://scalingo.com/) — Principalmente um PaaS, mas oferece nível gratuito de 128MB a 192MB de MySQL, PostgreSQL ou MongoDB.
  * [SeaTable](https://seatable.io/) — Banco de dados flexível tipo planilha desenvolvido pela equipe Seafile. Tabelas ilimitadas, 2.000 linhas, versionamento de 1 mês, até 25 membros da equipe.
  * [skyvia.com](https://skyvia.com/) — Plataforma de Dados em Nuvem oferece nível gratuito e todos os planos são completamente gratuitos enquanto estiverem em beta.
  * [StackBy](https://stackby.com/) — Uma ferramenta que combina a flexibilidade de planilhas, o poder de bancos de dados e integrações nativas com seus aplicativos de negócios favoritos. O plano gratuito inclui usuários ilimitados, dez stacks e 2GB de anexos por stack.
  * [TiDB Cloud](https://en.pingcap.com/tidb-cloud/) — TiDB é um RDBMS HTAP distribuído compatível com MySQL e open-source. O TiDB Serverless oferece 5GB de armazenamento em linhas, 5GB de armazenamento em colunas e 50 milhões de Request Units (RUs) gratuitamente por mês.
  * [Turso by ChiselStrike](https://chiselstrike.com/) - Turso é uma experiência de desenvolvedor SQLite em um banco de dados Edge. O Turso oferece um plano Free Forever, 9 GB de armazenamento total, até 500 bancos de dados, até 3 localizações, 1 bilhão de leituras de linhas por mês e suporte para desenvolvimento local com SQLite.
  * [InfluxDB](https://www.influxdata.com/) — Banco de dados de séries temporais, gratuito até 3MB/5 minutos de escrita, 30MB/5 minutos de leitura e 10.000 séries de cardinalidade.
  * [restdb.io](https://restdb.io/) - Serviço de banco de dados NoSQL rápido e direto na nuvem. Com o restdb.io você obtém esquema, relações, API REST automática (com consultas tipo MongoDB) e uma interface administrativa multiusuário eficiente para trabalhar com dados. O plano gratuito permite 3 usuários, 2500 registros e 1 requisição API por segundo.
  * [CockroachDB Cloud](https://www.cockroachlabs.com/pricing/) — Nível gratuito oferece 50 milhões de RUs e 10 GiB de armazenamento (equivalente a 15 dólares) por mês. ([O que são Request Units?](https://www.cockroachlabs.com/docs/cockroachcloud/metrics-request-units.html))
  * [Neo4j Aura](https://neo4j.com/cloud/aura/) — Banco de dados nativo em grafos gerenciado / plataforma de análise com linguagem de consulta Cypher e API REST. Limite de tamanho do grafo (50k nós, 175k relacionamentos).
  * [Neon](https://neon.tech/) — PostgreSQL gerenciado, 0.5 GB de armazenamento (total), 1 Projeto, 10 branches, bancos de dados ilimitados, branch primária sempre disponível (suspensão automática após 5 minutos), 20 horas de tempo ativo por mês (total) para branches não primárias.
  * [Prisma Postgres](https://prisma.io/postgres) - PostgreSQL hospedado super rápido construído em unikernels e rodando em bare metal, 1GB de armazenamento, 10 bancos de dados, integrado com Prisma ORM.
  * [Dgraph Cloud](https://cloud.dgraph.io/pricing?type=free) — Banco de dados nativo em grafos gerenciado com API GraphQL. Limitado a 1 MB de transferência de dados por dia.
  * [Tinybird](https://tinybird.co) - ClickHouse gerenciado serverless com ingestão de dados sem conexão via HTTP e permite publicar consultas SQL como APIs HTTP gerenciadas. Sem limite de tempo no nível gratuito, 10GB de armazenamento + 1000 requisições API por dia.
  * [TigerGraph Cloud](https://www.tigergraph.com/cloud/) — Banco de dados nativo em grafos gerenciado / plataforma de análise com linguagem de consulta gráfica tipo SQL e API REST. Uma instância gratuita com dois vCPU, 8GB de Memória e 50GB de armazenamento que hiberna após 1 hora de inatividade.
  * [TerminusCMS](https://terminusdb.com/pricing) — Serviço gratuito gerenciado para TerminusDB, um banco de dados de documentos e grafos escrito em Prolog e Rust. Gratuito para desenvolvimento, serviço pago para implantações empresariais e suporte.
  * [filess.io](https://filess.io) - O filess.io é uma plataforma onde você pode criar dois bancos de dados com até 10 MB por banco dos seguintes SGBDs gratuitamente: MySQL, MariaDB, MongoDB e PostgreSQL.
  * [xata.io](https://xata.io) - Xata é um banco de dados serverless com busca e análises poderosas integradas. Uma API, múltiplas bibliotecas cliente type-safe, e otimizado para seu fluxo de desenvolvimento. O nível gratuito para sempre é suficiente para desenvolvedores de hobby, inclui três unidades de Xata, consulte o site para definição de unidade.
  * [8base.com](https://www.8base.com/) - 8base é uma plataforma de desenvolvimento low-code full-stack construída para desenvolvedores JavaScript sobre MySQL, GraphQL e backend-as-a-service serverless. Permite começar a construir aplicações web rapidamente usando um construtor de apps visual e escalar rapidamente. O nível gratuito inclui: 2.500 linhas, 500 de armazenamento, computação serverless: 1Gb/h e 5 usuários de app cliente.
  * [Nile](https://www.thenile.dev/) — Plataforma Postgres para apps B2B. Bancos de dados ilimitados, sempre disponível sem desligamento, 1GB de armazenamento (total), 50 milhões de tokens de consulta, autoscaling, embeddings vetoriais ilimitados



**[⬆️ Voltar ao Topo](#table-of-contents)**

## Túnel, WebRTC, Servidores Web Socket e Outros Roteadores

  * [Pinggy](https://pinggy.io) — URLs públicas para localhost com um único comando, sem necessidade de download. Túneis HTTPS / TCP / TLS. O plano gratuito tem duração de túnel de 60 minutos.
  * [conveyor.cloud](https://conveyor.cloud/) — Extensão do Visual Studio para expor o IIS Express para a rede local ou via túnel para uma URL pública.
  * [Hamachi](https://www.vpn.net/) — LogMeIn Hamachi é um serviço VPN hospedado que permite estender redes tipo LAN para equipes distribuídas com um plano gratuito que permite redes ilimitadas com até 5 pessoas.
  * [Mirna Sockets](https://mirna.cloud/) - Plataforma gratuita de Socket como Serviço que fornece uma URL wss:// ao implantar seu código de servidor Web Socket e também permite monitorar seu desempenho.
  * [localhost.run](https://localhost.run/) — Exponha servidores locais em execução via túnel para uma URL pública.
  * [localtunnel](https://theboroer.github.io/localtunnel-www/) — Exponha servidores locais em execução via túnel para uma URL pública. Versão hospedada gratuita e [open source](https://github.com/localtunnel/localtunnel).
  * [ngrok.com](https://ngrok.com/) — Exponha servidores locais em execução via túnel para uma URL pública.
  * [cname.dev](https://cname.dev/) — Serviço de proxy reverso dinâmico gratuito e seguro.
  * [serveo](https://serveo.net/) — Exponha servidores locais para a internet. Sem instalação, sem cadastro. Subdomínio gratuito, sem limites.
  * [Radmin VPN](https://www.radmin-vpn.com/) — Conecte múltiplos computadores via VPN, habilitando uma rede tipo LAN. Pares ilimitados. (Alternativa ao Hamachi)
  * [segment.com](https://segment.com/) — Hub para traduzir e rotear eventos para outros serviços de terceiros. 100.000 eventos/mês gratuitos.
  * Google STUN — [stun:stun.l.google.com:19302](stun:stun.l.google.com:19302)
  * Twilio STUN — [stun:global.stun.twilio.com:3478?transport=udp](stun:global.stun.twilio.com:3478?transport=udp)
  * [Tailscale](https://tailscale.com/) — VPN sem configuração, usando o protocolo open-source WireGuard. Instala em MacOS, iOS, Windows, Linux e Android. Plano gratuito para uso pessoal com 100 dispositivos e três usuários.
  * [webhookrelay.com](https://webhookrelay.com) — Gerencie, depure, distribua e faça proxy de todos seus webhooks para destinos públicos ou internos (ex: localhost). Também exponha servidores rodando em rede privada via túnel obtendo um endpoint HTTP público (`https://yoursubdomain.webrelay.io <----> http://localhost:8080`).
  * [Hookdeck](https://hookdeck.com/pricing) — Desenvolva, teste e monitore seus webhooks de qualquer lugar. 100K requisições e 100K tentativas por mês com três dias de retenção.
  * [Xirsys](https://www.xirsys.com/pricing/) — Uso ilimitado de STUN + 500 MB de banda TURN mensal, banda limitada, uma região geográfica.
  * [ZeroTier](https://www.zerotier.com) — Ethernet virtual FOSS gerenciado como serviço. Redes ilimitadas, criptografadas end-to-end de até 25 clientes no plano gratuito. Clientes para desktop/mobile/NA; interface web para configuração de regras personalizadas de roteamento e aprovação de novos nós clientes em redes privadas.
  * [LocalXpose](https://localxpose.io) — Proxy reverso que permite expor seus servidores localhost para a internet. O plano gratuito tem duração de túnel de 15 minutos.
  * [Traefik-Hub](https://traefik.io/traefik-hub/) - Publique serviços em execução localmente via túnel para uma URL pública personalizada e proteja-os com controle de acesso. Gratuito para 5 serviços em um cluster.
  * [Expose](https://expose.dev/) - Exponha sites locais via túneis seguros. O plano gratuito inclui servidor na UE, subdomínios aleatórios e usuários únicos.
  * [btunnel](https://www.btunnel.in/) — Exponha localhost e servidor tcp local para a internet. O plano gratuito inclui servidor de arquivos, cabeçalhos http personalizados de requisição e resposta, proteção básica por autenticação e 1 hora de timeout de túnel.

**[⬆️ Voltar ao Topo](#table-of-contents)**

## Rastreamento de Issues e Gerenciamento de Projetos

  * [acunote.com](https://www.acunote.com/) — Software gratuito de gerenciamento de projetos e SCRUM para até 5 membros da equipe.
  * [asana.com](https://asana.com/) — Gratuito para projetos privados com colaboradores.
  * [Backlog](https://backlog.com) — Tudo que sua equipe precisa para lançar ótimos projetos em uma única plataforma. O plano gratuito oferece 1 projeto com dez usuários & 100MB de armazenamento.
  * [Basecamp](https://basecamp.com/personal) - Listas de tarefas, gerenciamento de marcos, mensagens tipo fórum, compartilhamento de arquivos e controle de tempo. Até 3 projetos, 20 usuários e 1GB de espaço de armazenamento.
  * [bitrix24.com](https://www.bitrix24.com/) — Ferramenta de intranet e gerenciamento de projetos. O plano gratuito oferece 5GB para usuários ilimitados.
  * [cacoo.com](https://cacoo.com/) — Diagramas online em tempo real: fluxogramas, UML, rede. Máx. 15 usuários/diagrama gratuitos, 25 folhas.
  * [Chpokify](https://chpokify.com/) — Planning Poker baseado em equipes que economiza tempo na estimativa de sprints. Gratuito até 5 usuários, integrações Jira gratuitas, chamadas de vídeo ilimitadas, equipes ilimitadas, sessões ilimitadas.
  * [clickup.com](https://clickup.com/) — Gerenciamento de projetos. Gratuito, versão premium com armazenamento em nuvem. Aplicativos móveis e integrações com Git disponíveis.
  * [Clockify](https://clockify.me) - Aplicativo de rastreamento de tempo e folha de ponto que permite controlar horas trabalhadas em projetos. Usuários ilimitados, gratuito para sempre.
  * [Cloudcraft](https://cloudcraft.co/) — Desenhe diagramas profissionais de arquitetura em minutos com o designer visual do Cloudcraft, otimizado para AWS com componentes inteligentes que mostram dados ao vivo. Plano gratuito tem diagramas privados ilimitados para usuário único.
  * [Codegiant](https://codegiant.io) — Gerenciamento de projetos com hospedagem de repositório & CI/CD. Plano gratuito oferece repositórios, projetos & documentos ilimitados com 5 membros na equipe. 500 minutos de CI/CD por mês. 30000 minutos de execução de código serverless por mês, 1GB de armazenamento de repositório.
  * [Confluence](https://www.atlassian.com/software/confluence) - Ferramenta de colaboração de conteúdo da Atlassian, usada para ajudar equipes a colaborar e compartilhar conhecimento eficientemente. Plano gratuito para até 10 usuários.
  * [contriber.com](https://www.contriber.com/) — Plataforma de gerenciamento de projetos personalizável, plano inicial gratuito, cinco workspaces
* [Crosswork](https://crosswork.app/) - Plataforma versátil de gerenciamento de projetos. Gratuito para até 3 projetos, usuários ilimitados, 1 GB de armazenamento.
* [diagrams.net](https://app.diagrams.net/) — Diagramas online armazenados localmente no Google Drive, OneDrive ou Dropbox. Gratuito para todos os recursos e níveis de armazenamento.
* [freedcamp.com](https://freedcamp.com/) - tarefas, discussões, marcos, controle de tempo, calendário, arquivos e gerenciador de senhas. Plano gratuito com projetos, usuários e armazenamento de arquivos ilimitados.
* [easyretro.io](https://www.easyretro.io/) — Ferramenta simples e intuitiva para retrospectivas de sprint. O plano gratuito oferece três quadros públicos e uma pesquisa por quadro por mês.
* [GForge](https://gforge.com) — Conjunto de ferramentas de Gerenciamento de Projetos e Rastreamento de Problemas para projetos complexos, com opções on-premises e SaaS. O plano gratuito SaaS oferece os cinco primeiros usuários grátis e é gratuito para Projetos Open Source.
* [gleek.io](https://www.gleek.io) — Ferramenta gratuita de descrição para diagramas para desenvolvedores. Crie diagramas UML informais de classes, objetos ou relacionamentos de entidades usando suas palavras-chave.
* [GraphQL Inspector](https://github.com/marketplace/graphql-inspector) - O GraphQL Inspector gera uma lista de alterações entre dois esquemas GraphQL. Cada diferença é explicada e marcada como breaking, non-breaking ou dangerous.
* [huboard.com](https://huboard.com/) — Gerenciamento instantâneo de projetos para suas issues do GitHub, gratuito para Open Source.
* [Hygger](https://hygger.io) — Plataforma de gerenciamento de projetos. O plano gratuito oferece usuários, projetos e quadros ilimitados com 100 MB de armazenamento.
* [Instabug](https://instabug.com) — SDK abrangente de relatórios de bugs e feedback in-app para aplicativos móveis. Plano gratuito para até 1 app e um membro.
* [WishKit](https://wishkit.io) — Colete feedback de usuários in-app para seu app iOS/macOS e priorize recursos com base nos votos dos usuários. Plano gratuito até 1 app.
* [Ilograph](https://www.ilograph.com/)  — Diagramas interativos que permitem aos usuários ver sua infraestrutura sob múltiplas perspectivas e níveis de detalhes. Os gráficos podem ser expressos em código. O nível gratuito possui diagramas privados ilimitados com até 3 visualizadores.
* [Jira](https://www.atlassian.com/software/jira) — Ferramenta avançada de gerenciamento de projetos de desenvolvimento de software usada em muitos ambientes corporativos. Plano gratuito para até 10 usuários.
* [kanbanflow.com](https://kanbanflow.com/) — Gerenciamento de projetos baseado em quadros. Gratuito, versão premium com mais opções.
* [kanbantool.com](https://kanbantool.com/) — Gerenciamento de projetos baseado em quadros Kanban. O plano gratuito possui dois quadros e dois usuários, sem anexos ou arquivos.
* [kan.bn](https://kan.bn/) - Um app kanban poderoso e flexível que ajuda você a organizar o trabalho, acompanhar o progresso e entregar resultados — tudo em um só lugar. Plano gratuito para até 1 usuário, quadros ilimitados, listas ilimitadas, cartões ilimitados.
* [Kitemaker.co](https://kitemaker.co) - Colabore em todas as fases do processo de desenvolvimento de produto e acompanhe o trabalho no Slack, Discord, Figma e Github. Usuários e espaços ilimitados. Plano gratuito até 250 itens de trabalho.
* [Kiter.app](https://www.kiter.app/) - Permite que qualquer pessoa organize sua busca de emprego e acompanhe entrevistas, oportunidades e conexões. Web app poderoso e extensão para Chrome. Totalmente gratuito.
* [Kumu.io](https://kumu.io/)  — Mapas de relacionamentos com animações, decorações, filtros, agrupamentos, importação de planilhas, etc. O nível gratuito permite projetos públicos ilimitados. Tamanho do gráfico ilimitado. Projetos privados gratuitos para estudantes. Modo sandbox disponível se preferir não deixar seu arquivo público online (upload, edição, download, descarte).
* [Linear](https://linear.app/) — Rastreador de issues com interface simplificada. Gratuito para membros ilimitados, upload de arquivos até 10MB, 250 issues (excluindo Arquivo).
* [leiga.com](https://www.leiga.com/) — Leiga é um produto SaaS que usa IA para gerenciar automaticamente seus projetos, ajudando sua equipe a manter o foco e liberar enorme potencial, garantindo que seus projetos avancem conforme planejado. Gratuito para até 10 usuários, 20 campos customizados, 2GB de armazenamento, gravação de vídeo com IA limitada a 5 mins/vídeo, automações 20/usuário/mês.
* [Lucidchart](https://www.lucidchart.com/) - Ferramenta online de diagramas com recursos de colaboração. Plano gratuito com três documentos editáveis, 100 modelos profissionais e recursos básicos de colaboração.
* [MeisterTask](https://www.meistertask.com/) — Gerenciamento de tarefas online para equipes. Gratuito para até 3 projetos e membros ilimitados por projeto.
* [MeuScrum](https://www.meuscrum.com/en) - Ferramenta scrum gratuita online com quadro kanban.
* [nTask](https://www.ntaskmanager.com/) — Software de gerenciamento de projetos que permite colaboração, planejamento, análise e gestão de tarefas diárias pelas equipes. O plano essencial é gratuito para sempre com 100 MB de armazenamento e cinco usuários/equipes. Espaços de trabalho, reuniões, atribuições, folhas de ponto e rastreamento de issues ilimitados.
* [Ora](https://ora.pm/) - Gestão ágil de tarefas e colaboração em equipe. Gratuito para até 3 usuários e arquivos limitados a 10 MB.
* [pivotaltracker.com](https://www.pivotaltracker.com/) — Gratuito para projetos públicos ilimitados e dois projetos privados com três usuários ativos (leitura e escrita) e usuários passivos ilimitados (somente leitura).
* [plan.io](https://plan.io/) — Gerenciamento de projetos com hospedagem de repositórios e mais opções. Gratuito para dois usuários com dez clientes e 500MB de armazenamento.
* [Plane](https://plane.so/) - Plane é uma ferramenta simples, extensível e open-source para gerenciamento de projetos e produtos. Gratuito para membros ilimitados, upload de arquivos até 5MB, 1000 issues.
* [planitpoker.com](https://www.planitpoker.com/) — Ferramenta gratuita de planning poker online (estimativa).
* [point.poker](https://www.point.poker/) - Planning Poker online (ferramenta de estimativa por consenso). Gratuito para usuários, equipes, sessões, rodadas e votos ilimitados. Não é necessário cadastro.
* [ScrumFast](https://www.scrumfast.com) - Quadro Scrum com interface muito intuitiva, gratuito para até 5 usuários.
* [Shake](https://www.shakebugs.com/) - Ferramenta de feedback e relatório de bugs in-app para apps móveis. Plano gratuito, dez relatórios de bugs por app/mês.
* [Shortcut](https://shortcut.com/) - Plataforma de gerenciamento de projetos. Gratuito para até 10 usuários para sempre.
* [Tadum](https://tadum.app) - Aplicativo de agenda e atas de reuniões projetado para reuniões recorrentes, gratuito para equipes de até 10 pessoas.
* [taiga.io](https://taiga.io/) — Plataforma de gerenciamento de projetos para startups e desenvolvedores ágeis, gratuito para Open Source.
* [Tara AI](https://tara.ai/) — Serviço simples de gerenciamento de sprints. O plano gratuito possui tarefas, sprints e workspaces ilimitados sem limite de usuários.
* [targetprocess.com](https://www.targetprocess.com/) — Gerenciamento visual de projetos, do Kanban e Scrum a quase qualquer processo operacional. Gratuito para usuários ilimitados, até 1.000 entidades de dados {[mais detalhes](https://www.targetprocess.com/pricing/)}
* [taskade.com](https://www.taskade.com/) — Listas de tarefas colaborativas em tempo real e outlines de equipes. O plano gratuito possui um workspace com tarefas e projetos ilimitados; 1GB de armazenamento de arquivos; 1 semana de histórico de projetos; e cinco participantes por reunião de vídeo.
* [taskulu.com](https://taskulu.com/) — Gerenciamento de projetos baseado em funções. Gratuito para até 5 usuários. Integração com GitHub/Trello/Dropbox/Google Drive.
* [Teaminal](https://www.teaminal.com) - Ferramenta de standup, retro e planejamento de sprint para equipes remotas. Gratuito para até 15 usuários.
* [teamwork.com](https://teamwork.com/) — Gerenciamento de projetos e chat de equipe. Gratuito para cinco usuários e dois projetos. Planos premium disponíveis.
* [teleretro.com](https://www.teleretro.com/) — Ferramenta de retrospectiva simples e divertida com quebra-gelos, gifs e emojis. O plano gratuito inclui três retros e membros ilimitados.
* [testlio.com](https://testlio.com/) — Plataforma de rastreamento de issues, gerenciamento de testes e beta testing. Gratuito para uso privado.
* [terrastruct.com](https://terrastruct.com/) — Criador de diagramas online especificamente para arquitetura de software. Nível gratuito até 4 camadas por diagrama.
* [todoist.com](https://todoist.com/) — Gerenciamento colaborativo e individual de tarefas. O plano gratuito possui: 5 projetos ativos, cinco usuários por projeto, upload de arquivos até 5MB, três filtros e uma semana de histórico de atividades.
* [trello.com](https://trello.com/) — Gerenciamento de projetos baseado em quadros. Quadros Pessoais Ilimitados, 10 Quadros de Equipe.
* [Tweek](https://tweek.so/) — Calendário de tarefas semanal simples e gerenciamento de tarefas.
* [ubertesters.com](https://ubertesters.com/) — Plataforma de testes, integração e testadores da multidão, 2 projetos, cinco membros.
* [Wikifactory](https://wikifactory.com/) — Serviço de design de produtos com projetos, VCS e issues. O plano gratuito oferece projetos e colaboradores ilimitados e 3GB de armazenamento.
* [Yodiz](https://www.yodiz.com/) — Desenvolvimento ágil e rastreamento de issues. Gratuito para até 3 usuários, projetos ilimitados.
* [YouTrack](https://www.jetbrains.com/youtrack/buy/#edition=incloud) — YouTrack hospedado gratuitamente (InCloud) para projetos FOSS e projetos privados (gratuito para três usuários). Inclui rastreamento de tempo e quadros ágeis.
* [zenhub.com](https://www.zenhub.com) — A única solução de gerenciamento de projetos dentro do GitHub. Gratuito para repositórios públicos, OSS e organizações sem fins lucrativos.
* [zenkit.com](https://zenkit.com) — Ferramenta de gerenciamento de projetos e colaboração. Gratuito para até 5 membros, 5 GB de anexos.
* [Zube](https://zube.io) — Gerenciamento de projetos com plano gratuito para 4 projetos e 4 usuários. Integração com GitHub disponível.
* [Toggl](https://toggl.com/) — Oferece duas ferramentas gratuitas de produtividade. [Toggl Track](https://toggl.com/track/) para gerenciamento e controle de tempo com plano gratuito que oferece controle de tempo e relatórios sem interrupções, projetado para freelancers. Possui registros de tempo, projetos, clientes, tags, relatórios ilimitados e mais. E [Toggl Plan](https://toggl.com/plan/) para planejamento de tarefas com plano gratuito para desenvolvedores solo com tarefas, marcos e cronogramas ilimitados.
* [Sflow](https://sflow.io) — sflow.io é uma ferramenta de gerenciamento de projetos construída para desenvolvimento ágil de software, marketing, vendas e suporte ao cliente, especialmente para projetos de outsourcing e colaboração entre organizações. Plano gratuito para até 3 projetos e cinco membros.
* [Pulse.red](https://pulse.red) — Aplicativo minimalista gratuito de controle de tempo e folhas de ponto para projetos.

**[⬆️ Voltar ao Topo](#table-of-contents)**

## Armazenamento e Processamento de Mídia

* [AndroidFileHost](https://androidfilehost.com/) - Plataforma gratuita de compartilhamento de arquivos com velocidade ilimitada, banda, quantidade de arquivos, downloads etc. Voltada principalmente para arquivos relacionados a desenvolvimento Android, como APK, ROM customizada e modificações, mas parece aceitar outros tipos de arquivos também.
* [borgbase.com](https://www.borgbase.com/) — Hospedagem simples e segura de backups offsite para Borg Backup. 10 GB de espaço gratuito e dois repositórios.
* [icedrive.net](https://www.icedrive.net/) - Serviço simples de armazenamento em nuvem. 10 GB de armazenamento gratuito.
* [sync.com](https://www.sync.com/) - Serviço de armazenamento em nuvem com criptografia ponta a ponta. 5 GB de armazenamento gratuito.
* [pcloud.com](https://www.pcloud.com/) - Serviço de armazenamento em nuvem. Até 10 GB de armazenamento gratuito.
* [sirv.com](https://sirv.com/) — CDN inteligente de imagens com otimização e redimensionamento em tempo real. O plano gratuito inclui 500 MB de armazenamento e 2 GB de banda.
* [cloudimage.io](https://www.cloudimage.io/en/home) — Serviço completo de otimização e CDN de imagens com mais de 1500 pontos de presença no mundo. Diversas funções de redimensionamento, compressão e marca d’água. Plugins open source para imagens responsivas, criação de imagens 360 e edição de imagem. Plano mensal gratuito com 25GB de tráfego CDN, 25GB de cache e transformações ilimitadas.
* [cloudinary.com](https://cloudinary.com/) — Upload de imagens, manipulação avançada, armazenamento e entrega para sites e apps, com bibliotecas para Ruby, Python, Java, PHP, Objective-C e mais. O plano gratuito inclui 25 créditos mensais. Um crédito equivale a 1.000 transformações de imagem, 1 GB de armazenamento ou 1 GB de uso de CDN.
* [embed.ly](https://embed.ly/) — Fornece APIs para incorporar mídia em páginas web, escalonamento responsivo de imagens e extração de elementos de páginas web. Gratuito para até 5.000 URLs/mês a 15 requisições/segundo.
* [filestack.com](https://www.filestack.com/) — Seleção, transformação e entrega de arquivos, gratuito para 250 arquivos, 500 transformações e 3 GB de banda.
* [file.io](https://www.file.io) - 2 GB de armazenamento de arquivos. O arquivo é apagado automaticamente após um download. REST API para interação. Limite de uma requisição/minuto.
* [freetools.site](https://freetools.site/) — Ferramentas online gratuitas. Converta ou edite documentos, imagens, áudio, vídeo e mais.
* [GoFile.io](https://gofile.io/) - Plataforma gratuita de compartilhamento e armazenamento de arquivos via interface web e API. Tamanho de arquivo, banda, downloads, etc., ilimitados. Os arquivos são removidos após ficarem inativos (sem download por mais de dez dias).
* [gumlet.com](https://www.gumlet.com/) — Hospedagem, processamento e streaming de imagens e vídeos via CDN. Generoso plano gratuito de 250 GB/mês para vídeos e 30 GB/mês para imagens.
* [image-charts.com](https://www.image-charts.com/) — Geração ilimitada de gráficos em imagem com marca d'água.
* [Imgbot](https://github.com/marketplace/imgbot) — Imgbot é um robô simpático que otimiza suas imagens e economiza seu tempo. Imagens otimizadas significam arquivos menores sem perder qualidade. Gratuito para open source.
* [ImgBB](https://imgbb.com/) — ImgBB é um serviço ilimitado de hospedagem de imagens. Arraste e solte sua imagem em qualquer lugar da tela. Limite de 32 MB por imagem. Receba links diretos, BBCode e miniaturas HTML após o upload. Faça login para acessar o histórico de uploads.
* [imgen](https://www.jitbit.com/imgen/) - API gratuita e ilimitada para geração de imagens de capa social, sem marca d’água.
* [imgix](https://www.imgix.com/) - Cache, gerenciamento e CDN de imagens. O plano gratuito inclui 1000 imagens de origem, transformações infinitas e 100 GB de banda.
* [kraken.io](https://kraken.io/) — Otimização de imagens como serviço para performance web, plano gratuito para arquivos de até 1 MB.
* [kvstore.io](https://www.kvstore.io/) — Serviço de armazenamento key-value. O plano gratuito permite 100 chaves, 1KB/chave, 100 chamadas/hora.
* [npoint.io](https://www.npoint.io/) — Armazenamento de JSON com edição colaborativa de schema.
* [nitropack.io](https://nitropack.io/) - Acelere a velocidade do seu site de forma automática com otimização completa de front-end (cache, imagens, código e CDN). Gratuito para até 5.000 pageviews/mês.
* [otixo.com](https://www.otixo.com/) — Criptografe, compartilhe, copie e mova todos os seus arquivos de armazenamento em nuvem em um só lugar. O plano básico oferece transferência ilimitada com arquivos de até 250 MB e permite cinco arquivos criptografados.
* [packagecloud.io](https://packagecloud.io/) — Repositórios de pacotes hospedados para YUM, APT, RubyGem e PyPI. Planos gratuitos limitados e planos open source disponíveis mediante solicitação.
* [getpantry.cloud](https://getpantry.cloud/) — API simples de armazenamento de dados JSON, perfeita para projetos pessoais, hackathons e aplicativos móveis!
* [Pinata IPFS](https://pinata.cloud) — Pinata é a maneira mais simples de fazer upload e gerenciar arquivos no IPFS. Interface amigável e API IPFS tornam o Pinata o serviço de pinning IPFS mais fácil para plataformas, criadores e colecionadores. 1 GB de armazenamento gratuito, com acesso à API.
* [placekitten.com](https://placekitten.com/) — Serviço rápido e simples para obter imagens de gatinhos como placeholders.
* [plot.ly](https://plot.ly/) — Crie gráficos e compartilhe seus dados. O plano gratuito inclui arquivos públicos ilimitados e dez arquivos privados.
* [podio.com](https://podio.com/) — Você pode usar o Podio com uma equipe de até cinco pessoas e experimentar os recursos do Plano Básico, exceto o gerenciamento de usuários.
* [QRME.SH](https://qrme.sh) - Gerador de QR Code em massa rápido e bonito – sem login, sem marca d'água, sem anúncios. Até 100 URLs por exportação em lote.
* [QuickChart](https://quickchart.io) — Gere gráficos de imagens, gráficos e QR codes embutíveis.
* [redbooth.com](https://redbooth.com) — Sincronização de arquivos P2P, gratuito para até 2 usuários.
* [resmush.it](https://resmush.it) — reSmush.it é uma API GRATUITA para otimização de imagens. Implementada nos CMS mais comuns como WordPress, Drupal ou Magento. É a API de otimização de imagens mais usada, com mais de sete bilhões de imagens já tratadas, e continua gratuita.
* [Shotstack](https://shotstack.io) - API para geração e edição de vídeo em escala. Gratuito até 20 minutos de vídeo renderizado por mês.
* [tinypng.com](https://tinypng.com/) — API para comprimir e redimensionar imagens PNG e JPEG, oferece 500 compressões gratuitas por mês.
* [transloadit.com](https://transloadit.com/) — Gerencia uploads e codificação de arquivos de vídeo, áudio, imagens e documentos. Gratuito para Open Source, instituições de caridade e estudantes via GitHub Student Developer Pack. Aplicações comerciais têm 2 GB gratuitos para testes.
  * [twicpics.com](https://www.twicpics.com) - Imagens responsivas como serviço. Oferece um CDN de imagens, uma API de processamento de mídia e uma biblioteca frontend para automatizar a otimização de imagens. O serviço é gratuito para até 3GB de tráfego/mês.
  * [uploadcare.com](https://uploadcare.com/hub/developers/) — O Uploadcare fornece o pipeline de mídia com o kit de ferramentas definitivo baseado em algoritmos de ponta. Todos os recursos estão disponíveis gratuitamente para desenvolvedores: API e UI de upload de arquivos, CDN de imagens e serviços de origem, entrega adaptativa e compressão inteligente. O plano gratuito inclui 3000 uploads, 3 GB de tráfego e 3 GB de armazenamento.
  * [imagekit.io](https://imagekit.io) – CDN de imagens com otimização automática, transformação em tempo real e armazenamento que pode ser integrado à configuração existente em minutos. O plano gratuito inclui até 20GB de banda por mês.
  * [internxt.com](https://internxt.com) – O Internxt Drive é um serviço de armazenamento de arquivos baseado em privacidade absoluta e segurança intransigente. Cadastre-se e ganhe 10 GB grátis para sempre!
  * [degoo.com](https://degoo.com/) – Armazenamento em nuvem baseado em IA com até 20 GB gratuitos, três dispositivos, bônus de indicação de 5 GB (90 dias de inatividade da conta).
  * [MConverter.eu](https://mconverter.eu/) – Converta arquivos em lote. Suporta muitos formatos, incluindo novos como [AVIF](https://mconverter.eu/convert/to/avif/). Extraia todos os frames de imagens de vídeos. Grátis para até dez arquivos de 100MB por dia, processados em lotes de dois.
  * [ImageEngine](https://imageengine.io/) – O ImageEngine é um CDN global de imagens fácil de usar. Configuração em menos de 60 segundos. Suporte a AVIF e JPEGXL, plugins para WordPress, Magento, React, Vue e mais. Solicite sua conta gratuita de desenvolvedor [aqui](https://imageengine.io/developer-program/).
  * [DocsParse](https://docsparse.com/) – Processamento de PDFs e imagens com IA GPT, extraindo dados estruturados em formatos JSON, CSV e EXCEL. 30 créditos gratuitos por mês.
  * [VaocherApp QR Code Generator](https://www.vaocherapp.com/qr-code-generator) – Crie facilmente QR Codes personalizados para cartões presente, vouchers e promoções. Suporte a customização de estilo, cor, logo...
  * [LibreQR](https://libreqr.com) — Gerador de QR Code gratuito focado em privacidade e sem rastreamento. Livre para uso sem coleta de dados.


**[⬆️ Voltar ao Topo](#table-of-contents)**

## Design e UI

  * [AllTheFreeStock](https://allthefreestock.com) - uma lista curada de imagens, áudios e vídeos gratuitos.
  * [Float UI](https://floatui.com/) - ferramenta gratuita de desenvolvimento web para criar rapidamente sites modernos e responsivos com design elegante, mesmo para não designers.
  * [Ant Design Landing Page](https://landing.ant.design/) - Ant Design Landing Page fornece um template construído pelos componentes de movimento do Ant Motion. Possui um rico template de homepage, download do pacote de código do template e pode ser usado rapidamente. Você também pode usar o editor para construir rapidamente sua própria página dedicada.
  * [Backlight](https://backlight.dev/) — Com colaboração entre desenvolvedores e designers no centro, o Backlight é uma plataforma completa de codificação onde equipes constroem, documentam, publicam, escalam e mantêm Design Systems. O plano gratuito permite até 3 editores trabalhando em um design system com visualizadores ilimitados.
  * [BoxySVG](https://boxy-svg.com/app) — Um aplicativo Web gratuito instalável para desenhar SVGs e exportar em SVG, PNG, jpeg e outros formatos.
  * [Carousel Hero](https://carouselhero.com/) - Ferramenta online gratuita para criar carrosséis para redes sociais.
  * [Circum Icons](https://circumicons.com) - Ícones open-source consistentes como SVG para React, Vue e Svelte.
  * [clevebrush.com](https://www.cleverbrush.com/) — App gratuito para Design Gráfico / Colagem de Fotos. Também oferece integração paga como componente.
  * [cloudconvert.com](https://cloudconvert.com/) — Converta qualquer coisa em qualquer coisa. Duzentos e oito formatos suportados, incluindo vídeos e gifs.
  * [CodeMyUI](https://codemyui.com) - Coleção selecionada de inspiração em Web Design & UI com trechos de código.
  * [ColorKit](https://colorkit.co/) - Crie paletas de cores online ou obtenha inspiração das principais paletas.
  * [coolors](https://coolors.co/) - Gerador de paleta de cores. Gratuito.
  * [CMYK Pantone](https://www.cmyktopantone.com/) - Converta facilmente valores CMYK para as cores Pantone mais próximas e outros modelos de cor em segundos gratuitamente.
  * [Branition](https://branition.com/colors) - Paletas de cores selecionadas à mão, ideais para marcas.
  * [css-gradient.com](https://www.css-gradient.com/) - Ferramenta gratuita para gerar rapidamente gradientes CSS customizados compatíveis com vários navegadores. Em formato RGB e HEX.
  * [easyvectors.com](https://easyvectors.com/) — EasyVectors.com é um banco de vetores SVG gratuito. Baixe os melhores gráficos vetoriais totalmente grátis.
  * [figma.com](https://www.figma.com) — Ferramenta de design colaborativa online para equipes; o plano gratuito inclui arquivos e visualizadores ilimitados com máximo de 2 editores e três projetos.
  * [Flyon UI](https://flyonui.com/)- A biblioteca de componentes mais fácil para Tailwind CSS.
  * [framer.com](https://www.framer.com/) - O Framer ajuda você a iterar e animar ideias de interface para seu próximo app, site ou produto—começando por layouts poderosos. Para quem está validando o Framer como ferramenta profissional de prototipagem: visualizadores ilimitados, até 2 editores e até 3 projetos.
  * [freeforcommercialuse.net](https://freeforcommercialuse.net/) — FFCU fotos stock com liberação de modelo/propriedade sem preocupações.
  * [Gradientos](https://www.gradientos.app) - Torna a escolha de um gradiente rápida e fácil.
  * [Icon Horse](https://icon.horse) – Obtenha o favicon de maior resolução de qualquer site através de nossa simples API.
  * [Iconoir](https://iconoir.com) – Biblioteca open-source de ícones com milhares de ícones, suportando React, React Native, Flutter, Vue, Figma e Framer.
  * [Icons8](https://icons8.com) — Ícones, ilustrações, fotos, músicas e ferramentas de design. O plano gratuito oferece formatos limitados em baixa resolução. Inclua o link para o Icons8 ao usar nossos recursos.
  * [landen.co](https://www.landen.co) — Gere, edite e publique sites e landing pages bonitas para sua startup. Tudo sem código. O plano gratuito permite um site, totalmente personalizável e publicado na web.
  * [Quant Ux](https://quant-ux.com/) - Quant Ux é uma ferramenta de prototipagem e design. - É totalmente gratuita e também open source.
  * [lensdump.com](https://lensdump.com/) - Hospedagem gratuita de imagens na nuvem.
  * [Lorem Picsum](https://picsum.photos/) - Uma ferramenta gratuita, fácil de usar, placeholders estilosos. Após a URL, adicione o tamanho desejado da imagem (largura & altura), e você receberá uma imagem aleatória.
  * [LottieFiles](https://lottiefiles.com/) - A maior plataforma online do mundo para o formato de animação mais compacto para designers, desenvolvedores e mais. Acesse ferramentas e plugins Lottie para Android, iOS e Web.
  * [MagicPattern](https://www.magicpattern.design/tools) — Uma coleção de geradores e ferramentas de fundo CSS & SVG para gradientes, padrões e blobs.
  * [marvelapp.com](https://marvelapp.com/) — Design, prototipagem e colaboração; o plano gratuito é limitado a um usuário e projeto.
  * [Mindmup.com](https://www.mindmup.com/) — Mapas mentais ilimitados gratuitamente e armazenados na nuvem. Seus mapas mentais estão disponíveis em qualquer lugar, instantaneamente, de qualquer dispositivo.
  * [Mockplus iDoc](https://www.mockplus.com/idoc) - Mockplus iDoc é uma poderosa ferramenta de colaboração e entrega de design. O plano gratuito inclui três usuários e cinco projetos com todos os recursos disponíveis.
  * [mockupmark.com](https://mockupmark.com/create/free) — Crie mockups realistas de camisetas e roupas para redes sociais e E-commerce, 40 mockups gratuitos.
  * [Mossaik](https://mossaik.app) - Gerador gratuito de imagens SVG com diferentes ferramentas como ondas, blobs e padrões.
  * [movingpencils.com](https://movingpencils.com) — Editor vetorial rápido baseado em navegador. Totalmente gratuito.
  * [Octopus.do](https://octopus.do) — Construtor visual de mapas de sites. Construa a estrutura do seu site em tempo real e compartilhe rapidamente para colaborar com sua equipe ou clientes.
  * [Pencil](https://github.com/evolus/pencil) - Ferramenta de design open source usando Electron.
  * [Penpot](https://penpot.app) - Ferramenta web open-source para design e prototipagem. Suporta SVG. Totalmente gratuita.
  * [pexels.com](https://www.pexels.com/) - Fotos gratuitas para uso comercial. Possui uma API gratuita que permite pesquisar fotos por palavras-chave.
  * [photopea.com](https://www.photopea.com) — Editor de design online avançado e gratuito com interface semelhante ao Adobe Photoshop, suportando formatos PSD, XCF & Sketch (Adobe Photoshop, Gimp e Sketch App).
  * [pixlr.com](https://pixlr.com/) — Editor online gratuito no navegador, no nível de editores comerciais.
  * [Plasmic](https://www.plasmic.app/) - Ferramenta de design web e construtor de páginas rápido, fácil de usar e robusto, que pode ser integrado ao seu código. Crie páginas responsivas ou componentes complexos; opcionalmente, estenda com código; e publique para sites e apps em produção.
  * [Pravatar](https://pravatar.cc/) - Gere um avatar falso aleatório/placeholder cuja URL pode ser usada diretamente em seu site/app.
  * [Proto.io](https://www.proto.io) - Crie protótipos UI totalmente interativos sem codificar. O plano gratuito está disponível após o término do trial. Inclui um usuário, um projeto, cinco protótipos, 100MB de armazenamento online e visualização do app proto.io.
  * [resizeappicon.com](https://resizeappicon.com/) — Serviço simples para redimensionar e gerenciar ícones de aplicativos.
  * [Rive](https://rive.app) — Crie e publique belas animações para qualquer plataforma. Gratuito para sempre para indivíduos. O serviço é um editor que também hospeda todos os gráficos em seus servidores. Também fornecem runtimes para várias plataformas para rodar as representações criadas com o Rive.
  * [storyset.com](https://storyset.com/) — Crie incríveis ilustrações personalizadas gratuitas para seu projeto usando esta ferramenta.
  * [smartmockups.com](https://smartmockups.com/) — Crie mockups de produtos, 200 mockups gratuitos.
  * [Shadcn Studio](https://shadcnstudio.com/theme-editor) — Visualize suas alterações de tema em diferentes componentes e layouts.
  * [Tailark](https://tailark.com/) - Coleção de blocos UI modernos, responsivos e pré-construídos, projetados para sites de marketing.
  * [tabler-icons.io](https://tabler-icons.io/) — Mais de 1500 ícones SVG editáveis para copiar e colar gratuitamente.
  * [tweakcn](https://tweakcn.com/) — Temas bonitos para shadcn/ui. Personalize cores, tipografia e mais em tempo real.
  * [UI Avatars](https://ui-avatars.com/) - Gere avatares com iniciais de nomes. As URLs podem ser usadas diretamente em seu site/app. Suporte a parâmetros de configuração via URL.
  * [unDraw](https://undraw.co/) - Coleção constantemente atualizada de belas imagens SVG que você pode usar totalmente grátis sem atribuição.
  * [unsplash.com](https://unsplash.com/) - Fotos gratuitas para fins comerciais e não comerciais (licença "faça-o-que-quiser").
  * [vectr.com](https://vectr.com/) — Aplicativo de Design Gratuito para Web + Desktop.
  * [walkme.com](https://www.walkme.com/) — Plataforma de orientação e engajamento de classe empresarial, plano gratuito com três walkthroughs de até 5 passos cada.
  * [Webflow](https://webflow.com) - Construtor de sites WYSIWYG com animações e hospedagem. Gratuito para dois projetos.
  * [Updrafts.app](https://updrafts.app) - Construtor de sites WYSIWYG para designs baseados em tailwindcss. Gratuito para uso não comercial.
  * [whimsical.com](https://whimsical.com/) - Fluxogramas colaborativos, wireframes, sticky notes e mapas mentais. Crie até 4 quadros gratuitos.
  * [Zeplin](https://zeplin.io/) — Plataforma de colaboração entre designers e desenvolvedores. Mostre designs, assets e guias de estilo. Gratuito para um projeto.
  * [Pixelixe](https://pixelixe.com/) — Crie e edite gráficos e imagens envolventes e exclusivas online.
  * [Responsively App](https://responsively.app) - Ferramenta gratuita para desenvolvimento web responsivo mais rápido e preciso.
  * [SceneLab](https://scenelab.io) - Editor gráfico de mockups online com uma coleção sempre crescente de templates de design gratuitos.
  * [xLayers](https://xlayers.dev) - Visualize e converta arquivos de design Sketch em Angular, React, Vue, LitElement, Stencil, Xamarin e mais (gratuito e open source em https://github.com/xlayers/xlayers)
  * [Grapedrop](https://grapedrop.com/) — Construtor de páginas web responsivo, poderoso e otimizado para SEO, baseado no GrapesJS Framework. Gratuito para as cinco primeiras páginas, domínios personalizados ilimitados, todos os recursos e uso simples.
  * [Mastershot](https://mastershot.app) - Editor de vídeo baseado em navegador totalmente gratuito. Sem marca d'água, opções de exportação até 1080p.
  * [Unicorn Platform](https://unicornplatform.com/) - Construtor de landing pages com hospedagem sem esforço. Um site gratuitamente.
  * [SVGmix.com](https://www.svgmix.com/) - Repositório massivo com mais de 300 mil ícones SVG, coleções e logos de marcas gratuitos. Possui um programa simples de edição vetorial diretamente no navegador para edição rápida de arquivos.
  * [svgrepo.com](https://www.svgrepo.com/) - Explore, pesquise e encontre os melhores ícones ou vetores para seus projetos usando várias bibliotecas vetoriais. Baixe vetores SVG gratuitos para uso comercial.
  * [haikei.app](https://www.haikei.app/) - Haikei é um app web para gerar formas SVG, fundos e padrões únicos – pronto para uso com suas ferramentas e fluxo de trabalho de design.
  * [Canva](https://canva.com) - Ferramenta gratuita de design online para criar conteúdo visual.
  * [Superdesigner](https://superdesigner.co) - Coleção de ferramentas de design gratuitas para criar fundos, padrões, formas, imagens únicas e mais com apenas alguns cliques.
  * [TeleportHQ](https://teleporthq.io/) - Plataforma de Design & Desenvolvimento Front-end Low-code. TeleportHQ é a plataforma colaborativa para criar e publicar instantaneamente sites estáticos headless. Três projetos gratuitos, colaboradores ilimitados e exportação de código gratuita.
  * [vector.express](https://vector.express) — Converta seus vetores AI, CDR, DWG, DXF, EPS, HPGL, PDF, PLT, PS e SVG de forma rápida e fácil.
  * [Vertopal](https://www.vertopal.com) - Vertopal é uma plataforma online gratuita para conversão de arquivos em diversos formatos. Incluindo conversores para desenvolvedores como JPG para SVG, GIF para APNG, PNG para WEBP, JSON para XML, etc.
  * [okso.app](https://okso.app) - Aplicativo minimalista de desenho online. Permite criar esboços rápidos e notas visuais. Exporta esboços para PNG, JPG, SVG e WEBP. Também instalável como PWA. Livre para todos (não requer registro).
  * [Wdrfree SVG](https://wdrfree.com/free-svg) - Arquivos gratuitos de corte SVG em preto e branco.
  * [Lucide](https://lucide.dev) - Toolkit gratuito de ícones SVG customizáveis e consistentes.
  * [Logo.dev](https://www.logo.dev) - API de logos de empresas com mais de 44 milhões de marcas, tão fácil quanto chamar uma URL. Primeiros 10.000 chamados de API são gratuitos.
  * [MDBootstrap](https://mdbootstrap.com/) - Gratuito para uso pessoal & comercial Bootstrap, Angular, React e Vue UI Kits com mais de 700 componentes, templates incríveis, instalação em 1 minuto, tutoriais extensos & comunidade colossal.
  * [TW Elements](https://tw-elements.com/) - Componentes Bootstrap gratuitos recriados com Tailwind CSS, mas com melhor design e mais funcionalidades.
  * [DaisyUI](https://daisyui.com/) -- Gratuito. "Use Tailwind CSS mas escreva menos classes" oferece componentes como botões.
  * [Scrollbar.app](https://scrollbar.app) -- Aplicativo web gratuito e simples para criar barras de rolagem personalizadas para a web.
  * [css.glass](https://css.glass/) -- Aplicativo web gratuito para criar designs glassmórficos usando CSS.
  * [hypercolor.dev](https://hypercolor.dev/) -- Uma coleção selecionada de gradientes de cor Tailwind CSS e diversos geradores para criar os seus próprios.
  * [iconify.design](https://icon-sets.iconify.design/) -- Uma coleção de mais de 100 pacotes de ícones com uma interface unificada. Permite pesquisar ícones em diferentes pacotes e exportar ícones individuais como SVG ou para frameworks web populares.
  * [NextUI](https://nextui.org/) -- Gratuito. Biblioteca de UI para React & Next.js, bonita, rápida e moderna.
  * [Glyphs](https://glyphs.fyi/) -- Gratuito, Os Ícones Mais Poderosos da Web, sistema de design totalmente editável e verdadeiramente open source.
  * [ShadcnUI](https://ui.shadcn.com/) -- Componentes lindamente projetados para copiar e colar em seus aplicativos. Acessível. Personalizável. Código aberto.
  * [HyperUI](https://www.hyperui.dev/) -- Componentes Tailwind CSS gratuitos e de código aberto.
  * [Calendar Icons Generator](https://calendariconsgenerator.app/) -- Gere ícones únicos para um ano inteiro em apenas um clique, totalmente GRÁTIS.
  * [Image BG Blurer](https://imagebgblurer.com/) -- Gere uma moldura de fundo desfocada para uma imagem, usando a própria imagem como fundo desfocado, para Notion, Trello, Jira e outras ferramentas.
  * [Webstudio](https://webstudio.is/) -- Alternativa open-source ao Webflow. O plano gratuito oferece sites ilimitados no domínio deles. Cinco sites com domínios personalizados. Dez mil visualizações de página/mês. 2 GB de armazenamento de ativos.
  * [Nappy](https://nappy.co/) -- Fotos bonitas de pessoas negras e pardas, gratuitamente. Para uso comercial e pessoal.
  * [Tailkits](https://tailkits.com/) -- Uma coleção selecionada de templates, componentes e ferramentas Tailwind, além de geradores úteis para código, grids, sombras de caixas e mais.
  * [Tailcolors](https://tailcolors.com/) -- Uma bela paleta de cores Tailwind CSS v4. Visualize instantaneamente e copie a classe de cor Tailwind CSS perfeita.
  * [Excalidraw](https://excalidraw.com/) -- Página web gratuita para desenho online com suporte gratuito para salvar localmente e exportar.
  * [Lunacy](https://icons8.com/lunacy) -- Ferramenta gratuita de design gráfico com suporte offline, ativos integrados (ícones, fotos, ilustrações) e colaboração em tempo real. O plano gratuito inclui 10 documentos em nuvem, histórico de 30 dias, ativos em baixa resolução e ferramentas básicas de design.

**[⬆️ Voltar ao Topo](#table-of-contents)**

## Inspiração em Design

  * [awwwards.](https://www.awwwards.com/) - [Top sites] Uma vitrine dos melhores sites projetados (avaliados por designers).
  * [Behance](https://www.behance.net/) - [Vitrine de design] Um local onde designers expõem seus trabalhos. Filtrável por categorias de projetos UI/UX.
  * [dribbble](https://dribbble.com/) - [Vitrine de design] Inspiração de design única, geralmente não proveniente de aplicações reais.
  * [Landings](https://landings.dev/) - [Capturas de tela web] Encontre as melhores landing pages para sua inspiração de design de acordo com sua preferência.
  * [Lapa Ninja](https://www.lapa.ninja/) - [Landing page / UI Kits / Capturas de tela web] Lapa Ninja é uma galeria com os melhores 6025 exemplos de landing pages, livros gratuitos para designers e kits de UI gratuitos da web.
  * [LovelyLanding.net](https://www.lovelylanding.net/) - [Designs de Landing Page] Capturas de tela de landing pages atualizadas frequentemente. Inclui capturas de Desktop, Tablet e Mobile.
  * [Mobbin](https://mobbin.design/) - [Capturas de tela mobile] Economize horas de pesquisa UI & UX com nossa biblioteca de mais de 50.000 capturas de tela de aplicativos móveis totalmente pesquisáveis.
  * [Uiland Design](https://uiland.design/) - [Capturas de tela mobile] Explore designs de UI Mobile e Web de empresas líderes na África e no mundo.
  * [Mobile Patterns](https://www.mobile-patterns.com/) - [Capturas de tela mobile] Biblioteca inspiradora de design com os melhores padrões UI UX (iOS e Android) para referência de designers, desenvolvedores e criadores de produtos.
  * [Page Flows](https://pageflows.com/) - [Vídeos e capturas de tela mobile/web] Vídeos de fluxos completos de muitos aplicativos mobile e web. Também inclui capturas de tela. Altamente pesquisável e indexado.
  * [Screenlane](https://screenlane.com/) - [Capturas de tela mobile] Inspire-se e acompanhe as últimas tendências de design UI de aplicativos web & mobile. Filtrável por padrão e aplicativo.
  * [scrnshts](https://scrnshts.club/) - [Capturas de tela mobile] Coleção selecionada das melhores capturas de tela de design da app store.
  * [Refero](https://refero.design/) - [Capturas de tela web] Coleção de referências de design de grandes aplicativos web, com tags e pesquisa.

**[⬆️ Voltar ao Topo](#table-of-contents)**

## Visualização de Dados em Mapas

  * [IP Geolocation](https://ipgeolocation.io/) — Plano DEVELOPER gratuito com 30.000 requisições/mês.
  * [carto.com](https://carto.com/) — Crie mapas e APIs geoespaciais a partir dos seus dados e dados públicos.
  * [Clockwork Micro](https://clockworkmicro.com/) — Ferramentas de mapa que funcionam como um relógio. Cinquenta mil consultas mensais gratuitas (tiles de mapa, db2vector, elevação).
  * [developers.arcgis.com](https://developers.arcgis.com) — APIs e SDKs para mapas, armazenamento de dados geoespaciais, análise, geocodificação, roteamento e mais para web, desktop e mobile. Dois milhões de tiles de mapa base gratuitas, 20.000 geocodificações não armazenadas, 20.000 rotas simples, 5.000 cálculos de tempo de direção e 5GB de armazenamento gratuito de tile+dados por mês.
  * [Foursquare](https://developer.foursquare.com/) - Descoberta de localização, busca de locais e conteúdo contextual via Places API e Pilgrim SDK.
  * [geoapify.com](https://www.geoapify.com/) - Tiles de mapas vetoriais e raster, geocodificação, locais, roteamento, APIs de isolinhas. Três mil requisições gratuitas/dia.
  * [geocod.io](https://www.geocod.io/) — Geocodificação via API ou upload de CSV. Dois mil e quinhentos pedidos gratuitos/dia.
  * [geocodify.com](https://geocodify.com/) — Geocodificação e Geoparsing via API ou upload de CSV. 10 mil consultas gratuitas/mês.
  * [geojs.io](https://www.geojs.io/) - API REST/JSON/JSONP de pesquisa de geolocalização de IP altamente disponível.
  * [giscloud.com](https://www.giscloud.com/) — Visualize, analise e compartilhe dados geográficos online.
  * [graphhopper.com](https://www.graphhopper.com/) Pacote de desenvolvedor gratuito para Roteamento, Otimização de Rotas, Matriz de Distância, Geocodificação e Map Matching.
  * [here](https://developer.here.com/) — APIs e SDKs para mapas e aplicativos com reconhecimento de localização. 250 mil transações/mês gratuitas.
  * [locationiq.com](https://locationiq.com/) — APIs de Geocodificação, Mapas e Roteamento. Cinco mil pedidos/dia gratuitos.
  * [mapbox.com](https://www.mapbox.com/) — Mapas, serviços geoespaciais e SDKs para exibição de dados de mapas.
  * [maptiler.com](https://www.maptiler.com/cloud/) — Mapas vetoriais, serviços de mapas e SDKs para visualização de mapas. Tiles vetoriais gratuitos com atualizações semanais e quatro estilos de mapas.
  * [nominatim.org](https://nominatim.org/) — Serviço gratuito de geocodificação do OpenStreetMap, oferecendo busca global de endereços e geocodificação reversa.
  * [nextbillion.ai](https://nextbillion.ai/) - Serviços relacionados a mapas: Geocodificação, Navegação (Direção, Roteamento, Otimização de Rotas, Matriz de Distância), SDK de Mapas (Vetorial, Estático, SDK Mobile). [Gratuito com cota especificada](https://nextbillion.ai/pricing) para cada serviço.
  * [opencagedata.com](https://opencagedata.com) — API de geocodificação agregando OpenStreetMap e outras fontes geográficas abertas. Dois mil e quinhentos pedidos gratuitos/dia.
  * [osmnames](https://osmnames.org/) — Geocodificação, resultados de busca classificados pela popularidade da página relacionada na Wikipedia.
  * [positionstack](https://positionstack.com/) - Geocodificação gratuita para lugares e coordenadas globais. 25.000 requisições por mês para uso pessoal.
  * [stadiamaps.com](https://stadiamaps.com/) — Tiles de mapas, roteamento, navegação e outras APIs geoespaciais. Dois mil e quinhentos visualizações de mapas e pedidos de API/dia para uso não comercial e testes.
  * [maps.stamen.com](http://maps.stamen.com/) - Tiles de mapas gratuitos e hospedagem de tiles.
  * [ipstack](https://ipstack.com/) - Localize e identifique visitantes do site pelo endereço IP.
  * [Geokeo api](https://geokeo.com) - API de geocodificação com correção de idioma e mais. Cobertura mundial. 2.500 pedidos gratuitos diários.

**[⬆️ Voltar ao Topo](#table-of-contents)**

## Sistema de Build de Pacotes

  * [build.opensuse.org](https://build.opensuse.org/) — Serviço de build de pacotes para múltiplas distros (SUSE, EL, Fedora, Debian, etc.).
  * [copr.fedorainfracloud.org](https://copr.fedorainfracloud.org) — Serviço de build de RPM baseado em Mock para Fedora e EL.
  * [help.launchpad.net](https://help.launchpad.net/Packaging) — Serviço de build para Ubuntu e Debian.

**[⬆️ Voltar ao Topo](#table-of-contents)**

## IDE e Edição de Código

  * [3v4l](https://3v4l.org/) - Shell PHP online gratuito e site de compartilhamento de snippets, que executa seu código em mais de 300 versões do PHP.
  * [Android Studio](https://developer.android.com/studio) — O Android Studio oferece as ferramentas mais rápidas para criar aplicativos em qualquer tipo de dispositivo Android. IDE Open Source gratuita para todos e o melhor para desenvolvimento de apps Android. Disponível para Windows, Mac, Linux e até ChromeOS!
  * [AndroidIDE](https://m.androidide.com/) — IDE Open Source para desenvolver aplicativos Android reais, baseados em Gradle, diretamente em dispositivos Android.
  * [Apache Netbeans](https://netbeans.apache.org/) — Ambiente de desenvolvimento, plataforma de ferramentas e framework para aplicações.
  * [apiary.io](https://apiary.io/) — Design colaborativo de API com mock instantâneo e documentação gerada (Gratuito para blueprints de API ilimitados e usuários ilimitados com uma conta admin e documentação hospedada).
  * [BBEdit](https://www.barebones.com/) - BBEdit é um editor popular e extensível para macOS. O Modo Gratuito oferece um [conjunto central de funcionalidades poderoso](https://www.barebones.com/products/bbedit/comparison.html) e um caminho de upgrade para recursos avançados.
  * [Binder](https://mybinder.org/) - Transforme um repositório Git em uma coleção de notebooks interativos. Serviço público gratuito.
  * [BlueJ](https://bluej.org) — Ambiente de Desenvolvimento Java gratuito projetado para iniciantes, usado por milhões no mundo todo. Desenvolvido pela Oracle & GUI simples para ajudar iniciantes.
  * [Bootify.io](https://bootify.io/) - Gerador de apps Spring Boot com banco de dados personalizado e API REST.
  * [Brackets](http://brackets.io/) - Brackets é um editor de texto open-source especificamente projetado para desenvolvimento web. Leve, fácil de usar e altamente customizável.
  * [cacher.io](https://www.cacher.io) — Organizador de snippets de código com etiquetas e suporte para mais de 100 linguagens de programação.
  * [Code::Blocks](https://codeblocks.org) — IDE gratuita para Fortran & C/C++. Open Source, roda em Windows, macOS & Linux.
  * [Cody](https://sourcegraph.com/cody) - Assistente de codificação AI gratuito que pode escrever (blocos de código, autocompletar, testes unitários), entender (conhecimento de todo seu código), corrigir e encontrar seu código. Disponível para VS Code, JetBrains e Online.
  * [codiga.io](https://codiga.io/) — Assistente de codificação que permite pesquisar, definir e reutilizar snippets de código diretamente no seu IDE. Gratuito para indivíduos e pequenas organizações.
  * [codesnip.com.br](https://codesnip.com.br) — Gerenciador simples de snippets de código com categorias, busca e tags. gratuito e ilimitado.
  * [cocalc.com](https://cocalc.com/) — (anteriormente SageMathCloud em cloud.sagemath.com) — Cálculo colaborativo na nuvem. Acesso via navegador a um Ubuntu completo com colaboração embutida e muitos softwares livres para matemática, ciência, ciência de dados, pré-instalados: Python, LaTeX, Jupyter Notebooks, SageMath, scikitlearn, etc.
  * [code.cs50.io](https://code.cs50.io/) - Visual Studio Code para CS50 é um aplicativo web em code.cs50.io que adapta o GitHub Codespaces para alunos e professores.
  * [codepen.io](https://codepen.io/) — CodePen é um playground para o front-end da web.
  * [codesandbox.io](https://codesandbox.io/) — Playground online para React, Vue, Angular, Preact e mais.
  * [Components.studio](https://webcomponents.dev/) - Codifique componentes isoladamente, visualize-os em histórias, teste-os e publique no npm.
  * [Eclipse Che](https://www.eclipse.org/che/) - IDE web-based e Kubernetes-Native para equipes de desenvolvedores com suporte multilíngue. Open Source e orientado pela comunidade. Uma instância online hospedada pela Red Hat está disponível em [workspaces.openshift.com](https://workspaces.openshift.com/).
  * [fakejson.com](https://fakejson.com/) — O FakeJSON ajuda você a gerar rapidamente dados falsos usando sua API. Faça uma requisição API descrevendo o que você quer e como quer. A API retorna tudo em JSON. Acelere o go-to-market de ideias e finja até conseguir.
  * [GetVM](https://getvm.io) — Linux instantâneo e IDEs na barra lateral do Chrome. O plano gratuito inclui 5 VMs por dia.
  * [GitPod](https://www.gitpod.io) — Ambientes de desenvolvimento instantâneos e prontos para codificar para projetos no GitHub. O plano gratuito inclui 50 horas/mês.
  * [ide.goorm.io](https://ide.goorm.io) goormIDE é um IDE completo na nuvem. Suporte a múltiplas linguagens, container baseado em Linux via terminal web totalmente funcional, encaminhamento de portas, URL personalizada, colaboração em tempo real e chat, link de compartilhamento, suporte a Git/Subversion. Há muitos outros recursos (O plano gratuito inclui 1GB de RAM e 10GB de armazenamento por container, 5 slots de container).
  * [JDoodle](https://www.jdoodle.com) — Compilador e editor online para mais de 60 linguagens de programação com plano gratuito para compilação de código via API REST até 200 créditos por dia.
  * [jetbrains.com](https://jetbrains.com/products.html) — Ferramentas de produtividade, IDEs e ferramentas de deploy (como [IntelliJ IDEA](https://www.jetbrains.com/idea/), [PyCharm](https://www.jetbrains.com/pycharm/), etc). Licença gratuita para estudantes, professores, projetos Open Source e grupos de usuários.
  * [jsbin.com](https://jsbin.com) — JS Bin é outro playground e site de compartilhamento de código para web front-end (HTML, CSS e JavaScript. Também suporta Markdown, Jade e Sass).
  * [jsfiddle.net](https://jsfiddle.net/) — JS Fiddle é um playground e site de compartilhamento de código para web front-end, suportando colaboração.
  * [JSONPlaceholder](https://jsonplaceholder.typicode.com/) Alguns endpoints de API REST que retornam dados fictícios em formato JSON. O código-fonte também está disponível caso queira rodar o servidor localmente.
  * [Lazarus](https://www.lazarus-ide.org/) — Lazarus é um IDE multiplataforma compatível com Delphi para Desenvolvimento Rápido de Aplicações.
  * [MarsCode](https://www.marscode.com/) - Um IDE gratuito na nuvem com inteligência artificial.
  * [micro-jaymock](https://micro-jaymock.now.sh/) - Microserviço de mocking de APIs para gerar dados JSON fictícios.
  * [mockable.io](https://www.mockable.io/) — Mockable é um serviço simples e configurável para simular APIs RESTful ou serviços web SOAP. Este serviço online permite definir rapidamente endpoints de API REST ou SOAP e fazer com que retornem dados em JSON ou XML.
  * [mockaroo](https://mockaroo.com/) — O Mockaroo permite gerar dados de teste realistas em formatos CSV, JSON, SQL e Excel. Você também pode criar mocks para APIs de back-end.
  * [Mocklets](https://mocklets.com) - Simulador de API mock baseado em HTTP que ajuda a simular APIs para desenvolvimento paralelo mais rápido e testes mais abrangentes, com plano gratuito vitalício.
  * [Paiza](https://paiza.cloud/en/) — Desenvolva aplicativos web no navegador sem precisar configurar nada. O plano gratuito oferece um servidor com 24 horas de duração e 4 horas de uso por dia com 2 CPUs, 2 GB de RAM e 1 GB de armazenamento.
  * [Prepros](https://prepros.io/) - O Prepros pode compilar Sass, Less, Stylus, Pug/Jade, Haml, Slim, CoffeeScript e TypeScript nativamente, recarrega seus navegadores e facilita o desenvolvimento e teste de seus sites para você focar em deixá-los perfeitos. Você também pode adicionar suas próprias ferramentas com apenas alguns cliques.
  * [Replit](https://replit.com/) — Ambiente de codificação na nuvem para várias linguagens de programação.
  * [SoloLearn](https://code.sololearn.com) — Playground de programação na nuvem ideal para executar snippets de código. Suporta várias linguagens de programação. Não é necessário registro para rodar código, mas é necessário para salvar código na plataforma. Também oferece cursos gratuitos para iniciantes e programadores de nível intermediário.
  * [stackblitz.com](https://stackblitz.com/) — IDE online/na nuvem para criar, editar e implantar apps full-stack. Suporta qualquer framework popular baseado em NodeJs para front-end e back-end. Link curto para criar um novo projeto: [https://node.new](https://node.new).
  * [Sublime Text](https://www.sublimetext.com/) - Sublime Text é um editor de texto popular, versátil e altamente personalizável usado para programação e edição de texto.
  * [Visual Studio Code](https://code.visualstudio.com/) - Editor de código redefinido e otimizado para construir e depurar aplicações web e em nuvem modernas. Desenvolvido pela Microsoft.
  * [Visual Studio Community](https://visualstudio.microsoft.com/vs/community/) — IDE completo com milhares de extensões, desenvolvimento de apps multiplataforma (extensões Microsoft disponíveis para download para iOS e Android), desenvolvimento desktop, web e cloud, suporte a múltiplas linguagens (C#, C++, JavaScript, Python, PHP e mais).
  * [VSCodium](https://vscodium.com/) - Distribuição binária gratuita, dirigida pela comunidade, sem telemetria/rastreamento, do editor VSCode da Microsoft.
  * [wakatime.com](https://wakatime.com/) — Métricas quantitativas sobre sua atividade de codificação usando plugins para editores de texto, plano limitado gratuito.
  * [Wave Terminal](https://waveterm.dev/) - Wave é um terminal open-source e multiplataforma para fluxos de trabalho integrados. Renderize qualquer coisa inline. Salve sessões e histórico. Baseado em padrões web abertos. MacOS e Linux.
  * [WebComponents.dev](https://webcomponents.dev/) — IDE no navegador para codificar web components isoladamente com 58 templates disponíveis, suporte a stories e testes.
  * [PHPSandbox](https://phpsandbox.io/) — Ambiente de desenvolvimento online para PHP.
  * [WebDB](https://webdb.app) - IDE de banco de dados eficiente e gratuito. Inclui descoberta de servidor, ERD, gerador de dados, IA, gerenciador de estrutura NoSQL, versionamento de banco de dados e muito mais.
  * [Zed](https://zed.dev/) - Zed é um editor de código de alta performance e multiplayer, dos criadores do Atom e Tree-sitter.
  * [OneCompiler](https://onecompiler.com/) - Compilador online gratuito suportando mais de 70 linguagens, incluindo Java, Python, C++, JavaScript.


**[⬆️ Voltar ao Topo](#table-of-contents)**

## Analytics, Events and Statistics

  * [Dwh.dev](https://dwh.dev) - Solução de Observabilidade de Dados em Nuvem (Snowflake). Gratuito para uso pessoal.
  * [Hightouch](https://hightouch.com/) - Hightouch é uma plataforma Reverse ETL que ajuda a sincronizar dados de clientes do seu data warehouse para CRM, marketing e ferramentas de suporte. O plano gratuito oferece um destino para sincronizar os dados.
  * [Avo](https://avo.app/) — Fluxo de trabalho simplificado para lançamento de analytics. Plano de rastreamento fonte única da verdade, biblioteca de tracking type-safe, debuggers no app e observabilidade de dados para capturar problemas antes do lançamento. Gratuito para dois membros e 1 hora de lookback de observabilidade de dados.
  * [Branch](https://www.branch.io) — Plataforma de Analytics Mobile. O plano gratuito oferece até 10K usuários de app mobile com deep-linking e outros serviços.
  * [Census](https://www.getcensus.com/) — Plataforma de Reverse ETL & Analytics Operacional. Sincronize 10 campos do seu data warehouse para 60+ SaaS como Salesforce, Zendesk ou Amplitude.
  * [Clicky](https://clicky.com) — Plataforma de Analytics para websites. Plano gratuito para um site com análises de 3.000 visualizações.
  * [Databox](https://databox.com) — Insights & Analytics de Negócios combinando outras plataformas de analytics & BI. Plano gratuito oferece 3 usuários, dashboards & fontes de dados. 11M de registros históricos.
  * [Hitsteps.com](https://hitsteps.com/) — 2.000 pageviews por mês para 1 site
  * [amplitude.com](https://amplitude.com/) — 1 milhão de eventos mensais, até 2 apps
  * [GoatCounter](https://www.goatcounter.com/) — GoatCounter é uma plataforma open-source de analytics web disponível como serviço hospedado (gratuito para uso não comercial) ou app auto-hospedado. Busca oferecer analytics web fáceis de usar e com foco em privacidade como alternativa ao Google Analytics ou Matomo. O plano gratuito é para uso não comercial e inclui sites ilimitados, seis meses de retenção de dados e 100k pageviews/mês.
  * [Google Analytics](https://analytics.google.com/) — Google Analytics
  * [MetricsWave](https://metricswave.com) — Alternativa ao Google Analytics focada em privacidade para desenvolvedores. O plano gratuito permite 20 mil pageviews por mês sem cartão de crédito.
  * [Expensify](https://www.expensify.com/) — Relatórios de despesas, workflow gratuito para aprovação de relatórios pessoais
  * [getinsights.io](https://getinsights.io) - Analytics focado em privacidade, sem cookies, gratuito para até 3 mil eventos/mês.
  * [heap.io](https://heap.io) — Captura automaticamente todas as ações dos usuários em apps iOS ou web. Gratuito para até 10K sessões mensais.
  * [Hotjar](https://hotjar.com) — Analytics e relatórios para websites. O plano gratuito permite 2.000 pageviews/dia. Cem snapshots/dia (capacidade máxima: 300). Três heatmaps de snapshot podem ser armazenados por 365 dias. Membros de equipe ilimitados. Também oferece pesquisas in-app e independentes, widgets de feedback com capturas de tela. O plano gratuito permite criar 3 pesquisas e 3 widgets de feedback e coletar 20 respostas por mês.
  * [Keen](https://keen.io/) — Analytics customizado para coleta, análise e visualização de dados. 1.000 eventos/mês gratuitos
  * [Yandex.Datalens](https://datalens.yandex.com/) — Serviço de visualização e análise de dados na nuvem Yandex. O serviço é gratuito. Sem restrições de número de usuários e requisições.
  * [Yandex.Metrica](https://metrica.yandex.com/) — Analytics ilimitado gratuito
  * [Mixpanel](https://mixpanel.com/) — 100.000 usuários monitorados por mês, histórico de dados e assentos ilimitados, residência de dados nos EUA ou UE
  * [Moesif](https://www.moesif.com) — Analytics de API para REST e GraphQL. (Gratuito até 500.000 chamadas de API/mês)
  * [optimizely.com](https://www.optimizely.com) — Solução de Teste A/B, plano inicial gratuito, um site, 1 app iOS e 1 app Android
  * [Microsoft PowerBI](https://powerbi.com) — Insights & Analytics de Negócios da Microsoft. Plano gratuito oferece uso limitado com 1 milhão de licenças de usuário.
  * [Row Zero](https://rowzero.io) - Planilha conectada e super rápida. Conecte-se diretamente a bancos de dados, S3 e APIs. Importe, analise, grafique e compartilhe milhões de linhas instantaneamente. Três workbooks gratuitos (para sempre).
  * [sematext.com](https://sematext.com/cloud/) — Gratuito para até 50 mil ações/mês, retenção de dados de 1 dia, dashboards e usuários ilimitados, etc.
  * [Similar Web](https://similarweb.com) — Analytics para Web & Apps Mobile. Plano gratuito oferece cinco resultados por métrica, um mês de dados de app mobile e 3 meses de dados de site.
  * [StatCounter](https://statcounter.com/) — Analytics de visitantes do site. Plano gratuito para análise dos 500 visitantes mais recentes.
  * [Statsig](https://statsig.com) - Plataforma tudo-em-um que abrange analytics, feature flagging e testes A/B. Gratuito para até 1 milhão de eventos/mês.
  * [Tableau Developer Program](https://www.tableau.com/developer) — Inove, crie e faça o Tableau funcionar perfeitamente para sua organização. O programa gratuito para desenvolvedores fornece licença sandbox pessoal para Tableau Online. A versão é a pré-lançamento mais recente, então os Data Devs podem testar todos os recursos dessa excelente plataforma.
  * [usabilityhub.com](https://usabilityhub.com/) — Teste designs e mockups com pessoas reais e acompanhe visitantes. Gratuito para um usuário, testes ilimitados
  * [woopra.com](https://www.woopra.com/) — Plataforma gratuita de analytics para 500K ações, 90 dias de retenção de dados, mais de 30 integrações one-click.
  * [counter.dev](https://counter.dev) — Analytics web simples e, portanto, amigável à privacidade. Gratuito ou pague o quanto quiser por doação.
  * [PostHog](https://posthog.com) - Suite completa de Analytics de Produto gratuita para até 1 milhão de eventos monitorados por mês. Também fornece pesquisas in-app ilimitadas com 250 respostas/mês.
  * [Uptrace](https://uptrace.dev) - Ferramenta de Distributed Tracing que ajuda desenvolvedores a identificar falhas e gargalos de performance. Tem plano gratuito, oferece assinatura Pessoal gratuita para projetos open-source e possui versão open-source.
  * [Microsoft Clarity](https://clarity.microsoft.com/) - Clarity é uma ferramenta gratuita e fácil de usar que captura como pessoas reais usam seu site.
  * [Beampipe.io](https://beampipe.io) - Beampipe é analytics web simples e focado em privacidade. Gratuito para até 5 domínios e 10 mil pageviews mensais.
  * [Aptabase](https://aptabase.com) — Analytics open source, amigável à privacidade e simples para apps mobile e desktop. SDKs para Swift, Kotlin, React Native, Flutter, Electron e muitos outros. Gratuito para até 20.000 eventos por mês.
  * [Trackingplan](https://www.trackingplan.com/) - Detecte automaticamente problemas de analytics digital, dados de marketing e pixels, mantenha planos de tracking atualizados e promova colaboração contínua. Implemente em produção com tráfego real ou adicione cobertura de analytics aos testes de regressão sem escrever código.
  * [LogSpot](https://logspot.io) - Plataforma unificada de analytics web e de produto, incluindo widgets de analytics embutidos e robôs automatizados (slack, telegram e webhooks). Plano gratuito inclui 10.000 eventos por mês.
  * [Umami](https://umami.is/) - Alternativa simples, rápida, open-source e com foco em privacidade ao Google Analytics.
  * [TrackWith Dicloud](https://dicloud.net/trackwith-privacy-focused-analytics/) - Alternativa gratuita e leve ao Google Analytics, focada em privacidade. Pageviews ilimitados, visitantes ilimitados, heatmaps de página ilimitados e rastreamento de metas. Gratuito para até 3 domínios e 600 replays de sessão por domínio.
  * [AppFit](https://appfit.io) - AppFit é uma ferramenta de analytics e gestão de produto completa, projetada para gerenciamento multiplataforma de analytics e atualizações de produto. Plano gratuito inclui 10.000 eventos por mês, diário de produto e insights semanais.
  * [Seline](https://seline.so) - Seline é um analytics simples e privado para sites e produtos. Sem cookies, leve e independente. Plano gratuito inclui 3.000 eventos por mês e acesso a todos os recursos, como dashboard, jornadas de usuário, funis e mais.
  * [Peasy](https://peasy.so) - Peasy é uma ferramenta de analytics leve e focada em privacidade para sites e produtos. O plano gratuito inclui 3.000 eventos por mês.
  * [Rybbit](https://rybbit.io) - Alternativa open source, sem cookies, ao Google Analytics, 10x mais intuitiva. Plano gratuito com 3.000 eventos mensais. 

**[⬆️ Voltar ao Topo](#table-of-contents)**

## Gravação de Sessão de Visitantes

  * [Reactflow.com](https://www.reactflow.com/) — Por site: 1.000 pageviews/dia, três heatmaps, três widgets, bug tracking gratuito
  * [OpenReplay.com](https://www.openreplay.com) - Replay de sessão open-source com ferramentas de desenvolvimento para reprodução de bugs, sessão ao vivo para suporte em tempo real e suíte de analytics de produto. Mil sessões/mês com acesso a todos os recursos e retenção de 7 dias.
  * [LogRocket.com](https://www.logrocket.com) - 1.000 sessões/mês com 30 dias de retenção, rastreamento de erros, modo ao vivo
  * [FullStory.com](https://www.fullstory.com) — 1.000 sessões/mês com um mês de retenção de dados e três assentos de usuário. Mais informações [aqui](https://help.fullstory.com/hc/en-us/articles/360020623354-FullStory-Free-Edition).
  * [hotjar.com](https://www.hotjar.com/) — Por site: 1.050 pageviews/mês, heatmaps ilimitados, dados armazenados por três meses
  * [inspectlet.com](https://www.inspectlet.com/) — 2.500 sessões/mês gratuitas para um site
  * [Microsoft Clarity](https://clarity.microsoft.com/) - Gravação de sessão totalmente gratuita com "sem limites de tráfego", sem limites de projetos e sem amostragem
  * [mouseflow.com](https://mouseflow.com/) — 500 sessões/mês gratuitas para um site
  * [mousestats.com](https://www.mousestats.com/) — 100 sessões/mês gratuitas para um site
  * [smartlook.com](https://www.smartlook.com/) — pacotes gratuitos para web e apps mobile (1.500 sessões/mês), três heatmaps, um funil, 1 mês de histórico de dados
  * [howuku.com](https://howuku.com) — Acompanhe interação, engajamento e eventos dos usuários. Gratuito para até 5.000 visitas/mês
  * [UXtweak.com](https://www.uxtweak.com/) — Grave e assista como visitantes usam seu site ou app. Tempo ilimitado grátis para projetos pequenos

**[⬆️ Voltar ao Topo](#table-of-contents)**
## API e SDK de Verificação Internacional de Número Móvel

  * [numverify](https://numverify.com/) — Validação global de número de telefone e API JSON de consulta. 100 solicitações de API/mês
  * [veriphone](https://veriphone.io/) — Verificação global de números de telefone em uma API JSON gratuita, rápida e confiável. 1000 solicitações/mês

**[⬆️ Voltar ao Topo](#table-of-contents)**

## Integração de Pagamento e Faturamento

  * [Qonversion](http://qonversion.io/) - Plataforma tudo-em-um de gerenciamento de assinaturas multiplataforma oferecendo análises, testes A/B, Apple Search Ads, configurações remotas e ferramentas de crescimento para otimizar compras in-app e monetização. Compatível com iOS, Android, React Native, Flutter, Unity, Cordova, Stripe e web. Grátis até $10k em receita mensal rastreada.
  * [ParityVend](https://www.ambeteco.com/ParityVend/) – Ajusta automaticamente o preço com base na localização do visitante para expandir seu negócio globalmente e alcançar novos mercados (paridade do poder de compra). O plano gratuito inclui 7.500 solicitações de API/mês.
  * [Glassfy](https://glassfy.io/) – Infraestrutura de assinaturas in-app, eventos de assinatura em tempo real e ferramentas de monetização prontas para uso em iOS, Android, Stripe e Paddle. Grátis até $10k de receita mensal.
  * [Adapty.io](https://adapty.io/) – Solução tudo-em-um com SDK open-source para integração de assinaturas in-app mobile no iOS, Android, React Native, Flutter, Unity ou app web. Grátis até $10k de receita mensal.
  * [CoinMarketCap](https://coinmarketcap.com/api/) — Fornece dados de mercado de criptomoedas, incluindo as taxas de câmbio mais recentes de criptos e moedas fiduciárias. O plano gratuito oferece 10K créditos de chamadas/mês.
  * [CurrencyFreaks](https://currencyfreaks.com/) — Fornece taxas de câmbio de moedas atuais e históricas. Plano DEVELOPER gratuito disponível com 1000 solicitações/mês.
  * [CoinGecko](https://www.coingecko.com/en/api) — Fornece dados de mercado de criptomoedas, incluindo taxas de câmbio mais recentes e dados históricos. A API demo possui limite estável de 30 chamadas/minuto e um teto mensal de 10.000 chamadas.
  * [CurrencyApi](https://currencyapi.net/) — Taxas de câmbio ao vivo para moedas físicas e criptomoedas, entregues em JSON e XML. O plano gratuito oferece 1.250 solicitações de API/mês.
  * [currencylayer](https://currencylayer.com/) — Taxas de câmbio confiáveis e conversão de moedas para o seu negócio, 100 solicitações de API/mês grátis.
  * [exchangerate-api.com](https://www.exchangerate-api.com) - Uma API de conversão de moedas JSON fácil de usar. O plano gratuito atualiza uma vez ao dia com limite de 1.500 solicitações/mês.
  * [FraudLabsPRO](https://www.fraudlabspro.com) — Ajuda comerciantes a prevenir fraudes em pagamentos e estornos. Plano Micro gratuito disponível com 500 consultas/mês.
  * [FxRatesAPI](https://fxratesapi.com) — Fornece taxas de câmbio em tempo real e históricas. O plano gratuito requer atribuição.
  * [Moesif API Monetization](https://www.moesif.com/) - Gere receita com APIs via cobrança baseada em uso. Conecte ao Stripe, Chargebee, etc. O plano gratuito oferece 30.000 eventos/mês.
  * [Nami ML](https://www.namiml.com/) - Plataforma completa para compras e assinaturas in-app em iOS e Android, incluindo paywalls sem código, CRM e análises. Gratuito para todos os recursos base para operar um negócio de IAP.
  * [RevenueCat](https://www.revenuecat.com/) — Backend hospedado para compras e assinaturas in-app (iOS e Android). Grátis até $2.5k/mês em receita rastreada.
  * [vatlayer](https://vatlayer.com/) — Validação instantânea de número VAT e API de taxas VAT da UE, grátis 100 solicitações de API/mês
  * [Currencyapi](https://currencyapi.com) — API gratuita de conversão de moeda e dados de taxa de câmbio. Grátis 300 solicitações por mês, 10 solicitações por minuto para uso privado.

**[⬆️ Voltar ao Topo](#table-of-contents)**

## Relacionados ao Docker

  * [canister.io](https://canister.io/) — 20 repositórios privados gratuitos para desenvolvedores, 30 repositórios privados gratuitos para equipes para construir e armazenar imagens Docker
  * [Container Registry Service](https://container-registry.com/) - Solução de Gerenciamento de Container baseada em Harbor. O plano gratuito oferece 1 GB de armazenamento para repositórios privados.
  * [Docker Hub](https://hub.docker.com) — Um repositório privado gratuito e repositórios públicos ilimitados para construir e armazenar imagens Docker
  * [Play with Docker](https://labs.play-with-docker.com/) — Um playground simples, interativo e divertido para aprender Docker.
  * [quay.io](https://quay.io/) — Construa e armazene imagens de container com repositórios públicos gratuitos ilimitados
  * [ttl.sh](https://ttl.sh/) - Registro de imagens Docker anônimo e efêmero

**[⬆️ Voltar ao Topo](#table-of-contents)**

## Relacionados ao Vagrant

  * [Vagrant Cloud](https://app.vagrantup.com) - HashiCorp Vagrant Cloud. Hospedagem de boxes Vagrant.
  * [Vagrantbox.es](https://www.vagrantbox.es/) — Um índice público alternativo de boxes

**[⬆️ Voltar ao Topo](#table-of-contents)**

## Sites de Blog para Devs

  * [BearBlog](https://bearblog.dev/) - Blog minimalista e construtor de sites com suporte a Markdown.
  * [Dev.to](https://dev.to/) - Onde programadores compartilham ideias e ajudam uns aos outros a crescer.
  * [Hashnode](https://hashnode.com/) — Software de blog sem complicações para desenvolvedores!
  * [Medium](https://medium.com/) — Reflita mais profundamente sobre o que importa para você.
  * [AyeDot](https://ayedot.com/) — Compartilhe suas ideias, conhecimentos e histórias com o mundo gratuitamente em formato moderno de miniblogs multimídia.

**[⬆️ Voltar ao Topo](#table-of-contents)**

## Plataformas de Comentários
  * [GraphComment](https://graphcomment.com/) - GraphComment é uma plataforma de comentários que ajuda você a construir uma comunidade ativa a partir da audiência do site.
  * [Utterances](https://utteranc.es/) - Widget de comentários leve construído sobre issues do GitHub. Use issues do GitHub para comentários de blog, páginas wiki e mais!
  * [Disqus](https://disqus.com/) - Disqus é uma plataforma de comunidade em rede utilizada por centenas de milhares de sites na web.
  * [Remarkbox](https://www.remarkbox.com/) - Plataforma de comentários open source hospedada, pague o quanto quiser para "Um moderador em alguns domínios com controle total sobre comportamento e aparência"
  * [IntenseDebate](https://intensedebate.com/) - Sistema de comentários com muitos recursos para WordPress, Tumblr, Blogger e muitas outras plataformas de sites.

**[⬆️ Voltar ao Topo](#table-of-contents)**

## APIs de Captura de Tela

  * [ApiFlash](https://apiflash.com) — API de captura de tela baseada em AWS Lambda e Chrome. Lida com página inteira, captura de tempo e dimensões de viewport.
  * [microlink.io](https://microlink.io/) – Transforma qualquer site em dados como normalização de metatags, belos previews de links, capacidades de scraping ou capturas de tela como serviço. 250 solicitações/dia sempre gratuito.
  * [ScreenshotAPI.net](https://screenshotapi.net/) - API de captura de tela que usa uma chamada de API direta para gerar capturas de tela de qualquer site. Construído para escalar e hospedado no Google Cloud. Oferece 100 capturas de tela gratuitas por mês.
  * [screenshotlayer.com](https://screenshotlayer.com/) — Capture snapshots altamente customizáveis de qualquer site. Grátis 100 snapshots/mês
  * [screenshotmachine.com](https://www.screenshotmachine.com/) — Capture 100 snapshots/mês, png, gif e jpg, incluindo capturas completas, não apenas da página inicial
  * [PhantomJsCloud](https://PhantomJsCloud.com) — Automação de navegador e renderização de páginas. Plano Gratuito oferece até 500 páginas/dia. Plano Gratuito desde 2017.
  * [Webshrinker.com](https://webshrinker.com) — Web Shrinker fornece capturas de tela de sites e serviços de API de inteligência de domínio. Grátis 100 solicitações/mês.
  * [Screenshots](https://screenshotson.click) — Sua API para capturas de tela. Com opções altamente customizáveis de captura. Grátis 100 capturas de tela/mês.

**[⬆️ Voltar ao Topo](#table-of-contents)**

## Relacionado ao Flutter e Construção de Apps iOS sem Mac

  * [FlutLab](https://flutlab.io/) - FlutLab é um IDE online moderno para Flutter e o melhor lugar para criar, depurar e construir projetos multiplataforma. Construa apps iOS (sem Mac) e Android com Flutter.
  * [CodeMagic](https://codemagic.io/) - Codemagic é um CI/CD totalmente hospedado e gerenciado para apps mobile. Você pode construir, testar e implantar com uma ferramenta de CI/CD baseada em GUI. O plano gratuito oferece 500 minutos gratuitos/mês e uma instância Mac Mini com 2.3 GHz e 8 GB de RAM.
  * [FlutterFlow](https://flutterflow.io/) - FlutterFlow é uma interface baseada em navegador para construir apps mobile usando Flutter com drag-and-drop.

**[⬆️ Voltar ao Topo](#table-of-contents)**

## Emulação de hardware baseada em navegador escrita em Javascript

  * [JsLinux](https://bellard.org/jslinux) — uma máquina virtual x86 realmente rápida capaz de rodar Linux e Windows 2k.
  * [Jor1k](https://s-macke.github.io/jor1k/demos/main.html) — uma máquina virtual OpenRISC capaz de rodar Linux com suporte a rede.
  * [v86](https://copy.sh/v86) — uma máquina virtual x86 capaz de rodar Linux e outros sistemas operacionais diretamente no navegador.

**[⬆️ Voltar ao Topo](#table-of-contents)**

## Gerenciamento de Privacidade
  * [Bearer](https://www.bearer.sh/) - Ajuda a implementar privacidade por design via auditorias e fluxos contínuos para que organizações cumpram GDPR e outras regulamentações. O plano gratuito é limitado a equipes menores e apenas à versão SaaS.
  * [Osano](https://www.osano.com/) - Plataforma de gestão de consentimento e conformidade com tudo, de representação GDPR a banners de cookies. O plano gratuito oferece recursos básicos.
  * [Iubenda](https://www.iubenda.com/) - Políticas de privacidade, cookies e gestão de consentimento. O plano gratuito oferece política de privacidade e cookies limitadas, além de banners de cookies.
  * [Cookiefirst](https://cookiefirst.com/) - Banners de cookies, auditoria e solução de gestão de consentimento multilíngue. O plano gratuito oferece um escaneamento único e um banner.
* [Ketch](https://www.ketch.com/) - Ferramenta de gerenciamento de consentimento e estrutura de privacidade. O plano gratuito oferece a maioria dos recursos com uma contagem limitada de visitantes.
* [Concord](https://www.concord.tech/) - Plataforma completa de privacidade de dados, incluindo gerenciamento de consentimento, tratamento de solicitações de privacidade (DSARs) e mapeamento de dados. O plano gratuito inclui os principais recursos de gerenciamento de consentimento e também oferecem um plano mais avançado gratuitamente para projetos open source verificados.

**[⬆️ Voltar ao Topo](#table-of-contents)**

## Diversos

* [BackgroundStyler.com](https://backgroundstyler.com) - Crie capturas de tela estéticas do seu código, texto ou imagens para compartilhar nas redes sociais.
* [BinShare.net](https://binshare.net) - Crie e compartilhe códigos ou binários. Disponível para compartilhar como uma bela imagem, por exemplo, para postagens no Twitter/Facebook ou como um link, por exemplo, para chats ou fóruns.
* [Blynk](https://blynk.io) — SaaS com API para controlar, construir e avaliar dispositivos IoT. Plano Developer gratuito com 5 dispositivos, Cloud & armazenamento de dados gratuitos. Apps mobile também disponíveis.
* [Bricks Note Calculator](https://free.getbricks.app/) - um aplicativo de anotações (PWA) com uma poderosa calculadora multilinha embutida.
* [Carbon.now.sh](https://carbon.now.sh) - crie e compartilhe trechos de código em formato de imagem semelhante a captura de tela estética. Normalmente usado para compartilhar/exibir trechos de código de forma estética no Twitter ou em posts de blog.
* [Code Time](https://www.software.com/code-time) - extensão para rastreamento de tempo e métricas de codificação no VS Code, Atom, IntelliJ, Sublime Text e mais.
* [Codepng](https://www.codepng.app) - Crie capturas excelentes do seu código-fonte para compartilhar nas redes sociais.
* [CodeToImage](https://codetoimage.com/) - Crie capturas de tela de código ou texto para compartilhar nas redes sociais.
* [Cronhooks](https://cronhooks.io/) - Agende webhooks pontuais ou recorrentes. O plano gratuito permite 5 agendamentos ad-hoc.
* [cron-job.org](https://cron-job.org) - Serviço de cronjobs online. Tarefas ilimitadas gratuitamente.
* [datelist.io](https://datelist.io) - Sistema online de agendamento/reserva. Gratuito até 5 reservas por mês, inclui 1 calendário.
* [Domain Forward](https://domain-forward.com/) - Ferramenta simples para redirecionar qualquer URL ou Domínio. Gratuito até 5 domínios e 200 mil requisições por mês.
* [Elementor](https://elementor.com) — Construtor de sites para WordPress. Plano gratuito disponível com 40+ Widgets básicos.
* [Exif Editor](https://exifeditor.io/) — Visualize, edite, limpe e analise metadados de imagens/fotos instantaneamente no navegador - incluindo localização GPS e metadados.
* [Format Express](https://www.format-express.dev) - Formatação instantânea online para JSON / XML / SQL.
* [FOSSA](https://fossa.com/) - Gerenciamento escalável e completo para código de terceiros, conformidade de licenças e vulnerabilidades.
* [Hook Relay](https://www.hookrelay.dev/) - Adicione suporte a webhooks ao seu app sem complicações: fila pronta, retentativas com backoff e logs. O plano gratuito tem 100 entregas por dia, retenção de 14 dias e 3 endpoints de hook.
* [Hosting Checker](https://hostingchecker.co) - Verifique informações de hospedagem como ASN, ISP, localização e mais para qualquer domínio, site ou IP. Inclui diversas ferramentas relacionadas a hospedagem e DNS.
* [http2.pro](https://http2.pro) — Teste de prontidão para protocolo HTTP/2 e API de detecção de suporte HTTP/2 do cliente.
* [kandi](https://kandi.openweaver.com/) — Acelere o desenvolvimento de aplicações: construa funções personalizadas, use cases e aplicações completas mais rápido através de trechos de código e reutilização de bibliotecas open source.
* [Base64 decoder/encoder](https://devpal.co/base64-decode/) — Ferramenta online gratuita para decodificação & codificação de dados.
* [newreleases.io](https://newreleases.io/) - Receba notificações por e-mail, Slack, Telegram, Discord e webhooks personalizados sobre novos lançamentos do GitHub, GitLab, Bitbucket, Python PyPI, Java Maven, Node.js NPM, Node.js Yarn, Ruby Gems, PHP Packagist, .NET NuGet, Rust Cargo e Docker Hub.
* [OnlineExifViewer](https://onlineexifviewer.com/) — Visualize dados EXIF de fotos online instantaneamente, incluindo localização GPS e metadados.
* [PDFMonkey](https://www.pdfmonkey.io/) — Gerencie templates de PDF em um painel, chame a API com dados dinâmicos e baixe seu PDF. Oferece 300 documentos gratuitos por mês.
* [Pika Code Screenshots](https://pika.style/templates/code-image) — Crie capturas de tela bonitas e personalizáveis a partir de snippets de código e do VSCode usando a extensão.
* [QuickType.io](https://quicktype.io/) - Gere rapidamente modelos/classes/tipos/interfaces e serializadores a partir de JSON, schema e GraphQL para trabalhar com dados de forma rápida e segura em qualquer linguagem de programação. Converta JSON em código bonito e type-safe em qualquer linguagem.
* [RandomKeygen](https://randomkeygen.com/) - Ferramenta gratuita e mobile-friendly que oferece uma variedade de chaves e senhas geradas aleatoriamente para proteger qualquer aplicação, serviço ou dispositivo.
* [ray.so](https://ray.so/) - Crie imagens bonitas dos seus trechos de código.
* [readme.com](https://readme.com/) — Documentação bonita de forma fácil, gratuito para Open Source.
* [redirection.io](https://redirection.io/) — Ferramenta SaaS para gerenciamento de redirecionamentos HTTP para negócios, marketing e SEO.
* [redirect.ing](https://redirect.ing/) - Redirecionamento de domínio rápido e seguro sem gerenciar servidores ou certificados SSL. Plano gratuito inclui 10 domínios e 100.000 requisições por mês.
* [redirect.pizza](https://redirect.pizza/) - Gerencie redirecionamentos facilmente com suporte a HTTPS. O plano gratuito inclui 10 fontes e 100.000 acessos por mês.
* [ReqBin](https://reqbin.com/) — Faça requisições HTTP online. Métodos populares incluem GET, POST, PUT, DELETE e HEAD. Suporta Headers e autenticação por Token. Possui sistema básico de login para salvar suas requisições.
* [Smartcar API](https://smartcar.com) - API para carros: localize, obtenha nível do tanque de combustível, bateria, hodômetro, destrave/trave portas, etc.
* [snappify](https://snappify.com) - Permite que desenvolvedores criem visuais impressionantes. De belos snippets de código a apresentações técnicas completas. O plano gratuito permite até 3 snaps simultâneos com downloads ilimitados e 5 explicações de código com IA por mês.
* [Sunrise and Sunset](https://sunrisesunset.io/api/) - Obtenha horários do nascer e pôr do sol para uma determinada longitude e latitude.
* [superfeedr.com](https://superfeedr.com/) — Feeds em tempo real compatíveis com PubSubHubbub, exportação, análises. Gratuito com menos personalização.
* [SurveyMonkey.com](https://www.surveymonkey.com) — Crie pesquisas online. Analise os resultados online. O plano gratuito permite apenas 10 perguntas e 100 respostas por pesquisa.
* [Tiledesk](https://tiledesk.com) - Crie chatbots e aplicativos conversacionais. Traga-os para múltiplos canais: do seu site (widget de chat ao vivo) ao WhatsApp. Plano gratuito com chatbots ilimitados.
* [Versionfeeds](https://versionfeeds.com) — Feeds RSS personalizados para lançamentos do seu software favorito. Tenha as últimas versões de suas linguagens, bibliotecas ou ferramentas preferidas em um único feed. (Os 3 primeiros feeds são gratuitos)
* [videoinu](https://videoinu.com) — Crie e edite gravações de tela e outros vídeos online.
* [Webacus](https://webacus.dev) — Acesse uma ampla variedade de ferramentas gratuitas para desenvolvedores para codificação, decodificação e manipulação de dados.

**[⬆️ Voltar ao Topo](#table-of-contents)**

## Ferramentas de Desktop Remoto

* [Getscreen.me](https://getscreen.me) — Gratuito para 2 dispositivos, sem limites de número ou duração das sessões
* [Apache Guacamole™](https://guacamole.apache.org/) — Gateway de desktop remoto sem cliente, open source
* [RemSupp](https://remsupp.com) — Suporte sob demanda e acesso permanente a dispositivos (2 sessões/dia gratuitamente)
* [RustDesk](https://rustdesk.com/) - Infraestrutura de desktop remoto/virtual open source para todos!
* [AnyDesk](https://anydesk.com) — Gratuito para 3 dispositivos, sem limites de número ou duração das sessões

**[⬆️ Voltar ao Topo](#table-of-contents)**

## Desenvolvimento de Jogos

* [itch.io](https://itch.io/game-assets) — Assets gratuitos/pagos como sprites, tilesets e pacotes de personagens.
* [Gamefresco.com](https://gamefresco.com/) — Descubra, colete e compartilhe assets gratuitos de jogos de artistas do mundo todo.
* [GameDevMarket](https://gamedevmarket.net) — Assets gratuitos/pagos como 2D, 3D, Áudio, GUI.
* [OpenGameArt](https://opengameart.org) — Assets de jogos open source como músicas, sons, sprites e gifs.
* [CraftPix](https://craftpix.net) — Assets gratuitos/pagos como 2D, 3D, Áudio, GUI, fundos, ícones, tilesets, kits de jogos.
* [Game Icons](https://game-icons.net/) - Ícones SVG/PNG gratuitos e personalizáveis sob licença CC-BY.
* [LoSpec](https://lospec.com/) — Ferramentas online para criar pixel art e outras artes digitais restritivas, diversos tutoriais/listas de paletas disponíveis para seus jogos.
* [ArtStation](https://www.artstation.com/) - MarketPlace para assets 2D, 3D gratuitos/pagos & áudios, ícones, tilesets, kits de jogos. Também pode ser usado para expor seu portfólio de arte.
* [Rive](https://rive.app/community/) - Assets da comunidade e crie seus próprios assets de jogos usando o plano gratuito.
* [Poly Pizza](https://poly.pizza/) - Assets 3D low poly gratuitos
* [3Dassets.one](https://3dassets.one/) - Mais de 8.000 modelos 3D gratuitos/pagos e materiais PBR para criação de texturas.
* [Kenney](https://www.kenney.nl/assets/) - Assets de jogos 2D, 3D, áudio e UI gratuitos (licença CC0 1.0 Universal).
* [Poliigon](https://www.poliigon.com/) - Texturas gratuitas e pagas (com resolução variável), modelos, HDRIs e brushes. Oferece plugins gratuitos para exportar para softwares como Blender.
* [Freesound](https://freesound.org/) - Biblioteca colaborativa de sons gratuitos sob diferentes licenças CC.

**[⬆️ Voltar ao Topo](#table-of-contents)**

## Outros Recursos Gratuitos

* [Wikimint Developer](https://developer.wikimint.com/p/tools.html) - Ferramentas sempre gratuitas para desenvolvedores web, incluindo minificação/desminificação de CSS, otimizador de imagens, redimensionador de imagens, conversor de maiúsculas/minúsculas, validador de CSS, compilador de JavaScript, editor HTML, etc.
* [ElevateAI](https://www.elevateai.com) - Ganhe até 200 horas de transcrição de áudio gratuita todo mês.
* [get.localhost.direct](https://get.localhost.direct) — Um certificado SSL Wildcard público assinado por CA para desenvolvimento localhost com suporte a subdomínios.
* [Framacloud](https://degooglisons-internet.org/en/) — Lista de Software Livre/Open Source e SaaS gratuitos da ONG francesa [Framasoft](https://framasoft.org/en/).
* [github.com — FOSS for Dev](https://github.com/tvvocold/FOSS-for-Dev) — Central de software gratuito e open source para desenvolvedores.
* [GitHub Education](https://education.github.com/pack) — Coleção de serviços gratuitos para estudantes. Necessário cadastro.
* [Markdown Tools](https://markdowntools.com) - Ferramentas para converter HTML, CSVs, PDFs, JSON e arquivos Excel para e de Markdown
* [Microsoft 365 Developer Program](https://developer.microsoft.com/microsoft-365/dev-program) — Obtenha um sandbox gratuito, ferramentas e outros recursos para desenvolver soluções para a plataforma Microsoft 365. A assinatura é uma [Assinatura Microsoft 365 E5 de 90 dias](https://www.microsoft.com/microsoft-365/enterprise/e5) (Windows excluído) que é renovável. Ela é renovada se você estiver ativo no desenvolvimento (medido por telemetria & algoritmos).
* [Pyrexp](https://pythonium.net/regex) — Testador e visualizador de regex baseado na web e gratuito para depuração de expressões regulares.
* [RedHat for Developers](https://developers.redhat.com) — Acesso gratuito a produtos Red Hat incluindo RHEL, OpenShift, CodeReady, etc. exclusivamente para desenvolvedores. Apenas plano individual. E-books gratuitos também são oferecidos para referência.
* [smsreceivefree.com](https://smsreceivefree.com/) — Fornece números de telefone temporários e descartáveis gratuitos.
* [sandbox.httpsms.com](https://sandbox.httpsms.com) — Envie e receba mensagens SMS de teste gratuitamente.
* [SimpleBackups.com](https://simplebackups.com/) — Serviço de automação de backup para servidores e bancos de dados (MySQL, PostgreSQL, MongoDB) diretamente em provedores de cloud storage (AWS, DigitalOcean e Backblaze). Oferece plano gratuito para 1 backup.
* [SnapShooter](https://snapshooter.com/) — Solução de backup para DigitalOcean, AWS, LightSail, Hetzner e Exoscale, com suporte para backups diretos de banco de dados, sistema de arquivos e aplicativos para armazenamento baseado em s3. Oferece plano gratuito com backups diários para um recurso.
* [Themeselection](https://themeselection.com/) — Templates selecionados de painéis de administração gratuitos, design moderno, profissional e fácil de usar, temas HTML e UI Kits para criar suas aplicações mais rápido!
* [Web.Dev](https://web.dev/measure/) — Ferramenta gratuita para ver a performance do seu site e melhorar o SEO para conseguir melhor posicionamento nos mecanismos de busca.
  * [SmallDev.tools](https://smalldev.tools/) — Uma ferramenta gratuita para desenvolvedores que permite codificar/decodificar vários formatos, minificar HTML/CSS/Javascript, embelezar, gerar conjuntos de dados falsos/de teste em JSON/CSV e múltiplos outros formatos, além de muitos outros recursos. Com uma interface agradável.
  * [UseCSV by Layercode](https://layercode.com/usecsv) — Adicione importação de CSV e Excel ao seu aplicativo web em minutos. Ofereça aos seus usuários uma experiência de importação de dados agradável e robusta. Comece gratuitamente sem precisar de cartão de crédito e comece a integrar UseCSV hoje mesmo. Você pode criar importadores ilimitados e fazer upload de arquivos de até 100Mb.
  * [Buttons Generator](https://markodenic.com/tools/buttons-generator/) — Mais de 100 botões que você pode usar em seu projeto.
  * [WrapPixel](https://www.wrappixel.com/) — Baixe templates de dashboard de administração de alta qualidade, gratuitos e premium, criados com Angular, React, VueJs, NextJS e NuxtJS!
  * [Utils.fun](https://utils.fun/en) — Todas as ferramentas diárias e de desenvolvimento offline baseadas na capacidade de computação do navegador, incluindo geração de marca d'água, gravação de tela, codificação e decodificação, criptografia e descriptografia, e formatação de código, são totalmente gratuitas e não enviam nenhum dado para a nuvem para processamento.
  * [It tools](it-tools.tech) - Ferramentas úteis para desenvolvedores e pessoas que trabalham com TI.
  * [Free Code Tools](https://freecodetools.org/) — Ferramentas de código eficazes 100% gratuitas. Editor Markdown, minificador/embelezador de código, gerador de QR code, gerador de Open Graph, gerador de cartão do Twitter e mais.
  * [regex101](https://regex101.com/) — Gratuito, este site permite que você teste e depure expressões regulares (regex). Ele fornece um editor e testador de regex, além de documentação útil e recursos para aprender regex.
  * [Kody Tools](https://www.kodytools.com/dev-tools) — Mais de 100 ferramentas para desenvolvimento, incluindo formatador, minificador e conversor.
  * [AdminMart](https://adminmart.com/) — Templates de dashboard de administração e de sites de alta qualidade, gratuitos e premium, criados com Angular, Bootstrap, React, VueJs, NextJS e NuxtJS!
  * [Glob tester](https://globster.xyz/) — Um site que permite criar e testar padrões glob. Também oferece recursos para aprender padrões glob.
  * [SimpleRestore](https://simplerestore.io) - Restauração de backup MySQL sem complicações. Restaure backups MySQL em qualquer banco de dados remoto sem código ou servidor.
  * [360Converter](https://www.360converter.com/) - Camada gratuita útil para converter: Vídeo para Texto && Áudio para Texto && Fala para Texto && Áudio em Tempo Real para Texto && Vídeo do YouTube para Texto && adicionar Legenda em Vídeo. Pode ser útil para conversão de vídeos curtos ou em tutoriais curtos do YouTube :)
  * [QRCodeBest](https://qrcode.best/) - Crie QR codes personalizados com 13 modelos, privacidade total e branding pessoal. Recursos de pixels de rastreamento, categorização de projetos e assentos ilimitados para equipe no QRCode.Best.
  * [PostPulse](https://PostPulseAI.com) - Potencialize sua presença online, melhore seu SEO e ranking do site com posts mensais criados por IA para domínios otimizados para SEO. O plano gratuito permite publicar manualmente um post em nosso site a cada mês.
  * [PageTools](https://pagetools.co/) - Oferece uma suíte de ferramentas para sempre gratuitas, alimentadas por IA, para ajudar você a gerar políticas essenciais de sites, criar bios para redes sociais, posts e páginas web com uma interface de um clique.
  * [MySQL Visual Explain](https://mysqlexplain.com) - Visualizador gratuito e fácil de entender da saída do MySQL EXPLAIN para otimizar queries lentas.
  * [Killer Coda](https://killercoda.com/)  - Playground interativo no seu navegador para estudar Linux, Kubernetes, Containers, Programação, DevOps, Redes.
  * [Axonomy App](https://axonomy-app.com/) - Ferramenta gratuita para criar, gerenciar e compartilhar suas faturas com seus clientes. 10 faturas gratuitas por mês.
  * [Table Format Converter](https://www.tableformatconverter.com) - Ferramenta gratuita para converter dados de tabela para diferentes formatos, como CSV, HTML, JSON, Markdown e outros.


**[⬆️ Voltar ao Topo](#table-of-contents)**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---
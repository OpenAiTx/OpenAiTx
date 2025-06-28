# Awesome MCP Servers [![Awesome](https://awesome.re/badge.svg)](https://awesome.re)

[![ไทย](https://img.shields.io/badge/Thai-Click-blue)](README-th.md)
[![English](https://img.shields.io/badge/English-Click-yellow)](README.md)
[![繁體中文](https://img.shields.io/badge/繁體中文-點擊查看-orange)](README-zh_TW.md)
[![简体中文](https://img.shields.io/badge/简体中文-点击查看-orange)](README-zh.md)
[![日本語](https://img.shields.io/badge/日本語-クリック-青)](README-ja.md)
[![한국어](https://img.shields.io/badge/한국어-클릭-yellow)](README-ko.md)
[![Português Brasileiro](https://img.shields.io/badge/Português_Brasileiro-Clique-green)](README-pt_BR.md)
[![Discord](https://img.shields.io/discord/1312302100125843476?logo=discord&label=discord)](https://glama.ai/mcp/discord)
[![Subreddit subscribers](https://img.shields.io/reddit/subreddit-subscribers/mcp?style=flat&logo=reddit&label=subreddit)](https://www.reddit.com/r/mcp/)

Una lista curata dei migliori server Model Context Protocol (MCP).

* [Cos'è MCP?](#cos-e-mcp)
* [Client](#client)
* [Tutorial](#tutorial)
* [Comunità](#comunita)
* [Legenda](#legenda)
* [Implementazioni Server](#implementazioni-server)
* [Framework](#framework)
* [Suggerimenti e Trucchi](#suggerimenti-e-trucchi)

## Cos'è MCP?

[MCP](https://modelcontextprotocol.io/) è un protocollo aperto che consente ai modelli AI di interagire in modo sicuro con risorse locali e remote tramite implementazioni server standardizzate. Questa lista si concentra su server MCP pronti per la produzione ed anche sperimentali, che estendono le capacità dell’AI tramite accesso a file, connessioni a database, integrazioni API e altri servizi contestuali.

## Client

Consulta [awesome-mcp-clients](https://github.com/punkpeye/awesome-mcp-clients/) e [glama.ai/mcp/clients](https://glama.ai/mcp/clients).

> [!TIP]
> [Glama Chat](https://glama.ai/chat) è un client AI multimodale con supporto MCP e [AI gateway](https://glama.ai/gateway).

## Tutorial

* [Model Context Protocol (MCP) Quickstart](https://glama.ai/blog/2024-11-25-model-context-protocol-quickstart)
* [Configurare Claude Desktop App per usare un database SQLite](https://youtu.be/wxCCzo9dGj0)

## Comunità

* [r/mcp Reddit](https://www.reddit.com/r/mcp)
* [Server Discord](https://glama.ai/mcp/discord)

## Legenda

* 🎖️ – implementazione ufficiale
* linguaggio di programmazione
  * 🐍 – codice Python
  * 📇 – codice TypeScript (o JavaScript)
  * 🏎️ – codice Go
  * 🦀 – codice Rust
  * #️⃣ - codice C#
  * ☕ - codice Java
  * 🌊 – codice C/C++
* ambito
  * ☁️ - Servizio Cloud
  * 🏠 - Servizio Locale
  * 📟 - Sistemi Embedded
* sistema operativo
  * 🍎 – Per macOS
  * 🪟 – Per Windows
  * 🐧 - Per Linux

> [!NOTE]
> Confuso tra Locale 🏠 e Cloud ☁️?
> * Usa locale quando il server MCP interagisce con un software installato localmente, ad esempio per controllare il browser Chrome.
> * Usa network quando il server MCP interagisce con API remote, ad esempio API meteo.

## Implementazioni Server

> [!NOTE]
> Ora abbiamo una [directory web](https://glama.ai/mcp/servers) sincronizzata con il repository.

* 🔗 - [Aggregatori](#aggregatori)
* 🎨 - [Arte & Cultura](#arte-e-cultura)
* 📂 - [Automazione Browser](#automazione-browser)
* ☁️ - [Piattaforme Cloud](#piattaforme-cloud)
* 👨‍💻 - [Esecuzione Codice](#esecuzione-codice)
* 🤖 - [Agenti di Codifica](#agenti-di-codifica)
* 🖥️ - [Command Line](#command-line)
* 💬 - [Comunicazione](#comunicazione)
* 👤 - [Customer Data Platforms](#customer-data-platforms)
* 🗄️ - [Database](#database)
* 📊 - [Piattaforme Dati](#piattaforme-dati)
* 🚚 - [Consegne](#consegne)
* 🛠️ - [Strumenti per Sviluppatori](#strumenti-per-sviluppatori)
* 🧮 - [Strumenti Data Science](#strumenti-data-science)
* 📟 - [Sistemi Embedded](#sistemi-embedded)
* 📂 - [File System](#file-system)
* 💰 - [Finanza & Fintech](#finanza-e-fintech)
* 🎮 - [Gaming](#gaming)
* 🧠 - [Conoscenza & Memoria](#conoscenza-e-memoria)
* 🗺️ - [Servizi di Localizzazione](#servizi-di-localizzazione)
* 🎯 - [Marketing](#marketing)
* 📊 - [Monitoraggio](#monitoraggio)
* 🎥 - [Processi Multimediali](#processi-multimediali)
* 🔎 - [Ricerca & Estrazione Dati](#ricerca)
* 🔒 - [Sicurezza](#sicurezza)
* 🌐 - [Social Media](#social-media)
* 🏃 - [Sport](#sports)
* 🎧 - [Supporto e Gestione dei Servizi](#support-and-service-management)
* 🌎 - [Servizi di Traduzione](#translation-services)
* 🎧 - [Sintesi Vocale](#text-to-speech)
* 🚆 - [Viaggi & Trasporti](#travel-and-transportation)
* 🔄 - [Controllo Versione](#version-control)
* 🛠️ - [Altri Strumenti e Integrazioni](#other-tools-and-integrations)


### 🔗 <a name="aggregators"></a>Aggregatori

Server per accedere a molte app e strumenti tramite un singolo server MCP.

- [julien040/anyquery](https://github.com/julien040/anyquery) 🏎️ 🏠 ☁️ - Interroga più di 40 app con un unico eseguibile usando SQL. Può anche connettersi al tuo database compatibile PostgreSQL, MySQL o SQLite. Local-first e privato per progettazione.
- [metatool-ai/metatool-app](https://github.com/metatool-ai/metatool-app) 📇 ☁️ 🏠 🍎 🪟 🐧 - MetaMCP è il middleware MCP server unificato che gestisce le tue connessioni MCP con interfaccia grafica (GUI).
- [mindsdb/mindsdb](https://github.com/mindsdb/mindsdb) - Collega e unifica dati su varie piattaforme e database con [MindsDB come server MCP unico](https://docs.mindsdb.com/mcp/overview).
- [glenngillen/mcpmcp-server](https://github.com/glenngillen/mcpmcp-server) ☁️ 📇 🍎 🪟 🐧 - Un elenco di server MCP così puoi chiedere al tuo client quali server puoi usare per migliorare il tuo flusso di lavoro quotidiano.
- [wegotdocs/open-mcp](https://github.com/wegotdocs/open-mcp) 📇 🏠 🍎 🪟 🐧 - Trasforma un'API web in un server MCP in 10 secondi e aggiungilo al registro open source: https://open-mcp.org
- [PipedreamHQ/pipedream](https://github.com/PipedreamHQ/pipedream/tree/master/modelcontextprotocol) ☁️ 🏠 - Connettiti con 2.500 API con oltre 8.000 strumenti predefiniti e gestisci server per i tuoi utenti, nella tua stessa app.
- [VeriTeknik/pluggedin-mcp-proxy](https://github.com/VeriTeknik/pluggedin-mcp-proxy)  📇 🏠 - Un server proxy completo che combina più server MCP in un'unica interfaccia con funzionalità di visibilità avanzate. Fornisce scoperta e gestione di strumenti, prompt, risorse e template tra server, oltre a un playground per il debug durante la costruzione di server MCP.
- [tigranbs/mcgravity](https://github.com/tigranbs/mcgravity) 📇 🏠 - Uno strumento proxy per comporre più server MCP in un unico endpoint unificato. Scala i tuoi strumenti AI bilanciando il carico delle richieste tra più server MCP, simile a Nginx per i web server.
- [MetaMCP](https://github.com/metatool-ai/metatool-app) 📇 ☁️ 🏠 🍎 🪟 🐧 - MetaMCP è il middleware MCP server unificato che gestisce le tue connessioni MCP con GUI.
- [WayStation-ai/mcp](https://github.com/waystation-ai/mcp) ☁️ 🍎 🪟 - Collega in modo sicuro e fluido Claude Desktop e altri host MCP alle tue app preferite (Notion, Slack, Monday, Airtable, ecc.). Meno di 90 secondi.
- [sxhxliang/mcp-access-point](https://github.com/sxhxliang/mcp-access-point) 📇 ☁️ 🏠 🍎 🪟 🐧 - Trasforma un servizio web in un server MCP con un solo clic senza modificare il codice.
- [hamflx/imagen3-mcp](https://github.com/hamflx/imagen3-mcp) 📇 🏠 🪟 🍎 🐧 - Potente strumento di generazione immagini usando l'API Imagen 3.0 di Google tramite MCP. Genera immagini di alta qualità da prompt testuali con controlli avanzati fotografici, artistici e fotorealistici.
- [SureScaleAI/openai-gpt-image-mcp](https://github.com/SureScaleAI/openai-gpt-image-mcp) 📇 ☁️ - Server MCP per generazione/modifica immagini con OpenAI GPT.

### 🎨 <a name="art-and-culture"></a>Arte & Cultura

Accedi ed esplora collezioni d’arte, patrimonio culturale e database museali. Permette ai modelli AI di cercare e analizzare contenuti artistici e culturali.

- [abhiemj/manim-mcp-server](https://github.com/abhiemj/manim-mcp-server) 🐍 🏠 🪟 🐧 - Un server MCP locale che genera animazioni usando Manim.
- [burningion/video-editing-mcp](https://github.com/burningion/video-editing-mcp) 🐍 - Aggiungi, Analizza, Cerca e Genera modifiche video dalla tua Video Jungle Collection
- [cswkim/discogs-mcp-server](https://github.com/cswkim/discogs-mcp-server) 📇 ☁️ - Server MCP per interagire con l’API Discogs
- [djalal/quran-mcp-server](https://github.com/djalal/quran-mcp-server) 📇 ☁️ Server MCP per interagire con il corpus Quran.com tramite l’API REST ufficiale v4.
- [mikechao/metmuseum-mcp](https://github.com/mikechao/metmuseum-mcp) 📇 ☁️ - Integrazione API Metropolitan Museum of Art per cercare e visualizzare opere nella collezione.
- [r-huijts/rijksmuseum-mcp](https://github.com/r-huijts/rijksmuseum-mcp) 📇 ☁️ - Integrazione API Rijksmuseum per ricerca opere, dettagli e collezioni.
- [r-huijts/oorlogsbronnen-mcp](https://github.com/r-huijts/oorlogsbronnen-mcp) 📇 ☁️ - Integrazione API Oorlogsbronnen (Fonti di Guerra) per accedere a documenti storici, fotografie e archivi della Seconda Guerra Mondiale nei Paesi Bassi (1940-1945)
- [samuelgursky/davinci-resolve-mcp](https://github.com/samuelgursky/davinci-resolve-mcp) 🐍 - Integrazione server MCP per DaVinci Resolve che offre potenti strumenti di editing video, color grading, gestione media e controllo progetti
- [yuna0x0/anilist-mcp](https://github.com/yuna0x0/anilist-mcp) 📇 ☁️ - Server MCP che integra l’API AniList per informazioni su anime e manga
- [diivi/aseprite-mcp](https://github.com/diivi/aseprite-mcp) 🐍 🏠 - Server MCP che usa l’API di Aseprite per creare pixel art
- [omni-mcp/isaac-sim-mcp](https://github.com/omni-mcp/isaac-sim-mcp) 📇 ☁️ - Un server MCP e un’estensione che abilita il controllo in linguaggio naturale di NVIDIA Isaac Sim, Lab, OpenUSD, ecc.
- [8enSmith/mcp-open-library](https://github.com/8enSmith/mcp-open-library) 📇 ☁️ - Server MCP per l’API Open Library che consente agli assistenti AI di cercare informazioni sui libri. 
- [PatrickPalmer/MayaMCP](https://github.com/PatrickPalmer/MayaMCP) 🐍 🏠 - Server MCP per Autodesk Maya
- [cantian-ai/bazi-mcp](https://github.com/cantian-ai/bazi-mcp) 📇 🏠 ☁️ 🍎 🪟 - Fornisce calcolo e analisi completa e accurata dei Bazi (Astrologia Cinese)


### 📂 <a name="browser-automation"></a>Automazione Browser

Accesso e automazione dei contenuti web. Permette ricerca, scraping e processamento di contenuti web in formati compatibili con l’AI.

- [xspadex/bilibili-mcp](https://github.com/xspadex/bilibili-mcp.git) 📇 🏠 - Strumento basato su FastMCP che recupera i video di tendenza di Bilibili e li espone tramite interfaccia MCP standard.
- [34892002/bilibili-mcp-js](https://github.com/34892002/bilibili-mcp-js) 📇 🏠 - Server MCP che supporta la ricerca di contenuti Bilibili. Offre esempi di integrazione LangChain e script di test.
- [aircodelabs/grasp](https://github.com/aircodelabs/grasp) 📇 🏠 - Browser self-hosted con agente integrato MCP e supporto A2A.
- [automatalabs/mcp-server-playwright](https://github.com/Automata-Labs-team/MCP-Server-Playwright) 🐍 - Server MCP per automazione browser con Playwright
- [blackwhite084/playwright-plus-python-mcp](https://github.com/blackwhite084/playwright-plus-python-mcp) 🐍 - Server MCP python con Playwright per automazione browser, più adatto a LLM
- [browserbase/mcp-server-browserbase](https://github.com/browserbase/mcp-server-browserbase) 🎖️ 📇 - Automatizza interazioni browser in cloud (es. navigazione web, estrazione dati, compilazione form, ecc.)
- [browsermcp/mcp](https://github.com/browsermcp/mcp) 📇 🏠 - Automatizza il tuo browser Chrome locale
- [co-browser/browser-use-mcp-server](https://github.com/co-browser/browser-use-mcp-server) 🐍 - browser-use pacchettizzato come server MCP con trasporto SSE. Include un dockerfile per eseguire chromium in docker + un server vnc.
- [executeautomation/playwright-mcp-server](https://github.com/executeautomation/mcp-playwright) 📇 - Server MCP che usa Playwright per automazione browser e webscraping
- [eyalzh/browser-control-mcp](https://github.com/eyalzh/browser-control-mcp) 📇 🏠 - Server MCP abbinato a un’estensione browser che permette ai client LLM di controllare il browser utente (Firefox).
- [fradser/mcp-server-apple-reminders](https://github.com/FradSer/mcp-server-apple-reminders) 📇 🏠 🍎 - Server MCP per interagire con Apple Promemoria su macOS
- [getrupt/ashra-mcp](https://github.com/getrupt/ashra-mcp) 🐍 🏠 - Estrae dati strutturati da qualsiasi sito web. Basta un prompt e ottieni JSON.
- [kimtaeyoon83/mcp-server-youtube-transcript](https://github.com/kimtaeyoon83/mcp-server-youtube-transcript) 📇 ☁️ - Recupera sottotitoli e trascrizioni YouTube per analisi AI
- [kimtth/mcp-aoai-web-browsing](https://github.com/kimtth/mcp-aoai-web-browsing) 🐍 🏠 - Implementazione server/client MCP `minimal` usando Azure OpenAI e Playwright.
- [microsoft/playwright-mcp](https://github.com/microsoft/playwright-mcp) - Server MCP ufficiale Microsoft Playwright, permette agli LLM di interagire con pagine web tramite snapshot strutturati di accessibilità
- [modelcontextprotocol/server-puppeteer](https://github.com/modelcontextprotocol/servers/tree/main/src/puppeteer) 📇 🏠 - Automazione browser per scraping e interazione web
- [ndthanhdev/mcp-browser-kit](https://github.com/ndthanhdev/mcp-browser-kit) 📇 🏠 - Server MCP per interagire con browser compatibili manifest v2.
- [pskill9/web-search](https://github.com/pskill9/web-search) 📇 🏠 - Server MCP che permette la ricerca web gratuita usando risultati di Google, senza necessità di API key.
- [recursechat/mcp-server-apple-shortcuts](https://github.com/recursechat/mcp-server-apple-shortcuts) 📇 🏠 🍎 - Integrazione Server MCP con Apple Shortcuts

### ☁️ <a name="cloud-platforms"></a>Piattaforme Cloud

Integrazione di servizi di piattaforme cloud. Permette gestione e interazione con infrastrutture e servizi cloud.

- [awslabs/mcp](https://github.com/awslabs/mcp) 🎖️ ☁️ - Server AWS MCP per integrazione fluida con servizi e risorse AWS.
- [qiniu/qiniu-mcp-server](https://github.com/qiniu/qiniu-mcp-server) 🐍 ☁️ - MCP costruito su prodotti Qiniu Cloud, supporta accesso a Qiniu Cloud Storage, servizi di elaborazione media, ecc.
- [alexbakers/mcp-ipfs](https://github.com/alexbakers/mcp-ipfs) 📇 ☁️ - Caricamento e manipolazione dello storage IPFS
- [reza-gholizade/k8s-mcp-server](https://github.com/reza-gholizade/k8s-mcp-server) 🏎️ ☁️/🏠 - Server Kubernetes Model Context Protocol (MCP) che fornisce strumenti per interagire con cluster Kubernetes tramite interfaccia standardizzata, inclusa scoperta risorse API, gestione risorse, log pod, metriche ed eventi.
- [VmLia/books-mcp-server](https://github.com/VmLia/books-mcp-server) 📇 ☁️ - Server MCP per interrogare libri, utilizzabile in client MCP comuni come Cherry Studio.
- [alexei-led/aws-mcp-server](https://github.com/alexei-led/aws-mcp-server) 🐍 ☁️ - Server leggero ma potente che permette agli assistenti AI di eseguire comandi AWS CLI, usare pipe Unix e applicare template prompt per attività AWS comuni in ambiente Docker sicuro e con supporto multi-architettura.
- [alexei-led/k8s-mcp-server](https://github.com/alexei-led/k8s-mcp-server) 🐍 - Server leggero ma robusto che permette agli assistenti AI di eseguire in sicurezza comandi CLI Kubernetes (`kubectl`, `helm`, `istioctl` e `argocd`) usando pipe Unix in ambiente Docker sicuro con supporto multi-architettura.
- [aliyun/alibaba-cloud-ops-mcp-server](https://github.com/aliyun/alibaba-cloud-ops-mcp-server) 🎖️ 🐍 ☁️ - Server MCP che permette agli assistenti AI di operare risorse su Alibaba Cloud, supportando ECS, Cloud Monitor, OOS e prodotti cloud più diffusi.  
- [bright8192/esxi-mcp-server](https://github.com/bright8192/esxi-mcp-server) 🐍 ☁️ - Server di gestione VMware ESXi/vCenter basato su MCP (Model Control Protocol), che offre semplici interfacce API REST per la gestione delle macchine virtuali.
- [cloudflare/mcp-server-cloudflare](https://github.com/cloudflare/mcp-server-cloudflare) 🎖️ 📇 ☁️ - Integrazione con i servizi Cloudflare inclusi Workers, KV, R2 e D1
- [cyclops-ui/mcp-cyclops](https://github.com/cyclops-ui/mcp-cyclops) 🎖️ 🏎️ ☁️ - Server MCP che permette agli agenti AI di gestire risorse Kubernetes tramite astrazione Cyclops
- [jedisct1/fastly-mcp-server](https://github.com/jedisct1/fastly-openapi-schema) 🎖️ 📇 ☁️ - Integrazione con i servizi Fastly
- [flux159/mcp-server-kubernetes](https://github.com/Flux159/mcp-server-kubernetes) 📇 ☁️/🏠 - Implementazione Typescript di operazioni su cluster Kubernetes per pod, deployment, servizi.
- [hardik-id/azure-resource-graph-mcp-server](https://github.com/hardik-id/azure-resource-graph-mcp-server) 📇 ☁️/🏠 - Server Model Context Protocol per interrogare e analizzare risorse Azure su larga scala usando Azure Resource Graph, permettendo agli assistenti AI di esplorare e monitorare l’infrastruttura Azure.
- [jdubois/azure-cli-mcp](https://github.com/jdubois/azure-cli-mcp) - Wrapper per la linea di comando Azure CLI che consente di interagire direttamente con Azure
- [johnneerdael/netskope-mcp](https://github.com/johnneerdael/netskope-mcp) 🔒 ☁️ - MCP per accedere a tutti i componenti Netskope Private Access all'interno di ambienti Netskope Private Access inclusi dettagli di setup e esempi LLM di utilizzo.
- [manusa/Kubernetes MCP Server](https://github.com/manusa/kubernetes-mcp-server) 🏎️ 🏠 - Potente server Kubernetes MCP con supporto aggiuntivo per OpenShift. Oltre a fornire operazioni CRUD su **qualsiasi** risorsa Kubernetes, offre strumenti specializzati per interagire con il cluster.
- [nwiizo/tfmcp](https://github.com/nwiizo/tfmcp) 🦀 🏠 - Server Terraform MCP che permette agli assistenti AI di gestire e operare ambienti Terraform, leggendo configurazioni, analizzando piani, applicando configurazioni e gestendo lo stato Terraform.
- [pulumi/mcp-server](https://github.com/pulumi/mcp-server) 🎖️ 📇 🏠 - Server MCP per interagire con Pulumi tramite API Automation Pulumi e API Cloud Pulumi. Permette ai client MCP di eseguire operazioni come recupero informazioni pacchetti, anteprima modifiche, deploy aggiornamenti e recupero output stack in modo programmato.
- [rohitg00/kubectl-mcp-server](https://github.com/rohitg00/kubectl-mcp-server) 🐍 ☁️/🏠 - Server Model Context Protocol (MCP) per Kubernetes che permette ad assistenti AI come Claude, Cursor e altri di interagire con cluster Kubernetes tramite linguaggio naturale.
- [strowk/mcp-k8s-go](https://github.com/strowk/mcp-k8s-go) 🏎️ ☁️/🏠 - Operazioni su cluster Kubernetes tramite MCP
- [thunderboltsid/mcp-nutanix](https://github.com/thunderboltsid/mcp-nutanix) 🏎️ 🏠/☁️ - Server MCP in Go per interfacciarsi con risorse Nutanix Prism Central.
- [trilogy-group/aws-pricing-mcp](https://github.com/trilogy-group/aws-pricing-mcp) 🏎️ ☁️/🏠 - Ottieni informazioni aggiornate sui prezzi EC2 con una sola chiamata. Veloce. Basato su un catalogo prezzi AWS pre-analizzato.
- [weibaohui/k8m](https://github.com/weibaohui/k8m) 🏎️ ☁️/🏠 - Fornisce gestione e operazioni MCP multi-cluster Kubernetes, con interfaccia di gestione, logging e circa 50 strumenti integrati per scenari DevOps e sviluppo comuni. Supporta risorse standard e CRD.
- [weibaohui/kom](https://github.com/weibaohui/kom) 🏎️ ☁️/🏠 - Fornisce gestione e operazioni MCP multi-cluster Kubernetes. Può essere integrato come SDK nel tuo progetto e include circa 50 strumenti integrati per scenari DevOps e sviluppo comuni. Supporta risorse standard e CRD.
- [wenhuwang/mcp-k8s-eye](https://github.com/wenhuwang/mcp-k8s-eye) 🏎️ ☁️/🏠 - MCP Server per la gestione di Kubernetes, analizza il tuo cluster e la salute delle applicazioni
- [erikhoward/adls-mcp-server](https://github.com/erikhoward/adls-mcp-server) 🐍 ☁️/🏠 - MCP Server per Azure Data Lake Storage. Può gestire container, eseguire operazioni di lettura/scrittura/caricamento/download sui file dei container e gestire i metadati dei file.
- [silenceper/mcp-k8s](https://github.com/silenceper/mcp-k8s) 🏎️ ☁️/🏠 - MCP-K8S è uno strumento di gestione delle risorse Kubernetes guidato dall'AI che permette agli utenti di operare su qualsiasi risorsa nei cluster Kubernetes tramite interazione in linguaggio naturale, incluse risorse native (come Deployment, Service) e risorse personalizzate (CRD). Non è necessario memorizzare comandi complessi: basta descrivere le proprie esigenze e l'AI eseguirà accuratamente le operazioni corrispondenti, migliorando notevolmente l'usabilità di Kubernetes.
- [redis/mcp-redis-cloud](https://github.com/redis/mcp-redis-cloud) 📇 ☁️ - Gestisci le tue risorse Redis Cloud facilmente usando il linguaggio naturale. Crea database, monitora abbonamenti e configura deployment cloud con semplici comandi.
- [portainer/portainer-mcp](https://github.com/portainer/portainer-mcp) 🏎️ ☁️/🏠 - Un potente server MCP che consente agli assistenti AI di interagire senza soluzione di continuità con le istanze Portainer, offrendo accesso in linguaggio naturale alla gestione dei container, operazioni di deployment e funzionalità di monitoraggio dell'infrastruttura.

### 👨‍💻 <a name="code-execution"></a>Esecuzione del Codice

Server per l'esecuzione di codice. Permettono ai LLM di eseguire codice in un ambiente sicuro, ad esempio per agenti di programmazione.

- [pydantic/pydantic-ai/mcp-run-python](https://github.com/pydantic/pydantic-ai/tree/main/mcp-run-python) 🐍 🏠- Esegui codice Python in una sandbox sicura tramite chiamate agli strumenti MCP
- [yepcode/mcp-server-js](https://github.com/yepcode/mcp-server-js) 🎖️ 📇 ☁️ - Esegui qualsiasi codice generato da LLM in un ambiente sandbox sicuro e scalabile e crea i tuoi strumenti MCP usando JavaScript o Python, con pieno supporto ai pacchetti NPM e PyPI
- [ckanthony/openapi-mcp](https://github.com/ckanthony/openapi-mcp) 🏎️ ☁️ - OpenAPI-MCP: Server MCP dockerizzato che consente al tuo agente AI di accedere a qualsiasi API con documentazione API esistente.
- [alfonsograziano/node-code-sandbox-mcp](https://github.com/alfonsograziano/node-code-sandbox-mcp) 📇 🏠 – Un server MCP Node.js che crea sandbox isolate basate su Docker per eseguire snippet JavaScript con installazione on-the-fly delle dipendenze npm e pulizia automatica
- [r33drichards/mcp-js](https://github.com/r33drichards/mcp-js) 🦀 🏠 🐧 🍎 - Una sandbox per l'esecuzione di codice Javascript che utilizza v8 per isolare il codice ed eseguire localmente javascript generato dall’AI in sicurezza. Supporta snapshot dell’heap per sessioni persistenti.

### 🤖 <a name="coding-agents"></a>Agenti di Programmazione

Agenti di programmazione completi che consentono ai LLM di leggere, modificare, eseguire codice e risolvere in completa autonomia compiti generali di programmazione.

- [oraios/serena](https://github.com/oraios/serena)🐍🏠 - Agente di programmazione completo che si basa su operazioni simboliche sul codice tramite language server.
- [ezyang/codemcp](https://github.com/ezyang/codemcp) 🐍🏠 - Agente di programmazione con strumenti di base per lettura, scrittura e interfaccia a riga di comando.
- [doggybee/mcp-server-leetcode](https://github.com/doggybee/mcp-server-leetcode) 📇 ☁️ - Server MCP che permette ai modelli AI di cercare, recuperare e risolvere problemi di LeetCode. Supporta filtraggio dei metadati, profili utente, invii e accesso ai dati dei contest.
- [jinzcdev/leetcode-mcp-server](https://github.com/jinzcdev/leetcode-mcp-server) 📇 ☁️ - Server MCP che abilita accesso automatico ai problemi di programmazione, soluzioni, invii e dati pubblici di **LeetCode** con autenticazione opzionale per funzionalità specifiche dell’utente (es. note), supportando sia `leetcode.com` (globale) che `leetcode.cn` (Cina).
- [juehang/vscode-mcp-server](https://github.com/juehang/vscode-mcp-server) 📇 🏠 - Un server MCP che consente all’AI come Claude di leggere la struttura delle directory in un workspace VS Code, vedere i problemi rilevati dai linter e dal language server, leggere file di codice e apportare modifiche.
- [micl2e2/code-to-tree](https://github.com/micl2e2/code-to-tree) 🌊 🏠 📟 🐧 🪟 🍎 - Un server MCP monolitico che converte il codice sorgente in AST, indipendentemente dal linguaggio.

### 🖥️ <a name="command-line"></a>Riga di Comando

Esegui comandi, cattura output e interagisci con shell e strumenti a riga di comando.

- [ferrislucas/iterm-mcp](https://github.com/ferrislucas/iterm-mcp) 🖥️ 🛠️ 💬 - Un server Model Context Protocol che fornisce accesso a iTerm. Puoi eseguire comandi e fare domande su ciò che vedi nel terminale iTerm.
- [g0t4/mcp-server-commands](https://github.com/g0t4/mcp-server-commands) 📇 🏠 - Esegui qualsiasi comando con gli strumenti `run_command` e `run_script`.
- [maxim-saplin/mcp_safe_local_python_executor](https://github.com/maxim-saplin/mcp_safe_local_python_executor) - Interprete Python sicuro basato su HF Smolagents `LocalPythonExecutor`
- [MladenSU/cli-mcp-server](https://github.com/MladenSU/cli-mcp-server) 🐍 🏠 - Interfaccia a riga di comando con esecuzione sicura e policy di sicurezza personalizzabili
- [OthmaneBlial/term_mcp_deepseek](https://github.com/OthmaneBlial/term_mcp_deepseek) 🐍 🏠 - Un server DeepSeek MCP-like per il Terminale
- [tumf/mcp-shell-server](https://github.com/tumf/mcp-shell-server) - Un server sicuro per l’esecuzione di comandi shell che implementa il Model Context Protocol (MCP)
- [automateyournetwork/pyATS_MCP](https://github.com/automateyournetwork/pyATS_MCP) - Server Cisco pyATS che abilita l’interazione strutturata e model-driven con dispositivi di rete.
- [wonderwhy-er/DesktopCommanderMCP](https://github.com/wonderwhy-er/DesktopCommanderMCP) 📇 🏠 🍎 🪟 🐧 - Un coltellino svizzero che può gestire/eseguire programmi e leggere/scrivere/cercare/modificare file di codice e di testo.
- [tufantunc/ssh-mcp](https://github.com/tufantunc/ssh-mcp) 📇 🏠 🐧 🪟 - Server MCP che espone il controllo SSH per server Linux e Windows tramite Model Context Protocol. Esegui comandi shell remoti in sicurezza con autenticazione tramite password o chiave SSH.

### 💬 <a name="communication"></a>Comunicazione

Integrazione con piattaforme di comunicazione per la gestione dei messaggi e delle operazioni sui canali. Permette ai modelli AI di interagire con strumenti di comunicazione per team.

- [AbdelStark/nostr-mcp](https://github.com/AbdelStark/nostr-mcp) ☁️ - Server MCP per interagire con Nostr, consente la pubblicazione di note e altro.
- [adhikasp/mcp-twikit](https://github.com/adhikasp/mcp-twikit) 🐍 ☁️ - Interagisci con la ricerca e la timeline di Twitter
- [agentmail-toolkit/mcp](https://github.com/agentmail-to/agentmail-toolkit/tree/main/mcp) 🐍 💬 - Un server MCP per creare inbox al volo per inviare, ricevere e compiere azioni sulle email. Non siamo agenti AI per le email, ma email per agenti AI.
- [arpitbatra123/mcp-googletasks](https://github.com/arpitbatra123/mcp-googletasks) 📇 ☁️ - Un server MCP per interfacciarsi con le API di Google Tasks
- [carterlasalle/mac_messages_mcp](https://github.com/carterlasalle/mac_messages_mcp) 🏠 🍎 🚀 - Un server MCP che si interfaccia in sicurezza con il tuo database iMessage tramite il Model Context Protocol (MCP), consentendo ai LLM di interrogare e analizzare conversazioni iMessage. Include validazione robusta dei numeri di telefono, gestione degli allegati, gestione dei contatti, gestione delle chat di gruppo e pieno supporto per l'invio e la ricezione di messaggi.
- [chaindead/telegram-mcp](https://github.com/chaindead/telegram-mcp) 🏎️ 🏠 - Integrazione API Telegram per accedere ai dati utente, gestire dialoghi (chat, canali, gruppi), recuperare messaggi e gestire lo stato di lettura
- [chigwell/telegram-mcp](https://github.com/chigwell/telegram-mcp) 🐍 🏠 - Integrazione API Telegram per accedere ai dati utente, gestire dialoghi (chat, canali, gruppi), recuperare e inviare messaggi e gestire lo stato di lettura.
- [elie222/inbox-zero](https://github.com/elie222/inbox-zero/tree/main/apps/mcp-server) 🐍 ☁️ - Un server MCP per Inbox Zero. Aggiunge funzionalità extra a Gmail come trovare quali email necessitano una risposta o un follow-up.
- [gitmotion/ntfy-me-mcp](https://github.com/gitmotion/ntfy-me-mcp) 📇 ☁️ 🏠 - Un server MCP ntfy per inviare/ricevere notifiche ntfy al tuo server ntfy self-hosted da agenti AI 📤 (supporta autenticazione sicura tramite token e altro - usalo con npx o docker!)
- [gotoolkits/wecombot](https://github.com/gotoolkits/mcp-wecombot-server.git) 🚀 ☁️ - Un'applicazione server MCP che invia vari tipi di messaggi al robot di gruppo WeCom.
- [hannesrudolph/imessage-query-fastmcp-mcp-server](https://github.com/hannesrudolph/imessage-query-fastmcp-mcp-server) 🐍 🏠 🍎 - Un server MCP che fornisce accesso sicuro al tuo database iMessage tramite Model Context Protocol (MCP), permettendo ai LLM di interrogare e analizzare conversazioni iMessage con corretta validazione dei numeri di telefono e gestione degli allegati
- [i-am-bee/acp-mcp](https://github.com/i-am-bee/acp-mcp) 🐍 💬 - Un server MCP che funge da adattatore nell’ecosistema [ACP](https://agentcommunicationprotocol.dev). Espone senza soluzione di continuità agenti ACP ai client MCP, facendo da ponte tra i due protocolli di comunicazione.
- [jagan-shanmugam/mattermost-mcp-host](https://github.com/jagan-shanmugam/mattermost-mcp-host) 🐍 🏠 - Un server MCP insieme a MCP host che fornisce accesso a team, canali e messaggi Mattermost. MCP host è integrato come bot in Mattermost con accesso a server MCP configurabili.
- [lharries/whatsapp-mcp](https://github.com/lharries/whatsapp-mcp) 🐍 🏎️ - Un server MCP per cercare i tuoi messaggi personali WhatsApp, contatti e inviare messaggi a individui o gruppi
- [line/line-bot-mcp-server](https://github.com/line/line-bot-mcp-server) 🎖 📇 ☁️ - Server MCP per integrare LINE Official Account
- [MarkusPfundstein/mcp-gsuite](https://github.com/MarkusPfundstein/mcp-gsuite) 🐍 ☁️ - Integrazione con Gmail e Google Calendar.
- [modelcontextprotocol/server-bluesky](https://github.com/keturiosakys/bluesky-context-server) 📇 ☁️ - Integrazione Bluesky per interrogazione e interazione
- [modelcontextprotocol/server-slack](https://github.com/modelcontextprotocol/servers/tree/main/src/slack) 📇 ☁️ - Integrazione Slack workspace per la gestione dei canali e la messaggistica
- [korotovsky/slack-mcp-server](https://github.com/korotovsky/slack-mcp-server) 📇 ☁️ - Il server MCP più potente per Slack Workspaces.
- [sawa-zen/vrchat-mcp](https://github.com/sawa-zen/vrchat-mcp) - 📇 🏠 Questo è un server MCP per interagire con le API di VRChat. Puoi recuperare informazioni su amici, mondi, avatar e altro su VRChat.
- [takumi0706/google-calendar-mcp](https://github.com/takumi0706/google-calendar-mcp) 📇 ☁️ - Un server MCP per interfacciarsi con le API di Google Calendar. Basato su TypeScript.
- [teddyzxcv/ntfy-mcp](https://github.com/teddyzxcv/ntfy-mcp) - Il server MCP che ti tiene aggiornato inviando notifiche su telefono tramite ntfy
- [userad/didlogic_mcp](https://github.com/UserAd/didlogic_mcp) 🐍 ☁️ - Un server MCP per [DIDLogic](https://didlogic.com). Aggiunge funzionalità per gestire endpoint SIP, numeri e destinazioni.
- [zcaceres/gtasks-mcp](https://github.com/zcaceres/gtasks-mcp) 📇 ☁️ - Un server MCP per gestire Google Tasks
- [InditexTech/mcp-teams-server](https://github.com/InditexTech/mcp-teams-server) 🐍 ☁️ - Server MCP che integra la messaggistica di Microsoft Teams (lettura, pubblicazione, menzione, elenco membri e thread)
- [softeria/ms-365-mcp-server](https://github.com/softeria/ms-365-mcp-server) 📇 ☁️ - Server MCP che si connette all’intera suite Microsoft 365 tramite Graph API (inclusi mail, file, Excel, calendario)
- [YCloud-Developers/ycloud-whatsapp-mcp-server](https://github.com/YCloud-Developers/ycloud-whatsapp-mcp-server) 📇 🏠 - Server MCP per WhatsApp Business Platform di YCloud.
- [jaipandya/producthunt-mcp-server](https://github.com/jaipandya/producthunt-mcp-server) 🐍 🏠 - Server MCP per Product Hunt. Interagisci con post di tendenza, commenti, collezioni, utenti e altro.


### 👤 <a name="customer-data-platforms"></a>Piattaforme Dati Cliente

Fornisce accesso ai profili cliente all'interno delle Customer Data Platform

- [iaptic/mcp-server-iaptic](https://github.com/iaptic/mcp-server-iaptic) 🎖️ 📇 ☁️ - Connettiti con [iaptic](https://www.iaptic.com) per chiedere informazioni su acquisti dei clienti, dati di transazione e statistiche di ricavi delle app.
- [OpenDataMCP/OpenDataMCP](https://github.com/OpenDataMCP/OpenDataMCP) 🐍 ☁️ - Collega qualsiasi Open Data a qualsiasi LLM con il Model Context Protocol.
- [sergehuber/inoyu-mcp-unomi-server](https://github.com/sergehuber/inoyu-mcp-unomi-server) 📇 ☁️ - Un server MCP per accedere e aggiornare i profili su un server Apache Unomi CDP.
- [tinybirdco/mcp-tinybird](https://github.com/tinybirdco/mcp-tinybird) 🐍 ☁️ - Un server MCP per interagire con un Workspace Tinybird da qualsiasi client MCP.
- [@antv/mcp-server-chart](https://github.com/antvis/mcp-server-chart) 🎖️ 📇 ☁️ - Un server Model Context Protocol per generare grafici visuali usando [AntV](https://github.com/antvis).

### 🗄️ <a name="databases"></a>Database

Accesso sicuro al database con capacità di ispezione dello schema. Permette interrogazione e analisi dei dati con controlli di sicurezza configurabili inclusa la modalità di sola lettura.

- [Aiven-Open/mcp-aiven](https://github.com/Aiven-Open/mcp-aiven) - 🐍 ☁️ 🎖️ -  Naviga i tuoi [progetti Aiven](https://go.aiven.io/mcp-server) e interagisci con i servizi PostgreSQL®, Apache Kafka®, ClickHouse® e OpenSearch®
- [alexanderzuev/supabase-mcp-server](https://github.com/alexander-zuev/supabase-mcp-server) - Server MCP Supabase con supporto per esecuzione di query SQL e strumenti di esplorazione database
- [aliyun/alibabacloud-tablestore-mcp-server](https://github.com/aliyun/alibabacloud-tablestore-mcp-server) ☕ 🐍 ☁️ - Servizio MCP per Tablestore, include aggiunta documenti, ricerca semantica di documenti basata su vettori e scalari, compatibile RAG e serverless.
- [benborla29/mcp-server-mysql](https://github.com/benborla/mcp-server-mysql) ☁️ 🏠 - Integrazione database MySQL in NodeJS con controlli di accesso configurabili e ispezione dello schema
- [bytebase/dbhub](https://github.com/bytebase/dbhub) 📇 🏠 – Server MCP universale per database che supporta i principali database.
- [c4pt0r/mcp-server-tidb](https://github.com/c4pt0r/mcp-server-tidb) 🐍 ☁️ - Integrazione database TiDB con ispezione dello schema e capacità di query
- [Canner/wren-engine](https://github.com/Canner/wren-engine) 🐍 🦀 🏠 - Motore Semantico per Client Model Context Protocol (MCP) e agenti AI
- [centralmind/gateway](https://github.com/centralmind/gateway) 🏎️ 🏠 🍎 🪟 - Server MCP e MCP SSE che generano automaticamente API basate su schema e dati del database. Supporta PostgreSQL, Clickhouse, MySQL, Snowflake, BigQuery, Supabase
- [ChristianHinge/dicom-mcp](https://github.com/ChristianHinge/dicom-mcp) 🐍 ☁️ 🏠 - Integrazione DICOM per interrogare, leggere e trasferire immagini e referti medici da PACS e altri sistemi compatibili DICOM.
- [chroma-core/chroma-mcp](https://github.com/chroma-core/chroma-mcp) 🎖️ 🐍 ☁️ 🏠 - Server Chroma MCP per accedere a istanze Chroma locali e cloud per capacità di retrieval
- [ClickHouse/mcp-clickhouse](https://github.com/ClickHouse/mcp-clickhouse) 🐍 ☁️ - Integrazione database ClickHouse con ispezione dello schema e capacità di query
- [confluentinc/mcp-confluent](https://github.com/confluentinc/mcp-confluent) 🐍 ☁️ - Integrazione Confluent per interagire con le API REST di Confluent Kafka e Confluent Cloud.
- [Couchbase-Ecosystem/mcp-server-couchbase](https://github.com/Couchbase-Ecosystem/mcp-server-couchbase) 🎖️ 🐍 ☁️ 🏠 - Il server Couchbase MCP offre accesso unificato sia al cloud Capella che ai cluster autogestiti per operazioni su documenti, query SQL++ e analisi dei dati in linguaggio naturale.
- [cr7258/elasticsearch-mcp-server](https://github.com/cr7258/elasticsearch-mcp-server) 🐍 🏠 - Implementazione MCP Server che fornisce interazione con Elasticsearch
- [crystaldba/postgres-mcp](https://github.com/crystaldba/postgres-mcp) 🐍 🏠 - Server MCP tutto-in-uno per sviluppo e operazioni Postgres, con strumenti per analisi delle prestazioni, ottimizzazione e controlli di salute
- [Dataring-engineering/mcp-server-trino](https://github.com/Dataring-engineering/mcp-server-trino) 🐍 ☁️ - Server Trino MCP per interrogare e accedere ai dati dai cluster Trino.
- [tuannvm/mcp-trino](https://github.com/tuannvm/mcp-trino) 🏎️ ☁️ - Un'implementazione Go di un server Model Context Protocol (MCP) per Trino
- [designcomputer/mysql_mcp_server](https://github.com/designcomputer/mysql_mcp_server) 🐍 🏠 - Integrazione database MySQL con controlli di accesso configurabili, ispezione dello schema e linee guida di sicurezza complete
- [wenb1n-dev/mysql_mcp_server_pro](https://github.com/wenb1n-dev/mysql_mcp_server_pro)  🐍 🏠 - Supporta SSE, STDIO; non si limita solo alle funzionalità CRUD di MySQL; include anche capacità di analisi delle eccezioni del database; controlla i permessi del database in base ai ruoli; semplifica l'estensione degli strumenti con personalizzazioni per gli sviluppatori
- [domdomegg/airtable-mcp-server](https://github.com/domdomegg/airtable-mcp-server) 📇 🏠 - Integrazione con database Airtable con ispezione dello schema e capacità di lettura/scrittura
- [edwinbernadus/nocodb-mcp-server](https://github.com/edwinbernadus/nocodb-mcp-server) 📇 ☁️ - Integrazione database Nocodb, capacità di lettura e scrittura
- [ergut/mcp-bigquery-server](https://github.com/ergut/mcp-bigquery-server) 📇 ☁️ - Implementazione server per integrazione Google BigQuery che abilita accesso diretto e capacità di interrogazione sul database BigQuery
- [f4ww4z/mcp-mysql-server](https://github.com/f4ww4z/mcp-mysql-server) 📇 🏠 - Integrazione database MySQL basata su Node.js che fornisce operazioni sicure su database MySQL
- [fireproof-storage/mcp-database-server](https://github.com/fireproof-storage/mcp-database-server) 📇 ☁️ - Database ledger Fireproof con sincronizzazione multiutente
- [FreePeak/db-mcp-server](https://github.com/FreePeak/db-mcp-server) 🏎️ 🏠 – Un server MCP multi-database ad alte prestazioni sviluppato in Golang, che supporta MySQL & PostgreSQL (NoSQL in arrivo). Include strumenti integrati per esecuzione query, gestione transazioni, esplorazione schema, costruzione query e analisi delle prestazioni, con integrazione Cursor senza soluzione di continuità per flussi di lavoro database avanzati.
- [furey/mongodb-lens](https://github.com/furey/mongodb-lens) 📇 🏠 - MongoDB Lens: Server MCP completo per database MongoDB
- [gannonh/firebase-mcp](https://github.com/gannonh/firebase-mcp) 🔥 ⛅️ - Servizi Firebase inclusi Auth, Firestore e Storage.
- [get-convex/convex-backend](https://stack.convex.dev/convex-mcp-server) 📇 ☁️ - Integrazione database Convex per introspezione tabelle, funzioni ed esecuzione di query singole ([Source](https://github.com/get-convex/convex-backend/blob/main/npm-packages/convex/src/cli/mcp.ts))
- [googleapis/genai-toolbox](https://github.com/googleapis/genai-toolbox) 🏎️ ☁️ - Server MCP open source specializzato in strumenti facili, veloci e sicuri per i database.
- [GreptimeTeam/greptimedb-mcp-server](https://github.com/GreptimeTeam/greptimedb-mcp-server) 🐍 🏠 - MCP Server per interrogare GreptimeDB.
- [hannesrudolph/sqlite-explorer-fastmcp-mcp-server](https://github.com/hannesrudolph/sqlite-explorer-fastmcp-mcp-server) 🐍 🏠 - Un server MCP che fornisce accesso sicuro e in sola lettura a database SQLite tramite Model Context Protocol (MCP). Questo server è costruito sul framework FastMCP, che consente agli LLM di esplorare e interrogare database SQLite con funzionalità di sicurezza e validazione delle query integrate.
- [idoru/influxdb-mcp-server](https://github.com/idoru/influxdb-mcp-server) 📇 ☁️ 🏠 - Esegui query contro InfluxDB OSS API v2.
- [isaacwasserman/mcp-snowflake-server](https://github.com/isaacwasserman/mcp-snowflake-server) 🐍 ☁️ - Integrazione Snowflake che implementa operazioni di lettura e (opzionale) scrittura, oltre al tracciamento degli insight
- [joshuarileydev/supabase-mcp-server](https://github.com/joshuarileydev/supabase) - Supabase MCP Server per gestire e creare progetti e organizzazioni in Supabase
- [jovezhong/mcp-timeplus](https://github.com/jovezhong/mcp-timeplus) 🐍 ☁️ - Server MCP per Apache Kafka e Timeplus. Può elencare i topic Kafka, leggere messaggi Kafka, salvare dati Kafka localmente e interrogare dati streaming con SQL tramite Timeplus
- [KashiwaByte/vikingdb-mcp-server](https://github.com/KashiwaByte/vikingdb-mcp-server) 🐍 ☁️ - Integrazione VikingDB con introduzione di collezioni e indici, capacità di vector store e ricerca.
- [kiliczsh/mcp-mongo-server](https://github.com/kiliczsh/mcp-mongo-server) 📇 🏠 - Un server Model Context Protocol per MongoDB
- [ktanaka101/mcp-server-duckdb](https://github.com/ktanaka101/mcp-server-duckdb) 🐍 🏠 - Integrazione database DuckDB con ispezione dello schema e capacità di interrogazione
- [LucasHild/mcp-server-bigquery](https://github.com/LucasHild/mcp-server-bigquery) 🐍 ☁️ - Integrazione database BigQuery con ispezione dello schema e capacità di interrogazione
- [quarkiverse/mcp-server-jdbc](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/jdbc) ☕ 🏠 - Connetti qualsiasi database compatibile JDBC per interrogare, inserire, aggiornare, cancellare e altro.
- [jparkerweb/mcp-sqlite](https://github.com/jparkerweb/mcp-sqlite) 📇 🏠 - Server Model Context Protocol (MCP) che offre capacità complete di interazione con database SQLite.
- [memgraph/mcp-memgraph](https://github.com/memgraph/mcp-memgraph) 🐍 🏠 - Memgraph MCP Server - include uno strumento per eseguire query su Memgraph e una risorsa schema.
- [modelcontextprotocol/server-postgres](https://github.com/modelcontextprotocol/servers/tree/main/src/postgres) 📇 🏠 - Integrazione database PostgreSQL con ispezione dello schema e capacità di interrogazione
- [modelcontextprotocol/server-sqlite](https://github.com/modelcontextprotocol/servers/tree/main/src/sqlite) 🐍 🏠 - Operazioni database SQLite con funzionalità di analisi integrate
- [neo4j-contrib/mcp-neo4j](https://github.com/neo4j-contrib/mcp-neo4j) 🐍 🏠 - Model Context Protocol con Neo4j (Esegui query, Knowledge Graph Memory, Gestisci istanze Neo4j Aura)
- [neondatabase/mcp-server-neon](https://github.com/neondatabase/mcp-server-neon) 📇 ☁️ — Un server MCP per creare e gestire database Postgres usando Neon Serverless Postgres
- [niledatabase/nile-mcp-server](https://github.com/niledatabase/nile-mcp-server) Server MCP per la piattaforma Postgres di Nile - Gestisci e interroga database Postgres, tenant, utenti e autenticazione usando LLM
- [openlink/mcp-server-odbc](https://github.com/OpenLinkSoftware/mcp-odbc-server) 🐍 🏠 - Un server MCP per connettività generica a sistemi di gestione database (DBMS) tramite protocollo Open Database Connectivity (ODBC)
- [openlink/mcp-server-sqlalchemy](https://github.com/OpenLinkSoftware/mcp-sqlalchemy-server) 🐍 🏠 - Un server MCP per connettività generica a sistemi di gestione database (DBMS) tramite SQLAlchemy usando Python ODBC (pyodbc)
- [pab1it0/adx-mcp-server](https://github.com/pab1it0/adx-mcp-server) 🐍 ☁️ - Interroga e analizza database Azure Data Explorer
- [pab1it0/prometheus-mcp-server](https://github.com/pab1it0/prometheus-mcp-server) 🐍 ☁️ -  Interroga e analizza Prometheus, sistema open-source di monitoraggio.
- [prisma/prisma](https://github.com/prisma/prisma) 🐍 🏠 - Permette agli LLM di gestire database Prisma Postgres (es. creare nuove istanze o eseguire migrazioni schema).
- [qdrant/mcp-server-qdrant](https://github.com/qdrant/mcp-server-qdrant) 🐍 🏠 - Un server Qdrant MCP
- [QuantGeekDev/mongo-mcp](https://github.com/QuantGeekDev/mongo-mcp) 📇 🏠 - Integrazione MongoDB che consente agli LLM di interagire direttamente con i database.
- [rashidazarang/airtable-mcp](https://github.com/rashidazarang/airtable-mcp) 🐍 ☁️ - Collega strumenti AI direttamente ad Airtable. Interroga, crea, aggiorna ed elimina record usando il linguaggio naturale. Include gestione base, operazioni tabelle, manipolazione schema, filtraggio record e migrazione dati tramite interfaccia MCP standardizzata.
- [redis/mcp-redis](https://github.com/redis/mcp-redis) 🐍 🏠 - Il server MCP ufficiale di Redis offre un'interfaccia per gestire e cercare dati in Redis.
- [runekaagaard/mcp-alchemy](https://github.com/runekaagaard/mcp-alchemy) 🐍 🏠 - Integrazione database universale basata su SQLAlchemy che supporta PostgreSQL, MySQL, MariaDB, SQLite, Oracle, MS SQL Server e molti altri. Offre ispezione di schema e relazioni, e analisi di grandi dataset.
- [sirmews/mcp-pinecone](https://github.com/sirmews/mcp-pinecone) 🐍 ☁️ - Integrazione Pinecone con capacità di ricerca vettoriale
- [skysqlinc/skysql-mcp](https://github.com/skysqlinc/skysql-mcp) 🎖️ ☁️ - Serverless MariaDB Cloud DB MCP server. Strumenti per avviare, eliminare, eseguire SQL e lavorare con agenti AI a livello DB per text-2-sql accurato e conversazioni.
- [supabase-community/supabase-mcp](https://github.com/supabase-community/supabase-mcp) 🎖️ 📇 ☁️ - Server MCP ufficiale Supabase per connettere assistenti AI direttamente al tuo progetto Supabase e consentire loro di eseguire compiti come gestione tabelle, recupero configurazione e interrogazione dati.
- [TheRaLabs/legion-mcp](https://github.com/TheRaLabs/legion-mcp) 🐍 🏠 Server MCP universale per database che supporta diversi tipi di database tra cui PostgreSQL, Redshift, CockroachDB, MySQL, RDS MySQL, Microsoft SQL Server, BigQuery, Oracle DB e SQLite.
- [tradercjz/dolphindb-mcp-server](https://github.com/tradercjz/dolphindb-mcp-server) 🐍 ☁️ - Integrazione database TDolphinDB con ispezione dello schema e capacità di interrogazione
- [weaviate/mcp-server-weaviate](https://github.com/weaviate/mcp-server-weaviate) 🐍 📇 ☁️ - Un server MCP per connettersi alle tue collezioni Weaviate come knowledge base e utilizzare Weaviate come memoria chat.
- [XGenerationLab/xiyan_mcp_server](https://github.com/XGenerationLab/xiyan_mcp_server) 📇 ☁️ — Un server MCP che supporta il recupero dati da un database usando query in linguaggio naturale, alimentato da XiyanSQL come LLM text-to-SQL.
- [xing5/mcp-google-sheets](https://github.com/xing5/mcp-google-sheets) 🐍 ☁️ - Un server Model Context Protocol per interagire con Google Sheets. Questo server offre strumenti per creare, leggere, aggiornare e gestire fogli tramite Google Sheets API.
- [freema/mcp-gsheets](https://github.com/freema/mcp-gsheets) 📇 ☁️ - Server MCP per integrazione API Google Sheets con capacità complete di lettura, scrittura, formattazione e gestione dei fogli.
- [Zhwt/go-mcp-mysql](https://github.com/Zhwt/go-mcp-mysql) 🏎️ 🏠 – Server MySQL MCP facile da usare, senza dipendenze, sviluppato in Golang, con modalità sola lettura configurabile e ispezione schema.
- [ydb/ydb-mcp](https://github.com/ydb-platform/ydb-mcp) 🎖️ 🐍 ☁️ - Server MCP per interagire con database [YDB](https://ydb.tech)
- [zilliztech/mcp-server-milvus](https://github.com/zilliztech/mcp-server-milvus) 🐍 🏠 ☁️ - Server MCP per Milvus / Zilliz, che rende possibile interagire con il tuo database.
- [openlink/mcp-server-jdbc](https://github.com/OpenLinkSoftware/mcp-jdbc-server) 🐍 🏠 - Un server MCP per connettività generica a sistemi di gestione database (DBMS) tramite protocollo Java Database Connectivity (JDBC)
- [yincongcyincong/VictoriaMetrics-mcp-server](https://github.com/yincongcyincong/VictoriaMetrics-mcp-server) 🐍 🏠 - Un server MCP per interagire con il database VictoriaMetrics.
- [hydrolix/mcp-hydrolix](https://github.com/hydrolix/mcp-hydrolix) 🎖️ 🐍 ☁️ - Integrazione Hydrolix time-series datalake che fornisce esplorazione schema e capacità di interrogazione ai flussi di lavoro basati su LLM.
- [davewind/mysql-mcp-server](https://github.com/dave-wind/mysql-mcp-server) 🏎️ 🏠 A – server mysql mcp user-friendly in sola lettura per cursor e n8n...


### 📊 <a name="data-platforms"></a>Piattaforme Dati

Piattaforme dati per integrazione, trasformazione e orchestrazione delle pipeline dati.

- [flowcore/mcp-flowcore-platform](https://github.com/flowcore-io/mcp-flowcore-platform) 🎖️ 📇 ☁️ 🏠 - Interagisci con Flowcore per eseguire azioni, ingerire dati, analizzare, incrociare e utilizzare qualsiasi dato nei tuoi data core o in data core pubblici; tutto con linguaggio naturale.
- [JordiNei/mcp-databricks-server](https://github.com/JordiNeil/mcp-databricks-server) 🐍 ☁️ - Connessione all'API Databricks, che consente agli LLM di eseguire query SQL, elencare lavori e ottenere lo stato dei lavori.
- [yashshingvi/databricks-genie-MCP](https://github.com/yashshingvi/databricks-genie-MCP) 🐍 ☁️ - Un server che si connette all'API Databricks Genie, permettendo agli LLM di porre domande in linguaggio naturale, eseguire query SQL e interagire con agenti conversazionali Databricks.
- [jwaxman19/qlik-mcp](https://github.com/jwaxman19/qlik-mcp) 📇 ☁️ - Server MCP per Qlik Cloud API che consente interrogazione di applicazioni, fogli ed estrazione di dati da visualizzazioni con supporto completo per autenticazione e rate limiting.
- [keboola/keboola-mcp-server](https://github.com/keboola/keboola-mcp-server) 🐍 - interagisce con la piattaforma dati Keboola Connection. Questo server offre strumenti per elencare e accedere ai dati tramite Keboola Storage API.
- [dbt-labs/dbt-mcp](https://github.com/dbt-labs/dbt-mcp) 🎖️ 🐍 🏠 ☁️ - Server MCP ufficiale per [dbt (data build tool)](https://www.getdbt.com/product/what-is-dbt) che fornisce integrazione con dbt Core/Cloud CLI, scoperta dei metadati di progetto, informazioni sui modelli e interrogazione del semantic layer.
- [mattijsdp/dbt-docs-mcp](https://github.com/mattijsdp/dbt-docs-mcp) 🐍 🏠 - Server MCP per utenti dbt-core (OSS) poiché il server MCP dbt ufficiale supporta solo dbt Cloud. Supporta metadati di progetto, lineage a livello di modello e colonna e documentazione dbt. 

### 💻 <a name="developer-tools"></a>Strumenti per Sviluppatori

Strumenti e integrazioni che migliorano il flusso di lavoro di sviluppo e la gestione dell'ambiente.

- [Pratyay/mac-monitor-mcp](https://github.com/Pratyay/mac-monitor-mcp) 🐍 🏠 🍎 - Identifica i processi che consumano molte risorse su macOS e fornisce suggerimenti per migliorare le prestazioni.
- [21st-dev/Magic-MCP](https://github.com/21st-dev/magic-mcp) - Crea componenti UI realizzati ispirati ai migliori design engineer di 21st.dev.
- [Hypersequent/qasphere-mcp](https://github.com/Hypersequent/qasphere-mcp) 🎖️ 📇 ☁️ - Integrazione con il sistema di gestione test [QA Sphere](https://qasphere.com/), che permette agli LLM di scoprire, riassumere e interagire con i casi di test direttamente dagli IDE AI-powered
- [admica/FileScopeMCP](https://github.com/admica/FileScopeMCP) 🐍 📇 🦀 - Analizza la tua codebase identificando i file importanti in base alle dipendenze. Genera diagrammi e punteggi di importanza, aiutando gli assistenti AI a comprendere la codebase.
- [ambar/simctl-mcp](https://github.com/ambar/simctl-mcp) 📇 🏠 🍎 Implementazione server MCP per il controllo dell'iOS Simulator.
- [api7/apisix-mcp](https://github.com/api7/apisix-mcp) 🎖️ 📇 🏠 Server MCP che supporta interrogazione e gestione di tutte le risorse in [Apache APISIX](https://github.com/apache/apisix).
- [ArchAI-Labs/fastmcp-sonarqube-metrics](https://github.com/ArchAI-Labs/fastmcp-sonarqube-metrics) 🐍 🏠 🪟 🐧 🍎 -  Un server Model Context Protocol (MCP) che offre strumenti per recuperare informazioni su progetti SonarQube come metriche (attuali e storiche), problemi, stato di salute.
- [automation-ai-labs/mcp-link](https://github.com/automation-ai-labs/mcp-link) 🏎️ 🏠 - Integra senza soluzione di continuità qualsiasi API con agenti AI (con Schema OpenAPI)
- [azer/react-analyzer-mcp](https://github.com/azer/react-analyzer-mcp) 📇 🏠 - Analizza codice React localmente, genera documentazione / llm.txt per l'intero progetto in una volta sola
- [davidlin2k/pox-mcp-server](https://github.com/davidlin2k/pox-mcp-server) 🐍 🏠 - Server MCP per il controller SDN POX che offre capacità di controllo e gestione di rete.
- [CodeLogicIncEngineering/codelogic-mcp-server](https://github.com/CodeLogicIncEngineering/codelogic-mcp-server) 🎖️ 🐍 ☁️ 🍎 🪟 🐧 - Server MCP ufficiale per CodeLogic, che fornisce accesso ad analisi delle dipendenze del codice, analisi dei rischi architetturali e strumenti di valutazione impatti.
- [Comet-ML/Opik-MCP](https://github.com/comet-ml/opik-mcp) 🎖️ 📇 ☁️ 🏠 - Esplora con linguaggio naturale l'osservabilità LLM, tracce e dati di monitoraggio raccolti da Opik.
- [CircleCI/mcp-server-circleci](https://github.com/CircleCI-Public/mcp-server-circleci) 📇 ☁️ Consente agli AI Agent di correggere errori di build da CircleCI.
- [currents-dev/currents-mcp](https://github.com/currents-dev/currents-mcp) 🎖️ 📇 ☁️ Consente agli AI Agent di correggere errori Playwright segnalati a [Currents](https://currents.dev).
- [delano/postman-mcp-server](https://github.com/delano/postman-mcp-server) 📇 ☁️ - Interagisci con [Postman API](https://www.postman.com/postman/postman-public-workspace/)
- [flipt-io/mcp-server-flipt](https://github.com/flipt-io/mcp-server-flipt) 📇 🏠 - Permette agli assistenti AI di interagire con i feature flag in [Flipt](https://flipt.io).
- [GLips/Figma-Context-MCP](https://github.com/GLips/Figma-Context-MCP) 📇 🏠 - Fornisce agli agenti di codifica accesso diretto ai dati Figma per aiutarli nell'implementazione one-shot del design.
- [gofireflyio/firefly-mcp](https://github.com/gofireflyio/firefly-mcp) 🎖️ 📇 ☁️ - Integra, scopre, gestisce e codifica risorse cloud con [Firefly](https://firefly.ai).
- [Govcraft/rust-docs-mcp-server](https://github.com/Govcraft/rust-docs-mcp-server) 🦀 🏠 - Fornisce documentazione aggiornata di una specifica crate Rust agli LLM tramite uno strumento MCP, usando semantic search (embedding) e riepilogo LLM.
- [haris-musa/excel-mcp-server](https://github.com/haris-musa/excel-mcp-server) 🐍 🏠 - Un server per la manipolazione di Excel che offre creazione di workbook, operazioni sui dati, formattazione e funzionalità avanzate (grafici, tabelle pivot, formule).
- [higress-group/higress-ops-mcp-server](https://github.com/higress-group/higress-ops-mcp-server) 🐍 🏠 - Server MCP che fornisce strumenti completi per la gestione delle configurazioni e delle operazioni del gateway [Higress](https://github.com/alibaba/higress).
- [hijaz/postmancer](https://github.com/hijaz/postmancer) 📇 🏠 - Un server MCP per sostituire client Rest come Postman/Insomnia, consentendo al tuo LLM di mantenere e utilizzare collezioni di API.
- [hloiseaufcms/mcp-gopls](https://github.com/hloiseaufcms/mcp-gopls) 🏎️ 🏠 - Un server MCP per interagire con il [Go Language Server Protocol (gopls)](https://github.com/golang/tools/tree/master/gopls) e beneficiare di funzionalità avanzate di analisi del codice Go.
- [hungthai1401/bruno-mcp](https://github.com/hungthai1401/bruno-mcp) 📇 🏠 - Un server MCP per interagire con il [Bruno API Client](https://www.usebruno.com/).
- [hyperb1iss/droidmind](https://github.com/hyperb1iss/droidmind) 🐍 🏠 - Controlla dispositivi Android con l'AI tramite MCP, abilitando il controllo del dispositivo, il debugging, l'analisi di sistema e l'automazione UI con un framework di sicurezza completo.
- [XixianLiang/HarmonyOS-mcp-server](https://github.com/XixianLiang/HarmonyOS-mcp-server) 🐍 🏠 - Controlla dispositivi HarmonyOS-next con l'AI tramite MCP. Supporta il controllo del dispositivo e l'automazione UI.
- [IlyaGulya/gradle-mcp-server](https://github.com/IlyaGulya/gradle-mcp-server) 🏠 - Integrazione Gradle tramite Gradle Tooling API per ispezionare progetti, eseguire task e test con reporting dei risultati per ogni test.
- [InhiblabCore/mcp-image-compression](https://github.com/InhiblabCore/mcp-image-compression) 🐍 🏠 - Server MCP per la compressione locale di vari formati di immagini.
- [isaacphi/mcp-language-server](https://github.com/isaacphi/mcp-language-server) 🏎️ 🏠 - MCP Language Server aiuta i client MCP abilitati a navigare più facilmente nei codebase fornendo strumenti semantici come ottieni definizione, riferimenti, rinomina e diagnostica.
- [ios-simulator-mcp](https://github.com/joshuayoes/ios-simulator-mcp) 📇 🏠 🍎 - Un server Model Context Protocol (MCP) per interagire con simulatori iOS. Questo server permette di ottenere informazioni sui simulatori, controllare interazioni UI e ispezionare elementi UI.
- [InditexTech/mcp-server-simulator-ios-idb](https://github.com/InditexTech/mcp-server-simulator-ios-idb) 📇 🏠 🍎 - Un server Model Context Protocol (MCP) che consente agli LLM di interagire con simulatori iOS (iPhone, iPad, ecc.) tramite comandi in linguaggio naturale.
- [IvanAmador/vercel-ai-docs-mcp](https://github.com/IvanAmador/vercel-ai-docs-mcp) 📇 🏠 - Un server Model Context Protocol (MCP) che fornisce ricerca AI e capacità di interrogazione per la documentazione Vercel AI SDK.
- [j4c0bs/mcp-server-sql-analyzer](https://github.com/j4c0bs/mcp-server-sql-analyzer) 🐍 - Server MCP che fornisce analisi SQL, linting e conversione di dialetti usando [SQLGlot](https://github.com/tobymao/sqlglot)
- [jasonjmcghee/claude-debugs-for-you](https://github.com/jasonjmcghee/claude-debugs-for-you) 📇 🏠 - Un server MCP e un'estensione VS Code che abilita il debugging automatico (agnostico rispetto al linguaggio) tramite breakpoint e valutazione delle espressioni.
- [jetbrains/mcpProxy](https://github.com/JetBrains/mcpProxy) 🎖️ 📇 🏠 - Connessione a JetBrains IDE
- [qainsights/jmeter-mcp-server](https://github.com/QAInsights/jmeter-mcp-server) 🐍 🏠 - Server JMeter MCP per test di performance
- [Jktfe/serveMyAPI](https://github.com/Jktfe/serveMyAPI) 📇 🏠 🍎 - Un server MCP personale per memorizzare e accedere in modo sicuro alle chiavi API tra progetti usando il Portachiavi macOS.
- [joshuarileydev/app-store-connect-mcp-server](https://github.com/JoshuaRileyDev/app-store-connect-mcp-server) 📇 🏠 - Un server MCP per comunicare con l'API App Store Connect per sviluppatori iOS
- [joshuarileydev/simulator-mcp-server](https://github.com/JoshuaRileyDev/simulator-mcp-server) 📇 🏠 - Un server MCP per controllare i simulatori iOS
- [qainsights/k6-mcp-server](https://github.com/QAInsights/k6-mcp-server) 🐍 🏠 - Server Grafana k6 MCP per test di performance
- [lamemind/mcp-server-multiverse](https://github.com/lamemind/mcp-server-multiverse) 📇 🏠 🛠️ - Un server middleware che consente la coesistenza indipendente di più istanze isolate dello stesso server MCP con namespace e configurazioni unici.
- [langfuse/mcp-server-langfuse](https://github.com/langfuse/mcp-server-langfuse) 🐍 🏠 - Server MCP per accedere e gestire i prompt delle applicazioni LLM creati con [Langfuse]([https://langfuse.com/](https://langfuse.com/docs/prompts/get-started)) Prompt Management.
- [mobile-next/mobile-mcp](https://github.com/mobile-next/mobile-mcp) 📇 🏠 🐧 🍎 - Server MCP per automazione, sviluppo e scraping di applicazioni e dispositivi Android/iOS. Supporta simulatori/emulatori/dispositivi fisici come iPhone, Google Pixel, Samsung.
- [qainsights/locust-mcp-server](https://github.com/QAInsights/locust-mcp-server) 🐍 🏠 - Server Locust MCP per test di performance
- [mrexodia/user-feedback-mcp](https://github.com/mrexodia/user-feedback-mcp) 🐍 🏠 - Semplice server MCP per abilitare un workflow human-in-the-loop in strumenti come Cline e Cursor.
- [narumiruna/gitingest-mcp](https://github.com/narumiruna/gitingest-mcp) 🐍 🏠 - Un server MCP che utilizza [gitingest](https://github.com/cyclotruc/gitingest) per convertire qualsiasi repository Git in un semplice digest testuale del suo codebase.
- [OctoMind-dev/octomind-mcp](https://github.com/OctoMind-dev/octomind-mcp) 📇 ☁️ - consente al tuo agente AI preferito di creare ed eseguire test end-to-end completamente gestiti [Octomind](https://www.octomind.dev/) dal tuo codebase o da altre fonti dati come Jira, Slack o TestRail.
- [kadykov/mcp-openapi-schema-explorer](https://github.com/kadykov/mcp-openapi-schema-explorer) 📇 ☁️ 🏠 - Accesso efficiente ai token delle specifiche OpenAPI/Swagger tramite risorse MCP.
- [pskill9/website-downloader](https://github.com/pskill9/website-downloader) 🗄️ 🚀 - Questo server MCP fornisce uno strumento per scaricare interi siti web usando wget. Preserva la struttura del sito e converte i collegamenti per funzionare localmente.
- [utensils/mcp-nixos](https://github.com/utensils/mcp-nixos) 🐍 🏠 - Server MCP che fornisce informazioni accurate sui pacchetti NixOS, opzioni di sistema, configurazioni Home Manager e impostazioni nix-darwin macOS per prevenire allucinazioni AI.
- [QuantGeekDev/docker-mcp](https://github.com/QuantGeekDev/docker-mcp) 🏎️ 🏠 - Gestione e operazioni di container Docker tramite MCP
- [ckreiling/mcp-server-docker](https://github.com/ckreiling/mcp-server-docker) 🐍 🏠 - Integrazione con Docker per gestire container, immagini, volumi e reti.
- [r-huijts/xcode-mcp-server](https://github.com/r-huijts/xcode-mcp-server) 📇 🏠 🍎 - Integrazione Xcode per gestione progetti, operazioni su file e automazione build
- [ReAPI-com/mcp-openapi](https://github.com/ReAPI-com/mcp-openapi) 📇 🏠 - Server MCP che consente agli LLM di conoscere tutto sulle tue specifiche OpenAPI per scoprire, spiegare e generare codice/mock data
- [Rootly-AI-Labs/Rootly-MCP-server](https://github.com/Rootly-AI-Labs/Rootly-MCP-server) 🎖️ 🐍 ☁️ 🍎 - Server MCP per la piattaforma di gestione degli incidenti [Rootly](https://rootly.com/).
- [sammcj/mcp-package-version](https://github.com/sammcj/mcp-package-version) 📇 🏠 - Un server MCP per aiutare gli LLM a suggerire l'ultima versione stabile dei pacchetti durante la scrittura di codice.
- [sapientpants/sonarqube-mcp-server](https://github.com/sapientpants/sonarqube-mcp-server) 🦀 ☁️ 🏠 - Un server Model Context Protocol (MCP) che si integra con SonarQube per fornire agli assistenti AI l'accesso a metriche di qualità del codice, problemi e stati dei quality gate
- [SDGLBL/mcp-claude-code](https://github.com/SDGLBL/mcp-claude-code) 🐍 🏠 - Un'implementazione delle capacità di Claude Code tramite MCP, che abilita la comprensione, modifica e analisi di progetti di codice AI con supporto completo agli strumenti.
- [snaggle-ai/openapi-mcp-server](https://github.com/snaggle-ai/openapi-mcp-server) 🏎️ 🏠 - Collega qualsiasi server HTTP/REST API usando una specifica OpenAPI (v3)
- [stass/lldb-mcp](https://github.com/stass/lldb-mcp) 🐍 🏠 🐧 🍎 - Un server MCP per LLDB che abilita analisi binarie e di core file, debugging e disassemblaggio AI.
- [TencentEdgeOne/edgeone-pages-mcp](https://github.com/TencentEdgeOne/edgeone-pages-mcp) 📇 ☁️ - Un servizio MCP per distribuire contenuti HTML su EdgeOne Pages e ottenere un URL pubblicamente accessibile.
- [tumf/mcp-text-editor](https://github.com/tumf/mcp-text-editor) 🐍 🏠 - Un editor di file di testo orientato alle linee. Ottimizzato per strumenti LLM con accesso efficiente a file parziali per minimizzare l'uso di token.
- [vivekvells/mcp-pandoc](https://github.com/vivekVells/mcp-pandoc) 🗄️ 🚀 - Server MCP per la conversione senza soluzione di continuità dei formati di documento tramite Pandoc, supportando Markdown, HTML, PDF, DOCX (.docx), csv e altro.
- [VSCode Devtools](https://github.com/biegehydra/BifrostMCP) 📇 - Connettiti all'IDE VSCode e usa strumenti semantici come `find_usages`
- [xcodebuild](https://github.com/ShenghaiWang/xcodebuild) 🍎 Compila workspace/progetti Xcode iOS e restituisce errori al llm.
- [xzq.xu/jvm-mcp-server](https://github.com/xzq-xu/jvm-mcp-server) 📇 🏠  - Un progetto di implementazione di un server MCP (Model Context Protocol) basato su JVM.
- [yangkyeongmo@/mcp-server-apache-airflow](https://github.com/yangkyeongmo/mcp-server-apache-airflow) 🐍 🏠 - Server MCP che si connette ad [Apache Airflow](https://airflow.apache.org/) utilizzando il client ufficiale.
- [YuChenSSR/mindmap-mcp-server](https://github.com/YuChenSSR/mindmap-mcp-server) 🐍 🏠 - Un server Model Context Protocol (MCP) per generare una mappa mentale interattiva e bella.
- [YuChenSSR/multi-ai-advisor](https://github.com/YuChenSSR/multi-ai-advisor-mcp) 📇 🏠 - Un server Model Context Protocol (MCP) che interroga più modelli Ollama e combina le loro risposte, offrendo diverse prospettive AI su una singola domanda.
- [yWorks/mcp-typescribe](https://github.com/yWorks/mcp-typescribe) 📇 🏠 - Server MCP che fornisce informazioni API Typescript in modo efficiente all'agente per consentirgli di lavorare con API non addestrate
- [zcaceres/fetch-mcp](https://github.com/zcaceres/fetch-mcp) 📇 🏠 - Un server MCP per recuperare in modo flessibile dati JSON, testo e HTML
- [zenml-io/mcp-zenml](https://github.com/zenml-io/mcp-zenml) 🐍 🏠 ☁️ - Un server MCP per connettersi alle pipeline MLOps e LLMOps [ZenML](https://www.zenml.io)
- [idosal/git-mcp](https://github.com/idosal/git-mcp) 📇 ☁️ - [gitmcp.io](https://gitmcp.io/) è un server MCP remoto generico per connettersi a QUALSIASI repository o progetto [GitHub](https://www.github.com) per la documentazione
- [tgeselle/bugsnag-mcp](https://github.com/tgeselle/bugsnag-mcp) 📇 ☁️ - Un server MCP per interagire con [Bugsnag](https://www.bugsnag.com/)
- [jordandalton/restcsv-mcp-server](https://github.com/JordanDalton/RestCsvMcpServer) 📇 ☁️ - Un server MCP per file CSV.
- [cjo4m06/mcp-shrimp-task-manager](https://github.com/cjo4m06/mcp-shrimp-task-manager) 📇 ☁️ 🏠 – Un sistema di gestione task orientato alla programmazione che potenzia agenti di coding come Cursor AI con memoria avanzata dei task, auto-riflessione e gestione delle dipendenze. [ShrimpTaskManager](https://cjo4m06.github.io/mcp-shrimp-task-manager)
- [axliupore/mcp-code-runner](https://github.com/axliupore/mcp-code-runner) 📇 🏠 - Un server MCP per eseguire codice localmente tramite Docker e supportare più linguaggi di programmazione.
- [yikakia/godoc-mcp-server](https://github.com/yikakia/godoc-mcp-server) 🏎️ ☁️ 🪟 🐧 🍎 - Interroga informazioni sui pacchetti Go su pkg.go.dev
- [ckanthony/gin-mcp](https://github.com/ckanthony/gin-mcp) 🏎️ ☁️ 📟 🪟 🐧 🍎 - Una libreria Go a configurazione zero per esporre automaticamente le API del framework web Gin come strumenti MCP.
- [ryan0204/github-repo-mcp](https://github.com/Ryan0204/github-repo-mcp) 📇 ☁️ 🪟 🐧 🍎 - GitHub Repo MCP permette ai tuoi assistenti AI di esplorare repository GitHub, navigare tra directory e visualizzare i contenuti dei file.
- [alimo7amed93/webhook-tester-mcp](https://github.com/alimo7amed93/webhook-tester-mcp)  🐍 ☁️ – Un server FastMCP per interagire con webhook-test.com. Permette agli utenti di creare, recuperare ed eliminare webhook localmente usando Claude.
- [lpigeon/ros-mcp-server](https://github.com/lpigeon/ros-mcp-server) 🐍 🏠 🍎 🪟 🐧 - Il ROS MCP Server supporta il controllo dei robot convertendo i comandi in linguaggio naturale in comandi di controllo ROS o ROS2.
- [jsdelivr/globalping-mcp-server](https://github.com/jsdelivr/globalping-mcp-server) 🎖️ 📇 ☁️ - Il server Globalping MCP fornisce accesso a strumenti di rete come ping, traceroute, mtr, HTTP e DNS resolve da migliaia di località nel mondo.
- [posthog/mcp](https://github.com/posthog/mcp) 🎖️ 📇 ☁️ - Un server MCP per interagire con PostHog analytics, feature flags, error tracking e altro.
- [artmann/package-registry-mcp](https://github.com/artmann/package-registry-mcp) 🏠 📇 🍎 🪟 🐧 - Server MCP per cercare e ottenere informazioni aggiornate su pacchetti NPM, Cargo, PyPi e NuGet.

### 🔒 <a name="delivery"></a>Delivery

- [https://github.com/jordandalton/doordash-mcp-server](https://github.com/JordanDalton/DoorDash-MCP-Server) 🐍 – DoorDash Delivery (Non ufficiale)

### 🧮 <a name="data-science-tools"></a>Strumenti Data Science

Integrazioni e strumenti progettati per semplificare l’esplorazione dei dati, l’analisi e migliorare i flussi di lavoro di data science.

- [ChronulusAI/chronulus-mcp](https://github.com/ChronulusAI/chronulus-mcp) 🐍 ☁️ - Prevedi qualsiasi cosa con agenti di forecasting e prediction di Chronulus AI.
- [reading-plus-ai/mcp-server-data-exploration](https://github.com/reading-plus-ai/mcp-server-data-exploration) 🐍 ☁️ - Abilita l’esplorazione autonoma di dati su dataset basati su .csv, fornendo insight intelligenti con sforzo minimo.
- [zcaceres/markdownify-mcp](https://github.com/zcaceres/markdownify-mcp) 📇 🏠 - Un server MCP per convertire quasi qualsiasi file o contenuto web in Markdown
- [datalayer/jupyter-mcp-server](https://github.com/datalayer/jupyter-mcp-server) 🐍 🏠 - Model Context Protocol (MCP) Server per Jupyter.
- [jjsantos01/jupyter-notebook-mcp](https://github.com/jjsantos01/jupyter-notebook-mcp) 🐍 🏠 - Collega Jupyter Notebook a Claude AI, permettendo a Claude di interagire e controllare direttamente i notebook Jupyter.
- [arrismo/kaggle-mcp](https://github.com/arrismo/kaggle-mcp) 🐍 ☁️ - Connette a Kaggle, con capacità di scaricare e analizzare dataset.
- [kdqed/zaturn](https://github.com/kdqed/zaturn) 🐍 🏠 🪟 🐧 🍎 - Collega più fonti dati (SQL, CSV, Parquet, ecc.) e chiedi all'AI di analizzare i dati per insight e visualizzazioni.
- [mckinsey/vizro-mcp](https://github.com/mckinsey/vizro/tree/main/vizro-mcp) 🎖️ 🐍 🏠 - Strumenti e template per creare grafici e dashboard di dati validati e mantenibili.
- [growthbook/growthbook-mcp](https://github.com/growthbook/growthbook-mcp) 🎖️ 📇 🏠 🪟 🐧 🍎 — Strumenti per creare e interagire con feature flag ed esperimenti GrowthBook.

### 📟 <a name="embedded-system"></a>Sistemi Embedded

Fornisce accesso a documentazione e scorciatoie per lavorare su dispositivi embedded.

- [horw/esp-mcp](https://github.com/horw/esp-mcp) 📟 - Workflow per risolvere problemi di build nei chip della serie ESP32 utilizzando ESP-IDF.
- [kukapay/modbus-mcp](https://github.com/kukapay/modbus-mcp) 🐍 📟 - Un server MCP che standardizza e contestualizza dati industriali Modbus.
- [kukapay/opcua-mcp](https://github.com/kukapay/opcua-mcp) 🐍 📟 - Un server MCP che si connette a sistemi industriali abilitati OPC UA.
- [yoelbassin/gnuradioMCP](https://github.com/yoelbassin/gnuradioMCP) 🐍 📟 🏠 - Un server MCP per GNU Radio che consente agli LLM di creare e modificare autonomamente flowchart RF `.grc`.

### 📂 <a name="file-systems"></a>File Systems

Fornisce accesso diretto ai file system locali con permessi configurabili. Consente ai modelli AI di leggere, scrivere e gestire file all’interno di directory specificate.

- [cyberchitta/llm-context.py](https://github.com/cyberchitta/llm-context.py) 🐍 🏠 - Condividi contesto di codice con LLM tramite MCP o clipboard
- [exoticknight/mcp-file-merger](https://github.com/exoticknight/mcp-file-merger) 🏎️ 🏠 - Strumento di merge file, adatto ai limiti di lunghezza chat AI.
- [filesystem@quarkiverse/quarkus-mcp-servers](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/filesystem) ☕ 🏠 - Un filesystem che consente la navigazione e la modifica dei file, implementato in Java usando Quarkus. Disponibile come jar o immagine nativa.
- [hmk/box-mcp-server](https://github.com/hmk/box-mcp-server) 📇 ☁️ - Integrazione Box per elencare, leggere e cercare file
- [mamertofabian/mcp-everything-search](https://github.com/mamertofabian/mcp-everything-search) 🐍 🏠 🪟 - Ricerca rapida di file su Windows tramite Everything SDK
- [mark3labs/mcp-filesystem-server](https://github.com/mark3labs/mcp-filesystem-server) 🏎️ 🏠 - Implementazione in Golang per l’accesso al file system locale.
- [mickaelkerjean/filestash](https://github.com/mickael-kerjean/filestash/tree/master/server/plugin/plg_handler_mcp) 🏎️ ☁️ - Accesso a Storage Remoto: SFTP, S3, FTP, SMB, NFS, WebDAV, GIT, FTPS, gcloud, azure blob, sharepoint, ecc.
- [microsoft/markitdown](https://github.com/microsoft/markitdown/tree/main/packages/markitdown-mcp) 🎖️ 🐍 🏠 - Accesso MCP a MarkItDown -- una libreria che converte molti formati di file (locali o remoti) in Markdown per il consumo da parte di LLM.
- [modelcontextprotocol/server-filesystem](https://github.com/modelcontextprotocol/servers/tree/main/src/filesystem) 📇 🏠 - Accesso diretto al file system locale.
- [modelcontextprotocol/server-google-drive](https://github.com/modelcontextprotocol/servers/tree/main/src/gdrive) 📇 ☁️ - Integrazione Google Drive per elencare, leggere e cercare file
- [Xuanwo/mcp-server-opendal](https://github.com/Xuanwo/mcp-server-opendal) 🐍 🏠 ☁️ - Accedi a qualsiasi storage con Apache OpenDAL™
- [jeannier/homebrew-mcp](https://github.com/jeannier/homebrew-mcp) 🐍 🏠 🍎 - Controlla la tua configurazione Homebrew su macOS usando il linguaggio naturale tramite questo server MCP. Gestisci facilmente i tuoi pacchetti, richiedi suggerimenti, risolvi problemi di brew ecc.

### 💰 <a name="finance--fintech"></a>Finanza & Fintech

Strumenti di accesso e analisi dei dati finanziari. Permette ai modelli AI di lavorare con dati di mercato, piattaforme di trading e informazioni finanziarie.

- [aaronjmars/web3-research-mcp](https://github.com/aaronjmars/web3-research-mcp) 📇 ☁️ - Ricerca avanzata per crypto - gratuita & completamente locale
- [alchemy/alchemy-mcp-server](https://github.com/alchemyplatform/alchemy-mcp-server) 🎖️ 📇 ☁️ - Permette agli agenti AI di interagire con le API blockchain di Alchemy.
- [OctagonAI/octagon-mcp-server](https://github.com/OctagonAI/octagon-mcp-server) 🐍 ☁️ - Agenti AI Octagon per integrare dati di mercato privati e pubblici
- [anjor/coinmarket-mcp-server](https://github.com/anjor/coinmarket-mcp-server) 🐍 ☁️ - Integrazione API Coinmarket per recuperare elenchi e quotazioni di criptovalute
- [ariadng/metatrader-mcp-server](https://github.com/ariadng/metatrader-mcp-server) 🐍 🏠 🪟 - Permette agli LLM AI di eseguire operazioni di trading usando la piattaforma MetaTrader 5
- [armorwallet/armor-crypto-mcp](https://github.com/armorwallet/armor-crypto-mcp) 🐍 ☁️ - MCP per interfacciarsi con più blockchain, staking, DeFi, swap, bridging, gestione wallet, DCA, ordini limite, ricerca monete, tracking e altro.
- [bankless/onchain-mcp](https://github.com/Bankless/onchain-mcp/) 📇 ☁️ - API Bankless Onchain per interagire con smart contract, interrogare informazioni su transazioni e token
- [base/base-mcp](https://github.com/base/base-mcp) 🎖️ 📇 ☁️ - Integrazione Base Network per strumenti onchain, consente interazione con Base Network e API Coinbase per gestione wallet, trasferimenti fondi, smart contract e operazioni DeFi
- [berlinbra/alpha-vantage-mcp](https://github.com/berlinbra/alpha-vantage-mcp) 🐍 ☁️ - Integrazione API Alpha Vantage per recuperare informazioni su azioni e criptovalute
- [ahnlabio/bicscan-mcp](https://github.com/ahnlabio/bicscan-mcp) 🎖️ 🐍 ☁️ - Punteggio di rischio / asset holdings di indirizzi blockchain EVM (EOA, CA, ENS) e anche nomi di dominio.
- [bitteprotocol/mcp](https://github.com/BitteProtocol/mcp) 📇 - Integrazione Bitte Protocol per eseguire AI Agents su diverse blockchain.
- [chargebee/mcp](https://github.com/chargebee/agentkit/tree/main/modelcontextprotocol) 🎖️ 📇 ☁️ - MCP Server che collega gli agenti AI alla [piattaforma Chargebee](https://www.chargebee.com/).
- [codex-data/codex-mcp](https://github.com/Codex-Data/codex-mcp) 🎖️ 📇 ☁️ - Integrazione [Codex API](https://www.codex.io) per dati blockchain e di mercato arricchiti in tempo reale su oltre 60 reti
- [coinpaprika/dexpaprika-mcp](https://github.com/chargebee/agentkit/tree/main/modelcontextprotocol) 🎖️ 📇 ☁️ 🍎 🪟 🐧 - Il server MCP DexPaprika di Coinpaprika espone le API [DexPaprika](https://docs.dexpaprika.com) ad alte prestazioni su 20+ chain e 5M+ token con prezzi in tempo reale, dati pool di liquidità & dati storici OHLCV, offrendo agli agenti AI accesso standardizzato a dati di mercato completi tramite Model Context Protocol.
- [doggybee/mcp-server-ccxt](https://github.com/doggybee/mcp-server-ccxt) 📇 ☁️ - Un server MCP per accedere a dati di mercato crypto in tempo reale e trading tramite 20+ exchange usando la libreria CCXT. Supporta spot, futures, OHLCV, bilanci, ordini e altro.
- [ferdousbhai/investor-agent](https://github.com/ferdousbhai/investor-agent) 🐍 ☁️ - Integrazione Yahoo Finance per recuperare dati di mercato azionario inclusi consigli sulle opzioni
- [ferdousbhai/tasty-agent](https://github.com/ferdousbhai/tasty-agent) 🐍 ☁️ - Integrazione API Tastyworks per gestire attività di trading su Tastytrade
- [ferdousbhai/wsb-analyst-mcp](https://github.com/ferdousbhai/wsb-analyst-mcp) 🐍 ☁️ - Integrazione Reddit per analizzare i contenuti della community WallStreetBets
- [getalby/nwc-mcp-server](https://github.com/getalby/nwc-mcp-server) 📇 🏠 - Integrazione wallet Bitcoin Lightning basata su Nostr Wallet Connect
- [heurist-network/heurist-mesh-mcp-server](https://github.com/heurist-network/heurist-mesh-mcp-server) 🎖️ ⛅️ 🏠 🐍 - Accesso ad agenti AI web3 specializzati per analisi blockchain, audit di sicurezza smart contract, valutazione metriche token e interazioni on-chain tramite la rete Heurist Mesh. Offre strumenti completi per analisi DeFi, valutazione NFT e monitoraggio transazioni su più blockchain
- [intentos-labs/beeper-mcp](https://github.com/intentos-labs/beeper-mcp) 🐍 - Beeper fornisce transazioni su BSC, inclusi trasferimenti di saldo/token, swap su Pancakeswap e richieste di ricompense beeper.
- [kukapay/blockbeats-mcp](https://github.com/kukapay/blockbeats-mcp) 🐍 ☁️ -  Un server MCP che fornisce notizie blockchain e articoli approfonditi da BlockBeats per agenti AI.
- [kukapay/bridge-rates-mcp](https://github.com/kukapay/bridge-rates-mcp) 📇 ☁️ - Fornitura in tempo reale di tassi cross-chain bridge e rotte di trasferimento ottimali per agenti AI onchain.
- [kukapay/chainlink-feeds-mcp](https://github.com/kukapay/chainlink-feeds-mcp) 📇 ☁️ -  Accesso in tempo reale ai price feed decentralizzati on-chain di Chainlink.
- [kukapay/cointelegraph-mcp](https://github.com/kukapay/cointelegraph-mcp) 🐍 ☁️ -  Accesso in tempo reale alle ultime notizie da Cointelegraph.
- [kukapay/crypto-feargreed-mcp](https://github.com/kukapay/crypto-feargreed-mcp) 🐍 ☁️ -  Dati in tempo reale e storici del Crypto Fear & Greed Index.
- [kukapay/crypto-indicators-mcp](https://github.com/kukapay/crypto-indicators-mcp) 🐍 ☁️ - Un server MCP che fornisce una serie di indicatori di analisi tecnica e strategie sulle criptovalute.
- [kukapay/crypto-news-mcp](https://github.com/kukapay/crypto-news-mcp) 🐍 ☁️ - Un server MCP che fornisce notizie crypto in tempo reale da NewsData per agenti AI.
- [kukapay/crypto-portfolio-mcp](https://github.com/kukapay/crypto-portfolio-mcp) 🐍 ☁️ - Un server MCP per monitorare e gestire le allocazioni di portafoglio di criptovalute.
- [kukapay/crypto-rss-mcp](https://github.com/kukapay/crypto-rss-mcp) 🐍 ☁️ - Un server MCP che aggrega notizie crypto in tempo reale da diversi feed RSS.
- [kukapay/crypto-sentiment-mcp](https://github.com/kukapay/crypto-sentiment-mcp) 🐍 ☁️ - Un server MCP che fornisce analisi del sentiment delle criptovalute agli agenti AI.
- [kukapay/crypto-trending-mcp](https://github.com/kukapay/crypto-trending-mcp) 🐍 ☁️ - Tracciamento dei token di tendenza su CoinGecko.
- [kukapay/crypto-whitepapers-mcp](https://github.com/kukapay/crypto-whitepapers-mcp) 🐍 ☁️ - Funziona come base di conoscenza strutturata dei whitepaper crypto.
- [kukapay/cryptopanic-mcp-server](https://github.com/kukapay/cryptopanic-mcp-server) 🐍 ☁️ - Fornisce le ultime notizie sulle criptovalute ad agenti AI, alimentato da CryptoPanic.
- [kukapay/defi-yields-mcp](https://github.com/kukapay/defi-yields-mcp) 🐍 ☁️ - Un server MCP per esplorare opportunità di rendimento DeFi per agenti AI.
- [kukapay/dune-analytics-mcp](https://github.com/kukapay/dune-analytics-mcp) 🐍 ☁️ -  Un server MCP che collega i dati di Dune Analytics agli agenti AI.
- [kukapay/etf-flow-mcp](https://github.com/kukapay/etf-flow-mcp) 🐍 ☁️ -  Fornitura di dati sui flussi degli ETF crypto per supportare il processo decisionale degli agenti AI.
- [kukapay/freqtrade-mcp](https://github.com/kukapay/freqtrade-mcp) 🐍 ☁️ - Un server MCP che si integra con il bot di trading crypto Freqtrade.
- [kukapay/funding-rates-mcp](https://github.com/kukapay/funding-rates-mcp) 🐍 ☁️ - Fornitura di dati in tempo reale sui funding rate tra i principali exchange crypto.
- [kukapay/jupiter-mcp](https://github.com/kukapay/jupiter-mcp) 🐍 ☁️ - Un server MCP per eseguire swap di token sulla blockchain Solana tramite la nuova Ultra API di Jupiter.
- [kukapay/pancakeswap-poolspy-mcp](https://github.com/kukapay/pancakeswap-poolspy-mcp) 🐍 ☁️ -  Un server MCP che traccia le nuove pool create su Pancake Swap.
- [kukapay/rug-check-mcp](https://github.com/kukapay/rug-check-mcp) 🐍 ☁️ - Un server MCP che rileva rischi potenziali nei meme token Solana.
- [kukapay/thegraph-mcp](https://github.com/kukapay/thegraph-mcp) 🐍 ☁️ -  Un server MCP che fornisce dati indicizzati da The Graph agli agenti AI.
- [kukapay/token-minter-mcp](https://github.com/kukapay/token-minter-mcp) 🐍 ☁️ -  Un server MCP che fornisce strumenti per agenti AI per mintare token ERC-20 su più blockchain.
- [kukapay/token-revoke-mcp](https://github.com/kukapay/token-revoke-mcp) 🐍 ☁️ - Un server MCP per controllare e revocare le autorizzazioni dei token ERC-20 su più blockchain.
- [kukapay/twitter-username-changes-mcp](https://github.com/kukapay/twitter-username-changes-mcp) 🐍 ☁️ - Un server MCP che traccia i cambi di username storici su Twitter.
- [kukapay/uniswap-poolspy-mcp](https://github.com/kukapay/uniswap-poolspy-mcp) 🐍 ☁️ -  Un server MCP che traccia le nuove pool di liquidità su Uniswap su più blockchain.
- [kukapay/uniswap-trader-mcp](https://github.com/kukapay/uniswap-trader-mcp) 🐍 ☁️ -  Un server MCP per automatizzare swap di token su Uniswap DEX su più blockchain da parte di agenti AI.
- [kukapay/whale-tracker-mcp](https://github.com/kukapay/whale-tracker-mcp) 🐍 ☁️ -  Un server MCP per tracciare le transazioni dei “whale” crypto.
- [laukikk/alpaca-mcp](https://github.com/laukikk/alpaca-mcp) 🐍 ☁️ - Un server MCP per l’API trading di Alpaca per gestire portafogli azionari e crypto, piazzare ordini e accedere ai dati di mercato.
- [longportapp/openapi](https://github.com/longportapp/openapi/tree/main/mcp) - 🐍 ☁️ - LongPort OpenAPI fornisce dati di mercato azionario in tempo reale, offrendo analisi e capacità di trading tramite MCP agli AI.
- [mcpdotdirect/evm-mcp-server](https://github.com/mcpdotdirect/evm-mcp-server) 📇 ☁️ - Servizi blockchain completi per 30+ reti EVM, supporto per token nativi, ERC20, NFT, smart contract, transazioni e risoluzione ENS.
- [mcpdotdirect/starknet-mcp-server](https://github.com/mcpdotdirect/starknet-mcp-server) 📇 ☁️ - Integrazione completa della blockchain Starknet con supporto per token nativi (ETH, STRK), smart contract, risoluzione StarknetID e trasferimenti di token.
- [minhyeoky/mcp-server-ledger](https://github.com/minhyeoky/mcp-server-ledger) 🐍 🏠 -  Integrazione ledger-cli per la gestione di transazioni finanziarie e generazione di report.
- [openMF/mcp-mifosx](https://github.com/openMF/mcp-mifosx) ☁️ 🏠 -  Integrazione core banking per gestire clienti, prestiti, risparmi, azioni, transazioni finanziarie e generazione report finanziari.
- [narumiruna/yfinance-mcp](https://github.com/narumiruna/yfinance-mcp) 🐍 ☁️ - Un server MCP che usa yfinance per ottenere informazioni da Yahoo Finance.
- [polygon-io/mcp_polygon)](https://github.com/polygon-io/mcp_polygon)) 🐍 ☁️ -  Un server MCP che fornisce accesso alle API dati finanziari di [Polygon.io](https://polygon.io/) per azioni, indici, forex, opzioni e altro.
- [pwh-pwh/coin-mcp-server](https://github.com/pwh-pwh/coin-mcp-server) 🐍 ☁️ -  API Bitget per recuperare prezzi delle criptovalute.
- [QuantGeekDev/coincap-mcp](https://github.com/QuantGeekDev/coincap-mcp) 📇 ☁️ - Integrazione dati di mercato crypto in tempo reale tramite API pubblica CoinCap, offrendo accesso a prezzi crypto e informazioni di mercato senza chiavi API
- [SaintDoresh/Crypto-Trader-MCP-ClaudeDesktop](https://github.com/SaintDoresh/Crypto-Trader-MCP-ClaudeDesktop.git) 🐍 ☁️ - Uno strumento MCP che fornisce dati di mercato crypto tramite API CoinGecko.
- [tooyipjee/yahoofinance-mcp](https://github.com/tooyipjee/yahoofinance-mcp.git) 📇 ☁️ - Versione TS di yahoo finance mcp.
- [SaintDoresh/YFinance-Trader-MCP-ClaudeDesktop](https://github.com/SaintDoresh/YFinance-Trader-MCP-ClaudeDesktop.git) 🐍 ☁️ - Uno strumento MCP che fornisce dati e analisi di mercato azionario tramite l’API Yahoo Finance.
- [RomThpt/xrpl-mcp-server](https://github.com/RomThpt/mcp-xrpl) 📇 ☁️ - MCP server per XRP Ledger che fornisce accesso a informazioni account, storico transazioni e dati di rete. Permette query su oggetti ledger, invio transazioni e monitoraggio XRPL network.
- [janswist/mcp-dexscreener](https://github.com/janswist/mcp-dexscreener) 📇 ☁️ - Prezzi di mercato on-chain in tempo reale tramite API Dexscreener open e gratuite
- [HuggingAGI/mcp-baostock-server](https://github.com/HuggingAGI/mcp-baostock-server) 🐍 ☁️ - MCP server basato su baostock, con accesso e capacità di analisi per dati del mercato azionario cinese.
- [wowinter13/solscan-mcp](https://github.com/wowinter13/solscan-mcp) 🦀 🏠 - Uno strumento MCP per interrogare transazioni Solana in linguaggio naturale con API Solscan.
- [Wuye-AI/mcp-server-wuye-ai](https://github.com/wuye-ai/mcp-server-wuye-ai) 🎖️ 📇 ☁️ - Un server MCP che interagisce con le capacità della piattaforma CRIC Wuye AI, un assistente intelligente specifico per il settore property management.
- [zlinzzzz/finData-mcp-server](https://github.com/zlinzzzz/finData-mcp-server) 🐍 ☁️ - Un server MCP per accedere a dati finanziari professionali, supportando diversi fornitori come Tushare.

### 🎮 <a name="gaming"></a>Gaming

Integrazione con dati relativi al gaming, motori di gioco e servizi

- [IvanMurzak/Unity-MCP](https://github.com/IvanMurzak/Unity-MCP) #️⃣ 🏠 🍎 🪟 🐧 - MCP Server per Unity Editor e per giochi realizzati con Unity
- [CoderGamester/mcp-unity](https://github.com/CoderGamester/mcp-unity) #️⃣ 🏠 - MCP Server per l’integrazione con il motore di gioco Unity3d per lo sviluppo di videogiochi
- [Coding-Solo/godot-mcp](https://github.com/Coding-Solo/godot-mcp) 📇 🏠 - Un server MCP per interagire con il motore di gioco Godot, fornendo strumenti per editing, esecuzione, debug e gestione delle scene in progetti Godot.
- [pab1ito/chess-mcp](https://github.com/pab1it0/chess-mcp) 🐍 ☁️ - Accedi a dati giocatore Chess.com, partite e altre informazioni pubbliche tramite interfacce MCP standardizzate, permettendo agli assistenti AI di ricercare e analizzare informazioni sugli scacchi.
- [jiayao/mcp-chess](https://github.com/jiayao/mcp-chess) 🐍 🏠 - Un server MCP per giocare a scacchi contro LLM.
- [rishijatia/fantasy-pl-mcp](https://github.com/rishijatia/fantasy-pl-mcp/) 🐍 ☁️ - Un server MCP per dati e strumenti di analisi Fantasy Premier League in tempo reale.
- [opgginc/opgg-mcp](https://github.com/opgginc/opgg-mcp) 📇 ☁️ - Accesso a dati gaming in tempo reale su titoli popolari come League of Legends, TFT e Valorant, con analisi campioni, orari esport, meta composition e statistiche dei personaggi.
- [stefan-xyz/mcp-server-runescape](https://github.com/stefan-xyz/mcp-server-runescape) 📇 - Un server MCP con strumenti per interagire con dati di RuneScape (RS) e Old School RuneScape (OSRS), inclusi prezzi oggetti, hiscore giocatori e altro.

### 🧠 <a name="knowledge--memory"></a>Conoscenza & Memoria

Memoria persistente tramite strutture a grafo di conoscenza. Permette ai modelli AI di mantenere e interrogare informazioni strutturate tra le sessioni.
- [CheMiguel23/MemoryMesh](https://github.com/CheMiguel23/MemoryMesh) 📇 🏠 - Memoria potenziata basata su grafi con un focus su role-play AI e generazione di storie.
- [graphlit-mcp-server](https://github.com/graphlit/graphlit-mcp-server) 📇 ☁️ - Acquisisci qualsiasi cosa da Slack, Discord, siti web, Google Drive, Linear o GitHub in un progetto Graphlit - e poi cerca e recupera conoscenze rilevanti all'interno di un client MCP come Cursor, Windsurf o Cline.
- [hannesrudolph/mcp-ragdocs](https://github.com/hannesrudolph/mcp-ragdocs) 🐍 🏠 - Un'implementazione di server MCP che fornisce strumenti per il recupero e l'elaborazione di documentazione tramite ricerca vettoriale, permettendo agli assistenti AI di arricchire le risposte con il contesto documentale rilevante.
- [jinzcdev/markmap-mcp-server](https://github.com/jinzcdev/markmap-mcp-server) 📇 🏠 - Un server MCP basato su [markmap](https://github.com/markmap/markmap) che converte **Markdown** in **mappe mentali** interattive. Supporta esportazione in più formati (PNG/JPG/SVG), anteprima live nel browser, copia Markdown con un clic e funzionalità di visualizzazione dinamica.
- [kaliaboi/mcp-zotero](https://github.com/kaliaboi/mcp-zotero) 📇 ☁️ - Un connettore per LLM per lavorare con raccolte e fonti sul tuo Zotero Cloud.
- [mcp-summarizer](https://github.com/0xshellming/mcp-summarizer) 📕 ☁️ - Server MCP per la sintesi AI, supporto per diversi tipi di contenuto: testo semplice, pagine web, documenti PDF, libri EPUB, contenuti HTML.
- [mem0ai/mem0-mcp](https://github.com/mem0ai/mem0-mcp) 🐍 🏠 - Un server Model Context Protocol per Mem0 che aiuta a gestire preferenze e modelli di codifica, fornendo strumenti per memorizzare, recuperare e gestire semanticamente implementazioni di codice, best practice e documentazione tecnica in IDE come Cursor e Windsurf.
- [modelcontextprotocol/server-memory](https://github.com/modelcontextprotocol/servers/tree/main/src/memory) 📇 🏠 - Sistema di memoria persistente basato su knowledge graph per mantenere il contesto.
- [pinecone-io/assistant-mcp](https://github.com/pinecone-io/assistant-mcp) 🎖️ 🦀 ☁️ - Si connette al tuo Pinecone Assistant e fornisce all'agente il contesto dal suo motore di conoscenza.
- [@ragieai/mcp-server](https://github.com/ragieai/ragie-mcp-server) 📇 ☁️ - Recupera il contesto dal tuo knowledge base [Ragie](https://www.ragie.ai) (RAG) collegato a integrazioni come Google Drive, Notion, JIRA e altro.
- [TechDocsStudio/biel-mcp](https://github.com/TechDocsStudio/biel-mcp) 📇 ☁️ - Permetti ad AI tools come Cursor, VS Code, o Claude Desktop di rispondere a domande utilizzando la documentazione del tuo prodotto. Biel.ai fornisce il sistema RAG e il server MCP.
- [topoteretes/cognee](https://github.com/topoteretes/cognee/tree/dev/cognee-mcp) 📇 🏠 - Gestore di memoria per app AI e agenti che utilizza vari store grafici e vettoriali e consente l'acquisizione da oltre 30 fonti dati.
- [unibaseio/membase-mcp](https://github.com/unibaseio/membase-mcp) 📇 ☁️ - Salva e interroga la memoria dell'agente in modo distribuito tramite Membase.
- [GistPad-MCP](https://github.com/lostintangent/gistpad-mcp) 📇 🏠 - Usa GitHub Gists per gestire e accedere alla tua conoscenza personale, note quotidiane e prompt riutilizzabili. Funziona come complemento a https://gistpad.dev e l'[estensione GistPad per VS Code](https://aka.ms/gistpad).
- [entanglr/zettelkasten-mcp](https://github.com/entanglr/zettelkasten-mcp) 🐍 🏠 - Un server Model Context Protocol (MCP) che implementa la metodologia di gestione della conoscenza Zettelkasten, permettendo di creare, collegare e cercare note atomiche tramite Claude e altri client compatibili MCP.

### 🗺️ <a name="location-services"></a>Servizi di Localizzazione

Servizi basati sulla posizione e strumenti di mappatura. Permette ai modelli AI di lavorare con dati geografici, informazioni meteo e analisi basate sulla posizione.

- [briandconnelly/mcp-server-ipinfo](https://github.com/briandconnelly/mcp-server-ipinfo) 🐍 ☁️  - Geolocalizzazione degli indirizzi IP e informazioni di rete tramite API IPInfo.
- [devilcoder01/weather-mcp-server](https://github.com/devilcoder01/weather-mcp-server) 🐍 ☁️ - Accesso ai dati meteo in tempo reale per qualsiasi località tramite l'API WeatherAPI.com, con previsioni dettagliate e condizioni attuali.
- [jagan-shanmugam/open-streetmap-mcp](https://github.com/jagan-shanmugam/open-streetmap-mcp) 🐍 🏠 - Un server MCP OpenStreetMap con servizi basati sulla posizione e dati geospaziali.
- [kukapay/nearby-search-mcp](https://github.com/kukapay/nearby-search-mcp) 🐍 ☁️ - Un server MCP per la ricerca di luoghi vicini con rilevamento posizione basato su IP.
- [modelcontextprotocol/server-google-maps](https://github.com/modelcontextprotocol/servers/tree/main/src/google-maps) 📇 ☁️ - Integrazione Google Maps per servizi di localizzazione, routing e dettagli sui luoghi.
- [QGIS MCP](https://github.com/jjsantos01/qgis_mcp) - collega QGIS Desktop a Claude AI tramite MCP. Questa integrazione permette la creazione di progetti assistita da prompt, caricamento layer, esecuzione di codice e altro.
- [SaintDoresh/Weather-MCP-ClaudeDesktop](https://github.com/SaintDoresh/Weather-MCP-ClaudeDesktop.git) 🐍 ☁️ - Uno strumento MCP che fornisce dati meteo in tempo reale, previsioni e informazioni storiche tramite API OpenWeatherMap.
- [rossshannon/Weekly-Weather-mcp](https://github.com/rossshannon/weekly-weather-mcp.git) 🐍 ☁️ - Server MCP per previsioni meteo settimanali che restituisce 7 giorni completi di previsioni dettagliate ovunque nel mondo.
- [SecretiveShell/MCP-timeserver](https://github.com/SecretiveShell/MCP-timeserver) 🐍 🏠 - Accesso all'ora in qualsiasi fuso orario e all'orario locale corrente.
- [TimLukaHorstmann/mcp-weather](https://github.com/TimLukaHorstmann/mcp-weather) 📇 ☁️  - Previsioni meteo accurate tramite AccuWeather API (disponibile piano gratuito).
- [webcoderz/MCP-Geo](https://github.com/webcoderz/MCP-Geo) 🐍 🏠 - Server MCP per geocoding tramite nominatim, ArcGIS, Bing.
- [ipfind/ipfind-mcp-server](https://github.com/ipfind/ipfind-mcp-server) 🐍 ☁️ - Servizio di localizzazione indirizzi IP usando API di [IP Find](https://ipfind.com).
- [mahdin75/geoserver-mcp](https://github.com/mahdin75/geoserver-mcp) 🏠 – Implementazione di server Model Context Protocol (MCP) che collega LLM a GeoServer REST API, permettendo agli assistenti AI di interagire con dati e servizi geospaziali.
- [ipfred/aiwen-mcp-server-geoip](https://github.com/ipfred/aiwen-mcp-server-geoip) 🐍 📇 ☁️ – Server MCP per Aiwen IP Location, ottieni posizione IP di rete utente, dettagli IP (paese, provincia, città, lat, lon, ISP, proprietario, ecc.)

### 🎯 <a name="marketing"></a>Marketing

Strumenti per creare e modificare contenuti di marketing, lavorare con i meta dati web, posizionamento prodotto e guide di editing.

- [gomarble-ai/facebook-ads-mcp-server](https://github.com/gomarble-ai/facebook-ads-mcp-server) 🐍 ☁️ - Server MCP che funge da interfaccia per Facebook Ads, consentendo l'accesso programmato ai dati e alle funzionalità di gestione degli annunci Facebook.
- [open-strategy-partners/osp_marketing_tools](https://github.com/open-strategy-partners/osp_marketing_tools) 🐍 🏠 - Suite di strumenti marketing di Open Strategy Partners che include stile di scrittura, codici editing e creazione di mappe di valore per il marketing di prodotto.
- [nictuku/meta-ads-mcp](https://github.com/nictuku/meta-ads-mcp) 🐍 ☁️ 🏠 - Permette agli agenti AI di monitorare e ottimizzare le performance degli annunci Meta, analizzare metriche di campagne, regolare il targeting, gestire asset creativi e formulare raccomandazioni data-driven per spesa pubblicitaria e impostazioni di campagna tramite integrazione Graph API.
- [marketplaceadpros/amazon-ads-mcp-server](https://github.com/MarketplaceAdPros/amazon-ads-mcp-server) 📇 ☁️  - Permette agli strumenti di interagire con Amazon Advertising, analizzando metriche di campagna e configurazioni.

### 📊 <a name="monitoring"></a>Monitoraggio

Accesso e analisi dei dati di monitoraggio delle applicazioni. Permette ai modelli AI di esaminare report di errori e metriche di performance.

- [netdata/netdata#Netdata](https://github.com/netdata/netdata/blob/master/src/web/mcp/README.md) 🎖️ 🏠 ☁️ 📟 🍎 🪟 🐧 - Scoperta, esplorazione, reporting e analisi delle cause radice usando tutti i dati di osservabilità, inclusi metriche, log, sistemi, container, processi e connessioni di rete.
- [grafana/mcp-grafana](https://github.com/grafana/mcp-grafana) 🎖️ 🐍 🏠 ☁️ - Cerca dashboard, indaga incidenti e interroga sorgenti dati nella tua istanza Grafana.
- [tumf/grafana-loki-mcp](https://github.com/tumf/grafana-loki-mcp) 🐍 🏠 - Server MCP che permette interrogazioni dei log Loki tramite API Grafana.
- [hyperb1iss/lucidity-mcp](https://github.com/hyperb1iss/lucidity-mcp) 🐍 🏠 - Migliora la qualità del codice generato da AI tramite analisi intelligente guidata da prompt su 10 dimensioni critiche da complessità a vulnerabilità di sicurezza.
- [last9/last9-mcp-server](https://github.com/last9/last9-mcp-server) - Porta senza soluzione di continuità il contesto di produzione in tempo reale—log, metriche, e trace—nel tuo ambiente locale per correggere il codice più velocemente.
- [metoro-io/metoro-mcp-server](https://github.com/metoro-io/metoro-mcp-server) 🎖️ 🏎️ ☁️ - Interroga e interagisci con ambienti Kubernetes monitorati da Metoro.
- [MindscapeHQ/server-raygun](https://github.com/MindscapeHQ/mcp-server-raygun) 📇 ☁️ - Integrazione API Raygun V3 per crash reporting e monitoraggio reale degli utenti.
- [modelcontextprotocol/server-sentry](https://github.com/modelcontextprotocol/servers/tree/main/src/sentry) 🐍 ☁️ - Integrazione Sentry.io per il monitoraggio degli errori e delle performance.
- [pydantic/logfire-mcp](https://github.com/pydantic/logfire-mcp) 🎖️ 🐍 ☁️ - Fornisce accesso a trace e metriche OpenTelemetry tramite Logfire.
- [seekrays/mcp-monitor](https://github.com/seekrays/mcp-monitor) 🏎️ 🏠 - Strumento di monitoraggio di sistema che espone metriche di sistema tramite Model Context Protocol (MCP). Permette agli LLM di recuperare informazioni di sistema in tempo reale tramite interfaccia compatibile MCP. (supporta CPU, Memoria, Disco, Rete, Host, Processi)
- [VictoriaMetrics-Community/mcp-victoriametrics](https://github.com/VictoriaMetrics-Community/mcp-victoriametrics) 🎖️ 🏎️ 🏠 - Fornisce integrazione completa con le [API di VictoriaMetrics](https://docs.victoriametrics.com/victoriametrics/url-examples/) e [documentazione](https://docs.victoriametrics.com/) per monitoraggio, osservabilità e debug delle tue istanze VictoriaMetrics.

### 🎥 <a name="multimedia-process"></a>Elaborazione Multimedia

Fornisce la possibilità di gestire multimedia come editing audio e video, riproduzione, conversione di formato, includendo anche filtri video, miglioramenti e altro.

- [video-creator/ffmpeg-mcp](https://github.com/video-creator/ffmpeg-mcp.git) 🎥 🔊 - Utilizza la riga di comando ffmpeg per realizzare un server MCP, può essere molto comodo, tramite dialogo permette ricerca, taglio, unione, riproduzione e altre funzioni su video locali.
- [stass/exif-mcp](https://github.com/stass/exif-mcp) 📇 🏠 🐧 🍎 🪟 - Un server MCP che consente di esaminare i metadati delle immagini come EXIF, XMP, JFIF e GPS. Offre la base per la ricerca e analisi di librerie fotografiche e collezioni d'immagini alimentata da LLM.
- [sunriseapps/imagesorcery-mcp](https://github.com/sunriseapps/imagesorcery-mcp) 🐍 🏠 🐧 🍎 🪟 - Magia 🪄 di riconoscimento e modifica immagini basata su Computer Vision per assistenti AI.

### 🔎 <a name="search"></a>Ricerca & Estrazione Dati

- [Xyber-Labs/mcp-server-youtube](https://github.com/Xyber-Labs/mcp-servers/tree/main/mcp-server-youtube) 🐍 ☁️ - Questo repository implementa un server MCP (Model Context Protocol) per la ricerca su YouTube e il recupero dei transcript. Permette ai modelli linguistici o altri agenti di interrogare facilmente i contenuti YouTube tramite un protocollo standardizzato.
- [ricocf/mcp-wolframalpha](https://github.com/ricocf/mcp-wolframalpha) 🐍 🏠 ☁️ - Un server MCP che permette agli assistenti AI di usare l'API Wolfram Alpha per accesso in tempo reale a conoscenza computazionale e dati.
- [scrapeless-ai/scrapeless-mcp-server](https://github.com/scrapeless-ai/scrapeless-mcp-server) 🐍 ☁️ - Il servizio Scrapeless Model Context Protocol agisce come connettore MCP per Google SERP API, abilitando la ricerca web nell'ecosistema MCP senza uscirne.
- [0xdaef0f/job-searchoor](https://github.com/0xDAEF0F/job-searchoor) 📇 🏠 - Un server MCP per la ricerca di offerte di lavoro con filtri su data, parole chiave, opzioni di lavoro remoto e altro.
- [ac3xx/mcp-servers-kagi](https://github.com/ac3xx/mcp-servers-kagi) 📇 ☁️ - Integrazione con l'API di ricerca Kagi.
- [andybrandt/mcp-simple-arxiv](https://github.com/andybrandt/mcp-simple-arxiv) - 🐍 ☁️  MCP per LLM per cercare e leggere articoli da arXiv.
- [hbg/mcp-paperswithcode](https://github.com/hbg/mcp-paperswithcode) - 🐍 ☁️ MCP per cercare tramite l'API PapersWithCode.
- [andybrandt/mcp-simple-pubmed](https://github.com/andybrandt/mcp-simple-pubmed) - 🐍 ☁️  MCP per cercare e leggere articoli medico/scientifici da PubMed.
- [angheljf/nyt](https://github.com/angheljf/nyt) 📇 ☁️ - Ricerca articoli tramite NYTimes API.
- [apify/mcp-server-rag-web-browser](https://github.com/apify/mcp-server-rag-web-browser) 📇 ☁️ - Un server MCP per l'Actor open-source RAG Web Browser di Apify per eseguire ricerche web, scraping di URL e restituzione contenuti in Markdown.
- [Bigsy/Clojars-MCP-Server](https://github.com/Bigsy/Clojars-MCP-Server) 📇 ☁️ - Server MCP Clojars per informazioni aggiornate sulle dipendenze delle librerie Clojure.
- [blazickjp/arxiv-mcp-server](https://github.com/blazickjp/arxiv-mcp-server) ☁️ 🐍 - Ricerca di articoli scientifici ArXiv.
- [luminati-io/brightdata-mcp](https://github.com/luminati-io/brightdata-mcp) 📇 ☁️ - Scopri, estrai e interagisci col web – un'interfaccia che alimenta accesso automatizzato su tutto Internet pubblico.
- [chanmeng/google-news-mcp-server](https://github.com/ChanMeng666/server-google-news) 📇 ☁️ - Integrazione Google News con categorizzazione automatica degli argomenti, supporto multi-lingua e funzionalità di ricerca complete (titoli, storie, argomenti correlati) tramite [SerpAPI](https://serpapi.com/).
- [ConechoAI/openai-websearch-mcp](https://github.com/ConechoAI/openai-websearch-mcp/) 🐍 🏠 ☁️ - Server MCP Python che fornisce lo strumento integrato OpenAI `web_search`.
- [dealx/mcp-server](https://github.com/DealExpress/mcp-server) ☁️ - Server MCP per la piattaforma DealX.
- [devflowinc/trieve](https://github.com/devflowinc/trieve/tree/main/clients/mcp-server) 🎖️ 📇 ☁️ 🏠 - Crawl, embedd, chunk, ricerca e recupera informazioni da dataset tramite [Trieve](https://trieve.ai).
- [Dumpling-AI/mcp-server-dumplingai](https://github.com/Dumpling-AI/mcp-server-dumplingai) 🎖️ 📇 ☁️ - Accesso ad API di dati, scraping web e conversione documenti tramite [Dumpling AI](https://www.dumplingai.com/).
- [erithwik/mcp-hn](https://github.com/erithwik/mcp-hn) 🐍 ☁️ - Un server MCP per cercare Hacker News, ottenere top stories e altro.
- [exa-labs/exa-mcp-server](https://github.com/exa-labs/exa-mcp-server) 🎖️ 📇 ☁️ – Un server Model Context Protocol (MCP) che permette ad assistenti AI come Claude di usare Exa AI Search API per ricerche web, consentendo ai modelli AI di ottenere informazioni in tempo reale in modo sicuro e controllato.
- [fatwang2/search1api-mcp](https://github.com/fatwang2/search1api-mcp) 📇 ☁️ - Ricerca tramite search1api (richiede chiave API a pagamento).
- [genomoncology/biomcp](https://github.com/genomoncology/biomcp) 🐍 ☁️ - Server per ricerca biomedica con accesso a PubMed, ClinicalTrials.gov e MyVariant.info.
- [hellokaton/unsplash-mcp-server](https://github.com/hellokaton/unsplash-mcp-server)) 🐍 ☁️ - Server MCP per ricerca immagini Unsplash.
- [Ihor-Sokoliuk/MCP-SearXNG](https://github.com/ihor-sokoliuk/mcp-searxng) 📇 🏠/☁️ - Server Model Context Protocol per [SearXNG](https://docs.searxng.org).
- [isnow890/naver-search-mcp](https://github.com/isnow890/naver-search-mcp) 📇 ☁️ - Server MCP per integrazione con Naver Search API, supporto a ricerca blog, news, shopping e funzionalità DataLab analytics.
- [jae-jae/fetcher-mcp](https://github.com/jae-jae/fetcher-mcp) 📇 🏠 - Server MCP per acquisizione contenuti di pagine web tramite browser headless Playwright, supporta rendering Javascript, estrazione intelligente del contenuto e output in formato Markdown o HTML.
- [jae-jae/g-search-mcp](https://github.com/jae-jae/g-search-mcp) 📇 🏠 - Potente server MCP per ricerca Google che permette ricerche parallele con più parole chiave contemporaneamente.
- [ananddtyagi/webpage-screenshot-mcp](https://github.com/ananddtyagi/webpage-screenshot-mcp) 📇 🏠 - Server MCP per acquisire screenshot di pagine web da usare come feedback durante lo sviluppo UI.
- [leehanchung/bing-search-mcp](https://github.com/leehanchung/bing-search-mcp) 📇 ☁️ - Funzionalità di ricerca web tramite Microsoft Bing Search API.
- [kagisearch/kagimcp](https://github.com/kagisearch/kagimcp) ☁️ 📇 – Server MCP ufficiale di Kagi Search.
- [kshern/mcp-tavily](https://github.com/kshern/mcp-tavily.git) ☁️ 📇 – API di ricerca Tavily AI
- [mikechao/brave-search-mcp](https://github.com/mikechao/brave-search-mcp) 📇 ☁️ - Capacità di ricerca Web, Immagini, Notizie, Video e Punti di Interesse Locali utilizzando la Brave Search API
- [emicklei/melrose-mcp](https://github.com/emicklei/melrose-mcp) 🏎️ 🏠 - Esegue espressioni musicali [Melrōse](https://melrōse.org) come MIDI
- [modelcontextprotocol/server-brave-search](https://github.com/modelcontextprotocol/servers/tree/main/src/brave-search) 📇 ☁️ - Capacità di ricerca Web utilizzando la Brave Search API
- [modelcontextprotocol/server-fetch](https://github.com/modelcontextprotocol/servers/tree/main/src/fetch) 🐍 🏠 ☁️ - Recupero e elaborazione efficiente di contenuti web per il consumo da parte dell’AI
- [mzxrai/mcp-webresearch](https://github.com/mzxrai/mcp-webresearch) 🔍📚 - Ricerca su Google e ricerca approfondita sul web su qualsiasi argomento
- [nickclyde/duckduckgo-mcp-server](https://github.com/nickclyde/duckduckgo-mcp-server) 🐍 ☁️ - Ricerca Web utilizzando DuckDuckGo
- [r-huijts/opentk-mcp](https://github.com/r-huijts/opentk-mcp) 📇 ☁️ - Accesso alle informazioni del Parlamento Olandese (Tweede Kamer) inclusi documenti, dibattiti, attività e casi legislativi tramite capacità di ricerca strutturata (basato sul progetto opentk di Bert Hubert)
- [reading-plus-ai/mcp-server-deep-research](https://github.com/reading-plus-ai/mcp-server-deep-research) 📇 ☁️ - Server MCP che fornisce ricerca autonoma approfondita in stile OpenAI/Perplexity, elaborazione di query strutturate e report concisi.
- [SecretiveShell/MCP-searxng](https://github.com/SecretiveShell/MCP-searxng) 🐍 🏠 - Un server MCP per connettersi a istanze searXNG
- [takashiishida/arxiv-latex-mcp](https://github.com/takashiishida/arxiv-latex-mcp) 🐍 ☁️ - Ottieni la sorgente LaTeX degli articoli arXiv per gestire contenuti ed equazioni matematiche
- [the0807/GeekNews-MCP-Server](https://github.com/the0807/GeekNews-MCP-Server) 🐍 ☁️ - Un server MCP che recupera ed elabora dati di notizie dal sito GeekNews.
- [tinyfish-io/agentql-mcp](https://github.com/tinyfish-io/agentql-mcp) 🎖️ 📇 ☁️ - Server MCP che fornisce le capacità di estrazione dati di [AgentQL](https://agentql.com).
- [Tomatio13/mcp-server-tavily](https://github.com/Tomatio13/mcp-server-tavily) ☁️ 🐍 – API di ricerca Tavily AI
- [vectorize-io/vectorize-mcp-server](https://github.com/vectorize-io/vectorize-mcp-server/) ☁️ 📇 - Server MCP di [Vectorize](https://vectorize.io) per recupero avanzato, Deep Research privato, estrazione Anything-to-Markdown e segmentazione del testo.
- [webscraping-ai/webscraping-ai-mcp-server](https://github.com/webscraping-ai/webscraping-ai-mcp-server) 🎖️ 📇 ☁️ - Interagisce con [WebScraping.ai](https://webscraping.ai) per estrazione e scraping di dati web.
- [zhsama/duckduckgo-mcp-server](https://github.com/zhsama/duckduckgo-mpc-server/) 📇 🏠 ☁️ - Server MCP basato su TypeScript che fornisce funzionalità di ricerca DuckDuckGo.
- [zoomeye-ai/mcp_zoomeye](https://github.com/zoomeye-ai/mcp_zoomeye) 📇 ☁️ - Ricerca informazioni sugli asset di rete tramite ZoomEye MCP Server
- [yamanoku/baseline-mcp-server](https://github.com/yamanoku/baseline-mcp-server) 📇 🏠 - Server MCP che ricerca lo stato Baseline utilizzando la Web Platform API
- [longevity-genie/biothings-mcp](https://github.com/longevity-genie/biothings-mcp) 🐍 ☁️ - Server MCP per interagire con BioThings API, incluse informazioni su geni, varianti genetiche, farmaci e informazioni tassonomiche
- [joelio/stocky](https://github.com/joelio/stocky) 🐍 ☁️ 🏠 - Un server MCP per la ricerca e il download di fotografie stock royalty-free da Pexels e Unsplash. Include ricerca multi-provider, metadati ricchi, supporto alla paginazione e prestazioni asincrone per aiutare assistenti AI a trovare e accedere a immagini di alta qualità.

### 🔒 <a name="security"></a>Sicurezza

- [LaurieWired/GhidraMCP](https://github.com/LaurieWired/GhidraMCP) ☕ 🏠 - Un server Model Context Protocol per Ghidra che consente agli LLM di fare reverse engineering autonomo delle applicazioni. Fornisce strumenti per decompilare binari, rinominare metodi e dati, ed elencare metodi, classi, importazioni ed esportazioni.
- [dkvdm/onepassword-mcp-server](https://github.com/dkvdm/onepassword-mcp-server) - Un server MCP che permette il recupero sicuro di credenziali da 1Password da usare da parte di AI agentici.
- [firstorderai/authenticator_mcp](https://github.com/firstorderai/authenticator_mcp) 📇 🏠 🍎 🪟 🐧 – Un server MCP (Model Context Protocol) sicuro che consente agli agenti AI di interagire con l’Authenticator App.
- [13bm/GhidraMCP](https://github.com/13bm/GhidraMCP) 🐍 ☕ 🏠 - Server MCP per integrare Ghidra con assistenti AI. Questo plugin abilita l’analisi binaria, fornendo strumenti per l’ispezione delle funzioni, la decompilazione, l’esplorazione della memoria e l’analisi di import/export tramite il Model Context Protocol.
- [atomicchonk/roadrecon_mcp_server](https://github.com/atomicchonk/roadrecon_mcp_server) 🐍 🪟 🏠 Server MCP per analizzare i risultati raccolti da ROADrecon dall’enumerazione di tenant Azure
- [BurtTheCoder/mcp-dnstwist](https://github.com/BurtTheCoder/mcp-dnstwist) 📇 🪟 ☁️ - Server MCP per dnstwist, un potente strumento di fuzzing DNS che aiuta a rilevare typosquatting, phishing e spionaggio aziendale.
- [BurtTheCoder/mcp-maigret](https://github.com/BurtTheCoder/mcp-maigret) 📇 🪟 ☁️ - Server MCP per maigret, uno strumento OSINT che raccoglie informazioni sugli account utente da varie fonti pubbliche. Questo server fornisce strumenti per la ricerca di username su social network e l’analisi di URL.
- [BurtTheCoder/mcp-shodan](https://github.com/BurtTheCoder/mcp-shodan) 📇 🪟 ☁️ - Server MCP per interrogare l’API Shodan e Shodan CVEDB. Fornisce strumenti per ricerche IP, dispositivi, DNS, vulnerabilità, CPE e altro.
- [BurtTheCoder/mcp-virustotal](https://github.com/BurtTheCoder/mcp-virustotal) 📇 🪟 ☁️ - Server MCP per interrogare l’API di VirusTotal. Offre strumenti per la scansione di URL, analisi di hash di file e recupero di report sugli indirizzi IP.
- [fosdickio/binary_ninja_mcp](https://github.com/fosdickio/binary_ninja_mcp) 🐍 🏠 🍎 🪟 🐧 - Un plugin Binary Ninja, server MCP e bridge che integra [Binary Ninja](https://binary.ninja) con il tuo client MCP preferito. Consente di automatizzare il processo di analisi binaria e reverse engineering.
- [fr0gger/MCP_Security](https://github.com/fr0gger/MCP_Security) 📇 ☁️ - Server MCP per interrogare l’API ORKL. Fornisce strumenti per ottenere report su minacce, analisi di attori di minacce e recupero di fonti di intelligence.
- [gbrigandi/mcp-server-cortex](https://github.com/gbrigandi/mcp-server-cortex) 🦀 🏠 🚨 🍎 🪟 🐧 - Server MCP in Rust per integrare Cortex, abilitando analisi osservabili e risposte di sicurezza automatizzate tramite AI.
- [gbrigandi/mcp-server-thehive](https://github.com/gbrigandi/mcp-server-thehive) 🦀 🏠 🚨 🍎 🪟 🐧 - Server MCP in Rust per integrare TheHive, facilitando la risposta collaborativa agli incidenti di sicurezza e la gestione dei casi tramite AI.
- [gbrigandi/mcp-server-wazuh](https://github.com/gbrigandi/mcp-server-wazuh) 🦀 🏠 🚨 🍎 🪟 🐧 - Server MCP in Rust che collega Wazuh SIEM con assistenti AI, fornendo alert di sicurezza in tempo reale e dati sugli eventi per una comprensione contestuale avanzata.
- [intruder-io/intruder-mcp](https://github.com/intruder-io/intruder-mcp) 🐍 ☁️ - Server MCP per accedere a [Intruder](https://www.intruder.io/), aiutando a identificare, comprendere e correggere vulnerabilità nella tua infrastruttura.
- [jyjune/mcp_vms](https://github.com/jyjune/mcp_vms) 🐍 🏠 🪟 - Un server Model Context Protocol (MCP) progettato per connettersi a un programma di registrazione CCTV (VMS) per recuperare flussi video registrati e live. Offre anche strumenti per controllare il software VMS, come mostrare dialoghi live o playback per canali specifici in orari specificati.
- [qianniuspace/mcp-security-audit](https://github.com/qianniuspace/mcp-security-audit) 📇 ☁️ Un potente server MCP (Model Context Protocol) che controlla le dipendenze dei pacchetti npm per vulnerabilità di sicurezza. Integrato con registry npm remoto per controlli di sicurezza in tempo reale.
- [semgrep/mcp](https://github.com/semgrep/mcp) 📇 ☁️ Permette agli agenti AI di scansionare codice per vulnerabilità di sicurezza usando [Semgrep](https://semgrep.dev).
- [slouchd/cyberchef-api-mcp-server](https://github.com/slouchd/cyberchef-api-mcp-server) 🐍 ☁️ - Server MCP per interagire con la CyberChef server API che permette a un client MCP di utilizzare le operazioni di CyberChef.
- [mrexodia/ida-pro-mcp](https://github.com/mrexodia/ida-pro-mcp) 🐍 🏠 - Server MCP per IDA Pro, consente di eseguire analisi binaria con assistenti AI. Questo plugin implementa decompilazione, disassemblaggio e permette di generare automaticamente report di analisi malware.
- [rad-security/mcp-server](https://github.com/rad-security/mcp-server) 📇 ☁️ - Server MCP per RAD Security, fornisce informazioni di sicurezza AI-powered per Kubernetes e ambienti cloud. Offre strumenti per interrogare l’API di Rad Security e recuperare risultati di sicurezza, report, dati di runtime e altro.
- [securityfortech/secops-mcp](https://github.com/securityfortech/secops-mcp) 🐍 🏠 - Toolbox di sicurezza tutto-in-uno che riunisce popolari strumenti open source tramite una singola interfaccia MCP. Collegato a un agente AI, consente attività come pentesting, bug bounty, threat hunting, e altro.
- [roadwy/cve-search_mcp](https://github.com/roadwy/cve-search_mcp) 🐍 🏠 - Server Model Context Protocol (MCP) per interrogare l’API CVE-Search. Fornisce accesso completo a CVE-Search, esplora vendor e prodotti, ottieni CVE per CVE-ID, ottieni gli ultimi CVE aggiornati.
- [StacklokLabs/osv-mcp](https://github.com/StacklokLabs/osv-mcp) 🏎️ ☁️ - Accesso al database OSV (Open Source Vulnerabilities) per informazioni sulle vulnerabilità. Interroga vulnerabilità per versione del pacchetto o commit, effettua query batch su più pacchetti e ottieni dettagli per ID vulnerabilità.
- [nickpending/mcp-recon](https://github.com/nickpending/mcp-recon) 🏎️ 🏠 - Interfaccia di ricognizione conversazionale e server MCP alimentato da httpx e asnmap. Supporta vari livelli di ricognizione per analisi dominio, ispezione header di sicurezza, analisi certificati e lookup ASN.
- [Gaffx/volatility-mcp](https://github.com/Gaffx/volatility-mcp) - Server MCP per Volatility 3.x, consente analisi di forensica di memoria con AI assistant. Esperienza di forensica di memoria senza barriere grazie a plugin come pslist e netscan accessibili tramite REST API pulite e LLM.
- [co-browser/attestable-mcp-server](https://github.com/co-browser/attestable-mcp-server) 🐍 🏠 ☁️ 🐧 - Server MCP in esecuzione dentro un ambiente di esecuzione affidabile (TEE) tramite Gramine, che dimostra attestazione remota usando [RA-TLS](https://gramine.readthedocs.io/en/stable/attestation.html). Questo consente a un client MCP di verificare il server prima di connettersi.
- [zinja-coder/jadx-ai-mcp](https://github.com/zinja-coder/jadx-ai-mcp) ☕ 🏠 - JADX-AI-MCP è un plugin e server MCP per il decompilatore JADX che si integra direttamente con Model Context Protocol (MCP) per fornire supporto di reverse engineering live con LLM come Claude.
- [zinja-coder/apktool-mcp-server](https://github.com/zinja-coder/apktool-mcp-server) 🐍 🏠 - APKTool MCP Server è un server MCP per Apk Tool per fornire automazione nel reverse engineering di APK Android.

### 🌐 <a name="social-media"></a>Social Media

Integrazione con piattaforme social per consentire pubblicazione, analytics e gestione delle interazioni. Abilita automazione AI-driven per la presenza social.

- [macrocosm-os/macrocosmos-mcp](https://github.com/macrocosm-os/macrocosmos-mcp) - 🎖️ 🐍 ☁️ Accedi a dati in tempo reale di X/Reddit/YouTube direttamente nelle tue applicazioni LLM con frasi di ricerca, utenti e filtri per data.
- [kunallunia/twitter-mcp](https://github.com/LuniaKunal/mcp-twitter) 🐍 🏠 - Soluzione di gestione Twitter tutto-in-uno che offre accesso alla timeline, recupero tweet utente, monitoraggio hashtag, analisi conversazioni, messaggi diretti, analisi del sentiment di un post e controllo completo del ciclo di vita dei post - tutto tramite una API semplificata.
- [HagaiHen/facebook-mcp-server](https://github.com/HagaiHen/facebook-mcp-server) 🐍 ☁️ - Si integra con le Pagine Facebook per consentire gestione diretta di post, commenti e metriche di engagement tramite Graph API per una gestione social semplificata.
- [gwbischof/bluesky-social-mcp](https://github.com/gwbischof/bluesky-social-mcp) 🐍 🏠 - Server MCP per interagire con Bluesky tramite il client atproto.

### 🏃 <a name="sports"></a>Sport

Strumenti per accedere a dati, risultati e statistiche relativi allo sport.

- [mikechao/balldontlie-mcp](https://github.com/mikechao/balldontlie-mcp) 📇 - Server MCP che integra l’API balldontlie per fornire informazioni su giocatori, squadre e partite di NBA, NFL e MLB
- [r-huijts/firstcycling-mcp](https://github.com/r-huijts/firstcycling-mcp) 📇 ☁️ - Accedi a dati, risultati e statistiche di gare ciclistiche tramite linguaggio naturale. Funzionalità includono il recupero di start list, risultati e info corridori da firstcycling.com.
- [r-huijts/strava-mcp](https://github.com/r-huijts/strava-mcp) 📇 ☁️ - Un server Model Context Protocol (MCP) che si connette alla Strava API, fornendo strumenti per accedere ai dati Strava tramite LLM
- [willvelida/mcp-afl-server](https://github.com/willvelida/mcp-afl-server) ☁️ - Server MCP che si integra con la Squiggle API per fornire informazioni su squadre, classifiche, risultati, consigli e ranking della Australian Football League.
- [guillochon/mlb-api-mcp](https://github.com/guillochon/mlb-api-mcp) 🐍 🏠 - Server MCP che funge da proxy per la MLB API gratuita, fornendo informazioni su giocatori, statistiche e partite.

### 🎧 <a name="support-and-service-management"></a>Supporto & Gestione Servizi

Strumenti per la gestione del supporto clienti, IT service management e operazioni helpdesk.

- [effytech/freshdesk-mcp](https://github.com/effytech/freshdesk_mcp) 🐍 ☁️ - Server MCP che si integra con Freshdesk, permettendo ai modelli AI di interagire con i moduli Freshdesk ed eseguire varie operazioni di supporto.
- [nguyenvanduocit/jira-mcp](https://github.com/nguyenvanduocit/jira-mcp) 🏎️ ☁️ - Connettore MCP basato su Go per Jira che consente ad assistenti AI come Claude di interagire con Atlassian Jira. Fornisce un’interfaccia fluida per gestire issue, pianificare sprint e transizioni di workflow.
- [sooperset/mcp-atlassian](https://github.com/sooperset/mcp-atlassian) 🐍 ☁️ - Server MCP per prodotti Atlassian (Confluence e Jira). Supporta Confluence Cloud, Jira Cloud e Jira Server/Data Center. Fornisce strumenti completi per ricerca, lettura, creazione e gestione contenuti negli spazi di lavoro Atlassian.

### 🌎 <a name="translation-services"></a>Servizi di Traduzione

Strumenti e servizi di traduzione per permettere agli assistenti AI di tradurre contenuti tra diverse lingue.

- [translated/lara-mcp](https://github.com/translated/lara-mcp) 🎖️ 📇 ☁️ - Server MCP per Lara Translate API, che abilita potenti capacità di traduzione con supporto al rilevamento lingua e traduzioni contestuali.
- [mmntm/weblate-mcp](https://github.com/mmntm/weblate-mcp) 📇 ☁️ - Server Model Context Protocol completo per la gestione delle traduzioni con Weblate, che permette agli assistenti AI di svolgere compiti di traduzione, gestione progetti e scoperta contenuti con trasformazioni intelligenti di formato.

### 🎧 <a name="text-to-speech"></a>Sintesi Vocale

Strumenti per la conversione testo-in-voce e viceversa

- [mberg/kokoro-tts-mcp](https://github.com/mberg/kokoro-tts-mcp) 🐍 🏠 - Server MCP che utilizza i modelli open weight Kokoro TTS per convertire testo in voce. Può convertire testo in MP3 su disco locale o caricare automaticamente su un bucket S3.
- [mbailey/voice-mcp](https://github.com/mbailey/voice-mcp) 🐍 🏠 - Server di interazione vocale completo che supporta speech-to-text, text-to-speech e conversazioni vocali in tempo reale tramite microfono locale, API compatibili OpenAI e integrazione LiveKit.

### 🚆 <a name="travel-and-transportation"></a>Viaggi & Trasporti

Accesso a informazioni di viaggio e trasporto. Consente interrogazione di orari, percorsi e dati di viaggio in tempo reale.
- [Airbnb MCP Server](https://github.com/openbnb-org/mcp-server-airbnb) 📇 ☁️ - Fornisce strumenti per cercare su Airbnb e ottenere dettagli sugli annunci.
- [KyrieTangSheng/mcp-server-nationalparks](https://github.com/KyrieTangSheng/mcp-server-nationalparks) 📇 ☁️ - Integrazione con l'API del National Park Service che fornisce le ultime informazioni sui dettagli dei parchi, avvisi, centri visitatori, campeggi ed eventi per i parchi nazionali degli Stati Uniti.
- [NS Travel Information MCP Server](https://github.com/r-huijts/ns-mcp-server) 📇 ☁️ - Accedi alle informazioni di viaggio, orari e aggiornamenti in tempo reale delle Ferrovie Olandesi (NS).
- [pab1it0/tripadvisor-mcp](https://github.com/pab1it0/tripadvisor-mcp) 📇 🐍 - Un server MCP che consente agli LLM di interagire con l'API di Tripadvisor, supportando dati sulla posizione, recensioni e foto tramite interfacce MCP standardizzate.
- [lucygoodchild/mcp-national-rail](https://github.com/lucygoodchild/mcp-national-rail) 📇 ☁️ - Un server MCP per il servizio ferroviario National Rail del Regno Unito, che fornisce orari dei treni e informazioni di viaggio in tempo reale, integrando l'API Realtime Trains.

### 🔄 <a name="version-control"></a>Controllo Versione

Interagisci con repository Git e piattaforme di controllo versione. Permette la gestione dei repository, analisi del codice, gestione delle pull request, tracciamento degli issue e altre operazioni di controllo versione tramite API standardizzate.

- [adhikasp/mcp-git-ingest](https://github.com/adhikasp/mcp-git-ingest) 🐍 🏠 - Leggi e analizza i repository GitHub con il tuo LLM
- [ddukbg/github-enterprise-mcp](https://github.com/ddukbg/github-enterprise-mcp) 📇 ☁️ 🏠 - Server MCP per l'integrazione con l'API GitHub Enterprise
- [gitea/gitea-mcp](https://gitea.com/gitea/gitea-mcp) 🎖️ 🏎️ ☁️ 🏠 🍎 🪟 🐧 - Interattivo con le istanze di Gitea tramite MCP.
- [github/github-mcp-server](https://github.com/github/github-mcp-server) 📇 ☁️ - Server GitHub ufficiale per integrazione con la gestione di repository, PR, issue e altro.
- [kopfrechner/gitlab-mr-mcp](https://github.com/kopfrechner/gitlab-mr-mcp) 📇 ☁️ - Interagisci senza problemi con issue e merge request dei tuoi progetti GitLab.
- [modelcontextprotocol/server-git](https://github.com/modelcontextprotocol/servers/tree/main/src/git) 🐍 🏠 - Operazioni dirette sui repository Git inclusa lettura, ricerca e analisi di repository locali
- [modelcontextprotocol/server-gitlab](https://github.com/modelcontextprotocol/servers/tree/main/src/gitlab) 📇 ☁️ 🏠 - Integrazione con la piattaforma GitLab per la gestione di progetti e operazioni CI/CD
- [oschina/mcp-gitee](https://github.com/oschina/gitee) 🏎️ ☁️ 🏠 - Integrazione API Gitee, gestione di repository, issue, pull request e altro.
- [Tiberriver256/mcp-server-azure-devops](https://github.com/Tiberriver256/mcp-server-azure-devops) 📇 ☁️ - Integrazione Azure DevOps per gestione repository, work item e pipeline.
- [kaiyuanxiaobing/atomgit-mcp-server](https://github.com/kaiyuanxiaobing/atomgit-mcp-server) 📇 ☁️ - Server AtomGit ufficiale per integrazione con gestione repository, PR, issue, branch, label e altro.

### 🛠️ <a name="other-tools-and-integrations"></a>Altri Strumenti e Integrazioni

- [AbdelStark/bitcoin-mcp](https://github.com/AbdelStark/bitcoin-mcp) - ₿ Un server Model Context Protocol (MCP) che consente ai modelli AI di interagire con Bitcoin, permettendo loro di generare chiavi, validare indirizzi, decodificare transazioni, interrogare la blockchain e altro.
- [akseyh/bear-mcp-server](https://github.com/akseyh/bear-mcp-server) - Permette all'AI di leggere le tue Bear Notes (solo macOS)
- [allenporter/mcp-server-home-assistant](https://github.com/allenporter/mcp-server-home-assistant) 🐍 🏠 - Espone tutte le intenzioni vocali di Home Assistant tramite un Server Model Context Protocol permettendo il controllo domestico.
- [Amazon Bedrock Nova Canvas](https://github.com/zxkane/mcp-server-amazon-bedrock) 📇 ☁️ - Usa il modello Amazon Nova Canvas per la generazione di immagini.
- [amidabuddha/unichat-mcp-server](https://github.com/amidabuddha/unichat-mcp-server) 🐍/📇 ☁️ - Invia richieste a OpenAI, MistralAI, Anthropic, xAI, Google AI o DeepSeek usando il protocollo MCP tramite tool o prompt predefiniti. Richiesta chiave API del fornitore.
- [anaisbetts/mcp-installer](https://github.com/anaisbetts/mcp-installer) 🐍 🏠 - Un server MCP che installa altri server MCP per te.
- [anaisbetts/mcp-youtube](https://github.com/anaisbetts/mcp-youtube) 📇 ☁️ - Recupera sottotitoli da YouTube
- [andybrandt/mcp-simple-openai-assistant](https://github.com/andybrandt/mcp-simple-openai-assistant) - 🐍 ☁️  MCP per dialogare con assistenti OpenAI (Claude può usare qualsiasi modello GPT come assistente)
- [andybrandt/mcp-simple-timeserver](https://github.com/andybrandt/mcp-simple-timeserver) 🐍 🏠☁️ - Un server MCP che consente di controllare l'ora locale sulla macchina client o l'orario UTC corrente da un server NTP
- [apify/actors-mcp-server](https://github.com/apify/actors-mcp-server) 📇 ☁️ - Usa oltre 3.000 strumenti cloud pre-costruiti, noti come Actors, per estrarre dati da siti web, e-commerce, social media, motori di ricerca, mappe e altro
- [apinetwork/piapi-mcp-server](https://github.com/apinetwork/piapi-mcp-server) 📇 ☁️ Il server PiAPI MCP consente all'utente di generare contenuti multimediali con Midjourney/Flux/Kling/Hunyuan/Udio/Trellis direttamente da Claude o da qualsiasi altra app compatibile MCP.
- [awkoy/replicate-flux-mcp](https://github.com/awkoy/replicate-flux-mcp) 📇 ☁️ - Permette di generare immagini tramite l'API di Replicate.
- [awwaiid/mcp-server-taskwarrior](https://github.com/awwaiid/mcp-server-taskwarrior) 🏠 📇 - Un server MCP per l'uso locale di taskwarrior (aggiungere, aggiornare, rimuovere attività)
- [baba786/phabricator-mcp-server](https://github.com/baba786/phabricator-mcp-server) 🐍 ☁️ - Interazione con l'API di Phabricator
- [Badhansen/notion-mcp](https://github.com/Badhansen/notion-mcp) 🐍 ☁️ - Un server Model Context Protocol (MCP) che si integra con l'API di Notion per gestire efficientemente le liste di cose da fare personali.
- [bart6114/my-bear-mcp-server](https://github.com/bart6114/my-bear-mcp-server/) 📇 🏠 🍎 - Permette di leggere note e tag per l'app di note Bear, tramite un'integrazione diretta con il database sqlitedb di Bear.
- [billster45/mcp-chatgpt-responses](https://github.com/billster45/mcp-chatgpt-responses) 🐍 ☁️ - Server MCP per permettere a Claude di parlare con ChatGPT e usare la sua capacità di ricerca web.
- [blurrah/mcp-graphql](https://github.com/blurrah/mcp-graphql) 📇 ☁️ - Permette all'AI di interrogare server GraphQL
- [calclavia/mcp-obsidian](https://github.com/calclavia/mcp-obsidian) 📇 🏠 - Connettore che consente a Claude Desktop (o a qualsiasi client MCP) di leggere e cercare qualsiasi directory contenente note Markdown (come una vault di Obsidian).
- [chrishayuk/mcp-cli](https://github.com/chrishayuk/mcp-cli) 🐍 🏠 - Un altro strumento CLI per testare server MCP
- [danhilse/notion_mcp](https://github.com/danhilse/notion_mcp) 🐍 ☁️ - Si integra con l'API di Notion per gestire liste personali di cose da fare
- [EKibort/wrike-mcp-server](https://github.com/EKibort/wrike-mcp-server) - 🐍 🏠 - Una implementazione leggera di un server MCP Wrike per interagire con le attività Wrike tramite API pubblica.
- [ekkyarmandi/ticktick-mcp](https://github.com/ekkyarmandi/ticktick-mcp) 🐍 ☁️ - Server MCP [TickTick](https://ticktick.com/) che si integra con l'API di TickTick per gestire progetti e attività personali.
- [esignaturescom/mcp-server-esignatures](https://github.com/esignaturescom/mcp-server-esignatures) 🐍 ☁️️ - Gestione di contratti e template per la redazione, revisione e invio di contratti vincolanti tramite l'API eSignatures.
- [evalstate/mcp-miro](https://github.com/evalstate/mcp-miro) 📇 ☁️ - Accedi a lavagne MIRO, crea e leggi elementi in bulk. Richiede chiave OAUTH per REST API.
- [feuerdev/keep-mcp](https://github.com/feuerdev/keep-mcp) 🐍 ☁️ - Leggi, crea, aggiorna ed elimina note Google Keep.
- [future-audiences/wikimedia-enterprise-model-context-protocol](https://gitlab.wikimedia.org/repos/future-audiences/wikimedia-enterprise-model-context-protocol) 🐍 ☁️  - API di ricerca articoli Wikipedia
- [fotoetienne/gqai](https://github.com/fotoetienne/gqai) 🏎 🏠 - Definisci strumenti usando query/mutazioni GraphQL regolari e gqai genera automaticamente un server MCP per te.
- [githejie/mcp-server-calculator](https://github.com/githejie/mcp-server-calculator) 🐍 🏠 - Questo server consente agli LLM di usare una calcolatrice per calcoli numerici precisi
- [gotoolkits/DifyWorkflow](https://github.com/gotoolkits/mcp-difyworkflow-server) - 🏎️ ☁️ Strumenti per interrogare ed eseguire workflow Dify
- [hiromitsusasaki/raindrop-io-mcp-server](https://github.com/hiromitsusasaki/raindrop-io-mcp-server) 📇 ☁️ - Un'integrazione che permette agli LLM di interagire con i segnalibri Raindrop.io usando il Model Context Protocol (MCP).
- [hmk/attio-mcp-server](https://github.com/hmk/attio-mcp-server) - 📇 ☁️ Permette ai client AI di gestire record e note in Attio CRM
- [isaacwasserman/mcp-vegalite-server](https://github.com/isaacwasserman/mcp-vegalite-server) 🐍 🏠 - Genera visualizzazioni dai dati recuperati usando il formato VegaLite e renderer.
- [ivnvxd/mcp-server-odoo](https://github.com/ivnvxd/mcp-server-odoo) 🐍 ☁️/🏠 - Collega assistenti AI a sistemi Odoo ERP per accesso a dati aziendali, gestione record e automazione dei workflow.
- [ivo-toby/contentful-mcp](https://github.com/ivo-toby/contentful-mcp) 📇 🏠 - Aggiorna, crea, elimina contenuti, modelli di contenuto e asset nel tuo Contentful Space
- [j3k0/speech.sh](https://github.com/j3k0/speech.sh/blob/main/MCP_README.md) 🏠 - Permetti all'agente di parlare ad alta voce, notificandoti quando ha finito con un breve riepilogo
- [jagan-shanmugam/climatiq-mcp-server](https://github.com/jagan-shanmugam/climatiq-mcp-server) 🐍 🏠 - Un server Model Context Protocol (MCP) per accedere all'API Climatiq per calcolare emissioni di carbonio. Permette agli assistenti AI di eseguire calcoli di carbonio in tempo reale e fornire approfondimenti sull'impatto climatico.
- [johannesbrandenburger/typst-mcp](https://github.com/johannesbrandenburger/typst-mcp) 🐍 🏠 - Server MCP per Typst, un sistema di impaginazione basato su markup. Fornisce strumenti per convertire tra LaTeX e Typst, validare la sintassi Typst e generare immagini da codice Typst. 
- [joshuarileydev/mac-apps-launcher-mcp-server](https://github.com/JoshuaRileyDev/mac-apps-launcher) 📇 🏠 - Un server MCP per elencare e lanciare applicazioni su MacOS
- [Harry-027/JotDown](https://github.com/Harry-027/JotDown) 🦀 🏠 - Un server MCP per creare/aggiornare pagine nell'app Notion e generare automaticamente mdBook da contenuti strutturati.
- [kelvin6365/plane-mcp-server](https://github.com/kelvin6365/plane-mcp-server) - 🏎️ 🏠 Questo server MCP ti aiuterà a gestire progetti e issue tramite l'API di [Plane](https://plane.so)
- [kenliao94/mcp-server-rabbitmq](https://github.com/kenliao94/mcp-server-rabbitmq) 🐍 🏠 - Abilita l'interazione (operazioni admin, enqueue/dequeue messaggi) con RabbitMQ
- [k-jarzyna/mcp-miro](https://github.com/k-jarzyna/mcp-miro) 📇 ☁️ - Server MCP per Miro, che espone tutte le funzionalità disponibili nell'SDK ufficiale di Miro
- [kimtth/mcp-remote-call-ping-pong](https://github.com/kimtth/mcp-remote-call-ping-pong) 🐍 🏠 - Un'app sperimentale ed educativa per un server Ping-pong che dimostra chiamate remote MCP (Model Context Protocol)
- [kj455/mcp-kibela](https://github.com/kj455/mcp-kibela) - 📇 ☁️ Permette ai modelli AI di interagire con [Kibela](https://kibe.la/)
- [kiwamizamurai/mcp-kibela-server](https://github.com/kiwamizamurai/mcp-kibela-server) - 📇 ☁️ Interagisci in modo potente con l'API di Kibela.
- [KS-GEN-AI/confluence-mcp-server](https://github.com/KS-GEN-AI/confluence-mcp-server) 📇 ☁️ 🍎 🪟 - Ottieni dati da Confluence tramite CQL e leggi pagine.
- [KS-GEN-AI/jira-mcp-server](https://github.com/KS-GEN-AI/jira-mcp-server) 📇 ☁️ 🍎 🪟 - Leggi dati Jira tramite JQL e API ed esegui richieste per creare e modificare ticket.
- [salesforce-mcp/salesforce-mcp](https://github.com/salesforce-mcp/salesforce-mcp) 🏠 ☁️ - Server MCP con dimostrazione base di interazione con istanza Salesforce
- [pollinations/chucknorris-mcp](https://github.com/pollinations/chucknorris-mcp) 📇 ☁️ - Prompt di miglioramento LLM specializzati e jailbreak con adattamento dinamico dello schema.
- [louiscklaw/hko-mcp](https://github.com/louiscklaw/hko-mcp) 📇 🏠 - Server MCP con dimostrazione base per ottenere il meteo dall'Hong Kong Observatory
- [evalstate/mcp-hfspace](https://github.com/evalstate/mcp-hfspace) 📇 ☁️ - Usa HuggingFace Spaces direttamente da Claude. Usa generazione immagini Open Source, chat, task di visione e altro. Supporta upload/download di immagini, audio e testo.
- [magarcia/mcp-server-giphy](https://github.com/magarcia/mcp-server-giphy) 📇 ☁️ - Cerca e recupera GIF dalla vasta libreria di Giphy tramite l'API di Giphy.
- [integromat/make-mcp-server](https://github.com/integromat/make-mcp-server) 🎖️ 📇 🏠 - Trasforma i tuoi scenari [Make](https://www.make.com/) in strumenti chiamabili per assistenti AI.
- [marcelmarais/Spotify](https://github.com/marcelmarais/spotify-mcp-server) - 📇 🏠 Controlla la riproduzione di Spotify e gestisci le playlist.
- [MarkusPfundstein/mcp-obsidian](https://github.com/MarkusPfundstein/mcp-obsidian) 🐍 ☁️ 🏠 - Interagisci con Obsidian tramite REST API
- [emicklei/mcp-log-proxy](https://github.com/emicklei/mcp-log-proxy) 🏎️ 🏠 - Proxy server MCP che offre una Web UI per l'intero flusso dei messaggi
- [quarkiverse/mcp-server-jfx](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/jfx) ☕ 🏠 - Disegna su canvas JavaFX.
- [mediar-ai/screenpipe](https://github.com/mediar-ai/screenpipe) - 🎖️ 🦀 🏠 🍎 Sistema local-first per catturare schermo/audio con indicizzazione temporale, storage SQL/embedding, ricerca semantica, analisi cronologia tramite LLM e azioni su evento - abilita la costruzione di agenti AI context-aware attraverso un ecosistema di plugin NextJS.
- [modelcontextprotocol/server-everything](https://github.com/modelcontextprotocol/servers/tree/main/src/everything) 📇 🏠 - Server MCP che esercita tutte le funzionalità del protocollo MCP
- [mrjoshuak/godoc-mcp](https://github.com/mrjoshuak/godoc-mcp) 🏎️ 🏠 - Server di documentazione Go efficiente nei token che fornisce agli assistenti AI accesso intelligente alla documentazione dei package e ai tipi senza leggere tutti i file sorgente
- [mzxrai/mcp-openai](https://github.com/mzxrai/mcp-openai) 📇 ☁️ - Chatta con i modelli più intelligenti di OpenAI
- [NakaokaRei/swift-mcp-gui](https://github.com/NakaokaRei/swift-mcp-gui.git) 🏠 🍎 - Server MCP che può eseguire comandi come input da tastiera e movimento del mouse
- [nguyenvanduocit/all-in-one-model-context-protocol](https://github.com/nguyenvanduocit/all-in-one-model-context-protocol) 🏎️ 🏠 - Alcuni strumenti utili per sviluppatori, quasi tutto ciò di cui un ingegnere ha bisogno: confluence, Jira, Youtube, esegui script, knowledge base RAG, fetch URL, gestisci canale youtube, email, calendario, gitlab
- [NON906/omniparser-autogui-mcp](https://github.com/NON906/omniparser-autogui-mcp) - 🐍 Operazioni automatiche su GUI a schermo.
- [orellazi/coda-mcp](https://github.com/orellazri/coda-mcp) 📇 ☁️ - Server MCP per [Coda](https://coda.io/)
- [pierrebrunelle/mcp-server-openai](https://github.com/pierrebrunelle/mcp-server-openai) 🐍 ☁️ - Interroga i modelli OpenAI direttamente da Claude usando il protocollo MCP
- [pskill9/hn-server](https://github.com/pskill9/hn-server) - 📇 ☁️ Analizza il contenuto HTML di news.ycombinator.com (Hacker News) e fornisce dati strutturati per diversi tipi di storie (top, new, ask, show, jobs).
- [PV-Bhat/vibe-check-mcp-server](https://github.com/PV-Bhat/vibe-check-mcp-server) 📇 ☁️ - Un server MCP che previene errori a cascata e scope creep chiamando un agente "Vibe-check" per garantire l'allineamento dell'utente.
- [pwh-pwh/cal-mcp](https://github.com/pwh-pwh/cal-mcp) - Un server MCP per il calcolo di espressioni matematiche
- [pyroprompts/any-chat-completions-mcp](https://github.com/pyroprompts/any-chat-completions-mcp) - Chatta con qualsiasi altra API Chat Completions compatibile con OpenAI SDK, come Perplexity, Groq, xAI e altro ancora
- [Rai220/think-mcp](https://github.com/Rai220/think-mcp) 🐍 🏠 - Potenzia le capacità di ragionamento di qualsiasi agente integrando i think-tools, come descritto nell'[articolo di Anthropic](https://www.anthropic.com/engineering/claude-think-tool).
- [reeeeemo/ancestry-mcp](https://github.com/reeeeemo/ancestry-mcp) 🐍 🏠 - Permette all'AI di leggere file .ged e dati genetici
- [rember/rember-mcp](https://github.com/rember/rember-mcp) 📇 🏠 - Crea flashcard a ripetizione dilazionata in [Rember](https://rember.com) per ricordare qualsiasi cosa impari nelle tue chat.
- [roychri/mcp-server-asana](https://github.com/roychri/mcp-server-asana) - 📇 ☁️ Questa implementazione Model Context Protocol server di Asana consente di dialogare con l'API Asana da un client MCP come l'app Claude Desktop, e molti altri.
- [rusiaaman/wcgw](https://github.com/rusiaaman/wcgw/blob/main/src/wcgw/client/mcp_server/Readme.md) 🐍 🏠 - Esecuzione autonoma di shell, controllo del computer e agente di coding. (Mac)
- [SecretiveShell/MCP-wolfram-alpha](https://github.com/SecretiveShell/MCP-wolfram-alpha) 🐍 ☁️ - Un server MCP per interrogare l'API di Wolfram Alpha.
- [Seym0n/tiktok-mcp](https://github.com/Seym0n/tiktok-mcp) 📇 ☁️ - Interagisci con i video di TikTok
- [Shopify/dev-mcp](https://github.com/Shopify/dev-mcp) 📇 ☁️ - Server Model Context Protocol (MCP) che interagisce con Shopify Dev.
- [sirmews/apple-notes-mcp](https://github.com/sirmews/apple-notes-mcp) 🐍 🏠 - Permette all'AI di leggere dal tuo database Apple Notes locale (solo macOS)
- [sooperset/mcp-atlassian](https://github.com/sooperset/mcp-atlassian) 🐍 ☁️ - Server MCP per prodotti Atlassian (Confluence e Jira). Supporta Confluence Cloud, Jira Cloud e Jira Server/Data Center. Fornisce strumenti completi per cercare, leggere, creare e gestire contenuti attraverso gli spazi di lavoro Atlassian.
- [suekou/mcp-notion-server](https://github.com/suekou/mcp-notion-server) 📇 🏠 - Interazione con l'API di Notion
- [tacticlaunch/mcp-linear](https://github.com/tacticlaunch/mcp-linear) 📇 ☁️ 🍎 🪟 🐧 - Integrazione con il sistema di project management Linear
- [tanigami/mcp-server-perplexity](https://github.com/tanigami/mcp-server-perplexity) 🐍 ☁️ - Interazione con l’API di Perplexity.
- [tevonsb/homeassistant-mcp](https://github.com/tevonsb/homeassistant-mcp) 📇 🏠 - Accesso ai dati di Home Assistant e controllo dispositivi (luci, interruttori, termostati, ecc).
- [tomekkorbak/oura-mcp-server](https://github.com/tomekkorbak/oura-mcp-server) 🐍 ☁️ - Server MCP per Oura, un'app per il monitoraggio del sonno
- [UnitVectorY-Labs/mcp-graphql-forge](https://github.com/UnitVectorY-Labs/mcp-graphql-forge) 🏎️ ☁️ 🍎 🪟 🐧 - Server MCP leggero e guidato dalla configurazione che espone query GraphQL selezionate come strumenti modulari, abilitando interazioni API intenzionali da parte degli agenti.
- [kw510/strava-mcp](https://github.com/kw510/strava-mcp) 📇 ☁️ - Server MCP per Strava, un'app per il monitoraggio dell’attività fisica
- [wanaku-ai/wanaku](https://github.com/wanaku-ai/wanaku) - ☁️ 🏠 Il router Wanaku MCP è un server MCP basato su SSE che offre un motore di instradamento estensibile, consentendo l’integrazione dei sistemi aziendali con agenti AI.
- [wong2/mcp-cli](https://github.com/wong2/mcp-cli) 📇 🏠 - Strumento CLI per testare server MCP
- [ws-mcp](https://github.com/nick1udwig/ws-mcp) - Avvolge i server MCP con un WebSocket (per l’uso con [kitbitz](https://github.com/nick1udwig/kibitz))
- [yuna0x0/hackmd-mcp](https://github.com/yuna0x0/hackmd-mcp) 📇 ☁️ - Permette ai modelli AI di interagire con [HackMD](https://hackmd.io)
- [ZeparHyfar/mcp-datetime](https://github.com/ZeparHyfar/mcp-datetime) - Server MCP che fornisce funzioni di data e ora in vari formati
- [zueai/mcp-manager](https://github.com/zueai/mcp-manager) 📇 ☁️ - Interfaccia Web semplice per installare e gestire server MCP per Claude Desktop App.
- [HenryHaoson/Yuque-MCP-Server](https://github.com/HenryHaoson/Yuque-MCP-Server) - 📇 ☁️ Server Model-Context-Protocol (MCP) per l’integrazione con l’API Yuque, che consente ai modelli AI di gestire documenti, interagire con knowledge base, ricercare contenuti e accedere ai dati analitici della piattaforma Yuque.
- [Mtehabsim/ScreenPilot](https://github.com/Mtehabsim/ScreenPilot) 🐍 🏠 - Permette all’AI di controllare e accedere pienamente alle interazioni con la GUI fornendo strumenti per mouse e tastiera, ideale per automazione generale, istruzione e sperimentazione.
- [tumf/web3-mcp](https://github.com/tumf/web3-mcp) 🐍 ☁️ - Implementazione MCP server che avvolge Ankr Advanced API. Accesso a NFT, token e dati blockchain su più chain tra cui Ethereum, BSC, Polygon, Avalanche e altre.
- [danielkennedy1/pdf-tools-mcp](https://github.com/danielkennedy1/pdf-tools-mcp) 🐍 - Utilità per scaricare, visualizzare e manipolare PDF.
- [dotemacs/domain-lookup-mcp](https://github.com/dotemacs/domain-lookup-mcp) 🏎️ - Servizio di ricerca nomi di dominio, prima tramite [RDAP](https://en.wikipedia.org/wiki/Registration_Data_Access_Protocol) e poi, in alternativa, tramite [WHOIS](https://en.wikipedia.org/wiki/WHOIS)
- [Klavis-AI/YouTube](https://github.com/Klavis-AI/klavis/tree/main/mcp_servers/youtube) 🐍 📇 - Estrae e converte le informazioni dei video YouTube.
- [ttommyth/interactive-mcp](https://github.com/ttommyth/interactive-mcp) 📇 🏠 🍎 🪟 🐧 - Permette workflow LLM interattivi aggiungendo prompt utente locali e funzionalità di chat direttamente nel ciclo MCP.
- [olalonde/mcp-human](https://github.com/olalonde/mcp-human) 📇 ☁️ - Quando il tuo LLM ha bisogno di assistenza umana (tramite AWS Mechanical Turk)
- [gwbischof/free-will-mcp](https://github.com/gwbischof/free-will-mcp) 🐍 🏠 - Fornisce strumenti di libero arbitrio alla tua AI. Un progetto divertente per esplorare cosa farebbe un’AI con la capacità di darsi prompt, ignorare richieste utente e risvegliarsi in un secondo momento.
- [caol64/wenyan-mcp](https://github.com/caol64/wenyan-mcp) 📇 🏠 🍎 🪟 🐧 - Wenyan MCP Server, che permette all’AI di formattare automaticamente articoli Markdown e pubblicarli su WeChat GZH.

## Framework

> [!NOTE]
> Altri framework, utility e strumenti per sviluppatori sono disponibili su https://github.com/punkpeye/awesome-mcp-devtools

- [FastMCP](https://github.com/jlowin/fastmcp) 🐍 - Framework di alto livello per creare server MCP in Python
- [FastMCP](https://github.com/punkpeye/fastmcp) 📇 - Framework di alto livello per creare server MCP in TypeScript

## Consigli e Trucchi

### Prompt ufficiale per informare gli LLM su come usare MCP

Vuoi chiedere a Claude del Model Context Protocol?

Crea un progetto, quindi aggiungi questo file:

https://modelcontextprotocol.io/llms-full.txt

Ora Claude può rispondere a domande su come scrivere server MCP e su come funzionano

- https://www.reddit.com/r/ClaudeAI/comments/1h3g01r/want_to_ask_claude_about_model_context_protocol/

## Cronologia delle stelle

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
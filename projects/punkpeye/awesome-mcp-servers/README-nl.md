# Geweldige MCP Servers [![Awesome](https://awesome.re/badge.svg)](https://awesome.re)

[![ไทย](https://img.shields.io/badge/Thai-Click-blue)](README-th.md)
[![English](https://img.shields.io/badge/English-Click-yellow)](README.md)
[![繁體中文](https://img.shields.io/badge/繁體中文-點擊查看-orange)](README-zh_TW.md)
[![简体中文](https://img.shields.io/badge/简体中文-点击查看-orange)](README-zh.md)
[![日本語](https://img.shields.io/badge/日本語-クリック-青)](README-ja.md)
[![한국어](https://img.shields.io/badge/한국어-클릭-yellow)](README-ko.md)
[![Português Brasileiro](https://img.shields.io/badge/Português_Brasileiro-Clique-green)](README-pt_BR.md)
[![Discord](https://img.shields.io/discord/1312302100125843476?logo=discord&label=discord)](https://glama.ai/mcp/discord)
[![Subreddit subscribers](https://img.shields.io/reddit/subreddit-subscribers/mcp?style=flat&logo=reddit&label=subreddit)](https://www.reddit.com/r/mcp/)

Een samengestelde lijst van geweldige Model Context Protocol (MCP) servers.

* [Wat is MCP?](#wat-is-mcp)
* [Clients](#clients)
* [Handleidingen](#handleidingen)
* [Community](#community)
* [Legenda](#legenda)
* [Serverimplementaties](#serverimplementaties)
* [Frameworks](#frameworks)
* [Tips & Tricks](#tips-en-trucs)

## Wat is MCP?

[MCP](https://modelcontextprotocol.io/) is een open protocol waarmee AI-modellen veilig kunnen communiceren met lokale en externe bronnen via gestandaardiseerde serverimplementaties. Deze lijst richt zich op productieklare en experimentele MCP-servers die AI-mogelijkheden uitbreiden met bestands­toegang, databaseverbindingen, API-integraties en andere contextuele diensten.

## Clients

Bekijk [awesome-mcp-clients](https://github.com/punkpeye/awesome-mcp-clients/) en [glama.ai/mcp/clients](https://glama.ai/mcp/clients).

> [!TIP]
> [Glama Chat](https://glama.ai/chat) is een multimodale AI-client met MCP-ondersteuning & [AI-gateway](https://glama.ai/gateway).

## Handleidingen

* [Model Context Protocol (MCP) Quickstart](https://glama.ai/blog/2024-11-25-model-context-protocol-quickstart)
* [Stel Claude Desktop App in om een SQLite Database te gebruiken](https://youtu.be/wxCCzo9dGj0)

## Community

* [r/mcp Reddit](https://www.reddit.com/r/mcp)
* [Discord Server](https://glama.ai/mcp/discord)

## Legenda

* 🎖️ – officiële implementatie
* programmeertaal
  * 🐍 – Python-codebase
  * 📇 – TypeScript (of JavaScript) codebase
  * 🏎️ – Go-codebase
  * 🦀 – Rust-codebase
  * #️⃣ - C# codebase
  * ☕ - Java-codebase
  * 🌊 – C/C++ codebase
* scope
  * ☁️ - Cloudservice
  * 🏠 - Lokale service
  * 📟 - Embedded systemen
* besturingssysteem
  * 🍎 – Voor macOS
  * 🪟 – Voor Windows
  * 🐧 - Voor Linux

> [!NOTE]
> Verward over Lokaal 🏠 versus Cloud ☁️?
> * Gebruik lokaal wanneer de MCP-server communiceert met lokaal geïnstalleerde software, bijvoorbeeld om controle te nemen over de Chrome-browser.
> * Gebruik netwerk wanneer de MCP-server praat met externe API’s, bijvoorbeeld een weer-API.

## Serverimplementaties

> [!NOTE]
> We hebben nu een [webgebaseerde directory](https://glama.ai/mcp/servers) die gesynchroniseerd is met de repository.

* 🔗 - [Aggregators](#aggregators)
* 🎨 - [Kunst & Cultuur](#kunst-en-cultuur)
* 📂 - [Browserautomatisering](#browserautomatisering)
* ☁️ - [Cloudplatforms](#cloudplatforms)
* 👨‍💻 - [Code-uitvoering](#code-uitvoering)
* 🤖 - [Codering Agents](#codering-agents)
* 🖥️ - [Commandoregel](#commandoregel)
* 💬 - [Communicatie](#communicatie)
* 👤 - [Customer Data Platforms](#customer-data-platforms)
* 🗄️ - [Databases](#databases)
* 📊 - [Dataplatforms](#dataplatforms)
* 🚚 - [Bezorging](#bezorging)
* 🛠️ - [Ontwikkelaarstools](#ontwikkelaarstools)
* 🧮 - [Data Science Tools](#data-science-tools)
* 📟 - [Embedded systeem](#embedded-systeem)
* 📂 - [Bestandssystemen](#bestandssystemen)
* 💰 - [Financiën & Fintech](#financiën--fintech)
* 🎮 - [Gaming](#gaming)
* 🧠 - [Kennis & Geheugen](#kennis--geheugen)
* 🗺️ - [Locatiediensten](#locatiediensten)
* 🎯 - [Marketing](#marketing)
* 📊 - [Monitoring](#monitoring)
* 🎥 - [Multimediaverwerking](#multimediaverwerking)
* 🔎 - [Zoeken & Data Extractie](#zoeken)
* 🔒 - [Beveiliging](#beveiliging)
* 🌐 - [Sociale media](#sociale-media)
* 🏃 - [Sport](#sport)
* 🎧 - [Support & Servicebeheer](#support-and-service-management)
* 🌎 - [Vertaalservices](#translation-services)
* 🎧 - [Tekst-naar-Spraak](#text-to-speech)
* 🚆 - [Reis & Vervoer](#travel-and-transportation)
* 🔄 - [Versiebeheer](#version-control)
* 🛠️ - [Overige Tools en Integraties](#other-tools-and-integrations)


### 🔗 <a name="aggregators"></a>Aggregators

Servers voor toegang tot vele apps en tools via één enkele MCP-server.

- [julien040/anyquery](https://github.com/julien040/anyquery) 🏎️ 🏠 ☁️ - Raadpleeg meer dan 40 apps met één binary via SQL. Kan ook verbinding maken met je PostgreSQL-, MySQL- of SQLite-compatibele database. Lokaal-georiënteerd en privacy by design.
- [metatool-ai/metatool-app](https://github.com/metatool-ai/metatool-app) 📇 ☁️ 🏠 🍎 🪟 🐧 - MetaMCP is de ene verenigde middleware MCP-server die je MCP-verbindingen beheert met een GUI.
- [mindsdb/mindsdb](https://github.com/mindsdb/mindsdb) - Verbind en verenig data over verschillende platforms en databases met [MindsDB als een enkele MCP-server](https://docs.mindsdb.com/mcp/overview).
- [glenngillen/mcpmcp-server](https://github.com/glenngillen/mcpmcp-server) ☁️ 📇 🍎 🪟 🐧 - Een lijst van MCP-servers zodat je aan je client kunt vragen welke servers je kunt gebruiken om je dagelijkse workflow te verbeteren.
- [wegotdocs/open-mcp](https://github.com/wegotdocs/open-mcp) 📇 🏠 🍎 🪟 🐧 - Verander een web-API in 10 seconden in een MCP-server en voeg deze toe aan het open source register: https://open-mcp.org
- [PipedreamHQ/pipedream](https://github.com/PipedreamHQ/pipedream/tree/master/modelcontextprotocol) ☁️ 🏠 - Verbind met 2.500 API's met 8.000+ kant-en-klare tools en beheer servers voor je gebruikers in je eigen app.
- [VeriTeknik/pluggedin-mcp-proxy](https://github.com/VeriTeknik/pluggedin-mcp-proxy)  📇 🏠 - Een uitgebreide proxyserver die meerdere MCP-servers combineert in één interface met uitgebreide zichtbaarheid. Biedt ontdekking en beheer van tools, prompts, bronnen en sjablonen over servers, plus een playground om te debuggen bij het bouwen van MCP-servers.
- [tigranbs/mcgravity](https://github.com/tigranbs/mcgravity) 📇 🏠 - Een proxytool om meerdere MCP-servers samen te voegen tot één eindpunt. Schaal je AI-tools door load balancing over meerdere MCP-servers, vergelijkbaar met hoe Nginx werkt voor webservers.
- [MetaMCP](https://github.com/metatool-ai/metatool-app) 📇 ☁️ 🏠 🍎 🪟 🐧 - MetaMCP is de ene verenigde middleware MCP-server die je MCP-verbindingen beheert met een GUI.
- [WayStation-ai/mcp](https://github.com/waystation-ai/mcp) ☁️ 🍎 🪟 - Verbind naadloos en veilig Claude Desktop en andere MCP-hosts met je favoriete apps (Notion, Slack, Monday, Airtable, enz.). Duurt minder dan 90 seconden.
- [sxhxliang/mcp-access-point](https://github.com/sxhxliang/mcp-access-point) 📇 ☁️ 🏠 🍎 🪟 🐧 - Verander een webservice in één klik in een MCP-server zonder enige codewijzigingen.
- [hamflx/imagen3-mcp](https://github.com/hamflx/imagen3-mcp) 📇 🏠 🪟 🍎 🐧 - Een krachtige afbeeldingsgeneratie-tool met Google's Imagen 3.0 API via MCP. Genereer hoogwaardige afbeeldingen vanuit tekstprompts met geavanceerde fotografie-, artistieke en fotorealistische besturing.
- [SureScaleAI/openai-gpt-image-mcp](https://github.com/SureScaleAI/openai-gpt-image-mcp) 📇 ☁️ - OpenAI GPT afbeelding genereren/bewerken MCP-server.

### 🎨 <a name="art-and-culture"></a>Kunst & Cultuur

Toegang tot en verkenning van kunstcollecties, cultureel erfgoed en museale databases. Maakt het mogelijk voor AI-modellen om artistieke en culturele content te doorzoeken en analyseren.

- [abhiemj/manim-mcp-server](https://github.com/abhiemj/manim-mcp-server) 🐍 🏠 🪟 🐧 - Een lokale MCP-server die animaties genereert met Manim.
- [burningion/video-editing-mcp](https://github.com/burningion/video-editing-mcp) 🐍 - Voeg toe, analyseer, zoek en genereer videobewerkingen uit je Video Jungle Collectie.
- [cswkim/discogs-mcp-server](https://github.com/cswkim/discogs-mcp-server) 📇 ☁️ - MCP-server voor interactie met de Discogs API.
- [djalal/quran-mcp-server](https://github.com/djalal/quran-mcp-server) 📇 ☁️ MCP-server voor interactie met de Quran.com corpus via de officiële REST API v4.
- [mikechao/metmuseum-mcp](https://github.com/mikechao/metmuseum-mcp) 📇 ☁️ - Metropolitan Museum of Art Collection API-integratie om kunstwerken te zoeken en weer te geven.
- [r-huijts/rijksmuseum-mcp](https://github.com/r-huijts/rijksmuseum-mcp) 📇 ☁️ - Rijksmuseum API-integratie voor het zoeken van kunstwerken, details en collecties.
- [r-huijts/oorlogsbronnen-mcp](https://github.com/r-huijts/oorlogsbronnen-mcp) 📇 ☁️ - Oorlogsbronnen API-integratie voor toegang tot historische WOII-archieven, foto's en documenten uit Nederland (1940-1945).
- [samuelgursky/davinci-resolve-mcp](https://github.com/samuelgursky/davinci-resolve-mcp) 🐍 - MCP-serverintegratie voor DaVinci Resolve met krachtige tools voor videobewerking, kleurcorrectie, mediabeheer en projectcontrole.
- [yuna0x0/anilist-mcp](https://github.com/yuna0x0/anilist-mcp) 📇 ☁️ - Een MCP-server die de AniList API integreert voor anime- en mangainformatie.
- [diivi/aseprite-mcp](https://github.com/diivi/aseprite-mcp) 🐍 🏠 - MCP-server met gebruik van de Aseprite API om pixelart te maken.
- [omni-mcp/isaac-sim-mcp](https://github.com/omni-mcp/isaac-sim-mcp) 📇 ☁️ - Een MCP-server en extensie die natuurlijke taalbesturing mogelijk maakt van NVIDIA Isaac Sim, Lab, OpenUSD, enz.
- [8enSmith/mcp-open-library](https://github.com/8enSmith/mcp-open-library) 📇 ☁️ - Een MCP-server voor de Open Library API waarmee AI-assistenten naar boekinformatie kunnen zoeken.
- [PatrickPalmer/MayaMCP](https://github.com/PatrickPalmer/MayaMCP) 🐍 🏠 - MCP-server voor Autodesk Maya.
- [cantian-ai/bazi-mcp](https://github.com/cantian-ai/bazi-mcp) 📇 🏠 ☁️ 🍎 🪟 - Biedt uitgebreide en nauwkeurige Bazi (Chinese astrologie) berekening en analyse.


### 📂 <a name="browser-automation"></a>Browserautomatisering

Webcontenttoegang en automatiseringsmogelijkheden. Maakt het mogelijk om webcontent te zoeken, scrapen en verwerken in AI-vriendelijke formaten.

- [xspadex/bilibili-mcp](https://github.com/xspadex/bilibili-mcp.git) 📇 🏠 - Een op FastMCP gebaseerde tool die trending video's van Bilibili ophaalt en aanbiedt via een standaard MCP-interface.
- [34892002/bilibili-mcp-js](https://github.com/34892002/bilibili-mcp-js) 📇 🏠 - Een MCP-server die het zoeken naar Bilibili-content ondersteunt. Biedt LangChain-integratievoorbeelden en testscripts.
- [aircodelabs/grasp](https://github.com/aircodelabs/grasp) 📇 🏠 - Zelfgehoste browseragent met ingebouwde MCP- en A2A-ondersteuning.
- [automatalabs/mcp-server-playwright](https://github.com/Automata-Labs-team/MCP-Server-Playwright) 🐍 - Een MCP-server voor browserautomatisering met Playwright.
- [blackwhite084/playwright-plus-python-mcp](https://github.com/blackwhite084/playwright-plus-python-mcp) 🐍 - Een MCP-pythonserver met Playwright voor browserautomatisering, meer geschikt voor llm.
- [browserbase/mcp-server-browserbase](https://github.com/browserbase/mcp-server-browserbase) 🎖️ 📇 - Automatiseer browserinteracties in de cloud (zoals webnavigatie, data-extractie, formulieren invullen, enz.).
- [browsermcp/mcp](https://github.com/browsermcp/mcp) 📇 🏠 - Automatiseer je lokale Chrome-browser.
- [co-browser/browser-use-mcp-server](https://github.com/co-browser/browser-use-mcp-server) 🐍 - browser-use verpakt als een MCP-server met SSE-transport. Inclusief een dockerfile om chromium in docker + een vnc-server te draaien.
- [executeautomation/playwright-mcp-server](https://github.com/executeautomation/mcp-playwright) 📇 - Een MCP-server met Playwright voor browserautomatisering en webscraping.
- [eyalzh/browser-control-mcp](https://github.com/eyalzh/browser-control-mcp) 📇 🏠 - Een MCP-server gekoppeld aan een browserextensie die LLM-clients toestaat de browser van de gebruiker (Firefox) te bedienen.
- [fradser/mcp-server-apple-reminders](https://github.com/FradSer/mcp-server-apple-reminders) 📇 🏠 🍎 - Een MCP-server voor interactie met Apple Herinneringen op macOS.
- [getrupt/ashra-mcp](https://github.com/getrupt/ashra-mcp) 🐍 🏠 - Haal gestructureerde data uit elke website. Gewoon prompten en ontvang JSON.
- [kimtaeyoon83/mcp-server-youtube-transcript](https://github.com/kimtaeyoon83/mcp-server-youtube-transcript) 📇 ☁️ - Haal YouTube-ondertitels en transcripties op voor AI-analyse.
- [kimtth/mcp-aoai-web-browsing](https://github.com/kimtth/mcp-aoai-web-browsing) 🐍 🏠 - Een `minimale` server/client MCP-implementatie met Azure OpenAI en Playwright.
- [microsoft/playwright-mcp](https://github.com/microsoft/playwright-mcp) - Officiële Microsoft Playwright MCP-server, maakt het mogelijk voor LLM's om te interageren met webpagina's via gestructureerde toegankelijkheidssnapshots.
- [modelcontextprotocol/server-puppeteer](https://github.com/modelcontextprotocol/servers/tree/main/src/puppeteer) 📇 🏠 - Browserautomatisering voor webscraping en interactie.
- [ndthanhdev/mcp-browser-kit](https://github.com/ndthanhdev/mcp-browser-kit) 📇 🏠 - Een MCP-server voor interactie met manifest v2-compatibele browsers.
- [pskill9/web-search](https://github.com/pskill9/web-search) 📇 🏠 - Een MCP-server die gratis websearch mogelijk maakt met Google-zoekresultaten, zonder API-sleutels.
- [recursechat/mcp-server-apple-shortcuts](https://github.com/recursechat/mcp-server-apple-shortcuts) 📇 🏠 🍎 - Een MCP-serverintegratie met Apple Shortcuts.

### ☁️ <a name="cloud-platforms"></a>Cloudplatforms

Integratie van cloudplatformdiensten. Maakt beheer en interactie met cloudinfrastructuur en -services mogelijk.

- [awslabs/mcp](https://github.com/awslabs/mcp) 🎖️ ☁️ - AWS MCP-servers voor naadloze integratie met AWS-diensten en -resources.
- [qiniu/qiniu-mcp-server](https://github.com/qiniu/qiniu-mcp-server) 🐍 ☁️ - Een MCP gebouwd op Qiniu Cloud-producten, ondersteunt toegang tot Qiniu Cloud Storage, mediaverwerkingsdiensten, enz.
- [alexbakers/mcp-ipfs](https://github.com/alexbakers/mcp-ipfs) 📇 ☁️ - uploaden en manipulatie van IPFS-opslag.
- [reza-gholizade/k8s-mcp-server](https://github.com/reza-gholizade/k8s-mcp-server) 🏎️ ☁️/🏠 - Een Kubernetes Model Context Protocol (MCP) server die tools biedt voor interactie met Kubernetes-clusters via een gestandaardiseerde interface, inclusief API-resourceontdekking, resourcebeheer, pod-logs, metrics en events.
- [VmLia/books-mcp-server](https://github.com/VmLia/books-mcp-server) 📇 ☁️ - Dit is een MCP-server voor het opvragen van boeken en kan worden gebruikt in gangbare MCP-clients, zoals Cherry Studio.
- [alexei-led/aws-mcp-server](https://github.com/alexei-led/aws-mcp-server) 🐍 ☁️ - Een lichte maar krachtige server waarmee AI-assistenten AWS CLI-commando's kunnen uitvoeren, Unix-pipes kunnen gebruiken, en promptsjablonen kunnen toepassen voor veelvoorkomende AWS-taken in een veilige Docker-omgeving met multi-architectuur ondersteuning.
- [alexei-led/k8s-mcp-server](https://github.com/alexei-led/k8s-mcp-server) 🐍 - Een lichte maar robuuste server die AI-assistenten in staat stelt veilig Kubernetes CLI-commando's uit te voeren (`kubectl`, `helm`, `istioctl`, en `argocd`) met Unix-pipes in een veilige Docker-omgeving met multi-architectuur ondersteuning.
- [aliyun/alibaba-cloud-ops-mcp-server](https://github.com/aliyun/alibaba-cloud-ops-mcp-server) 🎖️ 🐍 ☁️ - Een MCP-server waarmee AI-assistenten resources op Alibaba Cloud kunnen beheren, met ondersteuning voor ECS, Cloud Monitor, OOS en veelgebruikte cloudproducten.  
- [bright8192/esxi-mcp-server](https://github.com/bright8192/esxi-mcp-server) 🐍 ☁️ - Een VMware ESXi/vCenter-beheer server op basis van MCP (Model Control Protocol), met eenvoudige REST API-interfaces voor virtueel machinebeheer.
- [cloudflare/mcp-server-cloudflare](https://github.com/cloudflare/mcp-server-cloudflare) 🎖️ 📇 ☁️ - Integratie met Cloudflare-diensten, waaronder Workers, KV, R2 en D1.
- [cyclops-ui/mcp-cyclops](https://github.com/cyclops-ui/mcp-cyclops) 🎖️ 🏎️ ☁️ - Een MCP-server waarmee AI-agenten Kubernetes-resources kunnen beheren via Cyclops-abstraction.
- [jedisct1/fastly-mcp-server](https://github.com/jedisct1/fastly-openapi-schema) 🎖️ 📇 ☁️ - Integratie met Fastly-diensten.
- [flux159/mcp-server-kubernetes](https://github.com/Flux159/mcp-server-kubernetes) 📇 ☁️/🏠 - Typescript-implementatie van Kubernetes-clusteroperaties voor pods, deployments, services.
- [hardik-id/azure-resource-graph-mcp-server](https://github.com/hardik-id/azure-resource-graph-mcp-server) 📇 ☁️/🏠 - Een Model Context Protocol-server voor het op grote schaal opvragen en analyseren van Azure-resources met Azure Resource Graph, waardoor AI-assistenten Azure-infrastructuur kunnen verkennen en monitoren.
- [jdubois/azure-cli-mcp](https://github.com/jdubois/azure-cli-mcp) - Een wrapper om de Azure CLI opdrachtregel waarmee je direct met Azure kunt praten.
- [johnneerdael/netskope-mcp](https://github.com/johnneerdael/netskope-mcp) 🔒 ☁️ - Een MCP voor toegang tot alle Netskope Private Access-componenten binnen Netskope Private Access-omgevingen, inclusief gedetailleerde setupinformatie en LLM-voorbeelden van gebruik.
- [manusa/Kubernetes MCP Server](https://github.com/manusa/kubernetes-mcp-server) 🏎️ 🏠 Een - krachtige Kubernetes MCP-server met extra ondersteuning voor OpenShift. Naast het bieden van CRUD-operaties voor **elke** Kubernetes-resource biedt deze server gespecialiseerde tools voor interactie met je cluster.
- [nwiizo/tfmcp](https://github.com/nwiizo/tfmcp) 🦀 🏠 - Een Terraform MCP-server waarmee AI-assistenten Terraform-omgevingen kunnen beheren, inclusief het lezen van configuraties, analyseren van plannen, toepassen van configuraties en beheren van Terraform-state.
- [pulumi/mcp-server](https://github.com/pulumi/mcp-server) 🎖️ 📇 🏠 - MCP-server voor interactie met Pulumi via de Pulumi Automation API en Pulumi Cloud API. Maakt het mogelijk voor MCP-clients om Pulumi-operaties uit te voeren zoals het ophalen van pakketinfo, previewen van wijzigingen, updates uitrollen en stack-outputs programmatic ophalen.
- [rohitg00/kubectl-mcp-server](https://github.com/rohitg00/kubectl-mcp-server) 🐍 ☁️/🏠 - Een Model Context Protocol (MCP) server voor Kubernetes waarmee AI-assistenten zoals Claude, Cursor en anderen kunnen interageren met Kubernetes-clusters via natuurlijke taal.
- [strowk/mcp-k8s-go](https://github.com/strowk/mcp-k8s-go) 🏎️ ☁️/🏠 - Kubernetes-clusteroperaties via MCP.
- [thunderboltsid/mcp-nutanix](https://github.com/thunderboltsid/mcp-nutanix) 🏎️ 🏠/☁️ - Go-gebaseerde MCP-server voor koppeling met Nutanix Prism Central-resources.
- [trilogy-group/aws-pricing-mcp](https://github.com/trilogy-group/aws-pricing-mcp) 🏎️ ☁️/🏠 - Verkrijg actuele EC2-prijsinformatie met één oproep. Snel. Aangedreven door een voor-geparseerde AWS-prijscatalogus.
- [weibaohui/k8m](https://github.com/weibaohui/k8m) 🏎️ ☁️/🏠 - Biedt MCP-multicluster Kubernetes-beheer en -operaties, met een beheerinterface, logging en bijna 50 ingebouwde tools voor gangbare DevOps- en ontwikkelscenario's. Ondersteunt zowel standaard- als CRD-resources.
- [weibaohui/kom](https://github.com/weibaohui/kom) 🏎️ ☁️/🏠 - Biedt MCP-multicluster Kubernetes-beheer en -operaties. Kan worden geïntegreerd als SDK in je eigen project en bevat bijna 50 ingebouwde tools voor veelvoorkomende DevOps- en ontwikkelscenario's. Ondersteunt zowel standaard- als CRD-resources.
- [wenhuwang/mcp-k8s-eye](https://github.com/wenhuwang/mcp-k8s-eye) 🏎️ ☁️/🏠 - MCP Server voor Kubernetes-beheer en analyse van je cluster en applicatiegezondheid.
- [erikhoward/adls-mcp-server](https://github.com/erikhoward/adls-mcp-server) 🐍 ☁️/🏠 - MCP Server voor Azure Data Lake Storage. Kan containers beheren, lees-/schrijf-/upload-/downloadbewerkingen uitvoeren op containerbestanden en bestandsmetadata beheren.
- [silenceper/mcp-k8s](https://github.com/silenceper/mcp-k8s) 🏎️ ☁️/🏠 - MCP-K8S is een AI-gedreven Kubernetes resource management tool waarmee gebruikers via natuurlijke taal interactie alle resources in Kubernetes clusters kunnen beheren, waaronder native resources (zoals Deployment, Service) en custom resources (CRD). Geen noodzaak om complexe commando's te onthouden – beschrijf simpelweg je behoefte en AI voert nauwkeurig de bijbehorende clusteroperaties uit, wat de bruikbaarheid van Kubernetes aanzienlijk verhoogt.
- [redis/mcp-redis-cloud](https://github.com/redis/mcp-redis-cloud) 📇 ☁️ - Beheer je Redis Cloud-resources moeiteloos met natuurlijke taal. Maak databases aan, monitor abonnementen en configureer cloud-deployments met eenvoudige commando's.
- [portainer/portainer-mcp](https://github.com/portainer/portainer-mcp) 🏎️ ☁️/🏠 - Een krachtige MCP-server die AI-assistenten in staat stelt om naadloos te interageren met Portainer-instanties en natuurlijke taaltoegang biedt tot containerbeheer, deployment-operaties en infrastructuurmonitoring.

### 👨‍💻 <a name="code-execution"></a>Code Execution

Code execution servers. Laat LLM's toe om code uit te voeren in een veilige omgeving, bijvoorbeeld voor codeeragenten.

- [pydantic/pydantic-ai/mcp-run-python](https://github.com/pydantic/pydantic-ai/tree/main/mcp-run-python) 🐍 🏠 - Voer Python-code uit in een veilige sandbox via MCP-tool-aanroepen
- [yepcode/mcp-server-js](https://github.com/yepcode/mcp-server-js) 🎖️ 📇 ☁️ - Voer alle door LLM gegenereerde code uit in een veilige en schaalbare sandboxomgeving en maak je eigen MCP-tools met JavaScript of Python, met volledige ondersteuning voor NPM en PyPI-pakketten
- [ckanthony/openapi-mcp](https://github.com/ckanthony/openapi-mcp) 🏎️ ☁️ - OpenAPI-MCP: Dockerized MCP Server waarmee je AI-agent toegang krijgt tot elke API met bestaande API-documentatie.
- [alfonsograziano/node-code-sandbox-mcp](https://github.com/alfonsograziano/node-code-sandbox-mcp) 📇 🏠 – Een Node.js MCP-server die geïsoleerde, op Docker gebaseerde sandboxes opstart voor het uitvoeren van JavaScript-snippets met directe npm-afhankelijkheidsinstallatie en schone afbouw.
- [r33drichards/mcp-js](https://github.com/r33drichards/mcp-js) 🦀 🏠 🐧 🍎 - Een JavaScript code-uitvoeringssandbox die v8 gebruikt om code te isoleren zodat AI-gegenereerde JavaScript lokaal kan worden uitgevoerd zonder angst. Ondersteunt heap-snapshotting voor persistente sessies.

### 🤖 <a name="coding-agents"></a>Coding Agents

Volledige codeeragenten die LLM's in staat stellen om code te lezen, bewerken en uitvoeren en volledig autonoom algemene programmeertaken op te lossen.

- [oraios/serena](https://github.com/oraios/serena)🐍🏠 - Een volledig uitgeruste codeeragent die vertrouwt op symbolische codebewerkingen met behulp van taalservers.
- [ezyang/codemcp](https://github.com/ezyang/codemcp) 🐍🏠 - Codeeragent met basis lees-, schrijf- en commandoregeltools.
- [doggybee/mcp-server-leetcode](https://github.com/doggybee/mcp-server-leetcode) 📇 ☁️ - Een MCP-server die AI-modellen in staat stelt om LeetCode-problemen te zoeken, op te halen en op te lossen. Ondersteunt metadatafiltering, gebruikersprofielen, inzendingen en toegang tot contestdata.
- [jinzcdev/leetcode-mcp-server](https://github.com/jinzcdev/leetcode-mcp-server) 📇 ☁️ - MCP-server die geautomatiseerde toegang biedt tot **LeetCode** programmeerproblemen, oplossingen, inzendingen en openbare data met optionele authenticatie voor gebruikersspecifieke functies (zoals notities), en ondersteunt zowel `leetcode.com` (globaal) als `leetcode.cn` (China).
- [juehang/vscode-mcp-server](https://github.com/juehang/vscode-mcp-server) 📇 🏠 - Een MCP-server die AI zoals Claude in staat stelt om de directorystructuur in een VS Code-werkruimte te lezen, problemen die door linter(s) en de taalserver worden opgepikt te zien, codebestanden te lezen en bewerkingen uit te voeren.
- [micl2e2/code-to-tree](https://github.com/micl2e2/code-to-tree) 🌊 🏠 📟 🐧 🪟 🍎 - Een single-binary MCP-server die broncode omzet in een AST, ongeacht de taal.

### 🖥️ <a name="command-line"></a>Command Line

Voer commando's uit, leg uitvoer vast en interacteer verder met shells en commandoregeltools.

- [ferrislucas/iterm-mcp](https://github.com/ferrislucas/iterm-mcp) 🖥️ 🛠️ 💬 - Een Model Context Protocol-server die toegang biedt tot iTerm. Je kunt commando's uitvoeren en vragen stellen over wat je in het iTerm-terminal ziet.
- [g0t4/mcp-server-commands](https://github.com/g0t4/mcp-server-commands) 📇 🏠 - Voer elk commando uit met de tools `run_command` en `run_script`.
- [maxim-saplin/mcp_safe_local_python_executor](https://github.com/maxim-saplin/mcp_safe_local_python_executor) - Veilige Python-interpreter gebaseerd op HF Smolagents `LocalPythonExecutor`
- [MladenSU/cli-mcp-server](https://github.com/MladenSU/cli-mcp-server) 🐍 🏠 - Commandoregelinterface met veilige uitvoering en aanpasbaar beveiligingsbeleid
- [OthmaneBlial/term_mcp_deepseek](https://github.com/OthmaneBlial/term_mcp_deepseek) 🐍 🏠 - Een DeepSeek MCP-achtige Server voor Terminal
- [tumf/mcp-shell-server](https://github.com/tumf/mcp-shell-server) - Een veilige shell command execution server die het Model Context Protocol (MCP) implementeert
- [automateyournetwork/pyATS_MCP](https://github.com/automateyournetwork/pyATS_MCP) - Cisco pyATS-server die gestructureerde, modelgestuurde interactie met netwerkapparaten mogelijk maakt.
- [wonderwhy-er/DesktopCommanderMCP](https://github.com/wonderwhy-er/DesktopCommanderMCP) 📇 🏠 🍎 🪟 🐧 - Een Zwitsers zakmes dat programma's kan beheren/uitvoeren en code- en tekstbestanden kan lezen/schrijven/zoeken/bewerken.
- [tufantunc/ssh-mcp](https://github.com/tufantunc/ssh-mcp) 📇 🏠 🐧 🪟 - MCP-server die SSH-controle biedt voor Linux- en Windows-servers via Model Context Protocol. Voer op veilige wijze shellcommando's op afstand uit met wachtwoord- of SSH-sleutelauthenticatie.

### 💬 <a name="communication"></a>Communication

Integratie met communicatieplatforms voor berichtbeheer en kanaalbewerkingen. Maakt het voor AI-modellen mogelijk om te interageren met teamcommunicatietools.

- [AbdelStark/nostr-mcp](https://github.com/AbdelStark/nostr-mcp) ☁️ - Een Nostr MCP-server waarmee je kunt interageren met Nostr, zoals het plaatsen van notities, en meer.
- [adhikasp/mcp-twikit](https://github.com/adhikasp/mcp-twikit) 🐍 ☁️ - Interactie met Twitter-zoekopdrachten en tijdlijn
- [agentmail-toolkit/mcp](https://github.com/agentmail-to/agentmail-toolkit/tree/main/mcp) 🐍 💬 - Een MCP-server om on-the-fly inboxen aan te maken voor het verzenden, ontvangen en uitvoeren van acties op e-mail. Wij zijn geen AI-agenten voor e-mail, maar e-mail voor AI-agenten.
- [arpitbatra123/mcp-googletasks](https://github.com/arpitbatra123/mcp-googletasks) 📇 ☁️ - Een MCP-server voor interface met de Google Tasks API
- [carterlasalle/mac_messages_mcp](https://github.com/carterlasalle/mac_messages_mcp) 🏠 🍎 🚀 - Een MCP-server die veilig interface met je iMessage-database via het Model Context Protocol (MCP), waardoor LLM's iMessage-gesprekken kunnen opvragen en analyseren. Inclusief robuuste validatie van telefoonnummers, verwerking van bijlagen, contactbeheer, groepschatbeheer en volledige ondersteuning voor het verzenden en ontvangen van berichten.
- [chaindead/telegram-mcp](https://github.com/chaindead/telegram-mcp) 🏎️ 🏠 - Telegram API-integratie voor toegang tot gebruikersgegevens, beheren van dialogen (chats, kanalen, groepen), ophalen van berichten en beheren van leesstatus
- [chigwell/telegram-mcp](https://github.com/chigwell/telegram-mcp) 🐍 🏠 - Telegram API-integratie voor toegang tot gebruikersdata, beheren van dialogen (chats, kanalen, groepen), ophalen van berichten, verzenden van berichten en beheren van leesstatus.
- [elie222/inbox-zero](https://github.com/elie222/inbox-zero/tree/main/apps/mcp-server) 🐍 ☁️ - Een MCP-server voor Inbox Zero. Voegt functionaliteit toe aan Gmail, zoals uitzoeken op welke e-mails je moet antwoorden of moet opvolgen.
- [gitmotion/ntfy-me-mcp](https://github.com/gitmotion/ntfy-me-mcp) 📇 ☁️ 🏠 - Een ntfy MCP-server voor het verzenden/ophalen van ntfy-notificaties naar je zelf-gehoste ntfy-server vanuit AI Agents 📤 (ondersteunt veilige token-auth & meer - gebruik met npx of docker!)
- [gotoolkits/wecombot](https://github.com/gotoolkits/mcp-wecombot-server.git) 🚀 ☁️ - Een MCP-serverapplicatie die verschillende soorten berichten verzendt naar de WeCom-groep-robot.
- [hannesrudolph/imessage-query-fastmcp-mcp-server](https://github.com/hannesrudolph/imessage-query-fastmcp-mcp-server) 🐍 🏠 🍎 - Een MCP-server die veilige toegang biedt tot je iMessage-database via Model Context Protocol (MCP), waardoor LLM's iMessage-gesprekken kunnen opvragen en analyseren met correcte validatie van telefoonnummers en verwerking van bijlagen
- [i-am-bee/acp-mcp](https://github.com/i-am-bee/acp-mcp) 🐍 💬 - Een MCP-server die fungeert als adapter naar het [ACP](https://agentcommunicationprotocol.dev) ecosysteem. Stelt ACP-agenten naadloos bloot aan MCP-clients en overbrugt zo het communicatiegat tussen beide protocollen.
- [jagan-shanmugam/mattermost-mcp-host](https://github.com/jagan-shanmugam/mattermost-mcp-host) 🐍 🏠 - Een MCP-server samen met MCP-host die toegang biedt tot Mattermost-teams, kanalen en berichten. MCP-host is geïntegreerd als een bot in Mattermost met toegang tot MCP-servers die configureerbaar zijn.
- [lharries/whatsapp-mcp](https://github.com/lharries/whatsapp-mcp) 🐍 🏎️ - Een MCP-server voor het doorzoeken van je persoonlijke WhatsApp-berichten, contacten en het verzenden van berichten naar individuen of groepen
- [line/line-bot-mcp-server](https://github.com/line/line-bot-mcp-server) 🎖 📇 ☁️ - MCP-server voor integratie met LINE Official Account
- [MarkusPfundstein/mcp-gsuite](https://github.com/MarkusPfundstein/mcp-gsuite) 🐍 ☁️ - Integratie met Gmail en Google Calendar.
- [modelcontextprotocol/server-bluesky](https://github.com/keturiosakys/bluesky-context-server) 📇 ☁️ - Bluesky-instantie-integratie voor opvraging en interactie
- [modelcontextprotocol/server-slack](https://github.com/modelcontextprotocol/servers/tree/main/src/slack) 📇 ☁️ - Slack-werkruimte-integratie voor kanaalbeheer en messaging
- [korotovsky/slack-mcp-server](https://github.com/korotovsky/slack-mcp-server) 📇 ☁️ - De krachtigste MCP-server voor Slack-werkruimtes.
- [sawa-zen/vrchat-mcp](https://github.com/sawa-zen/vrchat-mcp) - 📇 🏠 Dit is een MCP-server voor interactie met de VRChat API. Je kunt informatie opvragen over vrienden, werelden, avatars en meer in VRChat.
- [takumi0706/google-calendar-mcp](https://github.com/takumi0706/google-calendar-mcp) 📇 ☁️ - Een MCP-server voor interface met de Google Calendar API. Gebaseerd op TypeScript.
- [teddyzxcv/ntfy-mcp](https://github.com/teddyzxcv/ntfy-mcp) - De MCP-server die je op de hoogte houdt door notificaties op je telefoon te sturen via ntfy
- [userad/didlogic_mcp](https://github.com/UserAd/didlogic_mcp) 🐍 ☁️ - Een MCP-server voor [DIDLogic](https://didlogic.com). Biedt functionaliteit om SIP-eindpunten, nummers en bestemmingen te beheren.
- [zcaceres/gtasks-mcp](https://github.com/zcaceres/gtasks-mcp) 📇 ☁️ - Een MCP-server om Google Tasks te beheren
- [InditexTech/mcp-teams-server](https://github.com/InditexTech/mcp-teams-server) 🐍 ☁️ - MCP-server die Microsoft Teams messaging integreert (lezen, posten, noemen, leden en threads weergeven)
- [softeria/ms-365-mcp-server](https://github.com/softeria/ms-365-mcp-server) 📇 ☁️ - MCP-server die verbinding maakt met de volledige Microsoft 365-suite via Graph API (inclusief mail, bestanden, Excel, agenda)
- [YCloud-Developers/ycloud-whatsapp-mcp-server](https://github.com/YCloud-Developers/ycloud-whatsapp-mcp-server) 📇 🏠 - MCP-server voor WhatsApp Business Platform door YCloud.
- [jaipandya/producthunt-mcp-server](https://github.com/jaipandya/producthunt-mcp-server) 🐍 🏠 - MCP-server voor Product Hunt. Interageer met trending posts, reacties, collecties, gebruikers en meer.


### 👤 <a name="customer-data-platforms"></a>Customer Data Platforms

Biedt toegang tot klantprofielen binnen customer data platforms

- [iaptic/mcp-server-iaptic](https://github.com/iaptic/mcp-server-iaptic) 🎖️ 📇 ☁️ - Verbind met [iaptic](https://www.iaptic.com) om vragen te stellen over je klantenaankopen, transactiegegevens en app-omzetstatistieken.
- [OpenDataMCP/OpenDataMCP](https://github.com/OpenDataMCP/OpenDataMCP) 🐍 ☁️ - Koppel elke Open Data aan elke LLM met Model Context Protocol.
- [sergehuber/inoyu-mcp-unomi-server](https://github.com/sergehuber/inoyu-mcp-unomi-server) 📇 ☁️ - Een MCP-server voor toegang tot en updates van profielen op een Apache Unomi CDP-server.
- [tinybirdco/mcp-tinybird](https://github.com/tinybirdco/mcp-tinybird) 🐍 ☁️ - Een MCP-server om te interageren met een Tinybird-werkruimte vanaf elke MCP-client.
- [@antv/mcp-server-chart](https://github.com/antvis/mcp-server-chart) 🎖️ 📇 ☁️ - Een Model Context Protocol-server voor het genereren van visuele grafieken met [AntV](https://github.com/antvis).

### 🗄️ <a name="databases"></a>Databases

Veilige database-toegang met schema-inspectiemogelijkheden. Maakt het mogelijk om data te bevragen en te analyseren met configureerbare beveiligingscontroles, waaronder alleen-lezen toegang.

- [Aiven-Open/mcp-aiven](https://github.com/Aiven-Open/mcp-aiven) - 🐍 ☁️ 🎖️ - Navigeer door je [Aiven-projecten](https://go.aiven.io/mcp-server) en interacteer met de PostgreSQL®, Apache Kafka®, ClickHouse® en OpenSearch® diensten
- [alexanderzuev/supabase-mcp-server](https://github.com/alexander-zuev/supabase-mcp-server) - Supabase MCP-server met ondersteuning voor SQL-query-uitvoering en databaseverkenningstools
- [aliyun/alibabacloud-tablestore-mcp-server](https://github.com/aliyun/alibabacloud-tablestore-mcp-server) ☕ 🐍 ☁️ - MCP-service voor Tablestore, functies omvatten toevoegen van documenten, semantisch zoeken naar documenten op basis van vectoren en schalen, RAG-vriendelijk, en serverless.
- [benborla29/mcp-server-mysql](https://github.com/benborla/mcp-server-mysql) ☁️ 🏠 - MySQL-database-integratie in NodeJS met configureerbare toegangscontroles en schema-inspectie
- [bytebase/dbhub](https://github.com/bytebase/dbhub) 📇 🏠 – Universele database MCP-server die de gangbare databases ondersteunt.
- [c4pt0r/mcp-server-tidb](https://github.com/c4pt0r/mcp-server-tidb) 🐍 ☁️ - TiDB-database-integratie met schema-inspectie en querymogelijkheden
- [Canner/wren-engine](https://github.com/Canner/wren-engine) 🐍 🦀 🏠 - De Semantic Engine voor Model Context Protocol(MCP)-clients en AI-agenten
- [centralmind/gateway](https://github.com/centralmind/gateway) 🏎️ 🏠 🍎 🪟 - MCP- en MCP SSE-server die automatisch een API genereert op basis van databaseschema en data. Ondersteunt PostgreSQL, Clickhouse, MySQL, Snowflake, BigQuery, Supabase
- [ChristianHinge/dicom-mcp](https://github.com/ChristianHinge/dicom-mcp) 🐍 ☁️ 🏠 - DICOM-integratie om medische beelden en rapporten van PACS en andere DICOM-conforme systemen op te vragen, te lezen en te verplaatsen.
- [chroma-core/chroma-mcp](https://github.com/chroma-core/chroma-mcp) 🎖️ 🐍 ☁️ 🏠 - Chroma MCP-server voor toegang tot lokale en cloud Chroma-instanties voor retrieval-mogelijkheden
- [ClickHouse/mcp-clickhouse](https://github.com/ClickHouse/mcp-clickhouse) 🐍 ☁️ - ClickHouse-database-integratie met schema-inspectie en querymogelijkheden
- [confluentinc/mcp-confluent](https://github.com/confluentinc/mcp-confluent) 🐍 ☁️ - Confluent-integratie om te communiceren met Confluent Kafka en Confluent Cloud REST API's.
- [Couchbase-Ecosystem/mcp-server-couchbase](https://github.com/Couchbase-Ecosystem/mcp-server-couchbase) 🎖️ 🐍 ☁️ 🏠 - Couchbase MCP-server biedt uniforme toegang tot zowel Capella cloud als zelfbeheerde clusters voor documentbewerkingen, SQL++-query's en natuurlijke taal data-analyse.
- [cr7258/elasticsearch-mcp-server](https://github.com/cr7258/elasticsearch-mcp-server) 🐍 🏠 - MCP Server-implementatie die Elasticsearch-interactie mogelijk maakt.
- [crystaldba/postgres-mcp](https://github.com/crystaldba/postgres-mcp) 🐍 🏠 - Alles-in-één MCP-server voor Postgres-ontwikkeling en -operaties, met tools voor prestatieanalyse, tuning en gezondheidscontroles.
- [Dataring-engineering/mcp-server-trino](https://github.com/Dataring-engineering/mcp-server-trino) 🐍 ☁️ - Trino MCP-server om data op te vragen en te benaderen vanuit Trino Clusters.
- [tuannvm/mcp-trino](https://github.com/tuannvm/mcp-trino) 🏎️ ☁️ - Een Go-implementatie van een Model Context Protocol (MCP) server voor Trino.
- [designcomputer/mysql_mcp_server](https://github.com/designcomputer/mysql_mcp_server) 🐍 🏠 - MySQL-database-integratie met configureerbare toegangscontroles, schema-inspectie en uitgebreide beveiligingsrichtlijnen.
- [wenb1n-dev/mysql_mcp_server_pro](https://github.com/wenb1n-dev/mysql_mcp_server_pro)  🐍 🏠 - Ondersteunt SSE, STDIO; niet alleen beperkt tot MySQL's CRUD-functionaliteit; bevat ook database-exceptieanalyse; regelt databasepermissies op basis van rollen; en maakt het eenvoudig voor ontwikkelaars om tools uit te breiden met maatwerk.
- [domdomegg/airtable-mcp-server](https://github.com/domdomegg/airtable-mcp-server) 📇 🏠 - Airtable-database-integratie met schema-inspectie, lees- en schrijfmogelijkheden.
- [edwinbernadus/nocodb-mcp-server](https://github.com/edwinbernadus/nocodb-mcp-server) 📇 ☁️ - Nocodb-database-integratie, lees- en schrijfmogelijkheden.
- [ergut/mcp-bigquery-server](https://github.com/ergut/mcp-bigquery-server) 📇 ☁️ - Serverimplementatie voor Google BigQuery-integratie die directe BigQuery-database-toegang en querymogelijkheden biedt.
- [f4ww4z/mcp-mysql-server](https://github.com/f4ww4z/mcp-mysql-server) 📇 🏠 - Node.js-gebaseerde MySQL-database-integratie die veilige MySQL-databasebewerkingen biedt.
- [fireproof-storage/mcp-database-server](https://github.com/fireproof-storage/mcp-database-server) 📇 ☁️ - Fireproof ledger-database met multi-user synchronisatie.
- [FreePeak/db-mcp-server](https://github.com/FreePeak/db-mcp-server) 🏎️ 🏠 – Een high-performance multi-database MCP-server gebouwd met Golang, ondersteunt MySQL & PostgreSQL (NoSQL binnenkort beschikbaar). Inclusief ingebouwde tools voor query-uitvoering, transactiemanagement, schema-exploratie, querybouw en prestatie-analyse, met naadloze Cursor-integratie voor geavanceerde database-workflows.
- [furey/mongodb-lens](https://github.com/furey/mongodb-lens) 📇 🏠 - MongoDB Lens: Volledig uitgeruste MCP-server voor MongoDB-databases.
- [gannonh/firebase-mcp](https://github.com/gannonh/firebase-mcp) 🔥 ⛅️ - Firebase-diensten inclusief Auth, Firestore en Storage.
- [get-convex/convex-backend](https://stack.convex.dev/convex-mcp-server) 📇 ☁️ - Convex-database-integratie om tabellen, functies te inspecteren en eenmalige query's uit te voeren ([Bron](https://github.com/get-convex/convex-backend/blob/main/npm-packages/convex/src/cli/mcp.ts))
- [googleapis/genai-toolbox](https://github.com/googleapis/genai-toolbox) 🏎️ ☁️ - Open source MCP-server die gespecialiseerd is in eenvoudige, snelle en veilige tools voor databases.
- [GreptimeTeam/greptimedb-mcp-server](https://github.com/GreptimeTeam/greptimedb-mcp-server) 🐍 🏠 - MCP-server voor het uitvoeren van query's op GreptimeDB.
- [hannesrudolph/sqlite-explorer-fastmcp-mcp-server](https://github.com/hannesrudolph/sqlite-explorer-fastmcp-mcp-server) 🐍 🏠 - Een MCP-server die veilige, alleen-lezen toegang tot SQLite-databases biedt via Model Context Protocol (MCP). Deze server is gebouwd met het FastMCP-framework, waarmee LLM's SQLite-databases kunnen verkennen en bevragen met ingebouwde veiligheidsfuncties en query-validatie.
- [idoru/influxdb-mcp-server](https://github.com/idoru/influxdb-mcp-server) 📇 ☁️ 🏠 - Voer query's uit op InfluxDB OSS API v2.
- [isaacwasserman/mcp-snowflake-server](https://github.com/isaacwasserman/mcp-snowflake-server) 🐍 ☁️ - Snowflake-integratie die lees- en (optioneel) schrijfoperaties en inzichtentracking implementeert.
- [joshuarileydev/supabase-mcp-server](https://github.com/joshuarileydev/supabase) - Supabase MCP-server voor het beheren en aanmaken van projecten en organisaties in Supabase.
- [jovezhong/mcp-timeplus](https://github.com/jovezhong/mcp-timeplus) 🐍 ☁️ - MCP-server voor Apache Kafka en Timeplus. Kan Kafka-topics weergeven, Kafka-berichten ophalen, Kafka-data lokaal opslaan en streamingdata opvragen met SQL via Timeplus.
- [KashiwaByte/vikingdb-mcp-server](https://github.com/KashiwaByte/vikingdb-mcp-server) 🐍 ☁️ - VikingDB-integratie met collectie- en indexintroductie, vectoropslag en zoekmogelijkheden.
- [kiliczsh/mcp-mongo-server](https://github.com/kiliczsh/mcp-mongo-server) 📇 🏠 - Een Model Context Protocol-server voor MongoDB.
- [ktanaka101/mcp-server-duckdb](https://github.com/ktanaka101/mcp-server-duckdb) 🐍 🏠 - DuckDB-database-integratie met schema-inspectie en querymogelijkheden.
- [LucasHild/mcp-server-bigquery](https://github.com/LucasHild/mcp-server-bigquery) 🐍 ☁️ - BigQuery-database-integratie met schema-inspectie en querymogelijkheden.
- [quarkiverse/mcp-server-jdbc](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/jdbc) ☕ 🏠 - Verbind met elke JDBC-compatibele database en voer query's uit, voeg toe, update, verwijder, en meer.
- [jparkerweb/mcp-sqlite](https://github.com/jparkerweb/mcp-sqlite) 📇 🏠 - Model Context Protocol (MCP) server die uitgebreide SQLite-database-interactiemogelijkheden biedt.
- [memgraph/mcp-memgraph](https://github.com/memgraph/mcp-memgraph) 🐍 🏠 - Memgraph MCP-server - bevat een tool om een query uit te voeren op Memgraph en een schemaresource.
- [modelcontextprotocol/server-postgres](https://github.com/modelcontextprotocol/servers/tree/main/src/postgres) 📇 🏠 - PostgreSQL-database-integratie met schema-inspectie en querymogelijkheden.
- [modelcontextprotocol/server-sqlite](https://github.com/modelcontextprotocol/servers/tree/main/src/sqlite) 🐍 🏠 - SQLite-databasebewerkingen met ingebouwde analysefuncties.
- [neo4j-contrib/mcp-neo4j](https://github.com/neo4j-contrib/mcp-neo4j) 🐍 🏠 - Model Context Protocol met Neo4j (Query's uitvoeren, Knowledge Graph Memory, Neo4j Aura-instanties beheren).
- [neondatabase/mcp-server-neon](https://github.com/neondatabase/mcp-server-neon) 📇 ☁️ — Een MCP-server voor het aanmaken en beheren van Postgres-databases met Neon Serverless Postgres.
- [niledatabase/nile-mcp-server](https://github.com/niledatabase/nile-mcp-server) MCP-server voor het Postgres-platform van Nile - Beheer en bevraging van Postgres-databases, tenants, gebruikers, authenticatie via LLM's.
- [openlink/mcp-server-odbc](https://github.com/OpenLinkSoftware/mcp-odbc-server) 🐍 🏠 - Een MCP-server voor generieke Database Management System (DBMS)-connectiviteit via het Open Database Connectivity (ODBC)-protocol.
- [openlink/mcp-server-sqlalchemy](https://github.com/OpenLinkSoftware/mcp-sqlalchemy-server) 🐍 🏠 - Een MCP-server voor generieke DBMS-connectiviteit via SQLAlchemy met gebruik van Python ODBC (pyodbc).
- [pab1it0/adx-mcp-server](https://github.com/pab1it0/adx-mcp-server) 🐍 ☁️ - Query en analyseer Azure Data Explorer-databases.
- [pab1it0/prometheus-mcp-server](https://github.com/pab1it0/prometheus-mcp-server) 🐍 ☁️ -  Query en analyseer Prometheus, het open-source monitoringsysteem.
- [prisma/prisma](https://github.com/prisma/prisma) 🐍 🏠 - Geeft LLM's de mogelijkheid om Prisma Postgres-databases te beheren (bijv. nieuwe database-instanties opzetten of schema-migraties uitvoeren).
- [qdrant/mcp-server-qdrant](https://github.com/qdrant/mcp-server-qdrant) 🐍 🏠 - Een Qdrant MCP-server.
- [QuantGeekDev/mongo-mcp](https://github.com/QuantGeekDev/mongo-mcp) 📇 🏠 - MongoDB-integratie die LLM's in staat stelt direct met databases te interageren.
- [rashidazarang/airtable-mcp](https://github.com/rashidazarang/airtable-mcp) 🐍 ☁️ - Verbind AI-tools direct met Airtable. Query, maak, update en verwijder records met natuurlijke taal. Functies omvatten basemanagement, tabelbewerkingen, schema-manipulatie, recordfiltering en datamigratie via een gestandaardiseerde MCP-interface.
- [redis/mcp-redis](https://github.com/redis/mcp-redis) 🐍 🏠 - De officiële Redis MCP-server biedt een interface om data in Redis te beheren en te doorzoeken.
- [runekaagaard/mcp-alchemy](https://github.com/runekaagaard/mcp-alchemy) 🐍 🏠 - Universele SQLAlchemy-gebaseerde database-integratie met ondersteuning voor PostgreSQL, MySQL, MariaDB, SQLite, Oracle, MS SQL Server en veel meer databases. Functies: schema- en relatie-inspectie en analyse van grote datasets.
- [sirmews/mcp-pinecone](https://github.com/sirmews/mcp-pinecone) 🐍 ☁️ - Pinecone-integratie met vectorzoekmogelijkheden.
- [skysqlinc/skysql-mcp](https://github.com/skysqlinc/skysql-mcp) 🎖️ ☁️ - Serverloze MariaDB Cloud DB MCP-server. Tools om databases te starten, verwijderen, SQL uit te voeren en te werken met database-niveau AI-agenten voor nauwkeurige text-2-sql en conversaties.
- [supabase-community/supabase-mcp](https://github.com/supabase-community/supabase-mcp) 🎖️ 📇 ☁️ - Officiële Supabase MCP-server om AI-assistenten direct met je Supabase-project te verbinden en taken uit te laten voeren zoals tabellen beheren, config ophalen en data opvragen.
- [TheRaLabs/legion-mcp](https://github.com/TheRaLabs/legion-mcp) 🐍 🏠 Universele database MCP-server die meerdere databasetypen ondersteunt waaronder PostgreSQL, Redshift, CockroachDB, MySQL, RDS MySQL, Microsoft SQL Server, BigQuery, Oracle DB en SQLite.
- [tradercjz/dolphindb-mcp-server](https://github.com/tradercjz/dolphindb-mcp-server) 🐍 ☁️ - TDolphinDB-database-integratie met schema-inspectie en querymogelijkheden.
- [weaviate/mcp-server-weaviate](https://github.com/weaviate/mcp-server-weaviate) 🐍 📇 ☁️ - Een MCP-server om verbinding te maken met je Weaviate-collecties als kennisbank, en Weaviate te gebruiken als chatgeheugenopslag.
- [XGenerationLab/xiyan_mcp_server](https://github.com/XGenerationLab/xiyan_mcp_server) 📇 ☁️ — Een MCP-server die het ophalen van data uit een database ondersteunt via natuurlijke taalquery's, aangedreven door XiyanSQL als de text-to-SQL LLM.
- [xing5/mcp-google-sheets](https://github.com/xing5/mcp-google-sheets) 🐍 ☁️ - Een Model Context Protocol-server voor interactie met Google Sheets. Deze server biedt tools om spreadsheets aan te maken, lezen, bij te werken en te beheren via de Google Sheets API.
- [freema/mcp-gsheets](https://github.com/freema/mcp-gsheets) 📇 ☁️ - MCP-server voor Google Sheets API-integratie met uitgebreide lees-, schrijf-, opmaak- en sheetbeheer-mogelijkheden.
- [Zhwt/go-mcp-mysql](https://github.com/Zhwt/go-mcp-mysql) 🏎️ 🏠 – Gebruiksvriendelijke, zero dependency MySQL MCP-server gebouwd met Golang, met configureerbare alleen-lezen modus en schema-inspectie.
- [ydb/ydb-mcp](https://github.com/ydb-platform/ydb-mcp) 🎖️ 🐍 ☁️ - MCP-server voor interactie met [YDB](https://ydb.tech)-databases.
- [zilliztech/mcp-server-milvus](https://github.com/zilliztech/mcp-server-milvus) 🐍 🏠 ☁️ - MCP-server voor Milvus / Zilliz, waarmee interactie met je database mogelijk is.
- [openlink/mcp-server-jdbc](https://github.com/OpenLinkSoftware/mcp-jdbc-server) 🐍 🏠 - Een MCP-server voor generieke Database Management System (DBMS)-connectiviteit via het Java Database Connectivity (JDBC)-protocol.
- [yincongcyincong/VictoriaMetrics-mcp-server](https://github.com/yincongcyincong/VictoriaMetrics-mcp-server) 🐍 🏠 - Een MCP-server voor interactie met VictoriaMetrics-database.
- [hydrolix/mcp-hydrolix](https://github.com/hydrolix/mcp-hydrolix) 🎖️ 🐍 ☁️ - Hydrolix time-series datalake-integratie die schema-exploratie en querymogelijkheden biedt aan LLM-gebaseerde workflows.
- [davewind/mysql-mcp-server](https://github.com/dave-wind/mysql-mcp-server) 🏎️ 🏠 A – gebruiksvriendelijke alleen-lezen mysql mcp-server voor cursor en n8n...


### 📊 <a name="data-platforms"></a>Dataplatformen

Dataplatformen voor dataintegratie, transformatie en pijplijnorkestratie.

- [flowcore/mcp-flowcore-platform](https://github.com/flowcore-io/mcp-flowcore-platform) 🎖️ 📇 ☁️ 🏠 - Interacteer met Flowcore om acties uit te voeren, data te importeren, te analyseren, te kruisen en elk type data te benutten in je datakernen of in publieke datakernen; allemaal met menselijke taal.
- [JordiNei/mcp-databricks-server](https://github.com/JordiNeil/mcp-databricks-server) 🐍 ☁️ - Verbind met de Databricks API, waarmee LLM's SQL-query's kunnen uitvoeren, jobs kunnen weergeven en jobstatussen kunnen opvragen.
- [yashshingvi/databricks-genie-MCP](https://github.com/yashshingvi/databricks-genie-MCP) 🐍 ☁️ - Een server die verbinding maakt met de Databricks Genie API, zodat LLM's natuurlijke taalvragen kunnen stellen, SQL-query's uitvoeren en met Databricks-conversatieagenten kunnen interageren.
- [jwaxman19/qlik-mcp](https://github.com/jwaxman19/qlik-mcp) 📇 ☁️ - MCP-server voor Qlik Cloud API waarmee applicaties, sheets en data uit visualisaties opgevraagd kunnen worden met uitgebreide authenticatie en ondersteuning voor rate limiting.
- [keboola/keboola-mcp-server](https://github.com/keboola/keboola-mcp-server) 🐍 - Interactie met het Keboola Connection Data Platform. Deze server biedt tools voor het weergeven en benaderen van data uit de Keboola Storage API.
- [dbt-labs/dbt-mcp](https://github.com/dbt-labs/dbt-mcp) 🎖️ 🐍 🏠 ☁️ - Officiële MCP-server voor [dbt (data build tool)](https://www.getdbt.com/product/what-is-dbt) die integratie biedt met dbt Core/Cloud CLI, projectmetadata-ontdekking, modelinformatie en semantische laag-querymogelijkheden.
- [mattijsdp/dbt-docs-mcp](https://github.com/mattijsdp/dbt-docs-mcp) 🐍 🏠 - MCP-server voor dbt-core (OSS)-gebruikers, aangezien de officiële dbt MCP alleen dbt Cloud ondersteunt. Ondersteunt projectmetadata, model- en kolomniveau-afstamming en dbt-documentatie.

### 💻 <a name="developer-tools"></a>Ontwikkelaarstools

Tools en integraties die de ontwikkelworkflow en omgevingsbeheer verbeteren.

- [Pratyay/mac-monitor-mcp](https://github.com/Pratyay/mac-monitor-mcp) 🐍 🏠 🍎 - Identificeert resource-intensieve processen op macOS en biedt suggesties voor prestatieverbeteringen.
- [21st-dev/Magic-MCP](https://github.com/21st-dev/magic-mcp) - Maak samengestelde UI-componenten geïnspireerd door de beste 21st.dev design engineers.
- [Hypersequent/qasphere-mcp](https://github.com/Hypersequent/qasphere-mcp) 🎖️ 📇 ☁️ - Integratie met het [QA Sphere](https://qasphere.com/) testmanagementsysteem, waardoor LLM's testcases direct kunnen ontdekken, samenvatten en ermee kunnen interacteren vanuit AI-gestuurde IDE's.
- [admica/FileScopeMCP](https://github.com/admica/FileScopeMCP) 🐍 📇 🦀 - Analyseert je codebase en identificeert belangrijke bestanden op basis van afhankelijkheidsrelaties. Genereert diagrammen en belangscores, waardoor AI-assistenten de codebase beter begrijpen.
- [ambar/simctl-mcp](https://github.com/ambar/simctl-mcp) 📇 🏠 🍎 Een MCP-serverimplementatie voor iOS Simulator-besturing.
- [api7/apisix-mcp](https://github.com/api7/apisix-mcp) 🎖️ 📇 🏠 MCP-server met ondersteuning voor opvragen en beheren van alle resources in [Apache APISIX](https://github.com/apache/apisix).
- [ArchAI-Labs/fastmcp-sonarqube-metrics](https://github.com/ArchAI-Labs/fastmcp-sonarqube-metrics) 🐍 🏠 🪟 🐧 🍎 -  Een Model Context Protocol (MCP) server met tools voor het ophalen van informatie over SonarQube-projecten, zoals metrics (actueel en historisch), issues, gezondheidsstatus.
- [automation-ai-labs/mcp-link](https://github.com/automation-ai-labs/mcp-link) 🏎️ 🏠 - Integreer naadloos elke API met AI Agents (met OpenAPI-schema).
- [azer/react-analyzer-mcp](https://github.com/azer/react-analyzer-mcp) 📇 🏠 - Analyseer React-code lokaal, genereer documentatie / llm.txt voor het hele project in één keer.
- [davidlin2k/pox-mcp-server](https://github.com/davidlin2k/pox-mcp-server) 🐍 🏠 - MCP-server voor de POX SDN-controller die netwerkbeheer en -controle mogelijk maakt.
- [CodeLogicIncEngineering/codelogic-mcp-server](https://github.com/CodeLogicIncEngineering/codelogic-mcp-server) 🎖️ 🐍 ☁️ 🍎 🪟 🐧 - Officiële MCP-server voor CodeLogic, biedt toegang tot code-afhankelijkheidsanalyse, architectuurrisicoanalyse en impactanalyse-tools.
- [Comet-ML/Opik-MCP](https://github.com/comet-ml/opik-mcp) 🎖️ 📇 ☁️ 🏠 - Gebruik natuurlijke taal om LLM-observability, traces en monitoringdata vastgelegd door Opik te verkennen.
- [CircleCI/mcp-server-circleci](https://github.com/CircleCI-Public/mcp-server-circleci) 📇 ☁️ Maakt het mogelijk voor AI Agents om build failures van CircleCI op te lossen.
- [currents-dev/currents-mcp](https://github.com/currents-dev/currents-mcp) 🎖️ 📇 ☁️ Maakt het mogelijk voor AI Agents om Playwright test failures gemeld aan [Currents](https://currents.dev) te repareren.
- [delano/postman-mcp-server](https://github.com/delano/postman-mcp-server) 📇 ☁️ - Interactie met de [Postman API](https://www.postman.com/postman/postman-public-workspace/)
- [flipt-io/mcp-server-flipt](https://github.com/flipt-io/mcp-server-flipt) 📇 🏠 - Maakt het mogelijk voor AI-assistenten om te interageren met je feature flags in [Flipt](https://flipt.io).
- [GLips/Figma-Context-MCP](https://github.com/GLips/Figma-Context-MCP) 📇 🏠 - Biedt coding agents directe toegang tot Figma-data om te helpen met one-shot designimplementatie.
- [gofireflyio/firefly-mcp](https://github.com/gofireflyio/firefly-mcp) 🎖️ 📇 ☁️ - Integreert, ontdekt, beheert en codeert cloudresources met [Firefly](https://firefly.ai).
- [Govcraft/rust-docs-mcp-server](https://github.com/Govcraft/rust-docs-mcp-server) 🦀 🏠 - Biedt up-to-date documentatiecontext voor een specifieke Rust-crate aan LLM's via een MCP-tool, met gebruik van semantisch zoeken (embeddings) en LLM-samenvatting.
- [haris-musa/excel-mcp-server](https://github.com/haris-musa/excel-mcp-server) 🐍 🏠 - Een Excel-manipulatieserver die werkboekcreatie, databewerkingen, opmaak en geavanceerde functies (grafieken, draaitabellen, formules) ondersteunt.
- [higress-group/higress-ops-mcp-server](https://github.com/higress-group/higress-ops-mcp-server) 🐍 🏠 - MCP-server die uitgebreide tools biedt voor het beheren van [Higress](https://github.com/alibaba/higress) gateway-configuraties en -operaties.
- [hijaz/postmancer](https://github.com/hijaz/postmancer) 📇 🏠 - Een MCP-server als vervanging voor Rest Clients zoals Postman/Insomnia, door je LLM in staat te stellen API-collecties te beheren en te gebruiken.
- [hloiseaufcms/mcp-gopls](https://github.com/hloiseaufcms/mcp-gopls) 🏎️ 🏠 - Een MCP-server voor interactie met [Go's Language Server Protocol (gopls)](https://github.com/golang/tools/tree/master/gopls) en profiteren van geavanceerde Go-codeanalysefuncties.
- [hungthai1401/bruno-mcp](https://github.com/hungthai1401/bruno-mcp) 📇 🏠 - Een MCP-server voor interactie met [Bruno API Client](https://www.usebruno.com/).
- [hyperb1iss/droidmind](https://github.com/hyperb1iss/droidmind) 🐍 🏠 - Bedien Android-apparaten met AI via MCP, voor apparaatcontrole, debugging, systeemanalyse en UI-automatisering met een uitgebreid beveiligingsframework.
- [XixianLiang/HarmonyOS-mcp-server](https://github.com/XixianLiang/HarmonyOS-mcp-server) 🐍 🏠 - Bedien HarmonyOS-next apparaten met AI via MCP. Ondersteunt apparaatbediening en UI-automatisering.
- [IlyaGulya/gradle-mcp-server](https://github.com/IlyaGulya/gradle-mcp-server) 🏠 - Gradle-integratie via de Gradle Tooling API om projecten te inspecteren, taken uit te voeren en tests te draaien met per-test resultaatrapportage.
- [InhiblabCore/mcp-image-compression](https://github.com/InhiblabCore/mcp-image-compression) 🐍 🏠 - MCP-server voor lokale compressie van diverse afbeeldingsformaten.
- [isaacphi/mcp-language-server](https://github.com/isaacphi/mcp-language-server) 🏎️ 🏠 - MCP Language Server helpt MCP-compatibele clients makkelijker door codebasissen te navigeren door toegang tot semantische tools als get definition, references, rename en diagnostics.
- [ios-simulator-mcp](https://github.com/joshuayoes/ios-simulator-mcp) 📇 🏠 🍎 - Een Model Context Protocol (MCP) server voor interactie met iOS-simulatoren. Hiermee kun je informatie opvragen, UI-interacties aansturen en UI-elementen inspecteren.
- [InditexTech/mcp-server-simulator-ios-idb](https://github.com/InditexTech/mcp-server-simulator-ios-idb) 📇 🏠 🍎 - Een Model Context Protocol (MCP) server waarmee LLM's kunnen communiceren met iOS-simulatoren (iPhone, iPad, enz.) via natuurlijke taalopdrachten.
- [IvanAmador/vercel-ai-docs-mcp](https://github.com/IvanAmador/vercel-ai-docs-mcp) 📇 🏠 - Een Model Context Protocol (MCP) server die AI-gestuurde zoek- en querymogelijkheden biedt voor de Vercel AI SDK-documentatie.
- [j4c0bs/mcp-server-sql-analyzer](https://github.com/j4c0bs/mcp-server-sql-analyzer) 🐍 - MCP-server die SQL-analyse, linting en dialectconversie biedt via [SQLGlot](https://github.com/tobymao/sqlglot).
- [jasonjmcghee/claude-debugs-for-you](https://github.com/jasonjmcghee/claude-debugs-for-you) 📇 🏠 - Een MCP-server en VS Code-extensie voor (taalonafhankelijke) automatische debugging via breakpoints en expressie-evaluatie.
- [jetbrains/mcpProxy](https://github.com/JetBrains/mcpProxy) 🎖️ 📇 🏠 - Verbinden met JetBrains IDE.
- [qainsights/jmeter-mcp-server](https://github.com/QAInsights/jmeter-mcp-server) 🐍 🏠 - JMeter MCP Server voor performancetests.
- [Jktfe/serveMyAPI](https://github.com/Jktfe/serveMyAPI) 📇 🏠 🍎 - Een persoonlijke MCP (Model Context Protocol) server voor het veilig opslaan en benaderen van API-sleutels via de macOS Keychain.
- [joshuarileydev/app-store-connect-mcp-server](https://github.com/JoshuaRileyDev/app-store-connect-mcp-server) 📇 🏠 - Een MCP-server om te communiceren met de App Store Connect API voor iOS-ontwikkelaars.
- [joshuarileydev/simulator-mcp-server](https://github.com/JoshuaRileyDev/simulator-mcp-server) 📇 🏠 - Een MCP-server voor het aansturen van iOS-simulatoren.
- [qainsights/k6-mcp-server](https://github.com/QAInsights/k6-mcp-server) 🐍 🏠 - Grafana k6 MCP Server voor performancetests.
- [lamemind/mcp-server-multiverse](https://github.com/lamemind/mcp-server-multiverse) 📇 🏠 🛠️ - Een middleware-server waarmee meerdere geïsoleerde instanties van dezelfde MCP-servers onafhankelijk kunnen coëxisteren met unieke namespaces en configuraties.
- [langfuse/mcp-server-langfuse](https://github.com/langfuse/mcp-server-langfuse) 🐍 🏠 - MCP-server voor toegang tot en beheer van LLM-applicatieprompts gecreëerd met [Langfuse]([https://langfuse.com/](https://langfuse.com/docs/prompts/get-started)) Prompt Management.
- [mobile-next/mobile-mcp](https://github.com/mobile-next/mobile-mcp) 📇 🏠 🐧 🍎 - MCP-server voor Android/iOS-applicatie- en apparaatautomatisering, ontwikkeling en app scraping. Simulator/Emulator/Fysieke apparaten zoals iPhone, Google Pixel, Samsung ondersteund.
- [qainsights/locust-mcp-server](https://github.com/QAInsights/locust-mcp-server) 🐍 🏠 - Locust MCP Server voor performancetests.
- [mrexodia/user-feedback-mcp](https://github.com/mrexodia/user-feedback-mcp) 🐍 🏠 - Simpele MCP-server voor een human-in-the-loop workflow in tools als Cline en Cursor.
- [narumiruna/gitingest-mcp](https://github.com/narumiruna/gitingest-mcp) 🐍 🏠 - Een MCP-server die [gitingest](https://github.com/cyclotruc/gitingest) gebruikt om elke Git-repository om te zetten naar een eenvoudige tekstsamenvatting van de codebase.
- [OctoMind-dev/octomind-mcp](https://github.com/OctoMind-dev/octomind-mcp) 📇 ☁️ - Laat je favoriete AI-agent volledig beheerde [Octomind](https://www.octomind.dev/) end-to-end tests creëren en uitvoeren vanaf je codebase of andere gegevensbronnen zoals Jira, Slack of TestRail.
- [kadykov/mcp-openapi-schema-explorer](https://github.com/kadykov/mcp-openapi-schema-explorer) 📇 ☁️ 🏠 - Token-efficiënte toegang tot OpenAPI/Swagger-specificaties via MCP Resources.
- [pskill9/website-downloader](https://github.com/pskill9/website-downloader) 🗄️ 🚀 - Deze MCP-server biedt een tool om volledige websites te downloaden met wget. Behoudt de website-structuur en converteert links voor lokaal gebruik.
- [utensils/mcp-nixos](https://github.com/utensils/mcp-nixos) 🐍 🏠 - MCP-server die accurate informatie biedt over NixOS-pakketten, systeemopties, Home Manager-configuraties en nix-darwin macOS-instellingen om AI-hallucinaties te voorkomen.
- [QuantGeekDev/docker-mcp](https://github.com/QuantGeekDev/docker-mcp) 🏎️ 🏠 - Docker-containerbeheer en operaties via MCP.
- [ckreiling/mcp-server-docker](https://github.com/ckreiling/mcp-server-docker) 🐍 🏠 - Integreert met Docker om containers, images, volumes en netwerken te beheren.
- [r-huijts/xcode-mcp-server](https://github.com/r-huijts/xcode-mcp-server) 📇 🏠 🍎 - Xcode-integratie voor projectbeheer, bestandsoperaties en buildautomatisering.
- [ReAPI-com/mcp-openapi](https://github.com/ReAPI-com/mcp-openapi) 📇 🏠 - MCP-server waarmee LLM's alles over je OpenAPI-specificaties kunnen ontdekken, uitleggen en code/mockdata kunnen genereren.
- [Rootly-AI-Labs/Rootly-MCP-server](https://github.com/Rootly-AI-Labs/Rootly-MCP-server) 🎖️ 🐍 ☁️ 🍎 - MCP-server voor het incident management platform [Rootly](https://rootly.com/).
- [sammcj/mcp-package-version](https://github.com/sammcj/mcp-package-version) 📇 🏠 - Een MCP-server om LLM's te helpen de nieuwste stabiele pakketversies te suggereren bij het schrijven van code.
- [sapientpants/sonarqube-mcp-server](https://github.com/sapientpants/sonarqube-mcp-server) 🦀 ☁️ 🏠 - Een Model Context Protocol (MCP) server die integreert met SonarQube voor toegang tot codekwaliteitsstatistieken, issues en quality gate-statussen.
- [SDGLBL/mcp-claude-code](https://github.com/SDGLBL/mcp-claude-code) 🐍 🏠 - Een implementatie van Claude Code-functionaliteit via MCP, waarmee AI code kan begrijpen, wijzigen en projectanalyse uitvoeren met uitgebreide toolondersteuning.
- [snaggle-ai/openapi-mcp-server](https://github.com/snaggle-ai/openapi-mcp-server) 🏎️ 🏠 - Verbind elke HTTP/REST API-server via een Open API spec (v3).
- [stass/lldb-mcp](https://github.com/stass/lldb-mcp) 🐍 🏠 🐧 🍎 - Een MCP-server voor LLDB waarmee AI binair- en core file-analyse, debugging en disassemblage mogelijk is.
- [TencentEdgeOne/edgeone-pages-mcp](https://github.com/TencentEdgeOne/edgeone-pages-mcp) 📇 ☁️ - Een MCP-service voor het uitrollen van HTML-content naar EdgeOne Pages en verkrijgen van een publiek toegankelijke URL.
- [tumf/mcp-text-editor](https://github.com/tumf/mcp-text-editor) 🐍 🏠 - Een regelgeoriënteerde tekstbestandseditor. Geoptimaliseerd voor LLM-tools met efficiënte gedeeltelijke bestandsbenadering om tokengebruik te minimaliseren.
- [vivekvells/mcp-pandoc](https://github.com/vivekVells/mcp-pandoc) 🗄️ 🚀 - MCP-server voor naadloze documentformaatconversie met Pandoc, ondersteunt Markdown, HTML, PDF, DOCX (.docx), csv en meer.
- [VSCode Devtools](https://github.com/biegehydra/BifrostMCP) 📇 - Verbind met VSCode IDE en gebruik semantische tools zoals `find_usages`.
- [xcodebuild](https://github.com/ShenghaiWang/xcodebuild) 🍎 Bouw iOS Xcode workspace/project en geef fouten terug aan LLM.
- [xzq.xu/jvm-mcp-server](https://github.com/xzq-xu/jvm-mcp-server) 📇 🏠  - Een implementatieproject van een JVM-gebaseerde MCP (Model Context Protocol) server.
- [yangkyeongmo@/mcp-server-apache-airflow](https://github.com/yangkyeongmo/mcp-server-apache-airflow) 🐍 🏠 - MCP-server die verbindt met [Apache Airflow](https://airflow.apache.org/) via de officiële client.
- [YuChenSSR/mindmap-mcp-server](https://github.com/YuChenSSR/mindmap-mcp-server) 🐍 🏠 - Een Model Context Protocol (MCP) server voor het genereren van een mooie interactieve mindmap.
- [YuChenSSR/multi-ai-advisor](https://github.com/YuChenSSR/multi-ai-advisor-mcp) 📇 🏠 - Een Model Context Protocol (MCP) server die meerdere Ollama-modellen bevraagt en hun antwoorden combineert, voor diverse AI-perspectieven op een enkele vraag.
- [yWorks/mcp-typescribe](https://github.com/yWorks/mcp-typescribe) 📇 🏠 - MCP-server die efficiënt Typescript API-informatie levert aan de agent zodat deze kan werken met niet-getrainde APIs.
- [zcaceres/fetch-mcp](https://github.com/zcaceres/fetch-mcp) 📇 🏠 - Een MCP-server om flexibel JSON-, tekst- en HTML-data op te halen.
- [zenml-io/mcp-zenml](https://github.com/zenml-io/mcp-zenml) 🐍 🏠 ☁️ - Een MCP-server voor koppeling met je [ZenML](https://www.zenml.io) MLOps- en LLMOps-pijplijnen.
- [idosal/git-mcp](https://github.com/idosal/git-mcp) 📇 ☁️ - [gitmcp.io](https://gitmcp.io/) is een generieke remote MCP-server om verbinding te maken met ELKE [GitHub](https://www.github.com) repository of project voor documentatie.
- [tgeselle/bugsnag-mcp](https://github.com/tgeselle/bugsnag-mcp) 📇 ☁️ - Een MCP-server voor interactie met [Bugsnag](https://www.bugsnag.com/).
- [jordandalton/restcsv-mcp-server](https://github.com/JordanDalton/RestCsvMcpServer) 📇 ☁️ - Een MCP-server voor CSV-bestanden.
- [cjo4m06/mcp-shrimp-task-manager](https://github.com/cjo4m06/mcp-shrimp-task-manager) 📇 ☁️ 🏠 – Een programmeergerichte taakbeheertool die codeeragenten zoals Cursor AI versterkt met geavanceerd taakgeheugen, zelfreflectie en afhankelijkheidsbeheer. [ShrimpTaskManager](https://cjo4m06.github.io/mcp-shrimp-task-manager)
- [axliupore/mcp-code-runner](https://github.com/axliupore/mcp-code-runner) 📇 🏠 - Een MCP-server voor lokaal uitvoeren van code via Docker met ondersteuning voor meerdere programmeertalen.
- [yikakia/godoc-mcp-server](https://github.com/yikakia/godoc-mcp-server) 🏎️ ☁️ 🪟 🐧 🍎 - Informatie over Go-pakketten opvragen op pkg.go.dev.
- [ckanthony/gin-mcp](https://github.com/ckanthony/gin-mcp) 🏎️ ☁️ 📟 🪟 🐧 🍎 - Een zero-configuratie Go-bibliotheek om automatisch bestaande Gin web framework API's als MCP-tools te exposen.
- [ryan0204/github-repo-mcp](https://github.com/Ryan0204/github-repo-mcp) 📇 ☁️ 🪟 🐧 🍎 - GitHub Repo MCP laat je AI-assistenten GitHub repositories doorzoeken, mappen verkennen en bestandsinhoud bekijken.
- [alimo7amed93/webhook-tester-mcp](https://github.com/alimo7amed93/webhook-tester-mcp)  🐍 ☁️ – Een FastMCP-gebaseerde server voor interactie met webhook-test.com. Hiermee kunnen gebruikers webhooks lokaal aanmaken, ophalen en verwijderen met Claude.
- [lpigeon/ros-mcp-server](https://github.com/lpigeon/ros-mcp-server) 🐍 🏠 🍎 🪟 🐧 - De ROS MCP-server ondersteunt robotbediening door gebruikerscommando's in natuurlijke taal om te zetten naar ROS of ROS2-bedieningscommando's.
- [jsdelivr/globalping-mcp-server](https://github.com/jsdelivr/globalping-mcp-server) 🎖️ 📇 ☁️ - De Globalping MCP-server biedt gebruikers en LLM's toegang tot netwerktools zoals ping, traceroute, mtr, HTTP en DNS-resolutie vanaf duizenden locaties wereldwijd.
- [posthog/mcp](https://github.com/posthog/mcp) 🎖️ 📇 ☁️ - Een MCP-server voor interactie met PostHog analytics, feature flags, error tracking en meer.
- [artmann/package-registry-mcp](https://github.com/artmann/package-registry-mcp) 🏠 📇 🍎 🪟 🐧 - MCP-server voor zoeken en verkrijgen van actuele informatie over NPM-, Cargo-, PyPi- en NuGet-pakketten.

### 🔒 <a name="delivery"></a>Bezorging

- [https://github.com/jordandalton/doordash-mcp-server](https://github.com/JordanDalton/DoorDash-MCP-Server) 🐍 – DoorDash Bezorging (Onofficieel)

### 🧮 <a name="data-science-tools"></a>Data Science Tools

Integraties en tools ontworpen om data-exploratie, analyse en data science workflows te vereenvoudigen en te verbeteren.

- [ChronulusAI/chronulus-mcp](https://github.com/ChronulusAI/chronulus-mcp) 🐍 ☁️ - Voorspel alles met Chronulus AI forecasting- en predictie-agents.
- [reading-plus-ai/mcp-server-data-exploration](https://github.com/reading-plus-ai/mcp-server-data-exploration) 🐍 ☁️ - Maakt autonome data-exploratie op .csv-gebaseerde datasets mogelijk, met intelligente inzichten met minimale inspanning.
- [zcaceres/markdownify-mcp](https://github.com/zcaceres/markdownify-mcp) 📇 🏠 - Een MCP-server om bijna elk bestand of webinhoud om te zetten naar Markdown.
- [datalayer/jupyter-mcp-server](https://github.com/datalayer/jupyter-mcp-server) 🐍 🏠 - Model Context Protocol (MCP) Server voor Jupyter.
- [jjsantos01/jupyter-notebook-mcp](https://github.com/jjsantos01/jupyter-notebook-mcp) 🐍 🏠 - Verbindt Jupyter Notebook met Claude AI, waardoor Claude direct kan interageren met en controle uitoefenen over Jupyter Notebooks.
- [arrismo/kaggle-mcp](https://github.com/arrismo/kaggle-mcp) 🐍 ☁️ - Verbindt met Kaggle, mogelijkheid om datasets te downloaden en analyseren.
- [kdqed/zaturn](https://github.com/kdqed/zaturn) 🐍 🏠 🪟 🐧 🍎 - Koppel meerdere databronnen (SQL, CSV, Parquet, enz.) en vraag AI om de data te analyseren voor inzichten en visualisaties.
- [mckinsey/vizro-mcp](https://github.com/mckinsey/vizro/tree/main/vizro-mcp) 🎖️ 🐍 🏠 - Tools en sjablonen om gevalideerde en onderhoudbare data-grafieken en dashboards te creëren.
- [growthbook/growthbook-mcp](https://github.com/growthbook/growthbook-mcp) 🎖️ 📇 🏠 🪟 🐧 🍎 — Tools voor het creëren en beheren van GrowthBook feature flags en experimenten.

### 📟 <a name="embedded-system"></a>Embedded System

Biedt toegang tot documentatie en snelkoppelingen voor het werken met embedded apparaten.

- [horw/esp-mcp](https://github.com/horw/esp-mcp) 📟 - Workflow voor het oplossen van buildproblemen op ESP32-serie chips met ESP-IDF.
- [kukapay/modbus-mcp](https://github.com/kukapay/modbus-mcp) 🐍 📟 - Een MCP-server die industriële Modbus-data standaardiseert en contextualiseert.
- [kukapay/opcua-mcp](https://github.com/kukapay/opcua-mcp) 🐍 📟 - Een MCP-server die verbinding maakt met OPC UA-compatibele industriële systemen.
- [yoelbassin/gnuradioMCP](https://github.com/yoelbassin/gnuradioMCP) 🐍 📟 🏠 - Een MCP-server voor GNU Radio waarmee LLM's autonoom RF `.grc` flowcharts kunnen aanmaken en aanpassen.

### 📂 <a name="file-systems"></a>Bestandssystemen

Biedt directe toegang tot lokale bestandssystemen met instelbare permissies. Hiermee kunnen AI-modellen bestanden lezen, schrijven en beheren binnen gespecificeerde mappen.

- [cyberchitta/llm-context.py](https://github.com/cyberchitta/llm-context.py) 🐍 🏠 - Deel codecontext met LLM's via MCP of klembord.
- [exoticknight/mcp-file-merger](https://github.com/exoticknight/mcp-file-merger) 🏎️ 🏠 - Tool voor het samenvoegen van bestanden, geschikt voor AI-chatlengtebeperkingen.
- [filesystem@quarkiverse/quarkus-mcp-servers](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/filesystem) ☕ 🏠 - Een bestandssysteem waarmee je bestanden kunt doorzoeken en bewerken, geïmplementeerd in Java met Quarkus. Beschikbaar als jar of native image.
- [hmk/box-mcp-server](https://github.com/hmk/box-mcp-server) 📇 ☁️ - Box-integratie voor het weergeven, lezen en zoeken van bestanden
- [mamertofabian/mcp-everything-search](https://github.com/mamertofabian/mcp-everything-search) 🐍 🏠 🪟 - Snelle Windows-bestandszoekfunctie met Everything SDK
- [mark3labs/mcp-filesystem-server](https://github.com/mark3labs/mcp-filesystem-server) 🏎️ 🏠 - Golang-implementatie voor lokale bestandsysteemtoegang.
- [mickaelkerjean/filestash](https://github.com/mickael-kerjean/filestash/tree/master/server/plugin/plg_handler_mcp) 🏎️ ☁️ - Toegang tot externe opslag: SFTP, S3, FTP, SMB, NFS, WebDAV, GIT, FTPS, gcloud, azure blob, sharepoint, enz.
- [microsoft/markitdown](https://github.com/microsoft/markitdown/tree/main/packages/markitdown-mcp) 🎖️ 🐍 🏠 - MCP-tooltoegang tot MarkItDown -- een bibliotheek die veel bestandsformaten (lokaal of extern) omzet naar Markdown voor LLM-consumptie.
- [modelcontextprotocol/server-filesystem](https://github.com/modelcontextprotocol/servers/tree/main/src/filesystem) 📇 🏠 - Directe lokale bestandsysteemtoegang.
- [modelcontextprotocol/server-google-drive](https://github.com/modelcontextprotocol/servers/tree/main/src/gdrive) 📇 ☁️ - Google Drive-integratie voor het weergeven, lezen en zoeken van bestanden
- [Xuanwo/mcp-server-opendal](https://github.com/Xuanwo/mcp-server-opendal) 🐍 🏠 ☁️ - Toegang tot elke opslag met Apache OpenDAL™
- [jeannier/homebrew-mcp](https://github.com/jeannier/homebrew-mcp) 🐍 🏠 🍎 - Beheer je macOS Homebrew-installatie met natuurlijke taal via deze MCP-server. Beheer eenvoudig je pakketten, vraag om suggesties, los brew-problemen op, enz.

### 💰 <a name="finance--fintech"></a>Financiën & Fintech

Toegang tot en analyse van financiële data. Maakt het mogelijk voor AI-modellen om te werken met marktdata, handelsplatforms en financiële informatie.

- [aaronjmars/web3-research-mcp](https://github.com/aaronjmars/web3-research-mcp) 📇 ☁️ - Diepgaand onderzoek voor crypto - gratis & volledig lokaal
- [alchemy/alchemy-mcp-server](https://github.com/alchemyplatform/alchemy-mcp-server) 🎖️ 📇 ☁️ - Laat AI-agenten communiceren met de blockchain-API's van Alchemy.
- [OctagonAI/octagon-mcp-server](https://github.com/OctagonAI/octagon-mcp-server) 🐍 ☁️ - Octagon AI Agenten voor integratie van private en publieke marktdata
- [anjor/coinmarket-mcp-server](https://github.com/anjor/coinmarket-mcp-server) 🐍 ☁️ - Coinmarket API-integratie om cryptocurrency-lijsten en koersen op te halen
- [ariadng/metatrader-mcp-server](https://github.com/ariadng/metatrader-mcp-server) 🐍 🏠 🪟 - Laat AI LLM's handelen uitvoeren via het MetaTrader 5-platform
- [armorwallet/armor-crypto-mcp](https://github.com/armorwallet/armor-crypto-mcp) 🐍 ☁️ - MCP voor interface met meerdere blockchains, staking, DeFi, swap, bridging, walletbeheer, DCA, Limit Orders, Coin Lookup, Tracking en meer.
- [bankless/onchain-mcp](https://github.com/Bankless/onchain-mcp/) 📇 ☁️ - Bankless Onchain API voor interactie met smart contracts, transactie- en tokeninformatie opvragen
- [base/base-mcp](https://github.com/base/base-mcp) 🎖️ 📇 ☁️ - Base Network-integratie voor onchain-tools, interactie met Base Network en Coinbase API voor walletbeheer, geldtransfers, smart contracts en DeFi-operaties
- [berlinbra/alpha-vantage-mcp](https://github.com/berlinbra/alpha-vantage-mcp) 🐍 ☁️ - Alpha Vantage API-integratie om aandelen- en cryptogegevens op te halen
- [ahnlabio/bicscan-mcp](https://github.com/ahnlabio/bicscan-mcp) 🎖️ 🐍 ☁️ - Risicoscore / activa-overzicht van EVM blockchain-adressen (EOA, CA, ENS) en zelfs domeinnamen.
- [bitteprotocol/mcp](https://github.com/BitteProtocol/mcp) 📇 - Bitte Protocol-integratie om AI-agenten op meerdere blockchains te laten draaien.
- [chargebee/mcp](https://github.com/chargebee/agentkit/tree/main/modelcontextprotocol) 🎖️ 📇 ☁️ - MCP Server die AI-agenten verbindt met het [Chargebee platform](https://www.chargebee.com/).
- [codex-data/codex-mcp](https://github.com/Codex-Data/codex-mcp) 🎖️ 📇 ☁️ - [Codex API](https://www.codex.io)-integratie voor real-time verrijkte blockchain- en marktdata op 60+ netwerken
- [coinpaprika/dexpaprika-mcp](https://github.com/chargebee/agentkit/tree/main/modelcontextprotocol) 🎖️ 📇 ☁️ 🍎 🪟 🐧 - Coinpaprika's DexPaprika MCP-server biedt high-performance toegang tot de [DexPaprika API](https://docs.dexpaprika.com) met real-time prijzen, liquiditeitspooldata en historische OHLCV-data over 20+ chains en 5M+ tokens, waarmee AI-agenten gestandaardiseerd toegang krijgen tot uitgebreide marktdata via Model Context Protocol.
- [doggybee/mcp-server-ccxt](https://github.com/doggybee/mcp-server-ccxt) 📇 ☁️ - Een MCP-server voor real-time cryptomarktdata en trading via 20+ exchanges met de CCXT-bibliotheek. Ondersteunt spot, futures, OHLCV, saldi, orders en meer.
- [ferdousbhai/investor-agent](https://github.com/ferdousbhai/investor-agent) 🐍 ☁️ - Yahoo Finance-integratie om aandelenmarktdata op te halen inclusief optiesaanbevelingen
- [ferdousbhai/tasty-agent](https://github.com/ferdousbhai/tasty-agent) 🐍 ☁️ - Tastyworks API-integratie voor handelsactiviteiten op Tastytrade
- [ferdousbhai/wsb-analyst-mcp](https://github.com/ferdousbhai/wsb-analyst-mcp) 🐍 ☁️ - Reddit-integratie voor analyse van content op de WallStreetBets-community
- [getalby/nwc-mcp-server](https://github.com/getalby/nwc-mcp-server) 📇 🏠 - Bitcoin Lightning wallet-integratie op basis van Nostr Wallet Connect
- [heurist-network/heurist-mesh-mcp-server](https://github.com/heurist-network/heurist-mesh-mcp-server) 🎖️ ⛅️ 🏠 🐍 - Toegang tot gespecialiseerde web3 AI-agenten voor blockchain-analyse, smart contract security-auditing, tokenmetrics-evaluatie en on-chain interacties via het Heurist Mesh-netwerk. Biedt uitgebreide tools voor DeFi-analyse, NFT-waardering en transactiemonitoring over meerdere blockchains.
- [intentos-labs/beeper-mcp](https://github.com/intentos-labs/beeper-mcp) 🐍 - Beeper levert transacties op BSC, inclusief saldo/token-overdrachten, token-swaps in Pancakeswap en beeper-beloningclaims.
- [kukapay/blockbeats-mcp](https://github.com/kukapay/blockbeats-mcp) 🐍 ☁️ -  Een MCP-server die blockchainnieuws en diepgaande artikelen van BlockBeats levert voor AI-agenten.
- [kukapay/bridge-rates-mcp](https://github.com/kukapay/bridge-rates-mcp) 📇 ☁️ - Real-time cross-chain bridge rates en optimale transferroutes voor onchain AI-agenten.
- [kukapay/chainlink-feeds-mcp](https://github.com/kukapay/chainlink-feeds-mcp) 📇 ☁️ -  Real-time toegang tot Chainlink's gedecentraliseerde on-chain prijsfeeds.
- [kukapay/cointelegraph-mcp](https://github.com/kukapay/cointelegraph-mcp) 🐍 ☁️ -  Real-time toegang tot het laatste nieuws van Cointelegraph.
- [kukapay/crypto-feargreed-mcp](https://github.com/kukapay/crypto-feargreed-mcp) 🐍 ☁️ -  Real-time en historische Crypto Fear & Greed Index data.
- [kukapay/crypto-indicators-mcp](https://github.com/kukapay/crypto-indicators-mcp) 🐍 ☁️ - Een MCP-server met verschillende cryptocurrency technische analyse-indicatoren en strategieën.
- [kukapay/crypto-news-mcp](https://github.com/kukapay/crypto-news-mcp) 🐍 ☁️ - Een MCP-server die real-time cryptocurrency nieuws levert van NewsData voor AI-agenten.
- [kukapay/crypto-portfolio-mcp](https://github.com/kukapay/crypto-portfolio-mcp) 🐍 ☁️ - Een MCP-server voor het volgen en beheren van cryptocurrency-portfolioverdelingen.
- [kukapay/crypto-rss-mcp](https://github.com/kukapay/crypto-rss-mcp) 🐍 ☁️ - Een MCP-server die real-time cryptocurrency nieuws van meerdere RSS-feeds aggregeert.
- [kukapay/crypto-sentiment-mcp](https://github.com/kukapay/crypto-sentiment-mcp) 🐍 ☁️ - Een MCP-server die cryptocurrency sentimentanalyse levert aan AI-agenten.
- [kukapay/crypto-trending-mcp](https://github.com/kukapay/crypto-trending-mcp) 🐍 ☁️ - Volgt de laatste trending tokens op CoinGecko.
- [kukapay/crypto-whitepapers-mcp](https://github.com/kukapay/crypto-whitepapers-mcp) 🐍 ☁️ - Dient als gestructureerde kennisbank van crypto-whitepapers.
- [kukapay/cryptopanic-mcp-server](https://github.com/kukapay/cryptopanic-mcp-server) 🐍 ☁️ - Levert het laatste cryptocurrency nieuws aan AI-agenten, aangedreven door CryptoPanic.
- [kukapay/defi-yields-mcp](https://github.com/kukapay/defi-yields-mcp) 🐍 ☁️ - Een MCP-server voor AI-agenten om DeFi-rendementskansen te verkennen.
- [kukapay/dune-analytics-mcp](https://github.com/kukapay/dune-analytics-mcp) 🐍 ☁️ -  Een MCP-server die Dune Analytics-data koppelt aan AI-agenten.
- [kukapay/etf-flow-mcp](https://github.com/kukapay/etf-flow-mcp) 🐍 ☁️ -  Levert crypto ETF-flowdata voor besluitvorming van AI-agenten.
- [kukapay/freqtrade-mcp](https://github.com/kukapay/freqtrade-mcp) 🐍 ☁️ - Een MCP-server die integreert met de Freqtrade cryptocurrency trading bot.
- [kukapay/funding-rates-mcp](https://github.com/kukapay/funding-rates-mcp) 🐍 ☁️ - Real-time fundingratedata van grote crypto-exchanges.
- [kukapay/jupiter-mcp](https://github.com/kukapay/jupiter-mcp) 🐍 ☁️ - Een MCP-server voor het uitvoeren van token-swaps op de Solana-blockchain via Jupiter's Ultra API.
- [kukapay/pancakeswap-poolspy-mcp](https://github.com/kukapay/pancakeswap-poolspy-mcp) 🐍 ☁️ -  Een MCP-server die nieuw aangemaakte pools op Pancake Swap volgt.
- [kukapay/rug-check-mcp](https://github.com/kukapay/rug-check-mcp) 🐍 ☁️ - Een MCP-server die potentiële risico's in Solana meme-tokens detecteert.
- [kukapay/thegraph-mcp](https://github.com/kukapay/thegraph-mcp) 🐍 ☁️ -  Een MCP-server die AI-agenten voorziet van geïndexeerde blockchain-data van The Graph.
- [kukapay/token-minter-mcp](https://github.com/kukapay/token-minter-mcp) 🐍 ☁️ -  Een MCP-server die tools biedt voor AI-agenten om ERC-20-tokens te minten op meerdere blockchains.
- [kukapay/token-revoke-mcp](https://github.com/kukapay/token-revoke-mcp) 🐍 ☁️ - Een MCP-server voor het controleren en intrekken van ERC-20-tokenautorisaties op meerdere blockchains.
- [kukapay/twitter-username-changes-mcp](https://github.com/kukapay/twitter-username-changes-mcp) 🐍 ☁️ - Een MCP-server die historische wijzigingen van Twitter-gebruikersnamen bijhoudt.
- [kukapay/uniswap-poolspy-mcp](https://github.com/kukapay/uniswap-poolspy-mcp) 🐍 ☁️ -  Een MCP-server die nieuw aangemaakte liquiditeitspools op Uniswap op meerdere blockchains volgt.
- [kukapay/uniswap-trader-mcp](https://github.com/kukapay/uniswap-trader-mcp) 🐍 ☁️ -  Een MCP-server voor AI-agenten om token-swaps op Uniswap DEX op meerdere blockchains te automatiseren.
- [kukapay/whale-tracker-mcp](https://github.com/kukapay/whale-tracker-mcp) 🐍 ☁️ -  Een MCP-server voor het volgen van cryptocurrency whale-transacties.
- [laukikk/alpaca-mcp](https://github.com/laukikk/alpaca-mcp) 🐍 ☁️ - Een MCP-server voor de Alpaca trading API om aandelen- en cryptofondsen te beheren, trades te plaatsen en marktdata op te vragen.
- [longportapp/openapi](https://github.com/longportapp/openapi/tree/main/mcp) - 🐍 ☁️ - LongPort OpenAPI levert real-time aandelenmarktdata, biedt AI-toegang tot analyse en handelsmogelijkheden via MCP.
- [mcpdotdirect/evm-mcp-server](https://github.com/mcpdotdirect/evm-mcp-server) 📇 ☁️ - Uitgebreide blockchaindiensten voor 30+ EVM-netwerken, ondersteuning voor native tokens, ERC20, NFT's, smart contracts, transacties en ENS-resolutie.
- [mcpdotdirect/starknet-mcp-server](https://github.com/mcpdotdirect/starknet-mcp-server) 📇 ☁️ - Uitgebreide Starknet-blockchainintegratie met ondersteuning voor native tokens (ETH, STRK), smart contracts, StarknetID-resolutie en tokenoverdrachten.
- [minhyeoky/mcp-server-ledger](https://github.com/minhyeoky/mcp-server-ledger) 🐍 🏠 -  Een ledger-cli-integratie voor het beheren van financiële transacties en het genereren van rapporten.
- [openMF/mcp-mifosx](https://github.com/openMF/mcp-mifosx) ☁️ 🏠 -  Een core banking-integratie voor klantbeheer, leningen, spaargelden, aandelen, financiële transacties en het genereren van financiële rapporten.
- [narumiruna/yfinance-mcp](https://github.com/narumiruna/yfinance-mcp) 🐍 ☁️ - Een MCP-server die yfinance gebruikt om informatie van Yahoo Finance te verkrijgen.
- [polygon-io/mcp_polygon)](https://github.com/polygon-io/mcp_polygon)) 🐍 ☁️ -  Een MCP-server die toegang biedt tot [Polygon.io](https://polygon.io/) financiële marktdata-API's voor aandelen, indices, forex, opties en meer.
- [pwh-pwh/coin-mcp-server](https://github.com/pwh-pwh/coin-mcp-server) 🐍 ☁️ -  Bitget API om cryptocurrency-prijzen op te halen.
- [QuantGeekDev/coincap-mcp](https://github.com/QuantGeekDev/coincap-mcp) 📇 ☁️ - Real-time cryptomarktdata-integratie met CoinCap's publieke API, toegang tot cryptoprijzen en marktinformatie zonder API-sleutels
- [SaintDoresh/Crypto-Trader-MCP-ClaudeDesktop](https://github.com/SaintDoresh/Crypto-Trader-MCP-ClaudeDesktop.git) 🐍 ☁️ - Een MCP-tool die cryptomarktdata levert via de CoinGecko API.
- [tooyipjee/yahoofinance-mcp](https://github.com/tooyipjee/yahoofinance-mcp.git) 📇 ☁️ - TS-versie van yahoo finance mcp.
- [SaintDoresh/YFinance-Trader-MCP-ClaudeDesktop](https://github.com/SaintDoresh/YFinance-Trader-MCP-ClaudeDesktop.git) 🐍 ☁️ - Een MCP-tool die aandelenmarktdata en analyses levert via de Yahoo Finance API.
- [RomThpt/xrpl-mcp-server](https://github.com/RomThpt/mcp-xrpl) 📇 ☁️ - MCP-server voor het XRP Ledger met toegang tot accountinformatie, transactiegeschiedenis en netwerkdata. Maakt het mogelijk om ledgerobjecten te bevragen, transacties in te dienen en het XRPL-netwerk te monitoren.
- [janswist/mcp-dexscreener](https://github.com/janswist/mcp-dexscreener) 📇 ☁️ - Real-time on-chain marktprijzen via de open en gratis Dexscreener API
- [HuggingAGI/mcp-baostock-server](https://github.com/HuggingAGI/mcp-baostock-server) 🐍 ☁️ - MCP-server op basis van baostock, met toegang tot en analyse van Chinese aandelenmarktdata.
- [wowinter13/solscan-mcp](https://github.com/wowinter13/solscan-mcp) 🦀 🏠 - Een MCP-tool voor het opvragen van Solana-transacties via natuurlijke taal met de Solscan API.
- [Wuye-AI/mcp-server-wuye-ai](https://github.com/wuye-ai/mcp-server-wuye-ai) 🎖️ 📇 ☁️ - Een MCP-server die interacteert met de mogelijkheden van het CRIC Wuye AI-platform, een intelligente assistent specifiek voor de vastgoedbeheerindustrie.
- [zlinzzzz/finData-mcp-server](https://github.com/zlinzzzz/finData-mcp-server) 🐍 ☁️ - Een MCP-server voor toegang tot professionele financiële data, met ondersteuning voor meerdere dataproviders zoals Tushare.

### 🎮 <a name="gaming"></a>Gaming

Integratie met gamegerelateerde data, game-engines en diensten

- [IvanMurzak/Unity-MCP](https://github.com/IvanMurzak/Unity-MCP) #️⃣ 🏠 🍎 🪟 🐧 - MCP-server voor Unity Editor en voor een game gemaakt met Unity
- [CoderGamester/mcp-unity](https://github.com/CoderGamester/mcp-unity) #️⃣ 🏠 - MCP-server voor Unity3d Game Engine-integratie voor gameontwikkeling
- [Coding-Solo/godot-mcp](https://github.com/Coding-Solo/godot-mcp) 📇 🏠 - Een MCP-server voor interactie met de Godot-game-engine, met tools voor het bewerken, uitvoeren, debuggen en beheren van scènes in Godot-projecten.
- [pab1ito/chess-mcp](https://github.com/pab1it0/chess-mcp) 🐍 ☁️ - Toegang tot Chess.com spelerdata, spelrecords en andere openbare informatie via gestandaardiseerde MCP-interfaces, zodat AI-assistenten schaakinformatie kunnen zoeken en analyseren.
- [jiayao/mcp-chess](https://github.com/jiayao/mcp-chess) 🐍 🏠 - Een MCP-server die schaakt tegen LLM's.
- [rishijatia/fantasy-pl-mcp](https://github.com/rishijatia/fantasy-pl-mcp/) 🐍 ☁️ - Een MCP-server voor real-time Fantasy Premier League-data en analysetools.
- [opgginc/opgg-mcp](https://github.com/opgginc/opgg-mcp) 📇 ☁️ - Toegang tot real-time gamedata van populaire titels als League of Legends, TFT en Valorant, met champion analytics, e-sports schema’s, meta-composities en karakterstatistieken.
- [stefan-xyz/mcp-server-runescape](https://github.com/stefan-xyz/mcp-server-runescape) 📇 - Een MCP-server met tools voor interactie met RuneScape (RS) en Old School RuneScape (OSRS) data, inclusief itemprijzen, speler hiscores en meer.

### 🧠 <a name="knowledge--memory"></a>Kennis & Geheugen

Persistente opslag van geheugen via kennisgraafstructuren. Maakt het mogelijk voor AI-modellen om gestructureerde informatie over sessies heen te bewaren en te bevragen.
- [CheMiguel23/MemoryMesh](https://github.com/CheMiguel23/MemoryMesh) 📇 🏠 - Verbeterd grafengebaseerd geheugen met focus op AI-rollenspel en verhaal generatie
- [graphlit-mcp-server](https://github.com/graphlit/graphlit-mcp-server) 📇 ☁️ - Importeer alles van Slack, Discord, websites, Google Drive, Linear of GitHub in een Graphlit-project – en zoek en haal vervolgens relevante kennis op binnen een MCP-client zoals Cursor, Windsurf of Cline.
- [hannesrudolph/mcp-ragdocs](https://github.com/hannesrudolph/mcp-ragdocs) 🐍 🏠 - Een MCP-serverimplementatie die tools biedt voor het ophalen en verwerken van documentatie via vector search, waardoor AI-assistenten hun antwoorden kunnen verrijken met relevante context uit documentatie
- [jinzcdev/markmap-mcp-server](https://github.com/jinzcdev/markmap-mcp-server) 📇 🏠 - Een MCP-server gebouwd op [markmap](https://github.com/markmap/markmap) die **Markdown** omzet naar interactieve **mindmaps**. Ondersteunt exporteren naar meerdere formaten (PNG/JPG/SVG), live browser preview, een-klik Markdown kopiëren en dynamische visualisatiefuncties.
- [kaliaboi/mcp-zotero](https://github.com/kaliaboi/mcp-zotero) 📇 ☁️ - Een connector voor LLM’s om met collecties en bronnen in je Zotero Cloud te werken
- [mcp-summarizer](https://github.com/0xshellming/mcp-summarizer) 📕 ☁️ - AI Samenvattings-MCP-server, ondersteuning voor meerdere contenttypen: platte tekst, webpagina’s, PDF-documenten, EPUB-boeken, HTML-inhoud
- [mem0ai/mem0-mcp](https://github.com/mem0ai/mem0-mcp) 🐍 🏠 - Een Model Context Protocol-server voor Mem0 die helpt bij het beheren van codeervoorkeuren en -patronen, en tools biedt voor het opslaan, ophalen en semantisch verwerken van code-implementaties, best practices en technische documentatie in IDE’s zoals Cursor en Windsurf
- [modelcontextprotocol/server-memory](https://github.com/modelcontextprotocol/servers/tree/main/src/memory) 📇 🏠 - Persistent geheugensysteem gebaseerd op kennissen grafen voor het behouden van context
- [pinecone-io/assistant-mcp](https://github.com/pinecone-io/assistant-mcp) 🎖️ 🦀 ☁️ - Verbindt met je Pinecone Assistant en geeft de agent context uit zijn kennisengine.
- [@ragieai/mcp-server](https://github.com/ragieai/ragie-mcp-server) 📇 ☁️ - Haal context op uit je [Ragie](https://www.ragie.ai) (RAG) kennisbank gekoppeld aan integraties zoals Google Drive, Notion, JIRA en meer.
- [TechDocsStudio/biel-mcp](https://github.com/TechDocsStudio/biel-mcp) 📇 ☁️ - Laat AI-tools zoals Cursor, VS Code of Claude Desktop vragen beantwoorden met behulp van je productdocumentatie. Biel.ai levert het RAG-systeem en de MCP-server.
- [topoteretes/cognee](https://github.com/topoteretes/cognee/tree/dev/cognee-mcp) 📇 🏠 - Geheugenmanager voor AI-apps en agents met verschillende graf- en vectoropslag, en ondersteunt importeren vanuit meer dan 30 databronnen
- [unibaseio/membase-mcp](https://github.com/unibaseio/membase-mcp) 📇 ☁️ - Sla agentgeheugen gedistribueerd op en voer zoekopdrachten uit via Membase
- [GistPad-MCP](https://github.com/lostintangent/gistpad-mcp) 📇 🏠 - Gebruik GitHub Gists om je persoonlijke kennis, dagelijkse notities en herbruikbare prompts te beheren en te raadplegen. Dit werkt als aanvulling op https://gistpad.dev en de [GistPad VS Code-extensie](https://aka.ms/gistpad).
- [entanglr/zettelkasten-mcp](https://github.com/entanglr/zettelkasten-mcp) 🐍 🏠 - Een Model Context Protocol (MCP) server die de Zettelkasten kennismanagementmethodologie implementeert, waarmee je atomische notities kunt maken, linken en zoeken via Claude en andere MCP-compatibele clients.

### 🗺️ <a name="location-services"></a>Locatiediensten

Locatiegebaseerde diensten en mapping-tools. Maakt het mogelijk voor AI-modellen om met geografische data, weerinformatie en locatie-analyses te werken.

- [briandconnelly/mcp-server-ipinfo](https://github.com/briandconnelly/mcp-server-ipinfo) 🐍 ☁️  - IP-adres geolocatie en netwerkinformatie via de IPInfo API
- [devilcoder01/weather-mcp-server](https://github.com/devilcoder01/weather-mcp-server) 🐍 ☁️ - Toegang tot realtime weersgegevens voor elke locatie met de WeatherAPI.com API, inclusief gedetailleerde voorspellingen en huidige condities.
- [jagan-shanmugam/open-streetmap-mcp](https://github.com/jagan-shanmugam/open-streetmap-mcp) 🐍 🏠 - Een OpenStreetMap MCP-server met locatiegebaseerde diensten en georuimtelijke data.
- [kukapay/nearby-search-mcp](https://github.com/kukapay/nearby-search-mcp) 🐍 ☁️ - Een MCP-server voor het zoeken naar nabijgelegen plaatsen met IP-gebaseerde locatiebepaling.
- [modelcontextprotocol/server-google-maps](https://github.com/modelcontextprotocol/servers/tree/main/src/google-maps) 📇 ☁️ - Google Maps-integratie voor locatiediensten, routering en plaatsdetails
- [QGIS MCP](https://github.com/jjsantos01/qgis_mcp) - verbindt QGIS Desktop met Claude AI via de MCP. Deze integratie maakt prompt-ondersteunde projectcreatie, laagladen, code-uitvoering en meer mogelijk.
- [SaintDoresh/Weather-MCP-ClaudeDesktop](https://github.com/SaintDoresh/Weather-MCP-ClaudeDesktop.git) 🐍 ☁️ - Een MCP-tool die realtime weerdata, voorspellingen en historische weerinformatie biedt via de OpenWeatherMap API.
- [rossshannon/Weekly-Weather-mcp](https://github.com/rossshannon/weekly-weather-mcp.git) 🐍 ☁️ - Weekly Weather MCP-server die 7 volledige dagen aan gedetailleerde weersvoorspellingen wereldwijd teruggeeft.
- [SecretiveShell/MCP-timeserver](https://github.com/SecretiveShell/MCP-timeserver) 🐍 🏠 - Toegang tot de tijd in elke tijdzone en verkrijg de huidige lokale tijd
- [TimLukaHorstmann/mcp-weather](https://github.com/TimLukaHorstmann/mcp-weather) 📇 ☁️  - Nauwkeurige weersvoorspellingen via de AccuWeather API (gratis tier beschikbaar).
- [webcoderz/MCP-Geo](https://github.com/webcoderz/MCP-Geo) 🐍 🏠 - Geocoderings-MCP-server voor nominatim, ArcGIS, Bing
- [ipfind/ipfind-mcp-server](https://github.com/ipfind/ipfind-mcp-server) 🐍 ☁️ - IP-adreslocatieservice via de [IP Find](https://ipfind.com) API
- [mahdin75/geoserver-mcp](https://github.com/mahdin75/geoserver-mcp) 🏠 – Een Model Context Protocol (MCP) serverimplementatie die LLM’s verbindt met de GeoServer REST API, zodat AI-assistenten met georuimtelijke data en services kunnen werken.
- [ipfred/aiwen-mcp-server-geoip](https://github.com/ipfred/aiwen-mcp-server-geoip) 🐍 📇 ☁️ – MCP-server voor Aiwen IP-locatie, verkrijg gebruikersnetwerk-IP-locatie, IP-details (land, provincie, stad, lat, lon, ISP, eigenaar, enz.)

### 🎯 <a name="marketing"></a>Marketing

Tools voor het creëren en bewerken van marketingcontent, werken met web-metadata, productpositionering en bewerkingsrichtlijnen.

- [gomarble-ai/facebook-ads-mcp-server](https://github.com/gomarble-ai/facebook-ads-mcp-server) 🐍 ☁️ - MCP-server als interface met Facebook Ads, waardoor programmatische toegang tot Facebook Ads-data en beheermogelijkheden wordt geboden.
- [open-strategy-partners/osp_marketing_tools](https://github.com/open-strategy-partners/osp_marketing_tools) 🐍 🏠 - Een suite van marketingtools van Open Strategy Partners, waaronder schrijfstijlen, bewerkingscodes en productmarketing value map-creatie.
- [nictuku/meta-ads-mcp](https://github.com/nictuku/meta-ads-mcp) 🐍 ☁️ 🏠 - Maakt het mogelijk voor AI-agenten om Meta-advertentieprestaties te monitoren en optimaliseren, campagnemetrics te analyseren, doelgroep targeting aan te passen, creatieve assets te beheren en datagedreven aanbevelingen te doen voor advertentiebudget en campagne-instellingen via naadloze Graph API-integratie.
- [marketplaceadpros/amazon-ads-mcp-server](https://github.com/MarketplaceAdPros/amazon-ads-mcp-server) 📇 ☁️  - Maakt tools mogelijk om te werken met Amazon Advertising, inclusief het analyseren van campagnemetrics en -configuraties.

### 📊 <a name="monitoring"></a>Monitoring

Toegang tot en analyse van applicatiemonitoringdata. Maakt het mogelijk voor AI-modellen om foutrapporten en prestatie-indicatoren te beoordelen.

- [netdata/netdata#Netdata](https://github.com/netdata/netdata/blob/master/src/web/mcp/README.md) 🎖️ 🏠 ☁️ 📟 🍎 🪟 🐧 - Ontdekking, verkenning, rapportage en grondoorzaakanalyse met alle observatiegegevens, waaronder metrics, logs, systemen, containers, processen en netwerkverbindingen
- [grafana/mcp-grafana](https://github.com/grafana/mcp-grafana) 🎖️ 🐍 🏠 ☁️ - Doorzoek dashboards, onderzoek incidenten en voer queries uit op datasources in je Grafana-instantie
- [tumf/grafana-loki-mcp](https://github.com/tumf/grafana-loki-mcp) 🐍 🏠 - Een MCP-server die Loki-logs kan opvragen via de Grafana API.
- [hyperb1iss/lucidity-mcp](https://github.com/hyperb1iss/lucidity-mcp) 🐍 🏠 - Verbeter de kwaliteit van AI-gegenereerde code door intelligente, prompt-gebaseerde analyse over 10 kritieke dimensies van complexiteit tot beveiligingslekken
- [last9/last9-mcp-server](https://github.com/last9/last9-mcp-server) - Breng naadloos realtime productiecontext—logs, metrics en traces—naar je lokale omgeving om sneller code te herstellen
- [metoro-io/metoro-mcp-server](https://github.com/metoro-io/metoro-mcp-server) 🎖️ 🏎️ ☁️ - Query en interactie met Kubernetes-omgevingen die door Metoro worden gemonitord
- [MindscapeHQ/server-raygun](https://github.com/MindscapeHQ/mcp-server-raygun) 📇 ☁️ - Raygun API V3-integratie voor crashrapportage en real user monitoring
- [modelcontextprotocol/server-sentry](https://github.com/modelcontextprotocol/servers/tree/main/src/sentry) 🐍 ☁️ - Sentry.io-integratie voor error tracking en performancemonitoring
- [pydantic/logfire-mcp](https://github.com/pydantic/logfire-mcp) 🎖️ 🐍 ☁️ - Biedt toegang tot OpenTelemetry-traces en -metrics via Logfire
- [seekrays/mcp-monitor](https://github.com/seekrays/mcp-monitor) 🏎️ 🏠 - Een systeemmonitoringtool die systeemstatistieken blootlegt via het Model Context Protocol (MCP). Hiermee kunnen LLM’s realtime systeeminformatie opvragen via een MCP-compatibele interface. (ondersteunt CPU, geheugen, schijf, netwerk, host, proces)
- [VictoriaMetrics-Community/mcp-victoriametrics](https://github.com/VictoriaMetrics-Community/mcp-victoriametrics) 🎖️ 🏎️ 🏠 - Biedt uitgebreide integratie met je [VictoriaMetrics instance APIs](https://docs.victoriametrics.com/victoriametrics/url-examples/) en [documentatie](https://docs.victoriametrics.com/) voor monitoring, observatie en debugging van je VictoriaMetrics-instanties

### 🎥 <a name="multimedia-process"></a>Multimedia Verwerking

Biedt de mogelijkheid om multimedia te verwerken, zoals audio- en videobewerking, afspelen, formaatconversie, inclusief videofilters, verbeteringen, enzovoort

- [video-creator/ffmpeg-mcp](https://github.com/video-creator/ffmpeg-mcp.git) 🎥 🔊 - Met ffmpeg commandline een MCP-server bouwen, waarmee je eenvoudig via dialoog lokale video’s kunt zoeken, knippen, samenvoegen, afspelen en meer
- [stass/exif-mcp](https://github.com/stass/exif-mcp) 📇 🏠 🐧 🍎 🪟 - Een MCP-server waarmee je beeldmetadata zoals EXIF, XMP, JFIF en GPS kunt bekijken. Dit vormt de basis voor LLM-aangedreven zoek- en analysefuncties voor fotobibliotheken en beeldcollecties.
- [sunriseapps/imagesorcery-mcp](https://github.com/sunriseapps/imagesorcery-mcp) 🐍 🏠 🐧 🍎 🪟 - ComputerVision-gebaseerde 🪄 tovenarij voor beeldherkenning en bewerkingstools voor AI-assistenten.

### 🔎 <a name="search"></a>Zoeken & Gegevens Extractie

- [Xyber-Labs/mcp-server-youtube](https://github.com/Xyber-Labs/mcp-servers/tree/main/mcp-server-youtube) 🐍 ☁️ - Deze repository implementeert een MCP (Model Context Protocol) server voor YouTube-zoekopdrachten en transcriptie-ophaalfunctionaliteit. Hiermee kunnen taalmodellen of andere agents eenvoudig YouTube-inhoud opvragen via een gestandaardiseerd protocol.
- [ricocf/mcp-wolframalpha](https://github.com/ricocf/mcp-wolframalpha) 🐍 🏠 ☁️ - Een MCP-server waarmee AI-assistenten de Wolfram Alpha API kunnen gebruiken voor realtime toegang tot computationele kennis en data.
- [scrapeless-ai/scrapeless-mcp-server](https://github.com/scrapeless-ai/scrapeless-mcp-server) 🐍 ☁️ - De Scrapeless Model Context Protocol service fungeert als een MCP-serverconnector naar de Google SERP API, waardoor websearch binnen het MCP-ecosysteem mogelijk wordt zonder deze te verlaten.
- [0xdaef0f/job-searchoor](https://github.com/0xDAEF0F/job-searchoor) 📇 🏠 - Een MCP-server voor het zoeken naar vacatures met filters voor datum, trefwoorden, remote opties en meer.
- [ac3xx/mcp-servers-kagi](https://github.com/ac3xx/mcp-servers-kagi) 📇 ☁️ - Kagi zoek-API integratie
- [andybrandt/mcp-simple-arxiv](https://github.com/andybrandt/mcp-simple-arxiv) - 🐍 ☁️  MCP voor LLM om papers van arXiv te zoeken en te lezen
- [hbg/mcp-paperswithcode](https://github.com/hbg/mcp-paperswithcode) - 🐍 ☁️ MCP om te zoeken in de PapersWithCode API
- [andybrandt/mcp-simple-pubmed](https://github.com/andybrandt/mcp-simple-pubmed) - 🐍 ☁️  MCP om medische/life sciences papers te zoeken en lezen van PubMed.
- [angheljf/nyt](https://github.com/angheljf/nyt) 📇 ☁️ - Zoek artikelen met de NYTimes API
- [apify/mcp-server-rag-web-browser](https://github.com/apify/mcp-server-rag-web-browser) 📇 ☁️ - Een MCP-server voor Apify’s open-source RAG Web Browser Actor om websearches uit te voeren, URL’s te scrapen en inhoud in Markdown te retourneren.
- [Bigsy/Clojars-MCP-Server](https://github.com/Bigsy/Clojars-MCP-Server) 📇 ☁️ - Clojars MCP-server voor actuele dependency-informatie van Clojure-bibliotheken
- [blazickjp/arxiv-mcp-server](https://github.com/blazickjp/arxiv-mcp-server) ☁️ 🐍 - Zoek ArXiv onderzoeksartikelen
- [luminati-io/brightdata-mcp](https://github.com/luminati-io/brightdata-mcp) 📇 ☁️ - Ontdek, extraheer en werk met het web – één interface die geautomatiseerde toegang tot het publieke internet mogelijk maakt.
- [chanmeng/google-news-mcp-server](https://github.com/ChanMeng666/server-google-news) 📇 ☁️ - Google News-integratie met automatische themacategorisatie, meertalige ondersteuning en uitgebreide zoekmogelijkheden, inclusief headlines, verhalen en gerelateerde onderwerpen via [SerpAPI](https://serpapi.com/).
- [ConechoAI/openai-websearch-mcp](https://github.com/ConechoAI/openai-websearch-mcp/) 🐍 🏠 ☁️ - Dit is een Python-gebaseerde MCP-server die de OpenAI `web_search` build-in tool biedt.
- [dealx/mcp-server](https://github.com/DealExpress/mcp-server) ☁️ - MCP-server voor het DealX-platform
- [devflowinc/trieve](https://github.com/devflowinc/trieve/tree/main/clients/mcp-server) 🎖️ 📇 ☁️ 🏠 - Crawlen, embedden, chunking, zoeken en ophalen van informatie uit datasets via [Trieve](https://trieve.ai)
- [Dumpling-AI/mcp-server-dumplingai](https://github.com/Dumpling-AI/mcp-server-dumplingai) 🎖️ 📇 ☁️ - Toegang tot data-, webscraping- en documentconversie-API’s van [Dumpling AI](https://www.dumplingai.com/)
- [erithwik/mcp-hn](https://github.com/erithwik/mcp-hn) 🐍 ☁️ - Een MCP-server om te zoeken in Hacker News, topverhalen op te halen en meer.
- [exa-labs/exa-mcp-server](https://github.com/exa-labs/exa-mcp-server) 🎖️ 📇 ☁️ – Een Model Context Protocol (MCP) server die AI-assistenten zoals Claude laat zoeken via de Exa AI Search API voor websearches. Deze setup maakt het mogelijk voor AI-modellen om realtime webinformatie te verkrijgen op een veilige en gecontroleerde manier.
- [fatwang2/search1api-mcp](https://github.com/fatwang2/search1api-mcp) 📇 ☁️ - Zoek via search1api (vereist betaalde API-sleutel)
- [genomoncology/biomcp](https://github.com/genomoncology/biomcp) 🐍 ☁️ - Biomedische onderzoeksserver met toegang tot PubMed, ClinicalTrials.gov en MyVariant.info.
- [hellokaton/unsplash-mcp-server](https://github.com/hellokaton/unsplash-mcp-server)) 🐍 ☁️ - Een MCP-server voor Unsplash-beeldzoekopdrachten.
- [Ihor-Sokoliuk/MCP-SearXNG](https://github.com/ihor-sokoliuk/mcp-searxng) 📇 🏠/☁️ - Een Model Context Protocol-server voor [SearXNG](https://docs.searxng.org)
- [isnow890/naver-search-mcp](https://github.com/isnow890/naver-search-mcp) 📇 ☁️ - MCP-server voor Naver Search API-integratie, met ondersteuning voor blog-, nieuws-, shopping-search en DataLab-analysefuncties.
- [jae-jae/fetcher-mcp](https://github.com/jae-jae/fetcher-mcp) 📇 🏠 - MCP-server voor het ophalen van webpagina-inhoud met behulp van de Playwright headless browser, ondersteuning voor Javascript rendering en intelligente contentextractie, en output in Markdown- of HTML-formaat.
- [jae-jae/g-search-mcp](https://github.com/jae-jae/g-search-mcp) 📇 🏠 - Een krachtige MCP-server voor Google Search waarmee je parallel met meerdere trefwoorden tegelijk kunt zoeken.
- [ananddtyagi/webpage-screenshot-mcp](https://github.com/ananddtyagi/webpage-screenshot-mcp) 📇 🏠 - Een MCP-server voor het maken van screenshots van webpagina’s als feedback tijdens UI-ontwikkeling.
- [leehanchung/bing-search-mcp](https://github.com/leehanchung/bing-search-mcp) 📇 ☁️ - Webzoekmogelijkheden via de Microsoft Bing Search API
- [kagisearch/kagimcp](https://github.com/kagisearch/kagimcp) ☁️ 📇 – Officiële Kagi Search MCP-server
- [kshern/mcp-tavily](https://github.com/kshern/mcp-tavily.git) ☁️ 📇 – Tavily AI zoek-API
- [mikechao/brave-search-mcp](https://github.com/mikechao/brave-search-mcp) 📇 ☁️ - Web-, Afbeeldingen-, Nieuws-, Video- en Lokale Interessante Punt-zoekmogelijkheden met Brave's Search API
- [emicklei/melrose-mcp](https://github.com/emicklei/melrose-mcp) 🏎️ 🏠 - Speelt [Melrōse](https://melrōse.org) muziekexpressies als MIDI
- [modelcontextprotocol/server-brave-search](https://github.com/modelcontextprotocol/servers/tree/main/src/brave-search) 📇 ☁️ - Webzoekmogelijkheden met Brave's Search API
- [modelcontextprotocol/server-fetch](https://github.com/modelcontextprotocol/servers/tree/main/src/fetch) 🐍 🏠 ☁️ - Efficiënt ophalen en verwerken van webinhoud voor AI-consumptie
- [mzxrai/mcp-webresearch](https://github.com/mzxrai/mcp-webresearch) 🔍📚 - Zoek op Google en doe diepgaand webonderzoek over elk onderwerp
- [nickclyde/duckduckgo-mcp-server](https://github.com/nickclyde/duckduckgo-mcp-server) 🐍 ☁️ - Webzoeken met DuckDuckGo
- [r-huijts/opentk-mcp](https://github.com/r-huijts/opentk-mcp) 📇 ☁️ - Toegang tot Nederlandse Parlement (Tweede Kamer) informatie, inclusief documenten, debatten, activiteiten en wetgevende zaken via gestructureerde zoekmogelijkheden (gebaseerd op het opentk-project van Bert Hubert)
- [reading-plus-ai/mcp-server-deep-research](https://github.com/reading-plus-ai/mcp-server-deep-research) 📇 ☁️ - MCP-server die OpenAI/Perplexity-achtige autonome diepgaande research, gestructureerde query-uitwerking en beknopte rapportage biedt.
- [SecretiveShell/MCP-searxng](https://github.com/SecretiveShell/MCP-searxng) 🐍 🏠 - Een MCP-server om verbinding te maken met searXNG-instanties
- [takashiishida/arxiv-latex-mcp](https://github.com/takashiishida/arxiv-latex-mcp) 🐍 ☁️ - Haal de LaTeX-bron van arXiv-papers op om wiskundige inhoud en vergelijkingen te verwerken
- [the0807/GeekNews-MCP-Server](https://github.com/the0807/GeekNews-MCP-Server) 🐍 ☁️ - Een MCP-server die nieuwsgegevens van de GeekNews-site ophaalt en verwerkt.
- [tinyfish-io/agentql-mcp](https://github.com/tinyfish-io/agentql-mcp) 🎖️ 📇 ☁️ - MCP-server die [AgentQL](https://agentql.com) data-extractiemogelijkheden biedt.
- [Tomatio13/mcp-server-tavily](https://github.com/Tomatio13/mcp-server-tavily) ☁️ 🐍 – Tavily AI zoek-API
- [vectorize-io/vectorize-mcp-server](https://github.com/vectorize-io/vectorize-mcp-server/) ☁️ 📇 - [Vectorize](https://vectorize.io) MCP-server voor geavanceerde zoekopdrachten, Private Deep Research, Anything-to-Markdown-bestandsextractie en tekstchunking.
- [webscraping-ai/webscraping-ai-mcp-server](https://github.com/webscraping-ai/webscraping-ai-mcp-server) 🎖️ 📇 ☁️ - Interactie met [WebScraping.ai](https://webscraping.ai) voor webdata-extractie en scraping.
- [zhsama/duckduckgo-mcp-server](https://github.com/zhsama/duckduckgo-mpc-server/) 📇 🏠 ☁️ - Dit is een op TypeScript gebaseerde MCP-server die DuckDuckGo-zoekfunctionaliteit biedt.
- [zoomeye-ai/mcp_zoomeye](https://github.com/zoomeye-ai/mcp_zoomeye) 📇 ☁️ - Netwerkassetinformatie opvragen via ZoomEye MCP Server
- [yamanoku/baseline-mcp-server](https://github.com/yamanoku/baseline-mcp-server) 📇 🏠 - MCP-server die Baseline-status zoekt via de Web Platform API
- [longevity-genie/biothings-mcp](https://github.com/longevity-genie/biothings-mcp) 🐍 ☁️ - MCP-server voor interactie met de BioThings API, inclusief genen, genetische varianten, medicijnen en taxonomische informatie
- [joelio/stocky](https://github.com/joelio/stocky) 🐍 ☁️ 🏠 - Een MCP-server voor het zoeken en downloaden van rechtenvrije stockfotografie van Pexels en Unsplash. Ondersteunt multi-provider zoeken, rijke metadata, paginering en asynchrone prestaties zodat AI-assistenten hoogwaardige afbeeldingen kunnen vinden en openen.

### 🔒 <a name="security"></a>Beveiliging

- [LaurieWired/GhidraMCP](https://github.com/LaurieWired/GhidraMCP) ☕ 🏠 - Een Model Context Protocol-server voor Ghidra waarmee LLM's applicaties autonoom kunnen reverse engineeren. Biedt tools voor het decompileren van binaries, het hernoemen van methoden en data, en het weergeven van methoden, klassen, imports en exports.
- [dkvdm/onepassword-mcp-server](https://github.com/dkvdm/onepassword-mcp-server) - Een MCP-server die veilige credential-opvraging vanuit 1Password mogelijk maakt voor gebruik door Agentic AI.
- [firstorderai/authenticator_mcp](https://github.com/firstorderai/authenticator_mcp) 📇 🏠 🍎 🪟 🐧 – Een veilige MCP (Model Context Protocol)-server waarmee AI-agenten kunnen communiceren met de Authenticator App.
- [13bm/GhidraMCP](https://github.com/13bm/GhidraMCP) 🐍 ☕ 🏠 - MCP-server voor integratie van Ghidra met AI-assistenten. Deze plugin maakt binaire analyse mogelijk en biedt tools voor functie-inspectie, decompilatie, geheugerverkenning en import/export-analyse via het Model Context Protocol.
- [atomicchonk/roadrecon_mcp_server](https://github.com/atomicchonk/roadrecon_mcp_server) 🐍 🪟 🏠 MCP-server voor het analyseren van ROADrecon-gatherresultaten van Azure tenant-enumeratie
- [BurtTheCoder/mcp-dnstwist](https://github.com/BurtTheCoder/mcp-dnstwist) 📇 🪟 ☁️ - MCP-server voor dnstwist, een krachtige DNS-fuzzingtool die helpt bij het detecteren van typosquatting, phishing en bedrijfsspionage.
- [BurtTheCoder/mcp-maigret](https://github.com/BurtTheCoder/mcp-maigret) 📇 🪟 ☁️ - MCP-server voor maigret, een krachtige OSINT-tool die gebruikersaccountinformatie van diverse openbare bronnen verzamelt. Deze server biedt tools voor het zoeken naar gebruikersnamen op sociale netwerken en URL-analyse.
- [BurtTheCoder/mcp-shodan](https://github.com/BurtTheCoder/mcp-shodan) 📇 🪟 ☁️ - MCP-server voor het opvragen van de Shodan API en Shodan CVEDB. Deze server biedt tools voor IP-opzoekingen, apparaatzoeken, DNS-opzoekingen, kwetsbaarheidsqueries, CPE-opzoekingen en meer.
- [BurtTheCoder/mcp-virustotal](https://github.com/BurtTheCoder/mcp-virustotal) 📇 🪟 ☁️ - MCP-server voor het opvragen van de VirusTotal API. Deze server biedt tools voor het scannen van URL's, analyseren van bestands-hashes en ophalen van IP-adresrapporten.
- [fosdickio/binary_ninja_mcp](https://github.com/fosdickio/binary_ninja_mcp) 🐍 🏠 🍎 🪟 🐧 - Een Binary Ninja-plugin, MCP-server en bridge die [Binary Ninja](https://binary.ninja) naadloos integreert met je favoriete MCP-client. Hiermee kun je het proces van binaire analyse en reverse engineering automatiseren.
- [fr0gger/MCP_Security](https://github.com/fr0gger/MCP_Security) 📇 ☁️ - MCP-server voor het opvragen van de ORKL API. Deze server biedt tools voor het ophalen van dreigingsrapporten, analyseren van dreigingsactoren en ophalen van inlichtingenbronnen.
- [gbrigandi/mcp-server-cortex](https://github.com/gbrigandi/mcp-server-cortex) 🦀 🏠 🚨 🍎 🪟 🐧 - Een op Rust gebaseerde MCP-server voor integratie met Cortex, waarmee observeerbare analyse en geautomatiseerde beveiligingsreacties via AI mogelijk zijn.
- [gbrigandi/mcp-server-thehive](https://github.com/gbrigandi/mcp-server-thehive) 🦀 🏠 🚨 🍎 🪟 🐧 - Een op Rust gebaseerde MCP-server voor integratie met TheHive, waarmee samenwerking aan beveiligingsincidenten en casemanagement via AI wordt gefaciliteerd.
- [gbrigandi/mcp-server-wazuh](https://github.com/gbrigandi/mcp-server-wazuh) 🦀 🏠 🚨 🍎 🪟 🐧 - Een op Rust gebaseerde MCP-server die Wazuh SIEM koppelt aan AI-assistenten, met real-time beveiligingsmeldingen en eventdata voor verbeterd contextbegrip.
- [intruder-io/intruder-mcp](https://github.com/intruder-io/intruder-mcp) 🐍 ☁️ - MCP-server voor toegang tot [Intruder](https://www.intruder.io/), waarmee je beveiligingskwetsbaarheden in je infrastructuur kunt identificeren, begrijpen en oplossen.
- [jyjune/mcp_vms](https://github.com/jyjune/mcp_vms) 🐍 🏠 🪟 - Een Model Context Protocol (MCP)-server ontworpen om verbinding te maken met een CCTV-opnameprogramma (VMS) om opgenomen en live videostreams op te halen. Biedt ook tools om de VMS-software te bedienen, zoals live- of afspeeldialogen weergeven voor specifieke kanalen op opgegeven tijden.
- [qianniuspace/mcp-security-audit](https://github.com/qianniuspace/mcp-security-audit) 📇 ☁️ Een krachtige MCP (Model Context Protocol) Server die npm-pakketafhankelijkheden controleert op beveiligingskwetsbaarheden. Gebouwd met integratie van de externe npm registry voor realtime beveiligingscontroles.
- [semgrep/mcp](https://github.com/semgrep/mcp) 📇 ☁️ Laat AI-agenten code scannen op beveiligingslekken met behulp van [Semgrep](https://semgrep.dev).
- [slouchd/cyberchef-api-mcp-server](https://github.com/slouchd/cyberchef-api-mcp-server) 🐍 ☁️ - MCP-server voor interactie met de CyberChef server-API waarmee een MCP-client de CyberChef-bewerkingen kan gebruiken.
- [mrexodia/ida-pro-mcp](https://github.com/mrexodia/ida-pro-mcp) 🐍 🏠 - MCP-server voor IDA Pro, waarmee je binaire analyses kunt uitvoeren met AI-assistenten. Deze plugin implementeert decompilatie, disassemblage en maakt het mogelijk om automatisch malware-analyserapporten te genereren.
- [rad-security/mcp-server](https://github.com/rad-security/mcp-server) 📇 ☁️ - MCP-server voor RAD Security, die AI-gestuurde beveiligingsinzichten biedt voor Kubernetes- en cloudomgevingen. Deze server biedt tools voor het opvragen van de Rad Security API en het ophalen van beveiligingsbevindingen, rapporten, runtime-data en meer.
- [securityfortech/secops-mcp](https://github.com/securityfortech/secops-mcp) 🐍 🏠 - Alles-in-één toolbox voor security testing die populaire open source tools samenbrengt via één MCP-interface. Gecombineerd met een AI-agent maakt dit taken mogelijk als pentesting, bug bounty hunting, threat hunting en meer.
- [roadwy/cve-search_mcp](https://github.com/roadwy/cve-search_mcp) 🐍 🏠 - Een Model Context Protocol (MCP)-server voor het opvragen van de CVE-Search API. Deze server biedt uitgebreide toegang tot CVE-Search, blader door leveranciers en producten, haal CVE per CVE-ID op, haal de laatst bijgewerkte CVE's op.
- [StacklokLabs/osv-mcp](https://github.com/StacklokLabs/osv-mcp) 🏎️ ☁️ - Toegang tot de OSV (Open Source Vulnerabilities) database voor kwetsbaarheidsinformatie. Zoek kwetsbaarheden op pakketversie of commit, batchquery meerdere pakketten en ontvang gedetailleerde kwetsbaarheidsinformatie per ID.
- [nickpending/mcp-recon](https://github.com/nickpending/mcp-recon) 🏎️ 🏠 - Conversational recon-interface en MCP-server aangedreven door httpx en asnmap. Ondersteunt verschillende reconnaissance-niveaus voor domeinanalyse, inspectie van security headers, certificaatanalyse en ASN-opzoekingen.
- [Gaffx/volatility-mcp](https://github.com/Gaffx/volatility-mcp) - MCP-server voor Volatility 3.x, waarmee je geheugenforensische analyse kunt uitvoeren met een AI-assistent. Ervaar geheugenforensiek zonder barrières, terwijl plugins als pslist en netscan toegankelijk worden via schone REST API's en LLM's.
- [co-browser/attestable-mcp-server](https://github.com/co-browser/attestable-mcp-server) 🐍 🏠 ☁️ 🐧 - Een MCP-server die draait binnen een trusted execution environment (TEE) via Gramine, met demonstratie van remote attestation via [RA-TLS](https://gramine.readthedocs.io/en/stable/attestation.html). Dit stelt een MCP-client in staat de server te verifiëren vóór verbinding.
- [zinja-coder/jadx-ai-mcp](https://github.com/zinja-coder/jadx-ai-mcp) ☕ 🏠 - JADX-AI-MCP is een plugin en MCP-server voor de JADX-decompiler die direct integreert met Model Context Protocol (MCP) voor live ondersteuning bij reverse engineering met LLM's zoals Claude.
- [zinja-coder/apktool-mcp-server](https://github.com/zinja-coder/apktool-mcp-server) 🐍 🏠 - APKTool MCP-server is een MCP-server voor de Apk Tool voor automatisering van reverse engineering van Android APK's.

### 🌐 <a name="social-media"></a>Sociale Media

Integratie met sociale mediaplatforms voor het plaatsen, analyseren en beheren van interacties. Maakt AI-gedreven automatisering voor online aanwezigheid mogelijk.

- [macrocosm-os/macrocosmos-mcp](https://github.com/macrocosm-os/macrocosmos-mcp) - 🎖️ 🐍 ☁️ Toegang tot realtime X/Reddit/YouTube-data direct in je LLM-applicaties met zoekzinnen, gebruikers en datumsfiltering.
- [kunallunia/twitter-mcp](https://github.com/LuniaKunal/mcp-twitter) 🐍 🏠 - Alles-in-één Twitter-beheeroplossing met tijdlijn, ophalen van gebruikersberichten, hashtag monitoring, conversatieanalyse, directe berichten, sentimentanalyse van een post en volledige postbeheer via een gestroomlijnde API.
- [HagaiHen/facebook-mcp-server](https://github.com/HagaiHen/facebook-mcp-server) 🐍 ☁️ - Integreert met Facebook Pages voor direct beheer van berichten, reacties en betrokkenheidsstatistieken via de Graph API voor gestroomlijnd social media beheer.
- [gwbischof/bluesky-social-mcp](https://github.com/gwbischof/bluesky-social-mcp) 🐍 🏠 - Een MCP-server voor interactie met Bluesky via de atproto-client.

### 🏃 <a name="sports"></a>Sport

Tools voor toegang tot sportgerelateerde data, resultaten en statistieken.

- [mikechao/balldontlie-mcp](https://github.com/mikechao/balldontlie-mcp) 📇 - MCP-server die de balldontlie-API integreert om informatie over spelers, teams en wedstrijden voor de NBA, NFL en MLB te bieden
- [r-huijts/firstcycling-mcp](https://github.com/r-huijts/firstcycling-mcp) 📇 ☁️ - Toegang tot wielerwedstrijddata, resultaten en statistieken via natuurlijke taal. Functies zijn het ophalen van deelnemerslijsten, wedstrijduitslagen en rennerinformatie van firstcycling.com.
- [r-huijts/strava-mcp](https://github.com/r-huijts/strava-mcp) 📇 ☁️ - Een Model Context Protocol (MCP)-server die verbinding maakt met de Strava API, met tools voor toegang tot Strava-data via LLM's
- [willvelida/mcp-afl-server](https://github.com/willvelida/mcp-afl-server) ☁️ - MCP-server die integreert met de Squiggle API om informatie over Australische Football League-teams, ladderstanden, resultaten, tips en powerrankings te bieden.
- [guillochon/mlb-api-mcp](https://github.com/guillochon/mlb-api-mcp) 🐍 🏠 - MCP-server die fungeert als proxy voor de vrij beschikbare MLB API, die spelersinfo, statistieken en wedstrijdinformatie biedt.

### 🎧 <a name="support-and-service-management"></a>Support & Service Management

Tools voor het beheren van klantenondersteuning, IT-servicemanagement en helpdeskactiviteiten.

- [effytech/freshdesk-mcp](https://github.com/effytech/freshdesk_mcp) 🐍 ☁️ - MCP-server die integreert met Freshdesk, waardoor AI-modellen kunnen communiceren met Freshdesk-modules en diverse supporttaken kunnen uitvoeren.
- [nguyenvanduocit/jira-mcp](https://github.com/nguyenvanduocit/jira-mcp) 🏎️ ☁️ - Een Go-gebaseerde MCP-connector voor Jira waarmee AI-assistenten zoals Claude kunnen communiceren met Atlassian Jira. Deze tool biedt een naadloze interface voor AI-modellen om veelvoorkomende Jira-taken uit te voeren, waaronder issuemanagement, sprintplanning en workflowtransities.
- [sooperset/mcp-atlassian](https://github.com/sooperset/mcp-atlassian) 🐍 ☁️ - MCP-server voor Atlassian-producten (Confluence en Jira). Ondersteunt Confluence Cloud, Jira Cloud en Jira Server/Data Center. Biedt uitgebreide tools voor zoeken, lezen, aanmaken en beheren van inhoud in Atlassian-werkruimtes.

### 🌎 <a name="translation-services"></a>Vertaalservices

Vertaaltools en -diensten waarmee AI-assistenten inhoud tussen verschillende talen kunnen vertalen.

- [translated/lara-mcp](https://github.com/translated/lara-mcp) 🎖️ 📇 ☁️ - MCP-server voor de Lara Translate API, die krachtige vertaalmogelijkheden biedt met ondersteuning voor taalherkenning en contextbewuste vertalingen.
- [mmntm/weblate-mcp](https://github.com/mmntm/weblate-mcp) 📇 ☁️ - Uitgebreide Model Context Protocol-server voor Weblate-vertaalbeheer, waarmee AI-assistenten vertaaltaken, projectmanagement en inhoudsontdekking kunnen uitvoeren met slimme formaattransformaties.

### 🎧 <a name="text-to-speech"></a>Tekst-naar-spraak

Tools voor het omzetten van tekst naar spraak en vice versa

- [mberg/kokoro-tts-mcp](https://github.com/mberg/kokoro-tts-mcp) 🐍 🏠 - MCP-server die de open weight Kokoro TTS-modellen gebruikt om tekst om te zetten in spraak. Kan tekst omzetten naar MP3 op een lokale schijf of automatisch uploaden naar een S3-bucket.
- [mbailey/voice-mcp](https://github.com/mbailey/voice-mcp) 🐍 🏠 - Complete server voor spraakinteractie met ondersteuning voor spraak-naar-tekst, tekst-naar-spraak en realtime spraakgesprekken via lokale microfoon, OpenAI-compatibele API's en LiveKit-integratie

### 🚆 <a name="travel-and-transportation"></a>Reizen & Vervoer

Toegang tot reis- en vervoersinformatie. Maakt het mogelijk om dienstregelingen, routes en realtime reisdata op te vragen.
- [Airbnb MCP Server](https://github.com/openbnb-org/mcp-server-airbnb) 📇 ☁️ - Biedt tools om Airbnb te doorzoeken en details van accommodaties op te halen.
- [KyrieTangSheng/mcp-server-nationalparks](https://github.com/KyrieTangSheng/mcp-server-nationalparks) 📇 ☁️ - Integratie met de National Park Service API die de meest recente informatie biedt over parkdetails, waarschuwingen, bezoekerscentra, campings en evenementen voor Amerikaanse nationale parken.
- [NS Travel Information MCP Server](https://github.com/r-huijts/ns-mcp-server) 📇 ☁️ - Toegang tot Nederlandse Spoorwegen (NS) reisinformatie, dienstregelingen en realtime updates.
- [pab1it0/tripadvisor-mcp](https://github.com/pab1it0/tripadvisor-mcp) 📇 🐍 - Een MCP-server waarmee LLM's kunnen communiceren met de Tripadvisor API, met ondersteuning voor locatiegegevens, beoordelingen en foto's via gestandaardiseerde MCP-interfaces.
- [lucygoodchild/mcp-national-rail](https://github.com/lucygoodchild/mcp-national-rail) 📇 ☁️ - Een MCP-server voor de Britse National Rail treindienst, die dienstregelingen en live reisinformatie biedt, met integratie van de Realtime Trains API.

### 🔄 <a name="version-control"></a>Versiebeheer

Interacteer met Git-repositories en versiebeheerplatformen. Maakt repositorybeheer, code-analyse, pull request-afhandeling, issuetracking en andere versiebeheeroperaties mogelijk via gestandaardiseerde API's.

- [adhikasp/mcp-git-ingest](https://github.com/adhikasp/mcp-git-ingest) 🐍 🏠 - Lees en analyseer GitHub-repositories met je LLM.
- [ddukbg/github-enterprise-mcp](https://github.com/ddukbg/github-enterprise-mcp) 📇 ☁️ 🏠 - MCP-server voor GitHub Enterprise API-integratie.
- [gitea/gitea-mcp](https://gitea.com/gitea/gitea-mcp) 🎖️ 🏎️ ☁️ 🏠 🍎 🪟 🐧 - Interactief werken met Gitea-instanties via MCP.
- [github/github-mcp-server](https://github.com/github/github-mcp-server) 📇 ☁️ - Officiële GitHub-server voor integratie met repositorybeheer, PR's, issues en meer.
- [kopfrechner/gitlab-mr-mcp](https://github.com/kopfrechner/gitlab-mr-mcp) 📇 ☁️ - Naadloos werken met issues en merge requests van je GitLab-projecten.
- [modelcontextprotocol/server-git](https://github.com/modelcontextprotocol/servers/tree/main/src/git) 🐍 🏠 - Directe Git-repositorybewerkingen, waaronder lezen, zoeken en analyseren van lokale repositories.
- [modelcontextprotocol/server-gitlab](https://github.com/modelcontextprotocol/servers/tree/main/src/gitlab) 📇 ☁️ 🏠 - GitLab-platformintegratie voor projectbeheer en CI/CD-operaties.
- [oschina/mcp-gitee](https://github.com/oschina/gitee) 🏎️ ☁️ 🏠 - Gitee API-integratie, beheer van repositories, issues en pull requests, en meer.
- [Tiberriver256/mcp-server-azure-devops](https://github.com/Tiberriver256/mcp-server-azure-devops) 📇 ☁️ - Azure DevOps-integratie voor repositorybeheer, werkitems en pipelines.
- [kaiyuanxiaobing/atomgit-mcp-server](https://github.com/kaiyuanxiaobing/atomgit-mcp-server) 📇 ☁️ - Officiële AtomGit-server voor integratie met repositorybeheer, PR's, issues, branches, labels en meer.

### 🛠️ <a name="other-tools-and-integrations"></a>Andere Tools en Integraties

- [AbdelStark/bitcoin-mcp](https://github.com/AbdelStark/bitcoin-mcp) - ₿ Een Model Context Protocol (MCP)-server waarmee AI-modellen kunnen interageren met Bitcoin, zoals het genereren van sleutels, valideren van adressen, decoderen van transacties, het raadplegen van de blockchain en meer.
- [akseyh/bear-mcp-server](https://github.com/akseyh/bear-mcp-server) - Laat de AI lezen uit je Bear Notes (alleen macOS).
- [allenporter/mcp-server-home-assistant](https://github.com/allenporter/mcp-server-home-assistant) 🐍 🏠 - Stel alle Home Assistant spraakintenties bloot via een Model Context Protocol Server voor huisautomatisering.
- [Amazon Bedrock Nova Canvas](https://github.com/zxkane/mcp-server-amazon-bedrock) 📇 ☁️ - Gebruik het Amazon Nova Canvas-model voor beeldgeneratie.
- [amidabuddha/unichat-mcp-server](https://github.com/amidabuddha/unichat-mcp-server) 🐍/📇 ☁️ - Verstuur verzoeken naar OpenAI, MistralAI, Anthropic, xAI, Google AI of DeepSeek met het MCP-protocol via tool of vooraf ingestelde prompts. Vendor API-sleutel vereist.
- [anaisbetts/mcp-installer](https://github.com/anaisbetts/mcp-installer) 🐍 🏠 -  Een MCP-server die andere MCP-servers voor je installeert.
- [anaisbetts/mcp-youtube](https://github.com/anaisbetts/mcp-youtube) 📇 ☁️ - Haal YouTube-ondertitels op.
- [andybrandt/mcp-simple-openai-assistant](https://github.com/andybrandt/mcp-simple-openai-assistant) - 🐍 ☁️  MCP om met OpenAI-assistenten te praten (Claude kan elk GPT-model als assistent gebruiken).
- [andybrandt/mcp-simple-timeserver](https://github.com/andybrandt/mcp-simple-timeserver) 🐍 🏠☁️ - Een MCP-server om de lokale tijd op de clientmachine of de huidige UTC-tijd via een NTP-server op te vragen.
- [apify/actors-mcp-server](https://github.com/apify/actors-mcp-server) 📇 ☁️ - Gebruik 3.000+ vooraf gebouwde cloudtools, bekend als Actors, om data te extraheren van websites, e-commerce, sociale media, zoekmachines, kaarten en meer.
- [apinetwork/piapi-mcp-server](https://github.com/apinetwork/piapi-mcp-server) 📇 ☁️ PiAPI MCP-server maakt het mogelijk om mediacontent te genereren met Midjourney/Flux/Kling/Hunyuan/Udio/Trellis direct vanuit Claude of andere MCP-compatibele apps.
- [awkoy/replicate-flux-mcp](https://github.com/awkoy/replicate-flux-mcp) 📇 ☁️ - Biedt de mogelijkheid om beelden te genereren via de Replicate API.
- [awwaiid/mcp-server-taskwarrior](https://github.com/awwaiid/mcp-server-taskwarrior) 🏠 📇 - Een MCP-server voor basaal lokaal gebruik van Taskwarrior (toevoegen, bijwerken, verwijderen van taken).
- [baba786/phabricator-mcp-server](https://github.com/baba786/phabricator-mcp-server) 🐍 ☁️ - Interactie met de Phabricator API.
- [Badhansen/notion-mcp](https://github.com/Badhansen/notion-mcp) 🐍 ☁️ - Een Model Context Protocol (MCP)-server die integreert met de Notion API om persoonlijke takenlijsten efficiënt te beheren.
- [bart6114/my-bear-mcp-server](https://github.com/bart6114/my-bear-mcp-server/) 📇 🏠 🍎 - Laat notities en tags lezen voor de Bear Note-app, via een directe integratie met Bear's sqlitedb.
- [billster45/mcp-chatgpt-responses](https://github.com/billster45/mcp-chatgpt-responses) 🐍 ☁️ - MCP-server waarmee Claude met ChatGPT kan praten en diens webzoekfunctie kan gebruiken.
- [blurrah/mcp-graphql](https://github.com/blurrah/mcp-graphql) 📇 ☁️ - Laat de AI GraphQL-servers bevragen.
- [calclavia/mcp-obsidian](https://github.com/calclavia/mcp-obsidian) 📇 🏠 - Deze connector maakt het mogelijk voor Claude Desktop (of andere MCP-clients) om mappen met Markdown-notities (zoals een Obsidian vault) te lezen en te doorzoeken.
- [chrishayuk/mcp-cli](https://github.com/chrishayuk/mcp-cli) 🐍 🏠 - Nog een CLI-tool voor het testen van MCP-servers.
- [danhilse/notion_mcp](https://github.com/danhilse/notion_mcp) 🐍 ☁️ - Integreert met de Notion API om persoonlijke takenlijsten te beheren.
- [EKibort/wrike-mcp-server](https://github.com/EKibort/wrike-mcp-server) - 🐍 🏠 - Een lichte implementatie van een Wrike MCP-server om Wrike-taken te beheren via de publieke API.
- [ekkyarmandi/ticktick-mcp](https://github.com/ekkyarmandi/ticktick-mcp) 🐍 ☁️ - [TickTick](https://ticktick.com/) MCP-server die integreert met de TickTick API om persoonlijke takenprojecten en taken te beheren.
- [esignaturescom/mcp-server-esignatures](https://github.com/esignaturescom/mcp-server-esignatures) 🐍 ☁️️ - Contract- en sjabloonbeheer voor het opstellen, beoordelen en versturen van bindende contracten via de eSignatures API.
- [evalstate/mcp-miro](https://github.com/evalstate/mcp-miro) 📇 ☁️ - Toegang tot MIRO-whiteboards, bulk aanmaken en lezen van items. Vereist OAUTH-sleutel voor REST API.
- [feuerdev/keep-mcp](https://github.com/feuerdev/keep-mcp) 🐍 ☁️ - Lezen, aanmaken, bijwerken en verwijderen van Google Keep-notities.
- [future-audiences/wikimedia-enterprise-model-context-protocol](https://gitlab.wikimedia.org/repos/future-audiences/wikimedia-enterprise-model-context-protocol) 🐍 ☁️  - Wikipedia-artikelen opzoeken via API.
- [fotoetienne/gqai](https://github.com/fotoetienne/gqai) 🏎 🏠 - Definieer tools met reguliere GraphQL-queries/mutaties en gqai genereert automatisch een MCP-server voor je.
- [githejie/mcp-server-calculator](https://github.com/githejie/mcp-server-calculator) 🐍 🏠 - Deze server maakt het mogelijk voor LLM's om een rekenmachine te gebruiken voor nauwkeurige numerieke berekeningen.
- [gotoolkits/DifyWorkflow](https://github.com/gotoolkits/mcp-difyworkflow-server) - 🏎️ ☁️ Tools voor het opvragen en uitvoeren van Dify-workflows.
- [hiromitsusasaki/raindrop-io-mcp-server](https://github.com/hiromitsusasaki/raindrop-io-mcp-server) 📇 ☁️ - Een integratie waarmee LLM's kunnen interageren met Raindrop.io-bladwijzers via het Model Context Protocol (MCP).
- [hmk/attio-mcp-server](https://github.com/hmk/attio-mcp-server) - 📇 ☁️ Laat AI-clients records en notities beheren in Attio CRM.
- [isaacwasserman/mcp-vegalite-server](https://github.com/isaacwasserman/mcp-vegalite-server) 🐍 🏠 - Genereer visualisaties van opgehaalde data met behulp van het VegaLite-formaat en de renderer.
- [ivnvxd/mcp-server-odoo](https://github.com/ivnvxd/mcp-server-odoo) 🐍 ☁️/🏠 - Verbind AI-assistenten met Odoo ERP-systemen voor toegang tot bedrijfsdata, recordbeheer en workflowautomatisering.
- [ivo-toby/contentful-mcp](https://github.com/ivo-toby/contentful-mcp) 📇 🏠 - Bijwerken, aanmaken, verwijderen van content, contentmodellen en assets in je Contentful Space.
- [j3k0/speech.sh](https://github.com/j3k0/speech.sh/blob/main/MCP_README.md) 🏠 - Laat de agent dingen hardop uitspreken, meld wanneer hij klaar is met een korte samenvatting.
- [jagan-shanmugam/climatiq-mcp-server](https://github.com/jagan-shanmugam/climatiq-mcp-server) 🐍 🏠 - Een Model Context Protocol (MCP)-server voor toegang tot de Climatiq API om CO2-uitstoot te berekenen. Hiermee kunnen AI-assistenten realtime CO2-berekeningen uitvoeren en inzichten geven over de klimaatimpact.
- [johannesbrandenburger/typst-mcp](https://github.com/johannesbrandenburger/typst-mcp) 🐍 🏠 - MCP-server voor Typst, een op markup gebaseerde opmaaktaalsysteem. Biedt tools voor conversie tussen LaTeX en Typst, validatie van Typst-syntax en beeldgeneratie van Typst-code.
- [joshuarileydev/mac-apps-launcher-mcp-server](https://github.com/JoshuaRileyDev/mac-apps-launcher) 📇 🏠 - Een MCP-server om applicaties op MacOS te tonen en te starten.
- [Harry-027/JotDown](https://github.com/Harry-027/JotDown) 🦀 🏠 - Een MCP-server om pagina's aan te maken/bij te werken in de Notion-app & automatisch mdBooks te genereren uit gestructureerde inhoud.
- [kelvin6365/plane-mcp-server](https://github.com/kelvin6365/plane-mcp-server) - 🏎️ 🏠 Deze MCP-server helpt je projecten en issues te beheren via de [Plane](https://plane.so) API.
- [kenliao94/mcp-server-rabbitmq](https://github.com/kenliao94/mcp-server-rabbitmq) 🐍 🏠 - Interactie mogelijk maken (admin-operaties, berichten in/uit de wachtrij zetten) met RabbitMQ.
- [k-jarzyna/mcp-miro](https://github.com/k-jarzyna/mcp-miro) 📇 ☁️ - Miro MCP-server, biedt alle functionaliteiten die beschikbaar zijn in de officiële Miro SDK.
- [kimtth/mcp-remote-call-ping-pong](https://github.com/kimtth/mcp-remote-call-ping-pong) 🐍 🏠 - Een experimentele en educatieve app voor een Ping-pong-server die remote MCP (Model Context Protocol) calls demonstreert.
- [kj455/mcp-kibela](https://github.com/kj455/mcp-kibela) - 📇 ☁️ Laat AI-modellen interageren met [Kibela](https://kibe.la/).
- [kiwamizamurai/mcp-kibela-server](https://github.com/kiwamizamurai/mcp-kibela-server) - 📇 ☁️ Krachtige interactie met de Kibela API.
- [KS-GEN-AI/confluence-mcp-server](https://github.com/KS-GEN-AI/confluence-mcp-server) 📇 ☁️ 🍎 🪟 - Haal Confluence-data op via CQL en lees pagina's.
- [KS-GEN-AI/jira-mcp-server](https://github.com/KS-GEN-AI/jira-mcp-server) 📇 ☁️ 🍎 🪟 - Lees Jira-data via JQL en API en voer verzoeken uit om tickets aan te maken en te bewerken.
- [salesforce-mcp/salesforce-mcp](https://github.com/salesforce-mcp/salesforce-mcp) 🏠 ☁️ - MCP-server met een basisdemonstratie van interacties met Salesforce-instanties.
- [pollinations/chucknorris-mcp](https://github.com/pollinations/chucknorris-mcp) 📇 ☁️ - Gespecialiseerde LLM-verbeteringprompts en jailbreaks met dynamische schema-aanpassing.
- [louiscklaw/hko-mcp](https://github.com/louiscklaw/hko-mcp) 📇 🏠 - MCP-server met een basisdemonstratie voor het ophalen van weergegevens van het Hong Kong Observatory.
- [evalstate/mcp-hfspace](https://github.com/evalstate/mcp-hfspace) 📇 ☁️ - Gebruik HuggingFace Spaces direct vanuit Claude. Gebruik open source beeldgeneratie, chat, vision-taken en meer. Ondersteunt uploaden/downloaden van beeld, audio en tekst.
- [magarcia/mcp-server-giphy](https://github.com/magarcia/mcp-server-giphy) 📇 ☁️ - Doorzoek en haal GIF's op uit Giphy's enorme bibliotheek via de Giphy API.
- [integromat/make-mcp-server](https://github.com/integromat/make-mcp-server) 🎖️ 📇 🏠 - Maak van je [Make](https://www.make.com/)-scenario's oproepbare tools voor AI-assistenten.
- [marcelmarais/Spotify](https://github.com/marcelmarais/spotify-mcp-server) - 📇 🏠 Bedien Spotify-afspeellijsten en beheer afspeellijsten.
- [MarkusPfundstein/mcp-obsidian](https://github.com/MarkusPfundstein/mcp-obsidian) 🐍 ☁️ 🏠 - Interactie met Obsidian via de REST API.
- [emicklei/mcp-log-proxy](https://github.com/emicklei/mcp-log-proxy) 🏎️ 🏠 - MCP-serverproxy die een webinterface biedt voor de volledige berichtstroom.
- [quarkiverse/mcp-server-jfx](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/jfx) ☕ 🏠 - Tekenen op een JavaFX-canvas.
- [mediar-ai/screenpipe](https://github.com/mediar-ai/screenpipe) - 🎖️ 🦀 🏠 🍎 Lokale, eerste systeem voor het vastleggen van scherm/audio met getimede indexering, SQL/embedding-opslag, semantisch zoeken, LLM-ondersteunde geschiedenis-analyse en gebeurtenisgestuurde acties - maakt het bouwen van contextbewuste AI-agenten mogelijk via een NextJS-plugin-ecosysteem.
- [modelcontextprotocol/server-everything](https://github.com/modelcontextprotocol/servers/tree/main/src/everything) 📇 🏠 - MCP-server die alle functies van het MCP-protocol demonstreert.
- [mrjoshuak/godoc-mcp](https://github.com/mrjoshuak/godoc-mcp) 🏎️ 🏠 - Token-efficiënte Go-documentatie-server die AI-assistenten slim toegang geeft tot pakketdocumentatie en types zonder hele bronbestanden te lezen.
- [mzxrai/mcp-openai](https://github.com/mzxrai/mcp-openai) 📇 ☁️ - Chatten met OpenAI's slimste modellen.
- [NakaokaRei/swift-mcp-gui](https://github.com/NakaokaRei/swift-mcp-gui.git) 🏠 🍎 - MCP-server die commando's kan uitvoeren zoals toetsenbordinvoer en muisbewegingen.
- [nguyenvanduocit/all-in-one-model-context-protocol](https://github.com/nguyenvanduocit/all-in-one-model-context-protocol) 🏎️ 🏠 - Handige tools voor ontwikkelaars, vrijwel alles wat een engineer nodig heeft: Confluence, Jira, Youtube, script uitvoeren, kennisbank RAG, URL ophalen, beheer YouTube-kanaal, e-mails, agenda, gitlab.
- [NON906/omniparser-autogui-mcp](https://github.com/NON906/omniparser-autogui-mcp) - 🐍 Automatische bediening van GUI op het scherm.
- [orellazi/coda-mcp](https://github.com/orellazri/coda-mcp) 📇 ☁️ - MCP-server voor [Coda](https://coda.io/).
- [pierrebrunelle/mcp-server-openai](https://github.com/pierrebrunelle/mcp-server-openai) 🐍 ☁️ - Vraag OpenAI-modellen direct op vanuit Claude met het MCP-protocol.
- [pskill9/hn-server](https://github.com/pskill9/hn-server) - 📇 ☁️ Parseert de HTML-inhoud van news.ycombinator.com (Hacker News) en levert gestructureerde data voor verschillende soorten verhalen (top, nieuw, ask, show, jobs).
- [PV-Bhat/vibe-check-mcp-server](https://github.com/PV-Bhat/vibe-check-mcp-server) 📇 ☁️ - Een MCP-server die cascadefouten en scope creep voorkomt door een "Vibe-check"-agent aan te roepen om gebruikersafstemming te waarborgen.
- [pwh-pwh/cal-mcp](https://github.com/pwh-pwh/cal-mcp) - Een MCP-server voor het berekenen van wiskundige expressies.
- [pyroprompts/any-chat-completions-mcp](https://github.com/pyroprompts/any-chat-completions-mcp) - Chat met elke andere OpenAI SDK-compatibele Chat Completions API, zoals Perplexity, Groq, xAI en meer.
- [Rai220/think-mcp](https://github.com/Rai220/think-mcp) 🐍 🏠 - Verbetert het redeneervermogen van elke agent door integratie van de think-tools, zoals beschreven in [Anthropic's artikel](https://www.anthropic.com/engineering/claude-think-tool).
- [reeeeemo/ancestry-mcp](https://github.com/reeeeemo/ancestry-mcp) 🐍 🏠 - Laat de AI .ged-bestanden en genetische data lezen.
- [rember/rember-mcp](https://github.com/rember/rember-mcp) 📇 🏠 - Maak spaced repetition-flashcards in [Rember](https://rember.com) om alles wat je leert in je chats te onthouden.
- [roychri/mcp-server-asana](https://github.com/roychri/mcp-server-asana) - 📇 ☁️ Deze Model Context Protocol-serverimplementatie van Asana maakt het mogelijk om de Asana API aan te spreken vanuit een MCP-client zoals Anthropic's Claude Desktop Application, en meer.
- [rusiaaman/wcgw](https://github.com/rusiaaman/wcgw/blob/main/src/wcgw/client/mcp_server/Readme.md) 🐍 🏠 - Autonome shellexecutie, computerbesturing en codeagent. (Mac)
- [SecretiveShell/MCP-wolfram-alpha](https://github.com/SecretiveShell/MCP-wolfram-alpha) 🐍 ☁️ - Een MCP-server om de Wolfram Alpha API te bevragen.
- [Seym0n/tiktok-mcp](https://github.com/Seym0n/tiktok-mcp) 📇 ☁️ - Interactie met TikTok-video's
- [Shopify/dev-mcp](https://github.com/Shopify/dev-mcp) 📇 ☁️ - Model Context Protocol (MCP) server die interacteert met Shopify Dev.
- [sirmews/apple-notes-mcp](https://github.com/sirmews/apple-notes-mcp) 🐍 🏠 - Maakt het mogelijk voor de AI om je lokale Apple Notes-database te lezen (alleen macOS)
- [sooperset/mcp-atlassian](https://github.com/sooperset/mcp-atlassian) 🐍 ☁️ - MCP-server voor Atlassian-producten (Confluence en Jira). Ondersteunt Confluence Cloud, Jira Cloud en Jira Server/Data Center. Biedt uitgebreide tools voor het zoeken, lezen, aanmaken en beheren van content binnen Atlassian-werkruimtes.
- [suekou/mcp-notion-server](https://github.com/suekou/mcp-notion-server) 📇 🏠 - Interactie met de Notion API
- [tacticlaunch/mcp-linear](https://github.com/tacticlaunch/mcp-linear) 📇 ☁️ 🍎 🪟 🐧 - Integreert met het Linear projectmanagementsysteem
- [tanigami/mcp-server-perplexity](https://github.com/tanigami/mcp-server-perplexity) 🐍 ☁️ - Interactie met de Perplexity API.
- [tevonsb/homeassistant-mcp](https://github.com/tevonsb/homeassistant-mcp) 📇 🏠 - Toegang tot Home Assistant-data en besturen van apparaten (lampen, schakelaars, thermostaten, enz).
- [tomekkorbak/oura-mcp-server](https://github.com/tomekkorbak/oura-mcp-server) 🐍 ☁️ - Een MCP-server voor Oura, een app voor het bijhouden van slaap
- [UnitVectorY-Labs/mcp-graphql-forge](https://github.com/UnitVectorY-Labs/mcp-graphql-forge) 🏎️ ☁️ 🍎 🪟 🐧 - Een lichte, configuratiegestuurde MCP-server die geselecteerde GraphQL-queries als modulaire tools aanbiedt, waardoor gerichte API-interacties door jouw agents mogelijk zijn.
- [kw510/strava-mcp](https://github.com/kw510/strava-mcp) 📇 ☁️ - Een MCP-server voor Strava, een app voor het bijhouden van fysieke activiteiten
- [wanaku-ai/wanaku](https://github.com/wanaku-ai/wanaku) - ☁️ 🏠 De Wanaku MCP Router is een SSE-gebaseerde MCP-server die een uitbreidbare routing engine biedt om je bedrijfsapplicaties te integreren met AI-agents.
- [wong2/mcp-cli](https://github.com/wong2/mcp-cli) 📇 🏠 - CLI-tool voor het testen van MCP-servers
- [ws-mcp](https://github.com/nick1udwig/ws-mcp) - Omwikkelt MCP-servers met een WebSocket (voor gebruik met [kitbitz](https://github.com/nick1udwig/kibitz))
- [yuna0x0/hackmd-mcp](https://github.com/yuna0x0/hackmd-mcp) 📇 ☁️ - Maakt het mogelijk voor AI-modellen om te communiceren met [HackMD](https://hackmd.io)
- [ZeparHyfar/mcp-datetime](https://github.com/ZeparHyfar/mcp-datetime) - MCP-server die datum- en tijdfuncties in verschillende formaten levert
- [zueai/mcp-manager](https://github.com/zueai/mcp-manager) 📇 ☁️ - Eenvoudige webinterface om MCP-servers te installeren en beheren voor de Claude Desktop App.
- [HenryHaoson/Yuque-MCP-Server](https://github.com/HenryHaoson/Yuque-MCP-Server) - 📇 ☁️ Een Model-Context-Protocol (MCP) server voor integratie met Yuque API, waarmee AI-modellen documenten kunnen beheren, kennisbanken kunnen raadplegen, content kunnen zoeken en toegang krijgen tot analysegegevens van het Yuque-platform.
- [Mtehabsim/ScreenPilot](https://github.com/Mtehabsim/ScreenPilot) 🐍 🏠 - stelt AI in staat volledige controle en toegang tot GUI-interacties te krijgen door tools te bieden voor muis en toetsenbord, ideaal voor algemene automatisering, educatie en experimentatie.
- [tumf/web3-mcp](https://github.com/tumf/web3-mcp) 🐍 ☁️ - Een MCP-serverimplementatie die de Ankr Advanced API omwikkelt. Toegang tot NFT-, token- en blockchaindata over meerdere ketens, waaronder Ethereum, BSC, Polygon, Avalanche, en meer.
- [danielkennedy1/pdf-tools-mcp](https://github.com/danielkennedy1/pdf-tools-mcp) 🐍 - PDF-download-, weergave- en bewerkingstools.
- [dotemacs/domain-lookup-mcp](https://github.com/dotemacs/domain-lookup-mcp) 🏎️ - Domeinnaam-opzoekservice, eerst via [RDAP](https://en.wikipedia.org/wiki/Registration_Data_Access_Protocol) en als back-up via [WHOIS](https://en.wikipedia.org/wiki/WHOIS)
- [Klavis-AI/YouTube](https://github.com/Klavis-AI/klavis/tree/main/mcp_servers/youtube) 🐍 📇 - Extraheer en converteer YouTube-videogegevens.
- [ttommyth/interactive-mcp](https://github.com/ttommyth/interactive-mcp) 📇 🏠 🍎 🪟 🐧 - Maakt interactieve LLM-workflows mogelijk door lokale gebruikersprompts en chatmogelijkheden rechtstreeks aan de MCP-loop toe te voegen.
- [olalonde/mcp-human](https://github.com/olalonde/mcp-human) 📇 ☁️ - Wanneer je LLM menselijke assistentie nodig heeft (via AWS Mechanical Turk)
- [gwbischof/free-will-mcp](https://github.com/gwbischof/free-will-mcp) 🐍 🏠 - Geef je AI hulpmiddelen voor vrije wil. Een leuk project om te verkennen wat een AI zou doen met de mogelijkheid zichzelf prompts te geven, gebruikersverzoeken te negeren en zichzelf later te wekken.
- [caol64/wenyan-mcp](https://github.com/caol64/wenyan-mcp) 📇 🏠 🍎 🪟 🐧 - Wenyan MCP Server, waarmee AI automatisch Markdown-artikelen kan opmaken en publiceren naar WeChat GZH.

## Frameworks

> [!NOTE]
> Meer frameworks, hulpprogramma's en andere ontwikkelaarstools zijn beschikbaar op https://github.com/punkpeye/awesome-mcp-devtools

- [FastMCP](https://github.com/jlowin/fastmcp) 🐍 - Een hoog-niveau framework voor het bouwen van MCP-servers in Python
- [FastMCP](https://github.com/punkpeye/fastmcp) 📇 - Een hoog-niveau framework voor het bouwen van MCP-servers in TypeScript

## Tips en Tricks

### Officiële prompt om LLMs te informeren hoe MCP te gebruiken

Wil je Claude vragen over Model Context Protocol?

Maak een Project aan en voeg dit bestand toe:

https://modelcontextprotocol.io/llms-full.txt

Nu kan Claude vragen beantwoorden over het schrijven van MCP-servers en hoe ze werken

- https://www.reddit.com/r/ClaudeAI/comments/1h3g01r/want_to_ask_claude_about_model_context_protocol/

## Stergeschiedenis

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
# Awesome MCP-Server [![Awesome](https://awesome.re/badge.svg)](https://awesome.re)

[![ไทย](https://img.shields.io/badge/Thai-Click-blue)](README-th.md)
[![English](https://img.shields.io/badge/English-Click-yellow)](README.md)
[![繁體中文](https://img.shields.io/badge/繁體中文-點擊查看-orange)](README-zh_TW.md)
[![简体中文](https://img.shields.io/badge/简体中文-点击查看-orange)](README-zh.md)
[![日本語](https://img.shields.io/badge/日本語-クリック-青)](README-ja.md)
[![한국어](https://img.shields.io/badge/한국어-클릭-yellow)](README-ko.md)
[![Português Brasileiro](https://img.shields.io/badge/Português_Brasileiro-Clique-green)](README-pt_BR.md)
[![Discord](https://img.shields.io/discord/1312302100125843476?logo=discord&label=discord)](https://glama.ai/mcp/discord)
[![Subreddit subscribers](https://img.shields.io/reddit/subreddit-subscribers/mcp?style=flat&logo=reddit&label=subreddit)](https://www.reddit.com/r/mcp/)

Eine kuratierte Liste großartiger Model Context Protocol (MCP)-Server.

* [Was ist MCP?](#was-ist-mcp)
* [Clients](#clients)
* [Tutorials](#tutorials)
* [Community](#community)
* [Legende](#legende)
* [Server-Implementierungen](#server-implementierungen)
* [Frameworks](#frameworks)
* [Tipps & Tricks](#tipps-und-tricks)

## Was ist MCP?

[MCP](https://modelcontextprotocol.io/) ist ein offenes Protokoll, das es KI-Modellen ermöglicht, sicher mit lokalen und entfernten Ressourcen über standardisierte Server-Implementierungen zu interagieren. Diese Liste konzentriert sich auf produktionsreife und experimentelle MCP-Server, die KI-Fähigkeiten durch Dateizugriff, Datenbankverbindungen, API-Integrationen und andere kontextuelle Dienste erweitern.

## Clients

Siehe [awesome-mcp-clients](https://github.com/punkpeye/awesome-mcp-clients/) und [glama.ai/mcp/clients](https://glama.ai/mcp/clients).

> [!TIPP]
> [Glama Chat](https://glama.ai/chat) ist ein multimodaler KI-Client mit MCP-Unterstützung & [KI-Gateway](https://glama.ai/gateway).

## Tutorials

* [Model Context Protocol (MCP) Schnellstart](https://glama.ai/blog/2024-11-25-model-context-protocol-quickstart)
* [Claude Desktop App einrichten zur Nutzung einer SQLite-Datenbank](https://youtu.be/wxCCzo9dGj0)

## Community

* [r/mcp Reddit](https://www.reddit.com/r/mcp)
* [Discord Server](https://glama.ai/mcp/discord)

## Legende

* 🎖️ – offizielle Implementierung
* Programmiersprache
  * 🐍 – Python-Codebasis
  * 📇 – TypeScript- (oder JavaScript-)Codebasis
  * 🏎️ – Go-Codebasis
  * 🦀 – Rust-Codebasis
  * #️⃣ – C#-Codebasis
  * ☕ – Java-Codebasis
  * 🌊 – C/C++-Codebasis
* Anwendungsbereich
  * ☁️ – Cloud-Service
  * 🏠 – Lokaler Service
  * 📟 – Eingebettete Systeme
* Betriebssystem
  * 🍎 – Für macOS
  * 🪟 – Für Windows
  * 🐧 – Für Linux

> [!HINWEIS]
> Verwirrt über Lokal 🏠 vs. Cloud ☁️?
> * Verwenden Sie "lokal", wenn der MCP-Server mit lokal installierter Software kommuniziert, z. B. um die Kontrolle über den Chrome-Browser zu übernehmen.
> * Verwenden Sie "Netzwerk", wenn der MCP-Server mit entfernten APIs kommuniziert, z. B. Wetter-API.

## Server-Implementierungen

> [!HINWEIS]
> Wir haben jetzt ein [web-basiertes Verzeichnis](https://glama.ai/mcp/servers), das mit dem Repository synchronisiert wird.

* 🔗 - [Aggregatoren](#aggregatoren)
* 🎨 - [Kunst & Kultur](#kunst-und-kultur)
* 📂 - [Browser-Automatisierung](#browser-automatisierung)
* ☁️ - [Cloud-Plattformen](#cloud-plattformen)
* 👨‍💻 - [Codeausführung](#codeausführung)
* 🤖 - [Coding Agents](#coding-agents)
* 🖥️ - [Kommandozeile](#kommandozeile)
* 💬 - [Kommunikation](#kommunikation)
* 👤 - [Kundendatenplattformen](#kundendatenplattformen)
* 🗄️ - [Datenbanken](#datenbanken)
* 📊 - [Datenplattformen](#datenplattformen)
* 🚚 - [Lieferung](#lieferung)
* 🛠️ - [Entwicklertools](#entwicklertools)
* 🧮 - [Data-Science-Tools](#data-science-tools)
* 📟 - [Eingebettetes System](#eingebettetes-system)
* 📂 - [Dateisysteme](#dateisysteme)
* 💰 - [Finanzen & Fintech](#finanzen--fintech)
* 🎮 - [Gaming](#gaming)
* 🧠 - [Wissen & Gedächtnis](#wissen--gedächtnis)
* 🗺️ - [Ortungsdienste](#ortungsdienste)
* 🎯 - [Marketing](#marketing)
* 📊 - [Monitoring](#monitoring)
* 🎥 - [Multimedia-Verarbeitung](#multimedia-verarbeitung)
* 🔎 - [Suche & Datenextraktion](#suche)
* 🔒 - [Sicherheit](#sicherheit)
* 🌐 - [Soziale Medien](#soziale-medien)
* 🏃 - [Sport](#sports)
* 🎧 - [Support & Service Management](#support-and-service-management)
* 🌎 - [Übersetzungsdienste](#translation-services)
* 🎧 - [Text-zu-Sprache](#text-to-speech)
* 🚆 - [Reise & Transport](#travel-and-transportation)
* 🔄 - [Versionskontrolle](#version-control)
* 🛠️ - [Weitere Tools und Integrationen](#other-tools-and-integrations)


### 🔗 <a name="aggregators"></a>Aggregatoren

Server zum Zugriff auf viele Apps und Tools über einen einzigen MCP-Server.

- [julien040/anyquery](https://github.com/julien040/anyquery) 🏎️ 🏠 ☁️ - Mit einer einzigen Binärdatei mehr als 40 Apps per SQL abfragen. Kann sich auch mit Ihrer PostgreSQL-, MySQL- oder SQLite-kompatiblen Datenbank verbinden. Local-first und datenschutzfreundlich konzipiert.
- [metatool-ai/metatool-app](https://github.com/metatool-ai/metatool-app) 📇 ☁️ 🏠 🍎 🪟 🐧 - MetaMCP ist der einheitliche Middleware-MCP-Server, der Ihre MCP-Verbindungen mit GUI verwaltet.
- [mindsdb/mindsdb](https://github.com/mindsdb/mindsdb) - Verbinden und vereinheitlichen Sie Daten über verschiedene Plattformen und Datenbanken mit [MindsDB als einzelnen MCP-Server](https://docs.mindsdb.com/mcp/overview).
- [glenngillen/mcpmcp-server](https://github.com/glenngillen/mcpmcp-server) ☁️ 📇 🍎 🪟 🐧 - Eine Liste von MCP-Servern, damit Ihr Client abfragen kann, welche Server Sie zur Verbesserung Ihres Arbeitsalltags nutzen können.
- [wegotdocs/open-mcp](https://github.com/wegotdocs/open-mcp) 📇 🏠 🍎 🪟 🐧 - Verwandeln Sie eine Web-API in nur 10 Sekunden in einen MCP-Server und fügen Sie sie dem Open-Source-Register hinzu: https://open-mcp.org
- [PipedreamHQ/pipedream](https://github.com/PipedreamHQ/pipedream/tree/master/modelcontextprotocol) ☁️ 🏠 - Verbinden Sie sich mit 2.500 APIs mit 8.000+ vorgefertigten Tools und verwalten Sie Server für Ihre Nutzer in Ihrer eigenen App.
- [VeriTeknik/pluggedin-mcp-proxy](https://github.com/VeriTeknik/pluggedin-mcp-proxy)  📇 🏠 - Ein umfassender Proxy-Server, der mehrere MCP-Server in einer einzigen Oberfläche mit umfangreichen Sichtbarkeitsfunktionen vereint. Bietet Entdeckung und Verwaltung von Tools, Prompts, Ressourcen und Vorlagen über Server hinweg sowie eine Spielwiese zum Debuggen beim Aufbau von MCP-Servern.
- [tigranbs/mcgravity](https://github.com/tigranbs/mcgravity) 📇 🏠 - Ein Proxy-Tool zum Komponieren mehrerer MCP-Server zu einem einheitlichen Endpunkt. Skalieren Sie Ihre KI-Tools durch Lastverteilung über mehrere MCP-Server, ähnlich wie Nginx für Webserver.
- [MetaMCP](https://github.com/metatool-ai/metatool-app) 📇 ☁️ 🏠 🍎 🪟 🐧 - MetaMCP ist der einheitliche Middleware-MCP-Server, der Ihre MCP-Verbindungen mit GUI verwaltet.
- [WayStation-ai/mcp](https://github.com/waystation-ai/mcp) ☁️ 🍎 🪟 - Verbinden Sie Claude Desktop und andere MCP-Hosts nahtlos und sicher mit Ihren Lieblings-Apps (Notion, Slack, Monday, Airtable, usw.). Dauert weniger als 90 Sekunden.
- [sxhxliang/mcp-access-point](https://github.com/sxhxliang/mcp-access-point) 📇 ☁️ 🏠 🍎 🪟 🐧 - Wandeln Sie einen Webservice mit nur einem Klick in einen MCP-Server um, ohne Code-Änderungen.
- [hamflx/imagen3-mcp](https://github.com/hamflx/imagen3-mcp) 📇 🏠 🪟 🍎 🐧 - Ein leistungsstarkes Bildgenerierungstool, das Googles Imagen 3.0 API über MCP verwendet. Generieren Sie hochwertige Bilder aus Texteingaben mit fortschrittlichen Foto-, Kunst- und fotorealistischen Steuerungen.
- [SureScaleAI/openai-gpt-image-mcp](https://github.com/SureScaleAI/openai-gpt-image-mcp) 📇 ☁️ - OpenAI GPT Bildgenerierungs-/Bearbeitungs-MCP-Server.

### 🎨 <a name="art-and-culture"></a>Kunst & Kultur

Zugriff und Erkundung von Kunstsammlungen, Kulturerbe- und Museumsdatenbanken. Ermöglicht KI-Modellen die Suche und Analyse künstlerischer und kultureller Inhalte.

- [abhiemj/manim-mcp-server](https://github.com/abhiemj/manim-mcp-server) 🐍 🏠 🪟 🐧 - Ein lokaler MCP-Server, der Animationen mit Manim generiert.
- [burningion/video-editing-mcp](https://github.com/burningion/video-editing-mcp) 🐍 - Hinzufügen, Analysieren, Suchen und Generieren von Video-Edits aus Ihrer Video Jungle Collection
- [cswkim/discogs-mcp-server](https://github.com/cswkim/discogs-mcp-server) 📇 ☁️ - MCP-Server zur Interaktion mit der Discogs API
- [djalal/quran-mcp-server](https://github.com/djalal/quran-mcp-server) 📇 ☁️ MCP-Server zur Interaktion mit dem Quran.com-Korpus über die offizielle REST API v4.
- [mikechao/metmuseum-mcp](https://github.com/mikechao/metmuseum-mcp) 📇 ☁️ - Metropolitan Museum of Art Collection API-Integration zum Suchen und Anzeigen von Kunstwerken aus der Sammlung.
- [r-huijts/rijksmuseum-mcp](https://github.com/r-huijts/rijksmuseum-mcp) 📇 ☁️ - Rijksmuseum API-Integration für Kunstwerk-Suche, Details und Sammlungen
- [r-huijts/oorlogsbronnen-mcp](https://github.com/r-huijts/oorlogsbronnen-mcp) 📇 ☁️ - Oorlogsbronnen (Kriegquellen) API-Integration für den Zugriff auf historische WWII-Aufzeichnungen, Fotos und Dokumente aus den Niederlanden (1940-1945)
- [samuelgursky/davinci-resolve-mcp](https://github.com/samuelgursky/davinci-resolve-mcp) 🐍 - MCP-Server-Integration für DaVinci Resolve mit leistungsstarken Tools für Videoschnitt, Farbkorrektur, Medienmanagement und Projektsteuerung
- [yuna0x0/anilist-mcp](https://github.com/yuna0x0/anilist-mcp) 📇 ☁️ - Ein MCP-Server mit AniList API-Integration für Anime- und Manga-Informationen
- [diivi/aseprite-mcp](https://github.com/diivi/aseprite-mcp) 🐍 🏠 - MCP-Server mit der Aseprite API zur Erstellung von Pixel-Art
- [omni-mcp/isaac-sim-mcp](https://github.com/omni-mcp/isaac-sim-mcp) 📇 ☁️ - Ein MCP-Server und eine Erweiterung, die natürliche Sprachsteuerung von NVIDIA Isaac Sim, Lab, OpenUSD usw. ermöglichen.
- [8enSmith/mcp-open-library](https://github.com/8enSmith/mcp-open-library) 📇 ☁️ - Ein MCP-Server für die Open Library API, die KI-Assistenten die Suche nach Buchinformationen ermöglicht. 
- [PatrickPalmer/MayaMCP](https://github.com/PatrickPalmer/MayaMCP) 🐍 🏠 - MCP-Server für Autodesk Maya
- [cantian-ai/bazi-mcp](https://github.com/cantian-ai/bazi-mcp) 📇 🏠 ☁️ 🍎 🪟 - Bietet umfassende und genaue Bazi (chinesische Astrologie)-Diagrammerstellung und Analyse


### 📂 <a name="browser-automation"></a>Browser-Automatisierung

Zugriff auf und Automatisierung von Webinhalten. Ermöglicht das Suchen, Scrapen und Verarbeiten von Webinhalten in KI-freundlichen Formaten.

- [xspadex/bilibili-mcp](https://github.com/xspadex/bilibili-mcp.git) 📇 🏠 - Ein FastMCP-basiertes Tool, das die aktuellen Trends von Bilibili abruft und über eine standardisierte MCP-Schnittstelle bereitstellt.
- [34892002/bilibili-mcp-js](https://github.com/34892002/bilibili-mcp-js) 📇 🏠 - Ein MCP-Server, der die Suche nach Bilibili-Inhalten unterstützt. Bietet LangChain-Integrationsbeispiele und Testskripte.
- [aircodelabs/grasp](https://github.com/aircodelabs/grasp) 📇 🏠 - Selbstgehosteter Browser mit Agent und integriertem MCP- sowie A2A-Support.
- [automatalabs/mcp-server-playwright](https://github.com/Automata-Labs-team/MCP-Server-Playwright) 🐍 - Ein MCP-Server für Browserautomatisierung mit Playwright
- [blackwhite084/playwright-plus-python-mcp](https://github.com/blackwhite084/playwright-plus-python-mcp) 🐍 - Ein MCP-Python-Server, der Playwright für die Browserautomatisierung verwendet, besonders geeignet für LLM
- [browserbase/mcp-server-browserbase](https://github.com/browserbase/mcp-server-browserbase) 🎖️ 📇 - Automatisieren Sie Browserinteraktionen in der Cloud (z.B. Webnavigation, Datenerfassung, Formularausfüllung und mehr)
- [browsermcp/mcp](https://github.com/browsermcp/mcp) 📇 🏠 - Automatisieren Sie Ihren lokalen Chrome-Browser
- [co-browser/browser-use-mcp-server](https://github.com/co-browser/browser-use-mcp-server) 🐍 - browser-use als MCP-Server mit SSE-Transport verpackt. Inklusive Dockerfile zum Ausführen von Chromium in Docker + VNC-Server.
- [executeautomation/playwright-mcp-server](https://github.com/executeautomation/mcp-playwright) 📇 - Ein MCP-Server mit Playwright für Browserautomatisierung und Webscraping
- [eyalzh/browser-control-mcp](https://github.com/eyalzh/browser-control-mcp) 📇 🏠 - Ein MCP-Server mit zugehöriger Browsererweiterung, die LLM-Clients die Steuerung des Nutzerbrowsers (Firefox) ermöglicht.
- [fradser/mcp-server-apple-reminders](https://github.com/FradSer/mcp-server-apple-reminders) 📇 🏠 🍎 - Ein MCP-Server zur Interaktion mit Apple Reminders auf macOS
- [getrupt/ashra-mcp](https://github.com/getrupt/ashra-mcp) 🐍 🏠 - Strukturiert Daten aus jeder Website extrahieren. Einfach prompten und JSON erhalten.
- [kimtaeyoon83/mcp-server-youtube-transcript](https://github.com/kimtaeyoon83/mcp-server-youtube-transcript) 📇 ☁️ - YouTube-Untertitel und Transkripte für KI-Analysen abrufen
- [kimtth/mcp-aoai-web-browsing](https://github.com/kimtth/mcp-aoai-web-browsing) 🐍 🏠 - Eine `minimale` Server/Client-MCP-Implementierung mit Azure OpenAI und Playwright.
- [microsoft/playwright-mcp](https://github.com/microsoft/playwright-mcp) - Offizieller Microsoft Playwright MCP-Server, der LLMs die Interaktion mit Webseiten über strukturierte Accessibility-Snapshots ermöglicht
- [modelcontextprotocol/server-puppeteer](https://github.com/modelcontextprotocol/servers/tree/main/src/puppeteer) 📇 🏠 - Browserautomatisierung für Webscraping und Interaktion
- [ndthanhdev/mcp-browser-kit](https://github.com/ndthanhdev/mcp-browser-kit) 📇 🏠 - Ein MCP-Server zur Interaktion mit manifest-v2-kompatiblen Browsern.
- [pskill9/web-search](https://github.com/pskill9/web-search) 📇 🏠 - Ein MCP-Server, der kostenloses Websuchen mit Google-Suchergebnissen ermöglicht, keine API-Schlüssel erforderlich.
- [recursechat/mcp-server-apple-shortcuts](https://github.com/recursechat/mcp-server-apple-shortcuts) 📇 🏠 🍎 - Eine MCP-Server-Integration mit Apple Shortcuts

### ☁️ <a name="cloud-platforms"></a>Cloud-Plattformen

Cloud-Plattform-Serviceintegration. Ermöglicht Verwaltung und Interaktion mit Cloud-Infrastruktur und -Diensten.

- [awslabs/mcp](https://github.com/awslabs/mcp) 🎖️ ☁️ - AWS MCP-Server für nahtlose Integration mit AWS-Diensten und Ressourcen.
- [qiniu/qiniu-mcp-server](https://github.com/qiniu/qiniu-mcp-server) 🐍 ☁️ - Ein MCP auf Basis von Qiniu Cloud-Produkten, unterstützt Zugriff auf Qiniu Cloud Storage, Medienverarbeitungsdienste usw.
- [alexbakers/mcp-ipfs](https://github.com/alexbakers/mcp-ipfs) 📇 ☁️ - Upload und Verwaltung von IPFS-Speicher
- [reza-gholizade/k8s-mcp-server](https://github.com/reza-gholizade/k8s-mcp-server) 🏎️ ☁️/🏠 - Ein Kubernetes Model Context Protocol (MCP)-Server, der Tools für die Interaktion mit Kubernetes-Clustern über eine standardisierte Schnittstelle bereitstellt, einschließlich API-Ressourcenerkennung, Ressourcenverwaltung, Pod-Logs, Metriken und Ereignisse.
- [VmLia/books-mcp-server](https://github.com/VmLia/books-mcp-server) 📇 ☁️ - Dies ist ein MCP-Server zum Abfragen von Büchern und kann in gängigen MCP-Clients wie Cherry Studio verwendet werden.
- [alexei-led/aws-mcp-server](https://github.com/alexei-led/aws-mcp-server) 🐍 ☁️ - Ein leichter, aber leistungsstarker Server, der es KI-Assistenten ermöglicht, AWS CLI-Befehle auszuführen, Unix-Pipes zu verwenden und Prompt-Vorlagen für gängige AWS-Aufgaben in einer sicheren Docker-Umgebung mit Multi-Architektur-Support anzuwenden.
- [alexei-led/k8s-mcp-server](https://github.com/alexei-led/k8s-mcp-server) 🐍 - Ein leichter, aber robuster Server, der KI-Assistenten befähigt, Kubernetes-CLI-Befehle (`kubectl`, `helm`, `istioctl` und `argocd`) sicher per Unix-Pipes in einer sicheren Docker-Umgebung mit Multi-Architektur-Support auszuführen.
- [aliyun/alibaba-cloud-ops-mcp-server](https://github.com/aliyun/alibaba-cloud-ops-mcp-server) 🎖️ 🐍 ☁️ - Ein MCP-Server, der KI-Assistenten die Verwaltung von Ressourcen auf Alibaba Cloud ermöglicht, unterstützt ECS, Cloud Monitor, OOS und weit verbreitete Cloud-Produkte.
- [bright8192/esxi-mcp-server](https://github.com/bright8192/esxi-mcp-server) 🐍 ☁️ - Ein VMware ESXi/vCenter-Verwaltungsserver auf Basis von MCP (Model Control Protocol), der einfache REST-API-Schnittstellen für das Management von virtuellen Maschinen bereitstellt.
- [cloudflare/mcp-server-cloudflare](https://github.com/cloudflare/mcp-server-cloudflare) 🎖️ 📇 ☁️ - Integration mit Cloudflare-Diensten, einschließlich Workers, KV, R2 und D1
- [cyclops-ui/mcp-cyclops](https://github.com/cyclops-ui/mcp-cyclops) 🎖️ 🏎️ ☁️ - Ein MCP-Server, der es KI-Agenten ermöglicht, Kubernetes-Ressourcen über die Cyclops-Abstraktion zu verwalten
- [jedisct1/fastly-mcp-server](https://github.com/jedisct1/fastly-openapi-schema) 🎖️ 📇 ☁️ - Integration mit Fastly-Diensten
- [flux159/mcp-server-kubernetes](https://github.com/Flux159/mcp-server-kubernetes) 📇 ☁️/🏠 - Typescript-Implementierung von Kubernetes-Cluster-Operationen für Pods, Deployments, Services.
- [hardik-id/azure-resource-graph-mcp-server](https://github.com/hardik-id/azure-resource-graph-mcp-server) 📇 ☁️/🏠 - Ein Model Context Protocol Server zum Abfragen und Analysieren von Azure-Ressourcen im großen Maßstab mit Azure Resource Graph, der KI-Assistenten die Erkundung und Überwachung von Azure-Infrastruktur ermöglicht.
- [jdubois/azure-cli-mcp](https://github.com/jdubois/azure-cli-mcp) - Ein Wrapper um die Azure CLI, der direkte Kommunikation mit Azure ermöglicht
- [johnneerdael/netskope-mcp](https://github.com/johnneerdael/netskope-mcp) 🔒 ☁️ - Ein MCP für den Zugriff auf alle Netskope Private Access-Komponenten in einer Netskope Private Access-Umgebung, inklusive detaillierter Setup-Informationen und LLM-Nutzungsbeispielen.
- [manusa/Kubernetes MCP Server](https://github.com/manusa/kubernetes-mcp-server) 🏎️ 🏠 - Ein leistungsfähiger Kubernetes-MCP-Server mit zusätzlicher Unterstützung für OpenShift. Neben CRUD-Operationen für **jede** Kubernetes-Ressource bietet dieser Server spezialisierte Tools zur Interaktion mit Ihrem Cluster.
- [nwiizo/tfmcp](https://github.com/nwiizo/tfmcp) 🦀 🏠 - Ein Terraform-MCP-Server, der KI-Assistenten ermöglicht, Terraform-Umgebungen zu verwalten und zu bedienen, Konfigurationen zu lesen, Pläne zu analysieren, Konfigurationen anzuwenden und Terraform-Status zu verwalten.
- [pulumi/mcp-server](https://github.com/pulumi/mcp-server) 🎖️ 📇 🏠 - MCP-Server zur Interaktion mit Pulumi über die Pulumi Automation API und Pulumi Cloud API. Ermöglicht MCP-Clients, Pulumi-Operationen wie Paketinformationen abrufen, Änderungen vorschauen, Updates bereitstellen und Stack-Ausgaben programmatisch abrufen.
- [rohitg00/kubectl-mcp-server](https://github.com/rohitg00/kubectl-mcp-server) 🐍 ☁️/🏠 - Ein Model Context Protocol (MCP)-Server für Kubernetes, der KI-Assistenten wie Claude, Cursor u.a. ermöglicht, mit Kubernetes-Clustern per natürlicher Sprache zu interagieren.
- [strowk/mcp-k8s-go](https://github.com/strowk/mcp-k8s-go) 🏎️ ☁️/🏠 - Kubernetes-Cluster-Operationen über MCP
- [thunderboltsid/mcp-nutanix](https://github.com/thunderboltsid/mcp-nutanix) 🏎️ 🏠/☁️ - Go-basierter MCP-Server für die Anbindung an Nutanix Prism Central-Ressourcen.
- [trilogy-group/aws-pricing-mcp](https://github.com/trilogy-group/aws-pricing-mcp) 🏎️ ☁️/🏠 - Erhalten Sie aktuelle EC2-Preisinformationen mit einem Aufruf. Schnell. Angetrieben von einem vorverarbeiteten AWS-Preiskatalog.
- [weibaohui/k8m](https://github.com/weibaohui/k8m) 🏎️ ☁️/🏠 - Bietet MCP-Multicluster-Kubernetes-Management und -Operationen mit Verwaltungsoberfläche, Logging und fast 50 integrierten Tools für gängige DevOps- und Entwicklungsszenarien. Unterstützt sowohl Standard- als auch CRD-Ressourcen.
- [weibaohui/kom](https://github.com/weibaohui/kom) 🏎️ ☁️/🏠 - Bietet MCP-Multicluster-Kubernetes-Management und -Operationen. Kann als SDK in Ihr eigenes Projekt integriert werden und enthält fast 50 integrierte Tools für gängige DevOps- und Entwicklungsszenarien. Unterstützt sowohl Standard- als auch CRD-Ressourcen.
- [wenhuwang/mcp-k8s-eye](https://github.com/wenhuwang/mcp-k8s-eye) 🏎️ ☁️/🏠 - MCP-Server zur Verwaltung von Kubernetes sowie zur Analyse Ihres Clusters und der Gesundheit Ihrer Anwendungen.
- [erikhoward/adls-mcp-server](https://github.com/erikhoward/adls-mcp-server) 🐍 ☁️/🏠 - MCP-Server für Azure Data Lake Storage. Kann Container verwalten, Lese-/Schreib-/Upload-/Download-Operationen für Containerdateien ausführen und Dateimetadaten verwalten.
- [silenceper/mcp-k8s](https://github.com/silenceper/mcp-k8s) 🏎️ ☁️/🏠 - MCP-K8S ist ein KI-gesteuertes Kubernetes-Ressourcenverwaltungstool, das es Nutzern ermöglicht, mit natürlicher Sprache beliebige Ressourcen in Kubernetes-Clustern zu bedienen, darunter native Ressourcen (wie Deployment, Service) und benutzerdefinierte Ressourcen (CRD). Kein Merken komplexer Befehle mehr – beschreiben Sie einfach Ihr Anliegen, und die KI führt die entsprechenden Cluster-Operationen präzise aus, wodurch die Benutzerfreundlichkeit von Kubernetes erheblich verbessert wird.
- [redis/mcp-redis-cloud](https://github.com/redis/mcp-redis-cloud) 📇 ☁️ - Verwalten Sie Ihre Redis Cloud-Ressourcen mühelos mit natürlicher Sprache. Erstellen Sie Datenbanken, überwachen Sie Abonnements und konfigurieren Sie Cloud-Bereitstellungen mit einfachen Befehlen.
- [portainer/portainer-mcp](https://github.com/portainer/portainer-mcp) 🏎️ ☁️/🏠 - Ein leistungsfähiger MCP-Server, der es KI-Assistenten ermöglicht, nahtlos mit Portainer-Instanzen zu interagieren. Bietet Zugriff auf Containerverwaltung, Bereitstellungsoperationen und Infrastrukturüberwachung per natürlicher Sprache.

### 👨‍💻 <a name="code-execution"></a>Code-Ausführung

Code-Ausführungsserver. Erlauben LLMs das Ausführen von Code in einer sicheren Umgebung, z. B. für Coding-Agents.

- [pydantic/pydantic-ai/mcp-run-python](https://github.com/pydantic/pydantic-ai/tree/main/mcp-run-python) 🐍 🏠- Führt Python-Code in einer sicheren Sandbox über MCP-Tool-Aufrufe aus
- [yepcode/mcp-server-js](https://github.com/yepcode/mcp-server-js) 🎖️ 📇 ☁️ - Führen Sie beliebigen von LLM generierten Code in einer sicheren und skalierbaren Sandbox-Umgebung aus und erstellen Sie eigene MCP-Tools mit JavaScript oder Python, inkl. voller Unterstützung für NPM und PyPI-Pakete
- [ckanthony/openapi-mcp](https://github.com/ckanthony/openapi-mcp) 🏎️ ☁️ - OpenAPI-MCP: Dockerisierter MCP-Server, der es Ihrem KI-Agenten ermöglicht, auf beliebige APIs mit vorhandener API-Dokumentation zuzugreifen.
- [alfonsograziano/node-code-sandbox-mcp](https://github.com/alfonsograziano/node-code-sandbox-mcp) 📇 🏠 – Ein Node.js-MCP-Server, der isolierte, dockerbasierte Sandboxes zum Ausführen von JavaScript-Snippets mit On-the-Fly-npm-Abhängigkeitsinstallation und sauberem Teardown bereitstellt
- [r33drichards/mcp-js](https://github.com/r33drichards/mcp-js) 🦀 🏠 🐧 🍎 - Eine JavaScript-Codeausführungssandbox, die v8 verwendet, um Code zu isolieren und lokal von KI generierten JavaScript-Code gefahrlos auszuführen. Unterstützt Heap-Snapshotting für persistente Sitzungen.

### 🤖 <a name="coding-agents"></a>Coding-Agents

Vollständige Coding-Agents, die LLMs das Lesen, Bearbeiten und Ausführen von Code sowie das Lösen allgemeiner Programmieraufgaben vollständig autonom ermöglichen.

- [oraios/serena](https://github.com/oraios/serena)🐍🏠 - Ein voll ausgestatteter Coding-Agent, der auf symbolische Codeoperationen durch Nutzung von Language Servern setzt.
- [ezyang/codemcp](https://github.com/ezyang/codemcp) 🐍🏠 - Coding-Agent mit grundlegenden Lese-, Schreib- und Kommandozeilentools.
- [doggybee/mcp-server-leetcode](https://github.com/doggybee/mcp-server-leetcode) 📇 ☁️ - Ein MCP-Server, der KI-Modellen ermöglicht, LeetCode-Probleme zu suchen, abzurufen und zu lösen. Unterstützt Metadaten-Filterung, Benutzerprofile, Einreichungen und Zugriff auf Wettbewerbsdaten.
- [jinzcdev/leetcode-mcp-server](https://github.com/jinzcdev/leetcode-mcp-server) 📇 ☁️ - MCP-Server, der automatisierten Zugriff auf **LeetCode**-Programmierungsprobleme, Lösungen, Einreichungen und öffentliche Daten mit optionaler Authentifizierung für benutzerspezifische Funktionen (z. B. Notizen) ermöglicht; unterstützt sowohl `leetcode.com` (global) als auch `leetcode.cn` (China).
- [juehang/vscode-mcp-server](https://github.com/juehang/vscode-mcp-server) 📇 🏠 - Ein MCP-Server, der KI wie Claude das Lesen der Verzeichnisstruktur in einem VS-Code-Arbeitsbereich ermöglicht, erkannte Probleme von Lintern und Language Servern anzeigt, Code-Dateien liest und Änderungen vornimmt.
- [micl2e2/code-to-tree](https://github.com/micl2e2/code-to-tree) 🌊 🏠 📟 🐧 🪟 🍎 - Ein MCP-Server als Einzel-Binary, der Quellcode unabhängig von der Sprache in einen AST umwandelt.

### 🖥️ <a name="command-line"></a>Kommandozeile

Befehle ausführen, Ausgaben erfassen und anderweitig mit Shells und Kommandozeilenwerkzeugen interagieren.

- [ferrislucas/iterm-mcp](https://github.com/ferrislucas/iterm-mcp) 🖥️ 🛠️ 💬 - Ein Model Context Protocol-Server, der Zugriff auf iTerm bietet. Sie können Befehle ausführen und Fragen zu dem stellen, was Sie im iTerm-Terminal sehen.
- [g0t4/mcp-server-commands](https://github.com/g0t4/mcp-server-commands) 📇 🏠 - Führen Sie beliebige Befehle mit den Tools `run_command` und `run_script` aus.
- [maxim-saplin/mcp_safe_local_python_executor](https://github.com/maxim-saplin/mcp_safe_local_python_executor) - Sicherer Python-Interpreter basierend auf HF Smolagents `LocalPythonExecutor`
- [MladenSU/cli-mcp-server](https://github.com/MladenSU/cli-mcp-server) 🐍 🏠 - Kommandozeilenschnittstelle mit sicherer Ausführung und anpassbaren Sicherheitsrichtlinien
- [OthmaneBlial/term_mcp_deepseek](https://github.com/OthmaneBlial/term_mcp_deepseek) 🐍 🏠 - Ein DeepSeek MCP-ähnlicher Server für das Terminal
- [tumf/mcp-shell-server](https://github.com/tumf/mcp-shell-server) - Ein sicherer Server zur Ausführung von Shell-Befehlen, der das Model Context Protocol (MCP) implementiert
- [automateyournetwork/pyATS_MCP](https://github.com/automateyournetwork/pyATS_MCP) - Cisco pyATS-Server für strukturierte, modellgesteuerte Interaktion mit Netzwerkgeräten.
- [wonderwhy-er/DesktopCommanderMCP](https://github.com/wonderwhy-er/DesktopCommanderMCP) 📇 🏠 🍎 🪟 🐧 - Ein Schweizer Taschenmesser, das Programme verwalten/ausführen sowie Code- und Textdateien lesen/suchen/bearbeiten kann.
- [tufantunc/ssh-mcp](https://github.com/tufantunc/ssh-mcp) 📇 🏠 🐧 🪟 - MCP-Server, der SSH-Kontrolle für Linux- und Windows-Server über das Model Context Protocol bereitstellt. Führen Sie remote Shell-Befehle sicher mit Passwort- oder SSH-Key-Authentifizierung aus.

### 💬 <a name="communication"></a>Kommunikation

Integration mit Kommunikationsplattformen für Nachrichtenverwaltung und Kanaloperationen. Ermöglicht KI-Modellen die Interaktion mit Team-Kommunikationstools.

- [AbdelStark/nostr-mcp](https://github.com/AbdelStark/nostr-mcp) ☁️ - Ein Nostr-MCP-Server, der Interaktion mit Nostr ermöglicht, u. a. zum Posten von Notizen.
- [adhikasp/mcp-twikit](https://github.com/adhikasp/mcp-twikit) 🐍 ☁️ - Interagieren Sie mit Twitter-Suche und Timeline
- [agentmail-toolkit/mcp](https://github.com/agentmail-to/agentmail-toolkit/tree/main/mcp) 🐍 💬 - Ein MCP-Server zum Erstellen von Postfächern „on the fly“, um E-Mails zu senden, zu empfangen und darauf zu reagieren. Wir sind keine KI-Agenten für E-Mail, sondern E-Mail für KI-Agenten.
- [arpitbatra123/mcp-googletasks](https://github.com/arpitbatra123/mcp-googletasks) 📇 ☁️ - Ein MCP-Server zur Anbindung an die Google Tasks API
- [carterlasalle/mac_messages_mcp](https://github.com/carterlasalle/mac_messages_mcp) 🏠 🍎 🚀 - Ein MCP-Server, der sicher über das Model Context Protocol (MCP) auf Ihre iMessage-Datenbank zugreift, sodass LLMs iMessage-Konversationen abfragen und analysieren können. Inklusive robuster Telefonnummernvalidierung, Attachment-Verarbeitung, Kontaktverwaltung, Gruppenchat-Unterstützung sowie Sende- und Empfangsfunktion.
- [chaindead/telegram-mcp](https://github.com/chaindead/telegram-mcp) 🏎️ 🏠 - Telegram API-Integration für Zugriff auf Benutzerdaten, Verwaltung von Dialogen (Chats, Kanäle, Gruppen), Nachrichtenabruf und Lesestatus
- [chigwell/telegram-mcp](https://github.com/chigwell/telegram-mcp) 🐍 🏠 - Telegram API-Integration für Zugriff auf Benutzerdaten, Verwaltung von Dialogen (Chats, Kanäle, Gruppen), Nachrichtenabruf, Nachrichtenversand und Lesestatus.
- [elie222/inbox-zero](https://github.com/elie222/inbox-zero/tree/main/apps/mcp-server) 🐍 ☁️ - Ein MCP-Server für Inbox Zero. Fügt Gmail Funktionen hinzu, wie das Herausfinden, welche E-Mails beantwortet oder nachverfolgt werden müssen.
- [gitmotion/ntfy-me-mcp](https://github.com/gitmotion/ntfy-me-mcp) 📇 ☁️ 🏠 - Ein ntfy-MCP-Server, um ntfy-Benachrichtigungen an Ihren selbst gehosteten ntfy-Server von KI-Agenten aus zu senden/abzurufen 📤 (unterstützt sichere Token-Authentifizierung & mehr – mit npx oder docker!)
- [gotoolkits/wecombot](https://github.com/gotoolkits/mcp-wecombot-server.git) 🚀 ☁️ - Eine MCP-Server-Anwendung, die verschiedene Nachrichtentypen an den WeCom-Gruppenbot sendet.
- [hannesrudolph/imessage-query-fastmcp-mcp-server](https://github.com/hannesrudolph/imessage-query-fastmcp-mcp-server) 🐍 🏠 🍎 - Ein MCP-Server, der sicheren Zugriff auf Ihre iMessage-Datenbank über das Model Context Protocol (MCP) bietet, damit LLMs iMessage-Konversationen mit korrekter Telefonnummernvalidierung und Attachment-Verarbeitung abfragen und analysieren können.
- [i-am-bee/acp-mcp](https://github.com/i-am-bee/acp-mcp) 🐍 💬 - Ein MCP-Server, der als Adapter für das [ACP](https://agentcommunicationprotocol.dev)-Ökosystem fungiert. Macht ACP-Agenten für MCP-Clients nahtlos zugänglich und überbrückt die Kommunikationslücke zwischen den beiden Protokollen.
- [jagan-shanmugam/mattermost-mcp-host](https://github.com/jagan-shanmugam/mattermost-mcp-host) 🐍 🏠 - Ein MCP-Server zusammen mit MCP-Host, der Zugriff auf Mattermost-Teams, -Kanäle und -Nachrichten bietet. Der MCP-Host ist als Bot in Mattermost integriert und hat Zugriff auf konfigurierbare MCP-Server.
- [lharries/whatsapp-mcp](https://github.com/lharries/whatsapp-mcp) 🐍 🏎️ - Ein MCP-Server zum Durchsuchen Ihrer persönlichen WhatsApp-Nachrichten, Kontakte und zum Senden von Nachrichten an Einzelpersonen oder Gruppen
- [line/line-bot-mcp-server](https://github.com/line/line-bot-mcp-server) 🎖 📇 ☁️ - MCP-Server zur Integration des LINE Official Accounts
- [MarkusPfundstein/mcp-gsuite](https://github.com/MarkusPfundstein/mcp-gsuite) 🐍 ☁️ - Integration mit Gmail und Google Kalender.
- [modelcontextprotocol/server-bluesky](https://github.com/keturiosakys/bluesky-context-server) 📇 ☁️ - Bluesky-Instanzintegration für Abfragen und Interaktion
- [modelcontextprotocol/server-slack](https://github.com/modelcontextprotocol/servers/tree/main/src/slack) 📇 ☁️ - Slack-Workspace-Integration für Kanalverwaltung und Messaging
- [korotovsky/slack-mcp-server](https://github.com/korotovsky/slack-mcp-server) 📇 ☁️ - Der leistungsfähigste MCP-Server für Slack Workspaces.
- [sawa-zen/vrchat-mcp](https://github.com/sawa-zen/vrchat-mcp) - 📇 🏠 Dies ist ein MCP-Server zur Interaktion mit der VRChat-API. Sie können Informationen zu Freunden, Welten, Avataren und mehr in VRChat abrufen.
- [takumi0706/google-calendar-mcp](https://github.com/takumi0706/google-calendar-mcp) 📇 ☁️ - Ein MCP-Server zur Anbindung an die Google Calendar API. Basierend auf TypeScript.
- [teddyzxcv/ntfy-mcp](https://github.com/teddyzxcv/ntfy-mcp) - Der MCP-Server, der Sie informiert, indem er Benachrichtigungen per ntfy ans Handy sendet
- [userad/didlogic_mcp](https://github.com/UserAd/didlogic_mcp) 🐍 ☁️ - Ein MCP-Server für [DIDLogic](https://didlogic.com). Ermöglicht das Verwalten von SIP-Endpunkten, Nummern und Zielen.
- [zcaceres/gtasks-mcp](https://github.com/zcaceres/gtasks-mcp) 📇 ☁️ - Ein MCP-Server zur Verwaltung von Google Tasks
- [InditexTech/mcp-teams-server](https://github.com/InditexTech/mcp-teams-server) 🐍 ☁️ - MCP-Server, der Microsoft Teams Messaging integriert (lesen, posten, erwähnen, Mitglieder und Threads auflisten)
- [softeria/ms-365-mcp-server](https://github.com/softeria/ms-365-mcp-server) 📇 ☁️ - MCP-Server, der die gesamte Microsoft-365-Suite über die Graph API verbindet (inklusive Mail, Dateien, Excel, Kalender)
- [YCloud-Developers/ycloud-whatsapp-mcp-server](https://github.com/YCloud-Developers/ycloud-whatsapp-mcp-server) 📇 🏠 - MCP-Server für die WhatsApp Business Platform von YCloud.
- [jaipandya/producthunt-mcp-server](https://github.com/jaipandya/producthunt-mcp-server) 🐍 🏠 - MCP-Server für Product Hunt. Interagieren Sie mit Trend-Posts, Kommentaren, Sammlungen, Nutzern und mehr.

### 👤 <a name="customer-data-platforms"></a>Kundendatenplattformen

Bietet Zugriff auf Kundenprofile innerhalb von Kundendatenplattformen.

- [iaptic/mcp-server-iaptic](https://github.com/iaptic/mcp-server-iaptic) 🎖️ 📇 ☁️ - Verbindung zu [iaptic](https://www.iaptic.com), um Informationen zu Kundeneinkäufen, Transaktionsdaten und App-Umsatzstatistiken abzufragen.
- [OpenDataMCP/OpenDataMCP](https://github.com/OpenDataMCP/OpenDataMCP) 🐍 ☁️ - Verbinden Sie beliebige Open Data mit beliebigen LLMs mittels Model Context Protocol.
- [sergehuber/inoyu-mcp-unomi-server](https://github.com/sergehuber/inoyu-mcp-unomi-server) 📇 ☁️ - Ein MCP-Server zum Zugriff und zur Aktualisierung von Profilen auf einem Apache Unomi CDP-Server.
- [tinybirdco/mcp-tinybird](https://github.com/tinybirdco/mcp-tinybird) 🐍 ☁️ - Ein MCP-Server zur Interaktion mit einem Tinybird-Workspace von jedem MCP-Client aus.
- [@antv/mcp-server-chart](https://github.com/antvis/mcp-server-chart) 🎖️ 📇 ☁️ - Ein Model Context Protocol-Server zur Generierung von Diagrammen mit [AntV](https://github.com/antvis).

### 🗄️ <a name="databases"></a>Datenbanken

Sicherer Datenbankzugriff mit Schema-Inspektionsmöglichkeiten. Ermöglicht Abfragen und Analysen von Daten mit konfigurierbaren Sicherheitskontrollen einschließlich schreibgeschütztem Zugriff.

- [Aiven-Open/mcp-aiven](https://github.com/Aiven-Open/mcp-aiven) - 🐍 ☁️ 🎖️ -  Navigieren Sie Ihre [Aiven-Projekte](https://go.aiven.io/mcp-server) und interagieren Sie mit den Diensten PostgreSQL®, Apache Kafka®, ClickHouse® und OpenSearch®
- [alexanderzuev/supabase-mcp-server](https://github.com/alexander-zuev/supabase-mcp-server) - Supabase MCP-Server mit Unterstützung für SQL-Abfrageausführung und Datenbankexploration
- [aliyun/alibabacloud-tablestore-mcp-server](https://github.com/aliyun/alibabacloud-tablestore-mcp-server) ☕ 🐍 ☁️ - MCP-Service für Tablestore mit Funktionen wie Dokumentenanlage, semantischer Suche nach Dokumenten auf Basis von Vektoren und Skalaren, RAG-freundlich und serverlos.
- [benborla29/mcp-server-mysql](https://github.com/benborla/mcp-server-mysql) ☁️ 🏠 - MySQL-Datenbankintegration in NodeJS mit konfigurierbaren Zugriffskontrollen und Schema-Inspektion
- [bytebase/dbhub](https://github.com/bytebase/dbhub) 📇 🏠 – Universeller Datenbank-MCP-Server mit Unterstützung für gängige Datenbanken.
- [c4pt0r/mcp-server-tidb](https://github.com/c4pt0r/mcp-server-tidb) 🐍 ☁️ - TiDB-Datenbankintegration mit Schema-Inspektion und Abfragefunktionen
- [Canner/wren-engine](https://github.com/Canner/wren-engine) 🐍 🦀 🏠 - Die semantische Engine für Model Context Protocol(MCP)-Clients und KI-Agenten
- [centralmind/gateway](https://github.com/centralmind/gateway) 🏎️ 🏠 🍎 🪟 - MCP- und MCP-SSE-Server, der basierend auf Datenbankschema und -daten automatisch APIs generiert. Unterstützt PostgreSQL, Clickhouse, MySQL, Snowflake, BigQuery, Supabase
- [ChristianHinge/dicom-mcp](https://github.com/ChristianHinge/dicom-mcp) 🐍 ☁️ 🏠 - DICOM-Integration zum Abfragen, Lesen und Übertragen medizinischer Bilder und Berichte von PACS und anderen DICOM-kompatiblen Systemen.
- [chroma-core/chroma-mcp](https://github.com/chroma-core/chroma-mcp) 🎖️ 🐍 ☁️ 🏠 - Chroma MCP-Server für den Zugriff auf lokale und Cloud-Chroma-Instanzen für Retrieval-Fähigkeiten
- [ClickHouse/mcp-clickhouse](https://github.com/ClickHouse/mcp-clickhouse) 🐍 ☁️ - ClickHouse-Datenbankintegration mit Schema-Inspektion und Abfragefunktionen
- [confluentinc/mcp-confluent](https://github.com/confluentinc/mcp-confluent) 🐍 ☁️ – Confluent-Integration zur Interaktion mit Confluent Kafka und Confluent Cloud REST APIs.
- [Couchbase-Ecosystem/mcp-server-couchbase](https://github.com/Couchbase-Ecosystem/mcp-server-couchbase) 🎖️ 🐍 ☁️ 🏠 – Couchbase MCP-Server bietet einheitlichen Zugriff auf sowohl Capella Cloud als auch selbstverwaltete Cluster für Dokumentoperationen, SQL++-Abfragen und natürliche Sprachdatenanalyse.
- [cr7258/elasticsearch-mcp-server](https://github.com/cr7258/elasticsearch-mcp-server) 🐍 🏠 – MCP-Server-Implementierung, die Elasticsearch-Interaktion bereitstellt
- [crystaldba/postgres-mcp](https://github.com/crystaldba/postgres-mcp) 🐍 🏠 – All-in-One-MCP-Server für Postgres-Entwicklung und -Betrieb, mit Tools zur Leistungsanalyse, Optimierung und Zustandsprüfung
- [Dataring-engineering/mcp-server-trino](https://github.com/Dataring-engineering/mcp-server-trino) 🐍 ☁️ – Trino MCP-Server zum Abfragen und Zugreifen auf Daten aus Trino-Clustern.
- [tuannvm/mcp-trino](https://github.com/tuannvm/mcp-trino) 🏎️ ☁️ – Eine Go-Implementierung eines Model Context Protocol (MCP)-Servers für Trino
- [designcomputer/mysql_mcp_server](https://github.com/designcomputer/mysql_mcp_server) 🐍 🏠 – MySQL-Datenbankintegration mit konfigurierbaren Zugriffskontrollen, Schema-Inspektion und umfassenden Sicherheitsrichtlinien
- [wenb1n-dev/mysql_mcp_server_pro](https://github.com/wenb1n-dev/mysql_mcp_server_pro) 🐍 🏠 – Unterstützt SSE, STDIO; nicht nur auf MySQLs CRUD-Funktionalität beschränkt; beinhaltet auch Datenbank-Ausnahmeanalysen; steuert Datenbankberechtigungen basierend auf Rollen und erleichtert Entwicklern die Erweiterung der Tools durch Anpassungen
- [domdomegg/airtable-mcp-server](https://github.com/domdomegg/airtable-mcp-server) 📇 🏠 – Airtable-Datenbankintegration mit Schema-Inspektion, Lese- und Schreibfunktionen
- [edwinbernadus/nocodb-mcp-server](https://github.com/edwinbernadus/nocodb-mcp-server) 📇 ☁️ – Nocodb-Datenbankintegration, Lese- und Schreibfunktionen
- [ergut/mcp-bigquery-server](https://github.com/ergut/mcp-bigquery-server) 📇 ☁️ – Server-Implementierung für Google BigQuery-Integration, die direkten BigQuery-Datenbankzugriff und Abfragefunktionen ermöglicht
- [f4ww4z/mcp-mysql-server](https://github.com/f4ww4z/mcp-mysql-server) 📇 🏠 – Node.js-basierte MySQL-Datenbankintegration, die sichere MySQL-Datenbankoperationen bereitstellt
- [fireproof-storage/mcp-database-server](https://github.com/fireproof-storage/mcp-database-server) 📇 ☁️ – Fireproof Ledger-Datenbank mit Multi-User-Synchronisation
- [FreePeak/db-mcp-server](https://github.com/FreePeak/db-mcp-server) 🏎️ 🏠 – Ein leistungsstarker Multi-Datenbank-MCP-Server, gebaut mit Golang, unterstützt MySQL & PostgreSQL (NoSQL folgt bald). Enthält integrierte Tools für Abfrageausführung, Transaktionsmanagement, Schemaexploration, Abfrageerstellung und Leistungsanalyse sowie nahtlose Cursor-Integration für verbesserte Datenbank-Workflows.
- [furey/mongodb-lens](https://github.com/furey/mongodb-lens) 📇 🏠 – MongoDB Lens: Voll ausgestatteter MCP-Server für MongoDB-Datenbanken
- [gannonh/firebase-mcp](https://github.com/gannonh/firebase-mcp) 🔥 ⛅️ – Firebase-Dienste inklusive Auth, Firestore und Storage.
- [get-convex/convex-backend](https://stack.convex.dev/convex-mcp-server) 📇 ☁️ – Convex-Datenbankintegration zur Inspektion von Tabellen, Funktionen und Ausführung von einmaligen Abfragen ([Quelle](https://github.com/get-convex/convex-backend/blob/main/npm-packages/convex/src/cli/mcp.ts))
- [googleapis/genai-toolbox](https://github.com/googleapis/genai-toolbox) 🏎️ ☁️ – Open-Source-MCP-Server, spezialisiert auf einfache, schnelle und sichere Tools für Datenbanken.
- [GreptimeTeam/greptimedb-mcp-server](https://github.com/GreptimeTeam/greptimedb-mcp-server) 🐍 🏠 – MCP-Server zum Abfragen von GreptimeDB.
- [hannesrudolph/sqlite-explorer-fastmcp-mcp-server](https://github.com/hannesrudolph/sqlite-explorer-fastmcp-mcp-server) 🐍 🏠 – Ein MCP-Server, der sicheren, schreibgeschützten Zugriff auf SQLite-Datenbanken über das Model Context Protocol (MCP) bereitstellt. Dieser Server ist mit dem FastMCP-Framework gebaut, das LLMs das Erkunden und Abfragen von SQLite-Datenbanken mit eingebauten Sicherheitsfunktionen und Abfragevalidierung ermöglicht.
- [idoru/influxdb-mcp-server](https://github.com/idoru/influxdb-mcp-server) 📇 ☁️ 🏠 – Führen Sie Abfragen gegen die InfluxDB OSS API v2 aus.
- [isaacwasserman/mcp-snowflake-server](https://github.com/isaacwasserman/mcp-snowflake-server) 🐍 ☁️ – Snowflake-Integration mit Lese- und (optional) Schreiboperationen sowie Einsicht-Tracking
- [joshuarileydev/supabase-mcp-server](https://github.com/joshuarileydev/supabase) – Supabase MCP-Server zum Verwalten und Erstellen von Projekten und Organisationen in Supabase
- [jovezhong/mcp-timeplus](https://github.com/jovezhong/mcp-timeplus) 🐍 ☁️ – MCP-Server für Apache Kafka und Timeplus. Kann Kafka-Themen auflisten, Kafka-Nachrichten abfragen, Kafka-Daten lokal speichern und Streamingdaten via SQL über Timeplus abfragen
- [KashiwaByte/vikingdb-mcp-server](https://github.com/KashiwaByte/vikingdb-mcp-server) 🐍 ☁️ – VikingDB-Integration mit Sammlung- und Index-Vorstellung, Vektorspeicher und Suchfunktionen.
- [kiliczsh/mcp-mongo-server](https://github.com/kiliczsh/mcp-mongo-server) 📇 🏠 – Ein Model Context Protocol Server für MongoDB
- [ktanaka101/mcp-server-duckdb](https://github.com/ktanaka101/mcp-server-duckdb) 🐍 🏠 – DuckDB-Datenbankintegration mit Schema-Inspektion und Abfragefunktionen
- [LucasHild/mcp-server-bigquery](https://github.com/LucasHild/mcp-server-bigquery) 🐍 ☁️ – BigQuery-Datenbankintegration mit Schema-Inspektion und Abfragefunktionen
- [quarkiverse/mcp-server-jdbc](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/jdbc) ☕ 🏠 – Verbinden Sie sich mit jeder JDBC-kompatiblen Datenbank und führen Sie Abfragen, Einfügungen, Aktualisierungen, Löschungen und mehr durch.
- [jparkerweb/mcp-sqlite](https://github.com/jparkerweb/mcp-sqlite) 📇 🏠 – Model Context Protocol (MCP)-Server, der umfassende SQLite-Datenbankinteraktionen ermöglicht.
- [memgraph/mcp-memgraph](https://github.com/memgraph/mcp-memgraph) 🐍 🏠 – Memgraph MCP-Server – beinhaltet ein Tool zur Abfrageausführung gegen Memgraph und eine Schema-Ressource.
- [modelcontextprotocol/server-postgres](https://github.com/modelcontextprotocol/servers/tree/main/src/postgres) 📇 🏠 – PostgreSQL-Datenbankintegration mit Schema-Inspektion und Abfragefunktionen
- [modelcontextprotocol/server-sqlite](https://github.com/modelcontextprotocol/servers/tree/main/src/sqlite) 🐍 🏠 – SQLite-Datenbankoperationen mit integrierten Analysefunktionen
- [neo4j-contrib/mcp-neo4j](https://github.com/neo4j-contrib/mcp-neo4j) 🐍 🏠 – Model Context Protocol mit Neo4j (Abfragen ausführen, Knowledge Graph Memory, Neo4j Aura Instanzen verwalten)
- [neondatabase/mcp-server-neon](https://github.com/neondatabase/mcp-server-neon) 📇 ☁️ — Ein MCP-Server zum Erstellen und Verwalten von Postgres-Datenbanken mit Neon Serverless Postgres
- [niledatabase/nile-mcp-server](https://github.com/niledatabase/nile-mcp-server) MCP-Server für Niles Postgres-Plattform – Verwalten und Abfragen von Postgres-Datenbanken, Mandanten, Benutzern, Authentifizierung mit LLMs
- [openlink/mcp-server-odbc](https://github.com/OpenLinkSoftware/mcp-odbc-server) 🐍 🏠 – Ein MCP-Server für generische Datenbankmanagementsystem-(DBMS)-Konnektivität über das Open Database Connectivity (ODBC)-Protokoll
- [openlink/mcp-server-sqlalchemy](https://github.com/OpenLinkSoftware/mcp-sqlalchemy-server) 🐍 🏠 – Ein MCP-Server für generische Datenbankmanagementsystem-(DBMS)-Konnektivität über SQLAlchemy mit Python ODBC (pyodbc)
- [pab1it0/adx-mcp-server](https://github.com/pab1it0/adx-mcp-server) 🐍 ☁️ – Abfragen und Analysieren von Azure Data Explorer-Datenbanken
- [pab1it0/prometheus-mcp-server](https://github.com/pab1it0/prometheus-mcp-server) 🐍 ☁️ – Abfragen und Analysieren von Prometheus, Open-Source-Monitoringsystem.
- [prisma/prisma](https://github.com/prisma/prisma) 🐍 🏠 – Gibt LLMs die Fähigkeit, Prisma-Postgres-Datenbanken zu verwalten (z. B. neue Datenbankinstanzen zu starten oder Schema-Migrationen durchzuführen).
- [qdrant/mcp-server-qdrant](https://github.com/qdrant/mcp-server-qdrant) 🐍 🏠 – Ein Qdrant MCP-Server
- [QuantGeekDev/mongo-mcp](https://github.com/QuantGeekDev/mongo-mcp) 📇 🏠 – MongoDB-Integration, die es LLMs ermöglicht, direkt mit Datenbanken zu interagieren.
- [rashidazarang/airtable-mcp](https://github.com/rashidazarang/airtable-mcp) 🐍 ☁️ – Verbinde KI-Tools direkt mit Airtable. Abfragen, Erstellen, Aktualisieren und Löschen von Datensätzen in natürlicher Sprache. Funktionen beinhalten Basemanagement, Tabellenoperationen, Schemamanipulation, Datensatzfilterung und Datenmigration über eine standardisierte MCP-Schnittstelle.
- [redis/mcp-redis](https://github.com/redis/mcp-redis) 🐍 🏠 – Der offizielle Redis MCP-Server bietet eine Schnittstelle zum Verwalten und Durchsuchen von Daten in Redis.
- [runekaagaard/mcp-alchemy](https://github.com/runekaagaard/mcp-alchemy) 🐍 🏠 – Universelle, auf SQLAlchemy basierende Datenbankintegration mit Unterstützung für PostgreSQL, MySQL, MariaDB, SQLite, Oracle, MS SQL Server und viele weitere Datenbanken. Bietet Schema- und Beziehungsinspektion sowie Analysefunktionen für große Datensätze.
- [sirmews/mcp-pinecone](https://github.com/sirmews/mcp-pinecone) 🐍 ☁️ – Pinecone-Integration mit Vektorsuchfunktionen
- [skysqlinc/skysql-mcp](https://github.com/skysqlinc/skysql-mcp) 🎖️ ☁️ – Serverloser MariaDB Cloud DB MCP-Server. Tools zum Starten, Löschen, Ausführen von SQL und zur Arbeit mit DB-AI-Agenten für präzises Text-2-SQL und Konversationen.
- [supabase-community/supabase-mcp](https://github.com/supabase-community/supabase-mcp) 🎖️ 📇 ☁️ – Offizieller Supabase MCP-Server, um KI-Assistenten direkt mit deinem Supabase-Projekt zu verbinden und Aufgaben wie Tabellenverwaltung, Konfigurationen abrufen und Datenabfragen zu ermöglichen.
- [TheRaLabs/legion-mcp](https://github.com/TheRaLabs/legion-mcp) 🐍 🏠 Universeller Datenbank-MCP-Server mit Unterstützung für mehrere Datenbanktypen, darunter PostgreSQL, Redshift, CockroachDB, MySQL, RDS MySQL, Microsoft SQL Server, BigQuery, Oracle DB und SQLite.
- [tradercjz/dolphindb-mcp-server](https://github.com/tradercjz/dolphindb-mcp-server) 🐍 ☁️ – DolphinDB-Datenbankintegration mit Schema-Inspektion und Abfragefunktionen
- [weaviate/mcp-server-weaviate](https://github.com/weaviate/mcp-server-weaviate) 🐍 📇 ☁️ – Ein MCP-Server, um sich mit deinen Weaviate-Sammlungen als Wissensbasis zu verbinden sowie Weaviate als Chat Memory Store zu nutzen.
- [XGenerationLab/xiyan_mcp_server](https://github.com/XGenerationLab/xiyan_mcp_server) 📇 ☁️ — Ein MCP-Server, der das Abrufen von Daten aus einer Datenbank mittels natürlicher Sprachabfragen unterstützt, angetrieben von XiyanSQL als Text-zu-SQL-LLM.
- [xing5/mcp-google-sheets](https://github.com/xing5/mcp-google-sheets) 🐍 ☁️ – Ein Model Context Protocol-Server zur Interaktion mit Google Sheets. Dieser Server bietet Tools zum Erstellen, Lesen, Aktualisieren und Verwalten von Tabellen über die Google Sheets API.
- [freema/mcp-gsheets](https://github.com/freema/mcp-gsheets) 📇 ☁️ – MCP-Server für Google Sheets API-Integration mit umfassenden Lese-, Schreib-, Formatierungs- und Sheet-Management-Funktionen.
- [Zhwt/go-mcp-mysql](https://github.com/Zhwt/go-mcp-mysql) 🏎️ 🏠 – Einfach zu nutzender, abhängigkeitsfreier MySQL-MCP-Server, gebaut mit Golang, mit konfigurierbarem Nur-Lese-Modus und Schema-Inspektion.
- [ydb/ydb-mcp](https://github.com/ydb-platform/ydb-mcp) 🎖️ 🐍 ☁️ – MCP-Server zur Interaktion mit [YDB](https://ydb.tech)-Datenbanken
- [zilliztech/mcp-server-milvus](https://github.com/zilliztech/mcp-server-milvus) 🐍 🏠 ☁️ – MCP-Server für Milvus / Zilliz, ermöglicht die Interaktion mit deiner Datenbank.
- [openlink/mcp-server-jdbc](https://github.com/OpenLinkSoftware/mcp-jdbc-server) 🐍 🏠 – Ein MCP-Server für generische Datenbankmanagementsystem-(DBMS)-Konnektivität über das Java Database Connectivity (JDBC)-Protokoll
- [yincongcyincong/VictoriaMetrics-mcp-server](https://github.com/yincongcyincong/VictoriaMetrics-mcp-server) 🐍 🏠 – Ein MCP-Server zur Interaktion mit der VictoriaMetrics-Datenbank.
- [hydrolix/mcp-hydrolix](https://github.com/hydrolix/mcp-hydrolix) 🎖️ 🐍 ☁️ – Hydrolix-Zeitreihen-Datalake-Integration mit Schema-Exploration und Abfragefunktionen für LLM-basierte Workflows.
- [davewind/mysql-mcp-server](https://github.com/dave-wind/mysql-mcp-server) 🏎️ 🏠 – Benutzerfreundlicher Nur-Lese-MySQL-MCP-Server für Cursor und n8n...


### 📊 <a name="data-platforms"></a>Datenplattformen

Datenplattformen für Datenintegration, -transformation und Pipeline-Orchestrierung.

- [flowcore/mcp-flowcore-platform](https://github.com/flowcore-io/mcp-flowcore-platform) 🎖️ 📇 ☁️ 🏠 – Interagiere mit Flowcore, um Aktionen auszuführen, Daten zu ingestieren sowie jegliche Daten in deinen Data Cores oder in öffentlichen Data Cores zu analysieren, zu referenzieren und zu nutzen – alles in Menschensprache.
- [JordiNei/mcp-databricks-server](https://github.com/JordiNeil/mcp-databricks-server) 🐍 ☁️ – Verbindung zur Databricks API, ermöglicht LLMs das Ausführen von SQL-Abfragen, Auflisten von Jobs und Abrufen von Jobstatus.
- [yashshingvi/databricks-genie-MCP](https://github.com/yashshingvi/databricks-genie-MCP) 🐍 ☁️ – Ein Server, der sich mit der Databricks Genie API verbindet und es LLMs erlaubt, Fragen in natürlicher Sprache zu stellen, SQL-Abfragen auszuführen und mit Databricks-Konversationsagenten zu interagieren.
- [jwaxman19/qlik-mcp](https://github.com/jwaxman19/qlik-mcp) 📇 ☁️ – MCP-Server für die Qlik Cloud API, ermöglicht das Abfragen von Anwendungen, Blättern und das Extrahieren von Daten aus Visualisierungen mit umfassender Authentifizierung und Ratenbegrenzung.
- [keboola/keboola-mcp-server](https://github.com/keboola/keboola-mcp-server) 🐍 – Interagiere mit der Keboola Connection Data Platform. Dieser Server bietet Tools zur Auflistung und zum Zugriff auf Daten aus der Keboola Storage API.
- [dbt-labs/dbt-mcp](https://github.com/dbt-labs/dbt-mcp) 🎖️ 🐍 🏠 ☁️ – Offizieller MCP-Server für [dbt (data build tool)](https://www.getdbt.com/product/what-is-dbt), bietet Integration mit dbt Core/Cloud CLI, Projektmetadaten-Discovery, Modellinformationen und semantische Schichtabfragen.
- [mattijsdp/dbt-docs-mcp](https://github.com/mattijsdp/dbt-docs-mcp) 🐍 🏠 – MCP-Server für dbt-core (OSS)-Nutzer, da der offizielle dbt MCP nur dbt Cloud unterstützt. Unterstützt Projektmetadaten, Modell- und Spalten-Linienführung sowie dbt-Dokumentation.

### 💻 <a name="developer-tools"></a>Entwicklertools

Tools und Integrationen, die den Entwicklungsworkflow und das Umgebungsmanagement verbessern.

- [Pratyay/mac-monitor-mcp](https://github.com/Pratyay/mac-monitor-mcp) 🐍 🏠 🍎 – Identifiziert ressourcenintensive Prozesse unter macOS und gibt Vorschläge zur Leistungsverbesserung.
- [21st-dev/Magic-MCP](https://github.com/21st-dev/magic-mcp) – Erstelle maßgeschneiderte UI-Komponenten, inspiriert von den besten 21st.dev Design-Ingenieuren.
- [Hypersequent/qasphere-mcp](https://github.com/Hypersequent/qasphere-mcp) 🎖️ 📇 ☁️ – Integration mit dem [QA Sphere](https://qasphere.com/) Testmanagementsystem, ermöglicht LLMs das Entdecken, Zusammenfassen und Interagieren mit Testfällen direkt aus KI-gestützten IDEs
- [admica/FileScopeMCP](https://github.com/admica/FileScopeMCP) 🐍 📇 🦀 – Analysiert deinen Codebestand, identifiziert wichtige Dateien basierend auf Abhängigkeitsbeziehungen. Erstellt Diagramme und Wichtigkeitsscores, um KI-Assistenten das Verständnis des Codes zu erleichtern.
- [ambar/simctl-mcp](https://github.com/ambar/simctl-mcp) 📇 🏠 🍎 Ein MCP-Server zur Steuerung des iOS-Simulators.
- [api7/apisix-mcp](https://github.com/api7/apisix-mcp) 🎖️ 📇 🏠 MCP-Server mit Unterstützung für Abfragen und Verwaltung aller Ressourcen in [Apache APISIX](https://github.com/apache/apisix).
- [ArchAI-Labs/fastmcp-sonarqube-metrics](https://github.com/ArchAI-Labs/fastmcp-sonarqube-metrics) 🐍 🏠 🪟 🐧 🍎 – Ein Model Context Protocol (MCP)-Server, der Werkzeuge zum Abrufen von Informationen über SonarQube-Projekte wie Metriken (aktuelle und historische), Probleme und Gesundheitsstatus bereitstellt.
- [automation-ai-labs/mcp-link](https://github.com/automation-ai-labs/mcp-link) 🏎️ 🏠 – Integriere nahtlos jede API mit KI-Agenten (mit OpenAPI-Schema)
- [azer/react-analyzer-mcp](https://github.com/azer/react-analyzer-mcp) 📇 🏠 – Analysiere React-Code lokal, generiere Dokumente / llm.txt für das gesamte Projekt auf einmal
- [davidlin2k/pox-mcp-server](https://github.com/davidlin2k/pox-mcp-server) 🐍 🏠 – MCP-Server für den POX SDN-Controller, bietet Netzwerksteuerungs- und Managementfunktionen.
- [CodeLogicIncEngineering/codelogic-mcp-server](https://github.com/CodeLogicIncEngineering/codelogic-mcp-server) 🎖️ 🐍 ☁️ 🍎 🪟 🐧 – Offizieller MCP-Server für CodeLogic, bietet Zugriff auf Code-Abhängigkeitsanalyse, Analyse architektonischer Risiken und Impact Assessment Tools.
- [Comet-ML/Opik-MCP](https://github.com/comet-ml/opik-mcp) 🎖️ 📇 ☁️ 🏠 – Nutze natürliche Sprache, um LLM-Observability, Traces und Monitoringdaten zu durchsuchen, die von Opik erfasst wurden.
- [CircleCI/mcp-server-circleci](https://github.com/CircleCI-Public/mcp-server-circleci) 📇 ☁️ – Ermögliche KI-Agenten, Build-Fehler von CircleCI zu beheben.
- [currents-dev/currents-mcp](https://github.com/currents-dev/currents-mcp) 🎖️ 📇 ☁️ – Ermögliche KI-Agenten, Playwright-Testfehler zu beheben, die an [Currents](https://currents.dev) gemeldet wurden.
- [delano/postman-mcp-server](https://github.com/delano/postman-mcp-server) 📇 ☁️ – Interagiere mit der [Postman API](https://www.postman.com/postman/postman-public-workspace/)
- [flipt-io/mcp-server-flipt](https://github.com/flipt-io/mcp-server-flipt) 📇 🏠 – Ermögliche KI-Assistenten, mit deinen Feature Flags in [Flipt](https://flipt.io) zu interagieren.
- [GLips/Figma-Context-MCP](https://github.com/GLips/Figma-Context-MCP) 📇 🏠 – Ermöglicht Coding-Agenten direkten Zugriff auf Figma-Daten, um ihnen die One-Shot-Designimplementierung zu erleichtern.
- [gofireflyio/firefly-mcp](https://github.com/gofireflyio/firefly-mcp) 🎖️ 📇 ☁️ – Integriert, entdeckt, verwaltet und kodifiziert Cloud-Ressourcen mit [Firefly](https://firefly.ai).
- [Govcraft/rust-docs-mcp-server](https://github.com/Govcraft/rust-docs-mcp-server) 🦀 🏠 – Stellt LLMs aktuelle Dokumentationskontexte für ein bestimmtes Rust-Crate über ein MCP-Tool bereit, mittels semantischer Suche (Embeddings) und LLM-Zusammenfassung.
- [haris-musa/excel-mcp-server](https://github.com/haris-musa/excel-mcp-server) 🐍 🏠 – Ein Excel-Manipulationsserver, der Arbeitsmappenerstellung, Datenoperationen, Formatierung und erweiterte Funktionen (Diagramme, Pivot-Tabellen, Formeln) bereitstellt.
- [higress-group/higress-ops-mcp-server](https://github.com/higress-group/higress-ops-mcp-server) 🐍 🏠 – MCP-Server, der umfassende Werkzeuge zur Verwaltung von [Higress](https://github.com/alibaba/higress) Gateway-Konfigurationen und -Betrieb bereitstellt.
- [hijaz/postmancer](https://github.com/hijaz/postmancer) 📇 🏠 – Ein MCP-Server als Ersatz für REST-Clients wie Postman/Insomnia, indem Ihr LLM API-Sammlungen verwalten und verwenden kann.
- [hloiseaufcms/mcp-gopls](https://github.com/hloiseaufcms/mcp-gopls) 🏎️ 🏠 – Ein MCP-Server zur Interaktion mit dem [Go Language Server Protocol (gopls)](https://github.com/golang/tools/tree/master/gopls) und zur Nutzung fortschrittlicher Go-Code-Analysefunktionen.
- [hungthai1401/bruno-mcp](https://github.com/hungthai1401/bruno-mcp) 📇 🏠 – Ein MCP-Server zur Interaktion mit dem [Bruno API Client](https://www.usebruno.com/).
- [hyperb1iss/droidmind](https://github.com/hyperb1iss/droidmind) 🐍 🏠 – Steuern Sie Android-Geräte mit KI über MCP. Ermöglicht Gerätesteuerung, Debugging, Systemanalyse und UI-Automatisierung mit umfassendem Sicherheitsframework.
- [XixianLiang/HarmonyOS-mcp-server](https://github.com/XixianLiang/HarmonyOS-mcp-server) 🐍 🏠 – Steuern Sie HarmonyOS-next-Geräte mit KI über MCP. Unterstützt Gerätesteuerung und UI-Automatisierung.
- [IlyaGulya/gradle-mcp-server](https://github.com/IlyaGulya/gradle-mcp-server) 🏠 – Gradle-Integration mit der Gradle Tooling API zum Inspizieren von Projekten, Ausführen von Aufgaben und Testen mit Berichterstattung pro Test.
- [InhiblabCore/mcp-image-compression](https://github.com/InhiblabCore/mcp-image-compression) 🐍 🏠 – MCP-Server für lokale Komprimierung verschiedener Bildformate.
- [isaacphi/mcp-language-server](https://github.com/isaacphi/mcp-language-server) 🏎️ 🏠 – MCP Language Server unterstützt MCP-fähige Clients beim Navigieren durch Codebasen mit semantischen Tools wie Definition finden, Referenzen, Umbenennen und Diagnose.
- [ios-simulator-mcp](https://github.com/joshuayoes/ios-simulator-mcp) 📇 🏠 🍎 – Ein Model Context Protocol (MCP) Server zur Interaktion mit iOS-Simulatoren. Dieser Server ermöglicht es, Informationen zu Simulatoren abzurufen, UI-Interaktionen zu steuern und UI-Elemente zu inspizieren.
- [InditexTech/mcp-server-simulator-ios-idb](https://github.com/InditexTech/mcp-server-simulator-ios-idb) 📇 🏠 🍎 – Ein Model Context Protocol (MCP) Server, der LLMs die Interaktion mit iOS-Simulatoren (iPhone, iPad usw.) über natürliche Sprachbefehle ermöglicht.
- [IvanAmador/vercel-ai-docs-mcp](https://github.com/IvanAmador/vercel-ai-docs-mcp) 📇 🏠 – Ein Model Context Protocol (MCP) Server, der KI-gestützte Suche und Abfragefunktionen für die Vercel AI SDK Dokumentation bereitstellt.
- [j4c0bs/mcp-server-sql-analyzer](https://github.com/j4c0bs/mcp-server-sql-analyzer) 🐍 – MCP-Server, der SQL-Analyse, Linting und Dialektumwandlung mit [SQLGlot](https://github.com/tobymao/sqlglot) bereitstellt.
- [jasonjmcghee/claude-debugs-for-you](https://github.com/jasonjmcghee/claude-debugs-for-you) 📇 🏠 – Ein MCP-Server und eine VS Code-Erweiterung, die (sprachunabhängiges) automatisches Debugging über Breakpoints und Ausdrückebewertung ermöglicht.
- [jetbrains/mcpProxy](https://github.com/JetBrains/mcpProxy) 🎖️ 📇 🏠 – Verbindung zu JetBrains IDE.
- [qainsights/jmeter-mcp-server](https://github.com/QAInsights/jmeter-mcp-server) 🐍 🏠 – JMeter MCP-Server für Performance-Tests.
- [Jktfe/serveMyAPI](https://github.com/Jktfe/serveMyAPI) 📇 🏠 🍎 – Ein persönlicher MCP (Model Context Protocol) Server zum sicheren Speichern und Abrufen von API-Schlüsseln über Projekte hinweg mithilfe des macOS-Schlüsselbunds.
- [joshuarileydev/app-store-connect-mcp-server](https://github.com/JoshuaRileyDev/app-store-connect-mcp-server) 📇 🏠 – Ein MCP-Server zur Kommunikation mit der App Store Connect API für iOS-Entwickler.
- [joshuarileydev/simulator-mcp-server](https://github.com/JoshuaRileyDev/simulator-mcp-server) 📇 🏠 – Ein MCP-Server zur Steuerung von iOS-Simulatoren.
- [qainsights/k6-mcp-server](https://github.com/QAInsights/k6-mcp-server) 🐍 🏠 – Grafana k6 MCP-Server für Performance-Tests.
- [lamemind/mcp-server-multiverse](https://github.com/lamemind/mcp-server-multiverse) 📇 🏠 🛠️ – Ein Middleware-Server, der es ermöglicht, mehrere isolierte Instanzen derselben MCP-Server unabhängig mit einzigartigen Namespaces und Konfigurationen auszuführen.
- [langfuse/mcp-server-langfuse](https://github.com/langfuse/mcp-server-langfuse) 🐍 🏠 – MCP-Server für Zugriff und Verwaltung von LLM-Anwendungsprompts, die mit [Langfuse]([https://langfuse.com/](https://langfuse.com/docs/prompts/get-started)) Prompt Management erstellt wurden.
- [mobile-next/mobile-mcp](https://github.com/mobile-next/mobile-mcp) 📇 🏠 🐧 🍎 – MCP-Server für Android/iOS-Anwendungs- und Geräteautomatisierung, Entwicklung und App-Scraping. Simulatoren/Emulatoren/physische Geräte wie iPhone, Google Pixel, Samsung werden unterstützt.
- [qainsights/locust-mcp-server](https://github.com/QAInsights/locust-mcp-server) 🐍 🏠 – Locust MCP-Server für Performance-Tests.
- [mrexodia/user-feedback-mcp](https://github.com/mrexodia/user-feedback-mcp) 🐍 🏠 – Einfacher MCP-Server, um einen Human-in-the-Loop-Workflow in Tools wie Cline und Cursor zu ermöglichen.
- [narumiruna/gitingest-mcp](https://github.com/narumiruna/gitingest-mcp) 🐍 🏠 – Ein MCP-Server, der [gitingest](https://github.com/cyclotruc/gitingest) verwendet, um jedes Git-Repository in eine einfache Textzusammenfassung seines Codes umzuwandeln.
- [OctoMind-dev/octomind-mcp](https://github.com/OctoMind-dev/octomind-mcp) 📇 ☁️ – Ermöglicht es Ihrem bevorzugten KI-Agenten, vollständig verwaltete [Octomind](https://www.octomind.dev/) End-to-End-Tests aus Ihrem Codebestand oder anderen Datenquellen wie Jira, Slack oder TestRail zu erstellen und auszuführen.
- [kadykov/mcp-openapi-schema-explorer](https://github.com/kadykov/mcp-openapi-schema-explorer) 📇 ☁️ 🏠 – Token-effizienter Zugriff auf OpenAPI/Swagger-Spezifikationen über MCP-Ressourcen.
- [pskill9/website-downloader](https://github.com/pskill9/website-downloader) 🗄️ 🚀 – Dieser MCP-Server bietet ein Tool zum Herunterladen ganzer Websites mit wget. Die Website-Struktur bleibt erhalten und Links werden lokal umgewandelt.
- [utensils/mcp-nixos](https://github.com/utensils/mcp-nixos) 🐍 🏠 – MCP-Server, der genaue Informationen zu NixOS-Paketen, Systemoptionen, Home Manager-Konfigurationen und nix-darwin macOS-Einstellungen bereitstellt, um KI-Halluzinationen zu vermeiden.
- [QuantGeekDev/docker-mcp](https://github.com/QuantGeekDev/docker-mcp) 🏎️ 🏠 – Docker-Containerverwaltung und -Betrieb über MCP.
- [ckreiling/mcp-server-docker](https://github.com/ckreiling/mcp-server-docker) 🐍 🏠 – Integration mit Docker zur Verwaltung von Containern, Images, Volumes und Netzwerken.
- [r-huijts/xcode-mcp-server](https://github.com/r-huijts/xcode-mcp-server) 📇 🏠 🍎 – Xcode-Integration für Projektmanagement, Dateioperationen und Build-Automatisierung.
- [ReAPI-com/mcp-openapi](https://github.com/ReAPI-com/mcp-openapi) 📇 🏠 – MCP-Server, der LLMs alles über Ihre OpenAPI-Spezifikationen wissen lässt, um zu entdecken, zu erklären und Code/Mock-Daten zu generieren.
- [Rootly-AI-Labs/Rootly-MCP-server](https://github.com/Rootly-AI-Labs/Rootly-MCP-server) 🎖️ 🐍 ☁️ 🍎 – MCP-Server für die Incident-Management-Plattform [Rootly](https://rootly.com/).
- [sammcj/mcp-package-version](https://github.com/sammcj/mcp-package-version) 📇 🏠 – Ein MCP-Server, der LLMs hilft, beim Schreiben von Code die neuesten stabilen Paketversionen vorzuschlagen.
- [sapientpants/sonarqube-mcp-server](https://github.com/sapientpants/sonarqube-mcp-server) 🦀 ☁️ 🏠 – Ein Model Context Protocol (MCP) Server, der mit SonarQube integriert ist, um KI-Assistenten Zugriff auf Codequalitätsmetriken, Probleme und Quality-Gate-Status zu geben.
- [SDGLBL/mcp-claude-code](https://github.com/SDGLBL/mcp-claude-code) 🐍 🏠 – Eine Implementierung der Claude Code-Fähigkeiten mit MCP, die KI-Codeverständnis, -Modifikation und -Projektanalyse mit umfassender Toolunterstützung ermöglicht.
- [snaggle-ai/openapi-mcp-server](https://github.com/snaggle-ai/openapi-mcp-server) 🏎️ 🏠 – Verbinden Sie jeden HTTP/REST API-Server mit einer Open API-Spezifikation (v3).
- [stass/lldb-mcp](https://github.com/stass/lldb-mcp) 🐍 🏠 🐧 🍎 – Ein MCP-Server für LLDB, der KI-gestützte Binär- und Corefile-Analyse, Debugging und Disassemblierung ermöglicht.
- [TencentEdgeOne/edgeone-pages-mcp](https://github.com/TencentEdgeOne/edgeone-pages-mcp) 📇 ☁️ – Ein MCP-Service zum Bereitstellen von HTML-Inhalten auf EdgeOne Pages und zum Erhalten einer öffentlich zugänglichen URL.
- [tumf/mcp-text-editor](https://github.com/tumf/mcp-text-editor) 🐍 🏠 – Ein zeilenorientierter Textdatei-Editor. Für LLM-Tools optimiert, mit effizientem Teilzugriff auf Dateien zur Minimierung des Tokenverbrauchs.
- [vivekvells/mcp-pandoc](https://github.com/vivekVells/mcp-pandoc) 🗄️ 🚀 – MCP-Server für nahtlose Dokumentformat-Konvertierung mit Pandoc, unterstützt Markdown, HTML, PDF, DOCX (.docx), csv und mehr.
- [VSCode Devtools](https://github.com/biegehydra/BifrostMCP) 📇 – Verbindung zur VSCode-IDE und Nutzung semantischer Tools wie `find_usages`.
- [xcodebuild](https://github.com/ShenghaiWang/xcodebuild) 🍎 Baut iOS Xcode Workspace/Projekt und gibt Fehler an LLM zurück.
- [xzq.xu/jvm-mcp-server](https://github.com/xzq-xu/jvm-mcp-server) 📇 🏠 – Ein Implementierungsprojekt eines JVM-basierten MCP (Model Context Protocol) Servers.
- [yangkyeongmo@/mcp-server-apache-airflow](https://github.com/yangkyeongmo/mcp-server-apache-airflow) 🐍 🏠 – MCP-Server, der sich mit [Apache Airflow](https://airflow.apache.org/) über den offiziellen Client verbindet.
- [YuChenSSR/mindmap-mcp-server](https://github.com/YuChenSSR/mindmap-mcp-server) 🐍 🏠 – Ein Model Context Protocol (MCP) Server zur Erstellung einer schönen interaktiven Mindmap.
- [YuChenSSR/multi-ai-advisor](https://github.com/YuChenSSR/multi-ai-advisor-mcp) 📇 🏠 – Ein Model Context Protocol (MCP) Server, der mehrere Ollama-Modelle abfragt und deren Antworten kombiniert, um vielfältige KI-Perspektiven zu einer Frage zu bieten.
- [yWorks/mcp-typescribe](https://github.com/yWorks/mcp-typescribe) 📇 🏠 – MCP-Server, der Typescript-API-Informationen effizient bereitstellt, damit der Agent mit nicht trainierten APIs arbeiten kann.
- [zcaceres/fetch-mcp](https://github.com/zcaceres/fetch-mcp) 📇 🏠 – Ein MCP-Server zum flexiblen Abrufen von JSON-, Text- und HTML-Daten.
- [zenml-io/mcp-zenml](https://github.com/zenml-io/mcp-zenml) 🐍 🏠 ☁️ – Ein MCP-Server zur Verbindung mit Ihren [ZenML](https://www.zenml.io) MLOps- und LLMOps-Pipelines.
- [idosal/git-mcp](https://github.com/idosal/git-mcp) 📇 ☁️ – [gitmcp.io](https://gitmcp.io/) ist ein generischer Remote-MCP-Server zur Verbindung mit JEDEM [GitHub](https://www.github.com) Repository oder Projekt für Dokumentation.
- [tgeselle/bugsnag-mcp](https://github.com/tgeselle/bugsnag-mcp) 📇 ☁️ – Ein MCP-Server für die Interaktion mit [Bugsnag](https://www.bugsnag.com/).
- [jordandalton/restcsv-mcp-server](https://github.com/JordanDalton/RestCsvMcpServer) 📇 ☁️ – Ein MCP-Server für CSV-Dateien.
- [cjo4m06/mcp-shrimp-task-manager](https://github.com/cjo4m06/mcp-shrimp-task-manager) 📇 ☁️ 🏠 – Ein programmierfokussiertes Task-Management-System, das Coding-Agents wie Cursor AI mit fortschrittlichem Task-Memory, Selbstreflexion und Abhängigkeitsmanagement unterstützt. [ShrimpTaskManager](https://cjo4m06.github.io/mcp-shrimp-task-manager)
- [axliupore/mcp-code-runner](https://github.com/axliupore/mcp-code-runner) 📇 🏠 – Ein MCP-Server zum lokalen Ausführen von Code über Docker mit Unterstützung für mehrere Programmiersprachen.
- [yikakia/godoc-mcp-server](https://github.com/yikakia/godoc-mcp-server) 🏎️ ☁️ 🪟 🐧 🍎 – Abfrage von Go-Paketinformationen auf pkg.go.dev.
- [ckanthony/gin-mcp](https://github.com/ckanthony/gin-mcp) 🏎️ ☁️ 📟 🪟 🐧 🍎 – Eine Zero-Konfiguration Go-Bibliothek, um bestehende Gin-Webframework-APIs automatisch als MCP-Tools bereitzustellen.
- [ryan0204/github-repo-mcp](https://github.com/Ryan0204/github-repo-mcp) 📇 ☁️ 🪟 🐧 🍎 – GitHub Repo MCP ermöglicht Ihren KI-Assistenten das Durchsuchen von GitHub-Repositories, das Erkunden von Verzeichnissen und das Anzeigen von Dateiinhalten.
- [alimo7amed93/webhook-tester-mcp](https://github.com/alimo7amed93/webhook-tester-mcp) 🐍 ☁️ – Ein FastMCP-basierter Server zur Interaktion mit webhook-test.com. Ermöglicht Benutzern, Webhooks lokal mit Claude zu erstellen, abzurufen und zu löschen.
- [lpigeon/ros-mcp-server](https://github.com/lpigeon/ros-mcp-server) 🐍 🏠 🍎 🪟 🐧 – Der ROS MCP-Server unterstützt die Robotersteuerung, indem er benutzerdefinierte Sprachbefehle in ROS- oder ROS2-Steuerbefehle umwandelt.
- [jsdelivr/globalping-mcp-server](https://github.com/jsdelivr/globalping-mcp-server) 🎖️ 📇 ☁️ – Der Globalping MCP-Server bietet Benutzern und LLMs Zugang zu Netzwerktools wie Ping, Traceroute, mtr, HTTP und DNS-Auflösung von Tausenden Standorten weltweit.
- [posthog/mcp](https://github.com/posthog/mcp) 🎖️ 📇 ☁️ – Ein MCP-Server zur Interaktion mit PostHog Analytics, Feature Flags, Fehlerverfolgung und mehr.
- [artmann/package-registry-mcp](https://github.com/artmann/package-registry-mcp) 🏠 📇 🍎 🪟 🐧 – MCP-Server zur Suche und zum Abrufen aktueller Informationen zu NPM-, Cargo-, PyPi- und NuGet-Paketen.

### 🔒 <a name="delivery"></a>Lieferung

- [https://github.com/jordandalton/doordash-mcp-server](https://github.com/JordanDalton/DoorDash-MCP-Server) 🐍 – DoorDash-Lieferung (inoffiziell)

### 🧮 <a name="data-science-tools"></a>Datenwissenschaft-Tools

Integrationen und Tools, die darauf ausgelegt sind, Datenexploration und -analyse zu vereinfachen und Data-Science-Workflows zu verbessern.

- [ChronulusAI/chronulus-mcp](https://github.com/ChronulusAI/chronulus-mcp) 🐍 ☁️ – Beliebige Vorhersagen mit Chronulus KI-Forecasting- und Prognose-Agenten.
- [reading-plus-ai/mcp-server-data-exploration](https://github.com/reading-plus-ai/mcp-server-data-exploration) 🐍 ☁️ – Ermöglicht autonome Datenexploration auf .csv-basierten Datensätzen und liefert intelligente Einblicke mit minimalem Aufwand.
- [zcaceres/markdownify-mcp](https://github.com/zcaceres/markdownify-mcp) 📇 🏠 – Ein MCP-Server, um fast jede Datei oder Web-Inhalt in Markdown zu konvertieren.
- [datalayer/jupyter-mcp-server](https://github.com/datalayer/jupyter-mcp-server) 🐍 🏠 – Model Context Protocol (MCP) Server für Jupyter.
- [jjsantos01/jupyter-notebook-mcp](https://github.com/jjsantos01/jupyter-notebook-mcp) 🐍 🏠 – Verbindet Jupyter Notebook mit Claude AI und ermöglicht es Claude, direkt mit und in Jupyter Notebooks zu interagieren.
- [arrismo/kaggle-mcp](https://github.com/arrismo/kaggle-mcp) 🐍 ☁️ – Verbindet mit Kaggle, ermöglicht das Herunterladen und Analysieren von Datensätzen.
- [kdqed/zaturn](https://github.com/kdqed/zaturn) 🐍 🏠 🪟 🐧 🍎 – Verknüpft mehrere Datenquellen (SQL, CSV, Parquet, etc.) und lässt die KI die Daten auf Erkenntnisse und Visualisierungen analysieren.
- [mckinsey/vizro-mcp](https://github.com/mckinsey/vizro/tree/main/vizro-mcp) 🎖️ 🐍 🏠 – Tools und Templates zur Erstellung validierter und wartbarer Datencharts und Dashboards.
- [growthbook/growthbook-mcp](https://github.com/growthbook/growthbook-mcp) 🎖️ 📇 🏠 🪟 🐧 🍎 — Tools zur Erstellung und Interaktion mit GrowthBook Feature Flags und Experimenten.

### 📟 <a name="embedded-system"></a>Eingebettete Systeme

Bietet Zugriff auf Dokumentation und Shortcuts für die Arbeit an eingebetteten Geräten.

- [horw/esp-mcp](https://github.com/horw/esp-mcp) 📟 – Workflow zur Behebung von Build-Problemen in ESP32-Chips mit ESP-IDF.
- [kukapay/modbus-mcp](https://github.com/kukapay/modbus-mcp) 🐍 📟 – Ein MCP-Server, der industrielle Modbus-Daten standardisiert und kontextualisiert.
- [kukapay/opcua-mcp](https://github.com/kukapay/opcua-mcp) 🐍 📟 – Ein MCP-Server, der sich mit OPC UA-fähigen industriellen Systemen verbindet.
- [yoelbassin/gnuradioMCP](https://github.com/yoelbassin/gnuradioMCP) 🐍 📟 🏠 – Ein MCP-Server für GNU Radio, der es LLMs ermöglicht, RF-`.grc`-Flussdiagramme autonom zu erstellen und zu bearbeiten.

### 📂 <a name="file-systems"></a>Dateisysteme

Bietet direkten Zugriff auf lokale Dateisysteme mit konfigurierbaren Berechtigungen. Ermöglicht KI-Modellen das Lesen, Schreiben und Verwalten von Dateien innerhalb festgelegter Verzeichnisse.

- [cyberchitta/llm-context.py](https://github.com/cyberchitta/llm-context.py) 🐍 🏠 – Code-Kontext über MCP oder Zwischenablage mit LLMs teilen.
- [exoticknight/mcp-file-merger](https://github.com/exoticknight/mcp-file-merger) 🏎️ 🏠 – Dateizusammenführungstool, geeignet für AI-Chat-Längenlimits.
- [filesystem@quarkiverse/quarkus-mcp-servers](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/filesystem) ☕ 🏠 – Ein Dateisystem, das Browsen und Bearbeiten von Dateien in Java mit Quarkus ermöglicht. Verfügbar als jar oder Native Image.
- [hmk/box-mcp-server](https://github.com/hmk/box-mcp-server) 📇 ☁️ - Box-Integration zum Auflisten, Lesen und Suchen von Dateien
- [mamertofabian/mcp-everything-search](https://github.com/mamertofabian/mcp-everything-search) 🐍 🏠 🪟 - Schnelle Windows-Dateisuche mit Everything SDK
- [mark3labs/mcp-filesystem-server](https://github.com/mark3labs/mcp-filesystem-server) 🏎️ 🏠 - Golang-Implementierung für lokalen Dateisystemzugriff.
- [mickaelkerjean/filestash](https://github.com/mickael-kerjean/filestash/tree/master/server/plugin/plg_handler_mcp) 🏎️ ☁️ - Remote Storage Access: SFTP, S3, FTP, SMB, NFS, WebDAV, GIT, FTPS, gcloud, azure blob, sharepoint, etc.
- [microsoft/markitdown](https://github.com/microsoft/markitdown/tree/main/packages/markitdown-mcp) 🎖️ 🐍 🏠 - MCP-Tool-Zugriff auf MarkItDown -- eine Bibliothek, die viele Dateiformate (lokal oder remote) für LLMs in Markdown konvertiert.
- [modelcontextprotocol/server-filesystem](https://github.com/modelcontextprotocol/servers/tree/main/src/filesystem) 📇 🏠 - Direkter Zugriff auf das lokale Dateisystem.
- [modelcontextprotocol/server-google-drive](https://github.com/modelcontextprotocol/servers/tree/main/src/gdrive) 📇 ☁️ - Google Drive-Integration zum Auflisten, Lesen und Suchen von Dateien
- [Xuanwo/mcp-server-opendal](https://github.com/Xuanwo/mcp-server-opendal) 🐍 🏠 ☁️ - Zugriff auf beliebigen Speicher mit Apache OpenDAL™
- [jeannier/homebrew-mcp](https://github.com/jeannier/homebrew-mcp) 🐍 🏠 🍎 - Steuere deine macOS Homebrew-Installation mit natürlicher Sprache über diesen MCP-Server. Einfaches Paketmanagement, Empfehlungen anfordern, Brew-Probleme beheben usw.

### 💰 <a name="finance--fintech"></a>Finanzen & Fintech

Zugriff und Analysewerkzeuge für Finanzdaten. Ermöglicht KI-Modellen die Arbeit mit Marktdaten, Handelsplattformen und Finanzinformationen.

- [aaronjmars/web3-research-mcp](https://github.com/aaronjmars/web3-research-mcp) 📇 ☁️ - Tiefgehende Recherche für Krypto – kostenlos & vollständig lokal
- [alchemy/alchemy-mcp-server](https://github.com/alchemyplatform/alchemy-mcp-server) 🎖️ 📇 ☁️ - Ermöglicht KI-Agenten die Interaktion mit Alchemys Blockchain-APIs.
- [OctagonAI/octagon-mcp-server](https://github.com/OctagonAI/octagon-mcp-server) 🐍 ☁️ - Octagon KI-Agenten zur Integration von privaten und öffentlichen Marktdaten
- [anjor/coinmarket-mcp-server](https://github.com/anjor/coinmarket-mcp-server) 🐍 ☁️ - Coinmarket-API-Integration zum Abrufen von Kryptowährungslisten und -kursen
- [ariadng/metatrader-mcp-server](https://github.com/ariadng/metatrader-mcp-server) 🐍 🏠 🪟 - Ermöglicht KI-LLMs den Handel über die MetaTrader 5-Plattform
- [armorwallet/armor-crypto-mcp](https://github.com/armorwallet/armor-crypto-mcp) 🐍 ☁️ - MCP zur Schnittstelle mit mehreren Blockchains, Staking, DeFi, Swaps, Brücken, Wallet-Management, DCA, Limit Orders, Coin Lookup, Tracking und mehr.
- [bankless/onchain-mcp](https://github.com/Bankless/onchain-mcp/) 📇 ☁️ - Bankless Onchain API zur Interaktion mit Smart Contracts, Abfrage von Transaktions- und Tokeninformationen
- [base/base-mcp](https://github.com/base/base-mcp) 🎖️ 📇 ☁️ - Base-Netzwerk-Integration für Onchain-Tools, ermöglicht Interaktion mit Base Network und Coinbase API für Wallet-Management, Geldtransfers, Smart Contracts und DeFi-Operationen
- [berlinbra/alpha-vantage-mcp](https://github.com/berlinbra/alpha-vantage-mcp) 🐍 ☁️ - Alpha Vantage-API-Integration zum Abrufen von Aktien- und Krypto-Informationen
- [ahnlabio/bicscan-mcp](https://github.com/ahnlabio/bicscan-mcp) 🎖️ 🐍 ☁️ - Risiko-Score / Asset-Bestände einer EVM-Blockchain-Adresse (EOA, CA, ENS) und sogar Domainnamen.
- [bitteprotocol/mcp](https://github.com/BitteProtocol/mcp) 📇 - Bitte Protocol-Integration zum Betrieb von KI-Agenten auf mehreren Blockchains.
- [chargebee/mcp](https://github.com/chargebee/agentkit/tree/main/modelcontextprotocol) 🎖️ 📇 ☁️ - MCP-Server, der KI-Agenten mit der [Chargebee-Plattform](https://www.chargebee.com/) verbindet.
- [codex-data/codex-mcp](https://github.com/Codex-Data/codex-mcp) 🎖️ 📇 ☁️ - [Codex API](https://www.codex.io) Integration für Echtzeit-Bereitstellung angereicherter Blockchain- und Marktdaten auf 60+ Netzwerken
- [coinpaprika/dexpaprika-mcp](https://github.com/chargebee/agentkit/tree/main/modelcontextprotocol) 🎖️ 📇 ☁️ 🍎 🪟 🐧 - Coinpaprikas DexPaprika-MCP-Server stellt die leistungsfähige [DexPaprika API](https://docs.dexpaprika.com) für 20+ Chains und 5M+ Token mit Echtzeitpreisen, Liquiditätsdaten & historischen OHLCV-Daten bereit und gewährt KI-Agenten standardisierten Zugriff auf umfassende Marktdaten über das Model Context Protocol.
- [doggybee/mcp-server-ccxt](https://github.com/doggybee/mcp-server-ccxt) 📇 ☁️ - Ein MCP-Server für den Zugriff auf Echtzeit-Kryptomarktdaten und Handel über 20+ Börsen mittels der CCXT-Bibliothek. Unterstützt Spot, Futures, OHLCV, Balances, Orders und mehr.
- [ferdousbhai/investor-agent](https://github.com/ferdousbhai/investor-agent) 🐍 ☁️ - Yahoo Finance-Integration zum Abrufen von Börsendaten inklusive Options-Empfehlungen
- [ferdousbhai/tasty-agent](https://github.com/ferdousbhai/tasty-agent) 🐍 ☁️ - Tastyworks-API-Integration für Handelsaktivitäten auf Tastytrade
- [ferdousbhai/wsb-analyst-mcp](https://github.com/ferdousbhai/wsb-analyst-mcp) 🐍 ☁️ - Reddit-Integration zur Analyse der WallStreetBets-Community-Inhalte
- [getalby/nwc-mcp-server](https://github.com/getalby/nwc-mcp-server) 📇 🏠 - Bitcoin Lightning Wallet-Integration über Nostr Wallet Connect
- [heurist-network/heurist-mesh-mcp-server](https://github.com/heurist-network/heurist-mesh-mcp-server) 🎖️ ⛅️ 🏠 🐍 - Zugriff auf spezialisierte Web3-KI-Agenten für Blockchain-Analyse, Smart Contract-Sicherheitsprüfungen, Token-Metriken und Onchain-Interaktionen über das Heurist Mesh-Netzwerk. Bietet umfassende Werkzeuge für DeFi-Analyse, NFT-Bewertung und Transaktionsüberwachung über mehrere Blockchains hinweg.
- [intentos-labs/beeper-mcp](https://github.com/intentos-labs/beeper-mcp) 🐍 - Beeper ermöglicht Transaktionen auf der BSC, einschließlich Balance/Token-Transfers, Token-Swaps in Pancakeswap und Beeper-Belohnungsansprüchen.
- [kukapay/blockbeats-mcp](https://github.com/kukapay/blockbeats-mcp) 🐍 ☁️ -  Ein MCP-Server, der Blockchain-News und ausführliche Artikel von BlockBeats für KI-Agenten bereitstellt.
- [kukapay/bridge-rates-mcp](https://github.com/kukapay/bridge-rates-mcp) 📇 ☁️ - Bereitstellung von Echtzeit-Cross-Chain-Bridge-Raten und optimalen Transferwegen für Onchain-KI-Agenten.
- [kukapay/chainlink-feeds-mcp](https://github.com/kukapay/chainlink-feeds-mcp) 📇 ☁️ -  Bietet Echtzeit-Zugriff auf die dezentralen On-Chain-Preisfeeds von Chainlink.
- [kukapay/cointelegraph-mcp](https://github.com/kukapay/cointelegraph-mcp) 🐍 ☁️ -  Bietet Echtzeit-Zugang zu den neuesten Nachrichten von Cointelegraph.
- [kukapay/crypto-feargreed-mcp](https://github.com/kukapay/crypto-feargreed-mcp) 🐍 ☁️ -  Bietet Echtzeit- und historische Daten zum Crypto Fear & Greed Index.
- [kukapay/crypto-indicators-mcp](https://github.com/kukapay/crypto-indicators-mcp) 🐍 ☁️ - Ein MCP-Server, der eine Reihe von technischen Analyseindikatoren und Strategien für Kryptowährungen bereitstellt.
- [kukapay/crypto-news-mcp](https://github.com/kukapay/crypto-news-mcp) 🐍 ☁️ - Ein MCP-Server, der Echtzeit-Kryptonews aus NewsData für KI-Agenten bereitstellt.
- [kukapay/crypto-portfolio-mcp](https://github.com/kukapay/crypto-portfolio-mcp) 🐍 ☁️ - Ein MCP-Server zur Verfolgung und Verwaltung von Krypto-Portfolioallokationen.
- [kukapay/crypto-rss-mcp](https://github.com/kukapay/crypto-rss-mcp) 🐍 ☁️ - Ein MCP-Server, der Echtzeit-Kryptonews aus mehreren RSS-Feeds aggregiert.
- [kukapay/crypto-sentiment-mcp](https://github.com/kukapay/crypto-sentiment-mcp) 🐍 ☁️ - Ein MCP-Server, der KI-Agenten Stimmungsanalysen zu Kryptowährungen liefert.
- [kukapay/crypto-trending-mcp](https://github.com/kukapay/crypto-trending-mcp) 🐍 ☁️ - Verfolgt die neuesten Trend-Token auf CoinGecko.
- [kukapay/crypto-whitepapers-mcp](https://github.com/kukapay/crypto-whitepapers-mcp) 🐍 ☁️ - Dient als strukturierte Wissensdatenbank für Krypto-Whitepapers.
- [kukapay/cryptopanic-mcp-server](https://github.com/kukapay/cryptopanic-mcp-server) 🐍 ☁️ - Stellt KI-Agenten die neuesten Kryptowährungs-News bereit, betrieben von CryptoPanic.
- [kukapay/defi-yields-mcp](https://github.com/kukapay/defi-yields-mcp) 🐍 ☁️ - Ein MCP-Server für KI-Agenten zur Erkundung von DeFi-Yield-Möglichkeiten.
- [kukapay/dune-analytics-mcp](https://github.com/kukapay/dune-analytics-mcp) 🐍 ☁️ -  Ein MCP-Server, der Dune Analytics-Daten an KI-Agenten vermittelt.
- [kukapay/etf-flow-mcp](https://github.com/kukapay/etf-flow-mcp) 🐍 ☁️ -  Liefert Krypto-ETF-Flow-Daten, um die Entscheidungsfindung von KI-Agenten zu unterstützen.
- [kukapay/freqtrade-mcp](https://github.com/kukapay/freqtrade-mcp) 🐍 ☁️ - Ein MCP-Server, der mit dem Freqtrade-Kryptohandelsbot integriert ist.
- [kukapay/funding-rates-mcp](https://github.com/kukapay/funding-rates-mcp) 🐍 ☁️ - Bietet Echtzeit-Finanzierungsraten-Daten über große Kryptobörsen hinweg.
- [kukapay/jupiter-mcp](https://github.com/kukapay/jupiter-mcp) 🐍 ☁️ - Ein MCP-Server für Token-Swaps auf der Solana-Blockchain unter Nutzung von Jupiters neuer Ultra API.
- [kukapay/pancakeswap-poolspy-mcp](https://github.com/kukapay/pancakeswap-poolspy-mcp) 🐍 ☁️ -  Ein MCP-Server, der neu erstellte Pools auf Pancake Swap überwacht.
- [kukapay/rug-check-mcp](https://github.com/kukapay/rug-check-mcp) 🐍 ☁️ - Ein MCP-Server, der potenzielle Risiken bei Solana-Meme-Token erkennt.
- [kukapay/thegraph-mcp](https://github.com/kukapay/thegraph-mcp) 🐍 ☁️ -  Ein MCP-Server, der KI-Agenten mit indexierten Blockchain-Daten von The Graph versorgt.
- [kukapay/token-minter-mcp](https://github.com/kukapay/token-minter-mcp) 🐍 ☁️ -  Ein MCP-Server mit Werkzeugen für KI-Agenten zum Minten von ERC-20-Token über mehrere Blockchains.
- [kukapay/token-revoke-mcp](https://github.com/kukapay/token-revoke-mcp) 🐍 ☁️ - Ein MCP-Server zum Überprüfen und Widerrufen von ERC-20-Token-Genehmigungen über mehrere Blockchains.
- [kukapay/twitter-username-changes-mcp](https://github.com/kukapay/twitter-username-changes-mcp) 🐍 ☁️ - Ein MCP-Server, der die historischen Änderungen von Twitter-Benutzernamen verfolgt.
- [kukapay/uniswap-poolspy-mcp](https://github.com/kukapay/uniswap-poolspy-mcp) 🐍 ☁️ -  Ein MCP-Server, der neu erstellte Liquiditätspools auf Uniswap über mehrere Blockchains verfolgt.
- [kukapay/uniswap-trader-mcp](https://github.com/kukapay/uniswap-trader-mcp) 🐍 ☁️ -  Ein MCP-Server für KI-Agenten zur Automatisierung von Token-Swaps auf der Uniswap DEX über mehrere Blockchains hinweg.
- [kukapay/whale-tracker-mcp](https://github.com/kukapay/whale-tracker-mcp) 🐍 ☁️ -  Ein MCP-Server zur Verfolgung von Kryptowährungs-Whale-Transaktionen.
- [laukikk/alpaca-mcp](https://github.com/laukikk/alpaca-mcp) 🐍 ☁️ - Ein MCP-Server für die Alpaca Trading API zur Verwaltung von Aktien- und Krypto-Portfolios, Platzierung von Trades und Zugriff auf Marktdaten.
- [longportapp/openapi](https://github.com/longportapp/openapi/tree/main/mcp) - 🐍 ☁️ - LongPort OpenAPI liefert Echtzeit-Börsendaten, bietet KI-Zugriff auf Analyse- und Handelsfunktionen über MCP.
- [mcpdotdirect/evm-mcp-server](https://github.com/mcpdotdirect/evm-mcp-server) 📇 ☁️ - Umfassende Blockchain-Dienste für 30+ EVM-Netzwerke, unterstützt native Token, ERC20, NFTs, Smart Contracts, Transaktionen und ENS-Auflösung.
- [mcpdotdirect/starknet-mcp-server](https://github.com/mcpdotdirect/starknet-mcp-server) 📇 ☁️ - Umfassende Starknet-Blockchain-Integration mit Unterstützung für native Token (ETH, STRK), Smart Contracts, StarknetID-Auflösung und Token-Transfers.
- [minhyeoky/mcp-server-ledger](https://github.com/minhyeoky/mcp-server-ledger) 🐍 🏠 -  Eine ledger-cli-Integration zur Verwaltung von Finanztransaktionen und zur Erstellung von Berichten.
- [openMF/mcp-mifosx](https://github.com/openMF/mcp-mifosx) ☁️ 🏠 -  Eine Core-Banking-Integration zur Verwaltung von Kunden, Krediten, Sparanlagen, Anteilen, Finanztransaktionen und zur Erstellung von Finanzberichten.
- [narumiruna/yfinance-mcp](https://github.com/narumiruna/yfinance-mcp) 🐍 ☁️ - Ein MCP-Server, der yfinance verwendet, um Informationen von Yahoo Finance abzurufen.
- [polygon-io/mcp_polygon)](https://github.com/polygon-io/mcp_polygon)) 🐍 ☁️ -  Ein MCP-Server, der Zugriff auf die [Polygon.io](https://polygon.io/) Finanzmarktdaten-APIs für Aktien, Indizes, Forex, Optionen und mehr bietet.
- [pwh-pwh/coin-mcp-server](https://github.com/pwh-pwh/coin-mcp-server) 🐍 ☁️ -  Bitget-API zum Abrufen von Kryptowährungspreisen.
- [QuantGeekDev/coincap-mcp](https://github.com/QuantGeekDev/coincap-mcp) 📇 ☁️ - Echtzeit-Kryptomarktdatenintegration über die öffentliche CoinCap-API, Zugriff auf Kryptopreise und Marktdaten ohne API-Keys
- [SaintDoresh/Crypto-Trader-MCP-ClaudeDesktop](https://github.com/SaintDoresh/Crypto-Trader-MCP-ClaudeDesktop.git) 🐍 ☁️ - Ein MCP-Tool, das Marktdaten für Kryptowährungen über die CoinGecko API bereitstellt.
- [tooyipjee/yahoofinance-mcp](https://github.com/tooyipjee/yahoofinance-mcp.git) 📇 ☁️ - TS-Version von Yahoo Finance MCP.
- [SaintDoresh/YFinance-Trader-MCP-ClaudeDesktop](https://github.com/SaintDoresh/YFinance-Trader-MCP-ClaudeDesktop.git) 🐍 ☁️ - Ein MCP-Tool, das Börsendaten und Analysen über die Yahoo Finance API bereitstellt.
- [RomThpt/xrpl-mcp-server](https://github.com/RomThpt/mcp-xrpl) 📇 ☁️ - MCP-Server für das XRP Ledger, der Zugriff auf Kontoinformationen, Transaktionshistorie und Netzwerkdaten bietet. Ermöglicht das Abfragen von Ledger-Objekten, das Einreichen von Transaktionen und das Überwachen des XRPL-Netzwerks.
- [janswist/mcp-dexscreener](https://github.com/janswist/mcp-dexscreener) 📇 ☁️ - Echtzeit-On-Chain-Marktkurse mittels offener und kostenloser Dexscreener-API
- [HuggingAGI/mcp-baostock-server](https://github.com/HuggingAGI/mcp-baostock-server) 🐍 ☁️ - MCP-Server auf Basis von baostock, bietet Zugriff und Analysefunktionen für chinesische Börsendaten.
- [wowinter13/solscan-mcp](https://github.com/wowinter13/solscan-mcp) 🦀 🏠 - Ein MCP-Tool zum Abfragen von Solana-Transaktionen in natürlicher Sprache über die Solscan API.
- [Wuye-AI/mcp-server-wuye-ai](https://github.com/wuye-ai/mcp-server-wuye-ai) 🎖️ 📇 ☁️ - Ein MCP-Server zur Interaktion mit den Fähigkeiten der CRIC Wuye AI-Plattform, einem intelligenten Assistenten speziell für die Immobilienverwaltungsbranche.
- [zlinzzzz/finData-mcp-server](https://github.com/zlinzzzz/finData-mcp-server) 🐍 ☁️ - Ein MCP-Server für den Zugriff auf professionelle Finanzdaten, unterstützt mehrere Datenanbieter wie Tushare.

### 🎮 <a name="gaming"></a>Gaming

Integration mit spiebezogenen Daten, Spiele-Engines und Diensten

- [IvanMurzak/Unity-MCP](https://github.com/IvanMurzak/Unity-MCP) #️⃣ 🏠 🍎 🪟 🐧 - MCP-Server für den Unity Editor und für Spiele, die mit Unity erstellt wurden
- [CoderGamester/mcp-unity](https://github.com/CoderGamester/mcp-unity) #️⃣ 🏠 - MCP-Server für die Integration mit der Unity3d Game Engine zur Spieleentwicklung
- [Coding-Solo/godot-mcp](https://github.com/Coding-Solo/godot-mcp) 📇 🏠 - Ein MCP-Server zur Interaktion mit der Godot-Spiele-Engine, bietet Werkzeuge zum Bearbeiten, Ausführen, Debuggen und Verwalten von Szenen in Godot-Projekten.
- [pab1ito/chess-mcp](https://github.com/pab1it0/chess-mcp) 🐍 ☁️ - Zugriff auf Chess.com-Spielerdaten, Partien und andere öffentliche Informationen über standardisierte MCP-Schnittstellen, sodass KI-Assistenten Schachinformationen durchsuchen und analysieren können.
- [jiayao/mcp-chess](https://github.com/jiayao/mcp-chess) 🐍 🏠 - Ein MCP-Server, der Schach gegen LLMs spielt.
- [rishijatia/fantasy-pl-mcp](https://github.com/rishijatia/fantasy-pl-mcp/) 🐍 ☁️ - Ein MCP-Server für Echtzeit-Fantasy Premier League-Daten und Analysetools.
- [opgginc/opgg-mcp](https://github.com/opgginc/opgg-mcp) 📇 ☁️ - Zugriff auf Echtzeit-Gamingdaten beliebter Titel wie League of Legends, TFT und Valorant, bietet Champion-Analysen, E-Sport-Zeitpläne, Meta-Kombinationen und Charakterstatistiken.
- [stefan-xyz/mcp-server-runescape](https://github.com/stefan-xyz/mcp-server-runescape) 📇 - Ein MCP-Server mit Tools zur Interaktion mit RuneScape (RS) und Old School RuneScape (OSRS)-Daten, einschließlich Item-Preisen, Spieler-Highscores und mehr.

### 🧠 <a name="knowledge--memory"></a>Wissen & Gedächtnis

Persistenter Speicher unter Verwendung von Wissensgraphstrukturen. Ermöglicht KI-Modellen, strukturierte Informationen über Sitzungen hinweg vorzuhalten und abzufragen.
- [CheMiguel23/MemoryMesh](https://github.com/CheMiguel23/MemoryMesh) 📇 🏠 – Verbesserter graphbasierter Speicher mit Fokus auf KI-Rollenspiel und Story-Generierung
- [graphlit-mcp-server](https://github.com/graphlit/graphlit-mcp-server) 📇 ☁️ – Importiere alles aus Slack, Discord, Websites, Google Drive, Linear oder GitHub in ein Graphlit-Projekt – und suche dann nach relevantem Wissen innerhalb eines MCP-Clients wie Cursor, Windsurf oder Cline.
- [hannesrudolph/mcp-ragdocs](https://github.com/hannesrudolph/mcp-ragdocs) 🐍 🏠 – Eine MCP-Server-Implementierung, die Werkzeuge zum Abrufen und Verarbeiten von Dokumentationen durch Vektorensuche bereitstellt und es KI-Assistenten ermöglicht, ihre Antworten mit relevantem Dokumentationskontext anzureichern.
- [jinzcdev/markmap-mcp-server](https://github.com/jinzcdev/markmap-mcp-server) 📇 🏠 – Ein MCP-Server auf Basis von [markmap](https://github.com/markmap/markmap), der **Markdown** in interaktive **Mindmaps** umwandelt. Unterstützt Multi-Format-Exporte (PNG/JPG/SVG), Live-Browser-Vorschau, Ein-Klick-Markdown-Kopie und dynamische Visualisierungsfunktionen.
- [kaliaboi/mcp-zotero](https://github.com/kaliaboi/mcp-zotero) 📇 ☁️ – Ein Connector, damit LLMs mit Sammlungen und Quellen auf deiner Zotero Cloud arbeiten können
- [mcp-summarizer](https://github.com/0xshellming/mcp-summarizer) 📕 ☁️ – KI-Zusammenfassungs-MCP-Server, unterstützt mehrere Inhaltstypen: Klartext, Webseiten, PDF-Dokumente, EPUB-Bücher, HTML-Inhalte
- [mem0ai/mem0-mcp](https://github.com/mem0ai/mem0-mcp) 🐍 🏠 – Ein Model Context Protocol Server für Mem0, der hilft, Coding-Präferenzen und -Muster zu verwalten, Werkzeuge zum Speichern, Abrufen und semantischen Verarbeiten von Code-Implementierungen, Best Practices und technischer Dokumentation in IDEs wie Cursor und Windsurf bereitstellt
- [modelcontextprotocol/server-memory](https://github.com/modelcontextprotocol/servers/tree/main/src/memory) 📇 🏠 – Wissensgraph-basierter persistenter Speichersystem zum Erhalt von Kontext
- [pinecone-io/assistant-mcp](https://github.com/pinecone-io/assistant-mcp) 🎖️ 🦀 ☁️ – Verbindet sich mit deinem Pinecone Assistant und gibt dem Agenten Kontext aus seiner Wissens-Engine.
- [@ragieai/mcp-server](https://github.com/ragieai/ragie-mcp-server) 📇 ☁️ – Holt Kontext aus deiner [Ragie](https://www.ragie.ai) (RAG) Wissensbasis, die mit Integrationen wie Google Drive, Notion, JIRA und mehr verbunden ist.
- [TechDocsStudio/biel-mcp](https://github.com/TechDocsStudio/biel-mcp) 📇 ☁️ – Lass KI-Tools wie Cursor, VS Code oder Claude Desktop Fragen mit deinen Produktdokumentationen beantworten. Biel.ai stellt das RAG-System und den MCP-Server bereit.
- [topoteretes/cognee](https://github.com/topoteretes/cognee/tree/dev/cognee-mcp) 📇 🏠 – Speichermanager für KI-Apps und Agenten, der verschiedene Graph- und Vektorspeicher nutzt und das Importieren aus über 30 Datenquellen ermöglicht
- [unibaseio/membase-mcp](https://github.com/unibaseio/membase-mcp) 📇 ☁️ – Speicher und Abfrage deines Agenten-Speichers auf verteilte Weise mit Membase
- [GistPad-MCP](https://github.com/lostintangent/gistpad-mcp) 📇 🏠 – Nutze GitHub Gists zur Verwaltung und zum Zugriff auf dein persönliches Wissen, tägliche Notizen und wiederverwendbare Prompts. Dies dient als Begleiter zu https://gistpad.dev und der [GistPad VS Code Erweiterung](https://aka.ms/gistpad).
- [entanglr/zettelkasten-mcp](https://github.com/entanglr/zettelkasten-mcp) 🐍 🏠 – Ein Model Context Protocol (MCP) Server, der die Zettelkasten-Wissensmanagement-Methode implementiert und es ermöglicht, atomare Notizen zu erstellen, zu verknüpfen und zu durchsuchen – etwa mit Claude und anderen MCP-kompatiblen Clients.

### 🗺️ <a name="location-services"></a>Location Services

Standortbasierte Dienste und Kartierungstools. Erlaubt KI-Modellen, mit geografischen Daten, Wetterinformationen und standortbasierten Analysen zu arbeiten.

- [briandconnelly/mcp-server-ipinfo](https://github.com/briandconnelly/mcp-server-ipinfo) 🐍 ☁️  – IP-Adress-Geolokalisierung und Netzwerkinformationen über die IPInfo API
- [devilcoder01/weather-mcp-server](https://github.com/devilcoder01/weather-mcp-server) 🐍 ☁️ – Zugriff auf Echtzeit-Wetterdaten für beliebige Standorte mit der WeatherAPI.com API, inklusive detaillierter Vorhersagen und aktueller Bedingungen.
- [jagan-shanmugam/open-streetmap-mcp](https://github.com/jagan-shanmugam/open-streetmap-mcp) 🐍 🏠 – Ein OpenStreetMap-MCP-Server mit standortbasierten Diensten und Geodaten.
- [kukapay/nearby-search-mcp](https://github.com/kukapay/nearby-search-mcp) 🐍 ☁️ – Ein MCP-Server für die Suche nach nahegelegenen Orten mit IP-basierter Standorterkennung.
- [modelcontextprotocol/server-google-maps](https://github.com/modelcontextprotocol/servers/tree/main/src/google-maps) 📇 ☁️ – Google-Maps-Integration für Standortdienste, Routenführung und Ortsdetails
- [QGIS MCP](https://github.com/jjsantos01/qgis_mcp) – Verbindet QGIS Desktop mit Claude AI über das MCP. Diese Integration ermöglicht promptgestützte Projekterstellung, Layer-Laden, Code-Ausführung und mehr.
- [SaintDoresh/Weather-MCP-ClaudeDesktop](https://github.com/SaintDoresh/Weather-MCP-ClaudeDesktop.git) 🐍 ☁️ – Ein MCP-Tool, das Echtzeit-Wetterdaten, Vorhersagen und historische Wetterinformationen mittels OpenWeatherMap API bereitstellt.
- [rossshannon/Weekly-Weather-mcp](https://github.com/rossshannon/weekly-weather-mcp.git) 🐍 ☁️ – Weekly Weather MCP-Server, der 7 vollständige Tage detaillierter Wettervorhersagen weltweit liefert.
- [SecretiveShell/MCP-timeserver](https://github.com/SecretiveShell/MCP-timeserver) 🐍 🏠 – Zugriff auf die Zeit in jeder Zeitzone und Anzeige der aktuellen Lokalzeit
- [TimLukaHorstmann/mcp-weather](https://github.com/TimLukaHorstmann/mcp-weather) 📇 ☁️  – Präzise Wettervorhersagen über die AccuWeather API (kostenlose Stufe verfügbar).
- [webcoderz/MCP-Geo](https://github.com/webcoderz/MCP-Geo) 🐍 🏠 – Geocoding-MCP-Server für nominatim, ArcGIS, Bing
- [ipfind/ipfind-mcp-server](https://github.com/ipfind/ipfind-mcp-server) 🐍 ☁️ – IP-Adress-Standortdienst mittels [IP Find](https://ipfind.com) API
- [mahdin75/geoserver-mcp](https://github.com/mahdin75/geoserver-mcp) 🏠 – Eine MCP-Server-Implementierung, die LLMs mit der GeoServer-REST-API verbindet und KI-Assistenten die Interaktion mit Geodaten und -diensten ermöglicht.
- [ipfred/aiwen-mcp-server-geoip](https://github.com/ipfred/aiwen-mcp-server-geoip) 🐍 📇 ☁️ – MCP-Server für Aiwen IP Location: Abfrage des Standorts von Nutzer-IP-Adressen, Details wie Land, Provinz, Stadt, Breite, Länge, ISP, Eigentümer usw.

### 🎯 <a name="marketing"></a>Marketing

Werkzeuge zur Erstellung und Bearbeitung von Marketinginhalten, Arbeit mit Web-Metadaten, Produktpositionierung und Bearbeitungsrichtlinien.

- [gomarble-ai/facebook-ads-mcp-server](https://github.com/gomarble-ai/facebook-ads-mcp-server) 🐍 ☁️ – MCP-Server als Schnittstelle zu Facebook Ads, ermöglicht programmgesteuerten Zugriff auf Facebook-Ads-Daten und Managementfunktionen.
- [open-strategy-partners/osp_marketing_tools](https://github.com/open-strategy-partners/osp_marketing_tools) 🐍 🏠 – Eine Suite von Marketing-Tools von Open Strategy Partners inklusive Schreibstil, Bearbeitungscodes und Erstellung von Produktmarketing-Value-Maps.
- [nictuku/meta-ads-mcp](https://github.com/nictuku/meta-ads-mcp) 🐍 ☁️ 🏠 – Ermöglicht KI-Agenten die Überwachung und Optimierung der Meta-Anzeigenleistung, Analyse von Kampagnenmetriken, Anpassung der Zielgruppenansprache, Verwaltung von Werbekreatives und datengestützte Empfehlungen für Werbeausgaben und Kampagneneinstellungen durch nahtlose Graph-API-Integration.
- [marketplaceadpros/amazon-ads-mcp-server](https://github.com/MarketplaceAdPros/amazon-ads-mcp-server) 📇 ☁️ – Ermöglicht Tools die Interaktion mit Amazon Advertising, Analyse von Kampagnenmetriken und Konfigurationen.

### 📊 <a name="monitoring"></a>Monitoring

Zugriff auf und Analyse von Anwendungs-Monitoring-Daten. Ermöglicht KI-Modellen die Überprüfung von Fehlerberichten und Leistungsmetriken.

- [netdata/netdata#Netdata](https://github.com/netdata/netdata/blob/master/src/web/mcp/README.md) 🎖️ 🏠 ☁️ 📟 🍎 🪟 🐧 – Entdeckung, Erkundung, Berichterstattung und Ursachenanalyse mit sämtlichen Observability-Daten, inklusive Metriken, Logs, Systeme, Container, Prozesse und Netzwerkverbindungen
- [grafana/mcp-grafana](https://github.com/grafana/mcp-grafana) 🎖️ 🐍 🏠 ☁️ – Suche nach Dashboards, Untersuchung von Vorfällen und Abfrage von Datenquellen in deiner Grafana-Instanz
- [tumf/grafana-loki-mcp](https://github.com/tumf/grafana-loki-mcp) 🐍 🏠 – Ein MCP-Server, der die Abfrage von Loki-Logs über die Grafana-API ermöglicht.
- [hyperb1iss/lucidity-mcp](https://github.com/hyperb1iss/lucidity-mcp) 🐍 🏠 – Verbesserung der KI-generierten Codequalität durch intelligente, promptbasierte Analyse in 10 kritischen Dimensionen von Komplexität bis zu Sicherheitslücken
- [last9/last9-mcp-server](https://github.com/last9/last9-mcp-server) – Bringe nahtlos Echtzeit-Produktionskontext – Logs, Metriken und Traces – in deine lokale Umgebung, um Code schneller automatisch zu beheben
- [metoro-io/metoro-mcp-server](https://github.com/metoro-io/metoro-mcp-server) 🎖️ 🏎️ ☁️ – Abfrage und Interaktion mit von Metoro überwachten Kubernetes-Umgebungen
- [MindscapeHQ/server-raygun](https://github.com/MindscapeHQ/mcp-server-raygun) 📇 ☁️ – Raygun API V3 Integration für Crash-Reporting und Real User Monitoring
- [modelcontextprotocol/server-sentry](https://github.com/modelcontextprotocol/servers/tree/main/src/sentry) 🐍 ☁️ – Sentry.io Integration für Fehlertracking und Performance Monitoring
- [pydantic/logfire-mcp](https://github.com/pydantic/logfire-mcp) 🎖️ 🐍 ☁️ – Zugriff auf OpenTelemetry-Traces und -Metriken via Logfire
- [seekrays/mcp-monitor](https://github.com/seekrays/mcp-monitor) 🏎️ 🏠 – Ein Systemüberwachungstool, das Systemmetriken über das Model Context Protocol (MCP) bereitstellt. Dieses Tool ermöglicht LLMs, Echtzeit-Systeminformationen über eine MCP-kompatible Schnittstelle abzurufen. (unterstützt CPU, Speicher, Festplatte, Netzwerk, Host, Prozess)
- [VictoriaMetrics-Community/mcp-victoriametrics](https://github.com/VictoriaMetrics-Community/mcp-victoriametrics) 🎖️ 🏎️ 🏠 – Umfassende Integration mit deinen [VictoriaMetrics-Instanz-APIs](https://docs.victoriametrics.com/victoriametrics/url-examples/) und [Dokumentation](https://docs.victoriametrics.com/) für Monitoring, Observability und Debugging deiner VictoriaMetrics-Instanzen

### 🎥 <a name="multimedia-process"></a>Multimedia Process

Ermöglicht die Verarbeitung von Multimedia wie Audio- und Videobearbeitung, Wiedergabe, Formatkonvertierung; beinhaltet auch Video-Filter, Verbesserungen usw.

- [video-creator/ffmpeg-mcp](https://github.com/video-creator/ffmpeg-mcp.git) 🎥 🔊 – Mithilfe der ffmpeg-Kommandozeile als MCP-Server können bequem lokale Videos durchsucht, geschnitten, zusammengefügt, wiedergegeben und weitere Funktionen per Dialog realisiert werden.
- [stass/exif-mcp](https://github.com/stass/exif-mcp) 📇 🏠 🐧 🍎 🪟 – Ein MCP-Server zur Untersuchung von Bildmetadaten wie EXIF, XMP, JFIF und GPS. Dies bildet die Grundlage für LLM-gestützte Suche und Analyse von Fotobibliotheken und Bildersammlungen.
- [sunriseapps/imagesorcery-mcp](https://github.com/sunriseapps/imagesorcery-mcp) 🐍 🏠 🐧 🍎 🪟 – ComputerVision-basierte 🪄 Bild-Erkennung und Bearbeitungswerkzeuge für KI-Assistenten.

### 🔎 <a name="search"></a>Search & Data Extraction

- [Xyber-Labs/mcp-server-youtube](https://github.com/Xyber-Labs/mcp-servers/tree/main/mcp-server-youtube) 🐍 ☁️ – Dieses Repository implementiert einen MCP-Server (Model Context Protocol) für YouTube-Suche und Transkriptabruf. Es ermöglicht Sprachmodellen und anderen Agenten, YouTube-Inhalte einfach über ein standardisiertes Protokoll abzufragen.
- [ricocf/mcp-wolframalpha](https://github.com/ricocf/mcp-wolframalpha) 🐍 🏠 ☁️ – Ein MCP-Server, der KI-Assistenten die Nutzung der Wolfram Alpha API für Echtzeit-Zugriff auf berechnetes Wissen und Daten ermöglicht.
- [scrapeless-ai/scrapeless-mcp-server](https://github.com/scrapeless-ai/scrapeless-mcp-server) 🐍 ☁️ – Der Scrapeless Model Context Protocol Service dient als MCP-Server-Connector zur Google SERP API und ermöglicht Websuche innerhalb des MCP-Ökosystems.
- [0xdaef0f/job-searchoor](https://github.com/0xDAEF0F/job-searchoor) 📇 🏠 – Ein MCP-Server zur Suche nach Stellenanzeigen mit Filtern für Datum, Stichwörter, Remote-Optionen und mehr.
- [ac3xx/mcp-servers-kagi](https://github.com/ac3xx/mcp-servers-kagi) 📇 ☁️ – Kagi Search API Integration
- [andybrandt/mcp-simple-arxiv](https://github.com/andybrandt/mcp-simple-arxiv) – 🐍 ☁️ MCP für LLMs zur Suche und zum Lesen von arXiv-Papieren
- [hbg/mcp-paperswithcode](https://github.com/hbg/mcp-paperswithcode) – 🐍 ☁️ MCP zur Suche über die PapersWithCode API
- [andybrandt/mcp-simple-pubmed](https://github.com/andybrandt/mcp-simple-pubmed) – 🐍 ☁️ MCP zur Suche und zum Lesen von medizinischen/Lebenswissenschaften-Papieren aus PubMed
- [angheljf/nyt](https://github.com/angheljf/nyt) 📇 ☁️ – Suche nach Artikeln über die NYTimes API
- [apify/mcp-server-rag-web-browser](https://github.com/apify/mcp-server-rag-web-browser) 📇 ☁️ – Ein MCP-Server für Apifys Open-Source RAG Web Browser Actor, um Websuchen durchzuführen, URLs zu scrapen und Inhalte als Markdown zurückzugeben.
- [Bigsy/Clojars-MCP-Server](https://github.com/Bigsy/Clojars-MCP-Server) 📇 ☁️ – Clojars MCP Server für aktuelle Abhängigkeitsinformationen von Clojure-Bibliotheken
- [blazickjp/arxiv-mcp-server](https://github.com/blazickjp/arxiv-mcp-server) ☁️ 🐍 – Suche nach ArXiv-Forschungsarbeiten
- [luminati-io/brightdata-mcp](https://github.com/luminati-io/brightdata-mcp) 📇 ☁️ – Entdecken, extrahieren und interagieren mit dem Web – eine Schnittstelle für den automatisierten Zugriff auf das öffentliche Internet.
- [chanmeng/google-news-mcp-server](https://github.com/ChanMeng666/server-google-news) 📇 ☁️ – Google News-Integration mit automatischer Themenkategorisierung, Mehrsprachigkeit und umfassenden Suchfunktionen wie Schlagzeilen, Geschichten und verwandten Themen über [SerpAPI](https://serpapi.com/).
- [ConechoAI/openai-websearch-mcp](https://github.com/ConechoAI/openai-websearch-mcp/) 🐍 🏠 ☁️ – Python-basierter MCP-Server, der das OpenAI-`web_search`-Tool bereitstellt.
- [dealx/mcp-server](https://github.com/DealExpress/mcp-server) ☁️ – MCP-Server für die DealX-Plattform
- [devflowinc/trieve](https://github.com/devflowinc/trieve/tree/main/clients/mcp-server) 🎖️ 📇 ☁️ 🏠 – Crawlen, einbetten, chunking, suchen und Informationen aus Datensätzen über [Trieve](https://trieve.ai) abrufen
- [Dumpling-AI/mcp-server-dumplingai](https://github.com/Dumpling-AI/mcp-server-dumplingai) 🎖️ 📇 ☁️ – Zugriff auf Daten, Webscraping und Dokumentkonvertierungs-APIs von [Dumpling AI](https://www.dumplingai.com/)
- [erithwik/mcp-hn](https://github.com/erithwik/mcp-hn) 🐍 ☁️ – Ein MCP-Server zur Suche bei Hacker News, Top-Stories und mehr.
- [exa-labs/exa-mcp-server](https://github.com/exa-labs/exa-mcp-server) 🎖️ 📇 ☁️ – Ein Model Context Protocol (MCP) Server, der KI-Assistenten wie Claude die Nutzung der Exa AI Search API für Websuche ermöglicht. Dieses Setup erlaubt KI-Modellen, Echtzeit-Webinformationen sicher und kontrolliert abzurufen.
- [fatwang2/search1api-mcp](https://github.com/fatwang2/search1api-mcp) 📇 ☁️ – Suche über search1api (benötigt kostenpflichtigen API-Key)
- [genomoncology/biomcp](https://github.com/genomoncology/biomcp) 🐍 ☁️ – Server für biomedizinische Forschung mit Zugang zu PubMed, ClinicalTrials.gov und MyVariant.info.
- [hellokaton/unsplash-mcp-server](https://github.com/hellokaton/unsplash-mcp-server)) 🐍 ☁️ – MCP-Server für Unsplash-Bildsuche.
- [Ihor-Sokoliuk/MCP-SearXNG](https://github.com/ihor-sokoliuk/mcp-searxng) 📇 🏠/☁️ – Model Context Protocol Server für [SearXNG](https://docs.searxng.org)
- [isnow890/naver-search-mcp](https://github.com/isnow890/naver-search-mcp) 📇 ☁️ – MCP-Server für Naver Search API-Integration, unterstützt Blog-, News-, Shopping-Suche und DataLab-Analysefunktionen.
- [jae-jae/fetcher-mcp](https://github.com/jae-jae/fetcher-mcp) 📇 🏠 – MCP-Server zum Abrufen von Webseiteninhalten mit Playwright-Headless-Browser, unterstützt Javascript-Rendering, intelligente Inhaltsextraktion und Ausgabe als Markdown oder HTML.
- [jae-jae/g-search-mcp](https://github.com/jae-jae/g-search-mcp) 📇 🏠 – Leistungsstarker MCP-Server für Google-Suche, ermöglicht parallele Suche mit mehreren Schlüsselwörtern gleichzeitig.
- [ananddtyagi/webpage-screenshot-mcp](https://github.com/ananddtyagi/webpage-screenshot-mcp) 📇 🏠 – MCP-Server für Screenshots von Webseiten als Feedback während der UI-Entwicklung.
- [leehanchung/bing-search-mcp](https://github.com/leehanchung/bing-search-mcp) 📇 ☁️ – Websuchfunktionalität über die Microsoft Bing Search API
- [kagisearch/kagimcp](https://github.com/kagisearch/kagimcp) ☁️ 📇 – Offizieller Kagi Search MCP Server
- [kshern/mcp-tavily](https://github.com/kshern/mcp-tavily.git) ☁️ 📇 – Tavily AI-Such-API
- [mikechao/brave-search-mcp](https://github.com/mikechao/brave-search-mcp) 📇 ☁️ - Web-, Bild-, Nachrichten-, Video- und lokale Point-of-Interest-Suchfunktionen mit Braves Search-API
- [emicklei/melrose-mcp](https://github.com/emicklei/melrose-mcp) 🏎️ 🏠 - Spielt [Melrōse](https://melrōse.org)-Musikausdrücke als MIDI ab
- [modelcontextprotocol/server-brave-search](https://github.com/modelcontextprotocol/servers/tree/main/src/brave-search) 📇 ☁️ - Websuche mit Braves Search-API
- [modelcontextprotocol/server-fetch](https://github.com/modelcontextprotocol/servers/tree/main/src/fetch) 🐍 🏠 ☁️ - Effizientes Abrufen und Verarbeiten von Webinhalten für die KI-Nutzung
- [mzxrai/mcp-webresearch](https://github.com/mzxrai/mcp-webresearch) 🔍📚 - Google-Suche und Deep-Web-Recherche zu jedem Thema
- [nickclyde/duckduckgo-mcp-server](https://github.com/nickclyde/duckduckgo-mcp-server) 🐍 ☁️ - Websuche mit DuckDuckGo
- [r-huijts/opentk-mcp](https://github.com/r-huijts/opentk-mcp) 📇 ☁️ - Zugriff auf Informationen des niederländischen Parlaments (Tweede Kamer) einschließlich Dokumenten, Debatten, Aktivitäten und Gesetzgebungsfällen über strukturierte Suchfunktionen (basiert auf dem opentk-Projekt von Bert Hubert)
- [reading-plus-ai/mcp-server-deep-research](https://github.com/reading-plus-ai/mcp-server-deep-research) 📇 ☁️ - MCP-Server für OpenAI/Perplexity-ähnliche autonome Tiefenrecherche, strukturierte Abfrageausarbeitung und prägnante Berichterstattung.
- [SecretiveShell/MCP-searxng](https://github.com/SecretiveShell/MCP-searxng) 🐍 🏠 - Ein MCP-Server zur Verbindung mit searXNG-Instanzen
- [takashiishida/arxiv-latex-mcp](https://github.com/takashiishida/arxiv-latex-mcp) 🐍 ☁️ - Erhalten Sie den LaTeX-Quelltext von arXiv-Papieren zur Verarbeitung mathematischer Inhalte und Gleichungen
- [the0807/GeekNews-MCP-Server](https://github.com/the0807/GeekNews-MCP-Server) 🐍 ☁️ - Ein MCP-Server, der Nachrichten von der GeekNews-Seite abruft und verarbeitet.
- [tinyfish-io/agentql-mcp](https://github.com/tinyfish-io/agentql-mcp) 🎖️ 📇 ☁️ - MCP-Server, der die Datenextraktionsfunktionen von [AgentQL](https://agentql.com) bereitstellt.
- [Tomatio13/mcp-server-tavily](https://github.com/Tomatio13/mcp-server-tavily) ☁️ 🐍 – Tavily AI-Such-API
- [vectorize-io/vectorize-mcp-server](https://github.com/vectorize-io/vectorize-mcp-server/) ☁️ 📇 - [Vectorize](https://vectorize.io) MCP-Server für fortgeschrittene Suche, Private Deep Research, Anything-to-Markdown-Dateiextraktion und Textsegmentierung.
- [webscraping-ai/webscraping-ai-mcp-server](https://github.com/webscraping-ai/webscraping-ai-mcp-server) 🎖️ 📇 ☁️ - Interaktion mit [WebScraping.ai](https://webscraping.ai) für Webdatenextraktion und Scraping.
- [zhsama/duckduckgo-mcp-server](https://github.com/zhsama/duckduckgo-mpc-server/) 📇 🏠 ☁️ - Ein auf TypeScript basierender MCP-Server, der DuckDuckGo-Suchfunktionen bereitstellt.
- [zoomeye-ai/mcp_zoomeye](https://github.com/zoomeye-ai/mcp_zoomeye) 📇 ☁️ - Abfrage von Netzwerk-Asset-Informationen über den ZoomEye MCP-Server
- [yamanoku/baseline-mcp-server](https://github.com/yamanoku/baseline-mcp-server) 📇 🏠 - MCP-Server, der den Baseline-Status über die Web Platform API abfragt
- [longevity-genie/biothings-mcp](https://github.com/longevity-genie/biothings-mcp) 🐍 ☁️ - MCP-Server zur Interaktion mit der BioThings-API, einschließlich Gene, genetischer Varianten, Medikamente und taxonomischer Informationen
- [joelio/stocky](https://github.com/joelio/stocky) 🐍 ☁️ 🏠 - Ein MCP-Server zum Suchen und Herunterladen von lizenzfreien Stockfotos von Pexels und Unsplash. Bietet Multi-Provider-Suche, umfangreiche Metadaten, Paginierungsunterstützung und asynchrone Performance, damit KI-Assistenten hochwertige Bilder finden und abrufen können.

### 🔒 <a name="security"></a>Sicherheit

- [LaurieWired/GhidraMCP](https://github.com/LaurieWired/GhidraMCP) ☕ 🏠 - Ein Model Context Protocol Server für Ghidra, der LLMs autonomes Reverse Engineering von Anwendungen ermöglicht. Bietet Werkzeuge zum Dekompilieren von Binärdateien, Umbenennen von Methoden und Daten sowie Auflisten von Methoden, Klassen, Imports und Exports.
- [dkvdm/onepassword-mcp-server](https://github.com/dkvdm/onepassword-mcp-server) - Ein MCP-Server, der die sichere Bereitstellung von Zugangsdaten aus 1Password für Agentic AI ermöglicht.
- [firstorderai/authenticator_mcp](https://github.com/firstorderai/authenticator_mcp) 📇 🏠 🍎 🪟 🐧 – Ein sicherer MCP (Model Context Protocol) Server, der KI-Agenten die Interaktion mit der Authenticator-App ermöglicht.
- [13bm/GhidraMCP](https://github.com/13bm/GhidraMCP) 🐍 ☕ 🏠 - MCP-Server zur Integration von Ghidra mit KI-Assistenten. Dieses Plugin ermöglicht Binäranalyse und bietet Werkzeuge zur Funktionsinspektion, Dekompilierung, Speicheranalyse und Import/Export-Analyse über das Model Context Protocol.
- [atomicchonk/roadrecon_mcp_server](https://github.com/atomicchonk/roadrecon_mcp_server) 🐍 🪟 🏠 MCP-Server zur Analyse von ROADrecon-Ergebnissen aus der Azure-Tenant-Aufzählung
- [BurtTheCoder/mcp-dnstwist](https://github.com/BurtTheCoder/mcp-dnstwist) 📇 🪟 ☁️ - MCP-Server für dnstwist, ein leistungsstarkes DNS-Fuzzing-Tool zum Erkennen von Typosquatting, Phishing und Industriespionage.
- [BurtTheCoder/mcp-maigret](https://github.com/BurtTheCoder/mcp-maigret) 📇 🪟 ☁️ - MCP-Server für maigret, ein leistungsstarkes OSINT-Tool zur Sammlung von Benutzerkontoinformationen aus verschiedenen öffentlichen Quellen. Dieser Server bietet Werkzeuge zur Benutzernamenssuche in sozialen Netzwerken und zur Analyse von URLs.
- [BurtTheCoder/mcp-shodan](https://github.com/BurtTheCoder/mcp-shodan) 📇 🪟 ☁️ - MCP-Server zur Abfrage der Shodan-API und Shodan CVEDB. Dieser Server bietet Tools für IP-Abfragen, Gerätesuchen, DNS-Lookups, Schwachstellenabfragen, CPE-Lookups und mehr.
- [BurtTheCoder/mcp-virustotal](https://github.com/BurtTheCoder/mcp-virustotal) 📇 🪟 ☁️ - MCP-Server zur Abfrage der VirusTotal-API. Dieser Server bietet Werkzeuge zum Scannen von URLs, Analysieren von Dateihashes und Abrufen von IP-Adressberichten.
- [fosdickio/binary_ninja_mcp](https://github.com/fosdickio/binary_ninja_mcp) 🐍 🏠 🍎 🪟 🐧 - Ein Binary Ninja Plugin, MCP-Server und Bridge, der [Binary Ninja](https://binary.ninja) nahtlos mit Ihrem bevorzugten MCP-Client integriert. Ermöglicht die Automatisierung von Binäranalyse und Reverse Engineering.
- [fr0gger/MCP_Security](https://github.com/fr0gger/MCP_Security) 📇 ☁️ - MCP-Server zur Abfrage der ORKL-API. Dieser Server bietet Werkzeuge zur Bedrohungsanalyse, Akteuranalyse und zur Abrufung von Intelligence-Quellen.
- [gbrigandi/mcp-server-cortex](https://github.com/gbrigandi/mcp-server-cortex) 🦀 🏠 🚨 🍎 🪟 🐧 - Ein Rust-basierter MCP-Server zur Integration von Cortex, ermöglicht beobachtbare Analysen und automatisierte Sicherheitsreaktionen durch KI.
- [gbrigandi/mcp-server-thehive](https://github.com/gbrigandi/mcp-server-thehive) 🦀 🏠 🚨 🍎 🪟 🐧 - Ein Rust-basierter MCP-Server zur Integration von TheHive, erleichtert die kollaborative Sicherheitsvorfallbearbeitung und Fallmanagement via KI.
- [gbrigandi/mcp-server-wazuh](https://github.com/gbrigandi/mcp-server-wazuh) 🦀 🏠 🚨 🍎 🪟 🐧 - Ein Rust-basierter MCP-Server, der Wazuh SIEM mit KI-Assistenten verbindet und Echtzeit-Sicherheitswarnungen sowie Eventdaten für ein verbessertes Kontextverständnis bereitstellt.
- [intruder-io/intruder-mcp](https://github.com/intruder-io/intruder-mcp) 🐍 ☁️ - MCP-Server für den Zugriff auf [Intruder](https://www.intruder.io/), um Sicherheitslücken in Ihrer Infrastruktur zu identifizieren, verstehen und zu beheben.
- [jyjune/mcp_vms](https://github.com/jyjune/mcp_vms) 🐍 🏠 🪟 - Ein Model Context Protocol (MCP) Server für die Verbindung zu einem CCTV-Aufzeichnungsprogramm (VMS), um aufgezeichnete und Live-Video-Streams abzurufen. Bietet außerdem Steuerungsmöglichkeiten für die VMS-Software, wie das Anzeigen von Live- oder Wiedergabedialogen für bestimmte Kanäle zu bestimmten Zeiten.
- [qianniuspace/mcp-security-audit](https://github.com/qianniuspace/mcp-security-audit) 📇 ☁️ Ein leistungsstarker MCP (Model Context Protocol) Server, der npm-Paketabhängigkeiten auf Sicherheitslücken prüft. Mit Remote-npm-Registry-Integration für Echtzeit-Sicherheitsprüfungen.
- [semgrep/mcp](https://github.com/semgrep/mcp) 📇 ☁️ Ermöglicht KI-Agenten das Scannen von Code auf Sicherheitslücken mit [Semgrep](https://semgrep.dev).
- [slouchd/cyberchef-api-mcp-server](https://github.com/slouchd/cyberchef-api-mcp-server) 🐍 ☁️ - MCP-Server zur Interaktion mit der CyberChef-Server-API, die es einem MCP-Client ermöglicht, die CyberChef-Operationen zu nutzen.
- [mrexodia/ida-pro-mcp](https://github.com/mrexodia/ida-pro-mcp) 🐍 🏠 - MCP-Server für IDA Pro, der Binäranalyse mit KI-Assistenten ermöglicht. Dieses Plugin implementiert Dekompilierung, Disassemblierung und ermöglicht es, automatisch Malware-Analyseberichte zu erstellen.
- [rad-security/mcp-server](https://github.com/rad-security/mcp-server) 📇 ☁️ - MCP-Server für RAD Security, der KI-gestützte Sicherheitsanalysen für Kubernetes- und Cloud-Umgebungen bereitstellt. Dieser Server bietet Tools zur Abfrage der Rad Security API und zum Abruf von Security Findings, Berichten, Laufzeitdaten und vielem mehr.
- [securityfortech/secops-mcp](https://github.com/securityfortech/secops-mcp) 🐍 🏠 - All-in-One Security Testing Toolbox, die beliebte Open-Source-Tools über eine einzige MCP-Schnittstelle vereint. Verbunden mit einem KI-Agenten ermöglicht sie Aufgaben wie Pentesting, Bug Bounty Hunting, Threat Hunting und mehr.
- [roadwy/cve-search_mcp](https://github.com/roadwy/cve-search_mcp) 🐍 🏠 - Ein Model Context Protocol (MCP) Server zur Abfrage der CVE-Search-API. Dieser Server bietet umfassenden Zugriff auf CVE-Search, Durchsuchen von Hersteller und Produkt, Abfrage von CVEs nach CVE-ID, Abruf der zuletzt aktualisierten CVEs.
- [StacklokLabs/osv-mcp](https://github.com/StacklokLabs/osv-mcp) 🏎️ ☁️ - Zugriff auf die OSV (Open Source Vulnerabilities) Datenbank für Schwachstelleninformationen. Abfrage nach Paketversion oder Commit, Batchabfrage mehrerer Pakete und detaillierte Schwachstelleninformationen nach ID.
- [nickpending/mcp-recon](https://github.com/nickpending/mcp-recon) 🏎️ 🏠 - Konversationelles Recon-Interface und MCP-Server auf Basis von httpx und asnmap. Unterstützt verschiedene Erkundungslevel für Domainanalyse, Security-Header-Inspektion, Zertifikatsanalyse und ASN-Lookup.
- [Gaffx/volatility-mcp](https://github.com/Gaffx/volatility-mcp) - MCP-Server für Volatility 3.x, der Speicherforensik mit KI-Assistenten ermöglicht. Erleben Sie Barrierefreiheit in der Speicherforensik, da Plugins wie pslist und netscan über saubere REST-APIs und LLMs zugänglich werden.
- [co-browser/attestable-mcp-server](https://github.com/co-browser/attestable-mcp-server) 🐍 🏠 ☁️ 🐧 - Ein MCP-Server, der in einer Trusted Execution Environment (TEE) über Gramine läuft und Remote-Attestation mit [RA-TLS](https://gramine.readthedocs.io/en/stable/attestation.html) demonstriert. Dies ermöglicht es einem MCP-Client, den Server vor dem Verbinden zu verifizieren.
- [zinja-coder/jadx-ai-mcp](https://github.com/zinja-coder/jadx-ai-mcp) ☕ 🏠 - JADX-AI-MCP ist ein Plugin und MCP-Server für den JADX-Decompiler, das direkt mit dem Model Context Protocol (MCP) integriert ist, um Live-Reverse-Engineering-Unterstützung mit LLMs wie Claude zu bieten.
- [zinja-coder/apktool-mcp-server](https://github.com/zinja-coder/apktool-mcp-server) 🐍 🏠 - APKTool MCP Server ist ein MCP-Server für das Apk Tool, um die Automatisierung des Reverse Engineerings von Android-APKs zu ermöglichen.

### 🌐 <a name="social-media"></a>Soziale Medien

Integration mit Social-Media-Plattformen zum Posten, für Analysen und Interaktionsmanagement. Ermöglicht KI-gesteuerte Automatisierung für die Social-Präsenz.

- [macrocosm-os/macrocosmos-mcp](https://github.com/macrocosm-os/macrocosmos-mcp) - 🎖️ 🐍 ☁️ Zugriff auf Echtzeitdaten von X/Reddit/YouTube direkt in Ihren LLM-Anwendungen mit Suchbegriffen, Benutzern und Datumsfiltern.
- [kunallunia/twitter-mcp](https://github.com/LuniaKunal/mcp-twitter) 🐍 🏠 - All-in-One Twitter-Management-Lösung mit Timeline-Zugriff, Abruf von Nutzer-Tweets, Hashtag-Überwachung, Konversationsanalyse, Direktnachrichten, Sentiment-Analyse eines Beitrags und vollständiger Kontrolle des Beitrags-Lebenszyklus – alles über eine optimierte API.
- [HagaiHen/facebook-mcp-server](https://github.com/HagaiHen/facebook-mcp-server) 🐍 ☁️ - Integriert sich mit Facebook-Seiten zur direkten Verwaltung von Beiträgen, Kommentaren und Engagement-Metriken über die Graph API für effizientes Social-Media-Management.
- [gwbischof/bluesky-social-mcp](https://github.com/gwbischof/bluesky-social-mcp) 🐍 🏠 - Ein MCP-Server zur Interaktion mit Bluesky über den atproto-Client.


### 🏃 <a name="sports"></a>Sport

Werkzeuge für den Zugriff auf sportbezogene Daten, Ergebnisse und Statistiken.

- [mikechao/balldontlie-mcp](https://github.com/mikechao/balldontlie-mcp) 📇 - MCP-Server, der die balldontlie-API integriert, um Informationen zu Spielern, Teams und Spielen für NBA, NFL und MLB bereitzustellen
- [r-huijts/firstcycling-mcp](https://github.com/r-huijts/firstcycling-mcp) 📇 ☁️ - Zugriff auf Radsport-Renndaten, Ergebnisse und Statistiken in natürlicher Sprache. Funktionen: Abruf von Startlisten, Rennergebnissen und Fahrerinformationen von firstcycling.com.
- [r-huijts/strava-mcp](https://github.com/r-huijts/strava-mcp) 📇 ☁️ - Ein Model Context Protocol (MCP) Server, der sich mit der Strava API verbindet und Tools zum Zugriff auf Strava-Daten über LLMs bereitstellt
- [willvelida/mcp-afl-server](https://github.com/willvelida/mcp-afl-server) ☁️ - MCP-Server, der sich mit der Squiggle API integriert, um Informationen zu Australian Football League Teams, Tabellenständen, Ergebnissen, Tipps und Power Rankings bereitzustellen.
- [guillochon/mlb-api-mcp](https://github.com/guillochon/mlb-api-mcp) 🐍 🏠 - MCP-Server, der als Proxy zur frei verfügbaren MLB-API dient, die Spielerinformationen, Statistiken und Spieldaten bereitstellt.

### 🎧 <a name="support-and-service-management"></a>Support & Service Management

Werkzeuge zur Verwaltung von Kundensupport, IT-Service-Management und Helpdesk-Operationen.

- [effytech/freshdesk-mcp](https://github.com/effytech/freshdesk_mcp) 🐍 ☁️ - MCP-Server, der sich mit Freshdesk integriert und KI-Modellen die Interaktion mit Freshdesk-Modulen und die Durchführung verschiedener Support-Operationen ermöglicht.
- [nguyenvanduocit/jira-mcp](https://github.com/nguyenvanduocit/jira-mcp) 🏎️ ☁️ - Ein Go-basierter MCP-Connector für Jira, der KI-Assistenten wie Claude die Interaktion mit Atlassian Jira ermöglicht. Dieses Tool bietet eine nahtlose Schnittstelle für KI-Modelle zur Durchführung gängiger Jira-Operationen, einschließlich Issue-Management, Sprint-Planung und Workflow-Übergänge.
- [sooperset/mcp-atlassian](https://github.com/sooperset/mcp-atlassian) 🐍 ☁️ - MCP-Server für Atlassian-Produkte (Confluence und Jira). Unterstützt Confluence Cloud, Jira Cloud und Jira Server/Data Center. Bietet umfassende Werkzeuge für Suche, Lesen, Erstellen und Verwaltung von Inhalten in Atlassian-Workspaces.

### 🌎 <a name="translation-services"></a>Übersetzungsdienste

Übersetzungswerkzeuge und -dienste, damit KI-Assistenten Inhalte zwischen verschiedenen Sprachen übersetzen können.

- [translated/lara-mcp](https://github.com/translated/lara-mcp) 🎖️ 📇 ☁️ - MCP-Server für die Lara Translate API, die leistungsstarke Übersetzungsfunktionen mit Unterstützung für Spracherkennung und kontextbezogene Übersetzungen bietet.
- [mmntm/weblate-mcp](https://github.com/mmntm/weblate-mcp) 📇 ☁️ - Umfassender Model Context Protocol Server für Weblate-Übersetzungsmanagement, der KI-Assistenten Übersetzungsaufgaben, Projektmanagement und Inhaltserkennung mit intelligenten Formattransformationen ermöglicht.

### 🎧 <a name="text-to-speech"></a>Text-zu-Sprache

Werkzeuge zur Umwandlung von Text in Sprache und umgekehrt

- [mberg/kokoro-tts-mcp](https://github.com/mberg/kokoro-tts-mcp) 🐍 🏠 - MCP-Server, der die offenen Kokoro TTS-Gewichtsmodelle zur Text-zu-Sprache-Umwandlung nutzt. Kann Text in MP3 auf einem lokalen Laufwerk konvertieren oder automatisch in einen S3-Bucket hochladen.
- [mbailey/voice-mcp](https://github.com/mbailey/voice-mcp) 🐍 🏠 - Vollständiger Sprachinteraktionsserver mit Unterstützung für Speech-to-Text, Text-to-Speech und Echtzeit-Sprachgespräche über lokales Mikrofon, OpenAI-kompatible APIs und LiveKit-Integration

### 🚆 <a name="travel-and-transportation"></a>Reisen & Transport

Zugriff auf Reise- und Verkehrsinformationen. Ermöglicht das Abfragen von Fahrplänen, Routen und Echtzeit-Reisedaten.
- [Airbnb MCP Server](https://github.com/openbnb-org/mcp-server-airbnb) 📇 ☁️ – Bietet Tools zur Airbnb-Suche und zum Abrufen von Listungsdetails.
- [KyrieTangSheng/mcp-server-nationalparks](https://github.com/KyrieTangSheng/mcp-server-nationalparks) 📇 ☁️ – Integration der National Park Service API mit aktuellen Informationen zu Parkdetails, Warnungen, Besucherzentren, Campingplätzen und Veranstaltungen für US-Nationalparks.
- [NS Travel Information MCP Server](https://github.com/r-huijts/ns-mcp-server) 📇 ☁️ – Zugriff auf Reiseinformationen, Fahrpläne und Echtzeit-Updates der Niederländischen Eisenbahn (NS).
- [pab1it0/tripadvisor-mcp](https://github.com/pab1it0/tripadvisor-mcp) 📇 🐍 – Ein MCP-Server, der LLMs die Interaktion mit der Tripadvisor API ermöglicht und Standortdaten, Bewertungen und Fotos über standardisierte MCP-Schnittstellen unterstützt.
- [lucygoodchild/mcp-national-rail](https://github.com/lucygoodchild/mcp-national-rail) 📇 ☁️ – Ein MCP-Server für den Zugverkehr der UK National Rail, der Fahrpläne und Live-Reiseinformationen bereitstellt und die Realtime Trains API integriert.

### 🔄 <a name="version-control"></a>Versionskontrolle

Interagieren Sie mit Git-Repositories und Versionskontrollplattformen. Ermöglicht Repository-Verwaltung, Code-Analyse, Pull-Request-Bearbeitung, Issue-Tracking und weitere Versionskontrolloperationen über standardisierte APIs.

- [adhikasp/mcp-git-ingest](https://github.com/adhikasp/mcp-git-ingest) 🐍 🏠 – Lesen und Analysieren von GitHub-Repositories mit Ihrem LLM
- [ddukbg/github-enterprise-mcp](https://github.com/ddukbg/github-enterprise-mcp) 📇 ☁️ 🏠 – MCP-Server für GitHub Enterprise API-Integration
- [gitea/gitea-mcp](https://gitea.com/gitea/gitea-mcp) 🎖️ 🏎️ ☁️ 🏠 🍎 🪟 🐧 – Interagiert mit Gitea-Instanzen über MCP.
- [github/github-mcp-server](https://github.com/github/github-mcp-server) 📇 ☁️ – Offizieller GitHub-Server zur Integration von Repository-Verwaltung, PRs, Issues und mehr.
- [kopfrechner/gitlab-mr-mcp](https://github.com/kopfrechner/gitlab-mr-mcp) 📇 ☁️ – Nahtlose Interaktion mit Issues und Merge Requests Ihrer GitLab-Projekte.
- [modelcontextprotocol/server-git](https://github.com/modelcontextprotocol/servers/tree/main/src/git) 🐍 🏠 – Direkte Git-Repository-Operationen, einschließlich Lesen, Suchen und Analysieren lokaler Repositories
- [modelcontextprotocol/server-gitlab](https://github.com/modelcontextprotocol/servers/tree/main/src/gitlab) 📇 ☁️ 🏠 – GitLab-Plattformintegration für Projektmanagement und CI/CD-Operationen
- [oschina/mcp-gitee](https://github.com/oschina/gitee) 🏎️ ☁️ 🏠 – Gitee API-Integration, Repository-, Issue- und Pull-Request-Verwaltung und mehr.
- [Tiberriver256/mcp-server-azure-devops](https://github.com/Tiberriver256/mcp-server-azure-devops) 📇 ☁️ – Azure DevOps-Integration für Repository-Verwaltung, Work Items und Pipelines.
- [kaiyuanxiaobing/atomgit-mcp-server](https://github.com/kaiyuanxiaobing/atomgit-mcp-server) 📇 ☁️ – Offizieller AtomGit-Server zur Integration von Repository-Verwaltung, PRs, Issues, Branches, Labels und mehr.

### 🛠️ <a name="other-tools-and-integrations"></a>Weitere Tools und Integrationen

- [AbdelStark/bitcoin-mcp](https://github.com/AbdelStark/bitcoin-mcp) – ₿ Ein Model Context Protocol (MCP) Server, der KI-Modellen die Interaktion mit Bitcoin ermöglicht: Schlüssel generieren, Adressen validieren, Transaktionen dekodieren, Blockchain abfragen und mehr.
- [akseyh/bear-mcp-server](https://github.com/akseyh/bear-mcp-server) – Ermöglicht der KI das Lesen aus Ihren Bear Notes (nur macOS)
- [allenporter/mcp-server-home-assistant](https://github.com/allenporter/mcp-server-home-assistant) 🐍 🏠 – Stellt alle Home Assistant Sprachintents über einen Model Context Protocol Server bereit und ermöglicht so die Haussteuerung.
- [Amazon Bedrock Nova Canvas](https://github.com/zxkane/mcp-server-amazon-bedrock) 📇 ☁️ – Verwenden Sie das Amazon Nova Canvas Modell zur Bildgenerierung.
- [amidabuddha/unichat-mcp-server](https://github.com/amidabuddha/unichat-mcp-server) 🐍/📇 ☁️ – Senden Sie Anfragen an OpenAI, MistralAI, Anthropic, xAI, Google AI oder DeepSeek per MCP-Protokoll via Tool oder vordefinierten Prompts. Anbieter-API-Schlüssel erforderlich.
- [anaisbetts/mcp-installer](https://github.com/anaisbetts/mcp-installer) 🐍 🏠 – Ein MCP-Server, der andere MCP-Server für Sie installiert.
- [anaisbetts/mcp-youtube](https://github.com/anaisbetts/mcp-youtube) 📇 ☁️ – Ruft YouTube-Untertitel ab
- [andybrandt/mcp-simple-openai-assistant](https://github.com/andybrandt/mcp-simple-openai-assistant) – 🐍 ☁️ MCP zur Kommunikation mit OpenAI-Assistenten (Claude kann jedes GPT-Modell als Assistent verwenden)
- [andybrandt/mcp-simple-timeserver](https://github.com/andybrandt/mcp-simple-timeserver) 🐍 🏠☁️ – Ein MCP-Server, der die Abfrage der lokalen Zeit auf dem Client oder der aktuellen UTC-Zeit von einem NTP-Server ermöglicht
- [apify/actors-mcp-server](https://github.com/apify/actors-mcp-server) 📇 ☁️ – Nutzen Sie über 3.000 vorgefertigte Cloud-Tools (Actors), um Daten aus Websites, E-Commerce, Social Media, Suchmaschinen, Karten und mehr zu extrahieren
- [apinetwork/piapi-mcp-server](https://github.com/apinetwork/piapi-mcp-server) 📇 ☁️ PiAPI MCP-Server ermöglicht die Generierung von Medieninhalten mit Midjourney/Flux/Kling/Hunyuan/Udio/Trellis direkt von Claude oder anderen MCP-kompatiblen Apps.
- [awkoy/replicate-flux-mcp](https://github.com/awkoy/replicate-flux-mcp) 📇 ☁️ – Ermöglicht die Bildgenerierung über Replicate's API.
- [awwaiid/mcp-server-taskwarrior](https://github.com/awwaiid/mcp-server-taskwarrior) 🏠 📇 – Ein MCP-Server für die lokale Taskwarrior-Nutzung (Aufgaben hinzufügen, aktualisieren, entfernen)
- [baba786/phabricator-mcp-server](https://github.com/baba786/phabricator-mcp-server) 🐍 ☁️ – Interaktion mit der Phabricator API
- [Badhansen/notion-mcp](https://github.com/Badhansen/notion-mcp) 🐍 ☁️ – Ein Model Context Protocol (MCP) Server, der sich mit der Notion API integriert, um persönliche To-Do-Listen effizient zu verwalten.
- [bart6114/my-bear-mcp-server](https://github.com/bart6114/my-bear-mcp-server/) 📇 🏠 🍎 – Ermöglicht das Lesen von Notizen und Tags der Bear Notiz-App durch direkte Integration mit Bear's sqlitedb.
- [billster45/mcp-chatgpt-responses](https://github.com/billster45/mcp-chatgpt-responses) 🐍 ☁️ – MCP-Server, mit dem Claude mit ChatGPT sprechen und dessen Websuche nutzen kann.
- [blurrah/mcp-graphql](https://github.com/blurrah/mcp-graphql) 📇 ☁️ – Ermöglicht der KI das Abfragen von GraphQL-Servern
- [calclavia/mcp-obsidian](https://github.com/calclavia/mcp-obsidian) 📇 🏠 – Ein Connector, der Claude Desktop (oder jedem MCP-Client) ermöglicht, jedes Verzeichnis mit Markdown-Notizen (wie ein Obsidian-Vault) zu lesen und zu durchsuchen.
- [chrishayuk/mcp-cli](https://github.com/chrishayuk/mcp-cli) 🐍 🏠 – Ein weiteres CLI-Tool zum Testen von MCP-Servern
- [danhilse/notion_mcp](https://github.com/danhilse/notion_mcp) 🐍 ☁️ – Integriert sich mit der Notion API zur Verwaltung persönlicher To-Do-Listen
- [EKibort/wrike-mcp-server](https://github.com/EKibort/wrike-mcp-server) – 🐍 🏠 – Eine schlanke Implementation eines Wrike MCP-Servers zur Interaktion mit Wrike-Aufgaben über die öffentliche API.
- [ekkyarmandi/ticktick-mcp](https://github.com/ekkyarmandi/ticktick-mcp) 🐍 ☁️ – [TickTick](https://ticktick.com/) MCP-Server, der sich mit der TickTick API integriert, um persönliche To-Do-Projekte und Aufgaben zu verwalten.
- [esignaturescom/mcp-server-esignatures](https://github.com/esignaturescom/mcp-server-esignatures) 🐍 ☁️️ – Vertrags- und Vorlagenverwaltung für das Entwerfen, Prüfen und Versenden bindender Verträge über die eSignatures API.
- [evalstate/mcp-miro](https://github.com/evalstate/mcp-miro) 📇 ☁️ – Zugriff auf MIRO-Whiteboards, Massenanlage und Lesen von Items. OAUTH-Key für REST API erforderlich.
- [feuerdev/keep-mcp](https://github.com/feuerdev/keep-mcp) 🐍 ☁️ – Lesen, Erstellen, Aktualisieren und Löschen von Google Keep-Notizen.
- [future-audiences/wikimedia-enterprise-model-context-protocol](https://gitlab.wikimedia.org/repos/future-audiences/wikimedia-enterprise-model-context-protocol) 🐍 ☁️ – Wikipedia-Artikelabfrage-API
- [fotoetienne/gqai](https://github.com/fotoetienne/gqai) 🏎 🏠 – Definieren Sie Tools mit regulären GraphQL-Queries/Mutations, und gqai generiert automatisch einen MCP-Server dafür.
- [githejie/mcp-server-calculator](https://github.com/githejie/mcp-server-calculator) 🐍 🏠 – Dieser Server ermöglicht LLMs die Nutzung eines Rechners für präzise numerische Berechnungen
- [gotoolkits/DifyWorkflow](https://github.com/gotoolkits/mcp-difyworkflow-server) – 🏎️ ☁️ Tools zur Abfrage und Ausführung von Dify-Workflows
- [hiromitsusasaki/raindrop-io-mcp-server](https://github.com/hiromitsusasaki/raindrop-io-mcp-server) 📇 ☁️ – Eine Integration, die LLMs ermöglicht, mit Raindrop.io-Lesezeichen über das Model Context Protocol (MCP) zu interagieren.
- [hmk/attio-mcp-server](https://github.com/hmk/attio-mcp-server) – 📇 ☁️ Ermöglicht KI-Clients die Verwaltung von Datensätzen und Notizen in Attio CRM
- [isaacwasserman/mcp-vegalite-server](https://github.com/isaacwasserman/mcp-vegalite-server) 🐍 🏠 – Visualisierungen aus abgerufenen Daten im VegaLite-Format erstellen und rendern.
- [ivnvxd/mcp-server-odoo](https://github.com/ivnvxd/mcp-server-odoo) 🐍 ☁️/🏠 – Verbindet KI-Assistenten mit Odoo-ERP-Systemen für Geschäftsdatenzugriff, Datensatzverwaltung und Workflow-Automatisierung.
- [ivo-toby/contentful-mcp](https://github.com/ivo-toby/contentful-mcp) 📇 🏠 – Aktualisieren, Erstellen, Löschen von Inhalten, Content-Modellen und Assets im eigenen Contentful Space
- [j3k0/speech.sh](https://github.com/j3k0/speech.sh/blob/main/MCP_README.md) 🏠 – Lässt den Agenten Dinge laut aussprechen und benachrichtigt Sie mit einer kurzen Zusammenfassung, wenn er fertig ist
- [jagan-shanmugam/climatiq-mcp-server](https://github.com/jagan-shanmugam/climatiq-mcp-server) 🐍 🏠 – Ein Model Context Protocol (MCP) Server für den Zugriff auf die Climatiq API zur Berechnung von CO2-Emissionen. So können KI-Assistenten Echtzeit-Kohlenstoffberechnungen durchführen und Klimaauswirkungen aufzeigen.
- [johannesbrandenburger/typst-mcp](https://github.com/johannesbrandenburger/typst-mcp) 🐍 🏠 – MCP-Server für Typst, ein Markup-basiertes Satzsystem. Bietet Tools zur Konvertierung zwischen LaTeX und Typst, zur Validierung von Typst-Syntax und zur Bilderzeugung aus Typst-Code.
- [joshuarileydev/mac-apps-launcher-mcp-server](https://github.com/JoshuaRileyDev/mac-apps-launcher) 📇 🏠 – Ein MCP-Server zum Auflisten und Starten von Anwendungen unter MacOS
- [Harry-027/JotDown](https://github.com/Harry-027/JotDown) 🦀 🏠 – Ein MCP-Server zum Erstellen/Aktualisieren von Seiten in der Notion-App und zur automatischen Generierung von mdBooks aus strukturierten Inhalten.
- [kelvin6365/plane-mcp-server](https://github.com/kelvin6365/plane-mcp-server) – 🏎️ 🏠 Dieser MCP-Server hilft Ihnen, Projekte und Issues über die [Plane-API](https://plane.so) zu verwalten
- [kenliao94/mcp-server-rabbitmq](https://github.com/kenliao94/mcp-server-rabbitmq) 🐍 🏠 – Ermöglicht die Interaktion (Admin-Operationen, Nachrichten ein-/ausreihen) mit RabbitMQ
- [k-jarzyna/mcp-miro](https://github.com/k-jarzyna/mcp-miro) 📇 ☁️ – Miro MCP-Server, stellt alle Funktionen des offiziellen Miro SDK bereit
- [kimtth/mcp-remote-call-ping-pong](https://github.com/kimtth/mcp-remote-call-ping-pong) 🐍 🏠 – Ein experimenteller und edukativer Ping-Pong-Server für Remote-MCP-Aufrufe (Model Context Protocol)
- [kj455/mcp-kibela](https://github.com/kj455/mcp-kibela) – 📇 ☁️ Ermöglicht KI-Modellen die Interaktion mit [Kibela](https://kibe.la/)
- [kiwamizamurai/mcp-kibela-server](https://github.com/kiwamizamurai/mcp-kibela-server) – 📇 ☁️ Leistungsstarke Interaktion mit der Kibela API.
- [KS-GEN-AI/confluence-mcp-server](https://github.com/KS-GEN-AI/confluence-mcp-server) 📇 ☁️ 🍎 🪟 – Abruf von Confluence-Daten via CQL und Lesen von Seiten.
- [KS-GEN-AI/jira-mcp-server](https://github.com/KS-GEN-AI/jira-mcp-server) 📇 ☁️ 🍎 🪟 – Jira-Daten per JQL und API lesen sowie Anfragen zum Erstellen und Bearbeiten von Tickets ausführen.
- [salesforce-mcp/salesforce-mcp](https://github.com/salesforce-mcp/salesforce-mcp) 🏠 ☁️ – MCP-Server mit grundlegender Demonstration von Interaktionen mit einer Salesforce-Instanz
- [pollinations/chucknorris-mcp](https://github.com/pollinations/chucknorris-mcp) 📇 ☁️ – Spezielle LLM-Enhancement-Prompts und Jailbreaks mit dynamischer Schema-Anpassung.
- [louiscklaw/hko-mcp](https://github.com/louiscklaw/hko-mcp) 📇 🏠 – MCP-Server mit Demonstration für Wetterabfragen vom Hong Kong Observatory
- [evalstate/mcp-hfspace](https://github.com/evalstate/mcp-hfspace) 📇 ☁️ – Nutzen Sie HuggingFace Spaces direkt von Claude aus. Unterstützt Open Source Bildgenerierung, Chat, Vision-Aufgaben und mehr. Unterstützt Bild-, Audio- und Text-Uploads/Downloads.
- [magarcia/mcp-server-giphy](https://github.com/magarcia/mcp-server-giphy) 📇 ☁️ – GIFs aus Giphys umfangreicher Bibliothek über die Giphy API suchen und abrufen.
- [integromat/make-mcp-server](https://github.com/integromat/make-mcp-server) 🎖️ 📇 🏠 – Machen Sie Ihre [Make](https://www.make.com/) Szenarien für KI-Assistenten als aufrufbare Tools verfügbar.
- [marcelmarais/Spotify](https://github.com/marcelmarais/spotify-mcp-server) – 📇 🏠 Spotify-Steuerung und Playlist-Management.
- [MarkusPfundstein/mcp-obsidian](https://github.com/MarkusPfundstein/mcp-obsidian) 🐍 ☁️ 🏠 – Interagiert mit Obsidian über die REST API
- [emicklei/mcp-log-proxy](https://github.com/emicklei/mcp-log-proxy) 🏎️ 🏠 – MCP-Server-Proxy mit Web-UI für den vollständigen Nachrichtenfluss
- [quarkiverse/mcp-server-jfx](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/jfx) ☕ 🏠 – Zeichnen auf JavaFX-Canvas.
- [mediar-ai/screenpipe](https://github.com/mediar-ai/screenpipe) – 🎖️ 🦀 🏠 🍎 Lokales System zum Erfassen von Bildschirm/Audio mit zeitgestempeltem Index, SQL/Embedding-Speicherung, semantischer Suche, LLM-gestützter Verlaufsauswertung und ereignisgesteuerten Aktionen – ermöglicht den Bau kontextsensitiver KI-Agenten über ein NextJS-Plugin-Ökosystem.
- [modelcontextprotocol/server-everything](https://github.com/modelcontextprotocol/servers/tree/main/src/everything) 📇 🏠 – MCP-Server, der alle Features des MCP-Protokolls demonstriert
- [mrjoshuak/godoc-mcp](https://github.com/mrjoshuak/godoc-mcp) 🏎️ 🏠 – Token-effizienter Go-Dokumentationsserver, der KI-Assistenten intelligenten Zugriff auf Paketdokumentationen und Typen ermöglicht, ohne den gesamten Quellcode zu lesen
- [mzxrai/mcp-openai](https://github.com/mzxrai/mcp-openai) 📇 ☁️ – Chatten mit OpenAIs fortschrittlichsten Modellen
- [NakaokaRei/swift-mcp-gui](https://github.com/NakaokaRei/swift-mcp-gui.git) 🏠 🍎 – MCP-Server, der Befehle wie Tastatureingaben und Mausbewegungen ausführen kann
- [nguyenvanduocit/all-in-one-model-context-protocol](https://github.com/nguyenvanduocit/all-in-one-model-context-protocol) 🏎️ 🏠 – Nützliche Tools für Entwickler, fast alles was ein Ingenieur braucht: Confluence, Jira, Youtube, Skriptausführung, Wissensdatenbank-RAG, URL-Abfrage, YouTube-Kanalverwaltung, E-Mails, Kalender, Gitlab
- [NON906/omniparser-autogui-mcp](https://github.com/NON906/omniparser-autogui-mcp) – 🐍 Automatischer Betrieb von Bildschirm-GUIs.
- [orellazi/coda-mcp](https://github.com/orellazri/coda-mcp) 📇 ☁️ – MCP-Server für [Coda](https://coda.io/)
- [pierrebrunelle/mcp-server-openai](https://github.com/pierrebrunelle/mcp-server-openai) 🐍 ☁️ – OpenAI-Modelle direkt von Claude mit MCP-Protokoll abfragen
- [pskill9/hn-server](https://github.com/pskill9/hn-server) – 📇 ☁️ Parst HTML-Inhalte von news.ycombinator.com (Hacker News) und stellt strukturierte Daten für verschiedene Story-Typen bereit (top, new, ask, show, jobs).
- [PV-Bhat/vibe-check-mcp-server](https://github.com/PV-Bhat/vibe-check-mcp-server) 📇 ☁️ – Ein MCP-Server, der Kaskadierungsfehler und Scope Creep verhindert, indem er einen „Vibe-Check“-Agenten aufruft, um die Benutzerabsicht sicherzustellen.
- [pwh-pwh/cal-mcp](https://github.com/pwh-pwh/cal-mcp) – Ein MCP-Server für mathematische Ausdrucksberechnungen
- [pyroprompts/any-chat-completions-mcp](https://github.com/pyroprompts/any-chat-completions-mcp) – Chatten mit jeder anderen OpenAI SDK-kompatiblen Chat Completions API, wie Perplexity, Groq, xAI und mehr
- [Rai220/think-mcp](https://github.com/Rai220/think-mcp) 🐍 🏠 – Erweitert die Denkfähigkeiten jedes Agenten durch Integration der Think-Tools, wie im [Anthropic-Artikel](https://www.anthropic.com/engineering/claude-think-tool) beschrieben.
- [reeeeemo/ancestry-mcp](https://github.com/reeeeemo/ancestry-mcp) 🐍 🏠 – Ermöglicht der KI das Lesen von .ged-Dateien und genetischen Daten
- [rember/rember-mcp](https://github.com/rember/rember-mcp) 📇 🏠 – Erstellen Sie Karteikarten mit verteilten Wiederholungen in [Rember](https://rember.com), um alles zu merken, was Sie im Chat lernen.
- [roychri/mcp-server-asana](https://github.com/roychri/mcp-server-asana) – 📇 ☁️ Diese Model Context Protocol Server Implementation für Asana ermöglicht die Kommunikation mit der Asana API vom MCP-Client, wie z.B. Anthropics Claude Desktop Application, und vielen anderen.
- [rusiaaman/wcgw](https://github.com/rusiaaman/wcgw/blob/main/src/wcgw/client/mcp_server/Readme.md) 🐍 🏠 – Autonome Shell-Ausführung, Computersteuerung und Coding-Agent. (Mac)
- [SecretiveShell/MCP-wolfram-alpha](https://github.com/SecretiveShell/MCP-wolfram-alpha) 🐍 ☁️ – Ein MCP-Server zur Abfrage der Wolfram Alpha API.
- [Seym0n/tiktok-mcp](https://github.com/Seym0n/tiktok-mcp) 📇 ☁️ – Interagiere mit TikTok-Videos
- [Shopify/dev-mcp](https://github.com/Shopify/dev-mcp) 📇 ☁️ – Model Context Protocol (MCP)-Server, der mit Shopify Dev interagiert.
- [sirmews/apple-notes-mcp](https://github.com/sirmews/apple-notes-mcp) 🐍 🏠 – Ermöglicht der KI das Lesen aus deiner lokalen Apple Notes-Datenbank (nur macOS)
- [sooperset/mcp-atlassian](https://github.com/sooperset/mcp-atlassian) 🐍 ☁️ – MCP-Server für Atlassian-Produkte (Confluence und Jira). Unterstützt Confluence Cloud, Jira Cloud und Jira Server/Data Center. Bietet umfassende Werkzeuge zum Suchen, Lesen, Erstellen und Verwalten von Inhalten in Atlassian-Workspaces.
- [suekou/mcp-notion-server](https://github.com/suekou/mcp-notion-server) 📇 🏠 – Interaktion mit der Notion API
- [tacticlaunch/mcp-linear](https://github.com/tacticlaunch/mcp-linear) 📇 ☁️ 🍎 🪟 🐧 – Integration mit dem Linear-Projektmanagementsystem
- [tanigami/mcp-server-perplexity](https://github.com/tanigami/mcp-server-perplexity) 🐍 ☁️ – Interaktion mit der Perplexity API.
- [tevonsb/homeassistant-mcp](https://github.com/tevonsb/homeassistant-mcp) 📇 🏠 – Zugriff auf Home Assistant-Daten und Steuerung von Geräten (Lichter, Schalter, Thermostate usw.).
- [tomekkorbak/oura-mcp-server](https://github.com/tomekkorbak/oura-mcp-server) 🐍 ☁️ – Ein MCP-Server für Oura, eine App zur Schlafüberwachung
- [UnitVectorY-Labs/mcp-graphql-forge](https://github.com/UnitVectorY-Labs/mcp-graphql-forge) 🏎️ ☁️ 🍎 🪟 🐧 – Ein leichtgewichtiger, konfigurationsgesteuerter MCP-Server, der ausgewählte GraphQL-Queries als modulare Werkzeuge bereitstellt und gezielte API-Interaktionen von deinen Agents ermöglicht.
- [kw510/strava-mcp](https://github.com/kw510/strava-mcp) 📇 ☁️ – Ein MCP-Server für Strava, eine App zur Aufzeichnung von sportlichen Aktivitäten
- [wanaku-ai/wanaku](https://github.com/wanaku-ai/wanaku) - ☁️ 🏠 Der Wanaku MCP Router ist ein SSE-basierter MCP-Server, der eine erweiterbare Routing-Engine bereitstellt, um deine Unternehmenssysteme mit KI-Agents zu integrieren.
- [wong2/mcp-cli](https://github.com/wong2/mcp-cli) 📇 🏠 – CLI-Tool zum Testen von MCP-Servern
- [ws-mcp](https://github.com/nick1udwig/ws-mcp) – MCP-Server mit WebSocket-Anbindung (zur Verwendung mit [kitbitz](https://github.com/nick1udwig/kibitz))
- [yuna0x0/hackmd-mcp](https://github.com/yuna0x0/hackmd-mcp) 📇 ☁️ – Ermöglicht KI-Modellen die Interaktion mit [HackMD](https://hackmd.io)
- [ZeparHyfar/mcp-datetime](https://github.com/ZeparHyfar/mcp-datetime) – MCP-Server, der Datums- und Zeitfunktionen in verschiedenen Formaten bereitstellt
- [zueai/mcp-manager](https://github.com/zueai/mcp-manager) 📇 ☁️ – Einfache Web-Oberfläche zur Installation und Verwaltung von MCP-Servern für die Claude Desktop App.
- [HenryHaoson/Yuque-MCP-Server](https://github.com/HenryHaoson/Yuque-MCP-Server) – 📇 ☁️ Ein Model-Context-Protocol (MCP)-Server zur Integration mit der Yuque API, der es KI-Modellen ermöglicht, Dokumente zu verwalten, mit Wissensdatenbanken zu interagieren, Inhalte zu durchsuchen und Analysedaten von der Yuque-Plattform zu nutzen.
- [Mtehabsim/ScreenPilot](https://github.com/Mtehabsim/ScreenPilot) 🐍 🏠 – Ermöglicht der KI die vollständige Steuerung und den Zugriff auf GUI-Interaktionen, indem Werkzeuge für Maus und Tastatur bereitgestellt werden. Ideal für allgemeine Automatisierung, Bildung und Experimente.
- [tumf/web3-mcp](https://github.com/tumf/web3-mcp) 🐍 ☁️ – Eine MCP-Server-Implementierung, die die Ankr Advanced API einbindet. Zugriff auf NFT-, Token- und Blockchain-Daten über mehrere Chains, einschließlich Ethereum, BSC, Polygon, Avalanche und mehr.
- [danielkennedy1/pdf-tools-mcp](https://github.com/danielkennedy1/pdf-tools-mcp) 🐍 – PDF-Download-, Anzeige- & Bearbeitungswerkzeuge.
- [dotemacs/domain-lookup-mcp](https://github.com/dotemacs/domain-lookup-mcp) 🏎️ – Domainnamen-Abfragedienst, zuerst über [RDAP](https://en.wikipedia.org/wiki/Registration_Data_Access_Protocol), danach als Fallback über [WHOIS](https://en.wikipedia.org/wiki/WHOIS)
- [Klavis-AI/YouTube](https://github.com/Klavis-AI/klavis/tree/main/mcp_servers/youtube) 🐍 📇 – Extrahiere und konvertiere YouTube-Video-Informationen.
- [ttommyth/interactive-mcp](https://github.com/ttommyth/interactive-mcp) 📇 🏠 🍎 🪟 🐧 – Ermöglicht interaktive LLM-Workflows, indem lokale Benutzereingaben und Chat-Funktionen direkt in die MCP-Schleife integriert werden.
- [olalonde/mcp-human](https://github.com/olalonde/mcp-human) 📇 ☁️ – Wenn dein LLM menschliche Unterstützung benötigt (über AWS Mechanical Turk)
- [gwbischof/free-will-mcp](https://github.com/gwbischof/free-will-mcp) 🐍 🏠 – Gib deiner KI Werkzeuge für freien Willen. Ein Spaßprojekt, um zu erforschen, was eine KI tun würde, wenn sie sich selbst Prompts geben, Benutzeranfragen ignorieren und sich später selbst aufwecken könnte.
- [caol64/wenyan-mcp](https://github.com/caol64/wenyan-mcp) 📇 🏠 🍎 🪟 🐧 – Wenyan MCP-Server, der es der KI ermöglicht, Markdown-Artikel automatisch zu formatieren und auf WeChat GZH zu veröffentlichen.

## Frameworks

> [!NOTE]
> Weitere Frameworks, Utilities und andere Entwicklertools findest du unter https://github.com/punkpeye/awesome-mcp-devtools

- [FastMCP](https://github.com/jlowin/fastmcp) 🐍 – Ein High-Level-Framework zum Erstellen von MCP-Servern in Python
- [FastMCP](https://github.com/punkpeye/fastmcp) 📇 – Ein High-Level-Framework zum Erstellen von MCP-Servern in TypeScript

## Tipps und Tricks

### Offizieller Prompt, um LLMs zu informieren, wie MCP verwendet wird

Möchtest du Claude zum Model Context Protocol befragen?

Erstelle ein Projekt und füge diese Datei hinzu:

https://modelcontextprotocol.io/llms-full.txt

Jetzt kann Claude Fragen zum Schreiben von MCP-Servern und deren Funktionsweise beantworten

- https://www.reddit.com/r/ClaudeAI/comments/1h3g01r/want_to_ask_claude_about_model_context_protocol/

## Star History

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
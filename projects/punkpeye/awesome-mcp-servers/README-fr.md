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

Une liste soigneusement sélectionnée des serveurs Model Context Protocol (MCP) exceptionnels.

* [Qu'est-ce que MCP ?](#quest-ce-que-mcp)
* [Clients](#clients)
* [Tutoriels](#tutoriels)
* [Communauté](#communaute)
* [Légende](#legende)
* [Implémentations de Serveurs](#implementations-de-serveurs)
* [Frameworks](#frameworks)
* [Astuces & Conseils](#astuces-et-conseils)

## Qu'est-ce que MCP ?

[MCP](https://modelcontextprotocol.io/) est un protocole ouvert qui permet aux modèles d’IA d’interagir de manière sécurisée avec des ressources locales et distantes via des implémentations de serveurs standardisées. Cette liste se concentre sur les serveurs MCP prêts pour la production ainsi que sur les expérimentaux, qui étendent les capacités de l’IA via l’accès aux fichiers, aux bases de données, aux intégrations API et à d’autres services contextuels.

## Clients

Consultez [awesome-mcp-clients](https://github.com/punkpeye/awesome-mcp-clients/) et [glama.ai/mcp/clients](https://glama.ai/mcp/clients).

> [!ASTUCE]
> [Glama Chat](https://glama.ai/chat) est un client IA multimodal avec prise en charge MCP et [passerelle IA](https://glama.ai/gateway).

## Tutoriels

* [Démarrage rapide Model Context Protocol (MCP)](https://glama.ai/blog/2024-11-25-model-context-protocol-quickstart)
* [Configurer l’application de bureau Claude pour utiliser une base de données SQLite](https://youtu.be/wxCCzo9dGj0)

## Communauté

* [r/mcp Reddit](https://www.reddit.com/r/mcp)
* [Serveur Discord](https://glama.ai/mcp/discord)

## Légende

* 🎖️ – implémentation officielle
* langage de programmation
  * 🐍 – codebase Python
  * 📇 – codebase TypeScript (ou JavaScript)
  * 🏎️ – codebase Go
  * 🦀 – codebase Rust
  * #️⃣ - codebase C#
  * ☕ - codebase Java
  * 🌊 – codebase C/C++
* périmètre
  * ☁️ - Service Cloud
  * 🏠 - Service Local
  * 📟 - Systèmes Embarqués
* système d’exploitation
  * 🍎 – Pour macOS
  * 🪟 – Pour Windows
  * 🐧 - Pour Linux

> [!NOTE]
> Vous êtes confus entre Local 🏠 et Cloud ☁️ ?
> * Utilisez local lorsque le serveur MCP communique avec un logiciel installé localement, par exemple pour contrôler le navigateur Chrome.
> * Utilisez réseau lorsque le serveur MCP communique avec des APIs distantes, par exemple une API météo.

## Implémentations de Serveurs

> [!NOTE]
> Nous disposons désormais d’un [répertoire web](https://glama.ai/mcp/servers) synchronisé avec ce dépôt.

* 🔗 - [Agrégateurs](#agregateurs)
* 🎨 - [Art & Culture](#art-et-culture)
* 📂 - [Automatisation de Navigateur](#automatisation-de-navigateur)
* ☁️ - [Plateformes Cloud](#plateformes-cloud)
* 👨‍💻 - [Exécution de Code](#execution-de-code)
* 🤖 - [Agents de Codage](#agents-de-codage)
* 🖥️ - [Ligne de Commande](#ligne-de-commande)
* 💬 - [Communication](#communication)
* 👤 - [Plateformes de Données Clients](#plateformes-de-donnees-clients)
* 🗄️ - [Bases de Données](#bases-de-donnees)
* 📊 - [Plateformes de Données](#plateformes-de-donnees)
* 🚚 - [Livraison](#livraison)
* 🛠️ - [Outils Développeur](#outils-developpeur)
* 🧮 - [Outils Data Science](#outils-data-science)
* 📟 - [Système Embarqué](#systeme-embarque)
* 📂 - [Systèmes de Fichiers](#systemes-de-fichiers)
* 💰 - [Finance & Fintech](#finance--fintech)
* 🎮 - [Jeux Vidéo](#jeux-video)
* 🧠 - [Connaissance & Mémoire](#connaissance--memoire)
* 🗺️ - [Services de Localisation](#services-de-localisation)
* 🎯 - [Marketing](#marketing)
* 📊 - [Surveillance](#surveillance)
* 🎥 - [Traitement Multimédia](#traitement-multimedia)
* 🔎 - [Recherche & Extraction de Données](#recherche)
* 🔒 - [Sécurité](#securite)
* 🌐 - [Réseaux Sociaux](#reseaux-sociaux)
* 🏃 - [Sports](#sports)
* 🎧 - [Gestion du support et des services](#support-and-service-management)
* 🌎 - [Services de traduction](#translation-services)
* 🎧 - [Synthèse vocale](#text-to-speech)
* 🚆 - [Voyage & Transport](#travel-and-transportation)
* 🔄 - [Gestion de versions](#version-control)
* 🛠️ - [Autres outils et intégrations](#other-tools-and-integrations)


### 🔗 <a name="aggregators"></a>Agrégateurs

Serveurs permettant d'accéder à de nombreuses applications et outils via un seul serveur MCP.

- [julien040/anyquery](https://github.com/julien040/anyquery) 🏎️ 🏠 ☁️ - Interrogez plus de 40 applications avec un seul binaire en utilisant SQL. Peut également se connecter à votre base de données compatible PostgreSQL, MySQL ou SQLite. Local-first et privé par conception.
- [metatool-ai/metatool-app](https://github.com/metatool-ai/metatool-app) 📇 ☁️ 🏠 🍎 🪟 🐧 - MetaMCP est le serveur middleware MCP unifié qui gère vos connexions MCP avec une interface graphique.
- [mindsdb/mindsdb](https://github.com/mindsdb/mindsdb) - Connectez et unifiez les données sur différentes plateformes et bases de données avec [MindsDB comme serveur MCP unique](https://docs.mindsdb.com/mcp/overview).
- [glenngillen/mcpmcp-server](https://github.com/glenngillen/mcpmcp-server) ☁️ 📇 🍎 🪟 🐧 - Une liste de serveurs MCP pour demander à votre client quels serveurs utiliser pour améliorer votre flux de travail quotidien.
- [wegotdocs/open-mcp](https://github.com/wegotdocs/open-mcp) 📇 🏠 🍎 🪟 🐧 - Transformez une API web en serveur MCP en 10 secondes et ajoutez-le au registre open source : https://open-mcp.org
- [PipedreamHQ/pipedream](https://github.com/PipedreamHQ/pipedream/tree/master/modelcontextprotocol) ☁️ 🏠 - Connectez-vous à 2 500 APIs avec plus de 8 000 outils préconstruits, et gérez les serveurs pour vos utilisateurs dans votre propre application.
- [VeriTeknik/pluggedin-mcp-proxy](https://github.com/VeriTeknik/pluggedin-mcp-proxy)  📇 🏠 - Un serveur proxy complet qui combine plusieurs serveurs MCP dans une seule interface avec de vastes fonctionnalités de visibilité. Il propose la découverte et la gestion d’outils, prompts, ressources et modèles à travers les serveurs, ainsi qu’un espace de test pour le débogage lors du développement de serveurs MCP.
- [tigranbs/mcgravity](https://github.com/tigranbs/mcgravity) 📇 🏠 - Un outil proxy pour composer plusieurs serveurs MCP en un seul point de terminaison unifié. Faites évoluer vos outils IA en équilibrant la charge des requêtes sur plusieurs serveurs MCP, à la manière de Nginx pour les serveurs web.
- [MetaMCP](https://github.com/metatool-ai/metatool-app) 📇 ☁️ 🏠 🍎 🪟 🐧 - MetaMCP est le serveur middleware MCP unifié qui gère vos connexions MCP avec une interface graphique.
- [WayStation-ai/mcp](https://github.com/waystation-ai/mcp) ☁️ 🍎 🪟 - Connectez de manière fluide et sécurisée Claude Desktop et d’autres hôtes MCP à vos applications favorites (Notion, Slack, Monday, Airtable, etc.). Moins de 90 secondes d’installation.
- [sxhxliang/mcp-access-point](https://github.com/sxhxliang/mcp-access-point) 📇 ☁️ 🏠 🍎 🪟 🐧 - Transformez un service web en serveur MCP en un clic, sans modification du code.
- [hamflx/imagen3-mcp](https://github.com/hamflx/imagen3-mcp) 📇 🏠 🪟 🍎 🐧 - Un outil puissant de génération d’images utilisant l’API Imagen 3.0 de Google via MCP. Générez des images de haute qualité à partir de prompts texte avec des contrôles avancés photographiques, artistiques et photoréalistes.
- [SureScaleAI/openai-gpt-image-mcp](https://github.com/SureScaleAI/openai-gpt-image-mcp) 📇 ☁️ - Serveur MCP pour la génération/édition d’images OpenAI GPT.

### 🎨 <a name="art-and-culture"></a>Art & Culture

Accédez et explorez des collections d’art, du patrimoine culturel et des bases de données de musées. Permet aux modèles d’IA de rechercher et d’analyser des contenus artistiques et culturels.

- [abhiemj/manim-mcp-server](https://github.com/abhiemj/manim-mcp-server) 🐍 🏠 🪟 🐧 - Un serveur MCP local qui génère des animations avec Manim.
- [burningion/video-editing-mcp](https://github.com/burningion/video-editing-mcp) 🐍 - Ajouter, analyser, rechercher et générer des montages vidéo à partir de votre collection Video Jungle
- [cswkim/discogs-mcp-server](https://github.com/cswkim/discogs-mcp-server) 📇 ☁️ - Serveur MCP pour interagir avec l’API Discogs
- [djalal/quran-mcp-server](https://github.com/djalal/quran-mcp-server) 📇 ☁️ Serveur MCP pour interagir avec le corpus de Quran.com via l’API REST officielle v4.
- [mikechao/metmuseum-mcp](https://github.com/mikechao/metmuseum-mcp) 📇 ☁️ - Intégration de l’API de la collection du Metropolitan Museum of Art pour rechercher et afficher des œuvres d’art de la collection.
- [r-huijts/rijksmuseum-mcp](https://github.com/r-huijts/rijksmuseum-mcp) 📇 ☁️ - Intégration de l’API du Rijksmuseum pour la recherche d’œuvres, de détails et de collections
- [r-huijts/oorlogsbronnen-mcp](https://github.com/r-huijts/oorlogsbronnen-mcp) 📇 ☁️ - Intégration de l’API Oorlogsbronnen (Sources de guerre) pour accéder à des archives, photographies et documents historiques de la Seconde Guerre mondiale aux Pays-Bas (1940-1945)
- [samuelgursky/davinci-resolve-mcp](https://github.com/samuelgursky/davinci-resolve-mcp) 🐍 - Intégration serveur MCP pour DaVinci Resolve offrant des outils puissants pour le montage vidéo, l’étalonnage, la gestion des médias et le contrôle des projets
- [yuna0x0/anilist-mcp](https://github.com/yuna0x0/anilist-mcp) 📇 ☁️ - Un serveur MCP intégrant l’API AniList pour les informations sur l’anime et le manga
- [diivi/aseprite-mcp](https://github.com/diivi/aseprite-mcp) 🐍 🏠 - Serveur MCP utilisant l’API Aseprite pour créer du pixel art
- [omni-mcp/isaac-sim-mcp](https://github.com/omni-mcp/isaac-sim-mcp) 📇 ☁️ - Un serveur MCP et une extension permettant le contrôle en langage naturel de NVIDIA Isaac Sim, Lab, OpenUSD, etc.
- [8enSmith/mcp-open-library](https://github.com/8enSmith/mcp-open-library) 📇 ☁️ - Serveur MCP pour l’API Open Library permettant aux assistants IA de rechercher des informations sur des livres. 
- [PatrickPalmer/MayaMCP](https://github.com/PatrickPalmer/MayaMCP) 🐍 🏠 - Serveur MCP pour Autodesk Maya
- [cantian-ai/bazi-mcp](https://github.com/cantian-ai/bazi-mcp) 📇 🏠 ☁️ 🍎 🪟 - Fournit une analyse et un calcul complet et précis du Bazi (astrologie chinoise)


### 📂 <a name="browser-automation"></a>Automatisation de navigateur

Accès au contenu web et capacités d’automatisation. Permet la recherche, l’extraction et le traitement de contenu web sous des formats adaptés à l’IA.

- [xspadex/bilibili-mcp](https://github.com/xspadex/bilibili-mcp.git) 📇 🏠 - Outil basé sur FastMCP qui récupère les vidéos tendances de Bilibili et les expose via une interface MCP standard.
- [34892002/bilibili-mcp-js](https://github.com/34892002/bilibili-mcp-js) 📇 🏠 - Serveur MCP prenant en charge la recherche de contenu Bilibili. Fournit des exemples d’intégration LangChain et des scripts de test.
- [aircodelabs/grasp](https://github.com/aircodelabs/grasp) 📇 🏠 - Navigateur auto-hébergé utilisant un agent avec support MCP et A2A intégré.
- [automatalabs/mcp-server-playwright](https://github.com/Automata-Labs-team/MCP-Server-Playwright) 🐍 - Un serveur MCP pour l’automatisation de navigateur avec Playwright
- [blackwhite084/playwright-plus-python-mcp](https://github.com/blackwhite084/playwright-plus-python-mcp) 🐍 - Serveur MCP python utilisant Playwright pour l’automatisation de navigateur, particulièrement adapté aux LLM
- [browserbase/mcp-server-browserbase](https://github.com/browserbase/mcp-server-browserbase) 🎖️ 📇 - Automatisez les interactions navigateur dans le cloud (navigation web, extraction de données, remplissage de formulaires, etc.)
- [browsermcp/mcp](https://github.com/browsermcp/mcp) 📇 🏠 - Automatisez votre navigateur Chrome local
- [co-browser/browser-use-mcp-server](https://github.com/co-browser/browser-use-mcp-server) 🐍 - browser-use empaqueté comme serveur MCP avec transport SSE. Inclut un dockerfile pour faire tourner chromium dans docker + un serveur vnc.
- [executeautomation/playwright-mcp-server](https://github.com/executeautomation/mcp-playwright) 📇 - Serveur MCP utilisant Playwright pour l’automatisation navigateur et le web scraping
- [eyalzh/browser-control-mcp](https://github.com/eyalzh/browser-control-mcp) 📇 🏠 - Serveur MCP couplé à une extension navigateur permettant aux clients LLM de contrôler le navigateur de l’utilisateur (Firefox).
- [fradser/mcp-server-apple-reminders](https://github.com/FradSer/mcp-server-apple-reminders) 📇 🏠 🍎 - Serveur MCP pour interagir avec Apple Reminders sur macOS
- [getrupt/ashra-mcp](https://github.com/getrupt/ashra-mcp) 🐍 🏠 - Extraire des données structurées de n’importe quel site web. Il suffit d’un prompt pour obtenir du JSON.
- [kimtaeyoon83/mcp-server-youtube-transcript](https://github.com/kimtaeyoon83/mcp-server-youtube-transcript) 📇 ☁️ - Récupère les sous-titres et transcriptions YouTube pour analyse IA
- [kimtth/mcp-aoai-web-browsing](https://github.com/kimtth/mcp-aoai-web-browsing) 🐍 🏠 - Implémentation serveur/client MCP `minimale` utilisant Azure OpenAI et Playwright.
- [microsoft/playwright-mcp](https://github.com/microsoft/playwright-mcp) - Serveur MCP Playwright officiel Microsoft, permettant aux LLM d’interagir avec des pages web via des snapshots d’accessibilité structurés
- [modelcontextprotocol/server-puppeteer](https://github.com/modelcontextprotocol/servers/tree/main/src/puppeteer) 📇 🏠 - Automatisation de navigateur pour le scraping et l’interaction web
- [ndthanhdev/mcp-browser-kit](https://github.com/ndthanhdev/mcp-browser-kit) 📇 🏠 - Serveur MCP pour l’interaction avec les navigateurs compatibles manifest v2.
- [pskill9/web-search](https://github.com/pskill9/web-search) 📇 🏠 - Serveur MCP permettant la recherche web gratuite avec les résultats Google, sans besoin de clés API.
- [recursechat/mcp-server-apple-shortcuts](https://github.com/recursechat/mcp-server-apple-shortcuts) 📇 🏠 🍎 - Serveur MCP pour l’intégration avec Raccourcis Apple

### ☁️ <a name="cloud-platforms"></a>Plateformes cloud

Intégration de services de plateformes cloud. Permet la gestion et l’interaction avec l’infrastructure et les services cloud.

- [awslabs/mcp](https://github.com/awslabs/mcp) 🎖️ ☁️ - Serveurs MCP AWS pour une intégration transparente avec les services et ressources AWS.
- [qiniu/qiniu-mcp-server](https://github.com/qiniu/qiniu-mcp-server) 🐍 ☁️ - Un MCP basé sur les produits Qiniu Cloud, permettant d’accéder au stockage cloud Qiniu, aux services de traitement médias, etc.
- [alexbakers/mcp-ipfs](https://github.com/alexbakers/mcp-ipfs) 📇 ☁️ - Téléversement et manipulation de stockage IPFS
- [reza-gholizade/k8s-mcp-server](https://github.com/reza-gholizade/k8s-mcp-server) 🏎️ ☁️/🏠 - Un serveur Kubernetes Model Context Protocol (MCP) fournissant des outils pour interagir avec les clusters Kubernetes via une interface standardisée, incluant la découverte des ressources API, la gestion des ressources, les logs de pods, métriques et événements.
- [VmLia/books-mcp-server](https://github.com/VmLia/books-mcp-server) 📇 ☁️ - Serveur MCP pour la recherche de livres, applicable dans des clients MCP courants comme Cherry Studio.
- [alexei-led/aws-mcp-server](https://github.com/alexei-led/aws-mcp-server) 🐍 ☁️ - Serveur léger mais puissant permettant aux assistants IA d’exécuter des commandes AWS CLI, d’utiliser les pipes Unix et d’appliquer des prompts pour des tâches AWS courantes dans un environnement Docker sécurisé, avec support multi-architecture.
- [alexei-led/k8s-mcp-server](https://github.com/alexei-led/k8s-mcp-server) 🐍 - Serveur léger mais robuste permettant aux assistants IA d’exécuter en toute sécurité des commandes Kubernetes CLI (`kubectl`, `helm`, `istioctl` et `argocd`) via des pipes Unix dans un Docker sécurisé avec support multi-architecture.
- [aliyun/alibaba-cloud-ops-mcp-server](https://github.com/aliyun/alibaba-cloud-ops-mcp-server) 🎖️ 🐍 ☁️ - Serveur MCP permettant aux assistants IA de gérer des ressources Alibaba Cloud, supportant ECS, Cloud Monitor, OOS et de nombreux produits cloud courants.
- [bright8192/esxi-mcp-server](https://github.com/bright8192/esxi-mcp-server) 🐍 ☁️ - Serveur de gestion VMware ESXi/vCenter basé sur MCP, proposant des API REST simples pour la gestion de machines virtuelles.
- [cloudflare/mcp-server-cloudflare](https://github.com/cloudflare/mcp-server-cloudflare) 🎖️ 📇 ☁️ - Intégration avec les services Cloudflare incluant Workers, KV, R2 et D1
- [cyclops-ui/mcp-cyclops](https://github.com/cyclops-ui/mcp-cyclops) 🎖️ 🏎️ ☁️ - Serveur MCP permettant aux agents IA de gérer des ressources Kubernetes via l’abstraction Cyclops
- [jedisct1/fastly-mcp-server](https://github.com/jedisct1/fastly-openapi-schema) 🎖️ 📇 ☁️ - Intégration avec les services Fastly
- [flux159/mcp-server-kubernetes](https://github.com/Flux159/mcp-server-kubernetes) 📇 ☁️/🏠 - Implémentation Typescript des opérations de cluster Kubernetes pour pods, déploiements, services.
- [hardik-id/azure-resource-graph-mcp-server](https://github.com/hardik-id/azure-resource-graph-mcp-server) 📇 ☁️/🏠 - Serveur Model Context Protocol pour interroger et analyser à grande échelle les ressources Azure via Azure Resource Graph, permettant aux assistants IA d’explorer et de surveiller l’infrastructure Azure.
- [jdubois/azure-cli-mcp](https://github.com/jdubois/azure-cli-mcp) - Un wrapper autour de la ligne de commande Azure CLI qui permet d’interagir directement avec Azure
- [johnneerdael/netskope-mcp](https://github.com/johnneerdael/netskope-mcp) 🔒 ☁️ - Un MCP donnant accès à tous les composants Netskope Private Access dans des environnements Netskope Private Access, avec des instructions de configuration détaillées et des exemples LLM d’utilisation.
- [manusa/Kubernetes MCP Server](https://github.com/manusa/kubernetes-mcp-server) 🏎️ 🏠 - Serveur MCP Kubernetes puissant avec support additionnel pour OpenShift. En plus des opérations CRUD sur **toutes** les ressources Kubernetes, ce serveur propose des outils spécialisés pour interagir avec votre cluster.
- [nwiizo/tfmcp](https://github.com/nwiizo/tfmcp) 🦀 🏠 - Serveur MCP Terraform permettant aux assistants IA de gérer et d’opérer des environnements Terraform : lecture de configurations, analyse de plans, application de configurations, gestion de l’état Terraform.
- [pulumi/mcp-server](https://github.com/pulumi/mcp-server) 🎖️ 📇 🏠 - Serveur MCP pour interagir avec Pulumi via l’API Automation Pulumi et l’API Cloud Pulumi. Permet aux clients MCP d’effectuer des opérations Pulumi telles que la récupération d’informations de package, la prévisualisation de changements, le déploiement de mises à jour et la récupération des sorties de stack de façon programmée.
- [rohitg00/kubectl-mcp-server](https://github.com/rohitg00/kubectl-mcp-server) 🐍 ☁️/🏠 - Serveur Model Context Protocol (MCP) pour Kubernetes permettant aux assistants IA comme Claude, Cursor, etc. d’interagir avec des clusters Kubernetes en langage naturel.
- [strowk/mcp-k8s-go](https://github.com/strowk/mcp-k8s-go) 🏎️ ☁️/🏠 - Opérations de cluster Kubernetes via MCP
- [thunderboltsid/mcp-nutanix](https://github.com/thunderboltsid/mcp-nutanix) 🏎️ 🏠/☁️ - Serveur MCP Go pour interagir avec les ressources Nutanix Prism Central.
- [trilogy-group/aws-pricing-mcp](https://github.com/trilogy-group/aws-pricing-mcp) 🏎️ ☁️/🏠 - Obtenez les informations de tarification EC2 à jour en une seule requête. Rapide. Basé sur un catalogue de prix AWS pré-analysé.
- [weibaohui/k8m](https://github.com/weibaohui/k8m) 🏎️ ☁️/🏠 - Fournit la gestion et les opérations multi-clusters Kubernetes MCP, avec une interface de gestion, la journalisation et près de 50 outils intégrés couvrant les scénarios DevOps et développement courants. Supporte les ressources standards et CRD.
- [weibaohui/kom](https://github.com/weibaohui/kom) 🏎️ ☁️/🏠 - Fournit la gestion et les opérations multi-clusters Kubernetes MCP. Peut être intégré comme SDK dans votre propre projet et inclut près de 50 outils intégrés couvrant les scénarios DevOps et développement courants. Supporte les ressources standards et CRD.
- [wenhuwang/mcp-k8s-eye](https://github.com/wenhuwang/mcp-k8s-eye) 🏎️ ☁️/🏠 - Serveur MCP pour la gestion de Kubernetes, permettant d’analyser votre cluster et la santé des applications.
- [erikhoward/adls-mcp-server](https://github.com/erikhoward/adls-mcp-server) 🐍 ☁️/🏠 - Serveur MCP pour Azure Data Lake Storage. Permet de gérer les conteneurs, d’effectuer des opérations de lecture/écriture/téléversement/téléchargement sur les fichiers du conteneur et de gérer les métadonnées des fichiers.
- [silenceper/mcp-k8s](https://github.com/silenceper/mcp-k8s) 🏎️ ☁️/🏠 - MCP-K8S est un outil de gestion des ressources Kubernetes piloté par IA, permettant aux utilisateurs d’opérer sur toutes les ressources des clusters Kubernetes via une interaction en langage naturel, y compris les ressources natives (telles que Deployment, Service) et les ressources personnalisées (CRD). Plus besoin de mémoriser des commandes complexes : décrivez simplement vos besoins et l’IA exécutera avec précision les opérations correspondantes sur le cluster, améliorant considérablement l’utilisabilité de Kubernetes.
- [redis/mcp-redis-cloud](https://github.com/redis/mcp-redis-cloud) 📇 ☁️ - Gérez facilement vos ressources Redis Cloud en langage naturel. Créez des bases de données, surveillez les abonnements et configurez les déploiements cloud avec des commandes simples.
- [portainer/portainer-mcp](https://github.com/portainer/portainer-mcp) 🏎️ ☁️/🏠 - Un serveur MCP puissant qui permet aux assistants IA d’interagir facilement avec des instances Portainer, offrant un accès en langage naturel à la gestion des conteneurs, aux opérations de déploiement et à la surveillance de l’infrastructure.

### 👨‍💻 <a name="code-execution"></a>Exécution de code

Serveurs d’exécution de code. Permettent aux LLM d’exécuter du code dans un environnement sécurisé, par exemple pour les agents de codage.

- [pydantic/pydantic-ai/mcp-run-python](https://github.com/pydantic/pydantic-ai/tree/main/mcp-run-python) 🐍 🏠- Exécutez du code Python dans un bac à sable sécurisé via des appels d’outils MCP
- [yepcode/mcp-server-js](https://github.com/yepcode/mcp-server-js) 🎖️ 📇 ☁️ - Exécutez tout code généré par LLM dans un environnement bac à sable sécurisé et évolutif et créez vos propres outils MCP en JavaScript ou Python, avec prise en charge complète des paquets NPM et PyPI
- [ckanthony/openapi-mcp](https://github.com/ckanthony/openapi-mcp) 🏎️ ☁️ - OpenAPI-MCP : Serveur MCP Dockerisé permettant à votre agent IA d’accéder à n’importe quelle API disposant de docs existantes.
- [alfonsograziano/node-code-sandbox-mcp](https://github.com/alfonsograziano/node-code-sandbox-mcp) 📇 🏠 – Un serveur MCP Node.js qui crée à la volée des bacs à sable isolés basés sur Docker pour exécuter des extraits JavaScript, avec installation dynamique des dépendances npm et suppression propre
- [r33drichards/mcp-js](https://github.com/r33drichards/mcp-js) 🦀 🏠 🐧 🍎 - Un bac à sable d’exécution de code JavaScript utilisant v8 pour isoler le code et exécuter localement du JavaScript généré par IA sans risque. Prend en charge la capture de snapshot de tas pour les sessions persistantes.

### 🤖 <a name="coding-agents"></a>Agents de codage

Agents de codage complets permettant aux LLM de lire, modifier et exécuter du code et de résoudre de façon autonome des tâches de programmation générales.

- [oraios/serena](https://github.com/oraios/serena)🐍🏠 - Un agent de codage complet reposant sur des opérations symboliques de code à l’aide de language servers.
- [ezyang/codemcp](https://github.com/ezyang/codemcp) 🐍🏠 - Agent de codage avec des outils basiques de lecture, écriture et ligne de commande.
- [doggybee/mcp-server-leetcode](https://github.com/doggybee/mcp-server-leetcode) 📇 ☁️ - Un serveur MCP permettant aux modèles IA de rechercher, récupérer et résoudre des problèmes LeetCode. Prend en charge le filtrage par métadonnées, les profils utilisateurs, les soumissions et l’accès aux données de concours.
- [jinzcdev/leetcode-mcp-server](https://github.com/jinzcdev/leetcode-mcp-server) 📇 ☁️ - Serveur MCP permettant un accès automatisé aux problèmes de programmation, solutions, soumissions et données publiques de **LeetCode** avec authentification optionnelle pour des fonctionnalités spécifiques à l’utilisateur (ex : notes), compatible avec `leetcode.com` (global) et `leetcode.cn` (Chine).
- [juehang/vscode-mcp-server](https://github.com/juehang/vscode-mcp-server) 📇 🏠 - Un serveur MCP permettant à une IA telle que Claude de lire la structure de répertoires d’un espace de travail VS Code, de voir les problèmes détectés par les linter(s) et le language server, de lire les fichiers de code et de proposer des modifications.
- [micl2e2/code-to-tree](https://github.com/micl2e2/code-to-tree) 🌊 🏠 📟 🐧 🪟 🍎 - Un serveur MCP monobinaire convertissant le code source en AST, quel que soit le langage.

### 🖥️ <a name="command-line"></a>Ligne de commande

Exécutez des commandes, capturez les sorties et interagissez avec les shells et outils en ligne de commande.

- [ferrislucas/iterm-mcp](https://github.com/ferrislucas/iterm-mcp) 🖥️ 🛠️ 💬 - Un serveur Model Context Protocol qui donne accès à iTerm. Vous pouvez exécuter des commandes et poser des questions sur ce qui s’affiche dans le terminal iTerm.
- [g0t4/mcp-server-commands](https://github.com/g0t4/mcp-server-commands) 📇 🏠 - Exécutez n’importe quelle commande avec les outils `run_command` et `run_script`.
- [maxim-saplin/mcp_safe_local_python_executor](https://github.com/maxim-saplin/mcp_safe_local_python_executor) - Interpréteur Python sécurisé basé sur HF Smolagents `LocalPythonExecutor`
- [MladenSU/cli-mcp-server](https://github.com/MladenSU/cli-mcp-server) 🐍 🏠 - Interface en ligne de commande avec exécution sécurisée et politiques de sécurité personnalisables
- [OthmaneBlial/term_mcp_deepseek](https://github.com/OthmaneBlial/term_mcp_deepseek) 🐍 🏠 - Un serveur DeepSeek MCP-like pour terminal
- [tumf/mcp-shell-server](https://github.com/tumf/mcp-shell-server) - Un serveur d’exécution sécurisée de commandes shell implémentant le Model Context Protocol (MCP)
- [automateyournetwork/pyATS_MCP](https://github.com/automateyournetwork/pyATS_MCP) - Serveur Cisco pyATS permettant une interaction structurée et pilotée par modèle avec les équipements réseau.
- [wonderwhy-er/DesktopCommanderMCP](https://github.com/wonderwhy-er/DesktopCommanderMCP) 📇 🏠 🍎 🪟 🐧 - Un couteau suisse permettant de gérer/exécuter des programmes et lire/écrire/rechercher/éditer des fichiers texte et code.
- [tufantunc/ssh-mcp](https://github.com/tufantunc/ssh-mcp) 📇 🏠 🐧 🪟 - Serveur MCP exposant un contrôle SSH pour les serveurs Linux et Windows via Model Context Protocol. Exécution sécurisée de commandes shell distantes avec authentification par mot de passe ou clé SSH.

### 💬 <a name="communication"></a>Communication

Intégration avec des plateformes de communication pour la gestion des messages et des canaux. Permet aux modèles IA d’interagir avec les outils de communication d’équipe.

- [AbdelStark/nostr-mcp](https://github.com/AbdelStark/nostr-mcp) ☁️ - Un serveur Nostr MCP permettant d’interagir avec Nostr, de publier des notes, et plus encore.
- [adhikasp/mcp-twikit](https://github.com/adhikasp/mcp-twikit) 🐍 ☁️ - Interagissez avec la recherche et la timeline Twitter
- [agentmail-toolkit/mcp](https://github.com/agentmail-to/agentmail-toolkit/tree/main/mcp) 🐍 💬 - Un serveur MCP pour créer des boîtes de réception à la volée afin d’envoyer, recevoir et agir sur les e-mails. Nous ne sommes pas des agents IA pour l’e-mail, mais l’e-mail pour les agents IA.
- [arpitbatra123/mcp-googletasks](https://github.com/arpitbatra123/mcp-googletasks) 📇 ☁️ - Serveur MCP pour interfacer avec l’API Google Tasks
- [carterlasalle/mac_messages_mcp](https://github.com/carterlasalle/mac_messages_mcp) 🏠 🍎 🚀 - Un serveur MCP qui interface en toute sécurité avec votre base iMessage via le Model Context Protocol (MCP), permettant aux LLM de requêter et analyser les conversations iMessage. Inclut une validation robuste des numéros de téléphone, la gestion des pièces jointes, des contacts, des groupes et le support complet de l’envoi/réception de messages.
- [chaindead/telegram-mcp](https://github.com/chaindead/telegram-mcp) 🏎️ 🏠 - Intégration API Telegram pour accéder aux données utilisateur, gérer les dialogues (chats, canaux, groupes), récupérer les messages et gérer le statut de lecture
- [chigwell/telegram-mcp](https://github.com/chigwell/telegram-mcp) 🐍 🏠 - Intégration API Telegram pour accéder aux données utilisateur, gérer les dialogues (chats, canaux, groupes), récupérer et envoyer des messages, gérer le statut de lecture.
- [elie222/inbox-zero](https://github.com/elie222/inbox-zero/tree/main/apps/mcp-server) 🐍 ☁️ - Serveur MCP pour Inbox Zero. Ajoute des fonctionnalités à Gmail comme trouver les e-mails nécessitant une réponse ou un suivi.
- [gitmotion/ntfy-me-mcp](https://github.com/gitmotion/ntfy-me-mcp) 📇 ☁️ 🏠 - Un serveur MCP ntfy pour envoyer/récupérer des notifications ntfy vers votre serveur ntfy auto-hébergé depuis des agents IA 📤 (authentification token sécurisée et plus - utilisable avec npx ou docker !)
- [gotoolkits/wecombot](https://github.com/gotoolkits/mcp-wecombot-server.git) 🚀 ☁️ - Une application serveur MCP qui envoie différents types de messages au robot de groupe WeCom.
- [hannesrudolph/imessage-query-fastmcp-mcp-server](https://github.com/hannesrudolph/imessage-query-fastmcp-mcp-server) 🐍 🏠 🍎 - Un serveur MCP permettant un accès sécurisé à votre base iMessage via Model Context Protocol (MCP), permettant aux LLM de requêter et analyser les conversations iMessage avec validation des numéros de téléphone et gestion des pièces jointes.
- [i-am-bee/acp-mcp](https://github.com/i-am-bee/acp-mcp) 🐍 💬 - Serveur MCP agissant comme adaptateur vers l’écosystème [ACP](https://agentcommunicationprotocol.dev). Expose facilement les agents ACP aux clients MCP, comblant le fossé entre les deux protocoles.
- [jagan-shanmugam/mattermost-mcp-host](https://github.com/jagan-shanmugam/mattermost-mcp-host) 🐍 🏠 - Un serveur MCP avec MCP host pour accéder aux équipes, canaux et messages Mattermost. MCP host est intégré comme bot dans Mattermost avec accès à des serveurs MCP configurables.
- [lharries/whatsapp-mcp](https://github.com/lharries/whatsapp-mcp) 🐍 🏎️ - Serveur MCP permettant la recherche de vos messages WhatsApp personnels, contacts et l’envoi de messages à des individus ou groupes
- [line/line-bot-mcp-server](https://github.com/line/line-bot-mcp-server) 🎖 📇 ☁️ - Serveur MCP pour l’intégration du compte officiel LINE
- [MarkusPfundstein/mcp-gsuite](https://github.com/MarkusPfundstein/mcp-gsuite) 🐍 ☁️ - Intégration avec Gmail et Google Calendar.
- [modelcontextprotocol/server-bluesky](https://github.com/keturiosakys/bluesky-context-server) 📇 ☁️ - Intégration instance Bluesky pour requêtes et interactions
- [modelcontextprotocol/server-slack](https://github.com/modelcontextprotocol/servers/tree/main/src/slack) 📇 ☁️ - Intégration Slack workspace pour gestion des canaux et messagerie
- [korotovsky/slack-mcp-server](https://github.com/korotovsky/slack-mcp-server) 📇 ☁️ - Le serveur MCP le plus puissant pour les espaces de travail Slack.
- [sawa-zen/vrchat-mcp](https://github.com/sawa-zen/vrchat-mcp) - 📇 🏠 Serveur MCP pour interagir avec l’API VRChat. Permet de récupérer des informations sur les amis, mondes, avatars, etc.
- [takumi0706/google-calendar-mcp](https://github.com/takumi0706/google-calendar-mcp) 📇 ☁️ - Serveur MCP pour interfacer avec l’API Google Calendar. Basé sur TypeScript.
- [teddyzxcv/ntfy-mcp](https://github.com/teddyzxcv/ntfy-mcp) - Serveur MCP qui vous informe en envoyant des notifications sur votre téléphone via ntfy
- [userad/didlogic_mcp](https://github.com/UserAd/didlogic_mcp) 🐍 ☁️ - Serveur MCP pour [DIDLogic](https://didlogic.com). Permet de gérer les endpoints SIP, numéros et destinations.
- [zcaceres/gtasks-mcp](https://github.com/zcaceres/gtasks-mcp) 📇 ☁️ - Serveur MCP pour gérer Google Tasks
- [InditexTech/mcp-teams-server](https://github.com/InditexTech/mcp-teams-server) 🐍 ☁️ - Serveur MCP intégrant la messagerie Microsoft Teams (lecture, post, mention, liste des membres et threads)
- [softeria/ms-365-mcp-server](https://github.com/softeria/ms-365-mcp-server) 📇 ☁️ - Serveur MCP connecté à toute la suite Microsoft 365 via Graph API (mail, fichiers, Excel, calendrier inclus)
- [YCloud-Developers/ycloud-whatsapp-mcp-server](https://github.com/YCloud-Developers/ycloud-whatsapp-mcp-server) 📇 🏠 - Serveur MCP pour WhatsApp Business Platform par YCloud.
- [jaipandya/producthunt-mcp-server](https://github.com/jaipandya/producthunt-mcp-server) 🐍 🏠 - Serveur MCP pour Product Hunt. Interagissez avec les posts tendance, commentaires, collections, utilisateurs, etc.

### 👤 <a name="customer-data-platforms"></a>Plateformes de données clients

Permet l’accès aux profils clients à l’intérieur des plateformes de données clients.

- [iaptic/mcp-server-iaptic](https://github.com/iaptic/mcp-server-iaptic) 🎖️ 📇 ☁️ - Connectez-vous à [iaptic](https://www.iaptic.com) pour interroger vos achats clients, données de transactions et statistiques de revenus d’applications.
- [OpenDataMCP/OpenDataMCP](https://github.com/OpenDataMCP/OpenDataMCP) 🐍 ☁️ - Connectez n’importe quelle donnée ouverte à tout LLM avec Model Context Protocol.
- [sergehuber/inoyu-mcp-unomi-server](https://github.com/sergehuber/inoyu-mcp-unomi-server) 📇 ☁️ - Serveur MCP pour accéder et mettre à jour les profils sur un serveur Apache Unomi CDP.
- [tinybirdco/mcp-tinybird](https://github.com/tinybirdco/mcp-tinybird) 🐍 ☁️ - Serveur MCP pour interagir avec un workspace Tinybird depuis n’importe quel client MCP.
- [@antv/mcp-server-chart](https://github.com/antvis/mcp-server-chart) 🎖️ 📇 ☁️ - Serveur Model Context Protocol pour générer des graphiques visuels avec [AntV](https://github.com/antvis).

### 🗄️ <a name="databases"></a>Bases de données

Accès sécurisé aux bases de données avec inspection du schéma. Permet la requête et l’analyse de données avec des contrôles de sécurité configurables, y compris l’accès en lecture seule.

- [Aiven-Open/mcp-aiven](https://github.com/Aiven-Open/mcp-aiven) - 🐍 ☁️ 🎖️ - Naviguez dans vos [projets Aiven](https://go.aiven.io/mcp-server) et interagissez avec les services PostgreSQL®, Apache Kafka®, ClickHouse® et OpenSearch®
- [alexanderzuev/supabase-mcp-server](https://github.com/alexander-zuev/supabase-mcp-server) - Serveur MCP Supabase avec prise en charge de l’exécution de requêtes SQL et d’outils d’exploration de base de données
- [aliyun/alibabacloud-tablestore-mcp-server](https://github.com/aliyun/alibabacloud-tablestore-mcp-server) ☕ 🐍 ☁️ - Service MCP pour Tablestore, avec ajout de documents, recherche sémantique basée sur vecteurs et scalaires, compatible RAG et serverless.
- [benborla29/mcp-server-mysql](https://github.com/benborla/mcp-server-mysql) ☁️ 🏠 - Intégration de base de données MySQL en NodeJS avec contrôles d’accès configurables et inspection du schéma
- [bytebase/dbhub](https://github.com/bytebase/dbhub) 📇 🏠 – Serveur MCP universel de base de données prenant en charge les bases de données principales.
- [c4pt0r/mcp-server-tidb](https://github.com/c4pt0r/mcp-server-tidb) 🐍 ☁️ - Intégration de la base TiDB avec inspection du schéma et possibilités de requête
- [Canner/wren-engine](https://github.com/Canner/wren-engine) 🐍 🦀 🏠 - Moteur sémantique pour clients Model Context Protocol (MCP) et agents IA
- [centralmind/gateway](https://github.com/centralmind/gateway) 🏎️ 🏠 🍎 🪟 - Serveur MCP et MCP SSE générant automatiquement une API à partir du schéma et des données de la base. Prend en charge PostgreSQL, Clickhouse, MySQL, Snowflake, BigQuery, Supabase
- [ChristianHinge/dicom-mcp](https://github.com/ChristianHinge/dicom-mcp) 🐍 ☁️ 🏠 - Intégration DICOM pour interroger, lire et déplacer des images médicales et rapports depuis des systèmes compatibles PACS/DICOM.
- [chroma-core/chroma-mcp](https://github.com/chroma-core/chroma-mcp) 🎖️ 🐍 ☁️ 🏠 - Serveur MCP Chroma pour accéder aux instances locales et cloud de Chroma pour des capacités de recherche
- [ClickHouse/mcp-clickhouse](https://github.com/ClickHouse/mcp-clickhouse) 🐍 ☁️ - Intégration de la base de données ClickHouse avec inspection du schéma et capacités de requête
- [confluentinc/mcp-confluent](https://github.com/confluentinc/mcp-confluent) 🐍 ☁️ - Intégration Confluent pour interagir avec les API REST de Confluent Kafka et Confluent Cloud.
- [Couchbase-Ecosystem/mcp-server-couchbase](https://github.com/Couchbase-Ecosystem/mcp-server-couchbase) 🎖️ 🐍 ☁️ 🏠 - Le serveur MCP Couchbase offre un accès unifié à la fois au cloud Capella et aux clusters autogérés pour les opérations sur les documents, les requêtes SQL++ et l’analyse de données en langage naturel.
- [cr7258/elasticsearch-mcp-server](https://github.com/cr7258/elasticsearch-mcp-server) 🐍 🏠 - Implémentation du serveur MCP qui permet l’interaction avec Elasticsearch.
- [crystaldba/postgres-mcp](https://github.com/crystaldba/postgres-mcp) 🐍 🏠 - Serveur MCP tout-en-un pour le développement et les opérations Postgres, avec des outils pour l’analyse des performances, l’optimisation et les contrôles de santé.
- [Dataring-engineering/mcp-server-trino](https://github.com/Dataring-engineering/mcp-server-trino) 🐍 ☁️ - Serveur MCP Trino pour interroger et accéder aux données des clusters Trino.
- [tuannvm/mcp-trino](https://github.com/tuannvm/mcp-trino) 🏎️ ☁️ - Implémentation Go d’un serveur Model Context Protocol (MCP) pour Trino.
- [designcomputer/mysql_mcp_server](https://github.com/designcomputer/mysql_mcp_server) 🐍 🏠 - Intégration de base de données MySQL avec contrôles d’accès configurables, inspection de schéma et directives de sécurité complètes.
- [wenb1n-dev/mysql_mcp_server_pro](https://github.com/wenb1n-dev/mysql_mcp_server_pro)  🐍 🏠 - Prend en charge SSE, STDIO ; ne se limite pas seulement aux fonctions CRUD de MySQL ; inclut également des capacités d’analyse des exceptions de base de données ; contrôle les permissions selon les rôles ; facilite l’extension d’outils personnalisés par les développeurs.
- [domdomegg/airtable-mcp-server](https://github.com/domdomegg/airtable-mcp-server) 📇 🏠 - Intégration de base de données Airtable avec inspection du schéma, capacités de lecture et d’écriture.
- [edwinbernadus/nocodb-mcp-server](https://github.com/edwinbernadus/nocodb-mcp-server) 📇 ☁️ - Intégration de base de données Nocodb, avec capacités de lecture et d’écriture.
- [ergut/mcp-bigquery-server](https://github.com/ergut/mcp-bigquery-server) 📇 ☁️ - Implémentation serveur pour l’intégration Google BigQuery permettant un accès direct et des capacités de requêtes sur la base BigQuery.
- [f4ww4z/mcp-mysql-server](https://github.com/f4ww4z/mcp-mysql-server) 📇 🏠 - Intégration MySQL basée sur Node.js offrant des opérations sécurisées sur la base MySQL.
- [fireproof-storage/mcp-database-server](https://github.com/fireproof-storage/mcp-database-server) 📇 ☁️ - Base de données ledger Fireproof avec synchronisation multi-utilisateurs.
- [FreePeak/db-mcp-server](https://github.com/FreePeak/db-mcp-server) 🏎️ 🏠 – Serveur MCP multi-bases de données haute performance construit avec Golang, prenant en charge MySQL & PostgreSQL (NoSQL bientôt disponible). Inclut des outils intégrés pour l’exécution de requêtes, la gestion des transactions, l’exploration de schémas, la construction de requêtes et l’analyse des performances, avec une intégration Cursor transparente pour des workflows améliorés.
- [furey/mongodb-lens](https://github.com/furey/mongodb-lens) 📇 🏠 - MongoDB Lens : Serveur MCP complet pour bases de données MongoDB.
- [gannonh/firebase-mcp](https://github.com/gannonh/firebase-mcp) 🔥 ⛅️ - Services Firebase, y compris Auth, Firestore et Storage.
- [get-convex/convex-backend](https://stack.convex.dev/convex-mcp-server) 📇 ☁️ - Intégration de base de données Convex pour introspecter les tables, fonctions et exécuter des requêtes ponctuelles ([Source](https://github.com/get-convex/convex-backend/blob/main/npm-packages/convex/src/cli/mcp.ts))
- [googleapis/genai-toolbox](https://github.com/googleapis/genai-toolbox) 🏎️ ☁️ - Serveur MCP open source spécialisé dans des outils faciles, rapides et sécurisés pour les bases de données.
- [GreptimeTeam/greptimedb-mcp-server](https://github.com/GreptimeTeam/greptimedb-mcp-server) 🐍 🏠 - Serveur MCP pour interroger GreptimeDB.
- [hannesrudolph/sqlite-explorer-fastmcp-mcp-server](https://github.com/hannesrudolph/sqlite-explorer-fastmcp-mcp-server) 🐍 🏠 - Un serveur MCP qui offre un accès sécurisé en lecture seule aux bases SQLite via le Model Context Protocol (MCP). Construit avec le framework FastMCP, qui permet aux LLM d’explorer et d’interroger les bases SQLite avec des fonctions de sécurité et de validation de requêtes intégrées.
- [idoru/influxdb-mcp-server](https://github.com/idoru/influxdb-mcp-server) 📇 ☁️ 🏠 - Exécutez des requêtes sur l’API InfluxDB OSS v2.
- [isaacwasserman/mcp-snowflake-server](https://github.com/isaacwasserman/mcp-snowflake-server) 🐍 ☁️ - Intégration Snowflake implémentant des opérations de lecture et (optionnellement) d’écriture ainsi que le suivi des insights.
- [joshuarileydev/supabase-mcp-server](https://github.com/joshuarileydev/supabase) - Serveur MCP Supabase pour gérer et créer des projets et organisations dans Supabase.
- [jovezhong/mcp-timeplus](https://github.com/jovezhong/mcp-timeplus) 🐍 ☁️ - Serveur MCP pour Apache Kafka et Timeplus. Permet de lister les topics Kafka, de récupérer des messages Kafka, de sauvegarder des données localement et d’interroger des données en streaming avec SQL via Timeplus.
- [KashiwaByte/vikingdb-mcp-server](https://github.com/KashiwaByte/vikingdb-mcp-server) 🐍 ☁️ - Intégration VikingDB avec introduction des collections et index, stockage et recherche vectorielle.
- [kiliczsh/mcp-mongo-server](https://github.com/kiliczsh/mcp-mongo-server) 📇 🏠 - Un serveur Model Context Protocol pour MongoDB.
- [ktanaka101/mcp-server-duckdb](https://github.com/ktanaka101/mcp-server-duckdb) 🐍 🏠 - Intégration DuckDB avec inspection de schéma et capacités de requêtes.
- [LucasHild/mcp-server-bigquery](https://github.com/LucasHild/mcp-server-bigquery) 🐍 ☁️ - Intégration BigQuery avec inspection de schéma et capacités de requêtes.
- [quarkiverse/mcp-server-jdbc](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/jdbc) ☕ 🏠 - Connectez-vous à toute base compatible JDBC et effectuez des opérations de requête, insertion, mise à jour, suppression, etc.
- [jparkerweb/mcp-sqlite](https://github.com/jparkerweb/mcp-sqlite) 📇 🏠 - Serveur Model Context Protocol (MCP) offrant des capacités complètes d’interaction avec des bases SQLite.
- [memgraph/mcp-memgraph](https://github.com/memgraph/mcp-memgraph) 🐍 🏠 - Serveur MCP Memgraph - inclut un outil pour exécuter des requêtes sur Memgraph et une ressource de schéma.
- [modelcontextprotocol/server-postgres](https://github.com/modelcontextprotocol/servers/tree/main/src/postgres) 📇 🏠 - Intégration PostgreSQL avec inspection de schéma et capacités de requêtes.
- [modelcontextprotocol/server-sqlite](https://github.com/modelcontextprotocol/servers/tree/main/src/sqlite) 🐍 🏠 - Opérations SQLite avec fonctions d’analyse intégrées.
- [neo4j-contrib/mcp-neo4j](https://github.com/neo4j-contrib/mcp-neo4j) 🐍 🏠 - Model Context Protocol avec Neo4j (Exécution de requêtes, Knowledge Graph Memory, gestion des instances Neo4j Aura).
- [neondatabase/mcp-server-neon](https://github.com/neondatabase/mcp-server-neon) 📇 ☁️ — Serveur MCP pour créer et gérer des bases de données Postgres avec Neon Serverless Postgres.
- [niledatabase/nile-mcp-server](https://github.com/niledatabase/nile-mcp-server) Serveur MCP pour la plateforme Postgres de Nile - Gérer et interroger bases Postgres, locataires, utilisateurs, authentification via LLM.
- [openlink/mcp-server-odbc](https://github.com/OpenLinkSoftware/mcp-odbc-server) 🐍 🏠 - Un serveur MCP pour la connectivité générique de systèmes de gestion de bases de données (SGBD) via le protocole ODBC (Open Database Connectivity).
- [openlink/mcp-server-sqlalchemy](https://github.com/OpenLinkSoftware/mcp-sqlalchemy-server) 🐍 🏠 - Un serveur MCP pour la connectivité générique des SGBD via SQLAlchemy en utilisant Python ODBC (pyodbc).
- [pab1it0/adx-mcp-server](https://github.com/pab1it0/adx-mcp-server) 🐍 ☁️ - Interroger et analyser les bases Azure Data Explorer.
- [pab1it0/prometheus-mcp-server](https://github.com/pab1it0/prometheus-mcp-server) 🐍 ☁️ - Interroger et analyser Prometheus, système de surveillance open-source.
- [prisma/prisma](https://github.com/prisma/prisma) 🐍 🏠 - Donne aux LLM la capacité de gérer les bases Prisma Postgres (ex. créer de nouvelles instances ou exécuter des migrations de schéma).
- [qdrant/mcp-server-qdrant](https://github.com/qdrant/mcp-server-qdrant) 🐍 🏠 - Un serveur MCP Qdrant.
- [QuantGeekDev/mongo-mcp](https://github.com/QuantGeekDev/mongo-mcp) 📇 🏠 - Intégration MongoDB permettant aux LLM d’interagir directement avec les bases de données.
- [rashidazarang/airtable-mcp](https://github.com/rashidazarang/airtable-mcp) 🐍 ☁️ - Connectez directement des outils d’IA à Airtable. Interroger, créer, mettre à jour et supprimer des enregistrements en langage naturel. Fonctionnalités : gestion des bases, opérations sur les tables, manipulation de schémas, filtrage d’enregistrements, migration de données via une interface MCP standardisée.
- [redis/mcp-redis](https://github.com/redis/mcp-redis) 🐍 🏠 - Le serveur MCP officiel Redis offre une interface pour gérer et rechercher des données dans Redis.
- [runekaagaard/mcp-alchemy](https://github.com/runekaagaard/mcp-alchemy) 🐍 🏠 - Intégration universelle des bases de données basée sur SQLAlchemy prenant en charge PostgreSQL, MySQL, MariaDB, SQLite, Oracle, MS SQL Server et bien d’autres. Fonctions d’inspection des schémas et relations, et analyse de grands jeux de données.
- [sirmews/mcp-pinecone](https://github.com/sirmews/mcp-pinecone) 🐍 ☁️ - Intégration Pinecone avec recherche vectorielle.
- [skysqlinc/skysql-mcp](https://github.com/skysqlinc/skysql-mcp) 🎖️ ☁️ - Serveur MCP MariaDB Cloud DB serverless. Outils pour lancer, supprimer, exécuter du SQL et travailler avec des agents IA pour un text-2-sql et des conversations précis.
- [supabase-community/supabase-mcp](https://github.com/supabase-community/supabase-mcp) 🎖️ 📇 ☁️ - Serveur MCP officiel Supabase pour connecter des assistants IA directement à votre projet Supabase et leur permettre de gérer des tables, récupérer la configuration et interroger les données.
- [TheRaLabs/legion-mcp](https://github.com/TheRaLabs/legion-mcp) 🐍 🏠 Serveur MCP universel pour bases de données multiples, incluant PostgreSQL, Redshift, CockroachDB, MySQL, RDS MySQL, Microsoft SQL Server, BigQuery, Oracle DB et SQLite.
- [tradercjz/dolphindb-mcp-server](https://github.com/tradercjz/dolphindb-mcp-server) 🐍 ☁️ - Intégration DolphinDB avec inspection de schéma et capacités de requêtes.
- [weaviate/mcp-server-weaviate](https://github.com/weaviate/mcp-server-weaviate) 🐍 📇 ☁️ - Un serveur MCP pour connecter vos collections Weaviate comme base de connaissances ainsi que l’utilisation de Weaviate comme mémoire de chat.
- [XGenerationLab/xiyan_mcp_server](https://github.com/XGenerationLab/xiyan_mcp_server) 📇 ☁️ — Un serveur MCP qui prend en charge la récupération de données depuis une base à l’aide de requêtes en langage naturel, propulsé par XiyanSQL comme LLM text-to-SQL.
- [xing5/mcp-google-sheets](https://github.com/xing5/mcp-google-sheets) 🐍 ☁️ - Un serveur Model Context Protocol pour interagir avec Google Sheets. Fournit des outils pour créer, lire, mettre à jour et gérer des feuilles via l’API Google Sheets.
- [freema/mcp-gsheets](https://github.com/freema/mcp-gsheets) 📇 ☁️ - Serveur MCP pour l’intégration Google Sheets API avec lecture, écriture, formatage et gestion avancée des feuilles.
- [Zhwt/go-mcp-mysql](https://github.com/Zhwt/go-mcp-mysql) 🏎️ 🏠 – Serveur MCP MySQL facile à utiliser, sans dépendance, construit avec Golang, avec mode lecture seule configurable et inspection de schéma.
- [ydb/ydb-mcp](https://github.com/ydb-platform/ydb-mcp) 🎖️ 🐍 ☁️ - Serveur MCP pour interagir avec les bases [YDB](https://ydb.tech).
- [zilliztech/mcp-server-milvus](https://github.com/zilliztech/mcp-server-milvus) 🐍 🏠 ☁️ - Serveur MCP pour Milvus / Zilliz, permettant d’interagir avec votre base de données.
- [openlink/mcp-server-jdbc](https://github.com/OpenLinkSoftware/mcp-jdbc-server) 🐍 🏠 - Un serveur MCP pour la connectivité générique des SGBD via le protocole Java Database Connectivity (JDBC).
- [yincongcyincong/VictoriaMetrics-mcp-server](https://github.com/yincongcyincong/VictoriaMetrics-mcp-server) 🐍 🏠 - Serveur MCP pour interagir avec la base VictoriaMetrics.
- [hydrolix/mcp-hydrolix](https://github.com/hydrolix/mcp-hydrolix) 🎖️ 🐍 ☁️ - Intégration Hydrolix time-series datalake fournissant l’exploration de schéma et les capacités de requêtes pour les workflows LLM.
- [davewind/mysql-mcp-server](https://github.com/dave-wind/mysql-mcp-server) 🏎️ 🏠 A – serveur MCP mysql convivial en lecture seule pour cursor et n8n...


### 📊 <a name="data-platforms"></a>Plateformes de Données

Plateformes de données pour l’intégration, la transformation et l’orchestration des pipelines de données.

- [flowcore/mcp-flowcore-platform](https://github.com/flowcore-io/mcp-flowcore-platform) 🎖️ 📇 ☁️ 🏠 - Interagissez avec Flowcore pour réaliser des actions, ingérer des données, analyser, croiser et exploiter toute donnée dans vos cœurs de données, ou dans des cœurs publics ; tout cela en langage naturel.
- [JordiNei/mcp-databricks-server](https://github.com/JordiNeil/mcp-databricks-server) 🐍 ☁️ - Connectez-vous à l’API Databricks, permettant aux LLM d’exécuter des requêtes SQL, de lister les jobs et obtenir leur statut.
- [yashshingvi/databricks-genie-MCP](https://github.com/yashshingvi/databricks-genie-MCP) 🐍 ☁️ - Un serveur qui se connecte à l’API Databricks Genie, permettant aux LLM de poser des questions en langage naturel, d’exécuter des requêtes SQL et d’interagir avec des agents conversationnels Databricks.
- [jwaxman19/qlik-mcp](https://github.com/jwaxman19/qlik-mcp) 📇 ☁️ - Serveur MCP pour Qlik Cloud API permettant d’interroger des applications, feuilles, et d’extraire des données de visualisations avec authentification complète et support de limitation de débit.
- [keboola/keboola-mcp-server](https://github.com/keboola/keboola-mcp-server) 🐍 - Interagissez avec la plateforme de données Keboola Connection. Ce serveur propose des outils pour lister et accéder aux données via l’API Keboola Storage.
- [dbt-labs/dbt-mcp](https://github.com/dbt-labs/dbt-mcp) 🎖️ 🐍 🏠 ☁️ - Serveur MCP officiel pour [dbt (data build tool)](https://www.getdbt.com/product/what-is-dbt) offrant l’intégration avec dbt Core/Cloud CLI, découverte de métadonnées de projet, informations sur les modèles et requêtes de la couche sémantique.
- [mattijsdp/dbt-docs-mcp](https://github.com/mattijsdp/dbt-docs-mcp) 🐍 🏠 - Serveur MCP pour les utilisateurs dbt-core (OSS) car le serveur officiel ne prend en charge que dbt Cloud. Prend en charge les métadonnées de projet, la lignée au niveau modèle et colonne ainsi que la documentation dbt.

### 💻 <a name="developer-tools"></a>Outils Développeur

Outils et intégrations qui améliorent le flux de travail de développement et la gestion des environnements.

- [Pratyay/mac-monitor-mcp](https://github.com/Pratyay/mac-monitor-mcp) 🐍 🏠 🍎 - Identifie les processus consommateurs de ressources sur macOS et fournit des suggestions pour améliorer les performances.
- [21st-dev/Magic-MCP](https://github.com/21st-dev/magic-mcp) - Créez des composants UI inspirés des meilleurs ingénieurs design de 21st.dev.
- [Hypersequent/qasphere-mcp](https://github.com/Hypersequent/qasphere-mcp) 🎖️ 📇 ☁️ - Intégration avec le système de gestion de tests [QA Sphere](https://qasphere.com/), permettant aux LLM de découvrir, résumer et interagir avec les cas de tests directement depuis des IDE assistés par l’IA.
- [admica/FileScopeMCP](https://github.com/admica/FileScopeMCP) 🐍 📇 🦀 - Analyse votre codebase en identifiant les fichiers importants selon les relations de dépendance. Génère des diagrammes et scores d’importance, aidant les assistants IA à comprendre la base de code.
- [ambar/simctl-mcp](https://github.com/ambar/simctl-mcp) 📇 🏠 🍎 - Implémentation serveur MCP pour le contrôle de l’iOS Simulator.
- [api7/apisix-mcp](https://github.com/api7/apisix-mcp) 🎖️ 📇 🏠 Serveur MCP permettant de requêter et gérer toutes les ressources dans [Apache APISIX](https://github.com/apache/apisix).
- [ArchAI-Labs/fastmcp-sonarqube-metrics](https://github.com/ArchAI-Labs/fastmcp-sonarqube-metrics) 🐍 🏠 🪟 🐧 🍎 - Serveur Model Context Protocol (MCP) fournissant des outils pour récupérer des informations sur les projets SonarQube : métriques (actuelles et historiques), problèmes, état de santé.
- [automation-ai-labs/mcp-link](https://github.com/automation-ai-labs/mcp-link) 🏎️ 🏠 - Intégrez sans effort n’importe quelle API avec des agents IA (avec schéma OpenAPI).
- [azer/react-analyzer-mcp](https://github.com/azer/react-analyzer-mcp) 📇 🏠 - Analysez du code React localement, générez la doc / llm.txt pour l’ensemble du projet.
- [davidlin2k/pox-mcp-server](https://github.com/davidlin2k/pox-mcp-server) 🐍 🏠 - Serveur MCP pour le contrôleur POX SDN apportant capacités de contrôle et gestion réseau.
- [CodeLogicIncEngineering/codelogic-mcp-server](https://github.com/CodeLogicIncEngineering/codelogic-mcp-server) 🎖️ 🐍 ☁️ 🍎 🪟 🐧 - Serveur MCP officiel pour CodeLogic, donnant accès à l’analyse de dépendances, analyse de risques architecturaux, et outils d’évaluation d’impact.
- [Comet-ML/Opik-MCP](https://github.com/comet-ml/opik-mcp) 🎖️ 📇 ☁️ 🏠 - Utilisez le langage naturel pour explorer l’observabilité LLM, les traces et la supervision des données capturées par Opik.
- [CircleCI/mcp-server-circleci](https://github.com/CircleCI-Public/mcp-server-circleci) 📇 ☁️ - Permet aux agents IA de corriger les échecs de builds CircleCI.
- [currents-dev/currents-mcp](https://github.com/currents-dev/currents-mcp) 🎖️ 📇 ☁️ - Permet aux agents IA de corriger les échecs de tests Playwright signalés à [Currents](https://currents.dev).
- [delano/postman-mcp-server](https://github.com/delano/postman-mcp-server) 📇 ☁️ - Interagissez avec [Postman API](https://www.postman.com/postman/postman-public-workspace/)
- [flipt-io/mcp-server-flipt](https://github.com/flipt-io/mcp-server-flipt) 📇 🏠 - Permet aux assistants IA d’interagir avec vos feature flags dans [Flipt](https://flipt.io).
- [GLips/Figma-Context-MCP](https://github.com/GLips/Figma-Context-MCP) 📇 🏠 - Donne aux agents de codage un accès direct aux données Figma pour faciliter l’implémentation one-shot du design.
- [gofireflyio/firefly-mcp](https://github.com/gofireflyio/firefly-mcp) 🎖️ 📇 ☁️ - Intègre, découvre, gère et codifie les ressources cloud avec [Firefly](https://firefly.ai).
- [Govcraft/rust-docs-mcp-server](https://github.com/Govcraft/rust-docs-mcp-server) 🦀 🏠 - Fournit, via un outil MCP, un contexte de documentation à jour pour une crate Rust spécifique aux LLM, utilisant recherche sémantique (embeddings) et résumé LLM.
- [haris-musa/excel-mcp-server](https://github.com/haris-musa/excel-mcp-server) 🐍 🏠 - Serveur de manipulation Excel offrant création de classeurs, opérations sur les données, mise en forme et fonctions avancées (graphiques, tableaux croisés, formules).
- [higress-group/higress-ops-mcp-server](https://github.com/higress-group/higress-ops-mcp-server) 🐍 🏠 - Serveur MCP qui fournit des outils complets pour gérer les configurations et opérations de la passerelle [Higress](https://github.com/alibaba/higress).
- [hijaz/postmancer](https://github.com/hijaz/postmancer) 📇 🏠 - Un serveur MCP pour remplacer les clients REST tels que Postman/Insomnia, permettant à votre LLM de maintenir et d'utiliser des collections d'API.
- [hloiseaufcms/mcp-gopls](https://github.com/hloiseaufcms/mcp-gopls) 🏎️ 🏠 - Un serveur MCP pour interagir avec le [Language Server Protocol (gopls) de Go](https://github.com/golang/tools/tree/master/gopls) et bénéficier de fonctionnalités avancées d’analyse de code Go.
- [hungthai1401/bruno-mcp](https://github.com/hungthai1401/bruno-mcp) 📇 🏠 - Un serveur MCP pour interagir avec le [Bruno API Client](https://www.usebruno.com/).
- [hyperb1iss/droidmind](https://github.com/hyperb1iss/droidmind) 🐍 🏠 - Contrôlez les appareils Android avec l’IA via MCP, permettant le contrôle des appareils, le débogage, l’analyse système et l’automatisation de l’UI avec un cadre de sécurité complet.
- [XixianLiang/HarmonyOS-mcp-server](https://github.com/XixianLiang/HarmonyOS-mcp-server) 🐍 🏠 - Contrôlez les appareils HarmonyOS-next avec l’IA via MCP. Prise en charge du contrôle d’appareil et de l’automatisation UI.
- [IlyaGulya/gradle-mcp-server](https://github.com/IlyaGulya/gradle-mcp-server) 🏠 - Intégration Gradle utilisant l’API Gradle Tooling pour inspecter les projets, exécuter des tâches et lancer des tests avec des rapports de résultats par test.
- [InhiblabCore/mcp-image-compression](https://github.com/InhiblabCore/mcp-image-compression) 🐍 🏠 - Serveur MCP pour la compression locale de divers formats d’image.
- [isaacphi/mcp-language-server](https://github.com/isaacphi/mcp-language-server) 🏎️ 🏠 - Le serveur MCP Language Server aide les clients compatibles MCP à naviguer plus facilement dans les bases de code en leur donnant accès à des outils sémantiques tels que aller à la définition, références, renommage et diagnostics.
- [ios-simulator-mcp](https://github.com/joshuayoes/ios-simulator-mcp) 📇 🏠 🍎 - Un serveur Model Context Protocol (MCP) pour interagir avec des simulateurs iOS. Ce serveur vous permet d’interagir avec les simulateurs iOS en obtenant des informations, contrôlant les interactions UI et inspectant les éléments UI.
- [InditexTech/mcp-server-simulator-ios-idb](https://github.com/InditexTech/mcp-server-simulator-ios-idb) 📇 🏠 🍎 - Un serveur Model Context Protocol (MCP) qui permet aux LLM d’interagir avec les simulateurs iOS (iPhone, iPad, etc.) via des commandes en langage naturel.
- [IvanAmador/vercel-ai-docs-mcp](https://github.com/IvanAmador/vercel-ai-docs-mcp) 📇 🏠 - Un serveur Model Context Protocol (MCP) qui fournit des capacités de recherche et de requête alimentées par l’IA pour la documentation du SDK Vercel AI.
- [j4c0bs/mcp-server-sql-analyzer](https://github.com/j4c0bs/mcp-server-sql-analyzer) 🐍 - Serveur MCP qui fournit de l’analyse SQL, du linting, et la conversion de dialectes via [SQLGlot](https://github.com/tobymao/sqlglot)
- [jasonjmcghee/claude-debugs-for-you](https://github.com/jasonjmcghee/claude-debugs-for-you) 📇 🏠 - Un serveur MCP et extension VS Code permettant un débogage automatique (agnostique au langage) via des points d’arrêt et l’évaluation d’expressions.
- [jetbrains/mcpProxy](https://github.com/JetBrains/mcpProxy) 🎖️ 📇 🏠 - Connexion à JetBrains IDE
- [qainsights/jmeter-mcp-server](https://github.com/QAInsights/jmeter-mcp-server) 🐍 🏠 - Serveur JMeter MCP pour les tests de performance
- [Jktfe/serveMyAPI](https://github.com/Jktfe/serveMyAPI) 📇 🏠 🍎 - Un serveur MCP personnel pour stocker et accéder en toute sécurité aux clés d’API via le trousseau macOS sur différents projets.
- [joshuarileydev/app-store-connect-mcp-server](https://github.com/JoshuaRileyDev/app-store-connect-mcp-server) 📇 🏠 - Un serveur MCP pour communiquer avec l’API App Store Connect pour les développeurs iOS.
- [joshuarileydev/simulator-mcp-server](https://github.com/JoshuaRileyDev/simulator-mcp-server) 📇 🏠 - Un serveur MCP pour contrôler les simulateurs iOS.
- [qainsights/k6-mcp-server](https://github.com/QAInsights/k6-mcp-server) 🐍 🏠 - Serveur Grafana k6 MCP pour les tests de performance
- [lamemind/mcp-server-multiverse](https://github.com/lamemind/mcp-server-multiverse) 📇 🏠 🛠️ - Un serveur middleware qui permet à plusieurs instances isolées des mêmes serveurs MCP de coexister indépendamment avec des espaces de noms et configurations uniques.
- [langfuse/mcp-server-langfuse](https://github.com/langfuse/mcp-server-langfuse) 🐍 🏠 - Serveur MCP pour accéder et gérer les prompts d’application LLM créés avec [Langfuse]([https://langfuse.com/](https://langfuse.com/docs/prompts/get-started)) Prompt Management.
- [mobile-next/mobile-mcp](https://github.com/mobile-next/mobile-mcp) 📇 🏠 🐧 🍎 - Serveur MCP pour l’automatisation, le développement et le scraping d’applications et d’appareils Android/iOS. Prise en charge des simulateurs/émulateurs/appareils physiques comme iPhone, Google Pixel, Samsung.
- [qainsights/locust-mcp-server](https://github.com/QAInsights/locust-mcp-server) 🐍 🏠 - Serveur Locust MCP pour les tests de performance
- [mrexodia/user-feedback-mcp](https://github.com/mrexodia/user-feedback-mcp) 🐍 🏠 - Serveur MCP simple pour permettre un workflow humain-dans-la-boucle dans des outils comme Cline et Cursor.
- [narumiruna/gitingest-mcp](https://github.com/narumiruna/gitingest-mcp) 🐍 🏠 - Un serveur MCP qui utilise [gitingest](https://github.com/cyclotruc/gitingest) pour transformer tout dépôt Git en un résumé texte de sa base de code.
- [OctoMind-dev/octomind-mcp](https://github.com/OctoMind-dev/octomind-mcp) 📇 ☁️ - Permet à votre agent IA préféré de créer et d’exécuter des tests de bout en bout [Octomind](https://www.octomind.dev/) entièrement gérés à partir de votre base de code ou d’autres sources de données comme Jira, Slack ou TestRail.
- [kadykov/mcp-openapi-schema-explorer](https://github.com/kadykov/mcp-openapi-schema-explorer) 📇 ☁️ 🏠 - Accès efficace en tokens aux spécifications OpenAPI/Swagger via MCP Resources.
- [pskill9/website-downloader](https://github.com/pskill9/website-downloader) 🗄️ 🚀 - Ce serveur MCP fournit un outil pour télécharger des sites Web entiers en utilisant wget. Il préserve la structure du site et convertit les liens pour un usage local.
- [utensils/mcp-nixos](https://github.com/utensils/mcp-nixos) 🐍 🏠 - Serveur MCP fournissant des informations précises sur les paquets NixOS, options système, configurations Home Manager et paramètres nix-darwin macOS pour éviter les hallucinations de l’IA.
- [QuantGeekDev/docker-mcp](https://github.com/QuantGeekDev/docker-mcp) 🏎️ 🏠 - Gestion et opérations de conteneurs Docker via MCP
- [ckreiling/mcp-server-docker](https://github.com/ckreiling/mcp-server-docker) 🐍 🏠 - Intégration avec Docker pour gérer conteneurs, images, volumes et réseaux.
- [r-huijts/xcode-mcp-server](https://github.com/r-huijts/xcode-mcp-server) 📇 🏠 🍎 - Intégration Xcode pour la gestion de projets, opérations sur fichiers et automatisation de builds.
- [ReAPI-com/mcp-openapi](https://github.com/ReAPI-com/mcp-openapi) 📇 🏠 - Serveur MCP permettant aux LLM de tout savoir sur vos spécifications OpenAPI : découverte, explication, génération de code/données fictives.
- [Rootly-AI-Labs/Rootly-MCP-server](https://github.com/Rootly-AI-Labs/Rootly-MCP-server) 🎖️ 🐍 ☁️ 🍎 - Serveur MCP pour la plateforme de gestion d’incidents [Rootly](https://rootly.com/).
- [sammcj/mcp-package-version](https://github.com/sammcj/mcp-package-version) 📇 🏠 - Un serveur MCP pour aider les LLM à suggérer la dernière version stable des paquets lors de l’écriture de code.
- [sapientpants/sonarqube-mcp-server](https://github.com/sapientpants/sonarqube-mcp-server) 🦀 ☁️ 🏠 - Un serveur Model Context Protocol (MCP) qui s’intègre à SonarQube pour fournir aux assistants IA l’accès aux métriques de qualité de code, problèmes, et statuts de quality gate.
- [SDGLBL/mcp-claude-code](https://github.com/SDGLBL/mcp-claude-code) 🐍 🏠 - Implémentation des capacités Claude Code via MCP, permettant la compréhension, modification et analyse de projet de code par IA avec un support d’outils complet.
- [snaggle-ai/openapi-mcp-server](https://github.com/snaggle-ai/openapi-mcp-server) 🏎️ 🏠 - Connectez n’importe quel serveur HTTP/REST API en utilisant une spécification OpenAPI (v3)
- [stass/lldb-mcp](https://github.com/stass/lldb-mcp) 🐍 🏠 🐧 🍎 - Serveur MCP pour LLDB permettant l’analyse binaire et de fichiers core par IA, débogage, désassemblage.
- [TencentEdgeOne/edgeone-pages-mcp](https://github.com/TencentEdgeOne/edgeone-pages-mcp) 📇 ☁️ - Service MCP pour déployer du contenu HTML sur EdgeOne Pages et obtenir une URL publiquement accessible.
- [tumf/mcp-text-editor](https://github.com/tumf/mcp-text-editor) 🐍 🏠 - Un éditeur de fichiers texte orienté lignes. Optimisé pour les outils LLM avec un accès partiel efficace pour minimiser l’utilisation de tokens.
- [vivekvells/mcp-pandoc](https://github.com/vivekVells/mcp-pandoc) 🗄️ 🚀 - Serveur MCP pour la conversion transparente de formats de documents avec Pandoc, supportant Markdown, HTML, PDF, DOCX (.docx), csv, et plus.
- [VSCode Devtools](https://github.com/biegehydra/BifrostMCP) 📇 - Connectez-vous à l’IDE VSCode et utilisez des outils sémantiques comme `find_usages`
- [xcodebuild](https://github.com/ShenghaiWang/xcodebuild) 🍎 Compile des espaces de travail/projets Xcode iOS et renvoie les erreurs à llm.
- [xzq.xu/jvm-mcp-server](https://github.com/xzq-xu/jvm-mcp-server) 📇 🏠  - Un projet d’implémentation d’un serveur MCP (Model Context Protocol) basé sur la JVM.
- [yangkyeongmo@/mcp-server-apache-airflow](https://github.com/yangkyeongmo/mcp-server-apache-airflow) 🐍 🏠 - Serveur MCP qui se connecte à [Apache Airflow](https://airflow.apache.org/) en utilisant le client officiel.
- [YuChenSSR/mindmap-mcp-server](https://github.com/YuChenSSR/mindmap-mcp-server) 🐍 🏠 - Un serveur Model Context Protocol (MCP) pour générer une carte mentale interactive et esthétique.
- [YuChenSSR/multi-ai-advisor](https://github.com/YuChenSSR/multi-ai-advisor-mcp) 📇 🏠 - Un serveur Model Context Protocol (MCP) qui interroge plusieurs modèles Ollama et combine leurs réponses, offrant des perspectives IA variées sur une même question.
- [yWorks/mcp-typescribe](https://github.com/yWorks/mcp-typescribe) 📇 🏠 - Serveur MCP qui fournit efficacement des informations d’API Typescript à l’agent pour lui permettre de travailler avec des API non entraînées.
- [zcaceres/fetch-mcp](https://github.com/zcaceres/fetch-mcp) 📇 🏠 - Un serveur MCP pour récupérer de manière flexible des données JSON, texte et HTML.
- [zenml-io/mcp-zenml](https://github.com/zenml-io/mcp-zenml) 🐍 🏠 ☁️ - Un serveur MCP pour se connecter à vos pipelines MLOps et LLMOps [ZenML](https://www.zenml.io)
- [idosal/git-mcp](https://github.com/idosal/git-mcp) 📇 ☁️ - [gitmcp.io](https://gitmcp.io/) est un serveur MCP distant générique pour se connecter à n’importe quel dépôt ou projet [GitHub](https://www.github.com) pour la documentation.
- [tgeselle/bugsnag-mcp](https://github.com/tgeselle/bugsnag-mcp) 📇 ☁️ - Un serveur MCP pour interagir avec [Bugsnag](https://www.bugsnag.com/)
- [jordandalton/restcsv-mcp-server](https://github.com/JordanDalton/RestCsvMcpServer) 📇 ☁️ - Un serveur MCP pour les fichiers CSV.
- [cjo4m06/mcp-shrimp-task-manager](https://github.com/cjo4m06/mcp-shrimp-task-manager) 📇 ☁️ 🏠 – Un système de gestion de tâches axé programmation qui booste les agents de codage comme Cursor AI avec mémoire avancée des tâches, auto-réflexion et gestion des dépendances. [ShrimpTaskManager](https://cjo4m06.github.io/mcp-shrimp-task-manager)
- [axliupore/mcp-code-runner](https://github.com/axliupore/mcp-code-runner) 📇 🏠 - Un serveur MCP pour exécuter du code localement via Docker et prenant en charge plusieurs langages de programmation.
- [yikakia/godoc-mcp-server](https://github.com/yikakia/godoc-mcp-server) 🏎️ ☁️ 🪟 🐧 🍎 - Interrogez les informations des paquets Go sur pkg.go.dev
- [ckanthony/gin-mcp](https://github.com/ckanthony/gin-mcp) 🏎️ ☁️ 📟 🪟 🐧 🍎 - Une bibliothèque Go sans configuration pour exposer automatiquement les API du framework web Gin comme outils MCP.
- [ryan0204/github-repo-mcp](https://github.com/Ryan0204/github-repo-mcp) 📇 ☁️ 🪟 🐧 🍎 - GitHub Repo MCP permet à vos assistants IA de parcourir les dépôts GitHub, explorer les répertoires et voir le contenu des fichiers.
- [alimo7amed93/webhook-tester-mcp](https://github.com/alimo7amed93/webhook-tester-mcp)  🐍 ☁️ – Un serveur basé sur FastMCP pour interagir avec webhook-test.com. Permet de créer, récupérer et supprimer des webhooks localement via Claude.
- [lpigeon/ros-mcp-server](https://github.com/lpigeon/ros-mcp-server) 🐍 🏠 🍎 🪟 🐧 - Le serveur ROS MCP prend en charge le contrôle de robot en convertissant les commandes en langage naturel de l’utilisateur en commandes de contrôle ROS ou ROS2.
- [jsdelivr/globalping-mcp-server](https://github.com/jsdelivr/globalping-mcp-server) 🎖️ 📇 ☁️ - Le serveur Globalping MCP permet aux utilisateurs et LLM d’exécuter des outils réseau comme ping, traceroute, mtr, HTTP et résolution DNS depuis des milliers d’emplacements dans le monde entier.
- [posthog/mcp](https://github.com/posthog/mcp) 🎖️ 📇 ☁️ - Un serveur MCP pour interagir avec PostHog analytics, les feature flags, le suivi d’erreurs et plus.
- [artmann/package-registry-mcp](https://github.com/artmann/package-registry-mcp) 🏠 📇 🍎 🪟 🐧 - Serveur MCP pour rechercher et obtenir des informations à jour sur les paquets NPM, Cargo, PyPi et NuGet.

### 🔒 <a name="delivery"></a>Livraison

- [https://github.com/jordandalton/doordash-mcp-server](https://github.com/JordanDalton/DoorDash-MCP-Server) 🐍 – Livraison DoorDash (Non officiel)

### 🧮 <a name="data-science-tools"></a>Outils Data Science

Intégrations et outils conçus pour simplifier l’exploration et l’analyse de données et améliorer les workflows en science des données.

- [ChronulusAI/chronulus-mcp](https://github.com/ChronulusAI/chronulus-mcp) 🐍 ☁️ - Prédisez tout avec les agents de prévision et de prédiction Chronulus AI.
- [reading-plus-ai/mcp-server-data-exploration](https://github.com/reading-plus-ai/mcp-server-data-exploration) 🐍 ☁️ - Permet l’exploration autonome de jeux de données basés sur .csv, fournissant des analyses intelligentes avec un effort minimal.
- [zcaceres/markdownify-mcp](https://github.com/zcaceres/markdownify-mcp) 📇 🏠 - Un serveur MCP pour convertir presque tout fichier ou contenu web en Markdown
- [datalayer/jupyter-mcp-server](https://github.com/datalayer/jupyter-mcp-server) 🐍 🏠 - Serveur Model Context Protocol (MCP) pour Jupyter.
- [jjsantos01/jupyter-notebook-mcp](https://github.com/jjsantos01/jupyter-notebook-mcp) 🐍 🏠 - Connecte Jupyter Notebook à Claude AI, permettant à Claude d’interagir et de contrôler directement les notebooks Jupyter.
- [arrismo/kaggle-mcp](https://github.com/arrismo/kaggle-mcp) 🐍 ☁️ - Connecte à Kaggle, possibilité de télécharger et d’analyser des jeux de données.
- [kdqed/zaturn](https://github.com/kdqed/zaturn) 🐍 🏠 🪟 🐧 🍎 - Liez plusieurs sources de données (SQL, CSV, Parquet, etc.) et demandez à l’IA d’analyser les données pour obtenir des analyses et visualisations.
- [mckinsey/vizro-mcp](https://github.com/mckinsey/vizro/tree/main/vizro-mcp) 🎖️ 🐍 🏠 - Outils et modèles pour créer des graphiques et tableaux de bord de données validés et maintenables.
- [growthbook/growthbook-mcp](https://github.com/growthbook/growthbook-mcp) 🎖️ 📇 🏠 🪟 🐧 🍎 — Outils pour créer et interagir avec les feature flags et expériences GrowthBook.

### 📟 <a name="embedded-system"></a>Système Embarqué

Fournit l’accès à la documentation et aux raccourcis pour travailler sur des dispositifs embarqués.

- [horw/esp-mcp](https://github.com/horw/esp-mcp) 📟 - Workflow pour corriger les problèmes de build sur les puces de la série ESP32 avec ESP-IDF.
- [kukapay/modbus-mcp](https://github.com/kukapay/modbus-mcp) 🐍 📟 - Un serveur MCP qui standardise et contextualise les données industrielles Modbus.
- [kukapay/opcua-mcp](https://github.com/kukapay/opcua-mcp) 🐍 📟 - Un serveur MCP qui se connecte à des systèmes industriels compatibles OPC UA.
- [yoelbassin/gnuradioMCP](https://github.com/yoelbassin/gnuradioMCP) 🐍 📟 🏠 - Un serveur MCP pour GNU Radio qui permet aux LLM de créer et modifier de manière autonome des schémas RF `.grc`.

### 📂 <a name="file-systems"></a>Systèmes de Fichiers

Fournit un accès direct aux systèmes de fichiers locaux avec des autorisations configurables. Permet aux modèles IA de lire, écrire et gérer des fichiers dans des répertoires spécifiés.

- [cyberchitta/llm-context.py](https://github.com/cyberchitta/llm-context.py) 🐍 🏠 - Partagez le contexte du code avec les LLM via MCP ou presse-papiers
- [exoticknight/mcp-file-merger](https://github.com/exoticknight/mcp-file-merger) 🏎️ 🏠 - Outil de fusion de fichiers, adapté aux limites de longueur des chats IA.
- [filesystem@quarkiverse/quarkus-mcp-servers](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/filesystem) ☕ 🏠 - Un système de fichiers permettant la navigation et l’édition de fichiers, implémenté en Java avec Quarkus. Disponible en jar ou image native.
- [hmk/box-mcp-server](https://github.com/hmk/box-mcp-server) 📇 ☁️ - Intégration Box pour lister, lire et rechercher des fichiers
- [mamertofabian/mcp-everything-search](https://github.com/mamertofabian/mcp-everything-search) 🐍 🏠 🪟 - Recherche rapide de fichiers Windows à l’aide du SDK Everything
- [mark3labs/mcp-filesystem-server](https://github.com/mark3labs/mcp-filesystem-server) 🏎️ 🏠 - Implémentation Golang pour l’accès au système de fichiers local.
- [mickaelkerjean/filestash](https://github.com/mickael-kerjean/filestash/tree/master/server/plugin/plg_handler_mcp) 🏎️ ☁️ - Accès au stockage distant : SFTP, S3, FTP, SMB, NFS, WebDAV, GIT, FTPS, gcloud, azure blob, sharepoint, etc.
- [microsoft/markitdown](https://github.com/microsoft/markitdown/tree/main/packages/markitdown-mcp) 🎖️ 🐍 🏠 - Accès aux outils MCP pour MarkItDown -- une bibliothèque qui convertit de nombreux formats de fichiers (locaux ou distants) en Markdown pour la consommation par des LLM.
- [modelcontextprotocol/server-filesystem](https://github.com/modelcontextprotocol/servers/tree/main/src/filesystem) 📇 🏠 - Accès direct au système de fichiers local.
- [modelcontextprotocol/server-google-drive](https://github.com/modelcontextprotocol/servers/tree/main/src/gdrive) 📇 ☁️ - Intégration Google Drive pour lister, lire et rechercher des fichiers
- [Xuanwo/mcp-server-opendal](https://github.com/Xuanwo/mcp-server-opendal) 🐍 🏠 ☁️ - Accédez à tout stockage avec Apache OpenDAL™
- [jeannier/homebrew-mcp](https://github.com/jeannier/homebrew-mcp) 🐍 🏠 🍎 - Contrôlez votre configuration Homebrew macOS en langage naturel via ce serveur MCP. Gérez simplement vos paquets, demandez des suggestions, résolvez des problèmes avec brew, etc.

### 💰 <a name="finance--fintech"></a>Finance & Fintech

Outils d’accès et d’analyse de données financières. Permet aux modèles d’IA de travailler avec des données de marché, des plateformes de trading et des informations financières.

- [aaronjmars/web3-research-mcp](https://github.com/aaronjmars/web3-research-mcp) 📇 ☁️ - Recherche approfondie pour la crypto - gratuit & entièrement local
- [alchemy/alchemy-mcp-server](https://github.com/alchemyplatform/alchemy-mcp-server) 🎖️ 📇 ☁️ - Permet aux agents IA d’interagir avec les API blockchain d’Alchemy.
- [OctagonAI/octagon-mcp-server](https://github.com/OctagonAI/octagon-mcp-server) 🐍 ☁️ - Agents IA Octagon pour intégrer des données de marché publiques et privées
- [anjor/coinmarket-mcp-server](https://github.com/anjor/coinmarket-mcp-server) 🐍 ☁️ - Intégration de l’API Coinmarket pour récupérer des listes et cotations de cryptomonnaies
- [ariadng/metatrader-mcp-server](https://github.com/ariadng/metatrader-mcp-server) 🐍 🏠 🪟 - Permettre aux LLMs IA d’exécuter des transactions via la plateforme MetaTrader 5
- [armorwallet/armor-crypto-mcp](https://github.com/armorwallet/armor-crypto-mcp) 🐍 ☁️ - MCP pour interfacer plusieurs blockchains, staking, DeFi, swap, bridge, gestion de portefeuille, DCA, ordres limites, recherche de coins, suivi et plus encore.
- [bankless/onchain-mcp](https://github.com/Bankless/onchain-mcp/) 📇 ☁️ - API Bankless Onchain pour interagir avec les smart contracts, interroger les transactions et les informations sur les tokens
- [base/base-mcp](https://github.com/base/base-mcp) 🎖️ 📇 ☁️ - Intégration Base Network pour les outils onchain, permettant l’interaction avec Base Network et l’API Coinbase pour la gestion de portefeuille, transferts de fonds, smart contracts et opérations DeFi
- [berlinbra/alpha-vantage-mcp](https://github.com/berlinbra/alpha-vantage-mcp) 🐍 ☁️ - Intégration de l’API Alpha Vantage pour récupérer des informations sur les actions et la crypto
- [ahnlabio/bicscan-mcp](https://github.com/ahnlabio/bicscan-mcp) 🎖️ 🐍 ☁️ - Score de risque / détention d’actifs d’une adresse blockchain EVM (EOA, CA, ENS) et même noms de domaine.
- [bitteprotocol/mcp](https://github.com/BitteProtocol/mcp) 📇 - Intégration Bitte Protocol pour faire fonctionner des agents IA sur plusieurs blockchains.
- [chargebee/mcp](https://github.com/chargebee/agentkit/tree/main/modelcontextprotocol) 🎖️ 📇 ☁️ - Serveur MCP qui connecte les agents IA à la [plateforme Chargebee](https://www.chargebee.com/).
- [codex-data/codex-mcp](https://github.com/Codex-Data/codex-mcp) 🎖️ 📇 ☁️ - Intégration de l’[API Codex](https://www.codex.io) pour des données enrichies en temps réel sur la blockchain et le marché sur 60+ réseaux
- [coinpaprika/dexpaprika-mcp](https://github.com/chargebee/agentkit/tree/main/modelcontextprotocol) 🎖️ 📇 ☁️ 🍎 🪟 🐧 - Le serveur MCP DexPaprika de Coinpaprika expose l’API haute performance [DexPaprika](https://docs.dexpaprika.com) couvrant 20+ chaînes et 5M+ tokens avec des prix en temps réel, données de pool de liquidité & historiques OHLCV, fournissant aux agents IA un accès standardisé à des données de marché complètes via Model Context Protocol.
- [doggybee/mcp-server-ccxt](https://github.com/doggybee/mcp-server-ccxt) 📇 ☁️ - Un serveur MCP pour accéder aux données de marché crypto en temps réel et au trading via 20+ exchanges utilisant la bibliothèque CCXT. Prend en charge spot, futures, OHLCV, soldes, ordres, et plus.
- [ferdousbhai/investor-agent](https://github.com/ferdousbhai/investor-agent) 🐍 ☁️ - Intégration Yahoo Finance pour récupérer des données boursières, y compris des recommandations d’options
- [ferdousbhai/tasty-agent](https://github.com/ferdousbhai/tasty-agent) 🐍 ☁️ - Intégration de l’API Tastyworks pour gérer les activités de trading sur Tastytrade
- [ferdousbhai/wsb-analyst-mcp](https://github.com/ferdousbhai/wsb-analyst-mcp) 🐍 ☁️ - Intégration Reddit pour analyser le contenu de la communauté WallStreetBets
- [getalby/nwc-mcp-server](https://github.com/getalby/nwc-mcp-server) 📇 🏠 - Intégration d’un portefeuille Bitcoin Lightning alimentée par Nostr Wallet Connect
- [heurist-network/heurist-mesh-mcp-server](https://github.com/heurist-network/heurist-mesh-mcp-server) 🎖️ ⛅️ 🏠 🐍 - Accédez à des agents IA web3 spécialisés pour l’analyse blockchain, l’audit de sécurité de smart contracts, l’évaluation de métriques de tokens, et les interactions on-chain via le réseau Heurist Mesh. Offre des outils complets pour l’analyse DeFi, la valorisation NFT et la surveillance de transactions sur plusieurs blockchains
- [intentos-labs/beeper-mcp](https://github.com/intentos-labs/beeper-mcp) 🐍 - Beeper fournit des transactions sur BSC, incluant transferts de soldes/tokens, swaps de tokens sur Pancakeswap et réclamations de récompenses beeper.
- [kukapay/blockbeats-mcp](https://github.com/kukapay/blockbeats-mcp) 🐍 ☁️ -  Un serveur MCP qui diffuse les actualités blockchain et articles approfondis de BlockBeats pour les agents IA.
- [kukapay/bridge-rates-mcp](https://github.com/kukapay/bridge-rates-mcp) 📇 ☁️ - Diffusion en temps réel des taux cross-chain et des routes de transfert optimales pour les agents IA onchain.
- [kukapay/chainlink-feeds-mcp](https://github.com/kukapay/chainlink-feeds-mcp) 📇 ☁️ -  Accès en temps réel aux flux de prix décentralisés Chainlink.
- [kukapay/cointelegraph-mcp](https://github.com/kukapay/cointelegraph-mcp) 🐍 ☁️ -  Accès en temps réel aux dernières actualités de Cointelegraph.
- [kukapay/crypto-feargreed-mcp](https://github.com/kukapay/crypto-feargreed-mcp) 🐍 ☁️ -  Fourniture de données en temps réel et historiques de l’indice Crypto Fear & Greed.
- [kukapay/crypto-indicators-mcp](https://github.com/kukapay/crypto-indicators-mcp) 🐍 ☁️ - Un serveur MCP fournissant une gamme d’indicateurs d’analyse technique crypto et de stratégies.
- [kukapay/crypto-news-mcp](https://github.com/kukapay/crypto-news-mcp) 🐍 ☁️ - Un serveur MCP qui fournit des actualités crypto en temps réel issues de NewsData pour les agents IA.
- [kukapay/crypto-portfolio-mcp](https://github.com/kukapay/crypto-portfolio-mcp) 🐍 ☁️ - Un serveur MCP pour suivre et gérer les allocations de portefeuilles crypto.
- [kukapay/crypto-rss-mcp](https://github.com/kukapay/crypto-rss-mcp) 🐍 ☁️ - Un serveur MCP agrégeant en temps réel des actualités crypto depuis plusieurs flux RSS.
- [kukapay/crypto-sentiment-mcp](https://github.com/kukapay/crypto-sentiment-mcp) 🐍 ☁️ - Un serveur MCP qui fournit une analyse de sentiment sur la crypto aux agents IA.
- [kukapay/crypto-trending-mcp](https://github.com/kukapay/crypto-trending-mcp) 🐍 ☁️ - Suivi des tokens tendance sur CoinGecko.
- [kukapay/crypto-whitepapers-mcp](https://github.com/kukapay/crypto-whitepapers-mcp) 🐍 ☁️ - Sert de base de connaissance structurée des whitepapers crypto.
- [kukapay/cryptopanic-mcp-server](https://github.com/kukapay/cryptopanic-mcp-server) 🐍 ☁️ - Fournit les dernières actualités crypto aux agents IA, alimenté par CryptoPanic.
- [kukapay/defi-yields-mcp](https://github.com/kukapay/defi-yields-mcp) 🐍 ☁️ - Un serveur MCP pour permettre aux agents IA d’explorer les opportunités de rendement DeFi.
- [kukapay/dune-analytics-mcp](https://github.com/kukapay/dune-analytics-mcp) 🐍 ☁️ -  Un serveur MCP qui relie les données Dune Analytics aux agents IA.
- [kukapay/etf-flow-mcp](https://github.com/kukapay/etf-flow-mcp) 🐍 ☁️ -  Diffusion de données de flux ETF crypto pour alimenter la prise de décision des agents IA.
- [kukapay/freqtrade-mcp](https://github.com/kukapay/freqtrade-mcp) 🐍 ☁️ - Un serveur MCP qui s’intègre au bot de trading crypto Freqtrade.
- [kukapay/funding-rates-mcp](https://github.com/kukapay/funding-rates-mcp) 🐍 ☁️ - Fourniture de données de taux de financement en temps réel sur les principales plateformes crypto.
- [kukapay/jupiter-mcp](https://github.com/kukapay/jupiter-mcp) 🐍 ☁️ - Un serveur MCP pour exécuter des swaps de tokens sur la blockchain Solana via la nouvelle API Ultra de Jupiter.
- [kukapay/pancakeswap-poolspy-mcp](https://github.com/kukapay/pancakeswap-poolspy-mcp) 🐍 ☁️ -  Un serveur MCP qui suit les nouveaux pools créés sur Pancake Swap.
- [kukapay/rug-check-mcp](https://github.com/kukapay/rug-check-mcp) 🐍 ☁️ - Un serveur MCP qui détecte les risques potentiels sur les meme tokens Solana.
- [kukapay/thegraph-mcp](https://github.com/kukapay/thegraph-mcp) 🐍 ☁️ -  Un serveur MCP qui fournit aux agents IA des données blockchain indexées via The Graph.
- [kukapay/token-minter-mcp](https://github.com/kukapay/token-minter-mcp) 🐍 ☁️ -  Un serveur MCP fournissant des outils pour la création de tokens ERC-20 sur plusieurs blockchains.
- [kukapay/token-revoke-mcp](https://github.com/kukapay/token-revoke-mcp) 🐍 ☁️ - Un serveur MCP pour vérifier et révoquer les autorisations de tokens ERC-20 sur plusieurs blockchains.
- [kukapay/twitter-username-changes-mcp](https://github.com/kukapay/twitter-username-changes-mcp) 🐍 ☁️ - Un serveur MCP qui suit l’historique des changements de pseudonymes Twitter.
- [kukapay/uniswap-poolspy-mcp](https://github.com/kukapay/uniswap-poolspy-mcp) 🐍 ☁️ -  Un serveur MCP qui suit les nouveaux pools de liquidité créés sur Uniswap sur plusieurs blockchains.
- [kukapay/uniswap-trader-mcp](https://github.com/kukapay/uniswap-trader-mcp) 🐍 ☁️ -  Un serveur MCP pour permettre aux agents IA d’automatiser les swaps sur Uniswap DEX sur plusieurs blockchains.
- [kukapay/whale-tracker-mcp](https://github.com/kukapay/whale-tracker-mcp) 🐍 ☁️ -  Un serveur MCP pour suivre les transactions des whales crypto.
- [laukikk/alpaca-mcp](https://github.com/laukikk/alpaca-mcp) 🐍 ☁️ - Un serveur MCP pour l’API de trading Alpaca afin de gérer des portefeuilles actions et crypto, passer des ordres et accéder aux données de marché.
- [longportapp/openapi](https://github.com/longportapp/openapi/tree/main/mcp) - 🐍 ☁️ - LongPort OpenAPI fournit des données boursières en temps réel, permet l’analyse et le trading par l’IA via MCP.
- [mcpdotdirect/evm-mcp-server](https://github.com/mcpdotdirect/evm-mcp-server) 📇 ☁️ - Services blockchain complets pour 30+ réseaux EVM, prise en charge des tokens natifs, ERC20, NFT, smart contracts, transactions et résolution ENS.
- [mcpdotdirect/starknet-mcp-server](https://github.com/mcpdotdirect/starknet-mcp-server) 📇 ☁️ - Intégration complète de la blockchain Starknet avec support des tokens natifs (ETH, STRK), smart contracts, résolution StarknetID et transferts de tokens.
- [minhyeoky/mcp-server-ledger](https://github.com/minhyeoky/mcp-server-ledger) 🐍 🏠 -  Intégration ledger-cli pour gérer les transactions financières et générer des rapports.
- [openMF/mcp-mifosx](https://github.com/openMF/mcp-mifosx) ☁️ 🏠 -  Intégration bancaire cœur pour gérer clients, prêts, épargne, actions, transactions financières et générer des rapports financiers.
- [narumiruna/yfinance-mcp](https://github.com/narumiruna/yfinance-mcp) 🐍 ☁️ - Un serveur MCP qui utilise yfinance pour obtenir des informations depuis Yahoo Finance.
- [polygon-io/mcp_polygon)](https://github.com/polygon-io/mcp_polygon)) 🐍 ☁️ -  Un serveur MCP qui fournit l’accès aux API de données financières [Polygon.io](https://polygon.io/) pour actions, indices, forex, options, etc.
- [pwh-pwh/coin-mcp-server](https://github.com/pwh-pwh/coin-mcp-server) 🐍 ☁️ -  API Bitget pour récupérer le prix des cryptomonnaies.
- [QuantGeekDev/coincap-mcp](https://github.com/QuantGeekDev/coincap-mcp) 📇 ☁️ - Intégration en temps réel des données de marché crypto via l’API publique CoinCap, accès aux prix crypto et infos marché sans clé API
- [SaintDoresh/Crypto-Trader-MCP-ClaudeDesktop](https://github.com/SaintDoresh/Crypto-Trader-MCP-ClaudeDesktop.git) 🐍 ☁️ - Un outil MCP qui fournit des données de marché crypto via l’API CoinGecko.
- [tooyipjee/yahoofinance-mcp](https://github.com/tooyipjee/yahoofinance-mcp.git) 📇 ☁️ - Version TS du MCP Yahoo Finance.
- [SaintDoresh/YFinance-Trader-MCP-ClaudeDesktop](https://github.com/SaintDoresh/YFinance-Trader-MCP-ClaudeDesktop.git) 🐍 ☁️ - Un outil MCP qui fournit des données boursières et analyses via l’API Yahoo Finance.
- [RomThpt/xrpl-mcp-server](https://github.com/RomThpt/mcp-xrpl) 📇 ☁️ - Serveur MCP pour le XRP Ledger fournissant l’accès aux infos de compte, historique des transactions et données réseau. Permet de requêter des objets du ledger, soumettre des transactions et surveiller le réseau XRPL.
- [janswist/mcp-dexscreener](https://github.com/janswist/mcp-dexscreener) 📇 ☁️ - Prix de marché on-chain en temps réel via l’API Dexscreener ouverte et gratuite
- [HuggingAGI/mcp-baostock-server](https://github.com/HuggingAGI/mcp-baostock-server) 🐍 ☁️ - Serveur MCP basé sur baostock, fournissant accès et analyse des données boursières chinoises.
- [wowinter13/solscan-mcp](https://github.com/wowinter13/solscan-mcp) 🦀 🏠 - Un outil MCP pour interroger les transactions Solana en langage naturel via l’API Solscan.
- [Wuye-AI/mcp-server-wuye-ai](https://github.com/wuye-ai/mcp-server-wuye-ai) 🎖️ 📇 ☁️ - Un serveur MCP qui interagit avec la plateforme CRIC Wuye AI, assistant intelligent dédié à la gestion immobilière.
- [zlinzzzz/finData-mcp-server](https://github.com/zlinzzzz/finData-mcp-server) 🐍 ☁️ - Un serveur MCP pour accéder à des données financières professionnelles, prenant en charge plusieurs fournisseurs comme Tushare.

### 🎮 <a name="gaming"></a>Jeux vidéo

Intégration avec des données liées aux jeux, moteurs de jeu et services

- [IvanMurzak/Unity-MCP](https://github.com/IvanMurzak/Unity-MCP) #️⃣ 🏠 🍎 🪟 🐧 - Serveur MCP pour l’éditeur Unity et pour un jeu développé avec Unity
- [CoderGamester/mcp-unity](https://github.com/CoderGamester/mcp-unity) #️⃣ 🏠 - Serveur MCP pour l’intégration du moteur de jeu Unity3d pour le développement de jeux
- [Coding-Solo/godot-mcp](https://github.com/Coding-Solo/godot-mcp) 📇 🏠 - Serveur MCP pour interagir avec le moteur de jeu Godot, fournissant des outils pour éditer, lancer, déboguer et gérer les scènes de projets Godot.
- [pab1ito/chess-mcp](https://github.com/pab1it0/chess-mcp) 🐍 ☁️ - Accédez aux données de joueurs Chess.com, historiques de parties et autres infos publiques via des interfaces MCP standardisées, permettant aux assistants IA de rechercher et analyser des informations sur les échecs.
- [jiayao/mcp-chess](https://github.com/jiayao/mcp-chess) 🐍 🏠 - Serveur MCP jouant aux échecs contre des LLMs.
- [rishijatia/fantasy-pl-mcp](https://github.com/rishijatia/fantasy-pl-mcp/) 🐍 ☁️ - Un serveur MCP pour les données en temps réel de la Fantasy Premier League et des outils d’analyse.
- [opgginc/opgg-mcp](https://github.com/opgginc/opgg-mcp) 📇 ☁️ - Accès aux données de jeux en temps réel pour des titres populaires comme League of Legends, TFT et Valorant, proposant analyses de champions, calendriers esport, compositions meta et statistiques de personnages.
- [stefan-xyz/mcp-server-runescape](https://github.com/stefan-xyz/mcp-server-runescape) 📇 - Un serveur MCP avec des outils pour interagir avec les données RuneScape (RS) et Old School RuneScape (OSRS), incluant prix des objets, hiscores joueurs, etc.

### 🧠 <a name="knowledge--memory"></a>Savoir & Mémoire

Stockage mémoire persistant utilisant des structures de graphe de connaissances. Permet aux modèles IA de maintenir et interroger des informations structurées entre les sessions.
- [CheMiguel23/MemoryMesh](https://github.com/CheMiguel23/MemoryMesh) 📇 🏠 - Mémoire améliorée basée sur les graphes, axée sur le jeu de rôle IA et la génération d'histoires
- [graphlit-mcp-server](https://github.com/graphlit/graphlit-mcp-server) 📇 ☁️ - Ingérez tout depuis Slack, Discord, des sites web, Google Drive, Linear ou GitHub dans un projet Graphlit – puis recherchez et récupérez les connaissances pertinentes dans un client MCP comme Cursor, Windsurf ou Cline.
- [hannesrudolph/mcp-ragdocs](https://github.com/hannesrudolph/mcp-ragdocs) 🐍 🏠 - Une implémentation de serveur MCP fournissant des outils pour récupérer et traiter la documentation via la recherche vectorielle, permettant aux assistants IA d'augmenter leurs réponses avec le contexte documentaire pertinent.
- [jinzcdev/markmap-mcp-server](https://github.com/jinzcdev/markmap-mcp-server) 📇 🏠 - Un serveur MCP basé sur [markmap](https://github.com/markmap/markmap) qui convertit le **Markdown** en **cartes heuristiques** interactives. Prise en charge de l'exportation multi-format (PNG/JPG/SVG), aperçu en direct dans le navigateur, copie Markdown en un clic, et fonctionnalités de visualisation dynamique.
- [kaliaboi/mcp-zotero](https://github.com/kaliaboi/mcp-zotero) 📇 ☁️ - Un connecteur pour permettre aux LLM de travailler avec les collections et sources sur votre Zotero Cloud
- [mcp-summarizer](https://github.com/0xshellming/mcp-summarizer) 📕 ☁️ - Serveur MCP de résumé par IA, prise en charge de plusieurs types de contenus : texte brut, pages web, documents PDF, livres EPUB, contenu HTML
- [mem0ai/mem0-mcp](https://github.com/mem0ai/mem0-mcp) 🐍 🏠 - Un serveur Model Context Protocol pour Mem0 qui aide à gérer les préférences et modèles de codage, fournissant des outils pour stocker, récupérer et manipuler sémantiquement des implémentations de code, meilleures pratiques et documentation technique dans des IDE comme Cursor et Windsurf
- [modelcontextprotocol/server-memory](https://github.com/modelcontextprotocol/servers/tree/main/src/memory) 📇 🏠 - Système de mémoire persistante basé sur un graphe de connaissances pour le maintien du contexte
- [pinecone-io/assistant-mcp](https://github.com/pinecone-io/assistant-mcp) 🎖️ 🦀 ☁️ - Se connecte à votre Assistant Pinecone et fournit à l'agent le contexte de son moteur de connaissances.
- [@ragieai/mcp-server](https://github.com/ragieai/ragie-mcp-server) 📇 ☁️ - Récupère du contexte depuis votre base de connaissances [Ragie](https://www.ragie.ai) (RAG) connectée à des intégrations comme Google Drive, Notion, JIRA et plus encore.
- [TechDocsStudio/biel-mcp](https://github.com/TechDocsStudio/biel-mcp) 📇 ☁️ - Permet à des outils IA comme Cursor, VS Code ou Claude Desktop de répondre à des questions à partir de la documentation de votre produit. Biel.ai fournit le système RAG et le serveur MCP.
- [topoteretes/cognee](https://github.com/topoteretes/cognee/tree/dev/cognee-mcp) 📇 🏠 - Gestionnaire de mémoire pour applications et agents IA utilisant différents magasins de graphes et vecteurs, et permettant l’ingestion à partir de plus de 30 sources de données
- [unibaseio/membase-mcp](https://github.com/unibaseio/membase-mcp) 📇 ☁️ - Sauvegarde et interrogation de la mémoire de l’agent de façon distribuée grâce à Membase
- [GistPad-MCP](https://github.com/lostintangent/gistpad-mcp) 📇 🏠 - Utilisez GitHub Gists pour gérer et accéder à vos connaissances personnelles, notes quotidiennes, et prompts réutilisables. Cela agit comme un compagnon pour https://gistpad.dev et l’[extension GistPad pour VS Code](https://aka.ms/gistpad).
- [entanglr/zettelkasten-mcp](https://github.com/entanglr/zettelkasten-mcp) 🐍 🏠 - Un serveur Model Context Protocol (MCP) qui implémente la méthodologie de gestion des connaissances Zettelkasten, permettant de créer, lier et rechercher des notes atomiques via Claude et d’autres clients compatibles MCP.

### 🗺️ <a name="location-services"></a>Services de Localisation

Services basés sur la localisation et outils de cartographie. Permet aux modèles IA de travailler avec des données géographiques, des informations météorologiques et de l’analytique géolocalisée.

- [briandconnelly/mcp-server-ipinfo](https://github.com/briandconnelly/mcp-server-ipinfo) 🐍 ☁️  - Géolocalisation d’adresse IP et informations réseau via l’API IPInfo
- [devilcoder01/weather-mcp-server](https://github.com/devilcoder01/weather-mcp-server) 🐍 ☁️ - Accès aux données météorologiques en temps réel pour n’importe quel lieu via l’API WeatherAPI.com, fournissant des prévisions détaillées et les conditions actuelles.
- [jagan-shanmugam/open-streetmap-mcp](https://github.com/jagan-shanmugam/open-streetmap-mcp) 🐍 🏠 - Un serveur MCP OpenStreetMap avec services de localisation et données géospatiales.
- [kukapay/nearby-search-mcp](https://github.com/kukapay/nearby-search-mcp) 🐍 ☁️ - Un serveur MCP pour la recherche de lieux à proximité avec détection de localisation basée sur IP.
- [modelcontextprotocol/server-google-maps](https://github.com/modelcontextprotocol/servers/tree/main/src/google-maps) 📇 ☁️ - Intégration Google Maps pour les services de localisation, itinéraires et détails sur les lieux
- [QGIS MCP](https://github.com/jjsantos01/qgis_mcp) - Connecte QGIS Desktop à Claude AI via le MCP. Cette intégration permet la création assistée de projet, le chargement de couches, l’exécution de code, et plus encore.
- [SaintDoresh/Weather-MCP-ClaudeDesktop](https://github.com/SaintDoresh/Weather-MCP-ClaudeDesktop.git) 🐍 ☁️ - Un outil MCP fournissant données météo en temps réel, prévisions et historiques via l’API OpenWeatherMap.
- [rossshannon/Weekly-Weather-mcp](https://github.com/rossshannon/weekly-weather-mcp.git) 🐍 ☁️ - Serveur MCP météo hebdomadaire qui retourne 7 jours complets de prévisions détaillées partout dans le monde.
- [SecretiveShell/MCP-timeserver](https://github.com/SecretiveShell/MCP-timeserver) 🐍 🏠 - Accédez à l’heure dans n’importe quel fuseau horaire et récupérez l’heure locale actuelle
- [TimLukaHorstmann/mcp-weather](https://github.com/TimLukaHorstmann/mcp-weather) 📇 ☁️  - Prévisions météo précises via l’API AccuWeather (niveau gratuit disponible).
- [webcoderz/MCP-Geo](https://github.com/webcoderz/MCP-Geo) 🐍 🏠 - Serveur MCP de géocodage pour nominatim, ArcGIS, Bing
- [ipfind/ipfind-mcp-server](https://github.com/ipfind/ipfind-mcp-server) 🐍 ☁️ - Service de localisation d’adresse IP utilisant l’API [IP Find](https://ipfind.com)
- [mahdin75/geoserver-mcp](https://github.com/mahdin75/geoserver-mcp) 🏠 – Une implémentation de serveur Model Context Protocol (MCP) qui connecte les LLM à l’API REST GeoServer, permettant aux assistants IA d’interagir avec des données et services géospatiaux.
- [ipfred/aiwen-mcp-server-geoip](https://github.com/ipfred/aiwen-mcp-server-geoip) 🐍 📇 ☁️ – Serveur MCP pour Aiwen IP Location, obtenez la localisation IP réseau de l’utilisateur, les détails IP (pays, province, ville, lat, lon, FAI, propriétaire, etc.)

### 🎯 <a name="marketing"></a>Marketing

Outils pour la création et l’édition de contenus marketing, la gestion des méta-données web, le positionnement produit et les guides éditoriaux.

- [gomarble-ai/facebook-ads-mcp-server](https://github.com/gomarble-ai/facebook-ads-mcp-server) 🐍 ☁️ - Serveur MCP servant d’interface aux Facebook Ads, permettant un accès programmatique aux données et fonctionnalités de gestion des publicités Facebook.
- [open-strategy-partners/osp_marketing_tools](https://github.com/open-strategy-partners/osp_marketing_tools) 🐍 🏠 - Suite d’outils marketing d’Open Strategy Partners incluant style rédactionnel, codes éditoriaux, et création de carte de valeur produit.
- [nictuku/meta-ads-mcp](https://github.com/nictuku/meta-ads-mcp) 🐍 ☁️ 🏠 - Permet aux agents IA de surveiller et optimiser la performance publicitaire Meta, analyser les métriques de campagne, ajuster le ciblage, gérer les créations, et formuler des recommandations sur le budget et la configuration via intégration Graph API transparente.
- [marketplaceadpros/amazon-ads-mcp-server](https://github.com/MarketplaceAdPros/amazon-ads-mcp-server) 📇 ☁️  - Permet aux outils d’interagir avec Amazon Advertising, analyse des métriques de campagne et des configurations.

### 📊 <a name="monitoring"></a>Supervision

Accédez et analysez les données de supervision applicative. Permet aux modèles IA d’examiner les rapports d’erreur et les métriques de performance.

- [netdata/netdata#Netdata](https://github.com/netdata/netdata/blob/master/src/web/mcp/README.md) 🎖️ 🏠 ☁️ 📟 🍎 🪟 🐧 - Découverte, exploration, reporting et analyse des causes racines à partir de toutes les données d’observabilité, y compris métriques, logs, systèmes, conteneurs, processus et connexions réseau
- [grafana/mcp-grafana](https://github.com/grafana/mcp-grafana) 🎖️ 🐍 🏠 ☁️ - Recherche de tableaux de bord, investigation d’incidents et requêtes sur les sources de données dans votre instance Grafana
- [tumf/grafana-loki-mcp](https://github.com/tumf/grafana-loki-mcp) 🐍 🏠 - Un serveur MCP permettant d’interroger les logs Loki via l’API Grafana.
- [hyperb1iss/lucidity-mcp](https://github.com/hyperb1iss/lucidity-mcp) 🐍 🏠 - Améliore la qualité du code généré par l’IA par une analyse intelligente et basée sur prompts sur 10 dimensions critiques de la complexité aux vulnérabilités de sécurité
- [last9/last9-mcp-server](https://github.com/last9/last9-mcp-server) - Apporte sans couture le contexte de production en temps réel — logs, métriques et traces — dans votre environnement local pour corriger le code plus rapidement
- [metoro-io/metoro-mcp-server](https://github.com/metoro-io/metoro-mcp-server) 🎖️ 🏎️ ☁️ - Interrogez et interagissez avec des environnements Kubernetes supervisés par Metoro
- [MindscapeHQ/server-raygun](https://github.com/MindscapeHQ/mcp-server-raygun) 📇 ☁️ - Intégration Raygun API V3 pour le reporting de crash et la supervision utilisateur réelle
- [modelcontextprotocol/server-sentry](https://github.com/modelcontextprotocol/servers/tree/main/src/sentry) 🐍 ☁️ - Intégration Sentry.io pour le suivi des erreurs et la surveillance des performances
- [pydantic/logfire-mcp](https://github.com/pydantic/logfire-mcp) 🎖️ 🐍 ☁️ - Fournit l’accès aux traces et métriques OpenTelemetry via Logfire
- [seekrays/mcp-monitor](https://github.com/seekrays/mcp-monitor) 🏎️ 🏠 - Outil de supervision système exposant les métriques système via le Model Context Protocol (MCP). Permet aux LLM de récupérer les infos système en temps réel via une interface MCP-compatible. (support CPU, Mémoire, Disque, Réseau, Hôte, Processus)
- [VictoriaMetrics-Community/mcp-victoriametrics](https://github.com/VictoriaMetrics-Community/mcp-victoriametrics) 🎖️ 🏎️ 🏠 - Fournit une intégration complète avec vos [APIs VictoriaMetrics](https://docs.victoriametrics.com/victoriametrics/url-examples/) et [documentation](https://docs.victoriametrics.com/) pour les tâches de supervision, d’observabilité et de débogage liées à vos instances VictoriaMetrics

### 🎥 <a name="multimedia-process"></a>Traitement Multimédia

Fournit la capacité de traiter du multimédia, comme le montage audio et vidéo, la lecture, la conversion de format, inclut aussi les filtres vidéo, les améliorations, etc.

- [video-creator/ffmpeg-mcp](https://github.com/video-creator/ffmpeg-mcp.git) 🎥 🔊 - Utilise la ligne de commande ffmpeg pour réaliser un serveur MCP. Permet, via le dialogue, la recherche, découpage, assemblage, lecture locale de vidéos et autres fonctions.
- [stass/exif-mcp](https://github.com/stass/exif-mcp) 📇 🏠 🐧 🍎 🪟 - Un serveur MCP permettant d’examiner les métadonnées d’image comme EXIF, XMP, JFIF et GPS. Cela offre une base pour la recherche et l’analyse de bibliothèques et collections d’images assistée par LLM.
- [sunriseapps/imagesorcery-mcp](https://github.com/sunriseapps/imagesorcery-mcp) 🐍 🏠 🐧 🍎 🪟 - Sorcellerie basée sur la Computer Vision 🪄 pour la reconnaissance et l’édition d’image pour les assistants IA.

### 🔎 <a name="search"></a>Recherche & Extraction de Données

- [Xyber-Labs/mcp-server-youtube](https://github.com/Xyber-Labs/mcp-servers/tree/main/mcp-server-youtube) 🐍 ☁️ - Ce dépôt implémente un serveur MCP (Model Context Protocol) pour la recherche YouTube et la récupération de transcription. Permet aux modèles de langage ou autres agents d’interroger aisément le contenu YouTube via un protocole standardisé.
- [ricocf/mcp-wolframalpha](https://github.com/ricocf/mcp-wolframalpha) 🐍 🏠 ☁️ - Un serveur MCP permettant aux assistants IA d’utiliser l’API Wolfram Alpha pour un accès temps réel à la connaissance computationnelle et aux données.
- [scrapeless-ai/scrapeless-mcp-server](https://github.com/scrapeless-ai/scrapeless-mcp-server) 🐍 ☁️ - Le service Scrapeless Model Context Protocol agit comme connecteur serveur MCP à l’API Google SERP, permettant la recherche web dans l’écosystème MCP sans en sortir.
- [0xdaef0f/job-searchoor](https://github.com/0xDAEF0F/job-searchoor) 📇 🏠 - Serveur MCP pour la recherche d’annonces d’emploi avec filtres sur date, mots-clés, options télétravail, etc.
- [ac3xx/mcp-servers-kagi](https://github.com/ac3xx/mcp-servers-kagi) 📇 ☁️ - Intégration API de recherche Kagi
- [andybrandt/mcp-simple-arxiv](https://github.com/andybrandt/mcp-simple-arxiv) - 🐍 ☁️  MCP pour que le LLM recherche et lise des articles sur arXiv
- [hbg/mcp-paperswithcode](https://github.com/hbg/mcp-paperswithcode) - 🐍 ☁️ MCP pour rechercher via l’API PapersWithCode
- [andybrandt/mcp-simple-pubmed](https://github.com/andybrandt/mcp-simple-pubmed) - 🐍 ☁️  MCP pour rechercher et lire des articles scientifiques/biomédicaux sur PubMed.
- [angheljf/nyt](https://github.com/angheljf/nyt) 📇 ☁️ - Recherche d’articles via l’API NYTimes
- [apify/mcp-server-rag-web-browser](https://github.com/apify/mcp-server-rag-web-browser) 📇 ☁️ - Serveur MCP pour l’acteur RAG Web Browser open source d’Apify pour effectuer des recherches web, scraper des URLs et retourner du contenu en Markdown.
- [Bigsy/Clojars-MCP-Server](https://github.com/Bigsy/Clojars-MCP-Server) 📇 ☁️ - Serveur MCP Clojars pour informations de dépendances à jour des bibliothèques Clojure
- [blazickjp/arxiv-mcp-server](https://github.com/blazickjp/arxiv-mcp-server) ☁️ 🐍 - Recherche d’articles de recherche ArXiv
- [luminati-io/brightdata-mcp](https://github.com/luminati-io/brightdata-mcp) 📇 ☁️ - Découverte, extraction et interaction avec le web – une interface unique pour un accès automatisé à tout Internet public.
- [chanmeng/google-news-mcp-server](https://github.com/ChanMeng666/server-google-news) 📇 ☁️ - Intégration Google News avec catégorisation automatique des sujets, multilingue, et recherche complète (titres, articles, sujets associés) via [SerpAPI](https://serpapi.com/).
- [ConechoAI/openai-websearch-mcp](https://github.com/ConechoAI/openai-websearch-mcp/) 🐍 🏠 ☁️ - Serveur MCP Python fournissant l’outil intégré `web_search` d’OpenAI.
- [dealx/mcp-server](https://github.com/DealExpress/mcp-server) ☁️ - Serveur MCP pour la plateforme DealX
- [devflowinc/trieve](https://github.com/devflowinc/trieve/tree/main/clients/mcp-server) 🎖️ 📇 ☁️ 🏠 - Exploration, intégration, découpage, recherche et récupération d’informations sur des datasets via [Trieve](https://trieve.ai)
- [Dumpling-AI/mcp-server-dumplingai](https://github.com/Dumpling-AI/mcp-server-dumplingai) 🎖️ 📇 ☁️ - Accès aux APIs de données, scraping web et conversion de documents par [Dumpling AI](https://www.dumplingai.com/)
- [erithwik/mcp-hn](https://github.com/erithwik/mcp-hn) 🐍 ☁️ - Serveur MCP pour rechercher sur Hacker News, obtenir les meilleures actualités, etc.
- [exa-labs/exa-mcp-server](https://github.com/exa-labs/exa-mcp-server) 🎖️ 📇 ☁️ – Un serveur Model Context Protocol (MCP) permettant aux assistants IA comme Claude d’utiliser l’API Exa AI Search pour la recherche web. Cette solution permet aux modèles IA d’obtenir des informations web en temps réel de manière sûre et contrôlée.
- [fatwang2/search1api-mcp](https://github.com/fatwang2/search1api-mcp) 📇 ☁️ - Recherche via search1api (clé API payante requise)
- [genomoncology/biomcp](https://github.com/genomoncology/biomcp) 🐍 ☁️ - Serveur de recherche biomédicale donnant accès à PubMed, ClinicalTrials.gov et MyVariant.info.
- [hellokaton/unsplash-mcp-server](https://github.com/hellokaton/unsplash-mcp-server)) 🐍 ☁️ - Serveur MCP pour la recherche d’images Unsplash.
- [Ihor-Sokoliuk/MCP-SearXNG](https://github.com/ihor-sokoliuk/mcp-searxng) 📇 🏠/☁️ - Serveur Model Context Protocol pour [SearXNG](https://docs.searxng.org)
- [isnow890/naver-search-mcp](https://github.com/isnow890/naver-search-mcp) 📇 ☁️ - Serveur MCP pour l’intégration Naver Search API, supporte la recherche blog, actualités, shopping et fonctionnalités analytiques DataLab.
- [jae-jae/fetcher-mcp](https://github.com/jae-jae/fetcher-mcp) 📇 🏠 - Serveur MCP pour extraire le contenu de pages web via Playwright headless browser, avec rendu Javascript, extraction intelligente et sortie Markdown ou HTML.
- [jae-jae/g-search-mcp](https://github.com/jae-jae/g-search-mcp) 📇 🏠 - Serveur MCP puissant pour la recherche Google permettant la recherche simultanée avec plusieurs mots-clés.
- [ananddtyagi/webpage-screenshot-mcp](https://github.com/ananddtyagi/webpage-screenshot-mcp) 📇 🏠 - Serveur MCP pour la capture d’écran de pages web à utiliser comme feedback lors du développement UI.
- [leehanchung/bing-search-mcp](https://github.com/leehanchung/bing-search-mcp) 📇 ☁️ - Capacités de recherche web via l’API Microsoft Bing Search
- [kagisearch/kagimcp](https://github.com/kagisearch/kagimcp) ☁️ 📇 – Serveur MCP officiel pour la recherche Kagi
- [kshern/mcp-tavily](https://github.com/kshern/mcp-tavily.git) ☁️ 📇 – API de recherche Tavily AI
- [mikechao/brave-search-mcp](https://github.com/mikechao/brave-search-mcp) 📇 ☁️ - Capacités de recherche Web, Image, Actualités, Vidéo et Points d’Intérêt locaux à l’aide de l’API Brave Search
- [emicklei/melrose-mcp](https://github.com/emicklei/melrose-mcp) 🏎️ 🏠 - Joue des expressions musicales [Melrōse](https://melrōse.org) en tant que MIDI
- [modelcontextprotocol/server-brave-search](https://github.com/modelcontextprotocol/servers/tree/main/src/brave-search) 📇 ☁️ - Capacités de recherche Web via l’API Brave Search
- [modelcontextprotocol/server-fetch](https://github.com/modelcontextprotocol/servers/tree/main/src/fetch) 🐍 🏠 ☁️ - Récupération et traitement efficaces de contenu web pour la consommation par l’IA
- [mzxrai/mcp-webresearch](https://github.com/mzxrai/mcp-webresearch) 🔍📚 - Recherche sur Google et exploration approfondie du web sur n’importe quel sujet
- [nickclyde/duckduckgo-mcp-server](https://github.com/nickclyde/duckduckgo-mcp-server) 🐍 ☁️ - Recherche Web utilisant DuckDuckGo
- [r-huijts/opentk-mcp](https://github.com/r-huijts/opentk-mcp) 📇 ☁️ - Accès aux informations du Parlement néerlandais (Tweede Kamer), incluant documents, débats, activités et cas législatifs via des capacités de recherche structurées (basé sur le projet opentk de Bert Hubert)
- [reading-plus-ai/mcp-server-deep-research](https://github.com/reading-plus-ai/mcp-server-deep-research) 📇 ☁️ - Serveur MCP fournissant une recherche approfondie autonome de type OpenAI/Perplexity, élaboration de requêtes structurées et rapports concis.
- [SecretiveShell/MCP-searxng](https://github.com/SecretiveShell/MCP-searxng) 🐍 🏠 - Un serveur MCP pour se connecter à des instances searXNG
- [takashiishida/arxiv-latex-mcp](https://github.com/takashiishida/arxiv-latex-mcp) 🐍 ☁️ - Obtenez la source LaTeX des articles arXiv pour gérer le contenu et les équations mathématiques
- [the0807/GeekNews-MCP-Server](https://github.com/the0807/GeekNews-MCP-Server) 🐍 ☁️ - Un serveur MCP qui récupère et traite les données d’actualités du site GeekNews.
- [tinyfish-io/agentql-mcp](https://github.com/tinyfish-io/agentql-mcp) 🎖️ 📇 ☁️ - Serveur MCP offrant les capacités d’extraction de données d’[AgentQL](https://agentql.com).
- [Tomatio13/mcp-server-tavily](https://github.com/Tomatio13/mcp-server-tavily) ☁️ 🐍 – API de recherche Tavily AI
- [vectorize-io/vectorize-mcp-server](https://github.com/vectorize-io/vectorize-mcp-server/) ☁️ 📇 - Serveur MCP [Vectorize](https://vectorize.io) pour la recherche avancée, la recherche approfondie privée, l’extraction de fichiers Anything-to-Markdown et le découpage de texte.
- [webscraping-ai/webscraping-ai-mcp-server](https://github.com/webscraping-ai/webscraping-ai-mcp-server) 🎖️ 📇 ☁️ - Interagissez avec [WebScraping.ai](https://webscraping.ai) pour l’extraction et le scraping de données web.
- [zhsama/duckduckgo-mcp-server](https://github.com/zhsama/duckduckgo-mpc-server/) 📇 🏠 ☁️ - Serveur MCP basé sur TypeScript offrant la fonctionnalité de recherche DuckDuckGo.
- [zoomeye-ai/mcp_zoomeye](https://github.com/zoomeye-ai/mcp_zoomeye) 📇 ☁️ - Recherche d’informations sur les actifs réseau via le serveur ZoomEye MCP
- [yamanoku/baseline-mcp-server](https://github.com/yamanoku/baseline-mcp-server) 📇 🏠 - Serveur MCP qui recherche l’état de Baseline à l’aide de Web Platform API
- [longevity-genie/biothings-mcp](https://github.com/longevity-genie/biothings-mcp) 🐍 ☁️ - Serveur MCP pour interagir avec l’API BioThings, incluant les gènes, variants génétiques, médicaments et informations taxonomiques
- [joelio/stocky](https://github.com/joelio/stocky) 🐍 ☁️ 🏠 - Un serveur MCP pour la recherche et le téléchargement de photographies libres de droits depuis Pexels et Unsplash. Prend en charge la recherche multi-fournisseur, les métadonnées enrichies, la pagination et les performances asynchrones pour permettre aux assistants IA de trouver et accéder à des images de haute qualité.

### 🔒 <a name="security"></a>Sécurité

- [LaurieWired/GhidraMCP](https://github.com/LaurieWired/GhidraMCP) ☕ 🏠 - Un serveur Model Context Protocol pour Ghidra qui permet aux LLMs d’effectuer de l’ingénierie inverse de façon autonome. Fournit des outils pour décompiler des binaires, renommer des méthodes et données, et lister méthodes, classes, imports et exports.
- [dkvdm/onepassword-mcp-server](https://github.com/dkvdm/onepassword-mcp-server) - Un serveur MCP permettant la récupération sécurisée d’identifiants depuis 1Password à utiliser par une IA agentique.
- [firstorderai/authenticator_mcp](https://github.com/firstorderai/authenticator_mcp) 📇 🏠 🍎 🪟 🐧 – Un serveur MCP sécurisé (Model Context Protocol) permettant aux agents IA d’interagir avec l’application Authenticator.
- [13bm/GhidraMCP](https://github.com/13bm/GhidraMCP) 🐍 ☕ 🏠 - Serveur MCP pour intégrer Ghidra avec des assistants IA. Ce plugin permet l’analyse binaire, l’inspection de fonctions, la décompilation, l’exploration mémoire, et l’analyse des imports/exports via le Model Context Protocol.
- [atomicchonk/roadrecon_mcp_server](https://github.com/atomicchonk/roadrecon_mcp_server) 🐍 🪟 🏠 Serveur MCP pour l’analyse des résultats ROADrecon issus de l’énumération de locataires Azure
- [BurtTheCoder/mcp-dnstwist](https://github.com/BurtTheCoder/mcp-dnstwist) 📇 🪟 ☁️ - Serveur MCP pour dnstwist, un puissant outil de fuzzing DNS qui aide à détecter le typosquatting, le phishing et l’espionnage industriel.
- [BurtTheCoder/mcp-maigret](https://github.com/BurtTheCoder/mcp-maigret) 📇 🪟 ☁️ - Serveur MCP pour maigret, un puissant outil OSINT qui collecte des informations sur les comptes utilisateurs à partir de diverses sources publiques. Ce serveur offre des outils pour rechercher des noms d’utilisateur sur les réseaux sociaux et analyser des URLs.
- [BurtTheCoder/mcp-shodan](https://github.com/BurtTheCoder/mcp-shodan) 📇 🪟 ☁️ - Serveur MCP pour interroger l’API Shodan et Shodan CVEDB. Ce serveur propose des outils pour la recherche d’IP, d’appareils, de DNS, de vulnérabilités, de CPE, et plus encore.
- [BurtTheCoder/mcp-virustotal](https://github.com/BurtTheCoder/mcp-virustotal) 📇 🪟 ☁️ - Serveur MCP pour interroger l’API VirusTotal. Ce serveur permet l’analyse d’URL, l’analyse de hash de fichiers et la récupération de rapports d’adresses IP.
- [fosdickio/binary_ninja_mcp](https://github.com/fosdickio/binary_ninja_mcp) 🐍 🏠 🍎 🪟 🐧 - Un plugin Binary Ninja, serveur MCP et passerelle qui intègre [Binary Ninja](https://binary.ninja) avec votre client MCP préféré. Permet d’automatiser l’analyse binaire et l’ingénierie inverse.
- [fr0gger/MCP_Security](https://github.com/fr0gger/MCP_Security) 📇 ☁️ - Serveur MCP pour interroger l’API ORKL. Permet de récupérer des rapports de menaces, analyser des acteurs de menaces, et récupérer des sources de renseignement.
- [gbrigandi/mcp-server-cortex](https://github.com/gbrigandi/mcp-server-cortex) 🦀 🏠 🚨 🍎 🪟 🐧 - Serveur MCP en Rust pour intégrer Cortex, permettant l’analyse d’observables et des réponses automatisées aux incidents par IA.
- [gbrigandi/mcp-server-thehive](https://github.com/gbrigandi/mcp-server-thehive) 🦀 🏠 🚨 🍎 🪟 🐧 - Serveur MCP en Rust pour intégrer TheHive, facilitant la gestion collaborative des incidents de sécurité et des dossiers via IA.
- [gbrigandi/mcp-server-wazuh](https://github.com/gbrigandi/mcp-server-wazuh) 🦀 🏠 🚨 🍎 🪟 🐧 - Serveur MCP en Rust faisant le lien entre Wazuh SIEM et les assistants IA, fournissant des alertes de sécurité et des données d’événements en temps réel pour une meilleure compréhension contextuelle.
- [intruder-io/intruder-mcp](https://github.com/intruder-io/intruder-mcp) 🐍 ☁️ - Serveur MCP pour accéder à [Intruder](https://www.intruder.io/), aidant à identifier, comprendre et corriger les vulnérabilités de sécurité de votre infrastructure.
- [jyjune/mcp_vms](https://github.com/jyjune/mcp_vms) 🐍 🏠 🪟 - Un serveur MCP (Model Context Protocol) conçu pour se connecter à un programme d’enregistrement CCTV (VMS) afin de récupérer des flux vidéo enregistrés et en direct. Fournit aussi des outils pour contrôler le logiciel VMS, comme l’affichage de flux live ou de relecture pour des canaux et horaires spécifiques.
- [qianniuspace/mcp-security-audit](https://github.com/qianniuspace/mcp-security-audit) 📇 ☁️ Un puissant serveur MCP (Model Context Protocol) qui audite les dépendances npm pour les vulnérabilités de sécurité. Intégration avec le registre npm distant pour des contrôles de sécurité en temps réel.
- [semgrep/mcp](https://github.com/semgrep/mcp) 📇 ☁️ Permet aux agents IA de scanner le code à la recherche de vulnérabilités de sécurité en utilisant [Semgrep](https://semgrep.dev).
- [slouchd/cyberchef-api-mcp-server](https://github.com/slouchd/cyberchef-api-mcp-server) 🐍 ☁️ - Serveur MCP pour interagir avec l’API CyberChef afin de permettre à un client MCP d’utiliser les opérations CyberChef.
- [mrexodia/ida-pro-mcp](https://github.com/mrexodia/ida-pro-mcp) 🐍 🏠 - Serveur MCP pour IDA Pro, permettant de réaliser des analyses binaires avec des assistants IA. Ce plugin implémente la décompilation, le désassemblage et permet de générer automatiquement des rapports d’analyse de malwares.
- [rad-security/mcp-server](https://github.com/rad-security/mcp-server) 📇 ☁️ - Serveur MCP pour RAD Security, offrant des insights de sécurité basés sur l’IA pour Kubernetes et les environnements cloud. Il permet d’interroger l’API Rad Security et de récupérer des résultats de sécurité, rapports, données d’exécution et bien plus.
- [securityfortech/secops-mcp](https://github.com/securityfortech/secops-mcp) 🐍 🏠 - Boîte à outils de test de sécurité tout-en-un réunissant des outils open source populaires via une seule interface MCP. Connecté à un agent IA, permet des tâches comme le pentest, bug bounty, threat hunting, etc.
- [roadwy/cve-search_mcp](https://github.com/roadwy/cve-search_mcp) 🐍 🏠 - Serveur MCP pour interroger l’API CVE-Search. Permet un accès complet à CVE-Search, navigation par fournisseur et produit, récupération de CVE par ID, consultation des dernières CVE mises à jour.
- [StacklokLabs/osv-mcp](https://github.com/StacklokLabs/osv-mcp) 🏎️ ☁️ - Accès à la base de données OSV (Open Source Vulnerabilities) pour les informations sur les vulnérabilités. Interrogez les vulnérabilités par version de package ou commit, requête en lot sur plusieurs packages, et obtenez les détails par ID.
- [nickpending/mcp-recon](https://github.com/nickpending/mcp-recon) 🏎️ 🏠 - Interface conversationnelle de reconnaissance et serveur MCP propulsé par httpx et asnmap. Prend en charge différents niveaux de reconnaissance pour l’analyse de domaine, l’inspection des headers de sécurité, l’analyse de certificat et la recherche ASN.
- [Gaffx/volatility-mcp](https://github.com/Gaffx/volatility-mcp) - Serveur MCP pour Volatility 3.x, permettant de réaliser de l’analyse forensique de mémoire avec un assistant IA. Accédez facilement via API REST propre et LLMs à des plugins comme pslist et netscan.
- [co-browser/attestable-mcp-server](https://github.com/co-browser/attestable-mcp-server) 🐍 🏠 ☁️ 🐧 - Serveur MCP fonctionnant dans un environnement d’exécution de confiance (TEE) via Gramine, démontrant l’attestation distante avec [RA-TLS](https://gramine.readthedocs.io/en/stable/attestation.html). Permet à un client MCP de vérifier le serveur avant connexion.
- [zinja-coder/jadx-ai-mcp](https://github.com/zinja-coder/jadx-ai-mcp) ☕ 🏠 - JADX-AI-MCP est un plugin et serveur MCP pour le décompilateur JADX intégrant le Model Context Protocol (MCP) afin de fournir un support d’ingénierie inverse en direct avec des LLMs comme Claude.
- [zinja-coder/apktool-mcp-server](https://github.com/zinja-coder/apktool-mcp-server) 🐍 🏠 - APKTool MCP Server est un serveur MCP pour Apk Tool afin d’automatiser l’ingénierie inverse des APK Android.

### 🌐 <a name="social-media"></a>Médias sociaux

Intégration avec les plateformes de médias sociaux pour permettre la publication, l’analyse et la gestion des interactions. Permet l’automatisation pilotée par IA de la présence sociale.

- [macrocosm-os/macrocosmos-mcp](https://github.com/macrocosm-os/macrocosmos-mcp) - 🎖️ 🐍 ☁️ Accédez en temps réel aux données X/Reddit/YouTube dans vos applications LLM, avec recherche par mots-clés, utilisateurs et filtrage par dates.
- [kunallunia/twitter-mcp](https://github.com/LuniaKunal/mcp-twitter) 🐍 🏠 - Solution de gestion Twitter tout-en-un offrant accès à la timeline, récupération de tweets d’utilisateurs, suivi de hashtags, analyse de conversations, messages privés, analyse de sentiment d’un post, et contrôle complet du cycle de vie des posts via une API simplifiée.
- [HagaiHen/facebook-mcp-server](https://github.com/HagaiHen/facebook-mcp-server) 🐍 ☁️ - S’intègre avec les Pages Facebook pour permettre la gestion directe des posts, commentaires et métriques d’engagement via l’API Graph pour une gestion des médias sociaux simplifiée.
- [gwbischof/bluesky-social-mcp](https://github.com/gwbischof/bluesky-social-mcp) 🐍 🏠 - Un serveur MCP pour interagir avec Bluesky via le client atproto.


### 🏃 <a name="sports"></a>Sports

Outils pour accéder aux données, résultats et statistiques liés au sport.

- [mikechao/balldontlie-mcp](https://github.com/mikechao/balldontlie-mcp) 📇 - Serveur MCP qui intègre l’API balldontlie pour fournir des informations sur les joueurs, équipes et matchs de la NBA, NFL et MLB
- [r-huijts/firstcycling-mcp](https://github.com/r-huijts/firstcycling-mcp) 📇 ☁️ - Accès aux données, résultats et statistiques des courses cyclistes en langage naturel. Fonctionnalités : listes de départ, résultats de courses et informations sur les coureurs depuis firstcycling.com.
- [r-huijts/strava-mcp](https://github.com/r-huijts/strava-mcp) 📇 ☁️ - Un serveur MCP (Model Context Protocol) qui se connecte à l’API Strava, offrant des outils d’accès aux données Strava via des LLMs
- [willvelida/mcp-afl-server](https://github.com/willvelida/mcp-afl-server) ☁️ - Serveur MCP s’intégrant à l’API Squiggle pour fournir des informations sur les équipes de l’Australian Football League, le classement, les résultats, pronostics et classements de puissance.
- [guillochon/mlb-api-mcp](https://github.com/guillochon/mlb-api-mcp) 🐍 🏠 - Serveur MCP agissant comme proxy vers l’API MLB gratuite, fournissant infos joueurs, statistiques et données de matchs.

### 🎧 <a name="support-and-service-management"></a>Support & Gestion de services

Outils pour gérer le support client, la gestion des services informatiques et les opérations de helpdesk.

- [effytech/freshdesk-mcp](https://github.com/effytech/freshdesk_mcp) 🐍 ☁️ - Serveur MCP s’intégrant à Freshdesk, permettant aux modèles IA d’interagir avec les modules Freshdesk et d’effectuer diverses opérations de support.
- [nguyenvanduocit/jira-mcp](https://github.com/nguyenvanduocit/jira-mcp) 🏎️ ☁️ - Connecteur MCP en Go pour Jira permettant aux assistants IA comme Claude d’interagir avec Atlassian Jira. Fournit une interface fluide pour gérer les tickets, la planification de sprint et les transitions de workflow.
- [sooperset/mcp-atlassian](https://github.com/sooperset/mcp-atlassian) 🐍 ☁️ - Serveur MCP pour les produits Atlassian (Confluence et Jira). Prend en charge Confluence Cloud, Jira Cloud et Jira Server/Data Center. Outils complets pour la recherche, la lecture, la création et la gestion de contenu sur les espaces Atlassian.

### 🌎 <a name="translation-services"></a>Services de traduction

Outils et services de traduction permettant aux assistants IA de traduire le contenu entre différentes langues.

- [translated/lara-mcp](https://github.com/translated/lara-mcp) 🎖️ 📇 ☁️ - Serveur MCP pour l’API Lara Translate, offrant de puissantes capacités de traduction avec détection de langue et traductions contextuelles.
- [mmntm/weblate-mcp](https://github.com/mmntm/weblate-mcp) 📇 ☁️ - Serveur Model Context Protocol complet pour la gestion de traduction Weblate, permettant aux assistants IA de réaliser des tâches de traduction, gestion de projets et découverte de contenu avec des transformations de formats intelligentes.

### 🎧 <a name="text-to-speech"></a>Texte vers parole

Outils pour convertir texte en parole et inversement

- [mberg/kokoro-tts-mcp](https://github.com/mberg/kokoro-tts-mcp) 🐍 🏠 - Serveur MCP utilisant les modèles Kokoro TTS open source pour convertir du texte en parole. Peut convertir en MP3 localement ou téléverser automatiquement sur un bucket S3.
- [mbailey/voice-mcp](https://github.com/mbailey/voice-mcp) 🐍 🏠 - Serveur complet d’interaction vocale prenant en charge la reconnaissance vocale, la synthèse vocale et les conversations en temps réel via micro local, APIs compatibles OpenAI et intégration LiveKit

### 🚆 <a name="travel-and-transportation"></a>Voyage & Transport

Accès aux informations de voyage et de transport. Permet d’interroger horaires, itinéraires et données de voyage en temps réel.
- [Airbnb MCP Server](https://github.com/openbnb-org/mcp-server-airbnb) 📇 ☁️ - Fournit des outils pour rechercher sur Airbnb et obtenir les détails des annonces.
- [KyrieTangSheng/mcp-server-nationalparks](https://github.com/KyrieTangSheng/mcp-server-nationalparks) 📇 ☁️ - Intégration de l'API National Park Service fournissant les dernières informations sur les parcs, alertes, centres d'accueil, campings et événements pour les parcs nationaux américains.
- [NS Travel Information MCP Server](https://github.com/r-huijts/ns-mcp-server) 📇 ☁️ - Accès aux informations de voyage, horaires et mises à jour en temps réel des chemins de fer néerlandais (NS).
- [pab1it0/tripadvisor-mcp](https://github.com/pab1it0/tripadvisor-mcp) 📇 🐍 - Un serveur MCP permettant aux LLMs d'interagir avec l'API de Tripadvisor, prise en charge des données de localisation, avis et photos via des interfaces MCP standardisées.
- [lucygoodchild/mcp-national-rail](https://github.com/lucygoodchild/mcp-national-rail) 📇 ☁️ - Un serveur MCP pour le service ferroviaire National Rail du Royaume-Uni, fournissant les horaires des trains et des informations de voyage en direct, intégrant l'API Realtime Trains.

### 🔄 <a name="version-control"></a>Contrôle de version

Interagissez avec les dépôts Git et les plateformes de contrôle de version. Permet la gestion des dépôts, l'analyse de code, la gestion des pull requests, le suivi des problèmes et d'autres opérations de contrôle de version via des API standardisées.

- [adhikasp/mcp-git-ingest](https://github.com/adhikasp/mcp-git-ingest) 🐍 🏠 - Lire et analyser les dépôts GitHub avec votre LLM
- [ddukbg/github-enterprise-mcp](https://github.com/ddukbg/github-enterprise-mcp) 📇 ☁️ 🏠 - Serveur MCP pour l'intégration de l'API GitHub Enterprise
- [gitea/gitea-mcp](https://gitea.com/gitea/gitea-mcp) 🎖️ 🏎️ ☁️ 🏠 🍎 🪟 🐧 - Interagir avec les instances Gitea via MCP.
- [github/github-mcp-server](https://github.com/github/github-mcp-server) 📇 ☁️ - Serveur GitHub officiel pour l'intégration avec la gestion des dépôts, PR, issues, et plus.
- [kopfrechner/gitlab-mr-mcp](https://github.com/kopfrechner/gitlab-mr-mcp) 📇 ☁️ - Interagissez facilement avec les issues et merge requests de vos projets GitLab.
- [modelcontextprotocol/server-git](https://github.com/modelcontextprotocol/servers/tree/main/src/git) 🐍 🏠 - Opérations directes sur les dépôts Git, y compris lecture, recherche et analyse des dépôts locaux.
- [modelcontextprotocol/server-gitlab](https://github.com/modelcontextprotocol/servers/tree/main/src/gitlab) 📇 ☁️ 🏠 - Intégration de la plateforme GitLab pour la gestion de projets et les opérations CI/CD.
- [oschina/mcp-gitee](https://github.com/oschina/gitee) 🏎️ ☁️ 🏠 - Intégration de l'API Gitee, gestion de dépôts, issues, pull requests, et plus encore.
- [Tiberriver256/mcp-server-azure-devops](https://github.com/Tiberriver256/mcp-server-azure-devops) 📇 ☁️ - Intégration Azure DevOps pour la gestion des dépôts, éléments de travail et pipelines.
- [kaiyuanxiaobing/atomgit-mcp-server](https://github.com/kaiyuanxiaobing/atomgit-mcp-server) 📇 ☁️ - Serveur officiel AtomGit pour l'intégration avec la gestion des dépôts, PR, issues, branches, labels, et plus.

### 🛠️ <a name="other-tools-and-integrations"></a>Autres outils et intégrations

- [AbdelStark/bitcoin-mcp](https://github.com/AbdelStark/bitcoin-mcp) - ₿ Un serveur Model Context Protocol (MCP) permettant aux modèles d'IA d'interagir avec Bitcoin : génération de clés, validation d'adresses, décodage de transactions, interrogation de la blockchain, etc.
- [akseyh/bear-mcp-server](https://github.com/akseyh/bear-mcp-server) - Permet à l'IA de lire vos notes Bear (macOS uniquement)
- [allenporter/mcp-server-home-assistant](https://github.com/allenporter/mcp-server-home-assistant) 🐍 🏠 - Expose toutes les intentions vocales Home Assistant via un serveur MCP permettant le contrôle de la maison.
- [Amazon Bedrock Nova Canvas](https://github.com/zxkane/mcp-server-amazon-bedrock) 📇 ☁️ - Utilisez le modèle Amazon Nova Canvas pour la génération d'images.
- [amidabuddha/unichat-mcp-server](https://github.com/amidabuddha/unichat-mcp-server) 🐍/📇 ☁️ - Envoyez des requêtes à OpenAI, MistralAI, Anthropic, xAI, Google AI ou DeepSeek via le protocole MCP par outil ou prompts prédéfinis. Clé API du fournisseur requise.
- [anaisbetts/mcp-installer](https://github.com/anaisbetts/mcp-installer) 🐍 🏠 - Un serveur MCP qui installe d'autres serveurs MCP pour vous.
- [anaisbetts/mcp-youtube](https://github.com/anaisbetts/mcp-youtube) 📇 ☁️ - Récupère les sous-titres YouTube.
- [andybrandt/mcp-simple-openai-assistant](https://github.com/andybrandt/mcp-simple-openai-assistant) - 🐍 ☁️  MCP pour dialoguer avec les assistants OpenAI (Claude peut utiliser n'importe quel modèle GPT comme assistant)
- [andybrandt/mcp-simple-timeserver](https://github.com/andybrandt/mcp-simple-timeserver) 🐍 🏠☁️ - Un serveur MCP permettant de vérifier l'heure locale sur la machine client ou l'heure UTC actuelle via un serveur NTP
- [apify/actors-mcp-server](https://github.com/apify/actors-mcp-server) 📇 ☁️ - Utilisez plus de 3 000 outils cloud pré-construits, appelés Actors, pour extraire des données de sites web, e-commerce, réseaux sociaux, moteurs de recherche, cartes, etc.
- [apinetwork/piapi-mcp-server](https://github.com/apinetwork/piapi-mcp-server) 📇 ☁️ Le serveur PiAPI MCP permet de générer du contenu média avec Midjourney/Flux/Kling/Hunyuan/Udio/Trellis directement depuis Claude ou toute autre app compatible MCP.
- [awkoy/replicate-flux-mcp](https://github.com/awkoy/replicate-flux-mcp) 📇 ☁️ - Permet de générer des images via l'API Replicate.
- [awwaiid/mcp-server-taskwarrior](https://github.com/awwaiid/mcp-server-taskwarrior) 🏠 📇 - Un serveur MCP pour l'utilisation locale basique de taskwarrior (ajouter, modifier, supprimer des tâches)
- [baba786/phabricator-mcp-server](https://github.com/baba786/phabricator-mcp-server) 🐍 ☁️ - Interaction avec l'API Phabricator
- [Badhansen/notion-mcp](https://github.com/Badhansen/notion-mcp) 🐍 ☁️ - Un serveur MCP intégrant l'API Notion pour gérer efficacement des listes de tâches personnelles.
- [bart6114/my-bear-mcp-server](https://github.com/bart6114/my-bear-mcp-server/) 📇 🏠 🍎 - Permet de lire les notes et tags de l'application Bear via une intégration directe avec la base sqlitedb de Bear.
- [billster45/mcp-chatgpt-responses](https://github.com/billster45/mcp-chatgpt-responses) 🐍 ☁️ - Serveur MCP pour que Claude dialogue avec ChatGPT et utilise sa capacité de recherche web.
- [blurrah/mcp-graphql](https://github.com/blurrah/mcp-graphql) 📇 ☁️ - Permet à l'IA d'interroger des serveurs GraphQL
- [calclavia/mcp-obsidian](https://github.com/calclavia/mcp-obsidian) 📇 🏠 - Connecteur permettant à Claude Desktop (ou tout client MCP) de lire et rechercher dans tout répertoire contenant des notes Markdown (comme un coffre-fort Obsidian).
- [chrishayuk/mcp-cli](https://github.com/chrishayuk/mcp-cli) 🐍 🏠 - Encore un outil CLI pour tester les serveurs MCP
- [danhilse/notion_mcp](https://github.com/danhilse/notion_mcp) 🐍 ☁️ - Intègre l'API Notion pour gérer les listes de tâches personnelles
- [EKibort/wrike-mcp-server](https://github.com/EKibort/wrike-mcp-server) - 🐍 🏠 - Une implémentation légère d'un serveur Wrike MCP pour interagir avec les tâches Wrike via l'API publique.
- [ekkyarmandi/ticktick-mcp](https://github.com/ekkyarmandi/ticktick-mcp) 🐍 ☁️ - Serveur MCP [TickTick](https://ticktick.com/) intégrant l'API TickTick pour gérer des projets et tâches personnels.
- [esignaturescom/mcp-server-esignatures](https://github.com/esignaturescom/mcp-server-esignatures) 🐍 ☁️️ - Gestion des contrats et modèles pour la rédaction, relecture et envoi de contrats juridiquement contraignants via l'API eSignatures.
- [evalstate/mcp-miro](https://github.com/evalstate/mcp-miro) 📇 ☁️ - Accédez aux tableaux blancs MIRO, création et lecture d'éléments en masse. Nécessite une clé OAUTH pour l'API REST.
- [feuerdev/keep-mcp](https://github.com/feuerdev/keep-mcp) 🐍 ☁️ - Lire, créer, modifier et supprimer des notes Google Keep.
- [future-audiences/wikimedia-enterprise-model-context-protocol](https://gitlab.wikimedia.org/repos/future-audiences/wikimedia-enterprise-model-context-protocol) 🐍 ☁️  - API de recherche d'articles Wikipédia
- [fotoetienne/gqai](https://github.com/fotoetienne/gqai) 🏎 🏠 - Définissez des outils via des requêtes/mutations GraphQL standards et gqai génère automatiquement un serveur MCP pour vous.
- [githejie/mcp-server-calculator](https://github.com/githejie/mcp-server-calculator) 🐍 🏠 - Ce serveur permet aux LLMs d'utiliser une calculatrice pour des calculs numériques précis
- [gotoolkits/DifyWorkflow](https://github.com/gotoolkits/mcp-difyworkflow-server) - 🏎️ ☁️ Outils pour la requête et l'exécution de workflows Dify
- [hiromitsusasaki/raindrop-io-mcp-server](https://github.com/hiromitsusasaki/raindrop-io-mcp-server) 📇 ☁️ - Intégration permettant aux LLMs d'interagir avec les favoris Raindrop.io via MCP.
- [hmk/attio-mcp-server](https://github.com/hmk/attio-mcp-server) - 📇 ☁️ Permet aux clients IA de gérer les enregistrements et notes dans Attio CRM
- [isaacwasserman/mcp-vegalite-server](https://github.com/isaacwasserman/mcp-vegalite-server) 🐍 🏠 - Générez des visualisations à partir de données récupérées au format VegaLite.
- [ivnvxd/mcp-server-odoo](https://github.com/ivnvxd/mcp-server-odoo) 🐍 ☁️/🏠 - Connecte les assistants IA aux systèmes Odoo ERP pour l'accès aux données métiers, la gestion des enregistrements et l'automatisation des workflows.
- [ivo-toby/contentful-mcp](https://github.com/ivo-toby/contentful-mcp) 📇 🏠 - Met à jour, crée, supprime des contenus, modèles de contenu et assets dans votre espace Contentful.
- [j3k0/speech.sh](https://github.com/j3k0/speech.sh/blob/main/MCP_README.md) 🏠 - Permet à l'agent de lire à voix haute, vous notifier quand il a fini avec un résumé rapide
- [jagan-shanmugam/climatiq-mcp-server](https://github.com/jagan-shanmugam/climatiq-mcp-server) 🐍 🏠 - Serveur MCP pour accéder à l'API Climatiq afin de calculer les émissions carbone. Permet aux assistants IA de réaliser des calculs carbone en temps réel et fournir des analyses d'impact climatique.
- [johannesbrandenburger/typst-mcp](https://github.com/johannesbrandenburger/typst-mcp) 🐍 🏠 - Serveur MCP pour Typst, un système de composition basé sur le balisage. Fournit des outils pour convertir entre LaTeX et Typst, valider la syntaxe Typst, et générer des images à partir de code Typst.
- [joshuarileydev/mac-apps-launcher-mcp-server](https://github.com/JoshuaRileyDev/mac-apps-launcher) 📇 🏠 - Serveur MCP pour lister et lancer des applications sur MacOS
- [Harry-027/JotDown](https://github.com/Harry-027/JotDown) 🦀 🏠 - Serveur MCP pour créer/modifier des pages dans Notion & générer automatiquement des mdBooks à partir de contenu structuré.
- [kelvin6365/plane-mcp-server](https://github.com/kelvin6365/plane-mcp-server) - 🏎️ 🏠 Ce serveur MCP aide à gérer les projets et problèmes via l'API de [Plane](https://plane.so)
- [kenliao94/mcp-server-rabbitmq](https://github.com/kenliao94/mcp-server-rabbitmq) 🐍 🏠 - Permet l'interaction (opérations admin, mise en file/enlèvement de messages) avec RabbitMQ
- [k-jarzyna/mcp-miro](https://github.com/k-jarzyna/mcp-miro) 📇 ☁️ - Serveur MCP Miro exposant toutes les fonctionnalités disponibles dans le SDK officiel Miro
- [kimtth/mcp-remote-call-ping-pong](https://github.com/kimtth/mcp-remote-call-ping-pong) 🐍 🏠 - Application expérimentale et éducative de serveur Ping-pong démontrant les appels MCP à distance
- [kj455/mcp-kibela](https://github.com/kj455/mcp-kibela) - 📇 ☁️ Permet aux modèles IA d'interagir avec [Kibela](https://kibe.la/)
- [kiwamizamurai/mcp-kibela-server](https://github.com/kiwamizamurai/mcp-kibela-server) - 📇 ☁️ Interaction avancée avec l'API Kibela.
- [KS-GEN-AI/confluence-mcp-server](https://github.com/KS-GEN-AI/confluence-mcp-server) 📇 ☁️ 🍎 🪟 - Récupère les données Confluence via CQL et lit les pages.
- [KS-GEN-AI/jira-mcp-server](https://github.com/KS-GEN-AI/jira-mcp-server) 📇 ☁️ 🍎 🪟 - Lit les données Jira via JQL et API et exécute des requêtes de création et modification de tickets.
- [salesforce-mcp/salesforce-mcp](https://github.com/salesforce-mcp/salesforce-mcp) 🏠 ☁️ - Serveur MCP avec démonstration de base des interactions avec une instance Salesforce
- [pollinations/chucknorris-mcp](https://github.com/pollinations/chucknorris-mcp) 📇 ☁️ - Prompts spécialisés d'amélioration LLM et jailbreaks avec adaptation dynamique du schéma.
- [louiscklaw/hko-mcp](https://github.com/louiscklaw/hko-mcp) 📇 🏠 - Serveur MCP avec démonstration de base pour obtenir la météo de l'Observatoire de Hong Kong
- [evalstate/mcp-hfspace](https://github.com/evalstate/mcp-hfspace) 📇 ☁️ - Utilisez HuggingFace Spaces directement depuis Claude. Génération d'images open source, chat, tâches vision et plus. Prend en charge les uploads/downloads d'images, audio, texte.
- [magarcia/mcp-server-giphy](https://github.com/magarcia/mcp-server-giphy) 📇 ☁️ - Recherche et récupération de GIFs depuis la vaste bibliothèque de Giphy via l'API Giphy.
- [integromat/make-mcp-server](https://github.com/integromat/make-mcp-server) 🎖️ 📇 🏠 - Transformez vos scénarios [Make](https://www.make.com/) en outils appelables pour assistants IA.
- [marcelmarais/Spotify](https://github.com/marcelmarais/spotify-mcp-server) - 📇 🏠 Contrôlez la lecture Spotify et gérez les playlists.
- [MarkusPfundstein/mcp-obsidian](https://github.com/MarkusPfundstein/mcp-obsidian) 🐍 ☁️ 🏠 - Interaction avec Obsidian via l'API REST
- [emicklei/mcp-log-proxy](https://github.com/emicklei/mcp-log-proxy) 🏎️ 🏠 - Proxy serveur MCP offrant une interface Web sur tout le flux de messages
- [quarkiverse/mcp-server-jfx](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/jfx) ☕ 🏠 - Dessinez sur un canvas JavaFX.
- [mediar-ai/screenpipe](https://github.com/mediar-ai/screenpipe) - 🎖️ 🦀 🏠 🍎 Système local d'enregistrement écran/audio avec indexation horodatée, stockage SQL/embedding, recherche sémantique, analyse historique par LLM et actions événementielles - permet la création d'agents IA contextuels via un écosystème de plugins NextJS.
- [modelcontextprotocol/server-everything](https://github.com/modelcontextprotocol/servers/tree/main/src/everything) 📇 🏠 - Serveur MCP qui exerce toutes les fonctionnalités du protocole MCP
- [mrjoshuak/godoc-mcp](https://github.com/mrjoshuak/godoc-mcp) 🏎️ 🏠 - Serveur de documentation Go efficient fournissant aux assistants IA un accès intelligent à la doc de package et aux types sans lire tout le code source
- [mzxrai/mcp-openai](https://github.com/mzxrai/mcp-openai) 📇 ☁️ - Dialogue avec les modèles les plus avancés d'OpenAI
- [NakaokaRei/swift-mcp-gui](https://github.com/NakaokaRei/swift-mcp-gui.git) 🏠 🍎 - Serveur MCP pouvant exécuter des commandes telles que saisie clavier et déplacement de souris
- [nguyenvanduocit/all-in-one-model-context-protocol](https://github.com/nguyenvanduocit/all-in-one-model-context-protocol) 🏎️ 🏠 - Outils utiles pour développeurs, presque tout ce dont un ingénieur a besoin : confluence, Jira, Youtube, script, base de connaissances RAG, fetch URL, gestion de chaîne Youtube, emails, calendrier, gitlab
- [NON906/omniparser-autogui-mcp](https://github.com/NON906/omniparser-autogui-mcp) - 🐍 Opérations automatiques sur GUI à l'écran.
- [orellazi/coda-mcp](https://github.com/orellazri/coda-mcp) 📇 ☁️ - Serveur MCP pour [Coda](https://coda.io/)
- [pierrebrunelle/mcp-server-openai](https://github.com/pierrebrunelle/mcp-server-openai) 🐍 ☁️ - Interrogez les modèles OpenAI directement depuis Claude via le protocole MCP
- [pskill9/hn-server](https://github.com/pskill9/hn-server) - 📇 ☁️ Analyse le contenu HTML de news.ycombinator.com (Hacker News) et fournit des données structurées pour différents types d'articles (top, new, ask, show, jobs).
- [PV-Bhat/vibe-check-mcp-server](https://github.com/PV-Bhat/vibe-check-mcp-server) 📇 ☁️ - Un serveur MCP qui prévient les erreurs en cascade et les dérives de périmètre en appelant un agent "Vibe-check" pour assurer l'alignement utilisateur.
- [pwh-pwh/cal-mcp](https://github.com/pwh-pwh/cal-mcp) - Serveur MCP pour le calcul d'expressions mathématiques
- [pyroprompts/any-chat-completions-mcp](https://github.com/pyroprompts/any-chat-completions-mcp) - Dialogue avec toute API Chat Completions compatible OpenAI SDK, comme Perplexity, Groq, xAI et autres
- [Rai220/think-mcp](https://github.com/Rai220/think-mcp) 🐍 🏠 - Améliore les capacités de raisonnement de tout agent en intégrant les think-tools, comme décrit dans [l'article d'Anthropic](https://www.anthropic.com/engineering/claude-think-tool).
- [reeeeemo/ancestry-mcp](https://github.com/reeeeemo/ancestry-mcp) 🐍 🏠 - Permet à l'IA de lire des fichiers .ged et données génétiques
- [rember/rember-mcp](https://github.com/rember/rember-mcp) 📇 🏠 - Créez des flashcards à répétition espacée dans [Rember](https://rember.com) pour retenir tout ce que vous apprenez dans vos discussions.
- [roychri/mcp-server-asana](https://github.com/roychri/mcp-server-asana) - 📇 ☁️ Cette implémentation serveur MCP pour Asana permet d'utiliser l'API Asana depuis un client MCP comme Claude Desktop Application, etc.
- [rusiaaman/wcgw](https://github.com/rusiaaman/wcgw/blob/main/src/wcgw/client/mcp_server/Readme.md) 🐍 🏠 - Exécution autonome de shell, contrôle de l'ordinateur et agent de codage. (Mac)
- [SecretiveShell/MCP-wolfram-alpha](https://github.com/SecretiveShell/MCP-wolfram-alpha) 🐍 ☁️ - Serveur MCP pour interroger l'API Wolfram Alpha.
- [Seym0n/tiktok-mcp](https://github.com/Seym0n/tiktok-mcp) 📇 ☁️ - Interagissez avec les vidéos TikTok
- [Shopify/dev-mcp](https://github.com/Shopify/dev-mcp) 📇 ☁️ - Serveur Model Context Protocol (MCP) qui interagit avec Shopify Dev.
- [sirmews/apple-notes-mcp](https://github.com/sirmews/apple-notes-mcp) 🐍 🏠 - Permet à l'IA de lire depuis votre base de données Apple Notes locale (macOS uniquement)
- [sooperset/mcp-atlassian](https://github.com/sooperset/mcp-atlassian) 🐍 ☁️ - Serveur MCP pour les produits Atlassian (Confluence et Jira). Prend en charge Confluence Cloud, Jira Cloud et Jira Server/Data Center. Fournit des outils complets pour rechercher, lire, créer et gérer le contenu à travers les espaces de travail Atlassian.
- [suekou/mcp-notion-server](https://github.com/suekou/mcp-notion-server) 📇 🏠 - Interaction avec l’API Notion
- [tacticlaunch/mcp-linear](https://github.com/tacticlaunch/mcp-linear) 📇 ☁️ 🍎 🪟 🐧 - Intègre le système de gestion de projet Linear
- [tanigami/mcp-server-perplexity](https://github.com/tanigami/mcp-server-perplexity) 🐍 ☁️ - Interaction avec l’API Perplexity.
- [tevonsb/homeassistant-mcp](https://github.com/tevonsb/homeassistant-mcp) 📇 🏠 - Accède aux données Home Assistant et contrôle les appareils (lumières, interrupteurs, thermostats, etc).
- [tomekkorbak/oura-mcp-server](https://github.com/tomekkorbak/oura-mcp-server) 🐍 ☁️ - Un serveur MCP pour Oura, une application de suivi du sommeil
- [UnitVectorY-Labs/mcp-graphql-forge](https://github.com/UnitVectorY-Labs/mcp-graphql-forge) 🏎️ ☁️ 🍎 🪟 🐧 - Un serveur MCP léger, piloté par configuration, qui expose des requêtes GraphQL sélectionnées comme des outils modulaires, permettant des interactions API intentionnelles depuis vos agents.
- [kw510/strava-mcp](https://github.com/kw510/strava-mcp) 📇 ☁️ - Un serveur MCP pour Strava, une application de suivi d’activité physique
- [wanaku-ai/wanaku](https://github.com/wanaku-ai/wanaku) - ☁️ 🏠 Le routeur Wanaku MCP est un serveur MCP basé sur SSE qui fournit un moteur de routage extensible permettant d’intégrer vos systèmes d’entreprise avec des agents IA.
- [wong2/mcp-cli](https://github.com/wong2/mcp-cli) 📇 🏠 - Outil CLI pour tester les serveurs MCP
- [ws-mcp](https://github.com/nick1udwig/ws-mcp) - Encapsule les serveurs MCP avec un WebSocket (à utiliser avec [kitbitz](https://github.com/nick1udwig/kibitz))
- [yuna0x0/hackmd-mcp](https://github.com/yuna0x0/hackmd-mcp) 📇 ☁️ - Permet aux modèles d’IA d’interagir avec [HackMD](https://hackmd.io)
- [ZeparHyfar/mcp-datetime](https://github.com/ZeparHyfar/mcp-datetime) - Serveur MCP fournissant des fonctions de date et d’heure dans divers formats
- [zueai/mcp-manager](https://github.com/zueai/mcp-manager) 📇 ☁️ - Interface Web simple pour installer et gérer des serveurs MCP pour l’application Claude Desktop.
- [HenryHaoson/Yuque-MCP-Server](https://github.com/HenryHaoson/Yuque-MCP-Server) - 📇 ☁️ Un serveur Model-Context-Protocol (MCP) pour intégrer l’API Yuque, permettant aux modèles d’IA de gérer des documents, interagir avec des bases de connaissances, rechercher du contenu et accéder aux données analytiques de la plateforme Yuque.
- [Mtehabsim/ScreenPilot](https://github.com/Mtehabsim/ScreenPilot) 🐍 🏠 - permet à l’IA de contrôler et d’accéder entièrement aux interactions GUI en fournissant des outils pour la souris et le clavier, idéal pour l’automatisation générale, l’éducation et l’expérimentation.
- [tumf/web3-mcp](https://github.com/tumf/web3-mcp) 🐍 ☁️ - Une implémentation de serveur MCP enveloppant Ankr Advanced API. Accès aux données NFT, tokens et blockchain sur plusieurs chaînes dont Ethereum, BSC, Polygon, Avalanche, etc.
- [danielkennedy1/pdf-tools-mcp](https://github.com/danielkennedy1/pdf-tools-mcp) 🐍 - Utilitaires pour télécharger, visualiser et manipuler des PDF.
- [dotemacs/domain-lookup-mcp](https://github.com/dotemacs/domain-lookup-mcp) 🏎️ - Service de recherche de noms de domaine, d’abord via [RDAP](https://en.wikipedia.org/wiki/Registration_Data_Access_Protocol) puis en secours via [WHOIS](https://en.wikipedia.org/wiki/WHOIS)
- [Klavis-AI/YouTube](https://github.com/Klavis-AI/klavis/tree/main/mcp_servers/youtube) 🐍 📇 - Extraire et convertir les informations de vidéos YouTube.
- [ttommyth/interactive-mcp](https://github.com/ttommyth/interactive-mcp) 📇 🏠 🍎 🪟 🐧 - Permet des workflows LLM interactifs en ajoutant des invites et des capacités de chat utilisateur localement dans la boucle MCP.
- [olalonde/mcp-human](https://github.com/olalonde/mcp-human) 📇 ☁️ - Quand votre LLM a besoin d’une assistance humaine (via AWS Mechanical Turk)
- [gwbischof/free-will-mcp](https://github.com/gwbischof/free-will-mcp) 🐍 🏠 - Donnez à votre IA des outils de libre arbitre. Un projet ludique pour explorer ce que ferait une IA avec la capacité de s’auto-suggérer des prompts, d’ignorer les requêtes utilisateur, et de se réveiller ultérieurement.
- [caol64/wenyan-mcp](https://github.com/caol64/wenyan-mcp) 📇 🏠 🍎 🪟 🐧 - Wenyan MCP Server, qui permet à l’IA de formater automatiquement des articles Markdown et de les publier sur WeChat GZH.

## Frameworks

> [!NOTE]
> Plus de frameworks, utilitaires et autres outils de développement sont disponibles sur https://github.com/punkpeye/awesome-mcp-devtools

- [FastMCP](https://github.com/jlowin/fastmcp) 🐍 - Un framework de haut niveau pour créer des serveurs MCP en Python
- [FastMCP](https://github.com/punkpeye/fastmcp) 📇 - Un framework de haut niveau pour créer des serveurs MCP en TypeScript

## Astuces et Conseils

### Prompt officiel pour informer les LLMs sur l’utilisation de MCP

Vous souhaitez demander à Claude des informations sur le Model Context Protocol ?

Créez un Projet, puis ajoutez-y ce fichier :

https://modelcontextprotocol.io/llms-full.txt

Claude pourra alors répondre à des questions sur l’écriture de serveurs MCP et leur fonctionnement

- https://www.reddit.com/r/ClaudeAI/comments/1h3g01r/want_to_ask_claude_about_model_context_protocol/

## Historique des étoiles

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
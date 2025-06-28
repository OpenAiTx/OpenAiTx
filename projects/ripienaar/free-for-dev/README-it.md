# free-for.dev

Gli sviluppatori e gli autori Open Source ora hanno a disposizione molti servizi che offrono livelli gratuiti, ma trovarli tutti richiede tempo per prendere decisioni informate.

Questa è una lista di software (SaaS, PaaS, IaaS, ecc.) e altre offerte con livelli gratuiti per sviluppatori.

L’ambito di questa particolare lista è limitato alle cose che gli sviluppatori di infrastrutture (Amministratori di Sistema, Professionisti DevOps, ecc.) potrebbero trovare utili. Amiamo tutti i servizi gratuiti disponibili, ma sarebbe bene restare in tema. A volte è una linea sottile, quindi questa lista è opinabile; per favore non sentirti offeso se non accetto il tuo contributo.

Questa lista è il risultato di Pull Request, revisioni, idee e lavoro svolto da oltre 1600 persone. Puoi anche aiutare inviando [Pull Request](https://github.com/ripienaar/free-for-dev) per aggiungere altri servizi o rimuovere quelli la cui offerta è cambiata o è stata ritirata.

[![Track Awesome List](https://www.trackawesomelist.com/badge.svg)](https://www.trackawesomelist.com/ripienaar/free-for-dev)

**NOTA**: Questa lista è solo per offerte as-a-Service, non per software self-hosted. Per essere idoneo, un servizio deve offrire un livello gratuito, non solo una prova gratuita. Il livello gratuito deve essere valido almeno un anno se è a tempo limitato. Consideriamo anche il livello gratuito dal punto di vista della sicurezza, quindi SSO va bene, ma non accetterò servizi che limitano TLS solo ai livelli a pagamento.

# Indice

  * [Limiti Always-Free dei principali provider cloud](#major-cloud-providers)
  * [Soluzioni di gestione cloud](#cloud-management-solutions)
  * [Analitiche, Eventi e Statistiche](#analytics-events-and-statistics)
  * [API, Dati e ML](#apis-data-and-ml)
  * [Repository di Artifact](#artifact-repos)
  * [BaaS](#baas)
  * [Piattaforme Low-code](#low-code-platform)
  * [CDN e Protezione](#cdn-and-protection)
  * [CI e CD](#ci-and-cd)
  * [CMS](#cms)
  * [Generazione di Codice](#code-generation)
  * [Qualità del Codice](#code-quality)
  * [Ricerca e Navigazione del Codice](#code-search-and-browsing)
  * [Gestione Crash ed Eccezioni](#crash-and-exception-handling)
  * [Visualizzazione dati su Mappe](#data-visualization-on-maps)
  * [Servizi dati gestiti](#managed-data-services)
  * [Design e UI](#design-and-ui)
  * [Ispirazione per Design](#design-inspiration)
  * [Siti di blogging per Dev](#dev-blogging-sites)
  * [DNS](#dns)
  * [Relativi a Docker](#docker-related)
  * [Dominio](#domain)
  * [Formazione e Sviluppo Carriera](#education-and-career-development)
  * [Email](#email)
  * [Piattaforme di Gestione Feature Toggles](#feature-toggles-management-platforms)
  * [Font](#font)
  * [Form](#forms)
  * [AI Generativa](#generative-ai)
  * [IaaS](#iaas)
  * [IDE e Editori di Codice](#ide-and-code-editing)
  * [API e SDK per verifica numeri mobili internazionali](#international-mobile-number-verification-api-and-sdk)
  * [Gestione Issue e Project Management](#issue-tracking-and-project-management)
  * [Gestione Log](#log-management)
  * [Distribuzione App Mobile e Feedback](#mobile-app-distribution-and-feedback)
  * [Sistemi di Gestione](#management-system)
  * [Messaggistica e Streaming](#messaging-and-streaming)
  * [Varie](#miscellaneous)
  * [Monitoraggio](#monitoring)
  * [PaaS](#paas)
  * [Sistema di Build di Pacchetti](#package-build-system)
  * [Pagamenti e Integrazione Fatturazione](#payment-and-billing-integration)
  * [Gestione della Privacy](#privacy-management)
  * [API Screenshot](#screenshot-apis)
  * [Relativi a Flutter e Build di app IOS senza Mac](#flutter-related-and-building-ios-apps-without-mac)
  * [Ricerca](#search)
  * [Sicurezza e PKI](#security-and-pki)
  * [Autenticazione, Autorizzazione e Gestione Utenti](#authentication-authorization-and-user-management)
  * [Repository di Codice Sorgente](#source-code-repos)
  * [Storage e Media Processing](#storage-and-media-processing)
  * [Tunneling, WebRTC, Web Socket Server e altri router](#tunneling-webrtc-web-socket-servers-and-other-routers)
  * [Testing](#testing)
  * [Strumenti per team e collaborazione](#tools-for-teams-and-collaboration)
  * [Gestione Traduzioni](#translation-management)
  * [Relativi a Vagrant](#vagrant-related)
  * [Registrazione sessione visitatori](#visitor-session-recording)
  * [Web Hosting](#web-hosting)
  * [Piattaforme di Commenti](#commenting-platforms)
  * [Emulazione hardware nel browser](#browser-based-hardware-emulation-written-in-javascript)
  * [Strumenti Desktop Remoti](#remote-desktop-tools)
  * [Sviluppo Videogiochi](#game-development)
  * [Altre Risorse Gratuite](#other-free-resources)

## Principali Provider Cloud

  * [Google Cloud Platform](https://cloud.google.com)
    * App Engine - 28 ore di istanza frontend al giorno, nove ore di istanza backend al giorno
    * Cloud Firestore - 1GB di storage, 50.000 letture, 20.000 scritture, 20.000 cancellazioni al giorno
    * Compute Engine - 1 e2-micro non preemptible, 30GB HDD, 5GB snapshot storage (limitato a certe regioni), 1 GB di egress di rete dal Nord America verso tutte le destinazioni regionali (esclusa Cina e Australia) al mese
    * Cloud Storage - 5GB, 1GB di egress di rete
    * Cloud Shell - Shell Linux/IDE primaria via web con 5GB di storage persistente. Limite di 60 ore a settimana
    * Cloud Pub/Sub - 10GB di messaggi al mese
    * Cloud Functions - 2 milioni di invocazioni al mese (include sia invocazioni background che HTTP)
    * Cloud Run - 2 milioni di richieste al mese, 360.000 GB-secondi di memoria, 180.000 vCPU-secondi di tempo di calcolo, 1 GB di egress di rete dal Nord America al mese
    * Google Kubernetes Engine - Nessuna fee di gestione cluster per un cluster zonale. Ogni nodo utente viene addebitato al prezzo standard di Compute Engine
    * BigQuery - 1 TB di query al mese, 10 GB di storage ogni mese
    * Cloud Build - 120 minuti di build al giorno
    * Cloud Source Repositories - Fino a 5 utenti, 50 GB di storage, 50 GB di egress
    * [Google Colab](https://colab.research.google.com/) - Ambiente di sviluppo Jupyter Notebooks gratuito.
    * [Firebase Studio](https://firebase.studio) Google Firebase Studio (precedentemente Project IDX). VSCode online in esecuzione su Google Cloud.
    * Lista completa e dettagliata - https://cloud.google.com/free

  * [Amazon Web Services](https://aws.amazon.com)
    * [CloudFront](https://aws.amazon.com/cloudfront/) - 1TB di egress al mese e 2M di invocazioni Function al mese
    * [CloudWatch](https://aws.amazon.com/cloudwatch/) - 10 metriche personalizzate e dieci allarmi
* [CodeBuild](https://aws.amazon.com/codebuild/) - 100 minuti di tempo di build al mese
* [CodeCommit](https://aws.amazon.com/codecommit/) - 5 utenti attivi, 50GB di storage e 10.000 richieste al mese
* [CodePipeline](https://aws.amazon.com/codepipeline/) - 1 pipeline attiva al mese
* [DynamoDB](https://aws.amazon.com/dynamodb/) - 25GB DB NoSQL
* [EC2](https://aws.amazon.com/ec2/) - 750 ore al mese di t2.micro o t3.micro (12 mesi). 100GB di traffico in uscita al mese
* [EBS](https://aws.amazon.com/ebs/) - 30GB al mese di General Purpose (SSD) o Magnetic (12 mesi)
* [Elastic Load Balancing](https://aws.amazon.com/elasticloadbalancing/) - 750 ore al mese (12 mesi)
* [RDS](https://aws.amazon.com/rds/) - 750 ore al mese di db.t2.micro, db.t3.micro o db.t4g.micro, 20GB di storage General Purpose (SSD), 20GB di backup storage (12 mesi)
* [S3](https://aws.amazon.com/s3/) - 5GB di storage oggetti Standard, 20.000 richieste Get e 2.000 richieste Put (12 mesi)
* [Glacier](https://aws.amazon.com/glacier/) - 10GB di storage oggetti a lungo termine
* [Lambda](https://aws.amazon.com/lambda/) - 1 milione di richieste al mese
* [SNS](https://aws.amazon.com/sns/) - 1 milione di pubblicazioni al mese
* [SES](https://aws.amazon.com/ses/) - 3.000 messaggi al mese (12 mesi)
* [SQS](https://aws.amazon.com/sqs/) - 1 milione di richieste di coda di messaggistica
* Elenco completo e dettagliato - https://aws.amazon.com/free/

* [Microsoft Azure](https://azure.microsoft.com)
  * [Virtual Machines](https://azure.microsoft.com/services/virtual-machines/) - 1 VM Linux B1S, 1 VM Windows B1S (12 mesi)
  * [App Service](https://azure.microsoft.com/services/app-service/) - 10 app web, mobile o API (60 minuti CPU/giorno)
  * [Functions](https://azure.microsoft.com/services/functions/) - 1 milione di richieste al mese
  * [DevTest Labs](https://azure.microsoft.com/services/devtest-lab/) - Ambienti di sviluppo e test rapidi, semplici ed efficienti
  * [Active Directory](https://azure.microsoft.com/services/active-directory/) - 500.000 oggetti
  * [Active Directory B2C](https://azure.microsoft.com/services/active-directory/external-identities/b2c/) - 50.000 utenti memorizzati mensilmente
  * [Azure DevOps](https://azure.microsoft.com/services/devops/) - 5 utenti attivi, repository Git privati illimitati
  * [Azure Pipelines](https://azure.microsoft.com/services/devops/pipelines/) — 10 job paralleli gratuiti con minuti illimitati per open source su Linux, macOS e Windows
  * [Microsoft IoT Hub](https://azure.microsoft.com/services/iot-hub/) - 8.000 messaggi al giorno
  * [Load Balancer](https://azure.microsoft.com/services/load-balancer/) - 1 IP pubblico bilanciato (VIP) gratuito
  * [Notification Hubs](https://azure.microsoft.com/services/notification-hubs/) - 1 milione di notifiche push
  * [Bandwidth](https://azure.microsoft.com/pricing/details/bandwidth/) - 15GB in entrata (12 mesi) e 5GB in uscita al mese
  * [Cosmos DB](https://azure.microsoft.com/services/cosmos-db/) - 25GB di storage e 1000 RU di throughput provisionato
  * [Static Web Apps](https://azure.microsoft.com/pricing/details/app-service/static/) — Crea, distribuisci e ospita app statiche e funzioni serverless con SSL gratuito, autenticazione/autorizzazione e domini personalizzati
  * [Storage](https://azure.microsoft.com/services/storage/) - 5GB di storage File o Blob LRS (12 mesi)
  * [Cognitive Services](https://azure.microsoft.com/services/cognitive-services/) - API AI/ML (Computer Vision, Translator, Face detection, Bot, ecc.) con tier gratuito che include transazioni limitate
  * [Cognitive Search](https://azure.microsoft.com/services/search/#features) - Servizio di ricerca e indicizzazione basato su AI, gratuito fino a 10.000 documenti
  * [Azure Kubernetes Service](https://azure.microsoft.com/services/kubernetes-service/) - Servizio Kubernetes gestito, gestione cluster gratuita
  * [Event Grid](https://azure.microsoft.com/services/event-grid/) - 100.000 operazioni/mese
  * Elenco completo e dettagliato - https://azure.microsoft.com/free/

* [Oracle Cloud](https://www.oracle.com/cloud/)
  * Compute
     - 2 VM Compute basate su AMD con 1/8 OCPU e 1 GB di memoria ciascuna
     - 4 core Arm Ampere A1 e 24 GB di memoria utilizzabili come una VM o fino a 4 VM
     - Le istanze verranno reclamate quando [considerate inattive](https://docs.oracle.com/en-us/iaas/Content/FreeTier/freetier_topic-Always_Free_Resources.htm#compute__idleinstances)
  * Block Volume - 2 volumi, 200 GB totali (usati per compute)
  * Object Storage - 10 GB
  * Load balancer - 1 istanza con 10 Mbps
  * Database - 2 DB, 20 GB ciascuno
  * Monitoring - 500 milioni di punti dati di ingestione, 1 miliardo di punti dati di recupero
  * Banda - 10 TB di traffico in uscita al mese, velocità limitata a 50 Mbps su VM x64, 500 Mbps * numero di core su VM ARM
  * IP pubblico - 2 IPv4 per VM, 1 IPv4 per load balancer
  * Notifiche - 1 milione di opzioni di consegna al mese, 1000 email inviate al mese
  * Elenco completo e dettagliato - https://www.oracle.com/cloud/free/

* [IBM Cloud](https://www.ibm.com/cloud/free/)
  * Database Cloudant - 1 GB di spazio di archiviazione dati
  * Database Db2 - 100MB di spazio di archiviazione dati
  * API Connect - 50.000 chiamate API al mese
  * Availability Monitoring - 3 milioni di punti dati al mese
  * Log Analysis - 500MB di log giornalieri
  * Elenco completo e dettagliato - https://www.ibm.com/cloud/free/

* [Cloudflare](https://www.cloudflare.com/)
  * [Application Services](https://www.cloudflare.com/plans/) - DNS gratuito per un numero illimitato di domini, Protezione DDoS, CDN con SSL gratuito, Regole firewall e regole di pagina, WAF, Bot Mitigation, Rate Limiting senza limiti - 1 regola per dominio, Analisi, Inoltro email
  * [Zero Trust & SASE](https://www.cloudflare.com/plans/zero-trust-services/) - Fino a 50 utenti, 24 ore di logging attività, tre posizioni di rete
  * [Cloudflare Tunnel](https://www.cloudflare.com/products/tunnel/) - Puoi esporre una porta HTTP in esecuzione localmente tramite tunnel su un sottodominio casuale su trycloudflare.com usando [Quick Tunnels](https://developers.cloudflare.com/cloudflare-one/connections/connect-networks/do-more-with-tunnels/trycloudflare/), nessun account richiesto. Più funzionalità (tunnel TCP, load balancing, VPN) nel piano Free di [Zero Trust](https://www.cloudflare.com/products/zero-trust/).
  * [Workers](https://developers.cloudflare.com/workers/) - Distribuisci codice serverless gratuitamente sulla rete globale Cloudflare—100k richieste giornaliere.
  * [Workers KV](https://developers.cloudflare.com/kv) - 100k richieste di lettura al giorno, 1000 richieste di scrittura al giorno, 1000 richieste di cancellazione al giorno, 1000 richieste di lista al giorno, 1 GB di dati archiviati
  * [R2](https://developers.cloudflare.com/r2/) - 10 GB al mese, 1 milione di operazioni Classe A al mese, 10 milioni di operazioni Classe B al mese
  * [D1](https://developers.cloudflare.com/d1/) - 5 milioni di righe lette al giorno, 100k righe scritte al giorno, 1 GB di storage
  * [Pages](https://developers.cloudflare.com/pages/) - Sviluppa e distribuisci le tue app web sulla rete globale veloce e sicura di Cloudflare. Cinquecento build mensili, 100 domini personalizzati, SSL integrato, collaboratori illimitati, distribuzioni di anteprima illimitate e capacità full-stack tramite integrazione Cloudflare Workers.
  * [Queues](https://developers.cloudflare.com/queues/) - 1 milione di operazioni al mese
  * [TURN](https://developers.cloudflare.com/calls/turn/) – 1TB di traffico gratuito (in uscita) al mese.

**[⬆️ Torna all'inizio](#table-of-contents)**

## Soluzioni di gestione cloud

* [Brainboard](https://www.brainboard.co) - Soluzione collaborativa per costruire e gestire visivamente infrastrutture cloud end-to-end.
* [Cloud 66](https://www.cloud66.com/) - Gratuito per progetti personali (incluso un server di deployment, un sito statico), Cloud 66 ti offre tutto il necessario per costruire, distribuire e far crescere le tue applicazioni su qualsiasi cloud senza la complessità della “roba server”.
* [Pulumi](https://www.pulumi.com/) — Piattaforma moderna di infrastructure as code che consente di utilizzare linguaggi e strumenti di programmazione familiari per costruire, distribuire e gestire infrastrutture cloud.
* [terraform.io](https://www.terraform.io/) — Terraform Cloud. Gestione remota dello stato gratuita e collaborazione per team fino a 500 risorse.
* [scalr.com](https://scalr.com/) - Scalr è un prodotto Terraform Automation and Collaboration (TACO) utilizzato per migliorare la collaborazione e l'automazione su infrastrutture e configurazioni gestite da Terraform. Supporto completo al CLI di Terraform, integrazione OPA e modello di configurazione gerarchico. Nessuna tassa SSO. Tutte le funzionalità incluse. Fino a 50 esecuzioni/mese gratuite.
* [deployment.io](https://deployment.io) - Deployment.io aiuta gli sviluppatori ad automatizzare i deployment su AWS. Nel piano gratuito, uno sviluppatore (utente singolo) può distribuire siti statici, servizi web e ambienti illimitati. Sono fornite 20 esecuzioni di job gratuite al mese con anteprime e auto-deploy inclusi nel piano gratuito.

**[⬆️ Torna all'inizio](#table-of-contents)**

## Repository di Codice Sorgente

* [Bitbucket](https://bitbucket.org/) — Repository Git pubblici e privati illimitati per un massimo di 5 utenti con Pipelines per CI/CD
* [chiselapp.com](https://chiselapp.com/) — Repository Fossil pubblici e privati illimitati
* [codebasehq.com](https://www.codebasehq.com/) — Un progetto gratuito con 100 MB di spazio e due utenti
* [Codeberg](https://codeberg.org/) — Repository Git pubblici e privati illimitati per progetti free e open source (con collaboratori illimitati). Basato su [Forgejo](https://forgejo.org/). Hosting di siti statici con [Codeberg Pages](https://codeberg.page/). Hosting CI/CD con [Codeberg's CI](https://docs.codeberg.org/ci/). Hosting di traduzioni con [Codeberg Translate](https://translate.codeberg.org/). Include hosting di package e container, gestione progetti e issue tracking.
* [GitGud](https://gitgud.io) — Repository privati e pubblici illimitati. Gratis per sempre. Basato su GitLab & Sapphire. CI/CD non fornito.
* [GitHub](https://github.com/) — Repository pubblici illimitati e repository privati illimitati (con collaboratori illimitati). Include CI/CD, ambiente di sviluppo, hosting statico, hosting di package e container, gestione progetti e AI Copilot
* [gitlab.com](https://about.gitlab.com/) — Repository Git pubblici e privati illimitati con fino a 5 collaboratori. Include CI/CD, hosting statico, Container Registry, gestione progetti e issue tracking
* [framagit.org](https://framagit.org/) — Framagit è la forge software di Framasoft basata sul software Gitlab e include CI, pagine statiche, pagine progetto e issue tracking.
* [heptapod.net](https://foss.heptapod.net/) — Heptapod è un fork amichevole di GitLab Community Edition che offre supporto per Mercurial
* [ionicframework.com](https://ionicframework.com/appflow) - Repository e strumenti per sviluppare applicazioni con Ionic; include anche un repo ionic
* [NotABug](https://notabug.org) — NotABug.org è una piattaforma di collaborazione per il codice libera per progetti con licenza libera, basata su Git
* [OSDN](https://osdn.net/) - OSDN.net è un servizio gratuito per sviluppatori di software open source, che offre repository SVN/Git/Mercurial/Bazaar/CVS.
* [Pagure.io](https://pagure.io) — Pagure.io è una piattaforma gratuita e open source per la collaborazione sul codice software per progetti con licenza FOSS, basata su Git
* [perforce.com](https://www.perforce.com/products/helix-teamhub) — 1GB Cloud gratuito e repository Git, Mercurial o SVN.
* [pijul.com](https://pijul.com/) - Sistema di controllo versione distribuito illimitato, gratuito e open source. La sua caratteristica distintiva si basa su una solida teoria delle patch, che lo rende facile da imparare, usare e distribuire. Risolve molti problemi di git/hg/svn/darcs.
* [plasticscm.com](https://plasticscm.com/) — Gratuito per individui, OSS e organizzazioni non profit
* [projectlocker.com](https://projectlocker.com) — Un progetto privato gratuito (Git e Subversion) con 50 MB di spazio
* [RocketGit](https://rocketgit.com) — Hosting di repository basato su Git. Repository pubblici e privati illimitati.
* [savannah.gnu.org](https://savannah.gnu.org/) - Serve come sistema di gestione collaborativa per lo sviluppo software di progetti free software (per progetti GNU)
* [savannah.nongnu.org](https://savannah.nongnu.org/) - Serve come sistema di gestione collaborativa per lo sviluppo software di progetti free software (per progetti non-GNU)

**[⬆️ Torna all'inizio](#table-of-contents)**

## API, Dati e ML

* [JSONGrid](https://jsongrid.com) - Strumento gratuito per visualizzare, modificare e filtrare dati JSON complessi in una tabella. Salva e condividi dati JSON tramite link.
* [Zerosheets](https://zerosheets.com) - Trasforma i tuoi fogli Google Sheets in potenti API per sviluppare rapidamente prototipi, siti web, app e altro. 500 richieste al mese disponibili gratuitamente.
* [IP.City](https://ip.city) — 100 richieste di geolocalizzazione IP gratuite al giorno
* [Abstract API](https://www.abstractapi.com) — Suite di API per vari casi d'uso, inclusa geolocalizzazione IP, rilevamento genere o validazione email.
* [Apify](https://www.apify.com/) — Piattaforma di web scraping e automazione per creare API per qualsiasi sito web ed estrarre dati. Scraper pronti all'uso, proxy integrati e soluzioni personalizzate. Piano gratuito con $5 di crediti mensili inclusi.
* [APITemplate.io](https://apitemplate.io) - Generazione automatica di immagini e documenti PDF tramite una semplice API o strumenti di automazione come Zapier & Airtable. Non è richiesto CSS/HTML. Il piano gratuito include 50 immagini/mese e tre template.
* [APIToolkit.io](https://apitoolkit.io) - Tutti gli strumenti necessari per comprendere appieno cosa succede nelle tue API e backend. Convalidazione e monitoraggio automatici dei contratti API. Il piano gratuito copre server fino a 10.000 richieste al giorno.
* [APIVerve](https://apiverve.com) - Accesso immediato a oltre 120+ API gratuite, progettate per qualità, coerenza e affidabilità. Il piano gratuito copre fino a 50 token API al mese. (Possibilmente non disponibile, 2025-06-25)
* [Arize AI](https://arize.com/) - Osservabilità ML per il monitoraggio dei modelli e analisi delle cause principali di problemi come la qualità dei dati e il drift delle prestazioni. Gratuito fino a due modelli.
* [Maxim AI](https://getmaxim.ai/) - Simula, valuta e osserva i tuoi agenti AI. Maxim è una piattaforma end-to-end per la valutazione e l’osservabilità, che aiuta i team a distribuire agenti AI in modo affidabile e >5x più velocemente. Gratuito per sempre per sviluppatori indipendenti e piccoli team (3 postazioni).
* [Beeceptor](https://beeceptor.com) - Mock di una REST API in pochi secondi, risposte API fittizie e molto altro. 50 richieste gratuite al giorno, dashboard pubblica, endpoint aperti (chiunque abbia il link della dashboard può vedere invii e risposte).
* [BigDataCloud](https://www.bigdatacloud.com/) - Offre API veloci, accurate e gratuite (illimitate o fino a 10K-50K/mese) per il web moderno come geolocalizzazione IP, reverse geocoding, networking insights, validazione email e telefono, info client e altro.
* [Browse AI](https://www.browse.ai) — Estrazione e monitoraggio dati dal web. 1k crediti al mese gratuiti, equivalenti a 1k richieste concorrenti.
* [BrowserCat](https://www.browsercat.com) - API browser headless per automazione, scraping, accesso web per agenti AI, generazione di immagini/pdf e altro. Piano gratuito con 1k richieste al mese.
* [Calendarific](https://calendarific.com) - API di festività pubbliche a livello enterprise per oltre 200 paesi. Il piano gratuito include 500 chiamate al mese.
* [Canopy](https://www.canopyapi.co/) - API GraphQL per dati su prodotti, ricerche e categorie Amazon.com. Il piano gratuito include 100 chiamate al mese.
* [Clarifai](https://www.clarifai.com) — API per immagini per riconoscimento e rilevamento facciale personalizzato. Possibilità di addestrare modelli AI. Il piano gratuito prevede 1.000 chiamate al mese.
* [Cloudmersive](https://cloudmersive.com/) — Piattaforma di utility API con accesso completo a una vasta libreria API, inclusa conversione documenti, scansione virus e altro con 600 chiamate/mese, solo North America AZ, dimensione massima file 2,5MB.
* [Colaboratory](https://colab.research.google.com) — Ambiente notebook Python web-based gratuito con GPU Nvidia Tesla K80.
* [CometML](https://www.comet.com/site/) - Piattaforma MLOps per tracking degli esperimenti, gestione della produzione dei modelli, registro modelli e tracciamento completo dei dati, dalla formazione alla produzione. Gratuito per individui e accademici.
* [Commerce Layer](https://commercelayer.io) - API di commercio componibile per costruire, gestire e controllare ordini da qualsiasi front end. Il piano developer permette 100 ordini al mese e fino a 1.000 SKU gratis.
* [Composio](https://composio.dev/) - Piattaforma di integrazione per AI Agents e LLMs. Integra oltre 200+ strumenti in tutto l’internet agentico.
* [Conversion Tools](https://conversiontools.io/) - Convertitore di file online per documenti, immagini, video, audio ed eBook. API REST disponibile. Librerie per Node.js, PHP, Python. Supporta file fino a 50 GB (per piani a pagamento). Il livello gratuito è limitato per dimensione file (20MB) e numero di conversioni (30/giorno, 300/mese).
* [Country-State-City Microservice API](https://country-state-city.rebuscando.info/) - API e microservizio che fornisce una vasta gamma di informazioni, tra cui paesi, regioni, province, città, codici postali e altro. Il livello gratuito include fino a 100 richieste al giorno.
* [Coupler](https://www.coupler.io/) - Strumento di integrazione dati che sincronizza tra app. Può creare dashboard e report in tempo reale, trasformare e manipolare valori, raccogliere e fare backup degli insight. Il piano gratuito è limitato a un utente, connessione, sorgente e destinazione dati, e richiede aggiornamento manuale dei dati.
* [CraftMyPDF](https://craftmypdf.com) - Generazione automatica di PDF da template riutilizzabili con editor drag-and-drop e semplice API. Il piano gratuito offre 100 PDF/mese e tre template.
* [Crawlbase](https://crawlbase.com/) — Crawl e scraping di siti web senza proxy, infrastruttura o browser. Risolviamo i captcha per te ed evitiamo blocchi. Le prime 1000 chiamate sono gratuite.
* [CurlHub](https://curlhub.io) — Servizio proxy per ispezionare e fare debug delle chiamate API. Il piano gratuito include 10.000 richieste al mese.
* [CurrencyScoop](https://currencyscoop.com) - API per dati valutari in tempo reale per app fintech. Il piano gratuito include 5.000 chiamate al mese.
* [Cube](https://cube.dev/) - Cube aiuta ingegneri e sviluppatori di dati ad accedere ai dati da archivi moderni, organizzarli in definizioni coerenti e distribuirli a ogni applicazione. Cube Cloud offre un piano gratuito limitato a 1.000 query al giorno.
* [Data Dead Drop](https://datadeaddrop.com) - Condivisione file semplice e gratuita. I dati si autodistruggono dopo l’accesso. Carica e scarica dati dal browser o dal tuo client da riga di comando preferito.
* [Data Fetcher](https://datafetcher.com) - Connetti Airtable a qualsiasi applicazione o API senza codice. Interfaccia tipo Postman per inviare richieste API in Airtable. Integrazioni predefinite con decine di app. Il piano gratuito include 100 esecuzioni al mese.
* [Dataimporter.io](https://www.dataimporter.io) - Strumento per collegare, pulire e importare dati in Salesforce. Piano gratuito fino a 20.000 record al mese.
* [Datalore](https://datalore.jetbrains.com) - Notebook Python di Jetbrains. Include 10 GB di storage e 120 ore di runtime ogni mese.
* [Data Miner](https://dataminer.io/) - Estensione browser (Google Chrome, MS Edge) per estrarre dati da pagine web in CSV o Excel. Il piano gratuito offre 500 pagine/mese.
* [Datapane](https://datapane.com) - API per costruire report interattivi in Python e distribuire script Python e Jupyter Notebook come strumenti self-service.
* [DB-IP](https://db-ip.com/api/free) - API gratuita di geolocalizzazione IP con 1k richieste per IP al giorno. Il database lite sotto licenza CC-BY 4.0 è anch’esso gratuito.
* [DB Designer](https://www.dbdesigner.net/) — Strumento cloud-based per la progettazione e modellazione di schemi database con piano starter gratuito per 2 modelli di database e dieci tabelle per modello.
* [DeepAR](https://developer.deepar.ai) — Filtri facciali AR per qualsiasi piattaforma con un solo SDK. Il piano gratuito prevede fino a 10 utenti attivi mensili (MAU) e tracciamento fino a 4 volti.
* [Deepnote](https://deepnote.com) - Nuovo notebook per data science. Compatibile con Jupyter, collaborazione in tempo reale e funzionamento in cloud. Il piano gratuito include progetti personali illimitati, macchine base illimitate con 5GB RAM e 2vCPU, e team fino a 3 editor.
* [Disease.sh](https://disease.sh/) — API gratuita che fornisce dati accurati per costruire app utili relative al Covid-19.
* [Doczilla](https://www.doczilla.app/) — SaaS API per generare screenshot o PDF direttamente da codice HTML/CSS/JS. Il piano gratuito consente 250 documenti al mese.
* [Doppio](https://doppio.sh/) — API gestita per generare e conservare privatamente PDF e screenshot usando tecnologia di rendering avanzata. Il piano gratuito consente 400 PDF e screenshot al mese.
* [drawDB](https://drawdb.app/) — Editor online ER diagram gratuito e open-source, senza registrazione richiesta.
* [dreamfactory.com](https://dreamfactory.com/) — Backend REST API open source per applicazioni mobile, web e IoT. Collega qualsiasi database SQL/NoSQL, sistema di storage file o servizio esterno, e crea istantaneamente una piattaforma REST API completa con documentazione live e gestione utenti.
* [Duply.co](https://duply.co) — Crea immagini dinamiche da API & URL, progetta un template una volta e riutilizzalo. Il piano gratuito offre 20 crediti.
* [DynamicDocs](https://advicement.io) - Genera documenti PDF con API JSON to PDF basata su template LaTeX. Il piano gratuito permette 50 chiamate API al mese e accesso a una libreria di template.
* [Efemarai](https://efemarai.com) - Piattaforma di test e debug per modelli e dati ML. Visualizza qualsiasi grafo computazionale. Uso locale gratuito.
* [ERD Lab](https://www.erdlab.io) —  Strumento cloud gratuito per diagrammi ER (entity relationship) pensato per sviluppatori. La prova gratuita include 2 progetti con 10 tabelle ciascuno.
* [ExtendsClass](https://extendsclass.com/rest-client-online.html) - HTTP client web gratuito per inviare richieste HTTP.
* [Export SDK](https://exportsdk.com) - API generatore PDF con editor drag-and-drop che fornisce SDK e integrazioni no-code. Il piano gratuito ha 250 pagine mensili, utenti illimitati e tre template.
* [file.coffee](https://file.coffee/) - Piattaforma dove puoi archiviare fino a 15MB/file (30MB/file con account).
* [Financial Data](https://financialdata.net/) - API per dati di mercato azionario e finanziari. Il piano gratuito permette 300 richieste al giorno.
* [FormatJSONOnline.com](https://formatjsononline.com) - Strumento gratuito via browser per formattare, validare, confrontare e minimizzare dati JSON istantaneamente.
* [FraudLabs Pro](https://www.fraudlabspro.com) — Analizza una transazione d’ordine per rilevare frodi nei pagamenti con carta di credito. Questa REST API rileva tutti i possibili tratti di frode in base ai parametri di input. Il piano Micro gratuito offre 500 transazioni al mese.
* [GeoDataSource](https://www.geodatasource.com) — Servizio di ricerca posizione che trova nomi di città tramite coordinate latitudine e longitudine. API gratuita fino a 500 query al mese.
* [Geolocated.io](https://geolocated.io) — API di geolocalizzazione IP con server su più continenti, piano gratuito con 2.000 richieste al giorno.
* [Glitterly](https://glitterly.app/) - Generazione programmata di immagini dinamiche da template base. API RESTful e integrazioni nocode. Il piano gratuito offre 50 immagini/mese e cinque template.
* [Hex](https://hex.tech/) - Piattaforma collaborativa per notebook, app dati e knowledge libraries. Livello community gratuito con fino a cinque progetti.
* [Hook0](https://www.hook0.com/) - Hook0 è un servizio open-source di Webhooks-as-a-service (WaaS) che facilita l’offerta di webhooks nei prodotti online. Fino a 100 eventi/giorno con 7 giorni di retention gratuita.
* [Hoppscotch](https://hoppscotch.io) - Builder gratuito, veloce e bello per richieste API.
* [huggingface.co](https://huggingface.co) - Crea, addestra e distribuisci modelli NLP per Pytorch, TensorFlow e JAX. Gratuito fino a 30k caratteri in input/mese.
* [Hybiscus](https://hybiscus.dev/) - Crea report PDF usando una semplice API dichiarativa. Il livello gratuito di 14 giorni include 50 report di una pagina con possibilità di personalizzare palette colori e font.
* [Invantive Cloud](https://cloud.invantive.com/) — Accedi a oltre 70 piattaforme (cloud) come Exact Online, Twinfield, ActiveCampaign o Visma usando Invantive SQL o OData4 (tipicamente Power BI o Power Query). Include replica ed exchange dati. Piano gratuito per sviluppatori e consulenti implementatori. Gratuito per specifiche piattaforme con limiti nei volumi dati.
* [ipaddress.sh](https://ipaddress.sh) — Servizio semplice per ottenere un indirizzo IP pubblico in diversi [formati](https://about.ipaddress.sh/).
* [ip-api](https://ip-api.com) — API di geolocalizzazione IP, gratuita per uso non commerciale, nessuna chiave API richiesta, limite di 45 richieste/minuto dallo stesso IP nel piano gratuito.
* [ipbase.com](https://ipbase.com) - API di geolocalizzazione IP - Piano gratuito per sempre con 150 richieste mensili.
* [IP Geolocation](https://ipgeolocation.io/) — API di geolocalizzazione IP - Piano gratuito per sempre per sviluppatori con limite di 1.000 richieste al giorno.
* [IP Geolocation API](https://www.abstractapi.com/ip-geolocation-api) — API di geolocalizzazione IP da Abstract - Consente 1.000 richieste gratuite.
* [IPLocate](https://www.iplocate.io) — API di geolocalizzazione IP, gratuita fino a 1.000 richieste/giorno. Include rilevamento proxy/VPN/hosting, dati ASN, IP to Company e altro. IPLocate offre anche database IP to Country e IP to ASN scaricabili gratuitamente in formato CSV o MMDB compatibile GeoIP.
* [IP2Location](https://www.ip2location.com) — Servizio di geolocalizzazione IP freemium. Il database LITE è disponibile per il download gratuito. Importa il database sul server ed esegui query locali per determinare città, coordinate e ISP.
* [IP2Location.io](https://www.ip2location.io/) — API di geolocalizzazione IP freemium, veloce e affidabile. Ottieni dati come città, coordinate, ISP e altro. Il piano gratuito include 50k crediti al mese. IP2Location.io offre anche 500 lookup WHOIS e domini hostati gratuiti al mese. Visualizza dettagli registrazione dominio e trova domini hostati su uno specifico IP. Passa a un piano a pagamento per più funzionalità.
* [ipapi](https://ipapi.co/) - API di localizzazione indirizzo IP di Kloudend, Inc - API affidabile basata su AWS, usata da Fortune 500. Il piano gratuito offre 30k lookup/mese (1k/giorno) senza registrazione.
* [ipapi.is](https://ipapi.is/) - API affidabile per indirizzi IP, creata da sviluppatori per sviluppatori, con le migliori capacità di rilevamento hosting esistenti. Il piano gratuito offre 1000 lookup senza registrazione.
* [IPinfo](https://ipinfo.io/) — API veloce, accurata e gratuita (fino a 50k/mese) per dati indirizzi IP. Offre API con dettagli su geolocalizzazione, aziende, carrier, range IP, domini, contatti abuso e altro. Tutte le API a pagamento si possono provare gratis.
* [IPQuery](https://ipquery.io) — API IP illimitata per sviluppatori, senza limiti di richiesta o prezzi.
* [IPTrace](https://iptrace.io) — API semplicissima per fornire dati IP geolocalizzati affidabili e utili, con 50.000 lookup gratuiti al mese.
* [JSON2Video](https://json2video.com) - API di video editing per automatizzare video marketing e social media video, in modo programmato o senza codice.
* [JSON IP](https://getjsonip.com) — Restituisce l’indirizzo IP pubblico del client che effettua la richiesta. Nessuna registrazione richiesta per il livello gratuito. Usando CORS, i dati possono essere richiesti direttamente dal browser tramite JS lato client. Utile per servizi di monitoraggio cambi IP client/server. Richieste illimitate.
* [JSON Serve](https://jsonserve.com/) — Servizio gratuito che aiuta gli sviluppatori a memorizzare oggetti JSON e usare quel JSON come REST API nella propria app.
* [JSONing](https://jsoning.com/api/) — Crea una REST API fittizia da un oggetto JSON e personalizza status code HTTP, header e corpo risposta.
* [konghq.com](https://konghq.com/) — API Marketplace e potenti strumenti API privati e pubblici. Con il piano gratuito, alcune funzionalità come monitoring, alerting e supporto sono limitate.
* [Kreya](https://kreya.app) — Client GUI gratuito per gRPC per chiamare e testare API gRPC. Può importare API gRPC tramite server reflection.
* [Lightly](https://www.lightly.ai/) — Migliora i tuoi modelli ML usando i dati corretti. Usa dataset fino a 1.000 campioni gratuitamente.
* [LoginLlama](https://loginllama.app) - API di sicurezza login per rilevare accessi fraudolenti e sospetti e notificare i tuoi clienti. Gratuito per 1.000 login al mese.
* [MailboxValidator](https://www.mailboxvalidator.com) — Servizio di verifica email tramite connessione reale ai mail server per confermare la validità. Il piano API gratuito prevede 100 verifiche al mese.
* [Market Data API](https://www.marketdata.app) - Fornisce dati finanziari in tempo reale e storici su azioni, opzioni, fondi comuni e altro. Il piano API Free Forever consente 100 richieste API giornaliere senza costi.
* [Meteosource Weather API](https://www.meteosource.com/) — API meteorologico globale per dati meteo attuali e previsionali. Le previsioni si basano su una combinazione di modelli meteo tramite machine learning per ottenere una maggiore precisione. Il piano gratuito offre 400 chiamate al giorno.
* [microlink.io](https://microlink.io/) – Trasforma qualsiasi sito web in dati come normalizzazione dei metatag, anteprime di link esteticamente gradevoli, funzionalità di scraping o screenshot come servizio. 50 richieste al giorno, gratis ogni giorno.
* [Mindee](https://developers.mindee.com) – Mindee è un potente software OCR e una piattaforma API-first che aiuta gli sviluppatori ad automatizzare i workflow delle applicazioni standardizzando lo strato di elaborazione dei documenti tramite il riconoscimento dei dati chiave usando computer vision e machine learning. Il livello gratuito offre 500 pagine al mese.
* [Mintlify](https://mintlify.com) — Standard moderno per la documentazione API. Componenti UI belli e facili da mantenere, ricerca in-app e playground interattivo. Gratuito per 1 editor.
* [MockAPI](https://www.mockapi.io/) — MockAPI è uno strumento semplice che ti consente di simulare rapidamente API, generare dati personalizzati ed eseguire operazioni tramite un'interfaccia RESTful. MockAPI è pensato come strumento di prototipazione/test/apprendimento. Un progetto/2 risorse per progetto gratis.
* [Mockfly](https://www.mockfly.dev/) — Mockfly è uno strumento di sviluppo affidabile per la simulazione di API e gestione dei feature flag. Genera e controlla rapidamente API di prova tramite un'interfaccia intuitiva. Il piano gratuito offre 500 richieste al giorno.
* [Mocki](https://mocki.io) - Uno strumento che ti consente di creare API mock GraphQL e REST sincronizzate con un repository GitHub. Le API REST semplici sono gratuite da sviluppare e usare senza registrazione.
* [Mocko.dev](https://mocko.dev/) — Proxya la tua API, scegli quali endpoint simulare nel cloud e ispeziona il traffico, gratuitamente. Accelera lo sviluppo e i test di integrazione.
* [Mocky](https://designer.mocky.io/) - Web app semplice per generare risposte HTTP personalizzate per simulare richieste HTTP. Disponibile anche come [open source](https://github.com/julien-lafont/Mocky).
* [Mock N Roll](https://mpcknroll.me/) - Servizio gratuito di API mock: uno strumento potente per simulare risposte API reali senza ritardi di backend. Perfetto per sviluppatori frontend, tester QA e team DevOps. [repo](https://github.com/haerulmuttaqin/mocknroll-web).
* [microenv.com](https://microenv.com) — Crea fake REST API per sviluppatori con la possibilità di generare codice e app in un contenitore docker.
* [Multi-Exit IP Address Checker](https://ip.alstra.ca/) — Strumento gratuito e semplice per controllare il proprio indirizzo IP di uscita su più nodi e capire come il tuo IP appare in diverse regioni e servizi globali. Utile per testare strumenti di split DNS basati su regole come Control D.
* [Namekit](https://namekit.app/) - Scoperta di domini alimentata da AI – trova nomi disponibili a prezzo standard istantaneamente. Query giornaliere gratuite.
* [News API](https://newsapi.org) — Cerca notizie sul web via codice e ottieni risultati in JSON. Gli sviluppatori hanno 100 query gratuite al giorno. Gli articoli hanno un ritardo di 24 ore.
* [numlookupapi.com](https://numlookupapi.com) - API gratuita di validazione dei numeri di telefono - 100 richieste gratuite/mese.
* [OCR.Space](https://ocr.space/) — Un'API OCR che analizza immagini e file PDF restituendo i risultati testuali in formato JSON. 25.000 richieste gratuite al mese e limite di 1MB per file.
* [OpenAPI3 Designer](https://openapidesigner.com/) — Crea visivamente definizioni Open API 3 gratuitamente.
* [parsehub.com](https://parsehub.com/) — Estrai dati da siti dinamici, trasforma siti web dinamici in API, cinque progetti gratuiti.
* [Parseur](https://parseur.com) — 20 pagine gratuite/mese: Estrai dati da PDF, email. Alimentato da AI. Accesso API completo.
* [PDFBolt](https://pdfbolt.com) - API per la generazione di PDF pensata per gli sviluppatori, con particolare attenzione alla privacy. Offre documentazione ispirata a Stripe e include 500 conversioni PDF gratuite al mese.
* [pdfEndpoint.com](https://pdfendpoint.com) - Converti facilmente HTML o URL in PDF tramite una semplice API. Cento conversioni al mese gratis.
* [PDF-API.io](https://pdf-api.io) - API di automazione PDF, editor visuale di template o HTML to PDF, integrazione dati dinamici e rendering PDF tramite API. Il piano gratuito include un template e 100 PDF/mese.
* [Pixela](https://pixe.la/) - Servizio gratuito di database daystream. Tutte le operazioni vengono eseguite tramite API. È possibile anche la visualizzazione con heatmap e grafici a linee.
* [Postman](https://postman.com) — Semplifica i workflow e crea API migliori – più velocemente – con Postman, una piattaforma di collaborazione per lo sviluppo di API. Usa la Postman App gratis per sempre. Le funzionalità cloud di Postman sono anch'esse gratuite per sempre con alcuni limiti.
* [Insomnia](https://insomnia.rest) - Client API open source per progettare e testare API, supporta REST e GraphQL.
* [PrefectCloud](https://www.prefect.io/cloud/) — Piattaforma completa per l'automazione dei flussi di dati. Il piano gratuito include 5 workflow distribuiti e 500 minuti di crediti serverless al mese.
* [Preset Cloud](https://preset.io/) - Servizio Apache Superset gestito. Sempre gratuito per team fino a 5 utenti, con dashboard e grafici illimitati, builder di grafici no-code ed editor SQL collaborativo.
* [PromptLoop](https://www.promptloop.com/) - PromptLoop offre scraping AI 10 volte più semplice con tempo di adozione quasi nullo, oltre l'85% di tempo risparmiato nei workflow esistenti, e funziona 4 volte più velocemente della ricerca manuale senza compromessi; include un endpoint API REST per tutte le attività di ricerca. I primi 1.000 crediti sono gratuiti ogni mese.
* [Public-Apis Github Repo](https://github.com/public-apis/public-apis) — Un elenco di API pubbliche gratuite.
* [Rapidapi](https://rapidapi.com/) - Il più grande hub API al mondo. Milioni di sviluppatori trovano e si connettono a migliaia di API, sviluppo API tramite sfide divertenti (con soluzioni!) ed esempi interattivi.
* [RequestBin.com](https://requestbin.com) — Crea un endpoint gratuito a cui puoi inviare richieste HTTP. Tutte le richieste HTTP inviate a quell'endpoint verranno registrate con payload e header associati per poter osservare raccomandazioni da webhook e altri servizi.
* [reqres.in](https://reqres.in) - REST-API ospitata gratuitamente pronta a rispondere alle tue richieste AJAX.
* [Roboflow](https://roboflow.com) - crea e distribuisci un modello di computer vision personalizzato senza esperienza di machine learning. Il livello gratuito include 30 crediti al mese.
* [ROBOHASH](https://robohash.org/) - Servizio web per generare immagini uniche e creative da qualsiasi testo.
* [Scraper's Proxy](https://scrapersproxy.com) — Semplice API proxy HTTP per scraping. Effettua scraping anonimo senza preoccuparti di restrizioni, blocchi o captcha. I primi 100 scraping riusciti al mese sono gratuiti, incluso il rendering javascript (più disponibili contattando il supporto).
* [ScrapingAnt](https://scrapingant.com/) — API di scraping con Chrome headless e servizio proxy gratuito controllato. Rendering javascript, proxy premium rotanti, evita CAPTCHA. 10.000 crediti API gratuiti.
* [Simplescraper](https://simplescraper.io) — Attiva il tuo webhook dopo ogni operazione. Il piano gratuito include 100 crediti cloud scrape.
* [Select Star](https://www.selectstar.com/) - piattaforma intelligente di data discovery che analizza e documenta automaticamente i tuoi dati. Piano light gratuito con 2 Data Source, fino a 1.000 tabelle e 25 utenti.
* [Sheetson](https://sheetson.com) - Trasforma istantaneamente qualsiasi Google Sheets in una RESTful API. Piano gratuito disponibile, inclusi 1.000 righe gratuite per foglio.
* [Shipyard](https://www.shipyardapp.com) — Piattaforma low-code di orchestrazione dati per il cloud. Costruisci con un mix di template low-code e il tuo codice (Python, Node.js, Bash, SQL). Il nostro piano gratuito offre 10 ore di runtime ogni mese per un utente - più che sufficienti per automatizzare diversi workflow.
* [Siterelic](https://siterelic.com/) - L'API Siterelic consente di fare screenshot, audit di siti, scansione TLS, lookup DNS, test TTFB e altro. Il piano gratuito offre 100 richieste API al mese.
* [SerpApi](https://serpapi.com/) - API di scraping in tempo reale dei motori di ricerca. Restituisce risultati JSON strutturati per Google, YouTube, Bing, Baidu, Walmart e molti altri. Il piano gratuito include 100 chiamate API riuscite al mese.
* [SmartParse](https://smartparse.io) - SmartParse è una piattaforma di migrazione dati e da CSV a API che offre strumenti per sviluppatori per risparmiare tempo e costi. Il piano Free include 300 Processing Unit al mese, upload da browser, quarantena dati, circuit breaker e Job Alerts.
* [Sofodata](https://www.sofodata.com/) - Crea API RESTful sicure da file CSV. Carica un file CSV e accedi subito ai dati tramite API, consentendo uno sviluppo applicativo più rapido. Il piano gratuito include 2 API e 2.500 chiamate API al mese. Nessuna carta di credito richiesta.
* [Sqlable](https://sqlable.com/) - Collezione di strumenti SQL online gratuiti, incluso formatter e validatore SQL, tester di regex SQL, generatore di dati fake e playground interattivi per database.
* [Stoplight](https://stoplight.io/) - SaaS per progettare e documentare API collaborativamente. Il piano gratuito offre strumenti di design, mocking e documentazione gratuiti.
* [Supportivekoala](https://supportivekoala.com/) — Consente di autogenerare immagini dai tuoi input tramite template. Il piano gratuito permette di creare fino a 50 immagini al mese.
* [Svix](https://www.svix.com/) - Webhook come servizio. Invia fino a 50.000 messaggi/mese gratuitamente.
* [Tavily AI](https://tavily.com/) - API per ricerca online e insight rapidi e ricerca completa, con capacità di organizzazione dei risultati. 1.000 richieste/mese nel piano gratuito, senza necessità di carta di credito.
* [The IP API](https://theipapi.com/) - API di geolocalizzazione IP con 1.000 richieste gratuite/giorno. Fornisce informazioni sulla posizione dell'indirizzo IP, tra cui paese, città, regione e altro.
* [TinyMCE](https://www.tiny.cloud) - API di editing rich text. Le funzionalità core sono gratuite per uso illimitato.
* [Tomorrow.io Weather API](https://www.tomorrow.io/weather-api/) - Offre piano gratuito di API meteo. Fornisce previsioni meteo accurate e aggiornate con copertura globale, dati storici e soluzioni di monitoraggio.
* [Treblle](https://www.treblle.com) - Treblle aiuta i team a costruire, distribuire e gestire API. Con aggregazione avanzata dei log, osservabilità, documentazione e debugging. Tutte le funzionalità sono gratuite ma c'è un limite di fino a 250k richieste al mese nel piano free.
* [UniRateAPI](https://unirateapi.com) – Tassi di cambio in tempo reale per oltre 590 valute e criptovalute. Chiamate API illimitate nel piano gratuito, perfetto per sviluppatori e app finanziarie.
* [vatcheckapi.com](https://vatcheckapi.com) - API semplice e gratuita di validazione numeri IVA. 150 validazioni gratuite al mese.
* [WeatherXu](https://weatherxu.com/) — Dati meteo globali inclusi condizioni attuali, previsioni orarie e giornaliere, e allerte meteo via API. Integrazione di modelli AI e sistemi ML per analizzare e combinare più modelli meteo e fornire previsioni più accurate. Piano gratuito con 10.000 chiamate API/mese.
* [Webhook Store](https://www.openwebhook.io) - Strumento per memorizzare webhook di terze parti e debuggare in locale (stile ngrok). Open source e self-hostabile. Dominio personale gratuito *username*.github.webhook.store, domini pubblici gratuiti *anything*.webhook.store.
* [WebScraping.AI](https://webscraping.ai) - API di web scraping semplice con parsing integrato, rendering Chrome e proxy. Duemila chiamate API gratuite al mese.
* [Weights & Biases](https://wandb.ai) — Piattaforma MLOps developer-first. Costruisci modelli migliori più velocemente con tracking degli esperimenti, versionamento dei dataset e gestione dei modelli. Piano free solo per progetti personali, include 100 GB di storage.
* [What The Diff](https://whatthediff.ai) - Assistente di code review AI-powered. Il piano gratuito ha un limite di 25.000 token mensili (~10 PR).
* [wolfram.com](https://wolfram.com/language/) — Algoritmi integrati basati sulla conoscenza nel cloud.
* [wrapapi.com](https://wrapapi.com/) — Trasforma qualsiasi sito web in un'API parametrizzata. 30k chiamate API al mese.
* [Zenscrape](https://zenscrape.com/web-scraping-api) — API di web scraping con browser headless, IP residenziali e prezzi semplici. Mille chiamate API gratuite/mese e crediti extra per studenti e non profit.
* [Zipcodebase](https://zipcodebase.com) - API gratuita di codici postali, accesso a dati di codici postali mondiali. 5.000 richieste gratuite/mese.
* [Zipcodestack](https://zipcodestack.com) - API gratuita di codici postali e validazione. Diecimila richieste gratuite/mese.
* [Zuplo](https://zuplo.com/) - Piattaforma gratuita di API Management per progettare, costruire e distribuire API all'Edge. Aggiungi autenticazione API Key, rate limiting, documentazione per sviluppatori e monetizzazione a qualsiasi API in pochi minuti. OpenAPI-native e completamente programmabile con API web standard e Typescript. Il piano gratuito offre fino a 10 progetti, ambienti di produzione edge illimitati, 1M richieste mensili e 10GB di traffico in uscita.

**[⬆️ Torna all'inizio](#table-of-contents)**

## Artifact Repos

* [Artifactory](https://jfrog.com/start-free/) - Un repository di artefatti che supporta numerosi formati di pacchetti come Maven, Docker, Cargo, Helm, PyPI, CocoaPods e GitLFS. Include lo strumento di scansione XRay e lo strumento CI/CD Pipelines (ex Shippable) con un livello gratuito di 2.000 minuti CI/CD al mese.
* [central.sonatype.org](https://central.sonatype.org) — Il repository artefatti predefinito per Apache Maven, SBT e altri sistemi di build.
* [cloudrepo.io](https://cloudrepo.io) - Repository Maven e PyPi cloud-based, privati e pubblici. Gratis per progetti open source.
* [cloudsmith.io](https://cloudsmith.io) — Servizio di repository semplice, sicuro e centralizzato per Java/Maven, RedHat, Debian, Python, Ruby, Vagrant e altro. Livello gratuito + gratis per open source.
* [jitpack.io](https://jitpack.io/) — Repository Maven per progetti JVM e Android su GitHub, gratis per progetti pubblici.
* [packagecloud.io](https://packagecloud.io/users/new?plan=free_usage_plan) — Hosting di repository facile da usare per pacchetti Maven, RPM, DEB, PyPi, NPM e RubyGem (ha piano gratuito).
* [repsy.io](https://repsy.io) — 1 GB di repository Maven privato/pubblico gratuito.
* [Gemfury](https://gemfury.com) — Repository di artefatti privati e pubblici per Maven, PyPi, NPM, Go Module, Nuget, APT e RPM. Gratis per progetti pubblici.
* [paperspace](https://www.paperspace.com/) — Costruisci e scala modelli AI, sviluppa, addestra e distribuisci applicazioni AI, piano gratuito: progetti pubblici, 5Gb storage, istanze base.
* [RepoForge](https://repoforge.io) - Repository privato cloud-hosted per pacchetti Python, Debian, NPM e registri Docker. Piano gratuito per progetti open source/pubblici.
* [RepoFlow](https://repoflow.io) - RepoFlow semplifica la gestione dei pacchetti con supporto per npm, PyPI, Docker, Go, Helm e altro. Provalo gratis con 10GB di storage, 10GB di banda, 100 pacchetti e utenti illimitati nel cloud, oppure self-hosted solo per uso personale.

**[⬆️ Torna all'inizio](#table-of-contents)**

## Strumenti per Team e Collaborazione
* [3Cols](https://3cols.com/) - Gestore di snippet di codice cloud gratuito per uso personale e collaborativo.
* [Bitwarden](https://bitwarden.com) — Il modo più semplice e sicuro per individui, team e aziende di archiviare, condividere e sincronizzare dati sensibili.
* [Braid](https://www.braidchat.com/) — App di chat progettata per team. Gratis per gruppi ad accesso pubblico, utenti illimitati, cronologia e integrazioni. Disponibile anche versione open source self-hostabile.
* [cally.com](https://cally.com/) — Trova il momento e la data perfetta per una riunione. Semplice da usare, ottimo per piccoli e grandi gruppi.
* [Calendly](https://calendly.com) — Calendly è lo strumento per connettere e pianificare riunioni. Il piano gratuito offre 1 connessione calendario per utente e sessioni illimitate. Disponibili anche app desktop e mobile.
* [Discord](https://discord.com/) — Chat con stanze pubbliche/private. Testo Markdown, voce, video e condivisione schermo. Gratis per utenti illimitati.
* [Fibo](https://fibo.dev) - Strumento scrum poker online realtime gratuito per team agili che consente a membri illimitati di stimare story point per una pianificazione più rapida.
* [Telegram](https://telegram.org/) — Telegram è per chiunque desideri messaggistica e chiamate veloci e affidabili. Gli utenti business e i piccoli team possono apprezzare i grandi gruppi, i nomi utente, le app desktop e le potenti opzioni di condivisione file.
* [DevToolLab](https://devtoollab.com) — Strumenti online per sviluppatori che offrono accesso gratuito a tutti gli strumenti base, con possibilità di autosalvataggio di una voce per tool, velocità standard e supporto community.
* [Dubble](https://dubble.so/) — Creatore gratuito di guide passo-passo. Cattura screenshot, documenta processi e collabora col tuo team. Supporta anche registrazione schermo asincrona.
* [Duckly](https://duckly.com/) — Parla e collabora in tempo reale col tuo team. Pair programming con IDE, condivisione terminale, voce, video e schermo. Gratis per piccoli team.
* [Dyte](https://dyte.io) - L'SDK di video & audio live più developer-friendly, con plugin collaborativi per aumentare produttività e coinvolgimento. Il piano gratuito include 10.000 minuti mensili di video/audio live.
* [evernote.com](https://evernote.com/) — Strumento per organizzare informazioni. Condividi note e lavora insieme agli altri.
* [Fibery](https://fibery.io/) — Piattaforma workspace connessa. Gratuito per utenti singoli, fino a 2 GB di spazio disco.
* [flock.com](https://flock.com) — Un modo più veloce per il tuo team di comunicare. Messaggi, canali, utenti, app e integrazioni illimitate gratuitamente.
* [Gather](https://www.gather.town/) - Un modo migliore per incontrarsi online. Incentrato su spazi completamente personalizzabili, Gather rende lo stare insieme alle proprie comunità facile quanto nella vita reale. Gratuito fino a 10 utenti contemporanei.
* [gokanban.io](https://gokanban.io) - Kanban Board basata su sintassi, senza registrazione per un utilizzo veloce. Gratuito senza limitazioni.
* [flat.social](https://flat.social) - Spazi interattivi e personalizzabili per riunioni di team & socialità. Riunioni illimitate, gratuito fino a 8 utenti contemporanei.
* [GitDailies](https://gitdailies.com) - Report giornalieri sull’attività di Commit e Pull Request del tuo team su GitHub. Include visualizzatore Push, sistema di riconoscimento tra pari, e generatore di avvisi personalizzati. Il piano gratuito prevede utenti illimitati, tre repository e 3 configurazioni di avviso.
* [gitter.im](https://gitter.im/) — Chat, per GitHub. Stanze pubbliche e private illimitate, gratuito per team fino a 25 persone.
* [Hackmd.io](https://hackmd.io/) - Strumento di collaborazione e scrittura in tempo reale per documenti/file in formato markdown. Come Google Docs ma per file markdown. Numero illimitato di "note" gratuito, ma il numero di collaboratori (invitati) per note private & template [sarà limitato](https://hackmd.io/pricing).
* [hangouts.google.com](https://hangouts.google.com/) — Un unico posto per tutte le tue conversazioni, gratis, serve un account Google.
* [HeySpace](https://hey.space) - Strumento di gestione attività con chat, calendario, timeline e videochiamate. Gratuito fino a 5 utenti.
* [helplightning.com](https://www.helplightning.com/) — Assistenza tramite video con realtà aumentata. Gratuito senza analisi, crittografia, supporto.
* [ideascale.com](https://ideascale.com/) — Permette ai clienti di inviare idee e votare, gratuito per 25 membri in 1 comunità.
* [Igloo](https://www.igloosoftware.com/) — Portale interno per la condivisione di documenti, blog, calendari, ecc. Gratuito fino a 10 utenti.
* [Keybase](https://keybase.io/) — Keybase è un’alternativa FOSS a Slack; mantiene chat e file di tutti al sicuro, dalle famiglie alle comunità alle aziende.
* [Google Meet](https://meet.google.com/) — Usa Google Meet per le esigenze di videoconferenze online della tua azienda. Meet offre riunioni online sicure e facili da avviare.
* [/meet for Slack](https://meetslack.com) - Avvia Google Meetings direttamente da Slack usando /meet in qualsiasi canale, gruppo o DM. Gratis senza limitazioni.
* [Livecycle](https://www.livecycle.io/) — Livecycle è una piattaforma di collaborazione inclusiva che rende i flussi di lavoro senza attriti per team di prodotto cross-funzionali e progetti open-source.
* [Lockitbot](https://www.lockitbot.com/) — Prenota e blocca risorse condivise all'interno di Slack come stanze, ambienti di sviluppo, server ecc. Gratuito fino a 2 risorse.
* [MarkUp](https://www.markup.io/) — MarkUp ti consente di raccogliere feedback direttamente su siti web, PDF e immagini.
* [Proton Pass](https://proton.me/pass) — Gestore di password con alias email integrati, autenticatore 2FA, condivisione e passkey. Disponibile su web, estensione browser, app mobile e desktop.
* [Visual Debug](https://visualdebug.com) - Strumento di feedback visivo per una migliore comunicazione tra cliente e sviluppatore.
* [meet.jit.si](https://meet.jit.si/) — Videoconversazioni e condivisione schermo con un click, gratis.
* [Microsoft Teams](https://products.office.com/microsoft-teams/free) — Microsoft Teams è un hub digitale basato su chat che riunisce conversazioni, contenuti e app in un unico posto. Gratuito fino a 500k utenti.
* [Miro](https://miro.com/) - Lavagna collaborativa scalabile, sicura, multi-dispositivo e pronta per l'impresa per team distribuiti. Con piano freemium.
* [nootiz](https://www.nootiz.com/) - Lo strumento di riferimento per raccogliere e gestire feedback visivi su qualsiasi sito web.
* [Notion](https://www.notion.so/) - Notion è un'applicazione per prendere note e collaborare con supporto markdown che integra attività, wiki e database. L’azienda descrive l’app come uno spazio di lavoro all-in-one per note, gestione progetti e attività. Oltre alle app multipiattaforma, è accessibile tramite la maggior parte dei browser web.
* [Nuclino](https://www.nuclino.com) - Wiki leggero e collaborativo per tutta la conoscenza, documenti e note del team. Piano gratuito con tutte le funzionalità essenziali, fino a 50 elementi e 5GB di storage.
* [OnlineInterview.io](https://onlineinterview.io/) - Piattaforma gratuita per colloqui di codice con video chat integrata, lavagna e editor di codice online dove puoi compilare ed eseguire il codice nel browser. Puoi creare una stanza di colloquio remoto con un solo click.
* [Quidlo Timesheets](https://www.quidlo.com/timesheets) - App semplice di timesheet e tracciamento ore per team. Il piano gratuito consente tracciamento del tempo e generazione di report per fino a 10 utenti.
* [PageShare.dev](https://www.pageshare.dev) - Aggiunge capacità di revisione visiva nelle Pull Request GitHub senza la necessità di distribuire i siti. Gratis fino a 10 pagine al mese e 100MB di storage totale.
* [Pendulums](https://pendulums.io/) - Pendulums è uno strumento gratuito di tracciamento del tempo che ti aiuta a gestire meglio il tempo con interfaccia facile e statistiche utili.
* [Pumble](https://pumble.com) - App di chat gratuita per team. Utenti e cronologia messaggi illimitati, gratis per sempre.
* [Raindrop.io](https://raindrop.io) - App privata e sicura per i segnalibri su macOS, Windows, Android, iOS e Web. Segnalibri e collaborazione illimitati gratuitamente.
* [element.io](https://element.io/) — Strumento di comunicazione decentralizzato e open-source basato su Matrix. Chat di gruppo, messaggi diretti, trasferimenti file criptati, chiamate vocali/video e facile integrazione con altri servizi.
* [Rocket.Chat](https://rocket.chat/) - Piattaforma di comunicazione open-source con funzionalità Omnichannel, Federazione Matrix, Bridge con altre app, messaggistica illimitata e cronologia completa dei messaggi.
* [seafile.com](https://www.seafile.com/) — Archiviazione privata o cloud, condivisione file, sincronizzazione, discussioni. La versione cloud ha solo 1 GB.
* [Sema](https://www.semasoftware.com/) - Strumento gratuito per portfolio sviluppatori capace di consolidare e mostrare contributi da più repository in un unico report.
* [Screen Sharing via Browser](https://screensharing.net) - Strumento gratuito di condivisione schermo, condividi lo schermo con collaboratori direttamente dal browser, senza download o registrazione. Gratis.
* [Slab](https://slab.com/) — Moderno servizio di gestione della conoscenza per team. Gratuito fino a 10 utenti.
* [slack.com](https://slack.com/) — Gratuito per utenti illimitati con alcune limitazioni di funzionalità.
* [Spectrum](https://spectrum.chat/) - Crea comunità pubbliche o private gratuitamente.
* [StatusPile](https://www.statuspile.com/) - Una pagina di stato delle pagine di stato. Puoi tracciare le pagine di stato dei tuoi fornitori a monte?
* [Stickies](https://stickies.app/) - App di collaborazione visiva per brainstorming, cura dei contenuti e note. Gratuito fino a 3 Walls, utenti illimitati e 1 GB di storage.
* [Stacks](https://betterstacks.com/) - Spazio di lavoro per contenuti con note integrate, link e archiviazione file per gestire il sovraccarico di informazioni. Piano personale gratuito per sempre.
* [talky.io](https://talky.io/) — Videochat di gruppo gratuita. Anonima. Peer‑to‑peer. Nessun plugin, iscrizione o pagamento richiesto.
* [Teamhood](https://teamhood.com/) - Software gratuito di Project, Task e Issue-tracking. Supporta Kanban con Swimlanes e implementazione Scrum completa. Tracciamento del tempo integrato. Gratis per cinque utenti e tre portfoli di progetto.
* [Teamplify](https://teamplify.com) - Migliora i processi di sviluppo del team con Team Analytics e Smart Daily Standup. Include gestione completa delle assenze per team remote-first. Gratis per piccoli gruppi fino a 5 utenti.
* [Tefter](https://tefter.io) - App di segnalibri con potente integrazione Slack. Gratis per team open-source.
* [TeleType](https://teletype.oorja.io/) — Condividi terminali, voce, codice, lavagna e altro. Nessuna registrazione richiesta per collaborazione sviluppatori end-to-end criptata.
* [TimeCamp](https://www.timecamp.com/) - Software gratuito di tracciamento del tempo per utenti illimitati. Si integra facilmente con tool PM come Jira, Trello, Asana, ecc.
* [Huly](https://huly.io/) - Piattaforma All-in-One per Project Management (alternativa a Linear, Jira, Slack, Notion, Motion) - utenti illimitati, 10GB di storage per workspace, 10GB traffico video(audio).
* [Teamcamp](https://www.teamcamp.app) - Applicazione all-in-one per la gestione dei progetti dedicata alle software house.
* [twist.com](https://twist.com) — App di comunicazione per team orientata all’asincrono dove le conversazioni restano organizzate e in tema. Disponibili piani Free e Unlimited. Sconti per team idonei.
* [tldraw.com](https://tldraw.com) — Strumento open-source gratuito per whiteboard e diagrammi con frecce intelligenti, snapping, sticky notes ed esportazione SVG. Modalità multiplayer per editing collaborativo. Disponibile anche estensione ufficiale gratuita per VS Code.
* [BookmarkOS.com](https://bookmarkos.com) - Gestore di segnalibri tutto-in-uno gratuito, gestore di schede e attività in un desktop online personalizzabile con collaborazione tra cartelle.
* [typetalk.com](https://www.typetalk.com/) — Condividi e discuti idee con il tuo team tramite messaggistica istantanea sul web o mobile.
* [Tugboat](https://tugboat.qa) - Anteprima di ogni pull request, automatizzato e on-demand. Gratuito per tutti, livello Nano gratuito per non-profit.
* [whereby.com](https://whereby.com/) — Videoconversazioni con un click, gratis (precedentemente appear.in).
* [windmill.dev](https://windmill.dev/) - Windmill è una piattaforma open-source per sviluppatori per costruire rapidamente automazioni e app interne di produzione da script Python e Typescript minimi. Come utente gratuito puoi creare ed essere membro di massimo tre workspace non-premium.
* [vadoo.tv](https://vadoo.tv/) — Hosting e marketing video semplificati. Carica video con un solo clic. Registra, gestisci, condividi e altro. Il piano gratuito prevede fino a 10 video, 1 GB di spazio e 10 GB di banda/mese.
* [userforge.com](https://userforge.com/) - Personas online interconnesse, user story e mappatura del contesto. Aiuta a mantenere design e sviluppo sincronizzati, gratis fino a 3 personas e due collaboratori.
* [wistia.com](https://wistia.com/) — Hosting video con analisi spettatori, consegna HD e strumenti di marketing per comprendere i tuoi visitatori, 25 video e player con brand Wistia.
* [wormhol.org](https://www.wormhol.org/) — Servizio semplice per la condivisione file. Condividi file illimitati fino a 5GB con tutti i peer che vuoi.
* [Wormhole](https://wormhole.app/) - Condividi file fino a 5GB con crittografia end-to-end per massimo 24 ore. Per file maggiori di 5 GB, usa trasferimento peer-to-peer diretto.
* [zoom.us](https://zoom.us/) — Videoconferenze sicure e componenti aggiuntivi Web. Il piano gratuito è limitato a 40 minuti.
* [Zulip](https://zulip.com/) — Chat in tempo reale con modello unico di threading simile all’email. Il piano gratuito include 10.000 messaggi ricercabili e storage file fino a 5 GB. Disponibile anche versione open-source self-hosted.
* [robocorp.com](https://robocorp.com) - Stack open-source per Automation Ops. Prova le funzionalità Cloud e implementa automazioni semplici gratis. Robot lavorano 240 min/mese, 10 Assistant run, 100 MB di storage.
* [Fleep.io](https://fleep.io/) — Fleep, alternativa a Slack. Piano gratuito per piccoli team con cronologia messaggi completa, conversazioni 1:1 illimitate, 1 conversazione di gruppo e 1 GB di archiviazione.
* [Chanty.com](https://chanty.com/) — Chanty, un'altra alternativa a Slack. Piano gratuito per sempre per piccoli team (fino a 10) con conversazioni pubbliche e private illimitate, cronologia ricercabile, chiamate audio 1:1 illimitate, messaggi vocali illimitati, dieci integrazioni e 20 GB di storage per team.
* [ruttl.com](https://ruttl.com/) — Il miglior strumento all-in-one per raccogliere feedback digitali e revisionare siti web, PDF e immagini.
* [Mattermost](https://mattermost.com/) — Collaborazione sicura per team tecnici. Piano gratuito con canali, playbook, board, utenti illimitati, 10GB di spazio e altro.
* [Webvizio](https://webvizio.com) — Strumento di feedback e revisione siti web e report bug per ottimizzare la collaborazione nello sviluppo web su siti live, web app, immagini, PDF e file di design.
* [Pullflow](https://pullflow.com) — Pullflow offre una piattaforma potenziata dall’IA per la collaborazione nella revisione del codice su GitHub, Slack e VS Code.
* [Webex](https://www.webex.com/) — Videoriunioni con piano gratuito di 40 minuti per meeting e fino a 100 partecipanti.
* [RingCentral](https://www.ringcentral.com/) — Videoriunioni con piano gratuito di 50 minuti per meeting e fino a 100 partecipanti.
* [GitBook](https://www.gitbook.com/) — Piattaforma per catturare e documentare conoscenza tecnica — dai documenti di prodotto alle knowledge base interne e API. Piano gratuito per sviluppatori individuali.
* [transfernow](https://www.transfernow.net/) — interfaccia più semplice, veloce e sicura per trasferire e condividere file. Invia foto, video e altri file grandi senza abbonamento obbligatorio.
* [paste.sh](https://paste.sh/) — Sito di paste semplice basato su JavaScript e Crypto.
* [Revolt.chat](https://revolt.chat/) — Alternativa open-source a [Discord](https://discord.com/), che rispetta la privacy. Offre gratuitamente quasi tutte le funzionalità proprietarie di Discord. Revolt è un’app tutto-in-uno sicura e veloce, 100% gratuita. Tutte le funzionalità sono gratuite. Supporta anche plugin (ufficiali e non), a differenza di molte app di chat mainstream.
* [Tencent RTC](https://trtc.io/) — Tencent Real-Time Communication (TRTC) offre soluzioni per chiamate audio/video di gruppo. 10.000 minuti gratuiti/mese per il primo anno.
* [Pastefy](https://pastefy.app/) - Pastebin bello e semplice con crittografia client opzionale, multi-tab, API, editor evidenziato e altro.
* [SiteDots](https://sitedots.com/) - Condividi feedback sui progetti web direttamente sul tuo sito, senza emulazione, canvas o workaround. Tier gratuito completamente funzionale.

**[⬆️ Torna su](#table-of-contents)**

## CMS

* [acquia.com](https://www.acquia.com/) — Hosting per siti Drupal. Livello gratuito per sviluppatori. Disponibili anche strumenti di sviluppo gratuiti (come Acquia Dev Desktop).
* [Contentful](https://www.contentful.com/) — Headless CMS. API di gestione e distribuzione contenuti nel cloud. Include uno spazio Community gratuito con cinque utenti, 25.000 record, 48 tipi di contenuti, 2 localizzazioni.
* [Cosmic](https://www.cosmicjs.com/) — Headless CMS e toolkit API. Piani personali gratuiti per sviluppatori.
* [Crystallize](https://crystallize.com) — Headless PIM con supporto ecommerce. API GraphQL integrata. La versione gratuita include utenti illimitati, 1000 articoli catalogo, 5 GB/mese di banda e 25k/mese chiamate API.
* [DatoCMS](https://www.datocms.com/) - Offre livello gratuito per piccoli progetti. DatoCMS è un CMS basato su GraphQL. Nel livello base, hai 100k chiamate/mese.
* [Directus](https://directus.io) — Headless CMS. Piattaforma completamente gratuita e open-source per la gestione di asset e contenuti database in locale o nel Cloud. Nessuna limitazione o paywall.
* [FrontAid](https://frontaid.io/) — Headless CMS che memorizza contenuti JSON direttamente nel tuo repository Git. Nessuna restrizione.
* [kontent.ai](https://www.kontent.ai) - Piattaforma Content-as-a-Service che offre tutti i vantaggi di un headless CMS dando potere anche ai marketer. Il piano developer offre due utenti con progetti illimitati, due ambienti per ciascuno, 500 elementi di contenuto, due lingue, Delivery e Management API e supporto Custom elements. Sono disponibili piani più dettagliati per esigenze specifiche.
* [Prismic](https://www.prismic.io/) — Headless CMS. Interfaccia di gestione contenuti con API completamente ospitata e scalabile. Il Community Plan offre chiamate API, documenti, tipi personalizzati, asset e localizzazioni illimitati per un utente. Tutto il necessario per il prossimo progetto. Piani gratuiti più ampi disponibili per progetti Open Content/Open Source.
* [Sanity.io](https://www.sanity.io/) - Piattaforma per contenuti strutturati con ambiente di editing open-source e datastore in hosting real-time. Progetti illimitati. Admin illimitati, tre utenti non-admin, due dataset, 500K richieste API CDN, 10GB di banda e 5GB di asset inclusi gratis per progetto.
* [sensenet](https://sensenet.com) - CMS headless API-first con soluzioni enterprise per aziende di ogni dimensione. Il piano Developer offre tre utenti, 500 contenuti, tre ruoli predefiniti, 25+5 tipi di contenuti, REST API completa, anteprima documenti e editing Office Online.
* [TinaCMS](https://tina.io/) — Sostituisce Forestry.io. CMS headless open-source basato su Git che supporta Markdown, MDX e JSON. L’offerta base è gratuita con due utenti disponibili.
* [GatsbyjsCMS](https://www.gatsbyjs.com/) - Gatsby è il framework veloce e flessibile che rende la creazione di siti web con qualsiasi CMS, API o database di nuovo divertente. Costruisci e distribuisci siti headless che generano più traffico, convertono meglio e producono più ricavi!
* [Hygraph](https://hygraph.com/) - Offre livello gratuito per piccoli progetti. API GraphQL first. Passa dalle soluzioni legacy al CMS Headless nativo GraphQL - e distribuisci contenuti omnicanale API-first.
* [Squidex](https://squidex.io/) - Offre un piano gratuito per piccoli progetti. API / GraphQL first. Open source e basato su event sourcing (versionamento automatico di ogni modifica).
* [InstaWP](https://instawp.com/) - Lancia un sito WordPress in pochi secondi. Un piano gratuito con 5 Siti Attivi, 500 MB di spazio, scadenza sito dopo 48 ore.
* [Storyblok](https://www.storyblok.com) - Un Headless CMS per sviluppatori e marketer che funziona con tutti i moderni framework. Il piano Community (gratuito) offre API di gestione, Editor Visuale, dieci fonti, Tipi di Campo Personalizzati, Internazionalizzazione (lingue/località illimitate), Gestore Asset (fino a 2500 asset), Servizio di Ottimizzazione Immagini, Query di Ricerca, Webhook + 250GB di traffico/mese inclusi.
* [WPJack](https://wpjack.com) - Configura WordPress su qualsiasi cloud in meno di 5 minuti! Il piano gratuito include 1 server, 2 siti, certificati SSL gratuiti e job cron illimitati. Nessun limite di tempo o scadenza—il tuo sito web, a modo tuo.

**[⬆️ Torna all'inizio](#table-of-contents)**

## Code Generation

* [Appinvento](https://appinvento.io/) — AppInvento è un builder di app no code gratuito. Nel codice backend generato automaticamente, gli utenti hanno accesso completo al codice sorgente e API e route illimitate, consentendo un'integrazione estesa. Il piano gratuito include tre progetti, cinque tabelle e un componente aggiuntivo Google.
* [Cody AI](https://sourcegraph.com/cody) - Cody è un assistente AI per il coding che utilizza l'intelligenza artificiale e una profonda comprensione della tua codebase per aiutarti a scrivere e comprendere codice più velocemente. Cody offre agli sviluppatori la scelta tra diversi LLM (inclusa inferenza locale), supporta vari IDE, tutti i linguaggi di programmazione più diffusi e ha un piano gratuito. Il piano gratuito offre 20 messaggi di chat (utilizzando Claude 3 Sonnet come LLM) e 500 autocompletamenti (utilizzando Starcoder 16b) ogni mese.
* [DhiWise](https://www.dhiwise.com/) — Trasforma senza problemi i design Figma in applicazioni Flutter & React dinamiche grazie alla tecnologia di generazione del codice di DhiWise, ottimizzando il workflow e aiutandoti a creare esperienze mobile e web eccezionali più rapidamente che mai.
* [Codeium](https://www.codeium.com/) — Codeium è uno strumento gratuito di completamento del codice alimentato da AI. Supporta oltre 20+ linguaggi di programmazione (Python, JavaScript, Java, TypeScript, PHP, C/C++, Go, ecc.) e si integra con tutti i principali IDE standalone e web.
* [Fern](https://buildwithfern.com) - Scrivi definizioni API e usale per generare SDK/librerie client nei linguaggi più popolari come TypeScript, Python, Java, Go e altri. OpenAPI completamente supportato. Il piano gratuito genera codice per un massimo di 20 endpoint.
* [Metalama](https://www.postsharp.net/metalama) - Solo per C#. Metalama genera automaticamente il boilerplate del codice durante la compilazione, mantenendo il codice sorgente pulito. Gratuito per progetti open source e il piano gratuito adatto anche a progetti commerciali include tre aspetti.
* [Supermaven](https://www.supermaven.com/) — Supermaven è un plugin veloce per il completamento del codice AI per VSCode, JetBrains e Neovim. Il piano gratuito offre completamenti inline illimitati.
* [tabnine.com](https://www.tabnine.com/) — Tabnine aiuta gli sviluppatori a creare software migliore più rapidamente fornendo insight appresi da tutto il codice esistente al mondo. Plugin disponibile.
* [v0.dev](https://v0.dev/) — v0 usa modelli AI per generare codice a partire da semplici prompt testuali. Genera codice React pronto da copiare e incollare basato su shadcn/ui e Tailwind CSS che può essere usato nei propri progetti. Ogni generazione richiede almeno 30 crediti. Si parte con 1200 crediti e si ricevono 200 crediti gratuiti ogni mese.

**[⬆️ Torna all'inizio](#table-of-contents)**

## Code Quality

* [beanstalkapp.com](https://beanstalkapp.com/) — Un workflow completo per scrivere, revisionare e distribuire codice, account gratuito per un utente e un repository con 100 MB di spazio
* [browserling.com](https://www.browserling.com/) — Test cross-browser live interattivo, gratuito solo per sessioni di 3 minuti con MS IE 9 su Vista a risoluzione 1024 x 768
* [codacy.com](https://www.codacy.com/) — Revisioni automatiche del codice per PHP, Python, Ruby, Java, JavaScript, Scala, CSS e CoffeeScript, gratuito per repository pubblici e privati illimitati
* [Codeac.io](https://www.codeac.io/infrastructure-as-code.html?ref=free-for-dev) - Strumento di revisione automatica Infrastructure as Code per DevOps che si integra con GitHub, Bitbucket e GitLab (anche self-hosted). Oltre ai linguaggi standard, analizza anche Ansible, Terraform, CloudFormation, Kubernetes e altro. (open source gratuito)
* [CodeBeat](https://codebeat.co) — Piattaforma di revisione automatica del codice disponibile per molti linguaggi. Gratis per sempre per repository pubblici con integrazione Slack ed e-mail.
* [codeclimate.com](https://codeclimate.com/) — Revisione automatica del codice, gratuito per Open Source e repository privati di organizzazione illimitati (fino a 4 collaboratori). Anche gratis per studenti e istituzioni.
* [codecov.io](https://codecov.io/) — Strumento di copertura del codice (SaaS), gratuito per Open Source e un repository privato gratuito
* [CodeFactor](https://www.codefactor.io) — Revisione automatica del codice per Git. La versione gratuita include utenti illimitati, repository pubblici e un repository privato.
* [coderabbit.ai](https://coderabbit.ai) — Strumento di revisione del codice basato su AI che si integra con GitHub/GitLab. Il piano gratuito include 200 file/ora, 3 revisioni all'ora e 50 conversazioni/ora. Gratuito per sempre per progetti open source.
* [codescene.io](https://codescene.io/) - CodeScene dà priorità al debito tecnico in base a come gli sviluppatori lavorano sul codice e visualizza fattori organizzativi come accoppiamento dei team e padronanza dei sistemi. Gratuito per Open Source.
* [CodSpeed](https://codspeed.io) - Automatizza il monitoraggio delle performance nelle pipeline CI. Individua regressioni delle performance prima del deployment, grazie a metriche precise e costanti. Gratis per sempre per progetti Open Source.
* [coveralls.io](https://coveralls.io/) — Visualizzazione dei report di copertura dei test, gratuito per Open Source
* [dareboost](https://dareboost.com) - 5 report di analisi gratuiti al mese per performance web, accessibilità e sicurezza
* [deepcode.ai](https://www.deepcode.ai) — DeepCode trova bug, vulnerabilità di sicurezza, problemi di performance e di API basandosi sull'AI. La velocità di analisi di DeepCode permette di analizzare il codice in tempo reale e fornire risultati quando salvi nel tuo IDE. Linguaggi supportati: Java, C/C++, JavaScript, Python e TypeScript. Integrazione con GitHub, BitBucket e GitLab. Gratuito per open source e repository privati fino a 30 sviluppatori.
* [deepscan.io](https://deepscan.io) — Analisi statica avanzata per trovare automaticamente errori di runtime nel codice JavaScript, gratuito per Open Source
* [DeepSource](https://deepsource.io/) - DeepSource analizza continuamente i cambiamenti nel codice sorgente, trovando e correggendo problemi categorizzati in sicurezza, performance, antipattern, rischi di bug, documentazione e stile. Integrazione nativa con GitHub, GitLab e Bitbucket.
* [DiffText](https://difftext.com) - Trova istantaneamente le differenze tra due blocchi di codice. Completamente gratuito da usare.
* [eversql.com](https://www.eversql.com/) — EverSQL - La piattaforma numero 1 per l’ottimizzazione dei database. Ottieni automaticamente insight critici sul tuo database e query SQL.
* [gerrithub.io](https://review.gerrithub.io/) — Gerrit code review per repository GitHub gratuitamente
* [gocover.io](https://gocover.io/) — Copertura del codice per qualsiasi pacchetto [Go](https://golang.org/)
* [goreportcard.com](https://goreportcard.com/) — Code Quality per progetti Go, gratuito per Open Source
* [gtmetrix.com](https://gtmetrix.com/) — Report e raccomandazioni dettagliate per ottimizzare siti web
* [holistic.dev](https://holistic.dev/) - Il miglior analizzatore statico di codice per l’ottimizzazione di Postgresql. Servizio automatico di rilevamento di problemi di performance, sicurezza e architettura del database
* [houndci.com](https://houndci.com/) — Commenta sui commit GitHub riguardo la qualità del codice, gratuito per Open Source
* [Moderne.io](https://app.moderne.io) — Refactoring automatico del codice sorgente. Moderne offre migrazioni di framework, analisi con remediation e trasformazione del codice su larga scala, così gli sviluppatori possono dedicarsi a nuove funzionalità invece che alla manutenzione. Gratis per Open Source.
* [reviewable.io](https://reviewable.io/) — Code review per repository GitHub, gratuito per repository pubblici o personali.
* [parsers.dev](https://parsers.dev/) - Parser di abstract syntax tree e compilatori di rappresentazione intermedia come servizio
* [scan.coverity.com](https://scan.coverity.com/) — Analisi statica del codice per Java, C/C++, C# e JavaScript, gratuito per Open Source
* [scrutinizer-ci.com](https://scrutinizer-ci.com/) — Piattaforma di ispezione continua, gratuito per Open Source
* [semanticdiff.com](https://app.semanticdiff.com/) — Diff consapevole del linguaggio di programmazione per pull request e commit GitHub, gratuito per repository pubblici
* [shields.io](https://shields.io) — Badge di metadati di qualità per progetti open source
* [sonarcloud.io](https://sonarcloud.io) — Analisi automatica del codice sorgente per Java, JavaScript, C/C++, C#, VB.NET, PHP, Objective-C, Swift, Python, Groovy e molti altri linguaggi, gratuito per Open Source
* [SourceLevel](https://sourcelevel.io/) — Code Review automatizzato e Team Analytics. Gratuito per Open Source e organizzazioni fino a 5 collaboratori.
* [webceo.com](https://www.webceo.com/) — Strumenti SEO ma anche verifiche del codice e test su diversi tipi di dispositivi
* [zoompf.com](https://zoompf.com/) — Migliora le performance dei tuoi siti web, analisi dettagliata

**[⬆️ Torna all'inizio](#table-of-contents)**

## Code Search and Browsing

* [libraries.io](https://libraries.io/) — Ricerca e notifiche di aggiornamento dipendenze per 32 diversi package manager, gratuito per open source
* [Namae](https://namae.dev/) - Cerca su vari siti come GitHub, Gitlab, Heroku, Netlify e molti altri la disponibilità del nome del tuo progetto.
* [searchcode.com](https://searchcode.com/) — Ricerca testuale del codice completa, gratuita per Open Source
* [tickgit.com](https://www.tickgit.com/) — Evidenzia commenti `TODO` (e altri marker) per identificare aree del codice su cui tornare per miglioramenti.
* [CodeKeep](https://codekeep.io) - Google Keep per snippet di codice. Organizza, scopri e condividi snippet di codice, con uno strumento avanzato di screenshot del codice con template predefiniti e funzione di collegamento.

**[⬆️ Torna all'inizio](#table-of-contents)**

## CI and CD

* [AccessLint](https://github.com/marketplace/accesslint) — AccessLint integra i test automatici di accessibilità web nel tuo workflow di sviluppo. Gratuito per open source e scopi educativi.
* [appcircle.io](https://appcircle.io) — Piattaforma DevOps mobile di livello enterprise che automatizza build, test e pubblicazione di app mobile per cicli di rilascio più rapidi ed efficienti. Gratis per 30 minuti di build massimi per build, 20 build mensili e 1 build concorrente.
* [appveyor.com](https://www.appveyor.com/) — Servizio CD per Windows, gratuito per Open Source
* [LocalOps](https://localops.co/) - Deploy della tua app su AWS/GCP/Azure in meno di 30 minuti. Configura ambienti app standardizzati su qualsiasi cloud, con automazione CI/CD integrata e osservabilità avanzata. Il piano gratuito consente 1 utente e 1 ambiente app.
* [Argonaut](https://argonaut.dev/) - Deployment di app e infrastruttura sul tuo cloud in pochi minuti. Supporto per deployment personalizzati e di terze parti su ambienti Kubernetes e Lambda. Il piano gratuito consente app e deployment illimitati per 5 domini e 2 utenti.
* [bitrise.io](https://www.bitrise.io/) — CI/CD per app mobile, native o ibride. 200 build gratuite/mese, build di 10 minuti e due membri del team. I progetti OSS ricevono build di 45 minuti, +1 concorrenza e team illimitato.
* [buddy.works](https://buddy.works/) — CI/CD con cinque progetti gratuiti e una esecuzione concorrente (120 esecuzioni/mese)
* [Buildkite](https://buildkite.com) Pipeline CI gratuito per 3 utenti e 5k minuti job/mese. Test Analytics tier developer gratuito include 100k esecuzioni test/mese, con ulteriori inclusioni gratuite per progetti open source.
* [bytebase.com](https://www.bytebase.com/) — Database CI/CD e DevOps. Gratuito sotto i 20 utenti e dieci istanze database
* [CircleCI](https://circleci.com/) — Piano gratuito completo con tutte le funzionalità incluse in un servizio CI/CD hosted per repository GitHub, GitLab e BitBucket. Diverse classi di risorse, Docker, Windows, Mac OS, esecutori ARM, runner locali, test splitting, Docker Layer Caching e altre funzionalità CI/CD avanzate. Gratuito fino a 6000 minuti/mese di esecuzione, collaboratori illimitati, 30 job paralleli in progetti privati e fino a 80.000 minuti build gratuiti per progetti Open Source.
* [cirrus-ci.org](https://cirrus-ci.org) - Gratuito per repository pubblici GitHub
* [cirun.io](https://cirun.io) - Gratuito per repository pubblici GitHub
* [codefresh.io](https://codefresh.io) — Piano Free-for-Life: 1 build, un ambiente, server condivisi, repository pubblici illimitati
* [codemagic.io](https://codemagic.io/) - 500 minuti di build gratuiti/mese
* [codeship.com](https://codeship.com/) — 100 build privati/mese, cinque progetti privati, illimitato per Open Source
* [deploybot.com](https://www.deploybot.com/) — 1 repository con dieci deployment, gratuito per Open Source
* [deployhq.com](https://www.deployhq.com/) — 1 progetto con dieci deployment giornalieri (30 minuti build/mese)
* [drone](https://cloud.drone.io/) - Drone Cloud permette agli sviluppatori di eseguire pipeline di Continuous Delivery su più architetture - incluse x86 e Arm (sia 32-bit che 64-bit) - tutto in un unico posto
* [LayerCI](https://layerci.com) — CI per progetti full stack. Un ambiente di preview full stack con 5GB di memoria e 3 CPU.
* [semaphoreci.com](https://semaphoreci.com/) — Gratuito per Open Source, 100 build privati al mese
* [Squash Labs](https://www.squash.io/) — crea una VM per ogni branch e rende la tua app disponibile da un URL unico, repository pubblici & privati illimitati, fino a 2 GB di dimensione VM.
* [styleci.io](https://styleci.io/) — Solo repository pubblici GitHub
* [Mergify](https://mergify.io) — automazione dei workflow e merge queue per GitHub — Gratis per repository pubblici GitHub
* [Make](https://www.make.com/en) — Tool di automazione dei workflow che consente di collegare app e automatizzare flussi tramite interfaccia grafica. Supporta molte app e le API più popolari. Gratuito per repository pubblici GitHub e piano free con 100 Mb, 1000 operazioni e 15 minuti di intervallo minimo.
* [Spacelift](https://spacelift.io/) - Piattaforma di gestione per Infrastructure as Code. Caratteristiche del piano gratuito: collaborazione IaC, registry moduli Terraform, integrazione ChatOps, conformità continua delle risorse con Open Policy Agent, SSO con SAML 2.0 e accesso ai pool di worker pubblici: fino a 200 minuti/mese
* [microtica.com](https://microtica.com/) - Ambienti startup con componenti infrastrutturali pronti all'uso, deploy app su AWS gratuitamente, e supporto per workload di produzione. Il piano gratuito include 1 ambiente (sul tuo account AWS), 2 servizi Kubernetes, 100 minuti di build al mese e 20 deployment mensili.
* [Nx Cloud](https://nx.dev/ci) - Nx Cloud velocizza i tuoi monorepo su CI con funzionalità come caching remoto, distribuzione dei task su più macchine e persino suddivisione automatica dei test e2e. Include un piano gratuito fino a 30 collaboratori con 150.000 crediti inclusi.
* [blacksmith](https://www.blacksmith.sh/) - Runner di performance gestiti per GitHub Actions che offre 3.000 minuti gratuiti al mese, senza necessità di carta di credito.
* [Terramate](https://terramate.io/) - Terramate è una piattaforma di orchestrazione e gestione per strumenti Infrastructure as Code (IaC) come Terraform, OpenTofu e Terragrunt. Gratuito fino a 2 utenti con tutte le funzionalità incluse.
* [Terrateam](https://terrateam.io) - Automazione Terraform GitOps-first con workflow guidati dalle pull request, isolamento dei progetti tramite runner self-hosted ed esecuzioni stratificate per operazioni ordinate. Gratuito fino a 3 utenti.

**[⬆️ Torna su](#table-of-contents)**

## Testing

* [Applitools.com](https://applitools.com/) — Validazione visiva intelligente per app web, mobile native e desktop. Si integra con quasi tutte le soluzioni di automazione (come Selenium e Karma) e runner remoti (Sauce Labs, Browser Stack). Gratuito per open source. Un livello gratuito per un singolo utente con checkpoint limitati a settimana.
* [Appetize](https://appetize.io) — Testa le tue app Android & iOS su questo emulatore cloud di telefoni/tablet Android e simulatori iPhone/iPad direttamente dal browser. Il piano gratuito include due sessioni concorrenti con 30 minuti di utilizzo al mese. Nessun limite di dimensione dell'app.
* [Apptim](https://apptim.com) — Uno strumento di testing mobile che permette anche a chi non ha competenze di ingegneria delle performance di valutare le prestazioni e l'esperienza utente (UX) di un'app. Una versione desktop utilizzando il proprio dispositivo è 100% GRATUITA, con test illimitati sia su iOS che Android.
* [Argos](https://argos-ci.com) - Testing visivo open source per sviluppatori. Progetti illimitati, con 5.000 screenshot al mese. Gratis per progetti open source.
* [Bencher](https://bencher.dev/) - Suite di strumenti di benchmarking continuo per individuare regressioni di performance su CI. Gratuito per tutti i progetti pubblici.
* [browserstack.com](https://www.browserstack.com/) — Testing manuale e automatico dei browser, [gratuito per Open Source](https://www.browserstack.com/open-source?ref=pricing)
* [BugBug](https://bugbug.io/) - Strumento leggero di automazione dei test per applicazioni web. Facile da imparare e non richiede programmazione. È possibile eseguire test illimitati sul proprio computer gratuitamente. Monitoraggio cloud e integrazione CI/CD disponibili con un costo mensile aggiuntivo.
* [Checkly](https://checklyhq.com) - Monitoraggio sintetico code-first per DevOps moderni. Monitora le tue API e app a una frazione del prezzo dei provider legacy. Alimentato da un workflow Monitoring as Code e Playwright. Livello gratuito generoso per sviluppatori.
* [checkbot.io](https://www.checkbot.io/) — Estensione browser che testa se il tuo sito segue oltre 50 best practice di SEO, velocità e sicurezza. Piano gratuito per siti web più piccoli.
* [CORS-Tester](https://cors-error.dev/cors-tester/) - Strumento gratuito per sviluppatori e tester API per verificare se una API è abilitata CORS per un dato dominio e identificare eventuali carenze. Fornisce insight utili.
* [cypress.io](https://www.cypress.io/) - Testing veloce, semplice e affidabile per tutto ciò che gira in un browser. Cypress Test Runner è sempre gratuito e open source senza restrizioni. Cypress Dashboard è gratuito per progetti open source fino a 5 utenti.
* [Cypress Recorder by Preflight](https://cypress.preflight.com/) - Crea test Cypress/POM basati su AI direttamente dal browser. Open source tranne la parte AI. Gratuito per cinque creazioni di test mensili con script auto-riparanti, email e testing visivo.
* [everystep-automation.com](https://www.everystep-automation.com/) — Registra e riproduce tutti i passaggi effettuati in un browser e crea script, gratuito con meno opzioni.
* [Gremlin](https://www.gremlin.com/gremlin-free-software) — Gli strumenti di Chaos Engineering di Gremlin permettono di iniettare errori in sicurezza nei sistemi per trovare punti deboli prima che causino problemi agli utenti. Gremlin Free offre Shutdown e CPU attacks su fino a 5 host o container.
* [gridlastic.com](https://www.gridlastic.com/) — Testing Selenium Grid con piano gratuito fino a 4 nodi selenium simultanei/10 avvii grid/4.000 minuti di test al mese
* [katalon.com](https://katalon.com) - Offre una piattaforma di testing per team di ogni dimensione e livello di maturità, inclusi Katalon Studio, TestOps (+ Visual Testing gratuito), TestCloud e Katalon Recorder.
* [Keploy](https://keploy.io/) - Toolkit di testing funzionale per sviluppatori. Registrando chiamate API genera test E2E per API (KTests) e mock o stub (KMocks). Gratuito per progetti Open Source.
* [knapsackpro.com](https://knapsackpro.com) - Velocizza i test con parallelizzazione ottimale delle suite su ogni provider CI. Divide i test Ruby, JavaScript su nodi CI paralleli per risparmiare tempo. Piano gratuito fino a 10 minuti di file di test e piano illimitato gratuito per progetti Open Source.
* [lambdatest.com](https://www.lambdatest.com/) — Testing manuale, visivo, screenshot e automatico su selenium e cypress, [gratuito per Open Source](https://www.lambdatest.com/open-source-cross-browser-testing-tool)
* [loadmill.com](https://www.loadmill.com/) - Crea automaticamente test API e di carico analizzando il traffico di rete. Simula fino a 50 utenti concorrenti per massimo 60 minuti mensili gratuitamente.
* [lost-pixel.com](https://lost-pixel.com) - Testing di regressione visiva olistico per le tue storie Storybook, Ladle, Histoire e Web App. Membri del team illimitati, totalmente gratuito per open source, 7.000 snapshot/mese.
* [octomind.dev](https://www.octomind.dev/) - Test UI Playwright auto-generati, eseguiti e mantenuti con generazione di casi di test assistita da AI.
* [percy.io](https://percy.io) - Aggiungi testing visivo a qualsiasi web app, sito statico, style guide o libreria di componenti. Membri team illimitati, app demo e progetti illimitati, 5.000 snapshot/mese.
* [preflight.com](https://preflight.com) - Testing web automatizzato no-code. Registra test sul browser resilienti ai cambiamenti UI ed eseguili su macchine Windows. Può integrarsi con il tuo CI/CD? Il piano gratuito include 50 esecuzioni di test mensili con video, sessioni HTML e altro.
* [qase.io](https://qase.io) - Sistema di gestione dei test per team Dev e QA. Gestisci casi di test, compila run di test, esegui test, traccia difetti e misura l'impatto. Il piano gratuito include tutte le funzionalità base, 500MB per allegati e fino a 3 utenti.
* [Repeato](https://repeato.app/) Strumento di automazione test mobile no-code basato su computer vision e AI. Funziona per app native, flutter, react-native, web, ionic e molti altri framework. Il piano gratuito è limitato a 10 test per iOS e 10 per Android, ma include la maggior parte delle funzionalità dei piani a pagamento, inclusi esecuzioni di test illimitate.
* [Requestly](https://requestly.com/) Estensione Chrome open-source per intercettare, reindirizzare e mockare richieste HTTP. Include [Debugger](https://requestly.com/products/web-debugger/), [Mock Server](https://requestly.com/products/mock-server/), [API Client](https://requestly.com/products/api-client/) e [Session Recording](https://requestly.com/products/session-book/). Reindirizza URL, modifica header HTTP, mocka API, inietta JS custom, modifica richieste GraphQL, genera endpoint API mock, registra sessioni con log di rete e console. Crea fino a 10 regole nel piano gratuito. Gratis per open source.
* [seotest.me](https://seotest.me/) — Tester SEO on-page gratuito. 10 crawl di siti web gratuiti al giorno. Risorse utili per imparare la SEO e raccomandazioni su come migliorare i risultati SEO on-page per qualsiasi sito, indipendentemente dalla tecnologia.
* [snippets.uilicious.com](https://snippets.uilicious.com) - È come CodePen ma per il testing cross-browser. UI-licious permette di scrivere test come user story e offre una piattaforma gratuita - UI-licious Snippets - che consente di eseguire test illimitati su Chrome senza registrazione, fino a 3 minuti per esecuzione. Hai trovato un bug? Puoi copiare l'URL unico del test per mostrare agli sviluppatori come riprodurlo.
* [TestCollab](https://testcollab.com) - Software di gestione dei test user-friendly, il piano gratuito include integrazione Jira, progetti illimitati, importazione casi di test tramite CSV/XLSx, time tracking e 1 GB di storage file.
* [testingbot.com](https://testingbot.com/) — Selenium Browser e Device Testing, [gratuito per Open Source](https://testingbot.com/open-source)
* [Testspace.com](https://testspace.com/) - Dashboard per pubblicare risultati di test automatizzati e framework per implementare test manuali come codice usando GitHub. Il servizio è [gratuito per Open Source](https://github.com/marketplace/testspace-com) e include 450 risultati mensili.
* [tesults.com](https://www.tesults.com) — Report dei risultati dei test e gestione dei casi di test. Si integra con i principali framework di test. Sviluppatori software open source, individui, educatori e piccoli team possono richiedere offerte gratuite e scontate oltre i progetti gratuiti di base.
* [UseWebhook.com](https://usewebhook.com) - Cattura e ispeziona webhook dal browser. Inoltra su localhost o ripeti dalla cronologia. Gratis da usare.
* [Vaadin](https://vaadin.com) — Crea UI scalabili in Java o TypeScript e usa tool, componenti e design system integrati per iterare più velocemente, progettare meglio e semplificare lo sviluppo. Progetti illimitati con cinque anni di manutenzione gratuita.
* [websitepulse.com](https://www.websitepulse.com/tools/) — Vari strumenti gratuiti di rete e server.
* [webhook-test.com](https://webhook-test.com) - Debug e ispezione di webhook e richieste HTTP con URL unico durante l'integrazione. Completamente gratuito, puoi creare URL illimitati e ricevere raccomandazioni.
* [webhook.site](https://webhook.site) - Verifica webhook, richieste HTTP in uscita o email con un URL personalizzato. Un URL e indirizzo email temporaneo sono sempre gratuiti.
* [webhookbeam.com](https://webhookbeam.com) - Configura webhook e monitorali tramite notifiche push ed email.

**[⬆️ Torna su](#table-of-contents)**

## Sicurezza e PKI

* [aikido.dev](https://www.aikido.dev) — Piattaforma appsec all-in-one che copre SCA, SAST, CSPM, DAST, Secrets, IaC, Malware, scanning Container, EOL,... Il piano gratuito include due utenti, scansione di 10 repo, 1 cloud, 2 container e 1 dominio.
* [alienvault.com](https://www.alienvault.com/open-threat-exchange/reputation-monitor) — Scopre sistemi compromessi nella tua rete
* [Altcha.org](https://altcha.org/anti-spam) - Un filtro antispam per siti web e API alimentato da elaborazione del linguaggio naturale e machine learning. Il piano gratuito include 200 richieste al giorno per dominio.
* [atomist.com](https://atomist.com/) — Un modo più veloce e conveniente per automatizzare vari task di sviluppo. Ora in beta.
* [cloudsploit.com](https://cloudsploit.com/) — Audit e monitoraggio della sicurezza e conformità su Amazon Web Services (AWS)
* [Public Cloud Threat Intelligence](https://cloudintel.himanshuanand.com/) — Indicatori di compromissione (IOC) ad alta affidabilità che prendono di mira infrastrutture cloud pubbliche. Una parte è disponibile su github (https://github.com/unknownhad/AWSAttacks). Lista completa disponibile via API.
* [CodeNotary.io](https://www.codenotary.io/) — Piattaforma Open Source con prova indelebile per notarizzare codice, file, directory o container
* [crypteron.com](https://www.crypteron.com/) — Piattaforma di sicurezza cloud-first e developer-friendly che previene data breach in applicazioni .NET e Java
* [CyberChef](https://gchq.github.io/CyberChef/) — App web semplice e intuitiva per analizzare e decodificare/codificare dati senza strumenti complessi o linguaggi di programmazione. Come un coltellino svizzero di crittografia & cifratura. Tutte le funzionalità sono gratuite, senza limiti. Open source per l'auto-hosting.
* [DAS](https://signup.styra.com/) — Styra DAS Free, gestione policy full lifecycle per creare, deployare e gestire autorizzazioni Open Policy Agent (OPA)
* [Datree](https://www.datree.io/) — Strumento CLI Open Source per prevenire errori di configurazione Kubernetes assicurando che manifest e Helm chart seguano best practice e policy aziendali
* [Dependabot](https://dependabot.com/) Aggiornamento automatico delle dipendenze per Ruby, JavaScript, Python, PHP, Elixir, Rust, Java (Maven e Gradle), .NET, Go, Elm, Docker, Terraform, Git Submodules e GitHub Actions.
* [DJ Checkup](https://djcheckup.com) — Scansiona il tuo sito Django alla ricerca di vulnerabilità di sicurezza con questo strumento gratuito e automatico. Fork di Pony Checkup.
* [Doppler](https://doppler.com/) — Secrets Manager universale per segreti e config applicativi, con supporto per sync verso vari cloud provider. Gratis per cinque utenti con controlli di accesso base.
* [Dotenv](https://dotenv.org/) — Sincronizza i tuoi file .env, velocemente e in sicurezza. Smetti di condividere file .env tramite canali insicuri come Slack ed email, e non perdere mai più un file .env importante. Gratuito fino a 3 membri del team.
* [GitGuardian](https://www.gitguardian.com) — Mantieni i segreti fuori dal tuo codice sorgente con rilevamento e rimedio automatico. Scansiona i tuoi repo git per oltre 350 tipi di segreti e file sensibili – Gratis per individui e team fino a 25 sviluppatori.
* [Have I been pwned?](https://haveibeenpwned.com) — REST API per ottenere informazioni sulle violazioni di sicurezza.
* [hostedscan.com](https://hostedscan.com) — Vulnerability scanner online per applicazioni web, server e reti. Dieci scansioni gratuite al mese.
* [Infisical](https://infisical.com/) — Piattaforma open source per gestire segreti degli sviluppatori nel team e nell'infrastruttura: da sviluppo locale a servizi di terze parti in staging/produzione. Gratuito fino a 5 sviluppatori.
* [Internet.nl](https://internet.nl) — Test sugli standard Internet moderni come IPv6, DNSSEC, HTTPS, DMARC, STARTTLS e DANE
* [keychest.net](https://keychest.net) - Gestione scadenza SSL e acquisto certificati con database CT integrato
* [letsencrypt.org](https://letsencrypt.org/) — Autorità di Certificazione SSL gratuita con certificati riconosciuti da tutti i principali browser
* [meterian.io](https://www.meterian.io/) - Monitora progetti Java, Javascript, .NET, Scala, Ruby e NodeJS per vulnerabilità di sicurezza nelle dipendenze. Gratuito per un progetto privato, progetti illimitati per open source.
* [Mozilla Observatory](https://observatory.mozilla.org/) — Trova e risolvi vulnerabilità di sicurezza nel tuo sito.
* [opswat.com](https://www.opswat.com/) — Security Monitoring di computer, dispositivi, applicazioni, configurazioni, Gratis per 25 utenti e 30 giorni di storico utenti.
* [openapi.security](https://openapi.security/) - Strumento gratuito per controllare rapidamente la sicurezza di qualsiasi API OpenAPI / Swagger. Non è necessaria registrazione.
* [pixee.ai](https://pixee.ai) - Product Security Engineer automatizzato come bot GitHub gratuito che invia PR al tuo codice Java per risolvere automaticamente vulnerabilità. Altri linguaggi presto disponibili!
* [pyup.io](https://pyup.io) — Monitora dipendenze Python per vulnerabilità di sicurezza e aggiornale automaticamente. Gratuito per un progetto privato, progetti illimitati per open source.
* [qualys.com](https://www.qualys.com/community-edition) — Individua vulnerabilità in web app, audit per rischi OWASP
* [report-uri.io](https://report-uri.io/) — Segnalazione di violazioni CSP e HPKP
* [ringcaptcha.com](https://ringcaptcha.com/) — Strumenti per usare il numero di telefono come ID, disponibili gratuitamente
* [seclookup.com](https://www.seclookup.com/) - Le API Seclookup possono arricchire indicatori di minaccia di dominio in SIEM, fornire informazioni dettagliate sui domini e migliorare detection & response. Ottieni 50.000 look-up gratuiti [qui](https://account.seclookup.com/).
* [snyk.io](https://snyk.io) — Trova e corregge vulnerabilità note nelle dipendenze open source. Test e remediation illimitati per progetti open source. Limitato a 200 test/mese per progetti privati.
* [ssllabs.com](https://www.ssllabs.com/ssltest/) — Analisi approfondita della configurazione di qualsiasi server web SSL
* [SOOS](https://soos.io) - Scansioni SCA gratuite e illimitate per progetti open source. Individua e correggi minacce di sicurezza prima del rilascio. Proteggi i tuoi progetti in modo semplice ed efficace.
* [StackHawk](https://www.stackhawk.com/) Automatizza la scansione applicativa lungo la pipeline per trovare e correggere bug di sicurezza prima che arrivino in produzione. Scansioni illimitate e ambienti per una singola app.
* [Sucuri SiteCheck](https://sitecheck.sucuri.net) - Controllo sicurezza sito web e scanner malware gratuito
* [Protectumus](https://protectumus.com) - Controllo sicurezza sito web, antivirus sito e firewall server (WAF) per PHP. Notifiche email per utenti registrati nel piano gratuito.
* [TestTLS.com](https://testtls.com) - Testa un servizio SSL/TLS per configurazione server sicura, certificati, chain, ecc. Non limitato a HTTPS.
* [threatconnect.com](https://threatconnect.com) — Threat intelligence: pensato per ricercatori individuali, analisti e organizzazioni che iniziano a occuparsi di cyber threat intelligence. Gratuito fino a 3 utenti
* [tinfoilsecurity.com](https://www.tinfoilsecurity.com/) — Vulnerability scanning automatizzato. Il piano gratuito permette scansioni XSS settimanali
* [Ubiq Security](https://ubiqsecurity.com/) — Cifra e decifra dati con tre righe di codice e gestione automatica delle chiavi. Gratis per una applicazione e fino a 1.000.000 cifrature al mese.
* [Virgil Security](https://virgilsecurity.com/) — Strumenti e servizi per implementare crittografia end-to-end, protezione database, sicurezza IoT e altro. Gratis per applicazioni fino a 250 utenti.
* [Vulert](https://vulert.com) - Vulert monitora continuamente le tue dipendenze open source per nuove vulnerabilità, raccomanda fix, senza richiedere installazione o accesso al codice. Gratis per progetti open source.
* [Escape GraphQL Quickscan](https://escape.tech/) - Security scan in un clic dei tuoi endpoint GraphQL. Gratuito, senza login richiesto.
* [HasMySecretLeaked](https://gitguardian.com/hasmysecretleaked) - Cerca tra 20 milioni di segreti esposti nei repository pubblici GitHub, gists, issue e commenti gratuitamente
* [Project Gatekeeper](https://gatekeeper.binarybiology.top/) - Toolkit SSL All-in-One che offre funzionalità come generatore di Private Key & CSR, decoder certificati SSL, matcher certificati e ordine certificati SSL. Permettiamo agli utenti di generare certificati SSL gratuiti da Let's Encrypt, Google Trust e BuyPass usando record CNAME invece dei record TXT.
**[⬆️ Torna all'inizio](#table-of-contents)**

## Autenticazione, Autorizzazione e Gestione Utenti

  * [Aserto](https://www.aserto.com) - Autorizzazione granulare come servizio per applicazioni e API. Gratuito fino a 1000 MAU e 100 istanze di authorizer.
  * [asgardeo.io](https://wso2.com/asgardeo) - Integrazione senza soluzione di continuità di SSO, MFA, autenticazione senza password e altro. Include SDK per app frontend e backend. Gratuito fino a 1000 MAU e cinque provider di identità.
  * [Auth0](https://auth0.com/) — SSO ospitato. Il piano gratuito include 25.000 MAU, connessioni social illimitate, dominio personalizzato e altro.
  * [Authgear](https://www.authgear.com) - Porta autenticazione senza password, OTP, 2FA, SSO alle tue app in pochi minuti. Tutto il frontend incluso. Gratuito fino a 5000 MAU.
  * [Authress](https://authress.io/) — Login di autenticazione e controllo accessi, provider di identità illimitati per qualsiasi progetto. Facebook, Google, Twitter e altro. Le prime 1000 chiamate API sono gratuite.
  * [Authy](https://authy.com) - Autenticazione a due fattori (2FA) su più dispositivi, con backup. Sostituzione immediata di Google Authenticator. Gratuito fino a 100 autenticazioni riuscite.
  * [Cerbos Hub](https://www.cerbos.dev/product-cerbos-hub) - Sistema completo di gestione delle autorizzazioni per scrittura, test e distribuzione di policy di accesso. Autorizzazione granulare e controllo accessi, gratuito fino a 100 principali attivi mensili.
  * [Clerk](https://clerk.com) — Gestione utenti, autenticazione, 2FA/MFA, componenti UI predefiniti per login, registrazione, profili utente e altro. Gratuito fino a 10.000 utenti attivi mensili.
  * [Cloud-IAM](https://www.cloud-iam.com/) — Gestione identità e accessi Keycloak come servizio. Gratuito fino a 100 utenti e un realm.
  * [Corbado](https://www.corbado.com/) — Aggiungi autenticazione passkey-first ad app nuove o esistenti. Gratuito per MAU illimitati.
  * [Descope](https://www.descope.com/) — Flussi AuthN altamente personalizzabili, sia no-code che API/SDK, 7.500 utenti attivi/mese gratuiti, 50 tenant (fino a 5 tenant SAML/SSO).
  * [duo.com](https://duo.com/) — Autenticazione a due fattori (2FA) per sito web o app. Gratuito per dieci utenti, tutti i metodi di autenticazione, integrazioni illimitate, token hardware.
  * [Kinde](https://kinde.com/) - Autenticazione semplice e solida che puoi integrare con il tuo prodotto in pochi minuti. Tutto ciò che serve per iniziare con 7.500 MAU gratuiti.
  * [logintc.com](https://www.logintc.com/) — Autenticazione a due fattori (2FA) tramite notifiche push, gratuita per dieci utenti, VPN, siti web e SSH.
  * [MojoAuth](https://mojoauth.com/) - MojoAuth rende facile implementare l'autenticazione senza password sulla tua app web, mobile o qualsiasi altra applicazione in pochi minuti.
  * [Okta](https://developer.okta.com/signup/) — Gestione utenti, autenticazione e autorizzazione. Gratuito fino a 100 utenti attivi mensili.
  * [onelogin.com](https://www.onelogin.com/) — Identità come servizio (IDaaS), provider Single Sign-On, Cloud SSO IdP, tre app aziendali e cinque app personali, utenti illimitati.
  * [Ory](https://ory.sh/) - Piattaforma di sicurezza gestita AuthN/AuthZ/OAuth2.0/Zero Trust. Account developer gratis per sempre con tutte le funzionalità di sicurezza, membri del team illimitati, 200 utenti attivi giornalieri e 25k/mo controlli permessi.
  * [Permit.io](https://permit.io) - Piattaforma authorization-as-a-service che abilita RBAC, ABAC e ReBAC per microservizi scalabili con aggiornamenti in tempo reale e UI policy no-code. Livello gratuito per 1000 utenti attivi mensili.
  * [Phase Two](https://phasetwo.io) - Gestione identità e accessi open source Keycloak. Realm gratuito fino a 1000 utenti, fino a 10 connessioni SSO, usando il container Keycloak migliorato di Phase Two che include l'estensione [Organization](https://phasetwo.io/product/organizations/).
  * [SSOJet](https://ssojet.com/) - Aggiungi SSO aziendale senza ricostruire la tua autenticazione. Il piano gratuito include utenti attivi mensili illimitati, organizzazioni illimitate, 2 connessioni SSO & 2 SCIM.
  * [Stytch](https://www.stytch.com/) - Piattaforma all-in-one che offre API e SDK per autenticazione e prevenzione frodi. Il piano gratuito include 10.000 utenti attivi mensili, organizzazioni illimitate, 5 connessioni SSO o SCIM e 1.000 token M2M.
  * [Stack Auth](https://stack-auth.com) — Autenticazione open source che funziona davvero. La soluzione più user-friendly per sviluppatori, ti permette di iniziare in cinque minuti. Self-hosting gratuito, o versione SaaS gestita con 10k utenti attivi mensili gratuiti.
  * [SuperTokens](https://supertokens.com/) - Autenticazione utente open source che si integra nativamente nella tua app: inizia rapidamente mantenendo il controllo sull'esperienza utente e sviluppatore. Gratuito fino a 5.000 MAU.
  * [Warrant](https://warrant.dev/) — Servizio di autorizzazione e controllo accessi hosted di livello enterprise per le tue app. Il piano gratuito include 1 milione di richieste API mensili e 1.000 regole di autorizzazione.
  * [ZITADEL Cloud](https://zitadel.com) — Gestione utenti e accessi chiavi in mano che funziona per te e supporta casi d'uso multi-tenant (B2B). Gratuito fino a 25.000 richieste autenticate, con tutte le funzionalità di sicurezza (nessun paywall per OTP, passwordless, policy, ecc.).
  * [PropelAuth](https://propelauth.com) — Vendi subito a qualsiasi dimensione aziendale con poche righe di codice, gratuito fino a 200 utenti e 10k email transazionali (con watermark "Powered by PropelAuth").
  * [Logto](https://logto.io/) - Sviluppa, proteggi e gestisci le identità utente del tuo prodotto, sia per autenticazione che autorizzazione. Gratuito fino a 5.000 MAU con opzione open source self-hosted.
  * [WorkOS](https://workos.com/) - Gestione utenti e autenticazione gratuita fino a 1 milione di MAU. Supporto per email + password, autenticazione social, Magic Auth, MFA e altro.

**[⬆️ Torna all'inizio](#table-of-contents)**

## Distribuzione e Feedback App Mobile

  * [TestApp.io](https://testapp.io) - La piattaforma di riferimento per assicurarti che le tue app mobili funzionino come dovrebbero. Piano gratuito: una app, analytics, versioni e installazioni illimitate, raccolta feedback.
  * [Loadly](https://loadly.io) - Servizio di distribuzione beta app iOS e Android completamente gratuito con download illimitati, download ad alta velocità e upload illimitati.
  * [Diawi](https://www.diawi.com) - Distribuisci app iOS & Android direttamente sui dispositivi. Piano gratuito: upload app, link protetti da password, scadenza 1 giorno, dieci installazioni.
  * [InstallOnAir](https://www.installonair.com) - Distribuisci app iOS & Android over-the-air. Piano gratuito: upload illimitati, link privati, scadenza 2 giorni per ospiti, 60 giorni per utenti registrati.
  * [GetUpdraft](https://www.getupdraft.com) - Distribuisci app mobile per testing. Il piano gratuito include un progetto app, tre versioni app, 500 MB di storage e 100 installazioni app al mese.
  * [Appho.st](https://appho.st) - Piattaforma di hosting per app mobile. Il piano gratuito include cinque app, 50 download mensili, dimensione massima file 100 MB.

**[⬆️ Torna all'inizio](#table-of-contents)**

## Sistema di Gestione

  * [bitnami.com](https://bitnami.com/) — Distribuisci app già pronte su IaaS. Gestione gratuita di 1 istanza micro AWS
  * [Esper](https://esper.io) — MDM e MAM per dispositivi Android con DevOps. Cento dispositivi gratuiti con una licenza utente e 25 MB di storage per applicazione.
  * [jamf.com](https://www.jamf.com/) — Gestione dispositivi per iPad, iPhone e Mac, tre dispositivi gratuiti
  * [Miradore](https://miradore.com) — Servizio di gestione dispositivi. Tieni aggiornata e sicura la tua flotta dispositivi in modo gratuito e illimitato. Il piano gratuito offre funzionalità base.
  * [moss.sh](https://moss.sh) - Aiuta gli sviluppatori a distribuire e gestire le loro web app e server. Gratuito fino a 25 deploy git al mese
  * [runcloud.io](https://runcloud.io/) - Gestione server focalizzata principalmente su progetti PHP. Gratuito fino a 1 server.
  * [ploi.io](https://ploi.io/) - Strumento di gestione server per gestire e distribuire facilmente server & siti. Gratuito per un server.
  * [xcloud.host](https://xcloud.host) — Piattaforma di gestione e distribuzione server con interfaccia user-friendly. Livello gratuito disponibile per un server.
  * [serveravatar.com](https://serveravatar.com) — Gestisci e monitora server web PHP con configurazioni automatizzate. Gratuito per un server.

**[⬆️ Torna all'inizio](#table-of-contents)**

## Messaggistica e Streaming

  * [Ably](https://www.ably.com/) - Servizio di messaggistica realtime con presenza, persistenza e delivery garantita. Il piano gratuito include 3 milioni di messaggi/mese, 100 connessioni di picco e 100 canali di picco.
  * [cloudamqp.com](https://www.cloudamqp.com/) — RabbitMQ as a Service. Piano Little Lemur: max 1 milione di messaggi/mese, max 20 connessioni concorrenti, max 100 code, max 10.000 messaggi in coda, nodi multipli in diverse AZ
  * [courier.com](https://www.courier.com/) — API unica per push, in-app, email, chat, SMS e altri canali di messaggistica con gestione template e altre funzionalità. Il piano gratuito include 10.000 messaggi/mese.
  * [engagespot.co](https://engagespot.co/) — Infrastruttura di notifiche multi-canale per sviluppatori con inbox in-app predefinita e editor template no-code. Il piano gratuito include 10.000 messaggi/mese.
  * [HiveMQ](https://www.hivemq.com/mqtt-cloud-broker/) - Collega i tuoi dispositivi MQTT al Cloud Native IoT Messaging Broker. Gratuito per collegare fino a 100 dispositivi (senza carta di credito) per sempre.
  * [knock.app](https://knock.app) – Infrastruttura notifiche per sviluppatori. Invia a più canali come in-app, email, SMS, Slack e push con una sola chiamata API. Il piano gratuito include 10.000 messaggi/mese.
  * [NotificationAPI.com](https://www.notificationapi.com/) — Aggiungi notifiche utente a qualsiasi software in 5 minuti. Il piano gratuito include 10.000 notifiche/mese + 100 SMS e chiamate automatiche.
  * [Novu.co](https://novu.co) — Infrastruttura notifiche open source per sviluppatori. Componenti e API semplici per gestire tutti i canali di comunicazione in un unico luogo: Email, SMS, Direct, In-App e Push. Il piano gratuito include 30.000 notifiche/mese con 90 giorni di retention.
  * [pusher.com](https://pusher.com/) — Servizio di messaggistica realtime. Gratuito fino a 100 connessioni simultanee e 200.000 messaggi/giorno
  * [scaledrone.com](https://www.scaledrone.com/) — Servizio di messaggistica realtime. Gratuito fino a 20 connessioni simultanee e 100.000 eventi/giorno
  * [synadia.com](https://synadia.com/ngs) — [NATS.io](https://nats.io) as a service. Globale, AWS, GCP e Azure. Gratuito per sempre con messaggi da 4k, 50 connessioni attive e 5GB di dati al mese.
  * [pubnub.com](https://www.pubnub.com/) - Messaggistica Swift, Kotlin e React con 1 milione di transazioni ogni mese. Le transazioni possono contenere più messaggi.
  * [eyeson API](https://developers.eyeson.team/) - Servizio API di comunicazione video basato su WebRTC (SFU, MCU) per costruire piattaforme video. Permette iniezione dati realtime, layout video, registrazioni, UI web hosted completa (quickstart) o pacchetti per UI custom. [Livello gratuito per sviluppatori](https://apiservice.eyeson.com/api-pricing) con 1000 minuti riunione al mese.
  * [webpushr](https://www.webpushr.com/) - Notifiche Web Push - Gratuito fino a 10k iscritti, notifiche push illimitate, messaggistica in-browser
  * [httpSMS](https://httpsms.com) - Invia e ricevi SMS usando il tuo telefono Android come gateway SMS. Gratuito per invio e ricezione fino a 200 messaggi al mese.
  * [EMQX Serverless](https://www.emqx.com/en/cloud/serverless-mqtt) - Broker MQTT serverless scalabile e sicuro pronto in pochi secondi. 1M minuti sessione/mese gratis per sempre (senza carta di credito).
  * [Pocket Alert](https://pocketalert.app) - Invia notifiche push ai tuoi dispositivi iOS e Android. Integrazione via API o Webhooks e pieno controllo sugli alert. Piano gratuito: 50 messaggi al giorno per 1 dispositivo e 1 applicazione.
  * [SuprSend](https://www.suprsend.com/) - SuprSend è un'infrastruttura notifiche che semplifica le notifiche di prodotto con un approccio API-first. Crea e consegna notifiche transazionali, cron e di engagement su più canali con una singola API. Nel piano gratuito ottieni 10.000 notifiche al mese, inclusi diversi nodi di workflow come digest, batch, multi-canale, preferenze, tenant, broadcast e altro.

**[⬆️ Torna all'inizio](#table-of-contents)**

## Gestione Log

  * [bugfender.com](https://bugfender.com/) — Gratuito fino a 100k righe log/giorno con 24 ore di retention
  * [logentries.com](https://logentries.com/) — Gratuito fino a 5 GB/mese con sette giorni di retention
  * [loggly.com](https://www.loggly.com/) — Gratuito per un singolo utente, 200MB/giorno con sette giorni di retention
  * [logz.io](https://logz.io/) — Gratuito fino a 1 GB/giorno, un giorno di retention
  * [ManageEngine Log360 Cloud](https://www.manageengine.com/cloud-siem/) — Servizio di gestione log gestito da Manage Engine. Piano gratuito offre 50 GB di storage con 15 giorni di retention e 7 giorni di ricerca.
  * [papertrailapp.com](https://papertrailapp.com/) — 48 ore di ricerca, sette giorni di archivio, 50 MB/mese
  * [sematext.com](https://sematext.com/logsene) — Gratuito fino a 500 MB/giorno, sette giorni di retention
  * [sumologic.com](https://www.sumologic.com/) — Gratuito fino a 500 MB/giorno, sette giorni di retention
  * [logflare.app](https://logflare.app/) — Gratuito fino a 12.960.000 entry per app al mese, 3 giorni di retention
  * [logtail.com](https://logtail.com/) — Gestione log basata su ClickHouse compatibile SQL. Gratuito fino a 1 GB al mese, tre giorni di retention.
  * [logzab.com](https://logzab.com/) — Sistema di gestione audit trail. Gratis 1.000 log attività utente/mese, 1 mese di retention, fino a 5 progetti.
  * [openobserve.ai](https://openobserve.ai/) - 200 GB di ingestione/mese gratis, 15 giorni di retention
**[⬆️ Torna all'inizio](#table-of-contents)**

## Gestione delle Traduzioni

  * [crowdin.com](https://crowdin.com/) — Progetti illimitati, stringhe illimitate e collaboratori per Open Source
  * [gitlocalize.com](https://gitlocalize.com) - Gratuito e illimitato sia per repository privati che pubblici
  * [Lecto](https://lecto.ai/) - API di Traduzione Automatica con piano gratuito (30 richieste gratuite, 1000 caratteri tradotti per richiesta). Integrato con il plugin Loco Translate per Wordpress.
  * [lingohub.com](https://lingohub.com/) — Gratuito fino a 3 utenti, sempre gratuito per Open Source
  * [localazy.com](https://localazy.com) - Gratuito per 1000 stringhe nella lingua sorgente, lingue illimitate, collaboratori illimitati, offerte per startup e open source
  * [Localeum](https://localeum.com) - Gratuito fino a 1000 stringhe, un utente, lingue illimitate, progetti illimitati
  * [localizely.com](https://localizely.com/) — Gratuito per Open Source
  * [Loco](https://localise.biz/) — Gratuito fino a 2000 traduzioni, traduttori illimitati, dieci lingue/progetto, 1000 asset traducibili/progetto
  * [oneskyapp.com](https://www.oneskyapp.com/) — Edizione gratuita limitata fino a 5 utenti, gratuito per Open Source
  * [POEditor](https://poeditor.com/) — Gratuito fino a 1000 stringhe
  * [SimpleLocalize](https://simplelocalize.io/) - Gratuito fino a 100 chiavi di traduzione, stringhe illimitate, lingue illimitate, offerte per startup
  * [Texterify](https://texterify.com/) - Gratuito per un singolo utente
  * [Tolgee](https://tolgee.io) - Offerta SaaS gratuita con traduzioni limitate, versione self-hosted sempre gratuita
  * [transifex.com](https://www.transifex.com/) — Gratuito per Open Source
  * [Translation.io](https://translation.io) - Gratuito per Open Source
  * [Translized](https://translized.com) - Gratuito fino a 1000 stringhe, un utente, lingue illimitate, progetti illimitati
  * [webtranslateit.com](https://webtranslateit.com/) — Gratuito fino a 500 stringhe
  * [weblate.org](https://weblate.org/) — Gratuito per progetti liberi con fino a 10.000 stringhe sorgente per il piano gratuito e illimitato per la versione Self-hosted on-premises.
  * [Free PO editor](https://pofile.net/free-po-editor) — Gratuito per tutti
  * [Lingo.dev](https://lingo.dev) – CLI open-source basata su AI per la localizzazione web & mobile. Puoi portare il tuo LLM, oppure usare 10.000 parole gratuite ogni mese tramite il motore di localizzazione gestito da Lingo.dev.

**[⬆️ Torna all'inizio](#table-of-contents)**

## Monitoraggio

  * [UptimeObserver.com](https://uptimeobserver.com) - Ottieni 20 monitoraggi uptime con intervalli di 5 minuti e una pagina di stato personalizzabile—anche per uso commerciale. Notifiche illimitate e in tempo reale via email e Telegram. Nessuna carta di credito richiesta per iniziare.
  * [Pingmeter.com](https://pingmeter.com/) - 5 monitor uptime con intervallo di 10 minuti. Monitora SSH, HTTP, HTTPS e qualsiasi porta TCP personalizzata.
  * [alerty.ai](https://www.alerty.ai) - APM e monitoraggio gratuito per FE, BE, DB e altro + esecuzioni agent gratuite.
  * [appdynamics.com](https://www.appdynamics.com/) — Gratuito per metriche di 24 ore, agent di gestione delle prestazioni applicative limitati a uno Java, uno .NET, uno PHP e uno Node.js
  * [appneta.com](https://www.appneta.com/) — Gratuito con conservazione dei dati di 1 ora
  * [appspector.com](https://appspector.com/) - Mission control per il debug remoto di iOS/Android/Flutter. Gratuito per uso con traffico limitato (64MB di log).
  * [assertible.com](https://assertible.com) — Test e monitoraggio API automatizzato. Piani gratuiti per team e singoli.
  * [bleemeo.com](https://bleemeo.com) - Gratuito per 3 server, 5 monitor uptime, utenti illimitati, dashboard illimitate, regole di allerta illimitate.
  * [Core Web Vitals History](https://punits.dev/core-web-vitals-historical/) - Trova la cronologia Core Web Vitals di un URL o sito web.
  * [checklyhq.com](https://checklyhq.com) - Monitoraggio E2E/Sintetico open source e monitoraggio API approfondito per sviluppatori. Piano gratuito con un utente e 10k esecuzioni check API & network / 1.5k browser.
  * [cloudsploit.com](https://cloudsploit.com) — Monitoraggio sicurezza e configurazione AWS. Gratuito: scansioni on-demand illimitate, utenti illimitati, account archiviati illimitati. Abbonamento: scansione automatica, accesso API, ecc.
  * [cronitor.io](https://cronitor.io/) - Analisi delle performance e monitoraggio uptime per cron job, siti web, API e altro. Un piano gratuito con cinque monitor.
  * [datadoghq.com](https://www.datadoghq.com/) — Gratuito fino a 5 nodi
  * [deadmanssnitch.com](https://deadmanssnitch.com/) — Monitoraggio per cron job. Un "snitch" (monitor) gratuito, altri se fai iscrivere altri utenti
  * [downtimemonkey.com](https://downtimemonkey.com/) — 60 monitor uptime, intervallo di 5 minuti. Avvisi Email, Slack.
  * [economize.cloud](https://economize.cloud) — Economize aiuta a chiarire i costi delle infrastrutture cloud organizzando le risorse cloud per ottimizzarle e riportarle. Gratuito fino a 5.000$ spesi su Google Cloud Platform ogni mese.
  * [elastic.co](https://www.elastic.co/solutions/apm) — Analisi immediate delle prestazioni per sviluppatori JS. Gratuito con conservazione dati di 24 ore
  * [fivenines.io](https://fivenines.io/) — Monitoraggio server Linux con dashboard in tempo reale e avvisi — gratuito per sempre fino a 5 server monitorati a intervalli di 60 secondi. Nessuna carta di credito richiesta.
  * [Grafana Cloud](https://grafana.com/products/cloud/) - Grafana Cloud è una piattaforma di osservabilità componibile che integra metriche e log con Grafana. Gratuito: 3 utenti, dieci dashboard, 100 avvisi, archiviazione metriche in Prometheus e Graphite (10.000 serie, 14 giorni di conservazione), archiviazione log in Loki (50 GB di log, 14 giorni di conservazione)
  * [healthchecks.io](https://healthchecks.io) — Monitora i tuoi cron job e task in background. Gratuito fino a 20 controlli.
  * [Hydrozen.io](https://hydrozen.io) — Uptime monitoring & Status pages, piano gratuito: 10 monitor uptime, 5 monitor heartbeat, 1 monitor dominio e 1 Statuspage gratis.
  * [incidenthub.cloud](https://incidenthub.cloud/) — Aggregatore di pagine di stato Cloud e SaaS - 20 monitor e 2 canali di notifica (Slack e Discord) sono gratuiti per sempre.
  * [inspector.dev](https://www.inspector.dev) - Dashboard di monitoraggio in tempo reale completa in meno di un minuto con piano sempre gratuito.
  * [instrumentalapp.com](https://instrumentalapp.com) - Monitoraggio applicazioni e server facile e bello con fino a 500 metriche e 3 ore di visibilità dati gratuitamente
  * [keychest.net/speedtest](https://keychest.net/speedtest) - Test di velocità indipendente e test di latenza handshake TLS contro Digital Ocean
  * [letsmonitor.org](https://letsmonitor.org) - Monitoraggio SSL, gratuito fino a 5 monitor
  * [linkok.com](https://linkok.com) - Verifica online di link rotti, gratuito per piccoli siti fino a 100 pagine, completamente gratuito per progetti open-source.
  * [loader.io](https://loader.io/) — Strumenti di test di carico gratuiti con limitazioni
  * [MonitorMonk](https://monitormonk.com) - Monitoraggio uptime minimalista con belle pagine di stato. Il piano Forever Free offre monitoraggio HTTPS, parole chiave, SSL e tempi di risposta per 10 siti o endpoint API, e fornisce 2 dashboard/pagine di stato.
  * [netdata.cloud](https://www.netdata.cloud/) — Netdata è uno strumento open-source per raccogliere metriche in tempo reale. È un prodotto in crescita e si trova anche su GitHub!
  * [newrelic.com](https://www.newrelic.com) — La piattaforma di osservabilità New Relic aiuta gli ingegneri a creare software più perfetto. Dai monoliti al serverless, puoi monitorare tutto e poi analizzare, risolvere e ottimizzare l'intero stack. Il piano gratuito offre 100GB/mese di ingestione dati gratuita, un utente full-access gratuito, e utenti primari illimitati gratuiti.
  * [Middleware.io](https://middleware.io/) - La piattaforma di osservabilità Middleware offre visibilità completa su app & stack, così puoi monitorare & diagnosticare problemi su larga scala. Piano sempre gratuito per la community Dev che consente il monitoraggio dei log fino a 1M eventi log, monitoraggio infrastrutturale & APM per fino a 2 host.
  * [nixstats.com](https://nixstats.com) - Gratuito per un server. Notifiche Email, pagina di stato pubblica, intervallo di 60 secondi, e altro.
  * [OnlineOrNot.com](https://onlineornot.com/) - OnlineOrNot offre monitoraggio uptime per siti web e API, monitoraggio per cron job e task programmati. Fornisce anche pagine di stato. I primi cinque controlli con intervallo di 3 minuti sono gratuiti. Il piano gratuito invia avvisi via Slack, Discord ed Email.
  * [OntarioNet.ca CN Test](https://cntest.ontarionet.ca) — Verifica se un sito web è bloccato in Cina dal Great Firewall. Identifica l'inquinamento DNS confrontando i risultati DNS e le informazioni ASN rilevate da server in Cina rispetto a server negli Stati Uniti.
  * [opsgenie.com](https://www.opsgenie.com/) — Potente gestione degli avvisi e delle reperibilità per servizi always-on. Gratuito fino a 5 utenti.
  * [paessler.com](https://www.paessler.com/) — Potente soluzione di monitoraggio infrastruttura e rete, inclusi avvisi, visualizzazioni avanzate e reportistica base. Gratuito fino a 100 sensori.
  * [pagecrawl.io](https://pagecrawl.io/) -  Monitora cambiamenti sui siti web, gratuito fino a 6 monitor con controlli giornalieri.
  * [syagent.com](https://syagent.com/) — Servizio gratuito non commerciale di monitoraggio server, avvisi e metriche.
  * [pagerly.io](https://pagerly.io/) -  Gestisci le reperibilità su Slack (integra con Pagerduty, OpsGenie). Gratuito fino a 1 team (un team equivale a una reperibilità)
  * [pagertree.com](https://pagertree.com/) - Interfaccia semplice per gestione avvisi e reperibilità. Gratuito fino a 5 utenti.
  * [phare.io](https://phare.io/) - Uptime monitoring gratuito fino a 100.000 eventi per progetti illimitati e pagine di stato illimitate.
  * [pingbreak.com](https://pingbreak.com/) — Servizio moderno di monitoraggio uptime. Controlla URL illimitati e ricevi notifiche di downtime via Discord, Slack o email.
  * [pingpong.one](https://pingpong.one/) — Piattaforma avanzata di pagine di stato con monitoraggio. Il piano gratuito include una pagina di stato pubblica personalizzabile con sottodominio SSL. Il piano Pro è offerto gratis a progetti open-source e non-profit.
  * [robusta.dev](https://home.robusta.dev/) — Potente monitoraggio Kubernetes basato su Prometheus. Puoi portare il tuo Prometheus o installare il bundle all-in-one. Il piano gratuito include fino a 20 nodi Kubernetes. Avvisi via Slack, Microsoft Teams, Discord e altro. Integrazioni con PagerDuty, OpsGenie, VictorOps, DataDog e molti altri strumenti.
  * [sematext.com](https://sematext.com/) — Gratuito per metriche di 24 ore, server illimitati, dieci metriche personalizzate, 500.000 punti dati metriche personalizzate, dashboard, utenti, ecc. illimitati.
  * [sitemonki.com](https://sitemonki.com/) — Monitoraggio sito, dominio, Cron & SSL, 5 monitor per ogni categoria gratuitamente
  * [sitesure.net](https://sitesure.net) - Monitoraggio sito web e cron - 2 monitor gratuiti
  * [skylight.io](https://www.skylight.io/) — Gratuito per i primi 100.000 richieste (solo Rails)
  * [speedchecker.xyz](https://probeapi.speedchecker.xyz/) — API per il monitoraggio delle performance, controlla Ping, DNS, ecc.
  * [stathat.com](https://www.stathat.com/) — Inizia con dieci statistiche gratuitamente, senza scadenza
  * [statuscake.com](https://www.statuscake.com/) — Monitoraggio siti web, test illimitati gratuiti con limitazioni
  * [statusgator.com](https://statusgator.com/) — Monitoraggio delle pagine di stato, 3 monitor gratis
  * [SweetUptime](https://dicloud.net/sweetuptime-server-uptime-monitoring/) — Monitoraggio server, uptime, DNS & dominio. Monitora 10 server, 10 uptime, e 10 domini gratuitamente.
  * [thousandeyes.com](https://www.thousandeyes.com/) — Monitoraggio rete ed esperienza utente. 3 località e 20 feed dati dei principali servizi web gratuiti
  * [uptimetoolbox.com](https://uptimetoolbox.com/) — Monitoraggio gratuito per cinque siti, intervallo di 60 secondi, statuspage pubblica.
  * [zenduty.com](https://www.zenduty.com/) — Gestione incidenti end-to-end, avvisi, gestione reperibilità e orchestrazione risposte per network operations, site reliability engineering e team DevOps. Gratuito fino a 5 utenti.
  * [instatus.com](https://instatus.com) - Ottieni una pagina di stato bella in 10 secondi. Gratuito per sempre con abbonati illimitati e team illimitati.
  * [Squadcast.com](https://squadcast.com) - Squadcast è un software di incident management end-to-end progettato per promuovere le best practice SRE. Piano gratuito per sempre disponibile fino a 10 utenti.
  * [RoboMiri.com](https://robomiri.com/) - RoboMiri è un monitor uptime stabile che offre una vasta gamma di monitor: cronjob, keyword, sito web, porta, ping. Venticinque controlli uptime con intervallo di 3 minuti gratuiti. Avvisi via Telefonata, SMS, Email e Webhook.
  * [Better Stack](https://betterstack.com/better-uptime) - Monitoraggio uptime, gestione incidenti, programmazione/avvisi reperibilità e pagine di stato in un unico prodotto. Il piano gratuito include dieci monitor con frequenza di controllo di 3 minuti e pagine di stato.
  * [Pulsetic](https://pulsetic.com) - 10 monitor, 6 mesi di cronologia Uptime/Log, pagine di stato illimitate e domini personalizzati inclusi! Per sempre e avvisi email illimitati gratuitamente. Non serve carta di credito.
  * [Wachete](https://www.wachete.com) - monitora cinque pagine, controlli ogni 24 ore.
  * [Xitoring.com](https://xitoring.com/) — Uptime monitoring: 20 gratuiti, Monitoraggio server Linux e Windows: 5 gratuiti, Status page: 1 gratuita - App mobile, canali di notifica multipli, e molto altro!
  * [Servervana](https://servervana.com) - Monitoraggio uptime avanzato con supporto a grandi progetti e team. Fornisce monitoraggio HTTP, monitoraggio basato su browser, monitoraggio DNS, monitoraggio dominio, pagine di stato e altro. Il piano gratuito include 10 monitor HTTP, 1 monitor DNS e una pagina di stato.

**[⬆️ Torna all'inizio](#table-of-contents)**

## Gestione Crash ed Eccezioni
* [CatchJS.com](https://catchjs.com/) - Tracciamento degli errori JavaScript con screenshot e tracciamento dei clic. Gratuito per progetti open-source.
* [bugsnag.com](https://www.bugsnag.com/) — Gratuito fino a 2.000 errori/mese dopo la prova iniziale
* [elmah.io](https://elmah.io/) — Logging degli errori e monitoraggio dell’uptime per sviluppatori web. Abbonamento Small Business gratuito per progetti open-source.
* [Embrace](https://embrace.io/) — Monitoraggio di app mobile. Gratuito per piccoli team fino a 1 milione di sessioni utente all'anno.
* [exceptionless](https://exceptionless.com) — Reportistica in tempo reale di errori, funzionalità, log e altro. Gratuito fino a 3.000 eventi al mese/1 utente. Open source e facile da ospitare autonomamente per uso illimitato.
* [GlitchTip](https://glitchtip.com/) — Tracciamento errori semplice e open-source. Compatibile con gli SDK open-source di Sentry. 1000 eventi al mese gratis, oppure può essere auto-ospitato senza limiti.
* [honeybadger.io](https://www.honeybadger.io) - Monitoraggio di eccezioni, uptime e cron. Gratuito per piccoli team e progetti open-source (12.000 errori/mese).
* [memfault.com](https://memfault.com) — Piattaforma cloud per osservabilità e debug dei dispositivi. 100 dispositivi gratuiti per dispositivi [Nordic](https://app.memfault.com/register-nordic), [NXP](https://app.memfault.com/register-nxp) e [Laird](https://app.memfault.com/register-laird).
* [rollbar.com](https://rollbar.com/) — Monitoraggio di eccezioni ed errori, piano gratuito con 5.000 errori/mese, utenti illimitati, conservazione dati 30 giorni
* [sentry.io](https://sentry.io/) — Sentry traccia le eccezioni delle app in tempo reale e offre un piccolo piano gratuito. Gratuito per 5.000 errori al mese/1 utente, uso illimitato se auto-ospitato.
* [Axiom](https://axiom.co/) — Archivia fino a 0,5 TB di log con conservazione di 30 giorni. Include integrazioni con piattaforme come Vercel e query avanzate sui dati con notifiche email/Discord.
* [Semaphr](https://semaphr.com) — Kill switch tutto-in-uno gratuito per le tue app mobile.
* [Jam](https://jam.dev) - Report di bug per sviluppatori con un clic. Piano gratuito con jam illimitati.
* [Whitespace](https://whitespace.dev) – Report di bug con un clic direttamente nel browser. Piano gratuito con registrazioni illimitate per uso personale.

**[⬆️ Torna all'inizio](#table-of-contents)**

## Ricerca

* [algolia.com](https://www.algolia.com/) — Soluzione di ricerca ospitata con tolleranza agli errori di digitazione, rilevanza e librerie UI per creare facilmente esperienze di ricerca. Il piano gratuito "Build" include 1 milione di documenti e 10.000 ricerche/mese. Offre anche [ricerca nella documentazione per sviluppatori](https://docsearch.algolia.com/) gratuitamente.
* [bonsai.io](https://bonsai.io/) — 1 GB di memoria e 1 GB di storage gratuiti
* [CommandBar](https://www.commandbar.com/) - Barra di ricerca unificata as-a-service, widget/plugin UI web-based che consente agli utenti di cercare contenuti, navigazione, funzionalità, ecc. all'interno del prodotto, favorendo la scoperta. Gratuito fino a 1.000 utenti attivi mensili, comandi illimitati.
* [Orama Cloud](https://orama.com/pricing) — 3 indici gratuiti, 100.000 documenti/indice, ricerche full-text/vettoriali/ibride illimitate, 60 giorni di analytics
* [searchly.com](http://www.searchly.com/) — 2 indici gratuiti e 20 MB di storage
* [easysitesearch.com](https://easysitesearch.com/) — Widget di ricerca e API, con indicizzazione automatica tramite web-crawler. Ricerche illimitate gratuite fino a 50 sottopagine.

**[⬆️ Torna all'inizio](#table-of-contents)**

## Istruzione e Sviluppo Professionale

* [FreeCodeCamp](https://www.freecodecamp.org/) - Piattaforma open-source che offre corsi e certificazioni gratuiti in Data Analysis, Information Security, Web Development e altro.
* [The Odin Project](https://www.theodinproject.com/) - Piattaforma gratuita e open-source con curriculum focalizzato su JavaScript e Ruby per lo sviluppo web.
* [Free Professional Resume Templates & Editor](https://www.overleaf.com/latex/templates/tagged/cv) - Piattaforma gratuita con molti template di CV di Professionisti Esperti, pronti da clonare, modificare completamente e scaricare, ottimizzati per ATS.
* [DeepLearning.AI Short Courses](https://www.deeplearning.ai/short-courses/) - Mini-corsi gratuiti da esperti leader del settore per mettere subito mano agli ultimi strumenti e tecniche di AI generativa in meno di un’ora.
* [LabEx](https://labex.io) - Sviluppa competenze in Linux, DevOps, Cybersecurity, Programmazione, Data Science e altro tramite laboratori interattivi e progetti reali.
* [Roadmap.sh](https://roadmap.sh) - Roadmap di apprendimento gratuite che coprono tutti gli aspetti dello sviluppo, dalla Blockchain al UX Design.
* [Cisco Networking Academy, Skills for All](https://skillsforall.com/) - Offre corsi gratuiti allineati alle certificazioni su temi come cybersecurity, networking e Python.
* [MIT OpenCourseWare](https://ocw.mit.edu/) - MIT OpenCourseWare è una pubblicazione online di materiali di oltre 2.500 corsi MIT, che condivide liberamente conoscenza con studenti e docenti in tutto il mondo. Il canale YouTube si trova su [@mitocw](https://www.youtube.com/@mitocw/featured)
* [W3Schools](https://www.w3schools.com/) - Offre tutorial gratuiti sulle tecnologie di sviluppo web come HTML, CSS, JavaScript e altro.
* [Khan Academy](https://www.khanacademy.org/computing/computer-programming) - Guide online gratuite per apprendere HTML/CSS di base e avanzato, JavaScript e SQL.
* [Full Stack Open](https://fullstackopen.com/en/) – Corso universitario gratuito sullo sviluppo web moderno con React, Node.js, GraphQL, TypeScript e altro. Totalmente online e self-paced.
* [edX](https://www.edx.org/) - Accesso a oltre 4.000 corsi online gratuiti di 250 istituzioni leader, incluse Harvard e MIT, specializzati in informatica, ingegneria e data science.
* [Django-tutorial.dev](https://django-tutorial.dev) - Guide online gratuite per imparare Django come primo framework & dà backlink dofollow gratuito agli articoli scritti dagli utenti.

**[⬆️ Torna all'inizio](#table-of-contents)**

## Email

* [10minutemail](https://10minutemail.com) - Email temporanea gratuita per test.
* [AhaSend](https://ahasend.com) - Servizio email transazionale, gratuito per 1000 email al mese, con domini illimitati, membri del team, webhook e instradamenti dei messaggi inclusi nel piano gratuito.
* [AnonAddy](https://anonaddy.com) - Email forwarding anonimo open-source, crea alias email illimitati gratuitamente.
* [Antideo](https://www.antideo.com/) — 10 richieste API all’ora per verifica email, IP e numero di telefono nel piano gratuito. Non è richiesta carta di credito.
* [Brevo](https://www.brevo.com/) — 9.000 email/mese, 300 email/giorno gratis
* [OneSignal](https://onesignal.com/) — 10.000 email/mese, non è richiesta carta di credito.
* [Bump](https://bump.email/) - 10 indirizzi email Bump gratuiti, un dominio personalizzato
* [Burnermail](https://burnermail.io/) – 5 indirizzi email Burner gratuiti, 1 casella postale, cronologia email di 7 giorni
* [Buttondown](https://buttondown.email/) — Servizio newsletter. Fino a 100 iscritti gratis
* [CloudMailin](https://www.cloudmailin.com/) - Email in entrata via HTTP POST e email transazionali in uscita - 10.000 email/mese gratis
* [Contact.do](https://contact.do/) — Modulo di contatto in un link (bitly per moduli di contatto)
* [debugmail.io](https://debugmail.io/) — Server mail di test facile da usare per sviluppatori
* [DNSExit](https://dnsexit.com/) - Fino a 2 indirizzi email sotto il tuo dominio gratis con 100MB di spazio. Supporto IMAP, POP3, SMTP, SPF/DKIM.
* [EmailLabs.io](https://emaillabs.io/en) — Invia fino a 9.000 email gratis ogni mese, fino a 300 email al giorno.
* [EmailOctopus](https://emailoctopus.com) - Fino a 2.500 iscritti e 10.000 email al mese gratis
* [EmailJS](https://www.emailjs.com/) – Non è un server email completo; è solo un client che puoi usare per inviare email direttamente dal client senza esporre le tue credenziali, il piano gratuito ha 200 richieste mensili, 2 template email, richieste fino a 50Kb, cronologia contatti limitata.
* [EtherealMail](https://ethereal.email) - Ethereal è un servizio SMTP fittizio, pensato principalmente per utenti Nodemailer ed EmailEngine (ma non solo). È un servizio email antitransazionale completamente gratuito dove i messaggi non vengono mai consegnati.
* [Temp-Mail.org](https://temp-mail.org/en/) - Generatore di email temporanee/usa e getta che utilizza una vasta gamma di domini. L’indirizzo email si aggiorna ogni volta che la pagina viene ricaricata. È completamente gratuito e non prevede prezzi per i servizi offerti.
* [TempMailDetector.com](https://tempmaildetector.com/) - Verifica fino a 200 email al mese gratis e controlla se un’email è temporanea o meno.
* [Emailvalidation.io](https://emailvalidation.io) - 100 verifiche email gratuite al mese
* [FakeMailGenerator.com](https://www.fakemailgenerator.com/) - Generatore tedesco di email temporanee/usa e getta. Supporta 10 domini, ti permette di creare indirizzi illimitati. (contiene annunci) ma a parte questo, il servizio è completamente gratuito.
* [forwardemail.net](https://forwardemail.net) — Email forwarding gratuito per domini personalizzati. Crea e inoltra un numero illimitato di indirizzi email con il tuo dominio (**nota**: Devi pagare se usi i TLD .casa, .cf, .click, .email, .fit, .ga, .gdn, .gq, .lat, .loan, .london, .men, .ml, .pl, .rest, .ru, .tk, .top, .work a causa dello spam)
* [Imitate Email](https://imitate.email) - Server email sandbox per testare la funzionalità email durante build/qa e ci/cd. Gli account gratuiti ricevono 15 email al giorno per sempre.
* [ImprovMX](https://improvmx.com) – Email forwarding gratuito.
* [EForw](https://www.eforw.com) – Email forwarding gratuito per un dominio. Ricevi e invia email dal tuo dominio.
* [Inboxes App](https://inboxesapp.com) — Crea fino a 3 email temporanee al giorno, poi eliminale quando hai finito tramite una comoda estensione Chrome. Perfetto per testare i flussi di registrazione.
* [inboxkitten.com](https://inboxkitten.com/) - Casella email temporanea/usa e getta gratuita, con cancellazione automatica delle email fino a 3 giorni. Open source e auto-ospitabile.
* [mail-tester.com](https://www.mail-tester.com) — Testa se le impostazioni DNS/SPF/DKIM/DMARC dell’email sono corrette, 20 gratis/mese.
* [dkimvalidator.com](https://dkimvalidator.com/) - Verifica se le impostazioni DNS/SPF/DKIM/DMARC dell’email sono corrette, servizio gratuito by roundsphere.com
* [mailcatcher.me](https://mailcatcher.me/) — Riceve email e le visualizza tramite interfaccia web.
* [mailchannels.com](https://www.mailchannels.com) - API email con integrazione REST API e SMTP, gratuito fino a 3.000 email/mese.
* [Mailcheck.ai](https://www.mailcheck.ai/) - Impedisce agli utenti di registrarsi con indirizzi email temporanei, 120 richieste/ora (~86.400 al mese)
* [Mailchimp](https://mailchimp.com/) — 500 iscritti e 1.000 email/mese gratis.
* [Maildroppa](https://maildroppa.com) - Fino a 100 iscritti e email illimitate e automazioni gratis.
* [MailerLite.com](https://www.mailerlite.com) — 1.000 iscritti/mese, 12.000 email/mese gratis
* [MailerSend.com](https://www.mailersend.com) — Email API, SMTP, 3.000 email/mese gratis per email transazionali
* [mailinator.com](https://www.mailinator.com/) — Sistema email pubblico e gratuito dove puoi usare qualsiasi inbox tu voglia
* [Mailjet](https://www.mailjet.com/) — 6.000 email/mese gratis (limite invio giornaliero 200 email)
* [Mailnesia](https://mailnesia.com) - Email temporanea/usa e getta gratuita, che visita automaticamente i link di registrazione.
* [mailsac.com](https://mailsac.com) - API gratuita per il test di email temporanee, hosting gratuito di email pubbliche, cattura in uscita, email-to-slack/websocket/webhook (limite mensile di 1.500 API)
* [Mailtrap.io](https://mailtrap.io/) — Falso server SMTP per sviluppo, piano gratuito con una inbox, 100 messaggi, nessun membro del team, due email/secondo, nessuna regola di inoltro.
* [Mail7.io](https://www.mail7.io/) — Indirizzi email temporanei gratuiti per sviluppatori QA. Crea indirizzi email istantaneamente tramite interfaccia web o API.
* [Momentary Email](https://www.momentaryemail.com/) — Indirizzi email temporanei gratuiti. Leggi le email ricevute sul sito o tramite feed RSS.
* [Mutant Mail](https://www.mutantmail.com/) – 10 ID email, 1 dominio, 1 casella postale gratis. Una casella unica per tutti gli ID email.
* [Outlook.com](https://outlook.live.com/owa/) - Email personale e calendario gratuiti.
* [Parsio.io](https://parsio.io) — Email parser gratuito (inoltra l'email, estrai i dati, inviali al tuo server)
* [pepipost.com](https://pepipost.com) — 30.000 email gratis per il primo mese, poi le prime 100 email/giorno gratis.
* [Plunk](https://useplunk.com) - 3.000 email/mese gratis
* [Postmark](https://postmarkapp.com/) - 100 email/mese gratis, report DMARC settimanali illimitati.
* [Proton Mail](https://proton.me/mail) - Servizio gratuito di email sicura con crittografia end-to-end integrata. 1GB di storage gratis.
* [Queuemail.dev](https://queuemail.dev) — API affidabile di consegna email. Piano gratuito (10.000 email/mese). Invio asincrono. Usa diversi server SMTP. Blocklist, log, tracciamento, webhook e altro.
* [QuickEmailVerification](https://quickemailverification.com) — Verifica 100 email al giorno gratuitamente nel piano free insieme ad altre API gratuite come DEA Detector, DNS Lookup, SPF Detector e altro.
* [Resend](https://resend.com) - API per email transazionali per sviluppatori. 3.000 email/mese, 100 email/giorno gratis, un dominio personalizzato.
* [Sender](https://www.sender.net) Fino a 15.000 email/mese, fino a 2.500 iscritti
* [Sendpulse](https://sendpulse.com) — 500 iscritti/mese, 15.000 email/mese gratis
* [SimpleLogin](https://simplelogin.io/) – Soluzione open source e self-hostable per alias email/inoltro. Gratis 5 alias, banda illimitata, risposta/invio illimitati. Gratis per personale educativo (studente, ricercatore, ecc.).
* [Substack](https://substack.com) — Servizio di newsletter illimitato e gratuito. Si paga solo quando si inizia a far pagare.
* [Sweego](https://www.sweego.io/) - API europea per email transazionali per sviluppatori. 500 email/giorno gratis.
* [Takeout](https://takeout.bysourfruit.com) - Servizio email costantemente aggiornato che facilita l'invio di email. Cinquecento email transazionali/mese gratis.
* [temp-mail.io](https://temp-mail.io) — Servizio gratuito di email temporanee usa e getta con gestione di più email contemporaneamente e inoltro
* [tinyletter.com](https://tinyletter.com/) — 5.000 iscritti/mese gratis
* [Touchlead](https://touchlead.app) - Strumento di automazione marketing multifunzionale, con gestione lead, builder di moduli e automazioni. Gratuito per un numero limitato di lead e automazioni
* [trashmail.com](https://www.trashmail.com) - Indirizzi email usa e getta gratuiti con inoltro e scadenza automatica dell'indirizzo
* [Tuta](https://tuta.com/) - Servizio gratuito di account email sicuri con crittografia end-to-end integrata, senza pubblicità, senza tracciamento. 1GB di spazio gratuito, un calendario (Tuta offre anche un [piano a pagamento](https://tuta.com/pricing).). Tuta è anche parzialmente [open source](https://github.com/tutao/tutanota), quindi puoi ospitarlo autonomamente.
* [Verifalia](https://verifalia.com/email-verification-api) — API di verifica email in tempo reale con conferma della casella e rilevatore di email usa e getta; 25 verifiche email gratuite/giorno.
* [verimail.io](https://verimail.io/) — Servizio di verifica email in bulk e tramite API. 100 verifiche gratuite/mese
* [Zoho](https://www.zoho.com) — Nato come provider di email, ora offre una suite di servizi, alcuni dei quali con piani gratuiti. Elenco dei servizi con piani gratuiti:
   - [Email](https://zoho.com/mail) Gratuito per 5 utenti. 5GB/utente & 25 MB limite allegati, un dominio.
   - [Zoho Assist](https://www.zoho.com/assist) — Il piano gratuito per sempre di Zoho Assist include una licenza di supporto remoto concorrente e accesso a 5 licenze computer non presidiati per durata illimitata, disponibile sia per uso professionale che personale.
   - [Sprints](https://zoho.com/sprints) Gratis per 5 utenti, 5 Progetti & 500MB di storage.
   - [Docs](https://zoho.com/docs) — Gratis per 5 utenti con limite di upload 1 GB & 5GB di storage. Zoho Office Suite (Writer, Sheets & Show) inclusa.
   - [Projects](https://zoho.com/projects) — Gratis per 3 utenti, 2 progetti & 10 MB limite allegati. Lo stesso piano si applica a [Bugtracker](https://zoho.com/bugtracker).
   - [Connect](https://zoho.com/connect) — Collaborazione di squadra gratuita per 25 utenti con tre gruppi, tre app personalizzate, 3 Board, 3 Manuali e 10 Integrazioni oltre a canali, eventi & forum.
   - [Meeting](https://zoho.com/meeting) — Meeting fino a 3 partecipanti & 10 partecipanti Webinar.
   - [Vault](https://zoho.com/vault) — Gestione password accessibile per singoli utenti.
   - [Showtime](https://zoho.com/showtime) — Un altro software di meeting per training remoto fino a 5 partecipanti.
   - [Notebook](https://zoho.com/notebook) — Un'alternativa gratuita a Evernote.
   - [Wiki](https://zoho.com/wiki) — Gratuito per tre utenti con 50 MB di storage, pagine illimitate, backup zip, feed RSS & Atom, controlli di accesso & CSS personalizzabile.
   - [Subscriptions](https://zoho.com/subscriptions) — Gestione fatturazione ricorrente gratuita per 20 clienti/abbonamenti & 1 utente, con tutti i pagamenti ospitati da Zoho. Le ultime 40 metriche di abbonamento vengono conservate.
   - [Checkout](https://zoho.com/checkout) — Gestione fatturazione prodotto con 3 pagine & fino a 50 pagamenti.
   - [Desk](https://zoho.com/desk) — Gestione supporto clienti con tre agenti, knowledge base privata e ticket email. Si integra con [Assist](https://zoho.com/assist) per un tecnico remoto & 5 computer non presidiati.
   - [Cliq](https://zoho.com/cliq) — Chat di squadra con 100 GB di storage, utenti illimitati, 100 utenti per canale & SSO.
   - [Campaigns](https://zoho.com/campaigns) - Email Marketing
   - [Forms](https://zoho.com/forms) - Creazione Moduli
   - [Sign](https://zoho.com/sign) - Firme Digitali
   - [Surveys](https://zoho.com/surveys) - Sondaggi Online
   - [Bookings](https://zoho.com/bookings) - Prenotazione Appuntamenti
* [Maileroo](https://maileroo.com) - Relay SMTP e API email per sviluppatori. 5.000 email al mese, domini illimitati, verifica email gratuita, monitoraggio blacklist, mail tester e altro.

**[⬆️ Torna all'inizio](#table-of-contents)**

## Piattaforme di Gestione Feature Toggles

* [ConfigCat](https://configcat.com) - ConfigCat è un servizio di feature flag pensato per sviluppatori con team di dimensione illimitata, eccellente supporto e prezzi ragionevoli. Piano gratuito fino a 10 flag, due ambienti, 1 prodotto e 5 milioni di richieste al mese.
* [Flagsmith](https://flagsmith.com) - Rilascia funzionalità con sicurezza; gestisci flag su web, mobile e applicazioni server-side. Usa la nostra API ospitata, effettua il deploy sul tuo cloud privato o in locale.
* [GrowthBook](https://growthbook.io) - Provider open source di feature flag e A/B testing con motore di analisi statistica bayesiana integrato. Gratis fino a 3 utenti, feature flag ed esperimenti illimitati.
* [Hypertune](https://www.hypertune.com) - Feature flag type-safe, A/B testing, analytics e configurazione app, con controllo versione stile Git e valutazione locale, sincrona, in memoria dei flag. Gratis fino a 5 membri del team con flag ed A/B test illimitati.
* [Molasses](https://www.molasses.app) - Feature flag potenti e A/B testing. Gratis fino a 3 ambienti con cinque feature flag ciascuno.
* [Toggled.dev](https://www.toggled.dev) - Piattaforma di gestione feature toggles multi-regionale, scalabile e pronta per l’enterprise. Piano gratuito fino a 10 flag, due ambienti, richieste illimitate. SDK, dashboard analytics, calendario rilasci, notifiche Slack e tutte le altre funzioni incluse nel piano gratuito illimitato.
* [Statsig](https://www.statsig.com) - Piattaforma robusta per gestione feature, A/B testing, analytics e altro. Il piano gratuito offre posti illimitati, flag, esperimenti e configurazioni dinamiche, fino a 1 milione di eventi/mese.
* [Abby](https://www.tryabby.com) - Feature flag open-source & A/B testing. Configuration as Code & SDK Typescript completamente tipizzati. Forte integrazione con framework come Next.js & React. Livello gratuito generoso e opzioni di scaling economiche.

**[⬆️ Torna all'inizio](#table-of-contents)**

## Font

* [dafont](https://www.dafont.com/) - I font presentati su questo sito sono proprietà degli autori e sono freeware, shareware, versioni demo o di pubblico dominio.
* [Everything Fonts](https://everythingfonts.com/) - Offre diversi strumenti; @font-face, convertitore unità, Font Hinter e Font Submitter.
* [Font Squirrel](https://www.fontsquirrel.com/) - Font freeware con licenza per uso commerciale. Typeface selezionati a mano e presentati in modo facile da usare.
* [Google Fonts](https://fonts.google.com/) - Molti font gratuiti facili e veloci da installare su un sito tramite download o link al CDN di Google.
* [FontGet](https://www.fontget.com/) - Offre una varietà di font da scaricare e ordinati con tag.
* [Fontshare](https://www.fontshare.com/) - È un servizio di font gratuiti. Collezione crescente di font professionali, 100% gratuiti per uso personale e commerciale.
* [Befonts](https://befonts.com/) - Fornisce diversi font unici per uso personale o commerciale.
* [Font of web](https://fontofweb.com/) - Identifica tutti i font utilizzati su un sito web e come vengono usati.
* [Bunny](https://fonts.bunny.net) Google Fonts orientati alla privacy
* [FontsKey](https://www.fontskey.com/) - Offre font gratuiti e a pagamento per uso personale e consente di inserire testo per filtraggio rapido.
* [fonts.xz.style](https://fonts.xz.style/) servizio gratuito e open source per la distribuzione di famiglie di font sui siti tramite CSS.
* [Fontsensei](https://fontsensei.com/) Google fonts open source taggati dagli utenti. Con tag per font CJK (Cinese, Giapponese, Coreano).

**[⬆️ Torna all'inizio](#table-of-contents)**

## Moduli

* [Feathery](https://feathery.io) - Potente builder di moduli per sviluppatori. Crea flussi di iscrizione e login, onboarding utenti, pagamenti, applicazioni finanziarie complesse e altro. Il piano gratuito consente fino a 250 invii/mese e cinque moduli attivi.
* [Form-Data](https://form-data.com) - Backend per moduli senza codice. Filtro spam, notifiche email e autoresponder, webhook, zapier, redirect, AJAX o POST, e altro. Il piano gratuito offre moduli illimitati, 20 invii/mese e ulteriori 2000 invii con badge Form-Data.
* [FabForm](https://fabform.io/) - Piattaforma backend per moduli per sviluppatori intelligenti. Il piano gratuito consente 250 invii al mese. Interfaccia moderna e user-friendly. Integrazione con Google Sheets, Airtable, Slack, Email e altro.
* [Form.taxi](https://form.taxi/) — Endpoint per invio moduli HTML. Notifiche, blocco spam e trattamento dati conforme al GDPR. Piano gratuito per uso base.
* [Formcarry.com](https://formcarry.com) - Endpoint HTTP POST per moduli, piano gratuito consente 100 invii mensili.
* [formingo.co](https://www.formingo.co/)- Moduli HTML facili per siti statici. Puoi iniziare gratis senza registrare un account. Il piano gratuito consente 500 invii mensili e un indirizzo email di risposta personalizzabile.
* [FormKeep.com](https://www.formkeep.com/) - Moduli illimitati con 50 invii mensili, protezione spam, notifiche email e designer drag-and-drop che può esportare HTML. Funzionalità aggiuntive: regole personalizzate, team e integrazioni con Google Sheets, Slack, ActiveCampaign e Zapier.
* [formlets.com](https://formlets.com/) — Moduli online, moduli single-page illimitati/mese, 100 invii/mese, notifiche email.
* [formspark.io](https://formspark.io/) - Servizio Form to Email, piano gratuito consente moduli illimitati, 250 invii al mese, supporto tramite team di assistenza clienti.
* [Formspree.io](https://formspree.io/) — Invia email tramite richiesta HTTP POST. Il livello gratuito limita a 50 invii per modulo al mese.
* [Formsubmit.co](https://formsubmit.co/) — Endpoint facili per i tuoi moduli HTML. Gratis per sempre. Nessuna registrazione richiesta.
* [Formlick.com](https://formlick.com) - Alternativa a Typeform con offerta a vita. Gli utenti possono creare 1 modulo gratuito e ricevere invii illimitati. Nel premium, moduli e invii illimitati.
* [getform.io](https://getform.io/) - Piattaforma backend per moduli per designer e sviluppatori, 1 modulo, 50 invii, upload singolo file, 100MB di spazio.
* [HeroTofu.com](https://herotofu.com/) - Backend per moduli con rilevamento bot e archivio cifrato. Inoltra invii tramite UI a email, Slack o Zapier. Usa il tuo frontend. Nessun codice server necessario. Piano gratuito: moduli illimitati e 100 invii al mese.
* [HeyForm.net](https://heyform.net/) - Builder di moduli drag and drop online. Il piano gratuito consente moduli e invii illimitati. Template predefiniti, anti-spam e 100MB di spazio inclusi.
* [Tally.so](https://tally.so/) - Il 99% delle funzioni è gratuito. Con il piano free: moduli illimitati, invii illimitati, notifiche email, logica modulo, pagamenti, upload file, pagina di ringraziamento personalizzata e molto altro.
* [Hyperforms.app](https://hyperforms.app/) — Crea moduli email e altro in pochi secondi e senza backend. L’account personale offre fino a 50 invii mensili gratuiti.
* [Kwes.io](https://kwes.io/) - Endpoint per moduli ricco di funzioni. Ottimo per siti statici. Piano gratuito per 1 sito e 50 invii mensili.
* [Pageclip](https://pageclip.co/) - Il piano gratuito consente un sito, un modulo e 1.000 invii mensili.
* [Qualtrics Survey](https://qualtrics.com/free-account) — Crea moduli e sondaggi professionali con questo strumento di prima classe. 50+ template di sondaggi. Account gratuito: 1 sondaggio attivo, 100 risposte/sondaggio & 8 tipi di risposta.
* [Screeb](https://screeb.app/) - Sondaggi in-app e analytics prodotto per decodificare il comportamento utente. Piano gratuito per sempre con 500 utenti attivi mensili, risposte ed eventi illimitati, molte integrazioni, esportazione e report periodici.
* [smartforms.dev](https://smartforms.dev/) - Backend potente e facile per moduli sito, piano gratuito per sempre con 50 invii al mese, 250MB di spazio, integrazione Zapier, export CSV/JSON, redirect personalizzato, pagina risposta personalizzata, bot Telegram & Slack, singole notifiche email.
* [Survicate](https://survicate.com/) — Raccogli feedback da tutte le fonti e invia sondaggi di follow-up con uno strumento unico. Analizza il feedback e ottieni insight con l’AI. Sondaggi email, web, in-app o mobile gratis, AI survey creator, 25 risposte/mese.
* [staticforms.xyz](https://www.staticforms.xyz/) - Integra facilmente moduli HTML senza codice server gratuito. Dopo l’invio, una email con il contenuto del modulo viene inviata al tuo indirizzo registrato.
* [stepFORM.io](https://stepform.io) - Builder di quiz e moduli. Piano gratuito con cinque moduli, fino a 3 step per modulo e 50 risposte mensili.
* [Typeform.com](https://www.typeform.com/) — Includi moduli dal design accattivante nei siti web. Il piano gratuito consente solo dieci campi per modulo e 100 risposte mensili.
* [WaiverStevie.com](https://waiverstevie.com) - Piattaforma di firma elettronica con REST API. Notifiche tramite webhook. Piano gratuito con watermark sui documenti firmati ma invii e firme illimitati.
* [Web3Forms](https://web3forms.com) - Moduli di contatto per siti Static & JAMStack senza scrivere codice backend. Piano gratuito con moduli e domini illimitati & 250 invii al mese.
* [WebAsk](https://webask.io) - Generatore di sondaggi e moduli. Il piano gratuito consente tre sondaggi per account, 100 risposte mensili e dieci elementi per sondaggio.
* [Wufoo](https://www.wufoo.com/) - Moduli rapidi da utilizzare sui siti web. Il piano gratuito prevede un limite di 100 invii ogni mese.
* [formpost.app](https://formpost.app) - Servizio gratuito e illimitato di Form to Email. Imposta reindirizzamenti personalizzati, auto-risposta, webhook, ecc. gratuitamente.
* [Formester.com](https://formester.com) - Condividi e incorpora moduli dall'aspetto unico sul tuo sito web—nessun limite al numero di moduli creati o alle funzionalità disponibili nel piano. Ottieni fino a 100 invii ogni mese gratuitamente.
* [SimplePDF.eu](https://simplepdf.eu/embed) - Incorpora un editor PDF sul tuo sito web e trasforma qualsiasi PDF in un modulo compilabile. Il piano gratuito consente PDF illimitati con tre invii per PDF.
* [forms.app](https://forms.app/) — Crea moduli online con funzionalità potenti come la logica condizionale, calcolatore di punteggio automatico e AI. Raccogli fino a 100 risposte con il piano gratuito, incorpora i tuoi moduli su un sito web o usali tramite link.
* [Qualli](https://usequalli.com) - Sondaggi in-app, progettati per dispositivi mobili. Usa Qualli AI per creare domande perfette. Puoi provarlo con il piano gratuito, fino a 500 MAU, creare moduli e trigger illimitati.
* [Sprig](https://sprig.com/) - 1 sondaggio in-app o sondaggio con replay al mese, con analisi AI potenziata da GPT.
* [feedback.fish](https://feedback.fish/) - Il piano gratuito consente di raccogliere 25 invii di feedback totali. Facile da integrare con componenti React e Vue forniti.
* [Vidhook](https://vidhook.io/) - Raccogli feedback utilizzando sondaggi accattivanti con tassi di risposta elevati. Il piano gratuito include 1 sondaggio attivo, 25 risposte per sondaggio e modelli personalizzabili.

**[⬆️ Torna all'inizio](#table-of-contents)**

## Generative AI

* [Zenable](https://zenable.io) - Corregge automaticamente gli output da strumenti come Cursor, Windsurf e Copilot per soddisfare gli standard di qualità e conformità della tua azienda utilizzando guardrail costruiti con Policy as Code. Il livello gratuito include 100 chiamate agli strumenti al giorno al server MCP e 25 revisioni automatiche di pull request al giorno tramite l'app GitHub.
* [Keywords AI](https://keywordsai.co) - La migliore piattaforma di monitoraggio LLM. Un formato per chiamare oltre 200 LLM con 2 righe di codice. 10.000 richieste gratuite ogni mese e $0 per le funzionalità della piattaforma!
* [Portkey](https://portkey.ai/) - Pannello di controllo per app Gen AI con suite di osservabilità e gateway AI. Invia e registra fino a 10.000 richieste gratuitamente ogni mese.
* [Braintrust](https://www.braintrustdata.com/) - Valutazioni, area di prova dei prompt e gestione dei dati per Gen AI. Il piano gratuito offre fino a 1.000 righe di valutazione privata/settimana.
* [Findr](https://www.usefindr.com/) - Ricerca universale che consente di cercare in tutte le tue app contemporaneamente. Assistente di ricerca che risponde alle domande utilizzando le tue informazioni. Il piano gratuito offre ricerca unificata illimitata e 5 query di co-pilot giornaliere.
* [ReportGPT](https://ReportGPT.app) - Assistente di scrittura potenziato da AI. L'intera piattaforma è gratuita finché utilizzi la tua chiave API.
* [Clair](https://askclair.ai/) - Riferimento AI clinico. Gli studenti hanno accesso gratuito alla suite di strumenti professionali, che include Open Search, Clinical Summary, Med Review, Drug Interactions, codici ICD-10 e Stewardship. Inoltre, è disponibile una prova gratuita della suite professionale.
* [Langtrace](https://langtrace.ai) - consente agli sviluppatori di tracciare, valutare, gestire prompt e dataset e risolvere problemi relativi alle prestazioni di un'applicazione LLM. Crea tracce standard open telemetry per qualsiasi LLM, aiutando con l'osservabilità e funzionando con qualsiasi client di osservabilità. Il piano gratuito offre 50.000 tracce/mese.
* [LangWatch](https://langwatch.ai) - Una piattaforma LLMOps che aiuta i team AI a misurare, monitorare e ottimizzare le applicazioni LLM per affidabilità, efficienza dei costi e prestazioni. Con un potente componente DSPy, consente la collaborazione tra ingegneri e team non tecnici per perfezionare e mettere in produzione prodotti GenAI. Il piano gratuito include tutte le funzionalità della piattaforma, 1k tracce/mese e 1 ottimizzatore DSPy per workflow. [#opensource](https://github.com/langwatch/langwatch)
* [Comet Opik](https://www.comet.com/site/products/opik/) - Valuta, testa e distribuisci applicazioni LLM durante tutto il ciclo di vita di sviluppo e produzione. [#opensource](https://github.com/comet-ml/opik/)
* [Langfuse](https://langfuse.com/) - Piattaforma open-source di ingegneria LLM che aiuta i team a eseguire il debug, analizzare e iterare collaborativamente sulle loro applicazioni LLM. Il piano gratuito per sempre include 50.000 osservazioni al mese e tutte le funzionalità della piattaforma. [#opensource](https://github.com/langfuse/langfuse)
* [Pollinations.AI](https://pollinations.ai/) - AI per la generazione di immagini facile da usare e gratuita con API disponibile gratuitamente. Nessuna registrazione o chiave API richiesta, e diverse opzioni per l'integrazione in un sito web o workflow. [#opensource](https://github.com/pollinations/pollinations)
* [Othor AI](https://othor.ai/) - Alternativa AI-native veloce, semplice e sicura alle soluzioni di business intelligence come Tableau, Power BI e Looker. Othor utilizza grandi modelli linguistici (LLM) per offrire soluzioni di business intelligence personalizzate in pochi minuti. Il piano Free Forever offre uno workspace con cinque connessioni a sorgenti dati per un utente, senza limiti di analisi. [#opensource](https://github.com/othorai/othor.ai)
* [OpenRouter](https://openrouter.ai/models?q=free) - Fornisce vari modelli AI gratuiti tra cui DeepSeek R1, V3, Llama e Moonshot AI. Questi modelli eccellono nell'elaborazione del linguaggio naturale e sono adatti a diverse esigenze di sviluppo. Tieni presente che, sebbene questi modelli siano gratuiti, sono soggetti a limiti di frequenza. Inoltre, OpenRouter offre modelli a pagamento per esigenze più avanzate, come Claude, OpenAI, Grok, Gemini e Nova.

**[⬆️ Torna all'inizio](#table-of-contents)**

## CDN e Protezione

* [bootstrapcdn.com](https://www.bootstrapcdn.com/) — CDN per bootstrap, bootswatch e fontawesome.io
* [cdnjs.com](https://cdnjs.com/) — Semplice. Veloce. Affidabile. Content delivery ai massimi livelli. cdnjs è un servizio CDN gratuito e open-source utilizzato da oltre l'11% di tutti i siti web, alimentato da Cloudflare.
* [developers.google.com](https://developers.google.com/speed/libraries/) — Google Hosted Libraries è una rete di distribuzione di contenuti per le più popolari librerie JavaScript open source
* [Stellate](https://stellate.co/) - Stellate è un CDN affidabile e velocissimo per la tua API GraphQL e gratuito per due servizi.
* [jsdelivr.com](https://www.jsdelivr.com/) — CDN open-source gratuito, veloce e affidabile. Supporta npm, GitHub, WordPress, Deno e altro.
* [Microsoft Ajax](https://docs.microsoft.com/en-us/aspnet/ajax/cdn/overview) — Il CDN Microsoft Ajax ospita librerie JavaScript di terze parti popolari come jQuery e consente di aggiungerle facilmente alla tua applicazione web
* [ovh.ie](https://www.ovh.ie/ssl-gateway/) — Protezione DDoS gratuita e certificato SSL
* [Skypack](https://www.skypack.dev/) — Il CDN JavaScript 100% Native ES Module. Gratuito per 1 milione di richieste per dominio al mese.
* [raw.githack.com](https://raw.githack.com/) — Un'alternativa moderna a **rawgit.com** che ospita semplicemente file utilizzando Cloudflare
* [section.io](https://www.section.io/) — Un modo semplice per attivare e gestire una soluzione completa di Varnish Cache. Presumibilmente gratuito per sempre per un sito
* [statically.io](https://statically.io/) — CDN per repository Git (GitHub, GitLab, Bitbucket), asset WordPress e immagini
* [toranproxy.com](https://toranproxy.com/) — Proxy per Packagist e GitHub. Mai più CD falliti. Gratuito per uso personale, un solo sviluppatore, nessun supporto
* [UNPKG](https://unpkg.com/) — CDN per tutto ciò che si trova su npm
* [weserv](https://images.weserv.nl/) — Servizio di cache e ridimensionamento immagini. Manipola immagini al volo con una cache mondiale.
* [Namecheap Supersonic](https://www.namecheap.com/supersonic-cdn/#free-plan) — Protezione DDoS gratuita
* [Gcore](https://gcorelabs.com/) Rete globale di distribuzione contenuti, 1 TB e 1 milione di richieste al mese gratis e hosting DNS gratuito
* [CacheFly](https://portal.cachefly.com/signup/free2023) - Fino a 5 TB al mese di traffico CDN gratuito, 19 Core PoPs, 1 dominio e SSL universale.

**[⬆️ Torna all'inizio](#table-of-contents)**

## PaaS

* [anvil.works](https://anvil.works) - Sviluppo di app web solo con Python. Tier gratuito con app illimitate e timeout di 30 secondi.
* [appwrite](https://appwrite.io) - Progetti illimitati senza sospensione dei progetti (supporta websocket) e servizio di autenticazione. 1 Database, 3 Bucket, 5 Funzioni per progetto nel tier gratuito.
* [configure.it](https://www.configure.it/) — Piattaforma di sviluppo app mobile, gratuita per due progetti, funzionalità limitate ma senza limiti di risorse
* [codenameone.com](https://www.codenameone.com/) — Toolchain open source, cross-platform, per lo sviluppo mobile per Java/Kotlin developer. Gratuito per uso commerciale con numero illimitato di progetti
* [deco.cx](https://www.deco.cx/en/dev) - Piattaforma frontend edge-native con CMS visuale auto-generato dal codice TypeScript. Test A/B integrati, segmentazione contenuti e analytics in tempo reale. Perfetta per siti di e-commerce Enterprise e ad alto contenuto. Gratuito fino a 5k visualizzazioni di pagina/mese o per progetti open-source/personali.
* [Deno Deploy](https://deno.com/deploy) - Sistema distribuito che esegue JavaScript, TypeScript e WebAssembly all'edge a livello globale. Il tier gratuito include 100.000 richieste al giorno e 100 GiB di trasferimenti dati al mese.
* [domcloud.co](https://domcloud.co) – Servizio di hosting Linux che offre CI/CD con GitHub, SSH e database MariaDB/Postgres. La versione gratuita ha 1 GB di storage, 1 GB di traffico/mese e un dominio gratuito.
* [encore.dev](https://encore.dev/) — Framework backend che usa analisi statica per fornire infrastruttura automatica, codice senza boilerplate e altro. Include cloud hosting gratuito per progetti hobbistici.
* [flightcontrol.dev](https://flightcontrol.dev/) - Distribuisci servizi web, database e altro sul tuo account AWS con un workflow stile Git push. Tier gratuito per utenti con 1 sviluppatore su repo GitHub personali. I costi AWS sono fatturati tramite AWS, ma puoi usare crediti e il free tier AWS.
* [gigalixir.com](https://gigalixir.com/) - Gigalixir offre una istanza gratuita che non va mai in sleep e un database PostgreSQL free-tier limitato a 2 connessioni, 10.000 righe e nessun backup per app Elixir/Phoenix.
* [Glitch](https://glitch.com/) — Hosting pubblico gratuito con condivisione del codice e collaborazione in tempo reale. Il piano gratuito ha un limite di 1000 ore/mese.
* [leapcell](https://leapcell.io/) - Leapcell è una piattaforma affidabile per applicazioni distribuite, fornendo tutto il necessario per supportare la crescita rapida. Il piano gratuito include 100k invocazioni di servizio, 10k task async e 100k comandi Redis.
* [pipedream.com](https://pipedream.com) - Piattaforma di integrazione per sviluppatori. Sviluppa qualsiasi workflow basato su trigger. I workflow sono codice eseguibile [gratuitamente](https://docs.pipedream.com/pricing/). Nessuna risorsa server o cloud da gestire.
* [pythonanywhere.com](https://www.pythonanywhere.com/) — Hosting cloud per app Python. Account per principianti gratuito, 1 app web Python su dominio your-username.pythonanywhere.com, 512 MB di storage privato, un database MySQL
* [ampt.dev](https://getampt.com/) - Ampt consente ai team di costruire, distribuire e scalare app JavaScript su AWS senza configurazioni complicate o gestione dell'infrastruttura. Piano Preview gratuito include 500 invocazioni orarie, 2.500 giornaliere e 50.000 mensili. I domini personalizzati sono disponibili solo nei piani a pagamento.
* [Koyeb](https://www.koyeb.com) - Koyeb è una piattaforma serverless per sviluppatori per distribuire app a livello globale. Esegui container Docker, web app e API con deploy via git, autoscaling nativo, edge network globale, service mesh e discovery integrati. L'istanza gratuita permette di distribuire un servizio web a Francoforte (Germania) o Washington, D.C. (USA). Database Postgres gestito gratuito disponibile a Francoforte, Washington, D.C. e Singapore. 512MB di memoria, 2GB di storage e 0.1 CPU.
* [Napkin](https://www.napkin.io/) - FaaS con 500Mb di memoria, timeout di default di 15 secondi, e 5.000 chiamate API gratuite/mese limitate a 5 chiamate/secondo.
* [Meteor Cloud](https://www.meteor.com/cloud) — Galaxy hosting. La piattaforma PaaS di Meteor per app Meteor include hosting MongoDB condiviso gratuito e SSL automatico.
* [Northflank](https://northflank.com) — Costruisci e distribuisci microservizi, job e database gestiti con una UI potente, API e CLI. Scala i container dai repository di versione e da registry Docker esterni. Il tier gratuito include due servizi, due cron job e 1 database.
* [YepCode](https://yepcode.io) - Piattaforma all-in-one per collegare API e servizi in un ambiente serverless. Unisce l'agilità degli strumenti NoCode con la potenza dei linguaggi di programmazione. Il piano gratuito include [1.000 yeps](https://yepcode.io/pricing/).
* [WunderGraph](https://cloud.wundergraph.com) - Piattaforma open-source per costruire, distribuire e gestire API moderne. CI/CD integrato, integrazione GitHub e HTTPS automatico. Fino a 3 progetti, 1GB di traffico in uscita, 300 minuti di build mensili nel [piano gratuito](https://wundergraph.com/pricing)
* [Zeabur](https://zeabur.com) - Distribuisci i tuoi servizi con un clic. Gratuito per tre servizi, con 5 dollari di crediti gratuiti al mese.
* [mogenius](https://mogenius.com) - Costruisci, distribuisci ed esegui servizi su Kubernetes facilmente. Il tier gratuito supporta la connessione di un cluster Kubernetes locale con mogenius, consentendo agli sviluppatori di creare un ambiente di test simile a quello di produzione sulla propria macchina.
* [genezio](https://genezio.com/) - Provider serverless di funzioni che offre 1 milione di chiamate funzione, 100GB di banda e 10 cron job al mese gratuitamente, esclusivamente per uso non commerciale o accademico.

**[⬆️ Torna all'inizio](#table-of-contents)**

## BaaS

* [Activepieces](https://www.activepieces.com) - Crea flussi di automazione per collegare diverse app insieme nel backend della tua app. Ad esempio, invia un messaggio Slack o aggiungi una riga su Google Sheet quando si verifica un evento nella tua app. Gratuito fino a 5.000 task al mese.
* [back4app.com](https://www.back4app.com) - Back4App è un backend facile da usare, flessibile e scalabile basato su Parse Platform.
* [backendless.com](https://backendless.com/) — BaaS mobile e web, con 1 GB di storage file gratuito, notifiche push fino a 50.000/mese e 1000 oggetti dati in tabella.
* [bismuth.cloud](https://www.bismuth.cloud/) — La nostra AI avvierà la tua API Python sul nostro runtime di funzioni e storage ospitato, costruisci e ospita gratuitamente nel nostro editor online o localmente con i tuoi strumenti preferiti.
* [BMC Developer Program](https://developers.bmc.com/site/global/bmc_helix_platform/program/overview/index.gsp) — Il Programma Sviluppatori BMC fornisce documentazione e risorse per costruire e distribuire innovazioni digitali per la tua azienda. Accesso a una sandbox personale e completa che include la piattaforma, SDK e una libreria di componenti utilizzabili per costruire e personalizzare app.
* [connectycube.com](https://connectycube.com) - Messaggi chat illimitati, chiamate p2p voce/video, allegati file e push notification. Gratuito per app fino a 1000 utenti.
* [convex.dev](https://convex.dev/) - Backend reattivo come servizio, ospita i tuoi dati (documenti con relazioni e transazioni ACID serializzabili), funzioni serverless e WebSocket per aggiornamenti live ai client. Gratuito per piccoli progetti - fino a 1M record, 5M chiamate funzione mensili.
* [darklang.com](https://darklang.com/) - Linguaggio ospitato combinato con editor e infrastruttura. Accessibile durante la beta, è previsto un generoso piano gratuito dopo la beta.
* [Firebase](https://firebase.com) — Firebase ti aiuta a costruire ed eseguire app di successo. Il piano gratuito Spark offre autenticazione, hosting, Firebase ML, Realtime Database, Cloud Storage, Testlab. A/B Testing, Analytics, App Distribution, App Indexing, Cloud Messaging (FCM), Crashlytics, Dynamic Links, In-App Messaging, Performance Monitoring, Predictions e Remote Config sono sempre gratuiti.
* [Flutter Flow](https://flutterflow.io) — Crea UI di app Flutter senza scrivere una sola riga di codice. Include anche integrazione con Firebase. Il piano gratuito include pieno accesso al Builder UI e template gratuiti.
* [getstream.io](https://getstream.io/) — Crea Chat In-App scalabili, messaggistica, video e audio e feed in poche ore invece che settimane
* [hasura.io](https://hasura.io/) — Hasura estende i tuoi database esistenti ovunque siano ospitati e fornisce una API GraphQL istantanea accessibile in modo sicuro per web, mobile e integrazione dati. Gratuito per 1GB/mese di traffico dati.
* [nhost.io](https://nhost.io) - Backend serverless per app web e mobile. Il piano gratuito include PostgreSQL, GraphQL (Hasura), autenticazione, storage e funzioni serverless.
* [onesignal.com](https://onesignal.com/) — Notifiche push illimitate gratuite. 10.000 invii email al mese, con contatti illimitati e accesso ad Auto Warm Up.
* [paraio.com](https://paraio.com) — Backend service API con autenticazione flessibile, ricerca full-text e cache. Gratuito per una app, 1GB di dati app.
* [pubnub.com](https://www.pubnub.com/) — Notifiche push gratuite fino a 1 milione di messaggi/mese e 100 dispositivi attivi giornalieri
* [pushbots.com](https://pushbots.com/) — Servizio di notifiche push. Gratuito fino a 1,5 milioni di push/mese
* [pushcrew.com](https://pushcrew.com/) — Servizio di notifiche push. Notifiche illimitate fino a 2.000 iscritti
* [pusher.com](https://pusher.com/beams) — Notifiche push gratuite e illimitate per 2000 utenti attivi mensili. Un'unica API per dispositivi iOS e Android.
* [quickblox.com](https://quickblox.com/) — Backend di comunicazione per messaggistica istantanea, video e chiamate vocali e notifiche push
* [restspace.io](https://restspace.io/) - Configura un server con servizi per autenticazione, dati, file, API email, template e altro, poi componili in pipeline e trasforma i dati.
* [Salesforce Developer Program](https://developer.salesforce.com/signup) — Crea app Lightning velocemente con strumenti drag-and-drop. Personalizza il modello dati con clic. Vai oltre con il codice Apex. Integra con qualsiasi cosa usando potenti API. Rimani protetto con sicurezza di livello enterprise. Personalizza l'interfaccia utente con clic o con qualsiasi framework web d'avanguardia. Il Programma Sviluppatori Gratuito dà accesso all'intera Lightning Platform.
* [simperium.com](https://simperium.com/) — Sposta dati ovunque istantaneamente e automaticamente, multipiattaforma, invio e archiviazione illimitati di dati strutturati, massimo 2.500 utenti/mese
* [Supabase](https://supabase.com) — L'alternativa open source a Firebase per costruire backend. Il Piano Gratuito offre Autenticazione, Database Realtime e Object Storage.
* [tyk.io](https://tyk.io/) — Gestione API con autenticazione, quote, monitoraggio e analytics. Offerta cloud gratuita
* [zapier.com](https://zapier.com/) — Collega le app che usi per automatizzare le attività. Cinque zaps ogni 15 minuti e 100 task/mese
* [IFTTT](https://ifttt.com) — Automatizza le tue app e dispositivi preferiti. 2 Applet gratuite
* [Integrately](https://integrately.com) — Automatizza compiti noiosi con un solo clic. 100 task gratuiti, 15 minuti
tempo di aggiornamento, cinque automazioni attive, webhook.
* [LeanCloud](https://leancloud.app/) — Backend mobile. 1GB di storage dati, 256MB di istanza, 3K richieste API/giorno, e 10K push/giorno gratis. (API molto simile a Parse Platform)
* [Claw.cloud](https://run.claw.cloud) - Piattaforma PaaS che offre $5/mese in crediti gratuiti per utenti con un account GitHub più vecchio di 180 giorni. Perfetta per hosting di app, database e altro. ([Link di iscrizione con credito gratuito](https://ap-southeast-1.run.claw.cloud/signin)).


**[⬆️ Torna all'inizio](#table-of-contents)**

## Piattaforme Low-code

* [appsmith](https://www.appsmith.com/) — Progetto low-code per costruire pannelli amministrativi, strumenti interni e dashboard. Si integra con oltre 15 database e qualsiasi API.
* [Basedash](https://www.basedash.com) — Piattaforma low-code per costruire pannelli amministrativi e dashboard interni. Supporta database SQL e API REST.
* [BudiBase](https://budibase.com/) — Budibase è una piattaforma open-source low-code per creare app interne in pochi minuti. Supporta PostgreSQL, MySQL, MSSQL, MongoDB, Rest API, Docker, K8s
* [Clappia](https://www.clappia.com) — Piattaforma low-code progettata per costruire applicazioni di processo aziendale con app mobile e web personalizzabili. Offre interfaccia drag-and-drop, funzioni come supporto offline, tracciamento posizione in tempo reale e integrazione con vari servizi di terze parti
* [DronaHQ](https://www.dronahq.com/) — DronaHQ - piattaforma low-code che aiuta i team di ingegneri e i product manager a costruire strumenti interni, flussi utente personalizzati, esperienze digitali, automazioni, pannelli amministrativi, app operative 10 volte più velocemente.
* [lil'bots](https://www.lilbots.io/) - scrivi ed esegui script online utilizzando API integrate gratuite come OpenAI, Anthropic, Firecrawl e altre. Ottimo per costruire agenti AI / strumenti interni e condivisione con il team. Il piano gratuito include accesso completo alle API, assistente di codifica AI e 10.000 crediti di esecuzione/mese.
* [Mendix](https://www.mendix.com/) — Sviluppo rapido di applicazioni per aziende, sandbox illimitati per utenti totali, 0,5 GB di storage e 1 GB di RAM per app. Anche Studio e Studio Pro IDE inclusi nel piano gratuito.
* [outsystems.com](https://www.outsystems.com/) — PaaS di sviluppo web enterprise per on-premise o cloud, l'offerta "ambiente personale" gratuita consente codice illimitato e fino a 1 GB di database
* [ReTool](https://retool.com/) — Piattaforma low-code per costruire applicazioni interne. Retool è altamente personalizzabile. Se puoi scriverlo in JavaScript e un'API, puoi farlo in Retool. Il piano gratuito consente fino a cinque utenti al mese, app e connessioni API illimitate.
* [Superblocks](https://superblocks.com/) — Piattaforma applicativa enterprise open pensata per sviluppatori e team semi-tecnici. Usa AI per generare, modificare visivamente ed estendere con codice. Gestione centralizzata di integrazioni, autenticazione, permessi e audit log.
* [ToolJet](https://www.tooljet.com/) — Framework low-code estensibile per costruire applicazioni business. Connetti a database, storage cloud, endpoint GraphQL, API, Airtable, ecc. e costruisci app con builder drag-and-drop.
* [UI Bakery](https://uibakery.io) — Piattaforma low-code per costruire più velocemente applicazioni web personalizzate. Permette di costruire UI con drag-and-drop e alto livello di personalizzazione tramite JavaScript, Python e SQL. Disponibile sia in cloud che self-hosted. Gratuito fino a 5 utenti.
* [manubes](https://www.manubes.com) - Potente piattaforma cloud no-code focalizzata sulla gestione della produzione industriale. Gratuita per un utente con 1 milione di attività workflow al mese ([disponibile anche in tedesco](https://www.manubes.de)).

**[⬆️ Torna all'inizio](#table-of-contents)**

## Web Hosting

* [Alwaysdata](https://www.alwaysdata.com/) — 100 MB di hosting web gratuito con supporto per MySQL, PostgreSQL, CouchDB, MongoDB, PHP, Python, Ruby, Node.js, Elixir, Java, Deno, web server personalizzati, accesso tramite FTP, WebDAV e SSH; casella email, mailing list e installer app inclusi.
* [Awardspace.com](https://www.awardspace.com) — Hosting web gratuito + dominio breve gratuito, PHP, MySQL, Installatore App, Invio Email & Nessuna pubblicità.
* [Bohr](https://bohr.io) — Gratuito per progetti non commerciali + Piattaforma di Deployment e Sviluppo Developer-First che riduce al minimo la gestione dell'infrastruttura e accelera la configurazione.
* [Bubble](https://bubble.io/) — Programmazione visuale per costruire app web e mobile senza codice, gratis con branding Bubble.
* [dAppling Network](https://www.dappling.network/) - Piattaforma di hosting web decentralizzata per frontend Web3 focalizzata su uptime, sicurezza e fornitura di un punto di accesso aggiuntivo per gli utenti.
* [DigitalOcean](https://www.digitalocean.com/pricing) - Crea e distribuisci tre siti statici gratuitamente su App Platform Starter.
* [Drive To Web](https://drv.tw) — Host direttamente sul web da Google Drive & OneDrive. Solo siti statici. Gratuito per sempre. Un sito per account Google/Microsoft.
* [Fenix Web Server](https://preview.fenixwebserver.com) - App desktop per sviluppatori per hostare siti localmente e condividerli pubblicamente (in tempo reale). Lavora come preferisci, tramite interfaccia grafica, API e/o CLI.
* [Fern](https://buildwithfern.com) - Crea e ospita un sito di documentazione basato su Markdown con il piano gratuito di Fern. Puoi anche generare automaticamente una reference API per il tuo sito da file di definizione API. Il sito è ospitato su _yoursite_.docs.buildwithfern.com.
* [Free Hosting](https://freehostingnoads.net/) — Hosting gratuito con PHP 5, Perl, CGI, MySQL, FTP, File Manager, Email POP, sottodomini gratuiti, hosting dominio gratuito, Editor DNS Zone, Statistiche Sito Web, Supporto Online GRATUITO e molte altre funzionalità non offerte da altri host gratuiti.
* [Freehostia](https://www.freehostia.com) — FreeHostia offre servizi di hosting gratuito incl. pannello di controllo leader di settore & installazione 1-click di oltre 50 app gratuite. Configurazione istantanea. Nessuna pubblicità forzata.
* [HelioHost](https://heliohost.org) — Hosting web gratuito no-profit con pannello Plesk, PHP, Node.js, Python, Django, Flask, .NET, Perl, CGI, MySQL, PostgreSQL, SQLite, email IMAP/POP3/SMTP, banda illimitata, sottodomini gratuiti, 1000 MB di storage gratis con opzione di upgrade.
* [Kinsta Static Site Hosting](https://kinsta.com/static-site-hosting/) — Distribuisci fino a 100 siti statici gratuitamente, domini personalizzati con SSL, 100 GB di banda mensile, 260+ location CDN Cloudflare.
* [Lecturify](https://www.lecturify.net/index.en.html) - Hosting web con accesso SFPT per upload e download file, php disponibile.
* [Neocities](https://neocities.org) — Statico, 1 GB di storage gratuito con 200 GB di banda.
* [Netlify](https://www.netlify.com/) — Build, deploy e hosting di siti/app statici gratis per 100 GB di dati e 100 GB/mese di banda.
* [pantheon.io](https://pantheon.io/) — Hosting Drupal e WordPress, DevOps automatizzato e infrastruttura scalabile. Gratis per sviluppatori e agenzie. Nessun dominio personalizzato.
* [readthedocs.org](https://readthedocs.org/) — Hosting gratuito di documentazione con versioning, generazione PDF e altro
* [render.com](https://render.com) — Cloud unificato per costruire ed eseguire app e siti con SSL gratuito, CDN globale, reti private, auto-deploy da Git e piani completamente gratuiti per web service, database e pagine web statiche.
* [SourceForge](https://sourceforge.net/) — Trova, crea e pubblica software open source gratuitamente
* [surge.sh](https://surge.sh/) — Pubblicazione web statica per sviluppatori Front-End. Siti illimitati con supporto dominio personalizzato
* [telegra.ph](https://telegra.ph/) Crea facilmente una pagina web usando Quill
* [tilda.cc](https://tilda.cc/) — Un sito, 50 pagine, 50 MB di storage, solo i blocchi principali predefiniti tra oltre 170 disponibili, nessun font, nessuna favicon e nessun dominio personalizzato
* [Vercel](https://vercel.com/) — Crea, distribuisci e ospita app web con SSL gratuito, CDN globale e Preview URL unici ogni volta che fai `git push`. Perfetto per Next.js e altri Static Site Generators.
* [Versoly](https://versoly.com/) — Website builder orientato SaaS - siti illimitati, oltre 70 blocchi, cinque template, CSS personalizzato, favicon, SEO e form. Nessun dominio personalizzato.
* [Qoddi](https://qoddi.com) - Servizio PaaS simile a Heroku con approccio developer-centrico e funzionalità all-inclusive. Piano gratuito per asset statici, staging e app di sviluppo.
* [FreeFlarum](https://freeflarum.com/) - Hosting gratuito per Flarum gestito dalla community fino a 250 utenti (dona per rimuovere il watermark dal footer).
* [MDB GO](https://mdbgo.com/) - Hosting gratuito per un progetto con TTL del container di due settimane, 500 MB di RAM per progetto, SFTP - 1G di spazio disco.
* [Patr Cloud](https://patr.cloud/) — Piattaforma cloud facile da usare, tra i servizi a pagamento offre l'hosting di tre siti statici gratuitamente.
* [Serv00.com](https://serv00.com/) — 3 GB di web hosting gratuito con backup giornalieri (7 giorni). Supporta: lavori Crontab, accesso SSH, repository (GIT, SVN e Mercurial), supporto: MySQL, PostgreSQL, MongoDB, PHP, Node.js, Python, Ruby, Java, Perl, TCL/TK, Lua, Erlang, Rust, Pascal, C, C++, D, R, e molti altri.
- [Sevalla](https://sevalla.com/) - Piattaforma di hosting progettata per semplificare il deployment e la gestione di applicazioni, database e siti statici - limite sito di 1GB, 100GB di banda gratuita, 600 minuti di build gratuiti, 100 siti per account.

**[⬆️ Torna all'inizio](#table-of-contents)**

## DNS

* [1.1.1.1](https://developers.cloudflare.com/1.1.1.1/) - Resolver DNS pubblico gratuito, veloce e sicuro (crittografa la query DNS), fornito da Cloudflare. Utile per bypassare il blocco DNS del provider, prevenire lo spionaggio delle query DNS e [bloccare contenuti per adulti & malware](https://developers.cloudflare.com/1.1.1.1/1.1.1.1-for-families). Usabile anche [via API](https://developers.cloudflare.com/1.1.1.1/encrypted-dns/dns-over-https/make-api-requests). Nota: solo resolver DNS, non hosting DNS.
* [1984.is](https://www.1984.is/product/freedns/) — Servizio DNS gratuito con API e molte altre funzionalità DNS gratuite incluse.
* [cloudns.net](https://www.cloudns.net/) — DNS hosting gratuito fino a 1 dominio con 50 record
* [deSEC](https://desec.io) - Hosting DNS gratuito con supporto API, progettato con la sicurezza in mente. Basato su software open-source e supportato da [SSE](https://www.securesystems.de/).
* [dns.he.net](https://dns.he.net/) — Servizio di hosting DNS gratuito con supporto Dynamic DNS
* [Zonomi](https://zonomi.com/) — Servizio di hosting DNS gratuito con propagazione DNS istantanea. Piano gratuito: 1 zona DNS (nome dominio) con fino a 10 record DNS.
* [dnspod.com](https://www.dnspod.com/) — Hosting DNS gratuito.
* [duckdns.org](https://www.duckdns.org/) — DDNS gratuito con fino a 5 domini nel piano gratuito. Guide di configurazione per vari setup.
* [Dynv6.com](https://dynv6.com/) — Servizio DDNS gratuito con [supporto API](https://dynv6.com/docs/apis) e gestione di molti tipi di record dns (come CNAME, MX, SPF, SRV, TXT e altri).
* [freedns.afraid.org](https://freedns.afraid.org/) — Hosting DNS gratuito. Offre anche sottodomini gratuiti basati su numerosi domini pubblici [contributi utenti](https://freedns.afraid.org/domain/registry/). Ottieni sottodomini gratuiti dal menu "Subdomains" dopo la registrazione.
* [luadns.com](https://www.luadns.com/) — Hosting DNS gratuito, tre domini, tutte le funzionalità con limiti ragionevoli
* [namecheap.com](https://www.namecheap.com/domains/freedns/) — DNS gratuito. Nessun limite al numero di domini
* [nextdns.io](https://nextdns.io) - Firewall DNS, 300K query gratuite al mese
* [noip.at](https://noip.at/) — Servizio DDNS gratuito senza registrazione, tracking, logging o pubblicità. Nessun limite di domini.
* [noip](https://www.noip.com/) — Servizio DNS dinamico che permette fino a 3 hostname gratuiti con conferma ogni 30 giorni
* [sslip.io](https://sslip.io/) — Servizio DNS gratuito che, se interrogato con un hostname con indirizzo IP incorporato, restituisce quell'indirizzo IP.
* [zilore.com](https://zilore.com/en/dns) — Hosting DNS gratuito per 5 domini.
* [zoneedit.com](https://www.zoneedit.com/free-dns/) — Hosting DNS gratuito con supporto Dynamic DNS.
* [zonewatcher.com](https://zonewatcher.com) — Backup automatici e monitoraggio delle modifiche DNS. Un dominio gratuito
* [huaweicloud.com](https://www.huaweicloud.com/intl/en-us/product/dns.html) – Hosting DNS gratuito di Huawei
* [Hetzner](https://www.hetzner.com/dns-console) – Hosting DNS gratuito da Hetzner con supporto API.
* [Glauca](https://docs.glauca.digital/hexdns/) – Hosting DNS gratuito per fino a 3 domini e supporto DNSSEC
* [VolaryDDNS](https://volaryddns.net) - DDNS gratuito ad alte prestazioni senza abbonamenti né pubblicità
**[⬆️ Torna all'inizio](#table-of-contents)**

## Dominio

  * [pp.ua](https://nic.ua/) — Sottodomini pp.ua gratuiti.
  * [us.kg](https://nic.us.kg/) - Sottodomini us.kg gratuiti.

**[⬆️ Torna all'inizio](#table-of-contents)**

## IaaS

  * [4EVERLAND](https://www.4everland.org/) — Compatibile con AWS S3 - API, operazioni tramite interfaccia, CLI e altri metodi di upload, carica e archivia file dalle reti IPFS e Arweave in modo sicuro, conveniente ed efficiente. Gli utenti registrati possono ottenere 6 GB di storage IPFS e 300MB di storage Arweave gratuitamente. Qualsiasi upload di file Arweave inferiore a 150 KB è gratuito.
  * [backblaze.com](https://www.backblaze.com/b2/) — Backblaze B2 cloud storage. 10 GB di storage oggetti (simile ad Amazon S3) gratuito per tempo illimitato.
  * [filebase.com](https://filebase.com/) - Storage oggetti compatibile S3 alimentato da Blockchain. 5 GB di storage gratuito per durata illimitata.
  * [Tebi](https://tebi.io/) - Storage oggetti compatibile S3. 25 GB di storage gratuito e 250GB di trasferimento in uscita.
  * [Idrive e2](https://www.idrive.com/e2/) - Storage oggetti compatibile S3. 10 GB di storage gratuito e 10 GB di banda di download al mese.
  * [C2 Object Storage](https://c2.synology.com/en-us/pricing/object-storage) - Storage oggetti compatibile S3. 15 GB di storage gratuito e 15 GB di download al mese.

**[⬆️ Torna all'inizio](#table-of-contents)**

## Servizi Gestiti di Dati

  * [Aiven](https://aiven.io/) - Aiven offre piani gratuiti PostgreSQL, MySQL e Redis sulla sua piattaforma dati open-source. Nodo singolo, 1 CPU, 1GB RAM, e per PostgreSQL e MySQL, 5GB di storage. Migrazione facile a piani più estesi o tra cloud.
  * [airtable.com](https://airtable.com/) — Sembra un foglio di calcolo, ma è un database relazionale con basi illimitate, 1.200 righe per base e 1.000 richieste API/mese
  * [Astra](https://www.datastax.com/products/datastax-astra/) — Cassandra Cloud Native as a Service con [80GB livello gratuito](https://www.datastax.com/products/datastax-astra/pricing)
  * [codehooks.io](https://codehooks.io/) — Servizio API/serverless backend JavaScript facile da usare e database NoSQL con funzioni, query tipo Mongdb, ricerca key/value, sistema di job, messaggi in tempo reale, code di lavoro, una CLI potente e un gestore dati web. Il piano gratuito offre 5GB di storage e 60 chiamate API al minuto. Inclusi 2 sviluppatori. Non è richiesta la carta di credito.
  * [CrateDB](https://crate.io/) - Database SQL Open Source distribuito per analytics in tempo reale. [Free Tier CRFREE](https://crate.io/lp-crfree): Nodo singolo con 2 CPU, 2 GiB di memoria, 8 GiB di storage. Un cluster per organizzazione, nessun metodo di pagamento richiesto.
  * [Upstash](https://upstash.com/) — Redis serverless con livello gratuito fino a 10.000 richieste al giorno, 256MB di dimensione massima del database e 20 connessioni concorrenti
  * [Couchbase Capella](https://www.couchbase.com/products/capella/) - distribuisci un cluster database completamente gestito sempre gratuito progettato per sviluppatori per creare la prossima generazione di applicazioni dall'IoT all'AI
  * [MongoDB Atlas](https://www.mongodb.com/cloud/atlas) — livello gratuito offre 512 MB
  * [redsmin.com](https://www.redsmin.com/) — Servizio di monitoraggio in tempo reale e amministrazione online per Redis, monitoraggio gratuito per 1 istanza Redis
  * [redislabs](https://redislabs.com/try-free/) - Istanza redis gratuita da 30MB
  * [MemCachier](https://www.memcachier.com/) — Servizio Memcache gestito. Gratuito fino a 25MB, 1 Proxy Server e analisi di base
  * [scalingo.com](https://scalingo.com/) — Principalmente un PaaS ma offre un livello gratuito da 128MB a 192MB di MySQL, PostgreSQL o MongoDB
  * [SeaTable](https://seatable.io/) — Database flessibile, simile a un foglio di calcolo sviluppato dal team Seafile. tabelle illimitate, 2.000 righe, versionamento di 1 mese, fino a 25 membri del team.
  * [skyvia.com](https://skyvia.com/) — Cloud Data Platform offre un livello gratuito e tutti i piani sono completamente gratuiti durante la fase beta
  * [StackBy](https://stackby.com/) — Uno strumento che combina la flessibilità dei fogli di calcolo, la potenza dei database e integrazioni integrate con le app aziendali preferite. Il piano gratuito include utenti illimitati, dieci stack e un allegato da 2GB per stack.
  * [TiDB Cloud](https://en.pingcap.com/tidb-cloud/) — TiDB è un RDBMS HTAP distribuito open-source compatibile MySQL. TiDB Serverless offre 5GB di storage row, 5GB di storage column, e 50 milioni di Request Units (RUs) gratis ogni mese.
  * [Turso by ChiselStrike](https://chiselstrike.com/) - Turso offre la Developer Experience di SQLite in un Database Edge. Turso fornisce un piano Free Forever, 9 GB di storage totale, fino a 500 database, fino a 3 posizioni, 1 miliardo di letture di righe al mese e supporto per lo sviluppo locale con SQLite.
  * [InfluxDB](https://www.influxdata.com/) — Database per serie temporali, gratuito fino a 3MB/5 minuti in scrittura, 30MB/5 minuti in lettura e 10.000 serie di cardinalità
  * [restdb.io](https://restdb.io/) - un servizio database cloud NoSQL veloce e semplice. Con restdb.io hai schema, relazioni, API REST automatica (con query simili a MongoDB) e una UI admin multiutente efficiente per lavorare con i dati. Il piano gratuito permette 3 utenti, 2500 record e 1 richiesta API al secondo.
  * [CockroachDB Cloud](https://www.cockroachlabs.com/pricing/) — Il livello gratuito offre 50 milioni di RUs e 10 GiB di storage (pari a 15$) gratuiti al mese. ([Cosa sono le Request Units](https://www.cockroachlabs.com/docs/cockroachcloud/metrics-request-units.html))
  * [Neo4j Aura](https://neo4j.com/cloud/aura/) — Database nativo a grafo gestito / piattaforma analytics con linguaggio di query Cypher e REST API. Limiti su dimensione grafo (50k nodi, 175k relazioni).
  * [Neon](https://neon.tech/) — PostgreSQL gestito, 0.5 GB di storage (totale), 1 Progetto, 10 branch, Database illimitati, branch primario sempre disponibile (autosospensione dopo 5 minuti), 20 ore di tempo attivo al mese (totale) per il branch non primario.
  * [Prisma Postgres](https://prisma.io/postgres) - Postgres hosted ultra veloce basato su unikernel e bare metal, 1GB di storage, 10 database, integrato con Prisma ORM.
  * [Dgraph Cloud](https://cloud.dgraph.io/pricing?type=free) — Database nativo a grafo gestito con API GraphQL. Limitato a 1 MB di trasferimento dati al giorno.
  * [Tinybird](https://tinybird.co) - ClickHouse gestito serverless con ingestion dati senza connessione tramite HTTP e consente di pubblicare query SQL come API HTTP gestite. Nessun limite di tempo sul livello gratuito, 10GB di storage + 1000 richieste API al giorno.
  * [TigerGraph Cloud](https://www.tigergraph.com/cloud/) — Database nativo a grafo gestito / piattaforma analytics con linguaggio query a grafo simile a SQL e REST API. Un'istanza gratuita con due vCPU, 8GB di memoria e 50GB di storage che va in sospensione dopo 1 ora di inattività.
  * [TerminusCMS](https://terminusdb.com/pricing) — Servizio gestito gratuito per TerminusDB, database a documenti e grafo scritto in Prolog e Rust. Gratuito per sviluppatori, servizio a pagamento per enterprise e supporto.
  * [filess.io](https://filess.io) - filess.io è una piattaforma dove puoi creare due database fino a 10 MB per database dei seguenti DBMS gratuitamente: MySQL, MariaDB, MongoDB e PostgreSQL.
  * [xata.io](https://xata.io) - Xata è un database serverless con ricerca e analytics potenti integrate. Una API, molteplici librerie client type-safe, ottimizzato per il tuo workflow di sviluppo. Il piano gratuito è sufficiente per sviluppatori hobby e include tre unità di Xata, fare riferimento al sito web per la definizione di unità.
  * [8base.com](https://www.8base.com/) - 8base è una piattaforma di sviluppo low-code full-stack costruita per sviluppatori JavaScript su MySQL e GraphQL e backend serverless as-a-service. Ti permette di iniziare a costruire app web velocemente tramite un builder UI e scalare rapidamente. Il piano gratuito include: righe: 2.500, storage: 500, computing serverless: 1Gb/h, utenti app client: 5.
  * [Nile](https://www.thenile.dev/) — Una piattaforma Postgres per app B2B. Database illimitati, sempre disponibile senza spegnimento, 1GB di storage (totale), 50 milioni di query token, autoscaling, embedding vettoriali illimitate



**[⬆️ Torna all'inizio](#table-of-contents)**

## Tunneling, WebRTC, Server Web Socket e Altri Router

  * [Pinggy](https://pinggy.io) — URL pubblici per localhost con un solo comando, nessun download richiesto. Tunnel HTTPS / TCP / TLS. Il piano gratuito ha una durata del tunnel di 60 minuti.
  * [conveyor.cloud](https://conveyor.cloud/) — Estensione Visual Studio per esporre IIS Express alla rete locale o tramite tunnel a un URL pubblico.
  * [Hamachi](https://www.vpn.net/) — LogMeIn Hamachi è un servizio VPN hosted che ti permette di estendere in sicurezza reti tipo LAN a team distribuiti con un piano gratuito che consente reti illimitate con fino a 5 persone
  * [Mirna Sockets](https://mirna.cloud/) - Piattaforma gratuita Socket as a Service che ti fornisce un URL wss:// quando distribuisci il tuo codice server Web Socket e ti permette anche di monitorare le performance.
  * [localhost.run](https://localhost.run/) — Espone server locali tramite tunnel a un URL pubblico.
  * [localtunnel](https://theboroer.github.io/localtunnel-www/) — Espone server locali tramite tunnel a un URL pubblico. Versione hosted gratuita, e [open source](https://github.com/localtunnel/localtunnel).
  * [ngrok.com](https://ngrok.com/) — Espone server locali tramite tunnel a un URL pubblico.
  * [cname.dev](https://cname.dev/) — Servizio di reverse proxy dinamico gratuito e sicuro.
  * [serveo](https://serveo.net/) — Espone server locali su internet. Nessuna installazione, nessuna registrazione. Sottodominio gratuito, senza limiti.
  * [Radmin VPN](https://www.radmin-vpn.com/) — Collega più computer tramite una VPN che abilita una rete tipo LAN. Peer illimitati. (Alternativa a Hamachi)
  * [segment.com](https://segment.com/) — Hub per tradurre e instradare eventi verso altri servizi di terze parti. 100.000 eventi/mese gratis
  * Google STUN — [stun:stun.l.google.com:19302](stun:stun.l.google.com:19302)
  * Twilio STUN — [stun:global.stun.twilio.com:3478?transport=udp](stun:global.stun.twilio.com:3478?transport=udp)
  * [Tailscale](https://tailscale.com/) — VPN zero config, utilizza il protocollo open-source WireGuard. Si installa su MacOS, iOS, Windows, Linux e Android. Piano gratuito per uso personale con 100 dispositivi e tre utenti.
  * [webhookrelay.com](https://webhookrelay.com) — Gestisci, fai debug, fan-out e proxy di tutti i tuoi webhook verso destinazioni pubbliche o interne (es. localhost). Inoltre, espone server in rete privata tramite tunnel assegnando un endpoint HTTP pubblico (`https://yoursubdomain.webrelay.io <----> http://localhost:8080`).
  * [Hookdeck](https://hookdeck.com/pricing) — Sviluppa, testa e monitora i tuoi webhook ovunque. 100K richieste e 100K tentativi al mese con tre giorni di retention.
  * [Xirsys](https://www.xirsys.com/pricing/) — Utilizzo STUN illimitato + 500 MB di banda TURN mensile, banda limitata, singola regione geografica.
  * [ZeroTier](https://www.zerotier.com) — Ethernet virtuale FOSS gestita come servizio. Reti cifrate end-to-end illimitate per 25 client sul piano gratuito. Client per desktop/mobile/NA; interfaccia web per configurare regole di routing personalizzate e approvazione nuovi nodi client su reti private.
  * [LocalXpose](https://localxpose.io) — Reverse proxy che consente di esporre i server localhost su internet. Il piano gratuito ha una durata tunnel di 15 minuti.
  * [Traefik-Hub](https://traefik.io/traefik-hub/) - Pubblica servizi locali in esecuzione tramite tunnel su un URL pubblico personalizzato e proteggili con access control. Gratuito per 5 servizi in un cluster.
  * [Expose](https://expose.dev/) - Espone siti locali tramite tunnel sicuri. Il piano gratuito include server UE, sottodomini casuali e singolo utente.
  * [btunnel](https://www.btunnel.in/) — Espone localhost e server tcp locali su internet. Il piano gratuito include file server, header http personalizzati in richiesta e risposta, protezione basic auth e timeout tunnel di 1 ora.

**[⬆️ Torna all'inizio](#table-of-contents)**

## Issue Tracking e Project Management

  * [acunote.com](https://www.acunote.com/) — Software gratuito di project management e SCRUM per fino a 5 membri del team
  * [asana.com](https://asana.com/) — Gratuito per progetto privato con collaboratori
  * [Backlog](https://backlog.com) — Tutto ciò di cui il tuo team ha bisogno per rilasciare grandi progetti su un'unica piattaforma. Il piano gratuito offre 1 Progetto con dieci utenti e 100MB di storage.
  * [Basecamp](https://basecamp.com/personal) - Liste di cose da fare, gestione delle milestone, messaggistica tipo forum, condivisione file e tracciamento del tempo. Fino a 3 progetti, 20 utenti e 1GB di spazio di archiviazione.
  * [bitrix24.com](https://www.bitrix24.com/) — Intranet e strumento di project management. Il piano gratuito offre 5GB per utenti illimitati.
  * [cacoo.com](https://cacoo.com/) — Diagrammi online in tempo reale: flowchart, UML, network. Gratis max. 15 utenti/diagramma, 25 fogli
  * [Chpokify](https://chpokify.com/) — Planning Poker basato su team che fa risparmiare tempo nella stima degli sprint. Fino a 5 utenti gratis, integrazioni Jira gratuite, chiamate video illimitate, team illimitati, sessioni illimitate.
  * [clickup.com](https://clickup.com/) — Project management. Gratuito, versione premium con storage cloud. App mobili e integrazione Git disponibili.
  * [Clockify](https://clockify.me) - App per il tracciamento del tempo e timesheet che permette di tracciare le ore di lavoro su progetti. Utenti illimitati, gratis per sempre.
  * [Cloudcraft](https://cloudcraft.co/) — Crea un diagramma di architettura professionale in pochi minuti con il designer visuale Cloudcraft, ottimizzato per AWS con componenti intelligenti che mostrano anche dati live. Il piano gratuito ha diagrammi privati illimitati per singolo utente.
  * [Codegiant](https://codegiant.io) — Project Management con repository e CI/CD. Il piano gratuito offre repository, progetti e documenti illimitati con 5 membri del team. 500 minuti CI/CD al mese. 30000 minuti di Serverless Code Run al mese. 1GB di storage repository.
  * [Confluence](https://www.atlassian.com/software/confluence) - Lo strumento di collaborazione di contenuti di Atlassian, usato per aiutare i team a collaborare e condividere conoscenza in modo efficiente. Piano gratuito fino a 10 utenti.
  * [contriber.com](https://www.contriber.com/) — Piattaforma di project management personalizzabile, piano starter gratuito, cinque workspace
* [Crosswork](https://crosswork.app/) - Piattaforma versatile di project management. Gratuito fino a 3 progetti, utenti illimitati, 1 GB di storage.
* [diagrams.net](https://app.diagrams.net/) — Diagrammi online memorizzati localmente su Google Drive, OneDrive o Dropbox. Gratuito per tutte le funzionalità e livelli di storage.
* [freedcamp.com](https://freedcamp.com/) - attività, discussioni, traguardi, monitoraggio del tempo, calendario, file e gestore di password. Piano gratuito con progetti, utenti e spazio di archiviazione file illimitati.
* [easyretro.io](https://www.easyretro.io/) — Strumento semplice e intuitivo per le retrospettive sprint. Il piano gratuito include tre board pubbliche e un sondaggio per board al mese.
* [GForge](https://gforge.com) — Strumento di Project Management e Issue Tracking per progetti complessi con opzioni self-premises e SaaS. Il piano SaaS gratuito offre i primi cinque utenti gratis & gratuito per Progetti Open Source.
* [gleek.io](https://www.gleek.io) — Strumento gratuito da descrizione-a-diagrammi per sviluppatori. Crea diagrammi informali UML di classi, oggetti o entità-relazione usando le tue parole chiave.
* [GraphQL Inspector](https://github.com/marketplace/graphql-inspector) - GraphQL Inspector restituisce un elenco di cambiamenti tra due schemi GraphQL. Ogni differenza è spiegata con precisione e classificata come breaking, non-breaking o dangerous.
* [huboard.com](https://huboard.com/) — Project management istantaneo per le tue issue GitHub, gratuito per Open Source.
* [Hygger](https://hygger.io) — Piattaforma di project management. Il piano gratuito offre utenti, progetti e board illimitati con 100 MB di storage.
* [Instabug](https://instabug.com) — SDK completo per segnalazione bug e feedback in-app per app mobile. Piano gratuito fino a 1 app e un membro.
* [WishKit](https://wishkit.io) — Raccogli feedback degli utenti in-app per la tua app iOS/macOS e dai priorità alle funzionalità in base ai voti degli utenti. Piano gratuito fino a 1 app.
* [Ilograph](https://www.ilograph.com/) — Diagrammi interattivi che permettono agli utenti di visualizzare la propria infrastruttura da più prospettive e livelli di dettaglio. I grafici possono essere espressi in codice. Il livello gratuito ha diagrammi privati illimitati con fino a 3 visualizzatori.
* [Jira](https://www.atlassian.com/software/jira) — Avanzato strumento di project management per lo sviluppo software usato in molti ambienti aziendali. Piano gratuito fino a 10 utenti.
* [kanbanflow.com](https://kanbanflow.com/) — Project management basato su board. Gratuito, versione premium con più opzioni.
* [kanbantool.com](https://kanbantool.com/) — Project management basato su board Kanban. Il piano gratuito include due board e due utenti, senza allegati o file.
* [kan.bn](https://kan.bn/) - Un'app kanban potente e flessibile che aiuta a organizzare il lavoro, monitorare i progressi e ottenere risultati, tutto in un unico posto. Piano gratuito fino a 1 utente per board illimitati, liste illimitate, card illimitate.
* [Kitemaker.co](https://kitemaker.co) - Collabora attraverso tutte le fasi dello sviluppo prodotto e tieni traccia del lavoro su Slack, Discord, Figma e Github. Utenti e spazi illimitati. Piano gratuito fino a 250 elementi di lavoro.
* [Kiter.app](https://www.kiter.app/) - Permetti a chiunque di organizzare la ricerca di lavoro e monitorare colloqui, opportunità e connessioni. Potente web app ed estensione Chrome. Completamente gratuito.
* [Kumu.io](https://kumu.io/) — Mappe delle relazioni con animazioni, decorazioni, filtri, clustering, importazione da spreadsheet, ecc. Il livello gratuito consente progetti pubblici illimitati. Dimensione del grafo illimitata. Progetti privati gratuiti per studenti. Modalità sandbox disponibile se preferisci non lasciare online pubblicamente il file (carica, modifica, scarica, elimina).
* [Linear](https://linear.app/) — Issue tracker con interfaccia semplificata. Gratuito per membri illimitati, fino a 10 MB di upload file, 250 issue (escluso Archivio).
* [leiga.com](https://www.leiga.com/) — Leiga è un prodotto SaaS che usa l'IA per gestire automaticamente i tuoi progetti, aiutando il team a restare focalizzato e a sbloccare un enorme potenziale, assicurando che i progetti progrediscano come pianificato. Gratuito fino a 10 utenti, 20 campi personalizzati, 2GB di spazio di archiviazione, Video Recording con AI limitato a 5 minuti/video, Automation Runs a 20/utente/mese.
* [Lucidchart](https://www.lucidchart.com/) - Strumento di diagrammi online con funzionalità di collaborazione. Piano gratuito con tre documenti modificabili, 100 template professionali e funzionalità base di collaborazione.
* [MeisterTask](https://www.meistertask.com/) — Gestione attività online per team. Gratuito fino a 3 progetti e membri illimitati nei progetti.
* [MeuScrum](https://www.meuscrum.com/en) - Strumento scrum online gratuito con board kanban.
* [nTask](https://www.ntaskmanager.com/) — Software di project management che consente ai team di collaborare, pianificare, analizzare e gestire le attività quotidiane. Il piano essenziale è gratuito per sempre con 100 MB di storage e cinque utenti/team. Workspace, riunioni, assegnazioni, timesheet e issue tracking illimitati.
* [Ora](https://ora.pm/) - Gestione attività agile e collaborazione di team. Gratuito fino a 3 utenti e file limitati a 10 MB.
* [pivotaltracker.com](https://www.pivotaltracker.com/) — Gratuito per progetti pubblici illimitati e due progetti privati con tre utenti attivi totali (lettura-scrittura) e utenti passivi illimitati (sola lettura).
* [plan.io](https://plan.io/) — Project Management con repository hosting e altre opzioni. Gratuito per due utenti con dieci clienti e 500MB di storage.
* [Plane](https://plane.so/) - Plane è uno strumento semplice, estensibile e open-source di project e product management. Gratuito per membri illimitati, upload file fino a 5MB, 1000 issue.
* [planitpoker.com](https://www.planitpoker.com/) — Planning poker online gratuito (strumento di stima).
* [point.poker](https://www.point.poker/) - Planning Poker online (strumento di stima basato sul consenso). Gratuito per utenti, team, sessioni, round e voti illimitati. Non è necessario registrarsi.
* [ScrumFast](https://www.scrumfast.com) - Board Scrum con interfaccia molto intuitiva, gratuito fino a 5 utenti.
* [Shake](https://www.shakebugs.com/) - Strumento di segnalazione bug in-app e feedback per app mobile. Piano gratuito, dieci segnalazioni bug per app/mese.
* [Shortcut](https://shortcut.com/) - Piattaforma di project management. Gratuito fino a 10 utenti per sempre.
* [Tadum](https://tadum.app) - App per agenda e verbali di riunione progettata per meeting ricorrenti, gratuita per team fino a 10 persone.
* [taiga.io](https://taiga.io/) — Piattaforma di project management per startup e sviluppatori agile, gratuita per Open Source.
* [Tara AI](https://tara.ai/) — Servizio semplice di gestione sprint. Il piano gratuito offre attività, sprint e workspace illimitati senza limiti di utenti.
* [targetprocess.com](https://www.targetprocess.com/) — Project management visuale, da Kanban e Scrum a quasi ogni processo operativo. Gratuito per utenti illimitati, fino a 1.000 entità dati {[maggiori dettagli](https://www.targetprocess.com/pricing/)}
* [taskade.com](https://www.taskade.com/) — Liste di attività e outline di team collaborative in tempo reale. Il piano gratuito include un workspace con attività e progetti illimitati; 1GB di storage file; 1 settimana di cronologia progetti; cinque partecipanti per meeting video.
* [taskulu.com](https://taskulu.com/) — Project management basato su ruoli. Gratuito fino a 5 utenti. Integrazione con GitHub/Trello/Dropbox/Google Drive.
* [Teaminal](https://www.teaminal.com) - Strumento per standup, retro e sprint planning per team remoti. Gratuito fino a 15 utenti.
* [teamwork.com](https://teamwork.com/) — Project management & Team Chat. Gratuito per cinque utenti e due progetti. Piani premium disponibili.
* [teleretro.com](https://www.teleretro.com/) — Strumento semplice e divertente per retrospettive con icebreaker, gif ed emoji. Il piano gratuito include tre retro e membri illimitati.
* [testlio.com](https://testlio.com/) — Issue tracking, test management e beta testing platform. Gratuito per uso privato.
* [terrastruct.com](https://terrastruct.com/) — Creatore di diagrammi online specifico per architetture software. Livello gratuito fino a 4 layer per diagramma.
* [todoist.com](https://todoist.com/) — Gestione collaborativa e individuale delle attività. Il piano gratuito include: 5 progetti attivi, cinque utenti per progetto, upload file fino a 5MB, tre filtri e una settimana di cronologia attività.
* [trello.com](https://trello.com/) — Project management basato su board. Board Personali illimitate, 10 Board Team.
* [Tweek](https://tweek.so/) — Semplice calendario settimanale di To-Do & Task Management.
* [ubertesters.com](https://ubertesters.com/) — Piattaforma di test, integrazione e crowd testers, 2 progetti, cinque membri.
* [Wikifactory](https://wikifactory.com/) — Servizio di progettazione prodotto con Projects, VCS & Issues. Il piano gratuito offre progetti e collaboratori illimitati e 3GB di storage.
* [Yodiz](https://www.yodiz.com/) — Sviluppo agile e issue tracking. Gratuito fino a 3 utenti, progetti illimitati.
* [YouTrack](https://www.jetbrains.com/youtrack/buy/#edition=incloud) — YouTrack (InCloud) ospitato gratuitamente per progetti FOSS e progetti privati (gratis per tre utenti). Include time tracking e board agile.
* [zenhub.com](https://www.zenhub.com) — L'unica soluzione di project management all'interno di GitHub. Gratuito per repo pubblici, OSS e organizzazioni non profit.
* [zenkit.com](https://zenkit.com) — Project management e strumento di collaborazione. Gratuito fino a 5 membri, 5 GB di allegati.
* [Zube](https://zube.io) — Project management con piano gratuito per 4 Progetti & 4 utenti. Integrazione GitHub disponibile.
* [Toggl](https://toggl.com/) — Offre due strumenti gratuiti di produttività. [Toggl Track](https://toggl.com/track/) per gestione e monitoraggio del tempo, piano gratuito con tracciamento e reportistica pensati per freelance. Include tracciamenti, progetti, clienti, tag, report illimitati e altro. E [Toggl Plan](https://toggl.com/plan/) per la pianificazione delle attività, piano gratuito per sviluppatori singoli con attività, milestone e timeline illimitati.
* [Sflow](https://sflow.io) — sflow.io è uno strumento di project management per sviluppo software agile, marketing, vendite e supporto clienti, pensato in particolare per outsourcing e collaborazione cross-organizzazione. Piano gratuito fino a 3 progetti e cinque membri.
* [Pulse.red](https://pulse.red) — Tracker di tempo e app foglio ore minimalista gratuito per progetti.

**[⬆️ Torna all'inizio](#table-of-contents)**

## Storage e Media Processing

* [AndroidFileHost](https://androidfilehost.com/) - Piattaforma gratuita di file sharing con velocità, banda, numero di file e download illimitati, ecc. Principalmente pensata per file legati allo sviluppo Android come APK build, custom ROM e modifiche, ecc. Ma sembra accettare anche altri tipi di file.
* [borgbase.com](https://www.borgbase.com/) — Hosting di backup offsite semplice e sicuro per Borg Backup. 10 GB di spazio di backup gratuito e due repository.
* [icedrive.net](https://www.icedrive.net/) - Servizio di cloud storage semplice. 10 GB di storage gratuito.
* [sync.com](https://www.sync.com/) - Servizio cloud di storage end-to-end. 5 GB di storage gratuito.
* [pcloud.com](https://www.pcloud.com/) - Servizio di cloud storage. Fino a 10 GB di storage gratuito.
* [sirv.com](https://sirv.com/) — Smart Image CDN con ottimizzazione e ridimensionamento delle immagini al volo. Il livello gratuito include 500 MB di storage e 2 GB di banda.
* [cloudimage.io](https://www.cloudimage.io/en/home) — Servizio completo di ottimizzazione immagini e CDN con oltre 1500 Point of Presence in tutto il mondo. Varie funzioni di ridimensionamento, compressione e watermarking delle immagini. Plugin open source per immagini responsive, creazione immagini 360° e editing immagini. Piano mensile gratuito con 25GB di traffico CDN, 25GB di cache storage e trasformazioni illimitate.
* [cloudinary.com](https://cloudinary.com/) — Upload immagini, potenti manipolazioni, storage e delivery per siti e app, con librerie Ruby, Python, Java, PHP, Objective-C e altro. Il livello gratuito include 25 crediti mensili. Un credito equivale a 1.000 trasformazioni immagine, 1 GB di storage o 1 GB di utilizzo CDN.
* [embed.ly](https://embed.ly/) — Fornisce API per incorporare media in una pagina web, scalare immagini in modo responsive, ed estrarre elementi da una pagina web. Gratuito fino a 5.000 URL/mese a 15 richieste/secondo.
* [filestack.com](https://www.filestack.com/) — File picker, trasformazione e delivery, gratuito per 250 file, 500 trasformazioni e 3 GB di banda.
* [file.io](https://www.file.io) - 2 GB di storage file. Un file viene eliminato automaticamente dopo un download. REST API per interagire con lo storage. Rate limit una richiesta/minuto.
* [freetools.site](https://freetools.site/) — Strumenti online gratuiti. Converti o modifica documenti, immagini, audio, video e altro.
* [GoFile.io](https://gofile.io/) - Piattaforma gratuita di file sharing e storage, utilizzabile tramite interfaccia web e anche API. Dimensione file, banda, numero di download, ecc. illimitati. Ma verrà eliminato quando un file diventa inattivo (nessun download per oltre dieci giorni).
* [gumlet.com](https://www.gumlet.com/) — Hosting, processing e streaming di immagini e video tramite CDN. Offre un generoso livello gratuito di 250 GB / mese per video e 30 GB / mese per immagini.
* [image-charts.com](https://www.image-charts.com/) — Generazione illimitata di grafici immagine con watermark.
* [Imgbot](https://github.com/marketplace/imgbot) — Imgbot è un robot amichevole che ottimizza le tue immagini e ti fa risparmiare tempo. Immagini ottimizzate significano dimensioni file più piccole senza sacrificare la qualità. È gratuito per open source.
* [ImgBB](https://imgbb.com/) — ImgBB è un servizio di hosting immagini illimitato. Trascina e rilascia la tua immagine ovunque sullo schermo. Limite di 32 MB/immagine. Ricevi link diretti all’immagine, BBCode e miniature HTML dopo l’upload. Login per vedere la cronologia degli upload.
* [imgen](https://www.jitbit.com/imgen/) - API gratuita e illimitata per generare immagini di copertina social, senza watermark.
* [imgix](https://www.imgix.com/) - Caching, gestione e CDN immagini. Piano gratuito include 1000 immagini sorgente, trasformazioni infinite e 100 GB di banda.
* [kraken.io](https://kraken.io/) — Ottimizzazione immagini per performance web come servizio, piano gratuito fino a 1 MB di dimensione file.
* [kvstore.io](https://www.kvstore.io/) — Servizio di storage key-value. Il livello gratuito consente 100 chiavi, 1KB/chiave, 100 chiamate/ora.
* [npoint.io](https://www.npoint.io/) — Storage JSON con editing collaborativo dello schema.
* [nitropack.io](https://nitropack.io/) - Velocizza il tuo sito in modo automatico con ottimizzazione front-end completa (caching, immagini e codice, CDN). Gratuito fino a 5.000 pageview/mese.
* [otixo.com](https://www.otixo.com/) — Crittografa, condividi, copia e sposta tutti i tuoi file di cloud storage da un unico posto. Il piano base offre trasferimenti file illimitati con dimensione massima di 250 MB/file e consente cinque file criptati.
* [packagecloud.io](https://packagecloud.io/) — Repository di pacchetti ospitati per YUM, APT, RubyGem e PyPI. Piani gratuiti limitati e piani open-source disponibili su richiesta.
* [getpantry.cloud](https://getpantry.cloud/) — Un'API di storage dati JSON semplice, perfetta per progetti personali, hackathon e app mobile!
* [Pinata IPFS](https://pinata.cloud) — Pinata è il modo più semplice per caricare e gestire file su IPFS. Interfaccia utente amichevole e API IPFS rendono Pinata il servizio di pinning IPFS più semplice per piattaforme, creatori e collezionisti. 1 GB di storage gratuito, accesso API incluso.
* [placekitten.com](https://placekitten.com/) — Servizio rapido e semplice per ottenere immagini di gattini da usare come segnaposto.
* [plot.ly](https://plot.ly/) — Grafica e condivisione dati. Il livello gratuito include file pubblici illimitati e dieci file privati.
* [podio.com](https://podio.com/) — Puoi usare Podio con un team fino a cinque persone e provare le funzionalità del Piano Base, eccetto la gestione utenti.
* [QRME.SH](https://qrme.sh) - Generatore QR code bulk veloce e bello – senza login, watermark o pubblicità. Fino a 100 URL per export bulk.
* [QuickChart](https://quickchart.io) — Genera grafici immagine, grafici e QR code incorporabili.
* [redbooth.com](https://redbooth.com) — P2P file syncing, gratuito fino a 2 utenti.
* [resmush.it](https://resmush.it) — reSmush.it è una API GRATUITA che fornisce ottimizzazione immagini. reSmush.it è stata implementata sui CMS più comuni come WordPress, Drupal o Magento. reSmush.it è l'API di ottimizzazione immagini più usata con oltre sette miliardi di immagini già trattate, ed è ancora gratuita.
* [Shotstack](https://shotstack.io) - API per generare e modificare video su larga scala. Gratuito fino a 20 minuti di video renderizzato al mese.
* [tinypng.com](https://tinypng.com/) — API per comprimere e ridimensionare immagini PNG e JPEG, offre 500 compressioni gratuite al mese.
* [transloadit.com](https://transloadit.com/) — Gestione upload file ed encoding di video, audio, immagini, documenti. Gratuito per open source, enti benefici e studenti tramite GitHub Student Developer Pack. Applicazioni commerciali hanno 2 GB gratuiti per testare.
* [twicpics.com](https://www.twicpics.com) - Immagini responsive come servizio. Fornisce una CDN per immagini, un'API di elaborazione media e una libreria frontend per automatizzare l'ottimizzazione delle immagini. Il servizio è gratuito fino a 3GB di traffico/mese.
* [uploadcare.com](https://uploadcare.com/hub/developers/) — Uploadcare offre una pipeline multimediale con un toolkit avanzato basato su algoritmi all’avanguardia. Tutte le funzionalità sono disponibili gratuitamente per gli sviluppatori: API e UI di caricamento file, CDN immagini e servizi origine, consegna adattiva e compressione intelligente. Il piano gratuito include 3000 upload, 3 GB di traffico e 3 GB di storage.
* [imagekit.io](https://imagekit.io) – CDN per immagini con ottimizzazione automatica, trasformazione in tempo reale e storage, integrabile in pochi minuti con la configurazione esistente. Il piano gratuito include fino a 20GB di banda al mese.
* [internxt.com](https://internxt.com) – Internxt Drive è un servizio di archiviazione file zero-knowledge basato su privacy assoluta e sicurezza senza compromessi. Registrati e ottieni 10 GB gratis, per sempre!
* [degoo.com](https://degoo.com/) – Cloud storage basato su AI con spazio gratuito fino a 20 GB, tre dispositivi, 5 GB di bonus referral (90 giorni di inattività dell'account).
* [MConverter.eu](https://mconverter.eu/) – Converti file in massa. Supporta molti formati di file, inclusi i più recenti come [AVIF](https://mconverter.eu/convert/to/avif/). Estrai tutti i frame immagine dai video. Gratis per un massimo di dieci file da 100MB al giorno, elaborati in batch da due.
* [ImageEngine](https://imageengine.io/) – ImageEngine è una CDN per immagini globale facile da usare. Configurazione in meno di 60 secondi. Supporto AVIF e JPEGXL, plugin per WordPress, Magento, React, Vue e altri. Richiedi il tuo account developer gratuito [qui](https://imageengine.io/developer-program/).
* [DocsParse](https://docsparse.com/) – Elaborazione AI GPT di PDF, immagini, in dati strutturati nei formati JSON, CSV, EXCEL. 30 crediti gratuiti ogni mese.
* [VaocherApp QR Code Generator](https://www.vaocherapp.com/qr-code-generator) – Crea facilmente codici QR personalizzati per gift card, voucher regalo e promozioni. Supporta stile personalizzato, colore, logo...
* [LibreQR](https://libreqr.com) — Generatore gratuito di codici QR incentrato sulla privacy e senza tracciamento. Gratuito senza raccolta dati.


**[⬆️ Torna all'inizio](#table-of-contents)**

## Design e UI

* [AllTheFreeStock](https://allthefreestock.com) - elenco curato di immagini, audio e video stock gratuiti.
* [Float UI](https://floatui.com/) - strumento gratuito di sviluppo web per creare rapidamente siti moderni e responsive con design accattivante, anche per non-designer.
* [Ant Design Landing Page](https://landing.ant.design/) - Ant Design Landing Page fornisce un template basato sui componenti motion di Ant Motion. Ha una homepage ricca di template, scarica il pacchetto codice del template e può essere usato rapidamente. Puoi anche usare l’editor per costruire velocemente la tua pagina dedicata.
* [Backlight](https://backlight.dev/) — Con la collaborazione tra sviluppatori e designer al centro, Backlight è una piattaforma completa dove i team costruiscono, documentano, pubblicano, scalano e mantengono Design System. Il piano gratuito permette fino a 3 editor di lavorare su un design system con visualizzatori illimitati.
* [BoxySVG](https://boxy-svg.com/app) — App web installabile gratuita per disegnare SVG ed esportare in SVG, PNG, jpeg e altri formati.
* [Carousel Hero](https://carouselhero.com/) - Strumento online gratuito per creare caroselli per i social media.
* [Circum Icons](https://circumicons.com) - Icone open-source consistenti come SVG per React, Vue e Svelte.
* [clevebrush.com](https://www.cleverbrush.com/) — App gratuita per grafica/foto collage. Offre anche integrazione a pagamento come componente.
* [cloudconvert.com](https://cloudconvert.com/) — Converti qualsiasi cosa in qualsiasi cosa. Supporta 208 formati, inclusi video e gif.
* [CodeMyUI](https://codemyui.com) - Collezione selezionata di ispirazioni Web Design & UI con snippet di codice.
* [ColorKit](https://colorkit.co/) - Crea palette di colori online o prendi ispirazione dalle migliori palette.
* [coolors](https://coolors.co/) - Generatore di palette di colori. Gratuito.
* [CMYK Pantone](https://www.cmyktopantone.com/) - Converti facilmente i valori CMYK nei colori Pantone più vicini e in altri modelli colore in pochi secondi gratuitamente.
* [Branition](https://branition.com/colors) - Palette di colori curate a mano, ideali per i brand.
* [css-gradient.com](https://www.css-gradient.com/) - Strumento gratuito per generare rapidamente gradienti CSS personalizzati cross-browser. In formato RGB e HEX.
* [easyvectors.com](https://easyvectors.com/) — EasyVectors.com è un archivio gratuito di arte vettoriale SVG. Scarica le migliori grafiche vettoriali gratuitamente.
* [figma.com](https://www.figma.com) — Strumento di design collaborativo online per team; il piano gratuito include file e visualizzatori illimitati con un massimo di 2 editor e tre progetti.
* [Flyon UI](https://flyonui.com/)- La libreria di componenti più semplice per Tailwind CSS.
* [framer.com](https://www.framer.com/) - Framer ti aiuta a iterare e animare idee di interfaccia per la tua prossima app, sito o prodotto, a partire da layout potenti. Per chiunque voglia validare Framer come strumento di prototipazione professionale: visualizzatori illimitati, fino a 2 editor e fino a 3 progetti.
* [freeforcommercialuse.net](https://freeforcommercialuse.net/) — FFCU foto stock con liberatoria per modello/proprietà senza preoccupazioni
* [Gradientos](https://www.gradientos.app) - Semplifica la scelta di un gradiente in modo rapido e facile.
* [Icon Horse](https://icon.horse) – Ottieni la favicon ad altissima risoluzione di qualsiasi sito web tramite la nostra semplice API.
* [Iconoir](https://iconoir.com) – Libreria open-source di icone con migliaia di icone, supporta React, React Native, Flutter, Vue, Figma e Framer.
* [Icons8](https://icons8.com) — Icone, illustrazioni, foto, musica e strumenti di design. Il piano gratuito offre formati limitati a bassa risoluzione. Inserisci il link a Icons8 quando usi le nostre risorse.
* [landen.co](https://www.landen.co) — Genera, modifica e pubblica siti web e landing page bellissime per la tua startup. Tutto senza codice. Il piano gratuito ti permette di avere un sito, completamente personalizzabile e pubblicato online.
* [Quant Ux](https://quant-ux.com/) - Quant Ux è uno strumento di prototipazione e design. - Completamente gratuito e open source.
* [lensdump.com](https://lensdump.com/) - Hosting cloud gratuito per immagini.
* [Lorem Picsum](https://picsum.photos/) - Strumento gratuito, facile da usare, per placeholder di immagini stilose. Dopo il nostro URL, aggiungi la dimensione desiderata (larghezza & altezza) e otterrai un'immagine casuale.
* [LottieFiles](https://lottiefiles.com/) - La più grande piattaforma online per il formato di animazione più piccolo al mondo, per designer, sviluppatori e altro. Accesso agli strumenti e plugin Lottie per Android, iOS e Web.
* [MagicPattern](https://www.magicpattern.design/tools) — Collezione di generatori e strumenti CSS & SVG per gradienti, pattern e blob.
* [marvelapp.com](https://marvelapp.com/) — Design, prototipazione e collaborazione, piano gratuito limitato a un utente e progetto.
* [Mindmup.com](https://www.mindmup.com/) — Mappe mentali illimitate gratis e archiviabili nel cloud. Le tue mappe mentali sono disponibili ovunque, subito, da qualsiasi dispositivo.
* [Mockplus iDoc](https://www.mockplus.com/idoc) - Strumento potente di collaborazione e handoff per il design. Il piano gratuito include tre utenti e cinque progetti con tutte le funzionalità disponibili.
* [mockupmark.com](https://mockupmark.com/create/free) — Crea mockup realistici di magliette e abbigliamento per social ed E-commerce, 40 mockup gratuiti.
* [Mossaik](https://mossaik.app) - Generatore gratuito di immagini SVG con diversi strumenti come onde, blog e pattern.
* [movingpencils.com](https://movingpencils.com) — Editor vettoriale veloce e basato su browser. Completamente gratuito.
* [Octopus.do](https://octopus.do) — Generatore visuale di sitemap. Crea la struttura del tuo sito in tempo reale e condividila velocemente per collaborare con il team o i clienti.
* [Pencil](https://github.com/evolus/pencil) - Strumento di design open source basato su Electron.
* [Penpot](https://penpot.app) - Strumento di design e prototipazione web-based, open source. Supporta SVG. Completamente gratuito.
* [pexels.com](https://www.pexels.com/) - Foto stock gratuite per uso commerciale. Ha un’API gratuita che permette di cercare foto tramite parole chiave.
* [photopea.com](https://www.photopea.com) — Editor di design online gratuito e avanzato con interfaccia stile Adobe Photoshop che supporta i formati PSD, XCF & Sketch (Adobe Photoshop, Gimp e Sketch App).
* [pixlr.com](https://pixlr.com/) — Editor online gratuito da browser a livello dei software commerciali.
* [Plasmic](https://www.plasmic.app/) - Strumento di design web e page builder veloce, facile da usare e robusto che si integra nel tuo codice. Crea pagine responsive o componenti complessi; estendi opzionalmente con codice; pubblica su siti e app di produzione.
* [Pravatar](https://pravatar.cc/) - Genera avatar casuali o placeholder il cui URL può essere hot-linkato direttamente nelle tue web/app.
* [Proto.io](https://www.proto.io) - Crea prototipi UI completamente interattivi senza codice. Il piano gratuito è disponibile al termine della prova gratuita. Il piano gratuito include un utente, un progetto, cinque prototipi, 100MB di storage online e l’anteprima dell’app proto.io.
* [resizeappicon.com](https://resizeappicon.com/) — Servizio semplice per ridimensionare e gestire le icone della tua app.
* [Rive](https://rive.app) — Crea e pubblica bellissime animazioni su qualsiasi piattaforma. Gratuito per sempre per individui. Il servizio offre un editor che ospita tutte le grafiche sui propri server. Fornisce anche runtime per molte piattaforme per eseguire le rappresentazioni create con Rive.
* [storyset.com](https://storyset.com/) — Crea illustrazioni personalizzate e gratuite per il tuo progetto con questo strumento.
* [smartmockups.com](https://smartmockups.com/) — Crea mockup di prodotto, 200 mockup gratuiti.
* [Shadcn Studio](https://shadcnstudio.com/theme-editor) — Visualizza in anteprima le modifiche al tema su diversi componenti e layout.
* [Tailark](https://tailark.com/) - Collezione di moderni blocchi UI pre-costruiti e responsive pensati per siti di marketing.
* [tabler-icons.io](https://tabler-icons.io/) — Oltre 1500 icone SVG gratuite, modificabili e da copiare-incollare.
* [tweakcn](https://tweakcn.com/) — Temi belli per shadcn/ui. Personalizza colori, tipografia e altro in tempo reale.
* [UI Avatars](https://ui-avatars.com/) - Genera avatar con iniziali dai nomi. Gli URL possono essere hot-linkati direttamente nelle tue web/app. Supporta parametri di configurazione via URL.
* [unDraw](https://undraw.co/) - Collezione in continuo aggiornamento di bellissime immagini SVG che puoi usare liberamente senza attribuzione.
* [unsplash.com](https://unsplash.com/) - Foto stock gratuite per scopi commerciali e non commerciali (licenza do-whatever-you-want).
* [vectr.com](https://vectr.com/) — App gratuita di design per Web + Desktop.
* [walkme.com](https://www.walkme.com/) — Piattaforma di guida e coinvolgimento di classe Enterprise, piano gratuito per tre walkthrough fino a 5 step/walk.
* [Webflow](https://webflow.com) - Website builder WYSIWYG con animazioni e hosting. Gratis per due progetti.
* [Updrafts.app](https://updrafts.app) - Website builder WYSIWYG per design basati su tailwindcss. Gratis per uso non commerciale.
* [whimsical.com](https://whimsical.com/) - Flowchart, wireframe, sticky notes e mappe mentali collaborativi. Crea fino a 4 board gratuite.
* [Zeplin](https://zeplin.io/) — Piattaforma di collaborazione tra designer e sviluppatori. Mostra design, asset e style guide. Gratuito per un progetto.
* [Pixelixe](https://pixelixe.com/) — Crea e modifica online immagini e grafiche uniche e coinvolgenti.
* [Responsively App](https://responsively.app) - Dev tool gratuito per lo sviluppo web responsive più veloce e preciso.
* [SceneLab](https://scenelab.io) - Editor online di grafiche mockup con una collezione in espansione di template di design gratuiti.
* [xLayers](https://xlayers.dev) - Visualizza in anteprima e converti file di design Sketch in Angular, React, Vue, LitElement, Stencil, Xamarin e altro (gratuito e open source su https://github.com/xlayers/xlayers)
* [Grapedrop](https://grapedrop.com/) — Website builder responsive, potente e SEO-ottimizzato basato sul framework GrapesJS. Gratuito per le prime cinque pagine, domini personalizzati illimitati, tutte le funzionalità e uso semplice.
* [Mastershot](https://mastershot.app) - Editor video da browser completamente gratuito. Nessun watermark, fino a 1080p di esportazione.
* [Unicorn Platform](https://unicornplatform.com/) - Website builder di landing page con hosting. Un sito gratis.
* [SVGmix.com](https://www.svgmix.com/) - Enorme repository con oltre 300K icone SVG gratuite, collezioni e loghi di brand. Ha un semplice editor vettoriale nel browser per modifiche veloci ai file.
* [svgrepo.com](https://www.svgrepo.com/) - Esplora, cerca e trova le migliori icone o vettori per i tuoi progetti tra diverse librerie vettoriali. Scarica SVG vettoriali gratuiti per uso commerciale.
* [haikei.app](https://www.haikei.app/) - Haikei è una web app per generare forme, sfondi e pattern SVG unici, pronti da usare nei tuoi strumenti e workflow di design.
* [Canva](https://canva.com) - Strumento di design online gratuito per creare contenuti visivi.
* [Superdesigner](https://superdesigner.co) - Collezione di strumenti di design gratuiti per creare sfondi, pattern, forme, immagini e altro con pochi clic.
* [TeleportHQ](https://teleporthq.io/) - Piattaforma low-code per Design & Sviluppo Front-end. TeleportHQ è la piattaforma collaborativa per creare e pubblicare istantaneamente siti statici headless. Tre progetti gratuiti, collaboratori illimitati, esportazione codice gratuita.
* [vector.express](https://vector.express) — Converti velocemente e facilmente i tuoi vettoriali AI, CDR, DWG, DXF, EPS, HPGL, PDF, PLT, PS e SVG.
* [Vertopal](https://www.vertopal.com) - Vertopal è una piattaforma online gratuita per la conversione di file in vari formati. Include converter per sviluppatori come JPG in SVG, GIF in APNG, PNG in WEBP, JSON in XML, ecc.
* [okso.app](https://okso.app) - App di disegno online minimalista. Permette di creare schizzi e note visive veloci. Esporta in PNG, JPG, SVG e WEBP. Installabile anche come PWA. Gratuita per tutti (senza registrazione).
* [Wdrfree SVG](https://wdrfree.com/free-svg) - File SVG bianchi e neri gratuiti per taglio.
* [Lucide](https://lucide.dev) - Toolkit gratuito di icone SVG personalizzabili e consistenti.
* [Logo.dev](https://www.logo.dev) - API per loghi aziendali con oltre 44M di brand, semplice come chiamare un URL. Prime 10.000 chiamate API gratuite.
* [MDBootstrap](https://mdbootstrap.com/) - Gratuito per uso personale e commerciale. UI Kit Bootstrap, Angular, React e Vue con oltre 700 componenti, template sorprendenti, installazione in 1 minuto, tutorial estesi e una grande community.
* [TW Elements](https://tw-elements.com/) - Componenti Bootstrap gratuiti ricreati con Tailwind CSS, con design migliore e più funzionalità.
* [DaisyUI](https://daisyui.com/) -- Gratuito. "Usa Tailwind CSS ma scrivi meno classi", offre componenti come bottoni.
* [Scrollbar.app](https://scrollbar.app) -- Semplice app web gratuita per progettare scrollbar personalizzate per il web.
* [css.glass](https://css.glass/) -- App web gratuita per creare design glassmorfici usando CSS.
* [hypercolor.dev](https://hypercolor.dev/) -- Una collezione curata di gradienti di colore Tailwind CSS, offre anche una varietà di generatori per crearne di propri.
* [iconify.design](https://icon-sets.iconify.design/) -- Una raccolta di oltre 100 set di icone con un'interfaccia unificata. Permette di cercare icone tra i vari set ed esportare singole icone come SVG o per i framework web più diffusi.
* [NextUI](https://nextui.org/) -- Gratuito. Libreria UI per React & Next.js, bella, veloce e moderna.
* [Glyphs](https://glyphs.fyi/) -- Gratuito, le icone più potenti del web, sistema di design completamente modificabile e veramente open source.
* [ShadcnUI](https://ui.shadcn.com/) -- Componenti splendidamente progettati che puoi copiare e incollare nelle tue app. Accessibili. Personalizzabili. Open Source.
* [HyperUI](https://www.hyperui.dev/) -- Componenti Tailwind CSS Open Source gratuiti.
* [Calendar Icons Generator](https://calendariconsgenerator.app/) -- Genera un intero anno di icone uniche con un solo click, assolutamente GRATIS.
* [Image BG Blurer](https://imagebgblurer.com/) -- Genera una cornice di sfondo sfocata per un'immagine, usando quella stessa immagine come fonte per la sfocatura, per Notion, Trello, Jira e altri strumenti.
* [Webstudio](https://webstudio.is/) -- Alternativa open-source a Webflow. Il piano gratuito offre siti illimitati sul loro dominio. Cinque siti con domini personalizzati. Diecimila visualizzazioni pagina/mese. 2 GB di spazio di archiviazione asset.
* [Nappy](https://nappy.co/) -- Bellissime foto di persone nere e marroni, gratis. Per uso commerciale e personale.
* [Tailkits](https://tailkits.com/) -- Una collezione curata di template Tailwind, componenti e strumenti, oltre a utili generatori per codice, griglie, ombre dei box e altro.
* [Tailcolors](https://tailcolors.com/) -- Una splendida palette di colori Tailwind CSS v4. Anteprima istantanea & copia della classe colore perfetta per Tailwind CSS.
* [Excalidraw](https://excalidraw.com/) -- Pagina web gratuita per disegni online, con salvataggio locale e supporto all'esportazione gratuiti.
* [Lunacy](https://icons8.com/lunacy) -- Strumento di progettazione grafica gratuito con supporto offline, asset integrati (icone, foto, illustrazioni) e collaborazione in tempo reale. Il livello gratuito include 10 documenti cloud, una cronologia di 30 giorni, asset a bassa risoluzione e strumenti di design di base.

**[⬆️ Torna all'inizio](#table-of-contents)**

## Ispirazione per il Design

* [awwwards.](https://www.awwwards.com/) - [Top websites] Una vetrina dei migliori siti web progettati (votati dai designer).
* [Behance](https://www.behance.net/) - [Design showcase] Un luogo dove i designer mostrano il loro lavoro. Filtrabile con categorie per progetti UI/UX.
* [dribbble](https://dribbble.com/) - [Design showcase] Ispirazione unica nel design, generalmente non da applicazioni reali.
* [Landings](https://landings.dev/) - [Web screenshots] Trova le migliori landing page per la tua ispirazione di design in base alle tue preferenze.
* [Lapa Ninja](https://www.lapa.ninja/) - [Landing page / UI KIts / Web screenshots] Lapa Ninja è una galleria con i migliori 6025 esempi di landing page, libri gratuiti per designer e UI kit gratuiti dal web.
* [LovelyLanding.net](https://www.lovelylanding.net/) - [Landing Page Designs] Screenshot di landing page aggiornati frequentemente. Include screenshot Desktop, Tablet e Mobile.
* [Mobbin](https://mobbin.design/) - [Mobile screenshots] Risparmia ore di ricerca UI & UX con la nostra libreria di oltre 50.000 screenshot di app mobili completamente ricercabili.
* [Uiland Design](https://uiland.design/) - [Mobile screenshots] Esplora design di UI mobile e web dalle aziende leader in Africa e nel mondo.
* [Mobile Patterns](https://www.mobile-patterns.com/) - [Mobile screenshots] Una libreria di ispirazione per il design che offre i migliori pattern UI UX (iOS e Android) per designer, sviluppatori e product maker.
* [Page Flows](https://pageflows.com/) - [Mobile / web videos and screenshots] Video di flussi completi su molte app mobili e web. Include anche screenshot. Altamente ricercabile e indicizzato.
* [Screenlane](https://screenlane.com/) - [Mobile screenshots] Trova ispirazione e resta aggiornato sulle ultime tendenze UI di web & mobile app. Filtrabile per pattern e app.
* [scrnshts](https://scrnshts.club/) - [Mobile screenshots] Una collezione selezionata dei migliori screenshot di design dagli store delle app.
* [Refero](https://refero.design/) - [Web screenshots] Collezione taggata e ricercabile di riferimenti di design da grandi applicazioni web.


**[⬆️ Torna all'inizio](#table-of-contents)**

## Visualizzazione dati su mappe

* [IP Geolocation](https://ipgeolocation.io/) — Piano SVILUPPATORE gratuito disponibile con 30K richieste/mese.
* [carto.com](https://carto.com/) — Crea mappe e API geospaziali dai tuoi dati e da dati pubblici.
* [Clockwork Micro](https://clockworkmicro.com/) — Strumenti per mappe che funzionano come un orologio. Cinquantamila query mensili gratuite (map tiles, db2vector, elevazione).
* [developers.arcgis.com](https://developers.arcgis.com) — API e SDK per mappe, archiviazione dati geospaziali, analisi, geocodifica, routing e altro su web, desktop e mobile. Due milioni di tile di base mappa gratuiti, 20.000 geocodifiche non archiviate, 20.000 percorsi semplici, 5.000 calcoli drive time e 5GB di storage tile+dati gratuito al mese.
* [Foursquare](https://developer.foursquare.com/) - Scoperta di località, ricerca di venue e contenuti contestuali tramite Places API e Pilgrim SDK.
* [geoapify.com](https://www.geoapify.com/) - Mappe vettoriali e raster, API di geocodifica, places, routing, isolinee. Tremila richieste gratuite/giorno.
* [geocod.io](https://www.geocod.io/) — Geocodifica tramite API o caricamento CSV. Duemilacinquecento query gratuite/giorno.
* [geocodify.com](https://geocodify.com/) — Geocodifica e Geoparsing tramite API o caricamento CSV. 10.000 query gratuite/mese.
* [geojs.io](https://www.geojs.io/) - API di lookup geolocalizzazione IP REST/JSON/JSONP altamente disponibile.
* [giscloud.com](https://www.giscloud.com/) — Visualizza, analizza e condividi dati geografici online.
* [graphhopper.com](https://www.graphhopper.com/) Pacchetto sviluppatore gratuito per Routing, Ottimizzazione percorsi, Matrice di distanze, Geocodifica e Map Matching.
* [here](https://developer.here.com/) — API e SDK per mappe e app location-aware. 250.000 transazioni/mese gratis.
* [locationiq.com](https://locationiq.com/) — API di geocodifica, mappe e routing. Cinquemila richieste/giorno gratis.
* [mapbox.com](https://www.mapbox.com/) — Mappe, servizi geospaziali e SDK per visualizzare dati cartografici.
* [maptiler.com](https://www.maptiler.com/cloud/) — Mappe vettoriali, servizi di mappe e SDK per la visualizzazione di mappe. Tile vettoriali gratuiti con aggiornamenti settimanali e quattro stili di mappa.
* [nominatim.org](https://nominatim.org/) — Servizio di geocodifica gratuito di OpenStreetMap, fornisce ricerca globale di indirizzi e funzionalità di geocodifica inversa.
* [nextbillion.ai](https://nextbillion.ai/) - Servizi relativi alle mappe: Geocodifica, Navigazione (direzioni, routing, ottimizzazione percorsi, matrice distanze), SDK Mappe (Vettoriali, Statiche, Mobile SDK). [Gratis con quota specificata](https://nextbillion.ai/pricing) per ogni servizio.
* [opencagedata.com](https://opencagedata.com) — API di geocodifica che aggrega OpenStreetMap e altre fonti geo open. Duemilacinquecento query gratuite/giorno.
* [osmnames](https://osmnames.org/) — Geocodifica, risultati di ricerca ordinati per popolarità della relativa pagina Wikipedia.
* [positionstack](https://positionstack.com/) - Geocodifica gratuita per località e coordinate globali. 25.000 richieste al mese per uso personale.
* [stadiamaps.com](https://stadiamaps.com/) — Map tiles, routing, navigazione e altre API geospaziali. Duemilacinquecento visualizzazioni mappa e richieste API/giorno gratis per uso non commerciale e test.
* [maps.stamen.com](http://maps.stamen.com/) - Tile di mappe e hosting tile gratuiti.
* [ipstack](https://ipstack.com/) - Localizza e identifica i visitatori del sito web tramite indirizzo IP.
* [Geokeo api](https://geokeo.com) - API di geocodifica con correzione lingua e altro. Copertura mondiale. 2.500 query giornaliere gratuite

**[⬆️ Torna all'inizio](#table-of-contents)**

## Sistema di Build per Pacchetti

* [build.opensuse.org](https://build.opensuse.org/) — Servizio di build pacchetti per più distro (SUSE, EL, Fedora, Debian, ecc.).
* [copr.fedorainfracloud.org](https://copr.fedorainfracloud.org) — Servizio di build RPM basato su Mock per Fedora ed EL.
* [help.launchpad.net](https://help.launchpad.net/Packaging) — Servizio di build per Ubuntu e Debian.

**[⬆️ Torna all'inizio](#table-of-contents)**

## IDE e Editor di Codice

* [3v4l](https://3v4l.org/) - Shell PHP online gratuita e sito di condivisione snippet, esegue il tuo codice in oltre 300 versioni PHP
* [Android Studio](https://developer.android.com/studio) — Android Studio fornisce i tool più veloci per sviluppare app su ogni tipo di dispositivo Android. IDE Open Source gratuito per tutti e il migliore per lo sviluppo di app Android. Disponibile per Windows, Mac, Linux e anche ChromeOS!
* [AndroidIDE](https://m.androidide.com/) — Un IDE Open Source per sviluppare vere applicazioni Android basate su Gradle direttamente su dispositivi Android.
* [Apache Netbeans](https://netbeans.apache.org/) — Ambiente di sviluppo, piattaforma di strumenti e framework applicativo.
* [apiary.io](https://apiary.io/) — Design API collaborativo con mock API istantaneo e documentazione generata (Gratis per API blueprint illimitati e utenti illimitati con un account admin e documentazione ospitata).
* [BBEdit](https://www.barebones.com/) - BBEdit è un popolare editor per macOS, estensibile. La Modalità Gratuita offre un [set di funzionalità base potente](https://www.barebones.com/products/bbedit/comparison.html) e un percorso di upgrade a funzionalità avanzate.
* [Binder](https://mybinder.org/) - Trasforma un repository Git in una raccolta di notebook interattivi. È un servizio pubblico gratuito.
* [BlueJ](https://bluej.org) — Ambiente di sviluppo Java gratuito progettato per principianti, usato da milioni di persone in tutto il mondo. Semplice GUI per aiutare i principianti, supportato da Oracle.
* [Bootify.io](https://bootify.io/) - Generatore di app Spring Boot con database personalizzato e REST API.
* [Brackets](http://brackets.io/) - Editor di testo open source specificamente progettato per lo sviluppo web. Leggero, facile da usare e altamente personalizzabile.
* [cacher.io](https://www.cacher.io) — Organizzatore di snippet di codice con etichette e supporto per oltre 100 linguaggi di programmazione.
* [Code::Blocks](https://codeblocks.org) — IDE gratuito per Fortran & C/C++. Open Source e disponibile per Windows, macOS & Linux.
* [Cody](https://sourcegraph.com/cody) - Assistente AI di coding gratuito che può scrivere (blocchi di codice, autocompletamento, unit test), comprendere (conoscenza dell’intero codebase), correggere e trovare il tuo codice. Disponibile per VS Code, JetBrains e Online.
* [codiga.io](https://codiga.io/) — Coding Assistant che ti permette di cercare, definire e riutilizzare snippet di codice direttamente nel tuo IDE. Gratis per individui e piccole organizzazioni.
* [codesnip.com.br](https://codesnip.com.br) — Gestore semplice di snippet di codice con categorie, ricerca e tag. Gratuito e illimitato.
* [cocalc.com](https://cocalc.com/) — (ex SageMathCloud su cloud.sagemath.com) — Calcolo collaborativo in cloud. Accesso tramite browser a una Ubuntu completa con collaborazione integrata e molto software gratuito preinstallato per matematica, scienza, data science: Python, LaTeX, Jupyter Notebooks, SageMath, scikitlearn, ecc.
* [code.cs50.io](https://code.cs50.io/) - Visual Studio Code per CS50 è un'app web che adatta GitHub Codespaces per studenti e insegnanti.
* [codepen.io](https://codepen.io/) — CodePen è un playground per il front-end del web.
* [codesandbox.io](https://codesandbox.io/) — Playground online per React, Vue, Angular, Preact e altro.
* [Components.studio](https://webcomponents.dev/) - Crea componenti di codice in isolamento, visualizzali in stories, testali e pubblicali su npm.
* [Eclipse Che](https://www.eclipse.org/che/) - IDE web-based e Kubernetes-Native per team di sviluppatori con supporto multilingua. Open Source e guidato dalla community. Un'istanza online ospitata da Red Hat è disponibile su [workspaces.openshift.com](https://workspaces.openshift.com/).
* [fakejson.com](https://fakejson.com/) — FakeJSON ti aiuta a generare rapidamente dati fittizi tramite la sua API. Fai una richiesta API descrivendo cosa vuoi e come lo vuoi. L’API restituisce tutto in JSON. Velocizza il processo go-to-market per le idee e fingi finché non ce la fai.
* [GetVM](https://getvm.io) — Linux e IDE istantanei gratuiti in barra laterale Chrome. Il piano gratuito include 5 VM al giorno.
* [GitPod](https://www.gitpod.io) — Ambienti di sviluppo istantanei e pronti per il codice per progetti GitHub. Il livello gratuito include 50 ore/mese.
* [ide.goorm.io](https://ide.goorm.io) goormIDE è un IDE completo sul cloud. Supporto multi-lingua, contenitore basato su Linux tramite terminale web completo, port forwarding, URL personalizzato, collaborazione e chat in tempo reale, link di condivisione, supporto Git/Subversion. Ci sono molte altre funzionalità (Il livello gratuito include 1GB di RAM e 10GB di Storage per contenitore, 5 slot per contenitori).
* [JDoodle](https://www.jdoodle.com) — Compilatore e editor online per più di 60 linguaggi di programmazione con un piano gratuito per compilazione codice via REST API fino a 200 crediti al giorno.
* [jetbrains.com](https://jetbrains.com/products.html) — Strumenti di produttività, IDE e strumenti di deploy (aka [IntelliJ IDEA](https://www.jetbrains.com/idea/), [PyCharm](https://www.jetbrains.com/pycharm/), ecc). Licenza gratuita per studenti, insegnanti, Open Source e gruppi utenti.
* [jsbin.com](https://jsbin.com) — JS Bin è un altro playground e sito di condivisione codice per web front-end (HTML, CSS e JavaScript). Supporta anche Markdown, Jade e Sass.
* [jsfiddle.net](https://jsfiddle.net/) — JS Fiddle è un playground e sito di condivisione codice per web front-end, supporta la collaborazione.
* [JSONPlaceholder](https://jsonplaceholder.typicode.com/) Alcuni endpoint REST API che restituiscono dati fittizi in formato JSON. Il codice sorgente è disponibile se desideri eseguire il server localmente.
* [Lazarus](https://www.lazarus-ide.org/) — Lazarus è un IDE multipiattaforma compatibile con Delphi per lo sviluppo rapido di applicazioni.
* [MarsCode](https://www.marscode.com/) - Un IDE cloud gratuito alimentato dall'AI.
* [micro-jaymock](https://micro-jaymock.now.sh/) - Microservizio di mocking API di piccole dimensioni per generare dati JSON fittizi.
* [mockable.io](https://www.mockable.io/) — Mockable è un servizio semplice e configurabile per simulare servizi web RESTful API o SOAP. Questo servizio online permette di definire rapidamente endpoint REST API o SOAP e di farli restituire dati in formato JSON o XML.
* [mockaroo](https://mockaroo.com/) — Mockaroo ti permette di generare dati di test realistici in formato CSV, JSON, SQL ed Excel. Puoi anche creare mock per API back-end.
* [Mocklets](https://mocklets.com) - Simulatore di mock API basato su HTTP che aiuta a simulare API per uno sviluppo parallelo più rapido e test più completi, con un livello gratuito a vita.
* [Paiza](https://paiza.cloud/en/) — Sviluppa applicazioni Web nel browser senza bisogno di configurare nulla. Il piano gratuito offre un server con una durata di 24 ore e 4 ore di tempo di esecuzione al giorno con 2 core CPU, 2 GB di RAM e 1 GB di storage.
* [Prepros](https://prepros.io/) - Prepros può compilare Sass, Less, Stylus, Pug/Jade, Haml, Slim, CoffeeScript e TypeScript subito, ricarica i browser e rende facile sviluppare e testare i tuoi siti web così puoi concentrarti sulla perfezione. Puoi anche aggiungere i tuoi strumenti con pochi clic.
* [Replit](https://replit.com/) — Ambiente di codifica cloud per vari linguaggi di programmazione.
* [SoloLearn](https://code.sololearn.com) — Playground di programmazione cloud ideale per l'esecuzione di snippet di codice. Supporta vari linguaggi di programmazione. Non è richiesta la registrazione per eseguire il codice, ma è necessaria per salvare il codice sulla loro piattaforma. Offre anche corsi gratuiti per principianti e programmatori di livello intermedio.
* [stackblitz.com](https://stackblitz.com/) — IDE di codice online/cloud per creare, modificare e distribuire app full-stack. Supporta qualsiasi framework frontend e backend basato su NodeJs. Shortlink per creare un nuovo progetto: [https://node.new](https://node.new).
* [Sublime Text](https://www.sublimetext.com/) - Sublime Text è un editor di testo popolare, versatile e altamente personalizzabile usato per attività di codifica e modifica testi.
* [Visual Studio Code](https://code.visualstudio.com/) - Editor di codice ridefinito e ottimizzato per costruire e fare debug di applicazioni web e cloud moderne. Sviluppato da Microsoft.
* [Visual Studio Community](https://visualstudio.microsoft.com/vs/community/) — IDE completo di tutte le funzionalità con migliaia di estensioni, sviluppo di app multipiattaforma (estensioni Microsoft disponibili per iOS e Android), sviluppo desktop, web e cloud, supporto multi-lingua (C#, C++, JavaScript, Python, PHP e altro).
* [VSCodium](https://vscodium.com/) - Distribuzione binaria di VSCode guidata dalla comunità, senza telemetria/tracciamento e con licenza libera.
* [wakatime.com](https://wakatime.com/) — Metriche di autosservizio sulle attività di codifica tramite plugin per editor di testo, piano limitato gratuito.
* [Wave Terminal](https://waveterm.dev/) - Wave è un terminale open-source e multipiattaforma per flussi di lavoro senza soluzione di continuità. Visualizza qualsiasi cosa inline. Salva sessioni e cronologia. Basato su standard web aperti. MacOS e Linux.
* [WebComponents.dev](https://webcomponents.dev/) — IDE nel browser per scrivere componenti web in isolamento con 58 template disponibili, supportando storie e test.
* [PHPSandbox](https://phpsandbox.io/) — Ambiente di sviluppo online per PHP
* [WebDB](https://webdb.app) - IDE di database efficiente gratuito. Include Server Discovery, ERD, Generatore di Dati, AI, Gestione Struttura NoSQL, Versionamento Database e molto altro.
* [Zed](https://zed.dev/) - Zed è un editor di codice ad alte prestazioni e multiplayer dai creatori di Atom e Tree-sitter.
* [OneCompiler](https://onecompiler.com/) - Compilatore online gratuito che supporta più di 70 linguaggi, inclusi Java, Python, C++, JavaScript.

**[⬆️ Torna all'inizio](#table-of-contents)**

## Analitiche, Eventi e Statistiche

* [Dwh.dev](https://dwh.dev) - Soluzione di Data Cloud Observability (Snowflake). Gratis per uso personale.
* [Hightouch](https://hightouch.com/) - Hightouch è una piattaforma Reverse ETL che ti aiuta a sincronizzare i dati dei clienti dal tuo data warehouse verso CRM, strumenti di marketing e supporto. Il livello gratuito offre una destinazione per sincronizzare i dati.
* [Avo](https://avo.app/) — Workflow semplificato per il rilascio di analytics. Piano di tracciamento unificato, libreria di tracciamento analytics type-safe, debugger in-app e data observability per rilevare tutti i problemi prima del rilascio. Gratis per due membri workspace e 1 ora di lookback data observability.
* [Branch](https://www.branch.io) — Piattaforma di Mobile Analytics. Il livello gratuito offre fino a 10K utenti app mobile con deep-linking e altri servizi.
* [Census](https://www.getcensus.com/) — Reverse ETL & Operational Analytics Platform. Sincronizza 10 campi dal tuo data warehouse a oltre 60 SaaS come Salesforce, Zendesk o Amplitude.
* [Clicky](https://clicky.com) — Piattaforma di Website Analytics. Piano gratuito per un sito con 3000 visualizzazioni analytics.
* [Databox](https://databox.com) — Business Insights & Analytics combinando altre piattaforme di analytics & BI. Il piano gratuito offre 3 utenti, dashboard e sorgenti dati. 11M record storici.
* [Hitsteps.com](https://hitsteps.com/) — 2.000 pageview al mese per 1 sito web
* [amplitude.com](https://amplitude.com/) — 1 milione di eventi mensili, fino a 2 app
* [GoatCounter](https://www.goatcounter.com/) — GoatCounter è una piattaforma open-source di web analytics disponibile come servizio ospitato (gratuito per uso non commerciale) o app self-hosted. Mira a offrire analytics web facili da usare, significativi e rispettosi della privacy come alternativa a Google Analytics o Matomo. Il livello gratuito è per uso non commerciale e include siti illimitati, sei mesi di conservazione dati e 100k pageview/mese.
* [Google Analytics](https://analytics.google.com/) — Google Analytics
* [MetricsWave](https://metricswave.com) — Alternativa a Google Analytics per sviluppatori, attenta alla privacy. Piano gratuito consente 20k pageview al mese senza carta di credito.
* [Expensify](https://www.expensify.com/) — Reportistica spese, workflow gratuito di approvazione report personali
* [getinsights.io](https://getinsights.io) - Analytics attenti alla privacy e senza cookie, gratuito fino a 3k eventi/mese.
* [heap.io](https://heap.io) — Cattura automaticamente ogni azione utente in app iOS o web. Gratuito fino a 10K sessioni mensili.
* [Hotjar](https://hotjar.com) — Analytics e report per siti web. Piano gratuito consente 2000 pageview/giorno. Cento snapshot/giorno (max 300). Tre heatmap snapshot possono essere salvati per 365 giorni. Membri del team illimitati. Anche sondaggi in-app e autonomi, widget di feedback con screenshot. Il livello gratuito consente la creazione di 3 sondaggi e 3 widget di feedback e la raccolta di 20 risposte al mese.
* [Keen](https://keen.io/) — Analytics personalizzati per raccolta, analisi e visualizzazione dati. 1.000 eventi/mese gratis
* [Yandex.Datalens](https://datalens.yandex.com/) — Servizio Yandex Cloud per visualizzazione e analisi dati. Il servizio è gratuito. Nessuna restrizione su numero di utenti e richieste.
* [Yandex.Metrica](https://metrica.yandex.com/) — Analytics illimitate gratuite
* [Mixpanel](https://mixpanel.com/) — 100.000 utenti mensili tracciati, dati e utenti illimitati, residenza dati US o EU
* [Moesif](https://www.moesif.com) — API analytics per REST e GraphQL. (Gratis fino a 500.000 chiamate API/mese)
* [optimizely.com](https://www.optimizely.com) — Soluzione per A/B Testing, piano starter gratuito, un sito, 1 app iOS e 1 app Android
* [Microsoft PowerBI](https://powerbi.com) — Business Insights & Analytics di Microsoft. Il piano gratuito offre utilizzo limitato con 1 Milione di licenze utente.
* [Row Zero](https://rowzero.io) - Foglio di calcolo connesso e velocissimo. Connettiti direttamente a database, S3 e API. Importa, analizza, crea grafici e condividi milioni di righe istantaneamente. Tre workbooks gratuiti per sempre.
* [sematext.com](https://sematext.com/cloud/) — Gratis fino a 50K azioni/mese, 1 giorno di retention dati, dashboard illimitati, utenti, ecc.
* [Similar Web](https://similarweb.com) — Analytics per Web & Mobile App. Piano gratuito offre cinque risultati per metrica, un mese di dati app mobile e 3 mesi di dati sito web.
* [StatCounter](https://statcounter.com/) — Analytics dei visitatori del sito. Piano gratuito per analytics degli ultimi 500 visitatori.
* [Statsig](https://statsig.com) - Piattaforma tutto-in-uno tra analytics, feature flagging e A/B testing. Gratis fino a 1 milione di eventi misurati al mese.
* [Tableau Developer Program](https://www.tableau.com/developer) — Inova, crea e fa che Tableau funzioni perfettamente per la tua organizzazione. Il programma gratuito offre una licenza personale sandbox per Tableau Online. La versione è l'ultima pre-release così i Data Devs possono testare ogni funzione della piattaforma.
* [usabilityhub.com](https://usabilityhub.com/) — Testa design e mockup su persone reali e traccia i visitatori. Gratis per un utente, test illimitati
* [woopra.com](https://www.woopra.com/) — Piattaforma gratuita di user analytics per 500K azioni, 90 giorni di retention dati, oltre 30 integrazioni one-click.
* [counter.dev](https://counter.dev) — Web analytics semplice e quindi attento alla privacy. Gratis o paga quanto vuoi tramite donazione.
* [PostHog](https://posthog.com) - Suite completa di Product Analytics gratis fino a 1 milione di eventi tracciati al mese. Fornisce anche survey in-app illimitate con 250 risposte/mese.
* [Uptrace](https://uptrace.dev) - Strumento di Distributed Tracing che aiuta gli sviluppatori a individuare errori e colli di bottiglia. Ha un piano gratuito, offre abbonamento personale gratuito per progetti open-source e versione open-source.
* [Microsoft Clarity](https://clarity.microsoft.com/) - Clarity è uno strumento gratuito e facile da usare che cattura come le persone usano realmente il tuo sito.
* [Beampipe.io](https://beampipe.io) - Beampipe è un servizio semplice di web analytics attento alla privacy. Gratis fino a 5 domini e 10k visualizzazioni mensili.
* [Aptabase](https://aptabase.com) — Open Source, analytics semplici e privacy-friendly per app mobile e desktop. SDK per Swift, Kotlin, React Native, Flutter, Electron e molti altri. Gratis fino a 20.000 eventi al mese.
* [Trackingplan](https://www.trackingplan.com/) - Rileva automaticamente problemi su analytics digitali, dati marketing e pixel, mantiene piani di tracciamento aggiornati e favorisce la collaborazione. Distribuiscilo in produzione con traffico reale o aggiungi coverage analytics ai tuoi test di regressione senza scrivere codice.
* [LogSpot](https://logspot.io) - Piattaforma completa unificata di web e product analytics, inclusi widget di analytics embeddabili e robot automatizzati (slack, telegram, webhook). Piano gratuito include 10.000 eventi al mese.
* [Umami](https://umami.is/) - Alternativa open-source semplice, veloce e attenta alla privacy a Google Analytics.
* [TrackWith Dicloud](https://dicloud.net/trackwith-privacy-focused-analytics/) - Alternativa gratuita, leggera e privacy-focused a Google Analytics. Pageview, visitatori, heatmap & goal tracking illimitati. Gratis fino a 3 domini e 600 session replay per dominio.
* [AppFit](https://appfit.io) - AppFit è uno strumento completo di analytics e gestione prodotto pensato per facilitare la gestione cross-platform di analytics e aggiornamenti prodotto. Piano gratuito include 10.000 eventi al mese, diario prodotto e insights settimanali.
* [Seline](https://seline.so) - Seline è un'analitica semplice e privata per siti e prodotti. Senza cookie, leggera, indipendente. Piano gratuito include 3.000 eventi/mese e accesso a tutte le funzionalità, come dashboard, user journeys, funnel e altro.
* [Peasy](https://peasy.so) - Peasy è uno strumento di analytics leggero e privacy-focused per siti e prodotti. Piano gratuito include 3.000 eventi al mese.
* [Rybbit](https://rybbit.io) - Alternativa open-source e senza cookie a Google Analytics che è 10x più intuitiva. Piano gratuito con 3.000 eventi mensili.

**[⬆️ Torna all'inizio](#table-of-contents)**

## Registrazione Sessioni Visitatore

* [Reactflow.com](https://www.reactflow.com/) — Per sito: 1.000 visualizzazioni pagina/giorno, tre heatmap, tre widget, bug tracking gratuito
* [OpenReplay.com](https://www.openreplay.com) - Session replay open-source con dev tool per riproduzione bug, sessioni live per supporto in tempo reale e suite di analytics prodotto. Mille sessioni/mese con accesso a tutte le funzionalità e retention di 7 giorni.
* [LogRocket.com](https://www.logrocket.com) - 1.000 sessioni/mese con retention di 30 giorni, error tracking, modalità live
* [FullStory.com](https://www.fullstory.com) — 1.000 sessioni/mese con un mese di retention dati e tre seat utente. Maggiori informazioni [qui](https://help.fullstory.com/hc/en-us/articles/360020623354-FullStory-Free-Edition).
* [hotjar.com](https://www.hotjar.com/) — Per sito: 1.050 visualizzazioni pagina/mese, heatmap illimitati, dati archiviati per tre mesi
* [inspectlet.com](https://www.inspectlet.com/) — 2.500 sessioni/mese gratis per un sito web
* [Microsoft Clarity](https://clarity.microsoft.com/) - Registrazione sessioni completamente gratuita con "nessun limite di traffico", nessun limite di progetto e nessun campionamento
* [mouseflow.com](https://mouseflow.com/) — 500 sessioni/mese gratis per un sito web
* [mousestats.com](https://www.mousestats.com/) — 100 sessioni/mese gratis per un sito web
* [smartlook.com](https://www.smartlook.com/) — pacchetti gratuiti per app web e mobile (1500 sessioni/mese), tre heatmap, una funnel, 1 mese di storico dati
* [howuku.com](https://howuku.com) — Traccia interazione, engagement ed eventi utente. Gratis fino a 5.000 visite/mese
* [UXtweak.com](https://www.uxtweak.com/) — Registra e guarda come i visitatori usano il tuo sito o app. Tempo illimitato gratis per piccoli progetti

**[⬆️ Torna all'inizio](#table-of-contents)**
## API e SDK per la Verifica di Numeri di Cellulare Internazionali

  * [numverify](https://numverify.com/) — Validazione globale dei numeri di telefono e API JSON per lookup. 100 richieste API/mese
  * [veriphone](https://veriphone.io/) — Verifica globale dei numeri di telefono in una API JSON gratuita, veloce e affidabile. 1000 richieste/mese

**[⬆️ Torna all'inizio](#table-of-contents)**

## Integrazione Pagamenti e Fatturazione

  * [Qonversion](http://qonversion.io/) - Piattaforma all-in-one per la gestione degli abbonamenti cross-platform che offre analytics, A/B testing, Apple Search Ads, configurazioni remote e strumenti di crescita per ottimizzare acquisti in-app e monetizzazione. Compatibile con iOS, Android, React Native, Flutter, Unity, Cordova, Stripe e web. Gratuito fino a $10k di ricavi mensili tracciati.
  * [ParityVend](https://www.ambeteco.com/ParityVend/) – Regola automaticamente i prezzi in base alla posizione del visitatore per espandere globalmente il tuo business e raggiungere nuovi mercati (parità di potere d'acquisto). Il piano gratuito include 7.500 richieste API/mese.
  * [Glassfy](https://glassfy.io/) – Infrastruttura per abbonamenti in-app, eventi di abbonamento in tempo reale e strumenti di monetizzazione pronti all'uso su iOS, Android, Stripe e Paddle. Gratuito fino a $10k di ricavi mensili.
  * [Adapty.io](https://adapty.io/) – Soluzione unica con SDK open-source per l'integrazione di abbonamenti in-app mobile su iOS, Android, React Native, Flutter, Unity o web app. Gratuito fino a $10k di ricavi mensili.
  * [CoinMarketCap](https://coinmarketcap.com/api/) — Fornisce dati di mercato sulle criptovalute tra cui ultimi tassi di cambio crypto e valute fiat. Il livello gratuito offre 10K crediti chiamata/mese.
  * [CurrencyFreaks](https://currencyfreaks.com/) — Fornisce tassi di cambio attuali e storici. Piano DEVELOPER gratuito disponibile con 1000 richieste/mese.
  * [CoinGecko](https://www.coingecko.com/en/api) — Fornisce dati di mercato sulle criptovalute, inclusi i più recenti tassi di cambio crypto e dati storici. L'api demo offre un rate limit stabile di 30 chiamate/min e un massimo mensile di 10.000 chiamate.
  * [CurrencyApi](https://currencyapi.net/) — Tassi di cambio in tempo reale per valute fisiche e criptovalute, forniti in JSON e XML. Il livello gratuito offre 1.250 richieste API/mese.
  * [currencylayer](https://currencylayer.com/) — Tassi di cambio affidabili e conversione valuta per il tuo business, 100 richieste API/mese gratuite.
  * [exchangerate-api.com](https://www.exchangerate-api.com) - API JSON per la conversione di valuta facile da usare. Il livello gratuito si aggiorna una volta al giorno con un limite di 1.500 richieste/mese.
  * [FraudLabsPRO](https://www.fraudlabspro.com) — Aiuta i commercianti a prevenire frodi nei pagamenti e chargeback. Piano Micro gratuito disponibile con 500 query/mese.
  * [FxRatesAPI](https://fxratesapi.com) — Fornisce tassi di cambio in tempo reale e storici. Il piano gratuito richiede attribuzione.
  * [Moesif API Monetization](https://www.moesif.com/) - Genera ricavi dalle API tramite fatturazione basata sull'uso. Collegati a Stripe, Chargebee, ecc. Il piano gratuito offre 30.000 eventi/mese.
  * [Nami ML](https://www.namiml.com/) - Piattaforma completa per acquisti e abbonamenti in-app su iOS e Android, incluse paywall no-code, CRM e analytics. Gratuito per tutte le funzionalità base per gestire un business IAP.
  * [RevenueCat](https://www.revenuecat.com/) — Backend ospitato per acquisti e abbonamenti in-app (iOS e Android). Gratuito fino a $2.5k/mese di ricavi tracciati.
  * [vatlayer](https://vatlayer.com/) — Validazione istantanea dei numeri IVA e API dei tassi IVA UE, 100 richieste API/mese gratuite.
  * [Currencyapi](https://currencyapi.com) — API gratuita di conversione valuta e tassi di cambio. 300 richieste gratuite al mese, 10 richieste al minuto per uso privato.

**[⬆️ Torna all'inizio](#table-of-contents)**

## Strumenti Relativi a Docker

  * [canister.io](https://canister.io/) — 20 repository privati gratuiti per sviluppatori, 30 repository privati gratuiti per team per costruire e archiviare immagini Docker
  * [Container Registry Service](https://container-registry.com/) - Soluzione di gestione container basata su Harbor. Il livello gratuito offre 1 GB di spazio per repository privati.
  * [Docker Hub](https://hub.docker.com) — Un repository privato gratuito e repository pubblici illimitati per costruire e archiviare immagini Docker
  * [Play with Docker](https://labs.play-with-docker.com/) — Un ambiente semplice, interattivo e divertente per imparare Docker.
  * [quay.io](https://quay.io/) — Costruisci e archivia immagini container con repository pubblici illimitati e gratuiti
  * [ttl.sh](https://ttl.sh/) - Registry di immagini Docker anonimo ed effimero

**[⬆️ Torna all'inizio](#table-of-contents)**

## Strumenti Relativi a Vagrant

  * [Vagrant Cloud](https://app.vagrantup.com) - HashiCorp Vagrant Cloud. Hosting di box Vagrant.
  * [Vagrantbox.es](https://www.vagrantbox.es/) — Un indice alternativo pubblico di box

**[⬆️ Torna all'inizio](#table-of-contents)**

## Siti di Blogging per Sviluppatori

  * [BearBlog](https://bearblog.dev/) - Blog e builder di siti minimalista alimentato da Markdown.
  * [Dev.to](https://dev.to/) - Dove i programmatori condividono idee e si aiutano a crescere.
  * [Hashnode](https://hashnode.com/) — Software di blogging senza problemi per sviluppatori!
  * [Medium](https://medium.com/) — Rifletti di più su ciò che conta per te.
  * [AyeDot](https://ayedot.com/) — Condividi gratuitamente idee, conoscenze e storie con il mondo in formato Miniblog multimediale moderno.

**[⬆️ Torna all'inizio](#table-of-contents)**

## Piattaforme di Commenti
  * [GraphComment](https://graphcomment.com/) - GraphComment è una piattaforma di commenti che aiuta a costruire una comunità attiva dal pubblico del sito web.
  * [Utterances](https://utteranc.es/) - Widget di commenti leggero basato su GitHub issues. Usa GitHub issues per commenti su blog, pagine wiki e altro!
  * [Disqus](https://disqus.com/) - Disqus è una piattaforma comunitaria utilizzata da centinaia di migliaia di siti in tutto il web.
  * [Remarkbox](https://www.remarkbox.com/) - Piattaforma di commenti open source ospitata, paghi quanto vuoi per "Un moderatore su pochi domini con controllo completo su comportamento e aspetto"
  * [IntenseDebate](https://intensedebate.com/) - Sistema di commenti ricco di funzionalità per WordPress, Tumblr, Blogger e molte altre piattaforme.

**[⬆️ Torna all'inizio](#table-of-contents)**

## API per Screenshot

  * [ApiFlash](https://apiflash.com) — API per screenshot basata su AWS Lambda e Chrome. Gestisce pagine intere, tempi di acquisizione e dimensioni viewport.
  * [microlink.io](https://microlink.io/) – Trasforma qualsiasi sito web in dati come normalizzazione di metatag, anteprime link, capacità di scraping o screenshot come servizio. 250 richieste/giorno sempre gratuite.
  * [ScreenshotAPI.net](https://screenshotapi.net/) - API per screenshot che utilizza una semplice chiamata API per generare screenshot di qualsiasi sito web. Scalabile e ospitato su Google Cloud. Offre 100 screenshot gratuiti al mese.
  * [screenshotlayer.com](https://screenshotlayer.com/) — Cattura snapshot altamente personalizzabili di qualsiasi sito web. 100 snapshot/mese gratuiti
  * [screenshotmachine.com](https://www.screenshotmachine.com/) — Cattura 100 snapshot/mese, png, gif e jpg, inclusi screenshot a lunghezza intera, non solo della home page
  * [PhantomJsCloud](https://PhantomJsCloud.com) — Automazione browser e rendering pagine. Il piano gratuito offre fino a 500 pagine/giorno. Piano gratuito dal 2017.
  * [Webshrinker.com](https://webshrinker.com) — Web Shrinker fornisce screenshot di siti web e servizi API di intelligence dei domini. 100 richieste gratuite/mese.
  * [Screenshots](https://screenshotson.click) — API per screenshot con opzioni di cattura altamente personalizzabili. 100 screenshot gratuiti/mese.

**[⬆️ Torna all'inizio](#table-of-contents)**

## Flutter e Sviluppo di App iOS senza Mac

  * [FlutLab](https://flutlab.io/) - FlutLab è un IDE online moderno per Flutter e il posto migliore per creare, fare debug e build di progetti cross-platform. Crea app iOS (senza Mac) e Android con Flutter.
  * [CodeMagic](https://codemagic.io/) - Codemagic è un CI/CD completamente gestito per app mobile. Puoi buildare, testare e distribuire con uno strumento CI/CD basato su GUI. Il piano gratuito offre 500 minuti gratis/mese e una istanza Mac Mini con 2.3 GHz e 8 GB di RAM.
  * [FlutterFlow](https://flutterflow.io/) -  FlutterFlow è una interfaccia drag-and-drop via browser per costruire app mobile con Flutter.

**[⬆️ Torna all'inizio](#table-of-contents)**

## Emulazione hardware nel browser scritta in Javascript

  * [JsLinux](https://bellard.org/jslinux) — una macchina virtuale x86 molto veloce in grado di eseguire Linux e Windows 2k.
  * [Jor1k](https://s-macke.github.io/jor1k/demos/main.html) —  una macchina virtuale OpenRISC in grado di eseguire Linux con supporto di rete.
  * [v86](https://copy.sh/v86) — una macchina virtuale x86 in grado di eseguire Linux e altri sistemi operativi direttamente nel browser.

**[⬆️ Torna all'inizio](#table-of-contents)**

## Gestione della Privacy
  * [Bearer](https://www.bearer.sh/) - Aiuta a implementare la privacy by design tramite audit e workflow continui per rispettare GDPR e altre normative. Il piano gratuito è limitato a team piccoli e solo versione SaaS.
  * [Osano](https://www.osano.com/) - Piattaforma di gestione del consenso e conformità con tutto, dalla rappresentanza GDPR ai banner cookie. Il piano gratuito offre funzionalità base.
  * [Iubenda](https://www.iubenda.com/) - Policy privacy, cookie e gestione del consenso. Il piano gratuito offre policy privacy e cookie limitate oltre a banner cookie.
  * [Cookiefirst](https://cookiefirst.com/) - Soluzione per banner cookie, audit e gestione consenso multilingue. Il piano gratuito offre una scansione una tantum e un solo banner.
* [Ketch](https://www.ketch.com/) - Strumento per la gestione del consenso e della privacy. Il piano gratuito offre la maggior parte delle funzionalità con un numero limitato di visitatori.
* [Concord](https://www.concord.tech/) - Piattaforma completa per la privacy dei dati, inclusa la gestione del consenso, la gestione delle richieste di privacy (DSARs) e la mappatura dei dati. Il piano gratuito include le funzionalità principali di gestione del consenso e offrono anche un piano più avanzato gratuito per progetti open source verificati.

**[⬆️ Torna all'inizio](#table-of-contents)**

## Varie

* [BackgroundStyler.com](https://backgroundstyler.com) - Crea screenshot estetici del tuo codice, testo o immagini da condividere sui social media.
* [BinShare.net](https://binshare.net) - Crea e condividi codice o binari. Disponibile per la condivisione come una bella immagine (es. per post su Twitter / Facebook) o come link (es. per chat o forum).
* [Blynk](https://blynk.io) — SaaS con API per controllare, costruire e valutare dispositivi IoT. Piano Developer gratuito con 5 dispositivi, Cloud gratuito e storage dati. Disponibili anche App Mobile.
* [Bricks Note Calculator](https://free.getbricks.app/) - un'app per prendere appunti (PWA) con un potente calcolatore multilinea integrato.
* [Carbon.now.sh](https://carbon.now.sh) - crea e condividi frammenti di codice in formato immagine estetica simile a uno screenshot. Solitamente usato per condividere/mostrare frammenti di codice in modo estetico su Twitter o post di blog.
* [Code Time](https://www.software.com/code-time) - un'estensione per il monitoraggio del tempo e delle metriche di codifica in VS Code, Atom, IntelliJ, Sublime Text e altri.
* [Codepng](https://www.codepng.app) - Crea eccellenti snapshot dal tuo codice sorgente da condividere sui social media.
* [CodeToImage](https://codetoimage.com/) - Crea screenshot di codice o testo da condividere sui social media.
* [Cronhooks](https://cronhooks.io/) - Pianifica webhooks una tantum o ricorrenti. Il piano gratuito consente 5 pianificazioni ad-hoc.
* [cron-job.org](https://cron-job.org) - Servizio di cronjob online. Job illimitati gratuiti.
* [datelist.io](https://datelist.io) - Sistema di prenotazione / pianificazione appuntamenti online. Gratuito fino a 5 prenotazioni al mese, include 1 calendario.
* [Domain Forward](https://domain-forward.com/) - Uno strumento semplice per reindirizzare qualsiasi URL o Dominio. Gratis fino a 5 domini e 200k richieste al mese.
* [Elementor](https://elementor.com) — Website builder per WordPress. Piano gratuito disponibile con oltre 40 Widget di base.
* [Exif Editor](https://exifeditor.io/) — Visualizza, modifica, cancella, analizza i metadati di immagini/foto direttamente nel browser - inclusa la posizione GPS e i metadati.
* [Format Express](https://www.format-express.dev) - Formattazione istantanea online per JSON / XML / SQL.
* [FOSSA](https://fossa.com/) - Gestione scalabile e end-to-end per codice di terze parti, conformità delle licenze e vulnerabilità.
* [Hook Relay](https://www.hookrelay.dev/) - Aggiungi il supporto webhook alla tua app senza complicazioni: accodamento già pronto, retry con backoff e log. Il piano gratuito ha 100 consegne al giorno, retention di 14 giorni e 3 endpoint hook.
* [Hosting Checker](https://hostingchecker.co) - Verifica informazioni di hosting come ASN, ISP, posizione e altro per qualsiasi dominio, sito web o indirizzo IP. Include anche diversi strumenti relativi a hosting e DNS.
* [http2.pro](https://http2.pro) — Test di prontezza del protocollo HTTP/2 e API per il rilevamento del supporto client HTTP/2.
* [kandi](https://kandi.openweaver.com/) — Avvia rapidamente lo sviluppo di applicazioni: costruisci funzioni personalizzate, use case e applicazioni complete più velocemente attraverso snippet di codice e riuso di librerie open source.
* [Base64 decoder/encoder](https://devpal.co/base64-decode/) — Strumento online gratuito per decodifica e codifica di dati.
* [newreleases.io](https://newreleases.io) - Ricevi notifiche via email, Slack, Telegram, Discord e webhook personalizzati per nuove release da GitHub, GitLab, Bitbucket, Python PyPI, Java Maven, Node.js NPM, Node.js Yarn, Ruby Gems, PHP Packagist, .NET NuGet, Rust Cargo e Docker Hub.
* [OnlineExifViewer](https://onlineexifviewer.com/) — Visualizza immediatamente online i dati EXIF di una foto inclusa la posizione GPS e i metadati.
* [PDFMonkey](https://www.pdfmonkey.io/) — Gestisci modelli PDF da dashboard, chiama l'API con dati dinamici e scarica il tuo PDF. Offre 300 documenti gratuiti al mese.
* [Pika Code Screenshots](https://pika.style/templates/code-image) — Crea screenshot belli e personalizzabili da frammenti di codice e VSCode usando l'estensione.
* [QuickType.io](https://quicktype.io/) - Genera rapidamente in automatico modelli/classi/tipi/interfacce e serializer da JSON, schema e GraphQL per lavorare velocemente e in sicurezza con i dati in qualsiasi linguaggio di programmazione. Converti JSON in codice tipizzato e bello in qualsiasi linguaggio.
* [RandomKeygen](https://randomkeygen.com/) - Strumento gratuito mobile-friendly che offre una varietà di chiavi e password generate casualmente da usare per qualsiasi applicazione, servizio o dispositivo.
* [ray.so](https://ray.so/) - Crea bellissime immagini dei tuoi frammenti di codice.
* [readme.com](https://readme.com/) — Documentazione bella e facile, gratuita per Open Source.
* [redirection.io](https://redirection.io/) — SaaS per la gestione dei reindirizzamenti HTTP per aziende, marketing e SEO.
* [redirect.ing](https://redirect.ing/) - Forwarding di dominio veloce e sicuro senza gestire server o certificati SSL. Il piano gratuito include 10 hostname e 100.000 richieste al mese.
* [redirect.pizza](https://redirect.pizza/) - Gestisci facilmente i redirect con supporto HTTPS. Il piano gratuito include 10 sorgenti e 100.000 hit al mese.
* [ReqBin](https://reqbin.com/) — Invia richieste HTTP online. I metodi più usati includono GET, POST, PUT, DELETE e HEAD. Supporta Header e autenticazione tramite Token. Include un sistema di login base per salvare le tue richieste.
* [Smartcar API](https://smartcar.com) - API per auto per localizzare, ottenere livelli di carburante, batteria, contachilometri, sbloccare/bloccare porte, ecc.
* [snappify](https://snappify.com) - Permette agli sviluppatori di creare visual straordinari. Dai frammenti di codice belli a presentazioni tecniche complete. Il piano gratuito include fino a 3 snap contemporanei con download illimitati e 5 spiegazioni di codice alimentate da AI al mese.
* [Sunrise and Sunset](https://sunrisesunset.io/api/) - Ottieni orari di alba e tramonto per una data longitudine e latitudine.
* [superfeedr.com](https://superfeedr.com/) — Feed compatibili PubSubHubbub in tempo reale, export, analytics. Gratuito con meno personalizzazioni.
* [SurveyMonkey.com](https://www.surveymonkey.com) — Crea sondaggi online. Analizza i risultati online. Il piano gratuito consente solo 10 domande e 100 risposte per sondaggio.
* [Tiledesk](https://tiledesk.com) - Crea chatbot e app conversazionali. Portali omnicanale: dal tuo sito web (live chat widget) a WhatsApp. Piano gratuito con chatbot illimitati.
* [Versionfeeds](https://versionfeeds.com) — Feed RSS personalizzati per le release dei tuoi software preferiti. Tieni le ultime versioni dei tuoi linguaggi di programmazione, librerie o strumenti preferiti in un unico feed. (I primi 3 feed sono gratis)
* [videoinu](https://videoinu.com) — Crea ed edita registrazioni schermo e altri video online.
* [Webacus](https://webacus.dev) — Accedi a una vasta gamma di strumenti gratuiti per sviluppatori per codifica, decodifica e manipolazione dati.

**[⬆️ Torna all'inizio](#table-of-contents)**

## Strumenti Desktop Remoto

* [Getscreen.me](https://getscreen.me) — Gratuito per 2 dispositivi, nessun limite sul numero e durata delle sessioni
* [Apache Guacamole™](https://guacamole.apache.org/) — Gateway open source clientless per desktop remoto
* [RemSupp](https://remsupp.com) — Supporto on-demand e accesso permanente ai dispositivi (2 sessioni/giorno gratis)
* [RustDesk](https://rustdesk.com/) - Infrastruttura desktop virtuale/remoto open source per tutti!
* [AnyDesk](https://anydesk.com) — Gratuito per 3 dispositivi, nessun limite sul numero e durata delle sessioni

**[⬆️ Torna all'inizio](#table-of-contents)**

## Sviluppo Videogiochi

* [itch.io](https://itch.io/game-assets) — Asset gratuiti/a pagamento come sprite, tile set e pacchetti personaggi.
* [Gamefresco.com](https://gamefresco.com/) — Scopri, colleziona e condividi asset di gioco gratuiti da artisti di tutto il mondo.
* [GameDevMarket](https://gamedevmarket.net) — Asset gratuiti/a pagamento come 2D, 3D, Audio, GUI.
* [OpenGameArt](https://opengameart.org) — Asset di gioco OpenSource come musica, suoni, sprite e gif.
* [CraftPix](https://craftpix.net) — Asset gratuiti/a pagamento come 2D, 3D, Audio, GUI, sfondi, icone, tile set, game kit.
* [Game Icons](https://game-icons.net/) - Icone SVG/PNG stilizzabili gratuite fornite con licenza CC-BY.
* [LoSpec](https://lospec.com/) — Strumenti online per creare pixel art e altra arte digitale restrittiva, molti tutorial/lista palette disponibili tra cui scegliere per i tuoi giochi.
* [ArtStation](https://www.artstation.com/) - MarketPlace per asset 2D, 3D e audio gratuiti/a pagamento, icone, tile set, game kit. Può anche essere usato come portfolio artistico.
* [Rive](https://rive.app/community/) - Asset della community e possibilità di creare i tuoi asset di gioco utilizzando il piano gratuito.
* [Poly Pizza](https://poly.pizza/) - Asset 3D low poly gratuiti
* [3Dassets.one](https://3dassets.one/) - Oltre 8.000 modelli 3D e materiali PBR gratuiti/a pagamento per creare texture.
* [Kenney](https://www.kenney.nl/assets/) - Asset di gioco 2D, 3D, Audio e UI gratuiti (licenza CC0 1.0 Universal).
* [Poliigon](https://www.poliigon.com/) - Texture gratuite e a pagamento (con risoluzione variabile), modelli, HDRI e pennelli. Offre plugin gratuiti per esportazione verso software come Blender.
* [Freesound](https://freesound.org/) - Libreria collaborativa di suoni gratuita offerta con diverse licenze CC.

**[⬆️ Torna all'inizio](#table-of-contents)**

## Altre Risorse Gratuite

* [Wikimint Developer](https://developer.wikimint.com/p/tools.html) - Strumenti sempre gratuiti per sviluppatori web tra cui minificazione/unminificazione CSS, ottimizzatore immagini, ridimensionatore immagini, convertitore maiuscole/minuscole, validatore CSS, compilatore JavaScript, editor HTML, ecc.
* [ElevateAI](https://www.elevateai.com) - Fino a 200 ore di trascrizione audio gratuite ogni mese.
* [get.localhost.direct](https://get.localhost.direct) — Un miglior certificato SSL Wildcard pubblico CA firmato per sviluppo localhost con supporto sub-dominio per `*.localhost.direct`
* [Framacloud](https://degooglisons-internet.org/en/) — Elenco di Software e SaaS Free/Libre Open Source della non-profit francese [Framasoft](https://framasoft.org/en/).
* [github.com — FOSS for Dev](https://github.com/tvvocold/FOSS-for-Dev) — Hub di software gratuito e Open Source per sviluppatori.
* [GitHub Education](https://education.github.com/pack) — Raccolta di servizi gratuiti per studenti. Registrazione richiesta.
* [Markdown Tools](https://markdowntools.com) - Strumenti per convertire HTML, CSV, PDF, JSON ed Excel da e verso Markdown
* [Microsoft 365 Developer Program](https://developer.microsoft.com/microsoft-365/dev-program) — Ottieni una sandbox gratuita, strumenti e altre risorse per costruire soluzioni sulla piattaforma Microsoft 365. L'abbonamento è un [Microsoft 365 E5 Subscription](https://www.microsoft.com/microsoft-365/enterprise/e5) di 90 giorni (Windows escluso) rinnovabile. Il rinnovo avviene se sei attivo nello sviluppo (misurato tramite dati di telemetria e algoritmi).
* [Pyrexp](https://pythonium.net/regex) — Tester e visualizzatore regex web-based gratuito per il debug di espressioni regolari.
* [RedHat for Developers](https://developers.redhat.com) — Accesso gratuito ai prodotti Red Hat inclusi RHEL, OpenShift, CodeReady, ecc. esclusivamente per sviluppatori. Solo piano individuale. Disponibili anche e-book gratuiti.
* [smsreceivefree.com](https://smsreceivefree.com/) — Fornisce numeri di telefono temporanei e usa e getta gratuitamente.
* [sandbox.httpsms.com](https://sandbox.httpsms.com) — Invia e ricevi SMS di test gratuitamente.
* [SimpleBackups.com](https://simplebackups.com/) — Servizio di automazione backup per server e database (MySQL, PostgreSQL, MongoDB) archiviati direttamente in cloud storage provider (AWS, DigitalOcean, Backblaze). Piano gratuito per 1 backup.
* [SnapShooter](https://snapshooter.com/) — Soluzione di backup per DigitalOcean, AWS, LightSail, Hetzner ed Exoscale, con supporto per backup diretti di database, file system e applicazioni su storage tipo s3. Piano gratuito con backup giornaliero per una risorsa.
* [Themeselection](https://themeselection.com/) — Template dashboard admin, temi HTML e UI Kit selezionati di alta qualità, dal design moderno, professionali e facili da usare per creare applicazioni più velocemente!
* [Web.Dev](https://web.dev/measure/) — Strumento gratuito che ti permette di vedere le prestazioni del tuo sito web e migliorare la SEO per ottenere un posizionamento migliore nei motori di ricerca.


  * [SmallDev.tools](https://smalldev.tools/) — Uno strumento gratuito per sviluppatori che consente di codificare/decodificare vari formati, minimizzare HTML/CSS/Javascript, abbellire, generare dati falsi/di test in JSON/CSV e molti altri formati e molte altre funzionalità. Con un'interfaccia piacevole.
  * [UseCSV by Layercode](https://layercode.com/usecsv) — Aggiungi l'importazione di CSV ed Excel alla tua app web in pochi minuti. Offri ai tuoi utenti un'esperienza di importazione dati piacevole e robusta. Inizia gratuitamente senza bisogno di carta di credito e integra UseCSV oggi stesso. Puoi creare importatori illimitati e caricare file fino a 100Mb.
  * [Buttons Generator](https://markodenic.com/tools/buttons-generator/) — Oltre 100 pulsanti che puoi utilizzare nel tuo progetto.
  * [WrapPixel](https://www.wrappixel.com/) — Scarica template di dashboard admin di alta qualità, gratuiti e premium, creati con Angular, React, VueJs, NextJS e NuxtJS!
  * [Utils.fun](https://utils.fun/en) — Tutti gli strumenti offline per uso quotidiano e sviluppo basati sulla potenza di calcolo del browser, tra cui generazione di watermark, registrazione dello schermo, codifica e decodifica, crittografia e decrittografia, e formattazione del codice, sono completamente gratuiti e non caricano alcun dato sul cloud per l'elaborazione.
  * [It tools](it-tools.tech) - Strumenti utili per sviluppatori e persone che lavorano nell'IT.
  * [Free Code Tools](https://freecodetools.org/) — Strumenti di codice efficaci e 100% gratuiti. Editor Markdown, minificatore/abbellitore di codice, generatore di codici QR, generatore di Open Graph, generatore di Twitter card e altro ancora.
  * [regex101](https://regex101.com/) — Gratuito, questo sito ti permette di testare e fare debug delle espressioni regolari (regex). Fornisce un editor e un tester per regex, oltre a documentazione e risorse utili per imparare le regex.
  * [Kody Tools](https://www.kodytools.com/dev-tools) — Oltre 100 strumenti per sviluppatori tra cui formatter, minificatore e convertitore.
  * [AdminMart](https://adminmart.com/) — Template di dashboard admin e siti web di alta qualità, gratuiti e premium, creati con Angular, Bootstrap, React, VueJs, NextJS e NuxtJS!
  * [Glob tester](https://globster.xyz/) — Un sito web che permette di progettare e testare pattern glob. Offre anche risorse per imparare i pattern glob.
  * [SimpleRestore](https://simplerestore.io) - Ripristino backup MySQL senza complicazioni. Ripristina backup MySQL su qualsiasi database remoto senza codice o server.
  * [360Converter](https://www.360converter.com/) - Livello gratuito, sito utile per convertire: Video in Testo && Audio in Testo && Voce in Testo && Audio in Tempo Reale in Testo && Video YouTube in Testo && aggiunta di sottotitoli ai video. Può essere utile per una breve conversione video o in un breve tutorial su YouTube:)
  * [QRCodeBest](https://qrcode.best/) - Crea codici QR personalizzati con 13 template, privacy totale e branding personale. Funzionalità di tracciamento pixel, categorizzazione progetti e posti team illimitati su QRCode.Best.
  * [PostPulse](https://PostPulseAI.com) - Migliora la tua presenza online, potenzia la SEO e il posizionamento del sito con post mensili creati dall'AI su domini ottimizzati per la SEO. Il piano gratuito consente di pubblicare manualmente un post al mese sul nostro sito.
  * [PageTools](https://pagetools.co/) - Offre una suite di strumenti AI gratuiti per sempre per aiutarti a generare policy essenziali per siti web, creare bio, post e pagine web per i social media con un'interfaccia semplice e con un solo clic.
  * [MySQL Visual Explain](https://mysqlexplain.com) - Visualizzatore gratuito e di facile comprensione dell'output di MySQL EXPLAIN per ottimizzare le query lente.
  * [Killer Coda](https://killercoda.com/)  - Playground interattivo nel tuo browser per studiare Linux, Kubernetes, Container, Programmazione, DevOps, Networking.
  * [Axonomy App](https://axonomy-app.com/) - Strumento gratuito per creare, gestire e condividere le tue fatture con i clienti. 10 fatture gratuite al mese.
  * [Table Format Converter](https://www.tableformatconverter.com) - Strumento gratuito per convertire dati tabellari in diversi formati, come CSV, HTML, JSON, Markdown e altro.


**[⬆️ Torna all'inizio](#table-of-contents)**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---
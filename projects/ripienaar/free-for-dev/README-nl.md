# free-for.dev

Ontwikkelaars en Open Source-auteurs hebben tegenwoordig veel diensten die gratis niveaus aanbieden, maar ze allemaal vinden kost tijd om weloverwogen beslissingen te nemen.

Dit is een lijst van software (SaaS, PaaS, IaaS, enz.) en andere aanbiedingen met gratis ontwikkelaarsniveaus.

De reikwijdte van deze specifieke lijst is beperkt tot zaken die infrastructuurontwikkelaars (systeembeheerders, DevOps-praktijkmensen, enz.) waarschijnlijk nuttig zullen vinden. We zijn dol op alle gratis diensten die er zijn, maar het is goed om het bij het onderwerp te houden. Soms is het een grijs gebied, dus deze lijst is subjectief; voel je alsjeblieft niet beledigd als ik je bijdrage niet accepteer.

Deze lijst is het resultaat van Pull Requests, reviews, ideeën en werk van meer dan 1600 mensen. Je kunt ook helpen door [Pull Requests](https://github.com/ripienaar/free-for-dev) te sturen om meer diensten toe te voegen of om diensten te verwijderen waarvan het aanbod is veranderd of beëindigd.

[![Track Awesome List](https://www.trackawesomelist.com/badge.svg)](https://www.trackawesomelist.com/ripienaar/free-for-dev)

**OPMERKING**: Deze lijst is alleen voor as-a-Service aanbiedingen, niet voor zelf-gehoste software. Om in aanmerking te komen, moet een dienst een gratis laag aanbieden, niet alleen een gratis proefperiode. De gratis laag moet minimaal een jaar geldig zijn als deze tijdsgebonden is. We bekijken het gratis niveau ook vanuit een beveiligingsperspectief, dus SSO is prima, maar ik accepteer geen diensten die TLS beperken tot alleen betaalde niveaus.

# Inhoudsopgave

  * [Altijd-gratis limieten van grote cloudproviders](#major-cloud-providers)
  * [Cloudbeheeroplossingen](#cloud-management-solutions)
  * [Analytics, Events en Statistieken](#analytics-events-and-statistics)
  * [API's, Data en ML](#apis-data-and-ml)
  * [Artifact Repos](#artifact-repos)
  * [BaaS](#baas)
  * [Low-code Platform](#low-code-platform)
  * [CDN en Bescherming](#cdn-and-protection)
  * [CI en CD](#ci-and-cd)
  * [CMS](#cms)
  * [Codegeneratie](#code-generation)
  * [Codekwaliteit](#code-quality)
  * [Code zoeken en bladeren](#code-search-and-browsing)
  * [Crash- en Exceptieafhandeling](#crash-and-exception-handling)
  * [Datavisualisatie op Kaarten](#data-visualization-on-maps)
  * [Beheerde Dataservices](#managed-data-services)
  * [Design en UI](#design-and-ui)
  * [Design Inspiratie](#design-inspiration)
  * [Dev Blogging Sites](#dev-blogging-sites)
  * [DNS](#dns)
  * [Docker gerelateerd](#docker-related)
  * [Domein](#domain)
  * [Onderwijs en Carrièreontwikkeling](#education-and-career-development)
  * [E-mail](#email)
  * [Feature Toggle Management Platforms](#feature-toggles-management-platforms)
  * [Lettertype](#font)
  * [Formulieren](#forms)
  * [Generatieve AI](#generative-ai)
  * [IaaS](#iaas)
  * [IDE en Code Editing](#ide-and-code-editing)
  * [Internationale mobiele nummer verificatie API en SDK](#international-mobile-number-verification-api-and-sdk)
  * [Issue Tracking en Projectmanagement](#issue-tracking-and-project-management)
  * [Logbeheer](#log-management)
  * [Distributie en Feedback van Mobiele Apps](#mobile-app-distribution-and-feedback)
  * [Beheersystemen](#management-system)
  * [Berichten en Streaming](#messaging-and-streaming)
  * [Diversen](#miscellaneous)
  * [Monitoring](#monitoring)
  * [PaaS](#paas)
  * [Package Build System](#package-build-system)
  * [Betalings- en Facturatie-integratie](#payment-and-billing-integration)
  * [Privacybeheer](#privacy-management)
  * [Screenshot-API's](#screenshot-apis)
  * [Flutter gerelateerd en iOS-apps bouwen zonder Mac](#flutter-related-and-building-ios-apps-without-mac)
  * [Zoeken](#search)
  * [Beveiliging en PKI](#security-and-pki)
  * [Authenticatie, Autorisatie en Gebruikersbeheer](#authentication-authorization-and-user-management)
  * [Source Code Repos](#source-code-repos)
  * [Opslag en Mediaverwerking](#storage-and-media-processing)
  * [Tunneling, WebRTC, Web Socket Servers en Overige Routers](#tunneling-webrtc-web-socket-servers-and-other-routers)
  * [Testen](#testing)
  * [Tools voor Teams en Samenwerking](#tools-for-teams-and-collaboration)
  * [Vertaalbeheer](#translation-management)
  * [Vagrant gerelateerd](#vagrant-related)
  * [Opnemen van Bezoeker Sessies](#visitor-session-recording)
  * [Webhosting](#web-hosting)
  * [Commentaarplatforms](#commenting-platforms)
  * [Browser gebaseerde hardware-emulatie](#browser-based-hardware-emulation-written-in-javascript)
  * [Remote Desktop Tools](#remote-desktop-tools)
  * [Gameontwikkeling](#game-development)
  * [Overige gratis bronnen](#other-free-resources)

## Grote Cloudproviders

  * [Google Cloud Platform](https://cloud.google.com)
    * App Engine - 28 frontend instance-uren per dag, negen backend instance-uren per dag
    * Cloud Firestore - 1GB opslag, 50.000 reads, 20.000 writes, 20.000 deletes per dag
    * Compute Engine - 1 non-preemptible e2-micro, 30GB HDD, 5GB snapshot-opslag (beperkt tot bepaalde regio's), 1 GB netwerk-egress van Noord-Amerika naar alle regiobestemmingen (exclusief China en Australië) per maand
    * Cloud Storage - 5GB, 1GB netwerk-egress
    * Cloud Shell - Webgebaseerde Linux-shell/hoofd-IDE met 5GB permanente opslag. 60 uur limiet per week
    * Cloud Pub/Sub - 10GB aan berichten per maand
    * Cloud Functions - 2 miljoen invocaties per maand (inclusief zowel achtergrond- als HTTP-invocaties)
    * Cloud Run - 2 miljoen verzoeken per maand, 360.000 GB-seconden geheugen, 180.000 vCPU-seconden rekentijd, 1 GB netwerk-egress van Noord-Amerika per maand
    * Google Kubernetes Engine - Geen clustermanagementkosten voor één zonale cluster. Elke gebruikersnode wordt in rekening gebracht tegen standaard Compute Engine-tarieven
    * BigQuery - 1 TB aan queries per maand, 10 GB opslag per maand
    * Cloud Build - 120 build-minuten per dag
    * Cloud Source Repositories - Tot 5 gebruikers, 50 GB opslag, 50 GB egress
    * [Google Colab](https://colab.research.google.com/) - Gratis Jupyter Notebooks ontwikkelomgeving.
    * [Firebase Studio](https://firebase.studio) Google Firebase Studio (voorheen Project IDX). Online VSCode draaiend op Google Cloud.
    * Volledige, gedetailleerde lijst - https://cloud.google.com/free

  * [Amazon Web Services](https://aws.amazon.com)
    * [CloudFront](https://aws.amazon.com/cloudfront/) - 1TB egress per maand en 2M functie-invocaties per maand
    * [CloudWatch](https://aws.amazon.com/cloudwatch/) - 10 aangepaste statistieken en tien alarmen
* [CodeBuild](https://aws.amazon.com/codebuild/) - 100 minuten bouwtijd per maand
* [CodeCommit](https://aws.amazon.com/codecommit/) - 5 actieve gebruikers, 50GB opslag, en 10.000 verzoeken per maand
* [CodePipeline](https://aws.amazon.com/codepipeline/) - 1 actieve pipeline per maand
* [DynamoDB](https://aws.amazon.com/dynamodb/) - 25GB NoSQL DB
* [EC2](https://aws.amazon.com/ec2/) - 750 uur per maand van t2.micro of t3.micro (12 maanden). 100GB uitgaand verkeer per maand
* [EBS](https://aws.amazon.com/ebs/) - 30GB per maand aan General Purpose (SSD) of Magnetic (12 maanden)
* [Elastic Load Balancing](https://aws.amazon.com/elasticloadbalancing/) - 750 uur per maand (12 maanden)
* [RDS](https://aws.amazon.com/rds/) - 750 uur per maand van db.t2.micro, db.t3.micro of db.t4g.micro, 20GB General Purpose (SSD) opslag, 20GB opslagback-ups (12 maanden)
* [S3](https://aws.amazon.com/s3/) - 5GB Standard objectopslag, 20K Get-verzoeken en 2K Put-verzoeken (12 maanden)
* [Glacier](https://aws.amazon.com/glacier/) - 10GB langetermijn objectopslag
* [Lambda](https://aws.amazon.com/lambda/) - 1 miljoen verzoeken per maand
* [SNS](https://aws.amazon.com/sns/) - 1 miljoen publicaties per maand
* [SES](https://aws.amazon.com/ses/) - 3.000 berichten per maand (12 maanden)
* [SQS](https://aws.amazon.com/sqs/) - 1 miljoen messaging queue-verzoeken
* Volledige, gedetailleerde lijst - https://aws.amazon.com/free/

* [Microsoft Azure](https://azure.microsoft.com)
  * [Virtual Machines](https://azure.microsoft.com/services/virtual-machines/) - 1 B1S Linux VM, 1 B1S Windows VM (12 maanden)
  * [App Service](https://azure.microsoft.com/services/app-service/) - 10 web-, mobiele of API-apps (60 CPU-minuten/dag)
  * [Functions](https://azure.microsoft.com/services/functions/) - 1 miljoen verzoeken per maand
  * [DevTest Labs](https://azure.microsoft.com/services/devtest-lab/) - Snel, eenvoudig en efficiënt dev-testomgevingen mogelijk maken
  * [Active Directory](https://azure.microsoft.com/services/active-directory/) - 500.000 objecten
  * [Active Directory B2C](https://azure.microsoft.com/services/active-directory/external-identities/b2c/) - 50.000 maandelijks opgeslagen gebruikers
  * [Azure DevOps](https://azure.microsoft.com/services/devops/) - 5 actieve gebruikers, onbeperkte privé Git-repo's
  * [Azure Pipelines](https://azure.microsoft.com/services/devops/pipelines/) — 10 gratis parallelle jobs met onbeperkte minuten voor open source voor Linux, macOS en Windows
  * [Microsoft IoT Hub](https://azure.microsoft.com/services/iot-hub/) - 8.000 berichten per dag
  * [Load Balancer](https://azure.microsoft.com/services/load-balancer/) - 1 gratis publiek load-balanced IP (VIP)
  * [Notification Hubs](https://azure.microsoft.com/services/notification-hubs/) - 1 miljoen pushmeldingen
  * [Bandwidth](https://azure.microsoft.com/pricing/details/bandwidth/) - 15GB inkomend (12 maanden) & 5GB uitgaand per maand
  * [Cosmos DB](https://azure.microsoft.com/services/cosmos-db/) - 25GB opslag en 1000 RUs aan geprovisioneerde throughput
  * [Static Web Apps](https://azure.microsoft.com/pricing/details/app-service/static/) — Bouw, implementeer en host statische apps en serverless functies met gratis SSL, authenticatie/autorisatie en aangepaste domeinen
  * [Storage](https://azure.microsoft.com/services/storage/) - 5GB LRS File of Blob-opslag (12 maanden)
  * [Cognitive Services](https://azure.microsoft.com/services/cognitive-services/) - AI/ML API's (Computer Vision, Translator, Gezichtsdetectie, Bots, enz.) met gratis laag inclusief beperkte transacties
  * [Cognitive Search](https://azure.microsoft.com/services/search/#features) - AI-gebaseerde zoek- en indexeringsdienst, gratis voor 10.000 documenten
  * [Azure Kubernetes Service](https://azure.microsoft.com/services/kubernetes-service/) - Managed Kubernetes-dienst, gratis clusterbeheer
  * [Event Grid](https://azure.microsoft.com/services/event-grid/) - 100K operaties/maand
  * Volledige, gedetailleerde lijst - https://azure.microsoft.com/free/

* [Oracle Cloud](https://www.oracle.com/cloud/)
  * Compute
     - 2 AMD-gebaseerde Compute VM's met elk 1/8 OCPU en 1 GB geheugen
     - 4 Arm-gebaseerde Ampere A1 cores en 24 GB geheugen, te gebruiken als één VM of tot 4 VM's
     - Instanties worden teruggenomen wanneer [inactief geacht](https://docs.oracle.com/en-us/iaas/Content/FreeTier/freetier_topic-Always_Free_Resources.htm#compute__idleinstances)
  * Block Volume - 2 volumes, 200 GB totaal (voor compute)
  * Object Storage - 10 GB
  * Load balancer - 1 instantie met 10 Mbps
  * Databases - 2 DB's, elk 20 GB
  * Monitoring - 500 miljoen ingest datapoints, 1 miljard retrieval datapoints
  * Bandbreedte - 10 TB uitgaand per maand, snelheid beperkt tot 50 Mbps op x64-gebaseerde VM, 500 Mbps * aantal cores op ARM-gebaseerde VM
  * Publiek IP - 2 IPv4 voor VM's, 1 IPv4 voor load balancer
  * Notificaties - 1 miljoen leveringsopties per maand, 1.000 verzonden e-mails per maand
  * Volledige, gedetailleerde lijst - https://www.oracle.com/cloud/free/

* [IBM Cloud](https://www.ibm.com/cloud/free/)
  * Cloudant database - 1 GB dataopslag
  * Db2 database - 100MB dataopslag
  * API Connect - 50.000 API-calls per maand
  * Availability Monitoring - 3 miljoen datapunten per maand
  * Log Analysis - 500MB aan logbestanden per dag
  * Volledige, gedetailleerde lijst - https://www.ibm.com/cloud/free/

* [Cloudflare](https://www.cloudflare.com/)
  * [Application Services](https://www.cloudflare.com/plans/) - Gratis DNS voor een onbeperkt aantal domeinen, DDoS-bescherming, CDN inclusief gratis SSL, firewallregels en paginaregels, WAF, Bot Mitigation, gratis onbeperkte Rate Limiting - 1 regel per domein, Analytics, E-mail forwarding
  * [Zero Trust & SASE](https://www.cloudflare.com/plans/zero-trust-services/) - Tot 50 gebruikers, 24 uur activiteitslogging, drie netwerklocaties
  * [Cloudflare Tunnel](https://www.cloudflare.com/products/tunnel/) - Je kunt een lokaal draaiende HTTP-poort via een tunnel naar een willekeurig subdomein op trycloudflare.com exposen met [Quick Tunnels](https://developers.cloudflare.com/cloudflare-one/connections/connect-networks/do-more-with-tunnels/trycloudflare/), geen account vereist. Meer functies (TCP-tunnel, Load balancing, VPN) in [Zero Trust](https://www.cloudflare.com/products/zero-trust/) Free Plan.
  * [Workers](https://developers.cloudflare.com/workers/) - Serverless code gratis uitrollen op Cloudflare's wereldwijd netwerk—100k verzoeken per dag.
  * [Workers KV](https://developers.cloudflare.com/kv) - 100k leesverzoeken per dag, 1000 schrijfverzoeken per dag, 1000 verwijderverzoeken per dag, 1000 lijstverzoeken per dag, 1 GB opgeslagen data
  * [R2](https://developers.cloudflare.com/r2/) - 10 GB per maand, 1 miljoen Klasse A-operaties per maand, 10 miljoen Klasse B-operaties per maand
  * [D1](https://developers.cloudflare.com/d1/) - 5 miljoen rijen gelezen per dag, 100k rijen geschreven per dag, 1 GB opslag
  * [Pages](https://developers.cloudflare.com/pages/) - Ontwikkel en implementeer je webapps op Cloudflare’s snelle, veilige wereldwijde netwerk. Vijfhonderd builds per maand, 100 aangepaste domeinen, geïntegreerde SSL, onbeperkt aantal toegankelijke plekken, onbeperkte preview deployments en full-stack mogelijkheden via Cloudflare Workers-integratie.
  * [Queues](https://developers.cloudflare.com/queues/) - 1 miljoen operaties per maand
  * [TURN](https://developers.cloudflare.com/calls/turn/) – 1TB gratis (uitgaand) verkeer per maand.

**[⬆️ Terug naar boven](#table-of-contents)**

## Cloud management oplossingen

* [Brainboard](https://www.brainboard.co) - Collaboratieve oplossing om cloudinfrastructuren visueel van end-to-end te bouwen en te beheren.
* [Cloud 66](https://www.cloud66.com/) - Gratis voor persoonlijke projecten (inclusief één deployment server, één statische site), Cloud 66 biedt alles wat je nodig hebt om applicaties te bouwen, uit te rollen en te laten groeien op elke cloud zonder het gedoe van "serverzaken".
* [Pulumi](https://www.pulumi.com/) — Moderne infrastructuur-als-code platform waarmee je vertrouwde programmeertalen en tools kunt gebruiken om cloudinfrastructuur te bouwen, uit te rollen en te beheren.
* [terraform.io](https://www.terraform.io/) — Terraform Cloud. Gratis remote state management en samenwerking voor teams tot 500 resources.
* [scalr.com](https://scalr.com/) - Scalr is een Terraform Automation en Collaboration (TACO) product voor betere samenwerking en automatisering van infrastructuur en configuraties beheerd door Terraform. Volledige Terraform CLI-ondersteuning, OPA-integratie en een hiërarchisch configuratiemodel. Geen SSO-belasting. Alle functies inbegrepen. Tot 50 runs/maand gratis.
* [deployment.io](https://deployment.io) - Deployment.io helpt ontwikkelaars met het automatiseren van deployments op AWS. In onze gratis laag kan een ontwikkelaar (enkele gebruiker) onbeperkt statische sites, webservices en omgevingen uitrollen. We bieden 20 gratis job-uitvoeringen per maand inclusief previews en auto-deploys in de gratis laag.

**[⬆️ Terug naar boven](#table-of-contents)**

## Source Code Repos

* [Bitbucket](https://bitbucket.org/) — Onbeperkte publieke en privé Git-repo's voor maximaal 5 gebruikers, inclusief Pipelines voor CI/CD
* [chiselapp.com](https://chiselapp.com/) — Onbeperkte publieke en privé Fossil-repositories
* [codebasehq.com](https://www.codebasehq.com/) — Eén gratis project met 100 MB ruimte en twee gebruikers
* [Codeberg](https://codeberg.org/) — Onbeperkte publieke en privé Git-repo's voor vrije en open-source projecten (met onbeperkt aantal medewerkers). Gebaseerd op [Forgejo](https://forgejo.org/). Statische website-hosting met [Codeberg Pages](https://codeberg.page/). CI/CD-hosting met [Codeberg's CI](https://docs.codeberg.org/ci/). Vertaalhosting met [Codeberg Translate](https://translate.codeberg.org/). Inclusief Package en Container hosting, projectmanagement en issue tracking
* [GitGud](https://gitgud.io) — Onbeperkte privé en publieke repositories. Gratis voor altijd. Gebaseerd op GitLab & Sapphire. CI/CD niet inbegrepen.
* [GitHub](https://github.com/) — Onbeperkte publieke repositories en onbeperkte privérepositories (met onbeperkt aantal medewerkers). Inclusief CI/CD, ontwikkelomgeving, statische hosting, package- en containerhosting, projectmanagement en AI Copilot
* [gitlab.com](https://about.gitlab.com/) — Onbeperkte publieke en privé Git-repo's met maximaal 5 medewerkers. Inclusief CI/CD, statische hosting, container registry, projectmanagement en issue tracking
* [framagit.org](https://framagit.org/) — Framagit is het softwareforge-platform van Framasoft gebaseerd op de Gitlab-software, inclusief CI, statische pagina's, projectpagina's en issue tracking.
* [heptapod.net](https://foss.heptapod.net/) — Heptapod is een vriendelijke fork van GitLab Community Edition met ondersteuning voor Mercurial
* [ionicframework.com](https://ionicframework.com/appflow) - Repo en tools om applicaties te ontwikkelen met Ionic; je hebt ook een ionic repo
* [NotABug](https://notabug.org) — NotABug.org is een gratis code-samenwerkingsplatform voor vrij gelicentieerde projecten, gebaseerd op Git
* [OSDN](https://osdn.net/) - OSDN.net is een gratis dienst voor open-source softwareontwikkelaars en biedt SVN/Git/Mercurial/Bazaar/CVS repositories.


  * [Pagure.io](https://pagure.io) — Pagure.io is een gratis en open source software code samenwerkingplatform voor FOSS-gelicentieerde projecten, Git-gebaseerd
  * [perforce.com](https://www.perforce.com/products/helix-teamhub) — Gratis 1GB Cloud en Git-, Mercurial- of SVN-repositories.
  * [pijul.com](https://pijul.com/) - Onbeperkt gratis en open source gedistribueerd versiebeheersysteem. Het onderscheidende kenmerk is gebaseerd op een degelijke theorie van patches, wat het makkelijk maakt om te leren, gebruiken en distribueren. Lost veel problemen van git/hg/svn/darcs op.
  * [plasticscm.com](https://plasticscm.com/) — Gratis voor individuen, OSS, en non-profitorganisaties
  * [projectlocker.com](https://projectlocker.com) — Eén gratis privéproject (Git en Subversion) met 50 MB opslagruimte
  * [RocketGit](https://rocketgit.com) — Repository Hosting gebaseerd op Git. Onbeperkt publieke en privé repositories.
  * [savannah.gnu.org](https://savannah.gnu.org/) - Dient als een collaboratief softwareontwikkelingsbeheersysteem voor vrije softwareprojecten (voor GNU-projecten)
  * [savannah.nongnu.org](https://savannah.nongnu.org/) - Dient als een collaboratief softwareontwikkelingsbeheersysteem voor vrije softwareprojecten (voor niet-GNU-projecten)

**[⬆️ Terug naar boven](#table-of-contents)**

## API's, Data en ML

  * [JSONGrid](https://jsongrid.com) - Gratis tool om complexe JSON-data te visualiseren, bewerken en filteren in een mooie tabelraster. Sla JSON-data op en deel deze via een link.
  * [Zerosheets](https://zerosheets.com) - Maak van je Google Sheets krachtige API's om snel prototypes, websites, apps en meer te ontwikkelen. 500 verzoeken per maand gratis beschikbaar.
  * [IP.City](https://ip.city) — 100 gratis IP-geolocatieverzoeken per dag
  * [Abstract API](https://www.abstractapi.com) — API-suite voor verschillende toepassingen, waaronder IP-geolocatie, geslachtsdetectie of e-mailvalidatie.
  * [Apify](https://www.apify.com/) — Web scraping en automatiseringsplatform om een API voor elke website te maken en data te extraheren. Kant-en-klare scrapers, geïntegreerde proxies, en maatwerkoplossingen. Gratis plan met elke maand $5 platformtegoed.
  * [APITemplate.io](https://apitemplate.io) - Genereer automatisch afbeeldingen en PDF-documenten met een eenvoudige API of automatiseringstools zoals Zapier & Airtable. Geen CSS/HTML vereist. Het gratis plan bevat 50 afbeeldingen/maand en drie sjablonen.
  * [APIToolkit.io](https://apitoolkit.io) - Alle tools die je nodig hebt om volledig te begrijpen wat er gebeurt in je API's en backends. Met automatische API-contractvalidatie en monitoring. Het gratis plan dekt servers tot 10.000 verzoeken per dag.
  * [APIVerve](https://apiverve.com) - Krijg direct toegang tot meer dan 120+ API's gratis, gebouwd met kwaliteit, consistentie en betrouwbaarheid in gedachten. Het gratis plan dekt tot 50 API-tokens per maand. (Mogelijk offline gehaald, 2025-06-25)
  * [Arize AI](https://arize.com/) - Machine learning observability voor modelmonitoring en het achterhalen van problemen zoals datakwaliteit en prestatieverschuiving. Gratis tot twee modellen.
  * [Maxim AI](https://getmaxim.ai/) - Simuleer, evalueer en observeer je AI-agents. Maxim is een end-to-end evaluatie- en observatieplatform dat teams helpt hun AI-agents betrouwbaar en >5x sneller uit te rollen. Altijd gratis voor indie-ontwikkelaars en kleine teams (3 stoelen).
  * [Beeceptor](https://beeceptor.com) - Mock een rest API in seconden, nep-API-antwoorden en veel meer. Gratis 50 verzoeken per dag, openbaar dashboard, open endpoints (iedereen met een dashboardlink kan inzendingen en antwoorden bekijken).
  * [BigDataCloud](https://www.bigdatacloud.com/) - Biedt snelle, nauwkeurige en gratis (Onbeperkt of tot 10K-50K/maand) API's voor moderne webtoepassingen zoals IP-geolocatie, reverse geocoding, netwerk inzichten, e-mail- en telefoonvalidatie, clientinfo en meer.
  * [Browse AI](https://www.browse.ai) — Data extraheren en monitoren van het web. 1k credits per maand gratis, gelijk aan 1k gelijktijdige verzoeken.
  * [BrowserCat](https://www.browsercat.com) - Headless browser API voor automatisering, scraping, webtoegang door AI-agents, afbeelding/pdf-generatie en meer. Gratis plan met 1k verzoeken per maand.
  * [Calendarific](https://calendarific.com) - Enterprise-grade feestdagen-API-service voor meer dan 200 landen. Het gratis plan omvat 500 oproepen per maand.
  * [Canopy](https://www.canopyapi.co/) - GraphQL API voor Amazon.com-product-, zoek- en categoriedata. Het gratis plan omvat 100 oproepen per maand.
  * [Clarifai](https://www.clarifai.com) — Afbeeldings-API voor aangepaste gezichtsherkenning en detectie. Mogelijkheid tot trainen van AI-modellen. Het gratis plan heeft 1.000 oproepen per maand.
  * [Cloudmersive](https://cloudmersive.com/) — Utility API-platform met volledige toegang tot uitgebreide API-bibliotheek inclusief documentconversie, viruscontrole en meer met 600 oproepen/maand, alleen Noord-Amerika AZ, 2,5MB maximale bestandsgrootte.
  * [Colaboratory](https://colab.research.google.com) — Gratis webgebaseerde Python-notebookomgeving met Nvidia Tesla K80 GPU.
  * [CometML](https://www.comet.com/site/) - Het MLOps-platform voor experimenttracking, modelproductiebeheer, modelregistratie en volledige datalijn, van training tot productie. Gratis voor individuen en academici.
  * [Commerce Layer](https://commercelayer.io) - Composable commerce-API die orders kan bouwen, plaatsen en beheren vanaf elke frontend. Het ontwikkelaarsplan staat 100 bestellingen per maand toe en tot 1.000 SKU's gratis.
  * [Composio](https://composio.dev/) - Integratieplatform voor AI-agents en LLM's. Integreer meer dan 200+ tools over het agentische internet.
  * [Conversion Tools](https://conversiontools.io/) - Online bestandsconverter voor documenten, afbeeldingen, video, audio en eBooks. REST API beschikbaar. Libraries voor Node.js, PHP, Python. Ondersteunt bestanden tot 50 GB (voor betaalde plannen). De gratis laag is beperkt door bestandsgrootte (20MB) en aantal conversies (30/dag, 300/maand).
  * [Country-State-City Microservice API](https://country-state-city.rebuscando.info/) - API en microservice die een breed scala aan informatie biedt, waaronder landen, regio's, provincies, steden, postcodes en meer. De gratis laag omvat tot 100 verzoeken per dag.
  * [Coupler](https://www.coupler.io/) - Dataintegratietool die synchroniseert tussen apps. Kan live dashboards en rapporten maken, waarden transformeren en manipuleren, en inzichten verzamelen en back-uppen. Het gratis plan is beperkt tot één gebruiker, dataverbinding, databron en datadoel. Vereist ook handmatige data-refresh.
  * [CraftMyPDF](https://craftmypdf.com) - Automatisch PDF-documenten genereren uit herbruikbare sjablonen met een drag-and-drop editor en een eenvoudige API. Het gratis plan bevat 100 PDF's/maand en drie sjablonen.
  * [Crawlbase](https://crawlbase.com/) — Crawlen en scrapen van websites zonder proxies, infrastructuur of browsers. Wij lossen captchas voor je op en voorkomen blokkering. De eerste 1000 oproepen zijn gratis.
  * [CurlHub](https://curlhub.io) — Proxyservice voor het inspecteren en debuggen van API-aanroepen. Het gratis plan omvat 10.000 verzoeken per maand.
  * [CurrencyScoop](https://currencyscoop.com) - Realtime valuta-data-API voor fintech-apps. Het gratis plan bevat 5.000 oproepen per maand.
  * [Cube](https://cube.dev/) - Cube helpt data engineers en applicatieontwikkelaars toegang te krijgen tot data uit moderne datastores, deze te organiseren in consistente definities en te leveren aan elke applicatie. De snelste manier om Cube te gebruiken is met Cube Cloud, dat een gratis laag heeft tot 1.000 queries per dag.
  * [Data Dead Drop](https://datadeaddrop.com) - Simpel, gratis bestandendelen. Data vernietigt zichzelf na toegang. Upload en download data via de browser of je favoriete commandoregeltool.
  * [Data Fetcher](https://datafetcher.com) - Verbind Airtable met elke applicatie of API zonder code. Postman-achtige interface voor het uitvoeren van API-verzoeken in Airtable. Voorgebouwde integraties met tientallen apps. Het gratis plan omvat 100 runs per maand.
  * [Dataimporter.io](https://www.dataimporter.io) - Tool voor het verbinden, opschonen en importeren van data in Salesforce. Gratis plan omvat tot 20.000 records per maand.
  * [Datalore](https://datalore.jetbrains.com) - Python-notebooks van Jetbrains. Inclusief 10 GB opslag en 120 uur runtime per maand.
  * [Data Miner](https://dataminer.io/) - Een browserextensie (Google Chrome, MS Edge) voor data-extractie van webpagina's naar CSV of Excel. Het gratis plan geeft je 500 pagina's/maand.
  * [Datapane](https://datapane.com) - API voor het bouwen van interactieve rapporten in Python en het uitrollen van Python-scripts en Jupyter Notebooks als selfservice-tools.
  * [DB-IP](https://db-ip.com/api/free) - Gratis IP-geolocatie-API met 1k verzoeken per IP per dag. Lite-database onder de CC-BY 4.0-licentie is ook gratis.
  * [DB Designer](https://www.dbdesigner.net/) — Cloudgebaseerde database-schema ontwerp- en modelleringstool met een gratis starterplan van 2 databasemodellen en tien tabellen per model.
  * [DeepAR](https://developer.deepar.ai) — Augmented reality gezichtsfilters voor elk platform met één SDK. Het gratis plan biedt tot 10 maandelijkse actieve gebruikers (MAU) en volgt maximaal 4 gezichten.
  * [Deepnote](https://deepnote.com) - Een nieuw data science-notebook. Jupyter-compatibel, met realtime samenwerking en in de cloud draaiend. De gratis laag omvat onbeperkte persoonlijke projecten, onbeperkte basis-machines met 5GB RAM en 2vCPU, en teams tot 3 editors.
  * [Disease.sh](https://disease.sh/) — Een gratis API die accurate data levert voor het bouwen van nuttige Covid-19-apps.
  * [Doczilla](https://www.doczilla.app/) — SaaS API die het genereren van screenshots of PDF's rechtstreeks vanuit HTML/CSS/JS-code mogelijk maakt. Het gratis plan staat 250 documenten per maand toe.
  * [Doppio](https://doppio.sh/) — Beheerde API om PDF's en screenshots te genereren en privé op te slaan met de nieuwste renderingtechnologie. Het gratis plan staat 400 PDF's en screenshots per maand toe.
  * [drawDB](https://drawdb.app/) — Gratis en open-source online database-dagrameditor zonder registratie vereist.
  * [dreamfactory.com](https://dreamfactory.com/) — Open source REST API-backend voor mobiele, web- en IoT-applicaties. Koppel elke SQL/NoSQL-database, bestandsopslagsysteem of externe service en het maakt direct een uitgebreid REST API-platform met live documentatie en gebruikersbeheer.
  * [Duply.co](https://duply.co) — Maak dynamische afbeeldingen vanuit API & URL, ontwerp één sjabloon en hergebruik deze. De gratis laag biedt 20 credits.
  * [DynamicDocs](https://advicement.io) - Genereer PDF-documenten met JSON-naar-PDF API op basis van LaTeX-sjablonen. Het gratis plan staat 50 API-calls per maand toe en toegang tot een sjabloonbibliotheek.
  * [Efemarai](https://efemarai.com) - Test- en debugplatform voor ML-modellen en data. Visualiseer elke computationele grafiek. Gratis lokaal gebruik.
  * [ERD Lab](https://www.erdlab.io) —  Gratis cloudgebaseerde entiteit-relatiediagram (ERD) tool gemaakt voor ontwikkelaars. Gratis proef bevat 2 projecten met 10 tabellen elk.
  * [ExtendsClass](https://extendsclass.com/rest-client-online.html) - Gratis webgebaseerde HTTP-client om HTTP-verzoeken te verzenden.
  * [Export SDK](https://exportsdk.com) - PDF-generator-API met drag-and-drop sjablooneditor die een SDK en no-code integraties biedt. Het gratis plan heeft 250 pagina's per maand, onbeperkte gebruikers en drie sjablonen.
  * [file.coffee](https://file.coffee/) - Een platform waar je tot 15MB/bestand kunt opslaan (30/MB bestand met een account).
  * [Financial Data](https://financialdata.net/) - Aandelenmarkt en financiële data-API. Gratis plan staat 300 verzoeken per dag toe.
  * [FormatJSONOnline.com](https://formatjsononline.com) - Een gratis, browsergebaseerde tool om JSON-data direct te formatteren, valideren, vergelijken en te minimaliseren.
  * [FraudLabs Pro](https://www.fraudlabspro.com) — Screen een ordertransactie op creditcardbetalingsfraude. Deze REST API detecteert alle mogelijke fraudekenmerken op basis van de ingevoerde orderparameters. Het gratis Micro-plan heeft 500 transacties per maand.
  * [GeoDataSource](https://www.geodatasource.com) — Locatiezoekservice zoekt stadsnamen op met behulp van breedte- en lengtegraadcoördinaten. Gratis API-verzoeken tot 500 keer per maand.
  * [Geolocated.io](https://geolocated.io) — IP-geolocatie-API met multi-continent servers, biedt een gratis plan met 2.000 verzoeken per dag.
  * [Glitterly](https://glitterly.app/) - Programmeerbaar dynamische afbeeldingen genereren uit basissjablonen. Restful API en nocode-integraties. De gratis laag komt met 50 afbeeldingen/maand en vijf sjablonen.
  * [Hex](https://hex.tech/) - Een collaboratief dataplatform voor notebooks, data-apps en kennisbibliotheken. Gratis communitylaag met tot vijf projecten.
  * [Hook0](https://www.hook0.com/) - Hook0 is een open-source Webhooks-as-a-service (WaaS) die het eenvoudig maakt voor online producten om webhooks aan te bieden. Verstuur tot 100 events/dag met zeven dagen historisch behoud gratis.
  * [Hoppscotch](https://hoppscotch.io) - Een gratis, snelle en mooie API-request builder.
  * [huggingface.co](https://huggingface.co) - Bouw, train en deploy NLP-modellen voor Pytorch, TensorFlow en JAX. Gratis tot 30k invoertekens/maand.
  * [Hybiscus](https://hybiscus.dev/) - Bouw pdf-rapporten met een eenvoudige declaratieve API. De 14-daagse gratis laag bevat 50 eenpagina-rapporten met de mogelijkheid om kleurpaletten en lettertypen aan te passen.
  * [Invantive Cloud](https://cloud.invantive.com/) — Toegang tot meer dan 70 (cloud)platformen zoals Exact Online, Twinfield, ActiveCampaign of Visma met Invantive SQL of OData4 (typisch Power BI of Power Query). Inclusief datareplicatie en -uitwisseling. Gratis plan voor ontwikkelaars en implementatieconsultants. Gratis voor specifieke platforms met beperkingen in datavolumes.
  * [ipaddress.sh](https://ipaddress.sh) — Eenvoudige service om een publiek IP-adres in verschillende [formaten](https://about.ipaddress.sh/) te verkrijgen.
  * [ip-api](https://ip-api.com) — IP-geolocatie-API, gratis voor niet-commercieel gebruik, geen API-sleutel vereist, beperkt tot 45 verzoeken/minuut vanaf hetzelfde IP-adres voor het gratis plan.
  * [ipbase.com](https://ipbase.com) - IP-geolocatie-API - Altijd gratis plan dat 150 maandelijkse verzoeken omvat.
  * [IP Geolocation](https://ipgeolocation.io/) — IP-geolocatie-API - Altijd gratis plan voor ontwikkelaars met een limiet van 1.000 verzoeken per dag.
  * [IP Geolocation API](https://www.abstractapi.com/ip-geolocation-api) — IP-geolocatie-API van Abstract - Staat 1.000 gratis verzoeken toe.
  * [IPLocate](https://www.iplocate.io) — IP-geolocatie-API, gratis tot 1.000 verzoeken/dag. Inclusief proxy/VPN/hostingdetectie, ASN-data, IP naar bedrijf en meer. IPLocate biedt ook gratis downloadbare IP-naar-land en IP-naar-ASN databases in CSV of GeoIP-compatibel MMDB-formaat.
  * [IP2Location](https://www.ip2location.com) — Freemium IP-geolocatieservice. LITE-database is gratis te downloaden. Importeer de database op de server en voer een lokale query uit om stad, coördinaten en ISP-informatie te bepalen.
  * [IP2Location.io](https://www.ip2location.io/) — Freemium, snelle en betrouwbare IP-geolocatie-API. Verkrijg gegevens zoals stad, coördinaten, ISP en meer. Het gratis plan omvat 50k credits per maand. IP2Location.io biedt ook 500 gratis WHOIS- en gehoste domeinopzoekingen per maand. Bekijk domeinregistratiegegevens en vind domeinen die op een specifiek IP worden gehost. Upgrade naar een betaald plan voor meer functies.
  * [ipapi](https://ipapi.co/) - IP-adreslocatie-API door Kloudend, Inc - Een betrouwbare geolocatie-API gebouwd op AWS, vertrouwd door Fortune 500. De gratis laag biedt 30k opzoekingen/maand (1k/dag) zonder registratie.
  * [ipapi.is](https://ipapi.is/) - Een betrouwbare IP-adres-API van ontwikkelaars voor ontwikkelaars met de beste hostingdetectie-mogelijkheden die er bestaan. Het gratis plan biedt 1000 opzoekingen zonder registratie.
  * [IPinfo](https://ipinfo.io/) — Snel, nauwkeurig en gratis (tot 50k/maand) IP-adres data API. Biedt API's met details over geolocatie, bedrijven, carriers, IP-reeksen, domeinen, abuse-contacten en meer. Alle betaalde API's kunnen gratis getest worden.
  * [IPQuery](https://ipquery.io) — Onbeperkte IP-API voor ontwikkelaars, geen ratelimits of prijzen.
  * [IPTrace](https://iptrace.io) — Een extreem eenvoudige API die je bedrijf betrouwbare en bruikbare IP-geolocatiedata biedt met 50.000 gratis opzoekingen per maand.
  * [JSON2Video](https://json2video.com) - Een video-editing API om videomarketing en sociale mediavideo's te automatiseren, programmeerbaar of zonder code.
  * [JSON IP](https://getjsonip.com) — Geeft het publieke IP-adres terug van de client waar het verzoek vandaan komt. Geen registratie vereist voor de gratis laag. Met CORS kan data direct met client-side JS uit de browser worden opgevraagd. Handig voor diensten die wijzigingen in client- en server-IP's monitoren. Onbeperkte verzoeken.
  * [JSON Serve](https://jsonserve.com/) — Een gratis dienst waarmee ontwikkelaars JSON-objecten kunnen opslaan en deze JSON als een REST API in hun app kunnen gebruiken.
  * [JSONing](https://jsoning.com/api/) — Maak een nep-REST API van een JSON-object, en pas HTTP-statuscodes, headers en response-bodies aan.
  * [konghq.com](https://konghq.com/) — API-marktplaats en krachtige private en publieke API-tools. Met de gratis laag zijn sommige functies zoals monitoring, waarschuwingen en support beperkt.
  * [Kreya](https://kreya.app) — Gratis gRPC GUI-client om gRPC API's aan te roepen en te testen. Kan gRPC API's importeren via serverreflectie.
  * [Lightly](https://www.lightly.ai/) — Verbeter je machine learning-modellen door de juiste data te gebruiken. Gebruik datasets tot 1000 samples gratis.
  * [LoginLlama](https://loginllama.app) - Een loginbeveiligings-API om frauduleuze en verdachte logins te detecteren en je klanten te waarschuwen. Gratis voor 1.000 logins per maand.
  * [MailboxValidator](https://www.mailboxvalidator.com) — E-mailverificatieservice die een echte mailserververbinding gebruikt om een geldig e-mailadres te bevestigen. Het gratis API-plan heeft 100 verificaties per maand.
  * [Market Data API](https://www.marketdata.app) - Biedt realtime en historische financiële data voor aandelen, opties, beleggingsfondsen en meer. De Free Forever API-laag staat 100 dagelijkse API-verzoeken gratis toe.
* [Meteosource Weather API](https://www.meteosource.com/) — globale weer-API voor actuele en voorspelde weersgegevens. Voorspellingen zijn gebaseerd op een machine learning-combinatie van meerdere weermodellen voor betere nauwkeurigheid. Het gratis plan bevat 400 oproepen per dag.
* [microlink.io](https://microlink.io/) – Zet elke website om in data zoals het normaliseren van metatags, mooie linkvoorbeelden, scraping-mogelijkheden of screenshots als een dienst. 50 verzoeken per dag, elke dag gratis.
* [Mindee](https://developers.mindee.com) – Mindee is krachtige OCR-software en een API-first platform dat ontwikkelaars helpt applicatieworkflows te automatiseren door de documentverwerkingslaag te standaardiseren via gegevensherkenning van kerninformatie met behulp van computer vision en machine learning. De gratis laag biedt 500 pagina’s per maand.
* [Mintlify](https://mintlify.com) — Moderne standaard voor API-documentatie. Mooie en eenvoudig te onderhouden UI-componenten, in-app zoekfunctie en interactieve playground. Gratis voor 1 editor.
* [MockAPI](https://www.mockapi.io/) — MockAPI is een eenvoudige tool waarmee je snel APIs kunt mocken, aangepaste data kunt genereren en bewerkingen kunt uitvoeren via een RESTful interface. MockAPI is bedoeld als een prototyping/test/leerhulpmiddel. Eén project/2 resources per project gratis.
* [Mockfly](https://www.mockfly.dev/) — Mockfly is een betrouwbare ontwikkeltool voor API-mocking en feature flag management. Genereer en beheer snel mock APIs met een intuïtieve interface. Het gratis plan biedt 500 verzoeken per dag.
* [Mocki](https://mocki.io) - Een tool waarmee je mock GraphQL en REST APIs maakt die gesynchroniseerd zijn met een GitHub-repository. Simpele REST APIs zijn gratis te ontwikkelen en te gebruiken zonder aanmelding.
* [Mocko.dev](https://mocko.dev/) — Proxy je API, kies welke endpoints je in de cloud wilt mocken en inspecteer het verkeer, gratis. Versnel je ontwikkeling en integratietests.
* [Mocky](https://designer.mocky.io/) - Een eenvoudige webapp om aangepaste HTTP-responses te genereren voor het mocken van HTTP-verzoeken. Ook beschikbaar als [open source](https://github.com/julien-lafont/Mocky).
* [Mock N Roll](https://mpcknroll.me/) - Gratis Mocks API-service—een krachtig hulpmiddel om echte API-responses te simuleren zonder backend-vertragingen. Perfect voor frontend-ontwikkelaars, QA-testers en DevOps-teams. [repo](https://github.com/haerulmuttaqin/mocknroll-web).
* [microenv.com](https://microenv.com) —  Maak een neppe REST API voor ontwikkelaars met de mogelijkheid om code en app te genereren in een docker-container.
* [Multi-Exit IP Address Checker](https://ip.alstra.ca/) —  Een gratis en eenvoudige tool om je exit-IP-adres te controleren op meerdere nodes en te begrijpen hoe je IP verschijnt voor verschillende wereldwijde regio’s en diensten. Handig voor het testen van DNS-splittingtools op basis van regels, zoals Control D.
* [Namekit](https://namekit.app/) - AI-gestuurde domeinontdekking – vind direct beschikbare, standaardprijsnamen. Gratis dagelijkse zoekopdrachten.
* [News API](https://newsapi.org) — Zoek nieuws op het web met code en ontvang JSON-resultaten. Ontwikkelaars krijgen elke dag 100 gratis zoekopdrachten. Artikelen hebben een vertraging van 24 uur.
* [numlookupapi.com](https://numlookupapi.com) - Gratis telefoonnummer validatie API - 100 gratis verzoeken / maand.
* [OCR.Space](https://ocr.space/) — Een OCR-API die afbeelding- en pdf-bestanden verwerkt en de tekstresultaten retourneert in JSON-formaat. 25.000 verzoeken per maand gratis en een bestandsgrootte limiet van 1MB.
* [OpenAPI3 Designer](https://openapidesigner.com/) — Visueel gratis Open API 3-definities maken.
* [parsehub.com](https://parsehub.com/) — Gegevens halen uit dynamische sites, verander dynamische websites in APIs, vijf projecten gratis.
* [Parseur](https://parseur.com) — 20 gratis pagina’s/maand: Gegevens halen uit PDF’s, e-mails. AI-gestuurd. Volledige API-toegang.
* [PDFBolt](https://pdfbolt.com) - Ontwikkelaarsgerichte PDF-generatie-API, ontworpen met privacy in gedachten. Biedt Stripe-geïnspireerde documentatie en omvat 500 gratis PDF-conversies per maand.
* [pdfEndpoint.com](https://pdfendpoint.com) - Zet HTML of URLs eenvoudig om naar PDF met een simpele API. Honderd conversies per maand gratis.
* [PDF-API.io](https://pdf-api.io) - PDF-automatiserings-API, visuele sjablooneditor of HTML naar PDF, dynamische data-integratie en PDF-rendering via een API. Het gratis plan heeft één sjabloon, 100 PDFs/maand.
* [Pixela](https://pixe.la/) - Gratis daystream databaseservice. Alle handelingen worden uitgevoerd via de API. Visualisatie met heatmaps en lijngrafieken is ook mogelijk.
* [Postman](https://postman.com) — Vereenvoudig workflows en maak betere APIs – sneller – met Postman, een samenwerkingsplatform voor API-ontwikkeling. Gebruik de Postman App gratis voor altijd. Postman cloudfuncties zijn ook gratis voor altijd met bepaalde limieten.
* [Insomnia](https://insomnia.rest) - Open-source API-client voor het ontwerpen en testen van APIs, ondersteunt REST en GraphQL.
* [PrefectCloud](https://www.prefect.io/cloud/) — Een compleet platform voor dataflow-automatisering. Gratis plan omvat 5 gedeployde workflows en 500 minuten serverless compute credits per maand.
* [Preset Cloud](https://preset.io/) - Een gehoste Apache Superset-service. Altijd gratis voor teams tot 5 gebruikers, met onbeperkte dashboards en grafieken, een no-code grafiekbouwer en een collaboratieve SQL-editor.
* [PromptLoop](https://www.promptloop.com/) - PromptLoop levert 10X eenvoudigere AI-webscraping met vrijwel geen adoptietijd, 85%+ tijdsbesparing op bestaande workflows, werkt 4X sneller dan handmatig onderzoek zonder compromissen en bevat een REST API-endpoint voor alle onderzoekstaken. De eerste 1.000 credits zijn elke maand gratis.
* [Public-Apis Github Repo](https://github.com/public-apis/public-apis) — Een lijst met gratis openbare APIs.
* [Rapidapi](https://rapidapi.com/) - ’s Werelds grootste API-hub Miljoenen ontwikkelaars vinden en verbinden met duizenden APIs, API-ontwikkeling met leuke uitdagingen (met oplossingen!) en interactieve voorbeelden.
* [RequestBin.com](https://requestbin.com) — Maak een gratis endpoint waarnaar je HTTP-verzoeken kunt sturen. Alle HTTP-verzoeken die naar dat endpoint worden gestuurd, worden geregistreerd met de bijbehorende payload en headers, zodat je aanbevelingen van webhooks en andere diensten kunt observeren.
* [reqres.in](https://reqres.in) - Een gratis gehoste REST-API, klaar om te reageren op jouw AJAX-verzoeken.
* [Roboflow](https://roboflow.com) - Maak en implementeer een aangepast computer vision-model zonder eerdere machine learning-ervaring. De gratis laag omvat 30 credits per maand.
* [ROBOHASH](https://robohash.org/) - Webdienst om unieke en coole afbeeldingen te genereren van elke tekst.
* [Scraper's Proxy](https://scrapersproxy.com) — Simpele HTTP-proxy-API voor scraping. Scrape anoniem zonder je zorgen te maken over beperkingen, blokkades of captchas. De eerste 100 succesvolle scrapes per maand gratis, inclusief javascript-rendering (meer mogelijk als je contact opneemt met support).
* [ScrapingAnt](https://scrapingant.com/) — Headless Chrome scraping-API en gratis gecontroleerde proxyservice. Javascript-rendering, premium roterende proxies, CAPTCHAs vermijden. Gratis 10.000 API-credits.
* [Simplescraper](https://simplescraper.io) — Trigger je webhook na elke operatie. Het gratis plan bevat 100 cloud scrape credits.
* [Select Star](https://www.selectstar.com/) - is een intelligent datadiscoverieplatform dat automatisch je data analyseert en documenteert. Gratis lichte laag met 2 Data Sources, tot 1.000 tabellen en 25 gebruikers.
* [Sheetson](https://sheetson.com) - Zet direct elke Google Sheet om in een RESTful API. Gratis plan beschikbaar, inclusief 1.000 gratis rijen per sheet.
* [Shipyard](https://www.shipyardapp.com) — Low-code data orchestratieplatform voor de cloud. Bouw met een mix van low-code templates en je eigen code (Python, Node.js, Bash, SQL). Ons gratis ontwikkelaarsplan biedt 10 uur runtime per maand voor één gebruiker - ruim voldoende om meerdere workflows te automatiseren.
* [Siterelic](https://siterelic.com/) - Siterelic API laat je screenshots maken, websites auditen, TLS-scan, DNS-lookup, TTFB-testen en meer. Het gratis plan biedt 100 API-verzoeken per maand.
* [SerpApi](https://serpapi.com/) - Real-time zoekmachinescraping-API. Geeft gestructureerde JSON-resultaten voor Google, YouTube, Bing, Baidu, Walmart en vele andere machines. Het gratis plan omvat 100 succesvolle API-calls per maand.
* [SmartParse](https://smartparse.io) - SmartParse is een datamigratie- en CSV-naar-API-platform dat tijdbesparende en kostenbesparende ontwikkelaarstools biedt. De gratis laag omvat 300 Processing Units per maand, browseruploads, dataquarantaine, circuit breakers en job alerts.
* [Sofodata](https://www.sofodata.com/) - Maak veilige RESTful APIs van CSV-bestanden. Upload een CSV-bestand en krijg direct toegang tot de data via de API, waardoor snellere applicatieontwikkeling mogelijk is. Het gratis plan omvat 2 APIs en 2.500 API-calls per maand. Geen creditcard nodig.
* [Sqlable](https://sqlable.com/) - Een verzameling gratis online SQL-tools, waaronder een SQL-formatter en validator, SQL-regex-tester, nepdatagenerator en interactieve database-playgrounds.
* [Stoplight](https://stoplight.io/) - SaaS voor het gezamenlijk ontwerpen en documenteren van APIs. Het gratis plan biedt gratis ontwerp-, mocking- en documentatietools.
* [Supportivekoala](https://supportivekoala.com/) — Maakt het mogelijk om automatisch afbeeldingen te genereren via je invoer en sjablonen. Het gratis plan laat je tot 50 afbeeldingen per maand maken.
* [Svix](https://www.svix.com/) - Webhooks as a Service. Verstuur tot 50.000 berichten/maand gratis.
* [Tavily AI](https://tavily.com/) - API voor online zoeken en snelle inzichten en uitgebreid onderzoek, met de mogelijkheid om onderzoeksresultaten te organiseren. 1000 verzoeken/maand voor de gratis laag, geen creditcard nodig.
* [The IP API](https://theipapi.com/) - IP-geolocatie-API met 1000 gratis verzoeken/dag. Geeft informatie over de locatie van een IP-adres, inclusief land, stad, regio en meer.
* [TinyMCE](https://www.tiny.cloud) - Rich text editing API. Kernfuncties zijn gratis voor onbeperkt gebruik.
* [Tomorrow.io Weather API](https://www.tomorrow.io/weather-api/) - Biedt een gratis plan voor weer-API. Levert nauwkeurige en up-to-date weersvoorspellingen met wereldwijde dekking, historische data en weermonitoringsoplossingen.
* [Treblle](https://www.treblle.com) - Treblle helpt teams bij het bouwen, leveren en beheren van APIs. Met geavanceerde API-logaggregatie, observability, documentatie en debugging. Je krijgt alle functies gratis, maar er is een limiet van maximaal 250k verzoeken per maand op het gratis niveau.
* [UniRateAPI](https://unirateapi.com) – Real-time wisselkoersen voor 590+ valuta’s en crypto. Onbeperkte API-calls op het gratis plan, perfect voor ontwikkelaars en financiële apps.
* [vatcheckapi.com](https://vatcheckapi.com) - Eenvoudige en gratis BTW-nummer validatie-API. 150 gratis validaties per maand.
* [WeatherXu](https://weatherxu.com/) — Wereldwijde weerdata inclusief actuele omstandigheden, uur- en dagvoorspellingen, en weerwaarschuwingen via onze API. Integratie van AI-modellen en ML-systemen om meerdere weermodellen te analyseren en combineren voor verbeterde nauwkeurigheid. Gratis laag omvat 10.000 API-calls/maand.
* [Webhook Store](https://www.openwebhook.io) - Tool voor het opslaan van webhooks van derden en het debuggen ervan op localhost (ngrok-stijl). Open source en zelf-hostbaar. Gratis persoonlijk domein *gebruikersnaam*.github.webhook.store, gratis publieke domeinen *anything*.webhook.store.
* [WebScraping.AI](https://webscraping.ai) - Eenvoudige Web Scraping API met ingebouwde parsing, Chrome-rendering en proxies. Tweeduizend gratis API-calls per maand.
* [Weights & Biases](https://wandb.ai) — Het ontwikkelaar-eerst MLOps-platform. Bouw betere modellen sneller met experimenttracking, datasetversiebeheer en modelbeheer. Gratis laag alleen voor persoonlijke projecten, met 100 GB opslag inbegrepen.
* [What The Diff](https://whatthediff.ai) - AI-gestuurde code review assistant. Het gratis plan heeft een limiet van 25.000 maandelijkse tokens (~10 PR’s).
* [wolfram.com](https://wolfram.com/language/) — Ingebouwde kennisgebaseerde algoritmen in de cloud.
* [wrapapi.com](https://wrapapi.com/) — Maak van elke website een geparametriseerde API. 30k API-calls per maand.
* [Zenscrape](https://zenscrape.com/web-scraping-api) — Web scraping API met headless browsers, residentiële IP’s en overzichtelijke prijzen. Duizend gratis API-calls/maand en extra credits voor studenten en non-profits.
* [Zipcodebase](https://zipcodebase.com) - Gratis Zip Code API, toegang tot wereldwijde postcodegegevens. 5.000 gratis verzoeken/maand.
* [Zipcodestack](https://zipcodestack.com) - Gratis Zip Code API en postcodevalidatie. Tienduizend gratis verzoeken/maand.
* [Zuplo](https://zuplo.com/) - Gratis API Management platform om APIs te ontwerpen, bouwen en uit te rollen naar de Edge. Voeg API Key-authenticatie, rate limiting, ontwikkelaarsdocumentatie en monetisatie toe aan elke API in enkele minuten. OpenAPI-native en volledig programmeerbaar met webstandaard APIs & Typescript. Het gratis plan biedt tot 10 projecten, onbeperkte productie edge-omgevingen, 1M maandelijkse verzoeken en 10GB egress.

**[⬆️ Terug naar boven](#table-of-contents)**

## Artifact Repos

* [Artifactory](https://jfrog.com/start-free/) - Een artifact repository die tal van pakketformaten ondersteunt zoals Maven, Docker, Cargo, Helm, PyPI, CocoaPods en GitLFS. Inclusief package scanning tool XRay en CI/CD-tool Pipelines (voorheen Shippable) met een gratis laag van 2.000 CI/CD-minuten per maand.
* [central.sonatype.org](https://central.sonatype.org) — De standaard artifact repository voor Apache Maven, SBT en andere buildsystemen.
* [cloudrepo.io](https://cloudrepo.io) - Cloudgebaseerde, private en publieke Maven- en PyPi-repositories. Gratis voor open-sourceprojecten.
* [cloudsmith.io](https://cloudsmith.io) — Eenvoudige, veilige en gecentraliseerde repositorydienst voor Java/Maven, RedHat, Debian, Python, Ruby, Vagrant en meer. Gratis laag + gratis voor open source.
* [jitpack.io](https://jitpack.io/) — Maven-repository voor JVM- en Android-projecten op GitHub, gratis voor publieke projecten.
* [packagecloud.io](https://packagecloud.io/users/new?plan=free_usage_plan) — Gebruiksvriendelijke repository-hosting voor Maven, RPM, DEB, PyPi, NPM en RubyGem-pakketten (heeft gratis laag).
* [repsy.io](https://repsy.io) — 1 GB gratis private/publieke Maven-repository.
* [Gemfury](https://gemfury.com) — Private en publieke artifact-repos voor Maven, PyPi, NPM, Go Module, Nuget, APT en RPM-repositories. Gratis voor publieke projecten.
* [paperspace](https://www.paperspace.com/) — Bouw & schaal AI-modellen, ontwikkel, train en implementeer AI-applicaties, gratis plan: publieke projecten, 5Gb opslag, basisinstanties.
* [RepoForge](https://repoforge.io) - Private cloud-gehoste repository voor Python-, Debian-, NPM-pakketten en Docker-registries. Gratis plan voor open source/publieke projecten.
* [RepoFlow](https://repoflow.io) - RepoFlow vereenvoudigt package management met ondersteuning voor npm, PyPI, Docker, Go, Helm en meer. Probeer het gratis met 10GB opslag, 10GB bandbreedte, 100 pakketten en onbeperkt aantal gebruikers in de cloud, of zelf-gehost alleen voor persoonlijk gebruik.

**[⬆️ Terug naar boven](#table-of-contents)**

## Tools voor Teams en Samenwerking
* [3Cols](https://3cols.com/) - Een gratis cloudgebaseerde code snippet manager voor persoonlijk en samenwerkend gebruik.
* [Bitwarden](https://bitwarden.com) — De makkelijkste en veiligste manier voor individuen, teams en organisaties om gevoelige gegevens op te slaan, te delen en te synchroniseren.
* [Braid](https://www.braidchat.com/) — Chat-app ontworpen voor teams. Gratis voor publieke groepsaccess, onbeperkte gebruikers, geschiedenis en integraties. Ook beschikbaar als zelf-hostbare open-sourceversie.
* [cally.com](https://cally.com/) — Vind de perfecte tijd en datum voor een vergadering. Eenvoudig in gebruik, werkt uitstekend voor kleine en grote groepen.
* [Calendly](https://calendly.com) — Calendly is de tool voor het verbinden en plannen van vergaderingen. Het gratis plan biedt 1 agenda-koppeling per gebruiker en onbeperkte sessies. Desktop- en mobiele apps zijn ook beschikbaar.
* [Discord](https://discord.com/) — Chatten met publieke/private kamers. Markdown-tekst, spraak, video en schermdeelmogelijkheden. Gratis voor onbeperkt aantal gebruikers.
* [Fibo](https://fibo.dev) - Een gratis online realtime scrum poker-tool voor agile teams waarmee onbeperkt leden story points kunnen inschatten voor snellere planning.
* [Telegram](https://telegram.org/) — Telegram is voor iedereen die snel, betrouwbaar wil berichten en bellen. Zakelijke gebruikers en kleine teams zullen de grote groepen, gebruikersnamen, desktopapps en krachtige bestandsdeelopties waarderen.
* [DevToolLab](https://devtoollab.com) — Online ontwikkelaarstools met gratis toegang tot alle basisfuncties, de mogelijkheid om één invoer per tool automatisch op te slaan, standaard verwerkingssnelheid en community-ondersteuning.
* [Dubble](https://dubble.so/) — Gratis stapsgewijze gidsmaker. Maak screenshots, documenteer processen en werk samen met je team. Ondersteunt ook asynchrone schermopname.
* [Duckly](https://duckly.com/) — Praat en werk samen in realtime met je team. Pair programming met IDE, terminaldeling, spraak-, video- en schermdeling. Gratis voor kleine teams.
* [Dyte](https://dyte.io) - De meest ontwikkelaarsvriendelijke live video & audio SDK, met collaboratieve plugins om productiviteit en betrokkenheid te vergroten. Het gratis plan omvat maandelijks 10.000 minuten live video/audio-gebruik.
* [evernote.com](https://evernote.com/) — Tool voor het organiseren van informatie. Deel je notities en werk samen met anderen.
* [Fibery](https://fibery.io/) — Connected workspace-platform. Gratis voor individuele gebruikers, tot 2 GB schijfruimte.
* [flock.com](https://flock.com) — Een snellere manier voor je team om te communiceren. Gratis onbeperkt berichten, kanalen, gebruikers, apps & integraties
* [Gather](https://www.gather.town/) - Een betere manier om online te vergaderen. Gericht op volledig aanpasbare ruimtes, maakt Gather het doorbrengen van tijd met je communities net zo eenvoudig als in het echte leven. Gratis voor maximaal 10 gelijktijdige gebruikers.
* [gokanban.io](https://gokanban.io) - Syntaxis-gebaseerd, geen registratie Kanban-bord voor snel gebruik. Gratis zonder beperkingen.
* [flat.social](https://flat.social) - Interactieve aanpasbare ruimtes voor teamvergaderingen & sociale borrels. Onbeperkte vergaderingen, gratis tot 8 gelijktijdige gebruikers.
* [GitDailies](https://gitdailies.com) - Dagelijkse rapporten van de Commit- en Pull Request-activiteit van je team op GitHub. Inclusief Push-visualizer, peer recognition system en custom alert builder. De gratis laag heeft onbeperkte gebruikers, drie repos en 3 alert-configuraties.
* [gitter.im](https://gitter.im/) — Chat, voor GitHub. Onbeperkt openbare en privé kamers, gratis voor teams tot 25 personen
* [Hackmd.io](https://hackmd.io/) - Real-time samenwerking & schrijfgereedschap voor markdown document/bestandsformaat. Zoals Google Docs, maar voor markdown-bestanden. Gratis onbeperkt aantal "notities", maar het aantal medewerkers (genodigden) voor privé notities & sjablonen [wordt beperkt](https://hackmd.io/pricing).
* [hangouts.google.com](https://hangouts.google.com/) — Eén plek voor al je gesprekken, gratis, Google-account vereist
* [HeySpace](https://hey.space) - Taakbeheer-tool met chat, kalender, tijdlijn en videogesprekken. Gratis tot 5 gebruikers.
* [helplightning.com](https://www.helplightning.com/) — Hulp via video met augmented reality. Gratis zonder analytics, encryptie, support
* [ideascale.com](https://ideascale.com/) — Laat klanten ideeën indienen en stemmen, gratis voor 25 leden in 1 community
* [Igloo](https://www.igloosoftware.com/) — Intern portaal voor het delen van documenten, blogs, kalenders, enz. Gratis tot 10 gebruikers.
* [Keybase](https://keybase.io/) — Keybase is een FOSS alternatief voor Slack; het houdt ieders chats en bestanden veilig, van gezinnen tot communities tot bedrijven.
* [Google Meet](https://meet.google.com/) — Gebruik Google Meet voor de online videovergaderingen van je bedrijf. Meet biedt veilige, eenvoudig te joinen online meetings.
* [/meet for Slack](https://meetslack.com) - Start Google Meetings direct vanuit Slack door /meet te gebruiken in elk kanaal, groep of DM. Gratis zonder enige beperking.
* [Livecycle](https://www.livecycle.io/) — Livecycle is een inclusief samenwerkingsplatform dat workflows frictieloos maakt voor cross-functionele productteams en open-source projecten.
* [Lockitbot](https://www.lockitbot.com/) — Reserveer en vergrendel gedeelde resources binnen Slack zoals kamers, dev-omgevingen, servers, etc. Gratis tot 2 resources
* [MarkUp](https://www.markup.io/) — MarkUp laat je feedback verzamelen direct op je websites, PDF's en afbeeldingen.
* [Proton Pass](https://proton.me/pass) — Wachtwoordmanager met ingebouwde e-mailaliassen, 2FA-authenticator, delen en passkeys. Beschikbaar op web, browserextensie, mobiele app en desktop.
* [Visual Debug](https://visualdebug.com) - Een visueel feedbacktool voor betere communicatie tussen klant en ontwikkelaar
* [meet.jit.si](https://meet.jit.si/) — Eén-klik videovergaderingen en scherm delen, gratis
* [Microsoft Teams](https://products.office.com/microsoft-teams/free) — Microsoft Teams is een chat-gebaseerd digitaal platform dat gesprekken, content en apps samenbrengt op één plek vanuit één ervaring. Gratis tot 500k gebruikers.
* [Miro](https://miro.com/) - Schaalbaar, veilig, cross-device en enterprise-ready samenwerkings-whiteboard voor gedistribueerde teams. Met een freemium-plan.
* [nootiz](https://www.nootiz.com/) - De tool bij uitstek voor het verzamelen en beheren van visuele feedback op elke website
* [Notion](https://www.notion.so/) - Notion is een notitie- en samenwerkingsapplicatie met markdown-ondersteuning die taken, wiki’s en databases integreert. Het bedrijf beschrijft de app als een alles-in-één werkplek voor notities, projectmanagement en taakbeheer. Naast cross-platform apps is het toegankelijk via de meeste webbrowsers.
* [Nuclino](https://www.nuclino.com) - Een lichtgewicht en collaboratieve wiki voor alle kennis, documenten en notities van je team. Gratis plan met alle essentiële functies, tot 50 items en 5GB opslag.
* [OnlineInterview.io](https://onlineinterview.io/) - Gratis code interview platform met ingebouwde videochat, tekenbord en online code editor waarmee je code direct in de browser kunt compileren en uitvoeren. Je kunt met één klik een remote interviewruimte aanmaken.
* [Quidlo Timesheets](https://www.quidlo.com/timesheets) - Een eenvoudige urenregistratie- en tijdsregistratie-app voor teams. Het gratis plan heeft tijdregistratie- en rapportagefuncties voor maximaal 10 gebruikers.
* [PageShare.dev](https://www.pageshare.dev) - Voegt visuele reviewmogelijkheden toe aan GitHub Pull Requests zonder websites te hoeven uitrollen. Gratis tot 10 pagina’s per maand en in totaal 100MB opslag.
* [Pendulums](https://pendulums.io/) - Pendulums is een gratis tijdregistratietool die je helpt je tijd beter te beheren met een gebruiksvriendelijke interface en waardevolle statistieken.
* [Pumble](https://pumble.com) - Gratis teamchat-app. Onbeperkte gebruikers en berichtgeschiedenis, altijd gratis.
* [Raindrop.io](https://raindrop.io) - Privé en veilige bookmarking-app voor macOS, Windows, Android, iOS en web. Gratis onbeperkt bookmarks en samenwerking.
* [element.io](https://element.io/) — Een gedecentraliseerde en open-source communicatietool gebouwd op Matrix. Groepschats, directe berichten, versleutelde bestandsoverdracht, spraak- en videochats, en eenvoudige integratie met andere diensten.
* [Rocket.Chat](https://rocket.chat/) - Open-source communicatieplatform met Omnichannel-functies, Matrix Federation, Bridge met andere apps, onbeperkt berichten en volledige berichtgeschiedenis.
* [seafile.com](https://www.seafile.com/) — Privé of cloudopslag, bestandsdeling, synchronisatie, discussies. De cloudversie heeft slechts 1 GB
* [Sema](https://www.semasoftware.com/) - Gratis ontwikkelaarsportefeuille-tool die bijdragen over meerdere repositories kan consolideren en samenvatten in één rapport.
* [Screen Sharing via Browser](https://screensharing.net) - Gratis schermdeeltool, deel je scherm met samenwerkers direct vanuit je browser, geen download of registratie nodig. Gratis.
* [Slab](https://slab.com/) — Een moderne kennismanagementservice voor teams. Gratis tot 10 gebruikers.
* [slack.com](https://slack.com/) — Gratis voor onbeperkte gebruikers met enkele functielimieten
* [Spectrum](https://spectrum.chat/) - Creëer gratis openbare of privé communities.
* [StatusPile](https://www.statuspile.com/) - Een statuspagina van statuspagina's. Kun je de statuspagina's van je upstream providers volgen?
* [Stickies](https://stickies.app/) - Visuele samenwerkingsapp gebruikt voor brainstormen, contentcuratie en notities. Gratis tot 3 Walls, onbeperkte gebruikers en 1 GB opslag.
* [Stacks](https://betterstacks.com/) - Content-werkplek met geïntegreerde notities, links en bestandsopslag om informatie-overload te navigeren. Altijd gratis persoonlijk plan.
* [talky.io](https://talky.io/) — Gratis groepsvideochat. Anoniem. Peer‑to‑peer. Geen plugins, registratie of betaling vereist
* [Teamhood](https://teamhood.com/) - Gratis project-, taak- en issuetrackingsoftware. Ondersteunt Kanban met Swimlanes en volledige Scrum-implementatie. Heeft geïntegreerde tijdregistratie. Gratis voor vijf gebruikers en drie projectportefeuilles.
* [Teamplify](https://teamplify.com) - Verbeter teamontwikkelprocessen met Team Analytics en Smart Daily Standup. Inclusief volledige verlofbeheer voor remote-first teams. Gratis voor kleine groepen tot 5 gebruikers.
* [Tefter](https://tefter.io) - Bookmarking-app met krachtige Slack-integratie. Gratis voor open-source teams.
* [TeleType](https://teletype.oorja.io/) — Deel terminals, spraak, code, whiteboard en meer. Geen registratie nodig voor end-to-end versleutelde samenwerking voor ontwikkelaars.
* [TimeCamp](https://www.timecamp.com/) - Gratis urenregistratiesoftware voor onbeperkte gebruikers. Integreert eenvoudig met PM-tools zoals Jira, Trello, Asana, etc.
* [Huly](https://huly.io/) - Alles-in-één projectmanagementplatform (alternatief voor Linear, Jira, Slack, Notion, Motion) - onbeperkte gebruikers, 10GB opslag per werkruimte, 10GB video(audio) verkeer.
* [Teamcamp](https://www.teamcamp.app) - Alles-in-één projectmanagementapplicatie voor softwareontwikkelingsbedrijven.
* [twist.com](https://twist.com) — Een asynchroon-vriendelijke teamcommunicatie-app waar gesprekken georganiseerd en on-topic blijven. Gratis en onbeperkte plannen beschikbaar. Korting voor in aanmerking komende teams.
* [tldraw.com](https://tldraw.com) —  Gratis open-source whiteboard- en diagramtool met intelligente pijlen, snap, sticky notes en SVG-export. Multiplayer-modus voor collaboratief bewerken. Gratis officiële VS Code-extensie beschikbaar.
* [BookmarkOS.com](https://bookmarkos.com) - Gratis alles-in-één bookmarkmanager, tabmanager en taakmanager in een aanpasbaar online bureaublad met map-samenwerking.
* [typetalk.com](https://www.typetalk.com/) — Deel en bespreek ideeën met je team via instant messaging op het web of mobiel
* [Tugboat](https://tugboat.qa) - Preview elke pull request, automatisch en on-demand. Gratis voor iedereen, gratis Nano-laag voor non-profits.
* [whereby.com](https://whereby.com/) — Eén-klik videovergaderingen, gratis (voorheen bekend als appear.in)
* [windmill.dev](https://windmill.dev/) - Windmill is een open-source ontwikkelaarsplatform om snel productieklare multi-step automatisering en interne apps te bouwen van minimale Python- en Typescripts. Als gratis gebruiker kun je maximaal drie niet-premium workspaces aanmaken en lid zijn van maximaal drie.
* [vadoo.tv](https://vadoo.tv/) — Video hosting en marketing eenvoudig gemaakt. Upload video's met één klik. Opnemen, beheren, delen & meer. De gratis laag biedt tot 10 video's, 1 GB opslag en 10 GB bandbreedte/maand.
* [userforge.com](https://userforge.com/) - Onderling verbonden online persona's, user stories en contextmapping. Houdt design en development op één lijn, gratis tot 3 persona's en twee samenwerkers.
* [wistia.com](https://wistia.com/) — Video hosting met kijkersanalyses, HD-videolevering en marketingtools om je bezoekers te begrijpen, 25 video's en Wistia branded player
* [wormhol.org](https://www.wormhol.org/) — Eenvoudige bestandsdeelservice. Deel onbeperkt bestanden tot 5GB met zoveel peers als je wilt.
* [Wormhole](https://wormhole.app/) - Deel bestanden tot 5GB met end-to-end encryptie tot 24 uur. Voor bestanden groter dan 5 GB gebruikt het peer-to-peer overdracht om je bestanden direct te versturen.
* [zoom.us](https://zoom.us/) — Veilige video- en webconferencing, add-ons beschikbaar. Het gratis plan is beperkt tot 40 minuten.
* [Zulip](https://zulip.com/) — Real-time chat met een uniek e-mailachtig threadingsmodel. Het gratis plan omvat 10.000 berichten zoekgeschiedenis en tot 5 GB bestandsopslag. Ook is er een zelf-hostbare open-source versie.
* [robocorp.com](https://robocorp.com) - Open-source stack voor Automation Ops. Probeer Cloud-functies en implementeer eenvoudige automatisering gratis. Robotwerk 240 min/maand, 10 Assistant runs, 100 MB opslag.
* [Fleep.io](https://fleep.io/) — Fleep is een alternatief voor Slack. Het heeft een gratis plan voor kleine teams met volledige berichtgeschiedenis, onbeperkte 1:1-gesprekken, 1 groepsgesprek en 1 GB bestandsopslag.
* [Chanty.com](https://chanty.com/) — Chanty is een ander alternatief voor Slack. Het heeft een gratis voor altijd-plan voor kleine teams (tot 10) met onbeperkte openbare en privégesprekken, doorzoekbare geschiedenis, onbeperkte 1:1-audiogesprekken, onbeperkte spraakberichten, tien integraties en 20 GB opslag per team.
* [ruttl.com](https://ruttl.com/) — De beste alles-in-één feedbacktool om digitale feedback te verzamelen en websites, PDF's en afbeeldingen te reviewen.
* [Mattermost](https://mattermost.com/) — Veilige samenwerking voor technische teams. Gratis plan met onbeperkte kanalen, playbooks, borden, gebruikers, 10GB opslag en meer.
* [Webvizio](https://webvizio.com) — Website feedbacktool, website reviewsoftware en bug reporting tool om samenwerking op taken direct op live websites, webapps, afbeeldingen, PDF's en designbestanden te stroomlijnen.
* [Pullflow](https://pullflow.com) — Pullflow biedt een AI-verrijkt platform voor code review samenwerking via GitHub, Slack en VS Code.
* [Webex](https://www.webex.com/) — Videovergaderingen met een gratis plan van 40 minuten per vergadering met 100 deelnemers.
* [RingCentral](https://www.ringcentral.com/) — Videovergaderingen met een gratis plan van 50 minuten per vergadering met 100 deelnemers.
* [GitBook](https://www.gitbook.com/) — Platform voor het vastleggen en documenteren van technische kennis — van productdocumentatie tot interne kennisbanken en API's. Gratis plan voor individuele ontwikkelaars.
* [transfernow](https://www.transfernow.net/) — De eenvoudigste, snelste en veiligste interface om bestanden te verzenden en delen. Stuur foto's, video's en andere grote bestanden zonder verplichte abonnement.
* [paste.sh](https://paste.sh/) — Dit is een JavaScript- en Crypto-gebaseerde eenvoudige paste-site.
* [Revolt.chat](https://revolt.chat/) — Een open-source alternatief voor [Discord](https://discord.com/), dat je privacy respecteert. Het bevat de meeste eigen features van Discord gratis. Revolt is een alles-in-één applicatie die veilig en snel is, en 100% gratis. Alle functies zijn gratis. Ze bieden (officiële & niet-officiële) plugin-ondersteuning, in tegenstelling tot de meeste mainstream chatapplicaties.
* [Tencent RTC](https://trtc.io/) — Tencent Real-Time Communication (TRTC) biedt oplossingen voor groepsaudio/video gesprekken. 10.000 gratis minuten/maand voor het eerste jaar.
* [Pastefy](https://pastefy.app/) - Mooie en eenvoudige Pastebin met optionele client-encryptie, multitabs, een API, een syntax-highlighting editor en meer.
* [SiteDots](https://sitedots.com/) - Deel feedback voor websiteprojecten direct op je website, geen emulatie, canvas of workarounds. Volledig functionele gratis laag.

**[⬆️ Terug naar boven](#table-of-contents)**

## CMS

* [acquia.com](https://www.acquia.com/) — Hosting voor Drupal-sites. Gratis laag voor ontwikkelaars. Gratis ontwikkeltools (zoals Acquia Dev Desktop) zijn ook beschikbaar.
* [Contentful](https://www.contentful.com/) — Headless CMS. Contentbeheer en leverings-API’s in de cloud. Wordt geleverd met één gratis Community-ruimte die vijf gebruikers, 25K records, 48 Content Types, 2 talen bevat.
* [Cosmic](https://www.cosmicjs.com/) — Headless CMS en API-toolkit. Gratis persoonlijke plannen voor ontwikkelaars.
* [Crystallize](https://crystallize.com) — Headless PIM met e-commerce ondersteuning. Ingebouwde GraphQL API. De gratis versie bevat onbeperkte gebruikers, 1000 catalogusitems, 5 GB/maand bandbreedte en 25k/maand API-calls.
* [DatoCMS](https://www.datocms.com/) - Biedt een gratis laag voor kleine projecten. DatoCMS is een GraphQL-gebaseerde CMS. In de laagste laag heb je 100k/maand calls.
* [Directus](https://directus.io) — Headless CMS. Een volledig gratis en open-source platform voor het beheren van assets en database-content on-prem of in de cloud. Geen beperkingen of betaalmuren.
* [FrontAid](https://frontaid.io/) — Headless CMS die JSON-content direct in je Git-repository opslaat. Geen restricties.
* [kontent.ai](https://www.kontent.ai) - Een Content-as-a-Service platform dat alle voordelen van een headless CMS biedt en tegelijkertijd marketeers versterkt. Het ontwikkelaarsplan biedt twee gebruikers met onbeperkte projecten met twee omgevingen per project, 500 content items, twee talen met Delivery en Management API, en Custom elements ondersteuning. Je kunt uitgebreidere plannen gebruiken om aan je wensen te voldoen.
* [Prismic](https://www.prismic.io/) — Headless CMS. Contentbeheerinterface met volledig gehoste en schaalbare API. Het Community Plan biedt onbeperkte API-calls, documenten, custom types, assets en talen voor één gebruiker. Alles wat je nodig hebt voor je volgende project. Grotere gratis plannen beschikbaar voor Open Content/Open Source projecten.
* [Sanity.io](https://www.sanity.io/) - Platform voor gestructureerde content met een open-source editoromgeving en een real-time gehoste datastore. Onbeperkte projecten. Onbeperkte admin-gebruikers, drie niet-admin gebruikers, twee datasets, 500K API CDN-requests, 10GB bandbreedte en 5GB assets inbegrepen per project.
* [sensenet](https://sensenet.com) - API-first headless CMS dat oplossingen op enterpriseniveau biedt voor bedrijven van elke omvang. Het ontwikkelaarsplan biedt drie gebruikers, 500 content items, drie ingebouwde rollen, 25+5 content types, volledig toegankelijke REST API, document preview generatie en Office Online bewerking.
* [TinaCMS](https://tina.io/) — Vervangt Forestry.io. Open-source Git-backed headless CMS dat Markdown, MDX en JSON ondersteunt. Het basisaanbod is gratis met twee gebruikers.
* [GatsbyjsCMS](https://www.gatsbyjs.com/) - Gatsby is het snelle en flexibele framework waarmee het bouwen van websites met elk CMS, API of database weer leuk wordt. Bouw en implementeer headless websites die meer verkeer genereren, beter converteren en meer omzet opleveren!
* [Hygraph](https://hygraph.com/) - Biedt gratis laag voor kleine projecten. GraphQL-first API. Stap over van legacy-oplossingen naar de GraphQL-native Headless CMS - en lever omnichannel content API-first.
* [Squidex](https://squidex.io/) - Biedt een gratis laag voor kleine projecten. API / GraphQL eerst. Open source en gebaseerd op event sourcing (versieert elke wijziging automatisch).
* [InstaWP](https://instawp.com/) - Start een WordPress-site in enkele seconden. Een gratis laag met 5 actieve sites, 500 MB ruimte, 48 uur siteverloop.
* [Storyblok](https://www.storyblok.com) - Een Headless CMS voor ontwikkelaars en marketeers dat werkt met alle moderne frameworks. De Community (gratis) laag biedt Management API, Visual Editor, tien bronnen, aangepaste veldtypen, internationalisatie (onbeperkt aantal talen/locale), Asset Manager (tot 2500 assets), Image Optimizing Service, Search Query, Webhook + 250GB verkeer/maand inbegrepen.
* [WPJack](https://wpjack.com) - Zet WordPress op elke cloud op in minder dan 5 minuten! De gratis laag bevat 1 server, 2 sites, gratis SSL-certificaten en onbeperkte cron-jobs. Geen tijdslimieten of vervaldatums—jouw website, jouw manier.

**[⬆️ Terug naar boven](#table-of-contents)**

## Codegeneratie

* [Appinvento](https://appinvento.io/) — AppInvento is een gratis no-code app bouwer. In de automatisch gegenereerde backend-code hebben gebruikers volledige toegang tot de broncode en onbeperkte API's en routes, wat uitgebreide integratie mogelijk maakt. Het gratis plan omvat drie projecten, vijf tabellen en een Google-add-on.
* [Cody AI](https://sourcegraph.com/cody) - Cody is een codeer-AI-assistent die AI en een diepgaand begrip van je codebase gebruikt om je te helpen sneller code te schrijven en te begrijpen. Cody geeft ontwikkelaars een keuze uit LLM's (inclusief lokale inferentie), heeft ondersteuning voor diverse IDE's, ondersteunt alle populaire programmeertalen en heeft een gratis plan. Het gratis plan biedt ontwikkelaars 20 chatberichten (met gebruik van Claude 3 Sonnet als LLM) en 500 autocompletions (met gebruik van Starcoder 16b) per maand.
* [DhiWise](https://www.dhiwise.com/) — Zet Figma-designs naadloos om in dynamische Flutter- & React-applicaties met DhiWise's innovatieve codegeneratie technologie, optimaliseer je workflow en help je uitzonderlijke mobiele en webervaringen sneller dan ooit te creëren.
* [Codeium](https://www.codeium.com/) — Codeium is een gratis AI-gestuurd code completion hulpmiddel. Het ondersteunt meer dan 20 programmeertalen (Python, JavaScript, Java, TypeScript, PHP, C/C++, Go, enz.) en integreert met alle grote standalone en web IDE's.
* [Fern](https://buildwithfern.com) - Schrijf API-definities en gebruik ze om SDK's/clientbibliotheken te genereren in populaire talen zoals TypeScript, Python, Java, Go en meer. OpenAPI volledig ondersteund. Gratis laag genereert code voor maximaal 20 endpoints.
* [Metalama](https://www.postsharp.net/metalama) - Alleen voor C#. Metalama genereert boilerplatecode tijdens compilatie zodat je broncode schoon blijft. Het is gratis voor open-source projecten, en de commercieel-vriendelijke gratis laag omvat drie aspecten.
* [Supermaven](https://www.supermaven.com/) — Supermaven is een snelle AI code completion plugin voor VSCode, JetBrains en Neovim. Gratis laag biedt onbeperkte inline aanvulling.
* [tabnine.com](https://www.tabnine.com/) — Tabnine helpt ontwikkelaars betere software sneller te maken door inzichten te bieden, geleerd uit alle code ter wereld. Plugin beschikbaar.
* [v0.dev](https://v0.dev/) — v0 gebruikt AI-modellen om code te genereren op basis van eenvoudige tekstprompts. Het genereert copy-paste-vriendelijke React-code gebaseerd op shadcn/ui en Tailwind CSS die mensen kunnen gebruiken in hun projecten. Elke generatie kost minimaal 30 credits. Je start met 1200 credits en krijgt elke maand 200 gratis credits.

**[⬆️ Terug naar boven](#table-of-contents)**

## Codekwaliteit

* [beanstalkapp.com](https://beanstalkapp.com/) — Een complete workflow om code te schrijven, te beoordelen en te deployen, een gratis account voor één gebruiker en één repository met 100 MB opslag.
* [browserling.com](https://www.browserling.com/) — Live interactieve cross-browser testing, gratis alleen 3 minuten sessies met MS IE 9 onder Vista bij 1024 x 768 resolutie.
* [codacy.com](https://www.codacy.com/) — Geautomatiseerde codebeoordeling voor PHP, Python, Ruby, Java, JavaScript, Scala, CSS en CoffeeScript, gratis voor onbeperkte publieke en privé repositories.
* [Codeac.io](https://www.codeac.io/infrastructure-as-code.html?ref=free-for-dev) - Geautomatiseerde Infrastructure as Code review tool voor DevOps, integreert met GitHub, Bitbucket en GitLab (ook self-hosted). Naast standaardtalen analyseert het ook Ansible, Terraform, CloudFormation, Kubernetes en meer. (open-source gratis)
* [CodeBeat](https://codebeat.co) — Geautomatiseerd Code Review Platform beschikbaar voor veel talen. Altijd gratis voor publieke repositories met Slack- en e-mailintegratie.
* [codeclimate.com](https://codeclimate.com/) — Geautomatiseerde code review, gratis voor Open Source en onbeperkt aan organisatie-eigen privé-repos (tot 4 medewerkers). Ook gratis voor studenten en instellingen.
* [codecov.io](https://codecov.io/) — Code coverage tool (SaaS), gratis voor Open Source en één gratis privé repo.
* [CodeFactor](https://www.codefactor.io) — Geautomatiseerde Code Review voor Git. De gratis versie bevat onbeperkte gebruikers, publieke repositories en één privé repo.
* [coderabbit.ai](https://coderabbit.ai) — AI-gestuurde code review tool die integreert met GitHub/GitLab. Gratis laag bevat 200 bestanden/uur, 3 reviews per uur en 50 gesprekken/uur. Altijd gratis voor open source projecten.
* [codescene.io](https://codescene.io/) - CodeScene prioriteert technische schuld op basis van hoe ontwikkelaars met de code werken en visualiseert organisatorische factoren zoals teamkoppeling en systeembeheersing. Gratis voor Open Source.
* [CodSpeed](https://codspeed.io) - Automatiseer prestatie-tracking in je CI-pijplijnen. Vang prestatieregressies op voor de uitrol dankzij nauwkeurige en consistente metingen. Altijd gratis voor Open Source projecten.
* [coveralls.io](https://coveralls.io/) — Toont testrapporten, gratis voor Open Source.
* [dareboost](https://dareboost.com) - 5 gratis analyse rapporten per maand voor webprestaties, toegankelijkheid en beveiliging.
* [deepcode.ai](https://www.deepcode.ai) — DeepCode vindt bugs, beveiligingslekken, prestatie- en API-problemen op basis van AI. De analysetijd van DeepCode maakt het mogelijk om je code in realtime te analyseren en resultaten te leveren wanneer je op de opslaan-knop in je IDE drukt. Ondersteunde talen: Java, C/C++, JavaScript, Python en TypeScript. Integraties met GitHub, BitBucket en GitLab. Gratis voor open source en privé repos en tot 30 ontwikkelaars.
* [deepscan.io](https://deepscan.io) — Geavanceerde statische analyse voor het automatisch vinden van runtime errors in JavaScript-code, gratis voor Open Source.
* [DeepSource](https://deepsource.io/) - DeepSource analyseert voortdurend broncodewijzigingen, vindt en repareert problemen onderverdeeld in beveiliging, prestaties, anti-patronen, bugrisico's, documentatie en stijl. Native integratie met GitHub, GitLab en Bitbucket.
* [DiffText](https://difftext.com) - Vind direct de verschillen tussen twee blokken code. Volledig gratis te gebruiken.
* [eversql.com](https://www.eversql.com/) — EverSQL - Het #1 platform voor database-optimalisatie. Krijg automatisch kritische inzichten in je database en SQL-queries.
* [gerrithub.io](https://review.gerrithub.io/) — Gerrit code review voor GitHub repositories gratis.
* [gocover.io](https://gocover.io/) — Code coverage voor elk [Go](https://golang.org/) pakket.
* [goreportcard.com](https://goreportcard.com/) — Codekwaliteit voor Go-projecten, gratis voor Open Source.
* [gtmetrix.com](https://gtmetrix.com/) — Rapporten en grondige aanbevelingen om websites te optimaliseren.
* [holistic.dev](https://holistic.dev/) - De #1 statische code-analyzer voor Postgresql-optimalisatie. Automatische detectie van prestatie-, beveiligings- en architectuurproblemen in databases.
* [houndci.com](https://houndci.com/) — Geeft opmerkingen over codekwaliteit op GitHub commits, gratis voor Open Source.
* [Moderne.io](https://app.moderne.io) — Automatische broncode refactoring. Moderne biedt framework-migraties, code-analyse met herstel en ongeëvenaarde code-transformatie op schaal, zodat ontwikkelaars hun tijd kunnen besteden aan het bouwen van nieuwe dingen in plaats van het onderhouden van het oude. Gratis voor Open Source.
* [reviewable.io](https://reviewable.io/) — Code review voor GitHub repositories, gratis voor publieke of persoonlijke repos.
* [parsers.dev](https://parsers.dev/) - Abstract syntax tree parsers en intermediate representation compilers als een service.
* [scan.coverity.com](https://scan.coverity.com/) — Statische codeanalyse voor Java, C/C++, C# en JavaScript, gratis voor Open Source.
* [scrutinizer-ci.com](https://scrutinizer-ci.com/) — Continuous inspection platform, gratis voor Open Source.
* [semanticdiff.com](https://app.semanticdiff.com/) — Programmeertaalbewuste diff voor GitHub pull requests en commits, gratis voor publieke repositories.
* [shields.io](https://shields.io) — Kwaliteitsmetadata-badges voor open source-projecten.
* [sonarcloud.io](https://sonarcloud.io) — Geautomatiseerde broncodeanalyse voor Java, JavaScript, C/C++, C#, VB.NET, PHP, Objective-C, Swift, Python, Groovy en meer talen, gratis voor Open Source.
* [SourceLevel](https://sourcelevel.io/) — Geautomatiseerde Code Review en Team Analytics. Gratis voor Open Source en organisaties tot 5 medewerkers.
* [webceo.com](https://www.webceo.com/) — SEO-tools, maar ook codeverificatie en verschillende apparaattests.
* [zoompf.com](https://zoompf.com/) — Verbeter de prestaties van je websites, gedetailleerde analyse.

**[⬆️ Terug naar boven](#table-of-contents)**

## Code zoeken en bladeren

* [libraries.io](https://libraries.io/) — Zoek- en afhankelijkheidsupdate meldingen voor 32 verschillende package managers, gratis voor open source.
* [Namae](https://namae.dev/) - Zoek op verschillende websites zoals GitHub, Gitlab, Heroku, Netlify en nog veel meer naar de beschikbaarheid van je projectnaam.
* [searchcode.com](https://searchcode.com/) — Uitgebreide tekstgebaseerde codezoekmachine, gratis voor Open Source.
* [tickgit.com](https://www.tickgit.com/) — Toont `TODO`-commentaren (en andere markeringen) om gebieden in de code te identificeren die verbetering behoeven.
* [CodeKeep](https://codekeep.io) - Google Keep voor code snippets. Organiseer, ontdek en deel code snippets, met een krachtige code screenshot-tool met vooraf ingestelde sjablonen en een koppelingsfunctie.

**[⬆️ Terug naar boven](#table-of-contents)**

## CI en CD

* [AccessLint](https://github.com/marketplace/accesslint) — AccessLint brengt geautomatiseerde webtoegankelijkheidstests in je ontwikkelworkflow. Gratis voor open source en onderwijsdoeleinden.
* [appcircle.io](https://appcircle.io) — Een enterprise-grade mobile DevOps-platform dat het bouwen, testen en publiceren van mobiele apps automatiseert voor snellere en efficiëntere releasecycli. Gratis voor maximaal 30 minuten buildtijd per build, 20 builds per maand en 1 gelijktijdige build.
* [appveyor.com](https://www.appveyor.com/) — CD-dienst voor Windows, gratis voor Open Source.
* [LocalOps](https://localops.co/) - Deploy je app op AWS/GCP/Azure in minder dan 30 minuten. Zet gestandaardiseerde app-omgevingen op in elke cloud, met ingebouwde continue deploy automatisering en geavanceerde observatie. Het gratis plan staat 1 gebruiker en 1 app-omgeving toe.
* [Argonaut](https://argonaut.dev/) - Deploy apps en infrastructuur op je cloud in minuten. Ondersteuning voor aangepaste en externe app-deployments op Kubernetes- en Lambda-omgevingen. De gratis laag staat onbeperkt apps en deploys toe voor 5 domeinen en 2 gebruikers.
* [bitrise.io](https://www.bitrise.io/) — CI/CD voor mobiele apps, native of hybride. Met 200 gratis builds/maand, 10 min buildtijd en twee teamleden. OSS-projecten krijgen 45 min buildtijd, +1 gelijktijdigheid en onbeperkte teamgrootte.
* [buddy.works](https://buddy.works/) — CI/CD met vijf gratis projecten en één gelijktijdige run (120 uitvoeringen/maand).
* [Buildkite](https://buildkite.com) CI Pipelines gratis voor 3 gebruikers en 5k jobminuten/maand. Test Analytics gratis ontwikkelaar laag bevat 100k testuitvoeringen/maand, met meer gratis mogelijkheden voor open-source projecten.
* [bytebase.com](https://www.bytebase.com/) — Database CI/CD en DevOps. Gratis voor minder dan 20 gebruikers en tien database-instanties.
* [CircleCI](https://circleci.com/) — Uitgebreid gratis plan met alle functies inbegrepen in een gehoste CI/CD-dienst voor GitHub-, GitLab- en BitBucket-repositories. Meerdere resourceklassen, Docker, Windows, Mac OS, ARM-executors, lokale runners, test-splitting, Docker Layer Caching en andere geavanceerde CI/CD-functies. Gratis tot 6000 minuten/maand uitvoeringstijd, onbeperkte medewerkers, 30 parallelle jobs in privéprojecten, en tot 80.000 gratis buildminuten voor Open Source-projecten.
* [cirrus-ci.org](https://cirrus-ci.org) - Gratis voor publieke GitHub-repositories.
* [cirun.io](https://cirun.io) - Gratis voor publieke GitHub-repositories.
* [codefresh.io](https://codefresh.io) — Free-for-Life plan: 1 build, één omgeving, gedeelde servers, onbeperkte publieke repos.
* [codemagic.io](https://codemagic.io/) - Gratis 500 buildminuten/maand.
* [codeship.com](https://codeship.com/) — 100 privé-builds/maand, vijf privéprojecten, onbeperkt voor Open Source.
* [deploybot.com](https://www.deploybot.com/) — 1 repository met tien deployments, gratis voor Open Source.
* [deployhq.com](https://www.deployhq.com/) — 1 project met tien dagelijkse deployments (30 buildminuten/maand).
* [drone](https://cloud.drone.io/) - Drone Cloud stelt ontwikkelaars in staat om Continuous Delivery-pijplijnen uit te voeren over meerdere architecturen - inclusief x86 en Arm (zowel 32- als 64-bit) - allemaal op één plek.
* [LayerCI](https://layerci.com) — CI voor full stack-projecten. Eén full stack preview-omgeving met 5GB geheugen & 3 CPU's.
* [semaphoreci.com](https://semaphoreci.com/) — Gratis voor Open Source, 100 privé-builds per maand.
* [Squash Labs](https://www.squash.io/) — creëert een VM voor elke branch en maakt je app beschikbaar via een unieke URL, onbeperkte publieke & privé repos, tot 2 GB VM-groottes.
* [styleci.io](https://styleci.io/) — Alleen publieke GitHub-repositories.
* [Mergify](https://mergify.io) — workflow-automatisering en merge-queue voor GitHub — Gratis voor publieke GitHub-repositories.
* [Make](https://www.make.com/en) — De workflow-automatiseringstool laat je apps koppelen en workflows automatiseren via een UI. Het ondersteunt veel apps en de meest populaire API's. Gratis voor publieke GitHub-repositories, en gratis laag met 100 Mb, 1000 operaties en 15 minuten minimale interval.
* [Spacelift](https://spacelift.io/) - Managementplatform voor Infrastructure as Code. Gratis planfuncties: IaC-samenwerking, Terraform module registry, ChatOps-integratie, continue resource compliance met Open Policy Agent, SSO met SAML 2.0 en toegang tot publieke worker pools: tot 200 minuten/maand.
* [microtica.com](https://microtica.com/) - Startup-omgevingen met kant-en-klare infrastructuurcomponenten, deploy apps op AWS gratis en ondersteun je productie-werklasten. De gratis laag bevat 1 omgeving (op je eigen AWS-account), 2 Kubernetes-services, 100 buildminuten per maand en 20 maandelijkse deployments.
* [Nx Cloud](https://nx.dev/ci) - Nx Cloud versnelt je monorepos op CI met functies zoals remote caching, distributie van taken over meerdere machines en zelfs geautomatiseerde splitsing van je e2e-testuitvoeringen. Het bevat een gratis plan voor maximaal 30 bijdragers met royale 150k credits inbegrepen.
* [blacksmith](https://www.blacksmith.sh/) - Beheerde performance runners voor GitHub Actions die 3.000 gratis minuten per maand bieden, zonder dat een creditcard nodig is.
* [Terramate](https://terramate.io/) - Terramate is een orkestratie- en beheersplatform voor Infrastructure as Code (IaC)-tools zoals Terraform, OpenTofu en Terragrunt. Gratis tot 2 gebruikers inclusief alle functies.
* [Terrateam](https://terrateam.io) - GitOps-first Terraform-automatisering met pull request-gedreven workflows, projectisolatie via self-hosted runners en gelaagde runs voor geordende operaties. Gratis tot 3 gebruikers.

**[⬆️ Terug naar boven](#table-of-contents)**

## Testen

* [Applitools.com](https://applitools.com/) — Slimme visuele validatie voor web-, native mobiele en desktop-apps. Integreert met bijna alle automatiseringsoplossingen (zoals Selenium en Karma) en remote runners (Sauce Labs, Browser Stack). Gratis voor open source. Een gratis laag voor één gebruiker met een beperkt aantal checkpoints per week.
* [Appetize](https://appetize.io) — Test je Android- & iOS-apps op deze cloudgebaseerde Android Phone/Tablets-emulator en iPhone/iPad-simulatoren direct in je browser. De gratis laag bevat twee gelijktijdige sessies met 30 minuten gebruik per maand. Geen limiet op app-grootte.
* [Apptim](https://apptim.com) — Een mobiele testtool waarmee mensen zonder performance engineering-vaardigheden de prestaties en gebruikerservaring (UX) van een app kunnen evalueren. Een desktopversie met je eigen apparaat is 100% GRATIS, met onbeperkte tests op zowel iOS als Android.
* [Argos](https://argos-ci.com) - Open Source visuele testen voor ontwikkelaars. Onbeperkte projecten, met 5.000 screenshots per maand. Gratis voor open source-projecten.
* [Bencher](https://bencher.dev/) - Een continuous benchmarking-toolkit om CI-prestatieregressies te detecteren. Gratis voor alle openbare projecten.
* [browserstack.com](https://www.browserstack.com/) — Handmatig en geautomatiseerd browser testen, [gratis voor Open Source](https://www.browserstack.com/open-source?ref=pricing)
* [BugBug](https://bugbug.io/) - Lichtgewicht testautomatiseringstool voor webapplicaties. Gemakkelijk te leren en vereist geen codering. Je kunt onbeperkt tests uitvoeren op je eigen computer, gratis. Cloud monitoring en CI/CD-integratie zijn beschikbaar voor een extra maandelijkse vergoeding.
* [Checkly](https://checklyhq.com) - Code-first synthetische monitoring voor moderne DevOps. Monitor je API's en apps voor een fractie van de prijs van traditionele providers. Aangedreven door een Monitoring as Code workflow en Playwright. Royaal gratis niveau voor ontwikkelaars.
* [checkbot.io](https://www.checkbot.io/) — Browserextensie die test of je website voldoet aan 50+ SEO-, snelheids- en beveiligingsbest practices. Gratis laag voor kleinere websites.
* [CORS-Tester](https://cors-error.dev/cors-tester/) - Een gratis tool voor ontwikkelaars en API-testers om te controleren of een API CORS-enabled is voor een bepaald domein en om eventuele hiaten te identificeren. Ontvang bruikbare inzichten.
* [cypress.io](https://www.cypress.io/) - Snel, eenvoudig en betrouwbaar testen voor alles wat in een browser draait. Cypress Test Runner is altijd gratis en open source zonder beperkingen. Cypress Dashboard is gratis voor open source-projecten tot 5 gebruikers.
* [Cypress Recorder by Preflight](https://cypress.preflight.com/) - Maak AI-aangedreven Cypress Tests/POM-modellen in je browser. Het is open source, behalve het AI-gedeelte. Gratis voor vijf maandelijkse testcreaties met self-healing scripts, e-mail en visuele testen.
* [everystep-automation.com](https://www.everystep-automation.com/) — Neemt alle stappen in een webbrowser op en speelt ze af en maakt scripts, gratis met minder opties.
* [Gremlin](https://www.gremlin.com/gremlin-free-software) — Gremlin's Chaos Engineering-tools stellen je in staat veilig en gecontroleerd fouten te injecteren in je systemen om zwakke plekken te vinden voordat ze klantproblemen veroorzaken. Gremlin Free biedt toegang tot Shutdown- en CPU-aanvallen op maximaal 5 hosts of containers.
* [gridlastic.com](https://www.gridlastic.com/) — Selenium Grid testen met een gratis plan van tot 4 gelijktijdige selenium nodes/10 grid starts/4.000 testminuten/maand.
* [katalon.com](https://katalon.com) - Biedt een testplatform dat teams van elke omvang kan helpen op verschillende niveaus van testvolwassenheid, inclusief Katalon Studio, TestOps (+ Visual Testing gratis), TestCloud en Katalon Recorder.
* [Keploy](https://keploy.io/) - Keploy is een functionele testtoolkit voor ontwikkelaars. Het opnemen van API-calls genereert E2E-tests voor API's (KTests) en mocks of stubs (KMocks). Gratis voor open source-projecten.
* [knapsackpro.com](https://knapsackpro.com) - Versnel je tests met optimale test suite-parallelisatie op elke CI-provider. Split Ruby-, JavaScript-tests op parallelle CI-nodes om tijd te besparen. Gratis plan tot 10 minuten aan testbestanden en gratis onbeperkt plan voor open source-projecten.
* [lambdatest.com](https://www.lambdatest.com/) — Handmatig, visueel, screenshot- en geautomatiseerd browsertesten op selenium en cypress, [gratis voor Open Source](https://www.lambdatest.com/open-source-cross-browser-testing-tool)
* [loadmill.com](https://www.loadmill.com/) - Maak automatisch API- en load-tests door netwerkverkeer te analyseren. Simuleer tot 50 gelijktijdige gebruikers tot 60 minuten gratis per maand.
* [lost-pixel.com](https://lost-pixel.com) - Holistische visuele regressietests voor je Storybook, Ladle, Histoire-verhalen en webapps. Onbeperkt aantal teamleden, volledig gratis voor open source, 7.000 snapshots/maand.
* [octomind.dev](https://www.octomind.dev/) - Automatisch gegenereerde, uitgevoerde en onderhouden Playwright UI-tests met AI-ondersteunde testcasusgeneratie.
* [percy.io](https://percy.io) - Voeg visuele testen toe aan elke webapp, statische site, stijlgids of componentenbibliotheek. Onbeperkt teamleden, demo-app en onbeperkte projecten, 5.000 snapshots/maand.
* [preflight.com](https://preflight.com) - No-code geautomatiseerd webtesten. Neem tests op in je browser die bestand zijn tegen UI-wijzigingen en voer ze uit op Windows-machines. Kun je integreren met je CI/CD? Het gratis plan bevat 50 maandelijkse testuitvoeringen met video, HTML-sessies en meer.
* [qase.io](https://qase.io) - Testmanagementsysteem voor Dev- en QA-teams. Beheer testcases, stel testuitvoeringen samen, voer tests uit, volg defecten en meet de impact. De gratis laag bevat alle kernfuncties, met 500MB beschikbaar voor bijlagen en tot 3 gebruikers.
* [Repeato](https://repeato.app/) No-code mobiele app-testautomatiseringstool gebaseerd op computer vision en AI. Werkt voor native apps, flutter, react-native, web, ionic en vele andere app-frameworks. Het gratis plan is beperkt tot 10 tests voor iOS en 10 voor Android, maar bevat de meeste functies van de betaalde plannen, inclusief onbeperkte testuitvoeringen.
* [Requestly](https://requestly.com/) Open-source Chrome-extensie om HTTP-verzoeken te onderscheppen, omleiden en mocken. Met [Debugger](https://requestly.com/products/web-debugger/), [Mock Server](https://requestly.com/products/mock-server/), [API Client](https://requestly.com/products/api-client/) en [Session Recording](https://requestly.com/products/session-book/). Omleidings-URL's, HTTP-headers aanpassen, API's mocken, aangepaste JS injecteren, GraphQL-verzoeken aanpassen, Mock API-eindpunten genereren, sessie opnemen met netwerk- & consolelogs. Maak tot 10 regels in de gratis laag. Gratis voor open source.
* [seotest.me](https://seotest.me/) — Gratis on-page SEO-website tester. 10 gratis website crawls per dag. Nuttige SEO-leermiddelen en aanbevelingen om de on-page SEO-resultaten van elke website te verbeteren, ongeacht de technologie.
* [snippets.uilicious.com](https://snippets.uilicious.com) - Het is als CodePen maar voor cross-browser testen. UI-licious laat je tests schrijven als user stories en biedt een gratis platform - UI-licious Snippets - waarop je onbeperkt tests op Chrome kunt uitvoeren zonder aanmelding, tot 3 minuten per testuitvoering. Een bug gevonden? Je kunt de unieke URL van je test kopiëren om je ontwikkelaars precies te laten zien hoe de bug te reproduceren.
* [TestCollab](https://testcollab.com) - Gebruiksvriendelijke testmanagementsoftware, het gratis plan omvat Jira-integratie, onbeperkte projecten, testcase-import via CSV/XLSx, tijdregistratie en 1 GB bestandsopslag.
* [testingbot.com](https://testingbot.com/) — Selenium-browser- en apparaattesten, [gratis voor Open Source](https://testingbot.com/open-source)
* [Testspace.com](https://testspace.com/) - Een dashboard voor het publiceren van geautomatiseerde testresultaten en een framework voor het implementeren van handmatige tests als code via GitHub. De dienst is [gratis voor Open Source](https://github.com/marketplace/testspace-com) en accounts voor 450 maandelijkse resultaten.
* [tesults.com](https://www.tesults.com) — Testresultaatrapportage en testcasebeheer. Integreert met populaire testframeworks. Open source-ontwikkelaars, individuen, docenten en kleine teams die beginnen kunnen korting en gratis aanbiedingen aanvragen naast de basis gratis projecten.
* [UseWebhook.com](https://usewebhook.com) - Ontvang en inspecteer webhooks vanuit je browser. Forward naar localhost, of opnieuw afspelen vanuit de geschiedenis. Gratis te gebruiken.
* [Vaadin](https://vaadin.com) — Bouw schaalbare UI's in Java of TypeScript en gebruik de geïntegreerde tooling, componenten en design system om sneller te itereren, beter te ontwerpen en het ontwikkelproces te vereenvoudigen. Onbeperkte projecten met vijf jaar gratis onderhoud.
* [websitepulse.com](https://www.websitepulse.com/tools/) — Diverse gratis netwerk- en servertools.
* [webhook-test.com](https://webhook-test.com) - Debug en inspecteer webhooks en HTTP-verzoeken met een unieke URL tijdens integratie. Volledig gratis, je kunt onbeperkt URL's aanmaken en aanbevelingen ontvangen.
* [webhook.site](https://webhook.site) - Verifieer webhooks, uitgaande HTTP-verzoeken of e-mails met een aangepaste URL. Een tijdelijke URL en e-mailadres zijn altijd gratis.
* [webhookbeam.com](https://webhookbeam.com) - Stel webhooks in en monitor ze via pushmeldingen en e-mails.

**[⬆️ Terug naar boven](#table-of-contents)**

## Beveiliging en PKI

* [aikido.dev](https://www.aikido.dev) — All-in-one appsec-platform dat SCA, SAST, CSPM, DAST, Secrets, IaC, Malware, Container-scanning, EOL, ... dekt. Gratis plan omvat twee gebruikers, scannen van 10 repos, 1 cloud, 2 containers & 1 domein.
* [alienvault.com](https://www.alienvault.com/open-threat-exchange/reputation-monitor) — Spoort gecompromitteerde systemen in je netwerk op.
* [Altcha.org](https://altcha.org/anti-spam) - Een spamfilter voor websites en API's, aangedreven door natuurlijke taalverwerking en machine learning. Gratis plan omvat 200 verzoeken per dag per domein.
* [atomist.com](https://atomist.com/) — Een snellere en handigere manier om diverse ontwikkelingstaken te automatiseren. Nu in beta.
* [cloudsploit.com](https://cloudsploit.com/) — Amazon Web Services (AWS) beveiliging en compliance auditing en monitoring.
* [Public Cloud Threat Intelligence](https://cloudintel.himanshuanand.com/) — High confidence Indicator of Compromise (IOC) gericht op publieke cloudinfrastructuur. Een deel is beschikbaar op github (https://github.com/unknownhad/AWSAttacks). Volledige lijst is beschikbaar via API.
* [CodeNotary.io](https://www.codenotary.io/) — Open Source-platform met onweerlegbaar bewijs om code, bestanden, mappen of containers te notariëren.
* [crypteron.com](https://www.crypteron.com/) — Cloud-first, ontwikkelaarvriendelijk beveiligingsplatform voorkomt datalekken in .NET- en Java-toepassingen.
* [CyberChef](https://gchq.github.io/CyberChef/) — Een eenvoudige, intuïtieve webapp voor het analyseren en decoderen/encoderen van data zonder complexe tools of programmeertalen. Als een Zwitsers zakmes voor cryptografie & encryptie. Alle functies zijn gratis te gebruiken, zonder limiet. Open source als je zelf wilt hosten.
* [DAS](https://signup.styra.com/) — Styra DAS Free, Full lifecycle policy management om Open Policy Agent (OPA) autorisaties te maken, uit te rollen en te beheren.
* [Datree](https://www.datree.io/) — Open Source CLI-tool om Kubernetes-misconfiguraties te voorkomen door te waarborgen dat manifests en Helm-charts best practices én de beleidsregels van je organisatie volgen.
* [Dependabot](https://dependabot.com/) Geautomatiseerde dependency-updates voor Ruby, JavaScript, Python, PHP, Elixir, Rust, Java (Maven en Gradle), .NET, Go, Elm, Docker, Terraform, Git Submodules en GitHub Actions.
* [DJ Checkup](https://djcheckup.com) — Scan je Django-site op beveiligingsproblemen met deze gratis, geautomatiseerde checkup-tool. Geforkt van de Pony Checkup-site.
* [Doppler](https://doppler.com/) — Universele Secrets Manager voor applicatiegeheimen en config, met ondersteuning voor synchronisatie naar verschillende cloudproviders. Gratis voor vijf gebruikers met basis toegangscontrole.
* [Dotenv](https://dotenv.org/) — Synchroniseer je .env-bestanden, snel & veilig. Stop met het delen van je .env-bestanden via onveilige kanalen zoals Slack en e-mail, en raak nooit meer een belangrijk .env-bestand kwijt. Gratis tot 3 teamleden.
* [GitGuardian](https://www.gitguardian.com) — Houd geheimen buiten je broncode met automatische geheimentracking en herstel. Scan je git-repos op 350+ soorten geheimen en gevoelige bestanden – Gratis voor individuen en teams van 25 ontwikkelaars of minder.
* [Have I been pwned?](https://haveibeenpwned.com) — REST API voor het opvragen van informatie over datalekken.
* [hostedscan.com](https://hostedscan.com) — Online kwetsbaarheidsscanner voor webapplicaties, servers en netwerken. Tien gratis scans per maand.
* [Infisical](https://infisical.com/) — Open source platform waarmee je ontwikkelaarsgeheimen kunt beheren voor je team en infrastructuur: van lokale ontwikkeling tot staging/productie en 3rd-party diensten. Gratis tot 5 ontwikkelaars.
* [Internet.nl](https://internet.nl) — Test voor moderne internetstandaarden zoals IPv6, DNSSEC, HTTPS, DMARC, STARTTLS en DANE.
* [keychest.net](https://keychest.net) - SSL-vervalbeheer en certificaataankoop met geïntegreerde CT-database.
* [letsencrypt.org](https://letsencrypt.org/) — Gratis SSL-certificaatautoriteit met certificaten die door alle grote browsers worden vertrouwd.
* [meterian.io](https://www.meterian.io/) - Monitor Java-, Javascript-, .NET-, Scala-, Ruby- en NodeJS-projecten op beveiligingskwetsbaarheden in dependencies. Gratis voor één privéproject, onbeperkte projecten voor open source.
* [Mozilla Observatory](https://observatory.mozilla.org/) — Vind en repareer beveiligingsproblemen in je site.
* [opswat.com](https://www.opswat.com/) — Beveiligingsmonitoring van computers, apparaten, applicaties, configuraties. Gratis 25 gebruikers en 30 dagen geschiedenis.
* [openapi.security](https://openapi.security/) - Gratis tool om snel de beveiliging van elke OpenAPI/Swagger-gebaseerde API te controleren. Geen aanmelding nodig.
* [pixee.ai](https://pixee.ai) - Geautomatiseerde Product Security Engineer als gratis GitHub-bot die PR's indient op je Java-codebase om automatisch kwetsbaarheden op te lossen. Andere talen binnenkort!
* [pyup.io](https://pyup.io) — Monitor Python dependencies op beveiligingskwetsbaarheden en werk ze automatisch bij. Gratis voor één privéproject, onbeperkte projecten voor open source.
* [qualys.com](https://www.qualys.com/community-edition) — Vind kwetsbaarheden in webapps, audit op OWASP Risks.
* [report-uri.io](https://report-uri.io/) — CSP- en HPKP-overtredingsrapportage.
* [ringcaptcha.com](https://ringcaptcha.com/) — Tools om het telefoonnummer als ID te gebruiken, gratis beschikbaar.
* [seclookup.com](https://www.seclookup.com/) - Seclookup API's kunnen domeinbedreigingsindicatoren verrijken in SIEM, uitgebreide informatie bieden over domeinnamen en de detectie & respons op bedreigingen verbeteren. Ontvang 50K lookups gratis [hier](https://account.seclookup.com/).
* [snyk.io](https://snyk.io) — Kan bekende beveiligingskwetsbaarheden in je open source dependencies vinden en oplossen. Onbeperkte tests en herstel voor open source-projecten. Beperkt tot 200 tests/maand voor privéprojecten.
* [ssllabs.com](https://www.ssllabs.com/ssltest/) — Grondige analyse van de configuratie van elke SSL-webserver.
* [SOOS](https://soos.io) - Gratis, onbeperkte SCA-scans voor open source-projecten. Detecteer en los beveiligingsbedreigingen op vóór release. Bescherm je projecten met een simpele en effectieve oplossing.
* [StackHawk](https://www.stackhawk.com/) Automatiseer applicatiescans door je hele pipeline om beveiligingsbugs te vinden en op te lossen voordat ze in productie komen. Onbeperkt aantal scans en omgevingen voor één app.
* [Sucuri SiteCheck](https://sitecheck.sucuri.net) - Gratis websitebeveiligingscontrole en malware-scanner.
* [Protectumus](https://protectumus.com) - Gratis websitebeveiligingscontrole, site-antivirus en serverfirewall (WAF) voor PHP. E-mailmeldingen voor geregistreerde gebruikers in de gratis laag.
* [TestTLS.com](https://testtls.com) - Test een SSL/TLS-dienst op veilige serverconfiguratie, certificaten, ketens, etc. Niet beperkt tot HTTPS.
* [threatconnect.com](https://threatconnect.com) — Threat intelligence: ontworpen voor individuele onderzoekers, analisten en organisaties die beginnen met cyber threat intelligence. Gratis tot 3 gebruikers.
* [tinfoilsecurity.com](https://www.tinfoilsecurity.com/) — Geautomatiseerde kwetsbaarheidsscans. Het gratis plan staat wekelijkse XSS-scans toe.
* [Ubiq Security](https://ubiqsecurity.com/) — Versleutel en ontsleutel data met drie regels code en automatische sleutelbeheer. Gratis voor één applicatie en tot 1.000.000 encrypties per maand.
* [Virgil Security](https://virgilsecurity.com/) — Tools en diensten voor end-to-end encryptie, databasebeveiliging, IoT-beveiliging en meer in je digitale oplossing. Gratis voor applicaties met tot 250 gebruikers.
* [Vulert](https://vulert.com) - Vulert monitort continu je open source dependencies op nieuwe kwetsbaarheden, doet aanbevelingen voor fixes, zonder installatie of toegang tot je codebase. Gratis voor open source-projecten.
* [Escape GraphQL Quickscan](https://escape.tech/) - One-click beveiligingsscan van je GraphQL-eindpunten. Gratis, geen login vereist.
* [HasMySecretLeaked](https://gitguardian.com/hasmysecretleaked) - Doorzoek 20 miljoen gelekte geheimen in publieke GitHub-repositories, gists, issues en comments, gratis.
* [Project Gatekeeper](https://gatekeeper.binarybiology.top/) - Een alles-in-één SSL-toolkit met diverse functies zoals Private Key & CSR Generator, SSL-certificaatdecoder, certificaatmatcher en SSL-certificaat bestellen. Wij bieden gebruikers de mogelijkheid gratis SSL-certificaten van Let's Encrypt, Google Trust en BuyPass te genereren met behulp van CNAME-records in plaats van TXT-records.
**[⬆️ Terug naar boven](#table-of-contents)**

## Authenticatie, Autorisatie en Gebruikersbeheer

  * [Aserto](https://www.aserto.com) - Fijnmazige autorisatie als een dienst voor applicaties en API's. Gratis tot 1000 MAU's en 100 authorizer-instanties.
  * [asgardeo.io](https://wso2.com/asgardeo) - Naadloze integratie van SSO, MFA, wachtwoordloze authenticatie en meer. Inclusief SDK's voor frontend- en backend-apps. Gratis tot 1000 MAU's en vijf identiteitsproviders.
  * [Auth0](https://auth0.com/) — Gehoste SSO. Het gratis plan bevat 25.000 MAU's, onbeperkte sociale verbindingen, een aangepast domein en meer.
  * [Authgear](https://www.authgear.com) - Breng wachtwoordloos, OTP's, 2FA, SSO naar je apps in minuten. Alle front-end inbegrepen. Gratis tot 5000 MAU's.
  * [Authress](https://authress.io/) — Authenticatie login en toegangsbeheer, onbeperkte identiteitsproviders voor elk project. Facebook, Google, Twitter en meer. De eerste 1000 API-aanroepen zijn gratis.
  * [Authy](https://authy.com) - Twee-factor authenticatie (2FA) op meerdere apparaten, met back-ups. Drop-in vervanging voor Google Authenticator. Gratis tot 100 succesvolle authenticaties.
  * [Cerbos Hub](https://www.cerbos.dev/product-cerbos-hub) - Een compleet autorisatiebeheersysteem voor het opstellen, testen en implementeren van toegangsbeleid. Fijnmazige autorisatie en toegangscontrole, gratis tot 100 maandelijkse actieve principals.
  * [Clerk](https://clerk.com) — Gebruikersbeheer, authenticatie, 2FA/MFA, vooraf gebouwde UI-componenten voor inloggen, registreren, gebruikersprofielen en meer. Gratis tot 10.000 maandelijkse actieve gebruikers.
  * [Cloud-IAM](https://www.cloud-iam.com/) — Keycloak Identity and Access Management as a Service. Gratis tot 100 gebruikers en één realm.
  * [Corbado](https://www.corbado.com/) — Voeg passkey-first authenticatie toe aan nieuwe of bestaande apps. Gratis voor onbeperkte MAU's.
  * [Descope](https://www.descope.com/) — Zeer aanpasbare AuthN flows, biedt zowel een no-code als API/SDK aanpak, gratis 7.500 actieve gebruikers/maand, 50 tenants (tot 5 SAML/SSO tenants).
  * [duo.com](https://duo.com/) — Twee-factor authenticatie (2FA) voor website of app. Gratis voor tien gebruikers, alle authenticatiemethoden, onbeperkt, integraties, hardware tokens.
  * [Kinde](https://kinde.com/) - Simpele, robuuste authenticatie die je binnen enkele minuten met je product kunt integreren. Alles wat je nodig hebt om te beginnen met 7.500 gratis MAU's.
  * [logintc.com](https://www.logintc.com/) — Twee-factor authenticatie (2FA) via pushmeldingen, gratis voor tien gebruikers, VPN, websites en SSH
  * [MojoAuth](https://mojoauth.com/) - MojoAuth maakt het eenvoudig om wachtwoordloze authenticatie te implementeren op je web-, mobiele of andere applicatie in minuten.
  * [Okta](https://developer.okta.com/signup/) — Gebruikersbeheer, authenticatie en autorisatie. Gratis tot 100 maandelijkse actieve gebruikers.
  * [onelogin.com](https://www.onelogin.com/) — Identity as a Service (IDaaS), Single Sign-On Identity Provider, Cloud SSO IdP, drie bedrijfsapps en vijf persoonlijke apps, onbeperkte gebruikers
  * [Ory](https://ory.sh/) - AuthN/AuthZ/OAuth2.0/Zero Trust beheerd beveiligingsplatform. Altijd gratis ontwikkelaarsaccounts met alle beveiligingsfuncties, onbeperkte teamleden, 200 dagelijkse actieve gebruikers en 25k/maand permissiecontroles.
  * [Permit.io](https://permit.io) - Authorization-as-a-service providerplatform waarmee RBAC, ABAC en ReBAC mogelijk zijn voor schaalbare microservices met realtime updates en een no-code policy UI. Een gratis niveau van 1000 maandelijkse actieve gebruikers.
  * [Phase Two](https://phasetwo.io) - Keycloak Open Source Identity and Access Management. Gratis realm tot 1000 gebruikers, tot 10 SSO-verbindingen, met gebruik van Phase Two's Keycloak enhanced container inclusief de [Organization](https://phasetwo.io/product/organizations/) extensie.
  * [SSOJet](https://ssojet.com/) - Voeg Enterprise SSO toe zonder je authenticatie opnieuw te bouwen. Het gratis plan bevat onbeperkte maandelijkse actieve gebruikers, onbeperkte organisaties, 2 SSO & 2 SCIM-verbindingen.
  * [Stytch](https://www.stytch.com/) - Een alles-in-één platform dat API's en SDK's biedt voor authenticatie en fraudepreventie. Het gratis plan bevat 10.000 maandelijkse actieve gebruikers, onbeperkte organisaties, 5 SSO- of SCIM-verbindingen en 1.000 M2M-tokens.
  * [Stack Auth](https://stack-auth.com) — Open-source authenticatie zonder gedoe. De meest ontwikkelaarsvriendelijke oplossing, waarmee je binnen vijf minuten aan de slag kunt. Zelf te hosten voor gratis, of een beheerde SaaS-versie met 10k gratis maandelijkse actieve gebruikers.
  * [SuperTokens](https://supertokens.com/) - Open-source gebruikersauthenticatie die native integreert in je app - waardoor je snel kunt starten en controle hebt over de gebruikers- en ontwikkelaars-ervaring. Gratis tot 5000 MAU's.
  * [Warrant](https://warrant.dev/) — Gehoste autorisatie- en toegangsbeheer op ondernemingsniveau voor je apps. Het gratis niveau bevat 1 miljoen maandelijkse API-verzoeken en 1.000 authz-regels.
  * [ZITADEL Cloud](https://zitadel.com) — Een kant-en-klaar gebruikers- en toegangsbeheer dat werkt voor jou en multi-tenant (B2B) use-cases ondersteunt. Gratis tot 25.000 geauthentiseerde verzoeken, met alle beveiligingsfuncties (geen betaalmuur voor OTP, wachtwoordloos, beleid, enzovoort).
  * [PropelAuth](https://propelauth.com) — Verkoop direct aan bedrijven van elke grootte met een paar regels code, gratis tot 200 gebruikers en 10k Transactionele E-mails (met een watermark branding: "Powered by PropelAuth").
  * [Logto](https://logto.io/) - Ontwikkel, beveilig en beheer gebruikersidentiteiten van je product - voor zowel authenticatie als autorisatie. Gratis tot 5.000 MAU's met open-source zelfgehoste optie beschikbaar.
  * [WorkOS](https://workos.com/) - Gratis gebruikersbeheer en authenticatie tot 1 miljoen MAU's. Ondersteunt e-mail + wachtwoord, sociale authenticatie, Magic Auth, MFA en meer.

**[⬆️ Terug naar boven](#table-of-contents)**

## Distributie en Feedback van Mobiele Apps

  * [TestApp.io](https://testapp.io) - Jouw platform om ervoor te zorgen dat je mobiele apps werken zoals ze horen. Gratis plan: één app, analytics, onbeperkte versies & installaties, en feedbackverzameling.
  * [Loadly](https://loadly.io) - iOS & Android beta apps distributieservice biedt volledig gratis diensten met onbeperkte downloads, hoge downloadsnelheid en onbeperkte uploads.
  * [Diawi](https://www.diawi.com) - Zet iOS & Android apps direct op apparaten uit. Gratis plan: app uploads, met wachtwoord beveiligde links, 1-dag verloop, tien installaties.
  * [InstallOnAir](https://www.installonair.com) - Verspreid iOS & Android apps draadloos. Gratis plan: onbeperkte uploads, privé links, 2-dagen verloop voor gasten, 60 dagen voor geregistreerde gebruikers.
  * [GetUpdraft](https://www.getupdraft.com) - Verspreid mobiele apps voor testen. Het gratis plan bevat één app-project, drie app-versies, 500 MB opslag en 100 app-installaties per maand.
  * [Appho.st](https://appho.st) - Mobiele app hostingplatform. Het gratis plan bevat vijf apps, 50 maandelijkse downloads, en een maximale bestandsgrootte van 100 MB.

**[⬆️ Terug naar boven](#table-of-contents)**

## Managementsysteem

  * [bitnami.com](https://bitnami.com/) — Bereide apps op IaaS inzetten. Beheer van 1 AWS micro instance gratis
  * [Esper](https://esper.io) — MDM en MAM voor Android-apparaten met DevOps. Honderd apparaten gratis met één gebruikerslicentie en 25 MB applicatie-opslag.
  * [jamf.com](https://www.jamf.com/) —  Apparaatbeheer voor iPads, iPhones en Macs, drie apparaten gratis
  * [Miradore](https://miradore.com) — Apparaatbeheerdienst. Houd je apparaatvloot up-to-date en beveilig onbeperkt apparaten gratis. Het gratis plan biedt basisfuncties.
  * [moss.sh](https://moss.sh) - Helpt ontwikkelaars hun webapps en servers uit te rollen en te beheren. Gratis tot 25 git-deployments per maand
  * [runcloud.io](https://runcloud.io/) - Serverbeheer met focus op PHP-projecten. Gratis tot 1 server.
  * [ploi.io](https://ploi.io/) - Serverbeheertool om eenvoudig je servers & sites te beheren en uit te rollen. Gratis voor één server.
  * [xcloud.host](https://xcloud.host) — Serverbeheer- en uitrolplatform met een gebruiksvriendelijke interface. Gratis niveau beschikbaar voor één server.
  * [serveravatar.com](https://serveravatar.com) — Beheer en monitor PHP-gebaseerde webservers met geautomatiseerde configuraties. Gratis voor één server.

**[⬆️ Terug naar boven](#table-of-contents)**

## Messaging en Streaming

  * [Ably](https://www.ably.com/) - Realtime messaging-service met presence, persistentie en gegarandeerde levering. Het gratis plan bevat 3 miljoen berichten per maand, 100 piekverbindingen en 100 piekkanalen.
  * [cloudamqp.com](https://www.cloudamqp.com/) — RabbitMQ as a Service. Little Lemur plan: max 1 miljoen berichten/maand, max 20 gelijktijdige verbindingen, max 100 queues, max 10.000 gequeue'de berichten, meerdere nodes in verschillende AZ's
  * [courier.com](https://www.courier.com/) — Eén API voor push, in-app, e-mail, chat, SMS en andere messagingkanalen met templatebeheer en andere functies. Het gratis plan bevat 10.000 berichten/maand.
  * [engagespot.co](https://engagespot.co/) — Multi-channel notificatie-infrastructuur voor ontwikkelaars met een ingebouwde in-app inbox en no-code template editor. Gratis plan bevat 10.000 berichten/maand.
  * [HiveMQ](https://www.hivemq.com/mqtt-cloud-broker/) - Verbind je MQTT-apparaten met de Cloud Native IoT Messaging Broker.  Gratis om tot 100 apparaten te verbinden (geen creditcard nodig) voor altijd.
  * [knock.app](https://knock.app) – Notificatie-infrastructuur voor ontwikkelaars. Stuur naar meerdere kanalen zoals in-app, e-mail, SMS, Slack en push met één enkele API-call. Het gratis plan bevat 10.000 berichten/maand.
  * [NotificationAPI.com](https://www.notificationapi.com/) — Voeg gebruikersnotificaties toe aan elke software in 5 minuten. Het gratis plan bevat 10.000 notificaties/maand + 100 SMS en geautomatiseerde oproepen.
  * [Novu.co](https://novu.co) — De open-source notificatie-infrastructuur voor ontwikkelaars. Simpele componenten en API's voor het beheren van alle communicatiekanalen op één plek: e-mail, SMS, direct, in-app en push. Het gratis plan bevat 30.000 notificaties/maand met 90 dagen retentie.
  * [pusher.com](https://pusher.com/) — Realtime messaging-service. Gratis tot 100 gelijktijdige verbindingen en 200.000 berichten/dag
  * [scaledrone.com](https://www.scaledrone.com/) — Realtime messaging-service. Gratis tot 20 gelijktijdige verbindingen en 100.000 events/dag
  * [synadia.com](https://synadia.com/ngs) — [NATS.io](https://nats.io) as a service. Globaal, AWS, GCP en Azure. Altijd gratis met 4k berichtgrootte, 50 actieve verbindingen en 5GB data per maand.
  * [pubnub.com](https://www.pubnub.com/) - Swift, Kotlin en React messaging bij 1 miljoen transacties per maand. Transacties kunnen meerdere berichten bevatten.
  * [eyeson API](https://developers.eyeson.team/) - Een video-communicatie API-dienst gebaseerd op WebRTC (SFU, MCU) om videoplatforms te bouwen. Ondersteunt realtime data-injectie, videolayouts, opnames, een volledig uitgeruste gehoste web-UI (quickstart) of pakketten voor aangepaste UI's. Heeft een [gratis niveau voor ontwikkelaars](https://apiservice.eyeson.com/api-pricing) met 1000 vergaderminuten per maand.
  * [webpushr](https://www.webpushr.com/) - Web Push Notificaties - Gratis tot 10k abonnees, onbeperkte pushnotificaties, in-browser messaging
  * [httpSMS](https://httpsms.com) - Stuur en ontvang sms-berichten via je Android-telefoon als een SMS Gateway. Gratis tot 200 berichten per maand verzenden en ontvangen.
  * [EMQX Serverless](https://www.emqx.com/en/cloud/serverless-mqtt) - Schaalbare en veilige serverloze MQTT-broker die je in seconden kunt krijgen. 1M sessieminuten/maand altijd gratis (geen creditcard nodig).
  * [Pocket Alert](https://pocketalert.app) - Stuur pushnotificaties naar je iOS- en Android-apparaten. Integreer eenvoudig via API of webhooks en behoud volledige controle over je alerts. Gratis plan: 50 berichten per dag naar 1 apparaat en 1 applicatie.
  * [SuprSend](https://www.suprsend.com/) - SuprSend is een notificatie-infrastructuur die je productnotificaties stroomlijnt met een API-first benadering. Maak en lever transactionele, cron- en engagementnotificaties op meerdere kanalen met één notificatie-API. In het gratis plan krijg je 10.000 notificaties per maand, inclusief verschillende workflow nodes zoals samenvattingen, batches, multi-kanalen, voorkeuren, tenants, broadcasts en meer. 

**[⬆️ Terug naar boven](#table-of-contents)**

## Logbeheer

  * [bugfender.com](https://bugfender.com/) — Gratis tot 100k logregels/dag met 24 uur retentie
  * [logentries.com](https://logentries.com/) — Gratis tot 5 GB/maand met zeven dagen retentie
  * [loggly.com](https://www.loggly.com/) — Gratis voor één gebruiker, 200MB/dag met zeven dagen retentie
  * [logz.io](https://logz.io/) — Gratis tot 1 GB/dag, één dag retentie
  * [ManageEngine Log360 Cloud](https://www.manageengine.com/cloud-siem/) — Logbeheer-dienst aangedreven door Manage Engine. Gratis plan biedt 50 GB opslag met 15 dagen opslagretentie en 7 dagen zoeken.
  * [papertrailapp.com](https://papertrailapp.com/) — 48 uur zoeken, zeven dagen archief, 50 MB/maand
  * [sematext.com](https://sematext.com/logsene) — Gratis tot 500 MB/dag, zeven dagen retentie
  * [sumologic.com](https://www.sumologic.com/) — Gratis tot 500 MB/dag, zeven dagen retentie
  * [logflare.app](https://logflare.app/) — Gratis tot 12.960.000 entries per app per maand, 3 dagen retentie
  * [logtail.com](https://logtail.com/) — ClickHouse-gebaseerd SQL-compatibel logbeheer. Gratis tot 1 GB per maand, drie dagen retentie.
  * [logzab.com](https://logzab.com/) — Audit trail managementsysteem. Gratis 1.000 gebruikersactiviteit-logs per maand, 1 maand retentie, voor maximaal 5 projecten.
  * [openobserve.ai](https://openobserve.ai/) - 200 GB Ingestie/maand gratis, 15 dagen retentie
**[⬆️ Terug naar boven](#table-of-contents)**

## Vertaalbeheer

  * [crowdin.com](https://crowdin.com/) — Onbeperkte projecten, onbeperkte strings en medewerkers voor Open Source
  * [gitlocalize.com](https://gitlocalize.com) - Gratis en onbeperkt voor zowel private als publieke repositories
  * [Lecto](https://lecto.ai/) - Machine Translation API met gratis tier (30 gratis verzoeken, 1000 vertaalde tekens per verzoek). Geïntegreerd met de Loco Translate Wordpress plugin.
  * [lingohub.com](https://lingohub.com/) — Gratis tot 3 gebruikers, altijd gratis voor Open Source
  * [localazy.com](https://localazy.com) - Gratis voor 1000 bron-taal strings, onbeperkte talen, onbeperkte bijdragers, startup- en open source-deals
  * [Localeum](https://localeum.com) - Gratis tot 1000 strings, één gebruiker, onbeperkte talen, onbeperkte projecten
  * [localizely.com](https://localizely.com/) — Gratis voor Open Source
  * [Loco](https://localise.biz/) — Gratis tot 2000 vertalingen, onbeperkt aantal vertalers, tien talen/project, 1000 vertaalbare assets/project
  * [oneskyapp.com](https://www.oneskyapp.com/) — Beperkte gratis editie tot 5 gebruikers, gratis voor Open Source
  * [POEditor](https://poeditor.com/) — Gratis tot 1000 strings
  * [SimpleLocalize](https://simplelocalize.io/) - Gratis tot 100 vertaalsleutels, onbeperkte strings, onbeperkte talen, startup-deals
  * [Texterify](https://texterify.com/) - Gratis voor één gebruiker
  * [Tolgee](https://tolgee.io) - Gratis SaaS-aanbod met beperkte vertalingen, altijd gratis self-hosted versie
  * [transifex.com](https://www.transifex.com/) — Gratis voor Open Source
  * [Translation.io](https://translation.io) - Gratis voor Open Source
  * [Translized](https://translized.com) - Gratis tot 1000 strings, één gebruiker, onbeperkte talen, onbeperkte projecten
  * [webtranslateit.com](https://webtranslateit.com/) — Gratis tot 500 strings
  * [weblate.org](https://weblate.org/) — Gratis voor vrije projecten met tot 10.000 string-bronnen voor de gratis tier en onbeperkt self-hosted on-premises.
  * [Free PO editor](https://pofile.net/free-po-editor) — Gratis voor iedereen
  * [Lingo.dev](https://lingo.dev) – Open-source AI-aangedreven CLI voor web- & mobiele localisatie. Gebruik je eigen LLM, of gebruik elke maand 10.000 gratis woorden via de door Lingo.dev beheerde localisatie-engine.

**[⬆️ Terug naar boven](#table-of-contents)**

## Monitoring

  * [UptimeObserver.com](https://uptimeobserver.com) - Krijg 20 uptime monitors met 5-minuten intervallen en een aanpasbare statuspagina—ook voor commercieel gebruik. Onbeperkte, realtime meldingen via e-mail en Telegram. Geen creditcard nodig om te starten.
  * [Pingmeter.com](https://pingmeter.com/) - 5 uptime monitors met 10-minuten interval. Monitor SSH, HTTP, HTTPS en elke aangepaste TCP-poort.
  * [alerty.ai](https://www.alerty.ai) - Gratis APM en monitoring voor je FE, BE, DB en meer + gratis agent runs.
  * [appdynamics.com](https://www.appdynamics.com/) — Gratis voor 24-uurs metrics, application performance management agents beperkt tot één Java, één .NET, één PHP en één Node.js
  * [appneta.com](https://www.appneta.com/) — Gratis met 1 uur dataretentie
  * [appspector.com](https://appspector.com/) - Mission control voor remote iOS/Android/Flutter debugging. Gratis voor klein verkeersgebruik (64MB aan logs).
  * [assertible.com](https://assertible.com) — Geautomatiseerde API-tests en monitoring. Gratis plannen voor teams en individuen.
  * [bleemeo.com](https://bleemeo.com) - Gratis voor 3 servers, 5 uptime monitors, onbeperkte gebruikers, onbeperkte dashboards, onbeperkte waarschuwingsregels.
  * [Core Web Vitals History](https://punits.dev/core-web-vitals-historical/) - Vind Core Web Vitals geschiedenis voor een url of website.
  * [checklyhq.com](https://checklyhq.com) - Open source E2E / Synthetische monitoring en diepgaande API-monitoring voor ontwikkelaars. Gratis plan met één gebruiker en 10k API & netwerk / 1,5k browser check runs.
  * [cloudsploit.com](https://cloudsploit.com) — AWS-beveiliging en configuratiemonitoring. Gratis: onbeperkt on-demand scans, onbeperkte gebruikers, onbeperkt opgeslagen accounts. Abonnement: geautomatiseerde scans, API-toegang, enz.
  * [cronitor.io](https://cronitor.io/) - Prestatie-inzichten en uptime monitoring voor cron jobs, websites, API's en meer. Een gratis tier met vijf monitors.
  * [datadoghq.com](https://www.datadoghq.com/) — Gratis tot 5 nodes
  * [deadmanssnitch.com](https://deadmanssnitch.com/) — Monitoring voor cron jobs. Eén gratis snitch (monitor), meer als je anderen aanmeldt
  * [downtimemonkey.com](https://downtimemonkey.com/) — 60 uptime monitors, 5-minuten interval. E-mail, Slack meldingen.
  * [economize.cloud](https://economize.cloud) — Economize helpt cloud infrastructuurkosten te verduidelijken door cloud resources te organiseren om te optimaliseren en te rapporteren. Gratis tot $5.000 aan Google Cloud Platform-uitgaven per maand.
  * [elastic.co](https://www.elastic.co/solutions/apm) — Directe prestatie-inzichten voor JS-ontwikkelaars. Gratis met 24-uurs dataretentie
  * [fivenines.io](https://fivenines.io/) — Linux server monitoring met realtime dashboards en meldingen — altijd gratis voor tot 5 servers met 60-seconden interval. Geen creditcard vereist.
  * [Grafana Cloud](https://grafana.com/products/cloud/) - Grafana Cloud is een samenstelbaar observatieplatform dat metrics en logs integreert met Grafana. Gratis: 3 gebruikers, tien dashboards, 100 alerts, metrics opslag in Prometheus en Graphite (10.000 series, 14 dagen retentie), logs opslag in Loki (50 GB logs, 14 dagen retentie)
  * [healthchecks.io](https://healthchecks.io) — Monitor je cron jobs en achtergrondtaken. Gratis tot 20 checks.
  * [Hydrozen.io](https://hydrozen.io) — Uptime monitoring & Statuspagina's, gratis plan: 10 uptime monitors, 5 heartbeat monitors, 1 domeinmonitor en 1 statuspagina gratis.
  * [incidenthub.cloud](https://incidenthub.cloud/) — Cloud en SaaS statuspagina-aggregator - 20 monitors en 2 notificatiekanalen (Slack en Discord) zijn voor altijd gratis.
  * [inspector.dev](https://www.inspector.dev) - Een compleet realtime monitoringsdashboard in minder dan een minuut met een altijd gratis tier.
  * [instrumentalapp.com](https://instrumentalapp.com) - Mooie en gebruiksvriendelijke applicatie- en servermonitoring met tot 500 metrics en 3 uur data-inzicht gratis
  * [keychest.net/speedtest](https://keychest.net/speedtest) - Onafhankelijke speedtest en TLS-handshake latency test tegen Digital Ocean
  * [letsmonitor.org](https://letsmonitor.org) - SSL-monitoring, gratis tot 5 monitors
  * [linkok.com](https://linkok.com) - Online broken link checker, gratis voor kleine websites tot 100 pagina's, volledig gratis voor open-source projecten.
  * [loader.io](https://loader.io/) — Gratis load testing tools met beperkingen
  * [MonitorMonk](https://monitormonk.com) - Minimalistische uptime monitoring met mooie statuspagina's. Het Forever Free plan biedt HTTPS-, Keyword-, SSL- en Response-time monitoring voor 10 websites of api-endpoints, en levert 2 dashboards/statuspagina's.
  * [netdata.cloud](https://www.netdata.cloud/) — Netdata is een open-source tool om realtime metrics te verzamelen. Het is een groeiend product en ook te vinden op GitHub!
  * [newrelic.com](https://www.newrelic.com) — New Relic observability platform, gebouwd om ingenieurs te helpen perfectere software te maken. Van monolieten tot serverless, instrumenteer alles en analyseer, los op en optimaliseer je volledige softwarestack. Het gratis tier biedt 100GB/maand gratis data-inname, één gratis full-access gebruiker, en onbeperkt aantal gratis primaire gebruikers.
  * [Middleware.io](https://middleware.io/) - Middleware observability platform biedt volledig inzicht in je apps & stack, zodat je problemen op schaal kunt monitoren & diagnosticeren. Ze hebben een altijd gratis plan voor Dev community gebruik waarmee je log monitoring kunt doen voor tot 1M log events, infrastructuur monitoring & APM voor tot 2 hosts.
  * [nixstats.com](https://nixstats.com) - Gratis voor één server. E-mailnotificaties, publieke statuspagina, 60-seconden interval en meer.
  * [OnlineOrNot.com](https://onlineornot.com/) - OnlineOrNot biedt uptime monitoring voor websites en API's, monitoring voor cron jobs en geplande taken. Biedt ook statuspagina's. De eerste vijf checks met 3-minuten interval zijn gratis. De gratis tier stuurt meldingen via Slack, Discord en E-mail.
  * [OntarioNet.ca CN Test](https://cntest.ontarionet.ca) — Controleer of een website wordt geblokkeerd in China door de Grote Firewall. Identificeert DNS-vervuiling door DNS-resultaten en ASN-informatie te vergelijken van servers in China versus servers in de Verenigde Staten.
  * [opsgenie.com](https://www.opsgenie.com/) — Krachtige alerting en on-call management voor het draaien van always-on services. Gratis tot 5 gebruikers.
  * [paessler.com](https://www.paessler.com/) — Krachtige infrastructuur- en netwerkmonitoringsoplossing, inclusief alerting, sterke visualisaties en basisrapportages. Gratis tot 100 sensoren.
  * [pagecrawl.io](https://pagecrawl.io/) -  Monitor websitewijzigingen, gratis tot 6 monitors met dagelijkse checks.
  * [syagent.com](https://syagent.com/) — Niet-commerciële gratis server monitoring service, meldingen en metrics.
  * [pagerly.io](https://pagerly.io/) -  Beheer on-calls op Slack  (integreert met Pagerduty, OpsGenie). Gratis tot 1 team (één team verwijst naar één on-call)
  * [pagertree.com](https://pagertree.com/) - Simpele interface voor alerting en on-call management. Gratis tot 5 gebruikers.
  * [phare.io](https://phare.io/) - Uptime monitoring gratis tot 100.000 events voor onbeperkte projecten en onbeperkte statuspagina's.
  * [pingbreak.com](https://pingbreak.com/) — Moderne uptime monitoring service. Check onbeperkt aantal URL's en ontvang downtime meldingen via Discord, Slack of e-mail.
  * [pingpong.one](https://pingpong.one/) — Geavanceerd statuspagina-platform met monitoring. De gratis tier bevat één publieke aanpasbare statuspagina met een SSL-subdomein. Pro-plan wordt gratis aangeboden aan open-source projecten en non-profits.
  * [robusta.dev](https://home.robusta.dev/) — Krachtige Kubernetes monitoring gebaseerd op Prometheus. Gebruik je eigen Prometheus of installeer de all-in-one bundel. De gratis tier bevat tot 20 Kubernetes nodes. Alerts via Slack, Microsoft Teams, Discord en meer. Integraties met PagerDuty, OpsGenie, VictorOps, DataDog en vele andere tools.
  * [sematext.com](https://sematext.com/) — Gratis voor 24-uurs metrics, onbeperkt aantal servers, tien eigen metrics, 500.000 eigen metric datapoints, onbeperkte dashboards, gebruikers, enz.
  * [sitemonki.com](https://sitemonki.com/) — Website-, domein-, Cron- & SSL-monitoring, 5 monitors in elke categorie gratis
  * [sitesure.net](https://sitesure.net) - Website- en cron monitoring - 2 monitors gratis
  * [skylight.io](https://www.skylight.io/) — Gratis voor de eerste 100.000 requests (alleen Rails)
  * [speedchecker.xyz](https://probeapi.speedchecker.xyz/) — Performance Monitoring API, controleert Ping, DNS, enz.
  * [stathat.com](https://www.stathat.com/) — Begin met tien statistieken gratis, geen vervaldatum
  * [statuscake.com](https://www.statuscake.com/) — Website monitoring, onbeperkt aantal tests gratis met beperkingen
  * [statusgator.com](https://statusgator.com/) — Statuspagina monitoring, 3 monitors gratis
  * [SweetUptime](https://dicloud.net/sweetuptime-server-uptime-monitoring/) — Server monitoring, uptime monitoring, DNS & domein monitoring. Monitor 10 servers, 10 uptimes en 10 domeinen gratis.
  * [thousandeyes.com](https://www.thousandeyes.com/) — Netwerk- en gebruikerservaring monitoring. 3 locaties en 20 datafeeds van grote webservices gratis
  * [uptimetoolbox.com](https://uptimetoolbox.com/) — Gratis monitoring voor vijf websites, 60-seconden intervallen, publieke statuspagina.
  * [zenduty.com](https://www.zenduty.com/) — End-to-end incident management, alerting, on-call management en response orkestratieplatform voor netwerkoperaties, site reliability engineering en DevOps-teams. Gratis tot 5 gebruikers.
  * [instatus.com](https://instatus.com) - Maak een mooie statuspagina in 10 seconden. Altijd gratis met onbeperkt aantal abonnees en onbeperkte teams.
  * [Squadcast.com](https://squadcast.com) - Squadcast is een end-to-end incident management software ontworpen om SRE best practices te bevorderen. Altijd gratis plan beschikbaar voor tot 10 gebruikers.
  * [RoboMiri.com](https://robomiri.com/) - RoboMiri is een stabiele uptime monitor die een breed scala aan monitors biedt: cronjob, keyword, website, poort, ping. Vijfentwintig uptime checks met 3-minuten interval gratis. Meldingen via telefoon, SMS, e-mail en webhooks.
  * [Better Stack](https://betterstack.com/better-uptime) - Uptime monitoring, incident management, on-call planning/meldingen en statuspagina's in één product. Het gratis plan omvat tien monitors met 3-minuten checkfrequentie en statuspagina's.
  * [Pulsetic](https://pulsetic.com) - 10 monitors, 6 maanden aan historische uptime/logs, onbeperkte statuspagina's en aangepaste domeinen inbegrepen! Voor onbeperkte tijd en onbeperkte e-mailalerts gratis. Geen creditcard nodig.
  * [Wachete](https://www.wachete.com) - monitor vijf pagina's, controles elke 24 uur.
  * [Xitoring.com](https://xitoring.com/) — Uptime monitoring: 20 gratis, Linux- en Windows Server monitoring: 5 gratis, Statuspagina: 1 gratis - Mobiele app, meerdere notificatiekanalen en veel meer!
  * [Servervana](https://servervana.com) - Geavanceerde uptime monitoring met ondersteuning voor grote projecten en teams. Biedt HTTP monitoring, browsergebaseerde monitoring, DNS monitoring, domeinmonitoring, statuspagina's en meer. De gratis tier bevat 10 HTTP monitors, 1 DNS monitor en één statuspagina.

**[⬆️ Terug naar boven](#table-of-contents)**

## Crash- en exceptieafhandeling
* [CatchJS.com](https://catchjs.com/) - JavaScript foutopsporing met screenshots en kliksporen. Gratis voor open-source projecten.
* [bugsnag.com](https://www.bugsnag.com/) — Gratis tot 2.000 fouten/maand na de initiële proefperiode
* [elmah.io](https://elmah.io/) — Foutlogging en uptime monitoring voor webontwikkelaars. Gratis Small Business-abonnement voor open-source projecten.
* [Embrace](https://embrace.io/) — Monitoring van mobiele apps. Gratis voor kleine teams tot 1 miljoen gebruikerssessies per jaar.
* [exceptionless](https://exceptionless.com) — Realtime fout-, feature- en lograpportage, en meer. Gratis voor 3k events per maand/1 gebruiker. Open source en eenvoudig zelf te hosten voor onbeperkt gebruik.
* [GlitchTip](https://glitchtip.com/) — Eenvoudige, open-source foutopsporing. Compatibel met open-source Sentry SDK's. 1000 events per maand gratis, of zelf te hosten zonder limieten.
* [honeybadger.io](https://www.honeybadger.io) - Exception-, uptime- en cron-monitoring. Gratis voor kleine teams en open-source projecten (12.000 fouten/maand).
* [memfault.com](https://memfault.com) — Cloud platform voor apparaatobservatie en debugging. 100 apparaten gratis voor [Nordic](https://app.memfault.com/register-nordic), [NXP](https://app.memfault.com/register-nxp), en [Laird](https://app.memfault.com/register-laird) apparaten.
* [rollbar.com](https://rollbar.com/) — Exception- en foutmonitoring, gratis plan met 5.000 fouten/maand, onbeperkte gebruikers, 30 dagen retentie.
* [sentry.io](https://sentry.io/) — Sentry volgt app-excepties realtime en heeft een klein gratis plan. Gratis voor 5k fouten per maand/1 gebruiker, onbeperkt gebruik bij zelfhosting.
* [Axiom](https://axiom.co/) — Sla tot 0,5 TB aan logs op met 30 dagen retentie. Inclusief integraties met platforms zoals Vercel en geavanceerde dataquery's met email/Discord-meldingen.
* [Semaphr](https://semaphr.com) — Gratis all-in-one kill switch voor je mobiele apps.
* [Jam](https://jam.dev) - Ontwikkelaarsvriendelijke bugrapporten in één klik. Gratis plan met onbeperkte jams.
* [Whitespace](https://whitespace.dev) – Bugrapporten met één klik direct in je browser. Gratis plan met onbeperkte opnames voor persoonlijk gebruik.

**[⬆️ Terug naar boven](#table-of-contents)**

## Zoeken

* [algolia.com](https://www.algolia.com/) — Gehoste zoekoplossing met typo-tolerantie, relevantie en UI-bibliotheken om eenvoudig zoekervaringen te creëren. Het gratis "Build" plan bevat 1M documenten en 10K zoekopdrachten/maand. Biedt ook [developer documentation search](https://docsearch.algolia.com/) gratis aan.
* [bonsai.io](https://bonsai.io/) — Gratis 1 GB geheugen en 1 GB opslag
* [CommandBar](https://www.commandbar.com/) - Unified Search Bar as-a-service, webgebaseerde UI-widget/plugin waarmee je gebruikers de inhoud, navigatie, features, enz. binnen je product kunnen doorzoeken, wat de vindbaarheid vergroot. Gratis tot 1.000 maandelijkse actieve gebruikers, onbeperkte commando's.
* [Orama Cloud](https://orama.com/pricing) — Gratis 3 indexen, 100K docs/index, onbeperkte full-text/vector/hybride zoekopdrachten, 60 dagen analytics
* [searchly.com](http://www.searchly.com/) — Gratis 2 indices en 20 MB opslag
* [easysitesearch.com](https://easysitesearch.com/) — Zoekwidget en API, met geautomatiseerde web-crawler gebaseerde indexering. Onbeperkte zoekopdrachten gratis, tot 50 subpagina's.

**[⬆️ Terug naar boven](#table-of-contents)**

## Educatie en loopbaanontwikkeling

* [FreeCodeCamp](https://www.freecodecamp.org/) - Open-source platform dat gratis cursussen en certificeringen aanbiedt in Data Analyse, Informatiebeveiliging, Webontwikkeling en meer.
* [The Odin Project](https://www.theodinproject.com/) - Gratis, open-source platform met een curriculum gericht op JavaScript en Ruby voor webontwikkeling.
* [Free Professional Resume Templates & Editor](https://www.overleaf.com/latex/templates/tagged/cv) - Gratis platform met veel cv-sjablonen van ervaren professionals, volledig te klonen, bewerken en downloaden, ATS geoptimaliseerd.
* [DeepLearning.AI Short Courses](https://www.deeplearning.ai/short-courses/) - Gratis korte cursussen van toonaangevende experts om hands-on ervaring op te doen met de nieuwste generatieve AI-tools en -technieken in een uur of minder.
* [LabEx](https://labex.io) - Ontwikkel vaardigheden in Linux, DevOps, Cybersecurity, Programmeren, Data Science en meer via interactieve labs en praktijkprojecten.
* [Roadmap.sh](https://roadmap.sh) - Gratis leerroadmaps die alle aspecten van ontwikkeling bestrijken, van Blockchain tot UX Design.
* [Cisco Networking Academy, Skills for All](https://skillsforall.com/) - Biedt gratis certificeringsgerichte cursussen aan in onderwerpen zoals cybersecurity, netwerken en Python.
* [MIT OpenCourseWare](https://ocw.mit.edu/) - MIT OpenCourseWare is een online publicatie van materiaal uit meer dan 2.500 MIT-cursussen, en deelt gratis kennis met studenten en docenten wereldwijd. Youtube-kanaal te vinden op [@mitocw](https://www.youtube.com/@mitocw/featured)
* [W3Schools](https://www.w3schools.com/) - Biedt gratis tutorials over webontwikkelingstechnologieën zoals HTML, CSS, JavaScript en meer.
* [Khan Academy](https://www.khanacademy.org/computing/computer-programming) - Gratis online gidsen voor het leren van basis en gevorderde HTML/CSS, JavaScript en SQL.
* [Full Stack Open](https://fullstackopen.com/en/) – Gratis universitair niveau cursus over moderne webontwikkeling met React, Node.js, GraphQL, TypeScript en meer. Volledig online en in eigen tempo.
* [edX](https://www.edx.org/) - Biedt toegang tot meer dan 4.000 gratis online cursussen van 250 toonaangevende instellingen, waaronder Harvard en MIT, met specialisatie in computerwetenschappen, engineering en data science.
* [Django-tutorial.dev](https://django-tutorial.dev) - Gratis online gidsen om Django als eerste framework te leren & geeft gratis dofollow backlink naar artikelen geschreven door gebruikers.

**[⬆️ Terug naar boven](#table-of-contents)**

## E-mail

* [10minutemail](https://10minutemail.com) - Gratis, tijdelijk e-mailadres voor testdoeleinden.
* [AhaSend](https://ahasend.com) - Transactionele e-maildienst, gratis voor 1000 e-mails per maand, met onbeperkte domeinen, teamleden, webhooks en berichtsroutes in het gratis plan.
* [AnonAddy](https://anonaddy.com) - Open-source anonieme e-mail forwarding, maak onbeperkt e-mailaliassen gratis aan.
* [Antideo](https://www.antideo.com/) — 10 API-verzoeken per uur voor e-mailverificatie, IP- en telefoonnummer-validatie in de gratis laag. Geen creditcard vereist.
* [Brevo](https://www.brevo.com/) — 9.000 e-mails/maand, 300 e-mails/dag gratis
* [OneSignal](https://onesignal.com/) — 10.000 e-mails/maand, geen creditcard vereist.
* [Bump](https://bump.email/) - Gratis 10 Bump e-mailadressen, één eigen domein
* [Burnermail](https://burnermail.io/) – Gratis 5 Burner e-mailadressen, 1 mailbox, 7 dagen mailboxgeschiedenis
* [Buttondown](https://buttondown.email/) — Nieuwsbrievendienst. Tot 100 abonnees gratis
* [CloudMailin](https://www.cloudmailin.com/) - Inkomende e-mail via HTTP POST en transactionele uitgaande e-mail - 10.000 gratis e-mails/maand
* [Contact.do](https://contact.do/) — Contactformulier in een link (bitly voor contactformulieren)
* [debugmail.io](https://debugmail.io/) — Gebruiksvriendelijke testmailserver voor ontwikkelaars
* [DNSExit](https://dnsexit.com/) - Tot 2 e-mailadressen onder je domein gratis met 100 MB opslagruimte. IMAP, POP3, SMTP, SPF/DKIM-ondersteuning.
* [EmailLabs.io](https://emaillabs.io/en) — Verstuur tot 9.000 e-mails elke maand gratis, tot 300 e-mails dagelijks.
* [EmailOctopus](https://emailoctopus.com) - Tot 2.500 abonnees en 10.000 e-mails per maand gratis
* [EmailJS](https://www.emailjs.com/) – Dit is geen volledige mailserver; dit is enkel een mailclient waarmee je direct vanuit de client e-mails kunt versturen zonder je credentials bloot te geven, de gratis laag heeft 200 maandelijkse verzoeken, 2 e-mailsjablonen, verzoeken tot 50Kb, beperkte contactgeschiedenis.
* [EtherealMail](https://ethereal.email) - Ethereal is een fake SMTP-dienst, voornamelijk gericht op Nodemailer en EmailEngine gebruikers (maar niet beperkt tot). Het is een volledig gratis anti-transactionele e-mailservice waarbij berichten nooit worden afgeleverd.
* [Temp-Mail.org](https://temp-mail.org/en/) - Tijdelijke/disposable mailgenerator met diverse domeinen. E-mailadres wordt vernieuwd telkens als de pagina wordt herladen. Volledig gratis zonder prijsmodellen.
* [TempMailDetector.com](https://tempmaildetector.com/) - Controleer tot 200 e-mails per maand gratis om te zien of een e-mail tijdelijk is of niet.
* [Emailvalidation.io](https://emailvalidation.io) - 100 gratis e-mailverificaties per maand
* [FakeMailGenerator.com](https://www.fakemailgenerator.com/) - Een Duitse tijdelijke/disposable mailgenerator. Ondersteunt 10 domeinen en biedt de vrijheid om onbeperkt adressen aan te maken. (inclusief advertenties), maar verder volledig gratis.
* [forwardemail.net](https://forwardemail.net) — Gratis e-mailforwarding voor eigen domeinen. Maak en forward onbeperkt e-mailadressen met je domeinnaam (**let op**: Betaling vereist bij gebruik van .casa, .cf, .click, .email, .fit, .ga, .gdn, .gq, .lat, .loan, .london, .men, .ml, .pl, .rest, .ru, .tk, .top, .work TLD's vanwege spam)
* [Imitate Email](https://imitate.email) - Sandbox mailserver voor het testen van e-mailfunctionaliteit over build/qa en ci/cd. Gratis accounts ontvangen 15 e-mails per dag, voor altijd.
* [ImprovMX](https://improvmx.com) – Gratis e-mail forwarding.
* [EForw](https://www.eforw.com) – Gratis e-mail forwarding voor één domein. Ontvang en verzend e-mails vanaf je domein.
* [Inboxes App](https://inboxesapp.com) — Maak tot 3 tijdelijke e-mails per dag aan, verwijder ze vervolgens eenvoudig met een handige Chrome-extensie. Perfect voor het testen van aanmeldflows.
* [inboxkitten.com](https://inboxkitten.com/) - Gratis tijdelijke/disposable mailbox, met tot 3 dagen automatische verwijdering van e-mails. Open-source en zelf te hosten.
* [mail-tester.com](https://www.mail-tester.com/) — Test of de DNS/SPF/DKIM/DMARC-instellingen van de e-mail correct zijn, 20 gratis/maand.
* [dkimvalidator.com](https://dkimvalidator.com/) - Test of de DNS/SPF/DKIM/DMARC-instellingen van de e-mail correct zijn, gratis dienst van roundsphere.com
* [mailcatcher.me](https://mailcatcher.me/) — Vangt e-mail op en toont deze via een webinterface.
* [mailchannels.com](https://www.mailchannels.com) - E-mail-API met REST API en SMTP-integraties, gratis tot 3.000 e-mails/maand.
* [Mailcheck.ai](https://www.mailcheck.ai/) - Voorkom dat gebruikers zich aanmelden met tijdelijke e-mailadressen, 120 verzoeken/uur (~86.400 per maand)
* [Mailchimp](https://mailchimp.com/) — 500 abonnees en 1.000 e-mails/maand gratis.
* [Maildroppa](https://maildroppa.com) - Tot 100 abonnees en onbeperkt e-mails plus automatiseringen gratis.
* [MailerLite.com](https://www.mailerlite.com) — 1.000 abonnees/maand, 12.000 e-mails/maand gratis
* [MailerSend.com](https://www.mailersend.com) — E-mail API, SMTP, 3.000 e-mails/maand gratis voor transactionele e-mails
* [mailinator.com](https://www.mailinator.com/) — Gratis, openbaar e-mailsysteem waar je elke gewenste inbox kunt gebruiken
* [Mailjet](https://www.mailjet.com/) — 6.000 e-mails/maand gratis (200 e-mails dagelijks verzendlimiet)
* [Mailnesia](https://mailnesia.com) - Gratis tijdelijke/disposable e-mail, die automatisch registratie-links bezoekt.
* [mailsac.com](https://mailsac.com) - Gratis API voor tijdelijke e-mailtesten, gratis publieke e-mailhosting, uitgaande capture, e-mail-naar-slack/websocket/webhook (1.500 maandelijkse API-limiet)
* [Mailtrap.io](https://mailtrap.io/) — Fake SMTP-server voor ontwikkeling, gratis plan met één inbox, 100 berichten, geen teamleden, twee e-mails/seconde, geen forwardregels.
* [Mail7.io](https://www.mail7.io/) — Gratis temp e-mailadressen voor QA-ontwikkelaars. Maak direct e-mailadressen aan via webinterface of API.
* [Momentary Email](https://www.momentaryemail.com/) — Gratis tijdelijke e-mailadressen. Lees inkomende e-mails op de website of via RSS-feed.
* [Mutant Mail](https://www.mutantmail.com/) – Gratis 10 e-mail-ID's, 1 domein, 1 mailbox. Eén mailbox voor alle e-mail-ID's.
* [Outlook.com](https://outlook.live.com/owa/) - Gratis persoonlijke e-mail en agenda.
* [Parsio.io](https://parsio.io) — Gratis e-mailparser (stuur e-mail door, extraheer de gegevens, stuur naar je server)
* [pepipost.com](https://pepipost.com) — 30k e-mails gratis in de eerste maand, daarna de eerste 100 e-mails/dag gratis.
* [Plunk](https://useplunk.com) - 3K e-mails/maand gratis
* [Postmark](https://postmarkapp.com/) - 100 e-mails/maand gratis, onbeperkte DMARC wekelijkse rapportages.
* [Proton Mail](https://proton.me/mail) -  Gratis veilige e-maildienst met ingebouwde end-to-end encryptie. Gratis 1GB opslag.
* [Queuemail.dev](https://queuemail.dev) — Betrouwbare e-mail delivery API. Gratis laag (10.000 e-mails/maand). Verstuur asynchroon. Gebruik meerdere SMTP-servers. Blocklists, logging, tracking, webhooks en meer.
* [QuickEmailVerification](https://quickemailverification.com) — Verifieer 100 e-mails dagelijks gratis op een gratis laag samen met andere gratis API's zoals DEA Detector, DNS Lookup, SPF Detector en meer.
* [Resend](https://resend.com) - Transactionele e-mail API voor ontwikkelaars. 3.000 e-mails/maand, 100 e-mails/dag gratis, één aangepast domein.
* [Sender](https://www.sender.net) Tot 15.000 e-mails/maand, tot 2.500 abonnees
* [Sendpulse](https://sendpulse.com) — 500 abonnees/maand, 15.000 e-mails/maand gratis
* [SimpleLogin](https://simplelogin.io/) – Open source, zelf-hostbare e-mail alias/doorstuur oplossing. Gratis 5 aliassen, onbeperkte bandbreedte, onbeperkt antwoorden/verzenden. Gratis voor onderwijspersoneel (student, onderzoeker, etc.).
* [Substack](https://substack.com) — Onbeperkt gratis nieuwsbriefdienst. Je gaat pas betalen als je er geld voor vraagt.
* [Sweego](https://www.sweego.io/) - Europese transactionele e-mail API voor ontwikkelaars. 500 e-mails/dag gratis.
* [Takeout](https://takeout.bysourfruit.com) - Een voortdurend bijgewerkte e-mailservice die het verzenden van e-mails eenvoudig maakt. Vijfhonderd transactionele e-mails/maand gratis.
* [temp-mail.io](https://temp-mail.io) — Gratis wegwerp tijdelijke e-mailservice met meerdere e-mails tegelijk en doorsturen
* [tinyletter.com](https://tinyletter.com/) — 5.000 abonnees/maand gratis
* [Touchlead](https://touchlead.app) - Een veelzijdige marketing automation tool, met leadbeheer, formulierbouwer en automatisering. Gratis voor een beperkt aantal leads en automatiseringen
* [trashmail.com](https://www.trashmail.com) - Gratis wegwerp e-mailadressen met doorsturen en automatische adresvervaldatum
* [Tuta](https://tuta.com/) - Gratis veilige e-mailserviceprovider met ingebouwde end-to-end encryptie, geen advertenties, geen tracking. Gratis 1GB opslag, één agenda (Tuta heeft ook een [betaald abonnement](https://tuta.com/pricing).). Tuta is ook deels [open source](https://github.com/tutao/tutanota), zodat je zelf kunt hosten.
* [Verifalia](https://verifalia.com/email-verification-api) — Real-time e-mail verificatie API met mailboxbevestiging en wegwerp e-mail adres detector; 25 gratis e-mailverificaties/dag.
* [verimail.io](https://verimail.io/) — Bulk- en API-e-mailverificatieservice. 100 gratis verificaties/maand
* [Zoho](https://www.zoho.com) — Begonnen als een e-mailprovider maar biedt nu een reeks diensten, waarvan sommige gratis abonnementen hebben. Lijst van diensten met gratis abonnement:
   - [Email](https://zoho.com/mail) Gratis voor 5 gebruikers. 5GB/gebruiker & 25 MB bijlage limiet, één domein.
   - [Zoho Assist](https://www.zoho.com/assist) — Het gratis Zoho Assist-abonnement bevat één gelijktijdige remote support licentie en toegang tot 5 onbeheerde computerlicenties voor onbeperkte duur, beschikbaar voor zowel professioneel als persoonlijk gebruik.
   - [Sprints](https://zoho.com/sprints) Gratis voor 5 gebruikers, 5 projecten & 500MB opslag.
   - [Docs](https://zoho.com/docs) — Gratis voor 5 gebruikers met 1 GB uploadlimiet & 5GB opslag. Zoho Office Suite (Writer, Sheets & Show) wordt meegeleverd.
   - [Projects](https://zoho.com/projects) — Gratis voor 3 gebruikers, 2 projecten & 10 MB bijlage limiet. Hetzelfde plan geldt voor [Bugtracker](https://zoho.com/bugtracker).
   - [Connect](https://zoho.com/connect) — Team samenwerking gratis voor 25 gebruikers met drie groepen, drie aangepaste apps, 3 borden, 3 handleidingen, en 10 integraties samen met kanalen, evenementen & forums.
   - [Meeting](https://zoho.com/meeting) — Vergaderingen met maximaal 3 deelnemers & 10 Webinar deelnemers.
   - [Vault](https://zoho.com/vault) — Wachtwoordbeheer toegankelijk voor individuen.
   - [Showtime](https://zoho.com/showtime) — Nog een vergadersoftware voor training voor een remote sessie tot 5 deelnemers.
   - [Notebook](https://zoho.com/notebook) — Een gratis alternatief voor Evernote.
   - [Wiki](https://zoho.com/wiki) — Gratis voor drie gebruikers met 50 MB opslag, onbeperkt pagina's, zip-backups, RSS & Atom feed, toegangscontrole & aanpasbare CSS.
   - [Subscriptions](https://zoho.com/subscriptions) — Recurring Billing management gratis voor 20 klanten/abonnementen & 1 gebruiker met alle betalingshosting door Zoho. De laatste 40 abonnementsstatistieken worden opgeslagen.
   - [Checkout](https://zoho.com/checkout) — Productfacturatiebeheer met 3 pagina's & tot 50 betalingen.
   - [Desk](https://zoho.com/desk) — Klantenondersteuningbeheer met drie agenten, privékennisbank en e-mailtickets. Integreert met [Assist](https://zoho.com/assist) voor één remote technicus & 5 onbeheerde computers.
   - [Cliq](https://zoho.com/cliq) — Teamchatsoftware met 100 GB opslag, onbeperkte gebruikers, 100 gebruikers per kanaal & SSO.
   - [Campaigns](https://zoho.com/campaigns) - E-mailmarketing
   - [Forms](https://zoho.com/forms) - Formulierbouwer
   - [Sign](https://zoho.com/sign) - Papierenloze handtekeningen
   - [Surveys](https://zoho.com/surveys) - Online enquêtes
   - [Bookings](https://zoho.com/bookings) - Afspraken plannen
* [Maileroo](https://maileroo.com) - SMTP relay en e-mail API voor ontwikkelaars. 5.000 e-mails per maand, onbeperkte domeinen, gratis e-mailverificatie, blacklist monitoring, mail tester en meer.

**[⬆️ Terug naar boven](#table-of-contents)**

## Feature Toggles Management Platforms

* [ConfigCat](https://configcat.com) - ConfigCat is een ontwikkelaarsgerichte feature flag service met onbeperkte teamgrootte, uitstekende ondersteuning en een redelijke prijs. Gratis plan tot 10 flags, twee omgevingen, 1 product en 5 miljoen verzoeken per maand.
* [Flagsmith](https://flagsmith.com) - Features met vertrouwen releasen; beheer feature flags over web-, mobiele en server-side applicaties. Gebruik onze gehoste API, implementeer in je eigen private cloud of draai on-premise.
* [GrowthBook](https://growthbook.io) - Open source feature flag en A/B test provider met ingebouwde Bayesiaanse statistische analyse-engine. Gratis tot 3 gebruikers, onbeperkte feature flags en experimenten.
* [Hypertune](https://www.hypertune.com) - Type-safe feature flags, A/B testing, analytics en app-configuratie, met Git-achtige versiebeheer en synchrone, in-memory, lokale flag-evaluatie. Gratis tot 5 teamleden met onbeperkte feature flags en A/B-tests.
* [Molasses](https://www.molasses.app) - Krachtige feature flags en A/B-testing. Gratis tot 3 omgevingen met vijf feature flags per omgeving.
* [Toggled.dev](https://www.toggled.dev) - Enterprise-ready, schaalbaar multiregionaal platform voor feature toggles management. Gratis plan tot 10 flags, twee omgevingen, onbeperkte verzoeken. SDK, analytics dashboard, releasekalender, Slack-notificaties en alle andere functies zijn inbegrepen in het eindeloos gratis plan.
* [Statsig](https://www.statsig.com) - Een robuust platform voor feature management, A/B-testing, analytics en meer. Het royale gratis plan biedt onbeperkte gebruikers, flags, experimenten en dynamische configuraties, tot 1 miljoen events per maand.
* [Abby](https://www.tryabby.com) - Open-Source feature flags & A/B-testing. Configuratie als Code & Volledig getypte Typescript SDK's. Sterke integratie met frameworks zoals Next.js & React. Royaal gratis aanbod en goedkope schaalopties.

**[⬆️ Terug naar boven](#table-of-contents)**

## Fonts

* [dafont](https://www.dafont.com/) - De lettertypen op deze website zijn eigendom van de auteurs en zijn freeware, shareware, demoversies of publiek domein.
* [Everything Fonts](https://everythingfonts.com/) - Biedt meerdere tools; @font-face, Units Converter, Font Hinter en Font Submitter.
* [Font Squirrel](https://www.fontsquirrel.com/) - Freeware-lettertypen gelicenseerd voor commercieel gebruik. Handgeselecteerde lettertypen, gepresenteerd in een gebruiksvriendelijk formaat.
* [Google Fonts](https://fonts.google.com/) - Veel gratis lettertypen zijn eenvoudig en snel op een website te installeren via een download of een link naar Google's CDN.
* [FontGet](https://www.fontget.com/) - Heeft een verscheidenheid aan lettertypen die je kunt downloaden en netjes gesorteerd op tags.
* [Fontshare](https://www.fontshare.com/) - is een gratis lettertypenservice. Het is een groeiende collectie professionele lettertypen, 100% gratis voor persoonlijk en commercieel gebruik.
* [Befonts](https://befonts.com/) - Biedt verschillende unieke lettertypen voor persoonlijk of commercieel gebruik.
* [Font of web](https://fontofweb.com/) - Identificeer alle lettertypen die op een website worden gebruikt en hoe ze worden gebruikt.
* [Bunny](https://fonts.bunny.net) Privacy-georiënteerde Google Fonts
* [FontsKey](https://www.fontskey.com/) - Biedt gratis en commerciële betaalde lettertypen voor persoonlijk gebruik en je kunt tekst invoeren voor snelle filtering.
* [fonts.xz.style](https://fonts.xz.style/) gratis en open source dienst voor het leveren van font families aan websites via CSS.
* [Fontsensei](https://fontsensei.com/) Opensource Google fonts getagd door gebruikers. Met CJK (Chinees, Japans, Koreaans) font tags.

**[⬆️ Terug naar boven](#table-of-contents)**

## Formulieren

* [Feathery](https://feathery.io) - Krachtige, ontwikkelaarsvriendelijke formulierbouwer. Bouw signup & login, gebruikersonboarding, betaalstromen, complexe financiële applicaties en meer. Het gratis plan staat tot 250 inzendingen/maand en vijf actieve formulieren toe.
* [Form-Data](https://form-data.com) - No-code forms backend. Spamfilter, e-mailnotificatie en auto-respond, webhooks, zapier, redirects, AJAX of POST, en meer. Het gratis plan biedt onbeperkte formulieren, 20 inzendingen/maand, en nog eens 2000 inzendingen met Form-Data badge.
* [FabForm](https://fabform.io/) - Formulier-backendplatform voor slimme ontwikkelaars. Het gratis plan staat 250 formulierinzendingen per maand toe. Gebruiksvriendelijke moderne GUI. Integreert met Google Sheets, Airtable, Slack, E-mail en anderen.
* [Form.taxi](https://form.taxi/) — Eindpunt voor HTML-formulierinzendingen. Met notificaties, spamblokkering en AVG-conforme gegevensverwerking. Gratis plan voor basisgebruik.
* [Formcarry.com](https://formcarry.com) - HTTP POST Form-eindpunt, gratis plan staat 100 maandelijkse inzendingen toe.
* [formingo.co](https://www.formingo.co/)- Eenvoudige HTML-formulieren voor statische websites. Je kunt gratis starten zonder accountregistratie. Het gratis plan biedt 500 maandelijkse inzendingen en een aanpasbaar reply-to e-mailadres.
* [FormKeep.com](https://www.formkeep.com/) - Onbeperkte formulieren met 50 maandelijkse inzendingen, spambeveiliging, e-mailnotificatie en een drag-and-drop designer die HTML kan exporteren. Extra functies zijn aangepaste veldregels, teams en integraties met Google Sheets, Slack, ActiveCampaign en Zapier.
* [formlets.com](https://formlets.com/) — Online formulieren, onbeperkte eenpagina-formulieren/maand, 100 inzendingen/maand, e-mailnotificaties.
* [formspark.io](https://formspark.io/) -  Formulier-naar-email service, gratis plan staat onbeperkte formulieren en 250 inzendingen per maand toe, ondersteuning door customer assistance team.
* [Formspree.io](https://formspree.io/) — Verstuur e-mail via een HTTP POST verzoek. De gratis laag is beperkt tot 50 inzendingen per formulier per maand.
* [Formsubmit.co](https://formsubmit.co/) — Eenvoudige formulier-eindpunten voor je HTML-formulieren. Voor altijd gratis. Geen registratie vereist.
* [Formlick.com](https://formlick.com) - Typeform alternatief met lifetime deal. Gebruikers kunnen 1 gratis formulier aanmaken en onbeperkt inzendingen ontvangen. In premium kun je onbeperkte formulieren en inzendingen aanmaken.
* [getform.io](https://getform.io/) - Formulier-backendplatform voor ontwerpers en ontwikkelaars, 1 formulier, 50 inzendingen, enkele bestandsupload, 100MB bestandsopslag.
* [HeroTofu.com](https://herotofu.com/) - Formulierenbackend met botdetectie en versleuteld archief. Stuur inzendingen via UI door naar e-mail, Slack of Zapier. Gebruik je eigen frontend. Geen servercode vereist. Het gratis plan geeft onbeperkte formulieren en 100 inzendingen per maand.
* [HeyForm.net](https://heyform.net/) - Drag-and-drop online formulierbouwer. De gratis laag laat je onbeperkt formulieren maken en onbeperkt inzendingen verzamelen. Wordt geleverd met voorgebouwde templates, anti-spam en 100MB bestandsopslag.
* [Tally.so](https://tally.so/) - 99% van alle functies is gratis. De gratis laag biedt: onbeperkte formulieren, onbeperkte inzendingen, e-mailnotificaties, formulierlogica, betalingen innen, bestandsupload, aangepaste bedankpagina, en veel meer.
* [Hyperforms.app](https://hyperforms.app/) — Maak in enkele seconden een formulier-naar-email en meer, zonder backend code. Het persoonlijke account geeft je tot 50 maandelijkse formulierinzendingen gratis.
* [Kwes.io](https://kwes.io/) - Functierijke formulier-eindpunt. Werkt uitstekend met statische sites. Gratis plan bevat tot 1 website met maximaal 50 maandelijkse inzendingen.
* [Pageclip](https://pageclip.co/) - Het gratis plan staat één site, één formulier en 1.000 maandelijkse inzendingen toe.
* [Qualtrics Survey](https://qualtrics.com/free-account) — Maak professionele formulieren & enquêtes met deze eersteklas tool. 50+ door experts ontworpen enquête-templates. Gratis account heeft een limiet van 1 actieve enquête, 100 antwoorden/enquête & 8 antwoordtypes.
* [Screeb](https://screeb.app/) - In-app enquêtes en productanalyse om gebruikersgedrag te doorgronden. Altijd gratis plan biedt 500 maandelijkse actieve gebruikers, onbeperkte antwoorden en events, veel integraties, export en periodieke rapporten.
* [smartforms.dev](https://smartforms.dev/) - Krachtige en eenvoudige formulier-backend voor je website, voor altijd gratis plan staat 50 inzendingen per maand toe, 250MB bestandsopslag, Zapier-integratie, CSV/JSON-export, aangepaste redirect, aangepaste responsepagina, Telegram & Slack bot, enkele e-mailnotificaties.
* [Survicate](https://survicate.com/) — Haal feedback op uit alle bronnen en verstuur follow-up enquêtes met één tool. Analyseer feedback automatisch en haal inzichten uit AI. Gratis e-mail-, website-, in-product- of mobiele enquêtes, AI-enquêtebouwer, en 25 maandelijkse antwoorden.
* [staticforms.xyz](https://www.staticforms.xyz/) - Integreer HTML-formulieren eenvoudig zonder server-side code, gratis. Na het inzenden van het formulier wordt een e-mail met de inhoud naar je geregistreerde adres gestuurd.
* [stepFORM.io](https://stepform.io) - Quiz- en formulierbouwer. Het gratis plan heeft vijf formulieren, tot 3 stappen per formulier en 50 maandelijkse antwoorden.
* [Typeform.com](https://www.typeform.com/) — Voeg prachtig ontworpen formulieren toe aan websites. Het gratis plan staat slechts tien velden per formulier en 100 maandelijkse antwoorden toe.
* [WaiverStevie.com](https://waiverstevie.com) - Elektronisch handtekeningenplatform met een REST API. Je kunt notificaties ontvangen via webhooks. Gratis plan voorziet ondertekende documenten van een watermerk, maar staat onbeperkte enveloppen + handtekeningen toe.
* [Web3Forms](https://web3forms.com) - Contactformulieren voor Statische & JAMStack-websites zonder backend-code te schrijven. Het gratis plan staat onbeperkte formulieren, onbeperkte domeinen & 250 inzendingen per maand toe.
* [WebAsk](https://webask.io) - Enquête- en Formulierbouwer. Het gratis plan biedt drie enquêtes per account, 100 maandelijkse reacties en tien elementen per enquête.
* [Wufoo](https://www.wufoo.com/) - Snelle formulieren om op websites te gebruiken. Het gratis plan heeft een limiet van 100 inzendingen per maand.
* [formpost.app](https://formpost.app) - Gratis, onbeperkte Formulier-naar-E-mail dienst. Stel aangepaste redirects, auto-responses, webhooks, enz. gratis in.
* [Formester.com](https://formester.com) - Deel en embed unieke formulieren op je website—geen limieten op het aantal aangemaakte formulieren of geblokkeerde functies per plan. Ontvang tot 100 inzendingen per maand gratis.
* [SimplePDF.eu](https://simplepdf.eu/embed) - Embed een PDF-editor op je website en maak van elke PDF een invulbaar formulier. Het gratis plan staat onbeperkte PDF's toe met drie inzendingen per PDF.
* [forms.app](https://forms.app/) — Maak online formulieren met krachtige functies zoals conditionele logica, automatische scoreberekening en AI. Verzamel tot 100 reacties met een gratis plan, embed je formulieren op een website of gebruik ze via een link.
* [Qualli](https://usequalli.com) - In-App Enquêtes, ontworpen voor mobiel. Gebruik Qualli AI om de perfecte vragen te maken. Je kunt het uitproberen op ons gratis plan, tot 500 MAU, maak onbeperkte formulieren en triggers.
* [Sprig](https://sprig.com/) - 1 In-Product Survey of Survey met Replay per maand, met GPT-gestuurde AI-analyse.
* [feedback.fish](https://feedback.fish/) - Het gratis plan staat toe om in totaal 25 feedbackinzendingen te verzamelen. Eenvoudig te integreren met React- en Vue-componenten die worden meegeleverd.
* [Vidhook](https://vidhook.io/) - Verzamel feedback met behulp van aantrekkelijke enquêtes met hoge responspercentages. Gratis plan bevat 1 actieve enquête, 25 reacties per enquête en aanpasbare sjablonen.

**[⬆️ Terug naar boven](#table-of-contents)**

## Generatieve AI

* [Zenable](https://zenable.io) - Herstel automatisch direct de output van tools zoals Cursor, Windsurf en Copilot om te voldoen aan de kwaliteits- en nalevingsnormen van je bedrijf met guardrails gebouwd met Policy as Code. Het gratis niveau omvat 100 tool-aanroepen per dag naar de MCP-server en 25 gratis geautomatiseerde pull request-beoordelingen per dag via de GitHub App.
* [Keywords AI](https://keywordsai.co) - Het beste LLM-monitoringplatform. Eén formaat om 200+ LLM’s aan te roepen met 2 regels code. 10.000 gratis verzoeken elke maand en $0 voor platformfuncties!
* [Portkey](https://portkey.ai/) - Controlepaneel voor Gen AI-apps met een observability suite en een AI-gateway. Verstuur en log tot 10.000 verzoeken gratis elke maand.
* [Braintrust](https://www.braintrustdata.com/) - Evaluaties, prompt playground en datamanagement voor Gen AI. Gratis plan geeft tot 1.000 privé-evaluatierijen per week.
* [Findr](https://www.usefindr.com/) - Universele zoekfunctie waarmee je al je apps tegelijk doorzoekt. Zoekassistent waarmee je vragen kunt beantwoorden met je eigen informatie. Gratis plan biedt onbeperkte uniforme zoekopdrachten en 5 co-pilot queries per dag.
* [ReportGPT](https://ReportGPT.app) - AI-aangedreven schrijf-assistent. Het volledige platform is gratis zolang je je eigen API-sleutel gebruikt.
* [Clair](https://askclair.ai/) - Klinische AI-referentie. Studenten hebben gratis toegang tot de professionele toolset, waaronder Open Search, Clinical Summary, Med Review, Drug Interactions, ICD-10 Codes en Stewardship. Daarnaast is er een gratis proefperiode voor de professionele suite.
* [Langtrace](https://langtrace.ai) - stelt ontwikkelaars in staat prompts en datasets te traceren, evalueren, beheren en problemen te debuggen met betrekking tot de prestaties van een LLM-applicatie. Het genereert open telemetry-standaardtraces voor elke LLM, wat helpt bij observability en werkt met elke observability-client. Gratis plan biedt 50K traces/maand.
* [LangWatch](https://langwatch.ai) - Een LLMOps-platform dat AI-teams helpt LLM-applicaties te meten, monitoren en optimaliseren op betrouwbaarheid, kostenefficiëntie en prestaties. Met een krachtige DSPy-component, waarmee samenwerking tussen engineers en niet-technische teams mogelijk wordt gemaakt voor het finetunen en in productie nemen van GenAI-producten. Gratis plan bevat alle platformfuncties, 1k traces/maand en 1 workflow DSPy optimizers. [#opensource](https://github.com/langwatch/langwatch)
* [Comet Opik](https://www.comet.com/site/products/opik/) - Evalueer, test en deploy LLM-applicaties in je ontwikkel- en productielifecycle. [#opensource](https://github.com/comet-ml/opik/)
* [Langfuse](https://langfuse.com/) - Open-source LLM-engineeringplatform dat teams helpt samen LLM-applicaties te debuggen, analyseren en itereren. Gratis voor altijd-plan bevat 50k observaties per maand en alle platformfuncties. [#opensource](https://github.com/langfuse/langfuse)
* [Pollinations.AI](https://pollinations.ai/) - gebruiksvriendelijke, gratis AI voor beeldgeneratie met gratis API beschikbaar. Geen registratie of API-sleutels vereist, en verschillende opties voor integratie in een website of workflow. [#opensource](https://github.com/pollinations/pollinations)
* [Othor AI](https://othor.ai/) - Een AI-native, snelle, eenvoudige en veilige vervanger voor populaire business intelligence oplossingen zoals Tableau, Power BI en Looker. Othor gebruikt grote taalmodellen (LLM's) om in enkele minuten op maat gemaakte BI-oplossingen te leveren. Het Free Forever-plan biedt één werkruimte met vijf databronverbindingen voor één gebruiker, zonder limiet op analyses. [#opensource](https://github.com/othorai/othor.ai)
* [OpenRouter](https://openrouter.ai/models?q=free) - Biedt verschillende gratis AI-modellen, waaronder DeepSeek R1, V3, Llama en Moonshot AI. Deze modellen blinken uit in natuurlijke taalverwerking en zijn geschikt voor diverse ontwikkelbehoeften. Let op: deze modellen zijn gratis te gebruiken, maar onderhevig aan rate limits. Daarnaast biedt OpenRouter betaalde modellen voor meer geavanceerde behoeften, zoals Claude, OpenAI, Grok, Gemini en Nova.

**[⬆️ Terug naar boven](#table-of-contents)**

## CDN en Bescherming

* [bootstrapcdn.com](https://www.bootstrapcdn.com/) — CDN voor bootstrap, bootswatch en fontawesome.io
* [cdnjs.com](https://cdnjs.com/) — Simpel. Snel. Betrouwbaar. Content delivery op zijn best. cdnjs is een gratis en open-source CDN-service, vertrouwd door meer dan 11% van alle websites, aangedreven door Cloudflare.
* [developers.google.com](https://developers.google.com/speed/libraries/) — De Google Hosted Libraries is een contentdistributienetwerk voor de populairste open source JavaScript-bibliotheken
* [Stellate](https://stellate.co/) - Stellate is een razendsnelle, betrouwbare CDN voor je GraphQL API en gratis voor twee services.
* [jsdelivr.com](https://www.jsdelivr.com/) — Een gratis, snelle en betrouwbare open-source CDN. Ondersteunt npm, GitHub, WordPress, Deno en meer.
* [Microsoft Ajax](https://docs.microsoft.com/en-us/aspnet/ajax/cdn/overview) — De Microsoft Ajax CDN host populaire externe JavaScript-bibliotheken zoals jQuery en maakt het eenvoudig om ze toe te voegen aan je webapplicatie
* [ovh.ie](https://www.ovh.ie/ssl-gateway/) — Gratis DDoS-bescherming en SSL-certificaat
* [Skypack](https://www.skypack.dev/) — De 100% Native ES Module JavaScript CDN. Gratis voor 1 miljoen verzoeken per domein per maand.
* [raw.githack.com](https://raw.githack.com/) — Een moderne vervanger van **rawgit.com** die bestanden host via Cloudflare
* [section.io](https://www.section.io/) — Een eenvoudige manier om een volledige Varnish Cache-oplossing te starten en te beheren. Blijvend gratis voor één site.
* [statically.io](https://statically.io/) — CDN voor Git-repo's (GitHub, GitLab, Bitbucket), WordPress-gerelateerde assets en afbeeldingen
* [toranproxy.com](https://toranproxy.com/) — Proxy voor Packagist en GitHub. Nooit falende CD. Gratis voor persoonlijk gebruik, één ontwikkelaar, geen support
* [UNPKG](https://unpkg.com/) — CDN voor alles op npm
* [weserv](https://images.weserv.nl/) — Een image cache & resize service. Bewerk afbeeldingen on-the-fly met een wereldwijde cache.
* [Namecheap Supersonic](https://www.namecheap.com/supersonic-cdn/#free-plan) — Gratis DDoS-bescherming
* [Gcore](https://gcorelabs.com/) Wereldwijd content delivery netwerk, 1 TB en 1 miljoen verzoeken per maand gratis en gratis DNS-hosting
* [CacheFly](https://portal.cachefly.com/signup/free2023) - Tot 5 TB per maand gratis CDN-verkeer, 19 Core PoPs, 1 domein en Universele SSL.

**[⬆️ Terug naar boven](#table-of-contents)**

## PaaS

* [anvil.works](https://anvil.works) - Webapp-ontwikkeling met alleen Python. Gratis niveau met onbeperkte apps en 30-seconden timeouts.
* [appwrite](https://appwrite.io) - Onbeperkte projecten zonder projectpauzering (ondersteunt websockets) en authenticatiedienst. 1 Database, 3 Buckets, 5 Functies per project in het gratis niveau.
* [configure.it](https://www.configure.it/) — Platform voor mobiele app-ontwikkeling, gratis voor twee projecten, beperkte functies maar geen resource-limieten
* [codenameone.com](https://www.codenameone.com/) — Open source, cross-platform, mobiele app-ontwikkelingstoolchain voor Java/Kotlin-ontwikkelaars. Gratis voor commercieel gebruik met een onbeperkt aantal projecten
* [deco.cx](https://www.deco.cx/en/dev) - Edge-native frontendplatform met een visueel CMS automatisch gegenereerd uit TypeScript-code. Ingebouwde A/B-tests, contentsegmentatie en realtime analytics. Perfect voor contentrijke en Enterprise e-commerce websites. Gratis tot 5k pageviews/maand of open-source/persoonlijke projecten.
* [Deno Deploy](https://deno.com/deploy) - Gedistribueerd systeem dat JavaScript, TypeScript en WebAssembly wereldwijd aan de edge uitvoert. Het gratis niveau omvat 100.000 verzoeken per dag en 100 GiB dataverkeer per maand.
* [domcloud.co](https://domcloud.co) – Linux-hostingdienst die CI/CD biedt met GitHub, SSH en MariaDB/Postgres-database. De gratis versie heeft 1 GB opslag en 1 GB netwerk/maand limiet en is beperkt tot een gratis domein.
* [encore.dev](https://encore.dev/) — Backend-framework dat gebruikmaakt van statische analyse om automatische infrastructuur, boilerplate-vrije code en meer te bieden. Inclusief gratis cloudhosting voor hobbyprojecten.
* [flightcontrol.dev](https://flightcontrol.dev/) - Deploy webservices, databases en meer op je eigen AWS-account met een Git push-achtige workflow. Gratis niveau voor gebruikers met 1 ontwikkelaar op persoonlijke GitHub-repo's. AWS-kosten worden gefactureerd via AWS, maar je kunt credits en het AWS free tier gebruiken.
* [gigalixir.com](https://gigalixir.com/) - Gigalixir biedt één gratis instantie die nooit slaapt en een gratis PostgreSQL-database in de gratis laag, beperkt tot 2 connecties, 10.000 rijen en geen back-ups voor Elixir/Phoenix-apps.
* [Glitch](https://glitch.com/) — Gratis publieke hosting met code sharing en realtime samenwerking. Het gratis plan heeft een limiet van 1000-uren/maand.
* [leapcell](https://leapcell.io/) - Leapcell is een betrouwbaar platform voor gedistribueerde applicaties, dat alles biedt wat je nodig hebt om je snelle groei soepel te ondersteunen. Het gratis plan omvat 100k service-aanroepen, 10k asynchrone taken en 100k Redis-commando's.
* [pipedream.com](https://pipedream.com) - Een integratieplatform gebouwd voor ontwikkelaars. Ontwikkel elke workflow gebaseerd op elke trigger. Workflows zijn code die je [gratis kunt uitvoeren](https://docs.pipedream.com/pricing/). Geen server- of cloudresources om te beheren.
* [pythonanywhere.com](https://www.pythonanywhere.com/) — Cloud Python app-hosting. Beginnersaccount is gratis, 1 Python-webapplicatie op je-gebruikersnaam.pythonanywhere.com domein, 512 MB privébestandsopslag, één MySQL-database
* [ampt.dev](https://getampt.com/) - Ampt laat teams JavaScript-apps bouwen, deployen en schalen op AWS zonder ingewikkelde configuraties of infrastructuurbeheer. Gratis Preview-plan omvat 500 aanroepen per uur, 2.500 aanroepen dagelijks en 50.000 aanroepen maandelijks. Aangepaste domeinen zijn alleen toegestaan in de betaalde plannen.
* [Koyeb](https://www.koyeb.com) - Koyeb is een ontwikkelaarsvriendelijk serverloos platform om apps wereldwijd te deployen. Voer naadloos Docker-containers, webapps en API's uit met git-gebaseerde deployment, native autoscaling, een wereldwijd edge-netwerk en ingebouwde service mesh en discovery. Gratis instantie laat je een webservice deployen in Frankfurt, Duitsland of Washington, D.C., VS. Gratis beheerde Postgres-database beschikbaar in Frankfurt (Duitsland), Washington, D.C. (VS) en Singapore. 512MB geheugen, 2GB opslag en 0.1 CPU.
* [Napkin](https://www.napkin.io/) - FaaS met 500Mb geheugen, standaard timeout van 15 seconden en 5.000 gratis API-calls/maand, gelimiteerd tot 5 calls/seconde.
* [Meteor Cloud](https://www.meteor.com/cloud) — Galaxy-hosting. Meteor's platform-as-a-service voor Meteor-apps omvat gratis MongoDB Gedeelde Hosting en automatische SSL.
* [Northflank](https://northflank.com) — Bouw en deploy microservices, jobs en beheerde databases met een krachtige UI, API & CLI. Schaal naadloos containers vanuit versiebeheer en externe Docker-registries. Het gratis niveau omvat twee services, twee cronjobs en 1 database.
* [YepCode](https://yepcode.io) - Alles-in-één platform om API's en diensten te koppelen in een serverloze omgeving. Het biedt alle flexibiliteit en voordelen van NoCode-tools, maar met alle kracht van programmeertalen. Het gratis niveau omvat [1.000 yeps](https://yepcode.io/pricing/).
* [WunderGraph](https://cloud.wundergraph.com) - Een open-source platform waarmee je snel moderne API's kunt bouwen, uitrollen en beheren. Ingebouwde CI/CD, GitHub-integratie en automatische HTTPS. Tot 3 projecten, 1GB uitgaand verkeer, 300 minuten buildtijd per maand op het [gratis plan](https://wundergraph.com/pricing)
* [Zeabur](https://zeabur.com) - Deploy je services met één klik. Gratis voor drie services, met US$ 5 gratis tegoed per maand.
* [mogenius](https://mogenius.com) - Bouw, deploy en run eenvoudig services op Kubernetes. Het gratis niveau ondersteunt het koppelen van een lokale Kubernetes met mogenius, waardoor individuele ontwikkelaars een productie-achtig testomgeving op hun machine kunnen creëren.
* [genezio](https://genezio.com/) - Een serverless function provider biedt 1 miljoen functieaanroepen, 100GB bandbreedte en 10 cronjobs per maand gratis, uitsluitend voor niet-commercieel of academisch gebruik.

**[⬆️ Terug naar boven](#table-of-contents)**

## BaaS

* [Activepieces](https://www.activepieces.com) - Bouw automatiseringsflows om verschillende apps met elkaar te verbinden in de backend van je app. Bijvoorbeeld, stuur een Slack-bericht of voeg een Google Sheet-rij toe wanneer er een gebeurtenis in je app wordt geactiveerd. Gratis tot 5.000 taken per maand.
* [back4app.com](https://www.back4app.com) - Back4App is een gebruiksvriendelijke, flexibele en schaalbare backend op basis van het Parse Platform.
* [backendless.com](https://backendless.com/) — Mobiele en Web-Baas, met 1 GB gratis bestandsopslag, 50.000 pushmeldingen per maand en 1.000 dataobjecten in de tabel.
* [bismuth.cloud](https://www.bismuth.cloud/) — Onze AI bootstrapt je Python API op onze function runtime en gehoste opslag, bouw en host gratis in onze online editor of lokaal met je favoriete tools.
* [BMC Developer Program](https://developers.bmc.com/site/global/bmc_helix_platform/program/overview/index.gsp) — Het BMC Developer Program biedt documentatie en bronnen om digitale innovaties voor je onderneming te bouwen en te deployen. Toegang tot een uitgebreide, persoonlijke sandbox met het platform, SDK en een bibliotheek met componenten om apps te bouwen en aan te passen.
* [connectycube.com](https://connectycube.com) - Onbeperkt chatberichten, p2p spraak- en videogesprekken, bestandsbijlagen en pushmeldingen. Gratis voor apps tot 1000 gebruikers.
* [convex.dev](https://convex.dev/) - Reactieve backend-as-a-service, host je data (documenten met relaties & seriële ACID-transacties), serverless functies en WebSockets om updates te streamen naar diverse clients. Gratis voor kleine projecten - tot 1M records, 5M maandelijkse functie-aanroepen.
* [darklang.com](https://darklang.com/) - Gehoste taal gecombineerd met editor en infrastructuur. Toegankelijk tijdens de bèta, een royaal gratis niveau is gepland na bèta.
* [Firebase](https://firebase.com) — Firebase helpt je bij het bouwen en runnen van succesvolle apps. Gratis Spark Plan biedt Authenticatie, Hosting, Firebase ML, Realtime Database, Cloud Storage, Testlab. A/B Testing, Analytics, App Distribution, App Indexing, Cloud Messaging (FCM), Crashlytics, Dynamic Links, In-App Messaging, Performance Monitoring, Predictions en Remote Config zijn altijd gratis.
* [Flutter Flow](https://flutterflow.io) — Bouw je Flutter App UI zonder een regel code te schrijven. Heeft ook een Firebase-integratie. Het gratis plan omvat volledige toegang tot de UI Builder en gratis sjablonen.
* [getstream.io](https://getstream.io/) — Bouw schaalbare In-App Chat, Messaging, Video en audio, en Feeds in een paar uur in plaats van weken
* [hasura.io](https://hasura.io/) — Hasura breidt je bestaande databases uit, waar ze ook gehost worden, en biedt een directe GraphQL API die veilig kan worden benaderd voor web-, mobiele en data-integratieworkloads. Gratis voor 1GB/maand datadoorvoer.
* [nhost.io](https://nhost.io) - Serverloze backend voor web- en mobiele apps. Het gratis plan omvat PostgreSQL, GraphQL (Hasura), Authenticatie, Opslag en Serverloze Functies.
* [onesignal.com](https://onesignal.com/) — Onbeperkt gratis pushmeldingen. 10.000 e-mailverzendingen per maand, met onbeperkte contacten en toegang tot Auto Warm Up.
* [paraio.com](https://paraio.com) — Backend-service API met flexibele authenticatie, full-text search en caching. Gratis voor één app, 1GB aan appdata.
  * [pubnub.com](https://www.pubnub.com/) — Gratis pushmeldingen voor maximaal 1 miljoen berichten/maand en 100 actieve dagelijkse apparaten
  * [pushbots.com](https://pushbots.com/) — Pushmeldingsservice. Gratis voor maximaal 1,5 miljoen pushes/maand
  * [pushcrew.com](https://pushcrew.com/) — Pushmeldingsservice. Onbeperkte meldingen voor maximaal 2.000 abonnees
  * [pusher.com](https://pusher.com/beams) — Gratis, onbeperkte pushmeldingen voor 2000 maandelijkse actieve gebruikers. Eén enkele API voor iOS- en Android-apparaten.
  * [quickblox.com](https://quickblox.com/) — Een communicatie-backend voor instant messaging, video- en spraakoproepen, en pushmeldingen
  * [restspace.io](https://restspace.io/) - Configureer een server met services voor authenticatie, data, bestanden, e-mail-API, sjablonen en meer, en stel deze samen in pipelines en transformeer data.
  * [Salesforce Developer Program](https://developer.salesforce.com/signup) — Bouw apps razendsnel met drag-and-drop tools. Pas je datamodel aan met klikken. Ga verder met Apex-code. Integreer met alles via krachtige API's. Blijf beschermd met beveiliging op ondernemingsniveau. Pas de UI aan met klikken of elk modern webframework. Het gratis Developer Program geeft toegang tot het volledige Lightning Platform.
  * [simperium.com](https://simperium.com/) — Verplaats data overal direct en automatisch, multi-platform, onbeperkt verzenden en opslaan van gestructureerde data, max. 2.500 gebruikers/maand
  * [Supabase](https://supabase.com) — Het open source Firebase-alternatief voor het bouwen van backends. Het gratis plan biedt Authenticatie, Realtime Database & Object Storage.
  * [tyk.io](https://tyk.io/) — API-beheer met authenticatie, quota’s, monitoring en analytics. Gratis cloud-aanbod
  * [zapier.com](https://zapier.com/) — Verbind de apps die je gebruikt om taken te automatiseren. Vijf zaps elke 15 minuten en 100 taken/maand
  * [IFTTT](https://ifttt.com) — Automatiseer je favoriete apps en apparaten. Gratis 2 Applets
  * [Integrately](https://integrately.com) — Automatiseer saaie taken met één klik. Gratis 100 taken, 15 minuten
Update-tijd, vijf actieve automatiseringen, webhooks.
  * [LeanCloud](https://leancloud.app/) — Mobiele backend. 1GB dataruimte, 256MB instance, 3K API-verzoeken/dag, en 10K pushes/dag gratis. (API is erg vergelijkbaar met Parse Platform)
  * [Claw.cloud](https://run.claw.cloud) - Een PaaS-platform met $5/maand gratis tegoed voor gebruikers met een GitHub-account ouder dan 180 dagen. Perfect voor het hosten van apps, databases en meer. ([Registratielink met gratis tegoed](https://ap-southeast-1.run.claw.cloud/signin)).


**[⬆️ Terug naar boven](#table-of-contents)**

## Low-code Platform

  * [appsmith](https://www.appsmith.com/) — Low-code project om adminpanelen, interne tools en dashboards te bouwen. Integreert met 15+ databases en elke API.
  * [Basedash](https://www.basedash.com) — Low-code platform voor het bouwen van interne adminpanelen en dashboards. Ondersteunt SQL-databases en REST API's.
  * [BudiBase](https://budibase.com/) — Budibase is een open-source low-code platform voor het creëren van interne apps in minuten. Ondersteunt PostgreSQL, MySQL, MSSQL, MongoDB, Rest API, Docker, K8s
  * [Clappia](https://www.clappia.com) — Een low-code platform ontworpen voor het bouwen van bedrijfsprocesapplicaties met aanpasbare mobiele en webapps. Biedt een drag-and-drop-interface, functies zoals offline ondersteuning, realtime locatiebepaling en integratie met verschillende externe services
  * [DronaHQ](https://www.dronahq.com/) — DronaHQ - een low-code platform dat engineeringteams en productmanagers helpt bij het bouwen van interne tools, aangepaste gebruikersreizen, digitale ervaringen, automatisering, aangepaste adminpanelen, operationele apps 10X sneller.
  * [lil'bots](https://www.lilbots.io/) - schrijf en voer scripts online uit met gratis ingebouwde API's zoals OpenAI, Anthropic, Firecrawl en anderen. Geweldig voor het bouwen van AI-agenten / interne tooling en delen met het team. Gratis-laag bevat volledige toegang tot API's, AI-coding assistant en 10.000 execution credits / maand.
  * [Mendix](https://www.mendix.com/) — Rapid Application Development voor ondernemingen, onbeperkte toegankelijke sandbox-omgevingen met ondersteuning voor totaal aantal gebruikers, 0,5 GB opslag en 1 GB RAM per app. Ook Studio en Studio Pro IDE's zijn toegestaan in de gratis laag.
  * [outsystems.com](https://www.outsystems.com/) — Enterprise webontwikkel-PaaS voor on-premise of cloud, gratis "persoonlijke omgeving" biedt onbeperkte code en tot 1 GB database
  * [ReTool](https://retool.com/) — Low-code platform voor het bouwen van interne applicaties. Retool is zeer aanpasbaar. Als je het kunt schrijven met JavaScript en een API, kun je het maken in Retool. De gratis laag staat tot vijf gebruikers per maand toe, onbeperkte apps en API-verbindingen.
  * [Superblocks](https://superblocks.com/) — Open enterprise applicatieplatform ontworpen voor ontwikkelaars en semi-technische teams. Gebruik AI om te genereren, visueel te bewerken en uit te breiden met code. Centraal beheren met integraties, authenticatie, permissies & auditlogs.
  * [ToolJet](https://www.tooljet.com/) — Uitbreidbaar low-code framework voor het bouwen van bedrijfsapplicaties. Verbind met databases, cloudopslag, GraphQL, API-eindpunten, Airtable, enz., en bouw apps met de drag-and-drop applicatiebouwer.
  * [UI Bakery](https://uibakery.io) — Low-code platform waarmee je sneller aangepaste webapplicaties bouwt. Bouw de UI via drag-and-drop met uitgebreide aanpassing via JavaScript, Python en SQL. Beschikbaar als cloud- en zelfgehoste oplossing. Gratis voor maximaal 5 gebruikers.
  * [manubes](https://www.manubes.com) - Krachtig no-code cloudplatform met focus op industrieel productiemanagement. Gratis voor één gebruiker met 1 miljoen workflowactiviteiten per maand ([ook beschikbaar in het Duits](https://www.manubes.de)).

**[⬆️ Terug naar boven](#table-of-contents)**

## Webhosting

  * [Alwaysdata](https://www.alwaysdata.com/) — 100 MB gratis webhosting met ondersteuning voor MySQL, PostgreSQL, CouchDB, MongoDB, PHP, Python, Ruby, Node.js, Elixir, Java, Deno, aangepaste webservers, toegang via FTP, WebDAV en SSH; mailbox, mailinglijst en app-installer inbegrepen.
  * [Awardspace.com](https://www.awardspace.com) — Gratis webhosting + een gratis korte domeinnaam, PHP, MySQL, App Installer, E-mailverzending & Geen advertenties.
  * [Bohr](https://bohr.io) — Gratis voor niet-commerciële projecten + Developer-First Deployment- en ontwikkelplatform dat infrastructuurhassle minimaliseert en de setup versnelt.
  * [Bubble](https://bubble.io/) — Visueel programmeren om web- en mobiele apps te bouwen zonder code, gratis met Bubble-branding.
  * [dAppling Network](https://www.dappling.network/) - Gedecentraliseerd webhostingplatform voor Web3-frontends met focus op verhoogde uptime en beveiliging en het bieden van een extra toegangspunt voor gebruikers.
  * [DigitalOcean](https://www.digitalocean.com/pricing) - Bouw en implementeer drie statische sites gratis op het App Platform Starter-tier.
  * [Drive To Web](https://drv.tw) — Host direct op het web vanuit Google Drive & OneDrive. Alleen statische sites. Altijd gratis. Eén site per Google/Microsoft-account.
  * [Fenix Web Server](https://preview.fenixwebserver.com) - Een desktop-app voor ontwikkelaars om sites lokaal te hosten en publiekelijk te delen (in realtime). Werk hoe je wilt, via de mooie gebruikersinterface, API en/of CLI.
  * [Fern](https://buildwithfern.com) - Bouw en host een Markdown-gebaseerde documentatiesite op Fern's gratis plan. Je kunt zelfs automatisch een API-referentie genereren voor je site uit API-definitiebestanden. De site wordt gehost op _jouwsite_.docs.buildwithfern.com.
  * [Free Hosting](https://freehostingnoads.net/) — Gratis hosting met PHP 5, Perl, CGI, MySQL, FTP, Bestandsbeheer, POP E-Mail, gratis subdomeinen, gratis domeinhosting, DNS Zone Editor, Website Statistieken, GRATIS Online Support en veel meer functies die andere gratis hosts niet bieden.
  * [Freehostia](https://www.freehostia.com) — FreeHostia biedt gratis hostingdiensten incl. een van de beste Control Panels & 1-klik installatie van 50+ gratis apps. Directe setup. Geen verplichte advertenties.
  * [HelioHost](https://heliohost.org) — Non-profit gratis webhosting met Plesk-controlepaneel, PHP, Node.js, Python, Django, Flask, .NET, Perl, CGI, MySQL, PostgreSQL, SQLite, IMAP/POP3/SMTP e-mail, onbeperkte bandbreedte, gratis subdomeinen, 1000 MB opslag gratis met upgrade-optie.
  * [Kinsta Static Site Hosting](https://kinsta.com/static-site-hosting/) — Implementeer tot 100 statische sites gratis, aangepaste domeinen met SSL, 100 GB maandelijkse bandbreedte, 260+ Cloudflare CDN-locaties.
  * [Lecturify](https://www.lecturify.net/index.en.html) - Webhosting met SFPT-toegang voor uploaden en downloaden van bestanden, php beschikbaar.
  * [Neocities](https://neocities.org) — Statische hosting, 1 GB gratis opslag met 200 GB bandbreedte.
  * [Netlify](https://www.netlify.com/) — Bouwt, implementeert en host statische site/app gratis voor 100 GB data en 100 GB/maand bandbreedte.
  * [pantheon.io](https://pantheon.io/) — Drupal- en WordPress-hosting, geautomatiseerde DevOps, en schaalbare infrastructuur. Gratis voor ontwikkelaars en bureaus. Geen aangepast domein.
  * [readthedocs.org](https://readthedocs.org/) — Gratis documentatiehosting met versiebeheer, PDF-generatie en meer
  * [render.com](https://render.com) — Geünificeerd cloudplatform om apps en sites te bouwen en draaien met gratis SSL, een wereldwijd CDN, privénetwerken, automatische deploys vanuit Git, en volledig gratis plannen voor webservices, databases en statische webpagina's.
  * [SourceForge](https://sourceforge.net/) — Vind, Maak en Publiceer Open Source-software gratis
  * [surge.sh](https://surge.sh/) — Statische webpublicatie voor Front-End-ontwikkelaars. Onbeperkt aantal sites met ondersteuning voor aangepaste domeinen
  * [telegra.ph](https://telegra.ph/) Maak eenvoudig een webpagina met Quill
  * [tilda.cc](https://tilda.cc/) — Eén site, 50 pagina's, 50 MB opslag, alleen de belangrijkste vooraf gedefinieerde blokken van 170+ beschikbaar, geen lettertypes, geen favicon en geen aangepast domein
  * [Vercel](https://vercel.com/) — Bouw, implementeer en host webapps met gratis SSL, wereldwijd CDN en unieke Preview-URL's elke keer dat je `git push` doet. Perfect voor Next.js en andere Static Site Generators.
  * [Versoly](https://versoly.com/) — SaaS-gerichte websitebouwer – onbeperkte websites, 70+ blokken, vijf templates, aangepaste CSS, favicon, SEO en formulieren. Geen aangepast domein.
  * [Qoddi](https://qoddi.com) - PaaS-dienst vergelijkbaar met Heroku met een ontwikkelaarsgerichte aanpak en all-in features. Gratis laag voor statische assets, staging en ontwikkelaarsapps.
  * [FreeFlarum](https://freeflarum.com/) - Community-gedreven gratis Flarum-hosting voor maximaal 250 gebruikers (doneer om de watermark uit de footer te verwijderen).
  * [MDB GO](https://mdbgo.com/) - Gratis hosting voor één project met twee weken Container TTL, 500 MB RAM per project, SFTP - 1G schijfruimte.
  * [Patr Cloud](https://patr.cloud/) — Een gebruiksvriendelijk cloudplatform, biedt naast betaalde diensten gratis hosting van drie statische sites.
  * [Serv00.com](https://serv00.com/) — 3 GB gratis webhosting met dagelijkse back-ups (7 dagen). Ondersteuning: Crontab-jobs, SSH-toegang, repositories (GIT, SVN en Mercurial), ondersteuning: MySQL, PostgreSQL, MongoDB, PHP, Node.js, Python, Ruby, Java, Perl, TCL/TK, Lua, Erlang, Rust, Pascal, C, C++, D, R en veel meer.
  - [Sevalla](https://sevalla.com/) - Hostingplatform ontworpen om het implementeren en beheren van applicaties, databases en statische websites te vereenvoudigen - 1GB site limiet, 100GB gratis bandbreedte, 600 gratis build-minuten, 100 sites per account.

**[⬆️ Terug naar boven](#table-of-contents)**

## DNS

  * [1.1.1.1](https://developers.cloudflare.com/1.1.1.1/) - Gratis publieke DNS-resolver, snel en veilig (versleutelt je DNS-query), aangeboden door Cloudflare. Handig om DNS-blokkering door je internetprovider te omzeilen, DNS-queryspionage te voorkomen en [volwassen- & malware-inhoud te blokkeren](https://developers.cloudflare.com/1.1.1.1/1.1.1.1-for-families). Kan ook [via API](https://developers.cloudflare.com/1.1.1.1/encrypted-dns/dns-over-https/make-api-requests) gebruikt worden. Let op: Alleen een DNS-resolver, geen DNS-hosting.
  * [1984.is](https://www.1984.is/product/freedns/) — Gratis DNS-service met API en veel andere gratis DNS-functies inbegrepen.
  * [cloudns.net](https://www.cloudns.net/) — Gratis DNS-hosting tot 1 domein met 50 records
  * [deSEC](https://desec.io) - Gratis DNS-hosting met API-ondersteuning, ontworpen met beveiliging in gedachten. Draait op open source software en wordt ondersteund door [SSE](https://www.securesystems.de/).
  * [dns.he.net](https://dns.he.net/) — Gratis DNS-hostingservice met Dynamic DNS-ondersteuning
  * [Zonomi](https://zonomi.com/) — Gratis DNS-hostingservice met directe DNS-propagatie. Gratis plan: 1 DNS-zone (domeinnaam) met maximaal 10 DNS-records.
  * [dnspod.com](https://www.dnspod.com/) — Gratis DNS-hosting.
  * [duckdns.org](https://www.duckdns.org/) — Gratis DDNS met tot 5 domeinen op de gratis laag. Met configuratiegidsen voor diverse setups.
  * [Dynv6.com](https://dynv6.com/) — Gratis DDNS-service met [API-ondersteuning](https://dynv6.com/docs/apis) en beheer van veel dns-recordtypes (zoals CNAME, MX, SPF, SRV, TXT en anderen).
  * [freedns.afraid.org](https://freedns.afraid.org/) — Gratis DNS-hosting. Biedt ook gratis subdomeinen op basis van talrijke publieke door gebruikers [bijgedragen domeinen](https://freedns.afraid.org/domain/registry/). Verkrijg gratis subdomeinen via het menu "Subdomains" na registratie.
  * [luadns.com](https://www.luadns.com/) — Gratis DNS-hosting, drie domeinen, alle functies met redelijke limieten
  * [namecheap.com](https://www.namecheap.com/domains/freedns/) — Gratis DNS. Geen limiet op het aantal domeinen
  * [nextdns.io](https://nextdns.io) - DNS-gebaseerde firewall, 300K gratis queries per maand
  * [noip.at](https://noip.at/) — Gratis DDNS-service zonder registratie, tracking, logging of advertenties. Geen limiet aan domeinen.
  * [noip](https://www.noip.com/) — een dynamische DNS-service die tot 3 hostnamen gratis toestaat met bevestiging elke 30 dagen
  * [sslip.io](https://sslip.io/) — Gratis DNS-service die, wanneer bevraagd met een hostnaam met een ingebouwd IP-adres, dat IP-adres retourneert.
  * [zilore.com](https://zilore.com/en/dns) — Gratis DNS-hosting voor 5 domeinen.
  * [zoneedit.com](https://www.zoneedit.com/free-dns/) — Gratis DNS-hosting met Dynamic DNS-ondersteuning.
  * [zonewatcher.com](https://zonewatcher.com) — Automatische back-ups en DNS-wijzigingsmonitoring. Eén domein gratis
  * [huaweicloud.com](https://www.huaweicloud.com/intl/en-us/product/dns.html) – Gratis DNS-hosting van Huawei
  * [Hetzner](https://www.hetzner.com/dns-console) – Gratis DNS-hosting van Hetzner met API-ondersteuning.
  * [Glauca](https://docs.glauca.digital/hexdns/) – Gratis DNS-hosting voor maximaal 3 domeinen en DNSSEC-ondersteuning
  * [VolaryDDNS](https://volaryddns.net) - Gratis, krachtige DDNS zonder abonnementen of advertenties
**[⬆️ Terug naar boven](#table-of-contents)**

## Domein

  * [pp.ua](https://nic.ua/) — Gratis pp.ua subdomeinen.
  * [us.kg](https://nic.us.kg/) - Gratis us.kg subdomeinen.

**[⬆️ Terug naar boven](#table-of-contents)**

## IaaS

  * [4EVERLAND](https://www.4everland.org/) — Compatibel met AWS S3 - APIs, interfacebewerkingen, CLI en andere uploadmethoden, uploaden en opslaan van bestanden van de IPFS- en Arweave-netwerken op een veilige, handige en efficiënte manier. Geregistreerde gebruikers kunnen 6 GB IPFS-opslag en 300 MB Arweave-opslag gratis krijgen. Arweave-bestandsuploads kleiner dan 150 KB zijn gratis.
  * [backblaze.com](https://www.backblaze.com/b2/) — Backblaze B2 cloudopslag. Gratis 10 GB (Amazon S3-achtige) objectopslag voor onbeperkte tijd.
  * [filebase.com](https://filebase.com/) - S3-compatibele objectopslag aangedreven door blockchain. 5 GB gratis opslag voor een onbeperkte duur.
  * [Tebi](https://tebi.io/) - S3-compatibele objectopslag. Gratis 25 GB opslag en 250 GB uitgaande overdracht.
  * [Idrive e2](https://www.idrive.com/e2/) - S3-compatibele objectopslag. 10 GB gratis opslag en 10 GB downloadbandbreedte per maand.
  * [C2 Object Storage](https://c2.synology.com/en-us/pricing/object-storage) - S3-compatibele objectopslag. 15 GB gratis opslag en 15 GB downloads per maand.

**[⬆️ Terug naar boven](#table-of-contents)**

## Managed Data Services

  * [Aiven](https://aiven.io/) - Aiven biedt gratis PostgreSQL-, MySQL- en Redis-plannen op zijn open-source dataplatform. Single node, 1 CPU, 1GB RAM, en voor PostgreSQL en MySQL, 5GB opslag. Eenvoudige migratie naar uitgebreidere plannen of tussen clouds.
  * [airtable.com](https://airtable.com/) — Ziet eruit als een spreadsheet, maar het is een relationele database. Onbeperkt aantal bases, 1.200 rijen/base, en 1.000 API-verzoeken/maand.
  * [Astra](https://www.datastax.com/products/datastax-astra/) — Cloud Native Cassandra as a Service met [80GB gratis tier](https://www.datastax.com/products/datastax-astra/pricing)
  * [codehooks.io](https://codehooks.io/) — Gebruiksvriendelijke JavaScript serverless API/backend en NoSQL-databaseservice met functies, Mongdb-achtige queries, key/value-zoekopdrachten, een jobsysteem, realtime berichten, worker queues, een krachtige CLI en een webgebaseerde datamanager. Gratis plan heeft 5GB opslag en 60 API-calls per minuut. 2 ontwikkelaars inbegrepen. Geen creditcard vereist.
  * [CrateDB](https://crate.io/) - Gedistribueerde Open Source SQL-database voor realtime analyses. [Gratis tier CRFREE](https://crate.io/lp-crfree): Eén node met 2 CPU's, 2 GiB geheugen, 8 GiB opslag. Eén cluster per organisatie, geen betaalmethode nodig.
  * [Upstash](https://upstash.com/) — Serverless Redis met gratis tier tot 10.000 verzoeken per dag, 256MB maximale databasegrootte, en 20 gelijktijdige verbindingen.
  * [Couchbase Capella](https://www.couchbase.com/products/capella/) - implementeer een altijd gratis tier volledig beheerde databasecluster, gebouwd voor ontwikkelaars om de volgende generatie applicaties te creëren van IoT tot AI.
  * [MongoDB Atlas](https://www.mongodb.com/cloud/atlas) — gratis tier biedt 512 MB.
  * [redsmin.com](https://www.redsmin.com/) — Online realtime monitoring- en beheerservice voor Redis, monitoring voor 1 Redis-instantie gratis.
  * [redislabs](https://redislabs.com/try-free/) - Gratis 30MB redis-instantie.
  * [MemCachier](https://www.memcachier.com/) — Beheerde Memcache-service. Gratis tot 25MB, 1 Proxy Server, en basisanalyses.
  * [scalingo.com](https://scalingo.com/) — Voornamelijk een PaaS, maar biedt een gratis tier van 128MB tot 192MB voor MySQL, PostgreSQL of MongoDB.
  * [SeaTable](https://seatable.io/) — Flexibele, spreadsheet-achtige database gebouwd door het Seafile-team. Onbeperkt aantal tabellen, 2.000 regels, 1 maand versiebeheer, tot 25 teamleden.
  * [skyvia.com](https://skyvia.com/) — Cloud Data Platform biedt een gratis tier en alle plannen zijn volledig gratis zolang ze in bèta zijn.
  * [StackBy](https://stackby.com/) — Eén tool die de flexibiliteit van spreadsheets, de kracht van databases en ingebouwde integraties met je favoriete zakelijke apps combineert. Het gratis plan bevat onbeperkte gebruikers, tien stacks en een bijlage van 2GB per stack.
  * [TiDB Cloud](https://en.pingcap.com/tidb-cloud/) — TiDB is een open-source MySQL-compatibele gedistribueerde HTAP RDBMS. TiDB Serverless biedt 5GB rijopslag, 5GB kolomopslag en 50 miljoen Request Units (RUs) gratis per maand.
  * [Turso by ChiselStrike](https://chiselstrike.com/) - Turso is SQLite Developer Experience in een Edge Database. Turso biedt een Free Forever starterplan, 9 GB totale opslag, tot 500 databases, tot 3 locaties, 1 miljard rijlezingen per maand, en lokale ontwikkelondersteuning met SQLite.
  * [InfluxDB](https://www.influxdata.com/) — Tijdreeksdatabase, gratis tot 3MB/5 minuten schrijven, 30MB/5 minuten lezen en 10.000 cardinaliteitseries.
  * [restdb.io](https://restdb.io/) - een snelle en eenvoudige NoSQL cloud database service. Met restdb.io krijg je schema, relaties, automatische REST API (met MongoDB-achtige queries), en een efficiënte multi-user admin UI voor het werken met data. Het gratis plan staat 3 gebruikers, 2500 records, en 1 API-verzoek per seconde toe.
  * [CockroachDB Cloud](https://www.cockroachlabs.com/pricing/) — Gratis tier biedt 50 miljoen RUs en 10 GiB opslag (gelijk aan $15 waarde) gratis per maand. ([Wat zijn Request Units](https://www.cockroachlabs.com/docs/cockroachcloud/metrics-request-units.html))
  * [Neo4j Aura](https://neo4j.com/cloud/aura/) — Beheerde native Graph DBMS / analytics platform met een Cypher-querytaal en een REST API. Limieten op grafiekgrootte (50k knooppunten, 175k relaties).
  * [Neon](https://neon.tech/) — Beheerde PostgreSQL, 0,5 GB opslag (totaal), 1 Project, 10 branches, onbeperkte databases, altijd beschikbare primaire branch (automatisch onderbroken na 5 minuten), 20 uur actieve tijd per maand (totaal) voor niet-primaire branch compute.
  * [Prisma Postgres](https://prisma.io/postgres) - Supersnelle gehoste Postgres gebouwd op unikernels en draaiend op bare metal, 1GB opslag, 10 databases, geïntegreerd met Prisma ORM.
  * [Dgraph Cloud](https://cloud.dgraph.io/pricing?type=free) — Beheerde native Graph DBMS met een GraphQL API. Beperkt tot 1 MB datatransfer per dag.
  * [Tinybird](https://tinybird.co) - Een serverloze beheerde ClickHouse met verbindingloze data ingest over HTTP en stelt je in staat SQL-queries te publiceren als beheerde HTTP API’s. Er is geen tijdslimiet op de gratis tier, 10GB opslag + 1000 API-verzoeken per dag.
  * [TigerGraph Cloud](https://www.tigergraph.com/cloud/) — Beheerde native Graph DBMS / analytics platform met een SQL-achtige graafquerytaal en een REST API. Eén gratis instantie met twee vCPU, 8GB geheugen, en 50GB opslag die slaapt na 1 uur inactiviteit.
  * [TerminusCMS](https://terminusdb.com/pricing) — Beheerde gratis dienst voor TerminusDB, een document- en graafdatabase geschreven in Prolog en Rust. Gratis voor ontwikkeling, betaalde dienst voor bedrijfsimplementaties en ondersteuning.
  * [filess.io](https://filess.io) - filess.io is een platform waar je gratis twee databases kunt creëren met maximaal 10 MB per database van de volgende DBMS: MySQL, MariaDB, MongoDB en PostgreSQL.
  * [xata.io](https://xata.io) - Xata is een serverloze database met ingebouwde krachtige zoek- en analysemogelijkheden. Eén API, meerdere type-safe clientbibliotheken en geoptimaliseerd voor je ontwikkelworkflow. De free-forever tier is voldoende voor hobbyontwikkelaars en komt met drie units van Xata, zie de website voor de definitie van een unit.
  * [8base.com](https://www.8base.com/) - 8base is een full-stack low-code ontwikkelplatform gebouwd voor JavaScript-ontwikkelaars, bovenop MySQL en GraphQL en serverless backend-as-a-service. Hiermee kun je snel webapplicaties bouwen met een UI-appbuilder en snel opschalen. Het gratis tier bevat rijen: 2.500, opslag: 500, serverless computing: 1Gb/u, en client app gebruikers: 5.
  * [Nile](https://www.thenile.dev/) — Een Postgres-platform voor B2B-apps. Onbeperkte databases, altijd beschikbaar zonder uitschakeling, 1GB opslag (totaal), 50 miljoen querytokens, autoscaling, onbeperkte vector-embeddings



**[⬆️ Terug naar boven](#table-of-contents)**

## Tunneling, WebRTC, Web Socket Servers en Andere Routers

  * [Pinggy](https://pinggy.io) — Publieke URL's voor localhost met één commando, geen downloads nodig. HTTPS / TCP / TLS tunnels. Het gratis plan heeft een tunnelduur van 60 minuten.
  * [conveyor.cloud](https://conveyor.cloud/) — Visual Studio-extensie om IIS Express bloot te stellen aan het lokale netwerk of over een tunnel naar een publieke URL.
  * [Hamachi](https://www.vpn.net/) — LogMeIn Hamachi is een gehoste VPN-dienst waarmee je veilig LAN-achtige netwerken kunt uitbreiden naar gedistribueerde teams met een gratis plan dat onbeperkte netwerken met maximaal 5 personen toestaat.
  * [Mirna Sockets](https://mirna.cloud/) - Gratis Socket as a Service Platform dat je een wss:// URL geeft bij het deployen van je Web Socket Server-code en je ook in staat stelt de prestaties ervan te monitoren.
  * [localhost.run](https://localhost.run/) — Lokaal draaiende servers blootstellen via een tunnel naar een publieke URL.
  * [localtunnel](https://theboroer.github.io/localtunnel-www/) — Lokaal draaiende servers blootstellen via een tunnel naar een publieke URL. Gratis gehoste versie, en [open source](https://github.com/localtunnel/localtunnel).
  * [ngrok.com](https://ngrok.com/) — Lokaal draaiende servers blootstellen via een tunnel naar een publieke URL.
  * [cname.dev](https://cname.dev/) — Gratis en veilige dynamische reverse proxy-dienst.
  * [serveo](https://serveo.net/) — Lokale servers blootstellen aan het internet. Geen installatie, geen registratie. Gratis subdomein, geen limieten.
  * [Radmin VPN](https://www.radmin-vpn.com/) — Verbind meerdere computers via een VPN, waardoor een LAN-achtig netwerk ontstaat. Onbeperkt aantal peers. (Alternatief voor Hamachi)
  * [segment.com](https://segment.com/) — Hub om gebeurtenissen te vertalen en routeren naar andere externe diensten. 100.000 gebeurtenissen/maand gratis.
  * Google STUN — [stun:stun.l.google.com:19302](stun:stun.l.google.com:19302)
  * Twilio STUN — [stun:global.stun.twilio.com:3478?transport=udp](stun:global.stun.twilio.com:3478?transport=udp)
  * [Tailscale](https://tailscale.com/) — Zero config VPN, gebruikmakend van het open-source WireGuard-protocol. Installeerbaar op MacOS, iOS, Windows, Linux en Android-apparaten. Gratis plan voor persoonlijk gebruik met 100 apparaten en drie gebruikers.
  * [webhookrelay.com](https://webhookrelay.com) — Beheer, debug, fan-out en proxy al je webhooks naar publieke of interne (d.w.z. localhost) bestemmingen. Ook servers die draaien in een privé-netwerk blootstellen via een tunnel door een publieke HTTP-endpoint te krijgen (`https://yoursubdomain.webrelay.io <----> http://localhost:8080`).
  * [Hookdeck](https://hookdeck.com/pricing) — Ontwikkel, test en monitor je webhooks overal vandaan. 100K verzoeken en 100K pogingen per maand met drie dagen retentie.
  * [Xirsys](https://www.xirsys.com/pricing/) — Onbeperkt STUN-gebruik + 500 MB maandelijkse TURN-bandbreedte, beperkte bandbreedte, enkele geografische regio.
  * [ZeroTier](https://www.zerotier.com) — FOSS beheerd virtueel Ethernet als een dienst. Onbeperkt aantal end-to-end versleutelde netwerken van 25 clients op het gratis plan. Clients voor desktop/mobiel/NA; webinterface voor configuratie van aangepaste routeringsregels en goedkeuring van nieuwe client nodes op privé-netwerken.
  * [LocalXpose](https://localxpose.io) — Reverse proxy waarmee je je localhost-servers kunt blootstellen aan het internet. Het gratis plan heeft een tunnelduur van 15 minuten.
  * [Traefik-Hub](https://traefik.io/traefik-hub/) - Publiceer lokaal draaiende services over een tunnel naar een publieke aangepaste URL en beveilig deze met toegangscontrole. Gratis voor 5 services in één cluster.
  * [Expose](https://expose.dev/) - Lokale sites blootstellen via beveiligde tunnels. Het gratis plan bevat een EU-server, willekeurige subdomeinen en enkele gebruikers.
  * [btunnel](https://www.btunnel.in/) — Stel localhost en lokale tcp-server bloot aan het internet. Gratis plan omvat file server, aangepaste http-request- en response-headers, basic auth-beveiliging en 1 uur tunnel-timeout.

**[⬆️ Terug naar boven](#table-of-contents)**

## Issue Tracking en Project Management

  * [acunote.com](https://www.acunote.com/) — Gratis projectmanagement- en SCRUM-software voor maximaal 5 teamleden.
  * [asana.com](https://asana.com/) — Gratis voor privéprojecten met medewerkers.
  * [Backlog](https://backlog.com) — Alles wat je team nodig heeft om geweldige projecten op één platform te lanceren. Het gratis plan biedt 1 project met tien gebruikers & 100MB opslag.
  * [Basecamp](https://basecamp.com/personal) - To-do-lijsten, mijlpaalbeheer, forumachtige berichten, bestandsdeling en tijdregistratie. Tot 3 projecten, 20 gebruikers en 1GB opslagruimte.
  * [bitrix24.com](https://www.bitrix24.com/) — Intranet- en projectmanagementtool. Het gratis plan heeft 5GB voor onbeperkte gebruikers.
  * [cacoo.com](https://cacoo.com/) — Online realtime diagrammen: flowchart, UML, netwerk. Gratis max. 15 gebruikers/diagram, 25 sheets.
  * [Chpokify](https://chpokify.com/) — Teams-based Planning Poker die tijd bespaart bij sprintinschattingen. Gratis tot 5 gebruikers, gratis Jira-integraties, onbeperkt videobellen, onbeperkte teams, onbeperkte sessies.
  * [clickup.com](https://clickup.com/) — Projectmanagement. Gratis, premiumversie met cloudopslag. Mobiele applicaties en Git-integraties beschikbaar.
  * [Clockify](https://clockify.me) - Tijdregistratie- en urenstaat-app waarmee je gewerkte uren per project kunt bijhouden. Onbeperkt aantal gebruikers, voor altijd gratis.
  * [Cloudcraft](https://cloudcraft.co/) — Ontwerp een professioneel architectuurdiagram in minuten met de Cloudcraft visual designer, geoptimaliseerd voor AWS met intelligente componenten die ook live data tonen. Gratis plan heeft onbeperkt aantal privédiagrammen voor één gebruiker.
  * [Codegiant](https://codegiant.io) — Projectmanagement met repository-hosting & CI/CD. Gratis plan biedt onbeperkte repositories, projecten & documenten met 5 teamleden. 500 CI/CD-minuten per maand. 30.000 serverloze coderun-minuten per maand, 1GB repository-opslag.
  * [Confluence](https://www.atlassian.com/software/confluence) - Atlassian's content collaboration tool wordt gebruikt om teams efficiënt te laten samenwerken en kennis te delen. Gratis plan voor tot 10 gebruikers.
  * [contriber.com](https://www.contriber.com/) — Aanpasbaar projectmanagementplatform, gratis starterplan, vijf werkruimtes.
* [Crosswork](https://crosswork.app/) - Veelzijdig projectmanagementplatform. Gratis voor maximaal 3 projecten, onbeperkt aantal gebruikers, 1 GB opslag.
* [diagrams.net](https://app.diagrams.net/) — Online diagrammen opgeslagen lokaal in Google Drive, OneDrive of Dropbox. Gratis voor alle functies en opslagniveaus.
* [freedcamp.com](https://freedcamp.com/) - taken, discussies, mijlpalen, tijdregistratie, kalender, bestanden en wachtwoordbeheer. Gratis plan met onbeperkte projecten, gebruikers en bestandsopslag.
* [easyretro.io](https://www.easyretro.io/) — Eenvoudige en intuïtieve sprint retrospectieve tool. Het gratis plan heeft drie openbare borden en één enquête per bord per maand.
* [GForge](https://gforge.com) — Projectmanagement- en issue tracking-toolset voor complexe projecten met opties voor zelf-hosting en SaaS. SaaS gratis plan biedt de eerste vijf gebruikers gratis & gratis voor Open Source Projecten.
* [gleek.io](https://www.gleek.io) — Gratis beschrijving-naar-diagrammen-tool voor ontwikkelaars. Maak informele UML class-, object- of entiteit-relatiediagrammen met behulp van jouw trefwoord.
* [GraphQL Inspector](https://github.com/marketplace/graphql-inspector) - GraphQL Inspector geeft een lijst met wijzigingen tussen twee GraphQL-schema's. Elk verschil wordt nauwkeurig uitgelegd en gemarkeerd als breaking, non-breaking of gevaarlijk.
* [huboard.com](https://huboard.com/) — Direct projectmanagement voor je GitHub-issues, gratis voor Open Source
* [Hygger](https://hygger.io) — Projectmanagementplatform. Het gratis plan biedt onbeperkt aantal gebruikers, projecten & borden met 100 MB opslag.
* [Instabug](https://instabug.com) —  Een uitgebreide bugrapportage- en in-app feedback-SDK voor mobiele apps. Gratis plan tot 1 app en één lid.
* [WishKit](https://wishkit.io) —  Verzamel in-app gebruikersfeedback voor je iOS/macOS-app en prioriteer functies op basis van gebruikersstemmen. Gratis plan tot 1 app.
* [Ilograph](https://www.ilograph.com/)  — interactieve diagrammen waarmee gebruikers hun infrastructuur vanuit meerdere perspectieven en detailniveaus kunnen bekijken. Grafieken kunnen in code worden uitgedrukt. De gratis versie heeft onbeperkt privédiagrammen met maximaal 3 kijkers.
* [Jira](https://www.atlassian.com/software/jira) — Geavanceerde projectmanagementtool voor softwareontwikkeling, veel gebruikt in bedrijfsomgevingen. Gratis plan voor maximaal 10 gebruikers.
* [kanbanflow.com](https://kanbanflow.com/) — Bord-gebaseerd projectmanagement. Gratis, premiumversie met meer opties
* [kanbantool.com](https://kanbantool.com/) — Kanbanbord-gebaseerd projectmanagement. Het gratis plan heeft twee borden en twee gebruikers, zonder bijlagen of bestanden.
* [kan.bn](https://kan.bn/) - Een krachtige, flexibele kanban-app die helpt werk te organiseren, voortgang te volgen en resultaten te leveren — allemaal op één plek. Gratis plan tot 1 gebruiker voor onbeperkte borden, lijsten en kaarten.
* [Kitemaker.co](https://kitemaker.co) - Samenwerken door alle fasen van het productontwikkelingsproces en werk bijhouden via Slack, Discord, Figma en Github. Onbeperkt aantal gebruikers en ruimtes. Gratis plan tot 250 werkitems.
* [Kiter.app](https://www.kiter.app/) - Laat iedereen zijn/haar zoektocht naar werk organiseren en sollicitaties, kansen en connecties volgen. Krachtige webapp en Chrome-extensie. Volledig gratis.
* [Kumu.io](https://kumu.io/)  — Relatiekaarten met animatie, decoraties, filters, clustering, spreadsheet-import, enz. De gratis versie staat onbeperkte openbare projecten toe. Grafiekgrootte onbeperkt. Gratis privéprojecten voor studenten. Sandboxmodus beschikbaar als je je bestand niet openbaar online wilt laten staan (uploaden, bewerken, downloaden, verwijderen).
* [Linear](https://linear.app/) — Issue tracker met een gestroomlijnde interface. Gratis voor onbeperkte leden, tot 10MB bestandsupload, 250 issues (exclusief Archief)
* [leiga.com](https://www.leiga.com/) — Leiga is een SaaS-product dat AI gebruikt om automatisch je projecten te beheren, zodat je team gefocust blijft en enorme potentie benut, en je projecten verlopen zoals gepland. Gratis voor maximaal 10 gebruikers, 20 aangepaste velden, 2GB opslagruimte, Video-opname met AI beperkt tot 5 min/video, Automatisering 20 keer per gebruiker/maand.
* [Lucidchart](https://www.lucidchart.com/) - Een online diagramtool met samenwerkingsfuncties. Gratis plan met drie bewerkbare documenten, 100 professionele sjablonen en basis-samenwerkingsfuncties.
* [MeisterTask](https://www.meistertask.com/) — Online taakbeheer voor teams. Gratis tot 3 projecten en onbeperkt aantal projectleden.
* [MeuScrum](https://www.meuscrum.com/en) - Gratis online scrumtool met kanbanbord
* [nTask](https://www.ntaskmanager.com/) — Projectmanagementsoftware waarmee teams kunnen samenwerken, plannen, analyseren en dagelijkse taken beheren. Het essentiële plan is voor altijd gratis met 100 MB opslag en vijf gebruikers/teams. Onbeperkte werkruimtes, vergaderingen, toewijzingen, timesheets en issue tracking.
* [Ora](https://ora.pm/) - Agile taakbeheer & team samenwerking. Gratis voor maximaal 3 gebruikers en bestanden beperkt tot 10 MB.
* [pivotaltracker.com](https://www.pivotaltracker.com/) — Gratis voor onbeperkte openbare projecten en twee privéprojecten met in totaal drie actieve gebruikers (lees-schrijf) en onbeperkte passieve gebruikers (alleen-lezen).
* [plan.io](https://plan.io/) — Projectmanagement met repository hosting en meer opties. Gratis voor twee gebruikers met tien klanten en 500MB opslag.
* [Plane](https://plane.so/) - Plane is een eenvoudige, uitbreidbare, open-source project- en productmanagementtool. Gratis voor onbeperkte leden, tot 5MB bestandsupload, 1000 issues.
* [planitpoker.com](https://www.planitpoker.com/) — Gratis online planning poker (schattingstool)
* [point.poker](https://www.point.poker/) - Online Planning Poker (consensus-gebaseerde schattingstool). Gratis voor onbeperkte gebruikers, teams, sessies, rondes en stemmen. Je hoeft je niet te registreren.
* [ScrumFast](https://www.scrumfast.com) - Scrum-bord met een zeer intuïtieve interface, gratis tot 5 gebruikers.
* [Shake](https://www.shakebugs.com/) - In-app bugrapportage en feedbacktool voor mobiele apps. Gratis plan, tien bugrapporten per app/maand.
* [Shortcut](https://shortcut.com/) - Projectmanagementplatform. Gratis voor maximaal 10 gebruikers voor altijd.
* [Tadum](https://tadum.app) - App voor vergaderagenda's en notulen, ontworpen voor terugkerende vergaderingen, gratis voor teams tot 10 personen.
* [taiga.io](https://taiga.io/) — Projectmanagementplatform voor startups en agile ontwikkelaars, gratis voor Open Source
* [Tara AI](https://tara.ai/) — Eenvoudige sprintmanagementservice. Het gratis plan heeft onbeperkte taken, sprints en werkruimtes zonder gebruikerslimieten.
* [targetprocess.com](https://www.targetprocess.com/) — Visueel projectmanagement, van Kanban en Scrum tot bijna elk operationeel proces. Gratis voor onbeperkte gebruikers, tot 1.000 data-entiteiten {[meer details](https://www.targetprocess.com/pricing/)}
* [taskade.com](https://www.taskade.com/) — Real-time gezamenlijke takenlijsten en teamoutlines. Het gratis plan heeft één werkruimte met onbeperkte taken en projecten; 1GB bestandsopslag; 1 week projectgeschiedenis; en vijf deelnemers per videogesprek.
* [taskulu.com](https://taskulu.com/) — Rolgebaseerd projectmanagement. Gratis tot 5 gebruikers. Integratie met GitHub/Trello/Dropbox/Google Drive
* [Teaminal](https://www.teaminal.com) - Standup-, retro- en sprintplanningstool voor remote teams. Gratis voor maximaal 15 gebruikers.
* [teamwork.com](https://teamwork.com/) — Projectmanagement & Team Chat. Gratis voor vijf gebruikers en twee projecten. Premium plannen beschikbaar.
* [teleretro.com](https://www.teleretro.com/) — Eenvoudige en leuke retrospectie-tool met ijsbrekers, gifs en emoji's. Het gratis plan omvat drie retros en onbeperkte leden.
* [testlio.com](https://testlio.com/) — Issue tracking, testmanagement en beta testplatform. Gratis voor privégebruik
* [terrastruct.com](https://terrastruct.com/) — Online diagrammaker specifiek voor softwarearchitectuur. Gratis versie tot 4 lagen per diagram.
* [todoist.com](https://todoist.com/) — Samenwerking en individueel taakbeheer. Het gratis plan heeft: 5 actieve projecten, vijf gebruikers per project, bestandsupload tot 5MB, drie filters en een week aan activiteitengeschiedenis.
* [trello.com](https://trello.com/) — Bord-gebaseerd projectmanagement. Onbeperkte persoonlijke borden, 10 teamborden.
* [Tweek](https://tweek.so/) — Simpele wekelijkse to-do kalender & taakbeheer.
* [ubertesters.com](https://ubertesters.com/) — Testplatform, integratie en crowd testers, 2 projecten, vijf leden
* [Wikifactory](https://wikifactory.com/) — Productontwerpdienst met projecten, VCS & issues. Het gratis plan biedt onbeperkte projecten & medewerkers en 3GB opslag.
* [Yodiz](https://www.yodiz.com/) — Agile ontwikkeling en issue tracking. Gratis tot 3 gebruikers, onbeperkte projecten.
* [YouTrack](https://www.jetbrains.com/youtrack/buy/#edition=incloud) — Gratis gehoste YouTrack (InCloud) voor FOSS-projecten en privéprojecten (gratis voor drie gebruikers). Inclusief tijdregistratie en agile borden
* [zenhub.com](https://www.zenhub.com) — De enige projectmanagementoplossing binnen GitHub. Gratis voor openbare repos, OSS en non-profitorganisaties
* [zenkit.com](https://zenkit.com) — Projectmanagement- en samenwerkingshulpmiddel. Gratis voor maximaal 5 leden, 5 GB bijlagen.
* [Zube](https://zube.io) — Projectmanagement met gratis plan voor 4 projecten & 4 gebruikers. GitHub-integratie beschikbaar.
* [Toggl](https://toggl.com/) — Biedt twee gratis productiviteitstools. [Toggl Track](https://toggl.com/track/) voor tijdbeheer en tijdregistratie-app met een gratis plan voor naadloze tijdregistratie en rapportage, ontworpen voor freelancers. Het heeft onbeperkt aantal trackingrecords, projecten, klanten, tags, rapportages en meer. En [Toggl Plan](https://toggl.com/plan/) voor taakplanning met een gratis plan voor solodevelopers met onbeperkte taken, mijlpalen en tijdlijnen.
* [Sflow](https://sflow.io) — sflow.io is een projectmanagementtool gebouwd voor agile softwareontwikkeling, marketing, sales en klantenondersteuning, vooral voor outsourcing en samenwerking over organisaties heen. Gratis plan tot 3 projecten en vijf leden.
* [Pulse.red](https://pulse.red) — Gratis minimalistische tijdregistratie- en urenregistratie-app voor projecten.

**[⬆️ Terug naar boven](#table-of-contents)**

## Opslag en Mediaverwerking

* [AndroidFileHost](https://androidfilehost.com/) - Gratis file-sharing platform met onbeperkte snelheid, bandbreedte, aantal bestanden, aantal downloads, enz. Gericht op Android-ontwikkelbestanden zoals APK-builds, custom ROMs & modificaties, etc. Maar lijkt ook andere bestanden te accepteren.
* [borgbase.com](https://www.borgbase.com/) — Eenvoudige en veilige offsite back-up hosting voor Borg Backup. 10 GB gratis back-upruimte en twee repositories.
* [icedrive.net](https://www.icedrive.net/) - Simpele cloudopslagdienst. 10 GB gratis opslag
* [sync.com](https://www.sync.com/) - End-to-End cloudopslagdienst. 5 GB gratis opslag
* [pcloud.com](https://www.pcloud.com/) - Cloudopslagdienst. Tot 10 GB gratis opslag
* [sirv.com](https://sirv.com/) — Slimme Image CDN met on-the-fly beeldoptimalisatie en -vergroting. Het gratis niveau omvat 500 MB opslag en 2 GB bandbreedte.
* [cloudimage.io](https://www.cloudimage.io/en/home) — Volledige beeldoptimalisatie en CDN-dienst met 1500+ Points of Presence wereldwijd. Diverse functies voor beeldvergroting, compressie en watermerken. Open source plugins voor responsive images, 360-afbeeldingen en beeldbewerking. Gratis maandelijks plan met 25GB CDN-verkeer, 25GB cache-opslag en onbeperkte transformaties.
* [cloudinary.com](https://cloudinary.com/) — Afbeeldingen uploaden, krachtige bewerkingen, opslag en levering voor sites en apps, met bibliotheken voor Ruby, Python, Java, PHP, Objective-C, en meer. Het gratis niveau omvat 25 maandelijkse credits. Eén credit = 1.000 afbeeldingsbewerkingen, 1 GB opslag of 1 GB CDN-gebruik.
* [embed.ly](https://embed.ly/) — Biedt API's voor het embedden van media in een webpagina, responsive beeldschaal en het extraheren van elementen uit een webpagina. Gratis tot 5.000 URLs/maand bij 15 verzoeken/seconde
* [filestack.com](https://www.filestack.com/) — File picker, transformeren en leveren, gratis tot 250 bestanden, 500 transformaties en 3 GB bandbreedte
* [file.io](https://www.file.io) - 2 GB opslag van bestanden. Een bestand wordt automatisch verwijderd na één download. REST API om met de opslag te communiceren. Rate limit één aanvraag/minuut.
* [freetools.site](https://freetools.site/) — Gratis online tools. Converteer of bewerk documenten, afbeeldingen, audio, video en meer.
* [GoFile.io](https://gofile.io/) - Gratis platform voor het delen en opslaan van bestanden, te gebruiken via web-gebaseerde UI & ook API. Onbeperkte bestandsgrootte, bandbreedte, aantal downloads, etc. Maar bestand wordt verwijderd als het inactief is (geen download meer dan tien dagen).
* [gumlet.com](https://www.gumlet.com/) — Afbeeldingen en video's hosten, verwerken en streamen via CDN. Royale gratis laag van 250 GB / maand voor video's en 30 GB / maand voor afbeeldingen.
* [image-charts.com](https://www.image-charts.com/) — Onbeperkt beeldgrafieken genereren met een watermerk
* [Imgbot](https://github.com/marketplace/imgbot) — Imgbot is een vriendelijke robot die je afbeeldingen optimaliseert en je tijd bespaart. Geoptimaliseerde afbeeldingen betekenen kleinere bestandsformaten zonder kwaliteitsverlies. Gratis voor open source.
* [ImgBB](https://imgbb.com/) — ImgBB is een onbeperkte afbeeldingshostingdienst. Sleep je afbeelding ergens op het scherm. 32 MB / afbeelding limiet. Ontvang directe afbeeldingslinks, BBCode en HTML-thumbnails na uploaden. Inloggen om de uploadgeschiedenis te zien.
* [imgen](https://www.jitbit.com/imgen/) - Gratis onbeperkte social cover image generation API, geen watermerk
* [imgix](https://www.imgix.com/) - Afbeeldingscaching, beheer en CDN. Gratis plan omvat 1000 originele afbeeldingen, oneindige transformaties en 100 GB bandbreedte
* [kraken.io](https://kraken.io/) — Afbeeldingsoptimalisatie als dienst voor websiteprestaties, gratis plan tot 1 MB bestandsgrootte
* [kvstore.io](https://www.kvstore.io/) — Key-value opslagdienst. Het gratis niveau staat 100 keys toe, 1KB/key, 100 calls/uur
* [npoint.io](https://www.npoint.io/) — JSON-opslag met gezamenlijke schema-bewerking
* [nitropack.io](https://nitropack.io/) - Versnel de snelheid van je site automatisch met volledige front-end optimalisatie (caching, afbeeldingen- en code-optimalisatie, CDN). Gratis voor tot 5.000 pageviews/maand
* [otixo.com](https://www.otixo.com/) — Versleutel, deel, kopieer en verplaats al je cloudopslagbestanden vanaf één plek. Het basisplan biedt onbeperkte bestandsoverdracht met 250 MB max. bestandsgrootte en staat vijf versleutelde bestanden toe
* [packagecloud.io](https://packagecloud.io/) — Gehoste pakketrepositories voor YUM, APT, RubyGem en PyPI.  Beperkte gratis plannen en open source-plannen beschikbaar op aanvraag
* [getpantry.cloud](https://getpantry.cloud/) — Een eenvoudige JSON-dataopslag API, perfect voor persoonlijke projecten, hackathons en mobiele apps!
* [Pinata IPFS](https://pinata.cloud) — Pinata is de eenvoudigste manier om bestanden te uploaden en te beheren op IPFS. Onze gebruiksvriendelijke interface en IPFS API maken Pinata de makkelijkste IPFS-pinningservice voor platforms, makers en verzamelaars. 1 GB opslag gratis, inclusief toegang tot de API.
* [placekitten.com](https://placekitten.com/) — Een snelle en eenvoudige dienst voor het verkrijgen van plaatjes van kittens als placeholders
* [plot.ly](https://plot.ly/) — Grafieken maken en je data delen. De gratis versie bevat onbeperkte openbare bestanden en tien privébestanden
* [podio.com](https://podio.com/) — Je kunt Podio gebruiken met een team van maximaal vijf personen en de functies van het Basic Plan uitproberen, behalve gebruikersbeheer
* [QRME.SH](https://qrme.sh) - Snelle, mooie bulk QR-code generator – geen login, geen watermerk, geen advertenties. Tot 100 URLs per bulk export.
* [QuickChart](https://quickchart.io) — Genereer in te sluiten afbeeldingsgrafieken, diagrammen en QR-codes
* [redbooth.com](https://redbooth.com) — P2P bestandssynchronisatie, gratis voor tot 2 gebruikers
* [resmush.it](https://resmush.it) — reSmush.it is een GRATIS API die beeldoptimalisatie biedt. reSmush.it is geïmplementeerd op de meest gebruikte CMS zoals WordPress, Drupal of Magento. reSmush.it is de meest gebruikte API voor beeldoptimalisatie met meer dan zeven miljard afbeeldingen reeds verwerkt, en nog steeds gratis.
* [Shotstack](https://shotstack.io) - API om op schaal video te genereren en te bewerken. Gratis tot 20 minuten gerenderde video per maand
* [tinypng.com](https://tinypng.com/) — API om PNG- en JPEG-afbeeldingen te comprimeren en te verkleinen, biedt 500 compressies gratis per maand
* [transloadit.com](https://transloadit.com/) — Behandelt bestandsuploads en encoding van video, audio, afbeeldingen, documenten. Gratis voor Open source, goede doelen en studenten via het GitHub Student Developer Pack. Commerciële applicaties krijgen 2 GB gratis om te testen
  * [twicpics.com](https://www.twicpics.com) - Responsieve afbeeldingen als een service. Het biedt een image CDN, een mediaverwerkings-API en een frontend-bibliotheek om beeldoptimalisatie te automatiseren. De dienst is gratis tot 3GB verkeer/maand.
  * [uploadcare.com](https://uploadcare.com/hub/developers/) — Uploadcare biedt de mediapijplijn met de ultieme toolkit gebaseerd op geavanceerde algoritmen. Alle functies zijn volledig gratis beschikbaar voor ontwikkelaars: File Uploading API en UI, Image CDN en Origin Services, Adaptive Delivery en Smart Compression. De gratis laag heeft 3000 uploads, 3 GB verkeer en 3 GB opslag.
  * [imagekit.io](https://imagekit.io) – Image CDN met automatische optimalisatie, realtime transformatie en opslag die je in enkele minuten kunt integreren met je bestaande setup. Het gratis abonnement omvat tot 20GB bandbreedte per maand.
  * [internxt.com](https://internxt.com) – Internxt Drive is een zero-knowledge bestandsopslagdienst gebaseerd op absolute privacy en compromisloze beveiliging. Meld je aan en krijg 10 GB gratis, voor altijd!
  * [degoo.com](https://degoo.com/) – AI-gebaseerde cloudopslag met gratis tot 20 GB, drie apparaten, 5 GB referral bonus (90 dagen account-inactiviteit).
  * [MConverter.eu](https://mconverter.eu/) – Converteer bestanden in bulk. Ondersteunt vele bestandsformaten, inclusief nieuwe zoals [AVIF](https://mconverter.eu/convert/to/avif/). Extraheer alle afbeeldingsframes uit video's. Gratis tot tien 100MB-bestanden per dag, verwerkt in batches van twee.
  * [ImageEngine](https://imageengine.io/) – ImageEngine is een eenvoudig te gebruiken wereldwijde image CDN. Setup binnen 60 sec. AVIF- en JPEGXL-ondersteuning, WordPress-, Magento-, React-, Vue-plugins en meer. Claim je gratis ontwikkelaarsaccount [hier](https://imageengine.io/developer-program/).
  * [DocsParse](https://docsparse.com/) – GPT-aangedreven AI-verwerking van PDF's, afbeeldingen, naar gestructureerde data in JSON-, CSV- en EXCEL-formaten. 30 gratis credits per maand.
  * [VaocherApp QR Code Generator](https://www.vaocherapp.com/qr-code-generator) – Maak eenvoudig aangepaste QR-codes voor cadeaubonnen, kortingsbonnen en promoties. Ondersteunt aangepaste styling, kleur, logo...
  * [LibreQR](https://libreqr.com) — Gratis QR-codegenerator gericht op privacy en zonder tracking. Gratis te gebruiken zonder dataverzameling.


**[⬆️ Terug naar boven](#table-of-contents)**

## Design en UI

  * [AllTheFreeStock](https://allthefreestock.com) - Een samengestelde lijst van gratis stockfoto’s, audio en video’s.
  * [Float UI](https://floatui.com/) - Gratis webontwikkeltool om snel moderne, responsieve websites met een strak design te maken, zelfs voor niet-designers.
  * [Ant Design Landing Page](https://landing.ant.design/) - Ant Design Landing Page biedt een sjabloon gebouwd met Ant Motion's motion-componenten. Het heeft een rijke homepage-sjabloon, downloadt het sjablooncodepakket en kan snel worden gebruikt. Je kunt ook de editor gebruiken om snel je eigen toegewijde pagina te bouwen.
  * [Backlight](https://backlight.dev/) — Met samenwerking tussen ontwikkelaars en ontwerpers als uitgangspunt is Backlight een compleet codeerplatform waar teams Design Systems bouwen, documenteren, publiceren, schalen en onderhouden. Het gratis abonnement staat toe dat tot 3 editors aan één design system werken met onbeperkt aantal kijkers.
  * [BoxySVG](https://boxy-svg.com/app) — Een gratis installeerbare web-app voor het tekenen van SVG's en het exporteren in SVG, PNG, jpeg en andere formaten.
  * [Carousel Hero](https://carouselhero.com/) - Gratis online tool om social media-carrousels te maken.
  * [Circum Icons](https://circumicons.com) - Consistente open-source iconen zoals SVG voor React, Vue en Svelte.
  * [clevebrush.com](https://www.cleverbrush.com/) — Gratis grafische ontwerp-/fotocollage-app. Ze bieden ook betaalde integratie als component.
  * [cloudconvert.com](https://cloudconvert.com/) — Converteer alles naar alles. Tweehonderd acht ondersteunde formaten inclusief video's en gifs.
  * [CodeMyUI](https://codemyui.com) - Handgekozen collectie van webdesign & UI-inspiratie met codefragmenten.
  * [ColorKit](https://colorkit.co/) - Maak online kleurpaletten of krijg inspiratie van top-palletten.
  * [coolors](https://coolors.co/) - Kleurpaletgenerator. Gratis.
  * [CMYK Pantone](https://www.cmyktopantone.com/) - Converteer eenvoudig CMYK-waarden naar de dichtstbijzijnde Pantone-kleuren en andere kleurmodellen in seconden gratis.
  * [Branition](https://branition.com/colors) - Handgeselecteerde kleurpaletten het best passend voor merken.
  * [css-gradient.com](https://www.css-gradient.com/) - Gratis tool om snel aangepaste cross-browser CSS-gradients te genereren. In RGB- en HEX-formaat.
  * [easyvectors.com](https://easyvectors.com/) — EasyVectors.com is een gratis SVG vector art stock. Download de beste vectorafbeeldingen helemaal gratis.
  * [figma.com](https://www.figma.com) — Online, collaboratieve ontwerptool voor teams; gratis laag omvat onbeperkt aantal bestanden en kijkers met maximaal 2 editors en drie projecten.
  * [Flyon UI](https://flyonui.com/)- De makkelijkste componentenbibliotheek voor Tailwind CSS.
  * [framer.com](https://www.framer.com/) - Framer helpt je interface-ideeën voor je volgende app, website of product te itereren en te animeren—beginnend met krachtige layouts. Voor iedereen die Framer als professioneel prototyping tool wil valideren: onbeperkt aantal kijkers, tot 2 editors en tot 3 projecten.
  * [freeforcommercialuse.net](https://freeforcommercialuse.net/) — FFCU zorgeloze model-/property-release stockfoto’s
  * [Gradientos](https://www.gradientos.app) - Maakt het kiezen van een gradient snel en makkelijk.
  * [Icon Horse](https://icon.horse) – Haal de hoogste resolutie favicon voor elke website via onze simpele API.
  * [Iconoir](https://iconoir.com) – Een open-source iconenbibliotheek met duizenden iconen, met ondersteuning voor React, React Native, Flutter, Vue, Figma en Framer.
  * [Icons8](https://icons8.com) — Iconen, illustraties, foto’s, muziek en designtools. Gratis abonnement biedt beperkte formaten in lagere resolutie. Verwijs naar Icons8 als je onze assets gebruikt.
  * [landen.co](https://www.landen.co) — Genereer, bewerk en publiceer mooie websites en landingspagina’s voor je startup. Alles zonder code. De gratis laag staat toe dat je één website hebt, volledig aanpasbaar en gepubliceerd op het web.
  * [Quant Ux](https://quant-ux.com/) - Quant Ux is een prototyping- en ontwerptool. - Het is volledig gratis en ook open source.
  * [lensdump.com](https://lensdump.com/) - Gratis cloud image hosting.
  * [Lorem Picsum](https://picsum.photos/) - Een gratis tool, eenvoudig te gebruiken, stijlvolle placeholders. Voeg na onze URL je gewenste afbeeldingsgrootte (breedte & hoogte) toe en je krijgt een willekeurige afbeelding.
  * [LottieFiles](https://lottiefiles.com/) - ’s Werelds grootste online platform voor het kleinste animatieformaat ter wereld voor ontwerpers, ontwikkelaars en meer. Toegang tot Lottie-animatietools en plug-ins voor Android, iOS en Web.
  * [MagicPattern](https://www.magicpattern.design/tools) — Een verzameling CSS- & SVG-achtergrondgeneratoren & tools voor gradients, patronen en blobs.
  * [marvelapp.com](https://marvelapp.com/) — Ontwerp, prototyping en samenwerking, gratis abonnement beperkt tot één gebruiker en project.
  * [Mindmup.com](https://www.mindmup.com/) — Onbeperkt aantal mindmaps gratis en sla ze op in de cloud. Je mindmaps zijn overal direct beschikbaar, vanaf elk apparaat.
  * [Mockplus iDoc](https://www.mockplus.com/idoc) - Mockplus iDoc is een krachtig samenwerking- en overdrachtstool voor ontwerp. Gratis plan bevat drie gebruikers en vijf projecten met alle functies beschikbaar.
  * [mockupmark.com](https://mockupmark.com/create/free) — Maak realistische t-shirt- en kledingmockups voor social media en e-commerce, 40 gratis mockups.
  * [Mossaik](https://mossaik.app) - Gratis SVG-afbeeldinggenerator met verschillende tools zoals golven, blogs en patronen.
  * [movingpencils.com](https://movingpencils.com) — Snelle, browsergebaseerde vectortekenaar. Volledig gratis.
  * [Octopus.do](https://octopus.do) — Visuele sitemapbouwer. Bouw je websitestructuur in realtime en deel deze snel om samen te werken met je team of klanten.
  * [Pencil](https://github.com/evolus/pencil) - Open source ontwerptool op basis van Electron.
  * [Penpot](https://penpot.app) - Webgebaseerde, open-source ontwerp- en prototypingtool. Ondersteunt SVG. Volledig gratis.
  * [pexels.com](https://www.pexels.com/) - Gratis stockfoto’s voor commercieel gebruik. Heeft een gratis API waarmee je foto’s kunt zoeken op trefwoorden.
  * [photopea.com](https://www.photopea.com) — Een gratis, geavanceerde online ontwerpbewerker met Adobe Photoshop UI die PSD-, XCF- en Sketch-formaten ondersteunt (Adobe Photoshop, Gimp en Sketch App).
  * [pixlr.com](https://pixlr.com/) — Gratis online browsereditor op het niveau van commerciële editors.
  * [Plasmic](https://www.plasmic.app/) - Een snelle, gebruiksvriendelijke, robuuste webdesigntool en page builder die integreert in je codebase. Bouw responsieve pagina’s of complexe componenten; optioneel uitbreiden met code; en publiceren naar productiesites en apps.
  * [Pravatar](https://pravatar.cc/) - Genereer een willekeurige/placeholder nep-avatar waarvan de URL direct kan worden ge-hotlinkt in je web/app.
  * [Proto.io](https://www.proto.io) - Maak volledig interactieve UI-prototypes zonder coderen. De gratis laag is beschikbaar wanneer de gratis proefperiode eindigt. De gratis laag omvat één gebruiker, één project, vijf prototypes, 100MB online opslag en een preview van de proto.io-app.
  * [resizeappicon.com](https://resizeappicon.com/) — Een eenvoudige dienst om je app-iconen te verkleinen en beheren.
  * [Rive](https://rive.app) — Maak en lever prachtige animaties op elk platform. Altijd gratis voor individuen. De dienst is een editor die ook alle grafische bestanden op hun servers host. Ze bieden ook runtimes voor vele platforms om representaties gemaakt met Rive te laten draaien.
  * [storyset.com](https://storyset.com/) — Maak ongelooflijke gratis aangepaste illustraties voor je project met deze tool.
  * [smartmockups.com](https://smartmockups.com/) — Maak productmockups, 200 gratis mockups.
  * [Shadcn Studio](https://shadcnstudio.com/theme-editor) — Bekijk je thema-aanpassingen in realtime bij verschillende componenten en layouts.
  * [Tailark](https://tailark.com/) - Een verzameling moderne, responsieve, kant-en-klare UI-blokken ontworpen voor marketingwebsites.
  * [tabler-icons.io](https://tabler-icons.io/) — Meer dan 1500 gratis copy-and-paste SVG-bewerkbare iconen.
  * [tweakcn](https://tweakcn.com/) — Mooie thema’s voor shadcn/ui. Pas kleuren, typografie en meer aan in realtime.
  * [UI Avatars](https://ui-avatars.com/) - Genereer avatars met initialen uit namen. De URLs kunnen direct worden ge-hotlinkt in je web/app. Ondersteunt configparameters via de URL.
  * [unDraw](https://undraw.co/) - Een voortdurend bijgewerkte verzameling prachtige SVG-afbeeldingen die je volledig gratis en zonder attributie kunt gebruiken.
  * [unsplash.com](https://unsplash.com/) - Gratis stockfoto’s voor commerciële en niet-commerciële doeleinden (doe-wat-je-wilt-licentie).
  * [vectr.com](https://vectr.com/) — Gratis ontwerp-app voor web + desktop.
  * [walkme.com](https://www.walkme.com/) — Enterprise Class Guidance and Engagement Platform, gratis plan drie walk-thru’s tot 5 stappen/walk.
  * [Webflow](https://webflow.com) - WYSIWYG-websitebouwer met animaties en websitehosting. Gratis voor twee projecten.
  * [Updrafts.app](https://updrafts.app) - WYSIWYG-websitebouwer voor tailwindcss-gebaseerde ontwerpen. Gratis voor niet-commercieel gebruik.
  * [whimsical.com](https://whimsical.com/) - Samenwerkende flowcharts, wireframes, plaknotities en mindmaps. Maak tot 4 gratis borden.
  * [Zeplin](https://zeplin.io/) — Platform voor samenwerking tussen ontwerpers en ontwikkelaars. Toon ontwerpen, assets en stijlhandleidingen. Gratis voor één project.
  * [Pixelixe](https://pixelixe.com/) — Maak en bewerk boeiende, unieke graphics en afbeeldingen online.
  * [Responsively App](https://responsively.app) - Een gratis dev-tool voor snellere en nauwkeurigere ontwikkeling van responsieve webapplicaties.
  * [SceneLab](https://scenelab.io) - Online mockup-grafische editor met een steeds groeiende collectie gratis ontwerp-sjablonen.
  * [xLayers](https://xlayers.dev) - Bekijk en converteer Sketch-ontwerpbestanden naar Angular, React, Vue, LitElement, Stencil, Xamarin en meer (gratis en open source op https://github.com/xlayers/xlayers)
  * [Grapedrop](https://grapedrop.com/) — Responsieve, krachtige, SEO-geoptimaliseerde webpagina-bouwer gebaseerd op het GrapesJS Framework. Gratis voor de eerste vijf pagina’s, onbeperkt aantal aangepaste domeinen, alle functies en eenvoudig gebruik.
  * [Mastershot](https://mastershot.app) - Volledig gratis browsergebaseerde video-editor. Geen watermerk, tot 1080p exportopties.
  * [Unicorn Platform](https://unicornplatform.com/) - Moeiteloze landingspagina-bouwer met hosting. Eén website gratis.
  * [SVGmix.com](https://www.svgmix.com/) - Enorme repository van 300K+ gratis SVG-iconen, collecties en merklijnen. Het heeft een eenvoudige vectorbewerkingsprogramma direct in de browser voor snelle bestandsbewerking.
  * [svgrepo.com](https://www.svgrepo.com/) - Ontdek, zoek en vind de best passende iconen of vectoren voor je projecten met behulp van verschillende vectorbibliotheken. Download gratis SVG-vectoren voor commercieel gebruik.
  * [haikei.app](https://www.haikei.app/) - Haikei is een webapp om unieke SVG-vormen, achtergronden en patronen te genereren – klaar voor gebruik in je ontwerp-tools en workflow.
  * [Canva](https://canva.com) - Gratis online designtool om visuele content te maken.
  * [Superdesigner](https://superdesigner.co) - Een collectie gratis designtools om unieke achtergronden, patronen, vormen, afbeeldingen en meer te maken met slechts enkele klikken.
  * [TeleportHQ](https://teleporthq.io/) - Low-code Front-end Design & Development Platform. TeleportHQ is het collaboratieve front-end platform om direct headless statische websites te maken en te publiceren. Drie gratis projecten, onbeperkt aantal medewerkers en gratis code-export.
  * [vector.express](https://vector.express) — Converteer je AI-, CDR-, DWG-, DXF-, EPS-, HPGL-, PDF-, PLT-, PS- en SVG-vector snel en gemakkelijk.
  * [Vertopal](https://www.vertopal.com) - Vertopal is een gratis online platform voor het converteren van bestanden naar verschillende formaten. Inclusief ontwikkelaar-converters zoals JPG naar SVG, GIF naar APNG, PNG naar WEBP, JSON naar XML, enz.
  * [okso.app](https://okso.app) - Minimalistische online tekenapp. Hiermee kun je snel schetsen en visuele notities maken. Exporteert schetsen naar PNG, JPG, SVG en WEBP. Ook te installeren als PWA. Gratis te gebruiken voor iedereen (geen registratie nodig).
  * [Wdrfree SVG](https://wdrfree.com/free-svg) - Zwart-witte gratis SVG-cuts.
  * [Lucide](https://lucide.dev) - Gratis aanpasbare en consistente SVG-iconentoolkit.
  * [Logo.dev](https://www.logo.dev) - Bedrijfslogo-API met 44M+ merken, net zo eenvoudig als het aanroepen van een URL. De eerste 10.000 API-aanroepen zijn gratis.
  * [MDBootstrap](https://mdbootstrap.com/) - Gratis voor persoonlijk & commercieel gebruik Bootstrap-, Angular-, React- en Vue UI-kits met meer dan 700 componenten, prachtige sjablonen, installatie in 1 minuut, uitgebreide tutorials & enorme community.
  * [TW Elements](https://tw-elements.com/) - Gratis Bootstrap-componenten opnieuw gemaakt met Tailwind CSS, maar met beter design en meer functionaliteit.
  * [DaisyUI](https://daisyui.com/) -- Gratis. "Gebruik Tailwind CSS maar schrijf minder class-namen" biedt componenten zoals knoppen.
* [Scrollbar.app](https://scrollbar.app) -- Eenvoudige gratis webapp voor het ontwerpen van aangepaste scrollbars voor het web.
* [css.glass](https://css.glass/) -- Gratis webapp voor het maken van glassmorphische ontwerpen met CSS.
* [hypercolor.dev](https://hypercolor.dev/) -- Een samengestelde collectie van Tailwind CSS kleurverlopen, biedt ook verschillende generators om je eigen te maken.
* [iconify.design](https://icon-sets.iconify.design/) -- Een verzameling van meer dan 100 iconenpakketten met een uniforme interface. Hiermee kun je iconen zoeken over verschillende pakketten en individuele iconen exporteren als SVG's of voor populaire webframeworks.
* [NextUI](https://nextui.org/) -- Gratis. Mooie, snelle en moderne React & Next.js UI-bibliotheek.
* [Glyphs](https://glyphs.fyi/) -- Gratis, The Mightiest Icons on the Web, volledig bewerkbaar & echt open source design systeem.
* [ShadcnUI](https://ui.shadcn.com/) -- Mooi ontworpen componenten die je kunt kopiëren en plakken in je apps. Toegankelijk. Aanpasbaar. Open Source.
* [HyperUI](https://www.hyperui.dev/) -- Gratis Open Source Tailwind CSS-componenten.
* [Calendar Icons Generator](https://calendariconsgenerator.app/) -- Genereer een heel jaar aan unieke iconen in één klik, helemaal GRATIS.
* [Image BG Blurer](https://imagebgblurer.com/) -- Genereer een vervaagde achtergrond voor een afbeelding, met de bronafbeelding als achtergrondvervaging, voor Notion, Trello, Jira en meer tools.
* [Webstudio](https://webstudio.is/) -- Open-source alternatief voor Webflow. Het gratis plan biedt onbeperkt websites op hun domein. Vijf websites met eigen domein. Tienduizend pageviews/maand. 2 GB opslagruimte voor assets.
* [Nappy](https://nappy.co/) -- Mooie foto's van Zwarte en Bruine mensen, gratis. Voor commercieel en persoonlijk gebruik.
* [Tailkits](https://tailkits.com/) -- Een samengestelde collectie van Tailwind-templates, componenten en tools, plus handige generators voor code, grids, box-shadows en meer.
* [Tailcolors](https://tailcolors.com/) -- Een prachtig Tailwind CSS v4 kleurenpalet. Direct voorbeeld & kopieer de perfecte Tailwind CSS kleurklasse.
* [Excalidraw](https://excalidraw.com/) -- Een gratis online tekenwebpagina met gratis opslaan lokaal en exportondersteuning.
* [Lunacy](https://icons8.com/lunacy) -- Gratis grafisch ontwerpgereedschap met offline ondersteuning, ingebouwde assets (iconen, foto's, illustraties) en realtime samenwerking. De gratis laag bevat 10 cloud-documenten, een 30-dagen geschiedenis, lage resolutie assets en basis ontwerptools.

**[⬆️ Terug naar boven](#table-of-contents)**

## Design Inspiratie

* [awwwards.](https://www.awwwards.com/) - [Top websites] Een etalage van de best ontworpen websites (beoordeeld door ontwerpers).
* [Behance](https://www.behance.net/) - [Design showcase] Een plek waar ontwerpers hun werk tonen. Filterbaar met categorieën voor UI/UX-projecten.
* [dribbble](https://dribbble.com/) - [Design showcase] Unieke designinspiratie, meestal niet uit echte applicaties.
* [Landings](https://landings.dev/) - [Web screenshots] Vind de beste landingspagina's voor je designinspiratie op basis van je voorkeur.
* [Lapa Ninja](https://www.lapa.ninja/) - [Landing page / UI Kits / Web screenshots] Lapa Ninja is een galerij met de beste 6025 landingspagina voorbeelden, gratis boeken voor ontwerpers en gratis UI-kits van over het web.
* [LovelyLanding.net](https://www.lovelylanding.net/) - [Landing Page Designs] Regelmatig bijgewerkte screenshots van landingspagina's. Inclusief Desktop-, Tablet- en Mobiele screenshots.
* [Mobbin](https://mobbin.design/) - [Mobile screenshots] Bespaar uren aan UI & UX-onderzoek met onze bibliotheek van 50.000+ volledig doorzoekbare mobiele app-screenshots.
* [Uiland Design](https://uiland.design/) - [Mobile screenshots] Ontdek mobiele en web UI-designs van toonaangevende bedrijven in Afrika en de wereld.
* [Mobile Patterns](https://www.mobile-patterns.com/) - [Mobile screenshots] Een designinspiratiebibliotheek met de beste UI UX-patronen (iOS en Android) voor ontwerpers, ontwikkelaars en productmakers ter referentie.
* [Page Flows](https://pageflows.com/) - [Mobile / web video's en screenshots] Video's van volledige flows in veel mobiele en web-apps. Bevat ook screenshots. Zeer doorzoekbaar en geïndexeerd.
* [Screenlane](https://screenlane.com/) - [Mobile screenshots] Laat je inspireren en blijf op de hoogte van de nieuwste web & mobiele app UI-designtrends. Filterbaar op patroon en app.
* [scrnshts](https://scrnshts.club/) - [Mobile screenshots] Een zorgvuldig samengestelde collectie van de beste app store design-screenshots.
* [Refero](https://refero.design/) - [Web screenshots] Getagde en doorzoekbare collectie van designreferenties uit geweldige webapplicaties.

**[⬆️ Terug naar boven](#table-of-contents)**

## Datavisualisatie op Kaarten

* [IP Geolocation](https://ipgeolocation.io/) — Gratis DEVELOPER-plan beschikbaar met 30K verzoeken/maand.
* [carto.com](https://carto.com/) — Maak kaarten en geospatiale API's van je eigen en openbare data.
* [Clockwork Micro](https://clockworkmicro.com/) — Kaarttools die werken als een klok. Vijftigduizend gratis maandelijkse aanvragen (kaarttegels, db2vector, hoogte).
* [developers.arcgis.com](https://developers.arcgis.com) — API's en SDK's voor kaarten, opslag van geospatiale data, analyse, geocodering, routering en meer, voor web, desktop en mobiel. Twee miljoen gratis basemap-tiles, 20.000 niet-opgeslagen geocodes, 20.000 eenvoudige routes, 5.000 rijtijd-berekeningen en 5GB gratis tile+dataopslag per maand.
* [Foursquare](https://developer.foursquare.com/) - Locatieontdekking, venue-zoekfunctie en contextbewuste inhoud van Places API en Pilgrim SDK.
* [geoapify.com](https://www.geoapify.com/) - Vector- en rasterkaarttegels, geocodering, plaatsen, routering, isolijnen API's. Drie duizend gratis verzoeken/dag.
* [geocod.io](https://www.geocod.io/) — Geocodering via API of CSV-upload. Twee duizend vijfhonderd gratis aanvragen/dag.
* [geocodify.com](https://geocodify.com/) — Geocodering en geoparsing via API of CSV-upload. 10k gratis aanvragen/maand.
* [geojs.io](https://www.geojs.io/) - Hoog-beschikbare REST/JSON/JSONP IP-geolocatie lookup API.
* [giscloud.com](https://www.giscloud.com/) — Visualiseer, analyseer en deel geo-data online.
* [graphhopper.com](https://www.graphhopper.com/) Een gratis ontwikkelaars-pakket wordt aangeboden voor routering, route-optimalisatie, afstandsmatrix, geocodering en map matching.
* [here](https://developer.here.com/) — API's en SDK's voor kaarten en locatiebewuste apps. 250k transacties/maand gratis.
* [locationiq.com](https://locationiq.com/) — Geocodering, kaarten en routerings-API's. Vijfduizend verzoeken/dag gratis.
* [mapbox.com](https://www.mapbox.com/) — Kaarten, geospatiale diensten en SDK's voor het weergeven van kaartdata.
* [maptiler.com](https://www.maptiler.com/cloud/) — Vectorkaarten, kaartdiensten en SDK's voor kaartvisualisatie. Gratis vector tiles met wekelijkse updates en vier kaartstijlen.
* [nominatim.org](https://nominatim.org/) — OpenStreetMap's gratis geocoding service, biedt wereldwijde adreszoekfunctionaliteit en reverse geocoding mogelijkheden.
* [nextbillion.ai](https://nextbillion.ai/) - Kaartgerelateerde diensten: Geocodering, Navigatie (richting, routering, route-optimalisatie, afstandsmatrix), Maps SDK (Vector, Statisch, Mobile SDK). [Gratis met opgegeven quota](https://nextbillion.ai/pricing) voor elke dienst.
* [opencagedata.com](https://opencagedata.com) — Geocoding API die OpenStreetMap en andere open geo-bronnen samenvoegt. Twee duizend vijfhonderd gratis aanvragen/dag.
* [osmnames](https://osmnames.org/) — Geocodering, zoekresultaten gerangschikt naar populariteit van het bijbehorende Wikipedia-pagina.
* [positionstack](https://positionstack.com/) - Gratis geocodering voor wereldwijde plaatsen en coördinaten. 25.000 aanvragen per maand voor persoonlijk gebruik.
* [stadiamaps.com](https://stadiamaps.com/) — Kaarttegels, routering, navigatie en andere geospatiale API's. Twee duizend vijfhonderd gratis kaartweergaven en API-aanvragen/dag voor niet-commercieel gebruik en testen.
* [maps.stamen.com](http://maps.stamen.com/) - Gratis kaarttegels en tegelhosting.
* [ipstack](https://ipstack.com/) - Lokaliseer en identificeer websitebezoekers op IP-adres.
* [Geokeo api](https://geokeo.com) - Geocoding API met taalcorrigerende functies en meer. Wereldwijde dekking. 2.500 gratis dagelijkse aanvragen.

**[⬆️ Terug naar boven](#table-of-contents)**

## Package Build System

* [build.opensuse.org](https://build.opensuse.org/) — Pakketbouwservice voor meerdere distro's (SUSE, EL, Fedora, Debian, enz.).
* [copr.fedorainfracloud.org](https://copr.fedorainfracloud.org) — Mock-based RPM-buildservice voor Fedora en EL.
* [help.launchpad.net](https://help.launchpad.net/Packaging) — Ubuntu en Debian buildservice.

**[⬆️ Terug naar boven](#table-of-contents)**

## IDE en Code Editing

* [3v4l](https://3v4l.org/) - Gratis online PHP-shell en snippet-deelsite, die je code uitvoert in 300+ PHP-versies
* [Android Studio](https://developer.android.com/studio) — Android Studio biedt de snelste tools voor het bouwen van apps op elk type Android-apparaat. Open Source IDE is gratis voor iedereen en de beste Android app-ontwikkeling. Beschikbaar voor Windows, Mac, Linux en zelfs ChromeOS!
* [AndroidIDE](https://m.androidide.com/) — Een Open Source IDE om echte, Gradle-gebaseerde Android-applicaties te ontwikkelen op Android-apparaten.
* [Apache Netbeans](https://netbeans.apache.org/) — Ontwikkelomgeving, Tooling Platform en Applicatieframework.
* [apiary.io](https://apiary.io/) — Collaboratieve API-ontwerp met directe API-mock en gegenereerde documentatie (Gratis voor onbeperkte API-blueprints en onbeperkte gebruikers met één beheerdersaccount en gehoste documentatie).
* [BBEdit](https://www.barebones.com/) - BBEdit is een populaire en uitbreidbare editor voor macOS. Gratis modus biedt een [krachtige kernfunctionaliteit](https://www.barebones.com/products/bbedit/comparison.html) en een upgradepad naar geavanceerde functies.
* [Binder](https://mybinder.org/) - Zet een Git-repo om in een collectie interactieve notebooks. Het is een gratis publieke dienst.
* [BlueJ](https://bluej.org) — Een gratis Java-ontwikkelomgeving ontworpen voor beginners, gebruikt door miljoenen wereldwijd. Ondersteund door Oracle & eenvoudige GUI voor beginners.
* [Bootify.io](https://bootify.io/) - Spring Boot app generator met aangepaste database en REST API.
* [Brackets](http://brackets.io/) - Brackets is een open-source teksteditor speciaal ontworpen voor webontwikkeling. Het is lichtgewicht, eenvoudig te gebruiken en zeer aanpasbaar.
* [cacher.io](https://www.cacher.io) — Code snippet-organizer met labels en ondersteuning voor 100+ programmeertalen.
* [Code::Blocks](https://codeblocks.org) — Gratis Fortran & C/C++ IDE. Open Source en werkt op Windows, macOS & Linux.
* [Cody](https://sourcegraph.com/cody) - Gratis AI-codingassistent die kan schrijven (codeblokken, autocompletion, unittests), begrijpen (kennis van je volledige codebase), repareren en je code vinden. Beschikbaar voor VS Code, JetBrains en Online.
* [codiga.io](https://codiga.io/) — Coding Assistant waarmee je code snippets direct in je IDE kunt zoeken, definiëren en hergebruiken. Gratis voor individuele en kleine organisaties.
* [codesnip.com.br](https://codesnip.com.br) — Eenvoudige code snippets manager met categorieën, zoeken en tags. gratis en onbeperkt.
* [cocalc.com](https://cocalc.com/) — (voorheen SageMathCloud op cloud.sagemath.com) — Samen rekenen in de cloud. Browsertoegang tot volledige Ubuntu met ingebouwde samenwerking en veel gratis software voor wiskunde, wetenschap, data science, vooraf geïnstalleerd: Python, LaTeX, Jupyter Notebooks, SageMath, scikitlearn, etc.
* [code.cs50.io](https://code.cs50.io/) - Visual Studio Code voor CS50 is een webapp op code.cs50.io die GitHub Codespaces aanpast voor studenten en docenten.
* [codepen.io](https://codepen.io/) — CodePen is een playground voor de front-end kant van het web.
* [codesandbox.io](https://codesandbox.io/) — Online Playground voor React, Vue, Angular, Preact, en meer.
* [Components.studio](https://webcomponents.dev/) - Codeer componenten in isolatie, visualiseer ze in stories, test ze en publiceer ze op npm.
* [Eclipse Che](https://www.eclipse.org/che/) - Web-based en Kubernetes-native IDE voor ontwikkelteams met meertalige ondersteuning. Open Source en community-driven. Een online instantie gehost door Red Hat is beschikbaar op [workspaces.openshift.com](https://workspaces.openshift.com/).
* [fakejson.com](https://fakejson.com/) — FakeJSON helpt je snel nepdata te genereren via de API. Doe een API-aanvraag die beschrijft wat je wilt en hoe je het wilt. De API retourneert alles in JSON. Versnel het go-to-marketproces voor ideeën en fake it till you make it.
* [GetVM](https://getvm.io) — Direct gratis Linux en IDE's chrome sidebar. De gratis laag bevat 5 VM's per dag.
  * [GitPod](https://www.gitpod.io) — Direct klaar, ontwikkelomgevingen voor GitHub-projecten. De gratis laag bevat 50 uur/maand.
  * [ide.goorm.io](https://ide.goorm.io) goormIDE is een volledige IDE in de cloud. Meertalige ondersteuning, Linux-gebaseerde container via de volledig uitgeruste webterminal, port forwarding, aangepaste URL, realtime samenwerking en chat, deelbare link, Git/Subversion-ondersteuning. Er zijn veel meer functies (De gratis laag bevat 1GB RAM en 10GB opslag per container, 5 containerslots).
  * [JDoodle](https://www.jdoodle.com) — Online compiler en editor voor meer dan 60 programmeertalen met een gratis plan voor REST API code-compilatie tot 200 credits per dag.
  * [jetbrains.com](https://jetbrains.com/products.html) — Productiviteitstools, IDE's en deploymenttools (zoals [IntelliJ IDEA](https://www.jetbrains.com/idea/), [PyCharm](https://www.jetbrains.com/pycharm/), etc). Gratis licentie voor studenten, docenten, open source en gebruikersgroepen.
  * [jsbin.com](https://jsbin.com) — JS Bin is een andere playground en code-deelsite voor front-end web (HTML, CSS en JavaScript. Ondersteunt ook Markdown, Jade en Sass).
  * [jsfiddle.net](https://jsfiddle.net/) — JS Fiddle is een playground en code-deelsite voor front-end web, met ondersteuning voor samenwerking.
  * [JSONPlaceholder](https://jsonplaceholder.typicode.com/) Enkele REST API-eindpunten die nepdata in JSON-formaat retourneren. De broncode is ook beschikbaar als je de server lokaal wilt draaien.
  * [Lazarus](https://www.lazarus-ide.org/) — Lazarus is een Delphi-compatibele, cross-platform IDE voor Rapid Application Development.
  * [MarsCode](https://www.marscode.com/) - Een gratis AI-aangedreven cloud-gebaseerde IDE.
  * [micro-jaymock](https://micro-jaymock.now.sh/) - Kleine API-mocking microservice voor het genereren van nep-JSON-data.
  * [mockable.io](https://www.mockable.io/) — Mockable is een eenvoudige configureerbare service om RESTful API of SOAP-webservices te mocken. Met deze online dienst kun je snel REST API- of SOAP-eindpunten definiëren en ze JSON- of XML-data laten retourneren.
  * [mockaroo](https://mockaroo.com/) — Mockaroo laat je realistische testdata genereren in CSV-, JSON-, SQL- en Excelformaat. Je kunt ook mocks voor back-end API maken.
  * [Mocklets](https://mocklets.com) - een HTTP-gebaseerde mock API-simulator die helpt APIs te simuleren voor snellere parallelle ontwikkeling en uitgebreidere tests, met een levenslange gratis laag.
  * [Paiza](https://paiza.cloud/en/) — Ontwikkel webapps in de browser zonder iets te hoeven instellen. Gratis plan biedt één server met een levensduur van 24 uur en 4 uur draaitijd per dag met 2 CPU-cores, 2 GB RAM en 1 GB opslag.
  * [Prepros](https://prepros.io/) - Prepros kan Sass, Less, Stylus, Pug/Jade, Haml, Slim, CoffeeScript en TypeScript out of the box compileren, herlaadt je browsers en maakt het makkelijk om websites te ontwikkelen & testen zodat je je kunt richten op perfectie. Je kunt ook eigen tools toevoegen met slechts een paar klikken.
  * [Replit](https://replit.com/) — Een cloud-codingomgeving voor diverse programmeertalen.
  * [SoloLearn](https://code.sololearn.com) — Een cloud-programmeeromgeving die goed geschikt is voor het uitvoeren van codefragmenten. Ondersteunt verschillende programmeertalen. Geen registratie vereist om code uit te voeren, maar wel om code op hun platform op te slaan. Biedt ook gratis cursussen voor beginners en intermediaire programmeurs.
  * [stackblitz.com](https://stackblitz.com/) — Online/Cloud Code IDE om full-stack apps te maken, bewerken en deployen. Ondersteunt populaire NodeJs-gebaseerde frontend- & backend-frameworks. Korte link voor een nieuw project: [https://node.new](https://node.new).
  * [Sublime Text](https://www.sublimetext.com/) - Sublime Text is een populaire, veelzijdige en sterk aanpasbare teksteditor voor codering en tekstbewerkingstaken.
  * [Visual Studio Code](https://code.visualstudio.com/) - Code-editor heruitgevonden en geoptimaliseerd voor het bouwen en debuggen van moderne web- en cloudapplicaties. Ontwikkeld door Microsoft.
  * [Visual Studio Community](https://visualstudio.microsoft.com/vs/community/) — Volledig uitgeruste IDE met duizenden extensies, cross-platform app-ontwikkeling (Microsoft-extensies beschikbaar voor iOS en Android), desktop-, web- en cloudontwikkeling, meertalige ondersteuning (C#, C++, JavaScript, Python, PHP en meer).
  * [VSCodium](https://vscodium.com/) - Community-gedreven, zonder telemetrie/tracking, en vrij gelicentieerde binaire distributie van Microsoft’s editor VSCode.
  * [wakatime.com](https://wakatime.com/) — Kwantitatieve zelfstatistieken over je programmeeractiviteit met behulp van teksteditor-plugins, gelimiteerd gratis plan.
  * [Wave Terminal](https://waveterm.dev/) - Wave is een open-source, cross-platform terminal voor naadloze workflows. Render alles inline. Sla sessies en geschiedenis op. Aangedreven door open webstandaarden. MacOS en Linux.
  * [WebComponents.dev](https://webcomponents.dev/) — IDE in de browser om webcomponenten geïsoleerd te coderen met 58 beschikbare templates, ondersteuning voor stories en tests.
  * [PHPSandbox](https://phpsandbox.io/) — Online ontwikkelomgeving voor PHP.
  * [WebDB](https://webdb.app) - Gratis efficiënte database-IDE. Met serverdetectie, ERD, datagenerator, AI, NoSQL-structuurbeheer, databaseversiebeheer en veel meer.
  * [Zed](https://zed.dev/) - Zed is een high-performance, multiplayer code-editor van de makers van Atom en Tree-sitter.
  * [OneCompiler](https://onecompiler.com/) - Gratis online compiler met ondersteuning voor 70+ talen waaronder Java, Python, C++, JavaScript.


**[⬆️ Terug naar boven](#table-of-contents)**

## Analytics, Events en Statistieken

  * [Dwh.dev](https://dwh.dev) - Data Cloud Observability-oplossing (Snowflake). Gratis voor persoonlijk gebruik.
  * [Hightouch](https://hightouch.com/) - Hightouch is een Reverse ETL-platform dat helpt klantdata te synchroniseren van je datawarehouse naar je CRM-, marketing- en supporttools. De gratis laag biedt je één bestemming om data naartoe te synchroniseren.
  * [Avo](https://avo.app/) — Vereenvoudigde analytics-releaseworkflow. Single-source-of-truth trackingplan, type-veilige analyticstrackingbibliotheek, in-app debuggers en data-observeerbaarheid om alle dataproblemen te detecteren vóór release. Gratis voor twee werkruimteleden en 1 uur data-observeerbaarheid terugkijken.
  * [Branch](https://www.branch.io) — Mobiel Analyticsplatform. Gratis laag biedt tot 10K mobiele app-gebruikers met deep-linking & andere diensten.
  * [Census](https://www.getcensus.com/) — Reverse ETL & Operationeel Analyticsplatform. Synchroniseer 10 velden van je datawarehouse naar 60+ SaaS zoals Salesforce, Zendesk of Amplitude.
  * [Clicky](https://clicky.com) — Website Analyticsplatform. Gratis plan voor één website met 3000 views analytics.
  * [Databox](https://databox.com) — Business Insights & Analytics door andere analytics- & BI-platforms te combineren. Gratis plan biedt 3 gebruikers, dashboards & databronnen. 11M historische datarecords.
  * [Hitsteps.com](https://hitsteps.com/) — 2.000 pageviews per maand voor 1 website.
  * [amplitude.com](https://amplitude.com/) — 1 miljoen maandelijkse events, tot 2 apps.
  * [GoatCounter](https://www.goatcounter.com/) — GoatCounter is een open-source webanalyticsplatform beschikbaar als een gehoste dienst (gratis voor niet-commercieel gebruik) of zelfgehoste app. Het doel is gebruiksvriendelijke en privacyvriendelijke webanalytics te bieden als alternatief voor Google Analytics of Matomo. De gratis laag is voor niet-commercieel gebruik en omvat onbeperkt aantal sites, zes maanden dataretentie en 100k pageviews/maand.
  * [Google Analytics](https://analytics.google.com/) — Google Analytics
  * [MetricsWave](https://metricswave.com) — Privacyvriendelijk Google Analytics-alternatief voor ontwikkelaars. Gratis plan staat 20k pageviews per maand toe zonder creditcard.
  * [Expensify](https://www.expensify.com/) — Expense reporting, gratis persoonlijke goedkeuringsworkflow.
  * [getinsights.io](https://getinsights.io) - Privacygerichte, cookieloze analytics, gratis tot 3k events/maand.
  * [heap.io](https://heap.io) — Registreert automatisch elke gebruikersactie in iOS- of webapps. Gratis tot 10K maandelijkse sessies.
  * [Hotjar](https://hotjar.com) — Website Analytics en rapportages. Gratis plan staat 2000 pageviews/dag toe. Honderd snapshots/dag (maximale capaciteit: 300). Drie snapshot-heatmaps kunnen 365 dagen worden opgeslagen. Onbeperkt aantal teamleden. Ook in-app en standalone enquêtes, feedbackwidgets met screenshots. Gratis laag laat toe om 3 enquêtes & 3 feedbackwidgets te maken en 20 reacties per maand te verzamelen.
  * [Keen](https://keen.io/) — Custom analytics voor datacollectie, analyse en visualisatie. 1.000 events/maand gratis.
  * [Yandex.Datalens](https://datalens.yandex.com/) — Yandex Cloud data-visualisatie- en analysetool. De dienst is gratis. Geen beperkingen op aantal gebruikers of aanvragen.
  * [Yandex.Metrica](https://metrica.yandex.com/) — Onbeperkt gratis analytics.
  * [Mixpanel](https://mixpanel.com/) — 100.000 maandelijks getrackte gebruikers, onbeperkte datahistorie en seats, VS of EU dataresidentie.
  * [Moesif](https://www.moesif.com) — API-analytics voor REST en GraphQL. (Gratis tot 500.000 API-calls/maand)
  * [optimizely.com](https://www.optimizely.com) — A/B-testoplossing, gratis starterplan, één website, 1 iOS- en 1 Android-app.
  * [Microsoft PowerBI](https://powerbi.com) — Business Insights & Analytics van Microsoft. Gratis plan biedt beperkt gebruik met 1 miljoen gebruikerslicenties.
  * [Row Zero](https://rowzero.io) - Razendsnel, verbonden spreadsheet. Maak direct verbinding met databases, S3 en APIs. Importeer, analyseer, grafiek en deel miljoenen rijen direct. Drie gratis (voor altijd) werkboeken.
  * [sematext.com](https://sematext.com/cloud/) — Gratis tot 50 K acties/maand, 1 dag dataretentie, onbeperkte dashboards, gebruikers, enz.
  * [Similar Web](https://similarweb.com) — Analytics voor web- & mobiele apps. Gratis plan biedt vijf resultaten per metriek, één maand mobiele app-data & 3 maanden website-data.
  * [StatCounter](https://statcounter.com/) — Websitebezoekersanalytics. Gratis plan voor analytics van de 500 meest recente bezoekers.
  * [Statsig](https://statsig.com) - All-in-one platform voor analytics, feature flagging en A/B-testen. Gratis tot 1 miljoen gemeten events per maand.
  * [Tableau Developer Program](https://www.tableau.com/developer) — Innoveer, creëer en maak Tableau perfect voor jouw organisatie. Het gratis ontwikkelaarsprogramma geeft een persoonlijke development sandbox-licentie voor Tableau Online. De versie is de nieuwste pre-release zodat Data Devs elke functie kunnen testen.
  * [usabilityhub.com](https://usabilityhub.com/) — Test ontwerpen en mockups op echte mensen en volg bezoekers. Gratis voor één gebruiker, onbeperkt aantal tests.
  * [woopra.com](https://www.woopra.com/) — Gratis gebruikersanalyticsplatform voor 500K acties, 90 dagen dataretentie, 30+ one-click integratie.
  * [counter.dev](https://counter.dev) — Webanalytics eenvoudig gemaakt en daardoor privacyvriendelijk. Gratis of donatie-gebaseerd.
  * [PostHog](https://posthog.com) - Volledig Product Analytics-pakket gratis tot 1 miljoen getrackte events per maand. Biedt ook onbeperkte in-app enquêtes met 250 reacties per maand.
  * [Uptrace](https://uptrace.dev) - Distributed Tracing Tool die ontwikkelaars helpt fouten te vinden en prestatieproblemen te lokaliseren. Heeft een gratis plan, biedt een gratis persoonlijk abonnement voor open-sourceprojecten, en heeft een open-sourceversie.
  * [Microsoft Clarity](https://clarity.microsoft.com/) - Clarity is een gratis, eenvoudig te gebruiken tool die vastlegt hoe echte mensen je site gebruiken.
  * [Beampipe.io](https://beampipe.io) - Beampipe is eenvoudige, privacygerichte webanalytics. Gratis voor tot 5 domeinen & 10k maandelijkse pageviews.
  * [Aptabase](https://aptabase.com) — Open Source, privacyvriendelijke en eenvoudige analytics voor mobiele en desktop-apps. SDK's voor Swift, Kotlin, React Native, Flutter, Electron en vele anderen. Gratis tot 20.000 events per maand.
  * [Trackingplan](https://www.trackingplan.com/) - Detecteer automatisch digitale analytics-, marketingdata- en pixelproblemen, onderhoud actuele trackingplannen en bevorder samenwerking. Implementeer het in je productieomgeving met echt verkeer of voeg analyticsdekking toe aan je regressietests zonder te coderen.
  * [LogSpot](https://logspot.io) - Volledig verenigd web- en productanalyticsplatform, inclusief insluitbare analyticswidgets en geautomatiseerde robots (slack, telegram en webhooks). Gratis plan omvat 10.000 events per maand.
  * [Umami](https://umami.is/) - Simpel, snel, privacygericht, open-source alternatief voor Google Analytics.
  * [TrackWith Dicloud](https://dicloud.net/trackwith-privacy-focused-analytics/) - Gratis lichtgewicht privacygericht alternatief voor Google Analytics. Onbeperkt pageviews, onbeperkte bezoekers, onbeperkte page-heatmaps & doeltracking. Gratis tot 3 domeinen en 600 sessie-replays per domein.
  * [AppFit](https://appfit.io) - AppFit is een uitgebreid analytics- en productmanagementtool ontworpen voor naadloos, cross-platform beheer van analytics en productupdates. Gratis plan omvat 10.000 events per maand, productjournaal en wekelijkse inzichten.
  * [Seline](https://seline.so) - Seline is een eenvoudige & private website- en productanalytics. Cookieless, lichtgewicht, onafhankelijk. Gratis plan omvat 3.000 events per maand en biedt toegang tot alle functies zoals dashboard, gebruikersreizen, funnels en meer.
  * [Peasy](https://peasy.so) - Peasy is een lichtgewicht, privacygerichte analytics-tool voor websites en producten. Gratis plan omvat 3.000 events per maand.
  * [Rybbit](https://rybbit.io) - Open-source en cookieless alternatief voor Google Analytics dat 10x intuïtiever is. Gratis plan heeft 3.000 maandelijkse events. 

**[⬆️ Terug naar boven](#table-of-contents)**

## Bezoeker Sessie-opname

  * [Reactflow.com](https://www.reactflow.com/) — Per site: 1.000 pageviews/dag, drie heatmaps, drie widgets, gratis bugtracking
  * [OpenReplay.com](https://www.openreplay.com) - Open-source sessie-replay met devtools voor bugreproductie, live sessie voor realtime support en productanalytics-suite. Duizend sessies/maand met toegang tot alle functies en 7 dagen retentie.
  * [LogRocket.com](https://www.logrocket.com) - 1.000 sessies/maand met 30 dagen retentie, error-tracking, live-modus
  * [FullStory.com](https://www.fullstory.com) — 1.000 sessies/maand met één maand dataretentie en drie gebruikersstoelen. Meer informatie [hier](https://help.fullstory.com/hc/en-us/articles/360020623354-FullStory-Free-Edition).
  * [hotjar.com](https://www.hotjar.com/) — Per site: 1.050 pageviews/maand, onbeperkte heatmaps, data opgeslagen voor drie maanden
  * [inspectlet.com](https://www.inspectlet.com/) — 2.500 sessies/maand gratis voor één website
  * [Microsoft Clarity](https://clarity.microsoft.com/) - Sessie-opname volledig gratis met "geen verkeerslimieten", geen projectlimieten en geen sampling
  * [mouseflow.com](https://mouseflow.com/) — 500 sessies/maand gratis voor één website
  * [mousestats.com](https://www.mousestats.com/) — 100 sessies/maand gratis voor één website
  * [smartlook.com](https://www.smartlook.com/) — gratis pakketten voor web- en mobiele apps (1.500 sessies/maand), drie heatmaps, één funnel, 1 maand datahistorie
  * [howuku.com](https://howuku.com) — Volg gebruikersinteractie, betrokkenheid en events. Gratis tot 5.000 bezoeken/maand
  * [UXtweak.com](https://www.uxtweak.com/) — Neem op en bekijk hoe bezoekers je website of app gebruiken. Gratis onbeperkte tijd voor kleine projecten

**[⬆️ Terug naar boven](#table-of-contents)**
## Internationale Mobiele Nummer Verificatie API en SDK

  * [numverify](https://numverify.com/) — Wereldwijde validatie en opzoeking van telefoonnummers via een JSON API. 100 API-verzoeken/maand
  * [veriphone](https://veriphone.io/) — Wereldwijde verificatie van telefoonnummers in een gratis, snelle, betrouwbare JSON API. 1000 verzoeken/maand

**[⬆️ Terug naar boven](#table-of-contents)**

## Betalings- en Facturatie-integratie

  * [Qonversion](http://qonversion.io/) - Alles-in-één cross-platform abonnementenbeheerplatform met analytics, A/B-testen, Apple Search Ads, remote configs en groeigerei voor het optimaliseren van in-app aankopen en monetisatie. Compatibel met iOS, Android, React Native, Flutter, Unity, Cordova, Stripe en web. Gratis tot $10k aan maandelijks gevolgde omzet.
  * [ParityVend](https://www.ambeteco.com/ParityVend/) – Past automatisch prijzen aan op basis van de locatie van de bezoeker om uw bedrijf wereldwijd uit te breiden en nieuwe markten te bereiken (koopkrachtpariteit). Het gratis abonnement omvat 7.500 API-verzoeken/maand.
  * [Glassfy](https://glassfy.io/) – Infrastructuur voor in-app abonnementen, realtime abonnementsevenementen en kant-en-klare monetisatie-tools op iOS, Android, Stripe en Paddle. Gratis tot $10k maandelijkse omzet.
  * [Adapty.io](https://adapty.io/) – Alles-in-één oplossing met open-source SDK voor mobiele in-app abonnement integratie voor iOS, Android, React Native, Flutter, Unity of web-app. Gratis tot $10k maandelijkse omzet.
  * [CoinMarketCap](https://coinmarketcap.com/api/) — Biedt cryptovaluta marktdata inclusief de laatste crypto- en fiatvaluta wisselkoersen. De gratis laag biedt 10K call credits/maand.
  * [CurrencyFreaks](https://currencyfreaks.com/) — Biedt actuele en historische wisselkoersen. Gratis DEVELOPER-abonnement beschikbaar met 1000 verzoeken/maand.
  * [CoinGecko](https://www.coingecko.com/en/api) — Biedt cryptovaluta marktdata inclusief de laatste crypto wisselkoersen en historische data. De demo-API heeft een stabiele limiet van 30 calls/min en een maandelijkse limiet van 10.000 calls.
  * [CurrencyApi](https://currencyapi.net/) — Live valuta koersen voor fysieke valuta's en cryptovaluta's, geleverd in JSON en XML. De gratis laag biedt 1.250 API-verzoeken/maand.
  * [currencylayer](https://currencylayer.com/) — Betrouwbare wisselkoersen en valuta conversie voor uw bedrijf, 100 API-verzoeken/maand gratis.
  * [exchangerate-api.com](https://www.exchangerate-api.com) - Een eenvoudig te gebruiken valuta conversie JSON API. De gratis laag wordt eenmaal per dag bijgewerkt met een limiet van 1.500 verzoeken/maand.
  * [FraudLabsPRO](https://www.fraudlabspro.com) — Helpt handelaren om betalingsfraude en terugboekingen te voorkomen. Gratis Micro Plan beschikbaar met 500 queries/maand.
  * [FxRatesAPI](https://fxratesapi.com) — Biedt realtime en historische wisselkoersen. De gratis laag vereist naamsvermelding.
  * [Moesif API Monetization](https://www.moesif.com/) - Genereer inkomsten uit API's via gebruiksgebaseerde facturatie. Koppel aan Stripe, Chargebee, etc. De gratis laag biedt 30.000 events/maand.
  * [Nami ML](https://www.namiml.com/) - Compleet platform voor in-app aankopen en abonnementen op iOS en Android, inclusief no-code betaalmuren, CRM en analytics. Gratis voor alle basisfuncties voor het runnen van een IAP-bedrijf.
  * [RevenueCat](https://www.revenuecat.com/) — Gehoste backend voor in-app aankopen en abonnementen (iOS en Android). Gratis tot $2.5k/maand aan gevolgde omzet.
  * [vatlayer](https://vatlayer.com/) — Directe BTW-nummer validatie en EU BTW-tarieven API, gratis 100 API-verzoeken/maand
  * [Currencyapi](https://currencyapi.com) — Gratis valuta conversie- en wisselkoersdata API. Gratis 300 verzoeken per maand, 10 verzoeken per minuut voor privégebruik.

**[⬆️ Terug naar boven](#table-of-contents)**

## Docker Gerelateerd

  * [canister.io](https://canister.io/) — 20 gratis privé repositories voor ontwikkelaars, 30 gratis privé repositories voor teams om Docker images te bouwen en op te slaan
  * [Container Registry Service](https://container-registry.com/) - Harbor-gebaseerde Container Management Oplossing. De gratis laag biedt 1 GB opslag voor privé repositories.
  * [Docker Hub](https://hub.docker.com) — Eén gratis privé repository en onbeperkt publieke repositories om Docker images te bouwen en op te slaan
  * [Play with Docker](https://labs.play-with-docker.com/) — Een eenvoudige, interactieve, leuke speelomgeving om Docker te leren.
  * [quay.io](https://quay.io/) — Bouw en sla container images op met onbeperkt gratis publieke repositories
  * [ttl.sh](https://ttl.sh/) - Anonieme & tijdelijke Docker image registry

**[⬆️ Terug naar boven](#table-of-contents)**

## Vagrant Gerelateerd

  * [Vagrant Cloud](https://app.vagrantup.com) - HashiCorp Vagrant Cloud. Vagrant box hosting.
  * [Vagrantbox.es](https://www.vagrantbox.es/) — Een alternatief openbaar box index

**[⬆️ Terug naar boven](#table-of-contents)**

## Dev Blogsites

  * [BearBlog](https://bearblog.dev/) - Minimalistische, door Markdown aangedreven blog- en websitebouwer.
  * [Dev.to](https://dev.to/) - Waar programmeurs ideeën delen en elkaar helpen groeien.
  * [Hashnode](https://hashnode.com/) — Moeiteloze blogsoftware voor ontwikkelaars!.
  * [Medium](https://medium.com/) — Denk dieper na over wat voor jou belangrijk is.
  * [AyeDot](https://ayedot.com/) — Deel gratis je ideeën, kennis en verhalen met de wereld in de vorm van moderne multimedia miniblogs in kort formaat.

**[⬆️ Terug naar boven](#table-of-contents)**

## Reactieplatforms
  * [GraphComment](https://graphcomment.com/) - GraphComment is een reactiesplatform dat helpt een actieve community op te bouwen vanuit het publiek van de website.
  * [Utterances](https://utteranc.es/) - Een lichtgewicht reactieswidget gebouwd op GitHub issues. Gebruik GitHub issues voor blogreacties, wikipagina's en meer!
  * [Disqus](https://disqus.com/) - Disqus is een netwerkcommunityplatform dat door honderdduizenden sites over het hele web wordt gebruikt.
  * [Remarkbox](https://www.remarkbox.com/) - Open source gehost reactiesplatform, betaal wat je kunt voor "Eén moderator op een paar domeinen met volledige controle over gedrag & uiterlijk"
  * [IntenseDebate](https://intensedebate.com/) - Een uitgebreid reactiesysteem voor WordPress, Tumblr, Blogger en veel andere websiteplatforms.

**[⬆️ Terug naar boven](#table-of-contents)**

## Screenshot API's

  * [ApiFlash](https://apiflash.com) — Een screenshot API gebaseerd op AWS Lambda en Chrome. Handelt volledige pagina's af, legt timing en viewport afmetingen vast.
  * [microlink.io](https://microlink.io/) – Zet elke website om in data zoals metatag-normalisatie, fraaie link previews, scraping-mogelijkheden of screenshots als dienst. 250 verzoeken/dag elke dag gratis.
  * [ScreenshotAPI.net](https://screenshotapi.net/) - Screenshot API gebruikt een eenvoudige API-aanroep om screenshots van elke website te genereren. Gebouwd om te schalen en gehost op Google Cloud. Biedt 100 gratis screenshots per maand.
  * [screenshotlayer.com](https://screenshotlayer.com/) — Leg sterk aanpasbare snapshots van elke website vast. Gratis 100 snapshots/maand
  * [screenshotmachine.com](https://www.screenshotmachine.com/) — Leg 100 snapshots/maand vast, png, gif en jpg, inclusief volledige pagina’s, niet alleen de homepagina
  * [PhantomJsCloud](https://PhantomJsCloud.com) — Browserautomatisering en paginarendering.  Gratis laag biedt tot 500 pagina’s/dag.  Gratis laag sinds 2017.
  * [Webshrinker.com](https://webshrinker.com) — Web Shrinker biedt website screenshots en domein-intelligentie API-diensten. Gratis 100 verzoeken/maand.
  * [Screenshots](https://screenshotson.click) — Jouw API voor screenshots. Met zeer aanpasbare opties voor vastleggen. Gratis 100 screenshots/maand.

**[⬆️ Terug naar boven](#table-of-contents)**

## Flutter Gerelateerd en iOS Apps Bouwen zonder Mac

  * [FlutLab](https://flutlab.io/) - FlutLab is een moderne Flutter online IDE en de beste plek om cross-platform projecten te maken, debuggen en bouwen. Bouw iOS (zonder een Mac) en Android apps met Flutter.
  * [CodeMagic](https://codemagic.io/) - Codemagic is een volledig gehoste en beheerde CI/CD voor mobiele apps. Je kunt bouwen, testen en uitrollen met een GUI-gebaseerde CI/CD tool. De gratis laag biedt 500 gratis minuten/maand en een Mac Mini-instantie met 2.3 GHz en 8 GB RAM.
  * [FlutterFlow](https://flutterflow.io/) -  FlutterFlow is een browsergebaseerde drag-and-drop interface om mobiele apps te bouwen met Flutter.

**[⬆️ Terug naar boven](#table-of-contents)**

## Browser-gebaseerde hardware-emulatie geschreven in Javascript

  * [JsLinux](https://bellard.org/jslinux) — een echt snelle x86 virtuele machine die Linux en Windows 2k kan draaien.
  * [Jor1k](https://s-macke.github.io/jor1k/demos/main.html) —  een OpenRISC virtuele machine die Linux met netwerkondersteuning kan draaien.
  * [v86](https://copy.sh/v86) — een x86 virtuele machine die Linux en andere besturingssystemen direct in de browser kan draaien.

**[⬆️ Terug naar boven](#table-of-contents)**

## Privacybeheer
  * [Bearer](https://www.bearer.sh/) - Helpt bij het implementeren van privacy by design via audits en continue workflows zodat organisaties voldoen aan de AVG en andere regelgeving. De gratis laag is beperkt tot kleinere teams en alleen de SaaS-versie.
  * [Osano](https://www.osano.com/) - Consent management- en complianceplatform met alles van AVG-vertegenwoordiging tot cookiebanners. De gratis laag biedt basisfunctionaliteit.
  * [Iubenda](https://www.iubenda.com/) - Privacy- en cookiebeleid en consent management. De gratis laag biedt beperkte privacy- en cookiepolicy evenals cookiebanners.
  * [Cookiefirst](https://cookiefirst.com/) - Cookiebanners, auditing en meertalige consent management oplossing. De gratis laag biedt een eenmalige scan en één banner.

**[⬆️ Terug naar boven](#table-of-contents)**
* [Ketch](https://www.ketch.com/) - Tool voor toestemmingsbeheer en privacyframework. De gratis versie biedt de meeste functies met een beperkt aantal bezoekers.
* [Concord](https://www.concord.tech/) - Volledig dataprivacyplatform, inclusief toestemmingsbeheer, afhandeling van privacyverzoeken (DSARs) en datamapping. De gratis versie bevat kernfuncties voor toestemmingsbeheer en ze bieden ook een geavanceerder plan gratis aan voor geverifieerde open source-projecten.

**[⬆️ Terug naar boven](#table-of-contents)**

## Diversen

* [BackgroundStyler.com](https://backgroundstyler.com) - Maak esthetische screenshots van je code, tekst of afbeeldingen om te delen op sociale media.
* [BinShare.net](https://binshare.net) - Maak & deel code of binaries. Beschikbaar om te delen als een mooie afbeelding (bijv. voor Twitter / Facebook post) of als een link (bijv. voor chats of forums).
* [Blynk](https://blynk.io) — Een SaaS met API om IoT-apparaten te bedienen, bouwen & evalueren. Gratis Developer Plan met 5 apparaten, gratis Cloud & dataopslag. Mobiele apps zijn ook beschikbaar.
* [Bricks Note Calculator](https://free.getbricks.app/) - een notitie-app (PWA) met een krachtige ingebouwde meervoudige rekenmachine.
* [Carbon.now.sh](https://carbon.now.sh) - maak en deel codefragmenten in een esthetisch screenshot-achtig afbeeldingsformaat. Meestal gebruikt om codefragmenten op Twitter of blogposts mooi te delen/tonen.
* [Code Time](https://www.software.com/code-time) - een extensie voor tijdregistratie en codemetriek in VS Code, Atom, IntelliJ, Sublime Text en meer.
* [Codepng](https://www.codepng.app) - Maak uitstekende snapshots van je broncode om te delen op sociale media.
* [CodeToImage](https://codetoimage.com/) - Maak screenshots van code of tekst om te delen op sociale media.
* [Cronhooks](https://cronhooks.io/) - Plan eenmalige of terugkerende webhooks. Het gratis plan staat 5 ad-hoc planningen toe.
* [cron-job.org](https://cron-job.org) - Online cronjobs-service. Onbeperkt aantal jobs gratis.
* [datelist.io](https://datelist.io) - Online boekings-/afspraakplanningssysteem. Gratis tot 5 boekingen per maand, inclusief 1 agenda.
* [Domain Forward](https://domain-forward.com/) - Een eenvoudige tool om elke URL of domein door te sturen. Gratis tot 5 domeinen en 200k aanvragen per maand.
* [Elementor](https://elementor.com) — WordPress-websitebouwer. Gratis plan beschikbaar met 40+ basiswidgets.
* [Exif Editor](https://exifeditor.io/) — Bekijk, bewerk, wis, analyseer beeld-/fotometadata direct in de browser - inclusief GPS-locatie en metadata.
* [Format Express](https://www.format-express.dev) - Direct online formatteren voor JSON / XML / SQL.
* [FOSSA](https://fossa.com/) - Schaalbaar, end-to-end beheer voor third-party code, licentiecompliance en kwetsbaarheden.
* [Hook Relay](https://www.hookrelay.dev/) - Voeg webhookondersteuning toe aan je app zonder gedoe: voorgeconfigureerde wachtrijen, retries met backoff en logging. Het gratis plan heeft 100 leveringen per dag, 14 dagen retentie en 3 hook endpoints.
* [Hosting Checker](https://hostingchecker.co) - Controleer hostinginformatie zoals ASN, ISP, locatie en meer voor elk domein, website of IP-adres. Bevat ook meerdere hosting- en DNS-gerelateerde tools.
* [http2.pro](https://http2.pro) — HTTP/2-protocolgereedheidstest en client HTTP/2-ondersteuning detectie-API.
* [kandi](https://kandi.openweaver.com/) — Versnel applicatieontwikkeling: bouw aangepaste functies, use cases en complete applicaties sneller door codefragmenten en hergebruik van open source-bibliotheken.
* [Base64 decoder/encoder](https://devpal.co/base64-decode/) — Online gratis tool voor het decoderen & coderen van data.
* [newreleases.io](https://newreleases.io/) - Ontvang meldingen via e-mail, Slack, Telegram, Discord en aangepaste webhooks voor nieuwe releases van GitHub, GitLab, Bitbucket, Python PyPI, Java Maven, Node.js NPM, Node.js Yarn, Ruby Gems, PHP Packagist, .NET NuGet, Rust Cargo en Docker Hub.
* [OnlineExifViewer](https://onlineexifviewer.com/) — Bekijk EXIF-data direct online voor een foto, inclusief GPS-locatie en metadata.
* [PDFMonkey](https://www.pdfmonkey.io/) — Beheer PDF-templates in een dashboard, roep de API aan met dynamische data en download je PDF. Biedt 300 gratis documenten per maand.
* [Pika Code Screenshots](https://pika.style/templates/code-image) — Maak mooie, aanpasbare screenshots van codefragmenten en VSCode met behulp van de extensie.
* [QuickType.io](https://quicktype.io/) - Genereer snel modellen/klassen/types/interfaces en serializers uit JSON, schema en GraphQL om snel & veilig met data te werken in elke programmeertaal. Zet JSON om in mooie, typesafe code in elke taal.
* [RandomKeygen](https://randomkeygen.com/) - Een gratis mobiele-vriendelijke tool die een verscheidenheid aan willekeurig gegenereerde sleutels en wachtwoorden biedt die je kunt gebruiken om elke applicatie, dienst of apparaat te beveiligen.
* [ray.so](https://ray.so/) - Maak mooie afbeeldingen van je codefragmenten.
* [readme.com](https://readme.com/) — Mooie documentatie eenvoudig gemaakt, gratis voor Open Source.
* [redirection.io](https://redirection.io/) — SaaS-tool voor het beheren van HTTP-omleidingen voor bedrijven, marketing en SEO.
* [redirect.ing](https://redirect.ing/) - Snelle & veilige domeindoorsturing zonder servers of SSL-certificaten te beheren. Gratis plan omvat 10 hostnamen en 100.000 verzoeken per maand.
* [redirect.pizza](https://redirect.pizza/) - Beheer eenvoudig redirects met HTTPS-ondersteuning. Het gratis plan omvat 10 bronnen en 100.000 hits per maand.
* [ReqBin](https://reqbin.com/) — Online HTTP-verzoeken uitvoeren. Populaire methoden zijn GET, POST, PUT, DELETE en HEAD. Ondersteunt Headers en Token Authenticatie. Bevat een basissysteem voor het opslaan van je verzoeken.
* [Smartcar API](https://smartcar.com) - Een API voor auto's om locatie, brandstoftank, batterijstatus, kilometerteller, deuren vergrendelen/ontgrendelen, enz. op te halen.
* [snappify](https://snappify.com) - Maakt het mogelijk voor ontwikkelaars om verbluffende visuals te creëren. Van mooie codefragmenten tot volledig uitgewerkte technische presentaties. Het gratis plan omvat tot 3 snaps tegelijk met onbeperkte downloads en 5 AI-ondersteunde codeverklaringen per maand.
* [Sunrise and Sunset](https://sunrisesunset.io/api/) - Haal zonsopgang- en zonsondergangtijden op voor een opgegeven lengte- en breedtegraad.
* [superfeedr.com](https://superfeedr.com/) — Real-time PubSubHubbub-conforme feeds, export, analytics. Gratis met minder aanpassingsmogelijkheden.
* [SurveyMonkey.com](https://www.surveymonkey.com) — Maak online enquêtes. Analyseer de resultaten online. Het gratis plan staat slechts 10 vragen en 100 antwoorden per enquête toe.
* [Tiledesk](https://tiledesk.com) - Maak chatbots en conversationele apps. Breng ze omnichannel: van je website (livechatwidget) tot WhatsApp. Gratis plan met onbeperkte chatbots.
* [Versionfeeds](https://versionfeeds.com) — Aangepaste RSS-feeds voor releases van je favoriete software. Heb de nieuwste versies van je programmeertalen, bibliotheken of geliefde tools in één feed. (De eerste 3 feeds zijn gratis)
* [videoinu](https://videoinu.com) — Maak en bewerk schermopnames en andere video's online.
* [Webacus](https://webacus.dev) — Toegang tot een breed scala aan gratis ontwikkelaarstools voor coderen, decoderen en datamanipulatie.

**[⬆️ Terug naar boven](#table-of-contents)**

## Remote Desktop Tools

* [Getscreen.me](https://getscreen.me) —  Gratis voor 2 apparaten, geen limieten op het aantal en de duur van sessies
* [Apache Guacamole™](https://guacamole.apache.org/) — Open source clientloze remote desktop gateway
* [RemSupp](https://remsupp.com) — On-demand ondersteuning en permanente toegang tot apparaten (2 sessies/dag gratis)
* [RustDesk](https://rustdesk.com/) - Open source virtuele/remote desktop-infrastructuur voor iedereen!
* [AnyDesk](https://anydesk.com) —  Gratis voor 3 apparaten, geen limieten op het aantal en de duur van sessies

**[⬆️ Terug naar boven](#table-of-contents)**

## Game Development

* [itch.io](https://itch.io/game-assets) — Gratis/Betaalde assets zoals sprites, tilesets en karakterpacks.
* [Gamefresco.com](https://gamefresco.com/) — Ontdek, verzamel en deel gratis game-assets van game-artiesten wereldwijd.
* [GameDevMarket](https://gamedevmarket.net) — Gratis/Betaalde assets zoals 2D, 3D, Audio, GUI.
* [OpenGameArt](https://opengameart.org) — OpenSource-game-assets zoals muziek, geluiden, sprites en gifs.
* [CraftPix](https://craftpix.net) — Gratis/Betaalde assets zoals 2D, 3D, Audio, GUI, achtergronden, iconen, tilesets, gamekits.
* [Game Icons](https://game-icons.net/) - Gratis stijlbare SVG/PNG-iconen onder een CC-BY-licentie.
* [LoSpec](https://lospec.com/) — Online tools voor het maken van pixel art en andere restrictieve digitale kunst, veel tutorials/paletlijsten beschikbaar om uit te kiezen voor je games.
* [ArtStation](https://www.artstation.com/) - Marketplace voor gratis/betaalde 2D, 3D assets & audio, iconen, tilesets, gamekits. Kan ook worden gebruikt voor het tonen van je artportfolio.
* [Rive](https://rive.app/community/) - Community-assets evenals de mogelijkheid om je eigen game-assets te maken met het gratis plan.
* [Poly Pizza](https://poly.pizza/) - Gratis low poly 3D-assets.
* [3Dassets.one](https://3dassets.one/) - Meer dan 8.000 gratis/betaalde 3D-modellen en PBR-materialen voor het maken van texturen.
* [Kenney](https://www.kenney.nl/assets/) - Gratis (CC0 1.0 Universele licentie) 2D, 3D, Audio en UI game-assets.
* [Poliigon](https://www.poliigon.com/) - Gratis en betaalde texturen (met variabele resolutie), modellen, HDRI's en brushes. Biedt gratis plugins om te exporteren naar software zoals Blender.
* [Freesound](https://freesound.org/) - Gratis collaboratieve geluidsbibliotheek met verschillende CC-licenties.

**[⬆️ Terug naar boven](#table-of-contents)**

## Overige Gratis Bronnen

* [Wikimint Developer](https://developer.wikimint.com/p/tools.html) - Altijd gratis tools voor webontwikkelaars, waaronder CSS minify/unminify, image optimizer, image resizer, case converter, CSS validator, JavaScript compiler, HTML-editor, enz.
* [ElevateAI](https://www.elevateai.com) - Krijg tot 200 uur gratis audiotranscriptie per maand.
* [get.localhost.direct](https://get.localhost.direct) — Een betere `*.localhost.direct` Wildcard publiek CA-ondertekend SSL-certificaat voor localhost-ontwikkeling met subdomeinondersteuning.
* [Framacloud](https://degooglisons-internet.org/en/) — Een lijst met Free/Libre Open Source Software en SaaS door de Franse non-profit [Framasoft](https://framasoft.org/en/).
* [github.com — FOSS for Dev](https://github.com/tvvocold/FOSS-for-Dev) — Een hub van gratis en open source software voor ontwikkelaars.
* [GitHub Education](https://education.github.com/pack) — Verzameling van gratis diensten voor studenten. Registratie vereist.
* [Markdown Tools](https://markdowntools.com) - Tools voor het converteren van HTML, CSV's, PDF's, JSON en Excel-bestanden van en naar Markdown.
* [Microsoft 365 Developer Program](https://developer.microsoft.com/microsoft-365/dev-program) — Ontvang een gratis sandbox, tools en andere bronnen die je nodig hebt om oplossingen te bouwen voor het Microsoft 365-platform. Het abonnement is een 90-daagse [Microsoft 365 E5 Subscription](https://www.microsoft.com/microsoft-365/enterprise/e5) (Windows uitgesloten) die verlengd kan worden. Het wordt verlengd als je actief bent in ontwikkeling (gemeten via telemetriegegevens & algoritmes).
* [Pyrexp](https://pythonium.net/regex) — Gratis webgebaseerde regex-tester en visualizer voor het debuggen van reguliere expressies.
* [RedHat for Developers](https://developers.redhat.com) — Gratis toegang tot Red Hat-producten, waaronder RHEL, OpenShift, CodeReady, enz. exclusief voor ontwikkelaars. Alleen individueel plan. Gratis e-books worden ook aangeboden ter referentie.
* [smsreceivefree.com](https://smsreceivefree.com/) — Biedt gratis tijdelijke en wegwerptelefoonnummers.
* [sandbox.httpsms.com](https://sandbox.httpsms.com) — Gratis test-sms-berichten verzenden en ontvangen.
* [SimpleBackups.com](https://simplebackups.com/) — Back-upautomatiseringsservice voor servers en databases (MySQL, PostgreSQL, MongoDB) die direct in cloudopslagproviders (AWS, DigitalOcean en Backblaze) worden opgeslagen. Biedt een gratis plan voor 1 back-up.
* [SnapShooter](https://snapshooter.com/) — Back-upoplossing voor DigitalOcean, AWS, LightSail, Hetzner en Exoscale, met ondersteuning voor directe database-, bestands- en applicatieback-ups naar s3-gebaseerde opslag. Biedt een gratis plan met dagelijkse back-ups voor één resource.
* [Themeselection](https://themeselection.com/) — Geselecteerde hoogwaardige, moderne, professionele en gebruiksvriendelijke gratis admin dashboard templates,
HTML-thema's en UI-kits om sneller je applicaties te bouwen!
* [Web.Dev](https://web.dev/measure/) — Dit is een gratis tool waarmee je de prestaties van je website kunt bekijken en de SEO kunt verbeteren om een hogere ranking in zoekmachines te behalen.
  * [SmallDev.tools](https://smalldev.tools/) — Een gratis tool voor ontwikkelaars waarmee je verschillende formaten kunt coderen/decoderen, HTML/CSS/Javascript kunt minimaliseren, verfraaien, nep/testgegevenssets kunt genereren in JSON/CSV & meerdere andere formaten en nog veel meer functies. Met een plezierige interface.
  * [UseCSV by Layercode](https://layercode.com/usecsv) — Voeg CSV- en Excel-import toe aan je webapp binnen enkele minuten. Bied je gebruikers een prettige en robuuste data-importervaring. Begin gratis zonder creditcardgegevens en integreer UseCSV vandaag nog. Je kunt onbeperkt importeurs aanmaken en bestanden tot 100Mb uploaden.
  * [Buttons Generator](https://markodenic.com/tools/buttons-generator/) — 100+ knoppen die je kunt gebruiken in je project.
  * [WrapPixel](https://www.wrappixel.com/) — Download hoogwaardige gratis en premium admin-dashboard templates gemaakt met Angular, React, VueJs, NextJS en NuxtJS!
  * [Utils.fun](https://utils.fun/en) — Alle offline dagelijkse en ontwikkelingstools op basis van de rekenkracht van je browser, waaronder watermerk generatie, schermopname, coderen en decoderen, encryptie en decryptie, en code formatting, zijn volledig gratis en uploaden geen data naar de cloud voor verwerking.
  * [It tools](it-tools.tech) - Handige tools voor ontwikkelaars en mensen die in de IT werken.
  * [Free Code Tools](https://freecodetools.org/) — Effectieve codetools die 100% gratis zijn. Markdown editor, code minimalizer/verfraaier, QR-codegenerator, Open Graph Generator, Twitter card Generator en meer.
  * [regex101](https://regex101.com/) — Gratis website die je laat testen en debuggen van reguliere expressies (regex). Biedt een regex-editor en tester, evenals nuttige documentatie en bronnen om regex te leren.
  * [Kody Tools](https://www.kodytools.com/dev-tools) — 100+ dev tools waaronder formatter, minifier en converter.
  * [AdminMart](https://adminmart.com/) — Hoogwaardige gratis en premium admin-dashboard en website-templates gemaakt met Angular, Bootstrap, React, VueJs, NextJS en NuxtJS!
  * [Glob tester](https://globster.xyz/) — Een website waarmee je globpatronen kunt ontwerpen en testen. Biedt ook bronnen om globpatronen te leren.
  * [SimpleRestore](https://simplerestore.io) - Moeiteloze MySQL backup-herstel. Herstel MySQL-backups naar elke externe database zonder code of server.
  * [360Converter](https://www.360converter.com/) - Gratis website om te converteren: Video naar Tekst & Audio naar Tekst & Spraak naar Tekst & Real-time Audio naar Tekst & YouTube Video naar Tekst & video ondertiteling toevoegen. Mogelijk handig voor korte videoconversies of YouTube tutorials:)
  * [QRCodeBest](https://qrcode.best/) - Maak aangepaste QR-codes met 13 sjablonen, volledige privacy en persoonlijke branding. Functies zijn onder meer trackingpixels, projectcategorisatie en onbeperkte teamleden op QRCode.Best.
  * [PostPulse](https://PostPulseAI.com) - Verhoog je online aanwezigheid, verbeter je SEO en site-ranking met maandelijks door AI geschreven berichten op SEO-geoptimaliseerde domeinen. Het gratis plan staat toe om handmatig één bericht per maand op onze site te publiceren.
  * [PageTools](https://pagetools.co/) - Biedt een reeks altijd gratis AI-tools om essentiële websitebeleid te genereren, social media bio’s, berichten en webpagina’s te maken met een eenvoudige one-click interface.
  * [MySQL Visual Explain](https://mysqlexplain.com) - Eenvoudig te begrijpen en gratis MySQL EXPLAIN-output visualizer om trage queries te optimaliseren.
  * [Killer Coda](https://killercoda.com/)  - Interactieve playground in je browser om Linux, Kubernetes, Containers, Programmeren, DevOps en Netwerken te bestuderen.
  * [Axonomy App](https://axonomy-app.com/) - Een gratis tool om je facturen aan te maken, beheren en delen met je klanten. 10 gratis facturen per maand.
  * [Table Format Converter](https://www.tableformatconverter.com) - Een gratis tool om tabelgegevens om te zetten naar verschillende formaten, zoals CSV, HTML, JSON, Markdown en meer.


**[⬆️ Terug naar boven](#table-of-contents)**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---
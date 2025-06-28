# free-for.dev

Entwickler und Open-Source-Autoren haben mittlerweile viele Dienste mit kostenlosen Tarifen zur Verfügung, aber alle zu finden, kostet Zeit, um fundierte Entscheidungen treffen zu können.

Dies ist eine Liste von Software (SaaS, PaaS, IaaS, usw.) und anderen Angeboten mit kostenlosen Entwickler-Tarifen.

Der Umfang dieser speziellen Liste ist auf Dinge beschränkt, die für Infrastruktur-Entwickler (Systemadministratoren, DevOps-Praktiker usw.) wahrscheinlich nützlich sind. Wir lieben alle kostenlosen Dienste, aber es wäre gut, beim Thema zu bleiben. Es ist manchmal eine Grauzone, daher ist diese Liste subjektiv; bitte sei nicht beleidigt, wenn ich deinen Beitrag nicht annehme.

Diese Liste ist das Ergebnis von Pull Requests, Reviews, Ideen und Arbeit von über 1600 Menschen. Du kannst auch helfen, indem du [Pull Requests](https://github.com/ripienaar/free-for-dev) schickst, um weitere Dienste hinzuzufügen oder solche zu entfernen, deren Angebote sich geändert haben oder eingestellt wurden.

[![Track Awesome List](https://www.trackawesomelist.com/badge.svg)](https://www.trackawesomelist.com/ripienaar/free-for-dev)

**HINWEIS**: Diese Liste ist nur für as-a-Service-Angebote, nicht für selbst gehostete Software. Um berechtigt zu sein, muss ein Dienst einen kostenlosen Tarif anbieten, nicht nur eine kostenlose Testversion. Der kostenlose Tarif muss mindestens ein Jahr lang gültig sein, wenn er zeitlich begrenzt ist. Wir betrachten den kostenlosen Tarif auch aus Sicherheitssicht; SSO ist in Ordnung, aber ich akzeptiere keine Dienste, die TLS nur in kostenpflichtigen Tarifen erlauben.

# Inhaltsverzeichnis

  * [Immer-freie Limits großer Cloud-Anbieter](#major-cloud-providers)
  * [Cloud-Management-Lösungen](#cloud-management-solutions)
  * [Analytik, Events und Statistiken](#analytics-events-and-statistics)
  * [APIs, Daten und ML](#apis-data-and-ml)
  * [Artefakt-Repositories](#artifact-repos)
  * [BaaS](#baas)
  * [Low-Code-Plattform](#low-code-platform)
  * [CDN und Schutz](#cdn-and-protection)
  * [CI und CD](#ci-and-cd)
  * [CMS](#cms)
  * [Code-Generierung](#code-generation)
  * [Code-Qualität](#code-quality)
  * [Code-Suche und -Durchsicht](#code-search-and-browsing)
  * [Absturz- und Ausnahmebehandlung](#crash-and-exception-handling)
  * [Datenvisualisierung auf Karten](#data-visualization-on-maps)
  * [Verwaltete Datendienste](#managed-data-services)
  * [Design und UI](#design-and-ui)
  * [Design-Inspiration](#design-inspiration)
  * [Dev-Blogging-Seiten](#dev-blogging-sites)
  * [DNS](#dns)
  * [Docker-bezogenes](#docker-related)
  * [Domain](#domain)
  * [Bildung und Karriereentwicklung](#education-and-career-development)
  * [E-Mail](#email)
  * [Feature-Flag-Management-Plattformen](#feature-toggles-management-platforms)
  * [Schriftart](#font)
  * [Formulare](#forms)
  * [Generative KI](#generative-ai)
  * [IaaS](#iaas)
  * [IDE und Code-Editing](#ide-and-code-editing)
  * [Internationale Mobilnummern-Überprüfung API und SDK](#international-mobile-number-verification-api-and-sdk)
  * [Issue-Tracking und Projektmanagement](#issue-tracking-and-project-management)
  * [Log-Management](#log-management)
  * [Mobile App-Verteilung und Feedback](#mobile-app-distribution-and-feedback)
  * [Managementsysteme](#management-system)
  * [Messaging und Streaming](#messaging-and-streaming)
  * [Verschiedenes](#miscellaneous)
  * [Überwachung](#monitoring)
  * [PaaS](#paas)
  * [Paket-Build-System](#package-build-system)
  * [Zahlungs- und Abrechnungsintegration](#payment-and-billing-integration)
  * [Datenschutz-Management](#privacy-management)
  * [Screenshot-APIs](#screenshot-apis)
  * [Flutter-bezogenes und iOS-Apps bauen ohne Mac](#flutter-related-and-building-ios-apps-without-mac)
  * [Suche](#search)
  * [Sicherheit und PKI](#security-and-pki)
  * [Authentifizierung, Autorisierung und Benutzermanagement](#authentication-authorization-and-user-management)
  * [Quellcode-Repositories](#source-code-repos)
  * [Speicherung und Medienverarbeitung](#storage-and-media-processing)
  * [Tunneling, WebRTC, Web Socket Server und andere Router](#tunneling-webrtc-web-socket-servers-and-other-routers)
  * [Testing](#testing)
  * [Tools für Teams und Zusammenarbeit](#tools-for-teams-and-collaboration)
  * [Übersetzungsmanagement](#translation-management)
  * [Vagrant-bezogenes](#vagrant-related)
  * [Besuchersitzungsaufzeichnung](#visitor-session-recording)
  * [Webhosting](#web-hosting)
  * [Kommentierungsplattformen](#commenting-platforms)
  * [Browserbasierte Hardware-Emulation](#browser-based-hardware-emulation-written-in-javascript)
  * [Remote-Desktop-Tools](#remote-desktop-tools)
  * [Spieleentwicklung](#game-development)
  * [Weitere kostenlose Ressourcen](#other-free-resources)

## Große Cloud-Anbieter

  * [Google Cloud Platform](https://cloud.google.com)
    * App Engine – 28 Frontend-Instanzstunden pro Tag, neun Backend-Instanzstunden pro Tag
    * Cloud Firestore – 1GB Speicher, 50.000 Lesevorgänge, 20.000 Schreibvorgänge, 20.000 Löschvorgänge pro Tag
    * Compute Engine – 1 nicht-preemptible e2-micro, 30GB HDD, 5GB Snapshot-Speicher (auf bestimmte Regionen beschränkt), 1 GB ausgehender Netzwerkverkehr von Nordamerika zu allen Regionen (außer China und Australien) pro Monat
    * Cloud Storage – 5GB, 1GB ausgehender Netzwerkverkehr
    * Cloud Shell – Web-basierte Linux-Shell/primäre IDE mit 5GB persistentem Speicher. 60 Stunden Limit pro Woche
    * Cloud Pub/Sub – 10GB Nachrichten pro Monat
    * Cloud Functions – 2 Millionen Aufrufe pro Monat (einschließlich Hintergrund- und HTTP-Aufrufe)
    * Cloud Run – 2 Millionen Anfragen pro Monat, 360.000 GB-Sekunden Speicher, 180.000 vCPU-Sekunden Rechenzeit, 1 GB ausgehender Netzwerkverkehr von Nordamerika pro Monat
    * Google Kubernetes Engine – Keine Cluster-Management-Gebühr für einen Zonencluster. Jeder Benutzer-Knoten wird zum Standardpreis der Compute Engine berechnet
    * BigQuery – 1 TB Abfragen pro Monat, 10 GB Speicher jeden Monat
    * Cloud Build – 120 Build-Minuten pro Tag
    * Cloud Source Repositories – Bis zu 5 Benutzer, 50 GB Speicher, 50 GB Egress
    * [Google Colab](https://colab.research.google.com/) – Kostenlose Jupyter-Notebook-Entwicklungsumgebung.
    * [Firebase Studio](https://firebase.studio) Google Firebase Studio (früher Project IDX). Online VSCode, läuft auf Google Cloud.
    * Vollständige, detaillierte Liste – https://cloud.google.com/free

  * [Amazon Web Services](https://aws.amazon.com)
    * [CloudFront](https://aws.amazon.com/cloudfront/) – 1TB Egress pro Monat und 2 Millionen Funktionsaufrufe pro Monat
    * [CloudWatch](https://aws.amazon.com/cloudwatch/) – 10 benutzerdefinierte Metriken und zehn Alarme
* [CodeBuild](https://aws.amazon.com/codebuild/) – 100 Minuten Build-Zeit pro Monat  
* [CodeCommit](https://aws.amazon.com/codecommit/) – 5 aktive Benutzer, 50GB Speicher und 10.000 Anfragen pro Monat  
* [CodePipeline](https://aws.amazon.com/codepipeline/) – 1 aktive Pipeline pro Monat  
* [DynamoDB](https://aws.amazon.com/dynamodb/) – 25GB NoSQL Datenbank  
* [EC2](https://aws.amazon.com/ec2/) – 750 Stunden pro Monat t2.micro oder t3.micro (12 Monate). 100GB ausgehender Traffic pro Monat  
* [EBS](https://aws.amazon.com/ebs/) – 30GB pro Monat General Purpose (SSD) oder Magnetic (12 Monate)  
* [Elastic Load Balancing](https://aws.amazon.com/elasticloadbalancing/) – 750 Stunden pro Monat (12 Monate)  
* [RDS](https://aws.amazon.com/rds/) – 750 Stunden pro Monat db.t2.micro, db.t3.micro oder db.t4g.micro, 20GB General Purpose (SSD) Speicher, 20GB Speicher-Backups (12 Monate)  
* [S3](https://aws.amazon.com/s3/) – 5GB Standard Object Storage, 20.000 Get-Anfragen und 2.000 Put-Anfragen (12 Monate)  
* [Glacier](https://aws.amazon.com/glacier/) – 10GB Langzeit-Object-Speicher  
* [Lambda](https://aws.amazon.com/lambda/) – 1 Million Anfragen pro Monat  
* [SNS](https://aws.amazon.com/sns/) – 1 Million Veröffentlichungen pro Monat  
* [SES](https://aws.amazon.com/ses/) – 3.000 Nachrichten pro Monat (12 Monate)  
* [SQS](https://aws.amazon.com/sqs/) – 1 Million Messaging-Queue-Anfragen  
* Vollständige, detaillierte Liste – https://aws.amazon.com/free/

* [Microsoft Azure](https://azure.microsoft.com)
  * [Virtual Machines](https://azure.microsoft.com/services/virtual-machines/) – 1 B1S Linux VM, 1 B1S Windows VM (12 Monate)
  * [App Service](https://azure.microsoft.com/services/app-service/) – 10 Web-, Mobile- oder API-Apps (60 CPU-Minuten/Tag)
  * [Functions](https://azure.microsoft.com/services/functions/) – 1 Million Anfragen pro Monat
  * [DevTest Labs](https://azure.microsoft.com/services/devtest-lab/) – Schnelle, einfache und schlanke Dev-Test-Umgebungen ermöglichen
  * [Active Directory](https://azure.microsoft.com/services/active-directory/) – 500.000 Objekte
  * [Active Directory B2C](https://azure.microsoft.com/services/active-directory/external-identities/b2c/) – 50.000 monatlich gespeicherte Benutzer
  * [Azure DevOps](https://azure.microsoft.com/services/devops/) – 5 aktive Benutzer, unbegrenzte private Git-Repos
  * [Azure Pipelines](https://azure.microsoft.com/services/devops/pipelines/) — 10 kostenlose parallele Jobs mit unbegrenzten Minuten für Open Source für Linux, macOS und Windows
  * [Microsoft IoT Hub](https://azure.microsoft.com/services/iot-hub/) – 8.000 Nachrichten pro Tag
  * [Load Balancer](https://azure.microsoft.com/services/load-balancer/) – 1 kostenlose öffentliche load-balanced IP (VIP)
  * [Notification Hubs](https://azure.microsoft.com/services/notification-hubs/) – 1 Million Push-Benachrichtigungen
  * [Bandwidth](https://azure.microsoft.com/pricing/details/bandwidth/) – 15GB eingehend (12 Monate) & 5GB ausgehend pro Monat
  * [Cosmos DB](https://azure.microsoft.com/services/cosmos-db/) – 25GB Speicher und 1000 RUs bereitgestellter Durchsatz
  * [Static Web Apps](https://azure.microsoft.com/pricing/details/app-service/static/) — Erstellen, Bereitstellen und Hosten statischer Apps und serverloser Funktionen mit kostenlosem SSL, Authentifizierung/Autorisierung und benutzerdefinierten Domains
  * [Storage](https://azure.microsoft.com/services/storage/) – 5GB LRS File oder Blob Storage (12 Monate)
  * [Cognitive Services](https://azure.microsoft.com/services/cognitive-services/) – KI/ML-APIs (Computer Vision, Übersetzer, Gesichtserkennung, Bots usw.) mit kostenlosem Tarif inklusive begrenzter Transaktionen
  * [Cognitive Search](https://azure.microsoft.com/services/search/#features) – KI-basierter Such- und Indexierungsdienst, kostenlos für 10.000 Dokumente
  * [Azure Kubernetes Service](https://azure.microsoft.com/services/kubernetes-service/) – Verwalteter Kubernetes-Service, kostenlose Clusterverwaltung
  * [Event Grid](https://azure.microsoft.com/services/event-grid/) – 100.000 Operationen/Monat
  * Vollständige, detaillierte Liste – https://azure.microsoft.com/free/

* [Oracle Cloud](https://www.oracle.com/cloud/)
  * Compute  
     - 2 AMD-basierte Compute-VMs mit je 1/8 OCPU und 1 GB RAM  
     - 4 Arm-basierte Ampere A1 Cores und 24 GB RAM nutzbar als eine VM oder bis zu 4 VMs  
     - Instanzen werden zurückgefordert, wenn sie [als inaktiv gelten](https://docs.oracle.com/en-us/iaas/Content/FreeTier/freetier_topic-Always_Free_Resources.htm#compute__idleinstances)  
  * Block Volume – 2 Volumes, insgesamt 200 GB (für Compute verwendet)  
  * Object Storage – 10 GB  
  * Load Balancer – 1 Instanz mit 10 Mbps  
  * Datenbanken – 2 DBs, je 20 GB  
  * Monitoring – 500 Millionen Ingestionsdatenpunkte, 1 Milliarde Abrufdatenpunkte  
  * Bandbreite – 10 TB ausgehend pro Monat, Geschwindigkeit auf 50 Mbps bei x64-VM, 500 Mbps * Kernanzahl bei ARM-VM  
  * Öffentliche IP – 2 IPv4 für VMs, 1 IPv4 für Load Balancer  
  * Benachrichtigungen – 1 Million Zustelloptionen pro Monat, 1.000 versendete E-Mails pro Monat  
  * Vollständige, detaillierte Liste – https://www.oracle.com/cloud/free/

* [IBM Cloud](https://www.ibm.com/cloud/free/)
  * Cloudant Datenbank – 1 GB Datenspeicher
  * Db2 Datenbank – 100MB Datenspeicher
  * API Connect – 50.000 API-Aufrufe pro Monat
  * Availability Monitoring – 3 Millionen Datenpunkte pro Monat
  * Log Analysis – 500MB tägliches Log
  * Vollständige, detaillierte Liste – https://www.ibm.com/cloud/free/

* [Cloudflare](https://www.cloudflare.com/)
  * [Application Services](https://www.cloudflare.com/plans/) – Kostenloses DNS für eine unbegrenzte Anzahl von Domains, DDoS-Schutz, CDN mit kostenlosem SSL, Firewall-Regeln und Seitenregeln, WAF, Bot-Abwehr, Kostenloses unbegrenztes Rate-Limiting – 1 Regel pro Domain, Analytics, E-Mail-Weiterleitung
  * [Zero Trust & SASE](https://www.cloudflare.com/plans/zero-trust-services/) – Bis zu 50 Benutzer, 24 Stunden Aktivitätsprotokollierung, drei Netzwerkstandorte
  * [Cloudflare Tunnel](https://www.cloudflare.com/products/tunnel/) – Sie können lokal laufenden HTTP-Port über einen Tunnel auf eine zufällige Subdomain bei trycloudflare.com exponieren, nutzen Sie [Quick Tunnels](https://developers.cloudflare.com/cloudflare-one/connections/connect-networks/do-more-with-tunnels/trycloudflare/), kein Account erforderlich. Weitere Funktionen (TCP-Tunnel, Load Balancing, VPN) im [Zero Trust](https://www.cloudflare.com/products/zero-trust/) Free Plan.
  * [Workers](https://developers.cloudflare.com/workers/) – Serverlosen Code kostenlos auf Cloudflares globalem Netzwerk bereitstellen – 100.000 Anfragen täglich.
  * [Workers KV](https://developers.cloudflare.com/kv) – 100.000 Leseanfragen/Tag, 1.000 Schreibanfragen/Tag, 1.000 Löschanfragen/Tag, 1.000 Listenanfragen/Tag, 1 GB gespeicherte Daten
  * [R2](https://developers.cloudflare.com/r2/) – 10 GB pro Monat, 1 Million Klasse-A-Operationen/Monat, 10 Millionen Klasse-B-Operationen/Monat
  * [D1](https://developers.cloudflare.com/d1/) – 5 Millionen gelesene Zeilen pro Tag, 100.000 geschriebene Zeilen pro Tag, 1 GB Speicher
  * [Pages](https://developers.cloudflare.com/pages/) – Entwickeln und deployen Sie Ihre Web-Apps auf Cloudflares schnellem, sicherem globalen Netzwerk. 500 monatliche Builds, 100 benutzerdefinierte Domains, integriertes SSL, unbegrenzte zugängliche Sitze, unbegrenzte Preview-Deployments und Full-Stack-Fähigkeit durch Cloudflare Workers-Integration.
  * [Queues](https://developers.cloudflare.com/queues/) – 1 Million Operationen pro Monat
  * [TURN](https://developers.cloudflare.com/calls/turn/) – 1TB kostenloser (ausgehender) Traffic pro Monat.

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Cloud-Management-Lösungen

* [Brainboard](https://www.brainboard.co) – Kollaborative Lösung zum visuellen Erstellen und Verwalten von Cloud-Infrastrukturen von Anfang bis Ende.
* [Cloud 66](https://www.cloud66.com/) – Kostenlos für persönliche Projekte (inklusive einem Deploy-Server, einer statischen Seite). Cloud 66 bietet alles, was Sie benötigen, um Ihre Anwendungen auf jeder Cloud zu erstellen, bereitzustellen und zu skalieren, ohne den „Server-Kram“.
* [Pulumi](https://www.pulumi.com/) — Moderne Infrastruktur-als-Code-Plattform, die es Ihnen ermöglicht, vertraute Programmiersprachen und Tools zu verwenden, um Cloud-Infrastrukturen zu erstellen, bereitzustellen und zu verwalten.
* [terraform.io](https://www.terraform.io/) — Terraform Cloud. Kostenloses Remote-State-Management und Team-Kollaboration für bis zu 500 Ressourcen.
* [scalr.com](https://scalr.com/) – Scalr ist ein Terraform Automation and Collaboration (TACO) Produkt für bessere Kollaboration und Automatisierung bei Infrastruktur und Konfigurationen, die von Terraform verwaltet werden. Vollständige Terraform-CLI-Unterstützung, OPA-Integration und hierarchisches Konfigurationsmodell. Keine SSO-Gebühren. Alle Funktionen sind enthalten. Bis zu 50 Runs/Monat kostenlos nutzbar.
* [deployment.io](https://deployment.io) – Deployment.io hilft Entwicklern, Deployments auf AWS zu automatisieren. Im kostenlosen Tarif kann ein Entwickler (Einzelbenutzer) unbegrenzt statische Seiten, Webservices und Umgebungen deployen. Es sind 20 Job-Ausführungen pro Monat kostenlos mit Previews und Auto-Deploys enthalten.

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Quellcode-Repositories

* [Bitbucket](https://bitbucket.org/) — Unbegrenzte öffentliche und private Git-Repos für bis zu 5 Benutzer mit Pipelines für CI/CD
* [chiselapp.com](https://chiselapp.com/) — Unbegrenzte öffentliche und private Fossil-Repositories
* [codebasehq.com](https://www.codebasehq.com/) — Ein kostenloses Projekt mit 100 MB Speicherplatz und zwei Benutzern
* [Codeberg](https://codeberg.org/) — Unbegrenzte öffentliche und private Git-Repos kostenlos und für Open-Source-Projekte (mit unbegrenzten Mitwirkenden). Betrieben von [Forgejo](https://forgejo.org/). Statisches Website-Hosting mit [Codeberg Pages](https://codeberg.page/). CI/CD-Hosting mit [Codebergs CI](https://docs.codeberg.org/ci/). Übersetzungs-Hosting mit [Codeberg Translate](https://translate.codeberg.org/). Enthält Paket- und Container-Hosting, Projektmanagement und Issue-Tracking
* [GitGud](https://gitgud.io) — Unbegrenzte private und öffentliche Repositories. Für immer kostenlos. Betrieben von GitLab & Sapphire. CI/CD nicht enthalten.
* [GitHub](https://github.com/) — Unbegrenzte öffentliche Repositories und unbegrenzte private Repositories (mit unbegrenzten Mitwirkenden). Enthält CI/CD, Entwicklungsumgebung, statisches Hosting, Paket- und Container-Hosting, Projektmanagement und KI-Copilot
* [gitlab.com](https://about.gitlab.com/) — Unbegrenzte öffentliche und private Git-Repos mit bis zu 5 Mitarbeitern. Enthält CI/CD, statisches Hosting, Container-Registry, Projektmanagement und Issue-Tracking
* [framagit.org](https://framagit.org/) — Framagit ist die Software-Schmiede von Framasoft, basierend auf der Gitlab-Software, inklusive CI, statischen Seiten, Projektseiten und Issue-Tracking.
* [heptapod.net](https://foss.heptapod.net/) — Heptapod ist ein freundlicher Fork der GitLab Community Edition mit Unterstützung für Mercurial
* [ionicframework.com](https://ionicframework.com/appflow) – Repo und Tools zur Entwicklung von Anwendungen mit Ionic; beinhaltet auch ein Ionic-Repo
* [NotABug](https://notabug.org) — NotABug.org ist eine freie Code-Collaboration-Plattform für frei lizenzierte Projekte, Git-basiert
* [OSDN](https://osdn.net/) – OSDN.net ist ein kostenloser Service für Open-Source-Softwareentwickler und bietet SVN/Git/Mercurial/Bazaar/CVS-Repositories.
* [Pagure.io](https://pagure.io) — Pagure.io ist eine freie und quelloffene Softwareplattform zur Code-Zusammenarbeit für FOSS-lizenzierte Projekte, basiert auf Git.
* [perforce.com](https://www.perforce.com/products/helix-teamhub) — Kostenlos 1GB Cloud und Git-, Mercurial- oder SVN-Repositories.
* [pijul.com](https://pijul.com/) - Unbegrenztes, kostenloses und quelloffenes verteiltes Versionskontrollsystem. Das besondere Merkmal basiert auf einer fundierten Patch-Theorie, wodurch es einfach zu erlernen, zu benutzen und zu verteilen ist. Löst viele Probleme von git/hg/svn/darcs.
* [plasticscm.com](https://plasticscm.com/) — Kostenlos für Einzelpersonen, Open Source und gemeinnützige Organisationen.
* [projectlocker.com](https://projectlocker.com) — Ein kostenloses privates Projekt (Git und Subversion) mit 50 MB Speicherplatz.
* [RocketGit](https://rocketgit.com) — Repository-Hosting basierend auf Git. Unbegrenzte öffentliche und private Repositories.
* [savannah.gnu.org](https://savannah.gnu.org/) - Dient als kollaboratives Softwareentwicklungs-Managementsystem für freie Softwareprojekte (für GNU-Projekte).
* [savannah.nongnu.org](https://savannah.nongnu.org/) - Dient als kollaboratives Softwareentwicklungs-Managementsystem für freie Softwareprojekte (für Nicht-GNU-Projekte).

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## APIs, Daten und ML

* [JSONGrid](https://jsongrid.com) - Kostenloses Tool zur Visualisierung, Bearbeitung und Filterung komplexer JSON-Daten in einer schönen tabellarischen Ansicht. Speichern und Teilen von JSON-Daten per Link.
* [Zerosheets](https://zerosheets.com) - Verwandeln Sie Ihre Google Sheets-Tabellen in leistungsstarke APIs, um schnell Prototypen, Websites, Apps und mehr zu entwickeln. 500 Anfragen pro Monat kostenlos.
* [IP.City](https://ip.city) — 100 kostenlose IP-Geolokalisierungsanfragen pro Tag.
* [Abstract API](https://www.abstractapi.com) — API-Suite für verschiedene Anwendungsfälle, einschließlich IP-Geolokalisierung, Geschlechtserkennung oder E-Mail-Validierung.
* [Apify](https://www.apify.com/) — Web-Scraping- und Automatisierungsplattform, um eine API für jede Website zu erstellen und Daten zu extrahieren. Vorgefertigte Scraper, integrierte Proxys und individuelle Lösungen. Kostenloser Plan mit $5 Plattformguthaben pro Monat.
* [APITemplate.io](https://apitemplate.io) - Automatische Generierung von Bildern und PDF-Dokumenten per einfacher API oder Automatisierungstools wie Zapier & Airtable. Kein CSS/HTML erforderlich. Der kostenlose Plan enthält 50 Bilder/Monat und drei Vorlagen.
* [APIToolkit.io](https://apitoolkit.io) - Alle Werkzeuge, um Ihre APIs und Backends vollständig zu verstehen. Mit automatischer API-Vertragsvalidierung und -Überwachung. Der kostenlose Plan deckt Server mit bis zu 10.000 Anfragen pro Tag ab.
* [APIVerve](https://apiverve.com) - Sofortiger Zugriff auf über 120+ APIs kostenlos, entwickelt mit Fokus auf Qualität, Konsistenz und Zuverlässigkeit. Der kostenlose Plan umfasst bis zu 50 API-Tokens pro Monat. (Möglicherweise nicht mehr erreichbar, 2025-06-25)
* [Arize AI](https://arize.com/) - Machine Learning Observability für Modellüberwachung und Ursachenermittlung wie Datenqualität und Performance-Drift. Kostenlos für bis zu zwei Modelle.
* [Maxim AI](https://getmaxim.ai/) - Simulieren, evaluieren und überwachen Sie Ihre KI-Agenten. Maxim ist eine End-to-End-Evaluations- und Observability-Plattform, die Teams hilft, ihre KI-Agenten zuverlässig und >5x schneller bereitzustellen. Für Indie-Entwickler und kleine Teams (3 Plätze) dauerhaft kostenlos.
* [Beeceptor](https://beeceptor.com) - REST-API in Sekunden simulieren, gefälschte API-Antworten und vieles mehr. Kostenlos 50 Anfragen pro Tag, öffentliches Dashboard, offene Endpunkte (jeder mit Dashboard-Link kann Einsendungen und Antworten sehen).
* [BigDataCloud](https://www.bigdatacloud.com/) - Bietet schnelle, genaue und kostenlose (unbegrenzt oder bis zu 10K-50K/Monat) APIs für moderne Webanwendungen wie IP-Geolokalisierung, Reverse-Geocoding, Netzwerk-Insights, E-Mail- und Telefonvalidierung, Client-Info und mehr.
* [Browse AI](https://www.browse.ai) — Extrahieren und Überwachen von Webdaten. 1k Credits pro Monat kostenlos, entspricht 1k parallelen Anfragen.
* [BrowserCat](https://www.browsercat.com) - Headless Browser API für Automatisierung, Scraping, KI-Agenten-Webzugriff, Bild-/PDF-Generierung und mehr. Kostenloser Plan mit 1.000 Anfragen pro Monat.
* [Calendarific](https://calendarific.com) - Enterprise-Grade Feiertags-API-Service für über 200 Länder. Der kostenlose Plan beinhaltet 500 Aufrufe pro Monat.
* [Canopy](https://www.canopyapi.co/) - GraphQL-API für Amazon.com Produkt-, Such- und Kategoriedaten. Der kostenlose Plan umfasst 100 Aufrufe pro Monat.
* [Clarifai](https://www.clarifai.com) — Bild-API für individuelle Gesichtserkennung und -detektion. Kann KI-Modelle trainieren. Der kostenlose Plan hat 1.000 Aufrufe pro Monat.
* [Cloudmersive](https://cloudmersive.com/) — Utility-API-Plattform mit vollem Zugriff auf eine umfangreiche API-Bibliothek, darunter Dokumentenkonvertierung, Virenscan und mehr mit 600 Aufrufen/Monat, nur North America AZ, max. Dateigröße 2,5MB.
* [Colaboratory](https://colab.research.google.com) — Kostenlose webbasierte Python-Notebook-Umgebung mit Nvidia Tesla K80 GPU.
* [CometML](https://www.comet.com/site/) - Die MLOps-Plattform für Experiment-Tracking, Modellproduktionsmanagement, Modell-Registry und komplette Datenabstammung, deckt den Workflow von Training bis Produktion ab. Kostenlos für Einzelpersonen und Akademiker.
* [Commerce Layer](https://commercelayer.io) - Komponierbare Commerce-API zum Erstellen, Platzieren und Verwalten von Bestellungen aus jedem Frontend. Der Entwicklerplan erlaubt 100 Bestellungen pro Monat und bis zu 1.000 SKUs kostenlos.
* [Composio](https://composio.dev/) - Integrationsplattform für KI-Agenten und LLMs. Integriert über 200+ Tools im agentischen Internet.
* [Conversion Tools](https://conversiontools.io/) - Online-Dateikonverter für Dokumente, Bilder, Video, Audio und eBooks. REST-API verfügbar. Bibliotheken für Node.js, PHP, Python. Unterstützt Dateien bis zu 50 GB (bei kostenpflichtigen Plänen). Die kostenlose Stufe ist durch Dateigröße (20MB) und Anzahl der Konvertierungen (30/Tag, 300/Monat) begrenzt.
* [Country-State-City Microservice API](https://country-state-city.rebuscando.info/) - API und Microservice, der eine Vielzahl von Informationen zu Ländern, Regionen, Provinzen, Städten, Postleitzahlen und mehr bietet. Die kostenlose Stufe beinhaltet bis zu 100 Anfragen pro Tag.
* [Coupler](https://www.coupler.io/) - Datenintegrationstool, das zwischen Apps synchronisiert. Kann Live-Dashboards und Berichte erstellen, Werte transformieren und manipulieren sowie Einblicke sammeln und sichern. Der kostenlose Plan ist auf einen Nutzer, eine Datenverbindung, eine Datenquelle und ein Datenziel beschränkt. Außerdem ist eine manuelle Datenaktualisierung erforderlich.
* [CraftMyPDF](https://craftmypdf.com) - Automatische PDF-Generierung aus wiederverwendbaren Vorlagen mit Drag-and-Drop-Editor und einfacher API. Der kostenlose Plan enthält 100 PDFs/Monat und drei Vorlagen.
* [Crawlbase](https://crawlbase.com/) — Websites crawlen und scrapen ohne Proxies, Infrastruktur oder Browser. Captchas werden gelöst und Blockierungen verhindert. Die ersten 1000 Aufrufe sind kostenlos.
* [CurlHub](https://curlhub.io) — Proxy-Service zum Inspizieren und Debuggen von API-Aufrufen. Der kostenlose Plan umfasst 10.000 Anfragen pro Monat.
* [CurrencyScoop](https://currencyscoop.com) - Echtzeit-Währungsdaten-API für Fintech-Apps. Der kostenlose Plan umfasst 5.000 Aufrufe pro Monat.
* [Cube](https://cube.dev/) - Cube hilft Dateningenieuren und Anwendungsentwicklern, Daten aus modernen Datenspeichern zu beziehen, in konsistente Definitionen zu organisieren und in jede Anwendung zu liefern. Der schnellste Weg, Cube zu nutzen, ist Cube Cloud, das eine kostenlose Stufe mit 1.000 Abfragen pro Tag bietet.
* [Data Dead Drop](https://datadeaddrop.com) - Einfaches, kostenloses Filesharing. Daten zerstören sich nach dem Zugriff selbst. Upload und Download per Browser oder Lieblings-CLI.
* [Data Fetcher](https://datafetcher.com) - Verbinden Sie Airtable mit jeder Anwendung oder API ohne Code. Postman-ähnliche Oberfläche für API-Anfragen in Airtable. Vorgefertigte Integrationen mit Dutzenden von Apps. Der kostenlose Plan beinhaltet 100 Ausführungen pro Monat.
* [Dataimporter.io](https://www.dataimporter.io) - Tool zum Verbinden, Bereinigen und Importieren von Daten in Salesforce. Kostenloser Plan umfasst bis zu 20.000 Datensätze pro Monat.
* [Datalore](https://datalore.jetbrains.com) - Python-Notebooks von Jetbrains. Enthält 10 GB Speicher und 120 Stunden Laufzeit pro Monat.
* [Data Miner](https://dataminer.io/) - Eine Browser-Erweiterung (Google Chrome, MS Edge) für die Datenextraktion aus Webseiten in CSV oder Excel. Der kostenlose Plan bietet 500 Seiten/Monat.
* [Datapane](https://datapane.com) - API zum Erstellen interaktiver Berichte in Python und Bereitstellen von Python-Skripten und Jupyter-Notebooks als Self-Service-Tools.
* [DB-IP](https://db-ip.com/api/free) - Kostenlose IP-Geolokalisierungs-API mit 1.000 Anfragen pro IP und Tag. Lite-Datenbank unter der CC-BY 4.0 Lizenz ist ebenfalls kostenlos.
* [DB Designer](https://www.dbdesigner.net/) — Cloudbasiertes Tool zur Datenbankschema-Entwicklung und -Modellierung mit kostenlosem Starterplan für 2 Datenbankmodelle und zehn Tabellen pro Modell.
* [DeepAR](https://developer.deepar.ai) — Augmented-Reality-Gesichtsfilter für jede Plattform mit nur einem SDK. Der kostenlose Plan bietet bis zu 10 monatlich aktive Nutzer (MAU) und verfolgt bis zu 4 Gesichter.
* [Deepnote](https://deepnote.com) - Neues Data-Science-Notebook. Jupyter-kompatibel mit Echtzeit-Zusammenarbeit und Ausführung in der Cloud. Die kostenlose Stufe beinhaltet unbegrenzt persönliche Projekte, unbegrenzte Basis-Maschinen mit 5GB RAM und 2vCPU sowie Teams mit bis zu 3 Editoren.
* [Disease.sh](https://disease.sh/) — Eine kostenlose API, die genaue Daten für die Entwicklung nützlicher Covid-19-Apps bereitstellt.
* [Doczilla](https://www.doczilla.app/) — SaaS-API für die Generierung von Screenshots oder PDFs direkt aus HTML/CSS/JS-Code. Der kostenlose Plan erlaubt 250 Dokumente pro Monat.
* [Doppio](https://doppio.sh/) — Verwaltete API zur Generierung und privaten Speicherung von PDFs und Screenshots mittels modernster Rendering-Technologie. Der kostenlose Plan erlaubt 400 PDFs und Screenshots pro Monat.
* [drawDB](https://drawdb.app/) — Kostenloser und quelloffener Online-Datenbankdiagramm-Editor ohne Registrierung.
* [dreamfactory.com](https://dreamfactory.com/) — Open-Source-REST-API-Backend für mobile, Web- und IoT-Anwendungen. Beliebige SQL/NoSQL-Datenbanken, Dateispeicher oder externe Dienste anschließen und sofort eine umfassende REST-API-Plattform mit Live-Dokumentation und Benutzerverwaltung erstellen.
* [Duply.co](https://duply.co) — Dynamische Bilder aus API & URL erstellen, Design einmalig anlegen und wiederverwenden. Der kostenlose Tarif bietet 20 Gratis-Credits.
* [DynamicDocs](https://advicement.io) - PDF-Dokumente mit JSON-zu-PDF-API auf Basis von LaTeX-Vorlagen generieren. Der kostenlose Plan erlaubt 50 API-Aufrufe pro Monat und Zugriff auf eine Vorlagenbibliothek.
* [Efemarai](https://efemarai.com) - Test- und Debugging-Plattform für ML-Modelle und Daten. Visualisieren Sie beliebige Rechen-Graphen. Kostenlose lokale Nutzung.
* [ERD Lab](https://www.erdlab.io) — Kostenloses cloudbasiertes Entity-Relationship-Diagramm-Tool (ERD) für Entwickler. Kostenlose Testversion enthält 2 Projekte mit je 10 Tabellen.
* [ExtendsClass](https://extendsclass.com/rest-client-online.html) - Kostenloser webbasierter HTTP-Client zum Senden von HTTP-Anfragen.
* [Export SDK](https://exportsdk.com) - PDF-Generator-API mit Drag-and-Drop-Template-Editor, SDK und No-Code-Integrationen. Der kostenlose Plan umfasst 250 Seiten pro Monat, unbegrenzte Nutzer und drei Vorlagen.
* [file.coffee](https://file.coffee/) - Eine Plattform, auf der Sie bis zu 15MB/Datei (30MB/Datei mit Account) speichern können.
* [Financial Data](https://financialdata.net/) - Aktienmarkt- und Finanzdaten-API. Kostenloser Plan erlaubt 300 Anfragen pro Tag.
* [FormatJSONOnline.com](https://formatjsononline.com) - Kostenloses browserbasiertes Tool zum Formatieren, Validieren, Vergleichen und Minimieren von JSON-Daten in Echtzeit.
* [FraudLabs Pro](https://www.fraudlabspro.com) — Überprüfung von Bestelltransaktionen auf Kreditkartenbetrug. Diese REST-API erkennt alle möglichen Betrugsmerkmale basierend auf den Eingabeparametern einer Bestellung. Der kostenlose Micro-Plan hat 500 Transaktionen pro Monat.
* [GeoDataSource](https://www.geodatasource.com) — Standort-Suchdienst, der Städtenamen anhand von Längen- und Breitengradkoordinaten sucht. Kostenlose API bis zu 500 Anfragen pro Monat.
* [Geolocated.io](https://geolocated.io) — IP-Geolokalisierungs-API mit Multi-Kontinent-Servern, kostenloses Paket mit 2.000 Anfragen pro Tag.
* [Glitterly](https://glitterly.app/) - Programmgesteuertes Erzeugen dynamischer Bilder aus Basistemplates. Restful-API und No-Code-Integrationen. Die kostenlose Stufe umfasst 50 Bilder/Monat und fünf Vorlagen.
* [Hex](https://hex.tech/) - Kollaborative Datenplattform für Notebooks, Daten-Apps und Wissensbibliotheken. Kostenloser Community-Tarif mit bis zu fünf Projekten.
* [Hook0](https://www.hook0.com/) - Hook0 ist ein Open-Source-Webhooks-as-a-Service (WaaS), mit dem Online-Produkte einfach Webhooks bereitstellen können. Bis zu 100 Events/Tag mit sieben Tagen Historienaufbewahrung kostenlos.
* [Hoppscotch](https://hoppscotch.io) - Ein kostenloser, schneller und schöner API-Request-Builder.
* [huggingface.co](https://huggingface.co) - Entwickeln, trainieren und bereitstellen von NLP-Modellen für Pytorch, TensorFlow und JAX. Kostenlos bis 30.000 Eingabezeichen/Monat.
* [Hybiscus](https://hybiscus.dev/) - PDF-Berichte mit einer einfachen deklarativen API erstellen. Die 14-tägige kostenlose Stufe umfasst 50 einseitige Berichte mit der Möglichkeit zur Anpassung von Farbschemata und Schriftarten.
* [Invantive Cloud](https://cloud.invantive.com/) — Zugriff auf über 70 (Cloud-)Plattformen wie Exact Online, Twinfield, ActiveCampaign oder Visma über Invantive SQL oder OData4 (typisch für Power BI oder Power Query). Inklusive Datenreplikation und -austausch. Kostenloser Plan für Entwickler und Implementierungsberater. Für bestimmte Plattformen kostenlos mit Einschränkungen beim Datenvolumen.
* [ipaddress.sh](https://ipaddress.sh) — Einfacher Service, um eine öffentliche IP-Adresse in verschiedenen [Formaten](https://about.ipaddress.sh/) abzurufen.
* [ip-api](https://ip-api.com) — IP-Geolokalisierungs-API, kostenlos für nicht-kommerzielle Nutzung, kein API-Schlüssel erforderlich, begrenzt auf 45 Anfragen/Minute von derselben IP-Adresse im Gratis-Tarif.
* [ipbase.com](https://ipbase.com) - IP-Geolokalisierungs-API – Dauerhaft kostenloser Tarif mit 150 Anfragen pro Monat.
* [IP Geolocation](https://ipgeolocation.io/) — IP-Geolokalisierungs-API – Dauerhaft kostenloser Tarif für Entwickler mit 1.000 Anfragen pro Tag.
* [IP Geolocation API](https://www.abstractapi.com/ip-geolocation-api) — IP-Geolokalisierungs-API von Abstract – erlaubt 1.000 kostenlose Anfragen.
* [IPLocate](https://www.iplocate.io) — IP-Geolokalisierungs-API, kostenlos bis zu 1.000 Anfragen/Tag. Beinhaltet Proxy/VPN/Hosting-Erkennung, ASN-Daten, IP-zu-Unternehmen und mehr. IPLocate bietet auch kostenlose herunterladbare IP-zu-Land- und IP-zu-ASN-Datenbanken im CSV- oder GeoIP-kompatiblen MMDB-Format.
* [IP2Location](https://www.ip2location.com) — Freemium IP-Geolokalisierungsdienst. LITE-Datenbank ist kostenlos als Download erhältlich. Importieren Sie die Datenbank auf dem Server und führen Sie lokale Abfragen zu Stadt, Koordinaten und ISP-Informationen durch.
* [IP2Location.io](https://www.ip2location.io/) — Freemium, schnelle und zuverlässige IP-Geolokalisierungs-API. Liefert Daten wie Stadt, Koordinaten, ISP und mehr. Der kostenlose Plan beinhaltet 50.000 Credits pro Monat. IP2Location.io bietet zudem 500 kostenlose WHOIS- und gehostete Domain-Abfragen pro Monat. Siehe Domain-Registrierungsdetails und finde Domains, die auf einer bestimmten IP gehostet werden. Upgrade auf einen kostenpflichtigen Plan für weitere Funktionen.
* [ipapi](https://ipapi.co/) - IP-Adressen-Lokalisierungs-API von Kloudend, Inc – Eine zuverlässige Geolokalisierungs-API auf AWS, vertrauenswürdig von Fortune 500. Die kostenlose Stufe bietet 30.000 Suchanfragen/Monat (1.000/Tag) ohne Anmeldung.
* [ipapi.is](https://ipapi.is/) - Eine zuverlässige IP-Adress-API von Entwicklern für Entwickler mit den besten Hosting-Erkennungsfähigkeiten. Der kostenlose Plan bietet 1.000 Suchanfragen ohne Anmeldung.
* [IPinfo](https://ipinfo.io/) — Schnelle, genaue und kostenlose (bis zu 50.000/Monat) IP-Adressdaten-API. Bietet APIs mit Details zu Geolokalisierung, Unternehmen, Netzbetreibern, IP-Bereichen, Domains, Missbrauchskontakten und mehr. Alle kostenpflichtigen APIs können kostenlos getestet werden.
* [IPQuery](https://ipquery.io) — Unbegrenzte IP-API für Entwickler, keine Ratenbegrenzung oder Preise.
* [IPTrace](https://iptrace.io) — Eine extrem einfache API, die Ihrem Unternehmen zuverlässige und hilfreiche IP-Geolokalisierungsdaten mit 50.000 kostenlosen Suchanfragen pro Monat liefert.
* [JSON2Video](https://json2video.com) - Video-Editing-API zur Automatisierung von Video-Marketing und Social-Media-Videos, programmatisch oder ohne Code.
* [JSON IP](https://getjsonip.com) — Gibt die öffentliche IP-Adresse des Clients zurück, von dem die Anfrage stammt. Keine Registrierung für die kostenlose Stufe erforderlich. Dank CORS kann die Abfrage mit clientseitigem JS direkt aus dem Browser gestellt werden. Nützlich für Dienste zur Überwachung von Änderungen bei Client- und Server-IPs. Unbegrenzte Anfragen.
* [JSON Serve](https://jsonserve.com/) — Ein kostenloser Service, der Entwicklern hilft, JSON-Objekte zu speichern und diese als REST-API in ihrer App zu verwenden.
* [JSONing](https://jsoning.com/api/) — Erstellen Sie eine gefälschte REST-API aus einem JSON-Objekt, passen Sie HTTP-Statuscodes, Header und Antwortkörper an.
* [konghq.com](https://konghq.com/) — API-Marktplatz und leistungsstarke private und öffentliche API-Tools. Im kostenlosen Tarif sind einige Funktionen wie Monitoring, Alarmierung und Support eingeschränkt.
* [Kreya](https://kreya.app) — Kostenloser gRPC-GUI-Client zum Aufrufen und Testen von gRPC-APIs. Kann gRPC-APIs per Server-Reflexion importieren.
* [Lightly](https://www.lightly.ai/) — Verbessern Sie Ihre Machine-Learning-Modelle mit den richtigen Daten. Nutzen Sie Datensätze mit bis zu 1000 Samples kostenlos.
* [LoginLlama](https://loginllama.app) - Login-Sicherheits-API zur Erkennung betrügerischer und verdächtiger Logins und Benachrichtigung Ihrer Kunden. Kostenlos für 1.000 Logins pro Monat.
* [MailboxValidator](https://www.mailboxvalidator.com) — E-Mail-Überprüfungsdienst per echter Mailserververbindung zur Bestätigung gültiger E-Mails. Der kostenlose API-Plan umfasst 100 Überprüfungen pro Monat.
* [Market Data API](https://www.marketdata.app) - Bietet Echtzeit- und historische Finanzdaten zu Aktien, Optionen, Investmentfonds und mehr. Die Free-Forever-API-Stufe ermöglicht 100 tägliche API-Anfragen kostenlos.
* [Meteosource Weather API](https://www.meteosource.com/) — Globale Wetter-API für aktuelle und prognostizierte Wetterdaten. Prognosen basieren auf einer Kombination mehrerer Wettermodelle mittels Machine Learning, um eine höhere Genauigkeit zu erzielen. Der kostenlose Tarif beinhaltet 400 Anfragen pro Tag.
* [microlink.io](https://microlink.io/) – Wandelt jede Website in Daten um, wie z.B. Normalisierung von Metatags, ansprechende Linkvorschauen, Scraping-Funktionen oder Screenshots als Service. 50 Anfragen pro Tag, jeden Tag kostenlos.
* [Mindee](https://developers.mindee.com) – Mindee ist eine leistungsstarke OCR-Software und eine API-First-Plattform, die Entwicklern hilft, Workflows von Anwendungen durch Standardisierung der Dokumentenverarbeitungsebene mittels Datenerkennung für Schlüsselinformationen mit Computer Vision und Machine Learning zu automatisieren. Die kostenlose Stufe bietet 500 Seiten pro Monat.
* [Mintlify](https://mintlify.com) — Moderner Standard für API-Dokumentation. Schöne und leicht zu wartende UI-Komponenten, In-App-Suche und interaktiver Playground. Kostenlos für 1 Editor.
* [MockAPI](https://www.mockapi.io/) — MockAPI ist ein einfaches Tool, mit dem Sie APIs schnell nachbilden, benutzerdefinierte Daten generieren und Operationen über eine RESTful-Schnittstelle durchführen können. MockAPI ist als Prototyping-/Test-/Lern-Tool gedacht. Ein Projekt/2 Ressourcen pro Projekt kostenlos.
* [Mockfly](https://www.mockfly.dev/) — Mockfly ist ein zuverlässiges Entwicklungstool für API-Mocking und Feature-Flag-Management. Generieren und steuern Sie Mock-APIs schnell mit einer intuitiven Oberfläche. Die kostenlose Stufe bietet 500 Anfragen pro Tag.
* [Mocki](https://mocki.io) - Ein Tool, mit dem Sie Mock-GraphQL- und REST-APIs erstellen können, die mit einem GitHub-Repository synchronisiert werden. Einfache REST-APIs sind kostenlos entwickelbar und nutzbar, ohne Anmeldung.
* [Mocko.dev](https://mocko.dev/) — Leiten Sie Ihre API über einen Proxy, wählen Sie aus, welche Endpunkte in der Cloud gemockt werden sollen, und inspizieren Sie den Traffic – kostenlos. Beschleunigt die Entwicklung und Integrationstests.
* [Mocky](https://designer.mocky.io/) - Eine einfache Web-App zum Erzeugen benutzerdefinierter HTTP-Antworten zum Mocken von HTTP-Anfragen. Auch als [Open Source](https://github.com/julien-lafont/Mocky) verfügbar.
* [Mock N Roll](https://mpcknroll.me/) - Kostenloser Mocks-API-Service – ein leistungsstarkes Tool, um echte API-Antworten ohne Backend-Verzögerungen zu simulieren. Perfekt für Frontend-Entwickler, QA-Tester und DevOps-Teams. [repo](https://github.com/haerulmuttaqin/mocknroll-web).
* [microenv.com](https://microenv.com) —  Erstellen Sie gefälschte REST-APIs für Entwickler mit der Möglichkeit, Code und App in einem Docker-Container zu generieren.
* [Multi-Exit IP Address Checker](https://ip.alstra.ca/) —  Ein kostenloses und einfaches Tool, um Ihre Exit-IP-Adresse über mehrere Knoten hinweg zu überprüfen und zu verstehen, wie Ihre IP in verschiedenen globalen Regionen und Diensten erscheint. Nützlich zum Testen von regelbasierten DNS-Splitting-Tools wie Control D.
* [Namekit](https://namekit.app/) - KI-gestützte Domain-Entdeckung – finden Sie sofort verfügbare Domains zum Standardpreis. Kostenlose tägliche Abfragen.
* [News API](https://newsapi.org) — Durchsuchen Sie Nachrichten im Web per Code und erhalten Sie JSON-Ergebnisse. Entwickler erhalten 100 Abfragen pro Tag kostenlos. Artikel haben eine Verzögerung von 24 Stunden.
* [numlookupapi.com](https://numlookupapi.com) - Kostenlose Telefonnummernvalidierungs-API – 100 kostenlose Anfragen/Monat.
* [OCR.Space](https://ocr.space/) — Eine OCR-API analysiert Bild- und PDF-Dateien und gibt die Textergebnisse im JSON-Format zurück. 25.000 Anfragen pro Monat sind kostenlos, mit einer Dateigrößenbegrenzung von 1 MB.
* [OpenAPI3 Designer](https://openapidesigner.com/) — Visuelles Erstellen von Open API 3 Definitionen kostenlos.
* [parsehub.com](https://parsehub.com/) — Daten von dynamischen Seiten extrahieren, dynamische Websites in APIs umwandeln, fünf Projekte kostenlos.
* [Parseur](https://parseur.com) — 20 kostenlose Seiten/Monat: Daten aus PDFs, E-Mails extrahieren. KI-basiert. Vollständiger API-Zugang.
* [PDFBolt](https://pdfbolt.com) - Entwicklerorientierte PDF-Generierungs-API, die mit Fokus auf Datenschutz entwickelt wurde. Bietet Stripe-inspirierte Dokumentation und beinhaltet 500 kostenlose PDF-Konvertierungen pro Monat.
* [pdfEndpoint.com](https://pdfendpoint.com) - Konvertieren Sie HTML oder URLs mühelos per einfacher API in PDF. Hundert Konvertierungen pro Monat kostenlos.
* [PDF-API.io](https://pdf-api.io) - PDF-Automatisierungs-API, visueller Vorlageneditor oder HTML zu PDF, dynamische Datenintegration und PDF-Rendering per API. Der kostenlose Plan umfasst eine Vorlage, 100 PDFs/Monat.
* [Pixela](https://pixe.la/) - Kostenloser Daystream-Datenbankdienst. Alle Operationen erfolgen per API. Visualisierung auch mit Heatmaps und Liniendiagrammen möglich.
* [Postman](https://postman.com) — Vereinfachen Sie Workflows und erstellen Sie bessere APIs – schneller – mit Postman, einer Kollaborationsplattform für API-Entwicklung. Die Postman-App ist für immer kostenlos nutzbar. Auch die Cloud-Funktionen von Postman sind mit bestimmten Limits dauerhaft kostenlos.
* [Insomnia](https://insomnia.rest) - Open-Source-API-Client zum Entwerfen und Testen von APIs, unterstützt REST und GraphQL.
* [PrefectCloud](https://www.prefect.io/cloud/) — Eine vollständige Plattform zur Automatisierung von Datenflüssen. Der kostenlose Plan beinhaltet 5 bereitgestellte Workflows und 500 Minuten Serverless-Compute-Guthaben pro Monat.
* [Preset Cloud](https://preset.io/) - Gehosteter Apache Superset-Service. Für Teams bis zu 5 Nutzer dauerhaft kostenlos, mit unbegrenzten Dashboards und Diagrammen, No-Code-Chartbuilder und kollaborativem SQL-Editor.
* [PromptLoop](https://www.promptloop.com/) - PromptLoop bietet 10-fach einfacheres KI-Webscraping mit nahezu null Einrichtungszeit, spart über 85% Zeit gegenüber herkömmlichen Workflows und arbeitet 4x schneller als manuelle Recherche – inklusive REST-API-Endpunkt für alle Rechercheaufgaben. Die ersten 1.000 Credits sind jeden Monat kostenlos.
* [Public-Apis Github Repo](https://github.com/public-apis/public-apis) — Eine Liste kostenloser öffentlicher APIs.
* [Rapidapi](https://rapidapi.com/) - Die weltweit größte API-Plattform. Millionen Entwickler finden und verbinden sich mit Tausenden von APIs, API-Entwicklung durch unterhaltsame Challenges (mit Lösungen!) und interaktiven Beispielen.
* [RequestBin.com](https://requestbin.com) — Erstellen Sie einen kostenlosen Endpunkt, an den Sie HTTP-Anfragen senden können. Alle HTTP-Anfragen an diesen Endpunkt werden mit zugehöriger Payload und Headern aufgezeichnet, so dass Sie Empfehlungen von Webhooks und anderen Diensten beobachten können.
* [reqres.in](https://reqres.in) - Eine kostenlos gehostete REST-API, bereit, auf Ihre AJAX-Anfragen zu antworten.
* [Roboflow](https://roboflow.com) - Erstellen und deployen Sie ein benutzerdefiniertes Computer-Vision-Modell ohne Vorkenntnisse im Machine Learning. Die kostenlose Stufe beinhaltet 30 Credits pro Monat.
* [ROBOHASH](https://robohash.org/) - Webservice zum Generieren einzigartiger und cooler Bilder aus beliebigem Text.
* [Scraper's Proxy](https://scrapersproxy.com) — Einfache HTTP-Proxy-API fürs Scraping. Anonymes Scrapen ohne Sorgen um Beschränkungen, Sperren oder Captchas. Die ersten 100 erfolgreichen Scrapes pro Monat sind kostenlos, inkl. Javascript-Rendering (mehr auf Anfrage beim Support).
* [ScrapingAnt](https://scrapingant.com/) — Headless-Chrome-Scraping-API und geprüfter Proxy-Service. Javascript-Rendering, Premium-Rotations-Proxys, CAPTCHAs-Vermeidung. 10.000 kostenlose API-Credits.
* [Simplescraper](https://simplescraper.io) — Triggern Sie Ihren Webhook nach jeder Operation. Der kostenlose Plan umfasst 100 Cloud-Scrape-Credits.
* [Select Star](https://www.selectstar.com/) - Eine intelligente Data-Discovery-Plattform, die Ihre Daten automatisch analysiert und dokumentiert. Kostenloses Light-Tier mit 2 Datenquellen, bis zu 1.000 Tabellen und 25 Nutzern.
* [Sheetson](https://sheetson.com) - Wandeln Sie Google Sheets sofort in eine RESTful API um. Kostenloser Plan verfügbar, inkl. 1.000 kostenloser Zeilen pro Sheet.
* [Shipyard](https://www.shipyardapp.com) — Low-Code-Datenorchestrierungsplattform für die Cloud. Bauen Sie mit einer Mischung aus Low-Code-Vorlagen und Ihrem Code (Python, Node.js, Bash, SQL). Unser kostenloser Entwicklerplan bietet 10 Stunden Laufzeit jeden Monat für einen Nutzer – mehr als genug, um mehrere Workflows zu automatisieren.
* [Siterelic](https://siterelic.com/) - Siterelic API ermöglicht Screenshots, Website-Audits, TLS-Scan, DNS-Lookup, TTFB-Test und mehr. Der kostenlose Plan bietet 100 API-Anfragen pro Monat.
* [SerpApi](https://serpapi.com/) - Echtzeit-Suchmaschinen-Scraping-API. Gibt strukturierte JSON-Ergebnisse für Google, YouTube, Bing, Baidu, Walmart und viele andere Maschinen zurück. Der kostenlose Plan beinhaltet 100 erfolgreiche API-Aufrufe pro Monat.
* [SmartParse](https://smartparse.io) - SmartParse ist eine Datenmigrations- und CSV-zu-API-Plattform, die zeit- und kostensparende Entwickler-Tools bietet. Die kostenlose Stufe umfasst 300 Processing Units pro Monat, Browser-Uploads, Datenquarantäne, Circuit Breaker und Job Alerts.
* [Sofodata](https://www.sofodata.com/) - Erstellen Sie sichere RESTful APIs aus CSV-Dateien. Laden Sie eine CSV-Datei hoch und greifen Sie sofort per API auf die Daten zu, um die Anwendungsentwicklung zu beschleunigen. Der kostenlose Plan umfasst 2 APIs und 2.500 API-Aufrufe pro Monat. Keine Kreditkarte erforderlich.
* [Sqlable](https://sqlable.com/) - Eine Sammlung kostenloser Online-SQL-Tools, darunter ein SQL-Formatter und Validator, SQL-Regex-Tester, Fake-Daten-Generator und interaktive Datenbank-Playgrounds.
* [Stoplight](https://stoplight.io/) - SaaS für kollaboratives Entwerfen und Dokumentieren von APIs. Der kostenlose Plan bietet kostenlose Design-, Mocking- und Dokumentationstools.
* [Supportivekoala](https://supportivekoala.com/) — Ermöglicht das automatische Generieren von Bildern durch Ihre Eingabe via Vorlagen. Der kostenlose Plan erlaubt die Erstellung von bis zu 50 Bildern pro Monat.
* [Svix](https://www.svix.com/) - Webhooks as a Service. Senden Sie bis zu 50.000 Nachrichten/Monat kostenlos.
* [Tavily AI](https://tavily.com/) - API für Online-Suche und schnelle, umfassende Recherche mit der Möglichkeit zur Organisation der Rechercheergebnisse. 1.000 Anfragen/Monat im Free-Tier, keine Kreditkarte erforderlich.
* [The IP API](https://theipapi.com/) - IP-Geolocation-API mit 1.000 kostenlosen Anfragen/Tag. Liefert Informationen über den Standort einer IP-Adresse, einschließlich Land, Stadt, Region und mehr.
* [TinyMCE](https://www.tiny.cloud) - Rich-Text-Editing-API. Kernfunktionen sind für unbegrenzte Nutzung kostenlos.
* [Tomorrow.io Weather API](https://www.tomorrow.io/weather-api/) - Bietet kostenlosen Plan für Wetter-API. Liefert genaue und aktuelle Wettervorhersagen mit globaler Abdeckung, historischen Daten und Wetterüberwachungslösungen.
* [Treblle](https://www.treblle.com) - Treblle hilft Teams beim Erstellen, Veröffentlichen und Verwalten von APIs. Mit fortschrittlicher API-Log-Aggregation, Observability, Dokumentation und Debugging. Sie erhalten alle Funktionen kostenlos, aber es gibt ein Limit von bis zu 250.000 Anfragen pro Monat im Free-Tier.
* [UniRateAPI](https://unirateapi.com) – Echtzeit-Wechselkurse für 590+ Währungen und Kryptowährungen. Unbegrenzte API-Aufrufe im kostenlosen Plan, ideal für Entwickler und Finanz-Apps.
* [vatcheckapi.com](https://vatcheckapi.com) - Einfache und kostenlose USt-IdNr.-Validierungs-API. 150 kostenlose Validierungen pro Monat.
* [WeatherXu](https://weatherxu.com/) — Globale Wetterdaten, einschließlich aktueller Bedingungen, stündlicher und täglicher Vorhersagen sowie Wetterwarnungen per API. Integration von KI-Modellen und ML-Systemen zur Analyse und Kombination mehrerer Wettermodelle für verbesserte Vorhersagegenauigkeit. Kostenlose Stufe enthält 10.000 API-Anfragen/Monat.
* [Webhook Store](https://www.openwebhook.io) - Tool zum Speichern von Drittanbieter-Webhooks und Debugging auf dem lokalen Rechner (ngrok-Stil). Open Source und selbst hostbar. Kostenloser persönlicher Domain *username*.github.webhook.store, kostenlose öffentliche Domains *anything*.webhook.store.
* [WebScraping.AI](https://webscraping.ai) - Einfache Web-Scraping-API mit integriertem Parsing, Chrome-Rendering und Proxys. Zweitausend kostenlose API-Aufrufe pro Monat.
* [Weights & Biases](https://wandb.ai) — Die Entwickler-zentrierte MLOps-Plattform. Bauen Sie bessere Modelle schneller mit Experiment-Tracking, Datenversionsverwaltung und Modellmanagement. Free-Tier nur für persönliche Projekte, mit 100 GB Speicher inklusive.
* [What The Diff](https://whatthediff.ai) - KI-gestützter Code-Review-Assistent. Der kostenlose Plan ist auf 25.000 monatliche Tokens (~10 PRs) begrenzt.
* [wolfram.com](https://wolfram.com/language/) — Integrierte wissensbasierte Algorithmen in der Cloud.
* [wrapapi.com](https://wrapapi.com/) — Wandeln Sie jede Website in eine parametrisierte API um. 30.000 API-Aufrufe pro Monat.
* [Zenscrape](https://zenscrape.com/web-scraping-api) — Web-Scraping-API mit Headless-Browsern, Residential-IPs und transparenter Preisgestaltung. Tausend kostenlose API-Aufrufe/Monat und zusätzliche Credits für Studenten und gemeinnützige Organisationen.
* [Zipcodebase](https://zipcodebase.com) - Kostenlose Zip-Code-API, Zugriff auf weltweite Postleitzahlendaten. 5.000 kostenlose Anfragen/Monat.
* [Zipcodestack](https://zipcodestack.com) - Kostenlose Zip-Code-API und Postleitzahlenvalidierung. Zehntausend kostenlose Anfragen/Monat.
* [Zuplo](https://zuplo.com/) - Kostenlose API-Management-Plattform zum Entwerfen, Bauen und Bereitstellen von APIs am Edge. Fügen Sie jeder API in Minuten API-Key-Authentifizierung, Rate-Limiting, Entwicklerdokumentation und Monetarisierung hinzu. OpenAPI-nativ und vollständig programmierbar mit Webstandard-APIs & Typescript. Der kostenlose Plan bietet bis zu 10 Projekte, unbegrenzte produktive Edge-Umgebungen, 1 Mio. monatliche Anfragen und 10 GB Egress.

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Artifact Repos

* [Artifactory](https://jfrog.com/start-free/) - Ein Artefakt-Repository, das zahlreiche Paketformate wie Maven, Docker, Cargo, Helm, PyPI, CocoaPods und GitLFS unterstützt. Enthält das Paketscanning-Tool XRay und das CI/CD-Tool Pipelines (ehemals Shippable) mit einer kostenlosen Stufe von 2.000 CI/CD-Minuten pro Monat.
* [central.sonatype.org](https://central.sonatype.org) — Das Standard-Artefakt-Repository für Apache Maven, SBT und andere Build-Systeme.
* [cloudrepo.io](https://cloudrepo.io) - Cloud-basiertes, privates und öffentliches Maven- und PyPi-Repository. Kostenlos für Open-Source-Projekte.
* [cloudsmith.io](https://cloudsmith.io) — Einfacher, sicherer und zentralisierter Repository-Service für Java/Maven, RedHat, Debian, Python, Ruby, Vagrant und mehr. Kostenlose Stufe + kostenlos für Open Source.
* [jitpack.io](https://jitpack.io/) — Maven-Repository für JVM- und Android-Projekte auf GitHub, kostenlos für öffentliche Projekte.
* [packagecloud.io](https://packagecloud.io/users/new?plan=free_usage_plan) — Einfach zu nutzendes Repository-Hosting für Maven-, RPM-, DEB-, PyPi-, NPM- und RubyGem-Pakete (mit kostenlosem Tarif).
* [repsy.io](https://repsy.io) — 1 GB kostenloses privates/öffentliches Maven-Repository.
* [Gemfury](https://gemfury.com) — Private und öffentliche Artefakt-Repositories für Maven, PyPi, NPM, Go Module, Nuget, APT und RPM. Kostenlos für öffentliche Projekte.
* [paperspace](https://www.paperspace.com/) — KI-Modelle erstellen & skalieren, KI-Anwendungen entwickeln, trainieren und deployen, kostenloser Plan: öffentliche Projekte, 5 GB Speicher, Basis-Instanzen.
* [RepoForge](https://repoforge.io) - Privates cloud-gehostetes Repository für Python-, Debian-, NPM-Pakete und Docker-Registries. Kostenloser Plan für Open-Source-/öffentliche Projekte.
* [RepoFlow](https://repoflow.io) - RepoFlow vereinfacht das Paketmanagement mit Unterstützung für npm, PyPI, Docker, Go, Helm und mehr. Testen Sie es kostenlos mit 10 GB Speicher, 10 GB Bandbreite, 100 Paketen und unbegrenzten Nutzern in der Cloud oder selbst gehostet für den persönlichen Gebrauch.

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Tools for Teams and Collaboration
* [3Cols](https://3cols.com/) - Ein kostenloser cloudbasierter Code-Snippet-Manager für persönliche und kollaborative Codeverwaltung.
* [Bitwarden](https://bitwarden.com) — Der einfachste und sicherste Weg für Einzelpersonen, Teams und Unternehmen, sensible Daten zu speichern, zu teilen und zu synchronisieren.
* [Braid](https://www.braidchat.com/) — Chat-App für Teams. Kostenlos für öffentliche Gruppen, unbegrenzte Nutzer, Verlauf und Integrationen. Es gibt auch eine selbsthostbare Open-Source-Version.
* [cally.com](https://cally.com/) — Finden Sie den perfekten Zeitpunkt und das perfekte Datum für ein Meeting. Einfach zu bedienen, funktioniert für kleine und große Gruppen.
* [Calendly](https://calendly.com) — Calendly ist das Tool zum Verbinden und Planen von Meetings. Der kostenlose Plan bietet 1 Kalenderverbindung pro Nutzer und unbegrenzte Sessions. Desktop- und Mobile-Apps werden ebenfalls angeboten.
* [Discord](https://discord.com/) — Chat mit öffentlichen/privaten Räumen. Markdown-Text, Sprach-, Video- und Bildschirmfreigabe. Kostenlos für unbegrenzte Nutzer.
* [Fibo](https://fibo.dev) - Ein kostenloses Online-Tool für Scrum-Poker in Echtzeit, das es agilen Teams ermöglicht, mit unbegrenzt vielen Mitgliedern Storypoints für schnellere Planung zu schätzen.
* [Telegram](https://telegram.org/) — Telegram ist für alle, die schnelle, zuverlässige Nachrichten und Anrufe möchten. Geschäftsanwender und kleine Teams schätzen große Gruppen, Nutzernamen, Desktop-Apps und leistungsfähige Dateifreigabe.
* [DevToolLab](https://devtoollab.com) — Online-Entwicklertools mit kostenlosem Zugang zu allen Basis-Tools, automatischem Speichern eines Eintrags pro Tool, Standardverarbeitungsgeschwindigkeit und Community-Support.
* [Dubble](https://dubble.so/) — Kostenloser Step-by-Step-Guide-Creator. Erstellen Sie Screenshots, dokumentieren Sie Prozesse und arbeiten Sie mit Ihrem Team zusammen. Unterstützt auch asynchrone Bildschirmaufzeichnung.
* [Duckly](https://duckly.com/) — Sprechen und kollaborieren Sie in Echtzeit mit Ihrem Team. Pair Programming mit IDE-, Terminal-Sharing, Sprach-, Video- und Bildschirmfreigabe. Kostenlos für kleine Teams.
* [Dyte](https://dyte.io) - Das entwicklerfreundlichste Live-Video- & Audio-SDK mit kollaborativen Plugins zur Steigerung von Produktivität und Engagement. Die kostenlose Stufe beinhaltet monatlich 10.000 Minuten Live-Video/Audio-Nutzung.
* [evernote.com](https://evernote.com/) — Tool zur Organisation von Informationen. Teilen Sie Ihre Notizen und arbeiten Sie mit anderen zusammen.
* [Fibery](https://fibery.io/) — Vernetzte Arbeitsplatzplattform. Kostenlos für Einzelnutzer, bis zu 2 GB Speicherplatz.
* [flock.com](https://flock.com) — Eine schnellere Möglichkeit für Ihr Team zu kommunizieren. Kostenlose unbegrenzte Nachrichten, Kanäle, Nutzer, Apps & Integrationen
* [Gather](https://www.gather.town/) - Eine bessere Möglichkeit, sich online zu treffen. Rund um vollständig anpassbare Räume aufgebaut, macht Gather das Zusammensein mit Ihren Communities genauso einfach wie im echten Leben. Kostenlos für bis zu 10 gleichzeitige Nutzer.
* [gokanban.io](https://gokanban.io) - Syntax-basiertes, registrierungsfreies Kanban-Board für schnellen Einsatz. Kostenlos und ohne Einschränkungen.
* [flat.social](https://flat.social) - Interaktive, anpassbare Räume für Teammeetings & Social Events nach Feierabend. Unbegrenzte Meetings, kostenlos für bis zu 8 gleichzeitige Nutzer.
* [GitDailies](https://gitdailies.com) - Tägliche Berichte über die Commit- und Pull-Request-Aktivitäten Ihres Teams auf GitHub. Enthält Push-Visualizer, Peer-Recognition-System und benutzerdefinierten Alarm-Builder. Die kostenlose Stufe hat unbegrenzte Nutzer, drei Repos und drei Alarm-Konfigurationen.
* [gitter.im](https://gitter.im/) — Chat für GitHub. Unbegrenzte öffentliche und private Räume, kostenlos für Teams mit bis zu 25 Personen
* [Hackmd.io](https://hackmd.io/) - Echtzeit-Zusammenarbeit & Schreibtool für Markdown-Dokumente/-Dateien. Wie Google Docs, aber für Markdown-Dateien. Unbegrenzte Anzahl an "Notizen" kostenlos, aber die Anzahl der Kollaborateure (Einladungen) für private Notizen & Vorlagen [wird begrenzt sein](https://hackmd.io/pricing).
* [hangouts.google.com](https://hangouts.google.com/) — Ein Ort für all Ihre Unterhaltungen, kostenlos, Google-Konto erforderlich
* [HeySpace](https://hey.space) - Aufgabenmanagement-Tool mit Chat, Kalender, Zeitstrahl und Videokonferenzen. Kostenlos für bis zu 5 Nutzer.
* [helplightning.com](https://www.helplightning.com/) — Hilfe per Video mit Augmented Reality. Kostenlos ohne Analytics, Verschlüsselung, Support
* [ideascale.com](https://ideascale.com/) — Ermöglicht Kunden das Einreichen und Bewerten von Ideen, kostenlos für 25 Mitglieder in einer Community
* [Igloo](https://www.igloosoftware.com/) — Internes Portal zum Teilen von Dokumenten, Blogs, Kalendern usw. Kostenlos für bis zu 10 Nutzer.
* [Keybase](https://keybase.io/) — Keybase ist eine FOSS-Alternative zu Slack; es hält die Chats und Dateien aller sicher, von Familien bis zu Communities und Unternehmen.
* [Google Meet](https://meet.google.com/) — Nutzen Sie Google Meet für die Online-Video-Meetings Ihres Unternehmens. Meet bietet sichere, einfach beitretbare Online-Meetings.
* [/meet for Slack](https://meetslack.com) - Starten Sie Google Meetings direkt aus Slack, indem Sie /meet in einem beliebigen Kanal, einer Gruppe oder Direktnachricht verwenden. Kostenlos ohne Einschränkungen.
* [Livecycle](https://www.livecycle.io/) — Livecycle ist eine inklusive Kollaborationsplattform, die Arbeitsabläufe für funktionsübergreifende Produktteams und Open-Source-Projekte reibungslos macht.
* [Lockitbot](https://www.lockitbot.com/) — Reservieren und sperren Sie gemeinsam genutzte Ressourcen innerhalb von Slack wie Räume, Entwicklungsumgebungen, Server usw. Kostenlos für bis zu 2 Ressourcen
* [MarkUp](https://www.markup.io/) — Mit MarkUp können Sie Feedback direkt auf Ihren Websites, PDFs und Bildern sammeln.
* [Proton Pass](https://proton.me/pass) — Passwort-Manager mit eingebauten E-Mail-Aliassen, 2FA-Authenticator, Teilen und Passkeys. Verfügbar im Web, als Browser-Erweiterung, mobile App und Desktop.
* [Visual Debug](https://visualdebug.com) - Ein visuelles Feedback-Tool für bessere Kommunikation zwischen Kunde und Entwickler
* [meet.jit.si](https://meet.jit.si/) — Ein-Klick-Video-Unterhaltungen und Bildschirmfreigabe, kostenlos
* [Microsoft Teams](https://products.office.com/microsoft-teams/free) — Microsoft Teams ist ein chatbasierter digitaler Hub, der Unterhaltungen, Inhalte und Apps an einem Ort zusammenführt. Kostenlos für bis zu 500.000 Nutzer.
* [Miro](https://miro.com/) - Skalierbares, sicheres, plattformübergreifendes und unternehmensbereites Kollaborations-Whiteboard für verteilte Teams. Mit Freemium-Plan.
* [nootiz](https://www.nootiz.com/) - Das Tool, um visuelles Feedback auf jeder Website zu sammeln und zu verwalten
* [Notion](https://www.notion.so/) - Notion ist eine Notiz- und Kollaborationsanwendung mit Markdown-Unterstützung, die Aufgaben, Wikis und Datenbanken integriert. Die App wird vom Unternehmen als All-in-One-Arbeitsbereich für Notizen, Projektmanagement und Aufgabenverwaltung beschrieben. Neben plattformübergreifenden Apps ist sie über die meisten Webbrowser zugänglich.
* [Nuclino](https://www.nuclino.com) - Ein leichtgewichtiges und kollaboratives Wiki für das gesamte Wissen, Dokumente und Notizen Ihres Teams. Kostenloser Plan mit allen wesentlichen Funktionen, bis zu 50 Objekte und 5 GB Speicher.
* [OnlineInterview.io](https://onlineinterview.io/) - Kostenlose Code-Interview-Plattform mit eingebettetem Videochat, Zeichenboard und Online-Code-Editor, in dem Sie Ihren Code im Browser kompilieren und ausführen können. Sie können mit nur einem Klick einen Remote-Interviewraum erstellen.
* [Quidlo Timesheets](https://www.quidlo.com/timesheets) - Eine einfache Zeiterfassungs- und Tracking-App für Teams. Der kostenlose Plan bietet Zeitverfolgung und Berichtserstellung für bis zu 10 Nutzer.
* [PageShare.dev](https://www.pageshare.dev) - Fügt GitHub Pull Requests visuelle Review-Funktionen hinzu, ohne Websites bereitstellen zu müssen. Kostenlos für bis zu 10 Seiten pro Monat und insgesamt 100 MB Speicher.
* [Pendulums](https://pendulums.io/) - Pendulums ist ein kostenloses Zeiterfassungstool, das Sie mit einer benutzerfreundlichen Oberfläche und wertvollen Statistiken bei der besseren Verwaltung Ihrer Zeit unterstützt.
* [Pumble](https://pumble.com) - Kostenlose Team-Chat-App. Unbegrenzte Nutzer und Nachrichtenhistorie, für immer kostenlos.
* [Raindrop.io](https://raindrop.io) - Private und sichere Lesezeichen-App für macOS, Windows, Android, iOS und Web. Unbegrenzte Lesezeichen und Zusammenarbeit kostenlos.
* [element.io](https://element.io/) — Ein dezentralisiertes und Open-Source-Kommunikationstool, gebaut auf Matrix. Gruppenchats, Direktnachrichten, verschlüsselte Dateiübertragungen, Sprach- und Video-Chats sowie einfache Integration mit anderen Diensten.
* [Rocket.Chat](https://rocket.chat/) - Open-Source-Kommunikationsplattform mit Omnichannel-Funktionen, Matrix Federation, Brücke zu anderen Apps, unbegrenzte Nachrichten und vollständige Nachrichtenhistorie.
* [seafile.com](https://www.seafile.com/) — Private oder Cloud-Speicher, Dateifreigabe, Synchronisation, Diskussionen. Die Cloud-Version hat nur 1 GB
* [Sema](https://www.semasoftware.com/) - Kostenloses Entwicklerportfolio-Tool, das Beiträge über mehrere Repositorien hinweg in einem einzigen Bericht konsolidieren und erfassen kann.
* [Screen Sharing via Browser](https://screensharing.net) - Kostenloses Bildschirmfreigabe-Tool, teilen Sie Ihren Bildschirm direkt aus dem Browser mit Kollaborateuren, kein Download oder Registrierung notwendig. Kostenlos.
* [Slab](https://slab.com/) — Moderner Wissensmanagement-Service für Teams. Kostenlos für bis zu 10 Nutzer.
* [slack.com](https://slack.com/) — Kostenlos für unbegrenzte Nutzer mit einigen Funktionsbeschränkungen
* [Spectrum](https://spectrum.chat/) - Erstellen Sie öffentliche oder private Communities kostenlos.
* [StatusPile](https://www.statuspile.com/) - Eine Statusseite von Statusseiten. Können Sie die Statusseiten Ihrer Upstream-Anbieter verfolgen?
* [Stickies](https://stickies.app/) - Visuelle Kollaborations-App für Brainstorming, Content-Kuration und Notizen. Kostenlos für bis zu 3 Walls, unbegrenzte Nutzer und 1 GB Speicher.
* [Stacks](https://betterstacks.com/) - Content-Workspace mit integrierten Notizen, Links und Dateispeicher zur Navigation durch die Informationsflut. Für immer kostenloser persönlicher Plan.
* [talky.io](https://talky.io/) — Kostenloser Gruppen-Videochat. Anonym. Peer‑to‑Peer. Keine Plugins, Anmeldung oder Zahlung erforderlich
* [Teamhood](https://teamhood.com/) - Kostenloses Projekt-, Aufgaben- und Issue-Tracking-Tool. Unterstützt Kanban mit Swimlanes und vollständige Scrum-Implementierung. Integrierte Zeiterfassung. Kostenlos für fünf Nutzer und drei Projektportfolios.
* [Teamplify](https://teamplify.com) - Verbessern Sie Team-Entwicklungsprozesse mit Team Analytics und Smart Daily Standup. Enthält vollumfängliches Abwesenheitsmanagement für remote-first Teams. Kostenlos für kleine Gruppen mit bis zu 5 Nutzern.
* [Tefter](https://tefter.io) - Lesezeichen-App mit leistungsstarker Slack-Integration. Kostenlos für Open-Source-Teams.
* [TeleType](https://teletype.oorja.io/) — Teilen Sie Terminals, Voice, Code, Whiteboard und mehr. Keine Anmeldung erforderlich für Ende-zu-Ende-verschlüsselte Zusammenarbeit für Entwickler.
* [TimeCamp](https://www.timecamp.com/) - Kostenlose Zeiterfassungssoftware für unbegrenzte Nutzer. Einfache Integration mit PM-Tools wie Jira, Trello, Asana usw.
* [Huly](https://huly.io/) - All-in-One-Projektmanagement-Plattform (Alternative zu Linear, Jira, Slack, Notion, Motion) - unbegrenzte Nutzer, 10GB Speicher pro Workspace, 10GB Video(Audio)-Traffic.
* [Teamcamp](https://www.teamcamp.app) - All-in-One-Projektmanagement-Anwendung für Softwareentwicklungsunternehmen.
* [twist.com](https://twist.com) — Eine asynchron-freundliche Teamkommunikations-App, in der Unterhaltungen organisiert und thematisch bleiben. Kostenlose und unbegrenzte Pläne verfügbar. Rabatte für berechtigte Teams.
* [tldraw.com](https://tldraw.com) — Kostenloses Open-Source-Whiteboard- und Diagramm-Tool mit intelligenten Pfeilen, Snapping, Haftnotizen und SVG-Export. Mehrspielermodus für kollaboratives Bearbeiten. Auch eine kostenlose offizielle VS Code-Erweiterung ist verfügbar.
* [BookmarkOS.com](https://bookmarkos.com) - Kostenloser All-in-One-Lesezeichenmanager, Tab-Manager und Aufgabenmanager in einem anpassbaren Online-Desktop mit Ordnerkollaboration.
* [typetalk.com](https://www.typetalk.com/) — Teilen und diskutieren Sie Ideen mit Ihrem Team über Sofortnachrichten im Web oder auf dem Mobilgerät
* [Tugboat](https://tugboat.qa) - Vorschau für jeden Pull Request, automatisiert und auf Abruf. Kostenlos für alle, kostenloses Nano-Tier für Non-Profits.
* [whereby.com](https://whereby.com/) — Ein-Klick-Video-Unterhaltungen, kostenlos (früher bekannt als appear.in)
* [windmill.dev](https://windmill.dev/) - Windmill ist eine Open-Source-Entwicklerplattform zum schnellen Erstellen von produktionsreifen mehrstufigen Automatisierungen und internen Apps aus minimalen Python- und Typescript-Skripten. Als kostenloser Nutzer können Sie Mitglied von maximal drei nicht-premium Workspaces sein und diese erstellen.
* [vadoo.tv](https://vadoo.tv/) — Videohosting und -marketing einfach gemacht. Laden Sie Videos mit einem Klick hoch. Aufnehmen, verwalten, teilen & mehr. Die kostenlose Stufe bietet bis zu 10 Videos, 1 GB Speicher und 10 GB Bandbreite/Monat
* [userforge.com](https://userforge.com/) - Vernetzte Online-Personas, User Stories und Kontext-Mapping. Hilft Design und Entwicklung im Einklang zu halten, kostenlos für bis zu 3 Personas und zwei Kollaborateure.
* [wistia.com](https://wistia.com/) — Videohosting mit Zuschauer-Analytics, HD-Videoauslieferung und Marketing-Tools zur Besucheranalyse, 25 Videos und Wistia-gebrandeter Player
* [wormhol.org](https://www.wormhol.org/) — Einfacher File-Sharing-Service. Teilen Sie unbegrenzt viele Dateien bis zu 5GB mit beliebig vielen Partnern.
* [Wormhole](https://wormhole.app/) - Teilen Sie Dateien bis zu 5 GB mit Ende-zu-Ende-Verschlüsselung für bis zu 24 Stunden. Bei größeren Dateien erfolgt die Übertragung peer-to-peer direkt.
* [zoom.us](https://zoom.us/) — Sichere Video- und Webkonferenzen, Add-ons verfügbar. Der kostenlose Plan ist auf 40 Minuten begrenzt.
* [Zulip](https://zulip.com/) — Echtzeit-Chat mit einzigartigem, E-Mail-ähnlichem Thread-Modell. Der kostenlose Plan beinhaltet 10.000 Nachrichten Suchverlauf und Dateispeicher bis zu 5 GB. Außerdem gibt es eine selbsthostbare Open-Source-Version.
* [robocorp.com](https://robocorp.com) - Open-Source-Stack für Automation Ops. Testen Sie Cloud-Funktionen und implementieren Sie einfache Automatisierungen kostenlos. Roboterarbeit 240 min/Monat, 10 Assistant-Durchläufe, 100 MB Speicher.
* [Fleep.io](https://fleep.io/) — Fleep, eine Alternative zu Slack. Es gibt einen kostenlosen Plan für kleine Teams mit voller Nachrichtenhistorie, unbegrenzten 1:1-Unterhaltungen, 1 Gruppenkonversation und 1 GB Dateispeicher.
* [Chanty.com](https://chanty.com/) — Chanty ist eine weitere Alternative zu Slack. Es gibt einen für immer kostenlosen Plan für kleine Teams (bis zu 10) mit unbegrenzten öffentlichen und privaten Unterhaltungen, durchsuchbarer Historie, unbegrenzten 1:1-Audioanrufen, unbegrenzten Sprachnachrichten, zehn Integrationen und 20 GB Speicher pro Team.
* [ruttl.com](https://ruttl.com/) — Das beste All-in-One-Feedback-Tool, um digitales Feedback zu sammeln und Websites, PDFs und Bilder zu überprüfen.
* [Mattermost](https://mattermost.com/) — Sichere Zusammenarbeit für technische Teams. Kostenloser Plan mit unbegrenzten Kanälen, Playbooks, Boards, Nutzern, 10GB Speicher und mehr.
* [Webvizio](https://webvizio.com) — Website-Feedback-Tool, Website-Review-Software und Bug-Reporting-Tool zur Optimierung der Webentwicklungskollaboration direkt auf Live-Websites und Web-Apps, Bildern, PDFs und Design-Dateien.
* [Pullflow](https://pullflow.com) — Pullflow bietet eine KI-gestützte Plattform für Code-Review-Kollaboration über GitHub, Slack und VS Code.
* [Webex](https://www.webex.com/) — Videomeetings mit kostenlosem Plan, der 40 Minuten pro Meeting mit 100 Teilnehmern bietet.
* [RingCentral](https://www.ringcentral.com/) — Videomeetings mit kostenlosem Plan, der 50 Minuten pro Meeting mit 100 Teilnehmern bietet.
* [GitBook](https://www.gitbook.com/) — Plattform zur Erfassung und Dokumentation technischen Wissens — von Produktdokumentation bis zu internen Wissensdatenbanken und APIs. Kostenloser Plan für einzelne Entwickler.
* [transfernow](https://www.transfernow.net/) — Die einfachste, schnellste und sicherste Oberfläche zum Übertragen und Teilen von Dateien. Senden Sie Fotos, Videos und andere große Dateien ohne verpflichtendes Abonnement.
* [paste.sh](https://paste.sh/) — Dies ist eine einfache Paste-Site, die auf JavaScript und Crypto basiert.
* [Revolt.chat](https://revolt.chat/) — Eine Open-Source-Alternative zu [Discord](https://discord.com/), die Ihre Privatsphäre respektiert. Sie bietet die meisten proprietären Discord-Funktionen kostenlos. Revolt ist eine All-in-One-Anwendung, die sicher und schnell ist und zu 100% kostenlos ist. Alle Funktionen sind kostenlos. Es gibt (offizielle & inoffizielle) Plugin-Unterstützung, anders als bei den meisten Mainstream-Chat-Apps.
* [Tencent RTC](https://trtc.io/) — Tencent Real-Time Communication (TRTC) bietet Lösungen für Gruppen-Audio/Videoanrufe. 10.000 Freiminuten/Monat im ersten Jahr.
* [Pastefy](https://pastefy.app/) - Schöner und einfacher Pastebin mit optionaler Client-Verschlüsselung, Multitab-Pastes, API, hervorgehobenem Editor und mehr.
* [SiteDots](https://sitedots.com/) - Teilen Sie Feedback für Website-Projekte direkt auf Ihrer Website, keine Emulation, kein Canvas oder Workarounds. Völlig funktionsfähige kostenlose Stufe.

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## CMS

* [acquia.com](https://www.acquia.com/) — Hosting für Drupal-Seiten. Kostenlose Stufe für Entwickler. Kostenlose Entwicklungstools (wie Acquia Dev Desktop) sind ebenfalls verfügbar.
* [Contentful](https://www.contentful.com/) — Headless CMS. Content-Management- und Delivery-APIs in der Cloud. Enthält einen kostenlosen Community-Bereich mit fünf Nutzern, 25.000 Datensätzen, 48 Content-Typen, 2 Sprachversionen.
* [Cosmic](https://www.cosmicjs.com/) — Headless CMS und API-Toolkit. Kostenlose persönliche Pläne für Entwickler.
* [Crystallize](https://crystallize.com) — Headless PIM mit E-Commerce-Unterstützung. Integrierte GraphQL-API. Die kostenlose Version umfasst unbegrenzte Nutzer, 1000 Katalogartikel, 5 GB/Monat Bandbreite und 25k/Monat API-Aufrufe.
* [DatoCMS](https://www.datocms.com/) - Bietet kostenlose Stufe für kleine Projekte. DatoCMS ist ein GraphQL-basiertes CMS. In der kleineren Stufe gibt es 100k/Monat-Aufrufe.
* [Directus](https://directus.io) — Headless CMS. Eine vollständig kostenlose und Open-Source-Plattform zur Verwaltung von Assets und Datenbankinhalten on-premise oder in der Cloud. Es gibt keine Einschränkungen oder Bezahlschranken.
* [FrontAid](https://frontaid.io/) — Headless CMS, das JSON-Inhalte direkt in Ihrem Git-Repository speichert. Keine Einschränkungen.
* [kontent.ai](https://www.kontent.ai) - Eine Content-as-a-Service-Plattform, die alle Vorteile eines Headless CMS bietet und gleichzeitig Marketer stärkt. Der Entwicklerplan bietet zwei Nutzer mit unbegrenzten Projekten und zwei Umgebungen pro Projekt, 500 Content-Items, zwei Sprachen mit Delivery- und Management-API sowie Unterstützung für benutzerdefinierte Elemente. Es gibt detailliertere Pläne, um Ihren Bedarf zu decken.
* [Prismic](https://www.prismic.io/) — Headless CMS. Content-Management-Interface mit vollständig gehosteter und skalierbarer API. Der Community-Plan bietet unbegrenzte API-Aufrufe, Dokumente, benutzerdefinierte Typen, Assets und Sprachen für einen Nutzer. Alles, was Sie für Ihr nächstes Projekt brauchen. Größere kostenlose Pläne für Open Content/Open Source-Projekte verfügbar.
* [Sanity.io](https://www.sanity.io/) - Plattform für strukturierte Inhalte mit Open-Source-Editor und Echtzeit gehostetem Datenspeicher. Unbegrenzte Projekte. Unbegrenzte Admin-Nutzer, drei Nicht-Admin-Nutzer, zwei Datasets, 500K API-CDN-Anfragen, 10GB Bandbreite und 5GB Assets pro Projekt kostenlos enthalten.
* [sensenet](https://sensenet.com) - API-First Headless CMS mit Enterprise-Lösungen für Unternehmen jeder Größe. Der Entwicklerplan bietet drei Nutzer, 500 Content-Items, drei integrierte Rollen, 25+5 Content-Typen, vollständig zugängliche REST-API, Dokumentenvorschau-Generierung und Office-Online-Bearbeitung.
* [TinaCMS](https://tina.io/) — Ersatz für Forestry.io. Open Source Git-gestütztes Headless CMS, das Markdown, MDX und JSON unterstützt. Das Basispaket ist kostenlos mit zwei verfügbaren Nutzern.
* [GatsbyjsCMS](https://www.gatsbyjs.com/) - Gatsby ist das schnelle und flexible Framework, das den Bau von Websites mit jedem CMS, jeder API oder Datenbank wieder spaßig macht. Erstellen und deployen Sie Headless-Websites, die mehr Traffic bringen, besser konvertieren und mehr Umsatz generieren!
* [Hygraph](https://hygraph.com/) - Bietet kostenlose Stufe für kleine Projekte. GraphQL-First API. Wechseln Sie von Legacy-Lösungen zum GraphQL-nativen Headless CMS und liefern Sie Omnichannel-Content API-First.
* [Squidex](https://squidex.io/) – Bietet eine kostenlose Stufe für kleine Projekte. API / GraphQL first. Open Source und basiert auf Event Sourcing (versioniert jede Änderung automatisch).
* [InstaWP](https://instawp.com/) – Starte eine WordPress-Seite in wenigen Sekunden. Kostenloses Kontingent mit 5 aktiven Seiten, 500 MB Speicherplatz, 48 Std. Ablaufzeit pro Seite.
* [Storyblok](https://www.storyblok.com) – Ein Headless CMS für Entwickler und Marketer, das mit allen modernen Frameworks funktioniert. Die Community (kostenlose) Stufe bietet Management API, visuellen Editor, zehn Quellen, benutzerdefinierte Feldtypen, Internationalisierung (unbegrenzte Sprachen/Regionen), Asset-Manager (bis zu 2500 Assets), Bildoptimierungsdienst, Suchabfragen, Webhook + 250GB Traffic/Monat inklusive.
* [WPJack](https://wpjack.com) – Richte WordPress auf jeder Cloud in weniger als 5 Minuten ein! Die kostenlose Stufe umfasst 1 Server, 2 Seiten, kostenlose SSL-Zertifikate und unbegrenzte Cronjobs. Keine Zeitlimits oder Verfallsdaten – deine Website, dein Weg.

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Codegenerierung

* [Appinvento](https://appinvento.io/) — AppInvento ist ein kostenloser No-Code-App-Builder. Im automatisch generierten Backend-Code haben Benutzer vollständigen Zugriff auf den Quellcode sowie unbegrenzte APIs und Routen, was umfangreiche Integrationen ermöglicht. Der kostenlose Plan beinhaltet drei Projekte, fünf Tabellen und ein Google-Add-on.
* [Cody AI](https://sourcegraph.com/cody) – Cody ist ein AI-Coding-Assistent, der KI und ein tiefes Verständnis deines Codebase nutzt, um dir beim schnelleren Schreiben und Verstehen von Code zu helfen. Cody gibt Entwicklern die Wahl zwischen verschiedenen LLMs (einschließlich lokaler Inferenz), unterstützt verschiedene IDEs, alle gängigen Programmiersprachen und bietet einen kostenlosen Plan. Der Gratis-Plan bietet Entwicklern 20 Chat-Nachrichten (mit Claude 3 Sonnet als LLM) und 500 Autovervollständigungen (mit Starcoder 16b) pro Monat.
* [DhiWise](https://www.dhiwise.com/) — Wandelt Figma-Designs nahtlos in dynamische Flutter- & React-Anwendungen um, dank innovativer Codegenerierungstechnologie von DhiWise. Optimiert deinen Workflow und hilft, außergewöhnliche Mobile- und Web-Erlebnisse schneller zu erstellen.
* [Codeium](https://www.codeium.com/) — Codeium ist ein kostenloses, KI-gestütztes Code-Completion-Tool. Unterstützt über 20+ Programmiersprachen (Python, JavaScript, Java, TypeScript, PHP, C/C++, Go, usw.) und lässt sich in alle wichtigen Standalone- und Web-IDEs integrieren.
* [Fern](https://buildwithfern.com) – Schreibe API-Definitionen und verwende sie zur Generierung von SDKs/Client-Bibliotheken in beliebten Sprachen wie TypeScript, Python, Java, Go und mehr. OpenAPI vollständig unterstützt. Die kostenlose Stufe generiert Code für bis zu maximal 20 Endpunkte.
* [Metalama](https://www.postsharp.net/metalama) – Nur für C#. Metalama generiert Boilerplate-Code während der Kompilierung on-the-fly, sodass dein Quellcode sauber bleibt. Für Open-Source-Projekte kostenlos, die kommerziell nutzbare kostenlose Stufe beinhaltet drei Aspects.
* [Supermaven](https://www.supermaven.com/) — Supermaven ist ein schneller KI-Code-Completion-Plugin für VSCode, JetBrains und Neovim. Die kostenlose Stufe bietet unbegrenzte Inline-Vervollständigungen.
* [tabnine.com](https://www.tabnine.com/) — Tabnine hilft Entwicklern, bessere Software schneller zu erstellen, indem es Erkenntnisse aus dem gesamten verfügbaren Code nutzt. Plugin verfügbar.
* [v0.dev](https://v0.dev/) — v0 verwendet KI-Modelle, um Code basierend auf einfachen Texteingaben zu generieren. Es erzeugt Copy-and-Paste-freundlichen React-Code auf Basis von shadcn/ui und Tailwind CSS, den Entwickler in ihren Projekten verwenden können. Jede Generierung kostet mindestens 30 Credits. Der Startwert beträgt 1200 Credits, monatlich gibt es 200 kostenlose Credits.

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Codequalität

* [beanstalkapp.com](https://beanstalkapp.com/) — Kompletter Workflow zum Schreiben, Überprüfen und Deployen von Code, kostenloses Konto für einen Benutzer und ein Repository mit 100 MB Speicherplatz
* [browserling.com](https://www.browserling.com/) — Live-interaktives Cross-Browser-Testing, kostenlos nur 3-Minuten-Sessions mit MS IE 9 unter Vista mit 1024 x 768 Auflösung
* [codacy.com](https://www.codacy.com/) — Automatisierte Code-Reviews für PHP, Python, Ruby, Java, JavaScript, Scala, CSS und CoffeeScript, kostenlos für unbegrenzt viele öffentliche und private Repositories
* [Codeac.io](https://www.codeac.io/infrastructure-as-code.html?ref=free-for-dev) – Automatisiertes Infrastructure as Code Review Tool für DevOps, integriert mit GitHub, Bitbucket und GitLab (auch selbst gehostet). Neben Standardsprachen werden auch Ansible, Terraform, CloudFormation, Kubernetes und mehr analysiert. (Open Source kostenlos)
* [CodeBeat](https://codebeat.co) — Automatisierte Code-Review-Plattform für viele Sprachen. Für öffentliche Repositories kostenlos, inklusive Slack- und E-Mail-Integration.
* [codeclimate.com](https://codeclimate.com/) — Automatisierte Code-Reviews, kostenlos für Open Source und unbegrenzt viele organisations-eigene private Repos (bis zu 4 Mitarbeiter). Ebenfalls kostenlos für Studenten und Bildungseinrichtungen.
* [codecov.io](https://codecov.io/) — Code-Coverage-Tool (SaaS), kostenlos für Open Source und ein privates Repo
* [CodeFactor](https://www.codefactor.io) — Automatisierte Code-Reviews für Git. Die kostenlose Version umfasst unbegrenzte Nutzer, öffentliche Repositories und ein privates Repo.
* [coderabbit.ai](https://coderabbit.ai) — KI-gestütztes Code-Review-Tool mit Integration für GitHub/GitLab. Die kostenlose Stufe umfasst 200 Dateien/Stunde, 3 Reviews pro Stunde und 50 Konversationen/Stunde. Für Open Source Projekte dauerhaft kostenlos.
* [codescene.io](https://codescene.io/) – CodeScene priorisiert technischen Schulden basierend darauf, wie Entwickler mit dem Code arbeiten, und visualisiert organisatorische Faktoren wie Team-Kopplung und System-Beherrschung. Kostenlos für Open Source.
* [CodSpeed](https://codspeed.io) – Automatisiere Performance-Tracking in deinen CI-Pipelines. Erkenne Performance-Regressions vor der Bereitstellung dank präziser und konsistenter Metriken. Dauerhaft kostenlos für Open-Source-Projekte.
* [coveralls.io](https://coveralls.io/) — Zeigt Testabdeckungsberichte an, kostenlos für Open Source
* [dareboost](https://dareboost.com) – 5 kostenlose Analyseberichte pro Monat für Web-Performance, Barrierefreiheit und Sicherheit
* [deepcode.ai](https://www.deepcode.ai) — DeepCode findet Bugs, Sicherheitslücken, Performance- und API-Probleme auf KI-Basis. Die Analysegeschwindigkeit von DeepCode ermöglicht es, deinen Code in Echtzeit zu analysieren und Ergebnisse direkt beim Speichern im IDE zu liefern. Unterstützte Sprachen: Java, C/C++, JavaScript, Python und TypeScript. Integrationen mit GitHub, BitBucket und GitLab. Kostenlos für Open Source und private Repos, bis zu 30 Entwickler.
* [deepscan.io](https://deepscan.io) — Fortgeschrittene statische Analyse zum automatischen Auffinden von Laufzeitfehlern in JavaScript-Code, kostenlos für Open Source
* [DeepSource](https://deepsource.io/) – DeepSource analysiert kontinuierlich Quellcode-Änderungen, findet und behebt Probleme in den Kategorien Sicherheit, Performance, Anti-Patterns, Bug-Risiken, Dokumentation und Stil. Native Integration mit GitHub, GitLab und Bitbucket.
* [DiffText](https://difftext.com) – Finde sofort die Unterschiede zwischen zwei Codeblöcken. Komplett kostenlos nutzbar.
* [eversql.com](https://www.eversql.com/) — EverSQL – Die Nr. 1 Plattform für Datenbankoptimierung. Erhalte automatisch wichtige Einblicke in deine Datenbank und SQL-Queries.
* [gerrithub.io](https://review.gerrithub.io/) — Gerrit-Code-Review für GitHub-Repositories kostenlos
* [gocover.io](https://gocover.io/) — Code Coverage für jedes [Go](https://golang.org/) Paket
* [goreportcard.com](https://goreportcard.com/) — Codequalität für Go-Projekte, kostenlos für Open Source
* [gtmetrix.com](https://gtmetrix.com/) — Berichte und ausführliche Empfehlungen zur Optimierung von Websites
* [holistic.dev](https://holistic.dev/) – Der Nr. 1 statische Code-Analyzer für Postgresql-Optimierung. Automatische Erkennung von Performance-, Sicherheits- und Architekturproblemen bei Datenbanken
* [houndci.com](https://houndci.com/) — Kommentiert GitHub-Commits bezüglich Codequalität, kostenlos für Open Source
* [Moderne.io](https://app.moderne.io) — Automatische Quellcode-Refaktorierung. Moderne bietet Framework-Migrationen, Codeanalysen mit Behebung und unübertroffene Code-Transformation im großen Stil, sodass Entwickler ihre Zeit mit neuen Features verbringen können anstatt mit Wartung. Kostenlos für Open Source.
* [reviewable.io](https://reviewable.io/) — Code-Review für GitHub-Repositories, kostenlos für öffentliche oder persönliche Repos.
* [parsers.dev](https://parsers.dev/) – Abstract Syntax Tree Parser und Intermediate Representation Compiler als Service
* [scan.coverity.com](https://scan.coverity.com/) — Statische Codeanalyse für Java, C/C++, C# und JavaScript, kostenlos für Open Source
* [scrutinizer-ci.com](https://scrutinizer-ci.com/) — Continuous Inspection Plattform, kostenlos für Open Source
* [semanticdiff.com](https://app.semanticdiff.com/) — Programmiersprachen-bewusster Diff für GitHub Pull Requests und Commits, kostenlos für öffentliche Repositories
* [shields.io](https://shields.io) — Qualitäts-Metadaten-Badges für Open-Source-Projekte
* [sonarcloud.io](https://sonarcloud.io) — Automatisierte Quellcodeanalyse für Java, JavaScript, C/C++, C#, VB.NET, PHP, Objective-C, Swift, Python, Groovy und viele weitere Sprachen, kostenlos für Open Source
* [SourceLevel](https://sourcelevel.io/) — Automatisierte Code-Reviews und Team-Analytics. Kostenlos für Open Source und Organisationen bis 5 Mitarbeiter.
* [webceo.com](https://www.webceo.com/) — SEO-Tools, aber auch Code-Überprüfungen und verschiedene Gerätetypen
* [zoompf.com](https://zoompf.com/) — Verbessere die Performance deiner Website, detaillierte Analysen

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Code-Suche und -Durchsicht

* [libraries.io](https://libraries.io/) — Suche und Abhängigkeits-Update-Benachrichtigungen für 32 verschiedene Paketmanager, kostenlos für Open Source
* [Namae](https://namae.dev/) – Suche auf verschiedenen Websites wie GitHub, Gitlab, Heroku, Netlify und vielen weiteren nach der Verfügbarkeit deines Projektnamens.
* [searchcode.com](https://searchcode.com/) — Umfassende textbasierte Codesuche, kostenlos für Open Source
* [tickgit.com](https://www.tickgit.com/) — Zeigt `TODO`-Kommentare (und andere Marker) an, um Codebereiche mit Verbesserungsbedarf zu identifizieren.
* [CodeKeep](https://codekeep.io) – Google Keep für Code-Snippets. Organisiere, entdecke und teile Code-Snippets, inklusive leistungsstarkem Code-Screenshot-Tool mit Vorlagen und Verlinkungsfunktion.

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## CI und CD

* [AccessLint](https://github.com/marketplace/accesslint) — AccessLint bringt automatisierte Web-Accessibility-Tests in deinen Entwicklungs-Workflow. Kostenlos für Open Source und Bildungszwecke.
* [appcircle.io](https://appcircle.io) — Eine Enterprise-Grade Mobile-DevOps-Plattform, die Build-, Test- und Store-Veröffentlichung mobiler Apps automatisiert, für schnellere, effizientere Release-Zyklen. Kostenlos für max. 30 Minuten Build-Zeit pro Build, 20 monatliche Builds und 1 gleichzeitigen Build.
* [appveyor.com](https://www.appveyor.com/) — CD-Service für Windows, kostenlos für Open Source
* [LocalOps](https://localops.co/) – Deploy deine App auf AWS/GCP/Azure in unter 30 Minuten. Standardisierte App-Umgebungen auf jeder Cloud, mit integrierter Continuous Deployment Automatisierung und fortschrittlicher Observability. Der kostenlose Plan erlaubt 1 Nutzer und 1 App-Umgebung.
* [Argonaut](https://argonaut.dev/) – Deploy Apps und Infrastruktur auf deiner Cloud in Minuten. Unterstützung für benutzerdefinierte und Drittanbieter-App-Deployments auf Kubernetes- und Lambda-Umgebungen. Die kostenlose Stufe erlaubt unbegrenzt viele Apps und Deployments für 5 Domains und 2 Nutzer.
* [bitrise.io](https://www.bitrise.io/) — CI/CD für mobile Apps, native oder hybrid. Mit 200 kostenlosen Builds/Monat, 10 Min. Build-Zeit und zwei Teammitgliedern. OSS-Projekte erhalten 45 Min. Build-Zeit, +1 Parallelität und unbegrenzte Teamgröße.
* [buddy.works](https://buddy.works/) — CI/CD mit fünf kostenlosen Projekten und einem gleichzeitigen Lauf (120 Ausführungen/Monat)
* [Buildkite](https://buildkite.com) – CI-Pipelines kostenlos für 3 Nutzer und 5.000 Job-Minuten/Monat. Test Analytics kostenloses Entwicklerkontingent umfasst 100.000 Testausführungen/Monat, mehr kostenlos für Open-Source-Projekte.
* [bytebase.com](https://www.bytebase.com/) — Database CI/CD und DevOps. Kostenlos für unter 20 Nutzer und zehn Datenbankinstanzen
* [CircleCI](https://circleci.com/) — Umfassender kostenloser Plan mit allen Funktionen für GitHub-, GitLab- und BitBucket-Repositories. Mehrere Ressourcentypen, Docker, Windows, Mac OS, ARM-Executors, lokale Runner, Test-Splitting, Docker Layer Caching und andere fortschrittliche CI/CD-Features. Kostenlos für bis zu 6000 Minuten/Monat Ausführungszeit, unbegrenzt viele Mitarbeiter, 30 parallele Jobs in privaten Projekten und bis zu 80.000 kostenlose Build-Minuten für Open-Source-Projekte.
* [cirrus-ci.org](https://cirrus-ci.org) – Kostenlos für öffentliche GitHub-Repositories
* [cirun.io](https://cirun.io) – Kostenlos für öffentliche GitHub-Repositories
* [codefresh.io](https://codefresh.io) — Free-for-Life-Plan: 1 Build, eine Umgebung, geteilte Server, unbegrenzt viele öffentliche Repos
* [codemagic.io](https://codemagic.io/) – Kostenlos 500 Build-Minuten/Monat
* [codeship.com](https://codeship.com/) — 100 private Builds/Monat, fünf private Projekte, unbegrenzt für Open Source
* [deploybot.com](https://www.deploybot.com/) — 1 Repository mit zehn Deployments, kostenlos für Open Source
* [deployhq.com](https://www.deployhq.com/) — 1 Projekt mit zehn täglichen Deployments (30 Build-Minuten/Monat)
* [drone](https://cloud.drone.io/) – Drone Cloud ermöglicht Entwicklern das Ausführen von Continuous-Delivery-Pipelines über mehrere Architekturen – einschließlich x86 und Arm (sowohl 32-Bit als auch 64-Bit) – alles an einem Ort
* [LayerCI](https://layerci.com) – CI für Full-Stack-Projekte. Eine vollständige Stack-Preview-Umgebung mit 5GB RAM & 3 CPUs.
* [semaphoreci.com](https://semaphoreci.com/) — Kostenlos für Open Source, 100 private Builds pro Monat
* [Squash Labs](https://www.squash.io/) — Erstellt eine VM für jeden Branch und macht deine App unter einer einzigartigen URL verfügbar, unbegrenzt öffentliche & private Repos, bis zu 2 GB VM-Größe.
* [styleci.io](https://styleci.io/) — Nur öffentliche GitHub-Repositories
* [Mergify](https://mergify.io) — Workflow-Automatisierung und Merge-Queue für GitHub — Kostenlos für öffentliche GitHub-Repositories
* [Make](https://www.make.com/en) — Das Workflow-Automatisierungstool verbindet Apps und automatisiert Workflows per UI. Unterstützt viele Apps und die bekanntesten APIs. Kostenlos für öffentliche GitHub-Repositories, und kostenlose Stufe mit 100 Mb, 1000 Operationen, 15 Minuten Mindestintervall.
* [Spacelift](https://spacelift.io/) – Management-Plattform für Infrastructure as Code. Kostenloser Plan: IaC-Kollaboration, Terraform-Modul-Registry, ChatOps-Integration, kontinuierliche Ressourcen-Compliance mit Open Policy Agent, SSO mit SAML 2.0 und Zugang zu öffentlichen Worker Pools: bis zu 200 Minuten/Monat
* [microtica.com](https://microtica.com/) – Startup-Umgebungen mit fertigen Infrastrukturkomponenten, Apps kostenlos auf AWS deployen und Produktions-Workloads unterstützen. Die kostenlose Stufe beinhaltet 1 Umgebung (auf deinem AWS-Konto), 2 Kubernetes-Services, 100 Build-Minuten pro Monat und 20 monatliche Deployments.
* [Nx Cloud](https://nx.dev/ci) – Nx Cloud beschleunigt Ihre Monorepos in der CI mit Funktionen wie Remote-Caching, Verteilung von Aufgaben über mehrere Maschinen und sogar automatischer Aufteilung Ihrer E2E-Testläufe. Es gibt einen kostenlosen Plan für bis zu 30 Mitwirkende mit großzügigen 150.000 Credits inklusive.
* [blacksmith](https://www.blacksmith.sh/) – Verwaltete Performance-Runner für GitHub Actions, die 3.000 kostenlose Minuten pro Monat bieten, ohne dass eine Kreditkarte erforderlich ist.
* [Terramate](https://terramate.io/) – Terramate ist eine Orchestrierungs- und Managementplattform für Infrastructure as Code (IaC)-Tools wie Terraform, OpenTofu und Terragrunt. Kostenlos für bis zu 2 Nutzer inklusive aller Funktionen.
* [Terrateam](https://terrateam.io) – GitOps-first Terraform-Automatisierung mit Pull-Request-gesteuerten Workflows, Projektisolation durch selbstgehostete Runner und gestaffelten Ausführungen für geordnete Abläufe. Kostenlos für bis zu 3 Nutzer.

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Testen

* [Applitools.com](https://applitools.com/) — Intelligente visuelle Validierung für Web-, native Mobile- und Desktop-Apps. Integriert sich mit nahezu allen Automatisierungslösungen (wie Selenium und Karma) und Remote-Runnern (Sauce Labs, Browser Stack). Kostenlos für Open Source. Eine kostenlose Stufe für einen einzelnen Nutzer mit begrenzten Checkpoints pro Woche.
* [Appetize](https://appetize.io) — Testen Sie Ihre Android- & iOS-Apps auf diesem Cloud-basierten Android-Phone-/Tablet-Emulator und iPhone/iPad-Simulatoren direkt im Browser. Die kostenlose Stufe enthält zwei gleichzeitige Sitzungen mit 30 Minuten Nutzung pro Monat. Keine Größenbeschränkung für Apps.
* [Apptim](https://apptim.com) — Ein Mobile-Test-Tool, das es auch Personen ohne Performance-Engineering-Kenntnisse ermöglicht, die Leistung und Benutzererfahrung (UX) einer App zu bewerten. Eine Desktop-Version mit eigenem Gerät ist 100 % KOSTENLOS, mit unbegrenzten Tests auf iOS und Android.
* [Argos](https://argos-ci.com) – Open-Source-Visual-Testing für Entwickler. Unbegrenzte Projekte, mit 5.000 Screenshots pro Monat. Kostenlos für Open-Source-Projekte.
* [Bencher](https://bencher.dev/) – Eine Suite für kontinuierliches Benchmarking, um Performance-Regressions im CI zu erkennen. Kostenlos für alle öffentlichen Projekte.
* [browserstack.com](https://www.browserstack.com/) — Manuelles und automatisiertes Browser-Testing, [kostenlos für Open Source](https://www.browserstack.com/open-source?ref=pricing)
* [BugBug](https://bugbug.io/) – Leichtgewichtiges Testautomatisierungstool für Webanwendungen. Einfach zu erlernen und keine Programmierkenntnisse erforderlich. Sie können unbegrenzt viele Tests auf Ihrem eigenen Computer kostenlos ausführen. Cloud-Monitoring und CI/CD-Integration gegen monatliche Gebühr verfügbar.
* [Checkly](https://checklyhq.com) – Code-first Synthetic Monitoring für modernes DevOps. Überwachen Sie Ihre APIs und Apps zu einem Bruchteil der Kosten herkömmlicher Anbieter. Unterstützt Monitoring-as-Code-Workflows und Playwright. Großzügige kostenlose Stufe für Entwickler.
* [checkbot.io](https://www.checkbot.io/) — Browser-Erweiterung, die prüft, ob Ihre Website mehr als 50 SEO-, Speed- und Security-Best-Practices einhält. Kostenlos für kleinere Websites.
* [CORS-Tester](https://cors-error.dev/cors-tester/) – Ein kostenloses Tool für Entwickler und API-Tester, um zu prüfen, ob eine API für eine bestimmte Domain CORS-fähig ist und Lücken zu identifizieren. Liefert umsetzbare Erkenntnisse.
* [cypress.io](https://www.cypress.io/) – Schnelles, einfaches und zuverlässiges Testing für alles, was im Browser läuft. Cypress Test Runner ist immer kostenlos und Open Source, ohne Einschränkungen. Cypress Dashboard ist kostenlos für Open-Source-Projekte bis zu 5 Nutzer.
* [Cypress Recorder by Preflight](https://cypress.preflight.com/) – Erstellen Sie KI-gestützte Cypress-Tests/POM-Modelle im Browser. Open Source, mit Ausnahme des KI-Teils. Kostenlos für fünf Test-Erstellungen pro Monat inkl. Self-Healing-Skripte, E-Mail- und visuelles Testing.
* [everystep-automation.com](https://www.everystep-automation.com/) — Zeichnet alle Schritte im Webbrowser auf und spielt sie ab, erstellt Scripte, kostenlos mit weniger Optionen
* [Gremlin](https://www.gremlin.com/gremlin-free-software) — Die Chaos-Engineering-Tools von Gremlin ermöglichen es, Fehler sicher und kontrolliert in Systeme einzuschleusen, um Schwachstellen zu finden, bevor sie zu Problemen führen. Gremlin Free bietet Zugriff auf Shutdown- und CPU-Attacken auf bis zu 5 Hosts oder Container.
* [gridlastic.com](https://www.gridlastic.com/) — Selenium-Grid-Testing mit kostenlosem Plan: bis zu 4 gleichzeitige Selenium-Nodes/10 Grid-Starts/4.000 Testminuten pro Monat
* [katalon.com](https://katalon.com) – Bietet eine Testplattform, die Teams jeder Größe und Reife im Testen unterstützt, einschließlich Katalon Studio, TestOps (+ visuelles Testing kostenlos), TestCloud und Katalon Recorder.
* [Keploy](https://keploy.io/) – Keploy ist ein funktionales Test-Toolkit für Entwickler. Aufnahme von API-Calls erzeugt E2E-Tests für APIs (KTests) und Mocks oder Stubs (KMocks). Kostenlos für Open-Source-Projekte.
* [knapsackpro.com](https://knapsackpro.com) – Beschleunigen Sie Ihre Tests durch optimale Parallelisierung der Test-Suite auf jedem CI-Anbieter. Ruby- und JavaScript-Tests auf parallelen CI-Nodes aufteilen und Zeit sparen. Kostenloser Plan für bis zu 10 Minuten Testdateien und unbegrenzter kostenloser Plan für Open Source.
* [lambdatest.com](https://www.lambdatest.com/) — Manuelles, visuelles, Screenshot- und automatisiertes Browser-Testing auf Selenium und Cypress, [kostenlos für Open Source](https://www.lambdatest.com/open-source-cross-browser-testing-tool)
* [loadmill.com](https://www.loadmill.com/) – Automatische Erstellung von API- und Lasttests durch Analyse des Netzwerkverkehrs. Simulation von bis zu 50 gleichzeitigen Nutzern für bis zu 60 Minuten kostenlos pro Monat.
* [lost-pixel.com](https://lost-pixel.com) – Ganzheitliches visuelles Regressionstesting für Ihre Storybook-, Ladle-, Histoire-Stories und Web-Apps. Unbegrenzte Teammitglieder, vollkommen kostenlos für Open Source, 7.000 Snapshots/Monat.
* [octomind.dev](https://www.octomind.dev/) – Automatisch generierte, ausgeführte und gewartete Playwright-UI-Tests mit KI-gestützter Testfallgenerierung.
* [percy.io](https://percy.io) – Fügen Sie jedem Web-App, statischer Seite, Styleguide oder Komponentenbibliothek visuelles Testing hinzu. Unbegrenzte Teammitglieder, Demo-App und unbegrenzte Projekte, 5.000 Snapshots/Monat.
* [preflight.com](https://preflight.com) – No-Code automatisiertes Web-Testing. Tests im Browser aufnehmen, die robust gegen UI-Änderungen sind, und auf Windows-Maschinen ausführen. Integration in CI/CD möglich. Der kostenlose Plan enthält 50 monatliche Testruns mit Video, HTML-Sessions und mehr.
* [qase.io](https://qase.io) – Testmanagementsystem für Dev- und QA-Teams. Testfälle verwalten, Testläufe zusammenstellen, Tests durchführen, Defekte verfolgen und Auswirkungen messen. Die kostenlose Stufe enthält alle Kernfunktionen, mit 500MB für Anhänge und bis zu 3 Nutzer.
* [Repeato](https://repeato.app/) No-Code-Testautomatisierung für mobile Apps auf Basis von Computer Vision und KI. Funktioniert für native Apps, Flutter, React-Native, Web, Ionic und viele weitere Frameworks. Der kostenlose Plan ist auf 10 Tests für iOS und 10 für Android begrenzt, beinhaltet aber die meisten Features der kostenpflichtigen Pläne, inklusive unbegrenzter Testausführungen.
* [Requestly](https://requestly.com/) Open-Source-Chrome-Erweiterung zum Abfangen, Umleiten und Mocken von HTTP-Anfragen. Mit [Debugger](https://requestly.com/products/web-debugger/), [Mock Server](https://requestly.com/products/mock-server/), [API Client](https://requestly.com/products/api-client/) und [Session Recording](https://requestly.com/products/session-book/). URLs umleiten, HTTP-Header ändern, APIs mocken, eigenes JS einfügen, GraphQL-Requests verändern, Mock-API-Endpunkte generieren, Session mit Netzwerk- & Konsolenlogs aufzeichnen. Bis zu 10 Regeln im Free-Tier. Kostenlos für Open Source.
* [seotest.me](https://seotest.me/) — Kostenloser On-Page-SEO-Websitetester. 10 kostenlose Website-Crawls pro Tag. Nützliche SEO-Lernressourcen und Empfehlungen zur Verbesserung der On-Page-SEO-Ergebnisse für jede Website, unabhängig von der Technologie.
* [snippets.uilicious.com](https://snippets.uilicious.com) – Wie CodePen, aber für Cross-Browser-Testing. UI-licious ermöglicht das Schreiben von Tests wie User Stories und bietet eine kostenlose Plattform – UI-licious Snippets – auf der unbegrenzt viele Tests auf Chrome ohne Anmeldung für bis zu 3 Minuten pro Testrun ausgeführt werden können. Fehler gefunden? Sie können die eindeutige URL zu Ihrem Test kopieren, um Ihren Entwicklern genau zu zeigen, wie der Fehler reproduziert werden kann.
* [TestCollab](https://testcollab.com) – Benutzerfreundliche Testmanagement-Software, kostenloser Plan inkl. Jira-Integration, unbegrenzte Projekte, Testfallimport per CSV/XLSx, Zeiterfassung und 1 GB Speicher.
* [testingbot.com](https://testingbot.com/) — Selenium-Browser- und Gerätetests, [kostenlos für Open Source](https://testingbot.com/open-source)
* [Testspace.com](https://testspace.com/) – Ein Dashboard zur Veröffentlichung automatisierter Testergebnisse und ein Framework zur Implementierung manueller Tests als Code mit GitHub. Der Dienst ist [kostenlos für Open Source](https://github.com/marketplace/testspace-com) und umfasst 450 Ergebnisse monatlich.
* [tesults.com](https://www.tesults.com) — Testresultat-Reporting und Testfallmanagement. Integration mit beliebten Testframeworks. Open-Source-Entwickler, Einzelpersonen, Ausbilder und kleine Teams können ermäßigte und kostenlose Angebote über die Basisprojekte hinaus anfragen.
* [UseWebhook.com](https://usewebhook.com) – Webhooks vom Browser aus erfassen und inspizieren. Weiterleitung an localhost oder erneutes Abspielen aus dem Verlauf. Kostenlos nutzbar.
* [Vaadin](https://vaadin.com) — Skalierbare UIs in Java oder TypeScript bauen und mit integriertem Tooling, Komponenten und Design-System schneller iterieren, besser gestalten und die Entwicklung vereinfachen. Unbegrenzte Projekte, fünf Jahre kostenlose Wartung.
* [websitepulse.com](https://www.websitepulse.com/tools/) — Verschiedene kostenlose Netzwerk- und Servertools.
* [webhook-test.com](https://webhook-test.com) – Webhooks und HTTP-Requests mit einer eindeutigen URL während der Integration debuggen und inspizieren. Komplett kostenlos, unbegrenzt viele URLs und Empfehlungen.
* [webhook.site](https://webhook.site) – Webhooks, ausgehende HTTP-Requests oder E-Mails mit einer eigenen URL verifizieren. Eine temporäre URL und E-Mail-Adresse sind immer kostenlos.
* [webhookbeam.com](https://webhookbeam.com) – Webhooks einrichten und über Push-Benachrichtigungen und E-Mails überwachen.

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Sicherheit und PKI

* [aikido.dev](https://www.aikido.dev) — All-in-One-AppSec-Plattform, deckt SCA, SAST, CSPM, DAST, Secrets, IaC, Malware, Container-Scanning, EOL,... ab. Der kostenlose Plan beinhaltet zwei Nutzer, Scan von 10 Repos, 1 Cloud, 2 Containern & 1 Domain.
* [alienvault.com](https://www.alienvault.com/open-threat-exchange/reputation-monitor) — Deckt kompromittierte Systeme im Netzwerk auf
* [Altcha.org](https://altcha.org/anti-spam) – Ein Spam-Filter für Websites und APIs, basierend auf natürlicher Sprachverarbeitung und maschinellem Lernen. Der kostenlose Plan umfasst 200 Anfragen pro Tag und Domain.
* [atomist.com](https://atomist.com/) — Ein schnellerer und komfortablerer Weg, verschiedene Entwicklungstasks zu automatisieren. Aktuell in Beta.
* [cloudsploit.com](https://cloudsploit.com/) — Amazon Web Services (AWS) Security- und Compliance-Auditing und Monitoring
* [Public Cloud Threat Intelligence](https://cloudintel.himanshuanand.com/) — High-confidence-Indikatoren für Kompromittierungen (IOC), die sich gegen Public-Cloud-Infrastrukturen richten. Ein Teil ist auf GitHub verfügbar (https://github.com/unknownhad/AWSAttacks). Die vollständige Liste ist per API verfügbar.
* [CodeNotary.io](https://www.codenotary.io/) — Open-Source-Plattform mit unwiderlegbarem Nachweis zur Notarisierung von Code, Dateien, Verzeichnissen oder Containern
* [crypteron.com](https://www.crypteron.com/) — Cloud-First, entwicklerfreundliche Sicherheitsplattform, die Datenpannen in .NET- und Java-Anwendungen verhindert
* [CyberChef](https://gchq.github.io/CyberChef/) — Eine einfache, intuitive Web-App zum Analysieren, Decodieren/Encodieren von Daten, ohne komplexe Tools oder Programmiersprachen. Wie ein Schweizer Taschenmesser der Kryptographie & Verschlüsselung. Alle Funktionen sind kostenlos nutzbar, ohne Limit. Open Source zum Selbsthosten.
* [DAS](https://signup.styra.com/) — Styra DAS Free, vollständiges Lifecycle-Policy-Management zur Erstellung, Bereitstellung und Verwaltung von Open Policy Agent (OPA) Autorisierungen
* [Datree](https://www.datree.io/) — Open-Source-CLI-Tool, um Kubernetes-Fehlkonfigurationen zu verhindern, indem sichergestellt wird, dass Manifeste und Helm-Charts Best Practices und Unternehmensrichtlinien folgen
* [Dependabot](https://dependabot.com/) Automatisierte Abhängigkeits-Updates für Ruby, JavaScript, Python, PHP, Elixir, Rust, Java (Maven und Gradle), .NET, Go, Elm, Docker, Terraform, Git Submodules und GitHub Actions.
* [DJ Checkup](https://djcheckup.com) — Überprüfen Sie Ihre Django-Site auf Sicherheitslücken mit diesem kostenlosen, automatisierten Tool. Geforkt von der Pony Checkup-Seite.
* [Doppler](https://doppler.com/) — Universeller Secret Manager für Anwendungsgeheimnisse und Konfigurationen, mit Support für Sync zu verschiedenen Cloud-Anbietern. Kostenlos für fünf Nutzer mit grundlegenden Zugriffskontrollen.
* [Dotenv](https://dotenv.org/) — Synchronisieren Sie Ihre .env-Dateien schnell und sicher. Teilen Sie Ihre .env-Dateien nicht mehr über unsichere Kanäle wie Slack und E-Mail, und verlieren Sie nie wieder eine wichtige .env-Datei. Kostenlos für bis zu 3 Teammitglieder.
* [GitGuardian](https://www.gitguardian.com) — Halten Sie Geheimnisse aus Ihrem Quellcode mit automatisierter Erkennung und Behebung. Scannen Sie Ihre Git-Repos auf 350+ Arten von Geheimnissen und sensiblen Dateien – kostenlos für Einzelpersonen und Teams bis zu 25 Entwicklern.
* [Have I been pwned?](https://haveibeenpwned.com) — REST-API zum Abrufen von Informationen über Datenlecks.
* [hostedscan.com](https://hostedscan.com) — Online-Schwachstellen-Scanner für Webanwendungen, Server und Netzwerke. Zehn kostenlose Scans pro Monat.
* [Infisical](https://infisical.com/) — Open-Source-Plattform zur Verwaltung von Entwicklergeheimnissen im Team und in der Infrastruktur – von der lokalen Entwicklung bis zu Staging/Produktions-3rd-Party-Services. Kostenlos für bis zu 5 Entwickler.
* [Internet.nl](https://internet.nl) — Test für moderne Internetstandards wie IPv6, DNSSEC, HTTPS, DMARC, STARTTLS und DANE
* [keychest.net](https://keychest.net) – SSL-Ablaufmanagement und Zertifikatskauf mit integrierter CT-Datenbank
* [letsencrypt.org](https://letsencrypt.org/) — Kostenlose SSL-Zertifizierungsstelle mit Zertifikaten, die von allen gängigen Browsern anerkannt werden
* [meterian.io](https://www.meterian.io/) – Überwachen Sie Java-, JavaScript-, .NET-, Scala-, Ruby- und NodeJS-Projekte auf Sicherheitslücken in Abhängigkeiten. Kostenlos für ein privates Projekt, unbegrenzte Projekte für Open Source.
* [Mozilla Observatory](https://observatory.mozilla.org/) — Finden und Beheben von Sicherheitslücken auf Ihrer Website.
* [opswat.com](https://www.opswat.com/) — Sicherheitsüberwachung von Computern, Geräten, Anwendungen, Konfigurationen, kostenlos für 25 Nutzer und 30 Tage Verlauf.
* [openapi.security](https://openapi.security/) – Kostenloses Tool zum schnellen Prüfen der Sicherheit beliebiger OpenAPI-/Swagger-basierter APIs. Keine Anmeldung erforderlich.
* [pixee.ai](https://pixee.ai) – Automatisierter Product Security Engineer als kostenloser GitHub-Bot, der PRs in Ihr Java-Code-Repository einreicht, um Schwachstellen automatisch zu beheben. Weitere Sprachen folgen bald!
* [pyup.io](https://pyup.io) — Überwachen Sie Python-Abhängigkeiten auf Sicherheitslücken und aktualisieren Sie sie automatisch. Kostenlos für ein privates Projekt, unbegrenzte Projekte für Open Source.
* [qualys.com](https://www.qualys.com/community-edition) — Finden Sie Schwachstellen in Web-Apps, prüfen Sie auf OWASP-Risiken
* [report-uri.io](https://report-uri.io/) — CSP- und HPKP-Verletzungsberichte
* [ringcaptcha.com](https://ringcaptcha.com/) — Tools, um die Telefonnummer als ID zu nutzen, kostenlos verfügbar
* [seclookup.com](https://www.seclookup.com/) – Seclookup-APIs können Domain-Bedrohungsindikatoren in SIEM anreichern, umfassende Informationen zu Domain-Namen liefern und die Bedrohungserkennung & -reaktion verbessern. Erhalten Sie 50.000 kostenlose Lookups [hier](https://account.seclookup.com/).
* [snyk.io](https://snyk.io) — Findet und behebt bekannte Sicherheitslücken in Open-Source-Abhängigkeiten. Unbegrenzte Tests und Behebungen für Open-Source-Projekte. Bis zu 200 Tests/Monat für private Projekte.
* [ssllabs.com](https://www.ssllabs.com/ssltest/) — Umfassende Analyse der Konfiguration jedes SSL-Webservers
* [SOOS](https://soos.io) – Kostenlos, unbegrenzte SCA-Scans für Open-Source-Projekte. Erkennen und beheben Sie Sicherheitsbedrohungen vor der Veröffentlichung. Schützen Sie Ihre Projekte mit einer einfachen und effektiven Lösung.
* [StackHawk](https://www.stackhawk.com/) Automatisieren Sie das Scannen von Anwendungen in Ihrer Pipeline, um Sicherheitsfehler zu finden und zu beheben, bevor sie in Produktion gehen. Unbegrenzte Scans und Umgebungen für eine App.
* [Sucuri SiteCheck](https://sitecheck.sucuri.net) – Kostenloser Website-Sicherheitscheck und Malware-Scanner
* [Protectumus](https://protectumus.com) – Kostenloser Website-Sicherheitscheck, Site-Antivirus und Server-Firewall (WAF) für PHP. E-Mail-Benachrichtigung für registrierte Nutzer im kostenlosen Tarif.
* [TestTLS.com](https://testtls.com) – Testen Sie einen SSL/TLS-Dienst auf sichere Serverkonfiguration, Zertifikate, Ketten usw. Nicht auf HTTPS beschränkt.
* [threatconnect.com](https://threatconnect.com) — Threat Intelligence: Entwickelt für Einzelresearcher, Analysten und Organisationen, die mit Cyber Threat Intelligence beginnen. Kostenlos für bis zu 3 Nutzer.
* [tinfoilsecurity.com](https://www.tinfoilsecurity.com/) — Automatisiertes Schwachstellenscanning. Der kostenlose Plan erlaubt wöchentliche XSS-Scans
* [Ubiq Security](https://ubiqsecurity.com/) — Daten mit drei Codezeilen verschlüsseln und entschlüsseln, automatische Schlüsselverwaltung. Kostenlos für eine Anwendung und bis zu 1.000.000 Verschlüsselungen pro Monat.
* [Virgil Security](https://virgilsecurity.com/) — Tools und Services für End-to-End-Verschlüsselung, Datenbankschutz, IoT-Sicherheit und mehr. Kostenlos für Anwendungen mit bis zu 250 Nutzern.
* [Vulert](https://vulert.com) – Vulert überwacht kontinuierlich Ihre Open-Source-Abhängigkeiten auf neue Schwachstellen und schlägt Fixes vor, ohne Installation oder Zugriff auf Ihren Code. Kostenlos für Open-Source-Projekte.
* [Escape GraphQL Quickscan](https://escape.tech/) – One-Click-Sicherheits-Scan Ihrer GraphQL-Endpunkte. Kostenlos, keine Anmeldung erforderlich.
* [HasMySecretLeaked](https://gitguardian.com/hasmysecretleaked) – Kostenlos in 20 Millionen offengelegten Geheimnissen in öffentlichen GitHub-Repositories, Gists, Issues und Kommentaren suchen
* [Project Gatekeeper](https://gatekeeper.binarybiology.top/) – All-in-One-SSL-Toolkit mit verschiedenen Funktionen wie Private Key & CSR Generator, SSL-Zertifikatsdecoder, Zertifikatsabgleich und Bestellung von SSL-Zertifikaten. Wir bieten Nutzern die Möglichkeit, kostenlose SSL-Zertifikate von Let's Encrypt, Google Trust und BuyPass per CNAME statt TXT zu generieren.
**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Authentifizierung, Autorisierung und Benutzerverwaltung

  * [Aserto](https://www.aserto.com) – Fein granulierte Autorisierung als Service für Anwendungen und APIs. Kostenlos bis zu 1000 MAUs und 100 Authorizer-Instanzen.
  * [asgardeo.io](https://wso2.com/asgardeo) – Nahtlose Integration von SSO, MFA, passwortloser Authentifizierung und mehr. Beinhaltet SDKs für Frontend- und Backend-Apps. Kostenlos bis zu 1000 MAUs und fünf Identitätsanbieter.
  * [Auth0](https://auth0.com/) — Gehostetes SSO. Der kostenlose Plan beinhaltet 25.000 MAUs, unbegrenzte soziale Verbindungen, eine eigene Domain und mehr.
  * [Authgear](https://www.authgear.com) – Bringen Sie Passwortlosigkeit, OTPs, 2FA, SSO in wenigen Minuten in Ihre Apps. Alle Frontend-Komponenten inklusive. Kostenlos bis zu 5000 MAUs.
  * [Authress](https://authress.io/) — Authentifizierungs-Login und Zugriffskontrolle, unbegrenzte Identitätsanbieter für jedes Projekt. Facebook, Google, Twitter und mehr. Die ersten 1000 API-Aufrufe sind kostenlos.
  * [Authy](https://authy.com) – Zwei-Faktor-Authentifizierung (2FA) auf mehreren Geräten, mit Backups. Drop-in-Ersatz für Google Authenticator. Kostenlos bis zu 100 erfolgreiche Authentifizierungen.
  * [Cerbos Hub](https://www.cerbos.dev/product-cerbos-hub) – Ein vollständiges Autorisierungsmanagementsystem zum Erstellen, Testen und Bereitstellen von Zugriffspolicen. Fein granulierte Autorisierung und Zugriffskontrolle, kostenlos bis zu 100 monatlich aktive Principals.
  * [Clerk](https://clerk.com) — Benutzerverwaltung, Authentifizierung, 2FA/MFA, vorgefertigte UI-Komponenten für Anmeldung, Registrierung, Benutzerprofile und mehr. Kostenlos bis zu 10.000 monatlich aktive Nutzer.
  * [Cloud-IAM](https://www.cloud-iam.com/) — Keycloak Identity and Access Management as a Service. Kostenlos bis zu 100 Nutzer und ein Realm.
  * [Corbado](https://www.corbado.com/) — Fügen Sie passkey-first Authentifizierung zu neuen oder bestehenden Apps hinzu. Kostenlos für unbegrenzte MAUs.
  * [Descope](https://www.descope.com/) — Hochgradig anpassbare AuthN-Flows, sowohl No-Code- als auch API/SDK-Ansatz. Kostenlos 7.500 aktive Nutzer/Monat, 50 Mandanten (bis zu 5 SAML/SSO Mandanten).
  * [duo.com](https://duo.com/) — Zwei-Faktor-Authentifizierung (2FA) für Websites oder Apps. Kostenlos für zehn Nutzer, alle Authentifizierungsmethoden, unbegrenzte Integrationen, Hardware-Token.
  * [Kinde](https://kinde.com/) – Einfache, robuste Authentifizierung, die Sie in wenigen Minuten mit Ihrem Produkt integrieren können. Alles Notwendige zum Starten mit 7.500 kostenlosen MAUs.
  * [logintc.com](https://www.logintc.com/) — Zwei-Faktor-Authentifizierung (2FA) per Push-Benachrichtigung, kostenlos für zehn Nutzer, VPN, Websites und SSH.
  * [MojoAuth](https://mojoauth.com/) – MojoAuth macht es einfach, passwortlose Authentifizierung in wenigen Minuten auf Ihrer Web-, Mobil- oder beliebigen Anwendung zu implementieren.
  * [Okta](https://developer.okta.com/signup/) — Benutzerverwaltung, Authentifizierung und Autorisierung. Kostenlos bis zu 100 monatlich aktive Nutzer.
  * [onelogin.com](https://www.onelogin.com/) — Identity as a Service (IDaaS), Single Sign-On Identity Provider, Cloud SSO IdP, drei Firmen-Apps und fünf persönliche Apps, unbegrenzte Nutzer.
  * [Ory](https://ory.sh/) – AuthN/AuthZ/OAuth2.0/Zero Trust Managed Security Platform. Für Entwicklerkonten für immer kostenlos mit allen Sicherheitsfunktionen, unbegrenzten Teammitgliedern, 200 täglich aktiven Nutzern und 25k/Monat Berechtigungsprüfungen.
  * [Permit.io](https://permit.io) – Autorisierung-as-a-Service-Plattform, die RBAC, ABAC und ReBAC für skalierbare Microservices mit Echtzeit-Updates und einer No-Code Policy UI ermöglicht. 1000 monatlich aktive Nutzer im kostenlosen Tarif.
  * [Phase Two](https://phasetwo.io) – Keycloak Open Source Identity and Access Management. Kostenloses Realm bis zu 1000 Nutzer, bis zu 10 SSO-Verbindungen, basierend auf dem erweiterten Keycloak-Container von Phase Two, inklusive [Organization](https://phasetwo.io/product/organizations/) Erweiterung.
  * [SSOJet](https://ssojet.com/) – Fügen Sie Enterprise SSO hinzu, ohne Ihre Authentifizierung neu zu bauen. Der kostenlose Plan beinhaltet unbegrenzte monatlich aktive Nutzer, unbegrenzte Organisationen, 2 SSO- & 2 SCIM-Verbindungen.
  * [Stytch](https://www.stytch.com/) – Eine All-in-One-Plattform, die APIs und SDKs für Authentifizierung und Betrugsprävention bereitstellt. Der kostenlose Plan beinhaltet 10.000 monatlich aktive Nutzer, unbegrenzte Organisationen, 5 SSO- oder SCIM-Verbindungen und 1.000 M2M-Tokens.
  * [Stack Auth](https://stack-auth.com) — Open-Source-Authentifizierung, die funktioniert. Die entwicklerfreundlichste Lösung, mit der Sie in nur fünf Minuten starten können. Kostenlos selbst-hostbar oder als Managed SaaS-Version mit 10k freien monatlich aktiven Nutzern.
  * [SuperTokens](https://supertokens.com/) – Open Source-Benutzerauthentifizierung, die sich nativ in Ihre App integriert – ermöglicht schnellen Start bei voller Kontrolle über User- und Developer-Erlebnis. Kostenlos bis zu 5000 MAUs.
  * [Warrant](https://warrant.dev/) — Gehosteter Autorisierungs- und Zugriffskontrollservice in Unternehmensqualität für Ihre Apps. Der kostenlose Tarif enthält 1 Million monatliche API-Anfragen und 1.000 Authz-Regeln.
  * [ZITADEL Cloud](https://zitadel.com) — Schlüsselfertige Benutzer- und Zugriffsverwaltung, die für Sie arbeitet und Multi-Tenant-(B2B)-Anwendungsfälle unterstützt. Kostenlos bis zu 25.000 authentifizierte Anfragen, mit allen Sicherheitsfeatures (kein Paywall für OTP, Passwortlosigkeit, Policies usw.).
  * [PropelAuth](https://propelauth.com) — Sofortiger Verkauf an Unternehmen jeder Größe mit wenigen Codezeilen, kostenlos bis zu 200 Nutzer und 10k Transaktions-E-Mails (mit Wasserzeichen-Branding: „Powered by PropelAuth“).
  * [Logto](https://logto.io/) – Entwickeln, sichern und verwalten Sie die Nutzeridentitäten Ihres Produkts – sowohl für Authentifizierung als auch Autorisierung. Kostenlos bis zu 5.000 MAUs, mit Open-Source-Self-Hosting-Option verfügbar.
  * [WorkOS](https://workos.com/) – Kostenlose Benutzerverwaltung und Authentifizierung für bis zu 1 Million MAUs. Unterstützt E-Mail + Passwort, Social Auth, Magic Auth, MFA und mehr.


**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Mobile App-Verteilung und Feedback

  * [TestApp.io](https://testapp.io) – Ihre Plattform, um sicherzustellen, dass Ihre mobilen Apps wie gewünscht funktionieren. Kostenloser Plan: eine App, Analytics, unbegrenzte Versionen & Installationen sowie Feedbacksammlung.
  * [Loadly](https://loadly.io) – iOS & Android Beta-App-Verteilungsservice, bietet komplett kostenlose Services mit unbegrenzten Downloads, Highspeed-Downloads und unbegrenzten Uploads.
  * [Diawi](https://www.diawi.com) – Deploy iOS & Android Apps direkt auf Geräte. Kostenloser Plan: App-Uploads, passwortgeschützte Links, 1 Tag Ablauf, zehn Installationen.
  * [InstallOnAir](https://www.installonair.com) – Verteile iOS & Android Apps Over-the-Air. Kostenloser Plan: unbegrenzte Uploads, private Links, 2 Tage Ablauf für Gäste, 60 Tage für registrierte Nutzer.
  * [GetUpdraft](https://www.getupdraft.com) – Verteile mobile Apps zu Testzwecken. Der kostenlose Plan beinhaltet ein App-Projekt, drei App-Versionen, 500 MB Speicher und 100 App-Installationen pro Monat.
  * [Appho.st](https://appho.st) – Mobile App-Hosting-Plattform. Der kostenlose Plan enthält fünf Apps, 50 monatliche Downloads und eine maximale Dateigröße von 100 MB.

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Verwaltungssystem

  * [bitnami.com](https://bitnami.com/) — Bereitstellung vorbereiteter Apps auf IaaS. Verwaltung einer AWS-Micro-Instanz kostenlos.
  * [Esper](https://esper.io) — MDM und MAM für Android-Geräte mit DevOps. Hundert Geräte kostenlos mit einer Nutzerlizenz und 25 MB App-Speicher.
  * [jamf.com](https://www.jamf.com/) — Gerätemanagement für iPads, iPhones und Macs, drei Geräte kostenlos.
  * [Miradore](https://miradore.com) — Device Management Service. Bleiben Sie auf dem neuesten Stand mit Ihrer Geräteflotte und sichern Sie unbegrenzte Geräte kostenlos. Der kostenlose Plan bietet Basisfunktionen.
  * [moss.sh](https://moss.sh) – Hilft Entwicklern, ihre Web-Apps und Server bereitzustellen und zu verwalten. Bis zu 25 Git-Deployments pro Monat kostenlos.
  * [runcloud.io](https://runcloud.io/) – Servermanagement, hauptsächlich für PHP-Projekte. Kostenlos für bis zu 1 Server.
  * [ploi.io](https://ploi.io/) – Servermanagement-Tool zum einfachen Verwalten und Bereitstellen Ihrer Server & Seiten. Kostenlos für einen Server.
  * [xcloud.host](https://xcloud.host) — Servermanagement- und Deployment-Plattform mit benutzerfreundlicher Oberfläche. Kostenloser Tarif für einen Server verfügbar.
  * [serveravatar.com](https://serveravatar.com) — Verwalten und überwachen Sie PHP-basierte Webserver mit automatisierten Konfigurationen. Kostenlos für einen Server.

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Messaging und Streaming

  * [Ably](https://www.ably.com/) – Echtzeit-Messaging-Service mit Anwesenheit, Persistenz und garantierter Zustellung. Der kostenlose Plan beinhaltet 3 Mio. Nachrichten pro Monat, 100 gleichzeitige Verbindungen und 100 gleichzeitige Kanäle.
  * [cloudamqp.com](https://www.cloudamqp.com/) — RabbitMQ as a Service. Little Lemur Plan: max. 1 Million Nachrichten/Monat, max. 20 gleichzeitige Verbindungen, max. 100 Queues, max. 10.000 wartende Nachrichten, mehrere Nodes in verschiedenen AZs.
  * [courier.com](https://www.courier.com/) — Einfache API für Push, In-App, E-Mail, Chat, SMS und andere Messaging-Kanäle mit Vorlagenverwaltung und weiteren Features. Der kostenlose Plan beinhaltet 10.000 Nachrichten/Monat.
  * [engagespot.co](https://engagespot.co/) — Multi-Channel-Benachrichtigungsinfrastruktur für Entwickler mit vorgefertigtem In-App-Posteingang und No-Code-Template-Editor. Kostenloser Plan beinhaltet 10.000 Nachrichten/Monat.
  * [HiveMQ](https://www.hivemq.com/mqtt-cloud-broker/) – Verbinden Sie Ihre MQTT-Geräte mit dem Cloud Native IoT Messaging Broker. Kostenlos für bis zu 100 Geräte (keine Kreditkarte erforderlich), für immer.
  * [knock.app](https://knock.app) – Benachrichtigungsinfrastruktur für Entwickler. Versand an mehrere Kanäle wie In-App, E-Mail, SMS, Slack und Push mit einem einzigen API-Aufruf. Der kostenlose Plan beinhaltet 10.000 Nachrichten/Monat.
  * [NotificationAPI.com](https://www.notificationapi.com/) — Fügen Sie Benachrichtigungen für Nutzer in jeder Software in 5 Minuten hinzu. Der kostenlose Plan beinhaltet 10.000 Benachrichtigungen/Monat + 100 SMS und automatisierte Anrufe.
  * [Novu.co](https://novu.co) — Die Open-Source-Benachrichtigungsinfrastruktur für Entwickler. Einfache Komponenten und APIs zur Verwaltung aller Kommunikationskanäle an einem Ort: E-Mail, SMS, Direkt, In-App und Push. Der kostenlose Plan beinhaltet 30.000 Benachrichtigungen/Monat mit 90 Tagen Aufbewahrung.
  * [pusher.com](https://pusher.com/) — Echtzeit-Messaging-Service. Kostenlos für bis zu 100 gleichzeitige Verbindungen und 200.000 Nachrichten/Tag.
  * [scaledrone.com](https://www.scaledrone.com/) — Echtzeit-Messaging-Service. Kostenlos für bis zu 20 gleichzeitige Verbindungen und 100.000 Events/Tag.
  * [synadia.com](https://synadia.com/ngs) — [NATS.io](https://nats.io) als Service. Global, AWS, GCP und Azure. Für immer kostenlos mit 4k Msg-Größe, 50 aktive Verbindungen und 5 GB Daten pro Monat.
  * [pubnub.com](https://www.pubnub.com/) – Swift-, Kotlin- und React-Messaging mit 1 Million Transaktionen pro Monat. Transaktionen können mehrere Nachrichten enthalten.
  * [eyeson API](https://developers.eyeson.team/) – Videokommunikations-API-Service auf Basis von WebRTC (SFU, MCU) zum Aufbau von Videoplattformen. Bietet Echtzeit-Dateninjektion, Video-Layouts, Aufzeichnungen, eine voll ausgestattete gehostete Web-UI (Quickstart) oder Pakete für individuelle UIs. Hat eine [kostenlose Stufe für Entwickler](https://apiservice.eyeson.com/api-pricing) mit 1000 Meeting-Minuten im Monat.
  * [webpushr](https://www.webpushr.com/) – Web-Push-Benachrichtigungen – kostenlos für bis zu 10k Abonnenten, unbegrenzte Push-Benachrichtigungen, In-Browser-Messaging.
  * [httpSMS](https://httpsms.com) – Senden und Empfangen von Textnachrichten über Ihr Android-Handy als SMS-Gateway. Kostenlos zum Senden und Empfangen von bis zu 200 Nachrichten pro Monat.
  * [EMQX Serverless](https://www.emqx.com/en/cloud/serverless-mqtt) – Skalierbarer und sicherer serverloser MQTT-Broker in Sekunden. 1 Mio. Sitzungsminuten/Monat für immer kostenlos (keine Kreditkarte erforderlich).
  * [Pocket Alert](https://pocketalert.app) – Senden Sie Push-Benachrichtigungen an Ihre iOS- und Android-Geräte. Einfach per API oder Webhooks integrierbar und behalten Sie die volle Kontrolle über Ihre Alerts. Kostenloser Plan: 50 Nachrichten pro Tag an 1 Gerät und 1 Anwendung.
  * [SuprSend](https://www.suprsend.com/) – SuprSend ist eine Benachrichtigungsinfrastruktur, die Ihre Produktbenachrichtigungen mit einem API-First-Ansatz optimiert. Erstellen und senden Sie Transaktions-, Cron- und Engagement-Benachrichtigungen auf mehreren Kanälen mit einer einzigen API. Im kostenlosen Plan erhalten Sie 10.000 Benachrichtigungen pro Monat, inklusive verschiedener Workflow-Nodes wie Digests, Batches, Multi-Channels, Präferenzen, Mandanten, Broadcasts u.a.

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Log-Management

  * [bugfender.com](https://bugfender.com/) — Kostenlos bis zu 100k Logzeilen/Tag mit 24 Stunden Aufbewahrung.
  * [logentries.com](https://logentries.com/) — Kostenlos bis zu 5 GB/Monat mit sieben Tagen Aufbewahrung.
  * [loggly.com](https://www.loggly.com/) — Kostenlos für einen einzelnen Nutzer, 200MB/Tag mit sieben Tagen Aufbewahrung.
  * [logz.io](https://logz.io/) — Kostenlos bis zu 1 GB/Tag, ein Tag Aufbewahrung.
  * [ManageEngine Log360 Cloud](https://www.manageengine.com/cloud-siem/) — Log-Management-Service von Manage Engine. Kostenloser Plan bietet 50 GB Speicher mit 15 Tagen Speicheraufbewahrung und 7 Tagen Suche.
  * [papertrailapp.com](https://papertrailapp.com/) — 48 Stunden Suche, sieben Tage Archiv, 50 MB/Monat.
  * [sematext.com](https://sematext.com/logsene) — Kostenlos bis zu 500 MB/Tag, sieben Tage Aufbewahrung.
  * [sumologic.com](https://www.sumologic.com/) — Kostenlos bis zu 500 MB/Tag, sieben Tage Aufbewahrung.
  * [logflare.app](https://logflare.app/) — Kostenlos bis zu 12.960.000 Einträge pro App und Monat, 3 Tage Aufbewahrung.
  * [logtail.com](https://logtail.com/) — ClickHouse-basierte, SQL-kompatible Log-Verwaltung. Kostenlos bis zu 1 GB pro Monat, drei Tage Aufbewahrung.
  * [logzab.com](https://logzab.com/) — Audit-Trail-Managementsystem. Kostenlos 1.000 Nutzeraktivitäts-Logs pro Monat, 1 Monat Aufbewahrung, für bis zu 5 Projekte.
  * [openobserve.ai](https://openobserve.ai/) – 200 GB Ingestion/Monat kostenlos, 15 Tage Aufbewahrung.
**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Übersetzungsmanagement

  * [crowdin.com](https://crowdin.com/) — Unbegrenzte Projekte, unbegrenzte Strings und Mitwirkende für Open Source
  * [gitlocalize.com](https://gitlocalize.com) - Kostenlos und unbegrenzt für private und öffentliche Repositories
  * [Lecto](https://lecto.ai/) - Machine Translation API mit kostenlosem Tarif (30 kostenlose Anfragen, 1000 übersetzte Zeichen pro Anfrage). Integriert mit dem Loco Translate Wordpress-Plugin.
  * [lingohub.com](https://lingohub.com/) — Kostenlos für bis zu 3 Nutzer, immer kostenlos für Open Source
  * [localazy.com](https://localazy.com) - Kostenlos für 1000 Quellsprache-Strings, unbegrenzte Sprachen, unbegrenzte Mitwirkende, Angebote für Startups und Open Source
  * [Localeum](https://localeum.com) - Kostenlos bis zu 1000 Strings, ein Nutzer, unbegrenzte Sprachen, unbegrenzte Projekte
  * [localizely.com](https://localizely.com/) — Kostenlos für Open Source
  * [Loco](https://localise.biz/) — Kostenlos bis zu 2000 Übersetzungen, unbegrenzt viele Übersetzer, zehn Sprachen/Projekt, 1000 übersetzbare Assets/Projekt
  * [oneskyapp.com](https://www.oneskyapp.com/) — Begrenzte kostenlose Edition für bis zu 5 Nutzer, kostenlos für Open Source
  * [POEditor](https://poeditor.com/) — Kostenlos bis zu 1000 Strings
  * [SimpleLocalize](https://simplelocalize.io/) - Kostenlos bis zu 100 Übersetzungsschlüssel, unbegrenzte Strings, unbegrenzte Sprachen, Angebote für Startups
  * [Texterify](https://texterify.com/) - Kostenlos für einen einzelnen Nutzer
  * [Tolgee](https://tolgee.io) - Kostenlose SaaS-Version mit begrenzten Übersetzungen, für immer kostenlose selbstgehostete Version
  * [transifex.com](https://www.transifex.com/) — Kostenlos für Open Source
  * [Translation.io](https://translation.io) - Kostenlos für Open Source
  * [Translized](https://translized.com) - Kostenlos bis zu 1000 Strings, ein Nutzer, unbegrenzte Sprachen, unbegrenzte Projekte
  * [webtranslateit.com](https://webtranslateit.com/) — Kostenlos bis zu 500 Strings
  * [weblate.org](https://weblate.org/) — Kostenlos für freie Projekte mit bis zu 10.000 String-Quellen im kostenlosen Tarif und unbegrenzt bei selbstgehosteter On-Premises-Lösung.
  * [Free PO editor](https://pofile.net/free-po-editor) — Für alle kostenlos
  * [Lingo.dev](https://lingo.dev) – Open-Source, KI-basierte CLI für Web- & Mobile-Lokalisierung. Eigene LLM nutzen oder 10.000 kostenlose Wörter pro Monat über die Lingo.dev-eigene Lokalisierungs-Engine verwenden.

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Monitoring

  * [UptimeObserver.com](https://uptimeobserver.com) - 20 Uptime-Monitore mit 5-Minuten-Intervallen und anpassbarer Statusseite – auch für kommerzielle Nutzung. Unbegrenzte, Echtzeit-Benachrichtigungen per E-Mail und Telegram. Keine Kreditkarte erforderlich.
  * [Pingmeter.com](https://pingmeter.com/) - 5 Uptime-Monitore mit 10-Minuten-Intervall. Überwacht SSH, HTTP, HTTPS und beliebige benutzerdefinierte TCP-Ports.
  * [alerty.ai](https://www.alerty.ai) - Kostenlose APM und Überwachung für FE, BE, DB und mehr + kostenlose Agent-Läufe.
  * [appdynamics.com](https://www.appdynamics.com/) — Kostenlos für 24-Stunden-Metriken, Application Performance Management Agents limitiert auf einen Java-, einen .NET-, einen PHP- und einen Node.js-Agent
  * [appneta.com](https://www.appneta.com/) — Kostenlos mit 1 Stunde Datenaufbewahrung
  * [appspector.com](https://appspector.com/) - Mission Control für Remote-iOS/Android/Flutter-Debugging. Kostenlos für geringen Traffic (64 MB Logs).
  * [assertible.com](https://assertible.com) — Automatisiertes API-Testing und Monitoring. Kostenlose Pläne für Teams und Einzelpersonen.
  * [bleemeo.com](https://bleemeo.com) - Kostenlos für 3 Server, 5 Uptime-Monitore, unbegrenzte Nutzer, unbegrenzte Dashboards, unbegrenzte Alarmierungsregeln.
  * [Core Web Vitals History](https://punits.dev/core-web-vitals-historical/) - Historie der Core Web Vitals für eine URL oder Website abrufen.
  * [checklyhq.com](https://checklyhq.com) - Open Source E2E-/synthetisches Monitoring und tiefgehendes API-Monitoring für Entwickler. Kostenloser Plan mit einem Nutzer und 10.000 API- & Netzwerk-/1.500 Browser-Check-Läufen.
  * [cloudsploit.com](https://cloudsploit.com) — AWS-Sicherheits- und Konfigurationsüberwachung. Kostenlos: unbegrenzte On-Demand-Scans, unbegrenzte Nutzer, unbegrenzte gespeicherte Konten. Abonnement: Automatisierte Scans, API-Zugang, etc.
  * [cronitor.io](https://cronitor.io/) - Performance-Insights und Uptime-Monitoring für Cronjobs, Websites, APIs und mehr. Kostenloses Kontingent mit fünf Monitoren.
  * [datadoghq.com](https://www.datadoghq.com/) — Kostenlos für bis zu 5 Nodes
  * [deadmanssnitch.com](https://deadmanssnitch.com/) — Überwachung von Cronjobs. Ein kostenloser Snitch (Monitor), mehr bei Empfehlung weiterer Nutzer
  * [downtimemonkey.com](https://downtimemonkey.com/) — 60 Uptime-Monitore, 5-Minuten-Intervall. E-Mail-, Slack-Benachrichtigungen.
  * [economize.cloud](https://economize.cloud) — Economize hilft, Cloud-Infrastrukturkosten zu verstehen, indem Cloud-Ressourcen organisiert, optimiert und berichtet werden. Kostenlos für bis zu 5.000 $ Google Cloud Platform-Ausgaben pro Monat.
  * [elastic.co](https://www.elastic.co/solutions/apm) — Sofortige Performance-Insights für JS-Entwickler. Kostenlos mit 24 Stunden Datenaufbewahrung
  * [fivenines.io](https://fivenines.io/) — Linux-Server-Monitoring mit Echtzeit-Dashboards und Alerting – für immer kostenlos für bis zu 5 überwachte Server im 60-Sekunden-Intervall. Keine Kreditkarte erforderlich.
  * [Grafana Cloud](https://grafana.com/products/cloud/) - Grafana Cloud ist eine offene Observability-Plattform, die Metriken und Logs mit Grafana integriert. Kostenlos: 3 Nutzer, zehn Dashboards, 100 Alerts, Metrikspeicherung in Prometheus und Graphite (10.000 Serien, 14 Tage Aufbewahrung), Logspeicherung in Loki (50 GB Logs, 14 Tage Aufbewahrung)
  * [healthchecks.io](https://healthchecks.io) — Überwacht Ihre Cronjobs und Hintergrundaufgaben. Kostenlos für bis zu 20 Checks.
  * [Hydrozen.io](https://hydrozen.io) — Uptime-Monitoring & Statusseiten, kostenloser Plan: 10 Uptime-Monitore, 5 Heartbeat-Monitore, 1 Domain-Monitor und 1 Statuspage kostenlos.
  * [incidenthub.cloud](https://incidenthub.cloud/) — Cloud- und SaaS-Statusseiten-Aggregator - 20 Monitore und 2 Benachrichtigungskanäle (Slack und Discord) dauerhaft kostenlos.
  * [inspector.dev](https://www.inspector.dev) - Vollständiges Echtzeit-Monitoring-Dashboard in weniger als einer Minute mit kostenloser Dauerstufe.
  * [instrumentalapp.com](https://instrumentalapp.com) - Schöne und einfach zu bedienende Anwendungs- und Serverüberwachung mit bis zu 500 Metriken und 3 Stunden Datenansicht kostenlos
  * [keychest.net/speedtest](https://keychest.net/speedtest) - Unabhängiger Speedtest und TLS-Handshake-Latenztest gegen Digital Ocean
  * [letsmonitor.org](https://letsmonitor.org) - SSL-Monitoring, kostenlos für bis zu 5 Monitore
  * [linkok.com](https://linkok.com) - Online-Broken-Link-Checker, kostenlos für kleine Websites bis zu 100 Seiten, völlig kostenlos für Open-Source-Projekte.
  * [loader.io](https://loader.io/) — Kostenloses Lasttest-Tool mit Einschränkungen
  * [MonitorMonk](https://monitormonk.com) - Minimalistisches Uptime-Monitoring mit schönen Statusseiten. Der Forever-Free-Plan bietet HTTPS-, Keyword-, SSL- und Response-Time-Monitoring für 10 Websites oder API-Endpunkte sowie 2 Dashboards/Statusseiten.
  * [netdata.cloud](https://www.netdata.cloud/) — Netdata ist ein Open-Source-Tool zur Sammlung von Echtzeitmetriken. Das Produkt wächst und ist auch auf GitHub verfügbar!
  * [newrelic.com](https://www.newrelic.com) — New Relic Observability-Plattform, entwickelt, um Ingenieuren zu helfen, perfektere Software zu erstellen. Von Monolithen bis Serverless kann alles instrumentiert und dann analysiert, Fehler behoben und der gesamte Software-Stack optimiert werden. Die kostenlose Stufe bietet 100 GB/Monat kostenlose Datenaufnahme, einen kostenlosen Full-Access-User und unbegrenzt viele kostenlose Hauptnutzer.
  * [Middleware.io](https://middleware.io/) - Die Middleware Observability-Plattform bietet vollständige Transparenz in Ihre Apps & Ihren Stack, sodass Sie Probleme im großen Maßstab überwachen & diagnostizieren können. Sie haben einen dauerhaft kostenlosen Plan für die Dev-Community, der Log-Monitoring für bis zu 1 Mio. Log-Events, Infrastrukturüberwachung & APM für bis zu 2 Hosts ermöglicht.
  * [nixstats.com](https://nixstats.com) - Kostenlos für einen Server. E-Mail-Benachrichtigungen, öffentliche Statusseite, 60-Sekunden-Intervall und mehr.
  * [OnlineOrNot.com](https://onlineornot.com/) - OnlineOrNot bietet Uptime-Monitoring für Websites und APIs, Überwachung von Cronjobs und geplanten Aufgaben. Bietet auch Statusseiten. Die ersten fünf Checks mit 3-Minuten-Intervall sind kostenlos. Der kostenlose Tarif sendet Benachrichtigungen über Slack, Discord und E-Mail.
  * [OntarioNet.ca CN Test](https://cntest.ontarionet.ca) — Prüft, ob eine Website in China durch die Great Firewall blockiert wird. DNS-Verschmutzung wird erkannt, indem DNS-Ergebnisse und ASN-Informationen von Servern in China mit denen in den USA verglichen werden.
  * [opsgenie.com](https://www.opsgenie.com/) — Leistungsstarke Alarmierung und Bereitschaftsverwaltung für den Betrieb stets verfügbarer Dienste. Kostenlos für bis zu 5 Nutzer.
  * [paessler.com](https://www.paessler.com/) — Leistungsstarke Infrastruktur- und Netzwerküberwachung, inkl. Alarmierung, starker Visualisierung und Basis-Reporting. Kostenlos für bis zu 100 Sensoren.
  * [pagecrawl.io](https://pagecrawl.io/) -  Überwacht Website-Änderungen, kostenlos für bis zu 6 Monitore mit täglichen Checks.
  * [syagent.com](https://syagent.com/) — Nicht-kommerzieller kostenloser Server-Monitoring-Dienst, Alarme und Metriken.
  * [pagerly.io](https://pagerly.io/) -  Bereitschaftsverwaltung in Slack (integriert mit Pagerduty, OpsGenie). Kostenlos für 1 Team (ein Team entspricht einer Bereitschaft)
  * [pagertree.com](https://pagertree.com/) - Einfache Oberfläche für Alarmierung und Bereitschaftsmanagement. Kostenlos für bis zu 5 Nutzer.
  * [phare.io](https://phare.io/) - Uptime-Monitoring kostenlos für bis zu 100.000 Events für unbegrenzte Projekte und unbegrenzte Statusseiten.
  * [pingbreak.com](https://pingbreak.com/) — Modernes Uptime-Monitoring. Unbegrenzte URLs prüfen und Downtime-Benachrichtigungen per Discord, Slack oder E-Mail erhalten.
  * [pingpong.one](https://pingpong.one/) — Erweiterte Statusseitenplattform mit Monitoring. Die kostenlose Stufe beinhaltet eine öffentliche, anpassbare Statusseite mit SSL-Subdomain. Pro-Tarif wird für Open-Source-Projekte und gemeinnützige Organisationen kostenlos angeboten.
  * [robusta.dev](https://home.robusta.dev/) — Leistungsstarkes Kubernetes-Monitoring auf Basis von Prometheus. Eigenen Prometheus mitbringen oder das All-in-One-Paket installieren. Die kostenlose Stufe beinhaltet bis zu 20 Kubernetes-Nodes. Alarmierungen via Slack, Microsoft Teams, Discord und mehr. Integrationen mit PagerDuty, OpsGenie, VictorOps, DataDog und vielen weiteren Tools.
  * [sematext.com](https://sematext.com/) — Kostenlos für 24-Stunden-Metriken, unbegrenzte Server, zehn benutzerdefinierte Metriken, 500.000 benutzerdefinierte Metrikdatenpunkte, unbegrenzte Dashboards, Nutzer usw.
  * [sitemonki.com](https://sitemonki.com/) — Website-, Domain-, Cron- & SSL-Monitoring, 5 Monitore in jeder Kategorie kostenlos
  * [sitesure.net](https://sitesure.net) - Website- und Cron-Monitoring – 2 Monitore kostenlos
  * [skylight.io](https://www.skylight.io/) — Kostenlos für die ersten 100.000 Requests (nur Rails)
  * [speedchecker.xyz](https://probeapi.speedchecker.xyz/) — Performance-Monitoring-API, prüft Ping, DNS, etc.
  * [stathat.com](https://www.stathat.com/) — Mit zehn Statistiken kostenlos loslegen, kein Ablaufdatum
  * [statuscake.com](https://www.statuscake.com/) — Website-Monitoring, unbegrenzte Tests kostenlos mit Einschränkungen
  * [statusgator.com](https://statusgator.com/) — Statusseiten-Monitoring, 3 Monitore kostenlos
  * [SweetUptime](https://dicloud.net/sweetuptime-server-uptime-monitoring/) — Server-Monitoring, Uptime-Monitoring, DNS- & Domain-Monitoring. Überwacht 10 Server, 10 Uptime und 10 Domains kostenlos.
  * [thousandeyes.com](https://www.thousandeyes.com/) — Netzwerk- und Nutzererfahrungsüberwachung. 3 Standorte und 20 Datenfeeds wichtiger Webdienste kostenlos
  * [uptimetoolbox.com](https://uptimetoolbox.com/) — Kostenloses Monitoring für fünf Websites, 60-Sekunden-Intervalle, öffentliche Statusseite.
  * [zenduty.com](https://www.zenduty.com/) — End-to-End-Incident-Management, Alarmierung, Bereitschaftsmanagement und Response-Orchestrierung für Netzwerkbetrieb, Site Reliability Engineering und DevOps-Teams. Kostenlos für bis zu 5 Nutzer.
  * [instatus.com](https://instatus.com) - In nur 10 Sekunden eine schöne Statusseite. Für immer kostenlos mit unbegrenzten Abonnenten und unbegrenzten Teams.
  * [Squadcast.com](https://squadcast.com) - Squadcast ist eine End-to-End-Incident-Management-Software zur Förderung von SRE-Best-Practices. Dauerhaft kostenloser Plan für bis zu 10 Nutzer.
  * [RoboMiri.com](https://robomiri.com/) - RoboMiri ist ein stabiles Uptime-Monitor mit breitem Monitoringspektrum: Cronjob, Keyword, Website, Port, Ping. 25 Uptime-Checks mit 3-Minuten-Intervall kostenlos. Alarme via Telefonanruf, SMS, E-Mail und Webhooks.
  * [Better Stack](https://betterstack.com/better-uptime) - Uptime-Monitoring, Incident-Management, Bereitschaftsplanung/-alarmierung und Statusseiten in einem Produkt. Der kostenlose Plan umfasst zehn Monitore mit 3-Minuten-Prüfintervall und Statusseiten.
  * [Pulsetic](https://pulsetic.com) - 10 Monitore, 6 Monate historische Uptime/Logs, unbegrenzte Statusseiten und eigene Domains inklusive! Für unbegrenzte Zeit und unbegrenzte E-Mail-Benachrichtigungen kostenlos. Keine Kreditkarte nötig.
  * [Wachete](https://www.wachete.com) - Überwacht fünf Seiten, prüft alle 24 Stunden.
  * [Xitoring.com](https://xitoring.com/) — Uptime-Monitoring: 20 kostenlos, Linux- und Windows-Server-Monitoring: 5 kostenlos, Statusseite: 1 kostenlos – Mobile App, mehrere Benachrichtigungskanäle und vieles mehr!
  * [Servervana](https://servervana.com) - Fortgeschrittenes Uptime-Monitoring mit Support für große Projekte und Teams. Bietet HTTP-Monitoring, Browser-basiertes Monitoring, DNS-Monitoring, Domain-Monitoring, Statusseiten und mehr. Die kostenlose Stufe beinhaltet 10 HTTP-Monitore, 1 DNS-Monitor und eine Statusseite.

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Crash- und Exception-Handling
* [CatchJS.com](https://catchjs.com/) – JavaScript-Fehlerverfolgung mit Screenshots und Klickpfaden. Kostenlos für Open-Source-Projekte.
* [bugsnag.com](https://www.bugsnag.com/) — Kostenlos bis zu 2.000 Fehler/Monat nach der ersten Testphase
* [elmah.io](https://elmah.io/) – Fehlerprotokollierung und Uptime-Überwachung für Webentwickler. Kostenloses Small-Business-Abonnement für Open-Source-Projekte.
* [Embrace](https://embrace.io/) – Mobile App Monitoring. Kostenlos für kleine Teams mit bis zu 1 Million Nutzersitzungen pro Jahr.
* [exceptionless](https://exceptionless.com) – Echtzeit-Fehler-, Feature- und Log-Reporting und mehr. Kostenlos für 3.000 Events pro Monat/1 Benutzer. Open Source und leicht selbst zu hosten für unbegrenzte Nutzung.
* [GlitchTip](https://glitchtip.com/) – Einfache, Open-Source-Fehlerverfolgung. Kompatibel mit den Open-Source-Sentry-SDKs. 1.000 Events pro Monat kostenlos, alternativ unbegrenzt beim Selbsthosting
* [honeybadger.io](https://www.honeybadger.io) – Exception-, Uptime- und Cron-Monitoring. Kostenlos für kleine Teams und Open-Source-Projekte (12.000 Fehler/Monat).
* [memfault.com](https://memfault.com) — Cloud-Plattform für Gerätebeobachtung und Debugging. 100 Geräte kostenlos für [Nordic](https://app.memfault.com/register-nordic), [NXP](https://app.memfault.com/register-nxp) und [Laird](https://app.memfault.com/register-laird) Geräte.
* [rollbar.com](https://rollbar.com/) – Exception- und Fehlerüberwachung, kostenloser Plan mit 5.000 Fehlern/Monat, unbegrenzte Nutzer, 30 Tage Aufbewahrung
* [sentry.io](https://sentry.io/) – Sentry verfolgt App-Exceptions in Echtzeit und bietet einen kleinen kostenlosen Plan. Kostenlos für 5.000 Fehler pro Monat/1 Benutzer, unbegrenzte Nutzung beim Selbsthosting
* [Axiom](https://axiom.co/) – Speichere bis zu 0,5 TB Logs mit 30 Tagen Aufbewahrung. Inklusive Integrationen mit Plattformen wie Vercel und fortschrittlicher Datenabfrage mit E-Mail/Discord-Benachrichtigungen.
* [Semaphr](https://semaphr.com) – Kostenloser All-in-one-Killswitch für deine mobilen Apps.
* [Jam](https://jam.dev) – Entwicklerfreundliche Fehlerberichte mit einem Klick. Kostenloser Plan mit unbegrenzten Jams.
* [Whitespace](https://whitespace.dev) – Fehlerberichte mit einem Klick direkt im Browser. Kostenloser Plan mit unbegrenzten Aufnahmen für den persönlichen Gebrauch.

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Suche

* [algolia.com](https://www.algolia.com/) – Gehostete Suchlösung mit Tippfehler-Toleranz, Relevanz und UI-Bibliotheken zur einfachen Erstellung von Sucherlebnissen. Der kostenlose „Build“-Plan umfasst 1 Mio. Dokumente und 10.000 Suchen/Monat. Bietet außerdem kostenlose [Entwicklerdokumentationssuche](https://docsearch.algolia.com/) an.
* [bonsai.io](https://bonsai.io/) – Kostenlos 1 GB Speicher und 1 GB RAM
* [CommandBar](https://www.commandbar.com/) – Vereinheitlichte Suchleiste als Service, webbasiertes UI-Widget/Plugin, das es deinen Nutzern ermöglicht, Inhalte, Navigationen, Features usw. innerhalb deines Produkts zu durchsuchen und so die Auffindbarkeit verbessert. Kostenlos für bis zu 1.000 monatlich aktive Nutzer, unbegrenzte Befehle.
* [Orama Cloud](https://orama.com/pricing) – Kostenlos 3 Indizes, 100.000 Dokumente/Index, unbegrenzte Volltext-/Vektor-/Hybrid-Suchen, 60 Tage Analytics
* [searchly.com](http://www.searchly.com/) – Kostenlos 2 Indizes und 20 MB Speicher
* [easysitesearch.com](https://easysitesearch.com/) – Such-Widget und API, mit automatischer webcrawler-basierter Indexierung. Unbegrenzte Suchanfragen kostenlos für bis zu 50 Unterseiten.

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Bildung und Karriereentwicklung

* [FreeCodeCamp](https://www.freecodecamp.org/) – Open-Source-Plattform mit kostenlosen Kursen und Zertifikaten in Datenanalyse, Informationssicherheit, Webentwicklung und mehr.
* [The Odin Project](https://www.theodinproject.com/) – Kostenlose Open-Source-Plattform mit Lehrplan, der sich auf JavaScript und Ruby für Webentwicklung konzentriert.
* [Free Professional Resume Templates & Editor](https://www.overleaf.com/latex/templates/tagged/cv) – Kostenlose Plattform mit vielen Lebenslauf-Vorlagen erfahrener Fachkräfte, bereit zum Klonen, vollständigen Bearbeiten und Herunterladen, ATS-optimiert.
* [DeepLearning.AI Short Courses](https://www.deeplearning.ai/short-courses/) – Kostenlose Kurzkurse von führenden Branchenexperten für praktische Erfahrung mit den neuesten generativen KI-Tools und -Techniken in einer Stunde oder weniger.
* [LabEx](https://labex.io) – Entwickle Fähigkeiten in Linux, DevOps, Cybersicherheit, Programmierung, Data Science und mehr durch interaktive Labs und praxisnahe Projekte.
* [Roadmap.sh](https://roadmap.sh) – Kostenlose Lern-Roadmaps, die alle Aspekte der Entwicklung abdecken, von Blockchain bis UX-Design.
* [Cisco Networking Academy, Skills for All](https://skillsforall.com/) – Bietet kostenlose, zertifikatsorientierte Kurse zu Themen wie Cybersicherheit, Netzwerke und Python.
* [MIT OpenCourseWare](https://ocw.mit.edu/) – MIT OpenCourseWare ist eine Online-Veröffentlichung von Materialien aus über 2.500 MIT-Kursen, die Wissen weltweit kostenlos mit Lernenden und Lehrenden teilt. Der Youtube-Kanal ist unter [@mitocw](https://www.youtube.com/@mitocw/featured) zu finden.
* [W3Schools](https://www.w3schools.com/) – Kostenlose Tutorials zu Webentwicklungstechnologien wie HTML, CSS, JavaScript und mehr.
* [Khan Academy](https://www.khanacademy.org/computing/computer-programming) – Kostenlose Online-Guides zum Erlernen von grundlegenden und fortgeschrittenen HTML/CSS-, JavaScript- und SQL-Kenntnissen.
* [Full Stack Open](https://fullstackopen.com/en/) – Kostenloser Hochschulkurs über moderne Webentwicklung mit React, Node.js, GraphQL, TypeScript und mehr. Komplett online und im eigenen Tempo.
* [edX](https://www.edx.org/) – Bietet Zugang zu über 4.000 kostenlosen Online-Kursen von 250 führenden Institutionen, darunter Harvard und MIT, mit Schwerpunkt auf Informatik, Ingenieurwesen und Data Science.
* [Django-tutorial.dev](https://django-tutorial.dev) – Kostenlose Online-Guides zum Erlernen von Django als erstem Framework & bietet kostenlosen Dofollow-Backlink zu von Nutzern verfassten Artikeln.

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## E-Mail

* [10minutemail](https://10minutemail.com) – Kostenlos, temporäre E-Mail zum Testen.
* [AhaSend](https://ahasend.com) – Transaktionaler E-Mail-Dienst, kostenlos für 1.000 E-Mails pro Monat, mit unbegrenzten Domains, Teammitgliedern, Webhooks und Nachrichtenrouten im kostenlosen Plan.
* [AnonAddy](https://anonaddy.com) – Open-Source anonyme E-Mail-Weiterleitung, unbegrenzt viele E-Mail-Aliase kostenlos erstellen
* [Antideo](https://www.antideo.com) — 10 API-Anfragen pro Stunde zur E-Mail-Verifizierung, IP- und Telefonnummernvalidierung im kostenlosen Tarif. Keine Kreditkarte erforderlich.
* [Brevo](https://www.brevo.com/) — 9.000 E-Mails/Monat, 300 E-Mails/Tag kostenlos
* [OneSignal](https://onesignal.com/) — 10.000 E-Mails/Monat, keine Kreditkarte erforderlich.
* [Bump](https://bump.email/) – Kostenlos 10 Bump-E-Mail-Adressen, eine eigene Domain
* [Burnermail](https://burnermail.io/) – Kostenlos 5 Burner-E-Mail-Adressen, 1 Postfach, 7 Tage Postfach-Historie
* [Buttondown](https://buttondown.email/) — Newsletter-Service. Bis zu 100 Abonnenten kostenlos
* [CloudMailin](https://www.cloudmailin.com/) – Eingehende E-Mails via HTTP POST und transaktionaler Versand – 10.000 kostenlose E-Mails/Monat
* [Contact.do](https://contact.do/) — Kontaktformular in einem Link (bitly für Kontaktformulare)
* [debugmail.io](https://debugmail.io/) — Einfach zu verwendender Test-Mailserver für Entwickler
* [DNSExit](https://dnsexit.com/) – Bis zu 2 E-Mail-Adressen unter deiner Domain kostenlos mit 100MB Speicherplatz. IMAP, POP3, SMTP, SPF/DKIM-Unterstützung.
* [EmailLabs.io](https://emaillabs.io/en) — Bis zu 9.000 E-Mails pro Monat kostenlos, bis zu 300 E-Mails täglich.
* [EmailOctopus](https://emailoctopus.com) – Bis zu 2.500 Abonnenten und 10.000 E-Mails pro Monat kostenlos
* [EmailJS](https://www.emailjs.com/) – Dies ist kein kompletter Mailserver; nur ein E-Mail-Client, mit dem du E-Mails direkt aus dem Client senden kannst, ohne deine Zugangsdaten preiszugeben. Der kostenlose Tarif beinhaltet 200 monatliche Anfragen, 2 E-Mail-Vorlagen, Anfragen bis 50 KB, eingeschränkte Kontakt-Historie.
* [EtherealMail](https://ethereal.email) – Ethereal ist ein Fake-SMTP-Dienst, hauptsächlich für Nodemailer- und EmailEngine-Nutzer (aber nicht darauf beschränkt). Es ist ein vollständig kostenloser, anti-transaktionaler E-Mail-Dienst, bei dem Nachrichten nie zugestellt werden.
* [Temp-Mail.org](https://temp-mail.org/en/) – Temporäre/Wegwerf-Mail-Generierung mit einer Vielzahl von Domains. Die E-Mail-Adresse wird bei jedem Neuladen der Seite aktualisiert. Vollständig kostenlos, keine Preisgestaltung für die Dienste.
* [TempMailDetector.com](https://tempmaildetector.com/) – Überprüfe bis zu 200 E-Mails pro Monat kostenlos und sieh nach, ob eine E-Mail temporär ist.
* [Emailvalidation.io](https://emailvalidation.io) – 100 kostenlose E-Mail-Verifizierungen pro Monat
* [FakeMailGenerator.com](https://www.fakemailgenerator.com/) – Ein deutscher temporärer/Wegwerf-Mail-Generator. Unterstützt 10 Domains, erlaubt unbegrenzt viele Adressen. (Werbung enthalten), aber ansonsten ist der Dienst vollständig kostenlos.
* [forwardemail.net](https://forwardemail.net) — Kostenlose E-Mail-Weiterleitung für eigene Domains. Erstelle und leite unbegrenzt viele E-Mail-Adressen mit deinem Domainnamen weiter (**Hinweis**: Bei TLDs wie .casa, .cf, .click, .email, .fit, .ga, .gdn, .gq, .lat, .loan, .london, .men, .ml, .pl, .rest, .ru, .tk, .top, .work ist eine Gebühr wegen Spam fällig)
* [Imitate Email](https://imitate.email) – Sandbox-Mailserver zum Testen von E-Mail-Funktionen in Build/QA und CI/CD. Kostenlose Konten erhalten 15 E-Mails pro Tag, für immer.
* [ImprovMX](https://improvmx.com) – Kostenlose E-Mail-Weiterleitung.
* [EForw](https://www.eforw.com) – Kostenlose E-Mail-Weiterleitung für eine Domain. E-Mails empfangen und senden von deiner Domain.
* [Inboxes App](https://inboxesapp.com) — Bis zu 3 temporäre E-Mails pro Tag erstellen und nach Gebrauch löschen – direkt aus einer praktischen Chrome-Erweiterung. Perfekt zum Testen von Registrierungsabläufen.
* [inboxkitten.com](https://inboxkitten.com/) – Kostenloser temporärer/wegwerfbarer E-Mail-Posteingang, mit automatischer Löschung nach bis zu 3 Tagen. Open Source und selbst hostbar.
* [mail-tester.com](https://www.mail-tester.com) — Prüfe, ob die DNS/SPF/DKIM/DMARC-Einstellungen deiner E-Mail korrekt sind, 20 kostenlos/Monat.
* [dkimvalidator.com](https://dkimvalidator.com/) – Prüfe, ob die DNS/SPF/DKIM/DMARC-Einstellungen deiner E-Mail korrekt sind, kostenloser Service von roundsphere.com
* [mailcatcher.me](https://mailcatcher.me/) – Fängt E-Mails ab und stellt sie über eine Weboberfläche bereit.
* [mailchannels.com](https://www.mailchannels.com) – E-Mail-API mit REST-API und SMTP-Integrationen, kostenlos bis zu 3.000 E-Mails/Monat.
* [Mailcheck.ai](https://www.mailcheck.ai/) – Verhindert die Registrierung mit temporären E-Mail-Adressen, 120 Anfragen/Stunde (~86.400 pro Monat)
* [Mailchimp](https://mailchimp.com/) — 500 Abonnenten und 1.000 E-Mails/Monat kostenlos.
* [Maildroppa](https://maildroppa.com) – Bis zu 100 Abonnenten und unbegrenzt viele E-Mails sowie Automatisierungen kostenlos.
* [MailerLite.com](https://www.mailerlite.com) — 1.000 Abonnenten/Monat, 12.000 E-Mails/Monat kostenlos
* [MailerSend.com](https://www.mailersend.com) — E-Mail-API, SMTP, 3.000 E-Mails/Monat kostenlos für transaktionale E-Mails
* [mailinator.com](https://www.mailinator.com/) – Kostenloses, öffentliches E-Mail-System, bei dem du beliebige Postfächer verwenden kannst
* [Mailjet](https://www.mailjet.com/) — 6.000 E-Mails/Monat kostenlos (200 E-Mails tägliches Versandlimit)
* [Mailnesia](https://mailnesia.com) – Kostenlose temporäre/wegwerfbare E-Mail, die automatisch Registrierungslinks besucht.
* [mailsac.com](https://mailsac.com) – Kostenlose API für temporäre E-Mail-Tests, kostenloses öffentliches E-Mail-Hosting, Outbound-Capture, E-Mail-zu-Slack/Websocket/Webhook (1.500 monatliches API-Limit)
* [Mailtrap.io](https://mailtrap.io/) — Fake-SMTP-Server für Entwicklung, kostenloser Plan mit einem Postfach, 100 Nachrichten, kein Teammitglied, zwei E-Mails/Sekunde, keine Weiterleitungsregeln.
* [Mail7.io](https://www.mail7.io/) — Kostenlose temporäre E-Mail-Adressen für QA-Entwickler. E-Mail-Adressen sofort per Weboberfläche oder API erstellen.
* [Momentary Email](https://www.momentaryemail.com/) — Kostenlose temporäre E-Mail-Adressen. Eingehende E-Mails auf der Website oder per RSS-Feed lesen.
* [Mutant Mail](https://www.mutantmail.com/) – Kostenlos 10 E-Mail-IDs, 1 Domain, 1 Postfach. Ein Postfach für alle E-Mail-IDs.
* [Outlook.com](https://outlook.live.com/owa/) – Kostenloses persönliches E-Mail-Postfach und Kalender.
* [Parsio.io](https://parsio.io) — Kostenloser E-Mail-Parser (E-Mail weiterleiten, Daten extrahieren, an deinen Server senden)
* [pepipost.com](https://pepipost.com) — 30.000 E-Mails im ersten Monat kostenlos, danach die ersten 100 E-Mails/Tag kostenlos.
* [Plunk](https://useplunk.com) – 3.000 E-Mails/Monat kostenlos
* [Postmark](https://postmarkapp.com/) – 100 E-Mails/Monat kostenlos, unbegrenzte DMARC-Wochenberichte.
* [Proton Mail](https://proton.me/mail) – Kostenloser, sicherer E-Mail-Anbieter mit eingebauter Ende-zu-Ende-Verschlüsselung. 1 GB Speicherplatz kostenlos.
* [Queuemail.dev](https://queuemail.dev) — Zuverlässige E-Mail-Delivery-API. Kostenloses Kontingent (10.000 E-Mails/Monat). Asynchrones Senden. Verwendung mehrerer SMTP-Server. Blocklisten, Logging, Tracking, Webhooks und mehr.
* [QuickEmailVerification](https://quickemailverification.com) — Täglich 100 E-Mail-Verifizierungen kostenlos im Free-Tarif sowie weitere kostenlose APIs wie DEA Detector, DNS Lookup, SPF Detector und mehr.
* [Resend](https://resend.com) – Transaktionale E-Mail-API für Entwickler. 3.000 E-Mails/Monat, 100 E-Mails/Tag kostenlos, eine benutzerdefinierte Domain.
* [Sender](https://www.sender.net) – Bis zu 15.000 E-Mails/Monat, bis zu 2.500 Abonnenten.
* [Sendpulse](https://sendpulse.com) – 500 Abonnenten/Monat, 15.000 E-Mails/Monat kostenlos.
* [SimpleLogin](https://simplelogin.io/) – Open Source, selbst hostbare Lösung für E-Mail-Alias/Weiterleitung. Kostenlos 5 Aliase, unbegrenzte Bandbreite, unbegrenzt Antworten/Senden. Kostenlos für Bildungspersonal (Student, Forscher usw.).
* [Substack](https://substack.com) – Unbegrenzter kostenloser Newsletter-Service. Bezahlen erst, wenn Sie Gebühren erheben.
* [Sweego](https://www.sweego.io/) – Europäische transaktionale E-Mail-API für Entwickler. 500 E-Mails/Tag kostenlos.
* [Takeout](https://takeout.bysourfruit.com) – Ein ständig aktualisierter E-Mail-Dienst, der das Versenden von E-Mails einfach macht. Fünfhundert transaktionale E-Mails/Monat kostenlos.
* [temp-mail.io](https://temp-mail.io) – Kostenloser, temporärer Wegwerf-E-Mail-Dienst mit mehreren gleichzeitigen E-Mails und Weiterleitung.
* [tinyletter.com](https://tinyletter.com/) – 5.000 Abonnenten/Monat kostenlos.
* [Touchlead](https://touchlead.app) – Ein vielseitiges Marketing-Automatisierungstool mit Lead-Management, Formular-Builder und Automatisierung. Kostenlos für eine begrenzte Anzahl an Leads und Automatisierungen.
* [trashmail.com](https://www.trashmail.com) – Kostenlose Wegwerf-E-Mail-Adressen mit Weiterleitung und automatischem Ablauf der Adresse.
* [Tuta](https://tuta.com/) – Kostenlose, sichere E-Mail-Konten mit eingebauter Ende-zu-Ende-Verschlüsselung, keine Werbung, kein Tracking. Kostenlos 1 GB Speicher, ein Kalender (Tuta bietet auch einen [kostenpflichtigen Tarif](https://tuta.com/pricing) an). Tuta ist zudem teilweise [Open Source](https://github.com/tutao/tutanota), sodass Selbsthosting möglich ist.
* [Verifalia](https://verifalia.com/email-verification-api) – Echtzeit-E-Mail-Verifizierungs-API mit Postfach-Bestätigung und Erkennung von Wegwerf-E-Mail-Adressen; 25 kostenlose E-Mail-Verifizierungen/Tag.
* [verimail.io](https://verimail.io/) – Bulk- und API-E-Mail-Verifizierungsdienst. 100 kostenlose Verifizierungen/Monat.
* [Zoho](https://www.zoho.com) – Ursprünglich E-Mail-Anbieter, nun eine Suite von Diensten, von denen einige kostenlose Tarife haben. Liste der Dienste mit kostenlosen Tarifen:
   - [Email](https://zoho.com/mail) Kostenlos für 5 Benutzer. 5 GB/Benutzer & 25 MB Anhangsgröße, eine Domain.
   - [Zoho Assist](https://www.zoho.com/assist) – Der dauerhaft kostenlose Plan von Zoho Assist beinhaltet eine gleichzeitige Fernunterstützungslizenz und Zugriff auf 5 unbeaufsichtigte Computerlizenzen für unbegrenzte Dauer, verfügbar für professionelle und private Nutzung.
   - [Sprints](https://zoho.com/sprints) Kostenlos für 5 Benutzer, 5 Projekte & 500 MB Speicher.
   - [Docs](https://zoho.com/docs) – Kostenlos für 5 Benutzer mit 1 GB Upload-Limit & 5 GB Speicher. Zoho Office Suite (Writer, Sheets & Show) ist enthalten.
   - [Projects](https://zoho.com/projects) – Kostenlos für 3 Benutzer, 2 Projekte & 10 MB Anhangsgröße. Gleicher Plan gilt für [Bugtracker](https://zoho.com/bugtracker).
   - [Connect](https://zoho.com/connect) – Team-Kollaboration kostenlos für 25 Benutzer mit drei Gruppen, drei benutzerdefinierten Apps, 3 Boards, 3 Handbüchern und 10 Integrationen sowie Kanälen, Events & Foren.
   - [Meeting](https://zoho.com/meeting) – Meetings mit bis zu 3 Teilnehmern & 10 Webinar-Teilnehmern.
   - [Vault](https://zoho.com/vault) – Passwortverwaltung für Einzelpersonen zugänglich.
   - [Showtime](https://zoho.com/showtime) – Noch eine Meeting-Software für Trainings mit Remote-Sitzungen bis zu 5 Teilnehmern.
   - [Notebook](https://zoho.com/notebook) – Eine kostenlose Alternative zu Evernote.
   - [Wiki](https://zoho.com/wiki) – Kostenlos für drei Benutzer mit 50 MB Speicher, unbegrenzten Seiten, ZIP-Backups, RSS- & Atom-Feed, Zugriffssteuerung & anpassbarem CSS.
   - [Subscriptions](https://zoho.com/subscriptions) – Verwaltung wiederkehrender Abrechnungen kostenlos für 20 Kunden/Abonnements & 1 Benutzer, alle Zahlungsabwicklungen über Zoho. Die letzten 40 Abonnementmetriken werden gespeichert.
   - [Checkout](https://zoho.com/checkout) – Produktabrechnungsmanagement mit 3 Seiten & bis zu 50 Zahlungen.
   - [Desk](https://zoho.com/desk) – Kundensupport-Management mit drei Agenten, privater Wissensdatenbank und E-Mail-Tickets. Integration mit [Assist](https://zoho.com/assist) für einen Remote-Techniker & 5 unbeaufsichtigte Computer.
   - [Cliq](https://zoho.com/cliq) – Team-Chat-Software mit 100 GB Speicher, unbegrenzten Benutzern, 100 Benutzer pro Kanal & SSO.
   - [Campaigns](https://zoho.com/campaigns) – E-Mail-Marketing.
   - [Forms](https://zoho.com/forms) – Formularersteller.
   - [Sign](https://zoho.com/sign) – Papierlose Signaturen.
   - [Surveys](https://zoho.com/surveys) – Online-Umfragen.
   - [Bookings](https://zoho.com/bookings) – Terminplanung.
* [Maileroo](https://maileroo.com) – SMTP-Relay und E-Mail-API für Entwickler. 5.000 E-Mails pro Monat, unbegrenzte Domains, kostenlose E-Mail-Verifizierung, Blacklist-Überwachung, Mail-Tester und mehr.

**[⬆️ Nach oben](#table-of-contents)**

## Feature-Toggle-Management-Plattformen

* [ConfigCat](https://configcat.com) – Entwicklerzentrierter Feature-Flag-Service mit unbegrenzter Teamgröße, exzellentem Support und fairem Preis. Kostenloser Plan bis zu 10 Flags, zwei Umgebungen, 1 Produkt und 5 Millionen Anfragen pro Monat.
* [Flagsmith](https://flagsmith.com) – Features mit Zuversicht veröffentlichen; Verwaltung von Feature-Flags für Web-, Mobil- und Serveranwendungen. Gehostete API nutzen, in der eigenen Cloud bereitstellen oder On-Premise betreiben.
* [GrowthBook](https://growthbook.io) – Open Source Feature-Flag- und A/B-Testing-Anbieter mit eingebauter Bayes’scher Statistik-Engine. Kostenlos für bis zu 3 Nutzer, unbegrenzte Feature-Flags und Experimente.
* [Hypertune](https://www.hypertune.com) – Typsichere Feature-Flags, A/B-Tests, Analytik und App-Konfiguration mit Git-ähnlicher Versionskontrolle und synchroner, im Speicher laufender, lokaler Flag-Auswertung. Kostenlos für bis zu 5 Teammitglieder mit unbegrenzten Feature-Flags und A/B-Tests.
* [Molasses](https://www.molasses.app) – Leistungsstarke Feature-Flags und A/B-Testing. Kostenlos bis zu 3 Umgebungen mit jeweils fünf Feature-Flags.
* [Toggled.dev](https://www.toggled.dev) – Enterprise-taugliche, skalierbare, multiregionale Feature-Toggle-Management-Plattform. Kostenloser Plan bis zu 10 Flags, zwei Umgebungen, unbegrenzte Anfragen. SDK, Analytics-Dashboard, Release-Kalender, Slack-Benachrichtigungen und alle weiteren Funktionen im dauerhaften kostenlosen Tarif enthalten.
* [Statsig](https://www.statsig.com) – Robuste Plattform für Feature-Management, A/B-Testing, Analytik und mehr. Der großzügige kostenlose Plan bietet unbegrenzte Plätze, Flags, Experimente und dynamische Konfigurationen mit Unterstützung für bis zu 1 Million Events pro Monat.
* [Abby](https://www.tryabby.com) – Open-Source Feature-Flags & A/B-Testing. Configuration as Code & vollständig typisierte Typescript-SDKs. Starke Integration mit Frameworks wie Next.js & React. Großzügiges kostenloses Kontingent und günstige Skalierungsoptionen.

**[⬆️ Nach oben](#table-of-contents)**

## Schriftarten

* [dafont](https://www.dafont.com/) – Die auf dieser Website präsentierten Schriftarten sind Eigentum der Autoren und entweder Freeware, Shareware, Demo-Versionen oder Public Domain.
* [Everything Fonts](https://everythingfonts.com/) – Bietet mehrere Tools; @font-face, Einheitenumrechner, Font Hinter und Font Submitter.
* [Font Squirrel](https://www.fontsquirrel.com/) – Freeware-Schriftarten, die für kommerzielle Arbeiten lizenziert sind. Sorgfältig ausgewählte Schriftarten in einem einfach zu verwendenden Format präsentiert.
* [Google Fonts](https://fonts.google.com/) – Viele kostenlose Schriftarten, die einfach und schnell über einen Download oder einen Link zum Google-CDN auf einer Website installiert werden können.
* [FontGet](https://www.fontget.com/) – Bietet eine Vielzahl von Schriftarten zum Download, ordentlich mit Tags sortiert.
* [Fontshare](https://www.fontshare.com/) – Ein kostenloser Schriftarten-Service. Wachsende Sammlung von professionellen Schriftarten, 100% kostenlos für private und kommerzielle Nutzung.
* [Befonts](https://befonts.com/) – Bietet mehrere einzigartige Schriftarten für private oder kommerzielle Nutzung.
* [Font of web](https://fontofweb.com/) – Ermittelt alle auf einer Website verwendeten Schriftarten und deren Verwendung.
* [Bunny](https://fonts.bunny.net) – Datenschutzorientierte Google Fonts.
* [FontsKey](https://www.fontskey.com/) – Bietet kostenlose und kommerzielle kostenpflichtige Schriftarten zur privaten Nutzung und kann Text zur schnellen Filterung eingeben.
* [fonts.xz.style](https://fonts.xz.style/) – Kostenloser und Open-Source-Service zur Bereitstellung von Schriftfamilien für Websites über CSS.
* [Fontsensei](https://fontsensei.com/) – Open Source Google Fonts, von Nutzern getaggt. Mit CJK (Chinesisch, Japanisch, Koreanisch) Font-Tags.

**[⬆️ Nach oben](#table-of-contents)**

## Formulare

* [Feathery](https://feathery.io) – Leistungsstarker, entwicklerfreundlicher Formular-Builder. Erstellung von Anmelde- & Login-Formularen, Benutzer-Onboarding, Zahlungsabwicklung, komplexen Finanzanwendungen und mehr. Kostenloser Tarif ermöglicht bis zu 250 Einsendungen/Monat und fünf aktive Formulare.
* [Form-Data](https://form-data.com) – No-Code-Forms-Backend. Spamfilter, E-Mail-Benachrichtigung und Auto-Reply, Webhooks, Zapier, Weiterleitungen, AJAX oder POST und mehr. Der kostenlose Plan bietet unbegrenzte Formulare, 20 Einsendungen/Monat und zusätzliche 2000 Einsendungen mit Form-Data-Badge.
* [FabForm](https://fabform.io/) – Formular-Backend-Plattform für intelligente Entwickler. Der kostenlose Plan ermöglicht 250 Formulareinsendungen pro Monat. Moderne, benutzerfreundliche Oberfläche. Integration mit Google Sheets, Airtable, Slack, E-Mail und anderen.
* [Form.taxi](https://form.taxi/) – Endpoint für HTML-Formularübermittlungen. Mit Benachrichtigungen, Spam-Blockern und DSGVO-konformer Datenverarbeitung. Kostenloser Tarif für Grundnutzung.
* [Formcarry.com](https://formcarry.com) – HTTP-POST-Formular-Endpunkt, kostenloser Plan erlaubt 100 monatliche Einsendungen.
* [formingo.co](https://www.formingo.co/) – Einfache HTML-Formulare für statische Websites. Kostenloser Start ohne Registrierung. Kostenloser Plan erlaubt 500 monatliche Einsendungen und eine anpassbare Antwortadresse.
* [FormKeep.com](https://www.formkeep.com/) – Unbegrenzte Formulare mit 50 monatlichen Einsendungen, Spamschutz, E-Mail-Benachrichtigung und Drag-and-Drop-Designer, der HTML exportieren kann. Weitere Features: benutzerdefinierte Feldregeln, Teams und Integrationen zu Google Sheets, Slack, ActiveCampaign und Zapier.
* [formlets.com](https://formlets.com/) – Online-Formulare, unbegrenzt einseitige Formulare/Monat, 100 Einsendungen/Monat, E-Mail-Benachrichtigungen.
* [formspark.io](https://formspark.io/) – Formular-zu-E-Mail-Dienst, kostenloser Plan erlaubt unbegrenzte Formulare, 250 Einsendungen pro Monat, Unterstützung durch Customer Assistance Team.
* [Formspree.io](https://formspree.io/) – E-Mail-Versand mittels HTTP-POST-Anfrage. Die kostenlose Stufe ist auf 50 Einsendungen pro Formular und Monat begrenzt.
* [Formsubmit.co](https://formsubmit.co/) – Einfache Formulareingabe-Endpunkte für Ihre HTML-Formulare. Für immer kostenlos. Keine Registrierung erforderlich.
* [Formlick.com](https://formlick.com) – Typeform-Alternative mit Lifetime-Deal. Nutzer können 1 kostenloses Formular erstellen und unbegrenzt Einsendungen empfangen. In Premium unbegrenzt Formulare und Einsendungen.
* [getform.io](https://getform.io/) – Formular-Backend-Plattform für Designer und Entwickler, 1 Formular, 50 Einsendungen, Einzeldatei-Upload, 100 MB Dateispeicher.
* [HeroTofu.com](https://herotofu.com/) – Formular-Backend mit Bot-Erkennung und verschlüsseltem Archiv. Leitet Einsendungen per UI an E-Mail, Slack oder Zapier weiter. Eigenes Frontend verwendbar, kein Server-Code notwendig. Kostenloser Plan: unbegrenzte Formulare, 100 Einsendungen pro Monat.
* [HeyForm.net](https://heyform.net/) – Drag-and-drop Online-Formular-Builder. Im kostenlosen Tarif unbegrenzt Formulare und Einsendungen, mit Vorlagen, Anti-Spam und 100 MB Dateispeicher.
* [Tally.so](https://tally.so/) – 99 % aller Funktionen kostenlos. Kostenloser Tarif: unbegrenzt Formulare, unbegrenzt Einsendungen, E-Mail-Benachrichtigungen, Formular-Logik, Zahlungsabwicklung, Datei-Upload, benutzerdefinierte Dankeseite und vieles mehr.
* [Hyperforms.app](https://hyperforms.app/) – Formular-zu-E-Mail und mehr in Sekunden, ohne Backend-Code. Persönlicher Account bis zu 50 monatliche Formulareinsendungen kostenlos.
* [Kwes.io](https://kwes.io/) – Funktionsreiches Formular-Endpunkt. Funktioniert hervorragend mit statischen Seiten. Kostenloser Plan: bis zu 1 Website mit bis zu 50 monatlichen Einsendungen.
* [Pageclip](https://pageclip.co/) – Kostenloser Plan erlaubt eine Seite, ein Formular und 1.000 monatliche Einsendungen.
* [Qualtrics Survey](https://qualtrics.com/free-account) – Professionelle Formulare & Umfragen mit diesem erstklassigen Tool erstellen. 50+ Expertenvorlagen für Umfragen. Kostenloses Konto: 1 aktive Umfrage, 100 Antworten/Umfrage & 8 Antworttypen.
* [Screeb](https://screeb.app/) – In-App-Umfragen und Produktanalytik zur Entschlüsselung des Nutzerverhaltens. Dauerhaft kostenloser Tarif mit 500 monatlich aktiven Nutzern, unbegrenzten Antworten und Events, vielen Integrationen, Export und regelmäßigen Berichten.
* [smartforms.dev](https://smartforms.dev/) – Leistungsstarkes und einfaches Formular-Backend für Ihre Website, dauerhaft kostenloser Plan mit 50 Einsendungen pro Monat, 250 MB Dateispeicher, Zapier-Integration, CSV/JSON-Export, individuelle Weiterleitung, eigene Antwortseite, Telegram- & Slack-Bot, Einzel-E-Mail-Benachrichtigungen.
* [Survicate](https://survicate.com/) – Feedback aus allen Quellen sammeln und Folgeumfragen mit einem Tool versenden. Automatische Analyse und Erkenntnisgewinn durch KI. Kostenlose E-Mail-, Website-, In-Produkt- oder Mobile-Umfragen, KI-Umfrageersteller und 25 monatliche Antworten.
* [staticforms.xyz](https://www.staticforms.xyz/) – HTML-Formulare einfach ohne serverseitigen Code integrieren – kostenlos. Nach dem Absenden erhält der Nutzer eine E-Mail mit dem Formularinhalt an die registrierte Adresse.
* [stepFORM.io](https://stepform.io) – Quiz- und Formular-Builder. Kostenloser Plan: fünf Formulare, bis zu 3 Schritte pro Formular und 50 monatliche Antworten.
* [Typeform.com](https://www.typeform.com/) – Schön gestaltete Formulare auf Webseiten einbinden. Kostenloser Plan erlaubt nur zehn Felder pro Formular und 100 monatliche Antworten.
* [WaiverStevie.com](https://waiverstevie.com) – Plattform für elektronische Signaturen mit REST-API. Benachrichtigungen per Webhooks möglich. Kostenloser Plan versieht signierte Dokumente mit Wasserzeichen, erlaubt aber unbegrenzt Umschläge + Signaturen.
* [Web3Forms](https://web3forms.com) – Kontaktformulare für statische & JAMStack-Websites ohne Backend-Code. Kostenloser Plan: unbegrenzt Formulare, unbegrenzt Domains & 250 Einsendungen pro Monat.
* [WebAsk](https://webask.io) – Umfrage- und Formular-Builder. Der kostenlose Tarif erlaubt drei Umfragen pro Konto, 100 monatliche Antworten und zehn Elemente pro Umfrage.
* [Wufoo](https://www.wufoo.com/) – Schnelle Formulare für Websites. Der kostenlose Tarif ist auf 100 Einreichungen pro Monat begrenzt.
* [formpost.app](https://formpost.app) – Kostenloser, unbegrenzter Formular-zu-E-Mail-Dienst. Individuelle Weiterleitungen, automatische Antworten, Webhooks usw. kostenlos einrichten.
* [Formester.com](https://formester.com) – Teilen und Einbetten von einzigartig gestalteten Formularen auf Ihrer Website – keine Begrenzung der erstellten Formulare oder Funktionsbeschränkungen durch den Tarif. Bis zu 100 Einreichungen pro Monat kostenlos.
* [SimplePDF.eu](https://simplepdf.eu/embed) – PDF-Editor auf Ihrer Website einbetten und jedes PDF in ein ausfüllbares Formular verwandeln. Der kostenlose Tarif erlaubt unbegrenzt viele PDFs mit drei Einreichungen pro PDF.
* [forms.app](https://forms.app/) — Online-Formulare mit leistungsstarken Funktionen wie bedingter Logik, automatischem Punktrechner und KI erstellen. Bis zu 100 Antworten mit dem kostenlosen Tarif erfassen, Formulare auf einer Website einbetten oder per Link nutzen.
* [Qualli](https://usequalli.com) – In-App-Umfragen, speziell für mobile Anwendungen. Mit Qualli AI können perfekte Fragen erstellt werden. Im kostenlosen Tarif bis zu 500 MAU testen, unbegrenzt viele Formulare und Trigger erstellen.
* [Sprig](https://sprig.com/) – 1 In-Product Survey oder Umfrage mit Replay pro Monat, mit GPT-gestützter KI-Analyse.
* [feedback.fish](https://feedback.fish/) – Kostenloser Tarif ermöglicht das Sammeln von insgesamt 25 Feedback-Einreichungen. Einfache Integration dank bereitgestellter React- und Vue-Komponenten.
* [Vidhook](https://vidhook.io/) – Feedback durch ansprechende Umfragen mit hoher Rücklaufquote sammeln. Kostenloser Tarif beinhaltet 1 aktive Umfrage, 25 Antworten pro Umfrage und anpassbare Vorlagen.

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Generative KI

* [Zenable](https://zenable.io) – Behebt automatisch Ausgaben von Tools wie Cursor, Windsurf und Copilot, um die Qualitäts- und Compliance-Standards Ihres Unternehmens mit Guardrails nach Policy as Code zu erfüllen. Die kostenlose Stufe umfasst 100 Tool-Aufrufe pro Tag zum MCP-Server und 25 kostenlose automatisierte Pull-Request-Reviews pro Tag über die GitHub-App.
* [Keywords AI](https://keywordsai.co) – Die beste LLM-Überwachungsplattform. Ein Format, um 200+ LLMs mit 2 Codezeilen aufzurufen. 10.000 kostenlose Anfragen pro Monat und $0 für Plattformfunktionen!
* [Portkey](https://portkey.ai/) – Control Panel für Gen AI-Apps mit Observability Suite & AI-Gateway. Bis zu 10.000 Anfragen pro Monat kostenlos senden und protokollieren.
* [Braintrust](https://www.braintrustdata.com/) – Evals, Prompt Playground und Datenmanagement für Gen AI. Kostenloser Tarif bietet bis zu 1.000 private Eval-Zeilen/Woche.
* [Findr](https://www.usefindr.com/) – Universelle Suche, mit der Sie alle Ihre Apps gleichzeitig durchsuchen können. Suchassistent, der Antworten auf Basis Ihrer Informationen liefert. Kostenloser Tarif bietet unbegrenzte einheitliche Suche und 5 tägliche Co-Pilot-Abfragen.
* [ReportGPT](https://ReportGPT.app) – KI-gestützter Schreibassistent. Die gesamte Plattform ist kostenlos, solange Sie Ihren eigenen API-Key mitbringen.
* [Clair](https://askclair.ai/) – Klinische KI-Referenz. Studierende erhalten kostenlosen Zugang zur professionellen Tool-Suite, darunter Open Search, Clinical Summary, Med Review, Arzneimittelinteraktionen, ICD-10-Codes und Stewardship. Zusätzlich ist eine kostenlose Testversion der Professional Suite verfügbar.
* [Langtrace](https://langtrace.ai) – Ermöglicht Entwicklern das Nachverfolgen, Bewerten, Verwalten von Prompts und Datasets sowie Debugging von Problemen bezüglich der Performance von LLM-Anwendungen. Erstellt Open-Telemetrie-Standard-Traces für jedes LLM zur besseren Beobachtbarkeit und funktioniert mit jedem Observability-Client. Kostenloser Tarif bietet 50.000 Traces/Monat.
* [LangWatch](https://langwatch.ai) – Eine LLMOps-Plattform, die KI-Teams dabei unterstützt, LLM-Anwendungen hinsichtlich Zuverlässigkeit, Kosteneffizienz und Performance zu messen, zu überwachen und zu optimieren. Mit einer leistungsstarken DSPy-Komponente ermöglichen wir nahtlose Zusammenarbeit zwischen Entwicklern und nicht-technischen Teams, um GenAI-Produkte zu optimieren und produktiv zu machen. Kostenloser Tarif enthält alle Plattformfunktionen, 1.000 Traces/Monat und 1 Workflow DSPy-Optimizer. [#opensource](https://github.com/langwatch/langwatch)
* [Comet Opik](https://www.comet.com/site/products/opik/) – LLM-Anwendungen über Dev- und Produktions-Lebenszyklen bewerten, testen und ausliefern. [#opensource](https://github.com/comet-ml/opik/)
* [Langfuse](https://langfuse.com/) – Open-Source-LLM-Engineering-Plattform, die Teams dabei hilft, gemeinsam LLM-Anwendungen zu debuggen, zu analysieren und weiterzuentwickeln. Der Free-Forever-Tarif umfasst 50.000 Beobachtungen pro Monat und alle Plattformfunktionen. [#opensource](https://github.com/langfuse/langfuse)
* [Pollinations.AI](https://pollinations.ai/) – Einfach zu bedienende, kostenlose Bildgenerierungs-KI mit kostenloser API. Keine Anmeldung oder API-Keys erforderlich und mehrere Integrationsmöglichkeiten in Website oder Workflow. [#opensource](https://github.com/pollinations/pollinations)
* [Othor AI](https://othor.ai/) – Eine KI-native, schnelle, einfache und sichere Alternative zu beliebten Business-Intelligence-Lösungen wie Tableau, Power BI und Looker. Othor nutzt große Sprachmodelle (LLMs) für individuelle BI-Lösungen in Minuten. Der Free-Forever-Tarif bietet einen Workspace mit fünf Datenquellenverbindungen für einen Nutzer, ohne Analyse-Limits. [#opensource](https://github.com/othorai/othor.ai)
* [OpenRouter](https://openrouter.ai/models?q=free) – Bietet verschiedene kostenlose KI-Modelle wie DeepSeek R1, V3, Llama und Moonshot AI. Diese Modelle sind ausgezeichnet für die Verarbeitung natürlicher Sprache und für vielfältige Entwicklungsbedarfe geeignet. Zu beachten: Die Nutzung der kostenlosen Modelle unterliegt Rate-Limits. Für fortgeschrittene Anforderungen bietet OpenRouter zudem kostenpflichtige Modelle an, z.B. Claude, OpenAI, Grok, Gemini und Nova.

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## CDN und Schutz

* [bootstrapcdn.com](https://www.bootstrapcdn.com/) — CDN für bootstrap, bootswatch und fontawesome.io
* [cdnjs.com](https://cdnjs.com/) — Einfach. Schnell. Zuverlässig. Content-Delivery auf höchstem Niveau. cdnjs ist ein kostenloser und quelloffener CDN-Dienst, dem über 11 % aller Websites vertrauen, betrieben von Cloudflare.
* [developers.google.com](https://developers.google.com/speed/libraries/) — Die Google Hosted Libraries sind ein Content-Distribution-Netzwerk für die beliebtesten Open-Source-JavaScript-Bibliotheken.
* [Stellate](https://stellate.co/) – Stellate ist ein blitzschnelles, zuverlässiges CDN für Ihre GraphQL-API und kostenlos für zwei Services.
* [jsdelivr.com](https://www.jsdelivr.com/) — Kostenloses, schnelles und zuverlässiges Open-Source-CDN. Unterstützt npm, GitHub, WordPress, Deno und mehr.
* [Microsoft Ajax](https://docs.microsoft.com/en-us/aspnet/ajax/cdn/overview) — Das Microsoft Ajax CDN hostet beliebte JavaScript-Bibliotheken wie jQuery und ermöglicht deren einfache Integration in Webanwendungen.
* [ovh.ie](https://www.ovh.ie/ssl-gateway/) — Kostenloser DDoS-Schutz und SSL-Zertifikat.
* [Skypack](https://www.skypack.dev/) — 100 % Native ES Module JavaScript CDN. Kostenlos bis zu 1 Million Anfragen pro Domain und Monat.
* [raw.githack.com](https://raw.githack.com/) — Moderne Alternative zu **rawgit.com**, hostet Dateien einfach über Cloudflare.
* [section.io](https://www.section.io/) — Einfache Verwaltung und Einrichtung einer kompletten Varnish-Cache-Lösung. Angeblich dauerhaft kostenlos für eine Website.
* [statically.io](https://statically.io/) — CDN für Git-Repositories (GitHub, GitLab, Bitbucket), WordPress-Assets und Bilder.
* [toranproxy.com](https://toranproxy.com/) — Proxy für Packagist und GitHub. Keine fehlgeschlagenen Deployments mehr. Kostenlos für private Nutzung, einen Entwickler, ohne Support.
* [UNPKG](https://unpkg.com/) — CDN für alles auf npm.
* [weserv](https://images.weserv.nl/) — Bild-Cache- & Resize-Service. Bilder weltweit zwischenspeichern und on-the-fly manipulieren.
* [Namecheap Supersonic](https://www.namecheap.com/supersonic-cdn/#free-plan) — Kostenloser DDoS-Schutz.
* [Gcore](https://gcorelabs.com/) Globales Content-Delivery-Netzwerk, 1 TB und 1 Million Anfragen pro Monat kostenlos sowie kostenloses DNS-Hosting.
* [CacheFly](https://portal.cachefly.com/signup/free2023) – Bis zu 5 TB CDN-Traffic pro Monat kostenlos, 19 Core PoPs, 1 Domain und Universal SSL.

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## PaaS

* [anvil.works](https://anvil.works) – Web-App-Entwicklung nur mit Python. Kostenloser Tarif mit unbegrenzten Apps und 30-Sekunden-Timeouts.
* [appwrite](https://appwrite.io) – Unbegrenzte Projekte ohne Projektpausierung (unterstützt Websockets) und Authentifizierungsdienst. 1 Datenbank, 3 Buckets, 5 Funktionen pro Projekt im kostenlosen Tarif.
* [configure.it](https://www.configure.it/) — Mobile-App-Entwicklungsplattform, kostenlos für zwei Projekte, eingeschränkte Funktionen, aber keine Ressourcenlimits.
* [codenameone.com](https://www.codenameone.com/) — Open-Source, plattformübergreifende Mobile-App-Entwicklungstoolchain für Java/Kotlin-Entwickler. Kostenlos für kommerzielle Nutzung mit unbegrenzter Anzahl an Projekten.
* [deco.cx](https://www.deco.cx/en/dev) – Edge-native Frontend-Plattform mit visuellem CMS, das automatisch aus TypeScript-Code generiert wird. Integriertes A/B-Testing, Content-Segmentierung und Echtzeit-Analytics. Perfekt für Content-starke und Enterprise-E-Commerce-Websites. Kostenlos bis zu 5.000 Pageviews/Monat oder für Open-Source/Private Projekte.
* [Deno Deploy](https://deno.com/deploy) – Verteilter Dienst, der JavaScript, TypeScript und WebAssembly weltweit am Edge ausführt. Kostenloser Tarif: 100.000 Anfragen pro Tag und 100 GiB Datentransfer pro Monat.
* [domcloud.co](https://domcloud.co) – Linux-Hosting mit CI/CD via GitHub, SSH und MariaDB/Postgres-Datenbank. Kostenlose Version mit 1 GB Speicher, 1 GB Traffic/Monat und auf eine freie Domain beschränkt.
* [encore.dev](https://encore.dev/) — Backend-Framework, das mit statischer Analyse automatische Infrastruktur, boilerplate-freien Code und mehr bietet. Inklusive kostenlosem Cloud-Hosting für Hobbyprojekte.
* [flightcontrol.dev](https://flightcontrol.dev/) – Deployment von Webservices, Datenbanken und mehr im eigenen AWS-Account mit Git-Push-Workflow. Kostenloser Tarif für 1 Entwickler auf persönlichen GitHub-Repos. AWS-Kosten werden über AWS abgerechnet, aber Credits und AWS-Free-Tier können genutzt werden.
* [gigalixir.com](https://gigalixir.com/) – Gigalixir bietet eine kostenlose Instanz, die nie schläft, sowie eine kostenlose PostgreSQL-Datenbank (2 Verbindungen, 10.000 Zeilen, keine Backups) für Elixir/Phoenix-Apps.
* [Glitch](https://glitch.com/) — Kostenloses Hosting mit Code-Sharing und Echtzeit-Kollaboration. Kostenloser Plan mit 1.000 Stunden pro Monat.
* [leapcell](https://leapcell.io/) – Zuverlässige Plattform für verteilte Anwendungen, alles Notwendige für rasantes Wachstum. Kostenloser Tarif: 100.000 Service-Aufrufe, 10.000 asynchrone Tasks und 100.000 Redis-Kommandos.
* [pipedream.com](https://pipedream.com) – Integrationsplattform für Entwickler. Erstellen Sie Workflows nach jedem Trigger. Workflows sind Code, den Sie [kostenlos](https://docs.pipedream.com/pricing/) ausführen können. Keine Server- oder Cloudressourcen zu verwalten.
* [pythonanywhere.com](https://www.pythonanywhere.com/) — Python-App-Hosting in der Cloud. Kostenloses Einsteigerkonto: 1 Python-Webanwendung unter your-username.pythonanywhere.com, 512 MB privater Speicher, eine MySQL-Datenbank.
* [ampt.dev](https://getampt.com/) – Teams können JavaScript-Apps auf AWS ohne komplizierte Konfigurationen oder Infrastrukturmanagement bereitstellen. Kostenloser Vorschauplan: 500 Aufrufe stündlich, 2.500 täglich, 50.000 monatlich. Eigene Domains nur in bezahlten Plänen.
* [Koyeb](https://www.koyeb.com) – Entwicklerfreundliche serverlose Plattform für globale App-Bereitstellung. Docker-Container, Web-Apps und APIs mit Git-Deployment, Autoscaling, globalem Edge-Netzwerk und Service-Mesh. Kostenlos: Webservice in Frankfurt (DE) oder Washington D.C. (US), kostenloses Managed Postgres in Frankfurt, Washington D.C. und Singapur. 512MB RAM, 2GB Speicher, 0,1 CPU.
* [Napkin](https://www.napkin.io/) – FaaS mit 500MB RAM, 15 Sekunden Timeout und 5.000 kostenlosen API-Aufrufen/Monat (rate-limited auf 5/s).
* [Meteor Cloud](https://www.meteor.com/cloud) — Galaxy-Hosting. Meteors Platform-as-a-Service für Meteor-Apps inkl. kostenlosem MongoDB Shared Hosting und automatischem SSL.
* [Northflank](https://northflank.com) — Microservices, Jobs und Datenbanken mit UI, API & CLI bereitstellen. Skalierung von Containern aus Versionskontrolle und externen Docker-Registries. Kostenloser Tarif: 2 Services, 2 Cronjobs, 1 Datenbank.
* [YepCode](https://yepcode.io) – Plattform zum Verbinden von APIs und Services in serverloser Umgebung. Agilität von NoCode-Tools mit der Power von Programmiersprachen. Kostenloser Tarif: [1.000 yeps](https://yepcode.io/pricing/).
* [WunderGraph](https://cloud.wundergraph.com) – Open-Source-Plattform zum schnellen Bauen, Ausliefern und Verwalten moderner APIs. Integrierte CI/CD, GitHub-Integration, automatisches HTTPS. Bis zu 3 Projekte, 1GB Egress, 300 Minuten Buildzeit pro Monat im [kostenlosen Tarif](https://wundergraph.com/pricing).
* [Zeabur](https://zeabur.com) – Services mit einem Klick bereitstellen. Kostenlos für drei Services, monatlich $5 Freiguthaben.
* [mogenius](https://mogenius.com) – Services einfach auf Kubernetes bauen, deployen und betreiben. Kostenloser Tarif: Verbindung eines lokalen Kubernetes mit mogenius möglich, so dass Einzelentwickler eine produktionsähnliche Testumgebung auf ihrem Rechner erstellen können.
* [genezio](https://genezio.com/) – Serverless-Function-Anbieter mit 1 Million Funktionsaufrufen, 100GB Bandbreite und 10 Cronjobs pro Monat kostenlos, ausschließlich für nicht-kommerzielle oder akademische Nutzung.

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## BaaS

* [Activepieces](https://www.activepieces.com) – Automatisierungsflüsse erstellen, um verschiedene Apps im Backend Ihrer Anwendung zu verbinden. Zum Beispiel eine Slack-Nachricht senden oder eine Google-Sheet-Zeile hinzufügen, wenn ein Ereignis ausgelöst wird. Bis zu 5.000 Aufgaben pro Monat kostenlos.
* [back4app.com](https://www.back4app.com) – Back4App ist ein benutzerfreundliches, flexibles und skalierbares Backend basierend auf der Parse-Plattform.
* [backendless.com](https://backendless.com/) — Mobile- und Web-BaaS mit 1 GB kostenlosem Dateispeicher, 50.000 Push-Benachrichtigungen/Monat und 1.000 Datenobjekten in der Tabelle.
* [bismuth.cloud](https://www.bismuth.cloud/) — Unsere KI bootstrapped Ihre Python-API auf unserem Funktionsruntime und gehosteten Speicher, kostenlos bauen und hosten im Online-Editor oder lokal mit Ihren Lieblingstools.
* [BMC Developer Program](https://developers.bmc.com/site/global/bmc_helix_platform/program/overview/index.gsp) — Das BMC Developer Program bietet Dokumentation und Ressourcen zum Erstellen und Bereitstellen digitaler Innovationen für Ihr Unternehmen. Zugang zu einer umfassenden persönlichen Sandbox, die die Plattform, das SDK und eine Komponentenbibliothek umfasst, mit der Apps erstellt und angepasst werden können.
* [connectycube.com](https://connectycube.com) – Unbegrenzte Chatnachrichten, p2p-Sprach- & Videoanrufe, Dateianhänge und Push-Benachrichtigungen. Kostenlos für Apps mit bis zu 1.000 Benutzern.
* [convex.dev](https://convex.dev/) – Reaktives Backend-as-a-Service, hostet Ihre Daten (Dokumente mit Relationen & serialisierbare ACID-Transaktionen), serverlose Funktionen und WebSockets für Updates an verschiedene Clients. Kostenlos für kleine Projekte – bis zu 1M Datensätze, 5M monatliche Funktionsaufrufe.
* [darklang.com](https://darklang.com/) – Gehostete Sprache mit integriertem Editor und Infrastruktur. Während der Beta zugänglich, großzügiger kostenloser Tarif nach der Beta geplant.
* [Firebase](https://firebase.com) — Firebase hilft beim Erstellen und Betrieb erfolgreicher Apps. Der kostenlose Spark-Plan bietet Authentifizierung, Hosting, Firebase ML, Realtime Database, Cloud Storage, Testlab. A/B-Testing, Analytics, App-Distribution, App-Indexing, Cloud Messaging (FCM), Crashlytics, Dynamic Links, In-App Messaging, Performance Monitoring, Predictions und Remote Config sind immer kostenlos.
* [Flutter Flow](https://flutterflow.io) — Flutter-App-UI ohne eine Zeile Code erstellen. Firebase-Integration inklusive. Der kostenlose Tarif umfasst den vollen Zugang zum UI-Builder und kostenlose Templates.
* [getstream.io](https://getstream.io/) — Skalierbare In-App-Chats, Messaging, Video und Audio sowie Feeds in wenigen Stunden statt Wochen erstellen.
* [hasura.io](https://hasura.io/) — Hasura erweitert Ihre bestehenden Datenbanken, egal wo sie gehostet sind, und bietet eine sofortige GraphQL-API, die sicher für Web-, Mobil- und Datenintegrations-Workloads genutzt werden kann. Kostenlos für 1GB/Monat Daten-Durchsatz.
* [nhost.io](https://nhost.io) – Serverloses Backend für Web- und Mobile-Apps. Kostenloser Plan umfasst PostgreSQL, GraphQL (Hasura), Authentifizierung, Storage und Serverless Functions.
* [onesignal.com](https://onesignal.com/) — Unbegrenzte kostenlose Push-Benachrichtigungen. 10.000 E-Mail-Sendungen pro Monat, unbegrenzte Kontakte und Zugang zum Auto Warm Up.
* [paraio.com](https://paraio.com) — Backend-Service-API mit flexibler Authentifizierung, Volltextsuche und Caching. Kostenlos für eine App, 1GB App-Daten.
* [pubnub.com](https://www.pubnub.com/) — Kostenlose Push-Benachrichtigungen für bis zu 1 Million Nachrichten/Monat und 100 aktive tägliche Geräte
* [pushbots.com](https://pushbots.com/) — Push-Benachrichtigungsdienst. Kostenlos für bis zu 1,5 Millionen Pushes/Monat
* [pushcrew.com](https://pushcrew.com/) — Push-Benachrichtigungsdienst. Unbegrenzte Benachrichtigungen für bis zu 2.000 Abonnenten
* [pusher.com](https://pusher.com/beams) — Kostenlose, unbegrenzte Push-Benachrichtigungen für 2.000 monatlich aktive Nutzer. Eine einzige API für iOS- und Android-Geräte.
* [quickblox.com](https://quickblox.com/) — Kommunikations-Backend für Instant Messaging, Video- und Sprachanrufe sowie Push-Benachrichtigungen
* [restspace.io](https://restspace.io/) - Konfigurieren Sie einen Server mit Diensten für Authentifizierung, Daten, Dateien, E-Mail-API, Vorlagen und mehr, dann kombinieren Sie diese in Pipelines und transformieren Sie Daten.
* [Salesforce Developer Program](https://developer.salesforce.com/signup) — Erstellen Sie Apps blitzschnell mit Drag-and-Drop-Tools. Passen Sie Ihr Datenmodell mit Klicks an. Gehen Sie mit Apex-Code noch weiter. Integrieren Sie alles mit leistungsstarken APIs. Bleiben Sie geschützt mit Sicherheit auf Unternehmensniveau. Passen Sie die UI mit Klicks oder jedem modernen Web-Framework an. Das kostenlose Entwicklerprogramm bietet Zugang zur vollständigen Lightning-Plattform.
* [simperium.com](https://simperium.com/) — Daten überall sofort und automatisch verschieben, plattformübergreifend, unbegrenztes Senden und Speichern von strukturierten Daten, max. 2.500 Nutzer/Monat
* [Supabase](https://supabase.com) — Die Open-Source-Firebase-Alternative zum Erstellen von Backends. Kostenloser Plan bietet Authentifizierung, Realtime-Datenbank & Objektspeicher.
* [tyk.io](https://tyk.io/) — API-Management mit Authentifizierung, Quoten, Monitoring und Analytics. Kostenlose Cloud-Variante
* [zapier.com](https://zapier.com/) — Verbinden Sie die von Ihnen genutzten Apps zur Automatisierung von Aufgaben. Fünf Zaps alle 15 Minuten und 100 Aufgaben/Monat
* [IFTTT](https://ifttt.com) — Automatisieren Sie Ihre Lieblings-Apps und -Geräte. Kostenlos 2 Applets
* [Integrately](https://integrately.com) — Automatisieren Sie lästige Aufgaben mit einem einzigen Klick. Kostenlos 100 Aufgaben, 15-Minuten-
Aktualisierungszeit, fünf aktive Automatisierungen, Webhooks.
* [LeanCloud](https://leancloud.app/) — Mobile Backend. 1GB Datenspeicher, 256MB Instanz, 3K API-Anfragen/Tag und 10K Pushes/Tag kostenlos. (API ist sehr ähnlich zur Parse Platform)
* [Claw.cloud](https://run.claw.cloud) - Eine PaaS-Plattform, die Nutzern mit einem älteren GitHub-Konto als 180 Tage $5/Monat an kostenlosen Credits bietet. Perfekt zum Hosten von Apps, Datenbanken und mehr. ([Anmeldelink mit Gratis-Guthaben](https://ap-southeast-1.run.claw.cloud/signin)).


**[⬆️ Zurück zum Inhaltsverzeichnis](#table-of-contents)**

## Low-Code-Plattform

* [appsmith](https://www.appsmith.com/) — Low-Code-Projekt zur Erstellung von Admin-Panels, internen Tools und Dashboards. Integration mit 15+ Datenbanken und jeder API.
* [Basedash](https://www.basedash.com) — Low-Code-Plattform zum Erstellen interner Admin-Panels und Dashboards. Unterstützt SQL-Datenbanken und REST-APIs.
* [BudiBase](https://budibase.com/) — Budibase ist eine Open-Source-Low-Code-Plattform zur Erstellung interner Apps in Minuten. Unterstützt PostgreSQL, MySQL, MSSQL, MongoDB, Rest API, Docker, K8s
* [Clappia](https://www.clappia.com) — Eine Low-Code-Plattform für die Erstellung von Geschäftsprozessanwendungen mit anpassbaren mobilen und Web-Apps. Bietet eine Drag-and-Drop-Oberfläche, Funktionen wie Offline-Support, Echtzeit-Standortverfolgung und Integration mit verschiedenen Drittanbieterdiensten
* [DronaHQ](https://www.dronahq.com/) — DronaHQ – eine Low-Code-Plattform, die Entwicklerteams und Produktmanagern hilft, interne Tools, benutzerdefinierte Nutzerreisen, digitale Erlebnisse, Automatisierung, individuelle Admin-Panels und operative Apps 10x schneller zu erstellen.
* [lil'bots](https://www.lilbots.io/) - Schreiben und Ausführen von Skripten online unter Nutzung kostenloser integrierter APIs wie OpenAI, Anthropic, Firecrawl und anderen. Ideal zum Erstellen von KI-Agenten / internen Tools und Teilen im Team. Free-Tier beinhaltet vollen Zugang zu APIs, KI-Coding-Assistent und 10.000 Ausführungsguthaben / Monat.
* [Mendix](https://www.mendix.com/) — Rapid Application Development für Unternehmen, unbegrenzt zugängliche Sandbox-Umgebungen mit beliebig vielen Nutzern, 0,5 GB Speicher und 1 GB RAM pro App. Außerdem sind die Studio- und Studio-Pro-IDEs in der kostenlosen Stufe erlaubt.
* [outsystems.com](https://www.outsystems.com/) — Enterprise-Webentwicklungs-PaaS für On-Premises oder Cloud, kostenloses "Personal Environment" erlaubt unbegrenzten Code und bis zu 1 GB Datenbank
* [ReTool](https://retool.com/) — Low-Code-Plattform zum Erstellen interner Anwendungen. Retool ist hochgradig anpassbar. Wenn Sie es mit JavaScript und einer API schreiben können, können Sie es in Retool erstellen. Die kostenlose Stufe erlaubt bis zu fünf Benutzer pro Monat, unbegrenzte Apps und API-Verbindungen.
* [Superblocks](https://superblocks.com/) — Offene Unternehmensanwendungsplattform für Entwickler und semi-technische Teams. Nutzen Sie KI zum Generieren, Visuellen Editieren und Erweitern mit Code. Zentrale Verwaltung mit Integrationen, Authentifizierung, Berechtigungen & Audit-Logs.
* [ToolJet](https://www.tooljet.com/) — Erweiterbares Low-Code-Framework für den Bau von Business-Anwendungen. Anbindung an Datenbanken, Cloud-Speicher, GraphQL, API-Endpunkte, Airtable usw., und Apps mit Drag-and-Drop-Builder erstellen.
* [UI Bakery](https://uibakery.io) — Low-Code-Plattform für den schnellen Bau individueller Webanwendungen. UI-Erstellung per Drag-and-Drop mit hoher Anpassbarkeit durch JavaScript, Python und SQL. Verfügbar als Cloud- und Selbsthost-Lösung. Kostenlos für bis zu 5 Nutzer.
* [manubes](https://www.manubes.com) - Leistungsstarke No-Code-Cloud-Plattform mit Fokus auf industrielle Produktionssteuerung. Kostenlos für einen Nutzer mit 1 Million Workflow-Aktivitäten pro Monat ([auch auf Deutsch verfügbar](https://www.manubes.de)).

**[⬆️ Zurück zum Inhaltsverzeichnis](#table-of-contents)**

## Webhosting

* [Alwaysdata](https://www.alwaysdata.com/) — 100 MB kostenloses Webhosting mit Unterstützung für MySQL, PostgreSQL, CouchDB, MongoDB, PHP, Python, Ruby, Node.js, Elixir, Java, Deno, benutzerdefinierte Webserver, Zugang via FTP, WebDAV und SSH; Mailbox, Mailingliste und App-Installer inklusive.
* [Awardspace.com](https://www.awardspace.com) — Kostenloses Webhosting + eine kostenlose Kurzdomain, PHP, MySQL, App-Installer, E-Mail-Versand & keine Werbung.
* [Bohr](https://bohr.io) — Kostenlos für nichtkommerzielle Projekte + Entwickler-First-Bereitstellungs- und Entwicklungsplattform, die Infrastrukturaufwand minimiert und Einrichtung beschleunigt.
* [Bubble](https://bubble.io/) — Visuelle Programmierung zum Erstellen von Web- und Mobile-Apps ohne Code, kostenlos mit Bubble-Branding.
* [dAppling Network](https://www.dappling.network/) - Dezentralisierte Webhosting-Plattform für Web3-Frontends mit Fokus auf höhere Verfügbarkeit und Sicherheit sowie zusätzlichem Zugangspunkt für Nutzer.
* [DigitalOcean](https://www.digitalocean.com/pricing) - Erstellen und Bereitstellen von drei statischen Seiten kostenlos im App Platform Starter-Tarif.
* [Drive To Web](https://drv.tw) — Direkt aus Google Drive & OneDrive ins Web hosten. Nur statische Seiten. Für immer kostenlos. Eine Seite pro Google/Microsoft-Konto.
* [Fenix Web Server](https://preview.fenixwebserver.com) - Eine Desktop-App für Entwickler, um Seiten lokal zu hosten und öffentlich (in Echtzeit) zu teilen. Arbeiten Sie wie Sie möchten, mit schöner Benutzeroberfläche, API und/oder CLI.
* [Fern](https://buildwithfern.com) - Erstellen und hosten Sie eine Markdown-basierte Dokumentationsseite im kostenlosen Tarif von Fern. Sie können sogar eine API-Referenz für Ihre Seite automatisch aus API-Definitionsdateien generieren. Die Seite wird unter _yoursite_.docs.buildwithfern.com gehostet.
* [Free Hosting](https://freehostingnoads.net/) — Kostenloses Hosting mit PHP 5, Perl, CGI, MySQL, FTP, Dateimanager, POP-E-Mail, kostenlosen Subdomains, kostenlosen Domain-Hosting, DNS-Zonen-Editor, Website-Statistiken, kostenlosem Online-Support und vielen weiteren Features, die andere kostenlose Hosts nicht bieten.
* [Freehostia](https://www.freehostia.com) — FreeHostia bietet kostenlose Hosting-Dienste inkl. branchenbestem Control Panel & 1-Klick-Installation von 50+ kostenlosen Apps. Sofortige Einrichtung. Keine erzwungene Werbung.
* [HelioHost](https://heliohost.org) — Gemeinnütziges, kostenloses Webhosting mit Plesk-Panel, PHP, Node.js, Python, Django, Flask, .NET, Perl, CGI, MySQL, PostgreSQL, SQLite, IMAP/POP3/SMTP-E-Mail, unbegrenzter Bandbreite, kostenlosen Subdomains, 1000 MB Speicher kostenlos mit Upgrade-Option.
* [Kinsta Static Site Hosting](https://kinsta.com/static-site-hosting/) — Bis zu 100 statische Seiten kostenlos bereitstellen, eigene Domains mit SSL, 100 GB monatliche Bandbreite, 260+ Cloudflare-CDN-Standorte.
* [Lecturify](https://www.lecturify.net/index.en.html) - Webhosting mit SFPT-Zugang zum Hoch- und Runterladen von Dateien, PHP verfügbar.
* [Neocities](https://neocities.org) — Statische Seiten, 1 GB kostenloser Speicher mit 200 GB Bandbreite.
* [Netlify](https://www.netlify.com/) — Erstellt, stellt bereit und hostet statische Seiten/Apps kostenlos für 100 GB Daten und 100 GB/Monat Bandbreite.
* [pantheon.io](https://pantheon.io/) — Drupal- und WordPress-Hosting, automatisiertes DevOps und skalierbare Infrastruktur. Kostenlos für Entwickler und Agenturen. Keine eigene Domain.
* [readthedocs.org](https://readthedocs.org/) — Kostenloses Dokumentationshosting mit Versionierung, PDF-Generierung und mehr
* [render.com](https://render.com) — Einheitliche Cloud zum Erstellen und Ausführen von Apps und Seiten mit kostenlosem SSL, globalem CDN, privaten Netzwerken, Auto-Deploys von Git und vollständig kostenlosen Plänen für Webdienste, Datenbanken und statische Webseiten.
* [SourceForge](https://sourceforge.net/) — Finden, Erstellen und Veröffentlichen von Open-Source-Software kostenlos
* [surge.sh](https://surge.sh/) — Statisches Web-Publishing für Front-End-Entwickler. Unbegrenzte Seiten mit Unterstützung für eigene Domains
* [telegra.ph](https://telegra.ph/) Erstellen Sie ganz einfach Webseiten mit Quill
* [tilda.cc](https://tilda.cc/) — Eine Seite, 50 Seiten, 50 MB Speicher, nur die Haupt-Standardblöcke von 170+ verfügbar, keine Schriften, kein Favicon und keine eigene Domain
* [Vercel](https://vercel.com/) — Erstellen, bereitstellen und hosten Sie Web-Apps mit kostenlosem SSL, globalem CDN und einzigartigen Vorschau-URLs bei jedem `git push`. Perfekt für Next.js und andere Static Site Generatoren.
* [Versoly](https://versoly.com/) — SaaS-orientierter Website-Builder – unbegrenzte Websites, 70+ Blöcke, fünf Templates, eigenes CSS, Favicon, SEO und Formulare. Keine eigene Domain.
* [Qoddi](https://qoddi.com) - PaaS-Dienst ähnlich Heroku mit entwicklerzentriertem Ansatz und All-in-One-Features. Kostenloses Kontingent für statische Inhalte, Staging und Entwickler-Apps.
* [FreeFlarum](https://freeflarum.com/) - Community-basiertes, kostenloses Flarum-Hosting für bis zu 250 Nutzer (Spende, um das Wasserzeichen im Footer zu entfernen).
* [MDB GO](https://mdbgo.com/) - Kostenloses Hosting für ein Projekt mit zwei Wochen Container-TTL, 500 MB RAM pro Projekt, SFTP - 1G Speicherplatz.
* [Patr Cloud](https://patr.cloud/) — Eine einfach zu nutzende Cloud-Plattform, unter den kostenpflichtigen Services können drei statische Seiten kostenlos gehostet werden.
* [Serv00.com](https://serv00.com/) — 3 GB kostenloses Webhosting mit täglichen Backups (7 Tage). Unterstützt: Crontab-Jobs, SSH-Zugang, Repositories (GIT, SVN und Mercurial), unterstützt: MySQL, PostgreSQL, MongoDB, PHP, Node.js, Python, Ruby, Java, Perl, TCL/TK, Lua, Erlang, Rust, Pascal, C, C++, D, R und viele mehr.
- [Sevalla](https://sevalla.com/) - Hosting-Plattform, entwickelt zur Vereinfachung der Bereitstellung und Verwaltung von Anwendungen, Datenbanken und statischen Webseiten – 1GB Seitenlimit, 100GB kostenlose Bandbreite, 600 kostenlose Build-Minuten, 100 Seiten pro Account.

**[⬆️ Zurück zum Inhaltsverzeichnis](#table-of-contents)**

## DNS

* [1.1.1.1](https://developers.cloudflare.com/1.1.1.1/) - Kostenloser öffentlicher DNS-Resolver, schnell und sicher (verschlüsselt Ihre DNS-Anfrage), bereitgestellt von Cloudflare. Nützlich zum Umgehen der DNS-Sperren Ihres Internetanbieters, zum Verhindern von DNS-Anfrage-Spionage und [zum Blockieren von Erwachsenen- & Malware-Inhalten](https://developers.cloudflare.com/1.1.1.1/1.1.1.1-for-families). Kann auch [per API](https://developers.cloudflare.com/1.1.1.1/encrypted-dns/dns-over-https/make-api-requests) genutzt werden. Hinweis: Nur ein DNS-Resolver, kein DNS-Hoster.
* [1984.is](https://www.1984.is/product/freedns/) — Kostenloser DNS-Dienst mit API und vielen anderen kostenlosen DNS-Features inklusive.
* [cloudns.net](https://www.cloudns.net/) — Kostenloses DNS-Hosting für bis zu 1 Domain mit 50 Einträgen
* [deSEC](https://desec.io) - Kostenloses DNS-Hosting mit API-Unterstützung, sicherheitsorientiert. Läuft auf Open-Source-Software und wird von [SSE](https://www.securesystems.de/) unterstützt.
* [dns.he.net](https://dns.he.net/) — Kostenloses DNS-Hosting mit Dynamic DNS Support
* [Zonomi](https://zonomi.com/) — Kostenloses DNS-Hosting mit sofortiger DNS-Propagation. Kostenloser Plan: 1 DNS-Zone (Domainname) mit bis zu 10 DNS-Einträgen.
* [dnspod.com](https://www.dnspod.com/) — Kostenloses DNS-Hosting.
* [duckdns.org](https://www.duckdns.org/) — Kostenloses DDNS mit bis zu 5 Domains im Free-Tier. Mit Konfigurationsanleitungen für verschiedene Setups.
* [Dynv6.com](https://dynv6.com/) — Kostenloser DDNS-Dienst mit [API-Unterstützung](https://dynv6.com/docs/apis) und Verwaltung vieler DNS-Eintragstypen (wie CNAME, MX, SPF, SRV, TXT und andere).
* [freedns.afraid.org](https://freedns.afraid.org/) — Kostenloses DNS-Hosting. Bietet auch kostenlose Subdomains, basierend auf zahlreichen öffentlichen Nutzer-[beigesteuerten Domains](https://freedns.afraid.org/domain/registry/). Nach Anmeldung kostenlose Subdomains im Menü "Subdomains" erhalten.
* [luadns.com](https://www.luadns.com/) — Kostenloses DNS-Hosting, drei Domains, alle Features mit angemessenen Limits
* [namecheap.com](https://www.namecheap.com/domains/freedns/) — Kostenloses DNS. Keine Begrenzung der Domain-Anzahl
* [nextdns.io](https://nextdns.io) - DNS-basierte Firewall, 300K kostenlose Abfragen pro Monat
* [noip.at](https://noip.at/) — Kostenloser DDNS-Dienst ohne Registrierung, Tracking, Logging oder Werbung. Keine Begrenzung der Domains.
* [noip](https://www.noip.com/) — Dynamischer DNS-Dienst, der bis zu 3 Hostnamen kostenlos erlaubt, Bestätigung alle 30 Tage erforderlich
* [sslip.io](https://sslip.io/) — Kostenloser DNS-Dienst, der bei Abfrage eines Hostnamens mit eingebetteter IP-Adresse diese IP-Adresse zurückgibt.
* [zilore.com](https://zilore.com/en/dns) — Kostenloses DNS-Hosting für 5 Domains.
* [zoneedit.com](https://www.zoneedit.com/free-dns/) — Kostenloses DNS-Hosting mit Dynamic DNS Support.
* [zonewatcher.com](https://zonewatcher.com) — Automatische Backups und DNS-Änderungsüberwachung. Eine Domain kostenlos
* [huaweicloud.com](https://www.huaweicloud.com/intl/en-us/product/dns.html) – Kostenloses DNS-Hosting von Huawei
* [Hetzner](https://www.hetzner.com/dns-console) – Kostenloses DNS-Hosting von Hetzner mit API-Unterstützung.
* [Glauca](https://docs.glauca.digital/hexdns/) – Kostenloses DNS-Hosting für bis zu 3 Domains und DNSSEC-Unterstützung
* [VolaryDDNS](https://volaryddns.net) - Kostenloses, leistungsstarkes DDNS ohne Abonnements oder Werbung

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Domain

  * [pp.ua](https://nic.ua/) — Kostenlose pp.ua-Subdomains.
  * [us.kg](https://nic.us.kg/) - Kostenlose us.kg-Subdomains.

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## IaaS

  * [4EVERLAND](https://www.4everland.org/) — Kompatibel mit AWS S3 - APIs, Interface-Operationen, CLI und andere Upload-Methoden, Dateien von den IPFS- und Arweave-Netzwerken sicher, bequem und effizient hochladen und speichern. Registrierte Nutzer erhalten 6 GB IPFS-Speicher und 300MB Arweave-Speicher kostenlos. Jegliche Arweave-Datei-Uploads unter 150 KB sind kostenlos.
  * [backblaze.com](https://www.backblaze.com/b2/) — Backblaze B2 Cloud-Speicher. 10 GB (Amazon S3-ähnlicher) Objektspeicher kostenlos und unbegrenzt lange nutzbar.
  * [filebase.com](https://filebase.com/) - S3-kompatibler Objektspeicher, betrieben durch Blockchain. 5 GB kostenloser Speicher für unbegrenzte Dauer.
  * [Tebi](https://tebi.io/) - S3-kompatibler Objektspeicher. 25 GB kostenloser Speicher und 250GB ausgehender Transfer.
  * [Idrive e2](https://www.idrive.com/e2/) - S3-kompatibler Objektspeicher. 10 GB kostenloser Speicher und 10 GB Download-Bandbreite pro Monat.
  * [C2 Object Storage](https://c2.synology.com/en-us/pricing/object-storage) - S3-kompatibler Objektspeicher. 15 GB kostenloser Speicher und 15 GB Downloads pro Monat.

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Verwaltete Datendienste

  * [Aiven](https://aiven.io/) - Aiven bietet kostenlose PostgreSQL-, MySQL- und Redis-Pläne auf seiner Open-Source-Datenplattform. Einzelner Node, 1 CPU, 1GB RAM, und für PostgreSQL und MySQL 5GB Speicher. Einfache Migration auf umfangreichere Pläne oder über mehrere Clouds.
  * [airtable.com](https://airtable.com/) — Sieht aus wie eine Tabelle, ist aber eine relationale Datenbank. Unbegrenzte Basen, 1.200 Zeilen/Basis und 1.000 API-Anfragen/Monat.
  * [Astra](https://www.datastax.com/products/datastax-astra/) — Cloud Native Cassandra as a Service mit [80GB kostenlosem Tarif](https://www.datastax.com/products/datastax-astra/pricing)
  * [codehooks.io](https://codehooks.io/) — Einfach zu verwendender JavaScript serverloser API/Backend- und NoSQL-Datenbankdienst mit Funktionen, Mongdb-ähnlichen Abfragen, Schlüssel/Wert-Suchen, einem Job-System, Echtzeit-Nachrichten, Worker-Queues, einem leistungsstarken CLI und einem webbasierten Datenmanager. Kostenloser Plan mit 5GB Speicher und 60 API-Aufrufen pro Minute. 2 Entwickler inklusive. Keine Kreditkarte erforderlich.
  * [CrateDB](https://crate.io/) - Verteilter Open-Source-SQL-Datenbank für Echtzeit-Analysen. [Free Tier CRFREE](https://crate.io/lp-crfree): Ein Node mit 2 CPUs, 2 GiB RAM, 8 GiB Speicher. Ein Cluster pro Organisation, keine Zahlungsmethode erforderlich.
  * [Upstash](https://upstash.com/) — Serverloses Redis mit kostenlosem Tarif bis zu 10.000 Anfragen pro Tag, 256MB max. Datenbankgröße und 20 gleichzeitigen Verbindungen.
  * [Couchbase Capella](https://www.couchbase.com/products/capella/) - Bereitstellung eines dauerhaft kostenlosen, vollständig verwalteten Datenbankclusters, gebaut für Entwickler zur Erstellung der nächsten Generation von Anwendungen von IoT bis KI.
  * [MongoDB Atlas](https://www.mongodb.com/cloud/atlas) — Kostenlose Stufe bietet 512 MB.
  * [redsmin.com](https://www.redsmin.com/) — Online-Echtzeitüberwachung und Verwaltungsdienst für Redis, Überwachung für 1 Redis-Instanz kostenlos.
  * [redislabs](https://redislabs.com/try-free/) - Kostenlose 30MB Redis-Instanz.
  * [MemCachier](https://www.memcachier.com/) — Verwalteter Memcache-Dienst. Kostenlos bis zu 25MB, 1 Proxy-Server und grundlegende Analysen.
  * [scalingo.com](https://scalingo.com/) — Hauptsächlich eine PaaS, bietet jedoch eine kostenlose Stufe von 128MB bis 192MB für MySQL, PostgreSQL oder MongoDB.
  * [SeaTable](https://seatable.io/) — Flexible, tabellenähnliche Datenbank vom Seafile-Team. Unbegrenzte Tabellen, 2.000 Zeilen, 1 Monat Versionierung, bis zu 25 Teammitglieder.
  * [skyvia.com](https://skyvia.com/) — Cloud Data Platform bietet eine kostenlose Stufe und alle Pläne sind während der Beta-Phase komplett kostenlos.
  * [StackBy](https://stackby.com/) — Ein Tool, das die Flexibilität von Tabellenkalkulationen, die Leistungsfähigkeit von Datenbanken und integrierte Integrationen mit Ihren bevorzugten Business-Apps kombiniert. Der kostenlose Plan umfasst unbegrenzte Nutzer, zehn Stacks und 2GB Anhänge pro Stack.
  * [TiDB Cloud](https://en.pingcap.com/tidb-cloud/) — TiDB ist eine Open-Source, MySQL-kompatible, verteilte HTAP-RDBMS. TiDB Serverless bietet 5GB Zeilenspeicher, 5GB Spaltenspeicher und 50 Millionen Request Units (RU) monatlich kostenlos.
  * [Turso by ChiselStrike](https://chiselstrike.com/) - Turso ist SQLite Developer Experience in einer Edge-Datenbank. Turso bietet einen Free-Forever-Starterplan, 9 GB Gesamtspeicher, bis zu 500 Datenbanken, bis zu 3 Standorte, 1 Milliarde Zeilenlesungen pro Monat und lokale Entwicklungsunterstützung mit SQLite.
  * [InfluxDB](https://www.influxdata.com/) — Zeitreihendatenbank, kostenlos bis zu 3MB/5 Minuten Schreiben, 30MB/5 Minuten Lesen und 10.000 Kardinalitätsserien.
  * [restdb.io](https://restdb.io/) - Eine schnelle und einfache NoSQL-Cloud-Datenbank. Mit restdb.io erhalten Sie Schema, Relationen, automatische REST-API (mit MongoDB-ähnlichen Abfragen) und eine effiziente Multi-User-Admin-UI zur Datenbearbeitung. Der kostenlose Plan erlaubt 3 Nutzer, 2500 Datensätze und 1 API-Anfrage pro Sekunde.
  * [CockroachDB Cloud](https://www.cockroachlabs.com/pricing/) — Kostenloser Tarif bietet 50 Millionen RUs und 10 GiB Speicher (entspricht $15 Wert) monatlich gratis. ([Was sind Request Units?](https://www.cockroachlabs.com/docs/cockroachcloud/metrics-request-units.html))
  * [Neo4j Aura](https://neo4j.com/cloud/aura/) — Verwaltete native Graph-DBMS-/Analyseplattform mit Cypher-Abfragesprache und REST-API. Begrenzungen für Graph-Größe (50k Knoten, 175k Beziehungen).
  * [Neon](https://neon.tech/) — Verwaltetes PostgreSQL, 0,5 GB Speicher (gesamt), 1 Projekt, 10 Branches, unbegrenzte Datenbanken, immer verfügbare Primär-Branch (automatische Suspendierung nach 5 Minuten), 20 Stunden aktive Zeit pro Monat (gesamt) für Nicht-Primär-Branch-Compute.
  * [Prisma Postgres](https://prisma.io/postgres) - Superschnelles gehostetes Postgres, gebaut auf Unikernels und laufend auf Bare Metal, 1GB Speicher, 10 Datenbanken, integriert mit Prisma ORM.
  * [Dgraph Cloud](https://cloud.dgraph.io/pricing?type=free) — Verwaltete native Graph-DBMS mit GraphQL-API. Begrenzung auf 1 MB Datentransfer pro Tag.
  * [Tinybird](https://tinybird.co) - Ein serverlos verwaltetes ClickHouse mit verbindungsloser Datenaufnahme über HTTP und der Möglichkeit, SQL-Abfragen als verwaltete HTTP-APIs zu veröffentlichen. Kein Zeitlimit im Free-Tier, 10GB Speicher + 1000 API-Anfragen pro Tag.
  * [TigerGraph Cloud](https://www.tigergraph.com/cloud/) — Verwaltete native Graph-DBMS-/Analyseplattform mit SQL-ähnlicher Graph-Abfragesprache und REST-API. Eine kostenlose Instanz mit zwei vCPU, 8GB RAM und 50GB Speicher, die nach 1 Stunde Inaktivität schläft.
  * [TerminusCMS](https://terminusdb.com/pricing) — Verwalteter kostenloser Dienst für TerminusDB, eine in Prolog und Rust geschriebene Dokument- und Graphdatenbank. Kostenlos für Entwickler, kostenpflichtiger Service für Unternehmensbereitstellung und Support.
  * [filess.io](https://filess.io) - filess.io ist eine Plattform, auf der Sie zwei Datenbanken mit bis zu 10 MB pro Datenbank der folgenden DBMS kostenlos erstellen können: MySQL, MariaDB, MongoDB und PostgreSQL.
  * [xata.io](https://xata.io) - Xata ist eine serverlose Datenbank mit eingebauter leistungsstarker Suche und Analytics. Eine API, mehrere typensichere Clientbibliotheken und optimiert für Ihren Entwicklungsworkflow. Das Free-Forever-Tier ist ausreichend für Hobbyentwickler und beinhaltet drei Xata-Einheiten, bitte siehe Website für die Definition der Einheit.
  * [8base.com](https://www.8base.com/) - 8base ist eine Full-Stack-Low-Code-Entwicklungsplattform für JavaScript-Entwickler, basierend auf MySQL und GraphQL sowie serverlosem Backend-as-a-Service. Sie ermöglicht den schnellen Start von Webanwendungen per UI-App-Builder und das schnelle Skalieren. Das Free-Tier umfasst Zeilen: 2.500, Speicher: 500, Serverless-Computing: 1Gb/h und Client-App-Nutzer: 5.
  * [Nile](https://www.thenile.dev/) — Eine Postgres-Plattform für B2B-Apps. Unbegrenzte Datenbanken, immer verfügbar ohne Abschaltung, 1GB Gesamtspeicher, 50 Millionen Abfrage-Token, Autoskalierung, unbegrenzte Vektor-Embeddings



**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Tunneling, WebRTC, Web Socket Server und andere Router

  * [Pinggy](https://pinggy.io) — Öffentliche URLs für localhost mit nur einem Befehl, kein Download erforderlich. HTTPS / TCP / TLS-Tunnel. Der kostenlose Plan hat eine Tunnel-Lebensdauer von 60 Minuten.
  * [conveyor.cloud](https://conveyor.cloud/) — Visual-Studio-Erweiterung, um IIS Express im lokalen Netzwerk oder über einen Tunnel zu einer öffentlichen URL verfügbar zu machen.
  * [Hamachi](https://www.vpn.net/) — LogMeIn Hamachi ist ein gehosteter VPN-Dienst, der es ermöglicht, LAN-ähnliche Netzwerke sicher auf verteilte Teams auszudehnen, mit einem kostenlosen Plan für unbegrenzte Netzwerke mit bis zu 5 Personen.
  * [Mirna Sockets](https://mirna.cloud/) - Kostenloses Socket-as-a-Service-Platform, die Ihnen eine wss://-URL beim Bereitstellen Ihres Web-Socket-Server-Codes gibt und auch Leistungsüberwachung ermöglicht.
  * [localhost.run](https://localhost.run/) — Lokal laufende Server über einen Tunnel zu einer öffentlichen URL bereitstellen.
  * [localtunnel](https://theboroer.github.io/localtunnel-www/) — Lokal laufende Server über einen Tunnel zu einer öffentlichen URL bereitstellen. Kostenlos gehostete Version und [Open Source](https://github.com/localtunnel/localtunnel).
  * [ngrok.com](https://ngrok.com/) — Lokal laufende Server über einen Tunnel zu einer öffentlichen URL bereitstellen.
  * [cname.dev](https://cname.dev/) — Kostenloser und sicherer dynamischer Reverse-Proxy-Dienst.
  * [serveo](https://serveo.net/) — Lokale Server ins Internet exponieren. Keine Installation, keine Anmeldung. Kostenlose Subdomain, keine Begrenzungen.
  * [Radmin VPN](https://www.radmin-vpn.com/) — Mehrere Computer über ein VPN verbinden, wodurch ein LAN-ähnliches Netzwerk entsteht. Unbegrenzte Peers. (Hamachi-Alternative)
  * [segment.com](https://segment.com/) — Hub zum Übersetzen und Weiterleiten von Ereignissen an andere Drittanbieter-Dienste. 100.000 Events/Monat kostenlos.
  * Google STUN — [stun:stun.l.google.com:19302](stun:stun.l.google.com:19302)
  * Twilio STUN — [stun:global.stun.twilio.com:3478?transport=udp](stun:global.stun.twilio.com:3478?transport=udp)
  * [Tailscale](https://tailscale.com/) — Zero-Config-VPN, nutzt das Open-Source-Protokoll WireGuard. Installationen für MacOS, iOS, Windows, Linux und Android. Kostenloser Plan für privaten Gebrauch mit 100 Geräten und drei Nutzern.
  * [webhookrelay.com](https://webhookrelay.com) — Webhooks verwalten, debuggen, verteilen und an öffentliche oder interne (z.B. localhost) Ziele weiterleiten. Außerdem lassen sich Server, die in einem privaten Netzwerk laufen, über einen Tunnel über eine öffentliche HTTP-Endpunkt-URL (`https://yoursubdomain.webrelay.io <----> http://localhost:8080`) verfügbar machen.
  * [Hookdeck](https://hookdeck.com/pricing) — Entwickeln, testen und überwachen Sie Ihre Webhooks von überall. 100.000 Anfragen und 100.000 Versuche pro Monat mit drei Tagen Aufbewahrung.
  * [Xirsys](https://www.xirsys.com/pricing/) — Unbegrenzte STUN-Nutzung + 500 MB monatliche TURN-Bandbreite, begrenzte Bandbreite, eine geografische Region.
  * [ZeroTier](https://www.zerotier.com) — FOSS-verwaltetes virtuelles Ethernet als Service. Unbegrenzte End-to-End-verschlüsselte Netzwerke mit 25 Clients im kostenlosen Plan. Clients für Desktop/Mobile/NA; Web-Oberfläche zur Konfiguration eigener Routingregeln und Freigabe neuer Clientknoten in privaten Netzwerken.
  * [LocalXpose](https://localxpose.io) — Reverse Proxy, der es ermöglicht, Ihre lokalen Server ins Internet zu exponieren. Der kostenlose Plan hat eine Tunnel-Lebensdauer von 15 Minuten.
  * [Traefik-Hub](https://traefik.io/traefik-hub/) - Veröffentlichen Sie lokal laufende Dienste über einen Tunnel zu einer öffentlichen benutzerdefinierten URL und sichern Sie sie mit Zugriffskontrolle. Kostenlos für 5 Dienste in einem Cluster.
  * [Expose](https://expose.dev/) - Exponieren Sie lokale Seiten über sichere Tunnel. Der kostenlose Plan beinhaltet einen EU-Server, zufällige Subdomains und Einzelbenutzer.
  * [btunnel](https://www.btunnel.in/) — Exponieren Sie localhost und lokale TCP-Server ins Internet. Kostenloser Plan beinhaltet Dateiserver, benutzerdefinierte HTTP-Anfrage- und -Antwort-Header, Basisauthentifizierung und 1 Stunde Tunnel-Timeout.

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Issue Tracking und Projektmanagement

  * [acunote.com](https://www.acunote.com/) — Kostenlose Projektmanagement- und SCRUM-Software für bis zu 5 Teammitglieder
  * [asana.com](https://asana.com/) — Kostenlos für private Projekte mit Mitwirkenden
  * [Backlog](https://backlog.com) — Alles, was Ihr Team für die Veröffentlichung großartiger Projekte auf einer Plattform benötigt. Der kostenlose Plan bietet 1 Projekt mit zehn Nutzern & 100MB Speicher.
  * [Basecamp](https://basecamp.com/personal) - Aufgabenlisten, Meilensteinmanagement, forumähnliche Nachrichten, Dateifreigabe und Zeiterfassung. Bis zu 3 Projekte, 20 Nutzer und 1GB Speicherplatz.
  * [bitrix24.com](https://www.bitrix24.com/) — Intranet- und Projektmanagement-Tool. Der kostenlose Plan hat 5GB für unbegrenzt viele Nutzer.
  * [cacoo.com](https://cacoo.com/) — Online-Echtzeitdiagramme: Flussdiagramm, UML, Netzwerk. Kostenlos max. 15 Nutzer/Diagramm, 25 Blätter.
  * [Chpokify](https://chpokify.com/) — Team-basiertes Planning Poker, das Zeit bei der Sprint-Schätzung spart. Kostenlos für bis zu 5 Nutzer, kostenlose Jira-Integrationen, unbegrenzte Videoanrufe, unbegrenzte Teams, unbegrenzte Sessions.
  * [clickup.com](https://clickup.com/) — Projektmanagement. Kostenlos, Premium-Version mit Cloud-Speicher. Mobile Anwendungen und Git-Integrationen verfügbar.
  * [Clockify](https://clockify.me) - Zeiterfassungs- und Arbeitszeittabellen-App, mit der Sie Arbeitsstunden projektübergreifend verfolgen können. Unbegrenzte Nutzer, dauerhaft kostenlos.
  * [Cloudcraft](https://cloudcraft.co/) — Entwerfen Sie professionelle Architekturdiagramme in wenigen Minuten mit dem Cloudcraft Visual Designer, optimiert für AWS mit intelligenten Komponenten, die auch Live-Daten anzeigen. Kostenloser Plan hat unbegrenzte private Diagramme für Einzelbenutzer.
  * [Codegiant](https://codegiant.io) — Projektmanagement mit Repository-Hosting & CI/CD. Kostenloser Plan bietet unbegrenzte Repositories, Projekte & Dokumente mit 5 Teammitgliedern. 500 CI/CD-Minuten pro Monat. 30.000 Serverless-Code-Ausführungsminuten pro Monat, 1GB Repository-Speicher.
  * [Confluence](https://www.atlassian.com/software/confluence) - Atlassians Tool für Inhaltskollaboration zur effizienten Zusammenarbeit und Wissensaustausch im Team. Kostenloser Plan für bis zu 10 Nutzer.
  * [contriber.com](https://www.contriber.com/) — Anpassbare Projektmanagementplattform, kostenloser Starter-Plan, fünf Arbeitsbereiche
* [Crosswork](https://crosswork.app/) – Vielseitige Projektmanagement-Plattform. Kostenlos für bis zu 3 Projekte, unbegrenzte Nutzer, 1 GB Speicherplatz.
* [diagrams.net](https://app.diagrams.net/) – Online-Diagramme, die lokal in Google Drive, OneDrive oder Dropbox gespeichert werden. Kostenlos für alle Funktionen und Speicherstufen.
* [freedcamp.com](https://freedcamp.com/) – Aufgaben, Diskussionen, Meilensteine, Zeiterfassung, Kalender, Dateien und Passwort-Manager. Kostenloser Plan mit unbegrenzten Projekten, Nutzern und Dateispeicher.
* [easyretro.io](https://www.easyretro.io/) – Einfaches und intuitives Tool für Sprint-Retrospektiven. Der kostenlose Plan umfasst drei öffentliche Boards und eine Umfrage pro Board und Monat.
* [GForge](https://gforge.com) – Projektmanagement- und Issue-Tracking-Toolset für komplexe Projekte mit On-Premises- und SaaS-Optionen. Der SaaS-Kostenlos-Plan bietet die ersten fünf Nutzer gratis & kostenlos für Open-Source-Projekte.
* [gleek.io](https://www.gleek.io) – Kostenloses Beschreibung-zu-Diagramm-Tool für Entwickler. Erstellen Sie informelle UML-Klassen-, Objekt- oder Entity-Relationship-Diagramme anhand von Schlüsselwörtern.
* [GraphQL Inspector](https://github.com/marketplace/graphql-inspector) – GraphQL Inspector gibt eine Liste der Änderungen zwischen zwei GraphQL-Schemas aus. Jeder Unterschied wird präzise erklärt und als breaking, non-breaking oder dangerous markiert.
* [huboard.com](https://huboard.com/) – Sofortiges Projektmanagement für Ihre GitHub-Issues, kostenlos für Open Source.
* [Hygger](https://hygger.io) – Projektmanagement-Plattform. Der kostenlose Plan bietet unbegrenzte Nutzer, Projekte & Boards mit 100 MB Speicherplatz.
* [Instabug](https://instabug.com) – Umfassendes Bug-Reporting und In-App-Feedback-SDK für mobile Apps. Kostenloser Plan für bis zu 1 App und ein Mitglied.
* [WishKit](https://wishkit.io) – Sammeln Sie In-App-Benutzerfeedback für Ihre iOS/macOS-App und priorisieren Sie Features basierend auf Benutzerstimmen. Kostenloser Plan für bis zu 1 App.
* [Ilograph](https://www.ilograph.com/) – Interaktive Diagramme, die es Nutzern ermöglichen, ihre Infrastruktur aus verschiedenen Perspektiven und Detailebenen zu betrachten. Diagramme können im Code ausgedrückt werden. Die kostenlose Stufe bietet unbegrenzte private Diagramme mit bis zu 3 Betrachtern.
* [Jira](https://www.atlassian.com/software/jira) – Fortschrittliches Projektmanagement-Tool für Softwareentwicklung, in vielen Unternehmen im Einsatz. Kostenloser Plan für bis zu 10 Nutzer.
* [kanbanflow.com](https://kanbanflow.com/) – Board-basiertes Projektmanagement. Kostenlos, Premium-Version mit mehr Optionen.
* [kanbantool.com](https://kanbantool.com/) – Kanban-Board-basiertes Projektmanagement. Der kostenlose Plan bietet zwei Boards und zwei Nutzer, ohne Anhänge oder Dateien.
* [kan.bn](https://kan.bn/) – Eine leistungsstarke, flexible Kanban-App, die hilft, Arbeit zu organisieren, Fortschritt zu verfolgen und Ergebnisse zu liefern – alles an einem Ort. Kostenloser Plan für 1 Nutzer mit unbegrenzten Boards, Listen und Karten.
* [Kitemaker.co](https://kitemaker.co) – Zusammenarbeit in allen Phasen des Produktentwicklungsprozesses und Verfolgung der Arbeit über Slack, Discord, Figma und Github hinweg. Unbegrenzte Nutzer, unbegrenzte Bereiche. Kostenloser Plan für bis zu 250 Arbeitsaufgaben.
* [Kiter.app](https://www.kiter.app/) – Ermöglicht jedem, die Jobsuche zu organisieren und Interviews, Chancen und Kontakte zu verfolgen. Leistungsstarke Web-App und Chrome-Erweiterung. Komplett kostenlos.
* [Kumu.io](https://kumu.io/) – Beziehungsdiagramme mit Animationen, Dekorationen, Filtern, Clusterung, Tabellenimporten etc. Die kostenlose Stufe erlaubt unbegrenzte öffentliche Projekte. Diagrammgröße unbegrenzt. Kostenlose private Projekte für Studierende. Sandbox-Modus verfügbar, wenn Sie Ihre Datei nicht öffentlich online lassen möchten (hochladen, bearbeiten, herunterladen, verwerfen).
* [Linear](https://linear.app/) – Issue-Tracker mit schlanker Benutzeroberfläche. Kostenlos für unbegrenzte Mitglieder, bis zu 10MB Dateiupload, 250 Issues (ausgenommen Archiv).
* [leiga.com](https://www.leiga.com/) – Leiga ist ein SaaS-Produkt, das KI nutzt, um Ihre Projekte automatisch zu verwalten, Ihr Team fokussiert zu halten und großes Potenzial freizusetzen, sodass Ihre Projekte wie geplant verlaufen. Kostenlos für bis zu 10 Nutzer, 20 benutzerdefinierte Felder, 2GB Speicherplatz, Videoaufzeichnung mit KI auf 5 Minuten/Video begrenzt, Automatisierungsläufe 20/Nutzer/Monat.
* [Lucidchart](https://www.lucidchart.com/) – Online-Diagrammtool mit Kollaborationsfunktionen. Kostenloser Plan mit drei bearbeitbaren Dokumenten, 100 professionellen Vorlagen und grundlegenden Kollaborationsfunktionen.
* [MeisterTask](https://www.meistertask.com/) – Online-Aufgabenmanagement für Teams. Kostenlos bis zu 3 Projekte und unbegrenzte Projektmitglieder.
* [MeuScrum](https://www.meuscrum.com/en) – Kostenloses Online-Scrum-Tool mit Kanban-Board.
* [nTask](https://www.ntaskmanager.com/) – Projektmanagement-Software, die Teams Zusammenarbeit, Planung, Analyse und Verwaltung täglicher Aufgaben ermöglicht. Der Essential-Plan ist dauerhaft kostenlos mit 100 MB Speicher und fünf Nutzern/Teams. Unbegrenzte Workspaces, Meetings, Aufgaben, Stundenzettel und Issue-Tracking.
* [Ora](https://ora.pm/) – Agiles Aufgabenmanagement & Team-Kollaboration. Kostenlos für bis zu 3 Nutzer, Dateien sind auf 10 MB begrenzt.
* [pivotaltracker.com](https://www.pivotaltracker.com/) – Kostenlos für unbegrenzte öffentliche Projekte und zwei private Projekte mit insgesamt drei aktiven Nutzern (Lese-/Schreibrechte) und unbegrenzten passiven Nutzern (nur Leserechte).
* [plan.io](https://plan.io/) – Projektmanagement mit Repository-Hosting und weiteren Optionen. Kostenlos für zwei Nutzer mit zehn Kunden und 500MB Speicher.
* [Plane](https://plane.so/) – Plane ist ein einfaches, erweiterbares, Open-Source-Projekt- und Produktmanagement-Tool. Kostenlos für unbegrenzte Mitglieder, bis zu 5MB Dateiupload, 1000 Issues.
* [planitpoker.com](https://www.planitpoker.com/) – Kostenloses Online-Planning-Poker (Schätztool).
* [point.poker](https://www.point.poker/) – Online Planning Poker (konsensbasiertes Schätztool). Kostenlos für unbegrenzte Nutzer, Teams, Sessions, Runden und Abstimmungen. Keine Registrierung nötig.
* [ScrumFast](https://www.scrumfast.com) – Scrum-Board mit sehr intuitiver Benutzeroberfläche, kostenlos für bis zu 5 Nutzer.
* [Shake](https://www.shakebugs.com/) – In-App-Bug-Reporting und Feedback-Tool für mobile Apps. Kostenloser Plan, zehn Bug-Reports pro App/Monat.
* [Shortcut](https://shortcut.com/) – Projektmanagement-Plattform. Kostenlos für bis zu 10 Nutzer für immer.
* [Tadum](https://tadum.app) – Meeting-Agenda- und Protokoll-App für wiederkehrende Meetings, kostenlos für Teams bis zu 10 Personen.
* [taiga.io](https://taiga.io/) – Projektmanagement-Plattform für Startups und agile Entwickler, kostenlos für Open Source.
* [Tara AI](https://tara.ai/) – Einfacher Sprint-Management-Service. Der kostenlose Plan hat unbegrenzte Aufgaben, Sprints und Workspaces ohne Nutzerbegrenzung.
* [targetprocess.com](https://www.targetprocess.com/) – Visuelles Projektmanagement, von Kanban und Scrum bis fast jeden operativen Prozess. Kostenlos für unbegrenzte Nutzer, bis zu 1.000 Datenentitäten {[weitere Details](https://www.targetprocess.com/pricing/)}
* [taskade.com](https://www.taskade.com/) – Echtzeit-kollaborative Aufgabenlisten und Team-Gliederungen. Der kostenlose Plan bietet einen Workspace mit unbegrenzten Aufgaben und Projekten; 1GB Dateispeicher; 1 Woche Projekthistorie; und fünf Teilnehmer pro Videomeeting.
* [taskulu.com](https://taskulu.com/) – Rollenbasiertes Projektmanagement. Kostenlos bis zu 5 Nutzer. Integration mit GitHub/Trello/Dropbox/Google Drive.
* [Teaminal](https://www.teaminal.com) – Standup-, Retro- und Sprint-Planungstool für Remote-Teams. Kostenlos für bis zu 15 Nutzer.
* [teamwork.com](https://teamwork.com/) – Projektmanagement & Team-Chat. Kostenlos für fünf Nutzer und zwei Projekte. Premium-Pläne verfügbar.
* [teleretro.com](https://www.teleretro.com/) – Einfaches und spaßiges Retrospektiven-Tool mit Eisbrechern, Gifs und Emojis. Der kostenlose Plan beinhaltet drei Retros und unbegrenzte Mitglieder.
* [testlio.com](https://testlio.com/) – Issue-Tracking, Testmanagement und Beta-Testplattform. Kostenlos für privaten Gebrauch.
* [terrastruct.com](https://terrastruct.com/) – Online-Diagramm-Tool speziell für Software-Architektur. Kostenlos bis zu 4 Ebenen pro Diagramm.
* [todoist.com](https://todoist.com/) – Kollaboratives und individuelles Aufgabenmanagement. Der kostenlose Plan beinhaltet: 5 aktive Projekte, fünf Nutzer pro Projekt, Datei-Uploads bis zu 5MB, drei Filter und eine Woche Aktivitätshistorie.
* [trello.com](https://trello.com/) – Board-basiertes Projektmanagement. Unbegrenzte persönliche Boards, 10 Team-Boards.
* [Tweek](https://tweek.so/) – Einfacher wöchentlicher To-Do-Kalender & Aufgabenmanagement.
* [ubertesters.com](https://ubertesters.com/) – Testplattform, Integration und Crowd-Tester, 2 Projekte, fünf Mitglieder.
* [Wikifactory](https://wikifactory.com/) – Produktdesign-Service mit Projekten, VCS & Issues. Der kostenlose Plan bietet unbegrenzte Projekte & Mitarbeiter und 3GB Speicher.
* [Yodiz](https://www.yodiz.com/) – Agile Entwicklung und Issue-Tracking. Kostenlos bis zu 3 Nutzer, unbegrenzte Projekte.
* [YouTrack](https://www.jetbrains.com/youtrack/buy/#edition=incloud) – Kostenlos gehostetes YouTrack (InCloud) für FOSS-Projekte und private Projekte (kostenlos für drei Nutzer). Enthält Zeiterfassung und agile Boards.
* [zenhub.com](https://www.zenhub.com) – Die einzige Projektmanagement-Lösung direkt in GitHub. Kostenlos für öffentliche Repos, OSS und gemeinnützige Organisationen.
* [zenkit.com](https://zenkit.com) – Projektmanagement- und Kollaborationstool. Kostenlos für bis zu 5 Mitglieder, 5 GB Anhänge.
* [Zube](https://zube.io) – Projektmanagement mit kostenlosem Plan für 4 Projekte & 4 Nutzer. GitHub-Integration verfügbar.
* [Toggl](https://toggl.com/) – Bietet zwei kostenlose Produktivitäts-Tools. [Toggl Track](https://toggl.com/track/) für Zeitmanagement und Zeiterfassungs-App mit kostenlosem Plan, der nahtlose Zeiterfassung und Berichterstattung bietet, speziell für Freelancer. Unbegrenzte Zeiterfassungen, Projekte, Kunden, Tags, Berichte und mehr. Und [Toggl Plan](https://toggl.com/plan/) für Aufgabenplanung mit kostenlosem Plan für Einzelentwickler, unbegrenzte Aufgaben, Meilensteine und Zeitpläne.
* [Sflow](https://sflow.io) – sflow.io ist ein Projektmanagement-Tool für agile Softwareentwicklung, Marketing, Vertrieb und Kundensupport, besonders für Outsourcing und organisationsübergreifende Kollaborationsprojekte. Kostenloser Plan für bis zu 3 Projekte und fünf Mitglieder.
* [Pulse.red](https://pulse.red) – Kostenloser minimalistischer Zeiterfassungs- und Stundenzettel-App für Projekte.

**[⬆️ Nach oben](#table-of-contents)**

## Storage und Medienverarbeitung

* [AndroidFileHost](https://androidfilehost.com/) – Kostenloses File-Sharing-Portal mit unbegrenzter Geschwindigkeit, Bandbreite, Dateianzahl, Download-Anzahl usw. Hauptsächlich für Android-Entwicklerdateien wie APK-Builds, Custom ROMs & Modifikationen gedacht, akzeptiert aber scheinbar auch andere Dateien.
* [borgbase.com](https://www.borgbase.com/) – Einfaches und sicheres Offsite-Backup-Hosting für Borg Backup. 10 GB kostenloser Backup-Speicher und zwei Repositories.
* [icedrive.net](https://www.icedrive.net/) – Einfacher Cloud-Speicherdienst. 10 GB kostenloser Speicher.
* [sync.com](https://www.sync.com/) – End-to-End-Cloud-Speicherdienst. 5 GB kostenloser Speicher.
* [pcloud.com](https://www.pcloud.com/) – Cloud-Speicherdienst. Bis zu 10 GB kostenloser Speicher.
* [sirv.com](https://sirv.com/) – Intelligentes Bild-CDN mit On-the-Fly-Bildoptimierung und -Größenänderung. Die kostenlose Stufe umfasst 500 MB Speicher und 2 GB Bandbreite.
* [cloudimage.io](https://www.cloudimage.io/en/home) – Vollständiger Bildoptimierungs- und CDN-Service mit 1500+ Points of Presence weltweit. Vielfältige Bildgrößenanpassung, Komprimierungs- und Wasserzeichenfunktionen. Open-Source-Plugins für responsive Bilder, 360°-Bilderstellung und Bildbearbeitung. Kostenloser Monatsplan mit 25GB CDN-Traffic, 25GB Cache-Speicher und unbegrenzten Transformationen.
* [cloudinary.com](https://cloudinary.com/) – Bild-Upload, leistungsstarke Manipulationen, Speicherung und Auslieferung für Websites und Apps, mit Ruby-, Python-, Java-, PHP-, Objective-C- und weiteren Bibliotheken. Die kostenlose Stufe umfasst 25 monatliche Credits. Ein Credit entspricht 1.000 Bildtransformationen, 1 GB Speicher oder 1 GB CDN-Nutzung.
* [embed.ly](https://embed.ly/) – Bietet APIs zum Einbetten von Medien auf Webseiten, responsives Skalieren von Bildern und Extrahieren von Elementen aus Webseiten. Kostenlos für bis zu 5.000 URLs/Monat bei 15 Anfragen/Sekunde.
* [filestack.com](https://www.filestack.com/) – Dateiauswahl, -transformation und -auslieferung, kostenlos für 250 Dateien, 500 Transformationen und 3 GB Bandbreite.
* [file.io](https://www.file.io) – 2 GB Dateispeicher. Eine Datei wird nach einem Download automatisch gelöscht. REST-API zur Interaktion mit dem Speicher. Rate-Limit: eine Anfrage/Minute.
* [freetools.site](https://freetools.site/) – Kostenlose Online-Tools. Dokumente, Bilder, Audio, Video und mehr konvertieren oder bearbeiten.
* [GoFile.io](https://gofile.io/) – Kostenloses File-Sharing- und Speicherportal, nutzbar über Web-UI & auch API. Unbegrenzte Dateigröße, Bandbreite, Download-Anzahl usw. Dateien werden jedoch gelöscht, wenn sie inaktiv werden (kein Download mehr als zehn Tage).
* [gumlet.com](https://www.gumlet.com/) – Bild- und Video-Hosting, -Verarbeitung und -Streaming via CDN. Großzügige kostenlose Stufe mit 250 GB/Monat für Videos und 30 GB/Monat für Bilder.
* [image-charts.com](https://www.image-charts.com/) – Unbegrenzte Bilddiagrammerstellung mit Wasserzeichen.
* [Imgbot](https://github.com/marketplace/imgbot) – Imgbot ist ein freundlicher Roboter, der Ihre Bilder optimiert und Ihnen Zeit spart. Optimierte Bilder bedeuten kleinere Dateigrößen ohne Qualitätsverlust. Kostenlos für Open Source.
* [ImgBB](https://imgbb.com/) – ImgBB ist ein unbegrenzter Bildhosting-Service. Ziehen Sie Ihr Bild einfach auf den Bildschirm. 32 MB / Bild Limit. Erhalten Sie nach dem Upload Direktlinks, BBCode und HTML-Thumbnails. Anmeldung zeigt Upload-Verlauf.
* [imgen](https://www.jitbit.com/imgen/) – Kostenlose unbegrenzte API zur Erstellung von Social-Cover-Bildern, kein Wasserzeichen.
* [imgix](https://www.imgix.com/) – Bild-Caching, -Verwaltung und CDN. Kostenloser Plan mit 1000 Ursprungsbildern, unbegrenzten Transformationen und 100 GB Bandbreite.
* [kraken.io](https://kraken.io/) – Bildoptimierung als Service für Website-Performance, kostenloser Plan bis zu 1 MB Dateigröße.
* [kvstore.io](https://www.kvstore.io/) – Key-Value-Speicherdienst. Die kostenlose Stufe erlaubt 100 Schlüssel, 1KB/Schlüssel, 100 Aufrufe/Stunde.
* [npoint.io](https://www.npoint.io/) – JSON-Store mit kollaborativem Schema-Editor.
* [nitropack.io](https://nitropack.io/) – Beschleunigen Sie die Geschwindigkeit Ihrer Website automatisch mit kompletter Frontend-Optimierung (Caching, Bild- und Codeoptimierung, CDN). Kostenlos für bis zu 5.000 Seitenaufrufe/Monat.
* [otixo.com](https://www.otixo.com/) – Verschlüsseln, teilen, kopieren und verschieben Sie alle Ihre Cloud-Speicherdateien von einem Ort aus. Der Basisplan bietet unbegrenzte Dateiübertragungen mit max. 250 MB Dateigröße und erlaubt fünf verschlüsselte Dateien.
* [packagecloud.io](https://packagecloud.io/) – Gehostete Paket-Repositories für YUM, APT, RubyGem und PyPI. Begrenzte kostenlose Pläne und Open-Source-Pläne auf Anfrage erhältlich.
* [getpantry.cloud](https://getpantry.cloud/) – Eine einfache JSON-Datenspeicher-API, perfekt für persönliche Projekte, Hackathons und Mobile Apps!
* [Pinata IPFS](https://pinata.cloud) – Pinata ist der einfachste Weg, Dateien auf IPFS hochzuladen und zu verwalten. Benutzerfreundliche Oberfläche und IPFS-API machen Pinata zum einfachsten IPFS-Pinning-Dienst für Plattformen, Kreative und Sammler. 1 GB Speicher kostenlos, inklusive API-Zugriff.
* [placekitten.com](https://placekitten.com/) – Schneller und einfacher Dienst für Platzhalterbilder von Kätzchen.
* [plot.ly](https://plot.ly/) – Visualisieren und teilen Sie Ihre Daten. Die kostenlose Stufe umfasst unbegrenzte öffentliche Dateien und zehn private Dateien.
* [podio.com](https://podio.com/) – Sie können Podio mit einem Team von bis zu fünf Personen nutzen und die Funktionen des Basic-Plans testen, außer Benutzerverwaltung.
* [QRME.SH](https://qrme.sh) – Schneller, schöner Bulk-QR-Code-Generator – kein Login, kein Wasserzeichen, keine Werbung. Bis zu 100 URLs pro Bulk-Export.
* [QuickChart](https://quickchart.io) – Einbettbare Bilddiagramme, Graphen und QR-Codes generieren.
* [redbooth.com](https://redbooth.com) – P2P-Dateisynchronisation, kostenlos für bis zu 2 Nutzer.
* [resmush.it](https://resmush.it) – reSmush.it ist eine KOSTENLOSE API zur Bildoptimierung. reSmush.it ist in den gängigsten CMS wie WordPress, Drupal oder Magento implementiert. reSmush.it ist die meistgenutzte Bildoptimierungs-API mit über sieben Milliarden behandelten Bildern – weiterhin kostenlos.
* [Shotstack](https://shotstack.io) – API zur skalierbaren Videoerstellung und -bearbeitung. Kostenlos bis zu 20 Minuten gerendertes Video pro Monat.
* [tinypng.com](https://tinypng.com/) – API zum Komprimieren und Skalieren von PNG- und JPEG-Bildern, bietet 500 Komprimierungen pro Monat kostenlos.
* [transloadit.com](https://transloadit.com/) – Handhabt Datei-Uploads und das Encoding von Video, Audio, Bildern, Dokumenten. Kostenlos für Open Source, gemeinnützige Organisationen und Studierende über das GitHub Student Developer Pack. Kommerzielle Anwendungen erhalten 2 GB kostenlos zum Ausprobieren.
* [twicpics.com](https://www.twicpics.com) – Responsive Images as a Service. Bietet ein Image-CDN, eine Medienverarbeitungs-API und eine Frontend-Bibliothek zur Automatisierung der Bildoptimierung. Der Service ist bis zu 3 GB Traffic/Monat kostenlos.
* [uploadcare.com](https://uploadcare.com/hub/developers/) — Uploadcare stellt die Media Pipeline mit dem ultimativen Toolkit auf Basis modernster Algorithmen bereit. Alle Funktionen stehen Entwicklern absolut kostenlos zur Verfügung: File Uploading API und UI, Image CDN und Origin Services, Adaptive Delivery und Smart Compression. Das kostenlose Kontingent umfasst 3.000 Uploads, 3 GB Traffic und 3 GB Speicher.
* [imagekit.io](https://imagekit.io) – Image CDN mit automatischer Optimierung, Echtzeit-Transformation und Speicher, das sich innerhalb von Minuten in bestehende Setups integrieren lässt. Der kostenlose Plan umfasst bis zu 20 GB Bandbreite pro Monat.
* [internxt.com](https://internxt.com) – Internxt Drive ist ein Zero-Knowledge-Dateispeicherdienst basierend auf absoluter Privatsphäre und kompromissloser Sicherheit. Melden Sie sich an und erhalten Sie 10 GB kostenlos, für immer!
* [degoo.com](https://degoo.com/) – KI-basierter Cloud-Speicher mit bis zu 20 GB kostenlos, drei Geräten, 5 GB Empfehlungsbonus (90 Tage Inaktivität führen zur Sperrung).
* [MConverter.eu](https://mconverter.eu/) – Dateien in großen Mengen konvertieren. Unterstützt viele Dateiformate, darunter neue wie [AVIF](https://mconverter.eu/convert/to/avif/). Extrahiert alle Einzelbilder aus Videos. Kostenlos für bis zu zehn 100MB-Dateien pro Tag, verarbeitet in Zweier-Chargen.
* [ImageEngine](https://imageengine.io/) – ImageEngine ist ein einfach zu benutzendes globales Image-CDN. In unter 60 Sekunden eingerichtet. AVIF- und JPEGXL-Unterstützung, Plugins für WordPress, Magento, React, Vue und mehr. Fordern Sie Ihr kostenloses Entwicklerkonto [hier](https://imageengine.io/developer-program/) an.
* [DocsParse](https://docsparse.com/) – KI-gestützte Verarbeitung von PDFs, Bildern in strukturierte Daten in JSON-, CSV-, EXCEL-Formaten. 30 Credits pro Monat kostenlos.
* [VaocherApp QR Code Generator](https://www.vaocherapp.com/qr-code-generator) – Erstellen Sie ganz einfach individuelle QR-Codes für Geschenkkarten, Gutscheine und Aktionen. Unterstützung von individueller Gestaltung, Farbe, Logo...
* [LibreQR](https://libreqr.com) — Kostenloser QR-Code-Generator mit Fokus auf Datenschutz und ohne Tracking. Kostenlose Nutzung ohne Datenerhebung.


**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Design und UI

* [AllTheFreeStock](https://allthefreestock.com) – Eine kuratierte Liste kostenloser Stockbilder, -audios und -videos.
* [Float UI](https://floatui.com/) – Kostenloses Webentwicklungstool zur schnellen Erstellung moderner, responsiver Websites mit elegantem Design, auch für Nicht-Designer.
* [Ant Design Landing Page](https://landing.ant.design/) – Ant Design Landing Page bietet eine Vorlage, die mit Motion-Komponenten von Ant Motion erstellt wurde. Es gibt eine reichhaltige Startseitenvorlage, der Vorlagencode kann heruntergeladen und schnell genutzt werden. Mit dem Editor können Sie auch schnell Ihre eigene Seite bauen.
* [Backlight](https://backlight.dev/) — Mit der Zusammenarbeit zwischen Entwicklern und Designern im Fokus ist Backlight eine komplette Coding-Plattform, auf der Teams Designsysteme erstellen, dokumentieren, veröffentlichen, skalieren und pflegen. Der kostenlose Plan erlaubt bis zu 3 Editoren an einem Designsystem mit unbegrenzten Betrachtern.
* [BoxySVG](https://boxy-svg.com/app) — Eine kostenlose, installierbare Web-App zum Zeichnen von SVGs und Exportieren in SVG, PNG, JPEG und andere Formate.
* [Carousel Hero](https://carouselhero.com/) – Kostenloses Online-Tool zur Erstellung von Social-Media-Karussells.
* [Circum Icons](https://circumicons.com) – Konsistente Open-Source-Icons als SVG für React, Vue und Svelte.
* [clevebrush.com](https://www.cleverbrush.com/) — Kostenlose Grafikdesign-/Fotocollage-App. Außerdem bieten sie eine kostenpflichtige Integration als Komponente an.
* [cloudconvert.com](https://cloudconvert.com/) — Konvertieren Sie alles in alles. 208 unterstützte Formate, darunter Videos und GIFs.
* [CodeMyUI](https://codemyui.com) – Handverlesene Sammlung von Webdesign- & UI-Inspirationen mit Code-Beispielen.
* [ColorKit](https://colorkit.co/) – Erstellen Sie Farbpaletten online oder lassen Sie sich von Top-Paletten inspirieren.
* [coolors](https://coolors.co/) – Farbpaletten-Generator. Kostenlos.
* [CMYK Pantone](https://www.cmyktopantone.com/) – Konvertieren Sie ganz einfach CMYK-Werte in die nächstgelegenen Pantone-Farben und andere Farbmodelle in Sekunden kostenlos.
* [Branition](https://branition.com/colors) – Handkurierte Farbpaletten, die sich besonders für Marken eignen.
* [css-gradient.com](https://www.css-gradient.com/) – Kostenloses Tool zur schnellen Erstellung benutzerdefinierter, browserübergreifender CSS-Verläufe. In RGB- und HEX-Format.
* [easyvectors.com](https://easyvectors.com/) — EasyVectors.com ist eine kostenlose SVG-Vektorart-Bibliothek. Laden Sie die besten Vektorgrafiken absolut kostenlos herunter.
* [figma.com](https://www.figma.com) — Online, kollaboratives Designtool für Teams; kostenloser Tarif beinhaltet unbegrenzte Dateien und Betrachter, maximal 2 Editoren und drei Projekte.
* [Flyon UI](https://flyonui.com/) – Die einfachste Komponentenbibliothek für Tailwind CSS.
* [framer.com](https://www.framer.com/) – Framer hilft Ihnen, Interface-Ideen für Ihre nächste App, Website oder Produkt zu iterieren und zu animieren – beginnend mit leistungsstarken Layouts. Für alle, die Framer als professionelles Prototyping-Tool validieren möchten: unbegrenzte Betrachter, bis zu 2 Editoren und bis zu 3 Projekte.
* [freeforcommercialuse.net](https://freeforcommercialuse.net/) — FFCU Sorglos-Model-/Property-Release-Stockfotos
* [Gradientos](https://www.gradientos.app) – Macht das Auswählen eines Farbverlaufs schnell und einfach.
* [Icon Horse](https://icon.horse) – Holen Sie sich das Favicon in höchster Auflösung für jede Website über unsere einfache API.
* [Iconoir](https://iconoir.com) – Eine Open-Source-Icon-Bibliothek mit Tausenden von Icons, unterstützt React, React Native, Flutter, Vue, Figma und Framer.
* [Icons8](https://icons8.com) — Icons, Illustrationen, Fotos, Musik und Designwerkzeuge. Kostenloser Plan bietet eingeschränkte Formate in niedriger Auflösung. Verlinken Sie zu Icons8, wenn Sie unsere Ressourcen verwenden.
* [landen.co](https://www.landen.co) — Erstellen, bearbeiten und veröffentlichen Sie schöne Websites und Landingpages für Ihr Startup. Alles ohne Code. Der kostenlose Tarif erlaubt eine Website, vollständig anpassbar und veröffentlicht im Web.
* [Quant Ux](https://quant-ux.com/) – Quant Ux ist ein Prototyping- und Designtool. – Es ist komplett kostenlos und auch Open Source.
* [lensdump.com](https://lensdump.com/) – Kostenloses Cloud-Bildhosting.
* [Lorem Picsum](https://picsum.photos/) – Ein kostenloses, einfach zu bedienendes Tool für stilvolle Platzhalterbilder. Nach der URL einfach die gewünschte Bildgröße (Breite & Höhe) hinzufügen und Sie erhalten ein zufälliges Bild.
* [LottieFiles](https://lottiefiles.com/) – Die weltweit größte Online-Plattform für das kleinste Animationsformat der Welt – für Designer, Entwickler und mehr. Zugriff auf Lottie-Animationstools und Plugins für Android, iOS und Web.
* [MagicPattern](https://www.magicpattern.design/tools) — Eine Sammlung von CSS- & SVG-Hintergrund-Generatoren & Tools für Verläufe, Muster und Blobs.
* [marvelapp.com](https://marvelapp.com/) — Design, Prototyping und Zusammenarbeit, kostenloser Plan auf einen Nutzer und ein Projekt begrenzt.
* [Mindmup.com](https://www.mindmup.com/) — Unbegrenzte Mindmaps kostenlos und in der Cloud speichern. Ihre Mindmaps sind überall, sofort, von jedem Gerät aus verfügbar.
* [Mockplus iDoc](https://www.mockplus.com/idoc) – Mockplus iDoc ist ein leistungsstarkes Design-Kollaborations- & Handoff-Tool. Kostenloser Plan umfasst drei Nutzer und fünf Projekte mit allen Funktionen.
* [mockupmark.com](https://mockupmark.com/create/free) — Erstellen Sie realistische T-Shirt- und Kleidungsmockups für Social Media und E-Commerce, 40 kostenlose Mockups.
* [Mossaik](https://mossaik.app) – Kostenloser SVG-Bildgenerator mit verschiedenen Tools wie Wellen, Blobs und Mustern.
* [movingpencils.com](https://movingpencils.com) — Schneller, browserbasierter Vektoreditor. Komplett kostenlos.
* [Octopus.do](https://octopus.do) — Visueller Sitemap-Builder. Erstellen Sie die Struktur Ihrer Website in Echtzeit und teilen Sie sie schnell zur Zusammenarbeit mit Ihrem Team oder Kunden.
* [Pencil](https://github.com/evolus/pencil) – Open-Source-Designtool auf Electron-Basis.
* [Penpot](https://penpot.app) – Web-basiertes, Open-Source-Design- und Prototyping-Tool. Unterstützt SVG. Komplett kostenlos.
* [pexels.com](https://www.pexels.com/) – Kostenlose Stockfotos für die kommerzielle Nutzung. Bietet eine kostenlose API, um Fotos nach Stichworten zu suchen.
* [photopea.com](https://www.photopea.com) — Kostenloser, fortschrittlicher Online-Designeditor mit Adobe Photoshop UI, unterstützt PSD, XCF & Sketch-Formate (Adobe Photoshop, Gimp und Sketch App).
* [pixlr.com](https://pixlr.com/) — Kostenloser Online-Browsereditor auf dem Niveau kommerzieller Tools.
* [Plasmic](https://www.plasmic.app/) – Schnelles, einfach zu bedienendes, robustes Webdesign-Tool und Pagebuilder, der sich in Ihren Code integrieren lässt. Erstellen Sie responsive Seiten oder komplexe Komponenten; optional mit Code erweitern und direkt auf Produktionsseiten und Apps veröffentlichen.
* [Pravatar](https://pravatar.cc/) – Generieren Sie einen zufälligen/Platzhalter-Avatar, dessen URL direkt in Ihrer Web/App verlinkt werden kann.
* [Proto.io](https://www.proto.io) – Erstellen Sie vollständig interaktive UI-Prototypen ohne Coding. Der kostenlose Tarif ist nach Ablauf der Testphase verfügbar. Er beinhaltet einen Nutzer, ein Projekt, fünf Prototypen, 100 MB Online-Speicher und Vorschau in der proto.io-App.
* [resizeappicon.com](https://resizeappicon.com/) — Ein einfacher Service zum Ändern und Verwalten Ihrer App-Icons.
* [Rive](https://rive.app) — Erstellen und veröffentlichen Sie wunderschöne Animationen für jede Plattform. Für Einzelpersonen dauerhaft kostenlos. Der Service ist ein Editor, der alle Grafiken auf deren Servern hostet. Es werden auch Laufzeitumgebungen für viele Plattformen bereitgestellt, um mit Rive erstellte Darstellungen auszuführen.
* [storyset.com](https://storyset.com/) — Erstellen Sie mit diesem Tool unglaubliche, kostenlose, individuell anpassbare Illustrationen für Ihr Projekt.
* [smartmockups.com](https://smartmockups.com/) — Produktmockups erstellen, 200 kostenlose Mockups.
* [Shadcn Studio](https://shadcnstudio.com/theme-editor) — Vorschau Ihrer Theme-Änderungen über verschiedene Komponenten und Layouts hinweg.
* [Tailark](https://tailark.com/) – Eine Sammlung moderner, responsiver, vorgefertigter UI-Blöcke für Marketing-Websites.
* [tabler-icons.io](https://tabler-icons.io/) — Über 1.500 kostenlose, kopierbare und bearbeitbare SVG-Icons.
* [tweakcn](https://tweakcn.com/) — Schöne Themes für shadcn/ui. Passen Sie Farben, Typografie und mehr in Echtzeit an.
* [UI Avatars](https://ui-avatars.com/) – Erstellen Sie Avatare mit Initialen aus Namen. Die URLs können direkt in Ihrer Web/App verwendet werden. Unterstützt Konfigurationsparameter über die URL.
* [unDraw](https://undraw.co/) – Eine ständig wachsende Sammlung schöner SVG-Bilder, die Sie völlig kostenlos und ohne Namensnennung verwenden können.
* [unsplash.com](https://unsplash.com/) – Kostenlose Stockfotos für kommerzielle und nicht-kommerzielle Zwecke (Do-what-you-want-Lizenz).
* [vectr.com](https://vectr.com/) — Kostenlose Design-App für Web + Desktop.
* [walkme.com](https://www.walkme.com/) — Enterprise-Class Guidance & Engagement Plattform, kostenloser Plan mit drei Walk-Thrus à maximal 5 Schritte/Walk.
* [Webflow](https://webflow.com) – WYSIWYG-Website-Builder mit Animationen und Webhosting. Kostenlos für zwei Projekte.
* [Updrafts.app](https://updrafts.app) – WYSIWYG-Website-Builder für tailwindcss-basierte Designs. Kostenlos für nicht-kommerzielle Nutzung.
* [whimsical.com](https://whimsical.com/) – Kollaborative Flussdiagramme, Wireframes, Notizzettel und Mindmaps. Erstellen Sie bis zu 4 kostenlose Boards.
* [Zeplin](https://zeplin.io/) — Plattform für die Zusammenarbeit von Designern und Entwicklern. Zeigt Designs, Assets und Styleguides. Kostenlos für ein Projekt.
* [Pixelixe](https://pixelixe.com/) — Online einzigartige, ansprechende Grafiken und Bilder erstellen und bearbeiten.
* [Responsively App](https://responsively.app) – Kostenloses Dev-Tool für eine schnellere und präzisere Entwicklung responsiver Webanwendungen.
* [SceneLab](https://scenelab.io) – Online-Mockup-Grafikeditor mit ständig wachsender Sammlung kostenloser Designvorlagen
* [xLayers](https://xlayers.dev) – Vorschau und Konvertierung von Sketch-Design-Dateien in Angular, React, Vue, LitElement, Stencil, Xamarin und mehr (kostenlos und Open Source unter https://github.com/xlayers/xlayers)
* [Grapedrop](https://grapedrop.com/) — Responsiver, leistungsstarker, SEO-optimierter Webpage-Builder auf Basis des GrapesJS-Frameworks. Kostenlos für die ersten fünf Seiten, unbegrenzte eigene Domains, alle Funktionen und einfache Bedienung.
* [Mastershot](https://mastershot.app) – Komplett kostenloser, browserbasierter Videoeditor. Kein Wasserzeichen, Exportoptionen bis 1080p.
* [Unicorn Platform](https://unicornplatform.com/) – Müheloser Landingpage-Builder mit Hosting. Eine Website kostenlos.
* [SVGmix.com](https://www.svgmix.com/) – Riesiges Repository mit 300.000+ kostenlosen SVG-Icons, Sammlungen und Markenlogos. Ein einfaches Vektor-Bearbeitungsprogramm ist direkt im Browser für schnelle Dateiänderungen integriert.
* [svgrepo.com](https://www.svgrepo.com/) – Durchsuchen und finden Sie die am besten passenden Icons oder Vektoren für Ihre Projekte mithilfe verschiedener Vektorbibliotheken. Laden Sie kostenlose SVG-Vektoren für die kommerzielle Nutzung herunter.
* [haikei.app](https://www.haikei.app/) – Haikei ist eine Web-App zur Generierung einzigartiger SVG-Formen, -Hintergründe und -Muster – bereit zur Nutzung mit Ihren Design-Tools und Workflows.
* [Canva](https://canva.com) – Kostenloses Online-Designtool zur Erstellung visueller Inhalte.
* [Superdesigner](https://superdesigner.co) – Eine Sammlung kostenloser Design-Tools, um einzigartige Hintergründe, Muster, Formen, Bilder und mehr mit nur wenigen Klicks zu erstellen.
* [TeleportHQ](https://teleporthq.io/) – Low-Code-Frontend-Design- & Entwicklungsplattform. TeleportHQ ist die kollaborative Frontend-Plattform zum sofortigen Erstellen und Veröffentlichen von Headless-Static-Websites. Drei kostenlose Projekte, unbegrenzte Mitwirkende, kostenloser Codeexport.
* [vector.express](https://vector.express) — Konvertieren Sie Ihre AI-, CDR-, DWG-, DXF-, EPS-, HPGL-, PDF-, PLT-, PS- und SVG-Vektoren schnell und einfach.
* [Vertopal](https://www.vertopal.com) – Vertopal ist eine kostenlose Online-Plattform zur Konvertierung von Dateien in verschiedene Formate. Inklusive Entwickler-Konvertern wie JPG zu SVG, GIF zu APNG, PNG zu WEBP, JSON zu XML usw.
* [okso.app](https://okso.app) – Minimalistische Online-Zeichenapp. Erlaubt schnelle Skizzen und visuelle Notizen. Exportiert Skizzen als PNG, JPG, SVG und WEBP. Auch als PWA installierbar. Kostenlos nutzbar für alle (keine Registrierung erforderlich).
* [Wdrfree SVG](https://wdrfree.com/free-svg) – Schwarz-weiße, kostenlose SVG-Cut-Dateien.
* [Lucide](https://lucide.dev) – Kostenloses, anpassbares und konsistentes SVG-Icon-Toolkit.
* [Logo.dev](https://www.logo.dev) – Firmenlogo-API mit 44M+ Marken, so einfach wie ein URL-Aufruf. Die ersten 10.000 API-Aufrufe sind kostenlos.
* [MDBootstrap](https://mdbootstrap.com/) – Kostenlos für persönliche & kommerzielle Nutzung. Bootstrap-, Angular-, React- und Vue-UI-Kits mit über 700 Komponenten, beeindruckenden Vorlagen, 1-Minuten-Installation, umfangreichen Tutorials & riesiger Community.
* [TW Elements](https://tw-elements.com/) – Kostenlose Bootstrap-Komponenten, neu erstellt mit Tailwind CSS, mit besserem Design und mehr Funktionen.
* [DaisyUI](https://daisyui.com/) – Kostenlos. „Nutze Tailwind CSS, aber schreibe weniger Klassennamen“, bietet Komponenten wie Buttons.
* [Scrollbar.app](https://scrollbar.app) -- Einfache, kostenlose Web-App zur Gestaltung individueller Scrollbars für das Web.
* [css.glass](https://css.glass/) -- Kostenlose Web-App zur Erstellung von glassmorphischen Designs mit CSS.
* [hypercolor.dev](https://hypercolor.dev/) -- Eine kuratierte Sammlung von Tailwind CSS Farbverläufen sowie verschiedene Generatoren zur Erstellung eigener Verläufe.
* [iconify.design](https://icon-sets.iconify.design/) -- Eine Sammlung von über 100 Icon-Paketen mit einheitlicher Oberfläche. Ermöglicht die Suche nach Icons über verschiedene Pakete hinweg und den Export einzelner Icons als SVGs oder für beliebte Web-Frameworks.
* [NextUI](https://nextui.org/) -- Kostenlos. Schönes, schnelles und modernes React & Next.js UI-Framework.
* [Glyphs](https://glyphs.fyi/) -- Kostenlos, Die mächtigsten Icons im Web, vollständig editierbares & wirklich quelloffenes Designsystem.
* [ShadcnUI](https://ui.shadcn.com/) -- Wunderschön gestaltete Komponenten zum Kopieren und Einfügen in eigene Apps. Barrierefrei. Anpassbar. Open Source.
* [HyperUI](https://www.hyperui.dev/) -- Kostenlose Open-Source Tailwind CSS Komponenten.
* [Calendar Icons Generator](https://calendariconsgenerator.app/) -- Erstelle ein ganzes Jahr einzigartiger Icons mit nur einem Klick, absolut KOSTENLOS.
* [Image BG Blurer](https://imagebgblurer.com/) -- Erzeugt einen unscharfen Hintergrundrahmen für ein Bild, indem das Bild selbst als Hintergrund-Unschärfe genutzt wird, für Notion, Trello, Jira und mehr Tools.
* [Webstudio](https://webstudio.is/) -- Open-Source Alternative zu Webflow. Der kostenlose Plan bietet unbegrenzte Websites auf deren Domain. Fünf Websites mit eigenen Domains. Zehntausend Seitenaufrufe/Monat. 2 GB Asset-Speicher.
* [Nappy](https://nappy.co/) -- Schöne Fotos von Schwarzen und People of Color, kostenlos. Für kommerzielle und private Nutzung.
* [Tailkits](https://tailkits.com/) -- Eine kuratierte Sammlung von Tailwind-Vorlagen, Komponenten und Tools sowie nützlichen Generatoren für Code, Grids, Box-Shadows und mehr.
* [Tailcolors](https://tailcolors.com/) -- Eine schöne Tailwind CSS v4 Farbpalette. Sofortige Vorschau & Kopieren der perfekten Tailwind CSS Farbklasse.
* [Excalidraw](https://excalidraw.com/) -- Eine kostenlose Online-Zeichen- und Dokumenten-Webseite mit kostenlosem Speichern lokal und Export-Unterstützung.
* [Lunacy](https://icons8.com/lunacy) -- Kostenloses Grafikdesign-Tool mit Offline-Unterstützung, integrierten Assets (Icons, Fotos, Illustrationen) und Echtzeit-Zusammenarbeit. Die kostenlose Stufe beinhaltet 10 Cloud-Dokumente, 30 Tage Verlauf, niedrigauflösende Assets und grundlegende Design-Tools.

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Design-Inspiration

* [awwwards.](https://www.awwwards.com/) - [Top-Websites] Eine Ausstellung der besten gestalteten Websites (gewählt von Designern).
* [Behance](https://www.behance.net/) - [Design-Showcase] Ein Ort, an dem Designer ihre Arbeit präsentieren. Filterbar mit Kategorien für UI/UX-Projekte.
* [dribbble](https://dribbble.com/) - [Design-Showcase] Einzigartige Design-Inspirationen, im Allgemeinen nicht aus echten Anwendungen.
* [Landings](https://landings.dev/) - [Web-Screenshots] Finde die besten Landingpages für deine Design-Inspiration basierend auf deinen Präferenzen.
* [Lapa Ninja](https://www.lapa.ninja/) - [Landingpage / UI-Kits / Web-Screenshots] Lapa Ninja ist eine Galerie mit den besten 6025 Landingpage-Beispielen, kostenlosen Büchern für Designer und kostenlosen UI-Kits aus dem Web.
* [LovelyLanding.net](https://www.lovelylanding.net/) - [Landingpage-Designs] Häufig aktualisierte Screenshots von Landingpages. Enthält Desktop-, Tablet- und Mobile-Screenshots.
* [Mobbin](https://mobbin.design/) - [Mobile-Screenshots] Spare Stunden an UI- & UX-Recherche mit unserer Bibliothek von über 50.000 vollständig durchsuchbaren Mobile-App-Screenshots.
* [Uiland Design](https://uiland.design/) - [Mobile-Screenshots] Entdecke Mobile- und Web-UI-Designs von führenden Unternehmen in Afrika und weltweit.
* [Mobile Patterns](https://www.mobile-patterns.com/) - [Mobile-Screenshots] Eine Design-Inspirationsbibliothek mit den besten UI-/UX-Patterns (iOS und Android) für Designer, Entwickler und Produktmacher.
* [Page Flows](https://pageflows.com/) - [Mobile/Web-Videos und Screenshots] Videos kompletter Abläufe in vielen Mobile- und Web-Apps. Enthält auch Screenshots. Hochgradig durchsuchbar und indexiert.
* [Screenlane](https://screenlane.com/) - [Mobile-Screenshots] Lass dich inspirieren und bleibe auf dem neuesten Stand bei Web- & Mobile-App-UI-Design-Trends. Filterbar nach Pattern und App.
* [scrnshts](https://scrnshts.club/) - [Mobile-Screenshots] Eine handverlesene Sammlung der besten App-Store-Design-Screenshots.
* [Refero](https://refero.design/) - [Web-Screenshots] Getaggte und durchsuchbare Sammlung von Design-Referenzen großartiger Webanwendungen.

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Datenvisualisierung auf Karten

* [IP Geolocation](https://ipgeolocation.io/) — Kostenloser DEVELOPER-Plan mit 30.000 Anfragen/Monat.
* [carto.com](https://carto.com/) — Erstelle Karten und Geodaten-APIs aus eigenen und öffentlichen Daten.
* [Clockwork Micro](https://clockworkmicro.com/) — Kartentools, die wie ein Uhrwerk funktionieren. Fünfzigtausend kostenlose monatliche Abfragen (Kartenkacheln, db2vector, Höhenangaben).
* [developers.arcgis.com](https://developers.arcgis.com) — APIs und SDKs für Karten, Geodaten-Speicherung, Analyse, Geokodierung, Routing und mehr für Web, Desktop und Mobil. Zwei Millionen kostenlose Basiskartenkacheln, 20.000 nicht gespeicherte Geokodierungen, 20.000 einfache Routen, 5.000 Fahrzeitberechnungen und 5GB kostenloser Kachel- und Datenspeicher pro Monat.
* [Foursquare](https://developer.foursquare.com/) - Standortentdeckung, Venue-Suche und kontextbezogene Inhalte über Places API und Pilgrim SDK.
* [geoapify.com](https://www.geoapify.com/) - Vektor- und Rasterkartenkacheln, Geokodierung, Orte, Routing, Isolinen-APIs. Dreitausend kostenlose Anfragen/Tag.
* [geocod.io](https://www.geocod.io/) — Geokodierung per API oder CSV-Upload. Zweitausendfünfhundert kostenlose Abfragen/Tag.
* [geocodify.com](https://geocodify.com/) — Geokodierung und Geoparsing per API oder CSV-Upload. 10.000 kostenlose Abfragen/Monat.
* [geojs.io](https://www.geojs.io/) - Hochverfügbare REST/JSON/JSONP-IP-Geolokalisierungs-API.
* [giscloud.com](https://www.giscloud.com/) — Visualisiere, analysiere und teile Geodaten online.
* [graphhopper.com](https://www.graphhopper.com/) Ein kostenloses Entwicklerpaket für Routing, Routenoptimierung, Distanzmatrix, Geokodierung und Map Matching wird angeboten.
* [here](https://developer.here.com/) — APIs und SDKs für Karten- und standortbezogene Apps. 250.000 Transaktionen/Monat kostenlos.
* [locationiq.com](https://locationiq.com/) — Geokodierungs-, Karten- und Routing-APIs. Fünftausend Anfragen/Tag kostenlos.
* [mapbox.com](https://www.mapbox.com/) — Karten, Geodienste und SDKs zur Anzeige von Kartendaten.
* [maptiler.com](https://www.maptiler.com/cloud/) — Vektorkarten, Kartendienste und SDKs für Kartenvisualisierung. Kostenlose Vektorkacheln mit wöchentlichen Updates und vier Kartenstilen.
* [nominatim.org](https://nominatim.org/) — OpenStreetMaps kostenloser Geokodierungsdienst, bietet globale Adresssuche und Reverse-Geokodierung.
* [nextbillion.ai](https://nextbillion.ai/) - Kartendienste: Geokodierung, Navigation (Richtung, Routing, Routenoptimierung, Distanzmatrix), Maps SDK (Vektor, Statisch, Mobile SDK). [Kostenlos mit festgelegtem Kontingent](https://nextbillion.ai/pricing) pro Dienst.
* [opencagedata.com](https://opencagedata.com) — Geokodierungs-API, die OpenStreetMap und andere offene Geoquellen aggregiert. Zweitausendfünfhundert kostenlose Abfragen/Tag.
* [osmnames](https://osmnames.org/) — Geokodierung, Suchergebnisse nach der Popularität der zugehörigen Wikipedia-Seite sortiert.
* [positionstack](https://positionstack.com/) - Kostenlose Geokodierung für globale Orte und Koordinaten. 25.000 Anfragen pro Monat für den persönlichen Gebrauch.
* [stadiamaps.com](https://stadiamaps.com/) — Kartenkacheln, Routing, Navigation und andere Geodaten-APIs. Zweitausendfünfhundert kostenlose Kartenaufrufe und API-Anfragen/Tag für nicht-kommerzielle Nutzung und Tests.
* [maps.stamen.com](http://maps.stamen.com/) - Kostenlose Kartenkacheln und Kachel-Hosting.
* [ipstack](https://ipstack.com/) - Lokalisieren und Identifizieren von Webseitenbesuchern über die IP-Adresse.
* [Geokeo api](https://geokeo.com) - Geokodierungs-API mit Sprachkorrektur und mehr. Weltweite Abdeckung. 2.500 kostenlose tägliche Abfragen.

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Paket-Build-System

* [build.opensuse.org](https://build.opensuse.org/) — Paket-Build-Service für mehrere Distributionen (SUSE, EL, Fedora, Debian, usw.).
* [copr.fedorainfracloud.org](https://copr.fedorainfracloud.org) — Mock-basierter RPM-Build-Service für Fedora und EL.
* [help.launchpad.net](https://help.launchpad.net/Packaging) — Ubuntu- und Debian-Build-Service.

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## IDE und Code-Editoren

* [3v4l](https://3v4l.org/) - Kostenloses Online-PHP-Shell und Snippet-Sharing-Seite, die deinen Code in über 300 PHP-Versionen ausführt.
* [Android Studio](https://developer.android.com/studio) — Android Studio bietet die schnellsten Tools zum Erstellen von Apps für alle Android-Geräte. Open Source IDE ist für alle kostenlos und das beste Werkzeug für Android-Entwicklung. Verfügbar für Windows, Mac, Linux und sogar ChromeOS!
* [AndroidIDE](https://m.androidide.com/) — Eine Open-Source-IDE zum Entwickeln von echten, Gradle-basierten Android-Anwendungen direkt auf Android-Geräten.
* [Apache Netbeans](https://netbeans.apache.org/) — Entwicklungsumgebung, Tooling-Plattform und Anwendungs-Framework.
* [apiary.io](https://apiary.io/) — Kollaboratives API-Design mit sofortigem API-Mock und generierter Dokumentation (Kostenlos für unbegrenzte API-Blueprints und unbegrenzte Nutzer mit einem Admin-Account und gehosteter Dokumentation).
* [BBEdit](https://www.barebones.com/) - BBEdit ist ein beliebter und erweiterbarer Editor für macOS. Der Free Mode bietet ein [leistungsfähiges Kern-Feature-Set](https://www.barebones.com/products/bbedit/comparison.html) und einen Upgrade-Pfad zu erweiterten Funktionen.
* [Binder](https://mybinder.org/) - Verwandle ein Git-Repository in eine Sammlung interaktiver Notebooks. Es handelt sich um einen kostenlosen öffentlichen Service.
* [BlueJ](https://bluej.org) — Eine kostenlose Java-Entwicklungsumgebung für Einsteiger, weltweit von Millionen genutzt. Unterstützt von Oracle & einfache GUI zur Unterstützung von Anfängern.
* [Bootify.io](https://bootify.io/) - Spring Boot App-Generator mit individueller Datenbank und REST-API.
* [Brackets](http://brackets.io/) - Brackets ist ein Open-Source-Texteditor, speziell für Webentwicklung entwickelt. Er ist leichtgewichtig, einfach zu bedienen und hochgradig anpassbar.
* [cacher.io](https://www.cacher.io) — Code-Snippet-Organizer mit Labels und Unterstützung für über 100 Programmiersprachen.
* [Code::Blocks](https://codeblocks.org) — Kostenlose Fortran & C/C++ IDE. Open Source und läuft auf Windows, macOS & Linux.
* [Cody](https://sourcegraph.com/cody) - Kostenloser KI-Coding-Assistent, der (Codeblöcke, Autovervollständigung, Unit-Tests) schreiben, (Kenntnis des gesamten Codebestands) verstehen, Code reparieren und finden kann. Verfügbar für VS Code, JetBrains und Online.
* [codiga.io](https://codiga.io/) — Coding-Assistent, der das Suchen, Definieren und Wiederverwenden von Code-Snippets direkt im eigenen IDE ermöglicht. Kostenlos für Einzelpersonen und kleine Organisationen.
* [codesnip.com.br](https://codesnip.com.br) — Einfacher Code-Snippet-Manager mit Kategorien, Suche und Tags. Kostenlos und unbegrenzt.
* [cocalc.com](https://cocalc.com/) — (früher SageMathCloud unter cloud.sagemath.com) — Kollaborative Berechnungen in der Cloud. Browser-Zugang zu vollem Ubuntu mit integrierter Zusammenarbeit und viel kostenloser Software für Mathematik, Wissenschaft, Data Science, vorinstalliert: Python, LaTeX, Jupyter Notebooks, SageMath, scikitlearn, usw.
* [code.cs50.io](https://code.cs50.io/) - Visual Studio Code für CS50 ist eine Web-App auf code.cs50.io, die GitHub Codespaces für Studierende und Lehrende adaptiert.
* [codepen.io](https://codepen.io/) — CodePen ist ein Spielplatz für die Frontend-Seite des Webs.
* [codesandbox.io](https://codesandbox.io/) — Online-Spielplatz für React, Vue, Angular, Preact und mehr.
* [Components.studio](https://webcomponents.dev/) - Code-Komponenten isoliert entwickeln, in Stories visualisieren, testen und auf npm veröffentlichen.
* [Eclipse Che](https://www.eclipse.org/che/) - Webbasierte und Kubernetes-native IDE für Entwicklerteams mit Mehrsprachenunterstützung. Open Source und Community-getrieben. Eine Online-Instanz, gehostet von Red Hat, ist verfügbar unter [workspaces.openshift.com](https://workspaces.openshift.com/).
* [fakejson.com](https://fakejson.com/) — FakeJSON hilft, schnell Fake-Daten per API zu generieren. Sende eine API-Anfrage, wie und was du möchtest, die API liefert alles im JSON-Format. Beschleunige die Markteinführung von Ideen und "Fake it till you make it".
* [GetVM](https://getvm.io) — Sofortige kostenlose Linux- und IDEs-Chrome-Sidebar. Die kostenlose Stufe beinhaltet 5 VMs pro Tag.
  * [GitPod](https://www.gitpod.io) — Sofort einsatzbereite Entwicklungsumgebungen für GitHub-Projekte. Die kostenlose Stufe beinhaltet 50 Stunden/Monat.
  * [ide.goorm.io](https://ide.goorm.io) goormIDE ist eine vollständige IDE in der Cloud. Mehrsprachige Unterstützung, Linux-basierter Container über das voll ausgestattete webbasierte Terminal, Port-Forwarding, benutzerdefinierte URL, Echtzeit-Zusammenarbeit und Chat, Freigabelink, Git/Subversion-Unterstützung. Es gibt viele weitere Funktionen (Die kostenlose Stufe umfasst 1GB RAM und 10GB Speicher pro Container, 5 Container-Slots).
  * [JDoodle](https://www.jdoodle.com) — Online-Compiler und Editor für mehr als 60 Programmiersprachen mit einem kostenlosen Plan für REST-API-Code-Kompilierung mit bis zu 200 Credits pro Tag.
  * [jetbrains.com](https://jetbrains.com/products.html) — Produktivitätstools, IDEs und Deployment-Tools (z.B. [IntelliJ IDEA](https://www.jetbrains.com/idea/), [PyCharm](https://www.jetbrains.com/pycharm/), usw.). Kostenlose Lizenz für Studenten, Lehrer, Open Source und User Groups.
  * [jsbin.com](https://jsbin.com) — JS Bin ist ein weiteres Playground- und Code-Sharing-Portal für Frontend-Web (HTML, CSS und JavaScript. Unterstützt auch Markdown, Jade und Sass).
  * [jsfiddle.net](https://jsfiddle.net/) — JS Fiddle ist ein Playground und Code-Sharing-Portal für Frontend-Web, unterstützt Zusammenarbeit.
  * [JSONPlaceholder](https://jsonplaceholder.typicode.com/) Einige REST-API-Endpunkte, die gefälschte Daten im JSON-Format zurückgeben. Der Quellcode ist ebenfalls verfügbar, falls Sie den Server lokal ausführen möchten.
  * [Lazarus](https://www.lazarus-ide.org/) — Lazarus ist eine Delphi-kompatible plattformübergreifende IDE für Rapid Application Development.
  * [MarsCode](https://www.marscode.com/) - Eine kostenlose, KI-basierte cloudbasierte IDE.
  * [micro-jaymock](https://micro-jaymock.now.sh/) - Winziger API-Mocking-Mikroservice zur Generierung von gefälschten JSON-Daten.
  * [mockable.io](https://www.mockable.io/) — Mockable ist ein einfach konfigurierbarer Service zum Mocken von RESTful API- oder SOAP-Webservices. Dieser Online-Service ermöglicht es Ihnen, REST-API- oder SOAP-Endpunkte schnell zu definieren und sie JSON- oder XML-Daten zurückgeben zu lassen.
  * [mockaroo](https://mockaroo.com/) — Mit Mockaroo können Sie realistische Testdaten in CSV-, JSON-, SQL- und Excel-Formaten generieren. Sie können auch Mocks für Backend-APIs erstellen.
  * [Mocklets](https://mocklets.com) - Ein HTTP-basierter Mock-API-Simulator, der hilft, APIs für schnellere parallele Entwicklung und umfassendere Tests zu simulieren, mit lebenslanger kostenloser Stufe.
  * [Paiza](https://paiza.cloud/en/) — Entwicklung von Web-Apps im Browser, ohne etwas einrichten zu müssen. Der kostenlose Plan bietet einen Server mit 24 Stunden Lebensdauer und 4 Stunden Laufzeit pro Tag mit 2 CPU-Kernen, 2 GB RAM und 1 GB Speicher.
  * [Prepros](https://prepros.io/) - Prepros kann Sass, Less, Stylus, Pug/Jade, Haml, Slim, CoffeeScript und TypeScript direkt kompilieren, lädt Browser automatisch neu und erleichtert die Entwicklung und das Testen Ihrer Websites, damit Sie sich auf deren Perfektionierung konzentrieren können. Sie können auch eigene Tools mit nur wenigen Klicks hinzufügen.
  * [Replit](https://replit.com/) — Eine Cloud-Coding-Umgebung für verschiedene Programmiersprachen.
  * [SoloLearn](https://code.sololearn.com) — Eine Cloud-Programmierumgebung, die sich gut zum Ausführen von Code-Snippets eignet. Unterstützt verschiedene Programmiersprachen. Keine Registrierung erforderlich zum Ausführen von Code, aber notwendig, wenn Code auf ihrer Plattform gespeichert werden soll. Bietet auch kostenlose Kurse für Anfänger und fortgeschrittene Programmierer.
  * [stackblitz.com](https://stackblitz.com/) — Online/Cloud-Code-IDE zum Erstellen, Bearbeiten und Deployen von Full-Stack-Apps. Unterstützt alle gängigen NodeJs-basierten Frontend- und Backend-Frameworks. Shortlink zum Erstellen eines neuen Projekts: [https://node.new](https://node.new).
  * [Sublime Text](https://www.sublimetext.com/) - Sublime Text ist ein beliebter, vielseitiger und hochgradig anpassbarer Texteditor für Coding- und Textbearbeitungsaufgaben.
  * [Visual Studio Code](https://code.visualstudio.com/) - Neudefinierter und optimierter Code-Editor zum Erstellen und Debuggen moderner Web- und Cloud-Anwendungen. Entwickelt von Microsoft.
  * [Visual Studio Community](https://visualstudio.microsoft.com/vs/community/) — Voll ausgestattete IDE mit Tausenden von Erweiterungen, plattformübergreifende App-Entwicklung (Microsoft-Erweiterungen zum Download für iOS und Android verfügbar), Desktop-, Web- und Cloud-Entwicklung, Mehrsprachunterstützung (C#, C++, JavaScript, Python, PHP und mehr).
  * [VSCodium](https://vscodium.com/) - Community-getriebene, ohne Telemetrie/Tracking und frei lizenzierte Binärdistribution von Microsofts Editor VSCode.
  * [wakatime.com](https://wakatime.com/) — Quantifizierte Selbst-Metriken zu Ihrer Programmieraktivität über Texteditor-Plugins, begrenzter kostenloser Plan.
  * [Wave Terminal](https://waveterm.dev/) - Wave ist ein Open-Source, plattformübergreifendes Terminal für nahtlose Workflows. Alles inline rendern. Sitzungen und Verlauf speichern. Angetrieben von offenen Webstandards. MacOS und Linux.
  * [WebComponents.dev](https://webcomponents.dev/) — In-Browser-IDE zum Programmieren von Web Components isoliert mit 58 verfügbaren Vorlagen, unterstützt Stories und Tests.
  * [PHPSandbox](https://phpsandbox.io/) — Online-Entwicklungsumgebung für PHP
  * [WebDB](https://webdb.app) - Kostenlose effiziente Datenbank-IDE. Mit Server Discovery, ERD, Data Generator, KI, NoSQL-Strukturmanager, Datenbankversionierung und vielem mehr.
  * [Zed](https://zed.dev/) - Zed ist ein leistungsstarker, Multiplayer-Code-Editor von den Machern von Atom und Tree-sitter.
  * [OneCompiler](https://onecompiler.com/) - Kostenloser Online-Compiler mit Unterstützung für über 70 Sprachen, darunter Java, Python, C++, JavaScript.


**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Analytics, Events und Statistiken

  * [Dwh.dev](https://dwh.dev) - Data Cloud Observability-Lösung (Snowflake). Kostenlos für den persönlichen Gebrauch.
  * [Hightouch](https://hightouch.com/) - Hightouch ist eine Reverse-ETL-Plattform, mit der Sie Kundendaten aus Ihrem Data Warehouse mit Ihrem CRM, Marketing- und Support-Tools synchronisieren können. Die kostenlose Stufe bietet ein Ziel zum Datensynchronisieren.
  * [Avo](https://avo.app/) — Vereinfachter Analytics-Release-Workflow. Single-Source-of-Truth-Tracking-Plan, typsichere Analytics-Tracking-Bibliothek, In-App-Debugger und Datenüberwachung zur Erkennung aller Datenprobleme vor der Veröffentlichung. Kostenlos für zwei Workspace-Mitglieder und 1 Stunde Datenüberwachungs-Überblick.
  * [Branch](https://www.branch.io) — Mobile Analytics Plattform. Kostenlose Stufe bietet bis zu 10.000 Mobile App Nutzer inklusive Deep-Linking & weitere Services.
  * [Census](https://www.getcensus.com/) — Reverse ETL & Operational Analytics Plattform. Synchronisieren Sie 10 Felder aus Ihrem Data Warehouse zu 60+ SaaS wie Salesforce, Zendesk oder Amplitude.
  * [Clicky](https://clicky.com) — Website-Analytics-Plattform. Kostenloser Plan für eine Website mit Analytics für 3000 Seitenaufrufe.
  * [Databox](https://databox.com) — Business Insights & Analytics durch Kombination anderer Analytics- & BI-Plattformen. Kostenloser Plan für 3 Benutzer, Dashboards & Datenquellen. 11 Mio. historische Datensätze.
  * [Hitsteps.com](https://hitsteps.com/) — 2.000 Seitenaufrufe pro Monat für 1 Website
  * [amplitude.com](https://amplitude.com/) — 1 Million monatliche Events, bis zu 2 Apps
  * [GoatCounter](https://www.goatcounter.com/) — GoatCounter ist eine Open-Source-Web-Analytics-Plattform, erhältlich als gehosteter Service (kostenlos für nicht-kommerzielle Nutzung) oder als selbst gehostete App. Ziel ist es, einfach zu bedienende und sinnvolle, datenschutzfreundliche Web-Analytics als Alternative zu Google Analytics oder Matomo anzubieten. Die kostenlose Stufe ist für nicht-kommerzielle Nutzung und beinhaltet unbegrenzte Seiten, sechs Monate Datenspeicherung und 100.000 Seitenaufrufe/Monat.
  * [Google Analytics](https://analytics.google.com/) — Google Analytics
  * [MetricsWave](https://metricswave.com) — Datenschutzfreundliche Google-Analytics-Alternative für Entwickler. Kostenloser Plan erlaubt 20.000 Seitenaufrufe pro Monat ohne Kreditkarte.
  * [Expensify](https://www.expensify.com/) — Ausgabenberichte, kostenloser persönlicher Berichtsfreigabeworkflow
  * [getinsights.io](https://getinsights.io) - Datenschutzorientierte, Cookie-freie Analytics, kostenlos für bis zu 3.000 Events/Monat.
  * [heap.io](https://heap.io) — Erfasst automatisch jede Benutzeraktion in iOS- oder Web-Apps. Kostenlos für bis zu 10.000 monatliche Sitzungen.
  * [Hotjar](https://hotjar.com) — Website-Analytics und Berichte. Kostenloser Plan erlaubt 2.000 Seitenaufrufe/Tag. Hundert Snapshots/Tag (max. Kapazität: 300). Drei Snapshot-Heatmaps können 365 Tage lang gespeichert werden. Unbegrenzte Teammitglieder. Ebenfalls in der App und eigenständige Umfragen, Feedback-Widgets mit Screenshots. Kostenlose Stufe erlaubt das Erstellen von 3 Umfragen & 3 Feedback-Widgets und das Sammeln von 20 Antworten pro Monat.
  * [Keen](https://keen.io/) — Benutzerdefinierte Analytics für Datenerfassung, Analyse und Visualisierung. 1.000 Events/Monat kostenlos
  * [Yandex.Datalens](https://datalens.yandex.com/) — Yandex-Cloud-Datenvisualisierungs- und Analyse-Service. Der Dienst ist kostenlos. Keine Begrenzung der Nutzerzahl und Anfragen.
  * [Yandex.Metrica](https://metrica.yandex.com/) — Unbegrenzte kostenlose Analytics
  * [Mixpanel](https://mixpanel.com/) — 100.000 monatlich getrackte Nutzer, unbegrenzte Datenhistorie und Plätze, US- oder EU-Datenresidenz
  * [Moesif](https://www.moesif.com) — API-Analytics für REST und GraphQL. (Kostenlos bis zu 500.000 API-Aufrufe/Monat)
  * [optimizely.com](https://www.optimizely.com) — A/B-Testing-Lösung, kostenloser Starter-Plan, eine Website, 1 iOS- und 1 Android-App
  * [Microsoft PowerBI](https://powerbi.com) — Business Insights & Analytics von Microsoft. Kostenloser Plan bietet eingeschränkte Nutzung mit 1 Million Benutzerlizenzen.
  * [Row Zero](https://rowzero.io) - Blitzschnelle, verbundene Tabellenkalkulation. Direkte Verbindung zu Datenbanken, S3 und APIs. Millionen von Zeilen sofort importieren, analysieren, grafisch darstellen und teilen. Drei kostenlose (für immer) Arbeitsmappen.
  * [sematext.com](https://sematext.com/cloud/) — Kostenlos für bis zu 50.000 Aktionen/Monat, 1 Tag Datenaufbewahrung, unbegrenzte Dashboards, Benutzer usw.
  * [Similar Web](https://similarweb.com) — Analytics für Web- & Mobile-Apps. Kostenloser Plan bietet fünf Ergebnisse pro Metrik, einen Monat Mobile-App-Daten & 3 Monate Website-Daten.
  * [StatCounter](https://statcounter.com/) — Website-Viewer-Analytics. Kostenloser Plan für Analytics der 500 letzten Besucher.
  * [Statsig](https://statsig.com) - All-in-one-Plattform für Analytics, Feature-Flagging und A/B-Testing. Kostenlos für bis zu 1 Mio. gemessene Events pro Monat.
  * [Tableau Developer Program](https://www.tableau.com/developer) — Innovieren, erstellen und machen Sie Tableau perfekt für Ihre Organisation. Das kostenlose Entwicklerprogramm gibt eine persönliche Entwicklungs-Sandbox-Lizenz für Tableau Online. Die Version ist die neueste Pre-Release-Version, sodass Data Devs jede Funktion dieser großartigen Plattform testen können.
  * [usabilityhub.com](https://usabilityhub.com/) — Designs und Mockups an echten Personen testen und Besucher tracken. Kostenlos für einen Nutzer, unbegrenzte Tests
  * [woopra.com](https://www.woopra.com/) — Kostenlose User-Analytics-Plattform für 500.000 Aktionen, 90 Tage Datenaufbewahrung, 30+ One-Click-Integrationen.
  * [counter.dev](https://counter.dev) — Web-Analytics einfach und damit datenschutzfreundlich. Kostenlos oder spendenbasiert.
  * [PostHog](https://posthog.com) - Vollständige Produkt-Analytics-Suite kostenlos für bis zu 1 Mio. getrackte Events pro Monat. Bietet auch unbegrenzte In-App-Umfragen mit 250 Antworten/Monat.
  * [Uptrace](https://uptrace.dev) - Distributed-Tracing-Tool, das Entwicklern hilft, Fehler zu erkennen und Performance-Engpässe zu finden. Hat einen kostenlosen Plan, bietet ein kostenloses persönliches Abo für Open-Source-Projekte und eine Open-Source-Version.
  * [Microsoft Clarity](https://clarity.microsoft.com/) - Clarity ist ein kostenloses, einfach zu bedienendes Tool, das erfasst, wie echte Menschen Ihre Website nutzen.
  * [Beampipe.io](https://beampipe.io) - Beampipe ist einfache, datenschutzfreundliche Web-Analytics. Kostenlos für bis zu 5 Domains & 10.000 monatliche Seitenaufrufe.
  * [Aptabase](https://aptabase.com) — Open Source, datenschutzfreundliche und einfache Analytics für Mobile- und Desktop-Apps. SDKs für Swift, Kotlin, React Native, Flutter, Electron und viele mehr. Kostenlos für bis zu 20.000 Events pro Monat.
  * [Trackingplan](https://www.trackingplan.com/) - Erkennt automatisch Probleme bei digitalen Analytics, Marketingdaten und Pixeln, hält Tracking-Pläne aktuell und fördert nahtlose Zusammenarbeit. Deployment in der Produktionsumgebung mit echtem Traffic oder Analytics-Abdeckung für Regressionstests ohne Code schreiben.
  * [LogSpot](https://logspot.io) - Vollständige, einheitliche Web- und Produkt-Analytics-Plattform, einschließlich einbettbarer Analytics-Widgets und automatisierter Roboter (Slack, Telegram und Webhooks). Kostenloser Plan beinhaltet 10.000 Events pro Monat.
  * [Umami](https://umami.is/) - Einfache, schnelle, datenschutzfreundliche, Open-Source-Alternative zu Google Analytics.
  * [TrackWith Dicloud](https://dicloud.net/trackwith-privacy-focused-analytics/) - Kostenloses, leichtgewichtiges, datenschutzorientiertes Google-Analytics-Alternative. Unbegrenzte Seitenaufrufe, unbegrenzte Besucher, unbegrenzte Seiten-Heatmaps & Ziel-Tracking. Kostenlos für bis zu 3 Domains und 600 Sitzungswiedergaben pro Domain.
  * [AppFit](https://appfit.io) - AppFit ist ein umfassendes Analytics- und Produktmanagement-Tool zur nahtlosen, plattformübergreifenden Verwaltung von Analytics und Produkt-Updates. Kostenloser Plan beinhaltet 10.000 Events pro Monat, Produktjournal und wöchentliche Insights.
  * [Seline](https://seline.so) - Seline ist eine einfache & private Website- und Produkt-Analytics. Cookie-frei, leichtgewichtig, unabhängig. Kostenloser Plan umfasst 3.000 Events pro Monat und Zugang zu allen Funktionen wie Dashboard, User Journeys, Funnels und mehr.
  * [Peasy](https://peasy.so) - Peasy ist ein leichtgewichtiges, datenschutzfreundliches Analytics-Tool für Websites und Produkte. Kostenloser Plan umfasst 3.000 Events pro Monat.
  * [Rybbit](https://rybbit.io) - Open-Source und Cookie-freie Alternative zu Google Analytics, die 10x intuitiver ist. Kostenloser Plan hat 3.000 monatliche Events. 

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Besucher-Sitzungsaufzeichnung

  * [Reactflow.com](https://www.reactflow.com/) — Pro Seite: 1.000 Seitenaufrufe/Tag, drei Heatmaps, drei Widgets, kostenloses Bugtracking
  * [OpenReplay.com](https://www.openreplay.com) - Open-Source-Session-Replay mit Dev-Tools zur Fehlerreproduktion, Live-Sitzung für Echtzeit-Support und Produkt-Analytics-Suite. Tausend Sessions/Monat mit Zugriff auf alle Funktionen und 7 Tagen Aufbewahrung.
  * [LogRocket.com](https://www.logrocket.com) - 1.000 Sessions/Monat mit 30 Tagen Aufbewahrung, Fehlerverfolgung, Live-Modus
  * [FullStory.com](https://www.fullstory.com) — 1.000 Sessions/Monat mit einem Monat Datenaufbewahrung und drei Benutzerplätzen. Mehr Informationen [hier](https://help.fullstory.com/hc/en-us/articles/360020623354-FullStory-Free-Edition).
  * [hotjar.com](https://www.hotjar.com/) — Pro Seite: 1.050 Seitenaufrufe/Monat, unbegrenzte Heatmaps, Daten werden drei Monate gespeichert
  * [inspectlet.com](https://www.inspectlet.com/) — 2.500 Sessions/Monat kostenlos für eine Website
  * [Microsoft Clarity](https://clarity.microsoft.com/) - Sitzungsaufzeichnung komplett kostenlos mit "keinen Traffic-Limits", keinen Projektlimits und keinem Sampling
  * [mouseflow.com](https://mouseflow.com/) — 500 Sessions/Monat kostenlos für eine Website
  * [mousestats.com](https://www.mousestats.com/) — 100 Sessions/Monat kostenlos für eine Website
  * [smartlook.com](https://www.smartlook.com/) — Kostenlose Pakete für Web- und Mobile-Apps (1.500 Sessions/Monat), drei Heatmaps, ein Funnel, 1 Monat Datenhistorie
  * [howuku.com](https://howuku.com) — Nutzerinteraktion, Engagement und Events verfolgen. Kostenlos für bis zu 5.000 Besuche/Monat
  * [UXtweak.com](https://www.uxtweak.com/) — Aufzeichnen und beobachten, wie Besucher Ihre Website oder App nutzen. Kostenlos unbegrenzt für kleine Projekte

**[⬆️ Zurück zum Anfang](#table-of-contents)**
## Internationale Mobile-Nummernüberprüfung API und SDK

  * [numverify](https://numverify.com/) — Globale Telefonnummernvalidierung und Lookup JSON API. 100 API-Anfragen/Monat
  * [veriphone](https://veriphone.io/) — Globale Telefonnummernüberprüfung in einer kostenlosen, schnellen, zuverlässigen JSON-API. 1000 Anfragen/Monat

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Zahlungs- und Abrechnungsintegration

  * [Qonversion](http://qonversion.io/) – All-in-One plattformübergreifende Abonnementverwaltungsplattform mit Analysen, A/B-Tests, Apple Search Ads, Remote-Konfigurationen und Wachstumstools zur Optimierung von In-App-Käufen und Monetarisierung. Kompatibel mit iOS, Android, React Native, Flutter, Unity, Cordova, Stripe und Web. Kostenlos bis zu $10k monatlich verfolgt Umsatz.
  * [ParityVend](https://www.ambeteco.com/ParityVend/) – Passt die Preisgestaltung automatisch anhand des Besucherstandorts an, um Ihr Geschäft global zu erweitern und neue Märkte zu erreichen (Kaufkraftparität). Der kostenlose Plan beinhaltet 7.500 API-Anfragen/Monat.
  * [Glassfy](https://glassfy.io/) – In-App-Abonnement-Infrastruktur, Echtzeit-Abonnementereignisse und sofort einsatzbereite Monetarisierungstools für iOS, Android, Stripe und Paddle. Kostenlos bis zu $10k monatlicher Umsatz.
  * [Adapty.io](https://adapty.io/) – Komplettlösung mit Open-Source-SDK für die Integration von mobilen In-App-Abonnements in iOS-, Android-, React Native-, Flutter-, Unity- oder Web-Apps. Kostenlos bis zu $10k monatlicher Umsatz.
  * [CoinMarketCap](https://coinmarketcap.com/api/) — Bietet Marktdaten zu Kryptowährungen inklusive aktueller Krypto- und Fiat-Währungskurse. Die kostenlose Stufe bietet 10K Aufrufguthaben/Monat.
  * [CurrencyFreaks](https://currencyfreaks.com/) — Bietet aktuelle und historische Währungskurse. Kostenloser DEVELOPER-Plan mit 1000 Anfragen/Monat verfügbar.
  * [CoinGecko](https://www.coingecko.com/en/api) — Bietet Marktdaten zu Kryptowährungen einschließlich aktueller Wechselkurse und historischer Daten. Die Demo-API hat ein stabiles Limit von 30 Aufrufen/Min und eine monatliche Obergrenze von 10.000 Aufrufen.
  * [CurrencyApi](https://currencyapi.net/) — Live-Währungskurse für physische und Kryptowährungen, geliefert in JSON und XML. Die kostenlose Stufe bietet 1.250 API-Anfragen/Monat.
  * [currencylayer](https://currencylayer.com/) — Zuverlässige Wechselkurse und Währungsumrechnung für Ihr Unternehmen, 100 API-Anfragen/Monat kostenlos.
  * [exchangerate-api.com](https://www.exchangerate-api.com) – Eine einfach zu verwendende Währungsumrechnungs-JSON-API. Die kostenlose Stufe aktualisiert einmal pro Tag mit einem Limit von 1.500 Anfragen/Monat.
  * [FraudLabsPRO](https://www.fraudlabspro.com) — Hilft Händlern, Zahlungsbetrug und Rückbuchungen zu verhindern. Kostenloser Micro-Plan mit 500 Abfragen/Monat verfügbar.
  * [FxRatesAPI](https://fxratesapi.com) — Bietet Echtzeit- und historische Wechselkurse. Die kostenlose Stufe erfordert eine Quellenangabe.
  * [Moesif API Monetization](https://www.moesif.com/) – Generieren Sie Einnahmen aus APIs durch nutzungsbasierte Abrechnung. Verbindung zu Stripe, Chargebee usw. Die kostenlose Stufe bietet 30.000 Events/Monat.
  * [Nami ML](https://www.namiml.com/) – Komplettplattform für In-App-Käufe und Abonnements auf iOS und Android, inklusive No-Code-Paywalls, CRM und Analysen. Kostenlos für alle Basisfunktionen für den Betrieb eines IAP-Geschäfts.
  * [RevenueCat](https://www.revenuecat.com/) — Gehostetes Backend für In-App-Käufe und Abonnements (iOS und Android). Kostenlos bis zu $2,5k/Monat an verfolgt Umsatz.
  * [vatlayer](https://vatlayer.com/) — Sofortige USt-IdNr.-Validierung und EU-Mehrwertsteuersätze-API, kostenlos 100 API-Anfragen/Monat
  * [Currencyapi](https://currencyapi.com) — Kostenlose API für Währungsumrechnung und Wechselkursdaten. 300 Anfragen pro Monat, 10 Anfragen pro Minute für private Nutzung kostenlos.

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Docker-bezogene Dienste

  * [canister.io](https://canister.io/) — 20 kostenlose private Repositories für Entwickler, 30 kostenlose private Repositories für Teams zum Erstellen und Speichern von Docker-Images
  * [Container Registry Service](https://container-registry.com/) – Auf Harbor basierende Container-Management-Lösung. Die kostenlose Stufe bietet 1 GB Speicherplatz für private Repositories.
  * [Docker Hub](https://hub.docker.com) — Ein kostenloses privates Repository und unbegrenzte öffentliche Repositories zum Erstellen und Speichern von Docker-Images
  * [Play with Docker](https://labs.play-with-docker.com/) — Ein einfacher, interaktiver, unterhaltsamer Spielplatz, um Docker zu erlernen.
  * [quay.io](https://quay.io/) — Erstellen und Speichern von Container-Images mit unbegrenzten kostenlosen öffentlichen Repositories
  * [ttl.sh](https://ttl.sh/) – Anonymes & flüchtiges Docker-Image-Registry

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Vagrant-bezogene Dienste

  * [Vagrant Cloud](https://app.vagrantup.com) – HashiCorp Vagrant Cloud. Vagrant Box Hosting.
  * [Vagrantbox.es](https://www.vagrantbox.es/) — Ein alternatives öffentliches Box-Index

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Dev Blogging Sites

  * [BearBlog](https://bearblog.dev/) – Minimalistischer, Markdown-basierter Blog- und Website-Builder.
  * [Dev.to](https://dev.to/) – Wo Programmierer Ideen austauschen und sich gegenseitig beim Wachsen unterstützen.
  * [Hashnode](https://hashnode.com/) — Sorgenfreies Bloggen für Entwickler!
  * [Medium](https://medium.com/) — Werde nachdenklicher über das, was dir wichtig ist.
  * [AyeDot](https://ayedot.com/) — Teile deine Ideen, dein Wissen und deine Geschichten kostenlos mit der Welt in Form von modernen, multimedialen Kurzformat-Miniblogs.

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Kommentarsysteme
  * [GraphComment](https://graphcomment.com/) – GraphComment ist eine Kommentierungsplattform, die Ihnen hilft, aus dem Website-Publikum eine aktive Community aufzubauen.
  * [Utterances](https://utteranc.es/) – Ein leichtgewichtiges Kommentar-Widget, das auf GitHub-Issues basiert. Verwenden Sie GitHub-Issues für Blog-Kommentare, Wikiseiten und mehr!
  * [Disqus](https://disqus.com/) – Disqus ist eine vernetzte Community-Plattform, die von Hunderttausenden Websites weltweit genutzt wird.
  * [Remarkbox](https://www.remarkbox.com/) – Open-Source-gehostete Kommentierungsplattform, „Zahle, was du kannst“ für „Einen Moderator auf wenigen Domains mit vollständiger Kontrolle über Verhalten und Aussehen“
  * [IntenseDebate](https://intensedebate.com/) – Ein funktionsreiches Kommentarsystem für WordPress, Tumblr, Blogger und viele andere Website-Plattformen.

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Screenshot-APIs

  * [ApiFlash](https://apiflash.com) — Eine Screenshot-API, die auf AWS Lambda und Chrome basiert. Unterstützt Ganzseitenaufnahmen, Timing und Viewport-Abmessungen.
  * [microlink.io](https://microlink.io/) – Wandelt jede Website in Daten um, wie z.B. Metatag-Normalisierung, schöne Link-Vorschauen, Scraping-Funktionen oder Screenshots als Service. 250 Anfragen/Tag jeden Tag kostenlos.
  * [ScreenshotAPI.net](https://screenshotapi.net/) – Screenshot-API mit einfacher API-Anfrage zur Generierung von Screenshots jeder Website. Skalierbar und gehostet auf Google Cloud. Bietet 100 kostenlose Screenshots pro Monat.
  * [screenshotlayer.com](https://screenshotlayer.com/) — Erfassen Sie hochgradig anpassbare Schnappschüsse jeder Website. Kostenlos 100 Schnappschüsse/Monat
  * [screenshotmachine.com](https://www.screenshotmachine.com/) — Erfassen Sie 100 Schnappschüsse/Monat, png, gif und jpg, einschließlich Ganzseitenaufnahmen, nicht nur der Startseite
  * [PhantomJsCloud](https://PhantomJsCloud.com) — Browserautomatisierung und Seitenrendering. Kostenloses Kontingent bietet bis zu 500 Seiten/Tag. Kostenloser Tarif seit 2017.
  * [Webshrinker.com](https://webshrinker.com) — Web Shrinker bietet Website-Screenshots und Domain-Intelligence-API-Dienste. Kostenlos 100 Anfragen/Monat.
  * [Screenshots](https://screenshotson.click) — Ihre API für Screenshots. Mit hochgradig anpassbaren Optionen für die Aufnahme. Kostenlos 100 Screenshots/Monat.

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Flutter-bezogen & iOS-Apps ohne Mac erstellen

  * [FlutLab](https://flutlab.io/) – FlutLab ist eine moderne Flutter-Online-IDE und der beste Ort, um plattformübergreifende Projekte zu erstellen, debuggen und zu bauen. Erstellen Sie iOS- (ohne Mac) und Android-Apps mit Flutter.
  * [CodeMagic](https://codemagic.io/) – Codemagic ist ein vollständig gehostetes und verwaltetes CI/CD für mobile Apps. Sie können mit einem GUI-basierten CI/CD-Tool bauen, testen und bereitstellen. Die kostenlose Stufe bietet 500 kostenlose Minuten/Monat und eine Mac Mini-Instanz mit 2,3 GHz und 8 GB RAM.
  * [FlutterFlow](https://flutterflow.io/) – FlutterFlow ist eine browserbasierte Drag-and-Drop-Oberfläche zum Erstellen von mobilen Apps mit Flutter.

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Browserbasierte Hardware-Emulation in Javascript

  * [JsLinux](https://bellard.org/jslinux) — Eine wirklich schnelle x86-VM, die Linux und Windows 2k ausführen kann.
  * [Jor1k](https://s-macke.github.io/jor1k/demos/main.html) — Eine OpenRISC-VM, die Linux mit Netzwerkunterstützung ausführen kann.
  * [v86](https://copy.sh/v86) — Eine x86-VM, die Linux und andere Betriebssysteme direkt im Browser ausführen kann.

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Datenschutzmanagement
  * [Bearer](https://www.bearer.sh/) – Hilft bei der Umsetzung von Privacy by Design durch Audits und kontinuierliche Workflows, damit Organisationen der DSGVO und anderen Vorschriften entsprechen. Die kostenlose Stufe ist auf kleinere Teams und die SaaS-Version beschränkt.
  * [Osano](https://www.osano.com/) – Einwilligungsmanagement- und Compliance-Plattform mit allem von DSGVO-Vertretung bis hin zu Cookie-Bannern. Die kostenlose Stufe bietet Basisfunktionen.
  * [Iubenda](https://www.iubenda.com/) – Datenschutz- und Cookie-Richtlinien sowie Einwilligungsmanagement. Die kostenlose Stufe bietet eingeschränkte Datenschutz- und Cookie-Richtlinien sowie Cookie-Banner.
  * [Cookiefirst](https://cookiefirst.com/) – Cookie-Banner, Auditing und mehrsprachige Einwilligungsmanagement-Lösung. Die kostenlose Stufe bietet einen einmaligen Scan und ein einziges Banner.

**[⬆️ Zurück zum Anfang](#table-of-contents)**
* [Ketch](https://www.ketch.com/) - Tool für Consent-Management und Datenschutz-Framework. Das kostenlose Kontingent bietet die meisten Funktionen mit einer begrenzten Besucherzahl.
* [Concord](https://www.concord.tech/) - Vollständige Datenschutzplattform, einschließlich Consent-Management, Bearbeitung von Datenschutzanfragen (DSARs) und Datenmapping. Das kostenlose Kontingent umfasst die wichtigsten Consent-Management-Funktionen und es gibt einen erweiterten Gratis-Plan für verifizierte Open-Source-Projekte.

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Verschiedenes

* [BackgroundStyler.com](https://backgroundstyler.com) - Erstelle ästhetische Screenshots von deinem Code, Text oder Bildern, um sie in sozialen Medien zu teilen.
* [BinShare.net](https://binshare.net) - Erstelle & teile Code oder Binärdateien. Kann als schönes Bild (z.B. für Twitter/Facebook-Posts) oder als Link (z.B. für Chats oder Foren) geteilt werden.
* [Blynk](https://blynk.io) — Ein SaaS mit API zur Steuerung, Erstellung & Bewertung von IoT-Geräten. Kostenloser Entwickler-Plan mit 5 Geräten, kostenlosem Cloud- & Datenspeicher. Mobile Apps sind ebenfalls verfügbar.
* [Bricks Note Calculator](https://free.getbricks.app/) - Eine Notiz-App (PWA) mit einem leistungsstarken, integrierten Mehrzeilen-Taschenrechner.
* [Carbon.now.sh](https://carbon.now.sh) - Erstelle und teile Code-Snippets als ästhetische, screenshot-ähnliche Bilder. Wird meist verwendet, um Code-Snippets ästhetisch auf Twitter oder in Blogposts zu teilen/zu zeigen.
* [Code Time](https://www.software.com/code-time) - Erweiterung für Zeitmessung und Code-Metriken in VS Code, Atom, IntelliJ, Sublime Text und mehr.
* [Codepng](https://www.codepng.app) - Erstelle exzellente Schnappschüsse deines Quellcodes, um sie in sozialen Medien zu teilen.
* [CodeToImage](https://codetoimage.com/) - Erstelle Screenshots von Code oder Text, um sie in sozialen Medien zu teilen.
* [Cronhooks](https://cronhooks.io/) - Einmalige oder wiederkehrende Webhooks planen. Der kostenlose Plan erlaubt 5 Ad-hoc-Zeitpläne.
* [cron-job.org](https://cron-job.org) - Online-Cronjob-Service. Unbegrenzte Jobs sind kostenlos.
* [datelist.io](https://datelist.io) - Online-Buchungs-/Terminplanungssystem. Kostenlos bis zu 5 Buchungen pro Monat, beinhaltet 1 Kalender.
* [Domain Forward](https://domain-forward.com/) - Ein einfaches Tool, um beliebige URLs oder Domains weiterzuleiten. Kostenlos bis zu 5 Domains und 200.000 Anfragen pro Monat.
* [Elementor](https://elementor.com) — WordPress-Website-Builder. Kostenloser Plan mit über 40 Basis-Widgets.
* [Exif Editor](https://exifeditor.io/) — Anzeige, Bearbeitung, Löschung und Analyse von Bild-/Foto-Metadaten sofort im Browser – inklusive GPS-Standort und Metadaten.
* [Format Express](https://www.format-express.dev) - Sofortige Online-Formatierung für JSON/XML/SQL.
* [FOSSA](https://fossa.com/) - Skalierbares End-to-End-Management für Drittanbieter-Code, Lizenz-Compliance und Schwachstellen.
* [Hook Relay](https://www.hookrelay.dev/) - Webhook-Support für deine App ohne Aufwand: inkl. Queueing, Retries mit Backoff und Logging. Der kostenlose Plan bietet 100 Auslieferungen pro Tag, 14 Tage Aufbewahrung und 3 Hook-Endpunkte.
* [Hosting Checker](https://hostingchecker.co) - Prüfe Hosting-Informationen wie ASN, ISP, Standort und mehr für jede Domain, Website oder IP-Adresse. Enthält auch mehrere Hosting- und DNS-bezogene Tools.
* [http2.pro](https://http2.pro) — HTTP/2-Protokoll-Bereitschaftstest und API zur Erkennung von Client-HTTP/2-Unterstützung.
* [kandi](https://kandi.openweaver.com/) — Application Development beschleunigen: eigene Funktionen, Use Cases und komplette Anwendungen schneller durch Code-Snippets und Open-Source-Bibliotheken erstellen.
* [Base64 decoder/encoder](https://devpal.co/base64-decode/) — Kostenloses Online-Tool zum Decodieren & Encodieren von Daten.
* [newreleases.io](https://newreleases.io/) - E-Mail-, Slack-, Telegram-, Discord- und benutzerdefinierte Webhook-Benachrichtigungen über neue Releases von GitHub, GitLab, Bitbucket, Python PyPI, Java Maven, Node.js NPM, Node.js Yarn, Ruby Gems, PHP Packagist, .NET NuGet, Rust Cargo und Docker Hub.
* [OnlineExifViewer](https://onlineexifviewer.com/) — Zeige EXIF-Daten eines Fotos sofort online an, einschließlich GPS-Standort und Metadaten.
* [PDFMonkey](https://www.pdfmonkey.io/) — Verwalte PDF-Vorlagen im Dashboard, rufe die API mit dynamischen Daten auf und lade dein PDF herunter. Bietet 300 kostenlose Dokumente pro Monat.
* [Pika Code Screenshots](https://pika.style/templates/code-image) — Erstelle schöne, anpassbare Screenshots aus Code-Snippets und VSCode mittels Erweiterung.
* [QuickType.io](https://quicktype.io/) - Modelle/Klassen/Typen/Interfaces und Serialisierer schnell automatisch aus JSON, Schema und GraphQL generieren für sicheres und schnelles Arbeiten mit Daten in jeder Programmiersprache. Konvertiere JSON in wunderschönen, typensicheren Code in jeder Sprache.
* [RandomKeygen](https://randomkeygen.com/) - Kostenloses, mobilfreundliches Tool, das verschiedene zufällig generierte Schlüssel und Passwörter für die Absicherung beliebiger Anwendungen, Dienste oder Geräte anbietet.
* [ray.so](https://ray.so/) - Erstelle schöne Bilder deiner Code-Snippets.
* [readme.com](https://readme.com/) — Schöne Dokumentation einfach gemacht, kostenlos für Open Source.
* [redirection.io](https://redirection.io/) — SaaS-Tool zum Verwalten von HTTP-Weiterleitungen für Unternehmen, Marketing und SEO.
* [redirect.ing](https://redirect.ing/) - Schnelles & sicheres Domain-Forwarding ohne Server- oder SSL-Zertifikats-Management. Der kostenlose Plan beinhaltet 10 Hostnamen und 100.000 Anfragen pro Monat.
* [redirect.pizza](https://redirect.pizza/) - Einfaches Management von Redirects mit HTTPS-Unterstützung. Der kostenlose Plan umfasst 10 Quellen und 100.000 Aufrufe pro Monat.
* [ReqBin](https://reqbin.com/) — HTTP-Anfragen online absetzen. Unterstützt gängige Methoden wie GET, POST, PUT, DELETE und HEAD. Unterstützt Header und Token-Authentifizierung. Grundlegendes Loginsystem zum Speichern der Anfragen enthalten.
* [Smartcar API](https://smartcar.com) - Eine API für Autos zum Orten, Abfragen von Tankfüllstand, Batteriestand, Kilometerzähler, Türen öffnen/schließen, usw.
* [snappify](https://snappify.com) - Erlaubt Entwicklern, beeindruckende Visuals zu erstellen. Von schönen Code-Snippets bis zu ausgearbeiteten technischen Präsentationen. Der kostenlose Plan erlaubt bis zu 3 Snaps gleichzeitig mit unbegrenzten Downloads und 5 KI-gestützten Code-Erklärungen pro Monat.
* [Sunrise and Sunset](https://sunrisesunset.io/api/) - Liefert Sonnenaufgangs- und Sonnenuntergangszeiten für eine bestimmte Längen- und Breitengrad.
* [superfeedr.com](https://superfeedr.com/) — Echtzeit PubSubHubbub-konforme Feeds, Export, Analysen. Kostenlos mit weniger Anpassungsmöglichkeiten.
* [SurveyMonkey.com](https://www.surveymonkey.com) — Online-Umfragen erstellen. Ergebnisse online analysieren. Der kostenlose Plan erlaubt nur 10 Fragen und 100 Antworten pro Umfrage.
* [Tiledesk](https://tiledesk.com) - Erstelle Chatbots und Konversations-Apps. Bringe sie Omnichannel: von deiner Website (Live-Chat-Widget) bis WhatsApp. Kostenloser Plan mit unbegrenzten Chatbots.
* [Versionfeeds](https://versionfeeds.com) — Benutzerdefinierte RSS-Feeds für Releases deiner Lieblingssoftware. Habe die neuesten Versionen deiner Programmiersprachen, Bibliotheken oder Tools in einem Feed. (Die ersten 3 Feeds sind kostenlos)
* [videoinu](https://videoinu.com) — Bildschirmaufnahmen und andere Videos online erstellen und bearbeiten.
* [Webacus](https://webacus.dev) — Zugriff auf eine breite Palette kostenloser Entwickler-Tools für Encoding, Decoding und Datenmanipulation.

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Remote-Desktop-Tools

* [Getscreen.me](https://getscreen.me) — Kostenlos für 2 Geräte, keine Begrenzung der Anzahl und Dauer der Sitzungen
* [Apache Guacamole™](https://guacamole.apache.org/) — Open-Source-Remote-Desktop-Gateway ohne Client
* [RemSupp](https://remsupp.com) — On-Demand-Support und permanenter Zugriff auf Geräte (2 Sitzungen/Tag kostenlos)
* [RustDesk](https://rustdesk.com/) - Open-Source-Virtual-/Remote-Desktop-Infrastruktur für alle!
* [AnyDesk](https://anydesk.com) — Kostenlos für 3 Geräte, keine Begrenzung der Anzahl und Dauer der Sitzungen

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Spieleentwicklung

* [itch.io](https://itch.io/game-assets) — Kostenlose/kostenpflichtige Assets wie Sprites, Tile-Sets und Charakterpakete.
* [Gamefresco.com](https://gamefresco.com/) — Entdecke, sammle und teile kostenlose Spiel-Assets von Game Artists aus aller Welt.
* [GameDevMarket](https://gamedevmarket.net) — Kostenlose/kostenpflichtige Assets wie 2D, 3D, Audio, GUI.
* [OpenGameArt](https://opengameart.org) — Open-Source-Spiel-Assets wie Musik, Sounds, Sprites und Gifs.
* [CraftPix](https://craftpix.net) — Kostenlose/kostenpflichtige Assets wie 2D, 3D, Audio, GUI, Hintergründe, Icons, Tile-Sets, Game-Kits.
* [Game Icons](https://game-icons.net/) - Kostenlose, anpassbare SVG/PNG-Icons unter CC-BY-Lizenz.
* [LoSpec](https://lospec.com/) — Online-Tools zum Erstellen von Pixel-Art und anderer restriktiver Digital Art, viele Tutorials/Palettenlisten zur Auswahl für deine Spiele.
* [ArtStation](https://www.artstation.com/) - Marktplatz für kostenlose/kostenpflichtige 2D-, 3D-Assets & Audios, Icons, Tile-Sets, Game-Kits. Auch zur Präsentation deines Art-Portfolios geeignet.
* [Rive](https://rive.app/community/) - Community-Assets sowie Möglichkeit, eigene Spiel-Assets mit dem kostenlosen Plan zu erstellen.
* [Poly Pizza](https://poly.pizza/) - Kostenlose Low-Poly-3D-Assets.
* [3Dassets.one](https://3dassets.one/) - Über 8.000 kostenlose/kostenpflichtige 3D-Modelle und PBR-Materialien für Texturen.
* [Kenney](https://www.kenney.nl/assets/) - Kostenlose (CC0 1.0 Universal-Lizenz) 2D-, 3D-, Audio- und UI-Spiel-Assets.
* [Poliigon](https://www.poliigon.com/) - Kostenlose und kostenpflichtige Texturen (mit variabler Auflösung), Modelle, HDRIs und Brushes. Bietet kostenlose Plugins zum Export in Software wie Blender.
* [Freesound](https://freesound.org/) - Kostenlose kollaborative Soundbibliothek mit verschiedenen CC-Lizenzen.

**[⬆️ Zurück zum Anfang](#table-of-contents)**

## Weitere kostenlose Ressourcen

* [Wikimint Developer](https://developer.wikimint.com/p/tools.html) - Immer kostenlose Tools für Webentwickler, darunter CSS-Minify/Unminify, Bildoptimierer, Bildgrößenänderer, Case Converter, CSS-Validator, JavaScript-Compiler, HTML-Editor usw.
* [ElevateAI](https://www.elevateai.com) - Bis zu 200 Stunden Audiotranskription pro Monat kostenlos.
* [get.localhost.direct](https://get.localhost.direct) — Ein besseres `*.localhost.direct` Wildcard-SSL-Zertifikat von einer öffentlichen CA für die lokale Entwicklung mit Subdomain-Unterstützung
* [Framacloud](https://degooglisons-internet.org/en/) — Eine Liste von Free/Libre Open Source Software und SaaS der französischen Non-Profit-Organisation [Framasoft](https://framasoft.org/en/).
* [github.com — FOSS for Dev](https://github.com/tvvocold/FOSS-for-Dev) — Eine Anlaufstelle für kostenlose und Open-Source-Software für Entwickler.
* [GitHub Education](https://education.github.com/pack) — Sammlung kostenloser Services für Studierende. Registrierung erforderlich.
* [Markdown Tools](https://markdowntools.com) - Tools zum Konvertieren von HTML, CSV, PDF, JSON und Excel-Dateien in und aus Markdown.
* [Microsoft 365 Developer Program](https://developer.microsoft.com/microsoft-365/dev-program) — Kostenloses Sandbox-Konto, Tools und weitere Ressourcen, um Lösungen für die Microsoft-365-Plattform zu entwickeln. Das Abonnement ist ein 90-tägiges [Microsoft 365 E5-Abonnement](https://www.microsoft.com/microsoft-365/enterprise/e5) (Windows ausgeschlossen), das erneuert werden kann. Die Erneuerung erfolgt bei aktiver Entwicklung (gemessen mittels Telemetriedaten & Algorithmen).
* [Pyrexp](https://pythonium.net/regex) — Kostenloser webbasierter Regex-Tester und Visualisierer zum Debuggen von regulären Ausdrücken.
* [RedHat for Developers](https://developers.redhat.com) — Kostenloser Zugang zu Red Hat Produkten einschließlich RHEL, OpenShift, CodeReady usw., ausschließlich für Entwickler. Nur Einzelpläne. Kostenlose E-Books werden ebenfalls als Referenz angeboten.
* [smsreceivefree.com](https://smsreceivefree.com/) — Bietet kostenlose temporäre und Wegwerf-Telefonnummern.
* [sandbox.httpsms.com](https://sandbox.httpsms.com) — Sende und empfange Test-SMS-Nachrichten kostenlos.
* [SimpleBackups.com](https://simplebackups.com/) — Backup-Automatisierungsdienst für Server und Datenbanken (MySQL, PostgreSQL, MongoDB), die direkt in Cloud-Speicheranbieter (AWS, DigitalOcean, Backblaze) gespeichert werden. Bietet einen kostenlosen Plan für 1 Backup.
* [SnapShooter](https://snapshooter.com/) — Backup-Lösung für DigitalOcean, AWS, LightSail, Hetzner und Exoscale, mit Unterstützung für direkte Datenbank-, Dateisystem- und Anwendungs-Backups auf s3-basierten Speicher. Bietet einen kostenlosen Plan mit täglichen Backups für eine Ressource.
* [Themeselection](https://themeselection.com/) — Ausgewählte hochwertige, moderne, professionelle und einfach zu verwendende kostenlose Admin-Dashboard-Vorlagen,
HTML-Themes und UI-Kits, um deine Anwendungen schneller zu erstellen!
* [Web.Dev](https://web.dev/measure/) — Kostenloses Tool zur Analyse der Website-Performance und zur Verbesserung des SEO für ein besseres Ranking in Suchmaschinen.

**[⬆️ Zurück zum Anfang](#table-of-contents)**
  * [SmallDev.tools](https://smalldev.tools/) — Ein kostenloses Tool für Entwickler, das das Kodieren/Dekodieren verschiedener Formate, das Minifizieren von HTML/CSS/Javascript, Beautifying, das Generieren von Fake-/Testdatensätzen in JSON/CSV & vielen weiteren Formaten sowie viele weitere Funktionen ermöglicht. Mit einer ansprechenden Benutzeroberfläche.
  * [UseCSV von Layercode](https://layercode.com/usecsv) — Fügen Sie Ihrer Web-App in wenigen Minuten den Import von CSV- und Excel-Dateien hinzu. Bieten Sie Ihren Nutzern ein angenehmes und robustes Datenimport-Erlebnis. Beginnen Sie kostenlos ohne Kreditkartenangaben und integrieren Sie UseCSV noch heute. Sie können unbegrenzt viele Importeure erstellen und Dateien mit bis zu 100 MB hochladen.
  * [Buttons Generator](https://markodenic.com/tools/buttons-generator/) — Über 100 Buttons, die Sie in Ihrem Projekt verwenden können.
  * [WrapPixel](https://www.wrappixel.com/) — Laden Sie hochwertige kostenlose und Premium-Admin-Dashboard-Vorlagen herunter, die mit Angular, React, VueJs, NextJS und NuxtJS erstellt wurden!
  * [Utils.fun](https://utils.fun/en) — Alle Offline-Tools für den täglichen Gebrauch und die Entwicklung basieren auf der Rechenleistung des Browsers, einschließlich Wasserzeichengenerierung, Bildschirmaufnahme, Kodierung und Dekodierung, Verschlüsselung und Entschlüsselung sowie Code-Formatierung. Sie sind komplett kostenlos und laden keine Daten zur Verarbeitung in die Cloud hoch.
  * [It tools](it-tools.tech) – Nützliche Tools für Entwickler und IT-Fachleute.
  * [Free Code Tools](https://freecodetools.org/) — Effektive Code-Tools, die 100% kostenlos sind. Markdown-Editor, Code-Minifier/Beautifier, QR-Code-Generator, Open Graph Generator, Twitter Card Generator und mehr.
  * [regex101](https://regex101.com/) — Kostenloses Testen und Debuggen von regulären Ausdrücken (Regex) auf dieser Website. Sie bietet einen Regex-Editor und -Tester sowie hilfreiche Dokumentationen und Ressourcen zum Erlernen von Regex.
  * [Kody Tools](https://www.kodytools.com/dev-tools) — Über 100 Entwickler-Tools, darunter Formatter, Minifier und Converter.
  * [AdminMart](https://adminmart.com/) — Hochwertige kostenlose und Premium-Admin-Dashboard- und Website-Vorlagen, erstellt mit Angular, Bootstrap, React, VueJs, NextJS und NuxtJS!
  * [Glob tester](https://globster.xyz/) — Eine Website, auf der Sie Glob-Muster entwerfen und testen können. Es gibt auch Ressourcen zum Erlernen von Glob-Mustern.
  * [SimpleRestore](https://simplerestore.io) – Mühelose MySQL-Backup-Wiederherstellung. Stellen Sie MySQL-Backups auf jede entfernte Datenbank wieder her – ohne Code oder Server.
  * [360Converter](https://www.360converter.com/) – Kostenlose Website zur Umwandlung von: Video zu Text && Audio zu Text && Sprache zu Text && Echtzeit-Audio zu Text && YouTube-Video zu Text && Video-Untertitel hinzufügen. Vielleicht hilfreich für die schnelle Umwandlung eines kurzen Videos oder eines kurzen YouTube-Tutorials :)
  * [QRCodeBest](https://qrcode.best/) – Erstellen Sie benutzerdefinierte QR-Codes mit 13 Vorlagen, vollständiger Privatsphäre und persönlichem Branding. Funktionen wie Tracking-Pixel, Projektkategorisierung und unbegrenzte Teamplätze auf QRCode.Best.
  * [PostPulse](https://PostPulseAI.com) – Stärken Sie Ihre Online-Präsenz und verbessern Sie Ihr SEO und Ranking mit monatlich KI-erstellten Beiträgen auf SEO-optimierten Domains. Der kostenlose Plan erlaubt das manuelle Veröffentlichen eines Beitrags pro Monat auf unserer Seite.
  * [PageTools](https://pagetools.co/) – Bietet eine Suite von dauerhaft kostenlosen KI-gestützten Tools, um wichtige Website-Richtlinien zu generieren, Social-Media-Bios, Beiträge und Webseiten mit einer einfachen One-Click-Oberfläche zu erstellen.
  * [MySQL Visual Explain](https://mysqlexplain.com) – Ein leicht verständlicher und kostenloser MySQL-EXPLAIN-Output-Visualizer zur Optimierung langsamer Abfragen.
  * [Killer Coda](https://killercoda.com/) – Interaktiver Playground in Ihrem Browser zum Lernen von Linux, Kubernetes, Containern, Programmierung, DevOps, Networking.
  * [Axonomy App](https://axonomy-app.com/) – Ein kostenloses Tool zum Erstellen, Verwalten und Teilen Ihrer Rechnungen mit Ihren Kunden. 10 kostenlose Rechnungen pro Monat.
  * [Table Format Converter](https://www.tableformatconverter.com) – Ein kostenloses Tool zum Konvertieren von Tabellendaten in verschiedene Formate wie CSV, HTML, JSON, Markdown und mehr.


**[⬆️ Zurück zum Anfang](#table-of-contents)**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---
# free-for.dev

Les développeurs et les auteurs Open Source disposent aujourd'hui de nombreux services offrant des formules gratuites, mais il faut du temps pour tous les trouver et prendre des décisions éclairées.

Voici une liste de logiciels (SaaS, PaaS, IaaS, etc.) et d'autres offres avec des formules gratuites pour les développeurs.

La portée de cette liste particulière est limitée aux éléments que les développeurs d'infrastructure (administrateurs système, praticiens DevOps, etc.) sont susceptibles de trouver utiles. Nous aimons tous les services gratuits disponibles, mais il serait bon de rester dans le sujet. Parfois, la frontière est floue, donc cette liste est subjective ; merci de ne pas vous offenser si je n'accepte pas votre contribution.

Cette liste est le résultat de Pull Requests, de revues, d'idées et du travail de plus de 1600 personnes. Vous pouvez aussi aider en envoyant des [Pull Requests](https://github.com/ripienaar/free-for-dev) pour ajouter de nouveaux services ou retirer ceux dont les offres ont changé ou ont été supprimées.

[![Track Awesome List](https://www.trackawesomelist.com/badge.svg)](https://www.trackawesomelist.com/ripienaar/free-for-dev)

**REMARQUE** : Cette liste concerne uniquement les offres as-a-Service, et non les logiciels auto-hébergés. Pour être éligible, un service doit proposer une offre gratuite, et pas seulement un essai gratuit. L'offre gratuite doit durer au moins un an si elle est limitée dans le temps. Nous prenons également en compte l'offre gratuite d'un point de vue sécurité ; SSO est accepté, mais je n'accepterai pas les services qui réservent TLS aux offres payantes uniquement.

# Table des matières

  * [Limites toujours gratuites des principaux fournisseurs de cloud](#major-cloud-providers)
  * [Solutions de gestion cloud](#cloud-management-solutions)
  * [Analytique, événements et statistiques](#analytics-events-and-statistics)
  * [APIs, données et ML](#apis-data-and-ml)
  * [Dépôts d’artifacts](#artifact-repos)
  * [BaaS](#baas)
  * [Plateforme Low-code](#low-code-platform)
  * [CDN et protection](#cdn-and-protection)
  * [CI et CD](#ci-and-cd)
  * [CMS](#cms)
  * [Génération de code](#code-generation)
  * [Qualité du code](#code-quality)
  * [Recherche et navigation dans le code](#code-search-and-browsing)
  * [Gestion des crashs et exceptions](#crash-and-exception-handling)
  * [Visualisation de données sur des cartes](#data-visualization-on-maps)
  * [Services de données managés](#managed-data-services)
  * [Design et UI](#design-and-ui)
  * [Inspiration pour le design](#design-inspiration)
  * [Sites de blogging pour développeurs](#dev-blogging-sites)
  * [DNS](#dns)
  * [Lié à Docker](#docker-related)
  * [Domaine](#domain)
  * [Éducation et développement de carrière](#education-and-career-development)
  * [Email](#email)
  * [Plateformes de gestion de Feature Toggles](#feature-toggles-management-platforms)
  * [Police de caractères](#font)
  * [Formulaires](#forms)
  * [IA générative](#generative-ai)
  * [IaaS](#iaas)
  * [IDE et édition de code](#ide-and-code-editing)
  * [API et SDK de vérification de numéros mobiles internationaux](#international-mobile-number-verification-api-and-sdk)
  * [Gestion des tickets et des projets](#issue-tracking-and-project-management)
  * [Gestion des logs](#log-management)
  * [Distribution et feedback d'applications mobiles](#mobile-app-distribution-and-feedback)
  * [Systèmes de gestion](#management-system)
  * [Messagerie et streaming](#messaging-and-streaming)
  * [Divers](#miscellaneous)
  * [Supervision](#monitoring)
  * [PaaS](#paas)
  * [Système de construction de paquets](#package-build-system)
  * [Intégration paiement et facturation](#payment-and-billing-integration)
  * [Gestion de la confidentialité](#privacy-management)
  * [APIs de capture d’écran](#screenshot-apis)
  * [Lié à Flutter et compilation d’apps iOS sans Mac](#flutter-related-and-building-ios-apps-without-mac)
  * [Recherche](#search)
  * [Sécurité et PKI](#security-and-pki)
  * [Authentification, autorisation et gestion des utilisateurs](#authentication-authorization-and-user-management)
  * [Dépôts de code source](#source-code-repos)
  * [Stockage et traitement média](#storage-and-media-processing)
  * [Tunneling, WebRTC, serveurs Web Socket et autres routeurs](#tunneling-webrtc-web-socket-servers-and-other-routers)
  * [Tests](#testing)
  * [Outils pour équipes et collaboration](#tools-for-teams-and-collaboration)
  * [Gestion de la traduction](#translation-management)
  * [Lié à Vagrant](#vagrant-related)
  * [Enregistrement de sessions visiteurs](#visitor-session-recording)
  * [Hébergement web](#web-hosting)
  * [Plateformes de commentaires](#commenting-platforms)
  * [Émulation matérielle basée sur navigateur](#browser-based-hardware-emulation-written-in-javascript)
  * [Outils de bureau à distance](#remote-desktop-tools)
  * [Développement de jeux](#game-development)
  * [Autres ressources gratuites](#other-free-resources)

## Principaux fournisseurs de Cloud

  * [Google Cloud Platform](https://cloud.google.com)
    * App Engine - 28 heures d'instance frontend par jour, neuf heures d'instance backend par jour
    * Cloud Firestore - 1 Go de stockage, 50 000 lectures, 20 000 écritures, 20 000 suppressions par jour
    * Compute Engine - 1 e2-micro non préemptible, 30 Go HDD, 5 Go de stockage de snapshot (restreint à certaines régions), 1 Go de sortie réseau depuis l’Amérique du Nord vers toutes les destinations régionales (hors Chine et Australie) par mois
    * Cloud Storage - 5 Go, 1 Go de sortie réseau
    * Cloud Shell - Shell Linux/IDE principal basé sur le Web avec 5 Go de stockage persistant. Limite de 60 heures par semaine
    * Cloud Pub/Sub - 10 Go de messages par mois
    * Cloud Functions - 2 millions d'invocations par mois (inclut les invocations en arrière-plan et HTTP)
    * Cloud Run - 2 millions de requêtes par mois, 360 000 Go-secondes de mémoire, 180 000 vCPU-secondes de temps de calcul, 1 Go de sortie réseau depuis l’Amérique du Nord par mois
    * Google Kubernetes Engine - Pas de frais de gestion de cluster pour un cluster zonal. Chaque nœud utilisateur est facturé au tarif standard Compute Engine
    * BigQuery - 1 To de requêtes par mois, 10 Go de stockage par mois
    * Cloud Build - 120 minutes de build par jour
    * Cloud Source Repositories - Jusqu’à 5 utilisateurs, 50 Go de stockage, 50 Go de sortie
    * [Google Colab](https://colab.research.google.com/) - Environnement de développement Jupyter Notebooks gratuit.
    * [Firebase Studio](https://firebase.studio) Google Firebase Studio (anciennement Project IDX). VSCode en ligne fonctionnant sur Google Cloud.
    * Liste complète et détaillée - https://cloud.google.com/free

  * [Amazon Web Services](https://aws.amazon.com)
    * [CloudFront](https://aws.amazon.com/cloudfront/) - 1 To de sortie réseau par mois et 2M d’invocations de fonctions par mois
    * [CloudWatch](https://aws.amazon.com/cloudwatch/) - 10 métriques personnalisées et dix alarmes
* [CodeBuild](https://aws.amazon.com/codebuild/) - 100 minutes de temps de build par mois  
* [CodeCommit](https://aws.amazon.com/codecommit/) - 5 utilisateurs actifs, 50 Go de stockage et 10 000 requêtes par mois  
* [CodePipeline](https://aws.amazon.com/codepipeline/) - 1 pipeline actif par mois  
* [DynamoDB](https://aws.amazon.com/dynamodb/) - Base de données NoSQL de 25 Go  
* [EC2](https://aws.amazon.com/ec2/) - 750 heures par mois de t2.micro ou t3.micro (12 mois). 100 Go de sortie par mois  
* [EBS](https://aws.amazon.com/ebs/) - 30 Go par mois de stockage General Purpose (SSD) ou Magnétique (12 mois)  
* [Elastic Load Balancing](https://aws.amazon.com/elasticloadbalancing/) - 750 heures par mois (12 mois)  
* [RDS](https://aws.amazon.com/rds/) - 750 heures par mois de db.t2.micro, db.t3.micro, ou db.t4g.micro, 20 Go de stockage General Purpose (SSD), 20 Go de stockage de sauvegardes (12 mois)  
* [S3](https://aws.amazon.com/s3/) - 5 Go de stockage d’objets Standard, 20 000 requêtes GET et 2 000 requêtes PUT (12 mois)  
* [Glacier](https://aws.amazon.com/glacier/) - 10 Go de stockage d’objets à long terme  
* [Lambda](https://aws.amazon.com/lambda/) - 1 million de requêtes par mois  
* [SNS](https://aws.amazon.com/sns/) - 1 million de publications par mois  
* [SES](https://aws.amazon.com/ses/) - 3 000 messages par mois (12 mois)  
* [SQS](https://aws.amazon.com/sqs/) - 1 million de requêtes de file de messagerie  
* Liste complète et détaillée - https://aws.amazon.com/free/

* [Microsoft Azure](https://azure.microsoft.com)
  * [Virtual Machines](https://azure.microsoft.com/services/virtual-machines/) - 1 VM Linux B1S, 1 VM Windows B1S (12 mois)
  * [App Service](https://azure.microsoft.com/services/app-service/) - 10 applications web, mobiles ou API (60 minutes CPU/jour)
  * [Functions](https://azure.microsoft.com/services/functions/) - 1 million de requêtes par mois
  * [DevTest Labs](https://azure.microsoft.com/services/devtest-lab/) - Environnements de dev-test rapides, faciles et légers
  * [Active Directory](https://azure.microsoft.com/services/active-directory/) - 500 000 objets
  * [Active Directory B2C](https://azure.microsoft.com/services/active-directory/external-identities/b2c/) - 50 000 utilisateurs stockés mensuels
  * [Azure DevOps](https://azure.microsoft.com/services/devops/) - 5 utilisateurs actifs, dépôts Git privés illimités
  * [Azure Pipelines](https://azure.microsoft.com/services/devops/pipelines/) — 10 jobs parallèles gratuits avec minutes illimitées pour l’open source pour Linux, macOS et Windows
  * [Microsoft IoT Hub](https://azure.microsoft.com/services/iot-hub/) - 8 000 messages par jour
  * [Load Balancer](https://azure.microsoft.com/services/load-balancer/) - 1 IP publique équilibrée (VIP) gratuite
  * [Notification Hubs](https://azure.microsoft.com/services/notification-hubs/) - 1 million de notifications push
  * [Bandwidth](https://azure.microsoft.com/pricing/details/bandwidth/) - 15 Go entrant (12 mois) & 5 Go sortant par mois
  * [Cosmos DB](https://azure.microsoft.com/services/cosmos-db/) - 25 Go de stockage et 1 000 RU de débit provisionné
  * [Static Web Apps](https://azure.microsoft.com/pricing/details/app-service/static/) — Construisez, déployez et hébergez des applications statiques et des fonctions serverless avec SSL gratuit, Authentification/Autorisation et domaines personnalisés
  * [Storage](https://azure.microsoft.com/services/storage/) - 5 Go de stockage LRS File ou Blob (12 mois)
  * [Cognitive Services](https://azure.microsoft.com/services/cognitive-services/) - APIs IA/ML (Computer Vision, Translator, détection de visage, Bots, etc.) avec un niveau gratuit incluant un nombre limité de transactions
  * [Cognitive Search](https://azure.microsoft.com/services/search/#features) - Service de recherche et d’indexation basé sur l’IA, gratuit pour 10 000 documents
  * [Azure Kubernetes Service](https://azure.microsoft.com/services/kubernetes-service/) - Service Kubernetes managé, gestion de cluster gratuite
  * [Event Grid](https://azure.microsoft.com/services/event-grid/) - 100 000 opérations/mois
  * Liste complète et détaillée - https://azure.microsoft.com/free/

* [Oracle Cloud](https://www.oracle.com/cloud/)
  * Compute
     - 2 VM Compute basées sur AMD avec 1/8 OCPU et 1 Go de mémoire chacune
     - 4 cœurs Arm Ampere A1 et 24 Go de mémoire utilisables comme une seule VM ou jusqu’à 4 VM
     - Les instances seront récupérées lorsqu'elles seront [considérées comme inactives](https://docs.oracle.com/en-us/iaas/Content/FreeTier/freetier_topic-Always_Free_Resources.htm#compute__idleinstances)
  * Block Volume - 2 volumes, 200 Go au total (utilisés pour le compute)
  * Object Storage - 10 Go
  * Load balancer - 1 instance avec 10 Mbps
  * Bases de données - 2 BD, 20 Go chacune
  * Monitoring - 500 millions de points d’ingestion de données, 1 milliard de points de récupération de données
  * Bande passante - 10 To de sortie par mois, vitesse limitée à 50 Mbps sur VM x64, 500 Mbps * nombre de cœurs sur VM ARM
  * IP publique - 2 IPv4 pour les VM, 1 IPv4 pour le load balancer
  * Notifications - 1 million d’options de livraison par mois, 1 000 e-mails envoyés par mois
  * Liste complète et détaillée - https://www.oracle.com/cloud/free/

* [IBM Cloud](https://www.ibm.com/cloud/free/)
  * Base de données Cloudant - 1 Go de stockage de données
  * Base de données Db2 - 100 Mo de stockage de données
  * API Connect - 50 000 appels API par mois
  * Monitoring de disponibilité - 3 millions de points de données par mois
  * Analyse de logs - 500 Mo de logs quotidiens
  * Liste complète et détaillée - https://www.ibm.com/cloud/free/

* [Cloudflare](https://www.cloudflare.com/)
  * [Application Services](https://www.cloudflare.com/plans/) - DNS gratuit pour un nombre illimité de domaines, protection DDoS, CDN avec SSL gratuit, règles de pare-feu et de page, WAF, atténuation des bots, limitation de débit non mesurée gratuite - 1 règle par domaine, analytics, transfert d’e-mails
  * [Zero Trust & SASE](https://www.cloudflare.com/plans/zero-trust-services/) - Jusqu’à 50 utilisateurs, 24 heures de journalisation d’activité, trois localisations réseau
  * [Cloudflare Tunnel](https://www.cloudflare.com/products/tunnel/) - Exposez un port HTTP local sur un sous-domaine aléatoire trycloudflare.com avec [Quick Tunnels](https://developers.cloudflare.com/cloudflare-one/connections/connect-networks/do-more-with-tunnels/trycloudflare/), pas de compte requis. Plus de fonctionnalités (tunnel TCP, load balancing, VPN) dans le plan [Zero Trust](https://www.cloudflare.com/products/zero-trust/) gratuit.
  * [Workers](https://developers.cloudflare.com/workers/) - Déployez du code serverless gratuitement sur le réseau mondial Cloudflare — 100 000 requêtes quotidiennes.
  * [Workers KV](https://developers.cloudflare.com/kv) - 100 000 requêtes de lecture par jour, 1 000 requêtes d’écriture par jour, 1 000 requêtes de suppression par jour, 1 000 requêtes de listing par jour, 1 Go de données stockées
  * [R2](https://developers.cloudflare.com/r2/) - 10 Go par mois, 1 million d’opérations de classe A par mois, 10 millions d’opérations de classe B par mois
  * [D1](https://developers.cloudflare.com/d1/) - 5 millions de lignes lues par jour, 100 000 lignes écrites par jour, 1 Go de stockage
  * [Pages](https://developers.cloudflare.com/pages/) - Développez et déployez vos applications web sur le réseau mondial Cloudflare, rapide et sécurisé. Cinq cents builds mensuels, 100 domaines personnalisés, SSL intégré, sièges illimités, déploiements de prévisualisation illimités, et capacité full-stack via l’intégration Cloudflare Workers.
  * [Queues](https://developers.cloudflare.com/queues/) - 1 million d’opérations par mois
  * [TURN](https://developers.cloudflare.com/calls/turn/) – 1 To de trafic (sortant) gratuit par mois.

**[⬆️ Retour en haut](#table-of-contents)**

## Solutions de gestion du cloud

* [Brainboard](https://www.brainboard.co) - Solution collaborative pour concevoir et gérer visuellement des infrastructures cloud de bout en bout.
* [Cloud 66](https://www.cloud66.com/) - Gratuit pour les projets personnels (inclut un serveur de déploiement, un site statique), Cloud 66 fournit tout ce dont vous avez besoin pour construire, déployer et faire évoluer vos applications sur n’importe quel cloud sans la complexité du “server stuff”.
* [Pulumi](https://www.pulumi.com/) — Plateforme moderne d’Infrastructure as Code permettant d’utiliser des langages et outils familiers pour construire, déployer et gérer l’infrastructure cloud.
* [terraform.io](https://www.terraform.io/) — Terraform Cloud. Gestion d’état distant gratuite et collaboration d’équipe jusqu’à 500 ressources.
* [scalr.com](https://scalr.com/) - Scalr est un produit d’Automatisation et de Collaboration Terraform (TACO) pour améliorer la collaboration et l’automatisation sur les infrastructures et configurations gérées par Terraform. Prise en charge complète du CLI Terraform, intégration OPA, et modèle de configuration hiérarchique. Pas de taxe SSO. Toutes les fonctionnalités sont incluses. Jusqu’à 50 exécutions/mois gratuitement.
* [deployment.io](https://deployment.io) - Deployment.io aide les développeurs à automatiser les déploiements sur AWS. Sur notre offre gratuite, un développeur (utilisateur unique) peut déployer un nombre illimité de sites statiques, services web et environnements. Nous proposons 20 exécutions de jobs gratuites par mois avec aperçus et déploiements automatiques inclus.

**[⬆️ Retour en haut](#table-of-contents)**

## Dépôts de code source

* [Bitbucket](https://bitbucket.org/) — Dépôts Git publics et privés illimités pour jusqu’à 5 utilisateurs avec Pipelines pour CI/CD
* [chiselapp.com](https://chiselapp.com/) — Dépôts Fossil publics et privés illimités
* [codebasehq.com](https://www.codebasehq.com/) — Un projet gratuit avec 100 Mo d’espace et deux utilisateurs
* [Codeberg](https://codeberg.org/) — Dépôts Git publics et privés illimités pour des projets gratuits et open source (avec collaborateurs illimités). Propulsé par [Forgejo](https://forgejo.org/). Hébergement de site statique avec [Codeberg Pages](https://codeberg.page/). Hébergement CI/CD avec [Codeberg's CI](https://docs.codeberg.org/ci/). Hébergement de traduction avec [Codeberg Translate](https://translate.codeberg.org/). Hébergement de paquets et conteneurs, gestion de projet et suivi des tickets inclus.
* [GitGud](https://gitgud.io) — Dépôts privés et publics illimités. Gratuit pour toujours. Propulsé par GitLab & Sapphire. CI/CD non fourni.
* [GitHub](https://github.com/) — Dépôts publics illimités et dépôts privés illimités (avec collaborateurs illimités). Inclut CI/CD, environnement de développement, hébergement statique, hébergement de paquets et conteneurs, gestion de projet et IA Copilot
* [gitlab.com](https://about.gitlab.com/) — Dépôts Git publics et privés illimités avec jusqu’à 5 collaborateurs. Inclut CI/CD, hébergement statique, registre de conteneurs, gestion de projet et suivi de tickets
* [framagit.org](https://framagit.org/) — Framagit est la forge logicielle de Framasoft basée sur le logiciel Gitlab, inclut CI, Pages statiques, pages de projet et suivi des tickets.
* [heptapod.net](https://foss.heptapod.net/) — Heptapod est un fork convivial de GitLab Community Edition avec prise en charge de Mercurial
* [ionicframework.com](https://ionicframework.com/appflow) - Dépôt et outils pour développer des applications avec Ionic ; inclut également un dépôt ionic
* [NotABug](https://notabug.org) — NotABug.org est une plateforme de collaboration de code pour logiciels libres, basée sur Git
* [OSDN](https://osdn.net/) - OSDN.net est un service gratuit pour les développeurs de logiciels open source, offrant des dépôts SVN/Git/Mercurial/Bazaar/CVS.
* [Pagure.io](https://pagure.io) — Pagure.io est une plateforme gratuite et open source de collaboration autour du code pour les projets sous licence FOSS, basée sur Git.
* [perforce.com](https://www.perforce.com/products/helix-teamhub) — 1 Go gratuit dans le cloud et dépôts Git, Mercurial ou SVN.
* [pijul.com](https://pijul.com/) - Système de gestion de versions distribué gratuit et open source illimité. Sa particularité repose sur une théorie solide des patches, ce qui le rend facile à apprendre, utiliser et distribuer. Résout de nombreux problèmes de git/hg/svn/darcs.
* [plasticscm.com](https://plasticscm.com/) — Gratuit pour les particuliers, les projets open source et les organisations à but non lucratif.
* [projectlocker.com](https://projectlocker.com) — Un projet privé gratuit (Git et Subversion) avec 50 Mo d’espace.
* [RocketGit](https://rocketgit.com) — Hébergement de dépôts basé sur Git. Dépôts publics et privés illimités.
* [savannah.gnu.org](https://savannah.gnu.org/) - Sert de système de gestion collaborative pour le développement de logiciels libres (pour les projets GNU).
* [savannah.nongnu.org](https://savannah.nongnu.org/) - Sert de système de gestion collaborative pour le développement de logiciels libres (pour les projets non-GNU).

**[⬆️ Retour en haut](#table-of-contents)**

## APIs, Données et ML

* [JSONGrid](https://jsongrid.com) - Outil gratuit pour visualiser, éditer, filtrer des données JSON complexes dans une belle grille tabulaire. Sauvegardez et partagez vos données JSON via un lien.
* [Zerosheets](https://zerosheets.com) - Transformez vos feuilles Google Sheets en puissantes APIs pour développer rapidement prototypes, sites web, applications et plus. 500 requêtes par mois disponibles gratuitement.
* [IP.City](https://ip.city) — 100 requêtes de géolocalisation IP gratuites par jour.
* [Abstract API](https://www.abstractapi.com) — Suite d’API pour divers cas d’utilisation, dont la géolocalisation IP, la détection du genre ou la validation d’emails.
* [Apify](https://www.apify.com/) — Plateforme de scraping web et d’automatisation pour créer une API pour n’importe quel site et extraire des données. Extracteurs prêts à l’emploi, proxys intégrés, solutions personnalisées. Offre gratuite incluant 5$ de crédits chaque mois.
* [APITemplate.io](https://apitemplate.io) - Génération automatique d’images et de documents PDF via API simple ou outils d’automatisation comme Zapier & Airtable. Aucun CSS/HTML requis. Le plan gratuit inclut 50 images/mois et trois modèles.
* [APIToolkit.io](https://apitoolkit.io) - Tous les outils nécessaires pour comprendre vos APIs et backends. Validation et surveillance automatique des contrats API. Le plan gratuit couvre les serveurs jusqu’à 10 000 requêtes/jour.
* [APIVerve](https://apiverve.com) - Accès instantané à plus de 120 APIs gratuitement, conçues pour la qualité, la cohérence et la fiabilité. Plan gratuit avec jusqu’à 50 tokens API/mois. (Peut-être hors ligne, 2025-06-25)
* [Arize AI](https://arize.com/) - Observabilité pour le monitoring et la recherche de causes racines dans les modèles de machine learning, tels que qualité des données et dérive de performance. Gratuit jusqu’à deux modèles.
* [Maxim AI](https://getmaxim.ai/) - Simulez, évaluez et observez vos agents IA. Plateforme complète d’évaluation et d’observabilité, aidant les équipes à livrer plus vite (>5x). Gratuit à vie pour les développeurs indépendants et petites équipes (3 sièges).
* [Beeceptor](https://beeceptor.com) - Mockez une API REST en quelques secondes, simulez des réponses API et plus. 50 requêtes gratuites par jour, tableau de bord public, endpoints ouverts (toute personne avec le lien du dashboard peut voir soumissions et réponses).
* [BigDataCloud](https://www.bigdatacloud.com/) - Fournit des APIs rapides, précises et gratuites (illimitées ou jusqu’à 10K-50K/mois) pour le web moderne : géolocalisation IP, reverse geocoding, analyse réseau, validation email/téléphone, info client et plus.
* [Browse AI](https://www.browse.ai) — Extraction et surveillance de données sur le web. 1 000 crédits par mois gratuitement, soit 1 000 requêtes simultanées.
* [BrowserCat](https://www.browsercat.com) - API de navigateur sans interface graphique pour automatisation, scraping, accès web par agents IA, génération d’images/PDF, etc. Plan gratuit avec 1 000 requêtes/mois.
* [Calendarific](https://calendarific.com) - API de jours fériés de niveau entreprise pour plus de 200 pays. Le plan gratuit inclut 500 appels par mois.
* [Canopy](https://www.canopyapi.co/) - API GraphQL pour les données de produits, recherches et catégories sur Amazon.com. Plan gratuit avec 100 appels/mois.
* [Clarifai](https://www.clarifai.com) — API d’images pour reconnaissance et détection de visages personnalisés. Possibilité d’entraîner des modèles IA. Plan gratuit avec 1 000 appels/mois.
* [Cloudmersive](https://cloudmersive.com/) — Plateforme d’API utilitaires avec accès complet à une large bibliothèque d’APIs : conversion de documents, scan de virus, etc. 600 appels/mois, zone Amérique du Nord uniquement, taille max 2,5 Mo.
* [Colaboratory](https://colab.research.google.com) — Environnement de notebooks Python gratuit en ligne avec GPU Nvidia Tesla K80.
* [CometML](https://www.comet.com/site/) - Plateforme MLOps pour le suivi d’expériences, gestion de production, registre de modèles et traçabilité complète des données. Gratuit pour les particuliers et académiques.
* [Commerce Layer](https://commercelayer.io) - API de commerce composable pour créer, passer et gérer des commandes depuis n’importe quel front-end. Le plan développeur autorise 100 commandes/mois et jusqu’à 1 000 SKU gratuitement.
* [Composio](https://composio.dev/) - Plateforme d’intégration pour agents IA et LLMs. Intégrez plus de 200 outils à travers l’internet agentique.
* [Conversion Tools](https://conversiontools.io/) - Convertisseur de fichiers en ligne pour documents, images, vidéos, audio et eBooks. API REST disponible. Librairies pour Node.js, PHP, Python. Jusqu’à 50 Go (plans payants). Limite gratuite : 20 Mo/fichier, 30 conversions/jour, 300/mois.
* [Country-State-City Microservice API](https://country-state-city.rebuscando.info/) - API et microservice fournissant de nombreuses informations : pays, régions, provinces, villes, codes postaux, etc. 100 requêtes/jour en gratuit.
* [Coupler](https://www.coupler.io/) - Outil d’intégration de données entre applications. Création de dashboards et rapports live, transformation, manipulation de valeurs, collecte et sauvegarde d’insights. Plan gratuit limité à un utilisateur, une connexion/source/destination de données, rafraîchissement manuel requis.
* [CraftMyPDF](https://craftmypdf.com) - Génération automatique de PDF à partir de modèles réutilisables avec éditeur glisser-déposer et API simple. 100 PDF/mois et trois modèles dans le plan gratuit.
* [Crawlbase](https://crawlbase.com/) — Crawl et scraping de sites sans proxies, infrastructure ni navigateurs. Captchas résolus pour vous, anti-blocage. Les 1 000 premiers appels sont gratuits.
* [CurlHub](https://curlhub.io) — Service proxy pour inspecter et déboguer les appels API. Plan gratuit avec 10 000 requêtes/mois.
* [CurrencyScoop](https://currencyscoop.com) - API de données de devises en temps réel pour apps fintech. Plan gratuit avec 5 000 appels/mois.
* [Cube](https://cube.dev/) - Permet aux ingénieurs et développeurs d’accéder aux données des data stores modernes, de les organiser et de les délivrer à chaque application. Cube Cloud a un niveau gratuit limité à 1 000 requêtes/jour.
* [Data Dead Drop](https://datadeaddrop.com) - Partage de fichiers simple et gratuit. Les données s’auto-détruisent après accès. Téléversement et téléchargement via navigateur ou ligne de commande.
* [Data Fetcher](https://datafetcher.com) - Connecte Airtable à n’importe quelle app ou API sans code. Interface de type Postman pour lancer des requêtes API dans Airtable. Intégrations pré-construites avec des dizaines d’apps. 100 exécutions/mois dans le plan gratuit.
* [Dataimporter.io](https://www.dataimporter.io) - Outil de connexion, nettoyage et import de données dans Salesforce. Plan gratuit jusqu’à 20 000 enregistrements/mois.
* [Datalore](https://datalore.jetbrains.com) - Notebooks Python par Jetbrains. Inclut 10 Go de stockage et 120h d’exécution/mois.
* [Data Miner](https://dataminer.io/) - Extension navigateur (Chrome, Edge) pour extraire des données de pages web vers CSV ou Excel. Plan gratuit : 500 pages/mois.
* [Datapane](https://datapane.com) - API pour construire des rapports interactifs en Python et déployer scripts Python et notebooks Jupyter en outils en libre-service.
* [DB-IP](https://db-ip.com/api/free) - API de géolocalisation IP gratuite avec 1 000 requêtes par IP/jour. Base lite sous licence CC-BY 4.0 gratuite aussi.
* [DB Designer](https://www.dbdesigner.net/) — Outil cloud de conception et modélisation de schémas de bases de données. Plan gratuit de départ : 2 modèles de base et 10 tables par modèle.
* [DeepAR](https://developer.deepar.ai) — Filtres de réalité augmentée pour le visage sur toute plateforme avec un SDK unique. Plan gratuit : 10 utilisateurs actifs mensuels (MAU) et suivi de 4 visages.
* [Deepnote](https://deepnote.com) - Nouveau notebook data science. Compatible Jupyter avec collaboration temps réel et exécution cloud. Gratuite : projets personnels illimités, machines basiques illimitées (5 Go RAM, 2 vCPU), équipes jusqu’à 3 éditeurs.
* [Disease.sh](https://disease.sh/) — API gratuite fournissant des données précises pour créer des applications utiles liées au Covid-19.
* [Doczilla](https://www.doczilla.app/) — API SaaS pour générer captures d’écran ou PDF à partir de code HTML/CSS/JS. Plan gratuit : 250 documents/mois.
* [Doppio](https://doppio.sh/) — API managée pour générer et stocker en privé des PDF et captures d’écran avec technologie de rendu avancée. Plan gratuit : 400 PDF et screenshots/mois.
* [drawDB](https://drawdb.app/) — Éditeur de diagrammes de bases de données en ligne gratuit et open source sans inscription.
* [dreamfactory.com](https://dreamfactory.com/) — Backend REST API open source pour applications mobiles, web et IoT. Connectez toute base SQL/NoSQL, système de fichiers ou service externe, et obtenez instantanément une plateforme API REST complète avec documentation live et gestion utilisateurs.
* [Duply.co](https://duply.co) — Créez des images dynamiques depuis API & URL, concevez un modèle unique et réutilisez-le. Niveau gratuit : 20 crédits offerts.
* [DynamicDocs](https://advicement.io) - Génération de documents PDF avec une API JSON vers PDF basée sur des modèles LaTeX. Plan gratuit : 50 appels API/mois et accès à une bibliothèque de modèles.
* [Efemarai](https://efemarai.com) - Plateforme de test et débogage pour modèles ML et données. Visualisez tout graphe computationnel. Utilisation locale gratuite.
* [ERD Lab](https://www.erdlab.io) — Outil ERD cloud gratuit pour développeurs. Essai gratuit : 2 projets de 10 tables chacun.
* [ExtendsClass](https://extendsclass.com/rest-client-online.html) - Client HTTP web gratuit pour envoyer des requêtes HTTP.
* [Export SDK](https://exportsdk.com) - API de génération de PDF avec éditeur de modèles drag-and-drop, SDK et intégrations no-code. Gratuit : 250 pages/mois, utilisateurs illimités, trois modèles.
* [file.coffee](https://file.coffee/) - Plateforme de stockage jusqu’à 15 Mo/fichier (30 Mo/fichier avec compte).
* [Financial Data](https://financialdata.net/) - API de données boursières et financières. Gratuit : 300 requêtes/jour.
* [FormatJSONOnline.com](https://formatjsononline.com) - Outil gratuit en ligne pour formater, valider, comparer et minifier instantanément du JSON.
* [FraudLabs Pro](https://www.fraudlabspro.com) — Analysez une transaction pour fraude de paiement par carte. API REST détectant tous les risques de fraude sur base des paramètres de commande. Micro plan gratuit : 500 transactions/mois.
* [GeoDataSource](https://www.geodatasource.com) — Service de recherche de lieu par nom de ville à partir de coordonnées GPS. API gratuite : 500 requêtes/mois.
* [Geolocated.io](https://geolocated.io) — API de géolocalisation IP multi-continents. Gratuit : 2 000 requêtes/jour.
* [Glitterly](https://glitterly.app/) - Génération programmatique d’images dynamiques à partir de modèles. API RESTful et intégrations nocode. Gratuit : 50 images/mois, cinq modèles.
* [Hex](https://hex.tech/) - Plateforme collaborative de données pour notebooks, apps data et bibliothèques de connaissances. Communauté gratuite : jusqu’à cinq projets.
* [Hook0](https://www.hook0.com/) - Webhooks-as-a-service open source pour faciliter l’intégration de webhooks. Jusqu’à 100 événements/jour et 7 jours d’historique gratuits.
* [Hoppscotch](https://hoppscotch.io) - Constructeur gratuit, rapide et esthétique de requêtes API.
* [huggingface.co](https://huggingface.co) - Construisez, entraînez et déployez des modèles NLP pour Pytorch, TensorFlow, JAX. Gratuit jusqu’à 30k caractères/mois.
* [Hybiscus](https://hybiscus.dev/) - Créez des rapports PDF via une API déclarative simple. Gratuit 14 jours : 50 rapports une page, personnalisation palettes et polices.
* [Invantive Cloud](https://cloud.invantive.com/) — Accès à plus de 70 plateformes (cloud) telles que Exact Online, Twinfield, ActiveCampaign, Visma via Invantive SQL ou OData4 (Power BI, Power Query). Inclut réplication et échange de données. Plan gratuit pour développeurs et consultants. Gratuit pour plateformes spécifiques (limite volumes de données).
* [ipaddress.sh](https://ipaddress.sh) — Service simple pour obtenir une adresse IP publique dans différents [formats](https://about.ipaddress.sh/).
* [ip-api](https://ip-api.com) — API de géolocalisation IP, gratuite pour usage non commercial, pas de clé API requise, 45 req/minute/IP sur le plan gratuit.
* [ipbase.com](https://ipbase.com) - API de géolocalisation IP - Plan gratuit à vie jusqu’à 150 requêtes/mois.
* [IP Geolocation](https://ipgeolocation.io/) — API de géolocalisation IP - Plan gratuit à vie pour développeurs avec limite de 1 000 requêtes/jour.
* [IP Geolocation API](https://www.abstractapi.com/ip-geolocation-api) — API de géolocalisation IP par Abstract - 1 000 requêtes gratuites.
* [IPLocate](https://www.iplocate.io) — API de géolocalisation IP, gratuit jusqu’à 1 000 requêtes/jour. Détection de proxy/VPN/hébergement, données ASN, IP vers entreprise, plus. Bases IP vers pays et ASN téléchargeables gratuitement en CSV ou MMDB.
* [IP2Location](https://www.ip2location.com) — Service de géolocalisation IP freemium. Base LITE gratuite à télécharger. Importez la base sur votre serveur pour interrogation locale : ville, coordonnées, FAI, etc.
* [IP2Location.io](https://www.ip2location.io/) — API de géolocalisation IP freemium, rapide et fiable. Données : ville, coordonnées, FAI, etc. Plan gratuit : 50k crédits/mois. Aussi 500 recherches WHOIS et domaines hébergés gratuits/mois. Détails d’enregistrement de domaine, recherche d’hébergeur d’un domaine. Plus de fonctionnalités avec un plan payant.
* [ipapi](https://ipapi.co/) - API de localisation d’adresse IP par Kloudend, Inc - API fiable sur AWS, utilisée par les Fortune 500. Niveau gratuit : 30k recherches/mois (1k/jour) sans inscription.
* [ipapi.is](https://ipapi.is/) - API fiable d’adresse IP par et pour développeurs, avec meilleure détection d’hébergement existante. Plan gratuit : 1 000 recherches sans inscription.
* [IPinfo](https://ipinfo.io/) — API rapide et précise (jusqu’à 50k/mois) d’adresse IP. Détails : géolocalisation, entreprises, opérateurs, plages IP, domaines, contacts abus, etc. Toutes les APIs payantes testables gratuitement.
* [IPQuery](https://ipquery.io) — API IP illimitée pour développeurs, sans limite de taux ni tarification.
* [IPTrace](https://iptrace.io) — API simple pour fournir à votre entreprise des données IP fiables et utiles, avec 50 000 recherches gratuites par mois.
* [JSON2Video](https://json2video.com) - API de montage vidéo pour automatiser marketing vidéo et vidéos réseaux sociaux, en code ou sans code.
* [JSON IP](https://getjsonip.com) — Retourne l’adresse IP publique du client. Pas d’inscription requise pour le niveau gratuit. Grâce au CORS, données requêtables directement en JS depuis le navigateur. Utile pour surveiller les changements d’IP client/serveur. Requêtes illimitées.
* [JSON Serve](https://jsonserve.com/) — Service gratuit pour stocker des objets JSON et les utiliser comme API REST dans votre app.
* [JSONing](https://jsoning.com/api/) — Créez une fausse API REST à partir d’un objet JSON, personnalisez statuts HTTP, headers et réponses.
* [konghq.com](https://konghq.com/) — Marketplace d’API et outils puissants d’API publics/privés. Niveau gratuit : certaines fonctions (monitoring, alertes, support) limitées.
* [Kreya](https://kreya.app) — Client GUI gRPC gratuit pour appeler et tester des APIs gRPC. Import des APIs via reflection serveur.
* [Lightly](https://www.lightly.ai/) — Améliorez vos modèles ML en utilisant les bonnes données. Jeux de données jusqu’à 1 000 échantillons gratuits.
* [LoginLlama](https://loginllama.app) - API de sécurité de connexion pour détecter logins frauduleux et suspects et notifier vos clients. Gratuit pour 1 000 connexions/mois.
* [MailboxValidator](https://www.mailboxvalidator.com) — Service de vérification d’emails par connexion réelle au serveur. Plan API gratuit : 100 vérifications/mois.
* [Market Data API](https://www.marketdata.app) - Données financières temps réel et historiques pour actions, options, fonds, etc. Niveau API Free Forever : 100 requêtes API/jour gratuitement.
  * [Meteosource Weather API](https://www.meteosource.com/) — API météo mondial pour les données météo actuelles et prévisionnelles. Les prévisions sont basées sur une combinaison de plusieurs modèles météorologiques par apprentissage automatique pour une meilleure précision. Le plan gratuit comprend 400 appels par jour.
  * [microlink.io](https://microlink.io/) – Transforme n'importe quel site web en données telles que la normalisation de métadonnées, des aperçus de liens enrichis, des capacités de scraping ou des captures d'écran en tant que service. 50 requêtes par jour, gratuit tous les jours.
  * [Mindee](https://developers.mindee.com) – Mindee est un puissant logiciel OCR et une plateforme API-first qui aide les développeurs à automatiser les flux de travail applicatifs en standardisant la couche de traitement documentaire grâce à la reconnaissance de données pour les informations clés, utilisant la vision par ordinateur et le machine learning. Le niveau gratuit offre 500 pages par mois.
  * [Mintlify](https://mintlify.com) — Standard moderne pour la documentation d’API. Composants UI beaux et faciles à maintenir, recherche intégrée et playground interactif. Gratuit pour 1 éditeur.
  * [MockAPI](https://www.mockapi.io/) — MockAPI est un outil simple qui vous permet de simuler rapidement des APIs, générer des données personnalisées, et effectuer des opérations via une interface RESTful. MockAPI est conçu comme un outil de prototypage/test/apprentissage. Un projet/2 ressources par projet gratuitement.
  * [Mockfly](https://www.mockfly.dev/) — Mockfly est un outil de développement fiable pour la simulation d’API et la gestion de feature flag. Générez et contrôlez rapidement des APIs simulées avec une interface intuitive. Le niveau gratuit propose 500 requêtes par jour.
  * [Mocki](https://mocki.io) - Un outil qui vous permet de créer des APIs GraphQL et REST simulées synchronisées avec un dépôt GitHub. Les APIs REST simples sont gratuites à développer et utiliser sans inscription.
  * [Mocko.dev](https://mocko.dev/) — Proxyfiez votre API, choisissez les endpoints à simuler dans le cloud et inspectez le trafic, gratuitement. Accélérez votre développement et vos tests d'intégration.
  * [Mocky](https://designer.mocky.io/) - Une application web simple pour générer des réponses HTTP personnalisées afin de simuler des requêtes HTTP. Également disponible en [open source](https://github.com/julien-lafont/Mocky).
  * [Mock N Roll](https://mpcknroll.me/) - Service API de mocks gratuits — un outil puissant pour simuler des réponses API réelles sans délais backend. Parfait pour les devs frontend, testeurs QA et équipes DevOps. [repo](https://github.com/haerulmuttaqin/mocknroll-web).
  * [microenv.com](https://microenv.com) —  Créez une fausse API REST pour les développeurs avec possibilité de générer du code et une application dans un conteneur docker.
  * [Multi-Exit IP Address Checker](https://ip.alstra.ca/) —  Un outil gratuit et simple pour vérifier votre adresse IP de sortie sur plusieurs nœuds et comprendre comment votre IP apparaît dans différentes régions et services mondiaux. Utile pour tester des outils de répartition DNS basés sur des règles comme Control D.
  * [Namekit](https://namekit.app/) - Découverte de domaines alimentée par l’IA – trouvez instantanément des noms disponibles à prix standard. Requêtes gratuites chaque jour.
  * [News API](https://newsapi.org) — Recherchez des actualités sur le web par code, et obtenez des résultats JSON. Les développeurs bénéficient de 100 requêtes gratuites par jour. Les articles ont un retard de 24 heures.
  * [numlookupapi.com](https://numlookupapi.com) - API gratuite de validation de numéros de téléphone - 100 requêtes gratuites/mois.
  * [OCR.Space](https://ocr.space/) — Une API OCR qui analyse les fichiers image et pdf et retourne les résultats texte au format JSON. 25 000 requêtes gratuites par mois et une taille de fichier maximale de 1 Mo.
  * [OpenAPI3 Designer](https://openapidesigner.com/) — Créez visuellement gratuitement des définitions Open API 3.
  * [parsehub.com](https://parsehub.com/) — Extrayez des données de sites dynamiques, transformez des sites web dynamiques en APIs, cinq projets gratuits.
  * [Parseur](https://parseur.com) — 20 pages gratuites/mois : Extraction de données depuis des PDFs, emails. Alimenté par l’IA. Accès API complet.
  * [PDFBolt](https://pdfbolt.com) - API de génération de PDF axée développeurs, conçue avec la confidentialité à l'esprit. Documentation inspirée de Stripe et inclut 500 conversions PDF gratuites par mois.
  * [pdfEndpoint.com](https://pdfendpoint.com) - Convertissez facilement du HTML ou des URLs en PDF via une API simple. Cent conversions par mois gratuites.
  * [PDF-API.io](https://pdf-api.io) - API d’automatisation PDF, éditeur visuel de modèles ou conversion HTML en PDF, intégration de données dynamiques, et rendu PDF via API. Le plan gratuit comprend un modèle, 100 PDF/mois.
  * [Pixela](https://pixe.la/) - Service gratuit de base de données daystream. Toutes les opérations se font par API. Visualisation possible avec cartes thermiques et graphiques linéaires.
  * [Postman](https://postman.com) — Simplifiez les workflows et créez de meilleures APIs – plus rapidement – avec Postman, une plateforme de collaboration pour le développement d’API. Utilisez l’application Postman gratuitement pour toujours. Les fonctionnalités cloud de Postman sont également gratuites à certaines limites.
  * [Insomnia](https://insomnia.rest) - Client API open source pour la conception et le test d’APIs, prend en charge REST et GraphQL.
  * [PrefectCloud](https://www.prefect.io/cloud/) — Plateforme complète d’automatisation des flux de données. Le plan gratuit inclut 5 workflows déployés et 500 minutes de calcul serverless par mois.
  * [Preset Cloud](https://preset.io/) - Service hébergé Apache Superset. Gratuit pour toujours pour les équipes jusqu'à 5 utilisateurs, avec tableaux de bord et graphiques illimités, générateur de graphiques sans code et éditeur SQL collaboratif.
  * [PromptLoop](https://www.promptloop.com/) - PromptLoop offre un scraping web IA 10X plus simple avec un temps d’adoption quasi nul, 85%+ de temps gagné sur les workflows existants, et fonctionne 4X plus vite que la recherche manuelle, sans compromis, avec un endpoint API REST pour toutes les tâches de recherche. Les 1 000 premiers crédits sont gratuits chaque mois.
  * [Public-Apis Github Repo](https://github.com/public-apis/public-apis) — Liste d’APIs publiques gratuites.
  * [Rapidapi](https://rapidapi.com/) - Plus grand hub d’API au monde. Des millions de développeurs trouvent et connectent des milliers d’APIs, développement d’API via des challenges ludiques (avec solutions !) et exemples interactifs.
  * [RequestBin.com](https://requestbin.com) — Créez un endpoint gratuit pour envoyer des requêtes HTTP. Toutes les requêtes HTTP envoyées à cet endpoint seront enregistrées avec leur payload et headers pour observer les recommandations de webhooks et autres services.
  * [reqres.in](https://reqres.in) - Une API REST hébergée gratuitement, prête à répondre à vos requêtes AJAX.
  * [Roboflow](https://roboflow.com) - Créez et déployez un modèle de vision par ordinateur personnalisé sans expérience préalable en machine learning requise. Le niveau gratuit inclut 30 crédits par mois.
  * [ROBOHASH](https://robohash.org/) - Service web pour générer des images uniques et originales à partir de n’importe quel texte.
  * [Scraper's Proxy](https://scrapersproxy.com) — API proxy HTTP simple pour le scraping. Scrapez anonymement sans restrictions, blocages ou captchas. Les 100 premiers scrapings réussis par mois sont gratuits, rendu javascript inclus (plus si vous contactez le support).
  * [ScrapingAnt](https://scrapingant.com/) — API de scraping Headless Chrome et service de proxies vérifiés gratuits. Rendu Javascript, proxies rotatifs premium, évitement des CAPTCHAs. 10 000 crédits API gratuits.
  * [Simplescraper](https://simplescraper.io) — Déclenchez votre webhook après chaque opération. Le plan gratuit comprend 100 crédits de scraping cloud.
  * [Select Star](https://www.selectstar.com/) - Plateforme intelligente de découverte de données qui analyse et documente automatiquement vos données. Version gratuite limitée avec 2 sources de données, jusqu’à 1 000 tables et 25 utilisateurs.
  * [Sheetson](https://sheetson.com) - Transformez instantanément n’importe quel Google Sheets en API RESTful. Plan gratuit disponible, incluant 1 000 lignes gratuites par feuille.
  * [Shipyard](https://www.shipyardapp.com) — Plateforme d'orchestration de données low-code pour le cloud. Construisez avec des templates low-code ou votre propre code (Python, Node.js, Bash, SQL). Notre plan développeur gratuit offre 10 heures d'exécution par mois pour un utilisateur — suffisant pour automatiser plusieurs workflows.
  * [Siterelic](https://siterelic.com/) - L’API Siterelic permet de prendre des captures d’écran, auditer des sites web, scanner TLS, lookup DNS, tester TTFB, et plus encore. Le plan gratuit offre 100 requêtes API/mois.
  * [SerpApi](https://serpapi.com/) - API de scraping en temps réel de moteurs de recherche. Retourne des résultats JSON structurés pour Google, YouTube, Bing, Baidu, Walmart, et bien d’autres. Le plan gratuit inclut 100 appels API réussis/mois.
  * [SmartParse](https://smartparse.io) - SmartParse est une plateforme de migration de données et de CSV vers API offrant des outils économiques et efficaces pour développeurs. Le niveau gratuit inclut 300 unités de traitement/mois, uploads par navigateur, quarantaine des données, circuit breakers et alertes de jobs.
  * [Sofodata](https://www.sofodata.com/) - Créez des APIs RESTful sécurisées à partir de fichiers CSV. Téléchargez un fichier CSV et accédez instantanément aux données via son API, permettant un développement applicatif plus rapide. Le plan gratuit inclut 2 APIs et 2 500 appels API/mois. Pas besoin de carte bancaire.
  * [Sqlable](https://sqlable.com/) - Une collection d’outils SQL en ligne gratuits, incluant un formateur et validateur SQL, un testeur SQL regex, un générateur de fausses données, et des playgrounds de bases de données interactifs.
  * [Stoplight](https://stoplight.io/) - SaaS pour la conception et la documentation collaborative d’APIs. Le plan gratuit offre des outils de design, simulation et documentation gratuits.
  * [Supportivekoala](https://supportivekoala.com/) — Permet de générer automatiquement des images selon vos entrées via des templates. Le plan gratuit permet de créer jusqu’à 50 images par mois.
  * [Svix](https://www.svix.com/) - Webhooks en tant que service. Envoyez jusqu’à 50 000 messages/mois gratuitement.
  * [Tavily AI](https://tavily.com/) - API pour la recherche en ligne et l’obtention rapide d’insights et de recherches complètes, avec capacité d’organisation des résultats. 1 000 requêtes/mois sur le niveau gratuit, aucune carte bancaire requise.
  * [The IP API](https://theipapi.com/) - API de géolocalisation IP avec 1 000 requêtes gratuites/jour. Fournit des informations sur la localisation d’une adresse IP, y compris pays, ville, région, etc.
  * [TinyMCE](https://www.tiny.cloud) - API d’édition de texte riche. Les fonctionnalités de base sont gratuites pour une utilisation illimitée.
  * [Tomorrow.io Weather API](https://www.tomorrow.io/weather-api/) - Propose un plan gratuit d’API météo. Fournit des prévisions météo précises et à jour avec couverture mondiale, données historiques et solutions de monitoring météo.
  * [Treblle](https://www.treblle.com) - Treblle aide les équipes à construire, livrer et gouverner les APIs. Agrégation avancée des logs API, observabilité, documentation et débogage. Toutes les fonctionnalités sont gratuites, mais la limite est de 250 000 requêtes/mois sur le niveau gratuit.
  * [UniRateAPI](https://unirateapi.com) – Taux de change en temps réel pour plus de 590 devises et crypto. Appels API illimités sur le plan gratuit, idéal pour développeurs et applications financières.
  * [vatcheckapi.com](https://vatcheckapi.com) - API simple et gratuite de validation de numéro de TVA. 150 validations gratuites par mois.
  * [WeatherXu](https://weatherxu.com/) — Données météo mondiales incluant conditions actuelles, prévisions horaires et journalières, alertes météo via notre API. Intégration de modèles IA et systèmes ML pour analyser et combiner plusieurs modèles météo afin d’offrir une meilleure précision de prévisions. Le niveau gratuit inclut 10 000 appels API/mois.
  * [Webhook Store](https://www.openwebhook.io) - Outil pour stocker des webhooks tiers et les déboguer en local (style ngrok). Open source et auto-hébergeable. Domaine personnel gratuit *username*.github.webhook.store, domaines publics gratuits *anything*.webhook.store.
  * [WebScraping.AI](https://webscraping.ai) - API de scraping web simple avec parsing intégré, rendu Chrome et proxies. Deux mille appels API gratuits par mois.
  * [Weights & Biases](https://wandb.ai) — Plateforme MLOps orientée développeur. Construisez de meilleurs modèles plus rapidement avec suivi d’expériences, versionnage de datasets et gestion de modèles. Gratuit pour projets personnels seulement, avec 100 Go de stockage inclus.
  * [What The Diff](https://whatthediff.ai) - Assistant de revue de code alimenté par IA. Le plan gratuit est limité à 25 000 tokens mensuels (~10 PRs).
  * [wolfram.com](https://wolfram.com/language/) — Algorithmes embarqués fondés sur la connaissance, dans le cloud.
  * [wrapapi.com](https://wrapapi.com/) — Transformez n’importe quel site web en API paramétrable. 30 000 appels API par mois.
  * [Zenscrape](https://zenscrape.com/web-scraping-api) — API de scraping web avec navigateurs headless, IP résidentielles et tarification simple. Mille appels API gratuits/mois et crédits supplémentaires pour étudiants et associations.
  * [Zipcodebase](https://zipcodebase.com) - API gratuite de codes postaux, accès aux données postales mondiales. 5 000 requêtes gratuites/mois.
  * [Zipcodestack](https://zipcodestack.com) - API gratuite de codes postaux et validation postale. Dix mille requêtes gratuites/mois.
  * [Zuplo](https://zuplo.com/) - Plateforme gratuite de gestion d’API pour concevoir, construire et déployer des APIs à la Edge. Ajoutez l’authentification par clé API, la limitation de débit, la documentation développeur et la monétisation à toute API en quelques minutes. Compatible OpenAPI et totalement programmable avec les APIs standard web & Typescript. Le plan gratuit offre jusqu’à 10 projets, environnements de production edge illimités, 1M de requêtes mensuelles et 10Go de sortie.

**[⬆️ Retour en haut](#table-of-contents)**

## Dépôts d'Artéfacts

  * [Artifactory](https://jfrog.com/start-free/) - Un dépôt d’artéfacts qui prend en charge de nombreux formats de paquets comme Maven, Docker, Cargo, Helm, PyPI, CocoaPods, et GitLFS. Inclut l’outil de scan de paquets XRay et l’outil CI/CD Pipelines (anciennement Shippable) avec un niveau gratuit de 2 000 minutes CI/CD par mois.
  * [central.sonatype.org](https://central.sonatype.org) — Le dépôt d’artéfacts par défaut pour Apache Maven, SBT, et autres systèmes de build.
  * [cloudrepo.io](https://cloudrepo.io) - Dépôts Maven et PyPi cloud, privés et publics. Gratuit pour les projets open source.
  * [cloudsmith.io](https://cloudsmith.io) — Service de dépôt simple, sécurisé et centralisé pour Java/Maven, RedHat, Debian, Python, Ruby, Vagrant, et plus. Niveau gratuit + gratuit pour open source.
  * [jitpack.io](https://jitpack.io/) — Dépôt Maven pour projets JVM et Android sur GitHub, gratuit pour les projets publics.
  * [packagecloud.io](https://packagecloud.io/users/new?plan=free_usage_plan) — Hébergement de dépôts facile pour paquets Maven, RPM, DEB, PyPi, NPM, et RubyGem (a un niveau gratuit).
  * [repsy.io](https://repsy.io) — 1 Go gratuit de dépôt Maven privé/public.
  * [Gemfury](https://gemfury.com) — Dépôts d’artéfacts privés et publics pour Maven, PyPi, NPM, Go Module, Nuget, APT et RPM. Gratuit pour les projets publics.
  * [paperspace](https://www.paperspace.com/) — Construisez et déployez des modèles IA, développez, entraînez et déployez des applications IA, plan gratuit : projets publics, 5 Go de stockage, instances basiques.
  * [RepoForge](https://repoforge.io) - Dépôt cloud privé hébergé pour paquets Python, Debian, NPM et registres Docker. Plan gratuit pour les projets open source/publics.
  * [RepoFlow](https://repoflow.io) - RepoFlow simplifie la gestion des paquets avec support de npm, PyPI, Docker, Go, Helm et plus. Essayez-le gratuitement avec 10 Go de stockage, 10 Go de bande passante, 100 paquets et utilisateurs illimités dans le cloud, ou auto-hébergé pour usage personnel seulement.

**[⬆️ Retour en haut](#table-of-contents)**

## Outils pour équipes et collaboration
  * [3Cols](https://3cols.com/) - Gestionnaire de snippets de code cloud gratuit pour usage personnel et collaboratif.
  * [Bitwarden](https://bitwarden.com) — Le moyen le plus simple et le plus sûr pour les particuliers, équipes et entreprises de stocker, partager et synchroniser des données sensibles.
  * [Braid](https://www.braidchat.com/) — Application de chat conçue pour les équipes. Gratuit pour les groupes publics, utilisateurs illimités, historique et intégrations. Version open source auto-hébergeable disponible.
  * [cally.com](https://cally.com/) — Trouvez le moment idéal pour une réunion. Simple à utiliser, idéal pour petits et grands groupes.
  * [Calendly](https://calendly.com) — Calendly est l’outil pour connecter et planifier des réunions. Le plan gratuit offre 1 connexion de calendrier par utilisateur et des sessions illimitées. Applications bureau et mobile également proposées.
  * [Discord](https://discord.com/) — Chat avec salons publics/privés. Texte Markdown, voix, vidéo et partage d’écran. Gratuit pour utilisateurs illimités.
  * [Fibo](https://fibo.dev) - Outil de scrum poker en ligne gratuit et en temps réel pour équipes agiles, permettant à un nombre illimité de membres d’estimer les points d’histoire pour une planification plus rapide.
  * [Telegram](https://telegram.org/) — Telegram est pour tous ceux qui veulent des messages et appels rapides et fiables. Les utilisateurs professionnels et petites équipes apprécieront les grands groupes, pseudos, applications bureau et le partage de fichiers performant.
  * [DevToolLab](https://devtoollab.com) — Outils en ligne pour développeurs offrant un accès gratuit à tous les outils de base, avec possibilité d’enregistrer automatiquement une entrée par outil, vitesse de traitement standard, et support communautaire.
  * [Dubble](https://dubble.so/) — Créateur gratuit de guides pas-à-pas. Prenez des captures d’écran, documentez des processus et collaborez avec votre équipe. Prend aussi en charge l’enregistrement d’écran asynchrone.
  * [Duckly](https://duckly.com/) — Discutez et collaborez en temps réel avec votre équipe. Programmation en binôme avec partage d’IDE, terminal, voix, vidéo et écran. Gratuit pour petites équipes.
  * [Dyte](https://dyte.io) - SDK de vidéo & audio live le plus convivial pour les développeurs, avec plugins collaboratifs pour améliorer la productivité et l’engagement. Le niveau gratuit inclut 10 000 minutes mensuelles d’utilisation vidéo/audio live.
  * [evernote.com](https://evernote.com/) — Outil pour organiser l’information. Partagez vos notes et travaillez ensemble.
  * [Fibery](https://fibery.io/) — Plateforme d’espace de travail connecté. Gratuit pour utilisateur seul, jusqu’à 2 Go d’espace disque.
  * [flock.com](https://flock.com) — Un moyen plus rapide pour votre équipe de communiquer. Messages, canaux, utilisateurs, applications et intégrations illimités gratuitement.
  * [Gather](https://www.gather.town/) - Une meilleure façon de se réunir en ligne. Axé sur des espaces entièrement personnalisables, Gather rend le temps passé avec vos communautés aussi simple que dans la vie réelle. Gratuit jusqu'à 10 utilisateurs simultanés.
  * [gokanban.io](https://gokanban.io) - Tableau Kanban basé sur la syntaxe, sans inscription, pour une utilisation rapide. Gratuit sans aucune limitation.
  * [flat.social](https://flat.social) - Espaces interactifs et personnalisables pour réunions d'équipe et événements sociaux. Réunions illimitées, gratuit jusqu'à 8 utilisateurs simultanés.
  * [GitDailies](https://gitdailies.com) - Rapports quotidiens de l'activité Commit et Pull Request de votre équipe sur GitHub. Comprend un visualisateur de Push, un système de reconnaissance des pairs et un générateur d'alertes personnalisées. Le niveau gratuit offre des utilisateurs illimités, trois dépôts et 3 configurations d'alertes.
  * [gitter.im](https://gitter.im/) — Chat, pour GitHub. Salles publiques et privées illimitées, gratuit pour les équipes jusqu'à 25 personnes.
  * [Hackmd.io](https://hackmd.io/) - Outil de collaboration et d'écriture en temps réel pour les documents/fichiers au format markdown. Comme Google Docs mais pour les fichiers markdown. Nombre illimité de "notes" gratuit, mais le nombre de collaborateurs (invités) pour les notes privées & modèles [sera limité](https://hackmd.io/pricing).
  * [hangouts.google.com](https://hangouts.google.com/) — Un seul endroit pour toutes vos conversations, gratuitement, nécessite un compte Google.
  * [HeySpace](https://hey.space) - Outil de gestion des tâches avec chat, calendrier, timeline et appels vidéo. Gratuit jusqu'à 5 utilisateurs.
  * [helplightning.com](https://www.helplightning.com/) — Assistance vidéo avec réalité augmentée. Gratuit sans analyses, chiffrement, ni support.
  * [ideascale.com](https://ideascale.com/) — Permet aux clients de soumettre des idées et de voter, gratuit pour 25 membres dans 1 communauté.
  * [Igloo](https://www.igloosoftware.com/) — Portail interne pour partager des documents, blogs, calendriers, etc. Gratuit jusqu'à 10 utilisateurs.
  * [Keybase](https://keybase.io/) — Keybase est une alternative FOSS à Slack ; il protège les discussions et fichiers de tous, des familles aux entreprises.
  * [Google Meet](https://meet.google.com/) — Utilisez Google Meet pour les besoins de réunions vidéo en ligne de votre entreprise. Meet propose des réunions en ligne sécurisées et faciles à rejoindre.
  * [/meet for Slack](https://meetslack.com) - Lancez des réunions Google directement depuis Slack en utilisant /meet dans n'importe quel canal, groupe ou DM. Gratuit sans aucune limitation.
  * [Livecycle](https://www.livecycle.io/) — Plateforme de collaboration inclusive qui rend les workflows fluides pour les équipes produit transverses et les projets open source.
  * [Lockitbot](https://www.lockitbot.com/) — Réservez et verrouillez des ressources partagées dans Slack comme des salles, environnements de développement, serveurs, etc. Gratuit jusqu'à 2 ressources.
  * [MarkUp](https://www.markup.io/) — MarkUp vous permet de collecter des retours directement sur vos sites web, PDFs et images.
  * [Proton Pass](https://proton.me/pass) — Gestionnaire de mots de passe avec alias mail intégrés, authentification 2FA, partage et passkeys. Disponible sur web, extension navigateur, application mobile et bureau.
  * [Visual Debug](https://visualdebug.com) - Outil de retour visuel pour une meilleure communication client-développeur.
  * [meet.jit.si](https://meet.jit.si/) — Conversations vidéo et partage d'écran en un clic, gratuitement.
  * [Microsoft Teams](https://products.office.com/microsoft-teams/free) — Microsoft Teams est un hub numérique basé sur le chat qui regroupe conversations, contenus et applications en un seul endroit. Gratuit jusqu'à 500 000 utilisateurs.
  * [Miro](https://miro.com/) - Tableau blanc collaboratif évolutif, sécurisé, multi-appareils et prêt pour l'entreprise. Offre freemium.
  * [nootiz](https://www.nootiz.com/) - L'outil incontournable pour collecter et gérer les retours visuels sur n'importe quel site web.
  * [Notion](https://www.notion.so/) - Notion est une application de prise de notes et de collaboration avec support du markdown, intégrant tâches, wikis et bases de données. L'application est présentée comme un espace de travail tout-en-un pour la prise de notes, la gestion de projets et des tâches. En plus des applications multiplateformes, elle est accessible via la plupart des navigateurs web.
  * [Nuclino](https://www.nuclino.com) - Wiki léger et collaboratif pour la connaissance, les documents et notes de votre équipe. Plan gratuit avec toutes les fonctionnalités essentielles, jusqu'à 50 éléments et 5 Go de stockage.
  * [OnlineInterview.io](https://onlineinterview.io/) - Plateforme gratuite d'entretien de code avec chat vidéo intégré, tableau de dessin et éditeur de code en ligne permettant de compiler et d'exécuter votre code dans le navigateur. Créez une salle d'entretien à distance en un clic.
  * [Quidlo Timesheets](https://www.quidlo.com/timesheets) - Application simple de feuille de temps et de suivi du temps pour les équipes. Le plan gratuit inclut le suivi du temps et la génération de rapports pour jusqu'à 10 utilisateurs.
  * [PageShare.dev](https://www.pageshare.dev) - Ajoute des capacités de revue visuelle dans les Pull Requests GitHub sans besoin de déployer les sites web. Gratuit jusqu'à 10 pages par mois et 100 Mo de stockage au total.
  * [Pendulums](https://pendulums.io/) - Pendulums est un outil gratuit de suivi du temps qui vous aide à mieux gérer votre temps avec une interface facile à utiliser et des statistiques pertinentes.
  * [Pumble](https://pumble.com) - Application de chat d'équipe gratuite. Utilisateurs et historique des messages illimités, gratuit à vie.
  * [Raindrop.io](https://raindrop.io) - Application de gestion de favoris privée et sécurisée pour macOS, Windows, Android, iOS et Web. Favoris et collaboration illimités gratuitement.
  * [element.io](https://element.io/) — Outil de communication décentralisé et open-source basé sur Matrix. Chats de groupe, messages directs, transferts de fichiers chiffrés, appels vocaux et vidéo, et intégration facile avec d'autres services.
  * [Rocket.Chat](https://rocket.chat/) - Plateforme de communication open source avec fonctionnalités omnicanal, fédération Matrix, ponts avec d'autres applications, messagerie illimitée et historique complet.
  * [seafile.com](https://www.seafile.com/) — Stockage privé ou cloud, partage de fichiers, synchronisation, discussions. La version cloud inclut seulement 1 Go.
  * [Sema](https://www.semasoftware.com/) - Outil gratuit de portfolio pour développeurs capable de consolider et d'agréger les contributions de plusieurs dépôts en un seul rapport.
  * [Screen Sharing via Browser](https://screensharing.net) - Outil de partage d'écran gratuit, partagez votre écran avec des collaborateurs directement depuis votre navigateur, sans téléchargement ni inscription. Gratuit.
  * [Slab](https://slab.com/) — Service moderne de gestion des connaissances pour équipes. Gratuit jusqu'à 10 utilisateurs.
  * [slack.com](https://slack.com/) — Gratuit pour un nombre illimité d'utilisateurs avec certaines limitations de fonctionnalités.
  * [Spectrum](https://spectrum.chat/) - Créez des communautés publiques ou privées gratuitement.
  * [StatusPile](https://www.statuspile.com/) - Une page de statut des pages de statut. Vous permet de suivre les pages de statut de vos fournisseurs en amont ?
  * [Stickies](https://stickies.app/) - Application de collaboration visuelle pour le brainstorming, la curation de contenu et les notes. Gratuit jusqu'à 3 murs, utilisateurs illimités et 1 Go de stockage.
  * [Stacks](https://betterstacks.com/) - Espace de travail pour le contenu avec notes intégrées, liens et stockage de fichiers pour naviguer dans la surcharge d'informations. Plan personnel gratuit à vie.
  * [talky.io](https://talky.io/) — Chat vidéo de groupe gratuit. Anonyme. Pair-à-pair. Aucun plugin, inscription ou paiement requis.
  * [Teamhood](https://teamhood.com/) - Logiciel gratuit de gestion de projets, tâches et suivi de tickets. Prend en charge le Kanban avec swimlanes et une implémentation complète de Scrum. Suivi du temps intégré. Gratuit pour cinq utilisateurs et trois portefeuilles de projets.
  * [Teamplify](https://teamplify.com) - Améliorez les processus de développement d'équipe avec l'Analytics d'équipe et le Smart Daily Standup. Comprend une gestion des congés complète pour les équipes remote-first. Gratuit pour les petits groupes jusqu'à 5 utilisateurs.
  * [Tefter](https://tefter.io) - Application de favoris avec intégration puissante à Slack. Gratuit pour les équipes open source.
  * [TeleType](https://teletype.oorja.io/) — Partagez terminaux, voix, code, tableau blanc et plus. Pas de connexion requise pour une collaboration chiffrée de bout en bout pour les développeurs.
  * [TimeCamp](https://www.timecamp.com/) - Logiciel gratuit de suivi du temps pour utilisateurs illimités. S'intègre facilement avec des outils de gestion de projet comme Jira, Trello, Asana, etc.
  * [Huly](https://huly.io/) - Plateforme de gestion de projet tout-en-un (alternative à Linear, Jira, Slack, Notion, Motion) - utilisateurs illimités, 10 Go de stockage par espace de travail, 10 Go de trafic vidéo(audio).
  * [Teamcamp](https://www.teamcamp.app) - Application de gestion de projet tout-en-un pour entreprises de développement logiciel.
  * [twist.com](https://twist.com) — Application de communication d'équipe adaptée à l'asynchrone où les conversations restent organisées et sur le sujet. Plans gratuit et illimité disponibles. Réductions pour les équipes éligibles.
  * [tldraw.com](https://tldraw.com) — Outil open-source gratuit de tableau blanc et de schématisation avec flèches intelligentes, alignement, post-its et exportation SVG. Mode multijoueur pour l'édition collaborative. Extension officielle gratuite pour VS Code également disponible.
  * [BookmarkOS.com](https://bookmarkos.com) - Gestionnaire de favoris, gestionnaire d'onglets et gestionnaire de tâches tout-en-un gratuit dans un bureau en ligne personnalisable avec collaboration sur dossiers.
  * [typetalk.com](https://www.typetalk.com/) — Partagez et discutez des idées avec votre équipe via la messagerie instantanée sur le web ou mobile.
  * [Tugboat](https://tugboat.qa) - Prévisualisez chaque pull request, de façon automatisée et à la demande. Gratuit pour tous, niveau Nano offert pour les associations à but non lucratif.
  * [whereby.com](https://whereby.com/) — Conversations vidéo en un clic, gratuitement (anciennement appear.in).
  * [windmill.dev](https://windmill.dev/) - Plateforme open source pour développeurs permettant de créer rapidement des automatisations et applications internes de niveau production à partir de scripts Python et Typescript minimalistes. En tant qu'utilisateur gratuit, vous pouvez créer et être membre d'au plus trois espaces de travail non premium.
  * [vadoo.tv](https://vadoo.tv/) — Hébergement et marketing vidéo simplifiés. Téléchargez des vidéos en un clic. Enregistrez, gérez, partagez, etc. Le plan gratuit permet jusqu'à 10 vidéos, 1 Go de stockage et 10 Go de bande passante/mois.
  * [userforge.com](https://userforge.com/) - Personas en ligne interconnectées, récits utilisateurs et cartographie du contexte. Aide à garder la conception et le développement synchronisés, gratuit jusqu'à 3 personas et deux collaborateurs.
  * [wistia.com](https://wistia.com/) — Hébergement vidéo avec analyses des spectateurs, diffusion HD et outils marketing pour comprendre vos visiteurs, 25 vidéos et lecteur Wistia brandé.
  * [wormhol.org](https://www.wormhol.org/) — Service de partage de fichiers simple. Partagez des fichiers illimités jusqu'à 5 Go avec autant de pairs que vous le souhaitez.
  * [Wormhole](https://wormhole.app/) - Partagez des fichiers jusqu'à 5 Go avec chiffrement de bout en bout pendant 24h maximum. Pour les fichiers de plus de 5 Go, il utilise le transfert pair-à-pair direct.
  * [zoom.us](https://zoom.us/) — Conférences vidéo et web sécurisées avec add-ons disponibles. Le plan gratuit est limité à 40 minutes.
  * [Zulip](https://zulip.com/) — Chat en temps réel avec un modèle de threads unique ressemblant à l'email. Le plan gratuit inclut 10 000 messages dans l'historique de recherche et 5 Go de stockage de fichiers. Version open source auto-hébergeable également disponible.
  * [robocorp.com](https://robocorp.com) - Pile open-source pour alimenter l'Automation Ops. Essayez les fonctionnalités cloud et mettez en œuvre une automatisation simple gratuitement. Tâches robot 240 min/mois, 10 exécutions Assistant, stockage de 100 Mo.
  * [Fleep.io](https://fleep.io/) — Fleep, une alternative à Slack. Plan gratuit pour petites équipes avec historique complet des messages, conversations 1:1 illimitées, 1 conversation de groupe et 1 Go de stockage de fichiers.
  * [Chanty.com](https://chanty.com/) — Chanty, autre alternative à Slack. Plan gratuit à vie pour petites équipes (jusqu'à 10) avec conversations publiques et privées illimitées, historique de recherche, appels audio 1:1 illimités, messages vocaux illimités, dix intégrations et 20 Go de stockage par équipe.
  * [ruttl.com](https://ruttl.com/) — Le meilleur outil de feedback tout-en-un pour collecter des retours numériques et réviser sites web, PDFs et images.
  * [Mattermost](https://mattermost.com/) — Collaboration sécurisée pour équipes techniques. Plan gratuit avec canaux, playbooks, tableaux, utilisateurs illimités, 10 Go de stockage et plus.
  * [Webvizio](https://webvizio.com) — Outil de feedback, logiciel de revue de site web et outil de rapport de bugs pour optimiser la collaboration sur tâches directement sur sites et apps web, images, PDFs et fichiers design.
  * [Pullflow](https://pullflow.com) — Plateforme collaborative de revue de code améliorée par IA sur GitHub, Slack et VS Code.
  * [Webex](https://www.webex.com/) — Réunions vidéo avec plan gratuit offrant 40 minutes par réunion et 100 participants.
  * [RingCentral](https://www.ringcentral.com/) — Réunions vidéo avec plan gratuit offrant 50 minutes par réunion et 100 participants.
  * [GitBook](https://www.gitbook.com/) — Plateforme pour capturer et documenter la connaissance technique — de la documentation produit aux bases de connaissances internes et APIs. Plan gratuit pour développeurs individuels.
  * [transfernow](https://www.transfernow.net/) — Interface la plus simple, rapide et sûre pour transférer et partager des fichiers. Envoyez photos, vidéos et autres gros fichiers sans abonnement obligatoire.
  * [paste.sh](https://paste.sh/) — Site de paste simple basé sur JavaScript et Crypto.
  * [Revolt.chat](https://revolt.chat/) — Une alternative open source à [Discord](https://discord.com/), respectueuse de votre vie privée. Dispose aussi de la plupart des fonctionnalités propriétaires de Discord gratuitement. Revolt est une application tout-en-un, sécurisée et rapide, 100% gratuite. Toutes les fonctionnalités sont gratuites. Supporte les plugins (officiels & non officiels), contrairement à la plupart des applications de chat grand public.
  * [Tencent RTC](https://trtc.io/) — Tencent Real-Time Communication (TRTC) propose des solutions d'appels audio/vidéo de groupe. 10 000 minutes gratuites/mois la première année.
  * [Pastefy](https://pastefy.app/) - Pastebin simple et élégant avec chiffrement client optionnel, pastes multi-onglets, une API, éditeur avec coloration syntaxique et plus.
  * [SiteDots](https://sitedots.com/) - Partagez des retours pour des projets web directement sur votre site, sans émulation, canvas ni détours. Offre gratuite complète.

**[⬆️ Retour en haut](#table-of-contents)**

## CMS

  * [acquia.com](https://www.acquia.com/) — Hébergement pour sites Drupal. Offre gratuite pour développeurs. Outils de développement gratuits (comme Acquia Dev Desktop) également disponibles.
  * [Contentful](https://www.contentful.com/) — CMS Headless. APIs de gestion et livraison de contenu dans le cloud. Inclus un espace Community gratuit avec cinq utilisateurs, 25K enregistrements, 48 types de contenu, 2 langues.
  * [Cosmic](https://www.cosmicjs.com/) — CMS Headless et boîte à outils API. Plans personnels gratuits pour développeurs.
  * [Crystallize](https://crystallize.com) — PIM Headless avec support e-commerce. API GraphQL intégrée. La version gratuite inclut utilisateurs illimités, 1000 articles catalogue, 5 Go/mois de bande passante, et 25k appels API/mois.
  * [DatoCMS](https://www.datocms.com/) - Offre un niveau gratuit pour petits projets. DatoCMS est un CMS basé sur GraphQL. Sur le niveau le plus bas, vous disposez de 100k appels/mois.
  * [Directus](https://directus.io) — CMS Headless. Plateforme totalement gratuite et open source pour gérer les ressources et contenus de base de données sur site ou dans le cloud. Aucune limitation ni paywall.
  * [FrontAid](https://frontaid.io/) — CMS Headless qui stocke le contenu JSON directement dans votre dépôt Git. Aucune restriction.
  * [kontent.ai](https://www.kontent.ai) - Plateforme Content-as-a-Service offrant tous les avantages d'un CMS headless tout en responsabilisant les marketeurs. Le plan développeur offre deux utilisateurs avec projets illimités, deux environnements chacun, 500 contenus, deux langues avec API Delivery et Management, et support des éléments personnalisés. Plans plus détaillés disponibles selon vos besoins.
  * [Prismic](https://www.prismic.io/) — CMS Headless. Interface de gestion du contenu avec API entièrement hébergée et évolutive. Le plan Community offre appels API, documents, types personnalisés, ressources et langues illimités pour un utilisateur. Tout ce dont vous avez besoin pour votre prochain projet. Des plans gratuits plus importants sont disponibles pour les projets Open Content/Open Source.
  * [Sanity.io](https://www.sanity.io/) - Plateforme pour contenu structuré avec environnement d'édition open source et base de données hébergée en temps réel. Projets illimités. Administrateurs illimités, trois utilisateurs non-admin, deux datasets, 500K requêtes API CDN, 10 Go de bande passante et 5 Go de ressources inclus gratuitement par projet.
  * [sensenet](https://sensenet.com) - CMS headless API-first proposant des solutions d'entreprise pour toutes tailles. Le plan développeur inclut trois utilisateurs, 500 contenus, trois rôles intégrés, 25+5 types de contenu, API REST complète, génération de prévisualisation de documents et édition Office Online.
  * [TinaCMS](https://tina.io/) — Remplace Forestry.io. CMS headless open source basé sur Git, supporte Markdown, MDX, et JSON. L'offre basique est gratuite avec deux utilisateurs.
  * [GatsbyjsCMS](https://www.gatsbyjs.com/) - Gatsby est le framework rapide et flexible qui rend la création de sites web avec n'importe quel CMS, API ou base de données à nouveau agréable. Construisez et déployez des sites headless qui génèrent plus de trafic, convertissent mieux et rapportent plus !
  * [Hygraph](https://hygraph.com/) - Offre un niveau gratuit pour petits projets. API d'abord GraphQL. Passez des solutions héritées au CMS headless natif GraphQL - et diffusez du contenu omnicanal en mode API first.
  * [Squidex](https://squidex.io/) - Offre un niveau gratuit pour les petits projets. API / GraphQL first. Open source et basé sur l'event sourcing (versionnant automatiquement chaque changement).
  * [InstaWP](https://instawp.com/) - Lancez un site WordPress en quelques secondes. Un niveau gratuit avec 5 sites actifs, 500 Mo d'espace, expiration du site après 48 heures.
  * [Storyblok](https://www.storyblok.com) - Un CMS Headless pour les développeurs et les marketeurs qui fonctionne avec tous les frameworks modernes. Le niveau Communauté (gratuit) propose une API de gestion, un éditeur visuel, dix sources, des types de champs personnalisés, l'internationalisation (langues/locales illimitées), un gestionnaire d'actifs (jusqu'à 2500 actifs), un service d'optimisation d'images, des requêtes de recherche, Webhook + 250 Go de trafic/mois inclus.
  * [WPJack](https://wpjack.com) - Installez WordPress sur n'importe quel cloud en moins de 5 minutes ! Le niveau gratuit inclut 1 serveur, 2 sites, des certificats SSL gratuits et des tâches cron illimitées. Pas de limite de temps ni d'expiration—votre site web, à votre façon.

**[⬆️ Retour en haut](#table-of-contents)**

## Génération de Code

  * [Appinvento](https://appinvento.io/) — AppInvento est un constructeur d'applications no-code gratuit. Dans le code backend généré automatiquement, les utilisateurs ont un accès complet au code source ainsi qu'aux APIs et routes illimitées, permettant une intégration poussée. Le plan gratuit inclut trois projets, cinq tables et un module complémentaire Google.
  * [Cody AI](https://sourcegraph.com/cody) - Cody est un assistant d'IA pour le code qui utilise l'IA et une compréhension approfondie de votre base de code pour vous aider à écrire et comprendre le code plus rapidement. Cody donne aux développeurs le choix entre plusieurs LLMs (y compris l'inférence locale), prend en charge différents IDE, supporte tous les langages de programmation populaires et propose un plan gratuit. Le plan gratuit donne aux développeurs 20 messages de chat (utilisant Claude 3 Sonnet comme LLM) et 500 autocomplétions (utilisant Starcoder 16b) par mois.
  * [DhiWise](https://www.dhiwise.com/) — Transformez sans effort vos designs Figma en applications dynamiques Flutter & React grâce à la technologie innovante de génération de code de DhiWise, optimisant votre flux de travail et vous aidant à créer des expériences mobiles et web exceptionnelles plus rapidement que jamais.
  * [Codeium](https://www.codeium.com/) — Codeium est un outil gratuit de complétion de code alimenté par l'IA. Il prend en charge plus de 20 langages de programmation (Python, JavaScript, Java, TypeScript, PHP, C/C++, Go, etc.) et s'intègre à tous les principaux IDE, en ligne ou autonomes.
  * [Fern](https://buildwithfern.com) - Écrivez des définitions d’API et utilisez-les pour générer des SDK/bibliothèques clients dans des langages populaires tels que TypeScript, Python, Java, Go, et plus encore. Support complet d’OpenAPI. Le niveau gratuit génère du code pour jusqu'à 20 endpoints maximum.
  * [Metalama](https://www.postsharp.net/metalama) - Uniquement pour C#. Metalama génère le boilerplate du code à la volée pendant la compilation pour que votre code source reste propre. Gratuit pour les projets open source, et le niveau gratuit commercial-friendly inclut trois aspects.
  * [Supermaven](https://www.supermaven.com/) — Supermaven est un plugin de complétion de code IA rapide pour VSCode, JetBrains et Neovim. Le niveau gratuit propose des complétions en ligne illimitées.
  * [tabnine.com](https://www.tabnine.com/) — Tabnine aide les développeurs à créer de meilleurs logiciels plus rapidement en fournissant des suggestions issues de tout le code du monde. Plugin disponible.
  * [v0.dev](https://v0.dev/) — v0 utilise des modèles IA pour générer du code à partir de simples instructions textuelles. Il génère un code React prêt à copier-coller basé sur shadcn/ui et Tailwind CSS, utilisable dans vos projets. Chaque génération coûte au minimum 30 crédits. Vous commencez avec 1200 crédits et obtenez 200 crédits gratuits chaque mois.


**[⬆️ Retour en haut](#table-of-contents)**

## Qualité de Code

  * [beanstalkapp.com](https://beanstalkapp.com/) — Un flux de travail complet pour écrire, relire et déployer du code, un compte gratuit pour un utilisateur et un dépôt avec 100 Mo de stockage
  * [browserling.com](https://www.browserling.com/) — Test cross-browser interactif en direct, gratuit uniquement pour des sessions de 3 minutes avec MS IE 9 sous Vista en 1024 x 768
  * [codacy.com](https://www.codacy.com/) — Revue de code automatisée pour PHP, Python, Ruby, Java, JavaScript, Scala, CSS et CoffeeScript, gratuit pour dépôts publics et privés illimités
  * [Codeac.io](https://www.codeac.io/infrastructure-as-code.html?ref=free-for-dev) - Outil automatisé de revue d'Infrastructure as Code pour DevOps, intégration avec GitHub, Bitbucket et GitLab (même auto-hébergé). En plus des langages standards, il analyse aussi Ansible, Terraform, CloudFormation, Kubernetes et plus. (open source gratuit)
  * [CodeBeat](https://codebeat.co) — Plateforme d'analyse de code automatisée disponible pour de nombreux langages. Gratuit à vie pour les dépôts publics avec intégration Slack et e-mail.
  * [codeclimate.com](https://codeclimate.com/) — Revue de code automatisée, gratuit pour l'Open Source et dépôts privés appartenant à une organisation (jusqu'à 4 collaborateurs). Gratuit aussi pour les étudiants et institutions.
  * [codecov.io](https://codecov.io/) — Outil de couverture de code (SaaS), gratuit pour l'Open Source et un dépôt privé gratuit
  * [CodeFactor](https://www.codefactor.io) — Revue de code automatisée pour Git. La version gratuite inclut utilisateurs illimités, dépôts publics, et un dépôt privé.
  * [coderabbit.ai](https://coderabbit.ai) — Outil de revue de code alimenté par l'IA, intégration avec GitHub/GitLab. Le niveau gratuit inclut 200 fichiers/heure, 3 revues par heure, et 50 conversations/heure. Gratuit à vie pour les projets open source.
  * [codescene.io](https://codescene.io/) - CodeScene priorise la dette technique selon la façon dont les développeurs travaillent sur le code et visualise des facteurs organisationnels comme le couplage des équipes et la maîtrise du système. Gratuit pour l'Open Source.
  * [CodSpeed](https://codspeed.io) - Automatisez le suivi des performances dans vos pipelines CI. Détectez les régressions de performance avant le déploiement, grâce à des métriques précises et cohérentes. Gratuit à vie pour les projets Open Source.
  * [coveralls.io](https://coveralls.io/) — Affichage des rapports de couverture de tests, gratuit pour l'Open Source
  * [dareboost](https://dareboost.com) - 5 analyses gratuites par mois pour la performance web, l'accessibilité et la sécurité
  * [deepcode.ai](https://www.deepcode.ai) — DeepCode trouve les bugs, vulnérabilités de sécurité, problèmes de performance et d'API grâce à l'IA. La rapidité d’analyse de DeepCode permet d’analyser votre code en temps réel et de livrer des résultats lorsque vous sauvegardez dans votre IDE. Langages supportés : Java, C/C++, JavaScript, Python et TypeScript. Intégrations avec GitHub, BitBucket et GitLab. Gratuit pour l’open source et les dépôts privés jusqu’à 30 développeurs.
  * [deepscan.io](https://deepscan.io) — Analyse statique avancée pour détecter automatiquement les erreurs d'exécution dans le code JavaScript, gratuit pour l'Open Source
  * [DeepSource](https://deepsource.io/) - DeepSource analyse en continu les modifications du code source, trouve et corrige les problèmes classés sous sécurité, performance, anti-patterns, risques de bugs, documentation et style. Intégration native avec GitHub, GitLab et Bitbucket.
  * [DiffText](https://difftext.com) - Trouvez instantanément les différences entre deux blocs de code. Entièrement gratuit.
  * [eversql.com](https://www.eversql.com/) — EverSQL - La plateforme n°1 pour l'optimisation de base de données. Obtenez des informations critiques sur votre base de données et vos requêtes SQL automatiquement.
  * [gerrithub.io](https://review.gerrithub.io/) — Revue de code Gerrit pour les dépôts GitHub, gratuit
  * [gocover.io](https://gocover.io/) — Couverture de code pour tout package [Go](https://golang.org/)
  * [goreportcard.com](https://goreportcard.com/) — Qualité du code pour les projets Go, gratuit pour l'Open Source
  * [gtmetrix.com](https://gtmetrix.com/) — Rapports et recommandations détaillées pour optimiser les sites web
  * [holistic.dev](https://holistic.dev/) - Analyseur statique de code n°1 pour l’optimisation Postgresql. Détection automatique des problèmes de performance, sécurité et architecture de la base de données
  * [houndci.com](https://houndci.com/) — Commente sur les commits GitHub sur la qualité du code, gratuit pour l'Open Source
  * [Moderne.io](https://app.moderne.io) — Refactoring automatique du code source. Moderne propose des migrations de framework, une analyse du code avec remédiation, et une transformation de code inégalée à grande échelle, pour que les développeurs passent leur temps à construire du neuf plutôt qu'à maintenir l'ancien. Gratuit pour l’Open Source.
  * [reviewable.io](https://reviewable.io/) — Revue de code pour les dépôts GitHub, gratuit pour dépôts publics ou personnels.
  * [parsers.dev](https://parsers.dev/) - Parsers d'arbres syntaxiques abstraits et compilateurs de représentation intermédiaire en tant que service
  * [scan.coverity.com](https://scan.coverity.com/) — Analyse statique de code pour Java, C/C++, C# et JavaScript, gratuit pour l’Open Source
  * [scrutinizer-ci.com](https://scrutinizer-ci.com/) — Plateforme d’inspection continue, gratuit pour l’Open Source
  * [semanticdiff.com](https://app.semanticdiff.com/) — Différentiel sensible au langage de programmation pour les pull requests et commits GitHub, gratuit pour les dépôts publics
  * [shields.io](https://shields.io) — Badges de métadonnées de qualité pour les projets open source
  * [sonarcloud.io](https://sonarcloud.io) — Analyse automatisée du code source pour Java, JavaScript, C/C++, C#, VB.NET, PHP, Objective-C, Swift, Python, Groovy et bien d'autres langages, gratuit pour l’Open Source
  * [SourceLevel](https://sourcelevel.io/) — Revue de code automatisée et analytics d’équipe. Gratuit pour l’Open Source et les organisations jusqu’à 5 collaborateurs.
  * [webceo.com](https://www.webceo.com/) — Outils SEO mais aussi vérifications de code et différents types d'appareils
  * [zoompf.com](https://zoompf.com/) — Corrigez la performance de vos sites web, analyse détaillée

**[⬆️ Retour en haut](#table-of-contents)**

## Recherche et Navigation dans le Code

  * [libraries.io](https://libraries.io/) — Recherche et notifications de mise à jour de dépendances pour 32 gestionnaires de paquets différents, gratuit pour l’open source
  * [Namae](https://namae.dev/) - Recherche la disponibilité de votre nom de projet sur divers sites comme GitHub, Gitlab, Heroku, Netlify, et plus encore.
  * [searchcode.com](https://searchcode.com/) — Recherche de code textuelle complète, gratuit pour l’Open Source
  * [tickgit.com](https://www.tickgit.com/) — Met en avant les commentaires `TODO` (et autres marqueurs) pour identifier les zones du code à améliorer.
  * [CodeKeep](https://codekeep.io) - Google Keep pour les extraits de code. Organisez, découvrez et partagez des extraits de code, avec un puissant outil de capture d’écran de code doté de modèles prédéfinis et d'une fonctionnalité de liaison.

**[⬆️ Retour en haut](#table-of-contents)**

## CI et CD

  * [AccessLint](https://github.com/marketplace/accesslint) — AccessLint intègre des tests d’accessibilité web automatisés dans votre flux de développement. Gratuit pour l’open source et l’éducation.
  * [appcircle.io](https://appcircle.io) — Plateforme DevOps mobile de niveau entreprise qui automatise la construction, le test et la publication d’applications mobiles pour un cycle de release plus rapide et efficace. Gratuit pour 30 minutes max de build par build, 20 builds mensuels et 1 build simultané.
  * [appveyor.com](https://www.appveyor.com/) — Service CD pour Windows, gratuit pour l’open source
  * [LocalOps](https://localops.co/) - Déployez votre app sur AWS/GCP/Azure en moins de 30 minutes. Créez des environnements applicatifs standardisés sur n'importe quel cloud, avec déploiement continu automatisé et observabilité avancée. Le plan gratuit autorise 1 utilisateur et 1 environnement applicatif.
  * [Argonaut](https://argonaut.dev/) - Déployez apps et infrastructure sur votre cloud en quelques minutes. Support des déploiements personnalisés et tiers sur Kubernetes et environnements Lambda. Le niveau gratuit autorise apps et déploiements illimités pour 5 domaines et 2 utilisateurs.
  * [bitrise.io](https://www.bitrise.io/) — CI/CD pour apps mobiles, natives ou hybrides. 200 builds gratuits/mois, 10 min par build et deux membres d’équipe. Projets OSS : 45 min par build, +1 en concurrence et équipe illimitée.
  * [buddy.works](https://buddy.works/) — CI/CD avec cinq projets gratuits et une exécution simultanée (120 exécutions/mois)
  * [Buildkite](https://buildkite.com) Pipelines CI gratuits pour 3 utilisateurs et 5k minutes de job/mois. Test Analytics niveau développeur gratuit inclut 100k exécutions de tests/mois, avec plus d'inclusions gratuites pour les projets open source.
  * [bytebase.com](https://www.bytebase.com/) — CI/CD et DevOps base de données. Gratuit sous 20 utilisateurs et dix instances de base de données
  * [CircleCI](https://circleci.com/) — Offre complète gratuite avec toutes les fonctionnalités incluses dans un service CI/CD hébergé pour les dépôts GitHub, GitLab et BitBucket. Multiples classes de ressources, Docker, Windows, Mac OS, ARM, runners locaux, split de tests, Docker Layer Caching et autres fonctionnalités avancées. Gratuit jusqu'à 6000 minutes/mois d'exécution, collaborateurs illimités, 30 jobs parallèles sur projets privés, et jusqu’à 80 000 minutes de build gratuites pour l’Open Source.
  * [cirrus-ci.org](https://cirrus-ci.org) - Gratuit pour les dépôts publics GitHub
  * [cirun.io](https://cirun.io) - Gratuit pour les dépôts publics GitHub
  * [codefresh.io](https://codefresh.io) — Plan Free-for-Life : 1 build, un environnement, serveurs partagés, dépôts publics illimités
  * [codemagic.io](https://codemagic.io/) - 500 minutes de build gratuites/mois
  * [codeship.com](https://codeship.com/) — 100 builds privés/mois, cinq projets privés, illimité pour l’open source
  * [deploybot.com](https://www.deploybot.com/) — 1 dépôt avec dix déploiements, gratuit pour l’open source
  * [deployhq.com](https://www.deployhq.com/) — 1 projet avec dix déploiements quotidiens (30 minutes de build/mois)
  * [drone](https://cloud.drone.io/) - Drone Cloud permet aux développeurs d'exécuter des pipelines de livraison continue sur plusieurs architectures — y compris x86 et Arm (32 et 64 bits) — tout au même endroit
  * [LayerCI](https://layerci.com) — CI pour projets full stack. Un environnement de prévisualisation full stack avec 5 Go de mémoire et 3 CPU.
  * [semaphoreci.com](https://semaphoreci.com/) — Gratuit pour l’Open Source, 100 builds privés par mois
  * [Squash Labs](https://www.squash.io/) — crée une VM pour chaque branche et rend votre app disponible via une URL unique, dépôts publics & privés illimités, jusqu'à 2 Go par VM.
  * [styleci.io](https://styleci.io/) — Dépôts publics GitHub uniquement
  * [Mergify](https://mergify.io) — automatisation du workflow et merge queue pour GitHub — Gratuit pour les dépôts publics GitHub
  * [Make](https://www.make.com/en) — Outil d’automatisation de workflows permettant de connecter des apps et d’automatiser des workflows en UI. Prend en charge de nombreuses apps et la plupart des APIs populaires. Gratuit pour les dépôts publics GitHub, et niveau gratuit avec 100 Mo, 1000 opérations et intervalle minimal de 15 minutes.
  * [Spacelift](https://spacelift.io/) - Plateforme de gestion pour Infrastructure as Code. Fonctionnalités du plan gratuit : collaboration IaC, registry de modules Terraform, intégration ChatOps, conformité continue des ressources avec Open Policy Agent, SSO avec SAML 2.0, et accès aux worker pools publics : jusqu’à 200 minutes/mois
  * [microtica.com](https://microtica.com/) - Environnements startup avec composants d’infrastructure prêts à l’emploi, déployez des apps sur AWS gratuitement et supportez vos workloads de production. Le niveau gratuit inclut 1 environnement (sur votre compte AWS), 2 services Kubernetes, 100 minutes de build par mois et 20 déploiements mensuels.
  * [Nx Cloud](https://nx.dev/ci) - Nx Cloud accélère vos monorepos sur CI grâce à des fonctionnalités telles que la mise en cache distante, la répartition des tâches entre plusieurs machines et même la répartition automatisée de vos exécutions de tests e2e. Il propose un plan gratuit pour jusqu'à 30 contributeurs incluant 150 000 crédits généreux.
  * [blacksmith](https://www.blacksmith.sh/) - Exécuteurs de performance managés pour GitHub Actions offrant 3 000 minutes gratuites par mois, sans besoin de carte bancaire.
  * [Terramate](https://terramate.io/) - Terramate est une plateforme d'orchestration et de gestion pour les outils Infrastructure as Code (IaC) tels que Terraform, OpenTofu et Terragrunt. Gratuit jusqu'à 2 utilisateurs incluant toutes les fonctionnalités.
  * [Terrateam](https://terrateam.io) - Automatisation Terraform orientée GitOps avec workflows basés sur les pull requests, isolement des projets via des runners auto-hébergés et exécutions par couches pour des opérations ordonnées. Gratuit pour jusqu'à 3 utilisateurs.

**[⬆️ Retour en haut](#table-of-contents)**

## Tests

  * [Applitools.com](https://applitools.com/) — Validation visuelle intelligente pour applications web, mobiles natives et desktop. S’intègre à presque toutes les solutions d’automatisation (comme Selenium et Karma) et runners distants (Sauce Labs, Browser Stack). Gratuit pour l’open source. Un palier gratuit pour un utilisateur unique avec un nombre limité de checkpoints par semaine.
  * [Appetize](https://appetize.io) — Testez vos applications Android & iOS sur cet émulateur Cloud pour téléphones/tablettes Android et simulateurs iPhone/iPad directement dans votre navigateur. Le forfait gratuit inclut deux sessions simultanées avec 30 minutes d’utilisation par mois. Pas de limite sur la taille des applications.
  * [Apptim](https://apptim.com) — Outil de test mobile qui permet à des personnes sans compétences en performance d’évaluer les performances et l’expérience utilisateur (UX) d’une application. Une version desktop utilisant votre propre appareil est 100% GRATUITE, avec des tests illimités sur iOS et Android.
  * [Argos](https://argos-ci.com) - Tests visuels Open Source pour développeurs. Projets illimités, avec 5 000 captures d’écran par mois. Gratuit pour les projets open source.
  * [Bencher](https://bencher.dev/) - Suite d’outils de benchmarking continu pour détecter les régressions de performance sur CI. Gratuit pour tous les projets publics.
  * [browserstack.com](https://www.browserstack.com/) — Tests manuels et automatisés de navigateurs, [gratuit pour l’Open Source](https://www.browserstack.com/open-source?ref=pricing)
  * [BugBug](https://bugbug.io/) - Outil léger d'automatisation de tests pour applications web. Facile à apprendre et sans codage requis. Vous pouvez exécuter un nombre illimité de tests sur votre propre ordinateur gratuitement. Surveillance cloud et intégration CI/CD disponibles avec supplément.
  * [Checkly](https://checklyhq.com) - Supervision synthétique orientée code pour DevOps modernes. Surveillez vos API et apps à moindre coût. Piloté par un workflow "Monitoring as Code" et Playwright. Offre gratuite généreuse pour les développeurs.
  * [checkbot.io](https://www.checkbot.io/) — Extension navigateur qui teste si votre site suit plus de 50 bonnes pratiques SEO, vitesse et sécurité. Gratuit pour les petits sites web.
  * [CORS-Tester](https://cors-error.dev/cors-tester/) - Outil gratuit pour développeurs et testeurs d’API afin de vérifier si une API est activée CORS pour un domaine donné et d’identifier les lacunes. Obtenez des informations exploitables.
  * [cypress.io](https://www.cypress.io/) - Tests rapides, simples et fiables pour tout ce qui tourne dans un navigateur. Cypress Test Runner est toujours gratuit et open-source, sans restrictions. Cypress Dashboard est gratuit pour les projets open-source jusqu’à 5 utilisateurs.
  * [Cypress Recorder by Preflight](https://cypress.preflight.com/) - Créez des tests Cypress/POM alimentés par l’IA sur votre navigateur. Open-source, sauf la partie IA. Gratuit pour cinq créations de tests mensuelles avec scripts auto-réparateurs, email et test visuel.
  * [everystep-automation.com](https://www.everystep-automation.com/) — Enregistre et rejoue toutes les étapes réalisées dans un navigateur et crée des scripts, gratuit avec options limitées.
  * [Gremlin](https://www.gremlin.com/gremlin-free-software) — Outils d’Ingénierie du Chaos permettant d’injecter des pannes dans vos systèmes pour détecter les faiblesses avant qu’elles ne deviennent visibles côté client. Gremlin Free donne accès aux attaques Shutdown et CPU sur jusqu’à 5 hôtes ou conteneurs.
  * [gridlastic.com](https://www.gridlastic.com/) — Tests Selenium Grid avec forfait gratuit jusqu’à 4 nœuds selenium simultanés/10 démarrages de grille/4 000 minutes de tests/mois
  * [katalon.com](https://katalon.com) - Plateforme de test pouvant aider les équipes de toutes tailles et niveaux de maturité, incluant Katalon Studio, TestOps (+ Visual Testing gratuit), TestCloud et Katalon Recorder.
  * [Keploy](https://keploy.io/) - Outil de test fonctionnel pour développeurs. Enregistre les appels API et génère des tests E2E pour APIs (KTests) et des mocks ou stubs (KMocks). Gratuit pour les projets Open Source.
  * [knapsackpro.com](https://knapsackpro.com) - Accélérez vos tests avec une parallélisation optimale sur n’importe quel fournisseur CI. Répartissez les tests Ruby, JavaScript sur des nœuds CI en parallèle pour gagner du temps. Forfait gratuit jusqu’à 10 minutes de fichiers de tests et forfait illimité gratuit pour les projets Open Source.
  * [lambdatest.com](https://www.lambdatest.com/) — Tests manuels, visuels, par capture d’écran et automatisés sur selenium et cypress, [gratuit pour l’Open Source](https://www.lambdatest.com/open-source-cross-browser-testing-tool)
  * [loadmill.com](https://www.loadmill.com/) - Créez automatiquement des tests d’API et de charge en analysant le trafic réseau. Simulez jusqu’à 50 utilisateurs simultanés pendant 60 minutes gratuitement chaque mois.
  * [lost-pixel.com](https://lost-pixel.com) - Tests de régression visuelle holistiques pour vos stories Storybook, Ladle, Histoire et applications web. Membres illimités, totalement gratuit pour l’open-source, 7 000 snapshots/mois.
  * [octomind.dev](https://www.octomind.dev/) - Génération, exécution et maintenance automatiques de tests UI Playwright avec génération de cas de tests assistée par IA.
  * [percy.io](https://percy.io) - Ajoutez des tests visuels à toute application web, site statique, guide de style ou bibliothèque de composants. Membres illimités, application de démo, projets illimités, 5 000 snapshots/mois.
  * [preflight.com](https://preflight.com) - Tests web automatisés sans code. Enregistrez des tests dans votre navigateur qui résistent aux changements d’UI et exécutez-les sur des machines Windows. Intégration possible avec votre CI/CD. Le forfait gratuit comprend 50 exécutions de tests mensuelles avec vidéo, sessions HTML, etc.
  * [qase.io](https://qase.io) - Système de gestion des tests pour les équipes Dev et QA. Gérez les cas de test, composez des campagnes, exécutez, suivez les défauts et mesurez l’impact. Le palier gratuit inclut toutes les fonctionnalités de base, avec 500 Mo pour les pièces jointes et jusqu’à 3 utilisateurs.
  * [Repeato](https://repeato.app/) Outil no-code d’automatisation de tests d’applications mobiles basé sur la vision par ordinateur et l’IA. Fonctionne pour les apps natives, flutter, react-native, web, ionic, et bien d’autres frameworks. Le plan gratuit est limité à 10 tests pour iOS et 10 pour Android, mais inclut la plupart des fonctionnalités des plans payants, y compris des exécutions illimitées.
  * [Requestly](https://requestly.com/) Extension Chrome open-source pour intercepter, rediriger et simuler des requêtes HTTP. Inclut [Debugger](https://requestly.com/products/web-debugger/), [Mock Server](https://requestly.com/products/mock-server/), [API Client](https://requestly.com/products/api-client/) et [Session Recording](https://requestly.com/products/session-book/). Redirigez des URLs, modifiez les en-têtes HTTP, simulez des APIs, injectez du JS personnalisé, modifiez des requêtes GraphQL, générez des endpoints mock, enregistrez des sessions avec logs réseau & console. Créez jusqu’à 10 règles dans l’offre gratuite. Gratuit pour l’open-source.
  * [seotest.me](https://seotest.me/) — Testeur SEO on-page gratuit. 10 analyses de site par jour. Ressources d’apprentissage SEO utiles et recommandations pour améliorer les résultats SEO on-page de tout site web, quelle que soit la technologie.
  * [snippets.uilicious.com](https://snippets.uilicious.com) - Similaire à CodePen mais pour tests multiplateformes. UI-licious vous permet d’écrire des tests comme des user stories et propose une plateforme gratuite - UI-licious Snippets - permettant d’exécuter des tests illimités sur Chrome sans inscription, pour des sessions allant jusqu’à 3 minutes. Un bug ? Copiez l’URL unique de votre test pour montrer à vos devs comment le reproduire.
  * [TestCollab](https://testcollab.com) - Logiciel de gestion de tests convivial, le plan gratuit inclut intégration Jira, projets illimités, import de cas via CSV/XLSx, suivi du temps et 1 Go de stockage.
  * [testingbot.com](https://testingbot.com/) — Tests Selenium navigateur et appareils, [gratuit pour l’Open Source](https://testingbot.com/open-source)
  * [Testspace.com](https://testspace.com/) - Tableau de bord pour publier les résultats de tests automatisés et framework pour implémenter des tests manuels comme du code via GitHub. Service [gratuit pour l’Open Source](https://github.com/marketplace/testspace-com) et 450 résultats mensuels par compte.
  * [tesults.com](https://www.tesults.com) — Rapport de résultats de tests et gestion des cas de test. S’intègre aux frameworks populaires. Les développeurs open source, particuliers, éducateurs et petites équipes débutantes peuvent demander des offres gratuites ou remisées au-delà des projets gratuits de base.
  * [UseWebhook.com](https://usewebhook.com) - Capturez et inspectez les webhooks depuis votre navigateur. Redirigez vers localhost, ou rejouez depuis l’historique. Gratuit.
  * [Vaadin](https://vaadin.com) — Construisez des UI évolutives en Java ou TypeScript, utilisez les outils intégrés, composants et design system pour itérer plus vite, mieux concevoir et simplifier le développement. Projets illimités avec 5 ans de maintenance gratuite.
  * [websitepulse.com](https://www.websitepulse.com/tools/) — Divers outils réseau et serveur gratuits.
  * [webhook-test.com](https://webhook-test.com) - Déboguez et inspectez les webhooks et requêtes HTTP avec une URL unique pendant l’intégration. Entièrement gratuit, URLs illimités et recommandations incluses.
  * [webhook.site](https://webhook.site) - Vérifiez webhooks, requêtes HTTP sortantes ou emails avec une URL personnalisée. Une URL et adresse email temporaires sont toujours gratuites.
  * [webhookbeam.com](https://webhookbeam.com) - Configurez des webhooks et surveillez-les par notifications push et emails.

**[⬆️ Retour en haut](#table-of-contents)**

## Sécurité et PKI

  * [aikido.dev](https://www.aikido.dev) — Plateforme AppSec tout-en-un couvrant SCA, SAST, CSPM, DAST, secrets, IaC, malware, scan de containers, EOL... Le plan gratuit inclut deux utilisateurs, scan de 10 dépôts, 1 cloud, 2 containers & 1 domaine.
  * [alienvault.com](https://www.alienvault.com/open-threat-exchange/reputation-monitor) — Détecte les systèmes compromis sur votre réseau
  * [Altcha.org](https://altcha.org/anti-spam) - Filtre antispam pour sites web et APIs, basé sur le traitement du langage naturel et le machine learning. Plan gratuit incluant 200 requêtes par jour et par domaine.
  * [atomist.com](https://atomist.com/) — Moyens rapides et pratiques pour automatiser diverses tâches de développement. Actuellement en bêta.
  * [cloudsploit.com](https://cloudsploit.com/) — Audit et surveillance de la sécurité et conformité pour Amazon Web Services (AWS)
  * [Public Cloud Threat Intelligence](https://cloudintel.himanshuanand.com/) — Indicateurs de compromission (IOC) à forte confiance ciblant les infrastructures cloud publiques, une partie disponible sur github (https://github.com/unknownhad/AWSAttacks). Liste complète via API.
  * [CodeNotary.io](https://www.codenotary.io/) — Plateforme Open Source avec preuve indélébile pour notariser code, fichiers, répertoires ou conteneurs.
  * [crypteron.com](https://www.crypteron.com/) — Plateforme cloud de sécurité, orientée développeur, prévenant les fuites de données dans les applications .NET et Java
  * [CyberChef](https://gchq.github.io/CyberChef/) — Webapp intuitive pour analyser et encoder/décoder des données sans outils complexes ou langage de programmation. Véritable couteau suisse de la crypto & du chiffrement. Toutes les fonctionnalités sont gratuites sans limite. Open source pour auto-hébergement.
  * [DAS](https://signup.styra.com/) — Styra DAS Free, gestion complète du cycle de vie des politiques pour créer, déployer et gérer l’autorisation Open Policy Agent (OPA)
  * [Datree](https://www.datree.io/) — Outil CLI Open Source pour éviter les mauvaises configurations Kubernetes en s’assurant que les manifestes et Helm charts suivent les bonnes pratiques et politiques de votre organisation.
  * [Dependabot](https://dependabot.com/) Mises à jour automatisées des dépendances pour Ruby, JavaScript, Python, PHP, Elixir, Rust, Java (Maven et Gradle), .NET, Go, Elm, Docker, Terraform, Git Submodules et GitHub Actions.
  * [DJ Checkup](https://djcheckup.com) — Analysez automatiquement votre site Django à la recherche de failles de sécurité. Fork du site Pony Checkup.
  * [Doppler](https://doppler.com/) — Gestionnaire universel de secrets applicatifs, synchronisation possible avec divers fournisseurs cloud. Gratuit pour cinq utilisateurs avec accès de base.
  * [Dotenv](https://dotenv.org/) — Synchronisez vos fichiers .env rapidement et en toute sécurité. Évitez de partager vos .env par Slack ou email, ne perdez plus jamais de .env important. Gratuit jusqu’à 3 coéquipiers.
  * [GitGuardian](https://www.gitguardian.com) — Gardez les secrets hors de votre code source avec détection et remédiation automatisée. Scannez vos repos git pour 350+ types de secrets et fichiers sensibles – Gratuit pour les particuliers et équipes jusqu’à 25 développeurs.
  * [Have I been pwned?](https://haveibeenpwned.com) — API REST pour récupérer les informations sur les compromissions.
  * [hostedscan.com](https://hostedscan.com) — Scanner de vulnérabilités en ligne pour applications web, serveurs et réseaux. Dix analyses gratuites par mois.
  * [Infisical](https://infisical.com/) — Plateforme open source pour gérer les secrets développeur à travers votre équipe et infrastructure : du développement local jusqu’aux services tiers en production/staging. Gratuit pour jusqu’à 5 développeurs.
  * [Internet.nl](https://internet.nl) — Teste la conformité aux standards Internet modernes : IPv6, DNSSEC, HTTPS, DMARC, STARTTLS et DANE.
  * [keychest.net](https://keychest.net) - Gestion des expirations SSL et achat de certificats avec base CT intégrée.
  * [letsencrypt.org](https://letsencrypt.org/) — Autorité de certification SSL gratuite avec certificats reconnus par tous les grands navigateurs.
  * [meterian.io](https://www.meterian.io/) - Surveillez les projets Java, Javascript, .NET, Scala, Ruby et NodeJS pour les vulnérabilités de dépendances. Gratuit pour un projet privé, projets illimités pour l’open source.
  * [Mozilla Observatory](https://observatory.mozilla.org/) — Trouvez et corrigez les vulnérabilités de sécurité de votre site.
  * [opswat.com](https://www.opswat.com/) — Surveillance de la sécurité des ordinateurs, appareils, applications, configurations, Gratuit pour 25 utilisateurs et 30 jours d’historique.
  * [openapi.security](https://openapi.security/) - Outil gratuit pour vérifier rapidement la sécurité d’une API basée sur OpenAPI / Swagger. Pas besoin de créer de compte.
  * [pixee.ai](https://pixee.ai) - Ingénieur produit sécurité automatisé sous forme de bot GitHub gratuit qui propose des PR pour corriger automatiquement les vulnérabilités Java. D’autres langages arrivent bientôt !
  * [pyup.io](https://pyup.io) — Surveillez les dépendances Python pour les vulnérabilités et mettez-les à jour automatiquement. Gratuit pour un projet privé, projets illimités pour l’open source.
  * [qualys.com](https://www.qualys.com/community-edition) — Détectez les vulnérabilités des applications web, audit pour risques OWASP.
  * [report-uri.io](https://report-uri.io/) — Rapport des violations CSP et HPKP
  * [ringcaptcha.com](https://ringcaptcha.com/) — Outils pour utiliser le numéro de téléphone comme identifiant, disponibles gratuitement.
  * [seclookup.com](https://www.seclookup.com/) - Les APIs Seclookup enrichissent les indicateurs de menace de domaine dans les SIEM, fournissent des informations détaillées et améliorent la détection & la réponse. 50 000 consultations gratuites [ici](https://account.seclookup.com/).
  * [snyk.io](https://snyk.io) — Détecte et corrige les vulnérabilités connues dans vos dépendances open source. Tests et remédiations illimités pour les projets open source. Limité à 200 tests/mois pour les projets privés.
  * [ssllabs.com](https://www.ssllabs.com/ssltest/) — Analyse approfondie de la configuration de tout serveur web SSL
  * [SOOS](https://soos.io) - SCA gratuit et illimité pour projets open source. Détectez et corrigez les menaces avant la sortie. Protégez vos projets avec une solution simple et efficace.
  * [StackHawk](https://www.stackhawk.com/) Automatisez le scan de vos applications à chaque étape de la chaîne CI/CD pour trouver et corriger les bugs de sécurité avant la production. Scans et environnements illimités pour une seule application.
  * [Sucuri SiteCheck](https://sitecheck.sucuri.net) - Vérification gratuite de la sécurité des sites web et scanner de malwares.
  * [Protectumus](https://protectumus.com) - Vérification gratuite de la sécurité des sites, antivirus de site et pare-feu (WAF) pour PHP. Notifications email pour les utilisateurs inscrits à l’offre gratuite.
  * [TestTLS.com](https://testtls.com) - Teste un service SSL/TLS pour la configuration du serveur, certificats, chaînes, etc. Pas limité au HTTPS.
  * [threatconnect.com](https://threatconnect.com) — Intelligence sur les menaces : conçu pour chercheurs individuels, analystes et organisations découvrant la cyber-intelligence. Gratuit jusqu’à 3 utilisateurs.
  * [tinfoilsecurity.com](https://www.tinfoilsecurity.com/) — Scan automatisé de vulnérabilités. Le plan gratuit autorise un scan XSS hebdomadaire.
  * [Ubiq Security](https://ubiqsecurity.com/) — Chiffrez et déchiffrez les données en trois lignes de code avec gestion automatique des clés. Gratuit pour une application et jusqu’à 1 000 000 de chiffrages mensuels.
  * [Virgil Security](https://virgilsecurity.com/) — Outils et services pour implémenter le chiffrement de bout en bout, la protection de base de données, la sécurité IoT, etc. Gratuit pour les applications jusqu’à 250 utilisateurs.
  * [Vulert](https://vulert.com) - Vulert surveille en continu vos dépendances open source pour les nouvelles vulnérabilités, recommande des correctifs, sans installation ni accès à votre code. Gratuit pour l’open source.
  * [Escape GraphQL Quickscan](https://escape.tech/) - Scan de sécurité en un clic de vos endpoints GraphQL. Gratuit, sans inscription.
  * [HasMySecretLeaked](https://gitguardian.com/hasmysecretleaked) - Recherchez parmi 20 millions de secrets exposés dans les dépôts publics GitHub, gists, issues et commentaires gratuitement.
  * [Project Gatekeeper](https://gatekeeper.binarybiology.top/) - Boîte à outils SSL tout-en-un proposant génération de clé privée & CSR, décodage de certificat, correspondance de certificats, commande de certificats SSL. Permet aux utilisateurs de générer des certificats SSL gratuits de Let's Encrypt, Google Trust et BuyPass via enregistrements CNAME plutôt que TXT.
**[⬆️ Retour en haut](#table-of-contents)**

## Authentification, autorisation et gestion des utilisateurs

  * [Aserto](https://www.aserto.com) - Autorisation fine en tant que service pour applications et API. Gratuit jusqu'à 1000 MAU et 100 instances d'autorisateur.
  * [asgardeo.io](https://wso2.com/asgardeo) - Intégration transparente de SSO, MFA, authentification sans mot de passe et plus encore. Inclut des SDK pour les applications frontend et backend. Gratuit jusqu'à 1000 MAU et cinq fournisseurs d'identité.
  * [Auth0](https://auth0.com/) — SSO hébergé. Le plan gratuit inclut 25 000 MAU, connexions sociales illimitées, un domaine personnalisé, et plus encore.
  * [Authgear](https://www.authgear.com) - Apportez l'authentification sans mot de passe, OTP, 2FA, SSO à vos applications en quelques minutes. Tout le Front-end inclus. Gratuit jusqu'à 5000 MAU.
  * [Authress](https://authress.io/) — Connexion d'authentification et contrôle d'accès, fournisseurs d'identité illimités pour tout projet. Facebook, Google, Twitter et plus. Les 1000 premiers appels API sont gratuits.
  * [Authy](https://authy.com) - Authentification à deux facteurs (2FA) sur plusieurs appareils, avec sauvegardes. Remplacement instantané de Google Authenticator. Gratuit jusqu'à 100 authentifications réussies.
  * [Cerbos Hub](https://www.cerbos.dev/product-cerbos-hub) - Système complet de gestion d'autorisation pour rédiger, tester et déployer des politiques d'accès. Autorisation fine et contrôle d'accès, gratuit jusqu'à 100 principaux actifs mensuels.
  * [Clerk](https://clerk.com) — Gestion des utilisateurs, authentification, 2FA/MFA, composants UI préconstruits pour connexion, inscription, profils utilisateurs, etc. Gratuit jusqu'à 10 000 utilisateurs actifs mensuels.
  * [Cloud-IAM](https://www.cloud-iam.com/) — Keycloak Identity and Access Management en tant que service. Gratuit jusqu'à 100 utilisateurs et un realm.
  * [Corbado](https://www.corbado.com/) — Ajoutez une authentification "passkey-first" aux nouvelles applications ou existantes. Gratuit pour MAU illimités.
  * [Descope](https://www.descope.com/) — Flux AuthN hautement personnalisables, approche no-code et API/SDK, 7 500 utilisateurs actifs/mois gratuits, 50 tenants (jusqu'à 5 tenants SAML/SSO).
  * [duo.com](https://duo.com/) — Authentification à deux facteurs (2FA) pour site web ou application. Gratuit pour dix utilisateurs, toutes méthodes d'authentification, intégrations illimitées, tokens matériels.
  * [Kinde](https://kinde.com/) - Authentification simple et robuste, intégration en quelques minutes. Tout ce dont vous avez besoin pour commencer avec 7 500 MAU gratuits.
  * [logintc.com](https://www.logintc.com/) — Authentification à deux facteurs (2FA) par notifications push, gratuit pour dix utilisateurs, VPN, sites web et SSH.
  * [MojoAuth](https://mojoauth.com/) - MojoAuth facilite l'implémentation de l'authentification sans mot de passe sur vos applications web, mobiles ou autres en quelques minutes.
  * [Okta](https://developer.okta.com/signup/) — Gestion des utilisateurs, authentification et autorisation. Gratuit jusqu'à 100 utilisateurs actifs mensuels.
  * [onelogin.com](https://www.onelogin.com/) — Identité en tant que service (IDaaS), fournisseur d'identité SSO, SSO Cloud IdP, trois applications d'entreprise et cinq applications personnelles, utilisateurs illimités.
  * [Ory](https://ory.sh/) - AuthN/AuthZ/OAuth2.0/plateforme de sécurité Zero Trust gérée. Comptes développeur gratuits à vie avec toutes les fonctionnalités de sécurité, membres d'équipe illimités, 200 utilisateurs actifs quotidiens et 25k/mois de vérifications d'autorisations.
  * [Permit.io](https://permit.io) - Plateforme d'autorisation en tant que service permettant RBAC, ABAC, et ReBAC pour des microservices évolutifs avec mises à jour en temps réel et une UI no-code pour les politiques. Niveau gratuit pour 1000 utilisateurs actifs mensuels.
  * [Phase Two](https://phasetwo.io) - Keycloak Open Source Identity and Access Management. Realm gratuit jusqu'à 1000 utilisateurs, jusqu'à 10 connexions SSO, utilisant le conteneur Keycloak amélioré de Phase Two incluant l'extension [Organization](https://phasetwo.io/product/organizations/).
  * [SSOJet](https://ssojet.com/) - Ajoutez le SSO Entreprise sans reconstruire votre Auth. Le plan gratuit inclut des utilisateurs actifs mensuels illimités, organisations illimitées, 2 connexions SSO & 2 connexions SCIM.
  * [Stytch](https://www.stytch.com/) - Plateforme tout-en-un fournissant des API et SDK pour l'authentification et la prévention de fraude. Le plan gratuit inclut 10 000 utilisateurs actifs mensuels, organisations illimitées, 5 connexions SSO ou SCIM, et 1 000 tokens M2M.
  * [Stack Auth](https://stack-auth.com) — Authentification open source sans compromis. Solution la plus adaptée aux développeurs, mise en route en cinq minutes. Auto-hébergeable gratuitement, ou version SaaS gérée avec 10k MAU gratuits.
  * [SuperTokens](https://supertokens.com/) - Authentification utilisateur open source s'intégrant nativement à votre application - pour commencer rapidement tout en gardant le contrôle sur l'expérience utilisateur et développeur. Gratuit jusqu'à 5000 MAU.
  * [Warrant](https://warrant.dev/) — Service hébergé d'autorisation et de contrôle d'accès de niveau entreprise pour vos applications. Le niveau gratuit inclut 1 million de requêtes API mensuelles et 1 000 règles d'autorisations.
  * [ZITADEL Cloud](https://zitadel.com) — Gestion des utilisateurs et des accès clé en main, prise en charge du multi-tenant (B2B). Gratuit jusqu'à 25 000 requêtes authentifiées, avec toutes les fonctionnalités de sécurité (pas de paywall pour OTP, sans mot de passe, politiques, etc.).
  * [PropelAuth](https://propelauth.com) — Vendez à des entreprises de toute taille immédiatement avec quelques lignes de code, gratuit jusqu'à 200 utilisateurs et 10k emails transactionnels (avec filigrane "Powered by PropelAuth").
  * [Logto](https://logto.io/) - Développez, sécurisez et gérez les identités utilisateurs de votre produit - pour l'authentification et l'autorisation. Gratuit jusqu'à 5 000 MAU avec option open source auto-hébergée disponible.
  * [WorkOS](https://workos.com/) - Gestion des utilisateurs et authentification gratuite jusqu'à 1 million de MAU. Support email + mot de passe, authentification sociale, Magic Auth, MFA, et plus.

**[⬆️ Retour en haut](#table-of-contents)**

## Distribution et feedback d'applications mobiles

  * [TestApp.io](https://testapp.io) - Plateforme de référence pour assurer le bon fonctionnement de vos applications mobiles. Plan gratuit : une app, analytics, versions et installations illimitées, et collecte de feedback.
  * [Loadly](https://loadly.io) - Service de distribution bêta d'apps iOS & Android, entièrement gratuit avec téléchargements illimités, téléchargements rapides, et uploads illimités.
  * [Diawi](https://www.diawi.com) - Déployez des apps iOS & Android directement sur les appareils. Plan gratuit : uploads d'app, liens protégés par mot de passe, expiration d'un jour, dix installations.
  * [InstallOnAir](https://www.installonair.com) - Distribution d'applications iOS & Android over-the-air. Plan gratuit : uploads illimités, liens privés, expiration de 2 jours pour les invités, 60 jours pour les utilisateurs enregistrés.
  * [GetUpdraft](https://www.getupdraft.com) - Distribution d'applications mobiles pour tests. Le plan gratuit inclut un projet d'application, trois versions, 500 Mo de stockage et 100 installations par mois.
  * [Appho.st](https://appho.st) - Plateforme d'hébergement d'applications mobiles. Plan gratuit : cinq applications, 50 téléchargements mensuels, taille de fichier max 100 Mo.

**[⬆️ Retour en haut](#table-of-contents)**

## Système de gestion

  * [bitnami.com](https://bitnami.com/) — Déployez des applications préparées sur IaaS. Gestion d'une instance AWS micro gratuite
  * [Esper](https://esper.io) — MDM et MAM pour appareils Android avec DevOps. Cent appareils gratuits avec une licence utilisateur et 25 Mo de stockage d'application.
  * [jamf.com](https://www.jamf.com/) — Gestion des appareils pour iPads, iPhones et Macs, trois appareils gratuits
  * [Miradore](https://miradore.com) — Service de gestion d'appareils. Gardez votre flotte d'appareils à jour et sécurisez un nombre illimité d'appareils gratuitement. Le plan gratuit offre des fonctionnalités de base.
  * [moss.sh](https://moss.sh) - Aide les développeurs à déployer et gérer leurs applications web et serveurs. Gratuit jusqu'à 25 déploiements git par mois
  * [runcloud.io](https://runcloud.io/) - Gestion de serveurs principalement orientée projets PHP. Gratuit jusqu'à 1 serveur.
  * [ploi.io](https://ploi.io/) - Outil de gestion de serveurs pour gérer et déployer facilement vos serveurs & sites. Gratuit pour un serveur.
  * [xcloud.host](https://xcloud.host) — Plateforme de gestion et déploiement de serveurs avec interface conviviale. Offre gratuite pour un serveur.
  * [serveravatar.com](https://serveravatar.com) — Gérez et surveillez des serveurs web PHP avec configurations automatisées. Gratuit pour un serveur.

**[⬆️ Retour en haut](#table-of-contents)**

## Messagerie et streaming

  * [Ably](https://www.ably.com/) - Service de messagerie temps réel avec présence, persistance et livraison garantie. Plan gratuit : 3 millions de messages/mois, 100 connexions et 100 canaux simultanés.
  * [cloudamqp.com](https://www.cloudamqp.com/) — RabbitMQ en tant que service. Offre Little Lemur : max 1 million de messages/mois, max 20 connexions simultanées, max 100 files d'attente, max 10 000 messages en file, plusieurs nœuds dans différentes AZ.
  * [courier.com](https://www.courier.com/) — API unique pour push, in-app, email, chat, SMS et autres canaux, gestion des templates et autres fonctionnalités. Plan gratuit : 10 000 messages/mois.
  * [engagespot.co](https://engagespot.co/) — Infrastructure de notifications multicanal pour développeurs avec boîte de réception intégrée et éditeur de templates sans code. Plan gratuit : 10 000 messages/mois.
  * [HiveMQ](https://www.hivemq.com/mqtt-cloud-broker/) - Connectez vos appareils MQTT au Cloud Native IoT Messaging Broker. Gratuit pour connecter jusqu'à 100 appareils (sans carte bancaire) à vie.
  * [knock.app](https://knock.app) – Infrastructure de notifications pour développeurs. Envoyez sur plusieurs canaux comme in-app, email, SMS, Slack, push via une seule API. Plan gratuit : 10 000 messages/mois.
  * [NotificationAPI.com](https://www.notificationapi.com/) — Ajoutez des notifications utilisateurs à tout logiciel en 5 minutes. Plan gratuit : 10 000 notifications/mois + 100 SMS et appels automatisés.
  * [Novu.co](https://novu.co) — Infrastructure de notifications open source pour développeurs. Composants et APIs simples pour gérer tous les canaux : email, SMS, direct, in-app et push. Plan gratuit : 30 000 notifications/mois avec 90 jours de rétention.
  * [pusher.com](https://pusher.com/) — Service de messagerie temps réel. Gratuit jusqu'à 100 connexions simultanées et 200 000 messages/jour.
  * [scaledrone.com](https://www.scaledrone.com/) — Service de messagerie temps réel. Gratuit jusqu'à 20 connexions simultanées et 100 000 événements/jour.
  * [synadia.com](https://synadia.com/ngs) — [NATS.io](https://nats.io) en tant que service. Global, AWS, GCP, Azure. Gratuit à vie avec taille de message 4k, 50 connexions actives, 5 Go de données/mois.
  * [pubnub.com](https://www.pubnub.com/) - Messagerie Swift, Kotlin et React à 1 million de transactions chaque mois. Les transactions peuvent contenir plusieurs messages.
  * [eyeson API](https://developers.eyeson.team/) - API de communication vidéo basée sur WebRTC (SFU, MCU) pour créer des plateformes vidéo. Permet l'injection de données en temps réel, layouts vidéo, enregistrements, une UI web hébergée complète (quickstart) ou packages pour UI personnalisées. Offre un [niveau gratuit pour développeurs](https://apiservice.eyeson.com/api-pricing) avec 1000 minutes de réunion par mois.
  * [webpushr](https://www.webpushr.com/) - Notifications Web Push - Gratuit jusqu'à 10k abonnés, notifications push illimitées, messagerie in-browser.
  * [httpSMS](https://httpsms.com) - Envoyez et recevez des SMS en utilisant votre téléphone Android comme passerelle SMS. Gratuit jusqu'à 200 messages par mois.
  * [EMQX Serverless](https://www.emqx.com/en/cloud/serverless-mqtt) - Broker MQTT serverless, évolutif et sécurisé, disponible en quelques secondes. 1M de minutes de session/mois gratuites à vie (pas de carte bancaire requise).
  * [Pocket Alert](https://pocketalert.app) - Envoyez des notifications push à vos appareils iOS et Android. Intégration simple via API ou Webhooks et contrôle total de vos alertes. Plan gratuit : 50 messages/jour vers 1 appareil et 1 application.
  * [SuprSend](https://www.suprsend.com/) - SuprSend est une infrastructure de notifications qui rationalise vos notifications produit avec une approche API-first. Créez et livrez des notifications transactionnelles, crons, et d'engagement sur plusieurs canaux avec une seule API. Plan gratuit : 10 000 notifications/mois, incluant différents nœuds de workflow (digests, batchs, multi-canaux, préférences, tenants, diffusions, etc.).

**[⬆️ Retour en haut](#table-of-contents)**

## Gestion des logs

  * [bugfender.com](https://bugfender.com/) — Gratuit jusqu'à 100k lignes de logs/jour avec 24h de rétention
  * [logentries.com](https://logentries.com/) — Gratuit jusqu'à 5 Go/mois avec sept jours de rétention
  * [loggly.com](https://www.loggly.com/) — Gratuit pour un seul utilisateur, 200Mo/jour avec sept jours de rétention
  * [logz.io](https://logz.io/) — Gratuit jusqu'à 1 Go/jour, un jour de rétention
  * [ManageEngine Log360 Cloud](https://www.manageengine.com/cloud-siem/) — Service de gestion de logs propulsé par Manage Engine. Plan gratuit : 50 Go de stockage avec 15 jours de rétention et 7 jours de recherche.
  * [papertrailapp.com](https://papertrailapp.com/) — 48h de recherche, sept jours d'archive, 50 Mo/mois
  * [sematext.com](https://sematext.com/logsene) — Gratuit jusqu'à 500 Mo/jour, sept jours de rétention
  * [sumologic.com](https://www.sumologic.com/) — Gratuit jusqu'à 500 Mo/jour, sept jours de rétention
  * [logflare.app](https://logflare.app/) — Gratuit jusqu'à 12 960 000 entrées/app/mois, 3 jours de rétention
  * [logtail.com](https://logtail.com/) — Gestion de logs compatible SQL basée sur ClickHouse. Gratuit jusqu'à 1 Go/mois, trois jours de rétention.
  * [logzab.com](https://logzab.com/) — Système de gestion de piste d'audit. 1 000 logs d'activité utilisateur/mois gratuits, 1 mois de rétention, jusqu'à 5 projets.
  * [openobserve.ai](https://openobserve.ai/) - 200 Go d'ingestion/mois gratuits, 15 jours de rétention
**[⬆️ Retour en haut](#table-of-contents)**

## Gestion de la traduction

  * [crowdin.com](https://crowdin.com/) — Projets illimités, chaînes illimitées et collaborateurs illimités pour l’Open Source
  * [gitlocalize.com](https://gitlocalize.com) - Gratuit et illimité pour les dépôts privés et publics
  * [Lecto](https://lecto.ai/) - API de traduction automatique avec un niveau gratuit (30 requêtes gratuites, 1000 caractères traduits par requête). Intégré au plugin Loco Translate pour Wordpress.
  * [lingohub.com](https://lingohub.com/) — Gratuit jusqu'à 3 utilisateurs, toujours gratuit pour l’Open Source
  * [localazy.com](https://localazy.com) - Gratuit jusqu’à 1000 chaînes dans la langue source, langues illimitées, contributeurs illimités, offres pour startups et open source
  * [Localeum](https://localeum.com) - Gratuit jusqu’à 1000 chaînes, un utilisateur, langues illimitées, projets illimités
  * [localizely.com](https://localizely.com/) — Gratuit pour l’Open Source
  * [Loco](https://localise.biz/) — Gratuit jusqu'à 2000 traductions, traducteurs illimités, dix langues/projet, 1000 ressources traduisibles/projet
  * [oneskyapp.com](https://www.oneskyapp.com/) — Édition gratuite limitée jusqu’à 5 utilisateurs, gratuit pour l’Open Source
  * [POEditor](https://poeditor.com/) — Gratuit jusqu’à 1000 chaînes
  * [SimpleLocalize](https://simplelocalize.io/) - Gratuit jusqu’à 100 clés de traduction, chaînes illimitées, langues illimitées, offres startup
  * [Texterify](https://texterify.com/) - Gratuit pour un seul utilisateur
  * [Tolgee](https://tolgee.io) - Offre SaaS gratuite avec traductions limitées, version auto-hébergée toujours gratuite
  * [transifex.com](https://www.transifex.com/) — Gratuit pour l’Open Source
  * [Translation.io](https://translation.io) - Gratuit pour l’Open Source
  * [Translized](https://translized.com) - Gratuit jusqu’à 1000 chaînes, un utilisateur, langues illimitées, projets illimités
  * [webtranslateit.com](https://webtranslateit.com/) — Gratuit jusqu’à 500 chaînes
  * [weblate.org](https://weblate.org/) — Gratuit pour les projets libres avec jusqu’à 10 000 chaînes sources pour le niveau gratuit et auto-hébergement illimité sur site.
  * [Free PO editor](https://pofile.net/free-po-editor) — Gratuit pour tout le monde
  * [Lingo.dev](https://lingo.dev) – CLI open-source alimenté par l’IA pour la localisation web & mobile. Apportez votre propre LLM, ou utilisez 10 000 mots gratuits chaque mois via le moteur de localisation géré par Lingo.dev.

**[⬆️ Retour en haut](#table-of-contents)**

## Supervision

  * [UptimeObserver.com](https://uptimeobserver.com) - 20 moniteurs d’uptime avec intervalles de 5 minutes et page de statut personnalisable, même pour un usage commercial. Notifications illimitées et en temps réel par email et Telegram. Pas de carte bancaire requise pour commencer.
  * [Pingmeter.com](https://pingmeter.com/) - 5 moniteurs d’uptime avec intervalle de 10 minutes. Surveillance SSH, HTTP, HTTPS, et tous ports TCP personnalisés.
  * [alerty.ai](https://www.alerty.ai) - APM et supervision gratuits pour FE, BE, DB et plus + exécutions d’agents gratuites.
  * [appdynamics.com](https://www.appdynamics.com/) — Gratuit pour les métriques sur 24h, gestion de performance applicative limitée à un agent Java, un .NET, un PHP, et un Node.js
  * [appneta.com](https://www.appneta.com/) — Gratuit avec une rétention des données d’1h
  * [appspector.com](https://appspector.com/) - Contrôle à distance pour le débogage iOS/Android/Flutter. Gratuit pour un faible trafic (64 Mo de logs).
  * [assertible.com](https://assertible.com) — Tests et supervision d’API automatisés. Plans gratuits pour équipes et particuliers.
  * [bleemeo.com](https://bleemeo.com) - Gratuit pour 3 serveurs, 5 moniteurs d’uptime, utilisateurs illimités, tableaux de bord illimités, règles d’alerte illimitées.
  * [Core Web Vitals History](https://punits.dev/core-web-vitals-historical/) - Historique des Core Web Vitals pour une URL ou un site web.
  * [checklyhq.com](https://checklyhq.com) - Supervision E2E/Synthétique open source et surveillance API avancée pour les développeurs. Plan gratuit avec un utilisateur et 10k vérifications API & réseau / 1,5k vérifications navigateur.
  * [cloudsploit.com](https://cloudsploit.com) — Supervision de sécurité et de configuration AWS. Gratuit : scans à la demande illimités, utilisateurs illimités, comptes stockés illimités. Abonnement : scans automatisés, accès API, etc.
  * [cronitor.io](https://cronitor.io/) - Analyses de performance et supervision d’uptime pour cron jobs, sites web, API et plus. Un niveau gratuit avec cinq moniteurs.
  * [datadoghq.com](https://www.datadoghq.com/) — Gratuit jusqu’à 5 nœuds
  * [deadmanssnitch.com](https://deadmanssnitch.com/) — Supervision des cron jobs. Un snitch (moniteur) gratuit, plus si vous parrainez d’autres inscriptions
  * [downtimemonkey.com](https://downtimemonkey.com/) — 60 moniteurs d’uptime, intervalle de 5 minutes. Alertes par email et Slack.
  * [economize.cloud](https://economize.cloud) — Optimisation et reporting des coûts d’infrastructure cloud. Gratuit jusqu’à 5 000 $ dépensés sur Google Cloud Platform chaque mois.
  * [elastic.co](https://www.elastic.co/solutions/apm) — Analyses de performance instantanées pour développeurs JS. Gratuit avec rétention des données sur 24h
  * [fivenines.io](https://fivenines.io/) — Supervision de serveurs Linux avec tableaux de bord temps réel et alertes — gratuit pour toujours jusqu’à 5 serveurs surveillés à 60 secondes d’intervalle. Pas de carte bancaire requise.
  * [Grafana Cloud](https://grafana.com/products/cloud/) - Plateforme d'observabilité intégrant métriques et logs avec Grafana. Gratuit : 3 utilisateurs, dix tableaux de bord, 100 alertes, stockage des métriques Prometheus/Graphite (10 000 séries, 14 jours de rétention), stockage des logs dans Loki (50 Go, 14 jours de rétention)
  * [healthchecks.io](https://healthchecks.io) — Supervisez vos cron jobs et tâches en arrière-plan. Gratuit jusqu’à 20 vérifications.
  * [Hydrozen.io](https://hydrozen.io) — Supervision d’uptime & pages de statut, Offre gratuite : 10 moniteurs d’uptime, 5 moniteurs heartbeat, 1 moniteur de domaine et 1 statuspage gratuits.
  * [incidenthub.cloud](https://incidenthub.cloud/) — Agrégateur de pages de statut Cloud et SaaS - 20 moniteurs et 2 canaux de notification (Slack et Discord) gratuits à vie.
  * [inspector.dev](https://www.inspector.dev) - Tableau de bord de supervision temps réel complet en moins d’une minute avec une offre gratuite à vie.
  * [instrumentalapp.com](https://instrumentalapp.com) - Supervision applicative et serveur intuitive, jusqu’à 500 métriques et 3h de données visibles gratuitement
  * [keychest.net/speedtest](https://keychest.net/speedtest) - Test de débit indépendant et test de latence TLS face à Digital Ocean
  * [letsmonitor.org](https://letsmonitor.org) - Surveillance SSL, gratuit jusqu’à 5 moniteurs
  * [linkok.com](https://linkok.com) - Vérificateur de liens cassés en ligne, gratuit pour petits sites jusqu’à 100 pages, totalement gratuit pour les projets open source.
  * [loader.io](https://loader.io/) — Outils de tests de charge gratuits avec limitations
  * [MonitorMonk](https://monitormonk.com) - Supervision uptime minimaliste avec pages de statut élégantes. Offre gratuite à vie : supervision HTTPS, mot-clé, SSL, temps de réponse pour 10 sites ou endpoints, 2 tableaux de bord/pages de statut.
  * [netdata.cloud](https://www.netdata.cloud/) — Netdata est un outil open source de collecte de métriques en temps réel. Produit en évolution, aussi sur GitHub !
  * [newrelic.com](https://www.newrelic.com) — Plateforme d’observabilité New Relic. Instrumentez tout, analysez, optimisez votre stack. Offre gratuite : 100 Go/mois de données, un utilisateur full-access gratuit, utilisateurs primaires illimités.
  * [Middleware.io](https://middleware.io/) - Plateforme d'observabilité Middleware offrant visibilité complète sur vos apps & stack, surveillance des logs (jusqu’à 1M événements), supervision d’infrastructure & APM jusqu’à 2 hôtes. Offre gratuite à vie pour la communauté Dev.
  * [nixstats.com](https://nixstats.com) - Gratuit pour un serveur. Notifications par email, page de statut publique, intervalle de 60 secondes, et plus.
  * [OnlineOrNot.com](https://onlineornot.com/) - Supervision uptime pour sites web et APIs, supervision de cron jobs et tâches planifiées. Statut pages incluses. Cinq premiers contrôles gratuits avec intervalle de 3 minutes. Alertes gratuites via Slack, Discord, Email.
  * [OntarioNet.ca CN Test](https://cntest.ontarionet.ca) — Vérifiez si un site web est bloqué en Chine par le Grand Pare-feu. Identifie la pollution DNS en comparant les résultats DNS et ASN détectés par des serveurs en Chine et aux États-Unis.
  * [opsgenie.com](https://www.opsgenie.com/) — Alerting puissant et gestion des astreintes pour services critiques. Gratuit jusqu’à 5 utilisateurs.
  * [paessler.com](https://www.paessler.com/) — Solution de supervision d’infrastructure et réseau, alertes, visualisation et reporting de base. Gratuit jusqu’à 100 capteurs.
  * [pagecrawl.io](https://pagecrawl.io/) -  Surveillance des changements de site web, gratuit jusqu’à 6 moniteurs avec vérifications quotidiennes.
  * [syagent.com](https://syagent.com/) — Service gratuit de supervision serveur non commercial, alertes et métriques.
  * [pagerly.io](https://pagerly.io/) -  Gestion des astreintes sur Slack (intégration Pagerduty, OpsGenie). Gratuit pour 1 équipe (une équipe = une astreinte)
  * [pagertree.com](https://pagertree.com/) - Interface simple pour alerting et gestion des astreintes. Gratuit jusqu’à 5 utilisateurs.
  * [phare.io](https://phare.io/) - Supervision d’uptime gratuite jusqu’à 100 000 événements pour projets et pages de statut illimités.
  * [pingbreak.com](https://pingbreak.com/) — Service moderne de surveillance d’uptime. URLs illimitées, notifications de panne via Discord, Slack ou email.
  * [pingpong.one](https://pingpong.one/) — Plateforme avancée de page de statut avec supervision. Offre gratuite : une page de statut publique personnalisable avec sous-domaine SSL. Plan pro offert gratuitement aux projets open source et associations.
  * [robusta.dev](https://home.robusta.dev/) — Supervision Kubernetes avancée basée sur Prometheus. Apportez votre Prometheus ou installez le bundle tout-en-un. Offre gratuite jusqu’à 20 nœuds Kubernetes. Alertes via Slack, Teams, Discord, etc. Intégration PagerDuty, OpsGenie, VictorOps, DataDog, et autres.
  * [sematext.com](https://sematext.com/) — Gratuit pour 24h de métriques, serveurs illimités, dix métriques personnalisées, 500 000 points de données, tableaux de bord illimités, utilisateurs illimités, etc.
  * [sitemonki.com](https://sitemonki.com/) — Supervision de site, domaine, Cron & SSL, 5 moniteurs dans chaque catégorie gratuitement
  * [sitesure.net](https://sitesure.net) - Supervision de site web et cron - 2 moniteurs gratuits
  * [skylight.io](https://www.skylight.io/) — Gratuit pour les 100 000 premières requêtes (Rails uniquement)
  * [speedchecker.xyz](https://probeapi.speedchecker.xyz/) — API de supervision de performance, vérifie Ping, DNS, etc.
  * [stathat.com](https://www.stathat.com/) — Débutez avec dix stats gratuites, sans expiration
  * [statuscake.com](https://www.statuscake.com/) — Supervision de site web, tests illimités gratuits avec limitations
  * [statusgator.com](https://statusgator.com/) — Supervision de page de statut, 3 moniteurs gratuits
  * [SweetUptime](https://dicloud.net/sweetuptime-server-uptime-monitoring/) — Supervision de serveurs, de disponibilité, DNS & domaines. Surveillez 10 serveurs, 10 uptimes, et 10 domaines gratuitement.
  * [thousandeyes.com](https://www.thousandeyes.com/) — Supervision réseau et expérience utilisateur. 3 localisations et 20 flux de données de grands services web gratuits
  * [uptimetoolbox.com](https://uptimetoolbox.com/) — Supervision gratuite de cinq sites, intervalles de 60 secondes, page de statut publique.
  * [zenduty.com](https://www.zenduty.com/) — Gestion des incidents de bout en bout, alertes, astreintes et orchestration pour équipes réseau, SRE et DevOps. Gratuit jusqu’à 5 utilisateurs.
  * [instatus.com](https://instatus.com) - Créez une belle page de statut en 10 secondes. Gratuit à vie, abonnés illimités, équipes illimitées.
  * [Squadcast.com](https://squadcast.com) - Logiciel de gestion d’incidents de bout en bout conçu pour promouvoir les bonnes pratiques SRE. Offre gratuite pour toujours jusqu’à 10 utilisateurs.
  * [RoboMiri.com](https://robomiri.com/) - RoboMiri est un moniteur d’uptime stable proposant de nombreux types de supervision : cronjob, mot-clé, site web, port, ping. 25 vérifications gratuites toutes les 3 minutes. Alertes via appel téléphonique, SMS, email et webhooks.
  * [Better Stack](https://betterstack.com/better-uptime) - Supervision d’uptime, gestion d’incident, planification/alerting des astreintes, pages de statut dans un seul produit. Offre gratuite : dix moniteurs avec fréquence de 3 minutes et pages de statut.
  * [Pulsetic](https://pulsetic.com) - 10 moniteurs, 6 mois d’historique d’uptime/logs, pages de statut illimitées, domaines personnalisés inclus ! Gratuit à vie et alertes email illimitées. Pas besoin de carte bancaire.
  * [Wachete](https://www.wachete.com) - Surveillez cinq pages, vérifications toutes les 24 heures.
  * [Xitoring.com](https://xitoring.com/) — Supervision d’uptime : 20 gratuits, Supervision Linux et Windows : 5 gratuits, page de statut : 1 gratuite - Application mobile, multiples canaux de notification, et plus encore !
  * [Servervana](https://servervana.com) - Supervision avancée de disponibilité pour projets et équipes de grande taille. Supervision HTTP, navigateur, DNS, domaines, pages de statut, etc. Niveau gratuit : 10 moniteurs HTTP, 1 DNS, 1 page de statut.

**[⬆️ Retour en haut](#table-of-contents)**

## Gestion des crashs et des exceptions
  * [CatchJS.com](https://catchjs.com/) - Suivi des erreurs JavaScript avec captures d'écran et suivi des clics. Gratuit pour les projets open-source.
  * [bugsnag.com](https://www.bugsnag.com/) — Gratuit jusqu'à 2 000 erreurs/mois après l'essai initial.
  * [elmah.io](https://elmah.io/) — Journalisation des erreurs et surveillance de la disponibilité pour les développeurs web. Abonnement Small Business gratuit pour les projets open-source.
  * [Embrace](https://embrace.io/) — Surveillance des applications mobiles. Gratuit pour les petites équipes jusqu'à 1 million de sessions utilisateur par an.
  * [exceptionless](https://exceptionless.com) — Signalement en temps réel des erreurs, fonctionnalités, journaux, et plus encore. Gratuit pour 3 000 événements par mois/1 utilisateur. Open source et facile à auto-héberger pour une utilisation illimitée.
  * [GlitchTip](https://glitchtip.com/) — Suivi d'erreurs simple et open source. Compatible avec les SDK open-source Sentry. 1 000 événements par mois gratuits, ou peut être auto-hébergé sans limite.
  * [honeybadger.io](https://www.honeybadger.io) - Surveillance des exceptions, de la disponibilité et des tâches cron. Gratuit pour les petites équipes et les projets open-source (12 000 erreurs/mois).
  * [memfault.com](https://memfault.com) — Plateforme cloud d'observabilité et de débogage des appareils. 100 appareils gratuits pour les appareils [Nordic](https://app.memfault.com/register-nordic), [NXP](https://app.memfault.com/register-nxp) et [Laird](https://app.memfault.com/register-laird).
  * [rollbar.com](https://rollbar.com/) — Surveillance des exceptions et des erreurs, offre gratuite avec 5 000 erreurs/mois, utilisateurs illimités, rétention de 30 jours.
  * [sentry.io](https://sentry.io/) — Sentry suit les exceptions des applications en temps réel et propose un petit forfait gratuit. Gratuit pour 5 000 erreurs par mois/1 utilisateur, utilisation illimitée si auto-hébergé.
  * [Axiom](https://axiom.co/) — Stockez jusqu'à 0,5 To de journaux avec une rétention de 30 jours. Inclut des intégrations avec des plateformes comme Vercel et des requêtes avancées de données avec notifications par email/Discord.
  * [Semaphr](https://semaphr.com) — Kill switch tout-en-un gratuit pour vos applications mobiles.
  * [Jam](https://jam.dev) - Rapports de bugs conviviaux pour les développeurs en un clic. Forfait gratuit avec jams illimités.
  * [Whitespace](https://whitespace.dev) – Rapports de bugs en un clic directement dans votre navigateur. Forfait gratuit avec enregistrements illimités pour usage personnel.

**[⬆️ Retour en haut](#table-of-contents)**

## Recherche

  * [algolia.com](https://www.algolia.com/) — Solution de recherche hébergée avec tolérance aux fautes de frappe, pertinence et bibliothèques UI pour créer facilement des expériences de recherche. Le forfait gratuit "Build" inclut 1M de documents et 10K recherches/mois. Propose également la [recherche documentaire pour les développeurs](https://docsearch.algolia.com/) gratuitement.
  * [bonsai.io](https://bonsai.io/) — 1 Go de mémoire et 1 Go de stockage gratuits.
  * [CommandBar](https://www.commandbar.com/) - Barre de recherche unifiée en tant que service, widget/plugin d'interface web permettant à vos utilisateurs de rechercher du contenu, des navigations, des fonctionnalités, etc. dans votre produit, ce qui facilite la découverte. Gratuit jusqu'à 1 000 utilisateurs actifs mensuels, commandes illimitées.
  * [Orama Cloud](https://orama.com/pricing) — 3 index gratuits, 100 000 docs/index, recherches full-text/vectorielles/hybrides illimitées, 60 jours d'analytique.
  * [searchly.com](http://www.searchly.com/) — 2 index gratuits et 20 Mo de stockage.
  * [easysitesearch.com](https://easysitesearch.com/) — Widget et API de recherche, avec indexation automatisée basée sur un web-crawler. Recherches illimitées gratuites jusqu'à 50 sous-pages.

**[⬆️ Retour en haut](#table-of-contents)**

## Éducation et développement de carrière

  * [FreeCodeCamp](https://www.freecodecamp.org/) - Plateforme open-source proposant des cours et certifications gratuits en analyse de données, sécurité de l'information, développement web, et plus.
  * [The Odin Project](https://www.theodinproject.com/) - Plateforme gratuite et open-source avec un programme axé sur JavaScript et Ruby pour le développement web.
  * [Modèles de CV professionnels gratuits & éditeur](https://www.overleaf.com/latex/templates/tagged/cv) - Plateforme gratuite avec de nombreux modèles de CV de professionnels expérimentés, prêts à être clonés, édités et téléchargés, optimisés ATS.
  * [DeepLearning.AI Short Courses](https://www.deeplearning.ai/short-courses/) - Cours courts gratuits dispensés par des experts de l'industrie pour acquérir une expérience pratique des derniers outils et techniques d'IA générative en une heure ou moins.
  * [LabEx](https://labex.io) - Développez vos compétences en Linux, DevOps, cybersécurité, programmation, data science, et plus via des laboratoires interactifs et des projets concrets.
  * [Roadmap.sh](https://roadmap.sh) - Parcours d'apprentissage gratuits couvrant tous les aspects du développement, de la blockchain au design UX.
  * [Cisco Networking Academy, Skills for All](https://skillsforall.com/) - Propose des cours gratuits alignés sur la certification dans des domaines comme la cybersécurité, le réseau, et Python.
  * [MIT OpenCourseWare](https://ocw.mit.edu/) - MIT OpenCourseWare est une publication en ligne de supports de plus de 2 500 cours du MIT, partageant librement le savoir avec les apprenants et les enseignants du monde entier. Chaîne Youtube disponible sur [@mitocw](https://www.youtube.com/@mitocw/featured)
  * [W3Schools](https://www.w3schools.com/) - Propose des tutoriels gratuits sur les technologies du développement web comme HTML, CSS, JavaScript, et plus.
  * [Khan Academy](https://www.khanacademy.org/computing/computer-programming) - Guides en ligne gratuits pour apprendre HTML/CSS, JavaScript et SQL, du niveau débutant à avancé.
  * [Full Stack Open](https://fullstackopen.com/en/) – Cours universitaire gratuit sur le développement web moderne avec React, Node.js, GraphQL, TypeScript, et plus. Entièrement en ligne et à votre rythme.
  * [edX](https://www.edx.org/) - Accès à plus de 4 000 cours en ligne gratuits issus de 250 institutions reconnues, dont Harvard et le MIT, spécialisés en informatique, ingénierie et data science.
  * [Django-tutorial.dev](https://django-tutorial.dev) - Guides gratuits en ligne pour apprendre Django comme premier framework & offre un backlink dofollow gratuit aux articles écrits par les utilisateurs.

**[⬆️ Retour en haut](#table-of-contents)**

## Email

  * [10minutemail](https://10minutemail.com) - Email temporaire gratuit pour les tests.
  * [AhaSend](https://ahasend.com) - Service d'email transactionnel, gratuit pour 1 000 emails par mois, avec domaines illimités, membres d'équipe, webhooks et routages de messages dans l'offre gratuite.
  * [AnonAddy](https://anonaddy.com) - Transfert anonyme d'email open-source, créez un nombre illimité d'alias email gratuitement.
  * [Antideo](https://www.antideo.com/) — 10 requêtes API par heure pour la vérification d'email, la validation IP et numéro de téléphone dans l'offre gratuite. Aucune carte bancaire requise.
  * [Brevo](https://www.brevo.com/) — 9 000 emails/mois, 300 emails/jour gratuits.
  * [OneSignal](https://onesignal.com/) — 10 000 emails/mois, aucune carte bancaire requise.
  * [Bump](https://bump.email/) - 10 adresses email Bump gratuites, un domaine personnalisé.
  * [Burnermail](https://burnermail.io/) – 5 adresses email Burner gratuites, 1 boîte de réception, historique de 7 jours.
  * [Buttondown](https://buttondown.email/) — Service de newsletter. Jusqu'à 100 abonnés gratuitement.
  * [CloudMailin](https://www.cloudmailin.com/) - Email entrant via HTTP POST et email transactionnel sortant - 10 000 emails gratuits/mois.
  * [Contact.do](https://contact.do/) — Formulaire de contact sous forme de lien (bitly des formulaires de contact).
  * [debugmail.io](https://debugmail.io/) — Serveur de test mail facile à utiliser pour les développeurs.
  * [DNSExit](https://dnsexit.com/) - Jusqu'à 2 adresses email sous votre domaine gratuitement avec 100 Mo d'espace de stockage. Support IMAP, POP3, SMTP, SPF/DKIM.
  * [EmailLabs.io](https://emaillabs.io/en) — Envoyez jusqu'à 9 000 emails gratuits chaque mois, jusqu'à 300 emails quotidiens.
  * [EmailOctopus](https://emailoctopus.com) - Jusqu'à 2 500 abonnés et 10 000 emails par mois gratuitement.
  * [EmailJS](https://www.emailjs.com/) – Ce n'est pas un serveur email complet ; il s'agit d'un client email permettant d'envoyer des emails directement depuis le client sans exposer vos identifiants, la formule gratuite comprend 200 requêtes mensuelles, 2 modèles d'email, requêtes jusqu'à 50 Ko, historique limité des contacts.
  * [EtherealMail](https://ethereal.email) - Ethereal est un faux service SMTP, principalement destiné aux utilisateurs de Nodemailer et EmailEngine (mais pas seulement). Service anti-transactionnel entièrement gratuit où les messages ne sont jamais délivrés.
  * [Temp-Mail.org](https://temp-mail.org/en/) - Générateur de mail temporaire/jetable utilisant une grande variété de domaines. L'adresse email se rafraîchit à chaque rechargement de la page. Totalement gratuit, aucun tarif pour les services proposés.
  * [TempMailDetector.com](https://tempmaildetector.com/) - Vérifiez jusqu'à 200 emails par mois gratuitement et voyez si un email est temporaire ou non.
  * [Emailvalidation.io](https://emailvalidation.io) - 100 vérifications d'email gratuites par mois.
  * [FakeMailGenerator.com](https://www.fakemailgenerator.com/) - Générateur allemand de mail temporaire/jetable. Supporte 10 domaines, permet de créer un nombre illimité d'adresses. (contient des pubs) mais totalement gratuit.
  * [forwardemail.net](https://forwardemail.net) — Redirection d'email gratuite pour domaines personnalisés. Créez et redirigez un nombre illimité d'adresses email avec votre nom de domaine (**note** : Payant si vous utilisez les TLD .casa, .cf, .click, .email, .fit, .ga, .gdn, .gq, .lat, .loan, .london, .men, .ml, .pl, .rest, .ru, .tk, .top, .work en raison du spam)
  * [Imitate Email](https://imitate.email) - Serveur email sandbox pour tester la fonctionnalité email lors de la construction/QA et CI/CD. Comptes gratuits : 15 emails par jour à vie.
  * [ImprovMX](https://improvmx.com) – Redirection d'email gratuite.
  * [EForw](https://www.eforw.com) – Redirection d'email gratuite pour un domaine. Recevez et envoyez des emails depuis votre domaine.
  * [Inboxes App](https://inboxesapp.com) — Créez jusqu'à 3 emails temporaires par jour, puis supprimez-les depuis une extension Chrome pratique. Parfait pour tester des parcours d'inscription.
  * [inboxkitten.com](https://inboxkitten.com/) - Boîte mail temporaire/jetable gratuite, suppression automatique des emails jusqu'à 3 jours. Open source et peut être auto-hébergée.
  * [mail-tester.com](https://www.mail-tester.com) — Teste la configuration DNS/SPF/DKIM/DMARC de l'email, 20 tests gratuits/mois.
  * [dkimvalidator.com](https://dkimvalidator.com/) - Teste la configuration DNS/SPF/DKIM/DMARC de l'email, service gratuit par roundsphere.com.
  * [mailcatcher.me](https://mailcatcher.me/) — Capture les emails et les affiche via une interface web.
  * [mailchannels.com](https://www.mailchannels.com) - API email avec intégrations REST API et SMTP, gratuit jusqu'à 3 000 emails/mois.
  * [Mailcheck.ai](https://www.mailcheck.ai/) - Empêche les utilisateurs de s'inscrire avec des adresses email temporaires, 120 requêtes/heure (~86 400/mois).
  * [Mailchimp](https://mailchimp.com/) — 500 abonnés et 1 000 emails/mois gratuits.
  * [Maildroppa](https://maildroppa.com) - Jusqu'à 100 abonnés et emails illimités ainsi qu'automatisations gratuites.
  * [MailerLite.com](https://www.mailerlite.com) — 1 000 abonnés/mois, 12 000 emails/mois gratuits.
  * [MailerSend.com](https://www.mailersend.com) — API email, SMTP, 3 000 emails/mois gratuits pour les emails transactionnels.
  * [mailinator.com](https://www.mailinator.com/) — Système d'email public gratuit où vous pouvez utiliser la boîte de réception de votre choix.
  * [Mailjet](https://www.mailjet.com/) — 6 000 emails/mois gratuits (limite de 200 emails envoyés par jour).
  * [Mailnesia](https://mailnesia.com) - Email temporaire/jetable gratuit qui visite automatiquement les liens d'inscription.
  * [mailsac.com](https://mailsac.com) - API gratuite pour tests d'email temporaire, hébergement email public gratuit, capture d'envoi, email vers slack/websocket/webhook (limite API 1 500/mois).
  * [Mailtrap.io](https://mailtrap.io/) — Faux serveur SMTP pour le développement, offre gratuite avec une boîte de réception, 100 messages, pas de membre d'équipe, deux emails/seconde, pas de règles de transfert.
  * [Mail7.io](https://www.mail7.io/) — Adresses email temporaires gratuites pour développeurs QA. Créez des adresses instantanément via l'interface web ou l'API.
  * [Momentary Email](https://www.momentaryemail.com/) — Adresses email temporaires gratuites. Lisez les emails entrants sur le site ou via flux RSS.
  * [Mutant Mail](https://www.mutantmail.com/) – 10 IDs email gratuits, 1 domaine, 1 boîte de réception. Boîte unique pour tous les IDs email.
  * [Outlook.com](https://outlook.live.com/owa/) - Email personnel et calendrier gratuits.
  * [Parsio.io](https://parsio.io) — Parseur d'email gratuit (transférez l'email, extrayez les données, envoyez-les à votre serveur).
  * [pepipost.com](https://pepipost.com) — 30 000 emails gratuits le premier mois, puis les 100 premiers emails/jour gratuits.
  * [Plunk](https://useplunk.com) - 3 000 emails/mois gratuits.
  * [Postmark](https://postmarkapp.com/) - 100 emails/mois gratuits, rapports DMARC hebdomadaires illimités.
  * [Proton Mail](https://proton.me/mail) - Service d'email sécurisé gratuit avec chiffrement de bout en bout. 1 Go de stockage gratuit.
  * [Queuemail.dev](https://queuemail.dev) — API de livraison d'email fiable. Offre gratuite (10 000 emails/mois). Envoi asynchrone. Utilisez plusieurs serveurs SMTP. Listes de blocage, logs, suivi, webhooks, et plus.
  * [QuickEmailVerification](https://quickemailverification.com) — Vérifiez 100 emails par jour gratuitement dans l'offre gratuite ainsi que d'autres API gratuites comme le détecteur DEA, la recherche DNS, le détecteur SPF, etc.
* [Resend](https://resend.com) - API d’e-mails transactionnels pour développeurs. 3 000 emails/mois, 100 emails/jour gratuits, un domaine personnalisé.
* [Sender](https://www.sender.net) Jusqu'à 15 000 emails/mois, jusqu'à 2 500 abonnés.
* [Sendpulse](https://sendpulse.com) — 500 abonnés/mois, 15 000 emails/mois gratuits.
* [SimpleLogin](https://simplelogin.io/) – Solution open source et auto-hébergeable d’alias/renvoi d’e-mails. 5 alias gratuits, bande passante illimitée, réponses/envois illimités. Gratuit pour le personnel éducatif (étudiants, chercheurs, etc.).
* [Substack](https://substack.com) — Service de newsletter gratuit et illimité. Paiement requis uniquement si vous facturez vos abonnés.
* [Sweego](https://www.sweego.io/) - API européenne d’e-mails transactionnels pour développeurs. 500 emails/jour gratuits.
* [Takeout](https://takeout.bysourfruit.com) - Service d’e-mail constamment mis à jour qui facilite l’envoi d’e-mails. 500 e-mails transactionnels/mois gratuits.
* [temp-mail.io](https://temp-mail.io) — Service gratuit d’e-mail temporaire jetable avec gestion de plusieurs adresses et redirection.
* [tinyletter.com](https://tinyletter.com/) — 5 000 abonnés/mois gratuits.
* [Touchlead](https://touchlead.app) - Outil d’automatisation marketing polyvalent, avec gestion de leads, générateur de formulaires et automatisation. Gratuit pour un nombre limité de leads et d’automatisations.
* [trashmail.com](https://www.trashmail.com) - Adresses e-mails jetables gratuites avec redirection et expiration automatique de l’adresse.
* [Tuta](https://tuta.com/) - Fournisseur de service de messagerie sécurisé gratuit avec chiffrement de bout en bout intégré, sans publicité, sans traçage. 1 Go de stockage gratuit, un calendrier (Tuta propose aussi un [plan payant](https://tuta.com/pricing)). Tuta est aussi partiellement [open source](https://github.com/tutao/tutanota), donc auto-hébergeable.
* [Verifalia](https://verifalia.com/email-verification-api) — API de vérification d’e-mails en temps réel avec confirmation de boîte aux lettres et détection d’adresses jetables ; 25 vérifications gratuites/jour.
* [verimail.io](https://verimail.io/) — Service de vérification d’e-mails en masse et via API. 100 vérifications gratuites/mois.
* [Zoho](https://www.zoho.com) — Initialement fournisseur d’e-mails, propose désormais une suite de services, dont certains gratuits. Liste des services avec offres gratuites :
   - [Email](https://zoho.com/mail) Gratuit pour 5 utilisateurs. 5 Go/utilisateur & 25 Mo limite de pièce jointe, un domaine.
   - [Zoho Assist](https://www.zoho.com/assist) — Le plan gratuit inclut une licence de support à distance simultanée et l’accès à 5 ordinateurs non surveillés pour une durée illimitée, usage pro ou perso.
   - [Sprints](https://zoho.com/sprints) Gratuit pour 5 utilisateurs, 5 projets & 500 Mo de stockage.
   - [Docs](https://zoho.com/docs) — Gratuit pour 5 utilisateurs avec limite de 1 Go par upload & 5 Go de stockage. Suite bureautique Zoho (Writer, Sheets & Show) incluse.
   - [Projects](https://zoho.com/projects) — Gratuit pour 3 utilisateurs, 2 projets & 10 Mo de pièce jointe. Même offre pour [Bugtracker](https://zoho.com/bugtracker).
   - [Connect](https://zoho.com/connect) — Collaboration d’équipe gratuite pour 25 utilisateurs avec trois groupes, trois apps personnalisées, 3 tableaux, 3 manuels, 10 intégrations + salons, événements & forums.
   - [Meeting](https://zoho.com/meeting) — Réunions jusqu’à 3 participants & 10 spectateurs en webinaire.
   - [Vault](https://zoho.com/vault) — Gestion de mots de passe pour individus.
   - [Showtime](https://zoho.com/showtime) — Autre solution de réunion pour sessions à distance, jusqu’à 5 participants.
   - [Notebook](https://zoho.com/notebook) — Alternative gratuite à Evernote.
   - [Wiki](https://zoho.com/wiki) — Gratuit pour 3 utilisateurs avec 50 Mo de stockage, pages illimitées, sauvegardes zip, flux RSS & Atom, contrôles d’accès & CSS personnalisable.
   - [Subscriptions](https://zoho.com/subscriptions) — Gestion d’abonnements récurrents gratuit pour 20 clients/abonnements & 1 utilisateur, hébergement des paiements par Zoho. Les 40 dernières métriques d’abonnement sont stockées.
   - [Checkout](https://zoho.com/checkout) — Gestion de facturation de produits avec 3 pages & jusqu’à 50 paiements.
   - [Desk](https://zoho.com/desk) — Gestion du support client avec trois agents, base de connaissances privée et tickets e-mail. Intégration avec [Assist](https://zoho.com/assist) pour un technicien à distance & 5 ordinateurs non surveillés.
   - [Cliq](https://zoho.com/cliq) — Messagerie d’équipe avec 100 Go de stockage, utilisateurs illimités, 100 utilisateurs par canal & SSO.
   - [Campaigns](https://zoho.com/campaigns) - Email Marketing
   - [Forms](https://zoho.com/forms) - Créateur de formulaires
   - [Sign](https://zoho.com/sign) - Signatures électroniques
   - [Surveys](https://zoho.com/surveys) - Sondages en ligne
   - [Bookings](https://zoho.com/bookings) - Prise de rendez-vous
* [Maileroo](https://maileroo.com) - Relais SMTP et API email pour développeurs. 5 000 emails/mois, domaines illimités, vérification d’e-mail gratuite, surveillance de blacklist, testeur de mails et plus.

**[⬆️ Retour en haut](#table-of-contents)**

## Plateformes de gestion des Feature Toggles

* [ConfigCat](https://configcat.com) - Service de feature flag centré sur les développeurs avec taille d’équipe illimitée, excellent support et tarif raisonnable. Gratuit jusqu’à 10 flags, deux environnements, 1 produit, et 5 millions de requêtes/mois.
* [Flagsmith](https://flagsmith.com) - Déployez vos fonctionnalités en toute confiance ; gérez les feature flags sur web, mobile et applications serveur. Utilisez notre API hébergée, déployez sur votre cloud privé ou sur site.
* [GrowthBook](https://growthbook.io) - Fournisseur open source de feature flag et d’A/B testing, moteur d’analyse statistique bayésienne intégré. Gratuit jusqu’à 3 utilisateurs, flags et expériences illimités.
* [Hypertune](https://www.hypertune.com) - Feature flags typés, A/B testing, analytics et configuration d’app, avec gestion de versions style Git et évaluation locale synchrone, en mémoire. Gratuit jusqu’à 5 membres d’équipe, flags et A/B tests illimités.
* [Molasses](https://www.molasses.app) - Feature flags puissants et A/B testing. Gratuit jusqu’à 3 environnements avec cinq flags chacun.
* [Toggled.dev](https://www.toggled.dev) - Plateforme de gestion de feature toggles multi-régionale et prête pour l’entreprise. Gratuit jusqu’à 10 flags, deux environnements, requêtes illimitées. SDK, dashboard analytique, calendrier de release, notifications Slack et toutes autres fonctionnalités incluses dans le plan gratuit illimité.
* [Statsig](https://www.statsig.com) - Plateforme robuste de gestion des fonctionnalités, A/B testing, analytics et plus. Offre gratuite généreuse : sièges, flags, expériences et configurations dynamiques illimités, jusqu’à 1 million d’événements/mois.
* [Abby](https://www.tryabby.com) - Feature flags et A/B testing open source. Configuration as Code & SDK Typescript typés. Intégration forte avec Next.js & React. Offre gratuite généreuse et options de montée en charge économiques.

**[⬆️ Retour en haut](#table-of-contents)**

## Polices

* [dafont](https://www.dafont.com/) - Les polices présentées sur ce site sont la propriété de leurs auteurs et sont soit freeware, shareware, démos ou domaine public.
* [Everything Fonts](https://everythingfonts.com/) - Propose plusieurs outils ; @font-face, convertisseur d’unités, Font Hinter et soumission de police.
* [Font Squirrel](https://www.fontsquirrel.com/) - Polices gratuites sous licence pour un usage commercial. Sélectionnées à la main et présentées dans un format facile d’utilisation.
* [Google Fonts](https://fonts.google.com/) - Nombreuses polices gratuites faciles et rapides à installer sur un site via téléchargement ou lien CDN Google.
* [FontGet](https://www.fontget.com/) - Propose une variété de polices à télécharger, triées par tags.
* [Fontshare](https://www.fontshare.com/) - Service de polices gratuites. Collection croissante de polices professionnelles, 100% gratuites pour usage personnel et commercial.
* [Befonts](https://befonts.com/) - Fournit plusieurs polices uniques pour un usage personnel ou commercial.
* [Font of web](https://fontofweb.com/) - Identifiez toutes les polices utilisées sur un site web et leur usage.
* [Bunny](https://fonts.bunny.net) Polices orientées confidentialité, alternative à Google Fonts.
* [FontsKey](https://www.fontskey.com/) - Propose des polices gratuites ou payantes pour usage personnel et permet de filtrer rapidement le texte.
* [fonts.xz.style](https://fonts.xz.style/) service libre et open source pour la diffusion de familles de polices sur les sites web via CSS.
* [Fontsensei](https://fontsensei.com/) Google fonts open source taguées par les utilisateurs. Avec tags pour polices CJK (chinois, japonais, coréen).

**[⬆️ Retour en haut](#table-of-contents)**

## Formulaires

* [Feathery](https://feathery.io) - Générateur de formulaires puissant et adapté aux développeurs. Créez des formulaires d’inscription & connexion, onboarding utilisateur, paiements, applications financières complexes, etc. Le plan gratuit permet jusqu’à 250 soumissions/mois et cinq formulaires actifs.
* [Form-Data](https://form-data.com) - Backend de formulaires no-code. Filtre anti-spam, notification e-mail, auto-réponse, webhooks, zapier, redirections, AJAX ou POST, et plus. Le plan gratuit propose des formulaires illimités, 20 soumissions/mois, et 2000 soumissions supplémentaires avec badge Form-Data.
* [FabForm](https://fabform.io/) - Plateforme backend de formulaires pour développeurs intelligents. Plan gratuit : 250 soumissions/mois. Interface moderne conviviale. Intégrations Google Sheets, Airtable, Slack, Email, etc.
* [Form.taxi](https://form.taxi/) — Endpoint pour soumissions de formulaires HTML. Notifications, anti-spam, traitement des données conforme RGPD. Plan gratuit pour usage basique.
* [Formcarry.com](https://formcarry.com) - Endpoint HTTP POST pour formulaire. Plan gratuit : 100 soumissions mensuelles.
* [formingo.co](https://www.formingo.co/)- Formulaires HTML faciles pour sites statiques. Démarrez gratuitement sans compte. Plan gratuit : 500 soumissions/mois, adresse reply-to personnalisable.
* [FormKeep.com](https://www.formkeep.com/) - Formulaires illimités avec 50 soumissions/mois, protection anti-spam, notification e-mail, éditeur glisser-déposer exportant en HTML. Fonctions avancées : règles de champs personnalisées, équipes, intégrations Google Sheets, Slack, ActiveCampaign, Zapier.
* [formlets.com](https://formlets.com/) — Formulaires en ligne, nombre illimité de formulaires d’une page/mois, 100 soumissions/mois, notifications e-mail.
* [formspark.io](https://formspark.io/) -  Service de formulaire vers email, plan gratuit avec formulaires illimités, 250 soumissions/mois, support client inclus.
* [Formspree.io](https://formspree.io/) — Envoi d’e-mail via requête HTTP POST. Offre gratuite limitée à 50 soumissions par formulaire par mois.
* [Formsubmit.co](https://formsubmit.co/) — Endpoints simples pour vos formulaires HTML. Gratuit à vie. Pas d’inscription requise.
* [Formlick.com](https://formlick.com) - Alternative à Typeform avec offre à vie. 1 formulaire gratuit avec soumissions illimitées. Version premium : formulaires et soumissions illimités.
* [getform.io](https://getform.io/) - Backend de formulaire pour designers et développeurs, 1 formulaire, 50 soumissions, upload d’un fichier, 100 Mo de stockage.
* [HeroTofu.com](https://herotofu.com/) - Backend de formulaires avec détection de bots et archivage chiffré. Transfert des soumissions par interface vers email, Slack ou Zapier. Utilisez votre propre frontend. Aucun code serveur requis. Plan gratuit : formulaires illimités et 100 soumissions/mois.
* [HeyForm.net](https://heyform.net/) - Générateur de formulaires en ligne glisser-déposer. Offre gratuite : formulaires et soumissions illimités. Modèles préconçus, anti-spam, 100 Mo de stockage inclus.
* [Tally.so](https://tally.so/) - 99% des fonctionnalités sont gratuites. Offre gratuite : formulaires illimités, soumissions illimitées, notifications e-mail, logique de formulaire, paiements, upload de fichiers, page de remerciement personnalisée, etc.
* [Hyperforms.app](https://hyperforms.app/) — Créez un formulaire vers email et plus en quelques secondes, sans code backend. Compte personnel : 50 soumissions/mois gratuites.
* [Kwes.io](https://kwes.io/) - Endpoint de formulaire riche en fonctionnalités. Idéal pour sites statiques. Plan gratuit : 1 site avec 50 soumissions/mois.
* [Pageclip](https://pageclip.co/) - Plan gratuit : un site, un formulaire, 1 000 soumissions mensuelles.
* [Qualtrics Survey](https://qualtrics.com/free-account) — Créez des formulaires et sondages professionnels. 50+ modèles de sondage. Compte gratuit limité à 1 sondage actif, 100 réponses/survey & 8 types de réponses.
* [Screeb](https://screeb.app/) - Sondages in-app et analytics produits pour décoder le comportement utilisateur. Plan gratuit à vie : 500 utilisateurs actifs/mois, réponses et événements illimités, nombreuses intégrations, export et rapports périodiques.
* [smartforms.dev](https://smartforms.dev/) - Backend de formulaire puissant et simple pour votre site, plan gratuit à vie : 50 soumissions/mois, 250 Mo de stockage, intégration Zapier, export CSV/JSON, redirection personnalisée, page de réponse personnalisée, bot Telegram & Slack, notifications par email unique.
* [Survicate](https://survicate.com/) — Collectez des retours de toutes sources et envoyez des suivis avec un seul outil. Analyse automatique et extraction d’insights par IA. Sondages email, web, in-app ou mobile gratuits, création de sondages IA, 25 réponses/mois.
* [staticforms.xyz](https://www.staticforms.xyz/) - Intégrez facilement des formulaires HTML sans code serveur gratuitement. Après soumission, un email avec le contenu sera envoyé à votre adresse enregistrée.
* [stepFORM.io](https://stepform.io) - Générateur de quiz et formulaires. Plan gratuit : 5 formulaires, jusqu’à 3 étapes par formulaire, 50 réponses/mois.
* [Typeform.com](https://www.typeform.com/) — Formulaires au design soigné sur sites web. Plan gratuit : 10 champs/formulaire, 100 réponses/mois.
* [WaiverStevie.com](https://waiverstevie.com) - Plateforme de signature électronique avec API REST. Notifications via webhooks. Plan gratuit : filigrane sur documents signés mais enveloppes et signatures illimitées.
* [Web3Forms](https://web3forms.com) - Formulaires de contact pour sites statiques & JAMStack sans code backend. Offre gratuite : formulaires illimités, domaines illimités, 250 soumissions/mois.
  * [WebAsk](https://webask.io) - Créateur d'enquêtes et de formulaires. Le plan gratuit permet trois enquêtes par compte, 100 réponses mensuelles et dix éléments par enquête.
  * [Wufoo](https://www.wufoo.com/) - Formulaires rapides à utiliser sur les sites web. Le plan gratuit est limité à 100 soumissions par mois.
  * [formpost.app](https://formpost.app) - Service gratuit et illimité de Formulaire vers Email. Configurez gratuitement des redirections personnalisées, des réponses automatiques, des webhooks, etc.
  * [Formester.com](https://formester.com) - Partagez et intégrez des formulaires au design unique sur votre site web — aucun plafond sur le nombre de formulaires créés ni de fonctionnalités restreintes selon le plan. Jusqu’à 100 soumissions par mois gratuitement.
  * [SimplePDF.eu](https://simplepdf.eu/embed) - Intégrez un éditeur de PDF sur votre site web et transformez n’importe quel PDF en formulaire remplissable. Le plan gratuit autorise un nombre illimité de PDF avec trois soumissions par PDF.
  * [forms.app](https://forms.app/) — Créez des formulaires en ligne avec des fonctionnalités puissantes telles que la logique conditionnelle, le calculateur de score automatique et l’IA. Collectez jusqu’à 100 réponses avec un plan gratuit, intégrez vos formulaires sur un site web ou utilisez-les via un lien.
  * [Qualli](https://usequalli.com) - Enquêtes intégrées à l’application, conçues pour le mobile. Utilisez l’IA Qualli pour créer les questions parfaites. Essai gratuit jusqu’à 500 MAU, créez des formulaires et déclencheurs illimités.
  * [Sprig](https://sprig.com/) - 1 enquête in-app ou enquête avec replay par mois, avec analyse IA alimentée par GPT.
  * [feedback.fish](https://feedback.fish/) - Le plan gratuit permet de collecter 25 soumissions de retours au total. Facile à intégrer avec des composants React et Vue fournis.
  * [Vidhook](https://vidhook.io/) - Collectez des retours via des enquêtes attrayantes avec un taux de réponse élevé. Le plan gratuit inclut 1 enquête active, 25 réponses par enquête et des modèles personnalisables.

**[⬆️ Retour en haut](#table-of-contents)**

## IA Générative

  * [Zenable](https://zenable.io) - Corrigez instantanément les sorties d’outils comme Cursor, Windsurf et Copilot pour répondre aux normes de qualité et de conformité de votre entreprise grâce à des garde-fous construits avec Policy as Code. Le niveau gratuit inclut 100 appels outils par jour au serveur MCP et 25 revues automatisées de pull requests gratuites par jour via l’application GitHub.
  * [Keywords AI](https://keywordsai.co) - La meilleure plateforme de surveillance des LLM. Un format pour appeler plus de 200 LLM avec 2 lignes de code. 10 000 requêtes gratuites chaque mois et 0 $ pour les fonctionnalités de la plateforme !
  * [Portkey](https://portkey.ai/) - Tableau de bord pour applications Gen AI avec une suite d'observabilité et une passerelle IA. Envoyez et journalisez jusqu’à 10 000 requêtes gratuitement chaque mois.
  * [Braintrust](https://www.braintrustdata.com/) - Évaluations, bac à sable de prompts et gestion des données pour Gen AI. Le plan gratuit offre jusqu’à 1 000 lignes d’évaluation privées/semaine.
  * [Findr](https://www.usefindr.com/) - Recherche universelle permettant de rechercher dans toutes vos applications en une fois. Assistant de recherche capable de répondre à vos questions en utilisant vos informations. Le plan gratuit offre une recherche unifiée illimitée et 5 requêtes copilot quotidiennes.
  * [ReportGPT](https://ReportGPT.app) - Assistant d’écriture alimenté par l’IA. La plateforme entière est gratuite tant que vous utilisez votre propre clé API.
  * [Clair](https://askclair.ai/) - Référence clinique IA. Accès gratuit pour les étudiants à la suite professionnelle, incluant Open Search, Clinical Summary, Med Review, Interactions médicamenteuses, codes CIM-10 et Stewardship. Un essai gratuit de la suite professionnelle est également disponible.
  * [Langtrace](https://langtrace.ai) - Permet aux développeurs de tracer, évaluer, gérer les prompts et jeux de données, et déboguer les problèmes liés à la performance d’une application LLM. Crée des traces au standard open telemetry pour tout LLM, ce qui aide à l’observabilité et fonctionne avec n’importe quel client d’observabilité. Le plan gratuit propose 50 000 traces/mois.
  * [LangWatch](https://langwatch.ai) - Plateforme LLMOps aidant les équipes IA à mesurer, surveiller et optimiser les applications LLM pour la fiabilité, la rentabilité et la performance. Avec un composant DSPy puissant, permet une collaboration fluide entre ingénieurs et équipes non techniques pour affiner et industrialiser les produits GenAI. Le plan gratuit inclut toutes les fonctionnalités de la plateforme, 1k traces/mois et 1 workflow DSPy optimizer. [#opensource](https://github.com/langwatch/langwatch)
  * [Comet Opik](https://www.comet.com/site/products/opik/) - Évaluez, testez et livrez des applications LLM tout au long du cycle de développement et de production. [#opensource](https://github.com/comet-ml/opik/)
  * [Langfuse](https://langfuse.com/) - Plateforme d’ingénierie LLM open source qui aide les équipes à déboguer, analyser et itérer ensemble sur leurs applications LLM. Plan gratuit à vie incluant 50 000 observations par mois et toutes les fonctionnalités de la plateforme. [#opensource](https://github.com/langfuse/langfuse)
  * [Pollinations.AI](https://pollinations.ai/) - Générateur d’images IA facile à utiliser, gratuit, avec une API gratuite disponible. Pas d’inscription ni de clé API requise, plusieurs options d’intégration sur site ou dans un workflow. [#opensource](https://github.com/pollinations/pollinations)
  * [Othor AI](https://othor.ai/) - Alternative IA-native rapide, simple et sécurisée aux solutions de business intelligence populaires telles que Tableau, Power BI et Looker. Othor utilise des LLM pour fournir des solutions BI personnalisées en quelques minutes. Le plan Free Forever fournit un espace de travail avec cinq connexions de sources de données pour un utilisateur, sans limite d’analyses. [#opensource](https://github.com/othorai/othor.ai)
  * [OpenRouter](https://openrouter.ai/models?q=free) - Propose divers modèles IA gratuits, y compris DeepSeek R1, V3, Llama et Moonshot AI. Ces modèles excellent dans le traitement du langage naturel et conviennent à divers besoins de développement. À noter : bien que ces modèles soient gratuits, ils sont soumis à des limites de débit. OpenRouter propose également des modèles payants pour des besoins avancés, par exemple Claude, OpenAI, Grok, Gemini et Nova.

**[⬆️ Retour en haut](#table-of-contents)**

## CDN et Protection

  * [bootstrapcdn.com](https://www.bootstrapcdn.com/) — CDN pour bootstrap, bootswatch et fontawesome.io
  * [cdnjs.com](https://cdnjs.com/) — Simple. Rapide. Fiable. Diffusion de contenu à son meilleur. cdnjs est un service CDN gratuit et open source utilisé par plus de 11 % de tous les sites web, propulsé par Cloudflare.
  * [developers.google.com](https://developers.google.com/speed/libraries/) — Google Hosted Libraries est un réseau de distribution de contenu pour les bibliothèques JavaScript open source les plus populaires.
  * [Stellate](https://stellate.co/) - Stellate est un CDN ultra-rapide et fiable pour votre API GraphQL, gratuit pour deux services.
  * [jsdelivr.com](https://www.jsdelivr.com/) — Un CDN open source gratuit, rapide et fiable. Prend en charge npm, GitHub, WordPress, Deno, etc.
  * [Microsoft Ajax](https://docs.microsoft.com/en-us/aspnet/ajax/cdn/overview) — Le CDN Microsoft Ajax héberge des bibliothèques JavaScript tierces populaires telles que jQuery et vous permet de les ajouter facilement à votre application Web.
  * [ovh.ie](https://www.ovh.ie/ssl-gateway/) — Protection DDoS gratuite et certificat SSL gratuit
  * [Skypack](https://www.skypack.dev/) — CDN JavaScript 100 % module ES natif. Gratuit jusqu’à 1 million de requêtes par domaine et par mois.
  * [raw.githack.com](https://raw.githack.com/) — Remplacement moderne de **rawgit.com** qui héberge simplement des fichiers via Cloudflare
  * [section.io](https://www.section.io/) — Moyen simple de mettre en place et de gérer une solution Varnish Cache complète. Gratuit supposément à vie pour un site.
  * [statically.io](https://statically.io/) — CDN pour dépôts Git (GitHub, GitLab, Bitbucket), ressources WordPress et images
  * [toranproxy.com](https://toranproxy.com/) — Proxy pour Packagist et GitHub. CD jamais en échec. Gratuit pour usage personnel, un développeur, pas de support.
  * [UNPKG](https://unpkg.com/) — CDN pour tout ce qui est sur npm
  * [weserv](https://images.weserv.nl/) — Service de cache et redimensionnement d’images. Modifiez les images à la volée avec un cache mondial.
  * [Namecheap Supersonic](https://www.namecheap.com/supersonic-cdn/#free-plan) — Protection DDoS gratuite
  * [Gcore](https://gcorelabs.com/) Réseau mondial de diffusion de contenu, 1 To et 1 million de requêtes par mois gratuits, ainsi qu’un hébergement DNS gratuit
  * [CacheFly](https://portal.cachefly.com/signup/free2023) - Jusqu’à 5 To/mois de trafic CDN gratuit, 19 PoPs principaux, 1 domaine et SSL universel.

**[⬆️ Retour en haut](#table-of-contents)**

## PaaS

  * [anvil.works](https://anvil.works) - Développement d’applications web uniquement avec Python. Offre gratuite avec apps illimitées et timeouts de 30 secondes.
  * [appwrite](https://appwrite.io) - Projets illimités sans interruption (supporte websockets) et service d’authentification. 1 base de données, 3 buckets, 5 fonctions par projet sur le palier gratuit.
  * [configure.it](https://www.configure.it/) — Plateforme de développement d’applications mobiles, gratuite pour deux projets, fonctionnalités limitées mais pas de limites de ressources
  * [codenameone.com](https://www.codenameone.com/) — Chaîne d’outils de développement mobile open source, multiplateforme, pour développeurs Java/Kotlin. Gratuit pour un usage commercial avec un nombre illimité de projets
  * [deco.cx](https://www.deco.cx/en/dev) - Plateforme frontend native Edge avec CMS visuel auto-généré depuis le code TypeScript. A/B testing intégré, segmentation de contenu et analytics en temps réel. Parfait pour les sites e-commerce à fort contenu et les entreprises. Gratuit jusqu’à 5 000 pages vues/mois ou projets open source/personnels.
  * [Deno Deploy](https://deno.com/deploy) - Système distribué qui exécute JavaScript, TypeScript et WebAssembly à la périphérie dans le monde entier. Le niveau gratuit inclut 100 000 requêtes par jour et 100 Go de transfert de données par mois.
  * [domcloud.co](https://domcloud.co) – Service d’hébergement Linux avec CI/CD via GitHub, SSH et base MariaDB/Postgres. La version gratuite offre 1 Go de stockage, 1 Go de réseau/mois, limitée à un domaine gratuit.
  * [encore.dev](https://encore.dev/) — Framework backend utilisant l’analyse statique pour fournir une infrastructure automatique, un code sans boilerplate et plus. Inclut l’hébergement cloud gratuit pour les projets hobby.
  * [flightcontrol.dev](https://flightcontrol.dev/) - Déployez des services web, bases de données et plus sur votre propre compte AWS avec un workflow type Git push. Niveau gratuit pour les utilisateurs avec 1 développeur sur des dépôts GitHub personnels. Les coûts AWS sont facturés via AWS, mais vous pouvez utiliser des crédits et le niveau gratuit AWS.
  * [gigalixir.com](https://gigalixir.com/) - Gigalixir offre une instance gratuite qui ne dort jamais et une base PostgreSQL gratuite limitée à 2 connexions, 10 000 lignes et pas de sauvegardes pour les apps Elixir/Phoenix.
  * [Glitch](https://glitch.com/) — Hébergement public gratuit avec partage de code et collaboration en temps réel. Plan gratuit limité à 1 000 heures/mois.
  * [leapcell](https://leapcell.io/) - Plateforme d’applications distribuées fiable, fournissant tout le nécessaire pour accompagner votre croissance rapide. Le plan gratuit inclut 100k invocations de service, 10k tâches asynchrones et 100k commandes Redis.
  * [pipedream.com](https://pipedream.com) - Plateforme d’intégration conçue pour les développeurs. Développez tout workflow basé sur n’importe quel déclencheur. Les workflows sont du code que vous pouvez exécuter [gratuitement](https://docs.pipedream.com/pricing/). Aucun serveur ou ressource cloud à gérer.
  * [pythonanywhere.com](https://www.pythonanywhere.com/) — Hébergement cloud pour applications Python. Compte débutant gratuit, 1 application web Python sur le domaine your-username.pythonanywhere.com, 512 Mo de stockage privé, une base MySQL.
  * [ampt.dev](https://getampt.com/) - Ampt permet aux équipes de construire, déployer et scaler des apps JavaScript sur AWS sans configuration compliquée ni gestion d’infrastructure. Le plan Preview gratuit inclut 500 invocations par heure, 2 500 invocations par jour et 50 000 par mois. Les domaines personnalisés ne sont autorisés que sur les plans payants.
  * [Koyeb](https://www.koyeb.com) - Plateforme serverless conviviale pour déployer des apps dans le monde entier. Exécutez des conteneurs Docker, apps web et APIs avec déploiement via git, autoscaling natif, réseau edge global, service mesh et découverte intégrés. Instance gratuite pour déployer un service web à Francfort (Allemagne) ou Washington, D.C. (US). Base Postgres gratuite dispo à Francfort, Washington et Singapour. 512 Mo RAM, 2 Go stockage, 0,1 CPU.
  * [Napkin](https://www.napkin.io/) - FaaS avec 500 Mo de mémoire, timeout par défaut de 15 secondes et 5 000 appels API gratuits/mois, limités à 5 appels/seconde.
  * [Meteor Cloud](https://www.meteor.com/cloud) — Galaxy hosting. PaaS pour apps Meteor incluant hébergement MongoDB partagé gratuit et SSL automatique.
  * [Northflank](https://northflank.com) — Créez et déployez microservices, jobs et bases de données gérées via une interface puissante (UI, API & CLI). Mise à l’échelle fluide depuis le contrôle de version et registres Docker externes. Niveau gratuit avec deux services, deux cron jobs et 1 base.
  * [YepCode](https://yepcode.io) - Plateforme tout-en-un pour connecter APIs et services dans un environnement serverless. Apporte l’agilité du NoCode tout en permettant l’usage de langages de programmation. Le niveau gratuit inclut [1 000 yeps](https://yepcode.io/pricing/).
  * [WunderGraph](https://cloud.wundergraph.com) - Plateforme open source pour construire, déployer et gérer rapidement des APIs modernes. CI/CD intégré, intégration GitHub et HTTPS automatique. Jusqu’à 3 projets, 1 Go d’egress, 300 minutes de build par mois sur le [plan gratuit](https://wundergraph.com/pricing)
  * [Zeabur](https://zeabur.com) - Déployez vos services en un clic. Gratuit pour trois services, avec 5 $ US de crédits gratuits par mois.
  * [mogenius](https://mogenius.com) - Créez, déployez et exécutez facilement des services sur Kubernetes. Le niveau gratuit permet de connecter un Kubernetes local avec mogenius, permettant aux développeurs individuels de créer un environnement de test proche de la production sur leur machine.
  * [genezio](https://genezio.com/) - Fournisseur de fonctions serverless offrant 1 million d’appels de fonctions, 100 Go de bande passante et 10 cron jobs par mois gratuitement, exclusivement pour un usage non commercial ou académique.

**[⬆️ Retour en haut](#table-of-contents)**

## BaaS

  * [Activepieces](https://www.activepieces.com) - Construisez des flux d’automatisation pour connecter plusieurs applications entre elles dans le backend de votre application. Par exemple, envoyer un message Slack ou ajouter une ligne Google Sheet lors d’un événement dans votre application. Gratuit jusqu’à 5 000 tâches par mois.
  * [back4app.com](https://www.back4app.com) - Back4App est un backend facile à utiliser, flexible et évolutif basé sur la plateforme Parse.
  * [backendless.com](https://backendless.com/) — BaaS pour mobile et web, avec 1 Go de stockage de fichiers gratuit, notifications push jusqu’à 50 000/mois et 1 000 objets de données dans la table.
  * [bismuth.cloud](https://www.bismuth.cloud/) — Notre IA va générer votre API Python sur notre runtime de fonctions et stockage hébergé, construisez et hébergez gratuitement dans notre éditeur en ligne ou localement avec vos outils préférés.
  * [BMC Developer Program](https://developers.bmc.com/site/global/bmc_helix_platform/program/overview/index.gsp) — Le programme développeur BMC offre documentation et ressources pour concevoir et déployer des innovations numériques pour votre entreprise. Accès à un bac à sable personnel complet incluant la plateforme, le SDK et une bibliothèque de composants pour construire et adapter vos applications.
  * [connectycube.com](https://connectycube.com) - Messages de chat illimités, appels voix & vidéo p2p, pièces jointes et notifications push. Gratuit pour les apps jusqu’à 1 000 utilisateurs.
  * [convex.dev](https://convex.dev/) - Backend réactif en tant que service, hébergeant vos données (documents avec relations & transactions ACID sérialisables), fonctions serverless, et WebSockets pour diffuser les mises à jour à divers clients. Gratuit pour petits projets : jusqu’à 1M de records, 5M d’appels de fonction mensuels.
  * [darklang.com](https://darklang.com/) - Langage hébergé combinant éditeur et infrastructure. Accessible pendant la bêta, un niveau gratuit généreux est prévu après la bêta.
  * [Firebase](https://firebase.com) — Aide à construire et exploiter des applications performantes. Le plan Spark gratuit offre Authentification, Hébergement, Firebase ML, Realtime Database, Cloud Storage, Testlab. A/B Testing, Analytics, App Distribution, App Indexing, Cloud Messaging (FCM), Crashlytics, Dynamic Links, In-App Messaging, Performance Monitoring, Predictions et Remote Config sont toujours gratuits.
  * [Flutter Flow](https://flutterflow.io) — Construisez votre interface Flutter sans écrire une seule ligne de code. Intégration Firebase disponible. Le plan gratuit inclut l’accès complet au générateur d’interface et aux modèles gratuits.
  * [getstream.io](https://getstream.io/) — Construisez un chat intégré, de la messagerie, de la vidéo, de l’audio et des feeds à grande échelle en quelques heures plutôt qu’en semaines
  * [hasura.io](https://hasura.io/) — Hasura étend vos bases de données existantes où qu’elles soient hébergées et fournit une API GraphQL instantanée accessible en toute sécurité pour le web, le mobile et les intégrations de données. Gratuit pour 1 Go/mois de données transitant.
  * [nhost.io](https://nhost.io) - Backend serverless pour applications web et mobiles. Le plan gratuit inclut PostgreSQL, GraphQL (Hasura), Authentification, Stockage et Fonctions Serverless.
  * [onesignal.com](https://onesignal.com/) — Notifications push illimitées gratuites. 10 000 emails envoyés par mois, contacts illimités et accès à Auto Warm Up.
  * [paraio.com](https://paraio.com) — API de service backend avec authentification flexible, recherche plein texte et cache. Gratuit pour une app, 1 Go de données d’app.
  * [pubnub.com](https://www.pubnub.com/) — Notifications push gratuites jusqu'à 1 million de messages/mois et 100 appareils actifs quotidiens
  * [pushbots.com](https://pushbots.com/) — Service de notifications push. Gratuit jusqu'à 1,5 million de notifications/mois
  * [pushcrew.com](https://pushcrew.com/) — Service de notifications push. Notifications illimitées jusqu'à 2 000 abonnés
  * [pusher.com](https://pusher.com/beams) — Notifications push illimitées et gratuites pour 2 000 utilisateurs actifs mensuels. Une seule API pour appareils iOS et Android.
  * [quickblox.com](https://quickblox.com/) — Backend de communication pour messagerie instantanée, appels vidéo et vocaux, et notifications push
  * [restspace.io](https://restspace.io/) - Configurez un serveur avec des services pour l'authentification, les données, les fichiers, l'API email, les templates, et plus encore, puis composez-les en pipelines et transformez les données.
  * [Salesforce Developer Program](https://developer.salesforce.com/signup) — Développez des applications Lightning rapidement avec des outils glisser-déposer. Personnalisez votre modèle de données par clics. Allez plus loin avec le code Apex. Intégrez tout grâce à de puissantes API. Restez protégé avec une sécurité de niveau entreprise. Personnalisez l'interface utilisateur par clics ou avec n'importe quel framework web de pointe. Le Programme Développeur gratuit donne accès à toute la plateforme Lightning.
  * [simperium.com](https://simperium.com/) — Déplacez les données partout instantanément et automatiquement, multiplateforme, envoi et stockage illimités de données structurées, max. 2 500 utilisateurs/mois
  * [Supabase](https://supabase.com) — L’alternative open source à Firebase pour construire des backends. Le plan gratuit offre Authentification, Base de données en temps réel & Stockage d’objets.
  * [tyk.io](https://tyk.io/) — Gestion d’API avec authentification, quotas, monitoring et analytics. Offre cloud gratuite
  * [zapier.com](https://zapier.com/) — Connectez les applications que vous utilisez pour automatiser des tâches. Cinq zaps toutes les 15 minutes et 100 tâches/mois
  * [IFTTT](https://ifttt.com) — Automatisez vos applications et appareils préférés. Gratuit : 2 Applets
  * [Integrately](https://integrately.com) — Automatisez des tâches fastidieuses en un clic. Gratuit : 100 tâches, temps de mise à jour de 15 minutes, cinq automatisations actives, webhooks.
  * [LeanCloud](https://leancloud.app/) — Backend mobile. 1 Go de stockage de données, instance de 256 Mo, 3K requêtes API/jour, et 10K notifications push/jour gratuits. (API très similaire à Parse Platform)
  * [Claw.cloud](https://run.claw.cloud) - Plateforme PaaS offrant 5 $/mois de crédits gratuits pour les utilisateurs avec un compte GitHub de plus de 180 jours. Parfait pour héberger des applications, bases de données, et plus. ([Lien d'inscription avec crédit gratuit](https://ap-southeast-1.run.claw.cloud/signin)).


**[⬆️ Retour en haut](#table-of-contents)**

## Plateforme Low-code

  * [appsmith](https://www.appsmith.com/) — Projet low-code pour construire des panneaux d'administration, outils internes et tableaux de bord. S'intègre à plus de 15 bases de données et à n'importe quelle API.
  * [Basedash](https://www.basedash.com) — Plateforme low-code pour créer des panneaux d'administration internes et des tableaux de bord. Supporte les bases de données SQL et les APIs REST.
  * [BudiBase](https://budibase.com/) — Budibase est une plateforme open source low-code pour créer des applications internes en quelques minutes. Supporte PostgreSQL, MySQL, MSSQL, MongoDB, Rest API, Docker, K8s
  * [Clappia](https://www.clappia.com) — Plateforme low-code conçue pour créer des applications de gestion de processus métier avec des apps mobiles et web personnalisables. Offre une interface glisser-déposer, des fonctionnalités comme le support hors-ligne, le suivi de localisation en temps réel et l'intégration avec divers services tiers
  * [DronaHQ](https://www.dronahq.com/) — DronaHQ - une plateforme low-code qui aide les équipes d’ingénierie et les chefs de produit à créer des outils internes, des parcours utilisateurs personnalisés, des expériences digitales, de l’automatisation, des panneaux d’admin personnalisés, des applications opérationnelles 10 fois plus vite.
  * [lil'bots](https://www.lilbots.io/) - écrivez et exécutez des scripts en ligne en utilisant des API intégrées gratuites telles que OpenAI, Anthropic, Firecrawl et d'autres. Idéal pour créer des agents IA / outils internes et les partager avec l’équipe. Le niveau gratuit inclut un accès complet aux API, un assistant de codage IA et 10 000 crédits d’exécution / mois.
  * [Mendix](https://www.mendix.com/) — Développement rapide d'applications pour les entreprises, environnements sandbox accessibles illimités pour les utilisateurs, 0,5 Go de stockage et 1 Go de RAM par application. Les IDE Studio et Studio Pro sont également autorisés dans le niveau gratuit.
  * [outsystems.com](https://www.outsystems.com/) — PaaS de développement web d'entreprise sur site ou cloud, l'offre "environnement personnel" gratuit permet un code illimité et jusqu'à 1 Go de base de données
  * [ReTool](https://retool.com/) — Plateforme low-code pour construire des applications internes. Retool est hautement personnalisable. Si vous pouvez le coder en JavaScript et via une API, vous pouvez le faire dans Retool. Le niveau gratuit permet jusqu'à cinq utilisateurs par mois, applications et connexions API illimitées.
  * [Superblocks](https://superblocks.com/) — Plateforme d’applications d’entreprise ouverte conçue pour les développeurs et les équipes semi-techniques. Utilisez l’IA pour générer, éditer visuellement et étendre avec du code. Gouvernance centralisée avec intégrations, authentification, permissions & logs d’audit.
  * [ToolJet](https://www.tooljet.com/) — Framework extensible low-code pour créer des applications métier. Connectez-vous aux bases de données, stockages cloud, GraphQL, points d’API, Airtable, etc., et créez des applications avec le générateur glisser-déposer.
  * [UI Bakery](https://uibakery.io) — Plateforme low-code pour construire plus rapidement des applications web personnalisées. Permet de construire une UI par glisser-déposer avec une personnalisation poussée via JavaScript, Python et SQL. Disponible en solutions cloud et auto-hébergées. Gratuit jusqu’à 5 utilisateurs.
  * [manubes](https://www.manubes.com) - Plateforme cloud puissante no-code axée sur la gestion de production industrielle. Gratuit pour un utilisateur avec 1 million d'activités de workflow par mois ([également disponible en allemand](https://www.manubes.de)).

**[⬆️ Retour en haut](#table-of-contents)**

## Hébergement Web

  * [Alwaysdata](https://www.alwaysdata.com/) — 100 Mo d’hébergement web gratuit avec support de MySQL, PostgreSQL, CouchDB, MongoDB, PHP, Python, Ruby, Node.js, Elixir, Java, Deno, serveurs web personnalisés, accès via FTP, WebDAV et SSH ; boîte mail, liste de diffusion et installateur d’app inclus.
  * [Awardspace.com](https://www.awardspace.com) — Hébergement web gratuit + un domaine court gratuit, PHP, MySQL, installateur d’applications, envoi d’emails & sans pubs.
  * [Bohr](https://bohr.io) — Gratuit pour les projets non commerciaux + plateforme de déploiement et développement orientée développeur qui minimise la gestion d’infrastructure et accélère la mise en place.
  * [Bubble](https://bubble.io/) — Programmation visuelle pour créer des applications web et mobiles sans code, gratuit avec branding Bubble.
  * [dAppling Network](https://www.dappling.network/) - Plateforme d’hébergement web décentralisée pour les frontends Web3 axée sur l’augmentation du temps de disponibilité et la sécurité, fournissant un point d’accès supplémentaire aux utilisateurs.
  * [DigitalOcean](https://www.digitalocean.com/pricing) - Construisez et déployez trois sites statiques gratuitement sur le niveau App Platform Starter.
  * [Drive To Web](https://drv.tw) — Hébergez directement sur le web depuis Google Drive & OneDrive. Sites statiques uniquement. Gratuit à vie. Un site par compte Google/Microsoft.
  * [Fenix Web Server](https://preview.fenixwebserver.com) - Application de bureau pour développeur permettant d’héberger des sites localement et de les partager publiquement (en temps réel). Travaillez comme vous voulez, avec son interface utilisateur élégante, son API et/ou CLI.
  * [Fern](https://buildwithfern.com) - Créez et hébergez un site de documentation basé sur Markdown sur le plan gratuit de Fern. Vous pouvez même auto-générer une référence d’API pour votre site à partir de fichiers de définition d’API. Le site est hébergé sur _yoursite_.docs.buildwithfern.com.
  * [Free Hosting](https://freehostingnoads.net/) — Hébergement gratuit avec PHP 5, Perl, CGI, MySQL, FTP, gestionnaire de fichiers, email POP, sous-domaines gratuits, hébergement de domaine gratuit, éditeur de zone DNS, statistiques de site, support en ligne GRATUIT et de nombreuses autres fonctionnalités non offertes par d’autres hébergeurs gratuits.
  * [Freehostia](https://www.freehostia.com) — FreeHostia propose des services d’hébergement gratuits incluant un panneau de contrôle parmi les meilleurs du secteur & une installation en 1 clic de plus de 50 applications gratuites. Installation instantanée. Pas de pubs imposées.
  * [HelioHost](https://heliohost.org) — Hébergement web gratuit à but non lucratif avec panneau de contrôle Plesk, PHP, Node.js, Python, Django, Flask, .NET, Perl, CGI, MySQL, PostgreSQL, SQLite, email IMAP/POP3/SMTP, bande passante illimitée, sous-domaines gratuits, 1000 Mo de stockage gratuit avec possibilité de mise à niveau.
  * [Kinsta Static Site Hosting](https://kinsta.com/static-site-hosting/) — Déployez jusqu’à 100 sites statiques gratuitement, domaines personnalisés avec SSL, 100 Go de bande passante mensuelle, 260+ emplacements CDN Cloudflare.
  * [Lecturify](https://www.lecturify.net/index.en.html) - Hébergement web avec accès SFPT pour upload et download de fichiers, php disponible.
  * [Neocities](https://neocities.org) — Statique, 1 Go de stockage gratuit avec 200 Go de bande passante.
  * [Netlify](https://www.netlify.com/) — Construit, déploie et héberge un site/app statique gratuitement pour 100 Go de données et 100 Go/mois de bande passante.
  * [pantheon.io](https://pantheon.io/) — Hébergement Drupal et WordPress, DevOps automatisé et infrastructure scalable. Gratuit pour développeurs et agences. Pas de domaine personnalisé.
  * [readthedocs.org](https://readthedocs.org/) — Hébergement de documentation gratuit avec gestion des versions, génération PDF, et plus encore
  * [render.com](https://render.com) — Cloud unifié pour construire et exécuter apps et sites avec SSL gratuit, CDN mondial, réseaux privés, déploiements auto depuis Git, et plans totalement gratuits pour services web, bases de données et pages web statiques.
  * [SourceForge](https://sourceforge.net/) — Trouvez, créez et publiez des logiciels open source gratuitement
  * [surge.sh](https://surge.sh/) — Publication web statique pour développeurs Front-End. Sites illimités avec support de domaine personnalisé
  * [telegra.ph](https://telegra.ph/) Créez facilement une page web avec Quill
  * [tilda.cc](https://tilda.cc/) — Un site, 50 pages, 50 Mo de stockage, seulement les blocs principaux parmi 170+ disponibles, pas de polices, pas de favicon, pas de domaine personnalisé
  * [Vercel](https://vercel.com/) — Construisez, déployez et hébergez des applications web avec SSL gratuit, CDN mondial, et URL de prévisualisation unique à chaque `git push`. Parfait pour Next.js et autres générateurs de sites statiques.
  * [Versoly](https://versoly.com/) — Constructeur de site web orienté SaaS - sites illimités, 70+ blocs, cinq templates, CSS personnalisé, favicon, SEO et formulaires. Pas de domaine personnalisé.
  * [Qoddi](https://qoddi.com) - Service PaaS similaire à Heroku avec une approche centrée développeur et des fonctionnalités tout inclus. Niveau gratuit pour actifs statiques, staging et apps développeur.
  * [FreeFlarum](https://freeflarum.com/) - Hébergement Flarum gratuit alimenté par la communauté pour jusqu'à 250 utilisateurs (donnez pour enlever le watermark du pied de page).
  * [MDB GO](https://mdbgo.com/) - Hébergement gratuit pour un projet avec deux semaines de TTL container, 500 Mo de RAM par projet, SFTP - 1 Go d’espace disque.
  * [Patr Cloud](https://patr.cloud/) — Plateforme cloud facile à utiliser, parmi ses services payants elle propose d’héberger trois sites statiques gratuitement.
  * [Serv00.com](https://serv00.com/) — 3 Go d’hébergement web gratuit avec sauvegardes quotidiennes (7 jours). Support : tâches crontab, accès SSH, dépôts (GIT, SVN, Mercurial), support : MySQL, PostgreSQL, MongoDB, PHP, Node.js, Python, Ruby, Java, Perl, TCL/TK, Lua, Erlang, Rust, Pascal, C, C++, D, R, et bien d’autres.
  - [Sevalla](https://sevalla.com/) - Plateforme d’hébergement conçue pour simplifier le déploiement et la gestion d’applications, bases de données et sites statiques - limite de 1 Go par site, 100 Go de bande passante gratuite, 600 minutes de build gratuites, 100 sites par compte.

**[⬆️ Retour en haut](#table-of-contents)**

## DNS

  * [1.1.1.1](https://developers.cloudflare.com/1.1.1.1/) - Résolveur DNS public gratuit, rapide et sécurisé (chiffre vos requêtes DNS), fourni par Cloudflare. Utile pour contourner le blocage DNS de votre fournisseur internet, empêcher l’espionnage des requêtes DNS, et [bloquer les contenus adultes & malveillants](https://developers.cloudflare.com/1.1.1.1/1.1.1.1-for-families). Peut aussi être utilisé [via API](https://developers.cloudflare.com/1.1.1.1/encrypted-dns/dns-over-https/make-api-requests). Remarque : juste un résolveur DNS, pas un hébergeur DNS.
  * [1984.is](https://www.1984.is/product/freedns/) — Service DNS gratuit avec API et de nombreuses autres fonctionnalités gratuites incluses.
  * [cloudns.net](https://www.cloudns.net/) — Hébergement DNS gratuit jusqu'à 1 domaine avec 50 enregistrements
  * [deSEC](https://desec.io) - Hébergement DNS gratuit avec support API, conçu avec la sécurité en tête. Fonctionne sur logiciel open source et est soutenu par [SSE](https://www.securesystems.de/).
  * [dns.he.net](https://dns.he.net/) — Service d'hébergement DNS gratuit avec support DNS dynamique
  * [Zonomi](https://zonomi.com/) — Service d’hébergement DNS gratuit avec propagation instantanée. Offre gratuite : 1 zone DNS (nom de domaine) avec jusqu'à 10 enregistrements DNS.
  * [dnspod.com](https://www.dnspod.com/) — Hébergement DNS gratuit.
  * [duckdns.org](https://www.duckdns.org/) — DDNS gratuit avec jusqu'à 5 domaines sur le niveau gratuit. Avec guides de configuration pour divers environnements.
  * [Dynv6.com](https://dynv6.com/) — Service DDNS gratuit avec [support API](https://dynv6.com/docs/apis) et gestion de nombreux types d’enregistrements DNS (CNAME, MX, SPF, SRV, TXT, etc.).
  * [freedns.afraid.org](https://freedns.afraid.org/) — Hébergement DNS gratuit. Offre aussi des sous-domaines gratuits basés sur de nombreux domaines publics [contribués par les utilisateurs](https://freedns.afraid.org/domain/registry/). Obtenez des sous-domaines gratuits dans le menu "Subdomains" après inscription.
  * [luadns.com](https://www.luadns.com/) — Hébergement DNS gratuit, trois domaines, toutes fonctionnalités avec des limites raisonnables
  * [namecheap.com](https://www.namecheap.com/domains/freedns/) — DNS gratuit. Pas de limite sur le nombre de domaines
  * [nextdns.io](https://nextdns.io) - Pare-feu basé DNS, 300K requêtes gratuites par mois
  * [noip.at](https://noip.at/) — Service DDNS gratuit sans inscription, tracking, logs ni publicités. Pas de limite de domaines.
  * [noip](https://www.noip.com/) — service DDNS permettant jusqu'à 3 noms d’hôtes gratuits avec confirmation tous les 30 jours
  * [sslip.io](https://sslip.io/) — Service DNS gratuit qui, interrogé avec un nom d’hôte contenant une adresse IP, retourne cette IP.
  * [zilore.com](https://zilore.com/en/dns) — Hébergement DNS gratuit pour 5 domaines.
  * [zoneedit.com](https://www.zoneedit.com/free-dns/) — Hébergement DNS gratuit avec support DNS dynamique.
  * [zonewatcher.com](https://zonewatcher.com) — Sauvegardes automatiques et surveillance des changements DNS. Un domaine gratuit
  * [huaweicloud.com](https://www.huaweicloud.com/intl/en-us/product/dns.html) – Hébergement DNS gratuit par Huawei
  * [Hetzner](https://www.hetzner.com/dns-console) – Hébergement DNS gratuit par Hetzner avec support API.
  * [Glauca](https://docs.glauca.digital/hexdns/) – Hébergement DNS gratuit jusqu’à 3 domaines et support DNSSEC
  * [VolaryDDNS](https://volaryddns.net) - DDNS gratuit haute performance sans abonnements ni publicités
**[⬆️ Retour en haut](#table-of-contents)**

## Domaine

  * [pp.ua](https://nic.ua/) — Sous-domaines pp.ua gratuits.
  * [us.kg](https://nic.us.kg/) - Sous-domaines us.kg gratuits.

**[⬆️ Retour en haut](#table-of-contents)**

## IaaS

  * [4EVERLAND](https://www.4everland.org/) — Compatible avec AWS S3 - API, opérations via l’interface, CLI et autres méthodes de téléchargement, téléchargez et stockez des fichiers depuis les réseaux IPFS et Arweave de façon sûre, pratique et efficace. Les utilisateurs inscrits bénéficient de 6 Go de stockage IPFS et 300 Mo de stockage Arweave gratuitement. Tous les fichiers Arweave de moins de 150 Ko sont gratuits.
  * [backblaze.com](https://www.backblaze.com/b2/) — Stockage cloud Backblaze B2. 10 Go de stockage d’objets gratuit (type Amazon S3) sans limite de temps.
  * [filebase.com](https://filebase.com/) - Stockage d’objets compatible S3 propulsé par la blockchain. 5 Go de stockage gratuit sans limite de durée.
  * [Tebi](https://tebi.io/) - Stockage d’objets compatible S3. 25 Go de stockage et 250 Go de transfert sortant gratuits.
  * [Idrive e2](https://www.idrive.com/e2/) - Stockage d’objets compatible S3. 10 Go de stockage gratuit et 10 Go de bande passante de téléchargement par mois.
  * [C2 Object Storage](https://c2.synology.com/en-us/pricing/object-storage) - Stockage d’objets compatible S3. 15 Go de stockage gratuit et 15 Go de téléchargements par mois.

**[⬆️ Retour en haut](#table-of-contents)**

## Services de données managés

  * [Aiven](https://aiven.io/) - Aiven propose des plans gratuits pour PostgreSQL, MySQL et Redis sur sa plateforme de données open source. Nœud unique, 1 CPU, 1 Go de RAM, et pour PostgreSQL et MySQL, 5 Go de stockage. Migration facile vers des plans plus étendus ou multi-clouds.
  * [airtable.com](https://airtable.com/) — Ressemble à un tableur, mais c’est une base de données relationnelle : bases illimitées, 1 200 lignes/base, 1 000 requêtes API/mois.
  * [Astra](https://www.datastax.com/products/datastax-astra/) — Cassandra Cloud Native en tant que service avec [80 Go gratuits](https://www.datastax.com/products/datastax-astra/pricing)
  * [codehooks.io](https://codehooks.io/) — API/backend serverless JavaScript et service de base de données NoSQL facile à utiliser avec fonctions, requêtes type MongoDB, recherches clé/valeur, système de jobs, messages temps réel, files d’attente de travailleurs, CLI puissante et gestionnaire de données web. Plan gratuit avec 5 Go de stockage et 60 appels API/minute. 2 développeurs inclus. Sans carte bancaire.
  * [CrateDB](https://crate.io/) - Base de données SQL open source distribuée pour l’analytique temps réel. [Free Tier CRFREE](https://crate.io/lp-crfree) : Un nœud avec 2 CPU, 2 Go de mémoire, 8 Go de stockage. Un cluster par organisation, pas besoin de moyen de paiement.
  * [Upstash](https://upstash.com/) — Redis serverless avec niveau gratuit jusqu’à 10 000 requêtes/jour, 256 Mo max par base de données, et 20 connexions simultanées.
  * [Couchbase Capella](https://www.couchbase.com/products/capella/) - déployez gratuitement un cluster de base de données entièrement managé pour les développeurs, pour créer la prochaine génération d’applications de l’IoT à l’IA.
  * [MongoDB Atlas](https://www.mongodb.com/cloud/atlas) — niveau gratuit offrant 512 Mo.
  * [redsmin.com](https://www.redsmin.com/) — Service en ligne de surveillance et d’administration en temps réel pour Redis, surveillance gratuite pour une instance Redis.
  * [redislabs](https://redislabs.com/try-free/) - Instance Redis gratuite de 30 Mo.
  * [MemCachier](https://www.memcachier.com/) — Service Memcache managé. Gratuit jusqu’à 25 Mo, 1 serveur proxy, et analyses basiques.
  * [scalingo.com](https://scalingo.com/) — Principalement un PaaS mais propose un niveau gratuit de 128 Mo à 192 Mo pour MySQL, PostgreSQL ou MongoDB.
  * [SeaTable](https://seatable.io/) — Base de données flexible de type tableur développée par l’équipe Seafile. Tables illimitées, 2 000 lignes, versionnage sur un mois, jusqu’à 25 membres d’équipe.
  * [skyvia.com](https://skyvia.com/) — Plateforme de données cloud avec niveau gratuit, tous les plans sont gratuits en bêta.
  * [StackBy](https://stackby.com/) — Outil combinant la flexibilité des tableurs, la puissance des bases de données, et des intégrations natives avec vos applications métier. Le plan gratuit inclut utilisateurs illimités, dix piles, et 2 Go de pièces jointes par pile.
  * [TiDB Cloud](https://en.pingcap.com/tidb-cloud/) — TiDB est un SGBDR HTAP distribué open source compatible MySQL. TiDB Serverless offre 5 Go de stockage lignes, 5 Go stockage colonnes, et 50 millions d’unités de requêtes (RU) gratuites chaque mois.
  * [Turso by ChiselStrike](https://chiselstrike.com/) - Turso est l’expérience développeur SQLite dans une base de données Edge. Offre Free Forever, 9 Go de stockage total, jusqu’à 500 bases, 3 emplacements, 1 milliard de lectures de lignes/mois, support développement local avec SQLite.
  * [InfluxDB](https://www.influxdata.com/) — Base de données de séries temporelles, gratuit jusqu’à 3 Mo/5 minutes en écriture, 30 Mo/5 minutes en lecture et 10 000 séries cardinalités.
  * [restdb.io](https://restdb.io/) - Service cloud NoSQL rapide et simple. Avec restdb.io, vous avez schéma, relations, API REST automatique (avec requêtes type MongoDB), et une interface multi-utilisateur efficace pour gérer les données. Le plan gratuit permet 3 utilisateurs, 2 500 enregistrements et 1 requête API/seconde.
  * [CockroachDB Cloud](https://www.cockroachlabs.com/pricing/) — Niveau gratuit offrant 50 millions de RU et 10 Go de stockage (équivalent à 15 $) gratuits par mois. ([Qu’est-ce que les Request Units ?](https://www.cockroachlabs.com/docs/cockroachcloud/metrics-request-units.html))
  * [Neo4j Aura](https://neo4j.com/cloud/aura/) — SGBD natif graphique managé / plateforme analytique avec langage Cypher et API REST. Limites de taille du graphe (50k nœuds, 175k relations).
  * [Neon](https://neon.tech/) — PostgreSQL managé, 0,5 Go de stockage (total), 1 projet, 10 branches, bases illimitées, branche principale toujours disponible (suspension automatique après 5 minutes), 20h d’activité par mois (total) pour les branches non principales.
  * [Prisma Postgres](https://prisma.io/postgres) - PostgreSQL hébergé ultra rapide basé sur des unikernels sur bare metal, 1 Go de stockage, 10 bases, intégré à Prisma ORM.
  * [Dgraph Cloud](https://cloud.dgraph.io/pricing?type=free) — SGBD natif graphique managé avec API GraphQL. Limité à 1 Mo de transfert de données par jour.
  * [Tinybird](https://tinybird.co) - ClickHouse managé serverless avec ingestion sans connexion via HTTP et publication de requêtes SQL comme API HTTP managée. Pas de limite de temps pour le niveau gratuit, 10 Go de stockage + 1 000 requêtes API/jour.
  * [TigerGraph Cloud](https://www.tigergraph.com/cloud/) — SGBD graphique natif managé / plateforme analytique avec langage de requête graphique de type SQL et API REST. Une instance gratuite avec 2 vCPU, 8 Go de RAM et 50 Go de stockage qui se met en veille après 1h d’inactivité.
  * [TerminusCMS](https://terminusdb.com/pricing) — Service gratuit managé pour TerminusDB, base documentaire et graphique écrite en Prolog et Rust. Gratuit pour le dev, service payant pour déploiements entreprise et support.
  * [filess.io](https://filess.io) - filess.io est une plateforme où vous pouvez créer deux bases de données jusqu’à 10 Mo par base gratuitement parmi : MySQL, MariaDB, MongoDB, PostgreSQL.
  * [xata.io](https://xata.io) - Xata est une base de données serverless avec recherche et analyse intégrées. Une API, plusieurs bibliothèques client typées, optimisée pour le flux de travail de développement. Le niveau gratuit suffit pour les développeurs hobbyistes, avec trois unités Xata, voir la définition sur le site.
  * [8base.com](https://www.8base.com/) - 8base est une plateforme de développement low-code full-stack pour développeurs JavaScript, basée sur MySQL, GraphQL et un backend serverless. Permet de créer rapidement des applications web et de scaler facilement. Le niveau gratuit inclut : 2 500 lignes, 500 de stockage, 1 Go/h de calcul serverless, 5 utilisateurs client.
  * [Nile](https://www.thenile.dev/) — Plateforme Postgres pour applications B2B. Bases illimitées, toujours disponible sans extinction, 1 Go de stockage (total), 50 millions de tokens de requêtes, autoscaling, embeddings vectoriels illimités.



**[⬆️ Retour en haut](#table-of-contents)**

## Tunneling, WebRTC, serveurs Web Socket et autres routeurs

  * [Pinggy](https://pinggy.io) — URLs publiques pour localhost avec une seule commande, sans téléchargement requis. Tunnels HTTPS / TCP / TLS. Le plan gratuit offre des tunnels de 60 minutes.
  * [conveyor.cloud](https://conveyor.cloud/) — Extension Visual Studio pour exposer IIS Express au réseau local ou via un tunnel à une URL publique.
  * [Hamachi](https://www.vpn.net/) — LogMeIn Hamachi est un VPN hébergé permettant d’étendre en toute sécurité les réseaux de type LAN à des équipes distribuées, avec un plan gratuit permettant des réseaux illimités jusqu’à 5 personnes.
  * [Mirna Sockets](https://mirna.cloud/) - Plateforme Socket as a Service gratuite qui vous donne une URL wss:// lors du déploiement de votre code serveur Web Socket et permet de surveiller ses performances.
  * [localhost.run](https://localhost.run/) — Exposez des serveurs locaux via un tunnel vers une URL publique.
  * [localtunnel](https://theboroer.github.io/localtunnel-www/) — Exposez des serveurs locaux via un tunnel vers une URL publique. Version hébergée gratuite, et [open source](https://github.com/localtunnel/localtunnel).
  * [ngrok.com](https://ngrok.com/) — Exposez des serveurs locaux via un tunnel vers une URL publique.
  * [cname.dev](https://cname.dev/) — Service de proxy inverse dynamique gratuit et sécurisé.
  * [serveo](https://serveo.net/) — Exposez des serveurs locaux sur Internet. Pas d’installation, pas d’inscription. Sous-domaine gratuit, pas de limite.
  * [Radmin VPN](https://www.radmin-vpn.com/) — Connectez plusieurs ordinateurs ensemble via VPN pour créer un réseau de type LAN. Pairs illimités. (Alternative à Hamachi)
  * [segment.com](https://segment.com/) — Hub pour traduire et router des événements vers d’autres services tiers. 100 000 événements/mois gratuits.
  * Google STUN — [stun:stun.l.google.com:19302](stun:stun.l.google.com:19302)
  * Twilio STUN — [stun:global.stun.twilio.com:3478?transport=udp](stun:global.stun.twilio.com:3478?transport=udp)
  * [Tailscale](https://tailscale.com/) — VPN zéro configuration basé sur le protocole open source WireGuard. S’installe sur MacOS, iOS, Windows, Linux et Android. Plan gratuit pour usage personnel : 100 appareils, 3 utilisateurs.
  * [webhookrelay.com](https://webhookrelay.com) — Gérez, déboguez, diffusez et proxyfiez tous vos webhooks vers des destinations publiques ou internes (localhost). Exposez également les serveurs en réseau privé via un tunnel avec un point d’accès HTTP public (`https://yoursubdomain.webrelay.io <----> http://localhost:8080`).
  * [Hookdeck](https://hookdeck.com/pricing) — Développez, testez et surveillez vos webhooks partout. 100 000 requêtes et 100 000 tentatives/mois avec 3 jours de rétention.
  * [Xirsys](https://www.xirsys.com/pricing/) — Utilisation STUN illimitée + 500 Mo de bande passante TURN mensuelle, bande passante plafonnée, une seule région géographique.
  * [ZeroTier](https://www.zerotier.com) — Ethernet virtuel FOSS managé. Réseaux chiffrés de bout en bout illimités pour 25 clients sur le plan gratuit. Clients desktop/mobile/NA ; interface web pour configurer des règles de routage personnalisées et approuver de nouveaux nœuds clients sur réseaux privés.
  * [LocalXpose](https://localxpose.io) — Proxy inverse pour exposer vos serveurs locaux sur Internet. Le plan gratuit a une durée de tunnel de 15 minutes.
  * [Traefik-Hub](https://traefik.io/traefik-hub/) - Publiez vos services locaux via un tunnel vers une URL personnalisée publique et sécurisez-les avec un contrôle d’accès. Gratuit pour 5 services dans un cluster.
  * [Expose](https://expose.dev/) - Exposez des sites locaux via tunnels sécurisés. Le plan gratuit inclut un serveur UE, sous-domaines aléatoires, utilisateur unique.
  * [btunnel](https://www.btunnel.in/) — Exposez localhost et serveur TCP local sur Internet. Le plan gratuit inclut serveur de fichiers, en-têtes http personnalisés, protection basic auth et timeout de tunnel d’1 heure.

**[⬆️ Retour en haut](#table-of-contents)**

## Suivi des tickets et gestion de projet

  * [acunote.com](https://www.acunote.com/) — Logiciel gratuit de gestion de projet et SCRUM pour jusqu’à 5 membres d’équipe.
  * [asana.com](https://asana.com/) — Gratuit pour projet privé avec collaborateurs.
  * [Backlog](https://backlog.com) — Tout ce dont votre équipe a besoin pour livrer de super projets en une seule plateforme. Le plan gratuit offre 1 projet avec dix utilisateurs & 100 Mo de stockage.
  * [Basecamp](https://basecamp.com/personal) - Listes de tâches, gestion des jalons, messagerie façon forum, partage de fichiers, gestion du temps. Jusqu’à 3 projets, 20 utilisateurs et 1 Go d’espace de stockage.
  * [bitrix24.com](https://www.bitrix24.com/) — Intranet et gestion de projet. Plan gratuit avec 5 Go pour utilisateurs illimités.
  * [cacoo.com](https://cacoo.com/) — Diagrammes collaboratifs en ligne : organigrammes, UML, réseau. Gratuit max. 15 utilisateurs/diagramme, 25 feuilles.
  * [Chpokify](https://chpokify.com/) — Planning Poker pour équipes pour gagner du temps sur l’estimation de sprint. Gratuit jusqu’à 5 utilisateurs, intégrations Jira gratuites, appels vidéo illimités, équipes et sessions illimitées.
  * [clickup.com](https://clickup.com/) — Gestion de projet. Gratuit, version premium avec stockage cloud. Applis mobiles et intégrations Git disponibles.
  * [Clockify](https://clockify.me) - Suivi du temps et feuilles de temps pour suivre les heures de travail par projet. Utilisateurs illimités, gratuit à vie.
  * [Cloudcraft](https://cloudcraft.co/) — Créez des diagrammes d’architecture professionnelle en quelques minutes avec le designer visuel Cloudcraft, optimisé pour AWS avec composants intelligents affichant aussi des données live. Plan gratuit avec diagrammes privés illimités pour un utilisateur.
  * [Codegiant](https://codegiant.io) — Gestion de projet avec hébergement de dépôts & CI/CD. Plan gratuit : dépôts, projets & documents illimités, 5 membres, 500 minutes CI/CD/mois, 30 000 minutes d’exécution code serverless/mois, 1 Go de stockage dépôts.
  * [Confluence](https://www.atlassian.com/software/confluence) - L’outil collaboratif de contenu d’Atlassian pour aider les équipes à collaborer et partager leur savoir efficacement. Gratuit jusqu’à 10 utilisateurs.
  * [contriber.com](https://www.contriber.com/) — Plateforme de gestion de projet personnalisable, plan starter gratuit, cinq espaces de travail.
* [Crosswork](https://crosswork.app/) - Plateforme polyvalente de gestion de projet. Gratuit jusqu'à 3 projets, utilisateurs illimités, 1 Go de stockage.
  * [diagrams.net](https://app.diagrams.net/) — Diagrammes en ligne stockés localement sur Google Drive, OneDrive ou Dropbox. Gratuit pour toutes les fonctionnalités et tous les niveaux de stockage.
  * [freedcamp.com](https://freedcamp.com/) - tâches, discussions, jalons, suivi du temps, calendrier, fichiers et gestionnaire de mots de passe. Offre gratuite avec projets, utilisateurs et stockage de fichiers illimités.
  * [easyretro.io](https://www.easyretro.io/) — Outil simple et intuitif de rétrospective de sprint. Le plan gratuit comprend trois tableaux publics et un sondage par tableau et par mois.
  * [GForge](https://gforge.com) — Outil de gestion de projet et de suivi des problèmes pour projets complexes avec options sur site et SaaS. Le plan SaaS gratuit offre les cinq premiers utilisateurs gratuits & gratuit pour les projets Open Source.
  * [gleek.io](https://www.gleek.io) — Outil gratuit de génération de diagrammes à partir de descriptions pour développeurs. Créez des diagrammes informels UML de classes, objets ou entités-relationnels à partir de vos mots-clés.
  * [GraphQL Inspector](https://github.com/marketplace/graphql-inspector) - GraphQL Inspector affiche une liste des changements entre deux schémas GraphQL. Chaque différence est précisément expliquée et marquée comme étant majeure, mineure ou dangereuse.
  * [huboard.com](https://huboard.com/) — Gestion instantanée de projets pour vos issues GitHub, gratuit pour l'Open Source.
  * [Hygger](https://hygger.io) — Plateforme de gestion de projet. Le plan gratuit offre utilisateurs, projets & tableaux illimités avec 100 Mo de stockage.
  * [Instabug](https://instabug.com) — SDK complet de rapport de bugs et de feedback in-app pour applications mobiles. Gratuit jusqu'à 1 application et un membre.
  * [WishKit](https://wishkit.io) — Collectez les retours utilisateurs in-app pour votre app iOS/macOS et priorisez les fonctionnalités selon les votes utilisateurs. Gratuit jusqu'à 1 application.
  * [Ilograph](https://www.ilograph.com/)  — Diagrammes interactifs permettant de visualiser l'infrastructure sous plusieurs angles et niveaux de détail. Les graphiques peuvent être exprimés en code. L'offre gratuite permet des diagrammes privés illimités avec jusqu'à 3 spectateurs.
  * [Jira](https://www.atlassian.com/software/jira) — Outil avancé de gestion de projet de développement logiciel utilisé dans de nombreux environnements d'entreprise. Gratuit jusqu'à 10 utilisateurs.
  * [kanbanflow.com](https://kanbanflow.com/) — Gestion de projet basée sur des tableaux. Gratuit, version premium avec plus d'options.
  * [kanbantool.com](https://kanbantool.com/) — Gestion de projet basée sur des tableaux Kanban. Le plan gratuit comprend deux tableaux et deux utilisateurs, sans pièces jointes ni fichiers.
  * [kan.bn](https://kan.bn/) - Application kanban puissante et flexible pour organiser le travail, suivre la progression et livrer des résultats, tout en un seul endroit. Gratuit jusqu'à 1 utilisateur pour tableaux, listes et cartes illimités.
  * [Kitemaker.co](https://kitemaker.co) - Collaboration à toutes les phases du développement produit et suivi du travail via Slack, Discord, Figma et Github. Utilisateurs et espaces illimités. Gratuit jusqu'à 250 éléments de travail.
  * [Kiter.app](https://www.kiter.app/) - Permet à chacun d'organiser sa recherche d'emploi et de suivre entretiens, opportunités et contacts. Application web puissante et extension Chrome. Entièrement gratuit.
  * [Kumu.io](https://kumu.io/)  — Cartes de relations avec animation, décorations, filtres, regroupement, importation de feuilles de calcul, etc. Le niveau gratuit permet des projets publics illimités. Taille du graphe illimitée. Projets privés gratuits pour les étudiants. Mode bac à sable disponible si vous préférez ne pas laisser votre fichier en ligne (téléversement, édition, téléchargement, suppression).
  * [Linear](https://linear.app/) — Suivi des tickets avec interface épurée. Gratuit pour membres illimités, taille de fichier jusqu'à 10 Mo, 250 tickets (hors Archive).
  * [leiga.com](https://www.leiga.com/) — Leiga est un SaaS qui utilise l'IA pour gérer automatiquement vos projets, aidant votre équipe à rester concentrée et à libérer un immense potentiel, en assurant la progression conforme de vos projets. Gratuit jusqu'à 10 utilisateurs, 20 champs personnalisés, 2 Go d'espace de stockage, enregistrement vidéo avec IA limité à 5 min/vidéo, 20 automatisations/utilisateur/mois.
  * [Lucidchart](https://www.lucidchart.com/) - Outil de diagrammes en ligne avec fonctions de collaboration. Gratuit avec trois documents éditables, 100 modèles professionnels et fonctionnalités de collaboration de base.
  * [MeisterTask](https://www.meistertask.com/) — Gestion de tâches en ligne pour équipes. Gratuit jusqu'à 3 projets et membres illimités par projet.
  * [MeuScrum](https://www.meuscrum.com/en) - Outil Scrum en ligne gratuit avec tableau kanban.
  * [nTask](https://www.ntaskmanager.com/) — Logiciel de gestion de projet permettant à vos équipes de collaborer, planifier, analyser et gérer les tâches quotidiennes. Le plan essentiel est gratuit à vie avec 100 Mo de stockage et cinq utilisateurs/équipes. Espaces de travail, réunions, assignations, feuilles de temps et suivi des problèmes illimités.
  * [Ora](https://ora.pm/) - Gestion de tâches agile & collaboration d'équipe. Gratuit jusqu'à 3 utilisateurs, fichiers limités à 10 Mo.
  * [pivotaltracker.com](https://www.pivotaltracker.com/) — Gratuit pour projets publics illimités et deux projets privés avec trois utilisateurs actifs (lecture-écriture) et utilisateurs passifs illimités (lecture seule).
  * [plan.io](https://plan.io/) — Gestion de projet avec hébergement de dépôts et plus d'options. Gratuit pour deux utilisateurs avec dix clients et 500 Mo de stockage.
  * [Plane](https://plane.so/) - Outil simple, extensible et open source de gestion de projets et produits. Gratuit pour membres illimités, taille de fichier jusqu'à 5 Mo, 1000 tickets.
  * [planitpoker.com](https://www.planitpoker.com/) — Outil de planning poker (estimation) en ligne gratuit.
  * [point.poker](https://www.point.poker/) - Planning Poker en ligne (outil d'estimation par consensus). Gratuit pour utilisateurs, équipes, sessions, tours et votes illimités. Pas d'inscription requise.
  * [ScrumFast](https://www.scrumfast.com) - Tableau Scrum avec interface très intuitive, gratuit jusqu'à 5 utilisateurs.
  * [Shake](https://www.shakebugs.com/) - Outil de rapport de bugs et feedback in-app pour applications mobiles. Offre gratuite, dix rapports de bugs/app/mois.
  * [Shortcut](https://shortcut.com/) - Plateforme de gestion de projet. Gratuit jusqu'à 10 utilisateurs à vie.
  * [Tadum](https://tadum.app) - Application de gestion d'agenda et comptes-rendus de réunions récurrentes, gratuit pour équipes jusqu'à 10 membres.
  * [taiga.io](https://taiga.io/) — Plateforme de gestion de projet pour startups et développeurs agiles, gratuit pour l'Open Source.
  * [Tara AI](https://tara.ai/) — Service simple de gestion de sprints. Le plan gratuit propose tâches, sprints et espaces de travail illimités sans limite d'utilisateurs.
  * [targetprocess.com](https://www.targetprocess.com/) — Gestion visuelle de projet, du Kanban au Scrum et à presque tous les processus opérationnels. Gratuit pour utilisateurs illimités, jusqu'à 1 000 entités de données {[plus de détails](https://www.targetprocess.com/pricing/)}
  * [taskade.com](https://www.taskade.com/) — Listes de tâches collaboratives en temps réel et outline d'équipe. Le plan gratuit comprend un espace de travail avec tâches et projets illimités ; 1 Go de stockage ; 1 semaine d'historique ; cinq participants par réunion vidéo.
  * [taskulu.com](https://taskulu.com/) — Gestion de projet basée sur les rôles. Gratuit jusqu'à 5 utilisateurs. Intégration avec GitHub/Trello/Dropbox/Google Drive.
  * [Teaminal](https://www.teaminal.com) - Outil de standup, rétro et planification de sprint pour équipes à distance. Gratuit jusqu'à 15 utilisateurs.
  * [teamwork.com](https://teamwork.com/) — Gestion de projet & chat d'équipe. Gratuit pour cinq utilisateurs et deux projets. Plans premium disponibles.
  * [teleretro.com](https://www.teleretro.com/) — Outil de rétrospective simple et ludique avec icebreakers, gifs et emojis. Le plan gratuit inclut trois retros et membres illimités.
  * [testlio.com](https://testlio.com/) — Suivi des problèmes, gestion des tests et plateforme de bêta test. Gratuit pour usage privé.
  * [terrastruct.com](https://terrastruct.com/) — Créateur de diagrammes en ligne spécifiquement pour l'architecture logicielle. Niveau gratuit jusqu'à 4 couches par diagramme.
  * [todoist.com](https://todoist.com/) — Gestion de tâches collaborative ou individuelle. Le plan gratuit propose : 5 projets actifs, cinq utilisateurs par projet, téléversement de fichiers jusqu'à 5 Mo, trois filtres et une semaine d'historique d'activité.
  * [trello.com](https://trello.com/) — Gestion de projet basée sur des tableaux. Tableaux personnels illimités, 10 tableaux d'équipe.
  * [Tweek](https://tweek.so/) — Calendrier hebdomadaire de tâches simple & gestion de tâches.
  * [ubertesters.com](https://ubertesters.com/) — Plateforme de tests, intégration et crowd testers, 2 projets, cinq membres.
  * [Wikifactory](https://wikifactory.com/) — Service de conception de produits avec projets, VCS & gestion des issues. Le plan gratuit offre projets et collaborateurs illimités et 3 Go de stockage.
  * [Yodiz](https://www.yodiz.com/) — Développement agile et suivi des problèmes. Gratuit jusqu'à 3 utilisateurs, projets illimités.
  * [YouTrack](https://www.jetbrains.com/youtrack/buy/#edition=incloud) — YouTrack hébergé gratuit (InCloud) pour projets FOSS et privés (gratuit pour trois utilisateurs). Inclut le suivi du temps et les tableaux agiles.
  * [zenhub.com](https://www.zenhub.com) — La seule solution de gestion de projet intégrée à GitHub. Gratuit pour les repos publics, OSS et associations.
  * [zenkit.com](https://zenkit.com) — Outil de gestion de projet et de collaboration. Gratuit jusqu'à 5 membres, 5 Go de pièces jointes.
  * [Zube](https://zube.io) — Gestion de projet avec offre gratuite pour 4 projets & 4 utilisateurs. Intégration GitHub disponible.
  * [Toggl](https://toggl.com/) — Propose deux outils de productivité gratuits. [Toggl Track](https://toggl.com/track/) pour la gestion du temps et suivi avec un plan gratuit, suivi du temps et rapports illimités, conçu pour les freelances. Projets, clients, tags, rapports illimités et plus. Et [Toggl Plan](https://toggl.com/plan/) pour la planification de tâches, gratuit pour développeur solo avec tâches, jalons et timelines illimités.
  * [Sflow](https://sflow.io) — sflow.io est un outil de gestion de projet conçu pour le développement logiciel agile, le marketing, les ventes et le support client, notamment pour les projets d'externalisation et de collaboration inter-organisation. Gratuit jusqu'à 3 projets et cinq membres.
  * [Pulse.red](https://pulse.red) — Application gratuite minimaliste de suivi du temps et feuilles de temps pour projets.

**[⬆️ Retour en haut](#table-of-contents)**

## Stockage et traitement des médias

  * [AndroidFileHost](https://androidfilehost.com/) - Plateforme de partage de fichiers gratuite avec vitesse, bande passante, nombre de fichiers, nombre de téléchargements illimités, etc. Principalement destinée aux fichiers liés au développement Android comme les APK, ROMs personnalisées & modifications, etc. Mais semble accepter tout autre fichier également.
  * [borgbase.com](https://www.borgbase.com/) — Hébergement de sauvegarde externalisée simple et sécurisé pour Borg Backup. 10 Go d'espace de sauvegarde gratuit et deux dépôts.
  * [icedrive.net](https://www.icedrive.net/) - Service de stockage cloud simple. 10 Go de stockage gratuit.
  * [sync.com](https://www.sync.com/) - Service de stockage cloud de bout en bout. 5 Go de stockage gratuit.
  * [pcloud.com](https://www.pcloud.com/) - Service de stockage cloud. Jusqu'à 10 Go de stockage gratuit.
  * [sirv.com](https://sirv.com/) — CDN d’images intelligent avec optimisation et redimensionnement à la volée. Le plan gratuit comprend 500 Mo de stockage et 2 Go de bande passante.
  * [cloudimage.io](https://www.cloudimage.io/en/home) — Service complet d’optimisation d’images et CDN avec plus de 1500 points de présence dans le monde. Nombreuses fonctions de redimensionnement, compression et watermarking. Plugins open source pour images responsives, création d’images 360 et édition. Plan mensuel gratuit avec 25 Go de trafic CDN, 25 Go de cache et transformations illimitées.
  * [cloudinary.com](https://cloudinary.com/) — Téléversement d'images, manipulations puissantes, stockage et diffusion pour sites et apps, avec bibliothèques Ruby, Python, Java, PHP, Objective-C, etc. Le plan gratuit inclut 25 crédits mensuels. Un crédit équivaut à 1 000 transformations, 1 Go de stockage ou 1 Go d’utilisation CDN.
  * [embed.ly](https://embed.ly/) — Fournit des API pour intégrer des médias sur une page web, mise à l’échelle responsive des images, et extraction d’éléments d’une page. Gratuit jusqu’à 5 000 URLs/mois à 15 requêtes/seconde.
  * [filestack.com](https://www.filestack.com/) — Sélecteur de fichiers, transformation et diffusion, gratuit pour 250 fichiers, 500 transformations et 3 Go de bande passante.
  * [file.io](https://www.file.io) - 2 Go de stockage de fichiers. Un fichier est automatiquement supprimé après un téléchargement. API REST pour interagir avec le stockage. Limite d’une requête/minute.
  * [freetools.site](https://freetools.site/) — Outils en ligne gratuits. Convertir ou éditer documents, images, audio, vidéo et plus.
  * [GoFile.io](https://gofile.io/) - Plateforme gratuite de partage et stockage de fichiers utilisable via interface web & API. Taille de fichier, bande passante, nombre de téléchargements illimités, etc. Mais le fichier est supprimé s’il reste inactif (aucun téléchargement > 10 jours).
  * [gumlet.com](https://www.gumlet.com/) — Hébergement, traitement et diffusion d’images et vidéos via CDN. Offre gratuite généreuse de 250 Go/mois pour les vidéos et 30 Go/mois pour les images.
  * [image-charts.com](https://www.image-charts.com/) — Génération illimitée de graphiques images avec filigrane.
  * [Imgbot](https://github.com/marketplace/imgbot) — Imgbot est un robot sympathique qui optimise vos images et vous fait gagner du temps. Images optimisées = fichiers plus petits sans perte de qualité. Gratuit pour l’open source.
  * [ImgBB](https://imgbb.com/) — ImgBB est un service d’hébergement d’images illimité. Glissez-déposez vos images sur l’écran. Limite de 32 Mo/image. Lien direct, BBCode et vignettes HTML après upload. Connexion pour voir l’historique d’upload.
  * [imgen](https://www.jitbit.com/imgen/) - API gratuite de génération illimitée d’images de couverture réseaux sociaux, sans filigrane.
  * [imgix](https://www.imgix.com/) - Mise en cache, gestion et CDN d’images. Offre gratuite pour 1000 images d’origine, transformations infinies et 100 Go de bande passante.
  * [kraken.io](https://kraken.io/) — Optimisation d’images pour la performance web en SaaS, gratuit pour des fichiers jusqu’à 1 Mo.
  * [kvstore.io](https://www.kvstore.io/) — Service de stockage clé-valeur. Le plan gratuit permet 100 clés, 1 Ko/clé, 100 appels/heure.
  * [npoint.io](https://www.npoint.io/) — Stockage JSON avec édition collaborative de schémas.
  * [nitropack.io](https://nitropack.io/) - Accélérez la vitesse de votre site en autopilote avec optimisation frontale complète (cache, images et code, CDN). Gratuit jusqu’à 5 000 vues/mois.
  * [otixo.com](https://www.otixo.com/) — Chiffrez, partagez, copiez et déplacez tous vos fichiers cloud depuis un seul endroit. Le plan basique permet des transferts illimités avec fichiers max 250 Mo et cinq fichiers chiffrés.
  * [packagecloud.io](https://packagecloud.io/) — Dépôts d’hébergement de paquets pour YUM, APT, RubyGem et PyPI. Plans gratuits limités et plans open source disponibles sur demande.
  * [getpantry.cloud](https://getpantry.cloud/) — API simple de stockage de données JSON, idéale pour projets persos, hackathons et apps mobiles !
  * [Pinata IPFS](https://pinata.cloud) — Pinata est le moyen le plus simple d’uploader et gérer des fichiers sur IPFS. Son interface conviviale et son API IPFS en font le service de pinning IPFS le plus simple pour plateformes, créateurs et collectionneurs. 1 Go gratuit, accès à l’API inclus.
  * [placekitten.com](https://placekitten.com/) — Service rapide et simple pour obtenir des images de chatons à utiliser comme placeholders.
  * [plot.ly](https://plot.ly/) — Graphiquez et partagez vos données. Le plan gratuit inclut fichiers publics illimités et dix fichiers privés.
  * [podio.com](https://podio.com/) — Utilisable avec une équipe jusqu’à cinq personnes et test des fonctionnalités du plan Basic, sauf gestion des utilisateurs.
  * [QRME.SH](https://qrme.sh) - Générateur rapide et esthétique de QR codes en masse – pas de login, pas de filigrane, pas de pub. Jusqu’à 100 URLs par export en masse.
  * [QuickChart](https://quickchart.io) — Génération d’images de graphiques, diagrammes et QR codes intégrables.
  * [redbooth.com](https://redbooth.com) — Synchronisation P2P de fichiers, gratuit jusqu’à 2 utilisateurs.
  * [resmush.it](https://resmush.it) — reSmush.it est une API GRATUITE d’optimisation d’images. Compatible avec les CMS les plus répandus comme WordPress, Drupal ou Magento. Plus de 7 milliards d’images traitées, toujours 100% gratuit.
  * [Shotstack](https://shotstack.io) - API de génération et édition vidéo à grande échelle. Gratuit jusqu’à 20 minutes de vidéo générée/mois.
  * [tinypng.com](https://tinypng.com/) — API de compression et redimensionnement d’images PNG et JPEG, 500 compressions gratuites/mois.
  * [transloadit.com](https://transloadit.com/) — Gère les uploads et l’encodage de vidéo, audio, images, documents. Gratuit pour open source, associations et étudiants via le GitHub Student Developer Pack. Applications commerciales : 2 Go gratuits pour test.
  * [twicpics.com](https://www.twicpics.com) - Images réactives en tant que service. Il fournit un CDN d’images, une API de traitement des médias et une bibliothèque frontend pour automatiser l’optimisation des images. Le service est gratuit jusqu’à 3 Go de trafic/mois.
  * [uploadcare.com](https://uploadcare.com/hub/developers/) — Uploadcare propose une chaîne de traitement des médias avec une boîte à outils ultime basée sur des algorithmes de pointe. Toutes les fonctionnalités sont disponibles gratuitement pour les développeurs : API et UI de téléversement de fichiers, CDN d’images et services d’origine, livraison adaptative et compression intelligente. L’offre gratuite inclut 3 000 téléversements, 3 Go de trafic et 3 Go de stockage.
  * [imagekit.io](https://imagekit.io) – CDN d’images avec optimisation automatique, transformation en temps réel et stockage, intégrable à une configuration existante en quelques minutes. L’offre gratuite inclut jusqu’à 20 Go de bande passante par mois.
  * [internxt.com](https://internxt.com) – Internxt Drive est un service de stockage de fichiers « zero-knowledge » basé sur une confidentialité absolue et une sécurité sans compromis. Inscrivez-vous et obtenez 10 Go gratuits, à vie !
  * [degoo.com](https://degoo.com/) – Stockage cloud basé sur l’IA, gratuit jusqu’à 20 Go, trois appareils, bonus de parrainage de 5 Go (90 jours d’inactivité du compte).
  * [MConverter.eu](https://mconverter.eu/) – Conversion de fichiers en masse. Prend en charge de nombreux formats, y compris les nouveaux comme [AVIF](https://mconverter.eu/convert/to/avif/). Extraire toutes les images d’une vidéo. Gratuit jusqu’à dix fichiers de 100 Mo par jour, traités par lots de deux.
  * [ImageEngine](https://imageengine.io/) – ImageEngine est un CDN d’images global facile à utiliser. Mise en place en moins de 60 secondes. Prise en charge d’AVIF et JPEGXL, plugins WordPress, Magento, React, Vue et plus. Demandez votre compte développeur gratuit [ici](https://imageengine.io/developer-program/).
  * [DocsParse](https://docsparse.com/) – Traitement IA GPT de PDF, images, en données structurées aux formats JSON, CSV, EXCEL. 30 crédits gratuits chaque mois.
  * [VaocherApp QR Code Generator](https://www.vaocherapp.com/qr-code-generator) – Créez facilement des QR codes personnalisés pour cartes cadeaux, bons d’achat et promotions. Prise en charge du style, des couleurs, du logo personnalisés...
  * [LibreQR](https://libreqr.com) — Générateur de QR codes gratuit, axé sur la confidentialité et sans suivi. Gratuit à utiliser, aucune collecte de données.


**[⬆️ Retour en haut](#table-of-contents)**

## Design et UI

  * [AllTheFreeStock](https://allthefreestock.com) - une liste sélectionnée d’images, sons et vidéos libres de droits.
  * [Float UI](https://floatui.com/) - outil gratuit de développement web pour créer rapidement des sites modernes et responsives avec un design élégant, même sans être designer.
  * [Ant Design Landing Page](https://landing.ant.design/) - Ant Design Landing Page propose un modèle construit avec les composants d’animation d’Ant Motion. Il offre un riche modèle de page d’accueil, téléchargez le code du modèle, et utilisez-le rapidement. Vous pouvez aussi utiliser l’éditeur pour créer rapidement votre propre page dédiée.
  * [Backlight](https://backlight.dev/) — Plateforme de codage complète favorisant la collaboration entre développeurs et designers pour construire, documenter, publier, faire évoluer et maintenir des Design Systems. Le plan gratuit permet à 3 éditeurs de travailler sur un design system avec des visionneurs illimités.
  * [BoxySVG](https://boxy-svg.com/app) — Application Web gratuite installable pour dessiner des SVG et exporter en SVG, PNG, JPEG et autres formats.
  * [Carousel Hero](https://carouselhero.com/) - Outil en ligne gratuit pour créer des carrousels pour les réseaux sociaux.
  * [Circum Icons](https://circumicons.com) - Icônes open source cohérentes comme SVG pour React, Vue et Svelte.
  * [clevebrush.com](https://www.cleverbrush.com/) — Application gratuite de design graphique et collage photo. Propose aussi une intégration payante en tant que composant.
  * [cloudconvert.com](https://cloudconvert.com/) — Convertissez tout en tout. 208 formats pris en charge, y compris vidéos et gifs.
  * [CodeMyUI](https://codemyui.com) - Collection sélectionnée d’inspirations Web Design & UI avec extraits de code.
  * [ColorKit](https://colorkit.co/) - Créez des palettes de couleurs en ligne ou trouvez l’inspiration parmi les meilleures palettes.
  * [coolors](https://coolors.co/) - Générateur de palettes de couleurs. Gratuit.
  * [CMYK Pantone](https://www.cmyktopantone.com/) - Convertissez facilement des valeurs CMYK vers la couleur Pantone la plus proche et d’autres modèles de couleurs en quelques secondes, gratuitement.
  * [Branition](https://branition.com/colors) - Palettes de couleurs sélectionnées à la main, idéales pour les marques.
  * [css-gradient.com](https://www.css-gradient.com/) - Outil gratuit pour générer rapidement des dégradés CSS personnalisés compatibles tous navigateurs. En format RGB et HEX.
  * [easyvectors.com](https://easyvectors.com/) — Banque d’images vectorielles SVG gratuite. Téléchargez les meilleurs graphiques vectoriels totalement gratuitement.
  * [figma.com](https://www.figma.com) — Outil de design collaboratif en ligne pour équipes ; la formule gratuite inclut des fichiers et visionneurs illimités avec un maximum de 2 éditeurs et trois projets.
  * [Flyon UI](https://flyonui.com/)- La bibliothèque de composants la plus simple pour Tailwind CSS.
  * [framer.com](https://www.framer.com/) - Framer vous aide à itérer et animer vos idées d’interface pour votre prochaine app, site web ou produit, avec des mises en page puissantes. Pour tous ceux qui testent Framer comme outil de prototypage professionnel : visionneurs illimités, jusqu’à 2 éditeurs et 3 projets.
  * [freeforcommercialuse.net](https://freeforcommercialuse.net/) — FFCU Photos libres de droits modèles/propriété, sans souci.
  * [Gradientos](https://www.gradientos.app) - Rend le choix d’un dégradé rapide et facile.
  * [Icon Horse](https://icon.horse) – Obtenez le favicon en plus haute résolution pour n’importe quel site web via notre API simple.
  * [Iconoir](https://iconoir.com) – Bibliothèque d’icônes open source avec des milliers d’icônes, compatible React, React Native, Flutter, Vue, Figma et Framer.
  * [Icons8](https://icons8.com) — Icônes, illustrations, photos, musique et outils de design. Le plan gratuit offre des formats limités en basse résolution. Lien vers Icons8 requis lors de l’utilisation de nos ressources.
  * [landen.co](https://www.landen.co) — Générez, éditez et publiez de beaux sites web et landing pages pour votre startup, sans code. Le plan gratuit permet un site web, totalement personnalisable et publié en ligne.
  * [Quant Ux](https://quant-ux.com/) - Outil de prototypage et design. - Totalement gratuit et open source.
  * [lensdump.com](https://lensdump.com/) - Hébergement d’images cloud gratuit.
  * [Lorem Picsum](https://picsum.photos/) - Outil gratuit, facile à utiliser, pour générer des images de remplacement stylées. Ajoutez la taille d’image voulue (largeur & hauteur) à l’URL pour obtenir une image aléatoire.
  * [LottieFiles](https://lottiefiles.com/) - Plus grande plateforme en ligne au monde pour le plus petit format d’animation destiné aux designers, développeurs, etc. Accès à des outils et plugins Lottie pour Android, iOS et Web.
  * [MagicPattern](https://www.magicpattern.design/tools) — Collection de générateurs et d’outils CSS & SVG pour les fonds, dégradés, motifs et formes organiques.
  * [marvelapp.com](https://marvelapp.com/) — Design, prototypage et collaboration, plan gratuit limité à un utilisateur et un projet.
  * [Mindmup.com](https://www.mindmup.com/) — Cartes heuristiques illimitées gratuitement, stockées dans le cloud. Vos cartes sont accessibles partout, instantanément, depuis n’importe quel appareil.
  * [Mockplus iDoc](https://www.mockplus.com/idoc) - Outil puissant de collaboration et livraison de design. Plan gratuit incluant 3 utilisateurs et 5 projets, toutes fonctionnalités comprises.
  * [mockupmark.com](https://mockupmark.com/create/free) — Créez des mockups réalistes de t-shirts et vêtements pour réseaux sociaux et e-commerce, 40 mockups gratuits.
  * [Mossaik](https://mossaik.app) - Générateur d’images SVG gratuit avec différents outils comme vagues, formes et motifs.
  * [movingpencils.com](https://movingpencils.com) — Éditeur vectoriel rapide dans le navigateur. Entièrement gratuit.
  * [Octopus.do](https://octopus.do) — Générateur de sitemap visuel. Construisez la structure de votre site en temps réel et partagez-la facilement avec votre équipe ou vos clients.
  * [Pencil](https://github.com/evolus/pencil) - Outil de design open source basé sur Electron.
  * [Penpot](https://penpot.app) - Outil de design et prototypage open source, basé sur le web. Prend en charge le SVG. Totalement gratuit.
  * [pexels.com](https://www.pexels.com/) - Photos libres de droits pour usage commercial. Offre une API gratuite permettant la recherche de photos par mot-clé.
  * [photopea.com](https://www.photopea.com) — Éditeur de design en ligne gratuit et avancé avec interface type Adobe Photoshop, compatible PSD, XCF & Sketch (Adobe Photoshop, Gimp et Sketch App).
  * [pixlr.com](https://pixlr.com/) — Éditeur en ligne gratuit, aussi performant que les commerciaux.
  * [Plasmic](https://www.plasmic.app/) - Outil de design web et constructeur de pages rapide, facile à utiliser et robuste, intégré à votre code. Créez des pages responsives ou des composants complexes ; ajoutez du code si besoin ; publiez sur des sites et apps en production.
  * [Pravatar](https://pravatar.cc/) - Générez un avatar faux/aléatoire ou de remplacement dont l’URL peut être utilisée directement dans votre site/app.
  * [Proto.io](https://www.proto.io) - Créez des prototypes UI totalement interactifs sans code. Offre gratuite disponible après la période d’essai. Plan gratuit : un utilisateur, un projet, cinq prototypes, 100 Mo de stockage en ligne, aperçu de l’app proto.io.
  * [resizeappicon.com](https://resizeappicon.com/) — Service simple pour redimensionner et gérer vos icônes d’apps.
  * [Rive](https://rive.app) — Créez et exportez de belles animations sur toutes les plateformes. Gratuit à vie pour les particuliers. L’éditeur héberge aussi toutes les créations sur leurs serveurs. Fournit des runtimes pour de nombreuses plateformes pour exécuter les animations créées avec Rive.
  * [storyset.com](https://storyset.com/) — Créez d’incroyables illustrations personnalisées gratuites pour vos projets.
  * [smartmockups.com](https://smartmockups.com/) — Créez des mockups de produits, 200 mockups gratuits.
  * [Shadcn Studio](https://shadcnstudio.com/theme-editor) — Prévisualisez vos changements de thème à travers différents composants et mises en page.
  * [Tailark](https://tailark.com/) - Collection de blocs UI modernes, responsives et préconçus pour les sites marketing.
  * [tabler-icons.io](https://tabler-icons.io/) — Plus de 1500 icônes SVG éditables gratuites, copiables/collables.
  * [tweakcn](https://tweakcn.com/) — Beaux thèmes pour shadcn/ui. Personnalisez couleurs, typographie, et plus, en temps réel.
  * [UI Avatars](https://ui-avatars.com/) - Générez des avatars avec initiales à partir de noms. Les URLs peuvent être utilisées directement dans votre site/app. Prise en charge de paramètres de configuration via l’URL.
  * [unDraw](https://undraw.co/) - Collection constamment enrichie d’illustrations SVG magnifiques, utilisables gratuitement sans attribution.
  * [unsplash.com](https://unsplash.com/) - Photos libres de droits pour usage commercial et non commercial (licence do-whatever-you-want).
  * [vectr.com](https://vectr.com/) — Application gratuite de design pour Web et Desktop.
  * [walkme.com](https://www.walkme.com/) — Plateforme d’accompagnement et d’engagement de classe entreprise, plan gratuit avec trois guides de 5 étapes maximum chacun.
  * [Webflow](https://webflow.com) - Constructeur WYSIWYG de sites web avec animations et hébergement. Gratuit pour deux projets.
  * [Updrafts.app](https://updrafts.app) - Constructeur WYSIWYG de sites web pour designs basés sur tailwindcss. Gratuit pour un usage non commercial.
  * [whimsical.com](https://whimsical.com/) - Diagrammes de flux, wireframes, post-its et cartes heuristiques collaboratifs. Jusqu’à 4 tableaux gratuits.
  * [Zeplin](https://zeplin.io/) — Plateforme de collaboration designers-développeurs. Affichez designs, assets et guides de style. Gratuit pour un projet.
  * [Pixelixe](https://pixelixe.com/) — Créez et éditez des images et graphiques originaux en ligne.
  * [Responsively App](https://responsively.app) - Outil gratuit pour développer plus vite et avec précision des applications web responsives.
  * [SceneLab](https://scenelab.io) - Éditeur de graphismes mockup en ligne avec une collection grandissante de modèles gratuits.
  * [xLayers](https://xlayers.dev) - Prévisualisez et convertissez des fichiers Sketch en Angular, React, Vue, LitElement, Stencil, Xamarin et plus (gratuit et open source sur https://github.com/xlayers/xlayers)
  * [Grapedrop](https://grapedrop.com/) — Constructeur de pages web responsives, puissantes et optimisées SEO basé sur le framework GrapesJS. Gratuit pour les cinq premières pages, domaines personnalisés illimités, toutes fonctionnalités et simplicité d’utilisation.
  * [Mastershot](https://mastershot.app) - Éditeur vidéo dans le navigateur, totalement gratuit. Sans watermark, export jusqu’à 1080p.
  * [Unicorn Platform](https://unicornplatform.com/) - Constructeur de landing pages avec hébergement. Un site web gratuit.
  * [SVGmix.com](https://www.svgmix.com/) - Immense base de 300 000+ icônes SVG gratuites, collections et logos de marques. Petit éditeur vectoriel intégré au navigateur pour modifications rapides.
  * [svgrepo.com](https://www.svgrepo.com/) - Explorez et trouvez les meilleures icônes ou vecteurs pour vos projets via de multiples bibliothèques vectorielles. Téléchargement gratuit de SVGs pour usage commercial.
  * [haikei.app](https://www.haikei.app/) - Application web pour générer des formes, fonds et motifs SVG uniques – prêts à l’emploi dans vos outils et workflow de design.
  * [Canva](https://canva.com) - Outil de design en ligne gratuit pour créer du contenu visuel.
  * [Superdesigner](https://superdesigner.co) - Collection d’outils gratuits pour créer fonds, motifs, formes, images uniques en quelques clics.
  * [TeleportHQ](https://teleporthq.io/) - Plateforme collaborative low-code de design et développement front-end. Créez et publiez instantanément des sites statiques headless. Trois projets gratuits, collaborateurs illimités, export de code gratuit.
  * [vector.express](https://vector.express) — Convertissez rapidement et facilement vos fichiers AI, CDR, DWG, DXF, EPS, HPGL, PDF, PLT, PS et SVG.
  * [Vertopal](https://www.vertopal.com) - Plateforme gratuite de conversion de fichiers en ligne vers divers formats. Inclut des convertisseurs pour développeurs, ex. JPG en SVG, GIF en APNG, PNG en WEBP, JSON en XML, etc.
  * [okso.app](https://okso.app) - Application de dessin en ligne minimaliste. Permet de créer des croquis et notes visuelles rapides. Export en PNG, JPG, SVG et WEBP. Aussi installable en PWA. Gratuit pour tous (sans inscription).
  * [Wdrfree SVG](https://wdrfree.com/free-svg) - Fichiers SVG gratuits en noir et blanc pour découpe.
  * [Lucide](https://lucide.dev) - Boîte à outils d’icônes SVG gratuites, personnalisables et cohérentes.
  * [Logo.dev](https://www.logo.dev) - API de logos d’entreprise avec plus de 44M de marques, aussi simple qu’un appel d’URL. Les 10 000 premiers appels API sont gratuits.
  * [MDBootstrap](https://mdbootstrap.com/) - Kits UI Bootstrap, Angular, React et Vue gratuits pour usage personnel & commercial, avec plus de 700 composants, templates, installation 1 min, tutos complets et grande communauté.
  * [TW Elements](https://tw-elements.com/) - Composants Bootstrap gratuits recréés avec Tailwind CSS, au design amélioré et plus de fonctionnalités.
  * [DaisyUI](https://daisyui.com/) -- Gratuit. « Utilisez Tailwind CSS mais écrivez moins de classes » propose des composants comme boutons.
  * [Scrollbar.app](https://scrollbar.app) -- Application web gratuite et simple pour concevoir des barres de défilement personnalisées pour le web.
  * [css.glass](https://css.glass/) -- Application web gratuite pour créer des designs glassmorphiques en utilisant le CSS.
  * [hypercolor.dev](https://hypercolor.dev/) -- Une collection organisée de dégradés de couleurs Tailwind CSS, proposant également divers générateurs pour créer les vôtres.
  * [iconify.design](https://icon-sets.iconify.design/) -- Une collection de plus de 100 packs d’icônes avec une interface unifiée. Permet de rechercher des icônes parmi les packs et d’exporter des icônes individuelles en SVG ou pour les frameworks web populaires.
  * [NextUI](https://nextui.org/) -- Gratuit. Bibliothèque d’interface utilisateur React & Next.js belle, rapide et moderne.
  * [Glyphs](https://glyphs.fyi/) -- Gratuit, Les icônes les plus puissantes du Web, système de design totalement éditable et véritablement open source.
  * [ShadcnUI](https://ui.shadcn.com/) -- Composants superbement conçus que vous pouvez copier-coller dans vos applications. Accessible. Personnalisable. Open Source.
  * [HyperUI](https://www.hyperui.dev/) -- Composants Tailwind CSS Open Source gratuits.
  * [Calendar Icons Generator](https://calendariconsgenerator.app/) -- Générez toute une année d’icônes uniques en un clic, totalement GRATUIT
  * [Image BG Blurer](https://imagebgblurer.com/) -- Générez un cadre de fond flou pour une image, en utilisant la source de cette image comme fond flou, pour Notion, Trello, Jira et d’autres outils
  * [Webstudio](https://webstudio.is/) -- Alternative open-source à Webflow. Le plan gratuit propose un nombre illimité de sites web sur leur domaine. Cinq sites web avec des domaines personnalisés. Dix mille vues de pages/mois. 2 Go de stockage d’actifs.
  * [Nappy](https://nappy.co/) -- Belles photos de personnes noires et brunes, gratuites. Pour un usage commercial et personnel.
  * [Tailkits](https://tailkits.com/) -- Une collection organisée de modèles, composants et outils Tailwind, ainsi que des générateurs utiles pour le code, les grilles, les ombres portées, et plus.
  * [Tailcolors](https://tailcolors.com/) -- Une belle palette de couleurs Tailwind CSS v4. Prévisualisez instantanément et copiez la classe de couleur Tailwind CSS parfaite.
  * [Excalidraw](https://excalidraw.com/) -- Application de dessin en ligne gratuite avec sauvegarde locale et exportation gratuites.
  * [Lunacy](https://icons8.com/lunacy) -- Outil gratuit de design graphique avec support hors ligne, ressources intégrées (icônes, photos, illustrations), et collaboration en temps réel. Le niveau gratuit inclut 10 documents cloud, un historique de 30 jours, des ressources basse résolution et des outils de conception de base.

**[⬆️ Retour en haut](#table-of-contents)**

## Inspiration Design

  * [awwwards.](https://www.awwwards.com/) - [Meilleurs sites web] Une vitrine des meilleurs sites web designés (évalués par des designers).
  * [Behance](https://www.behance.net/) - [Vitrine de design] Un endroit où les designers exposent leur travail. Filtrable avec des catégories pour les projets UI/UX.
  * [dribbble](https://dribbble.com/) - [Vitrine de design] Inspiration design unique, généralement non issue d’applications réelles.
  * [Landings](https://landings.dev/) - [Captures d’écran web] Trouvez les meilleures pages d’atterrissage pour votre inspiration design selon vos préférences.
  * [Lapa Ninja](https://www.lapa.ninja/) - [Landing page / UI Kits / Captures d’écran web] Lapa Ninja est une galerie présentant les 6025 meilleurs exemples de landing pages, des livres gratuits pour designers et des UI kits gratuits du web.
  * [LovelyLanding.net](https://www.lovelylanding.net/) - [Design de landing pages] Captures d’écran de landing pages fréquemment mises à jour. Inclut des captures Desktop, Tablette et Mobile.
  * [Mobbin](https://mobbin.design/) - [Captures d’écran mobile] Gagnez des heures de recherche UI & UX avec notre bibliothèque de plus de 50 000 captures d’écran d’applications mobiles entièrement recherchables.
  * [Uiland Design](https://uiland.design/) - [Captures d’écran mobile] Explorez les designs d’interface mobile et web des plus grandes entreprises d’Afrique et du monde.
  * [Mobile Patterns](https://www.mobile-patterns.com/) - [Captures d’écran mobile] Bibliothèque d’inspiration présentant les meilleurs patterns UI/UX (iOS et Android) pour designers, développeurs et créateurs de produits.
  * [Page Flows](https://pageflows.com/) - [Vidéos et captures d’écran mobile/web] Vidéos de parcours complets à travers de nombreuses applications mobiles et web. Inclut aussi des captures d’écran. Très recherchable et indexé.
  * [Screenlane](https://screenlane.com/) - [Captures d’écran mobile] Trouvez l’inspiration et restez à jour sur les tendances UI design web & mobile. Filtrable par pattern et application.
  * [scrnshts](https://scrnshts.club/) - [Captures d’écran mobile] Collection soigneusement choisie des plus belles captures d’écran de designs d’applications.
  * [Refero](https://refero.design/) - [Captures d’écran web] Collection de références design étiquetées et recherchables provenant des meilleures applications web.


**[⬆️ Retour en haut](#table-of-contents)**

## Visualisation de données sur cartes

  * [IP Geolocation](https://ipgeolocation.io/) — Offre un plan DÉVELOPPEUR gratuit avec 30 000 requêtes/mois.
  * [carto.com](https://carto.com/) — Créez des cartes et des API géospatiales à partir de vos données et de données publiques.
  * [Clockwork Micro](https://clockworkmicro.com/) — Outils cartographiques qui fonctionnent comme une horloge. Cinquante mille requêtes gratuites par mois (tuiles de carte, db2vector, élévation).
  * [developers.arcgis.com](https://developers.arcgis.com) — API et SDK pour cartes, stockage de données géospatiales, analyse, géocodage, routage, etc. sur web, bureau et mobile. Deux millions de tuiles de base gratuites, 20 000 géocodages non stockés, 20 000 itinéraires simples, 5 000 calculs de temps de conduite et 5 Go de stockage tuiles+données par mois.
  * [Foursquare](https://developer.foursquare.com/) - Découverte de lieux, recherche de points d’intérêt et contenu contextuel via Places API et Pilgrim SDK.
  * [geoapify.com](https://www.geoapify.com/) - Tuiles cartographiques vectorielles et raster, géocodage, lieux, API de routage, isolines. Trois mille requêtes gratuites/jour.
  * [geocod.io](https://www.geocod.io/) — Géocodage via API ou upload CSV. Deux mille cinq cents requêtes gratuites/jour.
  * [geocodify.com](https://geocodify.com/) — Géocodage et géoparsing via API ou upload CSV. 10 000 requêtes gratuites/mois.
  * [geojs.io](https://www.geojs.io/) - API de recherche de géolocalisation IP REST/JSON/JSONP hautement disponible.
  * [giscloud.com](https://www.giscloud.com/) — Visualisez, analysez et partagez des données géographiques en ligne.
  * [graphhopper.com](https://www.graphhopper.com/) Un forfait développeur gratuit est proposé pour le routage, l’optimisation d’itinéraire, la matrice de distances, le géocodage et le map matching.
  * [here](https://developer.here.com/) — API et SDK pour cartes et applications géolocalisées. 250 000 transactions/mois gratuites.
  * [locationiq.com](https://locationiq.com/) — API de géocodage, cartes et routage. Cinq mille requêtes/jour gratuites.
  * [mapbox.com](https://www.mapbox.com/) — Services de cartographie, services géospatiaux et SDK pour l’affichage de données cartographiques.
  * [maptiler.com](https://www.maptiler.com/cloud/) — Cartes vectorielles, services cartographiques et SDK pour la visualisation de cartes. Tuiles vectorielles gratuites avec mises à jour hebdomadaires et quatre styles de carte.
  * [nominatim.org](https://nominatim.org/) — Service de géocodage gratuit d’OpenStreetMap, offrant la recherche d’adresses et le géocodage inverse à l’échelle mondiale.
  * [nextbillion.ai](https://nextbillion.ai/) - Services liés aux cartes : géocodage, navigation (direction, routage, optimisation d’itinéraire, matrice de distances), SDK Cartes (vectorielles, statiques, SDK mobile). [Gratuit avec quota spécifié](https://nextbillion.ai/pricing) pour chaque service.
  * [opencagedata.com](https://opencagedata.com) — API de géocodage agrégeant OpenStreetMap et d’autres sources ouvertes. Deux mille cinq cents requêtes gratuites/jour.
  * [osmnames](https://osmnames.org/) — Géocodage, résultats de recherche classés selon la popularité de la page Wikipédia liée.
  * [positionstack](https://positionstack.com/) - Géocodage gratuit pour les lieux et coordonnées du monde entier. 25 000 requêtes par mois pour usage personnel.
  * [stadiamaps.com](https://stadiamaps.com/) — Tuiles cartographiques, routage, navigation et autres API géospatiales. Deux mille cinq cents vues de carte et requêtes API gratuites/jour pour un usage non commercial et pour les tests.
  * [maps.stamen.com](http://maps.stamen.com/) - Tuiles de cartes gratuites et hébergement de tuiles.
  * [ipstack](https://ipstack.com/) - Localisez et identifiez les visiteurs d’un site web par adresse IP
  * [Geokeo api](https://geokeo.com) - API de géocodage avec correction linguistique et plus encore. Couverture mondiale. 2 500 requêtes gratuites par jour

**[⬆️ Retour en haut](#table-of-contents)**

## Système de construction de paquets

  * [build.opensuse.org](https://build.opensuse.org/) — Service de construction de paquets pour plusieurs distributions (SUSE, EL, Fedora, Debian, etc.).
  * [copr.fedorainfracloud.org](https://copr.fedorainfracloud.org) — Service de construction RPM basé sur Mock pour Fedora et EL.
  * [help.launchpad.net](https://help.launchpad.net/Packaging) — Service de construction pour Ubuntu et Debian.

**[⬆️ Retour en haut](#table-of-contents)**

## IDE et édition de code

  * [3v4l](https://3v4l.org/) - Shell PHP en ligne gratuit et site de partage de snippets, exécute votre code sur plus de 300 versions de PHP
  * [Android Studio](https://developer.android.com/studio) — Android Studio fournit les outils les plus rapides pour créer des applications sur tout type d’appareil Android. IDE Open Source gratuit pour tous et la meilleure solution de développement d’applications Android. Disponible pour Windows, Mac, Linux, et même ChromeOS !
  * [AndroidIDE](https://m.androidide.com/) — IDE Open Source pour développer de vraies applications Android basées sur Gradle, directement sur les appareils Android.
  * [Apache Netbeans](https://netbeans.apache.org/) — Environnement de développement, plateforme d’outils et framework applicatif.
  * [apiary.io](https://apiary.io/) — Conception collaborative d’API avec simulation instantanée et documentation générée (gratuit pour API illimitées, utilisateurs illimités avec un compte admin et documentation hébergée).
  * [BBEdit](https://www.barebones.com/) - BBEdit est un éditeur populaire et extensible pour macOS. Le mode gratuit fournit un [ensemble de fonctionnalités de base puissant](https://www.barebones.com/products/bbedit/comparison.html) et un chemin de mise à niveau vers des fonctions avancées.
  * [Binder](https://mybinder.org/) - Transformez un dépôt Git en une collection de notebooks interactifs. Service public gratuit.
  * [BlueJ](https://bluej.org) — Environnement de développement Java gratuit conçu pour les débutants, utilisé par des millions de personnes dans le monde. Propulsé par Oracle & interface simple pour aider les débutants.
  * [Bootify.io](https://bootify.io/) - Générateur d’applications Spring Boot avec base de données personnalisée et API REST.
  * [Brackets](http://brackets.io/) - Editeur de texte open-source spécialement conçu pour le développement web. Léger, facile à utiliser et hautement personnalisable.
  * [cacher.io](https://www.cacher.io) — Organisateur de snippets de code avec étiquettes et prise en charge de plus de 100 langages de programmation.
  * [Code::Blocks](https://codeblocks.org) — IDE gratuit pour Fortran & C/C++. Open Source et fonctionne sur Windows, macOS & Linux.
  * [Cody](https://sourcegraph.com/cody) - Assistant de codage IA gratuit qui peut écrire (blocs de code, autocomplétion, tests unitaires), comprendre (connaissance de toute votre base de code), corriger et trouver votre code. Disponible pour VS Code, JetBrains et en ligne.
  * [codiga.io](https://codiga.io/) — Assistant de codage permettant de rechercher, définir et réutiliser des snippets de code directement dans votre IDE. Gratuit pour les particuliers et petites organisations.
  * [codesnip.com.br](https://codesnip.com.br) — Gestionnaire simple de snippets de code avec catégories, recherche et tags. Gratuit et illimité.
  * [cocalc.com](https://cocalc.com/) — (anciennement SageMathCloud sur cloud.sagemath.com) — Calcul collaboratif dans le cloud. Accès navigateur à un Ubuntu complet avec collaboration intégrée et de nombreux logiciels libres pour les maths, la science, la data science, préinstallé : Python, LaTeX, Jupyter Notebooks, SageMath, scikitlearn, etc.
  * [code.cs50.io](https://code.cs50.io/) - Visual Studio Code pour CS50 est une application web adaptée des Codespaces GitHub pour les étudiants et enseignants.
  * [codepen.io](https://codepen.io/) — CodePen est un terrain de jeu pour le front-end web.
  * [codesandbox.io](https://codesandbox.io/) — Terrain de jeu en ligne pour React, Vue, Angular, Preact, et plus.
  * [Components.studio](https://webcomponents.dev/) - Développez des composants de code en isolation, visualisez-les dans des stories, testez-les et publiez-les sur npm.
  * [Eclipse Che](https://www.eclipse.org/che/) - IDE web et natif Kubernetes pour équipes de développeurs avec prise en charge multilangage. Open Source et orienté communauté. Une instance en ligne hébergée par Red Hat est disponible sur [workspaces.openshift.com](https://workspaces.openshift.com/).
  * [fakejson.com](https://fakejson.com/) — FakeJSON vous aide à générer rapidement de fausses données via son API. Faites une requête API décrivant ce que vous voulez et comment vous le voulez. L’API retourne tout en JSON. Accélérez le passage à l’action pour vos idées et faites semblant jusqu’à ce que vous réussissiez.
  * [GetVM](https://getvm.io) — Instanciez gratuitement des VM Linux et IDE dans une barre latérale Chrome. Le forfait gratuit inclut 5 VM par jour.
  * [GitPod](https://www.gitpod.io) — Environnements de développement instantanés, prêts à coder pour les projets GitHub. Le niveau gratuit inclut 50 heures/mois.
  * [ide.goorm.io](https://ide.goorm.io) goormIDE est un IDE complet dans le cloud. Prise en charge multilingue, conteneur basé sur Linux via un terminal web complet, redirection de port, URL personnalisée, collaboration en temps réel et chat, partage de lien, support Git/Subversion. De nombreuses autres fonctionnalités sont disponibles (le niveau gratuit inclut 1 Go de RAM et 10 Go de stockage par conteneur, 5 emplacements de conteneur).
  * [JDoodle](https://www.jdoodle.com) — Compilateur et éditeur en ligne pour plus de 60 langages de programmation avec un plan gratuit pour la compilation de code via l’API REST jusqu’à 200 crédits par jour.
  * [jetbrains.com](https://jetbrains.com/products.html) — Outils de productivité, IDE et outils de déploiement (par exemple [IntelliJ IDEA](https://www.jetbrains.com/idea/), [PyCharm](https://www.jetbrains.com/pycharm/), etc). Licence gratuite pour les étudiants, enseignants, projets Open Source et groupes d’utilisateurs.
  * [jsbin.com](https://jsbin.com) — JS Bin est un autre bac à sable et site de partage de code pour le web front-end (HTML, CSS et JavaScript. Prend également en charge Markdown, Jade et Sass).
  * [jsfiddle.net](https://jsfiddle.net/) — JS Fiddle est un bac à sable et site de partage de code pour le web front-end, supportant la collaboration.
  * [JSONPlaceholder](https://jsonplaceholder.typicode.com/) Quelques points de terminaison d'API REST qui renvoient de fausses données au format JSON. Le code source est également disponible si vous souhaitez exécuter le serveur localement.
  * [Lazarus](https://www.lazarus-ide.org/) — Lazarus est un IDE multiplateforme compatible Delphi pour le développement rapide d'applications.
  * [MarsCode](https://www.marscode.com/) - Un IDE basé sur le cloud, alimenté par l’IA, gratuit.
  * [micro-jaymock](https://micro-jaymock.now.sh/) - Microservice de mock d’API minuscule pour générer de fausses données JSON.
  * [mockable.io](https://www.mockable.io/) — Mockable est un service simple et configurable pour simuler des API RESTful ou des services web SOAP. Ce service en ligne permet de définir rapidement des points de terminaison API REST ou SOAP et de faire retourner des données JSON ou XML.
  * [mockaroo](https://mockaroo.com/) — Mockaroo permet de générer des données de test réalistes aux formats CSV, JSON, SQL et Excel. Vous pouvez également créer des mocks pour les API back-end.
  * [Mocklets](https://mocklets.com) - Simulateur de mock d’API HTTP qui aide à simuler des APIs pour un développement parallèle plus rapide et des tests plus complets, avec un niveau gratuit à vie.
  * [Paiza](https://paiza.cloud/en/) — Développez des applications web dans le navigateur sans rien configurer. Le plan gratuit offre un serveur avec une durée de vie de 24 heures et 4 heures d'exécution par jour avec 2 cœurs CPU, 2 Go de RAM et 1 Go de stockage.
  * [Prepros](https://prepros.io/) - Prepros peut compiler Sass, Less, Stylus, Pug/Jade, Haml, Slim, CoffeeScript, et TypeScript dès l’installation, recharge les navigateurs et facilite le développement & le test de vos sites web pour que vous puissiez vous concentrer sur leur perfection. Vous pouvez également ajouter vos propres outils en quelques clics.
  * [Replit](https://replit.com/) — Un environnement de codage cloud pour divers langages de programmation.
  * [SoloLearn](https://code.sololearn.com) — Un terrain de jeu cloud pour la programmation, bien adapté à l’exécution de snippets de code. Prend en charge divers langages de programmation. Aucune inscription requise pour exécuter du code, mais nécessaire pour sauvegarder du code sur leur plateforme. Propose également des cours gratuits pour débutants et intermédiaires.
  * [stackblitz.com](https://stackblitz.com/) — IDE en ligne/cloud pour créer, éditer et déployer des apps full-stack. Prend en charge tous les frameworks NodeJs populaires, front-end & back-end. Lien court pour créer un nouveau projet : [https://node.new](https://node.new).
  * [Sublime Text](https://www.sublimetext.com/) - Sublime Text est un éditeur de texte populaire, polyvalent et hautement personnalisable utilisé pour la programmation et l’édition de texte.
  * [Visual Studio Code](https://code.visualstudio.com/) - Éditeur de code redéfini et optimisé pour construire et déboguer des applications web et cloud modernes. Développé par Microsoft.
  * [Visual Studio Community](https://visualstudio.microsoft.com/vs/community/) — IDE complet avec des milliers d’extensions, développement d’applications multiplateformes (extensions Microsoft disponibles pour iOS et Android), développement desktop, web et cloud, prise en charge de nombreux langages (C#, C++, JavaScript, Python, PHP, etc.).
  * [VSCodium](https://vscodium.com/) - Distribution binaire de l’éditeur VSCode de Microsoft, communautaire, sans télémétrie/traçage et sous licence libre.
  * [wakatime.com](https://wakatime.com/) — Métriques quantifiées sur votre activité de codage via des plugins d’éditeurs de texte, plan gratuit limité.
  * [Wave Terminal](https://waveterm.dev/) - Wave est un terminal open-source et multiplateforme pour des workflows fluides. Affichez tout en ligne. Sauvegardez sessions et historique. Basé sur les standards web ouverts. MacOS et Linux.
  * [WebComponents.dev](https://webcomponents.dev/) — IDE dans le navigateur pour coder des web components en isolation avec 58 modèles disponibles, supporte les histoires et les tests.
  * [PHPSandbox](https://phpsandbox.io/) — Environnement de développement en ligne pour PHP
  * [WebDB](https://webdb.app) - IDE de base de données gratuit et efficace. Comprend la découverte de serveur, ERD, générateur de données, IA, gestionnaire de structure NoSQL, versionnage de base de données, et bien plus.
  * [Zed](https://zed.dev/) - Zed est un éditeur de code performant et collaboratif, créé par les auteurs d’Atom et Tree-sitter.
  * [OneCompiler](https://onecompiler.com/) - Compilateur en ligne gratuit prenant en charge plus de 70 langages, dont Java, Python, C++, JavaScript.


**[⬆️ Retour en haut](#table-of-contents)**

## Analytique, Événements et Statistiques

  * [Dwh.dev](https://dwh.dev) - Solution d'observabilité Data Cloud (Snowflake). Gratuit pour un usage personnel.
  * [Hightouch](https://hightouch.com/) - Plateforme Reverse ETL qui vous aide à synchroniser les données clients de votre data warehouse vers vos outils CRM, marketing et support. Le niveau gratuit offre une destination de synchronisation.
  * [Avo](https://avo.app/) — Workflow simplifié de publication analytique. Plan de suivi unique, bibliothèque de tracking analytique type-safe, débogueurs intégrés et observabilité des données pour détecter tous les problèmes avant la mise en production. Gratuit pour deux membres d’espace de travail et 1h de lookback sur l’observabilité des données.
  * [Branch](https://www.branch.io) — Plateforme d'analytique mobile. Le niveau gratuit offre jusqu'à 10K utilisateurs d'app mobile avec deep-linking et autres services.
  * [Census](https://www.getcensus.com/) — Plateforme Reverse ETL & analytique opérationnelle. Synchronise 10 champs de votre data warehouse vers 60+ SaaS comme Salesforce, Zendesk ou Amplitude.
  * [Clicky](https://clicky.com) — Plateforme d'analytique de site web. Plan gratuit pour un site web avec 3000 vues analytiques.
  * [Databox](https://databox.com) — Insights et analytique d’entreprise en combinant d’autres plateformes d’analytique & BI. Plan gratuit offrant 3 utilisateurs, tableaux de bord & sources de données. 11M d’enregistrements historiques.
  * [Hitsteps.com](https://hitsteps.com/) — 2 000 pages vues par mois pour 1 site web
  * [amplitude.com](https://amplitude.com/) — 1 million d’événements mensuels, jusqu’à 2 apps
  * [GoatCounter](https://www.goatcounter.com/) — GoatCounter est une plateforme d’analytique web open-source disponible en service hébergé (gratuit pour usage non-commercial) ou en application auto-hébergée. Elle vise à offrir une analytique web simple, significative et respectueuse de la vie privée en alternative à Google Analytics ou Matomo. Le niveau gratuit est destiné à un usage non-commercial et inclut des sites illimités, six mois de conservation des données, et 100k pages vues/mois.
  * [Google Analytics](https://analytics.google.com/) — Google Analytics
  * [MetricsWave](https://metricswave.com) — Alternative à Google Analytics respectueuse de la vie privée pour les développeurs. Plan gratuit pour 20k pages vues par mois sans carte bancaire.
  * [Expensify](https://www.expensify.com/) — Reporting de dépenses, workflow d’approbation personnel gratuit
  * [getinsights.io](https://getinsights.io) - Analytique sans cookies et centrée sur la vie privée, gratuit jusqu'à 3k événements/mois.
  * [heap.io](https://heap.io) — Capture automatique de chaque action utilisateur sur les apps iOS ou web. Gratuit jusqu’à 10K sessions mensuelles.
  * [Hotjar](https://hotjar.com) — Analytique et rapports pour sites web. Plan gratuit permettant 2000 pages vues/jour. Cent captures instantanées/jour (capacité max : 300). Trois heatmaps peuvent être stockées pendant 365 jours. Membres illimités. Enquêtes et widgets de feedback avec captures d’écran, en app et indépendants. Le niveau gratuit permet de créer 3 enquêtes et 3 widgets de feedback et de collecter 20 réponses par mois.
  * [Keen](https://keen.io/) — Analytique personnalisée pour la collecte, l’analyse et la visualisation de données. 1 000 événements/mois gratuits
  * [Yandex.Datalens](https://datalens.yandex.com/) — Service Yandex Cloud de visualisation et d’analyse de données. Service gratuit, sans limitation du nombre d’utilisateurs ou de requêtes.
  * [Yandex.Metrica](https://metrica.yandex.com/) — Analytique gratuite illimitée
  * [Mixpanel](https://mixpanel.com/) — 100 000 utilisateurs suivis par mois, historique de données et utilisateurs illimités, résidence des données US ou UE
  * [Moesif](https://www.moesif.com) — Analytique API pour REST et GraphQL. (Gratuit jusqu’à 500 000 appels API/mois)
  * [optimizely.com](https://www.optimizely.com) — Solution de test A/B, plan de démarrage gratuit, un site web, 1 app iOS et 1 app Android
  * [Microsoft PowerBI](https://powerbi.com) — Insights et analytique d’entreprise par Microsoft. Plan gratuit avec utilisation limitée à 1 million de licences utilisateur.
  * [Row Zero](https://rowzero.io) - Tableur connecté et ultra-rapide. Connectez-vous directement à des bases de données, S3 et API. Importez, analysez, graphiez et partagez instantanément des millions de lignes. Trois classeurs gratuits (à vie).
  * [sematext.com](https://sematext.com/cloud/) — Gratuit jusqu’à 50 K actions/mois, rétention des données d’un jour, tableaux de bord et utilisateurs illimités, etc.
  * [Similar Web](https://similarweb.com) — Analytique pour sites web & apps mobiles. Plan gratuit offrant cinq résultats par métrique, un mois de données d’app mobile & 3 mois de données de site web.
  * [StatCounter](https://statcounter.com/) — Analytique de visiteurs de site web. Plan gratuit pour l’analytique des 500 derniers visiteurs.
  * [Statsig](https://statsig.com) - Plateforme tout-en-un pour analytique, feature flagging et A/B testing. Gratuit jusqu’à 1m d’événements comptabilisés par mois.
  * [Tableau Developer Program](https://www.tableau.com/developer) — Innovez, créez et adaptez Tableau à votre organisation. Le programme développeur gratuit donne une licence sandbox personnelle pour Tableau Online. Il s’agit de la dernière version pré-release afin que les Data Devs puissent tester toutes les fonctionnalités de cette superbe plateforme.
  * [usabilityhub.com](https://usabilityhub.com/) — Testez vos designs et maquettes auprès de vraies personnes et suivez les visiteurs. Gratuit pour un utilisateur, tests illimités
  * [woopra.com](https://www.woopra.com/) — Plateforme d’analytique utilisateur gratuite pour 500K actions, rétention des données 90 jours, plus de 30 intégrations en un clic.
  * [counter.dev](https://counter.dev) — Analytique web simple et donc respectueux de la vie privée. Gratuit ou paiement au don.
  * [PostHog](https://posthog.com) - Suite complète d’analytique produit gratuite jusqu’à 1m d’événements suivis par mois. Offre aussi des enquêtes in-app illimitées avec 250 réponses/mois.
  * [Uptrace](https://uptrace.dev) - Outil de traçage distribué aidant les développeurs à localiser les échecs et goulots d’étranglement. Plan gratuit, abonnement personnel offert pour les projets open-source, version open source disponible.
  * [Microsoft Clarity](https://clarity.microsoft.com/) - Clarity est un outil gratuit et facile à utiliser qui capture l’utilisation réelle de votre site.
  * [Beampipe.io](https://beampipe.io) - Beampipe est une analytique web simple et respectueuse de la vie privée. Gratuit jusqu’à 5 domaines et 10k pages vues mensuelles.
  * [Aptabase](https://aptabase.com) — Analytique open source, simple et respectueuse de la vie privée pour applications mobiles et desktop. SDK pour Swift, Kotlin, React Native, Flutter, Electron, et bien d’autres. Gratuit jusqu’à 20 000 événements/mois.
  * [Trackingplan](https://www.trackingplan.com/) - Détecte automatiquement les problèmes d’analytique digitale, données marketing et pixels, maintient à jour les plans de tracking, et favorise une collaboration fluide. Déployez-le sur votre environnement de production avec du trafic réel ou ajoutez une couverture analytique à vos tests de régression sans écrire de code.
  * [LogSpot](https://logspot.io) - Plateforme unifiée complète d’analytique web et produit, incluant des widgets analytiques intégrables et des robots automatisés (slack, telegram et webhooks). Le plan gratuit inclut 10 000 événements par mois.
  * [Umami](https://umami.is/) - Alternative open source simple, rapide, axée sur la confidentialité à Google Analytics.
  * [TrackWith Dicloud](https://dicloud.net/trackwith-privacy-focused-analytics/) - Alternative légère et axée sur la confidentialité à Google Analytics. Pages vues illimitées, visiteurs illimités, heatmaps de page et suivi d’objectifs illimités. Gratuit jusqu’à 3 domaines et 600 replays de session par domaine.
  * [AppFit](https://appfit.io) - AppFit est un outil complet d’analytique et de gestion produit conçu pour faciliter la gestion fluide et multiplateforme de l’analytique et des mises à jour produit. Plan gratuit incluant 10 000 événements/mois, journal produit et insights hebdomadaires.
  * [Seline](https://seline.so) - Seline est une solution simple & privée d’analytique web et produit. Sans cookies, légère, indépendante. Le plan gratuit comprend 3 000 événements/mois et donne accès à toutes les fonctionnalités comme le dashboard, les parcours utilisateurs, les entonnoirs, et plus.
  * [Peasy](https://peasy.so) - Peasy est un outil d’analytique léger et axé sur la confidentialité pour sites et produits web. Plan gratuit comprenant 3 000 événements/mois.
  * [Rybbit](https://rybbit.io) - Alternative open source et sans cookies à Google Analytics, 10x plus intuitive. Le plan gratuit offre 3 000 événements mensuels.

**[⬆️ Retour en haut](#table-of-contents)**

## Enregistrement des Sessions Visiteurs

  * [Reactflow.com](https://www.reactflow.com/) — Par site : 1 000 pages vues/jour, trois heatmaps, trois widgets, suivi de bugs gratuit
  * [OpenReplay.com](https://www.openreplay.com) - Relecture de session open source avec outils de développement pour reproduction de bugs, session live pour support en temps réel, et suite analytique produit. Mille sessions/mois avec accès à toutes les fonctionnalités et rétention de 7 jours.
  * [LogRocket.com](https://www.logrocket.com) - 1 000 sessions/mois avec rétention de 30 jours, suivi des erreurs, mode live
  * [FullStory.com](https://www.fullstory.com) — 1 000 sessions/mois avec un mois de rétention des données et trois sièges utilisateurs. Plus d’informations [ici](https://help.fullstory.com/hc/en-us/articles/360020623354-FullStory-Free-Edition).
  * [hotjar.com](https://www.hotjar.com/) — Par site : 1 050 pages vues/mois, heatmaps illimités, données stockées pendant trois mois
  * [inspectlet.com](https://www.inspectlet.com/) — 2 500 sessions/mois gratuites pour un site web
  * [Microsoft Clarity](https://clarity.microsoft.com/) - Enregistrement de session entièrement gratuit avec « aucune limite de trafic », aucun projet limité et aucun échantillonnage
  * [mouseflow.com](https://mouseflow.com/) — 500 sessions/mois gratuites pour un site web
  * [mousestats.com](https://www.mousestats.com/) — 100 sessions/mois gratuites pour un site web
  * [smartlook.com](https://www.smartlook.com/) — forfaits gratuits pour web et apps mobiles (1500 sessions/mois), trois heatmaps, un entonnoir, historique des données de 1 mois
  * [howuku.com](https://howuku.com) — Suivi des interactions utilisateur, engagement et événements. Gratuit jusqu’à 5 000 visites/mois
  * [UXtweak.com](https://www.uxtweak.com/) — Enregistrez et regardez comment les visiteurs utilisent votre site ou app. Gratuit sans limite de temps pour petits projets

**[⬆️ Retour en haut](#table-of-contents)**
## API et SDK de Vérification Internationale de Numéros de Mobile

  * [numverify](https://numverify.com/) — Validation et recherche globale de numéros de téléphone via une API JSON. 100 requêtes API/mois
  * [veriphone](https://veriphone.io/) — Vérification globale de numéros de téléphone via une API JSON gratuite, rapide et fiable. 1000 requêtes/mois

**[⬆️ Retour en haut](#table-of-contents)**

## Intégration de Paiement et Facturation

  * [Qonversion](http://qonversion.io/) - Plateforme tout-en-un de gestion d'abonnements multiplateforme offrant analyses, tests A/B, Apple Search Ads, configurations à distance et outils de croissance pour optimiser les achats intégrés et la monétisation. Compatible avec iOS, Android, React Native, Flutter, Unity, Cordova, Stripe et le web. Gratuit jusqu'à 10k$ de revenus suivis par mois.
  * [ParityVend](https://www.ambeteco.com/ParityVend/) – Ajuste automatiquement les prix en fonction de la localisation du visiteur pour étendre votre activité à l'international et atteindre de nouveaux marchés (parité de pouvoir d'achat). Le plan gratuit inclut 7 500 requêtes API/mois.
  * [Glassfy](https://glassfy.io/) – Infrastructure d'abonnements in-app, événements d'abonnements en temps réel et outils de monétisation prêts à l'emploi sur iOS, Android, Stripe et Paddle. Gratuit jusqu'à 10k$ de revenus mensuels.
  * [Adapty.io](https://adapty.io/) – Solution tout-en-un avec SDK open-source pour l'intégration d'abonnements mobiles in-app sur iOS, Android, React Native, Flutter, Unity, ou application web. Gratuit jusqu'à 10k$ de revenus mensuels.
  * [CoinMarketCap](https://coinmarketcap.com/api/) — Fournit des données de marché des cryptomonnaies incluant les taux de change crypto et fiat les plus récents. Le niveau gratuit offre 10K crédits d'appels/mois.
  * [CurrencyFreaks](https://currencyfreaks.com/) — Fournit des taux de change actuels et historiques. Plan DEVELOPER gratuit disponible avec 1000 requêtes/mois.
  * [CoinGecko](https://www.coingecko.com/en/api) — Fournit des données de marché sur les cryptomonnaies, incluant les taux de change crypto les plus récents et des données historiques. L’API de démonstration propose une limite stable de 30 appels/min et un plafond mensuel de 10 000 appels.
  * [CurrencyApi](https://currencyapi.net/) — Taux de change en temps réel pour monnaies physiques et cryptomonnaies, livrés en JSON et XML. Le niveau gratuit offre 1 250 requêtes API/mois.
  * [currencylayer](https://currencylayer.com/) — Taux de change fiables et conversion de devises pour votre entreprise, 100 requêtes API/mois gratuites.
  * [exchangerate-api.com](https://www.exchangerate-api.com) - API JSON de conversion de devises simple d'utilisation. Le niveau gratuit est mis à jour une fois par jour avec une limite de 1 500 requêtes/mois.
  * [FraudLabsPRO](https://www.fraudlabspro.com) — Aide les marchands à prévenir la fraude de paiement et les rétrofacturations. Plan Micro gratuit disponible avec 500 requêtes/mois.
  * [FxRatesAPI](https://fxratesapi.com) — Fournit des taux de change en temps réel et historiques. Le niveau gratuit nécessite une attribution.
  * [Moesif API Monetization](https://www.moesif.com/) - Générez des revenus avec vos APIs via la facturation à l'usage. Connexion à Stripe, Chargebee, etc. Le niveau gratuit offre 30 000 événements/mois.
  * [Nami ML](https://www.namiml.com/) - Plateforme complète pour achats intégrés et abonnements sur iOS et Android, incluant paywalls sans code, CRM et analyses. Gratuit pour toutes les fonctionnalités de base pour gérer un business IAP.
  * [RevenueCat](https://www.revenuecat.com/) — Backend hébergé pour achats intégrés et abonnements (iOS et Android). Gratuit jusqu’à 2,5k$/mois de revenus suivis.
  * [vatlayer](https://vatlayer.com/) — Validation instantanée de numéro de TVA et API de taux de TVA UE, 100 requêtes API/mois gratuites
  * [Currencyapi](https://currencyapi.com) — API gratuite de conversion et taux de change de devises. 300 requêtes gratuites par mois, 10 requêtes par minute pour usage privé.

**[⬆️ Retour en haut](#table-of-contents)**

## Lié à Docker

  * [canister.io](https://canister.io/) — 20 dépôts privés gratuits pour développeurs, 30 dépôts privés gratuits pour équipes pour construire et stocker des images Docker
  * [Container Registry Service](https://container-registry.com/) - Solution de gestion de conteneurs basée sur Harbor. Le niveau gratuit offre 1 Go de stockage pour les dépôts privés.
  * [Docker Hub](https://hub.docker.com) — Un dépôt privé gratuit et dépôts publics illimités pour construire et stocker des images Docker
  * [Play with Docker](https://labs.play-with-docker.com/) — Un terrain de jeu simple, interactif et ludique pour apprendre Docker.
  * [quay.io](https://quay.io/) — Construction et stockage d’images de conteneur avec dépôts publics illimités gratuits
  * [ttl.sh](https://ttl.sh/) - Registre d’images Docker anonyme et éphémère

**[⬆️ Retour en haut](#table-of-contents)**

## Lié à Vagrant

  * [Vagrant Cloud](https://app.vagrantup.com) - HashiCorp Vagrant Cloud. Hébergement de box Vagrant.
  * [Vagrantbox.es](https://www.vagrantbox.es/) — Index public alternatif de box

**[⬆️ Retour en haut](#table-of-contents)**

## Sites de Blogging Dev

  * [BearBlog](https://bearblog.dev/) - Créateur de blog et site web minimaliste propulsé par Markdown.
  * [Dev.to](https://dev.to/) - Où les programmeurs partagent des idées et s'entraident à progresser.
  * [Hashnode](https://hashnode.com/) — Logiciel de blog sans tracas pour développeurs !
  * [Medium](https://medium.com/) — Prenez le temps de réfléchir à ce qui compte pour vous.
  * [AyeDot](https://ayedot.com/) — Partagez vos idées, connaissances et histoires avec le monde gratuitement sous la forme de miniblogs multimédias modernes.

**[⬆️ Retour en haut](#table-of-contents)**

## Plateformes de Commentaires
  * [GraphComment](https://graphcomment.com/) - GraphComment est une plateforme de commentaires qui vous aide à bâtir une communauté active à partir de l’audience de votre site web.
  * [Utterances](https://utteranc.es/) - Widget de commentaires léger basé sur les issues GitHub. Utilisez les issues GitHub pour les commentaires de blog, pages wiki, etc. !
  * [Disqus](https://disqus.com/) - Disqus est une plateforme communautaire utilisée par des centaines de milliers de sites dans le monde entier.
  * [Remarkbox](https://www.remarkbox.com/) - Plateforme de commentaires hébergée open source, payez ce que vous pouvez pour "Un modérateur sur quelques domaines avec contrôle total sur le comportement et l'apparence"
  * [IntenseDebate](https://intensedebate.com/) - Système de commentaires riche en fonctionnalités pour WordPress, Tumblr, Blogger et de nombreuses autres plateformes web.

**[⬆️ Retour en haut](#table-of-contents)**

## APIs de Capture d'Écran

  * [ApiFlash](https://apiflash.com) — API de capture d’écran basée sur AWS Lambda et Chrome. Gère la page complète, le timing de capture et les dimensions du viewport.
  * [microlink.io](https://microlink.io/) – Transforme n'importe quel site web en données comme la normalisation des métadonnées, des aperçus de liens attractifs, des fonctionnalités de scraping, ou des captures d’écran en tant que service. 250 requêtes/jour gratuites chaque jour.
  * [ScreenshotAPI.net](https://screenshotapi.net/) - API de capture d’écran générant des captures de n'importe quel site web. Conçue pour évoluer et hébergée sur Google Cloud. Offre 100 captures gratuites par mois.
  * [screenshotlayer.com](https://screenshotlayer.com/) — Capturez des instantanés hautement personnalisables de n'importe quel site web. 100 captures gratuites/mois
  * [screenshotmachine.com](https://www.screenshotmachine.com/) — Capturez 100 instantanés/mois, png, gif et jpg, y compris la page complète, pas seulement la page d’accueil
  * [PhantomJsCloud](https://PhantomJsCloud.com) — Automatisation du navigateur et rendu de pages. Niveau gratuit jusqu’à 500 pages/jour. Offre gratuite depuis 2017.
  * [Webshrinker.com](https://webshrinker.com) — Web Shrinker fournit des captures d’écran de sites web et des services d’API d’intelligence de domaine. 100 requêtes/mois gratuites.
  * [Screenshots](https://screenshotson.click) — Votre API pour les captures d’écran. Avec de nombreuses options de personnalisation. 100 captures gratuites/mois.

**[⬆️ Retour en haut](#table-of-contents)**

## Lié à Flutter et Construction d’Apps iOS sans Mac

  * [FlutLab](https://flutlab.io/) - FlutLab est un IDE Flutter en ligne moderne et l’endroit idéal pour créer, déboguer et construire des projets multiplateformes. Construisez des apps iOS (sans Mac) et Android avec Flutter.
  * [CodeMagic](https://codemagic.io/) - Codemagic est une solution CI/CD entièrement hébergée et gérée pour apps mobiles. Vous pouvez construire, tester et déployer avec un outil CI/CD basé sur une interface graphique. Le niveau gratuit offre 500 minutes gratuites/mois et une instance Mac Mini avec 2,3 GHz et 8 Go de RAM.
  * [FlutterFlow](https://flutterflow.io/) - FlutterFlow est une interface drag-and-drop dans le navigateur pour créer des applications mobiles avec Flutter.

**[⬆️ Retour en haut](#table-of-contents)**

## Émulation matérielle basée navigateur en Javascript

  * [JsLinux](https://bellard.org/jslinux) — Une machine virtuelle x86 très rapide capable de faire tourner Linux et Windows 2k.
  * [Jor1k](https://s-macke.github.io/jor1k/demos/main.html) — Une machine virtuelle OpenRISC capable de faire tourner Linux avec support réseau.
  * [v86](https://copy.sh/v86) — Une machine virtuelle x86 capable de faire tourner Linux et d'autres OS directement dans le navigateur.

**[⬆️ Retour en haut](#table-of-contents)**

## Gestion de la confidentialité
  * [Bearer](https://www.bearer.sh/) - Aide à mettre en place la protection de la vie privée dès la conception via des audits et des workflows continus pour assurer la conformité RGPD et autres réglementations. Le niveau gratuit est limité aux petites équipes et à la version SaaS uniquement.
  * [Osano](https://www.osano.com/) - Plateforme de gestion du consentement et conformité, allant de la représentation RGPD aux bannières de cookies. Le niveau gratuit offre les fonctionnalités de base.
  * [Iubenda](https://www.iubenda.com/) - Politiques de confidentialité et cookies et gestion du consentement. Le niveau gratuit offre une politique de confidentialité et de cookies limitée ainsi que des bannières cookies.
  * [Cookiefirst](https://cookiefirst.com/) - Bannières cookies, audit et solution de gestion multi-langue du consentement. Le niveau gratuit offre un scan unique et une seule bannière.
  * [Ketch](https://www.ketch.com/) - Outil de gestion du consentement et cadre de confidentialité. Le niveau gratuit offre la plupart des fonctionnalités avec un nombre limité de visiteurs.
  * [Concord](https://www.concord.tech/) - Plateforme complète de protection des données, comprenant la gestion du consentement, le traitement des demandes de confidentialité (DSAR), et la cartographie des données. L’offre gratuite inclut les fonctionnalités principales de gestion du consentement et ils proposent également un plan plus avancé gratuitement pour les projets open source vérifiés.

**[⬆️ Retour en haut](#table-of-contents)**

## Divers

  * [BackgroundStyler.com](https://backgroundstyler.com) - Créez des captures d’écran esthétiques de votre code, texte ou images à partager sur les réseaux sociaux.
  * [BinShare.net](https://binshare.net) - Créez & partagez du code ou des binaires. Possibilité de partager sous forme d’image attrayante (ex : pour Twitter / Facebook) ou sous forme de lien (ex : pour discussions ou forums).
  * [Blynk](https://blynk.io) — SaaS avec API pour contrôler, construire & évaluer des objets IoT. Plan Développeur gratuit avec 5 appareils, Cloud & stockage de données gratuits. Applications mobiles également disponibles.
  * [Bricks Note Calculator](https://free.getbricks.app/) - une application de prise de notes (PWA) dotée d’une puissante calculatrice multiligne intégrée.
  * [Carbon.now.sh](https://carbon.now.sh) - créez et partagez des extraits de code sous forme d’images esthétiques façon capture d’écran. Généralement utilisé pour partager ou mettre en avant du code sur Twitter ou des blogs.
  * [Code Time](https://www.software.com/code-time) - extension de suivi du temps et de métriques de codage pour VS Code, Atom, IntelliJ, Sublime Text, et autres.
  * [Codepng](https://www.codepng.app) - Créez de superbes captures d’écran de votre code source à partager sur les réseaux sociaux.
  * [CodeToImage](https://codetoimage.com/) - Créez des captures d’écran de code ou de texte à partager sur les réseaux sociaux.
  * [Cronhooks](https://cronhooks.io/) - Planification de webhooks ponctuels ou récurrents. Le plan gratuit permet 5 programmations ponctuelles.
  * [cron-job.org](https://cron-job.org) - Service de tâches cron en ligne. Nombre de tâches illimité gratuit.
  * [datelist.io](https://datelist.io) - Système de réservation/prise de rendez-vous en ligne. Gratuit jusqu’à 5 réservations par mois, inclut 1 calendrier.
  * [Domain Forward](https://domain-forward.com/) - Un outil simple pour rediriger n’importe quelle URL ou domaine. Gratuit jusqu’à 5 domaines et 200 000 requêtes par mois.
  * [Elementor](https://elementor.com) — Constructeur de sites WordPress. Plan gratuit disponible avec plus de 40 widgets de base.
  * [Exif Editor](https://exifeditor.io/) — Voir, éditer, nettoyer, analyser les métadonnées d’images/photos instantanément dans le navigateur - y compris la localisation GPS et les métadonnées.
  * [Format Express](https://www.format-express.dev) - Format instantané en ligne pour JSON / XML / SQL.
  * [FOSSA](https://fossa.com/) - Gestion évolutive et complète du code tiers, conformité des licences et détection des vulnérabilités.
  * [Hook Relay](https://www.hookrelay.dev/) - Ajoutez le support webhook à votre application sans tracas : file d’attente, relances avec backoff, et journalisation incluses. Le plan gratuit comprend 100 livraisons par jour, une conservation de 14 jours, et 3 points de terminaison.
  * [Hosting Checker](https://hostingchecker.co) - Vérifiez les informations d’hébergement telles qu’ASN, FAI, localisation et plus pour tout domaine, site web ou adresse IP. Inclut aussi plusieurs outils liés à l’hébergement et DNS.
  * [http2.pro](https://http2.pro) — Test de compatibilité du protocole HTTP/2 et détection du support client HTTP/2 via API.
  * [kandi](https://kandi.openweaver.com/) — Démarrez le développement d’application : créez des fonctions personnalisées, des cas d’usage, et des applications complètes plus rapidement grâce à des extraits de code et à la réutilisation de bibliothèques open source.
  * [Base64 decoder/encoder](https://devpal.co/base64-decode/) — Outil gratuit en ligne pour encoder/décoder des données.
  * [newreleases.io](https://newreleases.io/) - Recevez des notifications par email, Slack, Telegram, Discord et webhooks personnalisés pour les nouvelles versions de GitHub, GitLab, Bitbucket, Python PyPI, Java Maven, Node.js NPM, Node.js Yarn, Ruby Gems, PHP Packagist, .NET NuGet, Rust Cargo et Docker Hub.
  * [OnlineExifViewer](https://onlineexifviewer.com/) — Consultez instantanément les données EXIF en ligne d’une photo, y compris la localisation GPS et les métadonnées.
  * [PDFMonkey](https://www.pdfmonkey.io/) — Gérez des modèles PDF sur un tableau de bord, appelez l’API avec des données dynamiques, et téléchargez vos PDF. Offre 300 documents gratuits par mois.
  * [Pika Code Screenshots](https://pika.style/templates/code-image) — Créez de belles captures d’écran personnalisables à partir d’extraits de code et de VSCode grâce à l’extension.
  * [QuickType.io](https://quicktype.io/) - Générez rapidement des modèles/classes/types/interfaces et des sérialiseurs à partir de JSON, schémas et GraphQL pour travailler avec les données rapidement et en toute sécurité dans n’importe quel langage de programmation. Convertissez du JSON en beau code typé dans n’importe quel langage.
  * [RandomKeygen](https://randomkeygen.com/) - Outil gratuit et adapté au mobile proposant une variété de clés et mots de passe générés aléatoirement à utiliser pour sécuriser n’importe quelle application, service ou appareil.
  * [ray.so](https://ray.so/) - Créez de belles images de vos extraits de code.
  * [readme.com](https://readme.com/) — Documentation attrayante et facile à réaliser, gratuit pour l’open source.
  * [redirection.io](https://redirection.io/) — Outil SaaS de gestion des redirections HTTP pour les entreprises, le marketing et le SEO.
  * [redirect.ing](https://redirect.ing/) - Redirection rapide & sécurisée de domaines sans gestion de serveurs ou de certificats SSL. Le plan gratuit inclut 10 hôtes et 100 000 requêtes par mois.
  * [redirect.pizza](https://redirect.pizza/) - Gérez facilement vos redirections avec support HTTPS. Le plan gratuit inclut 10 sources et 100 000 accès par mois.
  * [ReqBin](https://reqbin.com/) — Effectuez des requêtes HTTP en ligne. Méthodes populaires : GET, POST, PUT, DELETE, HEAD. Prend en charge les en-têtes et l’authentification par jeton. Système de connexion basique pour sauvegarder vos requêtes.
  * [Smartcar API](https://smartcar.com) - API pour voitures permettant de localiser, obtenir le niveau de carburant, la batterie, l’odomètre, déverrouiller/verrouiller les portes, etc.
  * [snappify](https://snappify.com) - Permet aux développeurs de créer des visuels saisissants. Des extraits de code élégants jusqu’à des présentations techniques complètes. Le plan gratuit inclut jusqu’à 3 snaps simultanés avec téléchargements illimités et 5 explications de code assistées par IA par mois.
  * [Sunrise and Sunset](https://sunrisesunset.io/api/) - Obtenez les horaires de lever et coucher du soleil pour une longitude et latitude données.
  * [superfeedr.com](https://superfeedr.com/) — Flux compatibles PubSubHubbub en temps réel, export, analyses. Gratuit avec moins de personnalisation.
  * [SurveyMonkey.com](https://www.surveymonkey.com) — Créez des enquêtes en ligne. Analysez les résultats en ligne. Le plan gratuit limite à 10 questions et 100 réponses par enquête.
  * [Tiledesk](https://tiledesk.com) - Créez des chatbots et applications conversationnelles. Rendez-les omnicanal : de votre site web (widget de chat en direct) à WhatsApp. Plan gratuit avec chatbots illimités.
  * [Versionfeeds](https://versionfeeds.com) — Flux RSS personnalisés pour les sorties de vos logiciels préférés. Ayez les dernières versions de vos langages, bibliothèques ou outils favoris dans un flux. (Les 3 premiers flux sont gratuits)
  * [videoinu](https://videoinu.com) — Créez et éditez des enregistrements d’écran et autres vidéos en ligne.
  * [Webacus](https://webacus.dev) — Accédez à une large gamme d’outils gratuits pour développeurs pour l’encodage, le décodage et la manipulation de données.

**[⬆️ Retour en haut](#table-of-contents)**

## Outils de bureau à distance

  * [Getscreen.me](https://getscreen.me) — Gratuit pour 2 appareils, sans limite sur le nombre ou la durée des sessions
  * [Apache Guacamole™](https://guacamole.apache.org/) — Passerelle de bureau à distance sans client, open source
  * [RemSupp](https://remsupp.com) — Support à la demande et accès permanent aux appareils (2 sessions/jour gratuites)
  * [RustDesk](https://rustdesk.com/) - Infrastructure de bureau distant/virtuel open source pour tous !
  * [AnyDesk](https://anydesk.com) — Gratuit pour 3 appareils, pas de limite sur le nombre ou la durée des sessions

**[⬆️ Retour en haut](#table-of-contents)**

## Développement de jeux

  * [itch.io](https://itch.io/game-assets) — Ressources gratuites/payantes comme des sprites, tilesets et packs de personnages.
  * [Gamefresco.com](https://gamefresco.com/) — Découvrez, collectez et partagez des ressources de jeu gratuites de créateurs du monde entier.
  * [GameDevMarket](https://gamedevmarket.net) — Ressources gratuites/payantes : 2D, 3D, audio, interfaces.
  * [OpenGameArt](https://opengameart.org) — Ressources de jeux open source : musiques, sons, sprites, gifs.
  * [CraftPix](https://craftpix.net) — Ressources gratuites/payantes : 2D, 3D, audio, interfaces, arrière-plans, icônes, tilesets, kits de jeux.
  * [Game Icons](https://game-icons.net/) - Icônes SVG/PNG stylisables gratuites sous licence CC-BY.
  * [LoSpec](https://lospec.com/) — Outils en ligne pour créer du pixel art et autres arts numériques restrictifs, de nombreux tutoriels/listes de palettes à disposition pour vos jeux.
  * [ArtStation](https://www.artstation.com/) - Marketplace pour ressources 2D, 3D & audio gratuites/payantes, icônes, tilesets, kits de jeux. Permet aussi de présenter votre portfolio d’art.
  * [Rive](https://rive.app/community/) - Ressources communautaires et possibilité de créer vos propres assets de jeu avec le plan gratuit.
  * [Poly Pizza](https://poly.pizza/) - Ressources 3D low poly gratuites
  * [3Dassets.one](https://3dassets.one/) - Plus de 8 000 modèles 3D et matériaux PBR gratuits/payants pour la création de textures.
  * [Kenney](https://www.kenney.nl/assets/) - Ressources de jeu 2D, 3D, audio et UI gratuites (licence CC0 1.0 Universelle).
  * [Poliigon](https://www.poliigon.com/) - Textures gratuites et payantes (résolution variable), modèles, HDRI, et brosses. Propose des plugins gratuits pour exporter vers des logiciels comme Blender.
  * [Freesound](https://freesound.org/) - Bibliothèque collaborative de sons gratuits avec différentes licences CC.

**[⬆️ Retour en haut](#table-of-contents)**

## Autres ressources gratuites

  * [Wikimint Developer](https://developer.wikimint.com/p/tools.html) - Outils toujours gratuits pour développeurs web, incluant minification/déminification CSS, optimisation et redimensionnement d’images, convertisseur de casse, validateur CSS, compilateur JavaScript, éditeur HTML, etc.
  * [ElevateAI](https://www.elevateai.com) - Jusqu’à 200 heures de transcription audio gratuites chaque mois.
  * [get.localhost.direct](https://get.localhost.direct) — Un meilleur certificat SSL wildcard `*.localhost.direct` signé par une autorité publique pour le développement local, avec support des sous-domaines.
  * [Framacloud](https://degooglisons-internet.org/en/) — Liste de logiciels et SaaS Libres/Gratuits proposée par l’association française [Framasoft](https://framasoft.org/en/).
  * [github.com — FOSS for Dev](https://github.com/tvvocold/FOSS-for-Dev) — Hub de logiciels libres et open source pour développeurs.
  * [GitHub Education](https://education.github.com/pack) — Collection de services gratuits pour étudiants. Inscription requise.
  * [Markdown Tools](https://markdowntools.com) - Outils pour convertir HTML, CSV, PDF, JSON et Excel vers et depuis Markdown.
  * [Microsoft 365 Developer Program](https://developer.microsoft.com/microsoft-365/dev-program) — Sandbox gratuit, outils et autres ressources pour développer sur la plateforme Microsoft 365. Abonnement de 90 jours [Microsoft 365 E5 Subscription](https://www.microsoft.com/microsoft-365/enterprise/e5) (Windows exclu), renouvelable si activité de développement détectée (données de télémétrie & algorithmes).
  * [Pyrexp](https://pythonium.net/regex) — Testeur regex en ligne gratuit pour déboguer et visualiser des expressions régulières.
  * [RedHat for Developers](https://developers.redhat.com) — Accès gratuit aux produits Red Hat (RHEL, OpenShift, CodeReady, etc.) réservé aux développeurs individuels. Des e-books gratuits sont également proposés.
  * [smsreceivefree.com](https://smsreceivefree.com/) — Numéros de téléphone temporaires et jetables gratuits.
  * [sandbox.httpsms.com](https://sandbox.httpsms.com) — Envoyez et recevez des SMS de test gratuitement.
  * [SimpleBackups.com](https://simplebackups.com/) — Service d’automatisation de sauvegardes pour serveurs et bases de données (MySQL, PostgreSQL, MongoDB) vers les fournisseurs de stockage cloud (AWS, DigitalOcean, Backblaze). Offre un plan gratuit pour 1 sauvegarde.
  * [SnapShooter](https://snapshooter.com/) — Solution de sauvegarde pour DigitalOcean, AWS, LightSail, Hetzner et Exoscale, avec prise en charge des sauvegardes directes de bases de données, systèmes de fichiers et applications vers le stockage compatible s3. Offre un plan gratuit avec sauvegarde quotidienne pour une ressource.
  * [Themeselection](https://themeselection.com/) — Sélection de templates d’administration, thèmes HTML et kits UI gratuits, modernes, professionnels et faciles à utiliser pour créer vos applications plus rapidement !
  * [Web.Dev](https://web.dev/measure/) — Outil gratuit permettant de voir les performances de votre site et d’améliorer son SEO pour obtenir un meilleur classement dans les moteurs de recherche.
  * [SmallDev.tools](https://smalldev.tools/) — Un outil gratuit pour les développeurs qui permet d’encoder/décoder divers formats, de minifier HTML/CSS/Javascript, d’embellir, de générer de fausses données/données de test en JSON/CSV et de nombreux autres formats, et bien d’autres fonctionnalités. Avec une interface agréable.
  * [UseCSV par Layercode](https://layercode.com/usecsv) — Ajoutez l’import CSV et Excel à votre application web en quelques minutes. Offrez à vos utilisateurs une expérience d’importation de données agréable et robuste. Commencez gratuitement sans aucune information de carte bancaire, et intégrez UseCSV dès aujourd’hui. Vous pouvez créer un nombre illimité d’importateurs et télécharger des fichiers jusqu’à 100 Mo.
  * [Buttons Generator](https://markodenic.com/tools/buttons-generator/) — Plus de 100 boutons que vous pouvez utiliser dans votre projet.
  * [WrapPixel](https://www.wrappixel.com/) — Téléchargez des modèles de tableaux de bord d’administration gratuits et premium de haute qualité créés avec Angular, React, VueJs, NextJS et NuxtJS !
  * [Utils.fun](https://utils.fun/en) — Tous les outils quotidiens et de développement hors ligne basés sur la puissance de calcul du navigateur, y compris la génération de filigrane, l’enregistrement d’écran, l’encodage et le décodage, le chiffrement et le déchiffrement, et le formatage du code, sont entièrement gratuits et n’envoient aucune donnée dans le cloud pour traitement.
  * [It tools](it-tools.tech) - Outils utiles pour les développeurs et les personnes travaillant dans l’IT.
  * [Free Code Tools](https://freecodetools.org/) — Outils de code efficaces 100 % gratuits. Éditeur Markdown, minificateur/embellisseur de code, générateur de QR code, générateur Open Graph, générateur de carte Twitter, et plus encore.
  * [regex101](https://regex101.com/) — Gratuit, ce site web vous permet de tester et déboguer des expressions régulières (regex). Il propose un éditeur et un testeur de regex, ainsi que de la documentation utile et des ressources pour apprendre les regex.
  * [Kody Tools](https://www.kodytools.com/dev-tools) — Plus de 100 outils pour développeurs, dont des outils de formatage, minification et conversion.
  * [AdminMart](https://adminmart.com/) — Modèles gratuits et premium de tableaux de bord d’administration et de sites web de haute qualité créés avec Angular, Bootstrap, React, VueJs, NextJS et NuxtJS !
  * [Glob tester](https://globster.xyz/) — Un site web permettant de concevoir et de tester des motifs glob. Il propose aussi des ressources pour apprendre les motifs glob.
  * [SimpleRestore](https://simplerestore.io) - Restauration MySQL sans tracas. Restaurez des sauvegardes MySQL sur n’importe quelle base de données distante sans code ni serveur.
  * [360Converter](https://www.360converter.com/) - Un site utile et gratuit pour convertir : Vidéo en texte && Audio en texte && Parole en texte && Audio en temps réel en texte && Vidéo YouTube en texte && ajouter des sous-titres vidéo. Peut être utile pour une conversion rapide de vidéo ou pour un court tutoriel YouTube :)
  * [QRCodeBest](https://qrcode.best/) - Créez des QR codes personnalisés avec 13 modèles, confidentialité totale et branding personnel. Fonctionnalités de pixels de suivi, catégorisation de projets et sièges illimités pour l’équipe sur QRCode.Best.
  * [PostPulse](https://PostPulseAI.com) - Améliorez votre présence en ligne, renforcez votre SEO et le classement de votre site avec des publications mensuelles générées par IA sur des domaines optimisés pour le SEO. Le forfait gratuit vous permet de publier manuellement un post sur notre site chaque mois.
  * [PageTools](https://pagetools.co/) - Propose une suite d’outils alimentés par l’IA, gratuits à vie, pour générer des politiques essentielles de site web, créer des bios de réseaux sociaux, des publications et des pages web avec une interface simple en un clic.
  * [MySQL Visual Explain](https://mysqlexplain.com) - Visualiseur gratuit et facile à comprendre de la sortie MySQL EXPLAIN pour optimiser les requêtes lentes.
  * [Killer Coda](https://killercoda.com/)  - Terrain de jeu interactif dans votre navigateur pour étudier Linux, Kubernetes, Conteneurs, Programmation, DevOps, Réseaux.
  * [Axonomy App](https://axonomy-app.com/) - Un outil gratuit pour créer, gérer et partager vos factures avec vos clients. 10 factures gratuites par mois.
  * [Table Format Converter](https://www.tableformatconverter.com) - Un outil gratuit pour convertir des données de tableaux en différents formats, tels que CSV, HTML, JSON, Markdown, et plus encore.


**[⬆️ Retour en haut](#table-of-contents)**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---
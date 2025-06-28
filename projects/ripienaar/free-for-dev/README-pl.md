# free-for.dev

Deweloperzy i autorzy Open Source mają obecnie do dyspozycji wiele usług oferujących darmowe plany, ale znalezienie ich wszystkich zajmuje czas potrzebny do podjęcia świadomych decyzji.

To jest lista oprogramowania (SaaS, PaaS, IaaS itd.) oraz innych ofert z darmowymi planami dla deweloperów.

Zakres tej konkretnej listy jest ograniczony do rzeczy, które twórcy infrastruktury (administratorzy systemów, specjaliści DevOps itd.) mogą uznać za przydatne. Uwielbiamy wszystkie darmowe usługi, ale dobrze byłoby trzymać się tematu. Czasami to cienka granica, więc lista jest subiektywna; proszę, nie czuj się urażony, jeśli nie zaakceptuję Twojego wkładu.

Ta lista jest efektem Pull Requestów, recenzji, pomysłów i pracy wykonanej przez ponad 1600 osób. Ty również możesz pomóc, wysyłając [Pull Requesty](https://github.com/ripienaar/free-for-dev), aby dodać kolejne usługi lub usunąć te, których oferta się zmieniła lub została wycofana.

[![Track Awesome List](https://www.trackawesomelist.com/badge.svg)](https://www.trackawesomelist.com/ripienaar/free-for-dev)

**UWAGA**: Ta lista dotyczy tylko usług w modelu as-a-Service, nie oprogramowania do samodzielnego hostowania. Aby usługa kwalifikowała się do listy, musi oferować darmowy plan, nie tylko darmowy okres próbny. Darmowy plan musi być dostępny przez co najmniej rok, jeśli jest ograniczony czasowo. Rozważamy także darmowy plan z perspektywy bezpieczeństwa, więc SSO jest akceptowalne, ale nie zaakceptuję usług ograniczających TLS wyłącznie do płatnych planów.

# Spis treści

  * [Limity zawsze darmowe największych dostawców chmurowych](#major-cloud-providers)
  * [Rozwiązania do zarządzania chmurą](#cloud-management-solutions)
  * [Analiza, zdarzenia i statystyki](#analytics-events-and-statistics)
  * [API, dane i ML](#apis-data-and-ml)
  * [Repozytoria artefaktów](#artifact-repos)
  * [BaaS](#baas)
  * [Platformy low-code](#low-code-platform)
  * [CDN i ochrona](#cdn-and-protection)
  * [CI i CD](#ci-and-cd)
  * [CMS](#cms)
  * [Generowanie kodu](#code-generation)
  * [Jakość kodu](#code-quality)
  * [Wyszukiwanie i przeglądanie kodu](#code-search-and-browsing)
  * [Obsługa błędów i wyjątków](#crash-and-exception-handling)
  * [Wizualizacja danych na mapach](#data-visualization-on-maps)
  * [Zarządzane usługi danych](#managed-data-services)
  * [Projektowanie i UI](#design-and-ui)
  * [Inspiracje projektowe](#design-inspiration)
  * [Blogi deweloperskie](#dev-blogging-sites)
  * [DNS](#dns)
  * [Usługi związane z Dockerem](#docker-related)
  * [Domeny](#domain)
  * [Edukacja i rozwój kariery](#education-and-career-development)
  * [E-mail](#email)
  * [Platformy zarządzania flagami funkcji](#feature-toggles-management-platforms)
  * [Czcionki](#font)
  * [Formularze](#forms)
  * [Generatywna AI](#generative-ai)
  * [IaaS](#iaas)
  * [IDE i edytory kodu](#ide-and-code-editing)
  * [Międzynarodowa weryfikacja numeru telefonu - API i SDK](#international-mobile-number-verification-api-and-sdk)
  * [Zarządzanie projektami i śledzenie błędów](#issue-tracking-and-project-management)
  * [Zarządzanie logami](#log-management)
  * [Dystrybucja i feedback aplikacji mobilnych](#mobile-app-distribution-and-feedback)
  * [Systemy zarządzania](#management-system)
  * [Wiadomości i streaming](#messaging-and-streaming)
  * [Różne](#miscellaneous)
  * [Monitoring](#monitoring)
  * [PaaS](#paas)
  * [Systemy budowania paczek](#package-build-system)
  * [Integracja płatności i fakturowania](#payment-and-billing-integration)
  * [Zarządzanie prywatnością](#privacy-management)
  * [Screenshot APIs](#screenshot-apis)
  * [Flutter i budowanie aplikacji IOS bez Maca](#flutter-related-and-building-ios-apps-without-mac)
  * [Wyszukiwarki](#search)
  * [Bezpieczeństwo i PKI](#security-and-pki)
  * [Uwierzytelnianie, autoryzacja i zarządzanie użytkownikami](#authentication-authorization-and-user-management)
  * [Repozytoria kodu źródłowego](#source-code-repos)
  * [Przechowywanie i przetwarzanie mediów](#storage-and-media-processing)
  * [Tunelowanie, WebRTC, serwery WebSocket i inne routery](#tunneling-webrtc-web-socket-servers-and-other-routers)
  * [Testowanie](#testing)
  * [Narzędzia dla zespołów i współpracy](#tools-for-teams-and-collaboration)
  * [Zarządzanie tłumaczeniami](#translation-management)
  * [Usługi związane z Vagrant](#vagrant-related)
  * [Nagrywanie sesji odwiedzających](#visitor-session-recording)
  * [Hosting stron WWW](#web-hosting)
  * [Platformy komentarzy](#commenting-platforms)
  * [Emulacja sprzętu w przeglądarce](#browser-based-hardware-emulation-written-in-javascript)
  * [Zdalne pulpity](#remote-desktop-tools)
  * [Tworzenie gier](#game-development)
  * [Inne darmowe zasoby](#other-free-resources)

## Najwięksi dostawcy chmury

  * [Google Cloud Platform](https://cloud.google.com)
    * App Engine – 28 godzin instancji frontend dziennie, dziewięć godzin instancji backend dziennie
    * Cloud Firestore – 1 GB miejsca, 50 000 odczytów, 20 000 zapisów, 20 000 usunięć dziennie
    * Compute Engine – 1 niepreemtywna e2-micro, 30 GB HDD, 5 GB miejsca na snapshoty (ograniczone do wybranych regionów), 1 GB ruchu wychodzącego z Ameryki Północnej do wszystkich regionów (z wyłączeniem Chin i Australii) miesięcznie
    * Cloud Storage – 5 GB, 1 GB ruchu wychodzącego
    * Cloud Shell – Przeglądarkowa powłoka Linuksa/główne IDE z 5 GB trwałego miejsca. Limit 60 godzin tygodniowo
    * Cloud Pub/Sub – 10 GB wiadomości miesięcznie
    * Cloud Functions – 2 miliony wywołań miesięcznie (obejmuje wywołania zarówno w tle, jak i HTTP)
    * Cloud Run – 2 miliony żądań miesięcznie, 360 000 GB-sekund pamięci, 180 000 vCPU-sekund czasu obliczeniowego, 1 GB ruchu wychodzącego z Ameryki Północnej miesięcznie
    * Google Kubernetes Engine – Brak opłaty za zarządzanie klastrem dla jednego klastra strefowego. Każdy węzeł użytkownika jest rozliczany według standardowego cennika Compute Engine
    * BigQuery – 1 TB zapytań miesięcznie, 10 GB miejsca miesięcznie
    * Cloud Build – 120 minut budowania dziennie
    * Cloud Source Repositories – Do 5 użytkowników, 50 GB miejsca, 50 GB ruchu wychodzącego
    * [Google Colab](https://colab.research.google.com/) – Darmowe środowisko do pracy z Jupyter Notebooks.
    * [Firebase Studio](https://firebase.studio) Google Firebase Studio (dawniej Project IDX). Internetowy VSCode działający w Google Cloud.
    * Pełna, szczegółowa lista – https://cloud.google.com/free

  * [Amazon Web Services](https://aws.amazon.com)
    * [CloudFront](https://aws.amazon.com/cloudfront/) – 1 TB ruchu wychodzącego miesięcznie i 2 mln wywołań funkcji miesięcznie
    * [CloudWatch](https://aws.amazon.com/cloudwatch/) – 10 niestandardowych metryk i dziesięć alarmów
* [CodeBuild](https://aws.amazon.com/codebuild/) - 100 minut czasu kompilacji miesięcznie
* [CodeCommit](https://aws.amazon.com/codecommit/) - 5 aktywnych użytkowników, 50GB przestrzeni dyskowej i 10 000 żądań miesięcznie
* [CodePipeline](https://aws.amazon.com/codepipeline/) - 1 aktywny pipeline miesięcznie
* [DynamoDB](https://aws.amazon.com/dynamodb/) - 25GB bazy danych NoSQL
* [EC2](https://aws.amazon.com/ec2/) - 750 godzin miesięcznie na instancji t2.micro lub t3.micro (12 miesięcy). 100GB wychodzącego transferu miesięcznie
* [EBS](https://aws.amazon.com/ebs/) - 30GB miesięcznie dysku General Purpose (SSD) lub Magnetic (12 miesięcy)
* [Elastic Load Balancing](https://aws.amazon.com/elasticloadbalancing/) - 750 godzin miesięcznie (12 miesięcy)
* [RDS](https://aws.amazon.com/rds/) - 750 godzin miesięcznie db.t2.micro, db.t3.micro lub db.t4g.micro, 20GB pamięci masowej General Purpose (SSD), 20GB kopii zapasowych (12 miesięcy)
* [S3](https://aws.amazon.com/s3/) - 5GB Standardowej pamięci obiektowej, 20 tys. zapytań GET i 2 tys. zapytań PUT (12 miesięcy)
* [Glacier](https://aws.amazon.com/glacier/) - 10GB długoterminowej pamięci obiektowej
* [Lambda](https://aws.amazon.com/lambda/) - 1 milion żądań miesięcznie
* [SNS](https://aws.amazon.com/sns/) - 1 milion publikacji miesięcznie
* [SES](https://aws.amazon.com/ses/) - 3 000 wiadomości miesięcznie (12 miesięcy)
* [SQS](https://aws.amazon.com/sqs/) - 1 milion żądań kolejkowania wiadomości
* Pełna, szczegółowa lista - https://aws.amazon.com/free/

* [Microsoft Azure](https://azure.microsoft.com)
  * [Virtual Machines](https://azure.microsoft.com/services/virtual-machines/) - 1 VM B1S Linux, 1 VM B1S Windows (12 miesięcy)
  * [App Service](https://azure.microsoft.com/services/app-service/) - 10 aplikacji webowych, mobilnych lub API (60 minut CPU/dzień)
  * [Functions](https://azure.microsoft.com/services/functions/) - 1 milion żądań miesięcznie
  * [DevTest Labs](https://azure.microsoft.com/services/devtest-lab/) - Szybkie, łatwe i wydajne środowiska testowo-rozwojowe
  * [Active Directory](https://azure.microsoft.com/services/active-directory/) - 500 000 obiektów
  * [Active Directory B2C](https://azure.microsoft.com/services/active-directory/external-identities/b2c/) - 50 000 przechowywanych użytkowników miesięcznie
  * [Azure DevOps](https://azure.microsoft.com/services/devops/) - 5 aktywnych użytkowników, nielimitowane prywatne repozytoria Git
  * [Azure Pipelines](https://azure.microsoft.com/services/devops/pipelines/) — 10 darmowych równoległych zadań z nielimitowanym czasem dla open source na Linux, macOS i Windows
  * [Microsoft IoT Hub](https://azure.microsoft.com/services/iot-hub/) - 8 000 wiadomości dziennie
  * [Load Balancer](https://azure.microsoft.com/services/load-balancer/) - 1 darmowy publiczny adres IP z load balancingiem (VIP)
  * [Notification Hubs](https://azure.microsoft.com/services/notification-hubs/) - 1 milion powiadomień push
  * [Bandwidth](https://azure.microsoft.com/pricing/details/bandwidth/) - 15GB przychodzącego transferu (12 miesięcy) i 5GB wychodzącego miesięcznie
  * [Cosmos DB](https://azure.microsoft.com/services/cosmos-db/) - 25GB przestrzeni i 1000 RU przepustowości
  * [Static Web Apps](https://azure.microsoft.com/pricing/details/app-service/static/) — Tworzenie, wdrażanie i hosting statycznych aplikacji i funkcji serverless z darmowym SSL, uwierzytelnianiem/autoryzacją i własnymi domenami
  * [Storage](https://azure.microsoft.com/services/storage/) - 5GB pamięci LRS File lub Blob (12 miesięcy)
  * [Cognitive Services](https://azure.microsoft.com/services/cognitive-services/) - API AI/ML (Computer Vision, Translator, rozpoznawanie twarzy, boty itp.) z darmową warstwą obejmującą ograniczoną liczbę transakcji
  * [Cognitive Search](https://azure.microsoft.com/services/search/#features) - Wyszukiwarka i usługa indeksowania oparta na AI, darmowa dla 10 000 dokumentów
  * [Azure Kubernetes Service](https://azure.microsoft.com/services/kubernetes-service/) - Zarządzana usługa Kubernetes, darmowe zarządzanie klastrami
  * [Event Grid](https://azure.microsoft.com/services/event-grid/) - 100 tys. operacji miesięcznie
  * Pełna, szczegółowa lista - https://azure.microsoft.com/free/

* [Oracle Cloud](https://www.oracle.com/cloud/)
  * Compute
     - 2 instancje VM oparte na AMD z 1/8 OCPU i 1GB RAM każda
     - 4 rdzenie Arm Ampere A1 i 24GB RAM do wykorzystania jako jedna VM lub do 4 VM
     - Instancje zostaną odzyskane, gdy zostaną [uznane za bezczynne](https://docs.oracle.com/en-us/iaas/Content/FreeTier/freetier_topic-Always_Free_Resources.htm#compute__idleinstances)
  * Block Volume - 2 woluminy, łącznie 200GB (do wykorzystania z compute)
  * Object Storage - 10GB
  * Load balancer - 1 instancja z 10 Mbps
  * Bazy danych - 2 bazy, po 20GB każda
  * Monitoring - 500 milionów punktów danych przyjęcia, 1 miliard punktów pobrań
  * Pasmo - 10TB wychodzącego transferu miesięcznie, ograniczenie prędkości do 50 Mbps na VM x64, 500 Mbps * liczba rdzeni na VM ARM
  * Publiczny IP - 2 IPv4 dla VM, 1 IPv4 dla load balancera
  * Powiadomienia - 1 milion opcji dostarczania miesięcznie, 1000 wysłanych emaili miesięcznie
  * Pełna, szczegółowa lista - https://www.oracle.com/cloud/free/

* [IBM Cloud](https://www.ibm.com/cloud/free/)
  * Baza danych Cloudant - 1GB przestrzeni
  * Baza danych Db2 - 100MB przestrzeni
  * API Connect - 50 000 wywołań API miesięcznie
  * Monitoring dostępności - 3 miliony punktów danych miesięcznie
  * Analiza logów - 500MB dziennie logów
  * Pełna, szczegółowa lista - https://www.ibm.com/cloud/free/

* [Cloudflare](https://www.cloudflare.com/)
  * [Application Services](https://www.cloudflare.com/plans/) - Darmowy DNS dla nieograniczonej liczby domen, ochrona DDoS, CDN wraz z darmowym SSL, reguły zapory i stron, WAF, ochrona przed botami, darmowe nielimitowane ograniczanie ruchu - 1 reguła na domenę, analityka, przekierowanie emaili
  * [Zero Trust & SASE](https://www.cloudflare.com/plans/zero-trust-services/) - Do 50 użytkowników, 24 godziny logowania aktywności, trzy lokalizacje sieciowe
  * [Cloudflare Tunnel](https://www.cloudflare.com/products/tunnel/) - Możesz wystawić lokalnie działający port HTTP przez tunel do losowej subdomeny na trycloudflare.com używając [Quick Tunnels](https://developers.cloudflare.com/cloudflare-one/connections/connect-networks/do-more-with-tunnels/trycloudflare/), konto nie jest wymagane. Więcej funkcji (tunel TCP, load balancing, VPN) w [Zero Trust](https://www.cloudflare.com/products/zero-trust/) Free Plan.
  * [Workers](https://developers.cloudflare.com/workers/) - Wdrażaj kod serverless za darmo w globalnej sieci Cloudflare — 100 tys. żądań dziennie.
  * [Workers KV](https://developers.cloudflare.com/kv) - 100 tys. zapytań odczytu dziennie, 1000 zapisów dziennie, 1000 usunięć dziennie, 1000 zapytań listy dziennie, 1GB przechowywanych danych
  * [R2](https://developers.cloudflare.com/r2/) - 10GB miesięcznie, 1 milion operacji klasy A miesięcznie, 10 milionów operacji klasy B miesięcznie
  * [D1](https://developers.cloudflare.com/d1/) - 5 milionów odczytanych wierszy dziennie, 100 tys. zapisanych wierszy dziennie, 1GB przestrzeni
  * [Pages](https://developers.cloudflare.com/pages/) - Twórz i wdrażaj aplikacje webowe w szybkiej i bezpiecznej globalnej sieci Cloudflare. 500 kompilacji miesięcznie, 100 własnych domen, zintegrowany SSL, nielimitowana liczba miejsc dostępnych, nielimitowane wdrożenia podglądowe oraz pełna obsługa full-stack przez integrację z Cloudflare Workers.
  * [Queues](https://developers.cloudflare.com/queues/) - 1 milion operacji miesięcznie
  * [TURN](https://developers.cloudflare.com/calls/turn/) – 1TB darmowego (wychodzącego) transferu miesięcznie.

**[⬆️ Powrót na górę](#table-of-contents)**

## Rozwiązania do zarządzania chmurą

* [Brainboard](https://www.brainboard.co) - Współpraca do wizualnego budowania i zarządzania infrastrukturą chmurową end-to-end.
* [Cloud 66](https://www.cloud66.com/) - Darmowe dla projektów osobistych (obejmuje jeden serwer wdrożeniowy, jedną stronę statyczną), Cloud 66 daje wszystko, czego potrzebujesz do budowania, wdrażania i rozwoju aplikacji w dowolnej chmurze bez problemów z „serwerami”.
* [Pulumi](https://www.pulumi.com/) — Nowoczesna platforma infrastruktury jako kod, która pozwala używać znanych języków programowania i narzędzi do budowania, wdrażania i zarządzania infrastrukturą chmurową.
* [terraform.io](https://www.terraform.io/) — Terraform Cloud. Darmowe zdalne zarządzanie stanem i współpraca zespołu do 500 zasobów.
* [scalr.com](https://scalr.com/) - Scalr to produkt Terraform Automation and Collaboration (TACO) umożliwiający lepszą współpracę i automatyzację infrastruktury oraz konfiguracji zarządzanych przez Terraform. Pełna obsługa CLI Terraform, integracja OPA oraz hierarchiczny model konfiguracji. Brak opłat za SSO. Wszystkie funkcje w cenie. Do 50 uruchomień miesięcznie za darmo.
* [deployment.io](https://deployment.io) - Deployment.io pomaga programistom automatyzować wdrożenia na AWS. W darmowej wersji programista (pojedynczy użytkownik) może wdrażać nieograniczoną liczbę stron statycznych, usług webowych i środowisk. Oferujemy 20 darmowych uruchomień zadań miesięcznie z podglądami i automatycznymi wdrożeniami w ramach darmowej wersji.

**[⬆️ Powrót na górę](#table-of-contents)**

## Repozytoria kodu źródłowego

* [Bitbucket](https://bitbucket.org/) — Nielimitowane publiczne i prywatne repozytoria Git dla maksymalnie 5 użytkowników z Pipeline do CI/CD
* [chiselapp.com](https://chiselapp.com/) — Nielimitowane publiczne i prywatne repozytoria Fossil
* [codebasehq.com](https://www.codebasehq.com/) — Jeden darmowy projekt z 100 MB przestrzeni i dwoma użytkownikami
* [Codeberg](https://codeberg.org/) — Nielimitowane publiczne i prywatne repozytoria Git dla projektów open-source (z nieograniczoną liczbą współpracowników). Napędzane przez [Forgejo](https://forgejo.org/). Hosting stron statycznych przez [Codeberg Pages](https://codeberg.page/). Hosting CI/CD przez [Codeberg's CI](https://docs.codeberg.org/ci/). Hosting tłumaczeń przez [Codeberg Translate](https://translate.codeberg.org/). Zawiera hosting pakietów i kontenerów, zarządzanie projektami oraz śledzenie zgłoszeń
* [GitGud](https://gitgud.io) — Nielimitowane prywatne i publiczne repozytoria. Darmowe na zawsze. Napędzane przez GitLab & Sapphire. Brak CI/CD.
* [GitHub](https://github.com/) — Nielimitowane publiczne repozytoria i nielimitowane prywatne repozytoria (z nieograniczoną liczbą współpracowników). W zestawie CI/CD, środowisko deweloperskie, hosting statyczny, hosting pakietów i kontenerów, zarządzanie projektami oraz AI Copilot
* [gitlab.com](https://about.gitlab.com/) — Nielimitowane publiczne i prywatne repozytoria Git z maksymalnie 5 współpracownikami. W zestawie CI/CD, hosting statyczny, rejestr kontenerów, zarządzanie projektami i śledzenie zgłoszeń
* [framagit.org](https://framagit.org/) — Framagit to forż oprogramowania Framasoft oparty na Gitlab, obejmuje CI, statyczne strony, strony projektów oraz śledzenie zgłoszeń.
* [heptapod.net](https://foss.heptapod.net/) — Heptapod to przyjazny fork GitLab Community Edition zapewniający obsługę Mercuriala
* [ionicframework.com](https://ionicframework.com/appflow) - Repozytorium i narzędzia do tworzenia aplikacji w Ionic; również repozytorium ionic
* [NotABug](https://notabug.org) — NotABug.org to platforma współpracy nad kodem dla projektów na wolnych licencjach, oparta na Git
* [OSDN](https://osdn.net/) - OSDN.net to darmowy serwis dla deweloperów open-source, oferujący repozytoria SVN/Git/Mercurial/Bazaar/CVS.
  * [Pagure.io](https://pagure.io) — Pagure.io to darmowa i otwartoźródłowa platforma do współpracy nad kodem dla projektów na licencji FOSS, oparta na Git
  * [perforce.com](https://www.perforce.com/products/helix-teamhub) — Darmowe 1 GB w chmurze oraz repozytoria Git, Mercurial lub SVN.
  * [pijul.com](https://pijul.com/) - Nielimitowany, darmowy i otwartoźródłowy rozproszony system kontroli wersji. Jego wyróżniającą cechą jest solidna teoria łatek, która ułatwia naukę, obsługę i dystrybucję. Rozwiązuje wiele problemów git/hg/svn/darcs.
  * [plasticscm.com](https://plasticscm.com/) — Darmowe dla osób prywatnych, projektów OSS i organizacji non-profit
  * [projectlocker.com](https://projectlocker.com) — Jeden darmowy prywatny projekt (Git i Subversion) z 50 MB przestrzeni
  * [RocketGit](https://rocketgit.com) — Hosting repozytoriów oparty na Git. Nielimitowane publiczne i prywatne repozytoria.
  * [savannah.gnu.org](https://savannah.gnu.org/) - Pełni rolę systemu zarządzania rozwojem oprogramowania dla projektów wolnego oprogramowania (dla projektów GNU)
  * [savannah.nongnu.org](https://savannah.nongnu.org/) - Pełni rolę systemu zarządzania rozwojem oprogramowania dla projektów wolnego oprogramowania (dla projektów nie-GNU)

**[⬆️ Powrót na górę](#table-of-contents)**

## API, dane i ML

  * [JSONGrid](https://jsongrid.com) - Darmowe narzędzie do wizualizacji, edycji, filtrowania złożonych danych JSON w pięknej tabelarycznej siatce. Zapisuj i udostępniaj dane JSON przez link.
  * [Zerosheets](https://zerosheets.com) - Zamień arkusze Google Sheets w potężne API do szybkiego prototypowania, stron, aplikacji i więcej. 500 żądań miesięcznie za darmo.
  * [IP.City](https://ip.city) — 100 darmowych zapytań geolokalizacyjnych IP dziennie
  * [Abstract API](https://www.abstractapi.com) — Pakiet API do różnych zastosowań, m.in. geolokalizacja IP, detekcja płci czy walidacja e-maili.
  * [Apify](https://www.apify.com/) — Platforma do web scrapingu i automatyzacji, pozwalająca stworzyć API dla dowolnej strony i wyodrębnić dane. Gotowe scrapery, zintegrowane proxy i rozwiązania customowe. Darmowy plan z kredytami o wartości $5 miesięcznie.
  * [APITemplate.io](https://apitemplate.io) - Automatyczne generowanie obrazów i dokumentów PDF przez proste API lub narzędzia automatyzujące jak Zapier & Airtable. Nie wymaga CSS/HTML. Darmowy plan: 50 obrazów/miesiąc i trzy szablony.
  * [APIToolkit.io](https://apitoolkit.io) - Wszystkie narzędzia potrzebne do pełnego zrozumienia działania Twoich API i backendów. Automatyczna walidacja i monitoring kontraktów API. Darmowy plan do 10 000 żądań dziennie.
  * [APIVerve](https://apiverve.com) - Natychmiastowy dostęp do ponad 120+ API za darmo, z myślą o jakości i niezawodności. Darmowy plan obejmuje do 50 tokenów API miesięcznie. (Możliwe, że usługa nieaktywna, 2025-06-25)
  * [Arize AI](https://arize.com/) - Nadzór ML dla monitorowania modeli i analizowania źródeł problemów, np. jakości danych i dryfu wydajności. Darmowo do dwóch modeli.
  * [Maxim AI](https://getmaxim.ai/) - Symuluj, oceniaj i obserwuj swoich agentów AI. Platforma end-to-end do oceny i nadzoru, przyspieszająca wdrożenia ponad 5x. Darmowa na zawsze dla indie developerów i małych zespołów (3 miejsca).
  * [Beeceptor](https://beeceptor.com) - Mockowanie REST API w kilka sekund, fałszywe odpowiedzi API i więcej. 50 darmowych żądań dziennie, publiczny dashboard, otwarte endpointy (każdy z linkiem do dashboardu może przeglądać zgłoszenia i odpowiedzi).
  * [BigDataCloud](https://www.bigdatacloud.com/) - Szybkie, dokładne i darmowe (Nielimitowane lub do 10K-50K/mies.) API dla nowoczesnego web, m.in. geolokalizacja IP, odwrotne geokodowanie, walidacja e-mail/telefonu, informacje o kliencie i inne.
  * [Browse AI](https://www.browse.ai) — Ekstrakcja i monitoring danych z internetu. 1k kredytów miesięcznie za darmo, co odpowiada 1k równoczesnych żądań.
  * [BrowserCat](https://www.browsercat.com) - Headless browser API do automatyzacji, scrapingu, dostępu agentów AI do web, generowania obrazów/pdf i więcej. Darmowy plan: 1k żądań miesięcznie.
  * [Calendarific](https://calendarific.com) - API świąt publicznych klasy enterprise dla ponad 200 krajów. Darmowy plan zawiera 500 zapytań miesięcznie.
  * [Canopy](https://www.canopyapi.co/) - GraphQL API dla danych produktów, wyszukiwań i kategorii Amazon.com. Darmowy plan obejmuje 100 zapytań miesięcznie.
  * [Clarifai](https://www.clarifai.com) — API obrazów do customowej detekcji i rozpoznawania twarzy. Możliwość trenowania modeli AI. Darmowy plan: 1 000 zapytań miesięcznie.
  * [Cloudmersive](https://cloudmersive.com/) — Platforma API narzędziowych z szerokim dostępem do biblioteki API, m.in. konwersja dokumentów, skanowanie wirusów. 600 zapytań/miesiąc, tylko dla Ameryki Północnej, max 2,5 MB pliku.
  * [Colaboratory](https://colab.research.google.com) — Darmowe środowisko notebooków Python online z GPU Nvidia Tesla K80.
  * [CometML](https://www.comet.com/site/) - Platforma MLOps do śledzenia eksperymentów, zarządzania wdrożeniem modeli, rejestru modeli i pełnej historii danych, od treningu po produkcję. Darmowa dla osób indywidualnych i naukowców.
  * [Commerce Layer](https://commercelayer.io) - Komponowalne API e-commerce do budowania, składania i zarządzania zamówieniami z dowolnego frontendu. Plan developerski pozwala na 100 zamówień miesięcznie i do 1 000 SKU za darmo.
  * [Composio](https://composio.dev/) - Platforma integracyjna dla agentów AI i LLM. Integruje ponad 200 narzędzi w internecie agentowym.
  * [Conversion Tools](https://conversiontools.io/) - Konwerter plików online (dokumenty, obrazy, wideo, audio, eBooki). API REST, biblioteki dla Node.js, PHP, Pythona. Obsługa plików do 50 GB (dla płatnych planów). Darmowy tier: pliki do 20 MB, 30 konwersji/dzień, 300/miesiąc.
  * [Country-State-City Microservice API](https://country-state-city.rebuscando.info/) - API i mikroserwis dostarczający szerokiego zakresu informacji: kraje, regiony, prowincje, miasta, kody pocztowe i więcej. Darmowy tier do 100 żądań dziennie.
  * [Coupler](https://www.coupler.io/) - Narzędzie do integracji danych między aplikacjami. Pozwala tworzyć dashboardy i raporty live, przetwarzać i archiwizować dane. Darmowy plan: jeden użytkownik, jedno połączenie, jedno źródło i miejsce docelowe. Wymaga ręcznego odświeżania danych.
  * [CraftMyPDF](https://craftmypdf.com) - Automatyczne generowanie PDF ze szablonów z edytorem drag&drop i prostym API. Darmowy plan: 100 PDF/miesiąc i trzy szablony.
  * [Crawlbase](https://crawlbase.com/) — Skrapowanie stron bez proxy, infrastruktury czy przeglądarek. Rozwiązujemy captche i chronimy przed blokadą. Pierwsze 1000 wywołań za darmo.
  * [CurlHub](https://curlhub.io) — Proxy do inspekcji i debugowania wywołań API. Darmowy plan: 10 000 żądań miesięcznie.
  * [CurrencyScoop](https://currencyscoop.com) - API danych walutowych w czasie rzeczywistym dla aplikacji fintech. Darmowy plan: 5 000 zapytań miesięcznie.
  * [Cube](https://cube.dev/) - Cube pomaga inżynierom danych i deweloperom organizować i udostępniać dane z nowoczesnych baz. Najszybciej skorzystasz przez Cube Cloud: darmowy tier do 1 000 zapytań dziennie.
  * [Data Dead Drop](https://datadeaddrop.com) - Proste, darmowe udostępnianie plików. Dane kasują się po pobraniu. Przesyłanie i pobieranie przez przeglądarkę lub CLI.
  * [Data Fetcher](https://datafetcher.com) - Połącz Airtable z dowolną aplikacją lub API bez kodowania. Interfejs podobny do Postmana. Gotowe integracje z dziesiątkami aplikacji. Darmowy plan: 100 uruchomień miesięcznie.
  * [Dataimporter.io](https://www.dataimporter.io) - Narzędzie do łączenia, czyszczenia i importu danych do Salesforce. Darmowy plan: do 20 000 rekordów miesięcznie.
  * [Datalore](https://datalore.jetbrains.com) - Notatniki Python od Jetbrains. 10 GB miejsca i 120 godzin działania miesięcznie.
  * [Data Miner](https://dataminer.io/) - Rozszerzenie do przeglądarek (Chrome, Edge) do ekstrakcji danych z web do CSV lub Excela. Darmowy plan: 500 stron miesięcznie.
  * [Datapane](https://datapane.com) - API do budowy interaktywnych raportów w Pythonie i wdrażania skryptów Pythona oraz Jupyter Notebooków jako narzędzi samoobsługowych.
  * [DB-IP](https://db-ip.com/api/free) - Darmowe API geolokalizacji IP, 1k żądań na IP dziennie. Baza lite na licencji CC-BY 4.0 również za darmo.
  * [DB Designer](https://www.dbdesigner.net/) — Chmurowe narzędzie do projektowania i modelowania schematów baz danych, darmowy plan startowy: 2 modele baz i 10 tabel na model.
  * [DeepAR](https://developer.deepar.ai) — Filtry AR na twarz dla każdej platformy z jednym SDK. Darmowy plan: do 10 aktywnych użytkowników miesięcznie (MAU), śledzenie do 4 twarzy.
  * [Deepnote](https://deepnote.com) - Nowy notatnik data science. Kompatybilny z Jupyterem, współpraca w czasie rzeczywistym i praca w chmurze. Darmowy tier: nielimitowane projekty osobiste, nielimitowane maszyny basic (5GB RAM, 2vCPU), zespoły do 3 edytorów.
  * [Disease.sh](https://disease.sh/) — Darmowe API dostarczające dokładnych danych do budowy aplikacji związanych z Covid-19.
  * [Doczilla](https://www.doczilla.app/) — SaaS API do generowania screenshotów lub PDF bezpośrednio z HTML/CSS/JS. Darmowy plan: 250 dokumentów/miesiąc.
  * [Doppio](https://doppio.sh/) — Zarządzane API do generowania i prywatnego przechowywania PDF i screenshotów przy użyciu topowej technologii renderowania. Darmowy plan: 400 PDF i screenshotów miesięcznie.
  * [drawDB](https://drawdb.app/) — Darmowy i otwartoźródłowy edytor diagramów baz danych online, bez rejestracji.
  * [dreamfactory.com](https://dreamfactory.com/) — Otwartoźródłowy backend REST API dla aplikacji mobilnych, webowych i IoT. Podłącz dowolną bazę SQL/NoSQL, system plików lub serwis zewnętrzny — otrzymasz gotowe REST API z dokumentacją i zarządzaniem użytkownikami.
  * [Duply.co](https://duply.co) — Twórz dynamiczne obrazy przez API i URL, jeden szablon – wielokrotne użycie. Darmowy tier: 20 darmowych kredytów.
  * [DynamicDocs](https://advicement.io) - Generowanie PDF przez API JSON->PDF na bazie szablonów LaTeX. Darmowy plan: 50 wywołań API miesięcznie i dostęp do biblioteki szablonów.
  * [Efemarai](https://efemarai.com) - Platforma do testowania i debugowania modeli ML i danych. Wizualizacja każdego grafu obliczeniowego. Darmowa praca lokalna.
  * [ERD Lab](https://www.erdlab.io) —  Darmowe narzędzie ERD w chmurze dla developerów. Darmowy trial: 2 projekty po 10 tabel każdy.
  * [ExtendsClass](https://extendsclass.com/rest-client-online.html) - Darmowy HTTP client online do wysyłania zapytań HTTP.
  * [Export SDK](https://exportsdk.com) - Generator PDF przez API z edytorem szablonów drag&drop, SDK i integracjami no-code. Darmowy plan: 250 stron/mies., nielimitowani użytkownicy, trzy szablony.
  * [file.coffee](https://file.coffee/) - Platforma do przechowywania plików do 15 MB/plik (30 MB/plik po założeniu konta).
  * [Financial Data](https://financialdata.net/) - API danych giełdowych i finansowych. Darmowy plan: 300 żądań dziennie.
  * [FormatJSONOnline.com](https://formatjsononline.com) - Darmowe narzędzie online do formatowania, walidacji, porównywania i minimalizacji JSONów w przeglądarce.
  * [FraudLabs Pro](https://www.fraudlabspro.com) — Weryfikacja transakcji kartą kredytową pod kątem oszustw. REST API wykrywa wszelkie możliwe cechy fraudu na podstawie parametrów zamówienia. Darmowy plan Micro: 500 transakcji miesięcznie.
  * [GeoDataSource](https://www.geodatasource.com) — Usługa wyszukiwania lokalizacji po współrzędnych. Darmowe API: 500 zapytań miesięcznie.
  * [Geolocated.io](https://geolocated.io) — API geolokalizacyjne IP z serwerami na wielu kontynentach, darmowy plan: 2 000 zapytań dziennie.
  * [Glitterly](https://glitterly.app/) - Programatyczne generowanie dynamicznych obrazów z bazowych szablonów. API Restful i integracje no-code. Darmowy tier: 50 obrazów/mies. i pięć szablonów.
  * [Hex](https://hex.tech/) - Platforma współpracy nad notatnikami, aplikacjami danych i bibliotekami wiedzy. Darmowy poziom community: do pięciu projektów.
  * [Hook0](https://www.hook0.com/) - Hook0 to otwartoźródłowy Webhooks-as-a-service (WaaS), łatwo dodający webhooki do produktów online. Darmowo: do 100 zdarzeń/dzień, 7 dni historii.
  * [Hoppscotch](https://hoppscotch.io) - Darmowy, szybki i estetyczny builder zapytań API.
  * [huggingface.co](https://huggingface.co) - Tworzenie, trenowanie i wdrażanie modeli NLP dla Pytorch, TensorFlow i JAX. Darmowo do 30k znaków wejściowych/mies.
  * [Hybiscus](https://hybiscus.dev/) - Buduj raporty PDF przez prosty, deklaratywny API. Darmowy 14-dniowy tier: 50 jednostronicowych raportów z możliwością personalizacji palet kolorów i czcionek.
  * [Invantive Cloud](https://cloud.invantive.com/) — Dostęp do ponad 70 platform (m.in. Exact Online, Twinfield, ActiveCampaign, Visma) przez Invantive SQL lub OData4 (typowo Power BI/Power Query). Replikacja i wymiana danych. Darmowy plan dla deweloperów i konsultantów wdrożeniowych. Darmowe dla wybranych platform z ograniczeniem wolumenu danych.
  * [ipaddress.sh](https://ipaddress.sh) — Prosta usługa zwracająca publiczny adres IP w różnych [formatach](https://about.ipaddress.sh/).
  * [ip-api](https://ip-api.com) — API geolokalizacyjne IP, darmowe do niekomercyjnego użytku, brak klucza API, limit 45 zapytań/min z tego samego IP.
  * [ipbase.com](https://ipbase.com) - API geolokalizacyjne IP — wiecznie darmowy plan obejmuje 150 żądań miesięcznie.
  * [IP Geolocation](https://ipgeolocation.io/) — API geolokalizacyjne IP — wiecznie darmowy plan dla developerów, limit 1 000 zapytań dziennie.
  * [IP Geolocation API](https://www.abstractapi.com/ip-geolocation-api) — API geolokalizacyjne IP od Abstract — 1 000 darmowych zapytań.
  * [IPLocate](https://www.iplocate.io) — API geolokalizacyjne IP, darmowe do 1 000 zapytań/dzień. W tym detekcja proxy/VPN/hostingu, dane ASN, IP do firmy i więcej. IPLocate oferuje też darmowe bazy IP do kraju i IP do ASN w CSV/MMDB.
  * [IP2Location](https://www.ip2location.com) — Usługa freemium geolokalizacji IP. Baza LITE dostępna do darmowego pobrania. Możesz zaimportować bazę i lokalnie określać miasto, współrzędne i ISP.
  * [IP2Location.io](https://www.ip2location.io/) — Freemium, szybkie i niezawodne API geolokalizacyjne IP. Dane: miasto, współrzędne, ISP i inne. Darmowy plan: 50k kredytów/miesiąc. Dodatkowo 500 darmowych zapytań WHOIS i hostowanych domen miesięcznie. Szczegóły rejestracji domen i domeny na danym IP. Więcej opcji w płatnych planach.
  * [ipapi](https://ipapi.co/) - API lokalizacji IP od Kloudend, Inc — niezawodne API na AWS, używane przez Fortune 500. Darmowy tier: 30k lookupów/mies. (1k/dzień) bez rejestracji.
  * [ipapi.is](https://ipapi.is/) - Niezawodne API adresów IP od deweloperów dla deweloperów z najlepszym wykrywaniem hostingu. Darmowy plan: 1000 lookupów bez rejestracji.
  * [IPinfo](https://ipinfo.io/) — Szybkie, dokładne i darmowe (do 50k/mies.) API danych IP. API: geolokalizacja, firmy, operatorzy, zakresy IP, domeny, kontakty abuse i więcej. Wszystkie płatne API dostępne w wersjach testowych za darmo.
  * [IPQuery](https://ipquery.io) — Nielimitowane API IP dla deweloperów, bez limitów i opłat.
  * [IPTrace](https://iptrace.io) — Bardzo proste API dostarczające rzetelnych danych geolokalizacyjnych IP, 50 000 lookupów miesięcznie za darmo.
  * [JSON2Video](https://json2video.com) - API do automatycznej edycji wideo marketingowego i na social media, programatycznie lub bez kodu.
  * [JSON IP](https://getjsonip.com) — Zwraca publiczny adres IP klienta, z którego pochodzi żądanie. Brak rejestracji dla darmowego tieru. Dzięki CORS dane mogą być pobierane przez JS bezpośrednio z przeglądarki. Przydatne do monitorowania zmian IP klienta i serwera. Brak limitu żądań.
  * [JSON Serve](https://jsonserve.com/) — Darmowa usługa pomagająca deweloperom przechowywać obiekty JSON i używać ich jako REST API w aplikacji.
  * [JSONing](https://jsoning.com/api/) — Twórz fake REST API z obiektu JSON, ustawiaj kody statusu HTTP, nagłówki i odpowiedzi.
  * [konghq.com](https://konghq.com/) — Marketplace API i potężne narzędzia do prywatnych i publicznych API. Darmowy tier: monitoring, alerty i wsparcie ograniczone.
  * [Kreya](https://kreya.app) — Darmowy klient GUI do gRPC do wywoływania i testowania API gRPC. Import API gRPC przez server reflection.
  * [Lightly](https://www.lightly.ai/) — Popraw swoje modele ML dzięki odpowiednim danym. Używaj zbiorów do 1000 próbek za darmo.
  * [LoginLlama](https://loginllama.app) - API bezpieczeństwa logowania wykrywające podejrzane i oszukańcze logowania oraz powiadamiające klientów. Darmowe do 1 000 logowań miesięcznie.
  * [MailboxValidator](https://www.mailboxvalidator.com) — Weryfikacja e-maili przez rzeczywiste połączenie z serwerem poczty. Darmowy plan API: 100 weryfikacji miesięcznie.
  * [Market Data API](https://www.marketdata.app) - Dostarcza bieżące i historyczne dane finansowe dla akcji, opcji, funduszy i więcej. Darmowy tier API: 100 dziennych zapytań za darmo.
  * [Meteosource Weather API](https://www.meteosource.com/) — globalne API pogodowe dla aktualnych i prognozowanych danych pogodowych. Prognozy oparte są na uczeniu maszynowym, łączącym wiele modeli pogodowych w celu uzyskania większej dokładności. Darmowy plan obejmuje 400 wywołań dziennie.
  * [microlink.io](https://microlink.io/) – Zamienia dowolną stronę internetową w dane, takie jak normalizacja metatagów, piękne podglądy linków, możliwości scrapingu lub zrzuty ekranu jako usługa. 50 żądań dziennie, codziennie za darmo.
  * [Mindee](https://developers.mindee.com) – Mindee to zaawansowane oprogramowanie OCR i platforma API-first pomagająca programistom automatyzować przepływy pracy aplikacji przez standaryzację warstwy przetwarzania dokumentów dzięki rozpoznawaniu kluczowych informacji za pomocą computer vision i uczenia maszynowego. Darmowy poziom obejmuje 500 stron miesięcznie.
  * [Mintlify](https://mintlify.com) — Nowoczesny standard dokumentacji API. Piękne i łatwe w utrzymaniu komponenty UI, wyszukiwanie w aplikacji i interaktywne środowisko testowe. Za darmo dla 1 edytora.
  * [MockAPI](https://www.mockapi.io/) — MockAPI to proste narzędzie pozwalające szybko tworzyć makiety API, generować niestandardowe dane i wykonywać operacje za pomocą interfejsu RESTful. MockAPI jest przeznaczone jako narzędzie do prototypowania/testowania/nauki. Jeden projekt/2 zasoby na projekt za darmo.
  * [Mockfly](https://www.mockfly.dev/) — Mockfly to zaufane narzędzie deweloperskie do mockowania API i zarządzania flagami funkcji. Szybko generuj i kontroluj makiety API dzięki intuicyjnemu interfejsowi. Darmowy poziom oferuje 500 żądań dziennie.
  * [Mocki](https://mocki.io) - Narzędzie umożliwiające tworzenie mockowanych API GraphQL i REST zsynchronizowanych z repozytorium GitHub. Proste REST API można tworzyć i używać za darmo bez rejestracji.
  * [Mocko.dev](https://mocko.dev/) — Proxy dla Twojego API, wybierz które endpointy chcesz mockować w chmurze i monitoruj ruch – za darmo. Przyspiesz swój rozwój i testy integracyjne.
  * [Mocky](https://designer.mocky.io/) - Prosta aplikacja webowa do generowania niestandardowych odpowiedzi HTTP do mockowania żądań HTTP. Dostępny także jako [open source](https://github.com/julien-lafont/Mocky).
  * [Mock N Roll](https://mpcknroll.me/) - Darmowy serwis Mocks API — potężne narzędzie do symulowania prawdziwych odpowiedzi API bez opóźnień backendu. Idealny dla frontendowców, testerów QA i zespołów DevOps. [repo](https://github.com/haerulmuttaqin/mocknroll-web).
  * [microenv.com](https://microenv.com) — Tworzenie fikcyjnych REST API dla deweloperów z możliwością generowania kodu i aplikacji w kontenerze Docker.
  * [Multi-Exit IP Address Checker](https://ip.alstra.ca/) — Darmowe i proste narzędzie do sprawdzania swojego adresu IP wyjściowego na wielu węzłach i zrozumienia, jak Twój IP wygląda w różnych regionach świata i usługach. Przydatne do testowania narzędzi typu DNS split, takich jak Control D.
  * [Namekit](https://namekit.app/) - Oparty na AI system do odkrywania domen – natychmiast znajdź dostępne, standardowo wycenione nazwy. Darmowe dzienne zapytania.
  * [News API](https://newsapi.org) — Przeszukuj wiadomości w Internecie kodem i otrzymuj wyniki w formacie JSON. Programiści mają 100 darmowych zapytań dziennie. Artykuły mają 24 godziny opóźnienia.
  * [numlookupapi.com](https://numlookupapi.com) - Darmowe API do walidacji numerów telefonów – 100 darmowych żądań/miesiąc.
  * [OCR.Space](https://ocr.space/) — API OCR przetwarzające obrazy i pliki pdf, zwracające wyniki tekstowe w formacie JSON. 25 000 darmowych żądań miesięcznie i limit rozmiaru pliku do 1MB.
  * [OpenAPI3 Designer](https://openapidesigner.com/) — Wizualne tworzenie definicji Open API 3 za darmo.
  * [parsehub.com](https://parsehub.com/) — Wyodrębniaj dane z dynamicznych stron, zamieniaj dynamiczne strony www w API, pięć projektów za darmo.
  * [Parseur](https://parseur.com) — 20 darmowych stron/miesiąc: Wyodrębniaj dane z PDF-ów, e-maili. Oparte na AI. Pełny dostęp do API.
  * [PDFBolt](https://pdfbolt.com) - API do generowania PDF skoncentrowane na prywatności, zaprojektowane dla programistów. Inspiracja dokumentacją Stripe i 500 darmowych konwersji PDF miesięcznie.
  * [pdfEndpoint.com](https://pdfendpoint.com) - Łatwa konwersja HTML lub adresów URL do PDF przez proste API. Sto konwersji miesięcznie za darmo.
  * [PDF-API.io](https://pdf-api.io) - Automatyzacja PDF przez API, wizualny edytor szablonów lub HTML do PDF, integracja dynamicznych danych i renderowanie PDF przez API. Darmowy plan obejmuje jeden szablon, 100 PDF/miesiąc.
  * [Pixela](https://pixe.la/) - Darmowa usługa bazy danych daystream. Wszystkie operacje odbywają się przez API. Możliwa wizualizacja przez heat mapy i wykresy liniowe.
  * [Postman](https://postman.com) — Upraszczaj przepływy pracy i twórz lepsze API – szybciej – dzięki Postmanowi, platformie do współpracy nad rozwojem API. Aplikacja Postman jest darmowa na zawsze. Chmurowe funkcje Postmana także są darmowe z pewnymi ograniczeniami.
  * [Insomnia](https://insomnia.rest) - Otwarty klient API do projektowania i testowania API, obsługuje REST i GraphQL.
  * [PrefectCloud](https://www.prefect.io/cloud/) — Kompleksowa platforma do automatyzacji przepływów danych. Darmowy plan obejmuje 5 wdrożonych workflowów i 500 minut serwerlessowych kredytów miesięcznie.
  * [Preset Cloud](https://preset.io/) - Hostowana usługa Apache Superset. Na zawsze za darmo dla zespołów do 5 użytkowników, nieograniczona liczba dashboardów i wykresów, kreator wykresów bez kodu i wspólny edytor SQL.
  * [PromptLoop](https://www.promptloop.com/) - PromptLoop oferuje 10x łatwiejszy AI web scraping, niemal zerowy czas wdrożenia, 85%+ oszczędności czasu na istniejących workflowach i działa 4x szybciej niż ręczne badania, bez kompromisów. Zawiera endpoint API REST dla wszystkich zadań badawczych. Pierwsze 1000 kredytów miesięcznie za darmo.
  * [Public-Apis Github Repo](https://github.com/public-apis/public-apis) — Lista darmowych publicznych API.
  * [Rapidapi](https://rapidapi.com/) - Największy hub API na świecie. Miliony programistów znajduje i łączy się z tysiącami API, rozwijaj API przez zabawy z zadaniami (z rozwiązaniami!) i interaktywnymi przykładami.
  * [RequestBin.com](https://requestbin.com) — Stwórz darmowy endpoint, na który możesz wysyłać żądania HTTP. Wszystkie żądania HTTP wysłane na ten endpoint będą rejestrowane wraz z payloadem i nagłówkami, dzięki czemu możesz obserwować rekomendacje z webhooków i innych usług.
  * [reqres.in](https://reqres.in) - Darmowe hostowane REST-API gotowe do odpowiadania na Twoje żądania AJAX.
  * [Roboflow](https://roboflow.com) - Twórz i wdrażaj własny model computer vision bez doświadczenia z ML. Darmowy poziom obejmuje 30 kredytów miesięcznie.
  * [ROBOHASH](https://robohash.org/) - Usługa webowa do generowania unikalnych i ciekawych obrazków na podstawie dowolnego tekstu.
  * [Scraper's Proxy](https://scrapersproxy.com) — Proste API proxy HTTP do scrapowania. Scrapuj anonimowo bez martwienia się o ograniczenia, blokady czy captche. Pierwsze 100 udanych scrapów miesięcznie za darmo, w tym renderowanie javascriptu (więcej po kontakcie z supportem).
  * [ScrapingAnt](https://scrapingant.com/) — Headless Chrome scraping API i darmowa usługa sprawdzonych proxy. Renderowanie javascript, premium rotacyjne proxy, unikanie CAPTCHA. Darmowe 10 000 kredytów API.
  * [Simplescraper](https://simplescraper.io) — Uruchom webhook po każdej operacji. Darmowy plan obejmuje 100 kredytów cloud scrape.
  * [Select Star](https://www.selectstar.com/) - Inteligentna platforma do odkrywania danych, która automatycznie analizuje i dokumentuje Twoje dane. Darmowy, lekki poziom: 2 źródła danych, do 1 000 tabel i 25 użytkowników.
  * [Sheetson](https://sheetson.com) - Zamień dowolny Google Sheets w RESTful API. Dostępny darmowy plan, obejmujący 1 000 darmowych wierszy na arkusz.
  * [Shipyard](https://www.shipyardapp.com) — Platforma low-code do orkiestracji danych w chmurze. Buduj za pomocą szablonów low-code i własnego kodu (Python, Node.js, Bash, SQL). Nasz darmowy plan deweloperski oferuje 10 godzin czasu działania miesięcznie dla jednego użytkownika – wystarczająco, aby zautomatyzować wiele workflowów.
  * [Siterelic](https://siterelic.com/) - API Siterelic umożliwia robienie zrzutów ekranu, audytowanie stron, skanowanie TLS, sprawdzanie DNS, testowanie TTFB i inne. Darmowy plan oferuje 100 żądań API miesięcznie.
  * [SerpApi](https://serpapi.com/) - API do scrapowania wyszukiwarek w czasie rzeczywistym. Zwraca ustrukturyzowane wyniki JSON dla Google, YouTube, Bing, Baidu, Walmart i wielu innych. Darmowy plan obejmuje 100 udanych wywołań API miesięcznie.
  * [SmartParse](https://smartparse.io) - SmartParse to platforma do migracji danych i CSV do API, oferująca narzędzia oszczędzające czas i koszty. Darmowy poziom obejmuje 300 jednostek przetwarzania miesięcznie, przesyłanie plików przez przeglądarkę, kwarantannę danych, bezpieczniki i alerty zadań.
  * [Sofodata](https://www.sofodata.com/) - Twórz bezpieczne RESTful API z plików CSV. Prześlij plik CSV i natychmiast uzyskaj dostęp do danych przez API, umożliwiając szybszy rozwój aplikacji. Darmowy plan obejmuje 2 API i 2 500 wywołań API miesięcznie. Bez potrzeby karty kredytowej.
  * [Sqlable](https://sqlable.com/) - Zestaw darmowych narzędzi SQL online, w tym formatowanie i walidacja SQL, testowanie wyrażeń regularnych SQL, generator fikcyjnych danych i interaktywne playgroundy baz danych.
  * [Stoplight](https://stoplight.io/) - SaaS do wspólnego projektowania i dokumentowania API. Darmowy plan oferuje darmowe narzędzia do projektowania, mockowania i dokumentacji.
  * [Supportivekoala](https://supportivekoala.com/) — Pozwala automatycznie generować obrazy na podstawie Twojego wejścia przez szablony. Darmowy plan pozwala tworzyć do 50 obrazów miesięcznie.
  * [Svix](https://www.svix.com/) - Webhooki jako usługa. Wysyłaj do 50 000 wiadomości miesięcznie za darmo.
  * [Tavily AI](https://tavily.com/) - API do wyszukiwania online i szybkich wniosków oraz kompleksowych badań, z możliwością organizacji wyników. 1000 żądań/miesiąc w darmowym poziomie, bez karty kredytowej.
  * [The IP API](https://theipapi.com/) - API geolokalizacji IP z 1000 darmowych żądań/dzień. Dostarcza informacji o lokalizacji adresu IP, w tym kraju, mieście, regionie i innych.
  * [TinyMCE](https://www.tiny.cloud) - API do edycji tekstu. Podstawowe funkcje są darmowe bez limitu użycia.
  * [Tomorrow.io Weather API](https://www.tomorrow.io/weather-api/) - Oferuje darmowy plan API pogodowego. Zapewnia dokładne i aktualne prognozy pogody z globalnym zasięgiem, danymi historycznymi i rozwiązaniami do monitorowania pogody.
  * [Treblle](https://www.treblle.com) - Treblle pomaga zespołom budować, wdrażać i zarządzać API. Zaawansowana agregacja logów API, obserwowalność, dokumentacja i debugowanie. Wszystkie funkcje za darmo, ale limit do 250 tys. żądań miesięcznie na darmowym poziomie.
  * [UniRateAPI](https://unirateapi.com) – Kursy walut w czasie rzeczywistym dla 590+ walut i kryptowalut. Nielimitowane wywołania API w darmowym planie, idealne dla programistów i aplikacji finansowych.
  * [vatcheckapi.com](https://vatcheckapi.com) - Proste i darmowe API do walidacji numerów VAT. 150 darmowych walidacji miesięcznie.
  * [WeatherXu](https://weatherxu.com/) — Globalne dane pogodowe, w tym aktualne warunki, prognozy godzinowe i dzienne oraz alerty pogodowe przez API. Integracja modeli AI i systemów ML do analizy i łączenia wielu modeli pogodowych w celu poprawy dokładności prognoz. Darmowy poziom obejmuje 10 000 wywołań API/miesiąc.
  * [Webhook Store](https://www.openwebhook.io) - Narzędzie do przechowywania webhooków firm trzecich i debugowania ich lokalnie (styl ngrok). Open source i do samodzielnego hostowania. Darmowa osobista domena *username*.github.webhook.store, darmowe domeny publiczne *anything*.webhook.store.
  * [WebScraping.AI](https://webscraping.ai) - Proste API do scrapowania stron z wbudowanym parsowaniem, renderowaniem Chrome i proxy. Dwa tysiące darmowych wywołań API miesięcznie.
  * [Weights & Biases](https://wandb.ai) — Platforma MLOps stworzona z myślą o programistach. Buduj lepsze modele szybciej dzięki śledzeniu eksperymentów, wersjonowaniu zbiorów danych i zarządzaniu modelami. Darmowy poziom tylko do projektów osobistych, obejmuje 100 GB miejsca.
  * [What The Diff](https://whatthediff.ai) - Asystent przeglądu kodu oparty na AI. Darmowy plan ma limit 25 000 tokenów miesięcznie (~10 PR).
  * [wolfram.com](https://wolfram.com/language/) — Wbudowane algorytmy bazujące na wiedzy w chmurze.
  * [wrapapi.com](https://wrapapi.com/) — Zamień dowolną stronę internetową w sparametryzowane API. 30 tys. wywołań API miesięcznie.
  * [Zenscrape](https://zenscrape.com/web-scraping-api) — API do scrapowania stron z headless browserami, adresami IP rezydencyjnymi i prostym cennikiem. Tysiąc darmowych wywołań API/miesiąc i dodatkowe kredyty dla studentów i organizacji non-profit.
  * [Zipcodebase](https://zipcodebase.com) - Darmowe API kodów pocztowych, dostęp do danych kodów pocztowych na całym świecie. 5 000 darmowych żądań/miesiąc.
  * [Zipcodestack](https://zipcodestack.com) - Darmowe API kodów pocztowych i walidacja kodów pocztowych. Dziesięć tysięcy darmowych żądań/miesiąc.
  * [Zuplo](https://zuplo.com/) - Darmowa platforma do zarządzania API do projektowania, budowania i wdrażania API na Edge. Dodaj uwierzytelnianie API Key, limitowanie żądań, dokumentację dla deweloperów i monetyzację do dowolnego API w kilka minut. OpenAPI-native i w pełni programowalna z web standard APIs & Typescript. Darmowy plan: do 10 projektów, nielimitowane produkcyjne środowiska edge, 1 mln żądań miesięcznie i 10GB transferu.

**[⬆️ Powrót na górę](#table-of-contents)**

## Repozytoria artefaktów

  * [Artifactory](https://jfrog.com/start-free/) - Repozytorium artefaktów obsługujące liczne formaty paczek jak Maven, Docker, Cargo, Helm, PyPI, CocoaPods i GitLFS. Zawiera narzędzie do skanowania paczek XRay i narzędzie CI/CD Pipelines (dawniej Shippable) z darmowym limitem 2 000 minut CI/CD miesięcznie.
  * [central.sonatype.org](https://central.sonatype.org) — Domyślne repozytorium artefaktów dla Apache Maven, SBT i innych systemów budowania.
  * [cloudrepo.io](https://cloudrepo.io) - Prywatne i publiczne repozytoria Maven i PyPi oparte na chmurze. Darmowe dla projektów open-source.
  * [cloudsmith.io](https://cloudsmith.io) — Prosta, bezpieczna i scentralizowana usługa repozytorium dla Java/Maven, RedHat, Debian, Python, Ruby, Vagrant i innych. Darmowy poziom + darmowe dla open source.
  * [jitpack.io](https://jitpack.io/) — Repozytorium Maven dla projektów JVM i Android na GitHubie, darmowe dla projektów publicznych.
  * [packagecloud.io](https://packagecloud.io/users/new?plan=free_usage_plan) — Łatwe w użyciu hostowanie repozytorium dla paczek Maven, RPM, DEB, PyPi, NPM i RubyGem (ma darmowy poziom).
  * [repsy.io](https://repsy.io) — 1 GB darmowego prywatnego/publicznego repozytorium Maven.
  * [Gemfury](https://gemfury.com) — Prywatne i publiczne repozytoria artefaktów dla Maven, PyPi, NPM, Go Module, Nuget, APT i RPM. Darmowe dla projektów publicznych.
  * [paperspace](https://www.paperspace.com/) — Buduj i skaluj modele AI, rozwijaj, trenuj i wdrażaj aplikacje AI, darmowy plan: projekty publiczne, 5 GB miejsca, podstawowe instancje.
  * [RepoForge](https://repoforge.io) - Prywatne repozytorium w chmurze dla paczek Python, Debian, NPM i rejestrów Docker. Darmowy plan dla projektów open source/publicznych.
  * [RepoFlow](https://repoflow.io) - RepoFlow upraszcza zarządzanie paczkami z obsługą npm, PyPI, Docker, Go, Helm i innych. Wypróbuj za darmo: 10 GB miejsca, 10 GB transferu, 100 paczek i nielimitowani użytkownicy w chmurze lub self-hosted tylko do użytku osobistego.

**[⬆️ Powrót na górę](#table-of-contents)**

## Narzędzia dla zespołów i współpracy
  * [3Cols](https://3cols.com/) - Darmowy menedżer fragmentów kodu w chmurze do osobistego i zespołowego użytku.
  * [Bitwarden](https://bitwarden.com) — Najprostszy i najbezpieczniejszy sposób dla osób indywidualnych, zespołów i firm na przechowywanie, udostępnianie i synchronizację wrażliwych danych.
  * [Braid](https://www.braidchat.com/) — Aplikacja czatowa dla zespołów. Za darmo dla publicznych grup, nielimitowanych użytkowników, historii i integracji. Dostępna także wersja open source do samodzielnego hostowania.
  * [cally.com](https://cally.com/) — Znajdź idealny termin i godzinę na spotkanie. Proste w obsłudze, świetnie działa w małych i dużych grupach.
  * [Calendly](https://calendly.com) — Calendly to narzędzie do łączenia się i planowania spotkań. Darmowy plan to 1 połączenie z kalendarzem na użytkownika i nielimitowane sesje. Oferowane są także aplikacje na desktop i mobile.
  * [Discord](https://discord.com/) — Czat z pokojami publicznymi/prywatnymi. Tekst Markdown, głos, wideo i udostępnianie ekranu. Darmowe dla nieograniczonej liczby użytkowników.
  * [Fibo](https://fibo.dev) - Darmowe, internetowe narzędzie do scrum pokera w czasie rzeczywistym dla zespołów agile, pozwala nieograniczonej liczbie członków szacować punkty historyjek dla szybszego planowania.
  * [Telegram](https://telegram.org/) — Telegram jest dla każdego, kto chce szybkiej, niezawodnej komunikacji i rozmów. Użytkownicy biznesowi i małe zespoły docenią duże grupy, nicki, aplikacje desktopowe i mocne możliwości udostępniania plików.
  * [DevToolLab](https://devtoollab.com) — Narzędzia programistyczne online z darmowym dostępem do wszystkich podstawowych narzędzi, możliwością autozapisu jednego wpisu na narzędzie, standardową prędkością przetwarzania i wsparciem społeczności.
  * [Dubble](https://dubble.so/) — Darmowy kreator instrukcji krok po kroku. Rób zrzuty ekranu, dokumentuj procesy i współpracuj z zespołem. Wspiera także asynchroniczne nagrywanie ekranu.
  * [Duckly](https://duckly.com/) — Rozmawiaj i współpracuj w czasie rzeczywistym z zespołem. Pair programming z udostępnianiem IDE, terminala, głosu, wideo i ekranu. Za darmo dla małych zespołów.
  * [Dyte](https://dyte.io) - Najbardziej przyjazne programistom SDK do live video & audio, z wtyczkami do współpracy dla zwiększenia produktywności i zaangażowania. Darmowy poziom obejmuje 10 000 minut miesięcznie transmisji wideo/audio na żywo.
  * [evernote.com](https://evernote.com/) — Narzędzie do organizowania informacji. Udostępniaj notatki i współpracuj z innymi.
  * [Fibery](https://fibery.io/) — Połączona platforma do pracy zespołowej. Za darmo dla pojedynczego użytkownika, do 2 GB miejsca na dysku.
  * [flock.com](https://flock.com) — Szybszy sposób komunikacji w zespole. Darmowe nieograniczone wiadomości, kanały, użytkownicy, aplikacje i integracje.
  * [Gather](https://www.gather.town/) - Lepszy sposób na spotkania online. Skupiony wokół w pełni konfigurowalnych przestrzeni, Gather sprawia, że spędzanie czasu z Twoimi społecznościami jest tak łatwe, jak w prawdziwym życiu. Darmowe dla maksymalnie 10 jednoczesnych użytkowników.
  * [gokanban.io](https://gokanban.io) - Tablica Kanban oparta na składni, bez rejestracji, do szybkiego użycia. Darmowa bez ograniczeń.
  * [flat.social](https://flat.social) - Interaktywne, konfigurowalne przestrzenie do spotkań zespołowych i integracji. Nieograniczona liczba spotkań, darmowe do 8 jednoczesnych użytkowników.
  * [GitDailies](https://gitdailies.com) - Codzienne raporty aktywności commitów i pull requestów Twojego zespołu na GitHubie. Zawiera wizualizator Push, system uznaniowy oraz kreator własnych alertów. Darmowy poziom pozwala na nieograniczoną liczbę użytkowników, trzy repozytoria i 3 konfiguracje alertów.
  * [gitter.im](https://gitter.im/) — Czat dla GitHub. Nieograniczona liczba publicznych i prywatnych pokoi, darmowe dla zespołów do 25 osób.
  * [Hackmd.io](https://hackmd.io/) - Narzędzie do współpracy i pisania w czasie rzeczywistym w formacie markdown. Jak Google Docs, ale dla plików markdown. Darmowa nieograniczona liczba "notatek", ale liczba współpracowników (zaproszonych) dla notatek prywatnych i szablonów [będzie ograniczona](https://hackmd.io/pricing).
  * [hangouts.google.com](https://hangouts.google.com/) — Jedno miejsce na wszystkie rozmowy, za darmo, wymagane konto Google.
  * [HeySpace](https://hey.space) - Narzędzie do zarządzania zadaniami z czatem, kalendarzem, osią czasu i rozmowami wideo. Darmowe do 5 użytkowników.
  * [helplightning.com](https://www.helplightning.com/) — Pomoc wideo z rozszerzoną rzeczywistością. Darmowe bez analityki, szyfrowania i wsparcia.
  * [ideascale.com](https://ideascale.com/) — Pozwól klientom zgłaszać pomysły i głosować, darmowe dla 25 członków w 1 społeczności.
  * [Igloo](https://www.igloosoftware.com/) — Wewnętrzny portal do udostępniania dokumentów, blogów, kalendarzy itp. Darmowe do 10 użytkowników.
  * [Keybase](https://keybase.io/) — Keybase to alternatywa FOSS dla Slacka; zabezpiecza czaty i pliki wszystkich, od rodzin po firmy.
  * [Google Meet](https://meet.google.com/) — Używaj Google Meet do potrzeb spotkań wideo online w firmie. Meet zapewnia bezpieczne, łatwe w użyciu spotkania online.
  * [/meet for Slack](https://meetslack.com) - Uruchamiaj spotkania Google bezpośrednio ze Slacka, wpisując /meet w dowolnym kanale, grupie lub DM. Darmowe bez ograniczeń.
  * [Livecycle](https://www.livecycle.io/) — Livecycle to inkluzywna platforma współpracy, która ułatwia workflow zespołom produktowym oraz projektom open-source.
  * [Lockitbot](https://www.lockitbot.com/) — Rezerwuj i blokuj współdzielone zasoby w Slacku, takie jak pokoje, środowiska developerskie, serwery itp. Darmowe dla maksymalnie 2 zasobów.
  * [MarkUp](https://www.markup.io/) — MarkUp pozwala zbierać opinie bezpośrednio na stronach, PDF-ach i obrazach.
  * [Proton Pass](https://proton.me/pass) — Menedżer haseł z wbudowanymi aliasami e-mail, autoryzatorem 2FA, udostępnianiem i kluczami dostępu. Dostępny w wersji web, rozszerzeniu przeglądarkowym, aplikacji mobilnej i desktopowej.
  * [Visual Debug](https://visualdebug.com) - Narzędzie do wizualnej informacji zwrotnej dla lepszej komunikacji klient-deweloper.
  * [meet.jit.si](https://meet.jit.si/) — Jednoklikowe rozmowy wideo i udostępnianie ekranu, za darmo.
  * [Microsoft Teams](https://products.office.com/microsoft-teams/free) — Microsoft Teams to cyfrowy hub oparty na czacie, który łączy rozmowy, treści i aplikacje w jednym miejscu. Darmowe do 500 tys. użytkowników.
  * [Miro](https://miro.com/) - Skalowalna, bezpieczna, wieloplatformowa tablica do współpracy dla rozproszonych zespołów. Z planem freemium.
  * [nootiz](https://www.nootiz.com/) - Narzędzie do zbierania i zarządzania wizualną informacją zwrotną na dowolnej stronie internetowej.
  * [Notion](https://www.notion.so/) - Notion to aplikacja do notatek i współpracy z obsługą markdown, integrująca zadania, wiki i bazy danych. Opisywana jako wszechstronne środowisko pracy do notatek, zarządzania projektami i zadaniami. Dostępna jako aplikacja wieloplatformowa i przez przeglądarkę.
  * [Nuclino](https://www.nuclino.com) - Lekka i wspólna wiki na potrzeby wiedzy, dokumentów i notatek zespołu. Darmowy plan z wszystkimi podstawowymi funkcjami, do 50 elementów i 5 GB przestrzeni.
  * [OnlineInterview.io](https://onlineinterview.io/) - Darmowa platforma do rozmów kwalifikacyjnych z wbudowanym czatem wideo, tablicą do rysowania i edytorem kodu online z możliwością kompilacji i uruchamiania kodu w przeglądarce. Możesz utworzyć zdalny pokój rozmów jednym kliknięciem.
  * [Quidlo Timesheets](https://www.quidlo.com/timesheets) - Prosta aplikacja do ewidencji czasu pracy i śledzenia czasu dla zespołów. Darmowy plan umożliwia śledzenie czasu i generowanie raportów dla maksymalnie 10 użytkowników.
  * [PageShare.dev](https://www.pageshare.dev) - Dodaje możliwości wizualnej recenzji do Pull Requestów na GitHubie bez konieczności wdrażania stron. Darmowe do 10 stron miesięcznie i 100 MB przestrzeni.
  * [Pendulums](https://pendulums.io/) - Darmowe narzędzie do śledzenia czasu, które pomaga lepiej zarządzać czasem dzięki prostemu interfejsowi i przydatnym statystykom.
  * [Pumble](https://pumble.com) - Darmowy czat zespołowy. Nieograniczona liczba użytkowników i historii wiadomości, na zawsze.
  * [Raindrop.io](https://raindrop.io) - Prywatna i bezpieczna aplikacja do zakładek dla macOS, Windows, Android, iOS i Web. Darmowe nieograniczone zakładki i współpraca.
  * [element.io](https://element.io/) — Zdecentralizowane i open-source narzędzie komunikacyjne oparte na Matrix. Czat grupowy, wiadomości bezpośrednie, szyfrowany transfer plików, rozmowy głosowe i wideo, integracje z innymi usługami.
  * [Rocket.Chat](https://rocket.chat/) - Otwarta platforma komunikacyjna z funkcjami Omnichannel, federacją Matrix, mostami do innych aplikacji, nieograniczoną liczbą wiadomości i pełną historią.
  * [seafile.com](https://www.seafile.com/) — Prywatna lub chmurowa przestrzeń dyskowa, udostępnianie plików, synchronizacja, dyskusje. Wersja chmurowa oferuje tylko 1 GB.
  * [Sema](https://www.semasoftware.com/) - Darmowe narzędzie do portfolio dla programistów, konsolidujące i podsumowujące wkład z wielu repozytoriów w jednym raporcie.
  * [Screen Sharing via Browser](https://screensharing.net) - Darmowe narzędzie do udostępniania ekranu, dziel się ekranem ze współpracownikami bezpośrednio z przeglądarki, bez pobierania i rejestracji. Za darmo.
  * [Slab](https://slab.com/) — Nowoczesna usługa zarządzania wiedzą dla zespołów. Darmowe do 10 użytkowników.
  * [slack.com](https://slack.com/) — Darmowe dla nieograniczonej liczby użytkowników z pewnymi ograniczeniami funkcjonalności.
  * [Spectrum](https://spectrum.chat/) - Twórz publiczne lub prywatne społeczności za darmo.
  * [StatusPile](https://www.statuspile.com/) - Strona statusowa statusów. Czy możesz śledzić strony statusowe swoich dostawców upstream?
  * [Stickies](https://stickies.app/) - Wizualna aplikacja do współpracy używana do burzy mózgów, kuracji treści i notatek. Darmowe do 3 tablic, nieograniczeni użytkownicy i 1 GB przestrzeni.
  * [Stacks](https://betterstacks.com/) - Przestrzeń do pracy z treścią z wbudowanymi notatkami, linkami i przechowywaniem plików do zarządzania natłokiem informacji. Wiecznie darmowy plan osobisty.
  * [talky.io](https://talky.io/) — Darmowy grupowy czat wideo. Anonimowy. Peer-to-peer. Bez wtyczek, rejestracji czy płatności.
  * [Teamhood](https://teamhood.com/) - Darmowe oprogramowanie do zarządzania projektami, zadaniami i zgłoszeniami. Obsługuje Kanban z torami i pełną implementację Scruma. Zawiera śledzenie czasu. Darmowe dla 5 użytkowników i 3 portfeli projektów.
  * [Teamplify](https://teamplify.com) - Ulepsz procesy zespołowe dzięki analizie zespołu i inteligentnym codziennym standupom. Pełny system zarządzania urlopami dla zespołów pracujących zdalnie. Darmowe dla małych grup do 5 użytkowników.
  * [Tefter](https://tefter.io) - Aplikacja do zakładek z zaawansowaną integracją ze Slackiem. Darmowe dla zespołów open-source.
  * [TeleType](https://teletype.oorja.io/) — Udostępniaj terminale, głos, kod, tablicę i więcej. Bez logowania, szyfrowana współpraca end-to-end dla programistów.
  * [TimeCamp](https://www.timecamp.com/) - Darmowe oprogramowanie do śledzenia czasu pracy dla nieograniczonej liczby użytkowników. Łatwa integracja z narzędziami PM jak Jira, Trello, Asana itp.
  * [Huly](https://huly.io/) - Wszystko-w-jednym platforma do zarządzania projektami (alternatywa dla Linear, Jira, Slack, Notion, Motion) - nieograniczona liczba użytkowników, 10 GB przestrzeni na workspace, 10 GB transferu wideo/audio.
  * [Teamcamp](https://www.teamcamp.app) - Wszechstronna aplikacja do zarządzania projektami dla firm programistycznych.
  * [twist.com](https://twist.com) — Asynchroniczna aplikacja do komunikacji zespołowej, w której rozmowy są uporządkowane i na temat. Dostępny darmowy i nieograniczony plan. Zniżki dla uprawnionych zespołów.
  * [tldraw.com](https://tldraw.com) — Darmowe open-source narzędzie do tablicy i diagramów z inteligentnymi strzałkami, przyciąganiem, karteczkami i eksportem SVG. Tryb multiplayer do wspólnej edycji. Dostępne oficjalne darmowe rozszerzenie VS Code.
  * [BookmarkOS.com](https://bookmarkos.com) - Darmowy menedżer zakładek, menedżer kart i menedżer zadań w konfigurowalnym internetowym pulpicie z możliwością współpracy nad folderami.
  * [typetalk.com](https://www.typetalk.com/) — Dzielenie się i omawianie pomysłów w zespole przez czat natychmiastowy w sieci lub na telefonie.
  * [Tugboat](https://tugboat.qa) - Podgląd każdego pull requesta, automatycznie i na żądanie. Darmowe dla wszystkich, darmowy poziom Nano dla organizacji non-profit.
  * [whereby.com](https://whereby.com/) — Jednoklikowe rozmowy wideo, za darmo (dawniej appear.in).
  * [windmill.dev](https://windmill.dev/) - Windmill to open-source platforma deweloperska do szybkiego tworzenia automatyzacji produkcyjnych i aplikacji wewnętrznych z minimalnych skryptów Python i Typescript. Jako darmowy użytkownik możesz utworzyć i być członkiem maksymalnie trzech nie-premium workspace'ów.
  * [vadoo.tv](https://vadoo.tv/) — Hosting wideo i marketing w prosty sposób. Przesyłaj filmy jednym kliknięciem. Nagrywaj, zarządzaj, udostępniaj i więcej. Darmowy poziom pozwala na 10 filmów, 1 GB miejsca i 10 GB transferu/miesiąc.
  * [userforge.com](https://userforge.com/) - Połączone online persony, historie użytkowników i mapowanie kontekstu. Pomaga utrzymać synchronizację designu i dev, darmowe do 3 person i dwóch współpracowników.
  * [wistia.com](https://wistia.com/) — Hosting wideo z analizą widzów, dostarczaniem HD i narzędziami marketingowymi, 25 filmów, odtwarzacz z brandingiem Wistia.
  * [wormhol.org](https://www.wormhol.org/) — Prosta usługa udostępniania plików. Udostępniaj nieograniczone pliki do 5GB z dowolną liczbą odbiorców.
  * [Wormhole](https://wormhole.app/) - Udostępniaj pliki do 5GB z szyfrowaniem end-to-end przez 24 godziny. Dla plików powyżej 5 GB używa transferu peer-to-peer.
  * [zoom.us](https://zoom.us/) — Bezpieczne spotkania wideo i webinary, dodatki dostępne. Darmowy plan ograniczony do 40 minut.
  * [Zulip](https://zulip.com/) — Czat w czasie rzeczywistym z unikalnym modelem wątków podobnym do e-maili. Darmowy plan obejmuje 10 000 wiadomości historii wyszukiwania i do 5 GB miejsca. Dostępna również wersja open-source do samodzielnego hostowania.
  * [robocorp.com](https://robocorp.com) - Otwarty stos do zasilania Automation Ops. Wypróbuj funkcje chmurowe i wdrażaj proste automatyzacje za darmo. Roboty 240 min/mc, 10 uruchomień Assistant, 100 MB miejsca.
  * [Fleep.io](https://fleep.io/) — Fleep to alternatywa dla Slacka. Darmowy plan dla małych zespołów z pełną historią wiadomości, nieograniczonymi 1:1 rozmowami, 1 rozmową grupową i 1 GB miejsca.
  * [Chanty.com](https://chanty.com/) — Chanty to kolejna alternatywa dla Slacka. Darmowy plan na zawsze dla małych zespołów (do 10 osób) z nieograniczoną liczbą rozmów publicznych i prywatnych, przeszukiwalną historią, nieograniczoną liczbą połączeń 1:1 audio, nieograniczonymi wiadomościami głosowymi, 10 integracjami i 20 GB miejsca na zespół.
  * [ruttl.com](https://ruttl.com/) — Kompleksowe narzędzie do zbierania opinii i recenzowania stron internetowych, PDF-ów i obrazów.
  * [Mattermost](https://mattermost.com/) — Bezpieczna współpraca dla zespołów technicznych. Darmowy plan z nieograniczoną liczbą kanałów, playbooków, tablic, użytkowników, 10 GB miejsca i więcej.
  * [Webvizio](https://webvizio.com) — Narzędzie do opiniowania stron, recenzji stron i zgłaszania błędów dla usprawnienia współpracy nad zadaniami bezpośrednio na żywych stronach, aplikacjach webowych, obrazach, PDF-ach i plikach projektowych.
  * [Pullflow](https://pullflow.com) — Pullflow oferuje platformę z AI do współpracy przy code review na GitHubie, Slacku i VS Code.
  * [Webex](https://www.webex.com/) — Spotkania wideo z darmowym planem na 40 minut i 100 uczestników.
  * [RingCentral](https://www.ringcentral.com/) — Spotkania wideo z darmowym planem na 50 minut i 100 uczestników.
  * [GitBook](https://www.gitbook.com/) — Platforma do rejestrowania i dokumentowania wiedzy technicznej — od dokumentacji produktu po bazy wiedzy i API. Darmowy plan dla indywidualnych deweloperów.
  * [transfernow](https://www.transfernow.net/) — najprostszy, najszybszy i najbezpieczniejszy interfejs do przesyłania i udostępniania plików. Wysyłaj zdjęcia, filmy i inne duże pliki bez obowiązkowej subskrypcji.
  * [paste.sh](https://paste.sh/) — Prosty pastebin oparty na JavaScript i Crypto.
  * [Revolt.chat](https://revolt.chat/) — OpenSource'owa alternatywa dla [Discord](https://discord.com/), która szanuje Twoją prywatność. Ma większość funkcji znanych z Discorda za darmo. Revolt to wszechstronna, bezpieczna i szybka aplikacja, w 100% darmowa. Wszystkie funkcje są darmowe. Wspiera także wtyczki (oficjalne i nieoficjalne), w przeciwieństwie do większości popularnych komunikatorów.
  * [Tencent RTC](https://trtc.io/) — Tencent Real-Time Communication (TRTC) oferuje rozwiązania do grupowych połączeń audio/wideo. 10 000 darmowych minut/miesiąc przez pierwszy rok.
  * [Pastefy](https://pastefy.app/) - Piękny i prosty Pastebin z opcjonalnym szyfrowaniem po stronie klienta, wieloma zakładkami, API, podświetlanym edytorem i innymi funkcjami.
  * [SiteDots](https://sitedots.com/) - Zbieraj opinie do projektów stron bezpośrednio na stronie, bez emulacji, płótna czy obejść. Całkowicie funkcjonalny darmowy poziom.

**[⬆️ Powrót na górę](#table-of-contents)**

## CMS

  * [acquia.com](https://www.acquia.com/) — Hosting dla stron Drupal. Darmowy poziom dla deweloperów. Dostępne również darmowe narzędzia developerskie (np. Acquia Dev Desktop).
  * [Contentful](https://www.contentful.com/) — Headless CMS. Zarządzanie treścią i API dostarczania w chmurze. Jeden darmowy Community space, który obejmuje pięciu użytkowników, 25 000 rekordów, 48 typów treści, 2 lokalizacje.
  * [Cosmic](https://www.cosmicjs.com/) — Headless CMS i zestaw narzędzi API. Darmowe plany osobiste dla deweloperów.
  * [Crystallize](https://crystallize.com) — Headless PIM ze wsparciem e-commerce. Wbudowane API GraphQL. Darmowa wersja obejmuje nieograniczoną liczbę użytkowników, 1000 elementów katalogu, 5 GB/mc transferu i 25 tys./mc wywołań API.
  * [DatoCMS](https://www.datocms.com/) - Darmowy poziom dla małych projektów. DatoCMS to CMS oparty na GraphQL. W niższym planie masz 100 tys./mc wywołań.
  * [Directus](https://directus.io) — Headless CMS. Całkowicie darmowa i open-source platforma do zarządzania zasobami i treścią bazy danych lokalnie lub w chmurze. Brak ograniczeń lub paywalla.
  * [FrontAid](https://frontaid.io/) — Headless CMS, który przechowuje treści JSON bezpośrednio w Twoim repozytorium Git. Bez ograniczeń.
  * [kontent.ai](https://www.kontent.ai) - Platforma Content-as-a-Service, dająca wszystkie zalety headless CMS i jednocześnie wspierająca marketerów. Plan developerski obejmuje dwóch użytkowników, nieograniczoną liczbę projektów z dwoma środowiskami w każdym, 500 elementów treści, dwa języki z Delivery i Management API oraz wsparcie Custom elements. Możesz wybrać bardziej szczegółowe plany wg potrzeb.
  * [Prismic](https://www.prismic.io/) — Headless CMS. Interfejs do zarządzania treścią z w pełni hostowanym i skalowalnym API. Plan Community oferuje nieograniczone wywołania API, dokumenty, typy własne, zasoby i lokalizacje dla jednego użytkownika. Wszystko, czego potrzebujesz do następnego projektu. Większe plany darmowe dostępne dla projektów Open Content/Open Source.
  * [Sanity.io](https://www.sanity.io/) - Platforma do zarządzania ustrukturyzowaną treścią z open-source edytorem i hostowaną bazą danych w czasie rzeczywistym. Nieograniczone projekty. Nieograniczeni admini, trzech nie-adminów, dwa zbiory danych, 500 tys. zapytań API CDN, 10 GB transferu i 5 GB zasobów za darmo na projekt.
  * [sensenet](https://sensenet.com) - API-first headless CMS oferujący rozwiązania klasy enterprise dla firm każdej wielkości. Plan deweloperski: trzech użytkowników, 500 elementów treści, trzy role wbudowane, 25+5 typów treści, w pełni dostępne REST API, generowanie podglądu dokumentu, edycja Office Online.
  * [TinaCMS](https://tina.io/) — Zastępuje Forestry.io. Open source Git-backed headless CMS obsługujący Markdown, MDX i JSON. Podstawowa oferta darmowa z dwoma użytkownikami.
  * [GatsbyjsCMS](https://www.gatsbyjs.com/) - Gatsby to szybki i elastyczny framework, który sprawia, że budowanie stron z dowolnym CMS, API lub bazą danych jest znów zabawne. Twórz i wdrażaj headless strony, które generują większy ruch, lepiej konwertują i przynoszą większe zyski!
  * [Hygraph](https://hygraph.com/) - Darmowy poziom dla małych projektów. GraphQL-first API. Przejdź z rozwiązań legacy do natywnego Headless CMS z GraphQL i dostarczaj treści API-first na wszystkie kanały.
* [Squidex](https://squidex.io/) – Oferuje darmowy poziom dla małych projektów. API / GraphQL first. Otwarty kod źródłowy i oparte na event sourcingu (wersjonowanie każdej zmiany automatycznie).
* [InstaWP](https://instawp.com/) – Uruchom stronę WordPress w kilka sekund. Darmowy poziom z 5 aktywnymi stronami, 500 MB przestrzeni, ważność strony 48 godzin.
* [Storyblok](https://www.storyblok.com) – Headless CMS dla deweloperów i marketerów, współpracujący ze wszystkimi nowoczesnymi frameworkami. Poziom Community (darmowy) oferuje Management API, Visual Editor, dziesięć źródeł, niestandardowe typy pól, internacjonalizację (nielimitowane języki/lokalizacje), Asset Manager (do 2500 zasobów), usługę optymalizacji obrazów, zapytania wyszukiwania, Webhook + 250GB transferu/miesiąc w cenie.
* [WPJack](https://wpjack.com) – Skonfiguruj WordPressa w dowolnej chmurze w mniej niż 5 minut! Darmowy poziom obejmuje 1 serwer, 2 strony, darmowe certyfikaty SSL i nieograniczoną liczbę zadań cron. Bez limitów czasowych ani wygaśnięcia — Twoja strona, Twoje zasady.

**[⬆️ Wróć na górę](#table-of-contents)**

## Generowanie kodu

* [Appinvento](https://appinvento.io/) — AppInvento to darmowy kreator aplikacji bez kodowania. W automatycznie generowanym kodzie backendu użytkownicy mają pełny dostęp do kodu źródłowego oraz nielimitowane API i trasy, co umożliwia szeroką integrację. Darmowy plan obejmuje trzy projekty, pięć tabel i dodatek Google.
* [Cody AI](https://sourcegraph.com/cody) – Cody to asystent AI do kodowania, wykorzystujący sztuczną inteligencję i głębokie zrozumienie Twojej bazy kodu, aby pomóc pisać i rozumieć kod szybciej. Cody daje deweloperom wybór modeli LLM (w tym lokalnych), obsługuje różne IDE i wszystkie popularne języki programowania, a także oferuje darmowy plan. Darmowy plan daje 20 wiadomości czatu (z użyciem Claude 3 Sonnet jako LLM) oraz 500 autouzupełnień (z użyciem Starcoder 16b) miesięcznie.
* [DhiWise](https://www.dhiwise.com/) — Płynnie przekształcaj projekty z Figma w dynamiczne aplikacje Flutter i React dzięki innowacyjnej technologii generowania kodu DhiWise, optymalizując swój workflow i pomagając szybciej tworzyć wyjątkowe doświadczenia mobilne i webowe.
* [Codeium](https://www.codeium.com/) — Codeium to darmowe narzędzie AI do uzupełniania kodu. Obsługuje ponad 20+ języków programowania (Python, JavaScript, Java, TypeScript, PHP, C/C++, Go, itd.) i integruje się ze wszystkimi głównymi IDE, zarówno samodzielnymi, jak i webowymi.
* [Fern](https://buildwithfern.com) – Pisz definicje API i używaj ich do generowania SDK/bibliotek klienckich w popularnych językach, takich jak TypeScript, Python, Java, Go i więcej. Pełne wsparcie OpenAPI. Darmowy poziom generuje kod dla maksymalnie 20 endpointów.
* [Metalama](https://www.postsharp.net/metalama) – Tylko dla C#. Metalama generuje kod szablonowy na bieżąco podczas kompilacji, dzięki czemu Twój kod źródłowy pozostaje czysty. Darmowe dla projektów open source, a komercyjny, przyjazny darmowy poziom obejmuje trzy aspekty.
* [Supermaven](https://www.supermaven.com/) — Supermaven to szybka wtyczka AI do uzupełniania kodu dla VSCode, JetBrains i Neovim. Darmowy poziom zapewnia nieograniczone uzupełnienia inline.
* [tabnine.com](https://www.tabnine.com/) — Tabnine pomaga deweloperom szybciej tworzyć lepsze oprogramowanie, dostarczając wnioski wyciągnięte ze wszystkich kodów na świecie. Wtyczka dostępna.
* [v0.dev](https://v0.dev/) — v0 wykorzystuje modele AI do generowania kodu na podstawie prostych poleceń tekstowych. Generuje gotowy do kopiowania kod React oparty na shadcn/ui i Tailwind CSS, który można wykorzystać w swoich projektach. Każda generacja zużywa co najmniej 30 kredytów. Startujesz z 1200 kredytami, a co miesiąc dostajesz 200 darmowych kredytów.

**[⬆️ Wróć na górę](#table-of-contents)**

## Jakość kodu

* [beanstalkapp.com](https://beanstalkapp.com/) — Kompletny workflow do pisania, przeglądania i wdrażania kodu, darmowe konto dla jednego użytkownika i jedno repozytorium ze 100 MB przestrzeni
* [browserling.com](https://www.browserling.com/) — Interaktywne testy międzyprzeglądarkowe na żywo, darmowe tylko 3-minutowe sesje z MS IE 9 na Vista przy rozdzielczości 1024 x 768
* [codacy.com](https://www.codacy.com/) — Automatyczne przeglądy kodu dla PHP, Pythona, Ruby, Javy, JavaScriptu, Scali, CSS i CoffeeScript, darmowe dla nielimitowanych publicznych i prywatnych repozytoriów
* [Codeac.io](https://www.codeac.io/infrastructure-as-code.html?ref=free-for-dev) – Automatyczne przeglądy Infrastructure as Code dla DevOps, integracja z GitHub, Bitbucket i GitLab (również self-hosted). Oprócz standardowych języków analizuje też Ansible, Terraform, CloudFormation, Kubernetes i inne. (open-source darmowe)
* [CodeBeat](https://codebeat.co) — Zautomatyzowana platforma Code Review dla wielu języków. Darmowa na zawsze dla publicznych repozytoriów ze Slack i integracją e-mail.
* [codeclimate.com](https://codeclimate.com/) — Automatyczny code review, darmowe dla Open Source i nielimitowanych prywatnych repozytoriów organizacji (do 4 współpracowników). Darmowe także dla studentów i instytucji.
* [codecov.io](https://codecov.io/) — Narzędzie do pokrycia kodu (SaaS), darmowe dla Open Source i jedno darmowe prywatne repozytorium
* [CodeFactor](https://www.codefactor.io) — Automatyczny code review dla Git. Wersja darmowa obejmuje nieograniczoną liczbę użytkowników, publicznych repozytoriów i jedno prywatne repozytorium.
* [coderabbit.ai](https://coderabbit.ai) — Narzędzie AI do przeglądu kodu integrujące się z GitHub/GitLab. Darmowy poziom obejmuje 200 plików/godzinę, 3 przeglądy na godzinę i 50 rozmów/godzinę. Zawsze darmowe dla projektów open source.
* [codescene.io](https://codescene.io/) – CodeScene priorytetyzuje dług techniczny na podstawie sposobu pracy deweloperów z kodem i wizualizuje czynniki organizacyjne, takie jak sprzężenie zespołu i opanowanie systemu. Darmowe dla Open Source.
* [CodSpeed](https://codspeed.io) – Automatyzuj monitorowanie wydajności w pipeline'ach CI. Wychwytuj regresje wydajności przed wdrożeniem dzięki precyzyjnym i spójnym metrykom. Zawsze darmowe dla projektów Open Source.
* [coveralls.io](https://coveralls.io/) — Wyświetlanie raportów pokrycia testami, darmowe dla Open Source
* [dareboost](https://dareboost.com) – 5 darmowych raportów analizy wydajności, dostępności i bezpieczeństwa stron internetowych miesięcznie
* [deepcode.ai](https://www.deepcode.ai) — DeepCode znajduje błędy, podatności, problemy z wydajnością i API na podstawie AI. Szybkość analizy DeepCode pozwala analizować kod w czasie rzeczywistym i dostarczać wyniki natychmiast po zapisaniu w IDE. Obsługiwane języki: Java, C/C++, JavaScript, Python, TypeScript. Integracje z GitHub, BitBucket i GitLab. Darmowe dla open source i repozytoriów prywatnych oraz do 30 deweloperów.
* [deepscan.io](https://deepscan.io) — Zaawansowana analiza statyczna do automatycznego znajdowania błędów wykonania w kodzie JavaScript, darmowe dla Open Source
* [DeepSource](https://deepsource.io/) – DeepSource stale analizuje zmiany kodu źródłowego, wykrywając i naprawiając problemy z zakresu bezpieczeństwa, wydajności, antywzorców, ryzyka błędów, dokumentacji i stylu. Natychmiastowa integracja z GitHub, GitLab i Bitbucket.
* [DiffText](https://difftext.com) – Natychmiast znajdź różnice między dwoma blokami kodu. Całkowicie darmowe w użyciu.
* [eversql.com](https://www.eversql.com/) — EverSQL – Platforma #1 do optymalizacji baz danych. Uzyskaj krytyczne informacje o swojej bazie i zapytaniach SQL automatycznie.
* [gerrithub.io](https://review.gerrithub.io/) — Gerrit code review dla repozytoriów GitHub za darmo
* [gocover.io](https://gocover.io/) — Pokrycie kodu dla dowolnego pakietu [Go](https://golang.org/)
* [goreportcard.com](https://goreportcard.com/) — Jakość kodu dla projektów Go, darmowe dla Open Source
* [gtmetrix.com](https://gtmetrix.com/) — Raporty i szczegółowe rekomendacje optymalizacyjne dla stron internetowych
* [holistic.dev](https://holistic.dev/) – #1 statyczny analizator kodu do optymalizacji Postgresql. Automatyczna detekcja problemów z wydajnością, bezpieczeństwem i architekturą bazy danych
* [houndci.com](https://houndci.com/) — Komentarze do commitów GitHub na temat jakości kodu, darmowe dla Open Source
* [Moderne.io](https://app.moderne.io) — Automatyczne refaktoryzacje kodu źródłowego. Moderne oferuje migracje frameworków, analizę kodu z naprawą oraz niezrównaną transformację kodu na dużą skalę, dzięki czemu deweloperzy mogą skupić się na nowym, a nie na utrzymaniu starego. Darmowe dla Open Source.
* [reviewable.io](https://reviewable.io/) — Code review dla repozytoriów GitHub, darmowe dla publicznych lub osobistych repozytoriów.
* [parsers.dev](https://parsers.dev/) – Parsery drzew AST i kompilatory reprezentacji pośrednich jako usługa
* [scan.coverity.com](https://scan.coverity.com/) — Analiza statyczna kodu dla Java, C/C++, C# i JavaScript, darmowa dla Open Source
* [scrutinizer-ci.com](https://scrutinizer-ci.com/) — Platforma ciągłej inspekcji, darmowa dla Open Source
* [semanticdiff.com](https://app.semanticdiff.com/) — Świadome językowo porównywanie kodu dla pull requestów i commitów GitHub, darmowe dla publicznych repozytoriów
* [shields.io](https://shields.io) — Odznaki z metadanymi jakości dla projektów open source
* [sonarcloud.io](https://sonarcloud.io) — Automatyczna analiza kodu źródłowego dla Java, JavaScript, C/C++, C#, VB.NET, PHP, Objective-C, Swift, Python, Groovy i innych języków, darmowe dla Open Source
* [SourceLevel](https://sourcelevel.io/) — Automatyczny code review i analityka zespołu. Darmowe dla Open Source oraz organizacji do 5 współpracowników.
* [webceo.com](https://www.webceo.com/) — Narzędzia SEO, ale także weryfikacje kodu i różne typy urządzeń
* [zoompf.com](https://zoompf.com/) — Napraw wydajność swoich stron www, szczegółowa analiza

**[⬆️ Wróć na górę](#table-of-contents)**

## Wyszukiwanie i przeglądanie kodu

* [libraries.io](https://libraries.io/) — Wyszukiwanie i powiadomienia o aktualizacjach zależności dla 32 różnych menedżerów pakietów, darmowe dla open source
* [Namae](https://namae.dev/) – Wyszukaj na różnych stronach, takich jak GitHub, Gitlab, Heroku, Netlify i wielu innych, dostępność nazwy swojego projektu.
* [searchcode.com](https://searchcode.com/) — Kompleksowe wyszukiwanie kodu oparte na tekście, darmowe dla Open Source
* [tickgit.com](https://www.tickgit.com/) — Wyszukuje komentarze `TODO` (i inne markery), by zidentyfikować fragmenty kodu warte poprawy.
* [CodeKeep](https://codekeep.io) – Google Keep dla fragmentów kodu. Organizuj, odkrywaj i udostępniaj fragmenty kodu, z potężnym narzędziem do screenshotów kodu z gotowymi szablonami i funkcją linkowania.

**[⬆️ Wróć na górę](#table-of-contents)**

## CI i CD

* [AccessLint](https://github.com/marketplace/accesslint) — AccessLint wprowadza automatyczne testy dostępności stron www do Twojego workflow deweloperskiego. Darmowe dla open source i celów edukacyjnych.
* [appcircle.io](https://appcircle.io) — Platforma DevOps klasy enterprise do automatyzacji budowy, testowania i publikowania aplikacji mobilnych w celu szybszego i bardziej efektywnego cyklu wydawniczego. Darmowe do 30 minut czasu budowy na build, 20 buildów miesięcznie i 1 budowa równoległa.
* [appveyor.com](https://www.appveyor.com/) — Usługa CD dla Windows, darmowa dla Open Source
* [LocalOps](https://localops.co/) – Wdróż swoją aplikację na AWS/GCP/Azure w mniej niż 30 minut. Konfiguruj standardowe środowiska aplikacji w każdej chmurze, z wbudowaną automatyzacją ciągłego wdrażania i zaawansowaną obserwowalnością. Darmowy plan obejmuje 1 użytkownika i 1 środowisko aplikacji.
* [Argonaut](https://argonaut.dev/) – Wdrażaj aplikacje i infrastrukturę w swojej chmurze w kilka minut. Wsparcie dla własnych i zewnętrznych wdrożeń aplikacji w środowiskach Kubernetes i Lambda. Darmowy poziom pozwala na nieograniczoną liczbę aplikacji i wdrożeń dla 5 domen i 2 użytkowników.
* [bitrise.io](https://www.bitrise.io/) — CI/CD dla aplikacji mobilnych, natywnych i hybrydowych. 200 darmowych buildów/miesiąc, 10 min na build i dwóch członków zespołu. Projekty OSS mają 45 min na build, +1 równoległość i nielimitowaną wielkość zespołu.
* [buddy.works](https://buddy.works/) — CI/CD z pięcioma darmowymi projektami i jednym równoległym uruchomieniem (120 wykonań/miesiąc)
* [Buildkite](https://buildkite.com) – CI Pipelines darmowe dla 3 użytkowników i 5k minut zadań/miesiąc. Test Analytics darmowy poziom deweloperski obejmuje 100k wykonanych testów/miesiąc, a dla projektów open source jeszcze więcej darmowych zasobów.
* [bytebase.com](https://www.bytebase.com/) — Database CI/CD i DevOps. Darmowe dla mniej niż 20 użytkowników i 10 instancji baz danych
* [CircleCI](https://circleci.com/) — Kompleksowy darmowy plan z pełną funkcjonalnością w hostowanej usłudze CI/CD dla repozytoriów GitHub, GitLab i BitBucket. Wiele klas zasobów, Docker, Windows, Mac OS, ARM, lokalni runnerzy, dzielenie testów, Docker Layer Caching i inne zaawansowane funkcje CI/CD. Darmowe do 6000 minut czasu wykonania/miesiąc, nielimitowani współpracownicy, 30 równoległych zadań w prywatnych projektach i do 80 000 darmowych minut buildów dla projektów Open Source.
* [cirrus-ci.org](https://cirrus-ci.org) – Darmowe dla publicznych repozytoriów GitHub
* [cirun.io](https://cirun.io) – Darmowe dla publicznych repozytoriów GitHub
* [codefresh.io](https://codefresh.io) — Plan Free-for-Life: 1 build, jedno środowisko, współdzielone serwery, nieograniczone publiczne repozytoria
* [codemagic.io](https://codemagic.io/) – Darmowe 500 minut buildów/miesiąc
* [codeship.com](https://codeship.com/) — 100 prywatnych buildów/miesiąc, pięć prywatnych projektów, nieograniczone dla Open Source
* [deploybot.com](https://www.deploybot.com/) — 1 repozytorium z dziesięcioma wdrożeniami, darmowe dla Open Source
* [deployhq.com](https://www.deployhq.com/) — 1 projekt z dziesięcioma wdrożeniami dziennie (30 minut buildów/miesiąc)
* [drone](https://cloud.drone.io/) – Drone Cloud umożliwia deweloperom uruchamianie pipeline’ów Continuous Delivery dla wielu architektur – w tym x86 i Arm (32- i 64-bit) – w jednym miejscu
* [LayerCI](https://layerci.com) — CI dla projektów full stack. Jedno środowisko podglądu full stack z 5 GB RAM i 3 CPU.
* [semaphoreci.com](https://semaphoreci.com/) — Darmowe dla Open Source, 100 prywatnych buildów miesięcznie
* [Squash Labs](https://www.squash.io/) — Tworzy VM dla każdej gałęzi i udostępnia Twoją aplikację pod unikalnym adresem URL, nieograniczone publiczne i prywatne repozytoria, do 2 GB rozmiaru VM.
* [styleci.io](https://styleci.io/) — Tylko publiczne repozytoria GitHub
* [Mergify](https://mergify.io) — automatyzacja workflow i kolejka merge dla GitHub — darmowe dla publicznych repozytoriów GitHub
* [Make](https://www.make.com/en) — Narzędzie do automatyzacji workflow, pozwalające łączyć aplikacje i automatyzować procesy za pomocą interfejsu graficznego. Obsługuje wiele aplikacji i najpopularniejsze API. Darmowe dla publicznych repozytoriów GitHub oraz darmowy poziom z 100 Mb, 1000 operacjami i minimalnym interwałem 15 minut.
* [Spacelift](https://spacelift.io/) – Platforma zarządzania Infrastructure as Code. Darmowe funkcje: współpraca nad IaC, rejestr modułów Terraform, integracja ChatOps, ciągła zgodność zasobów z Open Policy Agent, SSO z SAML 2.0 i dostęp do publicznych worker pooli: do 200 minut/miesiąc
* [microtica.com](https://microtica.com/) – Środowiska startupowe z gotowymi komponentami infrastruktury, wdrażaj aplikacje na AWS za darmo i wspieraj swoje środowiska produkcyjne. Darmowy poziom obejmuje 1 środowisko (na Twoim koncie AWS), 2 usługi Kubernetes, 100 minut buildów miesięcznie i 20 wdrożeń miesięcznie.
* [Nx Cloud](https://nx.dev/ci) - Nx Cloud przyspiesza pracę z monorepozytoriami na CI dzięki funkcjom takim jak zdalne cache'owanie, dystrybucja zadań pomiędzy maszyny, a nawet automatyczne dzielenie przebiegów testów e2e. Dostępny darmowy plan dla maksymalnie 30 współtwórców z dużym limitem 150 tys. kredytów.
* [blacksmith](https://www.blacksmith.sh/) - Zarządzane wydajne maszyny dla GitHub Actions oferujące 3 000 darmowych minut miesięcznie, bez potrzeby podawania karty kredytowej.
* [Terramate](https://terramate.io/) - Terramate to platforma orkiestracji i zarządzania narzędziami Infrastructure as Code (IaC), takimi jak Terraform, OpenTofu i Terragrunt. Bezpłatnie do 2 użytkowników, w tym wszystkie funkcje.
* [Terrateam](https://terrateam.io) - GitOps-first automatyzacja Terraform z workflow opartymi o pull requesty, izolacją projektów dzięki self-hosted runners oraz warstwowymi przebiegami dla uporządkowanych operacji. Darmowe dla maksymalnie 3 użytkowników.

**[⬆️ Powrót do góry](#table-of-contents)**

## Testowanie

* [Applitools.com](https://applitools.com/) — Inteligentna walidacja wizualna dla aplikacji webowych, natywnych mobilnych i desktopowych. Integracja z niemal wszystkimi rozwiązaniami automatyzacji (np. Selenium, Karma) i zdalnymi runnerami (Sauce Labs, Browser Stack). Za darmo dla open source. Darmowy poziom dla pojedynczego użytkownika z ograniczoną liczbą checkpointów na tydzień.
* [Appetize](https://appetize.io) — Testuj swoje aplikacje Android i iOS na emulowanych urządzeniach w chmurze (telefony/tablety Android oraz symulatory iPhone/iPad) bezpośrednio w przeglądarce. Darmowy poziom obejmuje dwie równoczesne sesje i 30 minut użycia miesięcznie. Bez limitu rozmiaru aplikacji.
* [Apptim](https://apptim.com) — Narzędzie do testowania mobilnego pozwalające osobom bez wiedzy z zakresu inżynierii wydajności ocenić wydajność i UX aplikacji. Wersja desktopowa z użyciem własnego urządzenia jest w 100% DARMOWA i pozwala na nieograniczoną liczbę testów na iOS i Androidzie.
* [Argos](https://argos-ci.com) - Otwarty test wizualny dla deweloperów. Nieograniczone projekty, 5 000 zrzutów ekranu miesięcznie. Darmowe dla projektów open source.
* [Bencher](https://bencher.dev/) - Zestaw narzędzi do ciągłego benchmarkowania, pozwalający wyłapać regresje wydajności CI. Darmowe dla wszystkich projektów publicznych.
* [browserstack.com](https://www.browserstack.com/) — Ręczne i automatyczne testy przeglądarkowe, [darmowe dla Open Source](https://www.browserstack.com/open-source?ref=pricing)
* [BugBug](https://bugbug.io/) - Lekki automat testujący aplikacje webowe. Łatwy do nauki, nie wymaga kodowania. Nielimitowane testy na własnym komputerze za darmo. Monitoring w chmurze i integracja z CI/CD za dodatkową miesięczną opłatą.
* [Checkly](https://checklyhq.com) - Code-first syntetyczny monitoring dla nowoczesnego DevOps. Monitoruj API i aplikacje znacznie taniej niż u tradycyjnych dostawców. Monitoring jako kod oraz Playwright. Hojny darmowy poziom dla deweloperów.
* [checkbot.io](https://www.checkbot.io/) — Rozszerzenie do przeglądarki testujące czy strona spełnia 50+ dobrych praktyk SEO, szybkości i bezpieczeństwa. Darmowy poziom dla mniejszych stron.
* [CORS-Tester](https://cors-error.dev/cors-tester/) - Darmowe narzędzie dla deweloperów i testerów API do sprawdzania, czy API obsługuje CORS dla podanej domeny oraz identyfikacji luk. Dostarcza przydatnych wskazówek.
* [cypress.io](https://www.cypress.io/) - Szybkie, łatwe i niezawodne testowanie wszystkiego, co działa w przeglądarce. Cypress Test Runner zawsze darmowy i open-source, bez ograniczeń. Cypress Dashboard darmowy dla projektów open source do 5 użytkowników.
* [Cypress Recorder by Preflight](https://cypress.preflight.com/) - Twórz testy Cypress wspierane przez AI i modele POM bezpośrednio w przeglądarce. Otwarty kod źródłowy (poza częścią AI). 5 darmowych testów miesięcznie z funkcjami samoleczenia, emailami i testami wizualnymi.
* [everystep-automation.com](https://www.everystep-automation.com/) — Nagrywanie i odtwarzanie wszystkich kroków w przeglądarce oraz generowanie skryptów, wersja darmowa z ograniczonymi opcjami.
* [Gremlin](https://www.gremlin.com/gremlin-free-software) — Narzędzia do Chaos Engineering pozwalające bezpiecznie wstrzykiwać awarie do systemów, by wykryć słabe punkty zanim wpłyną na klientów. Gremlin Free umożliwia ataki Shutdown i CPU na do 5 hostach lub kontenerach.
* [gridlastic.com](https://www.gridlastic.com/) — Testowanie Selenium Grid z darmowym planem: do 4 jednoczesnych nodów Selenium/10 uruchomień gridu/4 000 minut testów miesięcznie.
* [katalon.com](https://katalon.com) - Platforma testowa dla zespołów każdej wielkości i dojrzałości, obejmuje Katalon Studio, TestOps (+ darmowe testy wizualne), TestCloud i Katalon Recorder.
* [Keploy](https://keploy.io/) - Keploy to zestaw narzędzi do testów funkcjonalnych dla deweloperów. Rejestrowanie wywołań API generuje testy E2E (KTests) oraz mocki/stuby (KMocks). Darmowe dla projektów open source.
* [knapsackpro.com](https://knapsackpro.com) - Przyspiesz swoje testy poprzez optymalne równoległe uruchamianie zestawów testowych na dowolnym CI. Dziel testy Ruby, JavaScript na równoległe węzły CI. Darmowy plan do 10 minut testów oraz nielimitowany darmowy plan dla projektów open source.
* [lambdatest.com](https://www.lambdatest.com/) — Ręczne, wizualne, screenshotowe i automatyczne testy przeglądarkowe na selenium i cypress, [darmowe dla Open Source](https://www.lambdatest.com/open-source-cross-browser-testing-tool)
* [loadmill.com](https://www.loadmill.com/) - Automatyczne tworzenie testów API i obciążeniowych przez analizę ruchu sieciowego. Symulacja do 50 użytkowników jednocześnie przez 60 minut miesięcznie za darmo.
* [lost-pixel.com](https://lost-pixel.com) - Holistyczne testy regresji wizualnej dla Storybooka, Ladle, Histoire i aplikacji webowych. Nielimitowana liczba członków zespołu, całkowicie darmowe dla open source, 7 000 snapshotów/miesiąc.
* [octomind.dev](https://www.octomind.dev/) - Automatycznie generowane, uruchamiane i utrzymywane testy UI Playwright z generowaniem przypadków testowych wspomaganym AI.
* [percy.io](https://percy.io) - Dodaj testy wizualne do dowolnej aplikacji webowej, statycznej strony, przewodnika po stylach lub biblioteki komponentów. Nielimitowani członkowie zespołu, aplikacja demo i nielimitowane projekty, 5 000 snapshotów/miesiąc.
* [preflight.com](https://preflight.com) - Automatyczne testowanie webowe bez kodowania. Nagrywaj testy w przeglądarce odporne na zmiany UI i uruchamiaj je na maszynach z Windows. Integracja z CI/CD. Darmowy plan obejmuje 50 testów miesięcznie z nagraniem wideo, sesjami HTML i innymi funkcjami.
* [qase.io](https://qase.io) - System zarządzania testami dla zespołów Dev i QA. Zarządzaj przypadkami testowymi, twórz przebiegi testów, wykonuj testy, śledź defekty i mierz wpływ. Darmowy poziom obejmuje wszystkie kluczowe funkcje, 500MB na załączniki i do 3 użytkowników.
* [Repeato](https://repeato.app/) Narzędzie do automatyzacji testów aplikacji mobilnych bez kodowania, oparte na computer vision i AI. Działa dla aplikacji natywnych, flutter, react-native, web, ionic i wielu innych frameworków. Darmowy plan obejmuje 10 testów dla iOS i 10 dla Androida, ale zawiera większość funkcji planów płatnych, w tym nielimitowane uruchomienia testów.
* [Requestly](https://requestly.com/) Otwarta wtyczka Chrome do przechwytywania, przekierowywania i mockowania żądań HTTP. Zawiera [Debugger](https://requestly.com/products/web-debugger/), [Mock Server](https://requestly.com/products/mock-server/), [API Client](https://requestly.com/products/api-client/) oraz [Nagrywanie sesji](https://requestly.com/products/session-book/). Przekierowuj URL, modyfikuj nagłówki HTTP, mockuj API, wstrzykuj własny JS, modyfikuj żądania GraphQL, generuj mockowe endpointy API, nagrywaj sesje z logami sieciowymi i konsoli. Do 10 reguł w darmowym poziomie. Darmowe dla open source.
* [seotest.me](https://seotest.me/) — Darmowy tester SEO on-page. 10 bezpłatnych crawlów dziennie. Przydatne materiały edukacyjne SEO i rekomendacje jak poprawić wyniki SEO dla dowolnej strony, niezależnie od technologii.
* [snippets.uilicious.com](https://snippets.uilicious.com) - Jak CodePen, ale do testowania międzyprzeglądarkowego. UI-licious pozwala pisać testy jak user stories i oferuje darmową platformę - UI-licious Snippets - umożliwiającą nielimitowane testy na Chrome bez rejestracji, do 3 minut na uruchomienie testu. Znalazłeś błąd? Skopiuj unikalny URL do testu by pokazać deweloperom jak go odtworzyć.
* [TestCollab](https://testcollab.com) - Przyjazny system zarządzania testami, darmowy plan obejmuje integrację z Jira, nielimitowane projekty, import przypadków testowych przez CSV/XLSx, śledzenie czasu oraz 1 GB przestrzeni na pliki.
* [testingbot.com](https://testingbot.com/) — Selenium Browser i Device Testing, [darmowe dla Open Source](https://testingbot.com/open-source)
* [Testspace.com](https://testspace.com/) - Dashboard do publikowania wyników testów automatycznych i framework do implementacji testów manualnych jako kod w GitHubie. Usługa [darmowa dla Open Source](https://github.com/marketplace/testspace-com), limit 450 wyników miesięcznie.
* [tesults.com](https://www.tesults.com) — Raportowanie wyników testów i zarządzanie przypadkami testowymi. Integracja z popularnymi frameworkami testowymi. Twórcy oprogramowania open source, osoby indywidualne, edukatorzy i małe zespoły mogą uzyskać zniżki lub darmowe oferty wykraczające poza podstawowe darmowe projekty.
* [UseWebhook.com](https://usewebhook.com) - Przechwytuj i analizuj webhooki w przeglądarce. Przekieruj do localhost lub odtwórz z historii. Darmowe.
* [Vaadin](https://vaadin.com) — Twórz skalowalne UI w Javie lub TypeScript, korzystając z zintegrowanych narzędzi, komponentów i systemu designu, by szybciej iterować, projektować lepiej i upraszczać proces developmentu. Nielimitowane projekty z 5-letnim darmowym wsparciem.
* [websitepulse.com](https://www.websitepulse.com/tools/) — Różne darmowe narzędzia sieciowe i serwerowe.
* [webhook-test.com](https://webhook-test.com) - Debuguj i analizuj webhooki oraz żądania HTTP z unikalnym URL podczas integracji. Całkowicie darmowe, możesz tworzyć nielimitowane URL i otrzymywać rekomendacje.
* [webhook.site](https://webhook.site) - Weryfikuj webhooki, wychodzące żądania HTTP lub emaile za pomocą niestandardowego URL. Tymczasowy URL i adres email zawsze za darmo.
* [webhookbeam.com](https://webhookbeam.com) - Konfiguruj webhooki i monitoruj je poprzez powiadomienia push i emaile.

**[⬆️ Powrót do góry](#table-of-contents)**

## Bezpieczeństwo i PKI

* [aikido.dev](https://www.aikido.dev) — Kompleksowa platforma AppSec obejmująca SCA, SAST, CSPM, DAST, Secrets, IaC, Malware, skanowanie kontenerów, EOL... Bezpłatny plan obejmuje 2 użytkowników, skanowanie 10 repozytoriów, 1 chmury, 2 kontenerów i 1 domeny.
* [alienvault.com](https://www.alienvault.com/open-threat-exchange/reputation-monitor) — Wykrywa skompromitowane systemy w Twojej sieci
* [Altcha.org](https://altcha.org/anti-spam) - Filtrowanie spamu dla stron internetowych i API oparte na przetwarzaniu języka naturalnego i uczeniu maszynowym. Darmowy plan obejmuje 200 żądań dziennie na domenę.
* [atomist.com](https://atomist.com/) — Szybszy i wygodniejszy sposób automatyzowania różnych zadań developerskich. Obecnie w fazie beta.
* [cloudsploit.com](https://cloudsploit.com/) — Audyt bezpieczeństwa i zgodności oraz monitoring dla Amazon Web Services (AWS)
* [Public Cloud Threat Intelligence](https://cloudintel.himanshuanand.com/) — Wysokiej wiarygodności wskaźniki kompromitacji (IOC) dla infrastruktury chmurowej, część dostępna na github (https://github.com/unknownhad/AWSAttacks). Pełna lista dostępna przez API
* [CodeNotary.io](https://www.codenotary.io/) — Platforma open source z niepodważalnym potwierdzeniem autentyczności kodu, plików, katalogów lub kontenerów
* [crypteron.com](https://www.crypteron.com/) — Przyjazna dla deweloperów platforma bezpieczeństwa "cloud-first" zapobiegająca wyciekom danych w aplikacjach .NET i Java
* [CyberChef](https://gchq.github.io/CyberChef/) — Prosta, intuicyjna aplikacja webowa do analizy i kodowania/dekodowania danych bez konieczności używania złożonych narzędzi lub języków programowania. Szwajcarski scyzoryk kryptografii i szyfrowania. Wszystkie funkcje są darmowe, bez limitów. Open source do samodzielnego hostowania.
* [DAS](https://signup.styra.com/) — Styra DAS Free, pełny cykl zarządzania politykami, tworzenie, wdrażanie i zarządzanie autoryzacją Open Policy Agent (OPA)
* [Datree](https://www.datree.io/) — Otwarty CLI do zapobiegania błędnym konfiguracjom Kubernetes poprzez egzekwowanie dobrych praktyk i polityk organizacji w manifestach i helm chartach
* [Dependabot](https://dependabot.com/) Zautomatyzowane aktualizacje zależności dla Ruby, JavaScript, Pythona, PHP, Elixir, Rusta, Javy (Maven i Gradle), .NET, Go, Elm, Dockera, Terraform, Git Submodules i GitHub Actions.
* [DJ Checkup](https://djcheckup.com) — Skanuj swoją stronę Django pod kątem luk bezpieczeństwa za pomocą tego darmowego, automatycznego narzędzia. Fork Pony Checkup.
* [Doppler](https://doppler.com/) — Uniwersalny menedżer sekretów i konfiguracji aplikacji, obsługuje synchronizację z różnymi dostawcami chmur. Za darmo dla 5 użytkowników z podstawową kontrolą dostępu.
* [Dotenv](https://dotenv.org/) — Synchronizuj swoje pliki .env szybko i bezpiecznie. Przestań dzielić się plikami .env przez niezabezpieczone kanały jak Slack czy email i nie trać ważnych plików .env. Za darmo dla 3 współpracowników.
* [GitGuardian](https://www.gitguardian.com) — Automatyczne wykrywanie i usuwanie sekretów w kodzie źródłowym. Skanuj swoje repozytoria git pod kątem 350+ rodzajów sekretów i plików wrażliwych – darmowe dla osób i zespołów do 25 deweloperów.
* [Have I been pwned?](https://haveibeenpwned.com) — REST API do pobierania informacji o wyciekach danych.
* [hostedscan.com](https://hostedscan.com) — Online skaner podatności dla aplikacji webowych, serwerów i sieci. 10 darmowych skanów miesięcznie.
* [Infisical](https://infisical.com/) — Otwarta platforma do zarządzania sekretami deweloperskimi dla zespołów i infrastruktury: od developmentu lokalnego po staging/produkcyjne usługi zewnętrzne. Za darmo do 5 deweloperów.
* [Internet.nl](https://internet.nl) — Test zgodności z nowoczesnymi standardami internetu: IPv6, DNSSEC, HTTPS, DMARC, STARTTLS i DANE
* [keychest.net](https://keychest.net) - Zarządzanie wygasaniem certyfikatów SSL i zakup certyfikatów zintegrowane z bazą CT
* [letsencrypt.org](https://letsencrypt.org/) — Darmowy urząd certyfikacji SSL, certyfikaty zaufane przez wszystkie główne przeglądarki
* [meterian.io](https://www.meterian.io/) - Monitorowanie projektów Java, Javascript, .NET, Scala, Ruby i NodeJS pod kątem podatności w zależnościach. Darmowe dla jednego prywatnego projektu, nielimitowane projekty open source.
* [Mozilla Observatory](https://observatory.mozilla.org/) — Wyszukuj i naprawiaj luki bezpieczeństwa w swojej stronie.
* [opswat.com](https://www.opswat.com/) — Monitoring bezpieczeństwa komputerów, urządzeń, aplikacji, konfiguracji, darmowo do 25 użytkowników i 30 dni historii.
* [openapi.security](https://openapi.security/) - Darmowe narzędzie do szybkiej weryfikacji bezpieczeństwa dowolnego API opartego na OpenAPI/Swagger. Bez rejestracji.
* [pixee.ai](https://pixee.ai) - Automatyczny Product Security Engineer jako darmowy bot GitHub, który tworzy PR do kodu Java i automatycznie naprawia podatności. Wkrótce wsparcie dla innych języków!
* [pyup.io](https://pyup.io) — Monitorowanie zależności Pythona pod kątem podatności i automatyczne aktualizacje. Darmowe dla jednego prywatnego projektu, nielimitowane projekty open source.
* [qualys.com](https://www.qualys.com/community-edition) — Wyszukiwanie podatności aplikacji webowych, audyt pod kątem ryzyk OWASP
* [report-uri.io](https://report-uri.io/) — Raportowanie naruszeń CSP i HPKP
* [ringcaptcha.com](https://ringcaptcha.com/) — Narzędzia do używania numeru telefonu jako identyfikatora, dostępne za darmo
* [seclookup.com](https://www.seclookup.com/) - API Seclookup wzbogacają wskaźniki zagrożeń domenowych w SIEM, dostarczają kompleksowych informacji o domenach i zwiększają wykrywalność zagrożeń. 50 tys. zapytań za darmo [tutaj](https://account.seclookup.com/).
* [snyk.io](https://snyk.io) — Wyszukiwanie i naprawa znanych podatności w zależnościach open source. Nielimitowane testy i naprawy dla projektów open source. Limit 200 testów/miesiąc dla prywatnych projektów.
* [ssllabs.com](https://www.ssllabs.com/ssltest/) — Dogłębna analiza konfiguracji dowolnego serwera SSL
* [SOOS](https://soos.io) - Darmowe, nieograniczone skanowanie SCA dla projektów open source. Wykrywaj i naprawiaj zagrożenia bezpieczeństwa przed publikacją. Proste i skuteczne narzędzie.
* [StackHawk](https://www.stackhawk.com/) Automatyzuj skanowanie aplikacji w całym pipeline, by znaleźć i naprawić błędy bezpieczeństwa zanim trafią na produkcję. Nielimitowane skanowania i środowiska dla jednej aplikacji.
* [Sucuri SiteCheck](https://sitecheck.sucuri.net) - Darmowy skaner bezpieczeństwa strony i malware
* [Protectumus](https://protectumus.com) - Darmowy test bezpieczeństwa strony, antywirus strony oraz firewall serwera (WAF) dla PHP. Powiadomienia email dla zarejestrowanych użytkowników w darmowym planie.
* [TestTLS.com](https://testtls.com) - Test SSL/TLS pod kątem konfiguracji serwera, certyfikatów, łańcuchów itp. Nie tylko dla HTTPS.
* [threatconnect.com](https://threatconnect.com) — Threat intelligence: zaprojektowane dla indywidualnych badaczy, analityków i organizacji zaczynających naukę cyber threat intelligence. Bezpłatne do 3 użytkowników.
* [tinfoilsecurity.com](https://www.tinfoilsecurity.com/) — Automatyczne skanowanie podatności. Darmowy plan pozwala na cotygodniowe skanowanie XSS
* [Ubiq Security](https://ubiqsecurity.com/) — Szyfruj i deszyfruj dane trzema liniami kodu oraz automatyczne zarządzanie kluczami. Za darmo dla jednej aplikacji i do 1 000 000 szyfrowań miesięcznie.
* [Virgil Security](https://virgilsecurity.com/) — Narzędzia i usługi do wdrażania szyfrowania end-to-end, ochrony baz danych, bezpieczeństwa IoT i innych. Darmowe dla aplikacji do 250 użytkowników.
* [Vulert](https://vulert.com) - Vulert stale monitoruje zależności open source pod kątem nowych podatności, rekomenduje naprawy bez potrzeby instalowania lub dostępu do kodu. Darmowe dla projektów open source.
* [Escape GraphQL Quickscan](https://escape.tech/) - Jednoklikowy skan bezpieczeństwa endpointów GraphQL. Darmowe, bez logowania.
* [HasMySecretLeaked](https://gitguardian.com/hasmysecretleaked) - Przeszukaj 20 milionów ujawnionych sekretów w publicznych repozytoriach GitHub, gistach, issue i komentarzach za darmo.
* [Project Gatekeeper](https://gatekeeper.binarybiology.top/) - Kompleksowy zestaw narzędzi SSL: generator kluczy prywatnych i CSR, dekoder certyfikatów SSL, matcher certyfikatów, zamówienie certyfikatu SSL. Umożliwiamy generowanie darmowych certyfikatów SSL od Let's Encrypt, Google Trust i BuyPass za pomocą rekordów CNAME zamiast TXT.
**[⬆️ Powrót na górę](#table-of-contents)**

## Uwierzytelnianie, autoryzacja i zarządzanie użytkownikami

  * [Aserto](https://www.aserto.com) - Szczegółowa autoryzacja jako usługa dla aplikacji i API. Darmowe do 1000 MAU i 100 instancji autoryzatora.
  * [asgardeo.io](https://wso2.com/asgardeo) - Płynna integracja SSO, MFA, uwierzytelniania bezhasłowego i innych funkcji. Zawiera SDK dla aplikacji frontendowych i backendowych. Darmowe do 1000 MAU i pięciu dostawców tożsamości.
  * [Auth0](https://auth0.com/) — Hostowane SSO. Darmowy plan obejmuje 25 000 MAU, nieograniczone połączenia społecznościowe, własną domenę i więcej.
  * [Authgear](https://www.authgear.com) - Dodaj uwierzytelnianie bezhasłowe, OTP, 2FA, SSO do swoich aplikacji w kilka minut. Cały frontend w zestawie. Darmowe do 5000 MAU.
  * [Authress](https://authress.io/) — Logowanie i kontrola dostępu, nieograniczeni dostawcy tożsamości dla dowolnego projektu. Facebook, Google, Twitter i więcej. Pierwsze 1000 wywołań API za darmo.
  * [Authy](https://authy.com) - Uwierzytelnianie dwuskładnikowe (2FA) na wielu urządzeniach z kopią zapasową. Zamiennik Google Authenticator. Darmowe do 100 udanych uwierzytelnień.
  * [Cerbos Hub](https://www.cerbos.dev/product-cerbos-hub) - Kompletny system zarządzania autoryzacją do tworzenia, testowania i wdrażania polityk dostępu. Szczegółowa autoryzacja i kontrola dostępu, darmowe do 100 aktywnych miesięcznie podmiotów.
  * [Clerk](https://clerk.com) — Zarządzanie użytkownikami, uwierzytelnianie, 2FA/MFA, gotowe komponenty UI do logowania, rejestracji, profili użytkowników i więcej. Darmowe do 10 000 aktywnych użytkowników miesięcznie.
  * [Cloud-IAM](https://www.cloud-iam.com/) — Keycloak Identity and Access Management jako usługa. Darmowe do 100 użytkowników i jednej domeny (realm).
  * [Corbado](https://www.corbado.com/) — Dodaj uwierzytelnianie passkey-first do nowych lub istniejących aplikacji. Darmowe dla nieograniczonej liczby MAU.
  * [Descope](https://www.descope.com/) — Wysoce konfigurowalne przepływy AuthN, tryb no-code oraz API/SDK, darmowe 7500 aktywnych użytkowników miesięcznie, 50 tenantów (do 5 tenantów SAML/SSO).
  * [duo.com](https://duo.com/) — Uwierzytelnianie dwuskładnikowe (2FA) dla strony internetowej lub aplikacji. Darmowe dla 10 użytkowników, wszystkie metody uwierzytelniania, nieograniczone integracje, tokeny sprzętowe.
  * [Kinde](https://kinde.com/) - Proste, solidne uwierzytelnianie gotowe do integracji z Twoim produktem w kilka minut. Wszystko, czego potrzebujesz na start z 7500 darmowymi MAU.
  * [logintc.com](https://www.logintc.com/) — Uwierzytelnianie dwuskładnikowe (2FA) przez powiadomienia push, darmowe dla 10 użytkowników, VPN, strony WWW i SSH
  * [MojoAuth](https://mojoauth.com/) - MojoAuth ułatwia wdrożenie uwierzytelniania bezhasłowego na stronie, w aplikacji mobilnej lub dowolnej w kilka minut.
  * [Okta](https://developer.okta.com/signup/) — Zarządzanie użytkownikami, uwierzytelnianie i autoryzacja. Darmowe do 100 aktywnych użytkowników miesięcznie.
  * [onelogin.com](https://www.onelogin.com/) — Tożsamość jako usługa (IDaaS), dostawca SSO, cloud SSO IdP, trzy aplikacje firmowe i pięć osobistych, nieograniczona liczba użytkowników
  * [Ory](https://ory.sh/) - Platforma bezpieczeństwa zarządzana AuthN/AuthZ/OAuth2.0/Zero Trust. Bezpłatne konta deweloperskie na zawsze z wszystkimi funkcjami bezpieczeństwa, nieograniczoną liczbą członków zespołu, 200 aktywnych użytkowników dziennie i 25 tys./mies. sprawdzeń uprawnień.
  * [Permit.io](https://permit.io) - Platforma Authorization-as-a-service umożliwiająca RBAC, ABAC i ReBAC dla skalowalnych mikroserwisów z aktualizacjami w czasie rzeczywistym i UI do polityk no-code. Darmowy poziom do 1000 aktywnych użytkowników miesięcznie.
  * [Phase Two](https://phasetwo.io) - Keycloak Open Source Identity and Access Management. Darmowa domena do 1000 użytkowników, do 10 połączeń SSO, oparta na kontenerze Phase Two Keycloak z rozszerzeniem [Organization](https://phasetwo.io/product/organizations/).
  * [SSOJet](https://ssojet.com/) - Dodaj Enterprise SSO bez przebudowy autoryzacji. Darmowy plan: nieograniczeni aktywni użytkownicy miesięcznie, nieograniczone organizacje, 2 połączenia SSO i 2 połączenia SCIM.
  * [Stytch](https://www.stytch.com/) - Platforma all-in-one oferująca API i SDK do uwierzytelniania i zapobiegania oszustwom. Darmowy plan: 10 000 aktywnych użytkowników miesięcznie, nieograniczone organizacje, 5 połączeń SSO lub SCIM oraz 1 000 tokenów M2M.
  * [Stack Auth](https://stack-auth.com) — Open-source uwierzytelnianie, które jest przyjazne dla deweloperów, gotowe do wdrożenia w 5 minut. Do samodzielnego hostowania za darmo lub wersja SaaS z 10 tys. darmowych MAU.
  * [SuperTokens](https://supertokens.com/) - Open source uwierzytelnianie użytkowników, które natywnie integruje się z Twoją aplikacją — szybki start i pełna kontrola nad doświadczeniem użytkownika i dewelopera. Darmowe do 5000 MAU.
  * [Warrant](https://warrant.dev/) — Hostowana usługa autoryzacji klasy enterprise i kontroli dostępu dla aplikacji. Darmowy poziom: 1 mln żądań API miesięcznie i 1000 reguł autoryzacji.
  * [ZITADEL Cloud](https://zitadel.com) — Gotowy system zarządzania użytkownikami i dostępem, obsługuje przypadki multi-tenant (B2B). Darmowe do 25 000 uwierzytelnionych żądań, wszystkie funkcje bezpieczeństwa (bez paywalla za OTP, bezhasłowe, polityki itp.).
  * [PropelAuth](https://propelauth.com) — Sprzedawaj firmom dowolnej wielkości w kilka linijek kodu, darmowe do 200 użytkowników i 10 tys. e-maili transakcyjnych (z brandingiem: "Powered by PropelAuth").
  * [Logto](https://logto.io/) - Rozwijaj, zabezpieczaj i zarządzaj tożsamościami użytkowników produktu — zarówno dla uwierzytelniania, jak i autoryzacji. Darmowe do 5 000 MAU z opcją open-source self-hosted.
  * [WorkOS](https://workos.com/) - Darmowe zarządzanie użytkownikami i uwierzytelnianie dla do 1 mln MAU. Obsługuje email + hasło, logowanie społecznościowe, Magic Auth, MFA i więcej.


**[⬆️ Powrót na górę](#table-of-contents)**

## Dystrybucja aplikacji mobilnych i feedback

  * [TestApp.io](https://testapp.io) - Platforma zapewniająca poprawność działania aplikacji mobilnych. Darmowy plan: jedna aplikacja, analityka, nieograniczone wersje i instalacje, zbieranie feedbacku.
  * [Loadly](https://loadly.io) - Usługa dystrybucji aplikacji beta na iOS i Androida oferuje całkowicie darmowe usługi z nieograniczoną liczbą pobrań, szybkim transferem i nieograniczoną liczbą uploadów.
  * [Diawi](https://www.diawi.com) - Wdrażanie aplikacji iOS i Android bezpośrednio na urządzenia. Darmowy plan: uploady, linki z hasłem, 1-dniowy okres ważności, 10 instalacji.
  * [InstallOnAir](https://www.installonair.com) - Dystrybucja aplikacji iOS i Android przez OTA. Darmowy plan: nieograniczone uploady, prywatne linki, 2-dniowy okres ważności dla gości, 60 dni dla zarejestrowanych.
  * [GetUpdraft](https://www.getupdraft.com) - Dystrybucja aplikacji mobilnych do testów. Darmowy plan: jeden projekt, trzy wersje aplikacji, 500 MB na pliki, 100 instalacji miesięcznie.
  * [Appho.st](https://appho.st) - Hosting aplikacji mobilnych. Darmowy plan: 5 aplikacji, 50 pobrań miesięcznie, max rozmiar pliku 100 MB.

**[⬆️ Powrót na górę](#table-of-contents)**

## Systemy zarządzania

  * [bitnami.com](https://bitnami.com/) — Wdrażanie gotowych aplikacji na IaaS. Zarządzanie 1 mikroinstancją AWS za darmo
  * [Esper](https://esper.io) — MDM i MAM dla urządzeń Android z DevOps. Sto urządzeń za darmo z jedną licencją użytkownika i 25 MB miejsca na aplikacje.
  * [jamf.com](https://www.jamf.com/) —  Zarządzanie urządzeniami iPad, iPhone i Mac, trzy urządzenia za darmo
  * [Miradore](https://miradore.com) — Usługa zarządzania urządzeniami. Monitorowanie floty urządzeń i zabezpieczenie nieograniczonej liczby urządzeń za darmo. Plan darmowy oferuje podstawowe funkcje.
  * [moss.sh](https://moss.sh) - Pomaga deweloperom wdrażać i zarządzać aplikacjami i serwerami webowymi. Do 25 wdrożeń z gita miesięcznie za darmo
  * [runcloud.io](https://runcloud.io/) - Zarządzanie serwerami, głównie dla projektów PHP. Darmowe do 1 serwera.
  * [ploi.io](https://ploi.io/) - Narzędzie do zarządzania serwerami i wdrażania stron. Darmowe dla jednego serwera.
  * [xcloud.host](https://xcloud.host) — Zarządzanie i wdrażanie serwerów przez wygodny interfejs. Darmowy poziom dla jednego serwera.
  * [serveravatar.com](https://serveravatar.com) — Zarządzanie i monitorowanie serwerów webowych PHP z automatyczną konfiguracją. Darmowe dla jednego serwera.

**[⬆️ Powrót na górę](#table-of-contents)**

## Wiadomości i streaming

  * [Ably](https://www.ably.com/) - Usługa wiadomości w czasie rzeczywistym z obecnością, trwałością i gwarantowaną dostawą. Darmowy plan obejmuje 3 mln wiadomości/miesiąc, 100 połączeń i 100 kanałów jednocześnie.
  * [cloudamqp.com](https://www.cloudamqp.com/) — RabbitMQ jako usługa. Plan Little Lemur: max 1 mln wiadomości/miesiąc, max 20 połączeń jednocześnie, max 100 kolejek, max 10 000 wiadomości w kolejce, wiele węzłów w różnych AZ
  * [courier.com](https://www.courier.com/) — Jedno API do push, in-app, e-mail, czatu, SMS i innych kanałów z zarządzaniem szablonami i innymi funkcjami. Darmowy plan: 10 000 wiadomości/miesiąc.
  * [engagespot.co](https://engagespot.co/) — Infrastruktura powiadomień wielokanałowych z gotową skrzynką odbiorczą i edytorem szablonów no-code. Darmowy plan: 10 000 wiadomości/miesiąc.
  * [HiveMQ](https://www.hivemq.com/mqtt-cloud-broker/) - Podłącz urządzenia MQTT do natywnego brokera IoT w chmurze. Darmowe podłączenie do 100 urządzeń (bez karty kredytowej) na zawsze.
  * [knock.app](https://knock.app) – Infrastruktura powiadomień dla deweloperów. Wysyłaj na różne kanały, takie jak in-app, e-mail, SMS, Slack i push jednym wywołaniem API. Darmowy plan: 10 000 wiadomości/miesiąc.
  * [NotificationAPI.com](https://www.notificationapi.com/) — Dodaj powiadomienia użytkownika do dowolnego oprogramowania w 5 minut. Darmowy plan: 10 000 powiadomień/miesiąc + 100 SMS i połączeń automatycznych.
  * [Novu.co](https://novu.co) — Open source infrastruktura powiadomień dla deweloperów. Proste komponenty i API do zarządzania wszystkimi kanałami: e-mail, SMS, bezpośrednie, in-app i push. Darmowy plan: 30 000 powiadomień/miesiąc, 90 dni retencji.
  * [pusher.com](https://pusher.com/) — Usługa wiadomości w czasie rzeczywistym. Darmowe do 100 połączeń jednocześnie i 200 000 wiadomości dziennie
  * [scaledrone.com](https://www.scaledrone.com/) — Wiadomości w czasie rzeczywistym. Darmowe do 20 połączeń jednocześnie i 100 000 zdarzeń dziennie
  * [synadia.com](https://synadia.com/ngs) — [NATS.io](https://nats.io) jako usługa. Globalnie, AWS, GCP i Azure. Darmowe na zawsze: rozmiar wiadomości 4k, 50 aktywnych połączeń, 5 GB danych miesięcznie.
  * [pubnub.com](https://www.pubnub.com/) - Swift, Kotlin i React messaging: 1 mln transakcji miesięcznie. Jedna transakcja może zawierać wiele wiadomości.
  * [eyeson API](https://developers.eyeson.team/) - API komunikacji wideo na bazie WebRTC (SFU, MCU) do budowy platform wideo. Pozwala na przesyłanie danych w czasie rzeczywistym, układy wideo, nagrania, gotowy web UI lub pakiety do własnego UI. [Darmowy tier dla deweloperów](https://apiservice.eyeson.com/api-pricing): 1000 minut spotkań miesięcznie.
  * [webpushr](https://www.webpushr.com/) - Web Push Notifications - darmowe do 10 tys. subskrybentów, nieograniczone powiadomienia push, wiadomości w przeglądarce
  * [httpSMS](https://httpsms.com) - Wysyłaj i odbieraj SMSy używając telefonu z Androidem jako bramki SMS. Darmowe do 200 wiadomości miesięcznie.
  * [EMQX Serverless](https://www.emqx.com/en/cloud/serverless-mqtt) - Skalowalny i bezpieczny serverless broker MQTT dostępny w kilka sekund. 1 mln minut sesji miesięcznie za darmo (bez karty kredytowej).
  * [Pocket Alert](https://pocketalert.app) - Wysyłaj powiadomienia push na iOS i Androida. Integracja przez API lub webhooki, pełna kontrola nad alertami. Darmowy plan: 50 wiadomości dziennie na 1 urządzenie i 1 aplikację.
  * [SuprSend](https://www.suprsend.com/) - Infrastruktura powiadomień do obsługi powiadomień transakcyjnych, crons i engagement przez jedno API. Darmowy plan: 10 000 powiadomień miesięcznie, różne workflow nodes (digests, batch, multi-channels, preferences, tenants, broadcasts itd.).

**[⬆️ Powrót na górę](#table-of-contents)**

## Zarządzanie logami

  * [bugfender.com](https://bugfender.com/) — Za darmo do 100 tys. linii logów dziennie z 24 godzinną retencją
  * [logentries.com](https://logentries.com/) — Za darmo do 5 GB/miesiąc, 7 dni retencji
  * [loggly.com](https://www.loggly.com/) — Za darmo dla jednego użytkownika, 200MB/dzień, 7 dni retencji
  * [logz.io](https://logz.io/) — Za darmo do 1 GB/dzień, 1 dzień retencji
  * [ManageEngine Log360 Cloud](https://www.manageengine.com/cloud-siem/) — Usługa zarządzania logami od Manage Engine. Darmowy plan: 50 GB przestrzeni, 15 dni retencji, 7 dni wyszukiwania.
  * [papertrailapp.com](https://papertrailapp.com/) — 48 godzin wyszukiwania, 7 dni archiwum, 50 MB/miesiąc
  * [sematext.com](https://sematext.com/logsene) — Za darmo do 500 MB/dzień, 7 dni retencji
  * [sumologic.com](https://www.sumologic.com/) — Za darmo do 500 MB/dzień, 7 dni retencji
  * [logflare.app](https://logflare.app/) — Za darmo do 12 960 000 wpisów na aplikację miesięcznie, 3 dni retencji
  * [logtail.com](https://logtail.com/) — Zarządzanie logami na bazie ClickHouse, zgodne z SQL. Za darmo do 1 GB miesięcznie, trzy dni retencji.
  * [logzab.com](https://logzab.com/) — Zarządzanie śladem audytu. Darmowe 1000 logów aktywności użytkownika miesięcznie, 1 miesiąc retencji, do 5 projektów.
  * [openobserve.ai](https://openobserve.ai/) - 200 GB ingestii miesięcznie za darmo, 15 dni retencji
**[⬆️ Powrót na górę](#table-of-contents)**

## Zarządzanie tłumaczeniami

  * [crowdin.com](https://crowdin.com/) — Nieograniczona liczba projektów, nieograniczona liczba ciągów i współpracowników dla Open Source
  * [gitlocalize.com](https://gitlocalize.com) - Za darmo i bez ograniczeń dla repozytoriów prywatnych i publicznych
  * [Lecto](https://lecto.ai/) - API tłumaczenia maszynowego z darmowym poziomem (30 darmowych żądań, 1000 przetłumaczonych znaków na żądanie). Zintegrowane z wtyczką Loco Translate do Wordpressa.
  * [lingohub.com](https://lingohub.com/) — Za darmo do 3 użytkowników, zawsze bezpłatnie dla Open Source
  * [localazy.com](https://localazy.com) - Za darmo do 1000 ciągów w języku źródłowym, nieograniczona liczba języków, nieograniczona liczba współpracowników, oferty dla startupów i open source
  * [Localeum](https://localeum.com) - Za darmo do 1000 ciągów, jeden użytkownik, nieograniczona liczba języków, nieograniczona liczba projektów
  * [localizely.com](https://localizely.com/) — Za darmo dla Open Source
  * [Loco](https://localise.biz/) — Za darmo do 2000 tłumaczeń, nieograniczona liczba tłumaczy, dziesięć języków/projekt, 1000 tłumaczalnych zasobów/projekt
  * [oneskyapp.com](https://www.oneskyapp.com/) — Ograniczona darmowa edycja dla maksymalnie 5 użytkowników, za darmo dla Open Source
  * [POEditor](https://poeditor.com/) — Za darmo do 1000 ciągów
  * [SimpleLocalize](https://simplelocalize.io/) - Za darmo do 100 kluczy tłumaczeń, nieograniczona liczba ciągów, nieograniczona liczba języków, oferty dla startupów
  * [Texterify](https://texterify.com/) - Za darmo dla jednego użytkownika
  * [Tolgee](https://tolgee.io) - Darmowa oferta SaaS z ograniczoną liczbą tłumaczeń, zawsze darmowa wersja self-hosted
  * [transifex.com](https://www.transifex.com/) — Za darmo dla Open Source
  * [Translation.io](https://translation.io) - Za darmo dla Open Source
  * [Translized](https://translized.com) - Za darmo do 1000 ciągów, jeden użytkownik, nieograniczona liczba języków, nieograniczona liczba projektów
  * [webtranslateit.com](https://webtranslateit.com/) — Za darmo do 500 ciągów
  * [weblate.org](https://weblate.org/) — Za darmo dla projektów libre do 10 000 źródłowych ciągów w darmowym planie i Nieograniczone dla wersji Self-hosted on-premises.
  * [Free PO editor](https://pofile.net/free-po-editor) — Za darmo dla wszystkich
  * [Lingo.dev](https://lingo.dev) – Open-source’owe narzędzie CLI wspierane przez AI do lokalizacji aplikacji webowych i mobilnych. Możesz użyć własnego LLM lub skorzystać z 10 000 darmowych słów miesięcznie poprzez silnik lokalizacyjny zarządzany przez Lingo.dev.

**[⬆️ Powrót na górę](#table-of-contents)**

## Monitorowanie

  * [UptimeObserver.com](https://uptimeobserver.com) - 20 monitorów dostępności z interwałem 5 minut i konfigurowalną stroną statusu — nawet do użytku komercyjnego. Nielimitowane, natychmiastowe powiadomienia przez email i Telegram. Bez potrzeby karty kredytowej.
  * [Pingmeter.com](https://pingmeter.com/) - 5 monitorów dostępności z interwałem 10 minut. Monitoruj SSH, HTTP, HTTPS i dowolne niestandardowe porty TCP.
  * [alerty.ai](https://www.alerty.ai) - Darmowe APM i monitoring dla FE, BE, DB i więcej + darmowe uruchomienia agenta.
  * [appdynamics.com](https://www.appdynamics.com/) — Za darmo dla 24-godzinnych metryk, agenci do zarządzania wydajnością aplikacji ograniczeni do jednego Java, jednego .NET, jednego PHP i jednego Node.js
  * [appneta.com](https://www.appneta.com/) — Darmowy z 1-godzinnym przechowywaniem danych
  * [appspector.com](https://appspector.com/) - Centrum kontroli do zdalnego debugowania iOS/Android/Flutter. Za darmo przy małym ruchu (64MB logów).
  * [assertible.com](https://assertible.com) — Automatyczne testowanie i monitorowanie API. Darmowe plany dla zespołów i użytkowników indywidualnych.
  * [bleemeo.com](https://bleemeo.com) - Za darmo dla 3 serwerów, 5 monitorów dostępności, nieograniczeni użytkownicy, nieograniczone dashboardy, nieograniczone reguły powiadomień.
  * [Core Web Vitals History](https://punits.dev/core-web-vitals-historical/) - Historia Core Web Vitals dla adresu URL lub strony.
  * [checklyhq.com](https://checklyhq.com) - Open source E2E / Synthetic monitoring oraz zaawansowany monitoring API dla deweloperów. Darmowy plan dla jednego użytkownika i 10k API & network / 1.5k browser check runs.
  * [cloudsploit.com](https://cloudsploit.com) — Monitorowanie bezpieczeństwa i konfiguracji AWS. Za darmo: nieograniczona liczba skanów na żądanie, nieograniczona liczba użytkowników, nieograniczona liczba przechowywanych kont. Subskrypcja: automatyczne skanowanie, dostęp do API itp.
  * [cronitor.io](https://cronitor.io/) - Wgląd w wydajność i monitoring dostępności dla zadań cron, stron, API i więcej. Darmowy poziom z pięcioma monitorami.
  * [datadoghq.com](https://www.datadoghq.com/) — Za darmo do 5 węzłów
  * [deadmanssnitch.com](https://deadmanssnitch.com/) — Monitorowanie zadań cron. Jeden darmowy snitch (monitor), więcej jeśli polecisz innym rejestrację
  * [downtimemonkey.com](https://downtimemonkey.com/) — 60 monitorów dostępności, interwał 5 minut. Powiadomienia email, Slack.
  * [economize.cloud](https://economize.cloud) — Economize pomaga zrozumieć koszty infrastruktury chmurowej przez organizowanie zasobów chmurowych, by zoptymalizować i raportować wydatki. Darmowe do 5000 USD wydatków miesięcznie na Google Cloud Platform.
  * [elastic.co](https://www.elastic.co/solutions/apm) — Natychmiastowy wgląd w wydajność dla deweloperów JS. Za darmo z 24-godzinnym przechowywaniem danych
  * [fivenines.io](https://fivenines.io/) — Monitorowanie serwerów Linux z dashboardami czasu rzeczywistego i alertami — zawsze za darmo do 5 monitorowanych serwerów z interwałem 60 sekund. Bez potrzeby karty kredytowej.
  * [Grafana Cloud](https://grafana.com/products/cloud/) - Grafana Cloud to platforma do obserwowalności integrująca metryki i logi z Grafaną. Za darmo: 3 użytkowników, dziesięć dashboardów, 100 alertów, przechowywanie metryk w Prometheus i Graphite (10 000 serii, 14 dni retencji), przechowywanie logów w Loki (50 GB logów, 14 dni retencji)
  * [healthchecks.io](https://healthchecks.io) — Monitorowanie zadań cron i zadań w tle. Za darmo do 20 sprawdzeń.
  * [Hydrozen.io](https://hydrozen.io) — Monitoring dostępności i strony statusu, plan darmowy: 10 monitorów dostępności, 5 monitorów heartbeat, 1 monitor domeny i 1 strona statusu za darmo.
  * [incidenthub.cloud](https://incidenthub.cloud/) — Agregator stron statusowych chmury i SaaS - 20 monitorów i 2 kanały powiadomień (Slack i Discord) na zawsze za darmo.
  * [inspector.dev](https://www.inspector.dev) - Kompletny dashboard monitoringu czasu rzeczywistego w mniej niż minutę z darmowym planem na zawsze.
  * [instrumentalapp.com](https://instrumentalapp.com) - Łatwe w obsłudze i estetyczne monitorowanie aplikacji i serwerów do 500 metryk i 3 godziny widoczności danych za darmo
  * [keychest.net/speedtest](https://keychest.net/speedtest) - Niezależny test prędkości i opóźnienia TLS handshake wobec Digital Ocean
  * [letsmonitor.org](https://letsmonitor.org) - Monitorowanie SSL, za darmo do 5 monitorów
  * [linkok.com](https://linkok.com) - Online checker uszkodzonych linków, darmowy dla małych stron do 100 stron, całkowicie darmowy dla projektów open-source.
  * [loader.io](https://loader.io/) — Darmowe narzędzia do testowania obciążeniowego z ograniczeniami
  * [MonitorMonk](https://monitormonk.com) - Minimalistyczny monitoring dostępności z estetycznymi stronami statusu. Darmowy plan Forever Free oferuje monitorowanie HTTPS, słów kluczowych, SSL i czasu odpowiedzi dla 10 stron lub endpointów API, oraz 2 dashboardy/strony statusu.
  * [netdata.cloud](https://www.netdata.cloud/) — Netdata to narzędzie open-source do zbierania metryk w czasie rzeczywistym. Produkt stale rozwijany, dostępny również na GitHub!
  * [newrelic.com](https://www.newrelic.com) — Platforma obserwowalności New Relic, pomagająca inżynierom tworzyć lepsze oprogramowanie. Od monolitów po serverless — instrumentacja wszystkiego, analiza, rozwiązywanie problemów i optymalizacja całego stosu. Darmowy poziom obejmuje 100 GB/miesiąc darmowych danych, jednego użytkownika z pełnym dostępem i nieograniczoną liczbę podstawowych użytkowników.
  * [Middleware.io](https://middleware.io/) - Platforma obserwowalności Middleware zapewnia pełną widoczność aplikacji i środowiska, umożliwiając monitoring i diagnozowanie problemów na dużą skalę. Darmowy plan dla społeczności deweloperów obejmuje monitoring logów do 1 mln zdarzeń, monitoring infrastruktury i APM do 2 hostów.
  * [nixstats.com](https://nixstats.com) - Za darmo dla jednego serwera. Powiadomienia email, publiczna strona statusu, interwał 60 sekund i więcej.
  * [OnlineOrNot.com](https://onlineornot.com/) - OnlineOrNot oferuje monitoring dostępności stron i API, monitoring zadań cron i zadań cyklicznych. Oferuje też strony statusu. Pierwsze pięć sprawdzeń z interwałem 3 minut jest darmowe. Darmowy poziom wysyła powiadomienia przez Slack, Discord i email.
  * [OntarioNet.ca CN Test](https://cntest.ontarionet.ca) — Sprawdź, czy strona jest zablokowana w Chinach przez Wielki Firewall. Identyfikuje skażenie DNS porównując wyniki DNS i informacje ASN wykryte przez serwery w Chinach i USA.
  * [opsgenie.com](https://www.opsgenie.com/) — Potężne powiadamianie i zarządzanie on-call dla usług zawsze dostępnych. Za darmo do 5 użytkowników.
  * [paessler.com](https://www.paessler.com/) — Zaawansowane monitorowanie infrastruktury i sieci, powiadamianie, silna wizualizacja i podstawowe raportowanie. Za darmo do 100 sensorów.
  * [pagecrawl.io](https://pagecrawl.io/) - Monitorowanie zmian na stronach, za darmo do 6 monitorów z codziennym sprawdzaniem.
  * [syagent.com](https://syagent.com/) — Niekomercyjny, darmowy monitoring serwerów, alerty i metryki.
  * [pagerly.io](https://pagerly.io/) - Zarządzanie dyżurami w Slacku (integruje się z Pagerduty, OpsGenie). Za darmo dla 1 zespołu (jeden zespół to jeden dyżur)
  * [pagertree.com](https://pagertree.com/) - Prosty interfejs do powiadamiania i zarządzania dyżurami. Za darmo do 5 użytkowników.
  * [phare.io](https://phare.io/) - Monitoring dostępności za darmo do 100 000 zdarzeń dla nieograniczonej liczby projektów i stron statusu.
  * [pingbreak.com](https://pingbreak.com/) — Nowoczesny monitoring dostępności. Sprawdzanie nieograniczonej liczby URL-i i powiadomienia o awariach przez Discord, Slack lub email.
  * [pingpong.one](https://pingpong.one/) — Zaawansowana platforma stron statusowych z monitoringiem. Darmowy poziom obejmuje jedną publiczną, konfigurowalną stronę statusu z subdomeną SSL. Plan Pro oferowany za darmo dla projektów open-source i organizacji non-profit.
  * [robusta.dev](https://home.robusta.dev/) — Potężny monitoring Kubernetes oparty na Prometheusie. Możesz użyć własnego Prometheusa lub zainstalować pakiet all-in-one. Darmowy poziom obejmuje do 20 węzłów Kubernetes. Alerty przez Slack, Microsoft Teams, Discord i inne. Integracje z PagerDuty, OpsGenie, VictorOps, DataDog i wieloma innymi narzędziami.
  * [sematext.com](https://sematext.com/) — Za darmo 24-godzinne metryki, nieograniczona liczba serwerów, dziesięć własnych metryk, 500 000 punktów danych własnych metryk, nieograniczone dashboardy, użytkownicy itd.
  * [sitemonki.com](https://sitemonki.com/) — Monitoring stron, domen, Crona i SSL, 5 monitorów w każdej kategorii za darmo
  * [sitesure.net](https://sitesure.net) - Monitoring stron i cron - 2 monitory za darmo
  * [skylight.io](https://www.skylight.io/) — Za darmo dla pierwszych 100 000 żądań (tylko Rails)
  * [speedchecker.xyz](https://probeapi.speedchecker.xyz/) — API do monitorowania wydajności, sprawdza Ping, DNS itd.
  * [stathat.com](https://www.stathat.com/) — Zacznij z dziesięcioma statystykami za darmo, bez limitu czasowego
  * [statuscake.com](https://www.statuscake.com/) — Monitoring stron, nielimitowane testy za darmo z ograniczeniami
  * [statusgator.com](https://statusgator.com/) — Monitoring stron statusowych, 3 monitory za darmo
  * [SweetUptime](https://dicloud.net/sweetuptime-server-uptime-monitoring/) — Monitoring serwerów, dostępności, DNS i domen. Monitoruj 10 serwerów, 10 dostępności i 10 domen za darmo.
  * [thousandeyes.com](https://www.thousandeyes.com/) — Monitoring sieci i doświadczeń użytkownika. 3 lokalizacje i 20 źródeł danych głównych usług webowych za darmo
  * [uptimetoolbox.com](https://uptimetoolbox.com/) — Darmowe monitorowanie dla pięciu stron, interwał 60 sekund, publiczna strona statusowa.
  * [zenduty.com](https://www.zenduty.com/) — Kompleksowe zarządzanie incydentami, powiadamianie, zarządzanie dyżurami i orkiestracja reakcji dla zespołów sieciowych, SRE i DevOps. Za darmo do 5 użytkowników.
  * [instatus.com](https://instatus.com) - Stwórz piękną stronę statusu w 10 sekund. Zawsze za darmo, bez ograniczeń subskrybentów i zespołów.
  * [Squadcast.com](https://squadcast.com) - Squadcast to kompleksowe oprogramowanie do zarządzania incydentami, pomagające promować dobre praktyki SRE. Darmowy plan na zawsze do 10 użytkowników.
  * [RoboMiri.com](https://robomiri.com/) - RoboMiri to stabilny monitoring dostępności oferujący szeroki zakres monitorów: cronjob, słowo kluczowe, strona, port, ping. 25 sprawdzeń dostępności z interwałem 3 minut za darmo. Powiadomienia przez telefon, SMS, email i Webhooki.
  * [Better Stack](https://betterstack.com/better-uptime) - Monitoring dostępności, zarządzanie incydentami, planowanie dyżurów/powiadomień i strony statusowe w jednym produkcie. Darmowy plan obejmuje 10 monitorów z częstotliwością sprawdzania co 3 minuty i strony statusowe.
  * [Pulsetic](https://pulsetic.com) - 10 monitorów, 6 miesięcy historii dostępności/logów, nieograniczone strony statusowe i własne domeny w pakiecie! Bezterminowo i nieograniczone powiadomienia email za darmo. Nie potrzebujesz karty kredytowej.
  * [Wachete](https://www.wachete.com) - monitorowanie pięciu stron, sprawdzanie co 24 godziny.
  * [Xitoring.com](https://xitoring.com/) — Monitoring dostępności: 20 za darmo, monitoring serwerów Linux i Windows: 5 za darmo, strona statusowa: 1 za darmo - aplikacja mobilna, wiele kanałów powiadomień i wiele więcej!
  * [Servervana](https://servervana.com) - Zaawansowany monitoring dostępności z obsługą dużych projektów i zespołów. HTTP monitoring, monitoring przeglądarkowy, monitoring DNS, monitoring domen, strony statusowe i więcej. Darmowy poziom obejmuje 10 monitorów HTTP, 1 monitor DNS i jedną stronę statusową.

**[⬆️ Powrót na górę](#table-of-contents)**

## Obsługa błędów i wyjątków
  * [CatchJS.com](https://catchjs.com/) - Śledzenie błędów JavaScript z zrzutami ekranu i ścieżkami kliknięć. Darmowe dla projektów open-source.
  * [bugsnag.com](https://www.bugsnag.com/) — Darmowe do 2000 błędów/miesiąc po zakończeniu okresu próbnego
  * [elmah.io](https://elmah.io/) — Logowanie błędów i monitorowanie dostępności dla programistów webowych. Darmowa subskrypcja Small Business dla projektów open-source.
  * [Embrace](https://embrace.io/) — Monitorowanie aplikacji mobilnych. Darmowe dla małych zespołów do 1 miliona sesji użytkowników rocznie.
  * [exceptionless](https://exceptionless.com) — Raportowanie błędów, funkcji, logów w czasie rzeczywistym i więcej. Darmowe dla 3 tys. zdarzeń miesięcznie/1 użytkownik. Otwarty kod źródłowy i łatwe do samodzielnego hostowania bez limitów.
  * [GlitchTip](https://glitchtip.com/) — Proste, otwartoźródłowe śledzenie błędów. Kompatybilne z SDK Sentry open-source. 1000 zdarzeń miesięcznie za darmo lub możliwość samodzielnego hostowania bez limitów.
  * [honeybadger.io](https://www.honeybadger.io) - Monitorowanie wyjątków, dostępności i zadań cron. Darmowe dla małych zespołów i projektów open-source (12 000 błędów/miesiąc).
  * [memfault.com](https://memfault.com) — Platforma do obserwowalności urządzeń w chmurze i debugowania. 100 urządzeń za darmo dla urządzeń [Nordic](https://app.memfault.com/register-nordic), [NXP](https://app.memfault.com/register-nxp) oraz [Laird](https://app.memfault.com/register-laird).
  * [rollbar.com](https://rollbar.com/) — Monitorowanie wyjątków i błędów, darmowy plan: 5 000 błędów/miesiąc, nieograniczona liczba użytkowników, 30 dni przechowywania
  * [sentry.io](https://sentry.io/) — Sentry śledzi wyjątki w aplikacjach w czasie rzeczywistym i posiada mały darmowy plan. Darmowe do 5 tys. błędów miesięcznie/1 użytkownik, brak ograniczeń przy samodzielnym hostowaniu
  * [Axiom](https://axiom.co/) — Przechowywanie do 0,5 TB logów z 30-dniowym okresem retencji. Integracje z platformami jak Vercel i zaawansowane zapytania danych z powiadomieniami email/Discord.
  * [Semaphr](https://semaphr.com) — Darmowy, kompleksowy kill switch dla twoich aplikacji mobilnych.
  * [Jam](https://jam.dev) - Przyjazne dla deweloperów raporty błędów jednym kliknięciem. Darmowy plan z nieograniczoną liczbą "jamów".
  * [Whitespace](https://whitespace.dev) – Raportowanie błędów jednym kliknięciem bezpośrednio w przeglądarce. Darmowy plan z nieograniczoną liczbą nagrań do użytku osobistego.

**[⬆️ Powrót na górę](#table-of-contents)**

## Wyszukiwarka

  * [algolia.com](https://www.algolia.com/) — Hostowane rozwiązanie wyszukiwania z tolerancją literówek, trafnością i bibliotekami UI do łatwego tworzenia doświadczeń wyszukiwania. Darmowy plan "Build" obejmuje 1M dokumentów i 10K wyszukiwań/miesiąc. Oferuje też [wyszukiwarkę dokumentacji dla deweloperów](https://docsearch.algolia.com/) za darmo.
  * [bonsai.io](https://bonsai.io/) — 1 GB pamięci i 1 GB przestrzeni dyskowej za darmo
  * [CommandBar](https://www.commandbar.com/) - Unified Search Bar as-a-service, widget/plugin UI umożliwiający użytkownikom wyszukiwanie treści, nawigacji, funkcji itp. w twoim produkcie, co zwiększa odkrywalność. Darmowe do 1 000 aktywnych użytkowników miesięcznie, nieograniczona liczba komend.
  * [Orama Cloud](https://orama.com/pricing) — Darmowe 3 indeksy, 100 tys. dokumentów/indeks, nieograniczone wyszukiwania pełnotekstowe/wektorowe/hybrydowe, 60 dni analityki
  * [searchly.com](http://www.searchly.com/) — Darmowe 2 indeksy i 20 MB przestrzeni
  * [easysitesearch.com](https://easysitesearch.com/) — Widget wyszukiwarki i API, z automatycznym indeksowaniem przez web-crawler. Nieograniczone wyszukiwania za darmo, do 50 podstron.

**[⬆️ Powrót na górę](#table-of-contents)**

## Edukacja i rozwój kariery

  * [FreeCodeCamp](https://www.freecodecamp.org/) - Otwarty, darmowy serwis oferujący kursy i certyfikaty z analizy danych, bezpieczeństwa informacji, programowania webowego i innych dziedzin.
  * [The Odin Project](https://www.theodinproject.com/) - Darmowa, otwartoźródłowa platforma z programem nauczania skupionym na JavaScript i Ruby dla web developmentu.
  * [Free Professional Resume Templates & Editor](https://www.overleaf.com/latex/templates/tagged/cv) - Darmowa platforma z wieloma szablonami CV doświadczonych profesjonalistów, gotowych do sklonowania, pełnej edycji i pobrania, zoptymalizowanych pod ATS.
  * [DeepLearning.AI Short Courses](https://www.deeplearning.ai/short-courses/) - Darmowe krótkie kursy prowadzone przez ekspertów branżowych, pozwalające w godzinę zdobyć praktyczne doświadczenie z najnowszymi narzędziami i technikami generatywnej AI.
  * [LabEx](https://labex.io) - Rozwijaj umiejętności z Linuxa, DevOps, Cyberbezpieczeństwa, Programowania, Data Science i innych poprzez interaktywne laboratoria i projekty z prawdziwego świata.
  * [Roadmap.sh](https://roadmap.sh) - Darmowe ścieżki nauki obejmujące wszystkie aspekty rozwoju od blockchaina po UX Design.
  * [Cisco Networking Academy, Skills for All](https://skillsforall.com/) - Oferuje darmowe kursy z certyfikatami z zakresu cyberbezpieczeństwa, sieci komputerowych i Pythona.
  * [MIT OpenCourseWare](https://ocw.mit.edu/) - MIT OpenCourseWare to internetowa publikacja materiałów z ponad 2 500 kursów MIT, dzieląca się wiedzą z uczniami i nauczycielami na całym świecie. Kanał na YouTube można znaleźć pod [@mitocw](https://www.youtube.com/@mitocw/featured)
  * [W3Schools](https://www.w3schools.com/) - Darmowe tutoriale z technologii webowych takich jak HTML, CSS, JavaScript i innych.
  * [Khan Academy](https://www.khanacademy.org/computing/computer-programming) - Darmowe przewodniki online do nauki podstawowego i zaawansowanego HTML/CSS, JavaScript oraz SQL.
  * [Full Stack Open](https://fullstackopen.com/en/) – Darmowy uniwersytecki kurs z nowoczesnego web developmentu z React, Node.js, GraphQL, TypeScript i więcej. Całkowicie online i w swoim tempie.
  * [edX](https://www.edx.org/) - Dostęp do ponad 4 000 darmowych kursów online z 250 czołowych instytucji, w tym Harvardu i MIT, ze specjalizacją w informatyce, inżynierii i data science.
  * [Django-tutorial.dev](https://django-tutorial.dev) - Darmowe przewodniki online do nauki Django jako pierwszego frameworka oraz darmowy backlink do artykułów napisanych przez użytkowników.

**[⬆️ Powrót na górę](#table-of-contents)**

## E-mail

  * [10minutemail](https://10minutemail.com) - Darmowy, tymczasowy e-mail do testów.
  * [AhaSend](https://ahasend.com) - Usługa e-mail transakcyjnych, darmowe 1000 e-maili miesięcznie, nielimitowane domeny, członkowie zespołu, webhooki i trasy wiadomości w darmowym planie.
  * [AnonAddy](https://anonaddy.com) - Otwartoźródłowe, anonimowe przekierowywanie e-maili, nieograniczona liczba aliasów za darmo
  * [Antideo](https://www.antideo.com) — 10 zapytań API na godzinę na weryfikację e-maila, IP i numeru telefonu w darmowej wersji. Bez konieczności podawania karty kredytowej.
  * [Brevo](https://www.brevo.com/) — 9 000 e-maili/miesiąc, 300 e-maili/dzień za darmo
  * [OneSignal](https://onesignal.com/) — 10 000 e-maili/miesiąc, bez konieczności podawania karty kredytowej.
  * [Bump](https://bump.email/) - 10 darmowych adresów Bump, jedna własna domena
  * [Burnermail](https://burnermail.io/) – 5 darmowych adresów Burner, 1 skrzynka, 7 dni historii skrzynki
  * [Buttondown](https://buttondown.email/) — Usługa newslettera. Do 100 subskrybentów za darmo
  * [CloudMailin](https://www.cloudmailin.com/) - Przychodzące e-maile przez HTTP POST i transakcyjne wychodzące - 10 000 darmowych e-maili/miesiąc
  * [Contact.do](https://contact.do/) — Formularz kontaktowy w linku (bitly dla formularzy kontaktowych)
  * [debugmail.io](https://debugmail.io/) — Łatwy w użyciu serwer testowy poczty dla programistów
  * [DNSExit](https://dnsexit.com/) - Do 2 adresów e-mail pod własną domeną za darmo z 100MB przestrzeni. Wsparcie IMAP, POP3, SMTP, SPF/DKIM.
  * [EmailLabs.io](https://emaillabs.io/en) — Wysyłka do 9 000 e-maili za darmo każdego miesiąca, do 300 e-maili dziennie.
  * [EmailOctopus](https://emailoctopus.com) - Do 2 500 subskrybentów i 10 000 e-maili miesięcznie za darmo
  * [EmailJS](https://www.emailjs.com/) – To nie jest cały serwer pocztowy; to tylko klient e-mail, którego możesz użyć do wysyłania wiadomości bez ujawniania poświadczeń, darmowy poziom obejmuje 200 żądań miesięcznie, 2 szablony e-mail, żądania do 50Kb, ograniczona historia kontaktów.
  * [EtherealMail](https://ethereal.email) - Ethereal to fałszywa usługa SMTP, głównie dla użytkowników Nodemailer i EmailEngine (ale nie tylko). Całkowicie darmowa anty-transakcyjna usługa e-mail, w której wiadomości nigdy nie są dostarczane.
  * [Temp-Mail.org](https://temp-mail.org/en/) - Tymczasowy/jednorazowy generator e-mail z szerokim wyborem domen. Adres e-mail odświeża się przy każdym przeładowaniu strony. Całkowicie darmowe, brak cennika za usługi.
  * [TempMailDetector.com](https://tempmaildetector.com/) - Weryfikacja do 200 e-maili miesięcznie za darmo i sprawdzanie, czy adres jest tymczasowy.
  * [Emailvalidation.io](https://emailvalidation.io) - 100 darmowych weryfikacji e-maili miesięcznie
  * [FakeMailGenerator.com](https://www.fakemailgenerator.com/) - Niemiecki generator tymczasowych/jednorazowych e-maili. Obsługa 10 domen, możliwość tworzenia nieograniczonej liczby adresów. (zawiera reklamy), ale poza tym brak jakichkolwiek opłat, całkowicie darmowy.
  * [forwardemail.net](https://forwardemail.net) — Darmowe przekierowanie e-maili dla własnych domen. Twórz i przekierowuj nieograniczoną liczbę adresów e-mail pod własną domeną (**uwaga**: należy zapłacić, jeśli używasz TLD .casa, .cf, .click, .email, .fit, .ga, .gdn, .gq, .lat, .loan, .london, .men, .ml, .pl, .rest, .ru, .tk, .top, .work z powodu spamu)
  * [Imitate Email](https://imitate.email) - Sandboxowy serwer e-mail do testowania funkcjonalności poczty w procesach build/qa i ci/cd. Darmowe konta otrzymują 15 e-maili dziennie na zawsze.
  * [ImprovMX](https://improvmx.com) – Darmowe przekierowanie e-maili.
  * [EForw](https://www.eforw.com) – Darmowe przekierowanie e-maili dla jednej domeny. Odbieraj i wysyłaj e-maile z własnej domeny.
  * [Inboxes App](https://inboxesapp.com) — Tworzenie do 3 tymczasowych e-maili dziennie, możliwość ich usunięcia z poziomu wygodnego rozszerzenia Chrome. Idealne do testowania procesów rejestracji.
  * [inboxkitten.com](https://inboxkitten.com/) - Darmowa tymczasowa/jednorazowa skrzynka e-mail z automatycznym usuwaniem e-maili po 3 dniach. Otwarty kod źródłowy, możliwość samodzielnego hostowania.
  * [mail-tester.com](https://www.mail-tester.com/) — Testowanie poprawności ustawień DNS/SPF/DKIM/DMARC e-maila, 20 darmowych testów/miesiąc.
  * [dkimvalidator.com](https://dkimvalidator.com/) - Testowanie poprawności ustawień DNS/SPF/DKIM/DMARC e-maila, darmowa usługa od roundsphere.com
  * [mailcatcher.me](https://mailcatcher.me/) — Przechwytuje pocztę i udostępnia ją przez webowy interfejs.
  * [mailchannels.com](https://www.mailchannels.com) - Email API z integracjami REST API i SMTP, darmowe do 3 000 e-maili/miesiąc.
  * [Mailcheck.ai](https://www.mailcheck.ai/) - Zapobiega rejestracji użytkowników przy użyciu tymczasowych adresów e-mail, 120 zapytań/godzinę (~86 400 miesięcznie)
  * [Mailchimp](https://mailchimp.com/) — 500 subskrybentów i 1 000 e-maili/miesiąc za darmo.
  * [Maildroppa](https://maildroppa.com) - Do 100 subskrybentów i nieograniczona liczba e-maili oraz automatyzacji za darmo.
  * [MailerLite.com](https://www.mailerlite.com) — 1 000 subskrybentów/miesiąc, 12 000 e-maili/miesiąc za darmo
  * [MailerSend.com](https://www.mailersend.com) — Email API, SMTP, 3 000 e-maili/miesiąc za darmo dla e-maili transakcyjnych
  * [mailinator.com](https://www.mailinator.com/) — Darmowy, publiczny system e-mail, gdzie możesz użyć dowolnej skrzynki
  * [Mailjet](https://www.mailjet.com/) — 6 000 e-maili/miesiąc za darmo (limit 200 e-maili dziennie)
  * [Mailnesia](https://mailnesia.com) - Darmowy tymczasowy/jednorazowy e-mail, który automatycznie odwiedza linki rejestracyjne.
  * [mailsac.com](https://mailsac.com) - Darmowe API do testowania tymczasowych e-maili, darmowy publiczny hosting e-mail, przechwytywanie wychodzących, email-to-slack/websocket/webhook (1 500 zapytań API miesięcznie)
  * [Mailtrap.io](https://mailtrap.io/) — Fałszywy serwer SMTP do developmentu, darmowy plan z jedną skrzynką, 100 wiadomości, bez członków zespołu, dwa e-maile/sekundę, brak reguł przekierowań.
  * [Mail7.io](https://www.mail7.io/) — Darmowe tymczasowe adresy e-mail dla QA Developerów. Tworzenie adresów poprzez interfejs webowy lub API.
  * [Momentary Email](https://www.momentaryemail.com/) — Darmowe tymczasowe adresy e-mail. Odczyt e-maili na stronie lub przez kanał RSS.
  * [Mutant Mail](https://www.mutantmail.com/) – 10 darmowych ID e-mail, 1 domena, 1 skrzynka. Jedna skrzynka dla wszystkich ID e-mail.
  * [Outlook.com](https://outlook.live.com/owa/) - Darmowa osobista poczta e-mail i kalendarz.
  * [Parsio.io](https://parsio.io) — Darmowy parser e-maili (przekieruj e-mail, wyodrębnij dane, prześlij na serwer)
  * [pepipost.com](https://pepipost.com) — 30 tys. e-maili za darmo w pierwszym miesiącu, potem 100 e-maili dziennie za darmo.
  * [Plunk](https://useplunk.com) - 3 tys. e-maili/miesiąc za darmo
  * [Postmark](https://postmarkapp.com/) - 100 e-maili/miesiąc za darmo, nieograniczone tygodniowe raporty DMARC.
  * [Proton Mail](https://proton.me/mail) -  Darmowa, bezpieczna poczta e-mail z wbudowanym szyfrowaniem end-to-end. 1GB miejsca za darmo.
  * [Queuemail.dev](https://queuemail.dev) — Niezawodne API do wysyłki e-maili. Darmowy poziom (10 000 e-maili/miesiąc). Wysyłka asynchroniczna. Wsparcie kilku serwerów SMTP. Blacklisty, logi, śledzenie, webhooki i więcej.
  * [QuickEmailVerification](https://quickemailverification.com) — Weryfikacja 100 e-maili dziennie za darmo w darmowym planie wraz z innymi darmowymi API jak DEA Detector, DNS Lookup, SPF Detector i inne.


* [Resend](https://resend.com) - API do wysyłania maili transakcyjnych dla deweloperów. 3 000 maili/miesiąc, 100 maili/dzień za darmo, jedna własna domena.
* [Sender](https://www.sender.net) Do 15 000 maili/miesiąc, do 2 500 subskrybentów
* [Sendpulse](https://sendpulse.com) — 500 subskrybentów/miesiąc, 15 000 maili/miesiąc za darmo
* [SimpleLogin](https://simplelogin.io/) – Otwarty kod źródłowy, możliwość samodzielnego hostowania rozwiązania aliasów/przekierowywania e-maili. Darmowe 5 aliasów, nielimitowany transfer, nielimitowane odpowiedzi/wysyłki. Darmowe dla pracowników edukacyjnych (student, naukowiec itp.).
* [Substack](https://substack.com) — Nielimitowana darmowa usługa newslettera. Opłaty pojawiają się dopiero gdy pobierasz opłaty od subskrybentów.
* [Sweego](https://www.sweego.io/) - Europejskie API do maili transakcyjnych dla deweloperów. 500 maili/dzień za darmo.
* [Takeout](https://takeout.bysourfruit.com) - Stale aktualizowana usługa e-mail, która ułatwia wysyłanie wiadomości. Pięćset maili transakcyjnych/miesiąc za darmo.
* [temp-mail.io](https://temp-mail.io) — Darmowa, tymczasowa i jednorazowa poczta e-mail z możliwością posiadania wielu adresów jednocześnie oraz przekierowaniem.
* [tinyletter.com](https://tinyletter.com/) — 5 000 subskrybentów/miesiąc za darmo
* [Touchlead](https://touchlead.app) - Wielofunkcyjne narzędzie do automatyzacji marketingu z zarządzaniem leadami, kreatorem formularzy i automatyzacjami. Darmowe dla ograniczonej liczby leadów i automatyzacji.
* [trashmail.com](https://www.trashmail.com) - Darmowe jednorazowe adresy e-mail z przekierowywaniem i automatycznym wygasaniem adresów.
* [Tuta](https://tuta.com/) - Darmowa, bezpieczna poczta e-mail z wbudowanym szyfrowaniem end-to-end, bez reklam i śledzenia. Darmowe 1GB przestrzeni, jeden kalendarz (Tuta ma także [płatny plan](https://tuta.com/pricing)). Tuta jest także częściowo [open source](https://github.com/tutao/tutanota), możesz samodzielnie hostować.
* [Verifalia](https://verifalia.com/email-verification-api) — API do weryfikacji e-maili w czasie rzeczywistym z potwierdzaniem skrzynki i detekcją adresów jednorazowych; 25 darmowych weryfikacji e-maili/dzień.
* [verimail.io](https://verimail.io/) — Usługa masowej oraz API weryfikacji e-maili. 100 darmowych weryfikacji/miesiąc.
* [Zoho](https://www.zoho.com) — Zaczęło jako dostawca poczty, ale teraz oferuje pakiet usług, z których część ma darmowe plany. Lista usług z darmowymi planami:
   - [Email](https://zoho.com/mail) Darmowe dla 5 użytkowników. 5GB/użytkownik oraz limit załącznika 25MB, jedna domena.
   - [Zoho Assist](https://www.zoho.com/assist) — Darmowy plan obejmuje jedną licencję zdalnego wsparcia i dostęp do 5 komputerów bez nadzoru na czas nieograniczony, do użytku profesjonalnego i osobistego.
   - [Sprints](https://zoho.com/sprints) Darmowe dla 5 użytkowników, 5 projektów i 500MB przestrzeni.
   - [Docs](https://zoho.com/docs) — Darmowe dla 5 użytkowników, limit uploadu 1GB i 5GB przestrzeni. W zestawie Zoho Office Suite (Writer, Sheets & Show).
   - [Projects](https://zoho.com/projects) — Darmowe dla 3 użytkowników, 2 projekty i limit załącznika 10MB. Ten sam plan dotyczy [Bugtracker](https://zoho.com/bugtracker).
   - [Connect](https://zoho.com/connect) — Darmowa współpraca zespołu dla 25 użytkowników, trzy grupy, trzy własne aplikacje, 3 tablice, 3 instrukcje, 10 integracji oraz kanały, wydarzenia i fora.
   - [Meeting](https://zoho.com/meeting) — Spotkania do 3 uczestników oraz 10 uczestników webinaru.
   - [Vault](https://zoho.com/vault) — Zarządzanie hasłami dostępne dla osób indywidualnych.
   - [Showtime](https://zoho.com/showtime) — Kolejne narzędzie do spotkań, przeznaczone do szkoleń zdalnych do 5 uczestników.
   - [Notebook](https://zoho.com/notebook) — Darmowa alternatywa dla Evernote.
   - [Wiki](https://zoho.com/wiki) — Darmowe dla 3 użytkowników, 50MB przestrzeni, nielimitowane strony, kopie zapasowe zip, RSS & Atom feed, kontrola dostępu i własny CSS.
   - [Subscriptions](https://zoho.com/subscriptions) — Darmowe zarządzanie subskrypcjami cyklicznymi dla 20 klientów/subskrypcji i 1 użytkownika, z całą obsługą płatności przez Zoho. Ostatnie 40 metryk subskrypcji jest przechowywanych.
   - [Checkout](https://zoho.com/checkout) — Zarządzanie płatnościami za produkty, 3 strony i do 50 płatności.
   - [Desk](https://zoho.com/desk) — Obsługa klienta dla 3 agentów, prywatna baza wiedzy i zgłoszenia e-mail. Integracja z [Assist](https://zoho.com/assist) dla jednego zdalnego technika i 5 komputerów bez nadzoru.
   - [Cliq](https://zoho.com/cliq) — Czat zespołowy, 100GB przestrzeni, nielimitowani użytkownicy, do 100 użytkowników na kanał, SSO.
   - [Campaigns](https://zoho.com/campaigns) - E-mail marketing
   - [Forms](https://zoho.com/forms) - Kreator formularzy
   - [Sign](https://zoho.com/sign) - Podpisy elektroniczne
   - [Surveys](https://zoho.com/surveys) - Ankiety online
   - [Bookings](https://zoho.com/bookings) - Umawianie wizyt
* [Maileroo](https://maileroo.com) - SMTP relay oraz API do e-maili dla deweloperów. 5 000 maili miesięcznie, nielimitowane domeny, darmowa weryfikacja maili, monitorowanie czarnych list, mail tester i więcej.

**[⬆️ Powrót na górę](#table-of-contents)**

## Platformy zarządzania przełącznikami funkcji (Feature Toggles Management Platforms)

* [ConfigCat](https://configcat.com) - ConfigCat to zorientowana na deweloperów usługa flag funkcji z nielimitowaną wielkością zespołu, świetnym wsparciem i rozsądną ceną. Darmowy plan do 10 flag, dwa środowiska, 1 produkt i 5 milionów żądań miesięcznie.
* [Flagsmith](https://flagsmith.com) - Wdrażaj funkcje z pewnością; zarządzaj flagami funkcji w aplikacjach webowych, mobilnych i po stronie serwera. Skorzystaj z hostowanego API, wdrażaj w chmurze prywatnej lub lokalnie.
* [GrowthBook](https://growthbook.io) - Open source'owy dostawca flag funkcji oraz testów A/B z wbudowanym silnikiem analizy statystycznej Bayesa. Darmowe do 3 użytkowników, nielimitowane flagi i eksperymenty.
* [Hypertune](https://www.hypertune.com) - Typowane flagi funkcji, testy A/B, analityka i konfiguracja aplikacji, z wersjonowaniem w stylu Gita i synchroniczną, lokalną ewaluacją flag. Darmowe do 5 członków zespołu, nielimitowane flagi i testy A/B.
* [Molasses](https://www.molasses.app) - Zaawansowane flagi funkcji i testy A/B. Darmowe do 3 środowisk, po 5 flag funkcji każde.
* [Toggled.dev](https://www.toggled.dev) - Platforma do zarządzania przełącznikami funkcji gotowa dla przedsiębiorstw, skalowalna, wieloregionalna. Darmowy plan do 10 flag, dwa środowiska, nielimitowane żądania. SDK, panel analityczny, kalendarz wydań, powiadomienia Slack i wszystkie inne funkcje w bezterminowym darmowym planie.
* [Statsig](https://www.statsig.com) - Solidna platforma do zarządzania funkcjami, testów A/B, analityki i więcej. Hojny darmowy plan oferuje nielimitowane miejsca, flagi, eksperymenty i dynamiczne konfiguracje, obsługując do 1 miliona zdarzeń miesięcznie.
* [Abby](https://www.tryabby.com) - Open-Source'owe flagi funkcji i testy A/B. Konfiguracja jako kod, w pełni typowane SDK dla Typescript. Mocna integracja z frameworkami Next.js & React. Hojny darmowy plan i tanie opcje skalowania.

**[⬆️ Powrót na górę](#table-of-contents)**

## Fonty

* [dafont](https://www.dafont.com/) - Fonty prezentowane na tej stronie są własnością ich autorów i są udostępniane jako freeware, shareware, wersje demo lub w domenie publicznej.
* [Everything Fonts](https://everythingfonts.com/) - Oferuje wiele narzędzi; @font-face, konwerter jednostek, Font Hinter oraz Font Submitter.
* [Font Squirrel](https://www.fontsquirrel.com/) - Darmowe fonty licencjonowane do użytku komercyjnego. Ręcznie wybrane kroje pisma prezentowane w łatwej do użycia formie.
* [Google Fonts](https://fonts.google.com/) - Wiele darmowych fontów łatwych i szybkich do instalacji na stronie przez pobranie lub link do CDN Google.
* [FontGet](https://www.fontget.com/) - Różnorodne fonty do pobrania, posegregowane według tagów.
* [Fontshare](https://www.fontshare.com/) - darmowa usługa fontów. Rosnąca kolekcja fontów profesjonalnej jakości, 100% darmowych do użytku osobistego i komercyjnego.
* [Befonts](https://befonts.com/) - Oferuje unikalne fonty do użytku osobistego lub komercyjnego.
* [Font of web](https://fontofweb.com/) - Identyfikuje wszystkie fonty użyte na stronie i sposób ich zastosowania.
* [Bunny](https://fonts.bunny.net) Prywatnościowa alternatywa dla Google Fonts
* [FontsKey](https://www.fontskey.com/) - Oferuje darmowe i płatne fonty do użytku osobistego oraz możliwość wpisania tekstu do szybkiego filtrowania.
* [fonts.xz.style](https://fonts.xz.style/) darmowa i open source'owa usługa dostarczania rodzin fontów na strony przez CSS.
* [Fontsensei](https://fontsensei.com/) Otwarta baza Google Fonts tagowanych przez użytkowników. Z tagami fontów CJK (chińskie, japońskie, koreańskie).

**[⬆️ Powrót na górę](#table-of-contents)**

## Formularze

* [Feathery](https://feathery.io) - Potężny, przyjazny deweloperom kreator formularzy. Buduj rejestracje, logowania, onboarding użytkowników, płatności, złożone aplikacje finansowe i więcej. Darmowy plan umożliwia do 250 wysłanych formularzy/miesiąc i pięć aktywnych formularzy.
* [Form-Data](https://form-data.com) - Backend do formularzy bez kodowania. Filtr antyspamowy, powiadomienia e-mail i autoresponder, webhooki, zapier, przekierowania, AJAX lub POST i więcej. Darmowy plan: nielimitowana liczba formularzy, 20 zgłoszeń/miesiąc oraz dodatkowe 2000 zgłoszeń z odznaką Form-Data.
* [FabForm](https://fabform.io/) - Backend formularzy dla inteligentnych deweloperów. Darmowy plan pozwala na 250 wysłanych formularzy miesięcznie. Przyjazny, nowoczesny interfejs. Integracja z Google Sheets, Airtable, Slack, Email i innymi.
* [Form.taxi](https://form.taxi/) — Endpoint do przesyłania formularzy HTML. Powiadomienia, blokery spamu, przetwarzanie danych zgodne z RODO. Darmowy plan dla podstawowego użycia.
* [Formcarry.com](https://formcarry.com) - HTTP POST endpoint do formularzy, darmowy plan pozwala na 100 zgłoszeń miesięcznie.
* [formingo.co](https://www.formingo.co/)- Proste formularze HTML dla statycznych stron. Możesz zacząć za darmo bez zakładania konta. Darmowy plan: 500 zgłoszeń miesięcznie i możliwość ustawienia własnego adresu reply-to.
* [FormKeep.com](https://www.formkeep.com/) - Nielimitowana liczba formularzy z 50 zgłoszeniami miesięcznie, ochrona przed spamem, powiadomienia e-mail, kreator drag&drop z możliwością eksportu HTML. Dodatkowe funkcje: własne reguły pól, zespoły, integracje z Google Sheets, Slack, ActiveCampaign i Zapier.
* [formlets.com](https://formlets.com/) — Formularze online, nielimitowane formularze jednostronicowe/miesiąc, 100 zgłoszeń/miesiąc, powiadomienia e-mail.
* [formspark.io](https://formspark.io/) - Usługa Form to Email, darmowy plan: nielimitowane formularze, 250 zgłoszeń miesięcznie, wsparcie przez zespół obsługi klienta.
* [Formspree.io](https://formspree.io/) — Wysyłanie e-maila przez HTTP POST. Darmowy poziom: 50 zgłoszeń na formularz miesięcznie.
* [Formsubmit.co](https://formsubmit.co/) — Proste endpointy do twoich formularzy HTML. Darmowe na zawsze. Rejestracja nie jest wymagana.
* [Formlick.com](https://formlick.com) - Alternatywa dla Typeform z dożywotnim dostępem. Użytkownik może utworzyć 1 darmowy formularz i otrzymywać nielimitowane zgłoszenia. W premium: nielimitowane formularze i zgłoszenia.
* [getform.io](https://getform.io/) - Backend formularzy dla projektantów i deweloperów, 1 formularz, 50 zgłoszeń, pojedynczy upload pliku, 100MB przestrzeni na pliki.
* [HeroTofu.com](https://herotofu.com/) - Backend formularzy z detekcją botów i szyfrowanym archiwum. Przekieruj zgłoszenia przez UI na e-mail, Slack lub Zapier. Użyj własnego frontendu. Bez kodu po stronie serwera. Darmowy plan: nielimitowane formularze, 100 zgłoszeń miesięcznie.
* [HeyForm.net](https://heyform.net/) - Kreator formularzy drag&drop. Darmowy poziom: nielimitowane formularze i zgłoszenia. W zestawie gotowe szablony, antyspam, 100MB przestrzeni na pliki.
* [Tally.so](https://tally.so/) - 99% wszystkich funkcji jest darmowych. Darmowy poziom: nielimitowane formularze, nielimitowane zgłoszenia, powiadomienia e-mail, logika formularza, płatności, upload plików, własna strona podziękowania i wiele innych.
* [Hyperforms.app](https://hyperforms.app/) — Twórz formularze na e-mail i więcej w kilka sekund, bez backendu. Konto osobiste: do 50 zgłoszeń miesięcznie za darmo.
* [Kwes.io](https://kwes.io/) - Bogaty w funkcje endpoint do formularzy. Świetnie działa ze statycznymi stronami. Darmowy plan: 1 strona, do 50 zgłoszeń miesięcznie.
* [Pageclip](https://pageclip.co/) - Darmowy plan: jedna strona, jeden formularz, 1000 zgłoszeń miesięcznie.
* [Qualtrics Survey](https://qualtrics.com/free-account) — Twórz profesjonalne formularze i ankiety z użyciem tego narzędzia klasy premium. 50+ szablonów eksperckich. Darmowe konto: 1 aktywna ankieta, 100 odpowiedzi/ankietę, 8 typów odpowiedzi.
* [Screeb](https://screeb.app/) - Ankiety w aplikacji i analityka produktu do dekodowania zachowań użytkowników. Darmowy plan: 500 aktywnych użytkowników miesięcznie, nielimitowane odpowiedzi i zdarzenia, liczne integracje, eksport, okresowe raporty.
* [smartforms.dev](https://smartforms.dev/) - Potężny i prosty backend formularzy do twojej strony, darmowy plan: 50 zgłoszeń miesięcznie, 250MB przestrzeni na pliki, integracja z Zapier, eksport CSV/JSON, własne przekierowanie, własna strona odpowiedzi, bot Telegram & Slack, pojedyncze powiadomienia e-mail.
* [Survicate](https://survicate.com/) — Zbieraj feedback ze wszystkich źródeł i wysyłaj follow-upy jednym narzędziem. Automatyczna analiza feedbacku i wyciąganie wniosków przez AI. Darmowe ankiety e-mail, na stronie, w produkcie lub mobilne, AI survey creator i 25 odpowiedzi miesięcznie.
* [staticforms.xyz](https://www.staticforms.xyz/) - Łatwa integracja formularzy HTML bez kodu po stronie serwera. Po wysłaniu formularza e-mail z treścią trafia na twój zarejestrowany adres.
* [stepFORM.io](https://stepform.io) - Kreator quizów i formularzy. Darmowy plan: 5 formularzy, do 3 kroków na formularz, 50 odpowiedzi miesięcznie.
* [Typeform.com](https://www.typeform.com/) — Piękne formularze na stronach. Darmowy plan: tylko 10 pól na formularz i 100 odpowiedzi miesięcznie.
* [WaiverStevie.com](https://waiverstevie.com) - Platforma do podpisów elektronicznych z REST API. Powiadomienia przez webhooki. Darmowy plan: podpisy z watermarkiem, ale nielimitowane koperty + podpisy.
* [Web3Forms](https://web3forms.com) - Formularze kontaktowe dla statycznych stron i JAMStack bez backendu. Darmowy plan: nielimitowane formularze, nielimitowane domeny i 250 zgłoszeń miesięcznie.
* [WebAsk](https://webask.io) - Kreator ankiet i formularzy. Darmowy plan pozwala na trzy ankiety na konto, 100 odpowiedzi miesięcznie i dziesięć elementów na ankietę.
* [Wufoo](https://www.wufoo.com/) - Szybkie formularze do użycia na stronach internetowych. Darmowy plan ma limit 100 zgłoszeń miesięcznie.
* [formpost.app](https://formpost.app) - Darmowa, nielimitowana usługa Formularz do E-mail. Skonfiguruj własne przekierowania, auto-odpowiedzi, webhooki itp. za darmo.
* [Formester.com](https://formester.com) - Udostępniaj i osadzaj wyjątkowo wyglądające formularze na swojej stronie — bez ograniczeń liczby tworzonych formularzy ani funkcji limitowanych przez plan. Do 100 zgłoszeń miesięcznie za darmo.
* [SimplePDF.eu](https://simplepdf.eu/embed) - Osadź edytor PDF na swojej stronie i zamień każdy PDF w formularz do wypełnienia. Darmowy plan pozwala na nieograniczoną liczbę PDF-ów z trzema zgłoszeniami na PDF.
* [forms.app](https://forms.app/) — Twórz formularze online z zaawansowanymi funkcjami, takimi jak logika warunkowa, automatyczny kalkulator punktów i AI. Zbieraj do 100 odpowiedzi w darmowym planie, osadzaj formularze na stronie lub korzystaj z nich przez link.
* [Qualli](https://usequalli.com) - Ankiety w aplikacji, zaprojektowane na urządzenia mobilne. Skorzystaj z Qualli AI, aby opracować idealne pytania. Wypróbuj w darmowym planie do 500 MAU, twórz nieograniczoną liczbę formularzy i wyzwalaczy.
* [Sprig](https://sprig.com/) - 1 ankieta w produkcie lub ankieta z Replay miesięcznie, z analizą AI opartą na GPT.
* [feedback.fish](https://feedback.fish/) - Darmowy plan pozwala zebrać 25 zgłoszeń opinii. Łatwa integracja dzięki komponentom React i Vue.
* [Vidhook](https://vidhook.io/) - Zbieraj opinie za pomocą przyjemnych ankiet o wysokim współczynniku odpowiedzi. Darmowy plan obejmuje 1 aktywną ankietę, 25 odpowiedzi na ankietę oraz konfigurowalne szablony.

**[⬆️ Wróć na górę](#table-of-contents)**

## Generatywna AI

* [Zenable](https://zenable.io) - Natychmiastowe automatyczne poprawianie wyników narzędzi takich jak Cursor, Windsurf i Copilot, aby spełniały standardy jakości i zgodności firmy dzięki guardrails opartym o Policy as Code. Darmowy poziom obejmuje 100 wywołań narzędzi dziennie do serwera MCP oraz 25 darmowych automatycznych recenzji pull requestów dziennie przez GitHub App.
* [Keywords AI](https://keywordsai.co) - Najlepsza platforma do monitorowania LLM. Jeden format do wywoływania ponad 200 LLM za pomocą 2 linii kodu. 10 000 darmowych żądań miesięcznie i 0$ za funkcje platformy!
* [Portkey](https://portkey.ai/) - Panel kontrolny dla aplikacji Gen AI z zestawem narzędzi do obserwowalności i bramką AI. Wysyłaj i rejestruj do 10 000 żądań miesięcznie za darmo.
* [Braintrust](https://www.braintrustdata.com/) - Evals, plac zabaw promptów i zarządzanie danymi dla Gen AI. Darmowy plan daje do 1000 prywatnych wierszy eval tygodniowo.
* [Findr](https://www.usefindr.com/) - Uniwersalne wyszukiwanie pozwalające przeszukiwać wszystkie aplikacje naraz. Asystent wyszukiwania odpowiadający na pytania na podstawie Twoich danych. Darmowy plan oferuje nielimitowane wyszukiwanie zintegrowane i 5 codziennych zapytań co-pilota.
* [ReportGPT](https://ReportGPT.app) - Asystent pisania wspierany AI. Cała platforma jest darmowa, jeśli przyniesiesz własny klucz API.
* [Clair](https://askclair.ai/) - Kliniczna AI Reference. Studenci mają bezpłatny dostęp do profesjonalnego zestawu narzędzi, który zawiera Open Search, Clinical Summary, Med Review, Interakcje Leków, Kody ICD-10 i Stewardship. Dostępny także darmowy okres próbny dla profesjonalnego zestawu.
* [Langtrace](https://langtrace.ai) - umożliwia deweloperom śledzenie, ocenę, zarządzanie promptami i zestawami danych oraz debugowanie problemów związanych z wydajnością aplikacji LLM. Tworzy ślady zgodne ze standardem open telemetry dla dowolnego LLM, co pomaga z obserwowalnością i współpracuje z dowolnym klientem obserwowalności. Darmowy plan oferuje 50 tys. śladów/miesiąc.
* [LangWatch](https://langwatch.ai) - Platforma LLMOps pomagająca zespołom AI mierzyć, monitorować i optymalizować aplikacje LLM pod kątem niezawodności, efektywności kosztowej i wydajności. Dzięki komponentowi DSPy umożliwiamy płynną współpracę inżynierów z zespołami nietechnicznymi w celu strojenia i wdrażania produktów GenAI. Darmowy plan obejmuje wszystkie funkcje platformy, 1 tys. śladów/miesiąc i 1 workflow DSPy optimizer. [#opensource](https://github.com/langwatch/langwatch)
* [Comet Opik](https://www.comet.com/site/products/opik/) - Oceniaj, testuj i wdrażaj aplikacje LLM w całym cyklu dev i produkcyjnym. [#opensource](https://github.com/comet-ml/opik/)
* [Langfuse](https://langfuse.com/) - Otwarta platforma inżynierii LLM pomagająca zespołom wspólnie debugować, analizować i iterować nad aplikacjami LLM. Darmowy plan na zawsze obejmuje 50 tys. obserwacji miesięcznie i wszystkie funkcje platformy. [#opensource](https://github.com/langfuse/langfuse)
* [Pollinations.AI](https://pollinations.ai/) - łatwy w użyciu, darmowy AI do generowania obrazów z darmowym API. Bez rejestracji i kluczy API, kilka opcji integracji ze stroną lub workflow. [#opensource](https://github.com/pollinations/pollinations)
* [Othor AI](https://othor.ai/) - AI-native, szybka, prosta i bezpieczna alternatywa dla popularnych rozwiązań Business Intelligence jak Tableau, Power BI czy Looker. Othor wykorzystuje duże modele językowe (LLM), aby dostarczyć niestandardowe rozwiązania BI w kilka minut. Plan Free Forever zapewnia jedno środowisko pracy, pięć połączeń z bazami danych dla jednego użytkownika, bez limitu analiz. [#opensource](https://github.com/othorai/othor.ai)
* [OpenRouter](https://openrouter.ai/models?q=free) - Udostępnia różne darmowe modele AI, w tym DeepSeek R1, V3, Llama i Moonshot AI. Modele te są doskonałe w przetwarzaniu języka naturalnego i nadają się do różnych potrzeb developerskich. Należy pamiętać, że korzystanie z nich jest darmowe, ale podlega limitom. OpenRouter oferuje także płatne modele dla bardziej zaawansowanych wymagań, m.in. Claude, OpenAI, Grok, Gemini i Nova.

**[⬆️ Wróć na górę](#table-of-contents)**

## CDN i ochrona

* [bootstrapcdn.com](https://www.bootstrapcdn.com/) — CDN dla bootstrap, bootswatch i fontawesome.io
* [cdnjs.com](https://cdnjs.com/) — Prosty. Szybki. Niezawodny. Dostarczanie treści na najwyższym poziomie. cdnjs to darmowa i otwartoźródłowa usługa CDN, zaufana przez ponad 11% wszystkich stron, zasilana przez Cloudflare.
* [developers.google.com](https://developers.google.com/speed/libraries/) — Google Hosted Libraries to sieć dystrybucji treści dla najpopularniejszych bibliotek Open Source JavaScript
* [Stellate](https://stellate.co/) - Stellate to bardzo szybki i niezawodny CDN dla Twojego API GraphQL, darmowy dla dwóch usług.
* [jsdelivr.com](https://www.jsdelivr.com/) — Darmowy, szybki i niezawodny otwartoźródłowy CDN. Obsługuje npm, GitHub, WordPress, Deno i więcej.
* [Microsoft Ajax](https://docs.microsoft.com/en-us/aspnet/ajax/cdn/overview) — Microsoft Ajax CDN hostuje popularne biblioteki JavaScript, takie jak jQuery, i pozwala łatwo dodać je do aplikacji internetowej
* [ovh.ie](https://www.ovh.ie/ssl-gateway/) — Darmowa ochrona DDoS i certyfikat SSL
* [Skypack](https://www.skypack.dev/) — 100% natywny CDN JavaScript ES Module. Darmowy do 1 miliona żądań na domenę miesięcznie.
* [raw.githack.com](https://raw.githack.com/) — Nowoczesny zamiennik **rawgit.com**, po prostu hostuje plik przy użyciu Cloudflare
* [section.io](https://www.section.io/) — Prosty sposób na uruchomienie i zarządzanie kompletnym rozwiązaniem Varnish Cache. Podobno darmowy na zawsze dla jednej strony
* [statically.io](https://statically.io/) — CDN dla repozytoriów Git (GitHub, GitLab, Bitbucket), zasobów związanych z WordPress i obrazów
* [toranproxy.com](https://toranproxy.com/) — Proxy dla Packagist i GitHub. Nigdy nie zawodzący CD. Darmowe do użytku osobistego, jeden deweloper, bez wsparcia
* [UNPKG](https://unpkg.com/) — CDN dla wszystkiego z npm
* [weserv](https://images.weserv.nl/) — Cache i usługa zmiany rozmiaru obrazów. Przetwarzaj obrazy w locie z globalnym cache.
* [Namecheap Supersonic](https://www.namecheap.com/supersonic-cdn/#free-plan) — Darmowa ochrona DDoS
* [Gcore](https://gcorelabs.com/) Globalna sieć CDN, 1 TB i 1 milion żądań miesięcznie za darmo oraz darmowy hosting DNS
* [CacheFly](https://portal.cachefly.com/signup/free2023) - Do 5 TB miesięcznie darmowego ruchu CDN, 19 głównych PoP, 1 domena i uniwersalny SSL.

**[⬆️ Wróć na górę](#table-of-contents)**

## PaaS

* [anvil.works](https://anvil.works) - Tworzenie aplikacji webowych tylko w Pythonie. Darmowy poziom z nielimitowaną liczbą aplikacji i limitem czasowym 30 sekund.
* [appwrite](https://appwrite.io) - Nielimitowane projekty bez ich usypiania (obsługuje websockets) i usługa uwierzytelniania. 1 baza danych, 3 bucket-y, 5 funkcji na projekt w darmowym planie.
* [configure.it](https://www.configure.it/) — Platforma do tworzenia aplikacji mobilnych, darmowa dla dwóch projektów, ograniczone funkcje, ale brak limitu zasobów
* [codenameone.com](https://www.codenameone.com/) — Otwarty, wieloplatformowy toolchain do tworzenia aplikacji mobilnych dla programistów Java/Kotlin. Darmowe do użytku komercyjnego, bez limitu liczby projektów
* [deco.cx](https://www.deco.cx/en/dev) - Edge-native platforma frontendowa z wizualnym CMS generowanym automatycznie z kodu TypeScript. Wbudowane testy A/B, segmentacja treści i analityka w czasie rzeczywistym. Idealna do stron e-commerce i bogatych w treści. Do 5 tys. wyświetleń/miesiąc lub projekty open-source/osobiste za darmo.
* [Deno Deploy](https://deno.com/deploy) - Rozproszony system uruchamiający JavaScript, TypeScript i WebAssembly na całym świecie. Darmowy poziom obejmuje 100 000 żądań dziennie i 100 GiB transferu miesięcznie.
* [domcloud.co](https://domcloud.co) – Usługa hostingu Linuksa z CI/CD z GitHub, SSH oraz bazą danych MariaDB/Postgres. Wersja darmowa oferuje 1 GB miejsca i 1 GB transferu miesięcznie oraz ogranicza się do darmowej domeny.
* [encore.dev](https://encore.dev/) — Backendowy framework używający analizy statycznej do automatycznego zapewniania infrastruktury, kodu bez boilerplate i więcej. Zawiera darmowy hosting w chmurze dla projektów hobbystycznych.
* [flightcontrol.dev](https://flightcontrol.dev/) - Wdrażaj usługi webowe, bazy danych i więcej na własnym koncie AWS z workflow w stylu Git push. Darmowy poziom dla 1 dewelopera na prywatnych repozytoriach GitHub. Koszty AWS rozliczane przez AWS, można użyć kredytów i darmowego poziomu AWS.
* [gigalixir.com](https://gigalixir.com/) - Gigalixir oferuje jedną darmową instancję, która nigdy nie zasypia, oraz darmową bazę PostgreSQL ograniczoną do 2 połączeń, 10 000 wierszy i bez backupów dla aplikacji Elixir/Phoenix.
* [Glitch](https://glitch.com/) — Darmowy publiczny hosting z udostępnianiem kodu i współpracą w czasie rzeczywistym. Darmowy plan ma limit 1000 godzin/miesiąc.
* [leapcell](https://leapcell.io/) - Leapcell to niezawodna platforma do aplikacji rozproszonych, zapewniająca wszystko, czego potrzebujesz, by wspierać szybki rozwój. Darmowy plan obejmuje 100 tys. wywołań usług, 10 tys. zadań asynchronicznych i 100 tys. komend Redis.
* [pipedream.com](https://pipedream.com) - Platforma integracyjna dla deweloperów. Twórz dowolne workflow na dowolnym triggerze. Workflows to kod, który można uruchomić [za darmo](https://docs.pipedream.com/pricing/). Brak serwera czy chmury do zarządzania.
* [pythonanywhere.com](https://www.pythonanywhere.com/) — Hosting aplikacji Python w chmurze. Konto początkującego za darmo, 1 aplikacja webowa na domenie your-username.pythonanywhere.com, 512 MB prywatnego miejsca na pliki, jedna baza MySQL
* [ampt.dev](https://getampt.com/) - Ampt pozwala zespołom budować, wdrażać i skalować aplikacje JavaScript na AWS bez skomplikowanych konfiguracji czy zarządzania infrastrukturą. Darmowy plan Preview obejmuje 500 wywołań na godzinę, 2500 dziennie i 50 000 miesięcznie. Własne domeny tylko w płatnych planach.
* [Koyeb](https://www.koyeb.com) - Przyjazna platforma serverless do wdrażania aplikacji globalnie. Uruchamiaj kontenery Docker, aplikacje webowe i API z wdrażaniem przez git, autoskalowaniem, globalną siecią edge oraz wbudowaną siatką i wykrywaniem usług. Darmowa instancja pozwala wdrożyć usługę w Frankfurcie (Niemcy) lub Waszyngtonie D.C. (USA). Darmowa zarządzana baza Postgres dostępna we Frankfurcie (DE), Waszyngtonie D.C. (US) i Singapurze. 512MB RAM, 2GB miejsca, 0.1 CPU.
* [Napkin](https://www.napkin.io/) - FaaS z 500Mb RAM, domyślnym timeoutem 15s i 5000 darmowych wywołań API/miesiąc ograniczonych do 5 wywołań/sekundę.
* [Meteor Cloud](https://www.meteor.com/cloud) — Hosting Galaxy. Platforma Meteor PaaS dla aplikacji Meteor z darmowym hostingiem MongoDB Shared i automatycznym SSL.
* [Northflank](https://northflank.com) — Buduj i wdrażaj mikroserwisy, zadania i zarządzane bazy danych przez UI, API i CLI. Skaluj kontenery z kontroli wersji i zewnętrznych rejestrów Docker. Darmowy poziom obejmuje dwie usługi, dwa zadania cron i jedną bazę danych.
* [YepCode](https://yepcode.io) - Platforma all-in-one do łączenia API i usług w środowisku serverless. Łączy zalety NoCode i pełną moc języków programowania. Darmowy plan obejmuje [1000 yepów](https://yepcode.io/pricing/).
* [WunderGraph](https://cloud.wundergraph.com) - Otwarta platforma do szybkiego budowania, wdrażania i zarządzania nowoczesnymi API. Wbudowany CI/CD, integracja z GitHub i automatyczny HTTPS. Do 3 projektów, 1GB egress, 300 minut budowania miesięcznie w [darmowym planie](https://wundergraph.com/pricing)
* [Zeabur](https://zeabur.com) - Wdrażaj usługi jednym kliknięciem. Darmowy dla trzech usług, z 5$ darmowych kredytów miesięcznie.
* [mogenius](https://mogenius.com) - Łatwe budowanie, wdrażanie i uruchamianie usług na Kubernetes. Darmowy poziom wspiera podłączenie lokalnego Kubernetesa do mogenius, umożliwiając indywidualnym deweloperom stworzenie środowiska testowego jak produkcyjne na swoim komputerze.
* [genezio](https://genezio.com/) - Dostawca funkcji serverless oferuje 1 milion wywołań funkcji, 100GB transferu i 10 zadań cron miesięcznie za darmo, wyłącznie do użytku niekomercyjnego lub akademickiego.

**[⬆️ Wróć na górę](#table-of-contents)**

## BaaS

* [Activepieces](https://www.activepieces.com) - Buduj automatyzacje łączące różne aplikacje w backendzie twojej aplikacji. Na przykład, wysyłaj wiadomość Slack lub dodaj wiersz w Google Sheet, gdy w twojej aplikacji zajdzie zdarzenie. Darmowe do 5000 zadań miesięcznie.
* [back4app.com](https://www.back4app.com) - Back4App to prosty w użyciu, elastyczny i skalowalny backend oparty na platformie Parse.
* [backendless.com](https://backendless.com/) — Mobilny i webowy BaaS, 1 GB miejsca na pliki za darmo, 50 000 powiadomień push/miesiąc i 1000 obiektów danych w tabeli.
* [bismuth.cloud](https://www.bismuth.cloud/) — Nasza AI zbuduje i uruchomi Twój Python API na naszym środowisku funkcyjnym i hostowanym storage, zbuduj i hostuj za darmo w naszym edytorze online lub lokalnie z ulubionymi narzędziami.
* [BMC Developer Program](https://developers.bmc.com/site/global/bmc_helix_platform/program/overview/index.gsp) — Program deweloperski BMC zapewnia dokumentację i zasoby do budowy i wdrażania cyfrowych innowacji dla twojego przedsiębiorstwa. Dostęp do kompleksowego, osobistego sandboxa z platformą, SDK i biblioteką komponentów do budowy i dostosowywania aplikacji.
* [connectycube.com](https://connectycube.com) - Nielimitowane wiadomości na czacie, p2p voice i video calls, załączniki plików i powiadomienia push. Za darmo dla aplikacji do 1000 użytkowników.
* [convex.dev](https://convex.dev/) - Reaktywny backend jako usługa, hostujący twoje dane (dokumenty z relacjami i serializowalnymi transakcjami ACID), funkcje serverless i WebSockety do streamowania aktualizacji do różnych klientów. Darmowy dla małych projektów — do 1 mln rekordów, 5 mln miesięcznych wywołań funkcji.
* [darklang.com](https://darklang.com/) - Hostowany język z edytorem i infrastrukturą. Dostępne w becie, po becie planowany jest hojny darmowy poziom.
* [Firebase](https://firebase.com) — Pomaga budować i uruchamiać udane aplikacje. Darmowy plan Spark oferuje Authentication, Hosting, Firebase ML, Realtime Database, Cloud Storage, Testlab. A/B Testing, Analytics, App Distribution, App Indexing, Cloud Messaging (FCM), Crashlytics, Dynamic Links, In-App Messaging, Performance Monitoring, Predictions i Remote Config są zawsze darmowe.
* [Flutter Flow](https://flutterflow.io) — Buduj UI aplikacji Flutter bez pisania kodu. Integracja z Firebase. Darmowy plan obejmuje pełen dostęp do kreatora UI i darmowych szablonów.
* [getstream.io](https://getstream.io/) — Buduj skalowalny czat w aplikacji, wiadomości, wideo i audio oraz feedy w kilka godzin zamiast tygodni
* [hasura.io](https://hasura.io/) — Hasura rozbudowuje istniejące bazy danych, gdziekolwiek są hostowane i zapewnia natychmiastowe API GraphQL dostępne bezpiecznie dla aplikacji web, mobilnych i integracyjnych. Darmowe do 1GB/miesiąc przesyłanych danych.
* [nhost.io](https://nhost.io) - Serverless backend dla aplikacji webowych i mobilnych. Darmowy plan obejmuje PostgreSQL, GraphQL (Hasura), uwierzytelnianie, storage i funkcje serverless.
* [onesignal.com](https://onesignal.com/) — Nielimitowane darmowe powiadomienia push. 10 000 wysyłek email miesięcznie, nielimitowane kontakty i dostęp do Auto Warm Up.
* [paraio.com](https://paraio.com) — API backendowe z elastycznym uwierzytelnianiem, pełnotekstowym wyszukiwaniem i cache. Darmowe dla jednej aplikacji, 1GB danych aplikacji.
* [pubnub.com](https://www.pubnub.com/) — Darmowe powiadomienia push do 1 miliona wiadomości/miesiąc i 100 aktywnych urządzeń dziennie
* [pushbots.com](https://pushbots.com/) — Usługa powiadomień push. Za darmo do 1,5 miliona powiadomień/miesiąc
* [pushcrew.com](https://pushcrew.com/) — Usługa powiadomień push. Nielimitowane powiadomienia dla maksymalnie 2000 subskrybentów
* [pusher.com](https://pusher.com/beams) — Darmowe, nielimitowane powiadomienia push dla 2000 aktywnych użytkowników miesięcznie. Jedno API dla urządzeń iOS i Android.
* [quickblox.com](https://quickblox.com/) — Backend komunikacyjny dla wiadomości natychmiastowych, wideo, rozmów głosowych i powiadomień push
* [restspace.io](https://restspace.io/) - Skonfiguruj serwer z usługami takimi jak autoryzacja, dane, pliki, API e-mail, szablony i inne, a następnie łącz je w potoki i przekształcaj dane.
* [Salesforce Developer Program](https://developer.salesforce.com/signup) — Twórz aplikacje błyskawicznie dzięki narzędziom typu "przeciągnij i upuść". Dostosuj swój model danych kliknięciami. Rozszerzaj możliwości za pomocą kodu Apex. Integruj wszystko dzięki potężnym API. Pozostań chroniony dzięki bezpieczeństwu klasy korporacyjnej. Dostosuj UI kliknięciami lub dowolnym nowoczesnym frameworkiem webowym. Darmowy Program Developerski umożliwia dostęp do pełnej platformy Lightning.
* [simperium.com](https://simperium.com/) — Natychmiastowe i automatyczne przesyłanie danych na różne platformy, nielimitowane wysyłanie i przechowywanie danych strukturalnych, maks. 2500 użytkowników/miesiąc
* [Supabase](https://supabase.com) — Otwarta alternatywa dla Firebase do budowania backendów. Darmowy plan obejmuje autoryzację, bazę danych w czasie rzeczywistym oraz przechowywanie obiektów.
* [tyk.io](https://tyk.io/) — Zarządzanie API z autoryzacją, limitami, monitoringiem i analizą. Darmowa oferta w chmurze
* [zapier.com](https://zapier.com/) — Łącz aplikacje, których używasz, aby automatyzować zadania. Pięć zapsów co 15 minut i 100 zadań/miesiąc
* [IFTTT](https://ifttt.com) — Automatyzuj swoje ulubione aplikacje i urządzenia. 2 darmowe applet'y
* [Integrately](https://integrately.com) — Automatyzuj żmudne zadania jednym kliknięciem. 100 darmowych zadań, czas odświeżania 15 minut, pięć aktywnych automatyzacji, webhooki.
* [LeanCloud](https://leancloud.app/) — Backend mobilny. 1 GB przestrzeni danych, 256 MB instancji, 3K zapytań API/dzień i 10K powiadomień push/dzień za darmo. (API bardzo podobne do Parse Platform)
* [Claw.cloud](https://run.claw.cloud) - Platforma PaaS oferująca $5/miesiąc darmowego kredytu dla użytkowników z kontem GitHub starszym niż 180 dni. Idealna do hostowania aplikacji, baz danych i innych. ([Link do rejestracji z darmowym kredytem](https://ap-southeast-1.run.claw.cloud/signin)).


**[⬆️ Powrót na górę](#table-of-contents)**

## Platformy low-code

* [appsmith](https://www.appsmith.com/) — Projekt low-code do budowy paneli administracyjnych, narzędzi wewnętrznych i dashboardów. Integruje się z ponad 15 bazami danych i dowolnym API.
* [Basedash](https://www.basedash.com) — Platforma low-code do budowy wewnętrznych paneli administracyjnych i dashboardów. Obsługuje bazy SQL i REST API.
* [BudiBase](https://budibase.com/) — Budibase to open source'owa platforma low-code do tworzenia aplikacji wewnętrznych w kilka minut. Obsługuje PostgreSQL, MySQL, MSSQL, MongoDB, Rest API, Docker, K8s
* [Clappia](https://www.clappia.com) — Platforma low-code zaprojektowana do budowania aplikacji biznesowych z konfigurowalnymi aplikacjami mobilnymi i webowymi. Oferuje interfejs drag-and-drop, funkcje takie jak wsparcie offline, śledzenie lokalizacji w czasie rzeczywistym oraz integrację z różnymi usługami firm trzecich
* [DronaHQ](https://www.dronahq.com/) — DronaHQ - platforma low-code, która pomaga zespołom inżynieryjnym i managerom produktu budować narzędzia wewnętrzne, niestandardowe ścieżki użytkownika, doświadczenia cyfrowe, automatyzacje, niestandardowe panele administracyjne oraz aplikacje operacyjne 10x szybciej.
* [lil'bots](https://www.lilbots.io/) - pisz i uruchamiaj skrypty online wykorzystując darmowe, wbudowane API takie jak OpenAI, Anthropic, Firecrawl i inne. Świetne do budowy agentów AI / narzędzi wewnętrznych i dzielenia się z zespołem. Darmowa wersja obejmuje pełny dostęp do API, AI coding assistant i 10 000 kredytów na wykonania miesięcznie.
* [Mendix](https://www.mendix.com/) — Szybkie tworzenie aplikacji dla przedsiębiorstw, nielimitowane środowiska testowe z obsługą wszystkich użytkowników, 0,5 GB pamięci i 1 GB RAM na aplikację. IDE Studio i Studio Pro są dostępne w darmowej wersji.
* [outsystems.com](https://www.outsystems.com/) — Korporacyjny PaaS do tworzenia aplikacji webowych na miejscu lub w chmurze, darmowa „osobista przestrzeń” pozwala na nieograniczoną ilość kodu i do 1 GB bazy danych
* [ReTool](https://retool.com/) — Platforma low-code do budowy aplikacji wewnętrznych. Retool jest mocno konfigurowalny. Jeśli potrafisz napisać coś w JavaScript i API, zrobisz to w Retool. Darmowa wersja pozwala na pięciu użytkowników miesięcznie, nielimitowane aplikacje i połączenia API.
* [Superblocks](https://superblocks.com/) — Otwarta platforma aplikacyjna dla przedsiębiorstw, przeznaczona dla deweloperów i zespołów półtechnicznych. Użyj AI do generowania, wizualnej edycji i rozszerzania kodem. Centralne zarządzanie integracjami, autoryzacją, uprawnieniami i logami audytowymi.
* [ToolJet](https://www.tooljet.com/) — Rozszerzalny framework low-code do budowy aplikacji biznesowych. Połącz się z bazami danych, chmurą, GraphQL, API, Airtable itp. i buduj aplikacje za pomocą kreatora drag-and-drop.
* [UI Bakery](https://uibakery.io) — Platforma low-code umożliwiająca szybkie budowanie niestandardowych aplikacji webowych. Umożliwia budowę UI metodą drag-and-drop z dużą możliwością personalizacji przez JavaScript, Python i SQL. Dostępna w chmurze i jako rozwiązanie self-hosted. Za darmo do 5 użytkowników.
* [manubes](https://www.manubes.com) - Potężna platforma no-code w chmurze skupiona na zarządzaniu produkcją przemysłową. Za darmo dla jednego użytkownika z 1 milionem aktywności workflow miesięcznie ([dostępna także po niemiecku](https://www.manubes.de)).

**[⬆️ Powrót na górę](#table-of-contents)**

## Hosting WWW

* [Alwaysdata](https://www.alwaysdata.com/) — 100 MB darmowego hostingu WWW z obsługą MySQL, PostgreSQL, CouchDB, MongoDB, PHP, Python, Ruby, Node.js, Elixir, Java, Deno, własne serwery WWW, dostęp przez FTP, WebDAV i SSH; skrzynka pocztowa, lista mailingowa i instalator aplikacji w zestawie.
* [Awardspace.com](https://www.awardspace.com) — Darmowy hosting WWW + darmowa krótka domena, PHP, MySQL, instalator aplikacji, wysyłka e-maili i brak reklam.
* [Bohr](https://bohr.io) — Za darmo dla projektów niekomercyjnych + platforma wdrożeniowa i deweloperska z podejściem "developer-first", minimalizująca kłopoty z infrastrukturą i przyspieszająca wdrożenia.
* [Bubble](https://bubble.io/) — Programowanie wizualne do tworzenia aplikacji webowych i mobilnych bez kodu, za darmo z brandingiem Bubble.
* [dAppling Network](https://www.dappling.network/) - Zdecentralizowana platforma hostingu WWW dla frontendów Web3, skupiająca się na zwiększeniu dostępności, bezpieczeństwa i zapewniająca dodatkowy punkt dostępu dla użytkowników.
* [DigitalOcean](https://www.digitalocean.com/pricing) - Buduj i wdrażaj trzy strony statyczne za darmo na poziomie App Platform Starter.
* [Drive To Web](https://drv.tw) — Hosting bezpośrednio z Google Drive i OneDrive. Tylko strony statyczne. Na zawsze za darmo. Jedna strona na konto Google/Microsoft.
* [Fenix Web Server](https://preview.fenixwebserver.com) - Aplikacja desktopowa dla deweloperów do lokalnego hostowania stron i udostępniania ich publicznie (w czasie rzeczywistym). Pracuj, jak chcesz, używając interfejsu, API i/lub CLI.
* [Fern](https://buildwithfern.com) - Buduj i hostuj stronę dokumentacyjną opartą o Markdown w darmowym planie Fern. Możesz nawet automatycznie wygenerować referencje API dla swojej strony z plików definicji API. Strona hostowana pod _yoursite_.docs.buildwithfern.com.
* [Free Hosting](https://freehostingnoads.net/) — Darmowy hosting z PHP 5, Perl, CGI, MySQL, FTP, menedżerem plików, pocztą POP, darmowymi subdomenami, hostingiem domen, edytorem stref DNS, statystykami strony, darmowym wsparciem online i wieloma innymi funkcjami niedostępnymi u innych darmowych hosterów.
* [Freehostia](https://www.freehostia.com) — FreeHostia oferuje darmowe usługi hostingowe, w tym panel sterowania klasy przemysłowej i instalator 1-click ponad 50 darmowych aplikacji. Natychmiastowa konfiguracja. Brak wymuszonych reklam.
* [HelioHost](https://heliohost.org) — Non-profitowy, darmowy hosting WWW z panelem Plesk, PHP, Node.js, Python, Django, Flask, .NET, Perl, CGI, MySQL, PostgreSQL, SQLite, pocztą IMAP/POP3/SMTP, nielimitowanym transferem, darmowymi subdomenami, 1000 MB przestrzeni za darmo z opcją rozszerzenia.
* [Kinsta Static Site Hosting](https://kinsta.com/static-site-hosting/) — Wdrażaj do 100 statycznych stron za darmo, własne domeny z SSL, 100 GB transferu miesięcznie, 260+ lokalizacji CDN Cloudflare.
* [Lecturify](https://www.lecturify.net/index.en.html) - Hosting WWW z dostępem SFPT do przesyłania i pobierania plików, dostępne PHP.
* [Neocities](https://neocities.org) — Statyczny hosting, 1 GB darmowej przestrzeni, 200 GB transferu.
* [Netlify](https://www.netlify.com/) — Buduje, wdraża i hostuje statyczne strony/aplikacje za darmo do 100 GB danych i 100 GB/miesiąc transferu.
* [pantheon.io](https://pantheon.io/) — Hosting Drupal i WordPress, automatyczny DevOps i skalowalna infrastruktura. Darmowe dla deweloperów i agencji. Brak własnej domeny.
* [readthedocs.org](https://readthedocs.org/) — Darmowy hosting dokumentacji z wersjonowaniem, generowaniem PDF i innymi funkcjami
* [render.com](https://render.com) — Zunifikowana chmura do budowy i uruchamiania aplikacji i stron z darmowym SSL, globalnym CDN, prywatnymi sieciami, automatycznym wdrażaniem z Gita oraz kompletnie darmowymi planami dla usług webowych, baz danych i statycznych stron WWW.
* [SourceForge](https://sourceforge.net/) — Wyszukuj, twórz i publikuj darmowe oprogramowanie open source
* [surge.sh](https://surge.sh/) — Publikowanie statycznych stron dla frontendowców. Nielimitowane strony z obsługą własnych domen
* [telegra.ph](https://telegra.ph/) Łatwe tworzenie stron WWW przy użyciu Quill
* [tilda.cc](https://tilda.cc/) — Jedna strona, 50 podstron, 50 MB przestrzeni, tylko główne predefiniowane bloki z ponad 170, brak czcionek, favicony i własnej domeny
* [Vercel](https://vercel.com/) — Buduj, wdrażaj i hostuj aplikacje webowe z darmowym SSL, globalnym CDN i unikalnymi URL podglądu przy każdym `git push`. Idealne dla Next.js i innych generatorów statycznych stron.
* [Versoly](https://versoly.com/) — Kreator stron SaaS - nielimitowane strony, 70+ bloków, pięć szablonów, własny CSS, favicon, SEO i formularze. Brak własnej domeny.
* [Qoddi](https://qoddi.com) - Usługa PaaS podobna do Heroku z podejściem przyjaznym deweloperom i kompletnymi funkcjami. Darmowy poziom dla zasobów statycznych, środowisk testowych i aplikacji deweloperskich.
* [FreeFlarum](https://freeflarum.com/) - Społecznościowy, darmowy hosting Flarum dla maks. 250 użytkowników (wpłata usuwa znak wodny z stopki).
* [MDB GO](https://mdbgo.com/) - Darmowy hosting dla jednego projektu z dwutygodniowym TTL kontenera, 500 MB RAM na projekt, SFTP - 1 GB miejsca na dysku.
* [Patr Cloud](https://patr.cloud/) — Łatwa w obsłudze platforma chmurowa, wśród płatnych usług oferuje możliwość hostowania trzech statycznych stron za darmo.
* [Serv00.com](https://serv00.com/) — 3 GB darmowego hostingu WWW z codziennymi backupami (7 dni). Wsparcie: zadania crontab, dostęp SSH, repozytoria (GIT, SVN i Mercurial), wsparcie: MySQL, PostgreSQL, MongoDB, PHP, Node.js, Python, Ruby, Java, Perl, TCL/TK, Lua, Erlang, Rust, Pascal, C, C++, D, R i wiele innych.
- [Sevalla](https://sevalla.com/) - Platforma hostingowa upraszczająca wdrażanie i zarządzanie aplikacjami, bazami danych i stronami statycznymi - limit 1 GB na stronę, 100 GB darmowego transferu, 600 darmowych minut buildów, 100 stron na konto.

**[⬆️ Powrót na górę](#table-of-contents)**

## DNS

* [1.1.1.1](https://developers.cloudflare.com/1.1.1.1/) - Darmowy publiczny resolver DNS, szybki i bezpieczny (szyfruje zapytania DNS), dostarczany przez Cloudflare. Przydatny do omijania blokad DNS dostawcy, zapobiegania podglądaniu zapytań DNS i [blokowania treści dla dorosłych oraz malware](https://developers.cloudflare.com/1.1.1.1/1.1.1.1-for-families). Może być także używany [przez API](https://developers.cloudflare.com/1.1.1.1/encrypted-dns/dns-over-https/make-api-requests). Uwaga: tylko resolver DNS, nie hosting DNS.
* [1984.is](https://www.1984.is/product/freedns/) — Darmowa usługa DNS z API i wieloma innymi darmowymi funkcjami.
* [cloudns.net](https://www.cloudns.net/) — Darmowy hosting DNS dla 1 domeny z 50 rekordami
* [deSEC](https://desec.io) - Darmowy hosting DNS z obsługą API, zaprojektowany z myślą o bezpieczeństwie. Działa na open source i jest wspierany przez [SSE](https://www.securesystems.de/).
* [dns.he.net](https://dns.he.net/) — Darmowy hosting DNS z obsługą dynamicznego DNS
* [Zonomi](https://zonomi.com/) — Darmowy hosting DNS z natychmiastową propagacją DNS. Darmowy plan: 1 strefa DNS (nazwa domeny) do 10 rekordów DNS.
* [dnspod.com](https://www.dnspod.com/) — Darmowy hosting DNS.
* [duckdns.org](https://www.duckdns.org/) — Darmowy DDNS do 5 domen w darmowej wersji. Z przewodnikami konfiguracyjnymi dla różnych środowisk.
* [Dynv6.com](https://dynv6.com/) — Darmowy DDNS z [obsługą API](https://dynv6.com/docs/apis) i zarządzaniem wieloma typami rekordów DNS (CNAME, MX, SPF, SRV, TXT i inne).
* [freedns.afraid.org](https://freedns.afraid.org/) — Darmowy hosting DNS. Oferuje także darmowe subdomeny na bazie wielu publicznych, [udostępnionych domen](https://freedns.afraid.org/domain/registry/) użytkowników. Po rejestracji darmowe subdomeny dostępne w menu "Subdomains".
* [luadns.com](https://www.luadns.com/) — Darmowy hosting DNS, trzy domeny, wszystkie funkcje w rozsądnych limitach
* [namecheap.com](https://www.namecheap.com/domains/freedns/) — Darmowy DNS. Bez limitu domen
* [nextdns.io](https://nextdns.io) - Firewall oparty o DNS, 300K darmowych zapytań miesięcznie
* [noip.at](https://noip.at/) — Darmowy DDNS bez rejestracji, śledzenia, logowania i reklam. Bez limitu domen.
* [noip](https://www.noip.com/) — Dynamiczny DNS umożliwiający do 3 hostnamów za darmo (potwierdzenie co 30 dni)
* [sslip.io](https://sslip.io/) — Darmowa usługa DNS, która zwraca adres IP, jeśli zapytasz o nazwę hosta z zakodowanym adresem IP.
* [zilore.com](https://zilore.com/en/dns) — Darmowy hosting DNS dla 5 domen.
* [zoneedit.com](https://www.zoneedit.com/free-dns/) — Darmowy hosting DNS z obsługą dynamicznego DNS.
* [zonewatcher.com](https://zonewatcher.com) — Automatyczne kopie zapasowe i monitoring zmian DNS. Jedna domena za darmo
* [huaweicloud.com](https://www.huaweicloud.com/intl/en-us/product/dns.html) – Darmowy hosting DNS od Huawei
* [Hetzner](https://www.hetzner.com/dns-console) – Darmowy hosting DNS od Hetzner z obsługą API.
* [Glauca](https://docs.glauca.digital/hexdns/) – Darmowy hosting DNS dla maks. 3 domen oraz wsparcie DNSSEC
* [VolaryDDNS](https://volaryddns.net) - Darmowy, wydajny DDNS bez subskrypcji i reklam
**[⬆️ Powrót na górę](#table-of-contents)**

## Domeny

  * [pp.ua](https://nic.ua/) — Darmowe subdomeny pp.ua.
  * [us.kg](https://nic.us.kg/) - Darmowe subdomeny us.kg.

**[⬆️ Powrót na górę](#table-of-contents)**

## IaaS

  * [4EVERLAND](https://www.4everland.org/) — Kompatybilny z AWS S3 - API, operacje interfejsu, CLI oraz inne metody przesyłania, przesyłaj i przechowuj pliki z sieci IPFS i Arweave w sposób bezpieczny, wygodny i wydajny. Zarejestrowani użytkownicy otrzymują 6 GB przestrzeni IPFS i 300 MB przestrzeni Arweave za darmo. Każdy plik przesłany do Arweave o rozmiarze poniżej 150 KB jest darmowy.
  * [backblaze.com](https://www.backblaze.com/b2/) — Backblaze B2 cloud storage. Darmowe 10 GB (podobne do Amazon S3) obiektowej przestrzeni dyskowej na nieograniczony czas
  * [filebase.com](https://filebase.com/) - S3 kompatybilne przechowywanie obiektów napędzane blockchainem. 5 GB darmowej przestrzeni na nieograniczony czas.
  * [Tebi](https://tebi.io/) - S3 kompatybilne przechowywanie obiektów. Darmowe 25 GB przestrzeni oraz 250 GB transferu wychodzącego.
  * [Idrive e2](https://www.idrive.com/e2/) - S3 kompatybilne przechowywanie obiektów. 10 GB darmowej przestrzeni i 10 GB pasma pobierania miesięcznie.
  * [C2 Object Storage](https://c2.synology.com/en-us/pricing/object-storage) - S3 kompatybilne przechowywanie obiektów. 15 GB darmowej przestrzeni i 15 GB pobrań miesięcznie.

**[⬆️ Powrót na górę](#table-of-contents)**

## Zarządzane Usługi Danych

  * [Aiven](https://aiven.io/) - Aiven oferuje darmowe plany PostgreSQL, MySQL i Redis na swojej platformie open-source. Jeden węzeł, 1 CPU, 1 GB RAM, a dla PostgreSQL i MySQL 5 GB przestrzeni. Łatwa migracja do większych planów lub między chmurami.
  * [airtable.com](https://airtable.com/) — Wygląda jak arkusz kalkulacyjny, ale to relacyjna baza danych; nieograniczona liczba baz, 1200 wierszy/baza i 1000 zapytań API/miesiąc
  * [Astra](https://www.datastax.com/products/datastax-astra/) — Cloud Native Cassandra jako Usługa z [80GB darmowego poziomu](https://www.datastax.com/products/datastax-astra/pricing)
  * [codehooks.io](https://codehooks.io/) — Prosty w użyciu serwerless API/backend w JavaScript oraz usługa bazy NoSQL z funkcjami, zapytaniami podobnymi do MongoDB, wyszukiwaniem klucz/wartość, systemem zadań, wiadomościami w czasie rzeczywistym, kolejkami pracowników, potężnym CLI i menedżerem danych przez WWW. Darmowy plan obejmuje 5 GB przestrzeni i 60 wywołań API na minutę. 2 deweloperów w cenie. Bez karty kredytowej.
  * [CrateDB](https://crate.io/) - Rozproszona otwartoźródłowa baza SQL do analityki w czasie rzeczywistym. [Darmowy poziom CRFREE](https://crate.io/lp-crfree): Jeden węzeł z 2 CPU, 2 GiB pamięci, 8 GiB przestrzeni. Jeden klaster na organizację, bez konieczności płatności.
  * [Upstash](https://upstash.com/) — Serverless Redis z darmowym poziomem do 10 000 żądań dziennie, 256 MB maksymalnego rozmiaru bazy i 20 jednoczesnych połączeń
  * [Couchbase Capella](https://www.couchbase.com/products/capella/) - uruchom w pełni zarządzany klaster bazy danych w darmowym poziomie na zawsze, stworzony dla deweloperów do budowania nowej generacji aplikacji od IoT po AI
  * [MongoDB Atlas](https://www.mongodb.com/cloud/atlas) — darmowy poziom obejmuje 512 MB
  * [redsmin.com](https://www.redsmin.com/) — Usługa monitorowania i zarządzania Redis w czasie rzeczywistym online, monitoring jednej instancji Redis za darmo
  * [redislabs](https://redislabs.com/try-free/) - Darmowa instancja redis o wielkości 30 MB
  * [MemCachier](https://www.memcachier.com/) — Zarządzana usługa Memcache. Darmowa do 25 MB, 1 serwer proxy i podstawowa analityka
  * [scalingo.com](https://scalingo.com/) — Głównie PaaS, ale oferuje darmowy poziom 128 MB do 192 MB dla MySQL, PostgreSQL lub MongoDB
  * [SeaTable](https://seatable.io/) — Elastyczna, arkuszowa baza danych stworzona przez zespół Seafile. Nieograniczona liczba tabel, 2000 wierszy, wersjonowanie przez miesiąc, do 25 członków zespołu.
  * [skyvia.com](https://skyvia.com/) — Platforma Cloud Data oferuje darmowy poziom, a wszystkie plany są całkowicie darmowe w fazie beta
  * [StackBy](https://stackby.com/) — Jedno narzędzie łączące elastyczność arkuszy kalkulacyjnych, moc baz danych i integracje z ulubionymi aplikacjami biznesowymi. Darmowy plan obejmuje nieograniczoną liczbę użytkowników, dziesięć stosów i 2GB załączników na stos.
  * [TiDB Cloud](https://en.pingcap.com/tidb-cloud/) — TiDB to otwartoźródłowy, kompatybilny z MySQL rozproszony HTAP RDBMS. TiDB Serverless udostępnia 5 GB magazynu wierszowego, 5 GB magazynu kolumnowego i 50 mln Request Units (RU) miesięcznie za darmo.
  * [Turso by ChiselStrike](https://chiselstrike.com/) - Turso to SQLite Developer Experience w Edge Database. Turso oferuje darmowy plan Free Forever, 9 GB całkowitej przestrzeni, do 500 baz, do 3 lokalizacji, 1 miliard odczytów wierszy miesięcznie i wsparcie dla lokalnego developmentu z SQLite.
  * [InfluxDB](https://www.influxdata.com/) — Baza danych szeregów czasowych, darmowa do 3 MB/5 minut zapisu, 30 MB/5 minut odczytu i 10 000 serii kardynalności
  * [restdb.io](https://restdb.io/) - szybka i prosta usługa chmurowej bazy NoSQL. W restdb.io otrzymujesz schemat, relacje, automatyczne REST API (z zapytaniami podobnymi do MongoDB) oraz wydajny, wieloużytkownikowy interfejs do pracy z danymi. Darmowy plan pozwala na 3 użytkowników, 2500 rekordów i 1 zapytanie API na sekundę.
  * [CockroachDB Cloud](https://www.cockroachlabs.com/pricing/) — Darmowy poziom oferuje 50 mln RU i 10 GiB przestrzeni (równowartość 15 USD) miesięcznie. ([Czym są Request Units](https://www.cockroachlabs.com/docs/cockroachcloud/metrics-request-units.html))
  * [Neo4j Aura](https://neo4j.com/cloud/aura/) — Zarządzana natywna baza grafowa / platforma analityczna z językiem zapytań Cypher i REST API. Limity wielkości grafu (50 tys. węzłów, 175 tys. relacji).
  * [Neon](https://neon.tech/) — Zarządzany PostgreSQL, 0,5 GB przestrzeni (łącznie), 1 projekt, 10 gałęzi, nieograniczona liczba baz danych, zawsze dostępna główna gałąź (automatyczne zawieszanie po 5 minutach), 20 godzin aktywnego czasu miesięcznie (łącznie) dla obliczeń na gałęzi nie-głównej.
  * [Prisma Postgres](https://prisma.io/postgres) - Bardzo szybki, hostowany Postgres oparty na unikernelach, uruchamiany na gołym metalu, 1 GB przestrzeni, 10 baz danych, integracja z Prisma ORM.
  * [Dgraph Cloud](https://cloud.dgraph.io/pricing?type=free) — Zarządzana natywna baza grafowa z API GraphQL. Ograniczenie do 1 MB transferu danych dziennie.
  * [Tinybird](https://tinybird.co) - Serverless zarządzany ClickHouse z bezpołączeniowym przesyłaniem danych przez HTTP i możliwością publikowania zapytań SQL jako zarządzane API HTTP. Brak limitu czasowego na darmowym poziomie, 10 GB przestrzeni + 1000 żądań API dziennie.
  * [TigerGraph Cloud](https://www.tigergraph.com/cloud/) — Zarządzana natywna baza grafowa / platforma analityczna z językiem zapytań grafowych podobnym do SQL i REST API. Jedna darmowa instancja z dwoma vCPU, 8 GB RAM i 50 GB przestrzeni, usypiana po 1h bezczynności.
  * [TerminusCMS](https://terminusdb.com/pricing) — Zarządzana darmowa usługa dla TerminusDB, dokumentowej i grafowej bazy danych napisanej w Prologu i Rust. Darmowa dla dev, płatna dla wdrożeń enterprise i wsparcia.
  * [filess.io](https://filess.io) - filess.io to platforma, gdzie możesz utworzyć dwie bazy danych (do 10 MB na bazę) spośród: MySQL, MariaDB, MongoDB, PostgreSQL za darmo.
  * [xata.io](https://xata.io) - Xata to serverlessowa baza z wbudowanym wydajnym wyszukiwaniem i analizą. Jedno API, wiele typowanych bibliotek klienckich, zoptymalizowana pod workflow developerskie. Darmowy poziom wystarcza dla hobbystów i obejmuje trzy jednostki Xata, definicję jednostki znajdziesz na stronie.
  * [8base.com](https://www.8base.com/) - 8base to pełnostackowa platforma low-code dla JavaScriptowców, oparta na MySQL, GraphQL i serverless backend-as-a-service. Umożliwia szybkie budowanie aplikacji webowych przez UI app buildera i łatwą skalowalność. Darmowy poziom obejmuje: 2,500 wierszy, 500 storage, 1Gb/h serverless computing, 5 użytkowników aplikacji klienckich.
  * [Nile](https://www.thenile.dev/) — Platforma Postgres dla aplikacji B2B. Nieograniczona liczba baz, zawsze dostępna bez wyłączeń, 1 GB przestrzeni (łącznie), 50 milionów tokenów zapytań, autoskalowanie, nieograniczone osadzanie wektorów



**[⬆️ Powrót na górę](#table-of-contents)**

## Tunelowanie, WebRTC, Web Socket Serwery i Inne Routery

  * [Pinggy](https://pinggy.io) — Publiczne URL dla localhost jednym poleceniem, bez pobierania. HTTPS / TCP / TLS tunele. Darmowy plan: 60 minut tunelu.
  * [conveyor.cloud](https://conveyor.cloud/) — Rozszerzenie Visual Studio do udostępniania IIS Express w sieci lokalnej lub przez tunel do publicznego URL.
  * [Hamachi](https://www.vpn.net/) — LogMeIn Hamachi to hostowana usługa VPN umożliwiająca bezpieczne rozszerzenie sieci LAN dla rozproszonych zespołów; darmowy plan pozwala na nieograniczoną liczbę sieci z maks. 5 osobami
  * [Mirna Sockets](https://mirna.cloud/) - Darmowa platforma Socket as a Service, która daje Ci URL wss:// po wdrożeniu swojego kodu Web Socket Server oraz umożliwia monitorowanie wydajności.
  * [localhost.run](https://localhost.run/) — Udostępniaj lokalnie uruchomione serwery przez tunel do publicznego URL.
  * [localtunnel](https://theboroer.github.io/localtunnel-www/) — Udostępniaj lokalnie uruchomione serwery przez tunel do publicznego URL. Darmowa wersja hostowana oraz [open source](https://github.com/localtunnel/localtunnel).
  * [ngrok.com](https://ngrok.com/) — Udostępniaj lokalnie uruchomione serwery przez tunel do publicznego URL.
  * [cname.dev](https://cname.dev/) — Darmowy i bezpieczny dynamiczny serwis reverse proxy.
  * [serveo](https://serveo.net/) — Udostępnij lokalne serwery w internecie. Bez instalacji, bez rejestracji. Darmowa subdomena, brak limitów.
  * [Radmin VPN](https://www.radmin-vpn.com/) — Łącz wiele komputerów przez VPN, tworząc sieć podobną do LAN. Nieograniczona liczba peerów. (alternatywa dla Hamachi)
  * [segment.com](https://segment.com/) — Hub do tłumaczenia i routowania zdarzeń do innych usług zewnętrznych. 100 000 zdarzeń/miesiąc za darmo
  * Google STUN — [stun:stun.l.google.com:19302](stun:stun.l.google.com:19302)
  * Twilio STUN — [stun:global.stun.twilio.com:3478?transport=udp](stun:global.stun.twilio.com:3478?transport=udp)
  * [Tailscale](https://tailscale.com/) — Zero config VPN, używający open-source WireGuard. Instalacja na MacOS, iOS, Windows, Linux, Android. Darmowy plan dla użytku osobistego do 100 urządzeń i trzech użytkowników.
  * [webhookrelay.com](https://webhookrelay.com) — Zarządzaj, debuguj, rozdzielaj i proxy'uj wszystkie swoje webhooki do publicznych lub wewnętrznych (np. localhost) miejsc docelowych. Możesz również wystawić serwery z prywatnej sieci przez tunel, uzyskując publiczny endpoint HTTP (`https://yoursubdomain.webrelay.io <----> http://localhost:8080`).
  * [Hookdeck](https://hookdeck.com/pricing) — Twórz, testuj i monitoruj webhooki z dowolnego miejsca. 100 tys. żądań i 100 tys. prób miesięcznie, trzy dni retencji.
  * [Xirsys](https://www.xirsys.com/pricing/) — Nieograniczone użycie STUN + 500 MB miesięcznego transferu TURN, ograniczone pasmo, jeden region geograficzny.
  * [ZeroTier](https://www.zerotier.com) — FOSS zarządzany wirtualny Ethernet jako usługa. Nieograniczone, end-to-end szyfrowane sieci do 25 klientów w darmowym planie. Klienty na desktop/mobile/NA, webowy interfejs do konfiguracji trasowania i akceptacji nowych klientów w sieciach prywatnych
  * [LocalXpose](https://localxpose.io) — Reverse proxy umożliwiający wystawienie serwerów localhost do internetu. Darmowy plan: 15 minut tunelu.
  * [Traefik-Hub](https://traefik.io/traefik-hub/) - Udostępniaj lokalnie uruchomione usługi przez tunel na publiczny, własny URL i zabezpieczaj je kontrolą dostępu. Darmowo dla 5 usług w jednym klastrze.
  * [Expose](https://expose.dev/) - Udostępnij lokalne strony przez bezpieczne tunele. Darmowy plan zawiera serwer EU, losowe subdomeny i pojedynczego użytkownika.
  * [btunnel](https://www.btunnel.in/) — Udostępnij localhost i lokalny serwer TCP do internetu. Darmowy plan zawiera serwer plików, własne nagłówki http request/response, ochronę basic auth i 1h timeout tunelu.

**[⬆️ Powrót na górę](#table-of-contents)**

## Śledzenie zgłoszeń i zarządzanie projektami

  * [acunote.com](https://www.acunote.com/) — Darmowe oprogramowanie do zarządzania projektami i SCRUM dla maksymalnie 5 członków zespołu
  * [asana.com](https://asana.com/) — Darmowe dla prywatnych projektów z współpracownikami
  * [Backlog](https://backlog.com) — Wszystko, czego Twój zespół potrzebuje do wydania świetnych projektów w jednej platformie. Darmowy plan oferuje 1 projekt dla 10 użytkowników i 100 MB przestrzeni.
  * [Basecamp](https://basecamp.com/personal) - Listy zadań, zarządzanie kamieniami milowymi, komunikacja na wzór forum, udostępnianie plików i śledzenie czasu. Do 3 projektów, 20 użytkowników i 1 GB przestrzeni.
  * [bitrix24.com](https://www.bitrix24.com/) — Intranet i narzędzie do zarządzania projektami. Darmowy plan: 5 GB dla nieograniczonej liczby użytkowników.
  * [cacoo.com](https://cacoo.com/) — Online, współdzielone diagramy: flowchart, UML, sieciowe. Darmowo max. 15 użytkowników/diagram, 25 arkuszy
  * [Chpokify](https://chpokify.com/) — Planowanie sprintów w oparciu o Poker Planning dla zespołów. Darmowe do 5 użytkowników, darmowe integracje z Jira, nieograniczone wideorozmowy, zespoły i sesje.
  * [clickup.com](https://clickup.com/) — Zarządzanie projektami. Darmowe, wersja premium z chmurą. Aplikacje mobilne i integracje z Gitem dostępne.
  * [Clockify](https://clockify.me) - Tracker czasu i aplikacja do rejestrowania godzin pracy w projektach. Nieograniczona liczba użytkowników, zawsze za darmo.
  * [Cloudcraft](https://cloudcraft.co/) — Projektuj profesjonalne diagramy architektury w kilka minut dzięki wizualnemu projektantowi Cloudcraft, zoptymalizowanemu pod AWS z inteligentnymi komponentami pokazującymi także dane na żywo. Darmowy plan: nieograniczone prywatne diagramy dla jednego użytkownika.
  * [Codegiant](https://codegiant.io) — Zarządzanie projektami z hostingiem repozytorium i CI/CD. Darmowy plan: nieograniczone repozytoria, projekty i dokumenty dla 5 członków zespołu. 500 minut CI/CD miesięcznie. 30 000 minut Serverless Code Run miesięcznie, 1 GB repozytorium.
  * [Confluence](https://www.atlassian.com/software/confluence) - Narzędzie Atlassiana do współpracy nad treścią, pomagające zespołom efektywnie dzielić się wiedzą. Darmowy plan do 10 użytkowników.
  * [contriber.com](https://www.contriber.com/) — Konfigurowalna platforma do zarządzania projektami, darmowy plan startowy, pięć workspace’ów
* [Crosswork](https://crosswork.app/) - Wszechstronna platforma do zarządzania projektami. Darmowa do 3 projektów, nieograniczona liczba użytkowników, 1 GB miejsca na dane.
* [diagrams.net](https://app.diagrams.net/) — Diagramy online przechowywane lokalnie w Google Drive, OneDrive lub Dropbox. Darmowe dla wszystkich funkcji i poziomów pamięci.
* [freedcamp.com](https://freedcamp.com/) - zadania, dyskusje, kamienie milowe, śledzenie czasu, kalendarz, pliki i menedżer haseł. Plan darmowy z nieograniczoną liczbą projektów, użytkowników i miejsca na pliki.
* [easyretro.io](https://www.easyretro.io/) — Proste i intuicyjne narzędzie do retrospekcji sprintów. Darmowy plan obejmuje trzy publiczne tablice i jedną ankietę na tablicę miesięcznie.
* [GForge](https://gforge.com) — Zestaw narzędzi do zarządzania projektami i śledzenia zgłoszeń dla złożonych projektów, z opcjami self-hosted i SaaS. Plan darmowy SaaS dla pierwszych pięciu użytkowników oraz darmowy dla projektów Open Source.
* [gleek.io](https://www.gleek.io) — Darmowe narzędzie do opisu i generowania diagramów dla deweloperów. Twórz nieformalne diagramy UML klas, obiektów lub relacji encji, używając słów kluczowych.
* [GraphQL Inspector](https://github.com/marketplace/graphql-inspector) - GraphQL Inspector generuje listę zmian między dwoma schematami GraphQL. Każda różnica jest dokładnie wyjaśniona i oznaczona jako breaking, non-breaking lub dangerous.
* [huboard.com](https://huboard.com/) — Natychmiastowe zarządzanie projektami dla zgłoszeń GitHub, darmowe dla Open Source.
* [Hygger](https://hygger.io) — Platforma do zarządzania projektami. Darmowy plan oferuje nieograniczoną liczbę użytkowników, projektów i tablic oraz 100 MB miejsca na dane.
* [Instabug](https://instabug.com) — Kompleksowy SDK do zgłaszania błędów i opinii w aplikacjach mobilnych. Darmowy plan do 1 aplikacji i jednego członka.
* [WishKit](https://wishkit.io) — Zbieraj opinie użytkowników w aplikacji iOS/macOS i priorytetyzuj funkcje na podstawie głosów. Darmowy plan do 1 aplikacji.
* [Ilograph](https://www.ilograph.com/)  — Interaktywne diagramy umożliwiające prezentację infrastruktury z różnych perspektyw i na różnych poziomach szczegółowości. Diagramy można wyrażać w kodzie. Darmowy poziom obejmuje nieograniczoną liczbę prywatnych diagramów z maksymalnie 3 widzami.
* [Jira](https://www.atlassian.com/software/jira) — Zaawansowane narzędzie do zarządzania projektami programistycznymi, używane w środowiskach korporacyjnych. Darmowy plan do 10 użytkowników.
* [kanbanflow.com](https://kanbanflow.com/) — Zarządzanie projektami na tablicach. Darmowy, wersja premium z większą liczbą opcji.
* [kanbantool.com](https://kanbantool.com/) — Zarządzanie projektami na tablicach Kanban. Darmowy plan obejmuje dwie tablice i dwóch użytkowników, bez załączników i plików.
* [kan.bn](https://kan.bn/) - Potężna, elastyczna aplikacja kanban pomagająca organizować pracę, śledzić postępy i dostarczać wyniki — wszystko w jednym miejscu. Darmowy plan do 1 użytkownika na nieograniczoną liczbę tablic, list i kart.
* [Kitemaker.co](https://kitemaker.co) - Współpraca we wszystkich fazach rozwoju produktu i śledzenie pracy w Slack, Discord, Figma i Github. Nieograniczona liczba użytkowników i przestrzeni. Darmowy plan do 250 elementów pracy.
* [Kiter.app](https://www.kiter.app/) - Pozwól każdemu zorganizować swoją ścieżkę kariery i śledzić rozmowy, oferty i kontakty. Potężna aplikacja webowa i rozszerzenie Chrome. Całkowicie darmowe.
* [Kumu.io](https://kumu.io/)  — Mapy relacji z animacjami, dekoracjami, filtrami, klastrowaniem, importem z arkuszy itd. Darmowy poziom umożliwia nieograniczoną liczbę publicznych projektów. Wielkość grafu nieograniczona. Darmowe projekty prywatne dla studentów. Tryb sandbox dostępny, jeśli nie chcesz publikować pliku online (przesyłanie, edycja, pobieranie, odrzucenie).
* [Linear](https://linear.app/) — Tracker zgłoszeń z uproszczonym interfejsem. Darmowy dla nieograniczonej liczby członków, do 10 MB na plik, 250 zgłoszeń (z wyłączeniem archiwum).
* [leiga.com](https://www.leiga.com/) — Leiga to produkt SaaS, który używa AI do automatycznego zarządzania projektami, pomagając zespołowi skupić się i wykorzystać potencjał, zapewniając postępy zgodnie z planem. Darmowy do 10 użytkowników, 20 pól niestandardowych, 2 GB miejsca, nagrywanie wideo z AI ograniczone do 5 min/wideo, automatyzacje do 20/użytkownika/miesiąc.
* [Lucidchart](https://www.lucidchart.com/) - Narzędzie online do tworzenia diagramów z funkcjami współpracy. Darmowy plan obejmuje trzy edytowalne dokumenty, 100 profesjonalnych szablonów i podstawowe funkcje współpracy.
* [MeisterTask](https://www.meistertask.com/) — Zarządzanie zadaniami online dla zespołów. Darmowe do 3 projektów i nieograniczonej liczby członków projektu.
* [MeuScrum](https://www.meuscrum.com/en) - Darmowe narzędzie scrum online z tablicą kanban.
* [nTask](https://www.ntaskmanager.com/) — Oprogramowanie do zarządzania projektami pozwalające zespołom współpracować, planować, analizować i zarządzać codziennymi zadaniami. Plan podstawowy darmowy na zawsze, 100 MB miejsca i pięciu użytkowników/zespołów. Nieograniczone przestrzenie robocze, spotkania, zadania, karty czasu pracy i śledzenie zgłoszeń.
* [Ora](https://ora.pm/) - Zwinne zarządzanie zadaniami i współpraca zespołowa. Darmowe do 3 użytkowników, pliki ograniczone do 10 MB.
* [pivotaltracker.com](https://www.pivotaltracker.com/) — Darmowe dla nieograniczonej liczby projektów publicznych i dwóch prywatnych z łącznie trzema aktywnymi użytkownikami (z prawem zapisu) i nieograniczoną liczbą pasywnych użytkowników (tylko do odczytu).
* [plan.io](https://plan.io/) — Zarządzanie projektami z hostingiem repozytoriów i innymi opcjami. Darmowe dla dwóch użytkowników, dziesięciu klientów i 500MB miejsca.
* [Plane](https://plane.so/) - Proste, rozszerzalne, otwartoźródłowe narzędzie do zarządzania projektami i produktami. Darmowe dla nieograniczonej liczby członków, do 5MB na plik, 1000 zgłoszeń.
* [planitpoker.com](https://www.planitpoker.com/) — Darmowe planowanie pokerowe online (narzędzie do estymacji).
* [point.poker](https://www.point.poker/) - Online Planning Poker (narzędzie do estymacji konsensusowej). Darmowe dla nieograniczonej liczby użytkowników, zespołów, sesji, rund i głosów. Bez rejestracji.
* [ScrumFast](https://www.scrumfast.com) - Tablica scrum z bardzo intuicyjnym interfejsem, darmowa do 5 użytkowników.
* [Shake](https://www.shakebugs.com/) - Narzędzie do zgłaszania błędów i opinii w aplikacjach mobilnych. Darmowy plan, 10 zgłoszeń błędów na aplikację/miesiąc.
* [Shortcut](https://shortcut.com/) - Platforma do zarządzania projektami. Darmowe do 10 użytkowników na zawsze.
* [Tadum](https://tadum.app) - Aplikacja do agendy i protokołów spotkań zaprojektowana dla cyklicznych spotkań, darmowa dla zespołów do 10 osób.
* [taiga.io](https://taiga.io/) — Platforma do zarządzania projektami dla startupów i programistów agile, darmowa dla Open Source.
* [Tara AI](https://tara.ai/) — Prosty serwis do zarządzania sprintami. Darmowy plan z nieograniczoną liczbą zadań, sprintów i przestrzeni roboczych bez limitu użytkowników.
* [targetprocess.com](https://www.targetprocess.com/) — Wizualne zarządzanie projektami, od Kanban i Scrum po niemal każdy proces operacyjny. Darmowe dla nieograniczonej liczby użytkowników, do 1 000 encji danych {[więcej szczegółów](https://www.targetprocess.com/pricing/)}
* [taskade.com](https://www.taskade.com/) — Wspólne, w czasie rzeczywistym, listy zadań i konspekty zespołów. Darmowy plan obejmuje jedną przestrzeń roboczą z nieograniczoną liczbą zadań i projektów; 1GB miejsca na pliki; historię projektów z 1 tygodnia; pięciu uczestników na spotkanie wideo.
* [taskulu.com](https://taskulu.com/) — Zarządzanie projektami oparte na rolach. Darmowe do 5 użytkowników. Integracja z GitHub/Trello/Dropbox/Google Drive.
* [Teaminal](https://www.teaminal.com) - Narzędzie do standupów, retro i planowania sprintów dla zespołów zdalnych. Darmowe do 15 użytkowników.
* [teamwork.com](https://teamwork.com/) — Zarządzanie projektami i czat zespołowy. Darmowe dla pięciu użytkowników i dwóch projektów. Dostępne płatne plany premium.
* [teleretro.com](https://www.teleretro.com/) — Proste i zabawne narzędzie do retrospekcji z icebreakerami, gifami i emoji. Darmowy plan obejmuje trzy retrospekcje i nieograniczoną liczbę członków.
* [testlio.com](https://testlio.com/) — Platforma do śledzenia zgłoszeń, zarządzania testami i beta testów. Darmowe do prywatnego użytku.
* [terrastruct.com](https://terrastruct.com/) — Online diagram maker specjalnie dla architektury oprogramowania. Darmowy poziom do 4 warstw na diagram.
* [todoist.com](https://todoist.com/) — Wspólne i indywidualne zarządzanie zadaniami. Darmowy plan: 5 aktywnych projektów, pięciu użytkowników w projekcie, pliki do 5MB, trzy filtry i tydzień historii aktywności.
* [trello.com](https://trello.com/) — Zarządzanie projektami na tablicach. Nieograniczona liczba Tablic Osobistych, 10 Tablic Zespołowych.
* [Tweek](https://tweek.so/) — Prosty tygodniowy kalendarz zadań i zarządzanie zadaniami.
* [ubertesters.com](https://ubertesters.com/) — Platforma testowa, integracja i testerzy z tłumu, 2 projekty, pięciu członków.
* [Wikifactory](https://wikifactory.com/) — Usługa projektowania produktu z projektami, VCS i zgłoszeniami. Darmowy plan oferuje nieograniczoną liczbę projektów i współpracowników oraz 3GB miejsca.
* [Yodiz](https://www.yodiz.com/) — Zwinne zarządzanie projektami i śledzenie zgłoszeń. Darmowe do 3 użytkowników, nieograniczona liczba projektów.
* [YouTrack](https://www.jetbrains.com/youtrack/buy/#edition=incloud) — Darmowy YouTrack (InCloud) hostowany dla projektów FOSS i prywatnych (darmowy do trzech użytkowników). Obejmuje śledzenie czasu i tablice agile.
* [zenhub.com](https://www.zenhub.com) — Jedynie rozwiązanie do zarządzania projektami wewnątrz GitHub. Darmowe dla repozytoriów publicznych, OSS i organizacji non-profit.
* [zenkit.com](https://zenkit.com) — Narzędzie do zarządzania projektami i współpracy. Darmowe do 5 członków, 5 GB załączników.
* [Zube](https://zube.io) — Zarządzanie projektami z darmowym planem dla 4 projektów i 4 użytkowników. Dostępna integracja z GitHub.
* [Toggl](https://toggl.com/) — Dwa darmowe narzędzia do produktywności. [Toggl Track](https://toggl.com/track/) do zarządzania i śledzenia czasu z darmowym planem oferującym nieograniczone śledzenie, projekty, klientów, tagi, raportowanie i więcej. Oraz [Toggl Plan](https://toggl.com/plan/) do planowania zadań z darmowym planem dla pojedynczego dewelopera z nieograniczoną liczbą zadań, kamieni milowych i osi czasu.
* [Sflow](https://sflow.io) — sflow.io to narzędzie do zarządzania projektami stworzone dla zwinnego rozwoju oprogramowania, marketingu, sprzedaży i obsługi klienta, zwłaszcza do projektów outsourcingowych i międzyorganizacyjnych. Darmowy plan do 3 projektów i pięciu członków.
* [Pulse.red](https://pulse.red) — Darmowy minimalistyczny tracker czasu pracy i aplikacja do ewidencji czasu dla projektów.

**[⬆️ Powrót na górę](#table-of-contents)**

## Przechowywanie i przetwarzanie multimediów

* [AndroidFileHost](https://androidfilehost.com/) - Darmowa platforma do udostępniania plików z nieograniczoną prędkością, transferem, liczbą plików, liczbą pobrań itd. Głównie przeznaczona dla plików związanych z Androidem jak APK, custom ROM czy modyfikacje, ale akceptuje także inne pliki.
* [borgbase.com](https://www.borgbase.com/) — Prosty i bezpieczny hosting backupów poza siedzibą dla Borg Backup. 10 GB darmowego miejsca i dwa repozytoria.
* [icedrive.net](https://www.icedrive.net/) - Prosta usługa przechowywania w chmurze. 10 GB darmowego miejsca.
* [sync.com](https://www.sync.com/) - Chmura z szyfrowaniem end-to-end. 5 GB darmowego miejsca.
* [pcloud.com](https://www.pcloud.com/) - Usługa przechowywania w chmurze. Do 10 GB darmowego miejsca.
* [sirv.com](https://sirv.com/) — Inteligentny CDN do obrazów z automatyczną optymalizacją i skalowaniem. Darmowy poziom obejmuje 500 MB miejsca i 2 GB transferu.
* [cloudimage.io](https://www.cloudimage.io/en/home) — Pełna optymalizacja obrazów i CDN z ponad 1500 punktami obecności na świecie. Szeroki zakres funkcji zmiany rozmiaru, kompresji i znakowania wodnego. Open source pluginy do responsywnych obrazów, generowania 360 i edycji. Darmowy plan miesięczny z 25GB ruchu CDN, 25GB cache i nieograniczoną liczbą transformacji.
* [cloudinary.com](https://cloudinary.com/) — Przesyłanie, zaawansowana obróbka, przechowywanie i dostarczanie obrazów dla stron i aplikacji, z bibliotekami Ruby, Python, Java, PHP, Objective-C i innymi. Darmowy poziom obejmuje 25 kredytów miesięcznie. Jeden kredyt to 1 000 transformacji, 1 GB miejsca lub 1 GB ruchu CDN.
* [embed.ly](https://embed.ly/) — API do osadzania mediów na stronie, responsywnego skalowania obrazów i ekstrakcji elementów ze strony. Darmowe do 5 000 URL/miesiąc przy 15 żądaniach/sekundę.
* [filestack.com](https://www.filestack.com/) — Wybieranie plików, przetwarzanie i dostarczanie, darmowe dla 250 plików, 500 transformacji i 3 GB transferu.
* [file.io](https://www.file.io) - 2 GB miejsca na pliki. Plik jest automatycznie usuwany po jednym pobraniu. REST API do interakcji z magazynem. Limit 1 żądanie/minutę.
* [freetools.site](https://freetools.site/) — Darmowe narzędzia online. Konwersja lub edycja dokumentów, obrazów, audio, wideo i innych.
* [GoFile.io](https://gofile.io/) - Darmowa platforma do udostępniania i przechowywania plików dostępna przez interfejs webowy i API. Nieograniczona wielkość pliku, transfer, liczba pobrań itd. Plik jest kasowany, gdy stanie się nieaktywny (brak pobrań przez ponad 10 dni).
* [gumlet.com](https://www.gumlet.com/) — Hosting, przetwarzanie i streaming obrazów oraz wideo przez CDN. Hojny darmowy poziom: 250 GB/miesiąc dla wideo i 30 GB/miesiąc dla obrazów.
* [image-charts.com](https://www.image-charts.com/) — Nieograniczone generowanie wykresów jako obrazów z znakiem wodnym.
* [Imgbot](https://github.com/marketplace/imgbot) — Imgbot to bot optymalizujący obrazy i oszczędzający czas. Optymalizacja oznacza mniejsze rozmiary plików bez utraty jakości. Darmowy dla open source.
* [ImgBB](https://imgbb.com/) — ImgBB to nielimitowany hosting obrazów. Przeciągnij i upuść obraz w dowolnym miejscu na ekranie. Limit 32 MB na obraz. Po przesłaniu otrzymujesz bezpośrednie linki, BBCode i miniaturki HTML. Po zalogowaniu widzisz historię przesłań.
* [imgen](https://www.jitbit.com/imgen/) - Darmowe, nielimitowane API do generowania okładek społecznościowych, bez znaku wodnego.
* [imgix](https://www.imgix.com/) - Cache, zarządzanie i CDN do obrazów. Darmowy plan obejmuje 1000 obrazów źródłowych, nieskończone transformacje i 100 GB transferu.
* [kraken.io](https://kraken.io/) — Optymalizacja obrazów dla wydajności stron jako usługa, darmowy plan do 1 MB na plik.
* [kvstore.io](https://www.kvstore.io/) — Usługa przechowywania klucz-wartość. Darmowy poziom: 100 kluczy, 1KB/klucz, 100 wywołań/godzinę.
* [npoint.io](https://www.npoint.io/) — Przechowywanie JSON z możliwością wspólnej edycji schematów.
* [nitropack.io](https://nitropack.io/) - Automatyczna optymalizacja prędkości strony (cache, optymalizacja obrazów i kodu, CDN). Darmowe do 5 000 odsłon miesięcznie.
* [otixo.com](https://www.otixo.com/) — Szyfruj, udostępniaj, kopiuj i przenoś wszystkie pliki z chmury w jednym miejscu. Plan podstawowy: nieograniczony transfer plików, maks. 250 MB na plik i pięć zaszyfrowanych plików.
* [packagecloud.io](https://packagecloud.io/) — Hostowane repozytoria paczek dla YUM, APT, RubyGem i PyPI. Ograniczone darmowe plany i plany open source na zapytanie.
* [getpantry.cloud](https://getpantry.cloud/) — Proste API do przechowywania danych JSON, idealne do projektów osobistych, hackathonów i aplikacji mobilnych!
* [Pinata IPFS](https://pinata.cloud) — Najprostszy sposób na przesyłanie i zarządzanie plikami na IPFS. Przyjazny interfejs i API IPFS. 1 GB za darmo oraz dostęp do API.
* [placekitten.com](https://placekitten.com/) — Szybka i prosta usługa do pobierania zdjęć kotów jako placeholderów.
* [plot.ly](https://plot.ly/) — Twórz wykresy i udostępniaj dane. Darmowy poziom: nieograniczona liczba publicznych plików i 10 prywatnych.
* [podio.com](https://podio.com/) — Możesz korzystać z Podio z zespołem do pięciu osób i wypróbować funkcje planu Basic, z wyjątkiem zarządzania użytkownikami.
* [QRME.SH](https://qrme.sh) - Szybki, estetyczny generator masowych kodów QR – bez logowania, znaków wodnych i reklam. Do 100 URL w eksporcie masowym.
* [QuickChart](https://quickchart.io) — Generuj osadzalne wykresy obrazów, grafy i kody QR.
* [redbooth.com](https://redbooth.com) — P2P synchronizacja plików, darmowa do 2 użytkowników.
* [resmush.it](https://resmush.it) — reSmush.it to DARMOWE API do optymalizacji obrazów. Obsługuje najpopularniejsze CMS jak WordPress, Drupal czy Magento. Najpopularniejsze API do optymalizacji obrazów z ponad siedmioma miliardami przetworzonych obrazów i nadal darmowe.
* [Shotstack](https://shotstack.io) - API do generowania i edycji wideo na dużą skalę. Darmowe do 20 minut renderowanego wideo miesięcznie.
* [tinypng.com](https://tinypng.com/) — API do kompresji i zmiany rozmiaru obrazów PNG i JPEG, 500 kompresji darmowych miesięcznie.
* [transloadit.com](https://transloadit.com/) — Obsługa przesyłania plików i enkodowania wideo, audio, obrazów, dokumentów. Darmowe dla open source, organizacji charytatywnych i studentów (GitHub Student Developer Pack). Komercyjne aplikacje: 2 GB na testy.
* [twicpics.com](https://www.twicpics.com) - Responsywne obrazy jako usługa. Oferuje CDN do obrazów, API do przetwarzania multimediów oraz bibliotekę frontendową do automatyzacji optymalizacji obrazów. Usługa jest bezpłatna do 3GB ruchu/miesiąc.
* [uploadcare.com](https://uploadcare.com/hub/developers/) — Uploadcare udostępnia pipeline multimedialny z zaawansowanym zestawem narzędzi opartym na najnowszych algorytmach. Wszystkie funkcje są dostępne dla programistów całkowicie za darmo: API i UI do przesyłania plików, CDN do obrazów i usługi Origin, Adaptive Delivery i Smart Compression. Darmowy poziom obejmuje 3000 przesłań, 3 GB ruchu i 3 GB przestrzeni dyskowej.
* [imagekit.io](https://imagekit.io) – CDN do obrazów z automatyczną optymalizacją, przekształcaniem w czasie rzeczywistym i magazynowaniem, które można zintegrować z istniejącą infrastrukturą w kilka minut. Darmowy plan obejmuje do 20GB transferu danych miesięcznie.
* [internxt.com](https://internxt.com) – Internxt Drive to usługa przechowywania plików z zerową wiedzą (zero-knowledge), oparta na pełnej prywatności i bezkompromisowym bezpieczeństwie. Zarejestruj się i otrzymaj 10 GB za darmo, na zawsze!
* [degoo.com](https://degoo.com/) – Chmurowe przechowywanie plików oparte na AI, za darmo do 20 GB, trzy urządzenia, 5 GB za polecenie (90 dni braku aktywności konta).
* [MConverter.eu](https://mconverter.eu/) – Konwertuj pliki zbiorczo. Obsługuje wiele formatów, w tym nowe jak [AVIF](https://mconverter.eu/convert/to/avif/). Wyodrębnij wszystkie klatki obrazu z wideo. Za darmo do dziesięciu plików 100 MB dziennie, przetwarzanych w partiach po dwa.
* [ImageEngine](https://imageengine.io/) – ImageEngine to łatwy w użyciu globalny CDN do obrazów. Konfiguracja w mniej niż 60 sekund. Obsługa AVIF i JPEGXL, wtyczki do WordPress, Magento, React, Vue i inne. Odbierz darmowe konto deweloperskie [tutaj](https://imageengine.io/developer-program/).
* [DocsParse](https://docsparse.com/) – Przetwarzanie PDF i obrazów przez AI GPT do ustrukturyzowanych danych w formatach JSON, CSV, EXCEL. 30 darmowych kredytów miesięcznie.
* [VaocherApp QR Code Generator](https://www.vaocherapp.com/qr-code-generator) – Łatwo twórz niestandardowe kody QR na karty podarunkowe, vouchery i promocje. Obsługa niestandardowego stylu, koloru, logo...
* [LibreQR](https://libreqr.com) — Darmowy generator kodów QR skupiony na prywatności i braku śledzenia. Do bezpłatnego użytku bez zbierania danych.

**[⬆️ Powrót na górę](#table-of-contents)**

## Design i UI

* [AllTheFreeStock](https://allthefreestock.com) - kuratorowana lista darmowych zdjęć stockowych, dźwięków i wideo.
* [Float UI](https://floatui.com/) - darmowe narzędzie do szybkiego tworzenia nowoczesnych, responsywnych stron internetowych z eleganckim designem, nawet dla niedesignerów.
* [Ant Design Landing Page](https://landing.ant.design/) - Ant Design Landing Page oferuje szablon zbudowany na komponentach ruchu Ant Motion. Posiada bogaty zestaw szablonów stron głównych, możliwość pobrania paczki kodu szablonu i szybkiego wykorzystania. Możesz też skorzystać z edytora, aby szybko zbudować własną stronę.
* [Backlight](https://backlight.dev/) — Platforma do pełnej współpracy projektantów i deweloperów. Pozwala budować, dokumentować, publikować, skalować i utrzymywać Design Systemy. Darmowy plan pozwala do 3 edytorów na jednym systemie projektowym z nieograniczoną liczbą widzów.
* [BoxySVG](https://boxy-svg.com/app) — Darmowa instalowalna aplikacja webowa do rysowania SVG i eksportu do SVG, PNG, jpeg i innych formatów.
* [Carousel Hero](https://carouselhero.com/) - Darmowe narzędzie online do tworzenia karuzel na media społecznościowe.
* [Circum Icons](https://circumicons.com) - Spójne, otwartoźródłowe ikony SVG dla React, Vue i Svelte.
* [clevebrush.com](https://www.cleverbrush.com/) — Darmowa aplikacja do projektowania graficznego/robienia kolaży zdjęć. Oferuje również płatną integrację jako komponent.
* [cloudconvert.com](https://cloudconvert.com/) — Konwertuj wszystko na wszystko. Obsługuje 208 formatów, w tym wideo i gif.
* [CodeMyUI](https://codemyui.com) - Ręcznie wyselekcjonowana kolekcja inspiracji dla projektowania stron i UI z fragmentami kodu.
* [ColorKit](https://colorkit.co/) - Twórz palety kolorów online lub czerp inspirację z najlepszych palet.
* [coolors](https://coolors.co/) - Generator palet kolorystycznych. Darmowy.
* [CMYK Pantone](https://www.cmyktopantone.com/) - Szybko konwertuj wartości CMYK na najbliższe kolory Pantone i inne modele kolorów. Za darmo.
* [Branition](https://branition.com/colors) - Ręcznie dobierane palety kolorów najlepiej dopasowane do marek.
* [css-gradient.com](https://www.css-gradient.com/) - Darmowe narzędzie do szybkiego generowania własnych gradientów CSS na wszystkie przeglądarki. W formacie RGB i HEX.
* [easyvectors.com](https://easyvectors.com/) — EasyVectors.com to darmowy stock wektorów SVG. Pobierz najlepsze grafiki wektorowe całkowicie za darmo.
* [figma.com](https://www.figma.com) — Online’owe narzędzie do projektowania zespołowego; darmowy poziom obejmuje nieograniczone pliki i widzów, maks. 2 edytorów i trzy projekty.
* [Flyon UI](https://flyonui.com/)- Najprostsza biblioteka komponentów dla Tailwind CSS.
* [framer.com](https://www.framer.com/) - Framer pomaga iterować i animować pomysły interfejsów dla twojej aplikacji, strony lub produktu – z potężnymi układami. Dla każdego, kto testuje Framer jako profesjonalne narzędzie do prototypowania: nieograniczeni widzowie, do 2 edytorów i do 3 projektów.
* [freeforcommercialuse.net](https://freeforcommercialuse.net/) — FFCU zdjęcia stockowe z gwarancją modeli/nieruchomości do użytku komercyjnego.
* [Gradientos](https://www.gradientos.app) - Szybkie i łatwe wybieranie gradientów.
* [Icon Horse](https://icon.horse) – Uzyskaj najwyższą rozdzielczość faviconu dla dowolnej strony przez proste API.
* [Iconoir](https://iconoir.com) – Otwartoźródłowa biblioteka ikon z tysiącami ikon, wsparcie dla React, React Native, Flutter, Vue, Figma i Framer.
* [Icons8](https://icons8.com) — Ikony, ilustracje, zdjęcia, muzyka i narzędzia do projektowania. Darmowy plan oferuje ograniczone formaty w niższej rozdzielczości. Podaj link do Icons8, gdy używasz ich zasobów.
* [landen.co](https://www.landen.co) — Generuj, edytuj i publikuj piękne strony i landing page dla swojego startupu. Bez kodowania. Darmowy poziom pozwala na jedną stronę, w pełni konfigurowalną i opublikowaną w sieci.
* [Quant Ux](https://quant-ux.com/) - Quant Ux to narzędzie do prototypowania i projektowania. Całkowicie darmowe i otwartoźródłowe.
* [lensdump.com](https://lensdump.com/) - Darmowy hosting zdjęć w chmurze.
* [Lorem Picsum](https://picsum.photos/) - Darmowe, łatwe w użyciu, stylowe placeholdery zdjęć. Po URL dodaj żądany rozmiar obrazka (szerokość i wysokość), a otrzymasz losowy obrazek.
* [LottieFiles](https://lottiefiles.com/) - Największa na świecie platforma dla najmniejszego formatu animacji dla projektantów, deweloperów i innych. Dostęp do narzędzi i pluginów Lottie dla Android, iOS i Web.
* [MagicPattern](https://www.magicpattern.design/tools) — Kolekcja generatorów i narzędzi CSS & SVG do gradientów, wzorów i plam.
* [marvelapp.com](https://marvelapp.com/) — Projektowanie, prototypowanie i współpraca, darmowy plan ograniczony do jednego użytkownika i projektu.
* [Mindmup.com](https://www.mindmup.com/) — Nielimitowane mapy myśli za darmo i przechowywanie ich w chmurze. Mapy myśli dostępne wszędzie, od razu, na każdym urządzeniu.
* [Mockplus iDoc](https://www.mockplus.com/idoc) - Mockplus iDoc to potężne narzędzie do współpracy projektowej i przekazywania projektów do wdrożenia. Darmowy plan obejmuje trzech użytkowników i pięć projektów ze wszystkimi funkcjami.
* [mockupmark.com](https://mockupmark.com/create/free) — Twórz realistyczne mockupy koszulek i odzieży na media społecznościowe i e-commerce, 40 darmowych mockupów.
* [Mossaik](https://mossaik.app) - Darmowy generator obrazów SVG z narzędziami do fal, plam i wzorów.
* [movingpencils.com](https://movingpencils.com) — Szybki edytor wektorowy w przeglądarce. Całkowicie darmowy.
* [Octopus.do](https://octopus.do) — Wizualny kreator map stron. Buduj strukturę strony w czasie rzeczywistym i szybko udostępniaj do współpracy z zespołem lub klientami.
* [Pencil](https://github.com/evolus/pencil) - Otwartoźródłowe narzędzie do projektowania oparte na Electronie.
* [Penpot](https://penpot.app) - Webowe, otwartoźródłowe narzędzie do projektowania i prototypowania. Obsługuje SVG. Całkowicie darmowe.
* [pexels.com](https://www.pexels.com/) - Darmowe zdjęcia stockowe do użytku komercyjnego. Darmowe API umożliwia wyszukiwanie zdjęć po słowach kluczowych.
* [photopea.com](https://www.photopea.com) — Darmowy, zaawansowany edytor online z interfejsem Adobe Photoshop, obsługuje PSD, XCF i Sketch (Adobe Photoshop, Gimp i Sketch App).
* [pixlr.com](https://pixlr.com/) — Darmowy edytor online na poziomie komercyjnym.
* [Plasmic](https://www.plasmic.app/) - Szybkie, proste i solidne narzędzie do projektowania stron i komponentów, które integruje się z kodem. Twórz responsywne strony lub złożone komponenty, opcjonalnie rozszerzając je kodem, oraz publikuj na produkcji.
* [Pravatar](https://pravatar.cc/) - Generuj losowe/fake awatary, których URL można bezpośrednio osadzić w swojej aplikacji/stronie.
* [Proto.io](https://www.proto.io) - Twórz w pełni interaktywne prototypy UI bez kodowania. Darmowy poziom jest dostępny po zakończeniu okresu próbnego. Obejmuje jednego użytkownika, jeden projekt, pięć prototypów, 100MB przestrzeni online i podgląd w aplikacji proto.io.
* [resizeappicon.com](https://resizeappicon.com/) — Prosta usługa do zmiany rozmiaru i zarządzania ikonami aplikacji.
* [Rive](https://rive.app) — Twórz i publikuj piękne animacje na każdą platformę. Darmowe na zawsze dla osób prywatnych. Edytor i hosting grafik na ich serwerach. Dostępne również runtime’y na wiele platform.
* [storyset.com](https://storyset.com/) — Twórz niesamowite, spersonalizowane ilustracje do swojego projektu.
* [smartmockups.com](https://smartmockups.com/) — Twórz mockupy produktów, 200 darmowych mockupów.
* [Shadcn Studio](https://shadcnstudio.com/theme-editor) — Podglądaj zmiany motywu na różnych komponentach i layoutach.
* [Tailark](https://tailark.com/) - Zbiór nowoczesnych, responsywnych, gotowych bloków UI do stron marketingowych.
* [tabler-icons.io](https://tabler-icons.io/) — Ponad 1500 darmowych, edytowalnych ikon SVG do kopiowania i wklejania.
* [tweakcn](https://tweakcn.com/) — Piękne motywy dla shadcn/ui. Dostosuj kolory, typografię i więcej w czasie rzeczywistym.
* [UI Avatars](https://ui-avatars.com/) - Generuj awatary z inicjałami imienia i nazwiska. URL można bezpośrednio osadzić w aplikacji/stronie. Obsługuje parametry konfiguracyjne przez URL.
* [unDraw](https://undraw.co/) - Stale aktualizowana kolekcja pięknych obrazów SVG, które możesz używać całkowicie za darmo bez atrybucji.
* [unsplash.com](https://unsplash.com/) - Darmowe zdjęcia stockowe do użytku komercyjnego i niekomercyjnego (licencja do-whatever-you-want).
* [vectr.com](https://vectr.com/) — Darmowa aplikacja do projektowania na web i desktop.
* [walkme.com](https://www.walkme.com/) — Platforma klasy enterprise do prowadzenia użytkownika i angażowania, darmowy plan: trzy przewodniki po 5 kroków.
* [Webflow](https://webflow.com) - Kreator stron typu WYSIWYG z animacjami i hostingiem. Dwa projekty za darmo.
* [Updrafts.app](https://updrafts.app) - Kreator stron WYSIWYG dla projektów opartych na tailwindcss. Darmowy do użytku niekomercyjnego.
* [whimsical.com](https://whimsical.com/) - Współdzielone flowcharty, wireframe’y, karteczki i mapy myśli. Do 4 darmowych tablic.
* [Zeplin](https://zeplin.io/) — Platforma współpracy projektantów i programistów. Udostępnia projekty, zasoby i przewodniki po stylach. Darmowy dla jednego projektu.
* [Pixelixe](https://pixelixe.com/) — Twórz i edytuj online angażujące, unikalne grafiki i obrazy.
* [Responsively App](https://responsively.app) - Darmowe narzędzie dla deweloperów do szybszego i precyzyjniejszego tworzenia responsywnych aplikacji webowych.
* [SceneLab](https://scenelab.io) - Edytor mockupów online z stale rosnącą kolekcją darmowych szablonów graficznych.
* [xLayers](https://xlayers.dev) - Podglądaj i konwertuj pliki projektów Sketch do Angular, React, Vue, LitElement, Stencil, Xamarin i innych (darmowy i otwartoźródłowy na https://github.com/xlayers/xlayers)
* [Grapedrop](https://grapedrop.com/) — Responsywny, wydajny, SEO-friendly kreator stron oparty na GrapesJS Framework. Za darmo do pięciu stron, nieograniczone własne domeny, wszystkie funkcje, prosta obsługa.
* [Mastershot](https://mastershot.app) - Całkowicie darmowy edytor wideo w przeglądarce. Bez znaku wodnego, eksport do 1080p.
* [Unicorn Platform](https://unicornplatform.com/) - Prostota w budowie landing page z hostingiem. Jedna strona za darmo.
* [SVGmix.com](https://www.svgmix.com/) - Ogromne repozytorium ponad 300 000 darmowych ikon SVG, kolekcji i logotypów marek. Prosty edytor wektorów w przeglądarce do szybkiej edycji plików.
* [svgrepo.com](https://www.svgrepo.com/) - Przeglądaj, wyszukuj i znajdź najlepiej dopasowane ikony lub wektory do swoich projektów z różnych bibliotek. Pobieraj darmowe wektory SVG do zastosowań komercyjnych.
* [haikei.app](https://www.haikei.app/) - Aplikacja webowa do generowania unikalnych kształtów, tł i wzorów SVG – gotowych do użycia w narzędziach projektowych i workflow.
* [Canva](https://canva.com) - Darmowe narzędzie online do projektowania treści wizualnych.
* [Superdesigner](https://superdesigner.co) - Kolekcja darmowych narzędzi do tworzenia unikalnych teł, wzorów, kształtów, obrazów i więcej w kilka kliknięć.
* [TeleportHQ](https://teleporthq.io/) - Low-code platforma do projektowania i rozwoju frontendu. TeleportHQ to współdzielona platforma do natychmiastowego tworzenia i publikowania statycznych stron headless. Trzy darmowe projekty, nieograniczeni współpracownicy, darmowy eksport kodu.
* [vector.express](https://vector.express) — Szybko i łatwo konwertuj swoje pliki AI, CDR, DWG, DXF, EPS, HPGL, PDF, PLT, PS i SVG.
* [Vertopal](https://www.vertopal.com) - Darmowa platforma online do konwertowania plików na różne formaty. W tym konwertery deweloperskie jak JPG do SVG, GIF do APNG, PNG do WEBP, JSON do XML itd.
* [okso.app](https://okso.app) - Minimalistyczna aplikacja do rysowania online. Umożliwia szybkie szkicowanie i tworzenie notatek wizualnych. Eksport szkiców do PNG, JPG, SVG i WEBP. Możliwość instalacji jako PWA. Darmowa dla wszystkich (bez rejestracji).
* [Wdrfree SVG](https://wdrfree.com/free-svg) - Darmowe czarno-białe pliki SVG do cięcia.
* [Lucide](https://lucide.dev) - Darmowy, konfigurowalny i spójny zestaw ikon SVG.
* [Logo.dev](https://www.logo.dev) - API do logotypów firm z 44+ mln marek, łatwe jak wywołanie URL. Pierwsze 10 000 zapytań API za darmo.
* [MDBootstrap](https://mdbootstrap.com/) - Darmowe do użytku osobistego i komercyjnego UI Kity dla Bootstrap, Angular, React i Vue z ponad 700 komponentami, szablonami, szybką instalacją, rozbudowanymi tutorialami i wielką społecznością.
* [TW Elements](https://tw-elements.com/) - Darmowe komponenty Bootstrap odtworzone w Tailwind CSS, z lepszym designem i większą funkcjonalnością.
* [DaisyUI](https://daisyui.com/) -- Darmowe. „Używaj Tailwind CSS, ale pisz mniej klas” – oferuje komponenty jak przyciski.
  * [Scrollbar.app](https://scrollbar.app) -- Prosta, darmowa aplikacja webowa do projektowania niestandardowych pasków przewijania dla stron internetowych.
  * [css.glass](https://css.glass/) -- Darmowa aplikacja webowa do tworzenia projektów glassmorphism z użyciem CSS.
  * [hypercolor.dev](https://hypercolor.dev/) -- Wyselekcjonowana kolekcja gradientów kolorów Tailwind CSS, a także różne generatory do tworzenia własnych.
  * [iconify.design](https://icon-sets.iconify.design/) -- Kolekcja ponad 100 paczek ikon z jednolitym interfejsem. Umożliwia wyszukiwanie ikon w różnych paczkach oraz eksportowanie pojedynczych ikon jako SVG lub do popularnych frameworków webowych.
  * [NextUI](https://nextui.org/) -- Darmowa. Piękna, szybka i nowoczesna biblioteka UI dla React & Next.js.
  * [Glyphs](https://glyphs.fyi/) -- Darmowa, Najpotężniejsze Ikony w Internecie, w pełni edytowalny i prawdziwie otwarty system projektowania.
  * [ShadcnUI](https://ui.shadcn.com/) -- Pięknie zaprojektowane komponenty, które możesz kopiować i wklejać do swoich aplikacji. Dostępne. Konfigurowalne. Open Source.
  * [HyperUI](https://www.hyperui.dev/) -- Darmowe, otwartoźródłowe komponenty Tailwind CSS.
  * [Calendar Icons Generator](https://calendariconsgenerator.app/) -- Wygeneruj zestaw unikalnych ikon na cały rok za jednym kliknięciem, całkowicie ZA DARMO.
  * [Image BG Blurer](https://imagebgblurer.com/) -- Generuj rozmyte tło dla obrazu, wykorzystując ten obraz jako źródło rozmycia tła, dla Notion, Trello, Jira i innych narzędzi.
  * [Webstudio](https://webstudio.is/) -- Otwarty zamiennik Webflow. Darmowy plan oferuje nielimitowaną liczbę stron na ich domenie. Pięć stron z własną domeną. Dziesięć tysięcy wyświetleń stron/miesiąc. 2 GB przestrzeni na zasoby.
  * [Nappy](https://nappy.co/) -- Piękne zdjęcia osób czarnoskórych i brązowych, za darmo. Do użytku komercyjnego i osobistego.
  * [Tailkits](https://tailkits.com/) -- Wyselekcjonowana kolekcja szablonów, komponentów i narzędzi Tailwind oraz przydatnych generatorów do kodu, siatek, cieni pudełkowych i nie tylko.
  * [Tailcolors](https://tailcolors.com/) -- Piękna paleta kolorów Tailwind CSS v4. Natychmiastowy podgląd i kopiowanie idealnej klasy kolorów Tailwind CSS.
  * [Excalidraw](https://excalidraw.com/) -- Darmowa, internetowa aplikacja do rysowania z możliwością zapisu lokalnego i eksportu.
  * [Lunacy](https://icons8.com/lunacy) -- Darmowe narzędzie do projektowania grafiki z obsługą offline, wbudowanymi zasobami (ikony, zdjęcia, ilustracje) oraz współpracą w czasie rzeczywistym. Darmowy pakiet obejmuje 10 dokumentów w chmurze, historię 30 dni, zasoby w niskiej rozdzielczości i podstawowe narzędzia projektowe.

**[⬆️ Powrót na górę](#table-of-contents)**

## Inspiracje projektowe

  * [awwwards.](https://www.awwwards.com/) - [Najlepsze strony internetowe] Galeria najlepiej zaprojektowanych stron internetowych (oceniana przez projektantów).
  * [Behance](https://www.behance.net/) - [Galeria projektów] Miejsce, gdzie projektanci prezentują swoje prace. Możliwość filtrowania według kategorii projektów UI/UX.
  * [dribbble](https://dribbble.com/) - [Galeria projektów] Unikalne inspiracje projektowe, zazwyczaj nie pochodzące z rzeczywistych aplikacji.
  * [Landings](https://landings.dev/) - [Zrzuty ekranów stron] Znajdź najlepsze strony docelowe dla swojej inspiracji projektowej na podstawie własnych preferencji.
  * [Lapa Ninja](https://www.lapa.ninja/) - [Strony docelowe / zestawy UI / zrzuty ekranów stron] Lapa Ninja to galeria prezentująca najlepsze 6025 przykłady stron docelowych, darmowe książki dla projektantów i darmowe zestawy UI z całego internetu.
  * [LovelyLanding.net](https://www.lovelylanding.net/) - [Projekty stron docelowych] Często aktualizowane zrzuty ekranów stron docelowych. Obejmuje zrzuty dla komputerów, tabletów i urządzeń mobilnych.
  * [Mobbin](https://mobbin.design/) - [Zrzuty ekranów aplikacji mobilnych] Oszczędzaj godziny badań UI & UX dzięki naszej bibliotece ponad 50 000 w pełni przeszukiwalnych zrzutów ekranów aplikacji mobilnych.
  * [Uiland Design](https://uiland.design/) - [Zrzuty ekranów aplikacji mobilnych] Odkrywaj projekty UI mobilnych i webowych od czołowych firm w Afryce i na świecie.
  * [Mobile Patterns](https://www.mobile-patterns.com/) - [Zrzuty ekranów aplikacji mobilnych] Biblioteka inspiracji projektowych prezentująca najlepsze wzorce UI/UX (iOS i Android) dla projektantów, programistów i twórców produktów.
  * [Page Flows](https://pageflows.com/) - [Wideo i zrzuty ekranów aplikacji mobilnych/webowych] Wideo pełnych przepływów w wielu aplikacjach mobilnych i internetowych. Zawiera także zrzuty ekranów. Wysoka przeszukiwalność i indeksacja.
  * [Screenlane](https://screenlane.com/) - [Zrzuty ekranów aplikacji mobilnych] Inspiruj się i śledź najnowsze trendy UI projektowania stron i aplikacji mobilnych. Możliwość filtrowania po wzorcu i aplikacji.
  * [scrnshts](https://scrnshts.club/) - [Zrzuty ekranów aplikacji mobilnych] Ręcznie wybrana kolekcja najlepszych zrzutów ekranów projektów z App Store.
  * [Refero](https://refero.design/) - [Zrzuty ekranów stron] Otagowana i przeszukiwalna kolekcja inspiracji projektowych z najlepszych aplikacji webowych.

**[⬆️ Powrót na górę](#table-of-contents)**

## Wizualizacja danych na mapach

  * [IP Geolocation](https://ipgeolocation.io/) — Dostępny darmowy plan DEVELOPER z limitem 30 000 zapytań/miesiąc.
  * [carto.com](https://carto.com/) — Tworzenie map i API geoprzestrzennych z własnych oraz publicznych danych.
  * [Clockwork Micro](https://clockworkmicro.com/) — Narzędzia mapowe działające jak w zegarku. Pięćdziesiąt tysięcy darmowych zapytań miesięcznie (płytki map, db2vector, wysokość).
  * [developers.arcgis.com](https://developers.arcgis.com) — API i SDK do map, przechowywania danych geoprzestrzennych, analizy, geokodowania, trasowania i innych na web, desktop i mobile. Dwa miliony darmowych płytek map bazowych, 20 000 nieprzechowywanych geokodów, 20 000 prostych tras, 5 000 obliczeń czasu przejazdu, 5GB darmowego miejsca na płytki+dane miesięcznie.
  * [Foursquare](https://developer.foursquare.com/) - Odkrywanie lokalizacji, wyszukiwanie miejsc i kontekstowe treści z Places API i Pilgrim SDK.
  * [geoapify.com](https://www.geoapify.com/) - Płytki map wektorowych i rastrowych, geokodowanie, miejsca, trasowanie, API izolinii. Trzy tysiące darmowych zapytań dziennie.
  * [geocod.io](https://www.geocod.io/) — Geokodowanie przez API lub przesyłanie plików CSV. Dwa i pół tysiąca darmowych zapytań dziennie.
  * [geocodify.com](https://geocodify.com/) — Geokodowanie i geoparsowanie przez API lub CSV. 10 tys. darmowych zapytań miesięcznie.
  * [geojs.io](https://www.geojs.io/) - Wysoko dostępne REST/JSON/JSONP API do geolokalizacji IP.
  * [giscloud.com](https://www.giscloud.com/) — Wizualizacja, analiza i udostępnianie danych geoprzestrzennych online.
  * [graphhopper.com](https://www.graphhopper.com/) Oferowany jest darmowy pakiet deweloperski dla trasowania, optymalizacji tras, macierzy odległości, geokodowania i dopasowania trasy do mapy.
  * [here](https://developer.here.com/) — API i SDK do map oraz aplikacji lokalizacyjnych. 250 000 transakcji/miesiąc za darmo.
  * [locationiq.com](https://locationiq.com/) — API geokodowania, map i trasowania. Pięć tysięcy darmowych zapytań dziennie.
  * [mapbox.com](https://www.mapbox.com/) — Mapy, usługi geoprzestrzenne i SDK do wyświetlania danych mapowych.
  * [maptiler.com](https://www.maptiler.com/cloud/) — Mapy wektorowe, usługi mapowe i SDK do wizualizacji map. Darmowe płytki wektorowe z cotygodniowymi aktualizacjami oraz cztery style map.
  * [nominatim.org](https://nominatim.org/) — Darmowa usługa geokodowania OpenStreetMap, zapewniająca globalne wyszukiwanie adresów i możliwości odwrotnego geokodowania.
  * [nextbillion.ai](https://nextbillion.ai/) - Usługi związane z mapami: geokodowanie, nawigacja (wyznaczanie tras, optymalizacja, macierz odległości), SDK map (wektor, statyczne, SDK mobilne). [Darmowa pula](https://nextbillion.ai/pricing) określona dla każdej usługi.
  * [opencagedata.com](https://opencagedata.com) — API geokodowania agregujące OpenStreetMap i inne otwarte źródła geo. Dwa i pół tysiąca darmowych zapytań dziennie.
  * [osmnames](https://osmnames.org/) — Geokodowanie, wyniki wyszukiwania sortowane według popularności powiązanej strony Wikipedii.
  * [positionstack](https://positionstack.com/) - Darmowe geokodowanie miejsc i współrzędnych na całym świecie. 25 000 zapytań miesięcznie do użytku osobistego.
  * [stadiamaps.com](https://stadiamaps.com/) — Płytki map, trasowanie, nawigacja i inne API geoprzestrzenne. Dwa i pół tysiąca darmowych wyświetleń map i zapytań API dziennie do użytku niekomercyjnego i testów.
  * [maps.stamen.com](http://maps.stamen.com/) - Darmowe płytki map i hosting płytek.
  * [ipstack](https://ipstack.com/) - Lokalizuj i identyfikuj odwiedzających stronę internetową po adresie IP.
  * [Geokeo api](https://geokeo.com) - API geokodowania z korekcją językową i innymi funkcjami. Zasięg ogólnoświatowy. 2 500 darmowych zapytań dziennie.

**[⬆️ Powrót na górę](#table-of-contents)**

## Systemy budowania pakietów

  * [build.opensuse.org](https://build.opensuse.org/) — Usługa budowania pakietów dla wielu dystrybucji (SUSE, EL, Fedora, Debian itd.).
  * [copr.fedorainfracloud.org](https://copr.fedorainfracloud.org) — Usługa budowania RPM oparta na Mock dla Fedory i EL.
  * [help.launchpad.net](https://help.launchpad.net/Packaging) — Usługa budowania pakietów dla Ubuntu i Debiana.

**[⬆️ Powrót na górę](#table-of-contents)**

## IDE i edytory kodu

  * [3v4l](https://3v4l.org/) - Darmowa, internetowa powłoka PHP i miejsce do udostępniania fragmentów kodu, która uruchamia Twój kod w ponad 300 wersjach PHP.
  * [Android Studio](https://developer.android.com/studio) — Android Studio zapewnia najszybsze narzędzia do budowania aplikacji na każdy typ urządzenia z Androidem. Otwarty kod źródłowy IDE, darmowy dla wszystkich, najlepszy do tworzenia aplikacji Android. Dostępny dla Windows, Mac, Linux, a nawet ChromeOS!
  * [AndroidIDE](https://m.androidide.com/) — Otwarty IDE do tworzenia prawdziwych aplikacji Android opartych o Gradle na urządzeniach z Androidem.
  * [Apache Netbeans](https://netbeans.apache.org/) — Środowisko programistyczne, platforma narzędziowa i framework aplikacji.
  * [apiary.io](https://apiary.io/) — Współdzielone projektowanie API z natychmiastowym mockiem API i generowaną dokumentacją (darmowe dla nieograniczonej liczby blueprintów API i użytkowników z jednym kontem administratora oraz hostowaną dokumentacją).
  * [BBEdit](https://www.barebones.com/) - BBEdit to popularny i rozbudowywalny edytor dla macOS. Darmowy tryb oferuje [potężny zestaw funkcji podstawowych](https://www.barebones.com/products/bbedit/comparison.html) oraz możliwość aktualizacji do zaawansowanych opcji.
  * [Binder](https://mybinder.org/) - Zamień repozytorium Git w kolekcję interaktywnych notatników. Darmowa usługa publiczna.
  * [BlueJ](https://bluej.org) — Darmowe środowisko programistyczne Java stworzone z myślą o początkujących, używane przez miliony na całym świecie. Wspierane przez Oracle, proste GUI dla początkujących.
  * [Bootify.io](https://bootify.io/) - Generator aplikacji Spring Boot z własną bazą danych i REST API.
  * [Brackets](http://brackets.io/) - Brackets to otwartoźródłowy edytor tekstu zaprojektowany specjalnie do web developmentu. Lekki, łatwy w użyciu i wysoce konfigurowalny.
  * [cacher.io](https://www.cacher.io) — Organizator fragmentów kodu z etykietami i obsługą ponad 100 języków programowania.
  * [Code::Blocks](https://codeblocks.org) — Darmowe IDE Fortran i C/C++. Open Source, działa na Windows, macOS i Linux.
  * [Cody](https://sourcegraph.com/cody) - Darmowy asystent AI do kodowania, który potrafi pisać (bloki kodu, podpowiedzi, testy jednostkowe), rozumieć (zna cały Twój kod), poprawiać i znajdować kod. Dostępny dla VS Code, JetBrains i online.
  * [codiga.io](https://codiga.io/) — Asystent kodowania umożliwiający wyszukiwanie, definiowanie i ponowne wykorzystanie fragmentów kodu bezpośrednio w IDE. Darmowy dla osób indywidualnych i małych organizacji.
  * [codesnip.com.br](https://codesnip.com.br) — Prosty menedżer fragmentów kodu z kategoriami, wyszukiwarką i tagami. Darmowy i nielimitowany.
  * [cocalc.com](https://cocalc.com/) — (dawniej SageMathCloud na cloud.sagemath.com) — Współdzielone obliczenia w chmurze. Dostęp przez przeglądarkę do pełnego Ubuntu z wbudowaną współpracą i wieloma darmowymi programami do matematyki, nauki, data science, preinstalowane: Python, LaTeX, Jupyter Notebooks, SageMath, scikitlearn itd.
  * [code.cs50.io](https://code.cs50.io/) - Visual Studio Code dla CS50 to aplikacja webowa code.cs50.io, która adaptuje GitHub Codespaces dla studentów i nauczycieli.
  * [codepen.io](https://codepen.io/) — CodePen to plac zabaw dla frontendowej części webu.
  * [codesandbox.io](https://codesandbox.io/) — Internetowy plac zabaw dla React, Vue, Angular, Preact i innych.
  * [Components.studio](https://webcomponents.dev/) - Programuj komponenty w izolacji, wizualizuj je w historiach, testuj i publikuj na npm.
  * [Eclipse Che](https://www.eclipse.org/che/) - Webowe i natywne dla Kubernetes IDE dla zespołów deweloperskich z obsługą wielu języków. Otwarte źródło i społeczność. Wersja online hostowana przez Red Hat dostępna na [workspaces.openshift.com](https://workspaces.openshift.com/).
  * [fakejson.com](https://fakejson.com/) — FakeJSON pozwala szybko generować fałszywe dane przez API. Wystarczy wysłać żądanie API opisujące, co i jak chcesz. API zwróci wszystko w JSON. Przyspiesz wdrożenie pomysłów i udawaj, póki się nie uda.
  * [GetVM](https://getvm.io) — Natychmiastowy, darmowy Linux i IDE w pasku bocznym Chrome. Darmowy pakiet obejmuje 5 maszyn wirtualnych dziennie.
  * [GitPod](https://www.gitpod.io) — Natychmiastowe, gotowe do kodowania środowiska deweloperskie dla projektów GitHub. Darmowy poziom obejmuje 50 godzin/miesiąc.
  * [ide.goorm.io](https://ide.goorm.io) goormIDE to pełne IDE w chmurze. Wsparcie dla wielu języków, kontenery oparte na Linuksie przez w pełni funkcjonalny terminal webowy, przekierowanie portów, niestandardowy URL, współpraca i czat w czasie rzeczywistym, udostępnianie linku, wsparcie dla Git/Subversion. Wiele innych funkcji (Darmowy poziom obejmuje 1GB RAM i 10GB miejsca na kontener, 5 slotów kontenerów).
  * [JDoodle](https://www.jdoodle.com) — Kompilator online i edytor dla ponad 60 języków programowania z darmowym planem na kompilowanie kodu przez REST API do 200 kredytów dziennie.
  * [jetbrains.com](https://jetbrains.com/products.html) — Narzędzia produktywnościowe, IDE i narzędzia do wdrażania (np. [IntelliJ IDEA](https://www.jetbrains.com/idea/), [PyCharm](https://www.jetbrains.com/pycharm/) i inne). Darmowa licencja dla studentów, nauczycieli, projektów Open Source i grup użytkowników.
  * [jsbin.com](https://jsbin.com) — JS Bin to kolejny playground i serwis do dzielenia się kodem front-end (HTML, CSS i JavaScript. Obsługuje też Markdown, Jade i Sass).
  * [jsfiddle.net](https://jsfiddle.net/) — JS Fiddle to playground i serwis do dzielenia się kodem front-end, wspierający współpracę.
  * [JSONPlaceholder](https://jsonplaceholder.typicode.com/) Kilka endpointów REST API zwracających przykładowe dane w formacie JSON. Kod źródłowy jest również dostępny, jeśli chcesz uruchomić serwer lokalnie.
  * [Lazarus](https://www.lazarus-ide.org/) — Lazarus to kompatybilne z Delphi, wieloplatformowe IDE do szybkiego tworzenia aplikacji (Rapid Application Development).
  * [MarsCode](https://www.marscode.com/) - Darmowe, oparte na AI środowisko IDE w chmurze.
  * [micro-jaymock](https://micro-jaymock.now.sh/) - Lekki mikroserwis do mockowania API i generowania fałszywych danych JSON.
  * [mockable.io](https://www.mockable.io/) — Mockable to prosta, konfigurowalna usługa do mockowania RESTful API lub usług webowych SOAP. Umożliwia szybkie definiowanie endpointów REST API lub SOAP i zwracanie danych w formacie JSON lub XML.
  * [mockaroo](https://mockaroo.com/) — Mockaroo pozwala generować realistyczne dane testowe w formatach CSV, JSON, SQL i Excel. Możesz też tworzyć mocki dla API backendowych.
  * [Mocklets](https://mocklets.com) - symulator mock API oparty o HTTP, który pomaga symulować API dla szybszego, równoległego developmentu i bardziej kompleksowych testów, z wieczystym darmowym poziomem.
  * [Paiza](https://paiza.cloud/en/) — Tworzenie aplikacji webowych w przeglądarce bez konieczności konfiguracji. Darmowy plan oferuje jeden serwer z 24-godzinnym czasem życia i 4 godziny działania dziennie z 2 rdzeniami CPU, 2 GB RAM i 1 GB miejsca.
  * [Prepros](https://prepros.io/) - Prepros kompiluje Sass, Less, Stylus, Pug/Jade, Haml, Slim, CoffeeScript i TypeScript "out of the box", automatycznie odświeża przeglądarki i ułatwia rozwój oraz testowanie stron, abyś mógł skupić się na ich doskonaleniu. Możliwość dodawania własnych narzędzi kilkoma kliknięciami.
  * [Replit](https://replit.com/) — Środowisko kodowania w chmurze dla różnych języków programowania.
  * [SoloLearn](https://code.sololearn.com) — Playground programistyczny w chmurze, idealny do uruchamiania fragmentów kodu. Obsługuje wiele języków programowania. Rejestracja nie jest wymagana do uruchamiania kodu, ale konieczna przy zapisywaniu kodu na platformie. Oferuje też darmowe kursy dla początkujących i średniozaawansowanych.
  * [stackblitz.com](https://stackblitz.com/) — Online/Cloud Code IDE do tworzenia, edycji i wdrażania aplikacji full-stack. Wspiera wszystkie popularne frontendowe i backendowe frameworki oparte na NodeJs. Krótki link do tworzenia nowego projektu: [https://node.new](https://node.new).
  * [Sublime Text](https://www.sublimetext.com/) - Sublime Text to popularny, wszechstronny i wysoce konfigurowalny edytor tekstu używany do kodowania i edycji tekstu.
  * [Visual Studio Code](https://code.visualstudio.com/) - Edytor kodu zrewolucjonizowany i zoptymalizowany pod kątem budowania i debugowania nowoczesnych aplikacji webowych i chmurowych. Opracowany przez Microsoft.
  * [Visual Studio Community](https://visualstudio.microsoft.com/vs/community/) — Pełne IDE z tysiącami rozszerzeń, tworzeniem aplikacji wieloplatformowych (dostępne rozszerzenia Microsoft do pobrania dla iOS i Androida), desktop, web i chmura, wsparcie dla wielu języków (C#, C++, JavaScript, Python, PHP i inne).
  * [VSCodium](https://vscodium.com/) - Dystrybucja binarna edytora VSCode, napędzana przez społeczność, bez telemetrii/śledzenia i na wolnej licencji.
  * [wakatime.com](https://wakatime.com/) — Zautomatyzowane statystyki o aktywności programistycznej przy użyciu pluginów do edytorów tekstu, ograniczony darmowy plan.
  * [Wave Terminal](https://waveterm.dev/) - Wave to otwartoźródłowy, wieloplatformowy terminal dla płynnych workflow. Renderowanie dowolnych treści inline. Zapisywanie sesji i historii. Napędzany przez otwarte standardy webowe. MacOS i Linux.
  * [WebComponents.dev](https://webcomponents.dev/) — IDE w przeglądarce do kodowania web komponentów w izolacji, z 58 dostępnymi szablonami, wsparciem dla historii i testów.
  * [PHPSandbox](https://phpsandbox.io/) — Środowisko deweloperskie online dla PHP
  * [WebDB](https://webdb.app) - Darmowe, wydajne IDE do baz danych. Obejmuje wykrywanie serwerów, ERD, generator danych, AI, menedżer struktur NoSQL, wersjonowanie bazy i wiele innych.
  * [Zed](https://zed.dev/) - Zed to wydajny, wieloosobowy edytor kodu od twórców Atom i Tree-sitter.
  * [OneCompiler](https://onecompiler.com/) - Darmowy kompilator online obsługujący 70+ języków, w tym Java, Python, C++, JavaScript.


**[⬆️ Wróć na górę](#table-of-contents)**

## Analityka, Zdarzenia i Statystyki

  * [Dwh.dev](https://dwh.dev) - Rozwiązanie do obserwacji chmury danych (Snowflake). Darmowe do użytku osobistego.
  * [Hightouch](https://hightouch.com/) - Hightouch to platforma Reverse ETL, która pomaga synchronizować dane klientów z hurtowni danych do CRM, narzędzi marketingowych i wsparcia. Darmowy poziom umożliwia synchronizację do jednego miejsca docelowego.
  * [Avo](https://avo.app/) — Uproszczony workflow wydania analityki. Jednolite źródło prawdy dla planu śledzenia, typowany bezpieczny kod śledzenia, debugowanie w aplikacji i obserwacja danych, aby wyłapać wszystkie problemy przed wydaniem. Darmowe dla dwóch członków workspace i 1 godziny podglądu danych.
  * [Branch](https://www.branch.io) — Platforma analityki mobilnej. Darmowy poziom oferuje do 10 000 użytkowników aplikacji mobilnej z deep-linkingiem i innymi usługami.
  * [Census](https://www.getcensus.com/) — Platforma Reverse ETL & Operational Analytics. Synchronizuj 10 pól z hurtowni danych do 60+ SaaS jak Salesforce, Zendesk czy Amplitude.
  * [Clicky](https://clicky.com) — Platforma analityki stron WWW. Darmowy plan dla jednej strony z analizą 3000 odsłon.
  * [Databox](https://databox.com) — Wgląd biznesowy i analityka przez połączenie innych platform analitycznych i BI. Darmowy plan: 3 użytkowników, dashboardy i źródła danych. 11 mln rekordów danych historycznych.
  * [Hitsteps.com](https://hitsteps.com/) — 2 000 odsłon miesięcznie dla 1 strony
  * [amplitude.com](https://amplitude.com/) — 1 milion zdarzeń miesięcznie, do 2 aplikacji
  * [GoatCounter](https://www.goatcounter.com/) — GoatCounter to otwartoźródłowa platforma analityki stron WWW dostępna jako usługa hostowana (darmowa dla niekomercyjnego użytku) lub aplikacja self-hosted. Celem jest oferowanie łatwej w użyciu i znaczącej, przyjaznej prywatności alternatywy dla Google Analytics lub Matomo. Darmowy poziom dla niekomercyjnego użytku obejmuje nieograniczoną liczbę stron, 6 miesięcy przechowywania danych i 100 tys. odsłon/miesiąc.
  * [Google Analytics](https://analytics.google.com/) — Google Analytics
  * [MetricsWave](https://metricswave.com) — Przyjazna prywatności alternatywa Google Analytics dla deweloperów. Darmowy plan umożliwia 20 tys. odsłon miesięcznie bez karty kredytowej.
  * [Expensify](https://www.expensify.com/) — Raportowanie wydatków, darmowy workflow akceptacji raportów osobistych
  * [getinsights.io](https://getinsights.io) - Analityka bez cookies, z naciskiem na prywatność, darmowa do 3 tys. zdarzeń miesięcznie.
  * [heap.io](https://heap.io) — Automatycznie przechwytuje każde działanie użytkownika w aplikacjach iOS lub webowych. Darmowe do 10 tys. sesji miesięcznie.
  * [Hotjar](https://hotjar.com) — Analityka i raporty dla stron WWW. Darmowy plan umożliwia 2000 odsłon dziennie. Sto snapshotów dziennie (maksymalna pojemność: 300). Trzy snapshoty map cieplnych można przechowywać przez 365 dni. Nieograniczona liczba członków zespołu. W aplikacji i jako osobne ankiety, widgety feedbacku ze zrzutami ekranu. Darmowy poziom umożliwia utworzenie 3 ankiet i 3 widgetów feedbacku oraz zebranie 20 odpowiedzi miesięcznie.
  * [Keen](https://keen.io/) — Własna analityka do zbierania, analizy i wizualizacji danych. 1 000 zdarzeń/miesiąc darmowo
  * [Yandex.Datalens](https://datalens.yandex.com/) — Usługa wizualizacji i analizy danych w chmurze Yandex. Usługa jest darmowa. Bez ograniczeń liczby użytkowników i zapytań.
  * [Yandex.Metrica](https://metrica.yandex.com/) — Nielimitowana darmowa analityka
  * [Mixpanel](https://mixpanel.com/) — 100 000 miesięcznych śledzonych użytkowników, nieograniczona historia danych i miejsc, US lub EU data residency
  * [Moesif](https://www.moesif.com) — Analityka API dla REST i GraphQL. (Darmowo do 500 000 wywołań API/miesiąc)
  * [optimizely.com](https://www.optimizely.com) — Rozwiązanie do testów A/B, darmowy plan startowy, jedna strona, 1 aplikacja iOS i 1 aplikacja Android
  * [Microsoft PowerBI](https://powerbi.com) — Biznesowa analityka i raportowanie od Microsoft. Darmowy plan umożliwia ograniczone użycie z 1 milionem licencji użytkownika.
  * [Row Zero](https://rowzero.io) - Błyskawicznie szybki, połączony arkusz kalkulacyjny. Bezpośrednie połączenia z bazami danych, S3 i API. Import, analiza, wykresy i udostępnianie milionów wierszy natychmiast. Trzy darmowe (na zawsze) workbooki.
  * [sematext.com](https://sematext.com/cloud/) — Darmowe do 50 tys. akcji/miesiąc, 1 dzień przechowywania danych, nieograniczone dashboardy, użytkownicy itd.
  * [Similar Web](https://similarweb.com) — Analityka dla stron i aplikacji mobilnych. Darmowy plan oferuje pięć wyników na metrykę, miesiąc danych aplikacji mobilnej i 3 miesiące danych strony.
  * [StatCounter](https://statcounter.com/) — Analityka oglądalności stron. Darmowy plan dla 500 ostatnich użytkowników.
  * [Statsig](https://statsig.com) - Platforma all-in-one do analityki, feature flagów i testów A/B. Darmowa do 1 mln zdarzeń miesięcznie.
  * [Tableau Developer Program](https://www.tableau.com/developer) — Innowuj, twórz i dostosowuj Tableau do swojej organizacji. Darmowy program developerski daje osobistą licencję sandbox dla Tableau Online. Wersja to najnowszy pre-release, by Data Devs mogli testować każdą funkcję tej platformy.
  * [usabilityhub.com](https://usabilityhub.com/) — Testuj projekty i makiety na prawdziwych użytkownikach oraz śledź odwiedzających. Darmowe dla jednego użytkownika, nieograniczone testy
  * [woopra.com](https://www.woopra.com/) — Darmowa platforma analityki użytkowników: 500 tys. akcji, 90 dni przechowywania danych, 30+ integracji jednym kliknięciem.
  * [counter.dev](https://counter.dev) — Prosta i przyjazna prywatności analityka stron WWW. Darmowa lub na zasadzie "zapłać ile chcesz".
  * [PostHog](https://posthog.com) - Pełny pakiet analityki produktu darmowy do 1 mln śledzonych zdarzeń miesięcznie. Oferuje również nieograniczoną liczbę ankiet w aplikacji z 250 odpowiedziami/miesiąc.
  * [Uptrace](https://uptrace.dev) - Narzędzie do rozproszonego śledzenia pomagające programistom wykrywać błędy i wąskie gardła wydajnościowe. Ma darmowy plan, oferuje darmową subskrypcję Personal dla projektów open-source oraz wersję open-source.
  * [Microsoft Clarity](https://clarity.microsoft.com/) - Clarity to darmowe, proste narzędzie do podglądu, jak prawdziwi ludzie korzystają z Twojej strony.
  * [Beampipe.io](https://beampipe.io) - Beampipe to prosta, nastawiona na prywatność analityka stron WWW. Darmowa dla 5 domen i 10 tys. odsłon miesięcznie.
  * [Aptabase](https://aptabase.com) — Otwartoźródłowa, przyjazna prywatności i prosta analityka dla aplikacji mobilnych i desktopowych. SDK dla Swift, Kotlin, React Native, Flutter, Electron i wielu innych. Darmowa do 20 tys. zdarzeń miesięcznie.
  * [Trackingplan](https://www.trackingplan.com/) - Automatyczne wykrywanie problemów z analityką cyfrową, danymi marketingowymi i pikselami, utrzymanie aktualnych planów śledzenia, wspieranie płynnej współpracy. Wdrażaj na produkcji lub dodawaj pokrycie analityką do testów regresji bez pisania kodu.
  * [LogSpot](https://logspot.io) - Pełna, zunifikowana platforma analityki stron i produktu, w tym osadzane widgety analityczne i zautomatyzowane boty (Slack, Telegram, webhooks). Darmowy plan obejmuje 10 tys. zdarzeń miesięcznie.
  * [Umami](https://umami.is/) - Prosta, szybka, przyjazna prywatności, otwartoźródłowa alternatywa dla Google Analytics.
  * [TrackWith Dicloud](https://dicloud.net/trackwith-privacy-focused-analytics/) - Darmowa, lekka, przyjazna prywatności alternatywa dla Google Analytics. Nielimitowane odsłony, odwiedzający, mapy cieplne i śledzenie celów. Darmowo do 3 domen i 600 odtworzeń sesji na domenę.
  * [AppFit](https://appfit.io) - AppFit to kompleksowe narzędzie do analityki i zarządzania produktem, ułatwiające zarządzanie analityką i aktualizacjami produktu na wielu platformach. Darmowy plan obejmuje 10 tys. zdarzeń miesięcznie, dziennik produktu i tygodniowe podsumowania.
  * [Seline](https://seline.so) - Seline to prosta i prywatna analityka stron i produktu. Bez cookies, lekka, niezależna. Darmowy plan obejmuje 3 tys. zdarzeń miesięcznie i dostęp do wszystkich funkcji, takich jak dashboard, ścieżki użytkowników, leje konwersji i inne.
  * [Peasy](https://peasy.so) - Peasy to lekka, przyjazna prywatności analityka stron i produktów. Darmowy plan obejmuje 3 tys. zdarzeń miesięcznie.
  * [Rybbit](https://rybbit.io) - Otwartoźródłowa i bezciasteczkowa alternatywa dla Google Analytics, 10x bardziej intuicyjna. Darmowy plan obejmuje 3 tys. zdarzeń miesięcznie. 

**[⬆️ Wróć na górę](#table-of-contents)**

## Nagrywanie Sesji Odwiedzających

  * [Reactflow.com](https://www.reactflow.com/) — Na stronę: 1 000 odsłon/dzień, trzy mapy cieplne, trzy widgety, darmowy tracking błędów
  * [OpenReplay.com](https://www.openreplay.com) - Otwartoźródłowe odtwarzanie sesji z narzędziami developerskimi do odtwarzania błędów, wsparciem na żywo i pakietem analitycznym. 1 000 sesji/miesiąc z dostępem do wszystkich funkcji i 7-dniowym przechowywaniem.
  * [LogRocket.com](https://www.logrocket.com) - 1 000 sesji/miesiąc z 30-dniowym przechowywaniem, śledzeniem błędów, trybem live
  * [FullStory.com](https://www.fullstory.com) — 1 000 sesji/miesiąc z miesięcznym przechowywaniem danych i trzema miejscami użytkowników. Więcej informacji [tutaj](https://help.fullstory.com/hc/en-us/articles/360020623354-FullStory-Free-Edition).
  * [hotjar.com](https://www.hotjar.com/) — Na stronę: 1 050 odsłon/miesiąc, nieograniczone mapy cieplne, dane przechowywane przez trzy miesiące
  * [inspectlet.com](https://www.inspectlet.com/) — 2 500 sesji/miesiąc darmowo dla jednej strony
  * [Microsoft Clarity](https://clarity.microsoft.com/) - Nagrywanie sesji całkowicie darmowe, bez "limitów ruchu", bez limitów projektów i bez próbkowania
  * [mouseflow.com](https://mouseflow.com/) — 500 sesji/miesiąc darmowo dla jednej strony
  * [mousestats.com](https://www.mousestats.com/) — 100 sesji/miesiąc darmowo dla jednej strony
  * [smartlook.com](https://www.smartlook.com/) — darmowe pakiety dla stron www i aplikacji mobilnych (1 500 sesji/miesiąc), trzy mapy cieplne, jeden lejek, 1 miesiąc historii danych
  * [howuku.com](https://howuku.com) — Śledzenie interakcji użytkownika, zaangażowania i zdarzeń. Darmowe do 5 000 wizyt/miesiąc
  * [UXtweak.com](https://www.uxtweak.com/) — Nagrywaj i oglądaj jak odwiedzający korzystają z Twojej strony lub aplikacji. Darmowo, bez limitu czasu dla małych projektów

**[⬆️ Wróć na górę](#table-of-contents)**
## Międzynarodowa weryfikacja numerów telefonów API i SDK

  * [numverify](https://numverify.com/) — Globalna walidacja numerów telefonów i API do wyszukiwania w formacie JSON. 100 żądań API/miesiąc
  * [veriphone](https://veriphone.io/) — Globalna weryfikacja numerów telefonów w darmowym, szybkim i niezawodnym API JSON. 1000 żądań/miesiąc

**[⬆️ Powrót na górę](#table-of-contents)**

## Integracja płatności i rozliczeń

  * [Qonversion](http://qonversion.io/) - Kompleksowa, wieloplatformowa platforma do zarządzania subskrypcjami, oferująca analitykę, testy A/B, Apple Search Ads, zdalną konfigurację oraz narzędzia wzrostu do optymalizacji zakupów w aplikacji i monetyzacji. Kompatybilna z iOS, Android, React Native, Flutter, Unity, Cordova, Stripe i web. Darmowa do 10 tys. USD miesięcznych przychodów śledzonych.
  * [ParityVend](https://www.ambeteco.com/ParityVend/) – Automatyczna regulacja cen w zależności od lokalizacji odwiedzającego, aby rozszerzyć działalność globalnie i dotrzeć do nowych rynków (parytet siły nabywczej). Darmowy plan obejmuje 7 500 żądań API/miesiąc.
  * [Glassfy](https://glassfy.io/) – Infrastruktura subskrypcji w aplikacji, zdarzenia subskrypcji w czasie rzeczywistym oraz gotowe narzędzia monetyzacyjne na iOS, Android, Stripe i Paddle. Darmowe do 10 tys. USD miesięcznego przychodu.
  * [Adapty.io](https://adapty.io/) – Kompleksowe rozwiązanie z otwartoźródłowym SDK do integracji subskrypcji w aplikacji mobilnej na iOS, Android, React Native, Flutter, Unity lub aplikację webową. Darmowe do 10 tys. USD miesięcznego przychodu.
  * [CoinMarketCap](https://coinmarketcap.com/api/) — Dostarcza dane rynkowe kryptowalut, w tym najnowsze kursy wymiany kryptowalut i walut fiducjarnych. Darmowy poziom oferuje 10 000 kredytów wywołań/miesiąc.
  * [CurrencyFreaks](https://currencyfreaks.com/) — Udostępnia aktualne i historyczne kursy walut. Darmowy plan DEVELOPER z 1000 żądań/miesiąc.
  * [CoinGecko](https://www.coingecko.com/en/api) — Dostarcza dane rynkowe kryptowalut, w tym najnowsze kursy wymiany kryptowalut oraz dane historyczne. Demo API ma stabilny limit 30 wywołań/min i miesięczny limit 10 000 wywołań.
  * [CurrencyApi](https://currencyapi.net/) — Aktualne kursy walut fizycznych i kryptowalut, dostarczane w formacie JSON i XML. Darmowy poziom oferuje 1 250 żądań API/miesiąc.
  * [currencylayer](https://currencylayer.com/) — Niezawodne kursy wymiany i konwersja walut dla Twojego biznesu, 100 żądań API/miesiąc za darmo.
  * [exchangerate-api.com](https://www.exchangerate-api.com) - Proste w użyciu API konwersji walut w formacie JSON. Darmowy poziom aktualizowany raz dziennie z limitem 1 500 żądań/miesiąc.
  * [FraudLabsPRO](https://www.fraudlabspro.com) — Pomaga sprzedawcom zapobiegać oszustwom płatniczym i obciążeniom zwrotnym. Dostępny darmowy plan Micro z 500 zapytaniami/miesiąc.
  * [FxRatesAPI](https://fxratesapi.com) — Udostępnia kursy walut w czasie rzeczywistym i historyczne. Darmowy poziom wymaga podania źródła.
  * [Moesif API Monetization](https://www.moesif.com/) - Generowanie przychodów z API poprzez rozliczenia oparte na użyciu. Integracja ze Stripe, Chargebee itp. Darmowy poziom oferuje 30 000 zdarzeń/miesiąc.
  * [Nami ML](https://www.namiml.com/) - Kompleksowa platforma do zakupów w aplikacji i subskrypcji na iOS i Android, w tym ściany płatności bez kodowania, CRM i analityka. Darmowa dla wszystkich podstawowych funkcji do prowadzenia biznesu IAP.
  * [RevenueCat](https://www.revenuecat.com/) — Hostowany backend do zakupów w aplikacji i subskrypcji (iOS i Android). Darmowe do 2,5 tys. USD/miesiąc śledzonego przychodu.
  * [vatlayer](https://vatlayer.com/) — Natychmiastowa weryfikacja numerów VAT i API stawek VAT UE, darmowe 100 żądań API/miesiąc
  * [Currencyapi](https://currencyapi.com) — Darmowe API do konwersji walut i danych kursów wymiany. Darmowe 300 żądań miesięcznie, 10 żądań na minutę do użytku prywatnego.

**[⬆️ Powrót na górę](#table-of-contents)**

## Powiązane z Dockerem

  * [canister.io](https://canister.io/) — 20 darmowych prywatnych repozytoriów dla deweloperów, 30 darmowych prywatnych repozytoriów dla zespołów do budowania i przechowywania obrazów Docker
  * [Container Registry Service](https://container-registry.com/) - Rozwiązanie do zarządzania kontenerami oparte na Harbor. Darmowy poziom oferuje 1 GB przestrzeni dla prywatnych repozytoriów.
  * [Docker Hub](https://hub.docker.com) — Jedno darmowe prywatne repozytorium i nieograniczona liczba publicznych repozytoriów do budowania i przechowywania obrazów Docker
  * [Play with Docker](https://labs.play-with-docker.com/) — Prosty, interaktywny, zabawny plac zabaw do nauki Dockera.
  * [quay.io](https://quay.io/) — Buduj i przechowuj obrazy kontenerów z nieograniczoną liczbą darmowych publicznych repozytoriów
  * [ttl.sh](https://ttl.sh/) - Anonimowy i efemeryczny rejestr obrazów Docker

**[⬆️ Powrót na górę](#table-of-contents)**

## Powiązane z Vagrantem

  * [Vagrant Cloud](https://app.vagrantup.com) - HashiCorp Vagrant Cloud. Hosting boxów Vagrant.
  * [Vagrantbox.es](https://www.vagrantbox.es/) — Alternatywny publiczny indeks boxów

**[⬆️ Powrót na górę](#table-of-contents)**

## Serwisy blogowe dla deweloperów

  * [BearBlog](https://bearblog.dev/) - Minimalistyczny blog i kreator stron oparty na Markdown.
  * [Dev.to](https://dev.to/) - Miejsce, gdzie programiści dzielą się pomysłami i pomagają sobie nawzajem rozwijać.
  * [Hashnode](https://hashnode.com/) — Bezproblemowe oprogramowanie blogowe dla programistów!
  * [Medium](https://medium.com/) — Zastanów się głębiej nad tym, co dla Ciebie ważne.
  * [AyeDot](https://ayedot.com/) — Dziel się swoimi pomysłami, wiedzą i historiami ze światem za darmo w postaci nowoczesnych, multimedialnych miniblogów w krótkim formacie.

**[⬆️ Powrót na górę](#table-of-contents)**

## Platformy do komentowania
  * [GraphComment](https://graphcomment.com/) - GraphComment to platforma komentarzy, która pomaga zbudować aktywną społeczność z odbiorców strony.
  * [Utterances](https://utteranc.es/) - Lekki widget komentarzy oparty na zgłoszeniach GitHub. Używaj zgłoszeń GitHub jako komentarzy do bloga, stron wiki i innych!
  * [Disqus](https://disqus.com/) - Disqus to sieciowa platforma społecznościowa używana przez setki tysięcy stron w całym internecie.
  * [Remarkbox](https://www.remarkbox.com/) - Otwarta, hostowana platforma komentarzy, płacisz ile możesz za "Jednego moderatora na kilku domenach z pełną kontrolą nad zachowaniem i wyglądem"
  * [IntenseDebate](https://intensedebate.com/) - System komentarzy z wieloma funkcjami dla WordPress, Tumblr, Blogger i wielu innych platform.

**[⬆️ Powrót na górę](#table-of-contents)**

## Screenshot APIs

  * [ApiFlash](https://apiflash.com) — API do robienia screenshotów oparte na AWS Lambda i Chrome. Obsługuje pełną stronę, kontrolę czasu i rozmiarów widoku.
  * [microlink.io](https://microlink.io/) – Zamienia dowolną stronę w dane, takie jak normalizacja metatagów, piękne podglądy linków, możliwości scrapowania lub screenshoty jako usługa. 250 żądań/dzień za darmo każdego dnia.
  * [ScreenshotAPI.net](https://screenshotapi.net/) - Screenshot API korzysta z prostego wywołania API do generowania zrzutów ekranu dowolnej strony internetowej. Gotowe do skalowania i hostowane w Google Cloud. Oferuje 100 darmowych zrzutów ekranu miesięcznie.
  * [screenshotlayer.com](https://screenshotlayer.com/) — Rób bardzo konfigurowalne zrzuty dowolnej strony internetowej. Darmowe 100 zrzutów/miesiąc
  * [screenshotmachine.com](https://www.screenshotmachine.com/) — 100 zrzutów/miesiąc, png, gif i jpg, w tym pełne zrzuty, nie tylko strony głównej
  * [PhantomJsCloud](https://PhantomJsCloud.com) — Automatyzacja przeglądarki i renderowanie stron. Darmowy poziom oferuje do 500 stron/dzień. Darmowy poziom od 2017 r.
  * [Webshrinker.com](https://webshrinker.com) — Web Shrinker oferuje API do zrzutów stron oraz analiz domen. Darmowe 100 żądań/miesiąc.
  * [Screenshots](https://screenshotson.click) — Twoje API do zrzutów ekranu. Z wysoko konfigurowalnymi opcjami przechwytywania. Darmowe 100 zrzutów ekranu/miesiąc.

**[⬆️ Powrót na górę](#table-of-contents)**

## Powiązane z Flutterem oraz budowanie aplikacji iOS bez Maca

  * [FlutLab](https://flutlab.io/) - FlutLab to nowoczesne internetowe IDE Fluttera i najlepsze miejsce do tworzenia, debugowania oraz budowania projektów wieloplatformowych. Twórz aplikacje iOS (bez Maca) i Android za pomocą Fluttera.
  * [CodeMagic](https://codemagic.io/) - Codemagic to w pełni hostowane i zarządzane CI/CD dla aplikacji mobilnych. Możesz budować, testować i wdrażać za pomocą narzędzia CI/CD z GUI. Darmowy poziom oferuje 500 darmowych minut/miesiąc oraz Mac Mini z 2,3 GHz i 8 GB RAM.
  * [FlutterFlow](https://flutterflow.io/) -  FlutterFlow to narzędzie oparte na przeglądarce z interfejsem drag-and-drop do budowania aplikacji mobilnych przy użyciu Fluttera.

**[⬆️ Powrót na górę](#table-of-contents)**

## Emulacja sprzętu w przeglądarce napisana w JavaScript

  * [JsLinux](https://bellard.org/jslinux) — bardzo szybka maszyna wirtualna x86 zdolna do uruchamiania Linuksa i Windows 2k.
  * [Jor1k](https://s-macke.github.io/jor1k/demos/main.html) —  maszyna wirtualna OpenRISC zdolna do uruchamiania Linuksa z obsługą sieci.
  * [v86](https://copy.sh/v86) — maszyna wirtualna x86 zdolna do uruchamiania Linuksa i innych systemów operacyjnych bezpośrednio w przeglądarce.

**[⬆️ Powrót na górę](#table-of-contents)**

## Zarządzanie prywatnością
  * [Bearer](https://www.bearer.sh/) - Pomaga wdrożyć prywatność już na etapie projektowania poprzez audyty i ciągłe procesy, aby organizacje były zgodne z RODO i innymi regulacjami. Darmowy poziom ograniczony do mniejszych zespołów i tylko wersji SaaS.
  * [Osano](https://www.osano.com/) - Platforma zarządzania zgodą i zgodnością obejmująca wszystko od reprezentacji RODO po banery cookies. Darmowy poziom oferuje podstawowe funkcje.
  * [Iubenda](https://www.iubenda.com/) - Polityki prywatności i cookies oraz zarządzanie zgodą. Darmowy poziom oferuje ograniczoną politykę prywatności i cookies oraz banery cookies.
  * [Cookiefirst](https://cookiefirst.com/) - Banery cookies, audyt i wielojęzyczne zarządzanie zgodą. Darmowy poziom obejmuje jednorazowe skanowanie i jeden baner.
* [Ketch](https://www.ketch.com/) - Narzędzie do zarządzania zgodami i ramowe narzędzie prywatności. Darmowy poziom oferuje większość funkcji z ograniczoną liczbą odwiedzających.
* [Concord](https://www.concord.tech/) - Pełna platforma prywatności danych, w tym zarządzanie zgodami, obsługa żądań prywatności (DSAR), i mapowanie danych. Darmowy poziom obejmuje podstawowe funkcje zarządzania zgodami, a także oferują bardziej zaawansowany plan za darmo dla zweryfikowanych projektów open source.

**[⬆️ Powrót na górę](#table-of-contents)**

## Różne

* [BackgroundStyler.com](https://backgroundstyler.com) - Twórz estetyczne zrzuty ekranu swojego kodu, tekstu lub obrazów do udostępniania w mediach społecznościowych.
* [BinShare.net](https://binshare.net) - Twórz i udostępniaj kod lub pliki binarne. Dostępne do udostępniania jako piękny obraz np. na Twitterze/Facebooku lub jako link np. do czatów lub forów.
* [Blynk](https://blynk.io) — SaaS z API do kontroli, budowy i oceny urządzeń IoT. Darmowy plan deweloperski z 5 urządzeniami, darmową chmurą i przechowywaniem danych. Dostępne są również aplikacje mobilne.
* [Bricks Note Calculator](https://free.getbricks.app/) - aplikacja do notatek (PWA) z zaawansowanym wbudowanym wieloliniowym kalkulatorem.
* [Carbon.now.sh](https://carbon.now.sh) - twórz i udostępniaj fragmenty kodu w formie estetycznych zrzutów ekranu. Zazwyczaj używane do estetycznego udostępniania/pokazywania fragmentów kodu na Twitterze lub we wpisach na blogu.
* [Code Time](https://www.software.com/code-time) - rozszerzenie do śledzenia czasu i metryk kodowania w VS Code, Atom, IntelliJ, Sublime Text i innych.
* [Codepng](https://www.codepng.app) - Twórz doskonałe zrzuty swojego kodu źródłowego do udostępniania w mediach społecznościowych.
* [CodeToImage](https://codetoimage.com/) - Twórz zrzuty ekranu kodu lub tekstu do udostępniania w mediach społecznościowych.
* [Cronhooks](https://cronhooks.io/) - Harmonogram jednorazowych lub cyklicznych webhooków. Darmowy plan pozwala na 5 harmonogramów ad-hoc.
* [cron-job.org](https://cron-job.org) - Internetowa usługa cronjobów. Nieograniczona liczba zadań za darmo.
* [datelist.io](https://datelist.io) - Internetowy system rezerwacji/umawiania spotkań. Darmowy do 5 rezerwacji miesięcznie, obejmuje 1 kalendarz.
* [Domain Forward](https://domain-forward.com/) - Proste narzędzie do przekierowywania dowolnego URL lub domeny. Darmowe do 5 domen i 200 tys. żądań miesięcznie.
* [Elementor](https://elementor.com) — Kreator stron WordPress. Darmowy plan dostępny z ponad 40 podstawowymi widgetami.
* [Exif Editor](https://exifeditor.io/) — Przeglądaj, edytuj, usuwaj, analizuj metadane obrazu/zdjęcia bezpośrednio w przeglądarce - w tym lokalizację GPS i metadane.
* [Format Express](https://www.format-express.dev) - Natychmiastowy format online dla JSON / XML / SQL.
* [FOSSA](https://fossa.com/) - Skalowalne, kompleksowe zarządzanie kodem zewnętrznym, zgodnością licencji i podatnościami.
* [Hook Relay](https://www.hookrelay.dev/) - Dodaj obsługę webhooków do swojej aplikacji bez problemów: gotowe kolejkowanie, ponowne próby z opóźnieniem i logowanie. Darmowy plan to 100 dostaw dziennie, 14 dni przechowywania i 3 punkty końcowe hooków.
* [Hosting Checker](https://hostingchecker.co) - Sprawdzaj informacje o hostingu jak ASN, ISP, lokalizacja i więcej dla dowolnej domeny, strony internetowej lub adresu IP. Zawiera także wiele narzędzi związanych z hostingiem i DNS.
* [http2.pro](https://http2.pro) — Test gotowości protokołu HTTP/2 i API do wykrywania obsługi HTTP/2 przez klienta.
* [kandi](https://kandi.openweaver.com/) — Przyspiesz rozpoczęcie tworzenia aplikacji: buduj niestandardowe funkcje, przypadki użycia i kompletne aplikacje szybciej dzięki fragmentom kodu i ponownemu wykorzystaniu bibliotek open source.
* [Base64 decoder/encoder](https://devpal.co/base64-decode/) — Darmowe narzędzie online do dekodowania i kodowania danych.
* [newreleases.io](https://newreleases.io/) - Otrzymuj powiadomienia e-mail, Slack, Telegram, Discord i niestandardowe webhooks o nowych wydaniach z GitHub, GitLab, Bitbucket, Python PyPI, Java Maven, Node.js NPM, Node.js Yarn, Ruby Gems, PHP Packagist, .NET NuGet, Rust Cargo i Docker Hub.
* [OnlineExifViewer](https://onlineexifviewer.com/) — Przeglądaj dane EXIF online natychmiast dla zdjęcia, w tym lokalizację GPS i metadane.
* [PDFMonkey](https://www.pdfmonkey.io/) — Zarządzaj szablonami PDF w panelu, wywołuj API z dynamicznymi danymi i pobieraj swój PDF. Oferuje 300 darmowych dokumentów miesięcznie.
* [Pika Code Screenshots](https://pika.style/templates/code-image) — Twórz piękne, konfigurowalne zrzuty ekranu z fragmentów kodu i VSCode za pomocą rozszerzenia.
* [QuickType.io](https://quicktype.io/) - Szybko automatycznie generuj modele/klasy/typy/interfejsy i serializatory z JSON, schematów i GraphQL do szybkiej i bezpiecznej pracy z danymi w każdym języku programowania. Konwertuj JSON na piękny, typowany kod w dowolnym języku.
* [RandomKeygen](https://randomkeygen.com/) - Darmowe, przyjazne dla urządzeń mobilnych narzędzie oferujące różnorodne losowo generowane klucze i hasła do zabezpieczenia dowolnej aplikacji, usługi lub urządzenia.
* [ray.so](https://ray.so/) - Twórz piękne obrazy z fragmentów kodu.
* [readme.com](https://readme.com/) — Piękna dokumentacja w prosty sposób, darmowa dla open source.
* [redirection.io](https://redirection.io/) — Narzędzie SaaS do zarządzania przekierowaniami HTTP dla firm, marketingu i SEO.
* [redirect.ing](https://redirect.ing/) - Szybkie i bezpieczne przekierowywanie domen bez zarządzania serwerami lub certyfikatami SSL. Darmowy plan obejmuje 10 nazw hostów i 100 000 żądań miesięcznie.
* [redirect.pizza](https://redirect.pizza/) - Łatwe zarządzanie przekierowaniami z obsługą HTTPS. Darmowy plan obejmuje 10 źródeł i 100 000 wejść miesięcznie.
* [ReqBin](https://reqbin.com/) — Wysyłaj żądania HTTP online. Popularne metody to GET, POST, PUT, DELETE i HEAD. Obsługuje nagłówki i uwierzytelnianie tokenem. Zawiera podstawowy system logowania do zapisywania żądań.
* [Smartcar API](https://smartcar.com) - API dla samochodów do lokalizowania, pobierania poziomów paliwa, baterii, licznika, otwierania/zamykania drzwi itp.
* [snappify](https://snappify.com) - Pozwala deweloperom tworzyć efektowne wizualizacje. Od pięknych fragmentów kodu po pełne prezentacje techniczne. Darmowy plan obejmuje do 3 snapów naraz z nieograniczonymi pobraniami i 5 objaśnieniami kodu wspieranymi AI miesięcznie.
* [Sunrise and Sunset](https://sunrisesunset.io/api/) - Uzyskaj czasy wschodu i zachodu słońca dla podanych współrzędnych geograficznych.
* [superfeedr.com](https://superfeedr.com/) — Kanały zgodne z PubSubHubbub w czasie rzeczywistym, eksport, analizy. Darmowe przy mniejszej możliwości personalizacji
* [SurveyMonkey.com](https://www.surveymonkey.com) — Twórz ankiety online. Analizuj wyniki online. Darmowy plan pozwala tylko na 10 pytań i 100 odpowiedzi na ankietę.
* [Tiledesk](https://tiledesk.com) - Twórz chatboty i aplikacje konwersacyjne. Wprowadź je omnichannel: od swojej strony (widget czatu na żywo) po WhatsApp. Darmowy plan z nieograniczoną liczbą chatbotów.
* [Versionfeeds](https://versionfeeds.com) — Niestandardowe kanały RSS z wydaniami Twojego ulubionego oprogramowania. Miej najnowsze wersje języków programowania, bibliotek lub ulubionych narzędzi w jednym kanale. (Pierwsze 3 kanały za darmo)
* [videoinu](https://videoinu.com) — Twórz i edytuj nagrania ekranu oraz inne filmy online.
* [Webacus](https://webacus.dev) — Dostęp do szerokiej gamy darmowych narzędzi dla programistów do kodowania, dekodowania i manipulacji danymi.

**[⬆️ Powrót na górę](#table-of-contents)**

## Narzędzia do zdalnego pulpitu

* [Getscreen.me](https://getscreen.me) — Darmowe dla 2 urządzeń, bez limitu liczby i czasu trwania sesji
* [Apache Guacamole™](https://guacamole.apache.org/) — Open source klientowy bramkowy serwer zdalnego pulpitu bez klienta
* [RemSupp](https://remsupp.com) — Pomoc na żądanie i stały dostęp do urządzeń (2 sesje/dzień za darmo)
* [RustDesk](https://rustdesk.com/) - Otwarta infrastruktura wirtualnego/zdalnego pulpitu dla każdego!
* [AnyDesk](https://anydesk.com) — Darmowe dla 3 urządzeń, bez limitu liczby i czasu trwania sesji

**[⬆️ Powrót na górę](#table-of-contents)**

## Tworzenie gier

* [itch.io](https://itch.io/game-assets) — Darmowe/płatne zasoby takie jak sprite'y, zestawy kafelków i paczki postaci.
* [Gamefresco.com](https://gamefresco.com/) — Odkrywaj, zbieraj i udostępniaj darmowe zasoby do gier od twórców z całego świata.
* [GameDevMarket](https://gamedevmarket.net) — Darmowe/płatne zasoby 2D, 3D, audio, GUI.
* [OpenGameArt](https://opengameart.org) — Otwarty zbiór zasobów do gier jak muzyka, dźwięki, sprite'y i gify.
* [CraftPix](https://craftpix.net) — Darmowe/płatne zasoby 2D, 3D, audio, GUI, tła, ikony, zestawy kafelków, zestawy do gier.
* [Game Icons](https://game-icons.net/) - Darmowe stylizowane ikony SVG/PNG udostępniane na licencji CC-BY.
* [LoSpec](https://lospec.com/) — Narzędzia online do tworzenia pixel artu i innej restrykcyjnej grafiki cyfrowej, mnóstwo tutoriali/list palet do wyboru dla Twoich gier
* [ArtStation](https://www.artstation.com/) - MarketPlace dla darmowych/płatnych zasobów 2D, 3D i audio, ikon, zestawów kafelków, zestawów do gier. Może również służyć do prezentacji portfolio artystycznego.
* [Rive](https://rive.app/community/) - Zasoby społeczności oraz możliwość tworzenia własnych zasobów do gier z darmowym planem.
* [Poly Pizza](https://poly.pizza/) - Darmowe niskopoligonowe zasoby 3D
* [3Dassets.one](https://3dassets.one/) - Ponad 8 000 darmowych/płatnych modeli 3D i materiałów PBR do tworzenia tekstur.
* [Kenney](https://www.kenney.nl/assets/) - Darmowe (licencja CC0 1.0 Universal) zasoby do gier 2D, 3D, audio i UI.
* [Poliigon](https://www.poliigon.com/) - Darmowe i płatne tekstury (o zmiennej rozdzielczości), modele, HDRI i pędzle. Oferuje darmowe wtyczki do eksportu np. do Blendera.
* [Freesound](https://freesound.org/) - Darmowa współtworzona biblioteka dźwięków na różnych licencjach CC.

**[⬆️ Powrót na górę](#table-of-contents)**

## Inne darmowe zasoby

* [Wikimint Developer](https://developer.wikimint.com/p/tools.html) - Zawsze darmowe narzędzia dla web developerów, w tym minifikacja/odminifikacja CSS, optymalizator obrazów, zmiana rozmiaru obrazów, konwerter wielkości liter, walidator CSS, kompilator JavaScript, edytor HTML itp.
* [ElevateAI](https://www.elevateai.com) - Do 200 godzin transkrypcji audio za darmo co miesiąc.
* [get.localhost.direct](https://get.localhost.direct) — Lepszy `*.localhost.direct` Wildcard publiczny certyfikat SSL CA dla rozwoju lokalnego z obsługą subdomen
* [Framacloud](https://degooglisons-internet.org/en/) — Lista wolnego/otwartego oprogramowania i SaaS od francuskiej organizacji non-profit [Framasoft](https://framasoft.org/en/).
* [github.com — FOSS for Dev](https://github.com/tvvocold/FOSS-for-Dev) — Centrum darmowego i otwartego oprogramowania dla programistów.
* [GitHub Education](https://education.github.com/pack) — Zbiór darmowych usług dla studentów. Wymagana rejestracja.
* [Markdown Tools](https://markdowntools.com) - Narzędzia do konwersji HTML, CSV, PDF, JSON i plików Excel do i z Markdown
* [Microsoft 365 Developer Program](https://developer.microsoft.com/microsoft-365/dev-program) — Otrzymaj darmową piaskownicę, narzędzia i inne zasoby potrzebne do tworzenia rozwiązań na platformę Microsoft 365. Subskrypcja to 90-dniowa [Microsoft 365 E5 Subscription](https://www.microsoft.com/microsoft-365/enterprise/e5) (bez Windows), którą można odnawiać. Jest odnawiana, jeśli jesteś aktywny w rozwoju (mierzone na podstawie telemetrii i algorytmów).
* [Pyrexp](https://pythonium.net/regex) — Darmowy tester i wizualizator wyrażeń regularnych online do debugowania regexów.
* [RedHat for Developers](https://developers.redhat.com) — Darmowy dostęp do produktów Red Hat, w tym RHEL, OpenShift, CodeReady itp. wyłącznie dla programistów. Tylko plan indywidualny. Dostępne również darmowe e-booki.
* [smsreceivefree.com](https://smsreceivefree.com/) — Zapewnia darmowe tymczasowe i jednorazowe numery telefonów.
* [sandbox.httpsms.com](https://sandbox.httpsms.com) — Wysyłaj i odbieraj testowe SMS-y za darmo.
* [SimpleBackups.com](https://simplebackups.com/) — Automatyzacja backupów serwerów i baz danych (MySQL, PostgreSQL, MongoDB) bezpośrednio do chmur (AWS, DigitalOcean, Backblaze). Darmowy plan na 1 backup.
* [SnapShooter](https://snapshooter.com/) — Rozwiązanie do backupów dla DigitalOcean, AWS, LightSail, Hetzner i Exoscale, z obsługą bezpośrednich kopii baz danych, systemu plików i aplikacji do pamięci s3. Darmowy plan z codziennymi kopiami zapasowymi jednego zasobu.
* [Themeselection](https://themeselection.com/) — Wyselekcjonowane, wysokiej jakości, nowoczesne, profesjonalne i łatwe w użyciu darmowe szablony paneli administracyjnych, motywy HTML i zestawy UI do szybszego tworzenia aplikacji!
* [Web.Dev](https://web.dev/measure/) — Darmowe narzędzie pozwalające zobaczyć wydajność Twojej strony i poprawić SEO, aby uzyskać wyższą pozycję w wyszukiwarkach.
  * [SmallDev.tools](https://smalldev.tools/) — Darmowe narzędzie dla programistów umożliwiające kodowanie/dekodowanie różnych formatów, minimalizację HTML/CSS/Javascript, upiększanie, generowanie fałszywych/zestawów testowych danych w formatach JSON/CSV i wielu innych oraz wiele innych funkcji. Z przyjemnym interfejsem.
  * [UseCSV by Layercode](https://layercode.com/usecsv) — Dodaj import plików CSV i Excel do swojej aplikacji internetowej w kilka minut. Zapewnij użytkownikom przyjemne i niezawodne doświadczenie importu danych. Zacznij za darmo bez konieczności podawania danych karty kredytowej i rozpocznij integrację UseCSV już dziś. Możesz tworzyć nieograniczoną liczbę Importerów i przesyłać pliki do 100 MB.
  * [Buttons Generator](https://markodenic.com/tools/buttons-generator/) — Ponad 100 przycisków, które możesz wykorzystać w swoim projekcie.
  * [WrapPixel](https://www.wrappixel.com/) — Pobierz wysokiej jakości darmowe i premium szablony paneli administracyjnych stworzone w Angular, React, VueJs, NextJS i NuxtJS!
  * [Utils.fun](https://utils.fun/en) — Wszystkie narzędzia codzienne i deweloperskie offline oparte na mocy obliczeniowej przeglądarki, w tym generowanie znaków wodnych, nagrywanie ekranu, kodowanie i dekodowanie, szyfrowanie i deszyfrowanie oraz formatowanie kodu, są całkowicie darmowe i nie przesyłają żadnych danych do chmury.
  * [It tools](it-tools.tech) - Przydatne narzędzia dla programistów i osób pracujących w IT.
  * [Free Code Tools](https://freecodetools.org/) — Skuteczne narzędzia do kodu, które są w 100% darmowe. Edytor Markdown, minifikator/upiększacz kodu, generator kodów QR, generator Open Graph, generator kart Twittera i wiele więcej.
  * [regex101](https://regex101.com/) — Darmowa strona pozwalająca testować i debugować wyrażenia regularne (regex). Udostępnia edytor i tester regexów oraz przydatną dokumentację i zasoby do nauki wyrażeń regularnych.
  * [Kody Tools](https://www.kodytools.com/dev-tools) — Ponad 100 narzędzi deweloperskich, w tym formatowanie, minimalizacja i konwersja.
  * [AdminMart](https://adminmart.com/) — Wysokiej jakości darmowe i premium szablony paneli administracyjnych i stron internetowych stworzone w Angular, Bootstrap, React, VueJs, NextJS i NuxtJS!
  * [Glob tester](https://globster.xyz/) — Strona internetowa umożliwiająca projektowanie i testowanie wzorców glob. Zawiera również zasoby do nauki wzorców glob.
  * [SimpleRestore](https://simplerestore.io) - Bezproblemowe przywracanie kopii zapasowych MySQL. Przywracaj kopie zapasowe MySQL do dowolnej zdalnej bazy danych bez kodu lub serwera.
  * [360Converter](https://www.360converter.com/) - Darmowa strona internetowa umożliwiająca konwersję: wideo na tekst, audio na tekst, mowę na tekst, audio w czasie rzeczywistym na tekst, wideo z YouTube na tekst oraz dodawanie napisów do wideo. Może być przydatna do konwersji krótkich filmów lub krótkich tutoriali na YouTube:)
  * [QRCodeBest](https://qrcode.best/) - Twórz spersonalizowane kody QR z 13 szablonami, pełną prywatnością i brandingiem osobistym. Funkcje obejmują piksele śledzące, kategoryzację projektów i nieograniczoną liczbę członków zespołu na QRCode.Best.
  * [PostPulse](https://PostPulseAI.com) - Zwiększ swoją obecność w internecie, popraw SEO i ranking strony dzięki miesięcznym postom tworzonym przez AI na zoptymalizowanych pod SEO domenach. Darmowy plan pozwala ręcznie opublikować jeden post na naszej stronie każdego miesiąca.
  * [PageTools](https://pagetools.co/) - Oferuje zestaw na zawsze darmowych narzędzi AI, które pomagają generować niezbędne polityki stron, tworzyć bio do mediów społecznościowych, posty i strony internetowe za pomocą prostego interfejsu jednym kliknięciem.
  * [MySQL Visual Explain](https://mysqlexplain.com) - Łatwy do zrozumienia i darmowy wizualizator wyników EXPLAIN MySQL do optymalizacji wolnych zapytań.
  * [Killer Coda](https://killercoda.com/)  - Interaktywne środowisko w przeglądarce do nauki Linuxa, Kubernetes, kontenerów, programowania, DevOps, sieci.
  * [Axonomy App](https://axonomy-app.com/) - Darmowe narzędzie do tworzenia, zarządzania i udostępniania faktur klientom. 10 darmowych faktur miesięcznie.
  * [Table Format Converter](https://www.tableformatconverter.com) - Darmowe narzędzie do konwertowania danych tabelarycznych do różnych formatów, takich jak CSV, HTML, JSON, Markdown i innych.


**[⬆️ Powrót na górę](#table-of-contents)**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---
[![Licentie](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE) [![Coverage](https://github.com/NVIDIA/KAI-Scheduler/raw/coverage-badge/badges/coverage.svg)](https://github.com/NVIDIA/KAI-Scheduler/blob/main/.github/workflows/update-coverage-badge.yaml)
# KAI Scheduler
KAI Scheduler is een robuuste, efficiënte en schaalbare [Kubernetes scheduler](https://kubernetes.io/docs/concepts/scheduling-eviction/kube-scheduler/) die GPU-resourceallocatie optimaliseert voor AI- en machine learning-workloads.

Ontworpen om grootschalige GPU-clusters te beheren, waaronder duizenden nodes en een hoge doorvoer van workloads, maakt de KAI Scheduler ideaal voor omvangrijke en veeleisende omgevingen.
KAI Scheduler stelt beheerders van Kubernetes-clusters in staat om GPU-resources dynamisch toe te wijzen aan workloads.

KAI Scheduler ondersteunt de volledige AI-levenscyclus, van kleine, interactieve taken die minimale resources vereisen tot grote trainings- en inferentieprocessen, allemaal binnen hetzelfde cluster.
Het zorgt voor optimale resourceallocatie en handhaaft resourcegelijkheid tussen verschillende gebruikers.
Het kan naast andere schedulers op het cluster draaien.

## Belangrijkste kenmerken
* [Batch Scheduling](docs/batch/README.md): Zorg ervoor dat alle pods in een groep gelijktijdig worden ingepland of helemaal niet.
* Bin Packing & Spread Scheduling: Optimaliseer het gebruik van nodes door fragmentatie te minimaliseren (bin-packing) of door veerkracht en loadbalancing te vergroten (spread scheduling).
* [Workload Prioriteit](docs/priority/README.md): Prioriteer workloads effectief binnen wachtrijen.
* [Hiërarchische wachtrijen](docs/queues/README.md): Beheer workloads met tweeledige wachtrijhiërarchieën voor flexibele organisatorische controle.
* [Resourceverdeling](docs/fairness/README.md#resource-division-algorithm): Pas quota's, over-quota gewichten, limieten en prioriteiten per wachtrij aan.
* [Fairness Policies](docs/fairness/README.md#reclaim-strategies): Zorg voor een eerlijke resourceverdeling met behulp van Dominant Resource Fairness (DRF) en resource reclamation tussen wachtrijen.
* Workloadconsolidatie: Herverdeel draaiende workloads intelligent om fragmentatie te verminderen en het clustergebruik te verhogen.
* [Elastische Workloads](docs/elastic/README.md): Schaal workloads dynamisch binnen gedefinieerde minimale en maximale aantallen pods.
* Dynamische Resource Allocatie (DRA): Ondersteun leverancier-specifieke hardware resources via Kubernetes ResourceClaims (bijvoorbeeld GPU's van NVIDIA of AMD).
* [GPU Sharing](docs/gpu-sharing/README.md): Sta toe dat meerdere workloads efficiënt één of meerdere GPU's delen, waardoor het resourcegebruik wordt gemaximaliseerd.
* Cloud- & On-premise ondersteuning: Volledig compatibel met dynamische cloud-infrastructuren (inclusief auto-scalers zoals Karpenter) én statische on-premise implementaties.

## Vereisten
Voordat u KAI Scheduler installeert, zorg dat u beschikt over:

- Een draaiend Kubernetes-cluster
- [Helm](https://helm.sh/docs/intro/install) CLI geïnstalleerd
- [NVIDIA GPU-Operator](https://github.com/NVIDIA/gpu-operator) geïnstalleerd om workloads die GPU-resources aanvragen te kunnen plannen

## Installatie
KAI Scheduler wordt geïnstalleerd in de namespace `kai-scheduler`. Zorg bij het indienen van workloads voor een aparte namespace.

### Installatiemethoden
KAI Scheduler kan worden geïnstalleerd:

- **Vanuit productie (Aanbevolen)**
- **Vanuit broncode (Zelf bouwen)**

#### Installeren vanuit productie
Zoek de laatste releaseversie op de [releases](https://github.com/NVIDIA/KAI-Scheduler/releases) pagina.
Voer het volgende commando uit nadat u `<VERSION>` hebt vervangen door de gewenste releaseversie:
```sh
helm upgrade -i kai-scheduler oci://ghcr.io/nvidia/kai-scheduler/kai-scheduler -n kai-scheduler --create-namespace --version <VERSION>
```
#### Bouwen vanuit broncode
Volg de instructies [hier](docs/developer/building-from-source.md)

## Snelstart
Om te beginnen met het plannen van workloads met KAI Scheduler, ga verder naar het [Snelstartvoorbeeld](docs/quickstart/README.md)

## Routekaart

### Overzicht van de belangrijkste prioriteiten voor 2025
* Refactor de codebase om leveranciersneutraliteit te verbeteren
* Ondersteun Scheduling Gates https://github.com/NVIDIA/KAI-Scheduler/issues/63
* Onderzoek naar mogelijke integratie met Kueue https://github.com/NVIDIA/KAI-Scheduler/issues/68
* Voeg Topology Aware Scheduling ondersteuning toe voor pod-groepen https://github.com/NVIDIA/KAI-Scheduler/issues/66
* Ondersteun minimale looptijd per workload
* Ondersteun maximale looptijd per workload (met vertraagde herinplanning)
* Voeg meer PriorityClasses toe als onderdeel van de standaard KAI-installatie
* Ondersteun JobSet
* Ondersteun LWS (LeaderWorkerSet)
* Voeg metrics toe voor pod- en pod-groep-preëmpties
* Koppel prioriteit en preëmptie los

### Langetermijndoelen
* Ondersteun tijdsverval per wachtrij
* Hyperschaal-verbeteringen
* Ondersteun consolidatie van inferentie workloads voor clusterdefragmentatie
* Ondersteun n-niveaus van hiërarchische wachtrijen
* Geleidelijke uitrol van inferentie workloads (nieuwe revisie-update met tijdelijke over-quota voor wachtrij)

## Community, Discussie en Ondersteuning

We horen graag van je! Hier zijn de beste manieren om contact op te nemen:

### Slack
Word lid van de [CNCF Slack](https://communityinviter.com/apps/cloud-native/cncf) en bezoek het [#kai-scheduler](https://cloud-native.slack.com/archives/kai-scheduler) kanaal.

### Tweewekelijkse community-call  
**Wanneer:** Om de week op maandag om 17:00 CEST  
[Converteer naar jouw tijdzone](https://dateful.com/time-zone-converter?t=17&tz2=Germany) | [Voeg toe aan je agenda](https://calendar.google.com/calendar/event?action=TEMPLATE&tmeid=N2Q2bjhoNXAzMGc0cWpnZTQ4OGtpdXFhanFfMjAyNTA2MDlUMTUwMDAwWiAxZjQ2OTZiOWVlM2JiMWE1ZWIzMTAwODBkNDZiZmMwMDZjNTUxYWFiZmU1YTM3ZGM2YTc0NTFhYmNhMmE1ODk0QGc&tmsrc=1f4696b9ee3bb1a5eb310080d46bfc006c551aabfe5a37dc6a7451abca2a5894%40group.calendar.google.com&scp=ALL)  | [Notulen & agenda](https://docs.google.com/document/d/13K7NGdPebOstlrsif1YLjGz1x-aJafMXeIgqbO7WghI/edit?usp=sharing)

### Mailinglijst  
Word lid van de [kai-scheduler mailinglijst](https://groups.google.com/g/kai-scheduler) om updates te ontvangen over de tweewekelijkse vergaderingen.

### Technische issues & Feature requests  
Open een [GitHub issue](https://github.com/NVIDIA/KAI-Scheduler/issues/new/choose) voor bugs, functieverzoeken of technische hulp. Dit helpt ons om verzoeken bij te houden en effectief te reageren.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---
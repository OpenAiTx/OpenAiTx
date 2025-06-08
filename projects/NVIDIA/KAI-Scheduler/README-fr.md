[![License](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE) [![Coverage](https://github.com/NVIDIA/KAI-Scheduler/raw/coverage-badge/badges/coverage.svg)](https://github.com/NVIDIA/KAI-Scheduler/blob/main/.github/workflows/update-coverage-badge.yaml)
# KAI Scheduler
KAI Scheduler est un [planificateur Kubernetes](https://kubernetes.io/docs/concepts/scheduling-eviction/kube-scheduler/) robuste, efficace et évolutif qui optimise l’allocation des ressources GPU pour les charges de travail d’IA et d’apprentissage automatique.

Conçu pour gérer des clusters GPU à grande échelle, incluant des milliers de nœuds et un débit élevé de charges de travail, KAI Scheduler est idéal pour des environnements étendus et exigeants.
KAI Scheduler permet aux administrateurs de clusters Kubernetes d’allouer dynamiquement les ressources GPU aux charges de travail.

KAI Scheduler prend en charge tout le cycle de vie de l’IA, des petits travaux interactifs nécessitant peu de ressources aux grands entraînements et inférences, le tout dans le même cluster.
Il assure une allocation optimale des ressources tout en maintenant l’équité entre les différents consommateurs.
Il peut fonctionner en parallèle d’autres planificateurs installés sur le cluster.

## Fonctionnalités clés
* [Planification par lots](docs/batch/README.md) : Garantit que tous les pods d’un groupe sont planifiés simultanément ou pas du tout.
* Bin Packing & Planification par répartition : Optimise l’utilisation des nœuds soit en minimisant la fragmentation (bin-packing), soit en augmentant la résilience et l’équilibrage de charge (planification par répartition).
* [Priorité des charges de travail](docs/priority/README.md) : Priorise efficacement les charges de travail dans les files d’attente.
* [Files d’attente hiérarchiques](docs/queues/README.md) : Gère les charges de travail avec des files d’attente hiérarchiques à deux niveaux pour un contrôle organisationnel flexible.
* [Répartition des ressources](docs/fairness/README.md#resource-division-algorithm) : Personnalise les quotas, les poids hors quota, les limites et les priorités par file d’attente.
* [Politiques d’équité](docs/fairness/README.md#reclaim-strategies) : Assure une répartition équitable des ressources grâce à Dominant Resource Fairness (DRF) et à la récupération des ressources entre files d’attente.
* Consolidation des charges de travail : Réalloue intelligemment les charges de travail en cours pour réduire la fragmentation et augmenter l’utilisation du cluster.
* [Charges de travail élastiques](docs/elastic/README.md) : Redimensionne dynamiquement les charges de travail dans des limites minimales et maximales définies de pods.
* Allocation dynamique des ressources (DRA) : Prend en charge les ressources matérielles spécifiques aux fournisseurs via les ResourceClaims Kubernetes (par ex. GPU de NVIDIA ou AMD).
* [Partage de GPU](docs/gpu-sharing/README.md) : Permet à plusieurs charges de travail de partager efficacement un ou plusieurs GPU, maximisant ainsi l’utilisation des ressources.
* Prise en charge Cloud & On-premise : Entièrement compatible avec les infrastructures cloud dynamiques (y compris les auto-scalers comme Karpenter) ainsi que les déploiements sur site statique.

## Prérequis
Avant d’installer KAI Scheduler, assurez-vous d’avoir :

- Un cluster Kubernetes opérationnel
- Le CLI [Helm](https://helm.sh/docs/intro/install) installé
- [NVIDIA GPU-Operator](https://github.com/NVIDIA/gpu-operator) installé pour planifier les charges de travail nécessitant des ressources GPU

## Installation
KAI Scheduler sera installé dans l’espace de noms `kai-scheduler`. Lors de la soumission de charges de travail, veillez à utiliser un espace de noms dédié.

### Méthodes d’installation
KAI Scheduler peut être installé :

- **Depuis la production (recommandé)**
- **Depuis les sources (compilation manuelle)**

#### Installation depuis la production
Trouvez la dernière version publiée sur la page [releases](https://github.com/NVIDIA/KAI-Scheduler/releases).
Exécutez la commande suivante après avoir remplacé `<VERSION>` par la version souhaitée :
```sh
helm upgrade -i kai-scheduler oci://ghcr.io/nvidia/kai-scheduler/kai-scheduler -n kai-scheduler --create-namespace --version <VERSION>
```
#### Compilation depuis les sources
Suivez les instructions [ici](docs/developer/building-from-source.md)

## Démarrage rapide
Pour commencer à planifier des charges de travail avec KAI Scheduler, consultez l’[exemple de démarrage rapide](docs/quickstart/README.md)

## Feuille de route

### Vue d’ensemble des principales priorités pour 2025
* Refactorer la base de code pour renforcer la neutralité vis-à-vis des fournisseurs
* Prendre en charge les Scheduling Gates https://github.com/NVIDIA/KAI-Scheduler/issues/63
* Étudier l’intégration potentielle avec Kueue https://github.com/NVIDIA/KAI-Scheduler/issues/68
* Ajouter la prise en charge de la planification Topology Aware pour les groupes de pods https://github.com/NVIDIA/KAI-Scheduler/issues/66
* Prendre en charge un temps d’exécution minimum par charge de travail
* Prendre en charge un temps d’exécution maximum par charge de travail (avec remise en file d’attente différée)
* Ajouter plus de PriorityClasses dans l’installation par défaut de KAI
* Prendre en charge JobSet
* Prendre en charge LWS (LeaderWorkerSet)
* Ajouter des métriques pour les préemptions de pods et de groupes de pods
* Découpler Priorité et Préemption

### Objectifs à long terme
* Prendre en charge la décroissance temporelle par file d’attente
* Améliorations pour l’hyper-échelle
* Prendre en charge la consolidation des charges d’inférence pour la défragmentation du cluster
* Prendre en charge n niveaux de files d’attente hiérarchiques
* Déploiement progressif des charges d’inférence (nouvelle mise à jour de révision utilisant une file d’attente temporaire au-delà du quota)

## Communauté, discussions et support

Nous serions ravis d’avoir de vos nouvelles ! Voici les meilleurs moyens de nous contacter :

### Slack
Rejoignez d’abord le [Slack CNCF](https://communityinviter.com/apps/cloud-native/cncf) puis visitez le canal [#kai-scheduler](https://cloud-native.slack.com/archives/kai-scheduler).

### Appel communautaire bimensuel  
**Quand :** Un lundi sur deux à 17:00 CEST  
[Convertir dans votre fuseau horaire](https://dateful.com/time-zone-converter?t=17&tz2=Germany) | [Ajouter à votre agenda](https://calendar.google.com/calendar/event?action=TEMPLATE&tmeid=N2Q2bjhoNXAzMGc0cWpnZTQ4OGtpdXFhanFfMjAyNTA2MDlUMTUwMDAwWiAxZjQ2OTZiOWVlM2JiMWE1ZWIzMTAwODBkNDZiZmMwMDZjNTUxYWFiZmU1YTM3ZGM2YTc0NTFhYmNhMmE1ODk0QGc&tmsrc=1f4696b9ee3bb1a5eb310080d46bfc006c551aabfe5a37dc6a7451abca2a5894%40group.calendar.google.com&scp=ALL)  | [Notes & ordre du jour de la réunion](https://docs.google.com/document/d/13K7NGdPebOstlrsif1YLjGz1x-aJafMXeIgqbO7WghI/edit?usp=sharing)

### Liste de diffusion  
Inscrivez-vous à la [liste de diffusion kai-scheduler](https://groups.google.com/g/kai-scheduler) pour recevoir les mises à jour sur les réunions bimensuelles.

### Problèmes techniques & demandes de fonctionnalités  
Veuillez ouvrir une [issue GitHub](https://github.com/NVIDIA/KAI-Scheduler/issues/new/choose) pour les bugs, suggestions de fonctionnalités ou aide technique. Cela nous aide à suivre les demandes et à y répondre efficacement.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---
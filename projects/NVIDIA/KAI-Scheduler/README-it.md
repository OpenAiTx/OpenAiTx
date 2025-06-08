[![Licenza](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE) [![Copertura](https://github.com/NVIDIA/KAI-Scheduler/raw/coverage-badge/badges/coverage.svg)](https://github.com/NVIDIA/KAI-Scheduler/blob/main/.github/workflows/update-coverage-badge.yaml)
# KAI Scheduler
KAI Scheduler è un [scheduler Kubernetes](https://kubernetes.io/docs/concepts/scheduling-eviction/kube-scheduler/) robusto, efficiente e scalabile che ottimizza l'allocazione delle risorse GPU per carichi di lavoro di AI e machine learning.

Progettato per gestire cluster GPU su larga scala, inclusi migliaia di nodi e un elevato throughput di carichi di lavoro, KAI Scheduler è ideale per ambienti estesi ed esigenti.
KAI Scheduler consente agli amministratori dei cluster Kubernetes di allocare dinamicamente le risorse GPU ai carichi di lavoro.

KAI Scheduler supporta l'intero ciclo di vita dell'AI, dai piccoli job interattivi che richiedono risorse minime fino a grandi attività di training e inferenza, tutto all'interno dello stesso cluster.
Garantisce un'allocazione ottimale delle risorse mantenendo l'equità tra i diversi consumatori.
Può essere eseguito insieme ad altri scheduler installati sul cluster.

## Caratteristiche principali
* [Batch Scheduling](docs/batch/README.md): Garantisce che tutti i pod in un gruppo vengano schedulati simultaneamente o nessuno venga schedulato.
* Bin Packing & Spread Scheduling: Ottimizza l'utilizzo dei nodi minimizzando la frammentazione (bin-packing) o aumentando la resilienza e il bilanciamento del carico (spread scheduling).
* [Workload Priority](docs/priority/README.md): Prioritizza efficacemente i carichi di lavoro all'interno delle code.
* [Hierarchical Queues](docs/queues/README.md): Gestisce carichi di lavoro con gerarchie di code a due livelli per un controllo organizzativo flessibile.
* [Resource distribution](docs/fairness/README.md#resource-division-algorithm): Personalizza quote, pesi over-quota, limiti e priorità per coda.
* [Fairness Policies](docs/fairness/README.md#reclaim-strategies): Garantisce una distribuzione equa delle risorse usando Dominant Resource Fairness (DRF) e il recupero delle risorse tra code.
* Consolidamento dei carichi di lavoro: rialloca in modo intelligente i carichi di lavoro in esecuzione per ridurre la frammentazione e aumentare l'utilizzo del cluster.
* [Elastic Workloads](docs/elastic/README.md): Scala dinamicamente i carichi di lavoro tra un numero minimo e massimo di pod definiti.
* Dynamic Resource Allocation (DRA): Supporta risorse hardware specifiche del fornitore tramite Kubernetes ResourceClaims (ad es. GPU NVIDIA o AMD).
* [GPU Sharing](docs/gpu-sharing/README.md): Consente a più carichi di lavoro di condividere efficacemente una o più GPU, massimizzando l'utilizzo delle risorse.
* Supporto Cloud & On-premise: pienamente compatibile con infrastrutture cloud dinamiche (inclusi auto-scalers come Karpenter) e con deployment statici on-premise.

## Prerequisiti
Prima di installare KAI Scheduler, assicurarsi di avere:

- Un cluster Kubernetes attivo
- CLI [Helm](https://helm.sh/docs/intro/install) installata
- [NVIDIA GPU-Operator](https://github.com/NVIDIA/gpu-operator) installato per schedulare carichi di lavoro che richiedono risorse GPU

## Installazione
KAI Scheduler sarà installato nel namespace `kai-scheduler`. Quando si inviano carichi di lavoro, assicurarsi di utilizzare un namespace dedicato.

### Metodi di installazione
KAI Scheduler può essere installato:

- **Da Production (Consigliato)**
- **Dal Sorgente (Build it Yourself)**

#### Installazione da Production
Individuare l'ultima versione release nella pagina [releases](https://github.com/NVIDIA/KAI-Scheduler/releases).
Eseguire il seguente comando, sostituendo `<VERSION>` con la versione desiderata:
```sh
helm upgrade -i kai-scheduler oci://ghcr.io/nvidia/kai-scheduler/kai-scheduler -n kai-scheduler --create-namespace --version <VERSION>
```
#### Build dal Sorgente
Seguire le istruzioni [qui](docs/developer/building-from-source.md)

## Quick Start
Per iniziare a schedulare carichi di lavoro con KAI Scheduler, continuare con l'[esempio Quick Start](docs/quickstart/README.md)

## Roadmap

### Panoramica generale delle priorità principali per il 2025
* Refactoring del codice per migliorare la neutralità rispetto al fornitore
* Supporto a Scheduling Gates https://github.com/NVIDIA/KAI-Scheduler/issues/63
* Ricerca su possibili integrazioni con Kueue https://github.com/NVIDIA/KAI-Scheduler/issues/68
* Aggiunta del supporto Topology Aware Scheduling per pod-group https://github.com/NVIDIA/KAI-Scheduler/issues/66
* Supporto Min Run Time per carichi di lavoro
* Supporto Max Run Time per carico di lavoro (con requeue ritardato)
* Aggiunta di più PriorityClasses come parte dell'installazione predefinita di KAI
* Supporto JobSet
* Supporto LWS (LeaderWorkerSet)
* Aggiunta di metriche per preemption di pod e pod-group
* Separazione di Priority e Preemption

### Obiettivi a lungo termine
* Supporto decay temporale per coda
* Miglioramenti hyper scale
* Supporto consolidamento carichi di lavoro di inferenza per deframmentazione del cluster
* Supporto a n-livelli di code gerarchiche
* Rollout graduale dei carichi di lavoro di inferenza (nuovo aggiornamento di revisione usando over-quota temporaneo della coda)

## Community, Discussione e Supporto

Ci farebbe piacere sentirti! Ecco i modi migliori per entrare in contatto:

### Slack
Unisciti prima al [CNCF Slack](https://communityinviter.com/apps/cloud-native/cncf) e visita il canale [#kai-scheduler](https://cloud-native.slack.com/archives/kai-scheduler).

### Community Call bisettimanale  
**Quando:** Ogni due lunedì alle 17:00 CEST  
[Converti nel tuo fuso orario](https://dateful.com/time-zone-converter?t=17&tz2=Germany) | [Aggiungi al tuo calendario](https://calendar.google.com/calendar/event?action=TEMPLATE&tmeid=N2Q2bjhoNXAzMGc0cWpnZTQ4OGtpdXFhanFfMjAyNTA2MDlUMTUwMDAwWiAxZjQ2OTZiOWVlM2JiMWE1ZWIzMTAwODBkNDZiZmMwMDZjNTUxYWFiZmU1YTM3ZGM2YTc0NTFhYmNhMmE1ODk0QGc&tmsrc=1f4696b9ee3bb1a5eb310080d46bfc006c551aabfe5a37dc6a7451abca2a5894%40group.calendar.google.com&scp=ALL)  | [Note e agenda della riunione](https://docs.google.com/document/d/13K7NGdPebOstlrsif1YLjGz1x-aJafMXeIgqbO7WghI/edit?usp=sharing)

### Mailing List  
Iscriviti alla [mailing list kai-scheduler](https://groups.google.com/g/kai-scheduler) per ricevere aggiornamenti sulle riunioni bisettimanali.

### Problemi tecnici & Richieste di funzionalità  
Apri una [issue GitHub](https://github.com/NVIDIA/KAI-Scheduler/issues/new/choose) per bug, suggerimenti di funzionalità o aiuto tecnico. Questo ci aiuta a tenere traccia delle richieste e rispondere in modo efficace.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---
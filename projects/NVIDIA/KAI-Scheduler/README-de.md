[![Lizenz](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE) [![Abdeckung](https://github.com/NVIDIA/KAI-Scheduler/raw/coverage-badge/badges/coverage.svg)](https://github.com/NVIDIA/KAI-Scheduler/blob/main/.github/workflows/update-coverage-badge.yaml)
# KAI Scheduler
Der KAI Scheduler ist ein robuster, effizienter und skalierbarer [Kubernetes Scheduler](https://kubernetes.io/docs/concepts/scheduling-eviction/kube-scheduler/), der die Zuweisung von GPU-Ressourcen für KI- und Machine-Learning-Workloads optimiert.

Er wurde entwickelt, um große GPU-Cluster mit tausenden von Knoten und hohem Workload-Durchsatz zu verwalten und macht den KAI Scheduler ideal für umfangreiche und anspruchsvolle Umgebungen.
Der KAI Scheduler ermöglicht Administratoren von Kubernetes-Clustern, GPU-Ressourcen dynamisch auf Workloads zu verteilen.

Der KAI Scheduler unterstützt den gesamten KI-Lebenszyklus: von kleinen, interaktiven Jobs mit minimalem Ressourcenbedarf bis zu großen Trainings- und Inferenz-Workloads – alles innerhalb desselben Clusters.
Er gewährleistet eine optimale Ressourcenzuteilung und sorgt zugleich für Ressourcengerechtigkeit zwischen verschiedenen Verbrauchern.
Er kann parallel zu anderen im Cluster installierten Schedulern betrieben werden.

## Hauptfunktionen
* [Batch Scheduling](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/batch/README.md): Stellt sicher, dass alle Pods einer Gruppe gleichzeitig oder gar nicht eingeplant werden.
* Bin Packing & Spread Scheduling: Optimiert die Knotenauslastung entweder durch Minimierung der Fragmentierung (Bin-Packing) oder durch Erhöhung der Ausfallsicherheit und Lastverteilung (Spread Scheduling).
* [Workload-Priorität](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/priority/README.md): Priorisiert Workloads effektiv innerhalb von Warteschlangen.
* [Hierarchische Warteschlangen](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/queues/README.md): Verwalten von Workloads mit zweistufigen Warteschlangen-Hierarchien für flexible organisatorische Kontrolle.
* [Ressourcenverteilung](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/fairness/README.md#resource-division-algorithm): Anpassbare Quoten, Über-Quota-Gewichte, Limits und Prioritäten pro Warteschlange.
* [Fairness-Richtlinien](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/fairness/README.md#reclaim-strategies): Gewährleisten eine gerechte Ressourcenverteilung mit Dominant Resource Fairness (DRF) und Ressourcenrückgewinnung über Warteschlangen hinweg.
* Workload-Konsolidierung: Intelligente Neuverteilung laufender Workloads zur Reduzierung von Fragmentierung und Steigerung der Cluster-Auslastung.
* [Elastische Workloads](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/elastic/README.md): Dynamische Skalierung von Workloads innerhalb definierter minimaler und maximaler Pod-Anzahlen.
* Dynamische Ressourcenallokation (DRA): Unterstützung von herstellerspezifischen Hardware-Ressourcen durch Kubernetes ResourceClaims (z. B. GPUs von NVIDIA oder AMD).
* [GPU-Sharing](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/gpu-sharing/README.md): Ermöglicht mehreren Workloads das effiziente Teilen einzelner oder mehrerer GPUs zur Maximierung der Ressourcenauslastung.
* Cloud- & On-Premises-Unterstützung: Vollständig kompatibel mit dynamischen Cloud-Infrastrukturen (inklusive Auto-Scaler wie Karpenter) sowie mit statischen On-Premises-Bereitstellungen.

## Voraussetzungen
Bevor Sie den KAI Scheduler installieren, stellen Sie bitte sicher, dass Sie Folgendes haben:

- Ein laufendes Kubernetes-Cluster
- [Helm](https://helm.sh/docs/intro/install) CLI installiert
- [NVIDIA GPU-Operator](https://github.com/NVIDIA/gpu-operator) installiert, um Workloads mit GPU-Anforderungen einzuplanen

## Installation
Der KAI Scheduler wird im Namespace `kai-scheduler` installiert. Beim Einreichen von Workloads stellen Sie bitte sicher, einen eigenen Namespace zu verwenden.

### Installationsmethoden
Der KAI Scheduler kann wie folgt installiert werden:

- **Aus der Produktion (empfohlen)**
- **Aus dem Quellcode (Selbst bauen)**

#### Installation aus der Produktion
Die neueste Release-Version finden Sie auf der [Releases-Seite](https://github.com/NVIDIA/KAI-Scheduler/releases).
Führen Sie folgenden Befehl aus, nachdem Sie `<VERSION>` durch die gewünschte Release-Version ersetzt haben:
```sh
helm upgrade -i kai-scheduler oci://ghcr.io/nvidia/kai-scheduler/kai-scheduler -n kai-scheduler --create-namespace --version <VERSION>
```
#### Aus dem Quellcode bauen
Folgen Sie den Anweisungen [hier](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/developer/building-from-source.md)

## Schnellstart
Um mit der Planung von Workloads mit dem KAI Scheduler zu beginnen, lesen Sie bitte das [Schnellstart-Beispiel](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/quickstart/README.md)

## Fahrplan

### Überblick über die wichtigsten Prioritäten für 2025
* Refaktorierung des Code-Basis zur Verbesserung der Anbieterneutralität
* Unterstützung für Scheduling Gates https://github.com/NVIDIA/KAI-Scheduler/issues/63
* Forschung zu möglicher Integration mit Kueue https://github.com/NVIDIA/KAI-Scheduler/issues/68
* Unterstützung für Topology Aware Scheduling von Pod-Gruppen https://github.com/NVIDIA/KAI-Scheduler/issues/66
* Unterstützung für minimale Laufzeit pro Workload
* Unterstützung für maximale Laufzeit pro Workload (mit verzögertem Requeue)
* Hinzufügen weiterer PriorityClasses als Teil der Standard-KAI-Installation
* Unterstützung für JobSet
* Unterstützung für LWS (LeaderWorkerSet)
* Hinzufügen von Metriken für Pod- und Pod-Gruppen-Präemptionen
* Entkopplung von Priorität und Präemption

### Langfristige Ziele
* Unterstützung für zeitlichen Verfall pro Warteschlange
* Verbesserungen für Hyperskalierung
* Unterstützung der Konsolidierung von Inferenz-Workloads zur Defragmentierung des Clusters
* Unterstützung für n-stufige hierarchische Warteschlangen
* Sanftes Ausrollen von Inferenz-Workloads (neues Revisions-Update unter Verwendung temporärer Über-Quota in Warteschlangen)

## Community, Diskussion und Support

Wir freuen uns auf Ihre Rückmeldung! Hier sind die besten Wege, um in Kontakt zu treten:

### Slack
Treten Sie zuerst dem [CNCF Slack](https://communityinviter.com/apps/cloud-native/cncf) bei und besuchen Sie anschließend den [#kai-scheduler](https://cloud-native.slack.com/archives/kai-scheduler) Channel.

### Zweiwöchentlicher Community Call  
**Wann:** Jeden zweiten Montag um 17:00 Uhr CEST  
[In Ihre Zeitzone umrechnen](https://dateful.com/time-zone-converter?t=17&tz2=Germany) | [Zu Ihrem Kalender hinzufügen](https://calendar.google.com/calendar/event?action=TEMPLATE&tmeid=N2Q2bjhoNXAzMGc0cWpnZTQ4OGtpdXFhanFfMjAyNTA2MDlUMTUwMDAwWiAxZjQ2OTZiOWVlM2JiMWE1ZWIzMTAwODBkNDZiZmMwMDZjNTUxYWFiZmU1YTM3ZGM2YTc0NTFhYmNhMmE1ODk0QGc&tmsrc=1f4696b9ee3bb1a5eb310080d46bfc006c551aabfe5a37dc6a7451abca2a5894%40group.calendar.google.com&scp=ALL)  | [Meeting-Notizen & Agenda](https://docs.google.com/document/d/13K7NGdPebOstlrsif1YLjGz1x-aJafMXeIgqbO7WghI/edit?usp=sharing)

### Mailingliste  
Treten Sie der [kai-scheduler Mailingliste](https://groups.google.com/g/kai-scheduler) bei, um Updates zu den zweiwöchentlichen Meetings zu erhalten.

### Technische Probleme & Feature Requests  
Bitte eröffnen Sie ein [GitHub-Issue](https://github.com/NVIDIA/KAI-Scheduler/issues/new/choose) für Bugs, Feature-Vorschläge oder technische Hilfe. So behalten wir den Überblick über Anfragen und können effektiv reagieren.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---
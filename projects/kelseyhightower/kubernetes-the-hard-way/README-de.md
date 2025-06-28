# Kubernetes The Hard Way

Dieses Tutorial führt dich durch die Einrichtung von Kubernetes auf die harte Tour. Dieser Leitfaden richtet sich nicht an Personen, die nach einem vollautomatisierten Tool zur Einrichtung eines Kubernetes-Clusters suchen. Kubernetes The Hard Way ist für das Lernen optimiert, was bedeutet, dass du den langen Weg nimmst, um sicherzustellen, dass du jede Aufgabe verstehst, die zum Bootstrapping eines Kubernetes-Clusters erforderlich ist.

> Die Ergebnisse dieses Tutorials sollten nicht als produktionsreif angesehen werden und erhalten möglicherweise nur begrenzten Support von der Community, aber lass dich davon nicht vom Lernen abhalten!

## Urheberrecht

<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="Creative Commons Lizenz" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/88x31.png" /></a><br />Dieses Werk ist lizenziert unter einer <a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">Creative Commons Namensnennung-NichtKommerziell-Weitergabe unter gleichen Bedingungen 4.0 International Lizenz</a>.


## Zielgruppe

Die Zielgruppe für dieses Tutorial sind Personen, die die Grundlagen von Kubernetes und das Zusammenspiel der Kernkomponenten verstehen möchten.

## Cluster-Details

Kubernetes The Hard Way führt dich durch das Bootstrapping eines einfachen Kubernetes-Clusters mit allen Control-Plane-Komponenten auf einem einzelnen Node und zwei Worker-Nodes, was ausreicht, um die Kernkonzepte zu erlernen.

Komponenten-Versionen:

* [kubernetes](https://github.com/kubernetes/kubernetes) v1.32.x
* [containerd](https://github.com/containerd/containerd) v2.1.x
* [cni](https://github.com/containernetworking/cni) v1.6.x
* [etcd](https://github.com/etcd-io/etcd) v3.6.x

## Labore

Für dieses Tutorial werden vier (4) ARM64- oder AMD64-basierte virtuelle oder physische Maschinen benötigt, die mit demselben Netzwerk verbunden sind.

* [Voraussetzungen](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/01-prerequisites.md)
* [Einrichten der Jumpbox](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/02-jumpbox.md)
* [Bereitstellung von Compute-Ressourcen](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/03-compute-resources.md)
* [Bereitstellung der CA und Generierung von TLS-Zertifikaten](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/04-certificate-authority.md)
* [Generierung von Kubernetes-Konfigurationsdateien für die Authentifizierung](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/05-kubernetes-configuration-files.md)
* [Generierung der Datenverschlüsselungs-Konfiguration und des Schlüssels](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/06-data-encryption-keys.md)
* [Bootstrapping des etcd-Clusters](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/07-bootstrapping-etcd.md)
* [Bootstrapping der Kubernetes Control Plane](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/08-bootstrapping-kubernetes-controllers.md)
* [Bootstrapping der Kubernetes Worker Nodes](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/09-bootstrapping-kubernetes-workers.md)
* [Konfiguration von kubectl für den Remotezugriff](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/10-configuring-kubectl.md)
* [Bereitstellung von Pod-Netzwerk-Routen](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/11-pod-network-routes.md)
* [Smoke Test](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/12-smoke-test.md)
* [Aufräumen](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/13-cleanup.md)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---
# Kubernetes The Hard Way

Deze tutorial leidt je stap voor stap door het opzetten van Kubernetes op de moeilijke manier. Deze gids is niet bedoeld voor iemand die op zoek is naar een volledig geautomatiseerd hulpmiddel om een Kubernetes-cluster op te zetten. Kubernetes The Hard Way is geoptimaliseerd voor leren, wat betekent dat je de lange route neemt om ervoor te zorgen dat je elke taak begrijpt die nodig is om een Kubernetes-cluster te bootstrappen.

> De resultaten van deze tutorial moeten niet als productie-klaar worden beschouwd, en kunnen beperkte ondersteuning van de community ontvangen, maar laat dat je er niet van weerhouden om te leren!

## Copyright

<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="Creative Commons License" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/88x31.png" /></a><br />Dit werk is gelicentieerd onder een <a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">Creative Commons Naamsvermelding-NietCommercieel-GelijkDelen 4.0 Internationaal Licentie</a>.

## Doelgroep

De doelgroep voor deze tutorial is iemand die de basisprincipes van Kubernetes wil begrijpen en hoe de kerncomponenten samenhangen.

## Clusterdetails

Kubernetes The Hard Way begeleidt je bij het bootstrappen van een basis Kubernetes-cluster waarbij alle control plane-componenten op één node draaien, en twee worker nodes, wat voldoende is om de kernconcepten te leren.

Componentversies:

* [kubernetes](https://github.com/kubernetes/kubernetes) v1.32.x
* [containerd](https://github.com/containerd/containerd) v2.1.x
* [cni](https://github.com/containernetworking/cni) v1.6.x
* [etcd](https://github.com/etcd-io/etcd) v3.6.x

## Labs

Deze tutorial vereist vier (4) ARM64- of AMD64-gebaseerde virtuele of fysieke machines die met hetzelfde netwerk zijn verbonden.

* [Vereisten](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/01-prerequisites.md)
* [Jumpbox instellen](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/02-jumpbox.md)
* [Provisioneren van compute resources](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/03-compute-resources.md)
* [Provisioneren van de CA en genereren van TLS-certificaten](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/04-certificate-authority.md)
* [Genereren van Kubernetes configuratiebestanden voor authenticatie](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/05-kubernetes-configuration-files.md)
* [Genereren van de Data Encryption Config en Key](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/06-data-encryption-keys.md)
* [Bootstrappen van de etcd-cluster](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/07-bootstrapping-etcd.md)
* [Bootstrappen van het Kubernetes Control Plane](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/08-bootstrapping-kubernetes-controllers.md)
* [Bootstrappen van de Kubernetes Worker Nodes](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/09-bootstrapping-kubernetes-workers.md)
* [kubectl configureren voor externe toegang](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/10-configuring-kubectl.md)
* [Provisioneren van Pod-netwerkroutes](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/11-pod-network-routes.md)
* [Smoke Test](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/12-smoke-test.md)
* [Opruimen](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/13-cleanup.md)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---
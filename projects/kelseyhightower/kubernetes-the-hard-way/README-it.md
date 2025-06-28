# Kubernetes The Hard Way

Questo tutorial ti guida nell'installazione di Kubernetes nel modo più difficile. Questa guida non è pensata per chi cerca uno strumento completamente automatizzato per mettere in piedi un cluster Kubernetes. Kubernetes The Hard Way è ottimizzato per l'apprendimento, il che significa seguire il percorso più lungo per assicurarti di comprendere ogni attività necessaria per avviare un cluster Kubernetes.

> I risultati di questo tutorial non dovrebbero essere considerati pronti per la produzione e potrebbero ricevere un supporto limitato dalla community, ma questo non deve impedirti di imparare!

## Copyright

<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="Creative Commons License" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/88x31.png" /></a><br />Quest'opera è distribuita con Licenza <a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">Creative Commons Attribuzione-NonCommerciale-Condividi allo stesso modo 4.0 Internazionale</a>.

## Target Audience

Il pubblico a cui è rivolto questo tutorial è costituito da chi vuole comprendere i fondamenti di Kubernetes e come i componenti principali si integrano tra loro.

## Cluster Details

Kubernetes The Hard Way ti guida nell'avvio di un cluster Kubernetes di base con tutti i componenti del control plane in esecuzione su un singolo nodo e due nodi worker, quanto basta per apprendere i concetti fondamentali.

Versioni dei componenti:

* [kubernetes](https://github.com/kubernetes/kubernetes) v1.32.x
* [containerd](https://github.com/containerd/containerd) v2.1.x
* [cni](https://github.com/containernetworking/cni) v1.6.x
* [etcd](https://github.com/etcd-io/etcd) v3.6.x

## Labs

Questo tutorial richiede quattro (4) macchine virtuali o fisiche basate su ARM64 o AMD64 connesse alla stessa rete.

* [Prerequisiti](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/01-prerequisites.md)
* [Configurazione della Jumpbox](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/02-jumpbox.md)
* [Provisioning delle Risorse di Calcolo](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/03-compute-resources.md)
* [Provisioning della CA e Generazione dei Certificati TLS](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/04-certificate-authority.md)
* [Generazione dei File di Configurazione Kubernetes per l'Autenticazione](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/05-kubernetes-configuration-files.md)
* [Generazione della Configurazione e Chiave di Crittografia dei Dati](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/06-data-encryption-keys.md)
* [Bootstrap del Cluster etcd](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/07-bootstrapping-etcd.md)
* [Bootstrap del Control Plane di Kubernetes](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/08-bootstrapping-kubernetes-controllers.md)
* [Bootstrap dei Nodi Worker di Kubernetes](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/09-bootstrapping-kubernetes-workers.md)
* [Configurazione di kubectl per l’Accesso Remoto](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/10-configuring-kubectl.md)
* [Provisioning delle Rotte di Rete dei Pod](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/11-pod-network-routes.md)
* [Smoke Test](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/12-smoke-test.md)
* [Pulizia](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/13-cleanup.md)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---
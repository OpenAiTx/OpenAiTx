# Kubernetes à la dure

Ce tutoriel vous guide dans la mise en place de Kubernetes à la dure. Ce guide ne s'adresse pas à ceux qui recherchent un outil entièrement automatisé pour déployer un cluster Kubernetes. Kubernetes à la dure est optimisé pour l'apprentissage, ce qui signifie prendre la voie longue afin de s'assurer que vous comprenez chaque tâche nécessaire pour amorcer un cluster Kubernetes.

> Les résultats de ce tutoriel ne doivent pas être considérés comme prêts pour la production, et peuvent recevoir un soutien limité de la communauté, mais ne laissez pas cela vous empêcher d'apprendre !

## Copyright

<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="Licence Creative Commons" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/88x31.png" /></a><br />Ce travail est sous licence <a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International</a>.


## Public cible

Le public cible de ce tutoriel est toute personne souhaitant comprendre les fondamentaux de Kubernetes et la façon dont les composants principaux s'articulent.

## Détails du cluster

Kubernetes à la dure vous guide à travers l'amorçage d'un cluster Kubernetes de base avec tous les composants du plan de contrôle s'exécutant sur un seul nœud, et deux nœuds de travail, ce qui est suffisant pour apprendre les concepts de base.

Versions des composants :

* [kubernetes](https://github.com/kubernetes/kubernetes) v1.32.x
* [containerd](https://github.com/containerd/containerd) v2.1.x
* [cni](https://github.com/containernetworking/cni) v1.6.x
* [etcd](https://github.com/etcd-io/etcd) v3.6.x

## Laboratoires

Ce tutoriel nécessite quatre (4) machines virtuelles ou physiques basées sur ARM64 ou AMD64 connectées au même réseau.

* [Prérequis](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/01-prerequisites.md)
* [Mise en place du Jumpbox](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/02-jumpbox.md)
* [Provisionnement des ressources de calcul](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/03-compute-resources.md)
* [Provisionnement de l'autorité de certification et génération des certificats TLS](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/04-certificate-authority.md)
* [Génération des fichiers de configuration Kubernetes pour l'authentification](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/05-kubernetes-configuration-files.md)
* [Génération de la configuration et de la clé de chiffrement des données](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/06-data-encryption-keys.md)
* [Amorçage du cluster etcd](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/07-bootstrapping-etcd.md)
* [Amorçage du plan de contrôle Kubernetes](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/08-bootstrapping-kubernetes-controllers.md)
* [Amorçage des nœuds de travail Kubernetes](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/09-bootstrapping-kubernetes-workers.md)
* [Configuration de kubectl pour l'accès à distance](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/10-configuring-kubectl.md)
* [Provisionnement des routes réseau des pods](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/11-pod-network-routes.md)
* [Test de fumée](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/12-smoke-test.md)
* [Nettoyage](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/13-cleanup.md)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---
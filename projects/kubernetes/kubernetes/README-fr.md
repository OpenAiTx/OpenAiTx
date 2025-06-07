# Kubernetes (K8s)

[![CII Best Practices](https://bestpractices.coreinfrastructure.org/projects/569/badge)](https://bestpractices.coreinfrastructure.org/projects/569) [![Go Report Card](https://goreportcard.com/badge/github.com/kubernetes/kubernetes)](https://goreportcard.com/report/github.com/kubernetes/kubernetes) ![GitHub release (latest SemVer)](https://img.shields.io/github/v/release/kubernetes/kubernetes?sort=semver)

<img src="https://github.com/kubernetes/kubernetes/raw/master/logo/logo.png" width="100">

----

Kubernetes, également connu sous le nom de K8s, est un système open source pour la gestion des [applications conteneurisées]
sur plusieurs hôtes. Il fournit des mécanismes de base pour le déploiement, la maintenance
et la mise à l’échelle des applications.

Kubernetes s’appuie sur une quinzaine d’années d’expérience chez Google pour l’exécution
de charges de travail de production à grande échelle à l’aide d’un système appelé [Borg],
combinée aux meilleures idées et pratiques de la communauté.

Kubernetes est hébergé par la Cloud Native Computing Foundation ([CNCF]).
Si votre entreprise souhaite contribuer à l’évolution des
technologies qui sont emballées dans des conteneurs, planifiées dynamiquement
et orientées microservices, envisagez de rejoindre la CNCF.
Pour plus de détails sur les participants et le rôle de Kubernetes,
lisez l’[annonce] de la CNCF.

----

## Pour commencer à utiliser K8s

Consultez notre documentation sur [kubernetes.io].

Suivez un cours gratuit sur [Microservices Scalables avec Kubernetes].

Pour utiliser le code Kubernetes comme bibliothèque dans d’autres applications, consultez la [liste des composants publiés](https://git.k8s.io/kubernetes/staging/README.md).
L’utilisation du module `k8s.io/kubernetes` ou des packages `k8s.io/kubernetes/...` comme bibliothèques n’est pas prise en charge.

## Pour commencer à développer K8s

Le [dépôt communautaire] contient toutes les informations sur
la compilation de Kubernetes à partir des sources, comment contribuer au code
et à la documentation, à qui s’adresser pour quoi, etc.

Si vous souhaitez compiler Kubernetes immédiatement, deux options s’offrent à vous :

##### Vous disposez d’un [environnement Go] fonctionnel.

```
git clone https://github.com/kubernetes/kubernetes
cd kubernetes
make
```

##### Vous disposez d’un [environnement Docker] fonctionnel.

```
git clone https://github.com/kubernetes/kubernetes
cd kubernetes
make quick-release
```

Pour plus de détails, consultez la [documentation du développeur].

## Support

Si vous avez besoin d’aide, commencez par le [guide de dépannage],
et suivez le processus que nous avons décrit.

Ceci étant dit, si vous avez des questions, contactez-nous
[d’une manière ou d’une autre][communication].

[announcement]: https://cncf.io/news/announcement/2015/07/new-cloud-native-computing-foundation-drive-alignment-among-container
[Borg]: https://research.google.com/pubs/pub43438.html?authuser=1
[CNCF]: https://www.cncf.io/about
[communication]: https://git.k8s.io/community/communication
[community repository]: https://git.k8s.io/community
[containerized applications]: https://kubernetes.io/docs/concepts/overview/what-is-kubernetes/
[developer's documentation]: https://git.k8s.io/community/contributors/devel#readme
[Docker environment]: https://docs.docker.com/engine
[Go environment]: https://go.dev/doc/install
[kubernetes.io]: https://kubernetes.io
[Scalable Microservices with Kubernetes]: https://www.udacity.com/course/scalable-microservices-with-kubernetes--ud615
[troubleshooting guide]: https://kubernetes.io/docs/tasks/debug/

## Réunions communautaires

Le [Calendrier](https://www.kubernetes.dev/resources/calendar/) contient la liste de toutes les réunions de la communauté Kubernetes à un seul endroit.

## Adoptants

Le site [Études de cas utilisateurs](https://kubernetes.io/case-studies/) présente des cas d’utilisation réels d’organisations de divers secteurs qui déploient/migrent vers Kubernetes.

## Gouvernance

Le projet Kubernetes est régi par un cadre de principes, de valeurs, de politiques et de processus pour aider notre communauté et nos parties prenantes à atteindre nos objectifs communs.

La [Communauté Kubernetes](https://github.com/kubernetes/community/blob/master/governance.md) est le point de départ pour découvrir comment nous nous organisons.

Le [dépôt de la communauté Kubernetes Steering](https://github.com/kubernetes/steering) est utilisé par le comité de pilotage Kubernetes, qui supervise la gouvernance du projet Kubernetes.

## Feuille de route

Le [dépôt des améliorations Kubernetes](https://github.com/kubernetes/enhancements) fournit des informations sur les versions de Kubernetes, ainsi que le suivi des fonctionnalités et les arriérés.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---
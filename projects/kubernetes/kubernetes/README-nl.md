# Kubernetes (K8s)

[![CII Best Practices](https://bestpractices.coreinfrastructure.org/projects/569/badge)](https://bestpractices.coreinfrastructure.org/projects/569) [![Go Report Card](https://goreportcard.com/badge/github.com/kubernetes/kubernetes)](https://goreportcard.com/report/github.com/kubernetes/kubernetes) ![GitHub release (latest SemVer)](https://img.shields.io/github/v/release/kubernetes/kubernetes?sort=semver)

<img src="https://github.com/kubernetes/kubernetes/raw/master/logo/logo.png" width="100">

----

Kubernetes, ook bekend als K8s, is een open source systeem voor het beheren van [gecontaineriseerde applicaties]
over meerdere hosts. Het biedt basismechanismen voor de uitrol, het onderhoud
en de schaalvergroting van applicaties.

Kubernetes bouwt voort op anderhalf decennium ervaring bij Google met het draaien van
productieworkloads op schaal met behulp van een systeem genaamd [Borg],
in combinatie met de beste ideeën en praktijken uit de gemeenschap.

Kubernetes wordt gehost door de Cloud Native Computing Foundation ([CNCF]).
Als uw bedrijf wil bijdragen aan de evolutie van
technologieën die in containers zijn verpakt, dynamisch worden gepland,
en microservices-georiënteerd zijn, overweeg dan lid te worden van de CNCF.
Voor details over wie betrokken is en welke rol Kubernetes speelt,
lees de CNCF [aankondiging].

----

## Aan de slag met K8s

Bekijk onze documentatie op [kubernetes.io].

Volg een gratis cursus over [Schaalbare Microservices met Kubernetes].

Om Kubernetes-code als bibliotheek te gebruiken in andere applicaties, zie de [lijst met gepubliceerde componenten](https://git.k8s.io/kubernetes/staging/README.md).
Het gebruik van de `k8s.io/kubernetes` module of `k8s.io/kubernetes/...` pakketten als bibliotheken wordt niet ondersteund.

## Aan de slag met de ontwikkeling van K8s

De [community repository] bevat alle informatie over
het bouwen van Kubernetes vanuit de broncode, hoe je code
en documentatie kunt bijdragen, wie je over wat kunt contacteren, enzovoort.

Als je direct Kubernetes wilt bouwen zijn er twee opties:

##### Je hebt een werkende [Go-omgeving].

```
git clone https://github.com/kubernetes/kubernetes
cd kubernetes
make
```

##### Je hebt een werkende [Docker-omgeving].

```
git clone https://github.com/kubernetes/kubernetes
cd kubernetes
make quick-release
```

Voor het volledige verhaal, bekijk de [ontwikkelaarsdocumentatie].

## Ondersteuning

Als je ondersteuning nodig hebt, begin dan met de [troubleshooting guide]
en volg het proces dat we hebben uiteengezet.

Mocht je toch vragen hebben, neem dan contact met ons op
[op de een of andere manier][communicatie].

[aankondiging]: https://cncf.io/news/announcement/2015/07/new-cloud-native-computing-foundation-drive-alignment-among-container
[Borg]: https://research.google.com/pubs/pub43438.html?authuser=1
[CNCF]: https://www.cncf.io/about
[communicatie]: https://git.k8s.io/community/communication
[community repository]: https://git.k8s.io/community
[gecontaineriseerde applicaties]: https://kubernetes.io/docs/concepts/overview/what-is-kubernetes/
[ontwikkelaarsdocumentatie]: https://git.k8s.io/community/contributors/devel#readme
[Docker-omgeving]: https://docs.docker.com/engine
[Go-omgeving]: https://go.dev/doc/install
[kubernetes.io]: https://kubernetes.io
[Schaalbare Microservices met Kubernetes]: https://www.udacity.com/course/scalable-microservices-with-kubernetes--ud615
[troubleshooting guide]: https://kubernetes.io/docs/tasks/debug/

## Communitybijeenkomsten

De [Kalender](https://www.kubernetes.dev/resources/calendar/) bevat de lijst van alle bijeenkomsten in de Kubernetes-gemeenschap op één plek.

## Gebruikers

De [User Case Studies](https://kubernetes.io/case-studies/) website bevat praktijkvoorbeelden van organisaties uit verschillende sectoren die Kubernetes implementeren/migreren.

## Bestuur

Het Kubernetes-project wordt bestuurd door een raamwerk van principes, waarden, beleid en processen om onze gemeenschap en belanghebbenden te helpen bij het bereiken van onze gedeelde doelen.

De [Kubernetes Community](https://github.com/kubernetes/community/blob/master/governance.md) is het startpunt om te leren hoe wij ons organiseren.

De [Kubernetes Steering community repo](https://github.com/kubernetes/steering) wordt gebruikt door het Kubernetes Steering Committee, dat toezicht houdt op het bestuur van het Kubernetes-project.

## Routekaart

De [Kubernetes Enhancements repo](https://github.com/kubernetes/enhancements) geeft informatie over Kubernetes-releases, evenals feature-tracking en achterstanden.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---
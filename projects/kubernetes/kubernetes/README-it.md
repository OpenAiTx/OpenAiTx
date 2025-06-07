# Kubernetes (K8s)

[![CII Best Practices](https://bestpractices.coreinfrastructure.org/projects/569/badge)](https://bestpractices.coreinfrastructure.org/projects/569) [![Go Report Card](https://goreportcard.com/badge/github.com/kubernetes/kubernetes)](https://goreportcard.com/report/github.com/kubernetes/kubernetes) ![GitHub release (latest SemVer)](https://img.shields.io/github/v/release/kubernetes/kubernetes?sort=semver)

<img src="https://github.com/kubernetes/kubernetes/raw/master/logo/logo.png" width="100">

----

Kubernetes, noto anche come K8s, è un sistema open source per la gestione di [applicazioni containerizzate]
su più host. Fornisce meccanismi di base per il deployment, la manutenzione
e lo scaling delle applicazioni.

Kubernetes si basa su quindici anni di esperienza maturata in Google nell’esecuzione
di carichi di lavoro in produzione su larga scala usando un sistema chiamato [Borg],
combinando le migliori idee e pratiche della comunità.

Kubernetes è ospitato dalla Cloud Native Computing Foundation ([CNCF]).
Se la tua azienda vuole contribuire all’evoluzione delle
tecnologie basate su container, programmate dinamicamente
e orientate ai microservizi, considera l’adesione alla CNCF.
Per dettagli su chi è coinvolto e sul ruolo di Kubernetes,
leggi l’[annuncio] della CNCF.

----

## Per iniziare a usare K8s

Consulta la nostra documentazione su [kubernetes.io].

Segui un corso gratuito su [Scalable Microservices with Kubernetes].

Per utilizzare il codice di Kubernetes come libreria in altre applicazioni, consulta l’[elenco dei componenti pubblicati](https://git.k8s.io/kubernetes/staging/README.md).
L’uso del modulo `k8s.io/kubernetes` o dei pacchetti `k8s.io/kubernetes/...` come librerie non è supportato.

## Per iniziare a sviluppare K8s

Il [repository della community] ospita tutte le informazioni su
come costruire Kubernetes dal sorgente, come contribuire con codice
e documentazione, chi contattare per cosa, ecc.

Se vuoi costruire Kubernetes subito, ci sono due opzioni:

##### Hai un [ambiente Go] funzionante.

```
git clone https://github.com/kubernetes/kubernetes
cd kubernetes
make
```

##### Hai un [ambiente Docker] funzionante.

```
git clone https://github.com/kubernetes/kubernetes
cd kubernetes
make quick-release
```

Per tutti i dettagli, consulta la [documentazione per sviluppatori].

## Supporto

Se hai bisogno di supporto, inizia dalla [guida alla risoluzione dei problemi]
e segui il processo che abbiamo descritto.

Detto ciò, se hai domande, contattaci
[in un modo o nell’altro][communication].

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

## Incontri della community 

Il [Calendario](https://www.kubernetes.dev/resources/calendar/) elenca tutte le riunioni della community Kubernetes in un unico luogo.

## Utilizzatori

Il sito [User Case Studies](https://kubernetes.io/case-studies/) presenta casi d’uso reali di organizzazioni di vari settori che stanno implementando/migrando a Kubernetes.

## Governance 

Il progetto Kubernetes è governato da un quadro di principi, valori, politiche e processi che aiutano la nostra community e i suoi membri a raggiungere obiettivi condivisi.

La [Community di Kubernetes](https://github.com/kubernetes/community/blob/master/governance.md) è il punto di partenza per conoscere come ci organizziamo.

Il [repository Kubernetes Steering](https://github.com/kubernetes/steering) è utilizzato dallo Steering Committee di Kubernetes, che sovrintende alla governance del progetto Kubernetes.

## Roadmap 

Il [repository Kubernetes Enhancements](https://github.com/kubernetes/enhancements) fornisce informazioni sulle release di Kubernetes, nonché sul tracciamento delle funzionalità e sulle attività in backlog.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---
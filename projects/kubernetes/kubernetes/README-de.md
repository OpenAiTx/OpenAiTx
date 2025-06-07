# Kubernetes (K8s)

[![CII Best Practices](https://bestpractices.coreinfrastructure.org/projects/569/badge)](https://bestpractices.coreinfrastructure.org/projects/569) [![Go Report Card](https://goreportcard.com/badge/github.com/kubernetes/kubernetes)](https://goreportcard.com/report/github.com/kubernetes/kubernetes) ![GitHub release (latest SemVer)](https://img.shields.io/github/v/release/kubernetes/kubernetes?sort=semver)

<img src="https://github.com/kubernetes/kubernetes/raw/master/logo/logo.png" width="100">

----

Kubernetes, auch bekannt als K8s, ist ein Open-Source-System zur Verwaltung von [containerisierten Anwendungen] über mehrere Hosts hinweg. Es bietet grundlegende Mechanismen für die Bereitstellung, Wartung und Skalierung von Anwendungen.

Kubernetes baut auf anderthalb Jahrzehnten Erfahrung bei Google mit dem Betrieb von Produktions-Workloads im großen Maßstab unter Verwendung eines Systems namens [Borg] auf, kombiniert mit Best-Practice-Ideen und -Verfahren aus der Community.

Kubernetes wird von der Cloud Native Computing Foundation ([CNCF]) gehostet. Wenn Ihr Unternehmen die Entwicklung von Technologien mitgestalten möchte, die containerbasiert, dynamisch geplant und auf Microservices ausgerichtet sind, sollten Sie der CNCF beitreten. Weitere Informationen darüber, wer beteiligt ist und welche Rolle Kubernetes spielt, finden Sie in der CNCF-[Ankündigung].

----

## Erste Schritte mit K8s

Siehe unsere Dokumentation auf [kubernetes.io].

Belegen Sie einen kostenlosen Kurs zu [Skalierbaren Microservices mit Kubernetes].

Um Kubernetes-Code als Bibliothek in anderen Anwendungen zu verwenden, siehe die [Liste der veröffentlichten Komponenten](https://git.k8s.io/kubernetes/staging/README.md).
Die Verwendung des `k8s.io/kubernetes` Moduls oder der `k8s.io/kubernetes/...` Pakete als Bibliotheken wird nicht unterstützt.

## Erste Schritte bei der K8s-Entwicklung

Im [Community-Repository] finden Sie alle Informationen zum Bauen von Kubernetes aus dem Quellcode, zum Beitragen von Code und Dokumentation, wer für was zu kontaktieren ist usw.

Wenn Sie Kubernetes sofort bauen möchten, gibt es zwei Möglichkeiten:

##### Sie haben eine funktionierende [Go-Umgebung].

```
git clone https://github.com/kubernetes/kubernetes
cd kubernetes
make
```

##### Sie haben eine funktionierende [Docker-Umgebung].

```
git clone https://github.com/kubernetes/kubernetes
cd kubernetes
make quick-release
```

Die vollständigen Informationen finden Sie in der [Entwicklerdokumentation].

## Support

Wenn Sie Unterstützung benötigen, beginnen Sie mit der [Fehlerbehebungsanleitung] und folgen Sie dem von uns skizzierten Prozess.

Wenn Sie dennoch Fragen haben, kontaktieren Sie uns [auf die eine oder andere Weise][Kommunikation].

[Ankündigung]: https://cncf.io/news/announcement/2015/07/new-cloud-native-computing-foundation-drive-alignment-among-container
[Borg]: https://research.google.com/pubs/pub43438.html?authuser=1
[CNCF]: https://www.cncf.io/about
[Kommunikation]: https://git.k8s.io/community/communication
[Community-Repository]: https://git.k8s.io/community
[containerisierten Anwendungen]: https://kubernetes.io/docs/concepts/overview/what-is-kubernetes/
[Entwicklerdokumentation]: https://git.k8s.io/community/contributors/devel#readme
[Docker-Umgebung]: https://docs.docker.com/engine
[Go-Umgebung]: https://go.dev/doc/install
[kubernetes.io]: https://kubernetes.io
[Skalierbaren Microservices mit Kubernetes]: https://www.udacity.com/course/scalable-microservices-with-kubernetes--ud615
[Fehlerbehebungsanleitung]: https://kubernetes.io/docs/tasks/debug/

## Community-Meetings

Der [Kalender](https://www.kubernetes.dev/resources/calendar/) enthält eine Liste aller Meetings in der Kubernetes-Community an einem Ort.

## Anwender

Die [User Case Studies](https://kubernetes.io/case-studies/) Webseite enthält reale Anwendungsfälle von Organisationen aus verschiedenen Branchen, die Kubernetes einführen oder migrieren.

## Governance

Das Kubernetes-Projekt wird durch ein Rahmenwerk aus Prinzipien, Werten, Richtlinien und Prozessen gesteuert, das unserer Community und allen Beteiligten hilft, unsere gemeinsamen Ziele zu erreichen.

Die [Kubernetes Community](https://github.com/kubernetes/community/blob/master/governance.md) ist der Ausgangspunkt, um zu erfahren, wie wir uns organisieren.

Das [Kubernetes Steering Community Repository](https://github.com/kubernetes/steering) wird vom Kubernetes Steering Committee verwendet, das die Governance des Kubernetes-Projekts überwacht.

## Roadmap

Das [Kubernetes Enhancements Repository](https://github.com/kubernetes/enhancements) bietet Informationen zu Kubernetes-Releases sowie Feature-Tracking und Backlogs.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---
# Kubernetes (K8s)

[![CII Best Practices](https://bestpractices.coreinfrastructure.org/projects/569/badge)](https://bestpractices.coreinfrastructure.org/projects/569) [![Go Report Card](https://goreportcard.com/badge/github.com/kubernetes/kubernetes)](https://goreportcard.com/report/github.com/kubernetes/kubernetes) ![GitHub release (latest SemVer)](https://img.shields.io/github/v/release/kubernetes/kubernetes?sort=semver)

<img src="https://github.com/kubernetes/kubernetes/raw/master/logo/logo.png" width="100">

----

Kubernetes, znany również jako K8s, to otwartoźródłowy system do zarządzania [aplikacjami konteneryzowanymi]
na wielu hostach. Zapewnia podstawowe mechanizmy wdrażania, utrzymania
i skalowania aplikacji.

Kubernetes bazuje na ponad piętnastoletnim doświadczeniu Google w uruchamianiu
obciążeń produkcyjnych na dużą skalę przy użyciu systemu o nazwie [Borg],
połączonym z najlepszymi pomysłami i praktykami wypracowanymi przez społeczność.

Kubernetes jest hostowany przez Cloud Native Computing Foundation ([CNCF]).
Jeśli Twoja firma chce mieć wpływ na rozwój technologii
pakowanych w kontenery, dynamicznie harmonogramowanych
i zorientowanych na mikroserwisy, rozważ dołączenie do CNCF.
Aby uzyskać szczegóły na temat tego, kto jest zaangażowany i jaką rolę odgrywa Kubernetes,
przeczytaj [ogłoszenie] CNCF.

----

## Jak zacząć korzystać z K8s

Zobacz naszą dokumentację na [kubernetes.io].

Skorzystaj z bezpłatnego kursu [Skalowalne Mikroserwisy z Kubernetes].

Aby użyć kodu Kubernetes jako biblioteki w innych aplikacjach, zobacz [listę opublikowanych komponentów](https://git.k8s.io/kubernetes/staging/README.md).
Używanie modułu `k8s.io/kubernetes` lub pakietów `k8s.io/kubernetes/...` jako bibliotek nie jest wspierane.

## Jak zacząć rozwijać K8s

[Repozytorium społeczności] zawiera wszystkie informacje dotyczące
budowania Kubernetes ze źródeł, jak kontrybuować kod
i dokumentację, z kim się kontaktować w jakiej sprawie itd.

Jeśli chcesz od razu zbudować Kubernetes, masz dwie opcje:

##### Masz działające [środowisko Go].

```
git clone https://github.com/kubernetes/kubernetes
cd kubernetes
make
```

##### Masz działające [środowisko Docker].

```
git clone https://github.com/kubernetes/kubernetes
cd kubernetes
make quick-release
```

Aby poznać szczegóły, przejdź do [dokumentacji dla deweloperów].

## Wsparcie

Jeśli potrzebujesz wsparcia, zacznij od [przewodnika rozwiązywania problemów]
i postępuj zgodnie z opisanym tam procesem.

Jeśli jednak masz pytania, skontaktuj się z nami
[w taki czy inny sposób][komunikacja].

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

## Spotkania społeczności

[Kalendarz](https://www.kubernetes.dev/resources/calendar/) zawiera listę wszystkich spotkań społeczności Kubernetes w jednym miejscu.

## Użytkownicy

Strona [Studia przypadków użytkowników](https://kubernetes.io/case-studies/) prezentuje rzeczywiste przykłady użycia przez organizacje z różnych branż, które wdrażają lub migrują do Kubernetes.

## Zarządzanie

Projekt Kubernetes jest zarządzany przez ramy zasad, wartości, polityk i procesów, które pomagają naszej społeczności i interesariuszom osiągać wspólne cele.

[Kubernetes Community](https://github.com/kubernetes/community/blob/master/governance.md) to punkt wyjścia do poznania naszej organizacji.

[Repozytorium Kubernetes Steering](https://github.com/kubernetes/steering) jest używane przez Komitet Sterujący Kubernetes, który nadzoruje zarządzanie projektem Kubernetes.

## Mapa drogowa

[Repozytorium Kubernetes Enhancements](https://github.com/kubernetes/enhancements) zawiera informacje o wydaniach Kubernetes, a także o śledzeniu funkcji i backlogach.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---
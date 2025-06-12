![Logo Envoy](https://github.com/envoyproxy/artwork/blob/main/PNG/Envoy_Logo_Final_PANTONE.png)

[Natywny dla chmury, wysokowydajny proxy brzegowy/pośredni/usługowy](https://www.envoyproxy.io/)

Envoy jest hostowany przez [Cloud Native Computing Foundation](https://cncf.io) (CNCF). Jeśli jesteś
firmą, która chce współtworzyć ewolucję technologii opartych na kontenerach,
dynamicznym harmonogramowaniu i mikroserwisach, rozważ dołączenie do CNCF. Szczegóły dotyczące uczestników
oraz roli Envoy można znaleźć w ogłoszeniu CNCF
[announcement](https://www.cncf.io/blog/2017/09/13/cncf-hosts-envoy/).

[![CII Best Practices](https://bestpractices.coreinfrastructure.org/projects/1266/badge)](https://bestpractices.coreinfrastructure.org/projects/1266)
[![OpenSSF Scorecard](https://api.securityscorecards.dev/projects/github.com/envoyproxy/envoy/badge)](https://securityscorecards.dev/viewer/?uri=github.com/envoyproxy/envoy)
[![CLOMonitor](https://img.shields.io/endpoint?url=https://clomonitor.io/api/projects/cncf/envoy/badge)](https://clomonitor.io/projects/cncf/envoy)
[![Azure Pipelines](https://dev.azure.com/cncf/envoy/_apis/build/status/11?branchName=main)](https://dev.azure.com/cncf/envoy/_build/latest?definitionId=11&branchName=main)
[![Fuzzing Status](https://oss-fuzz-build-logs.storage.googleapis.com/badges/envoy.svg)](https://bugs.chromium.org/p/oss-fuzz/issues/list?sort=-opened&can=1&q=proj:envoy)
[![Jenkins](https://powerci.osuosl.org/buildStatus/icon?job=build-envoy-static-master&subject=ppc64le%20build)](https://powerci.osuosl.org/job/build-envoy-static-master/)
[![Jenkins](https://ibmz-ci.osuosl.org/buildStatus/icon?job=Envoy_IBMZ_CI&subject=s390x%20build)](https://ibmz-ci.osuosl.org/job/Envoy_IBMZ_CI/)

## Dokumentacja

* [Oficjalna dokumentacja](https://www.envoyproxy.io/)
* [FAQ](https://www.envoyproxy.io/docs/envoy/latest/faq/overview)
* [Dokumentacja przykładów](https://github.com/envoyproxy/examples/)
* [Blog](https://medium.com/@mattklein123/envoy-threading-model-a8d44b922310) o modelu wątkowania
* [Blog](https://medium.com/@mattklein123/envoy-hot-restart-1d16b14555b5) o gorącym restarcie
* [Blog](https://medium.com/@mattklein123/envoy-stats-b65c7f363342) o architekturze statystyk
* [Blog](https://medium.com/@mattklein123/the-universal-data-plane-api-d15cec7a) o uniwersalnym API płaszczyzny danych
* [Blog](https://medium.com/@mattklein123/lyfts-envoy-dashboards-5c91738816b1) o dashboardach Envoy w Lyft

## Powiązane

* [data-plane-api](https://github.com/envoyproxy/data-plane-api): definicje API v2 jako osobne
  repozytorium. To jest tylko do odczytu lustrzana kopia [api](https://raw.githubusercontent.com/envoyproxy/envoy/main/api/).
* [envoy-perf](https://github.com/envoyproxy/envoy-perf): Framework do testów wydajnościowych.
* [envoy-filter-example](https://github.com/envoyproxy/envoy-filter-example): Przykład jak dodać nowe filtry
  i połączyć z głównym repozytorium.

## Kontakt

* [envoy-announce](https://groups.google.com/forum/#!forum/envoy-announce): Niskoczęstotliwościowa lista
  mailingowa tylko do ogłoszeń.
* [envoy-security-announce](https://groups.google.com/forum/#!forum/envoy-security-announce): Niskoczęstotliwościowa lista
  mailingowa tylko do ogłoszeń związanych z bezpieczeństwem.
* [envoy-users](https://groups.google.com/forum/#!forum/envoy-users): Ogólna dyskusja użytkowników.
* [envoy-dev](https://groups.google.com/forum/#!forum/envoy-dev): Dyskusja deweloperska Envoy (API,
  projektowanie funkcji, itd.).
* [envoy-maintainers](https://groups.google.com/forum/#!forum/envoy-maintainers): Użyj tej listy,
  aby skontaktować się ze wszystkimi głównymi maintainerami Envoy.
* [Twitter](https://twitter.com/EnvoyProxy/): Śledź nas na Twitterze!
* [Slack](https://envoyproxy.slack.com/): Slack, aby otrzymać zaproszenie przejdź [tutaj](https://communityinviter.com/apps/envoyproxy/envoy).
  * UWAGA: Odpowiedzi na pytania użytkowników na Slacku są udzielane w miarę możliwości. Aby uzyskać "gwarantowaną" odpowiedź, prosimy pisać na envoy-users@ zgodnie z wytycznymi w poniższym wątku.

Prosimy zapoznać się z [tym](https://groups.google.com/forum/#!topic/envoy-announce/l9zjYsnS3TY) wątkiem email
w celu uzyskania informacji o korzystaniu z list mailingowych.

## Wkład

Wkład w Envoy to przyjemność, a nowoczesny C++ jest znacznie mniej straszny niż się wydaje, nawet jeśli nie masz wcześniejszego doświadczenia. Aby zacząć:

* [Przewodnik po kontrybucji](https://raw.githubusercontent.com/envoyproxy/envoy/main/CONTRIBUTING.md)
* [Zadania dla początkujących](https://github.com/envoyproxy/envoy/issues?q=is%3Aopen+is%3Aissue+label%3Abeginner)
* [Szybki start budowania/testowania przy użyciu dockera](https://raw.githubusercontent.com/envoyproxy/envoy/main/ci#building-and-running-tests-as-a-developer)
* [Przewodnik dla deweloperów](https://raw.githubusercontent.com/envoyproxy/envoy/main/DEVELOPER.md)
* Rozważ zainstalowanie [zestawu narzędzi wspierających rozwój Envoy](https://github.com/envoyproxy/envoy/blob/main/support/README.md), który pomaga automatyzować część procesu rozwoju, szczególnie te związane z przeglądem kodu.
* Prosimy upewnić się, że dajesz nam znać, jeśli pracujesz nad jakimś zagadnieniem, aby uniknąć dublowania pracy!

## Spotkanie Społeczności

Zespół Envoy ma zaplanowane spotkania dwa razy w miesiącu, we wtorek o 9:00 czasu PT. Publiczny
kalendarz Google jest [tutaj](https://goo.gl/PkDijT).  Spotkanie odbędzie się tylko,
jeśli w [protokole spotkania](https://goo.gl/5Cergb) pojawią się punkty agendy. Każdy członek społeczności może
zaproponować punkty agendy poprzez dodanie ich do protokołu. Maintainerzy potwierdzą
dodatki do agendy lub odwołają spotkanie w ciągu 24 godzin od planowanej daty, jeśli nie będzie potwierdzonej agendy.

## Bezpieczeństwo

### Audyt bezpieczeństwa

Przeprowadzono kilka zewnętrznych audytów bezpieczeństwa Envoy:
* W 2018 roku Cure53 przeprowadziło audyt bezpieczeństwa, [pełny raport](https://raw.githubusercontent.com/envoyproxy/envoy/main/docs/security/audit_cure53_2018.pdf).
* W 2021 roku Ada Logics przeprowadziło audyt infrastruktury fuzzingu wraz z rekomendacjami ulepszeń, [pełny raport](https://raw.githubusercontent.com/envoyproxy/envoy/main/docs/security/audit_fuzzer_adalogics_2021.pdf).

### Zgłaszanie luk bezpieczeństwa

Jeśli znalazłeś lukę lub potencjalną lukę w Envoy, prosimy o kontakt na
[envoy-security](mailto:envoy-security@googlegroups.com). Wyślemy potwierdzenie
odebrania zgłoszenia, a następnie kolejną wiadomość po zidentyfikowaniu problemu
pozytywnie lub negatywnie.

Więcej szczegółów można znaleźć w naszym pełnym [procesie wydawania poprawek bezpieczeństwa](https://raw.githubusercontent.com/envoyproxy/envoy/main/SECURITY.md).

### Buildy ppc64le

Buildy dla architektury ppc64le lub używające aws-lc nie są objęte polityką bezpieczeństwa Envoy. Architektura ppc64le jest obecnie wspierana w miarę możliwości i nie jest utrzymywana przez maintainerów Envoy.

## Wydania

Więcej szczegółów można znaleźć w naszym [procesie wydawania wydań](https://raw.githubusercontent.com/envoyproxy/envoy/main/RELEASES.md).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-12

---
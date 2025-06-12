![Envoy Logo](https://github.com/envoyproxy/artwork/blob/main/PNG/Envoy_Logo_Final_PANTONE.png)

[Cloud-native high-performance edge/middle/service proxy](https://www.envoyproxy.io/)

Envoy wordt gehost door de [Cloud Native Computing Foundation](https://cncf.io) (CNCF). Als je een
bedrijf bent dat wil bijdragen aan de evolutie van technologieën die container-verpakt,
dynamisch-gepland en microservices-georiënteerd zijn, overweeg dan om lid te worden van de CNCF. Voor details over wie
betrokken is en hoe Envoy een rol speelt, lees de CNCF
[aankondiging](https://www.cncf.io/blog/2017/09/13/cncf-hosts-envoy/).

[![CII Best Practices](https://bestpractices.coreinfrastructure.org/projects/1266/badge)](https://bestpractices.coreinfrastructure.org/projects/1266)
[![OpenSSF Scorecard](https://api.securityscorecards.dev/projects/github.com/envoyproxy/envoy/badge)](https://securityscorecards.dev/viewer/?uri=github.com/envoyproxy/envoy)
[![CLOMonitor](https://img.shields.io/endpoint?url=https://clomonitor.io/api/projects/cncf/envoy/badge)](https://clomonitor.io/projects/cncf/envoy)
[![Azure Pipelines](https://dev.azure.com/cncf/envoy/_apis/build/status/11?branchName=main)](https://dev.azure.com/cncf/envoy/_build/latest?definitionId=11&branchName=main)
[![Fuzzing Status](https://oss-fuzz-build-logs.storage.googleapis.com/badges/envoy.svg)](https://bugs.chromium.org/p/oss-fuzz/issues/list?sort=-opened&can=1&q=proj:envoy)
[![Jenkins](https://powerci.osuosl.org/buildStatus/icon?job=build-envoy-static-master&subject=ppc64le%20build)](https://powerci.osuosl.org/job/build-envoy-static-master/)
[![Jenkins](https://ibmz-ci.osuosl.org/buildStatus/icon?job=Envoy_IBMZ_CI&subject=s390x%20build)](https://ibmz-ci.osuosl.org/job/Envoy_IBMZ_CI/)

## Documentatie

* [Officiële documentatie](https://www.envoyproxy.io/)
* [FAQ](https://www.envoyproxy.io/docs/envoy/latest/faq/overview)
* [Voorbeeld documentatie](https://github.com/envoyproxy/examples/)
* [Blog](https://medium.com/@mattklein123/envoy-threading-model-a8d44b922310) over het threading model
* [Blog](https://medium.com/@mattklein123/envoy-hot-restart-1d16b14555b5) over hot restart
* [Blog](https://medium.com/@mattklein123/envoy-stats-b65c7f363342) over de statistiekenarchitectuur
* [Blog](https://medium.com/@mattklein123/the-universal-data-plane-api-d15cec7a) over de universele data plane API
* [Blog](https://medium.com/@mattklein123/lyfts-envoy-dashboards-5c91738816b1) over Lyft's Envoy dashboards

## Gerelateerd

* [data-plane-api](https://github.com/envoyproxy/data-plane-api): v2 API-definities als een op zichzelf staande
  repository. Dit is een alleen-lezen spiegel van [api](api/).
* [envoy-perf](https://github.com/envoyproxy/envoy-perf): Framework voor prestatietesten.
* [envoy-filter-example](https://github.com/envoyproxy/envoy-filter-example): Voorbeeld van hoe nieuwe filters toe te voegen
  en te koppelen aan de hoofdrepository.

## Contact

* [envoy-announce](https://groups.google.com/forum/#!forum/envoy-announce): Mailinglijst met lage frequentie
  waarop we alleen aankondigingen sturen.
* [envoy-security-announce](https://groups.google.com/forum/#!forum/envoy-security-announce): Mailinglijst met lage frequentie
  waarop we alleen beveiligingsgerelateerde aankondigingen sturen.
* [envoy-users](https://groups.google.com/forum/#!forum/envoy-users): Algemene gebruikersdiscussie.
* [envoy-dev](https://groups.google.com/forum/#!forum/envoy-dev): Envoy ontwikkelaarsdiscussie (API's,
  feature-ontwerp, enz.).
* [envoy-maintainers](https://groups.google.com/forum/#!forum/envoy-maintainers): Gebruik deze lijst
  om alle kern-Envoy-onderhouders te bereiken.
* [Twitter](https://twitter.com/EnvoyProxy/): Volg ons op Twitter!
* [Slack](https://envoyproxy.slack.com/): Slack, om uitgenodigd te worden ga [hier](https://communityinviter.com/apps/envoyproxy/envoy).
  * LET OP: Reactie op gebruikersvragen is op best-effort basis op Slack. Voor een "gegarandeerde" reactie, stuur
    een e-mail naar envoy-users@ volgens de richtlijnen in de volgende gelinkte thread.

Zie [deze](https://groups.google.com/forum/#!topic/envoy-announce/l9zjYsnS3TY) e-mailthread
voor informatie over het gebruik van de e-maillijsten.

## Bijdragen

Bijdragen aan Envoy is leuk en modern C++ is veel minder eng dan je misschien denkt als je geen
ervaring hebt. Om te beginnen:

* [Bijdragegids](CONTRIBUTING.md)
* [Beginner issues](https://github.com/envoyproxy/envoy/issues?q=is%3Aopen+is%3Aissue+label%3Abeginner)
* [Snel starten met bouwen/testen via docker](ci#building-and-running-tests-as-a-developer)
* [Ontwikkelaarsgids](DEVELOPER.md)
* Overweeg om de Envoy [development support toolchain](https://github.com/envoyproxy/envoy/blob/main/support/README.md) te installeren, die helpt bij het automatiseren van delen van het ontwikkelproces, met name met betrekking tot code review.
* Laat het ons alsjeblieft weten als je aan een issue werkt, zodat we werk niet dubbel doen!

## Community Meeting

Het Envoy-team heeft twee keer per maand een geplande vergadering op dinsdag om 9 uur PT. De openbare
Google-agenda is [hier](https://goo.gl/PkDijT).  De vergadering vindt alleen plaats
als er agendapunten staan in de [notulen](https://goo.gl/5Cergb). Elk lid van de community moet in
staat zijn om agendapunten toe te voegen aan de notulen. De onderhouders zullen
de toevoegingen aan de agenda bevestigen, of de vergadering annuleren binnen 24 uur voor de geplande
datum als er geen bevestigde agenda is.

## Beveiliging

### Security Audit

Er zijn verschillende derde partijen geweest die zich op Envoy-beveiliging hebben gericht:
* In 2018 heeft Cure53 een beveiligingsaudit uitgevoerd, [volledig rapport](https://raw.githubusercontent.com/envoyproxy/envoy/main/docs/security/audit_cure53_2018.pdf).
* In 2021 heeft Ada Logics een audit uitgevoerd op onze fuzzing infrastructuur met aanbevelingen voor verbeteringen, [volledig rapport](https://raw.githubusercontent.com/envoyproxy/envoy/main/docs/security/audit_fuzzer_adalogics_2021.pdf).

### Beveiligingslekken melden

Als je een kwetsbaarheid of een potentiële kwetsbaarheid in Envoy hebt gevonden, laat het ons dan weten op
[envoy-security](mailto:envoy-security@googlegroups.com). We sturen een bevestigingsmail
om je melding te erkennen, en we sturen een extra mail wanneer we het probleem
positief of negatief hebben geïdentificeerd.

Voor meer details, zie ons volledige [beveiligingsreleaseproces](SECURITY.md).

### ppc64le builds

Builds voor de ppc64le architectuur of met gebruik van aws-lc vallen niet onder het envoy beveiligingsbeleid. De ppc64le architectuur is momenteel best-effort en wordt niet onderhouden door de Envoy-onderhouders.

## Releases

Voor meer details, zie ons [releaseproces](https://github.com/envoyproxy/envoy/blob/main/RELEASES.md).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-12

---
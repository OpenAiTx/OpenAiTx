![Logo Envoy](https://github.com/envoyproxy/artwork/blob/main/PNG/Envoy_Logo_Final_PANTONE.png)

[Proxy edge/middle/service cloud-native ad alte prestazioni](https://www.envoyproxy.io/)

Envoy è ospitato dalla [Cloud Native Computing Foundation](https://cncf.io) (CNCF). Se sei un'azienda che desidera contribuire a plasmare l'evoluzione delle tecnologie containerizzate, con orchestrazione dinamica e orientate ai microservizi, considera di unirti alla CNCF. Per dettagli su chi è coinvolto e come Envoy svolge un ruolo, leggi l'[annuncio](https://www.cncf.io/blog/2017/09/13/cncf-hosts-envoy/) della CNCF.

[![CII Best Practices](https://bestpractices.coreinfrastructure.org/projects/1266/badge)](https://bestpractices.coreinfrastructure.org/projects/1266)
[![OpenSSF Scorecard](https://api.securityscorecards.dev/projects/github.com/envoyproxy/envoy/badge)](https://securityscorecards.dev/viewer/?uri=github.com/envoyproxy/envoy)
[![CLOMonitor](https://img.shields.io/endpoint?url=https://clomonitor.io/api/projects/cncf/envoy/badge)](https://clomonitor.io/projects/cncf/envoy)
[![Azure Pipelines](https://dev.azure.com/cncf/envoy/_apis/build/status/11?branchName=main)](https://dev.azure.com/cncf/envoy/_build/latest?definitionId=11&branchName=main)
[![Fuzzing Status](https://oss-fuzz-build-logs.storage.googleapis.com/badges/envoy.svg)](https://bugs.chromium.org/p/oss-fuzz/issues/list?sort=-opened&can=1&q=proj:envoy)
[![Jenkins](https://powerci.osuosl.org/buildStatus/icon?job=build-envoy-static-master&subject=ppc64le%20build)](https://powerci.osuosl.org/job/build-envoy-static-master/)
[![Jenkins](https://ibmz-ci.osuosl.org/buildStatus/icon?job=Envoy_IBMZ_CI&subject=s390x%20build)](https://ibmz-ci.osuosl.org/job/Envoy_IBMZ_CI/)

## Documentazione

* [Documentazione ufficiale](https://www.envoyproxy.io/)
* [FAQ](https://www.envoyproxy.io/docs/envoy/latest/faq/overview)
* [Documentazione di esempio](https://github.com/envoyproxy/examples/)
* [Blog](https://medium.com/@mattklein123/envoy-threading-model-a8d44b922310) sul modello di threading
* [Blog](https://medium.com/@mattklein123/envoy-hot-restart-1d16b14555b5) sul riavvio a caldo
* [Blog](https://medium.com/@mattklein123/envoy-stats-b65c7f363342) sull'architettura delle statistiche
* [Blog](https://medium.com/@mattklein123/the-universal-data-plane-api-d15cec7a) sull'Universal Data Plane API
* [Blog](https://medium.com/@mattklein123/lyfts-envoy-dashboards-5c91738816b1) sulle dashboard Envoy di Lyft

## Correlati

* [data-plane-api](https://github.com/envoyproxy/data-plane-api): definizioni API v2 come repository autonomo. Questo è uno specchio di sola lettura di [api](https://raw.githubusercontent.com/envoyproxy/envoy/main/api/).
* [envoy-perf](https://github.com/envoyproxy/envoy-perf): framework per il test delle prestazioni.
* [envoy-filter-example](https://github.com/envoyproxy/envoy-filter-example): esempio di come aggiungere nuovi filtri e collegarli al repository principale.

## Contatti

* [envoy-announce](https://groups.google.com/forum/#!forum/envoy-announce): mailing list a bassa frequenza dove verranno inviate solo comunicazioni importanti.
* [envoy-security-announce](https://groups.google.com/forum/#!forum/envoy-security-announce): mailing list a bassa frequenza dove verranno inviate solo comunicazioni relative alla sicurezza.
* [envoy-users](https://groups.google.com/forum/#!forum/envoy-users): discussione generale per gli utenti.
* [envoy-dev](https://groups.google.com/forum/#!forum/envoy-dev): discussione tra sviluppatori Envoy (API, progettazione funzionalità, ecc.).
* [envoy-maintainers](https://groups.google.com/forum/#!forum/envoy-maintainers): utilizza questa lista per contattare tutti i maintainer principali di Envoy.
* [Twitter](https://twitter.com/EnvoyProxy/): Segui su Twitter!
* [Slack](https://envoyproxy.slack.com/): Slack, per ricevere un invito vai [qui](https://communityinviter.com/apps/envoyproxy/envoy).
  * NOTA: le risposte alle domande degli utenti su Slack sono fornite su base migliore. Per una risposta "garantita" si prega di inviare un'email a envoy-users@ come indicato nella discussione collegata di seguito.

Consulta [questa](https://groups.google.com/forum/#!topic/envoy-announce/l9zjYsnS3TY) discussione email per informazioni sull'utilizzo delle mailing list.

## Contribuire

Contribuire a Envoy è divertente e il C++ moderno è molto meno spaventoso di quanto si possa pensare, anche senza esperienza pregressa. Per iniziare:

* [Guida al contributo](https://raw.githubusercontent.com/envoyproxy/envoy/main/CONTRIBUTING.md)
* [Issue per principianti](https://github.com/envoyproxy/envoy/issues?q=is%3Aopen+is%3Aissue+label%3Abeginner)
* [Guida rapida build/test tramite docker](https://raw.githubusercontent.com/envoyproxy/envoy/main/ci#building-and-running-tests-as-a-developer)
* [Guida per sviluppatori](https://raw.githubusercontent.com/envoyproxy/envoy/main/DEVELOPER.md)
* Considera l'installazione del [toolchain di supporto per lo sviluppo di Envoy](https://github.com/envoyproxy/envoy/blob/main/support/README.md), che aiuta ad automatizzare alcune parti del processo di sviluppo, in particolare quelle relative alla revisione del codice.
* Per favore, assicurati di farci sapere se stai lavorando a una issue in modo da evitare duplicati!

## Riunione della Comunità

Il team di Envoy ha una riunione programmata due volte al mese il martedì alle 9:00 PT. Il calendario pubblico di Google è [qui](https://goo.gl/PkDijT). La riunione si terrà solo se ci sono punti all'ordine del giorno elencati nei [verbali della riunione](https://goo.gl/5Cergb). Qualsiasi membro della community può proporre punti all'ordine del giorno aggiungendoli ai verbali. I maintainer confermeranno le aggiunte all'agenda o cancelleranno la riunione entro 24 ore dalla data programmata se non ci sono argomenti confermati.

## Sicurezza

### Audit di Sicurezza

Ci sono stati diversi interventi di terze parti focalizzati sulla sicurezza di Envoy:
* Nel 2018 Cure53 ha effettuato un audit di sicurezza, [rapporto completo](https://raw.githubusercontent.com/envoyproxy/envoy/main/docs/security/audit_cure53_2018.pdf).
* Nel 2021 Ada Logics ha condotto un audit sulla nostra infrastruttura di fuzzing con raccomandazioni per miglioramenti, [rapporto completo](https://raw.githubusercontent.com/envoyproxy/envoy/main/docs/security/audit_fuzzer_adalogics_2021.pdf).

### Segnalazione di vulnerabilità di sicurezza

Se hai trovato una vulnerabilità o una potenziale vulnerabilità in Envoy, ti preghiamo di informarci a [envoy-security](mailto:envoy-security@googlegroups.com). Invieremo un'email di conferma per riconoscere la tua segnalazione e invieremo un'ulteriore email quando avremo identificato la questione in modo positivo o negativo.

Per ulteriori dettagli consulta il nostro completo [processo di rilascio per la sicurezza](https://raw.githubusercontent.com/envoyproxy/envoy/main/SECURITY.md).

### Build ppc64le

Le build per l'architettura ppc64le o che utilizzano aws-lc non sono coperte dalla policy di sicurezza di Envoy. L'architettura ppc64le è attualmente gestita su base "best-effort" e non è mantenuta dai maintainer di Envoy.

## Release

Per ulteriori dettagli consulta il nostro [processo di rilascio](https://github.com/envoyproxy/envoy/blob/main/RELEASES.md).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-12

---
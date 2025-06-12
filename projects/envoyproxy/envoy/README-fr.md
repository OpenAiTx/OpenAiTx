![Logo Envoy](https://github.com/envoyproxy/artwork/blob/main/PNG/Envoy_Logo_Final_PANTONE.png)

[Proxy cloud-native haute performance edge/middle/service](https://www.envoyproxy.io/)

Envoy est hébergé par la [Cloud Native Computing Foundation](https://cncf.io) (CNCF). Si vous êtes une
entreprise souhaitant contribuer à l’évolution des technologies packagées dans des conteneurs,
planifiées dynamiquement et orientées microservices, envisagez de rejoindre la CNCF. Pour plus de détails sur les
participants et le rôle joué par Envoy, lisez l’
[annonce](https://www.cncf.io/blog/2017/09/13/cncf-hosts-envoy/) de la CNCF.

[![CII Best Practices](https://bestpractices.coreinfrastructure.org/projects/1266/badge)](https://bestpractices.coreinfrastructure.org/projects/1266)
[![OpenSSF Scorecard](https://api.securityscorecards.dev/projects/github.com/envoyproxy/envoy/badge)](https://securityscorecards.dev/viewer/?uri=github.com/envoyproxy/envoy)
[![CLOMonitor](https://img.shields.io/endpoint?url=https://clomonitor.io/api/projects/cncf/envoy/badge)](https://clomonitor.io/projects/cncf/envoy)
[![Azure Pipelines](https://dev.azure.com/cncf/envoy/_apis/build/status/11?branchName=main)](https://dev.azure.com/cncf/envoy/_build/latest?definitionId=11&branchName=main)
[![Fuzzing Status](https://oss-fuzz-build-logs.storage.googleapis.com/badges/envoy.svg)](https://bugs.chromium.org/p/oss-fuzz/issues/list?sort=-opened&can=1&q=proj:envoy)
[![Jenkins](https://powerci.osuosl.org/buildStatus/icon?job=build-envoy-static-master&subject=ppc64le%20build)](https://powerci.osuosl.org/job/build-envoy-static-master/)
[![Jenkins](https://ibmz-ci.osuosl.org/buildStatus/icon?job=Envoy_IBMZ_CI&subject=s390x%20build)](https://ibmz-ci.osuosl.org/job/Envoy_IBMZ_CI/)

## Documentation

* [Documentation officielle](https://www.envoyproxy.io/)
* [FAQ](https://www.envoyproxy.io/docs/envoy/latest/faq/overview)
* [Documentation d'exemple](https://github.com/envoyproxy/examples/)
* [Blog](https://medium.com/@mattklein123/envoy-threading-model-a8d44b922310) sur le modèle de threading
* [Blog](https://medium.com/@mattklein123/envoy-hot-restart-1d16b14555b5) sur le redémarrage à chaud
* [Blog](https://medium.com/@mattklein123/envoy-stats-b65c7f363342) sur l’architecture des statistiques
* [Blog](https://medium.com/@mattklein123/the-universal-data-plane-api-d15cec7a) sur l’API universelle du plan de données
* [Blog](https://medium.com/@mattklein123/lyfts-envoy-dashboards-5c91738816b1) sur les tableaux de bord Envoy de Lyft

## Liens connexes

* [data-plane-api](https://github.com/envoyproxy/data-plane-api) : définitions de l’API v2 dans un dépôt séparé.
  Il s’agit d’un miroir en lecture seule de [api](https://raw.githubusercontent.com/envoyproxy/envoy/main/api/).
* [envoy-perf](https://github.com/envoyproxy/envoy-perf) : Cadre de test de performance.
* [envoy-filter-example](https://github.com/envoyproxy/envoy-filter-example) : Exemple d’ajout de nouveaux filtres
  et de liaison avec le dépôt principal.

## Contact

* [envoy-announce](https://groups.google.com/forum/#!forum/envoy-announce) : Liste de diffusion à faible fréquence,
  uniquement pour les annonces.
* [envoy-security-announce](https://groups.google.com/forum/#!forum/envoy-security-announce) : Liste de diffusion à faible fréquence,
  uniquement pour les annonces de sécurité.
* [envoy-users](https://groups.google.com/forum/#!forum/envoy-users) : Discussion générale des utilisateurs.
* [envoy-dev](https://groups.google.com/forum/#!forum/envoy-dev) : Discussion pour les développeurs Envoy (APIs,
  conception de fonctionnalités, etc.).
* [envoy-maintainers](https://groups.google.com/forum/#!forum/envoy-maintainers) : Utilisez cette liste
  pour contacter tous les mainteneurs principaux d’Envoy.
* [Twitter](https://twitter.com/EnvoyProxy/) : Suivez-nous sur Twitter !
* [Slack](https://envoyproxy.slack.com/) : Slack, pour être invité, cliquez [ici](https://communityinviter.com/apps/envoyproxy/envoy).
  * REMARQUE : Les réponses aux questions des utilisateurs sur Slack sont faites au mieux. Pour une réponse « garantie », veuillez envoyer un email
    à envoy-users@ selon les recommandations dans le fil de discussion ci-dessous.

Veuillez consulter [ce](https://groups.google.com/forum/#!topic/envoy-announce/l9zjYsnS3TY) fil de discussion
pour plus d’informations sur l’utilisation des listes de diffusion.

## Contribution

Contribuer à Envoy est agréable et le C++ moderne est bien moins intimidant que vous ne le pensez, même sans expérience préalable. Pour commencer :

* [Guide de contribution](https://raw.githubusercontent.com/envoyproxy/envoy/main/CONTRIBUTING.md)
* [Problèmes pour débutants](https://github.com/envoyproxy/envoy/issues?q=is%3Aopen+is%3Aissue+label%3Abeginner)
* [Démarrage rapide build/test avec docker](https://raw.githubusercontent.com/envoyproxy/envoy/main/ci#building-and-running-tests-as-a-developer)
* [Guide du développeur](https://raw.githubusercontent.com/envoyproxy/envoy/main/DEVELOPER.md)
* Pensez à installer la [chaîne d’outils de support au développement Envoy](https://github.com/envoyproxy/envoy/blob/main/support/README.md), qui aide à automatiser certaines parties du processus de développement, notamment celles liées à la revue de code.
* Merci de nous informer si vous travaillez sur un problème, afin d’éviter la duplication des efforts !

## Réunion communautaire

L’équipe Envoy organise une réunion deux fois par mois, le mardi à 9h PT. Le calendrier public Google est [ici](https://goo.gl/PkDijT). La réunion n’aura lieu
que si des sujets sont inscrits à l’ordre du jour dans le [compte rendu de réunion](https://goo.gl/5Cergb).
Tout membre de la communauté peut proposer des sujets en les ajoutant au compte rendu. Les mainteneurs confirmeront
soit l’ajout à l’ordre du jour, soit annuleront la réunion dans les 24 heures précédant la date prévue s’il n’y a pas de sujet confirmé.

## Sécurité

### Audit de sécurité

Plusieurs audits indépendants ont été réalisés sur la sécurité d’Envoy :
* En 2018, Cure53 a effectué un audit de sécurité, [rapport complet](https://raw.githubusercontent.com/envoyproxy/envoy/main/docs/security/audit_cure53_2018.pdf).
* En 2021, Ada Logics a audité notre infrastructure de fuzzing avec des recommandations, [rapport complet](https://raw.githubusercontent.com/envoyproxy/envoy/main/docs/security/audit_fuzzer_adalogics_2021.pdf).

### Signalement de vulnérabilités de sécurité

Si vous avez identifié une vulnérabilité ou une possible vulnérabilité dans Envoy, merci de nous en informer à
[envoy-security](mailto:envoy-security@googlegroups.com). Nous enverrons un email de confirmation
pour accuser réception de votre rapport, puis un email supplémentaire lorsque nous aurons identifié le problème
de façon positive ou négative.

Pour plus de détails, consultez notre [processus de publication de sécurité](https://raw.githubusercontent.com/envoyproxy/envoy/main/SECURITY.md).

### Builds ppc64le

Les builds pour l’architecture ppc64le ou utilisant aws-lc ne sont pas couverts par la politique de sécurité d’Envoy. L’architecture ppc64le est actuellement prise en charge de façon « best effort » et n’est pas maintenue par les mainteneurs Envoy.

## Versions

Pour plus de détails, veuillez consulter notre [processus de publication](https://raw.githubusercontent.com/envoyproxy/envoy/main/RELEASES.md).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-12

---
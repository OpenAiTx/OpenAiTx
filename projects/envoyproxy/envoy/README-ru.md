![Логотип Envoy](https://github.com/envoyproxy/artwork/blob/main/PNG/Envoy_Logo_Final_PANTONE.png)

[Облачный высокопроизводительный прокси для edge/middle/service](https://www.envoyproxy.io/)

Envoy размещается в [Cloud Native Computing Foundation](https://cncf.io) (CNCF). Если вы —
компания, которая хочет участвовать в формировании развития технологий, связанных с контейнерами,
динамическим планированием и ориентированных на микросервисы, рассмотрите возможность присоединения к CNCF. Подробнее о том,
кто участвует и как Envoy играет свою роль, читайте в CNCF
[анонсе](https://www.cncf.io/blog/2017/09/13/cncf-hosts-envoy/).

[![CII Best Practices](https://bestpractices.coreinfrastructure.org/projects/1266/badge)](https://bestpractices.coreinfrastructure.org/projects/1266)
[![OpenSSF Scorecard](https://api.securityscorecards.dev/projects/github.com/envoyproxy/envoy/badge)](https://securityscorecards.dev/viewer/?uri=github.com/envoyproxy/envoy)
[![CLOMonitor](https://img.shields.io/endpoint?url=https://clomonitor.io/api/projects/cncf/envoy/badge)](https://clomonitor.io/projects/cncf/envoy)
[![Azure Pipelines](https://dev.azure.com/cncf/envoy/_apis/build/status/11?branchName=main)](https://dev.azure.com/cncf/envoy/_build/latest?definitionId=11&branchName=main)
[![Fuzzing Status](https://oss-fuzz-build-logs.storage.googleapis.com/badges/envoy.svg)](https://bugs.chromium.org/p/oss-fuzz/issues/list?sort=-opened&can=1&q=proj:envoy)
[![Jenkins](https://powerci.osuosl.org/buildStatus/icon?job=build-envoy-static-master&subject=ppc64le%20build)](https://powerci.osuosl.org/job/build-envoy-static-master/)
[![Jenkins](https://ibmz-ci.osuosl.org/buildStatus/icon?job=Envoy_IBMZ_CI&subject=s390x%20build)](https://ibmz-ci.osuosl.org/job/Envoy_IBMZ_CI/)

## Документация

* [Официальная документация](https://www.envoyproxy.io/)
* [FAQ](https://www.envoyproxy.io/docs/envoy/latest/faq/overview)
* [Примеры документации](https://github.com/envoyproxy/examples/)
* [Блог](https://medium.com/@mattklein123/envoy-threading-model-a8d44b922310) о модели многопоточности
* [Блог](https://medium.com/@mattklein123/envoy-hot-restart-1d16b14555b5) о горячем рестарте
* [Блог](https://medium.com/@mattklein123/envoy-stats-b65c7f363342) об архитектуре сбора статистики
* [Блог](https://medium.com/@mattklein123/the-universal-data-plane-api-d15cec7a) об универсальном API для плоскости данных
* [Блог](https://medium.com/@mattklein123/lyfts-envoy-dashboards-5c91738816b1) о дашбордах Lyft для Envoy

## Связанные проекты

* [data-plane-api](https://github.com/envoyproxy/data-plane-api): Определения API v2 как отдельный
  репозиторий. Это только для чтения зеркало [api](https://raw.githubusercontent.com/envoyproxy/envoy/main/api/).
* [envoy-perf](https://github.com/envoyproxy/envoy-perf): Фреймворк для тестирования производительности.
* [envoy-filter-example](https://github.com/envoyproxy/envoy-filter-example): Пример добавления новых фильтров
  и подключения к основному репозиторию.

## Контакты

* [envoy-announce](https://groups.google.com/forum/#!forum/envoy-announce): Рассылка с низкой частотой,
  только для анонсов.
* [envoy-security-announce](https://groups.google.com/forum/#!forum/envoy-security-announce): Рассылка с низкой частотой,
  только для уведомлений о безопасности.
* [envoy-users](https://groups.google.com/forum/#!forum/envoy-users): Обсуждение для пользователей.
* [envoy-dev](https://groups.google.com/forum/#!forum/envoy-dev): Обсуждение для разработчиков Envoy (APIs,
  проектирование функций и т.д.).
* [envoy-maintainers](https://groups.google.com/forum/#!forum/envoy-maintainers): Используйте этот список,
  чтобы связаться со всеми основными мейнтейнерами Envoy.
* [Twitter](https://twitter.com/EnvoyProxy/): Следите за новостями в Twitter!
* [Slack](https://envoyproxy.slack.com/): Slack, чтобы получить приглашение, перейдите [сюда](https://communityinviter.com/apps/envoyproxy/envoy).
  * ПРИМЕЧАНИЕ: Ответ на вопросы пользователей в Slack осуществляется по мере возможности. Для "гарантированного" ответа, пожалуйста, пишите
    на envoy-users@ согласно рекомендациям в следующем треде.

Пожалуйста, смотрите [этот](https://groups.google.com/forum/#!topic/envoy-announce/l9zjYsnS3TY) тред
для информации по использованию email-рассылок.

## Вклад

Вносить вклад в Envoy интересно, а современный C++ намного проще, чем может показаться, даже если у вас нет опыта. Для начала:

* [Руководство по внесению вклада](https://raw.githubusercontent.com/envoyproxy/envoy/main/CONTRIBUTING.md)
* [Задачи для начинающих](https://github.com/envoyproxy/envoy/issues?q=is%3Aopen+is%3Aissue+label%3Abeginner)
* [Быстрый старт сборки/тестирования с использованием docker](https://raw.githubusercontent.com/envoyproxy/envoy/main/ci#building-and-running-tests-as-a-developer)
* [Руководство разработчика](https://raw.githubusercontent.com/envoyproxy/envoy/main/DEVELOPER.md)
* Рекомендуется установить [набор инструментов поддержки разработки Envoy](https://github.com/envoyproxy/envoy/blob/main/support/README.md), который помогает автоматизировать части процесса разработки, особенно связанные с ревью кода.
* Пожалуйста, обязательно сообщайте, если вы работаете над задачей, чтобы избежать дублирования работы!

## Встречи сообщества

Команда Envoy проводит встречи два раза в месяц по вторникам в 9 утра по PT. Публичный
Google-календарь доступен [здесь](https://goo.gl/PkDijT). Встреча проводится
только если в [протоколе встречи](https://goo.gl/5Cergb) есть пункты повестки. Любой член сообщества может
предложить пункты повестки, добавив их в протокол. Мейнтейнеры либо подтвердят
добавления в повестку, либо отменят встречу в течение 24 часов до назначенной
даты, если не будет подтвержденной повестки.

## Безопасность

### Аудит безопасности

Проводились несколько сторонних аудитов, посвящённых безопасности Envoy:
* В 2018 году компания Cure53 провела аудит безопасности, [полный отчет](https://raw.githubusercontent.com/envoyproxy/envoy/main/docs/security/audit_cure53_2018.pdf).
* В 2021 году Ada Logics провела аудит инфраструктуры fuzzing с рекомендациями по улучшениям, [полный отчет](https://raw.githubusercontent.com/envoyproxy/envoy/main/docs/security/audit_fuzzer_adalogics_2021.pdf).

### Сообщение об уязвимостях безопасности

Если вы обнаружили уязвимость или потенциальную уязвимость в Envoy, пожалуйста, сообщите нам по адресу
[envoy-security](mailto:envoy-security@googlegroups.com). Мы отправим подтверждение
о получении вашего сообщения и дополнительное письмо, когда выявим проблему
(положительно или отрицательно).

Подробнее смотрите наш [полный процесс публикации обновлений безопасности](https://raw.githubusercontent.com/envoyproxy/envoy/main/SECURITY.md).

### Сборки ppc64le

Сборки для архитектуры ppc64le или с использованием aws-lc не покрываются политикой безопасности Envoy. Архитектура ppc64le на данный момент поддерживается на лучшем усилии и не сопровождается мейнтейнерами Envoy.

## Релизы

Подробности смотрите в [процессе релизов](https://github.com/envoyproxy/envoy/blob/main/RELEASES.md).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-12

---
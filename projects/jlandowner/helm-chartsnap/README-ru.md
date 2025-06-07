# helm-chartsnap 📸 
[![Go Reference](https://pkg.go.dev/badge/github.com/jlandowner/helm-chartsnap.svg)](https://pkg.go.dev/github.com/jlandowner/helm-chartsnap)
[![Go Report Card](https://goreportcard.com/badge/github.com/jlandowner/helm-chartsnap)](https://goreportcard.com/report/github.com/jlandowner/helm-chartsnap)
[![codecov](https://codecov.io/gh/jlandowner/helm-chartsnap/graph/badge.svg?token=8ARG53CRL7)](https://codecov.io/gh/jlandowner/helm-chartsnap)
[![Workflow Status](https://github.com/jlandowner/helm-chartsnap/actions/workflows/release.yaml/badge.svg)](https://github.com/jlandowner/helm-chartsnap/actions/workflows/release.yaml)
[![CI](https://github.com/jlandowner/helm-chartsnap/actions/workflows/ci.yaml/badge.svg)](https://github.com/jlandowner/helm-chartsnap/actions/workflows/ci.yaml)
[![GitHub Marketplace](https://img.shields.io/badge/Marketplace-Helm%20chartsnap%20action-blue.svg?colorA=24292e&colorB=0366d6&style=flat&longCache=true&logo=github)](https://github.com/marketplace/actions/helm-chartsnap-action)

Инструмент для создания снимков (snapshot testing) Helm-чартов.

Применяйте мощные возможности UI-тестирования для Helm-чартов с минимальной настройкой — прямо в файле `values.yaml`.

![screenshot](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/docs/screenshot.png)

## Обзор
- [Возможности 🔑](#возможности-)
- [Зачем нужно Snapshot-тестирование? 📸](#зачем-нужно-snapshot-тестирование-)
  - [Мотивация](#мотивация)
- [Установка 🚀](#установка-)
- [Использование](#использование)
  - [Обработка динамических значений 💪](#обработка-динамических-значений-)
- [Примеры и пользователи ✨](#примеры-и-пользователи-)


## Возможности 🔑

* **Простое и интуитивное Snapshot-тестирование для разработчиков Helm**
  
  - **Нет необходимости в специфическом формате файлов TestSuite**: В отличие от некоторых инструментов, которые требуют создания отдельных TestSuite с пользовательским форматом файлов, этот инструмент не требует дополнительных форматов. Вместо этого вы можете подготовить различные варианты стандартного файла `values.yaml` для каждого тестового случая. Это упрощает тестирование и избавляет от необходимости изучать новые форматы.

* **Оптимизировано для Helm-чартов**

  - **Обработка динамического вывода, генерируемого функциями Helm**: Вы можете указывать дополнительные свойства в файле values.yaml для каждого теста, чтобы гибко настраивать поведение теста. Например, можно контролировать вывод, динамически генерируемый функциями Helm, такими как [randAlphaNum](https://helm.sh/docs/chart_template_guide/function_list/).

* **Непрерывное Snapshot-тестирование**

  - **[GitHub Action](https://github.com/jlandowner/helm-chartsnap-action) готов к использованию**: GitHub Action, который позволяет выполнять непрерывное snapshot-тестирование локальных или удалённых Helm-чартов в вашем CI, готов 🚀 -> [`helm-chart-action`](https://github.com/jlandowner/helm-chartsnap-action)

## Зачем нужно Snapshot-тестирование? 📸

Я считаю, что snapshot-тестирование — популярный подход в Web или UI тестировании с такими инструментами, как Jest — это лучший способ тестирования Helm-чартов. Snapshot-тестирование даёт несколько преимуществ:

- **Визуальное сравнение:** Snapshot-тесты создают базовый вывод, а затем сравнивают его с последующими результатами тестов. Это позволяет легко визуально отслеживать изменения и регрессии в рендеринге Helm-чарта.

- **Улучшенная поддерживаемость:** Snapshot-тестирование упрощает процесс настройки тестов, делая его более доступным и поддерживаемым, особенно при работе со сложными Helm-чартами. Входными данными для Helm-чарта служит комбинация значений. Нужно поддерживать только предполагаемые комбинации входных данных (=values.yaml) и соответствующие им снимки.

- **Непрерывное тестирование:** Постоянно снимая снимки Helm-чарта в процессе CI, вы быстро замечаете любые изменения во всём чарте и избегаете регрессий.

Эти преимущества полезны не только для чарта, который вы создали, но и для сторонних чартов, установленных в вашем Kubernetes (если вы администратор). При обновлении кластера вы сможете заметить любые изменения в выходных манифестах, созданных с вашими *values*, даже самые незначительные.


### Мотивация

Существуют инструменты тестирования Helm, поддерживающие snapshot-тесты:
- [helm-unittest](https://github.com/helm-unittest/helm-unittest), популярный инструмент модульного тестирования, поддерживает [snapshot-тестирование](https://github.com/helm-unittest/helm-unittest#snapshot-testing).
- [terratest](https://terratest.gruntwork.io/), автоматизированные тесты для инфраструктурного кода. Позволяет писать тесты на Go и тестировать вывод Helm. [Блог-пост](https://blog.gruntwork.io/automated-testing-for-kubernetes-and-helm-charts-using-terratest-a4ddc4e67344)

> Официальный инструмент тестирования Helm [`ct`](https://github.com/helm/chart-testing) не предназначен для unit- или snapshot-тестов, а только для lint и интеграционных тестов.

Хотя это ценные инструменты для тестирования Helm-чартов, у них есть ограничения для snapshot-тестирования:

- Необходимо изучать и готовить Test Suite файлы инструментов, даже если требуется только snapshot-тестирование.

- По умолчанию не делают снимок всего чарта, а рассчитаны на тестирование по отдельным файлам в составе Helm-чарта.

- Динамический вывод функций Helm не учитывается.

helm-unittest устроен так, что тестирование проводится по отдельным файлам в чарте. Это значит, что каждый файл оценивается независимо. Если значения Helm-чарта или условия приводят к тому, что файл целиком включается или исключается, важные сценарии могут быть не покрыты тестами.

Пример файла спецификации теста для snapshot-тестирования в helm-unittest:

> https://github.com/helm-unittest/helm-unittest#snapshot-testing
> 
> ```yaml
> templates:
>   - templates/deployment.yaml
> tests:
>   - it: pod spec should match snapshot
>     asserts:
>       - matchSnapshot:
>           path: spec.template.spec
>   # или можно сделать снимок всего манифеста
>   - it: manifest should match snapshot
>     asserts:
>       - matchSnapshot: {}
> ```

Например, рассмотрим ситуацию, когда Helm-чарт может создать ресурс `Certificate` из `cert-manager`, если включены TLS и cert-manager, но создать самоподписанный TLS-секрет с помощью функции Helm [`genSelfSignedCert`](https://helm.sh/docs/chart_template_guide/function_list/#genselfsignedcert), если cert-manager не включён. Кроме того, включение TLS влияет на свойства TLS в Ingress, опции TLS в Deployment и т.д.

В таких случаях helm-unittest может быть неспособен адекватно протестировать поведение всего чарта, поскольку вывод условных файлов может быть пустым, и тесты будут неполными.

Однако всё, что нужно сделать с помощью `helm-chartsnap`, — это просто подготовить несколько файлов `values.yaml` с ожидаемыми вариантами 😊

## Установка 🚀

Вы можете установить как плагин Helm.

```sh
helm plugin install https://github.com/jlandowner/helm-chartsnap
```

Другие способы:

- Установка через Go

  ```sh
  go install github.com/jlandowner/helm-chartsnap@latest
  ```

- [Скачать бинарник релиза](https://github.com/jlandowner/helm-chartsnap/releases)

## Использование

Для быстрого старта просто передайте ваш чарт.

```
helm chartsnap -c YOUR_CHART
```

В директории чарта создаётся папка `__snapshot__` и файл `default.snap`.

Также можно создавать тестовые кейсы в виде вариаций файлов Values вашего чарта.

Полное описание команды:

```sh
Usage:
  chartsnap -c CHART [flags]

Examples:

  # Снимок с дефолтными значениями:
  chartsnap -c YOUR_CHART
  
  # Обновление файлов снимков:
  chartsnap -c YOUR_CHART -u

  # Снимок с тестовыми значениями:
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILE
  
  # Снимок всех тестовых кейсов:
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILES_DIRECTOY
  
  # Задание дополнительных аргументов/флагов для команды 'helm template':
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILE -- --skip-tests

  # Снимок удалённого чарта из Helm-репозитория:
  chartsnap -c CHART_NAME -f YOUR_VALUES_FILE -- --repo HELM_REPO_URL

  # Снимок helm-чарта ingress-nginx (https://kubernetes.github.io/ingress-nginx/) для конкретной версии с вашим файлом значений:
  chartsnap -c ingress-nginx -f YOUR_VALUES_FILE -- --repo https://kubernetes.github.io/ingress-nginx --namespace kube-system --version 4.8.3

  # Снимок helm-чарта cilium (https://cilium.io) с дефолтными значениями и доп. флагами:
  chartsnap -c cilium -- --repo https://helm.cilium.io --namespace kube-system --set hubble.relay.enabled=true --set hubble.ui.enabled=true

  # Снимок чартов из OCI-реестра:
  chartsnap -c oci://ghcr.io/nginxinc/charts/nginx-gateway-fabric -n nginx-gateway

  # Вывод без цветов:
  NO_COLOR=1 chartsnap -c YOUR_CHART

Flags:
  -c, --chart string              путь к директории чарта. этот флаг передаётся в 'helm template RELEASE_NAME CHART --values VALUES' как 'CHART'
      --config-file string        имя или путь к конфиг-файлу, который определяет поведение snapshot (например, динамические поля) (по умолчанию ".chartsnap.yaml")
  -N, --ctx-lines int             количество строк для показа в diff-выводе. 0 — полный вывод (по умолчанию 3)
      --debug                     режим отладки
      --fail-helm-error           завершить с ошибкой, если команда 'helm template' завершилась неудачно
      --failfast                  завершить при первом неудачном тесте
  -h, --help                      помощь по chartsnap
  -n, --namespace string          namespace. этот флаг передаётся в 'helm template RELEASE_NAME CHART --values VALUES --namespace NAMESPACE' как 'NAMESPACE' (по умолчанию "default")
  -o, --output-dir string         директория, куда будет создана папка __snapshot__ (по умолчанию: директория файла значений при --values; директория чарта, если чарт локальный; иначе текущая директория)
      --parallelism int           параллелизм тестов при множественных snapshot для директории тестовых файлов. по умолчанию не ограничено (по умолчанию -1)
      --release-name string       имя релиза. этот флаг передаётся в 'helm template RELEASE_NAME CHART --values VALUES' как 'RELEASE_NAME' (по умолчанию "chartsnap")
      --snapshot-version string   использовать определённую версию формата snapshot. Поддерживаются v1, v2, v3. (по умолчанию: latest)
  -u, --update-snapshot           режим обновления снимков
  -f, --values string             путь к тестовому файлу values или директории. если указана директория, тестируются все файлы. если не указано — используются дефолтные значения. этот флаг передаётся в 'helm template RELEASE_NAME CHART --values VALUES' как 'VALUES'
  -v, --version                   версия chartsnap

```

### Обработка динамических значений 💪

Helm поддерживает функции ("Helm functions"), которые генерируют случайные значения или самоподписанные сертификаты, например [`randAlphaNum`](https://helm.sh/docs/chart_template_guide/function_list/#randalphanum-randalpha-randnumeric-and-randascii) и [`genCA`, `genPrivateKey`, `genSelfSignedCert`](https://helm.sh/docs/chart_template_guide/function_list/#cryptographic-and-security-functions)

При использовании этих функций вывод будет различаться при каждом запуске Helm.
Для этого случая chartsnap имеет функцию, предотвращающую несовпадения снимков, подставляя фиксированное значение `###DYNAMIC_FIELD###`.

Вы можете указать пути динамических значений в сгенерированном YAML, используя [JSONPath](https://datatracker.ietf.org/doc/html/rfc6901).

```yaml:.chartsnap.yaml
dynamicFields:
  - apiVersion: v1
    kind: Secret
    name: cosmo-auth-env
    jsonPath:
      - /data/COOKIE_HASHKEY
      - /data/COOKIE_BLOCKKEY
      - /data/COOKIE_HASHKEY
      - /data/COOKIE_SESSION_NAME
    base64: true
```

> ПРИМЕЧАНИЕ:
> В JSONPath экранирование символа / описано в [RFC6901, секция 3](https://datatracker.ietf.org/doc/html/rfc6901#section-3)
> ```
>    Так как символы '~' (%x7E) и '/' (%x2F) имеют специальное значение в JSON Pointer, '~' кодируется как '~0', а '/' — как '~1', когда эти символы встречаются в токене.
> ```
>
> Поэтому, если вы работаете с манифестом, как показано ниже, путь должен быть `/metadata/annotaions/checksum~1values`.
> 
> ```yaml
> metadata:
>   annotations:
>     checksum/values: RANDOM_VALUES
> ```

Если у вас есть директория с тестовыми файлами values, поместите туда файл `.chartsnap.yaml`. Это общее поведение для всех snapshot-тестов в директории.

Больше примеров: [example/app1](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/app1).

Также можно прямо добавить конфиг в тестовый файл values через свойство `testSpec`.
В этом случае не нужно готовить `.chartsnap.yaml`. Это удобно для snapshot-тестов удалённых или сторонних чартов с одним файлом values.

Ваш values-файл может выглядеть так:

```yaml
# Добавьте это свойство в ваши values.
testSpec:
  dynamicFields:
    - apiVersion: v1
      kind: Secret
      name: cilium-ca
      jsonPath:
        - /data/ca.crt
        - /data/ca.key
      base64: true
    - apiVersion: v1
      kind: Secret
      name: hubble-server-certs
      jsonPath:
        - /data/ca.crt
        - /data/tls.crt
        - /data/tls.key
      base64: true
    - apiVersion: v1
      kind: Secret
      name: hubble-relay-client-certs
      jsonPath:
        - /data/ca.crt
        - /data/tls.crt
        - /data/tls.key
      base64: true

# Остальные параметры — любые значения вашего чарта.
# ...
```

Больше примеров: [example/remote](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/remote).

## Примеры и пользователи ✨

| Пользователь / Проект | Описание | URL |
|:---|:---|:---|
| Example | Пример чарта, сгенерированного командой `helm create` | [`example/app1`](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/app1) |
| Example | Пример snapshot-тестирования чартов из удалённых Helm-репозиториев | [`example/remote`](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/remote) |
| [helm-chartsnap-action](https://github.com/jlandowner/helm-chartsnap-action) | GitHub Action для использования helm chartsnap в CI | https://github.com/jlandowner/helm-chartsnap-action |
| [cosmo-workspace](https://github.com/cosmo-workspace/cosmo) | Open source WebIDE & DevEnvironment Platform на Kubernetes | https://github.com/cosmo-workspace/cosmo/tree/main/charts/cosmo/test |
| [Kong](https://github.com/Kong/kong) | 🦍 Облачный API Gateway и AI Gateway. | https://github.com/Kong/charts |



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---
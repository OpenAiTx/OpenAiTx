# helm-chartsnap 📸 
[![Go Reference](https://pkg.go.dev/badge/github.com/jlandowner/helm-chartsnap.svg)](https://pkg.go.dev/github.com/jlandowner/helm-chartsnap)
[![Go Report Card](https://goreportcard.com/badge/github.com/jlandowner/helm-chartsnap)](https://goreportcard.com/report/github.com/jlandowner/helm-chartsnap)
[![codecov](https://codecov.io/gh/jlandowner/helm-chartsnap/graph/badge.svg?token=8ARG53CRL7)](https://codecov.io/gh/jlandowner/helm-chartsnap)
[![Workflow Status](https://github.com/jlandowner/helm-chartsnap/actions/workflows/release.yaml/badge.svg)](https://github.com/jlandowner/helm-chartsnap/actions/workflows/release.yaml)
[![CI](https://github.com/jlandowner/helm-chartsnap/actions/workflows/ci.yaml/badge.svg)](https://github.com/jlandowner/helm-chartsnap/actions/workflows/ci.yaml)
[![GitHub Marketplace](https://img.shields.io/badge/Marketplace-Helm%20chartsnap%20action-blue.svg?colorA=24292e&colorB=0366d6&style=flat&longCache=true&logo=github)](https://github.com/marketplace/actions/helm-chartsnap-action)

Narzędzie do testowania migawkowego (snapshot testing) wykresów Helm.

Wprowadź zaawansowane możliwości testowania UI dla wykresów Helm przy minimalnej konfiguracji — wystarczy plik `values.yaml`. 

![screenshot](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/docs/screenshot.png)

## Przegląd
- [Funkcje 🔑](#funkcje-)
- [Dlaczego testowanie migawkowe? 📸](#dlaczego-testowanie-migawkowe-)
  - [Motywacja](#motywacja)
- [Instalacja 🚀](#instalacja-)
- [Użycie](#użycie)
  - [Obsługa wartości dynamicznych 💪](#obsluga-wartosci-dynamicznych-)
- [Prezentacja & Użytkownicy ✨](#prezentacja--uzytkownicy-)

## Funkcje 🔑

* **Łatwe i intuicyjne testowanie migawkowe dla deweloperów Helm**
  
  - **Brak plików TestSuite specyficznych dla narzędzia**: W przeciwieństwie do niektórych narzędzi, które wymagają tworzenia osobnych zestawów testowych z własnymi formatami plików, to narzędzie nie wymaga żadnych dodatkowych formatów plików. Zamiast tego możesz przygotować różne wersje standardowego pliku `values.yaml` dla każdego przypadku testowego. Eliminuje to konieczność nauki nowych formatów i upraszcza testowanie.

* **Optymalizacja pod wykresy Helm**

  - **Obsługa dynamicznych wyników generowanych przez funkcje Helm**: Możesz określić dodatkowe właściwości w pliku values.yaml dla każdego przypadku testowego, aby zapewnić elastyczność w dostosowywaniu zachowania testu. Na przykład możesz kontrolować wyniki dynamicznie generowane przez funkcje Helm, takie jak [randAlphaNum](https://helm.sh/docs/chart_template_guide/function_list/).

* **Ciągłe testowanie migawkowe**

  - **[GitHub Action](https://github.com/jlandowner/helm-chartsnap-action) jest gotowy**: GitHub Action, który umożliwia ciągłe testowanie migawkowe lokalnych lub zdalnych wykresów Helm w Twoim CI jest gotowy 🚀 -> [`helm-chart-action`](https://github.com/jlandowner/helm-chartsnap-action)

## Dlaczego testowanie migawkowe? 📸

Uważam, że testowanie migawkowe, popularna metoda testowania w testach Web/UI z narzędziami takimi jak Jest, jest najlepszym sposobem testowania wykresów Helm. Testowanie migawkowe oferuje kilka korzyści:

- **Porównania wizualne:** Testy migawkowe tworzą bazowy wynik, a następnie porównują go z kolejnymi wynikami testów. Umożliwia to łatwą wizualną inspekcję zmian i regresji w renderowaniu wykresów Helm.

- **Zwiększona łatwość utrzymania:** Testowanie migawkowe upraszcza proces konfiguracji testów, czyniąc go bardziej dostępnym i łatwiejszym w utrzymaniu, szczególnie przy skomplikowanych wykresach Helm. Wejściem do wykresu Helm jest kombinacja wartości. Wystarczy utrzymywać tylko zakładane kombinacje wejściowe (=values.yaml) oraz ich migawki.

- **Ciągłe testowanie:** Dzięki ciągłemu tworzeniu migawek wykresu Helm w procesie CI możesz szybko zauważyć zmiany w całym wykresie i unikać regresji.

Te zalety dotyczą nie tylko wykresów Helm, które samodzielnie tworzysz, ale również wykresów firm trzecich, które masz zainstalowane na swoim Kubernetesie jako administrator klastra. Podczas aktualizacji klastra możesz zauważyć wszelkie zmiany w wynikowych manifestach generowanych przez Twoje *values*, nawet te najmniejsze.

### Motywacja

Istnieją narzędzia do testowania Helm, które obsługują testy migawkowe.
- [helm-unittest](https://github.com/helm-unittest/helm-unittest), popularne narzędzie do testów jednostkowych, posiada opcję [testowania migawkowego](https://github.com/helm-unittest/helm-unittest#snapshot-testing).
- [terratest](https://terratest.gruntwork.io/), Automatyczne testy kodu infrastruktury. Pozwala pisać testy w Go i umożliwia testowanie wyników Helm. [blog post](https://blog.gruntwork.io/automated-testing-for-kubernetes-and-helm-charts-using-terratest-a4ddc4e67344)

> Oficjalne narzędzie testowe Helm [`ct`](https://github.com/helm/chart-testing) nie służy do testów jednostkowych ani migawkowych, lecz do lintowania i testów integracyjnych

Choć są to cenne narzędzia do testowania wykresów Helm, mają pewne ograniczenia w kontekście testowania migawkowego.

- Trzeba poznać i przygotować pliki Test Suite narzędzi nawet tylko dla testów migawkowych.

- Domyślnie nie wykonują migawki całego wykresu, lecz są zaprojektowane do testowania poszczególnych plików w wykresie Helm.

- Dynamiczne wyniki funkcji Helm nie są uwzględniane.

helm-unittest został zaprojektowany do testowania pojedynczych plików w wykresie Helm. Oznacza to, że ocenia każdy plik niezależnie, a gdy wartości lub warunki wykresu Helm powodują warunkowe włączenie lub wyłączenie całego pliku, może to prowadzić do sytuacji, w której testy nie obejmują ważnych scenariuszy.

Przykład pliku specyfikacji testu dla testowania migawkowego w helm-unittest:

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
>   # or you can snapshot the whole manifest
>   - it: manifest should match snapshot
>     asserts:
>       - matchSnapshot: {}
> ```

Przykładowo, wyobraź sobie sytuację, w której wykres Helm tworzy zasób `Certificate` dla `cert-manager`, gdy zarówno TLS, jak i cert-manager są włączone, ale tworzy własny zasób `Secret` TLS z użyciem funkcji Helm [`genSelfSignedCert`](https://helm.sh/docs/chart_template_guide/function_list/#genselfsignedcert), gdy cert-manager nie jest włączony. Ponadto, to czy TLS jest włączony, wpływa na właściwości TLS Ingress, opcje TLS specyficzne dla aplikacji w Deployment itd.

W takich przypadkach helm-unittest może nie być w stanie adekwatnie przetestować zachowania całego wykresu, gdyż wyjście tych warunkowych plików może być puste, co prowadzi do niepełnych testów.

Natomiast wszystko, co musisz zrobić z `helm-chartsnap`, to przygotować kilka plików `values.yaml` dla spodziewanych wariantów 😊

## Instalacja 🚀

Możesz zainstalować jako plugin Helm.

```sh
helm plugin install https://github.com/jlandowner/helm-chartsnap
```

Inne opcje:

- Instalacja przez Go

  ```sh
  go install github.com/jlandowner/helm-chartsnap@latest
  ```

- [Pobierz gotową binarkę](https://github.com/jlandowner/helm-chartsnap/releases)

## Użycie

Po prostu podaj swój wykres, aby szybko rozpocząć.

```
helm chartsnap -c YOUR_CHART
```

W katalogu wykresu zostanie utworzony katalog `__snapshot__` oraz plik `default.snap`.

Możesz także tworzyć przypadki testowe jako wariacje plików Values twojego wykresu.

Pełne użycie polecenia:

```sh
Usage:
  chartsnap -c CHART [flags]

Examples:

  # Migawka z domyślnymi wartościami:
  chartsnap -c YOUR_CHART
  
  # Aktualizacja plików migawkowych:
  chartsnap -c YOUR_CHART -u

  # Migawka z wartościami przypadku testowego:
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILE
  
  # Migawka wszystkich przypadków testowych:
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILES_DIRECTOY
  
  # Ustaw dodatkowe argumenty lub flagi dla polecenia 'helm template':
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILE -- --skip-tests

  # Migawka zdalnego wykresu w repozytorium Helm:
  chartsnap -c CHART_NAME -f YOUR_VALUES_FILE -- --repo HELM_REPO_URL

  # Migawka wykresu ingress-nginx (https://kubernetes.github.io/ingress-nginx/) dla konkretnej wersji z twoim plikiem wartości:
  chartsnap -c ingress-nginx -f YOUR_VALUES_FILE -- --repo https://kubernetes.github.io/ingress-nginx --namespace kube-system --version 4.8.3

  # Migawka wykresu cilium (https://cilium.io) z domyślną wartością i ustawionymi flagami:
  chartsnap -c cilium -- --repo https://helm.cilium.io --namespace kube-system --set hubble.relay.enabled=true --set hubble.ui.enabled=true

  # Migawka wykresów z rejestru OCI
  chartsnap -c oci://ghcr.io/nginxinc/charts/nginx-gateway-fabric -n nginx-gateway

  # Wyjście bez kolorów:
  NO_COLOR=1 chartsnap -c YOUR_CHART

Flags:
  -c, --chart string              ścieżka do katalogu wykresu. Ta flaga jest przekazywana do 'helm template RELEASE_NAME CHART --values VALUES' jako 'CHART'
      --config-file string        nazwa lub ścieżka pliku konfiguracyjnego, definiującego zachowanie migawki, np. pola dynamiczne (domyślnie ".chartsnap.yaml")
  -N, --ctx-lines int             liczba linii wyświetlanych w różnicy. 0 dla pełnego wyjścia (domyślnie 3)
      --debug                     tryb debugowania
      --fail-helm-error           błąd, jeśli polecenie 'helm template' się nie powiedzie
      --failfast                  przerwij przy pierwszym nieudanym przypadku testowym
  -h, --help                      pomoc dla chartsnap
  -n, --namespace string          namespace. Ta flaga jest przekazywana do 'helm template RELEASE_NAME CHART --values VALUES --namespace NAMESPACE' jako 'NAMESPACE' (domyślnie "default")
  -o, --output-dir string         katalog, w którym zostanie utworzony katalog __snapshot__. (domyślnie: katalog pliku values, jeśli --values jest ustawione; katalog wykresu, jeśli wykres jest lokalny; w przeciwnym razie katalog bieżący)
      --parallelism int           współbieżność testów, jeśli robione są migawki dla wielu plików wartości testowych. domyślnie bez limitu (domyślnie -1)
      --release-name string       nazwa wydania. Ta flaga jest przekazywana do 'helm template RELEASE_NAME CHART --values VALUES' jako 'RELEASE_NAME' (domyślnie "chartsnap")
      --snapshot-version string   użyj określonej wersji formatu migawki. Obsługiwane: v1, v2, v3. (domyślnie: najnowsza)
  -u, --update-snapshot           tryb aktualizacji migawki
  -f, --values string             ścieżka do pliku wartości testowych lub katalogu. Jeśli katalog, wszystkie pliki testowe są testowane. Jeśli puste, używane są wartości domyślne. Ta flaga jest przekazywana do 'helm template RELEASE_NAME CHART --values VALUES' jako 'VALUES'
  -v, --version                   wersja chartsnap

```

### Obsługa wartości dynamicznych 💪

Helm posiada funkcje "Helm functions", które generują losowe wartości lub certyfikaty samopodpisane, takie jak [`randAlphaNum`](https://helm.sh/docs/chart_template_guide/function_list/#randalphanum-randalpha-randnumeric-and-randascii) oraz [`genCA`, `genPrivateKey`, `genSelfSignedCert`](https://helm.sh/docs/chart_template_guide/function_list/#cryptographic-and-security-functions)

Podczas używania tych funkcji wynik będzie się różnić przy każdym uruchomieniu Helm.
W tym przypadku chartsnap posiada funkcję zapobiegającą niedopasowaniu migawek, zastępując je stałą wartością `###DYNAMIC_FIELD###`.

Możesz określić ścieżki do dynamicznych wartości w generowanym YAML za pomocą [JSONPath](https://datatracker.ietf.org/doc/html/rfc6901).

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

> UWAGA:
> W JSONPath znak / należy maskować zgodnie z [RFC6901, sekcja 3](https://datatracker.ietf.org/doc/html/rfc6901#section-3)
> ```
>    Ponieważ znaki '~' (%x7E) i '/' (%x2F) mają specjalne znaczenie w JSON Pointer,
>    '~' należy zakodować jako '~0', a '/' jako '~1', gdy te znaki pojawiają się w tokenie odwołania.
> ```
>
> Jeśli więc obsługujesz manifest taki jak poniżej, musisz określić ścieżkę json jako `/metadata/annotaions/checksum~1values`.
> 
> ```yaml
> metadata:
>   annotations:
>     checksum/values: RANDOM_VALUES
> ```

Jeśli masz katalog plików wartości testowych, umieść w nim plik `.chartsnap.yaml`. Jest to zachowanie wspólne dla wszystkich testów migawkowych w katalogu.

Więcej przykładów znajdziesz w [example/app1](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/app1).

Alternatywnie, możesz dodać konfigurację bezpośrednio w pliku wartości testowych jako właściwość `testSpec`.
W takim przypadku nie musisz przygotowywać `.chartsnap.yaml`. Jest to przydatne do wykonywania migawek zdalnych lub wykresów firm trzecich z własnym pojedynczym plikiem wartości.

Twój plik values może wyglądać tak:

```yaml
# Dodaj tę właściwość do swoich wartości.
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

# Pozostałe mogą być dowolnymi wartościami twojego wykresu.
# ...
```

Więcej przykładów znajdziesz w [example/remote](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/remote).

## Prezentacja & Użytkownicy ✨

| Użytkownicy / Projekty | Opis | URL |
|:---|:---|:---|
| Przykład | Przykładowy wykres wygenerowany przez polecenie `helm create` | [`example/app1`](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/app1) |
| Przykład | Przykład tworzenia migawek wykresów ze zdalnych repozytoriów Helm | [`example/remote`](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/remote) |
| [helm-chartsnap-action](https://github.com/jlandowner/helm-chartsnap-action) | GitHub Action do użycia helm chartsnap w CI | https://github.com/jlandowner/helm-chartsnap-action |
| [cosmo-workspace](https://github.com/cosmo-workspace/cosmo) | Otwarta platforma WebIDE & DevEnvironment na Kubernetes | https://github.com/cosmo-workspace/cosmo/tree/main/charts/cosmo/test |
| [Kong](https://github.com/Kong/kong) | 🦍 Cloud-Native API Gateway i AI Gateway. | https://github.com/Kong/charts |


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---
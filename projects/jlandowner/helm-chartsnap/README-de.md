# helm-chartsnap 📸 
[![Go Reference](https://pkg.go.dev/badge/github.com/jlandowner/helm-chartsnap.svg)](https://pkg.go.dev/github.com/jlandowner/helm-chartsnap)
[![Go Report Card](https://goreportcard.com/badge/github.com/jlandowner/helm-chartsnap)](https://goreportcard.com/report/github.com/jlandowner/helm-chartsnap)
[![codecov](https://codecov.io/gh/jlandowner/helm-chartsnap/graph/badge.svg?token=8ARG53CRL7)](https://codecov.io/gh/jlandowner/helm-chartsnap)
[![Workflow Status](https://github.com/jlandowner/helm-chartsnap/actions/workflows/release.yaml/badge.svg)](https://github.com/jlandowner/helm-chartsnap/actions/workflows/release.yaml)
[![CI](https://github.com/jlandowner/helm-chartsnap/actions/workflows/ci.yaml/badge.svg)](https://github.com/jlandowner/helm-chartsnap/actions/workflows/ci.yaml)
[![GitHub Marketplace](https://img.shields.io/badge/Marketplace-Helm%20chartsnap%20action-blue.svg?colorA=24292e&colorB=0366d6&style=flat&longCache=true&logo=github)](https://github.com/marketplace/actions/helm-chartsnap-action)

Snapshot-Test-Tool für Helm-Charts.

Bringen Sie leistungsstarke UI-Testfunktionen für Helm-Charts mit minimaler Konfiguration direkt in der `values.yaml`-Datei.

![screenshot](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/docs/screenshot.png)

## Übersicht
- [Features 🔑](#features-)
- [Warum Snapshot Testing? 📸](#warum-snapshot-testing-)
  - [Motivation](#motivation)
- [Installation 🚀](#installation-)
- [Verwendung](#verwendung)
  - [Umgang mit dynamischen Werten 💪](#umgang-mit-dynamischen-werten-)
- [Showcase & Nutzer ✨](#showcase--nutzer-)


## Features 🔑

* **Einfaches & intuitives Snapshot-Testing für Helm-Entwickler**
  
  - **Kein werkzeugspezifisches TestSuite-Dateiformat**: Im Gegensatz zu einigen Tools, die das Erstellen separater TestSuites mit eigenen Dateiformaten erfordern, benötigt dieses Tool keine zusätzlichen Formate. Stattdessen können Sie Varianten der Standard-`values.yaml`-Datei für jeden Testfall vorbereiten. Das erspart das Erlernen neuer Formate und vereinfacht das Testen.

* **Optimiert für Helm-Charts**

  - **Umgang mit dynamischer Ausgabe, die von Helm-Funktionen generiert wird**: Sie können zusätzliche Eigenschaften innerhalb der values.yaml-Datei für jeden Testfall angeben, um Flexibilität bei der Anpassung des Testverhaltens zu bieten. Zum Beispiel können Sie die von Helm-Funktionen wie [randAlphaNum](https://helm.sh/docs/chart_template_guide/function_list/) dynamisch generierte Ausgabe steuern.

* **Kontinuierliches Snapshot-Testing**

  - **[GitHub Action](https://github.com/jlandowner/helm-chartsnap-action) ist bereit**: GitHub Action, mit der kontinuierliches Snapshot-Testing für lokale oder entfernte Helm-Charts in Ihrer CI möglich ist, ist verfügbar 🚀 -> [`helm-chart-action`](https://github.com/jlandowner/helm-chartsnap-action)

## Warum Snapshot Testing? 📸

Ich bin überzeugt, dass Snapshot-Testing, ein beliebter Testansatz im Web- oder UI-Testing mit Tools wie Jest, die beste Methode zum Testen von Helm-Charts ist. Snapshot-Testing bietet mehrere Vorteile:

- **Visuelle Vergleiche:** Snapshot-Tests erstellen eine Ausgangsausgabe und vergleichen sie dann mit späteren Testergebnissen. Dies ermöglicht eine einfache visuelle Überprüfung von Änderungen und Regressionen im Helm-Chart-Rendering.

- **Erhöhte Wartbarkeit:** Snapshot-Testing vereinfacht den Testaufbau und macht ihn zugänglicher und wartbarer, insbesondere bei komplexen Helm-Charts. Die Eingabe für das Helm-Chart ist eine Kombination aus Werten. Wir müssen nur die angenommenen Eingabekombinationen (=values.yaml) und deren Snapshots pflegen.

- **Kontinuierliches Testen:** Durch das kontinuierliche Erstellen von Snapshots des Helm-Charts im CI-Prozess können Sie Änderungen an Ihrem gesamten Chart schnell erkennen und Regressionen vermeiden.

Diese Vorteile beschränken sich nicht nur auf das von Ihnen erstellte Helm-Chart, sondern gelten auch für Drittanbieter-Charts, die Sie als Kubernetes-Administrator in Ihrem Kubernetes installiert haben. Beim Upgrade eines Clusters können Sie Änderungen in den von Ihren *values* erzeugten Ausgabemanifesten erkennen, egal wie klein sie sind.


### Motivation

Es gibt bereits Helm-Testtools, die Snapshot-Tests unterstützen.
- [helm-unittest](https://github.com/helm-unittest/helm-unittest), ein beliebtes Unit-Test-Tool, das eine Option für [Snapshot-Testing](https://github.com/helm-unittest/helm-unittest#snapshot-testing) bietet.
- [terratest](https://terratest.gruntwork.io/), Automatisierte Tests für Ihren Infrastrukturcode. Es können Tests als Go-Code geschrieben werden und es bietet die Möglichkeit, die Ausgabe von Helm zu testen. [Blogbeitrag](https://blog.gruntwork.io/automated-testing-for-kubernetes-and-helm-charts-using-terratest-a4ddc4e67344)

> Das offizielle Helm-Test-Tool [`ct`](https://github.com/helm/chart-testing) ist nicht für Unit- oder Snapshot-Tests gedacht, sondern für Lint- und Integrationstests

Obwohl dies wertvolle Tools für das Testen von Helm-Charts sind, haben sie bestimmte Einschränkungen für das Snapshot-Testing.

- Sie müssen die TestSuite-Dateien der Tools lernen und vorbereiten, selbst wenn Sie nur Snapshot-Tests durchführen möchten.

- Standardmäßig wird nicht das gesamte Chart gesnapshottet, sondern das Testing ist dateibasiert innerhalb des Helm-Charts ausgelegt.

- Dynamische Ausgaben von Helm-Funktionen werden nicht berücksichtigt.

helm-unittest ist darauf ausgelegt, Tests dateibasiert innerhalb des Helm-Charts durchzuführen. Das bedeutet, dass jede Datei unabhängig bewertet wird und wenn Chart-Werte oder Bedingungen dazu führen, dass eine gesamte Datei bedingt ein- oder ausgeschlossen wird, kann dies dazu führen, dass wichtige Szenarien nicht abgedeckt werden.

Hier ist ein Beispiel für eine Testspezifikationsdatei für Snapshot-Testing in helm-unittest.

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

Betrachten Sie beispielsweise ein Szenario, in dem das Helm-Chart eine `Certificate`-Ressource von `cert-manager` erstellt, wenn sowohl TLS als auch cert-manager aktiviert sind, aber ein selbstsigniertes TLS-`Secret` mit der Helm-Funktion [`genSelfSignedCert`](https://helm.sh/docs/chart_template_guide/function_list/#genselfsignedcert) erzeugt, wenn cert-manager nicht aktiviert ist. Ob TLS aktiviert ist, beeinflusst zudem die TLS-Eigenschaften von Ingress, deploymentspezifische TLS-Optionen usw.

In solchen Fällen kann helm-unittest möglicherweise das Verhalten des gesamten Charts nicht ausreichend testen, da die Ausgabe dieser bedingten Dateien leer sein kann, was zu unvollständigen Tests führt.

Mit `helm-chartsnap` müssen Sie jedoch nur einige `values.yaml`-Dateien für die von Ihnen erwarteten Muster vorbereiten 😊

## Installation 🚀

Sie können es als Helm-Plugin installieren.

```sh
helm plugin install https://github.com/jlandowner/helm-chartsnap
```

Weitere Optionen:

- Go install

  ```sh
  go install github.com/jlandowner/helm-chartsnap@latest
  ```

- [Release-Binary herunterladen](https://github.com/jlandowner/helm-chartsnap/releases)

## Verwendung

Übergeben Sie einfach Ihr Chart für einen Schnellstart.

```
helm chartsnap -c YOUR_CHART
```

Ein `__snapshot__`-Verzeichnis wird im Chart-Verzeichnis erstellt und `default.snap` angelegt.

Sie können auch Testfälle als Varianten der Values-Dateien Ihres Charts anlegen.

Hier ist die vollständige Verwendung des Befehls.

```sh
Usage:
  chartsnap -c CHART [flags]

Examples:

  # Snapshot mit Standardwerten:
  chartsnap -c YOUR_CHART
  
  # Snapshot-Dateien aktualisieren:
  chartsnap -c YOUR_CHART -u

  # Snapshot mit Testfall-Werten:
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILE
  
  # Snapshot aller Testfälle:
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILES_DIRECTOY
  
  # Zusätzliche Argumente oder Flags für den 'helm template'-Befehl setzen:
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILE -- --skip-tests

  # Snapshot eines Remote-Charts im Helm-Repository:
  chartsnap -c CHART_NAME -f YOUR_VALUES_FILE -- --repo HELM_REPO_URL

  # Snapshot des ingress-nginx (https://kubernetes.github.io/ingress-nginx/) Helm-Charts für eine bestimmte Version mit Ihrer Value-Datei:
  chartsnap -c ingress-nginx -f YOUR_VALUES_FILE -- --repo https://kubernetes.github.io/ingress-nginx --namespace kube-system --version 4.8.3

  # Snapshot des cilium (https://cilium.io) Helm-Charts mit Standardwert und gesetzten Flags:
  chartsnap -c cilium -- --repo https://helm.cilium.io --namespace kube-system --set hubble.relay.enabled=true --set hubble.ui.enabled=true

  # Snapshot von Charts im OCI-Registry
  chartsnap -c oci://ghcr.io/nginxinc/charts/nginx-gateway-fabric -n nginx-gateway

  # Ausgabe ohne Farben:
  NO_COLOR=1 chartsnap -c YOUR_CHART

Flags:
  -c, --chart string              Pfad zum Chart-Verzeichnis. Dieses Flag wird an 'helm template RELEASE_NAME CHART --values VALUES' als 'CHART' übergeben
      --config-file string        Name oder Pfad der Konfigurationsdatei, die das Snapshot-Verhalten definiert, z.B. dynamische Felder (Standard: ".chartsnap.yaml")
  -N, --ctx-lines int             Anzahl der Zeilen, die in der Diff-Ausgabe angezeigt werden. 0 für vollständige Ausgabe (Standard: 3)
      --debug                     Debug-Modus
      --fail-helm-error           Fehler, falls der 'helm template'-Befehl fehlschlägt
      --failfast                  Abbruch, sobald ein Testfall fehlschlägt
  -h, --help                      Hilfe zu chartsnap
  -n, --namespace string          Namespace. Dieses Flag wird an 'helm template RELEASE_NAME CHART --values VALUES --namespace NAMESPACE' als 'NAMESPACE' übergeben (Standard: "default")
  -o, --output-dir string         Verzeichnis, in dem das __snapshot__-Verzeichnis erstellt wird. (Standard: Values-Datei-Verzeichnis, falls --values gesetzt; Chart-Verzeichnis, falls lokal; sonst aktuelles Verzeichnis)
      --parallelism int           Test-Konkurrenz, falls mehrere Snapshots für ein Testwertverzeichnis aufgenommen werden. Standard ist unbegrenzt (Standard -1)
      --release-name string       Release-Name. Dieses Flag wird an 'helm template RELEASE_NAME CHART --values VALUES' als 'RELEASE_NAME' übergeben (Standard: "chartsnap")
      --snapshot-version string   Bestimmte Snapshot-Format-Version verwenden. v1, v2, v3 werden unterstützt. (Standard: neueste)
  -u, --update-snapshot           Snapshot-Update-Modus
  -f, --values string             Pfad zu einer Test-Values-Datei oder einem Verzeichnis. Falls ein Verzeichnis gesetzt ist, werden alle Testdateien getestet. Falls leer, werden Standardwerte verwendet. Dieses Flag wird an 'helm template RELEASE_NAME CHART --values VALUES' als 'VALUES' übergeben
  -v, --version                   Version von chartsnap

```

### Umgang mit dynamischen Werten 💪

Helm verfügt über eine Funktion namens "Helm-Funktionen", die Zufallswerte oder selbstsignierte Zertifikate generieren, wie [`randAlphaNum`](https://helm.sh/docs/chart_template_guide/function_list/#randalphanum-randalpha-randnumeric-and-randascii) und [`genCA`, `genPrivateKey`, `genSelfSignedCert`](https://helm.sh/docs/chart_template_guide/function_list/#cryptographic-and-security-functions)

Bei Verwendung dieser Funktionen variiert die Ausgabe bei jedem Helm-Durchlauf.
Für diesen Fall bietet chartsnap eine Funktion, die Fehlanpassungen von Snapshots verhindert, indem sie durch einen festen Wert `###DYNAMIC_FIELD###` ersetzt werden.

Sie können die Pfade der dynamischen Werte im generierten YAML mit [JSONPath](https://datatracker.ietf.org/doc/html/rfc6901) angeben.

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

> HINWEIS:
> Im JSONPath ist das Escaping des /-Zeichens in [RFC6901, Abschnitt 3](https://datatracker.ietf.org/doc/html/rfc6901#section-3) dokumentiert:
> ```
>    Da die Zeichen '~' (%x7E) und '/' (%x2F) in JSON Pointer eine besondere
>    Bedeutung haben, muss '~' als '~0' und '/' als '~1' kodiert werden,
>    wenn diese Zeichen in einem Referenz-Token auftreten.
> ```
>
> Wenn Sie also ein Manifest wie das Folgende verarbeiten, müssen Sie den JSON-Pfad als `/metadata/annotaions/checksum~1values` angeben.
> 
> ```yaml
> metadata:
>   annotations:
>     checksum/values: RANDOM_VALUES
> ```

Wenn Sie ein Testwertdatei-Verzeichnis haben, platzieren Sie die `.chartsnap.yaml`-Datei in diesem Verzeichnis. Dies gilt als allgemeines Verhalten für alle Snapshot-Tests im Verzeichnis.

Weitere Beispiele finden Sie unter [example/app1](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/app1).

Alternativ können Sie die Konfiguration direkt in der Testwerte-Datei als `testSpec`-Eigenschaft hinzufügen.
In diesem Fall müssen Sie keine `.chartsnap.yaml` vorbereiten. Dies ist für Snapshots von Remote- oder Drittanbieter-Charts mit Ihrer einzelnen Values-Datei gedacht.

Ihre Values-Datei kann wie folgt aussehen:

```yaml
# Fügen Sie diese Eigenschaft Ihren Values hinzu.
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

# Andere können beliebige Ihrer Chart-Values sein.
# ...
```

Weitere Beispiele finden Sie unter [example/remote](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/remote).

## Showcase & Nutzer ✨

| Nutzer / Projekte | Beschreibung | URL |
|:---|:---|:---|
| Beispiel | Beispiel-Chart, generiert mit dem Befehl `helm create` | [`example/app1`](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/app1) |
| Beispiel | Beispiel für das Snapshotten von Charts in Remote-Helm-Repositories | [`example/remote`](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/remote) |
| [helm-chartsnap-action](https://github.com/jlandowner/helm-chartsnap-action) | GitHub Action zur Nutzung von helm chartsnap in CI | https://github.com/jlandowner/helm-chartsnap-action |
| [cosmo-workspace](https://github.com/cosmo-workspace/cosmo) | Open-Source-WebIDE & DevEnvironment-Plattform auf Kubernetes | https://github.com/cosmo-workspace/cosmo/tree/main/charts/cosmo/test |
| [Kong](https://github.com/Kong/kong) | 🦍 Das Cloud-Native API Gateway und AI Gateway. | https://github.com/Kong/charts |


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---
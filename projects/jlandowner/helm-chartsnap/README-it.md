# helm-chartsnap 📸 
[![Go Reference](https://pkg.go.dev/badge/github.com/jlandowner/helm-chartsnap.svg)](https://pkg.go.dev/github.com/jlandowner/helm-chartsnap)
[![Go Report Card](https://goreportcard.com/badge/github.com/jlandowner/helm-chartsnap)](https://goreportcard.com/report/github.com/jlandowner/helm-chartsnap)
[![codecov](https://codecov.io/gh/jlandowner/helm-chartsnap/graph/badge.svg?token=8ARG53CRL7)](https://codecov.io/gh/jlandowner/helm-chartsnap)
[![Workflow Status](https://github.com/jlandowner/helm-chartsnap/actions/workflows/release.yaml/badge.svg)](https://github.com/jlandowner/helm-chartsnap/actions/workflows/release.yaml)
[![CI](https://github.com/jlandowner/helm-chartsnap/actions/workflows/ci.yaml/badge.svg)](https://github.com/jlandowner/helm-chartsnap/actions/workflows/ci.yaml)
[![GitHub Marketplace](https://img.shields.io/badge/Marketplace-Helm%20chartsnap%20action-blue.svg?colorA=24292e&colorB=0366d6&style=flat&longCache=true&logo=github)](https://github.com/marketplace/actions/helm-chartsnap-action)

Strumento di snapshot testing per Helm charts.

Porta potenti capacità di testing UI per Helm chart con una configurazione minima direttamente all'interno del file `values.yaml`.

![screenshot](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/docs/screenshot.png)

## Panoramica
- [Funzionalità 🔑](#funzionalità-)
- [Perché il Snapshot Testing? 📸](#perché-il-snapshot-testing-)
  - [Motivazione](#motivazione)
- [Installazione 🚀](#installazione-)
- [Utilizzo](#utilizzo)
  - [Gestione dei valori dinamici 💪](#gestione-dei-valori-dinamici-)
- [Showcase & Utenti ✨](#showcase--utenti-)


## Funzionalità 🔑

* **Snapshot testing facile e intuitivo per sviluppatori Helm**
  
  - **Nessun formato file TestSuite specifico per lo strumento**: A differenza di altri strumenti che richiedono la creazione di TestSuite separati con formati file personalizzati, questo strumento non richiede alcun formato aggiuntivo. Puoi semplicemente preparare variazioni del file standard `values.yaml` per ogni caso di test. Questo elimina la necessità di imparare nuovi formati e semplifica il testing.

* **Ottimizzato per Helm chart**

  - **Gestione dell’output dinamico generato dalle funzioni helm**: Puoi specificare proprietà aggiuntive all'interno del file values.yaml per ogni caso di test per fornire flessibilità nell'adattare il comportamento dei test. Ad esempio, puoi controllare l’output generato dinamicamente da funzioni helm come [randAlphaNum](https://helm.sh/docs/chart_template_guide/function_list/).

* **Snapshot testing continuo**

  - **[GitHub Action](https://github.com/jlandowner/helm-chartsnap-action) pronta**: È pronta una GitHub Action che permette di eseguire snapshot testing continuo per Helm chart locali o remoti nel tuo CI 🚀 -> [`helm-chart-action`](https://github.com/jlandowner/helm-chartsnap-action)

## Perché il Snapshot Testing? 📸

Credo che il snapshot testing, un approccio molto diffuso nel testing Web o UI con strumenti come Jest, sia il miglior modo per testare i Helm chart. Il snapshot testing offre diversi vantaggi:

- **Confronti visivi:** I test snapshot creano un output di riferimento e lo confrontano con i risultati dei test successivi. Questo permette una facile ispezione visiva delle modifiche e delle regressioni nel rendering dei Helm chart.

- **Maggiore manutenibilità:** Il snapshot testing semplifica il processo di configurazione dei test, rendendolo più accessibile e manutenibile, soprattutto con Helm chart complessi. L’input per il chart Helm è una combinazione di valori. Basta mantenere solo le combinazioni di input previste(=values.yaml) e i loro snapshot.

- **Testing continuo:** Scattando continuamente snapshot del Helm chart nel processo CI, puoi notare rapidamente le modifiche nell’intero chart ed evitare regressioni.

Questi vantaggi non sono limitati ai chart Helm che hai creato, ma anche ai chart di terze parti che hai installato sul tuo Kubernetes se sei un amministratore Kubernetes. Quando aggiorni un cluster, puoi accorgerti di qualsiasi cambiamento nei manifest prodotti dai tuoi *values*, anche se minimo.


### Motivazione

Esistono strumenti di testing Helm che supportano i test snapshot.
- [helm-unittest](https://github.com/helm-unittest/helm-unittest), uno strumento popolare di unit test, che ha un’opzione per il [snapshot testing](https://github.com/helm-unittest/helm-unittest#snapshot-testing).
- [terratest](https://terratest.gruntwork.io/), test automatizzati per il codice di infrastruttura. Si possono scrivere test in Go e ha la funzionalità per testare l’output di Helm. [blog post](https://blog.gruntwork.io/automated-testing-for-kubernetes-and-helm-charts-using-terratest-a4ddc4e67344)

> Lo strumento ufficiale di test Helm [`ct`](https://github.com/helm/chart-testing) non è pensato per unit test o snapshot test ma per lint e test di integrazione.

Sebbene siano strumenti preziosi per testare i Helm chart, hanno alcune limitazioni per quanto riguarda il snapshot testing.

- Devi imparare e preparare i file Test Suite degli strumenti anche solo per il snapshot testing.

- Non fanno lo snapshot dell’intero chart di default, ma sono progettati per testare file per file all’interno del chart Helm.

- Gli output dinamici delle funzioni Helm non sono considerati.

helm-unittest è progettato per condurre test file per file all’interno del chart Helm. Questo significa che valuta ogni file indipendentemente, e quando i valori o le condizioni del chart Helm portano a includere o escludere un intero file in modo condizionale, può risultare che i test non coprano scenari importanti.

Ecco un esempio di file di specifica di test per lo snapshot testing in helm-unittest.

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

Ad esempio, considera uno scenario in cui il chart Helm può creare una risorsa `Certificate` di `cert-manager` quando sia TLS che cert-manager sono abilitati, ma crea una risorsa `Secret` TLS autofirmata usando la funzione helm [`genSelfSignedCert`](https://helm.sh/docs/chart_template_guide/function_list/#genselfsignedcert) quando cert-manager non è abilitato. Inoltre, l’attivazione di TLS influenza le proprietà TLS di Ingress, le opzioni TLS specifiche dell’app in Deployment, ecc.

In questi casi, helm-unittest potrebbe non essere in grado di testare adeguatamente il comportamento dell’intero chart, poiché l’output di questi file condizionali potrebbe essere vuoto, portando a test incompleti.

Tuttavia, tutto ciò che devi fare con `helm-chartsnap` è semplicemente preparare alcuni file `values.yaml` con i pattern che ti aspetti 😊

## Installazione 🚀

Puoi installarlo come plugin Helm.

```sh
helm plugin install https://github.com/jlandowner/helm-chartsnap
```

Altre opzioni:

- Go install

  ```sh
  go install github.com/jlandowner/helm-chartsnap@latest
  ```

- [Scarica il binary della release](https://github.com/jlandowner/helm-chartsnap/releases)

## Utilizzo

Basta passare il tuo chart per iniziare rapidamente.

```
helm chartsnap -c YOUR_CHART
```

La directory `__snapshot__` viene creata nella directory del chart e viene creato `default.snap`.

Puoi anche creare casi di test come variazione dei file Values del tuo chart.

Ecco l’utilizzo completo del comando.

```sh
Usage:
  chartsnap -c CHART [flags]

Examples:

  # Snapshot con valori di default:
  chartsnap -c YOUR_CHART
  
  # Aggiorna i file snapshot:
  chartsnap -c YOUR_CHART -u

  # Snapshot con valori di test:
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILE
  
  # Snapshot di tutti i casi di test:
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILES_DIRECTOY
  
  # Imposta argomenti o flag aggiuntivi per il comando 'helm template':
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILE -- --skip-tests

  # Snapshot di chart remoti nel repository Helm:
  chartsnap -c CHART_NAME -f YOUR_VALUES_FILE -- --repo HELM_REPO_URL

  # Snapshot di ingress-nginx (https://kubernetes.github.io/ingress-nginx/) helm chart per una versione specifica con il tuo file values:
  chartsnap -c ingress-nginx -f YOUR_VALUES_FILE -- --repo https://kubernetes.github.io/ingress-nginx --namespace kube-system --version 4.8.3

  # Snapshot di cilium (https://cilium.io) helm chart con valore di default e flag impostati:
  chartsnap -c cilium -- --repo https://helm.cilium.io --namespace kube-system --set hubble.relay.enabled=true --set hubble.ui.enabled=true

  # Snapshot di chart in registro OCI
  chartsnap -c oci://ghcr.io/nginxinc/charts/nginx-gateway-fabric -n nginx-gateway

  # Output senza colori:
  NO_COLOR=1 chartsnap -c YOUR_CHART

Flags:
  -c, --chart string              percorso della directory del chart. questo flag viene passato a 'helm template RELEASE_NAME CHART --values VALUES' come 'CHART'
      --config-file string        nome o percorso del file di configurazione, che definisce il comportamento dello snapshot, es. campi dinamici (default ".chartsnap.yaml")
  -N, --ctx-lines int             numero di righe da mostrare nell’output diff. 0 per output completo (default 3)
      --debug                     modalità debug
      --fail-helm-error           fallisce se il comando 'helm template' fallisce
      --failfast                  termina al primo caso di test fallito
  -h, --help                      aiuto per chartsnap
  -n, --namespace string          namespace. questo flag viene passato a 'helm template RELEASE_NAME CHART --values VALUES --namespace NAMESPACE' come 'NAMESPACE' (default "default")
  -o, --output-dir string         directory in cui viene creata la directory __snapshot__. (default: directory del file values se --values è impostato; directory del chart se il chart è locale; altrimenti directory corrente)
      --parallelism int           concorrenza dei test se si fanno più snapshot per una directory di file valori di test. default illimitato (default -1)
      --release-name string       nome della release. questo flag viene passato a 'helm template RELEASE_NAME CHART --values VALUES' come 'RELEASE_NAME' (default "chartsnap")
      --snapshot-version string   usa una versione specifica del formato snapshot. v1, v2, v3 sono supportate. (default: ultima)
  -u, --update-snapshot           modalità aggiorna snapshot
  -f, --values string             percorso di un file o directory di valori di test. se è impostata una directory, tutti i file di test vengono testati. se vuoto, vengono usati i valori di default. questo flag viene passato a 'helm template RELEASE_NAME CHART --values VALUES' come 'VALUES'
  -v, --version                   versione di chartsnap

```

### Gestione dei valori dinamici 💪

Helm ha una funzionalità chiamata "Helm functions" che genera valori casuali o certificati autofirmati come [`randAlphaNum`](https://helm.sh/docs/chart_template_guide/function_list/#randalphanum-randalpha-randnumeric-and-randascii) e [`genCA`, `genPrivateKey`, `genSelfSignedCert`](https://helm.sh/docs/chart_template_guide/function_list/#cryptographic-and-security-functions)

Quando utilizzi queste funzioni, l’output varierà a ogni esecuzione di Helm.
Per questo caso, chartsnap ha una funzionalità che previene snapshot non corrispondenti sostituendoli con un valore fisso, `###DYNAMIC_FIELD###`.

Puoi specificare i percorsi dei valori dinamici nello YAML generato usando [JSONPath](https://datatracker.ietf.org/doc/html/rfc6901).

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

> NOTA:
> In JSONPath, l’escape del carattere / è documentato in [RFC6901, sezione 3](https://datatracker.ietf.org/doc/html/rfc6901#section-3)
> ```
>    Poiché i caratteri '~' (%x7E) e '/' (%x2F) hanno significati speciali in JSON Pointer, '~' deve essere codificato come '~0' e '/' come '~1' quando questi caratteri appaiono in un token di riferimento.
> ```
>
> Quindi, se gestisci un manifest come il seguente, devi specificare il json path come `/metadata/annotaions/checksum~1values`.
> 
> ```yaml
> metadata:
>   annotations:
>     checksum/values: RANDOM_VALUES
> ```

Se hai una directory di file di valori di test, posiziona il file `.chartsnap.yaml` all’interno di quella directory. È un comportamento comune per tutti i test snapshot nella directory.

Per altri esempi, vedi [example/app1](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/app1).

In alternativa, puoi aggiungere direttamente la configurazione nel file di valori di test come proprietà `testSpec`.
In questo caso, non serve preparare `.chartsnap.yaml`. È utile per scattare snapshot di chart remoti o di terze parti con un singolo file values.

Il tuo file values può essere così:

```yaml
# Aggiungi questa proprietà ai tuoi valori.
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

# Gli altri possono essere qualsiasi valore del tuo chart.
# ...
```

Per altri esempi, vedi [example/remote](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/remote).

## Showcase & Utenti ✨

| Utenti / Progetti | Descrizione | URL |
|:---|:---|:---|
| Example | Chart di esempio generato dal comando `helm create` | [`example/app1`](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/app1) |
| Example | Esempio di snapshot di chart in repository Helm remoti | [`example/remote`](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/remote) |
| [helm-chartsnap-action](https://github.com/jlandowner/helm-chartsnap-action) | GitHub action per usare helm chartsnap in CI | https://github.com/jlandowner/helm-chartsnap-action |
| [cosmo-workspace](https://github.com/cosmo-workspace/cosmo) | Piattaforma open source WebIDE & DevEnvironment su Kubernetes | https://github.com/cosmo-workspace/cosmo/tree/main/charts/cosmo/test |
| [Kong](https://github.com/Kong/kong) | 🦍 Cloud-Native API Gateway e AI Gateway. | https://github.com/Kong/charts |

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---
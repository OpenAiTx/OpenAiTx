# helm-chartsnap 📸 
[![Go Reference](https://pkg.go.dev/badge/github.com/jlandowner/helm-chartsnap.svg)](https://pkg.go.dev/github.com/jlandowner/helm-chartsnap)
[![Go Report Card](https://goreportcard.com/badge/github.com/jlandowner/helm-chartsnap)](https://goreportcard.com/report/github.com/jlandowner/helm-chartsnap)
[![codecov](https://codecov.io/gh/jlandowner/helm-chartsnap/graph/badge.svg?token=8ARG53CRL7)](https://codecov.io/gh/jlandowner/helm-chartsnap)
[![Workflow Status](https://github.com/jlandowner/helm-chartsnap/actions/workflows/release.yaml/badge.svg)](https://github.com/jlandowner/helm-chartsnap/actions/workflows/release.yaml)
[![CI](https://github.com/jlandowner/helm-chartsnap/actions/workflows/ci.yaml/badge.svg)](https://github.com/jlandowner/helm-chartsnap/actions/workflows/ci.yaml)
[![GitHub Marketplace](https://img.shields.io/badge/Marketplace-Helm%20chartsnap%20action-blue.svg?colorA=24292e&colorB=0366d6&style=flat&longCache=true&logo=github)](https://github.com/marketplace/actions/helm-chartsnap-action)

Snapshot testtool voor Helm charts.

Breng krachtige UI-testmogelijkheden naar Helm charts met minimale configuratie, direct in het `values.yaml` bestand.

![screenshot](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/docs/screenshot.png)

## Overzicht
- [Functies 🔑](#functies-)
- [Waarom Snapshot Testing? 📸](#waarom-snapshot-testing-)
  - [Motivatie](#motivatie)
- [Installatie 🚀](#installatie-)
- [Gebruik](#gebruik)
  - [Omgaan met dynamische waarden 💪](#omgaan-met-dynamische-waarden-)
- [Showcase & Gebruikers ✨](#showcase--gebruikers-)

## Functies 🔑

* **Eenvoudige & Intuïtieve Snapshot testing voor Helm ontwikkelaars**
  
  - **Geen tool-specifiek TestSuite bestandsformaat**: In tegenstelling tot sommige tools die vereisen dat er aparte TestSuites met aangepaste bestandsformaten worden aangemaakt, vereist deze tool geen extra bestandsformaten. Je kunt in plaats daarvan variaties van het standaard `values.yaml` bestand voorbereiden voor elke test case. Dit elimineert de noodzaak om nieuwe formaten te leren en vereenvoudigt het testen.

* **Geoptimaliseerd voor Helm chart**

  - **Omgaan met dynamische output gegenereerd door helm functies**: Je kunt extra eigenschappen specificeren binnen het values.yaml bestand voor elke test case om flexibiliteit te bieden in het aanpassen van het testgedrag. Je kunt bijvoorbeeld de output regelen die dynamisch wordt gegenereerd door helm functies zoals [randAlphaNum](https://helm.sh/docs/chart_template_guide/function_list/).

* **Continue Snapshot testing**

  - **[GitHub Action](https://github.com/jlandowner/helm-chartsnap-action) is beschikbaar**: GitHub action die continue snapshot testing mogelijk maakt voor lokale of externe Helm charts in je CI is beschikbaar 🚀 -> [`helm-chart-action`](https://github.com/jlandowner/helm-chartsnap-action)

## Waarom Snapshot Testing? 📸

Ik geloof dat snapshot testing, een populaire testaanpak in Web- of UI-testing met tools zoals Jest, de beste manier is om Helm charts te testen. Snapshot testing biedt verschillende voordelen:

- **Visuele vergelijkingen:** Snapshot tests maken een basisuitvoer aan en vergelijken deze vervolgens met latere testresultaten. Dit maakt eenvoudige visuele inspectie van wijzigingen en regressies in de Helm chart rendering mogelijk.

- **Verbeterde onderhoudbaarheid:** Snapshot testing vereenvoudigt het opzetten van tests, waardoor het toegankelijker en beter onderhoudbaar is, vooral bij complexe Helm charts. De invoer voor de Helm chart is een combinatie van waarden. Je hoeft alleen de aangenomen invoercombinaties (=values.yaml) en hun snapshots te onderhouden.

- **Continue testing:** Door continu snapshots te maken van de Helm chart in je CI-proces, kun je snel veranderingen in je gehele chart opmerken en regressies voorkomen.

Deze voordelen zijn niet alleen beperkt tot de Helm chart die je zelf hebt aangemaakt, maar gelden ook voor derde partij charts die je op je Kubernetes hebt geïnstalleerd als je Kubernetes beheerder bent. Bij het upgraden van een cluster kun je eventuele wijzigingen in de output manifests, geproduceerd door jouw *values*, opmerken, hoe klein ook.

### Motivatie

Er bestaan reeds Helm testtools die snapshot tests ondersteunen.
- [helm-unittest](https://github.com/helm-unittest/helm-unittest), een populaire unittes tool, heeft een optie voor [snapshot testing](https://github.com/helm-unittest/helm-unittest#snapshot-testing).
- [terratest](https://terratest.gruntwork.io/), Geautomatiseerde tests voor je infrastructuurcode. Je kunt tests schrijven als Go code en het heeft de mogelijkheid om de output van Helm te testen. [blogpost](https://blog.gruntwork.io/automated-testing-for-kubernetes-and-helm-charts-using-terratest-a4ddc4e67344)

> De officiële Helm testtool [`ct`](https://github.com/helm/chart-testing) is niet bedoeld voor unittests of snapshot tests, maar voor lint- en integratietests.

Hoewel dit waardevolle tools zijn voor het testen van Helm charts, hebben ze bepaalde beperkingen voor snapshot testing.

- Je moet de Test Suite-bestanden van de tools leren en voorbereiden, zelfs als het alleen voor snapshot testing is.

- Standaard wordt niet de gehele chart gesnapshot, maar is het ontworpen om per bestand binnen de Helm chart te testen.

- Dynamische output van Helm functies wordt niet meegenomen.

helm-unittest is ontworpen om tests uit te voeren per bestand binnen de Helm chart. Dit betekent dat elk bestand onafhankelijk wordt geëvalueerd, en wanneer Helm chart waarden of condities ertoe leiden dat een heel bestand conditioneel wordt opgenomen of uitgesloten, kan het resulteren in tests die belangrijke scenario's niet dekken.

Hier is een voorbeeld van een testspecificatiebestand voor snapshot testing in helm-unittest.

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
>   # of je kunt het gehele manifest snappen
>   - it: manifest should match snapshot
>     asserts:
>       - matchSnapshot: {}
> ```

Stel je bijvoorbeeld een scenario voor waarin de Helm chart een `Certificate` resource van `cert-manager` aanmaakt als zowel TLS als cert-manager is ingeschakeld, maar een self-signed TLS `Secret` resource aanmaakt met de helm functie [`genSelfSignedCert`](https://helm.sh/docs/chart_template_guide/function_list/#genselfsignedcert) als cert-manager niet is ingeschakeld. Verder beïnvloedt het al dan niet inschakelen van TLS de TLS-eigenschappen van Ingress, app-specifieke TLS-opties van Deployment, enzovoort.

In zulke gevallen kan helm-unittest mogelijk niet het gedrag van de gehele chart adequaat testen, omdat de output van deze conditionele bestanden leeg kan zijn, wat leidt tot onvolledige tests.

Met `helm-chartsnap` hoef je echter alleen maar enkele `values.yaml` bestanden voor de verwachte patronen voor te bereiden 😊

## Installatie 🚀

Je kunt het installeren als een Helm plugin.

```sh
helm plugin install https://github.com/jlandowner/helm-chartsnap
```

Andere opties:

- Go install

  ```sh
  go install github.com/jlandowner/helm-chartsnap@latest
  ```

- [Download release binary](https://github.com/jlandowner/helm-chartsnap/releases)

## Gebruik

Geef gewoon je chart door voor een snelle start.

```
helm chartsnap -c JOUW_CHART
```

De `__snapshot__` directory wordt aangemaakt in de chart directory en `default.snap` wordt aangemaakt.

Je kunt ook testcases aanmaken als een variatie op de Values-bestanden van je chart.

Hier is het volledige gebruik van het commando.

```sh
Gebruik:
  chartsnap -c CHART [flags]

Voorbeelden:

  # Snapshot met standaardwaarden:
  chartsnap -c JOUW_CHART
  
  # Snapshotbestanden bijwerken:
  chartsnap -c JOUW_CHART -u

  # Snapshot met testcasewaarden:
  chartsnap -c JOUW_CHART -f JOUW_TEST_VALUES_FILE
  
  # Snapshot alle testcases:
  chartsnap -c JOUW_CHART -f JOUW_TEST_VALUES_FILES_DIRECTORY
  
  # Stel extra args of vlaggen in voor het 'helm template' commando:
  chartsnap -c JOUW_CHART -f JOUW_TEST_VALUES_FILE -- --skip-tests

  # Snapshot externe chart in Helm repository:
  chartsnap -c CHART_NAME -f JOUW_VALUES_FILE -- --repo HELM_REPO_URL

  # Snapshot ingress-nginx (https://kubernetes.github.io/ingress-nginx/) helm chart voor een specifieke versie met jouw value-bestand:
  chartsnap -c ingress-nginx -f JOUW_VALUES_FILE -- --repo https://kubernetes.github.io/ingress-nginx --namespace kube-system --version 4.8.3

  # Snapshot cilium (https://cilium.io) helm chart met standaardwaarde en extra vlaggen:
  chartsnap -c cilium -- --repo https://helm.cilium.io --namespace kube-system --set hubble.relay.enabled=true --set hubble.ui.enabled=true

  # Snapshot charts in OCI registry
  chartsnap -c oci://ghcr.io/nginxinc/charts/nginx-gateway-fabric -n nginx-gateway

  # Output zonder kleuren:
  NO_COLOR=1 chartsnap -c JOUW_CHART

Flags:
  -c, --chart string              pad naar de chart directory. Deze vlag wordt doorgegeven aan 'helm template RELEASE_NAME CHART --values VALUES' als 'CHART'
      --config-file string        config-bestandsnaam of pad, dat het snapshotgedrag definieert, zoals dynamische velden (standaard ".chartsnap.yaml")
  -N, --ctx-lines int             aantal regels om te tonen in diff-output. 0 voor volledige output (standaard 3)
      --debug                     debugmodus
      --fail-helm-error           falen als het 'helm template' commando faalt
      --failfast                  stop bij de eerste fout in een testcase
  -h, --help                      help voor chartsnap
  -n, --namespace string          namespace. Deze vlag wordt doorgegeven aan 'helm template RELEASE_NAME CHART --values VALUES --namespace NAMESPACE' als 'NAMESPACE' (standaard "default")
  -o, --output-dir string         directory waar de __snapshot__ directory wordt aangemaakt. (standaard: values-bestand directory als --values is ingesteld; chart directory als chart lokaal is; anders huidige directory)
      --parallelism int           testconcurrentie als er meerdere snapshots worden gemaakt voor een test value-bestandsdirectory. standaard is onbeperkt (standaard -1)
      --release-name string       release naam. Deze vlag wordt doorgegeven aan 'helm template RELEASE_NAME CHART --values VALUES' als 'RELEASE_NAME' (standaard "chartsnap")
      --snapshot-version string   gebruik een specifieke snapshot formaatversie. v1, v2, v3 worden ondersteund. (standaard: laatste)
  -u, --update-snapshot           update snapshot modus
  -f, --values string             pad naar een test values-bestand of directory. Als een directory is ingesteld, worden alle testbestanden getest. Indien leeg, worden standaardwaarden gebruikt. Deze vlag wordt doorgegeven aan 'helm template RELEASE_NAME CHART --values VALUES' als 'VALUES'
  -v, --version                   versie van chartsnap

```

### Omgaan met dynamische waarden 💪

Helm heeft een functie genaamd "Helm functies" die willekeurige waarden of self-signed certificaten genereert, zoals [`randAlphaNum`](https://helm.sh/docs/chart_template_guide/function_list/#randalphanum-randalpha-randnumeric-and-randascii) en [`genCA`, `genPrivateKey`, `genSelfSignedCert`](https://helm.sh/docs/chart_template_guide/function_list/#cryptographic-and-security-functions)

Wanneer je deze functies gebruikt, zal de output telkens anders zijn als Helm wordt uitgevoerd.
Voor dit geval heeft chartsnap een functie die voorkomt dat snapshots niet overeenkomen door deze te vervangen door een vaste waarde, `###DYNAMIC_FIELD###`.

Je kunt de paden van dynamische waarden in de gegenereerde YAML specificeren met behulp van [JSONPath](https://datatracker.ietf.org/doc/html/rfc6901).

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

> OPMERKING:
> In JSONPath wordt het escapen van het /-teken gedocumenteerd in [RFC6901, sectie 3](https://datatracker.ietf.org/doc/html/rfc6901#section-3)
> ```
>    Omdat de tekens '~' (%x7E) en '/' (%x2F) speciale
>    betekenissen hebben in JSON Pointer, moet '~' worden gecodeerd als '~0' en '/'
>    als '~1' wanneer deze tekens voorkomen in een referentietoken.
> ```
>
> Dus als je een manifest zoals het volgende verwerkt, moet je het json path specificeren als `/metadata/annotaions/checksum~1values`.
> 
> ```yaml
> metadata:
>   annotations:
>     checksum/values: RANDOM_VALUES
> ```

Als je een test values-bestanden directory hebt, plaats dan een `.chartsnap.yaml` bestand in die directory. Het gedrag geldt dan voor alle snapshot tests in die directory.

Voor meer voorbeelden, zie [example/app1](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/app1).

Je kunt de configuratie ook direct toevoegen in het test values-bestand als een `testSpec` eigenschap.
In dit geval hoef je geen `.chartsnap.yaml` te maken. Dit is bedoeld voor het nemen van snapshots van externe of derde partij charts met je eigen values-bestand.

Je values-bestand kan er zo uitzien:

```yaml
# Voeg deze eigenschap toe aan je values.
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

# De rest kan uit jouw chartwaarden bestaan.
# ...
```

Voor meer voorbeelden, zie [example/remote](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/remote).

## Showcase & Gebruikers ✨

| Gebruikers / Projecten | Omschrijving | URL |
|:---|:---|:---|
| Voorbeeld | Voorbeeld chart gegenereerd door het `helm create` commando | [`example/app1`](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/app1) |
| Voorbeeld | Voorbeeld van snapshotten van charts in externe Helm repositories | [`example/remote`](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/remote) |
| [helm-chartsnap-action](https://github.com/jlandowner/helm-chartsnap-action) | GitHub action om helm chartsnap in CI te gebruiken | https://github.com/jlandowner/helm-chartsnap-action |
| [cosmo-workspace](https://github.com/cosmo-workspace/cosmo) | Open source WebIDE & DevEnvironment Platform op Kubernetes | https://github.com/cosmo-workspace/cosmo/tree/main/charts/cosmo/test |
| [Kong](https://github.com/Kong/kong) | 🦍 De Cloud-Native API Gateway en AI Gateway. | https://github.com/Kong/charts |


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---
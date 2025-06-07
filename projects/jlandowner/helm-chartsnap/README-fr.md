# helm-chartsnap 📸 
[![Go Reference](https://pkg.go.dev/badge/github.com/jlandowner/helm-chartsnap.svg)](https://pkg.go.dev/github.com/jlandowner/helm-chartsnap)
[![Go Report Card](https://goreportcard.com/badge/github.com/jlandowner/helm-chartsnap)](https://goreportcard.com/report/github.com/jlandowner/helm-chartsnap)
[![codecov](https://codecov.io/gh/jlandowner/helm-chartsnap/graph/badge.svg?token=8ARG53CRL7)](https://codecov.io/gh/jlandowner/helm-chartsnap)
[![Workflow Status](https://github.com/jlandowner/helm-chartsnap/actions/workflows/release.yaml/badge.svg)](https://github.com/jlandowner/helm-chartsnap/actions/workflows/release.yaml)
[![CI](https://github.com/jlandowner/helm-chartsnap/actions/workflows/ci.yaml/badge.svg)](https://github.com/jlandowner/helm-chartsnap/actions/workflows/ci.yaml)
[![GitHub Marketplace](https://img.shields.io/badge/Marketplace-Helm%20chartsnap%20action-blue.svg?colorA=24292e&colorB=0366d6&style=flat&longCache=true&logo=github)](https://github.com/marketplace/actions/helm-chartsnap-action)

Outil de tests de snapshots pour les charts Helm.

Apportez de puissantes fonctionnalités de tests d’interface utilisateur pour vos charts Helm avec une configuration minimale uniquement dans le fichier `values.yaml`.

![capture d'écran](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/docs/screenshot.png)

## Vue d'ensemble
- [Fonctionnalités 🔑](#fonctionnalités-)
- [Pourquoi les tests de snapshot ? 📸](#pourquoi-les-tests-de-snapshot-)
  - [Motivation](#motivation)
- [Installation 🚀](#installation-)
- [Utilisation](#utilisation)
  - [Gestion des valeurs dynamiques 💪](#gestion-des-valeurs-dynamiques-)
- [Vitrine & Utilisateurs ✨](#vitrine--utilisateurs-)


## Fonctionnalités 🔑

* **Tests de snapshot faciles et intuitifs pour les développeurs Helm**
  
  - **Pas de format de fichier TestSuite spécifique à l’outil** : Contrairement à certains outils qui nécessitent la création de TestSuites séparés avec des formats de fichiers personnalisés, cet outil ne requiert aucun format de fichier supplémentaire. Vous pouvez simplement préparer des variantes du fichier standard `values.yaml` pour chaque cas de test. Cela élimine la nécessité d’apprendre de nouveaux formats et simplifie les tests.

* **Optimisé pour les charts Helm**

  - **Gestion de la sortie dynamique générée par les fonctions helm** : Vous pouvez spécifier des propriétés supplémentaires dans le fichier values.yaml pour chaque cas de test afin d’ajuster le comportement du test. Par exemple, vous pouvez contrôler la sortie générée dynamiquement par des fonctions helm comme [randAlphaNum](https://helm.sh/docs/chart_template_guide/function_list/).

* **Tests de snapshot continus**

  - **[GitHub Action](https://github.com/jlandowner/helm-chartsnap-action) disponible** : Une action GitHub permettant d’effectuer des tests de snapshot continus pour des charts Helm locaux ou distants dans votre CI est prête 🚀 -> [`helm-chart-action`](https://github.com/jlandowner/helm-chartsnap-action)

## Pourquoi les tests de snapshot ? 📸

Je pense que les tests de snapshot, une approche de test populaire dans le Web ou les tests UI avec des outils comme Jest, sont la meilleure façon de tester les charts Helm. Les tests de snapshot offrent plusieurs avantages :

- **Comparaisons visuelles :** Les tests de snapshot créent une sortie de référence, puis la comparent aux résultats des tests ultérieurs. Cela permet une inspection visuelle facile des changements et régressions dans le rendu des charts Helm.

- **Meilleure maintenabilité :** Les tests de snapshot simplifient le processus de configuration des tests, le rendant plus accessible et maintenable, surtout pour les charts Helm complexes. L'entrée du chart Helm est une combinaison de valeurs. Il suffit de maintenir les combinaisons d’entrées supposées (=values.yaml) et leurs snapshots.

- **Tests continus :** En prenant continuellement des snapshots du chart Helm dans votre processus CI, vous pouvez rapidement remarquer les changements dans l’ensemble de votre chart et éviter les régressions.

Ces avantages ne sont pas limités au chart Helm que vous avez créé, mais concernent aussi les charts tiers que vous avez installés sur votre Kubernetes si vous êtes administrateur Kubernetes. Lors de la mise à jour d’un cluster, vous pouvez constater tout changement dans les manifests générés par vos *values*, même minime.


### Motivation

Il existe des outils de test Helm qui prennent en charge les tests de snapshot.
- [helm-unittest](https://github.com/helm-unittest/helm-unittest), un outil de tests unitaires populaire, dispose d’une option pour effectuer des [tests de snapshot](https://github.com/helm-unittest/helm-unittest#snapshot-testing).
- [terratest](https://terratest.gruntwork.io/), tests automatisés pour votre code d’infrastructure. Il permet d’écrire des tests en Go et propose une fonctionnalité pour tester la sortie de Helm. [article de blog](https://blog.gruntwork.io/automated-testing-for-kubernetes-and-helm-charts-using-terratest-a4ddc4e67344)

> L’outil officiel de test Helm [`ct`](https://github.com/helm/chart-testing) n’est pas destiné aux tests unitaires ni aux tests de snapshot mais aux tests de lint et d’intégration.

Bien qu’ils soient utiles pour tester les charts Helm, ces outils présentent certaines limitations pour les tests de snapshot.

- Il est nécessaire d’apprendre et de préparer les fichiers Test Suite de ces outils, même uniquement pour les tests de snapshot.

- Par défaut, ils ne réalisent pas de snapshot de l’ensemble du chart, mais sont conçus pour tester fichier par fichier à l’intérieur du chart Helm.

- Les sorties dynamiques des fonctions Helm ne sont pas prises en compte.

helm-unittest est conçu pour effectuer des tests fichier par fichier dans le chart Helm. Cela signifie qu’il évalue chaque fichier indépendamment, et lorsque les valeurs ou conditions du chart Helm conduisent à l’inclusion ou l’exclusion conditionnelle d’un fichier entier, cela peut conduire à ce que les tests ne couvrent pas des scénarios importants.

Voici un exemple de fichier de spécification de test pour les tests de snapshot dans helm-unittest.

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

Par exemple, imaginez un scénario où le chart Helm peut créer une ressource `Certificate` de `cert-manager` lorsque TLS est activé et cert-manager aussi, mais créer une ressource `Secret` TLS auto-signée avec la fonction helm [`genSelfSignedCert`](https://helm.sh/docs/chart_template_guide/function_list/#genselfsignedcert) lorsque cert-manager n’est pas activé. De plus, l’activation ou non de TLS affecte les propriétés TLS d’Ingress, les options TLS spécifiques à l’application dans Deployment, etc.

Dans ces cas, helm-unittest peut ne pas être capable de tester adéquatement le comportement global du chart, car la sortie de ces fichiers conditionnels peut être vide, entraînant des tests incomplets.

Cependant, avec `helm-chartsnap`, il vous suffit de préparer quelques fichiers `values.yaml` correspondant aux cas que vous attendez 😊

## Installation 🚀

Vous pouvez l’installer comme plugin Helm.

```sh
helm plugin install https://github.com/jlandowner/helm-chartsnap
```

Autres options :

- Installation via Go

  ```sh
  go install github.com/jlandowner/helm-chartsnap@latest
  ```

- [Télécharger le binaire de la release](https://github.com/jlandowner/helm-chartsnap/releases)

## Utilisation

Passez simplement votre chart pour un démarrage rapide.

```
helm chartsnap -c VOTRE_CHART
```

Un répertoire `__snapshot__` est créé dans le répertoire du chart et `default.snap` est généré.

Vous pouvez également créer des cas de test comme variantes des fichiers Values de votre chart.

Voici l’utilisation complète de la commande.

```sh
Utilisation :
  chartsnap -c CHART [flags]

Exemples :

  # Snapshot avec les valeurs par défaut :
  chartsnap -c VOTRE_CHART
  
  # Mettre à jour les fichiers de snapshot :
  chartsnap -c VOTRE_CHART -u

  # Snapshot avec des valeurs de cas de test :
  chartsnap -c VOTRE_CHART -f VOTRE_FICHIER_VALUES_TEST
  
  # Snapshot de tous les cas de test :
  chartsnap -c VOTRE_CHART -f VOTRE_RÉPERTOIRE_DE_FICHIERS_VALUES_TEST
  
  # Définir des arguments ou flags supplémentaires pour la commande 'helm template' :
  chartsnap -c VOTRE_CHART -f VOTRE_FICHIER_VALUES_TEST -- --skip-tests

  # Snapshot d’un chart distant dans un dépôt Helm :
  chartsnap -c NOM_DU_CHART -f VOTRE_FICHIER_VALUES -- --repo URL_REPO_HELM

  # Snapshot du chart ingress-nginx (https://kubernetes.github.io/ingress-nginx/) pour une version spécifique avec votre fichier de valeurs :
  chartsnap -c ingress-nginx -f VOTRE_FICHIER_VALUES -- --repo https://kubernetes.github.io/ingress-nginx --namespace kube-system --version 4.8.3

  # Snapshot du chart cilium (https://cilium.io) avec la valeur par défaut et des flags définis :
  chartsnap -c cilium -- --repo https://helm.cilium.io --namespace kube-system --set hubble.relay.enabled=true --set hubble.ui.enabled=true

  # Snapshot de charts dans un registre OCI
  chartsnap -c oci://ghcr.io/nginxinc/charts/nginx-gateway-fabric -n nginx-gateway

  # Sortie sans couleurs :
  NO_COLOR=1 chartsnap -c VOTRE_CHART

Flags :
  -c, --chart string              chemin vers le répertoire du chart. ce flag est passé à 'helm template RELEASE_NAME CHART --values VALUES' comme 'CHART'
      --config-file string        nom ou chemin du fichier de configuration, qui définit le comportement du snapshot ex : champs dynamiques (par défaut ".chartsnap.yaml")
  -N, --ctx-lines int             nombre de lignes à afficher dans la sortie diff. 0 pour la sortie complète (par défaut 3)
      --debug                     mode debug
      --fail-helm-error           échouer si la commande 'helm template' a échoué
      --failfast                  échouer dès qu’un cas de test échoue
  -h, --help                      aide pour chartsnap
  -n, --namespace string          namespace. ce flag est passé à 'helm template RELEASE_NAME CHART --values VALUES --namespace NAMESPACE' comme 'NAMESPACE' (par défaut "default")
  -o, --output-dir string         répertoire dans lequel le dossier __snapshot__ est créé. (par défaut : répertoire du fichier values si --values est défini ; répertoire du chart si chart local ; sinon répertoire courant)
      --parallelism int           parallélisme des tests si plusieurs snapshots sont pris pour un répertoire de fichiers de valeurs de test. par défaut illimité (par défaut -1)
      --release-name string       nom de la release. ce flag est passé à 'helm template RELEASE_NAME CHART --values VALUES' comme 'RELEASE_NAME' (par défaut "chartsnap")
      --snapshot-version string   utiliser une version spécifique du format de snapshot. v1, v2, v3 sont supportées. (par défaut : la plus récente)
  -u, --update-snapshot           mode mise à jour du snapshot
  -f, --values string             chemin vers un fichier ou un dossier de valeurs de test. si un dossier est indiqué, tous les fichiers de test sont testés. si vide, valeurs par défaut utilisées. ce flag est passé à 'helm template RELEASE_NAME CHART --values VALUES' comme 'VALUES'
  -v, --version                   version de chartsnap

```

### Gestion des valeurs dynamiques 💪

Helm dispose d’une fonctionnalité appelée "fonctions Helm" qui génère des valeurs aléatoires ou des certificats auto-signés comme [`randAlphaNum`](https://helm.sh/docs/chart_template_guide/function_list/#randalphanum-randalpha-randnumeric-and-randascii) et [`genCA`, `genPrivateKey`, `genSelfSignedCert`](https://helm.sh/docs/chart_template_guide/function_list/#cryptographic-and-security-functions)

Lorsque vous utilisez ces fonctions, la sortie varie à chaque exécution de Helm.
Pour ce cas, chartsnap propose une fonctionnalité qui évite des snapshots non concordants en les remplaçant par une valeur fixe, `###DYNAMIC_FIELD###`.

Vous pouvez spécifier les chemins des valeurs dynamiques dans le YAML généré en utilisant [JSONPath](https://datatracker.ietf.org/doc/html/rfc6901).

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

> REMARQUE :
> En JSONPath, l’échappement du caractère / est documenté dans [RFC6901, section 3](https://datatracker.ietf.org/doc/html/rfc6901#section-3)
> ```
>    Parce que les caractères '~' (%x7E) et '/' (%x2F) ont des significations spéciales dans JSON Pointer, '~' doit être encodé en '~0' et '/' en '~1' lorsqu’ils apparaissent dans un token de référence.
> ```
>
> Donc si vous gérez un manifest comme ci-dessous, vous devez spécifier le chemin json comme `/metadata/annotaions/checksum~1values`.
> 
> ```yaml
> metadata:
>   annotations:
>     checksum/values: RANDOM_VALUES
> ```

Si vous avez un répertoire de fichiers de valeurs de test, placez-y un fichier `.chartsnap.yaml`. Ce comportement est commun à tous les tests de snapshot du dossier.

Pour plus d’exemples, voir [example/app1](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/app1).

Alternativement, vous pouvez ajouter directement la configuration dans le fichier de valeurs de test via la propriété `testSpec`.
Dans ce cas, il n’est pas nécessaire de préparer un `.chartsnap.yaml`. C’est utile pour prendre des snapshots de charts distants ou tiers avec un seul fichier de valeurs.

Votre fichier de valeurs peut ressembler à ceci :

```yaml
# Ajoutez cette propriété à vos valeurs.
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

# Le reste peut être n’importe quelle valeur de votre chart.
# ...
```

Pour plus d’exemples, voir [example/remote](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/remote).

## Vitrine & Utilisateurs ✨

| Utilisateurs / Projets | Description | URL |
|:---|:---|:---|
| Exemple | Chart exemple généré par la commande `helm create` | [`example/app1`](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/app1) |
| Exemple | Exemple de snapshot de charts dans des dépôts Helm distants | [`example/remote`](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/remote) |
| [helm-chartsnap-action](https://github.com/jlandowner/helm-chartsnap-action) | Action GitHub pour utiliser helm chartsnap en CI | https://github.com/jlandowner/helm-chartsnap-action |
| [cosmo-workspace](https://github.com/cosmo-workspace/cosmo) | Plateforme WebIDE & DevEnvironment open source sur Kubernetes | https://github.com/cosmo-workspace/cosmo/tree/main/charts/cosmo/test |
| [Kong](https://github.com/Kong/kong) | 🦍 La passerelle API Cloud-Native et AI Gateway. | https://github.com/Kong/charts |


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---
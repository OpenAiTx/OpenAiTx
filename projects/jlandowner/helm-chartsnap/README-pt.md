# helm-chartsnap 📸 
[![Go Reference](https://pkg.go.dev/badge/github.com/jlandowner/helm-chartsnap.svg)](https://pkg.go.dev/github.com/jlandowner/helm-chartsnap)
[![Go Report Card](https://goreportcard.com/badge/github.com/jlandowner/helm-chartsnap)](https://goreportcard.com/report/github.com/jlandowner/helm-chartsnap)
[![codecov](https://codecov.io/gh/jlandowner/helm-chartsnap/graph/badge.svg?token=8ARG53CRL7)](https://codecov.io/gh/jlandowner/helm-chartsnap)
[![Workflow Status](https://github.com/jlandowner/helm-chartsnap/actions/workflows/release.yaml/badge.svg)](https://github.com/jlandowner/helm-chartsnap/actions/workflows/release.yaml)
[![CI](https://github.com/jlandowner/helm-chartsnap/actions/workflows/ci.yaml/badge.svg)](https://github.com/jlandowner/helm-chartsnap/actions/workflows/ci.yaml)
[![GitHub Marketplace](https://img.shields.io/badge/Marketplace-Helm%20chartsnap%20action-blue.svg?colorA=24292e&colorB=0366d6&style=flat&longCache=true&logo=github)](https://github.com/marketplace/actions/helm-chartsnap-action)

Ferramenta de testes de snapshot para Helm charts.

Traga capacidades poderosas de teste de interface para Helm chart com configuração mínima, apenas dentro do arquivo `values.yaml`. 

![screenshot](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/docs/screenshot.png)

## Visão Geral
- [Funcionalidades 🔑](#funcionalidades-)
- [Por que Teste de Snapshot? 📸](#por-que-teste-de-snapshot-)
  - [Motivação](#motivação)
- [Instalação 🚀](#instalação-)
- [Uso](#uso)
  - [Lidando com valores dinâmicos 💪](#lidando-com-valores-dinâmicos-)
- [Exemplos & Usuários ✨](#exemplos--usuários-)


## Funcionalidades 🔑

* **Teste de snapshot fácil e intuitivo para desenvolvedores Helm**
  
  - **Sem formato de arquivo TestSuite específico da ferramenta**: Diferente de algumas ferramentas que exigem a criação de TestSuites separadas com formatos de arquivo personalizados, esta ferramenta não requer formatos de arquivo adicionais. Em vez disso, você pode preparar variações do arquivo padrão `values.yaml` para cada caso de teste. Isso elimina a necessidade de aprender novos formatos e simplifica os testes.

* **Otimizado para Helm chart**

  - **Lida com saída dinâmica gerada por funções do helm**: Você pode especificar propriedades adicionais dentro do arquivo values.yaml para cada caso de teste para fornecer flexibilidade ao ajustar o comportamento do teste. Por exemplo, é possível controlar a saída gerada dinamicamente por funções do helm como [randAlphaNum](https://helm.sh/docs/chart_template_guide/function_list/).

* **Teste de snapshot contínuo**

  - **[GitHub Action](https://github.com/jlandowner/helm-chartsnap-action) está pronta**: GitHub Action que permite realizar testes contínuos de snapshot para charts Helm locais ou remotos na sua CI está pronta 🚀 -> [`helm-chart-action`](https://github.com/jlandowner/helm-chartsnap-action)

## Por que Teste de Snapshot? 📸

Acredito que o teste de snapshot, uma abordagem de teste popular em Web ou UI com ferramentas como Jest, seja a melhor forma de testar Helm charts. O teste de snapshot oferece vários benefícios:

- **Comparações visuais:** Os testes de snapshot criam uma saída base e depois a comparam com os resultados de testes subsequentes. Isso permite uma inspeção visual fácil de mudanças e regressões no renderização do Helm chart.

- **Maior manutenibilidade:** O teste de snapshot simplifica o processo de configuração do teste, tornando-o mais acessível e fácil de manter, especialmente ao lidar com charts Helm complexos. A entrada para o Helm chart é uma combinação de valores. Só precisamos manter as combinações de entrada assumidas (=values.yaml) e seus snapshots.

- **Testes contínuos:** Ao capturar continuamente snapshots do Helm chart em seu processo de CI, você pode rapidamente perceber mudanças em todo o seu chart e evitar regressões.

Essas vantagens não se limitam ao chart Helm que você criou, mas também aos charts de terceiros que você instalou no seu Kubernetes, caso seja um administrador Kubernetes. Ao atualizar um cluster, você pode perceber quaisquer mudanças nos manifests de saída produzidos pelos seus *values*, por menores que sejam.


### Motivação

Existem ferramentas de teste Helm que suportam testes de snapshot.
- [helm-unittest](https://github.com/helm-unittest/helm-unittest), uma popular ferramenta de teste unitário, possui uma opção para fazer [teste de snapshot](https://github.com/helm-unittest/helm-unittest#snapshot-testing).
- [terratest](https://terratest.gruntwork.io/), testes automatizados para seu código de infraestrutura. Permite escrever testes em Go e possui recurso para testar a saída do Helm. [blog post](https://blog.gruntwork.io/automated-testing-for-kubernetes-and-helm-charts-using-terratest-a4ddc4e67344)

> A ferramenta oficial de teste do Helm [`ct`](https://github.com/helm/chart-testing) não é para testes unitários ou de snapshot, mas para lint e teste de integração

Embora sejam ferramentas valiosas para testar Helm charts, possuem certas limitações para teste de snapshot.

- É necessário aprender e preparar arquivos de Test Suite das ferramentas mesmo que seja apenas para teste de snapshot.

- Não faz snapshot do chart inteiro por padrão, mas é projetado para testar por arquivo dentro do Helm chart.

- As saídas dinâmicas das funções do Helm não são consideradas.

helm-unittest é projetado para conduzir testes por arquivo dentro do Helm chart. Isso significa que avalia cada arquivo de forma independente e, quando valores ou condições do Helm chart levam a um arquivo inteiro ser incluído ou excluído condicionalmente, isso pode resultar em testes incapazes de cobrir cenários importantes.

Aqui está um exemplo de arquivo de especificação de teste para teste de snapshot no helm-unittest.

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
>   # ou você pode fazer snapshot do manifest inteiro
>   - it: manifest should match snapshot
>     asserts:
>       - matchSnapshot: {}
> ```

Por exemplo, considere um cenário onde o Helm chart pode criar um recurso `Certificate` do `cert-manager` quando ambos TLS e cert-manager estão habilitados, mas criar um recurso `Secret` TLS autoassinado usando a função do helm [`genSelfSignedCert`](https://helm.sh/docs/chart_template_guide/function_list/#genselfsignedcert) quando cert-manager não está habilitado. Além disso, se TLS está habilitado ou não afeta as propriedades TLS do Ingress, opções TLS específicas do Deployment, etc.

Nesses casos, o helm-unittest pode não ser capaz de testar adequadamente o comportamento completo do chart, pois a saída desses arquivos condicionais pode ser vazia, levando a testes incompletos.

No entanto, tudo o que você precisa fazer com `helm-chartsnap` é apenas preparar alguns arquivos `values.yaml` dos padrões que você espera 😊

## Instalação 🚀

Você pode instalar como um plugin do Helm.

```sh
helm plugin install https://github.com/jlandowner/helm-chartsnap
```

Outras opções:

- Instalação via Go

  ```sh
  go install github.com/jlandowner/helm-chartsnap@latest
  ```

- [Baixar binário de release](https://github.com/jlandowner/helm-chartsnap/releases)

## Uso

Basta passar seu chart para um início rápido.

```
helm chartsnap -c SEU_CHART
```

O diretório `__snapshot__` é criado no diretório do chart e `default.snap` é criado.

Também é possível criar casos de teste como variações dos arquivos Values do seu chart.

Aqui está o uso completo do comando.

```sh
Uso:
  chartsnap -c CHART [flags]

Exemplos:

  # Snapshot com valores padrão:
  chartsnap -c SEU_CHART
  
  # Atualizar arquivos de snapshot:
  chartsnap -c SEU_CHART -u

  # Snapshot com valores do caso de teste:
  chartsnap -c SEU_CHART -f SEU_ARQUIVO_TESTE_VALUES
  
  # Snapshot de todos os casos de teste:
  chartsnap -c SEU_CHART -f SEU_DIRETÓRIO_ARQUIVOS_VALUES_TESTE
  
  # Definir argumentos ou flags adicionais para o comando 'helm template':
  chartsnap -c SEU_CHART -f SEU_ARQUIVO_TESTE_VALUES -- --skip-tests

  # Snapshot de chart remoto em repositório Helm:
  chartsnap -c NOME_DO_CHART -f SEU_ARQUIVO_VALUES -- --repo URL_DO_REPO_HELM

  # Snapshot do ingress-nginx (https://kubernetes.github.io/ingress-nginx/) helm chart para uma versão específica com seu arquivo de valores:
  chartsnap -c ingress-nginx -f SEU_ARQUIVO_VALUES -- --repo https://kubernetes.github.io/ingress-nginx --namespace kube-system --version 4.8.3

  # Snapshot do cilium (https://cilium.io) helm chart com valor padrão e definir flags:
  chartsnap -c cilium -- --repo https://helm.cilium.io --namespace kube-system --set hubble.relay.enabled=true --set hubble.ui.enabled=true

  # Snapshot de charts em registro OCI
  chartsnap -c oci://ghcr.io/nginxinc/charts/nginx-gateway-fabric -n nginx-gateway

  # Saída sem cores:
  NO_COLOR=1 chartsnap -c SEU_CHART

Flags:
  -c, --chart string              caminho para o diretório do chart. este flag é passado para 'helm template RELEASE_NAME CHART --values VALUES' como 'CHART'
      --config-file string        nome ou caminho do arquivo de configuração, que define o comportamento do snapshot, por exemplo, campos dinâmicos (padrão: ".chartsnap.yaml")
  -N, --ctx-lines int             número de linhas a mostrar na saída diff. 0 para saída completa (padrão: 3)
      --debug                     modo debug
      --fail-helm-error           falha se o comando 'helm template' falhar
      --failfast                  falha ao primeiro caso de teste que falhar
  -h, --help                      ajuda para chartsnap
  -n, --namespace string          namespace. este flag é passado para 'helm template RELEASE_NAME CHART --values VALUES --namespace NAMESPACE' como 'NAMESPACE' (padrão: "default")
  -o, --output-dir string         diretório onde o diretório __snapshot__ será criado. (padrão: diretório do arquivo de valores se --values estiver definido; diretório do chart se chart for local; senão diretório atual)
      --parallelism int           concorrência dos testes ao tirar múltiplos snapshots para um diretório de arquivos de valores de teste. padrão é ilimitado (padrão: -1)
      --release-name string       nome do release. este flag é passado para 'helm template RELEASE_NAME CHART --values VALUES' como 'RELEASE_NAME' (padrão: "chartsnap")
      --snapshot-version string   usar uma versão específica de formato de snapshot. v1, v2, v3 são suportados. (padrão: latest)
  -u, --update-snapshot           modo de atualização de snapshot
  -f, --values string             caminho para um arquivo ou diretório de valores de teste. se o diretório for definido, todos os arquivos de teste são testados. se vazio, valores padrão são usados. este flag é passado para 'helm template RELEASE_NAME CHART --values VALUES' como 'VALUES'
  -v, --version                   versão do chartsnap

```

### Lidando com valores dinâmicos 💪

Helm possui um recurso chamado "funções do Helm" que gera valores aleatórios ou certificados autoassinados como [`randAlphaNum`](https://helm.sh/docs/chart_template_guide/function_list/#randalphanum-randalpha-randnumeric-and-randascii) e [`genCA`, `genPrivateKey`, `genSelfSignedCert`](https://helm.sh/docs/chart_template_guide/function_list/#cryptographic-and-security-functions)

Ao usar essas funções, a saída irá variar a cada execução do Helm.
Para esses casos, o chartsnap possui um recurso que evita snapshots incompatíveis substituindo-os por um valor fixo, `###DYNAMIC_FIELD###`.

Você pode especificar os caminhos dos valores dinâmicos no YAML gerado usando [JSONPath](https://datatracker.ietf.org/doc/html/rfc6901).

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
> No JSONPath, o escape do caractere / está documentado na [RFC6901, seção 3](https://datatracker.ietf.org/doc/html/rfc6901#section-3)
> ```
>    Porque os caracteres '~' (%x7E) e '/' (%x2F) têm significados especiais no JSON Pointer, '~' precisa ser codificado como '~0' e '/' como '~1' quando esses caracteres aparecem em um token de referência.
> ```
>
> Portanto, se você manipular um manifest como o exemplo a seguir, é necessário especificar o caminho json como `/metadata/annotaions/checksum~1values`.
> 
> ```yaml
> metadata:
>   annotations:
>     checksum/values: RANDOM_VALUES
> ```

Se você tiver um diretório de arquivos de valores de teste, coloque um arquivo `.chartsnap.yaml` dentro desse diretório. É um comportamento comum em todos os testes de snapshot no diretório.

Para mais exemplos, veja [example/app1](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/app1).

Alternativamente, você pode adicionar a configuração diretamente no arquivo de valores de teste como uma propriedade `testSpec`.
Neste caso, não é necessário preparar o `.chartsnap.yaml`. É para tirar snapshots de charts remotos ou de terceiros com seu único arquivo de valores.

Seu arquivo de valores pode ser assim:

```yaml
# Adicione esta propriedade aos seus valores.
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

# Os outros podem ser quaisquer valores do seu chart.
# ...
```

Para mais exemplos, veja [example/remote](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/remote).

## Exemplos & Usuários ✨

| Usuários / Projetos | Descrição | URL |
|:---|:---|:---|
| Exemplo | Chart de exemplo gerado pelo comando `helm create` | [`example/app1`](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/app1) |
| Exemplo | Exemplo de snapshot de charts em repositórios Helm remotos | [`example/remote`](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/remote) |
| [helm-chartsnap-action](https://github.com/jlandowner/helm-chartsnap-action) | GitHub Action para usar helm chartsnap no CI | https://github.com/jlandowner/helm-chartsnap-action |
| [cosmo-workspace](https://github.com/cosmo-workspace/cosmo) | Plataforma WebIDE & DevEnvironment open source no Kubernetes | https://github.com/cosmo-workspace/cosmo/tree/main/charts/cosmo/test |
| [Kong](https://github.com/Kong/kong) | 🦍 O API Gateway Cloud-Native e AI Gateway. | https://github.com/Kong/charts |


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---
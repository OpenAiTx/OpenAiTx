# Gitleaks

```
┌─○───┐
│ │╲  │
│ │ ○ │
│ ○ ░ │
└─░───┘
```

[license]: https://raw.githubusercontent.com/gitleaks/gitleaks/master/LICENSE
[badge-license]: https://img.shields.io/github/license/gitleaks/gitleaks.svg
[go-docs-badge]: https://pkg.go.dev/badge/github.com/gitleaks/gitleaks/v8?status
[go-docs]: https://pkg.go.dev/github.com/zricethezav/gitleaks/v8
[badge-build]: https://github.com/gitleaks/gitleaks/actions/workflows/test.yml/badge.svg
[build]: https://github.com/gitleaks/gitleaks/actions/workflows/test.yml
[go-report-card-badge]: https://goreportcard.com/badge/github.com/gitleaks/gitleaks/v8
[go-report-card]: https://goreportcard.com/report/github.com/gitleaks/gitleaks/v8
[dockerhub]: https://hub.docker.com/r/zricethezav/gitleaks
[dockerhub-badge]: https://img.shields.io/docker/pulls/zricethezav/gitleaks.svg
[gitleaks-action]: https://github.com/gitleaks/gitleaks-action
[gitleaks-badge]: https://img.shields.io/badge/protected%20by-gitleaks-blue
[gitleaks-playground-badge]: https://img.shields.io/badge/gitleaks%20-playground-blue
[gitleaks-playground]: https://gitleaks.io/playground


[![GitHub Action Test][badge-build]][build]
[![Docker Hub][dockerhub-badge]][dockerhub]
[![Gitleaks Playground][gitleaks-playground-badge]][gitleaks-playground]
[![Gitleaks Action][gitleaks-badge]][gitleaks-action]
[![GoDoc][go-docs-badge]][go-docs]
[![GoReportCard][go-report-card-badge]][go-report-card]
[![License][badge-license]][license]


### Junte-se ao nosso Discord! [![Discord](https://img.shields.io/discord/1102689410522284044.svg?label=&logo=discord&logoColor=ffffff&color=7389D8&labelColor=6A7EC2)](https://discord.gg/8Hzbrnkr7E)

Gitleaks é uma ferramenta para **detectar** segredos como senhas, chaves de API e tokens em repositórios git, arquivos e qualquer outra coisa que você quiser analisar via `stdin`. Se quiser saber mais sobre como o mecanismo de detecção funciona, confira este blog: [Regex is (almost) all you need](https://lookingatcomputer.substack.com/p/regex-is-almost-all-you-need).


```
➜  ~/code(master) gitleaks git -v

    ○
    │╲
    │ ○
    ○ ░
    ░    gitleaks


Achado:      "export BUNDLE_ENTERPRISE__CONTRIBSYS__COM=cafebabe:deadbeef",
Segredo:     cafebabe:deadbeef
RuleID:      sidekiq-secret
Entropia:    2.609850
Arquivo:     cmd/generate/config/rules/sidekiq.go
Linha:       23
Commit:      cd5226711335c68be1e720b318b7bc3135a30eb2
Autor:       John
Email:       john@users.noreply.github.com
Data:        2022-08-03T12:31:40Z
Fingerprint: cd5226711335c68be1e720b318b7bc3135a30eb2:cmd/generate/config/rules/sidekiq.go:sidekiq-secret:23
```

## Primeiros Passos

O Gitleaks pode ser instalado usando Homebrew, Docker ou Go. O Gitleaks também está disponível em formato binário para muitas plataformas e tipos de sistemas operacionais populares na [página de releases](https://github.com/gitleaks/gitleaks/releases). Além disso, o Gitleaks pode ser implementado como um hook de pré-commit diretamente no seu repositório ou como uma ação do GitHub usando o [Gitleaks-Action](https://github.com/gitleaks/gitleaks-action).

### Instalação

```bash
# MacOS
brew install gitleaks

# Docker (DockerHub)
docker pull zricethezav/gitleaks:latest
docker run -v ${path_to_host_folder_to_scan}:/path zricethezav/gitleaks:latest [COMANDO] [OPÇÕES] [CAMINHO_ORIGEM]

# Docker (ghcr.io)
docker pull ghcr.io/gitleaks/gitleaks:latest
docker run -v ${path_to_host_folder_to_scan}:/path ghcr.io/gitleaks/gitleaks:latest [COMANDO] [OPÇÕES] [CAMINHO_ORIGEM]

# Do código fonte (certifique-se de que o `go` está instalado)
git clone https://github.com/gitleaks/gitleaks.git
cd gitleaks
make build
```

### GitHub Action

Confira a [Gitleaks GitHub Action](https://github.com/gitleaks/gitleaks-action) oficial

```
name: gitleaks
on: [pull_request, push, workflow_dispatch]
jobs:
  scan:
    name: gitleaks
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v3
        with:
          fetch-depth: 0
      - uses: gitleaks/gitleaks-action@v2
        env:
          GITHUB_TOKEN: ${{ secrets.GITHUB_TOKEN }}
          GITLEAKS_LICENSE: ${{ secrets.GITLEAKS_LICENSE}} # Necessário apenas para organizações, não para contas pessoais.
```

### Pre-Commit

1. Instale o pre-commit em https://pre-commit.com/#install
2. Crie um arquivo `.pre-commit-config.yaml` na raiz do seu repositório com o seguinte conteúdo:

   ```
   repos:
     - repo: https://github.com/gitleaks/gitleaks
       rev: v8.24.2
       hooks:
         - id: gitleaks
   ```

   para uma [execução nativa do gitleaks](https://github.com/gitleaks/gitleaks/releases) ou use o ID [`gitleaks-docker` do pre-commit](https://raw.githubusercontent.com/gitleaks/gitleaks/master/.pre-commit-hooks.yaml) para executar o gitleaks usando as [imagens Docker oficiais](#docker)

3. Atualize automaticamente a configuração para as versões mais recentes dos repositórios executando `pre-commit autoupdate`
4. Instale com `pre-commit install`
5. Agora está tudo pronto!

```
➜ git commit -m "este commit contém um segredo"
Detect hardcoded secrets.................................................Failed
```

Nota: para desabilitar o hook de pre-commit do gitleaks, você pode colocar `SKIP=gitleaks` antes do comando de commit
e isso irá pular a execução do gitleaks

```
➜ SKIP=gitleaks git commit -m "pular verificação do gitleaks"
Detect hardcoded secrets................................................Skipped
```

## Uso

```
Uso:
  gitleaks [comando]

Comandos disponíveis:
  dir         verifica diretórios ou arquivos em busca de segredos
  git         verifica repositórios git em busca de segredos
  help        Ajuda sobre qualquer comando
  stdin       detecta segredos a partir do stdin
  version     exibe a versão do gitleaks

Flags:
  -b, --baseline-path string          caminho para baseline com problemas que podem ser ignorados
  -c, --config string                 caminho do arquivo de configuração
                                      ordem de precedência:
                                      1. --config/-c
                                      2. variável de ambiente GITLEAKS_CONFIG
                                      3. variável de ambiente GITLEAKS_CONFIG_TOML com o conteúdo do arquivo
                                      4. (caminho alvo)/.gitleaks.toml
                                      Se nenhuma das quatro opções for usada, o gitleaks utilizará a configuração padrão
      --diagnostics string            habilita diagnósticos (lista separada por vírgulas: cpu,mem,trace). cpu=profiling de CPU, mem=profiling de memória, trace=tracing de execução
      --diagnostics-dir string        diretório para armazenar os arquivos de saída dos diagnósticos (padrão é o diretório atual)
      --enable-rule strings           habilita apenas regras específicas pelo id
      --exit-code int                 código de saída quando vazamentos forem encontrados (padrão 1)
  -i, --gitleaks-ignore-path string   caminho para o arquivo .gitleaksignore ou pasta que contenha um (padrão ".")
  -h, --help                          ajuda para o gitleaks
      --ignore-gitleaks-allow         ignora comentários gitleaks:allow
  -l, --log-level string              nível de log (trace, debug, info, warn, error, fatal) (padrão "info")
      --max-decode-depth int          permite decodificação recursiva até esta profundidade (padrão "0", nenhuma decodificação é feita)
      --max-archive-depth int         permite análise em arquivos compactados aninhados até esta profundidade (padrão "0", nenhum arquivo compactado é analisado)
      --max-target-megabytes int      arquivos maiores que isso serão ignorados
      --no-banner                     suprime o banner
      --no-color                      desativa cor na saída detalhada
      --redact uint[=100]             redige segredos dos logs e do stdout. Para redigir apenas partes do segredo, aplique um valor percentual de 0..100. Por exemplo --redact=20 (padrão 100%)
  -f, --report-format string          formato de saída (json, csv, junit, sarif, template)
  -r, --report-path string            arquivo de relatório
      --report-template string        arquivo de template usado para gerar o relatório (implica --report-format=template)
  -v, --verbose                       mostra saída detalhada da verificação
      --version                       versão do gitleaks

Use "gitleaks [comando] --help" para mais informações sobre um comando.
```

### Comandos

⚠️ A v8.19.0 introduziu uma alteração que descontinuou os comandos `detect` e `protect`. Esses comandos ainda estão disponíveis, mas estão ocultos no menu `--help`. Confira este [gist](https://gist.github.com/zricethezav/b325bb93ebf41b9c0b0507acf12810d2) para traduções fáceis de comandos.
Se você perceber que a v8.19.0 quebrou um comando existente (`detect`/`protect`), por favor, abra uma issue.

Existem três modos de varredura: `git`, `dir` e `stdin`.

#### Git

O comando `git` permite que você verifique repositórios git locais. Internamente, o gitleaks usa o comando `git log -p` para analisar patches.
Você pode configurar o comportamento do `git log -p` com a opção `log-opts`.
Por exemplo, se você quiser rodar o gitleaks em um intervalo de commits, pode usar o seguinte
comando: `gitleaks git -v --log-opts="--all commitA..commitB" caminho_para_repo`. Veja a documentação do [git log](https://git-scm.com/docs/git-log) para mais informações.
Se não houver alvo especificado como argumento posicional, então o gitleaks tentará analisar o diretório de trabalho atual como um repositório git.
#### Dir

O comando `dir` (os aliases incluem `files`, `directory`) permite que você faça a varredura de diretórios e arquivos. Exemplo: `gitleaks dir -v caminho_para_diretório_ou_arquivo`.
Se nenhum alvo for especificado como argumento posicional, então o gitleaks fará a varredura no diretório de trabalho atual.

#### Stdin

Você também pode transmitir dados para o gitleaks com o comando `stdin`. Exemplo: `cat algum_arquivo | gitleaks -v stdin`

### Criando uma linha de base

Ao escanear grandes repositórios ou repositórios com um histórico longo, pode ser conveniente usar uma linha de base. Ao usar uma linha de base,
o gitleaks irá ignorar quaisquer achados antigos que estejam presentes na linha de base. Uma linha de base pode ser qualquer relatório do gitleaks. Para criar um relatório do gitleaks, execute o gitleaks com o parâmetro `--report-path`.

```
gitleaks git --report-path gitleaks-report.json # Isto salvará o relatório em um arquivo chamado gitleaks-report.json
```

Uma vez criada a linha de base, ela pode ser aplicada ao executar novamente o comando detect:

```
gitleaks git --baseline-path gitleaks-report.json --report-path findings.json
```

Após executar o comando detect com o parâmetro --baseline-path, a saída do relatório (findings.json) conterá apenas problemas novos.

## Hook de Pré-Commit

Você pode executar o Gitleaks como um hook de pré-commit copiando o script de exemplo `pre-commit.py` para o seu diretório
`.git/hooks/`.

## Carregar Configuração

A ordem de precedência é:

1. Opção `--config/-c`:
      ```bash
      gitleaks git --config /home/dev/customgitleaks.toml .
      ```
2. Variável de ambiente `GITLEAKS_CONFIG` com o caminho do arquivo:
      ```bash
      export GITLEAKS_CONFIG="/home/dev/customgitleaks.toml"
      gitleaks git .
      ```
3. Variável de ambiente `GITLEAKS_CONFIG_TOML` com o conteúdo do arquivo:
      ```bash
      export GITLEAKS_CONFIG_TOML=`cat customgitleaks.toml`
      gitleaks git .
      ```
4. Um arquivo `.gitleaks.toml` dentro do caminho alvo:
      ```bash
      gitleaks git .
      ```

Se nenhuma das quatro opções for utilizada, o gitleaks usará a configuração padrão.

## Configuração

O Gitleaks oferece um formato de configuração que você pode seguir para escrever suas próprias regras de detecção de segredos:

```toml
# Título para o arquivo de configuração do gitleaks.
title = "Configuração personalizada do Gitleaks"

# Basicamente você tem duas opções para sua configuração personalizada:
#
# 1. definir sua própria configuração, as regras padrão não se aplicam
#
#    use, por exemplo, a configuração padrão como ponto de partida:
#    https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml
#
# 2. estender uma configuração, as regras são sobrescritas ou estendidas
#
#    Quando você estende uma configuração, as regras estendidas têm precedência sobre as
#    regras padrão. Ou seja, se houver regras duplicadas tanto na configuração estendida
#    quanto na configuração padrão, as regras estendidas ou
#    atributos delas irão sobrescrever as regras padrão.
#    Outra coisa a saber ao estender configurações é que você pode encadear
#    vários arquivos de configuração até uma profundidade de 2. Arrays de allowlist são
#    concatenados e podem conter duplicatas.

# useDefault e path NÃO podem ser usados ao mesmo tempo. Escolha um.
[extend]
# useDefault irá estender a configuração padrão do gitleaks embutida no binário
# a versão mais recente está localizada em:
# https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml
useDefault = true
# ou você pode fornecer um caminho para uma configuração da qual estender.
# O caminho é relativo de onde o gitleaks foi invocado,
# não da localização da configuração base.
# path = "common_config.toml"
# Se houver regras que você não deseja herdar, elas podem ser especificadas aqui.
disabledRules = [ "generic-api-key"]

# Um array de tabelas que contém informações que definem instruções
# de como detectar segredos
[[rules]]
# Identificador único para esta regra
id = "awesome-rule-1"

# Descrição curta e legível da regra.
description = "awesome rule 1"

# Expressão regular do Golang usada para detectar segredos. Note que o engine de regex do Golang
# não suporta lookaheads.
regex = '''one-go-style-regex-for-this-rule'''

# Inteiro usado para extrair o segredo da correspondência da regex e usado como o grupo que terá
# sua entropia verificada se `entropy` estiver definido.
secretGroup = 3

# Float representando a entropia shannon mínima que um grupo da regex deve ter para ser considerado um segredo.
entropy = 3.5

# Expressão regular do Golang usada para corresponder caminhos. Pode ser usada como uma regra independente ou em conjunto
# com uma entrada `regex` válida.
path = '''a-file-path-regex'''

# Palavras-chave são usadas para filtragem prévia antes da regex. Regras que contêm
# palavras-chave executarão uma verificação rápida de comparação de string para garantir que a(s)
# palavra(s)-chave estejam no conteúdo sendo escaneado. Idealmente, esses valores devem
# fazer parte do identificador ou serem strings únicas específicas da regex da regra
# (introduzido na v8.6.0)
keywords = [
  "auth",
  "password",
  "token",
]

# Array de strings usado para metadados e propósitos de relatório.
tags = ["tag","another tag"]

    # ⚠️ Na v8.21.0 `[rules.allowlist]` foi substituído por `[[rules.allowlists]]`.
    # Essa mudança foi retrocompatível: instâncias de `[rules.allowlist]` ainda funcionam.
    #
    # Você pode definir múltiplas allowlists para uma regra para reduzir falsos positivos.
    # Um achado será ignorado se _QUALQUER_ `[[rules.allowlists]]` corresponder.
    [[rules.allowlists]]
    description = "ignorar commit A"
    # Quando múltiplos critérios são definidos, a condição padrão é "OR".
    # por exemplo, isto pode corresponder a |commits| OU |paths| OU |stopwords|.
    condition = "OR"
    commits = [ "commit-A", "commit-B"]
    paths = [
      '''go\.mod''',
      '''go\.sum'''
    ]
    # nota: stopwords mira o segredo extraído, não toda a correspondência da regex
    # como 'regexes' faz. (stopwords introduzido na 8.8.0)
    stopwords = [
      '''client''',
      '''endpoint''',
    ]

    [[rules.allowlists]]
    # A condição "AND" pode ser usada para garantir que todos os critérios sejam atendidos.
    # por exemplo, corresponde se |regexes| E |paths| forem satisfeitos.
    condition = "AND"
    # nota: |regexes| faz a verificação padrão no _Secret_ do achado.
    # Valores aceitáveis para |regexTarget| são "secret" (padrão), "match" e "line".
    regexTarget = "match"
    regexes = [ '''(?i)parseur[il]''' ]
    paths = [ '''package-lock\.json''' ]

# Você pode estender uma regra específica da configuração padrão. Exemplo: gitlab-pat
# se você definiu um prefixo de token personalizado em sua instância GitLab
[[rules]]
id = "gitlab-pat"
# todos os outros atributos da regra padrão são herdados

    [[rules.allowlists]]
    regexTarget = "line"
    regexes = [ '''MY-glpat-''' ]


# ⚠️ Na v8.25.0 `[allowlist]` foi substituído por `[[allowlists]]`.
#
# Allowlists globais têm maior precedência do que allowlists específicas de regra.
# Se um commit listado no campo `commits` abaixo for encontrado, então esse commit será ignorado e nenhum
# segredo será detectado para tal commit. A mesma lógica se aplica para regexes e paths.
[[allowlists]]
description = "lista de permissões global"
commits = [ "commit-A", "commit-B", "commit-C"]
paths = [
  '''gitleaks\.toml''',
  '''(.*?)(jpg|gif|doc)'''
]
# nota: (global) regexTarget faz a verificação padrão no _Secret_ do achado.
# Valores aceitáveis para regexTarget são "match" e "line"
regexTarget = "match"
regexes = [
  '''219-09-9999''',
  '''078-05-1120''',
  '''(9[0-9]{2}|666)-\d{2}-\d{4}''',
]
# nota: stopwords mira o segredo extraído, não toda a correspondência da regex
# como 'regexes' faz. (stopwords introduzido na 8.8.0)
stopwords = [
  '''client''',
```markdown
  '''endpoint''',
]

# ⚠️ Na versão v8.25.0, `[[allowlists]]` possui um novo campo chamado |targetRules|.
#
# Allowlist comuns podem ser definidos uma vez e atribuídos a múltiplas regras usando |targetRules|.
# Isso será executado apenas nas regras especificadas, não globalmente.
[[allowlists]]
targetRules = ["awesome-rule-1", "awesome-rule-2"]
description = "Nossos ativos de teste disparam falsos positivos em algumas regras."
paths = ['''tests/expected/._\.json$''']
```

Consulte a [configuração padrão do gitleaks](https://raw.githubusercontent.com/gitleaks/gitleaks/master/config/gitleaks.toml) para exemplos ou siga as [diretrizes de contribuição](https://raw.githubusercontent.com/gitleaks/gitleaks/master/CONTRIBUTING.md) caso queira contribuir para a configuração padrão. Além disso, confira [este post do blog do gitleaks](https://blog.gitleaks.io/stop-leaking-secrets-configuration-2-3-aeed293b1fbf) que aborda configurações avançadas.

### Configuração Adicional

#### gitleaks:allow

Se você estiver propositalmente cometendo um segredo de teste que o gitleaks irá capturar, você pode adicionar um comentário `gitleaks:allow` naquela linha, instruindo o gitleaks a ignorar aquele segredo. Exemplo:

```
class CustomClass:
    discord_client_secret = '8dyfuiRyq=vVc3RRr_edRk-fK__JItpZ'  #gitleaks:allow

```

#### .gitleaksignore

Você pode ignorar achados específicos criando um arquivo `.gitleaksignore` na raiz do seu repositório. Na versão v8.10.0, o Gitleaks adicionou um valor `Fingerprint` ao relatório do Gitleaks. Cada vazamento, ou achado, possui um Fingerprint que identifica exclusivamente um segredo. Adicione este fingerprint ao arquivo `.gitleaksignore` para ignorar aquele segredo específico. Veja o [.gitleaksignore do Gitleaks](https://raw.githubusercontent.com/gitleaks/gitleaks/master/.gitleaksignore) para um exemplo. Nota: este recurso é experimental e pode mudar no futuro.

#### Decodificação

Às vezes, segredos são codificados de uma forma que os torna difíceis de encontrar apenas com regex. Agora você pode instruir o gitleaks a localizar e decodificar automaticamente textos codificados. O parâmetro `--max-decode-depth` habilita este recurso (o valor padrão "0" significa que o recurso está desabilitado por padrão).

A decodificação recursiva é suportada, pois o texto decodificado também pode conter texto codificado. O parâmetro `--max-decode-depth` define o limite de recursão. A recursão para quando não há mais segmentos de texto codificado para decodificar, então definir uma profundidade máxima muito alta não significa necessariamente que haverá tantas passagens. Ele fará apenas quantas forem necessárias para decodificar o texto. No geral, a decodificação aumenta minimamente o tempo de varredura.

Os achados para texto codificado diferem dos achados normais das seguintes formas:

- A localização aponta para os limites do texto codificado
  - Se a regra corresponder fora do texto codificado, os limites são ajustados para incluir isso também
- A correspondência e o segredo contêm o valor decodificado
- Duas tags são adicionadas: `decoded:<encoding>` e `decode-depth:<depth>`

Codificações atualmente suportadas:

- **percent** - Quaisquer valores codificados em percent ASCII imprimíveis
- **hex** - Quaisquer valores codificados em hexadecimal ASCII imprimíveis >= 32 caracteres
- **base64** - Quaisquer valores codificados em base64 ASCII imprimíveis >= 16 caracteres

#### Varredura de Arquivos Compactados

Às vezes, segredos estão empacotados dentro de arquivos compactados como arquivos zip ou tarballs, tornando-os difíceis de descobrir. Agora você pode instruir o gitleaks a extrair automaticamente e varrer o conteúdo de arquivos compactados. O parâmetro `--max-archive-depth` habilita este recurso tanto para os tipos de varredura `dir` quanto `git`. O valor padrão "0" significa que este recurso está desabilitado por padrão.

A varredura recursiva é suportada, pois arquivos compactados podem conter outros arquivos compactados. O parâmetro `--max-archive-depth` define o limite de recursão. A recursão para quando não há mais arquivos para extrair, então definir uma profundidade máxima muito alta apenas determina o potencial para ir tão fundo. Ele irá apenas tão fundo quanto necessário.

Os achados para segredos localizados dentro de um arquivo compactado incluirão o caminho para o arquivo dentro do compactado. Caminhos internos são separados por `!`.

Exemplo de achado (resumido):

```
Finding:     DB_PASSWORD=8ae31cacf141669ddfb5da
...
File:        testdata/archives/nested.tar.gz!archives/files.tar!files/.env.prod
Line:        4
Commit:      6e6ee6596d337bb656496425fb98644eb62b4a82
...
Fingerprint: 6e6ee6596d337bb656496425fb98644eb62b4a82:testdata/archives/nested.tar.gz!archives/files.tar!files/.env.prod:generic-api-key:4
Link:        https://github.com/leaktk/gitleaks/blob/6e6ee6596d337bb656496425fb98644eb62b4a82/testdata/archives/nested.tar.gz
```

Isso significa que um segredo foi detectado na linha 4 de `files/.env.prod.`, que está em `archives/files.tar`, que por sua vez está em `testdata/archives/nested.tar.gz`.

Formatos atualmente suportados:

Os [formatos de compressão](https://github.com/mholt/archives?tab=readme-ov-file#supported-compression-formats) e [formatos de arquivos compactados](https://github.com/mholt/archives?tab=readme-ov-file#supported-archive-formats) suportados pelo pacote [archives do mholt](https://github.com/mholt/archives) são suportados.

#### Relatórios

O Gitleaks possui suporte nativo para vários formatos de relatório: [`json`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/json_simple.json), [`csv`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/csv_simple.csv?plain=1), [`junit`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/junit_simple.xml), e [`sarif`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/sarif_simple.sarif).

Se nenhum destes formatos atender à sua necessidade, você pode criar seu próprio formato de relatório com um arquivo [Go `text/template` .tmpl](https://www.digitalocean.com/community/tutorials/how-to-use-templates-in-go#step-4-writing-a-template) e o parâmetro `--report-template`. O template pode usar [funcionalidades estendidas da biblioteca de templates `Masterminds/sprig`](https://masterminds.github.io/sprig/).

Por exemplo, o seguinte template fornece uma saída JSON personalizada:
```gotemplate
# jsonextra.tmpl
[{{ $lastFinding := (sub (len . ) 1) }}
{{- range $i, $finding := . }}{{with $finding}}
    {
        "Description": {{ quote .Description }},
        "StartLine": {{ .StartLine }},
        "EndLine": {{ .EndLine }},
        "StartColumn": {{ .StartColumn }},
        "EndColumn": {{ .EndColumn }},
        "Line": {{ quote .Line }},
        "Match": {{ quote .Match }},
        "Secret": {{ quote .Secret }},
        "File": "{{ .File }}",
        "SymlinkFile": {{ quote .SymlinkFile }},
        "Commit": {{ quote .Commit }},
        "Entropy": {{ .Entropy }},
        "Author": {{ quote .Author }},
        "Email": {{ quote .Email }},
        "Date": {{ quote .Date }},
        "Message": {{ quote .Message }},
        "Tags": [{{ $lastTag := (sub (len .Tags ) 1) }}{{ range $j, $tag := .Tags }}{{ quote . }}{{ if ne $j $lastTag }},{{ end }}{{ end }}],
        "RuleID": {{ quote .RuleID }},
        "Fingerprint": {{ quote .Fingerprint }}
    }{{ if ne $i $lastFinding }},{{ end }}
{{- end}}{{ end }}
]
```

Uso:
```sh
$ gitleaks dir ~/leaky-repo/ --report-path "report.json" --report-format template --report-template testdata/report/jsonextra.tmpl
```

## Patrocínios

<p align="left">
	<h3><a href="https://coderabbit.ai/?utm_source=oss&utm_medium=sponsorship&utm_campaign=gitleaks">coderabbit.ai</h3>
	  <a href="https://coderabbit.ai/?utm_source=oss&utm_medium=sponsorship&utm_campaign=gitleaks">
		  <img alt="CodeRabbit.ai Patrocínio" src="https://github.com/gitleaks/gitleaks/assets/15034943/76c30a85-887b-47ca-9956-17a8e55c6c41" width=200>
	  </a>
</p>


## Códigos de Saída

Você sempre pode definir o código de saída quando vazamentos são encontrados com o parâmetro --exit-code. Códigos de saída padrão abaixo:

```
0 - nenhum vazamento encontrado
1 - vazamentos ou erro encontrados
126 - flag desconhecida
```
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---
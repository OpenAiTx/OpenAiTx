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


### Unisciti al nostro Discord! [![Discord](https://img.shields.io/discord/1102689410522284044.svg?label=&logo=discord&logoColor=ffffff&color=7389D8&labelColor=6A7EC2)](https://discord.gg/8Hzbrnkr7E)

Gitleaks è uno strumento per **rilevare** segreti come password, chiavi API e token nei repository git, file e qualsiasi altra cosa tu voglia analizzare tramite `stdin`. Se vuoi saperne di più su come funziona il motore di rilevamento, dai un’occhiata a questo blog: [Regex is (almost) all you need](https://lookingatcomputer.substack.com/p/regex-is-almost-all-you-need).


```
➜  ~/code(master) gitleaks git -v

    ○
    │╲
    │ ○
    ○ ░
    ░    gitleaks


Finding:     "export BUNDLE_ENTERPRISE__CONTRIBSYS__COM=cafebabe:deadbeef",
Secret:      cafebabe:deadbeef
RuleID:      sidekiq-secret
Entropy:     2.609850
File:        cmd/generate/config/rules/sidekiq.go
Line:        23
Commit:      cd5226711335c68be1e720b318b7bc3135a30eb2
Author:      John
Email:       john@users.noreply.github.com
Date:        2022-08-03T12:31:40Z
Fingerprint: cd5226711335c68be1e720b318b7bc3135a30eb2:cmd/generate/config/rules/sidekiq.go:sidekiq-secret:23
```

## Per Iniziare

Gitleaks può essere installato tramite Homebrew, Docker o Go. Gitleaks è anche disponibile in formato binario per molte piattaforme e sistemi operativi sulla [pagina dei rilasci](https://github.com/gitleaks/gitleaks/releases). Inoltre, Gitleaks può essere implementato come hook pre-commit direttamente nel tuo repository o come GitHub Action usando [Gitleaks-Action](https://github.com/gitleaks/gitleaks-action).

### Installazione

```bash
# MacOS
brew install gitleaks

# Docker (DockerHub)
docker pull zricethezav/gitleaks:latest
docker run -v ${path_to_host_folder_to_scan}:/path zricethezav/gitleaks:latest [COMMAND] [OPTIONS] [SOURCE_PATH]

# Docker (ghcr.io)
docker pull ghcr.io/gitleaks/gitleaks:latest
docker run -v ${path_to_host_folder_to_scan}:/path ghcr.io/gitleaks/gitleaks:latest [COMMAND] [OPTIONS] [SOURCE_PATH]

# Da Sorgente (assicurati che `go` sia installato)
git clone https://github.com/gitleaks/gitleaks.git
cd gitleaks
make build
```

### GitHub Action

Consulta l'[Action ufficiale di Gitleaks su GitHub](https://github.com/gitleaks/gitleaks-action)

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
          GITLEAKS_LICENSE: ${{ secrets.GITLEAKS_LICENSE}} # Richiesto solo per le Organizzazioni, non per account personali.
```

### Pre-Commit

1. Installa pre-commit da https://pre-commit.com/#install
2. Crea un file `.pre-commit-config.yaml` nella root del tuo repository con il seguente contenuto:

   ```
   repos:
     - repo: https://github.com/gitleaks/gitleaks
       rev: v8.24.2
       hooks:
         - id: gitleaks
   ```

   per una [esecuzione nativa di gitleaks](https://github.com/gitleaks/gitleaks/releases) oppure usa l'[ID pre-commit `gitleaks-docker`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/.pre-commit-hooks.yaml) per eseguire gitleaks usando le [immagini Docker ufficiali](#docker)

3. Aggiorna automaticamente la configurazione alle ultime versioni dei repository eseguendo `pre-commit autoupdate`
4. Installa con `pre-commit install`
5. Ora sei pronto!

```
➜ git commit -m "this commit contains a secret"
Detect hardcoded secrets.................................................Failed
```

Nota: per disabilitare l'hook pre-commit di gitleaks puoi anteporre `SKIP=gitleaks` al comando di commit
e verrà saltata l'esecuzione di gitleaks

```
➜ SKIP=gitleaks git commit -m "skip gitleaks check"
Detect hardcoded secrets................................................Skipped
```

## Utilizzo

```
Utilizzo:
  gitleaks [comando]

Comandi disponibili:
  dir         analizza directory o file alla ricerca di segreti
  git         analizza repository git alla ricerca di segreti
  help        Aiuto su qualsiasi comando
  stdin       rileva segreti da stdin
  version     mostra la versione di gitleaks

Flag:
  -b, --baseline-path string          percorso al baseline con problemi da ignorare
  -c, --config string                 percorso del file di configurazione
                                      ordine di precedenza:
                                      1. --config/-c
                                      2. variabile d'ambiente GITLEAKS_CONFIG
                                      3. variabile d'ambiente GITLEAKS_CONFIG_TOML con il contenuto del file
                                      4. (percorso target)/.gitleaks.toml
                                      Se nessuna delle quattro opzioni viene usata, gitleaks utilizzerà la configurazione predefinita
      --diagnostics string            abilita diagnostica (lista separata da virgole: cpu,mem,trace). cpu=profilazione CPU, mem=profilazione memoria, trace=tracing esecuzione
      --diagnostics-dir string        directory in cui salvare i file di output della diagnostica (default: directory corrente)
      --enable-rule strings           abilita solo regole specifiche per id
      --exit-code int                 codice di uscita se vengono trovate perdite (default 1)
  -i, --gitleaks-ignore-path string   percorso al file .gitleaksignore o cartella che lo contiene (default ".")
  -h, --help                          aiuto per gitleaks
      --ignore-gitleaks-allow         ignora commenti gitleaks:allow
  -l, --log-level string              livello di log (trace, debug, info, warn, error, fatal) (default "info")
      --max-decode-depth int          abilita decodifica ricorsiva fino a questa profondità (default "0", nessuna decodifica)
      --max-archive-depth int         abilita analisi in archivi annidati fino a questa profondità (default "0", nessun attraversamento archivi)
      --max-target-megabytes int      i file più grandi di questo valore saranno saltati
      --no-banner                     sopprimi il banner
      --no-color                      disattiva i colori nell'output verboso
      --redact uint[=100]             oscura i segreti nei log e in stdout. Per oscurare solo parti del segreto applicare una percentuale da 0..100. Ad esempio --redact=20 (default 100%)
  -f, --report-format string          formato di output (json, csv, junit, sarif, template)
  -r, --report-path string            file di report
      --report-template string        file template usato per generare il report (implica --report-format=template)
  -v, --verbose                       mostra output dettagliato della scansione
      --version                       mostra la versione di gitleaks

Usa "gitleaks [comando] --help" per maggiori informazioni su un comando.
```

### Comandi

⚠️ La versione v8.19.0 ha introdotto una modifica che ha deprecato `detect` e `protect`. Questi comandi sono ancora disponibili ma
sono nascosti nel menu `--help`. Dai un’occhiata a questa [gist](https://gist.github.com/zricethezav/b325bb93ebf41b9c0b0507acf12810d2) per traduzioni rapide dei comandi.
Se trovi che la v8.19.0 ha interrotto un comando esistente (`detect`/`protect`), apri una issue.

Ci sono tre modalità di scansione: `git`, `dir` e `stdin`.

#### Git

Il comando `git` ti permette di analizzare repository git locali. Internamente, gitleaks usa il comando `git log -p` per esaminare le patch.
Puoi configurare il comportamento di `git log -p` con l’opzione `log-opts`.
Ad esempio, se vuoi eseguire gitleaks su un intervallo di commit puoi usare il seguente
comando: `gitleaks git -v --log-opts="--all commitA..commitB" path_to_repo`. Consulta la documentazione di [git log](https://git-scm.com/docs/git-log) per maggiori informazioni.
Se non viene specificato alcun target come argomento posizionale, gitleaks tenterà di analizzare la directory di lavoro corrente come un repository git.
#### Dir

Il comando `dir` (alias includono `files`, `directory`) consente di eseguire la scansione di directory e file. Esempio: `gitleaks dir -v path_to_directory_or_file`.
Se non viene specificato alcun target come argomento posizionale, gitleaks eseguirà la scansione della directory di lavoro corrente.

#### Stdin

Puoi anche trasmettere dati a gitleaks tramite il comando `stdin`. Esempio: `cat some_file | gitleaks -v stdin`

### Creazione di una baseline

Quando si eseguono scansioni su repository di grandi dimensioni o con una lunga cronologia, può essere utile utilizzare una baseline. Quando si utilizza una baseline,
gitleaks ignorerà tutti i vecchi risultati presenti nella baseline. Una baseline può essere qualsiasi report di gitleaks. Per creare un report di gitleaks, esegui gitleaks con il parametro `--report-path`.

```
gitleaks git --report-path gitleaks-report.json # Questo salverà il report in un file chiamato gitleaks-report.json
```

Una volta creata la baseline, può essere applicata eseguendo nuovamente il comando detect:

```
gitleaks git --baseline-path gitleaks-report.json --report-path findings.json
```

Dopo aver eseguito il comando detect con il parametro --baseline-path, l’output del report (findings.json) conterrà solo le nuove problematiche.

## Hook Pre-Commit

Puoi eseguire Gitleaks come hook pre-commit copiando lo script di esempio `pre-commit.py` nella tua directory `.git/hooks/`.

## Caricamento della configurazione

L’ordine di precedenza è:

1. Opzione `--config/-c`:
      ```bash
      gitleaks git --config /home/dev/customgitleaks.toml .
      ```
2. Variabile d’ambiente `GITLEAKS_CONFIG` con il percorso del file:
      ```bash
      export GITLEAKS_CONFIG="/home/dev/customgitleaks.toml"
      gitleaks git .
      ```
3. Variabile d’ambiente `GITLEAKS_CONFIG_TOML` con il contenuto del file:
      ```bash
      export GITLEAKS_CONFIG_TOML=`cat customgitleaks.toml`
      gitleaks git .
      ```
4. Un file `.gitleaks.toml` all’interno del percorso target:
      ```bash
      gitleaks git .
      ```

Se nessuna delle quattro opzioni viene utilizzata, gitleaks utilizzerà la configurazione predefinita.

## Configurazione

Gitleaks offre un formato di configurazione che puoi seguire per scrivere le tue regole personalizzate di rilevamento dei segreti:

```toml
# Titolo per il file di configurazione di gitleaks.
title = "Configurazione personalizzata di Gitleaks"

# Hai fondamentalmente due opzioni per la tua configurazione personalizzata:
#
# 1. definire la tua configurazione, le regole predefinite non si applicano
#
#    usa ad es. la configurazione predefinita come punto di partenza:
#    https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml
#
# 2. estendere una configurazione, le regole vengono sovrascritte o estese
#
#    Quando estendi una configurazione, le regole estese hanno la precedenza su
#    quelle predefinite. Cioè, se ci sono regole duplicate sia nella configurazione estesa
#    che in quella predefinita, le regole estese o i loro attributi sovrascriveranno quelle predefinite.
#    Un’altra cosa da sapere sull’estensione delle configurazioni è che puoi concatenare
#    insieme più file di configurazione fino a una profondità di 2. Gli array di allowlist vengono
#    aggiunti e possono contenere duplicati.

# useDefault e path NON possono essere usati contemporaneamente. Scegline uno.
[extend]
# useDefault estenderà la configurazione predefinita di gitleaks incorporata nel binario
# la versione più recente si trova all’indirizzo:
# https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml
useDefault = true
# oppure puoi fornire un percorso a una configurazione da cui estendere.
# Il percorso è relativo a dove è stato invocato gitleaks,
# non alla posizione della configurazione di base.
# path = "common_config.toml"
# Se ci sono regole che non vuoi ereditare, possono essere specificate qui.
disabledRules = [ "generic-api-key"]

# Un array di tabelle che contiene informazioni che definiscono le istruzioni
# su come rilevare i segreti
[[rules]]
# Identificatore univoco per questa regola
id = "awesome-rule-1"

# Breve descrizione leggibile della regola.
description = "awesome rule 1"

# Espressione regolare Golang usata per rilevare segreti. Nota che il motore regex di Golang
# non supporta i lookahead.
regex = '''one-go-style-regex-for-this-rule'''

# Intero usato per estrarre il segreto dalla corrispondenza regex e utilizzato come gruppo che verrà
# sottoposto a controllo di entropia se `entropy` è impostato.
secretGroup = 3

# Float che rappresenta l’entropia minima di Shannon che un gruppo regex deve avere per essere considerato un segreto.
entropy = 3.5

# Espressione regolare Golang utilizzata per abbinare i percorsi. Può essere utilizzata come regola autonoma o in combinazione
# con una voce `regex` valida.
path = '''a-file-path-regex'''

# Le keyword sono usate per il filtraggio pre-regex. Le regole che contengono
# keyword eseguiranno un rapido controllo di confronto stringa per assicurarsi che la/le
# keyword siano nel contenuto sottoposto a scansione. Idealmente questi valori dovrebbero
# essere parte dell’identificatore o stringhe uniche specifiche per la regex della regola
# (introdotto in v8.6.0)
keywords = [
  "auth",
  "password",
  "token",
]

# Array di stringhe usate per scopi di metadata e reporting.
tags = ["tag","another tag"]

    # ⚠️ In v8.21.0 `[rules.allowlist]` è stato sostituito da `[[rules.allowlists]]`.
    # Questo cambiamento è stato retrocompatibile: le istanze di `[rules.allowlist]` funzionano ancora.
    #
    # Puoi definire più allowlist per una regola per ridurre i falsi positivi.
    # Un risultato verrà ignorato se _QUALSIASI_ `[[rules.allowlists]]` corrisponde.
    [[rules.allowlists]]
    description = "ignora commit A"
    # Quando sono definiti più criteri la condizione predefinita è "OR".
    # ad es., questo può abbinare |commits| OR |paths| OR |stopwords|.
    condition = "OR"
    commits = [ "commit-A", "commit-B"]
    paths = [
      '''go\.mod''',
      '''go\.sum'''
    ]
    # nota: stopwords mira al segreto estratto, non all’intera corrispondenza regex
    # come fa 'regexes'. (stopwords introdotto in 8.8.0)
    stopwords = [
      '''client''',
      '''endpoint''',
    ]

    [[rules.allowlists]]
    # La condizione "AND" può essere utilizzata per assicurarsi che tutti i criteri corrispondano.
    # ad es., questo corrisponde se |regexes| AND |paths| sono soddisfatti.
    condition = "AND"
    # nota: |regexes| per impostazione predefinita controlla il _Secret_ nel risultato.
    # I valori accettabili per |regexTarget| sono "secret" (predefinito), "match" e "line".
    regexTarget = "match"
    regexes = [ '''(?i)parseur[il]''' ]
    paths = [ '''package-lock\.json''' ]

# Puoi estendere una regola particolare dalla configurazione predefinita, ad es. gitlab-pat
# se hai definito un prefisso token personalizzato sulla tua istanza GitLab
[[rules]]
id = "gitlab-pat"
# tutti gli altri attributi dalla regola predefinita sono ereditati

    [[rules.allowlists]]
    regexTarget = "line"
    regexes = [ '''MY-glpat-''' ]


# ⚠️ In v8.25.0 `[allowlist]` è stato sostituito da `[[allowlists]]`.
#
# Le allowlist globali hanno un ordine di precedenza superiore rispetto alle allowlist specifiche della regola.
# Se viene incontrato un commit elencato nel campo `commits` qui sotto, quel commit verrà saltato e nessun
# segreto verrà rilevato per quel commit. La stessa logica si applica a regex e percorsi.
[[allowlists]]
description = "global allow list"
commits = [ "commit-A", "commit-B", "commit-C"]
paths = [
  '''gitleaks\.toml''',
  '''(.*?)(jpg|gif|doc)'''
]
# nota: (globale) regexTarget per impostazione predefinita controlla il _Secret_ nel risultato.
# I valori accettabili per regexTarget sono "match" e "line"
regexTarget = "match"
regexes = [
  '''219-09-9999''',
  '''078-05-1120''',
  '''(9[0-9]{2}|666)-\d{2}-\d{4}''',
]
# nota: stopwords mira al segreto estratto, non all’intera corrispondenza regex
# come fa 'regexes'. (stopwords introdotto in 8.8.0)
stopwords = [
  '''client''',
  '''endpoint''',
]

# ⚠️ Nella versione v8.25.0, `[[allowlists]]` ha un nuovo campo chiamato |targetRules|.
#
# Le allowlist comuni possono essere definite una sola volta e assegnate a più regole usando |targetRules|.
# Questo verrà eseguito solo sulle regole specificate, non globalmente.
[[allowlists]]
targetRules = ["awesome-rule-1", "awesome-rule-2"]
description = "I nostri asset di test generano falsi positivi in alcune regole."
paths = ['''tests/expected/._\.json$''']
```

Consulta la [configurazione predefinita di gitleaks](https://raw.githubusercontent.com/gitleaks/gitleaks/master/config/gitleaks.toml) per esempi o segui le [linee guida per i contributi](https://raw.githubusercontent.com/gitleaks/gitleaks/master/CONTRIBUTING.md) se desideri contribuire alla configurazione di default. Inoltre, puoi leggere [questo post del blog di gitleaks](https://blog.gitleaks.io/stop-leaking-secrets-configuration-2-3-aeed293b1fbf) che tratta configurazioni avanzate.

### Configurazione Aggiuntiva

#### gitleaks:allow

Se stai volontariamente committando un segreto di test che gitleaks rileverà, puoi aggiungere un commento `gitleaks:allow` a quella riga, il che istruirà gitleaks
a ignorare quel segreto. Esempio:

```
class CustomClass:
    discord_client_secret = '8dyfuiRyq=vVc3RRr_edRk-fK__JItpZ'  #gitleaks:allow

```

#### .gitleaksignore

Puoi ignorare specifici risultati creando un file `.gitleaksignore` nella root del tuo repository. Dalla versione v8.10.0, Gitleaks ha aggiunto un valore `Fingerprint` al report. Ogni leak, o risultato, ha un Fingerprint che identifica un segreto in modo univoco. Aggiungi questo fingerprint al file `.gitleaksignore` per ignorare quel determinato segreto. Consulta [.gitleaksignore di Gitleaks](https://raw.githubusercontent.com/gitleaks/gitleaks/master/.gitleaksignore) per un esempio. Nota: questa funzionalità è sperimentale e potrebbe cambiare in futuro.

#### Decodifica

A volte i segreti sono codificati in modo tale da renderli difficili da trovare
usando solo le regex. Ora puoi indicare a gitleaks di trovare e decodificare
automaticamente il testo codificato. Il flag `--max-decode-depth` abilita questa funzione (il valore predefinito "0" significa che è disabilitata di default).

La decodifica ricorsiva è supportata poiché il testo decodificato può anche contenere testo codificato.
Il flag `--max-decode-depth` imposta il limite di ricorsione. La ricorsione si ferma
quando non ci sono più segmenti di testo codificato da decodificare, quindi impostare una profondità massima molto alta non significa che farà tanti passaggi. Ne farà solo quanti necessari per decodificare il testo. In generale, la decodifica aumenta solo minimamente i tempi di scansione.

I risultati per il testo codificato differiscono dai risultati normali nei seguenti
modi:

- La posizione indica i limiti del testo codificato
  - Se la regola corrisponde fuori dal testo codificato, i limiti vengono regolati per
    includere anche quello
- La corrispondenza e il segreto contengono il valore decodificato
- Vengono aggiunti due tag `decoded:<encoding>` e `decode-depth:<depth>`

Codifiche attualmente supportate:

- **percent** - Qualsiasi valore ASCII stampabile codificato in percentuale
- **hex** - Qualsiasi valore ASCII stampabile codificato in esadecimale >= 32 caratteri
- **base64** - Qualsiasi valore ASCII stampabile codificato in base64 >= 16 caratteri

#### Scansione Archivi

A volte i segreti sono inseriti all'interno di file di archivio come zip o tarball,
rendendoli difficili da scoprire. Ora puoi indicare a gitleaks di estrarre e scansionare
automaticamente il contenuto degli archivi. Il flag `--max-archive-depth`
abilita questa funzionalità sia per i tipi di scansione `dir` che `git`. Il valore predefinito
"0" significa che la funzione è disabilitata di default.

La scansione ricorsiva è supportata poiché gli archivi possono anche contenere altri archivi.
Il flag `--max-archive-depth` imposta il limite di ricorsione. La ricorsione si ferma quando
non ci sono più archivi da estrarre, quindi impostare una profondità massima molto alta
stabilisce solo la possibilità di andare così in profondità. Verrà usata solo la profondità necessaria.

I risultati per i segreti trovati all'interno di un archivio includeranno il percorso al file
all'interno dell'archivio. I percorsi interni sono separati da `!`.

Esempio di risultato (accorciato per brevità):

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

Questo significa che un segreto è stato rilevato alla riga 4 di `files/.env.prod`, che si trova in
`archives/files.tar` che si trova in `testdata/archives/nested.tar.gz`.

Formati attualmente supportati:

I [formati di compressione](https://github.com/mholt/archives?tab=readme-ov-file#supported-compression-formats)
e i [formati di archivio](https://github.com/mholt/archives?tab=readme-ov-file#supported-archive-formats)
supportati dal [pacchetto archives di mholt](https://github.com/mholt/archives)
sono supportati.

#### Reportistica

Gitleaks supporta diversi formati di report integrati: [`json`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/json_simple.json), [`csv`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/csv_simple.csv?plain=1), [`junit`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/junit_simple.xml), e [`sarif`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/sarif_simple.sarif).

Se nessuno di questi formati soddisfa le tue esigenze, puoi creare un tuo formato di report con un [file Go `text/template` .tmpl](https://www.digitalocean.com/community/tutorials/how-to-use-templates-in-go#step-4-writing-a-template) e il flag `--report-template`. Il template può utilizzare [funzionalità estese della libreria template `Masterminds/sprig`](https://masterminds.github.io/sprig/).

Per esempio, il seguente template fornisce un output JSON personalizzato:
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

Utilizzo:
```sh
$ gitleaks dir ~/leaky-repo/ --report-path "report.json" --report-format template --report-template testdata/report/jsonextra.tmpl
```

## Sponsorizzazioni

<p align="left">
	<h3><a href="https://coderabbit.ai/?utm_source=oss&utm_medium=sponsorship&utm_campaign=gitleaks">coderabbit.ai</h3>
	  <a href="https://coderabbit.ai/?utm_source=oss&utm_medium=sponsorship&utm_campaign=gitleaks">
		  <img alt="Sponsorizzazione CodeRabbit.ai" src="https://github.com/gitleaks/gitleaks/assets/15034943/76c30a85-887b-47ca-9956-17a8e55c6c41" width=200>
	  </a>
</p>


## Codici di uscita

Puoi sempre impostare il codice di uscita quando vengono rilevate perdite con il flag --exit-code. Di seguito i codici di uscita predefiniti:

```
0 - nessuna perdita presente
1 - perdite o errore riscontrati
126 - flag sconosciuto
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---
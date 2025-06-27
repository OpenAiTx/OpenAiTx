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


### Dołącz do naszego Discorda! [![Discord](https://img.shields.io/discord/1102689410522284044.svg?label=&logo=discord&logoColor=ffffff&color=7389D8&labelColor=6A7EC2)](https://discord.gg/8Hzbrnkr7E)

Gitleaks to narzędzie do **wykrywania** sekretów, takich jak hasła, klucze API i tokeny w repozytoriach git, plikach oraz w czymkolwiek innym, co przekażesz przez `stdin`. Jeśli chcesz dowiedzieć się więcej o tym, jak działa silnik detekcji, sprawdź tego bloga: [Regex is (almost) all you need](https://lookingatcomputer.substack.com/p/regex-is-almost-all-you-need).


```
➜  ~/code(master) gitleaks git -v

    ○
    │╲
    │ ○
    ○ ░
    ░    gitleaks


Znaleziono:   "export BUNDLE_ENTERPRISE__CONTRIBSYS__COM=cafebabe:deadbeef",
Sekret:       cafebabe:deadbeef
RuleID:       sidekiq-secret
Entropia:     2.609850
Plik:         cmd/generate/config/rules/sidekiq.go
Linia:        23
Commit:       cd5226711335c68be1e720b318b7bc3135a30eb2
Autor:        John
Email:        john@users.noreply.github.com
Data:         2022-08-03T12:31:40Z
Odcisk:       cd5226711335c68be1e720b318b7bc3135a30eb2:cmd/generate/config/rules/sidekiq.go:sidekiq-secret:23
```

## Pierwsze kroki

Gitleaks można zainstalować za pomocą Homebrew, Dockera lub Go. Gitleaks jest również dostępny w formie binarnej dla wielu popularnych platform i systemów operacyjnych na [stronie wydań](https://github.com/gitleaks/gitleaks/releases). Dodatkowo, Gitleaks może być zaimplementowany jako hook pre-commit bezpośrednio w twoim repozytorium lub jako GitHub Action przy użyciu [Gitleaks-Action](https://github.com/gitleaks/gitleaks-action).

### Instalacja

```bash
# MacOS
brew install gitleaks

# Docker (DockerHub)
docker pull zricethezav/gitleaks:latest
docker run -v ${path_to_host_folder_to_scan}:/path zricethezav/gitleaks:latest [COMMAND] [OPTIONS] [SOURCE_PATH]

# Docker (ghcr.io)
docker pull ghcr.io/gitleaks/gitleaks:latest
docker run -v ${path_to_host_folder_to_scan}:/path ghcr.io/gitleaks/gitleaks:latest [COMMAND] [OPTIONS] [SOURCE_PATH]

# Ze źródła (upewnij się, że masz zainstalowane `go`)
git clone https://github.com/gitleaks/gitleaks.git
cd gitleaks
make build
```

### GitHub Action

Sprawdź oficjalny [Gitleaks GitHub Action](https://github.com/gitleaks/gitleaks-action)

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
          GITLEAKS_LICENSE: ${{ secrets.GITLEAKS_LICENSE}} # Wymagane tylko dla organizacji, nie kont osobistych.
```

### Pre-Commit

1. Zainstaluj pre-commit ze strony https://pre-commit.com/#install
2. Utwórz plik `.pre-commit-config.yaml` w katalogu głównym swojego repozytorium o następującej treści:

   ```
   repos:
     - repo: https://github.com/gitleaks/gitleaks
       rev: v8.24.2
       hooks:
         - id: gitleaks
   ```

   dla [natywnego uruchomienia gitleaks](https://github.com/gitleaks/gitleaks/releases) lub użyj [`gitleaks-docker` pre-commit ID](https://raw.githubusercontent.com/gitleaks/gitleaks/master/.pre-commit-hooks.yaml) aby uruchomić gitleaks używając [oficjalnych obrazów Dockera](#docker)

3. Zaktualizuj automatycznie konfigurację do najnowszych wersji repozytoriów wykonując `pre-commit autoupdate`
4. Zainstaluj przez `pre-commit install`
5. Teraz wszystko jest gotowe!

```
➜ git commit -m "this commit contains a secret"
Detect hardcoded secrets.................................................Failed
```

Uwaga: aby wyłączyć hook pre-commit gitleaks możesz poprzedzić polecenie commita zmienną `SKIP=gitleaks`,
co spowoduje pominięcie uruchamiania gitleaks

```
➜ SKIP=gitleaks git commit -m "skip gitleaks check"
Detect hardcoded secrets................................................Skipped
```

## Użycie

```
Użycie:
  gitleaks [komenda]

Dostępne komendy:
  dir         skanuj katalogi lub pliki w poszukiwaniu sekretów
  git         skanuj repozytoria git w poszukiwaniu sekretów
  help        Pomoc dotycząca dowolnej komendy
  stdin       wykryj sekrety z stdin
  version     wyświetl wersję gitleaks

Flagi:
  -b, --baseline-path string          ścieżka do baseline z problemami, które można zignorować
  -c, --config string                 ścieżka do pliku konfiguracyjnego
                                      kolejność priorytetów:
                                      1. --config/-c
                                      2. zmienna środowiskowa GITLEAKS_CONFIG
                                      3. zmienna środowiskowa GITLEAKS_CONFIG_TOML z zawartością pliku
                                      4. (ścieżka docelowa)/.gitleaks.toml
                                      Jeśli żadna z tych opcji nie zostanie użyta, gitleaks użyje domyślnej konfiguracji
      --diagnostics string            włącz diagnostykę (lista rozdzielona przecinkami: cpu,mem,trace). cpu=profilowanie CPU, mem=profilowanie pamięci, trace=śledzenie wykonania
      --diagnostics-dir string        katalog do przechowywania plików wyjściowych diagnostyki (domyślnie bieżący katalog)
      --enable-rule strings           włącz tylko określone reguły według id
      --exit-code int                 kod wyjścia, gdy wykryto wycieki (domyślnie 1)
  -i, --gitleaks-ignore-path string   ścieżka do pliku .gitleaksignore lub folderu go zawierającego (domyślnie ".")
  -h, --help                          pomoc dla gitleaks
      --ignore-gitleaks-allow         ignoruj komentarze gitleaks:allow
  -l, --log-level string              poziom logowania (trace, debug, info, warn, error, fatal) (domyślnie "info")
      --max-decode-depth int          pozwól na rekurencyjne dekodowanie do tej głębokości (domyślnie "0", brak dekodowania)
      --max-archive-depth int         pozwól na skanowanie zagnieżdżonych archiwów do tej głębokości (domyślnie "0", brak przechodzenia przez archiwa)
      --max-target-megabytes int      pliki większe niż ta wartość zostaną pominięte
      --no-banner                     ukryj baner
      --no-color                      wyłącz kolory w szczegółowym wyjściu
      --redact uint[=100]             zamazuj sekrety w logach i stdout. Aby zamazać tylko część sekretu, ustaw procent od 0..100. Na przykład --redact=20 (domyślnie 100%)
  -f, --report-format string          format wyjścia (json, csv, junit, sarif, template)
  -r, --report-path string            plik raportu
      --report-template string        plik szablonu używany do generowania raportu (implikuje --report-format=template)
  -v, --verbose                       pokaż szczegółowe wyjście ze skanowania
      --version                       wersja gitleaks

Użyj "gitleaks [komenda] --help", aby uzyskać więcej informacji o komendzie.
```

### Komendy

⚠️ Wersja v8.19.0 wprowadziła zmianę, która zdeprecjonowała `detect` i `protect`. Te komendy są nadal dostępne, ale
ukryte w menu `--help`. Zajrzyj do [tego gista](https://gist.github.com/zricethezav/b325bb93ebf41b9c0b0507acf12810d2) dla łatwych tłumaczeń komend.
Jeśli uważasz, że v8.19.0 zepsuł istniejącą komendę (`detect`/`protect`), otwórz zgłoszenie.

Są trzy tryby skanowania: `git`, `dir` i `stdin`.

#### Git

Komenda `git` pozwala skanować lokalne repozytoria git. Pod spodem, gitleaks używa polecenia `git log -p` do skanowania patchy.
Możesz skonfigurować zachowanie `git log -p` za pomocą opcji `log-opts`.
Na przykład, jeśli chcesz uruchomić gitleaks na zakresie commitów, możesz użyć następującego
polecenia: `gitleaks git -v --log-opts="--all commitA..commitB" path_to_repo`. Zobacz dokumentację [git log](https://git-scm.com/docs/git-log) po więcej informacji.
Jeśli nie podano docelowej ścieżki jako argumentu pozycyjnego, gitleaks spróbuje zeskanować bieżący katalog roboczy jako repozytorium git.
#### Dir

Polecenie `dir` (aliasy to `files`, `directory`) umożliwia skanowanie katalogów i plików. Przykład: `gitleaks dir -v ścieżka_do_katalogu_lub_pliku`.
Jeśli nie zostanie określony żaden cel jako argument pozycyjny, gitleaks przeskanuje bieżący katalog roboczy.

#### Stdin

Możesz również przesyłać dane do gitleaks za pomocą polecenia `stdin`. Przykład: `cat jakiś_plik | gitleaks -v stdin`

### Tworzenie bazy odniesienia (baseline)

Podczas skanowania dużych repozytoriów lub repozytoriów z długą historią, wygodne może być użycie bazy odniesienia. Podczas korzystania z bazy odniesienia,
gitleaks zignoruje wszelkie stare wykrycia, które są obecne w bazie odniesienia. Bazą odniesienia może być dowolny raport gitleaks. Aby utworzyć raport gitleaks, uruchom gitleaks z parametrem `--report-path`.

```
gitleaks git --report-path gitleaks-report.json # To zapisze raport w pliku o nazwie gitleaks-report.json
```

Po utworzeniu bazy odniesienia można ją zastosować podczas ponownego uruchamiania polecenia detect:

```
gitleaks git --baseline-path gitleaks-report.json --report-path findings.json
```

Po uruchomieniu polecenia detect z parametrem --baseline-path, raport wyjściowy (findings.json) będzie zawierał tylko nowe problemy.

## Hook Pre-Commit

Możesz uruchomić Gitleaks jako hook pre-commit, kopiując przykładowy skrypt `pre-commit.py` do katalogu
`.git/hooks/` w swoim repozytorium.

## Wczytywanie konfiguracji

Kolejność priorytetu jest następująca:

1. Opcja `--config/-c`:
      ```bash
      gitleaks git --config /home/dev/customgitleaks.toml .
      ```
2. Zmienna środowiskowa `GITLEAKS_CONFIG` ze ścieżką do pliku:
      ```bash
      export GITLEAKS_CONFIG="/home/dev/customgitleaks.toml"
      gitleaks git .
      ```
3. Zmienna środowiskowa `GITLEAKS_CONFIG_TOML` z zawartością pliku:
      ```bash
      export GITLEAKS_CONFIG_TOML=`cat customgitleaks.toml`
      gitleaks git .
      ```
4. Plik `.gitleaks.toml` w katalogu docelowym:
      ```bash
      gitleaks git .
      ```

Jeśli żadna z czterech opcji nie zostanie użyta, gitleaks użyje domyślnej konfiguracji.

## Konfiguracja

Gitleaks oferuje format konfiguracji, który możesz wykorzystać do napisania własnych reguł wykrywania sekretów:

```toml
# Tytuł pliku konfiguracyjnego gitleaks.
title = "Niestandardowa konfiguracja Gitleaks"

# Masz zasadniczo dwie opcje dla swojej niestandardowej konfiguracji:
#
# 1. zdefiniuj własną konfigurację, domyślne reguły nie będą stosowane
#
#    użyj np. domyślnej konfiguracji jako punktu wyjścia:
#    https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml
#
# 2. rozszerz konfigurację, reguły są nadpisywane lub rozszerzane
#
#    Gdy rozszerzysz konfigurację, rozszerzone reguły mają pierwszeństwo przed
#    domyślnymi regułami. Tzn. jeśli istnieją duplikaty reguł zarówno w rozszerzonej
#    konfiguracji, jak i domyślnej, rozszerzone reguły lub ich atrybuty nadpiszą domyślne reguły.
#    Kolejną rzeczą, którą warto wiedzieć, jest to, że można łączyć
#    wiele plików konfiguracyjnych do głębokości 2. Tablice allowlist są
#    dołączane i mogą zawierać duplikaty.

# useDefault i path NIE mogą być używane jednocześnie. Wybierz jedną opcję.
[extend]
# useDefault rozszerzy domyślną konfigurację gitleaks wbudowaną w binarkę
# najnowsza wersja znajduje się pod adresem:
# https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml
useDefault = true
# lub możesz podać ścieżkę do konfiguracji, którą chcesz rozszerzyć.
# Ścieżka jest względna względem miejsca wywołania gitleaks,
# a nie lokalizacji konfiguracji bazowej.
# path = "common_config.toml"
# Jeśli są jakieś reguły, których nie chcesz dziedziczyć, możesz je tutaj określić.
disabledRules = [ "generic-api-key"]

# Tablica tabel zawierających informacje definiujące instrukcje
# jak wykrywać sekrety
[[rules]]
# Unikalny identyfikator tej reguły
id = "awesome-rule-1"

# Krótki, czytelny opis reguły.
description = "awesome rule 1"

# Wyrażenie regularne Golang służące do wykrywania sekretów. Uwaga: silnik regex Golang
# nie obsługuje lookaheadów.
regex = '''one-go-style-regex-for-this-rule'''

# Liczba całkowita używana do wyodrębnienia sekretu z dopasowania regex i używana jako grupa, która będzie
# miała sprawdzaną entropię, jeśli ustawiono `entropy`.
secretGroup = 3

# Liczba zmiennoprzecinkowa reprezentująca minimalną entropię shannona, jaką grupa regex musi mieć, aby została uznana za sekret.
entropy = 3.5

# Wyrażenie regularne Golang używane do dopasowywania ścieżek. Może być użyte jako samodzielna reguła lub w połączeniu
# z prawidłową definicją `regex`.
path = '''a-file-path-regex'''

# Słowa kluczowe są używane do filtrowania przed sprawdzeniem regex. Reguły zawierające
# słowa kluczowe wykonają szybkie porównanie ciągów, aby upewnić się, że
# słowo(a) kluczowe są obecne w skanowanej treści. Najlepiej, aby te wartości były
# częścią identyfikatora lub unikalnymi ciągami specyficznymi dla regex danej reguły
# (wprowadzone w v8.6.0)
keywords = [
  "auth",
  "password",
  "token",
]

# Tablica ciągów używana do celów metadanych i raportowania.
tags = ["tag","another tag"]

    # ⚠️ W wersji v8.21.0 `[rules.allowlist]` zostało zastąpione przez `[[rules.allowlists]]`.
    # Ta zmiana jest kompatybilna wstecznie: instancje `[rules.allowlist]` nadal działają.
    #
    # Możesz zdefiniować wiele allowlist dla reguły, aby zredukować liczbę fałszywych trafień.
    # Wykrycie zostanie zignorowane, jeśli _KTÓRAKOLWIEK_ z `[[rules.allowlists]]` pasuje.
    [[rules.allowlists]]
    description = "ignore commit A"
    # Gdy zdefiniowanych jest wiele kryteriów, domyślny warunek to "OR".
    # np. to może dopasowywać na |commits| LUB |paths| LUB |stopwords|.
    condition = "OR"
    commits = [ "commit-A", "commit-B"]
    paths = [
      '''go\.mod''',
      '''go\.sum'''
    ]
    # uwaga: stopwords dotyczy wyodrębnionego sekretu, a nie całego dopasowania regex
    # jak 'regexes'. (stopwords wprowadzone w 8.8.0)
    stopwords = [
      '''client''',
      '''endpoint''',
    ]

    [[rules.allowlists]]
    # Warunek "AND" można użyć, aby upewnić się, że wszystkie kryteria pasują.
    # np. to dopasowuje, jeśli |regexes| ORAZ |paths| zostaną spełnione.
    condition = "AND"
    # uwaga: |regexes| domyślnie sprawdza _Secret_ w wykryciu.
    # Akceptowalne wartości dla |regexTarget| to "secret" (domyślnie), "match" i "line".
    regexTarget = "match"
    regexes = [ '''(?i)parseur[il]''' ]
    paths = [ '''package-lock\.json''' ]

# Możesz rozszerzyć konkretną regułę z domyślnej konfiguracji, np. gitlab-pat
# jeśli zdefiniowałeś niestandardowy prefiks tokena w swojej instancji GitLab
[[rules]]
id = "gitlab-pat"
# wszystkie inne atrybuty z domyślnej reguły są dziedziczone

    [[rules.allowlists]]
    regexTarget = "line"
    regexes = [ '''MY-glpat-''' ]


# ⚠️ W wersji v8.25.0 `[allowlist]` zostało zastąpione przez `[[allowlists]]`.
#
# Globalne allowlisty mają wyższy priorytet niż allowlisty przypisane do reguł.
# Jeśli napotkany zostanie commit wymieniony w polu `commits` poniżej, ten commit zostanie pominięty i żadne
# sekrety nie zostaną wykryte dla tego commita. Ta sama logika dotyczy regexes i paths.
[[allowlists]]
description = "global allow list"
commits = [ "commit-A", "commit-B", "commit-C"]
paths = [
  '''gitleaks\.toml''',
  '''(.*?)(jpg|gif|doc)'''
]
# uwaga: (globalny) regexTarget domyślnie sprawdza _Secret_ w wykryciu.
# Akceptowalne wartości dla regexTarget to "match" i "line"
regexTarget = "match"
regexes = [
  '''219-09-9999''',
  '''078-05-1120''',
  '''(9[0-9]{2}|666)-\d{2}-\d{4}''',
]
# uwaga: stopwords dotyczy wyodrębnionego sekretu, a nie całego dopasowania regex
# jak 'regexes'. (stopwords wprowadzone w 8.8.0)
stopwords = [
  '''client''',
  '''endpoint''',
]

# ⚠️ W wersji v8.25.0, `[[allowlists]]` mają nowe pole o nazwie |targetRules|.
#
# Wspólne listy dozwolonych można zdefiniować raz i przypisać do wielu reguł za pomocą |targetRules|.
# Będą one działać tylko na określonych regułach, a nie globalnie.
[[allowlists]]
targetRules = ["awesome-rule-1", "awesome-rule-2"]
description = "Nasze zasoby testowe wywołują fałszywe alarmy w kilku regułach."
paths = ['''tests/expected/._\.json$''']
```

Zobacz domyślną [konfigurację gitleaks](https://raw.githubusercontent.com/gitleaks/gitleaks/master/config/gitleaks.toml) jako przykład lub zapoznaj się z [wytycznymi dla współtwórców](https://raw.githubusercontent.com/gitleaks/gitleaks/master/CONTRIBUTING.md) jeśli chcesz dołożyć się do domyślnej konfiguracji. Dodatkowo możesz zobaczyć [ten wpis na blogu gitleaks](https://blog.gitleaks.io/stop-leaking-secrets-configuration-2-3-aeed293b1fbf), który opisuje zaawansowane konfiguracje.

### Dodatkowa konfiguracja

#### gitleaks:allow

Jeśli świadomie zatwierdzasz testowy sekret, który zostanie wykryty przez gitleaks, możesz dodać komentarz `gitleaks:allow` do tej linii, co spowoduje, że gitleaks zignoruje ten sekret. Przykład:

```
class CustomClass:
    discord_client_secret = '8dyfuiRyq=vVc3RRr_edRk-fK__JItpZ'  #gitleaks:allow

```

#### .gitleaksignore

Możesz ignorować konkretne znaleziska, tworząc plik `.gitleaksignore` w głównym katalogu swojego repozytorium. W wersji v8.10.0 Gitleaks dodał wartość `Fingerprint` do raportu Gitleaks. Każdy wyciek lub znalezisko ma odcisk palca, który jednoznacznie identyfikuje sekret. Dodaj ten odcisk palca do pliku `.gitleaksignore`, aby zignorować dany sekret. Zobacz [.gitleaksignore](https://raw.githubusercontent.com/gitleaks/gitleaks/master/.gitleaksignore) Gitleaks jako przykład. Uwaga: ta funkcja jest eksperymentalna i może się zmienić w przyszłości.

#### Dekodowanie

Czasami sekrety są zakodowane w sposób utrudniający ich wykrycie wyłącznie przy użyciu wyrażeń regularnych. Teraz możesz poinstruować gitleaks, aby automatycznie wyszukiwał i dekodował zakodowany tekst. Flaga `--max-decode-depth` włącza tę funkcję (domyślna wartość "0" oznacza, że funkcja jest wyłączona).

Obsługiwane jest rekursywne dekodowanie, ponieważ zdekodowany tekst może również zawierać zakodowany tekst. Flaga `--max-decode-depth` ustawia limit rekursji. Rekursja kończy się, gdy nie ma już nowych segmentów tekstu do dekodowania, więc ustawienie bardzo dużej głębokości nie oznacza, że wykona tyle przejść — wykona tylko tyle, ile potrzeba. Ogólnie rzecz biorąc, dekodowanie tylko minimalnie wydłuża czas skanowania.

Znaleziska dla zakodowanego tekstu różnią się od zwykłych znalezisk w następujący sposób:

- Lokalizacja wskazuje zakres zakodowanego tekstu
  - Jeśli reguła pasuje poza zakodowany tekst, zakres jest dostosowywany tak, aby go objąć
- Pola match i secret zawierają zdekodowaną wartość
- Dodawane są dwa tagi: `decoded:<encoding>` oraz `decode-depth:<depth>`

Aktualnie obsługiwane kodowania:

- **percent** - Dowolne drukowalne znaki ASCII zakodowane procentowo
- **hex** - Dowolne drukowalne znaki ASCII zakodowane szesnastkowo o długości co najmniej 32 znaków
- **base64** - Dowolne drukowalne znaki ASCII zakodowane base64 o długości co najmniej 16 znaków

#### Skanowanie archiwów

Czasami sekrety są umieszczane w plikach archiwów, takich jak pliki zip lub tar, co utrudnia ich wykrycie. Teraz możesz polecić gitleaks automatyczne rozpakowywanie i skanowanie zawartości archiwów. Flaga `--max-archive-depth` włącza tę funkcję zarówno dla typów skanowania `dir`, jak i `git`. Domyślna wartość "0" oznacza, że funkcja jest wyłączona.

Obsługiwane jest rekursywne skanowanie, ponieważ archiwa mogą zawierać inne archiwa. Flaga `--max-archive-depth` ustawia limit rekursji. Rekursja zatrzymuje się, gdy nie ma już nowych archiwów do rozpakowania, więc ustawienie bardzo dużej głębokości tylko umożliwia potencjalnie głębsze skanowanie. Skanowanie zostanie wykonane tylko na tyle głęboko, ile to konieczne.

Znaleziska sekretów znajdujących się w archiwum będą zawierały ścieżkę do pliku wewnątrz archiwum. Wewnętrzne ścieżki są rozdzielone znakiem `!`.

Przykład znaleziska (skrócony):

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

Oznacza to, że sekret został wykryty w linii 4 pliku `files/.env.prod.`, który znajduje się w `archives/files.tar`, który z kolei jest w `testdata/archives/nested.tar.gz`.

Aktualnie obsługiwane formaty:

Obsługiwane są [formaty kompresji](https://github.com/mholt/archives?tab=readme-ov-file#supported-compression-formats)
oraz [formaty archiwów](https://github.com/mholt/archives?tab=readme-ov-file#supported-archive-formats)
obsługiwane przez pakiet [archives](https://github.com/mholt/archives) autorstwa mholt.

#### Raportowanie

Gitleaks ma wbudowane wsparcie dla kilku formatów raportów: [`json`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/json_simple.json), [`csv`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/csv_simple.csv?plain=1), [`junit`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/junit_simple.xml) oraz [`sarif`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/sarif_simple.sarif).

Jeśli żaden z tych formatów nie spełnia Twoich potrzeb, możesz stworzyć własny format raportu za pomocą [pliku szablonu Go `text/template` .tmpl](https://www.digitalocean.com/community/tutorials/how-to-use-templates-in-go#step-4-writing-a-template) oraz flagi `--report-template`. Szablon może korzystać z [rozszerzonych funkcji z biblioteki szablonów `Masterminds/sprig`](https://masterminds.github.io/sprig/).

Na przykład, poniższy szablon zapewnia niestandardowe wyjście JSON:
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

Użycie:
```sh
$ gitleaks dir ~/leaky-repo/ --report-path "report.json" --report-format template --report-template testdata/report/jsonextra.tmpl
```

## Sponsoring

<p align="left">
	<h3><a href="https://coderabbit.ai/?utm_source=oss&utm_medium=sponsorship&utm_campaign=gitleaks">coderabbit.ai</h3>
	  <a href="https://coderabbit.ai/?utm_source=oss&utm_medium=sponsorship&utm_campaign=gitleaks">
		  <img alt="CodeRabbit.ai Sponsorship" src="https://github.com/gitleaks/gitleaks/assets/15034943/76c30a85-887b-47ca-9956-17a8e55c6c41" width=200>
	  </a>
</p>


## Kody zakończenia (Exit Codes)

Zawsze możesz ustawić kod zakończenia, gdy wykryto wycieki, za pomocą flagi --exit-code. Domyślne kody zakończenia poniżej:

```
0 - brak wycieków
1 - wykryto wycieki lub wystąpił błąd
126 - nieznana flaga
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---
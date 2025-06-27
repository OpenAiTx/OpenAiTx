
#### Dir

Het `dir`-commando (aliassen zijn onder andere `files`, `directory`) stelt je in staat om mappen en bestanden te scannen. Voorbeeld: `gitleaks dir -v pad_naar_map_of_bestand`.
Als er geen doel wordt opgegeven als positioneel argument, zal gitleaks de huidige werkmap scannen.

#### Stdin

Je kunt ook data naar gitleaks streamen met het `stdin`-commando. Voorbeeld: `cat een_bestand | gitleaks -v stdin`

### Een baseline maken

Bij het scannen van grote repositories of repositories met een lange geschiedenis kan het handig zijn om een baseline te gebruiken. Bij gebruik van een baseline negeert gitleaks alle oude bevindingen die in de baseline aanwezig zijn. Een baseline kan elk gitleaks-rapport zijn. Om een gitleaks-rapport te maken, voer je gitleaks uit met de parameter `--report-path`.

```
gitleaks git --report-path gitleaks-report.json # Dit slaat het rapport op in een bestand genaamd gitleaks-report.json
```

Zodra een baseline is aangemaakt, kan deze worden toegepast bij het opnieuw uitvoeren van het detect-commando:

```
gitleaks git --baseline-path gitleaks-report.json --report-path findings.json
```

Na het uitvoeren van het detect-commando met de --baseline-path-parameter bevat de rapportoutput (findings.json) alleen nieuwe issues.

## Pre-Commit hook

Je kunt Gitleaks als een pre-commit hook draaien door het voorbeeldscript `pre-commit.py` te kopiëren naar je `.git/hooks/`-map.

## Configuratie laden

De volgorde van prioriteit is:

1. `--config/-c` optie:
      ```bash
      gitleaks git --config /home/dev/customgitleaks.toml .
      ```
2. Omgevingsvariabele `GITLEAKS_CONFIG` met het bestandspad:
      ```bash
      export GITLEAKS_CONFIG="/home/dev/customgitleaks.toml"
      gitleaks git .
      ```
3. Omgevingsvariabele `GITLEAKS_CONFIG_TOML` met de inhoud van het bestand:
      ```bash
      export GITLEAKS_CONFIG_TOML=`cat customgitleaks.toml`
      gitleaks git .
      ```
4. Een `.gitleaks.toml`-bestand binnen het doelpad:
      ```bash
      gitleaks git .
      ```

Als geen van de vier opties wordt gebruikt, dan gebruikt gitleaks de standaardconfiguratie.

## Configuratie

Gitleaks biedt een configuratieformaat waarmee je je eigen detectieregels voor geheimen kunt schrijven:

```toml
# Titel voor het gitleaks-configuratiebestand.
title = "Aangepaste Gitleaks-configuratie"

# Je hebt in principe twee opties voor je aangepaste configuratie:
#
# 1. Definieer je eigen configuratie, standaardregels zijn niet van toepassing
#
#    Gebruik bijvoorbeeld de standaardconfiguratie als startpunt:
#    https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml
#
# 2. Breid een configuratie uit, de regels worden overschreven of uitgebreid
#
#    Als je een configuratie uitbreidt, krijgen de uitgebreide regels voorrang op de
#    standaardregels. Dus als er dubbele regels zijn in zowel de uitgebreide
#    configuratie als de standaardconfiguratie, zullen de uitgebreide regels of
#    attributen daarvan de standaardregels overschrijven.
#    Een ander punt bij het uitbreiden van configuraties is dat je meerdere
#    configuratiebestanden aan elkaar kunt koppelen tot een diepte van 2. Allowlist-arrays worden
#    samengevoegd en kunnen duplicaten bevatten.

# useDefault en path kunnen NIET tegelijkertijd gebruikt worden. Kies er één.
[extend]
# useDefault zal de standaard gitleaks-configuratie uitbreiden die in de binary is ingebouwd
# De laatste versie is te vinden op:
# https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml
useDefault = true
# of je kunt een pad opgeven naar een configuratie om van uit te breiden.
# Het pad is relatief ten opzichte van waar gitleaks is aangeroepen,
# niet de locatie van de basisconfiguratie.
# path = "common_config.toml"
# Als er regels zijn die je niet wilt overnemen, kun je die hier opgeven.
disabledRules = [ "generic-api-key"]

# Een array van tabellen met informatie die instructies definieert
# over hoe geheimen gedetecteerd moeten worden
[[rules]]
# Unieke identifier voor deze regel
id = "awesome-rule-1"

# Korte, leesbare beschrijving van de regel.
description = "awesome rule 1"

# Golang-reguliere expressie gebruikt om geheimen te detecteren. Let op: Golang's regex-engine
# ondersteunt geen lookaheads.
regex = '''one-go-style-regex-for-this-rule'''

# Int gebruikt om het geheim uit de regex-match te halen en gebruikt als de groep waarvan
# de entropie wordt gecontroleerd als `entropy` is ingesteld.
secretGroup = 3

# Float die de minimale Shannon-entropie vertegenwoordigt die een regex-groep moet hebben om als geheim te worden beschouwd.
entropy = 3.5

# Golang-reguliere expressie gebruikt om paden te matchen. Dit kan gebruikt worden als een op zichzelf staande regel of in combinatie
# met een geldige `regex`-invoer.
path = '''a-file-path-regex'''

# Trefwoorden worden gebruikt voor filtering voorafgaand aan de regex-controle. Regels die
# trefwoorden bevatten, voeren een snelle stringvergelijking uit om te controleren of het
# trefwoord/de trefwoorden in de inhoud staan die wordt gescand. Idealiter moeten deze waarden
# deel uitmaken van de identifier of unieke strings die specifiek zijn voor de regex van de regel
# (geïntroduceerd in v8.6.0)
keywords = [
  "auth",
  "password",
  "token",
]

# Array van strings gebruikt voor metadata en rapportagedoeleinden.
tags = ["tag","another tag"]

    # ⚠️ In v8.21.0 werd `[rules.allowlist]` vervangen door `[[rules.allowlists]]`.
    # Deze wijziging was achterwaarts compatibel: instanties van `[rules.allowlist]` werken nog steeds.
    #
    # Je kunt meerdere allowlists voor een regel definiëren om false positives te verminderen.
    # Een bevinding wordt genegeerd als _ÉÉN_ van de `[[rules.allowlists]]` overeenkomt.
    [[rules.allowlists]]
    description = "commit A negeren"
    # Wanneer meerdere criteria zijn gedefinieerd, is de standaardvoorwaarde "OF".
    # Bijvoorbeeld, dit kan overeenkomen met |commits| OF |paths| OF |stopwords|.
    condition = "OR"
    commits = [ "commit-A", "commit-B"]
    paths = [
      '''go\.mod''',
      '''go\.sum'''
    ]
    # Let op: stopwords richten zich op het geëxtraheerde geheim, niet op de gehele regex-match
    # zoals 'regexes' doet. (stopwords geïntroduceerd in 8.8.0)
    stopwords = [
      '''client''',
      '''endpoint''',
    ]

    [[rules.allowlists]]
    # De "EN"-voorwaarde kan worden gebruikt om ervoor te zorgen dat alle criteria overeenkomen.
    # Bijvoorbeeld, dit komt overeen als |regexes| EN |paths| voldoen.
    condition = "AND"
    # Let op: |regexes| controleert standaard het _Secret_ in de bevinding.
    # Toegestane waarden voor |regexTarget| zijn "secret" (standaard), "match" en "line".
    regexTarget = "match"
    regexes = [ '''(?i)parseur[il]''' ]
    paths = [ '''package-lock\.json''' ]

# Je kunt een specifieke regel uit de standaardconfiguratie uitbreiden, bijvoorbeeld gitlab-pat
# als je een aangepast tokenvoorvoegsel hebt ingesteld op je GitLab-instantie
[[rules]]
id = "gitlab-pat"
# alle andere attributen uit de standaardregel worden overgenomen

    [[rules.allowlists]]
    regexTarget = "line"
    regexes = [ '''MY-glpat-''' ]


# ⚠️ In v8.25.0 werd `[allowlist]` vervangen door `[[allowlists]]`.
#
# Globale allowlists hebben een hogere prioriteit dan regel-specifieke allowlists.
# Als een commit in het onderstaande `commits`-veld voorkomt, wordt die commit overgeslagen en worden er geen
# geheimen gedetecteerd voor die commit. Dezelfde logica geldt voor regexes en paths.
[[allowlists]]
description = "globale allow list"
commits = [ "commit-A", "commit-B", "commit-C"]
paths = [
  '''gitleaks\.toml''',
  '''(.*?)(jpg|gif|doc)'''
]
# Let op: (globale) regexTarget controleert standaard het _Secret_ in de bevinding.
# Toegestane waarden voor regexTarget zijn "match" en "line"
regexTarget = "match"
regexes = [
  '''219-09-9999''',
  '''078-05-1120''',
  '''(9[0-9]{2}|666)-\d{2}-\d{4}''',
]
# Let op: stopwords richten zich op het geëxtraheerde geheim, niet op de gehele regex-match
# zoals 'regexes' doet. (stopwords geïntroduceerd in 8.8.0)
stopwords = [
  '''client''',
'''endpoint''',
]

# ⚠️ In v8.25.0 heeft `[[allowlists]]` een nieuw veld genaamd |targetRules|.
#
# Algemene allowlists kunnen één keer worden gedefinieerd en aan meerdere regels worden toegewezen met |targetRules|.
# Dit wordt alleen uitgevoerd op de opgegeven regels, niet globaal.
[[allowlists]]
targetRules = ["awesome-rule-1", "awesome-rule-2"]
description = "Onze testassets veroorzaken false-positives bij enkele regels."
paths = ['''tests/expected/._\.json$''']
```

Bekijk de standaard [gitleaks config](https://raw.githubusercontent.com/gitleaks/gitleaks/master/config/gitleaks.toml) voor voorbeelden of volg de [contributierichtlijnen](https://raw.githubusercontent.com/gitleaks/gitleaks/master/CONTRIBUTING.md) als je wilt bijdragen aan de standaardconfiguratie. Je kunt ook [deze gitleaks blogpost](https://blog.gitleaks.io/stop-leaking-secrets-configuration-2-3-aeed293b1fbf) raadplegen voor geavanceerde configuratie-opties.

### Aanvullende Configuratie

#### gitleaks:allow

Als je bewust een testgeheim toevoegt waarvan je weet dat gitleaks deze zal detecteren, kun je een `gitleaks:allow` commentaar toevoegen aan die regel. Dit instrueert gitleaks om dat geheim te negeren. Bijvoorbeeld:

```
class CustomClass:
    discord_client_secret = '8dyfuiRyq=vVc3RRr_edRk-fK__JItpZ'  #gitleaks:allow

```

#### .gitleaksignore

Je kunt specifieke bevindingen negeren door een `.gitleaksignore`-bestand aan te maken in de root van je repo. In release v8.10.0 heeft Gitleaks een `Fingerprint`-waarde toegevoegd aan het Gitleaks-rapport. Elk lek of bevinding heeft een vingerafdruk die een geheim uniek identificeert. Voeg deze vingerafdruk toe aan het `.gitleaksignore`-bestand om dat specifieke geheim te negeren. Zie Gitleaks' [.gitleaksignore](https://raw.githubusercontent.com/gitleaks/gitleaks/master/.gitleaksignore) voor een voorbeeld. Let op: deze functie is experimenteel en kan in de toekomst veranderen.

#### Decodering

Soms zijn geheimen gecodeerd op een manier die het moeilijk maakt ze te vinden met alleen regex. Je kunt gitleaks nu automatisch gecodeerde tekst laten vinden en decoderen. De vlag `--max-decode-depth` activeert deze functie (de standaardwaarde "0" betekent dat deze standaard is uitgeschakeld).

Recursieve decodering wordt ondersteund, omdat gedecodeerde tekst ook weer gecodeerde tekst kan bevatten. De vlag `--max-decode-depth` stelt de limiet voor recursie in. Recursie stopt wanneer er geen nieuwe segmenten gecodeerde tekst meer zijn om te decoderen, dus een hele hoge max diepte instellen betekent niet dat het altijd zoveel keer decodeert. Er wordt alleen zo vaak gedecodeerd als nodig is. Over het algemeen zorgt decoderen slechts voor minimale extra scantijd.

De bevindingen voor gecodeerde tekst verschillen van normale bevindingen op de volgende manieren:

- De locatie wijst naar de grenzen van de gecodeerde tekst
  - Als de regel buiten de gecodeerde tekst matcht, worden de grenzen aangepast om dat ook op te nemen
- De match en het geheim bevatten de gedecodeerde waarde
- Twee tags worden toegevoegd: `decoded:<encoding>` en `decode-depth:<depth>`

Momenteel ondersteunde coderingen:

- **percent** - Alle afdrukbare ASCII percent-gecodeerde waarden
- **hex** - Alle afdrukbare ASCII hex-gecodeerde waarden ≥ 32 tekens
- **base64** - Alle afdrukbare ASCII base64-gecodeerde waarden ≥ 16 tekens

#### Archief Scannen

Soms zijn geheimen verpakt in archiefbestanden zoals zipbestanden of tarballs, waardoor ze moeilijk te vinden zijn. Je kunt gitleaks nu automatisch de inhoud van archieven laten uitpakken en scannen. De vlag `--max-archive-depth` activeert deze functie voor zowel `dir` als `git` scantypes. De standaardwaarde "0" betekent dat deze functie standaard is uitgeschakeld.

Recursief scannen wordt ondersteund, omdat archieven andere archieven kunnen bevatten. De vlag `--max-archive-depth` stelt de limiet voor recursie in. Recursie stopt wanneer er geen nieuwe archieven meer zijn om uit te pakken, dus een hoge max diepte instellen betekent alleen dat het zo diep kan gaan. Er wordt alleen zo diep gegaan als nodig is.

De bevindingen voor geheimen die binnen een archief zijn gevonden, bevatten het pad naar het bestand binnen het archief. Interne paden worden gescheiden met `!`.

Voorbeeld van een bevinding (ingekort):

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

Dit betekent dat een geheim is gedetecteerd op regel 4 van `files/.env.prod.` dat zich bevindt in `archives/files.tar` dat weer in `testdata/archives/nested.tar.gz` zit.

Momenteel ondersteunde formaten:

De [compressie](https://github.com/mholt/archives?tab=readme-ov-file#supported-compression-formats)
en [archief](https://github.com/mholt/archives?tab=readme-ov-file#supported-archive-formats)
formaten die worden ondersteund door mholt's [archives package](https://github.com/mholt/archives)
worden ondersteund.

#### Rapportage

Gitleaks heeft ingebouwde ondersteuning voor verschillende rapportformaten: [`json`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/json_simple.json), [`csv`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/csv_simple.csv?plain=1), [`junit`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/junit_simple.xml), en [`sarif`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/sarif_simple.sarif).

Als geen van deze formaten voldoet aan je wensen, kun je je eigen rapportformaat maken met een [Go `text/template` .tmpl-bestand](https://www.digitalocean.com/community/tutorials/how-to-use-templates-in-go#step-4-writing-a-template) en de `--report-template` vlag. De template kan gebruik maken van [uitgebreide functionaliteit uit de `Masterminds/sprig` template-bibliotheek](https://masterminds.github.io/sprig/).

Bijvoorbeeld, de volgende template biedt een aangepaste JSON-uitvoer:
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

Gebruik:
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


## Exit Codes

Je kunt altijd de exit code instellen wanneer lekken worden aangetroffen met de --exit-code vlag. Standaard exit codes hieronder:

```
0 - geen lekken aanwezig
1 - lekken of fout aangetroffen
126 - onbekende vlag
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---
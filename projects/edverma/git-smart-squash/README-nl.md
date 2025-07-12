# Git Smart Squash

Verspil geen tijd meer met het handmatig herschikken van commits. Laat AI het voor je doen.

## Het Probleem

Je kent het wel: 15 commits voor een feature, waarvan de helft "fix", "typo" of "WIP" is. Nu moet je alles opschonen voor een PR-review. Handmatig squashen en herschrijven is tijdrovend.

## De Oplossing

Git Smart Squash analyseert je wijzigingen en organiseert ze in logische commits met duidelijke berichten:

```bash
# Voor: je rommelige branch
* fix tests
* typo  
* more auth changes
* WIP: working on auth
* update tests
* initial auth implementation

# Na: schone, logische commits
* feat: implementeer JWT-authenticatiesysteem
* test: voeg dekking toe voor auth-endpoint
```

## Snelstart

### 1. Installeren

```bash
# Met pip
pip install git-smart-squash

# Met pipx (aanbevolen voor geïsoleerde installatie)
pipx install git-smart-squash

# Met uv (snelle Python package manager)
uv tool install git-smart-squash
```
### 2. AI instellen

**Optie A: Lokale (Gratis, Privé)**
```bash
# Installeer Ollama van https://ollama.com
ollama pull devstral  # Standaardmodel
```

**Optie B: Cloud (Betere resultaten)**
```bash
export OPENAI_API_KEY="jouw-sleutel"
export ANTHROPIC_API_KEY="jouw-sleutel"
export GEMINI_API_KEY="jouw-sleutel"
```

### 3. Uitvoeren

```bash
cd jouw-repo
git-smart-squash
```
Dat is alles. Bekijk het plan en keur het goed.

## Commandoregelparameters

| Parameter         | Beschrijving                                           | Standaard                           |
|-------------------|-------------------------------------------------------|-------------------------------------|
| `--base`          | Basisbranch om mee te vergelijken                     | Configuratiebestand of `main`       |
| `--ai-provider`   | Te gebruiken AI-provider (openai, anthropic, local, gemini) | Geconfigureerd in instellingen      |
| `--model`         | Specifiek AI-model om te gebruiken (zie aanbevolen modellen hieronder) | Standaard van provider              |
| `--config`        | Pad naar aangepast configuratiebestand                | `.git-smart-squash.yml` of `~/.git-smart-squash.yml` |
| `--auto-apply`    | Pas het commitplan toe zonder bevestigingsprompt      | `false`                             |
| `--instructions`, `-i` | Aangepaste instructies voor AI (bijv. "Groeperen op featuregebied") | Geen                                |
| `--no-attribution`| Schakel attributiebericht in commits uit              | `false`                             |
| `--debug`         | Schakel debuglogboek voor gedetailleerde informatie in| `false`                             |

## Aanbevolen Modellen

### Standaardmodellen
- **OpenAI**: `gpt-4.1` (standaard)
- **Anthropic**: `claude-sonnet-4-20250514` (standaard)
- **Gemini**: `gemini-2.5-pro` (standaard)
- **Local/Ollama**: `devstral` (standaard)
### Modelselectie
```bash
# Specificeer een ander model
git-smart-squash --ai-provider openai --model gpt-4.1-mini

# Voor lokale Ollama
git-smart-squash --ai-provider local --model llama-3.1
```

## Aangepaste instructies

De parameter `--instructions` laat je bepalen hoe commits worden georganiseerd:

### Voorbeelden
```bash
# Voeg ticketprefixen toe
git-smart-squash -i "Voorzie alle commits van de prefix [ABC-1234]"

# Scheiden op type
git-smart-squash -i "Houd backend- en frontend-wijzigingen in aparte commits"
```
# Beperk het aantal commits
git-smart-squash -i "Maak in totaal maximaal 3 commits aan"
```

### Tips voor Betere Resultaten
- **Wees specifiek**: "Groepeer database-migraties apart" werkt beter dan "mooi organiseren"
- **Eén instructie tegelijk**: Complexe instructies met meerdere onderdelen kunnen gedeeltelijk genegeerd worden
- **Gebruik betere modellen**: Grotere modellen volgen instructies betrouwbaarder dan kleinere modellen

## Veelvoorkomende Gebruikssituaties

### "Ik moet opruimen voor een PR-review"
```bash
git-smart-squash              # Toont het plan en vraagt om bevestiging
git-smart-squash --auto-apply # Past automatisch toe zonder te vragen
```

### "Ik werk met een andere hoofdbranch"
```bash
git-smart-squash --base develop
```
### "Ik wil een specifieke AI-provider gebruiken"
```bash
git-smart-squash --ai-provider openai
```

## Veiligheid

**Je code is veilig:**
- Toont het plan voordat er wijzigingen worden aangebracht
- Maakt automatisch een back-up branch aan
- Vereist een schone werkdirectory
- Nooit pushen zonder jouw opdracht

**Als er iets misgaat:**
```bash
# Vind back-up
git branch | grep backup

# Herstel
git reset --hard your-branch-backup-[timestamp]
```

## AI-aanbieders

| Aanbieder   | Kosten | Privacy |
|-------------|--------|---------|
| **Ollama**  | Gratis | Lokaal  |
| **OpenAI**  | ~$0,01 | Cloud   |
| **Anthropic** | ~$0,01 | Cloud   |
| **Gemini**  | ~$0,01 | Cloud   |

## Geavanceerde configuratie (optioneel)

Wil je aanpassen? Maak een configuratiebestand aan:

**Project-specifiek** (`.git-smart-squash.yml` in je repo):
```yaml
ai:
  provider: openai  # Gebruik OpenAI voor dit project
base: develop       # Gebruik develop als de basisbranch voor dit project
```
**Globale standaard** (`~/.git-smart-squash.yml`):
```yaml
ai:
  provider: local   # Gebruik standaard altijd lokale AI
base: main          # Standaard basisbranch voor alle projecten
```

## Problemen oplossen

### "Ongeldige JSON" Fout
Dit betekent meestal dat het AI-model het antwoord niet goed kon formatteren:
- **Met Ollama**: Schakel over van `llama2` naar `mistral` of `mixtral`
- **Oplossing**: `ollama pull mistral` en probeer opnieuw
- **Alternatief**: Gebruik een cloudprovider met `--ai-provider openai`

### Model Volgt Instructies Niet
Sommige modellen hebben moeite met complexe instructies:
- **Gebruik betere modellen**: `--model gpt-4-turbo` of `--model claude-3-opus`
- **Vereenvoudig instructies**: Eén duidelijke opdracht werkt beter dan meerdere
- **Wees expliciet**: "Voorzie van prefix [ABC-123]" in plaats van "voeg ticketnummer toe"
### "Ollama niet gevonden" 
```bash
# Installeren vanaf https://ollama.com
ollama serve
ollama pull devstral  # Standaardmodel
```

### Slechte Commit-Groepering
Als de AI te veel commits aanmaakt of niet goed groepeert:
- **Onvoldoende model**: Gebruik een groter model
- **Voeg instructies toe**: `-i "Groepeer gerelateerde wijzigingen, maximaal 3 commits"`
- **Geef feedback**: Maak een issue aan op GitHub en laat ons weten wat er is gebeurd

### Installatieproblemen (Mac)
Als je geen pip hebt of geïsoleerde installaties verkiest:
```bash
# Gebruik pipx (aanbevolen)
brew install pipx
pipx install git-smart-squash
```
### "Geen wijzigingen om te reorganiseren"
```bash
git log --oneline main..HEAD  # Controleer of je commits hebt
git diff main                 # Controleer of je wijzigingen hebt
```

### Grote Diffs / Tokenlimieten
Lokale modellen hebben een tokenlimiet van ongeveer 32k. Voor grote wijzigingen:
- Gebruik `--base` met een recentere commit
- Schakel over naar de cloud: `--ai-provider openai`
- Splits op in kleinere PR's

### Meer hulp nodig?

Bekijk onze [uitgebreide documentatie](https://raw.githubusercontent.com/edverma/git-smart-squash/main/DOCUMENTATION.md) of open een issue!

## Licentie

MIT-licentie - zie het [LICENSE](LICENSE)-bestand voor details.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---
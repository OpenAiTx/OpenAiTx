<!-- markdownlint-disable MD041 MD033 -->
<div align="center">
    <picture>
        <source media="(prefers-color-scheme: dark)" srcset="docs/images/typedef-fenic-logo-dark.png">
        <img src="https://raw.githubusercontent.com/typedef-ai/fenic/main/docs/images/typedef-fenic-logo.png" alt="fenic, door typedef" width="90%">
    </picture>
</div>

# fenic: de dataframe (opnieuw) gebouwd voor LLM-inferentie

[![PyPI versie](https://img.shields.io/pypi/v/fenic.svg)](https://pypi.org/project/fenic/)
[![Python versies](https://img.shields.io/pypi/pyversions/fenic.svg)](https://pypi.org/project/fenic/)
[![Licentie](https://img.shields.io/github/license/typedef-ai/fenic.svg)](https://github.com/typedef-ai/fenic/blob/main/LICENSE)
[![Discord](https://img.shields.io/discord/1381706122322513952?label=Discord&logo=discord)](https://discord.gg/GdqF3J7huR)

---

## **Documentatie**: [docs.fenic.ai](https://docs.fenic.ai/)

fenic is een eigenzinnig, door PySpark geïnspireerd DataFrame-framework van typedef.ai voor het bouwen van AI- en agent-applicaties. Transformeer ongestructureerde en gestructureerde data naar inzichten met behulp van vertrouwde DataFrame-bewerkingen, verrijkt met semantische intelligentie. Met eersteklas ondersteuning voor markdown, transcripties en semantische operatoren, plus efficiënte batch-inferentie over elke modelprovider.
## Installeren

fenic ondersteunt Python `[3.10, 3.11, 3.12]`

```bash
pip install fenic
```

### LLM Provider Setup

fenic vereist een API-sleutel van ten minste één LLM-provider. Stel de juiste omgevingsvariabele in voor de door jou gekozen provider:

```bash
# Voor OpenAI
export OPENAI_API_KEY="jouw-openai-api-sleutel"

# Voor Anthropic
export ANTHROPIC_API_KEY="jouw-anthropic-api-sleutel"

# Voor Google
export GEMINI_API_KEY="your-google-api-key"
```

## Snelstart

De snelste manier om kennis te maken met fenic is door de voorbeelden te bekijken.

Hieronder staat een korte lijst van de voorbeelden in deze repo:

| Voorbeeld                                                                | Beschrijving                                                                                                                        |
| ------------------------------------------------------------------------ | ----------------------------------------------------------------------------------------------------------------------------------- |
| [Hello World!](examples/hello_world)                                     | Introductie tot semantische extractie en classificatie met behulp van fenic's kernoperatoren via analyse van foutlogboeken.         |
| [Verrijking](examples/enrichment)                                        | Meerstaps-DataFrames met template-gebaseerde tekstanalyse, joins en LLM-aangedreven transformaties gedemonstreerd via logverrijking.|
| [Vergadertranscript Verwerking](examples/meeting_transcript_processing)  | Native transcript parsing, Pydantic schema-integratie en complexe aggregaties getoond via vergaderanalyse.                         |
| [Nieuws Analyse](examples/news_analysis)                                 | Analyseer en extraheer inzichten uit nieuwsartikelen met behulp van semantische operatoren en gestructureerde dataverwerking.       |
| [Podcast Samenvatting](examples/podcast_summarization)                   | Verwerk en vat podcasttranscripten samen met spreker-bewuste analyse en extractie van kernpunten.                                  |
| [Semantische Join](examples/semantic_joins)                              | Gebruik in plaats van eenvoudige fuzzy matching de krachtige semantische join-functionaliteit van fenic om data tussen tabellen te koppelen. |
| [Naam Entiteit Herkenning](examples/named_entity_recognition)            | Extraheer en classificeer naam-entiteiten uit tekst met behulp van semantische extractie en classificatie.                         |
| [Markdown Verwerking](examples/markdown_processing)                      | Verwerk en transformeer markdown-documenten met gestructureerde data-extractie en opmaak.                                          |
| [JSON Verwerking](examples/json_processing)                              | Behandel complexe JSON-datastructuren met semantische operaties en schema-validatie.                                               |
| [Feedback Clustering](examples/feedback_clustering)                      | Groepeer en analyseer feedback met behulp van semantische gelijkenis en clustering-operaties.                                      |
| [Document Extractie](examples/document_extraction)                       | Extraheer gestructureerde informatie uit verschillende documentformaten met behulp van semantische operatoren.                     |

(Voel je vrij om op een van de bovenstaande voorbeelden te klikken om direct naar de bijbehorende map te gaan.)

## Waarom fenic gebruiken?

fenic is een eigenzinnig, door PySpark geïnspireerd DataFrame-framework voor het bouwen van productieklare AI- en agenttoepassingen.

In tegenstelling tot traditionele datatools die zijn aangepast voor LLM's, is de query-engine van fenic vanaf de basis ontworpen met inferentie in gedachten.

Transformeer gestructureerde en ongestructureerde data naar inzichten met behulp van vertrouwde DataFrame-operaties, uitgebreid met semantische intelligentie. Met eersteklas ondersteuning voor markdown, transcripties en semantische operatoren, plus efficiënte batch-inferentie via elke modelprovider.

fenic brengt de betrouwbaarheid van traditionele datapijplijnen naar AI-workloads.

### Belangrijkste kenmerken

#### Speciaal ontwikkeld voor LLM-inferentie

- Query-engine vanaf nul ontworpen voor AI-workloads, niet aangepast
- Automatische batchoptimalisatie voor API-calls
- Ingebouwde retry-logica en snelheidsbeperking
- Token-telling en kostenregistratie

#### Semantische operatoren als volwaardige elementen
- `semantic.analyze_sentiment` - Ingebouwde sentimentanalyse
- `semantic.classify` - Categoriseer tekst met few-shot voorbeelden
- `semantic.extract` - Zet ongestructureerde tekst om in gestructureerde data met schema's
- `semantic.group_by` - Groepeer data op semantische gelijkenis
- `semantic.join` - Voeg DataFrames samen op basis van betekenis, niet alleen waarden
- `semantic.map` - Pas natuurlijke taaltransformaties toe
- `semantic.predicate` - Maak predicaten met natuurlijke taal om rijen te filteren
- `semantic.reduce` - Aggregeer gegroepeerde data met LLM-operaties

#### Native Ondersteuning voor Ongestructureerde Data

Gaat verder dan typische multimodale datatypes (audio, afbeeldingen) door gespecialiseerde types te creëren voor tekstintensieve workloads:

- Markdown-parsing en extractie als een eersteklas datatype
- Transcriptverwerking (SRT, generieke formaten) met bewustzijn van spreker en tijdstempel
- JSON-manipulatie met JQ-expressies voor geneste data
- Automatische tekstchunking met configureerbare overlap voor lange documenten

#### Productierijpe Infrastructuur
- Ondersteuning voor meerdere providers (OpenAI, Anthropic, Gemini)
- Lokale en cloud uitvoeringsbackends
- Uitgebreide foutafhandeling en logging
- Pydantic-integratie voor typeveiligheid

#### Vertrouwde DataFrame API

- PySpark-compatibele bewerkingen
- Lui evalueren en query-optimalisatie
- SQL-ondersteuning voor complexe queries
- Naadloze integratie met bestaande datastromen

### Waarom DataFrames voor LLM- en Agent-toepassingen?

AI- en agent-toepassingen zijn in wezen pipelines en workflows – precies waarvoor DataFrame-API’s zijn ontworpen. In plaats van patronen voor datatransformatie, filtering en aggregatie opnieuw uit te vinden, maakt fenic gebruik van decennia aan bewezen technische praktijken.

#### Losgekoppelde Architectuur voor Betere Agents

fenic creëert een duidelijke scheiding tussen zware inferentietaken en realtime agentinteracties. Door batchverwerking uit de agent-runtime te halen, krijg je:

- Meer voorspelbare en responsieve agents
- Betere resourcebenutting met gebatchte LLM-calls
- Duidelijkere scheiding tussen planning/orchestratie en uitvoering
#### Gemaakt voor Alle Ingenieurs

DataFrames zijn niet alleen voor dataprofessionals. Het vloeiende, samenstelbare API-ontwerp maakt het toegankelijk voor elke ingenieur:

- Koppel bewerkingen op een natuurlijke manier: `df.filter(...).semantic.group_by(...)`
- Combineer imperatieve en declaratieve stijlen naadloos
- Begin snel met bekende patronen uit pandas/PySpark of SQL

## Support

Word lid van onze community op [Discord](https://discord.gg/GdqF3J7huR) waar je in contact kunt komen met andere gebruikers, vragen kunt stellen en hulp kunt krijgen bij je fenic-projecten. Onze community verwelkomt altijd graag nieuwkomers!

Als je fenic nuttig vindt, overweeg dan om ons een ⭐ te geven bovenaan deze repository. Jouw steun helpt ons het framework voor iedereen te laten groeien en verbeteren!

## Bijdragen

We verwelkomen bijdragen van allerlei aard! Of je nu geïnteresseerd bent in het schrijven van code, het verbeteren van documentatie, het testen van functies of het voorstellen van nieuwe ideeën, jouw hulp is waardevol voor ons.

Voor ontwikkelaars die van plan zijn om codewijzigingen in te dienen, raden we aan om eerst een issue te openen om je ideeën te bespreken voordat je een Pull Request aanmaakt. Dit helpt om afstemming met de richting van het project te garanderen en dubbele inspanningen te voorkomen.

Raadpleeg onze [bijdrageregels](https://raw.githubusercontent.com/typedef-ai/fenic/main/CONTRIBUTING.md) voor gedetailleerde informatie over het ontwikkelingsproces en het opzetten van het project.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---
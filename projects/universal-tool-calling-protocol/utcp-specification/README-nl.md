# Universeel Tool Calling Protocol (UTCP) Specificatie

Deze repository bevat de officiële specificatiedocumentatie voor het Universeel Tool Calling Protocol (UTCP). UTCP is een moderne, flexibele en schaalbare standaard voor het definiëren van en communiceren met tools via verschillende communicatieprotocollen.

## Wat is UTCP?

UTCP biedt een gestandaardiseerde manier voor AI-systemen en andere clients om tools van verschillende providers te ontdekken en aan te roepen, ongeacht het onderliggende protocol (HTTP, WebSocket, CLI, enzovoort). Deze specificatie definieert:

- Mechanismen voor tool discovery
- Tool-aanroepformaten
- Providerconfiguratie
- Authenticatiemethoden
- Afhandeling van antwoorden

## Bijdragen aan de Specificatie

We verwelkomen bijdragen aan de UTCP-specificatie! Zo kun je bijdragen:

1. **Fork de repository**: Maak een eigen fork van de specificatierepository
2. **Breng je wijzigingen aan**: Werk de documentatie bij of voeg deze toe waar nodig
3. **Dien een pull request in**: Open een PR met je wijzigingen ter beoordeling
4. **Doe mee aan discussies**: Neem deel aan het gesprek over voorgestelde wijzigingen

Houd je bij het bijdragen aan deze richtlijnen:

- Zorg ervoor dat je wijzigingen aansluiten bij de algemene visie en doelen van UTCP
- Volg de bestaande documentatiestructuur en opmaak
- Voeg voorbeelden toe bij nieuwe functies of concepten
- Werk relevante secties bij om consistentie in de documentatie te behouden

## De Documentatie Lokaal Bouwen

### Vereisten

Om de documentatiewebsite lokaal te bouwen en te bekijken, heb je het volgende nodig:

- Ruby versie 2.5.0 of hoger
- RubyGems
- Bundler

### Installatie

1. Clone de repository:
   ```bash
   git clone https://github.com/universal-tool-calling-protocol/utcp-specification.git
   cd utcp-specification
   ```
2. Installeer afhankelijkheden:

   ```bash
   bundle install
   ```
### De documentatiesite uitvoeren

Om de site lokaal te bouwen en te serveren:


```bash
bundle exec jekyll serve
```
Hierdoor wordt een lokale webserver gestart op `http://localhost:4000` waar je de documentatie kunt bekijken.

## Documentatiestructuur

De UTCP-documentatie is als volgt georganiseerd:

- `index.md`: Startpagina en introductie tot UTCP
- `docs/`
  - `introduction.md`: Gedetailleerde introductie en kernconcepten
  - `for-tool-providers.md`: Gids voor het implementeren van tool providers
  - `for-tool-callers.md`: Gids voor het implementeren van tool callers
  - `providers/`: Documentatie voor elk type provider
    - `http.md`: HTTP-provider
    - `websocket.md`: WebSocket-provider
    - `cli.md`: CLI-provider
    - `sse.md`: Server-Sent Events-provider
    - enz.
  - `implementation.md`: Richtlijnen voor implementatie en best practices

## Werken met de Specificatie

### Documentatie Aanpassen

De documentatie is geschreven in Markdown-formaat met Jekyll front matter. Bij het aanbrengen van wijzigingen:

1. Zorg ervoor dat je Markdown de vastgestelde stijl volgt
2. Bekijk wijzigingen lokaal voordat je PR's indient
3. Houd voorbeelden up-to-date met de laatste specificatie
4. Werk navigatie-items bij in `_config.yml` als je nieuwe pagina's toevoegt

### Bestandsorganisatie

Bij het toevoegen van nieuwe documentatie:

- Plaats provider-specifieke documentatie in `docs/providers/`
- Gebruik consistente front matter met gepaste navigatievolgorde
- Voeg tags toe voor betere doorzoekbaarheid op GitHub Pages

## Versiebeheer

De UTCP-specificatie volgt semantische versiebeheer:

- Major-versies (1.0, 2.0): Incompatibele wijzigingen aan het protocol
- Minor-versies (1.1, 1.2): Nieuwe functies toegevoegd op een achterwaarts-compatibele manier
- Patch-versies (1.0.1, 1.0.2): Achterwaarts-compatibele bugfixes en verduidelijkingen

## Licentie

Deze specificatie wordt verspreid onder de Mozilla Public License 2.0 (MPL-2.0).

## Aanvullende Bronnen

- [UTCP GitHub Organisatie](https://github.com/universal-tool-calling-protocol)
- [UTCP Website](https://utcp.io)
- [Referentie-implementaties](https://github.com/universal-tool-calling-protocol/python-utcp)
- [Community Discussies](https://github.com/universal-tool-calling-protocol/utcp-specification/discussions)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ja">Japans</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ko">Koreaans</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=th">Thais</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fa">Perzisch</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=id">Indonesisch</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
  <a href="https://core.heysol.ai">
    <img src="https://github.com/user-attachments/assets/89066cdd-204b-46c2-8ad4-4935f5ca9edd" width="200px" alt="CORE logo" />
  </a>

### CORE: Jouw Persoonlijke Geheugenlaag voor AI-apps

<p align="center">
    <a href="https://deepwiki.com/RedPlanetHQ/core">
        <img src="https://deepwiki.com/badge.svg" alt="DeepWiki Badge" />
    </a>
</p>
<p align="center">
    <a href="https://docs.heysol.ai/introduction"><b>Documentatie</b></a> •
    <a href="https://discord.gg/YGUZcvDjUa"><b>Discord</b></a>
</p>
</div>

## 🔥 Onderzoek Hoogtepunten

CORE-geheugen behaalt een gemiddelde nauwkeurigheid van **88,24%** op de Locomo-dataset over alle redeneertaken en overtreft daarmee aanzienlijk andere geheugenproviders. Bekijk deze [blog](https://blog.heysol.ai/core-build-memory-knowledge-graph-for-individuals-and-achieved-sota-on-locomo-benchmark/) voor meer informatie.

<img width="6048" height="3428" alt="benchmark" src="https://github.com/user-attachments/assets/2e5fdac5-02ed-4d00-9312-c21d09974e1f" />
(1) Single-hop vragen vereisen antwoorden op basis van één sessie; (2) Multi-hop vragen vereisen het synthetiseren van informatie uit meerdere verschillende sessies; (3) Open-domein kennisvragen kunnen worden beantwoord door de informatie van een spreker te combineren met externe kennis zoals gezond verstand of feiten over de wereld; (4) Tijdelijke redeneervragen kunnen worden beantwoord door temporeel redeneren en het vastleggen van tijdsgerelateerde gegevenssignalen binnen het gesprek;

## Overzicht

**Probleem**

Ontwikkelaars verspillen tijd door steeds opnieuw context uit te leggen aan AI-tools. Kom je aan het tokenlimiet bij Claude? Begin opnieuw en alles is weg. Wissel je van ChatGPT/Claude naar Cursor? Leg je context opnieuw uit. Je gesprekken, beslissingen en inzichten verdwijnen tussen sessies. Met elke nieuwe AI-tool nemen de kosten van contextwisselingen toe.

**Oplossing** - **CORE** (**Contextual Observation & Recall Engine**)

CORE is een open-source, uniforme en persistente geheugenlaag voor al je AI-tools. Je context volgt je van Cursor naar Claude, van ChatGPT naar Claude Code. Eén kennisgrafiek onthoudt wie wat zei, wanneer en waarom. Eén keer verbinden, overal onthouden. Stop met het beheren van context en begin met bouwen.

## 🚀 CORE Zelf-Hosting
Wil je CORE op je eigen infrastructuur draaien? Zelf-hosting geeft je volledige controle over je data en uitrol.

**Vereisten**:

- Docker (20.10.0+) en Docker Compose (2.20.0+) geïnstalleerd
- OpenAI API-sleutel

> **Opmerking over Open-Source modellen:** We hebben OSS-opties zoals Ollama en GPT-modellen getest, maar hun feitenextractie en grafiekkwaliteit waren onvoldoende. We zijn actief op zoek naar alternatieven.

### Installatie

1. Clone de repository:
```
git clone https://github.com/RedPlanetHQ/core.git
cd core
```
2. Configureer omgevingsvariabelen in `core/.env`:
```
OPENAI_API_KEY=your_openai_api_key
```
3. Start de service
```
docker-compose up -d
```
Zodra geïmplementeerd, kun je je AI-providers (OpenAI, Anthropic) configureren en beginnen met het bouwen van je geheugen grafiek.

👉 [Bekijk de volledige self-hosting gids](https://docs.heysol.ai/self-hosting/docker)

Opmerking: We hebben open-source modellen zoals Ollama of GPT OSS geprobeerd, maar de feitengeneratie was niet goed. We zoeken nog uit hoe we dit kunnen verbeteren, en zullen dan ook OSS modellen ondersteunen.

## 🚀 CORE Cloud
**Bouw je uniforme geheugen grafiek in 5 minuten:**

Wil je geen infrastructuur beheren? Met CORE Cloud bouw je direct je persoonlijke geheugensysteem - geen installatie, geen servers, gewoon geheugen dat werkt.

1. **Meld je aan** op [core.heysol.ai](https://core.heysol.ai) en maak een account aan
2. **Visualiseer je geheugen grafiek** en zie hoe CORE automatisch verbindingen tussen feiten legt
3. **Test het uit** - vraag "Wat weet je over mij?" in het conversatiegedeelte
4. Verbind met je tools:
   - [Claude](https://docs.heysol.ai/providers/claude) & [Cursor](https://docs.heysol.ai/providers/cursor) - coderen met context
   - [Claude Code CLI](https://docs.heysol.ai/providers/claude-code) & [Codex CLI](https://docs.heysol.ai/providers/codex) - terminal-based coderen met geheugen
   - [Browserextensie toevoegen](https://docs.heysol.ai/providers/browser-extension) - breng je geheugen naar elke website
   - [Linear](https://docs.heysol.ai/integrations/linear), [Github](https://docs.heysol.ai/integrations/github) - voeg automatisch projectcontext toe

## 🧩 Belangrijkste Functies

### 🧠 **Uniform, Draagbaar Geheugen**: 
Voeg je geheugen toe en haal het op via **Cursor, Windsurf, Claude Desktop, Claude Code, Gemini CLI, AWS's Kiro, VS Code en Roo Code** via MCP

![core-claude](https://github.com/user-attachments/assets/56c98288-ee87-4cd0-8b02-860aca1c7f9a)


### 🕸️ **Temporele + Gerealiseerde Kennisgrafiek**: 

Onthoud het verhaal achter elk feit—volg wie wat zei, wanneer en waarom met rijke relaties en volledige herkomst, niet alleen platte opslag

![core-memory-graph](https://github.com/user-attachments/assets/5d1ee659-d519-4624-85d1-e0497cbdd60a)


### 🌐 **Browserextensie**: 

Sla gesprekken en inhoud van ChatGPT, Grok, Gemini, Twitter, YouTube, blogposts en elke webpagina direct op in je CORE-geheugen.


**Hoe gebruikt u de extensie**
1. [Download de extensie](https://chromewebstore.google.com/detail/core-extension/cglndoindnhdbfcbijikibfjoholdjcc) vanuit de Chrome Web Store.
2. Log in op het [CORE dashboard](https://core.heysol.ai)
   - Navigeer naar Instellingen (linksonder)
   - Ga naar API Sleutel → Genereer nieuwe sleutel → Noem deze “extensie.”
3. Open de extensie, plak uw API-sleutel en sla op.

https://github.com/user-attachments/assets/6e629834-1b9d-4fe6-ae58-a9068986036a


### 💬 **Chatten met Geheugen**: 
Stel vragen zoals "Wat zijn mijn schrijfvoorkeuren?" en krijg direct inzicht uit uw verbonden kennis

![chat-with-memory](https://github.com/user-attachments/assets/d798802f-bd51-4daf-b2b5-46de7d206f66)


### ⚡ **Auto-Sync van Apps**:

Leg automatisch relevante context vast van Linear, Slack, Notion, GitHub en andere gekoppelde apps in uw CORE-geheugen

📖 **[Bekijk alle integraties](https://raw.githubusercontent.com/RedPlanetHQ/core/main/./integrations/README.md)** - Volledige lijst van ondersteunde diensten en hun functies

![core-slack](https://github.com/user-attachments/assets/d5fefe38-221e-4076-8a44-8ed673960f03)


### 🔗 **MCP Integratiehub**: 

Verbind Linear, Slack, GitHub, Notion eenmaal met CORE—gebruik daarna al hun tools in Claude, Cursor, of elke MCP-client via één enkele URL


![core-linear-claude](https://github.com/user-attachments/assets/7d59d92b-8c56-4745-a7ab-9a3c0341aa32)



## Hoe CORE geheugen aanmaakt

<img width="12885" height="3048" alt="memory-ingest-diagram" src="https://github.com/user-attachments/assets/c51679de-8260-4bee-bebf-aff32c6b8e13" />

Het CORE-verwerkingsproces bestaat uit vier fasen ontworpen om veranderende context vast te leggen:

1. **Normalisatie**: Verbindt nieuwe informatie met recente context, verdeelt lange documenten in samenhangende stukken met behoud van kruisverwijzingen, en standaardiseert termen zodat CORE bij kennisextractie werkt met schone, gecontextualiseerde input in plaats van rommelige tekst.
2. **Extractie**: Haalt betekenis uit genormaliseerde tekst door entiteiten te identificeren (personen, tools, projecten, concepten), ze om te zetten in verklaringen met context, bron en tijd, en relaties te koppelen. Bijvoorbeeld: “We schreven CORE in Next.js” wordt: Entiteiten (Core, Next.js), Verklaring (CORE is ontwikkeld met Next.js), en Relatie (is ontwikkeld met).
3. **Resolutie**: Detecteert tegenstrijdigheden, volgt hoe voorkeuren evolueren, en bewaart meerdere perspectieven met herkomst in plaats van ze te overschrijven zodat het geheugen je volledige traject weerspiegelt, niet alleen de laatste momentopname.
4. **Grafiekintegratie**: Verbindt entiteiten, uitspraken en episodes tot een temporele kennisgrafiek die feiten koppelt aan hun context en geschiedenis, waardoor geïsoleerde data verandert in een levend web van kennis dat agents echt kunnen gebruiken.

Het resultaat: In plaats van een vlakke database, geeft CORE je een geheugen dat meegroeit en verandert met jou – met behoud van context, evolutie en eigenaarschap zodat agents er echt gebruik van kunnen maken.


![memory-ingest-eg](https://github.com/user-attachments/assets/1d0a8007-153a-4842-9586-f6f4de43e647)

## Hoe CORE uit het geheugen ophaalt

<img width="10610" height="3454" alt="memory-search-diagram" src="https://github.com/user-attachments/assets/3541893e-f7c9-42b9-8fad-6dabf138dbeb" />

Wanneer je CORE een vraag stelt, kijkt het niet alleen tekst na – het duikt in je hele kennisgrafiek om de meest bruikbare antwoorden te vinden.

1. **Zoeken**: CORE doorzoekt het geheugen vanuit meerdere invalshoeken tegelijk – trefwoordzoektocht voor exacte overeenkomsten, semantische zoektocht voor gerelateerde ideeën ook als ze anders verwoord zijn, en grafiekdoorloop om links tussen verbonden concepten te volgen.
2. **Her-rangschikken**: De opgehaalde resultaten worden opnieuw gerangschikt om de meest relevante en diverse te benadrukken, zodat je niet alleen de voor de hand liggende overeenkomsten ziet maar ook diepere connecties.
3. **Filteren**: CORE past slimme filters toe op basis van tijd, betrouwbaarheid en sterkte van relaties, zodat alleen de meest betekenisvolle kennis naar boven komt.
4. **Uitvoer**: Je krijgt zowel feiten (duidelijke uitspraken) als episodes (de oorspronkelijke context waaruit ze komen), zodat het geheugen altijd is verankerd in context, tijd en verhaal.

Het resultaat: CORE haalt niet alleen feiten op – het haalt ze op in de juiste context, tijd en verhaal, zodat agents kunnen reageren zoals jij het zou herinneren.

## Documentatie

Bekijk onze documentatie om het meeste uit CORE te halen

- [Basisconcepten](https://docs.heysol.ai/concepts/memory_graph)
- [Zelf hosten](https://docs.heysol.ai/self-hosting/overview)
- [Core MCP verbinden met Claude](https://docs.heysol.ai/providers/claude)
- [Core MCP verbinden met Cursor](https://docs.heysol.ai/providers/cursor)
- [Core MCP verbinden met Claude Code](https://docs.heysol.ai/providers/claude-code)
- [Core MCP verbinden met Codex](https://docs.heysol.ai/providers/codex) 

- [Basisconcepten](https://docs.heysol.ai/overview)
- [API Referentie](https://docs.heysol.ai/api-reference/get-user-profile)

## 🔒 Veiligheid

CORE neemt veiligheid serieus. We hanteren industriestandaard beveiligingspraktijken om je gegevens te beschermen:
- **Gegevensversleuteling**: Alle gegevens tijdens transport (TLS 1.3) en in rust (AES-256)
- **Authenticatie**: OAuth 2.0 en magische link-authenticatie
- **Toegangscontrole**: Werkruimtegebaseerde isolatie en rolgebaseerde permissies
- **Kwetsbaarheidsrapportage**: Meld beveiligingsproblemen aan harshith@poozle.dev

Voor gedetailleerde informatie over beveiliging, zie ons [Beveiligingsbeleid](https://raw.githubusercontent.com/RedPlanetHQ/core/main/SECURITY.md).

## 🧑‍💻 Ondersteuning

Heb je vragen of feedback? Wij helpen graag:

- Discord: [Word lid van het core-support kanaal](https://discord.gg/YGUZcvDjUa)
- Documentatie: [docs.heysol.ai](https://docs.heysol.ai)
- E-mail: manik@poozle.dev

## Gebruiksrichtlijnen

**Opslaan:**

- Gespreksgeschiedenis
- Gebruikersvoorkeuren
- Taakcontext
- Referentiemateriaal

**Niet opslaan:**

- Gevoelige gegevens (PII)
- Inloggegevens
- Systeemlogs
- Tijdelijke data

## 👥 Bijdragers

<a href="https://github.com/RedPlanetHQ/core/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=RedPlanetHQ/core" />
</a>
















---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---
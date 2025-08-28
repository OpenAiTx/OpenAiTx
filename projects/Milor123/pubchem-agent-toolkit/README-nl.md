
<div align="center"><p><a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=hi"><img src="https://img.shields.io/badge/हिन्दी-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=fa"><img src="https://img.shields.io/badge/فارسی-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=id"><img src="https://img.shields.io/badge/Bahasa Indonesia-white" alt="version"></a> </p></div>

# Verbeterde PubChem MCP Server voor AI-assistenten

🧪 Een geavanceerde, robuuste en privacygerichte MCP-server die AI-assistenten in staat stelt om intelligent chemische verbindingen op PubChem te zoeken en te raadplegen.

Deze PubChem MCP Server fungeert als een krachtige brug tussen AI-assistenten (zoals die in AnythingLLM) en de uitgebreide chemische databank van PubChem. Het maakt gebruik van het Model Context Protocol (MCP) zodat AI-modellen slimme, veerkrachtige zoekopdrachten naar chemische verbindingen kunnen uitvoeren en hun gedetailleerde eigenschappen programmatisch kunnen ophalen.

---

## ✨ Kernfunctionaliteiten

Dit is niet zomaar een PubChem-wrapper. Deze server is volledig opnieuw opgebouwd om uiterst robuust en intelligent te zijn:

-   **🧠 Slimme fallback-zoekfunctie**: Als een zoekopdracht op een algemene naam (zoals "Vitamine D") mislukt, voert de server automatisch een diepgaandere zoekactie uit in de PubChem Substance-database om de juiste verbinding te vinden. Dit verbetert de slagingskans bij onduidelijke zoekopdrachten enorm.
-   **🛡️ Robuuste foutafhandeling & herhalingen**: De server is ontworpen om API-fouten soepel op te vangen. Bij een "Server Busy"-fout van PubChem wacht de server automatisch en probeert de aanvraag opnieuw, zodat je zoekopdrachten zelfs bij zware belasting slagen.
-   **🔒 Optionele Tor-proxy-ondersteuning**: Je hebt volledige controle over je privacy. Een eenvoudige `config.ini` stelt je in staat om alle aanvragen via het Tor-netwerk te laten verlopen (SOCKS5 of HTTP-proxy), zodat je IP-adres niet wordt blootgesteld. De server is standaard veilig en zal **nooit** je IP lekken als de proxyverbinding mislukt.
-   **🔎 Enkelvoudige & meervoudige verbindingen zoeken**: Kan moeiteloos zoekopdrachten voor één of meerdere verbindingen in één prompt aan.
-   **🧪 Gedetailleerde eigenschap-opvraging**: Toegang tot belangrijke chemische eigenschappen zoals IUPAC-naam, molecuulformule, molecuulgewicht en vooral de **monoisotopische massa**.

---

---

### 🚀 Geen installatie vereist: Probeer het live op Smithery.ai

Voor wie nieuw is met MCP-servers of gewoon de mogelijkheden van deze tool wil testen zonder lokale installatie, is er een live, gehoste versie beschikbaar op Smithery.ai. Hiermee kun je direct in je browser met de agent chatten.

[**<-- Verken de Live PubChem Agent op Smithery.ai -->**](https://smithery.ai/server/@Milor123/smithery-pubchem-deploy)

**Aan de slag:**

1.  Klik op de bovenstaande link om naar de serverpagina te gaan.
2.  Meld je aan met je **GitHub**- of **Google**-account.
3.  Klik op de knop **"Explore capabilities"** om een chatinterface te openen en direct te testen!

> **✅ Aanbevolen modellen voor beste resultaten**
>
> Om maximale nauwkeurigheid te behalen, zeker bij lange decimale getallen, raden we krachtige modellen sterk aan. De volgende modellen zijn getest en werken uitstekend met deze tool:
>
> *   **Anthropic's Claude 3 Sonnet**
> *   **OpenAI's GPT-4 Turbo** (of nieuwere versies zoals GPT-4o)
>
> We hebben bevestigd dat beide modellen de volledige precisie van de decimale getallen die door de tool zijn teruggegeven correct verwerken, zonder afronding.

---

## 🚀 Snelstart & Installatie

Deze server is ontworpen om lokaal te draaien, hetzij op je desktop of binnen de AnythingLLM Docker-omgeving.

### 1. Afhankelijkheden

Dit project is afhankelijk van een aantal Python-bibliotheken. Zorg ervoor dat deze in je omgeving zijn geïnstalleerd.

Maak een `requirements.txt`-bestand met de volgende inhoud:
```txt
requests
bs4 
mcp 
pubchempy
pandas
PySocks
```

Installeer ze met `uv` of `pip`:
```bash
uv venv
.venv\Scripts\activate
uv pip install -r requirements.txt
```
*(Opmerking: `PySocks` is alleen vereist als je van plan bent de Tor SOCKS5-proxyfunctie te gebruiken.)*

### 2. Configuratie

De server wordt geconfigureerd via een `config.ini`-bestand dat **automatisch wordt aangemaakt** de eerste keer dat je het uitvoert. Dit bestand verschijnt in dezelfde map als het `pubchem_server.py`-script.

**Standaard `config.ini`:**
```ini
[proxy]
# Change 'use_proxy' to 'true' to route all requests through a proxy.
# Essential for protecting your privacy if you use Tor.
use_proxy = false

# Defines the proxy type. Options:
#   socks5h  -> (Recommended for Tor) The native SOCKS proxy for Tor. More secure.
#   http     -> An HTTP proxy. If using Tor, requires additional configuration.
proxy_type = socks5h

# The proxy address. THIS IS A CRITICAL SETTING!
#   - If you run this script on your DESKTOP, use: 127.0.0.1
#   - If you run this script inside DOCKER, use: host.docker.internal
host = 127.0.0.1

# The proxy port.
#   9050 -> Default port for Tor's SOCKS proxy.
#   8118 -> Default port for Tor's HTTP proxy (if enabled).
port = 9050
```

### 3. Integratie met AnythingLLM

Volg de officiële documentatie om dit toe te voegen als een aangepaste MCP-server. Het belangrijkste is om de `command` te laten verwijzen naar je Python-uitvoerbaar bestand en het `pubchem_server.py` script.

**Voorbeeld voor AnythingLLM Desktop (`plugins/anythingllm_mcp_servers.json`):**
```json
{
  "mcpServers": {
    "pubchem": {
      "name": "PubChem Server (Enhanced)",
      "transport": "stdio",
      "command": "\"C:\\path\\to\\your\\.venv\\Scripts\\python.exe\" \"C:\\path\\to\\your\\project\\pubchem_server.py\"",
      "cwd": "C:\\path\\to\\your\\project"
    }
  }
}
```


### 3.1 Implementatievoorbeelden met AnythingLLM

Hier zijn enkele voorbeelden van hoe je met de agent kunt communiceren. Deze tests zijn uitgevoerd met AnythingLLM Desktop, waarbij verbinding is gemaakt met verschillende Large Language Models via OpenRouter.

Een cruciale bevinding uit onze tests is het belang van het gekozen model. We **raden sterk af om kleine of lokale modellen** voor deze taak te gebruiken. Kleinere modellen hebben vaak moeite om de door de tool teruggegeven data correct te parseren, wat leidt tot fouten zoals gefantaseerde waarden, verkeerde opmaak of, het meest kritisch, **afronden van decimale getallen**, waardoor het doel van deze zeer nauwkeurige tool wordt tenietgedaan.

Om de integriteit van je resultaten te waarborgen, is het altijd een goede gewoonte om de ruwe data die door de MCP wordt teruggegeven te verifiëren. Je kunt leren hoe je dit doet in het volgende gedeelte: [3.2 Hoe MCP-uitvoer in de logs te verifiëren](#32-hoe-mcp-uitvoer-in-de-logs-te-verifiëren).

<img width="837" height="1060" alt="imagen" src="https://github.com/user-attachments/assets/5a16c7a2-d65d-4d64-98dd-f3cb4cae9b22" />

Aan de andere kant hebben verschillende modellen uitstekende prestaties laten zien. We hebben uitstekende resultaten behaald met **Google's `Gemini 2.5 Flash lite`**. Dit model toonde opmerkelijke precisie bij het verwerken van lange decimale getallen en het correct opmaken van de uiteindelijke Markdown-tabel.

Google gemini 2.5 flash lite zonder prompt en met prompt behoudt perfecte decimalen (in het voorbeeld wordt een temperatuur van 0.6 gebruikt)

<img width="1089" height="1061" alt="imagen" src="https://github.com/user-attachments/assets/4574efa5-d6d9-49e3-a665-a39a427f09a1" />

Voor deze specifieke taak is mijn persoonlijke favoriet **`Gemini 2.5 Flash lite`** vanwege de consistente nauwkeurigheid en betrouwbaarheid.

### 3.2 Hoe MCP-uitvoer in de logs te verifiëren

De beste manier om te bevestigen dat de agent de juiste data ontvangt en dat de LLM geen fouten maakt, is door het debug-logbestand te controleren dat door de MCP-server wordt gegenereerd.

Deze server is geconfigureerd om automatisch een logbestand aan te maken in een submap binnen je projectdirectory. De locatie zal zijn:

```
your-project-folder/
└── logs_mcp/
    └── mcp_debug.log
```

In `mcp_debug.log` vind je de exacte JSON-gegevens die de tool terugstuurt naar de LLM *voordat* het model deze verwerkt. Je kunt deze JSON handmatig inspecteren om waarden te controleren, vooral lange decimale getallen van eigenschappen zoals `monoisotopic_mass`, zodat je zeker weet dat de LLM geen afrondingsfouten of hallucinaties heeft geïntroduceerd in het uiteindelijke antwoord.

---

## 📊 Gebruik

Zodra geïntegreerd, zal je AI-assistent deze tool automatisch gebruiken wanneer er naar chemische informatie wordt gevraagd. De belangrijkste tool die beschikbaar is, is `search_compounds_by_name`.

### Voorbeeldprompt

Deze prompt demonstreert het vermogen van de tool om een lijst van verbindingen met verschillende naamtypen te verwerken en meerdere eigenschappen op te halen.

```
@agent
Please use your PubChem tool to find information on the following compounds:

- Thiamine (Vitamin B1)
- Riboflavin (Vitamin B2)
- Folic Acid
- Hydroxocobalamin

For each compound found, please retrieve the IUPAC Name, Molecular Formula, and Monoisotopic Mass.

Present all the results in a single Markdown table.
```

De agent zal de `search_compounds_by_name` tool aanroepen, die elk bestanddeel intelligent zal vinden, de gegevens zal ophalen en deze aan de LLM zal retourneren voor opmaak.

---

## 🛠 MCP Tool Beschikbaar

### `search_compounds_by_name`

Zoekt meerdere verbindingen op naam, één voor één, met een slimme fallback-strategie inclusief pauzes en herhaalde pogingen voor maximale betrouwbaarheid.

**Parameters:**
-   `names` (List[str]): Een lijst met namen van verbindingen. Voorbeeld: `["Aspirine", "Ibuprofen"]`

**Retourneert:** Een lijst met dictionaries, waarbij elke dictionary ofwel de gevonden informatie van de verbinding bevat, of een foutmelding met uitleg waarom de zoekopdracht voor die specifieke verbinding is mislukt.

---

## 🙏 Dankbetuigingen

Dit project is sterk geïnspireerd door en gebouwd op de basis van de originele [PubChem-MCP-Server](https://github.com/JackKuo666/PubChem-MCP-Server) ontwikkeld door **JackKuo666**.

Hoewel deze repository geen directe fork is, was het originele project het cruciale startpunt. Deze versie verbetert het oorspronkelijke concept met een focus op extreme robuustheid, intelligente zoekstrategieën en gebruikersprivacy via optionele Tor-integratie 🧅.

Veel dank aan de oorspronkelijke auteur voor het fantastische werk en het delen met de gemeenschap.

---

## ⚠️ Disclaimer

Deze tool is bedoeld voor onderzoeks- en educatieve doeleinden. Respecteer de gebruiksvoorwaarden van PubChem en gebruik deze tool op verantwoorde wijze.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-27

---
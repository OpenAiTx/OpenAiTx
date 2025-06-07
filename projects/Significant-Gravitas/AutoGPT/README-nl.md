# AutoGPT: Bouw, Implementeer en Voer AI Agents uit

[![Discord Volgen](https://dcbadge.vercel.app/api/server/autogpt?style=flat)](https://discord.gg/autogpt) &ensp;
[![Twitter Volgen](https://img.shields.io/twitter/follow/Auto_GPT?style=social)](https://twitter.com/Auto_GPT) &ensp;
[![Licentie: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

**AutoGPT** is een krachtig platform waarmee je continue AI-agents kunt creëren, implementeren en beheren die complexe workflows automatiseren.

## Hostingopties
   - Download om zelf te hosten
   - [Meld je aan voor de wachtlijst](https://bit.ly/3ZDijAI) voor de cloud-hosted bèta

## Zelf-Hosting Installatie
> [!LET OP]
> Het opzetten en zelf hosten van het AutoGPT Platform is een technisch proces.
> Wil je liever iets dat gewoon werkt, dan raden we aan om [je aan te melden voor de wachtlijst](https://bit.ly/3ZDijAI) voor de cloud-hosted bèta.

### Systeemeisen

Controleer vóór de installatie of je systeem aan de volgende eisen voldoet:

#### Hardware-eisen
- CPU: 4+ cores aanbevolen
- RAM: Minimaal 8GB, 16GB aanbevolen
- Opslag: Minimaal 10GB vrije ruimte

#### Software-eisen
- Besturingssystemen:
  - Linux (Ubuntu 20.04 of nieuwer aanbevolen)
  - macOS (10.15 of nieuwer)
  - Windows 10/11 met WSL2
- Vereiste software (met minimum versies):
  - Docker Engine (20.10.0 of nieuwer)
  - Docker Compose (2.0.0 of nieuwer)
  - Git (2.30 of nieuwer)
  - Node.js (16.x of nieuwer)
  - npm (8.x of nieuwer)
  - VSCode (1.60 of nieuwer) of een moderne code-editor

#### Netwerkeisen
- Stabiele internetverbinding
- Toegang tot vereiste poorten (wordt geconfigureerd in Docker)
- Mogelijkheid om uitgaande HTTPS-verbindingen te maken

### Bijgewerkte Installatie-instructies:
We zijn overgestapt naar een volledig onderhouden en regelmatig bijgewerkte documentatie website.

👉 [Volg hier de officiële zelf-hosting handleiding](https://docs.agpt.co/platform/getting-started/)

Deze tutorial gaat ervan uit dat je Docker, VSCode, git en npm hebt geïnstalleerd.

### 🧱 AutoGPT Frontend

De AutoGPT frontend is waar gebruikers interacteren met ons krachtige AI-automatiseringsplatform. Het biedt meerdere manieren om met onze AI-agents te werken en deze te benutten. Dit is de interface waar je jouw AI-automatiseringsideeën tot leven brengt:

   **Agent Builder:** Voor wie wil aanpassen, biedt onze intuïtieve low-code interface de mogelijkheid om je eigen AI-agents te ontwerpen en configureren.
   
   **Workflowbeheer:** Bouw, wijzig en optimaliseer je automatiseringsworkflows eenvoudig. Je bouwt je agent door blokken te verbinden, waarbij elk blok een enkele actie uitvoert.
   
   **Implementatiebeheer:** Beheer de levenscyclus van je agents, van testen tot productie.
   
   **Kant-en-klare Agents:** Wil je niet zelf bouwen? Kies dan eenvoudig uit onze bibliotheek van vooraf geconfigureerde agents en zet ze direct aan het werk.
   
   **Agentinteractie:** Of je nu je eigen agent hebt gebouwd of kant-en-klare agents gebruikt, je kunt ze eenvoudig uitvoeren en ermee interacteren via onze gebruiksvriendelijke interface.

   **Monitoring en Analyse:** Houd de prestaties van je agents bij en verkrijg inzichten om je automatiseringsprocessen continu te verbeteren.

[Lees deze handleiding](https://docs.agpt.co/platform/new_blocks/) om te leren hoe je eigen aangepaste blokken bouwt.

### 💽 AutoGPT Server

De AutoGPT Server is het hart van ons platform. Hier draaien je agents. Eenmaal geïmplementeerd, kunnen agents door externe bronnen worden getriggerd en continu werken. Het bevat alle essentiële componenten die AutoGPT soepel laten draaien.

   **Broncode:** De kernlogica die onze agents en automatiseringsprocessen aandrijft.
   
   **Infrastructuur:** Robuuste systemen die betrouwbare en schaalbare prestaties garanderen.
   
   **Marktplaats:** Een uitgebreide marktplaats waar je een breed scala aan vooraf gebouwde agents kunt vinden en implementeren.

### 🐙 Voorbeeldagents

Hier zijn twee voorbeelden van wat je met AutoGPT kunt doen:

1. **Genereer virale video's van trending onderwerpen**
   - Deze agent leest onderwerpen op Reddit.
   - Hij identificeert trending onderwerpen.
   - Vervolgens maakt hij automatisch een korte video op basis van de inhoud.

2. **Identificeer topcitaten uit video's voor sociale media**
   - Deze agent abonneert zich op je YouTube-kanaal.
   - Wanneer je een nieuwe video plaatst, transcribeert hij deze.
   - Hij gebruikt AI om de meest impactvolle citaten te identificeren en genereert een samenvatting.
   - Daarna schrijft hij een bericht om automatisch te publiceren op je sociale media.

Deze voorbeelden tonen slechts een glimp van wat je met AutoGPT kunt bereiken! Je kunt aangepaste workflows creëren om agents te bouwen voor elk gebruiksscenario.

---
### Missie en Licenties
Onze missie is om de tools te bieden zodat jij je kunt focussen op wat belangrijk is:

- 🏗️ **Bouwen** - Leg de basis voor iets geweldigs.
- 🧪 **Testen** - Stem je agent perfect af.
- 🤝 **Uitbesteden** - Laat AI voor je werken en zie je ideeën tot leven komen.

Word onderdeel van de revolutie! **AutoGPT** is hier om te blijven, aan de voorhoede van AI-innovatie.

**📖 [Documentatie](https://docs.agpt.co)**
&ensp;|&ensp;
**🚀 [Bijdragen](CONTRIBUTING.md)**

**Licenties:**

MIT Licentie: Het grootste deel van de AutoGPT-repository valt onder de MIT Licentie.

Polyform Shield Licentie: Deze licentie geldt voor de autogpt_platform-map.

Voor meer informatie, zie https://agpt.co/blog/introducing-the-autogpt-platform

---
## 🤖 AutoGPT Classic
> Hieronder vind je informatie over de klassieke versie van AutoGPT.

**🛠️ [Bouw je eigen Agent - Quickstart](classic/FORGE-QUICKSTART.md)**

### 🏗️ Forge

**Smed je eigen agent!** &ndash; Forge is een kant-en-klare toolkit om je eigen agenttoepassing te bouwen. Het behandelt het meeste standaardcode, zodat jij je creativiteit kunt richten op wat *jouw* agent uniek maakt. Alle tutorials vind je [hier](https://medium.com/@aiedge/autogpt-forge-e3de53cc58ec). Componenten uit [`forge`](/classic/forge/) kunnen ook individueel worden gebruikt om de ontwikkeling te versnellen en boilerplate te verminderen in je agentproject.

🚀 [**Aan de slag met Forge**](https://github.com/Significant-Gravitas/AutoGPT/blob/master/classic/forge/tutorials/001_getting_started.md) &ndash;
Deze gids leidt je door het proces van het maken van je eigen agent en het gebruik van de benchmark en gebruikersinterface.

📘 [Meer informatie](https://github.com/Significant-Gravitas/AutoGPT/tree/master/classic/forge) over Forge

### 🎯 Benchmark

**Meet de prestaties van je agent!** De `agbenchmark` kan worden gebruikt met elke agent die het agentprotocol ondersteunt, en de integratie met de [CLI] van het project maakt het nog eenvoudiger om te gebruiken met AutoGPT- en forge-gebaseerde agents. De benchmark biedt een streng testmilieu. Ons framework maakt autonome, objectieve prestatie-evaluaties mogelijk, zodat je zeker weet dat je agents klaar zijn voor de praktijk.

<!-- TODO: visualisatie van de benchmark toevoegen -->

📦 [`agbenchmark`](https://pypi.org/project/agbenchmark/) op Pypi
&ensp;|&ensp;
📘 [Meer informatie](https://github.com/Significant-Gravitas/AutoGPT/tree/master/classic/benchmark) over de Benchmark

### 💻 UI

**Maakt agents eenvoudig te gebruiken!** De `frontend` biedt een gebruiksvriendelijke interface om je agents te besturen en monitoren. Hij verbindt met agents via het [agent protocol](#-agent-protocol), waardoor hij compatibel is met veel agents binnen en buiten ons ecosysteem.

<!-- TODO: screenshot van de frontend toevoegen -->

De frontend werkt direct met alle agents in de repo. Gebruik gewoon de [CLI] om je gewenste agent te starten!

📘 [Meer informatie](https://github.com/Significant-Gravitas/AutoGPT/tree/master/classic/frontend) over de Frontend

### ⌨️ CLI

[CLI]: #-cli

Om het zo eenvoudig mogelijk te maken om alle tools van de repository te gebruiken, is een CLI opgenomen in de root van de repo:

```shell
$ ./run
Usage: cli.py [OPTIONS] COMMAND [ARGS]...

Options:
  --help  Show this message and exit.

Commands:
  agent      Commands to create, start and stop agents
  benchmark  Commands to start the benchmark and list tests and categories
  setup      Installs dependencies needed for your system.
```

Clone gewoon de repo, installeer de afhankelijkheden met `./run setup`, en je kunt aan de slag!

## 🤔 Vragen? Problemen? Suggesties?

### Hulp nodig - [Discord 💬](https://discord.gg/autogpt)

[![Word lid van onze Discord](https://invidget.switchblade.xyz/autogpt)](https://discord.gg/autogpt)

Om een bug te melden of een feature aan te vragen, maak een [GitHub Issue](https://github.com/Significant-Gravitas/AutoGPT/issues/new/choose) aan. Controleer of er niet al een issue is voor hetzelfde onderwerp.

## 🤝 Zusterprojecten

### 🔄 Agent Protocol

Om een uniforme standaard te behouden en naadloze compatibiliteit met veel huidige en toekomstige toepassingen te waarborgen, gebruikt AutoGPT de [agent protocol](https://agentprotocol.ai/) standaard van de AI Engineer Foundation. Dit standaardiseert de communicatie van je agent naar de frontend en benchmark.

---

## Stars stats

<p align="center">
<a href="https://star-history.com/#Significant-Gravitas/AutoGPT">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=Significant-Gravitas/AutoGPT&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=Significant-Gravitas/AutoGPT&type=Date" />
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=Significant-Gravitas/AutoGPT&type=Date" />
  </picture>
</a>
</p>


## ⚡ Bijdragers

<a href="https://github.com/Significant-Gravitas/AutoGPT/graphs/contributors" alt="Bekijk Bijdragers">
  <img src="https://contrib.rocks/image?repo=Significant-Gravitas/AutoGPT&max=1000&columns=10" alt="Bijdragers" />
</a>

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---
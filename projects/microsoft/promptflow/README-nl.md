# Prompt flow

[![Python package](https://img.shields.io/pypi/v/promptflow)](https://pypi.org/project/promptflow/)
[![Python](https://img.shields.io/pypi/pyversions/promptflow.svg?maxAge=2592000)](https://pypi.python.org/pypi/promptflow/)
[![PyPI - Downloads](https://img.shields.io/pypi/dm/promptflow)](https://pypi.org/project/promptflow/)
[![CLI](https://img.shields.io/badge/CLI-reference-blue)](https://microsoft.github.io/promptflow/reference/pf-command-reference.html)
[![vsc extension](https://img.shields.io/visual-studio-marketplace/i/prompt-flow.prompt-flow?logo=Visual%20Studio&label=Extension%20)](https://marketplace.visualstudio.com/items?itemName=prompt-flow.prompt-flow)

[![Doc](https://img.shields.io/badge/Doc-online-green)](https://microsoft.github.io/promptflow/index.html)
[![Issue](https://img.shields.io/github/issues/microsoft/promptflow)](https://github.com/microsoft/promptflow/issues/new/choose)
[![Discussions](https://img.shields.io/github/discussions/microsoft/promptflow)](https://github.com/microsoft/promptflow/issues/new/choose)
[![CONTRIBUTING](https://img.shields.io/badge/Contributing-8A2BE2)](https://github.com/microsoft/promptflow/blob/main/CONTRIBUTING.md)
[![License: MIT](https://img.shields.io/github/license/microsoft/promptflow)](https://github.com/microsoft/promptflow/blob/main/LICENSE)

> Wees welkom om met ons mee te doen om prompt flow te verbeteren door deel te nemen aan [discussies](https://github.com/microsoft/promptflow/discussions), [issues te openen](https://github.com/microsoft/promptflow/issues/new/choose), [PR's in te dienen](https://github.com/microsoft/promptflow/pulls).

**Prompt flow** is een suite van ontwikkeltools ontworpen om de end-to-end ontwikkelcyclus van LLM-gebaseerde AI-toepassingen te stroomlijnen, van idee, prototyping, testen, evaluatie tot productie-uitrol en monitoring. Het maakt prompt engineering veel eenvoudiger en stelt je in staat om LLM-apps te bouwen met productiekwaliteit.

Met prompt flow kun je:

- **Flow creëren en iteratief ontwikkelen**
    - Maak uitvoerbare [flows](https://microsoft.github.io/promptflow/concepts/concept-flows.html) die LLM's, prompts, Python-code en andere [tools](https://microsoft.github.io/promptflow/concepts/concept-tools.html) met elkaar verbinden.
    - Debug en verbeter je flows, met name het [traceren van interactie met LLM's](https://microsoft.github.io/promptflow/how-to-guides/tracing/index.html) op een eenvoudige manier.
- **Flow kwaliteit en prestaties evalueren**
    - Evalueer de kwaliteit en prestaties van je flow met grotere datasets.
    - Integreer het testen en evalueren in je CI/CD-systeem om de kwaliteit van je flow te waarborgen.
- **Gestroomlijnde ontwikkelcyclus voor productie**
    - Zet je flow eenvoudig uit op het gewenste platform of integreer in de codebasis van je app.
    - (Optioneel, maar sterk aanbevolen) Werk samen met je team via de cloudversie van [Prompt flow in Azure AI](https://learn.microsoft.com/en-us/azure/machine-learning/prompt-flow/overview-what-is-prompt-flow?view=azureml-api-2).

------

## Installatie

Om snel te starten, kun je een vooraf gebouwde ontwikkelomgeving gebruiken. **Klik op de onderstaande knop** om de repo te openen in GitHub Codespaces, en ga vervolgens verder met de readme!

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/promptflow?quickstart=1)

Als je lokaal aan de slag wilt gaan, installeer dan eerst de pakketten:

Zorg dat je een python-omgeving hebt, `python>=3.9, <=3.11` wordt aanbevolen.

```sh
pip install promptflow promptflow-tools
```

## Snelstart ⚡

**Maak een chatbot met prompt flow**

Voer het commando uit om een prompt flow te starten vanuit een chat-template; dit maakt een map genaamd `my_chatbot` aan en genereert daarin de benodigde bestanden:

```sh
pf flow init --flow ./my_chatbot --type chat
```

**Stel een verbinding in voor je API-sleutel**

Voor een OpenAI-sleutel, maak een verbinding aan via het commando, gebruikmakend van het `openai.yaml` bestand in de `my_chatbot` map, waarin je OpenAI-sleutel wordt opgeslagen (overschrijf sleutels en naam met --set om wijzigingen aan het yaml-bestand te vermijden):

```sh
pf connection create --file ./my_chatbot/openai.yaml --set api_key=<your_api_key> --name open_ai_connection
```

Voor een Azure OpenAI-sleutel, maak de verbinding aan via het commando, gebruikmakend van het `azure_openai.yaml` bestand:

```sh
pf connection create --file ./my_chatbot/azure_openai.yaml --set api_key=<your_api_key> api_base=<your_api_base> --name open_ai_connection
```

**Chatten met je flow**

In de map `my_chatbot` bevindt zich een `flow.dag.yaml` bestand dat de flow beschrijft, inclusief invoer/uitvoer, nodes, verbindingen en het LLM-model, enz.

> Let op dat we in de `chat` node een verbinding gebruiken met de naam `open_ai_connection` (gespecificeerd in het `connection` veld) en het `gpt-35-turbo` model (gespecificeerd in het `deployment_name` veld). Het deployment_name veld specificeert het OpenAI-model of de Azure OpenAI deployment resource.

Interactie met je chatbot door het volgende uit te voeren: (druk op `Ctrl + C` om te stoppen)

```sh
pf flow test --flow ./my_chatbot --interactive
```

**Kernwaarde: zorgen voor "Hoge Kwaliteit" van prototype tot productie**

Bekijk onze [**15-minuten tutorial**](https://raw.githubusercontent.com/microsoft/promptflow/main/examples/tutorials/flow-fine-tuning-evaluation/promptflow-quality-improvement.md) die je begeleidt door prompt-tuning ➡ batch-testen ➡ evaluatie, alles gericht op het waarborgen van hoge kwaliteit voor productie.

Volgende stap! Ga verder met de sectie **Tutorial** 👇 om dieper in prompt flow te duiken.

## Tutorial 🏃‍♂️

Prompt flow is een tool ontworpen om **LLM-apps van hoge kwaliteit te bouwen**; het ontwikkelproces in prompt flow volgt deze stappen: ontwikkel een flow, verbeter de flow-kwaliteit, zet de flow uit naar productie.

### Ontwikkel je eigen LLM-apps

#### VS Code-extensie

We bieden ook een VS Code-extensie (een flow designer) voor een interactieve flow-ontwikkelervaring met UI.

<img src="https://raw.githubusercontent.com/microsoft/promptflow/main/docs/media/readme/vsc.png" alt="vsc" width="1000"/>

Je kunt deze installeren vanuit de <a href="https://marketplace.visualstudio.com/items?itemName=prompt-flow.prompt-flow">Visual Studio Marketplace</a>.

#### Verdiep je in flow-ontwikkeling

[Aan de slag met prompt flow](https://raw.githubusercontent.com/microsoft/promptflow/main/docs/how-to-guides/quick-start.md): Stapsgewijze begeleiding om je eerste flow-run te starten.

### Leer van use-cases

[Tutorial: Chat met PDF](https://github.com/microsoft/promptflow/blob/main/examples/tutorials/e2e-development/chat-with-pdf.md): Een end-to-end tutorial over het bouwen van een hoogwaardige chatapplicatie met prompt flow, inclusief flow-ontwikkeling en evaluatie met metrics.
> Meer voorbeelden vind je [hier](https://microsoft.github.io/promptflow/tutorials/index.html#samples). We verwelkomen bijdragen van nieuwe use-cases!

### Setup voor bijdragers

Als je wilt bijdragen, begin dan met onze dev-setup gids: [dev_setup.md](https://raw.githubusercontent.com/microsoft/promptflow/main/docs/dev/dev_setup.md).

Volgende stap! Ga verder met de sectie **Bijdragen** 👇 om bij te dragen aan prompt flow.

## Bijdragen

Dit project verwelkomt bijdragen en suggesties. De meeste bijdragen vereisen dat je akkoord gaat met een
Contributor License Agreement (CLA) waarin je verklaart dat je het recht hebt om je bijdrage te leveren en ons het recht geeft deze te gebruiken. Zie https://cla.opensource.microsoft.com voor details.

Wanneer je een pull request indient, bepaalt een CLA-bot automatisch of je een CLA moet ondertekenen en markeert de PR dienovereenkomstig (bijv. statuscheck, opmerking). Volg gewoon de instructies van de bot. Je hoeft dit slechts één keer te doen voor alle repos die onze CLA gebruiken.

Dit project hanteert de [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
Voor meer informatie, zie de [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) of
neem contact op met [opencode@microsoft.com](mailto:opencode@microsoft.com) voor aanvullende vragen of opmerkingen.

## Handelsmerken

Dit project kan handelsmerken of logo's bevatten van projecten, producten of diensten. Geautoriseerd gebruik van Microsoft
handelsmerken of logo's is onderworpen aan en moet voldoen aan de
[Microsoft's Trademark & Brand Guidelines](https://www.microsoft.com/en-us/legal/intellectualproperty/trademarks/usage/general).
Gebruik van Microsoft-handelsmerken of logo's in aangepaste versies van dit project mag geen verwarring veroorzaken of de indruk wekken van Microsoft-sponsoring.
Elk gebruik van handelsmerken of logo's van derden is onderworpen aan het beleid van die derden.

## Gedragscode

Dit project hanteert de
[Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
Voor meer informatie, zie de
[Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/)
of neem contact op met [opencode@microsoft.com](mailto:opencode@microsoft.com)
voor aanvullende vragen of opmerkingen.

## Gegevensverzameling

De software kan informatie over jou en je gebruik van de software verzamelen en
naar Microsoft verzenden als dit is geconfigureerd om telemetrie in te schakelen.
Microsoft kan deze informatie gebruiken om diensten te leveren en onze producten en diensten te verbeteren.
Je kunt telemetrie inschakelen zoals beschreven in de repository.
Sommige functies in de software kunnen het mogelijk maken dat jij en Microsoft
gegevens verzamelen van gebruikers van jouw applicaties. Als je deze functies gebruikt, moet je voldoen aan de toepasselijke wetgeving, waaronder het verstrekken van passende meldingen aan gebruikers van jouw applicaties samen met een kopie van Microsoft's privacyverklaring. Onze privacyverklaring is te vinden op
https://go.microsoft.com/fwlink/?LinkID=824704. Je kunt meer leren over gegevensverzameling en -gebruik in de helpdocumentatie en onze privacyverklaring. Je gebruik van de software geldt als toestemming voor deze praktijken.

### Telemetrieconfiguratie

Telemetrieverzameling staat standaard aan.

Om je af te melden, voer je `pf config set telemetry.enabled=false` uit om dit uit te schakelen.

## Licentie

Copyright (c) Microsoft Corporation. Alle rechten voorbehouden.

Gelicenseerd onder de [MIT](LICENSE) licentie.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---
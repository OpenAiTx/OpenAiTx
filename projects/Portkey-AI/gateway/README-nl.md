<p align="right">
   <strong>Engels</strong> | <a href="./.github/README.cn.md">中文</a> | <a href="./.github/README.jp.md">日本語</a>
</p>

<div align="center">

<a href="https://portkey.sh/report-github"><img src="https://raw.githubusercontent.com/siddharthsambharia-portkey/Portkey-Product-Images/refs/heads/main/LLM%20Report%20Campaign%20Frame.png"></img></a>
<br>

# AI Gateway
#### Routeer naar 250+ LLMs met 1 snelle & gebruiksvriendelijke API

<img src="https://cfassets.portkey.ai/sdk.gif" width="550px" alt="Portkey AI Gateway Demo die LLM routeringsmogelijkheden toont" style="margin-left:-35px">

[Docs](https://portkey.wiki/gh-1) | [Enterprise](https://portkey.wiki/gh-2) | [Hosted Gateway](https://portkey.wiki/gh-3) | [Changelog](https://portkey.wiki/gh-4) | [API Referentie](https://portkey.wiki/gh-5)


[![License](https://img.shields.io/github/license/Ileriayo/markdown-badges)](./LICENSE)
[![Discord](https://img.shields.io/discord/1143393887742861333)](https://portkey.wiki/gh-6)
[![Twitter](https://img.shields.io/twitter/url/https/twitter/follow/portkeyai?style=social&label=Follow%20%40PortkeyAI)](https://portkey.wiki/gh-7)
[![npm version](https://badge.fury.io/js/%40portkey-ai%2Fgateway.svg)](https://portkey.wiki/gh-8)
[![Better Stack Badge](https://uptime.betterstack.com/status-badges/v1/monitor/q94g.svg)](https://portkey.wiki/gh-9)

<a href="https://us-east-1.console.aws.amazon.com/cloudformation/home?region=us-east-1#/stacks/quickcreate?stackName=portkey-gateway&templateURL=https://portkey-gateway-ec2-quicklaunch.s3.us-east-1.amazonaws.com/portkey-gateway-ec2-quicklaunch.template.yaml"><img src="https://img.shields.io/badge/Deploy_to_EC2-232F3E?style=for-the-badge&logo=amazonwebservices&logoColor=white" alt="Deploy to AWS EC2" width="105"/></a> [![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/Portkey-AI/gateway)
</div>

<br/>

De [**AI Gateway**](https://portkey.wiki/gh-10) is ontworpen voor snelle, betrouwbare & veilige routering naar 1600+ taal-, visie-, audio- en beeldmodellen. Het is een lichtgewicht, open-source en enterprise-ready oplossing waarmee je binnen 2 minuten met elk taalmodel kunt integreren.

- [x] **Bliksemsnel** (<1ms latency) met een kleine footprint (122kb)
- [x] **Beproefd in de praktijk**, met meer dan 10 miljard tokens verwerkt per dag
- [x] **Enterprise-ready** met verbeterde beveiliging, schaalbaarheid en aangepaste implementaties

<br>

#### Wat kun je doen met de AI Gateway?
- Integreer met elke LLM binnen 2 minuten - [Snelstart](#quickstart-2-mins)
- Voorkom downtime door **[automatische herhalingen](https://portkey.wiki/gh-11)** en **[fallbacks](https://portkey.wiki/gh-12)**
- Schaal AI-apps met **[load balancing](https://portkey.wiki/gh-13)** en **[conditionele routering](https://portkey.wiki/gh-14)**
- Bescherm je AI-implementaties met **[guardrails](https://portkey.wiki/gh-15)**
- Ga verder dan tekst met **[multi-modale mogelijkheden](https://portkey.wiki/gh-16)**
- Ontdek ten slotte **[agentische workflow](https://portkey.wiki/gh-17)** integraties

<br><br>

> [!TIP]
> Door deze repo te starren help je meer ontwikkelaars de AI Gateway te ontdekken 🙏🏻
>
> ![star-2](https://github.com/user-attachments/assets/53597dce-6333-4ecc-a154-eb05532954e4)
> 
<br>


<br>

## Snelstart (2 min)

### 1. Installeer je AI Gateway

```bash
# Draai de gateway lokaal (vereist Node.js en npm)
npx @portkey-ai/gateway
```
> De Gateway draait op `http://localhost:8787/v1`
> 
> De Gateway Console draait op `http://localhost:8787/public/`

<sup>
Deployments gidsen:
&nbsp; <a href="https://portkey.wiki/gh-18"><img height="12" width="12" src="https://cfassets.portkey.ai/logo/dew-color.svg" /> Portkey Cloud (Aanbevolen)</a>
&nbsp; <a href="./docs/installation-deployments.md#docker"><img height="12" width="12" src="https://cdn.simpleicons.org/docker/3776AB" /> Docker</a>
&nbsp; <a href="./docs/installation-deployments.md#nodejs-server"><img height="12" width="12" src="https://cdn.simpleicons.org/node.js/3776AB" /> Node.js</a>
&nbsp; <a href="./docs/installation-deployments.md#cloudflare-workers"><img height="12" width="12" src="https://cdn.simpleicons.org/cloudflare/3776AB" /> Cloudflare</a>
&nbsp; <a href="./docs/installation-deployments.md#replit"><img height="12" width="12" src="https://cdn.simpleicons.org/replit/3776AB" /> Replit</a>
&nbsp; <a href="./docs/installation-deployments.md"> Overig...</a>

</sup>

### 2. Doe je eerste verzoek

<!-- <details open>
<summary>Python Voorbeeld</summary> -->
```python
# pip install -qU portkey-ai

from portkey_ai import Portkey

# OpenAI compatibele client
client = Portkey(
    provider="openai", # of 'anthropic', 'bedrock', 'groq', etc
    Authorization="sk-***" # de provider API sleutel
)

# Doe een verzoek via je AI Gateway
client.chat.completions.create(
    messages=[{"role": "user", "content": "What's the weather like?"}],
    model="gpt-4o-mini"
)
```



<sup>Ondersteunde bibliotheken:
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/javascript/3776AB" /> JS](https://portkey.wiki/gh-19)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/python/3776AB" /> Python](https://portkey.wiki/gh-20)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/gnubash/3776AB" /> REST](https://portkey.sh/gh-84)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/openai/3776AB" /> OpenAI SDKs](https://portkey.wiki/gh-21)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/langchain/3776AB" /> Langchain](https://portkey.wiki/gh-22)
&nbsp; [LlamaIndex](https://portkey.wiki/gh-23)
&nbsp; [Autogen](https://portkey.wiki/gh-24)
&nbsp; [CrewAI](https://portkey.wiki/gh-25)
&nbsp; [Meer..](https://portkey.wiki/gh-26)
</sup>

Op de Gateway Console (`http://localhost:8787/public/`) kun je al je lokale logs op één plek bekijken.

<img src="https://github.com/user-attachments/assets/362bc916-0fc9-43f1-a39e-4bd71aac4a3a" width="400" />


### 3. Routing & Guardrails
`Configs` in de LLM gateway stellen je in staat om routeringsregels te maken, betrouwbaarheid toe te voegen en guardrails in te stellen.
```python
config = {
  "retry": {"attempts": 5},

  "output_guardrails": [{
    "default.contains": {"operator": "none", "words": ["Apple"]},
    "deny": True
  }]
}

# Voeg de config toe aan de client
client = client.with_options(config=config)

client.chat.completions.create(
    model="gpt-4o-mini",
    messages=[{"role": "user", "content": "Reply randomly with Apple or Bat"}]
)

# Dit zal altijd antwoorden met "Bat" omdat de guardrail alle antwoorden met "Apple" weigert. De retry-config zal 5 keer opnieuw proberen voordat hij opgeeft.
```
<div align="center">
<img src="https://portkey.ai/blog/content/images/size/w1600/2024/11/image-15.png" width=600 title="Verzoekflow door Portkey's AI gateway met retries en guardrails" alt="Verzoekflow door Portkey's AI gateway met retries en guardrails"/>
</div>

Je kunt nog veel meer doen met configs in je AI gateway. [Ga naar voorbeelden  →](https://portkey.wiki/gh-27)

<br/>

### Enterprise Versie (Private deployments)

<sup>

[<img height="12" width="12" src="https://cfassets.portkey.ai/amazon-logo.svg" /> AWS](https://portkey.wiki/gh-28)
&nbsp; [<img height="12" width="12" src="https://cfassets.portkey.ai/azure-logo.svg" /> Azure](https://portkey.wiki/gh-29)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/googlecloud/3776AB" /> GCP](https://portkey.wiki/gh-30)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/redhatopenshift/3776AB" /> OpenShift](https://portkey.wiki/gh-31)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/kubernetes/3776AB" /> Kubernetes](https://portkey.wiki/gh-85)

</sup>

De [enterprise versie](https://portkey.wiki/gh-86) van de LLM Gateway biedt geavanceerde mogelijkheden voor **organisatiebeheer**, **governance**, **beveiliging** en [meer](https://portkey.wiki/gh-87) direct uit de doos. [Bekijk Feature Vergelijking →](https://portkey.wiki/gh-32)

De enterprise deployment architectuur voor ondersteunde platforms is hier beschikbaar - [**Enterprise Private Cloud Deployments**](https://portkey.wiki/gh-33)

<a href="https://portkey.sh/demo-13"><img src="https://portkey.ai/blog/content/images/2024/08/Get-API-Key--5-.png" height=50 alt="Boek een enterprise AI gateway demo" /></a><br/>


<br>

<hr>

### AI Engineering Uren

Neem deel aan wekelijkse community calls elke vrijdag (8 uur PT) om je AI Gateway implementatie te starten! [Elke vrijdag](https://portkey.wiki/gh-35)

<a href="https://portkey.wiki/gh-35"><img width="500" src="https://github.com/user-attachments/assets/c2885699-f197-4289-b819-21eb839fbae1" /></a>

Notulen van de vergaderingen [hier gepubliceerd](https://portkey.wiki/gh-36).


<hr>

### LLMs in Productie'25

Inzichten uit analyse van meer dan 2 biljoen tokens, verspreid over 90+ regio's en 650+ teams in productie. Wat je van dit rapport kunt verwachten:
- Trends die AI-adoptie en groei van LLM-aanbieders vormgeven.
- Benchmarks om snelheid, kosten en betrouwbaarheid te optimaliseren.
- Strategieën om productieklare AI-systemen op te schalen.

<a href="https://portkey.sh/report-github"><img width="500" src="https://raw.githubusercontent.com/siddharthsambharia-portkey/Portkey-Product-Images/refs/heads/main/LLM%20Report%20Campaign%20Image.png" /></a>

<a href="https://portkey.sh/report-github">**Ontvang het Rapport**</a>
<hr>


## Kernfunctionaliteiten
### Betrouwbare Routering
- <a href="https://portkey.wiki/gh-37">**Fallbacks**</a>: Vallen op een andere provider of model bij mislukte verzoeken via de LLM-gateway. Je kunt de fouten specificeren waarop de fallback moet worden geactiveerd. Verhoogt de betrouwbaarheid van je applicatie.
- <a href="https://portkey.wiki/gh-38">**Automatische Herhalingen**</a>: Mislukte verzoeken automatisch tot 5 keer opnieuw proberen. Een exponentiële backoff-strategie spreidt de herhalingspogingen om netwerkoverbelasting te voorkomen.
- <a href="https://portkey.wiki/gh-39">**Load Balancing**</a>: Verspreid LLM-verzoeken over meerdere API-sleutels of AI-providers met gewichten om hoge beschikbaarheid en optimale prestaties te garanderen.
- <a href="https://portkey.wiki/gh-40">**Request Timeouts**</a>: Beheer onhandelbare LLM's & latenties door gedetailleerde request timeouts in te stellen, waarmee verzoeken die een bepaalde duur overschrijden automatisch worden beëindigd.
- <a href="https://portkey.wiki/gh-41">**Multi-modale LLM Gateway**</a>: Roep vision-, audio- (tekst-naar-spraak & spraak-naar-tekst) en beeldgeneratiemodellen aan van meerdere providers — allemaal met de vertrouwde OpenAI-signature.
- <a href="https://portkey.wiki/gh-42">**Realtime API's**</a>: Roep realtime API's aan die door OpenAI zijn gelanceerd via de geïntegreerde websockets-server.

### Veiligheid & Nauwkeurigheid
- <a href="https://portkey.wiki/gh-88">**Guardrails**</a>: Controleer je LLM-inputs en -outputs om te voldoen aan je opgegeven controles. Kies uit de 40+ vooraf gebouwde guardrails om te voldoen aan beveiligings- en nauwkeurigheidsnormen. Je kunt <a href="https://portkey.wiki/gh-43">je eigen guardrails toevoegen</a> of kiezen uit onze <a href="https://portkey.wiki/gh-44">vele partners</a>.
- [**Veilig Sleutelbeheer**](https://portkey.wiki/gh-45): Gebruik je eigen sleutels of genereer virtuele sleutels on-the-fly.
- [**Rolgebaseerde toegangscontrole**](https://portkey.wiki/gh-46): Gedetailleerde toegangscontrole voor je gebruikers, workspaces en API-sleutels.
- <a href="https://portkey.wiki/gh-47">**Compliance & Gegevensprivacy**</a>: De AI-gateway voldoet aan SOC2, HIPAA, GDPR en CCPA.

### Kostenbeheer
- [**Slimme caching**](https://portkey.wiki/gh-48): Cache antwoorden van LLM's om kosten te verlagen en latentie te verbeteren. Ondersteunt eenvoudige en semantische* caching.
- [**Gebruik Analytics**](https://portkey.wiki/gh-49): Monitor en analyseer je AI- en LLM-gebruik, inclusief het aantal verzoeken, latentie, kosten en foutpercentages.
- [**Provider optimalisatie***](https://portkey.wiki/gh-89): Schakel automatisch over naar de meest kosteneffectieve provider op basis van gebruikspatronen en prijsmodellen.

### Samenwerking & Workflows
- <a href="https://portkey.ai/docs/integrations/agents">**Agents Support**</a>: Integreer naadloos met populaire agent-frameworks om complexe AI-applicaties te bouwen. De gateway integreert naadloos met [Autogen](https://portkey.wiki/gh-50), [CrewAI](https://portkey.wiki/gh-51), [LangChain](https://portkey.wiki/gh-52), [LlamaIndex](https://portkey.wiki/gh-53), [Phidata](https://portkey.wiki/gh-54), [Control Flow](https://portkey.wiki/gh-55), en zelfs [Custom Agents](https://portkey.wiki/gh-56).
- [**Prompt Template Management***](https://portkey.wiki/gh-57): Maak, beheer en versieer je prompt-templates gezamenlijk via een universele prompt-playground.
<br/><br/>

<sup>
*&nbsp;Beschikbaar in hosted en enterprise versies
</sup>

<br>

## Kookboeken

### ☄️ Trending
- Gebruik modellen van [Nvidia NIM](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/providers/nvidia.ipynb) met AI Gateway
- Monitor [CrewAI Agents](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/monitoring-agents/CrewAI_with_Telemetry.ipynb) met Portkey!
- Vergelijk [Top 10 LMSYS Modellen](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/use-cases/LMSYS%20Series/comparing-top10-LMSYS-models-with-Portkey.ipynb) met AI Gateway.

### 🚨 Laatste
* [Maak synthetische datasets met Nemotron](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/use-cases/Nemotron_GPT_Finetuning_Portkey.ipynb)
* [Gebruik de LLM Gateway met Vercel's AI SDK](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/integrations/vercel-ai.md)
* [Monitor Llama Agents met Portkey's LLM Gateway](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/monitoring-agents/Llama_Agents_with_Telemetry.ipynb)

[Bekijk alle kookboeken →](https://portkey.wiki/gh-58)
<br/><br/>

## Ondersteunde Providers

Ontdek Gateway-integraties met [45+ providers](https://portkey.wiki/gh-59) en [8+ agent-frameworks](https://portkey.wiki/gh-90).

|                                                                                                                            | Provider                                                                                      | Ondersteuning | Stream |
| -------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | ------------- | ------ |
| <img src="docs/images/openai.png" width=35 />                                                                              | [OpenAI](https://portkey.wiki/gh-60)                           | ✅             | ✅      |
| <img src="docs/images/azure.png" width=35>                                                                                 | [Azure OpenAI](https://portkey.wiki/gh-61)               | ✅             | ✅      |
| <img src="docs/images/anyscale.png" width=35>                                                                              | [Anyscale](https://portkey.wiki/gh-62) | ✅             | ✅      |
| <img src="https://upload.wikimedia.org/wikipedia/commons/2/2d/Google-favicon-2015.png" width=35>                           | [Google Gemini](https://portkey.wiki/gh-63)             | ✅             | ✅      |
| <img src="docs/images/anthropic.png" width=35>                                                                             | [Anthropic](https://portkey.wiki/gh-64)                     | ✅             | ✅      |
| <img src="docs/images/cohere.png" width=35>                                                                                | [Cohere](https://portkey.wiki/gh-65)                           | ✅             | ✅      |
| <img src="https://assets-global.website-files.com/64f6f2c0e3f4c5a91c1e823a/654693d569494912cfc0c0d4_favicon.svg" width=35> | [Together AI](https://portkey.wiki/gh-66)                 | ✅             | ✅      |
| <img src="https://www.perplexity.ai/favicon.svg" width=35>                                                                 | [Perplexity](https://portkey.wiki/gh-67)                | ✅             | ✅      |
| <img src="https://docs.mistral.ai/img/favicon.ico" width=35>                                                               | [Mistral](https://portkey.wiki/gh-68)                      | ✅             | ✅      |
| <img src="https://docs.nomic.ai/img/nomic-logo.png" width=35>                                                              | [Nomic](https://portkey.wiki/gh-69)                             | ✅             | ✅      |
| <img src="https://files.readme.io/d38a23e-small-studio-favicon.png" width=35>                                              | [AI21](https://portkey.wiki/gh-91)                                    | ✅             | ✅      |
| <img src="https://platform.stability.ai/small-logo-purple.svg" width=35>                                                   | [Stability AI](https://portkey.wiki/gh-71)               | ✅             | ✅      |
| <img src="https://deepinfra.com/_next/static/media/logo.4a03fd3d.svg" width=35>                                            | [DeepInfra](https://portkey.sh/gh-92)                               | ✅             | ✅      |
| <img src="https://ollama.com/public/ollama.png" width=35>                                                                  | [Ollama](https://portkey.wiki/gh-72)                           | ✅             | ✅      |
| <img src="https://novita.ai/favicon.ico" width=35>                                                                         | [Novita AI](https://portkey.wiki/gh-73)                              | ✅             | ✅      | `/chat/completions`, `/completions` |


> [Bekijk de volledige lijst van 200+ ondersteunde modellen hier](https://portkey.wiki/gh-74)
<br>

<br>

## Agents
Gateway integreert naadloos met populaire agent-frameworks. [Lees de documentatie hier](https://portkey.wiki/gh-75).


| Framework | Bel 200+ LLMs | Geavanceerde Routing | Caching | Logging & Tracing* | Observability* | Promptbeheer* |
|------------------------------|--------|---------------------|---------|------------------|---------------|--------------|
| [Autogen](https://portkey.wiki/gh-93)    | ✅     | ✅                  | ✅      | ✅              | ✅            | ✅           |
| [CrewAI](https://portkey.wiki/gh-94)             | ✅     | ✅                  | ✅      | ✅              | ✅            | ✅           |
| [LangChain](https://portkey.wiki/gh-95)             | ✅     | ✅                  | ✅      | ✅              | ✅            | ✅           |
| [Phidata](https://portkey.wiki/gh-96)             | ✅     | ✅                  | ✅      | ✅              | ✅            | ✅           |
| [Llama Index](https://portkey.wiki/gh-97)             | ✅     | ✅                  | ✅      | ✅              | ✅            | ✅           |
| [Control Flow](https://portkey.wiki/gh-98) | ✅     | ✅                  | ✅      | ✅              | ✅            | ✅           |
| [Bouw je eigen Agents](https://portkey.wiki/gh-99) | ✅     | ✅                  | ✅      | ✅              | ✅            | ✅           |

<br>

*Beschikbaar op de [gehoste app](https://portkey.wiki/gh-76). Voor gedetailleerde documentatie [klik hier](https://portkey.wiki/gh-100).


## Gateway Enterprise Versie
Maak je AI-app <ins>betrouwbaarder</ins> en <ins>toekomstbestendig</ins>, terwijl je volledige <ins>gegevensbeveiliging</ins> en <ins>privacy</ins> waarborgt.

✅&nbsp; Veilig Sleutelbeheer - voor rolgebaseerde toegangscontrole en tracking <br>
✅&nbsp; Eenvoudige & Semantische Caching - om herhaalde queries sneller te bedienen & kosten te besparen <br>
✅&nbsp; Toegangscontrole & Inkomende Regels - om te bepalen welke IP's en regio's verbinding kunnen maken met je deployments <br>
✅&nbsp; PII Redactie - om automatisch gevoelige gegevens uit je verzoeken te verwijderen en onbedoelde blootstelling te voorkomen <br>
✅&nbsp; SOC2, ISO, HIPAA, GDPR Compliances - voor de beste beveiligingspraktijken <br>
✅&nbsp; Professionele Ondersteuning - inclusief functieprioritering <br>

[Plan een gesprek om enterprise deployments te bespreken](https://portkey.sh/demo-13)

<br>


## Bijdragen

De makkelijkste manier om bij te dragen is door een issue met het label `good first issue` te kiezen 💪. Lees de bijdrage-richtlijnen [hier](https://raw.githubusercontent.com/Portkey-AI/gateway/main/.github/CONTRIBUTING.md).

Bug melden? [Dien hier in](https://portkey.wiki/gh-78) | Functieaanvraag? [Dien hier in](https://portkey.wiki/gh-78)


### Aan de slag met de Community
Doe mee met onze wekelijkse AI Engineering Hours elke vrijdag (8:00 uur PT) om:
- Andere bijdragers en communityleden te ontmoeten
- Geavanceerde Gateway-functies en implementatiepatronen te leren
- Je ervaringen te delen en hulp te krijgen
- Op de hoogte te blijven van de laatste ontwikkelprioriteiten

[Doe mee aan de volgende sessie →](https://portkey.wiki/gh-101) | [Notulen](https://portkey.wiki/gh-102)

<br>

## Community

Word lid van onze groeiende community over de hele wereld, voor hulp, ideeën en discussies over AI.

- Bekijk onze officiële [Blog](https://portkey.wiki/gh-78)
- Chat met ons op [Discord](https://portkey.wiki/community)
- Volg ons op [Twitter](https://portkey.wiki/gh-79)
- Connect met ons op [LinkedIn](https://portkey.wiki/gh-80)
- Lees de documentatie in het [Japans](https://raw.githubusercontent.com/Portkey-AI/gateway/main/.github/README.jp.md)
- Bezoek ons op [YouTube](https://portkey.wiki/gh-103)
- Word lid van onze [Dev community](https://portkey.wiki/gh-82)
<!-- - Vragen met #portkey op [Stack Overflow](https://stackoverflow.com/questions/tagged/portkey) -->

![Rubeus Social Share (4)](https://github.com/Portkey-AI/gateway/assets/971978/89d6f0af-a95d-4402-b451-14764c40d03f)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---
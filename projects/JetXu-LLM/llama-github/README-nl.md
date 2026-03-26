
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ja">Japans</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ko">Koreaans</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=th">Thais</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=fa">Perzisch</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=id">Indonesisch</a>
      </div>
    </div>
  </details>
</div>

# llama-github

[Gedetailleerd Document] https://deepwiki.com/JetXu-LLM/llama-github

[![PyPI versie](https://badge.fury.io/py/llama-github.svg)](https://badge.fury.io/py/llama-github)
[![Downloads](https://static.pepy.tech/badge/Llama-github)](https://pepy.tech/project/Llama-github)
[![Licentie](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)

Llama-github is een krachtig hulpmiddel dat je helpt om (gebaseerd op Agentic RAG) de meest relevante codefragmenten, issues en repository-informatie van GitHub op te halen op basis van je zoekopdrachten en deze te transformeren naar waardevolle kenniscontext. Het stelt LLM-chatbots, AI-agenten en Auto-dev-agenten in staat om complexe programmeertaken op te lossen. Of je nu een ontwikkelaar bent die op zoek is naar snelle oplossingen of een ingenieur die geavanceerde Auto Dev AI-agenten implementeert, llama-github maakt het eenvoudig en efficiënt.

Als je dit project leuk vindt of denkt dat het potentieel heeft, geef het dan een ⭐️. Jouw steun is onze grootste motivatie!

## Architectuur
![Hoog Niveau Architectuur](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/high_level_architecture.drawio.svg)

## Installatie
```
pip install llama-github
```

Huidig ondersteund runtime-doel: Python `3.10+`.

## Gebruik

Hier is een eenvoudig voorbeeld van hoe je llama-github gebruikt:

```python
from llama_github import GithubRAG

# Initialize GithubRAG with your credentials
github_rag = GithubRAG(
    github_access_token="your_github_access_token", 
    openai_api_key="your_openai_api_key", # Optional in Simple Mode
    jina_api_key="your_jina_api_key" # Optional - unless you want high concurrency production deployment (s.jina.ai API will be used in llama-github)
)

# Retrieve context for a coding question (simple_mode is default set to False)
query = "How to create a NumPy array in Python?"
contexts = github_rag.retrieve_context(
    query,
    # simple_mode = True
)

print(contexts[0]["url"])
print(contexts[0]["context"])
```

`retrieve_context()` retourneert een lijst met contextwoordenboeken. Elk item bevat ten minste `context` en `url`.

Voor meer geavanceerd gebruik en voorbeelden, raadpleeg de [documentatie](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/docs/usage.md). Uitvoerbare, goedkope voorbeelden zijn ook beschikbaar in [`examples/`](examples).

## Belangrijkste Kenmerken

- **🔍 Intelligente GitHub-ophaling**: Maak gebruik van de kracht van llama-github om zeer relevante codefragmenten, issues en repository-informatie van GitHub op te halen op basis van gebruikersvragen. Onze geavanceerde ophaaltechnieken zorgen ervoor dat je snel en efficiënt de meest relevante informatie vindt.

- **⚡ Repository Pool Caching**: Llama-github beschikt over een innovatief repository pool caching-mechanisme. Door repositories (inclusief READMEs, structuren, code en issues) over threads te cachen, versnelt llama-github aanzienlijk de efficiëntie van GitHub-zoekopdrachten en minimaliseert het het verbruik van GitHub API-tokens.

- **🧠 LLM-aangedreven Vraaganalyse**: Maak gebruik van de nieuwste taalmodellen om gebruikersvragen te analyseren en uiterst effectieve zoekstrategieën en criteria te genereren. Llama-github breekt complexe vragen intelligent op, zodat je de meest relevante informatie uit het enorme netwerk van GitHub-repositories ophaalt.

- **📚 Uitgebreide Contextgeneratie**: Genereer rijke, contextueel relevante antwoorden door naadloos informatie van GitHub te combineren met de redeneercapaciteiten van geavanceerde taalmodellen. Llama-github blinkt uit in het afhandelen van zelfs de meest complexe en lange vragen en biedt uitgebreide, inzichtelijke antwoorden met veel context om je ontwikkelingsbehoeften te ondersteunen.

- **🚀 Uitmuntende Asynchrone Verwerking**: Llama-github is vanaf de basis opgebouwd om het volledige potentieel van asynchroon programmeren te benutten. Met zorgvuldig geïmplementeerde asynchrone mechanismen door de hele codebase kan llama-github meerdere verzoeken gelijktijdig afhandelen, wat de algehele prestaties aanzienlijk verhoogt.

- **🔧 Flexibele LLM-integratie**: Integreer llama-github eenvoudig met verschillende LLM-providers, embed-modellen, reranking-modellen, of een geïnjecteerd LangChain-compatibel chatmodel om de mogelijkheden van de bibliotheek af te stemmen op jouw specifieke wensen.

- **🔒 Robuuste Authenticatieopties**: Llama-github ondersteunt zowel persoonlijke toegangstokens als GitHub App-authenticatie en biedt je de flexibiliteit om het te integreren in verschillende ontwikkelomgevingen. Of je nu een individuele ontwikkelaar bent of binnen een organisatie werkt, llama-github biedt veilige en betrouwbare authenticatiemechanismen.

- **🛠️ Logging en Foutafhandeling**: We begrijpen het belang van soepele operaties en eenvoudig probleemoplossen. Daarom is llama-github uitgerust met uitgebreide logging- en foutafhandelingsmechanismen. Krijg diepgaand inzicht in het gedrag van de bibliotheek, diagnoseer problemen snel en behoud een stabiele en betrouwbare ontwikkelworkflow.

## 🤖 Probeer Onze AI-aangedreven PR Review Assistant: LlamaPReview

Als je llama-github handig vindt, ben je misschien ook geïnteresseerd in onze AI-aangedreven GitHub PR review assistant, LlamaPReview. Het is ontworpen om je ontwikkelworkflow aan te vullen en de codekwaliteit verder te verbeteren.

### Belangrijkste Kenmerken van LlamaPReview:
- 🚀 Installatie met één klik, geen configuratie vereist, volledig automatisch
- 💯 Momenteel gratis te gebruiken - geen creditcard of betaalinformatie nodig
- 🧠 AI-aangedreven, automatische PR-reviews met diepgaand codebegrip
- 🌐 Ondersteunt meerdere programmeertalen

**LlamaPReview maakt gebruik van llama-github’s geavanceerde contextophaling en LLM-aangedreven analyse** om intelligente, contextbewuste codebeoordelingen te bieden. Het is alsof je een senior developer hebt, bewapend met de volledige context van je repository, die elke PR automatisch beoordeelt!

👉 [Installeer LlamaPReview Nu](https://github.com/marketplace/llamapreview/) (Gratis)

Door llama-github te gebruiken voor contextophaling en LlamaPReview voor codebeoordelingen, kun je een krachtig, AI-verrijkt ontwikkelomgeving creëren.

## Visie en Routekaart

### Visie

Onze visie is om een cruciale module te worden in de toekomst van AI-gedreven ontwikkelingsoplossingen, die naadloos integreert met GitHub om LLMs in staat te stellen automatisch complexe programmeertaken op te lossen.

![Visie Architectuur](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/vision.drawio.svg)

### Routekaart

Voor een historisch overzicht van de eerdere routekaart, bezoek [Visie en Routekaart](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/VISION_AND_ROADMAP.md).

## Erkenningen

Wij willen onze dank uitspreken aan de volgende open-source projecten voor hun steun en bijdragen:

- **[LangChain](https://github.com/langchain-ai/langchain)**: Voor het bieden van het basisframework dat de LLM prompting- en verwerkingsmogelijkheden in llama-github mogelijk maakt.
- **[Jina.ai](https://github.com/jina-ai/reader)**: Voor het aanbieden van de s.jina.ai API en open source reranker- en embed-modellen die de nauwkeurigheid en relevantie van de gegenereerde contexten in llama-github verhogen.

Hun bijdragen zijn van groot belang geweest voor de ontwikkeling van llama-github, en wij raden aan om hun projecten te bekijken voor meer innovatieve oplossingen.

## Bijdragen

Bijdragen aan llama-github zijn welkom! Zie onze [bijdragende richtlijnen](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/CONTRIBUTING.md) voor meer informatie.

## Licentie

Dit project valt onder de voorwaarden van de Apache 2.0 licentie. Zie het [LICENSE](LICENSE) bestand voor meer details.

## Contact

Als u vragen, suggesties of feedback heeft, neem dan gerust contact met ons op via [Jet Xu's e-mail](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/mailto:Voldemort.xu@foxmail.com).

---

Bedankt voor het kiezen van llama-github! We hopen dat deze bibliotheek uw AI-ontwikkelervaring verrijkt en u helpt krachtige applicaties eenvoudig te bouwen.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-26

---
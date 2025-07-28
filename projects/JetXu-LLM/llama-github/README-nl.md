
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
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=hi">हिन्दी</a>
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
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# llama-github

[Gedetailleerd Document] https://deepwiki.com/JetXu-LLM/llama-github

[![PyPI versie](https://badge.fury.io/py/llama-github.svg)](https://badge.fury.io/py/llama-github)
[![Downloads](https://static.pepy.tech/badge/Llama-github)](https://pepy.tech/project/Llama-github)
[![Licentie](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)

Llama-github is een krachtig hulpmiddel dat je helpt (op basis van Agentic RAG) de meest relevante codefragmenten, issues en repository-informatie van GitHub op te halen aan de hand van jouw zoekopdrachten en ze te transformeren in waardevolle kenniscontext. Het stelt LLM-chatbots, AI-agenten en Auto-dev-agenten in staat om complexe programmeertaken op te lossen. Of je nu een ontwikkelaar bent die snel oplossingen zoekt, of een ingenieur die geavanceerde Auto Dev AI Agents implementeert, llama-github maakt het eenvoudig en efficiënt.

Als je dit project leuk vindt of denkt dat het potentie heeft, geef het dan een ⭐️. Jouw steun is onze grootste motivatie!

## Architectuur
![Hoog Niveau Architectuur](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/high_level_architecture.drawio.svg)

## Installatie
```
pip install llama-github
```

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
context = github_rag.retrieve_context(
    query, # In professional mode, one query will take nearly 1 min to generate final contexts. You could set log level to INFO to monitor the retrieval progress
    # simple_mode = True
)

print(context)
```

Voor meer geavanceerd gebruik en voorbeelden, raadpleeg de [documentatie](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/docs/usage.md).

## Belangrijkste Kenmerken

- **🔍 Intelligente GitHub-Opvraging**: Maak gebruik van de kracht van llama-github om uiterst relevante codefragmenten, issues en repository-informatie van GitHub op te halen op basis van gebruikersvragen. Onze geavanceerde opvraagtechnieken zorgen ervoor dat je snel en efficiënt de meest relevante informatie vindt.

- **⚡ Repository Pool Caching**: Llama-github beschikt over een innovatief repository pool caching-mechanisme. Door repositories (inclusief READMEs, structuren, code en issues) over threads te cachen, versnelt llama-github aanzienlijk de efficiëntie van GitHub-zoekopdrachten en minimaliseert het het gebruik van GitHub API-tokens. Zet llama-github met vertrouwen in in multi-threaded productieomgevingen, wetende dat het optimaal presteert en waardevolle middelen bespaart.

- **🧠 LLM-Gestuurde Vraaganalyse**: Maak gebruik van geavanceerde taalmodellen om gebruikersvragen te analyseren en uiterst doeltreffende zoekstrategieën en criteria te genereren. Llama-github breekt complexe vragen intelligent op, zodat je de meest relevante informatie uit GitHub's uitgebreide repository-netwerk ophaalt.

- **📚 Uitgebreide Contextgeneratie**: Genereer rijke, contextueel relevante antwoorden door naadloos informatie van GitHub te combineren met de redeneercapaciteiten van geavanceerde taalmodellen. Llama-github blinkt uit in het behandelen van zelfs de meest complexe en lange vragen, en levert uitgebreide en inzichtelijke antwoorden die rijk zijn aan context voor jouw ontwikkelbehoeften.

- **🚀 Uitmuntende Asynchrone Verwerking**: Llama-github is vanaf de basis opgebouwd om optimaal te profiteren van asynchroon programmeren. Dankzij zorgvuldig geïmplementeerde asynchrone mechanismen door de hele codebase kan llama-github meerdere verzoeken tegelijk verwerken, wat de totale prestaties aanzienlijk verhoogt. Ervaar het verschil terwijl llama-github efficiënt grote werklasten beheert zonder concessies te doen aan snelheid of kwaliteit.

- **🔧 Flexibele LLM-Integratie**: Integreer eenvoudig llama-github met verschillende LLM-providers, embedding-modellen en reranking-modellen om de mogelijkheden van de bibliotheek af te stemmen op jouw specifieke wensen. Onze uitbreidbare architectuur maakt het mogelijk om de functionaliteit van llama-github aan te passen en uit te breiden, zodat deze naadloos aansluit op jouw unieke ontwikkelomgeving.

- **🔒 Robuuste Authenticatieopties**: Llama-github ondersteunt zowel personal access tokens als GitHub App-authenticatie, zodat je het flexibel kunt integreren in verschillende ontwikkelomgevingen. Of je nu een individuele ontwikkelaar bent of binnen een organisatie werkt, llama-github biedt veilige en betrouwbare authenticatiemechanismen.

- **🛠️ Logging en Foutafhandeling**: Wij begrijpen het belang van soepele werking en eenvoudig probleemoplossen. Daarom is llama-github uitgerust met uitgebreide logging- en foutafhandelingsmechanismen. Krijg diepgaand inzicht in het gedrag van de bibliotheek, diagnoseer snel problemen en onderhoud een stabiele en betrouwbare ontwikkelworkflow.

## 🤖 Probeer Onze AI-PR-Review Assistent: LlamaPReview

Als je llama-github nuttig vindt, ben je misschien ook geïnteresseerd in onze AI-aangedreven GitHub PR review-assistent, LlamaPReview. Deze is ontworpen om jouw ontwikkelworkflow aan te vullen en de codekwaliteit verder te verbeteren.

### Belangrijkste Kenmerken van LlamaPReview:
- 🚀 Installatie met één klik, geen configuratie nodig, volledig automatisch
- 💯 Momenteel gratis te gebruiken - geen creditcard of betaalinformatie vereist
- 🧠 AI-gestuurde, automatische PR-reviews met diepgaand code-inzicht
- 🌐 Ondersteunt meerdere programmeertalen

**LlamaPReview maakt gebruik van de geavanceerde contextopvraging en LLM-analyse van llama-github** om intelligente, contextbewuste code-reviews te bieden. Het is alsof je een senior ontwikkelaar hebt die, gewapend met de volledige context van jouw repository, elke PR automatisch beoordeelt!

👉 [Installeer LlamaPReview Nu](https://github.com/marketplace/llamapreview/) (Gratis)

Door llama-github te gebruiken voor contextopvraging en LlamaPReview voor code-reviews, kun je een krachtige, AI-verrijkte ontwikkelomgeving creëren.

## Visie en Routekaart

### Visie

Onze visie is om een essentieel onderdeel te worden van de toekomst van AI-gedreven ontwikkeloplossingen, naadloos geïntegreerd met GitHub om LLM's in staat te stellen automatisch complexe coderingstaken op te lossen.

![Vision Architecture](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/vision.drawio.svg)

### Routekaart

Voor een gedetailleerd overzicht van onze projectroutekaart, bezoek onze [Project Roadmap](https://github.com/users/JetXu-LLM/projects/2).

## Dankbetuigingen

Wij willen onze dank uitspreken aan de volgende open-sourceprojecten voor hun steun en bijdragen:

- **[LangChain](https://github.com/langchain-ai/langchain)**: Voor het bieden van het fundamentele framework dat de LLM-prompting- en verwerkingsmogelijkheden in llama-github aandrijft.
- **[Jina.ai](https://github.com/jina-ai/reader)**: Voor het aanbieden van de s.jina.ai API en open source reranker- en embedding-modellen die de nauwkeurigheid en relevantie van de gegenereerde contexten in llama-github verbeteren.

Hun bijdragen zijn van essentieel belang geweest voor de ontwikkeling van llama-github, en we raden aan hun projecten te bekijken voor meer innovatieve oplossingen.

## Bijdragen

We verwelkomen bijdragen aan llama-github! Zie onze [richtlijnen voor bijdragen](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/CONTRIBUTING.md) voor meer informatie.

## Licentie

Dit project is gelicentieerd onder de voorwaarden van de Apache 2.0-licentie. Zie het [LICENSE](LICENSE) bestand voor meer details.

## Contact

Als je vragen, suggesties of feedback hebt, neem dan gerust contact met ons op via [Jet Xu's e-mail](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/mailto:Voldemort.xu@foxmail.com).

---

Bedankt dat je voor llama-github hebt gekozen! We hopen dat deze bibliotheek je AI-ontwikkelervaring verbetert en je helpt krachtige applicaties eenvoudig te bouwen.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-28

---
![note-gen](https://socialify.git.ci/codexu/note-gen/image?custom_description=Cross-Platform+%7C+LLM+%7C+Markdown+%7C++Recording++%26+Writing&description=1&font=Raleway&forks=1&issues=1&logo=https%3A%2F%2Fcamo.githubusercontent.com%2Fbe4a3a39f8724658ad5bc549d63f0454ad4ca98564c73b7b0778704ca5212509%2F68747470733a2f2f73322e6c6f6c692e6e65742f323032352f30352f32362f594d4e67784b5644724238345a74572e706e67&name=1&owner=1&pattern=Circuit+Board&stargazers=1&theme=Light)

# NoteGen

![](https://github.com/codexu/note-gen/actions/workflows/release.yml/badge.svg?branch=release)
![](https://img.shields.io/github/v/release/codexu/note-gen)
![](https://img.shields.io/badge/version-alpha-orange)
![](https://img.shields.io/github/downloads/codexu/note-gen/total)
![](https://img.shields.io/github/commit-activity/m/codexu/note-gen)

Engels | [简体中文](.github/README.zh.md) | [日本語](.github/README.ja.md)

<div style="display: flex; gap: 1rem;">
  <a href="https://www.producthunt.com/products/notegen-2?embed=true&utm_source=badge-featured&utm_medium=badge&utm_source=badge-notegen&#0045;2" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=956348&theme=light&t=1749194675492" alt="NoteGen - A&#0032;cross&#0045;platform&#0032;Markdown&#0032;note&#0045;taking&#0032;application | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

  <a href="https://trendshift.io/repositories/12784" target="_blank"><img src="https://trendshift.io/api/badge/repositories/12784" alt="codexu%2Fnote-gen | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a>
</div>

## Handleiding

NoteGen is een cross-platform `Markdown` notitie-applicatie die zich toelegt op het gebruik van AI om opname en schrijven te overbruggen, en gefragmenteerde kennis te organiseren tot een leesbare notitie.

🖥️ Officiële Documentatie: [https://notegen.top](https://notegen.top)

💬 Word lid van de [WeChat/QQ Groep](https://github.com/codexu/note-gen/discussions/110)

## Waarom kiezen voor NoteGen?

- Lichtgewicht: [Installatiepakket](https://github.com/codexu/note-gen/releases) is **slechts 20MB**, gratis zonder advertenties of gebundelde software.
- Cross-platform: Ondersteunt Mac, Windows, Linux, en dankzij de cross-platform mogelijkheden van `Tauri2` zullen iOS en Android in de toekomst ondersteund worden.
- Ondersteunt meerdere opname methoden, waaronder `schermafbeeldingen`, `tekst`, `illustraties`, `bestanden`, `links`, enz., voor gefragmenteerde opnamebehoeften in diverse scenario's.
- Native `Markdown(.md)` als opslagformaat, geen aanpassingen, makkelijk te migreren.
- Native offline gebruik, met real-time synchronisatie naar `GitHub, Gitee privé-repositories` met geschiedenis-terugzetfunctie, en WebDAV-synchronisatie.
- AI-verbeterd: Configureerbaar met ChatGPT, Gemini, Ollama, LM Studio, Grok en andere modellen, met ondersteuning voor aangepaste derde partij modellen.
- RAG: Jouw notities zijn jouw kennisbank. Ondersteunt embedding modellen en reranking modellen.

## Screenshots

https://github.com/user-attachments/assets/4f8a3bc5-17f5-4b36-9b17-d87128685257

Opnemen:

![1.png](https://s2.loli.net/2025/05/19/Cs5viKfkqb2HJmd.png)

Schrijven:

![2.png](https://s2.loli.net/2025/05/19/5vwQBPoLr6jzgUA.png)

Thema:

![3.png](https://s2.loli.net/2025/05/19/8yU72prmWdsCHeu.png)

## Van Opnemen naar Schrijven

Conventionele notitie-applicaties bieden doorgaans geen opnamefunctionaliteit. Gebruikers moeten handmatig inhoud kopiëren en plakken om op te nemen, wat de efficiëntie aanzienlijk vermindert. Bij gefragmenteerde opgenomen inhoud kost het veel moeite om alles te organiseren.

NoteGen is verdeeld in `Opnemen` en `Schrijven` pagina’s, met de volgende relatie:

- Opnamen kunnen worden georganiseerd in notities en overgezet naar de schrijf-pagina voor diepgaande uitwerking.
- Tijdens het schrijven kun je op elk moment opnamen invoegen.

### Opnemen

De opneemfunctie lijkt op een **AI-chatbot**, maar tijdens het gesprek kun je deze koppelen aan eerder opgenomen inhoud, waarbij je van conversatiemodus naar organisatiemodus schakelt om opnamen te ordenen in een leesbare notitie.

De volgende hulpmiddelen helpen je effectiever opnemen:

- **Tags** om verschillende opnamescenario's te onderscheiden.
- **Persona’s** met ondersteuning voor aangepaste prompts om je AI-assistent nauwkeurig aan te sturen.
- **Klembordassistent** die automatisch tekst of afbeeldingen in je klembord herkent en toevoegt aan je lijst.

### Schrijven

Het schrijfgedeelte bestaat uit twee delen: **Bestandsbeheerder** en **Markdown Editor**.

**Bestandsbeheerder**

- Ondersteunt beheer van lokale Markdown-bestanden en met GitHub gesynchroniseerde bestanden.
- Ondersteunt onbeperkte mappenstructuur.
- Ondersteunt meerdere sorteermethoden.

**Markdown Editor**

- Ondersteunt WYSIWYG, directe weergave en gesplitst-scherm preview modi.
- Ondersteunt versiebeheer met geschiedenis-terugzetfunctie.
- Ondersteunt AI-assistentie voor gesprek, aanvullen, polijsten en vertaalfuncties.
- Ondersteunt image hosting, het uploaden van afbeeldingen en omzetten naar Markdown afbeeldingslinks.
- Ondersteunt HTML naar Markdown conversie, automatisch omzetten van gekopieerde browserinhoud naar Markdown.
- Ondersteunt outlines, wiskundige formules, mindmaps, grafieken, flowcharts, Gantt-diagrammen, sequentiediagrammen, notenbalken, multimedia, voorlezen, titelankers, code highlighting en kopiëren, graphviz rendering en plantuml UML-diagrammen.
- Ondersteunt real-time lokale opslag, vertraagde (10s zonder bewerking) automatische synchronisatie en geschiedenis-terugzetfunctie.

## Overige Functies

- Globale zoekfunctie om snel specifieke inhoud te vinden en te openen.
- Image hosting management voor eenvoudig beheer van je afbeeldingsrepository.
- Thema's en uiterlijk met ondersteuning voor donkere modus en weergave-instellingen voor Markdown, code, enz.
- Internationalisatie, momenteel beschikbaar in Chinees en Engels.

## Hoe te gebruiken?

### Downloaden

Momenteel worden Mac, Windows en Linux ondersteund. Dankzij de cross-platform mogelijkheden van Tauri2 zullen in de toekomst ook iOS en Android ondersteund worden.

[Download NoteGen (alpha)](https://github.com/codexu/note-gen/releases)

### Verbeteren

De notitie-app kan direct gebruikt worden zonder configuratie. Voor een betere ervaring kun je de instellingenpagina openen om AI en synchronisatie te configureren.

## Bijdragen

- [Lees de bijdragegids](https://raw.githubusercontent.com/codexu/note-gen/dev/.github/CONTRIBUTING.md)
- [Updateplannen](https://github.com/codexu/note-gen/issues/46)
- [Dien bugs of verbetersuggesties in](https://github.com/codexu/note-gen/issues)
- [Discussies](https://github.com/codexu/note-gen/discussions)

## Bijdragers

<a href="https://github.com/codexu/note-gen/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=codexu/note-gen" />
</a>

## Sterren Geschiedenis

[![Star History Chart](https://api.star-history.com/svg?repos=codexu/note-gen&type=Date)](https://www.star-history.com/#codexu/note-gen&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---
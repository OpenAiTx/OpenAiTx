<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=en">Engels</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=fr">Frans</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=de">Duits</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=es">Spaans</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=it">Italiaans</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ru">Russisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=pt">Portugees</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=pl">Pools</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ar">Arabisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=fa">Perzisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=tr">Turks</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=vi">Vietnamees</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

# AI Roman Editor

AI-ondersteunde romaneditor gebaseerd op PyQt6, biedt intelligente aanvulling, projectbeheer, conceptorganisatie en andere professionele schrijfhulpmiddelen.

## Installatie

1. Project klonen
```bash
git clone https://github.com/inliver233/Ai-Novel-Editor.git
cd ai-novel-editor
```

2. Virtuele omgeving aanmaken
```bash
python -m venv venv
venv\Scripts\activate     # Windows
```
Gebruik uv
```bash
uv venv -p 3.11
```
3. Installatie van afhankelijkheden
```bash
pip install -r requirements.txt
```
Gebruik uv
```bash
uv sync
```


4. Programma uitvoeren
```bash
python -m src
```

## Belangrijkste functionaliteiten

### Projectbeheer
- Hiërarchische documentstructuur (Werk > Hoofdstuk > Scène)
- Project importeren en exporteren (ondersteunt TEXT, MARKDOWN, DOCX, PDF, HTML formaten)
- Automatische back-up en versiebeheer
- Meerdere projecten beheren
### AI-aanvulfunctie
- Drie aanvulmodi: Automatisch aanvullen, Handmatig aanvullen (aanbevolen: één keer tab indrukken om te activeren, nogmaals tab om aanvulling toe te passen), Aanvullen uitschakelen
- Drie contextmodi:
  - Snelle modus: Lichtgewicht context, snelle respons
  - Gebalanceerde modus: Gemiddelde context, balans tussen kwaliteit en snelheid
  - Globale modus: Volledige projectcontext, beste resultaat
- Ondersteuning voor meerdere AI-diensten: OpenAI, Claude, Tongyi Qianwen, Zhipu AI, DeepSeek, Groq, enz.

### Overzichtsbeheer
- Visualiseerbare boomstructuur van het overzicht
- Sorteren en hiërarchie aanpassen via slepen en neerzetten
- Snelle navigatie door het document
- Analyse van het overzicht en optimalisatie-adviezen

### API-configuratie
- Uniform AI-configuratiecentrum
- Vooraf ingestelde configuraties voor meerdere aanbieders
- Verbindings-testfunctie
- Configuratieplannen opslaan en importeren/exporteren
### Instellingen voor slimme aanvulling
- Instelbare triggervertraging
- Limiet voor aanvulllengte
- Configuratie van contextlengte
- Ondersteuning voor streamingreacties

### Promptbewerking
- Ingebouwde schrijfsjablonen
- Aangepaste promptsjablonen
- Sjabloonbeheer per categorie
- Sjabloonconfiguratie voor specifieke modi

### Interfacefuncties
- Licht en donker thema
- Driekolomsindeling (projectboom, editor, conceptenpaneel)
- Inklapbare zijbalk
- Volledig scherm schrijfmodus
- Focusmodus (zin, alinea, typemachine, zenmodus, immersiemodus)

### Zoeken en vervangen
- Volledige projecttekst doorzoeken
- Ondersteuning voor reguliere expressies
- Functie voor batchvervanging
- Geavanceerde zoekopties

### Conceptbeheer
- Automatische detectie van rollen, locaties, objecten
- Relatiebeheer van concepten
- Tag- en classificatiesysteem
- Snelle invoeging van concepten

## Sneltoetsen

- `Ctrl+N`: Nieuw project
- `Ctrl+O`: Project openen
- `Ctrl+S`: Document opslaan
- `F11`: Volledig scherm modus
- `Tab`: Handmatig AI-aanvullen activeren (in handmatige modus)
- `Ctrl+F`: Zoeken
- `Ctrl+H`: Zoeken en vervangen
- `Ctrl+Shift+H`: Geavanceerd zoeken en vervangen
## Systeemvereisten

- Python 3.8+
- PyQt6
- Besturingssysteem: Windows, macOS, Linux

## Auteur

**inliver**
- E-mail: inliverapi@outlook.com  
- GitHub: https://github.com/inliver233

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---
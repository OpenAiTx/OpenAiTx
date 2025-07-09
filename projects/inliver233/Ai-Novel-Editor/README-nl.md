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

3. Vereisten installeren
```bash
pip install -r requirements.txt
```
4. Programma uitvoeren
```bash
python src/main.py
```

## Belangrijkste functies

### Projectbeheer
- Hiërarchische documentstructuur (Werk > Hoofdstuk > Scène)
- Project importeren en exporteren (ondersteunt TEXT, MARKDOWN, DOCX, PDF, HTML-formaten)
- Automatische back-up en versiebeheer
- Meerdere projecten beheren

### AI-aanvulfunctie
- Drie aanvulmodi: automatische aanvulling, handmatige aanvulling (aanbevolen: druk één keer op tab om te activeren, druk nogmaals op tab om toe te passen), aanvulling uitschakelen
- Drie contextmodi:
  - Snelle modus: lichte context, snelle respons
  - Gebalanceerde modus: gemiddelde context, balans tussen kwaliteit en snelheid
  - Globale modus: volledige projectcontext, beste resultaat
- Ondersteunt verschillende AI-diensten: OpenAI, Claude, Tongyi Qianwen, Zhipu AI, DeepSeek, Groq, enz.
### Overzichtsbeheer
- Visualiseerbare boomstructuur van het overzicht
- Sorteren en aanpassen van hiërarchie via slepen
- Snelle navigatie door het document
- Analyse en optimalisatie-advies voor het overzicht

### API-configuratie
- Uniform AI-configuratiecentrum
- Vooraf ingestelde configuraties voor meerdere aanbieders
- Verbindingstestfunctie
- Opslaan en importeren/exporteren van configuraties

### Instellingen voor slimme aanvulling
- Instelbare triggervertraging
- Limiet op de aanvulllengte
- Configuratie van contextlengte
- Ondersteuning voor streamingreacties

### Promptbewerking
- Ingebouwde schrijfsjablonen
- Aangepaste promptsjablonen
- Beheer van sjablooncategorieën
- Modus-specifieke sjabloonconfiguratie
### Interfacefuncties
- Licht en donker thema
- Driekoloms lay-out (projectboom, editor, conceptenpaneel)
- Inklapbare zijbalk
- Volledig scherm schrijversmodus
- Focusmodus (zin, alinea, typemachine, zen-modus, immersiemodus)

### Zoeken en vervangen
- Tekst zoeken in het hele project
- Ondersteuning voor reguliere expressies
- Functie voor batch-vervanging
- Geavanceerde zoekopties

### Conceptbeheer
- Automatische detectie van personages, locaties, objecten
- Beheer van conceptrelaties
- Label- en classificatiesysteem
- Snel concept invoegen

## Sneltoetsen
- `Ctrl+N`: Nieuw project
- `Ctrl+O`: Project openen
- `Ctrl+S`: Document opslaan
- `F11`: Volledig scherm modus
- `Tab`: Handmatig AI-aanvulling activeren (in handmatige modus)
- `Ctrl+F`: Zoeken
- `Ctrl+H`: Zoeken en vervangen
- `Ctrl+Shift+H`: Geavanceerd zoeken en vervangen


## Systeemeisen

- Python 3.8+
- PyQt6
- Besturingssysteem: Windows, macOS, Linux

## Auteur

**inliver**
- E-mail: inliverapi@outlook.com  
- GitHub: https://github.com/inliver233

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---
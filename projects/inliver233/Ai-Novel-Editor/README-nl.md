
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=en">Engels</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ja">Japans</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ko">Koreaans</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=hi">Hindi</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=th">Thais</a></p>
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
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=id">Indonesisch</a></p>
      </div>
    </div>
  </details>
</div>

# AI Roman Editor

AI-ondersteunde romaneditor gebaseerd op PyQt6, biedt professionele schrijftools zoals slimme aanvulling, projectbeheer en conceptorganisatie.

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

3. Installeer afhankelijkheden
```bash
pip install -r requirements.txt
```

4. Het programma uitvoeren
```bash
python src/main.py
```

## Belangrijkste Functies

### Projectbeheer
- Gelaagde documentstructuur (Werk > Hoofdstuk > Scène)
- Project importeren/exporteren (ondersteunt TEXT, MARKDOWN, DOCX, PDF, HTML-formaat)
- Automatische back-up en versiebeheer
- Meerdere projecten beheren

### AI-aanvulfunctie
- Drie aanvulmodi: Automatisch aanvullen, Handmatig aanvullen (aanbevolen: druk eenmaal op tab om te activeren, nogmaals tab om toe te passen), Aanvullen uitschakelen
- Drie contextmodi:
  - Snelle modus: Lichte context, snelle respons
  - Gebalanceerde modus: Gemiddelde context, balans tussen kwaliteit en snelheid
  - Globale modus: Volledige projectcontext, beste resultaat
- Ondersteuning voor meerdere AI-diensten: OpenAI, Claude, Tongyi Qianwen, Zhipu AI, DeepSeek, Groq, enz.

### Overzichtsbeheer
- Visuele overzichtsboomstructuur
- Sorteren en hiërarchie aanpassen via slepen en neerzetten
- Snel navigeren door documenten
- Overzichtsanalyse en optimalisatie-advies

### API-configuratie
- Uniform AI-configuratiecentrum
- Vooraf ingestelde configuraties van meerdere aanbieders
- Verbindings testfunctie
- Configuraties opslaan, importeren en exporteren

### Slimme aanvulinstellingen
- Instelbare vertraging voor activering
- Limiet voor aanvullengte
- Contextlengte instellen
- Ondersteuning voor streamende reacties

### Promptbewerking
- Ingebouwde diverse schrijfsjablonen
- Aangepaste promptsjablonen
- Sjablooncategoriebeheer
- Modus-specifieke sjabloonconfiguratie

### Interfacefuncties
- Licht en donker thema
- Driekolomsindeling (projectboom, editor, conceptenpaneel)
- Inklapbare zijbalk
- Volledig scherm schrijfmogus
- Focusmodus (zin, alinea, typemachine, zenmodus, immersiemodus)

### Zoeken en vervangen
- Tekstzoektocht door het hele project
- Ondersteuning voor reguliere expressies
- Bulkvervangfunctie
- Geavanceerde zoekopties

### Conceptbeheer
- Automatische detectie van personages, locaties, objecten
- Beheer van conceptrelaties
- Label- en categorisatiesysteem
- Snel invoegen van concepten

## Sneltoetsen

- `Ctrl+N`: Nieuw project
- `Ctrl+O`: Project openen
- `Ctrl+S`: Document opslaan
- `F11`: Volledig scherm modus
- `Tab`: Handmatig AI-aanvullen (in handmatige modus)
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-01

---
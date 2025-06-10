# AI Screenshot Translator (AI 截图翻译工具)

[![Python Version](https://img.shields.io/badge/python-3.8+-blue.svg)](https://www.python.org/downloads/) [![Nuitka](https://img.shields.io/badge/Nuitka-Compiled-purple)](https://nuitka.net/) [![Release Version](https://img.shields.io/badge/Release-v0.3.4-red)](https://github.com/Diraw/AI-Screenshot-Translator/releases/tag/v0.3.4-test)

# Introductie

Met deze tool kun je via een **eenvoudige screenshot-actie** een afbeelding naar een AI-model sturen voor tekstherkenning en vertaling. De vertaalde tekst wordt in een interactief HTML-formaat weergegeven in een apart venster.

De tool ondersteunt **aangepaste sneltoetsen, meervoudig vensterbeheer voor resultaten en systeemvakwerking**, wat de vertaalefficiëntie tijdens het werk en leren aanzienlijk verbetert.

**Kenmerken van de tool**: 1. Screenshot-vertaling, starten met sneltoets; 2. Vertaalde plaknotities van screenshots die vrij kunnen worden verplaatst en geschaald, met de mogelijkheid om meerdere vertaalgroepen te maken; 3. Formules kunnen worden omgeschakeld naar de originele tekst voor eenvoudig kopiëren; 4. Aangepaste API-interface

**Problemen die opgelost worden**: 1. De meeste bestaande documentvertalers zijn omslachtig; 2. Bij het kopiëren en plakken van tekst uit een pdf zijn formuleblokken soms rommelig of niet te kopiëren; 3. Bij gescande afbeeldingen in pdf’s is het niet mogelijk om tekst te kopiëren

# Demo

<img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/0.1.gif" alt="" width="100%">

# Vensterweergave

Vertaalscherm:

<img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v0.2.1.svg" alt="" width="100%">

Instellingenvenster:

<table>
  <tr>
    <td><img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v3.0.1.png" /></td>
    <td><img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v3.0.0_2.png" /></td>
  </tr>
</table>

Voor een meer gedetailleerde uitleg van de configuratieopties kun je in de software of op de website kijken bij [Tips](https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/doc/hint.md)

# Installatie

Je kunt ervoor kiezen om de broncode te downloaden en uit te voeren, of ga naar [Releases](https://github.com/Diraw/AI-Screenshot-Translator/releases) om het uitvoerbare bestand te downloaden

### 1. Repository klonen

```bash
git clone https://github.com/Diraw/AI-Screenshot-Translator.git
cd AI-Screenshot-Translator/src
```

### 2. Virtuele omgeving aanmaken en uitvoeren

```bash
conda create -n AI-Translator python=3.8
conda activate AI-Translator
pip install -r requirements.txt
python main.py
```

# Updateplan

- ~~GUI-venster voor API-configuratie toegevoegd, handmatige YAML-configuratie vervangen door automatische generatie in de software (v0.3.0 voltooid)~~
- Nieuw systeem voor opslag van afbeeldingen en formules, handig voor later gebruik (verwacht in v0.4 afgerond)
- (Meer functies? Dien gerust een issue in of draag bij via een PR)

# Overig

- Het software-icoon komt van [iconfinder](https://www.iconfinder.com/search?q=screenshot&price=free)
- Dank aan Gemini 2.5 Flash en DeepSeek-V3-0324 voor het helpen vinden van bugs

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---
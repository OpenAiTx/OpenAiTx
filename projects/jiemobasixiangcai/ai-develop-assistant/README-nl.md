# 🚀 MCP AI-ontwikkelingsassistent

> MCP-tool ter ondersteuning van AI-ontwikkelaars bij intelligente behoefteanalyse en architectuurontwerp

## ✨ Kernfuncties

- **Intelligente behoefteverduidelijking**: Herkent automatisch het projecttype en genereert gerichte vragen
- **Branch-bewuste management**: Volgt projectdoelen, functioneel ontwerp, technische voorkeuren, UI-ontwerp en andere dimensies
- **Automatische architectuurgeneratie**: Genereert technische architectuuroplossingen op basis van volledige vereisten
- **Persistente opslag**: Analyse-resultaten worden automatisch opgeslagen en export van documenten wordt ondersteund

## 📁 Snelle configuratie

### Configuratie voor oude versie
1. **Code klonen**
   ```bash
   git clone https://github.com/jiemobasixiangcai/ai-develop-assistant.git
   ```
2. **Aanbevolen virtuele omgeving**
   ```bash
   python -m venv venv
   source venv/bin/activate  # Unix/Linux/MacOS
   venv\Scripts\activate  # Windows
   ```
3. **Installatie van afhankelijkheden**
   ```bash
   pip install -r requirements.txt
   ```

4. **Locatie configuratiebestand**
   ```
   Windows: %APPDATA%\Claude\claude_desktop_config.json
   macOS: ~/Library/Application Support/Claude/claude_desktop_config.json
   ```

5. **Configuratie toevoegen**
   ```json
   {
     "mcpServers": {
       "ai-develop-assistant": {
         "command": "python",
         "args": ["path/to/AIDevlopStudy.py"],
         "env": {
           "MCP_STORAGE_DIR": "./mcp_data"
         }
       }
     }
   }
   ```

3. **Herstart Claude Desktop**

### Configuratie voor nieuwe versie
#### 🔧 Kernhulpmiddelen
1. **start_new_project** - Start een nieuw project
2. **create_requirement_blueprint** - Maak een behoefte-blauwdruk
3. **requirement_clarifier** - Ontvang prompts voor behoefteverduidelijking
4. **save_clarification_tasks** - Sla verduidelijkingstaken op
5. **update_branch_status** - Werk de branch-status bij
6. **requirement_manager** - Beheertool voor behoeften-documentatie
7. **check_architecture_prerequisites** - Controleer architectuurvoorwaarden
8. **get_architecture_design_prompt** - Ontvang prompts voor architectuurontwerp
9. **save_generated_architecture** - Sla gegenereerde architectuur op
10. **export_final_document** - Exporteer het volledige document
11. **view_requirements_status** - Bekijk de status van de behoeften

#### Configuratie (kopieer deze remote direct connect naar jouw tool en vervang MCP_STORAGE_DIR door jouw lokale directory)
   ```json
   {
     "mcpServers": {
       "ai-develop-assistant": {
         "command": "uvx",
         "args": ["ai-develop-assistant@latest"],
         "env": {
           "MCP_STORAGE_DIR": "/path/to/your/storage"
         }
       }
     }
   }
   ```

## 🎯 Gebruiksproces

### Basisstappen

1. **Behoefteverduidelijking**
   ```
   requirement_clarifier("Ik wil een online onderwijsplatform maken")
   ```

2. **Behoeftebeheer**
   ```
   requirement_manager("Doelgebruikers: studenten en docenten", "Projectoverzicht")
   ```

3. **Status bekijken**
   ```
   view_requirements_status()
   ```
4. **Architectuurontwerp**
   ```
   architecture_designer("Online onderwijsplatformarchitectuur")
   ```

5. **Document exporteren**
   ```
   export_final_document()
   ```

## 🚀 Aan de slag

### Snel starten
1. **Configureer Claude Desktop** (zie de bovenstaande configuratiemethode)
2. **Herstart Claude Desktop**
3. **Start met intelligente behoefte-analyse**:
   ```
   requirement_clarifier("Beschrijf je projectidee")
   ```
4. **Volg de slimme begeleiding van de AI** om elke behoefte-tak stap voor stap te verfijnen
5. **Exporteer het volledige document**:
   ```
   export_final_document()
   ```

### Best practices
- 💬 **Vertrouw op het branchbeheer van de AI**: Laat de AI je begeleiden bij alle behoefte-takken
- 🎯 **Geef voorkeuren duidelijk aan**: Wees duidelijk over technische keuzes, UI-stijl, enz.
- 📊 **Bekijk regelmatig de status**: Gebruik `view_requirements_status` om de voortgang te volgen
- 🤖 **Geef AI waar nodig toestemming**: Voor onzekere onderdelen kun je zeggen "gebruik de standaardoplossing"

---

**🎯 Nu heb je een echt intelligente AI-ontwikkelassistent die elk detail onthoudt en je begeleidt door de volledige behoefte-analyse!**

## 💬 Discussiegroep

<div align="center">
<img src="https://raw.githubusercontent.com/jiemobasixiangcai/ai-develop-assistant/main/./assets/qr-code.jpg" width="200" alt="Discussiegroep">
<br>
Discussiegroep
</div>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---
# 🚀 MCP AI-Entwicklungsassistent

> MCP-Tool zur Unterstützung von KI-Entwicklern bei intelligenter Anforderungsanalyse und Architekturdesign

## ✨ Kernfunktionen

- **Intelligente Anforderungsklärung**: Automatische Erkennung des Projekttyps, Generierung gezielter Fragen
- **Branchensensitives Management**: Nachverfolgung von Projektzielen, Funktionsdesign, Technologiepräferenzen, UI-Design usw.
- **Automatische Architekturgenerierung**: Erstellung technischer Architekturkonzepte basierend auf vollständigen Anforderungen
- **Persistente Speicherung**: Automatisches Speichern der Analyseergebnisse, Unterstützung des Dokumentexports

## 📁 Schnelle Konfiguration

### Konfiguration der alten Version
1. **Code klonen**
   ```bash
   git clone https://github.com/jiemobasixiangcai/ai-develop-assistant.git
   ```
2. **Empfohlene virtuelle Umgebung**
   ```bash
   python -m venv venv
   source venv/bin/activate  # Unix/Linux/MacOS
   venv\Scripts\activate  # Windows
   ```
3. **Abhängigkeiten installieren**
   ```bash
   pip install -r requirements.txt
   ```

4. **Konfigurationsdateipfad**
   ```
   Windows: %APPDATA%\Claude\claude_desktop_config.json
   macOS: ~/Library/Application Support/Claude/claude_desktop_config.json
   ```

5. **Konfiguration hinzufügen**
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

3. **Claude Desktop neu starten**

### Konfiguration der neuen Version
#### 🔧 Kernwerkzeuge
1. **start_new_project** – Neues Projekt starten
2. **create_requirement_blueprint** – Anforderungs-Blueprint erstellen
3. **requirement_clarifier** – Hinweise zur Anforderungsklärung abrufen
4. **save_clarification_tasks** – Klärungsaufgaben speichern
5. **update_branch_status** – Branchstatus aktualisieren
6. **requirement_manager** – Anforderungsdokumentenmanager
7. **check_architecture_prerequisites** – Architektur-Voraussetzungen prüfen
8. **get_architecture_design_prompt** – Architektur-Design-Hinweise abrufen
9. **save_generated_architecture** – Generiertes Architekturdesign speichern
10. **export_final_document** – Komplette Dokumentation exportieren
11. **view_requirements_status** – Anforderungsstatus anzeigen

#### Konfiguration (Remote-Direktverbindung in dein Tool kopieren, MCP_STORAGE_DIR durch dein lokales Verzeichnis ersetzen)
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

## 🎯 Ablauf der Nutzung

### Grundlegende Schritte

1. **Anforderungsklärung**
   ```
   requirement_clarifier("Ich möchte eine Online-Bildungsplattform erstellen")
   ```

2. **Anforderungsmanagement**
   ```
   requirement_manager("Zielnutzer: Studierende und Lehrkräfte", "Projektübersicht")
   ```

3. **Status anzeigen**
   ```
   view_requirements_status()
   ```
4. **Architektur-Design**
   ```
   architecture_designer("Online-Bildungsplattform-Architektur")
   ```

5. **Dokument exportieren**
   ```
   export_final_document()
   ```

## 🚀 Erste Schritte

### Schnellstart
1. **Konfiguriere Claude Desktop** (siehe oben für die Konfigurationsanleitung)
2. **Starte Claude Desktop neu**
3. **Starte die intelligente Anforderungsanalyse**:
   ```
   requirement_clarifier("Beschreibe deine Projektidee")
   ```
4. **Folge der intelligenten KI-Anleitung**, um die einzelnen Anforderungszweige schrittweise zu vervollständigen
5. **Exportiere das vollständige Dokument**:
   ```
   export_final_document()
   ```

### Best Practices
- 💬 **Vertraue dem KI-Branch-Management**: Lass die KI dich durch alle Anforderungszweige führen
- 🎯 **Präferenzen klar äußern**: Gib klare Präferenzen für Technologiewahl, UI-Stil usw. an
- 📊 **Regelmäßige Statusüberprüfung**: Nutze `view_requirements_status`, um den Fortschritt einzusehen
- 🤖 **KI angemessen autorisieren**: Für unsichere Bereiche kannst du sagen „Standardlösung verwenden“

---

**🎯 Jetzt verfügst du über einen wirklich intelligenten KI-Entwicklungsassistenten, der sich jedes Detail merkt und dich durch die vollständige Anforderungsanalyse führt!**

## 💬 Community-Gruppe

<div align="center">
<img src="https://raw.githubusercontent.com/jiemobasixiangcai/ai-develop-assistant/main/./assets/qr-code.jpg" width="200" alt="Community-Gruppe">
<br>
Community-Gruppe
</div>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
  <a href="https://core.heysol.ai">
    <img src="https://github.com/user-attachments/assets/89066cdd-204b-46c2-8ad4-4935f5ca9edd" width="200px" alt="CORE Logo" />
  </a>

### C.O.R.E: Dein digitales Gehirn für das KI-Zeitalter

<p align="center">
    <a href="https://docs.heysol.ai/core/overview"><b>Dokumentation</b></a> •
    <a href="https://discord.gg/YGUZcvDjUa"><b>Discord</b></a>
</p>
</div>

## 🧠 C.O.R.E.

**Contextual Observation & Recall Engine**

C.O.R.E ist ein portabler Gedächtnisgraph, der aus deinen LLM-Interaktionen und persönlichen Daten aufgebaut wird und sämtlichen Kontext sowie den Verlauf deiner Arbeitsabläufe jedem KI-Tool zugänglich macht – wie ein digitales Gehirn. Das macht wiederholtes Teilen von Kontext überflüssig. Ziel ist es, Folgendes zu bieten:

- **Vereinheitlichtes, portables Gedächtnis**: Füge Kontext nahtlos hinzu und rufe ihn ab, verbinde dein Gedächtnis mit Apps wie Claude, Cursor, Windsurf und mehr.
- **Relational, nicht nur flache Fakten**: CORE organisiert dein Wissen, speichert sowohl Fakten als auch Beziehungen für ein tieferes, reichhaltigeres Gedächtnis wie ein echtes Gehirn.
- **Vom Nutzer kontrolliert**: Du entscheidest, was behalten, aktualisiert oder gelöscht wird, teilst dein Gedächtnis über die gewünschten Tools und bist nicht an Anbieter gebunden.

## 🎥 Demo-Video

[Sieh dir die C.O.R.E-Demo an](https://youtu.be/iANZ32dnK60)

<img width="954" height="700" alt="Core Dashboard" src="https://github.com/user-attachments/assets/d684b708-6907-47be-9499-a30b25434694" />

## 🧩  Hauptfunktionen

- **Gedächtnisgraph**: Visualisiere, wie deine Fakten und Präferenzen miteinander verknüpft sind
- **Chat mit Gedächtnis**: Stelle Fragen zum Gedächtnis für sofortige Einblicke und Verständnis
- **Plug n Play**: Nutze das CORE-Gedächtnis sofort in Apps wie Cursor, Claude

## ☁️ C.O.R.E Cloud-Setup

1. Registriere dich bei [Core Cloud](https://core.heysol.ai) und beginne, deinen Gedächtnisgraphen zu erstellen.
2. Füge deinen Text hinzu, den du im Gedächtnis speichern möchtest. Nach dem Klick auf die Schaltfläche `+ Add` wird dein Gedächtnisgraph erstellt.
3. [Verbinde Core Memory MCP mit Cursor](#connecting-core-mcp-with-cursor)

## 💻 C.O.R.E Lokale Installation

#### Voraussetzungen

1. Docker
2. OpenAI API-Schlüssel


> **Hinweis:** Wir arbeiten aktiv daran, die Unterstützung für Llama-Modelle zu verbessern. Derzeit liefert C.O.R.E mit Llama-basierten Modellen noch keine optimalen Ergebnisse, aber wir machen Fortschritte, um in naher Zukunft eine bessere Kompatibilität und Ausgabe zu gewährleisten.
> 
#### C.O.R.E lokal ausführen

1. **Umgebungsvariablen kopieren**

   Kopiere die Beispiel-Umgebungsdatei nach `.env`:


   ```bash
   cp .env.example .env
   ```
2. **Starten Sie die Anwendung**

   Verwenden Sie Docker Compose, um alle erforderlichen Dienste zu starten:


   ```bash
   docker-compose up
   ```
3. **Zugriff auf die App**

   Sobald die Container laufen, öffne deinen Browser und gehe zu [http://localhost:3000](http://localhost:3000).

4. **Konto mit Magic Link erstellen**

   - Um ein Konto zu erstellen, klicke auf die Schaltfläche `Mit E-Mail fortfahren`

     <img width="865" height="490" alt="Konto erstellen" src="https://github.com/user-attachments/assets/65de110b-2b1f-42a5-9b8a-954227d68d52" />

   - Gib deine E-Mail-Adresse ein und klicke auf die Schaltfläche `Magic Link senden`

     <img width="824" height="429" alt="E-Mail eingeben" src="https://github.com/user-attachments/assets/76128b61-2086-48df-8332-38c2efa14087" />

   - `Kopiere den Magic Link aus den Terminal-Logs` und öffne ihn in deinem Browser

     <img width="1010" height="597" alt="Magic Link" src="https://github.com/user-attachments/assets/777cb4b1-bb93-4d54-b6ab-f7147e65aa5c" />


5. **Erstelle deinen privaten Bereich & füge Daten hinzu**

   - Gehe im Dashboard oben rechts zum Bereich -> Tippe eine Nachricht ein, z. B. `Ich spiele gerne Badminton` und klicke auf `+Hinzufügen`.
   - Deine Erinnerung wird zur Verarbeitung in die Warteschlange gestellt; du kannst ihren Status im Bereich `Logs` überwachen.
     
     <img width="1496" height="691" alt="Core Memory Logs" src="https://github.com/user-attachments/assets/dc34a7af-fe52-4142-9ecb-49ddc4e0e854" />

   - Nach Abschluss der Verarbeitung werden Knoten zu deinem privaten Wissensgraphen hinzugefügt und im Dashboard sichtbar sein.
   - Du kannst später entscheiden, diese Erinnerung mit anderen Tools zu verbinden oder privat zu halten.

6. **Durchsuche deine Erinnerungen**

   - Nutze die Suchfunktion des Dashboards, um deine aufgenommenen Daten in deinem privaten Bereich abzufragen.


## CORE MCP mit Cursor verbinden

1. Öffne das CORE-Dashboard und navigiere zum API-Bereich, um ein neues API-Token zu generieren.
2. Gehe in Cursor zu: Einstellungen → Tools & Integrationen → Neuer MCP-Server.
3. Füge den CORE MCP-Server mit dem untenstehenden Konfigurationsformat hinzu. Ersetze dabei unbedingt den Wert von API_TOKEN durch das in Schritt 1 erzeugte Token.

   MCP-Konfiguration zum Hinzufügen in Cursor


   ```json
   {
     "mcpServers": {
       "memory": {
         "command": "npx",
         "args": ["-y", "@redplanethq/core-mcp"],
         "env": {
           "API_TOKEN": "YOUR_API_TOKEN_HERE",
           "API_BASE_URL": "https://core.heysol.ai",
           "SOURCE": "cursor"
         }
       }
     }
   }
   ```
4. Gehen Sie zu Einstellungen -> Benutzerregeln -> Neue Regel -> und fügen Sie die folgende Regel hinzu, um sicherzustellen, dass alle Ihre Chat-Interaktionen im CORE-Speicher gespeichert werden


```
After every interaction, update the memory with the user's query and the assistant's
response to core-memory mcp. sessionId should be the uuid of the conversation
```
## Dokumentation

Entdecken Sie unsere Dokumentation, um das Beste aus CORE herauszuholen
- [Grundkonzepte](https://docs.heysol.ai/core/overview)
- [API-Referenz](https://docs.heysol.ai/core/local-setup)
- [Core Memory MCP mit Cursor verbinden](#connecting-core-mcp-with-cursor)


## 🧑‍💻 Support
Haben Sie Fragen oder Feedback? Wir sind für Sie da:
- Discord: [Treten Sie dem core-support Channel bei](https://discord.gg/YGUZcvDjUa)
- Dokumentation: [docs.heysol.ai/core](https://docs.heysol.ai/core/overview)
- E-Mail: manik@poozle.dev

## Nutzungsrichtlinien

**Speichern:**

- Gesprächsverlauf
- Benutzereinstellungen
- Aufgaben-Kontext
- Referenzmaterialien

**Nicht speichern:**

- Sensible Daten (personenbezogene Daten)
- Zugangsdaten
- Systemprotokolle
- Temporäre Daten

## 👥 Mitwirkende

<a href="https://github.com/RedPlanetHQ/core/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=RedPlanetHQ/core" />
</a>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---
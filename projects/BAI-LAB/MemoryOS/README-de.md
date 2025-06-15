# MemoryOS
<div align="center">
  <img src="https://raw.githubusercontent.com/BAI-LAB/MemoryOS/main/logo_1.png" alt="logo" width="400"/>
</div>
<p align="center">
  <a href="https://arxiv.org/abs/2506.06326">
    <img src="https://img.shields.io/badge/Arxiv-paper-red" alt="Mem0 Discord">
  </a>
  <a href="https://github.com/user-attachments/assets/d195e740-1249-4eb1-962a-2c0d99a38c39">
    <img src="https://img.shields.io/badge/Wechat-群二维码-green" alt="Mem0 PyPI - Downloads">
  </a>
  <a href="https://youtu.be/y9Igs0FnX_M" target="blank">
    <img src="https://img.shields.io/badge/Demo-Video-red" alt="Npm package">
  </a>
    <a href="https://www.apache.org/licenses/LICENSE-2.0" target="_blank">
    <img src="https://img.shields.io/badge/License-Apache_2.0-blue" alt="License: Apache 2.0">
  </a>
</p>

<h5 align="center"> 🎉 Wenn dir unser Projekt gefällt, gib uns bitte einen Stern ⭐ auf GitHub für die neuesten Updates.</h5>
**MemoryOS** wurde entwickelt, um ein Speicherbetriebssystem für personalisierte KI-Agenten bereitzustellen, das kohärentere, persönlichere und kontextbewusstere Interaktionen ermöglicht. Inspiriert von Speicherverwaltungsprinzipien aus Betriebssystemen, verfolgt es eine hierarchische Speicherarchitektur mit vier Kernmodulen: Speicherung, Aktualisierung, Abruf und Generierung, um eine umfassende und effiziente Speicherverwaltung zu erreichen. Im LoCoMo-Benchmark erreichte das Modell durchschnittliche Verbesserungen von **49,11%** und **46,18%** bei F1- und BLEU-1-Scores.

## 📣 Neueste Nachrichten
*   *<mark>[neu]</mark>* 🔥  **[2025-06-15]**:🛠️ Open-Source-Release von **MemoryOS-MCP**! Jetzt auf Agenten-Clients konfigurierbar für nahtlose Integration und Anpassung. [👉 查看](#memoryos_mcp-getting-started)
*   **[2025-05-30]**: Erste Version von **MemoryOS** veröffentlicht! Mit Kurzzeit-, Mittelzeit- und Langzeit-Persona-Speicher sowie automatisierter Aktualisierung von Nutzerprofil und Wissen.

## Demo
[![Watch the video](https://img.youtube.com/vi/y9Igs0FnX_M/maxresdefault.jpg)](https://youtu.be/y9Igs0FnX_M)

##  Systemarchitektur
![image](https://github.com/user-attachments/assets/09200494-03a9-4b7d-9ffa-ef646d9d51f0)

## Projektstruktur

```
memoryos/
├── __init__.py            # Initialisiert das MemoryOS-Paket
├── __pycache__/           # Python-Cache-Verzeichnis (automatisch generiert)
├── long_term.py           # Verwaltung des Langzeit-Persona-Speichers (Nutzerprofil, Wissen)
├── memoryos.py            # Hauptklasse für MemoryOS, koordiniert alle Komponenten
├── mid_term.py            # Verwaltung des Mittelzeitspeichers, Konsolidierung von Kurzzeitinteraktionen
├── prompts.py             # Enthält Prompts für LLM-Interaktionen (z.B. Zusammenfassung, Analyse)
├── retriever.py           # Ruft relevante Informationen aus allen Speicherebenen ab
├── short_term.py          # Verwaltung des Kurzzeitspeichers für aktuelle Interaktionen
├── updater.py             # Verarbeitet Speicheraktualisierungen, inkl. Übertragung von Informationen zwischen Ebenen
└── utils.py               # Hilfsfunktionen, die in der gesamten Bibliothek verwendet werden
```

## Funktionsweise

1.  **Initialisierung:** `Memoryos` wird mit Nutzer- und Assistenten-IDs, API-Schlüsseln, Daten-Speicherpfaden und verschiedenen Kapazitäts-/Schwellwerteinstellungen initialisiert. Es wird ein dedizierter Speicher für jeden Nutzer und Assistenten eingerichtet.
2.  **Speichern von Erinnerungen:** Nutzereingaben und Agentenantworten werden als QA-Paare hinzugefügt. Diese werden zunächst im Kurzzeitspeicher abgelegt.
3.  **Verarbeitung von Kurzzeit- zu Mittelzeitspeicher:** Wenn der Kurzzeitspeicher voll ist, verarbeitet das `Updater`-Modul diese Interaktionen, fasst sie zu sinnvollen Segmenten zusammen und speichert sie im Mittelzeitspeicher.
4.  **Mittelzeitanalyse & LPM-Updates:** Mittelzeitspeichersegmente akkumulieren „Hitze“ basierend auf Faktoren wie Besuchshäufigkeit und Interaktionslänge. Wenn die Hitze eines Segments einen Schwellenwert überschreitet, wird dessen Inhalt analysiert:
    *   Erkenntnisse zum Nutzerprofil werden extrahiert und zur Aktualisierung des Langzeit-Nutzerprofils verwendet.
    *   Spezifische Nutzerfakten werden dem Langzeitwissen des Nutzers hinzugefügt.
    *   Relevante Informationen für den Assistenten werden der Langzeit-Wissensbasis des Assistenten hinzugefügt.
5.  **Antwortgenerierung:** Wenn eine Nutzeranfrage eingeht:
    *   Das `Retriever`-Modul ruft relevanten Kontext aus der Kurzzeithistorie, Mittelzeitspeichersegmenten, dem Nutzerprofil & Wissen sowie der Wissensbasis des Assistenten ab.
    *   Dieser umfassende Kontext wird zusammen mit der Nutzeranfrage genutzt, um über ein LLM eine kohärente und fundierte Antwort zu generieren.

## MemoryOS_PYPI Schnellstart

### Voraussetzungen

*   Python >= 3.10
*   pip install -i https://pypi.org/simple/ MemoryOS-BaiJia

### Installation

```bash
conda create -n MemoryOS python=3.10
conda activate MemoryOS
pip install -i https://pypi.org/simple/ MemoryOS-BaiJia
```

### Grundlegende Verwendung

```python

import os
from memoryos import Memoryos

# --- Grundkonfiguration ---
USER_ID = "demo_user"
ASSISTANT_ID = "demo_assistant"
API_KEY = "YOUR_OPENAI_API_KEY"  # Ersetze durch deinen Schlüssel
BASE_URL = ""  # Optional: bei Nutzung eines eigenen OpenAI-Endpunkts
DATA_STORAGE_PATH = "./simple_demo_data"
LLM_MODEL = "gpt-4o-mini"

def simple_demo():
    print("MemoryOS Simple Demo")
    
    # 1. Initialisiere MemoryOS
    print("Initialisiere MemoryOS...")
    try:
        memo = Memoryos(
            user_id=USER_ID,
            openai_api_key=API_KEY,
            openai_base_url=BASE_URL,
            data_storage_path=DATA_STORAGE_PATH,
            llm_model=LLM_MODEL,
            assistant_id=ASSISTANT_ID,
            short_term_capacity=7,  
            mid_term_heat_threshold=5,  
            retrieval_queue_capacity=7,
            long_term_knowledge_capacity=100
        )
        print("MemoryOS erfolgreich initialisiert!\n")
    except Exception as e:
        print(f"Fehler: {e}")
        return

    # 2. Füge einige Erinnerungen hinzu
    print("Füge einige Erinnerungen hinzu...")
    
    memo.add_memory(
        user_input="Hi! Ich bin Tom, ich arbeite als Data Scientist in San Francisco.",
        agent_response="Hallo Tom! Schön, dich kennenzulernen. Data Science ist ein spannendes Feld. Mit welchen Daten arbeitest du?"
    )
     
    test_query = "Was weißt du noch über meinen Beruf?"
    print(f"Benutzer: {test_query}")
    
    response = memo.get_response(
        query=test_query,
    )
    
    print(f"Assistent: {response}")

if __name__ == "__main__":
    simple_demo()
```
## MemoryOS-MCP Schnellstart
### 🔧 Kernfunktionen

#### 1. `add_memory`
Speichert den Inhalt des Gesprächs zwischen Nutzer und KI-Assistent im Speichersystem, um einen persistenten Dialogverlauf und Kontextaufzeichnung zu ermöglichen.

#### 2. `retrieve_memory`
Ruft auf Basis einer Anfrage relevante historische Dialoge, Nutzerpräferenzen und Wissensinformationen aus dem Speichersystem ab, um dem KI-Assistenten zu helfen, die Bedürfnisse und den Hintergrund des Nutzers zu verstehen.

#### 3. `get_user_profile`
Erstellt ein Nutzerprofil aus der Analyse historischer Dialoge, einschließlich Persönlichkeitsmerkmalen, Interessenpräferenzen und relevantem Wissenshintergrund.

### 1. Abhängigkeiten installieren
```bash
cd memoryos-mcp
pip install -r requirements.txt
```
### 2. Konfiguration

Bearbeite `config.json`：
```json
{
  "user_id": "deine Nutzer-ID",
  "openai_api_key": "dein OpenAI API-Schlüssel",
  "openai_base_url": "https://api.openai.com/v1",
  "data_storage_path": "./memoryos_data",
  "assistant_id": "assistant_id",
  "llm_model": "gpt-4o-mini"
}
```
### 3. Server starten
```bash
python server_new.py --config config.json
```
### 4. Testen
```bash
python test_comprehensive.py
```
### 5. Konfiguration auf Cline und anderen Clients
Kopiere die mcp.json-Datei und stelle sicher, dass der Dateipfad korrekt ist.
```bash
command": "/root/miniconda3/envs/memos/bin/python"
# Dies sollte auf den Python-Interpreter deiner virtuellen Umgebung angepasst werden
```
## Beitrag leisten

Beiträge sind willkommen! Bitte zögere nicht, Issues oder Pull Requests einzureichen.

## Zitieren
Wenn du mehr Details lesen möchtest, klicke hier: [Vollständigen Artikel lesen](https://arxiv.org/abs/2506.06326)

Wenn du dieses Projekt nützlich findest, zitiere bitte unsere Arbeit:

```bibtex
@misc{kang2025memoryosaiagent,
      title={Memory OS of AI Agent}, 
      author={Jiazheng Kang and Mingming Ji and Zhe Zhao and Ting Bai},
      year={2025},
      eprint={2506.06326},
## Kontakt

BAI AI ist eine von Frau Prof. Ting Bai an der Beijing University of Posts and Telecommunications geleitete Forschungsgruppe, die sich der Entwicklung eines emotional reichen und außergewöhnlich gedächtnisstarken Gehirns für Silizium-basierte Menschen widmet.<br>
Kooperation und Anregungen: baiting@bupt.edu.cn<br>
Folgen Sie gerne dem offiziellen WeChat-Kanal „BAI Agent“ und treten Sie der WeChat-Gruppe bei, um sich auszutauschen!  
<div style="display: flex; justify-content: center; gap: 20px;">
  <img src="https://github.com/user-attachments/assets/42651f49-f1f7-444d-9455-718e13ed75e9" alt="BAI Agent WeChat-Kanal" width="250"/>
  <img src="https://github.com/user-attachments/assets/6b15a873-9e9a-44ee-b0b3-64f488fbd5d8" alt="WeChat-Gruppen-QR-Code" width="300"/>
</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---
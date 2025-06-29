![Gitcontainer](https://raw.githubusercontent.com/cyclotruc/gitcontainer/main/docs/image.png)

# Gitcontainer 🐳

**Trasforma qualsiasi repository GitHub in un container Docker pronto per la produzione con la generazione automatica del Dockerfile basata su AI.**

[![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)
[![Python 3.9+](https://img.shields.io/badge/python-3.9+-blue.svg)](https://www.python.org/downloads/)
[![FastAPI](https://img.shields.io/badge/FastAPI-0.68+-00a393.svg)](https://fastapi.tiangolo.com/)

Gitcontainer è un'applicazione web basata su AI che genera automaticamente Dockerfile pronti per la produzione analizzando repository GitHub. Basta incollare un URL GitHub e otterrai un Dockerfile personalizzato con selezione intelligente dell'immagine base, gestione delle dipendenze e best practice Docker.

## 🌟 Accesso Rapido

Semplicemente sostituisci `github.com` con `gitcontainer.com` in qualsiasi URL di repository GitHub per accedere istantaneamente alla pagina di generazione del Dockerfile per quel repository.

Ad esempio:
```
https://github.com/username/repo  →  https://gitcontainer.com/username/repo
```

## ✨ Funzionalità

- **🔄 Accesso Istantaneo tramite URL**: Basta sostituire 'github.com' con 'gitcontainer.com' in qualsiasi URL GitHub
- **🤖 Analisi Basata su AI**: Utilizza OpenAI GPT-4 per analizzare la struttura del repository e generare Dockerfile intelligenti
- **⚡ Streaming in Tempo Reale**: Guarda l'AI generare il tuo Dockerfile in tempo reale tramite streaming WebSocket
- **🎯 Rilevamento Intelligente**: Rileva automaticamente gli stack tecnologici (Python, Node.js, Java, Go, ecc.)
- **🔧 Pronto per la Produzione**: Genera Dockerfile seguendo le best practice con sicurezza, build multi-stage e ottimizzazione
- **📋 Istruzioni Aggiuntive**: Aggiungi requisiti personalizzati per ambienti specializzati
- **📄 Docker Compose**: Suggerisce automaticamente docker-compose.yml per applicazioni complesse
- **🎨 UI Moderna**: Interfaccia pulita e responsiva con editor Monaco per evidenziazione della sintassi
- **📱 Ottimizzato per Mobile**: Funziona perfettamente su dispositivi desktop e mobile

## 🚀 Avvio Rapido

### Prerequisiti

- Python 3.9 o superiore
- Git
- Chiave API OpenAI

### Installazione

1. **Clona il repository:**
   ```bash
   git clone https://github.com/cyclotruc/gitcontainer.git
   cd gitcontainer
   ```

2. **Installa le dipendenze:**
   ```bash
   pip install -r requirements.txt
   ```

3. **Configura le variabili d'ambiente:**
   ```bash
   # Crea il file .env
   echo "OPENAI_API_KEY=your_openai_api_key_here" > .env
   ```

4. **Avvia l'applicazione:**
   ```bash
   python app.py
   ```

5. **Apri il tuo browser:**
   Vai su `http://localhost:8000`

## 🛠️ Come Funziona

1. **Elaborazione URL**: Accedi a qualsiasi repository sostituendo 'github.com' con 'gitcontainer.com' nell'URL
2. **Clonazione del Repository**: Gitcontainer clona localmente il repository GitHub tramite Git
3. **Analisi del Codice**: Utilizza [gitingest](https://github.com/cyclotruc/gitingest) per analizzare la struttura del repository ed estrarre le informazioni rilevanti
4. **Generazione AI**: Invia l'analisi a OpenAI GPT-4 con prompt specializzati per la generazione del Dockerfile
5. **Ottimizzazione Intelligente**: L'AI prende in considerazione:
   - Rilevamento dello stack tecnologico
   - Gestione delle dipendenze
   - Best practice di sicurezza
   - Build multi-stage quando utile
   - Configurazione delle porte
   - Variabili d'ambiente
   - Health check

## 📁 Struttura del Progetto

```
cyclotruc-gitcontainer/
├── app.py                 # Applicazione principale FastAPI
├── requirements.txt       # Dipendenze Python
├── .env                  # Variabili d'ambiente (da creare)
├── static/               # Asset statici (icone, CSS)
├── templates/
│   └── index.jinja       # Template HTML principale
└── tools/                # Moduli core delle funzionalità
    ├── __init__.py
    ├── create_container.py  # Generazione Dockerfile tramite AI
    ├── git_operations.py    # Clonazione repository GitHub
    └── gitingest.py        # Analisi del repository
```
## 🔧 Configurazione

### Variabili d'Ambiente

| Variabile | Descrizione | Obbligatorio |
|-----------|-------------|--------------|
| `OPENAI_API_KEY` | La tua chiave API di OpenAI | Sì |
| `PORT` | Porta del server (default: 8000) | No |
| `HOST` | Host del server (default: 0.0.0.0) | No |

### Utilizzo Avanzato

Puoi usare gli strumenti programmaticamente:

```python
from tools import clone_repo_tool, gitingest_tool, create_container_tool
import asyncio

async def generate_dockerfile(github_url):
    # Clona il repository
    clone_result = await clone_repo_tool(github_url)
    
    # Analizza con gitingest
    analysis = await gitingest_tool(clone_result['local_path'])
    
    # Genera Dockerfile
    dockerfile = await create_container_tool(
        gitingest_summary=analysis['summary'],
        gitingest_tree=analysis['tree'],
        gitingest_content=analysis['content']
    )
    
    return dockerfile

# Utilizzo
result = asyncio.run(generate_dockerfile("https://github.com/user/repo"))
print(result['dockerfile'])
```

## 🎨 Personalizzazione

### Aggiunta di Istruzioni Personalizzate

Usa la funzione "Istruzioni aggiuntive" per personalizzare la generazione:

- `"Usa Alpine Linux per una dimensione dell'immagine più piccola"`
- `"Includi Redis e PostgreSQL"`
- `"Ottimizza per il deployment in produzione"`
- `"Aggiungi strumenti di sviluppo per il debugging"`

## 📝 Licenza

Questo progetto è rilasciato sotto licenza MIT - vedi il file [LICENSE](LICENSE) per i dettagli.

## 🙏 Ringraziamenti

- **[OpenAI](https://openai.com/)** per aver fornito l'API GPT-4
- **[gitingest](https://github.com/cyclotruc/gitingest)** per le capacità di analisi dei repository
- **[FastAPI](https://fastapi.tiangolo.com/)** per l'eccellente framework web
- **[Monaco Editor](https://microsoft.github.io/monaco-editor/)** per l'evidenziazione della sintassi del codice

## 🔗 Link

- **Repository GitHub**: [https://github.com/cyclotruc/gitcontainer](https://github.com/cyclotruc/gitcontainer)
- **Demo**: Provalo dal vivo con repository di esempio
- **Problemi**: [Segnala bug o richiedi funzionalità](https://github.com/cyclotruc/gitcontainer/issues)

---

**Creato con ❤️ da [Romain Courtois](https://github.com/cyclotruc)**

*Trasforma qualsiasi repository in un container in pochi secondi!*

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---
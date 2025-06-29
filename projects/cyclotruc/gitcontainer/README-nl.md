![Gitcontainer](https://raw.githubusercontent.com/cyclotruc/gitcontainer/main/docs/image.png)

# Gitcontainer 🐳

**Maak van elke GitHub-repository een productieklare Docker-container met AI-gegenereerde Dockerfiles.**

[![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)
[![Python 3.9+](https://img.shields.io/badge/python-3.9+-blue.svg)](https://www.python.org/downloads/)
[![FastAPI](https://img.shields.io/badge/FastAPI-0.68+-00a393.svg)](https://fastapi.tiangolo.com/)

Gitcontainer is een door AI aangedreven webapplicatie die automatisch productieklare Dockerfiles genereert door GitHub-repository’s te analyseren. Plak eenvoudig een GitHub-URL en ontvang een op maat gemaakte Dockerfile met intelligente selectie van basisafbeeldingen, afhankelijkheidsbeheer en Docker best practices.

## 🌟 Snelle Toegang

Vervang simpelweg `github.com` door `gitcontainer.com` in elke GitHub-repository-URL om direct toegang te krijgen tot de Dockerfile-generatiepagina voor die repository.

Bijvoorbeeld:
```
https://github.com/username/repo  →  https://gitcontainer.com/username/repo
```

## ✨ Functies

- **🔄 Directe URL-toegang**: Vervang gewoon 'github.com' door 'gitcontainer.com' in elke GitHub-URL
- **🤖 AI-gedreven analyse**: Gebruikt OpenAI GPT-4 om de repository-structuur te analyseren en intelligente Dockerfiles te genereren
- **⚡ Real-time streaming**: Bekijk live hoe de AI je Dockerfile genereert via WebSocket-streaming
- **🎯 Slimme detectie**: Detecteert automatisch technologie-stacks (Python, Node.js, Java, Go, etc.)
- **🔧 Productieklaar**: Genereert Dockerfiles volgens best practices met goede beveiliging, multi-stage builds en optimalisatie
- **📋 Extra instructies**: Voeg aangepaste vereisten toe voor gespecialiseerde omgevingen
- **📄 Docker Compose**: Stelt automatisch een docker-compose.yml voor bij complexe applicaties
- **🎨 Moderne UI**: Schone, responsieve interface met Monaco-editor voor syntax highlighting
- **📱 Mobielvriendelijk**: Werkt naadloos op desktop en mobiele apparaten

## 🚀 Snelstart

### Vereisten

- Python 3.9 of hoger
- Git
- OpenAI API-sleutel

### Installatie

1. **Kloon de repository:**
   ```bash
   git clone https://github.com/cyclotruc/gitcontainer.git
   cd gitcontainer
   ```

2. **Installeer afhankelijkheden:**
   ```bash
   pip install -r requirements.txt
   ```

3. **Stel omgevingsvariabelen in:**
   ```bash
   # Maak .env-bestand aan
   echo "OPENAI_API_KEY=your_openai_api_key_here" > .env
   ```

4. **Start de applicatie:**
   ```bash
   python app.py
   ```

5. **Open je browser:**
   Ga naar `http://localhost:8000`

## 🛠️ Hoe Werkt Het

1. **URL-verwerking**: Toegang tot elke repository door 'github.com' te vervangen door 'gitcontainer.com' in de URL
2. **Repository klonen**: Gitcontainer kloont de GitHub-repository lokaal met Git
3. **Code-analyse**: Gebruikt [gitingest](https://github.com/cyclotruc/gitingest) om de repository-structuur te analyseren en relevante informatie te extraheren
4. **AI-generatie**: Stuurt de analyse naar OpenAI GPT-4 met gespecialiseerde prompts voor Dockerfile-generatie
5. **Slimme optimalisatie**: De AI houdt rekening met:
   - Detectie van technologie-stack
   - Afhankelijkheidsbeheer
   - Beveiligingsbest practices
   - Multi-stage builds waar nuttig
   - Poortconfiguratie
   - Omgevingsvariabelen
   - Health checks

## 📁 Projectstructuur

```
cyclotruc-gitcontainer/
├── app.py                 # Hoofd FastAPI-applicatie
├── requirements.txt       # Python-afhankelijkheden
├── .env                  # Omgevingsvariabelen (zelf aanmaken)
├── static/               # Statische assets (iconen, CSS)
├── templates/
│   └── index.jinja       # Hoofd HTML-template
└── tools/                # Kernfunctionaliteit modules
    ├── __init__.py
    ├── create_container.py  # AI Dockerfile-generatie
    ├── git_operations.py    # GitHub repository klonen
    └── gitingest.py        # Repository-analyse
```
## 🔧 Configuratie

### Omgevingsvariabelen

| Variabele | Beschrijving | Vereist |
|-----------|--------------|---------|
| `OPENAI_API_KEY` | Je OpenAI API-sleutel | Ja |
| `PORT` | Serverpoort (standaard: 8000) | Nee |
| `HOST` | Serverhost (standaard: 0.0.0.0) | Nee |

### Geavanceerd Gebruik

Je kunt de tools programmatisch gebruiken:

```python
from tools import clone_repo_tool, gitingest_tool, create_container_tool
import asyncio

async def generate_dockerfile(github_url):
    # Repository klonen
    clone_result = await clone_repo_tool(github_url)
    
    # Analyseren met gitingest
    analysis = await gitingest_tool(clone_result['local_path'])
    
    # Dockerfile genereren
    dockerfile = await create_container_tool(
        gitingest_summary=analysis['summary'],
        gitingest_tree=analysis['tree'],
        gitingest_content=analysis['content']
    )
    
    return dockerfile

# Gebruik
result = asyncio.run(generate_dockerfile("https://github.com/user/repo"))
print(result['dockerfile'])
```

## 🎨 Aanpassing

### Aangepaste Instructies Toevoegen

Gebruik de functie "Additional instructions" om de generatie aan te passen:

- `"Gebruik Alpine Linux voor een kleinere image-grootte"`
- `"Voeg Redis en PostgreSQL toe"`
- `"Optimaliseer voor productie-deployment"`
- `"Voeg ontwikkeltools toe voor debugging"`

## 📝 Licentie

Dit project is gelicentieerd onder de MIT-licentie - zie het [LICENSE](LICENSE) bestand voor details.

## 🙏 Dankbetuigingen

- **[OpenAI](https://openai.com/)** voor het leveren van de GPT-4 API
- **[gitingest](https://github.com/cyclotruc/gitingest)** voor repository-analyse mogelijkheden
- **[FastAPI](https://fastapi.tiangolo.com/)** voor het uitstekende webframework
- **[Monaco Editor](https://microsoft.github.io/monaco-editor/)** voor code syntax highlighting

## 🔗 Links

- **GitHub Repository**: [https://github.com/cyclotruc/gitcontainer](https://github.com/cyclotruc/gitcontainer)
- **Demo**: Probeer het live met voorbeeldrepositories
- **Issues**: [Meld bugs of vraag functies aan](https://github.com/cyclotruc/gitcontainer/issues)

---

**Gemaakt met ❤️ door [Romain Courtois](https://github.com/cyclotruc)**

*Maak van elke repository in seconden een container!*

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---
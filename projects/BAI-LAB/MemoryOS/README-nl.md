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

<h5 align="center"> 🎉 Als je ons project leuk vindt, geef ons dan een ster ⭐ op GitHub voor de laatste updates.</h5>
**MemoryOS** is ontworpen om een geheugenbesturingssysteem te bieden voor gepersonaliseerde AI-agenten, wat meer coherente, gepersonaliseerde en contextbewuste interacties mogelijk maakt. Geïnspireerd door geheugenbeheerprincipes uit besturingssystemen, hanteert het een hiërarchische opslagarchitectuur met vier kernmodules: Storage, Updating, Retrieval en Generation, om volledig en efficiënt geheugenbeheer te realiseren. Op de LoCoMo-benchmark behaalde het model gemiddelde verbeteringen van **49,11%** en **46,18%** in respectievelijk F1- en BLEU-1-scores.

## 📣 Laatste Nieuws
*   *<mark>[nieuw]</mark>* 🔥  **[2025-06-15]**:🛠️ Open-source **MemoryOS-MCP** uitgebracht! Nu configureerbaar op agent clients voor naadloze integratie en aanpassing. [👉 Bekijk](#memoryos_mcp-getting-started)
*   **[2025-05-30]**: Eerste versie van **MemoryOS** gelanceerd! Met korte-, middellange- en langetermijn persona-geheugen met automatische gebruikersprofiel- en kennisupdates.

## Demo
[![Bekijk de video](https://img.youtube.com/vi/y9Igs0FnX_M/maxresdefault.jpg)](https://youtu.be/y9Igs0FnX_M)

## 	Systeemarchitectuur
![image](https://github.com/user-attachments/assets/09200494-03a9-4b7d-9ffa-ef646d9d51f0)

## Projectstructuur

```
memoryos/
├── __init__.py            # Initialiseert het MemoryOS-pakket
├── __pycache__/           # Python cache directory (automatisch gegenereerd)
├── long_term.py           # Beheert langetermijn persona-geheugen (gebruikersprofiel, kennis)
├── memoryos.py            # Hoofdklasse voor MemoryOS, regisseert alle componenten
├── mid_term.py            # Beheert middellange termijn geheugen, consolideert korte termijn interacties
├── prompts.py             # Bevat prompts gebruikt voor LLM-interacties (zoals samenvatting, analyse)
├── retriever.py           # Haalt relevante informatie op uit alle geheugenniveaus
├── short_term.py          # Beheert korte termijn geheugen voor recente interacties
├── updater.py             # Verwerkt geheugenupdates, inclusief promotie van informatie tussen lagen
└── utils.py               # Hulpprogramma's gebruikt in de hele bibliotheek
```

## Hoe Werkt Het

1.  **Initialisatie:** `Memoryos` wordt geïnitieerd met gebruikers- en assistent-ID's, API-sleutels, gegevensopslagpaden en diverse capaciteit/drempel-instellingen. Het richt een speciale opslag in voor elke gebruiker en assistent.
2.  **Herinneringen Toevoegen:** Gebruikersinvoer en agentreacties worden toegevoegd als QA-paren. Deze worden aanvankelijk opgeslagen in het korte termijn geheugen.
3.  **Korte termijn naar middellange termijn verwerking:** Wanneer het korte termijn geheugen vol is, verwerkt de `Updater`-module deze interacties, consolideert ze tot betekenisvolle segmenten en slaat ze op in het middellange termijn geheugen.
4.  **Middellange termijn analyse & LPM-updates:** Middellange termijn geheugensegmenten verzamelen "heat" op basis van factoren zoals bezoekfrequentie en interactielengte. Wanneer de heat van een segment een drempel overschrijdt, wordt de inhoud geanalyseerd:
    *   Inzichten in het gebruikersprofiel worden geëxtraheerd en gebruikt om het langetermijn gebruikersprofiel bij te werken.
    *   Specifieke gebruikersfeiten worden toegevoegd aan de langetermijnkennis van de gebruiker.
    *   Relevante informatie voor de assistent wordt toegevoegd aan de langetermijnkennisbasis van de assistent.
5.  **Antwoordgeneratie:** Wanneer een gebruikersvraag wordt ontvangen:
    *   De `Retriever`-module haalt relevante context op uit korte termijn geschiedenis, middellange termijn geheugen, het gebruikersprofiel & kennis, en de kennisbasis van de assistent.
    *   Deze volledige context wordt vervolgens gebruikt, samen met de gebruikersvraag, om een coherent en geïnformeerd antwoord te genereren via een LLM.

## MemoryOS_PYPI Aan de Slag

### Vereisten

*   Python >= 3.10
*   pip install -i https://pypi.org/simple/ MemoryOS-BaiJia

### Installatie

```bash
conda create -n MemoryOS python=3.10
conda activate MemoryOS
pip install -i https://pypi.org/simple/ MemoryOS-BaiJia
```

### Basisgebruik

```python

import os
from memoryos import Memoryos

# --- Basisconfiguratie ---
USER_ID = "demo_user"
ASSISTANT_ID = "demo_assistant"
API_KEY = "JOUW_OPENAI_API_KEY"  # Vervang door je eigen sleutel
BASE_URL = ""  # Optioneel: als je een aangepaste OpenAI endpoint gebruikt
DATA_STORAGE_PATH = "./simple_demo_data"
LLM_MODEL = "gpt-4o-mini"

def simple_demo():
    print("MemoryOS Simpele Demo")
    
    # 1. Initialiseer MemoryOS
    print("Initialiseren van MemoryOS...")
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
        print("MemoryOS succesvol geïnitialiseerd!\n")
    except Exception as e:
        print(f"Fout: {e}")
        return

    # 2. Voeg enkele basisherinneringen toe
    print("Herinneringen toevoegen...")
    
    memo.add_memory(
        user_input="Hoi! Ik ben Tom, ik werk als data scientist in San Francisco.",
        agent_response="Hallo Tom! Leuk je te ontmoeten. Data science is zo'n spannend vakgebied. Met wat voor data werk je?"
    )
     
    test_query = "Wat weet je nog over mijn baan?"
    print(f"Gebruiker: {test_query}")
    
    response = memo.get_response(
        query=test_query,
    )
    
    print(f"Assistent: {response}")

if __name__ == "__main__":
    simple_demo()
```
## MemoryOS-MCP Aan de Slag
### 🔧 Kernhulpmiddelen

#### 1. `add_memory`
Slaat de inhoud van het gesprek tussen de gebruiker en de AI-assistent op in het geheugensysteem, met als doel een blijvende dialooggeschiedenis en contextueel record op te bouwen.

#### 2. `retrieve_memory`
Haalt gerelateerde historische dialogen, gebruikersvoorkeuren en kennisinformatie op uit het geheugensysteem op basis van een query, zodat de AI-assistent de behoeften en achtergrond van de gebruiker kan begrijpen.

#### 3. `get_user_profile`
Verkrijgt een gebruikersprofiel dat is gegenereerd uit de analyse van historische dialogen, inclusief persoonlijkheidskenmerken, interessevoorkeuren en relevante kennisachtergrond van de gebruiker.

### 1. Installeer afhankelijkheden
```bash
cd memoryos-mcp
pip install -r requirements.txt
```
### 2. Configuratie

Bewerk `config.json`：
```json
{
  "user_id": "jouw gebruikersID",
  "openai_api_key": "jouw OpenAI API-sleutel",
  "openai_base_url": "https://api.openai.com/v1",
  "data_storage_path": "./memoryos_data",
  "assistant_id": "assistant_id",
  "llm_model": "gpt-4o-mini"
}
```
### 3. Start de server
```bash
python server_new.py --config config.json
```
### 4. Test
```bash
python test_comprehensive.py
```
### 5. Configureer op Cline en andere clients
Kopieer het mcp.json-bestand en zorg dat het pad naar het bestand correct is.
```bash
command": "/root/miniconda3/envs/memos/bin/python"
#Dit moet worden aangepast naar de Python-interpreter van jouw virtuele omgeving
```
## Bijdragen

Bijdragen zijn welkom! Dien gerust issues of pull requests in.

## Citeren
Als je meer details wilt lezen, klik dan hier: [Lees het volledige artikel](https://arxiv.org/abs/2506.06326)

Als je dit project nuttig vindt, overweeg dan ons artikel te citeren:

```bibtex
@misc{kang2025memoryosaiagent,
      title={Memory OS of AI Agent}, 
      author={Jiazheng Kang en Mingming Ji en Zhe Zhao en Ting Bai},
      year={2025},
      eprint={2506.06326},
```
## Contact opnemen
BAI-AI is een onderzoeksgroep onder leiding van universitair hoofddocent Bai Ting aan de Beijing University of Posts and Telecommunications, toegewijd aan het creëren van een emotioneel rijk en buitengewoon geheugen voor silicium-gebaseerde mensen.<br>
Samenwerking & suggesties: baiting@bupt.edu.cn<br>
Volg de BAI-Agent WeChat-publieke account en de WeChat-groep voor gezamenlijke uitwisseling!  
<div style="display: flex; justify-content: center; gap: 20px;">
  <img src="https://github.com/user-attachments/assets/42651f49-f1f7-444d-9455-718e13ed75e9" alt="BAI-Agent WeChat-publieke account" width="250"/>
  <img src="https://github.com/user-attachments/assets/6b15a873-9e9a-44ee-b0b3-64f488fbd5d8" alt="WeChat-groep QR-code" width="300"/>
</div>
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---
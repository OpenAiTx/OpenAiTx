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

<h5 align="center"> 🎉 Se ti piace il nostro progetto, per favore lasciaci una stella ⭐ su GitHub per rimanere aggiornato.</h5>
**MemoryOS** è progettato per fornire un sistema operativo di memoria per agenti AI personalizzati, consentendo interazioni più coerenti, personalizzate e consapevoli del contesto. Ispirato ai principi di gestione della memoria dei sistemi operativi, adotta un’architettura di archiviazione gerarchica con quattro moduli principali: Storage, Updating, Retrieval e Generation, per ottenere una gestione della memoria completa ed efficiente. Sulla benchmark LoCoMo, il modello ha raggiunto miglioramenti medi di **49.11%** e **46.18%** nei punteggi F1 e BLEU-1.

## 📣 Ultime Novità
*   *<mark>[nuovo]</mark>* 🔥  **[2025-06-15]**:🛠️ Rilasciato in open-source **MemoryOS-MCP**! Ora configurabile sui client agente per un’integrazione e personalizzazione senza soluzione di continuità. [👉 Visualizza](#memoryos_mcp-getting-started)
*   **[2025-05-30]**: Versione iniziale di **MemoryOS** lanciata! Con memoria persona di breve, medio e lungo termine e aggiornamento automatico del profilo utente e della conoscenza.

## Demo
[![Guarda il video](https://img.youtube.com/vi/y9Igs0FnX_M/maxresdefault.jpg)](https://youtu.be/y9Igs0FnX_M)

## 	Architettura di Sistema
![image](https://github.com/user-attachments/assets/09200494-03a9-4b7d-9ffa-ef646d9d51f0)

## Struttura del Progetto

```
memoryos/
├── __init__.py            # Inizializza il pacchetto MemoryOS
├── __pycache__/           # Directory cache di Python (generata automaticamente)
├── long_term.py           # Gestisce la memoria persona a lungo termine (profilo utente, conoscenza)
├── memoryos.py            # Classe principale per MemoryOS, orchestra tutti i componenti
├── mid_term.py            # Gestisce la memoria a medio termine, consolidando le interazioni a breve termine
├── prompts.py             # Contiene i prompt utilizzati per le interazioni LLM (es. sintesi, analisi)
├── retriever.py           # Recupera informazioni rilevanti da tutti i livelli di memoria
├── short_term.py          # Gestisce la memoria a breve termine per le interazioni recenti
├── updater.py             # Elabora gli aggiornamenti di memoria, inclusa la promozione delle informazioni tra i livelli
└── utils.py               # Funzioni di utilità usate in tutta la libreria
```

## Come Funziona

1.  **Inizializzazione:** `Memoryos` viene inizializzato con ID utente e assistente, API key, percorsi di archiviazione dati e varie impostazioni di capacità/soglia. Configura un’archiviazione dedicata per ogni utente e assistente.
2.  **Aggiunta di Memorie:** Gli input degli utenti e le risposte dell’agente vengono aggiunti come coppie QA. Queste vengono inizialmente memorizzate nella memoria a breve termine.
3.  **Processo da Breve a Medio Termine:** Quando la memoria a breve termine è piena, il modulo `Updater` elabora queste interazioni, consolidandole in segmenti significativi e archiviandoli nella memoria a medio termine.
4.  **Analisi a Medio Termine & Aggiornamenti LPM:** I segmenti di memoria a medio termine accumulano “calore” in base a fattori come frequenza di visita e durata dell’interazione. Quando il calore di un segmento supera una soglia, il suo contenuto viene analizzato:
    *   Vengono estratti insight sul profilo utente e utilizzati per aggiornare il profilo utente a lungo termine.
    *   Fatti specifici dell’utente vengono aggiunti alla conoscenza a lungo termine dell’utente.
    *   Informazioni rilevanti per l’assistente vengono aggiunte alla base di conoscenza a lungo termine dell’assistente.
5.  **Generazione della Risposta:** Quando viene ricevuta una query utente:
    *   Il modulo `Retriever` recupera il contesto rilevante dalla cronologia a breve termine, dai segmenti di memoria a medio termine, dal profilo e dalla conoscenza dell’utente, e dalla base di conoscenza dell’assistente.
    *   Questo contesto completo viene poi utilizzato, insieme alla query dell’utente, per generare una risposta coerente e informata tramite un LLM.

## MemoryOS_PYPI Guida Rapida

### Prerequisiti

*   Python >= 3.10
*   pip install -i https://pypi.org/simple/ MemoryOS-BaiJia

### Installazione

```bash
conda create -n MemoryOS python=3.10
conda activate MemoryOS
pip install -i https://pypi.org/simple/ MemoryOS-BaiJia
```

### Utilizzo Base

```python

import os
from memoryos import Memoryos

# --- Configurazione di Base ---
USER_ID = "demo_user"
ASSISTANT_ID = "demo_assistant"
API_KEY = "YOUR_OPENAI_API_KEY"  # Sostituisci con la tua chiave
BASE_URL = ""  # Facoltativo: se usi un endpoint OpenAI personalizzato
DATA_STORAGE_PATH = "./simple_demo_data"
LLM_MODEL = "gpt-4o-mini"

def simple_demo():
    print("MemoryOS Demo Semplice")
    
    # 1. Inizializza MemoryOS
    print("Inizializzazione di MemoryOS...")
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
        print("MemoryOS inizializzato con successo!\n")
    except Exception as e:
        print(f"Errore: {e}")
        return

    # 2. Aggiungi alcune memorie di base
    print("Aggiunta di alcune memorie...")
    
    memo.add_memory(
        user_input="Ciao! Sono Tom, lavoro come data scientist a San Francisco.",
        agent_response="Ciao Tom! Piacere di conoscerti. La data science è un campo davvero entusiasmante. Che tipo di dati tratti?"
    )
     
    test_query = "Cosa ricordi riguardo al mio lavoro?"
    print(f"Utente: {test_query}")
    
    response = memo.get_response(
        query=test_query,
    )
    
    print(f"Assistente: {response}")

if __name__ == "__main__":
    simple_demo()
```
## MemoryOS-MCP Guida Rapida
### 🔧 Strumenti Principali

#### 1. `add_memory`
Salva il contenuto della conversazione tra l’utente e l’assistente AI nel sistema di memoria, al fine di costruire una cronologia di dialogo persistente e un registro contestuale.

#### 2. `retrieve_memory`
Recupera dialoghi storici correlati, preferenze utente e informazioni di conoscenza dal sistema di memoria sulla base di una query, aiutando l’assistente AI a comprendere le esigenze e il background dell’utente.

#### 3. `get_user_profile`
Ottiene un profilo utente generato dall’analisi dei dialoghi storici, incluse le caratteristiche di personalità dell’utente, le preferenze di interesse e il background di conoscenze rilevanti.


### 1. Installa le dipendenze
```bash
cd memoryos-mcp
pip install -r requirements.txt
```
### 2. configurazione

Modifica `config.json`：
```json
{
  "user_id": "il tuo user ID",
  "openai_api_key": "la tua chiave API OpenAI",
  "openai_base_url": "https://api.openai.com/v1",
  "data_storage_path": "./memoryos_data",
  "assistant_id": "assistant_id",
  "llm_model": "gpt-4o-mini"
}
```
### 3. Avvia il server
```bash
python server_new.py --config config.json
```
### 4. Test
```bash
python test_comprehensive.py
```
### 5. Configuralo su Cline e altri client
Copia il file mcp.json e assicurati che il percorso del file sia corretto.
```bash
command": "/root/miniconda3/envs/memos/bin/python"
#Questo deve essere cambiato con l’interprete Python del tuo ambiente virtuale
```
## Contribuire

Contributi sono benvenuti! Sentiti libero di inviare issue o pull request.

## Citazione
Se desideri leggere più dettagli, clicca qui: [Leggi l’articolo completo](https://arxiv.org/abs/2506.06326)

Se trovi utile questo progetto, considera di citare il nostro articolo:

```bibtex
@misc{kang2025memoryosaiagent,
      title={Memory OS of AI Agent}, 
      author={Jiazheng Kang and Mingming Ji and Zhe Zhao and Ting Bai},
      year={2025},
      eprint={2506.06326},
```
## Contattaci
BAI AI è un gruppo di ricerca guidato dalla Professoressa Associata Bai Ting dell'Università di Posta e Telecomunicazioni di Pechino, impegnato nella creazione di un cervello ricco di emozioni e con una memoria straordinaria per gli esseri umani al silicio.<br>
Collaborazioni e suggerimenti: baiting@bupt.edu.cn<br>
Seguici sul nostro account ufficiale WeChat 百家Agent e nel gruppo WeChat per condividere e scambiare idee insieme!  
<div style="display: flex; justify-content: center; gap: 20px;">
  <img src="https://github.com/user-attachments/assets/42651f49-f1f7-444d-9455-718e13ed75e9" alt="百家Agent account ufficiale" width="250"/>
  <img src="https://github.com/user-attachments/assets/6b15a873-9e9a-44ee-b0b3-64f488fbd5d8" alt="QRCode gruppo WeChat" width="300"/>
</div>
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---